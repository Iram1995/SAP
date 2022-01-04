
// Type: SAP2012.Improvements




using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SAP2012
{
  [StandardModule]
  internal sealed class Improvements
  {
    private static float Improvement;
    private static bool filled;
    private static Improvements.Increments Changes = new Improvements.Increments();

    private static void FillImprovementCritera()
    {
      List<PCDF.Table131> table131s1 = SAP_Module.PCDFData.Table131s;
      Func<PCDF.Table131, bool> predicate1;
      // ISSUE: reference to a compiler-generated field
      if (Improvements._Closure\u0024__.\u0024I3\u002D0 != null)
      {
        // ISSUE: reference to a compiler-generated field
        predicate1 = Improvements._Closure\u0024__.\u0024I3\u002D0;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        Improvements._Closure\u0024__.\u0024I3\u002D0 = predicate1 = (Func<PCDF.Table131, bool>) (b => b.Ref.Equals("E"));
      }
      PCDF.Table131 table131_1 = table131s1.Where<PCDF.Table131>(predicate1).SingleOrDefault<PCDF.Table131>();
      float num1;
      float num2;
      if (Conversions.ToDouble(table131_1.Cost_Type) == 1.0)
      {
        num1 = (float) Conversion.Val(table131_1.A_low);
        num2 = (float) Conversion.Val(table131_1.A_High);
      }
      else
      {
        num1 = (float) Conversion.Val(table131_1.B_low);
        num2 = (float) Conversion.Val(table131_1.B_High);
      }
      SAP_Module.Improve.LowerCost.E.GreenDeal.Lower = num1;
      SAP_Module.Improve.LowerCost.E.GreenDeal.Higher = num2;
      SAP_Module.Improve.LowerCost.E.GreenDeal.n = (float) Conversion.Val(table131_1.Lifetime);
      SAP_Module.Improve.LowerCost.E.InUse = (float) Conversion.Val(table131_1.In_use);
      SAP_Module.Improve.LowerCost.E.InUseOA = (float) Conversion.Val(table131_1.In_Use_OA);
      SAP_Module.Improve.LowerCost.E.MinSAP = (float) Conversion.Val(table131_1.min_SAP);
      SAP_Module.Improve.LowerCost.E.GreenDeal.GreenDealCost = (float) Conversion.Val(table131_1.GD_cost);
      List<PCDF.Table131> table131s2 = SAP_Module.PCDFData.Table131s;
      Func<PCDF.Table131, bool> predicate2;
      // ISSUE: reference to a compiler-generated field
      if (Improvements._Closure\u0024__.\u0024I3\u002D1 != null)
      {
        // ISSUE: reference to a compiler-generated field
        predicate2 = Improvements._Closure\u0024__.\u0024I3\u002D1;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        Improvements._Closure\u0024__.\u0024I3\u002D1 = predicate2 = (Func<PCDF.Table131, bool>) (b => b.Ref.Equals("N"));
      }
      PCDF.Table131 table131_2 = table131s2.Where<PCDF.Table131>(predicate2).SingleOrDefault<PCDF.Table131>();
      float num3;
      float num4;
      if (Conversions.ToDouble(table131_2.Cost_Type) == 1.0)
      {
        num3 = (float) Conversion.Val(table131_2.A_low);
        num4 = (float) Conversion.Val(table131_2.A_High);
      }
      else
      {
        num3 = (float) Conversion.Val(table131_2.B_low);
        num4 = (float) Conversion.Val(table131_2.B_High);
      }
      SAP_Module.Improve.Further.N.GreenDeal.Lower = num3;
      SAP_Module.Improve.Further.N.GreenDeal.Higher = num4;
      SAP_Module.Improve.Further.N.GreenDeal.n = (float) Conversion.Val(table131_2.Lifetime);
      SAP_Module.Improve.Further.N.InUse = (float) Conversion.Val(table131_2.In_use);
      SAP_Module.Improve.Further.N.InUseOA = (float) Conversion.Val(table131_2.In_Use_OA);
      SAP_Module.Improve.Further.N.MinSAP = (float) Conversion.Val(table131_2.min_SAP);
      SAP_Module.Improve.Further.N.GreenDeal.GreenDealCost = (float) Conversion.Val(table131_2.GD_cost);
      List<PCDF.Table131> table131s3 = SAP_Module.PCDFData.Table131s;
      Func<PCDF.Table131, bool> predicate3;
      // ISSUE: reference to a compiler-generated field
      if (Improvements._Closure\u0024__.\u0024I3\u002D2 != null)
      {
        // ISSUE: reference to a compiler-generated field
        predicate3 = Improvements._Closure\u0024__.\u0024I3\u002D2;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        Improvements._Closure\u0024__.\u0024I3\u002D2 = predicate3 = (Func<PCDF.Table131, bool>) (b => b.Ref.Equals("U"));
      }
      PCDF.Table131 table131_3 = table131s3.Where<PCDF.Table131>(predicate3).SingleOrDefault<PCDF.Table131>();
      float num5;
      float num6;
      if (Conversions.ToDouble(table131_3.Cost_Type) == 1.0)
      {
        num5 = (float) Conversion.Val(table131_3.A_low);
        num6 = (float) Conversion.Val(table131_3.A_High);
      }
      else
      {
        num5 = (float) Conversion.Val(table131_3.B_low);
        num6 = (float) Conversion.Val(table131_3.B_High);
      }
      SAP_Module.Improve.Further.U.GreenDeal.Lower = num5;
      SAP_Module.Improve.Further.U.GreenDeal.Higher = num6;
      SAP_Module.Improve.Further.U.GreenDeal.n = (float) Conversion.Val(table131_3.Lifetime);
      SAP_Module.Improve.Further.U.InUse = (float) Conversion.Val(table131_3.In_use);
      SAP_Module.Improve.Further.U.InUseOA = (float) Conversion.Val(table131_3.In_Use_OA);
      SAP_Module.Improve.Further.U.MinSAP = (float) Conversion.Val(table131_3.min_SAP);
      SAP_Module.Improve.Further.U.GreenDeal.GreenDealCost = (float) Conversion.Val(table131_3.GD_cost);
      List<PCDF.Table131> table131s4 = SAP_Module.PCDFData.Table131s;
      Func<PCDF.Table131, bool> predicate4;
      // ISSUE: reference to a compiler-generated field
      if (Improvements._Closure\u0024__.\u0024I3\u002D3 != null)
      {
        // ISSUE: reference to a compiler-generated field
        predicate4 = Improvements._Closure\u0024__.\u0024I3\u002D3;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        Improvements._Closure\u0024__.\u0024I3\u002D3 = predicate4 = (Func<PCDF.Table131, bool>) (b => b.Ref.Equals("V2"));
      }
      PCDF.Table131 table131_4 = table131s4.Where<PCDF.Table131>(predicate4).SingleOrDefault<PCDF.Table131>();
      float num7;
      float num8;
      if (Conversions.ToDouble(table131_4.Cost_Type) == 1.0)
      {
        num7 = (float) Conversion.Val(table131_4.A_low);
        num8 = (float) Conversion.Val(table131_4.A_High);
      }
      else
      {
        num7 = (float) Conversion.Val(table131_4.B_low);
        num8 = (float) Conversion.Val(table131_4.B_High);
      }
      SAP_Module.Improve.Further.V2.GreenDeal.Lower = num7;
      SAP_Module.Improve.Further.V2.GreenDeal.Higher = num8;
      SAP_Module.Improve.Further.V2.GreenDeal.n = (float) Conversion.Val(table131_4.Lifetime);
      SAP_Module.Improve.Further.V2.InUse = (float) Conversion.Val(table131_4.In_use);
      SAP_Module.Improve.Further.V2.InUseOA = (float) Conversion.Val(table131_4.In_Use_OA);
      SAP_Module.Improve.Further.V2.MinSAP = (float) Conversion.Val(table131_4.min_SAP);
      SAP_Module.Improve.Further.V2.GreenDeal.GreenDealCost = (float) Conversion.Val(table131_4.GD_cost);
      Improvements.filled = true;
    }

    public static void GetImprovements(SAP_Module.Dwelling House)
    {
      SAP_Module.Improve = new Improvement_Class();
      Improvements.FillImprovementCritera();
      SAP_Module.ImproveDwelling = Functions.CopyDwelling(House);
      bool calcRound = SAP_Module.CalcRound;
      SAP_Module.CalcRound = false;
      SAP_Module.CalculationImprove2012Regional.IsRHICalc = true;
      SAP_Module.CalculationImprove2012Regional.IsHeatDemand = true;
      SAP_Module.CalculationImprove2012Regional.Dwelling = House;
      SAP_Module.CalculationImprove2012.Dwelling = House;
      if (SAP_Module.Calculation2012.Calculation.SAP_rating_11a.Box258 == 0.0)
      {
        Improvements.Changes.SAPChange = SAP_Module.CalculationImprove2012.Calculation.SAP_rating_11b.Box358;
        Improvements.Changes.CostChange = SAP_Module.CalculationImprove2012Regional.Calculation.Actual_costs_10b.Box355;
        Improvements.Changes.CO2Change = SAP_Module.CalculationImprove2012Regional.Calculation.CO2_Emissions_12b.Box383;
      }
      else
      {
        Improvements.Changes.SAPChange = SAP_Module.CalculationImprove2012.Calculation.SAP_rating_11a.Box258;
        Improvements.Changes.CostChange = SAP_Module.CalculationImprove2012Regional.Calculation.Actual_costs_10a.Box255;
        Improvements.Changes.CO2Change = SAP_Module.CalculationImprove2012Regional.Calculation.CO2_Emissions_12a.Box272;
      }
      if ((double) House.LowEnergyLight < 75.0)
      {
        SAP_Module.ImproveDwelling.LowEnergyLight = 100f;
        SAP_Module.CalculationImprove2012.Dwelling = SAP_Module.ImproveDwelling;
        SAP_Module.CalculationImprove2012Regional.Dwelling = SAP_Module.ImproveDwelling;
        SAP_Module.Improve.LowerCost.E.Include = Improvements.Include(0.45f);
        if (SAP_Module.Improve.LowerCost.E.Include)
        {
          SAP_Module.Improve.LowerCost.E.SAPChange = Improvements.SAPPoints();
          SAP_Module.Improve.LowerCost.E.CO2Change = Improvements.CO2Points();
          SAP_Module.Improve.LowerCost.E.CostChange = Improvements.Costs();
          SAP_Module.Improve.LowerCost.E.Energy = Improvements.Energy();
          SAP_Module.Improve.LowerCost.E.Environ = Improvements.Environ();
        }
        else
          SAP_Module.ImproveDwelling.LowEnergyLight = House.LowEnergyLight;
      }
      if (Operators.CompareString(House.PropertyType, nameof (House), false) == 0 | Operators.CompareString(House.PropertyType, "Bungalow", false) == 0)
      {
        if (!House.Water.Solar.Inlcude)
        {
          ref SAP_Module.SolarWater local = ref SAP_Module.ImproveDwelling.Water.Solar;
          local.Inlcude = true;
          local.SolarType = "Evacuated tube";
          local.Gross = false;
          local.SolarArea = 3f;
          local.SolarZero = 0.7f;
          local.SolarHLoss = 1.8f;
          local.SolarHLoss2 = 0.005f;
          local.SolarOrientation = "South";
          local.SolarTilt = "30°";
          local.SolarOvershading = "Modest (20% - 60%)";
          local.Pumped = false;
          local.Overide = true;
          int systemRef = House.Water.SystemRef;
          bool flag;
          if (systemRef == 901)
          {
            if (Operators.CompareString(House.MainHeating.InforSource, "Boiler Database", false) == 0)
            {
              if (Operators.CompareString(House.MainHeating.SGroup, "Gas boilers and oil boilers", false) == 0)
              {
                PCDF.SEDBUK sedbuk = SAP_Module.PCDFData.Boilers.Where<PCDF.SEDBUK>((Func<PCDF.SEDBUK, bool>) (b => b.ID.Equals(House.MainHeating.SEDBUK))).SingleOrDefault<PCDF.SEDBUK>();
                if (sedbuk != null)
                {
                  string mainType = sedbuk.MainType;
                  flag = Operators.CompareString(mainType, Conversions.ToString(2), false) == 0 || Operators.CompareString(mainType, Conversions.ToString(3), false) == 0;
                }
              }
              else
                flag = Operators.CompareString(House.MainHeating.SGroup, "Micro-cogeneration (micro-CHP)", false) != 0 ? Operators.CompareString(House.MainHeating.SGroup, "Solid fuel boilers", false) != 0 && House.MainHeating.SGroup.Contains("heat pumps") : !House.Water.Cylinder.PipeWorkInsulated;
            }
            else if (House.MainHeating.SGroup.Contains("heat pumps"))
            {
              flag = true;
            }
            else
            {
              int sapTableCode = House.MainHeating.SAPTableCode;
              int num;
              switch (sapTableCode)
              {
                case 103:
                case 104:
                case 107:
                case 108:
                case 112:
                case 113:
                case 118:
                case 120:
                case 121:
                case 122:
                case 123:
                case 128:
                case 129:
                case 130:
                  num = 1;
                  break;
                default:
                  num = sapTableCode == 192 ? 1 : 0;
                  break;
              }
              flag = num != 0 || sapTableCode >= 301 && sapTableCode <= 305 && !House.Water.HWSComm.CylinderInDwelling;
            }
          }
          else if (systemRef == 902 || systemRef == 903 || systemRef == 904 || systemRef == 905 || systemRef == 906 || systemRef == 911 || systemRef == 912 || systemRef == 913 || systemRef >= 921 && systemRef <= 931)
            flag = false;
          else if (systemRef == 907 || systemRef == 908 || systemRef == 909)
            flag = true;
          else if (systemRef == 950 || systemRef == 951 || systemRef == 952)
            flag = !House.Water.HWSComm.CylinderInDwelling;
          if (flag)
          {
            local.SolarVolume = 75f;
            local.SolarSeperate = true;
          }
          else
          {
            local.SolarSeperate = false;
            local.SolarVolume = 75f;
            if ((double) SAP_Module.ImproveDwelling.Water.Cylinder.Volume < 190.0)
            {
              if (SAP_Module.ImproveDwelling.Water.Cylinder.ManuSpecified)
                SAP_Module.ImproveDwelling.Water.Cylinder.DeclaredLoss = (float) (190.0 / (double) SAP_Module.ImproveDwelling.Water.Cylinder.Volume * (double) SAP_Module.ImproveDwelling.Water.Cylinder.DeclaredLoss * 0.85797746609968 / Math.Pow(120.0 / (double) SAP_Module.ImproveDwelling.Water.Cylinder.Volume, 1.0 / 3.0));
              SAP_Module.ImproveDwelling.Water.Cylinder.Volume = 190f;
            }
          }
          SAP_Module.ImproveDwelling.Water.Solar.ShowerType = "Both electric and non-electric showers";
          SAP_Module.CalculationImprove2012.Dwelling = SAP_Module.ImproveDwelling;
          SAP_Module.CalculationImprove2012Regional.Dwelling = SAP_Module.ImproveDwelling;
          SAP_Module.Improve.Further.N.Include = Improvements.Include(0.95f);
          if (SAP_Module.Improve.Further.N.Include)
          {
            SAP_Module.Improve.Further.N.SAPChange = Improvements.SAPPoints();
            SAP_Module.Improve.Further.N.CO2Change = Improvements.CO2Points();
            SAP_Module.Improve.Further.N.CostChange = Improvements.Costs();
            SAP_Module.Improve.Further.N.Energy = Improvements.Energy();
            SAP_Module.Improve.Further.N.Environ = Improvements.Environ();
          }
          else
            SAP_Module.ImproveDwelling.Water.Solar.Inlcude = false;
        }
        if (!House.Renewable.Photovoltaic.Inlcude)
        {
          ref SAP_Module.Photovoltaic local = ref SAP_Module.ImproveDwelling.Renewable.Photovoltaic;
          local.Inlcude = true;
          SAP_Module.ImproveDwelling.Renewable.Photovoltaic.Photovoltaics = new SAP_Module.PhotoVoltaics[1];
          local.Photovoltaics[0].PPower = 2.5f;
          local.Photovoltaics[0].PCOrientation = "South";
          local.Photovoltaics[0].PTilt = "30°";
          local.Photovoltaics[0].POvershading = "Modest";
          SAP_Module.CalculationImprove2012.Dwelling = SAP_Module.ImproveDwelling;
          SAP_Module.CalculationImprove2012Regional.Dwelling = SAP_Module.ImproveDwelling;
          SAP_Module.Improve.Further.U.Include = Improvements.Include(0.95f);
          if (SAP_Module.Improve.Further.U.Include)
          {
            SAP_Module.Improve.Further.U.SAPChange = Improvements.SAPPoints();
            SAP_Module.Improve.Further.U.CO2Change = Improvements.CO2Points();
            SAP_Module.Improve.Further.U.CostChange = Improvements.Costs();
            SAP_Module.Improve.Further.U.Energy = Improvements.Energy();
            SAP_Module.Improve.Further.U.Environ = Improvements.Environ();
          }
          else
            SAP_Module.ImproveDwelling.Renewable.Photovoltaic = House.Renewable.Photovoltaic;
        }
        if (!House.Renewable.WindTurbine.Inlcude & House.Terrain.Equals("Rural"))
        {
          ref SAP_Module.WindTurbine local = ref SAP_Module.ImproveDwelling.Renewable.WindTurbine;
          local.Inlcude = true;
          local.WRDiameter = Conversions.ToString(4);
          local.WHeight = Conversions.ToString(10);
          local.WNumber = 1;
          SAP_Module.CalculationImprove2012.Dwelling = SAP_Module.ImproveDwelling;
          SAP_Module.CalculationImprove2012Regional.Dwelling = SAP_Module.ImproveDwelling;
          SAP_Module.Improve.Further.V2.Include = Improvements.Include(0.95f);
          if (SAP_Module.Improve.Further.V2.Include)
          {
            SAP_Module.Improve.Further.V2.SAPChange = Improvements.SAPPoints();
            SAP_Module.Improve.Further.V2.CO2Change = Improvements.CO2Points();
            SAP_Module.Improve.Further.V2.CostChange = Improvements.Costs();
            SAP_Module.Improve.Further.V2.Energy = Improvements.Energy();
            SAP_Module.Improve.Further.V2.Environ = Improvements.Environ();
          }
          else
            SAP_Module.ImproveDwelling.Renewable.WindTurbine = House.Renewable.WindTurbine;
        }
      }
      SAP_Module.CalculationImprove2012.Dwelling = SAP_Module.ImproveDwelling;
      SAP_Module.CalculationImprove2012Regional.Dwelling = SAP_Module.ImproveDwelling;
      SAP_Module.CalcRound = calcRound;
    }

    public static bool Include(float Amount)
    {
      bool flag = false;
      if (SAP_Module.Calculation2012.Calculation.SAP_rating_11a.Box258 == 0.0)
      {
        if (SAP_Module.CalculationImprove2012.Calculation.SAP_rating_11b.Box358 - Improvements.Changes.SAPChange > (double) Amount)
          flag = true;
      }
      else if (SAP_Module.CalculationImprove2012.Calculation.SAP_rating_11a.Box258 - Improvements.Changes.SAPChange > (double) Amount)
        flag = true;
      return flag;
    }

    public static double SAPPoints()
    {
      double num;
      if (SAP_Module.Calculation2012.Calculation.SAP_rating_11a.Box258 == 0.0)
      {
        num = SAP_Module.CalculationImprove2012.Calculation.SAP_rating_11b.Box358 - Improvements.Changes.SAPChange;
        Improvements.Changes.SAPChange = SAP_Module.CalculationImprove2012.Calculation.SAP_rating_11b.Box358;
      }
      else
      {
        num = SAP_Module.CalculationImprove2012.Calculation.SAP_rating_11a.Box258 - Improvements.Changes.SAPChange;
        Improvements.Changes.SAPChange = SAP_Module.CalculationImprove2012.Calculation.SAP_rating_11a.Box258;
      }
      return num;
    }

    public static double CO2Points()
    {
      double num;
      if (SAP_Module.Calculation2012.Calculation.CO2_Emissions_12a.Box272 == 0.0)
      {
        num = Improvements.Changes.CO2Change - SAP_Module.CalculationImprove2012Regional.Calculation.CO2_Emissions_12b.Box383;
        Improvements.Changes.CO2Change = SAP_Module.CalculationImprove2012Regional.Calculation.CO2_Emissions_12b.Box383;
      }
      else
      {
        num = Improvements.Changes.CO2Change - SAP_Module.CalculationImprove2012Regional.Calculation.CO2_Emissions_12a.Box272;
        Improvements.Changes.CO2Change = SAP_Module.CalculationImprove2012Regional.Calculation.CO2_Emissions_12a.Box272;
      }
      return num;
    }

    public static double Costs()
    {
      double num;
      if (SAP_Module.Calculation2012.Calculation.Actual_costs_10a.Box255 == 0.0)
      {
        num = Improvements.Changes.CostChange - SAP_Module.CalculationImprove2012Regional.Calculation.Actual_costs_10b.Box355;
        Improvements.Changes.CostChange = SAP_Module.CalculationImprove2012Regional.Calculation.Actual_costs_10b.Box355;
      }
      else
      {
        num = Improvements.Changes.CostChange - SAP_Module.CalculationImprove2012Regional.Calculation.Actual_costs_10a.Box255;
        Improvements.Changes.CostChange = SAP_Module.CalculationImprove2012Regional.Calculation.Actual_costs_10a.Box255;
      }
      return num;
    }

    public static string Energy() => SAP_Module.Calculation2012.Calculation.SAP_rating_11a.Box258 != 0.0 ? SAP_Module.CalculationImprove2012.Calculation.SAP_rating_11a.SAPBand + " " + Conversions.ToString(SAP_Module.CalculationImprove2012.Calculation.SAP_rating_11a.SAPRating) : SAP_Module.CalculationImprove2012.Calculation.SAP_rating_11b.SAPBand + " " + Conversions.ToString(SAP_Module.CalculationImprove2012.Calculation.SAP_rating_11b.SAPRating);

    public static string Environ() => SAP_Module.Calculation2012.Calculation.CO2_Emissions_12a.Box272 != 0.0 ? SAP_Module.CalculationImprove2012.Calculation.CO2_Emissions_12a.EIBand + " " + Conversions.ToString(SAP_Module.CalculationImprove2012.Calculation.CO2_Emissions_12a.Box274) : SAP_Module.CalculationImprove2012.Calculation.CO2_Emissions_12b.EIBand + " " + Conversions.ToString(SAP_Module.CalculationImprove2012.Calculation.CO2_Emissions_12b.EIRating);

    private struct Increments
    {
      public double SAPChange;
      public double CostChange;
      public double CO2Change;
    }
  }
}
