
// Type: SAP2012.SAP_Module




using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;
using uValueCalc;

namespace SAP2012
{
  [StandardModule]
  public sealed class SAP_Module
  {
    public static SAP_Module.AppEnvironment CurrentEnvironment = SAP_Module.AppEnvironment.Live;
    public static SAP_Module.Project Proj;
    public static int RoundFigure = 4;
    public static int CurrDwelling = -1;
    public static string View;
    public static int RowNow;
    public static int ColNow;
    public static DataGridView ControlNow;
    public static bool ChangeNow;
    public static int RowEdit;
    public static bool EditRow;
    public static int FilterCode;
    public static int TableGroup;
    public static List<JunctionDetail> Junctions = new List<JunctionDetail>();
    public static bool Admin = false;
    public static readonly bool dev_mode = Debugger.IsAttached;
    public static ECOForm EcoFormShow = new ECOForm();
    public static PCDF PCDFData;
    public static Calc2012 CalculationFabric = new Calc2012();
    public static Calc2012 CalculationFabricTarget = new Calc2012();
    public static Calc2012 Calculation2012 = new Calc2012();
    public static Calc2012 Calculation2012Regional = new Calc2012();
    public static Calc2012 CalculationImprove2012 = new Calc2012();
    public static Calc2012 CalculationImprove2012Regional = new Calc2012();
    public static Calc2012 CalcualtionDER2012 = new Calc2012();
    public static Calc2012 CalcualtionTER2012 = new Calc2012();
    public static Calc2012 CalcualtionDER_CSH = new Calc2012();
    public static bool CalcRound;
    public static SAP_Module.Dwelling FabricDwelling;
    public static SAP_Module.Dwelling DERDwelling;
    public static SAP_Module.Dwelling DERDwelling_CSH;
    public static SAP_Module.Dwelling TERDwelling;
    public static SAP_Module.Dwelling ScotlandTERDwelling;
    public static SAP_Module.Dwelling ImproveDwelling;
    public static SAP_Module.Dwelling TempDwelling;
    public static AdditionalVariables Add_Variable = new AdditionalVariables();
    public static Improvement_Class Improve = new Improvement_Class();
    public static OverHeatingClass OverHeat = new OverHeatingClass();
    public static bool NoCalc;
    public static string CurrVersion;
    public static int DataBVersion;
    public static string DataBDate;
    public static bool CalcAssessmentLZCPlease;
    public static bool DoCodereport;
    public static string PDFFileName;
    public static string SAPInPutName;
    public static string SAPEPCName;
    public static string TERName;
    public static string DERName;
    public static string SAPImprovedName;
    public static string SAPCheckListName;
    public static string SAPOverHeatingName;
    public static string CostEPCName;
    public static string SAPXMLName;
    public static string PredicatedEPC;
    public static string ZerocarbonEPC;
    public static string ThermalBridge;
    public static string HQMXMLName;
    public static string ScottishFileName;
    public static string HQMXMLPath;
    public static bool ShowBar;
    public static bool DontChange;
    public static DataSet ClientDetails = new DataSet();
    public static string DebugVersion = "1.4.0.16";
    public static AppendixS AppenS = new AppendixS();

    public static string FuelCheck(int Fuel)
    {
      string str;
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
          str = "dual fuel (mineral and wood)";
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
          str = "heat from electric heat pump";
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
        default:
          str = "";
          break;
      }
      return str;
    }

    public static string GetCategory(Enum EnumConstant)
    {
      CategoryAttribute[] customAttributes = (CategoryAttribute[]) EnumConstant.GetType().GetField(EnumConstant.ToString()).GetCustomAttributes(typeof (CategoryAttribute), false);
      return customAttributes.Length > 0 ? customAttributes[0].Category : EnumConstant.ToString();
    }

