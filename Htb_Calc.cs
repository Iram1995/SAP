
// Type: SAP2012.Htb_Calc




using Microsoft.VisualBasic.CompilerServices;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace SAP2012
{
  [DesignerGenerated]
  public class Htb_Calc : UserControl, IComponentConnector
  {
    public Htb_Calculator2012 topForm;
    private bool _contentLoaded;

    public Htb_Calc(Htb_Calculator2012 topForm)
    {
      this.InitializeComponent();
      this.topForm = topForm;
      if (SAP_Module.Junctions.Count == 0)
        this.FillJunctions();
      this.PopJunctions();
    }

    private void FillJunctions()
    {
      SAP_Module.Junctions.Add(new JunctionDetail()
      {
        Ref = "E1",
        Detail = "Steel lintel with perforated steel base plate ",
        Approved = 0.5f,
        DefaultValue = 1f,
        JuncType = JunctionDetail.JunctionType.ExternalWall,
        ImportLenght = true
      });
      SAP_Module.Junctions.Add(new JunctionDetail()
      {
        Ref = "E2",
        Detail = "Other lintels (including other steel lintels)",
        Approved = 0.3f,
        DefaultValue = 1f,
        JuncType = JunctionDetail.JunctionType.ExternalWall,
        ImportLenght = true
      });
      SAP_Module.Junctions.Add(new JunctionDetail()
      {
        Ref = "E3",
        Detail = "Sill",
        Approved = 0.04f,
        DefaultValue = 0.08f,
        JuncType = JunctionDetail.JunctionType.ExternalWall,
        ImportLenght = true
      });
      SAP_Module.Junctions.Add(new JunctionDetail()
      {
        Ref = "E4",
        Detail = "Jamb",
        Approved = 0.05f,
        DefaultValue = 0.1f,
        JuncType = JunctionDetail.JunctionType.ExternalWall,
        ImportLenght = true
      });
      SAP_Module.Junctions.Add(new JunctionDetail()
      {
        Ref = "E5",
        Detail = "Ground floor (normal)",
        Approved = 0.16f,
        DefaultValue = 0.32f,
        JuncType = JunctionDetail.JunctionType.ExternalWall
      });
      SAP_Module.Junctions.Add(new JunctionDetail()
      {
        Ref = "E19",
        Detail = "Ground floor (inverted) ",
        Approved = 0.0f,
        DefaultValue = 0.07f,
        JuncType = JunctionDetail.JunctionType.ExternalWall
      });
      SAP_Module.Junctions.Add(new JunctionDetail()
      {
        Ref = "E20",
        Detail = "Exposed floor (normal)",
        Approved = 0.0f,
        DefaultValue = 0.32f,
        JuncType = JunctionDetail.JunctionType.ExternalWall
      });
      SAP_Module.Junctions.Add(new JunctionDetail()
      {
        Ref = "E21",
        Detail = "Exposed floor (inverted)",
        Approved = 0.0f,
        DefaultValue = 0.32f,
        JuncType = JunctionDetail.JunctionType.ExternalWall
      });
      SAP_Module.Junctions.Add(new JunctionDetail()
      {
        Ref = "E22",
        Detail = "Basement floor",
        Approved = 0.0f,
        DefaultValue = 0.07f,
        JuncType = JunctionDetail.JunctionType.ExternalWall
      });
      SAP_Module.Junctions.Add(new JunctionDetail()
      {
        Ref = "E6",
        Detail = "Intermediate floor within a dwelling",
        Approved = 0.07f,
        DefaultValue = 0.14f,
        JuncType = JunctionDetail.JunctionType.ExternalWall
      });
      SAP_Module.Junctions.Add(new JunctionDetail()
      {
        Ref = "E7",
        Detail = "Party floor between dwellings (in blocks of flats)",
        Approved = 0.07f,
        DefaultValue = 0.14f,
        JuncType = JunctionDetail.JunctionType.ExternalWall
      });
      SAP_Module.Junctions.Add(new JunctionDetail()
      {
        Ref = "E8",
        Detail = "Balcony within a dwelling, wall insulation continuous",
        Approved = 0.0f,
        DefaultValue = 0.0f,
        JuncType = JunctionDetail.JunctionType.ExternalWall
      });
      SAP_Module.Junctions.Add(new JunctionDetail()
      {
        Ref = "E9",
        Detail = "Balcony between dwellings, wall insulation continuous",
        Approved = 0.0f,
        DefaultValue = 0.04f,
        JuncType = JunctionDetail.JunctionType.ExternalWall
      });
      SAP_Module.Junctions.Add(new JunctionDetail()
      {
        Ref = "E23",
        Detail = " Balcony within or between dwellings, balcony support penetrates wall insulation",
        Approved = 0.0f,
        DefaultValue = 1f,
        JuncType = JunctionDetail.JunctionType.ExternalWall
      });
      SAP_Module.Junctions.Add(new JunctionDetail()
      {
        Ref = "E10",
        Detail = "Eaves (insulation at ceiling level)",
        Approved = 0.06f,
        DefaultValue = 0.12f,
        JuncType = JunctionDetail.JunctionType.ExternalWall
      });
      SAP_Module.Junctions.Add(new JunctionDetail()
      {
        Ref = "E24",
        Detail = "Eaves (insulation at ceiling level - inverted)",
        Approved = 0.0f,
        DefaultValue = 0.24f,
        JuncType = JunctionDetail.JunctionType.ExternalWall
      });
      SAP_Module.Junctions.Add(new JunctionDetail()
      {
        Ref = "E11",
        Detail = "Eaves (insulation at rafter level) ",
        Approved = 0.04f,
        DefaultValue = 0.08f,
        JuncType = JunctionDetail.JunctionType.ExternalWall
      });
      SAP_Module.Junctions.Add(new JunctionDetail()
      {
        Ref = "E12",
        Detail = "Gable (insulation at ceiling level)",
        Approved = 0.24f,
        DefaultValue = 0.48f,
        JuncType = JunctionDetail.JunctionType.ExternalWall
      });
      SAP_Module.Junctions.Add(new JunctionDetail()
      {
        Ref = "E13",
        Detail = "Gable (insulation at rafter level) ",
        Approved = 0.04f,
        DefaultValue = 0.08f,
        JuncType = JunctionDetail.JunctionType.ExternalWall
      });
      SAP_Module.Junctions.Add(new JunctionDetail()
      {
        Ref = "E14",
        Detail = "Flat roof",
        Approved = 0.0f,
        DefaultValue = 0.08f,
        JuncType = JunctionDetail.JunctionType.ExternalWall
      });
      SAP_Module.Junctions.Add(new JunctionDetail()
      {
        Ref = "E15",
        Detail = "Flat roof with parapet",
        Approved = 0.0f,
        DefaultValue = 0.56f,
        JuncType = JunctionDetail.JunctionType.ExternalWall
      });
      SAP_Module.Junctions.Add(new JunctionDetail()
      {
        Ref = "E16",
        Detail = "Corner (normal)",
        Approved = 0.09f,
        DefaultValue = 0.18f,
        JuncType = JunctionDetail.JunctionType.ExternalWall
      });
      SAP_Module.Junctions.Add(new JunctionDetail()
      {
        Ref = "E17",
        Detail = "Corner (inverted – internal area greater than external area)",
        Approved = -0.09f,
        DefaultValue = 0.0f,
        JuncType = JunctionDetail.JunctionType.ExternalWall
      });
      SAP_Module.Junctions.Add(new JunctionDetail()
      {
        Ref = "E18",
        Detail = "Party wall between dwellings",
        Approved = 0.06f,
        DefaultValue = 0.12f,
        JuncType = JunctionDetail.JunctionType.ExternalWall
      });
      SAP_Module.Junctions.Add(new JunctionDetail()
      {
        Ref = "E25",
        Detail = "Staggered party wall between dwellings c",
        Approved = 0.0f,
        DefaultValue = 0.12f,
        JuncType = JunctionDetail.JunctionType.ExternalWall
      });
      SAP_Module.Junctions.Add(new JunctionDetail()
      {
        Ref = "P1",
        Detail = "Ground floor",
        Approved = 0.0f,
        DefaultValue = 0.16f,
        JuncType = JunctionDetail.JunctionType.PartyWall
      });
      SAP_Module.Junctions.Add(new JunctionDetail()
      {
        Ref = "P6",
        Detail = "Ground floor (inverted)",
        Approved = 0.0f,
        DefaultValue = 0.07f,
        JuncType = JunctionDetail.JunctionType.PartyWall
      });
      SAP_Module.Junctions.Add(new JunctionDetail()
      {
        Ref = "P2",
        Detail = "Intermediate floor within a dwelling",
        Approved = 0.0f,
        DefaultValue = 0.0f,
        JuncType = JunctionDetail.JunctionType.PartyWall
      });
      SAP_Module.Junctions.Add(new JunctionDetail()
      {
        Ref = "P3",
        Detail = "Intermediate floor between dwellings (in blocks of flats) ",
        Approved = 0.0f,
        DefaultValue = 0.0f,
        JuncType = JunctionDetail.JunctionType.PartyWall
      });
      SAP_Module.Junctions.Add(new JunctionDetail()
      {
        Ref = "P7",
        Detail = "Exposed floor (normal)",
        Approved = 0.0f,
        DefaultValue = 0.16f,
        JuncType = JunctionDetail.JunctionType.PartyWall
      });
      SAP_Module.Junctions.Add(new JunctionDetail()
      {
        Ref = "P8",
        Detail = "Exposed floor (inverted)",
        Approved = 0.0f,
        DefaultValue = 0.24f,
        JuncType = JunctionDetail.JunctionType.PartyWall
      });
      SAP_Module.Junctions.Add(new JunctionDetail()
      {
        Ref = "P4",
        Detail = "Roof (insulation at ceiling level)",
        Approved = 0.0f,
        DefaultValue = 0.24f,
        JuncType = JunctionDetail.JunctionType.PartyWall
      });
      SAP_Module.Junctions.Add(new JunctionDetail()
      {
        Ref = "P5",
        Detail = "Roof (insulation at rafter level) ",
        Approved = 0.0f,
        DefaultValue = 0.08f,
        JuncType = JunctionDetail.JunctionType.PartyWall
      });
      SAP_Module.Junctions.Add(new JunctionDetail()
      {
        Ref = "R1",
        Detail = "Head of roof window",
        Approved = 0.0f,
        DefaultValue = 0.08f,
        JuncType = JunctionDetail.JunctionType.Roof,
        ImportLenght = true
      });
      SAP_Module.Junctions.Add(new JunctionDetail()
      {
        Ref = "R2",
        Detail = "Sill of roof window",
        Approved = 0.0f,
        DefaultValue = 0.06f,
        JuncType = JunctionDetail.JunctionType.Roof,
        ImportLenght = true
      });
      SAP_Module.Junctions.Add(new JunctionDetail()
      {
        Ref = "R3",
        Detail = "Jamb of roof window",
        Approved = 0.0f,
        DefaultValue = 0.08f,
        JuncType = JunctionDetail.JunctionType.Roof,
        ImportLenght = true
      });
      SAP_Module.Junctions.Add(new JunctionDetail()
      {
        Ref = "R4",
        Detail = "Ridge (vaulted ceiling)",
        Approved = 0.0f,
        DefaultValue = 0.08f,
        JuncType = JunctionDetail.JunctionType.Roof
      });
      SAP_Module.Junctions.Add(new JunctionDetail()
      {
        Ref = "R5",
        Detail = "Ridge (inverted)",
        Approved = 0.0f,
        DefaultValue = 0.04f,
        JuncType = JunctionDetail.JunctionType.Roof
      });
      SAP_Module.Junctions.Add(new JunctionDetail()
      {
        Ref = "R6",
        Detail = "Flat ceiling",
        Approved = 0.0f,
        DefaultValue = 0.06f,
        JuncType = JunctionDetail.JunctionType.Roof
      });
      SAP_Module.Junctions.Add(new JunctionDetail()
      {
        Ref = "R7",
        Detail = "Flat ceiling (inverted)",
        Approved = 0.0f,
        DefaultValue = 0.04f,
        JuncType = JunctionDetail.JunctionType.Roof
      });
      SAP_Module.Junctions.Add(new JunctionDetail()
      {
        Ref = "R8",
        Detail = "Roof to wall (rafter)",
        Approved = 0.0f,
        DefaultValue = 0.06f,
        JuncType = JunctionDetail.JunctionType.Roof
      });
      SAP_Module.Junctions.Add(new JunctionDetail()
      {
        Ref = "R9",
        Detail = "Roof to wall (flat ceiling) ",
        Approved = 0.0f,
        DefaultValue = 0.04f,
        JuncType = JunctionDetail.JunctionType.Roof
      });
    }

    public void PopJunctions()
    {
      this.stkExternal.Children.Clear();
      this.stkParty.Children.Clear();
      this.stkRoof.Children.Clear();
      if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.ExternalJunctions == null)
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.ExternalJunctions = new List<SAP_Module.Junction>();
      if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.RoofJunctions == null)
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.RoofJunctions = new List<SAP_Module.Junction>();
      if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.PartyJunctions == null)
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.PartyJunctions = new List<SAP_Module.Junction>();
      int num1 = checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.ExternalJunctions.Count - 1);
      int index = 0;
      while (index <= num1 && index <= checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.ExternalJunctions.Count - 1))
      {
        if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.ExternalJunctions[index].Ref != null)
        {
          if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.ExternalJunctions[index].Ref.Contains("P"))
          {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            Htb_Calc._Closure\u0024__3\u002D0 closure30 = new Htb_Calc._Closure\u0024__3\u002D0(closure30);
            // ISSUE: reference to a compiler-generated field
            closure30.\u0024VB\u0024Local_tempJunc = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.ExternalJunctions[index];
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.ExternalJunctions.Remove(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.ExternalJunctions[index]);
            // ISSUE: reference to a compiler-generated field
            closure30.\u0024VB\u0024Local_tempJunc.IsAccredited = false;
            // ISSUE: reference to a compiler-generated method
            JunctionDetail junctionDetail = SAP_Module.Junctions.Where<JunctionDetail>(new Func<JunctionDetail, bool>(closure30._Lambda\u0024__0)).SingleOrDefault<JunctionDetail>();
            // ISSUE: reference to a compiler-generated field
            if ((double) closure30.\u0024VB\u0024Local_tempJunc.ThermalTransmittance == (double) junctionDetail.DefaultValue)
            {
              // ISSUE: reference to a compiler-generated field
              closure30.\u0024VB\u0024Local_tempJunc.IsDefault = true;
            }
            // ISSUE: reference to a compiler-generated field
            closure30.\u0024VB\u0024Local_tempJunc.Defaul = Math.Round((double) junctionDetail.DefaultValue, 2);
            // ISSUE: reference to a compiler-generated field
            closure30.\u0024VB\u0024Local_tempJunc.JunctionDetail = junctionDetail.Detail;
            // ISSUE: reference to a compiler-generated field
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.PartyJunctions.Add(closure30.\u0024VB\u0024Local_tempJunc);
            checked { --index; }
          }
          try
          {
            if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.ExternalJunctions[index].Ref.Contains("R"))
            {
              // ISSUE: object of a compiler-generated type is created
              // ISSUE: variable of a compiler-generated type
              Htb_Calc._Closure\u0024__3\u002D1 closure31 = new Htb_Calc._Closure\u0024__3\u002D1(closure31);
              // ISSUE: reference to a compiler-generated field
              closure31.\u0024VB\u0024Local_tempJunc = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.ExternalJunctions[index];
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.ExternalJunctions.Remove(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.ExternalJunctions[index]);
              // ISSUE: reference to a compiler-generated field
              closure31.\u0024VB\u0024Local_tempJunc.IsAccredited = false;
              // ISSUE: reference to a compiler-generated method
              JunctionDetail junctionDetail = SAP_Module.Junctions.Where<JunctionDetail>(new Func<JunctionDetail, bool>(closure31._Lambda\u0024__1)).SingleOrDefault<JunctionDetail>();
              // ISSUE: reference to a compiler-generated field
              if ((double) closure31.\u0024VB\u0024Local_tempJunc.ThermalTransmittance == (double) junctionDetail.DefaultValue)
              {
                // ISSUE: reference to a compiler-generated field
                closure31.\u0024VB\u0024Local_tempJunc.IsDefault = true;
              }
              // ISSUE: reference to a compiler-generated field
              closure31.\u0024VB\u0024Local_tempJunc.Defaul = Math.Round((double) junctionDetail.DefaultValue, 2);
              bool flag = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.ExternalJunctions[index].Ref.Contains("R");
              if (flag == Conversions.ToBoolean("R1") || flag == Conversions.ToBoolean("R2") || flag == Conversions.ToBoolean("R3"))
              {
                // ISSUE: reference to a compiler-generated field
                closure31.\u0024VB\u0024Local_tempJunc.ImportLenght = true;
              }
              // ISSUE: reference to a compiler-generated field
              closure31.\u0024VB\u0024Local_tempJunc.JunctionDetail = junctionDetail.Detail;
              // ISSUE: reference to a compiler-generated field
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.RoofJunctions.Add(closure31.\u0024VB\u0024Local_tempJunc);
              checked { --index; }
            }
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
        }
        checked { ++index; }
      }
      int num2 = 0;
      // ISSUE: variable of a compiler-generated type
      Htb_Calc._Closure\u0024__3\u002D2 closure32_1;
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      Htb_Calc._Closure\u0024__3\u002D2 closure32_2 = new Htb_Calc._Closure\u0024__3\u002D2(closure32_1);
      // ISSUE: variable of a compiler-generated type
      Htb_Calc._Closure\u0024__3\u002D2 closure32_3 = closure32_2;
      int num3 = checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.ExternalJunctions.Count - 1);
      // ISSUE: reference to a compiler-generated field
      closure32_3.\u0024VB\u0024Local_i = 0;
      // ISSUE: reference to a compiler-generated field
      while (closure32_2.\u0024VB\u0024Local_i <= num3)
      {
        Htb_Junction element = new Htb_Junction();
        element.JuncType = Htb_Junction.JunctionType.External;
        element.topForm = this.topForm;
        element.Num = num2;
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.ExternalJunctions[closure32_2.\u0024VB\u0024Local_i].Accredited == 0.0 & SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.ExternalJunctions[closure32_2.\u0024VB\u0024Local_i].Defaul == 0.0)
        {
          // ISSUE: reference to a compiler-generated method
          JunctionDetail junctionDetail = SAP_Module.Junctions.Where<JunctionDetail>(new Func<JunctionDetail, bool>(closure32_2._Lambda\u0024__2)).SingleOrDefault<JunctionDetail>();
          if (junctionDetail != null)
          {
            // ISSUE: reference to a compiler-generated field
            SAP_Module.Junction externalJunction = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.ExternalJunctions[closure32_2.\u0024VB\u0024Local_i] with
            {
              Accredited = Math.Round((double) junctionDetail.Approved, 2),
              Defaul = Math.Round((double) junctionDetail.DefaultValue, 2),
              JunctionDetail = junctionDetail.Detail
            };
            string Left = externalJunction.Ref;
            if (Operators.CompareString(Left, "E1", false) == 0 || Operators.CompareString(Left, "E2", false) == 0 || Operators.CompareString(Left, "E3", false) == 0 || Operators.CompareString(Left, "E4", false) == 0)
              externalJunction.ImportLenght = true;
            // ISSUE: reference to a compiler-generated field
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.ExternalJunctions[closure32_2.\u0024VB\u0024Local_i] = externalJunction;
          }
        }
        // ISSUE: reference to a compiler-generated field
        element.Junction = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.ExternalJunctions[closure32_2.\u0024VB\u0024Local_i];
        // ISSUE: reference to a compiler-generated field
        element.txtAccredited.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.ExternalJunctions[closure32_2.\u0024VB\u0024Local_i].Accredited);
        // ISSUE: reference to a compiler-generated field
        element.txtDefault.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.ExternalJunctions[closure32_2.\u0024VB\u0024Local_i].Defaul);
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        element.txtDescription.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.ExternalJunctions[closure32_2.\u0024VB\u0024Local_i].Ref + ": " + SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.ExternalJunctions[closure32_2.\u0024VB\u0024Local_i].JunctionDetail;
        // ISSUE: reference to a compiler-generated field
        element.txtLength.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.ExternalJunctions[closure32_2.\u0024VB\u0024Local_i].Length);
        // ISSUE: reference to a compiler-generated field
        element.txtThermal.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.ExternalJunctions[closure32_2.\u0024VB\u0024Local_i].ThermalTransmittance);
        // ISSUE: reference to a compiler-generated field
        element.IsAccredited.IsChecked = new bool?(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.ExternalJunctions[closure32_2.\u0024VB\u0024Local_i].IsAccredited);
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        element.txtResult.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.ExternalJunctions[closure32_2.\u0024VB\u0024Local_i].Length * SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.ExternalJunctions[closure32_2.\u0024VB\u0024Local_i].ThermalTransmittance);
        // ISSUE: reference to a compiler-generated field
        element.IsDefault.IsChecked = new bool?(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.ExternalJunctions[closure32_2.\u0024VB\u0024Local_i].IsDefault);
        // ISSUE: reference to a compiler-generated field
        string Left1 = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.ExternalJunctions[closure32_2.\u0024VB\u0024Local_i].Ref;
        if (Operators.CompareString(Left1, "E1", false) == 0 || Operators.CompareString(Left1, "E2", false) == 0 || Operators.CompareString(Left1, "E3", false) == 0 || Operators.CompareString(Left1, "E4", false) == 0)
          element.ImportLen.IsEnabled = true;
        element.CheckValues();
        this.stkExternal.Children.Add((UIElement) element);
        checked { ++num2; }
        // ISSUE: reference to a compiler-generated field
        checked { ++closure32_2.\u0024VB\u0024Local_i; }
      }
      int num4 = 0;
      // ISSUE: variable of a compiler-generated type
      Htb_Calc._Closure\u0024__3\u002D3 closure33_1;
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      Htb_Calc._Closure\u0024__3\u002D3 closure33_2 = new Htb_Calc._Closure\u0024__3\u002D3(closure33_1);
      // ISSUE: variable of a compiler-generated type
      Htb_Calc._Closure\u0024__3\u002D3 closure33_3 = closure33_2;
      int num5 = checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.PartyJunctions.Count - 1);
      // ISSUE: reference to a compiler-generated field
      closure33_3.\u0024VB\u0024Local_i = 0;
      // ISSUE: reference to a compiler-generated field
      while (closure33_2.\u0024VB\u0024Local_i <= num5)
      {
        Htb_Junction element = new Htb_Junction();
        element.topForm = this.topForm;
        element.JuncType = Htb_Junction.JunctionType.Party;
        element.Num = num4;
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.PartyJunctions[closure33_2.\u0024VB\u0024Local_i].Accredited == 0.0 & SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.PartyJunctions[closure33_2.\u0024VB\u0024Local_i].Defaul == 0.0)
        {
          // ISSUE: reference to a compiler-generated method
          JunctionDetail junctionDetail = SAP_Module.Junctions.Where<JunctionDetail>(new Func<JunctionDetail, bool>(closure33_2._Lambda\u0024__3)).SingleOrDefault<JunctionDetail>();
          if (junctionDetail != null)
          {
            // ISSUE: reference to a compiler-generated field
            SAP_Module.Junction partyJunction = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.PartyJunctions[closure33_2.\u0024VB\u0024Local_i] with
            {
              Accredited = Math.Round((double) junctionDetail.Approved, 2),
              Defaul = Math.Round((double) junctionDetail.DefaultValue, 2),
              JunctionDetail = junctionDetail.Detail
            };
            // ISSUE: reference to a compiler-generated field
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.PartyJunctions[closure33_2.\u0024VB\u0024Local_i] = partyJunction;
          }
        }
        // ISSUE: reference to a compiler-generated field
        element.Junction = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.PartyJunctions[closure33_2.\u0024VB\u0024Local_i];
        // ISSUE: reference to a compiler-generated field
        element.txtAccredited.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.PartyJunctions[closure33_2.\u0024VB\u0024Local_i].Accredited);
        // ISSUE: reference to a compiler-generated field
        element.txtDefault.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.PartyJunctions[closure33_2.\u0024VB\u0024Local_i].Defaul);
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        element.txtDescription.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.PartyJunctions[closure33_2.\u0024VB\u0024Local_i].Ref + ": " + SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.PartyJunctions[closure33_2.\u0024VB\u0024Local_i].JunctionDetail;
        // ISSUE: reference to a compiler-generated field
        element.txtLength.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.PartyJunctions[closure33_2.\u0024VB\u0024Local_i].Length);
        // ISSUE: reference to a compiler-generated field
        element.txtThermal.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.PartyJunctions[closure33_2.\u0024VB\u0024Local_i].ThermalTransmittance);
        element.IsAccredited.IsChecked = new bool?(false);
        element.IsAccredited.IsEnabled = false;
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        element.txtResult.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.PartyJunctions[closure33_2.\u0024VB\u0024Local_i].Length * SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.PartyJunctions[closure33_2.\u0024VB\u0024Local_i].ThermalTransmittance);
        // ISSUE: reference to a compiler-generated field
        element.IsDefault.IsChecked = new bool?(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.PartyJunctions[closure33_2.\u0024VB\u0024Local_i].IsDefault);
        // ISSUE: reference to a compiler-generated field
        element.ImportLen.IsEnabled = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.PartyJunctions[closure33_2.\u0024VB\u0024Local_i].ImportLenght;
        element.CheckValues();
        this.stkParty.Children.Add((UIElement) element);
        checked { ++num4; }
        // ISSUE: reference to a compiler-generated field
        checked { ++closure33_2.\u0024VB\u0024Local_i; }
      }
      if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.RoofJunctions == null)
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.RoofJunctions = new List<SAP_Module.Junction>();
      int num6 = 0;
      // ISSUE: variable of a compiler-generated type
      Htb_Calc._Closure\u0024__3\u002D4 closure34_1;
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      Htb_Calc._Closure\u0024__3\u002D4 closure34_2 = new Htb_Calc._Closure\u0024__3\u002D4(closure34_1);
      // ISSUE: variable of a compiler-generated type
      Htb_Calc._Closure\u0024__3\u002D4 closure34_3 = closure34_2;
      int num7 = checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.RoofJunctions.Count - 1);
      // ISSUE: reference to a compiler-generated field
      closure34_3.\u0024VB\u0024Local_i = 0;
      // ISSUE: reference to a compiler-generated field
      while (closure34_2.\u0024VB\u0024Local_i <= num7)
      {
        Htb_Junction element = new Htb_Junction();
        element.topForm = this.topForm;
        element.JuncType = Htb_Junction.JunctionType.Roof;
        element.Num = num6;
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.RoofJunctions[closure34_2.\u0024VB\u0024Local_i].Accredited == 0.0 & SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.RoofJunctions[closure34_2.\u0024VB\u0024Local_i].Defaul == 0.0)
        {
          // ISSUE: reference to a compiler-generated method
          JunctionDetail junctionDetail = SAP_Module.Junctions.Where<JunctionDetail>(new Func<JunctionDetail, bool>(closure34_2._Lambda\u0024__4)).SingleOrDefault<JunctionDetail>();
          if (junctionDetail != null)
          {
            // ISSUE: reference to a compiler-generated field
            SAP_Module.Junction roofJunction = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.RoofJunctions[closure34_2.\u0024VB\u0024Local_i] with
            {
              Accredited = Math.Round((double) junctionDetail.Approved, 2),
              Defaul = Math.Round((double) junctionDetail.DefaultValue, 2),
              JunctionDetail = junctionDetail.Detail
            };
            // ISSUE: reference to a compiler-generated field
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.RoofJunctions[closure34_2.\u0024VB\u0024Local_i] = roofJunction;
          }
        }
        // ISSUE: reference to a compiler-generated field
        element.Junction = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.RoofJunctions[closure34_2.\u0024VB\u0024Local_i];
        // ISSUE: reference to a compiler-generated field
        element.txtAccredited.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.RoofJunctions[closure34_2.\u0024VB\u0024Local_i].Accredited);
        // ISSUE: reference to a compiler-generated field
        element.txtDefault.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.RoofJunctions[closure34_2.\u0024VB\u0024Local_i].Defaul);
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        element.txtDescription.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.RoofJunctions[closure34_2.\u0024VB\u0024Local_i].Ref + ": " + SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.RoofJunctions[closure34_2.\u0024VB\u0024Local_i].JunctionDetail;
        // ISSUE: reference to a compiler-generated field
        element.txtLength.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.RoofJunctions[closure34_2.\u0024VB\u0024Local_i].Length);
        // ISSUE: reference to a compiler-generated field
        element.txtThermal.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.RoofJunctions[closure34_2.\u0024VB\u0024Local_i].ThermalTransmittance);
        element.IsAccredited.IsEnabled = false;
        element.IsAccredited.IsChecked = new bool?(false);
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        element.txtResult.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.RoofJunctions[closure34_2.\u0024VB\u0024Local_i].Length * SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.RoofJunctions[closure34_2.\u0024VB\u0024Local_i].ThermalTransmittance);
        // ISSUE: reference to a compiler-generated field
        element.IsDefault.IsChecked = new bool?(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.RoofJunctions[closure34_2.\u0024VB\u0024Local_i].IsDefault);
        // ISSUE: reference to a compiler-generated field
        string Left = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.RoofJunctions[closure34_2.\u0024VB\u0024Local_i].Ref;
        if (Operators.CompareString(Left, "R1", false) == 0 || Operators.CompareString(Left, "R2", false) == 0 || Operators.CompareString(Left, "R3", false) == 0)
          element.ImportLen.IsEnabled = true;
        element.CheckValues();
        this.stkRoof.Children.Add((UIElement) element);
        checked { ++num6; }
        // ISSUE: reference to a compiler-generated field
        checked { ++closure34_2.\u0024VB\u0024Local_i; }
      }
      this.topForm.TotalIt();
    }

    private void cmdAddExternal_Click(object sender, RoutedEventArgs e)
    {
      if (this.cboExternal.SelectedIndex == 0)
        return;
      SAP_Module.Junction junction1 = new SAP_Module.Junction();
      List<string> list = ((IEnumerable<string>) NewLateBinding.LateGet(this.cboExternal.SelectedItem, (System.Type) null, "Content", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null).ToString().Split(':')).ToList<string>();
      switch (this.cboExternal.SelectedIndex)
      {
        case 1:
          SAP_Module.Junction junction2 = new SAP_Module.Junction()
          {
            Ref = "E1",
            JunctionDetail = list.Last<string>(),
            Accredited = 0.5,
            Defaul = 1.0
          };
          junction2.ThermalTransmittance = (float) junction2.Defaul;
          junction2.IsDefault = true;
          junction2.ImportLenght = true;
          junction1 = junction2;
          break;
        case 2:
          SAP_Module.Junction junction3 = new SAP_Module.Junction()
          {
            Ref = "E2",
            JunctionDetail = list.Last<string>(),
            Accredited = 0.3,
            Defaul = 1.0
          };
          junction3.ThermalTransmittance = (float) junction3.Defaul;
          junction3.IsDefault = true;
          junction3.ImportLenght = true;
          junction1 = junction3;
          break;
        case 3:
          SAP_Module.Junction junction4 = new SAP_Module.Junction()
          {
            Ref = "E3",
            JunctionDetail = list.Last<string>(),
            Accredited = 0.04,
            Defaul = 0.08
          };
          junction4.ThermalTransmittance = (float) junction4.Defaul;
          junction4.IsDefault = true;
          junction4.ImportLenght = true;
          junction1 = junction4;
          break;
        case 4:
          SAP_Module.Junction junction5 = new SAP_Module.Junction()
          {
            Ref = "E4",
            JunctionDetail = list.Last<string>(),
            Accredited = 0.05,
            Defaul = 0.1
          };
          junction5.ThermalTransmittance = (float) junction5.Defaul;
          junction5.IsDefault = true;
          junction5.ImportLenght = true;
          junction1 = junction5;
          break;
        case 5:
          SAP_Module.Junction junction6 = new SAP_Module.Junction()
          {
            Ref = "E5",
            JunctionDetail = list.Last<string>(),
            Accredited = 0.16,
            Defaul = 0.32
          };
          junction6.ThermalTransmittance = (float) junction6.Defaul;
          junction6.IsDefault = true;
          junction1 = junction6;
          break;
        case 6:
          SAP_Module.Junction junction7 = new SAP_Module.Junction()
          {
            Ref = "E19",
            JunctionDetail = list.Last<string>(),
            Accredited = 0.0,
            Defaul = 0.07
          };
          junction7.ThermalTransmittance = (float) junction7.Defaul;
          junction7.IsDefault = true;
          junction1 = junction7;
          break;
        case 7:
          SAP_Module.Junction junction8 = new SAP_Module.Junction()
          {
            Ref = "E20",
            JunctionDetail = list.Last<string>(),
            Accredited = 0.0,
            Defaul = 0.32
          };
          junction8.ThermalTransmittance = (float) junction8.Defaul;
          junction8.IsDefault = true;
          junction1 = junction8;
          break;
        case 8:
          SAP_Module.Junction junction9 = new SAP_Module.Junction()
          {
            Ref = "E21",
            JunctionDetail = list.Last<string>(),
            Accredited = 0.0,
            Defaul = 0.32
          };
          junction9.ThermalTransmittance = (float) junction9.Defaul;
          junction9.IsDefault = true;
          junction1 = junction9;
          break;
        case 9:
          SAP_Module.Junction junction10 = new SAP_Module.Junction()
          {
            Ref = "E22",
            JunctionDetail = list.Last<string>(),
            Accredited = 0.0,
            Defaul = 0.07
          };
          junction10.ThermalTransmittance = (float) junction10.Defaul;
          junction10.IsDefault = true;
          junction1 = junction10;
          break;
        case 10:
          SAP_Module.Junction junction11 = new SAP_Module.Junction()
          {
            Ref = "E6",
            JunctionDetail = list.Last<string>(),
            Accredited = 0.07,
            Defaul = 0.14
          };
          junction11.ThermalTransmittance = (float) junction11.Defaul;
          junction11.IsDefault = true;
          junction1 = junction11;
          break;
        case 11:
          SAP_Module.Junction junction12 = new SAP_Module.Junction()
          {
            Ref = "E7",
            JunctionDetail = list.Last<string>(),
            Accredited = 0.07,
            Defaul = 0.14
          };
          junction12.ThermalTransmittance = (float) junction12.Defaul;
          junction12.IsDefault = true;
          junction1 = junction12;
          break;
        case 12:
          SAP_Module.Junction junction13 = new SAP_Module.Junction()
          {
            Ref = "E8",
            JunctionDetail = list.Last<string>(),
            Accredited = 0.0,
            Defaul = 0.0
          };
          junction13.ThermalTransmittance = (float) junction13.Defaul;
          junction13.IsDefault = true;
          junction1 = junction13;
          break;
        case 13:
          SAP_Module.Junction junction14 = new SAP_Module.Junction()
          {
            Ref = "E9",
            JunctionDetail = list.Last<string>(),
            Accredited = 0.02,
            Defaul = 0.04
          };
          junction14.ThermalTransmittance = (float) junction14.Defaul;
          junction14.IsDefault = true;
          junction1 = junction14;
          break;
        case 14:
          SAP_Module.Junction junction15 = new SAP_Module.Junction()
          {
            Ref = "E23",
            JunctionDetail = list.Last<string>(),
            Accredited = 0.0,
            Defaul = 1.0
          };
          junction15.ThermalTransmittance = (float) junction15.Defaul;
          junction15.IsDefault = true;
          junction1 = junction15;
          break;
        case 15:
          SAP_Module.Junction junction16 = new SAP_Module.Junction()
          {
            Ref = "E10",
            JunctionDetail = list.Last<string>(),
            Accredited = 0.06,
            Defaul = 0.12
          };
          junction16.ThermalTransmittance = (float) junction16.Defaul;
          junction16.IsDefault = true;
          junction1 = junction16;
          break;
        case 16:
          SAP_Module.Junction junction17 = new SAP_Module.Junction()
          {
            Ref = "E24",
            JunctionDetail = list.Last<string>(),
            Accredited = 0.0,
            Defaul = 0.24
          };
          junction17.ThermalTransmittance = (float) junction17.Defaul;
          junction17.IsDefault = true;
          junction1 = junction17;
          break;
        case 17:
          SAP_Module.Junction junction18 = new SAP_Module.Junction()
          {
            Ref = "E11",
            JunctionDetail = list.Last<string>(),
            Accredited = 0.04,
            Defaul = 0.08
          };
          junction18.ThermalTransmittance = (float) junction18.Defaul;
          junction18.IsDefault = true;
          junction1 = junction18;
          break;
        case 18:
          SAP_Module.Junction junction19 = new SAP_Module.Junction()
          {
            Ref = "E12",
            JunctionDetail = list.Last<string>(),
            Accredited = 0.24,
            Defaul = 0.48
          };
          junction19.ThermalTransmittance = (float) junction19.Defaul;
          junction19.IsDefault = true;
          junction1 = junction19;
          break;
        case 19:
          SAP_Module.Junction junction20 = new SAP_Module.Junction()
          {
            Ref = "E13",
            JunctionDetail = list.Last<string>(),
            Accredited = 0.04,
            Defaul = 0.08
          };
          junction20.ThermalTransmittance = (float) junction20.Defaul;
          junction20.IsDefault = true;
          junction1 = junction20;
          break;
        case 20:
          SAP_Module.Junction junction21 = new SAP_Module.Junction()
          {
            Ref = "E14",
            JunctionDetail = list.Last<string>(),
            Accredited = 0.0,
            Defaul = 0.08
          };
          junction21.ThermalTransmittance = (float) junction21.Defaul;
          junction21.IsDefault = true;
          junction1 = junction21;
          break;
        case 21:
          SAP_Module.Junction junction22 = new SAP_Module.Junction()
          {
            Ref = "E15",
            JunctionDetail = list.Last<string>(),
            Accredited = 0.0,
            Defaul = 0.56
          };
          junction22.ThermalTransmittance = (float) junction22.Defaul;
          junction22.IsDefault = true;
          junction1 = junction22;
          break;
        case 22:
          SAP_Module.Junction junction23 = new SAP_Module.Junction()
          {
            Ref = "E16",
            JunctionDetail = list.Last<string>(),
            Accredited = 0.09,
            Defaul = 0.18
          };
          junction23.ThermalTransmittance = (float) junction23.Defaul;
          junction23.IsDefault = true;
          junction1 = junction23;
          break;
        case 23:
          SAP_Module.Junction junction24 = new SAP_Module.Junction()
          {
            Ref = "E17",
            JunctionDetail = list.Last<string>(),
            Accredited = -0.09,
            Defaul = 0.0
          };
          junction24.ThermalTransmittance = (float) junction24.Defaul;
          junction24.IsDefault = true;
          junction1 = junction24;
          break;
        case 24:
          SAP_Module.Junction junction25 = new SAP_Module.Junction()
          {
            Ref = "E18",
            JunctionDetail = list.Last<string>(),
            Accredited = 0.06,
            Defaul = 0.12
          };
          junction25.ThermalTransmittance = (float) junction25.Defaul;
          junction25.IsDefault = true;
          junction1 = junction25;
          break;
        case 25:
          SAP_Module.Junction junction26 = new SAP_Module.Junction()
          {
            Ref = "E25",
            JunctionDetail = list.Last<string>(),
            Accredited = 0.0,
            Defaul = 0.12
          };
          junction26.ThermalTransmittance = (float) junction26.Defaul;
          junction26.IsDefault = true;
          junction1 = junction26;
          break;
      }
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.ExternalJunctions.Add(junction1);
      this.PopJunctions();
    }

    private void cmdAddParty_Click(object sender, RoutedEventArgs e)
    {
      if (this.cboParty.SelectedIndex == 0)
        return;
      SAP_Module.Junction junction1 = new SAP_Module.Junction();
      List<string> list = ((IEnumerable<string>) NewLateBinding.LateGet(this.cboParty.SelectedItem, (System.Type) null, "Content", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null).ToString().Split(':')).ToList<string>();
      switch (this.cboParty.SelectedIndex)
      {
        case 1:
          SAP_Module.Junction junction2 = new SAP_Module.Junction()
          {
            Ref = "P1",
            JunctionDetail = list.Last<string>(),
            Accredited = 0.0,
            Defaul = 0.16
          };
          junction2.ThermalTransmittance = (float) junction2.Defaul;
          junction2.IsDefault = true;
          junction1 = junction2;
          break;
        case 2:
          SAP_Module.Junction junction3 = new SAP_Module.Junction()
          {
            Ref = "P6",
            JunctionDetail = list.Last<string>(),
            Accredited = 0.0,
            Defaul = 0.07
          };
          junction3.ThermalTransmittance = (float) junction3.Defaul;
          junction3.IsDefault = true;
          junction1 = junction3;
          break;
        case 3:
          SAP_Module.Junction junction4 = new SAP_Module.Junction()
          {
            Ref = "P2",
            JunctionDetail = list.Last<string>(),
            Accredited = 0.0,
            Defaul = 0.0
          };
          junction4.ThermalTransmittance = (float) junction4.Defaul;
          junction4.IsDefault = true;
          junction1 = junction4;
          break;
        case 4:
          SAP_Module.Junction junction5 = new SAP_Module.Junction()
          {
            Ref = "P3",
            JunctionDetail = list.Last<string>(),
            Accredited = 0.0,
            Defaul = 0.0
          };
          junction5.ThermalTransmittance = (float) junction5.Defaul;
          junction5.IsDefault = true;
          junction1 = junction5;
          break;
        case 5:
          SAP_Module.Junction junction6 = new SAP_Module.Junction()
          {
            Ref = "P7",
            JunctionDetail = list.Last<string>(),
            Accredited = 0.0,
            Defaul = 0.16
          };
          junction6.ThermalTransmittance = (float) junction6.Defaul;
          junction6.IsDefault = true;
          junction1 = junction6;
          break;
        case 6:
          SAP_Module.Junction junction7 = new SAP_Module.Junction()
          {
            Ref = "P8",
            JunctionDetail = list.Last<string>(),
            Accredited = 0.0,
            Defaul = 0.24
          };
          junction7.ThermalTransmittance = (float) junction7.Defaul;
          junction7.IsDefault = true;
          junction1 = junction7;
          break;
        case 7:
          SAP_Module.Junction junction8 = new SAP_Module.Junction()
          {
            Ref = "P4",
            JunctionDetail = list.Last<string>(),
            Accredited = 0.0,
            Defaul = 0.24
          };
          junction8.ThermalTransmittance = (float) junction8.Defaul;
          junction8.IsDefault = true;
          junction1 = junction8;
          break;
        case 8:
          SAP_Module.Junction junction9 = new SAP_Module.Junction()
          {
            Ref = "P5",
            JunctionDetail = list.Last<string>(),
            Accredited = 0.0,
            Defaul = 0.08
          };
          junction9.ThermalTransmittance = (float) junction9.Defaul;
          junction9.IsDefault = true;
          junction1 = junction9;
          break;
      }
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.PartyJunctions.Add(junction1);
      this.PopJunctions();
    }

    private void cmdAddRoof_Click(object sender, RoutedEventArgs e)
    {
      if (this.cboRoof.SelectedIndex == 0)
        return;
      SAP_Module.Junction junction1 = new SAP_Module.Junction();
      List<string> list = ((IEnumerable<string>) NewLateBinding.LateGet(this.cboRoof.SelectedItem, (System.Type) null, "Content", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null).ToString().Split(':')).ToList<string>();
      switch (this.cboRoof.SelectedIndex)
      {
        case 1:
          SAP_Module.Junction junction2 = new SAP_Module.Junction()
          {
            Ref = "R1",
            JunctionDetail = list.Last<string>(),
            Accredited = 0.0,
            Defaul = 0.08
          };
          junction2.ThermalTransmittance = (float) junction2.Defaul;
          junction2.IsDefault = true;
          junction2.ImportLenght = true;
          junction1 = junction2;
          break;
        case 2:
          SAP_Module.Junction junction3 = new SAP_Module.Junction()
          {
            Ref = "R2",
            JunctionDetail = list.Last<string>(),
            Accredited = 0.0,
            Defaul = 0.06
          };
          junction3.ThermalTransmittance = (float) junction3.Defaul;
          junction3.IsDefault = true;
          junction3.ImportLenght = true;
          junction1 = junction3;
          break;
        case 3:
          SAP_Module.Junction junction4 = new SAP_Module.Junction()
          {
            Ref = "R3",
            JunctionDetail = list.Last<string>(),
            Accredited = 0.0,
            Defaul = 0.08
          };
          junction4.ThermalTransmittance = (float) junction4.Defaul;
          junction4.IsDefault = true;
          junction4.ImportLenght = true;
          junction1 = junction4;
          break;
        case 4:
          SAP_Module.Junction junction5 = new SAP_Module.Junction()
          {
            Ref = "R4",
            JunctionDetail = list.Last<string>(),
            Accredited = 0.0,
            Defaul = 0.08
          };
          junction5.ThermalTransmittance = (float) junction5.Defaul;
          junction5.IsDefault = true;
          junction1 = junction5;
          break;
        case 5:
          SAP_Module.Junction junction6 = new SAP_Module.Junction()
          {
            Ref = "R5",
            JunctionDetail = list.Last<string>(),
            Accredited = 0.0,
            Defaul = 0.04
          };
          junction6.ThermalTransmittance = (float) junction6.Defaul;
          junction6.IsDefault = true;
          junction1 = junction6;
          break;
        case 6:
          SAP_Module.Junction junction7 = new SAP_Module.Junction()
          {
            Ref = "R6",
            JunctionDetail = list.Last<string>(),
            Accredited = 0.0,
            Defaul = 0.06
          };
          junction7.ThermalTransmittance = (float) junction7.Defaul;
          junction7.IsDefault = true;
          junction1 = junction7;
          break;
        case 7:
          SAP_Module.Junction junction8 = new SAP_Module.Junction()
          {
            Ref = "R7",
            JunctionDetail = list.Last<string>(),
            Accredited = 0.0,
            Defaul = 0.04
          };
          junction8.ThermalTransmittance = (float) junction8.Defaul;
          junction8.IsDefault = true;
          junction1 = junction8;
          break;
        case 8:
          SAP_Module.Junction junction9 = new SAP_Module.Junction()
          {
            Ref = "R8",
            JunctionDetail = list.Last<string>(),
            Accredited = 0.0,
            Defaul = 0.06
          };
          junction9.ThermalTransmittance = (float) junction9.Defaul;
          junction9.IsDefault = true;
          junction1 = junction9;
          break;
        case 9:
          SAP_Module.Junction junction10 = new SAP_Module.Junction()
          {
            Ref = "R9",
            JunctionDetail = list.Last<string>(),
            Accredited = 0.0,
            Defaul = 0.04
          };
          junction10.ThermalTransmittance = (float) junction10.Defaul;
          junction10.IsDefault = true;
          junction1 = junction10;
          break;
      }
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.RoofJunctions.Add(junction1);
      this.PopJunctions();
    }

    [field: AccessedThroughProperty("stackPanel1")]
    internal virtual StackPanel stackPanel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("ExternalWallJunctions")]
    internal virtual Expander ExternalWallJunctions { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button cmdAddExternal
    {
      get => this._cmdAddExternal;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        RoutedEventHandler routedEventHandler = new RoutedEventHandler(this.cmdAddExternal_Click);
        Button cmdAddExternal1 = this._cmdAddExternal;
        if (cmdAddExternal1 != null)
          cmdAddExternal1.Click -= routedEventHandler;
        this._cmdAddExternal = value;
        Button cmdAddExternal2 = this._cmdAddExternal;
        if (cmdAddExternal2 == null)
          return;
        cmdAddExternal2.Click += routedEventHandler;
      }
    }

    [field: AccessedThroughProperty("cboExternal")]
    internal virtual ComboBox cboExternal { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("stkExternal")]
    internal virtual StackPanel stkExternal { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("PartyWallJunctions")]
    internal virtual Expander PartyWallJunctions { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button cmdAddParty
    {
      get => this._cmdAddParty;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        RoutedEventHandler routedEventHandler = new RoutedEventHandler(this.cmdAddParty_Click);
        Button cmdAddParty1 = this._cmdAddParty;
        if (cmdAddParty1 != null)
          cmdAddParty1.Click -= routedEventHandler;
        this._cmdAddParty = value;
        Button cmdAddParty2 = this._cmdAddParty;
        if (cmdAddParty2 == null)
          return;
        cmdAddParty2.Click += routedEventHandler;
      }
    }

    [field: AccessedThroughProperty("cboParty")]
    internal virtual ComboBox cboParty { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("stkParty")]
    internal virtual StackPanel stkParty { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("RooforWithaRoominRoofJunctions")]
    internal virtual Expander RooforWithaRoominRoofJunctions { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button cmdAddRoof
    {
      get => this._cmdAddRoof;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        RoutedEventHandler routedEventHandler = new RoutedEventHandler(this.cmdAddRoof_Click);
        Button cmdAddRoof1 = this._cmdAddRoof;
        if (cmdAddRoof1 != null)
          cmdAddRoof1.Click -= routedEventHandler;
        this._cmdAddRoof = value;
        Button cmdAddRoof2 = this._cmdAddRoof;
        if (cmdAddRoof2 == null)
          return;
        cmdAddRoof2.Click += routedEventHandler;
      }
    }

    [field: AccessedThroughProperty("cboRoof")]
    internal virtual ComboBox cboRoof { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("stkRoof")]
    internal virtual StackPanel stkRoof { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [DebuggerNonUserCode]
    [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
    public void InitializeComponent()
    {
      if (this._contentLoaded)
        return;
      this._contentLoaded = true;
      Application.LoadComponent((object) this, new Uri("/SAP2012;component/wpf%20elelemts/htb_calc.xaml", UriKind.Relative));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public void System_Windows_Markup_IComponentConnector_Connect(int connectionId, object target)
    {
      switch (connectionId)
      {
        case 1:
          this.stackPanel1 = (StackPanel) target;
          break;
        case 2:
          this.ExternalWallJunctions = (Expander) target;
          break;
        case 3:
          this.cmdAddExternal = (Button) target;
          break;
        case 4:
          this.cboExternal = (ComboBox) target;
          break;
        case 5:
          this.stkExternal = (StackPanel) target;
          break;
        case 6:
          this.PartyWallJunctions = (Expander) target;
          break;
        case 7:
          this.cmdAddParty = (Button) target;
          break;
        case 8:
          this.cboParty = (ComboBox) target;
          break;
        case 9:
          this.stkParty = (StackPanel) target;
          break;
        case 10:
          this.RooforWithaRoominRoofJunctions = (Expander) target;
          break;
        case 11:
          this.cmdAddRoof = (Button) target;
          break;
        case 12:
          this.cboRoof = (ComboBox) target;
          break;
        case 13:
          this.stkRoof = (StackPanel) target;
          break;
        default:
          this._contentLoaded = true;
          break;
      }
    }
  }
}
