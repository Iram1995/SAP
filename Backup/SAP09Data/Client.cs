
// Type: SAP2012.SAP09Data.Client




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace SAP2012.SAP09Data
{
  [DebuggerStepThrough]
  [GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
  [DataContract(Name = "Client", Namespace = "http://rdsap2009.stroma.com/SAPData/SAP09Compliance.asmx")]
  [Serializable]
  public class Client : IExtensibleDataObject, INotifyPropertyChanged
  {
    [NonSerialized]
    private ExtensionDataObject extensionDataField;
    [OptionalField]
    private string NameField;
    private Address AddressField;
    [OptionalField]
    private string PhoneField;
    [OptionalField]
    private string FaxField;
    [OptionalField]
    private string EmailField;

    [Browsable(false)]
    public ExtensionDataObject ExtensionData
    {
      get => this.extensionDataField;
      set => this.extensionDataField = value;
    }

    [DataMember(EmitDefaultValue = false)]
    public string Name
    {
      get => this.NameField;
      set
      {
        if (object.ReferenceEquals((object) this.NameField, (object) value))
          return;
        this.NameField = value;
        this.RaisePropertyChanged(nameof (Name));
      }
    }

    [DataMember(EmitDefaultValue = false, IsRequired = true, Order = 1)]
    public Address Address
    {
      get => this.AddressField;
      set
      {
        if (object.ReferenceEquals((object) this.AddressField, (object) value))
          return;
        this.AddressField = value;
        this.RaisePropertyChanged(nameof (Address));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 2)]
    public string Phone
    {
      get => this.PhoneField;
      set
      {
        if (object.ReferenceEquals((object) this.PhoneField, (object) value))
          return;
        this.PhoneField = value;
        this.RaisePropertyChanged(nameof (Phone));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 3)]
    public string Fax
    {
      get => this.FaxField;
      set
      {
        if (object.ReferenceEquals((object) this.FaxField, (object) value))
          return;
        this.FaxField = value;
        this.RaisePropertyChanged(nameof (Fax));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 4)]
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
