
// Type: SAP2012.Enums




using System.ComponentModel;

namespace SAP2012
{
  public abstract class Enums
  {
    public int HeatingTranslate(int ID)
    {
      switch (ID)
      {
        case 1:
          return 1;
        case 2:
          return 2;
        case 3:
          return 3;
        case 4:
          return 4;
        case 5:
          return 11;
        case 6:
          return 15;
        case 7:
          return 12;
        case 8:
          return 20;
        case 9:
          return 22;
        case 10:
          return 23;
        case 11:
          return 21;
        case 12:
          return 10;
        case 13:
          return 30;
        case 14:
          return 32;
        case 15:
          return 31;
        case 16:
          return 1;
        case 17:
          return 34;
        case 18:
          return 33;
        case 19:
          return 101;
        case 20:
          return 36;
        case 21:
          return 42;
        case 22:
          return 43;
        case 23:
          return 44;
        case 24:
          return 35;
        case 25:
          return 8;
        case 26:
          return 9;
        case 27:
          return 71;
        case 28:
          return 72;
        case 29:
          return 73;
        case 30:
          return 74;
        case 31:
          return 75;
        case 32:
          return 76;
        case 33:
          return 12;
        case 34:
          return 10;
        case 35:
          return 22;
        case 36:
          return 23;
        case 37:
          return 51;
        case 38:
          return 52;
        case 39:
          return 53;
        case 40:
          return 55;
        case 41:
          return 54;
        case 42:
          return 41;
        case 43:
          return 42;
        case 44:
          return 43;
        case 45:
          return 44;
        case 46:
          return 46;
        case 47:
          return 48;
        case 48:
          return 49;
        default:
          return 99;
      }
    }

    public enum PrimaryHeatingType
    {
      [Description("No Heating"), Category("Primary Heating System")] No_Heating = 0,
      [Description("Central Heating Systems with Radiators or Underfloor Heating"), Category("Primary Heating System")] Central_Heating = 1,
      [Description("Community Heating System"), Category("Primary Heating System")] Community = 2,
      [Description("Electric Storage System"), Category("Primary Heating System")] Electric_Storage = 3,
      [Description("Electric Underfloor Heating"), Category("Primary Heating System")] Electric_Underfloor = 4,
      [Description("Warm Air Systems"), Category("Primary Heating System")] Warm_Air = 5,
      [Description("Room Heaters"), Category("Primary Heating System")] Room_Heaters = 6,
      OtherguageSystems = 7,
      [Description("Other Space Heating Systems"), Category("Primary Heating System")] _lan = 7,
    }

    public enum SecondaryHeatingType
    {
      [Description("Gas boilers and oil boilers"), Category("Central Heating Systems with Radiators or Underfloor Heating")] Gas_Oil_Boilers,
      [Description("Micro-cogeneration (micro-CHP)"), Category("Central Heating Systems with Radiators or Underfloor Heating")] Micro_CHP,
      [Description("Solid fuel boilers"), Category("Central Heating Systems with Radiators or Underfloor Heating")] Solid_Fuel,
      [Description("Electric boilers"), Category("Central Heating Systems with Radiators or Underfloor Heating")] Eectric_Boiler,
      [Description("Heat pumps"), Category("Central Heating Systems with Radiators or Underfloor Heating")] Heat_Pumps,
      [Description("Off-peak tariffs"), Category("Electric Storage System")] Off_peak,
      [Description("24-hour heating tariff"), Category("Electric Storage System")] _24_hour,
      [Description("Off-peak tariffs"), Category("Electric underfloor heating")] Off_peak_U,
      [Description("Standard tariff"), Category("Electric underfloor heating")] Standard_tarrif,
      [Description("Gas-fired warm air with fan-assisted flue"), Category("Warm air systems")] Warm_air_Fan_assisted,
      [Description("Gas fired warm air with balanced or open flue"), Category("Warm air systems")] Warm_air_Balanced_Open,
      [Description("Oil-fired warm air"), Category("Warm air systems")] Warm_air_Oil_Fired,
      [Description("Electric warm air"), Category("Warm air systems")] Warm_air_Electric,
      [Description("Heat pumps"), Category("Warm air systems")] Warm_air_Heat_Pumps,
      [Description("Gas (including LPG) room heaters"), Category("Room heaters")] Room_Gas,
      [Description("Oil room heaters"), Category("Room heaters")] Room_Oil,
      [Description("Solid fuel room heaters"), Category("Room heaters")] Room_Solid,
      [Description("Electric (direct acting) room heaters"), Category("Room heaters")] Room_Electric,
      [Description("Range cooker Mains Gas and LPG"), Category("GAS LPG")] Range_cooker_GAS_LPG,
      [Description("Range cooker Mains Gas and LPG"), Category("Room heaters")] Range_cooker_Oil,
      [Description("Gas Boilers"), Category("gas boilers")] GasBoilers,
      [Description("Oil Boilers"), Category("Oil boilers")] OilBoilers,
      [Description("Combined Primary Storage Units (CPSU) (mains gas and LPG)"), Category("gas boilers")] Combined_Primary_Storage_Units_CPSU_mains_gas_and_LPG,
      [Description("Gas boilers (including LPG) 1998 or later"), Category("gas boilers")] Gas_boilers_including_LPG_1998_or_later,
      [Description("Gas boilers (including LPG) pre-1998, with balanced or open flue"), Category("gas boilers")] Gas_boilers_including_LPG_pre_1998_with_balanced_or_open_flue,
      [Description("Gas boilers (including LPG) pre-1998, with fan-assisted flue"), Category("gas boilers")] Gas_boilers_including_LPG_pre_1998_with_fan_assisted_flue,
      [Description("No Secondary Option"), Category("gas boilers")] NoHeating,
      [Description("Community Heating"), Category("Community Hetaing")] CommunityHeating,
      [Description("Other Space hetaing"), Category("Other Space Hetaing")] OtherSpaceheating,
    }