    public static string Get_Enum_Desc(System.Type value_enum, int value)
    {
      FieldInfo[] fields = value_enum.GetFields(BindingFlags.Static | BindingFlags.Public);
      int num = checked (fields.Length - 1);
      int index = 0;
      while (index <= num)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(fields[index].GetRawConstantValue(), (object) value, false))
        {
          DescriptionAttribute[] customAttributes = (DescriptionAttribute[]) fields[index].GetCustomAttributes(typeof (DescriptionAttribute), false);
          if (customAttributes.Length > 0)
            return customAttributes[0].Description.ToString();
          break;
        }
        checked { ++index; }
      }
      return "";
    }

    public enum MECType
    {
      Centralised = 1,
      DeCentralised = 2,
    }

    public enum HeatingType
    {
      MainHeating = 1,
      SecMainHeating = 2,
    }

    public enum AppEnvironment
    {
      Live,
      Uat,
    }

    [Serializable]
    public struct Dwelling
    {
      public object ReplaceMe;
      public bool OverrideEne7;
      public string Name;
      public int ID;
      public string Reference;
      public string SAPOnly;
      public string Overheat;
      public string Status;
      public DateTime DateAssessment;
      public DateTime DateCertificate;
      public string Transaction;
      public string Tenure;
      public string RPD;
      public SAP_Module.TMP TMP;
      public SAP_Module.Address Address;
      public string UPRN;
      public string PropertyType;
      public string BuildForm;
      public string FlatType;
      public int YearBuilt;
      public string Location;
      public int ShelteredSides;
      public string Terrain;
      public string Orientation;
      public string AirCon;
      public string Conservatory;
      public float LowEnergyLight;
      public int LELOutlets;
      public int LELLights;
      public string EPCLanguage;
      public string SmokeArea;
      public string Overshading;
      public bool LessThan125Litre;
      public int Storeys;
      public bool TrueRoof;
      public float LivingArea;
      public float LivingFraction;
      public bool LivingFractionSpecified;
      public SAP_Module.Dimensions[] Dims;
      public int NoofFloors;
      public bool GrossAreas;
      public SAP_Module.Thermal Thermal;
      public SAP_Module.Opaques[] Floors;
      public int NoofpFloors;
      public SAP_Module.PartyElements[] PFloors;
      public int NoofIFloors;
      public SAP_Module.PartyElements[] IFloors;
      public int NoofWalls;
      public SAP_Module.Opaques[] Walls;
      public int NoofPWalls;
      public SAP_Module.PartyWall[] PWalls;
      public int NoofIWalls;
      public SAP_Module.PartyElements[] IWalls;
      public int NoofRoofs;
      public SAP_Module.Opaques[] Roofs;
      public int NoofPCeilings;
      public SAP_Module.PartyElements[] PCeilings;
      public int NoofICeilings;
      public SAP_Module.PartyElements[] ICeilings;
      public int NoofDoors;
      public SAP_Module.Door[] Doors;
      public int NoofWindows;
      public SAP_Module.Window[] Windows;
      public int NoofRoofLights;
      public SAP_Module.RoofLight[] RoofLights;
      public SAP_Module.Ventilation Ventilation;
      public SAP_Module.CoolingSystem Cooling;
      public SAP_Module.MainHeating MainHeating;
      public SAP_Module.MainHeating MainHeating2;
      public bool IncludeMainHeating2;
      public float HeatFractionSec;
      public bool Include_SecMain_Heat_Separat_Part;
      public bool Include_SecMain_Heat_Whole;
      public SAP_Module.SecHeating SecHeating;
      public SAP_Module.Water Water;
      public SAP_Module.ReNewable Renewable;
      public SAP_Module.OverHeating OverHeating;
      public SAP_Module.Validation Validation;
      public SAP_Module.Lodgement[] Lodgement;
      public SAP_Module.HQMLLodgement[] HQMLodgemnt;
      public int LodgementAttempts;
      public int HQMLAttempts;
      public int NoOfScotGraphs;
      public bool DisplayScotFrontpageOnly;
      public bool SimplifiedApproach;
      public int MaxStoreys;
      public string Comments;
      public DateTime DateDwellingCreated;
      public int NoOFDwellingsAbove;
      public int NoOFDwellingsBelow;
      public bool Imported09;
      public double ImportedYvalue;
      public bool WaterOnlyHeatPump;
    }

    [Serializable]
    public struct Block
    {
      public string Name;
      public SAP_Module.Block_Dwellings[] Dwellings;
      public float TFA;
      public float AveDER;
      public float AveTER;
      public float AveDFEE;
      public float AveTFEE;
      public string Compliance;
    }

    [Serializable]
    public struct Block_Dwellings
    {
      public int ID;
      public string Name;
      public string Reference;
    }

    [Serializable]
    public struct TMP
    {
      public string Type;
      public string Indicative;
      public float UserDefined;
    }

    [Serializable]
    public struct Project
    {
      public DateTime ProjectDate;
      public string Name;
      public int NoOfDwells;
      public SAP_Module.Dwelling[] Dwellings;
      public string Reference;
      public SAP_Module.Address Address;
      public SAP_Module.Client Client;
      public string SaveFileName;
      public int NoofBlocks;
      public SAP_Module.Block[] Blocks;
      public Output.UProj SAPUValues;
      public string Version;
      public string CalcVersion;
      public bool OverRide;
      public string Comments;
    }

    [Serializable]
    public struct Address
    {
      public string Line1;
      public string Line2;
      public string Line3;
      public string City;
      public string Country;
      public string PostCost;
    }

    [Serializable]
    public struct Client
    {
      public string Name;
      public SAP_Module.Address Address;
      public string Phone;
      public string Fax;
      public string Email;
    }

    [Serializable]
    public struct Dimensions
    {
      public string Basement;
      public float Area;
      public float Perimeter;
      public float Height;
      public SAP_Module.Dims Dims;
      public int Type;
      public int Floor;
    }

    [Serializable]
    public struct WWHRSSystem
    {
      public bool Include;
      public SAP_Module.WWHRS_Systems[] Systems;
      public float TotalRooms;
    }

    [Serializable]
    public struct WWHRS_Systems
    {
      public string SystemsRef;
      public float DedicatedStorage;
      public int WithBath;
      public int WithNoBath;
    }

    [Serializable]
    public struct Opaques
    {
      public string Name;
      public string Type;
      public string Construction;
      public float Area;
      public float U_Value;
      public float Ru;
      public bool Curtain;
      public float K;
      public SAP_Module.Dims Dims;
      public int UValueSelection;
      public bool UValueSelected;
      public string EPCDesc;
      public string LoftInsulation;
      public bool UvalueKnown;
    }

    [Serializable]
    public struct PartyWall
    {
      public string Name;
      public string Type;
      public string Construction;
      public float Area;
      public float U_Value;
      public float K;
      public SAP_Module.Dims Dims;
    }

    [Serializable]
    public struct PartyElements
    {
      public string Name;
      public string Construction;
      public float Area;
      public float K;
      public SAP_Module.Dims Dims;
    }

    [Serializable]
    public struct Window
    {
      public string Name;
      public string Location;
      public string UValueSource;
      public string Orientation;
      public string Overshading;
      public string GlazingType;
      public string AirGap;
      public string FrameType;
      public string ThermalBreak;
      public float Area;
      public float Width;
      public float Height;
      public int Count;
      public float OverhangWidth;
      public float OverhangDepth;
      public string CurtainType;
      public float FractionClosed;
      public float g;
      public float FF;
      public float U;
      public string OpeningType;
    }

    [Serializable]
    public struct Door
    {
      public string Name;
      public string Location;
      public string UValueSource;
      public string DoorType;
      public string Orientation;
      public string Overshading;
      public string GlazingType;
      public string AirGap;
      public string FrameType;
      public string ThermalBreak;
      public float Area;
      public float Width;
      public float Height;
      public int Count;
      public float g;
      public float FF;
      public float U;
      public string OpeningType;
    }

    [Serializable]
    public struct Thermal
    {
      public bool ManualHtb;
      public float HtbValue;
      public string ConstDetails;
      public bool ManualY;
      public float YValue;
      public List<SAP_Module.Junction> ExternalJunctions;
      public List<SAP_Module.Junction> PartyJunctions;
      public List<SAP_Module.Junction> RoofJunctions;
      public string Reference;
    }

    [Serializable]
    public struct Junction
    {
      public string Ref;
      public string JunctionDetail;
      public float ThermalTransmittance;
      public float Length;
      public bool IsAccredited;
      public bool IsDefault;
      public double Accredited;
      public double Defaul;
      public int Id;
      public string Notes;
      public bool RowIDCreated;
      public bool ImportLenght;
    }

    [Serializable]
    public struct RoofLight
    {
      public string Name;
      public string Location;
      public string UValueSource;
      public float Pitch;
      public string Orientation;
      public string Overshading;
      public string GlazingType;
      public string AirGap;
      public string FrameType;
      public string ThermalBreak;
      public float Area;
      public float Width;
      public float Height;
      public int Count;
      public float OverhangWidth;
      public float OverhangDepth;
      public string CurtainType;
      public float FractionClosed;
      public float g;
      public float FF;
      public float U;
      public string OpeningType;
    }

    [Serializable]
    public struct Ventilation
    {
      public int ChimneysMain;
      public int ChimneysSec;
      public int ChimneysOther;
      public int Chimneys;
      public int FluesMain;
      public int FluesSec;
      public int FluesOther;
      public int Flues;
      public int Fans;
      public int Vents;
      public int Fires;
      public float Shelter;
      public string MechVent;
      public string Parameters;
      public int WetRooms;
      public string DuctType;
      public int ProductID;
      public string ProductName;
      public bool ApprovedScheme;
      public SAP_Module.Decentralised Decentralised;
      public SAP_Module.MVDetails MVDetails;
      public string Pressure;
      public float DesignAir;
      public float MeasuredAir;
      public DateTime DateAir;
      public float AssumedAir;
      public bool AveragePerm;
      public SAP_Module.Infiltration Infiltration;
      public float Draught;
      public bool MultiSystem;
    }

    [Serializable]
    public struct Decentralised
    {
      public float KSPF1;
      public float KSPF2;
      public float KSPF3;
      public float OSPF1;
      public float OSPF2;
      public float OSPF3;
      public float KTP1;
      public float KTP2;
      public float KTP3;
      public float OTP1;
      public float OTP2;
      public float OTP3;
    }

    [Serializable]
    public struct MVDetails
    {
      public string ProductName;
      public string DuctingType;
      public float SFP;
      public float HEE;
      public bool UseDuctTable;
      public string DuctProductID;
    }

    [Serializable]
    public struct Infiltration
    {
      public string Construction;
      public string Lobby;
      public string Floor;
      public float DraguthP;
    }

    [Serializable]
    public struct PhotoVoltaics
    {
      public int ID;
      public float PPower;
      public string PTilt;
      public string PCOrientation;
      public string POvershading;
      public bool DirectlyConnected;
      public string FlatConnection;
    }

    [Serializable]
    public struct MainHeating
    {
      public string ElectricityTariff;
      public string HGroup;
      public string SGroup;
      public string InforSource;
      public string BSubGroup;
      public string MHType;
      public string Emitter;
      public string ControlCapability;
      public string Controls;
      public bool DelayedStart;
      public string Fuel;
      public string SEDBUK;
      public SAP_Module.Boiler Boiler;
      public List<SAP_Module.StorageHeater> StorageHeaters;
      public float MainEff;
      public int SAPTableCode;
      public int ControlCode;
      public int TableGroup;
      public string HETAS;
      public string Compensator;
      public SAP_Module.Range Range;
      public SAP_Module.CommunityH CommunityH;
      public bool OilPump;
      public bool SEDBUK2005;
      public bool SEDBUK2009;
      public string FuelBurningType;
      public string ControlCodePCDF;
      public string ControlFuel;
      public string ControlCategory;
      public string ControlCodePCDFWeather;
      public string ControlDelayedStart;
      public bool MCSCert;
      public SAP_Module.HeatOnlyPump HPOnly;
      public bool IntegralPFGHRS;
    }

    [Serializable]
    public struct HeatOnlyPump
    {
      public bool HotWaterOnlyHP;
      public bool HotWaterHP_Integral;
      public int Vol;
      public float DeclaredValue;
      public bool ManuSpecified;
      public double SummaerEff;
      public double WinterEff;
    }

    [Serializable]
    public class StorageHeater
    {
      public int Number_Of_Heaters { get; set; }

      public string Index_Number { get; set; }

      public string ManuName { get; set; }

      public string BrandName { get; set; }

      public string ModelName { get; set; }
    }

    [Serializable]
    public struct SecHeating
    {
      public string HGroup;
      public string SGroup;
      public string InforSource;
      public string MHType;
      public string TestMethod;
      public string Fuel;
      public string HETAS;
      public float SecEff;
      public int SAPTableCode;
      public string MDescription;
      public string FlueType;
    }

    [Serializable]
    public struct FlueGasHeatRecoverySystem
    {
      public bool Include;
      public string IndexNo;
      public SAP_Module.Photovoltaic PV;
    }

    [Serializable]
    public struct CoolingSystem
    {
      public bool Include;
      public string SystemType;
      public string Energylabel;
      public string Compressorcontrol;
      public string Cooled_Area;
      public bool ERRMeasuredInclude;
      public float ERR;
      public string Description;
    }

    [Serializable]
    public struct Boiler
    {
      public string PumpHP;
      public string PumpType;
      public string BILock;
      public string Description;
      public string FlueType;
      public string FanFlued;
      public bool IncludeKeepHot;
      public string KeepHotFuel;
      public bool KeepHotTimed;
      public bool LoadWeather;
      public string LoadWeatherType;
      public string FlowTemp;
    }

    [Serializable]
    public struct Water
    {
      public SAP_Module.SolarWater Solar;
      public string System;
      public int SystemRef;
      public string Fuel;
      public SAP_Module.Cylinder Cylinder;
      public float CPSUTemp;
      public SAP_Module.HWSComm HWSComm;
      public SAP_Module.ThermalStore Thermal;
      public string CombiType;
      public SAP_Module.WWHRSSystem WWHRS;
      public SAP_Module.FlueGasHeatRecoverySystem FGHRS;
      public bool DHWVessel;
    }

    [Serializable]
    public struct SolarWater
    {
      public bool Inlcude;
      public string SolarType;
      public bool Overide;
      public float SolarZero;
      public float SolarHLoss;
      public float SolarHLoss2;
      public float SolarArea;
      public bool Gross;
      public string SolarTilt;
      public string SolarOrientation;
      public string SolarOvershading;
      public float SolarVolume;
      public bool SolarSeperate;
      public bool Pumped;
      public string ShowerType;
    }

    [Serializable]
    public struct HWSComm
    {
      public bool CylinderInDwelling;
      public float CHPRatio;
      public bool KnownLossFactor;
      public float LossFactor;
      public float CHPPowerEff;
      public string HDS;
      public float Efficiency;
      public float Boiler1Fraction;
      public string Charging;
      public int NoOfAdditionalHeatSources;
      public bool FromDatabase;
      public string SystemRef;
      public SAP_Module.HeatSources HeatSource1;
      public SAP_Module.HeatSources HeatSource2;
      public SAP_Module.HeatSources HeatSource3;
      public SAP_Module.HeatSources HeatSource4;
    }

    [Serializable]
    public struct Photovoltaic
    {
      public bool Inlcude;
      public SAP_Module.PhotoVoltaics[] Photovoltaics;
      public float PPower;
      public string PTilt;
      public string PCOrientation;
      public string POvershading;
    }

    [Serializable]
    public struct WindTurbine
    {
      public bool Inlcude;
      public int WNumber;
      public string WRDiameter;
      public string WHeight;
    }

    [Serializable]
    public struct ReNewable
    {
      public SAP_Module.WindTurbine WindTurbine;
      public SAP_Module.Photovoltaic Photovoltaic;
      public SAP_Module.Special Special;
      public SAP_Module.AAEGeneration AAEGeneration;
      public SAP_Module.HydroGeneration HydroGeneration;
    }

    [Serializable]
    public struct Special
    {
      public bool Include;
      public SAP_Module.SpecialFeatures[] Special;
      public string Description;
      public float EnergySaved;
      public string FuelSaved;
      public float EnergyUsed;
      public string FuelUsed;
    }

    [Serializable]
    public struct SpecialFeatures
    {
      public bool Include;
      public int ID;
      public string Description;
      public float EnergySaved;
      public string FuelSaved;
      public float EnergyUsed;
      public string FuelUsed;
      public bool IncludeMonthly;
      public bool MakeEmissionsOnly;
      public float EmissionsAmount;
      public float EmissionsAmountCreated;
      public float M1;
      public float M2;
      public float M3;
      public float M4;
      public float M5;
      public float M6;
      public float M7;
      public float M8;
      public float M9;
      public float M10;
      public float M11;
      public float M12;
    }

    [Serializable]
    public struct AAEGeneration
    {
      public bool Inlcude;
      public float EGenerated;
      public string TotalArea;
    }

    [Serializable]
    public struct HydroGeneration
    {
      public bool Inlcude;
      public float HydroGenerated;
      public string TotalArea;
    }

    [Serializable]
    public struct OverHeating
    {
      public string EACBuildType;
      public string EACWindow;
      public bool EACOveride;
      public float EACAirChange;
      public bool Night;
      public int TMIllustrative;
      public bool TMOveride;
      public float TMTMP;
    }

    [Serializable]
    public struct Cylinder
    {
      public float Volume;
      public bool ManuSpecified;
      public float DeclaredLoss;
      public string Insulation;
      public float InsThick;
      public bool InHeatedSpace;
      public bool Thermostat;
      public bool PipeWorkInsulated;
      public string PipeWorkInsulationType;
      public bool Timed;
      public bool SummerImmersion;
      public string Immersion;
      public string HPImmersion;
      public float HPExchanger;
    }

    [Serializable]
    public struct ThermalStore
    {
      public bool Include;
      public string Type;
      public string Location;
      public string Connection;
    }

    [Serializable]
    public struct Range
    {
      public float CasekW;
      public float WaterkW;
    }

    [Serializable]
    public struct CommunityH
    {
      public float Boiler1Efficiency;
      public float Boiler1HeatFraction;
      public string HeatDSystem;
      public float HeatToPowerRatio;
      public int NoOfAdditionalHeatSources;
      public SAP_Module.HeatSources HeatSource1;
      public SAP_Module.HeatSources HeatSource2;
      public SAP_Module.HeatSources HeatSource3;
      public SAP_Module.HeatSources HeatSource4;
      public bool Boiler2CHP;
      public float Boiler2CHPEfficiency;
      public float CHPHeatFraction;
      public float CHPHeatEfficiency;
      public float CHPElectricalEfficiency;
      public string Boiler2CHPFuel;
      public bool KnownLoss;
      public float KnownLossValue;
    }

    [Serializable]
    public struct HeatSources
    {
      public int Type;
      public string Fuel;
      public float HeatFraction;
      public float Efficiency;
    }

    [Serializable]
    public struct Validation
    {
      public bool Property_Check;
      public bool Dims_Check;
      public bool Opaque_Check;
      public bool Openings_Check;
      public bool Ventilation_Check;
      public bool Heating_Check;
      public bool WaterHeating_Check;
      public bool RenewablesTech_Check;
      public bool OverHeating_Check;
    }

    [Serializable]
    public struct HQMLLodgement
    {
      public DateTime DateLodged;
      public bool Success;
      public string Result;
      public string RRN;
      public SAP_Module.Results SAP;
      public SAP_Module.Results PSAP;
      public string Method;
    }

    [Serializable]
    public struct Lodgement
    {
      public DateTime DateLodged;
      public bool Success;
      public string Result;
      public string RRN;
      public SAP_Module.Results SAP;
      public SAP_Module.Results PSAP;
      public string Method;
    }

    [Serializable]
    public struct Results
    {
      public int SAPRating;
      public string SAPBand;
      public int EIRating;
      public string EIBand;
    }

    [Serializable]
    public struct Dims
    {
      public float L1;
      public float W1;
      public float L2;
      public float W2;
      public float L3;
      public float W3;
      public float L4;
      public float W4;
      public float L5;
      public float W5;
      public float L6;
      public float W6;
    }
  }
}
