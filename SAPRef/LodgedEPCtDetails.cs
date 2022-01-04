
// Type: SAP2012.SAPRef.LodgedEPCtDetails




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace SAP2012.SAPRef
{
  [DebuggerStepThrough]
  [GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
  [DataContract(Name = "LodgedEPCtDetails", Namespace = "https://www.stromamembers.co.uk/sap.asmx")]
  [Serializable]
  public class LodgedEPCtDetails : IExtensibleDataObject, INotifyPropertyChanged
  {
    [NonSerialized]
    private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
    [OptionalField]
    private string FilenameField;
    [OptionalField]
    private string EPCField;
    private bool DownloadedField;
    [OptionalField]
    private byte[] EPCDataField;

    [Browsable(false)]
    public System.Runtime.Serialization.ExtensionDataObject ExtensionData
    {
      get => this.extensionDataField;
      set => this.extensionDataField = value;
    }

    [DataMember(EmitDefaultValue = false)]
    public string Filename
    {
      get => this.FilenameField;
      set
      {
        if (object.ReferenceEquals((object) this.FilenameField, (object) value))
          return;
        this.FilenameField = value;
        this.RaisePropertyChanged(nameof (Filename));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 1)]
    public string EPC
    {
      get => this.EPCField;
      set
      {
        if (object.ReferenceEquals((object) this.EPCField, (object) value))
          return;
        this.EPCField = value;
        this.RaisePropertyChanged(nameof (EPC));
      }
    }

    [DataMember(IsRequired = true, Order = 2)]
    public bool Downloaded
    {
      get => this.DownloadedField;
      set
      {
        if (this.DownloadedField.Equals(value))
          return;
        this.DownloadedField = value;
        this.RaisePropertyChanged(nameof (Downloaded));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 3)]
    public byte[] EPCData
    {
      get => this.EPCDataField;
      set
      {
        if (object.ReferenceEquals((object) this.EPCDataField, (object) value))
          return;
        this.EPCDataField = value;
        this.RaisePropertyChanged(nameof (EPCData));
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