    public enum HeatingCode
    {
      [Description(""), Category("")] Empty = 0,
      [Description("Regular non-condensing with automatic ignition"), Category("Boiler: Gas boilers (including LPG) 1998 or late")] Regular_non_condensing_with_automatic_ignition = 101, // 0x00000065
      [Description("Regular condensing with automatic ignition"), Category("Boiler: Gas boilers (including LPG) 1998 or late")] Regular_condensing_with_automatic_ignition = 102, // 0x00000066
      [Description("Non-condensing combi with automatic ignition"), Category("Boiler: Gas boilers (including LPG) 1998 or late")] Non_condensing_combi_with_automatic_ignition = 103, // 0x00000067
      [Description("Condensing combi with automatic ignition"), Category("Boiler: Gas boilers (including LPG) 1998 or late")] Condensing_combi_with_automatic_ignition = 104, // 0x00000068
      [Description("Regular non-condensing with permanent pilot light"), Category("Boiler: Gas boilers (including LPG) 1998 or late")] Regular_non_condensing_with_permanent_pilot_light = 105, // 0x00000069
      [Description("Non-condensing combi with permanent pilot light"), Category("Boiler: Gas boilers (including LPG) 1998 or late")] Non_condensing_combi_with_permanent_pilot_light = 107, // 0x0000006B
      [Description("Back boiler to radiators"), Category("Boiler: Gas boilers (including LPG) 1998 or late")] Back_boiler_to_radiators = 109, // 0x0000006D
      [Description("Regular, high or unknown thermal capacity"), Category("Boiler: Gas boilers (including LPG) pre-1998, with fan-assisted flue")] Regular_high_or_unknown_thermal_capacity = 111, // 0x0000006F
      [Description("Combi"), Category("Boiler: Gas boilers (including LPG) pre-1998, with fan-assisted flue")] Combi = 112, // 0x00000070
      [Description("Condensing comb"), Category("Boiler: Gas boilers (including LPG) pre-1998, with fan-assisted flue")] Condensing_comb = 113, // 0x00000071
      [Description("Regular, condensing"), Category("Boiler: Gas boilers (including LPG) pre-1998, with fan-assisted flue")] Regular_condensing = 114, // 0x00000072
      [Description("Regular, wall mounted"), Category("Boiler: Gas boilers (including LPG) pre-1998, with balanced or open flue")] Regular_wall_mounted = 115, // 0x00000073
      [Description("Regular, floor mounted, pre 1979"), Category("Boiler: Gas boilers (including LPG) pre-1998, with balanced or open flue")] Regular_floor_mounted_pre_1979 = 116, // 0x00000074
      [Description("Regular, floor mounted, 1979 to 1997"), Category("Boiler: Gas boilers (including LPG) pre-1998, with balanced or open flue")] Regular_floor_mounted_1979_to_1997 = 117, // 0x00000075
      [Description("Combi"), Category("Boiler: Gas boilers (including LPG) pre-1998, with balanced or open flue")] Combi_118 = 118, // 0x00000076
      [Description("Back boiler to radiators"), Category("Boiler: Gas boilers (including LPG) pre-1998, with balanced or open flue")] Back_boiler_to_radiators_119 = 119, // 0x00000077
      [Description("With automatic ignition (non-condensing)"), Category("Boiler: Combined Primary Storage Units (CPSU) (natural gas and LPG")] With_automatic_ignition_non_condensing = 120, // 0x00000078
      [Description("With automatic ignition (condensing"), Category("Boiler: Combined Primary Storage Units (CPSU) (natural gas and LPG")] With_automatic_ignition_condensing = 121, // 0x00000079
      [Description("Standard oil boiler 1985 to 1997"), Category("Boiler: Oil boiler")] Standard_oil_boiler_1985_to_1997 = 125, // 0x0000007D
      [Description("Standard oil boiler, 1998 or late"), Category("Boiler: Oil boiler")] Standard_oil_boiler_1998_or_late = 126, // 0x0000007E
      [Description("Condensing"), Category("Boiler: Oil boiler")] Condensing = 127, // 0x0000007F
      [Description("Combi, pre-1998"), Category("Boiler: Oil boiler")] Combi_pre_1998 = 128, // 0x00000080
      [Description("Combi, 1998 or later"), Category("Boiler: Oil boiler")] Combi_1998_or_later = 129, // 0x00000081
      [Description("Condensing combi"), Category("Boiler: Oil boiler")] Condensing_combi = 130, // 0x00000082
      [Description("Oil room heater with boiler to radiators, pre 200"), Category("Boiler: Oil boiler")] Oil_room_heater_with_boiler_to_radiators_pre_200 = 131, // 0x00000083
      [Description("Oil room heater with boiler to radiators, 2000 or late"), Category("Boiler: Oil boiler")] Oil_room_heater_with_boiler_to_radiators_2000_or_late = 132, // 0x00000084
      [Description("Single burner with permanent pilot"), Category("Boiler:  Range cooker boilers (natural gas and LPG)")] Single_burner_with_permanent_pilot = 133, // 0x00000085
      [Description("Single burner with automatic ignition"), Category("Boiler:  Range cooker boilers (natural gas and LPG)")] Single_burner_with_automatic_ignition = 134, // 0x00000086
      [Description("Twin burner with automatic ignition (non-condensing) pre 1998"), Category("Boiler:  Range cooker boilers (natural gas and LPG)")] Twin_burner_with_automatic_ignition_non_condensing_pre_1998 = 136, // 0x00000088
      [Description("Single burner "), Category("Boiler:   Range cooker boilers (oil)")] Single_burner = 139, // 0x0000008B
      [Description("Twin burner (non-condensing) pre 1998"), Category("Boiler:   Range cooker boilers (oil)")] Twin_burner_non_condensing_pre_1998 = 140, // 0x0000008C
      [Description("Manual feed independent boiler in heated space"), Category("Solid fuel boiler")] Manual_feed_independent_boiler_in_heated_space = 151, // 0x00000097
      [Description("Manual feed independent boiler in unheated space"), Category("Solid fuel boiler")] Manual_feed_independent_boiler_in_unheated_space = 152, // 0x00000098
      [Description("Auto (gravity) feed independent boiler in heated space"), Category("Solid fuel boiler")] Auto_gravity_feed_independent_boiler_in_heated_space = 153, // 0x00000099
      [Description("Auto (gravity) feed independent boiler in unheated space"), Category("Solid fuel boiler")] Auto_gravity_feed_independent_boiler_in_unheated_space = 154, // 0x0000009A
      [Description("Wood chip/pellet independent boiler"), Category("Solid fuel boiler")] Wood_chip_pellet_independent_boiler = 155, // 0x0000009B
      [Description("Open fire with back boiler to radiators"), Category("Solid fuel boiler")] Open_fire_with_back_boiler_to_radiators = 156, // 0x0000009C
      [Description("Closed roomheater with boiler to radiators"), Category("Solid fuel boiler")] Closed_roomheater_with_boiler_to_radiators = 158, // 0x0000009E
      [Description("Stove (pellet-fired) with boiler to radiators"), Category("Solid fuel boiler")] Stove_pellet_fired_with_boiler_to_radiators = 159, // 0x0000009F
      [Description("Range cooker boiler (integral oven and boiler)"), Category("Solid fuel boiler")] Range_cooker_boiler_integral_oven_and_boiler = 160, // 0x000000A0
      [Description("Direct acting electric boiler"), Category("Electric boiler")] Direct_acting_electric_boiler = 191, // 0x000000BF
      [Description("Electric CPSU in heated space"), Category("Electric boiler")] Electric_CPSU_in_heated_space_radiators_or_underfloor = 192, // 0x000000C0
      [Description("Electric dry core storage boiler in heated space"), Category("Electric boiler")] Electric_dry_core_storage_boiler_in_heated_space = 193, // 0x000000C1
      [Description("Electric water storage boiler in heated space"), Category("Electric boiler")] Electric_water_storage_boiler_in_heated_spac = 195, // 0x000000C3
      [Description("Ground-to-water heat pump (electric)"), Category("Heat pumps")] Ground_to_water_heat_pump_electric = 201, // 0x000000C9
      [Description("Ground-to-water heat pump with auxiliary heater (electric)"), Category("Heat pumps")] Ground_to_water_heat_pump_with_auxiliary_heater_electric = 202, // 0x000000CA
      [Description("Water-to-water heat pump (electric)"), Category("Heat pumps")] Water_to_water_heat_pump_electric = 203, // 0x000000CB
      [Description("Air-to-water heat pump (electric"), Category("Heat pumps")] Air_to_water_heat_pump_electric = 204, // 0x000000CC
      [Description("Community boilers only"), Category("COMMUNITY HEATING SCHEMES")] Community_boilers_only = 301, // 0x0000012D
      [Description("Community CHP and boiler"), Category("COMMUNITY HEATING SCHEMES")] Community_CHP_and_boilers = 302, // 0x0000012E
      [Description("Community heat pump"), Category("COMMUNITY HEATING SCHEMES")] Community_heat_pump = 304, // 0x00000130
      [Description("Old (large volume) storage heaters"), Category("ELECTRIC STORAGE SYSTEM")] Old_large_volume_storage_heater = 401, // 0x00000191
      [Description("Modern (slimline) storage heaters"), Category("ELECTRIC STORAGE SYSTEM")] Modern_slimline_storage_heaters = 402, // 0x00000192
      [Description("Fan storage heaters"), Category("ELECTRIC STORAGE SYSTEM")] Fan_storage_heaters = 404, // 0x00000194
      [Description("Integrated storage+direct-acting heaters"), Category("ELECTRIC STORAGE SYSTEM")] Integrated_storage_direct_acting_heater = 408, // 0x00000198
      [Description("In concrete slab (off-peak only)"), Category("ELECTRIC UNDERFLOOR HEATING")] In_concrete_slab_off_peak_only = 421, // 0x000001A5
      [Description("Integrated (storage+direct-acting)"), Category("ELECTRIC UNDERFLOOR HEATING")] Integrated_storage_direct_acting = 422, // 0x000001A6
      [Description("In screed above insulatio"), Category("ELECTRIC UNDERFLOOR HEATING")] In_screed_above_insulation = 424, // 0x000001A8
      [Description("Ducted, on-off control, 1998 or late"), Category("Gas-fired warm air with fan-assisted flue")] Ducted_on_off_control_1998_or_later = 502, // 0x000001F6
      [Description("Ducted or stub-ducted, on-off control, pre 199"), Category("Gas-fired warm air with fan-assisted flue")] Ducted_or_stub_ducted_on_off_control_pre_1998 = 506, // 0x000001FA
      [Description("Ducted or stub-ducted, modulating control, 1998 or late"), Category("Gas-fired warm air with fan-assisted flue")] Ducted_or_stub_ducted_with_flue_heat_recovery = 510, // 0x000001FE
      [Description("Ducted or stub-ducted with flue heat recover"), Category("Gas-fired warm air with fan-assisted flue")] Condensing_511 = 511, // 0x000001FF
      [Description("Ducted output (on/off control"), Category("Oil-fired warm air")] Ducted_output_on_off_control = 512, // 0x00000200
      [Description("Electricaire system"), Category("Electricaire system")] Electricaire_system = 515, // 0x00000203
      [Description("Ground-to-air heat pump (electric)"), Category("Warm air Systems Heat pumps")] Ground_to_air_heat_pump_electric = 521, // 0x00000209
      [Description("Ground-to-air heat pump with auxiliary heater (electric"), Category("Warm air Systems Heat pumps")] Ground_to_air_heat_pump_with_auxiliary_heater_electric = 522, // 0x0000020A
      [Description("Water-to-air heat pump (electric) "), Category("Warm air Systems Heat pumps")] Water_to_air_heat_pump_electric = 523, // 0x0000020B
      [Description("Air-to-air heat pump (electric)"), Category("Warm air Systems Heat pumps")] Air_to_air_heat_pump_electric = 524, // 0x0000020C
      [Description("Gas fire, open flue, pre-1980 (open fronted)"), Category("Gas (including LPG) room heaters")] Gas_fire_open_flue_pre_1980_open_fronted = 601, // 0x00000259
      [Description("Gas fire, open flue, pre-1980 (open fronted), with back boiler unit"), Category("Gas (including LPG) room heaters")] Gas_fire_open_flue_pre_1980_open_fronted_with_back_boiler_unit = 602, // 0x0000025A
      [Description("Gas fire, open flue, 1980 or later (open fronted), sitting proud of, and sealed to, fireplace opening"), Category("Gas (including LPG) room heaters")] Gas_fire_open_flue_1980_or_later_open_fronted_sitting_proud_of_and_sealed_to_fireplace_opening = 603, // 0x0000025B
      [Description("Gas fire, open flue, 1980 or later (open fronted), sitting proud of, and sealed to, fireplace opening, with back boiler unit"), Category("Gas (including LPG) room heaters")] Gas_fire_open_flue_1980_or_later_open_fronted_sitting_proud_of_and_sealed_to_fireplace_opening_with_back_boiler_unit = 604, // 0x0000025C
      [Description("Flush fitting Live Fuel Effect gas fire (open fronted), sealed to fireplace opening"), Category("Gas (including LPG) room heaters")] Flush_fitting_Live_Fuel_Effect_gas_fire_open_fronted_sealed_to_fireplace_opening = 605, // 0x0000025D
      [Description("Flush fitting Live Fuel Effect gas fire (open fronted), sealed to fireplace opening, with back boiler unit"), Category("Gas (including LPG) room heaters")] Flush_fitting_Live_Fuel_Effect_gas_fire_open_fronted__sealed_to_fireplace_opening_with_back_boiler_unit = 606, // 0x0000025E
      [Description("Gas"), Category("Gas (including LPG) room heaters")] Flush_fitting_Live_Fuel_Effect_gas_fire_open_fronted_fan_assisted_sealed_to_fireplace_opening = 607, // 0x0000025F
      [Description("Gas fire or wall heater, balanced flue"), Category("Gas (including LPG) room heaters")] Gas_fire_or_wall_heater_balanced_flue = 609, // 0x00000261
      [Description("Gas fire, closed fronted, fan assisted"), Category("Gas (including LPG) room heaters")] Gas_fire_closed_fronted_fan_assisted = 610, // 0x00000262
      [Description("Condensing gas fire "), Category("Gas (including LPG) room heaters")] Condensing_gas_fire = 611, // 0x00000263
      [Description("Decorative Fuel Effect gas fire, open to chimney"), Category("Gas (including LPG) room heaters")] Decorative_Fuel_Effect_gas_fire_open_to_chimney = 612, // 0x00000264
      [Description("Flueless gas fire, secondary heating only"), Category("Gas (including LPG) room heaters")] Flueless_gas_fire_secondary_heating_only = 613, // 0x00000265
      [Description("Room heater, pre 2000"), Category("Oil room heaters")] Room_heater_pre_2000 = 621, // 0x0000026D
      [Description("Room heater, pre 2000, with boiler (no radiators)"), Category("Oil room heaters")] Room_heater_pre_2000_with_boiler_no_radiators = 622, // 0x0000026E
      [Description("Room heater, 2000 or later"), Category("Oil room heaters")] Room_heater_2000_or_later = 623, // 0x0000026F
      [Description("Room heater, 2000 or later with boiler (no radiators)"), Category("Oil room heaters")] Room_heater_2000_or_later_with_boiler_no_radiators = 624, // 0x00000270
      [Description("Bioethanol heater, secondary heating only"), Category("Oil room heaters")] Bioethanol_heater_secondary_heating_only = 625, // 0x00000271
      [Description("Open fire in grat"), Category("Solid fuel room heater")] Open_fire_in_grate = 631, // 0x00000277
      [Description("Open fire with back boiler (no radiators"), Category("Solid fuel room heater")] Open_fire_with_back_boiler_No_Radiators = 632, // 0x00000278
      [Description("Closed room heate"), Category("Solid fuel room heater")] Closed_room_heater = 633, // 0x00000279
      [Description("Closed room heater with boiler (no radiators) "), Category("Solid fuel room heater")] Closed_room_heater_with_boiler_No_radiators = 634, // 0x0000027A
      [Description("Stove (pellet fired)"), Category("Solid fuel room heater")] Stove_pellet_fired = 635, // 0x0000027B
      [Description("Stove (pellet fired) with boiler (no radiators)"), Category("Solid fuel room heater")] Stove_pellet_fired_with_boiler_no_Radiators = 636, // 0x0000027C
      [Description("Panel, convector or radiant heater"), Category("Electric (direct acting) room heater")] Panel_convector_or_radiant_heaters = 691, // 0x000002B3
      [Description("Portable electric heaters"), Category("Electric (direct acting) room heater")] Portable_electric_heater = 693, // 0x000002B5
      [Description("Water- or oil-filled radiator"), Category("Electric (direct acting) room heater")] Water_or_oil_filled_radiators = 694, // 0x000002B6
      [Description("noHeating"), Category("All")] NoHeatingPresentCode = 699, // 0x000002BB
      [Description("Electric ceiling heating"), Category("OTHER SPACE HEATING SYSTEM")] Electric_ceiling_heating = 701, // 0x000002BD
    }

