
// Type: SAP2012.RdSAP.Extension_Class




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace SAP2012.RdSAP
{
  [DebuggerStepThrough]
  [GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
  [DataContract(Name = "Extension_Class", Namespace = "http://schemas.datacontract.org/2004/07/StromaServices")]
  [Serializable]
  public class Extension_Class : IExtensibleDataObject, INotifyPropertyChanged
  {
    [NonSerialized]
    private ExtensionDataObject extensionDataField;
    [OptionalField]
    private bool AltPresentField;
    [OptionalField]
    private int AltShelteredWallField;
    [OptionalField]
    private double AltWallAreaField;
    [OptionalField]
    private int AltWallConstructionField;
    [OptionalField]
    private int AltWallDryLinedField;
    [OptionalField]
    private int AltWallInsulationThicknessField;
    [OptionalField]
    private int AltWallInsulationTypeField;
    [OptionalField]
    private double AltWallThicknessField;
    [OptionalField]
    private bool AltWallThicknessMeasuredField;
    [OptionalField]
    private double AltWallUValueField;
    [OptionalField]
    private bool AltWallUValueKnownField;
    [OptionalField]
    private bool DryLiningField;
    [OptionalField]
    private int FlatRoofInsulationThicknessField;
    [OptionalField]
    private int FloorConstructionField;
    [OptionalField]
    private int FloorInsulationField;
    [OptionalField]
    private int FloorInsulationThicknessField;
    [OptionalField]
    private double FloorUValueField;
    [OptionalField]
    private bool FloorUValueKnownField;
    [OptionalField]
    private string IdentifierField;
    [OptionalField]
    private int LowestFloorField;
    [OptionalField]
    private int PartyWallConstructionField;
    [OptionalField]
    private int PropAgeField;
    [OptionalField]
    private int RafterInsulationThicknessField;
    [OptionalField]
    private int RoofAgeField;
    [OptionalField]
    private int RoofConstructionField;
    [OptionalField]
    private int RoofInsulationField;
    [OptionalField]
    private int RoofInsulationThicknessField;
    [OptionalField]
    private bool RoofRoomField;
    [OptionalField]
    private double RoofRoomFloor_AreaField;
    [OptionalField]
    private bool RoofRoom_EditField;
    [OptionalField]
    private Extension_Class.Roof_Area[] RoofRoom_FlatCeilingField;
    [OptionalField]
    private Extension_Class.Roof_Area[] RoofRoom_GableWallField;
    [OptionalField]
    private int RoofRoom_InsulationField;
    [OptionalField]
    private Extension_Class.Roof_Area[] RoofRoom_SlopeField;
    [OptionalField]
    private Extension_Class.Roof_Area[] RoofRoom_StudWallField;
    [OptionalField]
    private int RoofRoom_TicknessField;
    [OptionalField]
    private double RoofUValueField;
    [OptionalField]
    private bool RoofUValueKnownField;
    [OptionalField]
    private bool RoomRoofConnectedField;
    [OptionalField]
    private int RoomRoofInsulationAtSlopeField;
    [OptionalField]
    private Extension_Class.Storey_Details[] StoreyField;
    [OptionalField]
    private int StoreysField;
    [OptionalField]
    private int WallConstructionField;
    [OptionalField]
    private int WallInsulationField;
    [OptionalField]
    private int WallInsulationThicknessField;
    [OptionalField]
    private double WallThicknessField;
    [OptionalField]
    private bool WallThicknessMeasuredField;
    [OptionalField]
    private double WallUValueField;
    [OptionalField]
    private bool WallUValueKnownField;

    [Browsable(false)]
    public ExtensionDataObject ExtensionData
    {
      get => this.extensionDataField;
      set => this.extensionDataField = value;
    }

    [DataMember]
    public bool AltPresent
    {
      get => this.AltPresentField;
      set
      {
        if (this.AltPresentField.Equals(value))
          return;
        this.AltPresentField = value;
        this.RaisePropertyChanged(nameof (AltPresent));
      }
    }

    [DataMember]
    public int AltShelteredWall
    {
      get => this.AltShelteredWallField;
      set
      {
        if (this.AltShelteredWallField.Equals(value))
          return;
        this.AltShelteredWallField = value;
        this.RaisePropertyChanged(nameof (AltShelteredWall));
      }
    }

    [DataMember]
    public double AltWallArea
    {
      get => this.AltWallAreaField;
      set
      {
        if (this.AltWallAreaField.Equals(value))
          return;
        this.AltWallAreaField = value;
        this.RaisePropertyChanged(nameof (AltWallArea));
      }
    }

    [DataMember]
    public int AltWallConstruction
    {
      get => this.AltWallConstructionField;
      set
      {
        if (this.AltWallConstructionField.Equals(value))
          return;
        this.AltWallConstructionField = value;
        this.RaisePropertyChanged(nameof (AltWallConstruction));
      }
    }

    [DataMember]
    public int AltWallDryLined
    {
      get => this.AltWallDryLinedField;
      set
      {
        if (this.AltWallDryLinedField.Equals(value))
          return;
        this.AltWallDryLinedField = value;
        this.RaisePropertyChanged(nameof (AltWallDryLined));
      }
    }

    [DataMember]
    public int AltWallInsulationThickness
    {
      get => this.AltWallInsulationThicknessField;
      set
      {
        if (this.AltWallInsulationThicknessField.Equals(value))
          return;
        this.AltWallInsulationThicknessField = value;
        this.RaisePropertyChanged(nameof (AltWallInsulationThickness));
      }
    }

    [DataMember]
    public int AltWallInsulationType
    {
      get => this.AltWallInsulationTypeField;
      set
      {
        if (this.AltWallInsulationTypeField.Equals(value))
          return;
        this.AltWallInsulationTypeField = value;
        this.RaisePropertyChanged(nameof (AltWallInsulationType));
      }
    }

    [DataMember]
    public double AltWallThickness
    {
      get => this.AltWallThicknessField;
      set
      {
        if (this.AltWallThicknessField.Equals(value))
          return;
        this.AltWallThicknessField = value;
        this.RaisePropertyChanged(nameof (AltWallThickness));
      }
    }

    [DataMember]
    public bool AltWallThicknessMeasured
    {
      get => this.AltWallThicknessMeasuredField;
      set
      {
        if (this.AltWallThicknessMeasuredField.Equals(value))
          return;
        this.AltWallThicknessMeasuredField = value;
        this.RaisePropertyChanged(nameof (AltWallThicknessMeasured));
      }
    }

    [DataMember]
    public double AltWallUValue
    {
      get => this.AltWallUValueField;
      set
      {
        if (this.AltWallUValueField.Equals(value))
          return;
        this.AltWallUValueField = value;
        this.RaisePropertyChanged(nameof (AltWallUValue));
      }
    }

    [DataMember]
    public bool AltWallUValueKnown
    {
      get => this.AltWallUValueKnownField;
      set
      {
        if (this.AltWallUValueKnownField.Equals(value))
          return;
        this.AltWallUValueKnownField = value;
        this.RaisePropertyChanged(nameof (AltWallUValueKnown));
      }
    }

    [DataMember]
    public bool DryLining
    {
      get => this.DryLiningField;
      set
      {
        if (this.DryLiningField.Equals(value))
          return;
        this.DryLiningField = value;
        this.RaisePropertyChanged(nameof (DryLining));
      }
    }

    [DataMember]
    public int FlatRoofInsulationThickness
    {
      get => this.FlatRoofInsulationThicknessField;
      set
      {
        if (this.FlatRoofInsulationThicknessField.Equals(value))
          return;
        this.FlatRoofInsulationThicknessField = value;
        this.RaisePropertyChanged(nameof (FlatRoofInsulationThickness));
      }
    }

    [DataMember]
    public int FloorConstruction
    {
      get => this.FloorConstructionField;
      set
      {
        if (this.FloorConstructionField.Equals(value))
          return;
        this.FloorConstructionField = value;
        this.RaisePropertyChanged(nameof (FloorConstruction));
      }
    }

    [DataMember]
    public int FloorInsulation
    {
      get => this.FloorInsulationField;
      set
      {
        if (this.FloorInsulationField.Equals(value))
          return;
        this.FloorInsulationField = value;
        this.RaisePropertyChanged(nameof (FloorInsulation));
      }
    }

    [DataMember]
    public int FloorInsulationThickness
    {
      get => this.FloorInsulationThicknessField;
      set
      {
        if (this.FloorInsulationThicknessField.Equals(value))
          return;
        this.FloorInsulationThicknessField = value;
        this.RaisePropertyChanged(nameof (FloorInsulationThickness));
      }
    }

    [DataMember]
    public double FloorUValue
    {
      get => this.FloorUValueField;
      set
      {
        if (this.FloorUValueField.Equals(value))
          return;
        this.FloorUValueField = value;
        this.RaisePropertyChanged(nameof (FloorUValue));
      }
    }

    [DataMember]
    public bool FloorUValueKnown
    {
      get => this.FloorUValueKnownField;
      set
      {
        if (this.FloorUValueKnownField.Equals(value))
          return;
        this.FloorUValueKnownField = value;
        this.RaisePropertyChanged(nameof (FloorUValueKnown));
      }
    }

    [DataMember]
    public string Identifier
    {
      get => this.IdentifierField;
      set
      {
        if (object.ReferenceEquals((object) this.IdentifierField, (object) value))
          return;
        this.IdentifierField = value;
        this.RaisePropertyChanged(nameof (Identifier));
      }
    }

    [DataMember]
    public int LowestFloor
    {
      get => this.LowestFloorField;
      set
      {
        if (this.LowestFloorField.Equals(value))
          return;
        this.LowestFloorField = value;
        this.RaisePropertyChanged(nameof (LowestFloor));
      }
    }

    [DataMember]
    public int PartyWallConstruction
    {
      get => this.PartyWallConstructionField;
      set
      {
        if (this.PartyWallConstructionField.Equals(value))
          return;
        this.PartyWallConstructionField = value;
        this.RaisePropertyChanged(nameof (PartyWallConstruction));
      }
    }

    [DataMember]
    public int PropAge
    {
      get => this.PropAgeField;
      set
      {
        if (this.PropAgeField.Equals(value))
          return;
        this.PropAgeField = value;
        this.RaisePropertyChanged(nameof (PropAge));
      }
    }

    [DataMember]
    public int RafterInsulationThickness
    {
      get => this.RafterInsulationThicknessField;
      set
      {
        if (this.RafterInsulationThicknessField.Equals(value))
          return;
        this.RafterInsulationThicknessField = value;
        this.RaisePropertyChanged(nameof (RafterInsulationThickness));
      }
    }

    [DataMember]
    public int RoofAge
    {
      get => this.RoofAgeField;
      set
      {
        if (this.RoofAgeField.Equals(value))
          return;
        this.RoofAgeField = value;
        this.RaisePropertyChanged(nameof (RoofAge));
      }
    }

    [DataMember]
    public int RoofConstruction
    {
      get => this.RoofConstructionField;
      set
      {
        if (this.RoofConstructionField.Equals(value))
          return;
        this.RoofConstructionField = value;
        this.RaisePropertyChanged(nameof (RoofConstruction));
      }
    }

    [DataMember]
    public int RoofInsulation
    {
      get => this.RoofInsulationField;
      set
      {
        if (this.RoofInsulationField.Equals(value))
          return;
        this.RoofInsulationField = value;
        this.RaisePropertyChanged(nameof (RoofInsulation));
      }
    }

    [DataMember]
    public int RoofInsulationThickness
    {
      get => this.RoofInsulationThicknessField;
      set
      {
        if (this.RoofInsulationThicknessField.Equals(value))
          return;
        this.RoofInsulationThicknessField = value;
        this.RaisePropertyChanged(nameof (RoofInsulationThickness));
      }
    }

    [DataMember]
    public bool RoofRoom
    {
      get => this.RoofRoomField;
      set
      {
        if (this.RoofRoomField.Equals(value))
          return;
        this.RoofRoomField = value;
        this.RaisePropertyChanged(nameof (RoofRoom));
      }
    }

    [DataMember]
    public double RoofRoomFloor_Area
    {
      get => this.RoofRoomFloor_AreaField;
      set
      {
        if (this.RoofRoomFloor_AreaField.Equals(value))
          return;
        this.RoofRoomFloor_AreaField = value;
        this.RaisePropertyChanged(nameof (RoofRoomFloor_Area));
      }
    }

    [DataMember]
    public bool RoofRoom_Edit
    {
      get => this.RoofRoom_EditField;
      set
      {
        if (this.RoofRoom_EditField.Equals(value))
          return;
        this.RoofRoom_EditField = value;
        this.RaisePropertyChanged(nameof (RoofRoom_Edit));
      }
    }

    [DataMember]
    public Extension_Class.Roof_Area[] RoofRoom_FlatCeiling
    {
      get => this.RoofRoom_FlatCeilingField;
      set
      {
        if (object.ReferenceEquals((object) this.RoofRoom_FlatCeilingField, (object) value))
          return;
        this.RoofRoom_FlatCeilingField = value;
        this.RaisePropertyChanged(nameof (RoofRoom_FlatCeiling));
      }
    }

    [DataMember]
    public Extension_Class.Roof_Area[] RoofRoom_GableWall
    {
      get => this.RoofRoom_GableWallField;
      set
      {
        if (object.ReferenceEquals((object) this.RoofRoom_GableWallField, (object) value))
          return;
        this.RoofRoom_GableWallField = value;
        this.RaisePropertyChanged(nameof (RoofRoom_GableWall));
      }
    }

    [DataMember]
    public int RoofRoom_Insulation
    {
      get => this.RoofRoom_InsulationField;
      set
      {
        if (this.RoofRoom_InsulationField.Equals(value))
          return;
        this.RoofRoom_InsulationField = value;
        this.RaisePropertyChanged(nameof (RoofRoom_Insulation));
      }
    }

    [DataMember]
    public Extension_Class.Roof_Area[] RoofRoom_Slope
    {
      get => this.RoofRoom_SlopeField;
      set
      {
        if (object.ReferenceEquals((object) this.RoofRoom_SlopeField, (object) value))
          return;
        this.RoofRoom_SlopeField = value;
        this.RaisePropertyChanged(nameof (RoofRoom_Slope));
      }
    }

    [DataMember]
    public Extension_Class.Roof_Area[] RoofRoom_StudWall
    {
      get => this.RoofRoom_StudWallField;
      set
      {
        if (object.ReferenceEquals((object) this.RoofRoom_StudWallField, (object) value))
          return;
        this.RoofRoom_StudWallField = value;
        this.RaisePropertyChanged(nameof (RoofRoom_StudWall));
      }
    }

    [DataMember]
    public int RoofRoom_Tickness
    {
      get => this.RoofRoom_TicknessField;
      set
      {
        if (this.RoofRoom_TicknessField.Equals(value))
          return;
        this.RoofRoom_TicknessField = value;
        this.RaisePropertyChanged(nameof (RoofRoom_Tickness));
      }
    }

    [DataMember]
    public double RoofUValue
    {
      get => this.RoofUValueField;
      set
      {
        if (this.RoofUValueField.Equals(value))
          return;
        this.RoofUValueField = value;
        this.RaisePropertyChanged(nameof (RoofUValue));
      }
    }

    [DataMember]
    public bool RoofUValueKnown
    {
      get => this.RoofUValueKnownField;
      set
      {
        if (this.RoofUValueKnownField.Equals(value))
          return;
        this.RoofUValueKnownField = value;
        this.RaisePropertyChanged(nameof (RoofUValueKnown));
      }
    }

    [DataMember]
    public bool RoomRoofConnected
    {
      get => this.RoomRoofConnectedField;
      set
      {
        if (this.RoomRoofConnectedField.Equals(value))
          return;
        this.RoomRoofConnectedField = value;
        this.RaisePropertyChanged(nameof (RoomRoofConnected));
      }
    }

    [DataMember]
    public int RoomRoofInsulationAtSlope
    {
      get => this.RoomRoofInsulationAtSlopeField;
      set
      {
        if (this.RoomRoofInsulationAtSlopeField.Equals(value))
          return;
        this.RoomRoofInsulationAtSlopeField = value;
        this.RaisePropertyChanged(nameof (RoomRoofInsulationAtSlope));
      }
    }

    [DataMember]
    public Extension_Class.Storey_Details[] Storey
    {
      get => this.StoreyField;
      set
      {
        if (object.ReferenceEquals((object) this.StoreyField, (object) value))
          return;
        this.StoreyField = value;
        this.RaisePropertyChanged(nameof (Storey));
      }
    }

    [DataMember]
    public int Storeys
    {
      get => this.StoreysField;
      set
      {
        if (this.StoreysField.Equals(value))
          return;
        this.StoreysField = value;
        this.RaisePropertyChanged(nameof (Storeys));
      }
    }

    [DataMember]
    public int WallConstruction
    {
      get => this.WallConstructionField;
      set
      {
        if (this.WallConstructionField.Equals(value))
          return;
        this.WallConstructionField = value;
        this.RaisePropertyChanged(nameof (WallConstruction));
      }
    }

    [DataMember]
    public int WallInsulation
    {
      get => this.WallInsulationField;
      set
      {
        if (this.WallInsulationField.Equals(value))
          return;
        this.WallInsulationField = value;
        this.RaisePropertyChanged(nameof (WallInsulation));
      }
    }

    [DataMember]
    public int WallInsulationThickness
    {
      get => this.WallInsulationThicknessField;
      set
      {
        if (this.WallInsulationThicknessField.Equals(value))
          return;
        this.WallInsulationThicknessField = value;
        this.RaisePropertyChanged(nameof (WallInsulationThickness));
      }
    }

    [DataMember]
    public double WallThickness
    {
      get => this.WallThicknessField;
      set
      {
        if (this.WallThicknessField.Equals(value))
          return;
        this.WallThicknessField = value;
        this.RaisePropertyChanged(nameof (WallThickness));
      }
    }

    [DataMember]
    public bool WallThicknessMeasured
    {
      get => this.WallThicknessMeasuredField;
      set
      {
        if (this.WallThicknessMeasuredField.Equals(value))
          return;
        this.WallThicknessMeasuredField = value;
        this.RaisePropertyChanged(nameof (WallThicknessMeasured));
      }
    }

    [DataMember]
    public double WallUValue
    {
      get => this.WallUValueField;
      set
      {
        if (this.WallUValueField.Equals(value))
          return;
        this.WallUValueField = value;
        this.RaisePropertyChanged(nameof (WallUValue));
      }
    }

    [DataMember]
    public bool WallUValueKnown
    {
      get => this.WallUValueKnownField;
      set
      {
        if (this.WallUValueKnownField.Equals(value))
          return;
        this.WallUValueKnownField = value;
        this.RaisePropertyChanged(nameof (WallUValueKnown));
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

    [DebuggerStepThrough]
    [GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
    [DataContract(Name = "Extension_Class.Roof_Area", Namespace = "http://schemas.datacontract.org/2004/07/StromaServices")]
    [Serializable]
    public class Roof_Area : IExtensibleDataObject, INotifyPropertyChanged
    {
      [NonSerialized]
      private ExtensionDataObject extensionDataField;
      [OptionalField]
      private double AreaField;
      [OptionalField]
      private double U_ValueField;

      public ExtensionDataObject ExtensionData
      {
        get => this.extensionDataField;
        set => this.extensionDataField = value;
      }

      [DataMember]
      public double Area
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

      [DataMember]
      public double U_Value
      {
        get => this.U_ValueField;
        set
        {
          if (this.U_ValueField.Equals(value))
            return;
          this.U_ValueField = value;
          this.RaisePropertyChanged(nameof (U_Value));
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

    [DebuggerStepThrough]
    [GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
    [DataContract(Name = "Extension_Class.Storey_Details", Namespace = "http://schemas.datacontract.org/2004/07/StromaServices")]
    [Serializable]
    public class Storey_Details : IExtensibleDataObject, INotifyPropertyChanged
    {
      [NonSerialized]
      private ExtensionDataObject extensionDataField;
      [OptionalField]
      private double AreaField;
      [OptionalField]
      private double HeightField;
      [OptionalField]
      private string NameField;
      [OptionalField]
      private double PartyWallField;
      [OptionalField]
      private double PerimeterField;

      public ExtensionDataObject ExtensionData
      {
        get => this.extensionDataField;
        set => this.extensionDataField = value;
      }

      [DataMember]
      public double Area
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

      [DataMember]
      public double Height
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

      [DataMember]
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

      [DataMember]
      public double PartyWall
      {
        get => this.PartyWallField;
        set
        {
          if (this.PartyWallField.Equals(value))
            return;
          this.PartyWallField = value;
          this.RaisePropertyChanged(nameof (PartyWall));
        }
      }

      [DataMember]
      public double Perimeter
      {
        get => this.PerimeterField;
        set
        {
          if (this.PerimeterField.Equals(value))
            return;
          this.PerimeterField = value;
          this.RaisePropertyChanged(nameof (Perimeter));
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
}
