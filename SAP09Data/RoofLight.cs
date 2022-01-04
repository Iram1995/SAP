
// Type: SAP2012.SAP09Data.RoofLight




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace SAP2012.SAP09Data
{
  [DebuggerStepThrough]
  [GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
  [DataContract(Name = "RoofLight", Namespace = "http://rdsap2009.stroma.com/SAPData/SAP09Compliance.asmx")]
  [Serializable]
  public class RoofLight : IExtensibleDataObject, INotifyPropertyChanged
  {
    [NonSerialized]
    private ExtensionDataObject extensionDataField;
    [OptionalField]
    private string NameField;
    [OptionalField]
    private string LocationField;
    [OptionalField]
    private string UValueSourceField;
    private float PitchField;
    [OptionalField]
    private string OrientationField;
    [OptionalField]
    private string OvershadingField;
    [OptionalField]
    private string GlazingTypeField;
    [OptionalField]
    private string AirGapField;
    [OptionalField]
    private string FrameTypeField;
    [OptionalField]
    private string ThermalBreakField;
    private float AreaField;
    private float WidthField;
    private float HeightField;
    private int CountField;
    private float OverhangWidthField;
    private float OverhangDepthField;
    [OptionalField]
    private string CurtainTypeField;
    private float FractionClosedField;
    private float gField;
    private float FFField;
    private float UField;
    [OptionalField]
    private string OpeningTypeField;

    [Browsable(false)]
    public ExtensionDataObject ExtensionData
    {
      get => this.extensionDataField;
      set => this.extensionDataField = value;
    }

    [DataMember(EmitDefaultValue = false)]
    public string Name
    {
      get => this.NameField;
      set
      {
        if (object.ReferenceEquals((object) this.NameField, (object) value))
          return;
        this.NameField = value;
        this.RaisePropertyChanged(nameof (Name));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 1)]
    public string Location
    {
      get => this.LocationField;
      set
      {
        if (object.ReferenceEquals((object) this.LocationField, (object) value))
          return;
        this.LocationField = value;
        this.RaisePropertyChanged(nameof (Location));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 2)]
    public string UValueSource
    {
      get => this.UValueSourceField;
      set
      {
        if (object.ReferenceEquals((object) this.UValueSourceField, (object) value))
          return;
        this.UValueSourceField = value;
        this.RaisePropertyChanged(nameof (UValueSource));
      }
    }

    [DataMember(IsRequired = true, Order = 3)]
    public float Pitch
    {
      get => this.PitchField;
      set
      {
        if (this.PitchField.Equals(value))
          return;
        this.PitchField = value;
        this.RaisePropertyChanged(nameof (Pitch));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 4)]
    public string Orientation
    {
      get => this.OrientationField;
      set
      {
        if (object.ReferenceEquals((object) this.OrientationField, (object) value))
          return;
        this.OrientationField = value;
        this.RaisePropertyChanged(nameof (Orientation));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 5)]
    public string Overshading
    {
      get => this.OvershadingField;
      set
      {
        if (object.ReferenceEquals((object) this.OvershadingField, (object) value))
          return;
        this.OvershadingField = value;
        this.RaisePropertyChanged(nameof (Overshading));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 6)]
    public string GlazingType
    {
      get => this.GlazingTypeField;
      set
      {
        if (object.ReferenceEquals((object) this.GlazingTypeField, (object) value))
          return;
        this.GlazingTypeField = value;
        this.RaisePropertyChanged(nameof (GlazingType));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 7)]
    public string AirGap
    {
      get => this.AirGapField;
      set
      {
        if (object.ReferenceEquals((object) this.AirGapField, (object) value))
          return;
        this.AirGapField = value;
        this.RaisePropertyChanged(nameof (AirGap));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 8)]
    public string FrameType
    {
      get => this.FrameTypeField;
      set
      {
        if (object.ReferenceEquals((object) this.FrameTypeField, (object) value))
          return;
        this.FrameTypeField = value;
        this.RaisePropertyChanged(nameof (FrameType));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 9)]
    public string ThermalBreak
    {
      get => this.ThermalBreakField;
      set
      {
        if (object.ReferenceEquals((object) this.ThermalBreakField, (object) value))
          return;
        this.ThermalBreakField = value;
        this.RaisePropertyChanged(nameof (ThermalBreak));
      }
    }

    [DataMember(IsRequired = true, Order = 10)]
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

    [DataMember(IsRequired = true, Order = 11)]
    public float Width
    {
      get => this.WidthField;
      set
      {
        if (this.WidthField.Equals(value))
          return;
        this.WidthField = value;
        this.RaisePropertyChanged(nameof (Width));
      }
    }

    [DataMember(IsRequired = true, Order = 12)]
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

    [DataMember(IsRequired = true, Order = 13)]
    public int Count
    {
      get => this.CountField;
      set
      {
        if (this.CountField.Equals(value))
          return;
        this.CountField = value;
        this.RaisePropertyChanged(nameof (Count));
      }
    }

    [DataMember(IsRequired = true, Order = 14)]
    public float OverhangWidth
    {
      get => this.OverhangWidthField;
      set
      {
        if (this.OverhangWidthField.Equals(value))
          return;
        this.OverhangWidthField = value;
        this.RaisePropertyChanged(nameof (OverhangWidth));
      }
    }

    [DataMember(IsRequired = true, Order = 15)]
    public float OverhangDepth
    {
      get => this.OverhangDepthField;
      set
      {
        if (this.OverhangDepthField.Equals(value))
          return;
        this.OverhangDepthField = value;
        this.RaisePropertyChanged(nameof (OverhangDepth));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 16)]
    public string CurtainType
    {
      get => this.CurtainTypeField;
      set
      {
        if (object.ReferenceEquals((object) this.CurtainTypeField, (object) value))
          return;
        this.CurtainTypeField = value;
        this.RaisePropertyChanged(nameof (CurtainType));
      }
    }

    [DataMember(IsRequired = true, Order = 17)]
    public float FractionClosed
    {
      get => this.FractionClosedField;
      set
      {
        if (this.FractionClosedField.Equals(value))
          return;
        this.FractionClosedField = value;
        this.RaisePropertyChanged(nameof (FractionClosed));
      }
    }

    [DataMember(IsRequired = true, Order = 18)]
    public float g
    {
      get => this.gField;
      set
      {
        if (this.gField.Equals(value))
          return;
        this.gField = value;
        this.RaisePropertyChanged(nameof (g));
      }
    }

    [DataMember(IsRequired = true, Order = 19)]
    public float FF
    {
      get => this.FFField;
      set
      {
        if (this.FFField.Equals(value))
          return;
        this.FFField = value;
        this.RaisePropertyChanged(nameof (FF));
      }
    }

    [DataMember(IsRequired = true, Order = 20)]
    public float U
    {
      get => this.UField;
      set
      {
        if (this.UField.Equals(value))
          return;
        this.UField = value;
        this.RaisePropertyChanged(nameof (U));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 21)]
    public string OpeningType
    {
      get => this.OpeningTypeField;
      set
      {
        if (object.ReferenceEquals((object) this.OpeningTypeField, (object) value))
          return;
        this.OpeningTypeField = value;
        this.RaisePropertyChanged(nameof (OpeningType));
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
