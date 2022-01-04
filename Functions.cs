
// Type: SAP2012.Functions




using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using SAP2012.My;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace SAP2012
{
  [StandardModule]
  public sealed class Functions
  {
    public static string TransactionID;
    public static string Encrypt;
    public static bool SpFuel;
    public static double SpFuelValue;
    public static bool DoRedo;
    public static bool CommunityRedo;

    public static void ReDime() => SAP_Module.Proj.Dwellings = new SAP_Module.Dwelling[1];

    private static void SetCalcVersion()
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.CurrVersion, "Debug Mode", false) == 0)
      {
        if (SAP_Module.Proj.OverRide)
          return;
        SAP_Module.Proj.CalcVersion = SAP_Module.DebugVersion;
      }
      else if (!SAP_Module.Proj.OverRide)
        SAP_Module.Proj.CalcVersion = MyProject.Application.Deployment.CurrentVersion.ToString();
    }

    public static void Access_Details()
    {
      string str1 = "StromaRdSAP";
      string str2 = "09820489172516352096";
      Functions.TransactionID = Conversions.ToString(DateAndTime.Now.Year) + Conversions.ToString(DateAndTime.Now.Month) + Conversions.ToString(DateAndTime.Now.Day) + Conversions.ToString(DateAndTime.Now.Hour) + Conversions.ToString(DateAndTime.Now.Minute) + Conversions.ToString(DateAndTime.Now.Second) + Conversions.ToString(DateAndTime.Now.Millisecond);
      Functions.Encrypt = Functions.MD5_Hash(str1 + str2 + Functions.TransactionID);
    }

    public static string MD5_Hash(string SourceText)
    {
      string str;
      try
      {
        byte[] hash = new MD5CryptoServiceProvider().ComputeHash(Encoding.ASCII.GetBytes(SourceText));
        StringBuilder stringBuilder = new StringBuilder(checked ((int) Math.Round(unchecked ((double) checked (hash.Length * 2) + (double) hash.Length / 8.0))));
        int num = checked (hash.Length - 1);
        int startIndex = 0;
        while (startIndex <= num)
        {
          stringBuilder.Append(BitConverter.ToString(hash, startIndex, 1));
          checked { ++startIndex; }
        }
        str = stringBuilder.ToString().TrimEnd(' ').ToLower();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        str = "0";
        ProjectData.ClearProjectError();
      }
      return str;
    }

    public static void MakeTree()
    {
      int num1;
      int num2;
      try
      {
label_2:
        ProjectData.ClearProjectError();
        num1 = -2;
label_3:
        int num3 = 2;
        MyProject.Forms.SAPForm.TreeSAP.Nodes.Clear();
label_4:
        num3 = 3;
        if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Name, "", false) <= 0U)
          goto label_54;
label_5:
        num3 = 4;
        MyProject.Forms.SAPForm.TreeSAP.Nodes.Add("Project", SAP_Module.Proj.Name, 0, 4);
label_6:
        num3 = 5;
        if ((uint) SAP_Module.Proj.NoOfDwells <= 0U)
          goto label_50;
label_7:
        num3 = 6;
        int num4 = checked (SAP_Module.Proj.NoOfDwells - 1);
        int index = 0;
        goto label_46;
label_8:
        num3 = 7;
        SAP_Module.Proj.Dwellings[index] = Functions.CopyDwelling(SAP_Module.Proj.Dwellings[index]);
label_9:
        num3 = 8;
        if (!SAP_Module.Proj.Dwellings[index].Validation.Property_Check)
          goto label_11;
label_10:
        num3 = 9;
        MyProject.Forms.SAPForm.TreeSAP.Nodes[0].Nodes.Add(Conversion.Str((object) index), SAP_Module.Proj.Dwellings[index].Name, 8, 4);
        goto label_13;
label_11:
        num3 = 11;
        MyProject.Forms.SAPForm.TreeSAP.Nodes[0].Nodes.Add(Conversion.Str((object) index), SAP_Module.Proj.Dwellings[index].Name, 2, 4);
label_12:
label_13:
        num3 = 13;
        if (!SAP_Module.Proj.Dwellings[index].Validation.Dims_Check)
          goto label_15;
label_14:
        num3 = 14;
        MyProject.Forms.SAPForm.TreeSAP.Nodes[0].Nodes[index].Nodes.Add(Conversion.Str((object) index), "Dimensions", 6, 4);
        goto label_17;
label_15:
        num3 = 16;
        MyProject.Forms.SAPForm.TreeSAP.Nodes[0].Nodes[index].Nodes.Add(Conversion.Str((object) index), "Dimensions", 7, 4);
label_16:
label_17:
        num3 = 18;
        if (!SAP_Module.Proj.Dwellings[index].Validation.Opaque_Check)
          goto label_19;
label_18:
        num3 = 19;
        MyProject.Forms.SAPForm.TreeSAP.Nodes[0].Nodes[index].Nodes.Add(Conversion.Str((object) index), "Opaque Elements", 6, 4);
        goto label_21;
label_19:
        num3 = 21;
        MyProject.Forms.SAPForm.TreeSAP.Nodes[0].Nodes[index].Nodes.Add(Conversion.Str((object) index), "Opaque Elements", 7, 4);
label_20:
label_21:
        num3 = 23;
        if (!SAP_Module.Proj.Dwellings[index].Validation.Openings_Check)
          goto label_23;
label_22:
        num3 = 24;
        MyProject.Forms.SAPForm.TreeSAP.Nodes[0].Nodes[index].Nodes.Add(Conversion.Str((object) index), "Openings", 6, 4);
        goto label_25;
label_23:
        num3 = 26;
        MyProject.Forms.SAPForm.TreeSAP.Nodes[0].Nodes[index].Nodes.Add(Conversion.Str((object) index), "Openings", 7, 4);
label_24:
label_25:
        num3 = 28;
        if (!SAP_Module.Proj.Dwellings[index].Validation.Ventilation_Check)
          goto label_27;
label_26:
        num3 = 29;
        MyProject.Forms.SAPForm.TreeSAP.Nodes[0].Nodes[index].Nodes.Add(Conversion.Str((object) index), "Ventilation", 6, 4);
        goto label_29;
label_27:
        num3 = 31;
        MyProject.Forms.SAPForm.TreeSAP.Nodes[0].Nodes[index].Nodes.Add(Conversion.Str((object) index), "Ventilation", 7, 4);
label_28:
label_29:
        num3 = 33;
        if (!SAP_Module.Proj.Dwellings[index].Validation.Heating_Check)
          goto label_31;
label_30:
        num3 = 34;
        MyProject.Forms.SAPForm.TreeSAP.Nodes[0].Nodes[index].Nodes.Add(Conversion.Str((object) index), "Heating", 6, 4);
        goto label_33;
label_31:
        num3 = 36;
        MyProject.Forms.SAPForm.TreeSAP.Nodes[0].Nodes[index].Nodes.Add(Conversion.Str((object) index), "Heating", 7, 4);
label_32:
label_33:
        num3 = 38;
        if (!SAP_Module.Proj.Dwellings[index].Validation.WaterHeating_Check)
          goto label_35;
label_34:
        num3 = 39;
        MyProject.Forms.SAPForm.TreeSAP.Nodes[0].Nodes[index].Nodes.Add(Conversion.Str((object) index), "Water Heating", 6, 4);
        goto label_37;
label_35:
        num3 = 41;
        MyProject.Forms.SAPForm.TreeSAP.Nodes[0].Nodes[index].Nodes.Add(Conversion.Str((object) index), "Water Heating", 7, 4);
label_36:
label_37:
        num3 = 43;
        if (!SAP_Module.Proj.Dwellings[index].Validation.RenewablesTech_Check)
          goto label_39;
label_38:
        num3 = 44;
        MyProject.Forms.SAPForm.TreeSAP.Nodes[0].Nodes[index].Nodes.Add(Conversion.Str((object) index), "Renewable Technology", 6, 4);
        goto label_41;
label_39:
        num3 = 46;
        MyProject.Forms.SAPForm.TreeSAP.Nodes[0].Nodes[index].Nodes.Add(Conversion.Str((object) index), "Renewable Technology", 7, 4);
label_40:
label_41:
        num3 = 48;
        if (!SAP_Module.Proj.Dwellings[index].Validation.OverHeating_Check)
          goto label_43;
label_42:
        num3 = 49;
        MyProject.Forms.SAPForm.TreeSAP.Nodes[0].Nodes[index].Nodes.Add(Conversion.Str((object) index), "Overheating", 6, 4);
        goto label_45;
label_43:
        num3 = 51;
        MyProject.Forms.SAPForm.TreeSAP.Nodes[0].Nodes[index].Nodes.Add(Conversion.Str((object) index), "Overheating", 7, 4);
label_44:
label_45:
        num3 = 53;
        checked { ++index; }
label_46:
        if (index <= num4)
          goto label_8;
label_47:
        num3 = 54;
        MyProject.Forms.SAPForm.TreeSAP.Nodes[0].Expand();
label_48:
        num3 = 55;
        MyProject.Forms.SAPForm.TreeSAP.Nodes[0].Nodes[SAP_Module.CurrDwelling].Expand();
label_49:
label_50:
label_51:
        num3 = 57;
        MyProject.Forms.SAPForm.SplitContainer1.Panel1Collapsed = false;
label_52:
        num3 = 58;
        MyProject.Forms.SAPForm.SplitContainer1.SplitterDistance = 200;
label_53:
        num3 = 59;
        Functions.Updatelabel();
        goto label_57;
label_54:
        num3 = 61;
        MyProject.Forms.SAPForm.SplitContainer1.Panel1Collapsed = true;
label_55:
        num3 = 62;
        MyProject.Forms.SAPForm.lblDetails.Text = "";
label_56:
label_57:
        num3 = 64;
        PDFFunctions.Current_View = 0;
        goto label_64;
label_59:
        num2 = num3;
        switch (num1 > -2 ? num1 : 1)
        {
          case 1:
            int num5 = num2 + 1;
            num2 = 0;
            switch (num5)
            {
              case 1:
                goto label_2;
              case 2:
                goto label_3;
              case 3:
                goto label_4;
              case 4:
                goto label_5;
              case 5:
                goto label_6;
              case 6:
                goto label_7;
              case 7:
                goto label_8;
              case 8:
                goto label_9;
              case 9:
                goto label_10;
              case 10:
              case 13:
                goto label_13;
              case 11:
                goto label_11;
              case 12:
                goto label_12;
              case 14:
                goto label_14;
              case 15:
              case 18:
                goto label_17;
              case 16:
                goto label_15;
              case 17:
                goto label_16;
              case 19:
                goto label_18;
              case 20:
              case 23:
                goto label_21;
              case 21:
                goto label_19;
              case 22:
                goto label_20;
              case 24:
                goto label_22;
              case 25:
              case 28:
                goto label_25;
              case 26:
                goto label_23;
              case 27:
                goto label_24;
              case 29:
                goto label_26;
              case 30:
              case 33:
                goto label_29;
              case 31:
                goto label_27;
              case 32:
                goto label_28;
              case 34:
                goto label_30;
              case 35:
              case 38:
                goto label_33;
              case 36:
                goto label_31;
              case 37:
                goto label_32;
              case 39:
                goto label_34;
              case 40:
              case 43:
                goto label_37;
              case 41:
                goto label_35;
              case 42:
                goto label_36;
              case 44:
                goto label_38;
              case 45:
              case 48:
                goto label_41;
              case 46:
                goto label_39;
              case 47:
                goto label_40;
              case 49:
                goto label_42;
              case 50:
              case 53:
                goto label_45;
              case 51:
                goto label_43;
              case 52:
                goto label_44;
              case 54:
                goto label_47;
              case 55:
                goto label_48;
              case 56:
                goto label_49;
              case 57:
                goto label_51;
              case 58:
                goto label_52;
              case 59:
                goto label_53;
              case 60:
              case 64:
                goto label_57;
              case 61:
                goto label_54;
              case 62:
                goto label_55;
              case 63:
                goto label_56;
              case 65:
                goto label_64;
            }
            break;
        }
      }
      catch (Exception ex) when (ex is Exception & (uint) num1 > 0U & num2 == 0)
      {
        ProjectData.SetProjectError(ex);
        goto label_59;
      }
      throw ProjectData.CreateProjectError(-2146828237);
label_64:
      if (num2 == 0)
        return;
      ProjectData.ClearProjectError();
    }

    public static void Updatelabel()
    {
      try
      {
        if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.View, "Project Details", false) > 0U)
        {
          if ((uint) SAP_Module.Proj.NoOfDwells > 0U)
          {
            MyProject.Forms.SAPForm.lblDetails.Text = "Project: " + SAP_Module.Proj.Name + " -- Dwelling: " + SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Name + " -- " + SAP_Module.View;
            MyProject.Forms.SAPForm.ToolTip1.ToolTipTitle = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Name;
            if (string.IsNullOrEmpty(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Comments))
              MyProject.Forms.SAPForm.ToolTip1.SetToolTip((Control) MyProject.Forms.SAPForm.lblDetails, "No notes recorded");
            else
              MyProject.Forms.SAPForm.ToolTip1.SetToolTip((Control) MyProject.Forms.SAPForm.lblDetails, SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Comments);
          }
          else
          {
            MyProject.Forms.SAPForm.lblDetails.Text = "Project: " + SAP_Module.Proj.Name;
            MyProject.Forms.SAPForm.ToolTip1.ToolTipTitle = SAP_Module.Proj.Name;
            if (string.IsNullOrEmpty(SAP_Module.Proj.Comments))
              MyProject.Forms.SAPForm.ToolTip1.SetToolTip((Control) MyProject.Forms.SAPForm.lblDetails, "No notes recorded");
            else
              MyProject.Forms.SAPForm.ToolTip1.SetToolTip((Control) MyProject.Forms.SAPForm.lblDetails, SAP_Module.Proj.Comments);
          }
        }
        else
        {
          MyProject.Forms.SAPForm.lblDetails.Text = "Project: " + SAP_Module.Proj.Name;
          MyProject.Forms.SAPForm.ToolTip1.ToolTipTitle = SAP_Module.Proj.Name;
          if (string.IsNullOrEmpty(SAP_Module.Proj.Comments))
            MyProject.Forms.SAPForm.ToolTip1.SetToolTip((Control) MyProject.Forms.SAPForm.lblDetails, "No notes recorded");
          else
            MyProject.Forms.SAPForm.ToolTip1.SetToolTip((Control) MyProject.Forms.SAPForm.lblDetails, SAP_Module.Proj.Comments);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      try
      {
        MyProject.Forms.SAPForm.lblDetails.Cursor = Cursors.Hand;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    public static bool SaveFile(SAP_Module.Project strData, string FullPath)
    {
      FileStream serializationStream = File.Open(FullPath, FileMode.OpenOrCreate);
      BinaryFormatter binaryFormatter = new BinaryFormatter();
      bool flag;
      try
      {
        binaryFormatter.Serialize((Stream) serializationStream, (object) strData);
        serializationStream.Close();
        flag = true;
        if (PDFFunctions.Draft_PDF)
          MyProject.Forms.Saved.Show();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) Information.Err().Description);
        flag = false;
        ProjectData.ClearProjectError();
      }
      return flag;
    }

    public static SAP_Module.Project GetFileContents(string FullPath)
    {
      SAP_Module.Project fileContents = new SAP_Module.Project();
      try
      {
        FileStream serializationStream = File.Open(FullPath, FileMode.Open);
        fileContents = (SAP_Module.Project) new BinaryFormatter().Deserialize((Stream) serializationStream);
        serializationStream.Close();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) Information.Err().Description);
        ProjectData.ClearProjectError();
      }
      return fileContents;
    }

    public static float Get_Table6e_UValue(
      string Type,
      string Frame,
      string GAP,
      string Opening,
      string Thermal)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Type, "", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Frame, "", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(GAP, "", false) == 0)
      {
        if (!(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Type, "Single-glazed", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Type, "Secondary glazing", false) == 0))
          return 0.0f;
        GAP = "6mm, 12mm, 16mm or more";
      }
      float table6eUvalue;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Type, "Secondary glazing", false) == 0)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Frame, "Metal, thermal break", false) == 0)
        {
          table6eUvalue = 2.7f;
          string Left = Thermal;
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "4mm", false) != 0)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "8mm", false) != 0)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "12mm", false) != 0)
              {
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "20mm", false) != 0)
                {
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "32mm", false) == 0)
                    table6eUvalue -= 0.7f;
                }
                else
                  table6eUvalue -= 0.6f;
              }
              else
                table6eUvalue -= 0.5f;
            }
            else
              table6eUvalue -= 0.4f;
          }
          else
            table6eUvalue -= 0.3f;
        }
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Frame, "Metal", false) == 0)
          table6eUvalue = 2.7f;
      }
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Frame, "Metal, thermal break", false) == 0)
        Frame = "Metal";
      PCDF.Table6e table6e;
      try
      {
        table6e = !(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Type, "Secondary glazing", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Type, "Single-glazed", false) == 0) ? SAP_Module.PCDFData.Table6es.Where<PCDF.Table6e>((Func<PCDF.Table6e, bool>) (b => b.Type.Equals(Type) & b.Frame.ToUpper().Contains(Frame.ToUpper()) & b.GAP.Equals(Microsoft.VisualBasic.Strings.Trim(GAP)))).SingleOrDefault<PCDF.Table6e>() : SAP_Module.PCDFData.Table6es.Where<PCDF.Table6e>((Func<PCDF.Table6e, bool>) (b => b.Type.Equals(Type) & b.Frame.ToUpper().Contains(Frame.ToUpper()))).SingleOrDefault<PCDF.Table6e>();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      if (table6e != null)
      {
        table6eUvalue = (float) Conversion.Val(table6e.UValue);
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Opening, "Roof Window", false) == 0)
        {
          if (Type.Contains("Single"))
            table6eUvalue += 0.5f;
          if (Type.Contains("double") | Type.Contains("secondary"))
            table6eUvalue += 0.3f;
          if (Type.Contains("triple"))
            table6eUvalue += 0.2f;
        }
        if (Frame.Contains("Metal"))
        {
          string str = Thermal;
          // ISSUE: reference to a compiler-generated method
          switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(str))
          {
            case 333502473:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "8mm", false) == 0)
              {
                table6eUvalue -= 0.1f;
                goto default;
              }
              else
                goto default;
            case 473775746:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "No thermal break", false) == 0)
                break;
              goto default;
            case 536439224:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "12mm", false) == 0)
              {
                table6eUvalue -= 0.2f;
                goto default;
              }
              else
                goto default;
            case 2166136261:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "", false) == 0)
                break;
              goto default;
            case 2186527966:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "32mm", false) == 0)
              {
                table6eUvalue -= 0.4f;
                goto default;
              }
              else
                goto default;
            case 2560045537:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "20mm", false) == 0)
              {
                table6eUvalue -= 0.3f;
                goto default;
              }
              else
                goto default;
            case 3632641573:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "4mm", false) == 0)
                goto default;
              else
                goto default;
            default:
label_47:
              goto label_48;
          }
          table6eUvalue += 0.3f;
          goto label_47;
        }
      }
label_48:
      return table6eUvalue;
    }

    public static float Check_GValue(string GlazingType)
    {
      float num;
      if (GlazingType.Contains("Single"))
        num = 0.85f;
      else if (GlazingType.Contains("Secondary"))
        num = 0.76f;
      else if (GlazingType.Contains("double-glazed"))
        num = !GlazingType.Contains("hard") ? (!GlazingType.Contains("soft") ? 0.76f : 0.63f) : 0.72f;
      else if (GlazingType.Contains("triple-glazed"))
        num = !GlazingType.Contains("hard") ? (!GlazingType.Contains("soft") ? 0.68f : 0.57f) : 0.64f;
      return num;
    }

    public static string RestrictValue(TextBox Texty, int Limit)
    {
      string str;
      if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Texty.Text, "", false) > 0U)
        str = Conversion.Val(Texty.Text) <= (double) Limit ? (Conversion.Val(Texty.Text) >= 0.0 ? (Conversion.Val(Texty.Text) != 0.0 ? Texty.Text : Conversions.ToString(0)) : Conversions.ToString(0)) : Conversions.ToString(Limit);
      return str;
    }

    public static DataRow[] VentilationDataCheck()
    {
      DataRow[] dataRowArray;
      return dataRowArray;
    }

    public static void CalculateNow()
    {
      Functions.SetCalcVersion();
      SAP_Module.CalcRound = false;
      if (!Validation.LodgementStatusCheck(SAP_Module.CurrDwelling))
      {
        MyProject.Forms.SAPForm.DwellingDetails.Panel2Collapsed = true;
        MyProject.Forms.SAPForm.SplitContainer2.Panel2Collapsed = true;
        MyProject.Forms.SAPForm.Button3.Visible = false;
        MyProject.Forms.SAPForm.lblDwellingDER.Visible = false;
        MyProject.Forms.SAPForm.txtDwellingDER.Visible = false;
        MyProject.Forms.SAPForm.Sep1.Visible = false;
        MyProject.Forms.SAPForm.lblDwellingTER.Visible = false;
        MyProject.Forms.SAPForm.txtDwellingTER.Visible = false;
        MyProject.Forms.SAPForm.txtTFEE.Visible = false;
        MyProject.Forms.SAPForm.lblDwellingTFEE.Visible = false;
        MyProject.Forms.SAPForm.lblDwellingFEE.Visible = false;
        MyProject.Forms.SAPForm.txtDwellingFEE.Visible = false;
        MyProject.Forms.SAPForm.Sep2.Visible = false;
        MyProject.Forms.SAPForm.cmdCompliance.Visible = false;
        MyProject.Forms.GenResults.Visible = false;
      }
      else
      {
        Functions.GetFabricDwelling();
        SAP_Module.CalculationFabric.IsFabricEfficiency = true;
        SAP_Module.CalculationFabric.Dwelling = SAP_Module.FabricDwelling;
        SAP_Module.Calculation2012Regional.IsRHICalc = true;
        SAP_Module.Calculation2012Regional.IsHeatDemand = true;
        double yvalue = (double) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.YValue;
        if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Imported09 && !SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.ManualHtb && SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].ImportedYvalue > 0.0)
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.YValue = (float) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].ImportedYvalue;
        SAP_Module.Calculation2012Regional.Dwelling = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling];
        SAP_Module.Calculation2012.Dwelling = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling];
        if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Imported09 & !SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.ManualHtb)
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.YValue = (float) yvalue;
        MyProject.Forms.SAPForm.PG1.SelectedObject = (object) SAP_Module.Calculation2012.Calculation;
        MyProject.Forms.SAPForm.Button3.Visible = true;
        Functions.GetDERDwelling();
        Functions.GetTERDwelling();
        int roundFigure = SAP_Module.RoundFigure;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Overheat, "Yes", false) == 0)
          SAP_Module.OverHeat.Dwelling = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling];
        SAP_Module.CalcRound = false;
        MyProject.Forms.SAPForm.Button3.Visible = SAP_Module.Calculation2012.CalcComplete;
        MyProject.Forms.SAPForm.lblDwellingDER.Visible = SAP_Module.Calculation2012.CalcComplete;
        MyProject.Forms.SAPForm.cmdCompliance.Visible = SAP_Module.Calculation2012.CalcComplete;
        MyProject.Forms.SAPForm.txtDwellingDER.Visible = SAP_Module.Calculation2012.CalcComplete;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Address.Country, "England", false) == 0)
          MyProject.Forms.SAPForm.lblDwellingFEE.Visible = SAP_Module.Calculation2012.CalcComplete;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Address.Country, "England", false) == 0)
          MyProject.Forms.SAPForm.txtDwellingFEE.Visible = SAP_Module.Calculation2012.CalcComplete;
        MyProject.Forms.SAPForm.Sep1.Visible = SAP_Module.Calculation2012.CalcComplete;
        MyProject.Forms.SAPForm.lblDwellingTER.Visible = SAP_Module.Calculation2012.CalcComplete;
        MyProject.Forms.SAPForm.txtDwellingTER.Visible = SAP_Module.Calculation2012.CalcComplete;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Address.Country, "England", false) == 0)
          MyProject.Forms.SAPForm.lblDwellingTFEE.Visible = SAP_Module.Calculation2012.CalcComplete;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Address.Country, "England", false) == 0)
          MyProject.Forms.SAPForm.txtTFEE.Visible = SAP_Module.Calculation2012.CalcComplete;
        MyProject.Forms.SAPForm.Sep2.Visible = SAP_Module.Calculation2012.CalcComplete;
        MyProject.Forms.SAPForm.DwellingDetails.Panel2Collapsed = !SAP_Module.Calculation2012.CalcComplete;
        if (!SAP_Module.Calculation2012.CalcComplete)
        {
          MyProject.Forms.SAPForm.SplitContainer2.Panel2Collapsed = !SAP_Module.Calculation2012.CalcComplete;
        }
        else
        {
          SAP_Module.CalcAssessmentLZCPlease = true;
          SAP_Module.CalcualtionDER2012.DTER = true;
          SAP_Module.CalcualtionDER2012.Dwelling = SAP_Module.DERDwelling;
          MyProject.Forms.SAPForm.PG2.SelectedObject = (object) SAP_Module.CalcualtionDER2012.Calculation;
          SAP_Module.CalcualtionTER2012.DTER = true;
          SAP_Module.CalcualtionTER2012._TER = true;
          Functions.GetTERDwelling();
          Calc2012 calc2012_1 = new Calc2012()
          {
            DTER = true
          };
          calc2012_1.SETPCDF(SAP_Module.PCDFData);
          calc2012_1.Dwelling = SAP_Module.TERDwelling;
          SAP_Module.CalcualtionTER2012 = calc2012_1;
          SAP_Module.CalcualtionTER2012.Dwelling = SAP_Module.TERDwelling;
          MyProject.Forms.SAPForm.PG3.SelectedObject = (object) SAP_Module.CalcualtionTER2012.Calculation;
          SAP_Module.CalcRound = false;
          MyProject.Forms.SAPForm.txtDwellingTER.Text = Conversions.ToString(Functions.TER());
          SAP_Module.CalcRound = true;
          SAP_Module.RoundFigure = 2;
          if (SAP_Module.CalcualtionDER2012.Calculation.CO2_Emissions_12a.Box273 == 0.0)
            MyProject.Forms.SAPForm.txtDwellingDER.Text = Conversions.ToString(Math.Round(SAP_Module.CalcualtionDER2012.Calculation.CO2_Emissions_12b.Box384, 2));
          else
            MyProject.Forms.SAPForm.txtDwellingDER.Text = Conversions.ToString(Math.Round(SAP_Module.CalcualtionDER2012.Calculation.CO2_Emissions_12a.Box273, 2));
          MyProject.Forms.SAPForm.txtDwellingFEE.Text = Conversions.ToString(Math.Round(SAP_Module.CalculationFabric.Calculation.Fabric_Energy_Efficiency.Box109, 1));
          Calc2012 calc2012_2 = new Calc2012();
          calc2012_2.SETPCDF(SAP_Module.PCDFData);
          calc2012_2.IsFabricEfficiency = true;
          SAP_Module.CalcRound = false;
          calc2012_2.Dwelling = Functions.GetFEEDwelling(ref SAP_Module.TERDwelling);
          SAP_Module.CalcRound = true;
          MyProject.Forms.SAPForm.txtTFEE.Text = Conversions.ToString(Math.Round(1.15 * calc2012_2.Calculation.Fabric_Energy_Efficiency.Box109, 1));
          MyProject.Forms.SAPForm.PGTFEE.SelectedObject = (object) calc2012_2.Calculation;
          Improvements.GetImprovements(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling]);
          MyProject.Forms.SAPForm.PG7.SelectedObject = (object) SAP_Module.CalculationFabric.Calculation;
          MyProject.Forms.SAPForm.PG4.SelectedObject = (object) SAP_Module.CalculationImprove2012.Calculation;
          MyProject.Forms.SAPForm.PGEPCCosts.SelectedObject = (object) SAP_Module.Calculation2012Regional.Calculation;
          MyProject.Forms.SAPForm.PG6.SelectedObject = (object) SAP_Module.Improve;
          MyProject.Forms.SAPForm.PGHeat.SelectedObject = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Overheat, "Yes", false) != 0 ? (object) null : (object) SAP_Module.OverHeat;
          SAP_Module.RoundFigure = roundFigure;
        }
        SAP_Module.EcoFormShow.lblCosts.Text = Conversions.ToString(SAP_Module.Calculation2012Regional.Calculation.Actual_costs_10a.Box255 + SAP_Module.Calculation2012Regional.Calculation.Actual_costs_10b.Box355);
        SAP_Module.EcoFormShow.lblCO2.Text = Conversions.ToString(Math.Round(SAP_Module.Calculation2012Regional.Calculation.CO2_Emissions_12a.Box272 + SAP_Module.Calculation2012Regional.Calculation.CO2_Emissions_12b.Box383, 3));
        if (!Compliance.CheckCompliance(SAP_Module.CurrDwelling))
          MyProject.Forms.SAPForm.cmdCompliance.BackColor = Color.DarkRed;
        else
          MyProject.Forms.SAPForm.cmdCompliance.BackColor = Color.Green;
        if (MyProject.Forms.SAPForm.SplitContainer2.Panel2Collapsed)
        {
          if (!SAP_Module.ShowBar & SAP_Module.Calculation2012.CalcComplete)
          {
            MyProject.Forms.SAPForm.SplitContainer2.Panel2Collapsed = false;
            SAP_Module.ShowBar = true;
          }
          MyProject.Forms.SAPForm.Button3.Text = "<";
        }
        else
          MyProject.Forms.SAPForm.Button3.Text = ">";
        Functions.FillSummary();
      }
    }

    public static SAP_Module.Dwelling GetFEEDwelling(ref SAP_Module.Dwelling _dwelling)
    {
      SAP_Module.Dwelling feeDwelling = Functions.CopyDwelling(_dwelling);
      int num1 = checked (feeDwelling.Storeys - 1);
      int index1 = 0;
      float num2;
      while (index1 <= num1)
      {
        num2 += feeDwelling.Dims[index1].Area;
        checked { ++index1; }
      }
      feeDwelling.Ventilation.MechVent = "Natural ventilation";
      float num3 = num2;
      if ((double) num3 <= 70.0)
      {
        feeDwelling.Ventilation.Fans = 2;
      }
      else
      {
        int num4 = (double) num3 < 70.0 ? 0 : ((double) num3 <= 100.0 ? 1 : 0);
        feeDwelling.Ventilation.Fans = num4 == 0 ? 4 : 3;
      }
      feeDwelling.Ventilation.Vents = 0;
      feeDwelling.LowEnergyLight = 100f;
      if (feeDwelling.Windows != null)
      {
        SAP_Module.Window[] windows = feeDwelling.Windows;
        int index2 = 0;
        while (index2 < windows.Length)
        {
          SAP_Module.Window window = windows[index2];
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(window.Overshading, "Very Little", false) == 0)
            window.Overshading = "Average or unknown";
          checked { ++index2; }
        }
      }
      if (feeDwelling.RoofLights != null)
      {
        SAP_Module.RoofLight[] roofLights = feeDwelling.RoofLights;
        int index3 = 0;
        while (index3 < roofLights.Length)
        {
          SAP_Module.RoofLight roofLight = roofLights[index3];
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(roofLight.Overshading, "Very Little", false) == 0)
            roofLight.Overshading = "Average or unknown";
          checked { ++index3; }
        }
      }
      feeDwelling.Cooling.Include = true;
      return feeDwelling;
    }

    public static void CalculateLodge()
    {
      if ((uint) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].SecHeating.SAPTableCode > 0U & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].SecHeating.MHType, "", false) == 0)
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].SecHeating.SAPTableCode = 0;
      Functions.GetFabricDwelling();
      SAP_Module.CalculationFabric.IsFabricEfficiency = true;
      SAP_Module.CalculationFabric.Dwelling = SAP_Module.FabricDwelling;
      SAP_Module.Calculation2012.Dwelling = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling];
      Functions.GetDERDwelling();
      Functions.GetTERDwelling();
      int roundFigure = SAP_Module.RoundFigure;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Overheat, "Yes", false) == 0)
        SAP_Module.OverHeat.Dwelling = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling];
      if (!SAP_Module.Calculation2012.CalcComplete)
        return;
      SAP_Module.CalcAssessmentLZCPlease = true;
      SAP_Module.CalcualtionDER2012.DTER = true;
      SAP_Module.CalcualtionDER2012.Dwelling = SAP_Module.DERDwelling;
      SAP_Module.CalcualtionTER2012.DTER = true;
      SAP_Module.CalcualtionTER2012._TER = true;
      SAP_Module.CalcualtionTER2012.Dwelling = SAP_Module.TERDwelling;
      Improvements.GetImprovements(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling]);
    }

    public static void CalculateNowDERTER()
    {
      Functions.SetCalcVersion();
      try
      {
        SAP_Module.Calculation2012.Dwelling = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling];
        Functions.GetDERDwelling();
        Functions.GetTERDwelling();
        int roundFigure = SAP_Module.RoundFigure;
        SAP_Module.CalcAssessmentLZCPlease = true;
        SAP_Module.CalcualtionDER2012.Dwelling = SAP_Module.DERDwelling;
        SAP_Module.CalcualtionTER2012.Dwelling = SAP_Module.TERDwelling;
        SAP_Module.CalcRound = false;
        MyProject.Forms.SAPForm.txtDwellingTER.Text = Conversions.ToString(Functions.TER());
        SAP_Module.CalcRound = true;
        SAP_Module.RoundFigure = 2;
        if (SAP_Module.CalcualtionDER2012.Calculation.CO2_Emissions_12a.Box273 == 0.0)
          MyProject.Forms.SAPForm.txtDwellingDER.Text = Conversions.ToString(SAP_Module.CalcualtionDER2012.Calculation.CO2_Emissions_12b.Box384);
        else
          MyProject.Forms.SAPForm.txtDwellingDER.Text = Conversions.ToString(SAP_Module.CalcualtionDER2012.Calculation.CO2_Emissions_12a.Box273);
        SAP_Module.RoundFigure = roundFigure;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    public static void FillSummary()
    {
      Font font = new Font("Tahoma", 8f, FontStyle.Bold);
      DataGridView dtaSummary = MyProject.Forms.SAPForm.dtaSummary;
      if (dtaSummary.ColumnCount == 0)
      {
        dtaSummary.Columns.Add(Conversions.ToString(1), Conversions.ToString(1));
        dtaSummary.Columns.Add(Conversions.ToString(2), Conversions.ToString(2));
      }
      dtaSummary.Rows.Clear();
      dtaSummary.Rows.Add(13);
      dtaSummary[0, 0].Value = (object) "TER";
      dtaSummary[0, 1].Value = (object) "DER";
      dtaSummary[0, 2].Value = (object) "SAP Result";
      dtaSummary[0, 3].Value = (object) "EI rating";
      dtaSummary[0, 4].Value = (object) "EI Value";
      dtaSummary[0, 5].Value = (object) "HLP";
      dtaSummary[0, 6].Value = (object) "Overheating Risk";
      dtaSummary[0, 7].Value = (object) "Smoke Control Area";
      dtaSummary[0, 8].Value = (object) "Area weighted floor U-value";
      dtaSummary[0, 9].Value = (object) "Area weighted wall U-value";
      dtaSummary[0, 10].Value = (object) "Area weighted roof U-value";
      dtaSummary[0, 11].Value = (object) "Area weighted window U-value";
      dtaSummary[0, 12].Value = (object) "Windows description";
      int num1 = checked (dtaSummary.RowCount - 1);
      int rowIndex = 0;
      while (rowIndex <= num1)
      {
        dtaSummary[0, rowIndex].Style.Font = font;
        dtaSummary[0, rowIndex].Style.BackColor = Color.LightSlateGray;
        dtaSummary[0, rowIndex].Style.SelectionBackColor = Color.LightSlateGray;
        checked { ++rowIndex; }
      }
      int roundFigure = SAP_Module.RoundFigure;
      SAP_Module.RoundFigure = 2;
      dtaSummary[1, 0].Value = !MyProject.Forms.SAPForm.CheckHTB() ? (object) Functions.TER() : (object) null;
      float num2 = (float) Functions.TER();
      float num3;
      if (SAP_Module.CalcualtionDER2012.Calculation.CO2_Emissions_12a.Box273 == 0.0)
      {
        num3 = (float) SAP_Module.CalcualtionDER2012.Calculation.CO2_Emissions_12b.Box384;
        dtaSummary[1, 4].Value = (object) SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box385;
      }
      else
      {
        num3 = (float) SAP_Module.CalcualtionDER2012.Calculation.CO2_Emissions_12a.Box273;
        dtaSummary[1, 4].Value = (object) SAP_Module.Calculation2012.Calculation.CO2_Emissions_12a.EIValue;
      }
      float num4 = (float) Math.Round((double) num3, 2);
      if ((double) num4 == (double) num2)
      {
        double Expression = 0.0;
        dtaSummary[1, 1].Value = (object) (Conversions.ToString(num4) + " - Pass\r\n" + Microsoft.VisualBasic.Strings.Format((object) Expression, "#0.0") + "% Reduction");
        dtaSummary[1, 1].Style.BackColor = Color.Green;
        dtaSummary[1, 1].Style.SelectionBackColor = Color.Green;
        dtaSummary[1, 1].Style.ForeColor = Color.White;
      }
      else if ((double) num4 > (double) num2)
      {
        double Expression = (double) num4 >= 0.0 ? 100.0 * (1.0 - (double) num4 / (double) num2) : 100.0 * (1.0 - (double) num4 / (double) num2);
        dtaSummary.Rows[1].Height = 30;
        dtaSummary[1, 1].Style.WrapMode = DataGridViewTriState.True;
        dtaSummary[1, 1].Value = Expression >= 0.0 ? (object) (Conversions.ToString(num4) + " - Fail\r\n" + Microsoft.VisualBasic.Strings.Format((object) Expression, "#0.0") + "% Reduction") : (object) (Conversions.ToString(num4) + " - Fail\r\n" + Microsoft.VisualBasic.Strings.Mid(Expression.ToString(), 1, 5) + "% Reduction");
        dtaSummary[1, 1].Style.BackColor = Color.DarkRed;
        dtaSummary[1, 1].Style.SelectionBackColor = Color.DarkRed;
        dtaSummary[1, 1].Style.ForeColor = Color.White;
      }
      else
      {
        double Expression = (double) num4 >= 0.0 ? 100.0 * (1.0 - (double) num4 / (double) num2) : 100.0 * (1.0 - (double) num4 / (double) num2);
        dtaSummary.Rows[1].Height = 30;
        dtaSummary[1, 1].Style.WrapMode = DataGridViewTriState.True;
        dtaSummary[1, 1].Value = (object) (Conversions.ToString(num4) + " - Pass\r\n" + Microsoft.VisualBasic.Strings.Format((object) Expression, "#0.0") + "% Reduction");
        dtaSummary[1, 1].Style.BackColor = Color.Green;
        dtaSummary[1, 1].Style.SelectionBackColor = Color.Green;
        dtaSummary[1, 1].Style.ForeColor = Color.White;
      }
      if (SAP_Module.Calculation2012.Calculation.SAP_rating_11a.Box258 == 0.0)
        dtaSummary[1, 2].Value = (object) (SAP_Module.Calculation2012.Calculation.SAP_rating_11b.SAPBand + " " + Conversions.ToString(SAP_Module.Calculation2012.Calculation.SAP_rating_11b.SAPRating) + " (" + Conversions.ToString(SAP_Module.Calculation2012.Calculation.SAP_rating_11b.Box358) + ")");
      else
        dtaSummary[1, 2].Value = (object) (SAP_Module.Calculation2012.Calculation.SAP_rating_11a.SAPBand + " " + Conversions.ToString(SAP_Module.Calculation2012.Calculation.SAP_rating_11a.SAPRating) + " (" + Conversions.ToString(SAP_Module.Calculation2012.Calculation.SAP_rating_11a.Box258) + ")");
      dtaSummary[1, 3].Value = SAP_Module.Calculation2012.Calculation.SAP_rating_11a.Box258 == 0.0 ? (object) (SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.EIBand + " " + Conversions.ToString(Math.Round(SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.EIRating, 0))) : (object) (SAP_Module.Calculation2012.Calculation.CO2_Emissions_12a.EIBand + " " + Conversions.ToString(Math.Round(SAP_Module.Calculation2012.Calculation.CO2_Emissions_12a.EIValue, 0)));
      dtaSummary[1, 5].Value = (object) SAP_Module.Calculation2012.Calculation.HeatLoss.Box40;
      dtaSummary[1, 6].Value = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Overheat, "Yes", false) != 0 ? (object) "Not calculated" : (object) SAP_Module.OverHeat.AppendixP.Likelihood;
      dtaSummary[1, 7].Value = (object) Functions.CheckFuel();
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectNotEqual(dtaSummary[1, 6].Value, (object) "", false))
        MyProject.Forms.SAPForm.lblSmoke.Visible = true;
      else
        MyProject.Forms.SAPForm.lblSmoke.Visible = false;
      MyProject.Forms.SAPForm.lblSmoke.Text = Conversions.ToString(dtaSummary[1, 7].Value);
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectNotEqual(dtaSummary[1, 7].Value, (object) "", false))
      {
        dtaSummary[1, 7].Style.BackColor = Color.DarkRed;
        dtaSummary[1, 7].Style.SelectionBackColor = Color.DarkRed;
        MyProject.Forms.SAPForm.lblSmoke.ForeColor = Color.DarkRed;
        dtaSummary[1, 7].Style.ForeColor = Color.White;
      }
      else
      {
        dtaSummary[1, 7].Style.BackColor = Color.White;
        dtaSummary[1, 7].Style.SelectionBackColor = Color.White;
        MyProject.Forms.SAPForm.lblSmoke.ForeColor = Color.White;
        dtaSummary[1, 7].Style.ForeColor = Color.Black;
      }
      dtaSummary[1, 7].Style.WrapMode = DataGridViewTriState.True;
      dtaSummary.Rows[7].Height = 70;
      int num5 = 5;
      do
      {
        dtaSummary[0, num5].Style.WrapMode = DataGridViewTriState.True;
        if (num5 != 7)
          dtaSummary.Rows[num5].Height = checked ((int) Math.Round(unchecked (1.8 * (double) dtaSummary.Rows[num5].Height)));
        checked { ++num5; }
      }
      while (num5 <= 11);
      dtaSummary[1, 8].Value = (object) SAP_Module.Calculation2012._Add_Variable.Averages.Floor_U;
      dtaSummary[1, 9].Value = (object) SAP_Module.Calculation2012._Add_Variable.Averages.Wall_U;
      dtaSummary[1, 10].Value = (object) SAP_Module.Calculation2012._Add_Variable.Averages.Roof_U;
      dtaSummary[1, 11].Value = (object) SAP_Module.Calculation2012._Add_Variable.Averages.Window_U;
      dtaSummary[1, 12].Value = (object) SAP_Module.Calculation2012._Add_Variable.Averages.Description;
      dtaSummary[1, 12].Style.WrapMode = DataGridViewTriState.True;
      SAP_Module.RoundFigure = roundFigure;
      MyProject.Forms.SAPForm.dtaSummary.Rows[4].Visible = false;
    }

    private static string CheckFuel()
    {
      string Left1 = "";
      ref SAP_Module.Dwelling local = ref SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling];
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(local.SmokeArea, "Yes", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(local.SmokeArea, "Unknown", false) == 0)
      {
        string Left2 = Functions.CheckForSolidFuel(local.MainHeating.Fuel, local.MainHeating.SAPTableCode);
        if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left2, "", false) > 0U)
          Left1 = Left2;
        if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(local.SecHeating.Fuel, local.MainHeating.Fuel, false) > 0U)
        {
          string Left3 = Functions.CheckForSolidFuel(local.SecHeating.Fuel, local.SecHeating.SAPTableCode);
          if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left3, "", false) > 0U)
            Left1 = (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left1, "", false) <= 0U ? Left3 : Left1 + "\r\n" + Left3;
        }
        if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(local.Water.Fuel, local.MainHeating.Fuel, false) > 0U & (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(local.Water.Fuel, local.SecHeating.Fuel, false) > 0U)
        {
          string Left4 = Functions.CheckForSolidFuel(local.Water.Fuel, 0);
          if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left4, "", false) > 0U)
            Left1 = (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left1, "", false) <= 0U ? Left4 : Left1 + "\r\n" + Left4;
        }
      }
      else
        Left1 = "N/A";
      return Left1;
    }

    public static string CheckForSolidFuel(string Fuel, int HeatingType)
    {
      string Left = "";
      string str = Fuel;
      // ISSUE: reference to a compiler-generated method
      switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(str))
      {
        case 575487477:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "wood pellets (bulk supply in bags, for main heating)", false) == 0)
            goto label_14;
          else
            goto default;
        case 604697910:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "manufactured smokeless fuel", false) == 0)
          {
            Left = "Authorised smokeless fuel only";
            goto default;
          }
          else
            goto default;
        case 721524493:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "dual fuel appliance (mineral and wood)", false) == 0)
            break;
          goto default;
        case 857289046:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "house coal", false) == 0)
            break;
          goto default;
        case 1522447619:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "wood chips", false) == 0)
            goto label_14;
          else
            goto default;
        case 1946790875:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "wood logs", false) == 0)
          {
            int num = HeatingType;
            if (num == 631 || num == 632)
            {
              Left = "Not permitted";
              goto default;
            }
            else if (num >= 633 && num <= 636 || num >= 151 && num <= 161)
            {
              Left = "Exempted appliance only";
              goto default;
            }
            else
              goto default;
          }
          else
            goto default;
        case 2251322125:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "wood pellets (in bags, for secondary heating)", false) == 0)
            goto label_14;
          else
            goto default;
        default:
