
// Type: SAP2012.SAPRef.sapImportpermissionclass




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace SAP2012.SAPRef
{
  [DebuggerStepThrough]
  [GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
  [DataContract(Name = "sapImportpermissionclass", Namespace = "https://www.stromamembers.co.uk/sap.asmx")]
  [Serializable]
  public class sapImportpermissionclass : IExtensibleDataObject, INotifyPropertyChanged
  {
    [NonSerialized]
    private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
    [OptionalField]
    private string importtypeField;
    [OptionalField]
    private string eacertificateField;
    private bool IncludeField;

    [Browsable(false)]
    public System.Runtime.Serialization.ExtensionDataObject ExtensionData
    {
      get => this.extensionDataField;
      set => this.extensionDataField = value;
    }

    [DataMember(EmitDefaultValue = false)]
    public string importtype
    {
      get => this.importtypeField;
      set
      {
        if (object.ReferenceEquals((object) this.importtypeField, (object) value))
          return;
        this.importtypeField = value;
        this.RaisePropertyChanged(nameof (importtype));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 1)]
    public string eacertificate
    {
      get => this.eacertificateField;
      set
      {
        if (object.ReferenceEquals((object) this.eacertificateField, (object) value))
          return;
        this.eacertificateField = value;
        this.RaisePropertyChanged(nameof (eacertificate));
      }
    }

    [DataMember(IsRequired = true, Order = 2)]
    public bool Include
    {
      get => this.IncludeField;
      set
      {
        if (this.IncludeField.Equals(value))
          return;
        this.IncludeField = value;
        this.RaisePropertyChanged(nameof (Include));
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
