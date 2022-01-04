
// Type: SAP2012.OccupancyClass




using Microsoft.VisualBasic;
using SAP2012.RdSAP;
using System;
using System.Collections.Generic;

namespace SAP2012
{
  [Serializable]
  public class OccupancyClass
  {
    private float _TumbmeFraction;

    public bool CompleteOccupancy { get; set; }

    public int OccupancyID { get; set; }

    public int NoOfOccupants { get; set; }

    public Survey_Class Survey { get; set; }

    public int MainHeating1HeaterCode { get; set; }

    public int MainHeating1FuelCode { get; set; }

    public int MainHeating2HeaterCode { get; set; }

    public int MainHeating2FuelCode { get; set; }

    public int SecondaryHeatingHeaterCode { get; set; }

    public int SecondaryHeatingFuelCode { get; set; }

    public OccupancyClass.HeatingOveride MainHeating1 { get; set; }

    public OccupancyClass.HeatingOveride MainHeating2 { get; set; }

    public OccupancyClass.HeatingOveride SecondaryHeating { get; set; }

    public bool IsStandardOccupancy { get; set; }

    public Enums.HeatingCode MainRoomHeater { get; set; }

    public Enums.HeatingCode Main2RoomHeater { get; set; }

    public Enums.HeatingCode SecondaryHeater { get; set; }

    public Enums.HeatingFuelType MainFuel { get; set; }

    public Enums.HeatingFuelType MainFuel2 { get; set; }

    public Enums.HeatingFuelType SecFuel { get; set; }

    public OccupancyClass.RoomHeating[] HeatingByRooms { get; set; }

    public bool LivingTempKnown { get; set; }

    public int LivingTemp { get; set; }

    public OccupancyClass.HeatingPattern NormalPattern1 { get; set; }

    public OccupancyClass.HeatingPattern NormalPattern2 { get; set; }

    public OccupancyClass.HeatingPattern NormalPattern3 { get; set; }

    public OccupancyClass.HeatingPattern NormalPattern4 { get; set; }

    public OccupancyClass.HeatingPattern AltPattern1 { get; set; }

    public OccupancyClass.HeatingPattern AltPattern2 { get; set; }

    public OccupancyClass.HeatingPattern AltPattern3 { get; set; }

    public OccupancyClass.HeatingPattern AltPattern4 { get; set; }

    public int AverageHeatingHours
    {
      get
      {
        float num1;
        if (this.NormalPattern1.Include)
        {
          float num2;
          num1 = num2 + (float) checked (this.NormalPattern1.TimeOff - this.NormalPattern1.TimeOn * 15) / 60f;
        }
        if (this.NormalPattern2.Include)
          num1 += (float) checked (this.NormalPattern2.TimeOff - this.NormalPattern2.TimeOn * 15) / 60f;
        if (this.NormalPattern3.Include)
          num1 += (float) checked (this.NormalPattern3.TimeOff - this.NormalPattern3.TimeOn * 15) / 60f;
        if (this.NormalPattern4.Include)
          num1 += (float) checked (this.NormalPattern4.TimeOff - this.NormalPattern4.TimeOn * 15) / 60f;
        float num3;
        if (this.AltPattern1.Include)
        {
          float num4;
          num3 = num4 + (float) checked (this.AltPattern1.TimeOff - this.AltPattern1.TimeOn * 15) / 60f;
        }
        if (this.AltPattern2.Include)
          num3 += (float) checked (this.AltPattern2.TimeOff - this.AltPattern2.TimeOn * 15) / 60f;
        if (this.AltPattern3.Include)
          num3 += (float) checked (this.AltPattern3.TimeOff - this.AltPattern3.TimeOn * 15) / 60f;
        if (this.AltPattern4.Include)
          num3 += (float) checked (this.AltPattern4.TimeOff - this.AltPattern4.TimeOn * 15) / 60f;
        return checked ((int) Math.Round(unchecked ((double) num1 * (double) checked (7 - this.NoofAlternativeDays) + (double) num3 * (double) this.NoofAlternativeDays / 7.0)));
      }
    }

    public static TimeSpan TellMeTheTime(int T) => new TimeSpan(0, checked (15 * T), 0);

    public int NoofAlternativeDays { get; set; }

    public OccupancyClass.Recommendations Recommends { get; set; }

    public OccupancyClass.ShowerTypeCode ShowerType { get; set; }

    public OccupancyClass.RelatedPartyDisclosureCode RPD { get; set; }

    public bool BathsPerDayKnown { get; set; }

    public double BathsPerDay { get; set; }

