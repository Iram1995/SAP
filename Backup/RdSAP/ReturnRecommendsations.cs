
// Type: SAP2012.RdSAP.ReturnRecommendsations




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace SAP2012.RdSAP
{
  [DebuggerStepThrough]
  [GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
  [DataContract(Name = "ReturnRecommendsations", Namespace = "http://schemas.datacontract.org/2004/07/StromaServices")]
  [Serializable]
  public class ReturnRecommendsations : IExtensibleDataObject, INotifyPropertyChanged
  {
    [NonSerialized]
    private ExtensionDataObject extensionDataField;
    [OptionalField]
    private string[] CancellationsField;
    [OptionalField]
    private string ErrorStringField;
    [OptionalField]
    private bool HasRowField;
    [OptionalField]
    private int RdSAPIDField;

    [Browsable(false)]
    public ExtensionDataObject ExtensionData
    {
      get => this.extensionDataField;
      set => this.extensionDataField = value;
    }

    [DataMember]
    public string[] Cancellations
    {
      get => this.CancellationsField;
      set
      {
        if (object.ReferenceEquals((object) this.CancellationsField, (object) value))
          return;
        this.CancellationsField = value;
        this.RaisePropertyChanged(nameof (Cancellations));
      }
    }

    [DataMember]
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

    [DataMember]
    public bool HasRow
    {
      get => this.HasRowField;
      set
      {
        if (this.HasRowField.Equals(value))
          return;
        this.HasRowField = value;
        this.RaisePropertyChanged(nameof (HasRow));
      }
    }

    [DataMember]
    public int RdSAPID
    {
      get => this.RdSAPIDField;
      set
      {
        if (this.RdSAPIDField.Equals(value))
          return;
        this.RdSAPIDField = value;
        this.RaisePropertyChanged(nameof (RdSAPID));
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