    public enum HeatingFuelType
    {
      [Description(""), Category("")] Empty = 0,
      [Description("Mains gas"), Category("Gas")] Mains_Gas = 1,
      [Description("bulk LPG"), Category("Gas")] Bulk_LPG = 2,
      [Description("Bottle LPG"), Category("Gas")] Bottle_LPG = 3,
      [Description("Heating Oil"), Category("Oil")] Heating_Oil = 4,
      [Description("LNG"), Category("Gas")] LNG = 8,
      [Description("LPG subject to Special Condition"), Category("Gas")] LPG_special_condition = 9,
      [Description("Dual Fuel Mineral Wood"), Category("Solid Fuel")] Dual_Fuel_Mineral_Wood = 10, // 0x0000000A
      [Description("House Coal"), Category("Solid Fuel")] House_Coal = 11, // 0x0000000B
      [Description("Smokeless Coal"), Category("Solid Fuel")] Smokeless_Coal = 12, // 0x0000000C
      [Description("Anthracite"), Category("Solid Fuel")] Anthracite = 15, // 0x0000000F
      [Description("Wood Logs"), Category("Solid Fuel")] Wood_Logs = 20, // 0x00000014
      [Description("Wood Chips"), Category("Solid Fuel")] Wood_Chips = 21, // 0x00000015
      [Description("wood pellets (in bags for secondary heating) "), Category("Solid Fuel")] wood_pellets_in_bags_for_secondary_heating = 22, // 0x00000016
      [Description("Bulk Wood Pellets"), Category("Solid Fuel")] Bulk_Wood_Pellets = 23, // 0x00000017
      [Description("Standard tarrif"), Category("Electricity")] Standard_tarrif = 30, // 0x0000001E
      [Description("7-hour tariff (low rate)"), Category("Electricity")] _7_hour_tariff_low_rate = 31, // 0x0000001F
      [Description("7-hour tariff (high rate) "), Category("Electricity")] _7_hour_tariff_high_rate = 32, // 0x00000020
      [Description("10-hour tariff (low rate"), Category("Electricity")] _10_hour_tariff_low_rate = 33, // 0x00000021
      [Description("10-hour tariff (high rate )"), Category("Electricity")] _10_hour_tariff_high_rate = 34, // 0x00000022
      [Description("24-hour heating tariff"), Category("Electricity")] _24_hour_heating_tariff = 35, // 0x00000023
      [Description("electricity sold to grid"), Category("Electricity")] electricity_sold_to_grid = 36, // 0x00000024
      [Description("electricity displaced from grid"), Category("Electricity")] electricity_displaced_from_grid = 37, // 0x00000025
      [Description("electricity, unspecified tarif"), Category("Electricity")] electricity_unspecified = 39, // 0x00000027
      [Description("heat pump Community"), Category("Community")] Electricity_Community = 41, // 0x00000029
      [Description("Waste Combustion Community"), Category("Community")] Waste_Combustion_Community = 42, // 0x0000002A
      [Description("Biomass Community"), Category("Community")] Biomass_Community = 43, // 0x0000002B
      [Description("Biogas Community"), Category("Community")] Biogas_Community = 44, // 0x0000002C
      [Description("waste heat from power station Community"), Category("Community")] WasteHeat = 45, // 0x0000002D
      [Description("geothermal heat source Community"), Category("Community")] geothermal_Community = 46, // 0x0000002E
      [Description("heat from CH Community"), Category("Community")] CHP_Community = 48, // 0x00000030
      [Description("electricity generated by CHP"), Category("Community")] electricity_generated_by_CHP = 49, // 0x00000031
      [Description("electricity for pumping in distribution network"), Category("Community")] electricity_for_pumping_in_distribution_network = 50, // 0x00000032
      [Description("Mains Gas Community"), Category("Community")] Mains_Gas_Community = 51, // 0x00000033
      [Description("LPG Community"), Category("Community")] LPG_Community = 52, // 0x00000034
      [Description("Heating Oil Community"), Category("Community")] Heating_Oil_Community = 53, // 0x00000035
      [Description("Coal Community"), Category("Community")] Coal_Community_ = 54, // 0x00000036
      [Description("B30D Community"), Category("Community")] B30D_Community_ = 55, // 0x00000037
      [Description("biodiesel from any biomass source"), Category("Oil")] biodiesel_from_any_biomass_source = 71, // 0x00000047
      [Description("biodiesel from used cooking oil only"), Category("Oil")] Biodiesel_from_used_cooking_oil_only = 72, // 0x00000048
      [Description("Rapeseed Oil"), Category("Oil")] Rapeseed_oil = 73, // 0x00000049
      [Description("appliances able to use mineral oil or liquid biofuel"), Category("Oil")] Appliances_able_to_use_mineral_oil_or_liquid_biofuel = 74, // 0x0000004A
      [Description("B30K"), Category("Oil")] B30K__not_community = 75, // 0x0000004B
      [Description("Bioethanol"), Category("Oil")] Bioethanol = 76, // 0x0000004C
      [Description("electricity"), Category("Electricity")] electricity = 99, // 0x00000063
      [Description("Dual Fuel Mineral Wood2"), Category("Solid Fuel")] Dual_Fuel_Mineral_Wood2 = 100, // 0x00000064
      [Description("wood pellets (in bags for secondary heating2) "), Category("Solid Fuel")] wood_pellets_in_bags_for_secondary_heating2 = 222, // 0x000000DE
    }

