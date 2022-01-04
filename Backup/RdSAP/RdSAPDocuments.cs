
// Type: SAP2012.RdSAP.RdSAPDocuments




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace SAP2012.RdSAP
{
  [DebuggerStepThrough]
  [GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
  [DataContract(Name = "RdSAPDocuments", Namespace = "http://schemas.datacontract.org/2004/07/StromaServices")]
  [Serializable]
  public class RdSAPDocuments : IExtensibleDataObject, INotifyPropertyChanged
  {
    [NonSerialized]
    private ExtensionDataObject extensionDataField;
    [OptionalField]
    private string DocCatField;
    [OptionalField]
    private string DocNameField;
    [OptionalField]
    private string DocUrlField;

    [Browsable(false)]
    public ExtensionDataObject ExtensionData
    {
      get => this.extensionDataField;
      set => this.extensionDataField = value;
    }

    [DataMember]
    public string DocCat
    {
      get => this.DocCatField;
      set
      {
        if (object.ReferenceEquals((object) this.DocCatField, (object) value))
          return;
        this.DocCatField = value;
        this.RaisePropertyChanged(nameof (DocCat));
      }
    }

    [DataMember]
    public string DocName
    {
      get => this.DocNameField;
      set
      {
        if (object.ReferenceEquals((object) this.DocNameField, (object) value))
          return;
        this.DocNameField = value;
        this.RaisePropertyChanged(nameof (DocName));
      }
    }

    [DataMember]
    public string DocUrl
    {
      get => this.DocUrlField;
      set
      {
        if (object.ReferenceEquals((object) this.DocUrlField, (object) value))
          return;
        this.DocUrlField = value;
        this.RaisePropertyChanged(nameof (DocUrl));
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
