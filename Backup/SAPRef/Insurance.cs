
// Type: SAP2012.SAPRef.Insurance




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace SAP2012.SAPRef
{
  [DebuggerStepThrough]
  [GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
  [DataContract(Name = "Insurance", Namespace = "https://www.stromamembers.co.uk/sap.asmx")]
  [Serializable]
  public class Insurance : IExtensibleDataObject, INotifyPropertyChanged
  {
    [NonSerialized]
    private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
    [OptionalField]
    private string StartDateField;
    [OptionalField]
    private string EnddateField;
    [OptionalField]
    private string PLLimitField;
    [OptionalField]
    private string PolicyNoField;
    [OptionalField]
    private string InsurerField;
    private bool IncludeField;

    [Browsable(false)]
    public System.Runtime.Serialization.ExtensionDataObject ExtensionData
    {
      get => this.extensionDataField;
      set => this.extensionDataField = value;
    }

    [DataMember(EmitDefaultValue = false)]
    public string StartDate
    {
      get => this.StartDateField;
      set
      {
        if (object.ReferenceEquals((object) this.StartDateField, (object) value))
          return;
        this.StartDateField = value;
        this.RaisePropertyChanged(nameof (StartDate));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 1)]
    public string Enddate
    {
      get => this.EnddateField;
      set
      {
        if (object.ReferenceEquals((object) this.EnddateField, (object) value))
          return;
        this.EnddateField = value;
        this.RaisePropertyChanged(nameof (Enddate));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 2)]
    public string PLLimit
    {
      get => this.PLLimitField;
      set
      {
        if (object.ReferenceEquals((object) this.PLLimitField, (object) value))
          return;
        this.PLLimitField = value;
        this.RaisePropertyChanged(nameof (PLLimit));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 3)]
    public string PolicyNo
    {
      get => this.PolicyNoField;
      set
      {
        if (object.ReferenceEquals((object) this.PolicyNoField, (object) value))
          return;
        this.PolicyNoField = value;
        this.RaisePropertyChanged(nameof (PolicyNo));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 4)]
    public string Insurer
    {
      get => this.InsurerField;
      set
      {
        if (object.ReferenceEquals((object) this.InsurerField, (object) value))
          return;
        this.InsurerField = value;
        this.RaisePropertyChanged(nameof (Insurer));
      }
    }

    [DataMember(IsRequired = true, Order = 5)]
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
