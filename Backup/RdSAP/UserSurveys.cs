
// Type: SAP2012.RdSAP.UserSurveys




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace SAP2012.RdSAP
{
  [DebuggerStepThrough]
  [GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
  [DataContract(Name = "UserSurveys", Namespace = "http://schemas.datacontract.org/2004/07/StromaServices")]
  [Serializable]
  public class UserSurveys : IExtensibleDataObject, INotifyPropertyChanged
  {
    [NonSerialized]
    private ExtensionDataObject extensionDataField;
    [OptionalField]
    private string InspectionDateField;
    [OptionalField]
    private string RRNField;
    [OptionalField]
    private int RdSAPField;
    [OptionalField]
    private int SuccessField;
    [OptionalField]
    private string addressline1Field;
    [OptionalField]
    private string addressline2Field;
    [OptionalField]
    private string addressline3Field;
    [OptionalField]
    private string cityField;
    [OptionalField]
    private string countryField;
    [OptionalField]
    private string customerreference1Field;
    [OptionalField]
    private string customerreference2Field;
    [OptionalField]
    private string postcodeField;
    [OptionalField]
    private string uprnField;

    [Browsable(false)]
    public ExtensionDataObject ExtensionData
    {
      get => this.extensionDataField;
      set => this.extensionDataField = value;
    }

    [DataMember]
    public string InspectionDate
    {
      get => this.InspectionDateField;
      set
      {
        if (object.ReferenceEquals((object) this.InspectionDateField, (object) value))
          return;
        this.InspectionDateField = value;
        this.RaisePropertyChanged(nameof (InspectionDate));
      }
    }

    [DataMember]
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

    [DataMember]
    public int RdSAP
    {
      get => this.RdSAPField;
      set
      {
        if (this.RdSAPField.Equals(value))
          return;
        this.RdSAPField = value;
        this.RaisePropertyChanged(nameof (RdSAP));
      }
    }

    [DataMember]
    public int Success
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
    public string addressline1
    {
      get => this.addressline1Field;
      set
      {
        if (object.ReferenceEquals((object) this.addressline1Field, (object) value))
          return;
        this.addressline1Field = value;
        this.RaisePropertyChanged(nameof (addressline1));
      }
    }

    [DataMember]
    public string addressline2
    {
      get => this.addressline2Field;
      set
      {
        if (object.ReferenceEquals((object) this.addressline2Field, (object) value))
          return;
        this.addressline2Field = value;
        this.RaisePropertyChanged(nameof (addressline2));
      }
    }

    [DataMember]
    public string addressline3
    {
      get => this.addressline3Field;
      set
      {
        if (object.ReferenceEquals((object) this.addressline3Field, (object) value))
          return;
        this.addressline3Field = value;
        this.RaisePropertyChanged(nameof (addressline3));
      }
    }

    [DataMember]
    public string city
    {
      get => this.cityField;
      set
      {
        if (object.ReferenceEquals((object) this.cityField, (object) value))
          return;
        this.cityField = value;
        this.RaisePropertyChanged(nameof (city));
      }
    }

    [DataMember]
    public string country
    {
      get => this.countryField;
      set
      {
        if (object.ReferenceEquals((object) this.countryField, (object) value))
          return;
        this.countryField = value;
        this.RaisePropertyChanged(nameof (country));
      }
    }

    [DataMember]
    public string customerreference1
    {
      get => this.customerreference1Field;
      set
      {
        if (object.ReferenceEquals((object) this.customerreference1Field, (object) value))
          return;
        this.customerreference1Field = value;
        this.RaisePropertyChanged(nameof (customerreference1));
      }
    }

    [DataMember]
    public string customerreference2
    {
      get => this.customerreference2Field;
      set
      {
        if (object.ReferenceEquals((object) this.customerreference2Field, (object) value))
          return;
        this.customerreference2Field = value;
        this.RaisePropertyChanged(nameof (customerreference2));
      }
    }

    [DataMember]
    public string postcode
    {
      get => this.postcodeField;
      set
      {
        if (object.ReferenceEquals((object) this.postcodeField, (object) value))
          return;
        this.postcodeField = value;
        this.RaisePropertyChanged(nameof (postcode));
      }
    }

    [DataMember]
    public string uprn
    {
      get => this.uprnField;
      set
      {
        if (object.ReferenceEquals((object) this.uprnField, (object) value))
          return;
        this.uprnField = value;
        this.RaisePropertyChanged(nameof (uprn));
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
