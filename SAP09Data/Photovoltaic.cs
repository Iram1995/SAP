
// Type: SAP2012.SAP09Data.Photovoltaic




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace SAP2012.SAP09Data
{
  [DebuggerStepThrough]
  [GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
  [DataContract(Name = "Photovoltaic", Namespace = "http://rdsap2009.stroma.com/SAPData/SAP09Compliance.asmx")]
  [Serializable]
  public class Photovoltaic : IExtensibleDataObject, INotifyPropertyChanged
  {
    [NonSerialized]
    private ExtensionDataObject extensionDataField;
    private bool InlcudeField;
    [OptionalField]
    private PhotoVoltaics[] PhotovoltaicsField;
    private float PPowerField;
    [OptionalField]
    private string PTiltField;
    [OptionalField]
    private string PCOrientationField;
    [OptionalField]
    private string POvershadingField;

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

    [DataMember(EmitDefaultValue = false)]
    public PhotoVoltaics[] Photovoltaics
    {
      get => this.PhotovoltaicsField;
      set
      {
        if (object.ReferenceEquals((object) this.PhotovoltaicsField, (object) value))
          return;
        this.PhotovoltaicsField = value;
        this.RaisePropertyChanged(nameof (Photovoltaics));
      }
    }

    [DataMember(IsRequired = true, Order = 2)]
    public float PPower
    {
      get => this.PPowerField;
      set
      {
        if (this.PPowerField.Equals(value))
          return;
        this.PPowerField = value;
        this.RaisePropertyChanged(nameof (PPower));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 3)]
    public string PTilt
    {
      get => this.PTiltField;
      set
      {
        if (object.ReferenceEquals((object) this.PTiltField, (object) value))
          return;
        this.PTiltField = value;
        this.RaisePropertyChanged(nameof (PTilt));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 4)]
    public string PCOrientation
    {
      get => this.PCOrientationField;
      set
      {
        if (object.ReferenceEquals((object) this.PCOrientationField, (object) value))
          return;
        this.PCOrientationField = value;
        this.RaisePropertyChanged(nameof (PCOrientation));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 5)]
    public string POvershading
    {
      get => this.POvershadingField;
      set
      {
        if (object.ReferenceEquals((object) this.POvershadingField, (object) value))
          return;
        this.POvershadingField = value;
        this.RaisePropertyChanged(nameof (POvershading));
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
