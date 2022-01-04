
// Type: SAP2012.RdSAP.Survey_Class




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace SAP2012.RdSAP
{
  [DebuggerStepThrough]
  [GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
  [DataContract(Name = "Survey_Class", Namespace = "http://schemas.datacontract.org/2004/07/StromaServices")]
  [Serializable]
  public class Survey_Class : IExtensibleDataObject, INotifyPropertyChanged
  {
    [NonSerialized]
    private ExtensionDataObject extensionDataField;
    [OptionalField]
    private Survey_Class.Addendums_Class AddendumsField;
    [OptionalField]
    private Survey_Class.Age_Class AgeField;
    [OptionalField]
    private Survey_Class.AssessorDetails Assessor_DetailsField;
    [OptionalField]
    private Survey_Class.Conservatory_Class ConservatoryField;
    [OptionalField]
    private Extension_Class[] ExtensionsField;
    [OptionalField]
    private Survey_Class.Flat_Class Flat_MaisonetteField;
    [OptionalField]
    private Survey_Class.General_Class GeneralField;
    [OptionalField]
    private Survey_Class.Info_Class InfoField;
    [OptionalField]
    private Heating_Class[] MainHeatingField;
    [OptionalField]
    private Survey_Class.Windows_Class OpeningsField;
    [OptionalField]
    private Survey_Class.OtherDetails_Class OtherDetailsField;
    [OptionalField]
    private Survey_Class.Renewable_Class RenewableField;
    [OptionalField]
    private Survey_Class.SecondaryHeating_Class SecondaryHeatingField;
    [OptionalField]
    private Survey_Class.WaterHeating_Class WaterHeatingField;

    [Browsable(false)]
    public ExtensionDataObject ExtensionData
    {
      get => this.extensionDataField;
      set => this.extensionDataField = value;
    }

    [DataMember]
    public Survey_Class.Addendums_Class Addendums
    {
      get => this.AddendumsField;
      set
      {
        if (object.ReferenceEquals((object) this.AddendumsField, (object) value))
          return;
        this.AddendumsField = value;
        this.RaisePropertyChanged(nameof (Addendums));
      }
    }

    [DataMember]
    public Survey_Class.Age_Class Age
    {
      get => this.AgeField;
      set
      {
        if (object.ReferenceEquals((object) this.AgeField, (object) value))
          return;
        this.AgeField = value;
        this.RaisePropertyChanged(nameof (Age));
      }
    }

    [DataMember]
    public Survey_Class.AssessorDetails Assessor_Details
    {
      get => this.Assessor_DetailsField;
      set
      {
        if (object.ReferenceEquals((object) this.Assessor_DetailsField, (object) value))
          return;
        this.Assessor_DetailsField = value;
        this.RaisePropertyChanged(nameof (Assessor_Details));
      }
    }

    [DataMember]
    public Survey_Class.Conservatory_Class Conservatory
    {
      get => this.ConservatoryField;
      set
      {
        if (object.ReferenceEquals((object) this.ConservatoryField, (object) value))
          return;
        this.ConservatoryField = value;
        this.RaisePropertyChanged(nameof (Conservatory));
      }
    }

    [DataMember]
    public Extension_Class[] Extensions
    {
      get => this.ExtensionsField;
      set
      {
        if (object.ReferenceEquals((object) this.ExtensionsField, (object) value))
          return;
        this.ExtensionsField = value;
        this.RaisePropertyChanged(nameof (Extensions));
      }
    }

    [DataMember]
    public Survey_Class.Flat_Class Flat_Maisonette
    {
      get => this.Flat_MaisonetteField;
      set
      {
        if (object.ReferenceEquals((object) this.Flat_MaisonetteField, (object) value))
          return;
        this.Flat_MaisonetteField = value;
        this.RaisePropertyChanged(nameof (Flat_Maisonette));
      }
    }

    [DataMember]
    public Survey_Class.General_Class General
    {
      get => this.GeneralField;
      set
      {
        if (object.ReferenceEquals((object) this.GeneralField, (object) value))
          return;
        this.GeneralField = value;
        this.RaisePropertyChanged(nameof (General));
      }
    }

    [DataMember]
    public Survey_Class.Info_Class Info
    {
      get => this.InfoField;
      set
      {
        if (object.ReferenceEquals((object) this.InfoField, (object) value))
          return;
        this.InfoField = value;
        this.RaisePropertyChanged(nameof (Info));
      }
    }

    [DataMember]
    public Heating_Class[] MainHeating
    {
      get => this.MainHeatingField;
      set
      {
        if (object.ReferenceEquals((object) this.MainHeatingField, (object) value))
          return;
        this.MainHeatingField = value;
        this.RaisePropertyChanged(nameof (MainHeating));
      }
    }

    [DataMember]
    public Survey_Class.Windows_Class Openings
    {
      get => this.OpeningsField;
      set
      {
        if (object.ReferenceEquals((object) this.OpeningsField, (object) value))
          return;
        this.OpeningsField = value;
        this.RaisePropertyChanged(nameof (Openings));
      }
    }

    [DataMember]
    public Survey_Class.OtherDetails_Class OtherDetails
    {
      get => this.OtherDetailsField;
      set
      {
        if (object.ReferenceEquals((object) this.OtherDetailsField, (object) value))
          return;
        this.OtherDetailsField = value;
        this.RaisePropertyChanged(nameof (OtherDetails));
      }
    }

    [DataMember]
    public Survey_Class.Renewable_Class Renewable
    {
      get => this.RenewableField;
      set
      {
        if (object.ReferenceEquals((object) this.RenewableField, (object) value))
          return;
        this.RenewableField = value;
        this.RaisePropertyChanged(nameof (Renewable));
      }
    }

    [DataMember]
    public Survey_Class.SecondaryHeating_Class SecondaryHeating
    {
      get => this.SecondaryHeatingField;
      set
      {
        if (object.ReferenceEquals((object) this.SecondaryHeatingField, (object) value))
          return;
        this.SecondaryHeatingField = value;
        this.RaisePropertyChanged(nameof (SecondaryHeating));
      }
    }

    [DataMember]
    public Survey_Class.WaterHeating_Class WaterHeating
    {
      get => this.WaterHeatingField;
      set
      {
        if (object.ReferenceEquals((object) this.WaterHeatingField, (object) value))
          return;
        this.WaterHeatingField = value;
        this.RaisePropertyChanged(nameof (WaterHeating));
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
    [DataContract(Name = "Survey_Class.Addendums_Class", Namespace = "http://schemas.datacontract.org/2004/07/StromaServices")]
    [Serializable]
    public class Addendums_Class : IExtensibleDataObject, INotifyPropertyChanged
    {
      [NonSerialized]
      private ExtensionDataObject extensionDataField;
      [OptionalField]
      private bool AddendumField;
      [OptionalField]
      private bool AddendumCavityFilledField;
      [OptionalField]
      private bool AddendumHighExpField;
      [OptionalField]
      private bool AddendumIssueAcessField;
      [OptionalField]
      private int[] AddendumListField;
      [OptionalField]
      private bool AddendumNarrowCavityField;
      [OptionalField]
      private bool AddendumStoneWallField;
      [OptionalField]
      private bool AddendumSystemBuildField;

      public ExtensionDataObject ExtensionData
      {
        get => this.extensionDataField;
        set => this.extensionDataField = value;
      }

      [DataMember]
      public bool Addendum
      {
        get => this.AddendumField;
        set
        {
          if (this.AddendumField.Equals(value))
            return;
          this.AddendumField = value;
          this.RaisePropertyChanged(nameof (Addendum));
        }
      }

      [DataMember]
      public bool AddendumCavityFilled
      {
        get => this.AddendumCavityFilledField;
        set
        {
          if (this.AddendumCavityFilledField.Equals(value))
            return;
          this.AddendumCavityFilledField = value;
          this.RaisePropertyChanged(nameof (AddendumCavityFilled));
        }
      }

      [DataMember]
      public bool AddendumHighExp
      {
        get => this.AddendumHighExpField;
        set
        {
          if (this.AddendumHighExpField.Equals(value))
            return;
          this.AddendumHighExpField = value;
          this.RaisePropertyChanged(nameof (AddendumHighExp));
        }
      }

      [DataMember]
      public bool AddendumIssueAcess
      {
        get => this.AddendumIssueAcessField;
        set
        {
          if (this.AddendumIssueAcessField.Equals(value))
            return;
          this.AddendumIssueAcessField = value;
          this.RaisePropertyChanged(nameof (AddendumIssueAcess));
        }
      }

      [DataMember]
      public int[] AddendumList
      {
        get => this.AddendumListField;
        set
        {
          if (object.ReferenceEquals((object) this.AddendumListField, (object) value))
            return;
          this.AddendumListField = value;
          this.RaisePropertyChanged(nameof (AddendumList));
        }
      }

      [DataMember]
      public bool AddendumNarrowCavity
      {
        get => this.AddendumNarrowCavityField;
        set
        {
          if (this.AddendumNarrowCavityField.Equals(value))
            return;
          this.AddendumNarrowCavityField = value;
          this.RaisePropertyChanged(nameof (AddendumNarrowCavity));
        }
      }

      [DataMember]
      public bool AddendumStoneWall
      {
        get => this.AddendumStoneWallField;
        set
        {
          if (this.AddendumStoneWallField.Equals(value))
            return;
          this.AddendumStoneWallField = value;
          this.RaisePropertyChanged(nameof (AddendumStoneWall));
        }
      }

      [DataMember]
      public bool AddendumSystemBuild
      {
        get => this.AddendumSystemBuildField;
        set
        {
          if (this.AddendumSystemBuildField.Equals(value))
            return;
          this.AddendumSystemBuildField = value;
          this.RaisePropertyChanged(nameof (AddendumSystemBuild));
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

    [DebuggerStepThrough]
    [GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
    [DataContract(Name = "Survey_Class.Age_Class", Namespace = "http://schemas.datacontract.org/2004/07/StromaServices")]
    [Serializable]
    public class Age_Class : IExtensibleDataObject, INotifyPropertyChanged
    {
      [NonSerialized]
      private ExtensionDataObject extensionDataField;
      [OptionalField]
      private int DimTypeField;
      [OptionalField]
      private int MHabRoomsField;
      [OptionalField]
      private int MHeatHabRoomsField;
      [OptionalField]
      private int NumberOfExtensionField;

      public ExtensionDataObject ExtensionData
      {
        get => this.extensionDataField;
        set => this.extensionDataField = value;
      }

      [DataMember]
      public int DimType
      {
        get => this.DimTypeField;
        set
        {
          if (this.DimTypeField.Equals(value))
            return;
          this.DimTypeField = value;
          this.RaisePropertyChanged(nameof (DimType));
        }
      }

      [DataMember]
      public int MHabRooms
      {
        get => this.MHabRoomsField;
        set
        {
          if (this.MHabRoomsField.Equals(value))
            return;
          this.MHabRoomsField = value;
          this.RaisePropertyChanged(nameof (MHabRooms));
        }
      }

      [DataMember]
      public int MHeatHabRooms
      {
        get => this.MHeatHabRoomsField;
        set
        {
          if (this.MHeatHabRoomsField.Equals(value))
            return;
          this.MHeatHabRoomsField = value;
          this.RaisePropertyChanged(nameof (MHeatHabRooms));
        }
      }

      [DataMember]
      public int NumberOfExtension
      {
        get => this.NumberOfExtensionField;
        set
        {
          if (this.NumberOfExtensionField.Equals(value))
            return;
          this.NumberOfExtensionField = value;
          this.RaisePropertyChanged(nameof (NumberOfExtension));
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

    [DebuggerStepThrough]
    [GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
    [DataContract(Name = "Survey_Class.AssessorDetails", Namespace = "http://schemas.datacontract.org/2004/07/StromaServices")]
    [Serializable]
    public class AssessorDetails : IExtensibleDataObject, INotifyPropertyChanged
    {
      [NonSerialized]
      private ExtensionDataObject extensionDataField;
      [OptionalField]
      private string AsessorAddressField;
      [OptionalField]
      private string AssessorCompanyField;
      [OptionalField]
      private string AssessorFNField;
      [OptionalField]
      private string AssessorFaxField;
      [OptionalField]
      private string AssessorLNField;
      [OptionalField]
      private string AssessorNOField;
      [OptionalField]
      private string AssessorPhoneField;
      [OptionalField]
      private string EA_Address1Field;
      [OptionalField]
      private string EA_Address2Field;
      [OptionalField]
      private string EA_Address3Field;
      [OptionalField]
      private DateTime EA_CertificationDateField;
      [OptionalField]
      private string EA_EmailField;
      [OptionalField]
      private string EA_PostcodeField;
      [OptionalField]
      private string EA_PrefixField;
      [OptionalField]
      private string EA_StatusField;
      [OptionalField]
      private string EA_SuffixField;
      [OptionalField]
      private string EA_TownField;
      [OptionalField]
      private string EA_WebField;

      public ExtensionDataObject ExtensionData
      {
        get => this.extensionDataField;
        set => this.extensionDataField = value;
      }

      [DataMember]
      public string AsessorAddress
      {
        get => this.AsessorAddressField;
        set
        {
          if (object.ReferenceEquals((object) this.AsessorAddressField, (object) value))
            return;
          this.AsessorAddressField = value;
          this.RaisePropertyChanged(nameof (AsessorAddress));
        }
      }

      [DataMember]
      public string AssessorCompany
      {
        get => this.AssessorCompanyField;
        set
        {
          if (object.ReferenceEquals((object) this.AssessorCompanyField, (object) value))
            return;
          this.AssessorCompanyField = value;
          this.RaisePropertyChanged(nameof (AssessorCompany));
        }
      }

      [DataMember]
      public string AssessorFN
      {
        get => this.AssessorFNField;
        set
        {
          if (object.ReferenceEquals((object) this.AssessorFNField, (object) value))
            return;
          this.AssessorFNField = value;
          this.RaisePropertyChanged(nameof (AssessorFN));
        }
      }

      [DataMember]
      public string AssessorFax
      {
        get => this.AssessorFaxField;
        set
        {
          if (object.ReferenceEquals((object) this.AssessorFaxField, (object) value))
            return;
          this.AssessorFaxField = value;
          this.RaisePropertyChanged(nameof (AssessorFax));
        }
      }

      [DataMember]
      public string AssessorLN
      {
        get => this.AssessorLNField;
        set
        {
          if (object.ReferenceEquals((object) this.AssessorLNField, (object) value))
            return;
          this.AssessorLNField = value;
          this.RaisePropertyChanged(nameof (AssessorLN));
        }
      }

      [DataMember]
      public string AssessorNO
      {
        get => this.AssessorNOField;
        set
        {
          if (object.ReferenceEquals((object) this.AssessorNOField, (object) value))
            return;
          this.AssessorNOField = value;
          this.RaisePropertyChanged(nameof (AssessorNO));
        }
      }

      [DataMember]
      public string AssessorPhone
      {
        get => this.AssessorPhoneField;
        set
        {
          if (object.ReferenceEquals((object) this.AssessorPhoneField, (object) value))
            return;
          this.AssessorPhoneField = value;
          this.RaisePropertyChanged(nameof (AssessorPhone));
        }
      }

      [DataMember]
      public string EA_Address1
      {
        get => this.EA_Address1Field;
        set
        {
          if (object.ReferenceEquals((object) this.EA_Address1Field, (object) value))
            return;
          this.EA_Address1Field = value;
          this.RaisePropertyChanged(nameof (EA_Address1));
        }
      }

      [DataMember]
      public string EA_Address2
      {
        get => this.EA_Address2Field;
        set
        {
          if (object.ReferenceEquals((object) this.EA_Address2Field, (object) value))
            return;
          this.EA_Address2Field = value;
          this.RaisePropertyChanged(nameof (EA_Address2));
        }
      }

      [DataMember]
      public string EA_Address3
      {
        get => this.EA_Address3Field;
        set
        {
          if (object.ReferenceEquals((object) this.EA_Address3Field, (object) value))
            return;
          this.EA_Address3Field = value;
          this.RaisePropertyChanged(nameof (EA_Address3));
        }
      }

      [DataMember]
      public DateTime EA_CertificationDate
      {
        get => this.EA_CertificationDateField;
        set
        {
          if (this.EA_CertificationDateField.Equals(value))
            return;
          this.EA_CertificationDateField = value;
          this.RaisePropertyChanged(nameof (EA_CertificationDate));
        }
      }

      [DataMember]
      public string EA_Email
      {
        get => this.EA_EmailField;
        set
        {
          if (object.ReferenceEquals((object) this.EA_EmailField, (object) value))
            return;
          this.EA_EmailField = value;
          this.RaisePropertyChanged(nameof (EA_Email));
        }
      }

      [DataMember]
      public string EA_Postcode
      {
        get => this.EA_PostcodeField;
        set
        {
          if (object.ReferenceEquals((object) this.EA_PostcodeField, (object) value))
            return;
          this.EA_PostcodeField = value;
          this.RaisePropertyChanged(nameof (EA_Postcode));
        }
      }

      [DataMember]
      public string EA_Prefix
      {
        get => this.EA_PrefixField;
        set
        {
          if (object.ReferenceEquals((object) this.EA_PrefixField, (object) value))
            return;
          this.EA_PrefixField = value;
          this.RaisePropertyChanged(nameof (EA_Prefix));
        }
      }

      [DataMember]
      public string EA_Status
      {
        get => this.EA_StatusField;
        set
        {
          if (object.ReferenceEquals((object) this.EA_StatusField, (object) value))
            return;
          this.EA_StatusField = value;
          this.RaisePropertyChanged(nameof (EA_Status));
        }
      }

      [DataMember]
      public string EA_Suffix
      {
        get => this.EA_SuffixField;
        set
        {
          if (object.ReferenceEquals((object) this.EA_SuffixField, (object) value))
            return;
          this.EA_SuffixField = value;
          this.RaisePropertyChanged(nameof (EA_Suffix));
        }
      }

      [DataMember]
      public string EA_Town
      {
        get => this.EA_TownField;
        set
        {
          if (object.ReferenceEquals((object) this.EA_TownField, (object) value))
            return;
          this.EA_TownField = value;
          this.RaisePropertyChanged(nameof (EA_Town));
        }
      }

      [DataMember]
      public string EA_Web
      {
        get => this.EA_WebField;
        set
        {
          if (object.ReferenceEquals((object) this.EA_WebField, (object) value))
            return;
          this.EA_WebField = value;
          this.RaisePropertyChanged(nameof (EA_Web));
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

    [DebuggerStepThrough]
    [GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
    [DataContract(Name = "Survey_Class.Conservatory_Class", Namespace = "http://schemas.datacontract.org/2004/07/StromaServices")]
    [Serializable]
    public class Conservatory_Class : IExtensibleDataObject, INotifyPropertyChanged
    {
      [NonSerialized]
      private ExtensionDataObject extensionDataField;
      [OptionalField]
      private int ConservatoryTypeField;
      [OptionalField]
      private bool DoubleGlazedField;
      [OptionalField]
      private double FloorAreaField;
      [OptionalField]
      private double GlazedPerimeterField;
      [OptionalField]
      private int RoomHeightField;

      public ExtensionDataObject ExtensionData
      {
        get => this.extensionDataField;
        set => this.extensionDataField = value;
      }

      [DataMember]
      public int ConservatoryType
      {
        get => this.ConservatoryTypeField;
        set
        {
          if (this.ConservatoryTypeField.Equals(value))
            return;
          this.ConservatoryTypeField = value;
          this.RaisePropertyChanged(nameof (ConservatoryType));
        }
      }

      [DataMember]
      public bool DoubleGlazed
      {
        get => this.DoubleGlazedField;
        set
        {
          if (this.DoubleGlazedField.Equals(value))
            return;
          this.DoubleGlazedField = value;
          this.RaisePropertyChanged(nameof (DoubleGlazed));
        }
      }

      [DataMember]
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

      [DataMember]
      public double GlazedPerimeter
      {
        get => this.GlazedPerimeterField;
        set
        {
          if (this.GlazedPerimeterField.Equals(value))
            return;
          this.GlazedPerimeterField = value;
          this.RaisePropertyChanged(nameof (GlazedPerimeter));
        }
      }

      [DataMember]
      public int RoomHeight
      {
        get => this.RoomHeightField;
        set
        {
          if (this.RoomHeightField.Equals(value))
            return;
          this.RoomHeightField = value;
          this.RaisePropertyChanged(nameof (RoomHeight));
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

    [DebuggerStepThrough]
    [GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
    [DataContract(Name = "Survey_Class.Flat_Class", Namespace = "http://schemas.datacontract.org/2004/07/StromaServices")]
    [Serializable]
    public class Flat_Class : IExtensibleDataObject, INotifyPropertyChanged
    {
      [NonSerialized]
      private ExtensionDataObject extensionDataField;
      [OptionalField]
      private int FlatLocationField;
      [OptionalField]
      private int HeatLossCorridorField;
      [OptionalField]
      private int LevelField;
      [OptionalField]
      private string TopStoreyField;
      [OptionalField]
      private double UnHeatedCorridorLengthField;

      public ExtensionDataObject ExtensionData
      {
        get => this.extensionDataField;
        set => this.extensionDataField = value;
      }

      [DataMember]
      public int FlatLocation
      {
        get => this.FlatLocationField;
        set
        {
          if (this.FlatLocationField.Equals(value))
            return;
          this.FlatLocationField = value;
          this.RaisePropertyChanged(nameof (FlatLocation));
        }
      }

      [DataMember]
      public int HeatLossCorridor
      {
        get => this.HeatLossCorridorField;
        set
        {
          if (this.HeatLossCorridorField.Equals(value))
            return;
          this.HeatLossCorridorField = value;
          this.RaisePropertyChanged(nameof (HeatLossCorridor));
        }
      }

      [DataMember]
      public int Level
      {
        get => this.LevelField;
        set
        {
          if (this.LevelField.Equals(value))
            return;
          this.LevelField = value;
          this.RaisePropertyChanged(nameof (Level));
        }
      }

      [DataMember]
      public string TopStorey
      {
        get => this.TopStoreyField;
        set
        {
          if (object.ReferenceEquals((object) this.TopStoreyField, (object) value))
            return;
          this.TopStoreyField = value;
          this.RaisePropertyChanged(nameof (TopStorey));
        }
      }

      [DataMember]
      public double UnHeatedCorridorLength
      {
        get => this.UnHeatedCorridorLengthField;
        set
        {
          if (this.UnHeatedCorridorLengthField.Equals(value))
            return;
          this.UnHeatedCorridorLengthField = value;
          this.RaisePropertyChanged(nameof (UnHeatedCorridorLength));
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

    [DebuggerStepThrough]
    [GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
    [DataContract(Name = "Survey_Class.General_Class", Namespace = "http://schemas.datacontract.org/2004/07/StromaServices")]
    [Serializable]
    public class General_Class : IExtensibleDataObject, INotifyPropertyChanged
    {
      [NonSerialized]
      private ExtensionDataObject extensionDataField;
      [OptionalField]
      private string AddressLine1Field;
      [OptionalField]
      private string AddressLine2Field;
      [OptionalField]
      private string AddressLine3Field;
      [OptionalField]
      private string CityField;
      [OptionalField]
      private string ClientEmailField;
      [OptionalField]
      private int CountryField;
      [OptionalField]
      private string CustomerReference1Field;
      [OptionalField]
      private string CustomerReference2Field;
      [OptionalField]
      private string CustomerReference3Field;
      [OptionalField]
      private int EPCLanguageField;
      [OptionalField]
      private string ErrorsFoundField;
      [OptionalField]
      private int FirePlacesCountField;
      [OptionalField]
      private string InspectionDateField;
      [OptionalField]
      private DateTime LastUPdatedField;
      [OptionalField]
      private bool MultipleCertificationField;
      [OptionalField]
      private bool NoHeatingField;
      [OptionalField]
      private string PostCodeField;
      [OptionalField]
      private int PropertyType1Field;
      [OptionalField]
      private int PropertyType2Field;
      [OptionalField]
      private int RPDField;
      [OptionalField]
      private string RRNField;
      [OptionalField]
      private int RdSapIDField;
      [OptionalField]
      private string RegionField;
      [OptionalField]
      private int RevisonField;
      [OptionalField]
      private int TenureField;
      [OptionalField]
      private int TransactionField;
      [OptionalField]
      private string UPRNField;

      public ExtensionDataObject ExtensionData
      {
        get => this.extensionDataField;
        set => this.extensionDataField = value;
      }

      [DataMember]
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

      [DataMember]
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

      [DataMember]
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

      [DataMember]
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

      [DataMember]
      public string ClientEmail
      {
        get => this.ClientEmailField;
        set
        {
          if (object.ReferenceEquals((object) this.ClientEmailField, (object) value))
            return;
          this.ClientEmailField = value;
          this.RaisePropertyChanged(nameof (ClientEmail));
        }
      }

      [DataMember]
      public int Country
      {
        get => this.CountryField;
        set
        {
          if (this.CountryField.Equals(value))
            return;
          this.CountryField = value;
          this.RaisePropertyChanged(nameof (Country));
        }
      }

      [DataMember]
      public string CustomerReference1
      {
        get => this.CustomerReference1Field;
        set
        {
          if (object.ReferenceEquals((object) this.CustomerReference1Field, (object) value))
            return;
          this.CustomerReference1Field = value;
          this.RaisePropertyChanged(nameof (CustomerReference1));
        }
      }

      [DataMember]
      public string CustomerReference2
      {
        get => this.CustomerReference2Field;
        set
        {
          if (object.ReferenceEquals((object) this.CustomerReference2Field, (object) value))
            return;
          this.CustomerReference2Field = value;
          this.RaisePropertyChanged(nameof (CustomerReference2));
        }
      }

      [DataMember]
      public string CustomerReference3
      {
        get => this.CustomerReference3Field;
        set
        {
          if (object.ReferenceEquals((object) this.CustomerReference3Field, (object) value))
            return;
          this.CustomerReference3Field = value;
          this.RaisePropertyChanged(nameof (CustomerReference3));
        }
      }

      [DataMember]
      public int EPCLanguage
      {
        get => this.EPCLanguageField;
        set
        {
          if (this.EPCLanguageField.Equals(value))
            return;
          this.EPCLanguageField = value;
          this.RaisePropertyChanged(nameof (EPCLanguage));
        }
      }

      [DataMember]
      public string ErrorsFound
      {
        get => this.ErrorsFoundField;
        set
        {
          if (object.ReferenceEquals((object) this.ErrorsFoundField, (object) value))
            return;
          this.ErrorsFoundField = value;
          this.RaisePropertyChanged(nameof (ErrorsFound));
        }
      }

      [DataMember]
      public int FirePlacesCount
      {
        get => this.FirePlacesCountField;
        set
        {
          if (this.FirePlacesCountField.Equals(value))
            return;
          this.FirePlacesCountField = value;
          this.RaisePropertyChanged(nameof (FirePlacesCount));
        }
      }

      [DataMember]
      public string InspectionDate
      {
        get => this.InspectionDateField;
        set
        {
          if (object.ReferenceEquals((object) this.InspectionDateField, (object) value))
            return;
          this.InspectionDateField = value;
          this.RaisePropertyChanged(nameof (InspectionDate));
        }
      }

      [DataMember]
      public DateTime LastUPdated
      {
        get => this.LastUPdatedField;
        set
        {
          if (this.LastUPdatedField.Equals(value))
            return;
          this.LastUPdatedField = value;
          this.RaisePropertyChanged(nameof (LastUPdated));
        }
      }

      [DataMember]
      public bool MultipleCertification
      {
        get => this.MultipleCertificationField;
        set
        {
          if (this.MultipleCertificationField.Equals(value))
            return;
          this.MultipleCertificationField = value;
          this.RaisePropertyChanged(nameof (MultipleCertification));
        }
      }

      [DataMember]
      public bool NoHeating
      {
        get => this.NoHeatingField;
        set
        {
          if (this.NoHeatingField.Equals(value))
            return;
          this.NoHeatingField = value;
          this.RaisePropertyChanged(nameof (NoHeating));
        }
      }

      [DataMember]
      public string PostCode
      {
        get => this.PostCodeField;
        set
        {
          if (object.ReferenceEquals((object) this.PostCodeField, (object) value))
            return;
          this.PostCodeField = value;
          this.RaisePropertyChanged(nameof (PostCode));
        }
      }

      [DataMember]
      public int PropertyType1
      {
        get => this.PropertyType1Field;
        set
        {
          if (this.PropertyType1Field.Equals(value))
            return;
          this.PropertyType1Field = value;
          this.RaisePropertyChanged(nameof (PropertyType1));
        }
      }

      [DataMember]
      public int PropertyType2
      {
        get => this.PropertyType2Field;
        set
        {
          if (this.PropertyType2Field.Equals(value))
            return;
          this.PropertyType2Field = value;
          this.RaisePropertyChanged(nameof (PropertyType2));
        }
      }

      [DataMember]
      public int RPD
      {
        get => this.RPDField;
        set
        {
          if (this.RPDField.Equals(value))
            return;
          this.RPDField = value;
          this.RaisePropertyChanged(nameof (RPD));
        }
      }

      [DataMember]
      public string RRN
      {
        get => this.RRNField;
        set
        {
          if (object.ReferenceEquals((object) this.RRNField, (object) value))
            return;
          this.RRNField = value;
          this.RaisePropertyChanged(nameof (RRN));
        }
      }

      [DataMember]
      public int RdSapID
      {
        get => this.RdSapIDField;
        set
        {
          if (this.RdSapIDField.Equals(value))
            return;
          this.RdSapIDField = value;
          this.RaisePropertyChanged(nameof (RdSapID));
        }
      }

      [DataMember]
      public string Region
      {
        get => this.RegionField;
        set
        {
          if (object.ReferenceEquals((object) this.RegionField, (object) value))
            return;
          this.RegionField = value;
          this.RaisePropertyChanged(nameof (Region));
        }
      }

      [DataMember]
      public int Revison
      {
        get => this.RevisonField;
        set
        {
          if (this.RevisonField.Equals(value))
            return;
          this.RevisonField = value;
          this.RaisePropertyChanged(nameof (Revison));
        }
      }

      [DataMember]
      public int Tenure
      {
        get => this.TenureField;
        set
        {
          if (this.TenureField.Equals(value))
            return;
          this.TenureField = value;
          this.RaisePropertyChanged(nameof (Tenure));
        }
      }

      [DataMember]
      public int Transaction
      {
        get => this.TransactionField;
        set
        {
          if (this.TransactionField.Equals(value))
            return;
          this.TransactionField = value;
          this.RaisePropertyChanged(nameof (Transaction));
        }
      }

      [DataMember]
      public string UPRN
      {
        get => this.UPRNField;
        set
        {
          if (object.ReferenceEquals((object) this.UPRNField, (object) value))
            return;
          this.UPRNField = value;
          this.RaisePropertyChanged(nameof (UPRN));
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

    [DebuggerStepThrough]
    [GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
    [DataContract(Name = "Survey_Class.Info_Class", Namespace = "http://schemas.datacontract.org/2004/07/StromaServices")]
    [Serializable]
    public class Info_Class : IExtensibleDataObject, INotifyPropertyChanged
    {
      [NonSerialized]
      private ExtensionDataObject extensionDataField;
      [OptionalField]
      private string AssessmentField;
      [OptionalField]
      private Survey_Class.AssessorDetails AssessorField;
      [OptionalField]
      private string BEDFRevisionNumberField;
      [OptionalField]
      private bool CloningField;
      [OptionalField]
      private string CloningReferenceField;
      [OptionalField]
      private string CloningTypeField;
      [OptionalField]
      private DateTime CompletionDateField;
      [OptionalField]
      private int CountryCodeField;
      [OptionalField]
      private bool ECOEnabledField;
      [OptionalField]
      private string EmailField;
      [OptionalField]
      private string ExternalDefRevisionNoField;
      [OptionalField]
      private string FirstNameField;
      [OptionalField]
      private bool GDEnabledField;
      [OptionalField]
      private DateTime InspectionDateField;
      [OptionalField]
      private bool OAEnabledField;
      [OptionalField]
      private string PasswordField;
      [OptionalField]
      private bool RecommendHeatedSurveyField;
      [OptionalField]
      private DateTime RegistrationDateField;
      [OptionalField]
      private string SAPVersionField;
      [OptionalField]
      private string SchemaversionField;
      [OptionalField]
      private string SecondNameField;
      [OptionalField]
      private string SoftwareVersionField;
      [OptionalField]
      private string SoftwaretypeField;
      [OptionalField]
      private int SuccessField;
      [OptionalField]
      private int SurveyTypeField;
      [OptionalField]
      private int UserIDField;
      [OptionalField]
      private string UserNameField;

      public ExtensionDataObject ExtensionData
      {
        get => this.extensionDataField;
        set => this.extensionDataField = value;
      }

      [DataMember]
      public string Assessment
      {
        get => this.AssessmentField;
        set
        {
          if (object.ReferenceEquals((object) this.AssessmentField, (object) value))
            return;
          this.AssessmentField = value;
          this.RaisePropertyChanged(nameof (Assessment));
        }
      }

      [DataMember]
      public Survey_Class.AssessorDetails Assessor
      {
        get => this.AssessorField;
        set
        {
          if (object.ReferenceEquals((object) this.AssessorField, (object) value))
            return;
          this.AssessorField = value;
          this.RaisePropertyChanged(nameof (Assessor));
        }
      }

      [DataMember]
      public string BEDFRevisionNumber
      {
        get => this.BEDFRevisionNumberField;
        set
        {
          if (object.ReferenceEquals((object) this.BEDFRevisionNumberField, (object) value))
            return;
          this.BEDFRevisionNumberField = value;
          this.RaisePropertyChanged(nameof (BEDFRevisionNumber));
        }
      }

      [DataMember]
      public bool Cloning
      {
        get => this.CloningField;
        set
        {
          if (this.CloningField.Equals(value))
            return;
          this.CloningField = value;
          this.RaisePropertyChanged(nameof (Cloning));
        }
      }

      [DataMember]
      public string CloningReference
      {
        get => this.CloningReferenceField;
        set
        {
          if (object.ReferenceEquals((object) this.CloningReferenceField, (object) value))
            return;
          this.CloningReferenceField = value;
          this.RaisePropertyChanged(nameof (CloningReference));
        }
      }

      [DataMember]
      public string CloningType
      {
        get => this.CloningTypeField;
        set
        {
          if (object.ReferenceEquals((object) this.CloningTypeField, (object) value))
            return;
          this.CloningTypeField = value;
          this.RaisePropertyChanged(nameof (CloningType));
        }
      }

      [DataMember]
      public DateTime CompletionDate
      {
        get => this.CompletionDateField;
        set
        {
          if (this.CompletionDateField.Equals(value))
            return;
          this.CompletionDateField = value;
          this.RaisePropertyChanged(nameof (CompletionDate));
        }
      }

      [DataMember]
      public int CountryCode
      {
        get => this.CountryCodeField;
        set
        {
          if (this.CountryCodeField.Equals(value))
            return;
          this.CountryCodeField = value;
          this.RaisePropertyChanged(nameof (CountryCode));
        }
      }

      [DataMember]
      public bool ECOEnabled
      {
        get => this.ECOEnabledField;
        set
        {
          if (this.ECOEnabledField.Equals(value))
            return;
          this.ECOEnabledField = value;
          this.RaisePropertyChanged(nameof (ECOEnabled));
        }
      }

      [DataMember]
      public string Email
      {
        get => this.EmailField;
        set
        {
          if (object.ReferenceEquals((object) this.EmailField, (object) value))
            return;
          this.EmailField = value;
          this.RaisePropertyChanged(nameof (Email));
        }
      }

      [DataMember]
      public string ExternalDefRevisionNo
      {
        get => this.ExternalDefRevisionNoField;
        set
        {
          if (object.ReferenceEquals((object) this.ExternalDefRevisionNoField, (object) value))
            return;
          this.ExternalDefRevisionNoField = value;
          this.RaisePropertyChanged(nameof (ExternalDefRevisionNo));
        }
      }

      [DataMember]
      public string FirstName
      {
        get => this.FirstNameField;
        set
        {
          if (object.ReferenceEquals((object) this.FirstNameField, (object) value))
            return;
          this.FirstNameField = value;
          this.RaisePropertyChanged(nameof (FirstName));
        }
      }

      [DataMember]
      public bool GDEnabled
      {
        get => this.GDEnabledField;
        set
        {
          if (this.GDEnabledField.Equals(value))
            return;
          this.GDEnabledField = value;
          this.RaisePropertyChanged(nameof (GDEnabled));
        }
      }

      [DataMember]
      public DateTime InspectionDate
      {
        get => this.InspectionDateField;
        set
        {
          if (this.InspectionDateField.Equals(value))
            return;
          this.InspectionDateField = value;
          this.RaisePropertyChanged(nameof (InspectionDate));
        }
      }

      [DataMember]
      public bool OAEnabled
      {
        get => this.OAEnabledField;
        set
        {
          if (this.OAEnabledField.Equals(value))
            return;
          this.OAEnabledField = value;
          this.RaisePropertyChanged(nameof (OAEnabled));
        }
      }

      [DataMember]
      public string Password
      {
        get => this.PasswordField;
        set
        {
          if (object.ReferenceEquals((object) this.PasswordField, (object) value))
            return;
          this.PasswordField = value;
          this.RaisePropertyChanged(nameof (Password));
        }
      }

      [DataMember]
      public bool RecommendHeatedSurvey
      {
        get => this.RecommendHeatedSurveyField;
        set
        {
          if (this.RecommendHeatedSurveyField.Equals(value))
            return;
          this.RecommendHeatedSurveyField = value;
          this.RaisePropertyChanged(nameof (RecommendHeatedSurvey));
        }
      }

      [DataMember]
      public DateTime RegistrationDate
      {
        get => this.RegistrationDateField;
        set
        {
          if (this.RegistrationDateField.Equals(value))
            return;
          this.RegistrationDateField = value;
          this.RaisePropertyChanged(nameof (RegistrationDate));
        }
      }

      [DataMember]
      public string SAPVersion
      {
        get => this.SAPVersionField;
        set
        {
          if (object.ReferenceEquals((object) this.SAPVersionField, (object) value))
            return;
          this.SAPVersionField = value;
          this.RaisePropertyChanged(nameof (SAPVersion));
        }
      }

      [DataMember]
      public string Schemaversion
      {
        get => this.SchemaversionField;
        set
        {
          if (object.ReferenceEquals((object) this.SchemaversionField, (object) value))
            return;
          this.SchemaversionField = value;
          this.RaisePropertyChanged(nameof (Schemaversion));
        }
      }

      [DataMember]
      public string SecondName
      {
        get => this.SecondNameField;
        set
        {
          if (object.ReferenceEquals((object) this.SecondNameField, (object) value))
            return;
          this.SecondNameField = value;
          this.RaisePropertyChanged(nameof (SecondName));
        }
      }

      [DataMember]
      public string SoftwareVersion
      {
        get => this.SoftwareVersionField;
        set
        {
          if (object.ReferenceEquals((object) this.SoftwareVersionField, (object) value))
            return;
          this.SoftwareVersionField = value;
          this.RaisePropertyChanged(nameof (SoftwareVersion));
        }
      }

      [DataMember]
      public string Softwaretype
      {
        get => this.SoftwaretypeField;
        set
        {
          if (object.ReferenceEquals((object) this.SoftwaretypeField, (object) value))
            return;
          this.SoftwaretypeField = value;
          this.RaisePropertyChanged(nameof (Softwaretype));
        }
      }

      [DataMember]
      public int Success
      {
        get => this.SuccessField;
        set
        {
          if (this.SuccessField.Equals(value))
            return;
          this.SuccessField = value;
          this.RaisePropertyChanged(nameof (Success));
        }
      }

      [DataMember]
      public int SurveyType
      {
        get => this.SurveyTypeField;
        set
        {
          if (this.SurveyTypeField.Equals(value))
            return;
          this.SurveyTypeField = value;
          this.RaisePropertyChanged(nameof (SurveyType));
        }
      }

      [DataMember]
      public int UserID
      {
        get => this.UserIDField;
        set
        {
          if (this.UserIDField.Equals(value))
            return;
          this.UserIDField = value;
          this.RaisePropertyChanged(nameof (UserID));
        }
      }

      [DataMember]
      public string UserName
      {
        get => this.UserNameField;
        set
        {
          if (object.ReferenceEquals((object) this.UserNameField, (object) value))
            return;
          this.UserNameField = value;
          this.RaisePropertyChanged(nameof (UserName));
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

    [DebuggerStepThrough]
    [GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
    [DataContract(Name = "Survey_Class.Windows_Class", Namespace = "http://schemas.datacontract.org/2004/07/StromaServices")]
    [Serializable]
    public class Windows_Class : Survey_Class.BaseWindows
    {
      [OptionalField]
      private int DoorCountField;
      [OptionalField]
      private Survey_Class.ExtendedWindows[] ExtendedWindowsField;
      [OptionalField]
      private int GlazedAreaField;
      [OptionalField]
      private int InsulatedDoorCountField;
      [OptionalField]
      private double InsulatedUValueField;
      [OptionalField]
      private double MultipleGlazedProportionField;
      [OptionalField]
      private double PercentDraughtProofedField;

      [DataMember]
      public int DoorCount
      {
        get => this.DoorCountField;
        set
        {
          if (this.DoorCountField.Equals(value))
            return;
          this.DoorCountField = value;
          this.RaisePropertyChanged(nameof (DoorCount));
        }
      }

      [DataMember]
      public Survey_Class.ExtendedWindows[] ExtendedWindows
      {
        get => this.ExtendedWindowsField;
        set
        {
          if (object.ReferenceEquals((object) this.ExtendedWindowsField, (object) value))
            return;
          this.ExtendedWindowsField = value;
          this.RaisePropertyChanged(nameof (ExtendedWindows));
        }
      }

      [DataMember]
      public int GlazedArea
      {
        get => this.GlazedAreaField;
        set
        {
          if (this.GlazedAreaField.Equals(value))
            return;
          this.GlazedAreaField = value;
          this.RaisePropertyChanged(nameof (GlazedArea));
        }
      }

      [DataMember]
      public int InsulatedDoorCount
      {
        get => this.InsulatedDoorCountField;
        set
        {
          if (this.InsulatedDoorCountField.Equals(value))
            return;
          this.InsulatedDoorCountField = value;
          this.RaisePropertyChanged(nameof (InsulatedDoorCount));
        }
      }

      [DataMember]
      public double InsulatedUValue
      {
        get => this.InsulatedUValueField;
        set
        {
          if (this.InsulatedUValueField.Equals(value))
            return;
          this.InsulatedUValueField = value;
          this.RaisePropertyChanged(nameof (InsulatedUValue));
        }
      }

      [DataMember]
      public double MultipleGlazedProportion
      {
        get => this.MultipleGlazedProportionField;
        set
        {
          if (this.MultipleGlazedProportionField.Equals(value))
            return;
          this.MultipleGlazedProportionField = value;
          this.RaisePropertyChanged(nameof (MultipleGlazedProportion));
        }
      }

      [DataMember]
      public double PercentDraughtProofed
      {
        get => this.PercentDraughtProofedField;
        set
        {
          if (this.PercentDraughtProofedField.Equals(value))
            return;
          this.PercentDraughtProofedField = value;
          this.RaisePropertyChanged(nameof (PercentDraughtProofed));
        }
      }
    }

    [DebuggerStepThrough]
    [GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
    [DataContract(Name = "Survey_Class.OtherDetails_Class", Namespace = "http://schemas.datacontract.org/2004/07/StromaServices")]
    [Serializable]
    public class OtherDetails_Class : IExtensibleDataObject, INotifyPropertyChanged
    {
      [NonSerialized]
      private ExtensionDataObject extensionDataField;
      [OptionalField]
      private bool MainGasField;
      [OptionalField]
      private bool MechanicalVentilationField;
      [OptionalField]
      private int MeterTypeField;
      [OptionalField]
      private bool SpaceCoolingField;
      [OptionalField]
      private int VentTypeField;

      public ExtensionDataObject ExtensionData
      {
        get => this.extensionDataField;
        set => this.extensionDataField = value;
      }

      [DataMember]
      public bool MainGas
      {
        get => this.MainGasField;
        set
        {
          if (this.MainGasField.Equals(value))
            return;
          this.MainGasField = value;
          this.RaisePropertyChanged(nameof (MainGas));
        }
      }

      [DataMember]
      public bool MechanicalVentilation
      {
        get => this.MechanicalVentilationField;
        set
        {
          if (this.MechanicalVentilationField.Equals(value))
            return;
          this.MechanicalVentilationField = value;
          this.RaisePropertyChanged(nameof (MechanicalVentilation));
        }
      }

      [DataMember]
      public int MeterType
      {
        get => this.MeterTypeField;
        set
        {
          if (this.MeterTypeField.Equals(value))
            return;
          this.MeterTypeField = value;
          this.RaisePropertyChanged(nameof (MeterType));
        }
      }

      [DataMember]
      public bool SpaceCooling
      {
        get => this.SpaceCoolingField;
        set
        {
          if (this.SpaceCoolingField.Equals(value))
            return;
          this.SpaceCoolingField = value;
          this.RaisePropertyChanged(nameof (SpaceCooling));
        }
      }

      [DataMember]
      public int VentType
      {
        get => this.VentTypeField;
        set
        {
          if (this.VentTypeField.Equals(value))
            return;
          this.VentTypeField = value;
          this.RaisePropertyChanged(nameof (VentType));
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

    [DebuggerStepThrough]
    [GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
    [DataContract(Name = "Survey_Class.Renewable_Class", Namespace = "http://schemas.datacontract.org/2004/07/StromaServices")]
    [Serializable]
    public class Renewable_Class : IExtensibleDataObject, INotifyPropertyChanged
    {
      [NonSerialized]
      private ExtensionDataObject extensionDataField;
      [OptionalField]
      private double FixedLightingOutletsCountField;
      [OptionalField]
      private double LowEnergyFixedLightingOutletsField;
      [OptionalField]
      private double LowEnergylightsPercentField;
      [OptionalField]
      private int NoofPvsField;
      [OptionalField]
      private Survey_Class.Renewable_Class.PVArray_Class[] PVArrayField;
      [OptionalField]
      private bool PVConnectedToField;
      [OptionalField]
      private bool PVDetailsField;
      [OptionalField]
      private double PVPercentRoofAreaField;
      [OptionalField]
      private bool PhotovoltaicSupplyPresentField;
      [OptionalField]
      private bool WindTurbineDetailsField;
      [OptionalField]
      private double WindTurbineHubHeightField;
      [OptionalField]
      private bool WindTurbinePresentField;
      [OptionalField]
      private double WindTurbineRotoDiameterField;
      [OptionalField]
      private int WindTurbinesCountField;
      [OptionalField]
      private int WindTurbinesTerrainTypeField;

      public ExtensionDataObject ExtensionData
      {
        get => this.extensionDataField;
        set => this.extensionDataField = value;
      }

      [DataMember]
      public double FixedLightingOutletsCount
      {
        get => this.FixedLightingOutletsCountField;
        set
        {
          if (this.FixedLightingOutletsCountField.Equals(value))
            return;
          this.FixedLightingOutletsCountField = value;
          this.RaisePropertyChanged(nameof (FixedLightingOutletsCount));
        }
      }

      [DataMember]
      public double LowEnergyFixedLightingOutlets
      {
        get => this.LowEnergyFixedLightingOutletsField;
        set
        {
          if (this.LowEnergyFixedLightingOutletsField.Equals(value))
            return;
          this.LowEnergyFixedLightingOutletsField = value;
          this.RaisePropertyChanged(nameof (LowEnergyFixedLightingOutlets));
        }
      }

      [DataMember]
      public double LowEnergylightsPercent
      {
        get => this.LowEnergylightsPercentField;
        set
        {
          if (this.LowEnergylightsPercentField.Equals(value))
            return;
          this.LowEnergylightsPercentField = value;
          this.RaisePropertyChanged(nameof (LowEnergylightsPercent));
        }
      }

      [DataMember]
      public int NoofPvs
      {
        get => this.NoofPvsField;
        set
        {
          if (this.NoofPvsField.Equals(value))
            return;
          this.NoofPvsField = value;
          this.RaisePropertyChanged(nameof (NoofPvs));
        }
      }

      [DataMember]
      public Survey_Class.Renewable_Class.PVArray_Class[] PVArray
      {
        get => this.PVArrayField;
        set
        {
          if (object.ReferenceEquals((object) this.PVArrayField, (object) value))
            return;
          this.PVArrayField = value;
          this.RaisePropertyChanged(nameof (PVArray));
        }
      }

      [DataMember]
      public bool PVConnectedTo
      {
        get => this.PVConnectedToField;
        set
        {
          if (this.PVConnectedToField.Equals(value))
            return;
          this.PVConnectedToField = value;
          this.RaisePropertyChanged(nameof (PVConnectedTo));
        }
      }

      [DataMember]
      public bool PVDetails
      {
        get => this.PVDetailsField;
        set
        {
          if (this.PVDetailsField.Equals(value))
            return;
          this.PVDetailsField = value;
          this.RaisePropertyChanged(nameof (PVDetails));
        }
      }

      [DataMember]
      public double PVPercentRoofArea
      {
        get => this.PVPercentRoofAreaField;
        set
        {
          if (this.PVPercentRoofAreaField.Equals(value))
            return;
          this.PVPercentRoofAreaField = value;
          this.RaisePropertyChanged(nameof (PVPercentRoofArea));
        }
      }

      [DataMember]
      public bool PhotovoltaicSupplyPresent
      {
        get => this.PhotovoltaicSupplyPresentField;
        set
        {
          if (this.PhotovoltaicSupplyPresentField.Equals(value))
            return;
          this.PhotovoltaicSupplyPresentField = value;
          this.RaisePropertyChanged(nameof (PhotovoltaicSupplyPresent));
        }
      }

      [DataMember]
      public bool WindTurbineDetails
      {
        get => this.WindTurbineDetailsField;
        set
        {
          if (this.WindTurbineDetailsField.Equals(value))
            return;
          this.WindTurbineDetailsField = value;
          this.RaisePropertyChanged(nameof (WindTurbineDetails));
        }
      }

      [DataMember]
      public double WindTurbineHubHeight
      {
        get => this.WindTurbineHubHeightField;
        set
        {
          if (this.WindTurbineHubHeightField.Equals(value))
            return;
          this.WindTurbineHubHeightField = value;
          this.RaisePropertyChanged(nameof (WindTurbineHubHeight));
        }
      }

      [DataMember]
      public bool WindTurbinePresent
      {
        get => this.WindTurbinePresentField;
        set
        {
          if (this.WindTurbinePresentField.Equals(value))
            return;
          this.WindTurbinePresentField = value;
          this.RaisePropertyChanged(nameof (WindTurbinePresent));
        }
      }

      [DataMember]
      public double WindTurbineRotoDiameter
      {
        get => this.WindTurbineRotoDiameterField;
        set
        {
          if (this.WindTurbineRotoDiameterField.Equals(value))
            return;
          this.WindTurbineRotoDiameterField = value;
          this.RaisePropertyChanged(nameof (WindTurbineRotoDiameter));
        }
      }

      [DataMember]
      public int WindTurbinesCount
      {
        get => this.WindTurbinesCountField;
        set
        {
          if (this.WindTurbinesCountField.Equals(value))
            return;
          this.WindTurbinesCountField = value;
          this.RaisePropertyChanged(nameof (WindTurbinesCount));
        }
      }

      [DataMember]
      public int WindTurbinesTerrainType
      {
        get => this.WindTurbinesTerrainTypeField;
        set
        {
          if (this.WindTurbinesTerrainTypeField.Equals(value))
            return;
          this.WindTurbinesTerrainTypeField = value;
          this.RaisePropertyChanged(nameof (WindTurbinesTerrainType));
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
      [DataContract(Name = "Survey_Class.Renewable_Class.PVArray_Class", Namespace = "http://schemas.datacontract.org/2004/07/StromaServices")]
      [Serializable]
      public class PVArray_Class : IExtensibleDataObject, INotifyPropertyChanged
      {
        [NonSerialized]
        private ExtensionDataObject extensionDataField;
        [OptionalField]
        private bool ConnectedToField;
        [OptionalField]
        private int OrientationField;
        [OptionalField]
        private int OvershadingField;
        [OptionalField]
        private double PeakPowerField;
        [OptionalField]
        private int PitchField;
        [OptionalField]
        private bool PresentField;

        public ExtensionDataObject ExtensionData
        {
          get => this.extensionDataField;
          set => this.extensionDataField = value;
        }

        [DataMember]
        public bool ConnectedTo
        {
          get => this.ConnectedToField;
          set
          {
            if (this.ConnectedToField.Equals(value))
              return;
            this.ConnectedToField = value;
            this.RaisePropertyChanged(nameof (ConnectedTo));
          }
        }

        [DataMember]
        public int Orientation
        {
          get => this.OrientationField;
          set
          {
            if (this.OrientationField.Equals(value))
              return;
            this.OrientationField = value;
            this.RaisePropertyChanged(nameof (Orientation));
          }
        }

        [DataMember]
        public int Overshading
        {
          get => this.OvershadingField;
          set
          {
            if (this.OvershadingField.Equals(value))
              return;
            this.OvershadingField = value;
            this.RaisePropertyChanged(nameof (Overshading));
          }
        }

        [DataMember]
        public double PeakPower
        {
          get => this.PeakPowerField;
          set
          {
            if (this.PeakPowerField.Equals(value))
              return;
            this.PeakPowerField = value;
            this.RaisePropertyChanged(nameof (PeakPower));
          }
        }

        [DataMember]
        public int Pitch
        {
          get => this.PitchField;
          set
          {
            if (this.PitchField.Equals(value))
              return;
            this.PitchField = value;
            this.RaisePropertyChanged(nameof (Pitch));
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

    [DebuggerStepThrough]
    [GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
    [DataContract(Name = "Survey_Class.SecondaryHeating_Class", Namespace = "http://schemas.datacontract.org/2004/07/StromaServices")]
    [Serializable]
    public class SecondaryHeating_Class : IExtensibleDataObject, INotifyPropertyChanged
    {
      [NonSerialized]
      private ExtensionDataObject extensionDataField;
      [OptionalField]
      private int CodeField;
      [OptionalField]
      private int FuelField;
      [OptionalField]
      private bool PresentField;

      public ExtensionDataObject ExtensionData
      {
        get => this.extensionDataField;
        set => this.extensionDataField = value;
      }

      [DataMember]
      public int Code
      {
        get => this.CodeField;
        set
        {
          if (this.CodeField.Equals(value))
            return;
          this.CodeField = value;
          this.RaisePropertyChanged(nameof (Code));
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

    [DebuggerStepThrough]
    [GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
    [DataContract(Name = "Survey_Class.WaterHeating_Class", Namespace = "http://schemas.datacontract.org/2004/07/StromaServices")]
    [Serializable]
    public class WaterHeating_Class : IExtensibleDataObject, INotifyPropertyChanged
    {
      [NonSerialized]
      private ExtensionDataObject extensionDataField;
      [OptionalField]
      private int CodeField;
      [OptionalField]
      private int CommunityNetworkIndexNumberField;
      [OptionalField]
      private int CylinderInsulationThicknessField;
      [OptionalField]
      private int CylinderInsulationTypeField;
      [OptionalField]
      private int CylinderSizeField;
      [OptionalField]
      private bool CylinderThermostatField;
      [OptionalField]
      private int FuelField;
      [OptionalField]
      private int ImmersionHeatingTypeField;
      [OptionalField]
      private Survey_Class.WaterHeating_Class.SolarWater_Class SolarWaterField;
      [OptionalField]
      private bool TimedSeparatelyField;
      [OptionalField]
      private Survey_Class.WaterHeating_Class.WWHRS_Class WWHRSField;

      public ExtensionDataObject ExtensionData
      {
        get => this.extensionDataField;
        set => this.extensionDataField = value;
      }

      [DataMember]
      public int Code
      {
        get => this.CodeField;
        set
        {
          if (this.CodeField.Equals(value))
            return;
          this.CodeField = value;
          this.RaisePropertyChanged(nameof (Code));
        }
      }

      [DataMember]
      public int CommunityNetworkIndexNumber
      {
        get => this.CommunityNetworkIndexNumberField;
        set
        {
          if (this.CommunityNetworkIndexNumberField.Equals(value))
            return;
          this.CommunityNetworkIndexNumberField = value;
          this.RaisePropertyChanged(nameof (CommunityNetworkIndexNumber));
        }
      }

      [DataMember]
      public int CylinderInsulationThickness
      {
        get => this.CylinderInsulationThicknessField;
        set
        {
          if (this.CylinderInsulationThicknessField.Equals(value))
            return;
          this.CylinderInsulationThicknessField = value;
          this.RaisePropertyChanged(nameof (CylinderInsulationThickness));
        }
      }

      [DataMember]
      public int CylinderInsulationType
      {
        get => this.CylinderInsulationTypeField;
        set
        {
          if (this.CylinderInsulationTypeField.Equals(value))
            return;
          this.CylinderInsulationTypeField = value;
          this.RaisePropertyChanged(nameof (CylinderInsulationType));
        }
      }

      [DataMember]
      public int CylinderSize
      {
        get => this.CylinderSizeField;
        set
        {
          if (this.CylinderSizeField.Equals(value))
            return;
          this.CylinderSizeField = value;
          this.RaisePropertyChanged(nameof (CylinderSize));
        }
      }

      [DataMember]
      public bool CylinderThermostat
      {
        get => this.CylinderThermostatField;
        set
        {
          if (this.CylinderThermostatField.Equals(value))
            return;
          this.CylinderThermostatField = value;
          this.RaisePropertyChanged(nameof (CylinderThermostat));
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
      public int ImmersionHeatingType
      {
        get => this.ImmersionHeatingTypeField;
        set
        {
          if (this.ImmersionHeatingTypeField.Equals(value))
            return;
          this.ImmersionHeatingTypeField = value;
          this.RaisePropertyChanged(nameof (ImmersionHeatingType));
        }
      }

      [DataMember]
      public Survey_Class.WaterHeating_Class.SolarWater_Class SolarWater
      {
        get => this.SolarWaterField;
        set
        {
          if (object.ReferenceEquals((object) this.SolarWaterField, (object) value))
            return;
          this.SolarWaterField = value;
          this.RaisePropertyChanged(nameof (SolarWater));
        }
      }

      [DataMember]
      public bool TimedSeparately
      {
        get => this.TimedSeparatelyField;
        set
        {
          if (this.TimedSeparatelyField.Equals(value))
            return;
          this.TimedSeparatelyField = value;
          this.RaisePropertyChanged(nameof (TimedSeparately));
        }
      }

      [DataMember]
      public Survey_Class.WaterHeating_Class.WWHRS_Class WWHRS
      {
        get => this.WWHRSField;
        set
        {
          if (object.ReferenceEquals((object) this.WWHRSField, (object) value))
            return;
          this.WWHRSField = value;
          this.RaisePropertyChanged(nameof (WWHRS));
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
      [DataContract(Name = "Survey_Class.WaterHeating_Class.SolarWater_Class", Namespace = "http://schemas.datacontract.org/2004/07/StromaServices")]
      [Serializable]
      public class SolarWater_Class : IExtensibleDataObject, INotifyPropertyChanged
      {
        [NonSerialized]
        private ExtensionDataObject extensionDataField;
        [OptionalField]
        private double ApertureAreaField;
        [OptionalField]
        private bool CollectorDetailsKnownField;
        [OptionalField]
        private int CollectorTypeField;
        [OptionalField]
        private bool CombinedField;
        [OptionalField]
        private int DataSourceField;
        [OptionalField]
        private bool DetailsField;
        [OptionalField]
        private double EfficiencyField;
        [OptionalField]
        private double HeatLossField;
        [OptionalField]
        private int OrientationField;
        [OptionalField]
        private int OvershadingField;
        [OptionalField]
        private double PeakPowerField;
        [OptionalField]
        private int PitchField;
        [OptionalField]
        private bool PresentField;
        [OptionalField]
        private double SecondOrderHeatLossField;
        [OptionalField]
        private int ShowerTypeField;
        [OptionalField]
        private bool StoreDetailsKnownField;
        [OptionalField]
        private double StoreVolumeField;
        [OptionalField]
        private int TotalStorevalueField;
        [OptionalField]
        private int WaterPumpField;

        public ExtensionDataObject ExtensionData
        {
          get => this.extensionDataField;
          set => this.extensionDataField = value;
        }

        [DataMember]
        public double ApertureArea
        {
          get => this.ApertureAreaField;
          set
          {
            if (this.ApertureAreaField.Equals(value))
              return;
            this.ApertureAreaField = value;
            this.RaisePropertyChanged(nameof (ApertureArea));
          }
        }

        [DataMember]
        public bool CollectorDetailsKnown
        {
          get => this.CollectorDetailsKnownField;
          set
          {
            if (this.CollectorDetailsKnownField.Equals(value))
              return;
            this.CollectorDetailsKnownField = value;
            this.RaisePropertyChanged(nameof (CollectorDetailsKnown));
          }
        }

        [DataMember]
        public int CollectorType
        {
          get => this.CollectorTypeField;
          set
          {
            if (this.CollectorTypeField.Equals(value))
              return;
            this.CollectorTypeField = value;
            this.RaisePropertyChanged(nameof (CollectorType));
          }
        }

        [DataMember]
        public bool Combined
        {
          get => this.CombinedField;
          set
          {
            if (this.CombinedField.Equals(value))
              return;
            this.CombinedField = value;
            this.RaisePropertyChanged(nameof (Combined));
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
        public bool Details
        {
          get => this.DetailsField;
          set
          {
            if (this.DetailsField.Equals(value))
              return;
            this.DetailsField = value;
            this.RaisePropertyChanged(nameof (Details));
          }
        }

        [DataMember]
        public double Efficiency
        {
          get => this.EfficiencyField;
          set
          {
            if (this.EfficiencyField.Equals(value))
              return;
            this.EfficiencyField = value;
            this.RaisePropertyChanged(nameof (Efficiency));
          }
        }

        [DataMember]
        public double HeatLoss
        {
          get => this.HeatLossField;
          set
          {
            if (this.HeatLossField.Equals(value))
              return;
            this.HeatLossField = value;
            this.RaisePropertyChanged(nameof (HeatLoss));
          }
        }

        [DataMember]
        public int Orientation
        {
          get => this.OrientationField;
          set
          {
            if (this.OrientationField.Equals(value))
              return;
            this.OrientationField = value;
            this.RaisePropertyChanged(nameof (Orientation));
          }
        }

        [DataMember]
        public int Overshading
        {
          get => this.OvershadingField;
          set
          {
            if (this.OvershadingField.Equals(value))
              return;
            this.OvershadingField = value;
            this.RaisePropertyChanged(nameof (Overshading));
          }
        }

        [DataMember]
        public double PeakPower
        {
          get => this.PeakPowerField;
          set
          {
            if (this.PeakPowerField.Equals(value))
              return;
            this.PeakPowerField = value;
            this.RaisePropertyChanged(nameof (PeakPower));
          }
        }

        [DataMember]
        public int Pitch
        {
          get => this.PitchField;
          set
          {
            if (this.PitchField.Equals(value))
              return;
            this.PitchField = value;
            this.RaisePropertyChanged(nameof (Pitch));
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
        public double SecondOrderHeatLoss
        {
          get => this.SecondOrderHeatLossField;
          set
          {
            if (this.SecondOrderHeatLossField.Equals(value))
              return;
            this.SecondOrderHeatLossField = value;
            this.RaisePropertyChanged(nameof (SecondOrderHeatLoss));
          }
        }

        [DataMember]
        public int ShowerType
        {
          get => this.ShowerTypeField;
          set
          {
            if (this.ShowerTypeField.Equals(value))
              return;
            this.ShowerTypeField = value;
            this.RaisePropertyChanged(nameof (ShowerType));
          }
        }

        [DataMember]
        public bool StoreDetailsKnown
        {
          get => this.StoreDetailsKnownField;
          set
          {
            if (this.StoreDetailsKnownField.Equals(value))
              return;
            this.StoreDetailsKnownField = value;
            this.RaisePropertyChanged(nameof (StoreDetailsKnown));
          }
        }

        [DataMember]
        public double StoreVolume
        {
          get => this.StoreVolumeField;
          set
          {
            if (this.StoreVolumeField.Equals(value))
              return;
            this.StoreVolumeField = value;
            this.RaisePropertyChanged(nameof (StoreVolume));
          }
        }

        [DataMember]
        public int TotalStorevalue
        {
          get => this.TotalStorevalueField;
          set
          {
            if (this.TotalStorevalueField.Equals(value))
              return;
            this.TotalStorevalueField = value;
            this.RaisePropertyChanged(nameof (TotalStorevalue));
          }
        }

        [DataMember]
        public int WaterPump
        {
          get => this.WaterPumpField;
          set
          {
            if (this.WaterPumpField.Equals(value))
              return;
            this.WaterPumpField = value;
            this.RaisePropertyChanged(nameof (WaterPump));
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

      [DebuggerStepThrough]
      [GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
      [DataContract(Name = "Survey_Class.WaterHeating_Class.WWHRS_Class", Namespace = "http://schemas.datacontract.org/2004/07/StromaServices")]
      [Serializable]
      public class WWHRS_Class : IExtensibleDataObject, INotifyPropertyChanged
      {
        [NonSerialized]
        private ExtensionDataObject extensionDataField;
        [OptionalField]
        private int PresentField;
        [OptionalField]
        private int RoomsWithBathAndOrShowerField;
        [OptionalField]
        private int RoomsWithBathAndShowerField;
        [OptionalField]
        private int RoomsWithMixedShowerNoBathField;
        [OptionalField]
        private bool StorageCombinedField;
        [OptionalField]
        private int StorageVolumeField;
        [OptionalField]
        private Survey_Class.WaterHeating_Class.WWHRS_Class.System_Class[] SystemField;
        [OptionalField]
        private int WWHRSTotalField;
        [OptionalField]
        private int WWHRSTypeField;

        public ExtensionDataObject ExtensionData
        {
          get => this.extensionDataField;
          set => this.extensionDataField = value;
        }

        [DataMember]
        public int Present
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
        public int RoomsWithBathAndOrShower
        {
          get => this.RoomsWithBathAndOrShowerField;
          set
          {
            if (this.RoomsWithBathAndOrShowerField.Equals(value))
              return;
            this.RoomsWithBathAndOrShowerField = value;
            this.RaisePropertyChanged(nameof (RoomsWithBathAndOrShower));
          }
        }

        [DataMember]
        public int RoomsWithBathAndShower
        {
          get => this.RoomsWithBathAndShowerField;
          set
          {
            if (this.RoomsWithBathAndShowerField.Equals(value))
              return;
            this.RoomsWithBathAndShowerField = value;
            this.RaisePropertyChanged(nameof (RoomsWithBathAndShower));
          }
        }

        [DataMember]
        public int RoomsWithMixedShowerNoBath
        {
          get => this.RoomsWithMixedShowerNoBathField;
          set
          {
            if (this.RoomsWithMixedShowerNoBathField.Equals(value))
              return;
            this.RoomsWithMixedShowerNoBathField = value;
            this.RaisePropertyChanged(nameof (RoomsWithMixedShowerNoBath));
          }
        }

        [DataMember]
        public bool StorageCombined
        {
          get => this.StorageCombinedField;
          set
          {
            if (this.StorageCombinedField.Equals(value))
              return;
            this.StorageCombinedField = value;
            this.RaisePropertyChanged(nameof (StorageCombined));
          }
        }

        [DataMember]
        public int StorageVolume
        {
          get => this.StorageVolumeField;
          set
          {
            if (this.StorageVolumeField.Equals(value))
              return;
            this.StorageVolumeField = value;
            this.RaisePropertyChanged(nameof (StorageVolume));
          }
        }

        [DataMember]
        public Survey_Class.WaterHeating_Class.WWHRS_Class.System_Class[] System
        {
          get => this.SystemField;
          set
          {
            if (object.ReferenceEquals((object) this.SystemField, (object) value))
              return;
            this.SystemField = value;
            this.RaisePropertyChanged(nameof (System));
          }
        }

        [DataMember]
        public int WWHRSTotal
        {
          get => this.WWHRSTotalField;
          set
          {
            if (this.WWHRSTotalField.Equals(value))
              return;
            this.WWHRSTotalField = value;
            this.RaisePropertyChanged(nameof (WWHRSTotal));
          }
        }

        [DataMember]
        public int WWHRSType
        {
          get => this.WWHRSTypeField;
          set
          {
            if (this.WWHRSTypeField.Equals(value))
              return;
            this.WWHRSTypeField = value;
            this.RaisePropertyChanged(nameof (WWHRSType));
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
        [DataContract(Name = "Survey_Class.WaterHeating_Class.WWHRS_Class.System_Class", Namespace = "http://schemas.datacontract.org/2004/07/StromaServices")]
        [Serializable]
        public class System_Class : IExtensibleDataObject, INotifyPropertyChanged
        {
          [NonSerialized]
          private ExtensionDataObject extensionDataField;
          [OptionalField]
          private int IndexNumField;
          [OptionalField]
          private int MixedShowerWithSystemWithBathField;
          [OptionalField]
          private int MixedShowerWithSystemWithoutBathField;
          [OptionalField]
          private int StorageShowersAndBathsInUseField;
          [OptionalField]
          private int StorageTotalShowersField;

          public ExtensionDataObject ExtensionData
          {
            get => this.extensionDataField;
            set => this.extensionDataField = value;
          }

          [DataMember]
          public int IndexNum
          {
            get => this.IndexNumField;
            set
            {
              if (this.IndexNumField.Equals(value))
                return;
              this.IndexNumField = value;
              this.RaisePropertyChanged(nameof (IndexNum));
            }
          }

          [DataMember]
          public int MixedShowerWithSystemWithBath
          {
            get => this.MixedShowerWithSystemWithBathField;
            set
            {
              if (this.MixedShowerWithSystemWithBathField.Equals(value))
                return;
              this.MixedShowerWithSystemWithBathField = value;
              this.RaisePropertyChanged(nameof (MixedShowerWithSystemWithBath));
            }
          }

          [DataMember]
          public int MixedShowerWithSystemWithoutBath
          {
            get => this.MixedShowerWithSystemWithoutBathField;
            set
            {
              if (this.MixedShowerWithSystemWithoutBathField.Equals(value))
                return;
              this.MixedShowerWithSystemWithoutBathField = value;
              this.RaisePropertyChanged(nameof (MixedShowerWithSystemWithoutBath));
            }
          }

          [DataMember]
          public int StorageShowersAndBathsInUse
          {
            get => this.StorageShowersAndBathsInUseField;
            set
            {
              if (this.StorageShowersAndBathsInUseField.Equals(value))
                return;
              this.StorageShowersAndBathsInUseField = value;
              this.RaisePropertyChanged(nameof (StorageShowersAndBathsInUse));
            }
          }

          [DataMember]
          public int StorageTotalShowers
          {
            get => this.StorageTotalShowersField;
            set
            {
              if (this.StorageTotalShowersField.Equals(value))
                return;
              this.StorageTotalShowersField = value;
              this.RaisePropertyChanged(nameof (StorageTotalShowers));
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

    [DebuggerStepThrough]
    [GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
    [DataContract(Name = "Survey_Class.BaseWindows", Namespace = "http://schemas.datacontract.org/2004/07/StromaServices")]
    [KnownType(typeof (Survey_Class.ExtendedWindows))]
    [KnownType(typeof (Survey_Class.Windows_Class))]
    [Serializable]
    public class BaseWindows : IExtensibleDataObject, INotifyPropertyChanged
    {
      [NonSerialized]
      private ExtensionDataObject extensionDataField;
      [OptionalField]
      private int GlazingGapField;
      [OptionalField]
      private bool PVCWindowFramesField;
      [OptionalField]
      private int WindowDataSourceField;
      [OptionalField]
      private int WindowMultipleGlazedTypeField;
      [OptionalField]
      private double WindowSolarTransmittanceField;
      [OptionalField]
      private double WindowsUValueField;

      public ExtensionDataObject ExtensionData
      {
        get => this.extensionDataField;
        set => this.extensionDataField = value;
      }

      [DataMember]
      public int GlazingGap
      {
        get => this.GlazingGapField;
        set
        {
          if (this.GlazingGapField.Equals(value))
            return;
          this.GlazingGapField = value;
          this.RaisePropertyChanged(nameof (GlazingGap));
        }
      }

      [DataMember]
      public bool PVCWindowFrames
      {
        get => this.PVCWindowFramesField;
        set
        {
          if (this.PVCWindowFramesField.Equals(value))
            return;
          this.PVCWindowFramesField = value;
          this.RaisePropertyChanged(nameof (PVCWindowFrames));
        }
      }

      [DataMember]
      public int WindowDataSource
      {
        get => this.WindowDataSourceField;
        set
        {
          if (this.WindowDataSourceField.Equals(value))
            return;
          this.WindowDataSourceField = value;
          this.RaisePropertyChanged(nameof (WindowDataSource));
        }
      }

      [DataMember]
      public int WindowMultipleGlazedType
      {
        get => this.WindowMultipleGlazedTypeField;
        set
        {
          if (this.WindowMultipleGlazedTypeField.Equals(value))
            return;
          this.WindowMultipleGlazedTypeField = value;
          this.RaisePropertyChanged(nameof (WindowMultipleGlazedType));
        }
      }

      [DataMember]
      public double WindowSolarTransmittance
      {
        get => this.WindowSolarTransmittanceField;
        set
        {
          if (this.WindowSolarTransmittanceField.Equals(value))
            return;
          this.WindowSolarTransmittanceField = value;
          this.RaisePropertyChanged(nameof (WindowSolarTransmittance));
        }
      }

      [DataMember]
      public double WindowsUValue
      {
        get => this.WindowsUValueField;
        set
        {
          if (this.WindowsUValueField.Equals(value))
            return;
          this.WindowsUValueField = value;
          this.RaisePropertyChanged(nameof (WindowsUValue));
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

    [DebuggerStepThrough]
    [GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
    [DataContract(Name = "Survey_Class.ExtendedWindows", Namespace = "http://schemas.datacontract.org/2004/07/StromaServices")]
    [Serializable]
    public class ExtendedWindows : Survey_Class.BaseWindows
    {
      [OptionalField]
      private bool ActiveWindowField;
      [OptionalField]
      private double WindowAreaField;
      [OptionalField]
      private int WindowTypeField;
      [OptionalField]
      private int WindowsLocField;
      [OptionalField]
      private int WindowsOrientationField;

      [DataMember]
      public bool ActiveWindow
      {
        get => this.ActiveWindowField;
        set
        {
          if (this.ActiveWindowField.Equals(value))
            return;
          this.ActiveWindowField = value;
          this.RaisePropertyChanged(nameof (ActiveWindow));
        }
      }

      [DataMember]
      public double WindowArea
      {
        get => this.WindowAreaField;
        set
        {
          if (this.WindowAreaField.Equals(value))
            return;
          this.WindowAreaField = value;
          this.RaisePropertyChanged(nameof (WindowArea));
        }
      }

      [DataMember]
      public int WindowType
      {
        get => this.WindowTypeField;
        set
        {
          if (this.WindowTypeField.Equals(value))
            return;
          this.WindowTypeField = value;
          this.RaisePropertyChanged(nameof (WindowType));
        }
      }

      [DataMember]
      public int WindowsLoc
      {
        get => this.WindowsLocField;
        set
        {
          if (this.WindowsLocField.Equals(value))
            return;
          this.WindowsLocField = value;
          this.RaisePropertyChanged(nameof (WindowsLoc));
        }
      }

      [DataMember]
      public int WindowsOrientation
      {
        get => this.WindowsOrientationField;
        set
        {
          if (this.WindowsOrientationField.Equals(value))
            return;
          this.WindowsOrientationField = value;
          this.RaisePropertyChanged(nameof (WindowsOrientation));
        }
      }
    }
  }
}
