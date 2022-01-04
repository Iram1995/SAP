
// Type: SAP2012.RdSAP.LogonClass




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace SAP2012.RdSAP
{
  [DebuggerStepThrough]
  [GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
  [DataContract(Name = "LogonClass", Namespace = "http://schemas.datacontract.org/2004/07/StromaServices")]
  [Serializable]
  public class LogonClass : IExtensibleDataObject, INotifyPropertyChanged
  {
    [NonSerialized]
    private ExtensionDataObject extensionDataField;
    [OptionalField]
    private bool AdminField;
    [OptionalField]
    private string CompanyIDField;
    [OptionalField]
    private string CompanynameField;
    [OptionalField]
    private bool DEAField;
    [OptionalField]
    private string ErrorMessageField;
    [OptionalField]
    private string FirstnameField;
    [OptionalField]
    private bool GDAssessorPresentField;
    [OptionalField]
    private string IDField;
    [OptionalField]
    private bool InsuranceField;
    [OptionalField]
    private bool IsCompanyField;
    [OptionalField]
    private bool IsIntergratedField;
    [OptionalField]
    private bool IsProviderField;
    [OptionalField]
    private string LastnameField;
    [OptionalField]
    private string StatusField;
    [OptionalField]
    private string StromaNumberField;
    [OptionalField]
    private bool SuccessField;
    [OptionalField]
    private User[] UserListField;

    [Browsable(false)]
    public ExtensionDataObject ExtensionData
    {
      get => this.extensionDataField;
      set => this.extensionDataField = value;
    }

    [DataMember]
    public bool Admin
    {
      get => this.AdminField;
      set
      {
        if (this.AdminField.Equals(value))
          return;
        this.AdminField = value;
        this.RaisePropertyChanged(nameof (Admin));
      }
    }

    [DataMember]
    public string CompanyID
    {
      get => this.CompanyIDField;
      set
      {
        if (object.ReferenceEquals((object) this.CompanyIDField, (object) value))
          return;
        this.CompanyIDField = value;
        this.RaisePropertyChanged(nameof (CompanyID));
      }
    }

    [DataMember]
    public string Companyname
    {
      get => this.CompanynameField;
      set
      {
        if (object.ReferenceEquals((object) this.CompanynameField, (object) value))
          return;
        this.CompanynameField = value;
        this.RaisePropertyChanged(nameof (Companyname));
      }
    }

    [DataMember]
    public bool DEA
    {
      get => this.DEAField;
      set
      {
        if (this.DEAField.Equals(value))
          return;
        this.DEAField = value;
        this.RaisePropertyChanged(nameof (DEA));
      }
    }

    [DataMember]
    public string ErrorMessage
    {
      get => this.ErrorMessageField;
      set
      {
        if (object.ReferenceEquals((object) this.ErrorMessageField, (object) value))
          return;
        this.ErrorMessageField = value;
        this.RaisePropertyChanged(nameof (ErrorMessage));
      }
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
    public bool GDAssessorPresent
    {
      get => this.GDAssessorPresentField;
      set
      {
        if (this.GDAssessorPresentField.Equals(value))
          return;
        this.GDAssessorPresentField = value;
        this.RaisePropertyChanged(nameof (GDAssessorPresent));
      }
    }

    [DataMember]
    public string ID
    {
      get => this.IDField;
      set
      {
        if (object.ReferenceEquals((object) this.IDField, (object) value))
          return;
        this.IDField = value;
        this.RaisePropertyChanged(nameof (ID));
      }
    }

    [DataMember]
    public bool Insurance
    {
      get => this.InsuranceField;
      set
      {
        if (this.InsuranceField.Equals(value))
          return;
        this.InsuranceField = value;
        this.RaisePropertyChanged(nameof (Insurance));
      }
    }

    [DataMember]
    public bool IsCompany
    {
      get => this.IsCompanyField;
      set
      {
        if (this.IsCompanyField.Equals(value))
          return;
        this.IsCompanyField = value;
        this.RaisePropertyChanged(nameof (IsCompany));
      }
    }

    [DataMember]
    public bool IsIntergrated
    {
      get => this.IsIntergratedField;
      set
      {
        if (this.IsIntergratedField.Equals(value))
          return;
        this.IsIntergratedField = value;
        this.RaisePropertyChanged(nameof (IsIntergrated));
      }
    }

    [DataMember]
    public bool IsProvider
    {
      get => this.IsProviderField;
      set
      {
        if (this.IsProviderField.Equals(value))
          return;
        this.IsProviderField = value;
        this.RaisePropertyChanged(nameof (IsProvider));
      }
    }

    [DataMember]
    public string Lastname
    {
      get => this.LastnameField;
      set
      {
        if (object.ReferenceEquals((object) this.LastnameField, (object) value))
          return;
        this.LastnameField = value;
        this.RaisePropertyChanged(nameof (Lastname));
      }
    }

    [DataMember]
    public string Status
    {
      get => this.StatusField;
      set
      {
        if (object.ReferenceEquals((object) this.StatusField, (object) value))
          return;
        this.StatusField = value;
        this.RaisePropertyChanged(nameof (Status));
      }
    }

    [DataMember]
    public string StromaNumber
    {
      get => this.StromaNumberField;
      set
      {
        if (object.ReferenceEquals((object) this.StromaNumberField, (object) value))
          return;
        this.StromaNumberField = value;
        this.RaisePropertyChanged(nameof (StromaNumber));
      }
    }

    [DataMember]
    public bool Success
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
    public User[] UserList
    {
      get => this.UserListField;
      set
      {
        if (object.ReferenceEquals((object) this.UserListField, (object) value))
          return;
        this.UserListField = value;
        this.RaisePropertyChanged(nameof (UserList));
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
