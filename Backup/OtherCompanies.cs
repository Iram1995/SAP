
// Type: SAP2012.OtherCompanies




using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;

namespace SAP2012
{
  [StandardModule]
  internal sealed class OtherCompanies
  {
    private static DataSet NHERDataSet;
    private static object Projname;
    private static double TotalFloorArea;

    public static void CreateNHERData(string XMLfile)
    {
      OtherCompanies.NHERDataSet = new DataSet();
      int num1 = (int) OtherCompanies.NHERDataSet.ReadXml(XMLfile);
      if (SAP_Module.CurrDwelling == 0)
      {
        SAP_Module.Proj = new SAP_Module.Project();
        SAP_Module.Proj.Name = "NHER Project";
        // ISSUE: variable of a reference type
        int& local1;
        // ISSUE: explicit reference operation
        int num2 = checked (^(local1 = ref SAP_Module.Proj.NoOfDwells) + 1);
        local1 = num2;
        // ISSUE: variable of a reference type
        SAP_Module.Dwelling[]& local2;
        // ISSUE: explicit reference operation
        SAP_Module.Dwelling[] dwellingArray = (SAP_Module.Dwelling[]) Utils.CopyArray((Array) ^(local2 = ref SAP_Module.Proj.Dwellings), (Array) new SAP_Module.Dwelling[1]);
        local2 = dwellingArray;
      }
      else
      {
        // ISSUE: variable of a reference type
        int& local3;
        // ISSUE: explicit reference operation
        int num3 = checked (^(local3 = ref SAP_Module.Proj.NoOfDwells) + 1);
        local3 = num3;
        // ISSUE: variable of a reference type
        SAP_Module.Dwelling[]& local4;
        // ISSUE: explicit reference operation
        SAP_Module.Dwelling[] dwellingArray = (SAP_Module.Dwelling[]) Utils.CopyArray((Array) ^(local4 = ref SAP_Module.Proj.Dwellings), (Array) new SAP_Module.Dwelling[checked (SAP_Module.Proj.NoOfDwells - 1 + 1)]);
        local4 = dwellingArray;
      }
      OtherCompanies.NHER_Checktables();
      Validation.Checkerrors_All(SAP_Module.CurrDwelling);
      Functions.MakeTree();
      SAP_Write.SaveDetails_Validation(SAP_Module.CurrDwelling);
      checked { ++SAP_Module.CurrDwelling; }
    }

    public static void NHER_Checktables()
    {
      if (OtherCompanies.NHERDataSet.Tables.Contains("JobDetails"))
        OtherCompanies.NHER_JobDetails();
      if (OtherCompanies.NHERDataSet.Tables.Contains("Dwelling"))
        OtherCompanies.NHER_Dwellings();
      if (OtherCompanies.NHERDataSet.Tables.Contains("Storey"))
        OtherCompanies.NHER_Storeys();
      if (OtherCompanies.NHERDataSet.Tables.Contains("Floor"))
        OtherCompanies.NHER_Floors();
      if (OtherCompanies.NHERDataSet.Tables.Contains("Wall"))
        OtherCompanies.NHER_Walls();
      if (OtherCompanies.NHERDataSet.Tables.Contains("Roof"))
        OtherCompanies.NHER_Roofs();
      if (OtherCompanies.NHERDataSet.Tables.Contains("Opening"))
        OtherCompanies.NHER_Openings();
      if (OtherCompanies.NHERDataSet.Tables.Contains("Ventilation"))
        OtherCompanies.NHER_Ventilation();
      if (OtherCompanies.NHERDataSet.Tables.Contains("MechanicalVentilation"))
        OtherCompanies.NHER_MechVentilation();
      if (OtherCompanies.NHERDataSet.Tables.Contains("SpaceHeating"))
        OtherCompanies.NHER_SpaceHeating();
      if (OtherCompanies.NHERDataSet.Tables.Contains("MainHeating"))
        OtherCompanies.NHER_Heating();
      if (OtherCompanies.NHERDataSet.Tables.Contains("CommunityHeating"))
        OtherCompanies.NHER_Community();
      if (OtherCompanies.NHERDataSet.Tables.Contains("WaterHeating"))
        OtherCompanies.NHER_WaterHeating();
      if (OtherCompanies.NHERDataSet.Tables.Contains("Renewables"))
        OtherCompanies.NHER_RenewablesHeating();
      if (OtherCompanies.NHERDataSet.Tables.Contains("PV"))
        OtherCompanies.NHER_PV();
      if (OtherCompanies.NHERDataSet.Tables.Contains("Other"))
        OtherCompanies.NHER_Other();
      if (OtherCompanies.NHERDataSet.Tables.Contains("SummerOverheating"))
        OtherCompanies.NHER_SummerOverHeating();
      if (OtherCompanies.NHERDataSet.Tables.Contains("SecondaryHeating"))
        OtherCompanies.NHER_SecondaryHeating();
      if (OtherCompanies.NHERDataSet.Tables.Contains("ThermalBridge"))
      {
        OtherCompanies.HHER_ThermalBridge();
      }
      else
      {
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.ManualY = true;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.YValue = 0.15f;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.Reference = "New ref";
      }
      if (OtherCompanies.NHERDataSet.Tables.Contains("WindTurbines"))
        OtherCompanies.HNER_WindTurbine();
      OtherCompanies.HNER_ElectricGenration();
      OtherCompanies.HNER_HydroGenration();
      OtherCompanies.NHER_SpaceHeating();
      if (OtherCompanies.NHERDataSet.Tables.Contains("SolarWaterHeating"))
        OtherCompanies.NHER_solarWater();
      if (OtherCompanies.NHERDataSet.Tables.Contains("Cooling"))
        OtherCompanies.NHER_Cooling();
      if (OtherCompanies.NHERDataSet.Tables.Contains("FGHRSDetails"))
        OtherCompanies.NHER_FGHRS();
      if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SAPTableCode != 409)
        return;
      Heating.GetMainEfficiency("Electric storage systems", "Off-peak tariffs", "", "High heat retention storage heaters");
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MainEff = 100f;
    }

    private static void NHER_RenewablesHeating()
    {
    }

    private static void HHER_ThermalBridge()
    {
      SAP_Module.Junction junction1 = new SAP_Module.Junction();
      SAP_Module.Junction junction2 = new SAP_Module.Junction();
      SAP_Module.Junction junction3 = new SAP_Module.Junction();
      SAP_Module.Junction junction4 = new SAP_Module.Junction();
      if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.ExternalJunctions == null)
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.ExternalJunctions = new List<SAP_Module.Junction>();
      if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.PartyJunctions == null)
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.PartyJunctions = new List<SAP_Module.Junction>();
      if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.RoofJunctions == null)
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.RoofJunctions = new List<SAP_Module.Junction>();
      bool flag1 = false;
      bool flag2 = false;
      bool flag3 = false;
      bool flag4 = false;
      bool flag5 = false;
      bool flag6 = false;
      int num = checked (OtherCompanies.NHERDataSet.Tables["ThermalBridge"].Rows.Count - 1);
      int index = 0;
      while (index <= num)
      {
        if (Conversion.Val(RuntimeHelpers.GetObjectValue(OtherCompanies.NHERDataSet.Tables["ThermalBridge"].Rows[index]["length"])) != -1.0)
        {
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.ManualHtb = true;
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.ConstDetails = "";
          if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.ExternalJunctions == null)
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.ExternalJunctions = new List<SAP_Module.Junction>();
          junction1.IsDefault = false;
          junction1.IsAccredited = false;
          try
          {
            object Left = OtherCompanies.NHERDataSet.Tables["ThermalBridge"].Rows[index]["JunctionName"];
            if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) "Steel lintel With perforated steel base plate", false))
              junction1.Ref = "E1";
            else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) "Other lintels (including other steel lintels)", false))
              junction1.Ref = "E2";
            else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) "Ground floor (normal)", false))
              junction1.Ref = "E5";
            else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) "Basement floor", false))
              junction1.Ref = "E22";
            else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) "Party floor between dwellings (In blocks Of flats)", false))
              junction1.Ref = "E7";
            else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) "Balcony within a dwelling, wall insulation continuous", false))
              junction1.Ref = "E8";
            else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) "Balcony within Or between dwellings, balcony support penetrates wall insulation", false))
              junction1.Ref = "E9";
            else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) "Eaves (insulation at ceiling level)", false))
              junction1.Ref = "E10";
            else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) "Eaves (insulation at ceiling level - inverted)", false))
              junction1.Ref = "E24";
            else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) "Eaves (insulation at rafter level)", false))
              junction1.Ref = "E11";
            else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) "Gable (insulation at ceiling level)", false))
              junction1.Ref = "E12";
            else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) "Gable (insulation at rafter level)", false))
              junction1.Ref = "E13";
            else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) "Flat roof", false))
              junction1.Ref = "E14";
            else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) "Flat roof With parapet", false))
              junction1.Ref = "E15";
            else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) "Corner (normal)", false))
              junction1.Ref = "E16";
            else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) "Corner (inverted - internal area greater than external area)", false))
              junction1.Ref = "E17";
            else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) "Party wall between dwellings", false))
              junction1.Ref = "E18";
            else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) "Staggered party wall between dwellings", false))
              junction1.Ref = "E25";
            else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) "Ground floor", false))
              junction1.Ref = "P1";
            else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) "Intermediate floor between dwellings (In block Of flats)", false))
              junction1.Ref = "P3";
            else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) "Roof (insulation at ceiling level)", false))
              junction1.Ref = "P4";
            else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) "Roof (insulation at rafter level)", false))
              junction1.Ref = "P5";
            else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) "Head", false))
              junction1.Ref = "R1";
            else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) "Ridge (vaulted ceiling)", false))
              junction1.Ref = "R4";
            else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) "Ridge (inverted)", false))
              junction1.Ref = "R5";
            else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) "Flat ceiling", false))
              junction1.Ref = "R6";
            else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) "Flat ceiling (inverted)", false))
              junction1.Ref = "R7";
            else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) "Roof wall (rafter)", false))
              junction1.Ref = "R8";
            else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) "Roof wall (flat ceiling)", false))
              junction1.Ref = "R9";
            else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) "Intermediate floor within a dwelling", false))
            {
              if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(OtherCompanies.NHERDataSet.Tables["ThermalBridge"].Rows[index]["PsiValue"])))
                junction1.ThermalTransmittance = (float) Conversion.Val(RuntimeHelpers.GetObjectValue(OtherCompanies.NHERDataSet.Tables["ThermalBridge"].Rows[index]["PsiValue"]));
              if (junction1.IsDefault)
              {
                junction1.Ref = (double) junction1.ThermalTransmittance != 0.0 ? (flag6 ? "P2" : "E6") : "P2";
                flag6 = true;
              }
              else
              {
                junction1.Ref = flag6 ? "P2" : "E6";
                flag6 = true;
              }
            }
            else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) "Sill", false))
            {
              if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(OtherCompanies.NHERDataSet.Tables["ThermalBridge"].Rows[index]["PsiValue"])))
                junction1.ThermalTransmittance = (float) Conversion.Val(RuntimeHelpers.GetObjectValue(OtherCompanies.NHERDataSet.Tables["ThermalBridge"].Rows[index]["PsiValue"]));
              if (junction1.IsDefault)
              {
                junction1.Ref = (double) junction1.ThermalTransmittance != 0.06 ? (flag1 ? "R2" : "E3") : "R2";
                flag1 = true;
              }
              else
              {
                junction1.Ref = flag1 ? "R2" : "E3";
                flag1 = true;
              }
            }
            else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) "Jamb", false))
            {
              if (junction1.IsDefault)
              {
                junction1.Ref = (double) junction1.ThermalTransmittance != 0.08 ? (flag2 ? "R3" : "E4") : "R3";
                flag2 = true;
              }
              else
              {
                junction1.Ref = flag2 ? "R3" : "E4";
                flag2 = true;
              }
            }
            else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) "Ground floor (inverted)", false))
            {
              if (junction1.IsDefault)
              {
                if ((double) junction1.ThermalTransmittance == 0.07)
                {
                  junction1.Ref = "P6";
                }
                else
                {
                  junction1.Ref = flag3 ? "P6" : "E19";
                  flag3 = true;
                }
              }
              else
              {
                junction1.Ref = flag3 ? "P6" : "E19";
                flag3 = true;
              }
            }
            else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) "Exposed floor (normal)", false))
            {
              if (junction1.IsDefault)
              {
                if ((double) junction1.ThermalTransmittance == 0.16)
                {
                  junction1.Ref = "P7";
                }
                else
                {
                  junction1.Ref = flag4 ? "P7" : "E20";
                  flag4 = true;
                }
              }
              else
              {
                junction1.Ref = flag4 ? "E7" : "E20";
                flag4 = true;
              }
            }
            else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) "Exposed floor (inverted)", false))
            {
              if (junction1.IsDefault)
              {
                if ((double) junction1.ThermalTransmittance == 0.24)
                {
                  junction1.Ref = "P8";
                }
                else
                {
                  junction1.Ref = flag5 ? "P8" : "E21";
                  flag5 = true;
                }
              }
              else
              {
                junction1.Ref = flag5 ? "P8" : "E21";
                flag5 = true;
              }
            }
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
          try
          {
            if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(OtherCompanies.NHERDataSet.Tables["ThermalBridge"].Rows[index]["JunctionName"])))
              junction1.JunctionDetail = Conversions.ToString(OtherCompanies.NHERDataSet.Tables["ThermalBridge"].Rows[index]["JunctionName"]);
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
          try
          {
            if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(OtherCompanies.NHERDataSet.Tables["ThermalBridge"].Rows[index]["length"])))
              junction1.Length = (float) Conversion.Val(RuntimeHelpers.GetObjectValue(OtherCompanies.NHERDataSet.Tables["ThermalBridge"].Rows[index]["length"]));
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
          if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(OtherCompanies.NHERDataSet.Tables["ThermalBridge"].Rows[index]["PsiValue"])))
            junction1.ThermalTransmittance = (float) Conversion.Val(RuntimeHelpers.GetObjectValue(OtherCompanies.NHERDataSet.Tables["ThermalBridge"].Rows[index]["PsiValue"]));
          object Left1 = OtherCompanies.NHERDataSet.Tables["ThermalBridge"].Rows[index]["PSiValueType"];
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left1, (object) 0, false))
            junction1.IsDefault = true;
          else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left1, (object) 1, false))
            junction1.IsAccredited = true;
          else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left1, (object) 2, false))
          {
            junction1.IsDefault = false;
            junction1.IsAccredited = false;
          }
          string str = junction1.Ref;
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
                break;
              goto default;
            case 134497664:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "R5", false) == 0)
                goto label_166;
              else
                goto default;
            case 147582594:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "E6", false) == 0)
                break;
              goto default;
            case 151275283:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "R4", false) == 0)
                goto label_166;
              else
                goto default;
            case 164360213:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "E7", false) == 0)
                break;
              goto default;
            case 168052902:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "R7", false) == 0)
                goto label_166;
              else
                goto default;
            case 181137832:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "E8", false) == 0)
                break;
              goto default;
            case 184830521:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "R6", false) == 0)
                goto label_166;
              else
                goto default;
            case 197915451:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "E9", false) == 0)
                break;
              goto default;
            case 201608140:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "R1", false) == 0)
                goto label_166;
              else
                goto default;
            case 235163378:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "R3", false) == 0)
                goto label_166;
              else
                goto default;
            case 251940997:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "R2", false) == 0)
                goto label_166;
              else
                goto default;
            case 335829092:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "R9", false) == 0)
                goto label_166;
              else
                goto default;
            case 352606711:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "R8", false) == 0)
                goto label_166;
              else
                goto default;
            case 419422997:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "P8", false) == 0)
                goto label_165;
              else
                goto default;
            case 436200616:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "P7", false) == 0)
                goto label_165;
              else
                goto default;
            case 452978235:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "P6", false) == 0)
                goto label_165;
              else
                goto default;
            case 469755854:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "P5", false) == 0)
                goto label_165;
              else
                goto default;
            case 486533473:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "P4", false) == 0)
                goto label_165;
              else
                goto default;
            case 503311092:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "P3", false) == 0)
                goto label_165;
              else
                goto default;
            case 520088711:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "P2", false) == 0)
                goto label_165;
              else
                goto default;
            case 536866330:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "P1", false) == 0)
                goto label_165;
              else
                goto default;
            case 2314990768:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "E13", false) == 0)
                break;
              goto default;
            case 2331768387:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "E12", false) == 0)
                break;
              goto default;
            case 2348546006:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "E11", false) == 0)
                break;
              goto default;
            case 2365323625:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "E10", false) == 0)
                break;
              goto default;
            case 2382101244:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "E17", false) == 0)
                break;
              goto default;
            case 2398878863:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "E16", false) == 0)
                break;
              goto default;
            case 2399025958:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "E24", false) == 0)
                break;
              goto default;
            case 2415656482:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "E15", false) == 0)
                break;
              goto default;
            case 2415803577:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "E25", false) == 0)
                break;
              goto default;
            case 2432434101:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "E14", false) == 0)
                break;
              goto default;
            case 2432581196:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "E22", false) == 0)
                break;
              goto default;
            case 2449358815:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "E23", false) == 0)
                break;
              goto default;
            case 2466136434:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "E20", false) == 0)
                break;
              goto default;
            case 2482766958:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "E19", false) == 0)
                break;
              goto default;
            case 2482914053:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "E21", false) == 0)
                break;
              goto default;
            case 2499544577:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "E18", false) == 0)
                break;
              goto default;
            default:
label_167:
              goto label_168;
          }
          SAP_Module.Junction junction5 = junction1;
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.ExternalJunctions.Add(junction5);
          goto label_167;
label_165:
          SAP_Module.Junction junction6 = junction1;
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.PartyJunctions.Add(junction6);
          goto label_167;
label_166:
          SAP_Module.Junction junction7 = junction1;
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.RoofJunctions.Add(junction7);
          goto label_167;
        }
