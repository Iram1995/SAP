
// Type: SAP2012.SAPRef.SelectionClass




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace SAP2012.SAPRef
{
  [DebuggerStepThrough]
  [GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
  [DataContract(Name = "SelectionClass", Namespace = "https://www.stromamembers.co.uk/sap.asmx")]
  [Serializable]
  public class SelectionClass : IExtensibleDataObject, INotifyPropertyChanged
  {
    [NonSerialized]
    private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
    private CountryType CountryField;
    private EnviornmentType EnvironmentField;
    private AssessmentType AssessmentField;
    private languageType languageField;

    [Browsable(false)]
    public System.Runtime.Serialization.ExtensionDataObject ExtensionData
    {
      get => this.extensionDataField;
      set => this.extensionDataField = value;
    }

    [DataMember(IsRequired = true)]
    public CountryType Country
    {
      get => this.CountryField;
      set
      {
        if (this.CountryField.Equals((object) value))
          return;
        this.CountryField = value;
        this.RaisePropertyChanged(nameof (Country));
      }
    }

    [DataMember(IsRequired = true)]
    public EnviornmentType Environment
    {
      get => this.EnvironmentField;
      set
      {
        if (this.EnvironmentField.Equals((object) value))
          return;
        this.EnvironmentField = value;
        this.RaisePropertyChanged(nameof (Environment));
      }
    }

    [DataMember(IsRequired = true, Order = 2)]
    public AssessmentType Assessment
    {
      get => this.AssessmentField;
      set
      {
        if (this.AssessmentField.Equals((object) value))
          return;
        this.AssessmentField = value;
        this.RaisePropertyChanged(nameof (Assessment));
      }
    }

    [DataMember(IsRequired = true, Order = 3)]
    public languageType language
    {
      get => this.languageField;
      set
      {
        if (this.languageField.Equals((object) value))
          return;
        this.languageField = value;
        this.RaisePropertyChanged(nameof (language));
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
