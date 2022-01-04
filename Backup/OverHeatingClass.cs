
// Type: SAP2012.OverHeatingClass




using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;

namespace SAP2012
{
  public class OverHeatingClass
  {
    private SAP_Module.Dwelling _House;
    private bool _CalcComplete;
    private AppendixP _AppendixP;
    public Openings[] OpeningsJune;
    public Openings[] OpeningsJuly;
    public Openings[] OpeningsAug;
    private DataTable P5;
    private DataTable P6;
    public double Tmass;
    public double Tsummer;

    public OverHeatingClass() => this._AppendixP = new AppendixP();

    [ReadOnly(true)]
    public AppendixP AppendixP => this._AppendixP;

    public SAP_Module.Dwelling Dwelling
    {
      set
      {
        this._House = value;
        this._AppendixP = new AppendixP();
        SAP_Module.CalcRound = false;
        this.Calc();
      }
    }

    private void Calc()
    {
      try
      {
        this.P1();
        this.P3();
        this._CalcComplete = true;
        SAP_Module.CalcRound = true;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this._CalcComplete = false;
        ProjectData.ClearProjectError();
      }
    }

    private void P1()
    {
      AppendixP appendixP = this.AppendixP;
      appendixP.P1 = 0.33 * (double) this._House.OverHeating.EACAirChange * SAP_Module.Calculation2012.Calculation.Dimensions.Box5;
      appendixP.P2 = appendixP.P1 + SAP_Module.Calculation2012.Calculation.HeatLoss.Box37;
    }

