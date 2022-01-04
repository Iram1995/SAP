
// Type: SAP2012.SAP09Data.Dwelling




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace SAP2012.SAP09Data
{
  [DebuggerStepThrough]
  [GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
  [DataContract(Name = "Dwelling", Namespace = "http://rdsap2009.stroma.com/SAPData/SAP09Compliance.asmx")]
  [Serializable]
  public class Dwelling : IExtensibleDataObject, INotifyPropertyChanged
  {
    [NonSerialized]
    private ExtensionDataObject extensionDataField;
    [OptionalField]
    private string NameField;
    private int IDField;
    [OptionalField]
    private string ReferenceField;
    [OptionalField]
    private string SAPOnlyField;
    [OptionalField]
    private string OverheatField;
    [OptionalField]
    private string StatusField;
    private DateTime DateAssessmentField;
    private DateTime DateCertificateField;
    [OptionalField]
    private string TransactionField;
    [OptionalField]
    private string RPDField;
    private Address AddressField;
    [OptionalField]
    private string UPRNField;
    [OptionalField]
    private string PropertyTypeField;
    [OptionalField]
    private string BuildFormField;
    [OptionalField]
    private string FlatTypeField;
    private int YearBuiltField;
    [OptionalField]
    private string LocationField;
    private int ShelteredSidesField;
    [OptionalField]
    private string TerrainField;
    [OptionalField]
    private string OrientationField;
    [OptionalField]
    private string AirConField;
    [OptionalField]
    private string ConservatoryField;
    private float LowEnergyLightField;
    private int LELOutletsField;
    private int LELLightsField;
    [OptionalField]
    private string EPCLanguageField;
    [OptionalField]
    private string SmokeAreaField;
    [OptionalField]
    private string OvershadingField;
    private bool LessThan125LitreField;
    private int StoreysField;
    private bool TrueRoofField;
    private float LivingAreaField;
    [OptionalField]
    private float LivingFractionField;
    private bool LivingFractionSpecifiedField;
    [OptionalField]
    private Dimensions[] DimsField;
    private int NoofFloorsField;
    private bool GrossAreasField;
    [OptionalField]
    private Opaques[] FloorsField;
    private int NoofPFloorsField;
    private int NoofIFloorsField;
    private int NoofWallsField;
    [OptionalField]
    private Opaques[] WallsField;
    private int NoofPWallsField;
    [OptionalField]
    private PartyWall[] PWallsField;
    private int NoofRoofsField;
    [OptionalField]
    private Opaques[] RoofsField;
    private int NoofPCeilingsField;
    private int NoofICeilingsField;
    private int NoofDoorsField;
    [OptionalField]
    private Door[] DoorsField;
    private int NoofWindowsField;
    [OptionalField]
    private Window[] WindowsField;
    private int NoofRoofLightsField;
    [OptionalField]
    private RoofLight[] RoofLightsField;
    private bool IncludeMainHeating2Field;
    private float HeatFractionSecField;
    private bool Include_SecMain_Heat_Separat_PartField;
    private bool Include_SecMain_Heat_WholeField;
    private ReNewable RenewableField;
    private int LodgementAttemptsField;
    private int NoOfScotGraphsField;
    private bool DisplayScotFrontpageOnlyField;
    private bool SimplifiedApproachField;
    private float TotalFloorAreaField;
    private Client ClientField;
    private Address ProjectAddressField;

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

    [DataMember(IsRequired = true, Order = 1)]
    public int ID
    {
      get => this.IDField;
      set
      {
        if (this.IDField.Equals(value))
          return;
        this.IDField = value;
        this.RaisePropertyChanged(nameof (ID));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 2)]
    public string Reference
    {
      get => this.ReferenceField;
      set
      {
        if (object.ReferenceEquals((object) this.ReferenceField, (object) value))
          return;
        this.ReferenceField = value;
        this.RaisePropertyChanged(nameof (Reference));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 3)]
    public string SAPOnly
    {
      get => this.SAPOnlyField;
      set
      {
        if (object.ReferenceEquals((object) this.SAPOnlyField, (object) value))
          return;
        this.SAPOnlyField = value;
        this.RaisePropertyChanged(nameof (SAPOnly));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 4)]
    public string Overheat
    {
      get => this.OverheatField;
      set
      {
        if (object.ReferenceEquals((object) this.OverheatField, (object) value))
          return;
        this.OverheatField = value;
        this.RaisePropertyChanged(nameof (Overheat));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 5)]
    public string Status
    {
      get => this.StatusField;
      set
      {
        if (object.ReferenceEquals((object) this.StatusField, (object) value))
          return;
        this.StatusField = value;
        this.RaisePropertyChanged(nameof (Status));
      }
    }

    [DataMember(IsRequired = true, Order = 6)]
    public DateTime DateAssessment
    {
      get => this.DateAssessmentField;
      set
      {
        if (this.DateAssessmentField.Equals(value))
          return;
        this.DateAssessmentField = value;
        this.RaisePropertyChanged(nameof (DateAssessment));
      }
    }

    [DataMember(IsRequired = true, Order = 7)]
    public DateTime DateCertificate
    {
      get => this.DateCertificateField;
      set
      {
        if (this.DateCertificateField.Equals(value))
          return;
        this.DateCertificateField = value;
        this.RaisePropertyChanged(nameof (DateCertificate));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 8)]
    public string Transaction
    {
      get => this.TransactionField;
      set
      {
        if (object.ReferenceEquals((object) this.TransactionField, (object) value))
          return;
        this.TransactionField = value;
        this.RaisePropertyChanged(nameof (Transaction));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 9)]
    public string RPD
    {
      get => this.RPDField;
      set
      {
        if (object.ReferenceEquals((object) this.RPDField, (object) value))
          return;
        this.RPDField = value;
        this.RaisePropertyChanged(nameof (RPD));
      }
    }

    [DataMember(EmitDefaultValue = false, IsRequired = true, Order = 10)]
    public Address Address
    {
      get => this.AddressField;
      set
      {
        if (object.ReferenceEquals((object) this.AddressField, (object) value))
          return;
        this.AddressField = value;
        this.RaisePropertyChanged(nameof (Address));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 11)]
    public string UPRN
    {
      get => this.UPRNField;
      set
      {
        if (object.ReferenceEquals((object) this.UPRNField, (object) value))
          return;
        this.UPRNField = value;
        this.RaisePropertyChanged(nameof (UPRN));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 12)]
    public string PropertyType
    {
      get => this.PropertyTypeField;
      set
      {
        if (object.ReferenceEquals((object) this.PropertyTypeField, (object) value))
          return;
        this.PropertyTypeField = value;
        this.RaisePropertyChanged(nameof (PropertyType));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 13)]
    public string BuildForm
    {
      get => this.BuildFormField;
      set
      {
        if (object.ReferenceEquals((object) this.BuildFormField, (object) value))
          return;
        this.BuildFormField = value;
        this.RaisePropertyChanged(nameof (BuildForm));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 14)]
    public string FlatType
    {
      get => this.FlatTypeField;
      set
      {
        if (object.ReferenceEquals((object) this.FlatTypeField, (object) value))
          return;
        this.FlatTypeField = value;
        this.RaisePropertyChanged(nameof (FlatType));
      }
    }

    [DataMember(IsRequired = true, Order = 15)]
    public int YearBuilt
    {
      get => this.YearBuiltField;
      set
      {
        if (this.YearBuiltField.Equals(value))
          return;
        this.YearBuiltField = value;
        this.RaisePropertyChanged(nameof (YearBuilt));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 16)]
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

    [DataMember(IsRequired = true, Order = 17)]
    public int ShelteredSides
    {
      get => this.ShelteredSidesField;
      set
      {
        if (this.ShelteredSidesField.Equals(value))
          return;
        this.ShelteredSidesField = value;
        this.RaisePropertyChanged(nameof (ShelteredSides));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 18)]
    public string Terrain
    {
      get => this.TerrainField;
      set
      {
        if (object.ReferenceEquals((object) this.TerrainField, (object) value))
          return;
        this.TerrainField = value;
        this.RaisePropertyChanged(nameof (Terrain));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 19)]
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

    [DataMember(EmitDefaultValue = false, Order = 20)]
    public string AirCon
    {
      get => this.AirConField;
      set
      {
        if (object.ReferenceEquals((object) this.AirConField, (object) value))
          return;
        this.AirConField = value;
        this.RaisePropertyChanged(nameof (AirCon));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 21)]
    public string Conservatory
    {
      get => this.ConservatoryField;
      set
      {
        if (object.ReferenceEquals((object) this.ConservatoryField, (object) value))
          return;
        this.ConservatoryField = value;
        this.RaisePropertyChanged(nameof (Conservatory));
      }
    }

    [DataMember(IsRequired = true, Order = 22)]
    public float LowEnergyLight
    {
      get => this.LowEnergyLightField;
      set
      {
        if (this.LowEnergyLightField.Equals(value))
          return;
        this.LowEnergyLightField = value;
        this.RaisePropertyChanged(nameof (LowEnergyLight));
      }
    }

    [DataMember(IsRequired = true, Order = 23)]
    public int LELOutlets
    {
      get => this.LELOutletsField;
      set
      {
        if (this.LELOutletsField.Equals(value))
          return;
        this.LELOutletsField = value;
        this.RaisePropertyChanged(nameof (LELOutlets));
      }
    }

    [DataMember(IsRequired = true, Order = 24)]
    public int LELLights
    {
      get => this.LELLightsField;
      set
      {
        if (this.LELLightsField.Equals(value))
          return;
        this.LELLightsField = value;
        this.RaisePropertyChanged(nameof (LELLights));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 25)]
    public string EPCLanguage
    {
      get => this.EPCLanguageField;
      set
      {
        if (object.ReferenceEquals((object) this.EPCLanguageField, (object) value))
          return;
        this.EPCLanguageField = value;
        this.RaisePropertyChanged(nameof (EPCLanguage));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 26)]
    public string SmokeArea
    {
      get => this.SmokeAreaField;
      set
      {
        if (object.ReferenceEquals((object) this.SmokeAreaField, (object) value))
          return;
        this.SmokeAreaField = value;
        this.RaisePropertyChanged(nameof (SmokeArea));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 27)]
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

    [DataMember(IsRequired = true, Order = 28)]
    public bool LessThan125Litre
    {
      get => this.LessThan125LitreField;
      set
      {
        if (this.LessThan125LitreField.Equals(value))
          return;
        this.LessThan125LitreField = value;
        this.RaisePropertyChanged(nameof (LessThan125Litre));
      }
    }

    [DataMember(IsRequired = true, Order = 29)]
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

    [DataMember(IsRequired = true, Order = 30)]
    public bool TrueRoof
    {
      get => this.TrueRoofField;
      set
      {
        if (this.TrueRoofField.Equals(value))
          return;
        this.TrueRoofField = value;
        this.RaisePropertyChanged(nameof (TrueRoof));
      }
    }

    [DataMember(IsRequired = true, Order = 31)]
    public float LivingArea
    {
      get => this.LivingAreaField;
      set
      {
        if (this.LivingAreaField.Equals(value))
          return;
        this.LivingAreaField = value;
        this.RaisePropertyChanged(nameof (LivingArea));
      }
    }

    [DataMember(Order = 32)]
    public float LivingFraction
    {
      get => this.LivingFractionField;
      set
      {
        if (this.LivingFractionField.Equals(value))
          return;
        this.LivingFractionField = value;
        this.RaisePropertyChanged(nameof (LivingFraction));
      }
    }

    [DataMember(IsRequired = true, Order = 33)]
    public bool LivingFractionSpecified
    {
      get => this.LivingFractionSpecifiedField;
      set
      {
        if (this.LivingFractionSpecifiedField.Equals(value))
          return;
        this.LivingFractionSpecifiedField = value;
        this.RaisePropertyChanged(nameof (LivingFractionSpecified));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 34)]
    public Dimensions[] Dims
    {
      get => this.DimsField;
      set
      {
        if (object.ReferenceEquals((object) this.DimsField, (object) value))
          return;
        this.DimsField = value;
        this.RaisePropertyChanged(nameof (Dims));
      }
    }

    [DataMember(IsRequired = true, Order = 35)]
    public int NoofFloors
    {
      get => this.NoofFloorsField;
      set
      {
        if (this.NoofFloorsField.Equals(value))
          return;
        this.NoofFloorsField = value;
        this.RaisePropertyChanged(nameof (NoofFloors));
      }
    }

    [DataMember(IsRequired = true, Order = 36)]
    public bool GrossAreas
    {
      get => this.GrossAreasField;
      set
      {
        if (this.GrossAreasField.Equals(value))
          return;
        this.GrossAreasField = value;
        this.RaisePropertyChanged(nameof (GrossAreas));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 37)]
    public Opaques[] Floors
    {
      get => this.FloorsField;
      set
      {
        if (object.ReferenceEquals((object) this.FloorsField, (object) value))
          return;
        this.FloorsField = value;
        this.RaisePropertyChanged(nameof (Floors));
      }
    }

    [DataMember(IsRequired = true, Order = 38)]
    public int NoofPFloors
    {
      get => this.NoofPFloorsField;
      set
      {
        if (this.NoofPFloorsField.Equals(value))
          return;
        this.NoofPFloorsField = value;
        this.RaisePropertyChanged(nameof (NoofPFloors));
      }
    }

    [DataMember(IsRequired = true, Order = 39)]
    public int NoofIFloors
    {
      get => this.NoofIFloorsField;
      set
      {
        if (this.NoofIFloorsField.Equals(value))
          return;
        this.NoofIFloorsField = value;
        this.RaisePropertyChanged(nameof (NoofIFloors));
      }
    }

    [DataMember(IsRequired = true, Order = 40)]
    public int NoofWalls
    {
      get => this.NoofWallsField;
      set
      {
        if (this.NoofWallsField.Equals(value))
          return;
        this.NoofWallsField = value;
        this.RaisePropertyChanged(nameof (NoofWalls));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 41)]
    public Opaques[] Walls
    {
      get => this.WallsField;
      set
      {
        if (object.ReferenceEquals((object) this.WallsField, (object) value))
          return;
        this.WallsField = value;
        this.RaisePropertyChanged(nameof (Walls));
      }
    }

    [DataMember(IsRequired = true, Order = 42)]
    public int NoofPWalls
    {
      get => this.NoofPWallsField;
      set
      {
        if (this.NoofPWallsField.Equals(value))
          return;
        this.NoofPWallsField = value;
        this.RaisePropertyChanged(nameof (NoofPWalls));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 43)]
    public PartyWall[] PWalls
    {
      get => this.PWallsField;
      set
      {
        if (object.ReferenceEquals((object) this.PWallsField, (object) value))
          return;
        this.PWallsField = value;
        this.RaisePropertyChanged(nameof (PWalls));
      }
    }

    [DataMember(IsRequired = true, Order = 44)]
    public int NoofRoofs
    {
      get => this.NoofRoofsField;
      set
      {
        if (this.NoofRoofsField.Equals(value))
          return;
        this.NoofRoofsField = value;
        this.RaisePropertyChanged(nameof (NoofRoofs));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 45)]
    public Opaques[] Roofs
    {
      get => this.RoofsField;
      set
      {
        if (object.ReferenceEquals((object) this.RoofsField, (object) value))
          return;
        this.RoofsField = value;
        this.RaisePropertyChanged(nameof (Roofs));
      }
    }

    [DataMember(IsRequired = true, Order = 46)]
    public int NoofPCeilings
    {
      get => this.NoofPCeilingsField;
      set
      {
        if (this.NoofPCeilingsField.Equals(value))
          return;
        this.NoofPCeilingsField = value;
        this.RaisePropertyChanged(nameof (NoofPCeilings));
      }
    }

    [DataMember(IsRequired = true, Order = 47)]
    public int NoofICeilings
    {
      get => this.NoofICeilingsField;
      set
      {
        if (this.NoofICeilingsField.Equals(value))
          return;
        this.NoofICeilingsField = value;
        this.RaisePropertyChanged(nameof (NoofICeilings));
      }
    }

    [DataMember(IsRequired = true, Order = 48)]
    public int NoofDoors
    {
      get => this.NoofDoorsField;
      set
      {
        if (this.NoofDoorsField.Equals(value))
          return;
        this.NoofDoorsField = value;
        this.RaisePropertyChanged(nameof (NoofDoors));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 49)]
    public Door[] Doors
    {
      get => this.DoorsField;
      set
      {
        if (object.ReferenceEquals((object) this.DoorsField, (object) value))
          return;
        this.DoorsField = value;
        this.RaisePropertyChanged(nameof (Doors));
      }
    }

    [DataMember(IsRequired = true, Order = 50)]
    public int NoofWindows
    {
      get => this.NoofWindowsField;
      set
      {
        if (this.NoofWindowsField.Equals(value))
          return;
        this.NoofWindowsField = value;
        this.RaisePropertyChanged(nameof (NoofWindows));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 51)]
    public Window[] Windows
    {
      get => this.WindowsField;
      set
      {
        if (object.ReferenceEquals((object) this.WindowsField, (object) value))
          return;
        this.WindowsField = value;
        this.RaisePropertyChanged(nameof (Windows));
      }
    }

    [DataMember(IsRequired = true, Order = 52)]
    public int NoofRoofLights
    {
      get => this.NoofRoofLightsField;
      set
      {
        if (this.NoofRoofLightsField.Equals(value))
          return;
        this.NoofRoofLightsField = value;
        this.RaisePropertyChanged(nameof (NoofRoofLights));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 53)]
    public RoofLight[] RoofLights
    {
      get => this.RoofLightsField;
      set
      {
        if (object.ReferenceEquals((object) this.RoofLightsField, (object) value))
          return;
        this.RoofLightsField = value;
        this.RaisePropertyChanged(nameof (RoofLights));
      }
    }

    [DataMember(IsRequired = true, Order = 54)]
    public bool IncludeMainHeating2
    {
      get => this.IncludeMainHeating2Field;
      set
      {
        if (this.IncludeMainHeating2Field.Equals(value))
          return;
        this.IncludeMainHeating2Field = value;
        this.RaisePropertyChanged(nameof (IncludeMainHeating2));
      }
    }

    [DataMember(IsRequired = true, Order = 55)]
    public float HeatFractionSec
    {
      get => this.HeatFractionSecField;
      set
      {
        if (this.HeatFractionSecField.Equals(value))
          return;
        this.HeatFractionSecField = value;
        this.RaisePropertyChanged(nameof (HeatFractionSec));
      }
    }

    [DataMember(IsRequired = true, Order = 56)]
    public bool Include_SecMain_Heat_Separat_Part
    {
      get => this.Include_SecMain_Heat_Separat_PartField;
      set
      {
        if (this.Include_SecMain_Heat_Separat_PartField.Equals(value))
          return;
        this.Include_SecMain_Heat_Separat_PartField = value;
        this.RaisePropertyChanged(nameof (Include_SecMain_Heat_Separat_Part));
      }
    }

    [DataMember(IsRequired = true, Order = 57)]
    public bool Include_SecMain_Heat_Whole
    {
      get => this.Include_SecMain_Heat_WholeField;
      set
      {
        if (this.Include_SecMain_Heat_WholeField.Equals(value))
          return;
        this.Include_SecMain_Heat_WholeField = value;
        this.RaisePropertyChanged(nameof (Include_SecMain_Heat_Whole));
      }
    }

    [DataMember(EmitDefaultValue = false, IsRequired = true, Order = 58)]
    public ReNewable Renewable
    {
      get => this.RenewableField;
      set
      {
        if (object.ReferenceEquals((object) this.RenewableField, (object) value))
          return;
        this.RenewableField = value;
        this.RaisePropertyChanged(nameof (Renewable));
      }
    }

    [DataMember(IsRequired = true, Order = 59)]
    public int LodgementAttempts
    {
      get => this.LodgementAttemptsField;
      set
      {
        if (this.LodgementAttemptsField.Equals(value))
          return;
        this.LodgementAttemptsField = value;
        this.RaisePropertyChanged(nameof (LodgementAttempts));
      }
    }

    [DataMember(IsRequired = true, Order = 60)]
    public int NoOfScotGraphs
    {
      get => this.NoOfScotGraphsField;
      set
      {
        if (this.NoOfScotGraphsField.Equals(value))
          return;
        this.NoOfScotGraphsField = value;
        this.RaisePropertyChanged(nameof (NoOfScotGraphs));
      }
    }

    [DataMember(IsRequired = true, Order = 61)]
    public bool DisplayScotFrontpageOnly
    {
      get => this.DisplayScotFrontpageOnlyField;
      set
      {
        if (this.DisplayScotFrontpageOnlyField.Equals(value))
          return;
        this.DisplayScotFrontpageOnlyField = value;
        this.RaisePropertyChanged(nameof (DisplayScotFrontpageOnly));
      }
    }

    [DataMember(IsRequired = true, Order = 62)]
    public bool SimplifiedApproach
    {
      get => this.SimplifiedApproachField;
      set
      {
        if (this.SimplifiedApproachField.Equals(value))
          return;
        this.SimplifiedApproachField = value;
        this.RaisePropertyChanged(nameof (SimplifiedApproach));
      }
    }

    [DataMember(IsRequired = true, Order = 63)]
    public float TotalFloorArea
    {
      get => this.TotalFloorAreaField;
      set
      {
        if (this.TotalFloorAreaField.Equals(value))
          return;
        this.TotalFloorAreaField = value;
        this.RaisePropertyChanged(nameof (TotalFloorArea));
      }
    }

    [DataMember(EmitDefaultValue = false, IsRequired = true, Order = 64)]
    public Client Client
    {
      get => this.ClientField;
      set
      {
        if (object.ReferenceEquals((object) this.ClientField, (object) value))
          return;
        this.ClientField = value;
        this.RaisePropertyChanged(nameof (Client));
      }
    }

    [DataMember(EmitDefaultValue = false, IsRequired = true, Order = 65)]
    public Address ProjectAddress
    {
      get => this.ProjectAddressField;
      set
      {
        if (object.ReferenceEquals((object) this.ProjectAddressField, (object) value))
          return;
        this.ProjectAddressField = value;
        this.RaisePropertyChanged(nameof (ProjectAddress));
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