    public bool ShowersPerDayKnown { get; set; }

    public double ShowersPerDay { get; set; }

    public bool OutSideDrying { get; set; }

    public float TumbleFraction => this.TumblePercent / 100f;

    public float TumblePercent { get; set; }

    public int NoOfRefrigerators { get; set; }

    public int NoOfFreezers { get; set; }

    public int NoOfFridgeFreezers { get; set; }

    public OccupancyClass.CookerType Cooker { get; set; }

    public OccupancyClass.CookingFuel RangeFuel { get; set; }

    public OccupancyClass.Unusual UnusualEnergy { get; set; }

    public OccupancyClass.CommTypeCode CommType { get; set; }

    public OccupancyClass.Fuel Electricity { get; set; }

    public OccupancyClass.Fuel Electricity_High { get; set; }

    public OccupancyClass.Fuel Electricity_Low { get; set; }

    public OccupancyClass.Fuel Gas { get; set; }

    public static double PeriodLength(OccupancyClass.Periods Per) => Per > OccupancyClass.Periods.Unknown ? 10.5 + (double) Per * 0.5 : 0.0;

    public OccupancyClass.Community CommunityHeating { get; set; }

    public OccupancyClass.OtherFuel[] OtherFuels { get; set; }

    public List<string> ErrorList { get; set; }

    public string Address
    {
      get
      {
        string address = "";
        if (this.Survey != null)
          address = address + (string.IsNullOrEmpty(this.Survey.General.AddressLine1) ? "" : this.Survey.General.AddressLine1) + (string.IsNullOrEmpty(this.Survey.General.AddressLine2) ? "" : ", " + this.Survey.General.AddressLine2) + (string.IsNullOrEmpty(this.Survey.General.AddressLine3) ? "" : ", " + this.Survey.General.AddressLine3) + (string.IsNullOrEmpty(this.Survey.General.City) ? "" : ", " + this.Survey.General.City) + (string.IsNullOrEmpty(this.Survey.General.PostCode) ? "" : ", " + this.Survey.General.PostCode);
        return address;
      }
    }

    public OccupancyClass.Info Information { get; set; }

    public OccupancyClass()
    {
      this.OccupancyID = 0;
      this.NormalPattern1 = new OccupancyClass.HeatingPattern();
      this.NormalPattern2 = new OccupancyClass.HeatingPattern();
      this.NormalPattern3 = new OccupancyClass.HeatingPattern();
      this.NormalPattern4 = new OccupancyClass.HeatingPattern();
      this.AltPattern1 = new OccupancyClass.HeatingPattern();
      this.AltPattern2 = new OccupancyClass.HeatingPattern();
      this.AltPattern3 = new OccupancyClass.HeatingPattern();
      this.AltPattern4 = new OccupancyClass.HeatingPattern();
      this.Recommends = new OccupancyClass.Recommendations();
      this.RPD = OccupancyClass.RelatedPartyDisclosureCode.Blank;
      this.UnusualEnergy = new OccupancyClass.Unusual();
      this.Electricity = new OccupancyClass.Fuel();
      this.Electricity_High = new OccupancyClass.Fuel();
      this.Electricity_Low = new OccupancyClass.Fuel();
      this.Gas = new OccupancyClass.Fuel();
      this.CommunityHeating = new OccupancyClass.Community();
      this.Information = new OccupancyClass.Info();
      this.Electricity_Low.ChargingBasis = OccupancyClass.Fuel.ChargingBasisCode.Not_Applicable;
    }

    public enum HeatingOveride
    {
      AsRdSAP,
      None,
      RoomHeat,
    }

    public class RoomHeating
    {
      public RoomHeating()
      {
        this.RoomHeatID = 0;
        this.FlagDelete = false;
      }

      public bool HeatingByMain { get; set; }

      public bool HeatingByMain2 { get; set; }

      public bool HeatingBySecondary { get; set; }

      public bool PartiallyHeated { get; set; }

      public bool NotHeated { get; set; }

      public int RoomHeatID { get; set; }

      public bool FlagDelete { get; set; }
    }

    public class HeatingPattern
    {
      public bool Include { get; set; }

      public int TimeOn { get; set; }

      public int TimeOff { get; set; }
    }

    public enum ShowerTypeCode
    {
      None,
      Mixer,
      Pumped,
      Electric,
      Unknown,
    }

    public enum RelatedPartyDisclosureCode
    {
      Blank,
      No_Related_party,
      Relative_of_homeowner,
      Residing_at_the_property,
      Financial_interest_in_the_property,
      Owner_or_Director_of_the_organisation_dealing_with_the_property_transaction,
      Employed_by_the_professional_dealing_with_the_property_transaction,
      Relative_of_the_professional_dealing_with_the_property_transaction,
    }