    private void P3()
    {
      Internal_gains2012 internalGains2012 = new Internal_gains2012();
      Solar_gains2012 solarGains2012 = new Solar_gains2012();
      Mean_Int_Temp2012 meanIntTemp2012 = new Mean_Int_Temp2012();
      Space_heating_requirement2012 heatingRequirement2012 = new Space_heating_requirement2012();
      internalGains2012.Box66_m.M6 = 60.0 * SAP_Module.Calculation2012.Calculation.Water_heating.Box42;
      internalGains2012.Box66_m.M7 = 60.0 * SAP_Module.Calculation2012.Calculation.Water_heating.Box42;
      internalGains2012.Box66_m.M8 = 60.0 * SAP_Module.Calculation2012.Calculation.Water_heating.Box42;
      internalGains2012.Box67_m.M6 = SAP_Module.Calculation2012.Calculation.Internal_gains.AppendixL.ELm.M6 * 0.85 * 1000.0 / (24.0 * SAP_Module.Calculation2012.Calculation.HeatLoss.Box41_m.M6);
      internalGains2012.Box67_m.M7 = SAP_Module.Calculation2012.Calculation.Internal_gains.AppendixL.ELm.M7 * 0.85 * 1000.0 / (24.0 * SAP_Module.Calculation2012.Calculation.HeatLoss.Box41_m.M7);
      internalGains2012.Box67_m.M8 = SAP_Module.Calculation2012.Calculation.Internal_gains.AppendixL.ELm.M8 * 0.85 * 1000.0 / (24.0 * SAP_Module.Calculation2012.Calculation.HeatLoss.Box41_m.M8);
      internalGains2012.Box68_m.M6 = SAP_Module.Calculation2012.Calculation.Internal_gains.AppendixLAppliaces.EAm.M6 * 1000.0 / (24.0 * SAP_Module.Calculation2012.Calculation.HeatLoss.Box41_m.M6);
      internalGains2012.Box68_m.M7 = SAP_Module.Calculation2012.Calculation.Internal_gains.AppendixLAppliaces.EAm.M7 * 1000.0 / (24.0 * SAP_Module.Calculation2012.Calculation.HeatLoss.Box41_m.M7);
      internalGains2012.Box68_m.M8 = SAP_Module.Calculation2012.Calculation.Internal_gains.AppendixLAppliaces.EAm.M8 * 1000.0 / (24.0 * SAP_Module.Calculation2012.Calculation.HeatLoss.Box41_m.M8);
      internalGains2012.Box69_m.M6 = 35.0 + 7.0 * SAP_Module.Calculation2012.Calculation.Water_heating.Box42;
      internalGains2012.Box69_m.M7 = 35.0 + 7.0 * SAP_Module.Calculation2012.Calculation.Water_heating.Box42;
      internalGains2012.Box69_m.M8 = 35.0 + 7.0 * SAP_Module.Calculation2012.Calculation.Water_heating.Box42;
      float num1;
      float num2;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this._House.MainHeating.InforSource, "Boiler Database", false) == 0)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this._House.MainHeating.Boiler.PumpHP, "Yes", false) == 0)
          num2 = num1 + 10f;
      }
      else
      {
        int sapTableCode = this._House.MainHeating.SAPTableCode;
        if (sapTableCode < 300)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this._House.MainHeating.Boiler.PumpHP, "Yes", false) == 0)
            num2 = num1 + 10f;
        }
        else if (sapTableCode >= 500 && sapTableCode <= 600 && !this._House.Ventilation.MechVent.ToString().Contains("Balanced"))
          num2 = num1 + (float) (0.06 * SAP_Module.Calculation2012.Calculation.Dimensions.Box5);
      }
      string mechVent = this._House.Ventilation.MechVent;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(mechVent, "Positive input from outside", false) != 0)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(mechVent, "Balanced without heat recovery", false) == 0)
        {
          string parameters = this._House.Ventilation.Parameters;
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(parameters, "User defined", false) != 0)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(parameters, "SAP 2005", false) == 0)
              num2 += (float) (0.06 * SAP_Module.Calculation2012.Calculation.Dimensions.Box5 * 2.5 * 2.0);
          }
          else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this._House.Ventilation.MVDetails.DuctingType, "Rigid", false) == 0)
            num2 += (float) (0.06 * SAP_Module.Calculation2012.Calculation.Dimensions.Box5 * (double) this._House.Ventilation.MVDetails.SFP * 1.4);
          else
            num2 += (float) (0.06 * SAP_Module.Calculation2012.Calculation.Dimensions.Box5 * (double) this._House.Ventilation.MVDetails.SFP * 1.7);
        }
      }
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this._House.Ventilation.Parameters, "SAP 2005", false) == 0)
        num2 += (float) (0.096 * SAP_Module.Calculation2012.Calculation.Dimensions.Box5 * 2.5);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this._House.MainHeating.Fuel, "heating oil", false) == 0 & this._House.MainHeating.OilPump)
        num1 = num2 + 10f;
      internalGains2012.Box70_m.M6 = 0.0;
      internalGains2012.Box70_m.M7 = 0.0;
      internalGains2012.Box70_m.M8 = 0.0;
      internalGains2012.Box71_m.M6 = -40.0 * SAP_Module.Calculation2012.Calculation.Water_heating.Box42;
      internalGains2012.Box71_m.M7 = -40.0 * SAP_Module.Calculation2012.Calculation.Water_heating.Box42;
      internalGains2012.Box71_m.M8 = -40.0 * SAP_Module.Calculation2012.Calculation.Water_heating.Box42;
      internalGains2012.Box72_m.M6 = 1000.0 * SAP_Module.Calculation2012.Calculation.Water_heating.Box65_m.M6 / (SAP_Module.Calculation2012.Calculation.HeatLoss.Box41_m.M6 * 24.0);
      internalGains2012.Box72_m.M7 = 1000.0 * SAP_Module.Calculation2012.Calculation.Water_heating.Box65_m.M7 / (SAP_Module.Calculation2012.Calculation.HeatLoss.Box41_m.M7 * 24.0);
      internalGains2012.Box72_m.M8 = 1000.0 * SAP_Module.Calculation2012.Calculation.Water_heating.Box65_m.M8 / (SAP_Module.Calculation2012.Calculation.HeatLoss.Box41_m.M8 * 24.0);
      internalGains2012.Box73_m.M6 = internalGains2012.Box66_m.M6 + internalGains2012.Box67_m.M6 + internalGains2012.Box68_m.M6 + internalGains2012.Box69_m.M6 + internalGains2012.Box70_m.M6 + internalGains2012.Box71_m.M6 + internalGains2012.Box72_m.M6;
      internalGains2012.Box73_m.M7 = internalGains2012.Box66_m.M7 + internalGains2012.Box67_m.M7 + internalGains2012.Box68_m.M7 + internalGains2012.Box69_m.M7 + internalGains2012.Box70_m.M7 + internalGains2012.Box71_m.M7 + internalGains2012.Box72_m.M7;
      internalGains2012.Box73_m.M8 = internalGains2012.Box66_m.M8 + internalGains2012.Box67_m.M8 + internalGains2012.Box68_m.M8 + internalGains2012.Box69_m.M8 + internalGains2012.Box70_m.M8 + internalGains2012.Box71_m.M8 + internalGains2012.Box72_m.M8;
      PCDF.RegionalData regionalData = SAP_Module.PCDFData.AppendixU.Where<PCDF.RegionalData>((Func<PCDF.RegionalData, bool>) (b => b.Region.ToUpper().Equals(this._House.Location.ToUpper()))).SingleOrDefault<PCDF.RegionalData>();
      this.OpeningsJune = new Openings[0];
      this.OpeningsJuly = new Openings[0];
      this.OpeningsAug = new Openings[0];
      int num3 = checked (this._House.NoofWindows - 1);
      int index1 = 0;
      while (index1 <= num3)
      {
        // ISSUE: variable of a reference type
        Openings[]& local;
        // ISSUE: explicit reference operation
        Openings[] openingsArray = (Openings[]) Utils.CopyArray((Array) ^(local = ref this.OpeningsJune), (Array) new Openings[checked (this.OpeningsJune.Length + 1)]);
        local = openingsArray;
        this.OpeningsJune[checked (this.OpeningsJune.Length - 1)] = new Openings();
        Openings openings = this.OpeningsJune[checked (this.OpeningsJune.Length - 1)];
        openings.Zo = this.Overhang(this._House.Windows[index1]);
        openings.Zb = this.Shading(this._House.Windows[index1].CurtainType, index1, true);
        openings.Z = this.SAF(this._House.Windows[index1]);
        openings.Zs = openings.Zb * (openings.Z + openings.Zo - 1.0);
        openings.Aw = (double) this._House.Windows[index1].Area * (double) this._House.Windows[index1].Count;
        openings.S = this.SolarFlux(6, index1, true);
        openings.gt = (double) this._House.Windows[index1].g;
        openings.FF = (double) this._House.Windows[index1].FF;
        openings.Gs = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this._House.Windows[index1].UValueSource, "BFRC", false) != 0 ? 0.9 * openings.Aw * openings.S * openings.gt * openings.FF * openings.Zs : openings.Aw * openings.S * openings.gt * openings.Zs;
        checked { ++index1; }
      }
      int num4 = checked (this._House.NoofRoofLights - 1);
      int index2 = 0;
      while (index2 <= num4)
      {
        // ISSUE: variable of a reference type
        Openings[]& local;
        // ISSUE: explicit reference operation
        Openings[] openingsArray = (Openings[]) Utils.CopyArray((Array) ^(local = ref this.OpeningsJune), (Array) new Openings[checked (this.OpeningsJune.Length + 1)]);
        local = openingsArray;
        this.OpeningsJune[checked (this.OpeningsJune.Length - 1)] = new Openings();
        Openings openings = this.OpeningsJune[checked (this.OpeningsJune.Length - 1)];
        openings.Zo = this.Overhang(this._House.RoofLights[index2]);
        openings.Zb = this.Shading(this._House.RoofLights[index2].CurtainType, index2, false);
        openings.Z = 1.0;
        openings.Zs = openings.Zb * (openings.Z + openings.Zo - 1.0);
        openings.Aw = (double) this._House.RoofLights[index2].Area * (double) this._House.RoofLights[index2].Count;
        openings.S = this.SolarFlux(6, index2, false);
        openings.gt = (double) this._House.RoofLights[index2].g;
        openings.FF = (double) this._House.RoofLights[index2].FF;
        openings.Gs = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this._House.RoofLights[index2].UValueSource, "", false) != 0 ? 0.9 * openings.Aw * openings.S * openings.gt * openings.FF * openings.Zs : openings.Aw * openings.S * openings.gt * openings.Zs;
        checked { ++index2; }
      }
      int num5 = Information.UBound((Array) this.OpeningsJune);
      int index3 = 0;
      while (index3 <= num5)
      {
        Months p3;
        double num6 = (p3 = this.AppendixP.P3).M6 + this.OpeningsJune[index3].Gs;
        p3.M6 = num6;
        checked { ++index3; }
      }
      this.AppendixP.P5.M6 = !this._House.Water.Cylinder.SummerImmersion ? this.AppendixP.P3.M6 + internalGains2012.Box73_m.M6 : this.AppendixP.P3.M6 + internalGains2012.Box73_m.M6;
      this.AppendixP.P6.M6 = this.AppendixP.P5.M6 / this.AppendixP.P2;
      this.Tsummer = regionalData.TableU1.M6;
      this.Tmass = SAP_Module.Calculation2012.Calculation.HeatLoss.Box35 >= 285.0 ? 0.0 : 2.0 - 0.007 * SAP_Module.Calculation2012.Calculation.HeatLoss.Box35;
      if (this._House.OverHeating.Night && SAP_Module.Calculation2012.Calculation.HeatLoss.Box35 > 285.0)
      {
        // ISSUE: variable of a reference type
        double& local;
        // ISSUE: explicit reference operation
        double num7 = ^(local = ref this.Tmass) - 0.002 * (SAP_Module.Calculation2012.Calculation.HeatLoss.Box35 - 285.0);
        local = num7;
      }
      this.AppendixP.P7.M6 = this.AppendixP.P6.M6 + this.Tsummer + this.Tmass;
      double m6 = this.AppendixP.P7.M6;
      if (m6 < 20.5)
        this.AppendixP.Likelihood_June = "Not significant";
      else if (m6 >= 20.5 && m6 <= 22.0 / 1.0)
        this.AppendixP.Likelihood_June = "Slight";
      else if (m6 >= 22.0 && m6 <= 47.0 / 2.0)
        this.AppendixP.Likelihood_June = "Medium";
      else if (m6 > 47.0 / 2.0)
        this.AppendixP.Likelihood_June = "High";
      int num8 = checked (this._House.NoofWindows - 1);
      int index4 = 0;
      while (index4 <= num8)
      {
        // ISSUE: variable of a reference type
        Openings[]& local;
        // ISSUE: explicit reference operation
        Openings[] openingsArray = (Openings[]) Utils.CopyArray((Array) ^(local = ref this.OpeningsJuly), (Array) new Openings[checked (this.OpeningsJuly.Length + 1)]);
        local = openingsArray;
        this.OpeningsJuly[checked (this.OpeningsJuly.Length - 1)] = new Openings();
        Openings openings = this.OpeningsJuly[checked (this.OpeningsJuly.Length - 1)];
        openings.Zo = this.Overhang(this._House.Windows[index4]);
        openings.Zb = this.Shading(this._House.Windows[index4].CurtainType, index4, true);
        openings.Z = this.SAF(this._House.Windows[index4]);
        openings.Zs = openings.Zb * (openings.Z + openings.Zo - 1.0);
        openings.Aw = (double) this._House.Windows[index4].Area * (double) this._House.Windows[index4].Count;
        openings.S = this.SolarFlux(7, index4, true);
        openings.gt = (double) this._House.Windows[index4].g;
        openings.FF = (double) this._House.Windows[index4].FF;
        openings.Gs = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this._House.Windows[index4].UValueSource, "BFRC", false) != 0 ? 0.9 * openings.Aw * openings.S * openings.gt * openings.FF * openings.Zs : openings.Aw * openings.S * openings.gt * openings.Zs;
        checked { ++index4; }
      }
      int num9 = checked (this._House.NoofRoofLights - 1);
      int index5 = 0;
      while (index5 <= num9)
      {
        // ISSUE: variable of a reference type
        Openings[]& local;
        // ISSUE: explicit reference operation
        Openings[] openingsArray = (Openings[]) Utils.CopyArray((Array) ^(local = ref this.OpeningsJuly), (Array) new Openings[checked (this.OpeningsJuly.Length + 1)]);
        local = openingsArray;
        this.OpeningsJuly[checked (this.OpeningsJuly.Length - 1)] = new Openings();
        Openings openings = this.OpeningsJuly[checked (this.OpeningsJuly.Length - 1)];
        openings.Zo = this.Overhang(this._House.RoofLights[index5]);
        openings.Zb = this.Shading(this._House.RoofLights[index5].CurtainType, index5, false);
        openings.Z = 1.0;
        openings.Zs = openings.Zb * (openings.Z + openings.Zo - 1.0);
        openings.Aw = (double) this._House.RoofLights[index5].Area * (double) this._House.RoofLights[index5].Count;
        openings.S = this.SolarFlux(7, index5, false);
        openings.gt = (double) this._House.RoofLights[index5].g;
        openings.FF = (double) this._House.RoofLights[index5].FF;
        openings.Gs = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this._House.RoofLights[index5].UValueSource, "", false) != 0 ? 0.9 * openings.Aw * openings.S * openings.gt * openings.FF * openings.Zs : openings.Aw * openings.S * openings.gt * openings.Zs;
        checked { ++index5; }
      }
      int num10 = Information.UBound((Array) this.OpeningsJuly);
      int index6 = 0;
      while (index6 <= num10)
      {
        Months p3;
        double num11 = (p3 = this.AppendixP.P3).M7 + this.OpeningsJuly[index6].Gs;
        p3.M7 = num11;
        checked { ++index6; }
      }
      this.AppendixP.P5.M7 = !this._House.Water.Cylinder.SummerImmersion ? this.AppendixP.P3.M7 + internalGains2012.Box73_m.M7 : this.AppendixP.P3.M7 + internalGains2012.Box73_m.M7;
      this.AppendixP.P6.M7 = this.AppendixP.P5.M7 / this.AppendixP.P2;
      this.Tsummer = regionalData.TableU1.M7;
      this.Tmass = SAP_Module.Calculation2012.Calculation.HeatLoss.Box35 >= 285.0 ? 0.0 : 2.0 - 0.007 * SAP_Module.Calculation2012.Calculation.HeatLoss.Box35;
      if (this._House.OverHeating.Night && SAP_Module.Calculation2012.Calculation.HeatLoss.Box35 > 285.0)
      {
        // ISSUE: variable of a reference type
        double& local;
        // ISSUE: explicit reference operation
        double num12 = ^(local = ref this.Tmass) - 0.002 * (SAP_Module.Calculation2012.Calculation.HeatLoss.Box35 - 285.0);
        local = num12;
      }
      this.AppendixP.P7.M7 = this.AppendixP.P6.M7 + this.Tsummer + this.Tmass;
      double m7 = this.AppendixP.P7.M7;
      if (m7 < 20.5)
        this.AppendixP.Likelihood_July = "Not significant";
      else if (m7 >= 20.5 && m7 <= 22.0 / 1.0)
        this.AppendixP.Likelihood_July = "Slight";
      else if (m7 >= 22.0 && m7 <= 47.0 / 2.0)
        this.AppendixP.Likelihood_July = "Medium";
      else if (m7 > 47.0 / 2.0)
        this.AppendixP.Likelihood_July = "High";
      int num13 = checked (this._House.NoofWindows - 1);
      int index7 = 0;
      while (index7 <= num13)
      {
        // ISSUE: variable of a reference type
        Openings[]& local;
        // ISSUE: explicit reference operation
        Openings[] openingsArray = (Openings[]) Utils.CopyArray((Array) ^(local = ref this.OpeningsAug), (Array) new Openings[checked (this.OpeningsAug.Length + 1)]);
        local = openingsArray;
        this.OpeningsAug[checked (this.OpeningsAug.Length - 1)] = new Openings();
        Openings openings = this.OpeningsAug[checked (this.OpeningsAug.Length - 1)];
        openings.Zo = this.Overhang(this._House.Windows[index7]);
        openings.Zb = this.Shading(this._House.Windows[index7].CurtainType, index7, true);
        openings.Z = this.SAF(this._House.Windows[index7]);
        openings.Zs = openings.Zb * (openings.Z + openings.Zo - 1.0);
        openings.Aw = (double) this._House.Windows[index7].Area * (double) this._House.Windows[index7].Count;
        openings.S = this.SolarFlux(8, index7, true);
        openings.gt = (double) this._House.Windows[index7].g;
        openings.FF = (double) this._House.Windows[index7].FF;
        openings.Gs = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this._House.Windows[index7].UValueSource, "BFRC", false) != 0 ? 0.9 * openings.Aw * openings.S * openings.gt * openings.FF * openings.Zs : openings.Aw * openings.S * openings.gt * openings.Zs;
        checked { ++index7; }
      }
      int num14 = checked (this._House.NoofRoofLights - 1);
      int index8 = 0;
      while (index8 <= num14)
      {
        // ISSUE: variable of a reference type
        Openings[]& local;
        // ISSUE: explicit reference operation
        Openings[] openingsArray = (Openings[]) Utils.CopyArray((Array) ^(local = ref this.OpeningsAug), (Array) new Openings[checked (this.OpeningsAug.Length + 1)]);
        local = openingsArray;
        this.OpeningsAug[checked (this.OpeningsAug.Length - 1)] = new Openings();
        Openings openings = this.OpeningsAug[checked (this.OpeningsAug.Length - 1)];
        openings.Zo = this.Overhang(this._House.RoofLights[index8]);
        openings.Zb = this.Shading(this._House.RoofLights[index8].CurtainType, index8, false);
        openings.Z = 1.0;
        openings.Zs = openings.Zb * (openings.Z + openings.Zo - 1.0);
        openings.Aw = (double) this._House.RoofLights[index8].Area * (double) this._House.RoofLights[index8].Count;
        openings.S = this.SolarFlux(8, index8, false);
        openings.gt = (double) this._House.RoofLights[index8].g;
        openings.FF = (double) this._House.RoofLights[index8].FF;
        openings.Gs = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this._House.RoofLights[index8].UValueSource, "", false) != 0 ? 0.9 * openings.Aw * openings.S * openings.gt * openings.FF * openings.Zs : openings.Aw * openings.S * openings.gt * openings.Zs;
        checked { ++index8; }
      }
      int num15 = Information.UBound((Array) this.OpeningsAug);
      int index9 = 0;
      while (index9 <= num15)
      {
        Months p3;
        double num16 = (p3 = this.AppendixP.P3).M8 + this.OpeningsAug[index9].Gs;
        p3.M8 = num16;
        checked { ++index9; }
      }
      this.AppendixP.P5.M8 = !this._House.Water.Cylinder.SummerImmersion ? this.AppendixP.P3.M8 + internalGains2012.Box73_m.M8 : this.AppendixP.P3.M8 + internalGains2012.Box73_m.M8;
      this.AppendixP.P6.M8 = this.AppendixP.P5.M8 / this.AppendixP.P2;
      this.Tsummer = regionalData.TableU1.M8;
      this.Tmass = SAP_Module.Calculation2012.Calculation.HeatLoss.Box35 >= 285.0 ? 0.0 : 2.0 - 0.007 * SAP_Module.Calculation2012.Calculation.HeatLoss.Box35;
      if (this._House.OverHeating.Night && SAP_Module.Calculation2012.Calculation.HeatLoss.Box35 > 285.0)
      {
        // ISSUE: variable of a reference type
        double& local;
        // ISSUE: explicit reference operation
        double num17 = ^(local = ref this.Tmass) - 0.002 * (SAP_Module.Calculation2012.Calculation.HeatLoss.Box35 - 285.0);
        local = num17;
      }
      this.AppendixP.P7.M8 = this.AppendixP.P6.M8 + this.Tsummer + this.Tmass;
      double m8 = this.AppendixP.P7.M8;
      if (m8 < 20.5)
        this.AppendixP.Likelihood_Aug = "Not significant";
      else if (m8 >= 20.5 && m8 <= 22.0 / 1.0)
        this.AppendixP.Likelihood_Aug = "Slight";
      else if (m8 >= 22.0 && m8 <= 47.0 / 2.0)
        this.AppendixP.Likelihood_Aug = "Medium";
      else if (m8 > 47.0 / 2.0)
        this.AppendixP.Likelihood_Aug = "High";
      float num18 = (float) Math.Max(Math.Max(this.AppendixP.P7.M6, this.AppendixP.P7.M7), this.AppendixP.P7.M8);
      if ((double) num18 < 20.5)
        this.AppendixP.Likelihood = "Not significant";
      else if ((double) num18 >= 20.5 && (double) num18 <= 22.0)
        this.AppendixP.Likelihood = "Slight";
      else if ((double) num18 >= 22.0 && (double) num18 <= 23.5)
      {
        this.AppendixP.Likelihood = "Medium";
      }
      else
      {
        if ((double) num18 <= 23.5)
          return;
        this.AppendixP.Likelihood = "High";
      }
    }

    private double Transmit(string GlazingType)
    {
      string str = GlazingType;
      double num;
      // ISSUE: reference to a compiler-generated method
      switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(str))
      {
        case 68605829:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "triple-glazed, argon filled (low-E, En = 0.2, hard coat)", false) == 0)
            goto label_29;
          else
            goto default;
        case 763250309:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "double-glazed, air filled (low-E, En = 0.2, hard coat)", false) == 0)
            goto label_26;
          else
            goto default;
        case 1070237142:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "triple-glazed, argon filled", false) == 0)
            goto label_28;
          else
            goto default;
        case 1119002789:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "double-glazed, argon filled", false) == 0)
            break;
          goto default;
        case 1129292894:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "triple-glazed, air filled (low-E, En = 0.15, hard coat)", false) == 0)
            goto label_29;
          else
            goto default;
        case 1508940614:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "double-glazed, argon filled (low-E, En = 0.15, hard coat)", false) == 0)
            goto label_26;
          else
            goto default;
        case 1617436365:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "triple-glazed, argon filled (low-E, En = 0.1, soft coat)", false) == 0)
            goto label_30;
          else
            goto default;
        case 1917834200:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "double-glazed, argon filled (low-E, En = 0.1, soft coat)", false) == 0)
            goto label_27;
          else
            goto default;
        case 2282570948:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "triple-glazed, air filled (low-E, En = 0.2, hard coat)", false) == 0)
            goto label_29;
          else
            goto default;
        case 2312080845:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "double-glazed, air filled (low-E, En = 0.1, soft coat)", false) == 0)
            goto label_27;
          else
            goto default;
        case 2413948722:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "double-glazed, argon filled (low-E, En = 0.05, soft coat)", false) == 0)
            goto label_27;
          else
            goto default;
        case 2482092156:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "double-glazed, argon filled (low-E, En = 0.2, hard coat)", false) == 0)
            goto label_26;
          else
            goto default;
        case 2498216925:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "triple-glazed, air filled", false) == 0)
            goto label_28;
          else
            goto default;
        case 2915735968:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "triple-glazed, air filled (low-E, En = 0.1, soft coat)", false) == 0)
            goto label_30;
          else
            goto default;
        case 3074690985:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "triple-glazed, argon filled (low-E, En = 0.05, soft coat)", false) == 0)
            goto label_30;
          else
            goto default;
        case 3361248225:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "triple-glazed, argon filled (low-E, En = 0.15, hard coat)", false) == 0)
            goto label_29;
          else
            goto default;
        case 3689514233:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Single-glazed", false) == 0)
          {
            num = 0.85;
            goto default;
          }
          else
            goto default;
        case 3843542185:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "double-glazed, air filled (low-E, En = 0.05, soft coat)", false) == 0)
            goto label_27;
          else
            goto default;
        case 4014901974:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "double-glazed, air filled", false) == 0)
            break;
          goto default;
        case 4130099425:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "double-glazed, air filled (low-E, En = 0.15, hard coat)", false) == 0)
            goto label_26;
          else
            goto default;
        case 4251481834:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "triple-glazed, air filled (low-E, En = 0.05, soft coat)", false) == 0)
            goto label_30;
          else
            goto default;
        case 4255679661:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Secondary glazing", false) == 0)
          {
            num = 0.76;
            goto default;
          }
          else
            goto default;
        default:
