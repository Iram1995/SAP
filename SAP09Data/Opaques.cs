
// Type: SAP2012.SAP09Data.Opaques




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace SAP2012.SAP09Data
{
  [DebuggerStepThrough]
  [GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
  [DataContract(Name = "Opaques", Namespace = "http://rdsap2009.stroma.com/SAPData/SAP09Compliance.asmx")]
  [Serializable]
  public class Opaques : IExtensibleDataObject, INotifyPropertyChanged
  {
    [NonSerialized]
    private ExtensionDataObject extensionDataField;
    [OptionalField]
    private string NameField;
    [OptionalField]
    private string TypeField;
    [OptionalField]
    private string ConstructionField;
    private float AreaField;
    private float U_ValueField;
    private float RuField;
    private bool CurtainField;
    private float KField;
    private int UValueSelectionField;
    private bool UValueSelectedField;

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

    [DataMember(EmitDefaultValue = false)]
    public string Type
    {
      get => this.TypeField;
      set
      {
        if (object.ReferenceEquals((object) this.TypeField, (object) value))
          return;
        this.TypeField = value;
        this.RaisePropertyChanged(nameof (Type));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 2)]
    public string Construction
    {
      get => this.ConstructionField;
      set
      {
        if (object.ReferenceEquals((object) this.ConstructionField, (object) value))
          return;
        this.ConstructionField = value;
        this.RaisePropertyChanged(nameof (Construction));
      }
    }

    [DataMember(IsRequired = true, Order = 3)]
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

    [DataMember(IsRequired = true, Order = 4)]
    public float U_Value
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

    [DataMember(IsRequired = true, Order = 5)]
    public float Ru
    {
      get => this.RuField;
      set
      {
        if (this.RuField.Equals(value))
          return;
        this.RuField = value;
        this.RaisePropertyChanged(nameof (Ru));
      }
    }

    [DataMember(IsRequired = true, Order = 6)]
    public bool Curtain
    {
      get => this.CurtainField;
      set
      {
        if (this.CurtainField.Equals(value))
          return;
        this.CurtainField = value;
        this.RaisePropertyChanged(nameof (Curtain));
      }
    }

    [DataMember(IsRequired = true, Order = 7)]
    public float K
    {
      get => this.KField;
      set
      {
        if (this.KField.Equals(value))
          return;
        this.KField = value;
        this.RaisePropertyChanged(nameof (K));
      }
    }

    [DataMember(IsRequired = true, Order = 8)]
    public int UValueSelection
    {
      get => this.UValueSelectionField;
      set
      {
        if (this.UValueSelectionField.Equals(value))
          return;
        this.UValueSelectionField = value;
        this.RaisePropertyChanged(nameof (UValueSelection));
      }
    }

    [DataMember(IsRequired = true, Order = 9)]
    public bool UValueSelected
    {
      get => this.UValueSelectedField;
      set
      {
        if (this.UValueSelectedField.Equals(value))
          return;
        this.UValueSelectedField = value;
        this.RaisePropertyChanged(nameof (UValueSelected));
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
