
// Type: SAP2012.Ene7




using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;

namespace SAP2012
{
  public class Ene7
  {
    private SAP_Module.Dwelling _House;
    private SAP_Module.Dwelling _SHouse;
    private Calc2012 _SCalc;
    private SAP_Module.Dwelling _ActualHouse;
    private Calc2012 _ACalc;
    private Ene7.Ene7_Calc _Calc;

    public SAP_Module.Dwelling Dwelling
    {
      set
      {
        this._House = value;
        SAP_Module.CalcRound = false;
        this.Calc();
      }
    }

    private void Calc()
    {
      try
      {
        SAP_Module.CalcRound = false;
        this._Calc = new Ene7.Ene7_Calc();
        this.Get_SHouse();
        if (!this._House.OverrideEne7)
        {
          this._ActualHouse = Functions.CopyDwelling(this._SHouse);
          this.CheckforRenewables();
          this._ACalc = new Calc2012();
          SAP_Module.CalcAssessmentLZCPlease = true;
          this._ACalc.DTER = true;
          this._ACalc.Dwelling = this._ActualHouse;
        }
        this._SCalc = new Calc2012();
        SAP_Module.CalcAssessmentLZCPlease = true;
        this._SCalc.DTER = true;
        this._SCalc.Dwelling = this._SHouse;
        this.StandardCalc();
        this.ActualCalc();
        this.Saving();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) ex.Message);
        ProjectData.ClearProjectError();
      }
      SAP_Module.CalcRound = true;
    }

    private void StandardCalc() => this._Calc.Part1.P1 = this._SCalc.Calculation.AssessmentLZC2012.ZC8;

    private void ActualCalc() => this._Calc.Part2.P2 = !this._House.OverrideEne7 ? this._ACalc.Calculation.AssessmentLZC2012.ZC8 : SAP_Module.CalcualtionDER2012.Calculation.AssessmentLZC2012.ZC8;

    private void Saving() => this._Calc.P3 = (1.0 - this._Calc.Part2.P2 / this._Calc.Part1.P1) * 100.0;

    private void CheckforRenewables()
    {
      string sgroup = this._House.MainHeating.SGroup;
      if (Operators.CompareString(sgroup, "Micro-cogeneration (micro-CHP)", false) == 0 || Operators.CompareString(sgroup, "Heat pumps", false) == 0)
      {
        this._ActualHouse.MainHeating = this._House.MainHeating;
        this._ActualHouse.Water = this._House.Water;
      }
      this._ActualHouse.Renewable = this._House.Renewable;
      this._ActualHouse.Water.Solar = this._House.Water.Solar;
      if (!(!this._ActualHouse.Water.Solar.SolarSeperate & this._ActualHouse.Water.Solar.Inlcude))
        return;
      this._ActualHouse.Water.Cylinder.Volume = this._House.Water.Cylinder.Volume;
    }

    private void Get_SHouse()
    {
      try
      {
        this._SHouse = Functions.CopyDwelling(this._House);
        ref SAP_Module.Dwelling local = ref this._SHouse;
        string electricityTariff = local.MainHeating.ElectricityTariff;
        local.MainHeating = new SAP_Module.MainHeating();
        local.MainHeating.Boiler.PumpType = "";
        local.MainHeating.Fuel = "mains gas";
        local.MainHeating.InforSource = "Manufacturer Declaration";
        local.MainHeating.SAPTableCode = 102;
        local.MainHeating.MainEff = 88f;
        local.MainHeating.Emitter = "Systems with radiators";
        local.MainHeating.Controls = "Programmer, room thermostat and TRVs";
        local.MainHeating.ControlCode = 2106;
        local.MainHeating.Boiler.PumpHP = "Yes";
        local.MainHeating.Boiler.BILock = "Yes";
        local.MainHeating.Boiler.FlueType = "Room-sealed";
        local.MainHeating.Boiler.FanFlued = "Yes";
        local.MainHeating.Boiler.Description = "";
        local.MainHeating.Boiler.KeepHotFuel = "";
        local.MainHeating.FuelBurningType = "On/off";
        local.MainHeating.BSubGroup = "";
        local.MainHeating.Compensator = "";
        local.MainHeating.ElectricityTariff = electricityTariff;
        local.MainHeating.BSubGroup = "Gas boilers (including LPG) 1998 or later";
        local.MainHeating.HGroup = "Boiler systems with radiators or underfloor heating";
        local.MainHeating.MHType = "Regular condensing with automatic ignition";
        local.MainHeating.SGroup = "Gas boilers and oil boilers";
        if ((uint) local.SecHeating.SAPTableCode > 0U)
        {
          local.SecHeating.Fuel = "Electricity";
          local.SecHeating.SAPTableCode = 692;
          local.SecHeating.SecEff = 100f;
        }
        local.Water = new SAP_Module.Water();
        local.Water.Fuel = "mains gas";
        local.Water.System = "From main heating system";
        local.Water.SystemRef = 901;
        local.Water.Cylinder.Volume = 150f;
        local.Water.Cylinder.ManuSpecified = false;
        local.Water.Cylinder.Insulation = "Factory";
        local.Water.Cylinder.InsThick = 35f;
        local.Water.Cylinder.PipeWorkInsulated = true;
        local.Water.Cylinder.Timed = true;
        local.Water.Cylinder.Thermostat = true;
        local.Water.Cylinder.InHeatedSpace = true;
        local.Water.Solar.Inlcude = false;
        local.Renewable.AAEGeneration.Inlcude = false;
        local.Renewable.Photovoltaic.Inlcude = false;
        local.Renewable.Special.Include = false;
        local.Renewable.WindTurbine.Inlcude = false;
        local.Renewable.HydroGeneration.Inlcude = false;
        int num1 = checked (local.NoofWindows - 1);
        int index1 = 0;
        while (index1 <= num1)
        {
          if (Operators.CompareString(local.Windows[index1].Overshading, "Very Little", false) == 0)
            local.Windows[index1].Overshading = "Average or unknown";
          checked { ++index1; }
        }
        int num2 = checked (local.NoofRoofLights - 1);
        int index2 = 0;
        while (index2 <= num2)
        {
          if (Operators.CompareString(local.RoofLights[index2].Overshading, "Very Little", false) == 0)
            local.RoofLights[index2].Overshading = "Average or unknown";
          checked { ++index2; }
        }
        if ((double) local.LowEnergyLight >= 30.0)
          return;
        local.LowEnergyLight = 30f;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) ex.Message);
        ProjectData.ClearProjectError();
      }
    }

    public Ene7.Ene7_Calc Ene7_ => this._Calc;

    public class Ene7_Calc
    {
      private double _P3;
      private Ene7.Ene7_Calc.StandardCase _Part1;
      private Ene7.Ene7_Calc.ActualCase _Part2;

      public Ene7_Calc()
      {
        this._Part1 = new Ene7.Ene7_Calc.StandardCase();
        this._Part2 = new Ene7.Ene7_Calc.ActualCase();
      }

      public double P3
      {
        get => !SAP_Module.CalcRound ? this._P3 : Math.Round(this._P3, SAP_Module.RoundFigure);
        set => this._P3 = value;
      }

      public Ene7.Ene7_Calc.StandardCase Part1 => this._Part1;

      public Ene7.Ene7_Calc.ActualCase Part2 => this._Part2;

      public class StandardCase
      {
        private double _P1;

        public double P1
        {
          get => !SAP_Module.CalcRound ? this._P1 : Math.Round(this._P1, SAP_Module.RoundFigure);
          set => this._P1 = value;
        }
      }

      public class ActualCase
      {
        private double _P2;

        public double P2
        {
          get => !SAP_Module.CalcRound ? this._P2 : Math.Round(this._P2, SAP_Module.RoundFigure);
          set => this._P2 = value;
        }
      }
    }
  }
}