label_31:
          return num;
      }
      num = 0.76;
      goto label_31;
label_26:
      num = 0.72;
      goto label_31;
label_27:
      num = 0.63;
      goto label_31;
label_28:
      num = 0.68;
      goto label_31;
label_29:
      num = 0.64;
      goto label_31;
label_30:
      num = 0.57;
      goto label_31;
    }

    private double SolarFlux(int Month, int Opening, bool Window)
    {
      PCDF.RegionalData regionalData = SAP_Module.PCDFData.AppendixU.Where<PCDF.RegionalData>((Func<PCDF.RegionalData, bool>) (bb => bb.Region.ToUpper().Equals(this._House.Location.ToUpper()))).SingleOrDefault<PCDF.RegionalData>();
      int num1 = !Window ? checked ((int) Math.Round((double) this._House.RoofLights[Opening].Pitch)) : 90;
      float latitude = (float) regionalData.Latitude;
      int num2;
      float num3;
      switch (Month)
      {
        case 1:
          num2 = checked ((int) Math.Round(regionalData.TableU3.M1));
          num3 = (float) regionalData.SolarDeclination.M1;
          break;
        case 2:
          num2 = checked ((int) Math.Round(regionalData.TableU3.M2));
          num3 = (float) regionalData.SolarDeclination.M2;
          break;
        case 3:
          num2 = checked ((int) Math.Round(regionalData.TableU3.M3));
          num3 = (float) regionalData.SolarDeclination.M3;
          break;
        case 4:
          num2 = checked ((int) Math.Round(regionalData.TableU3.M4));
          num3 = (float) regionalData.SolarDeclination.M4;
          break;
        case 5:
          num2 = checked ((int) Math.Round(regionalData.TableU3.M5));
          num3 = (float) regionalData.SolarDeclination.M5;
          break;
        case 6:
          num2 = checked ((int) Math.Round(regionalData.TableU3.M6));
          num3 = (float) regionalData.SolarDeclination.M6;
          break;
        case 7:
          num2 = checked ((int) Math.Round(regionalData.TableU3.M7));
          num3 = (float) regionalData.SolarDeclination.M7;
          break;
        case 8:
          num2 = checked ((int) Math.Round(regionalData.TableU3.M8));
          num3 = (float) regionalData.SolarDeclination.M8;
          break;
        case 9:
          num2 = checked ((int) Math.Round(regionalData.TableU3.M9));
          num3 = (float) regionalData.SolarDeclination.M9;
          break;
        case 10:
          num2 = checked ((int) Math.Round(regionalData.TableU3.M10));
          num3 = (float) regionalData.SolarDeclination.M10;
          break;
        case 11:
          num2 = checked ((int) Math.Round(regionalData.TableU3.M11));
          num3 = (float) regionalData.SolarDeclination.M11;
          break;
        case 12:
          num2 = checked ((int) Math.Round(regionalData.TableU3.M12));
          num3 = (float) regionalData.SolarDeclination.M12;
          break;
      }
      PCDF.TableU5Constants tableU5Constants = new PCDF.TableU5Constants();
      string str = Window ? this._House.Windows[Opening].Orientation : this._House.RoofLights[Opening].Orientation;
      if (Window)
      {
        string orientation = this._House.Windows[Opening].Orientation;
        // ISSUE: reference to a compiler-generated method
        switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(orientation))
        {
          case 105265260:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation, "Unspecified", false) == 0)
              goto label_32;
            else
              goto label_75;
          case 1128440633:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation, "North East", false) == 0)
              break;
            goto label_75;
          case 1409318971:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation, "North West", false) == 0)
              break;
            goto label_75;
          case 1731397980:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation, "East", false) == 0)
              goto label_32;
            else
              goto label_75;
          case 1734234020:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation, "North", false) == 0)
            {
              List<PCDF.TableU5Constants> tableU5 = SAP_Module.PCDFData.TableU5;
              Func<PCDF.TableU5Constants, bool> predicate;
              // ISSUE: reference to a compiler-generated field
              if (OverHeatingClass._Closure\u0024__.\u0024I19\u002D1 != null)
              {
                // ISSUE: reference to a compiler-generated field
                predicate = OverHeatingClass._Closure\u0024__.\u0024I19\u002D1;
              }
              else
              {
                // ISSUE: reference to a compiler-generated field
                OverHeatingClass._Closure\u0024__.\u0024I19\u002D1 = predicate = (Func<PCDF.TableU5Constants, bool>) (bb => bb.Orientation.Equals("North"));
              }
              tableU5Constants = tableU5.Where<PCDF.TableU5Constants>(predicate).SingleOrDefault<PCDF.TableU5Constants>();
              goto label_75;
            }
            else
              goto label_75;
          case 1796576718:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation, "West", false) == 0)
              goto label_32;
            else
              goto label_75;
          case 2417407149:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation, "South West", false) == 0)
              goto label_36;
            else
              goto label_75;
          case 2853841879:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation, "South East", false) == 0)
              goto label_36;
            else
              goto label_75;
          case 3017973530:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation, "South", false) == 0)
            {
              List<PCDF.TableU5Constants> tableU5 = SAP_Module.PCDFData.TableU5;
              Func<PCDF.TableU5Constants, bool> predicate;
              // ISSUE: reference to a compiler-generated field
              if (OverHeatingClass._Closure\u0024__.\u0024I19\u002D5 != null)
              {
                // ISSUE: reference to a compiler-generated field
                predicate = OverHeatingClass._Closure\u0024__.\u0024I19\u002D5;
              }
              else
              {
                // ISSUE: reference to a compiler-generated field
                OverHeatingClass._Closure\u0024__.\u0024I19\u002D5 = predicate = (Func<PCDF.TableU5Constants, bool>) (bb => bb.Orientation.Equals("South"));
              }
              tableU5Constants = tableU5.Where<PCDF.TableU5Constants>(predicate).SingleOrDefault<PCDF.TableU5Constants>();
              goto label_75;
            }
            else
              goto label_75;
          default:
            goto label_75;
        }
        List<PCDF.TableU5Constants> tableU5_1 = SAP_Module.PCDFData.TableU5;
        Func<PCDF.TableU5Constants, bool> predicate1;
        // ISSUE: reference to a compiler-generated field
        if (OverHeatingClass._Closure\u0024__.\u0024I19\u002D2 != null)
        {
          // ISSUE: reference to a compiler-generated field
          predicate1 = OverHeatingClass._Closure\u0024__.\u0024I19\u002D2;
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          OverHeatingClass._Closure\u0024__.\u0024I19\u002D2 = predicate1 = (Func<PCDF.TableU5Constants, bool>) (bb => bb.Orientation.Equals("NE/NW"));
        }
        tableU5Constants = tableU5_1.Where<PCDF.TableU5Constants>(predicate1).SingleOrDefault<PCDF.TableU5Constants>();
        goto label_75;
