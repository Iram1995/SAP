
// Type: SAP2012.RdSAP.UploadResult




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace SAP2012.RdSAP
{
  [DebuggerStepThrough]
  [GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
  [DataContract(Name = "UploadResult", Namespace = "http://schemas.datacontract.org/2004/07/StromaServices")]
  [Serializable]
  public class UploadResult : IExtensibleDataObject, INotifyPropertyChanged
  {
    [NonSerialized]
    private ExtensionDataObject extensionDataField;
    [OptionalField]
    private string ErrorMessageField;
    [OptionalField]
    private int NewSurveyField;
    [OptionalField]
    private bool SuccessField;

    [Browsable(false)]
    public ExtensionDataObject ExtensionData
    {
      get => this.extensionDataField;
      set => this.extensionDataField = value;
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
    public int NewSurvey
    {
      get => this.NewSurveyField;
      set
      {
        if (this.NewSurveyField.Equals(value))
          return;
        this.NewSurveyField = value;
        this.RaisePropertyChanged(nameof (NewSurvey));
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
