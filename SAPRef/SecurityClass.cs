
// Type: SAP2012.SAPRef.SecurityClass




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace SAP2012.SAPRef
{
  [DebuggerStepThrough]
  [GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
  [DataContract(Name = "SecurityClass", Namespace = "https://www.stromamembers.co.uk/sap.asmx")]
  [Serializable]
  public class SecurityClass : IExtensibleDataObject, INotifyPropertyChanged
  {
    [NonSerialized]
    private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
    [OptionalField]
    private string EncryptionField;
    [OptionalField]
    private string TransactionField;

    [Browsable(false)]
    public System.Runtime.Serialization.ExtensionDataObject ExtensionData
    {
      get => this.extensionDataField;
      set => this.extensionDataField = value;
    }

    [DataMember(EmitDefaultValue = false)]
    public string Encryption
    {
      get => this.EncryptionField;
      set
      {
        if (object.ReferenceEquals((object) this.EncryptionField, (object) value))
          return;
        this.EncryptionField = value;
        this.RaisePropertyChanged(nameof (Encryption));
      }
    }

    [DataMember(EmitDefaultValue = false)]
    public string Transaction
    {
      get => this.TransactionField;
      set
      {
        if (object.ReferenceEquals((object) this.TransactionField, (object) value))
          return;
        this.TransactionField = value;
        this.RaisePropertyChanged(nameof (Transaction));
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