label_32:
        List<PCDF.TableU5Constants> tableU5_2 = SAP_Module.PCDFData.TableU5;
        Func<PCDF.TableU5Constants, bool> predicate2;
        // ISSUE: reference to a compiler-generated field
        if (OverHeatingClass._Closure\u0024__.\u0024I19\u002D3 != null)
        {
          // ISSUE: reference to a compiler-generated field
          predicate2 = OverHeatingClass._Closure\u0024__.\u0024I19\u002D3;
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          OverHeatingClass._Closure\u0024__.\u0024I19\u002D3 = predicate2 = (Func<PCDF.TableU5Constants, bool>) (bb => bb.Orientation.Equals("East/West"));
        }
        tableU5Constants = tableU5_2.Where<PCDF.TableU5Constants>(predicate2).SingleOrDefault<PCDF.TableU5Constants>();
        goto label_75;
label_36:
        List<PCDF.TableU5Constants> tableU5_3 = SAP_Module.PCDFData.TableU5;
        Func<PCDF.TableU5Constants, bool> predicate3;
        // ISSUE: reference to a compiler-generated field
        if (OverHeatingClass._Closure\u0024__.\u0024I19\u002D4 != null)
        {
          // ISSUE: reference to a compiler-generated field
          predicate3 = OverHeatingClass._Closure\u0024__.\u0024I19\u002D4;
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          OverHeatingClass._Closure\u0024__.\u0024I19\u002D4 = predicate3 = (Func<PCDF.TableU5Constants, bool>) (bb => bb.Orientation.Equals("SE/SW"));
        }
        tableU5Constants = tableU5_3.Where<PCDF.TableU5Constants>(predicate3).SingleOrDefault<PCDF.TableU5Constants>();
      }
      else
      {
        string orientation = this._House.RoofLights[Opening].Orientation;
        // ISSUE: reference to a compiler-generated method
        switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(orientation))
        {
          case 105265260:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation, "Unspecified", false) == 0)
              goto label_62;
            else
              goto default;
          case 1128440633:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation, "North East", false) == 0)
              break;
            goto default;
          case 1409318971:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation, "North West", false) == 0)
              break;
            goto default;
          case 1731397980:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation, "East", false) == 0)
              goto label_62;
            else
              goto default;
          case 1734234020:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation, "North", false) == 0)
            {
              List<PCDF.TableU5Constants> tableU5 = SAP_Module.PCDFData.TableU5;
              Func<PCDF.TableU5Constants, bool> predicate;
              // ISSUE: reference to a compiler-generated field
              if (OverHeatingClass._Closure\u0024__.\u0024I19\u002D6 != null)
              {
                // ISSUE: reference to a compiler-generated field
                predicate = OverHeatingClass._Closure\u0024__.\u0024I19\u002D6;
              }
              else
              {
                // ISSUE: reference to a compiler-generated field
                OverHeatingClass._Closure\u0024__.\u0024I19\u002D6 = predicate = (Func<PCDF.TableU5Constants, bool>) (bb => bb.Orientation.Equals("North"));
              }
              tableU5Constants = tableU5.Where<PCDF.TableU5Constants>(predicate).SingleOrDefault<PCDF.TableU5Constants>();
              goto default;
            }
            else
              goto default;
          case 1796576718:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation, "West", false) == 0)
              goto label_62;
            else
              goto default;
          case 2417407149:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation, "South West", false) == 0)
              goto label_66;
            else
              goto default;
          case 2853841879:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation, "South East", false) == 0)
              goto label_66;
            else
              goto default;
          case 3017973530:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation, "South", false) == 0)
            {
              List<PCDF.TableU5Constants> tableU5 = SAP_Module.PCDFData.TableU5;
              Func<PCDF.TableU5Constants, bool> predicate;
              // ISSUE: reference to a compiler-generated field
              if (OverHeatingClass._Closure\u0024__.\u0024I19\u002D10 != null)
              {
                // ISSUE: reference to a compiler-generated field
                predicate = OverHeatingClass._Closure\u0024__.\u0024I19\u002D10;
              }
              else
              {
                // ISSUE: reference to a compiler-generated field
                OverHeatingClass._Closure\u0024__.\u0024I19\u002D10 = predicate = (Func<PCDF.TableU5Constants, bool>) (bb => bb.Orientation.Equals("South"));
              }
              tableU5Constants = tableU5.Where<PCDF.TableU5Constants>(predicate).SingleOrDefault<PCDF.TableU5Constants>();
              goto default;
            }
            else
              goto default;
          default:
