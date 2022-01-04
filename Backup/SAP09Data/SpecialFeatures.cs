
// Type: SAP2012.SAP09Data.SpecialFeatures




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace SAP2012.SAP09Data
{
  [DebuggerStepThrough]
  [GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
  [DataContract(Name = "SpecialFeatures", Namespace = "http://rdsap2009.stroma.com/SAPData/SAP09Compliance.asmx")]
  [Serializable]
  public class SpecialFeatures : IExtensibleDataObject, INotifyPropertyChanged
  {
    [NonSerialized]
    private ExtensionDataObject extensionDataField;
    private bool IncludeField;
    private int IDField;
    [OptionalField]
    private string DescriptionField;
    private float EnergySavedField;
    [OptionalField]
    private string FuelSavedField;
    private float EnergyUsedField;
    [OptionalField]
    private string FuelUsedField;
    private bool IncludeMonthlyField;
    private float M1Field;
    private float M2Field;
    private float M3Field;
    private float M4Field;
    private float M5Field;
    private float M6Field;
    private float M7Field;
    private float M8Field;
    private float M9Field;
    private float M10Field;
    private float M11Field;
    private float M12Field;

    [Browsable(false)]
    public ExtensionDataObject ExtensionData
    {
      get => this.extensionDataField;
      set => this.extensionDataField = value;
    }

    [DataMember(IsRequired = true)]
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
    public string Description
    {
      get => this.DescriptionField;
      set
      {
        if (object.ReferenceEquals((object) this.DescriptionField, (object) value))
          return;
        this.DescriptionField = value;
        this.RaisePropertyChanged(nameof (Description));
      }
    }

    [DataMember(IsRequired = true, Order = 3)]
    public float EnergySaved
    {
      get => this.EnergySavedField;
      set
      {
        if (this.EnergySavedField.Equals(value))
          return;
        this.EnergySavedField = value;
        this.RaisePropertyChanged(nameof (EnergySaved));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 4)]
    public string FuelSaved
    {
      get => this.FuelSavedField;
      set
      {
        if (object.ReferenceEquals((object) this.FuelSavedField, (object) value))
          return;
        this.FuelSavedField = value;
        this.RaisePropertyChanged(nameof (FuelSaved));
      }
    }

    [DataMember(IsRequired = true, Order = 5)]
    public float EnergyUsed
    {
      get => this.EnergyUsedField;
      set
      {
        if (this.EnergyUsedField.Equals(value))
          return;
        this.EnergyUsedField = value;
        this.RaisePropertyChanged(nameof (EnergyUsed));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 6)]
    public string FuelUsed
    {
      get => this.FuelUsedField;
      set
      {
        if (object.ReferenceEquals((object) this.FuelUsedField, (object) value))
          return;
        this.FuelUsedField = value;
        this.RaisePropertyChanged(nameof (FuelUsed));
      }
    }

    [DataMember(IsRequired = true, Order = 7)]
    public bool IncludeMonthly
    {
      get => this.IncludeMonthlyField;
      set
      {
        if (this.IncludeMonthlyField.Equals(value))
          return;
        this.IncludeMonthlyField = value;
        this.RaisePropertyChanged(nameof (IncludeMonthly));
      }
    }

    [DataMember(IsRequired = true, Order = 8)]
    public float M1
    {
      get => this.M1Field;
      set
      {
        if (this.M1Field.Equals(value))
          return;
        this.M1Field = value;
        this.RaisePropertyChanged(nameof (M1));
      }
    }

    [DataMember(IsRequired = true, Order = 9)]
    public float M2
    {
      get => this.M2Field;
      set
      {
        if (this.M2Field.Equals(value))
          return;
        this.M2Field = value;
        this.RaisePropertyChanged(nameof (M2));
      }
    }

    [DataMember(IsRequired = true, Order = 10)]
    public float M3
    {
      get => this.M3Field;
      set
      {
        if (this.M3Field.Equals(value))
          return;
        this.M3Field = value;
        this.RaisePropertyChanged(nameof (M3));
      }
    }

    [DataMember(IsRequired = true, Order = 11)]
    public float M4
    {
      get => this.M4Field;
      set
      {
        if (this.M4Field.Equals(value))
          return;
        this.M4Field = value;
        this.RaisePropertyChanged(nameof (M4));
      }
    }

    [DataMember(IsRequired = true, Order = 12)]
    public float M5
    {
      get => this.M5Field;
      set
      {
        if (this.M5Field.Equals(value))
          return;
        this.M5Field = value;
        this.RaisePropertyChanged(nameof (M5));
      }
    }

    [DataMember(IsRequired = true, Order = 13)]
    public float M6
    {
      get => this.M6Field;
      set
      {
        if (this.M6Field.Equals(value))
          return;
        this.M6Field = value;
        this.RaisePropertyChanged(nameof (M6));
      }
    }

    [DataMember(IsRequired = true, Order = 14)]
    public float M7
    {
      get => this.M7Field;
      set
      {
        if (this.M7Field.Equals(value))
          return;
        this.M7Field = value;
        this.RaisePropertyChanged(nameof (M7));
      }
    }

    [DataMember(IsRequired = true, Order = 15)]
    public float M8
    {
      get => this.M8Field;
      set
      {
        if (this.M8Field.Equals(value))
          return;
        this.M8Field = value;
        this.RaisePropertyChanged(nameof (M8));
      }
    }

    [DataMember(IsRequired = true, Order = 16)]
    public float M9
    {
      get => this.M9Field;
      set
      {
        if (this.M9Field.Equals(value))
          return;
        this.M9Field = value;
        this.RaisePropertyChanged(nameof (M9));
      }
    }

    [DataMember(IsRequired = true, Order = 17)]
    public float M10
    {
      get => this.M10Field;
      set
      {
        if (this.M10Field.Equals(value))
          return;
        this.M10Field = value;
        this.RaisePropertyChanged(nameof (M10));
      }
    }

    [DataMember(IsRequired = true, Order = 18)]
    public float M11
    {
      get => this.M11Field;
      set
      {
        if (this.M11Field.Equals(value))
          return;
        this.M11Field = value;
        this.RaisePropertyChanged(nameof (M11));
      }
    }

    [DataMember(IsRequired = true, Order = 19)]
    public float M12
    {
      get => this.M12Field;
      set
      {
        if (this.M12Field.Equals(value))
          return;
        this.M12Field = value;
        this.RaisePropertyChanged(nameof (M12));
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