label_15:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].SmokeArea, "Unknown", false) == 0 && (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "", false) > 0U)
            Left += " if the dwelling is in a Smoke Control Area";
          return Left;
      }
      Left = "Not permitted";
      goto label_15;
label_14:
      Left = "Exempted appliance only";
      goto label_15;
    }

    private static void GetFabricDwelling()
    {
      try
      {
        SAP_Module.FabricDwelling = Functions.CopyDwelling(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling]);
        ref SAP_Module.Dwelling local = ref SAP_Module.FabricDwelling;
        local.Ventilation.MechVent = "Natural ventilation";
        float num1 = local.LivingArea / local.LivingFraction;
        local.Ventilation.Fans = (double) num1 > 70.0 ? ((double) num1 > 100.0 ? 4 : 3) : 2;
        local.Ventilation.Vents = 0;
        local.Water.SystemRef = 907;
        local.Water.FGHRS.Include = false;
        int num2 = checked (local.NoofWindows - 1);
        int index = 0;
        while (index <= num2)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(local.Windows[index].Overshading, "Very Little", false) == 0)
            local.Windows[index].Overshading = "Average or unknown";
          checked { ++index; }
        }
        string electricityTariff = local.MainHeating.ElectricityTariff;
        local.MainHeating = new SAP_Module.MainHeating();
        local.MainHeating.Fuel = "mains gas";
        local.MainHeating.InforSource = "SAP Tables";
        local.MainHeating.SAPTableCode = 102;
        local.MainHeating.MainEff = 78f;
        local.MainHeating.Emitter = "Systems with radiators";
        local.MainHeating.Controls = "Programmer, room thermostat and TRVs";
        local.MainHeating.ControlCode = 2106;
        local.MainHeating.Boiler.PumpHP = "No";
        local.MainHeating.Boiler.BILock = "Yes";
        local.MainHeating.Boiler.FlueType = "Room-sealed";
        local.MainHeating.Boiler.FanFlued = "Yes";
        local.MainHeating.Boiler.Description = "";
        local.MainHeating.Boiler.KeepHotFuel = "";
        local.MainHeating.BSubGroup = "";
        local.MainHeating.Compensator = "";
        local.MainHeating.ElectricityTariff = electricityTariff;
        local.MainHeating.BSubGroup = "Gas boilers (including LPG) 1998 or later";
        local.MainHeating.HGroup = "Central heating systems with radiators or underfloor heating";
        local.MainHeating.MHType = "Regular condensing with automatic ignition";
        local.MainHeating.SGroup = "Gas boilers and oil boilers";
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(local.Overshading, "Very Little", false) == 0)
          local.Overshading = "Average or unknown";
        local.Cooling.Include = true;
        local.Cooling.Cooled_Area = Conversions.ToString(local.LivingArea / local.LivingFraction);
        local.LowEnergyLight = 100f;
        local.IncludeMainHeating2 = false;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) ex.Message);
        ProjectData.ClearProjectError();
      }
    }

    private static void GetDERDwelling()
    {
      try
      {
        SAP_Module.DERDwelling = Functions.CopyDwelling(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling]);
        int num1 = checked (SAP_Module.DERDwelling.NoofWindows - 1);
        int index1 = 0;
        while (index1 <= num1)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.DERDwelling.Windows[index1].Overshading, "Very Little", false) == 0)
            SAP_Module.DERDwelling.Windows[index1].Overshading = "Average or unknown";
          checked { ++index1; }
        }
        int num2 = checked (SAP_Module.DERDwelling.NoofRoofLights - 1);
        int index2 = 0;
        while (index2 <= num2)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.DERDwelling.RoofLights[index2].Overshading, "Very Little", false) == 0)
            SAP_Module.DERDwelling.RoofLights[index2].Overshading = "Average or unknown";
          checked { ++index2; }
        }
        if ((double) SAP_Module.DERDwelling.LowEnergyLight < 30.0)
          SAP_Module.DERDwelling.LowEnergyLight = 30f;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Address.Country, "Scotland", false) != 0)
          return;
        if (SAP_Module.DERDwelling.ShelteredSides > 2)
          SAP_Module.DERDwelling.ShelteredSides = 0;
        if ((uint) SAP_Module.DERDwelling.SecHeating.SAPTableCode > 0U && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.DERDwelling.SecHeating.Fuel, "dual fuel appliance (mineral and wood)", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.DERDwelling.SecHeating.Fuel, "appliances able to use mineral oil or liquid biofuel", false) == 0)
          SAP_Module.DERDwelling.SecHeating.Fuel = "house coal";
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.DERDwelling.MainHeating.Fuel, "dual fuel appliance (mineral and wood)", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.DERDwelling.SecHeating.Fuel, "appliances able to use mineral oil or liquid biofuel", false) == 0)
        {
          SAP_Module.DERDwelling.MainHeating.Fuel = "house coal";
          SAP_Module.DERDwelling.Water.Fuel = "house coal";
        }
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.DERDwelling.MainHeating.Fuel, "B30K", false) == 0)
        {
          SAP_Module.DERDwelling.MainHeating.Fuel = "heating oil";
          if (SAP_Module.DERDwelling.Water.SystemRef == 901)
            SAP_Module.DERDwelling.Water.Fuel = SAP_Module.DERDwelling.MainHeating.Fuel;
        }
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.DERDwelling.MainHeating.Fuel, "heat from boilers – B30D", false) == 0)
        {
          SAP_Module.DERDwelling.MainHeating.Fuel = "heating oil";
          if (SAP_Module.DERDwelling.Water.SystemRef == 901)
            SAP_Module.DERDwelling.Water.Fuel = SAP_Module.DERDwelling.MainHeating.Fuel;
        }
        int sapTableCode = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SAPTableCode;
        if (sapTableCode >= 306 && sapTableCode <= 310 && SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.NoOfAdditionalHeatSources > 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.HeatSource1.Fuel, "heat from boilers – B30D", false) == 0)
            SAP_Module.DERDwelling.MainHeating.CommunityH.HeatSource1.Fuel = "heat from boilers - oil";
          if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.NoOfAdditionalHeatSources > 1 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.HeatSource2.Fuel, "heat from boilers – B30D", false) == 0)
            SAP_Module.DERDwelling.MainHeating.CommunityH.HeatSource2.Fuel = "heat from boilers - oil";
          if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.NoOfAdditionalHeatSources > 2 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.HeatSource3.Fuel, "heat from boilers – B30D", false) == 0)
            SAP_Module.DERDwelling.MainHeating.CommunityH.HeatSource3.Fuel = "heat from boilers - oil";
          if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.NoOfAdditionalHeatSources > 3 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.HeatSource4.Fuel, "heat from boilers – B30D", false) == 0)
            SAP_Module.DERDwelling.MainHeating.CommunityH.HeatSource4.Fuel = "heat from boilers - oil";
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) ex.Message);
        ProjectData.ClearProjectError();
      }
    }

    public static void GetDERDwelling_CSH(string Type)
    {
      SAP_Module.DERDwelling_CSH = Functions.CopyDwelling(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling]);
      try
      {
        if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SGroup.Contains("heat pumps") | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.HGroup, "Community heating schemes", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.HGroup, "Micro-Congeneration (Micro-CHP)", false) == 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Type, "Standard", false) == 0)
          {
            SAP_Module.DERDwelling_CSH.MainHeating = new SAP_Module.MainHeating();
            SAP_Module.DERDwelling_CSH.MainHeating.Fuel = "mains gas";
            SAP_Module.DERDwelling_CSH.MainHeating.InforSource = "Manufacturer Declaration";
            SAP_Module.DERDwelling_CSH.MainHeating.SGroup = "Gas boilers (including LPG) 1998 or later";
            SAP_Module.DERDwelling_CSH.MainHeating.HGroup = "Central heating systems with radiators or underfloor heating";
            SAP_Module.DERDwelling_CSH.MainHeating.MHType = "Regular condensing with automatic ignition";
            SAP_Module.DERDwelling_CSH.MainHeating.Emitter = "Systems with radiators";
            SAP_Module.DERDwelling_CSH.MainHeating.Controls = "Programmer, room thermostat and TRVs";
            SAP_Module.DERDwelling_CSH.MainHeating.ControlCode = Conversions.ToInteger("2106");
            SAP_Module.DERDwelling_CSH.MainHeating.ElectricityTariff = "standard tariff";
            SAP_Module.DERDwelling_CSH.MainHeating.MainEff = 88f;
            SAP_Module.DERDwelling_CSH.MainHeating.SAPTableCode = 102;
            SAP_Module.DERDwelling_CSH.MainHeating.FuelBurningType = "On/off";
            SAP_Module.DERDwelling_CSH.MainHeating.Boiler.BILock = "Yes";
            SAP_Module.DERDwelling_CSH.MainHeating.Boiler.PumpType = "2013 or later";
            SAP_Module.DERDwelling_CSH.MainHeating.Boiler.FanFlued = "Yes";
            SAP_Module.DERDwelling_CSH.MainHeating.Boiler.FlueType = "Room-sealed";
            SAP_Module.DERDwelling_CSH.MainHeating.Boiler.PumpHP = "Yes";
          }
        }
        else
        {
          SAP_Module.DERDwelling_CSH.MainHeating = new SAP_Module.MainHeating();
          SAP_Module.DERDwelling_CSH.MainHeating.Fuel = "mains gas";
          SAP_Module.DERDwelling_CSH.MainHeating.InforSource = "Manufacturer Declaration";
          SAP_Module.DERDwelling_CSH.MainHeating.SGroup = "Gas boilers (including LPG) 1998 or later";
          SAP_Module.DERDwelling_CSH.MainHeating.HGroup = "Central heating systems with radiators or underfloor heating";
          SAP_Module.DERDwelling_CSH.MainHeating.MHType = "Regular condensing with automatic ignition";
          SAP_Module.DERDwelling_CSH.MainHeating.Emitter = "Systems with radiators";
          SAP_Module.DERDwelling_CSH.MainHeating.Controls = "Programmer, room thermostat and TRVs";
          SAP_Module.DERDwelling_CSH.MainHeating.ControlCode = Conversions.ToInteger("2106");
          SAP_Module.DERDwelling_CSH.MainHeating.ElectricityTariff = "standard tariff";
          SAP_Module.DERDwelling_CSH.MainHeating.MainEff = 88f;
          SAP_Module.DERDwelling_CSH.MainHeating.SAPTableCode = 102;
          SAP_Module.DERDwelling_CSH.MainHeating.FuelBurningType = "On/off";
          SAP_Module.DERDwelling_CSH.MainHeating.Boiler.BILock = "Yes";
          SAP_Module.DERDwelling_CSH.MainHeating.Boiler.FanFlued = "Yes";
          SAP_Module.DERDwelling_CSH.MainHeating.Boiler.PumpType = "2013 or later";
          SAP_Module.DERDwelling_CSH.MainHeating.Boiler.FlueType = "Room-sealed";
          SAP_Module.DERDwelling_CSH.MainHeating.Boiler.PumpHP = "Yes";
        }
        if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].IncludeMainHeating2)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Type, "Standard", false) == 0)
          {
            SAP_Module.DERDwelling_CSH.HeatFractionSec = 0.5f;
            SAP_Module.DERDwelling_CSH.MainHeating2 = new SAP_Module.MainHeating();
            SAP_Module.DERDwelling_CSH.MainHeating2.Fuel = "mains gas";
            SAP_Module.DERDwelling_CSH.MainHeating2.InforSource = "Manufacturer Declaration";
            SAP_Module.DERDwelling_CSH.MainHeating2.SGroup = "Gas boilers (including LPG) 1998 or later";
            SAP_Module.DERDwelling_CSH.MainHeating2.HGroup = "Central heating systems with radiators or underfloor heating";
            SAP_Module.DERDwelling_CSH.MainHeating2.MHType = "Regular condensing with automatic ignition";
            SAP_Module.DERDwelling_CSH.MainHeating2.Emitter = "Systems with radiators";
            SAP_Module.DERDwelling_CSH.MainHeating2.Controls = "Programmer, room thermostat and TRVs";
            SAP_Module.DERDwelling_CSH.MainHeating2.ControlCode = Conversions.ToInteger("2106");
            SAP_Module.DERDwelling_CSH.MainHeating2.ElectricityTariff = "standard tariff";
            SAP_Module.DERDwelling_CSH.MainHeating2.MainEff = 88f;
            SAP_Module.DERDwelling_CSH.MainHeating2.SAPTableCode = 102;
            SAP_Module.DERDwelling_CSH.MainHeating2.FuelBurningType = "On/off";
            SAP_Module.DERDwelling_CSH.MainHeating2.Boiler.BILock = "Yes";
            SAP_Module.DERDwelling_CSH.MainHeating2.Boiler.FanFlued = "Yes";
            SAP_Module.DERDwelling_CSH.MainHeating2.Boiler.PumpType = "2013 or later";
            SAP_Module.DERDwelling_CSH.MainHeating2.Boiler.FlueType = "Room-sealed";
            SAP_Module.DERDwelling_CSH.MainHeating2.Boiler.PumpHP = "Yes";
          }
          else
            SAP_Module.DERDwelling_CSH.MainHeating2 = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2;
        }
        if ((uint) SAP_Module.DERDwelling_CSH.SecHeating.SAPTableCode > 0U)
        {
          SAP_Module.DERDwelling_CSH.SecHeating.Fuel = "Electricity";
          SAP_Module.DERDwelling_CSH.SecHeating.TestMethod = "";
          SAP_Module.DERDwelling_CSH.SecHeating.HGroup = "Room heaters";
          SAP_Module.DERDwelling_CSH.SecHeating.InforSource = "SAP Tables";
          SAP_Module.DERDwelling_CSH.SecHeating.SAPTableCode = 691;
          SAP_Module.DERDwelling_CSH.SecHeating.MHType = "Panel, convector or radiant heaters";
          SAP_Module.DERDwelling_CSH.SecHeating.SecEff = 100f;
          SAP_Module.DERDwelling_CSH.SecHeating.SGroup = "Electric (direct acting) room heaters";
        }
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Type, "Standard", false) == 0)
        {
          SAP_Module.DERDwelling_CSH.Renewable.AAEGeneration.Inlcude = false;
          SAP_Module.DERDwelling_CSH.Renewable.Photovoltaic.Inlcude = false;
          SAP_Module.DERDwelling_CSH.Renewable.Special.Include = false;
          SAP_Module.DERDwelling_CSH.Renewable.WindTurbine.Inlcude = false;
          SAP_Module.DERDwelling_CSH.Water.Solar.Inlcude = false;
          SAP_Module.DERDwelling_CSH.Renewable.HydroGeneration.Inlcude = false;
        }
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Type, "Actual", false) == 0)
        {
          if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SGroup.Contains("heat pumps") | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.HGroup, "Community heating schemes", false) == 0)
            SAP_Module.DERDwelling_CSH.Water = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water;
          else if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.SystemRef == 950 | SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.SystemRef == 951 | SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.SystemRef == 952)
          {
            SAP_Module.DERDwelling_CSH.Water = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water;
          }
          else
          {
            SAP_Module.DERDwelling_CSH.Water = new SAP_Module.Water();
            SAP_Module.DERDwelling_CSH.Water.System = "From main heating system";
            SAP_Module.DERDwelling_CSH.Water.SystemRef = 901;
            SAP_Module.DERDwelling_CSH.Water.Fuel = "mains gas";
            SAP_Module.DERDwelling_CSH.Water.Cylinder.ManuSpecified = false;
            SAP_Module.DERDwelling_CSH.Water.Cylinder.PipeWorkInsulated = true;
            SAP_Module.DERDwelling_CSH.Water.Cylinder.Thermostat = true;
            SAP_Module.DERDwelling_CSH.Water.Cylinder.Timed = true;
            SAP_Module.DERDwelling_CSH.Water.Cylinder.InHeatedSpace = true;
            SAP_Module.DERDwelling_CSH.Water.Cylinder.Volume = 150f;
            SAP_Module.DERDwelling_CSH.Water.Cylinder.InsThick = 35f;
            SAP_Module.DERDwelling_CSH.Water.Cylinder.Insulation = "Factory";
            SAP_Module.DERDwelling_CSH.Water.Cylinder.PipeWorkInsulationType = "Fully insulated primary pipework";
          }
        }
        else
        {
          SAP_Module.DERDwelling_CSH.Water = new SAP_Module.Water();
          SAP_Module.DERDwelling_CSH.Water.System = "From main heating system";
          SAP_Module.DERDwelling_CSH.Water.SystemRef = 901;
          SAP_Module.DERDwelling_CSH.Water.Fuel = "mains gas";
          SAP_Module.DERDwelling_CSH.Water.Cylinder.ManuSpecified = false;
          SAP_Module.DERDwelling_CSH.Water.Cylinder.PipeWorkInsulated = true;
          SAP_Module.DERDwelling_CSH.Water.Cylinder.Thermostat = true;
          SAP_Module.DERDwelling_CSH.Water.Cylinder.Timed = true;
          SAP_Module.DERDwelling_CSH.Water.Cylinder.InHeatedSpace = true;
          SAP_Module.DERDwelling_CSH.Water.Cylinder.Volume = 150f;
          SAP_Module.DERDwelling_CSH.Water.Cylinder.InsThick = 35f;
          SAP_Module.DERDwelling_CSH.Water.Cylinder.Insulation = "Factory";
          SAP_Module.DERDwelling_CSH.Water.Cylinder.PipeWorkInsulationType = "Fully insulated primary pipework";
        }
        if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.WWHRS.Include)
          SAP_Module.DERDwelling_CSH.Water.WWHRS = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.WWHRS;
        if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.FGHRS.Include)
          SAP_Module.DERDwelling_CSH.Water.FGHRS = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.FGHRS;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Type, "Standard", false) == 0)
        {
          SAP_Module.DERDwelling_CSH.Water.Solar.Inlcude = false;
          SAP_Module.DERDwelling_CSH.Renewable.AAEGeneration.Inlcude = false;
          SAP_Module.DERDwelling_CSH.Renewable.Photovoltaic.Inlcude = false;
          SAP_Module.DERDwelling_CSH.Renewable.Special.Include = false;
          SAP_Module.DERDwelling_CSH.Renewable.WindTurbine.Inlcude = false;
          SAP_Module.DERDwelling_CSH.Renewable.HydroGeneration.Inlcude = false;
        }
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Type, "Actual", false) != 0)
          return;
        if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Solar.Inlcude)
          SAP_Module.DERDwelling_CSH.Water.Solar = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Solar;
        if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.AAEGeneration.Inlcude)
          SAP_Module.DERDwelling_CSH.Renewable.AAEGeneration.Inlcude = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.AAEGeneration.Inlcude;
        if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Photovoltaic.Inlcude)
          SAP_Module.DERDwelling_CSH.Renewable.Photovoltaic.Inlcude = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Photovoltaic.Inlcude;
        if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Include)
          SAP_Module.DERDwelling_CSH.Renewable.Special.Include = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Include;
        if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.WindTurbine.Inlcude)
          SAP_Module.DERDwelling_CSH.Renewable.WindTurbine.Inlcude = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.WindTurbine.Inlcude;
        if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.HydroGeneration.Inlcude)
          SAP_Module.DERDwelling_CSH.Renewable.HydroGeneration.Inlcude = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.HydroGeneration.Inlcude;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) ex.Message);
        ProjectData.ClearProjectError();
      }
    }

    private static int CommunityNetworkDatapackage(double EmissionFactor)
    {
      int num;
      try
      {
        num = EmissionFactor >= 51.0 / 400.0 ? (!(EmissionFactor >= 51.0 / 400.0 & EmissionFactor < 0.2285) ? (!(EmissionFactor >= 0.2285 & EmissionFactor < 0.2695) ? (!(EmissionFactor >= 0.2695 & EmissionFactor < 0.4085) ? 4 : 3) : 2) : 1) : 5;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Console.Write("");
        ProjectData.ClearProjectError();
      }
      return num;
    }

    public static void GetTERDwelling(string fuel = null, bool useFuel = false, int source = 0)
    {
      try
      {
        SAP_Module.TERDwelling = Functions.CopyDwelling(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling]);
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.TERDwelling.Address.Country, "Scotland", false) == 0)
        {
          int num1;
          if (useFuel)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel, "dual fuel appliance (mineral and wood)", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Fuel, "appliances able to use mineral oil or liquid biofuel", false) == 0)
            {
              SAP_Module.TERDwelling.MainHeating.Fuel = "heating oil";
              num1 = Functions.GetScotland_Package(SAP_Module.TERDwelling.MainHeating.Fuel);
            }
            else
              num1 = Functions.GetScotland_Package(fuel);
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.InforSource, "Boiler Database", false) == 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.HGroup, "Community heating schemes", false) == 0)
            {
              List<PCDF.CommunityScheme_Sub> communitySchemeSubList = new List<PCDF.CommunityScheme_Sub>();
              List<PCDF.CommunityScheme_Sub> communitySchemesSub = SAP_Module.PCDFData.CommunitySchemes_Sub;
              Func<PCDF.CommunityScheme_Sub, bool> predicate;
              // ISSUE: reference to a compiler-generated field
              if (Functions._Closure\u0024__.\u0024I27\u002D0 != null)
              {
                // ISSUE: reference to a compiler-generated field
                predicate = Functions._Closure\u0024__.\u0024I27\u002D0;
              }
              else
              {
                // ISSUE: reference to a compiler-generated field
                Functions._Closure\u0024__.\u0024I27\u002D0 = predicate = (Func<PCDF.CommunityScheme_Sub, bool>) (b => b.ID.Equals(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SEDBUK));
              }
              List<PCDF.CommunityScheme_Sub> list = communitySchemesSub.Where<PCDF.CommunityScheme_Sub>(predicate).ToList<PCDF.CommunityScheme_Sub>();
              try
              {
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel, "", false) == 0)
                {
                  Functions.SpFuel = true;
                  Functions.SpFuelValue = Conversions.ToDouble(list[source].CO2Factor);
                  num1 = Functions.CommunityNetworkDatapackage(Conversions.ToDouble(list[source].CO2Factor));
                }
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
              }
            }
          }
          else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Fuel, "dual fuel appliance (mineral and wood)", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Fuel, "appliances able to use mineral oil or liquid biofuel", false) == 0)
          {
            SAP_Module.TERDwelling.MainHeating.Fuel = "heating oil";
            num1 = Functions.GetScotland_Package(SAP_Module.TERDwelling.MainHeating.Fuel);
          }
          else
            num1 = Functions.GetScotland_Package(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Fuel);
          ref SAP_Module.Dwelling local = ref SAP_Module.TERDwelling;
          local.Doors = new SAP_Module.Door[1];
          local.NoofDoors = 1;
          local.Windows = new SAP_Module.Window[1];
          local.NoofWindows = 1;
          local.NoofRoofLights = 0;
          local.RoofLights = new SAP_Module.RoofLight[0];
          local.Ventilation.Fans = 0;
          local.Ventilation.Vents = 0;
          local.MainHeating.FuelBurningType = "";
          local.Ventilation.FluesSec = 0;
          local.Ventilation.FluesMain = 0;
          local.Ventilation.FluesOther = 0;
          local.Ventilation.Fires = 0;
          local.Ventilation.Chimneys = 0;
          local.LessThan125Litre = false;
          local.Cooling.Include = false;
          local.Doors[0].Name = "Door 1";
          local.Doors[0].Location = "Wall 1";
          local.Doors[0].Area = 1.85f;
          local.Doors[0].U = 1.4f;
          local.Doors[0].DoorType = "Solid";
          local.Doors[0].GlazingType = "double-glazed, air filled";
          local.Doors[0].Overshading = "Average or unknown";
          local.Doors[0].UValueSource = "Manufacturer";
          local.Doors[0].Count = 1;
          local.Doors[0].Orientation = "East";
          int num2 = checked (local.NoofWalls - 1);
          int index1 = 0;
          float num3;
          while (index1 <= num2)
          {
            num3 += local.Walls[index1].Area;
            checked { ++index1; }
          }
          int num4 = checked (local.Storeys - 1);
          int index2 = 0;
          float num5;
          while (index2 <= num4)
          {
            num5 += local.Dims[index2].Area;
            checked { ++index2; }
          }
          float num6 = (float) ((double) num5 * 0.25 - 1.85);
          if ((double) num3 < (double) num5 * 0.25)
            num6 = num3;
          local.Windows[0].Name = "Window 1";
          local.Windows[0].Location = "Wall 1";
          local.Windows[0].Overshading = "Average or unknown";
          local.Windows[0].GlazingType = "double-glazed, air filled";
          local.Windows[0].Orientation = "East";
          local.Windows[0].Area = num6;
          local.Windows[0].FF = 0.7f;
          local.Windows[0].g = 0.63f;
          local.Windows[0].U = 1.4f;
          local.Windows[0].Count = 1;
          double num7 = 0.0;
          int num8 = checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofWalls - 1);
          int index3 = 0;
          while (index3 <= num8)
          {
            num7 += (double) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Walls[index3].Area * (double) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Walls[index3].K;
            checked { ++index3; }
          }
          local.Walls = new SAP_Module.Opaques[1];
          try
          {
            if (local.PWalls.Length > 0)
            {
              int num9 = checked (local.PWalls.Length - 1);
              int index4 = 0;
              while (index4 <= num9)
              {
                local.PWalls[index4].U_Value = 0.0f;
                checked { ++index4; }
              }
            }
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
          local.NoofWalls = 1;
          local.Walls[0].Area = num3;
          local.Walls[0].Name = "Wall 1";
          local.Walls[0].Type = "Exposed wall";
          local.Walls[0].U_Value = 0.17f;
          local.Walls[0].K = (float) num7 / num3;
          int num10 = checked (local.NoofFloors - 1);
          int index5 = 0;
          while (index5 <= num10)
          {
            local.Floors[index5].U_Value = 0.15f;
            checked { ++index5; }
          }
          int num11 = checked (local.NoofRoofs - 1);
          int index6 = 0;
          while (index6 <= num11)
          {
            local.Roofs[index6].U_Value = 0.11f;
            checked { ++index6; }
          }
          local.Thermal.ManualHtb = false;
          local.Thermal.YValue = 0.08f;
          local.Thermal.ManualY = true;
          local.TMP.UserDefined = (float) SAP_Module.Calculation2012.Calculation.HeatLoss.Box35;
          local.TMP.Type = "User Value";
          local.Ventilation.MechVent = "Natural ventilation";
          local.Ventilation.Pressure = "As designed";
          local.Ventilation.DesignAir = 7f;
          local.Ventilation.MeasuredAir = 0.0f;
          local.Ventilation.AssumedAir = 0.0f;
          local.Ventilation.Chimneys = 0;
          local.Ventilation.Shelter = 2f;
          local.Ventilation.Flues = 0;
          local.Ventilation.Fires = 0;
          switch (num1)
          {
            case 2:
            case 3:
            case 5:
              local.Ventilation.Flues = 1;
              break;
            default:
              local.Ventilation.Flues = 0;
              break;
          }
          local.Ventilation.Fans = (double) num5 <= 80.0 ? 3 : 4;
          local.Orientation = "East";
          local.Overshading = "Average or unknown";
          local.IncludeMainHeating2 = false;
          string electricityTariff = local.MainHeating.ElectricityTariff;
          local.MainHeating = new SAP_Module.MainHeating();
          local.MainHeating.Emitter = "Systems with radiators";
          local.MainHeating.ElectricityTariff = electricityTariff;
          switch (num1)
          {
            case 1:
            case 2:
            case 3:
              local.MainHeating.Fuel = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Fuel;
              local.MainHeating.HGroup = "Boiler systems with radiators or underfloor heating";
              local.MainHeating.SGroup = "Gas boilers and oil boilers";
              local.MainHeating.BSubGroup = "Gas boilers (including LPG) 1998 or later";
              local.MainHeating.InforSource = "Boiler Database";
              local.MainHeating.MainEff = 89f;
              if (num1 == 1)
              {
                local.MainHeating.Fuel = "mains gas";
                local.MainHeating.SEDBUK = "690103";
              }
              else if (num1 == 2)
              {
                local.MainHeating.Fuel = "bulk LPG";
                local.MainHeating.SEDBUK = "690104";
              }
              else if (num1 == 3)
              {
                local.MainHeating.Fuel = "heating oil";
                local.MainHeating.BSubGroup = "Oil boilers";
                local.MainHeating.SEDBUK = "690105";
                local.MainHeating.MainEff = 90f;
                local.MainHeating.OilPump = true;
              }
              local.MainHeating.Boiler.PumpType = "2013 or later";
              local.MainHeating.Boiler.PumpHP = "Yes";
              break;
            case 4:
              local.MainHeating.Fuel = "Electricity";
              local.MainHeating.MCSCert = true;
              local.MainHeating.HGroup = "Heat pumps with radiators or underfloor heating";
              local.MainHeating.SGroup = "Electric heat pumps";
              local.MainHeating.MHType = "Air source heat pump in other cases";
              local.MainHeating.SAPTableCode = 224;
              local.MainHeating.MainEff = 175.1f;
              local.MainHeating.Boiler.FlowTemp = "Design flow temperature >45°C";
              local.MainHeating.Boiler.PumpHP = "Yes";
              break;
            case 5:
              local.MainHeating.HGroup = "Boiler systems with radiators or underfloor heating";
              local.MainHeating.SGroup = "Solid fuel boilers";
              local.MainHeating.InforSource = "Boiler Database";
              local.MainHeating.MainEff = 86f;
              local.MainHeating.HETAS = "Yes";
              local.MainHeating.Boiler.PumpHP = "Yes";
              local.MainHeating.Fuel = "wood pellets (bulk supply in bags, for main heating)";
              local.MainHeating.SEDBUK = "691101";
              break;
          }
          local.MainHeating.Boiler.PumpType = "2013 or later";
          if ((uint) (num1 - 1) <= 2U)
          {
            local.MainHeating.Boiler.FlueType = "Room-sealed";
            local.MainHeating.Boiler.FanFlued = "Yes";
          }
          switch (num1 - 1)
          {
            case 0:
              local.MainHeating.ControlCodePCDFWeather = "696302";
              break;
            case 1:
              local.MainHeating.ControlCodePCDFWeather = "696303";
              break;
            case 2:
              local.MainHeating.ControlCodePCDFWeather = "696304";
              break;
          }
          switch (num1 - 1)
          {
            case 0:
            case 1:
            case 2:
              local.MainHeating.ControlCode = 2110;
              local.MainHeating.Boiler.BILock = "Yes";
              local.MainHeating.Boiler.LoadWeatherType = "Weather Compensator";
              local.MainHeating.Boiler.LoadWeather = true;
              local.MainHeating.DelayedStart = true;
              break;
            case 3:
              local.MainHeating.ControlCode = 2207;
              break;
            case 4:
              local.MainHeating.ControlCode = 2110;
              local.MainHeating.DelayedStart = true;
              break;
          }
          local.MainHeating.Controls = "Time and temperature zone control by suitable arrangement of plumbing and electrical services";
          local.SecHeating.Fuel = "";
          local.SecHeating.SAPTableCode = 0;
          local.SecHeating.SecEff = 0.0f;
          if ((uint) (num1 - 2) > 1U)
          {
            if (num1 == 4)
            {
              local.SecHeating.HGroup = "Room heater";
              local.SecHeating.Fuel = "Electricity";
              local.SecHeating.SAPTableCode = 692;
              local.SecHeating.SecEff = 100f;
            }
          }
          else
          {
            local.SecHeating.HGroup = "Room heater";
            local.SecHeating.SGroup = "Solid fuel room heaters";
            local.SecHeating.Fuel = "wood logs";
            local.SecHeating.MHType = "Closed room heater";
            local.SecHeating.InforSource = "SAP Tables";
            local.SecHeating.SAPTableCode = 633;
            local.SecHeating.HETAS = "No";
            local.SecHeating.SecEff = 60f;
          }
          local.Water = new SAP_Module.Water();
          local.Water.Fuel = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Fuel;
          int num12 = num1;
          if (num12 >= 1 && num12 <= 3 || num12 == 5)
          {
            local.Water.System = "From main heating system";
            local.Water.SystemRef = 901;
            local.Water.Fuel = local.MainHeating.Fuel;
          }
          else if (num12 == 4)
          {
            local.Water.System = "Electric immersion (on-peak or off-peak)";
            local.Water.SystemRef = 903;
            local.Water.Fuel = "Electricity";
          }
          local.Water.Cylinder.Timed = true;
          local.Water.Cylinder.Volume = 150f;
          local.Water.Cylinder.ManuSpecified = true;
          local.Water.Cylinder.DeclaredLoss = 1.89f;
          local.Water.Cylinder.PipeWorkInsulated = true;
          local.Water.Cylinder.Thermostat = true;
          local.Water.Cylinder.InHeatedSpace = true;
          local.Water.Cylinder.PipeWorkInsulationType = "Fully insulated primary pipework";
          switch (num1)
          {
            case 1:
            case 2:
            case 3:
              local.Renewable.Photovoltaic = new SAP_Module.Photovoltaic();
              local.Renewable.Photovoltaic.Photovoltaics = new SAP_Module.PhotoVoltaics[1];
              local.Renewable.Photovoltaic.Inlcude = true;
              local.Renewable.Photovoltaic.Photovoltaics[0].DirectlyConnected = true;
              local.Renewable.Photovoltaic.Photovoltaics[0].ID = 0;
              local.Renewable.Photovoltaic.Photovoltaics[0].PCOrientation = "South West";
              local.Renewable.Photovoltaic.Photovoltaics[0].POvershading = "None or very little";
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(local.PropertyType, "Flat", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(local.PropertyType, "Maisonette", false) == 0)
              {
                double num13 = (double) num5 / (double) checked (local.NoOFDwellingsBelow + local.NoOFDwellingsAbove + 1);
                double num14 = (double) num5 * 0.01;
                local.Renewable.Photovoltaic.Photovoltaics[0].PPower = 0.0414 * num13 >= num14 ? (float) Math.Round(num14, 2) : (float) Math.Round(0.0414 * num13, 2);
              }
              else
                local.Renewable.Photovoltaic.Photovoltaics[0].PPower = (float) Math.Round((double) num5 * 0.01, 2);
              local.Renewable.Photovoltaic.Photovoltaics[0].PTilt = "30°";
              break;
            default:
              local.Renewable.Photovoltaic.Inlcude = false;
              break;
          }
          local.Water.WWHRS = new SAP_Module.WWHRSSystem();
          local.Water.WWHRS.Include = true;
          local.Water.WWHRS.Systems = new SAP_Module.WWHRS_Systems[2];
          local.Water.WWHRS.Systems[0] = new SAP_Module.WWHRS_Systems();
          local.Water.WWHRS.Systems[1] = new SAP_Module.WWHRS_Systems();
          local.Water.WWHRS.Systems[0].SystemsRef = local.Water.WWHRS.Systems[0].SystemsRef;
          local.Water.WWHRS.Systems[1].SystemsRef = local.Water.WWHRS.Systems[1].SystemsRef;
          local.Water.WWHRS.TotalRooms = 1f;
          if ((double) num5 <= 100.0)
          {
            local.Water.WWHRS.Systems[0].WithBath = 0;
            local.Water.WWHRS.Systems[0].WithNoBath = 1;
            local.Water.WWHRS.Systems[0].SystemsRef = "695101";
          }
          if ((double) num5 >= 100.0)
          {
            local.Water.WWHRS.TotalRooms = 2f;
            local.Water.WWHRS.Systems[0].WithBath = 0;
            local.Water.WWHRS.Systems[0].WithNoBath = 1;
            local.Water.WWHRS.Systems[0].SystemsRef = "695101";
            local.Water.WWHRS.Systems[1].WithBath = 0;
            local.Water.WWHRS.Systems[1].WithNoBath = 1;
            local.Water.WWHRS.Systems[1].SystemsRef = "695102";
          }
          local.LowEnergyLight = 100f;
          local.Renewable.AAEGeneration.Inlcude = false;
          local.Renewable.HydroGeneration.Inlcude = false;
          local.Renewable.Special.Include = false;
          local.Renewable.WindTurbine.Inlcude = false;
          local.LessThan125Litre = false;
          local.Cooling.Include = false;
        }
        else
        {
          SAP_Module.TERDwelling.TMP.Type = "Indicative Value";
          SAP_Module.TERDwelling.TMP.Indicative = "Medium";
          SAP_Module.TERDwelling.LessThan125Litre = true;
          SAP_Module.TERDwelling.Cooling.Include = false;
          float num15 = 0.0f;
          int num16 = checked (SAP_Module.TERDwelling.NoofDoors - 1);
          int index7 = 0;
          while (index7 <= num16)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.TERDwelling.Doors[index7].DoorType, "Half glazed", false) == 0)
            {
              SAP_Module.TERDwelling.Doors[index7].U = 1.2f;
              SAP_Module.TERDwelling.Doors[index7].GlazingType = "double-glazed, air filled";
            }
            else
            {
              SAP_Module.TERDwelling.Doors[index7].U = 1f;
              SAP_Module.TERDwelling.Doors[index7].DoorType = "Solid";
            }
            num15 += SAP_Module.TERDwelling.Doors[index7].Area;
            checked { ++index7; }
          }
          int num17 = checked (SAP_Module.TERDwelling.Storeys - 1);
          int index8 = 0;
          float num18;
          while (index8 <= num17)
          {
            num18 += SAP_Module.TERDwelling.Dims[index8].Area;
            checked { ++index8; }
          }
          int num19 = checked (SAP_Module.TERDwelling.NoofWindows - 1);
          int index9 = 0;
          float num20;
          while (index9 <= num19)
          {
            num20 += (float) Math.Round((double) SAP_Module.TERDwelling.Windows[index9].Area * (double) SAP_Module.TERDwelling.Windows[index9].Count, 2);
            SAP_Module.TERDwelling.Windows[index9].GlazingType = "double-glazed, air filled (low-E, En = 0.2, hard coat)";
            SAP_Module.TERDwelling.Windows[index9].UValueSource = "SAP 2012";
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.TERDwelling.Windows[index9].Overshading, "Very Little", false) == 0)
              SAP_Module.TERDwelling.Windows[index9].Overshading = "Average or unknown";
            SAP_Module.TERDwelling.Windows[index9].FF = 0.7f;
            SAP_Module.TERDwelling.Windows[index9].g = 0.63f;
            SAP_Module.TERDwelling.Windows[index9].U = 1.4f;
            int num21 = checked (SAP_Module.TERDwelling.NoofWalls - 1);
            int index10 = 0;
            while (index10 <= num21)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.TERDwelling.Walls[index10].Name, SAP_Module.TERDwelling.Windows[index9].Location, false) == 0 & SAP_Module.TERDwelling.Walls[index10].Curtain)
                SAP_Module.TERDwelling.Windows[index9].U = 1.5f;
              checked { ++index10; }
            }
            checked { ++index9; }
          }
          int num22 = checked (SAP_Module.TERDwelling.NoofRoofLights - 1);
          int index11 = 0;
          while (index11 <= num22)
          {
            num20 += SAP_Module.TERDwelling.RoofLights[index11].Area * (float) SAP_Module.TERDwelling.RoofLights[index11].Count;
            SAP_Module.TERDwelling.RoofLights[index11].GlazingType = "double-glazed, air filled (low-E, En = 0.2, hard coat)";
            SAP_Module.TERDwelling.RoofLights[index11].UValueSource = "SAP 2012";
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.TERDwelling.RoofLights[index11].Overshading, "Very Little", false) == 0)
              SAP_Module.TERDwelling.RoofLights[index11].Overshading = "Average or unknown";
            SAP_Module.TERDwelling.RoofLights[index11].FF = 0.7f;
            SAP_Module.TERDwelling.RoofLights[index11].g = 0.63f;
            SAP_Module.TERDwelling.RoofLights[index11].U = 1.7f;
            checked { ++index11; }
          }
          if ((double) num18 * 0.25 < (double) num15 + (double) num20)
          {
            float num23 = (num18 * 0.25f - num15) / num20;
            int num24 = checked (SAP_Module.TERDwelling.NoofWindows - 1);
            int index12 = 0;
            while (index12 <= num24)
            {
              // ISSUE: variable of a reference type
              float& local;
              // ISSUE: explicit reference operation
              double num25 = (double) ^(local = ref SAP_Module.TERDwelling.Windows[index12].Area) * (double) num23;
              local = (float) num25;
              SAP_Module.TERDwelling.Windows[index12].Area = (float) Math.Round((double) SAP_Module.TERDwelling.Windows[index12].Area, 2);
              checked { ++index12; }
            }
            int num26 = checked (SAP_Module.TERDwelling.NoofRoofLights - 1);
            int index13 = 0;
            while (index13 <= num26)
            {
              // ISSUE: variable of a reference type
              float& local;
              // ISSUE: explicit reference operation
              double num27 = (double) ^(local = ref SAP_Module.TERDwelling.RoofLights[index13].Area) * (double) num23;
              local = (float) num27;
              checked { ++index13; }
            }
          }
          int num28 = checked (SAP_Module.TERDwelling.NoofWalls - 1);
          int index14 = 0;
          while (index14 <= num28)
          {
            SAP_Module.TERDwelling.Walls[index14].Ru = 0.0f;
            SAP_Module.TERDwelling.Walls[index14].U_Value = 0.18f;
            if (SAP_Module.TERDwelling.Walls[index14].Curtain)
              SAP_Module.TERDwelling.Walls[index14].U_Value = 0.18f;
            checked { ++index14; }
          }
          int num29 = checked (SAP_Module.TERDwelling.NoofPWalls - 1);
          int index15 = 0;
          while (index15 <= num29)
          {
            SAP_Module.TERDwelling.PWalls[index15].U_Value = 0.0f;
            checked { ++index15; }
          }
          int num30 = checked (SAP_Module.TERDwelling.NoofFloors - 1);
          int index16 = 0;
          while (index16 <= num30)
          {
            SAP_Module.TERDwelling.Floors[index16].U_Value = 0.13f;
            checked { ++index16; }
          }
          int num31 = checked (SAP_Module.TERDwelling.NoofRoofs - 1);
          int index17 = 0;
          while (index17 <= num31)
          {
            SAP_Module.TERDwelling.Roofs[index17].Ru = 0.0f;
            SAP_Module.TERDwelling.Roofs[index17].U_Value = 0.13f;
            checked { ++index17; }
          }
          bool flag1 = false;
          bool flag2 = false;
          if (!SAP_Module.TERDwelling.Thermal.ManualHtb)
            SAP_Module.TERDwelling.Thermal.YValue = 0.05f;
          if (SAP_Module.TERDwelling.Thermal.ManualHtb)
          {
            float num32 = 0.0f;
            if (SAP_Module.TERDwelling.Thermal.ExternalJunctions != null)
            {
              try
              {
                foreach (SAP_Module.Junction externalJunction in SAP_Module.TERDwelling.Thermal.ExternalJunctions)
                {
                  externalJunction.ThermalTransmittance = Functions.Gethtb(externalJunction.Ref);
                  num32 += externalJunction.ThermalTransmittance * externalJunction.Length;
                }
              }
              finally
              {
                List<SAP_Module.Junction>.Enumerator enumerator;
                enumerator.Dispose();
              }
            }
            if (SAP_Module.TERDwelling.Thermal.RoofJunctions != null)
            {
              try
              {
                foreach (SAP_Module.Junction roofJunction in SAP_Module.TERDwelling.Thermal.RoofJunctions)
                {
                  roofJunction.ThermalTransmittance = Functions.Gethtb(roofJunction.Ref);
                  num32 += roofJunction.ThermalTransmittance * roofJunction.Length;
                }
              }
              finally
              {
                List<SAP_Module.Junction>.Enumerator enumerator;
                enumerator.Dispose();
              }
            }
            if (SAP_Module.TERDwelling.Thermal.PartyJunctions != null)
            {
              try
              {
                foreach (SAP_Module.Junction partyJunction in SAP_Module.TERDwelling.Thermal.PartyJunctions)
                {
                  partyJunction.ThermalTransmittance = Functions.Gethtb(partyJunction.Ref);
                  num32 += partyJunction.ThermalTransmittance * partyJunction.Length;
                }
              }
              finally
              {
                List<SAP_Module.Junction>.Enumerator enumerator;
                enumerator.Dispose();
              }
            }
            SAP_Module.TERDwelling.Thermal.HtbValue = num32;
          }
          SAP_Module.TERDwelling.Ventilation.MechVent = "Natural ventilation";
          SAP_Module.TERDwelling.Ventilation.Chimneys = 0;
          SAP_Module.TERDwelling.Ventilation.Pressure = "As designed";
          SAP_Module.TERDwelling.Ventilation.DesignAir = 5f;
          SAP_Module.TERDwelling.Ventilation.Flues = 0;
          SAP_Module.TERDwelling.Ventilation.Fires = 0;
          float num33 = num18;
          if ((double) num33 <= 70.0)
          {
            SAP_Module.TERDwelling.Ventilation.Fans = 2;
          }
          else
          {
            int num34 = (double) num33 < 70.0 ? 0 : ((double) num33 <= 100.0 ? 1 : 0);
            SAP_Module.TERDwelling.Ventilation.Fans = num34 == 0 ? 4 : 3;
          }
          SAP_Module.TERDwelling.Ventilation.Vents = 0;
          SAP_Module.TERDwelling.SecHeating.SAPTableCode = 699;
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.TERDwelling.MainHeating.HGroup, "Boiler systems with radiators or underfloor heating", false) == 0)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.TERDwelling.MainHeating.InforSource, "Boiler Database", false) == 0)
            {
              List<PCDF.SEDBUK> boilers = SAP_Module.PCDFData.Boilers;
              Func<PCDF.SEDBUK, bool> predicate;
              // ISSUE: reference to a compiler-generated field
              if (Functions._Closure\u0024__.\u0024I27\u002D1 != null)
              {
                // ISSUE: reference to a compiler-generated field
                predicate = Functions._Closure\u0024__.\u0024I27\u002D1;
              }
              else
              {
                // ISSUE: reference to a compiler-generated field
                Functions._Closure\u0024__.\u0024I27\u002D1 = predicate = (Func<PCDF.SEDBUK, bool>) (b => b.ID.ToUpper().Equals(SAP_Module.TERDwelling.MainHeating.SEDBUK.ToUpper()));
              }
              PCDF.SEDBUK sedbuk = boilers.Where<PCDF.SEDBUK>(predicate).SingleOrDefault<PCDF.SEDBUK>();
              if (sedbuk != null)
              {
                if (sedbuk.MainType.Equals("2"))
                  flag1 = true;
                else if (!sedbuk.MainType.Equals("1") && sedbuk.MainType.Equals("3"))
                  flag2 = true;
              }
            }
            else
            {
              switch (SAP_Module.TERDwelling.MainHeating.SAPTableCode)
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
                  flag1 = true;
                  break;
                case 120:
                case 192:
                  flag2 = true;
                  break;
              }
            }
          }
          string electricityTariff = SAP_Module.TERDwelling.MainHeating.ElectricityTariff;
          string str = SAP_Module.TERDwelling.MainHeating.Boiler.PumpType;
          if (!SAP_Module.Proj.OverRide)
            str = "2013 or later";
          if (string.IsNullOrEmpty(str))
            str = "2013 or later";
          if (str == null)
            str = "2013 or later";
          SAP_Module.TERDwelling.MainHeating = new SAP_Module.MainHeating();
          SAP_Module.TERDwelling.MainHeating.Boiler.PumpHP = "Yes";
          SAP_Module.TERDwelling.MainHeating.Boiler.PumpType = str;
          SAP_Module.TERDwelling.MainHeating.ElectricityTariff = electricityTariff;
          SAP_Module.TERDwelling.MainHeating.Fuel = "mains gas";
          SAP_Module.TERDwelling.MainHeating.InforSource = "Manufacturer Declaration";
          SAP_Module.TERDwelling.IncludeMainHeating2 = false;
          SAP_Module.TERDwelling.MainHeating2.HPOnly.HotWaterHP_Integral = false;
          SAP_Module.TERDwelling.MainHeating.Emitter = "Systems with radiators";
          SAP_Module.TERDwelling.MainHeating.HGroup = "Boiler systems with radiators or underfloor heating";
          SAP_Module.TERDwelling.MainHeating.SGroup = "Gas boilers and oil boilers";
          SAP_Module.TERDwelling.MainHeating.BSubGroup = "Gas boilers (including LPG) 1998 or later";
          if (flag1 & SAP_Module.TERDwelling.Water.SystemRef != 914)
          {
            SAP_Module.TERDwelling.MainHeating.MHType = "Condensing combi with automatic ignition";
            SAP_Module.TERDwelling.MainHeating.SAPTableCode = 104;
          }
          else
          {
            SAP_Module.TERDwelling.MainHeating.MHType = "Regular condensing with automatic ignition";
            SAP_Module.TERDwelling.MainHeating.SAPTableCode = 102;
          }
          SAP_Module.TERDwelling.MainHeating.MainEff = 89.5f;
          SAP_Module.TERDwelling.MainHeating.Boiler.FlueType = "Room-sealed";
          SAP_Module.TERDwelling.MainHeating.FuelBurningType = "Modulation";
          SAP_Module.TERDwelling.MainHeating.SEDBUK2009 = true;
          SAP_Module.TERDwelling.MainHeating.SEDBUK2005 = false;
          SAP_Module.TERDwelling.MainHeating.Boiler.FanFlued = "Yes";
          SAP_Module.TERDwelling.SecHeating.SAPTableCode = 0;
          bool flag3 = false;
          if (SAP_Module.TERDwelling.Storeys == 1 && (double) SAP_Module.TERDwelling.LivingArea > (double) num18 * 0.7)
            flag3 = true;
          if (flag3)
          {
            SAP_Module.TERDwelling.MainHeating.Controls = "Programmer and room thermostat";
            SAP_Module.TERDwelling.MainHeating.ControlCode = 2104;
          }
          else
          {
            SAP_Module.TERDwelling.MainHeating.Controls = "Time and temperature zone control";
            SAP_Module.TERDwelling.MainHeating.ControlCode = 2110;
          }
          SAP_Module.TERDwelling.MainHeating.Boiler.BILock = "Yes";
          SAP_Module.TERDwelling.MainHeating.Boiler.LoadWeather = true;
          SAP_Module.TERDwelling.MainHeating.Boiler.LoadWeatherType = "Weather Compensator";
          SAP_Module.TERDwelling.Water = new SAP_Module.Water();
          SAP_Module.TERDwelling.Water.CombiType = "Instantaneous Combi";
          SAP_Module.TERDwelling.Water.Fuel = "mains gas";
          SAP_Module.TERDwelling.Water.System = "From main heating system";
          SAP_Module.TERDwelling.Water.SystemRef = 901;
          SAP_Module.TERDwelling.Water.Cylinder.Timed = true;
          if (flag1)
          {
            SAP_Module.TERDwelling.Water.Cylinder.Volume = 0.0f;
            SAP_Module.TERDwelling.Water.Cylinder.InsThick = 0.0f;
            SAP_Module.TERDwelling.Water.Cylinder.Insulation = "";
          }
          else if ((double) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.Volume == 0.0 | flag2 | SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.SystemRef == 999 | SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Thermal.Include)
          {
            SAP_Module.TERDwelling.Water.Cylinder.Volume = 150f;
            SAP_Module.TERDwelling.Water.Cylinder.Insulation = "Factory";
            SAP_Module.TERDwelling.Water.Cylinder.InsThick = 35f;
          }
          else
          {
            SAP_Module.TERDwelling.Water.Cylinder.Volume = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.Volume;
            SAP_Module.TERDwelling.Water.Cylinder.Insulation = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.Insulation;
            SAP_Module.TERDwelling.Water.Cylinder.InsThick = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.InsThick;
          }
          if (SAP_Module.TERDwelling.WaterOnlyHeatPump)
          {
            if ((double) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.Volume == 0.0 | !SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.InHeatedSpace)
            {
              SAP_Module.TERDwelling.Water.Cylinder.Volume = 150f;
            }
            else
            {
              SAP_Module.TERDwelling.Water.Cylinder.Volume = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.Volume;
              SAP_Module.TERDwelling.Water.Cylinder.Insulation = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.Insulation;
              SAP_Module.TERDwelling.Water.Cylinder.InsThick = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.InsThick;
            }
            if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.ManuSpecified)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.Insulation, "", false) == 0)
                SAP_Module.TERDwelling.Water.Cylinder.Insulation = "Factory";
              if (Conversion.Val((object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.InsThick) == 0.0)
                SAP_Module.TERDwelling.Water.Cylinder.InsThick = 35f;
            }
          }
          if ((double) SAP_Module.TERDwelling.Water.Cylinder.Volume != 0.0)
          {
            SAP_Module.TERDwelling.Water.Cylinder.ManuSpecified = true;
            SAP_Module.TERDwelling.Water.Cylinder.DeclaredLoss = (float) (0.85 * (0.2 + 0.051 * Math.Pow((double) SAP_Module.TERDwelling.Water.Cylinder.Volume, 2.0 / 3.0)));
          }
          SAP_Module.TERDwelling.Water.Cylinder.InHeatedSpace = true;
          SAP_Module.TERDwelling.Water.Cylinder.PipeWorkInsulated = true;
          SAP_Module.TERDwelling.Water.Cylinder.Thermostat = true;
          SAP_Module.TERDwelling.Water.Cylinder.PipeWorkInsulationType = "Fully insulated primary pipework";
          SAP_Module.TERDwelling.LowEnergyLight = 100f;
          SAP_Module.TERDwelling.Renewable.AAEGeneration.Inlcude = false;
          SAP_Module.TERDwelling.Renewable.Photovoltaic.Inlcude = false;
          SAP_Module.TERDwelling.Renewable.Special.Include = false;
          SAP_Module.TERDwelling.Renewable.WindTurbine.Inlcude = false;
          SAP_Module.TERDwelling.Renewable.HydroGeneration.Inlcude = false;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private static float Gethtb(string Ref)
    {
      string str = Ref;
      float num;
      // ISSUE: reference to a compiler-generated method
      switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(str))
      {
        case 63694499:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "E1", false) == 0)
            break;
          goto default;
        case 80472118:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "E2", false) == 0)
            break;
          goto default;
        case 97249737:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "E3", false) == 0)
            break;
          goto default;
        case 114027356:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "E4", false) == 0)
            break;
          goto default;
        case 130804975:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "E5", false) == 0)
            goto label_44;
          else
            goto default;
        case 134497664:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "R5", false) == 0)
            goto label_60;
          else
            goto default;
        case 147582594:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "E6", false) == 0)
            goto label_49;
          else
            goto default;
        case 151275283:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "R4", false) == 0)
            goto label_58;
          else
            goto default;
        case 164360213:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "E7", false) == 0)
            goto label_45;
          else
            goto default;
        case 168052902:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "R7", false) == 0)
            goto label_60;
          else
            goto default;
        case 181137832:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "E8", false) == 0)
            goto label_49;
          else
            goto default;
        case 184830521:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "R6", false) == 0)
            goto label_59;
          else
            goto default;
        case 197915451:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "E9", false) == 0)
            goto label_50;
          else
            goto default;
        case 201608140:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "R1", false) == 0)
            goto label_58;
          else
            goto default;
        case 235163378:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "R3", false) == 0)
            goto label_58;
          else
            goto default;
        case 251940997:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "R2", false) == 0)
            goto label_59;
          else
            goto default;
        case 335829092:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "R9", false) == 0)
            goto label_60;
          else
            goto default;
        case 352606711:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "R8", false) == 0)
            goto label_59;
          else
            goto default;
        case 419422997:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "P8", false) == 0)
          {
            num = 0.24f;
            goto label_62;
          }
          else
            goto default;
        case 436200616:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "P7", false) == 0)
            goto label_44;
          else
            goto default;
        case 452978235:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "P6", false) == 0)
            goto label_45;
          else
            goto default;
        case 469755854:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "P5", false) == 0)
            goto label_52;
          else
            goto default;
        case 486533473:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "P4", false) == 0)
          {
            num = 0.12f;
            goto label_62;
          }
          else
            goto default;
        case 503311092:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "P3", false) == 0)
            goto label_49;
          else
            goto default;
        case 520088711:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "P2", false) == 0)
            goto label_49;
          else
            goto default;
        case 536866330:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "P1", false) == 0)
            goto label_52;
          else
            goto default;
        case 2314990768:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "E13", false) == 0)
            goto label_52;
          else
            goto default;
        case 2331768387:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "E12", false) == 0)
            goto label_51;
          else
            goto default;
        case 2348546006:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "E11", false) == 0)
          {
            num = 0.04f;
            goto label_62;
          }
          else
            goto default;
        case 2365323625:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "E10", false) == 0)
            goto label_51;
          else
            goto default;
        case 2382101244:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "E17", false) == 0)
          {
            num = -0.09f;
            goto label_62;
          }
          else
            goto default;
        case 2398878863:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "E16", false) == 0)
          {
            num = 0.09f;
            goto label_62;
          }
          else
            goto default;
        case 2399025958:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "E24", false) == 0)
          {
            num = 0.24f;
            goto label_62;
          }
          else
            goto default;
        case 2415656482:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "E15", false) == 0)
          {
            num = 0.56f;
            goto label_62;
          }
          else
            goto default;
        case 2415803577:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "E25", false) == 0)
            goto label_51;
          else
            goto default;
        case 2432434101:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "E14", false) == 0)
            goto label_52;
          else
            goto default;
        case 2432581196:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "E22", false) == 0)
            goto label_45;
          else
            goto default;
        case 2449358815:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "E23", false) == 0)
            goto label_50;
          else
            goto default;
        case 2466136434:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "E20", false) == 0)
            goto label_46;
          else
            goto default;
        case 2482766958:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "E19", false) == 0)
            goto label_45;
          else
            goto default;
        case 2482914053:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "E21", false) == 0)
            goto label_46;
          else
            goto default;
        case 2499544577:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "E18", false) == 0)
            goto label_51;
          else
            goto default;
        default:
          goto label_62;
      }
      num = 0.05f;
      goto label_62;