    public enum CookerType
    {
      Unknown,
      Normal,
      Large,
      Range_All_Year,
      Range_Winter,
    }

    public enum CookingFuel
    {
      Unknown,
      Gas,
      Gas_Electric,
      Electric,
      Always_Gas,
      Always_Oil,
      Always_Solid,
      Always_Electric,
    }

    public class Unusual
    {
      public bool Include { get; set; }

      public string Description { get; set; }

      public Enums.HeatingFuelType Fuel { get; set; }
    }

    public enum CommTypeCode
    {
      Unasigned,
      HeatingUsed,
      Fixed,
    }

    public enum Periods
    {
      Unknown,
      _11,
      _11_5,
      _12,
      _12_5,
      _13,
    }

    public class Fuel
    {
      public Fuel()
      {
        this.FuelID = 0;
        this.FlagDelete = false;
        this.StandardCharge = new OccupancyClass.Fuel.StandardChargeClass();
        this.UnitPrice = new OccupancyClass.Fuel.UnitPriceClass();
      }

      public int FuelID { get; set; }

      public bool FlagDelete { get; set; }

      public OccupancyClass.Fuel.FuelBillInformation FuelBillInfo { get; set; }

      public double EnergyUsed { get; set; }

      public double EnergyUsed_Low { get; set; }

      public OccupancyClass.Periods Period { get; set; }

      public bool Renewable { get; set; }

      public double PVkWhSupplied { get; set; }

      public double WindkWhSupplied { get; set; }

      public double MicroCHPkWhSupplied { get; set; }

      public OccupancyClass.Fuel.ChargingBasisCode ChargingBasis { get; set; }

      public OccupancyClass.Fuel.StandardChargeClass StandardCharge { get; set; }

      public OccupancyClass.Fuel.UnitPriceClass UnitPrice { get; set; }

      public bool VAT { get; set; }

      public bool Unusual_Energy { get; set; }

      public string Unusual_Energy_Desc { get; set; }

      public enum FuelBillInformation
      {
        NotPresent,
        NotAvailable,
        EstimatedReadings,
        ActualReadings,
      }

      public enum ChargingBasisCode
      {
        Standing = 0,
        UnitPrices = 1,
        Not_Applicable = 5,
      }

      public class StandardChargeClass
      {
        public StandardChargeClass() => this.FlagDelete = false;

        public float Amount { get; set; }

        public OccupancyClass.Fuel.StandardChargeClass.PeriodCode Period { get; set; }

        public float Rate { get; set; }

        public float Rate_Low { get; set; }

        public bool FlagDelete { get; set; }

        public enum PeriodCode
        {
          Po_Year,
          Po_Quarter,
          Po_Month,
          p_Day,
        }
      }

      [Serializable]
      public class UnitPriceClass
      {
        public UnitPriceClass() => this.FlagDelete = false;

        public float UnitPrice { get; set; }

        public int Units { get; set; }

        public OccupancyClass.Fuel.UnitPriceClass.ChargeRateCode ChargeRate { get; set; }

        public float FollowOnUnitPrice { get; set; }

        public float FollowOnUnitPrice_Low { get; set; }

        public bool FlagDelete { get; set; }

        public enum ChargeRateCode
        {
          Unasigned,
          PerMonth,
          PerQuarter,
        }
      }
    }

    [Serializable]
    public class Community
    {
      public Community() => this.FlagDelete = false;

      public OccupancyClass.Community.FuelBillInformation FuelBillInfo { get; set; }

      public double EnergyUsed { get; set; }

      public OccupancyClass.Periods Period { get; set; }

      public double FixedCost { get; set; }

      public double UnitPrice { get; set; }

      public bool VAT { get; set; }

      public bool Unusual_Energy { get; set; }

      public string Unusual_Energy_Desc { get; set; }

      public bool FlagDelete { get; set; }

      public enum FuelBillInformation
      {
        NotPresent,
        NotAvailable,
        Invoices,
      }
    }

    [Serializable]
    public class OtherFuel
    {
      public OtherFuel()
      {
        this.OtherFuelID = 0;
        this.FlagDelete = false;
      }

      public OccupancyClass.OtherFuel.FuelBillInformation FuelBillInfo { get; set; }

      public OccupancyClass.OtherFuel.FuelType Fuel { get; set; }

      public bool Include { get; set; }

