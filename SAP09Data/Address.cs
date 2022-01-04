
// Type: SAP2012.SAP09Data.Address




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace SAP2012.SAP09Data
{
  [DebuggerStepThrough]
  [GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
  [DataContract(Name = "Address", Namespace = "http://rdsap2009.stroma.com/SAPData/SAP09Compliance.asmx")]
  [Serializable]
  public class Address : IExtensibleDataObject, INotifyPropertyChanged
  {
    [NonSerialized]
    private ExtensionDataObject extensionDataField;
    [OptionalField]
    private string Line1Field;
    [OptionalField]
    private string Line2Field;
    [OptionalField]
    private string Line3Field;
    [OptionalField]
    private string CityField;
    [OptionalField]
    private string CountryField;
    [OptionalField]
    private string PostCostField;

    [Browsable(false)]
    public ExtensionDataObject ExtensionData
    {
      get => this.extensionDataField;
      set => this.extensionDataField = value;
    }

    [DataMember(EmitDefaultValue = false)]
    public string Line1
    {
      get => this.Line1Field;
      set
      {
        if (object.ReferenceEquals((object) this.Line1Field, (object) value))
          return;
        this.Line1Field = value;
        this.RaisePropertyChanged(nameof (Line1));
      }
    }

    [DataMember(EmitDefaultValue = false)]
    public string Line2
    {
      get => this.Line2Field;
      set
      {
        if (object.ReferenceEquals((object) this.Line2Field, (object) value))
          return;
        this.Line2Field = value;
        this.RaisePropertyChanged(nameof (Line2));
      }
    }

    [DataMember(EmitDefaultValue = false)]
    public string Line3
    {
      get => this.Line3Field;
      set
      {
        if (object.ReferenceEquals((object) this.Line3Field, (object) value))
          return;
        this.Line3Field = value;
        this.RaisePropertyChanged(nameof (Line3));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 3)]
    public string City
    {
      get => this.CityField;
      set
      {
        if (object.ReferenceEquals((object) this.CityField, (object) value))
          return;
        this.CityField = value;
        this.RaisePropertyChanged(nameof (City));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 4)]
    public string Country
    {
      get => this.CountryField;
      set
      {
        if (object.ReferenceEquals((object) this.CountryField, (object) value))
          return;
        this.CountryField = value;
        this.RaisePropertyChanged(nameof (Country));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 5)]
    public string PostCost
    {
      get => this.PostCostField;
      set
      {
        if (object.ReferenceEquals((object) this.PostCostField, (object) value))
          return;
        this.PostCostField = value;
        this.RaisePropertyChanged(nameof (PostCost));
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
