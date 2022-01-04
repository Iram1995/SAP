
// Type: SAP2012.DataSAP




using Microsoft.VisualBasic.CompilerServices;

namespace SAP2012
{
  public class DataSAP
  {
    public Enums.HeatingFuelType CheckFuel(string Code)
    {
      string Left = Code;
      if (Operators.CompareString(Left, Conversions.ToString(1), false) == 0 || Operators.CompareString(Left, Conversions.ToString(26), false) == 0)
        return Enums.HeatingFuelType.Mains_Gas;
      if (Operators.CompareString(Left, Conversions.ToString(27), false) == 0)
        return Enums.HeatingFuelType.Bulk_LPG;
      if (Operators.CompareString(Left, Conversions.ToString(3), false) == 0)
        return Enums.HeatingFuelType.Bottle_LPG;
      if (Operators.CompareString(Left, Conversions.ToString(28), false) == 0)
        return Enums.HeatingFuelType.Heating_Oil;
      if (Operators.CompareString(Left, Conversions.ToString(5), false) == 0)
        return Enums.HeatingFuelType.Anthracite;
      if (Operators.CompareString(Left, Conversions.ToString(6), false) == 0)
        return Enums.HeatingFuelType.Wood_Logs;
      if (Operators.CompareString(Left, Conversions.ToString(7), false) == 0)
        return Enums.HeatingFuelType.Bulk_Wood_Pellets;
      if (Operators.CompareString(Left, Conversions.ToString(8), false) == 0)
        return Enums.HeatingFuelType.Wood_Chips;
      if (Operators.CompareString(Left, Conversions.ToString(9), false) == 0)
        return Enums.HeatingFuelType.Dual_Fuel_Mineral_Wood;
      if (Operators.CompareString(Left, Conversions.ToString(11), false) == 0)
        return Enums.HeatingFuelType.WasteHeat;
      if (Operators.CompareString(Left, Conversions.ToString(12), false) == 0)
        return Enums.HeatingFuelType.Appliances_able_to_use_mineral_oil_or_liquid_biofuel;
      if (Operators.CompareString(Left, Conversions.ToString(13), false) != 0)
      {
        if (Operators.CompareString(Left, Conversions.ToString(33), false) == 0)
          return Enums.HeatingFuelType.House_Coal;
        if (Operators.CompareString(Left, Conversions.ToString(15), false) == 0)
          return Enums.HeatingFuelType.Smokeless_Coal;
        if (Operators.CompareString(Left, Conversions.ToString(16), false) == 0)
          return Enums.HeatingFuelType.wood_pellets_in_bags_for_secondary_heating;
        if (Operators.CompareString(Left, Conversions.ToString(17), false) == 0)
          return Enums.HeatingFuelType.LPG_special_condition;
        if (Operators.CompareString(Left, Conversions.ToString(18), false) == 0)
          return Enums.HeatingFuelType.B30K__not_community;
        if (Operators.CompareString(Left, Conversions.ToString(19), false) == 0)
          return Enums.HeatingFuelType.Bioethanol;
        if (Operators.CompareString(Left, Conversions.ToString(20), false) == 0)
          return Enums.HeatingFuelType.Mains_Gas_Community;
        if (Operators.CompareString(Left, Conversions.ToString(21), false) == 0)
          return Enums.HeatingFuelType.LPG_Community;
        if (Operators.CompareString(Left, Conversions.ToString(22), false) == 0)
          return Enums.HeatingFuelType.Heating_Oil_Community;
        if (Operators.CompareString(Left, Conversions.ToString(23), false) == 0)
          return Enums.HeatingFuelType.B30D_Community_;
        if (Operators.CompareString(Left, Conversions.ToString(24), false) == 0)
          return Enums.HeatingFuelType.Coal_Community_;
        if (Operators.CompareString(Left, Conversions.ToString(25), false) == 0)
          return Enums.HeatingFuelType.electricity_generated_by_CHP;
        if (Operators.CompareString(Left, Conversions.ToString(29), false) == 0)
          return Enums.HeatingFuelType.electricity_unspecified;
        if (Operators.CompareString(Left, Conversions.ToString(30), false) == 0 || Operators.CompareString(Left, Conversions.ToString(31), false) == 0 || Operators.CompareString(Left, Conversions.ToString(32), false) == 0)
          return Enums.HeatingFuelType.Biogas_Community;
        if (Operators.CompareString(Left, Conversions.ToString(35), false) == 0 || Operators.CompareString(Left, Conversions.ToString(34), false) == 0)
          return Enums.HeatingFuelType.Biodiesel_from_used_cooking_oil_only;
        if (Operators.CompareString(Left, Conversions.ToString(36), false) == 0)
          return Enums.HeatingFuelType.Rapeseed_oil;
        if (Operators.CompareString(Left, Conversions.ToString(37), false) == 0)
          return Enums.HeatingFuelType.Appliances_able_to_use_mineral_oil_or_liquid_biofuel;
        if (Operators.CompareString(Left, Conversions.ToString(20), false) == 0)
          return Enums.HeatingFuelType.CHP_Community;
        if (Operators.CompareString(Left, Conversions.ToString(46), false) == 0)
          return Enums.HeatingFuelType.geothermal_Community;
      }
      return Enums.HeatingFuelType.Empty;
    }
  }
}
