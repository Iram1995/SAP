
// Type: SAP2012.SAPRef.AddressDetails




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace SAP2012.SAPRef
{
  [DebuggerStepThrough]
  [GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
  [DataContract(Name = "AddressDetails", Namespace = "https://www.stromamembers.co.uk/sap.asmx")]
  [Serializable]
  public class AddressDetails : IExtensibleDataObject, INotifyPropertyChanged
  {
    [NonSerialized]
    private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
    [OptionalField]
    private ExtensionDataObject ExtensionData1Field;
    [OptionalField]
    private string AddressLine1Field;
    [OptionalField]
    private string AddressLine2Field;
    [OptionalField]
    private string AddressLine3Field;
    [OptionalField]
    private string AddressLine4Field;
    [OptionalField]
    private string AddressSummaryField;
    [OptionalField]
    private string CityField;
    private int CountryField;
    [OptionalField]
    private string CountyField;
    [OptionalField]
    private string DistrictField;
    [OptionalField]
    private string EastingField;
    private bool HAS_EPCField;
    [OptionalField]
    private string NorthingField;
    [OptionalField]
    private string PostCodeField;
    [OptionalField]
    private string UPRNField;
    [OptionalField]
    private string WardField;
    [OptionalField]
    private string existingAssessmentsField;
    [OptionalField]
    private string temporaryField;

    [Browsable(false)]
    public System.Runtime.Serialization.ExtensionDataObject ExtensionData
    {
      get => this.extensionDataField;
      set => this.extensionDataField = value;
    }

    [DataMember(EmitDefaultValue = false, Name = "ExtensionData")]
    public ExtensionDataObject ExtensionData1
    {
      get => this.ExtensionData1Field;
      set
      {
        if (object.ReferenceEquals((object) this.ExtensionData1Field, (object) value))
          return;
        this.ExtensionData1Field = value;
        this.RaisePropertyChanged(nameof (ExtensionData1));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 1)]
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

    [DataMember(EmitDefaultValue = false, Order = 2)]
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

    [DataMember(EmitDefaultValue = false, Order = 3)]
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

    [DataMember(EmitDefaultValue = false, Order = 4)]
    public string AddressLine4
    {
      get => this.AddressLine4Field;
      set
      {
        if (object.ReferenceEquals((object) this.AddressLine4Field, (object) value))
          return;
        this.AddressLine4Field = value;
        this.RaisePropertyChanged(nameof (AddressLine4));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 5)]
    public string AddressSummary
    {
      get => this.AddressSummaryField;
      set
      {
        if (object.ReferenceEquals((object) this.AddressSummaryField, (object) value))
          return;
        this.AddressSummaryField = value;
        this.RaisePropertyChanged(nameof (AddressSummary));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 6)]
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

    [DataMember(IsRequired = true, Order = 7)]
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

    [DataMember(EmitDefaultValue = false, Order = 8)]
    public string County
    {
      get => this.CountyField;
      set
      {
        if (object.ReferenceEquals((object) this.CountyField, (object) value))
          return;
        this.CountyField = value;
        this.RaisePropertyChanged(nameof (County));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 9)]
    public string District
    {
      get => this.DistrictField;
      set
      {
        if (object.ReferenceEquals((object) this.DistrictField, (object) value))
          return;
        this.DistrictField = value;
        this.RaisePropertyChanged(nameof (District));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 10)]
    public string Easting
    {
      get => this.EastingField;
      set
      {
        if (object.ReferenceEquals((object) this.EastingField, (object) value))
          return;
        this.EastingField = value;
        this.RaisePropertyChanged(nameof (Easting));
      }
    }

    [DataMember(IsRequired = true, Order = 11)]
    public bool HAS_EPC
    {
      get => this.HAS_EPCField;
      set
      {
        if (this.HAS_EPCField.Equals(value))
          return;
        this.HAS_EPCField = value;
        this.RaisePropertyChanged(nameof (HAS_EPC));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 12)]
    public string Northing
    {
      get => this.NorthingField;
      set
      {
        if (object.ReferenceEquals((object) this.NorthingField, (object) value))
          return;
        this.NorthingField = value;
        this.RaisePropertyChanged(nameof (Northing));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 13)]
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

    [DataMember(EmitDefaultValue = false, Order = 14)]
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

    [DataMember(EmitDefaultValue = false, Order = 15)]
    public string Ward
    {
      get => this.WardField;
      set
      {
        if (object.ReferenceEquals((object) this.WardField, (object) value))
          return;
        this.WardField = value;
        this.RaisePropertyChanged(nameof (Ward));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 16)]
    public string existingAssessments
    {
      get => this.existingAssessmentsField;
      set
      {
        if (object.ReferenceEquals((object) this.existingAssessmentsField, (object) value))
          return;
        this.existingAssessmentsField = value;
        this.RaisePropertyChanged(nameof (existingAssessments));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 17)]
    public string temporary
    {
      get => this.temporaryField;
      set
      {
        if (object.ReferenceEquals((object) this.temporaryField, (object) value))
          return;
        this.temporaryField = value;
        this.RaisePropertyChanged(nameof (temporary));
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
