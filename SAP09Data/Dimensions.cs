
// Type: SAP2012.SAP09Data.Dimensions




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace SAP2012.SAP09Data
{
  [DebuggerStepThrough]
  [GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
  [DataContract(Name = "Dimensions", Namespace = "http://rdsap2009.stroma.com/SAPData/SAP09Compliance.asmx")]
  [Serializable]
  public class Dimensions : IExtensibleDataObject, INotifyPropertyChanged
  {
    [NonSerialized]
    private ExtensionDataObject extensionDataField;
    [OptionalField]
    private string BasementField;
    private float AreaField;
    private float HeightField;

    [Browsable(false)]
    public ExtensionDataObject ExtensionData
    {
      get => this.extensionDataField;
      set => this.extensionDataField = value;
    }

    [DataMember(EmitDefaultValue = false)]
    public string Basement
    {
      get => this.BasementField;
      set
      {
        if (object.ReferenceEquals((object) this.BasementField, (object) value))
          return;
        this.BasementField = value;
        this.RaisePropertyChanged(nameof (Basement));
      }
    }

    [DataMember(IsRequired = true, Order = 1)]
    public float Area
    {
      get => this.AreaField;
      set
      {
        if (this.AreaField.Equals(value))
          return;
        this.AreaField = value;
        this.RaisePropertyChanged(nameof (Area));
      }
    }

    [DataMember(IsRequired = true, Order = 2)]
    public float Height
    {
      get => this.HeightField;
      set
      {
        if (this.HeightField.Equals(value))
          return;
        this.HeightField = value;
        this.RaisePropertyChanged(nameof (Height));
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
