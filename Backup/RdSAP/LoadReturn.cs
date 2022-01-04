
// Type: SAP2012.RdSAP.LoadReturn




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace SAP2012.RdSAP
{
  [DebuggerStepThrough]
  [GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
  [DataContract(Name = "LoadReturn", Namespace = "http://schemas.datacontract.org/2004/07/StromaServices")]
  [Serializable]
  public class LoadReturn : IExtensibleDataObject, INotifyPropertyChanged
  {
    [NonSerialized]
    private ExtensionDataObject extensionDataField;
    [OptionalField]
    private string errorMessageField;
    [OptionalField]
    private string notesField;
    [OptionalField]
    private Survey_Class surveyField;

    [Browsable(false)]
    public ExtensionDataObject ExtensionData
    {
      get => this.extensionDataField;
      set => this.extensionDataField = value;
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
    public string notes
    {
      get => this.notesField;
      set
      {
        if (object.ReferenceEquals((object) this.notesField, (object) value))
          return;
        this.notesField = value;
        this.RaisePropertyChanged(nameof (notes));
      }
    }

    [DataMember]
    public Survey_Class survey
    {
      get => this.surveyField;
      set
      {
        if (object.ReferenceEquals((object) this.surveyField, (object) value))
          return;
        this.surveyField = value;
        this.RaisePropertyChanged(nameof (survey));
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
