
// Type: SAP2012.RdSAP.AssessorInsurance




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace SAP2012.RdSAP
{
  [DebuggerStepThrough]
  [GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
  [DataContract(Name = "AssessorInsurance", Namespace = "http://schemas.datacontract.org/2004/07/StromaServices")]
  [Serializable]
  public class AssessorInsurance : IExtensibleDataObject, INotifyPropertyChanged
  {
    [NonSerialized]
    private ExtensionDataObject extensionDataField;
    [OptionalField]
    private string EffectiveDateField;
    [OptionalField]
    private string ErrorMessageField;
    [OptionalField]
    private string ExpiryDateField;
    [OptionalField]
    private string InsurerField;
    [OptionalField]
    private string PILimitField;
    [OptionalField]
    private string PolicyNumberField;
    [OptionalField]
    private bool SuccessField;

    [Browsable(false)]
    public ExtensionDataObject ExtensionData
    {
      get => this.extensionDataField;
      set => this.extensionDataField = value;
    }

    [DataMember]
    public string EffectiveDate
    {
      get => this.EffectiveDateField;
      set
      {
        if (object.ReferenceEquals((object) this.EffectiveDateField, (object) value))
          return;
        this.EffectiveDateField = value;
        this.RaisePropertyChanged(nameof (EffectiveDate));
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
    public string ExpiryDate
    {
      get => this.ExpiryDateField;
      set
      {
        if (object.ReferenceEquals((object) this.ExpiryDateField, (object) value))
          return;
        this.ExpiryDateField = value;
        this.RaisePropertyChanged(nameof (ExpiryDate));
      }
    }

    [DataMember]
    public string Insurer
    {
      get => this.InsurerField;
      set
      {
        if (object.ReferenceEquals((object) this.InsurerField, (object) value))
          return;
        this.InsurerField = value;
        this.RaisePropertyChanged(nameof (Insurer));
      }
    }

    [DataMember]
    public string PILimit
    {
      get => this.PILimitField;
      set
      {
        if (object.ReferenceEquals((object) this.PILimitField, (object) value))
          return;
        this.PILimitField = value;
        this.RaisePropertyChanged(nameof (PILimit));
      }
    }

    [DataMember]
    public string PolicyNumber
    {
      get => this.PolicyNumberField;
      set
      {
        if (object.ReferenceEquals((object) this.PolicyNumberField, (object) value))
          return;
        this.PolicyNumberField = value;
        this.RaisePropertyChanged(nameof (PolicyNumber));
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
