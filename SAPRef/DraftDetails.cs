
// Type: SAP2012.SAPRef.DraftDetails




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace SAP2012.SAPRef
{
  [DebuggerStepThrough]
  [GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
  [DataContract(Name = "DraftDetails", Namespace = "https://www.stromamembers.co.uk/sap.asmx")]
  [Serializable]
  public class DraftDetails : IExtensibleDataObject, INotifyPropertyChanged
  {
    [NonSerialized]
    private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
    [OptionalField]
    private string FilenameField;
    [OptionalField]
    private string DraftEPCField;
    private bool DraftCratedField;

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
    public string DraftEPC
    {
      get => this.DraftEPCField;
      set
      {
        if (object.ReferenceEquals((object) this.DraftEPCField, (object) value))
          return;
        this.DraftEPCField = value;
        this.RaisePropertyChanged(nameof (DraftEPC));
      }
    }

    [DataMember(IsRequired = true, Order = 2)]
    public bool DraftCrated
    {
      get => this.DraftCratedField;
      set
      {
        if (this.DraftCratedField.Equals(value))
          return;
        this.DraftCratedField = value;
        this.RaisePropertyChanged(nameof (DraftCrated));
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
