
// Type: SAP2012.WaterHeating




using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using SAP2012.My;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SAP2012
{
  [StandardModule]
  internal sealed class WaterHeating
  {
    public static void CheckWaterType_AndFuel(string Type)
    {
      try
      {
        PCDF.Table4aWater table4aWater = SAP_Module.PCDFData.Table4aWaters.Where<PCDF.Table4aWater>((Func<PCDF.Table4aWater, bool>) (b => b.Description.Equals(Type))).SingleOrDefault<PCDF.Table4aWater>();
        if (table4aWater != null)
        {
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.SystemRef = Conversions.ToInteger(table4aWater.Code);
          MyProject.Forms.SAPForm.txtWaterFuel.Text = "";
          MyProject.Forms.SAPForm.txtWaterFuel.Items.Clear();
          WaterHeating.CheckCylinder();
          MyProject.Forms.SAPForm.txtWaterFuel.Enabled = true;
          string fuel = table4aWater.Fuel;
          if (Operators.CompareString(fuel, "-", false) != 0)
          {
            if (Operators.CompareString(fuel, "Electricity", false) != 0)
            {
              if (Operators.CompareString(fuel, "Gas", false) != 0)
              {
                if (Operators.CompareString(fuel, "Oil", false) != 0)
                {
                  if (Operators.CompareString(fuel, "Solid", false) == 0)
                  {
                    MyProject.Forms.SAPForm.txtWaterFuel.Items.Add((object) "house coal");
                    MyProject.Forms.SAPForm.txtWaterFuel.Items.Add((object) "anthracite");
                    MyProject.Forms.SAPForm.txtWaterFuel.Items.Add((object) "manufactured smokeless fuel");
                    MyProject.Forms.SAPForm.txtWaterFuel.Items.Add((object) "wood logs");
                    MyProject.Forms.SAPForm.txtWaterFuel.Items.Add((object) "wood pellets (in bags, for secondary heating)");
                    MyProject.Forms.SAPForm.txtWaterFuel.Items.Add((object) "wood pellets (bulk supply in bags, for main heating)");
                    MyProject.Forms.SAPForm.txtWaterFuel.Items.Add((object) "wood chips");
                    MyProject.Forms.SAPForm.txtWaterFuel.Items.Add((object) "dual fuel appliance (mineral and wood)");
                  }
                }
                else
                {
                  MyProject.Forms.SAPForm.txtWaterFuel.Items.Add((object) "heating oil");
                  MyProject.Forms.SAPForm.txtWaterFuel.Text = "heating oil";
                  MyProject.Forms.SAPForm.txtWaterFuel.Enabled = false;
                }
              }
              else
              {
                MyProject.Forms.SAPForm.txtWaterFuel.Items.Add((object) "mains gas");
                MyProject.Forms.SAPForm.txtWaterFuel.Items.Add((object) "bulk LPG");
                MyProject.Forms.SAPForm.txtWaterFuel.Items.Add((object) "bottled LPG");
              }
            }
            else
            {
              MyProject.Forms.SAPForm.txtWaterFuel.Items.Add((object) "Electricity");
              MyProject.Forms.SAPForm.txtWaterFuel.Text = "Electricity";
              MyProject.Forms.SAPForm.txtWaterFuel.Enabled = false;
            }
          }
          else
          {
            string Left = Type;
            if (Operators.CompareString(Left, "From main heating system", false) != 0)
            {
              if (Operators.CompareString(Left, "From second main heating system", false) != 0)
              {
                if (Operators.CompareString(Left, "From secondary system", false) != 0)
                {
                  if (Operators.CompareString(Left, "From hot-water only community scheme - boilers", false) == 0 || Operators.CompareString(Left, "From hot-water only community scheme - CHP", false) == 0 || Operators.CompareString(Left, "From hot-water only community scheme - heat pump", false) == 0)
                  {
                    MyProject.Forms.SAPForm.txtWaterFuel.Items.Add((object) "heat from boilers – mains gas");
                    MyProject.Forms.SAPForm.txtWaterFuel.Items.Add((object) "heat from boilers – LPG");
                    MyProject.Forms.SAPForm.txtWaterFuel.Items.Add((object) "heat from boilers – oil");
                    MyProject.Forms.SAPForm.txtWaterFuel.Items.Add((object) "heat from boilers – B30D");
                    MyProject.Forms.SAPForm.txtWaterFuel.Items.Add((object) "heat from boilers – coal");
                    MyProject.Forms.SAPForm.txtWaterFuel.Items.Add((object) "heat from electric heat pump");
                    MyProject.Forms.SAPForm.txtWaterFuel.Items.Add((object) "heat from boilers - waste combustion");
                    MyProject.Forms.SAPForm.txtWaterFuel.Items.Add((object) "heat from boilers – biomass");
                    MyProject.Forms.SAPForm.txtWaterFuel.Items.Add((object) "heat from boilers – biogas");
                    MyProject.Forms.SAPForm.txtWaterFuel.Items.Add((object) "waste heat from power stations");
                    MyProject.Forms.SAPForm.txtWaterFuel.Items.Add((object) "geothermal heat source");
                    MyProject.Forms.SAPForm.txtWaterFuel.Items.Add((object) "heat from CHP");
                  }
                }
                else
                {
                  MyProject.Forms.SAPForm.txtWaterFuel.Items.Add((object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].SecHeating.Fuel);
                  MyProject.Forms.SAPForm.txtWaterFuel.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].SecHeating.Fuel;
                  MyProject.Forms.SAPForm.txtWaterFuel.Enabled = false;
                }
              }
              else
              {
                MyProject.Forms.SAPForm.txtWaterFuel.Items.Add((object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.Fuel);
                MyProject.Forms.SAPForm.txtWaterFuel.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.Fuel;
                MyProject.Forms.SAPForm.txtWaterFuel.Enabled = false;
              }
            }
            else
            {
              MyProject.Forms.SAPForm.txtWaterFuel.Items.Add((object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Fuel);
              MyProject.Forms.SAPForm.txtWaterFuel.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Fuel;
              MyProject.Forms.SAPForm.txtWaterFuel.Enabled = false;
            }
          }
        }
        try
        {
          if (!SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].WaterOnlyHeatPump)
            return;
          if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.HPOnly.HotWaterHP_Integral)
          {
            MyProject.Forms.SAPForm.optCyManuLoss.Checked = true;
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.ManuSpecified = true;
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.DeclaredLoss = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.HPOnly.DeclaredValue;
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.Volume = (float) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.HPOnly.Vol;
            MyProject.Forms.SAPForm.txtCyVolume.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.Volume);
            MyProject.Forms.SAPForm.txtCyDLoss.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.DeclaredLoss);
            MyProject.Forms.SAPForm.grpCylinder.Enabled = false;
          }
          else
            MyProject.Forms.SAPForm.grpCylinder.Enabled = true;
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    public static void CheckCylinder()
    {
      MyProject.Forms.SAPForm.grpCylinder.Enabled = false;
      MyProject.Forms.SAPForm.grpDHWComm.Enabled = false;
      MyProject.Forms.SAPForm.grpThermalStore.Enabled = false;
      MyProject.Forms.SAPForm.txtCyVolume.Enabled = true;
      MyProject.Forms.SAPForm.optCyManuLoss.Checked = false;
      MyProject.Forms.SAPForm.optCyManuLoss.Enabled = true;
      MyProject.Forms.SAPForm.txtCyVolume.Text = "";
      MyProject.Forms.SAPForm.txtCyDLoss.Text = "";
      MyProject.Forms.SAPForm.txtCyInsulation.Text = "";
      MyProject.Forms.SAPForm.txtCyInsThick.Text = "";
      MyProject.Forms.SAPForm.txtCyInsulation.Enabled = true;
      MyProject.Forms.SAPForm.txtCyInsThick.Enabled = true;
      MyProject.Forms.SAPForm.optCyHSpace.Checked = false;
      MyProject.Forms.SAPForm.optCyThermostat.Checked = false;
      MyProject.Forms.SAPForm.optCyPipeWork.Checked = false;
      MyProject.Forms.SAPForm.optCyTimed.Checked = false;
      MyProject.Forms.SAPForm.optCyPipeWork.Enabled = false;
      MyProject.Forms.SAPForm.optCyTimed.Enabled = false;
      MyProject.Forms.SAPForm.grpCPSU.Enabled = false;
      MyProject.Forms.SAPForm.txtImmersion.Enabled = false;
      MyProject.Forms.SAPForm.chkThermal.Enabled = true;
      MyProject.Forms.SAPForm.txtThermalLocation.Enabled = false;
      MyProject.Forms.SAPForm.grpHeapPumpImmersion.Enabled = false;
      MyProject.Forms.SAPForm.txtDHWCommCHP.Enabled = false;
      MyProject.Forms.SAPForm.txtDHWCommHDS.Enabled = false;
      MyProject.Forms.SAPForm.txtDHWCommEff.Enabled = false;
      MyProject.Forms.SAPForm.grpWBoiler.Enabled = false;
      MyProject.Forms.SAPForm.txtCPSUTemp.Text = "";
      MyProject.Forms.SAPForm.optCySummer.Enabled = false;
      MyProject.Forms.SAPForm.optCySummer.Checked = false;
      MyProject.Forms.SAPForm.txtHeatPumpExchanger.Enabled = false;
      int systemRef = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.SystemRef;
      int num1;
      switch (systemRef)
      {
        case 901:
          if (Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.InforSource, "Boiler Database", false) == 0)
          {
            if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SEDBUK == null)
            {
              int num2 = (int) Interaction.MsgBox((object) "Please specify boiler from Database first.", MsgBoxStyle.Information, (object) "Water Heating");
              MyProject.Forms.SAPForm.txtWater.Text = "";
              return;
            }
            if (Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SEDBUK, "", false) == 0)
            {
              int num3 = (int) Interaction.MsgBox((object) "Please specify boiler from Database first.", MsgBoxStyle.Information, (object) "Water Heating");
              MyProject.Forms.SAPForm.txtWater.Text = "";
              return;
            }
            if (Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SGroup, "Gas boilers and oil boilers", false) == 0)
            {
              List<PCDF.SEDBUK> boilers = SAP_Module.PCDFData.Boilers;
              Func<PCDF.SEDBUK, bool> predicate;
              // ISSUE: reference to a compiler-generated field
              if (WaterHeating._Closure\u0024__.\u0024I1\u002D0 != null)
              {
                // ISSUE: reference to a compiler-generated field
                predicate = WaterHeating._Closure\u0024__.\u0024I1\u002D0;
              }
              else
              {
                // ISSUE: reference to a compiler-generated field
                WaterHeating._Closure\u0024__.\u0024I1\u002D0 = predicate = (Func<PCDF.SEDBUK, bool>) (b => b.ID.Equals(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SEDBUK));
              }
              PCDF.SEDBUK sedbuk = boilers.Where<PCDF.SEDBUK>(predicate).SingleOrDefault<PCDF.SEDBUK>();
              if (sedbuk != null)
              {
                if (!sedbuk.MainType.Equals("2"))
                {
                  MyProject.Forms.SAPForm.grpCylinder.Enabled = true;
                  MyProject.Forms.SAPForm.optCyPipeWork.Enabled = true;
                  MyProject.Forms.SAPForm.optCyTimed.Enabled = true;
                  MyProject.Forms.SAPForm.grpThermalStore.Enabled = true;
                  if (sedbuk.MainType.Equals("3"))
                  {
                    SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Thermal.Include = false;
                    MyProject.Forms.SAPForm.chkThermal.Checked = false;
                    MyProject.Forms.SAPForm.txtCyVolume.Enabled = false;
                    MyProject.Forms.SAPForm.optCyManuLoss.Enabled = false;
                    MyProject.Forms.SAPForm.txtCyInsulation.Enabled = false;
                    MyProject.Forms.SAPForm.txtCyInsThick.Enabled = false;
                    MyProject.Forms.SAPForm.chkThermal.Enabled = false;
                    MyProject.Forms.SAPForm.txtThermalLocation.Enabled = true;
                    MyProject.Forms.SAPForm.txtCyVolume.Text = "";
                    MyProject.Forms.SAPForm.txtCyDLoss.Text = "";
                    MyProject.Forms.SAPForm.txtCyInsulation.Text = "";
                    MyProject.Forms.SAPForm.txtCyInsThick.Text = "";
                  }
                }
                else if (sedbuk.MainType.Equals("2"))
                {
                  MyProject.Forms.SAPForm.chkThermal.Checked = false;
                  MyProject.Forms.SAPForm.txtCyVolume.Enabled = false;
                  MyProject.Forms.SAPForm.optCyManuLoss.Enabled = false;
                  MyProject.Forms.SAPForm.txtCyInsulation.Enabled = false;
                  MyProject.Forms.SAPForm.txtCyInsThick.Enabled = false;
                  MyProject.Forms.SAPForm.chkThermal.Enabled = false;
                  MyProject.Forms.SAPForm.txtCyDLoss.Enabled = false;
                  MyProject.Forms.SAPForm.txtThermalLocation.Enabled = true;
                  MyProject.Forms.SAPForm.txtCyVolume.Text = "";
                  MyProject.Forms.SAPForm.txtCyDLoss.Text = "";
                  MyProject.Forms.SAPForm.txtCyInsulation.Text = "";
                  MyProject.Forms.SAPForm.txtCyInsThick.Text = "";
                  MyProject.Forms.SAPForm.grpCylinder.Enabled = false;
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.Volume = (float) Conversion.Val(MyProject.Forms.SAPForm.txtCyVolume.Text);
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.ManuSpecified = MyProject.Forms.SAPForm.optCyManuLoss.Checked;
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.DeclaredLoss = (float) Conversion.Val(MyProject.Forms.SAPForm.txtCyDLoss.Text);
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.Insulation = MyProject.Forms.SAPForm.txtCyInsulation.Text;
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.InsThick = (float) Conversion.Val(MyProject.Forms.SAPForm.txtCyInsThick.Text);
                }
                goto label_196;
              }
              else
                goto label_196;
            }
            else if (Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SGroup, "Micro-cogeneration (micro-CHP)", false) == 0)
            {
              List<PCDF.CHP> chPs = SAP_Module.PCDFData.CHPs;
              Func<PCDF.CHP, bool> predicate;
              // ISSUE: reference to a compiler-generated field
              if (WaterHeating._Closure\u0024__.\u0024I1\u002D1 != null)
              {
                // ISSUE: reference to a compiler-generated field
                predicate = WaterHeating._Closure\u0024__.\u0024I1\u002D1;
              }
              else
              {
                // ISSUE: reference to a compiler-generated field
                WaterHeating._Closure\u0024__.\u0024I1\u002D1 = predicate = (Func<PCDF.CHP, bool>) (b => b.ID.Equals(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SEDBUK));
              }
              PCDF.CHP chp = chPs.Where<PCDF.CHP>(predicate).SingleOrDefault<PCDF.CHP>();
              if (chp != null)
              {
                MyProject.Forms.SAPForm.grpHeapPumpImmersion.Enabled = true;
                if (Conversion.Val(chp.HWVessel) != 1.0)
                {
                  MyProject.Forms.SAPForm.grpCylinder.Enabled = true;
                  MyProject.Forms.SAPForm.optCyPipeWork.Enabled = true;
                  MyProject.Forms.SAPForm.optCyTimed.Enabled = true;
                  MyProject.Forms.SAPForm.grpThermalStore.Enabled = true;
                  if (Conversion.Val(chp.Flue_Type) == 3.0)
                  {
                    SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Thermal.Include = false;
                    MyProject.Forms.SAPForm.chkThermal.Checked = false;
                    MyProject.Forms.SAPForm.txtCyVolume.Enabled = false;
                    MyProject.Forms.SAPForm.optCyManuLoss.Enabled = false;
                    MyProject.Forms.SAPForm.txtCyInsulation.Enabled = false;
                    MyProject.Forms.SAPForm.txtCyInsThick.Enabled = false;
                    MyProject.Forms.SAPForm.chkThermal.Enabled = false;
                    MyProject.Forms.SAPForm.txtThermalLocation.Enabled = true;
                    MyProject.Forms.SAPForm.txtCyVolume.Text = "";
                    MyProject.Forms.SAPForm.txtCyDLoss.Text = "";
                    MyProject.Forms.SAPForm.txtCyInsulation.Text = "";
                    MyProject.Forms.SAPForm.txtCyInsThick.Text = "";
                  }
                }
                goto label_196;
              }
              else
                goto label_196;
            }
            else if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SGroup.Contains("heat pumps"))
            {
              List<PCDF.HeatPump> heatPumps = SAP_Module.PCDFData.HeatPumps;
              Func<PCDF.HeatPump, bool> predicate;
              // ISSUE: reference to a compiler-generated field
              if (WaterHeating._Closure\u0024__.\u0024I1\u002D2 != null)
              {
                // ISSUE: reference to a compiler-generated field
                predicate = WaterHeating._Closure\u0024__.\u0024I1\u002D2;
              }
              else
              {
                // ISSUE: reference to a compiler-generated field
                WaterHeating._Closure\u0024__.\u0024I1\u002D2 = predicate = (Func<PCDF.HeatPump, bool>) (b => b.ID.Equals(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SEDBUK));
              }
              PCDF.HeatPump heatPump = heatPumps.Where<PCDF.HeatPump>(predicate).SingleOrDefault<PCDF.HeatPump>();
              if (heatPump != null)
              {
                MyProject.Forms.SAPForm.grpHeapPumpImmersion.Enabled = true;
                if (Conversion.Val(heatPump.HWvessel) != 1.0)
                {
                  MyProject.Forms.SAPForm.grpCylinder.Enabled = true;
                  MyProject.Forms.SAPForm.optCyPipeWork.Enabled = true;
                  MyProject.Forms.SAPForm.optCyTimed.Enabled = true;
                  MyProject.Forms.SAPForm.grpThermalStore.Enabled = true;
                  if (Conversion.Val(heatPump.Flue_Type) == 3.0)
                  {
                    SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Thermal.Include = false;
                    MyProject.Forms.SAPForm.chkThermal.Checked = false;
                    MyProject.Forms.SAPForm.txtCyVolume.Enabled = false;
                    MyProject.Forms.SAPForm.optCyManuLoss.Enabled = false;
                    MyProject.Forms.SAPForm.txtCyInsulation.Enabled = false;
                    MyProject.Forms.SAPForm.txtCyInsThick.Enabled = false;
                    MyProject.Forms.SAPForm.chkThermal.Enabled = false;
                    MyProject.Forms.SAPForm.txtThermalLocation.Enabled = true;
                    MyProject.Forms.SAPForm.txtCyVolume.Text = "";
                    MyProject.Forms.SAPForm.txtCyDLoss.Text = "";
                    MyProject.Forms.SAPForm.txtCyInsulation.Text = "";
                    MyProject.Forms.SAPForm.txtCyInsThick.Text = "";
                  }
                  if (Conversion.Val(heatPump.HWvessel) == 2.0)
                    MyProject.Forms.SAPForm.txtHeatPumpExchanger.Enabled = true;
                }
                else if (Conversion.Val(heatPump.HWvessel) == 1.0)
                {
                  MyProject.Forms.SAPForm.txtCyVolume.Text = heatPump.VesselVol;
                  MyProject.Forms.SAPForm.txtCyDLoss.Text = heatPump.VesselHeat_Loss;
                  MyProject.Forms.SAPForm.txtHeatPumpExchanger.Text = heatPump.VesselHeat_Exchanger;
                }
                goto label_196;
              }
              else
                goto label_196;
            }
            else if (Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SGroup, "Solid fuel boilers", false) == 0)
            {
              List<PCDF.SEDBUK_Solid> solidBoilers = SAP_Module.PCDFData.Solid_Boilers;
              Func<PCDF.SEDBUK_Solid, bool> predicate;
              // ISSUE: reference to a compiler-generated field
              if (WaterHeating._Closure\u0024__.\u0024I1\u002D3 != null)
              {
                // ISSUE: reference to a compiler-generated field
                predicate = WaterHeating._Closure\u0024__.\u0024I1\u002D3;
              }
              else
              {
                // ISSUE: reference to a compiler-generated field
                WaterHeating._Closure\u0024__.\u0024I1\u002D3 = predicate = (Func<PCDF.SEDBUK_Solid, bool>) (b => b.ID.Equals(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SEDBUK));
              }
              if (solidBoilers.Where<PCDF.SEDBUK_Solid>(predicate).SingleOrDefault<PCDF.SEDBUK_Solid>() != null)
              {
                MyProject.Forms.SAPForm.optCySummer.Enabled = true;
                MyProject.Forms.SAPForm.grpCylinder.Enabled = true;
                MyProject.Forms.SAPForm.optCyPipeWork.Enabled = true;
                MyProject.Forms.SAPForm.optCyTimed.Enabled = true;
                MyProject.Forms.SAPForm.grpThermalStore.Enabled = true;
              }
              goto label_196;
            }
            else
              goto label_196;
          }
          else
          {
            int sapTableCode1 = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SAPTableCode;
            int num4;
            switch (sapTableCode1)
            {
              case 101:
              case 102:
              case 105:
              case 106:
              case 109:
              case 110:
              case 111:
              case 114:
              case 115:
              case 116:
              case 117:
              case 119:
              case 120:
              case 121:
              case 122:
              case 123:
              case 124:
              case 125:
              case 126:
              case (int) sbyte.MaxValue:
              case 131:
              case 132:
              case 133:
              case 134:
              case 135:
              case 136:
              case 137:
              case 138:
              case 139:
              case 140:
                num4 = 1;
                break;
              default:
                num4 = sapTableCode1 == 141 ? 1 : 0;
                break;
            }
            if (num4 != 0)
            {
              MyProject.Forms.SAPForm.grpCylinder.Enabled = true;
              MyProject.Forms.SAPForm.grpThermalStore.Enabled = true;
              switch (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SAPTableCode)
              {
                case 120:
                case 121:
                case 122:
                case 123:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Thermal.Include = false;
                  MyProject.Forms.SAPForm.chkThermal.Checked = false;
                  MyProject.Forms.SAPForm.chkThermal.Enabled = false;
                  MyProject.Forms.SAPForm.txtThermalLocation.Enabled = true;
                  break;
              }
            }
            else if (sapTableCode1 == 103 || sapTableCode1 == 104 || sapTableCode1 == 107 || sapTableCode1 == 108 || sapTableCode1 == 112 || sapTableCode1 == 113 || sapTableCode1 == 118 || sapTableCode1 == 128 || sapTableCode1 == 129 || sapTableCode1 == 130)
            {
              MyProject.Forms.SAPForm.grpWBoiler.Enabled = true;
              if (Operators.CompareString(MyProject.Forms.SAPForm.txtWCombiType.Text, "", false) == 0)
                MyProject.Forms.SAPForm.txtWCombiType.Text = "Instantaneous Combi";
              if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.CombiType != null)
              {
                if (Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.CombiType, "Storage combi boiler, primary store", false) == 0 | Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.CombiType, "Storage combi boiler, secondary store", false) == 0)
                {
                  MyProject.Forms.SAPForm.grpCylinder.Enabled = true;
                }
                else
                {
                  MyProject.Forms.SAPForm.txtCyVolume.Text = "";
                  MyProject.Forms.SAPForm.txtCyDLoss.Text = "";
                  MyProject.Forms.SAPForm.txtCyInsulation.Text = "";
                  MyProject.Forms.SAPForm.txtCyInsThick.Text = "";
                  MyProject.Forms.SAPForm.optCyHSpace.Checked = false;
                  MyProject.Forms.SAPForm.optCyThermostat.Checked = false;
                  MyProject.Forms.SAPForm.optCyPipeWork.Checked = false;
                  MyProject.Forms.SAPForm.optCyTimed.Checked = false;
                  MyProject.Forms.SAPForm.optCySummer.Checked = false;
                  MyProject.Forms.SAPForm.cboPipeWorkInsulated.Text = "";
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.SummerImmersion = MyProject.Forms.SAPForm.optCySummer.Checked;
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.Volume = (float) Conversion.Val(MyProject.Forms.SAPForm.txtCyVolume.Text);
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.ManuSpecified = MyProject.Forms.SAPForm.optCyManuLoss.Checked;
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.DeclaredLoss = (float) Conversion.Val(MyProject.Forms.SAPForm.txtCyDLoss.Text);
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.Insulation = MyProject.Forms.SAPForm.txtCyInsulation.Text;
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.InsThick = (float) Conversion.Val(MyProject.Forms.SAPForm.txtCyInsThick.Text);
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.InHeatedSpace = MyProject.Forms.SAPForm.optCyHSpace.Checked;
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.Thermostat = MyProject.Forms.SAPForm.optCyThermostat.Checked;
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.PipeWorkInsulated = MyProject.Forms.SAPForm.optCyPipeWork.Checked;
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.PipeWorkInsulationType = MyProject.Forms.SAPForm.cboPipeWorkInsulated.Text;
                }
              }
            }
            else if (sapTableCode1 >= 151 && sapTableCode1 <= 207)
            {
              MyProject.Forms.SAPForm.grpCylinder.Enabled = true;
              MyProject.Forms.SAPForm.grpThermalStore.Enabled = true;
            }
            else if (sapTableCode1 >= 306 && sapTableCode1 <= 310)
              MyProject.Forms.SAPForm.grpThermalStore.Enabled = true;
            else if (sapTableCode1 == 602 || sapTableCode1 == 604 || sapTableCode1 == 606 || sapTableCode1 == 622 || sapTableCode1 == 624 || sapTableCode1 == 632 || sapTableCode1 == 634 || sapTableCode1 == 636)
            {
              MyProject.Forms.SAPForm.grpCylinder.Enabled = true;
              MyProject.Forms.SAPForm.grpThermalStore.Enabled = true;
            }
            else
            {
              if (sapTableCode1 >= 501 && sapTableCode1 <= 515)
              {
                MyProject.Forms.SAPForm.grpCylinder.Enabled = true;
                MyProject.Forms.SAPForm.grpThermalStore.Enabled = true;
                MyProject.Forms.SAPForm.txtWater.Text = "";
                return;
              }
              if (sapTableCode1 >= 520 && sapTableCode1 <= 527)
              {
                MyProject.Forms.SAPForm.grpCylinder.Enabled = true;
                MyProject.Forms.SAPForm.grpThermalStore.Enabled = true;
              }
              else if (sapTableCode1 != 103 && sapTableCode1 != 104 && sapTableCode1 != 107 && sapTableCode1 != 108 && sapTableCode1 != 112 && sapTableCode1 != 113 && sapTableCode1 != 118 && sapTableCode1 != 128 && sapTableCode1 != 129 && sapTableCode1 != 130)
              {
                if (sapTableCode1 >= 211 && sapTableCode1 <= 227)
                {
                  MyProject.Forms.SAPForm.grpCylinder.Enabled = true;
                  MyProject.Forms.SAPForm.grpThermalStore.Enabled = true;
                }
                else
                {
                  int num5 = (int) Interaction.MsgBox((object) "Main heating not suitable to heat water.", MsgBoxStyle.Information, (object) "Water Heating");
                  MyProject.Forms.SAPForm.txtWater.Text = "";
                  return;
                }
              }
            }
            MyProject.Forms.SAPForm.optCyPipeWork.Enabled = true;
            MyProject.Forms.SAPForm.optCyTimed.Enabled = true;
            int sapTableCode2 = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SAPTableCode;
            if (sapTableCode2 == 192)
              MyProject.Forms.SAPForm.grpCPSU.Enabled = true;
            else if (sapTableCode2 >= 120 && sapTableCode2 <= 123)
              MyProject.Forms.SAPForm.grpCPSU.Enabled = true;
            int sapTableCode3 = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SAPTableCode;
            if (sapTableCode3 >= 156 && sapTableCode3 <= 161 || sapTableCode3 == 632 || sapTableCode3 == 634 || sapTableCode3 == 636)
            {
              MyProject.Forms.SAPForm.optCySummer.Enabled = true;
            }
            else
            {
              MyProject.Forms.SAPForm.optCySummer.Enabled = false;
              MyProject.Forms.SAPForm.optCySummer.Checked = false;
              int sapTableCode4 = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SAPTableCode;
              if (sapTableCode4 == 191 || sapTableCode4 >= 193 && sapTableCode4 <= 196)
              {
                MyProject.Forms.SAPForm.txtImmersion.Enabled = true;
              }
              else
              {
                MyProject.Forms.SAPForm.txtImmersion.Enabled = false;
                MyProject.Forms.SAPForm.txtImmersion.Text = "";
              }
            }
            int sapTableCode5 = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SAPTableCode;
            if (sapTableCode5 >= 201 && sapTableCode5 <= 207)
              MyProject.Forms.SAPForm.grpHeapPumpImmersion.Enabled = true;
            int sapTableCode6 = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SAPTableCode;
            if (sapTableCode6 >= 306 && sapTableCode6 <= 310)
              MyProject.Forms.SAPForm.grpDHWComm.Enabled = true;
            goto label_196;
          }
        case 902:
          switch (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].SecHeating.SAPTableCode)
          {
            case 0:
              int num6 = (int) Interaction.MsgBox((object) "Please specify secondary heating first.", MsgBoxStyle.Information, (object) "Water Heating");
              MyProject.Forms.SAPForm.txtWater.Text = "";
              return;
            case 602:
            case 604:
            case 606:
            case 622:
            case 624:
            case 632:
            case 634:
            case 636:
              MyProject.Forms.SAPForm.grpThermalStore.Enabled = true;
              MyProject.Forms.SAPForm.grpCylinder.Enabled = true;
              MyProject.Forms.SAPForm.optCyPipeWork.Enabled = true;
              MyProject.Forms.SAPForm.optCyTimed.Enabled = true;
              goto label_196;
            default:
              int num7 = (int) Interaction.MsgBox((object) "Secondary heating not suitable to heat water.", MsgBoxStyle.Information, (object) "Water Heating");
              MyProject.Forms.SAPForm.txtWater.Text = "";
              return;
          }
        case 914:
          if (Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.InforSource, "Boiler Database", false) == 0)
          {
            if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SEDBUK == null)
            {
              int num8 = (int) Interaction.MsgBox((object) "Please specify boiler from Database first.", MsgBoxStyle.Information, (object) "Water Heating");
              MyProject.Forms.SAPForm.txtWater.Text = "";
              return;
            }
            if (Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SEDBUK, "", false) == 0)
            {
              int num9 = (int) Interaction.MsgBox((object) "Please specify boiler from Database first.", MsgBoxStyle.Information, (object) "Water Heating");
              MyProject.Forms.SAPForm.txtWater.Text = "";
              return;
            }
            if (Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SGroup, "Gas boilers and oil boilers", false) == 0)
            {
              List<PCDF.SEDBUK> boilers = SAP_Module.PCDFData.Boilers;
              Func<PCDF.SEDBUK, bool> predicate;
              // ISSUE: reference to a compiler-generated field
              if (WaterHeating._Closure\u0024__.\u0024I1\u002D4 != null)
              {
                // ISSUE: reference to a compiler-generated field
                predicate = WaterHeating._Closure\u0024__.\u0024I1\u002D4;
              }
              else
              {
                // ISSUE: reference to a compiler-generated field
                WaterHeating._Closure\u0024__.\u0024I1\u002D4 = predicate = (Func<PCDF.SEDBUK, bool>) (b => b.ID.Equals(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SEDBUK));
              }
              PCDF.SEDBUK sedbuk = boilers.Where<PCDF.SEDBUK>(predicate).SingleOrDefault<PCDF.SEDBUK>();
              if (sedbuk != null)
              {
                if (Conversion.Val(sedbuk.MainType) != 2.0)
                {
                  MyProject.Forms.SAPForm.grpCylinder.Enabled = true;
                  MyProject.Forms.SAPForm.optCyPipeWork.Enabled = true;
                  MyProject.Forms.SAPForm.optCyTimed.Enabled = true;
                  MyProject.Forms.SAPForm.grpThermalStore.Enabled = true;
                  if (sedbuk.MainType.Equals("3"))
                  {
                    SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Thermal.Include = false;
                    MyProject.Forms.SAPForm.chkThermal.Checked = false;
                    MyProject.Forms.SAPForm.txtCyVolume.Enabled = false;
                    MyProject.Forms.SAPForm.optCyManuLoss.Enabled = false;
                    MyProject.Forms.SAPForm.txtCyInsulation.Enabled = false;
                    MyProject.Forms.SAPForm.txtCyInsThick.Enabled = false;
                    MyProject.Forms.SAPForm.chkThermal.Enabled = false;
                    MyProject.Forms.SAPForm.txtThermalLocation.Enabled = true;
                    MyProject.Forms.SAPForm.txtCyVolume.Text = "";
                    MyProject.Forms.SAPForm.txtCyDLoss.Text = "";
                    MyProject.Forms.SAPForm.txtCyInsulation.Text = "";
                    MyProject.Forms.SAPForm.txtCyInsThick.Text = "";
                  }
                }
                else if (sedbuk.MainType.Equals("2"))
                {
                  MyProject.Forms.SAPForm.txtCyVolume.Text = "";
                  MyProject.Forms.SAPForm.txtCyDLoss.Text = "";
                  MyProject.Forms.SAPForm.txtCyInsulation.Text = "";
                  MyProject.Forms.SAPForm.txtCyInsThick.Text = "";
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.Volume = (float) Conversion.Val(MyProject.Forms.SAPForm.txtCyVolume.Text);
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.ManuSpecified = MyProject.Forms.SAPForm.optCyManuLoss.Checked;
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.DeclaredLoss = (float) Conversion.Val(MyProject.Forms.SAPForm.txtCyDLoss.Text);
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.Insulation = MyProject.Forms.SAPForm.txtCyInsulation.Text;
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.InsThick = (float) Conversion.Val(MyProject.Forms.SAPForm.txtCyInsThick.Text);
                }
                goto label_196;
              }
              else
                goto label_196;
            }
            else if (Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SGroup, "Micro-cogeneration (micro-CHP)", false) == 0)
            {
              List<PCDF.CHP> chPs = SAP_Module.PCDFData.CHPs;
              Func<PCDF.CHP, bool> predicate;
              // ISSUE: reference to a compiler-generated field
              if (WaterHeating._Closure\u0024__.\u0024I1\u002D5 != null)
              {
                // ISSUE: reference to a compiler-generated field
                predicate = WaterHeating._Closure\u0024__.\u0024I1\u002D5;
              }
              else
              {
                // ISSUE: reference to a compiler-generated field
                WaterHeating._Closure\u0024__.\u0024I1\u002D5 = predicate = (Func<PCDF.CHP, bool>) (b => b.ID.Equals(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SEDBUK));
              }
              PCDF.CHP chp = chPs.Where<PCDF.CHP>(predicate).SingleOrDefault<PCDF.CHP>();
              if (chp != null)
              {
                MyProject.Forms.SAPForm.grpHeapPumpImmersion.Enabled = true;
                if (Conversion.Val(chp.HWVessel) != 1.0)
                {
                  MyProject.Forms.SAPForm.grpCylinder.Enabled = true;
                  MyProject.Forms.SAPForm.optCyPipeWork.Enabled = true;
                  MyProject.Forms.SAPForm.optCyTimed.Enabled = true;
                  MyProject.Forms.SAPForm.grpThermalStore.Enabled = true;
                  if (Conversion.Val(chp.Flue_Type) == 3.0)
                  {
                    SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Thermal.Include = false;
                    MyProject.Forms.SAPForm.chkThermal.Checked = false;
                    MyProject.Forms.SAPForm.txtCyVolume.Enabled = false;
                    MyProject.Forms.SAPForm.optCyManuLoss.Enabled = false;
                    MyProject.Forms.SAPForm.txtCyInsulation.Enabled = false;
                    MyProject.Forms.SAPForm.txtCyInsThick.Enabled = false;
                    MyProject.Forms.SAPForm.chkThermal.Enabled = false;
                    MyProject.Forms.SAPForm.txtThermalLocation.Enabled = true;
                  }
                }
                goto label_196;
              }
              else
                goto label_196;
            }
            else if (Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SGroup, "Heat pumps", false) == 0)
            {
              List<PCDF.HeatPump> heatPumps = SAP_Module.PCDFData.HeatPumps;
              Func<PCDF.HeatPump, bool> predicate;
              // ISSUE: reference to a compiler-generated field
              if (WaterHeating._Closure\u0024__.\u0024I1\u002D6 != null)
              {
                // ISSUE: reference to a compiler-generated field
                predicate = WaterHeating._Closure\u0024__.\u0024I1\u002D6;
              }
              else
              {
                // ISSUE: reference to a compiler-generated field
                WaterHeating._Closure\u0024__.\u0024I1\u002D6 = predicate = (Func<PCDF.HeatPump, bool>) (b => b.ID.Equals(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SEDBUK));
              }
              PCDF.HeatPump heatPump = heatPumps.Where<PCDF.HeatPump>(predicate).SingleOrDefault<PCDF.HeatPump>();
              if (heatPump != null)
              {
                MyProject.Forms.SAPForm.grpHeapPumpImmersion.Enabled = true;
                if (Conversion.Val(heatPump.HWvessel) != 1.0)
                {
                  MyProject.Forms.SAPForm.grpCylinder.Enabled = true;
                  MyProject.Forms.SAPForm.optCyPipeWork.Enabled = true;
                  MyProject.Forms.SAPForm.optCyTimed.Enabled = true;
                  MyProject.Forms.SAPForm.grpThermalStore.Enabled = true;
                  if (Conversion.Val(heatPump.Flue_Type) == 3.0)
                  {
                    SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Thermal.Include = false;
                    MyProject.Forms.SAPForm.chkThermal.Checked = false;
                    MyProject.Forms.SAPForm.txtCyVolume.Enabled = false;
                    MyProject.Forms.SAPForm.optCyManuLoss.Enabled = false;
                    MyProject.Forms.SAPForm.txtCyInsulation.Enabled = false;
                    MyProject.Forms.SAPForm.txtCyInsThick.Enabled = false;
                    MyProject.Forms.SAPForm.chkThermal.Enabled = false;
                    MyProject.Forms.SAPForm.txtThermalLocation.Enabled = true;
                  }
                  if (Conversion.Val(heatPump.HWvessel) == 2.0)
                    MyProject.Forms.SAPForm.txtHeatPumpExchanger.Enabled = true;
                }
                goto label_196;
              }
              else
                goto label_196;
            }
            else if (Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SGroup, "Solid fuel boilers", false) == 0)
            {
              List<PCDF.SEDBUK_Solid> solidBoilers = SAP_Module.PCDFData.Solid_Boilers;
              Func<PCDF.SEDBUK_Solid, bool> predicate;
              // ISSUE: reference to a compiler-generated field
              if (WaterHeating._Closure\u0024__.\u0024I1\u002D7 != null)
              {
                // ISSUE: reference to a compiler-generated field
                predicate = WaterHeating._Closure\u0024__.\u0024I1\u002D7;
              }
              else
              {
                // ISSUE: reference to a compiler-generated field
                WaterHeating._Closure\u0024__.\u0024I1\u002D7 = predicate = (Func<PCDF.SEDBUK_Solid, bool>) (b => b.ID.Equals(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SEDBUK));
              }
              if (solidBoilers.Where<PCDF.SEDBUK_Solid>(predicate).SingleOrDefault<PCDF.SEDBUK_Solid>() != null)
              {
                MyProject.Forms.SAPForm.optCySummer.Enabled = true;
                MyProject.Forms.SAPForm.grpCylinder.Enabled = true;
                MyProject.Forms.SAPForm.optCyPipeWork.Enabled = true;
                MyProject.Forms.SAPForm.optCyTimed.Enabled = true;
                MyProject.Forms.SAPForm.grpThermalStore.Enabled = true;
              }
              goto label_196;
            }
            else
              goto label_196;
          }
          else
          {
            int sapTableCode7 = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SAPTableCode;
            int num10;
            switch (sapTableCode7)
            {
              case 101:
              case 102:
              case 105:
              case 106:
              case 109:
              case 110:
              case 111:
              case 114:
              case 115:
              case 116:
              case 117:
              case 119:
              case 120:
              case 121:
              case 122:
              case 123:
              case 124:
              case 125:
              case 126:
              case (int) sbyte.MaxValue:
              case 131:
              case 132:
              case 133:
              case 134:
              case 135:
              case 136:
              case 137:
              case 138:
              case 139:
              case 140:
                num10 = 1;
                break;
              default:
                num10 = sapTableCode7 == 141 ? 1 : 0;
                break;
            }
            if (num10 != 0)
            {
              MyProject.Forms.SAPForm.grpCylinder.Enabled = true;
              MyProject.Forms.SAPForm.grpThermalStore.Enabled = true;
              switch (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SAPTableCode)
              {
                case 120:
                case 121:
                case 122:
                case 123:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Thermal.Include = false;
                  MyProject.Forms.SAPForm.chkThermal.Checked = false;
                  MyProject.Forms.SAPForm.chkThermal.Enabled = false;
                  MyProject.Forms.SAPForm.txtThermalLocation.Enabled = true;
                  break;
              }
            }
            else if (sapTableCode7 == 103 || sapTableCode7 == 104 || sapTableCode7 == 107 || sapTableCode7 == 108 || sapTableCode7 == 112 || sapTableCode7 == 113 || sapTableCode7 == 118 || sapTableCode7 == 128 || sapTableCode7 == 129 || sapTableCode7 == 130)
            {
              MyProject.Forms.SAPForm.grpWBoiler.Enabled = true;
              if (Operators.CompareString(MyProject.Forms.SAPForm.txtWCombiType.Text, "", false) == 0)
                MyProject.Forms.SAPForm.txtWCombiType.Text = "Instantaneous Combi";
              if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.CombiType != null && Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.CombiType, "Storage combi boiler, primary store", false) == 0 | Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.CombiType, "Storage combi boiler, secondary store", false) == 0)
                MyProject.Forms.SAPForm.grpCylinder.Enabled = true;
            }
            else if (sapTableCode7 >= 151 && sapTableCode7 <= 207)
            {
              MyProject.Forms.SAPForm.grpCylinder.Enabled = true;
              MyProject.Forms.SAPForm.grpThermalStore.Enabled = true;
            }
            else if (sapTableCode7 >= 306 && sapTableCode7 <= 310)
              MyProject.Forms.SAPForm.grpThermalStore.Enabled = true;
            else if (sapTableCode7 == 602 || sapTableCode7 == 604 || sapTableCode7 == 606 || sapTableCode7 == 622 || sapTableCode7 == 624 || sapTableCode7 == 632 || sapTableCode7 == 634 || sapTableCode7 == 636)
            {
              MyProject.Forms.SAPForm.grpCylinder.Enabled = true;
              MyProject.Forms.SAPForm.grpThermalStore.Enabled = true;
            }
            else if (sapTableCode7 >= 501 && sapTableCode7 <= 514 || sapTableCode7 >= 521 && sapTableCode7 <= 527)
            {
              MyProject.Forms.SAPForm.grpCylinder.Enabled = true;
              MyProject.Forms.SAPForm.grpThermalStore.Enabled = true;
            }
            else
            {
              int num11;
              switch (sapTableCode7)
              {
                case 0:
                  int num12 = (int) Interaction.MsgBox((object) "Please specify main heating first.", MsgBoxStyle.Information, (object) "Water Heating");
                  MyProject.Forms.SAPForm.txtWater.Text = "";
                  return;
                case 103:
                case 104:
                case 107:
                case 108:
                case 112:
                case 113:
                case 118:
                case 128:
                case 129:
                  num11 = 1;
                  break;
                default:
                  num11 = sapTableCode7 == 130 ? 1 : 0;
                  break;
              }
              if (num11 == 0)
              {
                if (sapTableCode7 >= 211 && sapTableCode7 <= 227)
                {
                  MyProject.Forms.SAPForm.grpCylinder.Enabled = true;
                  MyProject.Forms.SAPForm.grpThermalStore.Enabled = true;
                }
                else
                {
                  int num13 = (int) Interaction.MsgBox((object) "Main heating not suitable to heat water.", MsgBoxStyle.Information, (object) "Water Heating");
                  MyProject.Forms.SAPForm.txtWater.Text = "";
                  return;
                }
              }
            }
            MyProject.Forms.SAPForm.optCyPipeWork.Enabled = true;
            MyProject.Forms.SAPForm.optCyTimed.Enabled = true;
            int sapTableCode8 = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SAPTableCode;
            if (sapTableCode8 == 192)
              MyProject.Forms.SAPForm.grpCPSU.Enabled = true;
            else if (sapTableCode8 >= 120 && sapTableCode8 <= 123)
              MyProject.Forms.SAPForm.grpCPSU.Enabled = true;
            int sapTableCode9 = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SAPTableCode;
            if (sapTableCode9 >= 156 && sapTableCode9 <= 161 || sapTableCode9 == 632 || sapTableCode9 == 634 || sapTableCode9 == 636)
            {
              MyProject.Forms.SAPForm.optCySummer.Enabled = true;
            }
            else
            {
              MyProject.Forms.SAPForm.optCySummer.Enabled = false;
              MyProject.Forms.SAPForm.optCySummer.Checked = false;
              int sapTableCode10 = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SAPTableCode;
              if (sapTableCode10 == 191 || sapTableCode10 >= 193 && sapTableCode10 <= 196)
              {
                MyProject.Forms.SAPForm.txtImmersion.Enabled = true;
              }
              else
              {
                MyProject.Forms.SAPForm.txtImmersion.Enabled = false;
                MyProject.Forms.SAPForm.txtImmersion.Text = "";
              }
            }
            int sapTableCode11 = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SAPTableCode;
            if (sapTableCode11 >= 201 && sapTableCode11 <= 207)
              MyProject.Forms.SAPForm.grpHeapPumpImmersion.Enabled = true;
            int sapTableCode12 = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SAPTableCode;
            if (sapTableCode12 >= 306 && sapTableCode12 <= 310)
              MyProject.Forms.SAPForm.grpDHWComm.Enabled = true;
            goto label_196;
          }
        case 950:
          num1 = 1;
          break;
        default:
          num1 = systemRef == 952 ? 1 : 0;
          break;
      }
      if (num1 != 0)
      {
        MyProject.Forms.SAPForm.grpDHWComm.Enabled = true;
        MyProject.Forms.SAPForm.txtDHWCommCHP.Enabled = false;
        MyProject.Forms.SAPForm.txtDHWCommHDS.Enabled = true;
        MyProject.Forms.SAPForm.txtDHWCommEff.Enabled = true;
        MyProject.Forms.SAPForm.optCyPipeWork.Enabled = true;
      }
      else
      {
        int num14;
        switch (systemRef)
        {
          case 903:
            MyProject.Forms.SAPForm.grpCylinder.Enabled = true;
            MyProject.Forms.SAPForm.grpThermalStore.Enabled = true;
            MyProject.Forms.SAPForm.txtImmersion.Enabled = true;
            goto label_196;
          case 911:
          case 912:
            num14 = 1;
            break;
          case 951:
            MyProject.Forms.SAPForm.grpDHWComm.Enabled = true;
            MyProject.Forms.SAPForm.txtDHWCommCHP.Enabled = true;
            MyProject.Forms.SAPForm.txtDHWCommHDS.Enabled = true;
            MyProject.Forms.SAPForm.txtDHWCommEff.Enabled = true;
            MyProject.Forms.SAPForm.optCyPipeWork.Enabled = true;
            goto label_196;
          default:
            num14 = systemRef == 913 ? 1 : 0;
            break;
        }
        if (num14 != 0)
        {
          MyProject.Forms.SAPForm.grpCylinder.Enabled = true;
          MyProject.Forms.SAPForm.optCyPipeWork.Enabled = true;
          MyProject.Forms.SAPForm.optCyTimed.Enabled = true;
        }
        else if (systemRef >= 921 && systemRef <= 931)
        {
          MyProject.Forms.SAPForm.grpCylinder.Enabled = true;
          MyProject.Forms.SAPForm.optCyPipeWork.Enabled = true;
          MyProject.Forms.SAPForm.optCyTimed.Enabled = true;
        }
        else if (systemRef != 904 && systemRef != 905 && systemRef != 906)
          ;
      }
label_196:;
    }

    public static void PaniCheck(int HeatingType, string NewFuel, int house)
    {
      if (HeatingType != 3)
      {
        MyProject.Forms.SAPForm.txtHeatPumpImmersion.Text = "";
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.HPImmersion = "";
      }
      try
      {
        switch (SAP_Module.Proj.Dwellings[house].Water.SystemRef)
        {
          case 901:
            if (HeatingType != 1)
              break;
            SAP_Module.Proj.Dwellings[house].Water.Fuel = NewFuel;
            SAP_Module.Proj.Dwellings[house].Water.System = "From main heating system";
            WaterHeating.CheckWaterType_AndFuel("From main heating system");
            break;
          case 902:
            if (HeatingType != 3)
              break;
            SAP_Module.Proj.Dwellings[house].Water.Fuel = NewFuel;
            WaterHeating.CheckWaterType_AndFuel("From secondary system");
            break;
          case 914:
            if (HeatingType != 2)
              break;
            SAP_Module.Proj.Dwellings[house].Water.Fuel = NewFuel;
            WaterHeating.CheckWaterType_AndFuel("From second main heating system");
            break;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }
  }
}
