
// Type: SAP2012.OccupancyAssessmentClasses




using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SAP2012
{
  public class OccupancyAssessmentClasses
  {
    public OccupancyAssessmentClasses()
    {
      this.HeatingByRooms = new List<OccupancyClass.RoomHeating>();
      this.OtherFuels = new ObservableCollection<OccupancyClass.OtherFuel>();
      this.Ec_m = new Months();
      this.Er_m = new Months();
      this.Ea_m = new Months();
      this.Eshower_m = new Months();
      this.Gc_m = new Months();
      this.Gc2_m = new Months();
      this.Gr_m = new Months();
      this.Gshower_m = new Months();
    }

    public float NoOfOccupants { get; set; }

    public bool IsStandard { get; set; }

    public OccupancyClass.ShowerTypeCode ShowerType { get; set; }

    public bool ShowersPerDayKnown { get; set; }

    public double ShowersPerDay { get; set; }

    public bool BathsPerDayKnown { get; set; }

    public double BathsPerDay { get; set; }

    public OccupancyClass.HeatingOveride MainHeating1 { get; set; }

    public OccupancyClass.HeatingOveride MainHeating2 { get; set; }

    public OccupancyClass.HeatingOveride SecondaryHeating { get; set; }

    public List<OccupancyClass.RoomHeating> HeatingByRooms { get; set; }

    public int LivingTemp { get; set; }

    public bool LivingTempKnown { get; set; }

    public OccupancyClass.HeatingPattern NormalPattern1 { get; set; }

    public OccupancyClass.HeatingPattern NormalPattern2 { get; set; }

    public OccupancyClass.HeatingPattern NormalPattern3 { get; set; }

    public OccupancyClass.HeatingPattern NormalPattern4 { get; set; }

    public OccupancyClass.HeatingPattern AltPattern1 { get; set; }

    public OccupancyClass.HeatingPattern AltPattern2 { get; set; }

    public OccupancyClass.HeatingPattern AltPattern3 { get; set; }

    public OccupancyClass.HeatingPattern AltPattern4 { get; set; }

    public int NoofAlternativeDays { get; set; }

    public OccupancyClass.CommTypeCode CommType { get; set; }

    public OccupancyClass.Community CommunityHeating { get; set; }

    public OccupancyClass.Fuel Electricity { get; set; }

    public OccupancyClass.Fuel Electricity_High { get; set; }

    public OccupancyClass.Fuel Electricity_Low { get; set; }

    public OccupancyClass.Fuel Gas { get; set; }

    public bool MainsGas_Available { get; set; }

    public ObservableCollection<OccupancyClass.OtherFuel> OtherFuels { get; set; }

    public OccupancyClass.Unusual UnusualEnergy { get; set; }

    public OccupancyClass.Recommendations Recommends { get; set; }

    public bool U_Included { get; set; }

    public OccupancyClass.CookerType CookerType { get; set; }

    public OccupancyClass.CookingFuel CookingFuel { get; set; }

    public bool Scaling_Factors_Set { get; set; }

    public float Box211_High_factor { get; set; }

    public float Box213_High_factor { get; set; }

    public float Box215_High_factor { get; set; }

    public float Box219_High_factor { get; set; }

    public float Box219Imm_High_factor { get; set; }

    public float Box219a_High_factor { get; set; }

    public float Box231_High_factor { get; set; }

    public float Box232_High_factor { get; set; }

    public float Box232a_High_factor { get; set; }

    public float Box232b_High_factor { get; set; }

    public float Box232c_High_factor { get; set; }

    public float Box211_factor { get; set; }

    public float Box213_factor { get; set; }

    public float Box215_factor { get; set; }

    public float Box219_factor { get; set; }

    public float Box219Imm_factor { get; set; }

    public float Box219a_factor { get; set; }

    public float Box231_factor { get; set; }

    public float Box232_factor { get; set; }

    public float Box232a_factor { get; set; }

    public float Box232b_factor { get; set; }

    public float Box232c_factor { get; set; }

    public float Box211_Dual_factor { get; set; }

    public float Box213_Dual_factor { get; set; }

    public float Box215_Dual_factor { get; set; }

    public float Box219_Dual_factor { get; set; }

    public float Box312a_High_factor { get; set; }

    public float Box307_factor { get; set; }

    public float Box309_factor { get; set; }

    public float Box310a_factor { get; set; }

    public float Box312a_factor { get; set; }

    public float Box332c_factor { get; set; }

    public float Box332b_factor { get; set; }

    public string MainHeating_Fuel { get; set; }

    public string MainHeating2_Fuel { get; set; }

    public string Secondary_Fuel { get; set; }

    public double SecondaryHeatingFraction { get; set; }

    public bool SecondaryHeatingLivingRoom { get; set; }

    public double Ec { get; set; }

    public double Ec2 { get; set; }

    public Months Ec_m { get; set; }

    public Months Er_m { get; set; }

    public double Etd { get; set; }

    public double Ecold { get; set; }

    public double Ea { get; set; }

    public Months Ea_m { get; set; }

    public Months Eshower_m { get; set; }

    public Months Gc_m { get; set; }

    public Months Gc2_m { get; set; }

    public Months Gr_m { get; set; }

    public Months Gshower_m { get; set; }

    public void Eother(float TFA)
    {
      this.Ea = 127.9 * Math.Pow((double) TFA * (double) this.NoOfOccupants, 0.4714) + this.Etd + this.Ecold;
      this.Ea_m.M1 = this.Ea * (1.0 + 0.157 * Math.Cos(-13.0 * Math.PI / 100.0)) * 31.0 / 365.0;
      this.Ea_m.M2 = this.Ea * (1.0 + 0.157 * Math.Cos(11.0 * Math.PI / 300.0)) * 28.0 / 365.0;
      this.Ea_m.M3 = this.Ea * (1.0 + 0.157 * Math.Cos(61.0 * Math.PI / 300.0)) * 31.0 / 365.0;
      this.Ea_m.M4 = this.Ea * (1.0 + 0.157 * Math.Cos(37.0 * Math.PI / 100.0)) * 30.0 / 365.0;
      this.Ea_m.M5 = this.Ea * (1.0 + 0.157 * Math.Cos(161.0 * Math.PI / 300.0)) * 31.0 / 365.0;
      this.Ea_m.M6 = this.Ea * (1.0 + 0.157 * Math.Cos(211.0 * Math.PI / 300.0)) * 30.0 / 365.0;
      this.Ea_m.M7 = this.Ea * (1.0 + 0.157 * Math.Cos(87.0 * Math.PI / 100.0)) * 31.0 / 365.0;
      this.Ea_m.M8 = this.Ea * (1.0 + 0.157 * Math.Cos(311.0 * Math.PI / 300.0)) * 31.0 / 365.0;
      this.Ea_m.M9 = this.Ea * (1.0 + 0.157 * Math.Cos(361.0 * Math.PI / 300.0)) * 30.0 / 365.0;
      this.Ea_m.M10 = this.Ea * (1.0 + 0.157 * Math.Cos(137.0 * Math.PI / 100.0)) * 31.0 / 365.0;
      this.Ea_m.M11 = this.Ea * (1.0 + 0.157 * Math.Cos(461.0 * Math.PI / 300.0)) * 30.0 / 365.0;
      this.Ea_m.M12 = this.Ea * (1.0 + 0.157 * Math.Cos(511.0 * Math.PI / 300.0)) * 31.0 / 365.0;
      this.Ea = this.Ea_m.M1 + this.Ea_m.M2 + this.Ea_m.M3 + this.Ea_m.M4 + this.Ea_m.M5 + this.Ea_m.M6 + this.Ea_m.M7 + this.Ea_m.M8 + this.Ea_m.M9 + this.Ea_m.M10 + this.Ea_m.M11 + this.Ea_m.M12;
    }
  }
}
