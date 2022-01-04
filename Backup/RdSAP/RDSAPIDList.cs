
// Type: SAP2012.RdSAP.RDSAPIDList




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace SAP2012.RdSAP
{
  [DebuggerStepThrough]
  [GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
  [DataContract(Name = "RDSAPIDList", Namespace = "http://schemas.datacontract.org/2004/07/StromaServices")]
  [Serializable]
  public class RDSAPIDList : IExtensibleDataObject, INotifyPropertyChanged
  {
    [NonSerialized]
    private ExtensionDataObject extensionDataField;
    [OptionalField]
    private string errorMessageField;
    [OptionalField]
    private int[] rdsapidListField;
    [OptionalField]
    private bool successField;

    [Browsable(false)]
    public ExtensionDataObject ExtensionData
    {
      get => this.extensionDataField;
      set => this.extensionDataField = value;
    }

    [DataMember]
    public string errorMessage
    {
      get => this.errorMessageField;
      set
      {
        if (object.ReferenceEquals((object) this.errorMessageField, (object) value))
          return;
        this.errorMessageField = value;
        this.RaisePropertyChanged(nameof (errorMessage));
      }
    }

    [DataMember]
    public int[] rdsapidList
    {
      get => this.rdsapidListField;
      set
      {
        if (object.ReferenceEquals((object) this.rdsapidListField, (object) value))
          return;
        this.rdsapidListField = value;
        this.RaisePropertyChanged(nameof (rdsapidList));
      }
    }

    [DataMember]
    public bool success
    {
      get => this.successField;
      set
      {
        if (this.successField.Equals(value))
          return;
        this.successField = value;
        this.RaisePropertyChanged(nameof (success));
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
