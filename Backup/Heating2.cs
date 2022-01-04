
// Type: SAP2012.Heating2




using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using SAP2012.My;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SAP2012
{
  [StandardModule]
  internal sealed class Heating2
  {
    public static void PrimaryHeatingSubGroupCheck2()
    {
      MyProject.Forms.SAPForm.pnlMainSecEff1.BringToFront();
      MyProject.Forms.SAPForm.txtSecMainFuel.Enabled = false;
      MyProject.Forms.SAPForm.txtSecMainFuel.Text = "";
      MyProject.Forms.SAPForm.txtSecHeatingSource.Items.Clear();
      MyProject.Forms.SAPForm.txtSecHeatingSource.Text = "";
      MyProject.Forms.SAPForm.txtSecMainHeatingType.Text = "";
      MyProject.Forms.SAPForm.txtSecMainHeatingType.Enabled = false;
      MyProject.Forms.SAPForm.txtSecBoilerSub.Text = "";
      MyProject.Forms.SAPForm.txtSecBoilerSub.Enabled = false;
      MyProject.Forms.SAPForm.grpSecHETASMain.Enabled = false;
      MyProject.Forms.SAPForm.txtSecHETASMain.Text = "";
      MyProject.Forms.SAPForm.grpSecKeepHot.Enabled = false;
      MyProject.Forms.SAPForm.chkSecKeepHot.Checked = false;
      MyProject.Forms.SAPForm.txtSecKeepHotFuel.Text = "";
      MyProject.Forms.SAPForm.chkSecKeepHotTimed.Checked = false;
      MyProject.Forms.SAPForm.grpSecRange.Visible = false;
      MyProject.Forms.SAPForm.grpSecBoilerInfo.Visible = false;
      MyProject.Forms.SAPForm.grpSecCompensator.Visible = false;
      MyProject.Forms.SAPForm.grpCommHSec.Visible = false;
      MyProject.Forms.SAPForm.grpSecCompensator.Visible = false;
      string text1 = MyProject.Forms.SAPForm.txtSecSubGroup.Text;
      if (Operators.CompareString(text1, "Gas boilers and oil boilers", false) == 0 || Operators.CompareString(text1, "Micro-cogeneration (micro-CHP)", false) == 0 || Operators.CompareString(text1, "Solid fuel boilers", false) == 0)
        MyProject.Forms.SAPForm.txtSecHeatingSource.Items.Add((object) "Boiler Database");
      if (Operators.CompareString(MyProject.Forms.SAPForm.txtSecSubGroup.Text, "Micro-cogeneration (micro-CHP)", false) != 0)
        MyProject.Forms.SAPForm.txtSecHeatingSource.Items.Add((object) "SAP Tables");
      string text2 = MyProject.Forms.SAPForm.txtSecSubGroup.Text;
      if (Operators.CompareString(text2, "Micro-cogeneration (micro-CHP)", false) != 0 && Operators.CompareString(text2, "Heat pumps", false) != 0 && Operators.CompareString(text2, "Electric heat pumps", false) != 0 && Operators.CompareString(text2, "Gas-fired heat pumps", false) != 0)
        MyProject.Forms.SAPForm.txtSecHeatingSource.Items.Add((object) "Manufacturer Declaration");
      if (MyProject.Forms.SAPForm.ChkIncSecMain.Checked)
        MyProject.Forms.SAPForm.txtSecHeatingSource.Enabled = true;
      string text3 = MyProject.Forms.SAPForm.txtSecSubGroup.Text;
      if (Operators.CompareString(text3, "Gas boilers and oil boilers", false) != 0 && Operators.CompareString(text3, "Micro-cogeneration (micro-CHP)", false) != 0 && Operators.CompareString(text3, "Solid fuel boilers", false) != 0 && Operators.CompareString(text3, "Electric boilers", false) != 0)
      {
        if (Operators.CompareString(text3, "Electric heat pumps", false) != 0 && Operators.CompareString(text3, "Gas-fired heat pumps", false) != 0)
          return;
        MyProject.Forms.SAPForm.txtSecHeatingSource.Items.Add((object) "Boiler Database");
        string text4 = MyProject.Forms.SAPForm.txtSECPrimary.Text;
        SAP_Module.TableGroup = Operators.CompareString(MyProject.Forms.SAPForm.txtSECPrimary.Text, "Heat pumps with warm air distribution", false) != 0 ? 2 : 5;
        MyProject.Forms.SAPForm.txtSecHeatingControls.Text = "";
        Heating2.PopControlsSec();
      }
      else
      {
        SAP_Module.TableGroup = 1;
        MyProject.Forms.SAPForm.txtSecHeatingControls.Text = "";
        Heating2.PopControlsSec();
      }
    }

    public static void PrimaryHeatingGroupCheck2()
    {
      MyProject.Forms.SAPForm.pnlMainSecEff1.BringToFront();
      MyProject.Forms.SAPForm.txtSecMainFuel.Enabled = false;
      MyProject.Forms.SAPForm.txtSecMainFuel.Text = "";
      MyProject.Forms.SAPForm.txtSecSubGroup.Items.Clear();
      MyProject.Forms.SAPForm.txtSecSubGroup.Text = "";
      MyProject.Forms.SAPForm.txtSecSubGroup.Enabled = false;
      MyProject.Forms.SAPForm.txtSecHeatingEmitter.Enabled = false;
      MyProject.Forms.SAPForm.txtSecHeatingEmitter.Text = "";
      MyProject.Forms.SAPForm.txtSecHeatingControls.Enabled = false;
      MyProject.Forms.SAPForm.txtSecHeatingControls.Text = "";
      MyProject.Forms.SAPForm.txtSecHeatingSource.Text = "";
      MyProject.Forms.SAPForm.txtSecHeatingSource.Enabled = false;
      MyProject.Forms.SAPForm.txtSecHeatingSource.Items.Clear();
      MyProject.Forms.SAPForm.txtSecBoilerSub.Text = "";
      MyProject.Forms.SAPForm.txtSecBoilerSub.Enabled = false;
      MyProject.Forms.SAPForm.txtSecMainHeatingType.Text = "";
      MyProject.Forms.SAPForm.txtSecMainHeatingType.Enabled = false;
      MyProject.Forms.SAPForm.txtSecMainHeatingType.Items.Clear();
      MyProject.Forms.SAPForm.grpSecHETASMain.Enabled = false;
      MyProject.Forms.SAPForm.txtSecHETASMain.Text = "";
      MyProject.Forms.SAPForm.grpSecRange.Visible = false;
      MyProject.Forms.SAPForm.grpSecCompensator.Visible = false;
      MyProject.Forms.SAPForm.grpSecKeepHot.Enabled = false;
      MyProject.Forms.SAPForm.chkSecKeepHot.Checked = false;
      MyProject.Forms.SAPForm.txtSecKeepHotFuel.Text = "";
      MyProject.Forms.SAPForm.chkSecKeepHotTimed.Checked = false;
      MyProject.Forms.SAPForm.grpCommHSec.Visible = false;
      MyProject.Forms.SAPForm.grpSecEfficiency.Visible = true;
      MyProject.Forms.SAPForm.grpSecBoilerInfo.Visible = false;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].WaterOnlyHeatPump = false;
      string text = MyProject.Forms.SAPForm.txtSECPrimary.Text;
      // ISSUE: reference to a compiler-generated method
      switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(text))
      {
        case 743056865:
          if (Operators.CompareString(text, "Heat pumps with warm air distribution", false) != 0)
            return;
          break;
        case 1278633908:
          if (Operators.CompareString(text, "Room heaters", false) != 0)
            return;
          MyProject.Forms.SAPForm.txtSecSubGroup.Enabled = true;
          MyProject.Forms.SAPForm.txtSecSubGroup.Items.Add((object) "Gas (including LPG) room heaters");
          MyProject.Forms.SAPForm.txtSecSubGroup.Items.Add((object) "Oil room heaters");
          MyProject.Forms.SAPForm.txtSecSubGroup.Items.Add((object) "Solid fuel room heaters");
          MyProject.Forms.SAPForm.txtSecSubGroup.Items.Add((object) "Electric (direct acting) room heaters");
          SAP_Module.TableGroup = 6;
          Heating2.PopControlsSec();
          return;
        case 1356142837:
          if (Operators.CompareString(text, "Electric storage systems", false) != 0)
            return;
          MyProject.Forms.SAPForm.txtSecSubGroup.Enabled = true;
          MyProject.Forms.SAPForm.txtSecSubGroup.Items.Add((object) "Off-peak tariffs");
          MyProject.Forms.SAPForm.txtSecSubGroup.Items.Add((object) "24-hour heating tariff");
          SAP_Module.TableGroup = 4;
          Heating2.PopControlsSec();
          return;
        case 1403793243:
          if (Operators.CompareString(text, "Micro-Congeneration (Micro-CHP)", false) != 0)
            return;
          MyProject.Forms.SAPForm.txtSecSubGroup.Enabled = false;
          MyProject.Forms.SAPForm.txtSecSubGroup.Items.Add((object) "Micro-cogeneration (micro-CHP)");
          MyProject.Forms.SAPForm.txtSecSubGroup.SelectedIndex = 0;
          MyProject.Forms.SAPForm.txtSecHeatingEmitter.Enabled = true;
          return;
        case 1754365722:
          if (Operators.CompareString(text, "Warm air systems (Not heat pump)", false) != 0)
            return;
          MyProject.Forms.SAPForm.txtSecSubGroup.Enabled = true;
          MyProject.Forms.SAPForm.txtSecSubGroup.Items.Add((object) "Gas-fired warm air with fan-assisted flue");
          MyProject.Forms.SAPForm.txtSecSubGroup.Items.Add((object) "Gas fired warm air with balanced or open flue");
          MyProject.Forms.SAPForm.txtSecSubGroup.Items.Add((object) "Oil-fired warm air");
          MyProject.Forms.SAPForm.txtSecSubGroup.Items.Add((object) "Electric warm air");
          SAP_Module.TableGroup = 5;
          Heating2.PopControlsSec();
          return;
        case 2058786912:
          if (Operators.CompareString(text, "Electric underfloor heating", false) != 0)
            return;
          MyProject.Forms.SAPForm.txtSecSubGroup.Enabled = true;
          MyProject.Forms.SAPForm.txtSecSubGroup.Items.Add((object) "Off-peak tariffs");
          MyProject.Forms.SAPForm.txtSecSubGroup.Items.Add((object) "Standard tariff");
          SAP_Module.TableGroup = 7;
          Heating2.PopControlsSec();
          return;
        case 2185270936:
          if (Operators.CompareString(text, "Community heating schemes", false) != 0)
            return;
          MyProject.Forms.SAPForm.txtSecSubGroup.Enabled = false;
          MyProject.Forms.SAPForm.txtSecHeatingSource.Items.Add((object) "SAP Tables");
          MyProject.Forms.SAPForm.txtSecHeatingSource.Items.Add((object) "Manufacturer Declaration");
          MyProject.Forms.SAPForm.txtSecHeatingSource.Enabled = true;
          MyProject.Forms.SAPForm.grpSecEfficiency.Visible = false;
          SAP_Module.TableGroup = 3;
          Heating2.PopControlsSec();
          return;
        case 2419931075:
          if (Operators.CompareString(text, "Other space heating systems", false) != 0)
            return;
          MyProject.Forms.SAPForm.txtSecSubGroup.Enabled = false;
          MyProject.Forms.SAPForm.txtSecHeatingEmitter.Enabled = true;
          MyProject.Forms.SAPForm.txtSecHeatingSource.Items.Add((object) "SAP Tables");
          MyProject.Forms.SAPForm.txtSecHeatingSource.Items.Add((object) "Manufacturer Declaration");
          MyProject.Forms.SAPForm.txtSecHeatingSource.Enabled = true;
          SAP_Module.TableGroup = 7;
          Heating2.PopControlsSec();
          return;
        case 2707799250:
          if (Operators.CompareString(text, "Heat pumps with radiators or underfloor heating", false) != 0)
            return;
          break;
        case 4284389836:
          if (Operators.CompareString(text, "Boiler systems with radiators or underfloor heating", false) != 0)
            return;
          MyProject.Forms.SAPForm.txtSecSubGroup.Enabled = true;
          MyProject.Forms.SAPForm.txtSecSubGroup.Items.Add((object) "Gas boilers and oil boilers");
          MyProject.Forms.SAPForm.txtSecSubGroup.Items.Add((object) "Solid fuel boilers");
          MyProject.Forms.SAPForm.txtSecSubGroup.Items.Add((object) "Electric boilers");
          MyProject.Forms.SAPForm.txtSecHeatingEmitter.Enabled = true;
          Heating2.PopControlsSec();
          return;
        default:
          return;
      }
      MyProject.Forms.SAPForm.txtSecSubGroup.Enabled = true;
      MyProject.Forms.SAPForm.txtSecSubGroup.Items.Add((object) "Electric heat pumps");
      MyProject.Forms.SAPForm.txtSecSubGroup.Items.Add((object) "Gas-fired heat pumps");
      MyProject.Forms.SAPForm.txtSecHeatingEmitter.Enabled = true;
    }

    public static void CheckSource2()
    {
      MyProject.Forms.SAPForm.pnlMainSecEff1.BringToFront();
      MyProject.Forms.SAPForm.grpCommHSec.Visible = false;
      MyProject.Forms.SAPForm.grpSecCompensator.Visible = false;
      MyProject.Forms.SAPForm.txtSecMainFuel.Enabled = false;
      MyProject.Forms.SAPForm.txtSecMainFuel.Text = "";
      MyProject.Forms.SAPForm.txtSecMainHeatingType.Enabled = false;
      MyProject.Forms.SAPForm.txtSecMainHeatingType.Text = "";
      MyProject.Forms.SAPForm.txtSecMainHeatingType.Items.Clear();
      MyProject.Forms.SAPForm.chkSecSEDBUK2005.Visible = false;
      MyProject.Forms.SAPForm.chkSecSEDBUK2005.Checked = false;
      MyProject.Forms.SAPForm.txtSecBoilerSub.Text = "";
      MyProject.Forms.SAPForm.txtSecBoilerSub.Enabled = false;
      MyProject.Forms.SAPForm.grpSecRange.Visible = false;
      MyProject.Forms.SAPForm.grpSecHETASMain.Enabled = false;
      MyProject.Forms.SAPForm.txtSecHETASMain.Text = "";
      if (Operators.CompareString(MyProject.Forms.SAPForm.txtSecHeatingSource.Text, "Boiler Database", false) == 0)
      {
        MyProject.Forms.SAPForm.cmdBiolerData2.Enabled = true;
      }
      else
      {
        MyProject.Forms.SAPForm.cmdBiolerData2.Enabled = false;
        MyProject.Forms.SAPForm.grpSecBoilerInfo.Visible = false;
      }
      MyProject.Forms.SAPForm.grpSecKeepHot.Enabled = false;
      MyProject.Forms.SAPForm.chkSecKeepHot.Checked = false;
      MyProject.Forms.SAPForm.txtSecKeepHotFuel.Text = "";
      MyProject.Forms.SAPForm.chkSecKeepHotTimed.Checked = false;
      if (Operators.CompareString(MyProject.Forms.SAPForm.txtSecHeatingSource.Text, "SAP Tables", false) == 0 | Operators.CompareString(MyProject.Forms.SAPForm.txtSecHeatingSource.Text, "Manufacturer Declaration", false) == 0)
      {
        string text = MyProject.Forms.SAPForm.txtSecSubGroup.Text;
        if (Operators.CompareString(text, "Gas boilers and oil boilers", false) != 0)
        {
          if (Operators.CompareString(text, "Micro-cogeneration (micro-CHP)", false) != 0)
          {
            List<PCDF.Table4a_B> table4aBs = SAP_Module.PCDFData.Table4a_bs;
            Func<PCDF.Table4a_B, bool> predicate;
            // ISSUE: reference to a compiler-generated field
            if (Heating2._Closure\u0024__.\u0024I2\u002D0 != null)
            {
              // ISSUE: reference to a compiler-generated field
              predicate = Heating2._Closure\u0024__.\u0024I2\u002D0;
            }
            else
            {
              // ISSUE: reference to a compiler-generated field
              Heating2._Closure\u0024__.\u0024I2\u002D0 = predicate = (Func<PCDF.Table4a_B, bool>) (b => b.FirstGroup.ToUpper().Equals(MyProject.Forms.SAPForm.txtSECPrimary.Text.ToUpper()) & b.SecondGroup.ToUpper().Equals(MyProject.Forms.SAPForm.txtSecSubGroup.Text.ToUpper()));
            }
            List<PCDF.Table4a_B> list = table4aBs.Where<PCDF.Table4a_B>(predicate).ToList<PCDF.Table4a_B>();
            try
            {
              foreach (PCDF.Table4a_B table4aB in list)
                MyProject.Forms.SAPForm.txtSecMainHeatingType.Items.Add((object) table4aB.Description);
            }
            finally
            {
              List<PCDF.Table4a_B>.Enumerator enumerator;
              enumerator.Dispose();
            }
            MyProject.Forms.SAPForm.txtSecMainHeatingType.Enabled = true;
          }
        }
        else
          MyProject.Forms.SAPForm.txtSecBoilerSub.Enabled = true;
      }
      else
        MyProject.Forms.SAPForm.txtSecMainHeatingType.Enabled = false;
      if (Operators.CompareString(MyProject.Forms.SAPForm.txtSecHeatingSource.Text, "Manufacturer Declaration", false) == 0)
      {
        MyProject.Forms.SAPForm.txtSecEfficiency.Enabled = true;
        MyProject.Forms.SAPForm.txtSecDescription.Enabled = true;
      }
      else
      {
        MyProject.Forms.SAPForm.txtSecEfficiency.Enabled = false;
        MyProject.Forms.SAPForm.txtSecDescription.Enabled = false;
        MyProject.Forms.SAPForm.txtSecDescription.Text = "";
      }
      if (Operators.CompareString(MyProject.Forms.SAPForm.txtSecHeatingSource.Text, "Manufacturer Declaration", false) == 0 & Operators.CompareString(MyProject.Forms.SAPForm.txtSecSubGroup.Text, "Gas boilers and oil boilers", false) == 0)
        MyProject.Forms.SAPForm.chkSecSEDBUK2005.Visible = true;
      else
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SEDBUK2005 = false;
    }

    public static void PopControlsSec()
    {
      MyProject.Forms.SAPForm.txtSecHeatingControls.Items.Clear();
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.TableGroup = SAP_Module.TableGroup;
      List<PCDF.Table4e> table4es = SAP_Module.PCDFData.Table4es;
      Func<PCDF.Table4e, bool> predicate;
      // ISSUE: reference to a compiler-generated field
      if (Heating2._Closure\u0024__.\u0024I3\u002D0 != null)
      {
        // ISSUE: reference to a compiler-generated field
        predicate = Heating2._Closure\u0024__.\u0024I3\u002D0;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        Heating2._Closure\u0024__.\u0024I3\u002D0 = predicate = (Func<PCDF.Table4e, bool>) (b => b.Group.ToUpper().Equals(SAP_Module.TableGroup.ToString().ToUpper()));
      }
      List<PCDF.Table4e> list = table4es.Where<PCDF.Table4e>(predicate).ToList<PCDF.Table4e>();
      int num = checked (list.Count - 1);
      int index = 0;
      while (index <= num)
      {
        MyProject.Forms.SAPForm.txtSecHeatingControls.Items.Add((object) list[index].Description);
        checked { ++index; }
      }
      if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].WaterOnlyHeatPump)
      {
        MyProject.Forms.SAPForm.txtSecHeatingControls.Enabled = false;
        MyProject.Forms.SAPForm.txtSecHeatingControls.Items.Add((object) "Not applicable (boiler provides DHW only");
        MyProject.Forms.SAPForm.txtSecHeatingControls.Text = "Not applicable (boiler provides DHW only)";
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.TableGroup = 1;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.ControlCode = 2100;
      }
      else
        MyProject.Forms.SAPForm.txtSecHeatingControls.Enabled = true;
    }

    public static void CheckBoilerSubSec()
    {
      if (Operators.CompareString(MyProject.Forms.SAPForm.txtSecBoilerSub.Text, "", false) == 0)
        return;
      MyProject.Forms.SAPForm.grpCommHSec.Visible = false;
      if ((uint) Operators.CompareString(MyProject.Forms.SAPForm.txtSecSubGroup.Text, "Electric boilers", false) > 0U)
      {
        MyProject.Forms.SAPForm.txtSecMainFuel.Enabled = false;
        MyProject.Forms.SAPForm.txtSecMainFuel.Text = "";
        MyProject.Forms.SAPForm.txtSecMainHeatingType.Text = "";
        MyProject.Forms.SAPForm.txtSecMainHeatingType.Items.Clear();
        MyProject.Forms.SAPForm.txtSecMainHeatingType.Enabled = true;
        MyProject.Forms.SAPForm.grpSecKeepHot.Enabled = false;
        MyProject.Forms.SAPForm.chkSecKeepHot.Checked = false;
        MyProject.Forms.SAPForm.txtSecKeepHotFuel.Text = "";
        MyProject.Forms.SAPForm.chkSecKeepHotTimed.Checked = false;
        string text = MyProject.Forms.SAPForm.txtSecBoilerSub.Text;
        // ISSUE: reference to a compiler-generated method
        switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(text))
        {
          case 799497367:
            if (Operators.CompareString(text, "Gas boilers (including LPG) 1998 or later", false) == 0)
              break;
            goto default;
          case 803062556:
            if (Operators.CompareString(text, "Range cooker boilers (oil)", false) == 0)
              break;
            goto default;
          case 1963717526:
            if (Operators.CompareString(text, "Gas boilers (including LPG) pre-1998, with fan-assisted flue", false) == 0)
              break;
            goto default;
          case 2128692673:
            if (Operators.CompareString(text, "Range cooker boilers (mains gas and LPG)", false) == 0)
              break;
            goto default;
          case 2518842909:
            if (Operators.CompareString(text, "Gas boilers (including LPG) pre-1998, with balanced or open flue", false) == 0)
              break;
            goto default;
          case 3873049789:
            if (Operators.CompareString(text, "Oil boilers", false) == 0)
              break;
            goto default;
          case 4015132498:
            if (Operators.CompareString(text, "Combined Primary Storage Units (CPSU) (mains gas and LPG)", false) == 0)
              break;
            goto default;
          default:
            MyProject.Forms.SAPForm.txtSecMainHeatingType.Enabled = false;
            goto label_21;
        }
        List<PCDF.Table4a_B> table4aBs = SAP_Module.PCDFData.Table4a_bs;
        Func<PCDF.Table4a_B, bool> predicate;
        // ISSUE: reference to a compiler-generated field
        if (Heating2._Closure\u0024__.\u0024I4\u002D0 != null)
        {
          // ISSUE: reference to a compiler-generated field
          predicate = Heating2._Closure\u0024__.\u0024I4\u002D0;
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          Heating2._Closure\u0024__.\u0024I4\u002D0 = predicate = (Func<PCDF.Table4a_B, bool>) (b => b.FirstGroup.ToUpper().Equals(MyProject.Forms.SAPForm.txtSECPrimary.Text.ToUpper()) & b.SecondGroup.ToUpper().Equals(MyProject.Forms.SAPForm.txtSecBoilerSub.Text.ToUpper()));
        }
        List<PCDF.Table4a_B> list = table4aBs.Where<PCDF.Table4a_B>(predicate).ToList<PCDF.Table4a_B>();
        try
        {
          foreach (PCDF.Table4a_B table4aB in list)
            MyProject.Forms.SAPForm.txtSecMainHeatingType.Items.Add((object) table4aB.Description);
        }
        finally
        {
          List<PCDF.Table4a_B>.Enumerator enumerator;
          enumerator.Dispose();
        }
        MyProject.Forms.SAPForm.txtMainHeatingType.Enabled = true;
label_21:;
      }
    }

    public static void CheckFuelTypeForSAPTable2(
      string Description,
      string SubGroup,
      string BoilerSubGroup)
    {
      MyProject.Forms.SAPForm.pnlMainSecEff1.BringToFront();
      if (Operators.CompareString(Description, "", false) == 0)
        return;
      try
      {
        List<PCDF.Table4a_B> table4aBList = Operators.CompareString(MyProject.Forms.SAPForm.txtSECPrimary.Text, "Electric storage systems", false) != 0 ? ((uint) Operators.CompareString(BoilerSubGroup, "", false) <= 0U ? SAP_Module.PCDFData.Table4a_bs.Where<PCDF.Table4a_B>((Func<PCDF.Table4a_B, bool>) (b => b.Description.Equals(Description) & b.FirstGroup.ToUpper().Equals(MyProject.Forms.SAPForm.txtSECPrimary.Text.ToUpper()) & b.SecondGroup.ToUpper().Equals(MyProject.Forms.SAPForm.txtSecSubGroup.Text.ToUpper()))).ToList<PCDF.Table4a_B>() : SAP_Module.PCDFData.Table4a_bs.Where<PCDF.Table4a_B>((Func<PCDF.Table4a_B, bool>) (b => b.Description.ToUpper().Equals(Description.ToUpper()) & b.SecondGroup.ToUpper().Equals(BoilerSubGroup.ToUpper()))).ToList<PCDF.Table4a_B>()) : SAP_Module.PCDFData.Table4a_bs.Where<PCDF.Table4a_B>((Func<PCDF.Table4a_B, bool>) (b => b.Description.ToUpper().Equals(Description.ToUpper()) & b.SecondGroup.ToUpper().Equals(SubGroup.ToUpper()))).ToList<PCDF.Table4a_B>();
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SAPTableCode = Conversions.ToInteger(table4aBList[0].Code);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SEDBUK = "";
        MyProject.Forms.SAPForm.txtSecMainFuel.Text = "";
        MyProject.Forms.SAPForm.txtSecMainFuel.Items.Clear();
        MyProject.Forms.SAPForm.txtSecMainFuel.Enabled = true;
        MyProject.Forms.SAPForm.chkSecMainHLoadWeather.Enabled = false;
        MyProject.Forms.SAPForm.grpSecHETASMain.Enabled = false;
        int sapTableCode1 = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SAPTableCode;
        if (sapTableCode1 >= 151 && sapTableCode1 <= 161 || sapTableCode1 >= 631 && sapTableCode1 <= 636)
          MyProject.Forms.SAPForm.grpSecHETASMain.Enabled = true;
        else
          MyProject.Forms.SAPForm.txtSecHETASMain.Text = "";
        MyProject.Forms.SAPForm.grpSecBoilerInfo.Visible = false;
        int sapTableCode2 = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SAPTableCode;
        if (sapTableCode2 < 300)
        {
          MyProject.Forms.SAPForm.grpSecBoilerInfo.Visible = true;
          MyProject.Forms.SAPForm.txtSecPumpHP.Enabled = true;
          MyProject.Forms.SAPForm.txtSecBILock.Enabled = true;
          int sapTableCode3 = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SAPTableCode;
          if (sapTableCode3 >= 191 && sapTableCode3 <= 196)
          {
            MyProject.Forms.SAPForm.txtSecBFlueType.Enabled = false;
            MyProject.Forms.SAPForm.txtSecBFlueType.Text = "";
            MyProject.Forms.SAPForm.txtSecFanFlued.Enabled = false;
            MyProject.Forms.SAPForm.txtSecFanFlued.Text = "";
          }
          else
          {
            MyProject.Forms.SAPForm.txtSecBFlueType.Enabled = true;
            MyProject.Forms.SAPForm.txtSecFanFlued.Enabled = true;
          }
          if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SAPTableCode == 192)
          {
            MyProject.Forms.SAPForm.grpSecBoilerInfo.Visible = false;
            MyProject.Forms.SAPForm.txtSecPumpHP.Text = "Yes";
            MyProject.Forms.SAPForm.txtSecBILock.Text = "Yes";
          }
          MyProject.Forms.SAPForm.grpSecKeepHot.Enabled = false;
          MyProject.Forms.SAPForm.chkSecKeepHot.Checked = false;
          MyProject.Forms.SAPForm.txtSecKeepHotFuel.Text = "";
          MyProject.Forms.SAPForm.chkSecKeepHotTimed.Checked = false;
          if (Operators.CompareString(MyProject.Forms.SAPForm.txtSecHeatingSource.Text, "Manufacturer Declaration", false) == 0)
          {
            switch (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SAPTableCode)
            {
              case 103:
              case 104:
              case 107:
              case 108:
              case 112:
              case 113:
              case 118:
              case 128:
              case 129:
              case 130:
                MyProject.Forms.SAPForm.grpSecKeepHot.Enabled = true;
                break;
            }
          }
          MyProject.Forms.SAPForm.grpSecRange.Visible = false;
          if (Operators.CompareString(MyProject.Forms.SAPForm.txtSecHeatingSource.Text, "Manufacturer Declaration", false) == 0)
          {
            int sapTableCode4 = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SAPTableCode;
            if (sapTableCode4 >= 133 && sapTableCode4 <= 141)
              MyProject.Forms.SAPForm.grpSecRange.Visible = true;
          }
          int sapTableCode5 = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SAPTableCode;
          if (sapTableCode5 >= 201 && sapTableCode5 <= 207)
            MyProject.Forms.SAPForm.grpSecCompensator.Visible = true;
          else
            MyProject.Forms.SAPForm.txtSecCompensator.Text = "";
          MyProject.Forms.SAPForm.chkSecMainHLoadWeather.Enabled = false;
          switch (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SAPTableCode)
          {
            case 102:
            case 104:
            case 106:
            case 108:
            case 113:
            case 114:
            case 121:
            case 123:
            case (int) sbyte.MaxValue:
            case 130:
              MyProject.Forms.SAPForm.chkSecMainHLoadWeather.Enabled = true;
              break;
            default:
              MyProject.Forms.SAPForm.chkSecMainHLoadWeather.Checked = false;
              break;
          }
        }
        else if (sapTableCode2 >= 306 && sapTableCode2 <= 310)
        {
          MyProject.Forms.SAPForm.grpCommHSec.Visible = true;
          MyProject.Forms.SAPForm.txtSecCommHB1HeatToPower.Enabled = false;
          switch (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SAPTableCode)
          {
            case 307:
              MyProject.Forms.SAPForm.txtCommHB1HeatToPower.Enabled = true;
              break;
          }
        }
        else if (sapTableCode2 >= 501 && sapTableCode2 <= 505)
        {
          MyProject.Forms.SAPForm.grpSecBoilerInfo.Visible = true;
          MyProject.Forms.SAPForm.txtSecPumpHP.Enabled = false;
          MyProject.Forms.SAPForm.txtSecBILock.Enabled = false;
          MyProject.Forms.SAPForm.txtSecBFlueType.Enabled = true;
          MyProject.Forms.SAPForm.txtSecFanFlued.Enabled = true;
        }
        else if (sapTableCode2 >= 506 && sapTableCode2 <= 514)
        {
          MyProject.Forms.SAPForm.grpSecBoilerInfo.Visible = true;
          MyProject.Forms.SAPForm.txtSecPumpHP.Enabled = false;
          MyProject.Forms.SAPForm.txtSecBILock.Enabled = false;
          MyProject.Forms.SAPForm.txtSecBFlueType.Enabled = true;
          MyProject.Forms.SAPForm.txtSecFanFlued.Enabled = false;
        }
        else if (sapTableCode2 >= 521 && sapTableCode2 <= 527)
        {
          MyProject.Forms.SAPForm.grpSecBoilerInfo.Visible = true;
          MyProject.Forms.SAPForm.txtSecPumpHP.Enabled = false;
          MyProject.Forms.SAPForm.txtSecBILock.Enabled = false;
          MyProject.Forms.SAPForm.txtSecBFlueType.Enabled = true;
          MyProject.Forms.SAPForm.txtSecFanFlued.Enabled = true;
        }
        else if (sapTableCode2 == 701)
        {
          MyProject.Forms.SAPForm.txtSecHeatingEmitter.Enabled = false;
          MyProject.Forms.SAPForm.txtSecHeatingEmitter.Text = "";
        }
        MyProject.Forms.SAPForm.txtSecMainFuel.Enabled = true;
        string fuel = table4aBList[0].Fuel;
        if (Operators.CompareString(fuel, "Gas", false) != 0)
        {
          if (Operators.CompareString(fuel, "Electricity", false) != 0)
          {
            if (Operators.CompareString(fuel, "Oil", false) != 0)
            {
              if (Operators.CompareString(fuel, "Solid", false) != 0)
              {
                if (Operators.CompareString(fuel, "Community", false) == 0)
                {
                  MyProject.Forms.SAPForm.txtSecMainFuel.Items.Add((object) "heat from boilers – mains gas");
                  MyProject.Forms.SAPForm.txtSecMainFuel.Items.Add((object) "heat from boilers – LPG");
                  MyProject.Forms.SAPForm.txtSecMainFuel.Items.Add((object) "heat from boilers – oil");
                  MyProject.Forms.SAPForm.txtSecMainFuel.Items.Add((object) "heat from boilers – B30D");
                  MyProject.Forms.SAPForm.txtSecMainFuel.Items.Add((object) "heat from boilers – coal");
                  MyProject.Forms.SAPForm.txtSecMainFuel.Items.Add((object) "heat from electric heat pump");
                  MyProject.Forms.SAPForm.txtSecMainFuel.Items.Add((object) "heat from boilers - waste combustion");
                  MyProject.Forms.SAPForm.txtSecMainFuel.Items.Add((object) "heat from boilers – biomass");
                  MyProject.Forms.SAPForm.txtSecMainFuel.Items.Add((object) "heat from boilers – biogas");
                  MyProject.Forms.SAPForm.txtSecMainFuel.Items.Add((object) "waste heat from power stations");
                  MyProject.Forms.SAPForm.txtSecMainFuel.Items.Add((object) "geothermal heat source");
                  MyProject.Forms.SAPForm.txtSecMainFuel.Items.Add((object) "heat from CHP");
                }
              }
              else
              {
                MyProject.Forms.SAPForm.txtSecMainFuel.Items.Add((object) "house coal");
                MyProject.Forms.SAPForm.txtSecMainFuel.Items.Add((object) "anthracite");
                MyProject.Forms.SAPForm.txtSecMainFuel.Items.Add((object) "manufactured smokeless fuel");
                MyProject.Forms.SAPForm.txtSecMainFuel.Items.Add((object) "wood logs");
                MyProject.Forms.SAPForm.txtSecMainFuel.Items.Add((object) "wood pellets (in bags, for secondary heating)");
                MyProject.Forms.SAPForm.txtSecMainFuel.Items.Add((object) "wood pellets (bulk supply in bags, for main heating)");
                MyProject.Forms.SAPForm.txtSecMainFuel.Items.Add((object) "wood chips");
                MyProject.Forms.SAPForm.txtSecMainFuel.Items.Add((object) "dual fuel appliance (mineral and wood)");
              }
            }
            else
            {
              MyProject.Forms.SAPForm.txtSecMainFuel.Items.Add((object) "heating oil");
              MyProject.Forms.SAPForm.txtSecMainFuel.Items.Add((object) "biodiesel from any biomass source");
              MyProject.Forms.SAPForm.txtSecMainFuel.Items.Add((object) "biodiesel from used cooking oil only");
              MyProject.Forms.SAPForm.txtSecMainFuel.Items.Add((object) "appliances able to use mineral oil or liquid biofuel");
              MyProject.Forms.SAPForm.txtSecMainFuel.Items.Add((object) "B30K");
              MyProject.Forms.SAPForm.txtSecMainFuel.Items.Add((object) "bioethanol from any biomass source");
            }
          }
          else
          {
            MyProject.Forms.SAPForm.txtSecMainFuel.Items.Add((object) "Electricity");
            MyProject.Forms.SAPForm.txtSecMainFuel.Enabled = false;
            MyProject.Forms.SAPForm.txtSecMainFuel.Text = "Electricity";
          }
        }
        else
        {
          MyProject.Forms.SAPForm.txtSecMainFuel.Items.Add((object) "mains gas");
          MyProject.Forms.SAPForm.txtSecMainFuel.Items.Add((object) "bulk LPG");
          MyProject.Forms.SAPForm.txtSecMainFuel.Items.Add((object) "bottled LPG");
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    public static void GetMainSecEfficiency(
      string FirstGroup,
      string SecondGroup,
      string BoilerGroup,
      string Description)
    {
      MyProject.Forms.SAPForm.pnlMainSecEff1.BringToFront();
      if (Operators.CompareString(MyProject.Forms.SAPForm.txtSecHeatingSource.Text, "SAP Tables", false) != 0)
        return;
      MyProject.Forms.SAPForm.txtSecEfficiency.Enabled = false;
      PCDF.Table4a_B table4aB = Operators.CompareString(BoilerGroup, "", false) != 0 ? SAP_Module.PCDFData.Table4a_bs.Where<PCDF.Table4a_B>((Func<PCDF.Table4a_B, bool>) (b => b.FirstGroup.Equals(FirstGroup) & b.SecondGroup.Equals(BoilerGroup) & b.Description.Equals(Description))).SingleOrDefault<PCDF.Table4a_B>() : SAP_Module.PCDFData.Table4a_bs.Where<PCDF.Table4a_B>((Func<PCDF.Table4a_B, bool>) (b => b.FirstGroup.Equals(FirstGroup) & b.SecondGroup.Equals(SecondGroup) & b.Description.Equals(Description))).SingleOrDefault<PCDF.Table4a_B>();
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SAPTableCode = checked ((int) Math.Round(Conversion.Val(table4aB.Code)));
      MyProject.Forms.SAPForm.txtSecEfficiency.Text = "";
      int sapTableCode = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SAPTableCode;
      if (sapTableCode < 150)
      {
        MyProject.Forms.SAPForm.pnlMainSecEff2.BringToFront();
        MyProject.Forms.SAPForm.txtsecMainEffWinter.Text = table4aB.EffA;
        MyProject.Forms.SAPForm.txtsecMainEffSummer.Text = table4aB.EffB;
      }
      else
        MyProject.Forms.SAPForm.txtSecEfficiency.Text = sapTableCode < 601 || sapTableCode > 613 ? ((sapTableCode < 151 || sapTableCode > 161) && (sapTableCode < 631 || sapTableCode > 636) ? table4aB.EffB : (Operators.CompareString(MyProject.Forms.SAPForm.txtSecHETASMain.Text, "Yes", false) == 0 ? table4aB.EffA : table4aB.EffB)) : (Operators.CompareString(MyProject.Forms.SAPForm.txtSecMainFuel.Text, "mains gas", false) == 0 ? table4aB.EffA : table4aB.EffB);
    }
  }
}