label_168:
        checked { ++index; }
      }
    }

    private static void NHER_JobDetails()
    {
      // ISSUE: variable of a reference type
      SAP_Module.Dwelling[]& local;
      // ISSUE: explicit reference operation
      SAP_Module.Dwelling[] dwellingArray = (SAP_Module.Dwelling[]) Utils.CopyArray((Array) ^(local = ref SAP_Module.Proj.Dwellings), (Array) new SAP_Module.Dwelling[checked (SAP_Module.CurrDwelling + 1)]);
      local = dwellingArray;
      if (OtherCompanies.NHERDataSet.Tables["JobDetails"].Rows.Count > 0)
      {
        int num = checked (OtherCompanies.NHERDataSet.Tables["JobDetails"].Rows.Count - 1);
        int index = 0;
        while (index <= num)
        {
          string str = Conversions.ToString(OtherCompanies.NHERDataSet.Tables["JobDetails"].Rows[index]["URN"]);
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Name = !str.Contains("\\") ? str : str.Replace("\\", "-");
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Reference = str;
          SAP_Module.Proj.Address.Line1 = Conversions.ToString(OtherCompanies.NHERDataSet.Tables["JobDetails"].Rows[index]["HouseNo"]);
          SAP_Module.Proj.Address.Line1 = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) (SAP_Module.Proj.Address.Line1 + " "), OtherCompanies.NHERDataSet.Tables["JobDetails"].Rows[index]["FlatLetterNo"]));
          SAP_Module.Proj.Address.Line1 = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) (SAP_Module.Proj.Address.Line1 + " "), OtherCompanies.NHERDataSet.Tables["JobDetails"].Rows[index]["BlockHouseName"]));
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Address.Line2 = Conversions.ToString(OtherCompanies.NHERDataSet.Tables["JobDetails"].Rows[index]["Street"]);
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Address.City = Conversions.ToString(OtherCompanies.NHERDataSet.Tables["JobDetails"].Rows[index]["Town"]);
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Address.PostCost = Conversions.ToString(OtherCompanies.NHERDataSet.Tables["JobDetails"].Rows[index]["Postcode"]);
          if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Address.PostCost != null)
            OtherCompanies.CreateRegion(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Address.PostCost);
          SAP_Module.Proj.Client.Name = Conversions.ToString(OtherCompanies.NHERDataSet.Tables["JobDetails"].Rows[index]["Client"]);
          if (OtherCompanies.NHERDataSet.Tables["JobDetails"].Columns.Contains("Status") && !Information.IsDBNull(RuntimeHelpers.GetObjectValue(OtherCompanies.NHERDataSet.Tables["JobDetails"].Rows[index]["Status"])))
          {
            object Left = OtherCompanies.NHERDataSet.Tables["JobDetails"].Rows[index]["Status"];
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Status = !Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) 0, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) 1, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) 2, false) ? " New dwelling design stage" : "New dwelling As built") : "Existing dwelling (SAP)") : "New dwelling design stage";
          }
          checked { ++index; }
        }
      }
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].EPCLanguage = "English";
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Overshading = "Average or unknown";
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].SmokeArea = "Unknown";
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RPD = "No related party";
    }

    private static void CreateRegion(string Postcode)
    {
      if (Postcode == null)
        return;
      if (Postcode.Length > 0)
      {
        try
        {
          Postcode = Postcode.Substring(0, 4);
          int num = checked ((int) Math.Round(Conversion.Val(OtherCompanies.GetRegion(Postcode))));
          if (num == 0)
          {
            Postcode = Postcode.Substring(0, 3);
            num = checked ((int) Math.Round(Conversion.Val(OtherCompanies.GetRegion(Postcode))));
          }
          if (num == 0)
          {
            Postcode = Postcode.Substring(0, 2);
            num = checked ((int) Math.Round(Conversion.Val(OtherCompanies.GetRegion(Postcode))));
          }
          switch (num - 1)
          {
            case 0:
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Location = "Thames valley";
              break;
            case 1:
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Location = "South East England";
              break;
            case 2:
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Location = "South England";
              break;
            case 3:
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Location = "South West England";
              break;
            case 4:
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Location = "Severn valley";
              break;
            case 5:
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Location = "Midlands";
              break;
            case 6:
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Location = "West Pennines";
              break;
            case 7:
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Location = "North West England";
              break;
            case 8:
            case 15:
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Location = "West Scotland";
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Address.Country = "Scotland";
              break;
            case 9:
            case 10:
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Location = "East Pennines";
              break;
            case 11:
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Location = "North East England";
              break;
            case 12:
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Location = "Borders";
              break;
            case 13:
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Location = "East Anglia";
              break;
            case 14:
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Location = "Wales";
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Address.Country = "Wales";
              break;
            case 16:
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Location = "East Scotland";
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Address.Country = "Scotland";
              break;
            case 17:
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Location = "North East Scotland";
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Address.Country = "Scotland";
              break;
            case 18:
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Location = "Highland";
              break;
            case 19:
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Location = "Western Isles";
              break;
            case 20:
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Location = "Orkney";
              break;
            case 21:
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Location = "Shetland";
              break;
            case 22:
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Location = "Northern Ireland";
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Address.Country = "Northern Ireland";
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

    private static string GetRegion(string Postcode)
    {
      string region;
      if (Postcode != null)
      {
        string str1 = "";
        string str2 = Postcode;
        // ISSUE: reference to a compiler-generated method
        switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(str2))
        {
          case 137770707:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "SA20", false) == 0)
              goto label_491;
            else
              goto default;
          case 154526143:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "PH19", false) == 0)
              goto label_472;
            else
              goto default;
          case 184629573:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "PE9", false) == 0)
              goto label_469;
            else
              goto default;
          case 340013321:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "EN9", false) == 0)
            {
              str1 = Conversions.ToString(12);
              goto default;
            }
            else
              goto default;
          case 365691641:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "EC", false) == 0)
            {
              str1 = Conversions.ToString(1);
              goto default;
            }
            else
              goto default;
          case 401953830:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "TA", false) == 0)
            {
              str1 = "5E";
              goto default;
            }
            else
              goto default;
          case 417157331:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "BD", false) == 0)
            {
              str1 = Conversions.ToString(11);
              goto default;
            }
            else
              goto default;
          case 439620754:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "SA38", false) == 0)
              goto label_492;
            else
              goto default;
          case 449579736:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "EH", false) == 0)
            {
              str1 = Conversions.ToString(15);
              goto default;
            }
            else
              goto default;
          case 452286687:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "TF", false) == 0)
            {
              str1 = Conversions.ToString(6);
              goto default;
            }
            else
              goto default;
          case 456398373:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "SA39", false) == 0)
              goto label_492;
            else
              goto default;
          case 467490188:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "BA", false) == 0)
            {
              str1 = "5E";
              goto default;
            }
            else
              goto default;
          case 473175992:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "SA36", false) == 0)
              goto label_492;
            else
              goto default;
          case 485841925:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "TD", false) == 0)
            {
              str1 = Conversions.ToString(9);
              goto default;
            }
            else
              goto default;
          case 489953611:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "SA37", false) == 0)
              goto label_492;
            else
              goto default;
          case 501645475:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "GU46", false) == 0)
            {
              str1 = Conversions.ToString(3);
              goto default;
            }
            else
              goto default;
          case 506731230:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "SA34", false) == 0)
              goto label_492;
            else
              goto default;
          case 517278592:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "AL", false) == 0)
            {
              str1 = Conversions.ToString(1);
              goto default;
            }
            else
              goto default;
          case 517823045:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "BB", false) == 0)
            {
              str1 = "7E";
              goto default;
            }
            else
              goto default;
          case 523508849:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "SA35", false) == 0)
              goto label_492;
            else
              goto default;
          case 540286468:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "SA32", false) == 0)
              goto label_492;
            else
              goto default;
          case 550245450:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "EN", false) == 0)
            {
              str1 = Conversions.ToString(1);
              goto default;
            }
            else
              goto default;
          case 551378283:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "BL", false) == 0)
            {
              str1 = "7E";
              goto default;
            }
            else
              goto default;
          case 557064087:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "SA33", false) == 0)
              goto label_492;
            else
              goto default;
          case 570421568:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "PO", false) == 0)
            {
              str1 = Conversions.ToString(3);
              goto default;
            }
            else
              goto default;
          case 584933521:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "BN", false) == 0)
            {
              str1 = Conversions.ToString(2);
              goto default;
            }
            else
              goto default;
          case 586507639:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "TN", false) == 0)
            {
              str1 = Conversions.ToString(2);
              goto default;
            }
            else
              goto default;
          case 590619325:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "SA31", false) == 0)
              goto label_492;
            else
              goto default;
          case 597315636:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "CM21", false) == 0)
              goto label_389;
            else
              goto default;
          case 618488759:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "BH", false) == 0)
            {
              str1 = Conversions.ToString(3);
              goto default;
            }
            else
              goto default;
          case 619077139:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "NP", false) == 0)
            {
              str1 = "5W";
              goto default;
            }
            else
              goto default;
          case 620754425:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "PL", false) == 0)
            {
              str1 = Conversions.ToString(4);
              goto default;
            }
            else
              goto default;
          case 630870874:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "CM23", false) == 0)
              goto label_389;
            else
              goto default;
          case 636840496:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "TS", false) == 0)
            {
              str1 = Conversions.ToString(10);
              goto default;
            }
            else
              goto default;
          case 647648493:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "CM22", false) == 0)
              goto label_389;
            else
              goto default;
          case 651805403:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "GU11", false) == 0)
              goto label_417;
            else
              goto default;
          case 652632377:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "NR", false) == 0)
            {
              str1 = Conversions.ToString(12);
              goto default;
            }
            else
              goto default;
          case 653618115:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "TR", false) == 0)
            {
              str1 = Conversions.ToString(4);
              goto default;
            }
            else
              goto default;
          case 668583022:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "GU12", false) == 0)
              goto label_417;
            else
              goto default;
          case 669954449:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "KA", false) == 0)
            {
              str1 = Conversions.ToString(14);
              goto default;
            }
            else
              goto default;
          case 670395734:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "TQ", false) == 0)
            {
              str1 = Conversions.ToString(4);
              goto default;
            }
            else
              goto default;
          case 672661400:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "ZE", false) == 0)
            {
              str1 = Conversions.ToString(20);
              goto default;
            }
            else
              goto default;
          case 685599235:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "BT", false) == 0)
            {
              str1 = Conversions.ToString(21);
              goto default;
            }
            else
              goto default;
          case 687320448:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "WV", false) == 0)
            {
              str1 = Conversions.ToString(6);
              goto default;
            }
            else
              goto default;
          case 687864901:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "PH", false) == 0)
            {
              str1 = Conversions.ToString(15);
              goto default;
            }
            else
              goto default;
          case 702138260:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "GU14", false) == 0)
            {
              str1 = Conversions.ToString(3);
              goto default;
            }
            else
              goto default;
          case 702965234:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "NW", false) == 0)
            {
              str1 = Conversions.ToString(1);
              goto default;
            }
            else
              goto default;
          case 703950972:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "TW", false) == 0)
            {
              str1 = Conversions.ToString(1);
              goto default;
            }
            else
              goto default;
          case 718021640:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "EX", false) == 0)
            {
              str1 = Conversions.ToString(4);
              goto default;
            }
            else
              goto default;
          case 719771579:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "SK17", false) == 0)
            {
              str1 = Conversions.ToString(6);
              goto default;
            }
            else
              goto default;
          case 738197758:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "PE", false) == 0)
            {
              str1 = Conversions.ToString(12);
              goto default;
            }
            else
              goto default;
          case 751723973:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "DT", false) == 0)
            {
              str1 = Conversions.ToString(3);
              goto default;
            }
            else
              goto default;
          case 752165258:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "AB", false) == 0)
            {
              str1 = Conversions.ToString(16);
              goto default;
            }
            else
              goto default;
          case 754430924:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "WR", false) == 0)
            {
              str1 = Conversions.ToString(6);
              goto default;
            }
            else
              goto default;
          case 769487330:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "BS", false) == 0)
            {
              str1 = "5E";
              goto default;
            }
            else
              goto default;
          case 771208543:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "WS", false) == 0)
            {
              str1 = Conversions.ToString(6);
              goto default;
            }
            else
              goto default;
          case 786264949:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "BR", false) == 0)
            {
              str1 = Conversions.ToString(2);
              goto default;
            }
            else
              goto default;
          case 786882055:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "SK13", false) == 0)
            {
              str1 = Conversions.ToString(6);
              goto default;
            }
            else
              goto default;
          case 802056830:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "DY", false) == 0)
            {
              str1 = Conversions.ToString(6);
              goto default;
            }
            else
              goto default;
          case 804175401:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "KY", false) == 0)
            {
              str1 = Conversions.ToString(15);
              goto default;
            }
            else
              goto default;
          case 805308234:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "PA", false) == 0)
            {
              str1 = Conversions.ToString(14);
              goto default;
            }
            else
              goto default;
          case 936277782:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "DA", false) == 0)
            {
              str1 = Conversions.ToString(2);
              goto default;
            }
            else
              goto default;
          case 937851900:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "NE", false) == 0)
            {
              str1 = "9E";
              goto default;
            }
            else
              goto default;
          case 955762352:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "WF", false) == 0)
            {
              str1 = Conversions.ToString(11);
              goto default;
            }
            else
              goto default;
          case 969833020:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "DG", false) == 0)
            {
              str1 = Conversions.ToString(8);
              goto default;
            }
            else
              goto default;
          case 971407138:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "NG", false) == 0)
            {
              str1 = Conversions.ToString(11);
              goto default;
            }
            else
              goto default;
          case 971951591:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "KW", false) == 0)
            {
              str1 = Conversions.ToString(17);
              goto default;
            }
            else
              goto default;
          case 988729210:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "KT", false) == 0)
            {
              str1 = Conversions.ToString(1);
              goto default;
            }
            else
              goto default;
          case 989317590:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "WD", false) == 0)
            {
              str1 = Conversions.ToString(1);
              goto default;
            }
            else
              goto default;
          case 1003388258:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "DE", false) == 0)
            {
              str1 = Conversions.ToString(6);
              goto default;
            }
            else
              goto default;
          case 1020165877:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "DD", false) == 0)
            {
              str1 = Conversions.ToString(15);
              goto default;
            }
            else
              goto default;
          case 1038076329:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "MK", false) == 0)
            {
              str1 = Conversions.ToString(1);
              goto default;
            }
            else
              goto default;
          case 1039650447:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "WC", false) == 0)
            {
              str1 = Conversions.ToString(1);
              goto default;
            }
            else
              goto default;
          case 1054853948:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "ML", false) == 0)
            {
              str1 = Conversions.ToString(14);
              goto default;
            }
            else
              goto default;
          case 1056972519:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "PR", false) == 0)
            {
              str1 = "7E";
              goto default;
            }
            else
              goto default;
          case 1073205685:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "WA", false) == 0)
            {
              str1 = "7E";
              goto default;
            }
            else
              goto default;
          case 1075857884:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "LA20", false) == 0)
              goto label_443;
            else
              goto default;
          case 1087276353:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "DH", false) == 0)
            {
              str1 = Conversions.ToString(10);
              goto default;
            }
            else
              goto default;
          case 1089983304:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "WN", false) == 0)
            {
              str1 = "7E";
              goto default;
            }
            else
              goto default;
          case 1092635503:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "LA21", false) == 0)
              goto label_443;
            else
              goto default;
          case 1101413809:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "NP8", false) == 0)
            {
              str1 = Conversions.ToString(13);
              goto default;
            }
            else
              goto default;
          case 1106865200:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "PE24", false) == 0)
              goto label_470;
            else
              goto default;
          case 1108438209:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "YO", false) == 0)
            {
              str1 = Conversions.ToString(10);
              goto default;
            }
            else
              goto default;
          case 1109413122:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "LA22", false) == 0)
              goto label_443;
            else
              goto default;
          case 1120831591:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "DN", false) == 0)
            {
              str1 = Conversions.ToString(11);
              goto default;
            }
            else
              goto default;
          case 1122405709:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "NN", false) == 0)
            {
              str1 = Conversions.ToString(6);
              goto default;
            }
            else
              goto default;
          case 1123642819:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "PE25", false) == 0)
              goto label_470;
            else
              goto default;
          case 1126190741:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "LA23", false) == 0)
              goto label_443;
            else
              goto default;
          case 1148733806:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "LS24", false) == 0)
            {
              str1 = Conversions.ToString(10);
              goto default;
            }
            else
              goto default;
          case 1154386829:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "DL", false) == 0)
            {
              str1 = Conversions.ToString(10);
              goto default;
            }
            else
              goto default;
          case 1173975676:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "PE20", false) == 0)
              goto label_470;
            else
              goto default;
          case 1190753295:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "PE21", false) == 0)
              goto label_470;
            else
              goto default;
          case 1207530914:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "PE22", false) == 0)
              goto label_470;
            else
              goto default;
          case 1224308533:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "PE23", false) == 0)
              goto label_470;
            else
              goto default;
          case 1227297740:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "LA19", false) == 0)
              goto label_443;
            else
              goto default;
          case 1244075359:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "LA18", false) == 0)
              goto label_443;
            else
              goto default;
          case 1274785227:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "TD15", false) == 0)
            {
              str1 = "9E";
              goto default;
            }
            else
              goto default;
          case 1283975560:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "SY21", false) == 0)
              goto label_514;
            else
              goto default;
          case 1294408216:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "LA15", false) == 0)
              goto label_443;
            else
              goto default;
          case 1300753179:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "SY20", false) == 0)
              goto label_514;
            else
              goto default;
          case 1311185835:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "LA14", false) == 0)
              goto label_443;
            else
              goto default;
          case 1317530798:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "SY23", false) == 0)
              goto label_514;
            else
              goto default;
          case 1327963454:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "LA17", false) == 0)
              goto label_443;
            else
              goto default;
          case 1334308417:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "SY22", false) == 0)
              goto label_514;
            else
              goto default;
          case 1344741073:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "LA16", false) == 0)
              goto label_443;
            else
              goto default;
          case 1351086036:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "SY25", false) == 0)
              goto label_514;
            else
              goto default;
          case 1358673322:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "TD12", false) == 0)
            {
              str1 = "9E";
              goto default;
            }
            else
              goto default;
          case 1361518692:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "LA11", false) == 0)
              goto label_443;
            else
              goto default;
          case 1367863655:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "SY24", false) == 0)
              goto label_514;
            else
              goto default;
          case 1378296311:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "LA10", false) == 0)
              goto label_443;
            else
              goto default;
          case 1395073930:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "LA13", false) == 0)
              goto label_443;
            else
              goto default;
          case 1411851549:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "LA12", false) == 0)
              goto label_443;
            else
              goto default;
          case 1476560089:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "SA", false) == 0)
            {
              str1 = "5W";
              goto default;
            }
            else
              goto default;
          case 1492579021:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "RH20", false) == 0)
              goto label_484;
            else
              goto default;
          case 1508438041:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "IG", false) == 0)
            {
              str1 = Conversions.ToString(12);
              goto default;
            }
            else
              goto default;
          case 1510115327:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "SG", false) == 0)
            {
              str1 = Conversions.ToString(1);
              goto default;
            }
            else
              goto default;
          case 1543670565:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "SE", false) == 0)
            {
              str1 = Conversions.ToString(1);
              goto default;
            }
            else
              goto default;
          case 1577225803:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "SK", false) == 0)
            {
              str1 = "7E";
              goto default;
            }
            else
              goto default;
          case 1627558660:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "SN", false) == 0)
            {
              str1 = "5E";
              goto default;
            }
            else
              goto default;
          case 1644336279:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "SO", false) == 0)
            {
              str1 = Conversions.ToString(3);
              goto default;
            }
            else
              goto default;
          case 1657862494:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "GL", false) == 0)
            {
              str1 = "5E";
              goto default;
            }
            else
              goto default;
          case 1658995327:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "LN", false) == 0)
            {
              str1 = Conversions.ToString(11);
              goto default;
            }
            else
              goto default;
          case 1661113898:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "SL", false) == 0)
            {
              str1 = Conversions.ToString(1);
              goto default;
            }
            else
              goto default;
          case 1677891517:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "SM", false) == 0)
            {
              str1 = Conversions.ToString(1);
              goto default;
            }
            else
              goto default;
          case 1692006112:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "CR", false) == 0)
            {
              str1 = Conversions.ToString(1);
              goto default;
            }
            else
              goto default;
          case 1692550565:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "LL", false) == 0)
            {
              str1 = "7W";
              goto default;
            }
            else
              goto default;
          case 1694669136:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "SR", false) == 0)
            {
              str1 = "9E";
              goto default;
            }
            else
              goto default;
          case 1697395408:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "S33", false) == 0)
              goto label_488;
            else
              goto default;
          case 1711446755:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "SS", false) == 0)
            {
              str1 = Conversions.ToString(12);
              goto default;
            }
            else
              goto default;
          case 1714173027:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "S32", false) == 0)
              goto label_488;
            else
              goto default;
          case 1728224374:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "SP", false) == 0)
            {
              str1 = "5E";
              goto default;
            }
            else
              goto default;
          case 1742736327:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "Me", false) == 0)
            {
              str1 = Conversions.ToString(2);
              goto default;
            }
            else
              goto default;
          case 1742883422:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "LA", false) == 0)
            {
              str1 = "7E";
              goto default;
            }
            else
              goto default;
          case 1759116588:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "CV", false) == 0)
            {
              str1 = Conversions.ToString(6);
              goto default;
            }
            else
              goto default;
          case 1760102326:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "IV", false) == 0)
            {
              str1 = Conversions.ToString(17);
              goto default;
            }
            else
              goto default;
          case 1763440832:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "SP6", false) == 0)
              goto label_506;
            else
              goto default;
          case 1775894207:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "CW", false) == 0)
            {
              str1 = "7E";
              goto default;
            }
            else
              goto default;
          case 1778557231:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "SW", false) == 0)
            {
              str1 = Conversions.ToString(1);
              goto default;
            }
            else
              goto default;
          case 1779924261:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "SR7", false) == 0)
              goto label_508;
            else
              goto default;
          case 1780218451:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "SP7", false) == 0)
              goto label_506;
            else
              goto default;
          case 1792671826:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "CT", false) == 0)
            {
              str1 = Conversions.ToString(2);
              goto default;
            }
            else
              goto default;
          case 1793657564:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "IP", false) == 0)
            {
              str1 = Conversions.ToString(12);
              goto default;
            }
            else
              goto default;
          case 1795334850:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "ST", false) == 0)
            {
              str1 = Conversions.ToString(6);
              goto default;
            }
            else
              goto default;
          case 1796701880:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "SR8", false) == 0)
              goto label_508;
            else
              goto default;
          case 1808861065:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "GU", false) == 0)
            {
              str1 = Conversions.ToString(1);
              goto default;
            }
            else
              goto default;
          case 1809008160:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "FY", false) == 0)
            {
              str1 = "7E";
              goto default;
            }
            else
              goto default;
          case 1809993898:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "LE", false) == 0)
            {
              str1 = Conversions.ToString(6);
              goto default;
            }
            else
              goto default;
          case 1810582278:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "HU", false) == 0)
            {
              str1 = Conversions.ToString(11);
              goto default;
            }
            else
              goto default;
          case 1815132931:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "S18", false) == 0)
            {
              str1 = Conversions.ToString(6);
              goto default;
            }
            else
              goto default;
          case 1826771517:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "LD", false) == 0)
            {
              str1 = Conversions.ToString(13);
              goto default;
            }
            else
              goto default;
          case 1844137516:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "HS", false) == 0)
            {
              str1 = Conversions.ToString(18);
              goto default;
            }
            else
              goto default;
          case 1860915135:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "HR", false) == 0)
            {
              str1 = Conversions.ToString(6);
              goto default;
            }
            else
              goto default;
          case 1879222945:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "SY", false) == 0)
            {
              str1 = Conversions.ToString(6);
              goto default;
            }
            else
              goto default;
          case 1880766748:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "SP11", false) == 0)
              goto label_506;
            else
              goto default;
          case 1894470373:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "HP", false) == 0)
            {
              str1 = Conversions.ToString(1);
              goto default;
            }
            else
              goto default;
          case 1897544367:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "SP10", false) == 0)
              goto label_506;
            else
              goto default;
          case 1947724112:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "LL43", false) == 0)
              goto label_448;
            else
              goto default;
          case 1960448016:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "CB", false) == 0)
            {
              str1 = Conversions.ToString(12);
              goto default;
            }
            else
              goto default;
          case 1962125302:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "UB", false) == 0)
            {
              str1 = Conversions.ToString(1);
              goto default;
            }
            else
              goto default;
          case 1964501731:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "LL42", false) == 0)
              goto label_448;
            else
              goto default;
          case 1977770088:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "LS", false) == 0)
            {
              str1 = Conversions.ToString(11);
              goto default;
            }
            else
              goto default;
          case 1981279350:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "LL41", false) == 0)
              goto label_448;
            else
              goto default;
          case 1994694802:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "OX", false) == 0)
            {
              str1 = Conversions.ToString(1);
              goto default;
            }
            else
              goto default;
          case 1998056969:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "LL40", false) == 0)
              goto label_448;
            else
              goto default;
          case 1998204064:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "LL76", false) == 0)
              goto label_448;
            else
              goto default;
          case 1998327498:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "SP8", false) == 0)
              goto label_506;
            else
              goto default;
          case 2010780873:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "CA", false) == 0)
            {
              str1 = "8E";
              goto default;
            }
            else
              goto default;
          case 2014834588:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "LL47", false) == 0)
              goto label_448;
            else
              goto default;
          case 2014981683:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "LL77", false) == 0)
              goto label_448;
            else
              goto default;
          case 2015105117:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "SP9", false) == 0)
              goto label_506;
            else
              goto default;
          case 2016150304:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "PH50", false) == 0)
            {
              str1 = Conversions.ToString(14);
              goto default;
            }
            else
              goto default;
          case 2027558492:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "CF", false) == 0)
            {
              str1 = "5W";
              goto default;
            }
            else
              goto default;
          case 2028691325:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "HX", false) == 0)
            {
              str1 = Conversions.ToString(11);
              goto default;
            }
            else
              goto default;
          case 2031612207:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "LL46", false) == 0)
              goto label_448;
            else
              goto default;
          case 2031759302:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "LL74", false) == 0)
              goto label_448;
            else
              goto default;
          case 2031883676:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "DH5", false) == 0)
              goto label_400;
            else
              goto default;
          case 2045468944:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "HG", false) == 0)
            {
              str1 = Conversions.ToString(10);
              goto default;
            }
            else
              goto default;
          case 2047146230:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "RG", false) == 0)
            {
              str1 = Conversions.ToString(1);
              goto default;
            }
            else
              goto default;
          case 2048389826:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "LL45", false) == 0)
              goto label_448;
            else
              goto default;
          case 2048536921:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "LL75", false) == 0)
              goto label_448;
            else
              goto default;
          case 2048661295:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "DH4", false) == 0)
              goto label_400;
            else
              goto default;
          case 2048684016:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "LL69", false) == 0)
              goto label_448;
            else
              goto default;
          case 2050691280:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "PH32", false) == 0)
              goto label_474;
            else
              goto default;
          case 2065167445:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "LL44", false) == 0)
              goto label_448;
            else
              goto default;
          case 2065314540:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "LL72", false) == 0)
              goto label_448;
            else
              goto default;
          case 2065461635:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "LL68", false) == 0)
              goto label_448;
            else
              goto default;
          case 2066630256:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "PH43", false) == 0)
              goto label_474;
            else
              goto default;
          case 2067468899:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "PH33", false) == 0)
              goto label_474;
            else
              goto default;
          case 2078435802:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "LU", false) == 0)
            {
              str1 = Conversions.ToString(1);
              goto default;
            }
            else
              goto default;
          case 2082092159:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "LL73", false) == 0)
              goto label_448;
            else
              goto default;
          case 2083407875:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "PH42", false) == 0)
              goto label_474;
            else
              goto default;
          case 2084246518:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "PH30", false) == 0)
              goto label_474;
            else
              goto default;
          case 2095801801:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "HD", false) == 0)
            {
              str1 = Conversions.ToString(11);
              goto default;
            }
            else
              goto default;
          case 2098869778:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "LL70", false) == 0)
              goto label_448;
            else
              goto default;
          case 2100185494:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "PH41", false) == 0)
              goto label_474;
            else
              goto default;
          case 2101024137:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "PH31", false) == 0)
              goto label_474;
            else
              goto default;
          case 2101171232:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "PH25", false) == 0)
              goto label_472;
            else
              goto default;
          case 2111005302:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "FK", false) == 0)
            {
              str1 = Conversions.ToString(14);
              goto default;
            }
            else
              goto default;
          case 2115500302:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "LL49", false) == 0)
              goto label_448;
            else
              goto default;
          case 2115647397:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "LL71", false) == 0)
              goto label_448;
            else
              goto default;
          case 2116963113:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "PH40", false) == 0)
              goto label_474;
            else
              goto default;
          case 2117801756:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "PH36", false) == 0)
              goto label_474;
            else
              goto default;
          case 2117948851:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "PH24", false) == 0)
              goto label_472;
            else
              goto default;
          case 2128224206:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "CH", false) == 0)
            {
              str1 = "7E";
              goto default;
            }
            else
              goto default;
          case 2132277921:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "LL48", false) == 0)
              goto label_448;
            else
              goto default;
          case 2134579375:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "PH37", false) == 0)
              goto label_474;
            else
              goto default;
          case 2146134658:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "HA", false) == 0)
            {
              str1 = Conversions.ToString(1);
              goto default;
            }
            else
              goto default;
          case 2147811944:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "RM", false) == 0)
            {
              str1 = Conversions.ToString(12);
              goto default;
            }
            else
              goto default;
          case 2148734464:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "BD23", false) == 0)
              break;
            goto default;
          case 2151356994:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "PH34", false) == 0)
              goto label_474;
            else
              goto default;
          case 2151504089:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "PH26", false) == 0)
            {
              str1 = Conversions.ToString(16);
              goto default;
            }
            else
              goto default;
          case 2168134613:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "PH35", false) == 0)
              goto label_474;
            else
              goto default;
          case 2168281708:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "PH21", false) == 0)
              goto label_472;
            else
              goto default;
          case 2178557063:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "CO", false) == 0)
            {
              str1 = Conversions.ToString(12);
              goto default;
            }
            else
              goto default;
          case 2182904968:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "LL61", false) == 0)
              goto label_448;
            else
              goto default;
          case 2184073589:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "PH44", false) == 0)
              goto label_474;
            else
              goto default;
          case 2185059327:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "PH20", false) == 0)
              goto label_472;
            else
              goto default;
          case 2196026230:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "OL", false) == 0)
            {
              str1 = "7E";
              goto default;
            }
            else
              goto default;
          case 2199682587:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "LL60", false) == 0)
              goto label_448;
            else
              goto default;
          case 2201836946:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "PH23", false) == 0)
              goto label_472;
            else
              goto default;
          case 2212112301:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "CM", false) == 0)
            {
              str1 = Conversions.ToString(12);
              goto default;
            }
            else
              goto default;
          case 2216460206:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "LL63", false) == 0)
              goto label_448;
            else
              goto default;
          case 2218467470:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "PH38", false) == 0)
              goto label_474;
            else
              goto default;
          case 2218614565:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "PH22", false) == 0)
              goto label_472;
            else
              goto default;
          case 2226993168:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "EH44", false) == 0)
              goto label_408;
            else
              goto default;
          case 2231700039:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "RH", false) == 0)
            {
              str1 = Conversions.ToString(1);
              goto default;
            }
            else
              goto default;
          case 2233090730:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "LL78", false) == 0)
              goto label_448;
            else
              goto default;
          case 2233237825:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "LL62", false) == 0)
              goto label_448;
            else
              goto default;
          case 2234406446:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "PH49", false) == 0)
            {
              str1 = Conversions.ToString(14);
              goto default;
            }
            else
              goto default;
          case 2235245089:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "PH39", false) == 0)
              goto label_474;
            else
              goto default;
          case 2243770787:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "EH45", false) == 0)
              goto label_408;
            else
              goto default;
          case 2247609844:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "YO25", false) == 0)
            {
              str1 = Conversions.ToString(11);
              goto default;
            }
            else
              goto default;
          case 2250015444:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "LL65", false) == 0)
              goto label_448;
            else
              goto default;
          case 2260548406:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "EH46", false) == 0)
              goto label_408;
            else
              goto default;
          case 2266177797:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "BD24", false) == 0)
              break;
            goto default;
          case 2266793063:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "LL64", false) == 0)
              goto label_448;
            else
              goto default;
          case 2280525068:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "PO22", false) == 0)
              goto label_479;
            else
              goto default;
          case 2283570682:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "LL67", false) == 0)
              goto label_448;
            else
              goto default;
          case 2300348301:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "LL66", false) == 0)
              goto label_448;
            else
              goto default;
          case 2314080306:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "PO20", false) == 0)
              goto label_479;
            else
              goto default;
          case 2330710830:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "PO19", false) == 0)
              goto label_479;
            else
              goto default;
          case 2330857925:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "PO21", false) == 0)
              goto label_479;
            else
              goto default;
          case 2344436501:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "EH43", false) == 0)
              goto label_408;
            else
              goto default;
          case 2347488449:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "PO18", false) == 0)
              goto label_479;
            else
              goto default;
          case 2369488224:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "SA47", false) == 0)
              goto label_492;
            else
              goto default;
          case 2385427200:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "SA18", false) == 0)
              goto label_491;
            else
              goto default;
          case 2386265843:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "SA46", false) == 0)
              goto label_492;
            else
              goto default;
          case 2402204819:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "SA19", false) == 0)
              goto label_491;
            else
              goto default;
          case 2403043462:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "SA45", false) == 0)
              goto label_492;
            else
              goto default;
          case 2419821081:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "SA44", false) == 0)
              goto label_492;
            else
              goto default;
          case 2436598700:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "SA43", false) == 0)
              goto label_492;
            else
              goto default;
          case 2453376319:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "SA42", false) == 0)
              goto label_492;
            else
              goto default;
          case 2470153938:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "SA41", false) == 0)
              goto label_492;
            else
              goto default;
          case 2486931557:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "SA40", false) == 0)
              goto label_492;
            else
              goto default;
          case 2537558604:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "SA69", false) == 0)
              goto label_493;
            else
              goto default;
          case 2554189128:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "SA72", false) == 0)
              goto label_493;
            else
              goto default;
          case 2554336223:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "SA68", false) == 0)
              goto label_493;
            else
              goto default;
          case 2570966747:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "SA73", false) == 0)
              goto label_493;
            else
              goto default;
          case 2586758628:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "SA14", false) == 0)
              goto label_491;
            else
              goto default;
          case 2587744366:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "SA70", false) == 0)
              goto label_493;
            else
              goto default;
          case 2603536247:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "SA15", false) == 0)
              goto label_491;
            else
              goto default;
          case 2604521985:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "SA71", false) == 0)
              goto label_493;
            else
              goto default;
          case 2604669080:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "SA65", false) == 0)
              goto label_493;
            else
              goto default;
          case 2619322204:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "RG28", false) == 0)
              goto label_482;
            else
              goto default;
          case 2620313866:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "SA16", false) == 0)
              goto label_491;
            else
              goto default;
          case 2621152509:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "SA48", false) == 0)
              goto label_492;
            else
              goto default;
          case 2621446699:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "SA64", false) == 0)
              goto label_493;
            else
              goto default;
          case 2636099823:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "RG29", false) == 0)
              goto label_482;
            else
              goto default;
          case 2637091485:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "SA17", false) == 0)
              goto label_491;
            else
              goto default;
          case 2638224318:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "SA67", false) == 0)
              goto label_493;
            else
              goto default;
          case 2655001937:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "SA66", false) == 0)
              goto label_493;
            else
              goto default;
          case 2665560968:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "GU29", false) == 0)
              goto label_419;
            else
              goto default;
          case 2665708063:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "GU51", false) == 0)
              goto label_422;
            else
              goto default;
          case 2671779556:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "SA61", false) == 0)
              goto label_493;
            else
              goto default;
          case 2682338587:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "GU28", false) == 0)
              goto label_419;
            else
              goto default;
          case 2682485682:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "GU52", false) == 0)
              goto label_422;
            else
              goto default;
          case 2686432680:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "RG24", false) == 0)
              goto label_482;
            else
              goto default;
          case 2703210299:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "RG25", false) == 0)
              goto label_482;
            else
              goto default;
          case 2705334794:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "SA63", false) == 0)
              goto label_493;
            else
              goto default;
          case 2719987918:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "RG26", false) == 0)
              goto label_482;
            else
              goto default;
          case 2722112413:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "SA62", false) == 0)
              goto label_493;
            else
              goto default;
          case 2736765537:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "RG27", false) == 0)
              goto label_482;
            else
              goto default;
          case 2770320775:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "RG21", false) == 0)
              goto label_482;
            else
              goto default;
          case 2787098394:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "RG22", false) == 0)
              goto label_482;
            else
              goto default;
          case 2799946072:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "SK23", false) == 0)
              goto label_499;
            else
              goto default;
          case 2803876013:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "RG23", false) == 0)
              goto label_482;
            else
              goto default;
          case 2808107074:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "CH8", false) == 0)
              goto label_387;
            else
              goto default;
          case 2816723691:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "SK22", false) == 0)
              goto label_499;
            else
              goto default;
          case 2841662312:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "CH6", false) == 0)
              goto label_387;
            else
              goto default;
          case 2858439931:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "CH7", false) == 0)
              goto label_387;
            else
              goto default;
          case 2891995169:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "CH5", false) == 0)
              goto label_387;
            else
              goto default;
          case 2917078158:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "GU34", false) == 0)
              goto label_420;
            else
              goto default;
          case 2933855777:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "GU35", false) == 0)
              goto label_420;
            else
              goto default;
          case 2950633396:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "GU32", false) == 0)
              goto label_420;
            else
              goto default;
          case 2967411015:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "GU33", false) == 0)
              goto label_420;
            else
              goto default;
          case 2984188634:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "GU30", false) == 0)
              goto label_420;
            else
              goto default;
          case 3000966253:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "GU31", false) == 0)
              goto label_420;
            else
              goto default;
          case 3170488016:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "RH12", false) == 0)
              goto label_484;
            else
              goto default;
          case 3187265635:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "RH13", false) == 0)
              goto label_484;
            else
              goto default;
          case 3204043254:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "RH10", false) == 0)
              goto label_484;
            else
              goto default;
          case 3212857292:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "SY14", false) == 0)
            {
              str1 = "7E";
              goto default;
            }
            else
              goto default;
          case 3220820873:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "RH11", false) == 0)
              goto label_484;
            else
              goto default;
          case 3222007936:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "E", false) == 0)
            {
              str1 = Conversions.ToString(1);
              goto default;
            }
            else
              goto default;
          case 3229634911:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "SY15", false) == 0)
              goto label_514;
            else
              goto default;
          case 3237598492:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "RH16", false) == 0)
              goto label_484;
            else
              goto default;
          case 3246412530:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "SY16", false) == 0)
              goto label_514;
            else
              goto default;
          case 3254376111:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "RH17", false) == 0)
              goto label_484;
            else
              goto default;
          case 3255563174:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "G", false) == 0)
            {
              str1 = Conversions.ToString(14);
              goto default;
            }
            else
              goto default;
          case 3263190149:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "SY17", false) == 0)
              goto label_514;
            else
              goto default;
          case 3271153730:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "RH14", false) == 0)
              goto label_484;
            else
              goto default;
          case 3279967768:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "SY18", false) == 0)
              goto label_514;
            else
              goto default;
          case 3287931349:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "RH15", false) == 0)
              goto label_484;
            else
              goto default;
          case 3296745387:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "SY19", false) == 0)
              goto label_514;
            else
              goto default;
          case 3338264206:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "RH18", false) == 0)
              goto label_484;
            else
              goto default;
          case 3339451269:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "B", false) == 0)
            {
              str1 = Conversions.ToString(6);
              goto default;
            }
            else
              goto default;
          case 3355041825:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "RH19", false) == 0)
              goto label_484;
            else
              goto default;
          case 3356228888:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "M", false) == 0)
            {
              str1 = "7E";
              goto default;
            }
            else
              goto default;
          case 3373006507:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "L", false) == 0)
            {
              str1 = "7E";
              goto default;
            }
            else
              goto default;
          case 3406561745:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "N", false) == 0)
            {
              str1 = Conversions.ToString(1);
              goto default;
            }
            else
              goto default;
          case 3524005078:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "W", false) == 0)
            {
              str1 = Conversions.ToString(1);
              goto default;
            }
            else
              goto default;
          case 3591115554:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "S", false) == 0)
            {
              str1 = Conversions.ToString(11);
              goto default;
            }
            else
              goto default;
          case 3607171716:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "PE11", false) == 0)
              goto label_469;
            else
              goto default;
          case 3623949335:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "PE10", false) == 0)
              goto label_469;
            else
              goto default;
          case 3657504573:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "PE12", false) == 0)
              goto label_469;
            else
              goto default;
          case 3803599548:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "KW16", false) == 0)
              goto label_439;
            else
              goto default;
          case 3820377167:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "KW17", false) == 0)
              goto label_439;
            else
              goto default;
          case 3828888496:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "S42", false) == 0)
              goto label_489;
            else
              goto default;
          case 3845666115:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "S43", false) == 0)
              goto label_489;
            else
              goto default;
          case 3853932405:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "KW15", false) == 0)
              goto label_439;
            else
              goto default;
          case 3862443734:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "S40", false) == 0)
              goto label_489;
            else
              goto default;
          case 3879221353:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "S41", false) == 0)
              goto label_489;
            else
              goto default;
          case 3926767945:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "SN7", false) == 0)
            {
              str1 = Conversions.ToString(1);
              goto default;
            }
            else
              goto default;
          case 3929554210:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "S44", false) == 0)
              goto label_489;
            else
              goto default;
          case 3946331829:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "S45", false) == 0)
              goto label_489;
            else
              goto default;
          case 3962799947:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "IV36", false) == 0)
            {
              str1 = Conversions.ToString(16);
              goto default;
            }
            else
              goto default;
          case 4013629074:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "LA8", false) == 0)
              goto label_443;
            else
              goto default;
          case 4029910423:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "IV32", false) == 0)
              goto label_434;
            else
              goto default;
          case 4030406693:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "LA9", false) == 0)
              goto label_443;
            else
              goto default;
          case 4044676224:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "LL50", false) == 0)
              goto label_448;
            else
              goto default;
          case 4046688042:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "IV31", false) == 0)
              goto label_434;
            else
              goto default;
          case 4061453843:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "LL51", false) == 0)
              goto label_448;
            else
              goto default;
          case 4063465661:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "IV30", false) == 0)
              goto label_434;
            else
              goto default;
          case 4063961931:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "LA7", false) == 0)
              goto label_443;
            else
              goto default;
          case 4078231462:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "LL52", false) == 0)
              goto label_448;
            else
              goto default;
          case 4079217200:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "LL32", false) == 0)
              goto label_448;
            else
              goto default;
          case 4095009081:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "LL53", false) == 0)
              goto label_448;
            else
              goto default;
          case 4095994819:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "LL33", false) == 0)
              goto label_448;
            else
              goto default;
          case 4111786700:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "LL54", false) == 0)
              goto label_448;
            else
              goto default;
          case 4112772438:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "LL30", false) == 0)
              goto label_448;
            else
              goto default;
          case 4126158719:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "YO15", false) == 0)
              goto label_536;
            else
              goto default;
          case 4128564319:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "LL55", false) == 0)
              goto label_448;
            else
              goto default;
          case 4129550057:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "LL31", false) == 0)
              goto label_448;
            else
              goto default;
          case 4129697152:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "LL25", false) == 0)
              goto label_447;
            else
              goto default;
          case 4142936338:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "YO16", false) == 0)
              goto label_536;
            else
              goto default;
          case 4145341938:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "LL56", false) == 0)
              goto label_448;
            else
              goto default;
          case 4146327676:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "LL36", false) == 0)
              goto label_448;
            else
              goto default;
          case 4146474771:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "LL24", false) == 0)
              goto label_447;
            else
              goto default;
          case 4162119557:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "LL57", false) == 0)
              goto label_448;
            else
              goto default;
          case 4163105295:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "LL37", false) == 0)
              goto label_448;
            else
              goto default;
          case 4163252390:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "LL27", false) == 0)
              goto label_447;
            else
              goto default;
          case 4178897176:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "LL58", false) == 0)
              goto label_448;
            else
              goto default;
          case 4179882914:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "LL34", false) == 0)
              goto label_448;
            else
              goto default;
          case 4180030009:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "LL26", false) == 0)
              goto label_447;
            else
              goto default;
          case 4195674795:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "LL59", false) == 0)
              goto label_448;
            else
              goto default;
          case 4196660533:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "LL35", false) == 0)
              goto label_448;
            else
              goto default;
          case 4230362866:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "LL23", false) == 0)
              goto label_447;
            else
              goto default;
          case 4246993390:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "LL38", false) == 0)
              goto label_448;
            else
              goto default;
          case 4263771009:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "LL39", false) == 0)
              goto label_448;
            else
              goto default;
          default:
