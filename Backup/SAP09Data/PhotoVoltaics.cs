
// Type: SAP2012.SAP09Data.PhotoVoltaics




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace SAP2012.SAP09Data
{
  [DebuggerStepThrough]
  [GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
  [DataContract(Name = "PhotoVoltaics", Namespace = "http://rdsap2009.stroma.com/SAPData/SAP09Compliance.asmx")]
  [Serializable]
  public class PhotoVoltaics : IExtensibleDataObject, INotifyPropertyChanged
  {
    [NonSerialized]
    private ExtensionDataObject extensionDataField;
    private int IDField;
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

    [DataMember(IsRequired = true)]
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

    [DataMember(EmitDefaultValue = false)]
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

    [DataMember(EmitDefaultValue = false, Order = 3)]
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

    [DataMember(EmitDefaultValue = false, Order = 4)]
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
