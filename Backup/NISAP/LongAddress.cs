
// Type: SAP2012.NISAP.LongAddress




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace SAP2012.NISAP
{
  [DebuggerStepThrough]
  [GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
  [DataContract(Name = "LongAddress", Namespace = "https://www.stromamembers.co.uk/NISAP.asmx")]
  [Serializable]
  public class LongAddress : IExtensibleDataObject, INotifyPropertyChanged
  {
    [NonSerialized]
    private ExtensionDataObject extensionDataField;
    [OptionalField]
    private string UPRNField;
    private bool addressHasEpcInputDataField;
    private bool addressHasSapEpcInputDataField;
    [OptionalField]
    private string buildingNameField;
    [OptionalField]
    private string buildingNumberField;
    [OptionalField]
    private string countyField;
    [OptionalField]
    private string dependantLocalityField;
    [OptionalField]
    private string dependantThoroughFareDescriptorField;
    [OptionalField]
    private string dependantThoroughFareNameField;
    [OptionalField]
    private string doubleDependantLocalityField;
    [OptionalField]
    private string postCodeField;
    [OptionalField]
    private string postTownField;
    [OptionalField]
    private string subBuildingNameField;
    [OptionalField]
    private string thoroughFareDescriptorField;
    [OptionalField]
    private string thoroughFareNameField;

    [Browsable(false)]
    public ExtensionDataObject ExtensionData
    {
      get => this.extensionDataField;
      set => this.extensionDataField = value;
    }

    [DataMember(EmitDefaultValue = false)]
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

    [DataMember(IsRequired = true)]
    public bool addressHasEpcInputData
    {
      get => this.addressHasEpcInputDataField;
      set
      {
        if (this.addressHasEpcInputDataField.Equals(value))
          return;
        this.addressHasEpcInputDataField = value;
        this.RaisePropertyChanged(nameof (addressHasEpcInputData));
      }
    }

    [DataMember(IsRequired = true)]
    public bool addressHasSapEpcInputData
    {
      get => this.addressHasSapEpcInputDataField;
      set
      {
        if (this.addressHasSapEpcInputDataField.Equals(value))
          return;
        this.addressHasSapEpcInputDataField = value;
        this.RaisePropertyChanged(nameof (addressHasSapEpcInputData));
      }
    }

    [DataMember(EmitDefaultValue = false)]
    public string buildingName
    {
      get => this.buildingNameField;
      set
      {
        if (object.ReferenceEquals((object) this.buildingNameField, (object) value))
          return;
        this.buildingNameField = value;
        this.RaisePropertyChanged(nameof (buildingName));
      }
    }

    [DataMember(EmitDefaultValue = false)]
    public string buildingNumber
    {
      get => this.buildingNumberField;
      set
      {
        if (object.ReferenceEquals((object) this.buildingNumberField, (object) value))
          return;
        this.buildingNumberField = value;
        this.RaisePropertyChanged(nameof (buildingNumber));
      }
    }

    [DataMember(EmitDefaultValue = false)]
    public string county
    {
      get => this.countyField;
      set
      {
        if (object.ReferenceEquals((object) this.countyField, (object) value))
          return;
        this.countyField = value;
        this.RaisePropertyChanged(nameof (county));
      }
    }

    [DataMember(EmitDefaultValue = false)]
    public string dependantLocality
    {
      get => this.dependantLocalityField;
      set
      {
        if (object.ReferenceEquals((object) this.dependantLocalityField, (object) value))
          return;
        this.dependantLocalityField = value;
        this.RaisePropertyChanged(nameof (dependantLocality));
      }
    }

    [DataMember(EmitDefaultValue = false)]
    public string dependantThoroughFareDescriptor
    {
      get => this.dependantThoroughFareDescriptorField;
      set
      {
        if (object.ReferenceEquals((object) this.dependantThoroughFareDescriptorField, (object) value))
          return;
        this.dependantThoroughFareDescriptorField = value;
        this.RaisePropertyChanged(nameof (dependantThoroughFareDescriptor));
      }
    }

    [DataMember(EmitDefaultValue = false)]
    public string dependantThoroughFareName
    {
      get => this.dependantThoroughFareNameField;
      set
      {
        if (object.ReferenceEquals((object) this.dependantThoroughFareNameField, (object) value))
          return;
        this.dependantThoroughFareNameField = value;
        this.RaisePropertyChanged(nameof (dependantThoroughFareName));
      }
    }

    [DataMember(EmitDefaultValue = false)]
    public string doubleDependantLocality
    {
      get => this.doubleDependantLocalityField;
      set
      {
        if (object.ReferenceEquals((object) this.doubleDependantLocalityField, (object) value))
          return;
        this.doubleDependantLocalityField = value;
        this.RaisePropertyChanged(nameof (doubleDependantLocality));
      }
    }

    [DataMember(EmitDefaultValue = false)]
    public string postCode
    {
      get => this.postCodeField;
      set
      {
        if (object.ReferenceEquals((object) this.postCodeField, (object) value))
          return;
        this.postCodeField = value;
        this.RaisePropertyChanged(nameof (postCode));
      }
    }

    [DataMember(EmitDefaultValue = false)]
    public string postTown
    {
      get => this.postTownField;
      set
      {
        if (object.ReferenceEquals((object) this.postTownField, (object) value))
          return;
        this.postTownField = value;
        this.RaisePropertyChanged(nameof (postTown));
      }
    }

    [DataMember(EmitDefaultValue = false)]
    public string subBuildingName
    {
      get => this.subBuildingNameField;
      set
      {
        if (object.ReferenceEquals((object) this.subBuildingNameField, (object) value))
          return;
        this.subBuildingNameField = value;
        this.RaisePropertyChanged(nameof (subBuildingName));
      }
    }

    [DataMember(EmitDefaultValue = false)]
    public string thoroughFareDescriptor
    {
      get => this.thoroughFareDescriptorField;
      set
      {
        if (object.ReferenceEquals((object) this.thoroughFareDescriptorField, (object) value))
          return;
        this.thoroughFareDescriptorField = value;
        this.RaisePropertyChanged(nameof (thoroughFareDescriptor));
      }
    }

    [DataMember(EmitDefaultValue = false)]
    public string thoroughFareName
    {
      get => this.thoroughFareNameField;
      set
      {
        if (object.ReferenceEquals((object) this.thoroughFareNameField, (object) value))
          return;
        this.thoroughFareNameField = value;
        this.RaisePropertyChanged(nameof (thoroughFareName));
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
