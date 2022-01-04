
// Type: SAP2012.SAP09Data.PartyWall




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace SAP2012.SAP09Data
{
  [DebuggerStepThrough]
  [GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
  [DataContract(Name = "PartyWall", Namespace = "http://rdsap2009.stroma.com/SAPData/SAP09Compliance.asmx")]
  [Serializable]
  public class PartyWall : IExtensibleDataObject, INotifyPropertyChanged
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
    private float KField;

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