label_539:
            region = str1;
            goto label_540;
        }
        str1 = Conversions.ToString(10);
        goto label_539;
label_387:
        str1 = "7W";
        goto label_539;
label_389:
        str1 = Conversions.ToString(1);
        goto label_539;
label_400:
        str1 = "9E";
        goto label_539;
label_408:
        str1 = Conversions.ToString(9);
        goto label_539;
label_417:
        str1 = Conversions.ToString(3);
        goto label_539;
label_419:
        str1 = Conversions.ToString(2);
        goto label_539;
label_420:
        str1 = Conversions.ToString(3);
        goto label_539;
label_422:
        str1 = Conversions.ToString(3);
        goto label_539;
label_434:
        str1 = Conversions.ToString(16);
        goto label_539;
label_439:
        str1 = Conversions.ToString(19);
        goto label_539;
label_443:
        str1 = "8E";
        goto label_539;
label_447:
        str1 = Conversions.ToString(13);
        goto label_539;
label_448:
        str1 = Conversions.ToString(13);
        goto label_539;
label_469:
        str1 = Conversions.ToString(11);
        goto label_539;
label_470:
        str1 = Conversions.ToString(11);
        goto label_539;
label_472:
        str1 = Conversions.ToString(17);
        goto label_539;
label_474:
        str1 = Conversions.ToString(17);
        goto label_539;
label_479:
        str1 = Conversions.ToString(2);
        goto label_539;
label_482:
        str1 = Conversions.ToString(3);
        goto label_539;
label_484:
        str1 = Conversions.ToString(2);
        goto label_539;
label_488:
        str1 = Conversions.ToString(6);
        goto label_539;
label_489:
        str1 = Conversions.ToString(6);
        goto label_539;
label_491:
        str1 = Conversions.ToString(13);
        goto label_539;
label_492:
        str1 = Conversions.ToString(13);
        goto label_539;
label_493:
        str1 = Conversions.ToString(13);
        goto label_539;
label_499:
        str1 = Conversions.ToString(6);
        goto label_539;
label_506:
        str1 = Conversions.ToString(3);
        goto label_539;
label_508:
        str1 = Conversions.ToString(10);
        goto label_539;
label_514:
        str1 = Conversions.ToString(13);
        goto label_539;
label_536:
        str1 = Conversions.ToString(11);
        goto label_539;
      }
