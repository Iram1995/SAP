
// Type: SAP2012.SAP09Data.ComplianceDetails




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace SAP2012.SAP09Data
{
  [DebuggerStepThrough]
  [GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
  [DataContract(Name = "ComplianceDetails", Namespace = "http://rdsap2009.stroma.com/SAPData/SAP09Compliance.asmx")]
  [Serializable]
  public class ComplianceDetails : IExtensibleDataObject, INotifyPropertyChanged
  {
    [NonSerialized]
    private ExtensionDataObject extensionDataField;
    private int ProjectIDField;
    [OptionalField]
    private string UserIDField;
    [OptionalField]
    private string CountryField;
    [OptionalField]
    private string BuildFormField;
    [OptionalField]
    private string DwellingTypeField;
    [OptionalField]
    private string SiteReferenceField;
    [OptionalField]
    private string PlotReferenceField;
    [OptionalField]
    private string AddressLine1Field;
    [OptionalField]
    private string AddressLine2Field;
    [OptionalField]
    private string AddressLine3Field;
    [OptionalField]
    private string CityField;
    [OptionalField]
    private string PostcodeField;
    [OptionalField]
    private string ClientNameField;
    [OptionalField]
    private string Client_AddressLine1Field;
    [OptionalField]
    private string Client_AddressLine2Field;
    [OptionalField]
    private string Client_AddressLine3Field;
    [OptionalField]
    private string Client_CityField;
    [OptionalField]
    private string Client_postcodeField;
    [OptionalField]
    private string MainHeating_fuelField;
    private double DERField;
    private double TERField;
    private double Wall_Average_UField;
    private double Wall_Highest_UField;
    private bool IncludeWallField;
    private bool IncludePWallField;
    private double PWall_Average_UField;
    private bool IncludeFloorsField;
    private double Floor_Average_UField;
    private bool IncludeRoofField;
    private double Roof_Average_UField;
    private bool IncludeCurtainwallField;
    private double Curtainwall_UField;
    private bool IncludeWindowsField;
    private double WindowsAverage_UField;
    private double WindowsHighest_UField;
    [OptionalField]
    private string AirPermeability_DESCField;
    private double AirPermeability_AirPermeability_ValueField;
    private bool CPSUFoundField;
    [OptionalField]
    private string HeatingSourceField;
    [OptionalField]
    private string SEDBUKCodeField;
    [OptionalField]
    private string BoilerSGroupField;
    [OptionalField]
    private string BoilerHGroupField;
    [OptionalField]
    private string MainFuelField;
    private bool SEDBUK2005Field;
    private double MainEffField;
    private bool SAP_DefaultDataField;
    private bool IncludeMainHeating2Field;
    [OptionalField]
    private string SEDBUKCode2Field;
    [OptionalField]
    private string SAPCodeField;
    [OptionalField]
    private string HeatingSource2Field;
    [OptionalField]
    private string BoilerSGroup2Field;
    [OptionalField]
    private string BoilerHGroup2Field;
    [OptionalField]
    private string MainFuel2Field;
    [OptionalField]
    private string SAPCode2Field;
    [OptionalField]
    private string SEDBUK2005_2Field;
    [OptionalField]
    private string MainEff2Field;
    private bool SAP_DefaultData2Field;
    private bool Include_SecondaryHeatingField;
    [OptionalField]
    private string SecHeating_FuelField;
    private double Sec_SAPTableCodeField;
    private double SecHeatingEffField;
    [OptionalField]
    private string water_SystemRefField;
    [OptionalField]
    private string Water_CylinderVolumeField;
    [OptionalField]
    private string Water_CylinderFoundField;
    private bool IncludeWaterThermalField;
    private double CylinderValueField;
    private double CylinderValuePermittedField;
    private bool WaterCylinderImmersionField;
    [OptionalField]
    private string WaterFuelField;
    [OptionalField]
    private string Primary_pipework_insulatedField;
    private bool InlcudePrimary_PipeworkField;
    private bool Include_SolarWaterField;
    private double SolarVolumeField;
    private double SolarAreaField;
    private double SolarLimitField;
    [OptionalField]
    private string MainHeatingControlField;
    private int NoofFloorsField;
    private double LivingFractionField;
    private double FloorAreaField;
    private bool IncludeHeatingControl2Field;
    [OptionalField]
    private string MainHeatingControl2Field;
    private bool CylinderstatField;
    private bool IndependentTimerField;
    private bool BoilerInterlockField;
    private double LowEnergyLight_PercentField;
    [OptionalField]
    private string MechVentField;
    [OptionalField]
    private string Vent_ParametersField;
    [OptionalField]
    private string Specific_fan_powerField;
    private bool IncludeOverheatingField;
    [OptionalField]
    private string HouseLocationField;
    [OptionalField]
    private string OverHeatingLikelihoodField;
    [OptionalField]
    private string OvershadingField;
    private int NoofWindowsField;
    private int NoofRoofLightsField;
    private double VentilationRateField;
    [OptionalField]
    private string CurtainTypeField;
    private bool IncludeKeyfeaturesField;
    private bool Key_ThermalbridgingField;
    private bool Key_DesignAir_permeablilityField;
    private bool Key_Roof_Window_UField;
    private bool Key_Door_UField;
    private bool Key_Roof_UField;
    private bool Key_External_Wall_UField;
    private bool Key_micro_CogenerationField;
    private bool Key_Community_HeatingField;
    private bool Key_microCogenerationField;
    private bool Key_Photovaltaic_ArrayField;
    private bool Key_Wind_TurbineField;
    private bool Key_Appendix_QField;
    private bool Key_Fixed_CoolingField;
    private bool Key_Allow_Electricity_GenerationField;
    private bool Key_Secondary_HeatingField;
    private bool Key_Solar_water_heatingField;

    [Browsable(false)]
    public ExtensionDataObject ExtensionData
    {
      get => this.extensionDataField;
      set => this.extensionDataField = value;
    }

    [DataMember(IsRequired = true)]
    public int ProjectID
    {
      get => this.ProjectIDField;
      set
      {
        if (this.ProjectIDField.Equals(value))
          return;
        this.ProjectIDField = value;
        this.RaisePropertyChanged(nameof (ProjectID));
      }
    }

    [DataMember(EmitDefaultValue = false)]
    public string UserID
    {
      get => this.UserIDField;
      set
      {
        if (object.ReferenceEquals((object) this.UserIDField, (object) value))
          return;
        this.UserIDField = value;
        this.RaisePropertyChanged(nameof (UserID));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 2)]
    public string Country
    {
      get => this.CountryField;
      set
      {
        if (object.ReferenceEquals((object) this.CountryField, (object) value))
          return;
        this.CountryField = value;
        this.RaisePropertyChanged(nameof (Country));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 3)]
    public string BuildForm
    {
      get => this.BuildFormField;
      set
      {
        if (object.ReferenceEquals((object) this.BuildFormField, (object) value))
          return;
        this.BuildFormField = value;
        this.RaisePropertyChanged(nameof (BuildForm));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 4)]
    public string DwellingType
    {
      get => this.DwellingTypeField;
      set
      {
        if (object.ReferenceEquals((object) this.DwellingTypeField, (object) value))
          return;
        this.DwellingTypeField = value;
        this.RaisePropertyChanged(nameof (DwellingType));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 5)]
    public string SiteReference
    {
      get => this.SiteReferenceField;
      set
      {
        if (object.ReferenceEquals((object) this.SiteReferenceField, (object) value))
          return;
        this.SiteReferenceField = value;
        this.RaisePropertyChanged(nameof (SiteReference));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 6)]
    public string PlotReference
    {
      get => this.PlotReferenceField;
      set
      {
        if (object.ReferenceEquals((object) this.PlotReferenceField, (object) value))
          return;
        this.PlotReferenceField = value;
        this.RaisePropertyChanged(nameof (PlotReference));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 7)]
    public string AddressLine1
    {
      get => this.AddressLine1Field;
      set
      {
        if (object.ReferenceEquals((object) this.AddressLine1Field, (object) value))
          return;
        this.AddressLine1Field = value;
        this.RaisePropertyChanged(nameof (AddressLine1));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 8)]
    public string AddressLine2
    {
      get => this.AddressLine2Field;
      set
      {
        if (object.ReferenceEquals((object) this.AddressLine2Field, (object) value))
          return;
        this.AddressLine2Field = value;
        this.RaisePropertyChanged(nameof (AddressLine2));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 9)]
    public string AddressLine3
    {
      get => this.AddressLine3Field;
      set
      {
        if (object.ReferenceEquals((object) this.AddressLine3Field, (object) value))
          return;
        this.AddressLine3Field = value;
        this.RaisePropertyChanged(nameof (AddressLine3));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 10)]
    public string City
    {
      get => this.CityField;
      set
      {
        if (object.ReferenceEquals((object) this.CityField, (object) value))
          return;
        this.CityField = value;
        this.RaisePropertyChanged(nameof (City));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 11)]
    public string Postcode
    {
      get => this.PostcodeField;
      set
      {
        if (object.ReferenceEquals((object) this.PostcodeField, (object) value))
          return;
        this.PostcodeField = value;
        this.RaisePropertyChanged(nameof (Postcode));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 12)]
    public string ClientName
    {
      get => this.ClientNameField;
      set
      {
        if (object.ReferenceEquals((object) this.ClientNameField, (object) value))
          return;
        this.ClientNameField = value;
        this.RaisePropertyChanged(nameof (ClientName));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 13)]
    public string Client_AddressLine1
    {
      get => this.Client_AddressLine1Field;
      set
      {
        if (object.ReferenceEquals((object) this.Client_AddressLine1Field, (object) value))
          return;
        this.Client_AddressLine1Field = value;
        this.RaisePropertyChanged(nameof (Client_AddressLine1));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 14)]
    public string Client_AddressLine2
    {
      get => this.Client_AddressLine2Field;
      set
      {
        if (object.ReferenceEquals((object) this.Client_AddressLine2Field, (object) value))
          return;
        this.Client_AddressLine2Field = value;
        this.RaisePropertyChanged(nameof (Client_AddressLine2));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 15)]
    public string Client_AddressLine3
    {
      get => this.Client_AddressLine3Field;
      set
      {
        if (object.ReferenceEquals((object) this.Client_AddressLine3Field, (object) value))
          return;
        this.Client_AddressLine3Field = value;
        this.RaisePropertyChanged(nameof (Client_AddressLine3));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 16)]
    public string Client_City
    {
      get => this.Client_CityField;
      set
      {
        if (object.ReferenceEquals((object) this.Client_CityField, (object) value))
          return;
        this.Client_CityField = value;
        this.RaisePropertyChanged(nameof (Client_City));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 17)]
    public string Client_postcode
    {
      get => this.Client_postcodeField;
      set
      {
        if (object.ReferenceEquals((object) this.Client_postcodeField, (object) value))
          return;
        this.Client_postcodeField = value;
        this.RaisePropertyChanged(nameof (Client_postcode));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 18)]
    public string MainHeating_fuel
    {
      get => this.MainHeating_fuelField;
      set
      {
        if (object.ReferenceEquals((object) this.MainHeating_fuelField, (object) value))
          return;
        this.MainHeating_fuelField = value;
        this.RaisePropertyChanged(nameof (MainHeating_fuel));
      }
    }

    [DataMember(IsRequired = true, Order = 19)]
    public double DER
    {
      get => this.DERField;
      set
      {
        if (this.DERField.Equals(value))
          return;
        this.DERField = value;
        this.RaisePropertyChanged(nameof (DER));
      }
    }

    [DataMember(IsRequired = true, Order = 20)]
    public double TER
    {
      get => this.TERField;
      set
      {
        if (this.TERField.Equals(value))
          return;
        this.TERField = value;
        this.RaisePropertyChanged(nameof (TER));
      }
    }

    [DataMember(IsRequired = true, Order = 21)]
    public double Wall_Average_U
    {
      get => this.Wall_Average_UField;
      set
      {
        if (this.Wall_Average_UField.Equals(value))
          return;
        this.Wall_Average_UField = value;
        this.RaisePropertyChanged(nameof (Wall_Average_U));
      }
    }

    [DataMember(IsRequired = true, Order = 22)]
    public double Wall_Highest_U
    {
      get => this.Wall_Highest_UField;
      set
      {
        if (this.Wall_Highest_UField.Equals(value))
          return;
        this.Wall_Highest_UField = value;
        this.RaisePropertyChanged(nameof (Wall_Highest_U));
      }
    }

    [DataMember(IsRequired = true, Order = 23)]
    public bool IncludeWall
    {
      get => this.IncludeWallField;
      set
      {
        if (this.IncludeWallField.Equals(value))
          return;
        this.IncludeWallField = value;
        this.RaisePropertyChanged(nameof (IncludeWall));
      }
    }

    [DataMember(IsRequired = true, Order = 24)]
    public bool IncludePWall
    {
      get => this.IncludePWallField;
      set
      {
        if (this.IncludePWallField.Equals(value))
          return;
        this.IncludePWallField = value;
        this.RaisePropertyChanged(nameof (IncludePWall));
      }
    }

    [DataMember(IsRequired = true, Order = 25)]
    public double PWall_Average_U
    {
      get => this.PWall_Average_UField;
      set
      {
        if (this.PWall_Average_UField.Equals(value))
          return;
        this.PWall_Average_UField = value;
        this.RaisePropertyChanged(nameof (PWall_Average_U));
      }
    }

    [DataMember(IsRequired = true, Order = 26)]
    public bool IncludeFloors
    {
      get => this.IncludeFloorsField;
      set
      {
        if (this.IncludeFloorsField.Equals(value))
          return;
        this.IncludeFloorsField = value;
        this.RaisePropertyChanged(nameof (IncludeFloors));
      }
    }

    [DataMember(IsRequired = true, Order = 27)]
    public double Floor_Average_U
    {
      get => this.Floor_Average_UField;
      set
      {
        if (this.Floor_Average_UField.Equals(value))
          return;
        this.Floor_Average_UField = value;
        this.RaisePropertyChanged(nameof (Floor_Average_U));
      }
    }

    [DataMember(IsRequired = true, Order = 28)]
    public bool IncludeRoof
    {
      get => this.IncludeRoofField;
      set
      {
        if (this.IncludeRoofField.Equals(value))
          return;
        this.IncludeRoofField = value;
        this.RaisePropertyChanged(nameof (IncludeRoof));
      }
    }

    [DataMember(IsRequired = true, Order = 29)]
    public double Roof_Average_U
    {
      get => this.Roof_Average_UField;
      set
      {
        if (this.Roof_Average_UField.Equals(value))
          return;
        this.Roof_Average_UField = value;
        this.RaisePropertyChanged(nameof (Roof_Average_U));
      }
    }

    [DataMember(IsRequired = true, Order = 30)]
    public bool IncludeCurtainwall
    {
      get => this.IncludeCurtainwallField;
      set
      {
        if (this.IncludeCurtainwallField.Equals(value))
          return;
        this.IncludeCurtainwallField = value;
        this.RaisePropertyChanged(nameof (IncludeCurtainwall));
      }
    }

    [DataMember(IsRequired = true, Order = 31)]
    public double Curtainwall_U
    {
      get => this.Curtainwall_UField;
      set
      {
        if (this.Curtainwall_UField.Equals(value))
          return;
        this.Curtainwall_UField = value;
        this.RaisePropertyChanged(nameof (Curtainwall_U));
      }
    }

    [DataMember(IsRequired = true, Order = 32)]
    public bool IncludeWindows
    {
      get => this.IncludeWindowsField;
      set
      {
        if (this.IncludeWindowsField.Equals(value))
          return;
        this.IncludeWindowsField = value;
        this.RaisePropertyChanged(nameof (IncludeWindows));
      }
    }

    [DataMember(IsRequired = true, Order = 33)]
    public double WindowsAverage_U
    {
      get => this.WindowsAverage_UField;
      set
      {
        if (this.WindowsAverage_UField.Equals(value))
          return;
        this.WindowsAverage_UField = value;
        this.RaisePropertyChanged(nameof (WindowsAverage_U));
      }
    }

    [DataMember(IsRequired = true, Order = 34)]
    public double WindowsHighest_U
    {
      get => this.WindowsHighest_UField;
      set
      {
        if (this.WindowsHighest_UField.Equals(value))
          return;
        this.WindowsHighest_UField = value;
        this.RaisePropertyChanged(nameof (WindowsHighest_U));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 35)]
    public string AirPermeability_DESC
    {
      get => this.AirPermeability_DESCField;
      set
      {
        if (object.ReferenceEquals((object) this.AirPermeability_DESCField, (object) value))
          return;
        this.AirPermeability_DESCField = value;
        this.RaisePropertyChanged(nameof (AirPermeability_DESC));
      }
    }

    [DataMember(IsRequired = true, Order = 36)]
    public double AirPermeability_AirPermeability_Value
    {
      get => this.AirPermeability_AirPermeability_ValueField;
      set
      {
        if (this.AirPermeability_AirPermeability_ValueField.Equals(value))
          return;
        this.AirPermeability_AirPermeability_ValueField = value;
        this.RaisePropertyChanged(nameof (AirPermeability_AirPermeability_Value));
      }
    }

    [DataMember(IsRequired = true, Order = 37)]
    public bool CPSUFound
    {
      get => this.CPSUFoundField;
      set
      {
        if (this.CPSUFoundField.Equals(value))
          return;
        this.CPSUFoundField = value;
        this.RaisePropertyChanged(nameof (CPSUFound));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 38)]
    public string HeatingSource
    {
      get => this.HeatingSourceField;
      set
      {
        if (object.ReferenceEquals((object) this.HeatingSourceField, (object) value))
          return;
        this.HeatingSourceField = value;
        this.RaisePropertyChanged(nameof (HeatingSource));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 39)]
    public string SEDBUKCode
    {
      get => this.SEDBUKCodeField;
      set
      {
        if (object.ReferenceEquals((object) this.SEDBUKCodeField, (object) value))
          return;
        this.SEDBUKCodeField = value;
        this.RaisePropertyChanged(nameof (SEDBUKCode));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 40)]
    public string BoilerSGroup
    {
      get => this.BoilerSGroupField;
      set
      {
        if (object.ReferenceEquals((object) this.BoilerSGroupField, (object) value))
          return;
        this.BoilerSGroupField = value;
        this.RaisePropertyChanged(nameof (BoilerSGroup));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 41)]
    public string BoilerHGroup
    {
      get => this.BoilerHGroupField;
      set
      {
        if (object.ReferenceEquals((object) this.BoilerHGroupField, (object) value))
          return;
        this.BoilerHGroupField = value;
        this.RaisePropertyChanged(nameof (BoilerHGroup));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 42)]
    public string MainFuel
    {
      get => this.MainFuelField;
      set
      {
        if (object.ReferenceEquals((object) this.MainFuelField, (object) value))
          return;
        this.MainFuelField = value;
        this.RaisePropertyChanged(nameof (MainFuel));
      }
    }

    [DataMember(IsRequired = true, Order = 43)]
    public bool SEDBUK2005
    {
      get => this.SEDBUK2005Field;
      set
      {
        if (this.SEDBUK2005Field.Equals(value))
          return;
        this.SEDBUK2005Field = value;
        this.RaisePropertyChanged(nameof (SEDBUK2005));
      }
    }

    [DataMember(IsRequired = true, Order = 44)]
    public double MainEff
    {
      get => this.MainEffField;
      set
      {
        if (this.MainEffField.Equals(value))
          return;
        this.MainEffField = value;
        this.RaisePropertyChanged(nameof (MainEff));
      }
    }

    [DataMember(IsRequired = true, Order = 45)]
    public bool SAP_DefaultData
    {
      get => this.SAP_DefaultDataField;
      set
      {
        if (this.SAP_DefaultDataField.Equals(value))
          return;
        this.SAP_DefaultDataField = value;
        this.RaisePropertyChanged(nameof (SAP_DefaultData));
      }
    }

    [DataMember(IsRequired = true, Order = 46)]
    public bool IncludeMainHeating2
    {
      get => this.IncludeMainHeating2Field;
      set
      {
        if (this.IncludeMainHeating2Field.Equals(value))
          return;
        this.IncludeMainHeating2Field = value;
        this.RaisePropertyChanged(nameof (IncludeMainHeating2));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 47)]
    public string SEDBUKCode2
    {
      get => this.SEDBUKCode2Field;
      set
      {
        if (object.ReferenceEquals((object) this.SEDBUKCode2Field, (object) value))
          return;
        this.SEDBUKCode2Field = value;
        this.RaisePropertyChanged(nameof (SEDBUKCode2));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 48)]
    public string SAPCode
    {
      get => this.SAPCodeField;
      set
      {
        if (object.ReferenceEquals((object) this.SAPCodeField, (object) value))
          return;
        this.SAPCodeField = value;
        this.RaisePropertyChanged(nameof (SAPCode));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 49)]
    public string HeatingSource2
    {
      get => this.HeatingSource2Field;
      set
      {
        if (object.ReferenceEquals((object) this.HeatingSource2Field, (object) value))
          return;
        this.HeatingSource2Field = value;
        this.RaisePropertyChanged(nameof (HeatingSource2));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 50)]
    public string BoilerSGroup2
    {
      get => this.BoilerSGroup2Field;
      set
      {
        if (object.ReferenceEquals((object) this.BoilerSGroup2Field, (object) value))
          return;
        this.BoilerSGroup2Field = value;
        this.RaisePropertyChanged(nameof (BoilerSGroup2));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 51)]
    public string BoilerHGroup2
    {
      get => this.BoilerHGroup2Field;
      set
      {
        if (object.ReferenceEquals((object) this.BoilerHGroup2Field, (object) value))
          return;
        this.BoilerHGroup2Field = value;
        this.RaisePropertyChanged(nameof (BoilerHGroup2));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 52)]
    public string MainFuel2
    {
      get => this.MainFuel2Field;
      set
      {
        if (object.ReferenceEquals((object) this.MainFuel2Field, (object) value))
          return;
        this.MainFuel2Field = value;
        this.RaisePropertyChanged(nameof (MainFuel2));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 53)]
    public string SAPCode2
    {
      get => this.SAPCode2Field;
      set
      {
        if (object.ReferenceEquals((object) this.SAPCode2Field, (object) value))
          return;
        this.SAPCode2Field = value;
        this.RaisePropertyChanged(nameof (SAPCode2));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 54)]
    public string SEDBUK2005_2
    {
      get => this.SEDBUK2005_2Field;
      set
      {
        if (object.ReferenceEquals((object) this.SEDBUK2005_2Field, (object) value))
          return;
        this.SEDBUK2005_2Field = value;
        this.RaisePropertyChanged(nameof (SEDBUK2005_2));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 55)]
    public string MainEff2
    {
      get => this.MainEff2Field;
      set
      {
        if (object.ReferenceEquals((object) this.MainEff2Field, (object) value))
          return;
        this.MainEff2Field = value;
        this.RaisePropertyChanged(nameof (MainEff2));
      }
    }

    [DataMember(IsRequired = true, Order = 56)]
    public bool SAP_DefaultData2
    {
      get => this.SAP_DefaultData2Field;
      set
      {
        if (this.SAP_DefaultData2Field.Equals(value))
          return;
        this.SAP_DefaultData2Field = value;
        this.RaisePropertyChanged(nameof (SAP_DefaultData2));
      }
    }

    [DataMember(IsRequired = true, Order = 57)]
    public bool Include_SecondaryHeating
    {
      get => this.Include_SecondaryHeatingField;
      set
      {
        if (this.Include_SecondaryHeatingField.Equals(value))
          return;
        this.Include_SecondaryHeatingField = value;
        this.RaisePropertyChanged(nameof (Include_SecondaryHeating));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 58)]
    public string SecHeating_Fuel
    {
      get => this.SecHeating_FuelField;
      set
      {
        if (object.ReferenceEquals((object) this.SecHeating_FuelField, (object) value))
          return;
        this.SecHeating_FuelField = value;
        this.RaisePropertyChanged(nameof (SecHeating_Fuel));
      }
    }

    [DataMember(IsRequired = true, Order = 59)]
    public double Sec_SAPTableCode
    {
      get => this.Sec_SAPTableCodeField;
      set
      {
        if (this.Sec_SAPTableCodeField.Equals(value))
          return;
        this.Sec_SAPTableCodeField = value;
        this.RaisePropertyChanged(nameof (Sec_SAPTableCode));
      }
    }

    [DataMember(IsRequired = true, Order = 60)]
    public double SecHeatingEff
    {
      get => this.SecHeatingEffField;
      set
      {
        if (this.SecHeatingEffField.Equals(value))
          return;
        this.SecHeatingEffField = value;
        this.RaisePropertyChanged(nameof (SecHeatingEff));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 61)]
    public string water_SystemRef
    {
      get => this.water_SystemRefField;
      set
      {
        if (object.ReferenceEquals((object) this.water_SystemRefField, (object) value))
          return;
        this.water_SystemRefField = value;
        this.RaisePropertyChanged(nameof (water_SystemRef));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 62)]
    public string Water_CylinderVolume
    {
      get => this.Water_CylinderVolumeField;
      set
      {
        if (object.ReferenceEquals((object) this.Water_CylinderVolumeField, (object) value))
          return;
        this.Water_CylinderVolumeField = value;
        this.RaisePropertyChanged(nameof (Water_CylinderVolume));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 63)]
    public string Water_CylinderFound
    {
      get => this.Water_CylinderFoundField;
      set
      {
        if (object.ReferenceEquals((object) this.Water_CylinderFoundField, (object) value))
          return;
        this.Water_CylinderFoundField = value;
        this.RaisePropertyChanged(nameof (Water_CylinderFound));
      }
    }

    [DataMember(IsRequired = true, Order = 64)]
    public bool IncludeWaterThermal
    {
      get => this.IncludeWaterThermalField;
      set
      {
        if (this.IncludeWaterThermalField.Equals(value))
          return;
        this.IncludeWaterThermalField = value;
        this.RaisePropertyChanged(nameof (IncludeWaterThermal));
      }
    }

    [DataMember(IsRequired = true, Order = 65)]
    public double CylinderValue
    {
      get => this.CylinderValueField;
      set
      {
        if (this.CylinderValueField.Equals(value))
          return;
        this.CylinderValueField = value;
        this.RaisePropertyChanged(nameof (CylinderValue));
      }
    }

    [DataMember(IsRequired = true, Order = 66)]
    public double CylinderValuePermitted
    {
      get => this.CylinderValuePermittedField;
      set
      {
        if (this.CylinderValuePermittedField.Equals(value))
          return;
        this.CylinderValuePermittedField = value;
        this.RaisePropertyChanged(nameof (CylinderValuePermitted));
      }
    }

    [DataMember(IsRequired = true, Order = 67)]
    public bool WaterCylinderImmersion
    {
      get => this.WaterCylinderImmersionField;
      set
      {
        if (this.WaterCylinderImmersionField.Equals(value))
          return;
        this.WaterCylinderImmersionField = value;
        this.RaisePropertyChanged(nameof (WaterCylinderImmersion));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 68)]
    public string WaterFuel
    {
      get => this.WaterFuelField;
      set
      {
        if (object.ReferenceEquals((object) this.WaterFuelField, (object) value))
          return;
        this.WaterFuelField = value;
        this.RaisePropertyChanged(nameof (WaterFuel));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 69)]
    public string Primary_pipework_insulated
    {
      get => this.Primary_pipework_insulatedField;
      set
      {
        if (object.ReferenceEquals((object) this.Primary_pipework_insulatedField, (object) value))
          return;
        this.Primary_pipework_insulatedField = value;
        this.RaisePropertyChanged(nameof (Primary_pipework_insulated));
      }
    }

    [DataMember(IsRequired = true, Order = 70)]
    public bool InlcudePrimary_Pipework
    {
      get => this.InlcudePrimary_PipeworkField;
      set
      {
        if (this.InlcudePrimary_PipeworkField.Equals(value))
          return;
        this.InlcudePrimary_PipeworkField = value;
        this.RaisePropertyChanged(nameof (InlcudePrimary_Pipework));
      }
    }

    [DataMember(IsRequired = true, Order = 71)]
    public bool Include_SolarWater
    {
      get => this.Include_SolarWaterField;
      set
      {
        if (this.Include_SolarWaterField.Equals(value))
          return;
        this.Include_SolarWaterField = value;
        this.RaisePropertyChanged(nameof (Include_SolarWater));
      }
    }

    [DataMember(IsRequired = true, Order = 72)]
    public double SolarVolume
    {
      get => this.SolarVolumeField;
      set
      {
        if (this.SolarVolumeField.Equals(value))
          return;
        this.SolarVolumeField = value;
        this.RaisePropertyChanged(nameof (SolarVolume));
      }
    }

    [DataMember(IsRequired = true, Order = 73)]
    public double SolarArea
    {
      get => this.SolarAreaField;
      set
      {
        if (this.SolarAreaField.Equals(value))
          return;
        this.SolarAreaField = value;
        this.RaisePropertyChanged(nameof (SolarArea));
      }
    }

    [DataMember(IsRequired = true, Order = 74)]
    public double SolarLimit
    {
      get => this.SolarLimitField;
      set
      {
        if (this.SolarLimitField.Equals(value))
          return;
        this.SolarLimitField = value;
        this.RaisePropertyChanged(nameof (SolarLimit));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 75)]
    public string MainHeatingControl
    {
      get => this.MainHeatingControlField;
      set
      {
        if (object.ReferenceEquals((object) this.MainHeatingControlField, (object) value))
          return;
        this.MainHeatingControlField = value;
        this.RaisePropertyChanged(nameof (MainHeatingControl));
      }
    }

    [DataMember(IsRequired = true, Order = 76)]
    public int NoofFloors
    {
      get => this.NoofFloorsField;
      set
      {
        if (this.NoofFloorsField.Equals(value))
          return;
        this.NoofFloorsField = value;
        this.RaisePropertyChanged(nameof (NoofFloors));
      }
    }

    [DataMember(IsRequired = true, Order = 77)]
    public double LivingFraction
    {
      get => this.LivingFractionField;
      set
      {
        if (this.LivingFractionField.Equals(value))
          return;
        this.LivingFractionField = value;
        this.RaisePropertyChanged(nameof (LivingFraction));
      }
    }

    [DataMember(IsRequired = true, Order = 78)]
    public double FloorArea
    {
      get => this.FloorAreaField;
      set
      {
        if (this.FloorAreaField.Equals(value))
          return;
        this.FloorAreaField = value;
        this.RaisePropertyChanged(nameof (FloorArea));
      }
    }

    [DataMember(IsRequired = true, Order = 79)]
    public bool IncludeHeatingControl2
    {
      get => this.IncludeHeatingControl2Field;
      set
      {
        if (this.IncludeHeatingControl2Field.Equals(value))
          return;
        this.IncludeHeatingControl2Field = value;
        this.RaisePropertyChanged(nameof (IncludeHeatingControl2));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 80)]
    public string MainHeatingControl2
    {
      get => this.MainHeatingControl2Field;
      set
      {
        if (object.ReferenceEquals((object) this.MainHeatingControl2Field, (object) value))
          return;
        this.MainHeatingControl2Field = value;
        this.RaisePropertyChanged(nameof (MainHeatingControl2));
      }
    }

    [DataMember(IsRequired = true, Order = 81)]
    public bool Cylinderstat
    {
      get => this.CylinderstatField;
      set
      {
        if (this.CylinderstatField.Equals(value))
          return;
        this.CylinderstatField = value;
        this.RaisePropertyChanged(nameof (Cylinderstat));
      }
    }

    [DataMember(IsRequired = true, Order = 82)]
    public bool IndependentTimer
    {
      get => this.IndependentTimerField;
      set
      {
        if (this.IndependentTimerField.Equals(value))
          return;
        this.IndependentTimerField = value;
        this.RaisePropertyChanged(nameof (IndependentTimer));
      }
    }

    [DataMember(IsRequired = true, Order = 83)]
    public bool BoilerInterlock
    {
      get => this.BoilerInterlockField;
      set
      {
        if (this.BoilerInterlockField.Equals(value))
          return;
        this.BoilerInterlockField = value;
        this.RaisePropertyChanged(nameof (BoilerInterlock));
      }
    }

    [DataMember(IsRequired = true, Order = 84)]
    public double LowEnergyLight_Percent
    {
      get => this.LowEnergyLight_PercentField;
      set
      {
        if (this.LowEnergyLight_PercentField.Equals(value))
          return;
        this.LowEnergyLight_PercentField = value;
        this.RaisePropertyChanged(nameof (LowEnergyLight_Percent));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 85)]
    public string MechVent
    {
      get => this.MechVentField;
      set
      {
        if (object.ReferenceEquals((object) this.MechVentField, (object) value))
          return;
        this.MechVentField = value;
        this.RaisePropertyChanged(nameof (MechVent));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 86)]
    public string Vent_Parameters
    {
      get => this.Vent_ParametersField;
      set
      {
        if (object.ReferenceEquals((object) this.Vent_ParametersField, (object) value))
          return;
        this.Vent_ParametersField = value;
        this.RaisePropertyChanged(nameof (Vent_Parameters));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 87)]
    public string Specific_fan_power
    {
      get => this.Specific_fan_powerField;
      set
      {
        if (object.ReferenceEquals((object) this.Specific_fan_powerField, (object) value))
          return;
        this.Specific_fan_powerField = value;
        this.RaisePropertyChanged(nameof (Specific_fan_power));
      }
    }

    [DataMember(IsRequired = true, Order = 88)]
    public bool IncludeOverheating
    {
      get => this.IncludeOverheatingField;
      set
      {
        if (this.IncludeOverheatingField.Equals(value))
          return;
        this.IncludeOverheatingField = value;
        this.RaisePropertyChanged(nameof (IncludeOverheating));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 89)]
    public string HouseLocation
    {
      get => this.HouseLocationField;
      set
      {
        if (object.ReferenceEquals((object) this.HouseLocationField, (object) value))
          return;
        this.HouseLocationField = value;
        this.RaisePropertyChanged(nameof (HouseLocation));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 90)]
    public string OverHeatingLikelihood
    {
      get => this.OverHeatingLikelihoodField;
      set
      {
        if (object.ReferenceEquals((object) this.OverHeatingLikelihoodField, (object) value))
          return;
        this.OverHeatingLikelihoodField = value;
        this.RaisePropertyChanged(nameof (OverHeatingLikelihood));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 91)]
    public string Overshading
    {
      get => this.OvershadingField;
      set
      {
        if (object.ReferenceEquals((object) this.OvershadingField, (object) value))
          return;
        this.OvershadingField = value;
        this.RaisePropertyChanged(nameof (Overshading));
      }
    }

    [DataMember(IsRequired = true, Order = 92)]
    public int NoofWindows
    {
      get => this.NoofWindowsField;
      set
      {
        if (this.NoofWindowsField.Equals(value))
          return;
        this.NoofWindowsField = value;
        this.RaisePropertyChanged(nameof (NoofWindows));
      }
    }

    [DataMember(IsRequired = true, Order = 93)]
    public int NoofRoofLights
    {
      get => this.NoofRoofLightsField;
      set
      {
        if (this.NoofRoofLightsField.Equals(value))
          return;
        this.NoofRoofLightsField = value;
        this.RaisePropertyChanged(nameof (NoofRoofLights));
      }
    }

    [DataMember(IsRequired = true, Order = 94)]
    public double VentilationRate
    {
      get => this.VentilationRateField;
      set
      {
        if (this.VentilationRateField.Equals(value))
          return;
        this.VentilationRateField = value;
        this.RaisePropertyChanged(nameof (VentilationRate));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 95)]
    public string CurtainType
    {
      get => this.CurtainTypeField;
      set
      {
        if (object.ReferenceEquals((object) this.CurtainTypeField, (object) value))
          return;
        this.CurtainTypeField = value;
        this.RaisePropertyChanged(nameof (CurtainType));
      }
    }

    [DataMember(IsRequired = true, Order = 96)]
    public bool IncludeKeyfeatures
    {
      get => this.IncludeKeyfeaturesField;
      set
      {
        if (this.IncludeKeyfeaturesField.Equals(value))
          return;
        this.IncludeKeyfeaturesField = value;
        this.RaisePropertyChanged(nameof (IncludeKeyfeatures));
      }
    }

    [DataMember(IsRequired = true, Order = 97)]
    public bool Key_Thermalbridging
    {
      get => this.Key_ThermalbridgingField;
      set
      {
        if (this.Key_ThermalbridgingField.Equals(value))
          return;
        this.Key_ThermalbridgingField = value;
        this.RaisePropertyChanged(nameof (Key_Thermalbridging));
      }
    }

    [DataMember(IsRequired = true, Order = 98)]
    public bool Key_DesignAir_permeablility
    {
      get => this.Key_DesignAir_permeablilityField;
      set
      {
        if (this.Key_DesignAir_permeablilityField.Equals(value))
          return;
        this.Key_DesignAir_permeablilityField = value;
        this.RaisePropertyChanged(nameof (Key_DesignAir_permeablility));
      }
    }

    [DataMember(IsRequired = true, Order = 99)]
    public bool Key_Roof_Window_U
    {
      get => this.Key_Roof_Window_UField;
      set
      {
        if (this.Key_Roof_Window_UField.Equals(value))
          return;
        this.Key_Roof_Window_UField = value;
        this.RaisePropertyChanged(nameof (Key_Roof_Window_U));
      }
    }

    [DataMember(IsRequired = true, Order = 100)]
    public bool Key_Door_U
    {
      get => this.Key_Door_UField;
      set
      {
        if (this.Key_Door_UField.Equals(value))
          return;
        this.Key_Door_UField = value;
        this.RaisePropertyChanged(nameof (Key_Door_U));
      }
    }

    [DataMember(IsRequired = true, Order = 101)]
    public bool Key_Roof_U
    {
      get => this.Key_Roof_UField;
      set
      {
        if (this.Key_Roof_UField.Equals(value))
          return;
        this.Key_Roof_UField = value;
        this.RaisePropertyChanged(nameof (Key_Roof_U));
      }
    }

    [DataMember(IsRequired = true, Order = 102)]
    public bool Key_External_Wall_U
    {
      get => this.Key_External_Wall_UField;
      set
      {
        if (this.Key_External_Wall_UField.Equals(value))
          return;
        this.Key_External_Wall_UField = value;
        this.RaisePropertyChanged(nameof (Key_External_Wall_U));
      }
    }

    [DataMember(IsRequired = true, Order = 103)]
    public bool Key_micro_Cogeneration
    {
      get => this.Key_micro_CogenerationField;
      set
      {
        if (this.Key_micro_CogenerationField.Equals(value))
          return;
        this.Key_micro_CogenerationField = value;
        this.RaisePropertyChanged(nameof (Key_micro_Cogeneration));
      }
    }

    [DataMember(IsRequired = true, Order = 104)]
    public bool Key_Community_Heating
    {
      get => this.Key_Community_HeatingField;
      set
      {
        if (this.Key_Community_HeatingField.Equals(value))
          return;
        this.Key_Community_HeatingField = value;
        this.RaisePropertyChanged(nameof (Key_Community_Heating));
      }
    }

    [DataMember(IsRequired = true, Order = 105)]
    public bool Key_microCogeneration
    {
      get => this.Key_microCogenerationField;
      set
      {
        if (this.Key_microCogenerationField.Equals(value))
          return;
        this.Key_microCogenerationField = value;
        this.RaisePropertyChanged(nameof (Key_microCogeneration));
      }
    }

    [DataMember(IsRequired = true, Order = 106)]
    public bool Key_Photovaltaic_Array
    {
      get => this.Key_Photovaltaic_ArrayField;
      set
      {
        if (this.Key_Photovaltaic_ArrayField.Equals(value))
          return;
        this.Key_Photovaltaic_ArrayField = value;
        this.RaisePropertyChanged(nameof (Key_Photovaltaic_Array));
      }
    }

    [DataMember(IsRequired = true, Order = 107)]
    public bool Key_Wind_Turbine
    {
      get => this.Key_Wind_TurbineField;
      set
      {
        if (this.Key_Wind_TurbineField.Equals(value))
          return;
        this.Key_Wind_TurbineField = value;
        this.RaisePropertyChanged(nameof (Key_Wind_Turbine));
      }
    }

    [DataMember(IsRequired = true, Order = 108)]
    public bool Key_Appendix_Q
    {
      get => this.Key_Appendix_QField;
      set
      {
        if (this.Key_Appendix_QField.Equals(value))
          return;
        this.Key_Appendix_QField = value;
        this.RaisePropertyChanged(nameof (Key_Appendix_Q));
      }
    }

    [DataMember(IsRequired = true, Order = 109)]
    public bool Key_Fixed_Cooling
    {
      get => this.Key_Fixed_CoolingField;
      set
      {
        if (this.Key_Fixed_CoolingField.Equals(value))
          return;
        this.Key_Fixed_CoolingField = value;
        this.RaisePropertyChanged(nameof (Key_Fixed_Cooling));
      }
    }

    [DataMember(IsRequired = true, Order = 110)]
    public bool Key_Allow_Electricity_Generation
    {
      get => this.Key_Allow_Electricity_GenerationField;
      set
      {
        if (this.Key_Allow_Electricity_GenerationField.Equals(value))
          return;
        this.Key_Allow_Electricity_GenerationField = value;
        this.RaisePropertyChanged(nameof (Key_Allow_Electricity_Generation));
      }
    }

    [DataMember(IsRequired = true, Order = 111)]
    public bool Key_Secondary_Heating
    {
      get => this.Key_Secondary_HeatingField;
      set
      {
        if (this.Key_Secondary_HeatingField.Equals(value))
          return;
        this.Key_Secondary_HeatingField = value;
        this.RaisePropertyChanged(nameof (Key_Secondary_Heating));
      }
    }

    [DataMember(IsRequired = true, Order = 112)]
    public bool Key_Solar_water_heating
    {
      get => this.Key_Solar_water_heatingField;
      set
      {
        if (this.Key_Solar_water_heatingField.Equals(value))
          return;
        this.Key_Solar_water_heatingField = value;
        this.RaisePropertyChanged(nameof (Key_Solar_water_heating));
      }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected void RaisePropertyChanged(string propertyName)
    {
      // ISSUE: reference to a compiler-generated field
      PropertyChangedEventHandler propertyChangedEvent = this.PropertyChangedEvent;
      if (propertyChangedEvent == null)
        return;
      propertyChangedEvent((object) this, new PropertyChangedEventArgs(propertyName));
    }
  }
}
