
// Type: SAP2012.SAPRef.HQMRequest




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace SAP2012.SAPRef
{
  [DebuggerStepThrough]
  [GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
  [DataContract(Name = "HQMRequest", Namespace = "https://www.stromamembers.co.uk/sap.asmx")]
  [Serializable]
  public class HQMRequest : IExtensibleDataObject, INotifyPropertyChanged
  {
    [NonSerialized]
    private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
    [OptionalField]
    private string XMLField;
    [OptionalField]
    private string EacertificateNoField;
    [OptionalField]
    private string AddressLine1Field;
    [OptionalField]
    private string PostcodeField;
    [OptionalField]
    private string TransactionIDField;
    [OptionalField]
    private string EncryptField;
    [OptionalField]
    private string RRNField;

    [Browsable(false)]
    public System.Runtime.Serialization.ExtensionDataObject ExtensionData
    {
      get => this.extensionDataField;
      set => this.extensionDataField = value;
    }

    [DataMember(EmitDefaultValue = false)]
    public string XML
    {
      get => this.XMLField;
      set
      {
        if (object.ReferenceEquals((object) this.XMLField, (object) value))
          return;
        this.XMLField = value;
        this.RaisePropertyChanged(nameof (XML));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 1)]
    public string EacertificateNo
    {
      get => this.EacertificateNoField;
      set
      {
        if (object.ReferenceEquals((object) this.EacertificateNoField, (object) value))
          return;
        this.EacertificateNoField = value;
        this.RaisePropertyChanged(nameof (EacertificateNo));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 2)]
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

    [DataMember(EmitDefaultValue = false, Order = 3)]
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

    [DataMember(EmitDefaultValue = false, Order = 4)]
    public string TransactionID
    {
      get => this.TransactionIDField;
      set
      {
        if (object.ReferenceEquals((object) this.TransactionIDField, (object) value))
          return;
        this.TransactionIDField = value;
        this.RaisePropertyChanged(nameof (TransactionID));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 5)]
    public string Encrypt
    {
      get => this.EncryptField;
      set
      {
        if (object.ReferenceEquals((object) this.EncryptField, (object) value))
          return;
        this.EncryptField = value;
        this.RaisePropertyChanged(nameof (Encrypt));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 6)]
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
