
// Type: SAP2012.RdSAP.SecurityData




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace SAP2012.RdSAP
{
  [DebuggerStepThrough]
  [GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
  [DataContract(Name = "SecurityData", Namespace = "http://schemas.datacontract.org/2004/07/StromaServices")]
  [Serializable]
  public class SecurityData : IExtensibleDataObject, INotifyPropertyChanged
  {
    [NonSerialized]
    private ExtensionDataObject extensionDataField;
    [OptionalField]
    private string EncryptField;
    [OptionalField]
    private string PasswordField;
    [OptionalField]
    private string TransactionIDField;
    [OptionalField]
    private string UsernameField;

    [Browsable(false)]
    public ExtensionDataObject ExtensionData
    {
      get => this.extensionDataField;
      set => this.extensionDataField = value;
    }

    [DataMember]
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

    [DataMember]
    public string Username
    {
      get => this.UsernameField;
      set
      {
        if (object.ReferenceEquals((object) this.UsernameField, (object) value))
          return;
        this.UsernameField = value;
        this.RaisePropertyChanged(nameof (Username));
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