    public enum HeatingBoilerFlueType
    {
      [Description(""), Category("")] Empty,
      [Description("Open Flue"), Category("FlueType")] Open_Flue,
      [Description("Balanced Flue"), Category("FlueType")] Balanced_Flue,
    }

    public enum HeatingDataSource
    {
      [Description(""), Category("")] Empty,
      [Description("PCDF"), Category("DataSourcee")] PCDF,
      [Description("SAP tables"), Category("DataSource")] SAP_Tables,
    }

    public enum CollectorDataSource
    {
      [Description(""), Category("")] Empty,
      [Description("Declared"), Category("DataSourcee")] Declared,
      [Description("SAP tables"), Category("DataSource")] SAP_Tables,
    }

    public enum HeatingEmitterType
    {
      [Description(""), Category("")] Empty,
      [Description("Radiators"), Category("EmitterType")] Radiators,
      [Description("Underfloor"), Category("EmitterType")] Underfloor,
      [Description("Fan Coil Units"), Category("EmitterType")] Fan_Coil_Units,
    }

    public enum HeatingControlsCode
    {
      [Description("Not applicable (boiler provides DHW only)"), Category("BOILER SYSTEMS WITH RADIATORS OR UNDERFLOOR HEATING")] Not_applicable_boiler_provides_DHW_only = 2100, // 0x00000834
      [Description("No time or thermostatic control of room temperature"), Category("BOILER SYSTEMS WITH RADIATORS OR UNDERFLOOR HEATING")] No_time_or_thermostatic_control_of_room_temperature_2101 = 2101, // 0x00000835
      [Description("Programmer, no room thermostat"), Category("BOILER SYSTEMS WITH RADIATORS OR UNDERFLOOR HEATING")] Programmer_no_room_thermostat = 2102, // 0x00000836
      [Description("Room thermostat only"), Category("BOILER SYSTEMS WITH RADIATORS OR UNDERFLOOR HEATING")] Room_thermostat_only = 2103, // 0x00000837
      [Description("Programmer and room thermostat"), Category("BOILER SYSTEMS WITH RADIATORS OR UNDERFLOOR HEATING")] Programmer_and_room_thermostat = 2104, // 0x00000838
      [Description("Programmer and at least two room thermostats"), Category("BOILER SYSTEMS WITH RADIATORS OR UNDERFLOOR HEATING")] Programmer_and_at_least_two_room_thermostats = 2105, // 0x00000839
      [Description("Programmer, room thermostat and TRVs"), Category("BOILER SYSTEMS WITH RADIATORS OR UNDERFLOOR HEATING")] Programmer_room_thermostat_and_TRVs = 2106, // 0x0000083A
      [Description("Programmer, TRVs and bypass"), Category("BOILER SYSTEMS WITH RADIATORS OR UNDERFLOOR HEATING")] Programmer_TRVs_and_bypass = 2107, // 0x0000083B
      [Description("Programmer, TRVs and boiler energy manage"), Category("BOILER SYSTEMS WITH RADIATORS OR UNDERFLOOR HEATING")] Programmer_TRVs_and_boiler_energy_manage = 2109, // 0x0000083D
      [Description("Time and temperature zone control"), Category("BOILER SYSTEMS WITH RADIATORS OR UNDERFLOOR HEATING")] Time_and_temperature_zone_control = 2110, // 0x0000083E
      [Description("TRVs and bypass"), Category("BOILER SYSTEMS WITH RADIATORS OR UNDERFLOOR HEATING")] TRVs_and_bypass = 2111, // 0x0000083F
      [Description("No time or thermostatic control of room temperature"), Category("HEAT PUMPS WITH RADIATORS OR UNDERFLOOR HEATING")] No_time_or_thermostatic_control_of_room_temperature_2201 = 2201, // 0x00000899
      [Description("Programmer, no room thermostat "), Category("HEAT PUMPS WITH RADIATORS OR UNDERFLOOR HEATING")] Programmer_no_room_thermostat_2202 = 2202, // 0x0000089A
      [Description("Room thermostat onl"), Category("HEAT PUMPS WITH RADIATORS OR UNDERFLOOR HEATING")] Room_thermostat_only_2203 = 2203, // 0x0000089B
      [Description("Programmer and room thermosta"), Category("HEAT PUMPS WITH RADIATORS OR UNDERFLOOR HEATING")] Programmer_and_room_thermostat_2204 = 2204, // 0x0000089C
      [Description("Programmer and at least two room thermostats"), Category("HEAT PUMPS WITH RADIATORS OR UNDERFLOOR HEATING")] Programmer_and_at_least_two_room_thermostats_2205 = 2205, // 0x0000089D
      [Description("Programmer, TRVs and bypas"), Category("HEAT PUMPS WITH RADIATORS OR UNDERFLOOR HEATING")] Programmer_TRVs_and_bypas_2206 = 2206, // 0x0000089E
      [Description("Time and temperature zone control"), Category("HEAT PUMPS WITH RADIATORS OR UNDERFLOOR HEATING")] Time_and_temperature_zone_control_2207 = 2207, // 0x0000089F
      [Description("Flat rate charging*, no thermostatic control of room temperature"), Category("COMMUNITY HEATING SCHEME")] Flat_rate_charging_no_thermostatic_control_of_room_temperature = 2301, // 0x000008FD
      [Description("Flat rate charging*, programmer, no room thermostat"), Category("COMMUNITY HEATING SCHEME")] Flat_rate_charging_programmer_no_room_thermostat = 2302, // 0x000008FE
      [Description("Flat rate charging*, room thermostat onl"), Category("COMMUNITY HEATING SCHEME")] Flat_rate_charging_room_thermostat_only = 2303, // 0x000008FF
      [Description("Flat rate charging*, programmer and room thermostat"), Category("COMMUNITY HEATING SCHEME")] Flat_rate_charging_programmer_and_room_thermostat_2204 = 2304, // 0x00000900
      [Description("Flat rate charging*, programmer and TRV"), Category("COMMUNITY HEATING SCHEME")] Flat_rate_charging_programmer_and_TRV_2305 = 2305, // 0x00000901
      [Description("Charging system linked to use of community heating, programmer and TRV"), Category("COMMUNITY HEATING SCHEME")] Charging_system_linked_to_use_of_community_heating_Programmer_and_TRV = 2306, // 0x00000902
      [Description("Flat rate charging*, TRV"), Category("COMMUNITY HEATING SCHEME")] Flat_rate_charging_TRV_2307 = 2307, // 0x00000903
      [Description("Charging system linked to use of community heating, room thermostat only"), Category("COMMUNITY HEATING SCHEME")] Charging_system_linked_to_use_of_community_heating_room_thermostat_only = 2308, // 0x00000904
      [Description("Charging system linked to use of community heating, programmer and room thermostat"), Category("COMMUNITY HEATING SCHEME")] Charging_system_linked_to_use_of_community_heating_programmer_and_room_thermostat = 2309, // 0x00000905
      [Description("Charging system linked to use of community heating, TRVs"), Category("COMMUNITY HEATING SCHEME")] Charging_system_linked_to_use_of_community_heating_TRVs = 2310, // 0x00000906
      [Description("Manual charge control"), Category("ELECTRIC STORAGE SYSTEMS")] Manual_charge_control = 2401, // 0x00000961
      [Description("Automatic charge control"), Category("ELECTRIC STORAGE SYSTEMS")] Automatic_charge_control = 2402, // 0x00000962
      [Description("Celect-type control"), Category("ELECTRIC STORAGE SYSTEMS")] Celect_type_control = 2403, // 0x00000963
      [Description("No thermostatic control of room temperature"), Category("WARM AIR SYSTEMS (including heat pumps with warm air distribution)")] No_thermostatic_control_of_room_temperature_2501 = 2501, // 0x000009C5
      [Description("Programmer, no room thermostat"), Category("WARM AIR SYSTEMS (including heat pumps with warm air distribution)")] Programmer_no_room_thermostat_2502 = 2502, // 0x000009C6
      [Description("Room thermostat only"), Category("WARM AIR SYSTEMS (including heat pumps with warm air distribution)")] Room_thermostat_only_2503 = 2503, // 0x000009C7
      [Description("Programmer and room thermostat"), Category("WARM AIR SYSTEMS (including heat pumps with warm air distribution)")] Programmer_and_room_thermostat_2504 = 2504, // 0x000009C8
      [Description("Programmer and at least two room thermostat"), Category("WARM AIR SYSTEMS (including heat pumps with warm air distribution)")] Programmer_and_at_least_two_room_thermostats_2505 = 2505, // 0x000009C9
      [Description("Time and temperature zone control"), Category("WARM AIR SYSTEMS (including heat pumps with warm air distribution)")] Time_and_temperature_zone_control_2506 = 2506, // 0x000009CA
      [Description("No thermostatic control of room temperature"), Category("ROOM HEATER SYSTEM)")] No_thermostatic_control_of_room_temperature_2601 = 2601, // 0x00000A29
      [Description("Appliance thermostat"), Category("ROOM HEATER SYSTEM)")] Appliance_thermostat_2602 = 2602, // 0x00000A2A
      [Description("Programmer and appliance thermostats"), Category("ROOM HEATER SYSTEM)")] Programmer_and_appliance_thermostats_2603 = 2603, // 0x00000A2B
      [Description("Room thermostats only"), Category("ROOM HEATER SYSTEM)")] Room_thermostats_only_2604 = 2604, // 0x00000A2C
      [Description("Programmer and room thermostat"), Category("ROOM HEATER SYSTEM)")] Programmer_and_room_thermostat_2605 = 2605, // 0x00000A2D
      [Description("NO HEATING SYSTEM PRESENT"), Category("No Heating Present")] None = 2699, // 0x00000A8B
      [Description("No thermostatic control of room temperature"), Category("OTHER SYSTEM")] No_thermostatic_control_of_room_temperature_2701 = 2701, // 0x00000A8D
      [Description("Programmer, no room thermostat"), Category("OTHER SYSTEM")] Programmer_no_room_thermostat_2702 = 2702, // 0x00000A8E
      [Description("Room thermostat only"), Category("OTHER SYSTEM")] Room_thermostat_only_2703 = 2703, // 0x00000A8F
      [Description("Programmer and room thermostat"), Category("OTHER SYSTEM")] Programmer_and_room_thermostat_2704 = 2704, // 0x00000A90
      [Description("Temperature zone control"), Category("OTHER SYSTEM")] Temperature_zone_contro1_2705 = 2705, // 0x00000A91
      [Description("Time and temperature zone control"), Category("OTHER SYSTEM")] Time_and_temperature_zone_control_2706 = 2706, // 0x00000A92
    }

