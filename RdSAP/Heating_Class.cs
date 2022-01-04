
// Type: SAP2012.RdSAP.Heating_Class




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace SAP2012.RdSAP
{
  [DebuggerStepThrough]
  [GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
  [DataContract(Name = "Heating_Class", Namespace = "http://schemas.datacontract.org/2004/07/StromaServices")]
  [Serializable]
  public class Heating_Class : IExtensibleDataObject, INotifyPropertyChanged
  {
    [NonSerialized]
    private ExtensionDataObject extensionDataField;
    [OptionalField]
    private int BoilerCodeField;
    [OptionalField]
    private int BoilerFlueTypeField;
    [OptionalField]
    private bool BoilerInterlockField;
    [OptionalField]
    private int CommunityNetworkIndexField;
    [OptionalField]
    private int ControlsCodeField;
    [OptionalField]
    private string ControlsIndexNumberField;
    [OptionalField]
    private int DataSourceField;
    [OptionalField]
    private int EmitterTypeField;
    [OptionalField]
    private bool FGHRPVIncludeField;
    [OptionalField]
    private int FGHRPVOrientationField;
    [OptionalField]
    private int FGHRPVOvershadingField;
    [OptionalField]
    private double FGHRPVPeakPowerField;
    [OptionalField]
    private int FGHRPVPitchField;
    [OptionalField]
    private int FGHRSIndexNumField;
    [OptionalField]
    private bool FanFluePresentField;
    [OptionalField]
    private int FlowTempField;
    [OptionalField]
    private double FractionField;
    [OptionalField]
    private int FuelField;
    [OptionalField]
    private bool HETASApprovedField;
    [OptionalField]
    private bool HasFGHRSField;
    [OptionalField]
    private bool HasWeatherCompensatorField;
    [OptionalField]
    private string HeatingDescField;
    [OptionalField]
    private bool MCSInstalledField;
    [OptionalField]
    private bool MainHeatingField;
    [OptionalField]
    private bool PresentField;
    [OptionalField]
    private int PrimaryTypeField;
    [OptionalField]
    private int PumpAgeField;
    [OptionalField]
    private int SAPCodeField;
    [OptionalField]
    private int SecondaryTypeField;
    [OptionalField]
    private Heating_Class.StorageHeater[] StorageHeatersField;
    [OptionalField]
    private string WeatherCompensatorIndexNumberField;

    [Browsable(false)]
    public ExtensionDataObject ExtensionData
    {
      get => this.extensionDataField;
      set => this.extensionDataField = value;
    }

    [DataMember]
    public int BoilerCode
    {
      get => this.BoilerCodeField;
      set
      {
        if (this.BoilerCodeField.Equals(value))
          return;
        this.BoilerCodeField = value;
        this.RaisePropertyChanged(nameof (BoilerCode));
      }
    }

    [DataMember]
    public int BoilerFlueType
    {
      get => this.BoilerFlueTypeField;
      set
      {
        if (this.BoilerFlueTypeField.Equals(value))
          return;
        this.BoilerFlueTypeField = value;
        this.RaisePropertyChanged(nameof (BoilerFlueType));
      }
    }

    [DataMember]
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

    [DataMember]
    public int CommunityNetworkIndex
    {
      get => this.CommunityNetworkIndexField;
      set
      {
        if (this.CommunityNetworkIndexField.Equals(value))
          return;
        this.CommunityNetworkIndexField = value;
        this.RaisePropertyChanged(nameof (CommunityNetworkIndex));
      }
    }

    [DataMember]
    public int ControlsCode
    {
      get => this.ControlsCodeField;
      set
      {
        if (this.ControlsCodeField.Equals(value))
          return;
        this.ControlsCodeField = value;
        this.RaisePropertyChanged(nameof (ControlsCode));
      }
    }

    [DataMember]
    public string ControlsIndexNumber
    {
      get => this.ControlsIndexNumberField;
      set
      {
        if (object.ReferenceEquals((object) this.ControlsIndexNumberField, (object) value))
          return;
        this.ControlsIndexNumberField = value;
        this.RaisePropertyChanged(nameof (ControlsIndexNumber));
      }
    }

    [DataMember]
    public int DataSource
    {
      get => this.DataSourceField;
      set
      {
        if (this.DataSourceField.Equals(value))
          return;
        this.DataSourceField = value;
        this.RaisePropertyChanged(nameof (DataSource));
      }
    }

    [DataMember]
    public int EmitterType
    {
      get => this.EmitterTypeField;
      set
      {
        if (this.EmitterTypeField.Equals(value))
          return;
        this.EmitterTypeField = value;
        this.RaisePropertyChanged(nameof (EmitterType));
      }
    }

    [DataMember]
    public bool FGHRPVInclude
    {
      get => this.FGHRPVIncludeField;
      set
      {
        if (this.FGHRPVIncludeField.Equals(value))
          return;
        this.FGHRPVIncludeField = value;
        this.RaisePropertyChanged(nameof (FGHRPVInclude));
      }
    }

    [DataMember]
    public int FGHRPVOrientation
    {
      get => this.FGHRPVOrientationField;
      set
      {
        if (this.FGHRPVOrientationField.Equals(value))
          return;
        this.FGHRPVOrientationField = value;
        this.RaisePropertyChanged(nameof (FGHRPVOrientation));
      }
    }

    [DataMember]
    public int FGHRPVOvershading
    {
      get => this.FGHRPVOvershadingField;
      set
      {
        if (this.FGHRPVOvershadingField.Equals(value))
          return;
        this.FGHRPVOvershadingField = value;
        this.RaisePropertyChanged(nameof (FGHRPVOvershading));
      }
    }

    [DataMember]
    public double FGHRPVPeakPower
    {
      get => this.FGHRPVPeakPowerField;
      set
      {
        if (this.FGHRPVPeakPowerField.Equals(value))
          return;
        this.FGHRPVPeakPowerField = value;
        this.RaisePropertyChanged(nameof (FGHRPVPeakPower));
      }
    }

    [DataMember]
    public int FGHRPVPitch
    {
      get => this.FGHRPVPitchField;
      set
      {
        if (this.FGHRPVPitchField.Equals(value))
          return;
        this.FGHRPVPitchField = value;
        this.RaisePropertyChanged(nameof (FGHRPVPitch));
      }
    }

    [DataMember]
    public int FGHRSIndexNum
    {
      get => this.FGHRSIndexNumField;
      set
      {
        if (this.FGHRSIndexNumField.Equals(value))
          return;
        this.FGHRSIndexNumField = value;
        this.RaisePropertyChanged(nameof (FGHRSIndexNum));
      }
    }

    [DataMember]
    public bool FanFluePresent
    {
      get => this.FanFluePresentField;
      set
      {
        if (this.FanFluePresentField.Equals(value))
          return;
        this.FanFluePresentField = value;
        this.RaisePropertyChanged(nameof (FanFluePresent));
      }
    }

    [DataMember]
    public int FlowTemp
    {
      get => this.FlowTempField;
      set
      {
        if (this.FlowTempField.Equals(value))
          return;
        this.FlowTempField = value;
        this.RaisePropertyChanged(nameof (FlowTemp));
      }
    }

    [DataMember]
    public double Fraction
    {
      get => this.FractionField;
      set
      {
        if (this.FractionField.Equals(value))
          return;
        this.FractionField = value;
        this.RaisePropertyChanged(nameof (Fraction));
      }
    }

    [DataMember]
    public int Fuel
    {
      get => this.FuelField;
      set
      {
        if (this.FuelField.Equals(value))
          return;
        this.FuelField = value;
        this.RaisePropertyChanged(nameof (Fuel));
      }
    }

    [DataMember]
    public bool HETASApproved
    {
      get => this.HETASApprovedField;
      set
      {
        if (this.HETASApprovedField.Equals(value))
          return;
        this.HETASApprovedField = value;
        this.RaisePropertyChanged(nameof (HETASApproved));
      }
    }

    [DataMember]
    public bool HasFGHRS
    {
      get => this.HasFGHRSField;
      set
      {
        if (this.HasFGHRSField.Equals(value))
          return;
        this.HasFGHRSField = value;
        this.RaisePropertyChanged(nameof (HasFGHRS));
      }
    }

    [DataMember]
    public bool HasWeatherCompensator
    {
      get => this.HasWeatherCompensatorField;
      set
      {
        if (this.HasWeatherCompensatorField.Equals(value))
          return;
        this.HasWeatherCompensatorField = value;
        this.RaisePropertyChanged(nameof (HasWeatherCompensator));
      }
    }

    [DataMember]
    public string HeatingDesc
    {
      get => this.HeatingDescField;
      set
      {
        if (object.ReferenceEquals((object) this.HeatingDescField, (object) value))
          return;
        this.HeatingDescField = value;
        this.RaisePropertyChanged(nameof (HeatingDesc));
      }
    }

    [DataMember]
    public bool MCSInstalled
    {
      get => this.MCSInstalledField;
      set
      {
        if (this.MCSInstalledField.Equals(value))
          return;
        this.MCSInstalledField = value;
        this.RaisePropertyChanged(nameof (MCSInstalled));
      }
    }

    [DataMember]
    public bool MainHeating
    {
      get => this.MainHeatingField;
      set
      {
        if (this.MainHeatingField.Equals(value))
          return;
        this.MainHeatingField = value;
        this.RaisePropertyChanged(nameof (MainHeating));
      }
    }

    [DataMember]
    public bool Present
    {
      get => this.PresentField;
      set
      {
        if (this.PresentField.Equals(value))
          return;
        this.PresentField = value;
        this.RaisePropertyChanged(nameof (Present));
      }
    }

    [DataMember]
    public int PrimaryType
    {
      get => this.PrimaryTypeField;
      set
      {
        if (this.PrimaryTypeField.Equals(value))
          return;
        this.PrimaryTypeField = value;
        this.RaisePropertyChanged(nameof (PrimaryType));
      }
    }

    [DataMember]
    public int PumpAge
    {
      get => this.PumpAgeField;
      set
      {
        if (this.PumpAgeField.Equals(value))
          return;
        this.PumpAgeField = value;
        this.RaisePropertyChanged(nameof (PumpAge));
      }
    }

    [DataMember]
    public int SAPCode
    {
      get => this.SAPCodeField;
      set
      {
        if (this.SAPCodeField.Equals(value))
          return;
        this.SAPCodeField = value;
        this.RaisePropertyChanged(nameof (SAPCode));
      }
    }

    [DataMember]
    public int SecondaryType
    {
      get => this.SecondaryTypeField;
      set
      {
        if (this.SecondaryTypeField.Equals(value))
          return;
        this.SecondaryTypeField = value;
        this.RaisePropertyChanged(nameof (SecondaryType));
      }
    }

    [DataMember]
    public Heating_Class.StorageHeater[] StorageHeaters
    {
      get => this.StorageHeatersField;
      set
      {
        if (object.ReferenceEquals((object) this.StorageHeatersField, (object) value))
          return;
        this.StorageHeatersField = value;
        this.RaisePropertyChanged(nameof (StorageHeaters));
      }
    }

    [DataMember]
    public string WeatherCompensatorIndexNumber
    {
      get => this.WeatherCompensatorIndexNumberField;
      set
      {
        if (object.ReferenceEquals((object) this.WeatherCompensatorIndexNumberField, (object) value))
          return;
        this.WeatherCompensatorIndexNumberField = value;
        this.RaisePropertyChanged(nameof (WeatherCompensatorIndexNumber));
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

    [DebuggerStepThrough]
    [GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
    [DataContract(Name = "Heating_Class.StorageHeater", Namespace = "http://schemas.datacontract.org/2004/07/StromaServices")]
    [Serializable]
    public class StorageHeater : IExtensibleDataObject, INotifyPropertyChanged
    {
      [NonSerialized]
      private ExtensionDataObject extensionDataField;
      [OptionalField]
      private string BrandNameField;
      [OptionalField]
      private string Index_NumberField;
      [OptionalField]
      private string ManuNameField;
      [OptionalField]
      private string ModelNameField;
      [OptionalField]
      private int Number_Of_HeatersField;

      public ExtensionDataObject ExtensionData
      {
        get => this.extensionDataField;
        set => this.extensionDataField = value;
      }

      [DataMember]
      public string BrandName
      {
        get => this.BrandNameField;
        set
        {
          if (object.ReferenceEquals((object) this.BrandNameField, (object) value))
            return;
          this.BrandNameField = value;
          this.RaisePropertyChanged(nameof (BrandName));
        }
      }

      [DataMember]
      public string Index_Number
      {
        get => this.Index_NumberField;
        set
        {
          if (object.ReferenceEquals((object) this.Index_NumberField, (object) value))
            return;
          this.Index_NumberField = value;
          this.RaisePropertyChanged(nameof (Index_Number));
        }
      }

      [DataMember]
      public string ManuName
      {
        get => this.ManuNameField;
        set
        {
          if (object.ReferenceEquals((object) this.ManuNameField, (object) value))
            return;
          this.ManuNameField = value;
          this.RaisePropertyChanged(nameof (ManuName));
        }
      }

      [DataMember]
      public string ModelName
      {
        get => this.ModelNameField;
        set
        {
          if (object.ReferenceEquals((object) this.ModelNameField, (object) value))
            return;
          this.ModelNameField = value;
          this.RaisePropertyChanged(nameof (ModelName));
        }
      }

      [DataMember]
      public int Number_Of_Heaters
      {
        get => this.Number_Of_HeatersField;
        set
        {
          if (this.Number_Of_HeatersField.Equals(value))
            return;
          this.Number_Of_HeatersField = value;
          this.RaisePropertyChanged(nameof (Number_Of_Heaters));
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
}
