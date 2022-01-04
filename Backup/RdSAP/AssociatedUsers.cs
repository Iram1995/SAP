
// Type: SAP2012.RdSAP.AssociatedUsers




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace SAP2012.RdSAP
{
  [DebuggerStepThrough]
  [GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
  [DataContract(Name = "AssociatedUsers", Namespace = "http://schemas.datacontract.org/2004/07/StromaServices")]
  [Serializable]
  public class AssociatedUsers : IExtensibleDataObject, INotifyPropertyChanged
  {
    [NonSerialized]
    private ExtensionDataObject extensionDataField;
    [OptionalField]
    private User[] companyUsersField;
    [OptionalField]
    private string errorMessageField;
    [OptionalField]
    private User[] groupedUsersField;
    [OptionalField]
    private bool successField;

    [Browsable(false)]
    public ExtensionDataObject ExtensionData
    {
      get => this.extensionDataField;
      set => this.extensionDataField = value;
    }

    [DataMember]
    public User[] companyUsers
    {
      get => this.companyUsersField;
      set
      {
        if (object.ReferenceEquals((object) this.companyUsersField, (object) value))
          return;
        this.companyUsersField = value;
        this.RaisePropertyChanged(nameof (companyUsers));
      }
    }

    [DataMember]
    public string errorMessage
    {
      get => this.errorMessageField;
      set
      {
        if (object.ReferenceEquals((object) this.errorMessageField, (object) value))
          return;
        this.errorMessageField = value;
        this.RaisePropertyChanged(nameof (errorMessage));
      }
    }

    [DataMember]
    public User[] groupedUsers
    {
      get => this.groupedUsersField;
      set
      {
        if (object.ReferenceEquals((object) this.groupedUsersField, (object) value))
          return;
        this.groupedUsersField = value;
        this.RaisePropertyChanged(nameof (groupedUsers));
      }
    }

    [DataMember]
    public bool success
    {
      get => this.successField;
      set
      {
        if (this.successField.Equals(value))
          return;
        this.successField = value;
        this.RaisePropertyChanged(nameof (success));
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
