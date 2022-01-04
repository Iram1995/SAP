
// Type: SAP2012.NISAP.FormattedAddress




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace SAP2012.NISAP
{
  [DebuggerStepThrough]
  [GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
  [DataContract(Name = "FormattedAddress", Namespace = "https://www.stromamembers.co.uk/NISAP.asmx")]
  [Serializable]
  public class FormattedAddress : IExtensibleDataObject, INotifyPropertyChanged
  {
    [NonSerialized]
    private ExtensionDataObject extensionDataField;
    [OptionalField]
    private string UPRNField;
    private bool addressHasEpcInputDataField;
    private bool addressHasSapEpcInputDataField;
    [OptionalField]
    private string addressLine1Field;
    [OptionalField]
    private string addressLine2Field;
    [OptionalField]
    private string addressLine3Field;
    [OptionalField]
    private string postCodeField;
    [OptionalField]
    private string postTownField;

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
    public string addressLine1
    {
      get => this.addressLine1Field;
      set
      {
        if (object.ReferenceEquals((object) this.addressLine1Field, (object) value))
          return;
        this.addressLine1Field = value;
        this.RaisePropertyChanged(nameof (addressLine1));
      }
    }

    [DataMember(EmitDefaultValue = false)]
    public string addressLine2
    {
      get => this.addressLine2Field;
      set
      {
        if (object.ReferenceEquals((object) this.addressLine2Field, (object) value))
          return;
        this.addressLine2Field = value;
        this.RaisePropertyChanged(nameof (addressLine2));
      }
    }

    [DataMember(EmitDefaultValue = false)]
    public string addressLine3
    {
      get => this.addressLine3Field;
      set
      {
        if (object.ReferenceEquals((object) this.addressLine3Field, (object) value))
          return;
        this.addressLine3Field = value;
        this.RaisePropertyChanged(nameof (addressLine3));
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