label_44:
      num = 0.16f;
      goto label_62;
label_45:
      num = 0.07f;
      goto label_62;
label_46:
      num = 0.32f;
      goto label_62;
label_49:
      num = 0.0f;
      goto label_62;
label_50:
      num = 0.0f;
      goto label_62;
label_51:
      num = 0.06f;
      goto label_62;
label_52:
      num = 0.08f;
      goto label_62;
label_58:
      num = 0.08f;
      goto label_62;
label_59:
      num = 0.06f;
      goto label_62;
label_60:
      num = 0.04f;
label_62:
      return num;
    }

    public static void GetTemPScotlandTERDwelling()
    {
      try
      {
        SAP_Module.ScotlandTERDwelling = Functions.CopyDwelling(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling]);
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.ScotlandTERDwelling.Address.Country, "Scotland", false) != 0)
          return;
        int scotlandPackage = Functions.GetScotland_Package(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.Fuel);
        ref SAP_Module.Dwelling local = ref SAP_Module.ScotlandTERDwelling;
        local.Ventilation.Fans = 0;
        local.Ventilation.Vents = 0;
        local.MainHeating.FuelBurningType = "";
        local.Ventilation.FluesSec = 0;
        local.Ventilation.FluesMain = 0;
        local.Ventilation.FluesOther = 0;
        local.Ventilation.Fires = 0;
        local.Ventilation.Chimneys = 0;
        local.LessThan125Litre = false;
        local.Cooling.Include = false;
        local.Doors = new SAP_Module.Door[1];
        local.NoofDoors = 1;
        local.Windows = new SAP_Module.Window[1];
        local.NoofWindows = 1;
        local.NoofRoofLights = 0;
        local.RoofLights = new SAP_Module.RoofLight[0];
        local.Doors[0].Name = "Door 1";
        local.Doors[0].Location = "Wall 1";
        local.Doors[0].Area = 1.85f;
        local.Doors[0].U = 1.4f;
        local.Doors[0].DoorType = "Solid";
        local.Doors[0].GlazingType = "double-glazed, air filled";
        local.Doors[0].Overshading = "Average or unknown";
        local.Doors[0].UValueSource = "Manufacturer";
        local.Doors[0].Count = 1;
        local.Doors[0].Orientation = "East";
        int num1 = checked (local.NoofWalls - 1);
        int index1 = 0;
        float num2;
        while (index1 <= num1)
        {
          num2 += local.Walls[index1].Area;
          checked { ++index1; }
        }
        int num3 = checked (local.Storeys - 1);
        int index2 = 0;
        float num4;
        while (index2 <= num3)
        {
          num4 += local.Dims[index2].Area;
          checked { ++index2; }
        }
        float num5 = (float) ((double) num4 * 0.25 - 1.85);
        if ((double) num2 < (double) num4 * 0.25)
          num5 = num2;
        local.Windows[0].Name = "Window 1";
        local.Windows[0].Location = "Wall 1";
        local.Windows[0].Overshading = "Average or unknown";
        local.Windows[0].GlazingType = "double-glazed, air filled";
        local.Windows[0].Orientation = "East";
        local.Windows[0].Area = num5;
        local.Windows[0].FF = 0.7f;
        local.Windows[0].g = 0.63f;
        local.Windows[0].U = 1.4f;
        local.Windows[0].Count = 1;
        double num6 = 0.0;
        int num7 = checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofWalls - 1);
        int index3 = 0;
        while (index3 <= num7)
        {
          num6 += (double) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Walls[index3].Area * (double) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Walls[index3].K;
          checked { ++index3; }
        }
        local.Walls = new SAP_Module.Opaques[1];
        try
        {
          if (local.PWalls.Length > 0)
          {
            int num8 = checked (local.PWalls.Length - 1);
            int index4 = 0;
            while (index4 <= num8)
            {
              local.PWalls[index4].U_Value = 0.0f;
              checked { ++index4; }
            }
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        local.NoofWalls = 1;
        local.Walls[0].Area = num2;
        local.Walls[0].Name = "Wall 1";
        local.Walls[0].Type = "Exposed wall";
        local.Walls[0].U_Value = 0.17f;
        local.Walls[0].K = (float) num6 / num2;
        int num9 = checked (local.NoofFloors - 1);
        int index5 = 0;
        while (index5 <= num9)
        {
          local.Floors[index5].U_Value = 0.15f;
          checked { ++index5; }
        }
        int num10 = checked (local.NoofRoofs - 1);
        int index6 = 0;
        while (index6 <= num10)
        {
          local.Roofs[index6].U_Value = 0.11f;
          checked { ++index6; }
        }
        local.Thermal.ManualHtb = false;
        local.Thermal.YValue = 0.08f;
        local.Thermal.ManualY = true;
        local.TMP.UserDefined = (float) SAP_Module.Calculation2012.Calculation.HeatLoss.Box35;
        local.TMP.Type = "User Value";
        local.Ventilation.MechVent = "Natural ventilation";
        local.Ventilation.Pressure = "As designed";
        local.Ventilation.DesignAir = 7f;
        local.Ventilation.MeasuredAir = 0.0f;
        local.Ventilation.AssumedAir = 0.0f;
        local.Ventilation.Chimneys = 0;
        local.Ventilation.Shelter = 2f;
        local.Ventilation.Flues = 0;
        local.Ventilation.Fires = 0;
        switch (scotlandPackage)
        {
          case 2:
          case 3:
          case 5:
            local.Ventilation.Flues = 1;
            break;
          default:
            local.Ventilation.Flues = 0;
            break;
        }
        local.Ventilation.Fans = (double) num4 <= 80.0 ? 3 : 4;
        local.Orientation = "East";
        local.Overshading = "Average or unknown";
        local.MainHeating = new SAP_Module.MainHeating();
        local.MainHeating = local.MainHeating2;
        string electricityTariff = local.MainHeating.ElectricityTariff;
        local.MainHeating.Emitter = "Systems with radiators";
        local.IncludeMainHeating2 = false;
        local.MainHeating.ElectricityTariff = electricityTariff;
        switch (scotlandPackage)
        {
          case 1:
          case 2:
          case 3:
            local.MainHeating.Fuel = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Fuel;
            local.MainHeating.HGroup = "Boiler systems with radiators or underfloor heating";
            local.MainHeating.SGroup = "Gas boilers and oil boilers";
            local.MainHeating.BSubGroup = "Gas boilers (including LPG) 1998 or later";
            local.MainHeating.InforSource = "Boiler Database";
            local.MainHeating.FuelBurningType = "Modulation";
            local.MainHeating.MainEff = 89f;
            if (scotlandPackage == 1)
            {
              local.MainHeating.Fuel = "mains gas";
              local.MainHeating.SEDBUK = "690103";
            }
            else if (scotlandPackage == 2)
            {
              local.MainHeating.Fuel = "bulk LPG";
              local.MainHeating.SEDBUK = "690104";
              local.MainHeating.Boiler.FlueType = "Room-sealed";
            }
            else if (scotlandPackage == 3)
            {
              local.MainHeating.Fuel = "heating oil";
              local.MainHeating.BSubGroup = "Oil boilers";
              local.MainHeating.SEDBUK = "690105";
              local.MainHeating.MainEff = 90f;
              local.MainHeating.OilPump = true;
            }
            local.MainHeating.Boiler.PumpType = "2013 or later";
            local.MainHeating.Boiler.PumpHP = "Yes";
            break;
          case 4:
            local.MainHeating.Fuel = "Electricity";
            local.MainHeating.MCSCert = true;
            local.MainHeating.HGroup = "Heat pumps with radiators or underfloor heating";
            local.MainHeating.SGroup = "Electric heat pumps";
            local.MainHeating.MHType = "Air source heat pump in other cases";
            local.MainHeating.SAPTableCode = 224;
            local.MainHeating.MainEff = 175.1f;
            local.MainHeating.Boiler.FlowTemp = "Design flow temperature >45°C";
            local.MainHeating.Boiler.PumpHP = "Yes";
            break;
          case 5:
            local.MainHeating.HGroup = "Boiler systems with radiators or underfloor heating";
            local.MainHeating.SGroup = "Solid fuel boilers";
            local.MainHeating.InforSource = "Boiler Database";
            local.MainHeating.MainEff = 86f;
            local.MainHeating.HETAS = "Yes";
            local.MainHeating.Boiler.PumpHP = "Yes";
            local.MainHeating.Fuel = "wood pellets (bulk supply in bags, for main heating)";
            local.MainHeating.SEDBUK = "691101";
            break;
        }
        local.MainHeating.Boiler.PumpType = "2013 or later";
        if ((uint) (scotlandPackage - 1) <= 2U)
        {
          local.MainHeating.Boiler.FlueType = "Room-sealed";
          local.MainHeating.Boiler.FanFlued = "Yes";
        }
        switch (scotlandPackage - 1)
        {
          case 0:
            local.MainHeating.ControlCodePCDFWeather = "696302";
            break;
          case 1:
            local.MainHeating.ControlCodePCDFWeather = "696303";
            break;
          case 2:
            local.MainHeating.ControlCodePCDFWeather = "696304";
            break;
        }
        switch (scotlandPackage - 1)
        {
          case 0:
          case 1:
          case 2:
            local.MainHeating.ControlCode = 2110;
            local.MainHeating.Boiler.BILock = "Yes";
            local.MainHeating.Boiler.LoadWeatherType = "Weather Compensator";
            local.MainHeating.Boiler.LoadWeather = true;
            local.MainHeating.DelayedStart = true;
            break;
          case 3:
            local.MainHeating.ControlCode = 2207;
            break;
          case 4:
            local.MainHeating.ControlCode = 2110;
            local.MainHeating.DelayedStart = true;
            break;
        }
        local.MainHeating.Controls = "Time and temperature zone control by suitable arrangement of plumbing and electrical services";
        local.SecHeating.Fuel = "";
        local.SecHeating.SAPTableCode = 0;
        local.SecHeating.SecEff = 0.0f;
        if ((uint) (scotlandPackage - 2) > 1U)
        {
          if (scotlandPackage == 4)
          {
            local.SecHeating.HGroup = "Room heater";
            local.SecHeating.Fuel = "Electricity";
            local.SecHeating.SAPTableCode = 692;
            local.SecHeating.SecEff = 100f;
          }
        }
        else
        {
          local.SecHeating.HGroup = "Room heater";
          local.SecHeating.SGroup = "Solid fuel room heaters";
          local.SecHeating.Fuel = "wood logs";
          local.SecHeating.MHType = "Closed room heater";
          local.SecHeating.InforSource = "SAP Tables";
          local.SecHeating.SAPTableCode = 633;
          local.SecHeating.HETAS = "No";
          local.SecHeating.SecEff = 60f;
        }
        local.IncludeMainHeating2 = false;
        local.Water = new SAP_Module.Water();
        local.Water.Fuel = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Fuel;
        int num11 = scotlandPackage;
        if (num11 >= 1 && num11 <= 3 || num11 == 5)
        {
          local.Water.System = "From main heating system";
          local.Water.SystemRef = 901;
          local.Water.Fuel = local.MainHeating.Fuel;
        }
        else if (num11 == 4)
        {
          local.Water.System = "Electric immersion (on-peak or off-peak)";
          local.Water.SystemRef = 903;
          local.Water.Fuel = "Electricity";
        }
        local.Water.Cylinder.Timed = true;
        local.Water.Cylinder.Volume = 150f;
        local.Water.Cylinder.ManuSpecified = true;
        local.Water.Cylinder.DeclaredLoss = 1.89f;
        local.Water.Cylinder.PipeWorkInsulated = true;
        local.Water.Cylinder.Thermostat = true;
        local.Water.Cylinder.InHeatedSpace = true;
        local.Water.Cylinder.PipeWorkInsulationType = "Fully insulated primary pipework";
        switch (scotlandPackage)
        {
          case 1:
          case 2:
          case 3:
            local.Renewable.Photovoltaic = new SAP_Module.Photovoltaic();
            local.Renewable.Photovoltaic.Photovoltaics = new SAP_Module.PhotoVoltaics[1];
            local.Renewable.Photovoltaic.Inlcude = false;
            local.Renewable.Photovoltaic.Photovoltaics[0].DirectlyConnected = true;
            local.Renewable.Photovoltaic.Photovoltaics[0].ID = 0;
            local.Renewable.Photovoltaic.Photovoltaics[0].PCOrientation = "South West";
            local.Renewable.Photovoltaic.Photovoltaics[0].POvershading = "None or very little";
            local.Renewable.Photovoltaic.Photovoltaics[0].PPower = num4 * 0.01f;
            local.Renewable.Photovoltaic.Photovoltaics[0].PTilt = "30°";
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(local.PropertyType, "Flat", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(local.PropertyType, "Maisonette", false) == 0)
            {
              double num12 = (double) num4 / (double) checked (local.NoOFDwellingsBelow + local.NoOFDwellingsAbove + 1);
              double num13 = (double) num4 * 0.01;
              local.Renewable.Photovoltaic.Photovoltaics[0].PPower = 0.0414 * num12 >= num13 ? (float) Math.Round(num13, 2) : (float) Math.Round(0.0414 * num12, 2);
            }
            else
              local.Renewable.Photovoltaic.Photovoltaics[0].PPower = (float) Math.Round((double) num4 * 0.01, 2);
            local.Renewable.Photovoltaic.Photovoltaics[0].PTilt = "30°";
            break;
          default:
            local.Renewable.Photovoltaic.Inlcude = false;
            break;
        }
        local.Water.WWHRS = new SAP_Module.WWHRSSystem();
        local.Water.WWHRS.Include = true;
        local.Water.WWHRS.Systems = new SAP_Module.WWHRS_Systems[2];
        local.Water.WWHRS.Systems[0] = new SAP_Module.WWHRS_Systems();
        local.Water.WWHRS.Systems[1] = new SAP_Module.WWHRS_Systems();
        local.Water.WWHRS.Systems[0].SystemsRef = local.Water.WWHRS.Systems[0].SystemsRef;
        local.Water.WWHRS.Systems[1].SystemsRef = local.Water.WWHRS.Systems[1].SystemsRef;
        local.Water.WWHRS.TotalRooms = 1f;
        if ((double) num4 <= 100.0)
        {
          local.Water.WWHRS.Systems[0].WithBath = 0;
          local.Water.WWHRS.Systems[0].WithNoBath = 1;
          local.Water.WWHRS.Systems[0].SystemsRef = "695101";
        }
        if ((double) num4 >= 100.0)
        {
          local.Water.WWHRS.TotalRooms = 2f;
          local.Water.WWHRS.Systems[0].WithBath = 0;
          local.Water.WWHRS.Systems[0].WithNoBath = 1;
          local.Water.WWHRS.Systems[0].SystemsRef = "695101";
          local.Water.WWHRS.Systems[1].WithBath = 0;
          local.Water.WWHRS.Systems[1].WithNoBath = 1;
          local.Water.WWHRS.Systems[1].SystemsRef = "695102";
        }
        local.LowEnergyLight = 100f;
        local.Renewable.AAEGeneration.Inlcude = false;
        local.Renewable.HydroGeneration.Inlcude = false;
        local.Renewable.Special.Include = false;
        local.Renewable.WindTurbine.Inlcude = false;
        local.LessThan125Litre = false;
        local.Cooling.Include = false;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    public static double TER()
    {
      string fuel1 = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Fuel;
      float num1;
      // ISSUE: reference to a compiler-generated method
      switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(fuel1))
      {
        case 157581269:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel1, "heating oil", false) == 0)
          {
            num1 = 1.17f;
            goto label_27;
          }
          else
            goto default;
        case 575487477:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel1, "wood pellets (bulk supply in bags, for main heating)", false) == 0)
            goto label_20;
          else
            goto default;
        case 604697910:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel1, "manufactured smokeless fuel", false) == 0)
            goto label_20;
          else
            goto default;
        case 857289046:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel1, "house coal", false) == 0)
            goto label_20;
          else
            goto default;
        case 975024876:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel1, "bulk LPG", false) == 0)
            break;
          goto default;
        case 1086463322:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel1, "LPG subject to Special Condition 18", false) == 0)
          {
            num1 = 1.1f;
            goto label_27;
          }
          else
            goto default;
        case 1441345278:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel1, "Electricity", false) == 0)
          {
            num1 = 1.55f;
            goto label_27;
          }
          else
            goto default;
        case 1538586610:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel1, "heat from boilers – oil", false) == 0)
            goto label_24;
          else
            goto default;
        case 1597764060:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel1, "mains gas", false) == 0)
            goto label_21;
          else
            goto default;
        case 1770949684:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel1, "appliances able to use mineral oil or liquid biofuel", false) == 0)
            goto label_24;
          else
            goto default;
        case 1860525480:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel1, "heat from electric heat pump", false) == 0)
          {
            num1 = 1.55f;
            goto label_27;
          }
          else
            goto default;
        case 1946790875:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel1, "wood logs", false) == 0)
            goto label_20;
          else
            goto default;
        case 2313921600:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel1, "anthracite", false) == 0)
            goto label_20;
          else
            goto default;
        case 3722837730:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel1, "bottled LPG", false) == 0)
            break;
          goto default;
        case 3794681384:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel1, "LNG", false) == 0)
            goto label_21;
          else
            goto default;
        case 3824947145:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel1, "heat from boilers – coal", false) == 0)
          {
            num1 = 1.28f;
            goto label_27;
          }
          else
            goto default;
        default:
          num1 = 1f;
          goto label_27;
      }
      num1 = 1.06f;
      goto label_27;