      public OccupancyClass.OtherFuel.UnitMeasure UnitType { get; set; }

      public double FixedCost { get; set; }

      public OccupancyClass.Periods Period { get; set; }

      public int UnitsPurchased { get; set; }

      public float UnitPrice { get; set; }

      public float TotalCost { get; set; }

      public bool VAT { get; set; }

      public bool Unusual_Energy { get; set; }

      public string Unusual_Energy_Desc { get; set; }

      public int OtherFuelID { get; set; }

      public bool FlagDelete { get; set; }

      public enum FuelBillInformation
      {
        NotAvailable,
        Invoices,
      }

      public enum FuelType
      {
        Bottled_LPG,
        Bulk_LPG,
        LPG_Special_Condition_18,
        Heating_Oil,
        Coal,
        Anthracite,
        Smokeless_Fuel,
        Wood_Logs,
        Wood_Chips,
        Wood_Pellets,
        Bioethanol,
        Biodiesel_From_Biomass,
        Biodiesel_From_Cooking_Oil,
        Rapeseed_Oil,
        Mineral_Oil_Or_Liquid_Biofuel,
        B30K,
      }

      public enum UnitMeasure
      {
        Unselected,
        kWh,
        litres,
        kg,
        cubic_meters,
      }
    }

    public class Recommendations
    {
      public bool A { get; set; }

      public OccupancyClass.Recommendations.A_Options A_Option { get; set; }

      public bool A2 { get; set; }

      public OccupancyClass.Recommendations.A2_Options A2_Option { get; set; }

      public bool A3 { get; set; }

      public OccupancyClass.Recommendations.A3_Options A3_Option { get; set; }

      public bool B { get; set; }

      public bool Q2 { get; set; }

      public OccupancyClass.Recommendations.Q2_Options Q2_Option { get; set; }

      public bool Q { get; set; }

      public OccupancyClass.Recommendations.Q_Options Q_Option { get; set; }

      public OccupancyClass.Recommendations.ImprovePercent Q_Percent { get; set; }

      public bool Q1 { get; set; }

      public OccupancyClass.Recommendations.Q_Options Q1_Option { get; set; }

      public OccupancyClass.Recommendations.ImprovePercent Q1_Percent { get; set; }

      public bool W { get; set; }

      public OccupancyClass.Recommendations.W_Options W_Option { get; set; }

      public bool D { get; set; }

      public bool E { get; set; }

      public bool C { get; set; }

      public bool F { get; set; }

      public bool G { get; set; }

      public int G_Control { get; set; }

      public bool H { get; set; }

      public bool I { get; set; }

      public bool S { get; set; }

      public bool T { get; set; }

      public bool T2 { get; set; }

      public bool R { get; set; }

      public bool J { get; set; }

      public bool K { get; set; }

      public bool L { get; set; }

      public bool M { get; set; }

      public bool Z1 { get; set; }

      public bool Z4 { get; set; }

      public bool Z2 { get; set; }

      public bool Z5 { get; set; }

      public bool Z3 { get; set; }

      public bool N { get; set; }

      public OccupancyClass.Recommendations.N_Options N_Option { get; set; }

      public OccupancyClass.Recommendations.Orientation N_Orientation { get; set; }

      public bool Y { get; set; }

      public bool O { get; set; }

      public OccupancyClass.Recommendations.ImprovePercent O_Percent { get; set; }

      public bool O2 { get; set; }

      public OccupancyClass.Recommendations.ImprovePercent O2_Percent { get; set; }

      public bool P { get; set; }

      public OccupancyClass.Recommendations.ImprovePercent P_Percent { get; set; }

      public bool X { get; set; }

      public bool U { get; set; }

      public OccupancyClass.Recommendations.U_Options U_Option { get; set; }

      public bool V { get; set; }

      public OccupancyClass.Recommendations.Orientation U_Orientation { get; set; }

      public OccupancyClass.Recommendations.V_Options V_Option { get; set; }

      public bool FlagDelete { get; set; }

      public Recommendations()
      {
        this.A_Option = new OccupancyClass.Recommendations.A_Options();
        this.A2_Option = new OccupancyClass.Recommendations.A2_Options();
        this.A3_Option = new OccupancyClass.Recommendations.A3_Options();
        this.Q2_Option = new OccupancyClass.Recommendations.Q2_Options();
        this.Q_Option = new OccupancyClass.Recommendations.Q_Options();
        this.Q1_Option = new OccupancyClass.Recommendations.Q_Options();
        this.W_Option = new OccupancyClass.Recommendations.W_Options();
        this.G_Control = 0;
        this.N_Option = new OccupancyClass.Recommendations.N_Options();
        this.N_Orientation = new OccupancyClass.Recommendations.Orientation();
        this.U_Option = new OccupancyClass.Recommendations.U_Options();
        this.U_Orientation = new OccupancyClass.Recommendations.Orientation();
        this.V_Option = new OccupancyClass.Recommendations.V_Options();
        this.FlagDelete = false;
        this.Q_Percent = OccupancyClass.Recommendations.ImprovePercent._100;
      }