    public enum Meter
    {
      [Description("Dual"), Category("Meter Type")] Dual = 1,
      [Description("Single"), Category("Meter Type")] _Single = 2,
      [Description("Unknown"), Category("Meter Type")] Unknown = 3,
      [Description("24 hour"), Category("Meter Type")] _24_hour = 4,
    }

    public enum Conservatory_Type
    {
      [Description("No conservatory"), Category("Conservatory Type")] No_conservatory = 1,
      [Description("Separated_Unheated_Conservatory"), Category("Conservatory Type")] Separated_unheated_conservatory = 2,
      [Description("Separated Heated Conservatory"), Category("Conservatory Type")] Separated_heated_conservatory = 3,
      [Description("Not Separated"), Category("Conservatory Type")] Not_separated = 4,
    }

    public enum RoomHeightCode
    {
      [Description("1 storey"), Category("Room Height Code Type")] _1_storey = 1,
      [Description("1.5 storeys"), Category("Room Height Code Type")] _One_and_Half_storeys = 2,
      [Description("2 storeys"), Category("Room Height Code Type")] _2_storeys = 3,
      [Description("2.5 storeys"), Category("Room Height Code Type")] _2_and_Half__storey = 4,
      [Description("3 storeys"), Category("Room Height Code Type")] _3_storeys = 5,
    }

    public enum WaterImmersionHeatingType
    {
      [Description("Dual"), Category("Water Immersion Heating Type")] Dual = 1,
      [Description("Single"), Category("Water Immersion Heating Type")] _Single = 2,
    }

    public enum WaterCylinderSize
    {
      [Description("No Cylinder"), Category("Water Cylinder Size")] No_Cylinder = 1,
      [Description("No Access"), Category("Water Cylinder Size")] No_Access = 2,
      [Description("Normal - between 90 and 130 litres"), Category("Water Cylinder Size")] Normal = 3,
      [Description("Medium - between 131 and 170 litres"), Category("Water Cylinder Size")] Medium = 4,
      [Description("Large - greater than 170 litres"), Category("Water Cylinder Size")] Large = 5,
    }

    public enum WaterInsulationType
    {
      [Description("None"), Category("Water Insulation Type")] None = 1,
      [Description("Foam"), Category("Water Insulation Type")] Foam = 2,
      [Description("Jacket"), Category("Water Insulation Type")] Jacket = 3,
    }

    public enum WaterThickness
    {
      [Description("12mm"), Category("Water Insulation Thickness")] _12mm = 1,
      [Description("25mm"), Category("Water Insulation Thickness")] _25mm = 2,
      [Description("38mm"), Category("Water Insulation Thickness")] _38mm = 3,
      [Description("50mm"), Category("Water Insulation Thickness")] _50mm = 4,
      [Description("80mm"), Category("Water Insulation Thickness")] _80mm = 5,
      [Description("120mm"), Category("Water Insulation Thickness")] _120mm = 6,
      [Description("160mm"), Category("Water Insulation Thickness")] _160mm = 7,
    }

