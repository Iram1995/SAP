
// Type: SAP2012.SAPRef.AddressResult




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace SAP2012.SAPRef
{
  [DebuggerStepThrough]
  [GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
  [DataContract(Name = "AddressResult", Namespace = "https://www.stromamembers.co.uk/sap.asmx")]
  [Serializable]
  public class AddressResult : IExtensibleDataObject, INotifyPropertyChanged
  {
    [NonSerialized]
    private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
    [OptionalField]
    private ExtensionDataObject ExtensionData1Field;
    [OptionalField]
    private AddressDetails[] AddressField;
    [OptionalField]
    private string MsgField;
    private bool SuccessField;

    [Browsable(false)]
    public System.Runtime.Serialization.ExtensionDataObject ExtensionData
    {
      get => this.extensionDataField;
      set => this.extensionDataField = value;
    }

    [DataMember(EmitDefaultValue = false, Name = "ExtensionData")]
    public ExtensionDataObject ExtensionData1
    {
      get => this.ExtensionData1Field;
      set
      {
        if (object.ReferenceEquals((object) this.ExtensionData1Field, (object) value))
          return;
        this.ExtensionData1Field = value;
        this.RaisePropertyChanged(nameof (ExtensionData1));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 1)]
    public AddressDetails[] Address
    {
      get => this.AddressField;
      set
      {
        if (object.ReferenceEquals((object) this.AddressField, (object) value))
          return;
        this.AddressField = value;
        this.RaisePropertyChanged(nameof (Address));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 2)]
    public string Msg
    {
      get => this.MsgField;
      set
      {
        if (object.ReferenceEquals((object) this.MsgField, (object) value))
          return;
        this.MsgField = value;
        this.RaisePropertyChanged(nameof (Msg));
      }
    }

    [DataMember(IsRequired = true, Order = 3)]
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