label_20:
      num1 = 1.35f;
      goto label_27;
label_21:
      num1 = 1f;
      bool flag = true;
      goto label_27;
label_24:
      num1 = 1.17f;
label_27:
      float num2;
      if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].IncludeMainHeating2)
      {
        string fuel2 = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.Fuel;
        // ISSUE: reference to a compiler-generated method
        switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(fuel2))
        {
          case 157581269:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel2, "heating oil", false) == 0)
            {
              num2 = 1.17f;
              goto label_52;
            }
            else
              goto default;
          case 575487477:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel2, "wood pellets (bulk supply in bags, for main heating)", false) == 0)
              goto label_46;
            else
              goto default;
          case 604697910:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel2, "manufactured smokeless fuel", false) == 0)
              goto label_46;
            else
              goto default;
          case 857289046:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel2, "house coal", false) == 0)
              goto label_46;
            else
              goto default;
          case 975024876:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel2, "bulk LPG", false) == 0)
              break;
            goto default;
          case 1086463322:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel2, "LPG subject to Special Condition 18", false) == 0)
            {
              num2 = 1.1f;
              goto label_52;
            }
            else
              goto default;
          case 1441345278:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel2, "Electricity", false) == 0)
            {
              num2 = 1.55f;
              goto label_52;
            }
            else
              goto default;
          case 1597764060:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel2, "mains gas", false) == 0)
              goto label_47;
            else
              goto default;
          case 1770949684:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel2, "appliances able to use mineral oil or liquid biofuel", false) == 0)
            {
              num2 = 1.17f;
              goto label_52;
            }
            else
              goto default;
          case 1860525480:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel2, "heat from electric heat pump", false) == 0)
            {
              num2 = 1.47f;
              goto label_52;
            }
            else
              goto default;
          case 1946790875:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel2, "wood logs", false) == 0)
              goto label_46;
            else
              goto default;
          case 2313921600:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel2, "anthracite", false) == 0)
              goto label_46;
            else
              goto default;
          case 3722837730:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel2, "bottled LPG", false) == 0)
              break;
            goto default;
          case 3794681384:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel2, "LNG", false) == 0)
              goto label_47;
            else
              goto default;
          default:
            num2 = 1f;
            goto label_52;
        }
        num2 = 1.06f;
        goto label_52;
label_46:
        num2 = 1.28f;
        goto label_52;
label_47:
        num2 = 1f;
        flag = true;
label_52:;
      }
      if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].IncludeMainHeating2 && (double) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].HeatFractionSec > 0.5)
      {
        string fuel3 = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.Fuel;
        // ISSUE: reference to a compiler-generated method
        switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(fuel3))
        {
          case 157581269:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel3, "heating oil", false) == 0)
            {
              num1 = 1.17f;
              goto label_79;
            }
            else
              goto default;
          case 604697910:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel3, "manufactured smokeless fuel", false) == 0)
              goto label_72;
            else
              goto default;
          case 857289046:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel3, "house coal", false) == 0)
              goto label_72;
            else
              goto default;
          case 975024876:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel3, "bulk LPG", false) == 0)
              break;
            goto default;
          case 1086463322:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel3, "LPG subject to Special Condition 18", false) == 0)
            {
              num1 = 1.1f;
              goto label_79;
            }
            else
              goto default;
          case 1441345278:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel3, "Electricity", false) == 0)
            {
              num1 = 1.55f;
              goto label_79;
            }
            else
              goto default;
          case 1538586610:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel3, "heat from boilers – oil", false) == 0)
              goto label_76;
            else
              goto default;
          case 1597764060:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel3, "mains gas", false) == 0)
              goto label_73;
            else
              goto default;
          case 1770949684:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel3, "appliances able to use mineral oil or liquid biofuel", false) == 0)
              goto label_76;
            else
              goto default;
          case 1860525480:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel3, "heat from electric heat pump", false) == 0)
            {
              num1 = 1.47f;
              goto label_79;
            }
            else
              goto default;
          case 2313921600:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel3, "anthracite", false) == 0)
              goto label_72;
            else
              goto default;
          case 3722837730:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel3, "bottled LPG", false) == 0)
              break;
            goto default;
          case 3794681384:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel3, "LNG", false) == 0)
              goto label_73;
            else
              goto default;
          case 3824947145:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel3, "heat from boilers – coal", false) == 0)
            {
              num1 = 1.28f;
              goto label_79;
            }
            else
              goto default;
          default:
            num1 = 1f;
            goto label_79;
        }
        num1 = 1.1f;
        goto label_79;
label_72:
        num1 = 1.28f;
        goto label_79;
label_73:
        num1 = 1f;
        flag = true;
        goto label_79;
label_76:
        num1 = 1.17f;
