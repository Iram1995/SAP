
// Type: SAP2012.ScotlandService.ReturnObject




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace SAP2012.ScotlandService
{
  [DebuggerStepThrough]
  [GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
  [DataContract(Name = "ReturnObject", Namespace = "https://www.stromamembers.co.uk/Stroma_DomesticScotland.asmx")]
  [Serializable]
  public class ReturnObject : IExtensibleDataObject, INotifyPropertyChanged
  {
    [NonSerialized]
    private ExtensionDataObject extensionDataField;
    [OptionalField]
    private string ErrorStringField;
    [OptionalField]
    private string XdocField;

    [Browsable(false)]
    public ExtensionDataObject ExtensionData
    {
      get => this.extensionDataField;
      set => this.extensionDataField = value;
    }

    [DataMember(EmitDefaultValue = false)]
    public string ErrorString
    {
      get => this.ErrorStringField;
      set
      {
        if (object.ReferenceEquals((object) this.ErrorStringField, (object) value))
          return;
        this.ErrorStringField = value;
        this.RaisePropertyChanged(nameof (ErrorString));
      }
    }

    [DataMember(EmitDefaultValue = false)]
    public string Xdoc
    {
      get => this.XdocField;
      set
      {
        if (object.ReferenceEquals((object) this.XdocField, (object) value))
          return;
        this.XdocField = value;
        this.RaisePropertyChanged(nameof (Xdoc));
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