    public enum WaterCode
    {
      [Description("From main heating system"), Category("Water Heating Code")] From_main_heating_system = 901, // 0x00000385
      [Description("From secondary syste"), Category("Water Heating Code")] From_secondary_system = 902, // 0x00000386
      [Description("Electric immersion"), Category("Water Heating Code")] Electric_immersion = 903, // 0x00000387
      [Description("Single-point gas water heater (instantaneous at point of use) "), Category("Water Heating Code")] Single_point_gas_water_heater_instantaneous_at_point_of_use = 907, // 0x0000038B
      [Description("Multi-point gas water heater (instantaneous serving several taps)"), Category("Water Heating Code")] Multi_point_gas_water_heater_instantaneous_serving_several_taps = 908, // 0x0000038C
      [Description("Electric instantaneous at point of use "), Category("Water Heating Code")] Electric_instantaneous_at_point_of_use = 909, // 0x0000038D
      [Description("Gas boiler/circulator for water heating only"), Category("Water Heating Code")] Gas_boiler_circulator_for_water_heating_only = 911, // 0x0000038F
      [Description("Oil boiler/circulator for water heating onl"), Category("Water Heating Code")] Oil_boiler_circulator_for_water_heating_only = 912, // 0x00000390
      [Description("Solid fuel boiler/circulator for water heating only"), Category("Water Heating Code")] Solid_fuel_boiler_circulator_for_water_heating_only = 913, // 0x00000391
      [Description("From second main system"), Category("Water Heating Code")] From_second_main_system = 914, // 0x00000392
      [Description("Gas, single burner with permanent pilot "), Category("Water Heating Code")] Gas_single_burner_with_permanent_pilot = 921, // 0x00000399
      [Description("Gas, single burner with automatic ignition"), Category("Water Heating Code")] Gas_single_burner_with_automatic_ignition = 922, // 0x0000039A
      [Description("Gas, twin burner with automatic ignition  pre 1998"), Category("Water Heating Code")] Gas_twin_burner_with_automatic_ignition_pre_1998 = 924, // 0x0000039C
      [Description(" Oil, single burner"), Category("Water Heating Code")] Oil_single_burner = 927, // 0x0000039F
      [Description("Oil, twin burner pre 1998"), Category("Water Heating Code")] Oil_twin_burner_pre_1998 = 928, // 0x000003A0
      [Description("   Solid fuel, integral oven and boiler"), Category("Water Heating Code")] Solid_fuel_integral_oven_and_boiler = 930, // 0x000003A2
      [Description(" Solid fuel, independent oven and boiler"), Category("Water Heating Code")] Solid_fuel_independent_oven_and_boiler = 931, // 0x000003A3
      [Description("Hot-water only community scheme Boilers"), Category("Water Code Community scheme")] Hot_water_only_community_scheme_BOilers = 950, // 0x000003B6
      [Description("Hot-water only community scheme CHP"), Category("Water Code Community scheme")] Hot_water_only_community_scheme_CHP = 951, // 0x000003B7
      [Description("Hot-water only community scheme"), Category("Water Code Community scheme")] Hot_water_only_community_scheme_Heatpumps = 952, // 0x000003B8
      [Description("No hot water system present - electric immersion assume"), Category("Water Heating Code")] No_WaterPresent = 999, // 0x000003E7
    }

    public enum PitchType
    {
      [Description("Horizontal"), Category("PV Pitch")] Horizontal = 1,
      [Description("30 Degrees"), Category("PV Pitch")] _30_Degrees = 2,
      [Description("45 Degrees"), Category("PV Pitch")] _45_Degrees = 3,
      [Description("60 Degrees"), Category("PV Pitch")] _60_Degrees = 4,
      [Description("Vertical"), Category("PV Pitch")] Vertical = 5,
    }

    public enum OvershadingType
    {
      [Description("None or very little"), Category("PV Overshading")] None_or_very_little = 1,
      [Description("Modest"), Category("PV Overshading")] Modest = 2,
      [Description("Significant"), Category("PV Overshading")] Significant = 3,
      [Description("Heavy"), Category("PV Overshading")] Heavy = 4,
    }

    public enum DimensionType
    {
      [Description("External"), Category("Dim Type")] External = 1,
      [Description("Internal"), Category("Dim Type")] Internal = 2,
    }

    public enum Orientation
    {
      [Description("North"), Category("PV Orientation")] North = 1,
      [Description("North East"), Category("PV Orientation")] North_east = 2,
      [Description("East"), Category("PV Orientation")] East = 3,
      [Description("South East"), Category("PV Orientation")] South_East = 4,
      [Description("South"), Category("PV Orientation")] South = 5,
      [Description("South West"), Category("PV Orientation")] South_West = 6,
      [Description("West"), Category("PV Orientation")] West = 7,
      [Description("North West"), Category("PV Orientation")] North_West = 8,
      [Description("Horizontal"), Category("PV Orientation")] Horizontal = 9,
    }

    public enum HeatLossCorridorType
    {
      [Description("No corridor"), Category("Heat Loss Corridor")] No_corridor = 1,
      [Description("Heated corridor"), Category("Heat Loss Corridor")] heated_corridor = 2,
      [Description("Unheated corridor"), Category("Heat Loss Corridor")] Unheated_corridor = 3,
    }

    public enum FlatLevelType
    {
      [Description("Basement"), Category("Level")] Basement = 1,
      [Description("Ground Floor"), Category("Level")] Ground_Floor = 2,
      [Description("Mid Floor"), Category("Level")] Mid_Floor = 3,
      [Description("Top Floor"), Category("Level")] Top_Floor = 4,
    }

    public enum FlatLocationType
    {
      [Description("Basement"), Category("Flat Location")] Basement = 1,
      [Description("Ground"), Category("Flat Location")] Ground = 2,
      [Description("1st"), Category("Flat Location")] _1st = 3,
      [Description("2nd"), Category("Flat Location")] _2nd = 4,
      [Description("3rd"), Category("Flat Location")] _3rd = 5,
      [Description("4th"), Category("Flat Location")] _4th = 6,
      [Description("5th"), Category("Flat Location")] _5th = 7,
      [Description("6th"), Category("Flat Location")] _6th = 8,
      [Description("7th"), Category("Flat Location")] _7th = 9,
      [Description("8th"), Category("Flat Location")] _8th = 10, // 0x0000000A
      [Description("9th"), Category("Flat Location")] _9th = 11, // 0x0000000B
      [Description("10th"), Category("Flat Location")] _10th = 12, // 0x0000000C
      [Description("11th"), Category("Flat Location")] _11th = 13, // 0x0000000D
      [Description("12th"), Category("Flat Location")] _12th = 14, // 0x0000000E
      [Description("13th"), Category("Flat Location")] _13th = 15, // 0x0000000F
      [Description("14th"), Category("Flat Location")] _14th = 16, // 0x00000010
      [Description("15th"), Category("Flat Location")] _15th = 17, // 0x00000011
      [Description("16th"), Category("Flat Location")] _16th = 18, // 0x00000012
      [Description("17th"), Category("Flat Location")] _17th = 19, // 0x00000013
      [Description("18th"), Category("Flat Location")] _18th = 20, // 0x00000014
      [Description("19th"), Category("Flat Location")] _19th = 21, // 0x00000015
      [Description("20th"), Category("Flat Location")] _20th = 22, // 0x00000016
      [Description("21st or above"), Category("Flat Location")] _21th_or_above = 23, // 0x00000017
    }

    public enum AddendumCode
    {
      [Description("Wall type does not correspond to options available in RdSAP"), Category("Addendum Code")] Wall_type_Not_For_RDSAP = 1,
      [Description("Room heater specified for water heating instead of a range cooker"), Category("Addendum Code")] Room_heater_specified_for_water_heating_instead_of_a_range_cooker = 2,
      [Description("Space heating from individual system and water heating from community system"), Category("Addendum Code")] Space_heating_from_individual_system_and_water_heating_from_community_system = 3,
      [Description("Dwelling has a swimming pool"), Category("Addendum Code")] Dwelling_has_a_swimming_pool = 4,
      [Description("Dwelling has micro-CHP"), Category("Addendum Code")] Dwelling_has_micro_CHP = 5,
      [Description("Storage heater or dual immersion, and single electric meter"), Category("Addendum Code")] Storage_heater_or_dual_immersion_and_Single_electric_Meter = 6,
      [Description("Heating controlled by TRVs only"), Category("Addendum Code")] Heating_controlled_by_TRVs_only = 7,
      [Description("PVs or wind turbine present on the property (England, Wales or Scotland)"), Category("Addendum Code")] PVs_or_wind_turbine_present_on_the_property = 8,
      [Description("Two main heating systems and heating system upgrade is recommended"), Category("Addendum Code")] Two_main_heating_systems_and_heating_system_upgrade_is_recommended = 9,
    }

    public enum AddendumCode2
    {
      [Description("Cavity Filled Recommended"), Category("Addendum Code2")] CavityFilledRecommended = 1,
      [Description("Stone Walls Recommended"), Category("Addendum Code2")] StonewallsRecommended = 2,
      [Description("System Build Recommended"), Category("Addendum Code2")] SystemBuildRecommended = 3,
      [Description("Access Issues Recommended"), Category("Addendum Code2")] AccessIssuesRecommended = 4,
      [Description("High Exposure Recommended"), Category("Addendum Code2")] HighExposureRecommended = 5,
      [Description("Narrow Cavities Recommended"), Category("Addendum Code2")] NarrowCavitiesRecommended = 6,
    }

    public enum WindowsLocation
    {
      [Description("Main Building"), Category("Windows Location")] Main_Building,
      [Description("Extension 1"), Category("Windows Location")] Extension1,
      [Description("Extension2"), Category("Windows Location")] Extension2,
      [Description("Extension 3"), Category("Windows Location")] Extension3,
      [Description("Extension 4"), Category("Windows Location")] Extension4,
    }

    public enum WindowType
    {
      [Description("Window"), Category("Windows Type")] Window,
      [Description("Roof Window"), Category("Windows Type")] Roof_Window,
    }

