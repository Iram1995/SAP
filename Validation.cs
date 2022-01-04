
// Type: SAP2012.Validation




using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using SAP2012.My;
using SAP2012.SAPRef;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SAP2012
{
  [StandardModule]
  internal sealed class Validation
  {
    public static bool UserLogged;
    public static bool PredicatedCheck;
    public static bool OldFormat;
    public static bool FirstFile;
    public static string RefNum;
    public static string AssessorNO;
    public static string AssessorFN;
    public static string EA_Prefix;
    public static string AssessorLN;
    public static string EA_Suffix;
    public static string AssessorCompany;
    public static string AssessorPhone;
    public static string AssessorFax;
    public static string EA_Address1;
    public static string EA_Address2;
    public static string EA_Address3;
    public static string EA_Town;
    public static string EA_Postcode;
    public static string EA_Email;
    public static string EA_Web;
    public static string EA_Status;
    public static string EA_CertificationDate;
    public static string UserName;
    public static string Password;
    public static Insurance Insurance = new Insurance();

    public static int CheckErrors_Propertys(int house)
    {
      int num1;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Name, "", false) == 0)
      {
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtDName, "Please enter dwelling name.");
        int num2;
        num1 = checked (num2 + 1);
      }
      else
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtDName, "");
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Reference, "", false) == 0)
      {
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtDRef, "Please enter dwelling Reference.");
        checked { ++num1; }
      }
      else
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtDRef, "");
      if (DateTime.Compare(SAP_Module.Proj.Dwellings[house].DateAssessment, DateTime.MinValue) == 0)
      {
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtDDate, "Please select Assessment date.");
        checked { ++num1; }
      }
      else
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtDDate, "");
      if (DateTime.Compare(SAP_Module.Proj.Dwellings[house].DateCertificate, DateTime.MinValue) == 0)
      {
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtCDate, "Please select Certificate date.");
        checked { ++num1; }
      }
      else
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtCDate, "");
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Status, "", false) == 0)
      {
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtStatus, "Please select Assessment type.");
        checked { ++num1; }
      }
      else
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtStatus, "");
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Transaction, "", false) == 0)
      {
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtTransaction, "Please enter Transaction Type.");
        checked { ++num1; }
      }
      else
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtTransaction, "");
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Overheat, "", false) == 0)
      {
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtOverHeat, "Please select summer Overheating option.");
        checked { ++num1; }
      }
      else
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtOverHeat, "");
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Tenure, "", false) == 0)
      {
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtTenure, "Please enter Transaction Type.");
        checked { ++num1; }
      }
      else
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtTenure, "");
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].RPD, "", false) == 0)
      {
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtRPD, "Please enter Related Party.");
        checked { ++num1; }
      }
      else
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtRPD, "");
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].TMP.Type, "", false) == 0)
      {
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtTMP, "Please enter the Thermal Mass Parameter Type");
        checked { ++num1; }
      }
      else
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtTMP, "");
      MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtTMPUser, "");
      MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtTMPIndicative, "");
      if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].TMP.Type, "", false) > 0U)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].TMP.Type, "Indicative Value", false) == 0 & string.IsNullOrEmpty(SAP_Module.Proj.Dwellings[house].TMP.Indicative))
        {
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtTMPIndicative, "Please enter the Thermal Mass Indicative Type");
          checked { ++num1; }
        }
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].TMP.Type, "User Value", false) == 0 & (double) SAP_Module.Proj.Dwellings[house].TMP.UserDefined == 0.0)
        {
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtTMPUser, "Please enter the Thermal Mass Value");
          checked { ++num1; }
        }
      }
      if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Status, "New dwelling design stage", false) > 0U)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Address.City, "", false) == 0)
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtDCity, "Please enter City.");
        else
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtDCity, "");
      }
      else
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtDCity, "");
      if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Status, "New dwelling design stage", false) > 0U)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Address.PostCost, "", false) == 0)
        {
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtDPostCode, "Please enter Postcode.");
          checked { ++num1; }
        }
        else
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtDPostCode, "");
      }
      else
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtDPostCode, "");
      if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Status, "New dwelling design stage", false) > 0U)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].UPRN, "", false) == 0)
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtUPRN, "Please enter UPRN.");
        else
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtUPRN, "");
      }
      else
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtUPRN, "");
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Address.Country, "", false) == 0)
      {
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtDCountry, "Please enter Country.");
        checked { ++num1; }
      }
      else
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtDCountry, "");
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].EPCLanguage, "", false) == 0)
      {
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtEPCLanguage, "Please Select the language.");
        checked { ++num1; }
      }
      else
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtEPCLanguage, "");
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].PropertyType, "", false) == 0)
      {
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtPropertyType, "Please Select property type.");
        checked { ++num1; }
      }
      else
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtPropertyType, "");
      string propertyType = SAP_Module.Proj.Dwellings[house].PropertyType;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(propertyType, "Flat", false) == 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(propertyType, "Maisonette", false) == 0)
      {
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtBuiltForm, "");
        SAP_Module.Proj.Dwellings[house].BuildForm = "";
      }
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].BuildForm, "", false) == 0)
      {
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtBuiltForm, "Please Select Build from.");
        checked { ++num1; }
      }
      else
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtBuiltForm, "");
      if (MyProject.Forms.SAPForm.txtFlatType.Enabled)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].PropertyType, "Flat", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].PropertyType, "Maisonette", false) == 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].FlatType, "", false) == 0)
          {
            MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtFlatType, "Please SelectFlat type.");
            checked { ++num1; }
          }
          else
            MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtFlatType, "");
        }
        else
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtFlatType, "");
      }
      else
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtFlatType, "");
      if (SAP_Module.Proj.Dwellings[house].YearBuilt == 0)
      {
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtYearBuilt, "Please Select Year.");
        checked { ++num1; }
      }
      else
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtYearBuilt, "");
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Location, "", false) == 0)
      {
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtLocation, "Please Select Location.");
        checked { ++num1; }
      }
      else
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtLocation, "");
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Terrain, "", false) == 0)
      {
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtTerrain, "Please Select Terrain.");
        checked { ++num1; }
      }
      else
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtTerrain, "");
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Orientation, "", false) == 0)
      {
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtOrientation, "Please Select Orientation.");
        checked { ++num1; }
      }
      else
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtOrientation, "");
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].SmokeArea, "", false) == 0)
      {
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtSmokeArea, "Please Select SmokeArea.");
        checked { ++num1; }
      }
      else
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtSmokeArea, "");
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Overshading, "", false) == 0)
      {
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtShading, "Please Select Shading.");
        checked { ++num1; }
      }
      else
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtShading, "");
      SAP_Module.Proj.Dwellings[house].Validation.Property_Check = num1 == 0;
      return num1;
    }

    public static int CheckErrors_Opaque(int house)
    {
      MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txty, "");
      MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtHtb, "");
      int num1;
      int num2;
      if (SAP_Module.Proj.Dwellings[house].Thermal.ManualHtb)
      {
        if ((double) SAP_Module.Proj.Dwellings[house].Thermal.HtbValue == 0.0)
        {
          bool flag = false;
          if (SAP_Module.Proj.Dwellings[house].Thermal.PartyJunctions != null)
          {
            int num3 = checked (SAP_Module.Proj.Dwellings[house].Thermal.PartyJunctions.Count - 1);
            int index = 0;
            while (index <= num3)
            {
              if ((double) SAP_Module.Proj.Dwellings[house].Thermal.PartyJunctions[index].Length > 0.0)
                flag = true;
              checked { ++index; }
            }
          }
          if (SAP_Module.Proj.Dwellings[house].Thermal.ExternalJunctions != null)
          {
            int num4 = checked (SAP_Module.Proj.Dwellings[house].Thermal.ExternalJunctions.Count - 1);
            int index = 0;
            while (index <= num4)
            {
              if ((double) SAP_Module.Proj.Dwellings[house].Thermal.ExternalJunctions[index].Length > 0.0)
                flag = true;
              checked { ++index; }
            }
          }
          if (SAP_Module.Proj.Dwellings[house].Thermal.RoofJunctions != null)
          {
            int num5 = checked (SAP_Module.Proj.Dwellings[house].Thermal.RoofJunctions.Count - 1);
            int index = 0;
            while (index <= num5)
            {
              if ((double) SAP_Module.Proj.Dwellings[house].Thermal.RoofJunctions[index].Length > 0.0)
                flag = true;
              checked { ++index; }
            }
          }
          if (!flag)
          {
            MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtHtb, "Missing value, calculation required.");
            num2 = checked (num1 + 1);
          }
          else
            MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtHtb, "");
        }
        else
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtHtb, "");
      }
      else if (SAP_Module.Proj.Dwellings[house].Imported09 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Address.Country, "Scotland", false) == 0)
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txty, "");
      else if ((double) SAP_Module.Proj.Dwellings[house].Thermal.YValue == 0.0)
      {
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txty, "Missing y Value");
        num2 = checked (num1 + 1);
      }
      else
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txty, "");
      if (SAP_Module.Proj.Dwellings[house].Thermal.ManualY)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Thermal.Reference, "", false) == 0)
        {
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtThermalReference, "reference missing");
          checked { ++num2; }
        }
        else
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtThermalReference, "");
      }
      else
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtThermalReference, "");
      if (SAP_Module.Proj.Dwellings[house].NoofFloors == 0)
      {
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.GroupBox12, "");
      }
      else
      {
        int num6 = checked (SAP_Module.Proj.Dwellings[house].NoofFloors - 1);
        int index = 0;
        while (index <= num6)
        {
          bool flag;
          if ((double) SAP_Module.Proj.Dwellings[house].Floors[index].Area == 0.0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Floors[index].Name, (string) null, false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Floors[index].Type, "", false) == 0 | (double) SAP_Module.Proj.Dwellings[house].Floors[index].U_Value == 0.0)
          {
            MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.GroupBox12, "Please fill the information for floor.");
            checked { ++num2; }
            flag = true;
          }
          else if (!flag)
            MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.GroupBox12, "");
          checked { ++index; }
        }
      }
      int num7 = checked (SAP_Module.Proj.Dwellings[house].NoofpFloors - 1);
      int index1 = 0;
      while (index1 <= num7)
      {
        bool flag;
        if ((double) SAP_Module.Proj.Dwellings[house].PFloors[index1].Area == 0.0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].PFloors[index1].Name, (string) null, false) == 0)
        {
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.GroupBox29, "Please fill the information for Party floor.");
          checked { ++num2; }
          flag = true;
        }
        else if (!flag)
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.GroupBox29, "");
        checked { ++index1; }
      }
      int num8 = checked (SAP_Module.Proj.Dwellings[house].NoofIFloors - 1);
      int index2 = 0;
      while (index2 <= num8)
      {
        bool flag;
        if ((double) SAP_Module.Proj.Dwellings[house].IFloors[index2].Area == 0.0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].IFloors[index2].Name, (string) null, false) == 0)
        {
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.GroupBox48, "Please fill the information for internal floor.");
          checked { ++num2; }
          flag = true;
        }
        else if (!flag)
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.GroupBox48, "");
        checked { ++index2; }
      }
      int num9 = checked (SAP_Module.Proj.Dwellings[house].NoofWalls - 1);
      int index3 = 0;
      while (index3 <= num9)
      {
        bool flag;
        if ((double) SAP_Module.Proj.Dwellings[house].Walls[index3].Area == 0.0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Walls[index3].Name, (string) null, false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Walls[index3].Type, "", false) == 0 | (double) SAP_Module.Proj.Dwellings[house].Walls[index3].U_Value == 0.0)
        {
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.GroupBox11, "Please fill the information for Walls.");
          checked { ++num2; }
          flag = true;
        }
        else if (!flag)
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.GroupBox11, "");
        checked { ++index3; }
      }
      int num10 = checked (SAP_Module.Proj.Dwellings[house].NoofPWalls - 1);
      int index4 = 0;
      while (index4 <= num10)
      {
        bool flag;
        if ((double) SAP_Module.Proj.Dwellings[house].PWalls[index4].Area == 0.0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].PWalls[index4].Name, (string) null, false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].PWalls[index4].Type, "", false) == 0)
        {
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.GroupBox30, "Please fill the information for party Walls.");
          checked { ++num2; }
          flag = true;
        }
        else if (!flag)
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.GroupBox30, "");
        checked { ++index4; }
      }
      int num11 = checked (SAP_Module.Proj.Dwellings[house].NoofIWalls - 1);
      int index5 = 0;
      while (index5 <= num11)
      {
        bool flag;
        if ((double) SAP_Module.Proj.Dwellings[house].IWalls[index5].Area == 0.0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].IWalls[index5].Name, (string) null, false) == 0)
        {
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.GroupBox49, "Please fill the information for Internal Walls.");
          checked { ++num2; }
          flag = true;
        }
        else if (!flag)
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.GroupBox49, "");
        checked { ++index5; }
      }
      if (SAP_Module.Proj.Dwellings[house].NoofRoofs == 0)
      {
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.GroupBox14, "");
      }
      else
      {
        int num12 = checked (SAP_Module.Proj.Dwellings[house].NoofRoofs - 1);
        int index6 = 0;
        while (index6 <= num12)
        {
          bool flag;
          if ((double) SAP_Module.Proj.Dwellings[house].Roofs[index6].Area == 0.0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Roofs[index6].Name, (string) null, false) == 0 | (double) SAP_Module.Proj.Dwellings[house].Roofs[index6].U_Value == 0.0)
          {
            MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.GroupBox14, "Please fill the information for roofs.");
            checked { ++num2; }
            flag = true;
          }
          else if (!flag)
            MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.GroupBox14, "");
          checked { ++index6; }
        }
        int num13 = checked (SAP_Module.Proj.Dwellings[house].NoofICeilings - 1);
        int index7 = 0;
        while (index7 <= num13)
        {
          bool flag;
          if ((double) SAP_Module.Proj.Dwellings[house].ICeilings[index7].Area == 0.0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].ICeilings[index7].Name, (string) null, false) == 0)
          {
            MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.GroupBox50, "Please fill the information for Internal ceilings.");
            checked { ++num2; }
            flag = true;
          }
          else if (!flag)
            MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.GroupBox50, "");
          checked { ++index7; }
        }
        int num14 = checked (SAP_Module.Proj.Dwellings[house].NoofPCeilings - 1);
        int index8 = 0;
        while (index8 <= num14)
        {
          bool flag;
          if ((double) SAP_Module.Proj.Dwellings[house].PCeilings[index8].Area == 0.0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].PCeilings[index8].Name, (string) null, false) == 0)
          {
            MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.GroupBox45, "Please fill the information for party ceilings.");
            checked { ++num2; }
            flag = true;
          }
          else if (!flag)
            MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.GroupBox45, "");
          checked { ++index8; }
        }
      }
      SAP_Module.Proj.Dwellings[house].Validation.Opaque_Check = num2 == 0;
      return num2;
    }

    public static int CheckErrors_Openings(int house)
    {
      string Left1 = "Missing items for doors...";
      MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.GroupBox18, "");
      int num1 = checked (SAP_Module.Proj.Dwellings[house].NoofDoors - 1);
      int index1 = 0;
      while (index1 <= num1)
      {
        if ((double) SAP_Module.Proj.Dwellings[house].Doors[index1].Area == 0.0)
          Left1 = Left1 + "\r\nDoor Area Missing on Door - " + Conversions.ToString(checked (index1 + 1));
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Doors[index1].Name, "", false) == 0)
          Left1 = Left1 + "\r\nDoor Name Missing on Door - " + Conversions.ToString(checked (index1 + 1));
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Doors[index1].DoorType, "", false) == 0)
          Left1 = Left1 + "\r\nDoor Type Missing on Door - " + Conversions.ToString(checked (index1 + 1));
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Doors[index1].Location, "", false) == 0)
          Left1 = Left1 + "\r\nDoor Location Missing on Door - " + Conversions.ToString(checked (index1 + 1));
        if ((double) SAP_Module.Proj.Dwellings[house].Doors[index1].U == 0.0)
          Left1 = Left1 + "\r\nDoor U-value Missing on Door - " + Conversions.ToString(checked (index1 + 1));
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Doors[index1].Overshading, "", false) == 0 & (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Doors[index1].DoorType, "Solid", false) > 0U)
          Left1 = Left1 + "\r\nDoor overshading Missing on Door - " + Conversions.ToString(checked (index1 + 1));
        checked { ++index1; }
      }
      int num2;
      int num3;
      if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left1, "Missing items for doors...", false) > 0U)
      {
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.GroupBox18, Left1);
        num3 = checked (num2 + 1);
      }
      MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.GroupBox16, "");
      string Left2 = "Missing items for windows...";
      int num4 = checked (SAP_Module.Proj.Dwellings[house].NoofWindows - 1);
      int index2 = 0;
      while (index2 <= num4)
      {
        if ((double) SAP_Module.Proj.Dwellings[house].Windows[index2].Area == 0.0)
          Left2 = Left2 + "\r\nWindow Area Missing on Window - " + Conversions.ToString(checked (index2 + 1));
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Windows[index2].Name, "", false) == 0)
          Left2 = Left2 + "\r\nWindow Name Missing on Window - " + Conversions.ToString(checked (index2 + 1));
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Windows[index2].GlazingType, "", false) == 0)
          Left2 = Left2 + "\r\nWindow Glazing Type Missing on Window - " + Conversions.ToString(checked (index2 + 1));
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Windows[index2].Location, "", false) == 0)
          Left2 = Left2 + "\r\nWindow Location Missing on Window - " + Conversions.ToString(checked (index2 + 1));
        if ((double) SAP_Module.Proj.Dwellings[house].Windows[index2].U == 0.0)
          Left2 = Left2 + "\r\nWindow U-value Missing on Window - " + Conversions.ToString(checked (index2 + 1));
        if ((double) SAP_Module.Proj.Dwellings[house].Windows[index2].g == 0.0)
          Left2 = Left2 + "\r\nWindow g-value Missing on Window - " + Conversions.ToString(checked (index2 + 1));
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Windows[index2].Overshading, "", false) == 0)
          Left2 = Left2 + "\r\nWindow overshading Missing on Window - " + Conversions.ToString(checked (index2 + 1));
        if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Windows[index2].UValueSource, "BFRC", false) > 0U && (double) SAP_Module.Proj.Dwellings[house].Windows[index2].FF == 0.0)
          Left2 = Left2 + "\r\nWindow 'Frame Factor' Missing on Window - " + Conversions.ToString(checked (index2 + 1));
        checked { ++index2; }
      }
      if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left2, "Missing items for windows...", false) > 0U)
      {
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.GroupBox16, Left2);
        checked { ++num3; }
      }
      MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.GroupBox17, "");
      string Left3 = "Missing items for roof lights...";
      int num5 = checked (SAP_Module.Proj.Dwellings[house].NoofRoofLights - 1);
      int index3 = 0;
      while (index3 <= num5)
      {
        if ((double) SAP_Module.Proj.Dwellings[house].RoofLights[index3].Area == 0.0)
          Left3 = Left3 + "\r\nWindow Area Missing on roof light - " + Conversions.ToString(checked (index3 + 1));
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].RoofLights[index3].Name, "", false) == 0)
          Left3 = Left3 + "\r\nWindow Name Missing on roof light - " + Conversions.ToString(checked (index3 + 1));
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].RoofLights[index3].GlazingType, "", false) == 0)
          Left3 = Left3 + "\r\nWindow Glazing Type Missing on roof light - " + Conversions.ToString(checked (index3 + 1));
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].RoofLights[index3].Location, "", false) == 0)
          Left3 = Left3 + "\r\nWindow Location Missing on roof light - " + Conversions.ToString(checked (index3 + 1));
        if ((double) SAP_Module.Proj.Dwellings[house].RoofLights[index3].U == 0.0)
          Left3 = Left3 + "\r\nWindow U-value Missing on roof light - " + Conversions.ToString(checked (index3 + 1));
        if ((double) SAP_Module.Proj.Dwellings[house].RoofLights[index3].g == 0.0)
          Left3 = Left3 + "\r\nWindow g-value Missing on roof light - " + Conversions.ToString(checked (index3 + 1));
        if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].RoofLights[index3].UValueSource, "BFRC", false) > 0U && (double) SAP_Module.Proj.Dwellings[house].RoofLights[index3].FF == 0.0)
          Left3 = Left3 + "\r\nWindow 'Frame Factor' Missing on roof light - " + Conversions.ToString(checked (index3 + 1));
        checked { ++index3; }
      }
      if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left3, "Missing items for roof lights...", false) > 0U)
      {
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.GroupBox17, Left3);
        checked { ++num3; }
      }
      SAP_Module.Proj.Dwellings[house].Validation.Openings_Check = num3 == 0;
      int num6;
      if (SAP_Module.Proj.Dwellings[house].NoofDoors > 0)
      {
        int num7 = checked (SAP_Module.Proj.Dwellings[house].NoofDoors - 1);
        int i = 0;
        while (i <= num7)
        {
          num6 = Validation.Checkerrors_Door(house, i);
          if (num6 <= 0)
            checked { ++i; }
          else
            break;
        }
        if (num6 > 0)
          SAP_Module.Proj.Dwellings[house].Validation.Openings_Check = false;
      }
      int num8;
      if (SAP_Module.Proj.Dwellings[house].NoofWindows > 0)
      {
        int num9 = checked (SAP_Module.Proj.Dwellings[house].NoofWindows - 1);
        int i = 0;
        while (i <= num9)
        {
          num8 = Validation.Checkerrors_Windows(house, i);
          if (num8 <= 0)
            checked { ++i; }
          else
            break;
        }
        if (num8 > 0)
          SAP_Module.Proj.Dwellings[house].Validation.Openings_Check = false;
      }
      int num10;
      if (SAP_Module.Proj.Dwellings[house].NoofRoofLights > 0)
      {
        int num11 = checked (SAP_Module.Proj.Dwellings[house].NoofRoofLights - 1);
        int i = 0;
        while (i <= num11)
        {
          num10 = Validation.Checkerrors_RoofLights(house, i);
          if (num10 <= 0)
            checked { ++i; }
          else
            break;
        }
        if (num10 > 0)
          SAP_Module.Proj.Dwellings[house].Validation.Openings_Check = false;
      }
      if (checked (SAP_Module.Proj.Dwellings[house].NoofWindows + SAP_Module.Proj.Dwellings[house].NoofDoors + SAP_Module.Proj.Dwellings[house].NoofRoofLights) == 0)
      {
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.DataWindows, "Please fill the information.");
        num2 = checked (num3 + 1);
      }
      else
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.DataWindows, "");
      int num12 = checked (num8 + num6 + num10);
      SAP_Module.Proj.Dwellings[house].Validation.Openings_Check = num12 == 0;
      return num12;
    }

    public static int CheckErrors_Dims(int House)
    {
      int num1;
      if (SAP_Module.Proj.Dwellings[House].Storeys == 0)
      {
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.GroupBox13, "Please fill the information.");
      }
      else
      {
        int num2 = checked (SAP_Module.Proj.Dwellings[House].Storeys - 1);
        int index = 0;
        while (index <= num2)
        {
          if (Conversion.Val((object) SAP_Module.Proj.Dwellings[House].Dims[index].Area) == 0.0 | Conversion.Val((object) SAP_Module.Proj.Dwellings[House].Dims[index].Height) == 0.0)
          {
            MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.GroupBox13, "Please fill the information.");
            checked { ++num1; }
          }
          else
            MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.GroupBox13, "");
          checked { ++index; }
        }
      }
      if (Conversion.Val(SAP_Module.Proj.Dwellings[House].LivingFraction.ToString()) == 0.0)
      {
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtLivingFraction, "Please fill the information.");
        checked { ++num1; }
      }
      else
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtLivingFraction, "");
      if ((double) SAP_Module.Proj.Dwellings[House].LivingArea == 0.0)
      {
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtLivingArea, "Please fill the information for total area.");
        checked { ++num1; }
      }
      else
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtLivingArea, "");
      SAP_Module.Proj.Dwellings[House].Validation.Dims_Check = num1 == 0;
      return num1;
    }

    public static int CheckErrors_Cooling(int House)
    {
      MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtCoolingSystemType, "");
      MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtEnergyLabelClass, "");
      MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.CompressControl, "");
      MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtCooledArea, "");
      MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.ChkCoolingSystem, "");
      MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtEER, "");
      MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txterrDesc, "");
      ref SAP_Module.CoolingSystem local = ref SAP_Module.Proj.Dwellings[House].Cooling;
      int num1;
      if (local.Include)
      {
        if (string.IsNullOrEmpty(local.SystemType))
        {
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtCoolingSystemType, "'Cooling System Type' required");
          int num2;
          num1 = checked (num2 + 1);
        }
        if (local.ERRMeasuredInclude)
        {
          if (string.IsNullOrEmpty(local.Description))
          {
            MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txterrDesc, "'Description' required");
            checked { ++num1; }
          }
          if ((double) local.ERR == 0.0)
          {
            MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtEER, "'EER' required");
            checked { ++num1; }
          }
        }
        else if (string.IsNullOrEmpty(local.Energylabel))
        {
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtEnergyLabelClass, "'Energy label class' required");
          checked { ++num1; }
        }
        if (string.IsNullOrEmpty(local.Compressorcontrol))
        {
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.CompressControl, "'Compress Control' required");
          checked { ++num1; }
        }
        if (Conversion.Val(local.Cooled_Area) == 0.0)
        {
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtCooledArea, "'Cooled area' required");
          checked { ++num1; }
        }
      }
      return num1;
    }

    public static int CheckErrors_Ventilation(int house)
    {
      int num1;
      if (SAP_Module.Proj.Dwellings[house].Ventilation.Fans == 0 & (uint) SAP_Module.Proj.Dwellings[house].Ventilation.Fans > 0U)
      {
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtNoofFans, "Please fill the information for fans.");
        int num2;
        num1 = checked (num2 + 1);
      }
      else
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtNoofFans, "");
      if (SAP_Module.Proj.Dwellings[house].Ventilation.Chimneys == 0 & (uint) SAP_Module.Proj.Dwellings[house].Ventilation.Chimneys > 0U)
      {
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtNoofChmneys, "Please fill the information for Chimeny.");
        checked { ++num1; }
      }
      else
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtNoofChmneys, "");
      if (SAP_Module.Proj.Dwellings[house].Ventilation.Fires == 0 & (uint) SAP_Module.Proj.Dwellings[house].Ventilation.Fires > 0U)
      {
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtNoofFlueGasFires, "Please fill the information for Fires.");
        checked { ++num1; }
      }
      else
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtNoofFlueGasFires, "");
      if (SAP_Module.Proj.Dwellings[house].Ventilation.Flues == 0 & (uint) SAP_Module.Proj.Dwellings[house].Ventilation.Flues > 0U)
      {
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtNoofOpenFlues, "Please fill the information for Flues.");
        checked { ++num1; }
      }
      else
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtNoofOpenFlues, "");
      if (SAP_Module.Proj.Dwellings[house].Ventilation.Vents == 0 & (uint) SAP_Module.Proj.Dwellings[house].Ventilation.Vents > 0U)
      {
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtNoofPassiveVents, "Please fill the information for vents.");
        checked { ++num1; }
      }
      else
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtNoofPassiveVents, "");
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Ventilation.MechVent, "", false) == 0)
      {
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtMechVentilation, "Please select the Mechnical ventilation");
        checked { ++num1; }
      }
      else
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtMechVentilation, "");
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Ventilation.MechVent, "Balanced without heat recovery", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Ventilation.MechVent, "Balanced with heat recovery", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Ventilation.MechVent, "Centralised whole house extract", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Ventilation.MechVent, "Decentralised whole house extract", false) == 0)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Ventilation.Parameters, "", false) == 0)
        {
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtParamters, "Please select the source");
          checked { ++num1; }
        }
        else
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtParamters, "");
      }
      else
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtParamters, "");
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Ventilation.MechVent, "Balanced without heat recovery", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Ventilation.MechVent, "Balanced with heat recovery", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Ventilation.MechVent, "Centralised whole house extract", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Ventilation.MechVent, "Decentralised whole house extract", false) == 0)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Ventilation.Parameters, "User defined", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Ventilation.Parameters, "Database", false) == 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Ventilation.MechVent, "Decentralised whole house extract", false) != 0)
          {
            if (SAP_Module.Proj.Dwellings[house].Ventilation.WetRooms == 0 | SAP_Module.Proj.Dwellings[house].Ventilation.WetRooms == 0)
            {
              MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtWetRooms, "Please enter wet rooms.");
              checked { ++num1; }
            }
            else
              MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtWetRooms, "");
          }
        }
        else
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtWetRooms, "");
      }
      else
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtWetRooms, "");
      string mechVent = SAP_Module.Proj.Dwellings[house].Ventilation.MechVent;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(mechVent, "Balanced without heat recovery", false) != 0)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(mechVent, "Balanced with heat recovery", false) != 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(mechVent, "Centralised whole house extract", false) != 0)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(mechVent, "Decentralised whole house extract", false) == 0)
            {
              MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtMechHeat, "");
              MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtMechFan, "");
              MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtDuctInsulation, "");
              string parameters = SAP_Module.Proj.Dwellings[house].Ventilation.Parameters;
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(parameters, "Database", false) != 0)
              {
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(parameters, "User defined", false) == 0)
                {
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Ventilation.MVDetails.ProductName, "", false) == 0)
                  {
                    MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtMechProductName, "Please enter product name.");
                    checked { ++num1; }
                  }
                  else
                    MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtMechProductName, "");
                  MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtDuctInsulation, "");
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Ventilation.MVDetails.DuctingType, "", false) == 0)
                  {
                    MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtMechDucting, "Please enter Duct Type.");
                    checked { ++num1; }
                  }
                  else
                    MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtMechDucting, "");
                  MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtMechFan, "");
                }
              }
              else if (SAP_Module.Proj.Dwellings[house].Ventilation.ProductID == 0)
              {
                MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.cmdProducts, "Please Select from the database.");
                checked { ++num1; }
              }
              else
                MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.cmdProducts, "");
              if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Ventilation.Parameters, "SAP 2012", false) > 0U)
              {
                if ((double) SAP_Module.Proj.Dwellings[house].Ventilation.Decentralised.KTP1 > 0.0)
                {
                  if ((double) SAP_Module.Proj.Dwellings[house].Ventilation.Decentralised.KSPF1 == 0.0)
                  {
                    MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtMechDecKTF1, "Please enter room ceiling.");
                    checked { ++num1; }
                  }
                  else
                    MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtMechDecKTF1, "");
                }
                else
                  MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtMechDecKTF1, "");
                if ((double) SAP_Module.Proj.Dwellings[house].Ventilation.Decentralised.KTP2 > 0.0)
                {
                  if ((double) SAP_Module.Proj.Dwellings[house].Ventilation.Decentralised.KSPF2 == 0.0)
                  {
                    MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtMechDecKTF2, "Please enter duct.");
                    checked { ++num1; }
                  }
                  else
                    MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtMechDecKTF2, "");
                }
                else
                  MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtMechDecKTF2, "");
                if ((double) SAP_Module.Proj.Dwellings[house].Ventilation.Decentralised.KTP3 > 0.0)
                {
                  if ((double) SAP_Module.Proj.Dwellings[house].Ventilation.Decentralised.KSPF3 == 0.0)
                  {
                    MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtMechDecKTF3, "Please enter through wall.");
                    checked { ++num1; }
                  }
                  else
                    MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtMechDecKTF3, "");
                }
                else
                  MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtMechDecKTF3, "");
                if ((double) SAP_Module.Proj.Dwellings[house].Ventilation.Decentralised.OTP1 > 0.0)
                {
                  if ((double) SAP_Module.Proj.Dwellings[house].Ventilation.Decentralised.OSPF1 == 0.0)
                  {
                    MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtMechDecOTF1, "Please enter room ceiling.");
                    checked { ++num1; }
                  }
                  else
                    MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtMechDecOTF1, "");
                }
                else
                  MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtMechDecOTF1, "");
                if ((double) SAP_Module.Proj.Dwellings[house].Ventilation.Decentralised.OTP2 > 0.0)
                {
                  if ((double) SAP_Module.Proj.Dwellings[house].Ventilation.Decentralised.OSPF2 == 0.0)
                  {
                    MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtMechDecOTF2, "Please enter duct.");
                    checked { num1 += 2; }
                  }
                  else
                    MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtMechDecOTF2, "");
                }
                else
                  MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtMechDecOTF2, "");
                if ((double) SAP_Module.Proj.Dwellings[house].Ventilation.Decentralised.OTP3 > 0.0)
                {
                  if ((double) SAP_Module.Proj.Dwellings[house].Ventilation.Decentralised.OSPF3 == 0.0)
                  {
                    MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtMechDecOTF3, "Please enter through wall.");
                    checked { num1 += 2; }
                  }
                  else
                    MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtMechDecOTF3, "");
                }
                else
                  MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtMechDecOTF3, "");
              }
            }
          }
          else
          {
            string parameters = SAP_Module.Proj.Dwellings[house].Ventilation.Parameters;
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(parameters, "Database", false) != 0)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(parameters, "User defined", false) == 0)
              {
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Ventilation.MVDetails.ProductName, "", false) == 0)
                {
                  MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtMechProductName, "Please enter product name.");
                  checked { ++num1; }
                }
                else
                  MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtMechProductName, "");
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Ventilation.MVDetails.DuctingType, "", false) == 0)
                {
                  MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtMechDucting, "Please enter Duct Type.");
                  checked { ++num1; }
                }
                else
                  MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtMechDucting, "");
                if ((double) SAP_Module.Proj.Dwellings[house].Ventilation.MVDetails.SFP == 0.0)
                {
                  MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtMechFan, "Please enter fans.");
                  checked { ++num1; }
                }
                else
                  MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtMechFan, "");
              }
            }
            else if (SAP_Module.Proj.Dwellings[house].Ventilation.ProductID == 0)
            {
              MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.cmdProducts, "Please Select from the database.");
              checked { ++num1; }
            }
            else
              MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.cmdProducts, "");
          }
        }
        else
        {
          string parameters = SAP_Module.Proj.Dwellings[house].Ventilation.Parameters;
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(parameters, "User defined", false) != 0)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(parameters, "Database", false) == 0)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Ventilation.DuctType, "", false) == 0)
              {
                MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtDuctInsulation, "Please enter Duct Insulation Type.");
                checked { ++num1; }
              }
              else
                MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtDuctInsulation, "");
              if (SAP_Module.Proj.Dwellings[house].Ventilation.ProductID == 0)
              {
                MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.cmdProducts, "Please Select from the database.");
                checked { ++num1; }
              }
              else
                MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.cmdProducts, "");
            }
          }
          else
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Ventilation.MVDetails.ProductName, "", false) == 0)
            {
              MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtMechProductName, "Please enter product name.");
              checked { ++num1; }
            }
            else
              MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtMechProductName, "");
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Ventilation.DuctType, "", false) == 0)
            {
              MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtDuctInsulation, "Please enter Duct Insulation Type.");
              checked { ++num1; }
            }
            else
              MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtDuctInsulation, "");
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Ventilation.MVDetails.DuctingType, "", false) == 0)
            {
              MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtMechDucting, "Please enter Duct Type.");
              checked { ++num1; }
            }
            else
              MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtMechDucting, "");
            if ((double) SAP_Module.Proj.Dwellings[house].Ventilation.MVDetails.SFP == 0.0)
            {
              MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtMechFan, "Please enter fans.");
              checked { ++num1; }
            }
            else
              MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtMechFan, "");
          }
        }
      }
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Ventilation.Parameters, "User defined", false) == 0)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Ventilation.MVDetails.ProductName, "", false) == 0)
        {
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtMechProductName, "Please enter product name.");
          checked { ++num1; }
        }
        else
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtMechProductName, "");
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Ventilation.MVDetails.DuctingType, "", false) == 0)
        {
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtMechDucting, "Please enter Duct Type.");
          checked { ++num1; }
        }
        else
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtMechDucting, "");
        if ((double) SAP_Module.Proj.Dwellings[house].Ventilation.MVDetails.SFP == 0.0)
        {
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtMechFan, "Please enter fans.");
          checked { ++num1; }
        }
        else
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtMechFan, "");
      }
      if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Ventilation.Parameters, "SAP 2012", false) > 0U & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Ventilation.MechVent, "Decentralised whole house extract", false) == 0)
      {
        if ((double) SAP_Module.Proj.Dwellings[house].Ventilation.Decentralised.KTP1 == 0.0 & (double) SAP_Module.Proj.Dwellings[house].Ventilation.Decentralised.KTP2 == 0.0 & (double) SAP_Module.Proj.Dwellings[house].Ventilation.Decentralised.KTP3 == 0.0 & (double) SAP_Module.Proj.Dwellings[house].Ventilation.Decentralised.OTP1 == 0.0 & (double) SAP_Module.Proj.Dwellings[house].Ventilation.Decentralised.OTP2 == 0.0 & (double) SAP_Module.Proj.Dwellings[house].Ventilation.Decentralised.OTP3 == 0.0)
        {
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtMechDecKTF1, "Please check ventilation details.");
          checked { ++num1; }
        }
        else
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtMechDecKTF1, "");
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Ventilation.Pressure, "", false) == 0)
      {
        bool flag = false;
        if (Conversion.Val((object) SAP_Module.Proj.Dwellings[house].Ventilation.MeasuredAir) > 0.0)
        {
          SAP_Module.Proj.Dwellings[house].Ventilation.Pressure = "As built";
          flag = true;
        }
        else if (Conversion.Val((object) SAP_Module.Proj.Dwellings[house].Ventilation.DesignAir) > 0.0)
        {
          SAP_Module.Proj.Dwellings[house].Ventilation.Pressure = "As designed";
          flag = true;
        }
        if (!flag)
        {
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtAirTest, "Please select the pressure test");
          checked { ++num1; }
        }
      }
      else
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtAirTest, "");
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Ventilation.Pressure, "As built", false) == 0)
      {
        if ((double) SAP_Module.Proj.Dwellings[house].Ventilation.MeasuredAir == 0.0 | (double) SAP_Module.Proj.Dwellings[house].Ventilation.MeasuredAir == 0.0)
        {
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtMeasuredAir, "Please select the Measure test");
          checked { ++num1; }
        }
        else
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtMeasuredAir, "");
      }
      else
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtMeasuredAir, "");
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Ventilation.Pressure, "As designed", false) == 0)
      {
        if ((double) SAP_Module.Proj.Dwellings[house].Ventilation.DesignAir == 0.0 | (double) SAP_Module.Proj.Dwellings[house].Ventilation.DesignAir == 0.0)
        {
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtDesignAir, "Please select the design air");
          checked { ++num1; }
        }
        else
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtDesignAir, "");
      }
      else
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtDesignAir, "");
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Ventilation.Pressure, "As built", false) == 0)
        MyProject.Forms.SAPForm.txtDesignAir.Text = "";
      if (MyProject.Forms.SAPForm.grpDetails.Visible)
      {
        if ((double) SAP_Module.Proj.Dwellings[house].Ventilation.Infiltration.DraguthP == 0.0)
        {
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtDetPercentDraught, "Please enter Draught Percent.");
          checked { ++num1; }
        }
        else
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtDetPercentDraught, "");
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Ventilation.Infiltration.Lobby, (string) null, false) == 0)
        {
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtDetLobby, "Please enter lobby detail.");
          checked { ++num1; }
        }
        else
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtDetLobby, "");
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Ventilation.Infiltration.Floor, (string) null, false) == 0)
        {
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtDetFloor, "Please enter Floor detail.");
          checked { ++num1; }
        }
        else
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtDetFloor, "");
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Ventilation.Infiltration.Construction, (string) null, false) == 0)
        {
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtDetConstruction, "Please enter Construction detail.");
          checked { ++num1; }
        }
        else
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtDetConstruction, "");
      }
      else
      {
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtDetConstruction, "");
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtDetLobby, "");
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtDetFloor, "");
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtDetPercentDraught, "");
      }
      if (MyProject.Forms.SAPForm.txtDuctInsulation.Enabled)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Ventilation.DuctType, "", false) == 0)
        {
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtDuctInsulation, "Please select the insulation type option.");
          checked { ++num1; }
        }
        else
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtDuctInsulation, "");
      }
      else
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtDuctInsulation, "");
      SAP_Module.Proj.Dwellings[house].Validation.Ventilation_Check = num1 == 0;
      return num1;
    }

    public static int CheckErrors_WaterHeating(int house)
    {
      int num1;
      if (SAP_Module.Proj.Dwellings[house].Water.Solar.Inlcude)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Water.Solar.SolarType, "", false) == 0)
        {
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtSolarType, "Please select solar type.");
          int num2;
          num1 = checked (num2 + 1);
        }
        else
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtSolarType, "");
        if ((double) SAP_Module.Proj.Dwellings[house].Water.Solar.SolarZero == 0.0)
        {
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtSolarZero, "Please select solar Zero.");
          checked { ++num1; }
        }
        else
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtSolarZero, "");
        if ((double) SAP_Module.Proj.Dwellings[house].Water.Solar.SolarHLoss == 0.0)
        {
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtSolarHLoss, "Please select solar heat loss.");
          checked { ++num1; }
        }
        else
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtSolarHLoss, "");
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Water.Solar.SolarTilt, "", false) == 0)
        {
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtSolarTilt, "Please select solar Gross area.");
          checked { ++num1; }
        }
        else
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtSolarTilt, "");
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Water.Solar.SolarOrientation, "", false) == 0)
        {
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtSolarOrientation, "Please select solar Orientation.");
          checked { ++num1; }
        }
        else
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtSolarOrientation, "");
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Water.Solar.SolarOvershading, "", false) == 0)
        {
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtSolarOvershading, "Please select solar vershading.");
          checked { ++num1; }
        }
        else
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtSolarOvershading, "");
      }
      else
      {
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtSolarType, "");
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtSolarZero, "");
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtSolarHLoss, "");
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtSolarArea, "");
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.chkSolarGross, "");
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtSolarTilt, "");
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtSolarOrientation, "");
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtSolarOvershading, "");
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtSolarVolume, "");
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Water.System, "", false) == 0)
      {
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtWater, "Please select water system.");
        checked { ++num1; }
      }
      else
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtWater, "");
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].MainHeating.HGroup, "Boiler systems with radiators or underfloor heating", false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].MainHeating.InforSource, "Boiler Database", false) == 0)
      {
        object Instance = (object) SAP_Module.PCDFData.HeatPumps.Where<PCDF.HeatPump>((Func<PCDF.HeatPump, bool>) (b => b.ID.Equals(SAP_Module.Proj.Dwellings[house].MainHeating.SEDBUK))).SingleOrDefault<PCDF.HeatPump>();
        if (Instance != null)
        {
          try
          {
            if (Conversion.Val(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Instance, (System.Type) null, "ServiceProvision", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))) == 3.0)
            {
              if (SAP_Module.Proj.Dwellings[house].Water.SystemRef == 901)
              {
                MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtWater, "Please select correct heating space.");
                checked { ++num1; }
              }
              else
                MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtWater, "");
            }
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
        }
      }
      else
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtWater, "");
      if (SAP_Module.Proj.Dwellings[house].Water.Cylinder.ManuSpecified)
      {
        if ((double) SAP_Module.Proj.Dwellings[house].Water.Cylinder.DeclaredLoss == 0.0)
        {
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtCyDLoss, "Please enter correct value.");
          checked { ++num1; }
        }
        else
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtCyDLoss, "");
      }
      else
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtCyDLoss, "");
      if (SAP_Module.Proj.Dwellings[house].Water.Thermal.Include)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Water.Thermal.Type, "", false) == 0)
        {
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtThermalType, "Please select Thermal type.");
          checked { ++num1; }
        }
        else
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtThermalType, "");
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Water.Thermal.Location, "", false) == 0)
        {
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtThermalLocation, "Please select Thermal Location.");
          checked { ++num1; }
        }
        else
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtThermalLocation, "");
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Water.Thermal.Connection, "", false) == 0)
        {
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtThermalConnection, "Please select Thermal connection.");
          checked { ++num1; }
        }
        else
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtThermalConnection, "");
      }
      else
      {
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.chkThermal, "");
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtThermalConnection, "");
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtThermalLocation, "");
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtThermalType, "");
      }
      MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.grdCommunityWater, "");
      bool flag;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Water.System, "From hot-water only community scheme - boilers", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Water.System, "From hot-water only community scheme - CHP", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Water.System, "From hot-water only community scheme - heat pump", false) == 0)
      {
        if (SAP_Module.Proj.Dwellings[house].Water.HWSComm.FromDatabase)
        {
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtDHWCommEff, "");
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtDHWCommFraction, "");
          if (string.IsNullOrEmpty(SAP_Module.Proj.Dwellings[house].Water.HWSComm.SystemRef))
          {
            MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.grdCommunityWater, "Please select water system");
            checked { ++num1; }
          }
          else
            MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.grdCommunityWater, "");
          try
          {
            List<PCDF.CommunityScheme_Sub> list = SAP_Module.PCDFData.CommunitySchemes_Sub.Where<PCDF.CommunityScheme_Sub>((Func<PCDF.CommunityScheme_Sub, bool>) (b => b.ID.Equals(SAP_Module.Proj.Dwellings[house].Water.HWSComm.SystemRef))).ToList<PCDF.CommunityScheme_Sub>();
            if (list[0] != null)
            {
              if (list[0].CommunityFuel.Equals("99"))
                flag = true;
            }
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
        }
        else
        {
          if (!SAP_Module.Proj.OverRide)
          {
            try
            {
              if (SAP_Module.Proj.Dwellings[house].Water.HWSComm.NoOfAdditionalHeatSources > 0)
              {
                float num3;
                float Expression = num3 + SAP_Module.Proj.Dwellings[house].Water.HWSComm.Boiler1Fraction;
                if (SAP_Module.Proj.Dwellings[house].Water.HWSComm.NoOfAdditionalHeatSources > 0)
                  Expression += SAP_Module.Proj.Dwellings[house].Water.HWSComm.HeatSource1.HeatFraction;
                if (SAP_Module.Proj.Dwellings[house].Water.HWSComm.NoOfAdditionalHeatSources > 1)
                  Expression += SAP_Module.Proj.Dwellings[house].Water.HWSComm.HeatSource2.HeatFraction;
                if (SAP_Module.Proj.Dwellings[house].Water.HWSComm.NoOfAdditionalHeatSources > 2)
                  Expression += SAP_Module.Proj.Dwellings[house].Water.HWSComm.HeatSource3.HeatFraction;
                if (SAP_Module.Proj.Dwellings[house].Water.HWSComm.NoOfAdditionalHeatSources > 3)
                  Expression += SAP_Module.Proj.Dwellings[house].Water.HWSComm.HeatSource4.HeatFraction;
                if (Conversion.Val((object) Expression) != 1.0)
                {
                  MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtDHWCommFraction, "The total fraction doesn't total to 1");
                  checked { ++num1; }
                }
                else
                  MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtDHWCommFraction, "");
              }
              else if ((double) SAP_Module.Proj.Dwellings[house].Water.HWSComm.Boiler1Fraction != 1.0)
              {
                MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtDHWCommFraction, "Faction has to be 1.");
                checked { ++num1; }
              }
              else
                MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtDHWCommFraction, "");
            }
            catch (Exception ex)
            {
              ProjectData.SetProjectError(ex);
              ProjectData.ClearProjectError();
            }
          }
          if (SAP_Module.Proj.Dwellings[house].Water.SystemRef == 951)
          {
            if ((double) SAP_Module.Proj.Dwellings[house].Water.HWSComm.CHPRatio == 0.0 & (double) SAP_Module.Proj.Dwellings[house].Water.HWSComm.CHPPowerEff == 0.0)
            {
              MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtDHWCommCHP, "Please enter efficiency");
              checked { ++num1; }
            }
            else
              MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtDHWCommCHP, "");
          }
          else
            MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtDHWCommCHP, "");
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Water.HWSComm.HDS, "", false) == 0)
          {
            MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtDHWCommHDS, "Please Select Heat distribution system.");
            checked { ++num1; }
          }
          else
            MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtDHWCommHDS, "");
          if ((double) SAP_Module.Proj.Dwellings[house].Water.HWSComm.Efficiency == 0.0)
          {
            MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtDHWCommEff, "Please enter efficiency.");
            checked { ++num1; }
          }
          else
            MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtDHWCommEff, "");
        }
      }
      else
      {
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtDHWCommEff, "");
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtDHWCommHDS, "");
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtDHWCommCHP, "");
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.chkDHWCommCylinder, "");
      }
      if (flag)
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtWaterFuel, "");
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Water.Fuel, "", false) == 0)
      {
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtWaterFuel, "Please select water fuel.");
        checked { ++num1; }
      }
      else
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtWaterFuel, "");
      if (MyProject.Forms.SAPForm.grpCylinder.Enabled)
      {
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtCyInsulation, "");
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtCyInsThick, "");
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtCyDLoss, "");
        if (MyProject.Forms.SAPForm.optCyManuLoss.Enabled | SAP_Module.Proj.Dwellings[house].Water.Cylinder.ManuSpecified)
        {
          if (SAP_Module.Proj.Dwellings[house].Water.Cylinder.ManuSpecified)
          {
            if ((double) SAP_Module.Proj.Dwellings[house].Water.Cylinder.DeclaredLoss == 0.0)
            {
              MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtCyDLoss, "Please Insert Cylinder Loss.");
              checked { ++num1; }
            }
            else
              MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtCyDLoss, "");
          }
          else
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Water.Cylinder.Insulation, "", false) == 0)
            {
              MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtCyInsulation, "Please Select Insulation.");
              checked { ++num1; }
            }
            else
              MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtCyInsulation, "");
            if ((double) SAP_Module.Proj.Dwellings[house].Water.Cylinder.InsThick == 0.0)
            {
              MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtCyInsThick, "Please Select Insulation.");
              checked { ++num1; }
            }
            else
              MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtCyInsThick, "");
          }
        }
      }
      else
      {
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtCyVolume, "");
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtCyInsulation, "");
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtCyInsThick, "");
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtCyDLoss, "");
      }
      try
      {
        MyProject.Forms.SAPForm.cmdFGHRS.Enabled = true;
        MyProject.Forms.SAPForm.ChkFGHRS.Enabled = true;
        if (SAP_Module.Proj.Dwellings[house].MainHeating.IntegralPFGHRS | SAP_Module.Proj.Dwellings[house].MainHeating2.IntegralPFGHRS)
        {
          MyProject.Forms.SAPForm.cmdFGHRS.Enabled = false;
          MyProject.Forms.SAPForm.ChkFGHRS.Enabled = false;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      SAP_Module.Proj.Dwellings[house].Validation.WaterHeating_Check = num1 == 0;
      return num1;
    }

    public static int CheckErrors_RenewableTech(int house)
    {
      MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtPPower, "");
      MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtPTilt, "");
      MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtPCOrientation, "");
      MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtPOvershading, "");
      MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.GroupBox37, "");
      MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.cmdPhotoNew, "");
      int num1;
      if (SAP_Module.Proj.Dwellings[house].Renewable.Photovoltaic.Inlcude)
      {
        if (SAP_Module.Proj.Dwellings[house].Renewable.Photovoltaic.Photovoltaics != null)
        {
          int num2 = Information.UBound((Array) SAP_Module.Proj.Dwellings[house].Renewable.Photovoltaic.Photovoltaics);
          int index = 0;
          while (index <= num2)
          {
            ref SAP_Module.PhotoVoltaics local = ref SAP_Module.Proj.Dwellings[house].Renewable.Photovoltaic.Photovoltaics[index];
            if ((double) local.PPower == 0.0)
            {
              MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.GroupBox37, "Please enter Photovoltaic power.");
              checked { ++num1; }
            }
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(local.PTilt, "", false) == 0)
            {
              MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.GroupBox37, "Please enter Photovoltaic Tilt.");
              checked { ++num1; }
            }
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(local.PCOrientation, "", false) == 0)
            {
              MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.GroupBox37, "Please enter Photovoltaic Orientation.");
              checked { ++num1; }
            }
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(local.POvershading, "", false) == 0)
            {
              MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.GroupBox37, "Please enter Photovoltaic Overshading.");
              checked { ++num1; }
            }
            checked { ++index; }
          }
        }
        else
        {
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.cmdPhotoNew, "Please create a New Photovoltaic element.");
          int num3;
          num1 = checked (num3 + 1);
        }
      }
      if (SAP_Module.Proj.Dwellings[house].Renewable.WindTurbine.Inlcude)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Renewable.WindTurbine.WHeight, (string) null, false) == 0 | Conversions.ToDouble(SAP_Module.Proj.Dwellings[house].Renewable.WindTurbine.WHeight) == 0.0)
        {
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtWHeight, "Please enter wind turbine height.");
          checked { ++num1; }
        }
        else
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtWHeight, "");
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Renewable.WindTurbine.WRDiameter, (string) null, false) == 0 | Conversions.ToDouble(SAP_Module.Proj.Dwellings[house].Renewable.WindTurbine.WRDiameter) == 0.0)
        {
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtWRDiameter, "Please enter Rotor Diameter.");
          checked { ++num1; }
        }
        else
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtWRDiameter, "");
        if (SAP_Module.Proj.Dwellings[house].Renewable.WindTurbine.WNumber == 0 | SAP_Module.Proj.Dwellings[house].Renewable.WindTurbine.WNumber == 0)
        {
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtWNumber, "Please enter Number of turbines.");
          checked { ++num1; }
        }
        else
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtWNumber, "");
      }
      else
      {
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtWNumber, "");
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtWRDiameter, "");
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtWHeight, "");
      }
      if (SAP_Module.Proj.Dwellings[house].Renewable.AAEGeneration.Inlcude)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Renewable.AAEGeneration.TotalArea, (string) null, false) == 0 | Conversions.ToDouble(SAP_Module.Proj.Dwellings[house].Renewable.AAEGeneration.TotalArea) == 0.0)
        {
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtAAEGArea, "Please enter Total area.");
          checked { ++num1; }
        }
        else
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtAAEGArea, "");
      }
      else
      {
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtAAEGGenerated, "");
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtAAEGArea, "");
      }
      if (SAP_Module.Proj.Dwellings[house].Renewable.AAEGeneration.Inlcude & SAP_Module.Proj.Dwellings[house].Renewable.HydroGeneration.Inlcude)
      {
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtAAEGArea, "Hydro and AAEG cannot be selected at same time.");
        checked { ++num1; }
      }
      else
      {
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtAAEGGenerated, "");
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtAAEGArea, "");
      }
      if (SAP_Module.Proj.Dwellings[house].Renewable.HydroGeneration.Inlcude)
      {
        try
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Renewable.HydroGeneration.TotalArea, "", false) == 0)
            SAP_Module.Proj.Dwellings[house].Renewable.HydroGeneration.TotalArea = Conversions.ToString(0);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        if (Conversions.ToDouble(SAP_Module.Proj.Dwellings[house].Renewable.HydroGeneration.TotalArea) == 0.0)
        {
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtHydroArea, "Please enter Total area.");
          checked { ++num1; }
        }
        else
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtHydroArea, "");
      }
      else
      {
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtHydroGenerated, "");
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtHydroArea, "");
      }
      MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtSpDescription, "");
      MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtSpESaved, "");
      MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtSpFSaved, "");
      MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtSpEUsed, "");
      MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtSpFUsed, "");
      MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.GroupBox39, "");
      MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.BtnSp_Feature_add, "");
      MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtEmissionsOnly, "");
      if (SAP_Module.Proj.Dwellings[house].Renewable.Special.Include)
      {
        if (SAP_Module.Proj.Dwellings[house].Renewable.Special.Special != null)
        {
          int num4 = Information.UBound((Array) SAP_Module.Proj.Dwellings[house].Renewable.Special.Special);
          int index = 0;
          while (index <= num4)
          {
            ref SAP_Module.SpecialFeatures local = ref SAP_Module.Proj.Dwellings[house].Renewable.Special.Special[index];
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(local.Description, "", false) == 0)
            {
              MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.GroupBox39, "Please enter some description.");
              checked { ++num1; }
            }
            if (local.MakeEmissionsOnly)
            {
              if ((double) local.EmissionsAmount == 0.0)
              {
                MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtEmissionsOnly, "Enter carbon saving");
                checked { ++num1; }
              }
            }
            else
            {
              if ((double) local.EnergySaved == 0.0 | (double) local.EnergySaved == 0.0)
              {
                MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.GroupBox39, "Enter energy saved");
                checked { ++num1; }
              }
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(local.FuelSaved, "", false) == 0)
              {
                MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.GroupBox39, "Enter fuel saved");
                checked { ++num1; }
              }
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(local.FuelUsed, "", false) == 0 & (double) local.EnergyUsed != 0.0)
              {
                MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.GroupBox39, "Enter fuel used.");
                checked { ++num1; }
              }
            }
            checked { ++index; }
          }
        }
        else
        {
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.BtnSp_Feature_add, "Please create a New Special Feature element.");
          checked { ++num1; }
        }
      }
      SAP_Module.Proj.Dwellings[house].Validation.RenewablesTech_Check = num1 == 0;
      return num1;
    }

    public static int CheckErrors_Overheating(int house)
    {
      int num = 0;
      MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtOverAirType, "");
      MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtOverAirWindow, "");
      MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtOverAirach, "");
      MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtOverThermalTMP, "");
      MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtFixedAirCon, "");
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Overheat, "Yes", false) == 0)
      {
        if (!SAP_Module.Proj.Dwellings[house].OverHeating.EACOveride)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].OverHeating.EACBuildType, "", false) == 0)
          {
            MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtOverAirType, "Enter Build type");
            checked { ++num; }
          }
          else
            MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtOverAirType, "");
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].OverHeating.EACWindow, "", false) == 0)
          {
            MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtOverAirWindow, "Enter Window opening");
            checked { ++num; }
          }
          else
            MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtOverAirWindow, "");
        }
        if ((double) SAP_Module.Proj.Dwellings[house].OverHeating.EACAirChange == 0.0)
        {
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtOverAirach, "Enter effective Air Change Rate");
          checked { ++num; }
        }
        else
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtOverAirach, "");
      }
      if ((double) SAP_Module.Proj.Dwellings[house].LowEnergyLight > 100.0 | (double) SAP_Module.Proj.Dwellings[house].LowEnergyLight < 0.0)
      {
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtLowEnergyLight, "Enter low energy light");
        checked { ++num; }
      }
      else
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtLowEnergyLight, "");
      if (SAP_Module.Proj.Dwellings[house].LELOutlets < 1)
      {
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtLELOutlets, "Enter number of outlets");
        checked { ++num; }
      }
      else
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtLELOutlets, "");
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Conservatory, "", false) == 0)
      {
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtConservatory, "Select Conservatory Option");
        checked { ++num; }
      }
      else
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtConservatory, "");
      SAP_Module.Proj.Dwellings[house].Validation.OverHeating_Check = num == 0;
      return num;
    }

    public static int CheckErrors_Heating(int house)
    {
      int num1;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].SecHeating.HGroup, "Room heaters", false) == 0)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].SecHeating.SGroup, "", false) == 0)
        {
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtSSubGroup, "Please select sub group secondary system.");
          int num2;
          num1 = checked (num2 + 1);
        }
        else
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtSSubGroup, "");
        if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].SecHeating.SGroup, "", false) > 0U)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].SecHeating.InforSource, "", false) == 0)
          {
            MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtSHeatingSource, "Please select the Info source for secondary system.");
            checked { ++num1; }
          }
          else
            MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtSHeatingSource, "");
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].SecHeating.MHType, "", false) == 0)
          {
            MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtSMainHeatingType, "Please select the heating type.");
            checked { ++num1; }
          }
          else
            MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtSMainHeatingType, "");
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].SecHeating.Fuel, "", false) == 0)
          {
            MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtSMainFuel, "Please select the fuel type.");
            checked { ++num1; }
          }
          else
            MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtSMainFuel, "");
          if ((double) SAP_Module.Proj.Dwellings[house].SecHeating.SecEff == 0.0)
          {
            MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtSEfficiency, "Please enter efficiency for secondary heating.");
            checked { ++num1; }
          }
          else
            MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtSEfficiency, "");
        }
        else
        {
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtSMainHeatingType, "");
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtSHeatingSource, "");
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtSMainFuel, "");
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtSEfficiency, "");
        }
      }
      string hgroup = SAP_Module.Proj.Dwellings[house].MainHeating.HGroup;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(hgroup, "Boiler systems with radiators or underfloor heating", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(hgroup, "Micro-Congeneration (Micro-CHP)", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(hgroup, "Heat pumps with radiators or underfloor heating", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(hgroup, "Heat pumps with warm air distribution", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(hgroup, "Other space heating systems", false) != 0)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(hgroup, "Community heating schemes", false) == 0)
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtHeatingEmitter, "");
      }
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].MainHeating.Emitter, "", false) == 0)
      {
        if (SAP_Module.Proj.Dwellings[house].MainHeating.SAPTableCode != 701)
        {
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtHeatingEmitter, "Please enter emitter type");
          checked { ++num1; }
        }
        else
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtHeatingEmitter, "");
      }
      else
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtHeatingEmitter, "");
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].MainHeating.SGroup, "Gas boilers and oil boilers", false) == 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].MainHeating.InforSource, "Boiler Database", false) == 0 && SAP_Module.Proj.Dwellings[house].MainHeating.SEDBUK != null)
      {
        PCDF.SEDBUK sedbuk = SAP_Module.PCDFData.Boilers.Where<PCDF.SEDBUK>((Func<PCDF.SEDBUK, bool>) (b => b.ID.Equals(SAP_Module.Proj.Dwellings[house].MainHeating.SEDBUK.ToString()))).SingleOrDefault<PCDF.SEDBUK>();
        if (sedbuk != null)
        {
          try
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(sedbuk.SubType, "1", false) == 0)
            {
              SAP_Module.Proj.Dwellings[house].Water.FGHRS.Include = true;
              SAP_Module.Proj.Dwellings[house].Water.FGHRS.IndexNo = sedbuk.SubTypeIndex;
            }
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
        }
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].MainHeating.HGroup, "No heating system present", false) == 0)
      {
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtPrimary, "");
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtHeatingSource, "");
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtSubGroup, "");
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtHeatingControls, "");
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtMainFuel, "");
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtEfficiency, "");
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtElectricityTariff, "");
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtPumpHP, "");
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtBILock, "");
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtBFlueType, "");
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtFanFlued, "");
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtLoadWeather, "");
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtKeepHotFuel, "");
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtMainHeatingType, "");
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtBoilerSub, "");
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtHeatingEmitter, "");
      }
      else
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].MainHeating.HGroup, "", false) == 0)
        {
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtPrimary, "Please select primary heating");
          checked { ++num1; }
        }
        else
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtPrimary, "");
        if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].MainHeating.HGroup, "", false) > 0U)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].MainHeating.HGroup, "Community heating schemes", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].MainHeating.HGroup, "Other space heating systems", false) == 0)
          {
            MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtSubGroup, "");
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].MainHeating.InforSource, "", false) == 0)
            {
              MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtHeatingSource, "Please select heating source");
              checked { ++num1; }
            }
            else
              MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtHeatingSource, "");
          }
          else
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].MainHeating.InforSource, "", false) == 0)
            {
              MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtHeatingSource, "Please select heating source");
              checked { ++num1; }
            }
            else
              MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtHeatingSource, "");
            MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtSubGroup, "");
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].MainHeating.SGroup, "", false) == 0)
            {
              MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtSubGroup, "Please select sub group");
              checked { ++num1; }
            }
            else
              MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtSubGroup, "");
          }
        }
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].MainHeating.InforSource, "SAP Tables", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].MainHeating.InforSource, "Manufacturer Declaration", false) == 0)
        {
          if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].MainHeating.SGroup, "", false) > 0U)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].MainHeating.SGroup, "Gas boilers and oil boilers", false) == 0)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].MainHeating.BSubGroup, "", false) == 0)
              {
                MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtBoilerSub, "Please select Boiler sub group");
                checked { ++num1; }
              }
              else
              {
                MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtBoilerSub, "");
                if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].MainHeating.SGroup, "Micro-cogeneration (micro-CHP)", false) > 0U)
                {
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].MainHeating.MHType, "", false) == 0)
                  {
                    MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtMainHeatingType, "Please select Heating Type");
                    checked { ++num1; }
                  }
                  else
                    MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtMainHeatingType, "");
                }
              }
            }
            else
            {
              MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtBoilerSub, "");
              if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].MainHeating.SGroup, "Micro-cogeneration (micro-CHP)", false) > 0U)
              {
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].MainHeating.MHType, "", false) == 0)
                {
                  MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtMainHeatingType, "Please select Heating Type");
                  checked { ++num1; }
                }
                else
                  MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtMainHeatingType, "");
              }
            }
          }
          else
          {
            MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtBoilerSub, "");
            if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].MainHeating.SGroup, "Micro-cogeneration (micro-CHP)", false) > 0U)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].MainHeating.MHType, "", false) == 0)
              {
                MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtMainHeatingType, "Please select Heating Type");
                checked { ++num1; }
              }
              else
                MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtMainHeatingType, "");
            }
          }
        }
        else
        {
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtBoilerSub, "");
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtMainHeatingType, "");
        }
        if (SAP_Module.Proj.Dwellings[house].MainHeating.CommunityH.KnownLoss)
        {
          if ((double) SAP_Module.Proj.Dwellings[house].MainHeating.CommunityH.KnownLossValue == 0.0)
          {
            MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtLossKnown, "Please enter known loss value.");
            checked { ++num1; }
          }
          else
            MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtLossKnown, "");
        }
        else
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtLossKnown, "");
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].MainHeating.Controls, "", false) == 0)
        {
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtHeatingControls, "Please select heating control");
          checked { ++num1; }
        }
        else
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtHeatingControls, "");
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].MainHeating.Fuel, "", false) == 0)
        {
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtMainFuel, "Please select fuel.");
          checked { ++num1; }
        }
        else
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtMainFuel, "");
        if ((double) SAP_Module.Proj.Dwellings[house].MainHeating.MainEff == 0.0)
          SAP_Module.Proj.Dwellings[house].MainHeating.MainEff = 0.0f;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].MainHeating.ElectricityTariff, "", false) == 0)
        {
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtElectricityTariff, "Please select tariff.");
          checked { ++num1; }
        }
        else
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtElectricityTariff, "");
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].MainHeating.SGroup, "Off-peak tariffs", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].MainHeating.SGroup, "24-hour heating tariff", false) == 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].MainHeating.ElectricityTariff, "standard tariff", false) == 0)
          {
            MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtElectricityTariff, "Please select tariff.");
            checked { ++num1; }
          }
          else
            MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtElectricityTariff, "");
        }
        else
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtElectricityTariff, "");
        if (SAP_Module.Proj.Dwellings[house].MainHeating.Boiler.IncludeKeepHot)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].MainHeating.Boiler.KeepHotFuel, "", false) == 0)
          {
            MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtKeepHotFuel, "Please select fuel.");
            checked { ++num1; }
          }
          else
            MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtKeepHotFuel, "");
        }
        else
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtKeepHotFuel, "");
        if (SAP_Module.Proj.Dwellings[house].MainHeating.Boiler.LoadWeather)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].MainHeating.ControlCodePCDFWeather, "", false) == 0)
          {
            MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.cmdMainControlSelectWeather, "Please select Load weather type.");
            checked { ++num1; }
          }
          else
            MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.cmdMainControlSelectWeather, "");
        }
        else
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.cmdMainControlSelectWeather, "");
      }
      MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtCommHB1Efficiency, "");
      MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtCommHB1HFraction, "");
      MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtCommHB1HeatToPower, "");
      MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtCommHDS, "");
      MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtCommHAdd1Efficiency, "");
      MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtCommHAdd1Fraction, "");
      MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtCommHAdd1Fuel, "");
      MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtCommHAdd1Type, "");
      MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtCommHAdd2Efficiency, "");
      MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtCommHAdd2Fraction, "");
      MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtCommHAdd2Fuel, "");
      MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtCommHAdd2Type, "");
      MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtCommHAdd3Efficiency, "");
      MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtCommHAdd3Fraction, "");
      MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtCommHAdd3Fuel, "");
      MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtCommHAdd3Type, "");
      MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtCommHAdd4Efficiency, "");
      MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtCommHAdd4Fraction, "");
      MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtCommHAdd4Fuel, "");
      MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtCommHAdd4Type, "");
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].MainHeating.HGroup, "Community heating schemes", false) == 0)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].MainHeating.MHType, "Community CHP", false) == 0 && (double) SAP_Module.Proj.Dwellings[house].MainHeating.CommunityH.HeatToPowerRatio == 0.0)
        {
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtCommHB1HeatToPower, "Please specify the CHP Power Efficiency");
          checked { ++num1; }
        }
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].MainHeating.InforSource, "Boiler Database", false) != 0)
        {
          if ((double) SAP_Module.Proj.Dwellings[house].MainHeating.CommunityH.Boiler1Efficiency == 0.0)
          {
            MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtCommHB1Efficiency, "Please specify the efficiency");
            checked { ++num1; }
          }
          if ((double) SAP_Module.Proj.Dwellings[house].MainHeating.CommunityH.Boiler1HeatFraction == 0.0)
          {
            MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtCommHB1HFraction, "Please specify the heat fraction");
            checked { ++num1; }
          }
        }
        if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].MainHeating.InforSource, "Boiler Database", false) > 0U)
        {
          if (SAP_Module.Proj.Dwellings[house].MainHeating.CommunityH.KnownLoss)
            MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtCommHDS, "");
          else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].MainHeating.CommunityH.HeatDSystem, "", false) == 0)
          {
            MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtCommHDS, "Please specify the heat distribution system");
            checked { ++num1; }
          }
          float boiler1HeatFraction = SAP_Module.Proj.Dwellings[house].MainHeating.CommunityH.Boiler1HeatFraction;
          if (SAP_Module.Proj.Dwellings[house].MainHeating.CommunityH.NoOfAdditionalHeatSources > 0)
          {
            if ((double) SAP_Module.Proj.Dwellings[house].MainHeating.CommunityH.HeatSource1.Efficiency == 0.0)
            {
              MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtCommHAdd1Efficiency, "Please specify the efficiency");
              checked { ++num1; }
            }
            if ((double) SAP_Module.Proj.Dwellings[house].MainHeating.CommunityH.HeatSource1.HeatFraction == 0.0)
            {
              MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtCommHAdd1Fraction, "Please specify the fraction");
              checked { ++num1; }
            }
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].MainHeating.CommunityH.HeatSource1.Fuel, "", false) == 0)
            {
              MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtCommHAdd1Fuel, "Please specify the fuel");
              checked { ++num1; }
            }
            if (SAP_Module.Proj.Dwellings[house].MainHeating.CommunityH.HeatSource1.Type == 0)
            {
              MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtCommHAdd1Type, "Please specify the type");
              checked { ++num1; }
            }
            boiler1HeatFraction += SAP_Module.Proj.Dwellings[house].MainHeating.CommunityH.HeatSource1.HeatFraction;
          }
          if (SAP_Module.Proj.Dwellings[house].MainHeating.CommunityH.NoOfAdditionalHeatSources > 1)
          {
            if ((double) SAP_Module.Proj.Dwellings[house].MainHeating.CommunityH.HeatSource2.Efficiency == 0.0)
            {
              MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtCommHAdd2Efficiency, "Please specify the efficiency");
              checked { ++num1; }
            }
            if ((double) SAP_Module.Proj.Dwellings[house].MainHeating.CommunityH.HeatSource2.HeatFraction == 0.0)
            {
              MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtCommHAdd1Fraction, "Please specify the fraction");
              checked { ++num1; }
            }
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].MainHeating.CommunityH.HeatSource2.Fuel, "", false) == 0)
            {
              MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtCommHAdd2Fuel, "Please specify the fuel");
              checked { ++num1; }
            }
            if (SAP_Module.Proj.Dwellings[house].MainHeating.CommunityH.HeatSource2.Type == 0)
            {
              MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtCommHAdd2Type, "Please specify the type");
              checked { ++num1; }
            }
            boiler1HeatFraction += SAP_Module.Proj.Dwellings[house].MainHeating.CommunityH.HeatSource2.HeatFraction;
          }
          if (SAP_Module.Proj.Dwellings[house].MainHeating.CommunityH.NoOfAdditionalHeatSources > 2)
          {
            if ((double) SAP_Module.Proj.Dwellings[house].MainHeating.CommunityH.HeatSource3.Efficiency == 0.0)
            {
              MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtCommHAdd3Efficiency, "Please specify the efficiency");
              checked { ++num1; }
            }
            if ((double) SAP_Module.Proj.Dwellings[house].MainHeating.CommunityH.HeatSource3.HeatFraction == 0.0)
            {
              MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtCommHAdd3Fraction, "Please specify the fraction");
              checked { ++num1; }
            }
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].MainHeating.CommunityH.HeatSource3.Fuel, "", false) == 0)
            {
              MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtCommHAdd3Fuel, "Please specify the fuel");
              checked { ++num1; }
            }
            if (SAP_Module.Proj.Dwellings[house].MainHeating.CommunityH.HeatSource3.Type == 0)
            {
              MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtCommHAdd3Type, "Please specify the type");
              checked { ++num1; }
            }
            boiler1HeatFraction += SAP_Module.Proj.Dwellings[house].MainHeating.CommunityH.HeatSource3.HeatFraction;
          }
          if (SAP_Module.Proj.Dwellings[house].MainHeating.CommunityH.NoOfAdditionalHeatSources > 3)
          {
            if ((double) SAP_Module.Proj.Dwellings[house].MainHeating.CommunityH.HeatSource4.Efficiency == 0.0)
            {
              MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtCommHAdd4Efficiency, "Please specify the efficiency");
              checked { ++num1; }
            }
            if ((double) SAP_Module.Proj.Dwellings[house].MainHeating.CommunityH.HeatSource4.HeatFraction == 0.0)
            {
              MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtCommHAdd4Fraction, "Please specify the fraction");
              checked { ++num1; }
            }
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].MainHeating.CommunityH.HeatSource4.Fuel, "", false) == 0)
            {
              MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtCommHAdd4Fuel, "Please specify the fuel");
              checked { ++num1; }
            }
            if (SAP_Module.Proj.Dwellings[house].MainHeating.CommunityH.HeatSource4.Type == 0)
            {
              MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtCommHAdd4Type, "Please specify the type");
              checked { ++num1; }
            }
            boiler1HeatFraction += SAP_Module.Proj.Dwellings[house].MainHeating.CommunityH.HeatSource4.HeatFraction;
          }
          if (Conversion.Val((object) boiler1HeatFraction) != 1.0)
          {
            MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtCommHB1HFraction, "The total fraction doesn't total 1");
            checked { ++num1; }
          }
        }
      }
      if (!SAP_Module.Proj.OverRide)
      {
        if (SAP_Module.Proj.Dwellings[house].MainHeating.Boiler.LoadWeather)
        {
          if (SAP_Module.Proj.Dwellings[house].MainHeating.ControlCodePCDFWeather != null)
          {
            if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].MainHeating.ControlCodePCDFWeather, "", false) > 0U)
            {
              if (!Validation.CheckControlCapabilities(house))
              {
                checked { ++num1; }
                MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.chkMainHLoadWeather, "Incompatibility error: Weather Compensator " + SAP_Module.Proj.Dwellings[house].MainHeating.ControlCodePCDFWeather + " with Boiler " + SAP_Module.Proj.Dwellings[house].MainHeating.SEDBUK + " is not allowed.");
              }
              else
                MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.chkMainHLoadWeather, "");
            }
            else
              MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.chkMainHLoadWeather, "");
          }
          else
            MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.chkMainHLoadWeather, "");
        }
        else
          MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.chkMainHLoadWeather, "");
      }
      else
        MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.chkMainHLoadWeather, "");
      int num3 = checked (num1 + Validation.CheckErrors_Heating2(house) + Validation.CheckErrors_Cooling(house));
      SAP_Module.Proj.Dwellings[house].Validation.Heating_Check = num3 == 0;
      if (!SAP_Module.Proj.OverRide)
        SAP_Module.Proj.Dwellings[house].Validation.Heating_Check = Validation.CheckControlCapabilities(house);
      return num3;
    }

    public static bool CheckControlCapabilities(int House)
    {
      bool flag = false;
      if (SAP_Module.Proj.Dwellings[House].MainHeating.Boiler.LoadWeather)
      {
        if (Conversion.Val(SAP_Module.Proj.Dwellings[House].MainHeating.ControlCodePCDFWeather) > 0.0)
        {
          try
          {
            PCDF.SEDBUK sedbuk = SAP_Module.PCDFData.Boilers.Where<PCDF.SEDBUK>((Func<PCDF.SEDBUK, bool>) (b => b.ID.Equals(SAP_Module.Proj.Dwellings[House].MainHeating.SEDBUK))).SingleOrDefault<PCDF.SEDBUK>();
            string sgroup = SAP_Module.Proj.Dwellings[House].MainHeating.SGroup;
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(sgroup, "Gas boilers and oil boilers", false) != 0)
            {
              if ((Microsoft.VisualBasic.CompilerServices.Operators.CompareString(sgroup, "Electric heat pumps", false) == 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(sgroup, "Gas-fired heat pumps", false) == 0) && Conversions.ToDouble(SAP_Module.Proj.Dwellings[House].MainHeating.ControlCategory) == 4.0)
                flag = true;
            }
            else if (Conversions.ToDouble(SAP_Module.Proj.Dwellings[House].MainHeating.ControlCategory) == 2.0)
              flag = true;
            if (sedbuk.Fuel != null)
            {
              double num = Conversion.Val(sedbuk.Fuel);
              if (num == 1.0)
                sedbuk.Fuel = "mains gas";
              else if (num == 2.0)
                sedbuk.Fuel = "bulk LPG";
              else if (num == 3.0)
                sedbuk.Fuel = "bottled LPG";
              else if (num == 4.0)
                sedbuk.Fuel = "heating oil";
              else if (num == 11.0)
                sedbuk.Fuel = "house coal";
              else if (num == 12.0)
                sedbuk.Fuel = "smokeless fuel";
              else if (num == 13.0)
                sedbuk.Fuel = "anthracite";
              else if (num == 20.0)
                sedbuk.Fuel = "wood logs";
              else if (num == 21.0)
                sedbuk.Fuel = "wood chips";
              else if (num == 23.0)
                sedbuk.Fuel = "wood pellets";
              else if (num == 10.0)
                sedbuk.Fuel = "dual fuel appliance (mineral and wood)";
              else if (num == 11.0)
                sedbuk.Fuel = "house coal";
              else if (num == 45.0)
                sedbuk.Fuel = "waste heat from power stations";
              else if (num == 49.0)
                sedbuk.Fuel = "electricity generated by CHP";
              else if (num == 50.0)
                sedbuk.Fuel = "heat from boilers – B30D1";
              else if (num == 52.0)
                sedbuk.Fuel = "heat from boilers – LPG";
              else if (num == 53.0)
                sedbuk.Fuel = "heat from boilers – oil";
              else if (num == 39.0)
                sedbuk.Fuel = "Electricity";
            }
            flag = flag && SAP_Module.Proj.Dwellings[House].MainHeating.SAPTableCode == 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.ControlFuel, sedbuk.Fuel, false) == 0;
            if (SAP_Module.Proj.OverRide)
            {
              if (flag)
              {
                int num1 = int.Parse(SAP_Module.Proj.Dwellings[House].MainHeating.ControlCapability, NumberStyles.HexNumber);
                int num2 = int.Parse(sedbuk.ControlCapabilities, NumberStyles.HexNumber);
                if ((num1 & num2) == num2)
                  flag = true;
              }
            }
            else if (flag)
              flag = Conversion.Val(sedbuk.ControlCapabilities) >= Conversion.Val(SAP_Module.Proj.Dwellings[House].MainHeating.ControlCapability);
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
        }
        else
          flag = true;
      }
      else
        flag = true;
      return flag;
    }

    public static int CheckErrors_Heating2(int house)
    {
      MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtSECPrimary, "");
      MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtSecHeatingSource, "");
      MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtSecSubGroup, "");
      MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtSecHeatingControls, "");
      MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtSecMainFuel, "");
      MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtSecEfficiency, "");
      MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtSecPumpHP, "");
      MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtSecBILock, "");
      MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtSecBFlueType, "");
      MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtSecFanFlued, "");
      MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtSecLoadWeather, "");
      MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtSecKeepHotFuel, "");
      MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtSecMainHeatingType, "");
      MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtSecBoilerSub, "");
      MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtSecHeatingEmitter, "");
      int num1;
      if (SAP_Module.Proj.Dwellings[house].IncludeMainHeating2)
      {
        string hgroup = SAP_Module.Proj.Dwellings[house].MainHeating2.HGroup;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(hgroup, "Boiler systems with radiators or underfloor heating", false) == 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(hgroup, "Micro-Congeneration (Micro-CHP)", false) == 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(hgroup, "Heat pumps with radiators or underfloor heating", false) == 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(hgroup, "Heat pumps with warm air distribution", false) == 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(hgroup, "Other space heating systems", false) == 0)
        {
          if (!SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.HPOnly.HotWaterOnlyHP)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].MainHeating2.Emitter, "", false) == 0)
              MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtSecHeatingEmitter, "Please enter emitter type");
            else
              MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtSecHeatingEmitter, "");
          }
          else
          {
            MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtSecHeatingEmitter, "");
            MyProject.Forms.SAPForm.txtSecHeatingEmitter.Enabled = false;
          }
        }
        int num2;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].MainHeating2.HGroup, "No heating system present", false) != 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].MainHeating2.HGroup, "", false) == 0)
          {
            MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtSECPrimary, "Please select primary heating");
            int num3;
            num2 = checked (num3 + 1);
          }
          else
            MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtSECPrimary, "");
          if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].MainHeating2.HGroup, "", false) > 0U)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].MainHeating2.HGroup, "Community heating schemes", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].MainHeating2.HGroup, "Other space heating systems", false) == 0)
            {
              MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtSecSubGroup, "");
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].MainHeating2.InforSource, "", false) == 0)
              {
                MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtSecHeatingSource, "Please select heating source");
                checked { ++num2; }
              }
              else
                MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtSecHeatingSource, "");
            }
            else
            {
              MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtSecSubGroup, "");
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].MainHeating2.SGroup, "", false) == 0)
              {
                MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtSecSubGroup, "Please select sub group");
                checked { ++num2; }
              }
              else
                MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtSecSubGroup, "");
            }
          }
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].MainHeating2.InforSource, "SAP Tables", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].MainHeating2.InforSource, "Manufacturer Declaration", false) == 0)
          {
            if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].MainHeating2.SGroup, "", false) > 0U)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].MainHeating2.SGroup, "Gas boilers and oil boilers", false) == 0)
              {
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].MainHeating2.BSubGroup, "", false) == 0)
                {
                  MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtSecBoilerSub, "Please select Boiler sub group");
                  checked { ++num2; }
                }
                else
                {
                  MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtSecBoilerSub, "");
                  if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].MainHeating2.SGroup, "Micro-cogeneration (micro-CHP)", false) > 0U)
                  {
                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].MainHeating2.MHType, "", false) == 0)
                    {
                      MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtSecMainHeatingType, "Please select Heating Type");
                      checked { ++num2; }
                    }
                    else
                      MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtSecMainHeatingType, "");
                  }
                }
              }
              else
              {
                MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtSecBoilerSub, "");
                if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].MainHeating2.SGroup, "Micro-cogeneration (micro-CHP)", false) > 0U)
                {
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].MainHeating2.MHType, "", false) == 0)
                  {
                    MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtSecMainHeatingType, "Please select Heating Type");
                    checked { ++num2; }
                  }
                  else
                    MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtSecMainHeatingType, "");
                }
              }
            }
            else
            {
              MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtSecBoilerSub, "");
              if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].MainHeating2.SGroup, "Micro-cogeneration (micro-CHP)", false) > 0U)
              {
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].MainHeating2.MHType, "", false) == 0)
                {
                  MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtSecMainHeatingType, "Please select Heating Type");
                  checked { ++num2; }
                }
                else
                  MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtSecMainHeatingType, "");
              }
            }
          }
          else
          {
            MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtSecBoilerSub, "");
            MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtSecMainHeatingType, "");
          }
          if (SAP_Module.Proj.Dwellings[house].WaterOnlyHeatPump)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].MainHeating2.Emitter, "", false) == 0)
              MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtSecHeatingEmitter, "");
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].MainHeating.HGroup, "Community heating schemes", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].MainHeating.HGroup, "Micro-Congeneration (Micro-CHP)", false) == 0)
            {
              MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtSECPrimary, "Can't use water only  heat pump with this system.");
              checked { ++num2; }
            }
            else
              MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtSECPrimary, "");
          }
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].MainHeating2.Controls, "", false) == 0)
          {
            MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtSecHeatingControls, "Please select heating control");
            checked { ++num2; }
          }
          else
            MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtSecHeatingControls, "");
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].MainHeating2.Fuel, "", false) == 0)
          {
            MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtSecMainFuel, "Please select fuel.");
            checked { ++num2; }
          }
          else
            MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtSecMainFuel, "");
          if ((double) SAP_Module.Proj.Dwellings[house].MainHeating2.MainEff == 0.0)
            SAP_Module.Proj.Dwellings[house].MainHeating2.MainEff = 0.0f;
          if (SAP_Module.Proj.Dwellings[house].MainHeating2.Boiler.IncludeKeepHot)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].MainHeating2.Boiler.KeepHotFuel, "", false) == 0)
            {
              MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtSecKeepHotFuel, "Please select fuel.");
              checked { ++num2; }
            }
            else
              MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtSecKeepHotFuel, "");
          }
          else
            MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtSecKeepHotFuel, "");
          if (SAP_Module.Proj.Dwellings[house].MainHeating2.Boiler.LoadWeather)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].MainHeating2.Boiler.LoadWeatherType, "", false) == 0)
            {
              MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtSecLoadWeather, "Please select Load weather type.");
              checked { ++num2; }
            }
            else
              MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtSecLoadWeather, "");
          }
          else
            MyProject.Forms.SAPForm.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.txtSecLoadWeather, "");
        }
        num1 = num2;
      }
      return num1;
    }

    public static void Checkerrors_All(int house)
    {
      if (house == -1)
        return;
      Validation.CheckErrors_Dims(house);
      Validation.CheckErrors_Heating(house);
      Validation.CheckErrors_Opaque(house);
      Validation.CheckErrors_Propertys(house);
      Validation.CheckErrors_Overheating(house);
      Validation.CheckErrors_Ventilation(house);
      Validation.CheckErrors_RenewableTech(house);
      Validation.CheckErrors_WaterHeating(house);
      Validation.CheckErrors_Openings(house);
    }

    public static bool LodgementStatusCheck(int House)
    {
      bool flag;
      try
      {
        flag = SAP_Module.Proj.Dwellings[House].Validation.Dims_Check && SAP_Module.Proj.Dwellings[House].Validation.Heating_Check && SAP_Module.Proj.Dwellings[House].Validation.Opaque_Check && SAP_Module.Proj.Dwellings[House].Validation.Openings_Check && SAP_Module.Proj.Dwellings[House].Validation.OverHeating_Check && SAP_Module.Proj.Dwellings[House].Validation.Property_Check && SAP_Module.Proj.Dwellings[House].Validation.WaterHeating_Check && SAP_Module.Proj.Dwellings[House].Validation.Ventilation_Check && SAP_Module.Proj.Dwellings[House].Validation.RenewablesTech_Check;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      return flag;
    }

    public static int Checkerrors_Door(int house, int i)
    {
      int num1 = 0;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Doors[i].Location, "", false) == 0)
      {
        MyProject.Forms.Doors.ErrorPChecker.SetError((Control) MyProject.Forms.Doors.txtLocation, "Please select location.");
        checked { ++num1; }
      }
      else
        MyProject.Forms.Doors.ErrorPChecker.SetError((Control) MyProject.Forms.Doors.txtLocation, "");
      bool flag = false;
      try
      {
        if (SAP_Module.Proj.Dwellings[house].NoofWalls > 0)
        {
          int num2 = checked (SAP_Module.Proj.Dwellings[house].NoofWalls - 1);
          int index = 0;
          while (index <= num2)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Walls[index].Name, SAP_Module.Proj.Dwellings[house].Doors[i].Location, false) == 0)
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
      if (!flag)
      {
        MyProject.Forms.Doors.ErrorPChecker.SetError((Control) MyProject.Forms.Doors.txtLocation, "Wall name is incorrect in door location.");
        checked { ++num1; }
      }
      else
        MyProject.Forms.Doors.ErrorPChecker.SetError((Control) MyProject.Forms.Doors.txtLocation, "");
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Doors[i].Overshading, "", false) != 0)
        ;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Doors[i].Name, "", false) == 0)
      {
        MyProject.Forms.Doors.ErrorPChecker.SetError((Control) MyProject.Forms.Doors.txtName, "Please enter Name.");
        checked { ++num1; }
      }
      else
        MyProject.Forms.Doors.ErrorPChecker.SetError((Control) MyProject.Forms.Doors.txtName, "");
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Doors[i].DoorType, "", false) == 0)
      {
        MyProject.Forms.Doors.ErrorPChecker.SetError((Control) MyProject.Forms.Doors.txtDoorType, "Please select door type.");
        checked { ++num1; }
      }
      else
        MyProject.Forms.Doors.ErrorPChecker.SetError((Control) MyProject.Forms.Doors.txtDoorType, "");
      if ((double) SAP_Module.Proj.Dwellings[house].Doors[i].Area == 0.0 | (double) SAP_Module.Proj.Dwellings[house].Doors[i].Area == 0.0)
      {
        MyProject.Forms.Doors.ErrorPChecker.SetError((Control) MyProject.Forms.Doors.txtArea, "Please enter area");
        checked { ++num1; }
      }
      else
        MyProject.Forms.Doors.ErrorPChecker.SetError((Control) MyProject.Forms.Doors.txtArea, "");
      if ((double) SAP_Module.Proj.Dwellings[house].Doors[i].U == 0.0 | (double) SAP_Module.Proj.Dwellings[house].Doors[i].U == 0.0)
      {
        MyProject.Forms.Doors.ErrorPChecker.SetError((Control) MyProject.Forms.Doors.txtU, "Please enter u value");
        checked { ++num1; }
      }
      else
        MyProject.Forms.Doors.ErrorPChecker.SetError((Control) MyProject.Forms.Doors.txtU, "");
      try
      {
        if ((double) SAP_Module.Proj.Dwellings[house].Doors[i].FF > 1.0)
        {
          MyProject.Forms.Doors.ErrorPChecker.SetError((Control) MyProject.Forms.Doors.txtFF, "Value can not be greater then 1.");
          checked { ++num1; }
        }
        else
          MyProject.Forms.Doors.ErrorPChecker.SetError((Control) MyProject.Forms.Doors.txtFF, "");
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      return num1;
    }

    public static int Checkerrors_Windows(int house, int i)
    {
      int num1 = 0;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Windows[i].Location, "", false) == 0)
      {
        MyProject.Forms.Windows.ErrorPChecker.SetError((Control) MyProject.Forms.Windows.txtLocation, "Please select location.");
        checked { ++num1; }
      }
      else
        MyProject.Forms.Windows.ErrorPChecker.SetError((Control) MyProject.Forms.Windows.txtLocation, "");
      bool flag = false;
      try
      {
        if (SAP_Module.Proj.Dwellings[house].NoofWalls > 0)
        {
          int num2 = checked (SAP_Module.Proj.Dwellings[house].NoofWalls - 1);
          int index = 0;
          while (index <= num2)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Walls[index].Name, SAP_Module.Proj.Dwellings[house].Windows[i].Location, false) == 0)
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
      if (!flag)
      {
        MyProject.Forms.Windows.ErrorPChecker.SetError((Control) MyProject.Forms.Windows.txtLocation, "Wall name is incorrect in Windows location.");
        checked { ++num1; }
      }
      else
        MyProject.Forms.Windows.ErrorPChecker.SetError((Control) MyProject.Forms.Windows.txtLocation, "");
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Windows[i].Name, "", false) == 0)
      {
        MyProject.Forms.Windows.ErrorPChecker.SetError((Control) MyProject.Forms.Windows.txtName, "Please enter Name.");
        checked { ++num1; }
      }
      else
        MyProject.Forms.Windows.ErrorPChecker.SetError((Control) MyProject.Forms.Windows.txtName, "");
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Windows[i].GlazingType, "", false) == 0)
      {
        MyProject.Forms.Windows.ErrorPChecker.SetError((Control) MyProject.Forms.Windows.txtGlazingType, "Please select glazing type.");
        checked { ++num1; }
      }
      else
        MyProject.Forms.Windows.ErrorPChecker.SetError((Control) MyProject.Forms.Windows.txtGlazingType, "");
      if ((double) SAP_Module.Proj.Dwellings[house].Windows[i].Area == 0.0 | (double) SAP_Module.Proj.Dwellings[house].Windows[i].Area == 0.0)
      {
        MyProject.Forms.Windows.ErrorPChecker.SetError((Control) MyProject.Forms.Windows.txtArea, "Please enter area");
        checked { ++num1; }
      }
      else
        MyProject.Forms.Windows.ErrorPChecker.SetError((Control) MyProject.Forms.Windows.txtArea, "");
      if ((double) SAP_Module.Proj.Dwellings[house].Windows[i].g == 0.0 | (double) SAP_Module.Proj.Dwellings[house].Windows[i].g == 0.0)
      {
        MyProject.Forms.Windows.ErrorPChecker.SetError((Control) MyProject.Forms.Windows.txtg, "Please enter u value");
        checked { ++num1; }
      }
      else
        MyProject.Forms.Windows.ErrorPChecker.SetError((Control) MyProject.Forms.Windows.txtg, "");
      if ((double) SAP_Module.Proj.Dwellings[house].Windows[i].U == 0.0 | (double) SAP_Module.Proj.Dwellings[house].Windows[i].U == 0.0)
      {
        MyProject.Forms.Windows.ErrorPChecker.SetError((Control) MyProject.Forms.Windows.txtU, "Please enter u value");
        checked { ++num1; }
      }
      else
        MyProject.Forms.Windows.ErrorPChecker.SetError((Control) MyProject.Forms.Windows.txtU, "");
      return num1;
    }

    public static int Checkerrors_RoofLights(int house, int i)
    {
      int num1 = 0;
      bool flag = false;
      if (!(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].RoofLights[i].Location, "", false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].RoofLights[i].Name, "", false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].RoofLights[i].GlazingType, "", false) == 0 & (double) SAP_Module.Proj.Dwellings[house].RoofLights[i].Area == 0.0 & (double) SAP_Module.Proj.Dwellings[house].RoofLights[i].U == 0.0))
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].RoofLights[i].Location, "", false) == 0)
        {
          MyProject.Forms.RoofWindows.ErrorPChecker.SetError((Control) MyProject.Forms.RoofWindows.txtLocation, "Please select location.");
          checked { ++num1; }
        }
        else
          MyProject.Forms.RoofWindows.ErrorPChecker.SetError((Control) MyProject.Forms.RoofWindows.txtLocation, "");
        try
        {
          if (SAP_Module.Proj.Dwellings[house].NoofRoofs > 0)
          {
            int num2 = checked (SAP_Module.Proj.Dwellings[house].NoofRoofs - 1);
            int index = 0;
            while (index <= num2)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Roofs[index].Name, SAP_Module.Proj.Dwellings[house].RoofLights[i].Location, false) == 0)
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
        if (!flag)
        {
          MyProject.Forms.RoofWindows.ErrorPChecker.SetError((Control) MyProject.Forms.RoofWindows.txtLocation, "Roof name is incorrect in roof Windows location.");
          checked { ++num1; }
        }
        else
          MyProject.Forms.RoofWindows.ErrorPChecker.SetError((Control) MyProject.Forms.RoofWindows.txtLocation, "");
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].RoofLights[i].Name, "", false) == 0)
        {
          MyProject.Forms.RoofWindows.ErrorPChecker.SetError((Control) MyProject.Forms.RoofWindows.txtName, "Please enter Name.");
          checked { ++num1; }
        }
        else
          MyProject.Forms.RoofWindows.ErrorPChecker.SetError((Control) MyProject.Forms.RoofWindows.txtName, "");
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].RoofLights[i].GlazingType, "", false) == 0)
        {
          MyProject.Forms.RoofWindows.ErrorPChecker.SetError((Control) MyProject.Forms.RoofWindows.txtGlazingType, "Please select glazing type.");
          checked { ++num1; }
        }
        else
          MyProject.Forms.RoofWindows.ErrorPChecker.SetError((Control) MyProject.Forms.RoofWindows.txtGlazingType, "");
        if ((double) SAP_Module.Proj.Dwellings[house].RoofLights[i].Area == 0.0 | (double) SAP_Module.Proj.Dwellings[house].RoofLights[i].Area == 0.0)
        {
          MyProject.Forms.RoofWindows.ErrorPChecker.SetError((Control) MyProject.Forms.RoofWindows.txtArea, "Please enter area");
          checked { ++num1; }
        }
        else
          MyProject.Forms.RoofWindows.ErrorPChecker.SetError((Control) MyProject.Forms.RoofWindows.txtArea, "");
        if ((double) SAP_Module.Proj.Dwellings[house].RoofLights[i].U == 0.0 | (double) SAP_Module.Proj.Dwellings[house].RoofLights[i].U == 0.0)
        {
          MyProject.Forms.RoofWindows.ErrorPChecker.SetError((Control) MyProject.Forms.RoofWindows.txtU, "Please enter U value");
          checked { ++num1; }
        }
        else
          MyProject.Forms.RoofWindows.ErrorPChecker.SetError((Control) MyProject.Forms.RoofWindows.txtU, "");
      }
      return num1;
    }

    public static DataTable ListToDataTable<T>(List<T> items)
    {
      DataTable dataTable = new DataTable(typeof (T).Name);
      PropertyInfo[] properties = typeof (T).GetProperties(BindingFlags.Instance | BindingFlags.Public);
      PropertyInfo[] propertyInfoArray = properties;
      int index1 = 0;
      while (index1 < propertyInfoArray.Length)
      {
        PropertyInfo propertyInfo = propertyInfoArray[index1];
        dataTable.Columns.Add(propertyInfo.Name);
        checked { ++index1; }
      }
      try
      {
        foreach (T obj in items)
        {
          object[] objArray = new object[checked (properties.Length - 1 + 1)];
          int num = checked (properties.Length - 1);
          int index2 = 0;
          while (index2 <= num)
          {
            objArray[index2] = RuntimeHelpers.GetObjectValue(properties[index2].GetValue((object) obj, (object[]) null));
            checked { ++index2; }
          }
          dataTable.Rows.Add(objArray);
        }
      }
      finally
      {
        List<T>.Enumerator enumerator;
        enumerator.Dispose();
      }
      return dataTable;
    }
  }
}