label_540:
      return region;
    }

    private static void NHER_Dwellings()
    {
      if (OtherCompanies.NHERDataSet.Tables["Dwelling"].Rows.Count <= 0)
        return;
      int num = checked (OtherCompanies.NHERDataSet.Tables["Dwelling"].Rows.Count - 1);
      int index = 0;
      while (index <= num)
      {
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].YearBuilt = Conversions.ToInteger(OtherCompanies.NHERDataSet.Tables["Dwelling"].Rows[index]["YearBuilt"]);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Transaction = "New dwelling";
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Tenure = "Unknown";
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Address.Country = "England";
        if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(OtherCompanies.NHERDataSet.Tables["Dwelling"].Rows[index]["Region"])))
        {
          object Left = OtherCompanies.NHERDataSet.Tables["Dwelling"].Rows[index]["Region"];
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) 2, false))
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Address.Country = "Scotland";
          else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) 3, false))
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Address.Country = "Northern Ireland";
          else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) 4, false))
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Address.Country = "England";
          else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) 5, false))
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Address.Country = "Wales";
        }
        if (OtherCompanies.NHERDataSet.Tables["JobDetails"].Columns.Contains("NumberOfDwellingsAbove") && Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectNotEqual(OtherCompanies.NHERDataSet.Tables["JobDetails"].Rows[index]["NumberOfDwellingsAbove"], (object) -1, false))
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoOFDwellingsAbove = Conversions.ToInteger(OtherCompanies.NHERDataSet.Tables["JobDetails"].Rows[index]["NumberOfDwellingsAbove"]);
        if (OtherCompanies.NHERDataSet.Tables["JobDetails"].Columns.Contains("NumberOfDwellingsBelow") && Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectNotEqual(OtherCompanies.NHERDataSet.Tables["JobDetails"].Rows[index]["NumberOfDwellingsBelow"], (object) -1, false))
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoOFDwellingsBelow = Conversions.ToInteger(OtherCompanies.NHERDataSet.Tables["JobDetails"].Rows[index]["NumberOfDwellingsBelow"]);
        if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(OtherCompanies.NHERDataSet.Tables["Dwelling"].Rows[index]["PropertyType"])))
        {
          object Left = OtherCompanies.NHERDataSet.Tables["Dwelling"].Rows[index]["PropertyType"];
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) 0, false))
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PropertyType = "House";
          else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) 1, false))
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PropertyType = "Bungalow";
          else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) 2, false))
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PropertyType = "Flat";
          else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) 3, false))
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PropertyType = "Maisonette";
        }
        if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(OtherCompanies.NHERDataSet.Tables["Dwelling"].Rows[index]["BuiltForm"])))
        {
          object Left = OtherCompanies.NHERDataSet.Tables["Dwelling"].Rows[index]["BuiltForm"];
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].BuildForm = !Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) 0, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) 1, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) 2, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) 3, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) 4, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) 5, false) ? "Detached" : "Enclosed End") : "Enclosed mid") : "End-terrace") : "Mid-terrace") : "Semi-detached") : "Detached";
        }
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectNotEqual(OtherCompanies.NHERDataSet.Tables["Dwelling"].Rows[index]["FlatType"], (object) -1, false))
        {
          object Left = OtherCompanies.NHERDataSet.Tables["Dwelling"].Rows[index]["FlatType"];
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) 0, false))
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].FlatType = "Ground floor";
          else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) 1, false))
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].FlatType = "Mid floor";
          else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) 2, false))
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].FlatType = "Top floor";
        }
        object Left1 = OtherCompanies.NHERDataSet.Tables["Dwelling"].Rows[index]["Tariff"];
        if (Conversions.ToBoolean((object) (bool) (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(Left1, (object) 0, false)) ? 1 : (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(Left1, (object) 1, false)) ? 1 : 0))))
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.ElectricityTariff = "standard tariff";
        else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left1, (object) 2, false))
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.ElectricityTariff = "7-hour tariff";
        else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left1, (object) 4, false))
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.ElectricityTariff = "10-hour tariff";
        else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left1, (object) 4, false))
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.ElectricityTariff = "24-hour tariff";
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Overheat = !Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(OtherCompanies.NHERDataSet.Tables["Dwelling"].Rows[index]["Summeroverheating"], (object) 1, false) ? "No" : "Yes";
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Shelter = Conversions.ToSingle(OtherCompanies.NHERDataSet.Tables["Dwelling"].Rows[index]["ShelteredSides"]);
        object Left2 = OtherCompanies.NHERDataSet.Tables["Dwelling"].Rows[index]["Terrain"];
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left2, (object) 0, false))
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Terrain = "Dense urban";
        else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left2, (object) 1, false))
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Terrain = "Low rise urban / suburban";
        else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left2, (object) 2, false))
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Terrain = "Rural";
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Storeys = Conversions.ToInteger(OtherCompanies.NHERDataSet.Tables["Dwelling"].Rows[index]["Storeys"]);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Conservatory = !Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(OtherCompanies.NHERDataSet.Tables["Dwelling"].Rows[index]["HasHeatedConservatory"], (object) 1, false) ? "No conservatory" : "Separated unheated conservatory";
        object Left3 = OtherCompanies.NHERDataSet.Tables["Dwelling"].Rows[index]["Orientation"];
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Orientation = !Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left3, (object) 0, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left3, (object) 1, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left3, (object) 2, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left3, (object) 3, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left3, (object) 4, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left3, (object) 5, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left3, (object) 6, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left3, (object) 7, false) ? "Unspecified" : "South West") : "South East") : "South") : "West") : "East") : "North West") : "North East") : "North";
        object Left4 = OtherCompanies.NHERDataSet.Tables["Dwelling"].Rows[index]["SummerOverheating"];
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left4, (object) 0, false))
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Overheat = "No";
        else if (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left4, (object) 1, false) && Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left4, (object) 0, false))
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Overheat = "Yes";
        try
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectGreater(OtherCompanies.NHERDataSet.Tables["Dwelling"].Rows[index]["LivingNonheatLossarea"], (object) 0, false))
          {
            // ISSUE: variable of a reference type
            float& local;
            // ISSUE: explicit reference operation
            double single = (double) Conversions.ToSingle(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) ^(local = ref SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].LivingArea), OtherCompanies.NHERDataSet.Tables["Dwelling"].Rows[index]["LivingNonheatLossarea"]));
            local = (float) single;
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        checked { ++index; }
      }
    }

    private static void NHER_Storeys()
    {
      OtherCompanies.TotalFloorArea = 0.0;
      if (OtherCompanies.NHERDataSet.Tables["Storey"].Rows.Count <= 0)
        return;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Storeys = OtherCompanies.NHERDataSet.Tables["Storey"].Rows.Count;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Dims = new SAP_Module.Dimensions[checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Storeys - 1 + 1)];
      int num = checked (OtherCompanies.NHERDataSet.Tables["Storey"].Rows.Count - 1);
      int index = 0;
      while (index <= num)
      {
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Dims[index].Area = Conversions.ToSingle(OtherCompanies.NHERDataSet.Tables["Storey"].Rows[index]["Area"]);
        OtherCompanies.TotalFloorArea += (double) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Dims[index].Area;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Dims[index].Height = Conversions.ToSingle(OtherCompanies.NHERDataSet.Tables["Storey"].Rows[index]["Height"]);
        checked { ++index; }
      }
    }

    private static void NHER_Walls()
    {
      if (OtherCompanies.NHERDataSet.Tables["Wall"].Rows.Count <= 0)
        return;
      int index1 = 0;
      int num1 = checked (OtherCompanies.NHERDataSet.Tables["Wall"].Rows.Count - 1);
      int index2 = 0;
      while (index2 <= num1)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectNotEqual(OtherCompanies.NHERDataSet.Tables["Wall"].Rows[index2]["Type"], (object) 3, false))
        {
          // ISSUE: variable of a reference type
          SAP_Module.Opaques[]& local;
          // ISSUE: explicit reference operation
          SAP_Module.Opaques[] opaquesArray = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local = ref SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Walls), (Array) new SAP_Module.Opaques[checked (index1 + 1)]);
          local = opaquesArray;
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Walls[index1].Name = Conversions.ToString(OtherCompanies.NHERDataSet.Tables["Wall"].Rows[index2]["Description"]);
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Walls[index1].Type = "Exposed wall";
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Walls[index1].Area = Conversions.ToSingle(OtherCompanies.NHERDataSet.Tables["Wall"].Rows[index2]["GrossArea"]);
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Walls[index1].U_Value = Conversions.ToSingle(OtherCompanies.NHERDataSet.Tables["Wall"].Rows[index2]["UValue"]);
          checked { ++index1; }
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofWalls = index1;
        }
        checked { ++index2; }
      }
      int index3 = 0;
      int num2 = checked (OtherCompanies.NHERDataSet.Tables["Wall"].Rows.Count - 1);
      int index4 = 0;
      while (index4 <= num2)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(OtherCompanies.NHERDataSet.Tables["Wall"].Rows[index4]["Type"], (object) 3, false))
        {
          // ISSUE: variable of a reference type
          SAP_Module.PartyWall[]& local;
          // ISSUE: explicit reference operation
          SAP_Module.PartyWall[] partyWallArray = (SAP_Module.PartyWall[]) Utils.CopyArray((Array) ^(local = ref SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PWalls), (Array) new SAP_Module.PartyWall[checked (index3 + 1)]);
          local = partyWallArray;
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PWalls[index3].Name = Conversions.ToString(OtherCompanies.NHERDataSet.Tables["Wall"].Rows[index4]["Description"]);
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PWalls[index3].Area = Conversions.ToSingle(OtherCompanies.NHERDataSet.Tables["Wall"].Rows[index4]["GrossArea"]);
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PWalls[index3].U_Value = Conversions.ToSingle(OtherCompanies.NHERDataSet.Tables["Wall"].Rows[index4]["UValue"]);
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PWalls[index3].Type = "Unfilled cavity With no effective edge sealing ";
          checked { ++index3; }
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofPWalls = index3;
        }
        checked { ++index4; }
      }
    }

    private static void NHER_Roofs()
    {
      if (OtherCompanies.NHERDataSet.Tables["Roof"].Rows.Count <= 0)
        return;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofRoofs = OtherCompanies.NHERDataSet.Tables["Roof"].Rows.Count;
      // ISSUE: variable of a reference type
      SAP_Module.Opaques[]& local;
      // ISSUE: explicit reference operation
      SAP_Module.Opaques[] opaquesArray = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local = ref SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Roofs), (Array) new SAP_Module.Opaques[checked (OtherCompanies.NHERDataSet.Tables["Roof"].Rows.Count + 1)]);
      local = opaquesArray;
      int num = checked (OtherCompanies.NHERDataSet.Tables["Roof"].Rows.Count - 1);
      int index = 0;
      while (index <= num)
      {
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Roofs[index].Name = Conversions.ToString(OtherCompanies.NHERDataSet.Tables["Roof"].Rows[index]["Description"]);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Roofs[index].Type = "Pitched - insulated rafters";
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Roofs[index].Area = Conversions.ToSingle(OtherCompanies.NHERDataSet.Tables["Roof"].Rows[index]["GrossArea"]);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Roofs[index].U_Value = Conversions.ToSingle(OtherCompanies.NHERDataSet.Tables["Roof"].Rows[index]["UValue"]);
        checked { ++index; }
      }
    }

    private static void NHER_Floors()
    {
      if (OtherCompanies.NHERDataSet.Tables["Floor"].Rows.Count <= 0)
        return;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Storeys = OtherCompanies.NHERDataSet.Tables["Floor"].Rows.Count;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofFloors = OtherCompanies.NHERDataSet.Tables["Floor"].Rows.Count;
      // ISSUE: variable of a reference type
      SAP_Module.Opaques[]& local1;
      // ISSUE: explicit reference operation
      SAP_Module.Opaques[] opaquesArray = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local1 = ref SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Floors), (Array) new SAP_Module.Opaques[checked (OtherCompanies.NHERDataSet.Tables["Floor"].Rows.Count + 1)]);
      local1 = opaquesArray;
      int num = checked (OtherCompanies.NHERDataSet.Tables["Floor"].Rows.Count - 1);
      int index = 0;
      while (index <= num)
      {
        try
        {
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Floors[index].Name = Conversions.ToString(OtherCompanies.NHERDataSet.Tables["Floor"].Rows[index]["Description"]);
          object Left = OtherCompanies.NHERDataSet.Tables["Floor"].Rows[index]["Type"];
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Floors[index].Type = !Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) 0, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) 2, false) ? "Ground floor" : "Exposed floor") : "Basement floor";
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Floors[index].Name = Conversions.ToString(OtherCompanies.NHERDataSet.Tables["Floor"].Rows[index]["Ref"]);
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Floors[index].Construction = "Suspended concrete floor, carpeted";
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Floors[index].Area = Conversions.ToSingle(OtherCompanies.NHERDataSet.Tables["Floor"].Rows[index]["Area"]);
          // ISSUE: variable of a reference type
          float& local2;
          // ISSUE: explicit reference operation
          double single = (double) Conversions.ToSingle(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) ^(local2 = ref SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].LivingArea), OtherCompanies.NHERDataSet.Tables["Floor"].Rows[index]["LivingArea"]));
          local2 = (float) single;
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Floors[index].U_Value = Conversions.ToSingle(OtherCompanies.NHERDataSet.Tables["Floor"].Rows[index]["UValue"]);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        checked { ++index; }
      }
    }

    private static string hardCoating(string Text, int Value)
    {
      switch (Value)
      {
        case 0:
          Text += ", hard coat)";
          break;
        case 1:
          Text += ", soft coat)";
          break;
      }
      return Text;
    }

    private static string LowECoating(string Text, int Value)
    {
      switch (Value)
      {
        case 0:
          Text += " (low-E, En = 0.05";
          break;
        case 1:
          Text += " (low-E, En = 0.1";
          break;
      }
      return Text;
    }

    private static string Filled(string Text, int value)
    {
      switch (value)
      {
        case 0:
          Text += ", air filled";
          break;
        case 1:
          Text += ", argon filled";
          break;
      }
      return Text;
    }

    private static void NHER_Openings()
    {
      try
      {
        int num1 = checked (OtherCompanies.NHERDataSet.Tables["Opening"].Rows.Count - 1);
        int index1 = 0;
        int num2;
        while (index1 <= num1)
        {
          if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.OrObject(Microsoft.VisualBasic.CompilerServices.Operators.OrObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(OtherCompanies.NHERDataSet.Tables["Opening"].Rows[index1]["OpeningType"], (object) 3, false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(OtherCompanies.NHERDataSet.Tables["Opening"].Rows[index1]["OpeningType"], (object) 2, false)), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(OtherCompanies.NHERDataSet.Tables["Opening"].Rows[index1]["OpeningType"], (object) 1, false))))
            checked { ++num2; }
          checked { ++index1; }
        }
        int num3 = checked (OtherCompanies.NHERDataSet.Tables["Opening"].Rows.Count - 1);
        int index2 = 0;
        int num4;
        while (index2 <= num3)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(OtherCompanies.NHERDataSet.Tables["Opening"].Rows[index2]["OpeningType"], (object) 4, false))
            checked { ++num4; }
          checked { ++index2; }
        }
        int num5 = checked (OtherCompanies.NHERDataSet.Tables["Opening"].Rows.Count - 1);
        int index3 = 0;
        int num6;
        while (index3 <= num5)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(OtherCompanies.NHERDataSet.Tables["Opening"].Rows[index3]["OpeningType"], (object) 5, false))
            checked { ++num6; }
          checked { ++index3; }
        }
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofWindows = num4;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofDoors = num2;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofRoofLights = num6;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights = new SAP_Module.RoofLight[checked (num6 - 1 + 1)];
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors = new SAP_Module.Door[checked (num2 - 1 + 1)];
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows = new SAP_Module.Window[checked (num4 - 1 + 1)];
        if (OtherCompanies.NHERDataSet.Tables["Opening"].Rows.Count > 0)
        {
          int index4 = 0;
          try
          {
            int num7 = checked (OtherCompanies.NHERDataSet.Tables["Opening"].Rows.Count - 1);
            int index5 = 0;
            while (index5 <= num7)
            {
              if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.OrObject(Microsoft.VisualBasic.CompilerServices.Operators.OrObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(OtherCompanies.NHERDataSet.Tables["Opening"].Rows[index5]["OpeningType"], (object) 3, false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(OtherCompanies.NHERDataSet.Tables["Opening"].Rows[index5]["OpeningType"], (object) 2, false)), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(OtherCompanies.NHERDataSet.Tables["Opening"].Rows[index5]["OpeningType"], (object) 1, false))))
              {
                SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors[index4].Name = Conversions.ToString(OtherCompanies.NHERDataSet.Tables["Opening"].Rows[index5]["Ref"]);
                SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors[index4].DoorType = !Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(OtherCompanies.NHERDataSet.Tables["Opening"].Rows[index5]["HalfGlazed"], (object) 1, false) ? "Solid" : "Half glazed";
                object Left1 = OtherCompanies.NHERDataSet.Tables["Opening"].Rows[index5]["OpeningType"];
                if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left1, (object) 1, false))
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors[index4].DoorType = "Solid";
                else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left1, (object) 2, false))
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors[index4].DoorType = "Half glazed";
                else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left1, (object) 3, false))
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors[index4].DoorType = "Fully glazed";
                SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors[index4].U = Conversions.ToSingle(OtherCompanies.NHERDataSet.Tables["Opening"].Rows[index5]["UValue"]);
                object Left2 = OtherCompanies.NHERDataSet.Tables["Opening"].Rows[index5]["Source"];
                if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left2, (object) 2, false))
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors[index4].UValueSource = "Manufacturer";
                else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left2, (object) 0, false))
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors[index4].UValueSource = "SAP 2012";
                else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left2, (object) 1, false))
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors[index4].UValueSource = "BFRC";
                object Left3 = OtherCompanies.NHERDataSet.Tables["Opening"].Rows[index5]["Overshading"];
                if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left3, (object) 1, false))
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors[index4].Overshading = "Average or unknown";
                else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left3, (object) 2, false))
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors[index4].Overshading = "More than average";
                else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left3, (object) 3, false))
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors[index4].Overshading = "Heavy";
                else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left3, (object) 0, false))
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors[index4].Overshading = "Very Little";
                object Left4 = OtherCompanies.NHERDataSet.Tables["Opening"].Rows[index5]["Orientation"];
                int num8 = Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(Left4, (object) 0, false)) ? 1 : (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(Left4, (object) -1, false)) ? 1 : 0);
                SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors[index4].Orientation = !Conversions.ToBoolean((object) (bool) num8) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left4, (object) 1, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left4, (object) 2, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left4, (object) 3, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left4, (object) 4, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left4, (object) 5, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left4, (object) 6, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left4, (object) 7, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left4, (object) 8, false) ? "Unspecified" : "North West") : "West") : "South West") : "South") : "South East") : "East") : "North East") : "North") : "";
                SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors[index4].Width = Conversions.ToSingle(Microsoft.VisualBasic.CompilerServices.Operators.MultiplyObject(OtherCompanies.NHERDataSet.Tables["Opening"].Rows[index5]["Width"], (object) 1000));
                SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors[index4].Height = Conversions.ToSingle(Microsoft.VisualBasic.CompilerServices.Operators.MultiplyObject(OtherCompanies.NHERDataSet.Tables["Opening"].Rows[index5]["Height"], (object) 1000));
                SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors[index4].Location = Conversions.ToString(OtherCompanies.NHERDataSet.Tables["Opening"].Rows[index5]["LocationDescription"]);
                SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors[index4].g = Conversions.ToSingle(OtherCompanies.NHERDataSet.Tables["Opening"].Rows[index5]["TransmittanceFactor"]);
                SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors[index4].FF = Conversions.ToSingle(OtherCompanies.NHERDataSet.Tables["Opening"].Rows[index5]["FrameFactor"]);
                SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors[index4].Area = (float) (Conversion.Val(RuntimeHelpers.GetObjectValue(OtherCompanies.NHERDataSet.Tables["Opening"].Rows[index5]["Width"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(OtherCompanies.NHERDataSet.Tables["Opening"].Rows[index5]["Height"])));
                SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors[index4].g = Conversions.ToSingle(OtherCompanies.NHERDataSet.Tables["Opening"].Rows[index5]["TransmittanceFactor"]);
                string str = "";
                object Left5 = OtherCompanies.NHERDataSet.Tables["Opening"].Rows[index5]["GlazingType"];
                if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left5, (object) 0, false))
                  str = "Single-glazed";
                else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left5, (object) 1, false))
                  str = "double-glazed";
                else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left5, (object) 2, false))
                  str = "double-glazed";
                else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left5, (object) 3, false))
                  str = "triple-glazed";
                else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left5, (object) 4, false))
                  str = "triple-glazed";
                else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left5, (object) 5, false))
                  str = "Secondary glazing";
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Single-glazed", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Secondary glazing", false) != 0)
                {
                  if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectNotEqual(OtherCompanies.NHERDataSet.Tables["Opening"].Rows[index5]["Argon"], (object) -1, false))
                    str = OtherCompanies.Filled(str, Conversions.ToInteger(OtherCompanies.NHERDataSet.Tables["Opening"].Rows[index5]["Argon"]));
                  if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectNotEqual(OtherCompanies.NHERDataSet.Tables["Opening"].Rows[index5]["LowECoating"], (object) -1, false))
                    str = OtherCompanies.LowECoating(str, Conversions.ToInteger(OtherCompanies.NHERDataSet.Tables["Opening"].Rows[index5]["LowECoating"]));
                  if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectNotEqual(OtherCompanies.NHERDataSet.Tables["Opening"].Rows[index5]["Emissivity"], (object) -1, false))
                    str = OtherCompanies.hardCoating(str, Conversions.ToInteger(OtherCompanies.NHERDataSet.Tables["Opening"].Rows[index5]["Emissivity"]));
                }
                SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors[index4].GlazingType = str;
                object Left6 = OtherCompanies.NHERDataSet.Tables["Opening"].Rows[index5]["Frame"];
                SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors[index4].FrameType = !Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left6, (object) 0, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left6, (object) 1, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left6, (object) 2, false) ? "Metal, thermal break" : "PVC-U") : "Metal") : "Wood";
                object Left7 = OtherCompanies.NHERDataSet.Tables["Opening"].Rows[index5]["ThermalBreak"];
                if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left7, (object) 0, false))
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors[index4].ThermalBreak = "4mm";
                else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left7, (object) 1, false))
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors[index4].ThermalBreak = "8mm";
                else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left7, (object) 2, false))
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors[index4].ThermalBreak = "12mm";
                else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left7, (object) 3, false))
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors[index4].ThermalBreak = "20mm";
                else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left7, (object) 4, false))
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors[index4].ThermalBreak = "32mm";
                else if (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left7, (object) -1, false))
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors[index4].ThermalBreak = "";
                object Left8 = OtherCompanies.NHERDataSet.Tables["Opening"].Rows[index5]["Gap"];
                if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left8, (object) 0, false))
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors[index4].AirGap = "6mm";
                else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left8, (object) 1, false))
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors[index4].AirGap = "12mm";
                else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left8, (object) 2, false))
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors[index4].AirGap = "16mm or more ";
                else if (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left8, (object) -1, false))
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors[index4].AirGap = "";
                SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors[index4].Count = 1;
                checked { ++index4; }
              }
              checked { ++index5; }
            }
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            Exception exception = ex;
            int num9 = (int) Interaction.MsgBox((object) (exception.StackTrace + exception.Message));
            ProjectData.ClearProjectError();
          }
          if (OtherCompanies.NHERDataSet.Tables["Opening"].Rows.Count > 0)
          {
            int index6 = 0;
            int num10 = checked (OtherCompanies.NHERDataSet.Tables["Opening"].Rows.Count - 1);
            int index7 = 0;
            while (index7 <= num10)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(OtherCompanies.NHERDataSet.Tables["Opening"].Rows[index7]["OpeningType"], (object) 4, false))
              {
                try
                {
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows[index6].Name = Conversions.ToString(OtherCompanies.NHERDataSet.Tables["Opening"].Rows[index7]["Description"]);
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows[index6].U = Conversions.ToSingle(OtherCompanies.NHERDataSet.Tables["Opening"].Rows[index7]["UValue"]);
                  object Left9 = OtherCompanies.NHERDataSet.Tables["Opening"].Rows[index7]["Source"];
                  if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left9, (object) 2, false))
                    SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows[index6].UValueSource = "Manufacturer";
                  else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left9, (object) 0, false))
                    SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows[index6].UValueSource = "SAP 2012";
                  else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left9, (object) 1, false))
                    SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows[index6].UValueSource = "BFRC";
                  object Left10 = OtherCompanies.NHERDataSet.Tables["Opening"].Rows[index7]["Overshading"];
                  if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left10, (object) 1, false))
                    SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows[index6].Overshading = "Average or unknown";
                  else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left10, (object) 2, false))
                    SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows[index6].Overshading = "More than average";
                  else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left10, (object) 3, false))
                    SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows[index6].Overshading = "Average or unknown";
                  else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left10, (object) 0, false))
                    SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows[index6].Overshading = "Very Little";
                  object Left11 = OtherCompanies.NHERDataSet.Tables["Opening"].Rows[index7]["Orientation"];
                  int num11 = Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(Left11, (object) 0, false)) ? 1 : (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(Left11, (object) -1, false)) ? 1 : 0);
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows[index6].Orientation = !Conversions.ToBoolean((object) (bool) num11) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left11, (object) 1, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left11, (object) 2, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left11, (object) 3, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left11, (object) 4, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left11, (object) 5, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left11, (object) 6, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left11, (object) 7, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left11, (object) 8, false) ? "Unspecified" : "North West") : "West") : "South West") : "South") : "South East") : "East") : "North East") : "North") : "";
                  if (Conversion.Val(RuntimeHelpers.GetObjectValue(OtherCompanies.NHERDataSet.Tables["Opening"].Rows[index7]["OverhangDepth"])) > 0.0)
                    SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows[index6].OverhangDepth = (float) (Conversion.Val(RuntimeHelpers.GetObjectValue(OtherCompanies.NHERDataSet.Tables["Opening"].Rows[index7]["OverhangDepth"])) * 1000.0);
                  if (Conversion.Val(RuntimeHelpers.GetObjectValue(OtherCompanies.NHERDataSet.Tables["Opening"].Rows[index7]["OverhangDepth"])) > 0.0)
                    SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows[index6].OverhangWidth = (float) (Conversion.Val(RuntimeHelpers.GetObjectValue(OtherCompanies.NHERDataSet.Tables["Opening"].Rows[index7]["OverhangWidth"])) * 1000.0);
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows[index6].Width = Conversions.ToSingle(Microsoft.VisualBasic.CompilerServices.Operators.MultiplyObject(OtherCompanies.NHERDataSet.Tables["Opening"].Rows[index7]["Width"], (object) 1000));
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows[index6].Height = Conversions.ToSingle(Microsoft.VisualBasic.CompilerServices.Operators.MultiplyObject(OtherCompanies.NHERDataSet.Tables["Opening"].Rows[index7]["Height"], (object) 1000));
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows[index6].Location = Conversions.ToString(OtherCompanies.NHERDataSet.Tables["Opening"].Rows[index7]["LocationDescription"]);
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows[index6].g = Conversions.ToSingle(OtherCompanies.NHERDataSet.Tables["Opening"].Rows[index7]["TransmittanceFactor"]);
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows[index6].FF = Conversions.ToSingle(OtherCompanies.NHERDataSet.Tables["Opening"].Rows[index7]["FrameFactor"]);
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows[index6].Area = (float) (Conversion.Val(RuntimeHelpers.GetObjectValue(OtherCompanies.NHERDataSet.Tables["Opening"].Rows[index7]["Width"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(OtherCompanies.NHERDataSet.Tables["Opening"].Rows[index7]["Height"])));
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows[index6].g = Conversions.ToSingle(OtherCompanies.NHERDataSet.Tables["Opening"].Rows[index7]["TransmittanceFactor"]);
                  string str = "";
                  object Left12 = OtherCompanies.NHERDataSet.Tables["Opening"].Rows[index7]["GlazingType"];
                  if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left12, (object) 0, false))
                    str = "Single-glazed";
                  else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left12, (object) 1, false))
                    str = "double-glazed";
                  else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left12, (object) 2, false))
                    str = "double-glazed";
                  else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left12, (object) 3, false))
                    str = "triple-glazed";
                  else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left12, (object) 4, false))
                    str = "triple-glazed";
                  else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left12, (object) 5, false))
                    str = "Secondary glazing";
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Single-glazed", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Secondary glazing", false) != 0)
                  {
                    if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectNotEqual(OtherCompanies.NHERDataSet.Tables["Opening"].Rows[index7]["Argon"], (object) -1, false))
                      str = OtherCompanies.Filled(str, Conversions.ToInteger(OtherCompanies.NHERDataSet.Tables["Opening"].Rows[index7]["Argon"]));
                    if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectNotEqual(OtherCompanies.NHERDataSet.Tables["Opening"].Rows[index7]["LowECoating"], (object) -1, false))
                      str = OtherCompanies.LowECoating(str, Conversions.ToInteger(OtherCompanies.NHERDataSet.Tables["Opening"].Rows[index7]["LowECoating"]));
                    if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectNotEqual(OtherCompanies.NHERDataSet.Tables["Opening"].Rows[index7]["Emissivity"], (object) -1, false))
                      str = OtherCompanies.hardCoating(str, Conversions.ToInteger(OtherCompanies.NHERDataSet.Tables["Opening"].Rows[index7]["Emissivity"]));
                  }
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows[index6].GlazingType = str;
                  object Left13 = OtherCompanies.NHERDataSet.Tables["Opening"].Rows[index7]["Frame"];
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows[index6].FrameType = !Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left13, (object) 0, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left13, (object) 1, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left13, (object) 2, false) ? "Metal, thermal break" : "PVC-U") : "Metal") : "Wood";
                  object Left14 = OtherCompanies.NHERDataSet.Tables["Opening"].Rows[index7]["ThermalBreak"];
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows[index6].ThermalBreak = !Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left14, (object) 0, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left14, (object) 1, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left14, (object) 2, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left14, (object) 3, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left14, (object) 4, false) ? "" : "32mm") : "20mm") : "12mm") : "8mm") : "4mm";
                  object Left15 = OtherCompanies.NHERDataSet.Tables["Opening"].Rows[index7]["Gap"];
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows[index6].AirGap = !Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left15, (object) 0, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left15, (object) 1, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left15, (object) 2, false) ? "" : "16mm or more ") : "12mm") : "6mm";
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows[index6].Count = 1;
                  checked { ++index6; }
                }
                catch (Exception ex)
                {
                  ProjectData.SetProjectError(ex);
                  Exception exception = ex;
                  int num12 = (int) Interaction.MsgBox((object) (exception.StackTrace + exception.Message));
                  ProjectData.ClearProjectError();
                }
              }
              checked { ++index7; }
            }
          }
          if (OtherCompanies.NHERDataSet.Tables["Opening"].Rows.Count > 0)
          {
            int index8 = 0;
            int num13 = checked (OtherCompanies.NHERDataSet.Tables["Opening"].Rows.Count - 1);
            int index9 = 0;
            while (index9 <= num13)
            {
              try
              {
                if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(OtherCompanies.NHERDataSet.Tables["Opening"].Rows[index9]["OpeningType"], (object) 5, false))
                {
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[index8].Name = Conversions.ToString(OtherCompanies.NHERDataSet.Tables["Opening"].Rows[index9]["Description"]);
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[index8].U = Conversions.ToSingle(OtherCompanies.NHERDataSet.Tables["Opening"].Rows[index9]["UValue"]);
                  object Left16 = OtherCompanies.NHERDataSet.Tables["Opening"].Rows[index9]["Source"];
                  if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left16, (object) 2, false))
                    SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[index8].UValueSource = "Manufacturer";
                  else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left16, (object) 0, false))
                    SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[index8].UValueSource = "SAP 2012";
                  else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left16, (object) 1, false))
                    SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[index8].UValueSource = "BFRC";
                  object Left17 = OtherCompanies.NHERDataSet.Tables["Opening"].Rows[index9]["Overshading"];
                  if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left17, (object) 1, false))
                    SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[index8].Overshading = "Average or unknown";
                  else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left17, (object) 2, false))
                    SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[index8].Overshading = "More than average";
                  else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left17, (object) 3, false))
                    SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[index8].Overshading = "Average or unknown";
                  else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left17, (object) 0, false))
                    SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[index8].Overshading = "Very Little";
                  object Left18 = OtherCompanies.NHERDataSet.Tables["Opening"].Rows[index9]["Orientation"];
                  int num14 = Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(Left18, (object) 0, false)) ? 1 : (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(Left18, (object) -1, false)) ? 1 : 0);
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[index8].Orientation = !Conversions.ToBoolean((object) (bool) num14) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left18, (object) 1, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left18, (object) 2, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left18, (object) 3, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left18, (object) 4, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left18, (object) 5, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left18, (object) 6, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left18, (object) 7, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left18, (object) 8, false) ? "Horizontal" : "North West") : "West") : "South West") : "South") : "South East") : "East") : "North East") : "North") : "";
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[index8].OverhangDepth = (float) (Conversion.Val(RuntimeHelpers.GetObjectValue(OtherCompanies.NHERDataSet.Tables["Opening"].Rows[index9]["OverhangDepth"])) * 1000.0);
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[index8].OverhangWidth = (float) (Conversion.Val(RuntimeHelpers.GetObjectValue(OtherCompanies.NHERDataSet.Tables["Opening"].Rows[index9]["OverhangWidth"])) * 1000.0);
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[index8].Width = Conversions.ToSingle(Microsoft.VisualBasic.CompilerServices.Operators.MultiplyObject(OtherCompanies.NHERDataSet.Tables["Opening"].Rows[index9]["Width"], (object) 1000));
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[index8].Height = Conversions.ToSingle(Microsoft.VisualBasic.CompilerServices.Operators.MultiplyObject(OtherCompanies.NHERDataSet.Tables["Opening"].Rows[index9]["Height"], (object) 1000));
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[index8].Location = Conversions.ToString(OtherCompanies.NHERDataSet.Tables["Opening"].Rows[index9]["LocationDescription"]);
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[index8].g = Conversions.ToSingle(OtherCompanies.NHERDataSet.Tables["Opening"].Rows[index9]["TransmittanceFactor"]);
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[index8].FF = Conversions.ToSingle(OtherCompanies.NHERDataSet.Tables["Opening"].Rows[index9]["FrameFactor"]);
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[index8].Area = (float) (Conversion.Val(RuntimeHelpers.GetObjectValue(OtherCompanies.NHERDataSet.Tables["Opening"].Rows[index9]["Width"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(OtherCompanies.NHERDataSet.Tables["Opening"].Rows[index9]["Height"])));
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[index8].g = Conversions.ToSingle(OtherCompanies.NHERDataSet.Tables["Opening"].Rows[index9]["TransmittanceFactor"]);
                  string str = "";
                  object Left19 = OtherCompanies.NHERDataSet.Tables["Opening"].Rows[index9]["GlazingType"];
                  if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left19, (object) 0, false))
                    str = "Single-glazed";
                  else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left19, (object) 1, false))
                    str = "double-glazed";
                  else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left19, (object) 2, false))
                    str = "double-glazed";
                  else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left19, (object) 3, false))
                    str = "triple-glazed";
                  else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left19, (object) 4, false))
                    str = "triple-glazed";
                  else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left19, (object) 5, false))
                    str = "Secondary glazing";
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Single-glazed", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Secondary glazing", false) != 0)
                  {
                    if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectNotEqual(OtherCompanies.NHERDataSet.Tables["Opening"].Rows[index9]["Argon"], (object) -1, false))
                      str = OtherCompanies.Filled(str, Conversions.ToInteger(OtherCompanies.NHERDataSet.Tables["Opening"].Rows[index9]["Argon"]));
                    if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectNotEqual(OtherCompanies.NHERDataSet.Tables["Opening"].Rows[index9]["LowECoating"], (object) -1, false))
                      str = OtherCompanies.LowECoating(str, Conversions.ToInteger(OtherCompanies.NHERDataSet.Tables["Opening"].Rows[index9]["LowECoating"]));
                    if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectNotEqual(OtherCompanies.NHERDataSet.Tables["Opening"].Rows[index9]["Emissivity"], (object) -1, false))
                      str = OtherCompanies.hardCoating(str, Conversions.ToInteger(OtherCompanies.NHERDataSet.Tables["Opening"].Rows[index9]["Emissivity"]));
                  }
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[index8].GlazingType = str;
                  if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectNotEqual(OtherCompanies.NHERDataSet.Tables["Opening"].Rows[index9]["Pitch"], (object) -1, false))
                    SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[index8].Pitch = Conversions.ToSingle(OtherCompanies.NHERDataSet.Tables["Opening"].Rows[index9]["Pitch"]);
                  object Left20 = OtherCompanies.NHERDataSet.Tables["Opening"].Rows[index9]["Frame"];
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[index8].FrameType = !Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left20, (object) 1, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left20, (object) 1, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left20, (object) 2, false) ? "Metal, thermal break" : "PVC-U") : "Metal") : "Wood";
                  object Left21 = OtherCompanies.NHERDataSet.Tables["Opening"].Rows[index9]["ThermalBreak"];
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[index8].ThermalBreak = !Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left21, (object) 0, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left21, (object) 1, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left21, (object) 2, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left21, (object) 3, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left21, (object) 4, false) ? "" : "32mm") : "20mm") : "12mm") : "8mm") : "4mm";
                  object Left22 = OtherCompanies.NHERDataSet.Tables["Opening"].Rows[index9]["Gap"];
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[index8].AirGap = !Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left22, (object) 0, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left22, (object) 1, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left22, (object) 2, false) ? "" : "16mm or more ") : "12mm") : "6mm";
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[index8].Count = 1;
                  checked { ++index8; }
                }
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                Exception exception = ex;
                int num15 = (int) Interaction.MsgBox((object) (exception.StackTrace + exception.Message));
                ProjectData.ClearProjectError();
              }
              checked { ++index9; }
            }
          }
        }
        if (num2 == 0)
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors = (SAP_Module.Door[]) null;
        if (num6 == 0)
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights = (SAP_Module.RoofLight[]) null;
        if (num4 != 0)
          return;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows = (SAP_Module.Window[]) null;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        int num = (int) Interaction.MsgBox((object) (exception.StackTrace + exception.Message));
        ProjectData.ClearProjectError();
      }
    }

    private static void NHER_Ventilation()
    {
      try
      {
        int num = checked (OtherCompanies.NHERDataSet.Tables["Ventilation"].Rows.Count - 1);
        int index = 0;
        while (index <= num)
        {
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Flues = Conversions.ToInteger(OtherCompanies.NHERDataSet.Tables["Ventilation"].Rows[index]["OpenFlues"]);
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Fans = Conversions.ToInteger(OtherCompanies.NHERDataSet.Tables["Ventilation"].Rows[index]["ExtractFans"]);
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Vents = Conversions.ToInteger(OtherCompanies.NHERDataSet.Tables["Ventilation"].Rows[index]["PassiveVents"]);
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Chimneys = Conversions.ToInteger(OtherCompanies.NHERDataSet.Tables["Ventilation"].Rows[index]["OpenFireplaces"]);
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Fires = Conversions.ToInteger(OtherCompanies.NHERDataSet.Tables["Ventilation"].Rows[index]["FluelessGasFires"]);
          if (Conversion.Val(RuntimeHelpers.GetObjectValue(OtherCompanies.NHERDataSet.Tables["Ventilation"].Rows[index]["DesignAirPermRate"])) > 0.0)
          {
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Pressure = "As designed";
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.DesignAir = Conversions.ToSingle(OtherCompanies.NHERDataSet.Tables["Ventilation"].Rows[index]["AirPermRate"]);
          }
          else if (Conversion.Val(RuntimeHelpers.GetObjectValue(OtherCompanies.NHERDataSet.Tables["Ventilation"].Rows[index]["AsBuiltAirPermRate"])) > 0.0)
          {
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Pressure = "As Built";
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.DesignAir = Conversions.ToSingle(OtherCompanies.NHERDataSet.Tables["Ventilation"].Rows[index]["AsBuiltAirPermRate"]);
          }
          else
          {
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Pressure = "Assumed";
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.AssumedAir = 15f;
          }
          object Left = OtherCompanies.NHERDataSet.Tables["Ventilation"].Rows[index]["VentilationType"];
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) 0, false))
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.MechVent = "Natural ventilation";
          else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) 4, false))
          {
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.MechVent = "Positive input from loft";
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Parameters = "SAP 2005";
          }
          else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) 5, false))
          {
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.MechVent = "Positive input from outside";
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Parameters = "SAP 2005";
          }
          else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) 1, false))
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.MechVent = "Balanced without heat recovery";
          else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) 2, false))
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.MechVent = "Balanced With heat recovery";
          else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) 3, false))
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.MechVent = "Centralised whole house extract";
          else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) 6, false))
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.MechVent = "Decentralised whole house extract";
          checked { ++index; }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        int num = (int) Interaction.MsgBox((object) (exception.StackTrace + exception.Message));
        ProjectData.ClearProjectError();
      }
    }

    private static void NHER_MechVentilation()
    {
      int num = checked (OtherCompanies.NHERDataSet.Tables["MechanicalVentilation"].Rows.Count - 1);
      int index = 0;
      while (index <= num)
      {
        object Left1 = OtherCompanies.NHERDataSet.Tables["MechanicalVentilation"].Rows[index]["ValuesFrom"];
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left1, (object) 0, false))
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Parameters = "SAP 2012";
        else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left1, (object) 1, false))
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Parameters = "User defined";
        else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left1, (object) 2, false))
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Parameters = "User defined";
        else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left1, (object) 3, false))
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Parameters = "Database";
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Decentralised.KSPF1 = Conversions.ToSingle(OtherCompanies.NHERDataSet.Tables["MechanicalVentilation"].Rows[index]["InRoomKitchenSFP"]);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Decentralised.OSPF1 = Conversions.ToSingle(OtherCompanies.NHERDataSet.Tables["MechanicalVentilation"].Rows[index]["InRoomNonKitchenSFP"]);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Decentralised.KSPF2 = Conversions.ToSingle(OtherCompanies.NHERDataSet.Tables["MechanicalVentilation"].Rows[index]["InDuctKitchenSFP"]);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Decentralised.OSPF2 = Conversions.ToSingle(OtherCompanies.NHERDataSet.Tables["MechanicalVentilation"].Rows[index]["InDuctNonKitchenSFP"]);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Decentralised.KSPF3 = Conversions.ToSingle(OtherCompanies.NHERDataSet.Tables["MechanicalVentilation"].Rows[index]["ThroughWallKitchenSFP"]);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Decentralised.KTP1 = Conversions.ToSingle(OtherCompanies.NHERDataSet.Tables["MechanicalVentilation"].Rows[index]["InRoomKitchenQuantity"]);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Decentralised.OTP1 = Conversions.ToSingle(OtherCompanies.NHERDataSet.Tables["MechanicalVentilation"].Rows[index]["InRoomNonKitchenQuantity"]);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Decentralised.KTP2 = Conversions.ToSingle(OtherCompanies.NHERDataSet.Tables["MechanicalVentilation"].Rows[index]["InDuctKitchenQuantity"]);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Decentralised.OTP2 = Conversions.ToSingle(OtherCompanies.NHERDataSet.Tables["MechanicalVentilation"].Rows[index]["InDuctNonKitchenQuantity"]);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Decentralised.KTP3 = Conversions.ToSingle(OtherCompanies.NHERDataSet.Tables["MechanicalVentilation"].Rows[index]["ThroughWallKitchenQuantity"]);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Decentralised.OTP3 = Conversions.ToSingle(OtherCompanies.NHERDataSet.Tables["MechanicalVentilation"].Rows[index]["ThroughWallNonKitchenQuantity"]);
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectNotEqual(OtherCompanies.NHERDataSet.Tables["MechanicalVentilation"].Rows[index]["IsApprovedInstaller"], (object) -1, false) && Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(OtherCompanies.NHERDataSet.Tables["MechanicalVentilation"].Rows[index]["IsApprovedInstaller"], (object) 1, false))
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.ApprovedScheme = true;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.DuctType = !Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(OtherCompanies.NHERDataSet.Tables["MechanicalVentilation"].Rows[index]["DuctInsulation"], (object) 1, false) ? "Un-Insulated" : "Insulation";
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectGreater(OtherCompanies.NHERDataSet.Tables["MechanicalVentilation"].Rows[index]["WetRooms"], (object) 0, false))
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.WetRooms = Conversions.ToInteger(OtherCompanies.NHERDataSet.Tables["MechanicalVentilation"].Rows[index]["WetRooms"]);
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectNotEqual(OtherCompanies.NHERDataSet.Tables["MechanicalVentilation"].Rows[index]["DuctType"], (object) -1, false))
        {
          object Left2 = OtherCompanies.NHERDataSet.Tables["MechanicalVentilation"].Rows[index]["DuctType"];
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left2, (object) 1, false))
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.MVDetails.DuctingType = "Rigid";
          else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left2, (object) 2, false))
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.MVDetails.DuctingType = "Flexible";
        }
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.ProductID = Conversions.ToInteger(OtherCompanies.NHERDataSet.Tables["MechanicalVentilation"].Rows[index]["MVindex"]);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.ProductName = Conversions.ToString(OtherCompanies.NHERDataSet.Tables["MechanicalVentilation"].Rows[index]["ProductName"]);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.MVDetails.SFP = Conversions.ToSingle(OtherCompanies.NHERDataSet.Tables["MechanicalVentilation"].Rows[index]["SpecificFanPower"]);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.MVDetails.HEE = Conversions.ToSingle(OtherCompanies.NHERDataSet.Tables["MechanicalVentilation"].Rows[index]["HeatRecoveryEff"]);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Infiltration.Construction = "";
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Infiltration.Lobby = "";
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Infiltration.Floor = "";
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Infiltration.DraguthP = 0.0f;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Draught = 0.0f;
        checked { ++index; }
      }
    }

    private static void HNER_HydroGenration()
    {
      if (!OtherCompanies.NHERDataSet.Tables.Contains("Renewables") || !Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(OtherCompanies.NHERDataSet.Tables["Renewables"].Rows[0]["HasHydroGenerators"], (object) 1, false))
        return;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.HydroGeneration = new SAP_Module.HydroGeneration();
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.HydroGeneration.Inlcude = true;
      int num = checked (OtherCompanies.NHERDataSet.Tables["Renewables"].Rows.Count - 1);
      int index = 0;
      while (index <= num)
      {
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.HydroGeneration.HydroGenerated = Conversions.ToSingle(OtherCompanies.NHERDataSet.Tables["Renewables"].Rows[index]["HydroElecgeneration"]);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.HydroGeneration.TotalArea = Conversions.ToString(OtherCompanies.TotalFloorArea);
        checked { ++index; }
      }
    }

    private static void HNER_ElectricGenration()
    {
      if (!OtherCompanies.NHERDataSet.Tables.Contains("Renewables") || !Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(OtherCompanies.NHERDataSet.Tables["Renewables"].Rows[0]["HasAdditionalGeneration"], (object) 1, false))
        return;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.AAEGeneration = new SAP_Module.AAEGeneration();
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.AAEGeneration.Inlcude = true;
      int num = checked (OtherCompanies.NHERDataSet.Tables["Renewables"].Rows.Count - 1);
      int index = 0;
      while (index <= num)
      {
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.AAEGeneration.EGenerated = Conversions.ToSingle(OtherCompanies.NHERDataSet.Tables["Renewables"].Rows[index]["ElectricityGenerated"]);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.AAEGeneration.TotalArea = Conversions.ToString(OtherCompanies.TotalFloorArea);
        checked { ++index; }
      }
    }

    private static void HNER_WindTurbine()
    {
      if (!OtherCompanies.NHERDataSet.Tables.Contains("Renewables") || !Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(OtherCompanies.NHERDataSet.Tables["Renewables"].Rows[0]["HasWindTurbines"], (object) 1, false))
        return;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.WindTurbine = new SAP_Module.WindTurbine();
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.WindTurbine.Inlcude = true;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.WindTurbine.WHeight = "";
      int num = checked (OtherCompanies.NHERDataSet.Tables["Windturbines"].Rows.Count - 1);
      int index = 0;
      while (index <= num)
      {
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.WindTurbine.WHeight = Conversions.ToString(OtherCompanies.NHERDataSet.Tables["Windturbines"].Rows[index]["HeightAboveRidge"]);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.WindTurbine.WRDiameter = Conversions.ToString(OtherCompanies.NHERDataSet.Tables["Windturbines"].Rows[index]["RotorDiameter"]);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.WindTurbine.WNumber = Conversions.ToInteger(OtherCompanies.NHERDataSet.Tables["Windturbines"].Rows[index]["Turbines"]);
        checked { ++index; }
      }
    }

    private static void NHER_PV()
    {
      // ISSUE: variable of a reference type
      SAP_Module.PhotoVoltaics[]& local;
      // ISSUE: explicit reference operation
      SAP_Module.PhotoVoltaics[] photoVoltaicsArray = (SAP_Module.PhotoVoltaics[]) Utils.CopyArray((Array) ^(local = ref SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Photovoltaic.Photovoltaics), (Array) new SAP_Module.PhotoVoltaics[checked (OtherCompanies.NHERDataSet.Tables["PV"].Rows.Count - 1 + 1)]);
      local = photoVoltaicsArray;
      int num = checked (OtherCompanies.NHERDataSet.Tables["PV"].Rows.Count - 1);
      int index = 0;
      while (index <= num)
      {
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Photovoltaic.Inlcude = true;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Photovoltaic.Photovoltaics[index].PPower = Conversions.ToSingle(OtherCompanies.NHERDataSet.Tables["PV"].Rows[index]["PeakPower"]);
        object Left1 = OtherCompanies.NHERDataSet.Tables["PV"].Rows[index]["CollectorOrientation"];
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Photovoltaic.Photovoltaics[index].PCOrientation = !Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left1, (object) 1, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left1, (object) 2, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left1, (object) 8, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left1, (object) 3, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left1, (object) 7, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left1, (object) 5, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left1, (object) 4, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left1, (object) 6, false) ? "Unspecified" : "South West") : "South East") : "South") : "West") : "East") : "North West") : "North East") : "North";
        object Left2 = OtherCompanies.NHERDataSet.Tables["PV"].Rows[index]["CollectorTilt"];
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Photovoltaic.Photovoltaics[index].PTilt = !Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left2, (object) 0, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left2, (object) 1, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left2, (object) 2, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left2, (object) 3, false) ? "Vertical" : "60°") : "45°") : "30°") : "Horizontal";
        object Left3 = OtherCompanies.NHERDataSet.Tables["PV"].Rows[index]["Overshading"];
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Photovoltaic.Photovoltaics[index].POvershading = !Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left3, (object) 1, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left3, (object) 2, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left3, (object) 0, false) ? "None or very little" : "Heavy") : "Modest") : "Significant";
        try
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(OtherCompanies.NHERDataSet.Tables["PV"].Rows[index]["PVConnection"], (object) 3, false))
          {
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Photovoltaic.Photovoltaics[index].FlatConnection = "PV output goes To all flats In proportion To floor area";
          }
          else
          {
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Photovoltaic.Photovoltaics[index].FlatConnection = "PV output goes To particular individual flats";
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Photovoltaic.Photovoltaics[index].DirectlyConnected = true;
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        checked { ++index; }
      }
    }

    private static void NHER_SpaceHeating()
    {
      if (OtherCompanies.NHERDataSet.Tables["SpaceHeating"].Rows.Count <= 0)
        return;
      int num = checked (OtherCompanies.NHERDataSet.Tables["SpaceHeating"].Rows.Count - 1);
      int index = 0;
      while (index <= num)
      {
        object Left = OtherCompanies.NHERDataSet.Tables["SpaceHeating"].Rows[index]["SmokeControlArea"];
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].SmokeArea = !Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) 0, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) 1, false) ? "Unknown" : "Yes") : "No";
        checked { ++index; }
      }
    }

    private static void NHER_Community()
    {
      if (OtherCompanies.NHERDataSet.Tables["CommunityHeating"].Rows.Count > 0)
      {
        int num = checked (OtherCompanies.NHERDataSet.Tables["CommunityHeating"].Rows.Count - 1);
        int index = 0;
        while (index <= num)
        {
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.HGroup = "Community heating schemes";
          if (OtherCompanies.NHERDataSet.Tables.Contains("EfficiencySource"))
          {
            object Left = OtherCompanies.NHERDataSet.Tables["CommunityHeating"].Rows[index]["EfficiencySource"];
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.InforSource = !Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) 1, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) 2, false) ? "SAP Tables" : "Manufacturer Declaration") : "Boiler Database";
          }
          if (OtherCompanies.NHERDataSet.Tables.Contains("Systemindex"))
          {
            if (Conversion.Val(RuntimeHelpers.GetObjectValue(OtherCompanies.NHERDataSet.Tables["CommunityHeating"].Rows[index]["Systemindex"])) > 0.0)
            {
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SEDBUK = Conversions.ToString(OtherCompanies.NHERDataSet.Tables["CommunityHeating"].Rows[index]["Systemindex"]);
            }
            else
            {
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SAPTableCode = Conversions.ToInteger(OtherCompanies.NHERDataSet.Tables["CommunityHeating"].Rows[index]["System"]);
              OtherCompanies.NHERSAPConverstion(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SAPTableCode);
            }
          }
          if (OtherCompanies.NHERDataSet.Tables.Contains("Fuel"))
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Fuel = OtherCompanies.FuelCheckNHER(Conversions.ToInteger(OtherCompanies.NHERDataSet.Tables["CommunityHeating"].Rows[index]["Fuel"]));
          if (OtherCompanies.NHERDataSet.Tables.Contains("Systemindex"))
          {
            object Left = OtherCompanies.NHERDataSet.Tables["HeatDistributionSystem"].Rows[index]["HeatDistributionSystem"];
            if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) 1, false))
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.InforSource = "Piping<=1990, Not pre-insulated, medium/high temp, full flow";
            else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) 2, false))
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.InforSource = "Piping<=1990, pre-insulated, low temp, full flow";
            else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) 3, false))
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.InforSource = "Piping>=1991, pre-insulated, medium temp, variable flow";
            else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) 4, false))
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.InforSource = "Piping>=1991, pre-insulated, low temp, variable flow";
            else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) 5, false))
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.InforSource = "Unknown";
          }
          if (OtherCompanies.NHERDataSet.Tables.Contains("Controls"))
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.ControlCode = Conversions.ToInteger(OtherCompanies.NHERDataSet.Tables["CommunityHeating"].Rows[index]["Controls"]);
          if (OtherCompanies.NHERDataSet.Tables.Contains("Controls"))
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Controls = OtherCompanies.GetControlText(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.ControlCode);
          try
          {
            object Left = OtherCompanies.NHERDataSet.Tables["MainHeating"].Rows[index]["CommunityHeating"];
            if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) 0, false))
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Emitter = "Systems With radiators";
            else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) 1, false))
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Emitter = "Underfloor heating, pipes In insulated timber floor";
            else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) 2, false))
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Emitter = "Underfloor heating, pipes In concrete slab";
            else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) 3, false))
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Emitter = "Underfloor heating And radiators, pipes In insulated timber floor";
            else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) 4, false))
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Emitter = "Underfloor heating And radiators, pipes In concrete slab";
            else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) 5, false))
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Emitter = "Underfloor heating, pipes In screed above insulation";
            else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) 6, false))
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Emitter = "Underfloor heating And radiators, pipes In screed above insulation";
            else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) 7, false))
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Emitter = "Fan coil units";
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
          checked { ++index; }
        }
      }
      OtherCompanies.NHER_HeatSource();
    }

    private static void NHER_HeatSource()
    {
      if (OtherCompanies.NHERDataSet.Tables["HeatSource"].Rows.Count <= 0)
        return;
      int num = checked (OtherCompanies.NHERDataSet.Tables["HeatSource"].Rows.Count - 1);
      int index = 0;
      while (index <= num)
      {
        object Left = OtherCompanies.NHERDataSet.Tables["HeatSource"].Rows[index]["Type"];
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.InforSource = !Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) 2, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) 3, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) 4, false) ? "Community geothermal heat source" : "Community waste heat from power station") : "Community heat pump") : "Community boilers";
        checked { ++index; }
      }
    }

    private static void NHER_Heating()
    {
      if (OtherCompanies.NHERDataSet.Tables["MainHeating"].Rows.Count > 0)
      {
        int num1 = checked (OtherCompanies.NHERDataSet.Tables["MainHeating"].Rows.Count - 1);
        int index1 = 0;
        while (index1 <= num1)
        {
          if (index1 == 1)
          {
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].IncludeMainHeating2 = true;
            OtherCompanies.NHER_Heating2(OtherCompanies.NHERDataSet.Tables["MainHeating"].Rows[index1]);
            break;
          }
          object Left1 = OtherCompanies.NHERDataSet.Tables["MainHeating"].Rows[index1]["EfficiencySource"];
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.InforSource = !Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left1, (object) 1, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left1, (object) 2, false) ? "SAP Tables" : "Manufacturer Declaration") : "Boiler Database";
          object Left2 = OtherCompanies.NHERDataSet.Tables["MainHeating"].Rows[index1]["HeatingType"];
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left2, (object) 0, false))
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.HGroup = "Boiler systems with radiators or underfloor heating";
          else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left2, (object) 2, false))
          {
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.HGroup = "Micro-Congeneration (Micro-CHP)";
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.InforSource = "Boiler Database";
          }
          else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left2, (object) 3, false))
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.HGroup = "Heat pumps With radiators or underfloor heating";
          else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left2, (object) 4, false))
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.HGroup = "Heat pumps With warm air distribution";
          else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left2, (object) 5, false))
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.HGroup = "Community heating schemes";
          else if (Conversions.ToBoolean((object) (bool) (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(Left2, (object) 6, false)) ? 1 : (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(Left2, (object) 1, false)) ? 1 : 0))))
          {
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.HGroup = "Electric storage systems";
            if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(OtherCompanies.NHERDataSet.Tables["MainHeating"].Rows[index1]["System"], (object) 409, false))
            {
              if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.StorageHeaters == null)
                SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.StorageHeaters = new List<SAP_Module.StorageHeater>();
              OtherCompanies.NHERDataSet.Tables["MainHeating"].Rows[index1]["Productindex"] = (object) 0;
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.InforSource = "SAP Tables";
              if (OtherCompanies.NHERDataSet.Tables.Contains("StorageHeater"))
              {
                int index2 = 0;
                if (OtherCompanies.NHERDataSet.Tables["StorageHeater"].Rows.Count > 0)
                {
                  int num2 = checked (OtherCompanies.NHERDataSet.Tables["StorageHeater"].Rows.Count - 1);
                  int index3 = 0;
                  while (index3 <= num2)
                  {
                    SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.StorageHeaters.Add(new SAP_Module.StorageHeater()
                    {
                      Index_Number = Conversions.ToString(OtherCompanies.NHERDataSet.Tables["StorageHeater"].Rows[index3]["indexnumber"]),
                      BrandName = Conversions.ToString(OtherCompanies.NHERDataSet.Tables["StorageHeater"].Rows[index3]["indexnumber"]),
                      ManuName = Conversions.ToString(OtherCompanies.NHERDataSet.Tables["StorageHeater"].Rows[index3]["indexnumber"]),
                      ModelName = Conversions.ToString(OtherCompanies.NHERDataSet.Tables["StorageHeater"].Rows[index3]["indexnumber"])
                    });
                    SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.StorageHeaters[index2].Number_Of_Heaters = Conversions.ToInteger(OtherCompanies.NHERDataSet.Tables["StorageHeater"].Rows[index3]["NumberOfHeaters"]);
                    checked { ++index2; }
                    checked { ++index3; }
                  }
                }
              }
            }
          }
          else
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.HGroup = !Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left2, (object) 7, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left2, (object) 8, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left2, (object) 9, false) ? "No heating system present" : "Other space heating systems") : "Room heaters") : "Warm air systems (Not heat pump)";
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(OtherCompanies.NHERDataSet.Tables["MainHeating"].Rows[index1]["BoilerType"], (object) 6, false))
          {
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.HGroup = "Micro-Congeneration (Micro-CHP)";
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.InforSource = "Boiler Database";
          }
          try
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(OtherCompanies.NHERDataSet.Tables["MainHeating"].Rows[index1]["HasFGHRS"], (object) 1, false))
            {
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.FGHRS.Include = true;
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.FGHRS.IndexNo = Conversions.ToString(OtherCompanies.NHERDataSet.Tables["MainHeating"].Rows[index1]["FGHRSIndex"]);
            }
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Fuel = OtherCompanies.FuelCheckNHER(Conversions.ToInteger(OtherCompanies.NHERDataSet.Tables["MainHeating"].Rows[index1]["Fuel"]));
          string hgroup = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.HGroup;
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(hgroup, "Boiler systems with radiators or underfloor heating", false) != 0)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(hgroup, "Heat pumps With radiators or underfloor heating", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(hgroup, "Heat pumps With warm air distribution", false) != 0)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(hgroup, "Micro-Congeneration (Micro-CHP)", false) == 0)
              {
                SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SGroup = "Micro-congeneration (micro-CHP)";
                SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SEDBUK = Conversions.ToString(OtherCompanies.NHERDataSet.Tables["MainHeating"].Rows[index1]["Productindex"]);
                SAP_Read.CheckSEDBUK();
              }
            }
            else
            {
              object Left3 = OtherCompanies.NHERDataSet.Tables["MainHeating"].Rows[index1]["Fuel"];
              int num3 = !Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectGreaterEqual(Left3, (object) 30, false)) ? 0 : (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectLessEqual(Left3, (object) 39, false)) ? 1 : 0);
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SGroup = !Conversions.ToBoolean((object) (bool) num3) ? "Gas-fired heat pumps" : "Electric heat pumps";
            }
          }
          else
          {
            object Left4 = OtherCompanies.NHERDataSet.Tables["MainHeating"].Rows[index1]["Fuel"];
            if (Conversions.ToBoolean((object) (bool) (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(Left4, (object) 1, false)) || Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(Left4, (object) 2, false)) || Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(Left4, (object) 3, false)) || Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(Left4, (object) 9, false)) ? 1 : (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(Left4, (object) 7, false)) ? 1 : 0))))
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SGroup = "Gas boilers And oil boilers";
            else if (Conversions.ToBoolean((object) (bool) (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(Left4, (object) 4, false)) || Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(Left4, (object) 71, false)) || Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(Left4, (object) 73, false)) || Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(Left4, (object) 74, false)) || Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(Left4, (object) 75, false)) ? 1 : (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(Left4, (object) 76, false)) ? 1 : 0))))
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SGroup = "Gas boilers And oil boilers";
            else if (Conversions.ToBoolean((object) (bool) (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(Left4, (object) 11, false)) || Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(Left4, (object) 12, false)) || Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(Left4, (object) 15, false)) || Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(Left4, (object) 20, false)) || Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(Left4, (object) 22, false)) || Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(Left4, (object) 23, false)) || Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(Left4, (object) 21, false)) ? 1 : (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(Left4, (object) 10, false)) ? 1 : 0))))
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SGroup = "Solid fuel boilers";
            else if (Conversions.ToBoolean((object) (bool) (!Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectGreaterEqual(Left4, (object) 30, false)) ? 0 : (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectLessEqual(Left4, (object) 39, false)) ? 1 : 0))))
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SGroup = "Electric boilers";
          }
          object Left5 = OtherCompanies.NHERDataSet.Tables["MainHeating"].Rows[index1]["FlueType"];
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left5, (object) 1, false))
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Boiler.FlueType = "Open";
          else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left5, (object) 2, false))
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Boiler.FlueType = "Room-sealed";
          else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left5, (object) 3, false))
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Boiler.FlueType = "Chimney";
          else if (Conversions.ToBoolean((object) (bool) (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(Left5, (object) 0, false)) ? 1 : (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(Left5, (object) 4, false)) ? 1 : 0))))
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Boiler.FlueType = "Unknown";
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Boiler.FanFlued = !Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(OtherCompanies.NHERDataSet.Tables["MainHeating"].Rows[index1]["FanFlue"], (object) 1, false) ? "No" : "Yes";
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.ControlCode = Conversions.ToInteger(OtherCompanies.NHERDataSet.Tables["MainHeating"].Rows[index1]["Controls"]);
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Controls = OtherCompanies.GetControlText(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.ControlCode);
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Boiler.BILock = !Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(OtherCompanies.NHERDataSet.Tables["MainHeating"].Rows[index1]["Interlock"], (object) 1, false) ? "No" : "Yes";
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.DelayedStart = Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(OtherCompanies.NHERDataSet.Tables["MainHeating"].Rows[index1]["DelayedStartStat"], (object) 1, false);
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(OtherCompanies.NHERDataSet.Tables["MainHeating"].Rows[index1]["Compensation"], (object) 1, false))
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Boiler.LoadWeather = true;
          object Left6 = OtherCompanies.NHERDataSet.Tables["MainHeating"].Rows[index1]["BurnerControl"];
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.FuelBurningType = !Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left6, (object) 0, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left6, (object) 1, false) ? "Unknown" : "Modulation") : "On/off";
          object Left7 = OtherCompanies.NHERDataSet.Tables["MainHeating"].Rows[index1]["Emitter"];
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left7, (object) 0, false))
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Emitter = "Systems With radiators";
          else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left7, (object) 1, false))
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Emitter = "Underfloor heating, pipes In insulated timber floor";
          else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left7, (object) 2, false))
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Emitter = "Underfloor heating, pipes In concrete slab";
          else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left7, (object) 3, false))
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Emitter = "Underfloor heating And radiators, pipes In insulated timber floor";
          else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left7, (object) 4, false))
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Emitter = "Underfloor heating And radiators, pipes In concrete slab";
          else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left7, (object) 5, false))
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Emitter = "Underfloor heating, pipes In screed above insulation";
          else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left7, (object) 6, false))
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Emitter = "Underfloor heating And radiators, pipes In screed above insulation";
          else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left7, (object) 7, false))
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Emitter = "Fan coil units";
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.HGroup, "Heat pumps With warm air distribution", false) == 0)
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Emitter = "Fan coil units";
          try
          {
            object Left8 = OtherCompanies.NHERDataSet.Tables["MainHeating"].Rows[index1]["FlowTemp"];
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Boiler.FlowTemp = !Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left8, (object) 4, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left8, (object) 3, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left8, (object) 2, false) ? "Unknown" : "Design flow temperature >45°C") : "Design flow temperature<=45°C") : "Design flow temperature<=35°C";
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
          object Left9 = OtherCompanies.NHERDataSet.Tables["MainHeating"].Rows[index1]["PumpinHeatedSpace"];
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left9, (object) 1, false))
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Boiler.PumpHP = "Yes";
          else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left9, (object) 0, false))
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Boiler.PumpHP = "No";
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(OtherCompanies.NHERDataSet.Tables["MainHeating"].Rows[index1]["OilPumpinHeatedSpace"], (object) 1, false))
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.OilPump = true;
          try
          {
            object Left10 = OtherCompanies.NHERDataSet.Tables["MainHeating"].Rows[index1]["Installed2013OrLater"];
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Boiler.PumpType = !Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left10, (object) 1, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left10, (object) 0, false) ? "Unknown" : "2012 or earlier") : "2013 or later";
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(OtherCompanies.NHERDataSet.Tables["MainHeating"].Rows[index1]["KeepHotPowerRating"], (object) 1, false))
          {
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Boiler.KeepHotTimed = true;
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Boiler.KeepHotFuel = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Fuel;
          }
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MainEff = Conversions.ToSingle(OtherCompanies.NHERDataSet.Tables["MainHeating"].Rows[index1]["Efficiency"]);
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(OtherCompanies.NHERDataSet.Tables["MainHeating"].Rows[index1]["KeepHotElec"], (object) 1, false))
          {
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Boiler.KeepHotTimed = true;
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Boiler.KeepHotFuel = "Electricity";
          }
          try
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(OtherCompanies.NHERDataSet.Tables["MainHeating"].Rows[index1]["MCSInstaller"], (object) 1, false))
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MCSCert = true;
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
          try
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectGreater(OtherCompanies.NHERDataSet.Tables["MainHeating"].Rows[index1]["CompensationIndex"], (object) 0, false))
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.ControlCodePCDFWeather = Conversions.ToString(OtherCompanies.NHERDataSet.Tables["MainHeating"].Rows[index1]["CompensationIndex"]);
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
          if (Conversion.Val(RuntimeHelpers.GetObjectValue(OtherCompanies.NHERDataSet.Tables["MainHeating"].Rows[index1]["Productindex"])) > 0.0)
          {
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SEDBUK = Conversions.ToString(OtherCompanies.NHERDataSet.Tables["MainHeating"].Rows[index1]["Productindex"]);
          }
          else
          {
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SAPTableCode = Conversions.ToInteger(OtherCompanies.NHERDataSet.Tables["MainHeating"].Rows[index1]["System"]);
            OtherCompanies.NHERSAPConverstion(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SAPTableCode);
          }
          checked { ++index1; }
        }
      }
    }

    private static void NHERSAPConverstion(int System)
    {
      int num = System;
      if (num >= 101 && num <= 109)
      {
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.HGroup = "Boiler systems with radiators or underfloor heating";
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SGroup = "Gas boilers And oil boilers";
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.BSubGroup = "Gas boilers (including LPG) 1998 or later";
        switch (System)
        {
          case 101:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Regular non-condensing With automatic ignition";
            break;
          case 102:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Regular condensing With automatic ignition";
            break;
          case 103:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Non-condensing combi With automatic ignition";
            break;
          case 104:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Condensing combi With automatic ignition";
            break;
          case 105:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Regular non-condensing With permanent pilot light";
            break;
          case 107:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Non-condensing combi With permanent pilot light";
            break;
          case 109:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Back boiler To radiators";
            break;
        }
      }
      else if (num >= 110 && num <= 114)
      {
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.HGroup = "Boiler systems with radiators or underfloor heating";
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SGroup = "Gas boilers And oil boilers";
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.BSubGroup = "Gas boilers (including LPG) pre-1998, With fan-assisted flue";
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Boiler.PumpHP = "Yes";
        switch (System)
        {
          case 111:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Regular, high or unknown thermal capacity";
            break;
          case 112:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Combi";
            break;
          case 113:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Condensing combi";
            break;
          case 114:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Regular, condensing";
            break;
        }
      }
      else if (num >= 115 && num <= 119)
      {
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.HGroup = "Boiler systems with radiators or underfloor heating";
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SGroup = "Gas boilers And oil boilers";
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.BSubGroup = "Gas boilers (including LPG) pre-1998, With balanced or open flue";
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Boiler.FlueType = "Open";
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Boiler.PumpHP = "Yes";
        switch (System)
        {
          case 115:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Regular, wall mounted";
            break;
          case 116:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Regular, floor mounted, pre 1979";
            break;
          case 117:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Regular, floor mounted, 1979 To 1997";
            break;
          case 118:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Combi";
            break;
          case 119:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Back boiler To radiators";
            break;
        }
      }
      else if (num >= 120 && num <= 123)
      {
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.HGroup = "Boiler systems with radiators or underfloor heating";
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SGroup = "Gas boilers And oil boilers";
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.BSubGroup = "Combined Primary Storage Units (CPSU) (mains gas And LPG)";
        switch (System)
        {
          case 120:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "With automatic ignition (non-condensing)";
            break;
          case 121:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "With automatic ignition (condensing)";
            break;
        }
      }
      else if (num >= 124 && num <= 132)
      {
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.HGroup = "Boiler systems with radiators or underfloor heating";
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SGroup = "Gas boilers And oil boilers";
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.BSubGroup = "Oil boilers";
        switch (System)
        {
          case 125:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Standard oil boiler 1985 To 1997";
            break;
          case 126:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Standard oil boiler, 1998 or later";
            break;
          case (int) sbyte.MaxValue:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Condensing";
            break;
          case 128:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Combi, pre-1998";
            break;
          case 129:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Combi, 1998 or later";
            break;
          case 130:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Condensing combi";
            break;
          case 131:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Oil room heater With boiler To radiators, pre 2000";
            break;
          case 132:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Oil room heater With boiler To radiators, 2000 or later";
            break;
        }
      }
      else if (num >= 133 && num <= 138)
      {
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.HGroup = "Boiler systems with radiators or underfloor heating";
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SGroup = "Gas boilers And oil boilers";
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.BSubGroup = "Range cooker boilers (mains gas And LPG)";
        switch (System)
        {
          case 133:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Single burner With permanent pilot";
            break;
          case 134:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Single burner With automatic ignition";
            break;
          case 136:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Twin burner With automatic ignition (non-condensing) pre 1998";
            break;
        }
      }
      else if (num >= 139 && num <= 140)
      {
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.HGroup = "Boiler systems with radiators or underfloor heating";
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SGroup = "Gas boilers And oil boilers";
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.BSubGroup = "Range cooker boilers (oil)";
        switch (System)
        {
          case 139:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Single burner";
            break;
          case 140:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Twin burner (non-condensing) pre 1998";
            break;
        }
      }
      else if (num >= 151 && num <= 161)
      {
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.HGroup = "Boiler systems with radiators or underfloor heating";
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SGroup = "Solid fuel boilers";
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.BSubGroup = "";
        switch (System)
        {
          case 151:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Manual feed independent boiler In heated space";
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MainEff = 60f;
            break;
          case 152:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Manual feed independent boiler In unheated space";
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MainEff = 55f;
            break;
          case 153:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Auto (gravity) feed independent boiler In heated space";
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MainEff = 65f;
            break;
          case 154:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Auto (gravity) feed independent boiler In unheated space";
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MainEff = 60f;
            break;
          case 155:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Wood chip/pellet independent boiler";
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MainEff = 63f;
            break;
          case 156:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Open fire With back boiler To radiators";
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MainEff = 55f;
            break;
          case 158:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Closed roomheater With boiler To radiators";
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MainEff = 65f;
            break;
          case 159:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Closed roomheater With boiler To radiators";
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MainEff = 63f;
            break;
          case 160:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Range cooker boiler (integral oven And boiler)";
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MainEff = 45f;
            break;
        }
      }
      else if (num >= 191 && num <= 195)
      {
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.HGroup = "Boiler systems with radiators or underfloor heating";
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SGroup = "Electric boilers";
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.BSubGroup = "";
        switch (System)
        {
          case 191:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Direct acting electric boiler";
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MainEff = 100f;
            break;
          case 192:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Electric CPSU";
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MainEff = 100f;
            break;
          case 193:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Electric dry core storage boiler";
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MainEff = 100f;
            break;
          case 195:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Electric water storage boiler";
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MainEff = 100f;
            break;
          case 196:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Boiler systems with radiators or underfloor heating";
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MainEff = 85f;
            break;
        }
      }
      else if (num >= 201 && num <= 204 || num == 211 || num == 213 || num == 214 || num == 221 || num == 223 || num == 224)
      {
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.HGroup = "Heat pumps With radiators or underfloor heating";
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SGroup = "Electric heat pumps";
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.BSubGroup = "";
        switch (System)
        {
          case 203:
          case 213:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Water source heat pump With flow temperature <= 35°C";
            break;
          case 204:
          case 214:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Air source heat pump With flow temperature <= 35°C";
            break;
          case 211:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Ground source heat pump With flow temperature <= 35°C";
            break;
          case 221:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Ground source heat pump In other cases";
            break;
          case 223:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Water source heat pump, In other cases";
            break;
          case 224:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Air source heat pump In other Case";
            break;
        }
      }
      else if (num == 215 || num == 216 || num == 217 || num == 225 || num == 226 || num == 227)
      {
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.HGroup = "Heat pumps With radiators or underfloor heating";
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SGroup = "Gas-fired heat pumps";
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.BSubGroup = "";
        switch (System)
        {
          case 215:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Ground source heat pump With flow temperature <= 35°C";
            break;
          case 216:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Water source heat pump With flow temperature <= 35°C";
            break;
          case 217:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Air source heat pump With flow temperature <= 35°C";
            break;
          case 225:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Ground source heat pump In other cases";
            break;
          case 226:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Water source heat pump, In other cases";
            break;
          case 227:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Air source heat pump In other Case";
            break;
        }
      }
      else if (num == 301 || num == 306)
      {
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.HGroup = "Community heating schemes";
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.InforSource = "SAP Tables";
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Community boilers";
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SAPTableCode = 306;
      }
      else if (num == 302 || num == 307)
      {
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.HGroup = "Community heating schemes";
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.InforSource = "SAP Tables";
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Community CHP";
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SAPTableCode = 307;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.HeatDSystem = "Piping<=1990, pre-insulated, low temp, full flow";
      }
      else
      {
        switch (num)
        {
          case 308:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.HGroup = "Community heating schemes";
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.InforSource = "SAP Tables";
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Community waste heat from power station";
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SAPTableCode = 308;
            break;
          case 309:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.HGroup = "Community heating schemes";
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.InforSource = "SAP Tables";
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Community heat pump";
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SAPTableCode = 309;
            break;
          case 310:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.HGroup = "Community heating schemes";
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.InforSource = "SAP Tables";
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Community geothermal heat source";
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SAPTableCode = 310;
            break;
          default:
            if (num >= 401 && num <= 409)
            {
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.HGroup = "Electric storage systems";
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SGroup = "Off-peak tariffs";
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.BSubGroup = "";
              switch (System)
              {
                case 401:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Old (large volume) storage heaters";
                  return;
                case 402:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Modern (slimline) storage heaters";
                  return;
                case 403:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Convector storage heaters";
                  return;
                case 404:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Fan storage heaters";
                  return;
                case 405:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Modern (slimline) storage heaters With Celect-type control";
                  return;
                case 406:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Convector storage heaters With Celect-type control";
                  return;
                case 407:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Fan storage heaters With Celect-type control";
                  return;
                case 408:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Integrated storage+direct-acting heater";
                  return;
                case 409:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "High heat retention storage heaters";
                  return;
                default:
                  return;
              }
            }
            else if (num >= 421 && num <= 425)
            {
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.HGroup = "Electric underfloor heating";
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.BSubGroup = "";
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MainEff = 100f;
              switch (System)
              {
                case 421:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "In concrete slab (off-peak only)";
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SGroup = "Off-peak tariffs";
                  return;
                case 422:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Integrated (storage+direct-acting)";
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SGroup = "Off-peak tariffs";
                  return;
                case 423:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Integrated (storage+direct-acting) With low (off-peak) tariff control";
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SGroup = "Standard tariff";
                  return;
                case 424:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "In screed above insulation";
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SGroup = "Standard tariff";
                  return;
                case 425:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "In timber floor, or immediately below floor covering";
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SGroup = "Standard tariff";
                  return;
                default:
                  return;
              }
            }
            else if (num >= 501 && num <= 505 || num == 520)
            {
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.HGroup = "Warm air systems (Not heat pump)";
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SGroup = "Gas-fired warm air With fan-assisted flue";
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.BSubGroup = "";
              switch (System)
              {
                case 501:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Ducted, On-off control, pre 1998";
                  return;
                case 502:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Ducted, On-off control, 1998 or later";
                  return;
                case 503:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Ducted, modulating control, pre 1998";
                  return;
                case 504:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Ducted, modulating control, 1998 or later";
                  return;
                case 505:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Roomheater With In-floor ducts";
                  return;
                case 520:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Condensing";
                  return;
                default:
                  return;
              }
            }
            else if (num >= 506 && num <= 511)
            {
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.HGroup = "Warm air systems (Not heat pump)";
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SGroup = "Gas fired warm air With balanced or open flue";
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.BSubGroup = "";
              switch (System)
              {
                case 506:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Ducted Or stub-ducted, On-off control, pre 1998";
                  return;
                case 507:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Ducted Or stub-ducted, On-off control, 1998 Or later";
                  return;
                case 508:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Ducted Or stub-ducted, modulating control, pre 1998";
                  return;
                case 509:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Ducted Or stub-ducted, modulating control, 1998 or later";
                  return;
                case 510:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Ducted Or stub-ducted With flue heat recovery";
                  return;
                case 511:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Condensing";
                  return;
                default:
                  return;
              }
            }
            else if (num >= 512 && num <= 515)
            {
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.HGroup = "Warm air systems (Not heat pump)";
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SGroup = "Oil-fired warm air";
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.BSubGroup = "";
              switch (System)
              {
                case 512:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Ducted output (On/off control)";
                  return;
                case 513:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Ducted output (modulating control)";
                  return;
                case 514:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Stub duct system";
                  return;
                case 515:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SGroup = "Electric warm air";
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.BSubGroup = "";
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Electricaire system";
                  return;
                default:
                  return;
              }
            }
            else if (num >= 521 && num <= 527)
            {
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.HGroup = "Heat pumps With warm air distribution";
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.BSubGroup = "";
              switch (System)
              {
                case 521:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Ground source heat pump";
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SGroup = "Electric heat pumps";
                  return;
                case 522:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Ground source heat pump";
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SGroup = "Electric heat pumps";
                  return;
                case 523:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Water source heat pump";
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SGroup = "Electric heat pumps";
                  return;
                case 524:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Air source heat pump";
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SGroup = "Electric heat pumps";
                  return;
                case 525:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Ground source heat pump";
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SGroup = "Gas-fired heat pumps";
                  return;
                case 526:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Water source heat pump";
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SGroup = "Gas-fired heat pumps";
                  return;
                case 527:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Air source heat pump";
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SGroup = "Gas-fired heat pumps";
                  return;
                default:
                  return;
              }
            }
            else if (num >= 601 && num <= 613)
            {
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.HGroup = "Room heaters";
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SGroup = "Gas (including LPG) room heaters";
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.BSubGroup = "";
              switch (System)
              {
                case 601:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MainEff = 50f;
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Gas fire, open flue, pre-1980 (open fronted)";
                  return;
                case 602:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MainEff = 50f;
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Gas fire, open flue, pre-1980 (open fronted), With back boiler unit";
                  return;
                case 603:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MainEff = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Fuel, "mains gas", false) != 0 ? 64f : 63f;
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Gas fire, open flue, 1980 or later(open fronted), sitting proud Of, And sealed To, fireplace opening";
                  return;
                case 604:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MainEff = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Fuel, "mains gas", false) != 0 ? 64f : 63f;
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Gas fire, open flue, 1980 or later(open fronted), sitting proud Of, And sealed To, fireplace opening, With back boiler unit";
                  return;
                case 605:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MainEff = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Fuel, "mains gas", false) != 0 ? 41f : 40f;
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Flush fitting Live Fuel Effect gas fire (open fronted), sealed To fireplace opening";
                  return;
                case 606:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MainEff = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Fuel, "mains gas", false) != 0 ? 41f : 40f;
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Flush fitting Live Fuel Effect gas fire (open fronted), sealed To fireplace opening, With back boiler unit";
                  return;
                case 607:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MainEff = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Fuel, "mains gas", false) != 0 ? 46f : 45f;
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Flush fitting Live Fuel Effect gas fire (open fronted), fan assisted, sealed To fireplace opening";
                  return;
                case 608:
                  return;
                case 609:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MainEff = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Fuel, "mains gas", false) != 0 ? 60f : 58f;
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Gas fire or wall heater, balanced flue";
                  return;
                case 610:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MainEff = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Fuel, "mains gas", false) != 0 ? 73f : 72f;
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Gas fire, closed fronted, fan assisted";
                  return;
                case 611:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MainEff = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Fuel, "mains gas", false) != 0 ? 85f : 85f;
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Condensing gas fire";
                  return;
                case 612:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MainEff = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Fuel, "mains gas", false) != 0 ? 20f : 20f;
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Decorative Fuel Effect gas fire, open To chimney";
                  return;
                case 613:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MainEff = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Fuel, "mains gas", false) != 0 ? 92f : 90f;
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Flueless gas fire, secondary heating only";
                  return;
                default:
                  return;
              }
            }
            else if (num >= 621 && num <= 625)
            {
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.HGroup = "Room heaters";
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SGroup = "Oil room heaters";
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.BSubGroup = "";
              switch (System)
              {
                case 621:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MainEff = 55f;
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Room heater, pre 2000";
                  return;
                case 622:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MainEff = 65f;
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Room heater, pre 2000, With boiler (no radiators)";
                  return;
                case 623:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MainEff = 60f;
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Room heater, 2000 or later";
                  return;
                case 624:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MainEff = 70f;
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Room heater, 2000 or later With boiler (no radiators)";
                  return;
                case 625:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MainEff = 94f;
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Bioethanol heater, secondary heating only";
                  return;
                default:
                  return;
              }
            }
            else if (num >= 631 && num <= 636)
            {
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.HGroup = "Room heaters";
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SGroup = "Solid fuel room heaters";
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.HETAS = "No";
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.BSubGroup = "";
              switch (System)
              {
                case 631:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MainEff = 32f;
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Open fire In grate";
                  return;
                case 632:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MainEff = 50f;
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Open fire With back boiler (no radiators)";
                  return;
                case 633:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MainEff = 60f;
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Closed room heater";
                  return;
                case 634:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MainEff = 65f;
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Closed room heater With boiler (no radiators)";
                  return;
                case 635:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MainEff = 63f;
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Stove (pellet fired)";
                  return;
                case 636:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MainEff = 63f;
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Stove (pellet fired) With boiler (no radiators)";
                  return;
                default:
                  return;
              }
            }
            else if (num >= 691 && num <= 694)
            {
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.HGroup = "Room heaters";
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SGroup = "Electric (direct acting) room heaters";
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.BSubGroup = "";
              switch (System)
              {
                case 691:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Panel, convector or radiant heaters";
                  return;
                case 692:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Fan heaters";
                  return;
                case 693:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Portable electric heaters";
                  return;
                case 694:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Water- or oil-filled radiators";
                  return;
                default:
                  return;
              }
            }
            else
            {
              if (num == 699 || num != 701)
                break;
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.HGroup = "Other space heating systems";
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = "Electric ceiling heating";
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.BSubGroup = "";
              break;
            }
        }
      }
    }

    private static void NHERSAPConverstion_MainHeating2(int System)
    {
      int num = System;
      if (num >= 101 && num <= 109)
      {
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.HGroup = "Boiler systems with radiators or underfloor heating";
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SGroup = "Gas boilers And oil boilers";
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.BSubGroup = "Gas boilers (including LPG) 1998 or later";
        switch (System)
        {
          case 101:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Regular non-condensing With automatic ignition";
            break;
          case 102:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Regular condensing With automatic ignition";
            break;
          case 103:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Non-condensing combi With automatic ignition";
            break;
          case 104:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Condensing combi With automatic ignition";
            break;
          case 105:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Regular non-condensing With permanent pilot light";
            break;
          case 107:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Non-condensing combi With permanent pilot light";
            break;
          case 109:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Back boiler To radiators";
            break;
        }
      }
      else if (num >= 110 && num <= 114)
      {
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.HGroup = "Boiler systems with radiators or underfloor heating";
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SGroup = "Gas boilers And oil boilers";
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.BSubGroup = "Gas boilers (including LPG) pre-1998, With fan-assisted flue";
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.Boiler.PumpHP = "Yes";
        switch (System)
        {
          case 111:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Regular, high or unknown thermal capacity";
            break;
          case 112:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Combi";
            break;
          case 113:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Condensing combi";
            break;
          case 114:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Regular, condensing";
            break;
        }
      }
      else if (num >= 115 && num <= 119)
      {
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.HGroup = "Boiler systems with radiators or underfloor heating";
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SGroup = "Gas boilers And oil boilers";
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.BSubGroup = "Gas boilers (including LPG) pre-1998, With balanced or open flue";
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.Boiler.FlueType = "Open";
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.Boiler.PumpHP = "Yes";
        switch (System)
        {
          case 115:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Regular, wall mounted";
            break;
          case 116:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Regular, floor mounted, pre 1979";
            break;
          case 117:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Regular, floor mounted, 1979 To 1997";
            break;
          case 118:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Combi";
            break;
          case 119:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Back boiler To radiators";
            break;
        }
      }
      else if (num >= 120 && num <= 123)
      {
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.HGroup = "Boiler systems with radiators or underfloor heating";
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SGroup = "Gas boilers And oil boilers";
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.BSubGroup = "Combined Primary Storage Units (CPSU) (mains gas And LPG)";
        switch (System)
        {
          case 120:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "With automatic ignition (non-condensing)";
            break;
          case 121:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "With automatic ignition (condensing)";
            break;
        }
      }
      else if (num >= 124 && num <= 132)
      {
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.HGroup = "Boiler systems with radiators Or underfloor heating";
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SGroup = "Gas boilers And oil boilers";
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.BSubGroup = "Oil boilers";
        switch (System)
        {
          case 125:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Standard oil boiler 1985 To 1997";
            break;
          case 126:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Standard oil boiler, 1998 or later";
            break;
          case (int) sbyte.MaxValue:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Condensing";
            break;
          case 128:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Combi, pre-1998";
            break;
          case 129:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Combi, 1998 or later";
            break;
          case 130:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Condensing combi";
            break;
          case 131:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Oil room heater With boiler To radiators, pre 2000";
            break;
          case 132:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Oil room heater With boiler To radiators, 2000 or later";
            break;
        }
      }
      else if (num >= 133 && num <= 138)
      {
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.HGroup = "Boiler systems with radiators or underfloor heating";
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SGroup = "Gas boilers And oil boilers";
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.BSubGroup = "Range cooker boilers (mains gas And LPG)";
        switch (System)
        {
          case 133:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Single burner With permanent pilot";
            break;
          case 134:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Single burner With automatic ignition";
            break;
          case 136:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Twin burner With automatic ignition (non-condensing) pre 1998";
            break;
        }
      }
      else if (num >= 139 && num <= 140)
      {
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.HGroup = "Boiler systems with radiators or underfloor heating";
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SGroup = "Gas boilers And oil boilers";
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.BSubGroup = "Range cooker boilers (oil)";
        switch (System)
        {
          case 139:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Single burner";
            break;
          case 140:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Twin burner (non-condensing) pre 1998";
            break;
        }
      }
      else if (num >= 151 && num <= 161)
      {
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.HGroup = "Boiler systems with radiators or underfloor heating";
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SGroup = "Solid fuel boilers";
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.BSubGroup = "";
        switch (System)
        {
          case 151:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Manual feed independent boiler In heated space";
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MainEff = 60f;
            break;
          case 152:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Manual feed independent boiler In unheated space";
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MainEff = 55f;
            break;
          case 153:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Auto (gravity) feed independent boiler In heated space";
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MainEff = 65f;
            break;
          case 154:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Auto (gravity) feed independent boiler In unheated space";
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MainEff = 60f;
            break;
          case 155:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Wood chip/pellet independent boiler";
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MainEff = 63f;
            break;
          case 156:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Open fire With back boiler To radiators";
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MainEff = 55f;
            break;
          case 158:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Closed roomheater With boiler To radiators";
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MainEff = 65f;
            break;
          case 159:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Closed roomheater With boiler To radiators";
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MainEff = 63f;
            break;
          case 160:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Range cooker boiler (integral oven And boiler)";
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MainEff = 45f;
            break;
        }
      }
      else if (num >= 191 && num <= 195)
      {
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.HGroup = "Boiler systems with radiators or underfloor heating";
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SGroup = "Electric boilers";
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.BSubGroup = "";
        switch (System)
        {
          case 191:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Direct acting electric boiler";
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MainEff = 100f;
            break;
          case 192:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Electric CPSU";
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MainEff = 100f;
            break;
          case 193:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Electric dry core storage boiler";
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MainEff = 100f;
            break;
          case 195:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Electric water storage boiler";
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MainEff = 100f;
            break;
          case 196:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Boiler systems with radiators or underfloor heating";
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MainEff = 85f;
            break;
        }
      }
      else if (num >= 201 && num <= 204 || num == 211 || num == 213 || num == 214 || num == 221 || num == 223 || num == 224)
      {
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.HGroup = "Heat pumps With radiators or underfloor heating";
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SGroup = "Electric heat pumps";
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.BSubGroup = "";
        switch (System)
        {
          case 203:
          case 213:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Water source heat pump With flow temperature <= 35°C";
            break;
          case 204:
          case 214:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Air source heat pump With flow temperature <= 35°C";
            break;
          case 211:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Ground source heat pump With flow temperature <= 35°C";
            break;
          case 221:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Ground source heat pump In other cases";
            break;
          case 223:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Water source heat pump, In other cases";
            break;
          case 224:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Air source heat pump In other Case";
            break;
        }
      }
      else if (num == 215 || num == 216 || num == 217 || num == 225 || num == 226 || num == 227)
      {
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.HGroup = "Heat pumps With radiators or underfloor heating";
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SGroup = "Gas-fired heat pumps";
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.BSubGroup = "";
        switch (System)
        {
          case 215:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Ground source heat pump With flow temperature <= 35°C";
            break;
          case 216:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Water source heat pump With flow temperature <= 35°C";
            break;
          case 217:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Air source heat pump With flow temperature <= 35°C";
            break;
          case 225:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Ground source heat pump In other cases";
            break;
          case 226:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Water source heat pump, In other cases";
            break;
          case 227:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Air source heat pump In other Case";
            break;
        }
      }
      else if (num == 301 || num == 306)
      {
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.HGroup = "Community heating schemes";
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.InforSource = "SAP Tables";
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Community boilers";
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SAPTableCode = 306;
      }
      else if (num == 302 || num == 307)
      {
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.HGroup = "Community heating schemes";
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.InforSource = "SAP Tables";
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Community CHP";
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SAPTableCode = 307;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.CommunityH.HeatDSystem = "Piping<=1990, pre-insulated, low temp, full flow";
      }
      else
      {
        switch (num)
        {
          case 308:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.HGroup = "Community heating schemes";
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.InforSource = "SAP Tables";
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Community waste heat from power station";
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SAPTableCode = 308;
            break;
          case 309:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.HGroup = "Community heating schemes";
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.InforSource = "SAP Tables";
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Community heat pump";
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SAPTableCode = 309;
            break;
          case 310:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.HGroup = "Community heating schemes";
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.InforSource = "SAP Tables";
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Community geothermal heat source";
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SAPTableCode = 310;
            break;
          default:
            if (num >= 401 && num <= 409)
            {
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.HGroup = "Electric storage systems";
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SGroup = "Off-peak tariffs";
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.BSubGroup = "";
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MainEff = 100f;
              switch (System)
              {
                case 401:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Old (large volume) storage heaters";
                  return;
                case 402:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Modern (slimline) storage heaters";
                  return;
                case 403:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Convector storage heaters";
                  return;
                case 404:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Fan storage heaters";
                  return;
                case 405:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Modern (slimline) storage heaters With Celect-type control";
                  return;
                case 406:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Convector storage heaters With Celect-type control";
                  return;
                case 407:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Fan storage heaters With Celect-type control";
                  return;
                case 408:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Integrated storage+direct-acting heater";
                  return;
                case 409:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "High heat retention storage heaters";
                  return;
                default:
                  return;
              }
            }
            else if (num >= 421 && num <= 425)
            {
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.HGroup = "Electric underfloor heating";
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.BSubGroup = "";
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MainEff = 100f;
              switch (System)
              {
                case 421:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "In concrete slab (off-peak only)";
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SGroup = "Off-peak tariffs";
                  return;
                case 422:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Integrated (storage+direct-acting)";
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SGroup = "Off-peak tariffs";
                  return;
                case 423:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Integrated (storage+direct-acting) With low (off-peak) tariff control";
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SGroup = "Standard tariff";
                  return;
                case 424:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "In screed above insulation";
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SGroup = "Standard tariff";
                  return;
                case 425:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "In timber floor, or immediately below floor covering";
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SGroup = "Standard tariff";
                  return;
                default:
                  return;
              }
            }
            else if (num >= 501 && num <= 505 || num == 520)
            {
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.HGroup = "Warm air systems (Not heat pump)";
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SGroup = "Gas-fired warm air With fan-assisted flue";
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.BSubGroup = "";
              switch (System)
              {
                case 501:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Ducted, On-off control, pre 1998";
                  return;
                case 502:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Ducted, On-off control, 1998 or later";
                  return;
                case 503:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Ducted, modulating control, pre 1998";
                  return;
                case 504:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Ducted, modulating control, 1998 or later";
                  return;
                case 505:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Roomheater With In-floor ducts";
                  return;
                case 520:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Condensing";
                  return;
                default:
                  return;
              }
            }
            else if (num >= 506 && num <= 511)
            {
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.HGroup = "Warm air systems (Not heat pump)";
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SGroup = "Gas fired warm air With balanced Or open flue";
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.BSubGroup = "";
              switch (System)
              {
                case 506:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Ducted or stub-ducted, On-off control, pre 1998";
                  return;
                case 507:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Ducted or stub-ducted, On-off control, 1998 or later";
                  return;
                case 508:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Ducted or stub-ducted, modulating control, pre 1998";
                  return;
                case 509:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Ducted or stub-ducted, modulating control, 1998 or later";
                  return;
                case 510:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Ducted or stub-ducted With flue heat recovery";
                  return;
                case 511:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Condensing";
                  return;
                default:
                  return;
              }
            }
            else if (num >= 512 && num <= 515)
            {
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.HGroup = "Warm air systems (Not heat pump)";
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SGroup = "Oil-fired warm air";
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.BSubGroup = "";
              switch (System)
              {
                case 512:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Ducted output (On/off control)";
                  return;
                case 513:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Ducted output (modulating control)";
                  return;
                case 514:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Stub duct system";
                  return;
                case 515:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SGroup = "Electric warm air";
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.BSubGroup = "";
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Electricaire system";
                  return;
                default:
                  return;
              }
            }
            else if (num >= 521 && num <= 527)
            {
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.HGroup = "Heat pumps With warm air distribution";
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.BSubGroup = "";
              switch (System)
              {
                case 521:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Ground source heat pump";
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SGroup = "Electric heat pumps";
                  return;
                case 522:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Ground source heat pump";
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SGroup = "Electric heat pumps";
                  return;
                case 523:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Water source heat pump";
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SGroup = "Electric heat pumps";
                  return;
                case 524:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Air source heat pump";
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SGroup = "Electric heat pumps";
                  return;
                case 525:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Ground source heat pump";
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SGroup = "Gas-fired heat pumps";
                  return;
                case 526:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Water source heat pump";
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SGroup = "Gas-fired heat pumps";
                  return;
                case 527:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Air source heat pump";
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SGroup = "Gas-fired heat pumps";
                  return;
                default:
                  return;
              }
            }
            else if (num >= 601 && num <= 613)
            {
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.HGroup = "Room heaters";
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SGroup = "Gas (including LPG) room heaters";
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.BSubGroup = "";
              switch (System)
              {
                case 601:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MainEff = 50f;
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Gas fire, open flue, pre-1980 (open fronted)";
                  return;
                case 602:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MainEff = 50f;
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Gas fire, open flue, pre-1980 (open fronted), With back boiler unit";
                  return;
                case 603:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MainEff = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.Fuel, "mains gas", false) != 0 ? 64f : 63f;
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Gas fire, open flue, 1980 or later(open fronted), sitting proud Of, And sealed To, fireplace opening";
                  return;
                case 604:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MainEff = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.Fuel, "mains gas", false) != 0 ? 64f : 63f;
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Gas fire, open flue, 1980 or later(open fronted), sitting proud Of, And sealed To, fireplace opening, With back boiler unit";
                  return;
                case 605:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MainEff = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.Fuel, "mains gas", false) != 0 ? 41f : 40f;
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Flush fitting Live Fuel Effect gas fire (open fronted), sealed To fireplace opening";
                  return;
                case 606:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MainEff = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.Fuel, "mains gas", false) != 0 ? 41f : 40f;
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Flush fitting Live Fuel Effect gas fire (open fronted), sealed To fireplace opening, With back boiler unit";
                  return;
                case 607:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MainEff = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.Fuel, "mains gas", false) != 0 ? 46f : 45f;
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Flush fitting Live Fuel Effect gas fire (open fronted), fan assisted, sealed To fireplace opening";
                  return;
                case 608:
                  return;
                case 609:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MainEff = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.Fuel, "mains gas", false) != 0 ? 60f : 58f;
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Gas fire Or wall heater, balanced flue";
                  return;
                case 610:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MainEff = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.Fuel, "mains gas", false) != 0 ? 73f : 72f;
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Gas fire, closed fronted, fan assisted";
                  return;
                case 611:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MainEff = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.Fuel, "mains gas", false) != 0 ? 85f : 85f;
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Condensing gas fire";
                  return;
                case 612:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MainEff = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.Fuel, "mains gas", false) != 0 ? 20f : 20f;
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Decorative Fuel Effect gas fire, open To chimney";
                  return;
                case 613:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MainEff = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.Fuel, "mains gas", false) != 0 ? 92f : 90f;
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Flueless gas fire, secondary heating only";
                  return;
                default:
                  return;
              }
            }
            else if (num >= 621 && num <= 625)
            {
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.HGroup = "Room heaters";
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SGroup = "Oil room heaters";
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.BSubGroup = "";
              switch (System)
              {
                case 621:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MainEff = 55f;
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Room heater, pre 2000";
                  return;
                case 622:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MainEff = 65f;
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Room heater, pre 2000, With boiler (no radiators)";
                  return;
                case 623:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MainEff = 60f;
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Room heater, 2000 Or later";
                  return;
                case 624:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MainEff = 70f;
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Room heater, 2000 Or later With boiler (no radiators)";
                  return;
                case 625:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MainEff = 94f;
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Bioethanol heater, secondary heating only";
                  return;
                default:
                  return;
              }
            }
            else if (num >= 631 && num <= 636)
            {
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.HGroup = "Room heaters";
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SGroup = "Solid fuel room heaters";
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.HETAS = "No";
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.BSubGroup = "";
              switch (System)
              {
                case 631:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MainEff = 32f;
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Open fire In grate";
                  return;
                case 632:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MainEff = 50f;
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Open fire With back boiler (no radiators)";
                  return;
                case 633:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MainEff = 60f;
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Closed room heater";
                  return;
                case 634:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MainEff = 65f;
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Closed room heater With boiler (no radiators)";
                  return;
                case 635:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MainEff = 63f;
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Stove (pellet fired)";
                  return;
                case 636:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MainEff = 63f;
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Stove (pellet fired) With boiler (no radiators)";
                  return;
                default:
                  return;
              }
            }
            else if (num >= 691 && num <= 694)
            {
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.HGroup = "Room heaters";
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SGroup = "Electric (direct acting) room heaters";
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.BSubGroup = "";
              switch (System)
              {
                case 691:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Panel, convector or radiant heaters";
                  return;
                case 692:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Fan heaters";
                  return;
                case 693:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Portable electric heaters";
                  return;
                case 694:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Water- or oil-filled radiators";
                  return;
                default:
                  return;
              }
            }
            else
            {
              if (num == 699 || num != 701)
                break;
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.HGroup = "Other space heating systems";
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = "Electric ceiling heating";
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.BSubGroup = "";
              break;
            }
        }
      }
    }

    private static void NHER_Other()
    {
      if (OtherCompanies.NHERDataSet.Tables["Other"].Rows.Count <= 0)
        return;
      int num = checked (OtherCompanies.NHERDataSet.Tables["Other"].Rows.Count - 1);
      int index = 0;
      while (index <= num)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(OtherCompanies.NHERDataSet.Tables["Other"].Rows[index]["TotalThermalBridges"], (object) -1, false))
        {
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.Reference = Conversions.ToString(OtherCompanies.NHERDataSet.Tables["Other"].Rows[index]["YValueDescription"]);
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.YValue = Conversions.ToSingle(OtherCompanies.NHERDataSet.Tables["Other"].Rows[index]["YValue"]);
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.ManualY = true;
        }
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].TMP.UserDefined = Conversions.ToSingle(OtherCompanies.NHERDataSet.Tables["Other"].Rows[index]["ThermalMassParameter"]);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].TMP.Type = "User Value";
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].LELOutlets = checked ((int) Math.Round(unchecked (Conversion.Val(RuntimeHelpers.GetObjectValue(OtherCompanies.NHERDataSet.Tables["Other"].Rows[index]["LELOutlets"])) + Conversion.Val(RuntimeHelpers.GetObjectValue(OtherCompanies.NHERDataSet.Tables["Other"].Rows[index]["StandardOutlets"])))));
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].LELLights = Conversions.ToInteger(OtherCompanies.NHERDataSet.Tables["Other"].Rows[index]["LELOutlets"]);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].LowEnergyLight = (float) Math.Round((double) checked (100 * SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].LELLights) / (double) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].LELOutlets);
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(OtherCompanies.NHERDataSet.Tables["Other"].Rows[index]["HasSpecialFeatures"], (object) 1, false))
        {
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Include = true;
          OtherCompanies.SpecialFeature();
        }
        checked { ++index; }
      }
    }

    private static void SpecialFeature()
    {
      // ISSUE: variable of a reference type
      SAP_Module.SpecialFeatures[]& local;
      // ISSUE: explicit reference operation
      SAP_Module.SpecialFeatures[] specialFeaturesArray = (SAP_Module.SpecialFeatures[]) Utils.CopyArray((Array) ^(local = ref SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special), (Array) new SAP_Module.SpecialFeatures[1]);
      local = specialFeaturesArray;
      int num = checked (OtherCompanies.NHERDataSet.Tables[nameof (SpecialFeature)].Rows.Count - 1);
      int index = 0;
      while (index <= num)
      {
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special[index].Description = Conversions.ToString(OtherCompanies.NHERDataSet.Tables[nameof (SpecialFeature)].Rows[index]["description"]);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special[index].EnergySaved = Conversions.ToSingle(OtherCompanies.NHERDataSet.Tables[nameof (SpecialFeature)].Rows[index]["energysaved"]);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special[index].EnergyUsed = Conversions.ToSingle(OtherCompanies.NHERDataSet.Tables[nameof (SpecialFeature)].Rows[index]["energyused"]);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special[index].FuelSaved = SAP_Module.FuelCheck(Conversions.ToInteger(OtherCompanies.NHERDataSet.Tables[nameof (SpecialFeature)].Rows[index]["energySavedFuel"]));
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special[index].FuelUsed = SAP_Module.FuelCheck(Conversions.ToInteger(OtherCompanies.NHERDataSet.Tables[nameof (SpecialFeature)].Rows[index]["energyUsedFuel"]));
        checked { ++index; }
      }
    }

    private static string WaterDescription(int Value)
    {
      string str;
      switch (Value)
      {
        case 901:
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.System = "From main heating system";
          goto default;
        case 902:
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.System = "From secondary system";
          goto default;
        case 903:
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.System = "Electric immersion (On-peak or off-peak)";
          goto default;
        case 904:
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.System = "Back boiler (hot water only)";
          goto default;
        case 905:
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.System = "From a circulator built into a gas warm air system, pre 1998";
          goto default;
        case 906:
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.System = "From a circulator built into a gas warm air system, 1998 or later";
          goto default;
        case 907:
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.System = "Single-point gas water heater (instantaneous at point Of use)";
          goto default;
        case 908:
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.System = "Multi-point gas water heater (instantaneous serving several taps)";
          goto default;
        case 909:
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.System = "Electric instantaneous at point Of use";
          goto default;
        case 910:
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.System = "Gas boiler/circulator For water heating only";
          goto default;
        case 911:
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.System = "Oil boiler/circulator For water heating only";
          goto default;
        case 912:
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.System = "Solid fuel boiler/circulator For water heating only";
          goto default;
        case 913:
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.System = "Gas, Single burner With permanent pilot";
          goto default;
        case 914:
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.System = "From second main heating system";
          goto default;
        case 921:
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.System = "Gas, Single burner With automatic ignition";
          goto default;
        case 922:
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.System = "Gas, Single burner With automatic ignition";
          goto default;
        case 923:
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.System = "Gas, twin burner With permanent pilot pre 1998";
          goto default;
        case 924:
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.System = "Gas, twin burner With automatic ignition pre 1998";
          goto default;
        case 925:
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.System = "Gas, twin burner With permanent pilot 1998 or later";
          goto default;
        case 926:
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.System = "Gas, twin burner With automatic ignition 1998 or later";
          goto default;
        case 927:
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.System = "Oil, Single burner";
          goto default;
        case 928:
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.System = "Oil, twin burner pre 1998";
          goto default;
        case 929:
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.System = "Oil, twin burner 1998 or later";
          goto default;
        case 930:
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.System = "Solid fuel, integral oven And boiler";
          goto default;
        case 931:
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.System = "Solid fuel, independent oven And boiler";
          goto default;
        case 941:
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.System = "Electric heat pump For water heating only";
          goto default;
        case 950:
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.System = "From hot-water only community scheme - boilers";
          goto default;
        case 951:
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.System = "From hot-water only community scheme - CHP";
          goto default;
        case 952:
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.System = "From hot-water only community scheme - heat pump";
          str = Conversions.ToString(Value);
          break;
        case 999:
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.System = "No hot water system present - electric immersion assumed";
          goto default;
      }
      return str;
    }

    private static void NHER_WaterHeating()
    {
      int num = checked (OtherCompanies.NHERDataSet.Tables["WaterHeating"].Rows.Count - 1);
      int index = 0;
      while (index <= num && SAP_Module.CurrDwelling != -1)
      {
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].LessThan125Litre = Conversions.ToBoolean(OtherCompanies.NHERDataSet.Tables["WaterHeating"].Rows[index]["ReducedWaterUse"]);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.SystemRef = Conversions.ToInteger(OtherCompanies.NHERDataSet.Tables["WaterHeating"].Rows[index]["WaterHeatingType"]);
        OtherCompanies.WaterDescription(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.SystemRef);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Fuel = SAP_Module.FuelCheck(Conversions.ToInteger(OtherCompanies.NHERDataSet.Tables["WaterHeating"].Rows[index]["Fuel"]));
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(OtherCompanies.NHERDataSet.Tables["WaterHeating"].Rows[index]["SeparatelyTimed"], (object) 1, false))
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.Timed = true;
        object Left1 = OtherCompanies.NHERDataSet.Tables["WaterHeating"].Rows[index]["ImmersionType"];
        if (Conversions.ToBoolean((object) (bool) (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(Left1, (object) 0, false)) ? 1 : (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(Left1, (object) 1, false)) ? 1 : 0))))
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.Immersion = "Single";
        else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left1, (object) 2, false))
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.Immersion = "Dual";
        object Left2 = OtherCompanies.NHERDataSet.Tables["WaterHeating"].Rows[index]["InsulationType"];
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left2, (object) 1, false))
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.Insulation = "Jacket";
        else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left2, (object) 2, false))
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.Insulation = "Factory";
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectNotEqual(OtherCompanies.NHERDataSet.Tables["WaterHeating"].Rows[index]["DeclaredLossFactor"], (object) -1, false))
        {
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.ManuSpecified = true;
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.DeclaredLoss = Conversions.ToSingle(OtherCompanies.NHERDataSet.Tables["WaterHeating"].Rows[index]["DeclaredLossFactor"]);
        }
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectNotEqual(OtherCompanies.NHERDataSet.Tables["WaterHeating"].Rows[index]["SummerImmersion"], (object) -1, false))
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.SummerImmersion = Conversions.ToBoolean(OtherCompanies.NHERDataSet.Tables["WaterHeating"].Rows[index]["SummerImmersion"]);
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectNotEqual(OtherCompanies.NHERDataSet.Tables["WaterHeating"].Rows[index]["CylinderVolume"], (object) -1, false))
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.Volume = Conversions.ToSingle(OtherCompanies.NHERDataSet.Tables["WaterHeating"].Rows[index]["CylinderVolume"]);
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectNotEqual(OtherCompanies.NHERDataSet.Tables["WaterHeating"].Rows[index]["InsulationThickness"], (object) -1, false))
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.InsThick = Conversions.ToSingle(OtherCompanies.NHERDataSet.Tables["WaterHeating"].Rows[index]["InsulationThickness"]);
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(OtherCompanies.NHERDataSet.Tables["WaterHeating"].Rows[index]["Thermostat"], (object) 1, false))
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.Thermostat = true;
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(OtherCompanies.NHERDataSet.Tables["WaterHeating"].Rows[index]["InHeatedSpace"], (object) 1, false))
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.InHeatedSpace = true;
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectNotEqual(OtherCompanies.NHERDataSet.Tables["WaterHeating"].Rows[index]["ThermalStoreshortPipeWork"], (object) -1, false))
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.PipeWorkInsulated = Conversions.ToBoolean(OtherCompanies.NHERDataSet.Tables["WaterHeating"].Rows[index]["ThermalStoreshortPipeWork"]);
        try
        {
          object Left3 = OtherCompanies.NHERDataSet.Tables["WaterHeating"].Rows[index]["PrimaryPipeworkInsulation"];
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left3, (object) 1, false))
          {
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.PipeWorkInsulationType = "First 1m from cylinder insulated";
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.PipeWorkInsulated = true;
          }
          else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left3, (object) 2, false))
          {
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.PipeWorkInsulationType = "All accessible pipework insulated";
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.PipeWorkInsulated = true;
          }
          else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left3, (object) 3, false))
          {
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.PipeWorkInsulationType = "Fully insulated primary pipework";
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.PipeWorkInsulated = true;
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        object Left4 = OtherCompanies.NHERDataSet.Tables["WaterHeating"].Rows[index]["HeatPumpWithImmersion"];
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left4, (object) 0, false))
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.HPImmersion = "No";
        else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left4, (object) 1, false))
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.HPImmersion = "Yes";
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectNotEqual(OtherCompanies.NHERDataSet.Tables["WaterHeating"].Rows[index]["HeatExchangeArea"], (object) -1, false))
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.HPExchanger = Conversions.ToSingle(OtherCompanies.NHERDataSet.Tables["WaterHeating"].Rows[index]["HeatExchangeArea"]);
        object Left5 = OtherCompanies.NHERDataSet.Tables["WaterHeating"].Rows[index]["charging"];
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left5, (object) 1, false))
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.Charging = "Flat Rate Charging";
        else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left5, (object) 2, false))
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.Charging = "Charged Link To Use";
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectNotEqual(OtherCompanies.NHERDataSet.Tables["WaterHeating"].Rows[index]["DistributionLossFactorSpecified"], (object) -1, false))
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.KnownLossFactor = Conversions.ToBoolean(OtherCompanies.NHERDataSet.Tables["WaterHeating"].Rows[index]["DistributionLossFactorSpecified"]);
        object Left6 = OtherCompanies.NHERDataSet.Tables["WaterHeating"].Rows[index]["HeatDistributionSystem"];
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left6, (object) 1, false))
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HDS = "Piping<=1990, Not pre-insulated, medium/high temp, full flow";
        else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left6, (object) 2, false))
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HDS = "Piping<=1990, pre-insulated, low temp, full flow";
        else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left6, (object) 3, false))
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HDS = "Piping>=1991, pre-insulated, medium temp, variable flow";
        else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left6, (object) 4, false))
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HDS = "Piping>=1991, pre-insulated, low temp, variable flow";
        else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left6, (object) 5, false))
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HDS = "Unknown";
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectNotEqual(OtherCompanies.NHERDataSet.Tables["WaterHeating"].Rows[index]["DistributionLossFactor"], (object) -1, false))
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.LossFactor = Conversions.ToSingle(OtherCompanies.NHERDataSet.Tables["WaterHeating"].Rows[index]["DistributionLossFactor"]);
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectNotEqual(OtherCompanies.NHERDataSet.Tables["WaterHeating"].Rows[index]["CylinderInDwelling"], (object) -1, false))
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.CylinderInDwelling = Conversions.ToBoolean(OtherCompanies.NHERDataSet.Tables["WaterHeating"].Rows[index]["CylinderInDwelling"]);
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(OtherCompanies.NHERDataSet.Tables["WaterHeating"].Rows[index]["HasWWHRS"], (object) 1, false))
        {
          OtherCompanies.NHER_WWHRS();
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.WWHRS.TotalRooms = Conversions.ToSingle(OtherCompanies.NHERDataSet.Tables["WaterHeating"].Rows[index]["roomsWithBathShower"]);
        }
        checked { ++index; }
      }
    }

    private static string GetControlText(int Code)
    {
      string controlText = "";
      switch (Code)
      {
        case 2100:
          controlText = "Not applicable (boiler provides DHW only)";
          break;
        case 2101:
          controlText = "No time or thermostatic control of room temperature";
          break;
        case 2102:
          controlText = "Programmer, no room thermostat";
          break;
        case 2103:
          controlText = "Room thermostat only";
          break;
        case 2104:
          controlText = "Programmer and room thermostat";
          break;
        case 2105:
          controlText = "Programmer and at least two room thermostats";
          break;
        case 2106:
          controlText = "Programmer, room thermostat and TRVs";
          break;
        case 2107:
          controlText = "Programmer, TRVs and bypass";
          break;
        case 2108:
          controlText = "Programmer, TRVs and flow switch";
          break;
        case 2109:
          controlText = "Programmer, TRVs and boiler energy manager";
          break;
        case 2110:
          controlText = "Time and temperature zone control by suitable arrangement of plumbing and electrical services";
          break;
        case 2112:
          controlText = "Time and temperature zone control by device in database";
          break;
        case 2201:
          controlText = "No time or thermostatic control of room temperature";
          break;
        case 2202:
          controlText = "Programmer, no room thermostat";
          break;
        case 2203:
          controlText = "Room thermostat only";
          break;
        case 2204:
          controlText = "Programmer and room thermostat";
          break;
        case 2205:
          controlText = "Programmer and at least two room thermostats";
          break;
        case 2206:
          controlText = "Programmer, TRVs and bypass";
          break;
        case 2207:
          controlText = "Time and temperature zone control by suitable arrangement of plumbing and electrical services";
          break;
        case 2208:
          controlText = "Time and temperature zone control by device in database";
          break;
        case 2301:
          controlText = "Flat rate charging, no thermostatic control of room temperature";
          break;
        case 2302:
          controlText = "Flat rate charging, programmer, no room thermostat";
          break;
        case 2303:
          controlText = "Flat rate charging, room thermostat only";
          break;
        case 2304:
          controlText = "Flat rate charging, programmer and room thermostat";
          break;
        case 2305:
          controlText = "Flat rate charging, programmer and TRVs";
          break;
        case 2307:
          controlText = "Flat rate charging, TRVs";
          break;
        case 2308:
          controlText = "Charging system linked to use of community heating, room thermostat only";
          break;
        case 2309:
          controlText = "Charging system linked to use of community heating, programmer and room thermostat";
          break;
        case 2310:
          controlText = "Charging system linked to use of community heating, TRVs";
          break;
        case 2311:
          controlText = "Flat rate charging, programmer and at least two room thermostats";
          break;
        case 2312:
          controlText = "Charging system linked to use of community heating, programmer and at least two room thermostats";
          break;
        case 2401:
          controlText = "Manual charge control";
          break;
        case 2402:
          controlText = "Automatic charge control";
          break;
        case 2403:
          controlText = "Celect-type controls";
          break;
        case 2404:
          controlText = "Controls for high heat retention storage heaters";
          break;
        case 2501:
          controlText = "No thermostatic control of room temperature";
          break;
        case 2502:
          controlText = "Programmer, no room thermostat";
          break;
        case 2503:
          controlText = "Room thermostat only";
          break;
        case 2504:
          controlText = "Programmer and room thermostat";
          break;
        case 2505:
          controlText = "Programmer and at least two room thermostats";
          break;
        case 2506:
          controlText = "Time and temperature zone control";
          break;
        case 2601:
          controlText = "No thermostatic control of room temperature";
          break;
        case 2602:
          controlText = "Appliance thermostats";
          break;
        case 2603:
          controlText = "Programmer and appliance thermostats";
          break;
        case 2604:
          controlText = "Room thermostats only";
          break;
        case 2605:
          controlText = "Programmer and room thermostats";
          break;
        case 2701:
          controlText = "No thermostatic control of room temperature";
          break;
        case 2702:
          controlText = "Programmer, no room thermostat";
          break;
        case 2703:
          controlText = "Room thermostat only";
          break;
        case 2704:
          controlText = "Programmer and room thermostat";
          break;
        case 2705:
          controlText = "Temperature zone control";
          break;
        case 2706:
          controlText = "Time and temperature zone control";
          break;
      }
      return controlText;
    }

    private static void NHER_FGHRS()
    {
      int num = checked (OtherCompanies.NHERDataSet.Tables["FGHRSDetails"].Rows.Count - 1);
      int index = 0;
      while (index <= num)
      {
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.FGHRS.Include = true;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.FGHRS.PV = new SAP_Module.Photovoltaic();
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.FGHRS.PV.PPower = Conversions.ToSingle(OtherCompanies.NHERDataSet.Tables["FGHRSDetails"].Rows[index]["HeatStoreTotalVolume"]);
        checked { ++index; }
      }
    }

    private static void NHER_WWHRS()
    {
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.WWHRS = new SAP_Module.WWHRSSystem();
      if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.WWHRS.Systems != null)
        return;
      int num1 = 0;
      do
      {
        // ISSUE: variable of a reference type
        SAP_Module.WWHRS_Systems[]& local;
        // ISSUE: explicit reference operation
        SAP_Module.WWHRS_Systems[] wwhrsSystemsArray = (SAP_Module.WWHRS_Systems[]) Utils.CopyArray((Array) ^(local = ref SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.WWHRS.Systems), (Array) new SAP_Module.WWHRS_Systems[checked (num1 + 1)]);
        local = wwhrsSystemsArray;
        checked { ++num1; }
      }
      while (num1 <= 1);
      int num2 = checked (OtherCompanies.NHERDataSet.Tables["WWHRS"].Rows.Count - 1);
      int index = 0;
      while (index <= num2)
      {
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.WWHRS.Include = true;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.WWHRS.Systems[index].SystemsRef = Conversions.ToString(OtherCompanies.NHERDataSet.Tables["WWHRS"].Rows[index]["ProductIndex"]);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.WWHRS.Systems[index].WithBath = Conversions.ToInteger(OtherCompanies.NHERDataSet.Tables["WWHRS"].Rows[index]["NumberInroomsWithBath"]);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.WWHRS.Systems[index].WithNoBath = Conversions.ToInteger(OtherCompanies.NHERDataSet.Tables["WWHRS"].Rows[index]["NumberInroomsWithoutBath"]);
        try
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectNotEqual(OtherCompanies.NHERDataSet.Tables["WWHRS"].Rows[index]["StorageVolume"], (object) -1, false))
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.WWHRS.Systems[index].DedicatedStorage = Conversions.ToSingle(OtherCompanies.NHERDataSet.Tables["WWHRS"].Rows[index]["StorageVolume"]);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        checked { ++index; }
      }
    }

    private static void NHER_solarWater()
    {
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Solar = new SAP_Module.SolarWater();
      int num = checked (OtherCompanies.NHERDataSet.Tables["SolarwaterHeating"].Rows.Count - 1);
      int index = 0;
      while (index <= num)
      {
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Solar.Inlcude = true;
        object Left1 = OtherCompanies.NHERDataSet.Tables["SolarwaterHeating"].Rows[index]["CollectorType"];
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Solar.SolarType = !Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left1, (object) 1, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left1, (object) 2, false) ? "Evacuated tube" : "Unglazed") : "Flat plate, glazed";
        object Left2 = OtherCompanies.NHERDataSet.Tables["SolarwaterHeating"].Rows[index]["CollectorOrientation"];
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left2, (object) 1, false))
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Solar.SolarOrientation = "North";
        else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left2, (object) 2, false))
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Solar.SolarOrientation = "NE/NW";
        else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left2, (object) 3, false))
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Solar.SolarOrientation = "E/W";
        else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left2, (object) 4, false))
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Solar.SolarOrientation = "East";
        else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left2, (object) 5, false))
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Solar.SolarOrientation = "SE/SW";
        else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left2, (object) 6, false))
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Solar.SolarOrientation = "SE/SW";
        else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left2, (object) 7, false))
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Solar.SolarOrientation = "NE/NW";
        else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left2, (object) 8, false))
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Solar.SolarOrientation = "NE/NW";
        object Left3 = OtherCompanies.NHERDataSet.Tables["SolarwaterHeating"].Rows[index]["CollectorTilt"];
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Solar.SolarTilt = !Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left3, (object) 0, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left3, (object) 1, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left3, (object) 2, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left3, (object) 3, false) ? "Vertical" : "60°") : "45°") : "30°") : "Horizontal";
        object Left4 = OtherCompanies.NHERDataSet.Tables["SolarwaterHeating"].Rows[index]["Overshading"];
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left4, (object) 1, false))
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Solar.SolarOvershading = "None or Very Little (<20%)";
        else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left4, (object) 2, false))
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Solar.SolarOvershading = "Modest (20% - 60%)";
        else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left4, (object) 3, false))
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Solar.SolarOvershading = "Significant (>60% - 80%)";
        else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left4, (object) 4, false))
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Solar.SolarOvershading = "Heavy (>80%)";
        object Left5 = OtherCompanies.NHERDataSet.Tables["SolarwaterHeating"].Rows[index]["Overshading"];
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left5, (object) 1, false))
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Solar.SolarOvershading = "None or Very Little (<20%)";
        else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left5, (object) 2, false))
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Solar.SolarOvershading = "Modest (20% - 60%)";
        else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left5, (object) 3, false))
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Solar.SolarOvershading = "Significant (>60% - 80%)";
        else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left5, (object) 4, false))
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Solar.SolarOvershading = "Heavy (>80%)";
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Solar.Gross = Conversions.ToBoolean(OtherCompanies.NHERDataSet.Tables["SolarwaterHeating"].Rows[index]["IsAreaGross"]);
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(OtherCompanies.NHERDataSet.Tables["SolarwaterHeating"].Rows[index]["CollectorDataSource"], (object) 1, false))
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Solar.Overide = true;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Solar.SolarArea = Conversions.ToSingle(OtherCompanies.NHERDataSet.Tables["SolarwaterHeating"].Rows[index]["PanelArea"]);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Solar.SolarZero = Conversions.ToSingle(OtherCompanies.NHERDataSet.Tables["SolarwaterHeating"].Rows[index]["CollectorZeroLossEfficiency"]);
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectNotEqual(OtherCompanies.NHERDataSet.Tables["SolarwaterHeating"].Rows[index]["CollectorLinearHeatLossCoefficient"], (object) -1, false))
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Solar.SolarHLoss = Conversions.ToSingle(OtherCompanies.NHERDataSet.Tables["SolarwaterHeating"].Rows[index]["CollectorLinearHeatLossCoefficient"]);
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectNotEqual(OtherCompanies.NHERDataSet.Tables["SolarwaterHeating"].Rows[index]["CollectorSecondHeatLossCoefficient"], (object) -1, false))
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Solar.SolarHLoss2 = Conversions.ToSingle(OtherCompanies.NHERDataSet.Tables["SolarwaterHeating"].Rows[index]["CollectorSecondHeatLossCoefficient"]);
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectNotEqual(OtherCompanies.NHERDataSet.Tables["SolarwaterHeating"].Rows[index]["IsSolarStoreCombined"], (object) 1, false))
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Solar.SolarSeperate = true;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Solar.SolarVolume = Conversions.ToSingle(OtherCompanies.NHERDataSet.Tables["SolarwaterHeating"].Rows[index]["SolarStoreVolume"]);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Solar.Pumped = Conversions.ToBoolean(OtherCompanies.NHERDataSet.Tables["SolarwaterHeating"].Rows[index]["SolarPump"]);
        object Left6 = OtherCompanies.NHERDataSet.Tables["SolarwaterHeating"].Rows[index]["ShowersPresent"];
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left6, (object) 3, false))
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Solar.ShowerType = "Non-electric shower(s) only";
        else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left6, (object) 2, false))
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Solar.ShowerType = "Electric shower(s) only";
        else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left6, (object) 1, false))
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Solar.ShowerType = "Both electric and non-electric showers";
        else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left6, (object) 0, false))
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Solar.ShowerType = "No shower (bath only)";
        checked { ++index; }
      }
    }

    private static void NHER_Cooling()
    {
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Cooling = new SAP_Module.CoolingSystem();
      int num = checked (OtherCompanies.NHERDataSet.Tables["cooling"].Rows.Count - 1);
      int index = 0;
      while (index <= num)
      {
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Cooling.Include = true;
        object Left1 = OtherCompanies.NHERDataSet.Tables["cooling"].Rows[index]["systemtype"];
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left1, (object) 0, false))
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Cooling.SystemType = "Split/multiple systems";
        else if (Conversions.ToBoolean((object) (bool) (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(Left1, (object) 1, false)) ? 1 : (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(Left1, (object) -1, false)) ? 1 : 0))))
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Cooling.SystemType = "Packaged systems";
        object Left2 = OtherCompanies.NHERDataSet.Tables["cooling"].Rows[index]["Control"];
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left2, (object) 0, false))
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Cooling.Compressorcontrol = "Systems with On/Off control";
        else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left2, (object) 1, false))
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Cooling.Compressorcontrol = "Systems with variable speed compressors";
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Cooling.ERR = Conversions.ToSingle(OtherCompanies.NHERDataSet.Tables["cooling"].Rows[index]["EER"]);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Cooling.Cooled_Area = Conversions.ToString(OtherCompanies.NHERDataSet.Tables["cooling"].Rows[index]["cooledarea"]);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Cooling.Description = "New";
        object Left3 = OtherCompanies.NHERDataSet.Tables["cooling"].Rows[index]["EnergyLabelClass"];
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Cooling.Energylabel = !Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left3, (object) 0, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left3, (object) 1, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left3, (object) 2, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left3, (object) 3, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left3, (object) 4, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left3, (object) 5, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left3, (object) 6, false) ? "Unknown" : "G") : "F") : "E") : "D") : "C") : "B") : "A";
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Cooling.ERRMeasuredInclude = !Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(OtherCompanies.NHERDataSet.Tables["cooling"].Rows[index]["Datasource"], (object) 0, false);
        checked { ++index; }
      }
    }

    private static void NHER_SummerOverHeating()
    {
      int num = checked (OtherCompanies.NHERDataSet.Tables["SummerOverHeating"].Rows.Count - 1);
      int index = 0;
      while (index <= num)
      {
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].OverHeating.EACOveride = Conversions.ToBoolean(OtherCompanies.NHERDataSet.Tables["SummerOverHeating"].Rows[index]["UserDefAirChangeRate"]);
        if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].OverHeating.EACOveride)
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].OverHeating.EACAirChange = Conversions.ToSingle(OtherCompanies.NHERDataSet.Tables["SummerOverHeating"].Rows[index]["AirChangeRate"]);
        try
        {
          object Left1 = OtherCompanies.NHERDataSet.Tables["SummerOverHeating"].Rows[index]["CrossVentilation"];
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left1, (object) 0, false))
          {
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].OverHeating.EACBuildType = "Single storey dwelling (bungalow, flat) Cross ventilation possible";
            object Left2 = OtherCompanies.NHERDataSet.Tables["SummerOverHeating"].Rows[index]["WindowVentilation"];
            if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left2, (object) 0, false))
            {
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].OverHeating.EACWindow = "Trickle vents only";
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].OverHeating.EACAirChange = 0.1f;
            }
            else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left2, (object) 1, false))
            {
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].OverHeating.EACWindow = "Windows slightly open (50 mm)";
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].OverHeating.EACAirChange = 0.8f;
            }
            else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left2, (object) 2, false))
            {
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].OverHeating.EACWindow = "Windows open half the time";
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].OverHeating.EACAirChange = 3f;
            }
            else
            {
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].OverHeating.EACWindow = "Windows fully open";
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].OverHeating.EACAirChange = 6f;
            }
          }
          else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left1, (object) 1, false))
          {
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].OverHeating.EACBuildType = "Single storey dwelling (bungalow, flat) Cross ventilation not possible";
            object Left3 = OtherCompanies.NHERDataSet.Tables["SummerOverHeating"].Rows[index]["WindowVentilation"];
            if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left3, (object) 0, false))
            {
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].OverHeating.EACWindow = "Trickle vents only";
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].OverHeating.EACAirChange = 0.1f;
            }
            else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left3, (object) 1, false))
            {
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].OverHeating.EACWindow = "Windows slightly open (50 mm)";
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].OverHeating.EACAirChange = 0.5f;
            }
            else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left3, (object) 2, false))
            {
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].OverHeating.EACWindow = "Windows open half the time";
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].OverHeating.EACAirChange = 2f;
            }
            else
            {
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].OverHeating.EACWindow = "Windows fully open";
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].OverHeating.EACAirChange = 4f;
            }
          }
          else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left1, (object) 2, false))
          {
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].OverHeating.EACBuildType = "Dwelling of two or more storeys windows open upstairs and downstairs Cross ventilation possible";
            object Left4 = OtherCompanies.NHERDataSet.Tables["SummerOverHeating"].Rows[index]["WindowVentilation"];
            if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left4, (object) 0, false))
            {
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].OverHeating.EACWindow = "Trickle vents only";
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].OverHeating.EACAirChange = 0.2f;
            }
            else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left4, (object) 1, false))
            {
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].OverHeating.EACWindow = "Windows slightly open (50 mm)";
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].OverHeating.EACAirChange = 1f;
            }
            else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left4, (object) 2, false))
            {
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].OverHeating.EACWindow = "Windows open half the time";
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].OverHeating.EACAirChange = 4f;
            }
            else
            {
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].OverHeating.EACWindow = "Windows fully open";
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].OverHeating.EACAirChange = 8f;
            }
          }
          else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left1, (object) 3, false))
          {
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].OverHeating.EACBuildType = "Dwelling of two or more storeys windows open upstairs and downstairs Cross ventilation not possible";
            object Left5 = OtherCompanies.NHERDataSet.Tables["SummerOverHeating"].Rows[index]["WindowVentilation"];
            if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left5, (object) 0, false))
            {
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].OverHeating.EACWindow = "Trickle vents only";
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].OverHeating.EACAirChange = 0.1f;
            }
            else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left5, (object) 1, false))
            {
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].OverHeating.EACWindow = "Windows slightly open (50 mm)";
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].OverHeating.EACAirChange = 0.6f;
            }
            else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left5, (object) 2, false))
            {
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].OverHeating.EACWindow = "Windows open half the time";
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].OverHeating.EACAirChange = 2.5f;
            }
            else
            {
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].OverHeating.EACWindow = "Windows fully open";
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].OverHeating.EACAirChange = 5f;
            }
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        checked { ++index; }
      }
    }

    private static void NHER_Heating2(DataRow Newrow)
    {
      DataRow dataRow = Newrow;
      object Left1 = dataRow["EfficiencySource"];
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.InforSource = !Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left1, (object) 1, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left1, (object) 2, false) ? "SAP Tables" : "Manufacturer Declaration") : "Boiler Database";
      object Left2 = dataRow["HeatingType"];
      int num = Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(Left2, (object) 0, false)) ? 1 : (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(Left2, (object) 1, false)) ? 1 : 0);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.HGroup = !Conversions.ToBoolean((object) (bool) num) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left2, (object) 2, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left2, (object) 3, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left2, (object) 4, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left2, (object) 5, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left2, (object) 6, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left2, (object) 7, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left2, (object) 8, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left2, (object) 9, false) ? "No heating system present" : "Other space heating systems") : "Room heaters") : "Warm air systems (Not heat pump)") : "Electric storage systems") : "Community heating schemes") : "Heat pumps with warm air distribution") : "Heat pumps with radiators or underfloor heating") : "Micro-Congeneration (Micro-CHP)") : "Boiler systems with radiators or underfloor heating";
      object Left3 = dataRow["BoilerType"];
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left3, (object) 1, false))
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SGroup = "Gas boilers and oil boilers";
      else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left3, (object) 2, false))
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SGroup = "Boiler systems with radiators or underfloor heating";
      else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left3, (object) 3, false))
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SGroup = "Micro-Congeneration (Micro-CHP)";
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.Fuel = OtherCompanies.FuelCheckNHER(Conversions.ToInteger(dataRow["Fuel"]));
      object Left4 = dataRow["FlueType"];
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left4, (object) 1, false))
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.Boiler.FlueType = "Open";
      else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left4, (object) 2, false))
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.Boiler.FlueType = "Room-sealed";
      else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left4, (object) 3, false))
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.Boiler.FlueType = "Chimney";
      else if (Conversions.ToBoolean((object) (bool) (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(Left4, (object) 0, false)) ? 1 : (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(Left4, (object) 4, false)) ? 1 : 0))))
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.Boiler.FlueType = "Unknown";
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.Boiler.FanFlued = !Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(dataRow["FanFlue"], (object) 1, false) ? "No" : "Yes";
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.ControlCode = Conversions.ToInteger(dataRow["Controls"]);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.Controls = OtherCompanies.GetControlText(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.ControlCode);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.Boiler.BILock = !Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(dataRow["Interlock"], (object) 1, false) ? "No" : "Yes";
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.DelayedStart = Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(dataRow["DelayedStartStat"], (object) 1, false);
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(dataRow["Compensation"], (object) 1, false))
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.Boiler.LoadWeather = true;
      object Left5 = dataRow["BurnerControl"];
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.FuelBurningType = !Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left5, (object) 0, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left5, (object) 1, false) ? "Unknown" : "Modulation") : "On/off";
      object Left6 = dataRow["Emitter"];
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left6, (object) 0, false))
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.Emitter = "Systems with radiators";
      else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left6, (object) 1, false))
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.Emitter = "Underfloor heating, pipes in insulated timber floor";
      else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left6, (object) 2, false))
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.Emitter = "Underfloor heating, pipes in concrete slab";
      else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left6, (object) 3, false))
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.Emitter = "Underfloor heating and radiators, pipes in insulated timber floor";
      else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left6, (object) 4, false))
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.Emitter = "Underfloor heating and radiators, pipes in concrete slab";
      else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left6, (object) 5, false))
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.Emitter = "Underfloor heating, pipes in screed above insulation";
      else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left6, (object) 6, false))
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.Emitter = "Underfloor heating and radiators, pipes in screed above insulation";
      else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left6, (object) 7, false))
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.Emitter = "Fan coil units";
      object Left7 = dataRow["FlowTemp"];
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left7, (object) 4, false))
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.Boiler.FlowTemp = "Design flow temperature<=35°C";
      else
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.FuelBurningType = !Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left7, (object) 3, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left7, (object) 2, false) ? "Unknown" : "Design flow temperature >45°C") : "Design flow temperature<=45°C";
      object Left8 = dataRow["PumpinHeatedSpace"];
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left8, (object) 1, false))
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.Boiler.PumpHP = "Yes";
      else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left8, (object) 0, false))
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.Boiler.PumpHP = "No";
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(dataRow["OilPumpinHeatedSpace"], (object) 1, false))
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.OilPump = true;
      object Left9 = dataRow["Installed2013OrLater"];
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.Boiler.PumpType = !Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left9, (object) 1, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left9, (object) 0, false) ? "Unknown" : "2012 or earlier") : "2013 or later";
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MainEff = Conversions.ToSingle(dataRow["Efficiency"]);
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(dataRow["KeepHotPowerRating"], (object) 1, false))
      {
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.Boiler.KeepHotTimed = true;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.Boiler.KeepHotFuel = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.Fuel;
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(dataRow["KeepHotElec"], (object) 1, false))
      {
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.Boiler.KeepHotTimed = true;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.Boiler.KeepHotFuel = "Electricity";
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(dataRow["MCSInstaller"], (object) 1, false))
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MCSCert = true;
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectGreater(dataRow["CompensationIndex"], (object) 0, false))
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.ControlCodePCDFWeather = Conversions.ToString(dataRow["CompensationIndex"]);
      if (Conversion.Val(RuntimeHelpers.GetObjectValue(dataRow["Productindex"])) > 0.0)
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SEDBUK = Conversions.ToString(dataRow["Productindex"]);
      else
        OtherCompanies.NHERSAPConverstion_MainHeating2(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SAPTableCode);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].HeatFractionSec = Conversions.ToSingle(dataRow["MainHeatingFraction"]);
    }

    private static void NHER_SecondaryHeating()
    {
      int num = checked (OtherCompanies.NHERDataSet.Tables["SecondaryHeating"].Rows.Count - 1);
      int index = 0;
      while (index <= num)
      {
        object Left1 = OtherCompanies.NHERDataSet.Tables["SecondaryHeating"].Rows[index]["FlueType"];
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left1, (object) 1, false))
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].SecHeating.FlueType = "Open";
        else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left1, (object) 2, false))
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].SecHeating.FlueType = "Room-sealed";
        else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left1, (object) 3, false))
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].SecHeating.FlueType = "Chimney";
        else if (Conversions.ToBoolean((object) (bool) (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(Left1, (object) 0, false)) ? 1 : (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(Left1, (object) 4, false)) ? 1 : 0))))
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].SecHeating.FlueType = "Unknown";
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].SecHeating.Fuel = OtherCompanies.FuelCheckNHER(Conversions.ToInteger(OtherCompanies.NHERDataSet.Tables["SecondaryHeating"].Rows[index]["Fuel"]));
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectNotEqual(OtherCompanies.NHERDataSet.Tables["SecondaryHeating"].Rows[index]["TestMethod"], (object) -1, false))
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].SecHeating.TestMethod = Conversions.ToString(OtherCompanies.NHERDataSet.Tables["SecondaryHeating"].Rows[index]["TestMethod"]);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].SecHeating.SecEff = Conversions.ToSingle(OtherCompanies.NHERDataSet.Tables["SecondaryHeating"].Rows[index]["Efficiency"]);
        object Left2 = OtherCompanies.NHERDataSet.Tables["SecondaryHeating"].Rows[index]["HETASAPproved"];
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left2, (object) 1, false))
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].SecHeating.HETAS = "Yes";
        else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left2, (object) 0, false))
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].SecHeating.HETAS = "No";
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].SecHeating.SAPTableCode = Conversions.ToInteger(OtherCompanies.NHERDataSet.Tables["SecondaryHeating"].Rows[index]["system"]);
        int sapTableCode = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].SecHeating.SAPTableCode;
        if (sapTableCode >= 601 && sapTableCode <= 613)
        {
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].SecHeating.HGroup = "Room heaters";
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].SecHeating.SGroup = "Gas (including LPG) room heaters";
        }
        else if (sapTableCode >= 621 && sapTableCode <= 625)
        {
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].SecHeating.HGroup = "Room heaters";
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].SecHeating.SGroup = "Oil room heaters";
        }
        else if (sapTableCode >= 631 && sapTableCode <= 636)
        {
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].SecHeating.HGroup = "Room heaters";
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].SecHeating.SGroup = "Solid fuel room heaters";
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].SecHeating.HETAS = "No";
        }
        else if (sapTableCode >= 691 && sapTableCode <= 694)
        {
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].SecHeating.HGroup = "Room heaters";
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].SecHeating.SGroup = "Electric (direct acting) room heaters";
        }
        switch (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].SecHeating.SAPTableCode)
        {
          case 601:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].SecHeating.MHType = "Gas fire, open flue, pre-1980 (open fronted)";
            break;
          case 602:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].SecHeating.MHType = "Gas fire, open flue, pre-1980 (open fronted), With back boiler unit";
            break;
          case 603:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].SecHeating.MHType = "Gas fire, open flue, 1980 or later(open fronted), sitting proud Of, And sealed To, fireplace opening";
            break;
          case 604:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].SecHeating.MHType = "Gas fire, open flue, 1980 or later(open fronted), sitting proud Of, And sealed To, fireplace opening, With back boiler unit";
            break;
          case 605:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].SecHeating.MHType = "Flush fitting Live Fuel Effect gas fire (open fronted), sealed To fireplace opening";
            break;
          case 606:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].SecHeating.MHType = "Flush fitting Live Fuel Effect gas fire (open fronted), sealed To fireplace opening, With back boiler unit";
            break;
          case 607:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].SecHeating.MHType = "Flush fitting Live Fuel Effect gas fire (open fronted), fan assisted, sealed To fireplace opening";
            break;
          case 609:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].SecHeating.MHType = "Gas fire or wall heater, balanced flue";
            break;
          case 610:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].SecHeating.MHType = "Gas fire, closed fronted, fan assisted";
            break;
          case 611:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].SecHeating.MHType = "Condensing gas fire";
            break;
          case 612:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].SecHeating.MHType = "Decorative Fuel Effect gas fire, open To chimney";
            break;
          case 613:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].SecHeating.MHType = "Flueless gas fire, secondary heating only";
            break;
          case 621:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].SecHeating.MHType = "Room heater, pre 2000";
            break;
          case 622:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].SecHeating.MHType = "Room heater, pre 2000, With boiler (no radiators)";
            break;
          case 623:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].SecHeating.MHType = "Room heater, 2000 or later";
            break;
          case 624:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].SecHeating.MHType = "Room heater, 2000 or later With boiler (no radiators)";
            break;
          case 625:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].SecHeating.MHType = "Bioethanol heater, secondary heating only";
            break;
          case 631:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].SecHeating.MHType = "Open fire In grate";
            break;
          case 632:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].SecHeating.MHType = "Open fire With back boiler (no radiators)";
            break;
          case 633:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].SecHeating.MHType = "Closed room heater";
            break;
          case 634:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].SecHeating.MHType = "Closed room heater With boiler (no radiators)";
            break;
          case 635:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].SecHeating.MHType = "Stove (pellet fired)";
            break;
          case 636:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].SecHeating.MHType = "Stove (pellet fired) With boiler (no radiators)";
            break;
          case 691:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].SecHeating.MHType = "Panel, convector or radiant heaters";
            break;
          case 692:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].SecHeating.MHType = "Fan heaters";
            break;
          case 693:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].SecHeating.MHType = "Portable electric heaters";
            break;
          case 694:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].SecHeating.MHType = "Water- or oil-filled radiators";
            break;
          case 701:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].SecHeating.HGroup = "Other space heating systems";
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].SecHeating.MHType = "Electric ceiling heating";
            break;
        }
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].SecHeating.MDescription = Conversions.ToString(OtherCompanies.NHERDataSet.Tables["SecondaryHeating"].Rows[index]["ManufacturerDescription"]);
        object Left3 = OtherCompanies.NHERDataSet.Tables["SecondaryHeating"].Rows[index]["EfficiencySource"];
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].SecHeating.InforSource = !Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left3, (object) 1, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left3, (object) 2, false) ? "SAP Tables" : "Manufacturer Declaration") : "Boiler Database";
        checked { ++index; }
      }
    }

    private static string FuelCheckNHER(int Fuel)
    {
      string str = "";
      switch (Fuel)
      {
        case 1:
          str = "mains gas";
          break;
        case 2:
          str = "bulk LPG";
          break;
        case 3:
          str = "bottled LPG";
          break;
        case 4:
          str = "heating oil";
          break;
        case 8:
          str = "LNG";
          break;
        case 9:
          str = "LPG subject to Special Condition 18";
          break;
        case 10:
          str = "dual fuel appliance (mineral and wood)";
          break;
        case 11:
          str = "house coal";
          break;
        case 12:
          str = "manufactured smokeless fuel";
          break;
        case 15:
          str = "anthracite";
          break;
        case 20:
          str = "wood logs";
          break;
        case 21:
          str = "wood chips";
          break;
        case 22:
          str = "wood pellets (in bags, for secondary heating)";
          break;
        case 23:
          str = "wood pellets (bulk supply in bags, for main heating)";
          break;
        case 39:
          str = "Electricity";
          break;
        case 41:
          str = "heat from heat pump";
          break;
        case 42:
          str = "heat from boilers - waste combustion";
          break;
        case 43:
          str = "heat from boilers – biomass";
          break;
        case 44:
          str = "heat from boilers – biogas";
          break;
        case 45:
          str = "waste heat from power stations";
          break;
        case 46:
          str = "geothermal heat source";
          break;
        case 51:
          str = "heat from boilers – mains gas";
          break;
        case 52:
          str = "heat from boilers – LPG";
          break;
        case 53:
          str = "heat from boilers – oil";
          break;
        case 54:
          str = "heat from boilers – coal";
          break;
        case 55:
          str = "heat from boilers – B30D";
          break;
        case 71:
          str = "biodiesel from any biomass source";
          break;
        case 72:
          str = "biodiesel from used cooking oil only";
          break;
        case 73:
          str = "rapeseed oil";
          break;
        case 74:
          str = "appliances able to use mineral oil or liquid biofuel";
          break;
        case 75:
          str = "B30K";
          break;
        case 76:
          str = "bioethanol from any biomass source";
          break;
      }
      return str;
    }
  }
}