label_74:
            goto label_75;
        }
        List<PCDF.TableU5Constants> tableU5_4 = SAP_Module.PCDFData.TableU5;
        Func<PCDF.TableU5Constants, bool> predicate4;
        // ISSUE: reference to a compiler-generated field
        if (OverHeatingClass._Closure\u0024__.\u0024I19\u002D7 != null)
        {
          // ISSUE: reference to a compiler-generated field
          predicate4 = OverHeatingClass._Closure\u0024__.\u0024I19\u002D7;
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          OverHeatingClass._Closure\u0024__.\u0024I19\u002D7 = predicate4 = (Func<PCDF.TableU5Constants, bool>) (bb => bb.Orientation.Equals("NE/NW"));
        }
        tableU5Constants = tableU5_4.Where<PCDF.TableU5Constants>(predicate4).SingleOrDefault<PCDF.TableU5Constants>();
        goto label_74;
label_62:
        List<PCDF.TableU5Constants> tableU5_5 = SAP_Module.PCDFData.TableU5;
        Func<PCDF.TableU5Constants, bool> predicate5;
        // ISSUE: reference to a compiler-generated field
        if (OverHeatingClass._Closure\u0024__.\u0024I19\u002D8 != null)
        {
          // ISSUE: reference to a compiler-generated field
          predicate5 = OverHeatingClass._Closure\u0024__.\u0024I19\u002D8;
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          OverHeatingClass._Closure\u0024__.\u0024I19\u002D8 = predicate5 = (Func<PCDF.TableU5Constants, bool>) (bb => bb.Orientation.Equals("East/West"));
        }
        tableU5Constants = tableU5_5.Where<PCDF.TableU5Constants>(predicate5).SingleOrDefault<PCDF.TableU5Constants>();
        goto label_74;
label_66:
        List<PCDF.TableU5Constants> tableU5_6 = SAP_Module.PCDFData.TableU5;
        Func<PCDF.TableU5Constants, bool> predicate6;
        // ISSUE: reference to a compiler-generated field
        if (OverHeatingClass._Closure\u0024__.\u0024I19\u002D9 != null)
        {
          // ISSUE: reference to a compiler-generated field
          predicate6 = OverHeatingClass._Closure\u0024__.\u0024I19\u002D9;
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          OverHeatingClass._Closure\u0024__.\u0024I19\u002D9 = predicate6 = (Func<PCDF.TableU5Constants, bool>) (bb => bb.Orientation.Equals("SE/SW"));
        }
        tableU5Constants = tableU5_6.Where<PCDF.TableU5Constants>(predicate6).SingleOrDefault<PCDF.TableU5Constants>();
        goto label_74;
      }
label_75:
      float num4 = (float) ((double) tableU5Constants.k1 * Math.Pow(Math.Sin((double) num1 * Math.PI / 360.0), 3.0) + (double) tableU5Constants.k2 * Math.Pow(Math.Sin((double) num1 * Math.PI / 360.0), 2.0) + (double) tableU5Constants.k3 * Math.Sin((double) num1 * Math.PI / 360.0));
      float num5 = (float) ((double) tableU5Constants.k4 * Math.Pow(Math.Sin((double) num1 * Math.PI / 360.0), 3.0) + (double) tableU5Constants.k5 * Math.Pow(Math.Sin((double) num1 * Math.PI / 360.0), 2.0) + (double) tableU5Constants.k6 * Math.Sin((double) num1 * Math.PI / 360.0));
      float num6 = (float) ((double) tableU5Constants.k7 * Math.Pow(Math.Sin((double) num1 * Math.PI / 360.0), 3.0) + (double) tableU5Constants.k8 * Math.Pow(Math.Sin((double) num1 * Math.PI / 360.0), 2.0) + (double) tableU5Constants.k9 * Math.Sin((double) num1 * Math.PI / 360.0) + 1.0);
      float num7 = (float) ((double) num4 * Math.Pow(Math.Cos(((double) latitude - (double) num3) * Math.PI / 180.0), 2.0) + (double) num5 * Math.Cos(((double) latitude - (double) num3) * Math.PI / 180.0)) + num6;
      return (double) num2 * (double) num7;
    }

    private double SAF(SAP_Module.Window x)
    {
      string overshading = x.Overshading;
      double num;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(overshading, "Heavy", false) != 0)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(overshading, "More than average", false) != 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(overshading, "Average or unknown", false) != 0)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(overshading, "Very Little", false) == 0)
              num = 1.0;
          }
          else
            num = 0.9;
        }
        else
          num = 0.7;
      }
      else
        num = 0.5;
      return num;
    }

    private double Shading(string CurtainType, int opening, bool window)
    {
      string str = CurtainType;
      double num;
      // ISSUE: reference to a compiler-generated method
      switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(str))
      {
        case 810547195:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "None", false) == 0)
            break;
          goto default;
        case 909211039:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Dark-coloured external shutter, window fully open", false) == 0)
          {
            num = 0.85;
            if ((double) this._House.Windows[opening].FractionClosed != 1.0)
            {
              num = (double) this._House.Windows[opening].FractionClosed * num + (1.0 - (double) this._House.Windows[opening].FractionClosed);
              goto default;
            }
            else
              goto default;
          }
          else
            goto default;
        case 1374332624:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "White external shutter, window fully open", false) == 0)
          {
            num = 0.65;
            if ((double) this._House.Windows[opening].FractionClosed != 1.0)
            {
              num = (double) this._House.Windows[opening].FractionClosed * num + (1.0 - (double) this._House.Windows[opening].FractionClosed);
              goto default;
            }
            else
              goto default;
          }
          else
            goto default;
        case 2166136261:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "", false) == 0)
            break;
          goto default;
        case 2218971717:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Light-coloured curtain or roller blind", false) == 0)
          {
            num = 0.6;
            if (!window)
            {
              if ((double) this._House.RoofLights[opening].FractionClosed != 1.0)
              {
                num = (double) this._House.RoofLights[opening].FractionClosed * num + (1.0 - (double) this._House.RoofLights[opening].FractionClosed);
                goto default;
              }
              else
                goto default;
            }
            else
            {
              if ((double) this._House.Windows[opening].FractionClosed != 1.0)
                num = (double) this._House.Windows[opening].FractionClosed * num + (1.0 - (double) this._House.Windows[opening].FractionClosed);
              goto default;
            }
          }
          else
            goto default;
        case 2738525451:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Net curtain (covering half window)", false) == 0)
          {
            num = 0.9;
            goto default;
          }
          else
            goto default;
        case 2916140955:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Dark-coloured external shutter, window closed", false) == 0)
          {
            num = 0.24;
            if ((double) this._House.Windows[opening].FractionClosed != 1.0)
            {
              num = (double) this._House.Windows[opening].FractionClosed * num + (1.0 - (double) this._House.Windows[opening].FractionClosed);
              goto default;
            }
            else
              goto default;
          }
          else
            goto default;
        case 3155074971:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Net curtain (covering whole window)", false) == 0)
          {
            num = 0.8;
            goto default;
          }
          else
            goto default;
        case 3533940856:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Dark-coloured venetian blind", false) == 0)
          {
            num = 0.88;
            if (!window && (double) this._House.RoofLights[opening].FractionClosed != 1.0)
            {
              num = (double) this._House.RoofLights[opening].FractionClosed * num + (1.0 - (double) this._House.RoofLights[opening].FractionClosed);
              goto default;
            }
            else
              goto default;
          }
          else
            goto default;
        case 3737043484:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "White external shutter, window closed", false) == 0)
          {
            num = 0.27;
            if ((double) this._House.Windows[opening].FractionClosed != 1.0)
            {
              num = (double) this._House.Windows[opening].FractionClosed * num + (1.0 - (double) this._House.Windows[opening].FractionClosed);
              goto default;
            }
            else
              goto default;
          }
          else
            goto default;
        case 3744450198:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Light-coloured venetian blind", false) == 0)
          {
            num = 0.7;
            if (!window && (double) this._House.RoofLights[opening].FractionClosed != 1.0)
            {
              num = (double) this._House.RoofLights[opening].FractionClosed * num + (1.0 - (double) this._House.RoofLights[opening].FractionClosed);
              goto default;
            }
            else
              goto default;
          }
          else
            goto default;
        case 4026130527:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Dark-coloured curtain or roller blind", false) == 0)
          {
            num = 0.85;
            if (!window)
            {
              if ((double) this._House.RoofLights[opening].FractionClosed != 1.0)
              {
                num = (double) this._House.RoofLights[opening].FractionClosed * num + (1.0 - (double) this._House.RoofLights[opening].FractionClosed);
                goto default;
              }
              else
                goto default;
            }
            else
            {
              if ((double) this._House.Windows[opening].FractionClosed != 1.0)
                num = (double) this._House.Windows[opening].FractionClosed * num + (1.0 - (double) this._House.Windows[opening].FractionClosed);
              goto default;
            }
          }
          else
            goto default;
        default:
label_40:
          return num;
      }
      num = 1.0;
      goto label_40;
    }

    private double Overhang(SAP_Module.Window x)
    {
      string str = "";
      if ((double) x.Height == 0.0)
        return 1.0;
      double Right = (double) x.OverhangDepth / (double) x.Height;
      if (Right == 0.0)
        return 1.0;
      string orientation = x.Orientation;
      // ISSUE: reference to a compiler-generated method
      switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(orientation))
      {
        case 1128440633:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation, "North East", false) == 0)
            break;
          goto default;
        case 1409318971:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation, "North West", false) == 0)
            break;
          goto default;
        case 1731397980:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation, "East", false) == 0)
            goto label_15;
          else
            goto default;
        case 1734234020:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation, "North", false) == 0)
          {
            str = "N";
            goto default;
          }
          else
            goto default;
        case 1796576718:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation, "West", false) == 0)
            goto label_15;
          else
            goto default;
        case 2417407149:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation, "South West", false) == 0)
            goto label_16;
          else
            goto default;
        case 2853841879:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation, "South East", false) == 0)
            goto label_16;
          else
            goto default;
        case 3017973530:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation, "South", false) == 0)
          {
            str = "S";
            goto default;
          }
          else
            goto default;
        default:
label_18:
          DataRow[] dataRowArray;
          if ((double) x.OverhangWidth >= 2.0 * (double) x.Width)
          {
            if (this.P5 == null)
              this.FillP5();
            dataRowArray = this.P5.Select("Orientation = '" + str + "'");
          }
          else
          {
            if (this.P6 == null)
              this.FillP6();
            dataRowArray = this.P6.Select("Orientation = '" + str + "'");
          }
          double num1;
          if (Right == 0.0)
          {
            num1 = Conversions.ToDouble(dataRowArray[0]["Value"]);
          }
          else
          {
            int num2 = checked (dataRowArray.Length - 2);
            int index = 0;
            while (index <= num2)
            {
              if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectLessEqual(dataRowArray[index]["Ratio"], (object) Right, false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectGreaterEqual(dataRowArray[checked (index + 1)]["Ratio"], (object) Right, false))))
              {
                num1 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.DivideObject(Microsoft.VisualBasic.CompilerServices.Operators.MultiplyObject(Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject(dataRowArray[checked (index + 1)]["Ratio"], (object) Right), Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject(dataRowArray[index]["Value"], dataRowArray[checked (index + 1)]["Value"])), Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject(dataRowArray[checked (index + 1)]["Ratio"], dataRowArray[index]["Ratio"])), dataRowArray[checked (index + 1)]["Value"]));
                break;
              }
              checked { ++index; }
            }
          }
          if (num1 == 0.0)
            num1 = Conversions.ToDouble(dataRowArray[checked (dataRowArray.Length - 1)]["Value"]);
          return num1;
      }
      str = "NE/NW";
      goto label_18;
label_15:
      str = "E/W";
      goto label_18;
label_16:
      str = "SE/SW";
      goto label_18;
    }

    private double Overhang(SAP_Module.RoofLight x)
    {
      string str = "";
      if ((double) x.Height == 0.0)
        return 1.0;
      double Right = (double) x.OverhangDepth / (double) x.Height;
      if (Right == 0.0 || Right == 0.0)
        return 1.0;
      string orientation = x.Orientation;
      // ISSUE: reference to a compiler-generated method
      switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(orientation))
      {
        case 1128440633:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation, "North East", false) == 0)
            break;
          goto default;
        case 1409318971:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation, "North West", false) == 0)
            break;
          goto default;
        case 1731397980:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation, "East", false) == 0)
            goto label_15;
          else
            goto default;
        case 1734234020:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation, "North", false) == 0)
          {
            str = "N";
            goto default;
          }
          else
            goto default;
        case 1796576718:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation, "West", false) == 0)
            goto label_15;
          else
            goto default;
        case 2417407149:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation, "South West", false) == 0)
            goto label_16;
          else
            goto default;
        case 2853841879:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation, "South East", false) == 0)
            goto label_16;
          else
            goto default;
        case 3017973530:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation, "South", false) == 0)
          {
            str = "S";
            goto default;
          }
          else
            goto default;
        default:
label_18:
          DataRow[] dataRowArray;
          if ((double) x.OverhangWidth > 2.0 * (double) x.Width)
          {
            if (this.P5 == null)
              this.FillP5();
            dataRowArray = this.P5.Select("Orientation = '" + str + "'");
          }
          else
          {
            if (this.P6 == null)
              this.FillP6();
            dataRowArray = this.P6.Select("Orientation = '" + str + "'");
          }
          double num1;
          if (Right == 0.0)
          {
            num1 = Conversions.ToDouble(dataRowArray[0]["Value"]);
          }
          else
          {
            int num2 = checked (dataRowArray.Length - 2);
            int index = 0;
            while (index <= num2)
            {
              if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectLess(dataRowArray[index]["Ratio"], (object) Right, false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectGreater(dataRowArray[checked (index + 1)]["Ratio"], (object) Right, false))))
                num1 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.DivideObject(Microsoft.VisualBasic.CompilerServices.Operators.MultiplyObject(Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject(dataRowArray[checked (index + 1)]["Ratio"], (object) Right), Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject(dataRowArray[index]["Value"], dataRowArray[checked (index + 1)]["Value"])), Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject(dataRowArray[checked (index + 1)]["Ratio"], dataRowArray[index]["Ratio"])), dataRowArray[checked (index + 1)]["Value"]));
              checked { ++index; }
            }
          }
          if (num1 == 0.0)
            num1 = Conversions.ToDouble(dataRowArray[checked (dataRowArray.Length - 1)]["Value"]);
          return num1;
      }
      str = "NE/NW";
      goto label_18;
label_15:
      str = "E/W";
      goto label_18;
