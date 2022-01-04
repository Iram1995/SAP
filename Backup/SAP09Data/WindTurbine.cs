
// Type: SAP2012.SAP09Data.WindTurbine




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace SAP2012.SAP09Data
{
  [DebuggerStepThrough]
  [GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
  [DataContract(Name = "WindTurbine", Namespace = "http://rdsap2009.stroma.com/SAPData/SAP09Compliance.asmx")]
  [Serializable]
  public class WindTurbine : IExtensibleDataObject, INotifyPropertyChanged
  {
    [NonSerialized]
    private ExtensionDataObject extensionDataField;
    private bool InlcudeField;
    private int WNumberField;
    [OptionalField]
    private string WRDiameterField;
    [OptionalField]
    private string WHeightField;

    [Browsable(false)]
    public ExtensionDataObject ExtensionData
    {
      get => this.extensionDataField;
      set => this.extensionDataField = value;
    }

    [DataMember(IsRequired = true)]
    public bool Inlcude
    {
      get => this.InlcudeField;
      set
      {
        if (this.InlcudeField.Equals(value))
          return;
        this.InlcudeField = value;
        this.RaisePropertyChanged(nameof (Inlcude));
      }
    }

    [DataMember(IsRequired = true)]
    public int WNumber
    {
      get => this.WNumberField;
      set
      {
        if (this.WNumberField.Equals(value))
          return;
        this.WNumberField = value;
        this.RaisePropertyChanged(nameof (WNumber));
      }
    }

    [DataMember(EmitDefaultValue = false)]
    public string WRDiameter
    {
      get => this.WRDiameterField;
      set
      {
        if (object.ReferenceEquals((object) this.WRDiameterField, (object) value))
          return;
        this.WRDiameterField = value;
        this.RaisePropertyChanged(nameof (WRDiameter));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 3)]
    public string WHeight
    {
      get => this.WHeightField;
      set
      {
        if (object.ReferenceEquals((object) this.WHeightField, (object) value))
          return;
        this.WHeightField = value;
        this.RaisePropertyChanged(nameof (WHeight));
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
