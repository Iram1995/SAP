
// Type: SAP2012.SAPRef.AddressRequest




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace SAP2012.SAPRef
{
  [DebuggerStepThrough]
  [GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
  [DataContract(Name = "AddressRequest", Namespace = "https://www.stromamembers.co.uk/sap.asmx")]
  [Serializable]
  public class AddressRequest : IExtensibleDataObject, INotifyPropertyChanged
  {
    [NonSerialized]
    private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
    [OptionalField]
    private SelectionClass SelectionField;
    [OptionalField]
    private SecurityClass SecurityField;

    [Browsable(false)]
    public System.Runtime.Serialization.ExtensionDataObject ExtensionData
    {
      get => this.extensionDataField;
      set => this.extensionDataField = value;
    }

    [DataMember(EmitDefaultValue = false)]
    public SelectionClass Selection
    {
      get => this.SelectionField;
      set
      {
        if (object.ReferenceEquals((object) this.SelectionField, (object) value))
          return;
        this.SelectionField = value;
        this.RaisePropertyChanged(nameof (Selection));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 1)]
    public SecurityClass Security
    {
      get => this.SecurityField;
      set
      {
        if (object.ReferenceEquals((object) this.SecurityField, (object) value))
          return;
        this.SecurityField = value;
        this.RaisePropertyChanged(nameof (Security));
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
