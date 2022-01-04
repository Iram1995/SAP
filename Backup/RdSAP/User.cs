
// Type: SAP2012.RdSAP.User




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace SAP2012.RdSAP
{
  [DebuggerStepThrough]
  [GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
  [DataContract(Name = "User", Namespace = "http://schemas.datacontract.org/2004/07/StromaServices")]
  [Serializable]
  public class User : IExtensibleDataObject, INotifyPropertyChanged
  {
    [NonSerialized]
    private ExtensionDataObject extensionDataField;
    [OptionalField]
    private string FirstnameField;
    [OptionalField]
    private string StromaNoField;
    [OptionalField]
    private string SurnameField;
    [OptionalField]
    private int UserIDField;
    [OptionalField]
    private string UsernameField;

    [Browsable(false)]
    public ExtensionDataObject ExtensionData
    {
      get => this.extensionDataField;
      set => this.extensionDataField = value;
    }

    [DataMember]
    public string Firstname
    {
      get => this.FirstnameField;
      set
      {
        if (object.ReferenceEquals((object) this.FirstnameField, (object) value))
          return;
        this.FirstnameField = value;
        this.RaisePropertyChanged(nameof (Firstname));
      }
    }

    [DataMember]
    public string StromaNo
    {
      get => this.StromaNoField;
      set
      {
        if (object.ReferenceEquals((object) this.StromaNoField, (object) value))
          return;
        this.StromaNoField = value;
        this.RaisePropertyChanged(nameof (StromaNo));
      }
    }

    [DataMember]
    public string Surname
    {
      get => this.SurnameField;
      set
      {
        if (object.ReferenceEquals((object) this.SurnameField, (object) value))
          return;
        this.SurnameField = value;
        this.RaisePropertyChanged(nameof (Surname));
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
