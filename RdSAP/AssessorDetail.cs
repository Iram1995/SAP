
// Type: SAP2012.RdSAP.AssessorDetail




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace SAP2012.RdSAP
{
  [DebuggerStepThrough]
  [GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
  [DataContract(Name = "AssessorDetail", Namespace = "http://schemas.datacontract.org/2004/07/StromaServices")]
  [Serializable]
  public class AssessorDetail : IExtensibleDataObject, INotifyPropertyChanged
  {
    [NonSerialized]
    private ExtensionDataObject extensionDataField;
    [OptionalField]
    private string AddressLine1Field;
    [OptionalField]
    private string AddressLine2Field;
    [OptionalField]
    private string AddressLine3Field;
    [OptionalField]
    private string AssessorNumberField;
    [OptionalField]
    private string CompanyNameField;
    [OptionalField]
    private string EmailField;
    [OptionalField]
    private string ErrorMessageField;
    [OptionalField]
    private string FaxField;
    [OptionalField]
    private string FirstNameField;
    [OptionalField]
    private string LastNameField;
    [OptionalField]
    private string OrgnisationIDField;
    [OptionalField]
    private string PostcodeField;
    [OptionalField]
    private bool SuccessField;
    [OptionalField]
    private string TelephoneField;
    [OptionalField]
    private string TownField;
    [OptionalField]
    private string WebisteField;

    [Browsable(false)]
    public ExtensionDataObject ExtensionData
    {
      get => this.extensionDataField;
      set => this.extensionDataField = value;
    }

    [DataMember]
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

    [DataMember]
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

    [DataMember]
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

    [DataMember]
    public string AssessorNumber
    {
      get => this.AssessorNumberField;
      set
      {
        if (object.ReferenceEquals((object) this.AssessorNumberField, (object) value))
          return;
        this.AssessorNumberField = value;
        this.RaisePropertyChanged(nameof (AssessorNumber));
      }
    }

    [DataMember]
    public string CompanyName
    {
      get => this.CompanyNameField;
      set
      {
        if (object.ReferenceEquals((object) this.CompanyNameField, (object) value))
          return;
        this.CompanyNameField = value;
        this.RaisePropertyChanged(nameof (CompanyName));
      }
    }

    [DataMember]
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

    [DataMember]
    public string FirstName
    {
      get => this.FirstNameField;
      set
      {
        if (object.ReferenceEquals((object) this.FirstNameField, (object) value))
          return;
        this.FirstNameField = value;
        this.RaisePropertyChanged(nameof (FirstName));
      }
    }

    [DataMember]
    public string LastName
    {
      get => this.LastNameField;
      set
      {
        if (object.ReferenceEquals((object) this.LastNameField, (object) value))
          return;
        this.LastNameField = value;
        this.RaisePropertyChanged(nameof (LastName));
      }
    }

    [DataMember]
    public string OrgnisationID
    {
      get => this.OrgnisationIDField;
      set
      {
        if (object.ReferenceEquals((object) this.OrgnisationIDField, (object) value))
          return;
        this.OrgnisationIDField = value;
        this.RaisePropertyChanged(nameof (OrgnisationID));
      }
    }

    [DataMember]
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
    public string Telephone
    {
      get => this.TelephoneField;
      set
      {
        if (object.ReferenceEquals((object) this.TelephoneField, (object) value))
          return;
        this.TelephoneField = value;
        this.RaisePropertyChanged(nameof (Telephone));
      }
    }

    [DataMember]
    public string Town
    {
      get => this.TownField;
      set
      {
        if (object.ReferenceEquals((object) this.TownField, (object) value))
          return;
        this.TownField = value;
        this.RaisePropertyChanged(nameof (Town));
      }
    }

    [DataMember]
    public string Webiste
    {
      get => this.WebisteField;
      set
      {
        if (object.ReferenceEquals((object) this.WebisteField, (object) value))
          return;
        this.WebisteField = value;
        this.RaisePropertyChanged(nameof (Webiste));
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
