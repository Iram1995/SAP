
// Type: SAP2012.SecHeating




using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using SAP2012.My;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SAP2012
{
  [StandardModule]
  internal sealed class SecHeating
  {
    public static void SPrimaryHeatingSubGroupCheck()
    {
      MyProject.Forms.SAPForm.txtSMainFuel.Enabled = false;
      MyProject.Forms.SAPForm.txtSMainFuel.Text = "";
      MyProject.Forms.SAPForm.txtSHeatingSource.Items.Clear();
      MyProject.Forms.SAPForm.txtSHeatingSource.Text = "";
      MyProject.Forms.SAPForm.txtSMainHeatingType.Text = "";
      MyProject.Forms.SAPForm.txtSMainHeatingType.Enabled = false;
      MyProject.Forms.SAPForm.txtSHeatingSource.Items.Add((object) "SAP Tables");
      MyProject.Forms.SAPForm.txtSHeatingSource.Items.Add((object) "Manufacturer Declaration");
      MyProject.Forms.SAPForm.txtSHeatingSource.Enabled = true;
      MyProject.Forms.SAPForm.txtHETAS.Text = "";
      MyProject.Forms.SAPForm.txtSEfficiency.Text = "";
      MyProject.Forms.SAPForm.GroupBox34.Enabled = false;
    }

    public static void SPrimaryHeatingGroupCheck()
    {
      MyProject.Forms.SAPForm.txtSMainFuel.Enabled = false;
      MyProject.Forms.SAPForm.txtSMainFuel.Text = "";
      MyProject.Forms.SAPForm.txtSSubGroup.Items.Clear();
      MyProject.Forms.SAPForm.txtSSubGroup.Text = "";
      MyProject.Forms.SAPForm.txtSSubGroup.Enabled = false;
      MyProject.Forms.SAPForm.txtSHeatingSource.Text = "";
      MyProject.Forms.SAPForm.txtSHeatingSource.Enabled = false;
      MyProject.Forms.SAPForm.txtSHeatingSource.Items.Clear();
      MyProject.Forms.SAPForm.txtSMainHeatingType.Text = "";
      MyProject.Forms.SAPForm.txtSMainHeatingType.Enabled = false;
      MyProject.Forms.SAPForm.txtSMainHeatingType.Items.Clear();
      MyProject.Forms.SAPForm.txtHETAS.Text = "";
      MyProject.Forms.SAPForm.txtSEfficiency.Text = "";
      MyProject.Forms.SAPForm.GroupBox34.Enabled = false;
      if (Operators.CompareString(MyProject.Forms.SAPForm.txtSPrimary.Text, "Room heaters", false) != 0)
        return;
      MyProject.Forms.SAPForm.txtSSubGroup.Enabled = true;
      MyProject.Forms.SAPForm.txtSSubGroup.Items.Add((object) "Gas (including LPG) room heaters");
      MyProject.Forms.SAPForm.txtSSubGroup.Items.Add((object) "Oil room heaters");
      MyProject.Forms.SAPForm.txtSSubGroup.Items.Add((object) "Solid fuel room heaters");
      MyProject.Forms.SAPForm.txtSSubGroup.Items.Add((object) "Electric (direct acting) room heaters");
    }

    public static void SCheckSource()
    {
      MyProject.Forms.SAPForm.txtSMainFuel.Enabled = false;
      MyProject.Forms.SAPForm.txtSMainFuel.Text = "";
      MyProject.Forms.SAPForm.txtSMainHeatingType.Enabled = false;
      MyProject.Forms.SAPForm.txtSMainHeatingType.Text = "";
      MyProject.Forms.SAPForm.txtSMainHeatingType.Items.Clear();
      MyProject.Forms.SAPForm.txtHETAS.Text = "";
      MyProject.Forms.SAPForm.txtSEfficiency.Text = "";
      MyProject.Forms.SAPForm.GroupBox34.Enabled = false;
      if (Operators.CompareString(MyProject.Forms.SAPForm.txtSHeatingSource.Text, "SAP Tables", false) == 0 | Operators.CompareString(MyProject.Forms.SAPForm.txtSHeatingSource.Text, "Manufacturer Declaration", false) == 0)
      {
        string text = MyProject.Forms.SAPForm.txtSSubGroup.Text;
        if (Operators.CompareString(text, "Gas (including LPG) room heaters", false) != 0)
        {
          if (Operators.CompareString(text, "Oil room heaters", false) != 0)
          {
            if (Operators.CompareString(text, "Solid fuel room heaters", false) != 0)
            {
              if (Operators.CompareString(text, "Electric (direct acting) room heaters", false) == 0)
              {
                MyProject.Forms.SAPForm.txtSMainHeatingType.Items.Add((object) "Panel, convector or radiant heaters");
                MyProject.Forms.SAPForm.txtSMainHeatingType.Items.Add((object) "Fan heaters");
                MyProject.Forms.SAPForm.txtSMainHeatingType.Items.Add((object) "Portable electric heaters");
                MyProject.Forms.SAPForm.txtSMainHeatingType.Items.Add((object) "Water- or oil-filled radiators");
                MyProject.Forms.SAPForm.txtSMainHeatingType.Enabled = true;
              }
            }
            else
            {
              MyProject.Forms.SAPForm.txtSMainHeatingType.Items.Add((object) "Open fire in grate");
              MyProject.Forms.SAPForm.txtSMainHeatingType.Items.Add((object) "Open fire with back boiler (no radiators)");
              MyProject.Forms.SAPForm.txtSMainHeatingType.Items.Add((object) "Closed room heater");
              MyProject.Forms.SAPForm.txtSMainHeatingType.Items.Add((object) "Closed room heater with boiler (no radiators)");
              MyProject.Forms.SAPForm.txtSMainHeatingType.Items.Add((object) "Stove (pellet fired)");
              MyProject.Forms.SAPForm.txtSMainHeatingType.Items.Add((object) "Stove (pellet fired) with boiler (no radiators)");
              MyProject.Forms.SAPForm.txtSMainHeatingType.Enabled = true;
              MyProject.Forms.SAPForm.GroupBox34.Enabled = true;
            }
          }
          else
          {
            MyProject.Forms.SAPForm.txtSMainHeatingType.Items.Add((object) "Room heater, pre 2000");
            MyProject.Forms.SAPForm.txtSMainHeatingType.Items.Add((object) "Room heater, pre 2000, with boiler (no radiators)");
            MyProject.Forms.SAPForm.txtSMainHeatingType.Items.Add((object) "Room heater, 2000 or later");
            MyProject.Forms.SAPForm.txtSMainHeatingType.Items.Add((object) "Room heater, 2000 or later with boiler (no radiators)");
            MyProject.Forms.SAPForm.txtSMainHeatingType.Items.Add((object) "Bioethanol heater, secondary heating only");
            MyProject.Forms.SAPForm.txtSMainHeatingType.Enabled = true;
          }
        }
        else
        {
          MyProject.Forms.SAPForm.txtSMainHeatingType.Items.Add((object) "Gas fire, open flue, pre-1980 (open fronted)");
          MyProject.Forms.SAPForm.txtSMainHeatingType.Items.Add((object) "Gas fire, open flue, pre-1980 (open fronted), with back boiler unit");
          MyProject.Forms.SAPForm.txtSMainHeatingType.Items.Add((object) "Gas fire, open flue, 1980 or later (open fronted),sitting proud of, and sealed to, fireplace opening");
          MyProject.Forms.SAPForm.txtSMainHeatingType.Items.Add((object) "Gas fire, open flue, 1980 or later (open fronted), sitting proud of, and sealed to, fireplace opening, with back boiler unit");
          MyProject.Forms.SAPForm.txtSMainHeatingType.Items.Add((object) "Flush fitting Live Fuel Effect gas fire (open fronted), sealed to fireplace opening");
          MyProject.Forms.SAPForm.txtSMainHeatingType.Items.Add((object) "Flush fitting Live Fuel Effect gas fire (open fronted), sealed to fireplace opening, with back boiler unit");
          MyProject.Forms.SAPForm.txtSMainHeatingType.Items.Add((object) "Flush fitting Live Fuel Effect gas fire (open fronted), fan assisted, sealed to fireplace opening");
          MyProject.Forms.SAPForm.txtSMainHeatingType.Items.Add((object) "Gas fire or wall heater, balanced flue");
          MyProject.Forms.SAPForm.txtSMainHeatingType.Items.Add((object) "Gas fire, closed fronted, fan assisted");
          MyProject.Forms.SAPForm.txtSMainHeatingType.Items.Add((object) "Condensing gas fire");
          MyProject.Forms.SAPForm.txtSMainHeatingType.Items.Add((object) "Decorative Fuel Effect gas fire, open to chimney");
          MyProject.Forms.SAPForm.txtSMainHeatingType.Items.Add((object) "Flueless gas fire, secondary heating only");
          MyProject.Forms.SAPForm.txtSMainHeatingType.Enabled = true;
        }
      }
      else
        MyProject.Forms.SAPForm.txtSMainHeatingType.Enabled = false;
      if (Operators.CompareString(MyProject.Forms.SAPForm.txtSHeatingSource.Text, "Manufacturer Declaration", false) == 0)
        MyProject.Forms.SAPForm.txtSEfficiency.Enabled = true;
      else
        MyProject.Forms.SAPForm.txtSEfficiency.Enabled = false;
      MyProject.Forms.SAPForm.txtSMainHeatingType.DropDownWidth = 1;
      Graphics graphics = Graphics.FromImage((Image) new Bitmap(2, 2));
      int num1 = checked (MyProject.Forms.SAPForm.txtSMainHeatingType.Items.Count - 1);
      int index = 0;
      while (index <= num1)
      {
        double dropDownWidth = (double) MyProject.Forms.SAPForm.txtSMainHeatingType.DropDownWidth;
        SizeF sizeF = graphics.MeasureString(Conversions.ToString(MyProject.Forms.SAPForm.txtSMainHeatingType.Items[index]), new Font("Tahoma", 9f));
        double width = (double) sizeF.Width;
        if (dropDownWidth < width)
        {
          ComboBox smainHeatingType = MyProject.Forms.SAPForm.txtSMainHeatingType;
          sizeF = graphics.MeasureString(Conversions.ToString(MyProject.Forms.SAPForm.txtSMainHeatingType.Items[index]), new Font("Tahoma", 9f));
          int num2 = checked ((int) Math.Round((double) sizeF.Width));
          smainHeatingType.DropDownWidth = num2;
        }
        checked { ++index; }
      }
    }

    public static void SCheckFuelTypeForSAPTable(string Description)
    {
      try
      {
        try
        {
          if (Operators.CompareString(Description, "Portable electric heaters", false) == 0)
            Description = "Portable Electric heaters";
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        PCDF.Table4a_B table4aB = SAP_Module.PCDFData.Table4a_bs.Where<PCDF.Table4a_B>((Func<PCDF.Table4a_B, bool>) (b => b.Description.Equals(Description))).SingleOrDefault<PCDF.Table4a_B>();
        MyProject.Forms.SAPForm.txtSMainFuel.Text = "";
        MyProject.Forms.SAPForm.txtSMainFuel.Items.Clear();
        MyProject.Forms.SAPForm.txtSMainFuel.Enabled = true;
        MyProject.Forms.SAPForm.txtSEfficiency.Text = "";
        string fuel = table4aB.Fuel;
        if (Operators.CompareString(fuel, "Gas", false) != 0)
        {
          if (Operators.CompareString(fuel, "Electricity", false) != 0)
          {
            if (Operators.CompareString(fuel, "Oil", false) != 0)
            {
              if (Operators.CompareString(fuel, "Solid", false) != 0)
              {
                if (Operators.CompareString(fuel, "Community", false) != 0)
                  return;
                MyProject.Forms.SAPForm.txtSMainFuel.Items.Add((object) "heat from boilers gas");
                MyProject.Forms.SAPForm.txtSMainFuel.Items.Add((object) "heat from boilers oil");
                MyProject.Forms.SAPForm.txtSMainFuel.Items.Add((object) "heat from boilers solid fuel");
                MyProject.Forms.SAPForm.txtSMainFuel.Items.Add((object) "anthracite");
                MyProject.Forms.SAPForm.txtSMainFuel.Items.Add((object) "anthracite");
                MyProject.Forms.SAPForm.txtSMainFuel.Items.Add((object) "anthracite");
                MyProject.Forms.SAPForm.txtSMainFuel.Items.Add((object) "anthracite");
                MyProject.Forms.SAPForm.txtSMainFuel.Items.Add((object) "anthracite");
                MyProject.Forms.SAPForm.txtSMainFuel.Items.Add((object) "anthracite");
              }
              else
              {
                MyProject.Forms.SAPForm.txtSMainFuel.Items.Add((object) "house coal");
                MyProject.Forms.SAPForm.txtSMainFuel.Items.Add((object) "anthracite");
                MyProject.Forms.SAPForm.txtSMainFuel.Items.Add((object) "manufactured smokeless fuel");
                MyProject.Forms.SAPForm.txtSMainFuel.Items.Add((object) "wood logs");
                MyProject.Forms.SAPForm.txtSMainFuel.Items.Add((object) "wood pellets (in bags, for secondary heating)");
                MyProject.Forms.SAPForm.txtSMainFuel.Items.Add((object) "wood pellets (bulk supply in bags, for main heating)");
                MyProject.Forms.SAPForm.txtSMainFuel.Items.Add((object) "wood chips");
                MyProject.Forms.SAPForm.txtSMainFuel.Items.Add((object) "dual fuel appliance (mineral and wood)");
              }
            }
            else
            {
              MyProject.Forms.SAPForm.txtSMainFuel.Items.Add((object) "heating oil");
              MyProject.Forms.SAPForm.txtSMainFuel.Items.Add((object) "biodiesel from any biomass source");
              MyProject.Forms.SAPForm.txtSMainFuel.Items.Add((object) "biodiesel from used cooking oil only");
              MyProject.Forms.SAPForm.txtSMainFuel.Items.Add((object) "rapeseed oil");
              MyProject.Forms.SAPForm.txtSMainFuel.Items.Add((object) "appliances able to use mineral oil or liquid biofuel");
              MyProject.Forms.SAPForm.txtSMainFuel.Items.Add((object) "B30K");
              MyProject.Forms.SAPForm.txtSMainFuel.Items.Add((object) "bioethanol from any biomass source");
            }
          }
          else
          {
            MyProject.Forms.SAPForm.txtSMainFuel.Items.Add((object) "Electricity");
            MyProject.Forms.SAPForm.txtSMainFuel.Enabled = false;
            MyProject.Forms.SAPForm.txtSMainFuel.Text = "Electricity";
          }
        }
        else
        {
          MyProject.Forms.SAPForm.txtSMainFuel.Items.Add((object) "mains gas");
          MyProject.Forms.SAPForm.txtSMainFuel.Items.Add((object) "bulk LPG");
          MyProject.Forms.SAPForm.txtSMainFuel.Items.Add((object) "bottled LPG");
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    public static void GetSecEfficiency(string FirstGroup, string SecondGroup, string Description)
    {
      try
      {
        try
        {
          if (Operators.CompareString(Description, "Portable electric heaters", false) == 0)
            Description = "Portable Electric heaters";
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        PCDF.Table4a_B table4aB = SAP_Module.PCDFData.Table4a_bs.Where<PCDF.Table4a_B>((Func<PCDF.Table4a_B, bool>) (b => b.Description.Equals(Description) & b.FirstGroup.Equals(FirstGroup) & b.SecondGroup.Equals(SecondGroup))).SingleOrDefault<PCDF.Table4a_B>();
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].SecHeating.SAPTableCode = checked ((int) Math.Round(Conversion.Val(table4aB.Code)));
        if (Operators.CompareString(MyProject.Forms.SAPForm.txtSHeatingSource.Text, "SAP Tables", false) == 0)
        {
          MyProject.Forms.SAPForm.txtSEfficiency.Enabled = false;
          int sapTableCode = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].SecHeating.SAPTableCode;
          if (sapTableCode >= 601 && sapTableCode <= 613)
          {
            if (Operators.CompareString(MyProject.Forms.SAPForm.txtSMainFuel.Text, "mains gas", false) == 0)
              MyProject.Forms.SAPForm.txtSEfficiency.Text = table4aB.EffA;
            else
              MyProject.Forms.SAPForm.txtSEfficiency.Text = table4aB.EffB;
          }
          else if (sapTableCode >= 631 && sapTableCode <= 636)
          {
            if (Operators.CompareString(MyProject.Forms.SAPForm.txtHETAS.Text, "Yes", false) == 0)
              MyProject.Forms.SAPForm.txtSEfficiency.Text = table4aB.EffA;
            else
              MyProject.Forms.SAPForm.txtSEfficiency.Text = table4aB.EffB;
          }
          else
            MyProject.Forms.SAPForm.txtSEfficiency.Text = table4aB.EffB;
        }
        else
          MyProject.Forms.SAPForm.txtSEfficiency.Enabled = true;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }
  }
}
