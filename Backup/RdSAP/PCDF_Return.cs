
// Type: SAP2012.RdSAP.PCDF_Return




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace SAP2012.RdSAP
{
  [DebuggerStepThrough]
  [GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
  [DataContract(Name = "PCDF_Return", Namespace = "http://schemas.datacontract.org/2004/07/StromaServices")]
  [Serializable]
  public class PCDF_Return : IExtensibleDataObject, INotifyPropertyChanged
  {
    [NonSerialized]
    private ExtensionDataObject extensionDataField;
    [OptionalField]
    private string FileDataField;
    [OptionalField]
    private bool NewFileField;
    [OptionalField]
    private string VersionNoField;

    [Browsable(false)]
    public ExtensionDataObject ExtensionData
    {
      get => this.extensionDataField;
      set => this.extensionDataField = value;
    }

    [DataMember]
    public string FileData
    {
      get => this.FileDataField;
      set
      {
        if (object.ReferenceEquals((object) this.FileDataField, (object) value))
          return;
        this.FileDataField = value;
        this.RaisePropertyChanged(nameof (FileData));
      }
    }

    [DataMember]
    public bool NewFile
    {
      get => this.NewFileField;
      set
      {
        if (this.NewFileField.Equals(value))
          return;
        this.NewFileField = value;
        this.RaisePropertyChanged(nameof (NewFile));
      }
    }

    [DataMember]
    public string VersionNo
    {
      get => this.VersionNoField;
      set
      {
        if (object.ReferenceEquals((object) this.VersionNoField, (object) value))
          return;
        this.VersionNoField = value;
        this.RaisePropertyChanged(nameof (VersionNo));
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