    public enum WindowsArea
    {
      [Description("Normal"), Category("Windows Glazed Area")] Normal = 1,
      [Description("More Than Typical"), Category("Windows Glazed Area")] More_Than_Typical = 2,
      [Description("Less Than Typical"), Category("Windows Glazed Area")] Less_Than_Typical = 3,
      [Description("Much More Than Typical"), Category("Windows Glazed Area")] Much_More_Than_Typical = 4,
      [Description("Much Less Than Typical"), Category("Windows Glazed Area")] Much_Less_Than_Typical = 5,
    }

    public enum WindowsDataSource
    {
      [Description("Manu"), Category("DataSource")] Manu = 1,
      [Description("BFRC"), Category("DataSource")] BFRC = 2,
    }

    public enum GlazedType
    {
      [Description("Double glazing installed before 2002"), Category("Windows Glazed Type")] Double_glazing_installed_before_2002 = 1,
      [Description("Double glazing installed during or after 2002"), Category("Windows Glazed Type")] Double_glazing_installed_during_or_after_2002 = 2,
      [Description("Double Glazed, Unknown date"), Category("Windows Glazed Type")] Double_Glazed_UnknownDate = 3,
      [Description("Secondary glazing"), Category("Windows Glazed Type")] Secondary_glazing = 4,
      [Description("Single glazing"), Category("Windows Glazed Type")] Single_glazing = 5,
      [Description("Triple glazing"), Category("Windows Glazed Type")] Triple_glazing = 6,
      [Description("Double, known data"), Category("Windows Glazed Type")] Double_known_data = 7,
      [Description("Triple, known data"), Category("Windows Glazed Type")] Triple_known_data = 8,
    }

    public enum VentilationType
    {
      [Description("Extract"), Category("Ventilation Type")] Extract = 1,
      [Description("Balance"), Category("Ventilation Type")] Balance = 2,
    }

    public enum TerrainType
    {
      [Description("Dense urban"), Category("Terrain Type")] Dense_Urban = 1,
      [Description("Low rise urban / suburban"), Category("Terrain Type")] Low_rise_urban_suburban = 2,
      [Description("Rural"), Category("Terrain Type")] Rural = 3,
    }

    public enum RelatedPartyDisclosureCode
    {
      [Description("No related party"), Category("Related Party Disclosure Code")] No_Related_party = 1,
      [Description("Relative of homeowner or occupier of the property"), Category("Related Party Disclosure Code")] Relative_of_homeowner = 2,
      [Description("Residing at the property"), Category("Related Party Disclosure Code")] Residing_at_the_property = 3,
      [Description("Financial interest in the property"), Category("Related Party Disclosure Code")] Financial_interest_in_the_property = 4,
      [Description("Owner or Director of the organisation dealing with the property transaction"), Category("Related Party Disclosure Code")] Owner_or_Director_of_the_organisation_dealing_with_the_property_transaction = 5,
      [Description("Employed by the professional dealing with the property transaction"), Category("Related Party Disclosure Code")] Employed_by_the_professional_dealing_with_the_property_transaction = 6,
      [Description("Relative of the professional dealing with the property transaction"), Category("Related Party Disclosure Code")] Relative_of_the_professional_dealing_with_the_property_transaction = 7,
    }

    public enum EPCLanguageType
    {
      [Description("EPC Language"), Category("EPC Language Type")] English = 1,
      [Description("EPC Language"), Category("EPC Language Type")] Wales = 2,
    }

    public enum PropertyAge
    {
      [Description("before 1900"), Category("England")] England_before_1900 = 1,
      [Description("before 1900"), Category("Northern Ireland")] NorthernIreland_before_1919 = 1,
      [Description("before 1900"), Category("Scotland")] Scotland_before_1919 = 1,
      [Description("1900-1929"), Category("England")] England_1900_1929 = 2,
      [Description("1919-1929"), Category("Northern Ireland")] NorthernIreland_1919_1929 = 2,
      [Description("1919-1929"), Category("Scotland")] Scotland_1919_1929 = 2,
      [Description("1930-1949"), Category("England")] England_1930_1949 = 3,
      [Description("1930-1949"), Category("Northern Ireland")] NorthernIreland_1930_1949 = 3,
      [Description("1930-1949"), Category("Scotland")] Scotland_1930_1949 = 3,
      [Description("1950-1966"), Category("England")] England_1950_1966 = 4,
      [Description("1950-1973"), Category("Northern Ireland")] NorthernIreland_1950_1973 = 4,
      [Description("1950-1964"), Category("Scotland")] Scotland_1950_1964 = 4,
      [Description("1967-1975"), Category("England")] England_1967_1975 = 5,
      [Description("1974-1977"), Category("Northern Ireland")] NorthernIreland_1974_1977 = 5,
      [Description("1965-1975"), Category("Scotland")] Scotland_1965_1975 = 5,
      [Description("1976-1982"), Category("England")] England_1976_1982 = 6,
      [Description("1978-1985"), Category("Northern Ireland")] NorthernIreland_1978_1985 = 6,
      [Description("1976-1983"), Category("Scotland")] Scotland_1976_1983 = 6,
      [Description("1983-1990"), Category("England")] England_1983_1990 = 7,
      [Description("1986-1991"), Category("Northern Ireland")] NorthernIreland_1986_1991 = 7,
      [Description("1984-1991"), Category("Scotland")] Scotland_1984_1991 = 7,
      [Description("1991-1995"), Category("England")] England_1991_1995 = 8,
      [Description("1992-1999"), Category("Northern Ireland")] NorthernIreland_1992_1999 = 8,
      [Description("1992-1998"), Category("Scotland")] Scotland_1992_1998 = 8,
      [Description("1996-2002"), Category("England")] England_1996_2002 = 9,
      [Description("1986-1991"), Category("Northern Ireland")] NorthernIreland_2000_2006 = 9,
      [Description("1999-2002"), Category("Scotland")] Scotland_1999_2002 = 9,
      [Description("2003-2006"), Category("England")] England_2003_2006 = 10, // 0x0000000A
      [Description("2003-2007"), Category("Scotland")] Scotland_2003_2007 = 10, // 0x0000000A
      [Description("2007 onwards"), Category("England")] England_2007_onwards = 11, // 0x0000000B
      [Description("2007 onwards"), Category("Northern Ireland")] NorthernIreland_2007_onwards = 11, // 0x0000000B
      [Description("2008 onwards"), Category("Scotland")] Scotland_2008_onwards = 11, // 0x0000000B
      [Description("not applicable"), Category("Northern Ireland")] NorthernIreland_not_applicable = 99, // 0x00000063
    }

    public enum TenureType
    {
      [Description("Owner-occupied"), Category("Tenure Type Code")] Owner_occupied = 1,
      [Description("Rental (social)"), Category("Tenure Type Code")] Rental_social = 2,
      [Description("Rental (private)"), Category("Tenure Type Code")] Rental_private = 3,
      [Description("Unknown"), Category("Tenure Type Code")] Unknown = 4,
    }

    public enum TransactionType
    {
      [Description("Marketed sale"), Category("Transaction Type Code")] Marketed_sale = 1,
      [Description("non marketed sale"), Category("Transaction Type Code")] non_marketed_sale = 2,
      [Description("Rental (social)"), Category("Transaction Type Code")] Rental_social = 3,
      [Description("Rental (private)"), Category("Transaction Type Code")] Rental_private = 4,
      [Description("None of the above"), Category("Transaction Type Code")] None_of_the_above = 5,
      [Description("Not recorded Compability Only"), Category("Transaction Type Code")] Not_recorded_Backward_Compability_Only = 7,
      [Description("Rental"), Category("Transaction Type Code")] Rental = 8,
      [Description("Assessmenkt for Green Deal)"), Category("Transaction Type Code")] Assessment_for_Green_Deal = 9,
      [Description("Following_Green_Deal"), Category("Transaction Type Code")] Following_Green_Deal = 10, // 0x0000000A
      [Description("FiT application"), Category("Transaction Type Code")] FiT_application = 11, // 0x0000000B
    }

    public enum CloneType
    {
      [Description("Clone"), Category("Clone Type Code")] Clone = 1,
      [Description("Visited"), Category("Clone Type Code")] Visited = 2,
    }

    public enum CountryCode
    {
      [Description("England"), Category("Country Code")] England = 1,
      [Description("Wales"), Category("Country Code")] Wales = 2,
      [Description("Scotland"), Category("Country Code")] Scotland = 3,
      [Description("Northern Ireland"), Category("Country Code")] Northern_Ireland = 4,
    }

    public enum BuildingType
    {
      [Description("House"), Category("Building Type")] House = 1,
      [Description("Bungalow"), Category("Building Type")] Bungalow = 2,
      [Description("Flat"), Category("Building Type")] Flat = 3,
      [Description("Maisonette"), Category("Building Type")] Maisonette = 4,
    }

