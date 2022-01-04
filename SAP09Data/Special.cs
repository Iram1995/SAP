
// Type: SAP2012.SAP09Data.Special




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace SAP2012.SAP09Data
{
  [DebuggerStepThrough]
  [GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
  [DataContract(Name = "Special", Namespace = "http://rdsap2009.stroma.com/SAPData/SAP09Compliance.asmx")]
  [Serializable]
  public class Special : IExtensibleDataObject, INotifyPropertyChanged
  {
    [NonSerialized]
    private ExtensionDataObject extensionDataField;
    private bool IncludeField;
    [OptionalField]
    private SpecialFeatures[] SpecialMemberField;
    [OptionalField]
    private string DescriptionField;
    private float EnergySavedField;
    [OptionalField]
    private string FuelSavedField;
    private float EnergyUsedField;
    [OptionalField]
    private string FuelUsedField;

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

    [DataMember(EmitDefaultValue = false, Name = "Special")]
    public SpecialFeatures[] SpecialMember
    {
      get => this.SpecialMemberField;
      set
      {
        if (object.ReferenceEquals((object) this.SpecialMemberField, (object) value))
          return;
        this.SpecialMemberField = value;
        this.RaisePropertyChanged(nameof (SpecialMember));
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