      [Serializable]
      public class A_Options
      {
        public bool _150 { get; set; }

        public bool _200 { get; set; }

        public bool _250 { get; set; }

        public bool _270 { get; set; }

        public bool _300 { get; set; }

        public bool _350 { get; set; }

        public bool _400 { get; set; }

        public A_Options() => this._270 = true;

        public double Uvalue()
        {
          if (this._150)
            return 0.3;
          if (this._200)
            return 0.22;
          if (this._250)
            return 0.18;
          if (this._270)
            return 0.16;
          if (this._300)
            return 0.15;
          if (this._350)
            return 0.13;
          return this._400 ? 0.11 : 0.3;
        }
      }

      [Serializable]
      public class A2_Options
      {
        public bool _100 { get; set; }

        public bool _150 { get; set; }

        public bool _200 { get; set; }

        public bool _250 { get; set; }

        public A2_Options() => this._200 = true;

        public double Uvalue()
        {
          if (this._100)
            return 0.33;
          if (this._150)
            return 0.24;
          if (this._200)
            return 0.18;
          return this._250 ? 0.16 : 0.33;
        }
      }

      [Serializable]
      public class A3_Options
      {
        public bool _100 { get; set; }

        public bool _150 { get; set; }

        public bool _200 { get; set; }

        public bool _250 { get; set; }

        public A3_Options() => this._150 = true;

        public double Uvalue()
        {
          if (this._100)
            return 0.35;
          if (this._150)
            return 0.25;
          if (this._200)
            return 0.18;
          return this._250 ? 0.16 : 0.35;
        }
      }

      public class Q2_Options
      {
        public bool _50 { get; set; }

        public bool _100 { get; set; }

        public bool _150 { get; set; }

        public Q2_Options() => this._50 = true;
      }

      public class Q_Options
      {
        public int Percent;

        public bool _50 { get; set; }

        public bool _100 { get; set; }

        public bool _150 { get; set; }

        public Q_Options() => this._100 = true;
      }

      public class Q1_Options
      {
        public int Percent;

        public bool _50 { get; set; }

        public bool _100 { get; set; }

        public bool _150 { get; set; }

        public Q1_Options() => this._100 = true;
      }

      public class W_Options
      {
        public bool _50 { get; set; }

        public bool _100 { get; set; }

        public bool _150 { get; set; }

        public bool _200 { get; set; }

        public W_Options() => this._100 = true;
      }

      public class N_Options
      {
        public bool _3 { get; set; }

        public bool _6 { get; set; }

        public N_Options() => this._3 = true;

        public double m2() => this._3 || !this._6 ? 3.0 : 6.0;
      }

      public class U_Options
      {
        public bool _1_5 { get; set; }

        public bool _2_5 { get; set; }

        public bool _3_5 { get; set; }

        public U_Options() => this._2_5 = true;

        public double kWp()
        {
          if (this._1_5)
            return 1.5;
          if (this._2_5)
            return 2.5;
          return this._3_5 ? 3.5 : 1.5;
        }
      }

      public class V_Options
      {
        public bool V { get; set; }

        public bool V2 { get; set; }

        public V_Options() => this.V = true;

        public double Blade_Diameter() => this.V || !this.V2 ? 2.0 : 4.0;

        public double Hub_Height() => this.V || !this.V2 ? 4.0 : 10.0;
      }

      public enum ImprovePercent
      {
        _100,
        _90,
        _80,
        _70,
        _60,
        _50,
        _40,
        _30,
        _20,
        _10,
      }

      public enum Orientation
      {
        North,
        North_East,
        East,
        South_East,
        South,
        South_West,
        West,
        North_West,
        Horizontal,
      }
    }

    public class Info
    {
      public Info() => this.InspectionDate = DateAndTime.Now;

      public DateTime InspectionDate { get; set; }

      public string RRN { get; set; }
    }

    public enum FuelType
    {
      Electricity,
      Electricity_High,
      Electricity_Low,
      Gas,
    }

    public enum VTypes
    {
      V,
      V2,
    }
  }
}
