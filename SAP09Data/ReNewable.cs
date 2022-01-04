
// Type: SAP2012.SAP09Data.ReNewable




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace SAP2012.SAP09Data
{
  [DebuggerStepThrough]
  [GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
  [DataContract(Name = "ReNewable", Namespace = "http://rdsap2009.stroma.com/SAPData/SAP09Compliance.asmx")]
  [Serializable]
  public class ReNewable : IExtensibleDataObject, INotifyPropertyChanged
  {
    [NonSerialized]
    private ExtensionDataObject extensionDataField;
    private WindTurbine WindTurbineField;
    private Photovoltaic PhotovoltaicField;
    private Special SpecialField;
    private AAEGeneration AAEGenerationField;

    [Browsable(false)]
    public ExtensionDataObject ExtensionData
    {
      get => this.extensionDataField;
      set => this.extensionDataField = value;
    }

    [DataMember(EmitDefaultValue = false, IsRequired = true)]
    public WindTurbine WindTurbine
    {
      get => this.WindTurbineField;
      set
      {
        if (object.ReferenceEquals((object) this.WindTurbineField, (object) value))
          return;
        this.WindTurbineField = value;
        this.RaisePropertyChanged(nameof (WindTurbine));
      }
    }

    [DataMember(EmitDefaultValue = false, IsRequired = true, Order = 1)]
    public Photovoltaic Photovoltaic
    {
      get => this.PhotovoltaicField;
      set
      {
        if (object.ReferenceEquals((object) this.PhotovoltaicField, (object) value))
          return;
        this.PhotovoltaicField = value;
        this.RaisePropertyChanged(nameof (Photovoltaic));
      }
    }

    [DataMember(EmitDefaultValue = false, IsRequired = true, Order = 2)]
    public Special Special
    {
      get => this.SpecialField;
      set
      {
        if (object.ReferenceEquals((object) this.SpecialField, (object) value))
          return;
        this.SpecialField = value;
        this.RaisePropertyChanged(nameof (Special));
      }
    }

    [DataMember(EmitDefaultValue = false, IsRequired = true, Order = 3)]
    public AAEGeneration AAEGeneration
    {
      get => this.AAEGenerationField;
      set
      {
        if (object.ReferenceEquals((object) this.AAEGenerationField, (object) value))
          return;
        this.AAEGenerationField = value;
        this.RaisePropertyChanged(nameof (AAEGeneration));
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
