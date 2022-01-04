
// Type: SAP2012.Heating




using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using SAP2012.My;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SAP2012
{
  [StandardModule]
  internal sealed class Heating
  {
    public static void PrimaryHeatingSubGroupCheck()
    {
      MyProject.Forms.SAPForm.pnlMainEff1.BringToFront();
      MyProject.Forms.SAPForm.txtMainFuel.Enabled = false;
      MyProject.Forms.SAPForm.txtMainFuel.Text = "";
      MyProject.Forms.SAPForm.txtHeatingSource.Items.Clear();
      MyProject.Forms.SAPForm.txtHeatingSource.Text = "";
      MyProject.Forms.SAPForm.txtMainHeatingType.Text = "";
      MyProject.Forms.SAPForm.txtMainHeatingType.Enabled = false;
      MyProject.Forms.SAPForm.txtBoilerSub.Text = "";
      MyProject.Forms.SAPForm.txtBoilerSub.Enabled = false;
      MyProject.Forms.SAPForm.grpHETASMain.Enabled = false;
      MyProject.Forms.SAPForm.txtHETASMain.Text = "";
      MyProject.Forms.SAPForm.grpKeepHot.Enabled = false;
      MyProject.Forms.SAPForm.chkKeepHot.Checked = false;
      MyProject.Forms.SAPForm.txtKeepHotFuel.Text = "";
      MyProject.Forms.SAPForm.chkKeepHotTimed.Checked = false;
      MyProject.Forms.SAPForm.grpRange.Visible = false;
      MyProject.Forms.SAPForm.grpBoilerInfo.Visible = false;
      MyProject.Forms.SAPForm.grpCompensator.Visible = false;
      MyProject.Forms.SAPForm.grpCommH.Visible = false;
      MyProject.Forms.SAPForm.grpCompensator.Visible = false;
      string text1 = MyProject.Forms.SAPForm.txtSubGroup.Text;
      // ISSUE: reference to a compiler-generated method
      switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(text1))
      {
        case 466968799:
          if (Operators.CompareString(text1, "Oil-fired warm air", false) == 0)
            break;
          goto default;
        case 517062339:
          if (Operators.CompareString(text1, "Gas boilers and oil boilers", false) == 0)
            break;
          goto default;
        case 593559484:
          if (Operators.CompareString(text1, "Gas-fired heat pumps", false) == 0)
            break;
          goto default;
        case 932397623:
          if (Operators.CompareString(text1, "Electric heat pumps", false) == 0)
            break;
          goto default;
        case 3210050926:
          if (Operators.CompareString(text1, "Solid fuel boilers", false) == 0)
            break;
          goto default;
        case 3406792557:
          if (Operators.CompareString(text1, "Micro-cogeneration (micro-CHP)", false) == 0)
            break;
          goto default;
        case 3711985384:
          if (Operators.CompareString(text1, "Gas fired warm air with balanced or open flue", false) == 0)
            break;
          goto default;
        case 3980656698:
          if (Operators.CompareString(text1, "Gas-fired warm air with fan-assisted flue", false) == 0)
            break;
          goto default;
        default:
label_10:
          if (Operators.CompareString(MyProject.Forms.SAPForm.txtPrimary.Text, "Community heating schemes", false) == 0)
            MyProject.Forms.SAPForm.txtHeatingSource.Items.Add((object) "Boiler Database");
          if (Operators.CompareString(MyProject.Forms.SAPForm.txtSubGroup.Text, "Micro-cogeneration (micro-CHP)", false) != 0)
            MyProject.Forms.SAPForm.txtHeatingSource.Items.Add((object) "SAP Tables");
          string text2 = MyProject.Forms.SAPForm.txtSubGroup.Text;
          if (Operators.CompareString(text2, "Micro-cogeneration (micro-CHP)", false) != 0 && Operators.CompareString(text2, "Heat pumps", false) != 0 && Operators.CompareString(text2, "Electric heat pumps", false) != 0 && Operators.CompareString(text2, "Gas-fired heat pumps", false) != 0)
            MyProject.Forms.SAPForm.txtHeatingSource.Items.Add((object) "Manufacturer Declaration");
          MyProject.Forms.SAPForm.txtHeatingSource.Enabled = true;
          string text3 = MyProject.Forms.SAPForm.txtSubGroup.Text;
          if (Operators.CompareString(text3, "Gas boilers and oil boilers", false) != 0 && Operators.CompareString(text3, "Micro-cogeneration (micro-CHP)", false) != 0 && Operators.CompareString(text3, "Solid fuel boilers", false) != 0 && Operators.CompareString(text3, "Electric boilers", false) != 0)
          {
            if (Operators.CompareString(text3, "Electric heat pumps", false) != 0 && Operators.CompareString(text3, "Gas-fired heat pumps", false) != 0)
              return;
            string text4 = MyProject.Forms.SAPForm.txtPrimary.Text;
            MyProject.Forms.SAPForm.txtHeatingSource.Items.Add((object) "Boiler Database");
            SAP_Module.TableGroup = Operators.CompareString(MyProject.Forms.SAPForm.txtPrimary.Text, "Heat pumps with warm air distribution", false) != 0 ? 2 : 5;
            MyProject.Forms.SAPForm.txtHeatingControls.Text = "";
            Heating.PopControls();
            return;
          }
          SAP_Module.TableGroup = 1;
          MyProject.Forms.SAPForm.txtHeatingControls.Text = "";
          Heating.PopControls();
          return;
      }
      MyProject.Forms.SAPForm.txtHeatingSource.Items.Add((object) "Boiler Database");
      goto label_10;
    }

    public static void PrimaryHeatingGroupCheck()
    {
      MyProject.Forms.SAPForm.pnlMainEff1.BringToFront();
      MyProject.Forms.SAPForm.txtMainFuel.Enabled = false;
      MyProject.Forms.SAPForm.txtMainFuel.Text = "";
      MyProject.Forms.SAPForm.txtSubGroup.Items.Clear();
      MyProject.Forms.SAPForm.txtSubGroup.Text = "";
      MyProject.Forms.SAPForm.txtSubGroup.Enabled = false;
      MyProject.Forms.SAPForm.txtHeatingEmitter.Enabled = false;
      MyProject.Forms.SAPForm.txtHeatingEmitter.Text = "";
      MyProject.Forms.SAPForm.txtHeatingControls.Enabled = false;
      MyProject.Forms.SAPForm.txtHeatingControls.Text = "";
      MyProject.Forms.SAPForm.txtHeatingSource.Text = "";
      MyProject.Forms.SAPForm.txtHeatingSource.Enabled = false;
      MyProject.Forms.SAPForm.txtHeatingSource.Items.Clear();
      MyProject.Forms.SAPForm.txtBoilerSub.Text = "";
      MyProject.Forms.SAPForm.txtBoilerSub.Enabled = false;
      MyProject.Forms.SAPForm.txtMainHeatingType.Text = "";
      MyProject.Forms.SAPForm.txtMainHeatingType.Enabled = false;
      MyProject.Forms.SAPForm.txtMainHeatingType.Items.Clear();
      MyProject.Forms.SAPForm.grpHETASMain.Enabled = false;
      MyProject.Forms.SAPForm.txtHETASMain.Text = "";
      MyProject.Forms.SAPForm.grpRange.Visible = false;
      MyProject.Forms.SAPForm.grpCompensator.Visible = false;
      MyProject.Forms.SAPForm.grpKeepHot.Enabled = false;
      MyProject.Forms.SAPForm.chkKeepHot.Checked = false;
      MyProject.Forms.SAPForm.txtKeepHotFuel.Text = "";
      MyProject.Forms.SAPForm.chkKeepHotTimed.Checked = false;
      MyProject.Forms.SAPForm.grpCommH.Visible = false;
      MyProject.Forms.SAPForm.grpEfficiency.Visible = true;
      MyProject.Forms.SAPForm.grpBoilerInfo.Visible = false;
      MyProject.Forms.SAPForm.chkMCS.Enabled = false;
      MyProject.Forms.SAPForm.txtLoadWeather.Text = "";
      MyProject.Forms.SAPForm.txtCompensator.Text = "";
      MyProject.Forms.SAPForm.lblControlWeather.Text = "";
      string text = MyProject.Forms.SAPForm.txtPrimary.Text;
      // ISSUE: reference to a compiler-generated method
      switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(text))
      {
        case 468594210:
          if (Operators.CompareString(text, "No heating system present", false) != 0)
            break;
          MyProject.Forms.SAPForm.txtMainFuel.Text = "Electricity";
          MyProject.Forms.SAPForm.txtHeatingSource.Text = "SAP Tables";
          MyProject.Forms.SAPForm.txtEfficiency.Text = Conversions.ToString(100);
          Heating.GetMainEfficiency(MyProject.Forms.SAPForm.txtPrimary.Text, "", "", "Electric heater (assumed)");
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.ControlCode = 2699;
          MyProject.Forms.SAPForm.txtHeatingControls.Text = "None";
          break;
        case 743056865:
          if (Operators.CompareString(text, "Heat pumps with warm air distribution", false) != 0)
            break;
          MyProject.Forms.SAPForm.txtSubGroup.Enabled = true;
          MyProject.Forms.SAPForm.txtSubGroup.Items.Add((object) "Electric heat pumps");
          MyProject.Forms.SAPForm.txtSubGroup.Items.Add((object) "Gas-fired heat pumps");
          MyProject.Forms.SAPForm.txtHeatingEmitter.Enabled = true;
          break;
        case 1278633908:
          if (Operators.CompareString(text, "Room heaters", false) != 0)
            break;
          MyProject.Forms.SAPForm.txtSubGroup.Enabled = true;
          MyProject.Forms.SAPForm.txtSubGroup.Items.Add((object) "Gas (including LPG) room heaters");
          MyProject.Forms.SAPForm.txtSubGroup.Items.Add((object) "Oil room heaters");
          MyProject.Forms.SAPForm.txtSubGroup.Items.Add((object) "Solid fuel room heaters");
          MyProject.Forms.SAPForm.txtSubGroup.Items.Add((object) "Electric (direct acting) room heaters");
          SAP_Module.TableGroup = 6;
          Heating.PopControls();
          break;
        case 1356142837:
          if (Operators.CompareString(text, "Electric storage systems", false) != 0)
            break;
          MyProject.Forms.SAPForm.txtSubGroup.Enabled = true;
          MyProject.Forms.SAPForm.txtSubGroup.Items.Add((object) "Off-peak tariffs");
          MyProject.Forms.SAPForm.txtSubGroup.Items.Add((object) "24-hour heating tariff");
          SAP_Module.TableGroup = 4;
          Heating.PopControls();
          break;
        case 1403793243:
          if (Operators.CompareString(text, "Micro-Congeneration (Micro-CHP)", false) != 0)
            break;
          MyProject.Forms.SAPForm.txtSubGroup.Enabled = false;
          MyProject.Forms.SAPForm.txtSubGroup.Items.Add((object) "Micro-cogeneration (micro-CHP)");
          MyProject.Forms.SAPForm.txtSubGroup.SelectedIndex = 0;
          MyProject.Forms.SAPForm.txtHeatingEmitter.Enabled = true;
          break;
        case 1754365722:
          if (Operators.CompareString(text, "Warm air systems (Not heat pump)", false) != 0)
            break;
          MyProject.Forms.SAPForm.txtSubGroup.Enabled = true;
          MyProject.Forms.SAPForm.txtSubGroup.Items.Add((object) "Gas-fired warm air with fan-assisted flue");
          MyProject.Forms.SAPForm.txtSubGroup.Items.Add((object) "Gas fired warm air with balanced or open flue");
          MyProject.Forms.SAPForm.txtSubGroup.Items.Add((object) "Oil-fired warm air");
          MyProject.Forms.SAPForm.txtSubGroup.Items.Add((object) "Electric warm air");
          SAP_Module.TableGroup = 5;
          Heating.PopControls();
          break;
        case 2058786912:
          if (Operators.CompareString(text, "Electric underfloor heating", false) != 0)
            break;
          MyProject.Forms.SAPForm.txtSubGroup.Enabled = true;
          MyProject.Forms.SAPForm.txtSubGroup.Items.Add((object) "Off-peak tariffs");
          MyProject.Forms.SAPForm.txtSubGroup.Items.Add((object) "Standard tariff");
          SAP_Module.TableGroup = 7;
          Heating.PopControls();
          break;
        case 2185270936:
          if (Operators.CompareString(text, "Community heating schemes", false) != 0)
            break;
          MyProject.Forms.SAPForm.txtSubGroup.Enabled = false;
          MyProject.Forms.SAPForm.txtHeatingSource.Items.Add((object) "SAP Tables");
          MyProject.Forms.SAPForm.txtHeatingSource.Items.Add((object) "Manufacturer Declaration");
          MyProject.Forms.SAPForm.txtHeatingSource.Items.Add((object) "Boiler Database");
          MyProject.Forms.SAPForm.txtHeatingSource.Enabled = true;
          MyProject.Forms.SAPForm.grpEfficiency.Visible = false;
          SAP_Module.TableGroup = 3;
          Heating.PopControls();
          break;
        case 2419931075:
          if (Operators.CompareString(text, "Other space heating systems", false) != 0)
            break;
          MyProject.Forms.SAPForm.txtSubGroup.Enabled = false;
          MyProject.Forms.SAPForm.txtHeatingEmitter.Enabled = true;
          MyProject.Forms.SAPForm.txtHeatingSource.Items.Add((object) "SAP Tables");
          MyProject.Forms.SAPForm.txtHeatingSource.Items.Add((object) "Manufacturer Declaration");
          MyProject.Forms.SAPForm.txtHeatingSource.Enabled = true;
          SAP_Module.TableGroup = 7;
          Heating.PopControls();
          break;
        case 2707799250:
          if (Operators.CompareString(text, "Heat pumps with radiators or underfloor heating", false) != 0)
            break;
          MyProject.Forms.SAPForm.txtSubGroup.Enabled = true;
          MyProject.Forms.SAPForm.txtSubGroup.Items.Add((object) "Electric heat pumps");
          MyProject.Forms.SAPForm.txtSubGroup.Items.Add((object) "Gas-fired heat pumps");
          MyProject.Forms.SAPForm.txtHeatingEmitter.Enabled = true;
          MyProject.Forms.SAPForm.chkMCS.Enabled = true;
          break;
        case 4284389836:
          if (Operators.CompareString(text, "Boiler systems with radiators or underfloor heating", false) != 0)
            break;
          MyProject.Forms.SAPForm.txtSubGroup.Enabled = true;
          MyProject.Forms.SAPForm.txtSubGroup.Items.Add((object) "Gas boilers and oil boilers");
          MyProject.Forms.SAPForm.txtSubGroup.Items.Add((object) "Solid fuel boilers");
          MyProject.Forms.SAPForm.txtSubGroup.Items.Add((object) "Electric boilers");
          MyProject.Forms.SAPForm.txtHeatingEmitter.Enabled = true;
          break;
      }
    }

    public static void CheckSource()
    {
      MyProject.Forms.SAPForm.pnlMainEff1.BringToFront();
      MyProject.Forms.SAPForm.grpCommH.Visible = false;
      MyProject.Forms.SAPForm.grpCompensator.Visible = false;
      MyProject.Forms.SAPForm.txtMainFuel.Enabled = false;
      MyProject.Forms.SAPForm.txtMainFuel.Text = "";
      MyProject.Forms.SAPForm.txtMainHeatingType.Enabled = false;
      MyProject.Forms.SAPForm.txtMainHeatingType.Text = "";
      MyProject.Forms.SAPForm.txtMainHeatingType.Items.Clear();
      MyProject.Forms.SAPForm.chkSEDBUK2005.Visible = false;
      MyProject.Forms.SAPForm.chkSEDBUK2005.Checked = false;
      MyProject.Forms.SAPForm.txtBoilerSub.Text = "";
      MyProject.Forms.SAPForm.txtBoilerSub.Enabled = false;
      MyProject.Forms.SAPForm.grpRange.Visible = false;
      MyProject.Forms.SAPForm.grpHETASMain.Enabled = false;
      MyProject.Forms.SAPForm.txtHETASMain.Text = "";
      MyProject.Forms.SAPForm.chkMainHLoadWeather.Checked = false;
      MyProject.Forms.SAPForm.txtLoadWeather.Text = "";
      if (Operators.CompareString(MyProject.Forms.SAPForm.txtHeatingSource.Text, "Boiler Database", false) == 0)
      {
        MyProject.Forms.SAPForm.cmdBiolerData.Enabled = true;
      }
      else
      {
        MyProject.Forms.SAPForm.cmdBiolerData.Enabled = false;
        MyProject.Forms.SAPForm.grpBoilerInfo.Visible = false;
      }
      MyProject.Forms.SAPForm.grpKeepHot.Enabled = false;
      MyProject.Forms.SAPForm.chkKeepHot.Checked = false;
      MyProject.Forms.SAPForm.txtKeepHotFuel.Text = "";
      MyProject.Forms.SAPForm.chkKeepHotTimed.Checked = false;
      if (Operators.CompareString(MyProject.Forms.SAPForm.txtHeatingSource.Text, "SAP Tables", false) == 0 | Operators.CompareString(MyProject.Forms.SAPForm.txtHeatingSource.Text, "Manufacturer Declaration", false) == 0)
      {
        string text = MyProject.Forms.SAPForm.txtSubGroup.Text;
        if (Operators.CompareString(text, "Gas boilers and oil boilers", false) != 0)
        {
          if (Operators.CompareString(text, "Micro-cogeneration (micro-CHP)", false) != 0)
          {
            List<PCDF.Table4a_B> table4aBs1 = SAP_Module.PCDFData.Table4a_bs;
            Func<PCDF.Table4a_B, bool> predicate1;
            // ISSUE: reference to a compiler-generated field
            if (Heating._Closure\u0024__.\u0024I2\u002D0 != null)
            {
              // ISSUE: reference to a compiler-generated field
              predicate1 = Heating._Closure\u0024__.\u0024I2\u002D0;
            }
            else
            {
              // ISSUE: reference to a compiler-generated field
              Heating._Closure\u0024__.\u0024I2\u002D0 = predicate1 = (Func<PCDF.Table4a_B, bool>) (b => b.FirstGroup.ToUpper().Equals(MyProject.Forms.SAPForm.txtPrimary.Text.ToUpper()) & b.SecondGroup.ToUpper().Equals(MyProject.Forms.SAPForm.txtSubGroup.Text.ToUpper()));
            }
            List<PCDF.Table4a_B> list1 = table4aBs1.Where<PCDF.Table4a_B>(predicate1).ToList<PCDF.Table4a_B>();
            try
            {
              foreach (PCDF.Table4a_B table4aB in list1)
                MyProject.Forms.SAPForm.txtMainHeatingType.Items.Add((object) table4aB.Description);
            }
            finally
            {
              List<PCDF.Table4a_B>.Enumerator enumerator;
              enumerator.Dispose();
            }
            if (MyProject.Forms.SAPForm.txtPrimary.Text.Equals("Electric underfloor heating") & MyProject.Forms.SAPForm.txtSubGroup.Text.Equals("Off-peak tariffs"))
            {
              List<PCDF.Table4a_B> table4aBs2 = SAP_Module.PCDFData.Table4a_bs;
              Func<PCDF.Table4a_B, bool> predicate2;
              // ISSUE: reference to a compiler-generated field
              if (Heating._Closure\u0024__.\u0024I2\u002D1 != null)
              {
                // ISSUE: reference to a compiler-generated field
                predicate2 = Heating._Closure\u0024__.\u0024I2\u002D1;
              }
              else
              {
                // ISSUE: reference to a compiler-generated field
                Heating._Closure\u0024__.\u0024I2\u002D1 = predicate2 = (Func<PCDF.Table4a_B, bool>) (b => b.FirstGroup.ToUpper().Equals(MyProject.Forms.SAPForm.txtPrimary.Text.ToUpper()) & b.SecondGroup.Equals("Standard tariff"));
              }
              List<PCDF.Table4a_B> list2 = table4aBs2.Where<PCDF.Table4a_B>(predicate2).ToList<PCDF.Table4a_B>();
              try
              {
                foreach (PCDF.Table4a_B table4aB in list2)
                  MyProject.Forms.SAPForm.txtMainHeatingType.Items.Add((object) table4aB.Description);
              }
              finally
              {
                List<PCDF.Table4a_B>.Enumerator enumerator;
                enumerator.Dispose();
              }
            }
            MyProject.Forms.SAPForm.txtMainHeatingType.Enabled = true;
          }
        }
        else
          MyProject.Forms.SAPForm.txtBoilerSub.Enabled = true;
      }
      else
        MyProject.Forms.SAPForm.txtMainHeatingType.Enabled = false;
      if (Operators.CompareString(MyProject.Forms.SAPForm.txtPrimary.Text, "No heating system present", false) == 0)
      {
        MyProject.Forms.SAPForm.txtMainFuel.Text = "Electricity";
        MyProject.Forms.SAPForm.txtHeatingSource.Text = "SAP Tables";
        MyProject.Forms.SAPForm.txtEfficiency.Text = Conversions.ToString(100);
      }
      if (Operators.CompareString(MyProject.Forms.SAPForm.txtHeatingSource.Text, "Manufacturer Declaration", false) == 0)
      {
        MyProject.Forms.SAPForm.txtEfficiency.Enabled = true;
        MyProject.Forms.SAPForm.txtDescription.Enabled = true;
      }
      else
      {
        MyProject.Forms.SAPForm.txtEfficiency.Enabled = false;
        MyProject.Forms.SAPForm.txtDescription.Enabled = false;
        MyProject.Forms.SAPForm.txtDescription.Text = "";
      }
      if (Operators.CompareString(MyProject.Forms.SAPForm.txtHeatingSource.Text, "Manufacturer Declaration", false) == 0 & Operators.CompareString(MyProject.Forms.SAPForm.txtSubGroup.Text, "Gas boilers and oil boilers", false) == 0)
        MyProject.Forms.SAPForm.chkSEDBUK2005.Visible = true;
      else
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SEDBUK2005 = false;
    }

    public static void PopControls()
    {
      MyProject.Forms.SAPForm.txtHeatingControls.Items.Clear();
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.TableGroup = SAP_Module.TableGroup;
      List<PCDF.Table4e> table4es = SAP_Module.PCDFData.Table4es;
      Func<PCDF.Table4e, bool> predicate;
      // ISSUE: reference to a compiler-generated field
      if (Heating._Closure\u0024__.\u0024I3\u002D0 != null)
      {
        // ISSUE: reference to a compiler-generated field
        predicate = Heating._Closure\u0024__.\u0024I3\u002D0;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        Heating._Closure\u0024__.\u0024I3\u002D0 = predicate = (Func<PCDF.Table4e, bool>) (b => b.Group.ToUpper().Equals(SAP_Module.TableGroup.ToString().ToUpper()));
      }
      List<PCDF.Table4e> list = table4es.Where<PCDF.Table4e>(predicate).ToList<PCDF.Table4e>();
      int num = checked (list.Count - 1);
      int index = 0;
      while (index <= num)
      {
        MyProject.Forms.SAPForm.txtHeatingControls.Items.Add((object) list[index].Description);
        checked { ++index; }
      }
      MyProject.Forms.SAPForm.txtHeatingControls.Enabled = true;
    }

    public static void CheckBoilerSub()
    {
      if (Operators.CompareString(MyProject.Forms.SAPForm.txtBoilerSub.Text, "", false) == 0)
        return;
      MyProject.Forms.SAPForm.grpCommH.Visible = false;
      if ((uint) Operators.CompareString(MyProject.Forms.SAPForm.txtSubGroup.Text, "Electric boilers", false) > 0U)
      {
        MyProject.Forms.SAPForm.txtMainFuel.Enabled = false;
        MyProject.Forms.SAPForm.txtMainFuel.Text = "";
        MyProject.Forms.SAPForm.txtMainHeatingType.Text = "";
        MyProject.Forms.SAPForm.txtMainHeatingType.Items.Clear();
        MyProject.Forms.SAPForm.txtMainHeatingType.Enabled = true;
        MyProject.Forms.SAPForm.grpKeepHot.Enabled = false;
        MyProject.Forms.SAPForm.chkKeepHot.Checked = false;
        MyProject.Forms.SAPForm.txtKeepHotFuel.Text = "";
        MyProject.Forms.SAPForm.chkKeepHotTimed.Checked = false;
        string text = MyProject.Forms.SAPForm.txtBoilerSub.Text;
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
            MyProject.Forms.SAPForm.txtMainHeatingType.Enabled = false;
            goto label_21;
        }
        List<PCDF.Table4a_B> table4aBs = SAP_Module.PCDFData.Table4a_bs;
        Func<PCDF.Table4a_B, bool> predicate;
        // ISSUE: reference to a compiler-generated field
        if (Heating._Closure\u0024__.\u0024I4\u002D0 != null)
        {
          // ISSUE: reference to a compiler-generated field
          predicate = Heating._Closure\u0024__.\u0024I4\u002D0;
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          Heating._Closure\u0024__.\u0024I4\u002D0 = predicate = (Func<PCDF.Table4a_B, bool>) (b => b.FirstGroup.ToUpper().Equals(MyProject.Forms.SAPForm.txtPrimary.Text.ToUpper()) & b.SecondGroup.ToUpper().Equals(MyProject.Forms.SAPForm.txtBoilerSub.Text.ToUpper()));
        }
        List<PCDF.Table4a_B> list = table4aBs.Where<PCDF.Table4a_B>(predicate).ToList<PCDF.Table4a_B>();
        try
        {
          foreach (PCDF.Table4a_B table4aB in list)
            MyProject.Forms.SAPForm.txtMainHeatingType.Items.Add((object) table4aB.Description);
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

    public static void CheckFuelTypeForSAPTable(
      string Description,
      string SubGroup,
      string BoilerSubGroup)
    {
      MyProject.Forms.SAPForm.pnlMainEff1.BringToFront();
      if (Operators.CompareString(Description, "", false) == 0)
        return;
      try
      {
        MyProject.Forms.SAPForm.chkMCS.Enabled = false;
        List<PCDF.Table4a_B> table4aBList = Operators.CompareString(MyProject.Forms.SAPForm.txtPrimary.Text, "Electric storage systems", false) != 0 ? ((uint) Operators.CompareString(BoilerSubGroup, "", false) <= 0U ? SAP_Module.PCDFData.Table4a_bs.Where<PCDF.Table4a_B>((Func<PCDF.Table4a_B, bool>) (b => b.Description.Equals(Description) & b.FirstGroup.ToUpper().Equals(MyProject.Forms.SAPForm.txtPrimary.Text.ToUpper()) & b.SecondGroup.ToUpper().Equals(MyProject.Forms.SAPForm.txtSubGroup.Text.ToUpper()))).ToList<PCDF.Table4a_B>() : SAP_Module.PCDFData.Table4a_bs.Where<PCDF.Table4a_B>((Func<PCDF.Table4a_B, bool>) (b => b.Description.ToUpper().Equals(Description.ToUpper()) & b.SecondGroup.ToUpper().Equals(BoilerSubGroup.ToUpper()))).ToList<PCDF.Table4a_B>()) : SAP_Module.PCDFData.Table4a_bs.Where<PCDF.Table4a_B>((Func<PCDF.Table4a_B, bool>) (b => b.Description.ToUpper().Equals(Description.ToUpper()) & b.SecondGroup.ToUpper().Equals(SubGroup.ToUpper()))).ToList<PCDF.Table4a_B>();
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SAPTableCode = Conversions.ToInteger(table4aBList[0].Code);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SEDBUK = "";
        MyProject.Forms.SAPForm.txtMainFuel.Text = "";
        MyProject.Forms.SAPForm.txtMainFuel.Items.Clear();
        MyProject.Forms.SAPForm.txtMainFuel.Enabled = true;
        MyProject.Forms.SAPForm.chkMainHLoadWeather.Enabled = false;
        MyProject.Forms.SAPForm.grpHETASMain.Enabled = false;
        int sapTableCode1 = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SAPTableCode;
        if (sapTableCode1 >= 151 && sapTableCode1 <= 161 || sapTableCode1 >= 631 && sapTableCode1 <= 636)
          MyProject.Forms.SAPForm.grpHETASMain.Enabled = true;
        else
          MyProject.Forms.SAPForm.txtHETASMain.Text = "";
        MyProject.Forms.SAPForm.grpBoilerInfo.Visible = false;
        int sapTableCode2 = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SAPTableCode;
        if (sapTableCode2 < 300)
        {
          MyProject.Forms.SAPForm.grpBoilerInfo.Visible = true;
          MyProject.Forms.SAPForm.txtPumpHP.Enabled = true;
          MyProject.Forms.SAPForm.txtBILock.Enabled = true;
          int sapTableCode3 = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SAPTableCode;
          if (sapTableCode3 >= 191 && sapTableCode3 <= 196)
          {
            MyProject.Forms.SAPForm.txtBFlueType.Enabled = false;
            MyProject.Forms.SAPForm.txtBFlueType.Text = "";
            MyProject.Forms.SAPForm.txtFanFlued.Enabled = false;
            MyProject.Forms.SAPForm.txtFanFlued.Text = "";
          }
          else
          {
            MyProject.Forms.SAPForm.txtBFlueType.Enabled = true;
            MyProject.Forms.SAPForm.txtFanFlued.Enabled = true;
          }
          switch (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SAPTableCode)
          {
            case 211:
            case 213:
            case 214:
            case 221:
            case 223:
            case 224:
              MyProject.Forms.SAPForm.chkMCS.Enabled = true;
              break;
          }
          if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SAPTableCode == 192)
          {
            MyProject.Forms.SAPForm.txtPumpHP.Text = "Yes";
            MyProject.Forms.SAPForm.txtBILock.Text = "Yes";
          }
          MyProject.Forms.SAPForm.grpKeepHot.Enabled = false;
          MyProject.Forms.SAPForm.chkKeepHot.Checked = false;
          MyProject.Forms.SAPForm.txtKeepHotFuel.Text = "";
          MyProject.Forms.SAPForm.chkKeepHotTimed.Checked = false;
          if (Operators.CompareString(MyProject.Forms.SAPForm.txtHeatingSource.Text, "Manufacturer Declaration", false) == 0)
          {
            switch (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SAPTableCode)
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
                MyProject.Forms.SAPForm.grpKeepHot.Enabled = true;
                break;
            }
          }
          MyProject.Forms.SAPForm.grpRange.Visible = false;
          if (Operators.CompareString(MyProject.Forms.SAPForm.txtHeatingSource.Text, "Manufacturer Declaration", false) == 0)
          {
            int sapTableCode4 = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SAPTableCode;
            if (sapTableCode4 >= 133 && sapTableCode4 <= 141)
              MyProject.Forms.SAPForm.grpRange.Visible = true;
          }
          int sapTableCode5 = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SAPTableCode;
          if (sapTableCode5 >= 201 && sapTableCode5 <= 207)
            MyProject.Forms.SAPForm.grpCompensator.Visible = true;
          else
            MyProject.Forms.SAPForm.txtCompensator.Text = "";
          MyProject.Forms.SAPForm.chkMainHLoadWeather.Enabled = false;
          switch (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SAPTableCode)
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
              MyProject.Forms.SAPForm.chkMainHLoadWeather.Enabled = true;
              break;
            default:
              MyProject.Forms.SAPForm.chkMainHLoadWeather.Checked = false;
              break;
          }
        }
        else if (sapTableCode2 >= 306 && sapTableCode2 <= 310)
        {
          MyProject.Forms.SAPForm.grpCommH.Visible = true;
          MyProject.Forms.SAPForm.txtCommHB1HeatToPower.Enabled = false;
          switch (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SAPTableCode)
          {
            case 307:
              MyProject.Forms.SAPForm.txtCommHB1HeatToPower.Enabled = true;
              break;
          }
        }
        else if (sapTableCode2 >= 501 && sapTableCode2 <= 505)
        {
          MyProject.Forms.SAPForm.grpBoilerInfo.Visible = true;
          MyProject.Forms.SAPForm.txtPumpHP.Enabled = false;
          MyProject.Forms.SAPForm.txtBILock.Enabled = false;
          MyProject.Forms.SAPForm.txtBFlueType.Enabled = true;
          MyProject.Forms.SAPForm.txtFanFlued.Enabled = true;
        }
        else if (sapTableCode2 >= 506 && sapTableCode2 <= 514)
        {
          MyProject.Forms.SAPForm.grpBoilerInfo.Visible = true;
          MyProject.Forms.SAPForm.txtPumpHP.Enabled = false;
          MyProject.Forms.SAPForm.txtBILock.Enabled = false;
          MyProject.Forms.SAPForm.txtBFlueType.Enabled = true;
          MyProject.Forms.SAPForm.txtFanFlued.Enabled = false;
        }
        else if (sapTableCode2 >= 521 && sapTableCode2 <= 527)
        {
          MyProject.Forms.SAPForm.grpBoilerInfo.Visible = true;
          MyProject.Forms.SAPForm.txtPumpHP.Enabled = false;
          MyProject.Forms.SAPForm.txtBILock.Enabled = false;
          MyProject.Forms.SAPForm.txtBFlueType.Enabled = true;
          MyProject.Forms.SAPForm.txtFanFlued.Enabled = true;
        }
        else if (sapTableCode2 == 701)
          MyProject.Forms.SAPForm.txtHeatingEmitter.Enabled = true;
        MyProject.Forms.SAPForm.txtMainFuel.Enabled = true;
        MyProject.Forms.SAPForm.chkOilPump.Visible = false;
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
                  MyProject.Forms.SAPForm.txtMainFuel.Items.Add((object) "heat from boilers – mains gas");
                  MyProject.Forms.SAPForm.txtMainFuel.Items.Add((object) "heat from boilers – LPG");
                  MyProject.Forms.SAPForm.txtMainFuel.Items.Add((object) "heat from boilers – oil");
                  MyProject.Forms.SAPForm.txtMainFuel.Items.Add((object) "heat from boilers – B30D");
                  MyProject.Forms.SAPForm.txtMainFuel.Items.Add((object) "heat from boilers – coal");
                  MyProject.Forms.SAPForm.txtMainFuel.Items.Add((object) "heat from electric heat pump");
                  MyProject.Forms.SAPForm.txtMainFuel.Items.Add((object) "heat from boilers - waste combustion");
                  MyProject.Forms.SAPForm.txtMainFuel.Items.Add((object) "heat from boilers – biomass");
                  MyProject.Forms.SAPForm.txtMainFuel.Items.Add((object) "heat from boilers – biogas");
                  MyProject.Forms.SAPForm.txtMainFuel.Items.Add((object) "waste heat from power stations");
                  MyProject.Forms.SAPForm.txtMainFuel.Items.Add((object) "geothermal heat source");
                  MyProject.Forms.SAPForm.txtMainFuel.Items.Add((object) "heat from CHP");
                }
              }
              else
              {
                MyProject.Forms.SAPForm.txtMainFuel.Items.Add((object) "house coal");
                MyProject.Forms.SAPForm.txtMainFuel.Items.Add((object) "anthracite");
                MyProject.Forms.SAPForm.txtMainFuel.Items.Add((object) "manufactured smokeless fuel");
                MyProject.Forms.SAPForm.txtMainFuel.Items.Add((object) "wood logs");
                MyProject.Forms.SAPForm.txtMainFuel.Items.Add((object) "wood pellets (in bags, for secondary heating)");
                MyProject.Forms.SAPForm.txtMainFuel.Items.Add((object) "wood pellets (bulk supply in bags, for main heating)");
                MyProject.Forms.SAPForm.txtMainFuel.Items.Add((object) "wood chips");
                MyProject.Forms.SAPForm.txtMainFuel.Items.Add((object) "dual fuel appliance (mineral and wood)");
              }
            }
            else
            {
              MyProject.Forms.SAPForm.txtMainFuel.Items.Add((object) "heating oil");
              MyProject.Forms.SAPForm.txtMainFuel.Items.Add((object) "biodiesel from any biomass source");
              MyProject.Forms.SAPForm.txtMainFuel.Items.Add((object) "biodiesel from used cooking oil only");
              MyProject.Forms.SAPForm.txtMainFuel.Items.Add((object) "appliances able to use mineral oil or liquid biofuel");
              MyProject.Forms.SAPForm.txtMainFuel.Items.Add((object) "B30K");
              MyProject.Forms.SAPForm.txtMainFuel.Items.Add((object) "bioethanol from any biomass source");
            }
          }
          else
          {
            MyProject.Forms.SAPForm.txtMainFuel.Items.Add((object) "Electricity");
            MyProject.Forms.SAPForm.txtMainFuel.Enabled = false;
            MyProject.Forms.SAPForm.txtMainFuel.Text = "Electricity";
          }
        }
        else
        {
          MyProject.Forms.SAPForm.txtMainFuel.Items.Add((object) "mains gas");
          MyProject.Forms.SAPForm.txtMainFuel.Items.Add((object) "bulk LPG");
          MyProject.Forms.SAPForm.txtMainFuel.Items.Add((object) "bottled LPG");
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    public static void GetMainEfficiency(
      string FirstGroup,
      string SecondGroup,
      string BoilerGroup,
      string Description)
    {
      MyProject.Forms.SAPForm.pnlMainEff1.BringToFront();
      if (Operators.CompareString(MyProject.Forms.SAPForm.txtHeatingSource.Text, "SAP Tables", false) != 0)
        return;
      MyProject.Forms.SAPForm.txtSEfficiency.Enabled = false;
      PCDF.Table4a_B table4aB = Operators.CompareString(BoilerGroup, "", false) != 0 ? SAP_Module.PCDFData.Table4a_bs.Where<PCDF.Table4a_B>((Func<PCDF.Table4a_B, bool>) (b => b.FirstGroup.Equals(FirstGroup) & b.SecondGroup.Equals(BoilerGroup) & b.Description.Equals(Description))).SingleOrDefault<PCDF.Table4a_B>() : SAP_Module.PCDFData.Table4a_bs.Where<PCDF.Table4a_B>((Func<PCDF.Table4a_B, bool>) (b => b.FirstGroup.Equals(FirstGroup) & b.SecondGroup.Equals(SecondGroup) & b.Description.Equals(Description))).SingleOrDefault<PCDF.Table4a_B>();
      if (MyProject.Forms.SAPForm.txtPrimary.Text.Equals("Electric underfloor heating") & MyProject.Forms.SAPForm.txtSubGroup.Text.Equals("Off-peak tariffs") & table4aB == null)
        table4aB = SAP_Module.PCDFData.Table4a_bs.Where<PCDF.Table4a_B>((Func<PCDF.Table4a_B, bool>) (b => b.FirstGroup.Equals(FirstGroup) & b.SecondGroup.Equals("Standard tariff") & b.Description.Equals(Description))).SingleOrDefault<PCDF.Table4a_B>();
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SAPTableCode = checked ((int) Math.Round(Conversion.Val(table4aB.Code)));
      MyProject.Forms.SAPForm.txtEfficiency.Text = "";
      int sapTableCode = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SAPTableCode;
      if (sapTableCode < 150)
      {
        MyProject.Forms.SAPForm.pnlMainEff2.BringToFront();
        MyProject.Forms.SAPForm.txtMainEffWinter.Text = table4aB.EffA;
        MyProject.Forms.SAPForm.txtMainEffSummer.Text = table4aB.EffB;
      }
      else
        MyProject.Forms.SAPForm.txtEfficiency.Text = sapTableCode < 601 || sapTableCode > 613 ? ((sapTableCode < 151 || sapTableCode > 161) && (sapTableCode < 631 || sapTableCode > 636) ? table4aB.EffB : (Operators.CompareString(MyProject.Forms.SAPForm.txtHETASMain.Text, "Yes", false) == 0 ? table4aB.EffA : table4aB.EffB)) : (Operators.CompareString(MyProject.Forms.SAPForm.txtMainFuel.Text, "mains gas", false) == 0 ? table4aB.EffA : table4aB.EffB);
    }
  }
}