label_16:
      str = "SE/SW";
      goto label_18;
    }

    private void FillP5()
    {
      this.P5 = new DataTable();
      this.P5.Columns.Add("Ratio", typeof (double));
      this.P5.Columns.Add("Orientation", typeof (string));
      this.P5.Columns.Add("Value", typeof (double));
      DataRow row1 = this.P5.NewRow();
      DataRow dataRow1 = row1;
      dataRow1["Ratio"] = (object) 0;
      dataRow1["Orientation"] = (object) "N";
      dataRow1["Value"] = (object) 1.0;
      this.P5.Rows.Add(row1);
      DataRow row2 = this.P5.NewRow();
      DataRow dataRow2 = row2;
      dataRow2["Ratio"] = (object) 0.2;
      dataRow2["Orientation"] = (object) "N";
      dataRow2["Value"] = (object) 0.92;
      this.P5.Rows.Add(row2);
      DataRow row3 = this.P5.NewRow();
      DataRow dataRow3 = row3;
      dataRow3["Ratio"] = (object) 0.4;
      dataRow3["Orientation"] = (object) "N";
      dataRow3["Value"] = (object) 0.85;
      this.P5.Rows.Add(row3);
      DataRow row4 = this.P5.NewRow();
      DataRow dataRow4 = row4;
      dataRow4["Ratio"] = (object) 0.6;
      dataRow4["Orientation"] = (object) "N";
      dataRow4["Value"] = (object) 0.79;
      this.P5.Rows.Add(row4);
      DataRow row5 = this.P5.NewRow();
      DataRow dataRow5 = row5;
      dataRow5["Ratio"] = (object) 0.8;
      dataRow5["Orientation"] = (object) "N";
      dataRow5["Value"] = (object) 0.73;
      this.P5.Rows.Add(row5);
      DataRow row6 = this.P5.NewRow();
      DataRow dataRow6 = row6;
      dataRow6["Ratio"] = (object) 1;
      dataRow6["Orientation"] = (object) "N";
      dataRow6["Value"] = (object) 0.69;
      this.P5.Rows.Add(row6);
      DataRow row7 = this.P5.NewRow();
      DataRow dataRow7 = row7;
      dataRow7["Ratio"] = (object) 1.2;
      dataRow7["Orientation"] = (object) "N";
      dataRow7["Value"] = (object) 0.66;
      this.P5.Rows.Add(row7);
      DataRow row8 = this.P5.NewRow();
      DataRow dataRow8 = row8;
      dataRow8["Ratio"] = (object) 0;
      dataRow8["Orientation"] = (object) "NE/NW";
      dataRow8["Value"] = (object) 1.0;
      this.P5.Rows.Add(row8);
      DataRow row9 = this.P5.NewRow();
      DataRow dataRow9 = row9;
      dataRow9["Ratio"] = (object) 0.2;
      dataRow9["Orientation"] = (object) "NE/NW";
      dataRow9["Value"] = (object) 0.89;
      this.P5.Rows.Add(row9);
      DataRow row10 = this.P5.NewRow();
      DataRow dataRow10 = row10;
      dataRow10["Ratio"] = (object) 0.4;
      dataRow10["Orientation"] = (object) "NE/NW";
      dataRow10["Value"] = (object) 0.8;
      this.P5.Rows.Add(row10);
      DataRow row11 = this.P5.NewRow();
      DataRow dataRow11 = row11;
      dataRow11["Ratio"] = (object) 0.6;
      dataRow11["Orientation"] = (object) "NE/NW";
      dataRow11["Value"] = (object) 0.72;
      this.P5.Rows.Add(row11);
      DataRow row12 = this.P5.NewRow();
      DataRow dataRow12 = row12;
      dataRow12["Ratio"] = (object) 0.8;
      dataRow12["Orientation"] = (object) "NE/NW";
      dataRow12["Value"] = (object) 0.65;
      this.P5.Rows.Add(row12);
      DataRow row13 = this.P5.NewRow();
      DataRow dataRow13 = row13;
      dataRow13["Ratio"] = (object) 1;
      dataRow13["Orientation"] = (object) "NE/NW";
      dataRow13["Value"] = (object) 0.59;
      this.P5.Rows.Add(row13);
      DataRow row14 = this.P5.NewRow();
      DataRow dataRow14 = row14;
      dataRow14["Ratio"] = (object) 1.2;
      dataRow14["Orientation"] = (object) "NE/NW";
      dataRow14["Value"] = (object) 0.55;
      this.P5.Rows.Add(row14);
      DataRow row15 = this.P5.NewRow();
      DataRow dataRow15 = row15;
      dataRow15["Ratio"] = (object) 0;
      dataRow15["Orientation"] = (object) "E/W";
      dataRow15["Value"] = (object) 1.0;
      this.P5.Rows.Add(row15);
      DataRow row16 = this.P5.NewRow();
      DataRow dataRow16 = row16;
      dataRow16["Ratio"] = (object) 0.2;
      dataRow16["Orientation"] = (object) "E/W";
      dataRow16["Value"] = (object) 0.88;
      this.P5.Rows.Add(row16);
      DataRow row17 = this.P5.NewRow();
      DataRow dataRow17 = row17;
      dataRow17["Ratio"] = (object) 0.4;
      dataRow17["Orientation"] = (object) "E/W";
      dataRow17["Value"] = (object) 0.76;
      this.P5.Rows.Add(row17);
      DataRow row18 = this.P5.NewRow();
      DataRow dataRow18 = row18;
      dataRow18["Ratio"] = (object) 0.6;
      dataRow18["Orientation"] = (object) "E/W";
      dataRow18["Value"] = (object) 0.66;
      this.P5.Rows.Add(row18);
      DataRow row19 = this.P5.NewRow();
      DataRow dataRow19 = row19;
      dataRow19["Ratio"] = (object) 0.8;
      dataRow19["Orientation"] = (object) "E/W";
      dataRow19["Value"] = (object) 0.58;
      this.P5.Rows.Add(row19);
      DataRow row20 = this.P5.NewRow();
      DataRow dataRow20 = row20;
      dataRow20["Ratio"] = (object) 1;
      dataRow20["Orientation"] = (object) "E/W";
      dataRow20["Value"] = (object) 0.51;
      this.P5.Rows.Add(row20);
      DataRow row21 = this.P5.NewRow();
      DataRow dataRow21 = row21;
      dataRow21["Ratio"] = (object) 1.2;
      dataRow21["Orientation"] = (object) "E/W";
      dataRow21["Value"] = (object) 0.46;
      this.P5.Rows.Add(row21);
      DataRow row22 = this.P5.NewRow();
      DataRow dataRow22 = row22;
      dataRow22["Ratio"] = (object) 0;
      dataRow22["Orientation"] = (object) "SE/SW";
      dataRow22["Value"] = (object) 1.0;
      this.P5.Rows.Add(row22);
      DataRow row23 = this.P5.NewRow();
      DataRow dataRow23 = row23;
      dataRow23["Ratio"] = (object) 0.2;
      dataRow23["Orientation"] = (object) "SE/SW";
      dataRow23["Value"] = (object) 0.83;
      this.P5.Rows.Add(row23);
      DataRow row24 = this.P5.NewRow();
      DataRow dataRow24 = row24;
      dataRow24["Ratio"] = (object) 0.4;
      dataRow24["Orientation"] = (object) "SE/SW";
      dataRow24["Value"] = (object) 0.67;
      this.P5.Rows.Add(row24);
      DataRow row25 = this.P5.NewRow();
      DataRow dataRow25 = row25;
      dataRow25["Ratio"] = (object) 0.6;
      dataRow25["Orientation"] = (object) "SE/SW";
      dataRow25["Value"] = (object) 0.54;
      this.P5.Rows.Add(row25);
      DataRow row26 = this.P5.NewRow();
      DataRow dataRow26 = row26;
      dataRow26["Ratio"] = (object) 0.8;
      dataRow26["Orientation"] = (object) "SE/SW";
      dataRow26["Value"] = (object) 0.43;
      this.P5.Rows.Add(row26);
      DataRow row27 = this.P5.NewRow();
      DataRow dataRow27 = row27;
      dataRow27["Ratio"] = (object) 1;
      dataRow27["Orientation"] = (object) "SE/SW";
      dataRow27["Value"] = (object) 0.36;
      this.P5.Rows.Add(row27);
      DataRow row28 = this.P5.NewRow();
      DataRow dataRow28 = row28;
      dataRow28["Ratio"] = (object) 1.2;
      dataRow28["Orientation"] = (object) "SE/SW";
      dataRow28["Value"] = (object) 0.31;
      this.P5.Rows.Add(row28);
      DataRow row29 = this.P5.NewRow();
      DataRow dataRow29 = row29;
      dataRow29["Ratio"] = (object) 0;
      dataRow29["Orientation"] = (object) "S";
      dataRow29["Value"] = (object) 1.0;
      this.P5.Rows.Add(row29);
      DataRow row30 = this.P5.NewRow();
      DataRow dataRow30 = row30;
      dataRow30["Ratio"] = (object) 0.2;
      dataRow30["Orientation"] = (object) "S";
      dataRow30["Value"] = (object) 0.77;
      this.P5.Rows.Add(row30);
      DataRow row31 = this.P5.NewRow();
      DataRow dataRow31 = row31;
      dataRow31["Ratio"] = (object) 0.4;
      dataRow31["Orientation"] = (object) "S";
      dataRow31["Value"] = (object) 0.55;
      this.P5.Rows.Add(row31);
      DataRow row32 = this.P5.NewRow();
      DataRow dataRow32 = row32;
      dataRow32["Ratio"] = (object) 0.6;
      dataRow32["Orientation"] = (object) "S";
      dataRow32["Value"] = (object) 0.38;
      this.P5.Rows.Add(row32);
      DataRow row33 = this.P5.NewRow();
      DataRow dataRow33 = row33;
      dataRow33["Ratio"] = (object) 0.8;
      dataRow33["Orientation"] = (object) "S";
      dataRow33["Value"] = (object) 0.32;
      this.P5.Rows.Add(row33);
      DataRow row34 = this.P5.NewRow();
      DataRow dataRow34 = row34;
      dataRow34["Ratio"] = (object) 1;
      dataRow34["Orientation"] = (object) "S";
      dataRow34["Value"] = (object) 0.3;
      this.P5.Rows.Add(row34);
      DataRow row35 = this.P5.NewRow();
      DataRow dataRow35 = row35;
      dataRow35["Ratio"] = (object) 1.2;
      dataRow35["Orientation"] = (object) "S";
      dataRow35["Value"] = (object) 0.29;
      this.P5.Rows.Add(row35);
    }

    private void FillP6()
    {
      this.P6 = new DataTable();
      this.P6.Columns.Add("Ratio", typeof (double));
      this.P6.Columns.Add("Orientation", typeof (string));
      this.P6.Columns.Add("Value", typeof (double));
      DataRow row1 = this.P6.NewRow();
      DataRow dataRow1 = row1;
      dataRow1["Ratio"] = (object) 0;
      dataRow1["Orientation"] = (object) "N";
      dataRow1["Value"] = (object) 1.0;
      this.P6.Rows.Add(row1);
      DataRow row2 = this.P6.NewRow();
      DataRow dataRow2 = row2;
      dataRow2["Ratio"] = (object) 0.2;
      dataRow2["Orientation"] = (object) "N";
      dataRow2["Value"] = (object) 0.94;
      this.P6.Rows.Add(row2);
      DataRow row3 = this.P6.NewRow();
      DataRow dataRow3 = row3;
      dataRow3["Ratio"] = (object) 0.4;
      dataRow3["Orientation"] = (object) "N";
      dataRow3["Value"] = (object) 0.9;
      this.P6.Rows.Add(row3);
      DataRow row4 = this.P6.NewRow();
      DataRow dataRow4 = row4;
      dataRow4["Ratio"] = (object) 0.6;
      dataRow4["Orientation"] = (object) "N";
      dataRow4["Value"] = (object) 0.88;
      this.P6.Rows.Add(row4);
      DataRow row5 = this.P6.NewRow();
      DataRow dataRow5 = row5;
      dataRow5["Ratio"] = (object) 0.8;
      dataRow5["Orientation"] = (object) "N";
      dataRow5["Value"] = (object) 0.86;
      this.P6.Rows.Add(row5);
      DataRow row6 = this.P6.NewRow();
      DataRow dataRow6 = row6;
      dataRow6["Ratio"] = (object) 1;
      dataRow6["Orientation"] = (object) "N";
      dataRow6["Value"] = (object) 0.85;
      this.P6.Rows.Add(row6);
      DataRow row7 = this.P6.NewRow();
      DataRow dataRow7 = row7;
      dataRow7["Ratio"] = (object) 1.2;
      dataRow7["Orientation"] = (object) "N";
      dataRow7["Value"] = (object) 0.84;
      this.P6.Rows.Add(row7);
      DataRow row8 = this.P6.NewRow();
      DataRow dataRow8 = row8;
      dataRow8["Ratio"] = (object) 0;
      dataRow8["Orientation"] = (object) "NE/NW";
      dataRow8["Value"] = (object) 1.0;
      this.P6.Rows.Add(row8);
      DataRow row9 = this.P6.NewRow();
      DataRow dataRow9 = row9;
      dataRow9["Ratio"] = (object) 0.2;
      dataRow9["Orientation"] = (object) "NE/NW";
      dataRow9["Value"] = (object) 0.91;
      this.P6.Rows.Add(row9);
      DataRow row10 = this.P6.NewRow();
      DataRow dataRow10 = row10;
      dataRow10["Ratio"] = (object) 0.4;
      dataRow10["Orientation"] = (object) "NE/NW";
      dataRow10["Value"] = (object) 0.85;
      this.P6.Rows.Add(row10);
      DataRow row11 = this.P6.NewRow();
      DataRow dataRow11 = row11;
      dataRow11["Ratio"] = (object) 0.6;
      dataRow11["Orientation"] = (object) "NE/NW";
      dataRow11["Value"] = (object) 0.81;
      this.P6.Rows.Add(row11);
      DataRow row12 = this.P6.NewRow();
      DataRow dataRow12 = row12;
      dataRow12["Ratio"] = (object) 0.8;
      dataRow12["Orientation"] = (object) "NE/NW";
      dataRow12["Value"] = (object) 0.79;
      this.P6.Rows.Add(row12);
      DataRow row13 = this.P6.NewRow();
      DataRow dataRow13 = row13;
      dataRow13["Ratio"] = (object) 1;
      dataRow13["Orientation"] = (object) "NE/NW";
      dataRow13["Value"] = (object) 0.77;
      this.P6.Rows.Add(row13);
      DataRow row14 = this.P6.NewRow();
      DataRow dataRow14 = row14;
      dataRow14["Ratio"] = (object) 1.2;
      dataRow14["Orientation"] = (object) "NE/NW";
      dataRow14["Value"] = (object) 0.76;
      this.P6.Rows.Add(row14);
      DataRow row15 = this.P6.NewRow();
      DataRow dataRow15 = row15;
      dataRow15["Ratio"] = (object) 0;
      dataRow15["Orientation"] = (object) "E/W";
      dataRow15["Value"] = (object) 1.0;
      this.P6.Rows.Add(row15);
      DataRow row16 = this.P6.NewRow();
      DataRow dataRow16 = row16;
      dataRow16["Ratio"] = (object) 0.2;
      dataRow16["Orientation"] = (object) "E/W";
      dataRow16["Value"] = (object) 0.89;
      this.P6.Rows.Add(row16);
      DataRow row17 = this.P6.NewRow();
      DataRow dataRow17 = row17;
      dataRow17["Ratio"] = (object) 0.4;
      dataRow17["Orientation"] = (object) "E/W";
      dataRow17["Value"] = (object) 0.79;
      this.P6.Rows.Add(row17);
      DataRow row18 = this.P6.NewRow();
      DataRow dataRow18 = row18;
      dataRow18["Ratio"] = (object) 0.6;
      dataRow18["Orientation"] = (object) "E/W";
      dataRow18["Value"] = (object) 0.72;
      this.P6.Rows.Add(row18);
      DataRow row19 = this.P6.NewRow();
      DataRow dataRow19 = row19;
      dataRow19["Ratio"] = (object) 0.8;
      dataRow19["Orientation"] = (object) "E/W";
      dataRow19["Value"] = (object) 0.66;
      this.P6.Rows.Add(row19);
      DataRow row20 = this.P6.NewRow();
      DataRow dataRow20 = row20;
      dataRow20["Ratio"] = (object) 1;
      dataRow20["Orientation"] = (object) "E/W";
      dataRow20["Value"] = (object) 0.61;
      this.P6.Rows.Add(row20);
      DataRow row21 = this.P6.NewRow();
      DataRow dataRow21 = row21;
      dataRow21["Ratio"] = (object) 1.2;
      dataRow21["Orientation"] = (object) "E/W";
      dataRow21["Value"] = (object) 0.57;
      this.P6.Rows.Add(row21);
      DataRow row22 = this.P6.NewRow();
      DataRow dataRow22 = row22;
      dataRow22["Ratio"] = (object) 0;
      dataRow22["Orientation"] = (object) "SE/SW";
      dataRow22["Value"] = (object) 1.0;
      this.P6.Rows.Add(row22);
      DataRow row23 = this.P6.NewRow();
      DataRow dataRow23 = row23;
      dataRow23["Ratio"] = (object) 0.2;
      dataRow23["Orientation"] = (object) "SE/SW";
      dataRow23["Value"] = (object) 0.84;
      this.P6.Rows.Add(row23);
      DataRow row24 = this.P6.NewRow();
      DataRow dataRow24 = row24;
      dataRow24["Ratio"] = (object) 0.4;
      dataRow24["Orientation"] = (object) "SE/SW";
      dataRow24["Value"] = (object) 0.72;
      this.P6.Rows.Add(row24);
      DataRow row25 = this.P6.NewRow();
      DataRow dataRow25 = row25;
      dataRow25["Ratio"] = (object) 0.6;
      dataRow25["Orientation"] = (object) "SE/SW";
      dataRow25["Value"] = (object) 0.62;
      this.P6.Rows.Add(row25);
      DataRow row26 = this.P6.NewRow();
      DataRow dataRow26 = row26;
      dataRow26["Ratio"] = (object) 0.8;
      dataRow26["Orientation"] = (object) "SE/SW";
      dataRow26["Value"] = (object) 0.55;
      this.P6.Rows.Add(row26);
      DataRow row27 = this.P6.NewRow();
      DataRow dataRow27 = row27;
      dataRow27["Ratio"] = (object) 1;
      dataRow27["Orientation"] = (object) "SE/SW";
      dataRow27["Value"] = (object) 0.52;
      this.P6.Rows.Add(row27);
      DataRow row28 = this.P6.NewRow();
      DataRow dataRow28 = row28;
      dataRow28["Ratio"] = (object) 1.2;
      dataRow28["Orientation"] = (object) "SE/SW";
      dataRow28["Value"] = (object) 0.5;
      this.P6.Rows.Add(row28);
      DataRow row29 = this.P6.NewRow();
      DataRow dataRow29 = row29;
      dataRow29["Ratio"] = (object) 0;
      dataRow29["Orientation"] = (object) "S";
      dataRow29["Value"] = (object) 1.0;
      this.P6.Rows.Add(row29);
      DataRow row30 = this.P6.NewRow();
      DataRow dataRow30 = row30;
      dataRow30["Ratio"] = (object) 0.2;
      dataRow30["Orientation"] = (object) "S";
      dataRow30["Value"] = (object) 0.79;
      this.P6.Rows.Add(row30);
      DataRow row31 = this.P6.NewRow();
      DataRow dataRow31 = row31;
      dataRow31["Ratio"] = (object) 0.4;
      dataRow31["Orientation"] = (object) "S";
      dataRow31["Value"] = (object) 0.64;
      this.P6.Rows.Add(row31);
      DataRow row32 = this.P6.NewRow();
      DataRow dataRow32 = row32;
      dataRow32["Ratio"] = (object) 0.6;
      dataRow32["Orientation"] = (object) "S";
      dataRow32["Value"] = (object) 0.53;
      this.P6.Rows.Add(row32);
      DataRow row33 = this.P6.NewRow();
      DataRow dataRow33 = row33;
      dataRow33["Ratio"] = (object) 0.8;
      dataRow33["Orientation"] = (object) "S";
      dataRow33["Value"] = (object) 0.5;
      this.P6.Rows.Add(row33);
      DataRow row34 = this.P6.NewRow();
      DataRow dataRow34 = row34;
      dataRow34["Ratio"] = (object) 1;
      dataRow34["Orientation"] = (object) "S";
      dataRow34["Value"] = (object) 0.49;
      this.P6.Rows.Add(row34);
      DataRow row35 = this.P6.NewRow();
      DataRow dataRow35 = row35;
      dataRow35["Ratio"] = (object) 1.2;
      dataRow35["Orientation"] = (object) "S";
      dataRow35["Value"] = (object) 0.48;
      this.P6.Rows.Add(row35);
    }
  }
}