label_79:;
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.HGroup, "Community heating schemes", false) == 0)
      {
        if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Fuel.Contains("mains gas"))
          num1 = 1f;
        if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.HeatSource1.Fuel != null && SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.NoOfAdditionalHeatSources > 0 & SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.HeatSource1.Fuel.Contains("mains gas"))
          num1 = 1f;
        if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.HeatSource2.Fuel != null && SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.NoOfAdditionalHeatSources > 1 & SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.HeatSource2.Fuel.Contains("mains gas"))
          num1 = 1f;
        if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.HeatSource3.Fuel != null && SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.NoOfAdditionalHeatSources > 2 & SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.HeatSource3.Fuel.Contains("mains gas"))
          num1 = 1f;
        if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.HeatSource4.Fuel != null && SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.NoOfAdditionalHeatSources > 3 & SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.HeatSource4.Fuel.Contains("mains gas"))
          num1 = 1f;
      }
      if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.SystemRef == 950 | SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.SystemRef == 951 | SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.SystemRef == 952)
      {
        if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Fuel.Contains("mains gas"))
          num1 = 1f;
        if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HeatSource1.Fuel != null && SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.NoOfAdditionalHeatSources > 0 & SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HeatSource1.Fuel.Contains("mains gas"))
          num1 = 1f;
        if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HeatSource2.Fuel != null && SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.NoOfAdditionalHeatSources > 1 & SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HeatSource2.Fuel.Contains("mains gas"))
          num1 = 1f;
        if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HeatSource3.Fuel != null && SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.NoOfAdditionalHeatSources > 2 & SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HeatSource3.Fuel.Contains("mains gas"))
          num1 = 1f;
        if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HeatSource4.Fuel != null && SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.NoOfAdditionalHeatSources > 3 & SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HeatSource4.Fuel.Contains("mains gas"))
          num1 = 1f;
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].SecHeating.Fuel, "mains gas", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Fuel, "mains gas", false) == 0)
      {
        num1 = 1f;
        num2 = 1f;
        flag = true;
      }
      if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].IncludeMainHeating2 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.Fuel, "mains gas", false) == 0)
      {
        num1 = 1f;
        num2 = 1f;
        flag = true;
      }
      double num3;
      if (!(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Address.Country, "Northern Ireland", false) == 0 & !flag))
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Address.Country, "Scotland", false) == 0)
        {
          num3 = Math.Round(SAP_Module.CalcualtionTER2012.Calculation.CO2_Emissions_12a.Box272 / SAP_Module.CalcualtionTER2012.Calculation.Dimensions.Box4, 2);
          if (!Functions.DoRedo && SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].IncludeMainHeating2 && !SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.Fuel.Equals(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Fuel))
          {
            Functions.DoRedo = true;
            double num4 = num3 * (1.0 - (double) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].HeatFractionSec);
            Functions.GetTemPScotlandTERDwelling();
            Calc2012 calc2012 = new Calc2012()
            {
              DTER = true
            };
            calc2012.SETPCDF(SAP_Module.PCDFData);
            calc2012.Dwelling = SAP_Module.ScotlandTERDwelling;
            num3 = num4 + calc2012.Calculation.CO2_Emissions_12a.Box273 * (double) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].HeatFractionSec;
            Functions.DoRedo = false;
          }
          if (!Functions.CommunityRedo)
          {
            Functions.CommunityRedo = true;
            string fuel4 = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Fuel;
            int sapTableCode = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SAPTableCode;
            if (sapTableCode >= 306 && sapTableCode <= 310)
            {
              float[] numArray = new float[checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.NoOfAdditionalHeatSources + 1)];
              Calc2012 calc2012 = new Calc2012();
              calc2012.DTER = true;
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Fuel = fuel4;
              Functions.GetTERDwelling();
              SAP_Module.CalcRound = false;
              calc2012.Dwelling = SAP_Module.TERDwelling;
              numArray[0] = (float) Math.Round(calc2012.Calculation.CO2_Emissions_12a.Box272 / calc2012.Calculation.Dimensions.Box4, 2) * SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.Boiler1HeatFraction;
              num3 = (double) numArray[0];
              if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.NoOfAdditionalHeatSources > 0)
              {
                Functions.GetTERDwelling(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.HeatSource1.Fuel, true, 1);
                SAP_Module.CalcRound = false;
                calc2012.Dwelling = SAP_Module.TERDwelling;
                numArray[1] = (float) Math.Round(calc2012.Calculation.CO2_Emissions_12a.Box272 / calc2012.Calculation.Dimensions.Box4, 2) * SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.HeatSource1.HeatFraction;
                double num5 = num3 + (double) numArray[1];
                if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.NoOfAdditionalHeatSources > 1)
                {
                  Functions.GetTERDwelling(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.HeatSource2.Fuel, true, 2);
                  SAP_Module.CalcRound = false;
                  calc2012.Dwelling = SAP_Module.TERDwelling;
                  numArray[2] = (float) Math.Round(calc2012.Calculation.CO2_Emissions_12a.Box272 / calc2012.Calculation.Dimensions.Box4, 2) * SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.HeatSource2.HeatFraction;
                  num5 += (double) numArray[2];
                }
                if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.NoOfAdditionalHeatSources > 2)
                {
                  Functions.GetTERDwelling(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.HeatSource3.Fuel, true, 3);
                  SAP_Module.CalcRound = false;
                  calc2012.Dwelling = SAP_Module.TERDwelling;
                  numArray[3] = (float) Math.Round(calc2012.Calculation.CO2_Emissions_12a.Box272 / calc2012.Calculation.Dimensions.Box4, 2) * SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.HeatSource3.HeatFraction;
                  num5 += (double) numArray[3];
                }
                if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.NoOfAdditionalHeatSources > 3)
                {
                  Functions.GetTERDwelling(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.HeatSource4.Fuel, true, 4);
                  SAP_Module.CalcRound = false;
                  calc2012.Dwelling = SAP_Module.TERDwelling;
                  numArray[4] = (float) Math.Round(calc2012.Calculation.CO2_Emissions_12a.Box272 / calc2012.Calculation.Dimensions.Box4, 2) * SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.HeatSource4.HeatFraction;
                  num5 += (double) numArray[4];
                }
                num3 = Math.Round(num5, 2);
                SAP_Module.CalcRound = true;
                SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Fuel = fuel4;
              }
            }
            Functions.CommunityRedo = false;
          }
        }
        else
          num3 = Math.Round((double) num1 * (SAP_Module.CalcualtionTER2012.Calculation.CO2_Emissions_12a.Box265 / SAP_Module.CalcualtionTER2012.Calculation.Dimensions.Box4) + SAP_Module.CalcualtionTER2012.Calculation.CO2_Emissions_12a.Box268 / SAP_Module.CalcualtionTER2012.Calculation.Dimensions.Box4 + SAP_Module.CalcualtionTER2012.Calculation.CO2_Emissions_12a.Box267 / SAP_Module.CalcualtionTER2012.Calculation.Dimensions.Box4, 2);
      }
      return Math.Round(num3, 2);
    }

    public static SAP_Module.Dwelling CopyDwelling(SAP_Module.Dwelling Dwelling)
    {
      BinaryFormatter binaryFormatter1 = new BinaryFormatter();
      MemoryStream serializationStream = new MemoryStream();
      binaryFormatter1.Serialize((Stream) serializationStream, (object) Dwelling);
      BinaryFormatter binaryFormatter2 = new BinaryFormatter();
      serializationStream.Position = 0L;
      return (SAP_Module.Dwelling) binaryFormatter2.Deserialize((Stream) serializationStream);
    }

    public static void Import()
    {
      try
      {
        MyProject.Forms.SAPForm.OpenFileDialog1.FileName = "";
        MyProject.Forms.SAPForm.OpenFileDialog1.Filter = "Stroma FSAP Dwelling (*.dwl2012)|*.dwl2012";
        int num1 = (int) MyProject.Forms.SAPForm.OpenFileDialog1.ShowDialog();
        MyProject.Forms.SAPForm.OpenFileDialog1.Multiselect = true;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(MyProject.Forms.SAPForm.OpenFileDialog1.FileName, "", false) == 0)
          return;
        string[] fileNames = MyProject.Forms.SAPForm.OpenFileDialog1.FileNames;
        int index = 0;
        while (index < fileNames.Length)
        {
          string FullPath = fileNames[index];
          MyProject.Forms.SAPForm.TreeSAP.SelectedNode = MyProject.Forms.SAPForm.TreeSAP.Nodes[0];
          Application.DoEvents();
          // ISSUE: variable of a reference type
          int& local1;
          // ISSUE: explicit reference operation
          int num2 = checked (^(local1 = ref SAP_Module.Proj.NoOfDwells) + 1);
          local1 = num2;
          // ISSUE: variable of a reference type
          SAP_Module.Dwelling[]& local2;
          // ISSUE: explicit reference operation
          SAP_Module.Dwelling[] dwellingArray = (SAP_Module.Dwelling[]) Microsoft.VisualBasic.CompilerServices.Utils.CopyArray((Array) ^(local2 = ref SAP_Module.Proj.Dwellings), (Array) new SAP_Module.Dwelling[checked (SAP_Module.Proj.NoOfDwells - 1 + 1)]);
          local2 = dwellingArray;
          SAP_Module.Proj.Dwellings[checked (SAP_Module.Proj.NoOfDwells - 1)].Name = "House " + Conversions.ToString(SAP_Module.Proj.NoOfDwells);
          SAP_Module.Proj.Dwellings[checked (SAP_Module.Proj.NoOfDwells - 1)].YearBuilt = DateAndTime.Now.Year;
          SAP_Module.CurrDwelling = checked (SAP_Module.Proj.NoOfDwells - 1);
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling] = Functions.GetDwellingContents(FullPath);
          Validation.Checkerrors_All(SAP_Module.CurrDwelling);
          Functions.MakeTree();
          MyProject.Forms.SAPForm.TreeSAP.SelectedNode = MyProject.Forms.SAPForm.TreeSAP.Nodes[0].Nodes[SAP_Module.CurrDwelling];
          SAP_Write.SaveDetails_Validation(SAP_Module.CurrDwelling);
          checked { ++index; }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) "Error Occured", MsgBoxStyle.Information, (object) "Open File Information");
        ProjectData.ClearProjectError();
      }
      finally
      {
      }
    }

    public static void Import_2005(string[] Files)
    {
      try
      {
        int num1 = checked (Files.Length - 1);
        int index = 0;
        while (index <= num1)
        {
          string file = Files[index];
          MyProject.Forms.SAPForm.TreeSAP.SelectedNode = MyProject.Forms.SAPForm.TreeSAP.Nodes[0];
          Application.DoEvents();
          // ISSUE: variable of a reference type
          int& local1;
          // ISSUE: explicit reference operation
          int num2 = checked (^(local1 = ref SAP_Module.Proj.NoOfDwells) + 1);
          local1 = num2;
          // ISSUE: variable of a reference type
          SAP_Module.Dwelling[]& local2;
          // ISSUE: explicit reference operation
          SAP_Module.Dwelling[] dwellingArray = (SAP_Module.Dwelling[]) Microsoft.VisualBasic.CompilerServices.Utils.CopyArray((Array) ^(local2 = ref SAP_Module.Proj.Dwellings), (Array) new SAP_Module.Dwelling[checked (SAP_Module.Proj.NoOfDwells - 1 + 1)]);
          local2 = dwellingArray;
          SAP_Module.Proj.Dwellings[checked (SAP_Module.Proj.NoOfDwells - 1)].Name = "House " + Conversions.ToString(SAP_Module.Proj.NoOfDwells);
          SAP_Module.Proj.Dwellings[checked (SAP_Module.Proj.NoOfDwells - 1)].YearBuilt = DateAndTime.Now.Year;
          SAP_Module.CurrDwelling = checked (SAP_Module.Proj.NoOfDwells - 1);
          object objectValue;
          try
          {
            FileStream serializationStream = File.Open(file, FileMode.Open);
            objectValue = RuntimeHelpers.GetObjectValue(new BinaryFormatter().Deserialize((Stream) serializationStream));
            serializationStream.Close();
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            int num3 = (int) Interaction.MsgBox((object) Information.Err().Description);
            ProjectData.ClearProjectError();
          }
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling] = Functions.ConvertSAP(RuntimeHelpers.GetObjectValue(objectValue));
          Validation.Checkerrors_All(SAP_Module.CurrDwelling);
          Functions.MakeTree();
          MyProject.Forms.SAPForm.TreeSAP.SelectedNode = MyProject.Forms.SAPForm.TreeSAP.Nodes[0].Nodes[SAP_Module.CurrDwelling];
          SAP_Write.SaveDetails_Validation(SAP_Module.CurrDwelling);
          checked { ++index; }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) "Error Occured", MsgBoxStyle.Information, (object) "Open File Information");
        ProjectData.ClearProjectError();
      }
      finally
      {
      }
    }

    public static void Import_2005(object ProjectImport, int[] Dwellings)
    {
      try
      {
        int num1 = checked (Dwellings.Length - 1);
        int index = 0;
        while (index <= num1)
        {
          MyProject.Forms.SAPForm.TreeSAP.SelectedNode = MyProject.Forms.SAPForm.TreeSAP.Nodes[0];
          Application.DoEvents();
          // ISSUE: variable of a reference type
          int& local1;
          // ISSUE: explicit reference operation
          int num2 = checked (^(local1 = ref SAP_Module.Proj.NoOfDwells) + 1);
          local1 = num2;
          // ISSUE: variable of a reference type
          SAP_Module.Dwelling[]& local2;
          // ISSUE: explicit reference operation
          SAP_Module.Dwelling[] dwellingArray = (SAP_Module.Dwelling[]) Microsoft.VisualBasic.CompilerServices.Utils.CopyArray((Array) ^(local2 = ref SAP_Module.Proj.Dwellings), (Array) new SAP_Module.Dwelling[checked (SAP_Module.Proj.NoOfDwells - 1 + 1)]);
          local2 = dwellingArray;
          ref SAP_Module.Dwelling local3 = ref SAP_Module.Proj.Dwellings[checked (SAP_Module.Proj.NoOfDwells - 1)];
          // ISSUE: variable of a reference type
          int& local4;
          object[] objArray1;
          bool[] flagArray1;
          // ISSUE: explicit reference operation
          object Instance1 = NewLateBinding.LateGet(ProjectImport, (System.Type) null, nameof (Dwellings), objArray1 = new object[1]
          {
            (object) ^(local4 = ref Dwellings[index])
          }, (string[]) null, (System.Type[]) null, flagArray1 = new bool[1]
          {
            true
          });
          if (flagArray1[0])
            local4 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray1[0]), typeof (int));
          string str = Conversions.ToString(NewLateBinding.LateGet(Instance1, (System.Type) null, "name", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local3.Name = str;
          ref SAP_Module.Dwelling local5 = ref SAP_Module.Proj.Dwellings[checked (SAP_Module.Proj.NoOfDwells - 1)];
          // ISSUE: variable of a reference type
          int& local6;
          object[] objArray2;
          bool[] flagArray2;
          // ISSUE: explicit reference operation
          object Instance2 = NewLateBinding.LateGet(ProjectImport, (System.Type) null, nameof (Dwellings), objArray2 = new object[1]
          {
            (object) ^(local6 = ref Dwellings[index])
          }, (string[]) null, (System.Type[]) null, flagArray2 = new bool[1]
          {
            true
          });
          if (flagArray2[0])
            local6 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray2[0]), typeof (int));
          int integer = Conversions.ToInteger(NewLateBinding.LateGet(Instance2, (System.Type) null, "YearBuilt", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local5.YearBuilt = integer;
          SAP_Module.CurrDwelling = checked (SAP_Module.Proj.NoOfDwells - 1);
          SAP_Module.Dwelling[] dwellings = SAP_Module.Proj.Dwellings;
          int currDwelling = SAP_Module.CurrDwelling;
          // ISSUE: variable of a reference type
          int& local7;
          object[] objArray3;
          bool[] flagArray3;
          // ISSUE: explicit reference operation
          object obj = NewLateBinding.LateGet(ProjectImport, (System.Type) null, nameof (Dwellings), objArray3 = new object[1]
          {
            (object) ^(local7 = ref Dwellings[index])
          }, (string[]) null, (System.Type[]) null, flagArray3 = new bool[1]
          {
            true
          });
          if (flagArray3[0])
            local7 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray3[0]), typeof (int));
          SAP_Module.Dwelling dwelling = Functions.ConvertSAP(RuntimeHelpers.GetObjectValue(obj));
          dwellings[currDwelling] = dwelling;
          Validation.Checkerrors_All(SAP_Module.CurrDwelling);
          checked { ++index; }
        }
        Functions.MakeTree();
        MyProject.Forms.SAPForm.TreeSAP.SelectedNode = MyProject.Forms.SAPForm.TreeSAP.Nodes[0].Nodes[SAP_Module.CurrDwelling];
        SAP_Write.SaveDetails_Validation(SAP_Module.CurrDwelling);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) "Error Occured", MsgBoxStyle.Information, (object) "Open File Information");
        ProjectData.ClearProjectError();
      }
      finally
      {
      }
    }

    private static SAP_Module.Dwelling ConvertSAP(object SAP2005)
    {
      SAP_Module.Dwelling dwelling;
      dwelling.Name = Conversions.ToString(NewLateBinding.LateGet(SAP2005, (System.Type) null, "name", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.ID = Conversions.ToInteger(NewLateBinding.LateGet(SAP2005, (System.Type) null, "ID", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Reference = Conversions.ToString(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Reference", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.SAPOnly = Conversions.ToString(NewLateBinding.LateGet(SAP2005, (System.Type) null, "SAPOnly", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Overheat = Conversions.ToString(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Overheat", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Status = Conversions.ToString(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Status", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.DateAssessment = Conversions.ToDate(NewLateBinding.LateGet(SAP2005, (System.Type) null, "DateAssessment", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.DateCertificate = Conversions.ToDate(NewLateBinding.LateGet(SAP2005, (System.Type) null, "DateCertificate", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Transaction = Conversions.ToString(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Transaction", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.RPD = Conversions.ToString(NewLateBinding.LateGet(SAP2005, (System.Type) null, "RPD", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Address.Line1 = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Address", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Line1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Address.Line2 = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Address", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Line2", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Address.Line3 = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Address", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Line3", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Address.City = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Address", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "City", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Address.Country = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Address", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Country", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Address.PostCost = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Address", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "PostCost", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.UPRN = Conversions.ToString(NewLateBinding.LateGet(SAP2005, (System.Type) null, "UPRN", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.PropertyType = Conversions.ToString(NewLateBinding.LateGet(SAP2005, (System.Type) null, "PropertyType", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.BuildForm = Conversions.ToString(NewLateBinding.LateGet(SAP2005, (System.Type) null, "BuildForm", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.FlatType = Conversions.ToString(NewLateBinding.LateGet(SAP2005, (System.Type) null, "FlatType", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.YearBuilt = Conversions.ToInteger(NewLateBinding.LateGet(SAP2005, (System.Type) null, "YearBuilt", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Location = Conversions.ToString(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Location", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.ShelteredSides = Conversions.ToInteger(NewLateBinding.LateGet(SAP2005, (System.Type) null, "ShelteredSides", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Terrain = Conversions.ToString(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Terrain", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Orientation = Conversions.ToString(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Orientation", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.AirCon = !Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(SAP2005, (System.Type) null, "AirCon", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Yes", false) ? "No" : "Yes";
      dwelling.Conservatory = Conversions.ToString(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Conservatory", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      ref SAP_Module.Dwelling local1 = ref dwelling;
      System.Type Type = typeof (Math);
      object[] Arguments = new object[2];
      object Instance1 = SAP2005;
      Arguments[0] = NewLateBinding.LateGet(Instance1, (System.Type) null, "LowEnergyLight", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null);
      Arguments[1] = (object) 1;
      object[] objArray1 = Arguments;
      bool[] CopyBack;
      bool[] flagArray1 = CopyBack = new bool[2]
      {
        true,
        false
      };
      object obj = NewLateBinding.LateGet((object) null, Type, "Round", Arguments, (string[]) null, (System.Type[]) null, CopyBack);
      if (flagArray1[0])
        NewLateBinding.LateSetComplex(Instance1, (System.Type) null, "LowEnergyLight", new object[1]
        {
          objArray1[0]
        }, (string[]) null, (System.Type[]) null, true, false);
      double single1 = (double) Conversions.ToSingle(obj);
      local1.LowEnergyLight = (float) single1;
      dwelling.EPCLanguage = Conversions.ToString(NewLateBinding.LateGet(SAP2005, (System.Type) null, "EPCLanguage", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.SmokeArea = Conversions.ToString(NewLateBinding.LateGet(SAP2005, (System.Type) null, "SmokeArea", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Overshading = Conversions.ToString(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Overshading", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Storeys = Conversions.ToInteger(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Storeys", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.TrueRoof = Conversions.ToBoolean(NewLateBinding.LateGet(SAP2005, (System.Type) null, "TrueRoof", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.LivingArea = Conversions.ToSingle(NewLateBinding.LateGet(SAP2005, (System.Type) null, "LivingArea", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.LivingFraction = Conversions.ToSingle(NewLateBinding.LateGet(SAP2005, (System.Type) null, "LivingFraction", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.LivingFractionSpecified = Conversions.ToBoolean(NewLateBinding.LateGet(SAP2005, (System.Type) null, "LivingFractionSpecified", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Dims = new SAP_Module.Dimensions[checked (dwelling.Storeys - 1 + 1)];
      int num1 = checked (dwelling.Storeys - 1);
      int index1 = 0;
      while (index1 <= num1)
      {
        ref SAP_Module.Dimensions local2 = ref dwelling.Dims[index1];
        object[] objArray2;
        bool[] flagArray2;
        object Instance2 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Dims", objArray2 = new object[1]
        {
          (object) index1
        }, (string[]) null, (System.Type[]) null, flagArray2 = new bool[1]
        {
          true
        });
        if (flagArray2[0])
          index1 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray2[0]), typeof (int));
        string str = Conversions.ToString(NewLateBinding.LateGet(Instance2, (System.Type) null, "Basement", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local2.Basement = str;
        ref SAP_Module.Dimensions local3 = ref dwelling.Dims[index1];
        object[] objArray3;
        bool[] flagArray3;
        object Instance3 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Dims", objArray3 = new object[1]
        {
          (object) index1
        }, (string[]) null, (System.Type[]) null, flagArray3 = new bool[1]
        {
          true
        });
        if (flagArray3[0])
          index1 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray3[0]), typeof (int));
        double single2 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance3, (System.Type) null, "Area", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local3.Area = (float) single2;
        ref SAP_Module.Dimensions local4 = ref dwelling.Dims[index1];
        object[] objArray4;
        bool[] flagArray4;
        object Instance4 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Dims", objArray4 = new object[1]
        {
          (object) index1
        }, (string[]) null, (System.Type[]) null, flagArray4 = new bool[1]
        {
          true
        });
        if (flagArray4[0])
          index1 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray4[0]), typeof (int));
        double single3 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance4, (System.Type) null, "Height", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local4.Height = (float) single3;
        try
        {
          ref SAP_Module.Dims local5 = ref dwelling.Dims[index1].Dims;
          object[] objArray5;
          bool[] flagArray5;
          object Instance5 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Dims", objArray5 = new object[1]
          {
            (object) index1
          }, (string[]) null, (System.Type[]) null, flagArray5 = new bool[1]
          {
            true
          });
          if (flagArray5[0])
            index1 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray5[0]), typeof (int));
          double single4 = (double) Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(Instance5, (System.Type) null, "Dims", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "L1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local5.L1 = (float) single4;
          ref SAP_Module.Dims local6 = ref dwelling.Dims[index1].Dims;
          object[] objArray6;
          bool[] flagArray6;
          object Instance6 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Dims", objArray6 = new object[1]
          {
            (object) index1
          }, (string[]) null, (System.Type[]) null, flagArray6 = new bool[1]
          {
            true
          });
          if (flagArray6[0])
            index1 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray6[0]), typeof (int));
          double single5 = (double) Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(Instance6, (System.Type) null, "Dims", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "L1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local6.W1 = (float) single5;
          ref SAP_Module.Dims local7 = ref dwelling.Dims[index1].Dims;
          object[] objArray7;
          bool[] flagArray7;
          object Instance7 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Dims", objArray7 = new object[1]
          {
            (object) index1
          }, (string[]) null, (System.Type[]) null, flagArray7 = new bool[1]
          {
            true
          });
          if (flagArray7[0])
            index1 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray7[0]), typeof (int));
          double single6 = (double) Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(Instance7, (System.Type) null, "Dims", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "L1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local7.L2 = (float) single6;
          ref SAP_Module.Dims local8 = ref dwelling.Dims[index1].Dims;
          object[] objArray8;
          bool[] flagArray8;
          object Instance8 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Dims", objArray8 = new object[1]
          {
            (object) index1
          }, (string[]) null, (System.Type[]) null, flagArray8 = new bool[1]
          {
            true
          });
          if (flagArray8[0])
            index1 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray8[0]), typeof (int));
          double single7 = (double) Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(Instance8, (System.Type) null, "Dims", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "L1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local8.W2 = (float) single7;
          ref SAP_Module.Dims local9 = ref dwelling.Dims[index1].Dims;
          object[] objArray9;
          bool[] flagArray9;
          object Instance9 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Dims", objArray9 = new object[1]
          {
            (object) index1
          }, (string[]) null, (System.Type[]) null, flagArray9 = new bool[1]
          {
            true
          });
          if (flagArray9[0])
            index1 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray9[0]), typeof (int));
          double single8 = (double) Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(Instance9, (System.Type) null, "Dims", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "L1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local9.L3 = (float) single8;
          ref SAP_Module.Dims local10 = ref dwelling.Dims[index1].Dims;
          object[] objArray10;
          bool[] flagArray10;
          object Instance10 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Dims", objArray10 = new object[1]
          {
            (object) index1
          }, (string[]) null, (System.Type[]) null, flagArray10 = new bool[1]
          {
            true
          });
          if (flagArray10[0])
            index1 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray10[0]), typeof (int));
          double single9 = (double) Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(Instance10, (System.Type) null, "Dims", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "L1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local10.W3 = (float) single9;
          ref SAP_Module.Dims local11 = ref dwelling.Dims[index1].Dims;
          object[] objArray11;
          bool[] flagArray11;
          object Instance11 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Dims", objArray11 = new object[1]
          {
            (object) index1
          }, (string[]) null, (System.Type[]) null, flagArray11 = new bool[1]
          {
            true
          });
          if (flagArray11[0])
            index1 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray11[0]), typeof (int));
          double single10 = (double) Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(Instance11, (System.Type) null, "Dims", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "L1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local11.L4 = (float) single10;
          ref SAP_Module.Dims local12 = ref dwelling.Dims[index1].Dims;
          object[] objArray12;
          bool[] flagArray12;
          object Instance12 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Dims", objArray12 = new object[1]
          {
            (object) index1
          }, (string[]) null, (System.Type[]) null, flagArray12 = new bool[1]
          {
            true
          });
          if (flagArray12[0])
            index1 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray12[0]), typeof (int));
          double single11 = (double) Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(Instance12, (System.Type) null, "Dims", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "L1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local12.W4 = (float) single11;
          ref SAP_Module.Dims local13 = ref dwelling.Dims[index1].Dims;
          object[] objArray13;
          bool[] flagArray13;
          object Instance13 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Dims", objArray13 = new object[1]
          {
            (object) index1
          }, (string[]) null, (System.Type[]) null, flagArray13 = new bool[1]
          {
            true
          });
          if (flagArray13[0])
            index1 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray13[0]), typeof (int));
          double single12 = (double) Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(Instance13, (System.Type) null, "Dims", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "L1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local13.L5 = (float) single12;
          ref SAP_Module.Dims local14 = ref dwelling.Dims[index1].Dims;
          object[] objArray14;
          bool[] flagArray14;
          object Instance14 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Dims", objArray14 = new object[1]
          {
            (object) index1
          }, (string[]) null, (System.Type[]) null, flagArray14 = new bool[1]
          {
            true
          });
          if (flagArray14[0])
            index1 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray14[0]), typeof (int));
          double single13 = (double) Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(Instance14, (System.Type) null, "Dims", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "L1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local14.W5 = (float) single13;
          ref SAP_Module.Dims local15 = ref dwelling.Dims[index1].Dims;
          object[] objArray15;
          bool[] flagArray15;
          object Instance15 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Dims", objArray15 = new object[1]
          {
            (object) index1
          }, (string[]) null, (System.Type[]) null, flagArray15 = new bool[1]
          {
            true
          });
          if (flagArray15[0])
            index1 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray15[0]), typeof (int));
          double single14 = (double) Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(Instance15, (System.Type) null, "Dims", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "L1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local15.L6 = (float) single14;
          ref SAP_Module.Dims local16 = ref dwelling.Dims[index1].Dims;
          object[] objArray16;
          bool[] flagArray16;
          object Instance16 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Dims", objArray16 = new object[1]
          {
            (object) index1
          }, (string[]) null, (System.Type[]) null, flagArray16 = new bool[1]
          {
            true
          });
          if (flagArray16[0])
            index1 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray16[0]), typeof (int));
          double single15 = (double) Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(Instance16, (System.Type) null, "Dims", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "L1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local16.W6 = (float) single15;
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        checked { ++index1; }
      }
      dwelling.GrossAreas = Conversions.ToBoolean(NewLateBinding.LateGet(SAP2005, (System.Type) null, "GrossAreas", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Thermal.ManualHtb = Conversions.ToBoolean(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Thermal", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "ManualHtb", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Thermal.HtbValue = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Thermal", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HtbValue", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Thermal.ConstDetails = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Thermal", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "ConstDetails", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Thermal", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "ConstDetails", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "All detailing conforms with Accredited Construction Details", false))
      {
        dwelling.Thermal.Reference = "SAP05 ACDs";
        dwelling.Thermal.ManualY = true;
        dwelling.Thermal.YValue = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Thermal", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "YValue", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      }
      else
      {
        dwelling.Thermal.ManualY = Conversions.ToBoolean(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Thermal", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "ManualY", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dwelling.Thermal.YValue = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Thermal", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "YValue", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dwelling.Thermal.Reference = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Thermal", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Reference", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      }
      dwelling.NoofFloors = Conversions.ToInteger(NewLateBinding.LateGet(SAP2005, (System.Type) null, "NoofFloors", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Floors = new SAP_Module.Opaques[checked (dwelling.NoofFloors - 1 + 1)];
      int num2 = checked (dwelling.NoofFloors - 1);
      int index2 = 0;
      while (index2 <= num2)
      {
        ref SAP_Module.Opaques local17 = ref dwelling.Floors[index2];
        object[] objArray17;
        bool[] flagArray17;
        object Instance17 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Floors", objArray17 = new object[1]
        {
          (object) index2
        }, (string[]) null, (System.Type[]) null, flagArray17 = new bool[1]
        {
          true
        });
        if (flagArray17[0])
          index2 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray17[0]), typeof (int));
        string str1 = Conversions.ToString(NewLateBinding.LateGet(Instance17, (System.Type) null, "name", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local17.Name = str1;
        ref SAP_Module.Opaques local18 = ref dwelling.Floors[index2];
        object[] objArray18;
        bool[] flagArray18;
        object Instance18 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Floors", objArray18 = new object[1]
        {
          (object) index2
        }, (string[]) null, (System.Type[]) null, flagArray18 = new bool[1]
        {
          true
        });
        if (flagArray18[0])
          index2 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray18[0]), typeof (int));
        string str2 = Conversions.ToString(NewLateBinding.LateGet(Instance18, (System.Type) null, "Type", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local18.Type = str2;
        ref SAP_Module.Opaques local19 = ref dwelling.Floors[index2];
        object[] objArray19;
        bool[] flagArray19;
        object Instance19 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Floors", objArray19 = new object[1]
        {
          (object) index2
        }, (string[]) null, (System.Type[]) null, flagArray19 = new bool[1]
        {
          true
        });
        if (flagArray19[0])
          index2 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray19[0]), typeof (int));
        double single16 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance19, (System.Type) null, "Area", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local19.Area = (float) single16;
        ref SAP_Module.Opaques local20 = ref dwelling.Floors[index2];
        object[] objArray20;
        bool[] flagArray20;
        object Instance20 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Floors", objArray20 = new object[1]
        {
          (object) index2
        }, (string[]) null, (System.Type[]) null, flagArray20 = new bool[1]
        {
          true
        });
        if (flagArray20[0])
          index2 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray20[0]), typeof (int));
        double single17 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance20, (System.Type) null, "U_Value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local20.U_Value = (float) single17;
        ref SAP_Module.Opaques local21 = ref dwelling.Floors[index2];
        object[] objArray21;
        bool[] flagArray21;
        object Instance21 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Floors", objArray21 = new object[1]
        {
          (object) index2
        }, (string[]) null, (System.Type[]) null, flagArray21 = new bool[1]
        {
          true
        });
        if (flagArray21[0])
          index2 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray21[0]), typeof (int));
        double single18 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance21, (System.Type) null, "Ru", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local21.Ru = (float) single18;
        ref SAP_Module.Opaques local22 = ref dwelling.Floors[index2];
        object[] objArray22;
        bool[] flagArray22;
        object Instance22 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Floors", objArray22 = new object[1]
        {
          (object) index2
        }, (string[]) null, (System.Type[]) null, flagArray22 = new bool[1]
        {
          true
        });
        if (flagArray22[0])
          index2 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray22[0]), typeof (int));
        int num3 = Conversions.ToBoolean(NewLateBinding.LateGet(Instance22, (System.Type) null, "Curtain", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)) ? 1 : 0;
        local22.Curtain = num3 != 0;
        ref SAP_Module.Opaques local23 = ref dwelling.Floors[index2];
        object[] objArray23;
        bool[] flagArray23;
        object Instance23 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Floors", objArray23 = new object[1]
        {
          (object) index2
        }, (string[]) null, (System.Type[]) null, flagArray23 = new bool[1]
        {
          true
        });
        if (flagArray23[0])
          index2 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray23[0]), typeof (int));
        string str3 = Conversions.ToString(NewLateBinding.LateGet(Instance23, (System.Type) null, "name", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local23.Name = str3;
        try
        {
          ref SAP_Module.Dims local24 = ref dwelling.Floors[index2].Dims;
          object[] objArray24;
          bool[] flagArray24;
          object Instance24 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Floors", objArray24 = new object[1]
          {
            (object) index2
          }, (string[]) null, (System.Type[]) null, flagArray24 = new bool[1]
          {
            true
          });
          if (flagArray24[0])
            index2 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray24[0]), typeof (int));
          double single19 = (double) Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(Instance24, (System.Type) null, "Dims", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "L1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local24.L1 = (float) single19;
          ref SAP_Module.Dims local25 = ref dwelling.Floors[index2].Dims;
          object[] objArray25;
          bool[] flagArray25;
          object Instance25 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Floors", objArray25 = new object[1]
          {
            (object) index2
          }, (string[]) null, (System.Type[]) null, flagArray25 = new bool[1]
          {
            true
          });
          if (flagArray25[0])
            index2 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray25[0]), typeof (int));
          double single20 = (double) Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(Instance25, (System.Type) null, "Dims", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "L1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local25.W1 = (float) single20;
          ref SAP_Module.Dims local26 = ref dwelling.Floors[index2].Dims;
          object[] objArray26;
          bool[] flagArray26;
          object Instance26 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Floors", objArray26 = new object[1]
          {
            (object) index2
          }, (string[]) null, (System.Type[]) null, flagArray26 = new bool[1]
          {
            true
          });
          if (flagArray26[0])
            index2 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray26[0]), typeof (int));
          double single21 = (double) Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(Instance26, (System.Type) null, "Dims", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "L1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local26.L2 = (float) single21;
          ref SAP_Module.Dims local27 = ref dwelling.Floors[index2].Dims;
          object[] objArray27;
          bool[] flagArray27;
          object Instance27 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Floors", objArray27 = new object[1]
          {
            (object) index2
          }, (string[]) null, (System.Type[]) null, flagArray27 = new bool[1]
          {
            true
          });
          if (flagArray27[0])
            index2 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray27[0]), typeof (int));
          double single22 = (double) Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(Instance27, (System.Type) null, "Dims", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "L1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local27.W2 = (float) single22;
          ref SAP_Module.Dims local28 = ref dwelling.Floors[index2].Dims;
          object[] objArray28;
          bool[] flagArray28;
          object Instance28 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Floors", objArray28 = new object[1]
          {
            (object) index2
          }, (string[]) null, (System.Type[]) null, flagArray28 = new bool[1]
          {
            true
          });
          if (flagArray28[0])
            index2 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray28[0]), typeof (int));
          double single23 = (double) Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(Instance28, (System.Type) null, "Dims", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "L1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local28.L3 = (float) single23;
          ref SAP_Module.Dims local29 = ref dwelling.Floors[index2].Dims;
          object[] objArray29;
          bool[] flagArray29;
          object Instance29 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Floors", objArray29 = new object[1]
          {
            (object) index2
          }, (string[]) null, (System.Type[]) null, flagArray29 = new bool[1]
          {
            true
          });
          if (flagArray29[0])
            index2 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray29[0]), typeof (int));
          double single24 = (double) Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(Instance29, (System.Type) null, "Dims", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "L1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local29.W3 = (float) single24;
          ref SAP_Module.Dims local30 = ref dwelling.Floors[index2].Dims;
          object[] objArray30;
          bool[] flagArray30;
          object Instance30 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Floors", objArray30 = new object[1]
          {
            (object) index2
          }, (string[]) null, (System.Type[]) null, flagArray30 = new bool[1]
          {
            true
          });
          if (flagArray30[0])
            index2 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray30[0]), typeof (int));
          double single25 = (double) Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(Instance30, (System.Type) null, "Dims", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "L1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local30.L4 = (float) single25;
          ref SAP_Module.Dims local31 = ref dwelling.Floors[index2].Dims;
          object[] objArray31;
          bool[] flagArray31;
          object Instance31 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Floors", objArray31 = new object[1]
          {
            (object) index2
          }, (string[]) null, (System.Type[]) null, flagArray31 = new bool[1]
          {
            true
          });
          if (flagArray31[0])
            index2 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray31[0]), typeof (int));
          double single26 = (double) Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(Instance31, (System.Type) null, "Dims", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "L1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local31.W4 = (float) single26;
          ref SAP_Module.Dims local32 = ref dwelling.Floors[index2].Dims;
          object[] objArray32;
          bool[] flagArray32;
          object Instance32 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Floors", objArray32 = new object[1]
          {
            (object) index2
          }, (string[]) null, (System.Type[]) null, flagArray32 = new bool[1]
          {
            true
          });
          if (flagArray32[0])
            index2 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray32[0]), typeof (int));
          double single27 = (double) Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(Instance32, (System.Type) null, "Dims", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "L1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local32.L5 = (float) single27;
          ref SAP_Module.Dims local33 = ref dwelling.Floors[index2].Dims;
          object[] objArray33;
          bool[] flagArray33;
          object Instance33 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Floors", objArray33 = new object[1]
          {
            (object) index2
          }, (string[]) null, (System.Type[]) null, flagArray33 = new bool[1]
          {
            true
          });
          if (flagArray33[0])
            index2 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray33[0]), typeof (int));
          double single28 = (double) Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(Instance33, (System.Type) null, "Dims", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "L1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local33.W5 = (float) single28;
          ref SAP_Module.Dims local34 = ref dwelling.Floors[index2].Dims;
          object[] objArray34;
          bool[] flagArray34;
          object Instance34 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Floors", objArray34 = new object[1]
          {
            (object) index2
          }, (string[]) null, (System.Type[]) null, flagArray34 = new bool[1]
          {
            true
          });
          if (flagArray34[0])
            index2 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray34[0]), typeof (int));
          double single29 = (double) Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(Instance34, (System.Type) null, "Dims", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "L1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local34.L6 = (float) single29;
          ref SAP_Module.Dims local35 = ref dwelling.Floors[index2].Dims;
          object[] objArray35;
          bool[] flagArray35;
          object Instance35 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Floors", objArray35 = new object[1]
          {
            (object) index2
          }, (string[]) null, (System.Type[]) null, flagArray35 = new bool[1]
          {
            true
          });
          if (flagArray35[0])
            index2 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray35[0]), typeof (int));
          double single30 = (double) Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(Instance35, (System.Type) null, "Dims", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "L1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local35.W6 = (float) single30;
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        checked { ++index2; }
      }
      dwelling.NoofWalls = Conversions.ToInteger(NewLateBinding.LateGet(SAP2005, (System.Type) null, "NoofWalls", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Walls = new SAP_Module.Opaques[checked (dwelling.NoofWalls - 1 + 1)];
      int num4 = checked (dwelling.NoofWalls - 1);
      int index3 = 0;
      while (index3 <= num4)
      {
        ref SAP_Module.Opaques local36 = ref dwelling.Walls[index3];
        object[] objArray36;
        bool[] flagArray36;
        object Instance36 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Walls", objArray36 = new object[1]
        {
          (object) index3
        }, (string[]) null, (System.Type[]) null, flagArray36 = new bool[1]
        {
          true
        });
        if (flagArray36[0])
          index3 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray36[0]), typeof (int));
        string str4 = Conversions.ToString(NewLateBinding.LateGet(Instance36, (System.Type) null, "name", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local36.Name = str4;
        ref SAP_Module.Opaques local37 = ref dwelling.Walls[index3];
        object[] objArray37;
        bool[] flagArray37;
        object Instance37 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Walls", objArray37 = new object[1]
        {
          (object) index3
        }, (string[]) null, (System.Type[]) null, flagArray37 = new bool[1]
        {
          true
        });
        if (flagArray37[0])
          index3 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray37[0]), typeof (int));
        string str5 = Conversions.ToString(NewLateBinding.LateGet(Instance37, (System.Type) null, "Type", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local37.Type = str5;
        ref SAP_Module.Opaques local38 = ref dwelling.Walls[index3];
        object[] objArray38;
        bool[] flagArray38;
        object Instance38 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Walls", objArray38 = new object[1]
        {
          (object) index3
        }, (string[]) null, (System.Type[]) null, flagArray38 = new bool[1]
        {
          true
        });
        if (flagArray38[0])
          index3 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray38[0]), typeof (int));
        double single31 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance38, (System.Type) null, "Area", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local38.Area = (float) single31;
        ref SAP_Module.Opaques local39 = ref dwelling.Walls[index3];
        object[] objArray39;
        bool[] flagArray39;
        object Instance39 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Walls", objArray39 = new object[1]
        {
          (object) index3
        }, (string[]) null, (System.Type[]) null, flagArray39 = new bool[1]
        {
          true
        });
        if (flagArray39[0])
          index3 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray39[0]), typeof (int));
        double single32 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance39, (System.Type) null, "U_Value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local39.U_Value = (float) single32;
        ref SAP_Module.Opaques local40 = ref dwelling.Walls[index3];
        object[] objArray40;
        bool[] flagArray40;
        object Instance40 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Walls", objArray40 = new object[1]
        {
          (object) index3
        }, (string[]) null, (System.Type[]) null, flagArray40 = new bool[1]
        {
          true
        });
        if (flagArray40[0])
          index3 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray40[0]), typeof (int));
        double single33 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance40, (System.Type) null, "Ru", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local40.Ru = (float) single33;
        ref SAP_Module.Opaques local41 = ref dwelling.Walls[index3];
        object[] objArray41;
        bool[] flagArray41;
        object Instance41 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Walls", objArray41 = new object[1]
        {
          (object) index3
        }, (string[]) null, (System.Type[]) null, flagArray41 = new bool[1]
        {
          true
        });
        if (flagArray41[0])
          index3 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray41[0]), typeof (int));
        int num5 = Conversions.ToBoolean(NewLateBinding.LateGet(Instance41, (System.Type) null, "Curtain", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)) ? 1 : 0;
        local41.Curtain = num5 != 0;
        ref SAP_Module.Opaques local42 = ref dwelling.Walls[index3];
        object[] objArray42;
        bool[] flagArray42;
        object Instance42 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Walls", objArray42 = new object[1]
        {
          (object) index3
        }, (string[]) null, (System.Type[]) null, flagArray42 = new bool[1]
        {
          true
        });
        if (flagArray42[0])
          index3 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray42[0]), typeof (int));
        string str6 = Conversions.ToString(NewLateBinding.LateGet(Instance42, (System.Type) null, "name", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local42.Name = str6;
        try
        {
          ref SAP_Module.Dims local43 = ref dwelling.Walls[index3].Dims;
          object[] objArray43;
          bool[] flagArray43;
          object Instance43 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Walls", objArray43 = new object[1]
          {
            (object) index3
          }, (string[]) null, (System.Type[]) null, flagArray43 = new bool[1]
          {
            true
          });
          if (flagArray43[0])
            index3 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray43[0]), typeof (int));
          double single34 = (double) Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(Instance43, (System.Type) null, "Dims", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "L1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local43.L1 = (float) single34;
          ref SAP_Module.Dims local44 = ref dwelling.Walls[index3].Dims;
          object[] objArray44;
          bool[] flagArray44;
          object Instance44 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Walls", objArray44 = new object[1]
          {
            (object) index3
          }, (string[]) null, (System.Type[]) null, flagArray44 = new bool[1]
          {
            true
          });
          if (flagArray44[0])
            index3 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray44[0]), typeof (int));
          double single35 = (double) Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(Instance44, (System.Type) null, "Dims", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "L1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local44.W1 = (float) single35;
          ref SAP_Module.Dims local45 = ref dwelling.Walls[index3].Dims;
          object[] objArray45;
          bool[] flagArray45;
          object Instance45 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Walls", objArray45 = new object[1]
          {
            (object) index3
          }, (string[]) null, (System.Type[]) null, flagArray45 = new bool[1]
          {
            true
          });
          if (flagArray45[0])
            index3 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray45[0]), typeof (int));
          double single36 = (double) Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(Instance45, (System.Type) null, "Dims", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "L1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local45.L2 = (float) single36;
          ref SAP_Module.Dims local46 = ref dwelling.Walls[index3].Dims;
          object[] objArray46;
          bool[] flagArray46;
          object Instance46 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Walls", objArray46 = new object[1]
          {
            (object) index3
          }, (string[]) null, (System.Type[]) null, flagArray46 = new bool[1]
          {
            true
          });
          if (flagArray46[0])
            index3 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray46[0]), typeof (int));
          double single37 = (double) Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(Instance46, (System.Type) null, "Dims", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "L1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local46.W2 = (float) single37;
          ref SAP_Module.Dims local47 = ref dwelling.Walls[index3].Dims;
          object[] objArray47;
          bool[] flagArray47;
          object Instance47 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Walls", objArray47 = new object[1]
          {
            (object) index3
          }, (string[]) null, (System.Type[]) null, flagArray47 = new bool[1]
          {
            true
          });
          if (flagArray47[0])
            index3 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray47[0]), typeof (int));
          double single38 = (double) Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(Instance47, (System.Type) null, "Dims", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "L1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local47.L3 = (float) single38;
          ref SAP_Module.Dims local48 = ref dwelling.Walls[index3].Dims;
          object[] objArray48;
          bool[] flagArray48;
          object Instance48 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Walls", objArray48 = new object[1]
          {
            (object) index3
          }, (string[]) null, (System.Type[]) null, flagArray48 = new bool[1]
          {
            true
          });
          if (flagArray48[0])
            index3 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray48[0]), typeof (int));
          double single39 = (double) Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(Instance48, (System.Type) null, "Dims", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "L1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local48.W3 = (float) single39;
          ref SAP_Module.Dims local49 = ref dwelling.Walls[index3].Dims;
          object[] objArray49;
          bool[] flagArray49;
          object Instance49 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Walls", objArray49 = new object[1]
          {
            (object) index3
          }, (string[]) null, (System.Type[]) null, flagArray49 = new bool[1]
          {
            true
          });
          if (flagArray49[0])
            index3 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray49[0]), typeof (int));
          double single40 = (double) Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(Instance49, (System.Type) null, "Dims", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "L1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local49.L4 = (float) single40;
          ref SAP_Module.Dims local50 = ref dwelling.Walls[index3].Dims;
          object[] objArray50;
          bool[] flagArray50;
          object Instance50 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Walls", objArray50 = new object[1]
          {
            (object) index3
          }, (string[]) null, (System.Type[]) null, flagArray50 = new bool[1]
          {
            true
          });
          if (flagArray50[0])
            index3 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray50[0]), typeof (int));
          double single41 = (double) Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(Instance50, (System.Type) null, "Dims", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "L1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local50.W4 = (float) single41;
          ref SAP_Module.Dims local51 = ref dwelling.Walls[index3].Dims;
          object[] objArray51;
          bool[] flagArray51;
          object Instance51 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Walls", objArray51 = new object[1]
          {
            (object) index3
          }, (string[]) null, (System.Type[]) null, flagArray51 = new bool[1]
          {
            true
          });
          if (flagArray51[0])
            index3 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray51[0]), typeof (int));
          double single42 = (double) Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(Instance51, (System.Type) null, "Dims", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "L1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local51.L5 = (float) single42;
          ref SAP_Module.Dims local52 = ref dwelling.Walls[index3].Dims;
          object[] objArray52;
          bool[] flagArray52;
          object Instance52 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Walls", objArray52 = new object[1]
          {
            (object) index3
          }, (string[]) null, (System.Type[]) null, flagArray52 = new bool[1]
          {
            true
          });
          if (flagArray52[0])
            index3 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray52[0]), typeof (int));
          double single43 = (double) Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(Instance52, (System.Type) null, "Dims", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "L1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local52.W5 = (float) single43;
          ref SAP_Module.Dims local53 = ref dwelling.Walls[index3].Dims;
          object[] objArray53;
          bool[] flagArray53;
          object Instance53 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Walls", objArray53 = new object[1]
          {
            (object) index3
          }, (string[]) null, (System.Type[]) null, flagArray53 = new bool[1]
          {
            true
          });
          if (flagArray53[0])
            index3 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray53[0]), typeof (int));
          double single44 = (double) Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(Instance53, (System.Type) null, "Dims", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "L1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local53.L6 = (float) single44;
          ref SAP_Module.Dims local54 = ref dwelling.Walls[index3].Dims;
          object[] objArray54;
          bool[] flagArray54;
          object Instance54 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Walls", objArray54 = new object[1]
          {
            (object) index3
          }, (string[]) null, (System.Type[]) null, flagArray54 = new bool[1]
          {
            true
          });
          if (flagArray54[0])
            index3 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray54[0]), typeof (int));
          double single45 = (double) Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(Instance54, (System.Type) null, "Dims", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "L1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local54.W6 = (float) single45;
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        checked { ++index3; }
      }
      dwelling.NoofRoofs = Conversions.ToInteger(NewLateBinding.LateGet(SAP2005, (System.Type) null, "NoofRoofs", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Roofs = new SAP_Module.Opaques[checked (dwelling.NoofRoofs - 1 + 1)];
      int num6 = checked (dwelling.NoofRoofs - 1);
      int index4 = 0;
      while (index4 <= num6)
      {
        ref SAP_Module.Opaques local55 = ref dwelling.Roofs[index4];
        object[] objArray55;
        bool[] flagArray55;
        object Instance55 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Roofs", objArray55 = new object[1]
        {
          (object) index4
        }, (string[]) null, (System.Type[]) null, flagArray55 = new bool[1]
        {
          true
        });
        if (flagArray55[0])
          index4 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray55[0]), typeof (int));
        string str7 = Conversions.ToString(NewLateBinding.LateGet(Instance55, (System.Type) null, "name", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local55.Name = str7;
        ref SAP_Module.Opaques local56 = ref dwelling.Roofs[index4];
        object[] objArray56;
        bool[] flagArray56;
        object Instance56 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Roofs", objArray56 = new object[1]
        {
          (object) index4
        }, (string[]) null, (System.Type[]) null, flagArray56 = new bool[1]
        {
          true
        });
        if (flagArray56[0])
          index4 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray56[0]), typeof (int));
        string str8 = Conversions.ToString(NewLateBinding.LateGet(Instance56, (System.Type) null, "Type", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local56.Type = str8;
        ref SAP_Module.Opaques local57 = ref dwelling.Roofs[index4];
        object[] objArray57;
        bool[] flagArray57;
        object Instance57 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Roofs", objArray57 = new object[1]
        {
          (object) index4
        }, (string[]) null, (System.Type[]) null, flagArray57 = new bool[1]
        {
          true
        });
        if (flagArray57[0])
          index4 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray57[0]), typeof (int));
        double single46 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance57, (System.Type) null, "Area", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local57.Area = (float) single46;
        ref SAP_Module.Opaques local58 = ref dwelling.Roofs[index4];
        object[] objArray58;
        bool[] flagArray58;
        object Instance58 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Roofs", objArray58 = new object[1]
        {
          (object) index4
        }, (string[]) null, (System.Type[]) null, flagArray58 = new bool[1]
        {
          true
        });
        if (flagArray58[0])
          index4 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray58[0]), typeof (int));
        double single47 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance58, (System.Type) null, "U_Value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local58.U_Value = (float) single47;
        ref SAP_Module.Opaques local59 = ref dwelling.Roofs[index4];
        object[] objArray59;
        bool[] flagArray59;
        object Instance59 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Roofs", objArray59 = new object[1]
        {
          (object) index4
        }, (string[]) null, (System.Type[]) null, flagArray59 = new bool[1]
        {
          true
        });
        if (flagArray59[0])
          index4 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray59[0]), typeof (int));
        double single48 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance59, (System.Type) null, "Ru", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local59.Ru = (float) single48;
        ref SAP_Module.Opaques local60 = ref dwelling.Roofs[index4];
        object[] objArray60;
        bool[] flagArray60;
        object Instance60 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Roofs", objArray60 = new object[1]
        {
          (object) index4
        }, (string[]) null, (System.Type[]) null, flagArray60 = new bool[1]
        {
          true
        });
        if (flagArray60[0])
          index4 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray60[0]), typeof (int));
        int num7 = Conversions.ToBoolean(NewLateBinding.LateGet(Instance60, (System.Type) null, "Curtain", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)) ? 1 : 0;
        local60.Curtain = num7 != 0;
        ref SAP_Module.Opaques local61 = ref dwelling.Roofs[index4];
        object[] objArray61;
        bool[] flagArray61;
        object Instance61 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Roofs", objArray61 = new object[1]
        {
          (object) index4
        }, (string[]) null, (System.Type[]) null, flagArray61 = new bool[1]
        {
          true
        });
        if (flagArray61[0])
          index4 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray61[0]), typeof (int));
        string str9 = Conversions.ToString(NewLateBinding.LateGet(Instance61, (System.Type) null, "name", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local61.Name = str9;
        try
        {
          ref SAP_Module.Dims local62 = ref dwelling.Roofs[index4].Dims;
          object[] objArray62;
          bool[] flagArray62;
          object Instance62 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Roofs", objArray62 = new object[1]
          {
            (object) index4
          }, (string[]) null, (System.Type[]) null, flagArray62 = new bool[1]
          {
            true
          });
          if (flagArray62[0])
            index4 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray62[0]), typeof (int));
          double single49 = (double) Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(Instance62, (System.Type) null, "Dims", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "L1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local62.L1 = (float) single49;
          ref SAP_Module.Dims local63 = ref dwelling.Roofs[index4].Dims;
          object[] objArray63;
          bool[] flagArray63;
          object Instance63 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Roofs", objArray63 = new object[1]
          {
            (object) index4
          }, (string[]) null, (System.Type[]) null, flagArray63 = new bool[1]
          {
            true
          });
          if (flagArray63[0])
            index4 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray63[0]), typeof (int));
          double single50 = (double) Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(Instance63, (System.Type) null, "Dims", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "L1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local63.W1 = (float) single50;
          ref SAP_Module.Dims local64 = ref dwelling.Roofs[index4].Dims;
          object[] objArray64;
          bool[] flagArray64;
          object Instance64 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Roofs", objArray64 = new object[1]
          {
            (object) index4
          }, (string[]) null, (System.Type[]) null, flagArray64 = new bool[1]
          {
            true
          });
          if (flagArray64[0])
            index4 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray64[0]), typeof (int));
          double single51 = (double) Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(Instance64, (System.Type) null, "Dims", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "L1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local64.L2 = (float) single51;
          ref SAP_Module.Dims local65 = ref dwelling.Roofs[index4].Dims;
          object[] objArray65;
          bool[] flagArray65;
          object Instance65 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Roofs", objArray65 = new object[1]
          {
            (object) index4
          }, (string[]) null, (System.Type[]) null, flagArray65 = new bool[1]
          {
            true
          });
          if (flagArray65[0])
            index4 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray65[0]), typeof (int));
          double single52 = (double) Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(Instance65, (System.Type) null, "Dims", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "L1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local65.W2 = (float) single52;
          ref SAP_Module.Dims local66 = ref dwelling.Roofs[index4].Dims;
          object[] objArray66;
          bool[] flagArray66;
          object Instance66 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Roofs", objArray66 = new object[1]
          {
            (object) index4
          }, (string[]) null, (System.Type[]) null, flagArray66 = new bool[1]
          {
            true
          });
          if (flagArray66[0])
            index4 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray66[0]), typeof (int));
          double single53 = (double) Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(Instance66, (System.Type) null, "Dims", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "L1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local66.L3 = (float) single53;
          ref SAP_Module.Dims local67 = ref dwelling.Roofs[index4].Dims;
          object[] objArray67;
          bool[] flagArray67;
          object Instance67 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Roofs", objArray67 = new object[1]
          {
            (object) index4
          }, (string[]) null, (System.Type[]) null, flagArray67 = new bool[1]
          {
            true
          });
          if (flagArray67[0])
            index4 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray67[0]), typeof (int));
          double single54 = (double) Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(Instance67, (System.Type) null, "Dims", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "L1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local67.W3 = (float) single54;
          ref SAP_Module.Dims local68 = ref dwelling.Roofs[index4].Dims;
          object[] objArray68;
          bool[] flagArray68;
          object Instance68 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Roofs", objArray68 = new object[1]
          {
            (object) index4
          }, (string[]) null, (System.Type[]) null, flagArray68 = new bool[1]
          {
            true
          });
          if (flagArray68[0])
            index4 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray68[0]), typeof (int));
          double single55 = (double) Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(Instance68, (System.Type) null, "Dims", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "L1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local68.L4 = (float) single55;
          ref SAP_Module.Dims local69 = ref dwelling.Roofs[index4].Dims;
          object[] objArray69;
          bool[] flagArray69;
          object Instance69 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Roofs", objArray69 = new object[1]
          {
            (object) index4
          }, (string[]) null, (System.Type[]) null, flagArray69 = new bool[1]
          {
            true
          });
          if (flagArray69[0])
            index4 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray69[0]), typeof (int));
          double single56 = (double) Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(Instance69, (System.Type) null, "Dims", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "L1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local69.W4 = (float) single56;
          ref SAP_Module.Dims local70 = ref dwelling.Roofs[index4].Dims;
          object[] objArray70;
          bool[] flagArray70;
          object Instance70 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Roofs", objArray70 = new object[1]
          {
            (object) index4
          }, (string[]) null, (System.Type[]) null, flagArray70 = new bool[1]
          {
            true
          });
          if (flagArray70[0])
            index4 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray70[0]), typeof (int));
          double single57 = (double) Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(Instance70, (System.Type) null, "Dims", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "L1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local70.L5 = (float) single57;
          ref SAP_Module.Dims local71 = ref dwelling.Roofs[index4].Dims;
          object[] objArray71;
          bool[] flagArray71;
          object Instance71 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Roofs", objArray71 = new object[1]
          {
            (object) index4
          }, (string[]) null, (System.Type[]) null, flagArray71 = new bool[1]
          {
            true
          });
          if (flagArray71[0])
            index4 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray71[0]), typeof (int));
          double single58 = (double) Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(Instance71, (System.Type) null, "Dims", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "L1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local71.W5 = (float) single58;
          ref SAP_Module.Dims local72 = ref dwelling.Roofs[index4].Dims;
          object[] objArray72;
          bool[] flagArray72;
          object Instance72 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Roofs", objArray72 = new object[1]
          {
            (object) index4
          }, (string[]) null, (System.Type[]) null, flagArray72 = new bool[1]
          {
            true
          });
          if (flagArray72[0])
            index4 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray72[0]), typeof (int));
          double single59 = (double) Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(Instance72, (System.Type) null, "Dims", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "L1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local72.L6 = (float) single59;
          ref SAP_Module.Dims local73 = ref dwelling.Roofs[index4].Dims;
          object[] objArray73;
          bool[] flagArray73;
          object Instance73 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Roofs", objArray73 = new object[1]
          {
            (object) index4
          }, (string[]) null, (System.Type[]) null, flagArray73 = new bool[1]
          {
            true
          });
          if (flagArray73[0])
            index4 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray73[0]), typeof (int));
          double single60 = (double) Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(Instance73, (System.Type) null, "Dims", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "L1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local73.W6 = (float) single60;
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        checked { ++index4; }
      }
      dwelling.NoofDoors = Conversions.ToInteger(NewLateBinding.LateGet(SAP2005, (System.Type) null, "NoofDoors", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Doors = new SAP_Module.Door[checked (dwelling.NoofDoors - 1 + 1)];
      int num8 = checked (dwelling.NoofDoors - 1);
      int index5 = 0;
      while (index5 <= num8)
      {
        ref SAP_Module.Door local74 = ref dwelling.Doors[index5];
        object[] objArray74;
        bool[] flagArray74;
        object Instance74 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Doors", objArray74 = new object[1]
        {
          (object) index5
        }, (string[]) null, (System.Type[]) null, flagArray74 = new bool[1]
        {
          true
        });
        if (flagArray74[0])
          index5 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray74[0]), typeof (int));
        string str10 = Conversions.ToString(NewLateBinding.LateGet(Instance74, (System.Type) null, "Name", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local74.Name = str10;
        ref SAP_Module.Door local75 = ref dwelling.Doors[index5];
        object[] objArray75;
        bool[] flagArray75;
        object Instance75 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Doors", objArray75 = new object[1]
        {
          (object) index5
        }, (string[]) null, (System.Type[]) null, flagArray75 = new bool[1]
        {
          true
        });
        if (flagArray75[0])
          index5 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray75[0]), typeof (int));
        string str11 = Conversions.ToString(NewLateBinding.LateGet(Instance75, (System.Type) null, "Location", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local75.Location = str11;
        ref SAP_Module.Door local76 = ref dwelling.Doors[index5];
        object[] objArray76;
        bool[] flagArray76;
        object Instance76 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Doors", objArray76 = new object[1]
        {
          (object) index5
        }, (string[]) null, (System.Type[]) null, flagArray76 = new bool[1]
        {
          true
        });
        if (flagArray76[0])
          index5 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray76[0]), typeof (int));
        string str12 = Conversions.ToString(NewLateBinding.LateGet(Instance76, (System.Type) null, "UValueSource", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local76.UValueSource = str12;
        ref SAP_Module.Door local77 = ref dwelling.Doors[index5];
        object[] objArray77;
        bool[] flagArray77;
        object Instance77 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Doors", objArray77 = new object[1]
        {
          (object) index5
        }, (string[]) null, (System.Type[]) null, flagArray77 = new bool[1]
        {
          true
        });
        if (flagArray77[0])
          index5 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray77[0]), typeof (int));
        string str13 = Conversions.ToString(NewLateBinding.LateGet(Instance77, (System.Type) null, "DoorType", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local77.DoorType = str13;
        ref SAP_Module.Door local78 = ref dwelling.Doors[index5];
        object[] objArray78;
        bool[] flagArray78;
        object Instance78 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Doors", objArray78 = new object[1]
        {
          (object) index5
        }, (string[]) null, (System.Type[]) null, flagArray78 = new bool[1]
        {
          true
        });
        if (flagArray78[0])
          index5 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray78[0]), typeof (int));
        string str14 = Conversions.ToString(NewLateBinding.LateGet(Instance78, (System.Type) null, "Orientation", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local78.Orientation = str14;
        ref SAP_Module.Door local79 = ref dwelling.Doors[index5];
        object[] objArray79;
        bool[] flagArray79;
        object Instance79 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Doors", objArray79 = new object[1]
        {
          (object) index5
        }, (string[]) null, (System.Type[]) null, flagArray79 = new bool[1]
        {
          true
        });
        if (flagArray79[0])
          index5 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray79[0]), typeof (int));
        string str15 = Conversions.ToString(NewLateBinding.LateGet(Instance79, (System.Type) null, "Overshading", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local79.Overshading = str15;
        ref SAP_Module.Door local80 = ref dwelling.Doors[index5];
        object[] objArray80;
        bool[] flagArray80;
        object Instance80 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Doors", objArray80 = new object[1]
        {
          (object) index5
        }, (string[]) null, (System.Type[]) null, flagArray80 = new bool[1]
        {
          true
        });
        if (flagArray80[0])
          index5 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray80[0]), typeof (int));
        string str16 = Conversions.ToString(NewLateBinding.LateGet(Instance80, (System.Type) null, "GlazingType", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local80.GlazingType = str16;
        ref SAP_Module.Door local81 = ref dwelling.Doors[index5];
        object[] objArray81;
        bool[] flagArray81;
        object Instance81 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Doors", objArray81 = new object[1]
        {
          (object) index5
        }, (string[]) null, (System.Type[]) null, flagArray81 = new bool[1]
        {
          true
        });
        if (flagArray81[0])
          index5 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray81[0]), typeof (int));
        string str17 = Conversions.ToString(NewLateBinding.LateGet(Instance81, (System.Type) null, "AirGap", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local81.AirGap = str17;
        ref SAP_Module.Door local82 = ref dwelling.Doors[index5];
        object[] objArray82;
        bool[] flagArray82;
        object Instance82 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Doors", objArray82 = new object[1]
        {
          (object) index5
        }, (string[]) null, (System.Type[]) null, flagArray82 = new bool[1]
        {
          true
        });
        if (flagArray82[0])
          index5 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray82[0]), typeof (int));
        string str18 = Conversions.ToString(NewLateBinding.LateGet(Instance82, (System.Type) null, "FrameType", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local82.FrameType = str18;
        ref SAP_Module.Door local83 = ref dwelling.Doors[index5];
        object[] objArray83;
        bool[] flagArray83;
        object Instance83 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Doors", objArray83 = new object[1]
        {
          (object) index5
        }, (string[]) null, (System.Type[]) null, flagArray83 = new bool[1]
        {
          true
        });
        if (flagArray83[0])
          index5 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray83[0]), typeof (int));
        string str19 = Conversions.ToString(NewLateBinding.LateGet(Instance83, (System.Type) null, "ThermalBreak", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local83.ThermalBreak = str19;
        ref SAP_Module.Door local84 = ref dwelling.Doors[index5];
        object[] objArray84;
        bool[] flagArray84;
        object Instance84 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Doors", objArray84 = new object[1]
        {
          (object) index5
        }, (string[]) null, (System.Type[]) null, flagArray84 = new bool[1]
        {
          true
        });
        if (flagArray84[0])
          index5 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray84[0]), typeof (int));
        double single61 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance84, (System.Type) null, "Area", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local84.Area = (float) single61;
        ref SAP_Module.Door local85 = ref dwelling.Doors[index5];
        object[] objArray85;
        bool[] flagArray85;
        object Instance85 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Doors", objArray85 = new object[1]
        {
          (object) index5
        }, (string[]) null, (System.Type[]) null, flagArray85 = new bool[1]
        {
          true
        });
        if (flagArray85[0])
          index5 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray85[0]), typeof (int));
        double single62 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance85, (System.Type) null, "Width", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local85.Width = (float) single62;
        ref SAP_Module.Door local86 = ref dwelling.Doors[index5];
        object[] objArray86;
        bool[] flagArray86;
        object Instance86 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Doors", objArray86 = new object[1]
        {
          (object) index5
        }, (string[]) null, (System.Type[]) null, flagArray86 = new bool[1]
        {
          true
        });
        if (flagArray86[0])
          index5 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray86[0]), typeof (int));
        double single63 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance86, (System.Type) null, "Height", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local86.Height = (float) single63;
        ref SAP_Module.Door local87 = ref dwelling.Doors[index5];
        object[] objArray87;
        bool[] flagArray87;
        object Instance87 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Doors", objArray87 = new object[1]
        {
          (object) index5
        }, (string[]) null, (System.Type[]) null, flagArray87 = new bool[1]
        {
          true
        });
        if (flagArray87[0])
          index5 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray87[0]), typeof (int));
        int integer = Conversions.ToInteger(NewLateBinding.LateGet(Instance87, (System.Type) null, "Count", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local87.Count = integer;
        ref SAP_Module.Door local88 = ref dwelling.Doors[index5];
        object[] objArray88;
        bool[] flagArray88;
        object Instance88 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Doors", objArray88 = new object[1]
        {
          (object) index5
        }, (string[]) null, (System.Type[]) null, flagArray88 = new bool[1]
        {
          true
        });
        if (flagArray88[0])
          index5 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray88[0]), typeof (int));
        double single64 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance88, (System.Type) null, "g", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local88.g = (float) single64;
        ref SAP_Module.Door local89 = ref dwelling.Doors[index5];
        object[] objArray89;
        bool[] flagArray89;
        object Instance89 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Doors", objArray89 = new object[1]
        {
          (object) index5
        }, (string[]) null, (System.Type[]) null, flagArray89 = new bool[1]
        {
          true
        });
        if (flagArray89[0])
          index5 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray89[0]), typeof (int));
        double single65 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance89, (System.Type) null, "FF", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local89.FF = (float) single65;
        ref SAP_Module.Door local90 = ref dwelling.Doors[index5];
        object[] objArray90;
        bool[] flagArray90;
        object Instance90 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Doors", objArray90 = new object[1]
        {
          (object) index5
        }, (string[]) null, (System.Type[]) null, flagArray90 = new bool[1]
        {
          true
        });
        if (flagArray90[0])
          index5 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray90[0]), typeof (int));
        double single66 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance90, (System.Type) null, "U", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local90.U = (float) single66;
        ref SAP_Module.Door local91 = ref dwelling.Doors[index5];
        object[] objArray91;
        bool[] flagArray91;
        object Instance91 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Doors", objArray91 = new object[1]
        {
          (object) index5
        }, (string[]) null, (System.Type[]) null, flagArray91 = new bool[1]
        {
          true
        });
        if (flagArray91[0])
          index5 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray91[0]), typeof (int));
        double single67 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance91, (System.Type) null, "g", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local91.g = (float) single67;
        ref SAP_Module.Door local92 = ref dwelling.Doors[index5];
        object[] objArray92;
        bool[] flagArray92;
        object Instance92 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Doors", objArray92 = new object[1]
        {
          (object) index5
        }, (string[]) null, (System.Type[]) null, flagArray92 = new bool[1]
        {
          true
        });
        if (flagArray92[0])
          index5 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray92[0]), typeof (int));
        string str20 = Conversions.ToString(NewLateBinding.LateGet(Instance92, (System.Type) null, "OpeningType", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local92.OpeningType = str20;
        checked { ++index5; }
      }
      dwelling.NoofWindows = Conversions.ToInteger(NewLateBinding.LateGet(SAP2005, (System.Type) null, "NoofWindows", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Windows = new SAP_Module.Window[checked (dwelling.NoofWindows - 1 + 1)];
      int num9 = checked (dwelling.NoofWindows - 1);
      int index6 = 0;
      while (index6 <= num9)
      {
        ref SAP_Module.Window local93 = ref dwelling.Windows[index6];
        object[] objArray93;
        bool[] flagArray93;
        object Instance93 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Windows", objArray93 = new object[1]
        {
          (object) index6
        }, (string[]) null, (System.Type[]) null, flagArray93 = new bool[1]
        {
          true
        });
        if (flagArray93[0])
          index6 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray93[0]), typeof (int));
        string str21 = Conversions.ToString(NewLateBinding.LateGet(Instance93, (System.Type) null, "Name", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local93.Name = str21;
        ref SAP_Module.Window local94 = ref dwelling.Windows[index6];
        object[] objArray94;
        bool[] flagArray94;
        object Instance94 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Windows", objArray94 = new object[1]
        {
          (object) index6
        }, (string[]) null, (System.Type[]) null, flagArray94 = new bool[1]
        {
          true
        });
        if (flagArray94[0])
          index6 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray94[0]), typeof (int));
        string str22 = Conversions.ToString(NewLateBinding.LateGet(Instance94, (System.Type) null, "Location", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local94.Location = str22;
        object[] objArray95;
        bool[] flagArray95;
        object Instance95 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Windows", objArray95 = new object[1]
        {
          (object) index6
        }, (string[]) null, (System.Type[]) null, flagArray95 = new bool[1]
        {
          true
        });
        if (flagArray95[0])
          index6 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray95[0]), typeof (int));
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(Instance95, (System.Type) null, "UValueSource", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "SAP 2005", false))
        {
          dwelling.Windows[index6].UValueSource = "SAP 2012";
        }
        else
        {
          ref SAP_Module.Window local95 = ref dwelling.Windows[index6];
          object[] objArray96;
          bool[] flagArray96;
          object Instance96 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Windows", objArray96 = new object[1]
          {
            (object) index6
          }, (string[]) null, (System.Type[]) null, flagArray96 = new bool[1]
          {
            true
          });
          if (flagArray96[0])
            index6 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray96[0]), typeof (int));
          string str23 = Conversions.ToString(NewLateBinding.LateGet(Instance96, (System.Type) null, "UValueSource", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local95.UValueSource = str23;
        }
        ref SAP_Module.Window local96 = ref dwelling.Windows[index6];
        object[] objArray97;
        bool[] flagArray97;
        object Instance97 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Windows", objArray97 = new object[1]
        {
          (object) index6
        }, (string[]) null, (System.Type[]) null, flagArray97 = new bool[1]
        {
          true
        });
        if (flagArray97[0])
          index6 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray97[0]), typeof (int));
        string str24 = Conversions.ToString(NewLateBinding.LateGet(Instance97, (System.Type) null, "Orientation", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local96.Orientation = str24;
        ref SAP_Module.Window local97 = ref dwelling.Windows[index6];
        object[] objArray98;
        bool[] flagArray98;
        object Instance98 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Windows", objArray98 = new object[1]
        {
          (object) index6
        }, (string[]) null, (System.Type[]) null, flagArray98 = new bool[1]
        {
          true
        });
        if (flagArray98[0])
          index6 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray98[0]), typeof (int));
        string str25 = Conversions.ToString(NewLateBinding.LateGet(Instance98, (System.Type) null, "Overshading", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local97.Overshading = str25;
        ref SAP_Module.Window local98 = ref dwelling.Windows[index6];
        object[] objArray99;
        bool[] flagArray99;
        object Instance99 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Windows", objArray99 = new object[1]
        {
          (object) index6
        }, (string[]) null, (System.Type[]) null, flagArray99 = new bool[1]
        {
          true
        });
        if (flagArray99[0])
          index6 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray99[0]), typeof (int));
        string str26 = Conversions.ToString(NewLateBinding.LateGet(Instance99, (System.Type) null, "GlazingType", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local98.GlazingType = str26;
        ref SAP_Module.Window local99 = ref dwelling.Windows[index6];
        object[] objArray100;
        bool[] flagArray100;
        object Instance100 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Windows", objArray100 = new object[1]
        {
          (object) index6
        }, (string[]) null, (System.Type[]) null, flagArray100 = new bool[1]
        {
          true
        });
        if (flagArray100[0])
          index6 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray100[0]), typeof (int));
        string str27 = Conversions.ToString(NewLateBinding.LateGet(Instance100, (System.Type) null, "AirGap", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local99.AirGap = str27;
        ref SAP_Module.Window local100 = ref dwelling.Windows[index6];
        object[] objArray101;
        bool[] flagArray101;
        object Instance101 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Windows", objArray101 = new object[1]
        {
          (object) index6
        }, (string[]) null, (System.Type[]) null, flagArray101 = new bool[1]
        {
          true
        });
        if (flagArray101[0])
          index6 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray101[0]), typeof (int));
        string str28 = Conversions.ToString(NewLateBinding.LateGet(Instance101, (System.Type) null, "FrameType", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local100.FrameType = str28;
        ref SAP_Module.Window local101 = ref dwelling.Windows[index6];
        object[] objArray102;
        bool[] flagArray102;
        object Instance102 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Windows", objArray102 = new object[1]
        {
          (object) index6
        }, (string[]) null, (System.Type[]) null, flagArray102 = new bool[1]
        {
          true
        });
        if (flagArray102[0])
          index6 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray102[0]), typeof (int));
        string str29 = Conversions.ToString(NewLateBinding.LateGet(Instance102, (System.Type) null, "ThermalBreak", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local101.ThermalBreak = str29;
        ref SAP_Module.Window local102 = ref dwelling.Windows[index6];
        object[] objArray103;
        bool[] flagArray103;
        object Instance103 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Windows", objArray103 = new object[1]
        {
          (object) index6
        }, (string[]) null, (System.Type[]) null, flagArray103 = new bool[1]
        {
          true
        });
        if (flagArray103[0])
          index6 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray103[0]), typeof (int));
        double single68 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance103, (System.Type) null, "Area", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local102.Area = (float) single68;
        ref SAP_Module.Window local103 = ref dwelling.Windows[index6];
        object[] objArray104;
        bool[] flagArray104;
        object Instance104 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Windows", objArray104 = new object[1]
        {
          (object) index6
        }, (string[]) null, (System.Type[]) null, flagArray104 = new bool[1]
        {
          true
        });
        if (flagArray104[0])
          index6 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray104[0]), typeof (int));
        double single69 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance104, (System.Type) null, "Width", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local103.Width = (float) single69;
        ref SAP_Module.Window local104 = ref dwelling.Windows[index6];
        object[] objArray105;
        bool[] flagArray105;
        object Instance105 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Windows", objArray105 = new object[1]
        {
          (object) index6
        }, (string[]) null, (System.Type[]) null, flagArray105 = new bool[1]
        {
          true
        });
        if (flagArray105[0])
          index6 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray105[0]), typeof (int));
        double single70 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance105, (System.Type) null, "Height", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local104.Height = (float) single70;
        ref SAP_Module.Window local105 = ref dwelling.Windows[index6];
        object[] objArray106;
        bool[] flagArray106;
        object Instance106 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Windows", objArray106 = new object[1]
        {
          (object) index6
        }, (string[]) null, (System.Type[]) null, flagArray106 = new bool[1]
        {
          true
        });
        if (flagArray106[0])
          index6 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray106[0]), typeof (int));
        int integer = Conversions.ToInteger(NewLateBinding.LateGet(Instance106, (System.Type) null, "Count", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local105.Count = integer;
        ref SAP_Module.Window local106 = ref dwelling.Windows[index6];
        object[] objArray107;
        bool[] flagArray107;
        object Instance107 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Windows", objArray107 = new object[1]
        {
          (object) index6
        }, (string[]) null, (System.Type[]) null, flagArray107 = new bool[1]
        {
          true
        });
        if (flagArray107[0])
          index6 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray107[0]), typeof (int));
        double single71 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance107, (System.Type) null, "OverhangWidth", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local106.OverhangWidth = (float) single71;
        ref SAP_Module.Window local107 = ref dwelling.Windows[index6];
        object[] objArray108;
        bool[] flagArray108;
        object Instance108 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Windows", objArray108 = new object[1]
        {
          (object) index6
        }, (string[]) null, (System.Type[]) null, flagArray108 = new bool[1]
        {
          true
        });
        if (flagArray108[0])
          index6 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray108[0]), typeof (int));
        double single72 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance108, (System.Type) null, "OverhangDepth", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local107.OverhangDepth = (float) single72;
        ref SAP_Module.Window local108 = ref dwelling.Windows[index6];
        object[] objArray109;
        bool[] flagArray109;
        object Instance109 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Windows", objArray109 = new object[1]
        {
          (object) index6
        }, (string[]) null, (System.Type[]) null, flagArray109 = new bool[1]
        {
          true
        });
        if (flagArray109[0])
          index6 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray109[0]), typeof (int));
        string str30 = Conversions.ToString(NewLateBinding.LateGet(Instance109, (System.Type) null, "CurtainType", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local108.CurtainType = str30;
        ref SAP_Module.Window local109 = ref dwelling.Windows[index6];
        object[] objArray110;
        bool[] flagArray110;
        object Instance110 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Windows", objArray110 = new object[1]
        {
          (object) index6
        }, (string[]) null, (System.Type[]) null, flagArray110 = new bool[1]
        {
          true
        });
        if (flagArray110[0])
          index6 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray110[0]), typeof (int));
        double single73 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance110, (System.Type) null, "FractionClosed", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local109.FractionClosed = (float) single73;
        ref SAP_Module.Window local110 = ref dwelling.Windows[index6];
        object[] objArray111;
        bool[] flagArray111;
        object Instance111 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Windows", objArray111 = new object[1]
        {
          (object) index6
        }, (string[]) null, (System.Type[]) null, flagArray111 = new bool[1]
        {
          true
        });
        if (flagArray111[0])
          index6 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray111[0]), typeof (int));
        double single74 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance111, (System.Type) null, "g", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local110.g = (float) single74;
        ref SAP_Module.Window local111 = ref dwelling.Windows[index6];
        object[] objArray112;
        bool[] flagArray112;
        object Instance112 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Windows", objArray112 = new object[1]
        {
          (object) index6
        }, (string[]) null, (System.Type[]) null, flagArray112 = new bool[1]
        {
          true
        });
        if (flagArray112[0])
          index6 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray112[0]), typeof (int));
        double single75 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance112, (System.Type) null, "FF", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local111.FF = (float) single75;
        ref SAP_Module.Window local112 = ref dwelling.Windows[index6];
        object[] objArray113;
        bool[] flagArray113;
        object Instance113 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Windows", objArray113 = new object[1]
        {
          (object) index6
        }, (string[]) null, (System.Type[]) null, flagArray113 = new bool[1]
        {
          true
        });
        if (flagArray113[0])
          index6 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray113[0]), typeof (int));
        double single76 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance113, (System.Type) null, "U", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local112.U = (float) single76;
        ref SAP_Module.Window local113 = ref dwelling.Windows[index6];
        object[] objArray114;
        bool[] flagArray114;
        object Instance114 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "Windows", objArray114 = new object[1]
        {
          (object) index6
        }, (string[]) null, (System.Type[]) null, flagArray114 = new bool[1]
        {
          true
        });
        if (flagArray114[0])
          index6 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray114[0]), typeof (int));
        string str31 = Conversions.ToString(NewLateBinding.LateGet(Instance114, (System.Type) null, "OpeningType", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local113.OpeningType = str31;
        checked { ++index6; }
      }
      dwelling.NoofRoofLights = Conversions.ToInteger(NewLateBinding.LateGet(SAP2005, (System.Type) null, "NoofRoofLights", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.RoofLights = new SAP_Module.RoofLight[checked (dwelling.NoofRoofLights - 1 + 1)];
      int num10 = checked (dwelling.NoofRoofLights - 1);
      int index7 = 0;
      while (index7 <= num10)
      {
        ref SAP_Module.RoofLight local114 = ref dwelling.RoofLights[index7];
        object[] objArray115;
        bool[] flagArray115;
        object Instance115 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "RoofLights", objArray115 = new object[1]
        {
          (object) index7
        }, (string[]) null, (System.Type[]) null, flagArray115 = new bool[1]
        {
          true
        });
        if (flagArray115[0])
          index7 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray115[0]), typeof (int));
        string str32 = Conversions.ToString(NewLateBinding.LateGet(Instance115, (System.Type) null, "Name", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local114.Name = str32;
        ref SAP_Module.RoofLight local115 = ref dwelling.RoofLights[index7];
        object[] objArray116;
        bool[] flagArray116;
        object Instance116 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "RoofLights", objArray116 = new object[1]
        {
          (object) index7
        }, (string[]) null, (System.Type[]) null, flagArray116 = new bool[1]
        {
          true
        });
        if (flagArray116[0])
          index7 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray116[0]), typeof (int));
        string str33 = Conversions.ToString(NewLateBinding.LateGet(Instance116, (System.Type) null, "Location", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local115.Location = str33;
        ref SAP_Module.RoofLight local116 = ref dwelling.RoofLights[index7];
        object[] objArray117;
        bool[] flagArray117;
        object Instance117 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "RoofLights", objArray117 = new object[1]
        {
          (object) index7
        }, (string[]) null, (System.Type[]) null, flagArray117 = new bool[1]
        {
          true
        });
        if (flagArray117[0])
          index7 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray117[0]), typeof (int));
        string str34 = Conversions.ToString(NewLateBinding.LateGet(Instance117, (System.Type) null, "UValueSource", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local116.UValueSource = str34;
        ref SAP_Module.RoofLight local117 = ref dwelling.RoofLights[index7];
        object[] objArray118;
        bool[] flagArray118;
        object Instance118 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "RoofLights", objArray118 = new object[1]
        {
          (object) index7
        }, (string[]) null, (System.Type[]) null, flagArray118 = new bool[1]
        {
          true
        });
        if (flagArray118[0])
          index7 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray118[0]), typeof (int));
        double single77 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance118, (System.Type) null, "Pitch", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local117.Pitch = (float) single77;
        ref SAP_Module.RoofLight local118 = ref dwelling.RoofLights[index7];
        object[] objArray119;
        bool[] flagArray119;
        object Instance119 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "RoofLights", objArray119 = new object[1]
        {
          (object) index7
        }, (string[]) null, (System.Type[]) null, flagArray119 = new bool[1]
        {
          true
        });
        if (flagArray119[0])
          index7 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray119[0]), typeof (int));
        string str35 = Conversions.ToString(NewLateBinding.LateGet(Instance119, (System.Type) null, "Orientation", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local118.Orientation = str35;
        ref SAP_Module.RoofLight local119 = ref dwelling.RoofLights[index7];
        object[] objArray120;
        bool[] flagArray120;
        object Instance120 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "RoofLights", objArray120 = new object[1]
        {
          (object) index7
        }, (string[]) null, (System.Type[]) null, flagArray120 = new bool[1]
        {
          true
        });
        if (flagArray120[0])
          index7 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray120[0]), typeof (int));
        string str36 = Conversions.ToString(NewLateBinding.LateGet(Instance120, (System.Type) null, "Overshading", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local119.Overshading = str36;
        ref SAP_Module.RoofLight local120 = ref dwelling.RoofLights[index7];
        object[] objArray121;
        bool[] flagArray121;
        object Instance121 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "RoofLights", objArray121 = new object[1]
        {
          (object) index7
        }, (string[]) null, (System.Type[]) null, flagArray121 = new bool[1]
        {
          true
        });
        if (flagArray121[0])
          index7 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray121[0]), typeof (int));
        string str37 = Conversions.ToString(NewLateBinding.LateGet(Instance121, (System.Type) null, "GlazingType", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local120.GlazingType = str37;
        ref SAP_Module.RoofLight local121 = ref dwelling.RoofLights[index7];
        object[] objArray122;
        bool[] flagArray122;
        object Instance122 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "RoofLights", objArray122 = new object[1]
        {
          (object) index7
        }, (string[]) null, (System.Type[]) null, flagArray122 = new bool[1]
        {
          true
        });
        if (flagArray122[0])
          index7 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray122[0]), typeof (int));
        string str38 = Conversions.ToString(NewLateBinding.LateGet(Instance122, (System.Type) null, "AirGap", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local121.AirGap = str38;
        ref SAP_Module.RoofLight local122 = ref dwelling.RoofLights[index7];
        object[] objArray123;
        bool[] flagArray123;
        object Instance123 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "RoofLights", objArray123 = new object[1]
        {
          (object) index7
        }, (string[]) null, (System.Type[]) null, flagArray123 = new bool[1]
        {
          true
        });
        if (flagArray123[0])
          index7 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray123[0]), typeof (int));
        string str39 = Conversions.ToString(NewLateBinding.LateGet(Instance123, (System.Type) null, "FrameType", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local122.FrameType = str39;
        ref SAP_Module.RoofLight local123 = ref dwelling.RoofLights[index7];
        object[] objArray124;
        bool[] flagArray124;
        object Instance124 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "RoofLights", objArray124 = new object[1]
        {
          (object) index7
        }, (string[]) null, (System.Type[]) null, flagArray124 = new bool[1]
        {
          true
        });
        if (flagArray124[0])
          index7 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray124[0]), typeof (int));
        string str40 = Conversions.ToString(NewLateBinding.LateGet(Instance124, (System.Type) null, "ThermalBreak", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local123.ThermalBreak = str40;
        ref SAP_Module.RoofLight local124 = ref dwelling.RoofLights[index7];
        object[] objArray125;
        bool[] flagArray125;
        object Instance125 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "RoofLights", objArray125 = new object[1]
        {
          (object) index7
        }, (string[]) null, (System.Type[]) null, flagArray125 = new bool[1]
        {
          true
        });
        if (flagArray125[0])
          index7 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray125[0]), typeof (int));
        double single78 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance125, (System.Type) null, "Area", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local124.Area = (float) single78;
        ref SAP_Module.RoofLight local125 = ref dwelling.RoofLights[index7];
        object[] objArray126;
        bool[] flagArray126;
        object Instance126 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "RoofLights", objArray126 = new object[1]
        {
          (object) index7
        }, (string[]) null, (System.Type[]) null, flagArray126 = new bool[1]
        {
          true
        });
        if (flagArray126[0])
          index7 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray126[0]), typeof (int));
        double single79 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance126, (System.Type) null, "Width", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local125.Width = (float) single79;
        ref SAP_Module.RoofLight local126 = ref dwelling.RoofLights[index7];
        object[] objArray127;
        bool[] flagArray127;
        object Instance127 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "RoofLights", objArray127 = new object[1]
        {
          (object) index7
        }, (string[]) null, (System.Type[]) null, flagArray127 = new bool[1]
        {
          true
        });
        if (flagArray127[0])
          index7 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray127[0]), typeof (int));
        double single80 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance127, (System.Type) null, "Height", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local126.Height = (float) single80;
        ref SAP_Module.RoofLight local127 = ref dwelling.RoofLights[index7];
        object[] objArray128;
        bool[] flagArray128;
        object Instance128 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "RoofLights", objArray128 = new object[1]
        {
          (object) index7
        }, (string[]) null, (System.Type[]) null, flagArray128 = new bool[1]
        {
          true
        });
        if (flagArray128[0])
          index7 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray128[0]), typeof (int));
        int integer = Conversions.ToInteger(NewLateBinding.LateGet(Instance128, (System.Type) null, "Count", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local127.Count = integer;
        ref SAP_Module.RoofLight local128 = ref dwelling.RoofLights[index7];
        object[] objArray129;
        bool[] flagArray129;
        object Instance129 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "RoofLights", objArray129 = new object[1]
        {
          (object) index7
        }, (string[]) null, (System.Type[]) null, flagArray129 = new bool[1]
        {
          true
        });
        if (flagArray129[0])
          index7 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray129[0]), typeof (int));
        double single81 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance129, (System.Type) null, "OverhangWidth", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local128.OverhangWidth = (float) single81;
        ref SAP_Module.RoofLight local129 = ref dwelling.RoofLights[index7];
        object[] objArray130;
        bool[] flagArray130;
        object Instance130 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "RoofLights", objArray130 = new object[1]
        {
          (object) index7
        }, (string[]) null, (System.Type[]) null, flagArray130 = new bool[1]
        {
          true
        });
        if (flagArray130[0])
          index7 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray130[0]), typeof (int));
        double single82 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance130, (System.Type) null, "OverhangDepth", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local129.OverhangDepth = (float) single82;
        ref SAP_Module.RoofLight local130 = ref dwelling.RoofLights[index7];
        object[] objArray131;
        bool[] flagArray131;
        object Instance131 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "RoofLights", objArray131 = new object[1]
        {
          (object) index7
        }, (string[]) null, (System.Type[]) null, flagArray131 = new bool[1]
        {
          true
        });
        if (flagArray131[0])
          index7 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray131[0]), typeof (int));
        string str41 = Conversions.ToString(NewLateBinding.LateGet(Instance131, (System.Type) null, "CurtainType", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local130.CurtainType = str41;
        ref SAP_Module.RoofLight local131 = ref dwelling.RoofLights[index7];
        object[] objArray132;
        bool[] flagArray132;
        object Instance132 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "RoofLights", objArray132 = new object[1]
        {
          (object) index7
        }, (string[]) null, (System.Type[]) null, flagArray132 = new bool[1]
        {
          true
        });
        if (flagArray132[0])
          index7 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray132[0]), typeof (int));
        double single83 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance132, (System.Type) null, "FractionClosed", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local131.FractionClosed = (float) single83;
        ref SAP_Module.RoofLight local132 = ref dwelling.RoofLights[index7];
        object[] objArray133;
        bool[] flagArray133;
        object Instance133 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "RoofLights", objArray133 = new object[1]
        {
          (object) index7
        }, (string[]) null, (System.Type[]) null, flagArray133 = new bool[1]
        {
          true
        });
        if (flagArray133[0])
          index7 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray133[0]), typeof (int));
        double single84 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance133, (System.Type) null, "g", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local132.g = (float) single84;
        ref SAP_Module.RoofLight local133 = ref dwelling.RoofLights[index7];
        object[] objArray134;
        bool[] flagArray134;
        object Instance134 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "RoofLights", objArray134 = new object[1]
        {
          (object) index7
        }, (string[]) null, (System.Type[]) null, flagArray134 = new bool[1]
        {
          true
        });
        if (flagArray134[0])
          index7 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray134[0]), typeof (int));
        double single85 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance134, (System.Type) null, "FF", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local133.FF = (float) single85;
        ref SAP_Module.RoofLight local134 = ref dwelling.RoofLights[index7];
        object[] objArray135;
        bool[] flagArray135;
        object Instance135 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "RoofLights", objArray135 = new object[1]
        {
          (object) index7
        }, (string[]) null, (System.Type[]) null, flagArray135 = new bool[1]
        {
          true
        });
        if (flagArray135[0])
          index7 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray135[0]), typeof (int));
        double single86 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance135, (System.Type) null, "U", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local134.U = (float) single86;
        ref SAP_Module.RoofLight local135 = ref dwelling.RoofLights[index7];
        object[] objArray136;
        bool[] flagArray136;
        object Instance136 = NewLateBinding.LateGet(SAP2005, (System.Type) null, "RoofLights", objArray136 = new object[1]
        {
          (object) index7
        }, (string[]) null, (System.Type[]) null, flagArray136 = new bool[1]
        {
          true
        });
        if (flagArray136[0])
          index7 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray136[0]), typeof (int));
        string str42 = Conversions.ToString(NewLateBinding.LateGet(Instance136, (System.Type) null, "OpeningType", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local135.OpeningType = str42;
        checked { ++index7; }
      }
      dwelling.Ventilation.Chimneys = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Ventilation", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Chimneys", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Ventilation.Flues = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Ventilation", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Flues", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Ventilation.Fans = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Ventilation", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Fans", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Ventilation.Vents = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Ventilation", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Vents", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Ventilation.Fires = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Ventilation", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Fires", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Ventilation.Shelter = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Ventilation", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Shelter", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Ventilation.MechVent = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Ventilation", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "MechVent", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Ventilation.Parameters = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Ventilation", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Parameters", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Ventilation.WetRooms = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Ventilation", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "WetRooms", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Ventilation.DuctType = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Ventilation", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "DuctType", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Ventilation.ProductID = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Ventilation", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "ProductID", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Ventilation.ProductName = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Ventilation", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "ProductName", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Ventilation.Decentralised.KSPF1 = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Ventilation", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Decentralised", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "KSPF1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Ventilation.Decentralised.KSPF2 = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Ventilation", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Decentralised", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "KSPF2", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Ventilation.Decentralised.KSPF3 = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Ventilation", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Decentralised", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "KSPF3", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Ventilation.Decentralised.OSPF1 = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Ventilation", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Decentralised", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "OSPF1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Ventilation.Decentralised.OSPF2 = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Ventilation", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Decentralised", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "OSPF2", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Ventilation.Decentralised.OSPF3 = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Ventilation", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Decentralised", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "OSPF3", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Ventilation.Decentralised.KTP1 = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Ventilation", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Decentralised", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "KTP1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Ventilation.Decentralised.KTP2 = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Ventilation", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Decentralised", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "KTP2", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Ventilation.Decentralised.KTP3 = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Ventilation", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Decentralised", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "KTP3", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Ventilation.Decentralised.OTP1 = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Ventilation", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Decentralised", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "OTP1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Ventilation.Decentralised.OTP2 = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Ventilation", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Decentralised", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "OTP2", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Ventilation.Decentralised.OTP3 = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Ventilation", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Decentralised", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "OTP3", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Ventilation.MVDetails.ProductName = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Ventilation", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "MVDetails", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "ProductName", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Ventilation.MVDetails.DuctingType = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Ventilation", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "MVDetails", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "DuctingType", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Ventilation.MVDetails.SFP = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Ventilation", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "MVDetails", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "SFP", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Ventilation.MVDetails.HEE = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Ventilation", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "MVDetails", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HEE", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Ventilation.Pressure = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Ventilation", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Pressure", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Ventilation.DesignAir = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Ventilation", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "DesignAir", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Ventilation.MeasuredAir = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Ventilation", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "MeasuredAir", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Ventilation.DateAir = Conversions.ToDate(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Ventilation", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "DateAir", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Ventilation.AssumedAir = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Ventilation", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "AssumedAir", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Ventilation.Infiltration.Construction = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Ventilation", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Infiltration", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Construction", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Ventilation.Infiltration.Lobby = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Ventilation", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Infiltration", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Lobby", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Ventilation.Infiltration.Floor = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Ventilation", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Infiltration", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Floor", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Ventilation.Infiltration.DraguthP = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Ventilation", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Infiltration", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "DraguthP", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Ventilation.Draught = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Ventilation", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Draught", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.MainHeating.ElectricityTariff = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "MainHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "ElectricityTariff", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      object Left = NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "MainHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "SAPTableCode", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null);
      if (!Conversions.ToBoolean((object) (bool) (!Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectGreaterEqual(Left, (object) 301, false)) ? 0 : (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectLessEqual(Left, (object) 305, false)) ? 1 : 0))))
      {
        dwelling.MainHeating.HGroup = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "MainHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HGroup", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dwelling.MainHeating.SGroup = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "MainHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "SGroup", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dwelling.MainHeating.InforSource = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "MainHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "InforSource", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dwelling.MainHeating.BSubGroup = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "MainHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "BSubGroup", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dwelling.MainHeating.MHType = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "MainHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "MHType", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dwelling.MainHeating.Emitter = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "MainHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Emitter", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dwelling.MainHeating.Controls = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "MainHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Controls", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dwelling.MainHeating.DelayedStart = Conversions.ToBoolean(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "MainHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "DelayedStart", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dwelling.MainHeating.Fuel = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "MainHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Fuel", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dwelling.MainHeating.SEDBUK = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "MainHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "SEDBUK", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dwelling.MainHeating.Boiler.PumpHP = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "MainHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Boiler", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "PumpHP", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dwelling.MainHeating.Boiler.BILock = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "MainHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Boiler", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "BILock", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dwelling.MainHeating.Boiler.Description = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "MainHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Boiler", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Description", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dwelling.MainHeating.Boiler.FlueType = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "MainHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Boiler", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "FlueType", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dwelling.MainHeating.Boiler.FanFlued = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "MainHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Boiler", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "FanFlued", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dwelling.MainHeating.Boiler.IncludeKeepHot = Conversions.ToBoolean(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "MainHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Boiler", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "IncludeKeepHot", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dwelling.MainHeating.Boiler.KeepHotFuel = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "MainHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Boiler", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "KeepHotFuel", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dwelling.MainHeating.Boiler.KeepHotTimed = Conversions.ToBoolean(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "MainHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Boiler", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "KeepHotTimed", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dwelling.MainHeating.Boiler.LoadWeather = Conversions.ToBoolean(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "MainHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Boiler", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "LoadWeather", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dwelling.MainHeating.Boiler.LoadWeatherType = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "MainHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Boiler", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "LoadWeatherType", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dwelling.MainHeating.MainEff = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "MainHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "MainEff", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dwelling.MainHeating.SAPTableCode = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "MainHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "SAPTableCode", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dwelling.MainHeating.ControlCode = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "MainHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "ControlCode", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dwelling.MainHeating.TableGroup = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "MainHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "TableGroup", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dwelling.MainHeating.HETAS = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "MainHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HETAS", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dwelling.MainHeating.Compensator = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "MainHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Compensator", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dwelling.MainHeating.Range.CasekW = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "MainHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Range", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "CasekW", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dwelling.MainHeating.Range.WaterkW = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "MainHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Range", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "WaterkW", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dwelling.MainHeating.OilPump = Conversions.ToBoolean(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "MainHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "OilPump", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      }
      dwelling.SecHeating.HGroup = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "SecHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HGroup", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.SecHeating.SGroup = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "SecHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "SGroup", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.SecHeating.InforSource = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "SecHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "InforSource", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.SecHeating.MHType = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "SecHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "MHType", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.SecHeating.TestMethod = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "SecHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "TestMethod", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.SecHeating.Fuel = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "SecHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Fuel", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.SecHeating.HETAS = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "SecHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HETAS", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.SecHeating.SecEff = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "SecHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "SecEff", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.SecHeating.SAPTableCode = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "SecHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "SAPTableCode", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.SecHeating.MDescription = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "SecHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "MDescription", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.SecHeating.FlueType = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "SecHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "FlueType", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Water.Solar.Inlcude = Conversions.ToBoolean(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Solar", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Inlcude", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Water.Solar.SolarType = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Solar", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "SolarType", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Water.Solar.Overide = Conversions.ToBoolean(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Solar", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Overide", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Water.Solar.SolarZero = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Solar", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "SolarZero", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Water.Solar.SolarHLoss = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Solar", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "SolarHLoss", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Water.Solar.SolarArea = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Solar", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "SolarArea", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Water.Solar.Gross = Conversions.ToBoolean(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Solar", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Gross", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Water.Solar.SolarTilt = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Solar", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "SolarTilt", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Water.Solar.SolarOrientation = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Solar", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "SolarOrientation", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Water.Solar.SolarOvershading = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Solar", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "SolarOvershading", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Water.Solar.SolarVolume = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Solar", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "SolarVolume", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Water.Solar.SolarSeperate = Conversions.ToBoolean(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Solar", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "SolarSeperate", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Water.Solar.Pumped = Conversions.ToBoolean(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Solar", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Pumped", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Water.System = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "System", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Water.SystemRef = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "SystemRef", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Water.Fuel = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Fuel", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Water.Cylinder.Volume = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Cylinder", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Volume", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Water.Cylinder.ManuSpecified = Conversions.ToBoolean(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Cylinder", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "ManuSpecified", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Water.Cylinder.DeclaredLoss = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Cylinder", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "DeclaredLoss", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Water.Cylinder.Insulation = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Cylinder", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Insulation", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Water.Cylinder.InsThick = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Cylinder", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "InsThick", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Water.Cylinder.InHeatedSpace = Conversions.ToBoolean(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Cylinder", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "InHeatedSpace", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Water.Cylinder.Thermostat = Conversions.ToBoolean(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Cylinder", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Thermostat", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Water.Cylinder.PipeWorkInsulated = Conversions.ToBoolean(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Cylinder", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "PipeWorkInsulated", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Water.Cylinder.Timed = Conversions.ToBoolean(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Cylinder", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Timed", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Water.Cylinder.SummerImmersion = Conversions.ToBoolean(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Cylinder", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "SummerImmersion", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Water.Cylinder.Immersion = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Cylinder", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Immersion", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Water.Cylinder.HPImmersion = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Cylinder", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HPImmersion", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Water.CPSUTemp = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "CPSUTemp", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Water.HWSComm.CylinderInDwelling = Conversions.ToBoolean(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HWSComm", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "CylinderInDwelling", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Water.HWSComm.CHPRatio = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HWSComm", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "CHPRatio", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Water.HWSComm.HDS = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HWSComm", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HDS", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Water.HWSComm.Efficiency = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HWSComm", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Efficiency", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Water.Thermal.Include = Conversions.ToBoolean(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Thermal", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Include", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Water.Thermal.Type = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Thermal", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Type", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Water.Thermal.Location = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Thermal", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Location", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Water.Thermal.Connection = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Thermal", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Connection", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Water.CombiType = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "CombiType", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Renewable.WindTurbine.Inlcude = Conversions.ToBoolean(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Renewable", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "WindTurbine", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Inlcude", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Renewable.WindTurbine.WNumber = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Renewable", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "WindTurbine", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "WNumber", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Renewable.WindTurbine.WRDiameter = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Renewable", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "WindTurbine", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "WRDiameter", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Renewable.WindTurbine.WHeight = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Renewable", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "WindTurbine", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "WHeight", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Renewable.Photovoltaic.Inlcude = Conversions.ToBoolean(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Renewable", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Photovoltaic", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Inlcude", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      if (dwelling.Renewable.Photovoltaic.Inlcude)
      {
        dwelling.Renewable.Photovoltaic.Photovoltaics = new SAP_Module.PhotoVoltaics[1];
        dwelling.Renewable.Photovoltaic.Photovoltaics[0].ID = 0;
        dwelling.Renewable.Photovoltaic.Photovoltaics[0].PPower = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Renewable", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Photovoltaic", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "PPower", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dwelling.Renewable.Photovoltaic.Photovoltaics[0].PTilt = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Renewable", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Photovoltaic", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "PTilt", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dwelling.Renewable.Photovoltaic.Photovoltaics[0].PCOrientation = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Renewable", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Photovoltaic", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "PCOrientation", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dwelling.Renewable.Photovoltaic.Photovoltaics[0].POvershading = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Renewable", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Photovoltaic", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "POvershading", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      }
      dwelling.Renewable.Special.Include = Conversions.ToBoolean(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Renewable", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Special", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Include", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      if (dwelling.Renewable.Special.Include)
      {
        dwelling.Renewable.Special.Special = new SAP_Module.SpecialFeatures[1];
        dwelling.Renewable.Special.Special[0].Description = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Renewable", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Special", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Description", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dwelling.Renewable.Special.Special[0].EnergySaved = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Renewable", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Special", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "EnergySaved", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dwelling.Renewable.Special.Special[0].FuelSaved = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Renewable", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Special", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "FuelSaved", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dwelling.Renewable.Special.Special[0].EnergyUsed = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Renewable", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Special", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "EnergyUsed", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dwelling.Renewable.Special.Special[0].FuelUsed = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Renewable", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Special", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "FuelUsed", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      }
      dwelling.Renewable.AAEGeneration.Inlcude = Conversions.ToBoolean(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Renewable", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "AAEGeneration", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Inlcude", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Renewable.AAEGeneration.EGenerated = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Renewable", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "AAEGeneration", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "EGenerated", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Renewable.AAEGeneration.TotalArea = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "Renewable", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "AAEGeneration", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "TotalArea", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.OverHeating.EACBuildType = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "OverHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "EACBuildType", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.OverHeating.EACWindow = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "OverHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "EACWindow", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.OverHeating.EACOveride = Conversions.ToBoolean(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "OverHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "EACOveride", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.OverHeating.EACAirChange = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "OverHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "EACAirChange", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.OverHeating.TMIllustrative = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "OverHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "TMIllustrative", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.OverHeating.TMOveride = Conversions.ToBoolean(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "OverHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "TMOveride", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.OverHeating.TMTMP = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2005, (System.Type) null, "OverHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "TMTMP", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling = dwelling;
      return dwelling;
    }

    public static void export()
    {
      SAP_Write.SaveDetails();
      MyProject.Forms.SAPForm.SaveFileDialog1.Filter = "Stroma FSAP Dwelling (*.dwl2012)|*.dwl2012";
      int num = (int) MyProject.Forms.SAPForm.SaveFileDialog1.ShowDialog();
      string fileName = MyProject.Forms.SAPForm.SaveFileDialog1.FileName;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fileName, "", false) == 0)
        return;
      Functions.SaveDwelling(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling], fileName);
    }

    public static bool SaveDwelling(SAP_Module.Dwelling strData, string FullPath)
    {
      FileStream serializationStream = File.Open(FullPath, FileMode.OpenOrCreate);
      BinaryFormatter binaryFormatter = new BinaryFormatter();
      bool flag;
      try
      {
        binaryFormatter.Serialize((Stream) serializationStream, (object) strData);
        serializationStream.Close();
        flag = true;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) Information.Err().Description);
        flag = false;
        ProjectData.ClearProjectError();
      }
      return flag;
    }

    public static SAP_Module.Dwelling GetDwellingContents(string FullPath)
    {
      SAP_Module.Dwelling dwellingContents = new SAP_Module.Dwelling();
      try
      {
        FileStream serializationStream = File.Open(FullPath, FileMode.Open);
        dwellingContents = (SAP_Module.Dwelling) new BinaryFormatter().Deserialize((Stream) serializationStream);
        serializationStream.Close();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) Information.Err().Description);
        ProjectData.ClearProjectError();
      }
      return dwellingContents;
    }

    public static SAP_Module.Door CopyDoor(SAP_Module.Door Door)
    {
      BinaryFormatter binaryFormatter1 = new BinaryFormatter();
      MemoryStream serializationStream = new MemoryStream();
      binaryFormatter1.Serialize((Stream) serializationStream, (object) Door);
      BinaryFormatter binaryFormatter2 = new BinaryFormatter();
      serializationStream.Position = 0L;
      return (SAP_Module.Door) binaryFormatter2.Deserialize((Stream) serializationStream);
    }

    public static SAP_Module.Window CopyWindow(SAP_Module.Window Window)
    {
      BinaryFormatter binaryFormatter1 = new BinaryFormatter();
      MemoryStream serializationStream = new MemoryStream();
      binaryFormatter1.Serialize((Stream) serializationStream, (object) Window);
      BinaryFormatter binaryFormatter2 = new BinaryFormatter();
      serializationStream.Position = 0L;
      return (SAP_Module.Window) binaryFormatter2.Deserialize((Stream) serializationStream);
    }

    public static SAP_Module.RoofLight CopyRoofLight(SAP_Module.RoofLight RoofLight)
    {
      BinaryFormatter binaryFormatter1 = new BinaryFormatter();
      MemoryStream serializationStream = new MemoryStream();
      binaryFormatter1.Serialize((Stream) serializationStream, (object) RoofLight);
      BinaryFormatter binaryFormatter2 = new BinaryFormatter();
      serializationStream.Position = 0L;
      return (SAP_Module.RoofLight) binaryFormatter2.Deserialize((Stream) serializationStream);
    }

    public static float CalcMissingEff(string ID)
    {
      float num1;
      try
      {
        PCDF.SEDBUK_Solid sedbukSolid = SAP_Module.PCDFData.Solid_Boilers.Where<PCDF.SEDBUK_Solid>((Func<PCDF.SEDBUK_Solid, bool>) (b => b.ID.Equals(ID))).SingleOrDefault<PCDF.SEDBUK_Solid>();
        num1 = (float) (100.0 * ((Conversion.Val(sedbukSolid.room_full) + Conversion.Val(sedbukSolid.water_full)) / Conversion.Val(sedbukSolid.input_full)));
        if (Conversion.Val(sedbukSolid.input_part) != 0.0)
          num1 += (float) (50.0 * ((Conversion.Val(sedbukSolid.water_part) + Conversion.Val(sedbukSolid.room_part)) / Conversion.Val(sedbukSolid.input_part)));
        else
          num1 *= 0.975f;
        num1 = (float) Math.Round((double) num1, 1);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num2 = (int) Interaction.MsgBox((object) "An error has occured during boiler efficiency calculation, please contact Stroma Accreditation", MsgBoxStyle.Critical, (object) "Error");
        ProjectData.ClearProjectError();
      }
      return num1;
    }

    public static void FillFiles()
    {
      try
      {
        int num1 = checked (MyProject.Forms.SAPForm.RecentProjectsToolStripMenuItem.DropDownItems.Count - 1);
        int index1 = 0;
        while (index1 <= num1)
        {
          MyProject.Forms.SAPForm.RecentProjectsToolStripMenuItem.DropDownItems[index1].Visible = false;
          checked { ++index1; }
        }
        int num2 = checked (UserSettings.USettings.Files.Length - 1);
        int index2 = 0;
        while (index2 <= num2)
        {
          MyProject.Forms.SAPForm.RecentProjectsToolStripMenuItem.DropDownItems[index2].Text = UserSettings.USettings.Files[index2];
          MyProject.Forms.SAPForm.RecentProjectsToolStripMenuItem.DropDownItems[index2].Visible = true;
          MyProject.Forms.SAPForm.RecentProjectsToolStripMenuItem.Visible = true;
          checked { ++index2; }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    public static void AddFile(string File)
    {
      try
      {
        bool flag;
        int num1;
        if (UserSettings.USettings.Files != null)
        {
          int num2 = checked (UserSettings.USettings.Files.Length - 1);
          int index = 0;
          while (index <= num2)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(UserSettings.USettings.Files[index], File, false) == 0)
            {
              flag = true;
              num1 = index;
              break;
            }
            checked { ++index; }
          }
          if (UserSettings.USettings.Files.Length <= 11 & !flag)
          {
            // ISSUE: variable of a reference type
            string[]& local;
            // ISSUE: explicit reference operation
            string[] strArray = (string[]) Microsoft.VisualBasic.CompilerServices.Utils.CopyArray((Array) ^(local = ref UserSettings.USettings.Files), (Array) new string[checked (UserSettings.USettings.Files.Length + 1)]);
            local = strArray;
          }
        }
        else
        {
          // ISSUE: variable of a reference type
          string[]& local;
          // ISSUE: explicit reference operation
          string[] strArray = (string[]) Microsoft.VisualBasic.CompilerServices.Utils.CopyArray((Array) ^(local = ref UserSettings.USettings.Files), (Array) new string[1]);
          local = strArray;
        }
        if (!flag)
        {
          int index = checked (UserSettings.USettings.Files.Length - 1);
          while (index >= 1)
          {
            UserSettings.USettings.Files[index] = UserSettings.USettings.Files[checked (index - 1)];
            checked { index += -1; }
          }
        }
        else
        {
          int index = num1;
          while (index >= 1)
          {
            UserSettings.USettings.Files[index] = UserSettings.USettings.Files[checked (index - 1)];
            checked { index += -1; }
          }
        }
        UserSettings.USettings.Files[0] = File;
        Functions.FillFiles();
        try
        {
          object folderPath = (object) Environment.GetFolderPath(Environment.SpecialFolder.Personal);
          DirectoryInfo directoryInfo = new DirectoryInfo(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(folderPath, (object) "\\Stroma SAP 2012")));
          if (!directoryInfo.Exists)
            directoryInfo.Create();
          FileInfo fileInfo = new FileInfo(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(folderPath, (object) "\\Stroma SAP 2012\\Settings.set")));
          UserSettings.SaveSettings(UserSettings.USettings, fileInfo.FullName);
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

    public static string FindNewDwellingRatingNI(int house)
    {
      SAP_Module.Calculation2012.DTER = false;
      Functions.CalculateNow();
      double num1 = (SAP_Module.CalcualtionTER2012.Calculation.Fuel_costs_10a.Box240 != 0.0 ? SAP_Module.CalcualtionTER2012.Calculation.Fuel_costs_10a.Box240 + SAP_Module.CalcualtionTER2012.Calculation.Fuel_costs_10a.Box241 + SAP_Module.CalcualtionTER2012.Calculation.Fuel_costs_10a.Box242 : SAP_Module.CalcualtionTER2012.Calculation.Fuel_costs_10b.Box340a + SAP_Module.CalcualtionTER2012.Calculation.Fuel_costs_10b.Box340b + SAP_Module.CalcualtionTER2012.Calculation.Fuel_costs_10b.Box340c + SAP_Module.CalcualtionTER2012.Calculation.Fuel_costs_10b.Box340d + SAP_Module.CalcualtionTER2012.Calculation.Fuel_costs_10b.Box340e + SAP_Module.CalcualtionTER2012.Calculation.Fuel_costs_10b.Box342a + SAP_Module.CalcualtionTER2012.Calculation.Fuel_costs_10b.Box342b + SAP_Module.CalcualtionTER2012.Calculation.Fuel_costs_10b.Box342c + SAP_Module.CalcualtionTER2012.Calculation.Fuel_costs_10b.Box342d + SAP_Module.CalcualtionTER2012.Calculation.Fuel_costs_10b.Box342e + SAP_Module.CalcualtionTER2012.Calculation.Fuel_costs_10b.Box341) + (SAP_Module.CalcualtionTER2012.Calculation.Fuel_costs_10a.Box243 + SAP_Module.CalcualtionTER2012.Calculation.Actual_costs_10a.Box247 != 0.0 ? SAP_Module.CalcualtionTER2012.Calculation.Fuel_costs_10a.Box243 + SAP_Module.CalcualtionTER2012.Calculation.Fuel_costs_10a.Box247 : SAP_Module.CalcualtionTER2012.Calculation.Fuel_costs_10b.Box343 + SAP_Module.CalcualtionTER2012.Calculation.Fuel_costs_10b.Box347) + (SAP_Module.CalcualtionTER2012.Calculation.Fuel_costs_10a.Box249 != 0.0 ? SAP_Module.CalcualtionTER2012.Calculation.Fuel_costs_10a.Box249 : SAP_Module.CalcualtionTER2012.Calculation.Fuel_costs_10b.Box349);
      double num2 = SAP_Module.CalcualtionTER2012.Calculation.Fuel_costs_10a.Box250 != 0.0 ? SAP_Module.CalcualtionTER2012.Calculation.Fuel_costs_10a.Box250 : SAP_Module.CalcualtionTER2012.Calculation.Fuel_costs_10b.Box350;
      double num3 = 274.0 / 265.0;
      double num4 = SAP_Module.CalcualtionTER2012.Calculation.Actual_costs_10a.Box250 != 0.0 ? 0.517 / SAP_Module.CalcualtionTER2012.Calculation.CO2_Emissions_12a.Box263E : 0.517 / SAP_Module.CalcualtionTER2012.Calculation.CO2_Emissions_12b.Box363E;
      string dwellingRatingNi = Microsoft.VisualBasic.Strings.Format((object) Math.Round(100.0 - 13.95 * ((num1 * 1.14 * 1.17 * num3 + num2 * num4) * 0.6 * 0.47 / (SAP_Module.Calculation2012.Calculation.Dimensions.Box4 + 45.0))));
      Functions.CalculateNow();
      return dwellingRatingNi;
    }

    public static double Ene1Rating(double P7)
    {
      double num;
      try
      {
        string country = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Address.Country;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(country, "England", false) != 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(country, "Wales", false) == 0)
            num = Functions.E49Wales(P7);
        }
        else
          num = Functions.E49England(P7);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        num = 0.0;
        ProjectData.ClearProjectError();
      }
      return num;
    }

    private static double E49England(double P7)
    {
      double num = P7;
      if (num == double.MaxValue)
        return double.MaxValue;
      if (num < 0.6)
        return 0.0;
      if (num < 1.2)
        return 0.1;
      if (num < 1.8)
        return 0.2;
      if (num < 2.4)
        return 0.3;
      if (num < 3.0)
        return 0.4;
      if (num < 3.6)
        return 0.5;
      if (num < 4.2)
        return 0.6;
      if (num < 4.8)
        return 0.7;
      if (num < 5.4)
        return 0.8;
      if (num < 6.0)
        return 0.9;
      if (num < 6.6)
        return 1.0;
      if (num < 7.2)
        return 1.1;
      if (num < 7.8)
        return 1.2;
      if (num < 8.4)
        return 1.3;
      if (num < 9.0)
        return 1.4;
      if (num < 9.6)
        return 1.5;
      if (num < 10.2)
        return 1.6;
      if (num < 10.8)
        return 1.7;
      if (num < 11.4)
        return 1.8;
      if (num < 12.0)
        return 1.9;
      if (num < 12.7)
        return 2.0;
      if (num < 13.4)
        return 2.1;
      if (num < 14.1)
        return 2.2;
      if (num < 14.8)
        return 2.3;
      if (num < 15.5)
        return 2.4;
      if (num < 16.2)
        return 2.5;
      if (num < 16.9)
        return 2.6;
      if (num < 17.6)
        return 2.7;
      if (num < 18.3)
        return 2.8;
      if (num < 19.0)
        return 2.9;
      if (num < 20.3)
        return 3.0;
      if (num < 21.6)
        return 3.1;
      if (num < 22.9)
        return 3.2;
      if (num < 24.2)
        return 3.3;
      if (num < 25.5)
        return 3.4;
      if (num < 26.8)
        return 3.5;
      if (num < 28.1)
        return 3.6;
      if (num < 29.4)
        return 3.7;
      if (num < 30.7)
        return 3.8;
      if (num < 32.0)
        return 3.9;
      if (num < 33.2)
        return 4.0;
      if (num < 34.4)
        return 4.1;
      if (num < 35.6)
        return 4.2;
      if (num < 36.8)
        return 4.3;
      if (num < 38.0)
        return 4.4;
      if (num < 39.2)
        return 4.5;
      if (num < 40.4)
        return 4.6;
      if (num < 41.6)
        return 4.7;
      if (num < 42.8)
        return 4.8;
      if (num < 44.0)
        return 4.9;
      if (num < 45.2)
        return 5.0;
      if (num < 46.4)
        return 5.1;
      if (num < 47.6)
        return 5.2;
      if (num < 48.8)
        return 5.3;
      if (num < 50.0)
        return 5.4;
      if (num < 51.2)
        return 5.5;
      if (num < 52.4)
        return 5.6;
      if (num < 53.6)
        return 5.7;
      if (num < 54.8)
        return 5.8;
      if (num < 56.0)
        return 5.9;
      if (num < 57.4)
        return 6.0;
      if (num < 58.8)
        return 6.1;
      if (num < 60.2)
        return 6.2;
      if (num < 61.6)
        return 6.3;
      if (num < 63.0)
        return 6.4;
      if (num < 64.4)
        return 6.5;
      if (num < 65.8)
        return 6.6;
      if (num < 67.2)
        return 6.7;
      if (num < 68.6)
        return 6.8;
      if (num < 70.0)
        return 6.9;
      if (num < 71.4)
        return 7.0;
      if (num < 72.8)
        return 7.1;
      if (num < 74.2)
        return 7.2;
      if (num < 75.6)
        return 7.3;
      if (num < 77.0)
        return 7.4;
      if (num < 78.4)
        return 7.5;
      if (num < 79.8)
        return 7.6;
      if (num < 81.2)
        return 7.7;
      if (num < 82.6)
        return 7.8;
      if (num < 84.0)
        return 7.9;
      if (num < 85.6)
        return 8.0;
      if (num < 87.2)
        return 8.1;
      if (num < 88.8)
        return 8.2;
      if (num < 90.4)
        return 8.3;
      if (num < 92.0)
        return 8.4;
      if (num < 93.6)
        return 8.5;
      if (num < 95.2)
        return 8.6;
      if (num < 96.8)
        return 8.7;
      if (num < 98.4)
        return 8.8;
      if (num < 100.0)
        return 8.9;
      return num >= 100.0 ? 9.0 : double.MaxValue;
    }

    private static double E49Wales(double P7)
    {
      double num = P7;
      if (num == double.MaxValue)
        return double.MaxValue;
      if (num < 0.4)
        return 0.0;
      if (num < 0.8)
        return 0.1;
      if (num < 1.2)
        return 0.2;
      if (num < 1.6)
        return 0.3;
      if (num < 2.0)
        return 0.4;
      if (num < 2.4)
        return 0.5;
      if (num < 2.8)
        return 0.6;
      if (num < 3.2)
        return 0.7;
      if (num < 3.6)
        return 0.8;
      if (num < 4.0)
        return 0.9;
      if (num < 4.6)
        return 1.0;
      if (num < 5.2)
        return 1.1;
      if (num < 5.8)
        return 1.2;
      if (num < 6.4)
        return 1.3;
      if (num < 7.0)
        return 1.4;
      if (num < 7.6)
        return 1.5;
      if (num < 8.2)
        return 1.6;
      if (num < 8.8)
        return 1.7;
      if (num < 9.4)
        return 1.8;
      if (num < 10.0)
        return 1.9;
      if (num < 10.7)
        return 2.0;
      if (num < 11.4)
        return 2.1;
      if (num < 12.1)
        return 2.2;
      if (num < 12.8)
        return 2.3;
      if (num < 13.5)
        return 2.4;
      if (num < 14.2)
        return 2.5;
      if (num < 14.9)
        return 2.6;
      if (num < 15.6)
        return 2.7;
      if (num < 16.3)
        return 2.8;
      if (num < 17.0)
        return 2.9;
      if (num < 18.3)
        return 3.0;
      if (num < 19.6)
        return 3.1;
      if (num < 20.9)
        return 3.2;
      if (num < 22.2)
        return 3.3;
      if (num < 23.5)
        return 3.4;
      if (num < 24.8)
        return 3.5;
      if (num < 26.1)
        return 3.6;
      if (num < 27.4)
        return 3.7;
      if (num < 28.7)
        return 3.8;
      if (num < 30.0)
        return 3.9;
      if (num < 31.2)
        return 4.0;
      if (num < 32.4)
        return 4.1;
      if (num < 33.6)
        return 4.2;
      if (num < 34.8)
        return 4.3;
      if (num < 36.0)
        return 4.4;
      if (num < 37.2)
        return 4.5;
      if (num < 38.4)
        return 4.6;
      if (num < 39.6)
        return 4.7;
      if (num < 40.8)
        return 4.8;
      if (num < 42.0)
        return 4.9;
      if (num < 43.3)
        return 5.0;
      if (num < 44.6)
        return 5.1;
      if (num < 45.9)
        return 5.2;
      if (num < 47.2)
        return 5.3;
      if (num < 48.5)
        return 5.4;
      if (num < 49.8)
        return 5.5;
      if (num < 51.1)
        return 5.6;
      if (num < 52.4)
        return 5.7;
      if (num < 53.7)
        return 5.8;
      if (num < 55.0)
        return 5.9;
      if (num < 56.5)
        return 6.0;
      if (num < 58.0)
        return 6.1;
      if (num < 59.5)
        return 6.2;
      if (num < 61.0)
        return 6.3;
      if (num < 62.5)
        return 6.4;
      if (num < 64.0)
        return 6.5;
      if (num < 65.5)
        return 6.6;
      if (num < 67.0)
        return 6.7;
      if (num < 68.5)
        return 6.8;
      if (num < 70.0)
        return 6.9;
      if (num < 71.4)
        return 7.0;
      if (num < 72.8)
        return 7.1;
      if (num < 74.2)
        return 7.2;
      if (num < 75.6)
        return 7.3;
      if (num < 77.0)
        return 7.4;
      if (num < 78.4)
        return 7.5;
      if (num < 79.8)
        return 7.6;
      if (num < 81.2)
        return 7.7;
      if (num < 82.6)
        return 7.8;
      if (num < 84.0)
        return 7.9;
      if (num < 85.6)
        return 8.0;
      if (num < 87.2)
        return 8.1;
      if (num < 88.8)
        return 8.2;
      if (num < 90.4)
        return 8.3;
      if (num < 92.0)
        return 8.4;
      if (num < 93.6)
        return 8.5;
      if (num < 95.2)
        return 8.6;
      if (num < 96.8)
        return 8.7;
      if (num < 98.4)
        return 8.8;
      if (num < 100.0)
        return 8.9;
      return num >= 100.0 ? 9.0 : double.MaxValue;
    }

    public static double Ene2Rating(double FEE, int House)
    {
      FEE = Math.Round(FEE, 2);
      string propertyType = SAP_Module.Proj.Dwellings[House].PropertyType;
      int num1;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(propertyType, nameof (House), false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(propertyType, "Bungalow", false) != 0)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(propertyType, "Flat", false) == 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(propertyType, "Maisonette", false) == 0)
          num1 = 1;
      }
      else
        num1 = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].BuildForm, "Mid-terrace", false) == 0 ? 1 : 2;
      int num2;
      int num3;
      int num4;
      int num5;
      if (num1 == 1)
      {
        double num6 = FEE;
        if (num6 <= 32.0)
          return 9.0;
        if (num6 <= 35.0)
        {
          num2 = 35;
          num3 = 32;
          num4 = 9;
          num5 = 8;
        }
        else if (num6 <= 39.0)
        {
          num2 = 39;
          num3 = 35;
          num4 = 8;
          num5 = 7;
        }
        else if (num6 <= 41.0)
        {
          num2 = 41;
          num3 = 39;
          num4 = 7;
          num5 = 6;
        }
        else if (num6 <= 43.0)
        {
          num2 = 43;
          num3 = 41;
          num4 = 6;
          num5 = 5;
        }
        else if (num6 <= 45.0)
        {
          num2 = 45;
          num3 = 43;
          num4 = 5;
          num5 = 4;
        }
        else
        {
          if (num6 > 48.0)
            return 0.0;
          num2 = 48;
          num3 = 45;
          num4 = 4;
          num5 = 3;
        }
      }
      else
      {
        double num7 = FEE;
        if (num7 <= 38.0)
          return 9.0;
        if (num7 <= 42.0)
        {
          num2 = 42;
          num3 = 38;
          num4 = 9;
          num5 = 8;
        }
        else if (num7 <= 46.0)
        {
          num2 = 46;
          num3 = 42;
          num4 = 8;
          num5 = 7;
        }
        else if (num7 <= 49.0)
        {
          num2 = 49;
          num3 = 46;
          num4 = 7;
          num5 = 6;
        }
        else if (num7 <= 52.0)
        {
          num2 = 52;
          num3 = 49;
          num4 = 6;
          num5 = 5;
        }
        else if (num7 <= 55.0)
        {
          num2 = 55;
          num3 = 52;
          num4 = 5;
          num5 = 4;
        }
        else
        {
          if (num7 > 60.0)
            return 0.0;
          num2 = 60;
          num3 = 55;
          num4 = 4;
          num5 = 3;
        }
      }
      return Math.Round((double) num5 + ((double) num2 - FEE) * (double) checked (num4 - num5) / (double) checked (num2 - num3), 1);
    }

    public static int GetScotland_Package(string Fuel)
    {
      string str = Fuel;
      int scotlandPackage;
      // ISSUE: reference to a compiler-generated method
      switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(str))
      {
        case 157581269:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "heating oil", false) == 0)
            goto label_39;
          else
            goto default;
        case 335024745:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "heat from boilers – biogas", false) == 0)
            goto label_40;
          else
            goto default;
        case 575487477:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "wood pellets (bulk supply in bags, for main heating)", false) == 0)
            goto label_40;
          else
            goto default;
        case 604697910:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "manufactured smokeless fuel", false) == 0)
            goto label_39;
          else
            goto default;
        case 721524493:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "dual fuel appliance (mineral and wood)", false) == 0)
            goto label_40;
          else
            goto default;
        case 857289046:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "house coal", false) == 0)
            goto label_40;
          else
            goto default;
        case 975024876:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "bulk LPG", false) == 0)
            goto label_38;
          else
            goto default;
        case 1086463322:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "LPG subject to Special Condition 18", false) == 0)
            goto label_38;
          else
            goto default;
        case 1384014791:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "B30K", false) == 0)
            goto label_39;
          else
            goto default;
        case 1424221758:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "geothermal heat source", false) == 0)
            goto label_40;
          else
            goto default;
        case 1441345278:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Electricity", false) == 0)
            break;
          goto default;
        case 1522447619:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "wood chips", false) == 0)
            goto label_40;
          else
            goto default;
        case 1538586610:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "heat from boilers – oil", false) == 0)
            goto label_39;
          else
            goto default;
        case 1597764060:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "mains gas", false) == 0)
            goto label_37;
          else
            goto default;
        case 1623787443:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "10-hour tariff (on-peak)", false) == 0)
            break;
          goto default;
        case 1770949684:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "appliances able to use mineral oil or liquid biofuel", false) == 0)
            goto label_39;
          else
            goto default;
        case 1860525480:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "heat from electric heat pump", false) == 0)
            break;
          goto default;
        case 1880739446:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "24-hour tariff", false) == 0)
            break;
          goto default;
        case 1946790875:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "wood logs", false) == 0)
            goto label_40;
          else
            goto default;
        case 1956632141:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "7-hour tariff (on-peak)", false) == 0)
            break;
          goto default;
        case 2251322125:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "wood pellets (in bags, for secondary heating)", false) == 0)
            goto label_40;
          else
            goto default;
        case 2313921600:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "anthracite", false) == 0)
            goto label_40;
          else
            goto default;
        case 2340757125:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "heat from boilers - waste combustion", false) == 0)
            goto label_40;
          else
            goto default;
        case 2343415715:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "waste heat from power stations", false) == 0)
            goto label_40;
          else
            goto default;
        case 2487325169:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "10-hour tariff (off-peak)", false) == 0)
            break;
          goto default;
        case 3198893402:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "rapeseed oil", false) == 0)
            goto label_39;
          else
            goto default;
        case 3216529428:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "heat from boilers – biomass", false) == 0)
            goto label_40;
          else
            goto default;
        case 3349323758:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "biodiesel from any biomass source", false) == 0)
            goto label_40;
          else
            goto default;
        case 3398809853:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "heat from boilers – B30D", false) == 0)
            goto label_39;
          else
            goto default;
        case 3722837730:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "bottled LPG", false) == 0)
            goto label_38;
          else
            goto default;
        case 3794681384:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "LNG", false) == 0)
            goto label_37;
          else
            goto default;
        case 3836938347:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "7-hour tariff (off-peak)", false) == 0)
            break;
          goto default;
        case 4020509270:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "standard tariff", false) == 0)
            break;
          goto default;
        case 4235694608:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "biodiesel from used cooking oil only", false) == 0)
            goto label_40;
          else
            goto default;
        case 4241528165:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "heat from boilers – mains gas", false) == 0)
            goto label_37;
          else
            goto default;
        default:
label_41:
          return scotlandPackage;
      }
      scotlandPackage = 4;
      goto label_41;
label_37:
      scotlandPackage = 1;
      goto label_41;
label_38:
      scotlandPackage = 2;
      goto label_41;
label_39:
      scotlandPackage = 3;
      goto label_41;
label_40:
      scotlandPackage = 5;
      goto label_41;
    }

    public static bool LodgementLock(int House)
    {
      bool flag = false;
      try
      {
        if (SAP_Module.Proj.Dwellings[House].Lodgement != null)
        {
          int num = checked (((IEnumerable<SAP_Module.Lodgement>) SAP_Module.Proj.Dwellings[House].Lodgement).Count<SAP_Module.Lodgement>() - 1);
          int index = 0;
          while (index <= num)
          {
            if (SAP_Module.Proj.Dwellings[House].Lodgement[index].Success)
              flag = true;
            checked { ++index; }
          }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      return flag;
    }

    public static T DeepClone<T>(ref T orig)
    {
      T obj;
      if (object.ReferenceEquals((object) orig, (object) null))
      {
        obj = default (T);
      }
      else
      {
        BinaryFormatter binaryFormatter = new BinaryFormatter();
        MemoryStream serializationStream = new MemoryStream();
        binaryFormatter.Serialize((Stream) serializationStream, (object) orig);
        serializationStream.Seek(0L, SeekOrigin.Begin);
        obj = Conversions.ToGenericParameter<T>(binaryFormatter.Deserialize((Stream) serializationStream));
      }
      return obj;
    }
  }
}
