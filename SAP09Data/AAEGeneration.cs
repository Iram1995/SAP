
// Type: SAP2012.SAP09Data.AAEGeneration




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace SAP2012.SAP09Data
{
  [DebuggerStepThrough]
  [GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
  [DataContract(Name = "AAEGeneration", Namespace = "http://rdsap2009.stroma.com/SAPData/SAP09Compliance.asmx")]
  [Serializable]
  public class AAEGeneration : IExtensibleDataObject, INotifyPropertyChanged
  {
    [NonSerialized]
    private ExtensionDataObject extensionDataField;
    private bool InlcudeField;
    private float EGeneratedField;
    [OptionalField]
    private string TotalAreaField;

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

    [DataMember(IsRequired = true, Order = 1)]
    public float EGenerated
    {
      get => this.EGeneratedField;
      set
      {
        if (this.EGeneratedField.Equals(value))
          return;
        this.EGeneratedField = value;
        this.RaisePropertyChanged(nameof (EGenerated));
      }
    }

    [DataMember(EmitDefaultValue = false, Order = 2)]
    public string TotalArea
    {
      get => this.TotalAreaField;
      set
      {
        if (object.ReferenceEquals((object) this.TotalAreaField, (object) value))
          return;
        this.TotalAreaField = value;
        this.RaisePropertyChanged(nameof (TotalArea));
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
