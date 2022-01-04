
// Type: SAP2012.NISAP.ShortAddress




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace SAP2012.NISAP
{
  [DebuggerStepThrough]
  [GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
  [DataContract(Name = "ShortAddress", Namespace = "https://www.stromamembers.co.uk/NISAP.asmx")]
  [Serializable]
  public class ShortAddress : IExtensibleDataObject, INotifyPropertyChanged
  {
    [NonSerialized]
    private ExtensionDataObject extensionDataField;
    [OptionalField]
    private string addressLineField;
    [OptionalField]
    private string temporaryIDField;

    [Browsable(false)]
    public ExtensionDataObject ExtensionData
    {
      get => this.extensionDataField;
      set => this.extensionDataField = value;
    }

    [DataMember(EmitDefaultValue = false)]
    public string addressLine
    {
      get => this.addressLineField;
      set
      {
        if (object.ReferenceEquals((object) this.addressLineField, (object) value))
          return;
        this.addressLineField = value;
        this.RaisePropertyChanged(nameof (addressLine));
      }
    }

    [DataMember(EmitDefaultValue = false)]
    public string temporaryID
    {
      get => this.temporaryIDField;
      set
      {
        if (object.ReferenceEquals((object) this.temporaryIDField, (object) value))
          return;
        this.temporaryIDField = value;
        this.RaisePropertyChanged(nameof (temporaryID));
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