    public enum PropertyType
    {
      [Description("Detached"), Category("Property Type")] Detached = 1,
      [Description("Semi-Detached"), Category("Property Type")] Semi_Detached = 2,
      [Description("End-Terrace"), Category("Property Type")] End_Terrace = 3,
      [Description("Mid-Terrace"), Category("Property Type")] Mid_Terrace = 4,
      [Description("Enclosed End-Terrace"), Category("Property Type")] Enclosed_End_Terrace = 5,
      [Description("Enclosed Mid-Terrace"), Category("Property Type")] Enclosed_Mid_Terrace = 6,
    }

    public enum LowestFloorType
    {
      [Description("To External Air"), Category("FloorHeatLoss")] Exposed_floor = 1,
      [Description("Semi-exposed upper floor to unheated space"), Category("FloorHeatLoss")] Semi_exposed_upper_floor_to_unheated_space = 2,
      [Description("Semi-exposed upper floor to partially heated space"), Category("FloorHeatLoss")] Semi_exposed_upper_floor_to_partially_heated_space = 3,
      [Description("Other flat below"), Category("FloorHeatLoss")] Other_flat_below = 4,
      [Description("Ground floor"), Category("FloorHeatLoss")] Ground_floor = 5,
      [Description("Same dwelling below"), Category("FloorHeatLoss")] Same_dwelling_below = 6,
      [Description("To External Air"), Category("FloorHeatLoss")] To_External_Air = 7,
    }

    public enum FloorConstructionCode
    {
      [Description("Unknown"), Category("Floor Construction")] Unknown = 1,
      [Description("Solid"), Category("Floor Construction")] Solid = 2,
      [Description("Suspended timber"), Category("Floor Construction")] Suspended_timber = 3,
      [Description("Suspended, not timber"), Category("Floor Construction")] Suspended_not_timber = 4,
      [Description(" Not applicable"), Category("Floor Construction")] Not_applicable = 99, // 0x00000063
    }

    public enum FloorInsulationCode
    {
      [Description("Unknown"), Category("Floor Insulation")] Unknown = 1,
      [Description("As-built"), Category("Floor Insulation")] As_built = 2,
      [Description("Retro-fitted"), Category("Floor Insulation")] Retro_fitted = 3,
      [Description(" Not applicable"), Category("Floor Insulation")] Not_applicable = 99, // 0x00000063
    }

    public enum FloorInsulationThicknessCode
    {
      [Description("Unknown"), Category("Floor Insulation Thickness")] Unknown = 1,
      [Description("50mm"), Category("Floor Insulation Thickness")] _50mm = 2,
      [Description("100mm"), Category("Floor Insulation Thickness")] _100mm = 3,
      [Description("150mm"), Category("Floor Insulation Thickness")] _150mm = 4,
      [Description("U-value known"), Category("Floor Insulation Thickness")] U_value_known = 5,
      [Description(" Not applicable"), Category("Floor Insulation Thickness")] Not_applicable = 99, // 0x00000063
    }

    public enum WallConstructionCode
    {
      [Description("Granite or whinstone"), Category("Wall Construction")] Granite_or_whinstone = 1,
      [Description("Sandstone"), Category("Wall Construction")] Sandstone = 2,
      [Description("solid brick timber"), Category("Wall Construction")] Solid_brick = 3,
      [Description("Cavity"), Category("Wall Construction")] Cavity = 4,
      [Description("Timber frame"), Category("Wall Construction")] Timber_frame = 5,
      [Description("System built"), Category("Wall Construction")] System_built = 6,
      [Description("Cob wall"), Category("Wall Construction")] Cob_wall = 7,
    }

    public enum WallInsulationCode
    {
      [Description("External"), Category("Wall Insulation")] External = 1,
      [Description("Filled cavity"), Category("Wall Insulation")] Filled_cavity = 2,
      [Description("Internal"), Category("Wall Insulation")] Internal = 3,
      [Description("As built"), Category("Wall Insulation")] As_built = 4,
      [Description("Unknown"), Category("Wall Insulation")] Unknown = 5,
      [Description("Filled cavity + external"), Category("Wall Insulation")] Filled_cavity_external = 6,
      [Description("Filled cavity + internal"), Category("Wall Insulation")] Filled_cavity_internal = 7,
    }

    public enum WallInsulationThicknessCode
    {
      [Description("Unknown"), Category("Wall Insulation Thickness")] Unknown = 1,
      [Description("50mm"), Category("Wall Insulation Thickness")] _50mm = 2,
      [Description("100mm"), Category("Wall Insulation Thickness")] _100mm = 3,
      [Description("150mm"), Category("Wall Insulation Thickness")] _150mm = 4,
    }

    public enum RoofConstructionCode
    {
      [Description("None"), Category("Roof Construction")] None = 1,
      [Description("Flat"), Category("Roof Construction")] Flat = 2,
      [Description("Another dwelling above"), Category("Roof Construction")] Another_dwelling_above = 3,
      [Description("Pitched (slates or tiles), access to loft"), Category("Roof Construction")] Pitched_slates_or_tiles_access_to_loft = 4,
      [Description("Pitched (slates or tiles), no access to loft"), Category("Roof Construction")] Pitched_slates_or_tiles_no_access_to_loft = 5,
      [Description("Pitched (thatch)"), Category("Roof Construction")] Pitched_thatch = 6,
      [Description("Same dwelling above"), Category("Roof Construction")] Same_dwelling_above = 7,
    }

    public enum RoofInsulationThicknessCode
    {
      [Description("None"), Category("Roof Insulation Thickness")] None = 1,
      [Description("Unknown"), Category("Roof Insulation Thickness")] Unknown = 2,
      [Description("12mm"), Category("Roof Insulation Thickness")] _12mm = 3,
      [Description("25mm"), Category("Roof Insulation Thickness")] _25mm = 4,
      [Description("50mm"), Category("Roof Insulation Thickness")] _50mm = 5,
      [Description("75mm"), Category("Roof Insulation Thickness")] _75mm = 6,
      [Description("100mm"), Category("Roof Insulation Thickness")] _100mm = 7,
      [Description("150mm"), Category("Roof Insulation Thickness")] _150mm = 8,
      [Description("200mm"), Category("Roof Insulation Thickness")] _200mm = 9,
      [Description("250mm"), Category("Roof Insulation Thickness")] _250mm = 10, // 0x0000000A
      [Description("300mm+"), Category("Roof Insulation Thickness")] _300mm = 11, // 0x0000000B
      [Description("Not Applicable"), Category("Roof Insulation Thickness")] Not_Applicable = 12, // 0x0000000C
    }

    public enum RoofRoomWallAndSlopeThicknessCode
    {
      [Description("Unknown"), Category("Roof Insulation Thickness")] Unknown = 1,
      [Description("50mm"), Category("Roof Insulation Thickness")] _50mm = 2,
      [Description("100mm"), Category("Roof Insulation Thickness")] _100mm = 3,
      [Description("150mm"), Category("Roof Insulation Thickness")] _150mm = 4,
    }

    public enum RoofRafterThicknessCode
    {
      [Description("Unknown"), Category("rafter Insulation Thickness")] Unknown = 1,
      [Description("50mm"), Category("rafter Insulation Thickness")] _50mm = 2,
      [Description("100mm"), Category("rafter Insulation Thickness")] _100mm = 3,
      [Description("150mm"), Category("rafter Insulation Thickness")] _150mm = 4,
    }

    public enum RoofInsulationCode
    {
      [Description("None"), Category("Roof Insulation")] None = 1,
      [Description("Unknown"), Category("Roof Insulation")] Unknown = 2,
      [Description("Rafters"), Category("Roof Insulation")] Rafters = 3,
      [Description("Joists"), Category("Roof Insulation")] Joists = 4,
      [Description("Flat roof insulation"), Category("Roof Insulation")] Flat_roof_insulation = 5,
    }

    public enum RoofRoomInsulationCode
    {
      [Description("Unknown"), Category("Roof Insulation")] Unknown,
      [Description("None"), Category("Roof Insulation")] None,
      [Description("Flat Ceiling Only"), Category("Roof Insulation")] Flat_Ceiling_Only,
      [Description("All Elements"), Category("Roof Insulation")] All_Elements,
    }

    public enum SolarWaterPumpType
    {
      [Description("Unknown"), Category("Solar Water Pump Type")] Unknown = 1,
      [Description("Electrically Powered"), Category("Solar Water Pump Type")] Electrically_Powered = 2,
      [Description("PV powered"), Category("Solar Water Pump Type")] PV_powered = 3,
    }

    public enum SolarCollectorType
    {
      [Description("Unglazed"), Category("CollectorType")] Unglazed = 1,
      [Description("Flat Panel"), Category("CollectorType")] Flat_Panel = 2,
      [Description("Evacuated Tube"), Category("CollectorType")] Evacuated_Tube = 3,
    }
  }
}
