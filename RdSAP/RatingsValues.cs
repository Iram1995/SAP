
// Type: SAP2012.RdSAP.RatingsValues




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace SAP2012.RdSAP
{
  [DebuggerStepThrough]
  [GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
  [DataContract(Name = "RatingsValues", Namespace = "http://schemas.datacontract.org/2004/07/StromaServices")]
  [Serializable]
  public class RatingsValues : IExtensibleDataObject, INotifyPropertyChanged
  {
    [NonSerialized]
    private ExtensionDataObject extensionDataField;
    [OptionalField]
    private int EEnRatingField;
    [OptionalField]
    private int ESAPRatingField;
    [OptionalField]
    private int EnRatingField;
    [OptionalField]
    private string EnergyUseField;
    [OptionalField]
    private string EnergyUsepotentialField;
    [OptionalField]
    private string HeatingCurrentField;
    [OptionalField]
    private string HeatingPotentialField;
    [OptionalField]
    private string HotWaterCurrentField;
    [OptionalField]
    private string HotWaterPotentialField;
    [OptionalField]
    private int PEnRatingField;
    [OptionalField]
    private int PSAPRatingField;
    [OptionalField]
    private int SAPRatingField;
    [OptionalField]
    private string co2currentField;
    [OptionalField]
    private string co2potentialField;
    [OptionalField]
    private string lightingCurrentField;
    [OptionalField]
    private string lightingpotentialField;

    [Browsable(false)]
    public ExtensionDataObject ExtensionData
    {
      get => this.extensionDataField;
      set => this.extensionDataField = value;
    }

    [DataMember]
    public int EEnRating
    {
      get => this.EEnRatingField;
      set
      {
        if (this.EEnRatingField.Equals(value))
          return;
        this.EEnRatingField = value;
        this.RaisePropertyChanged(nameof (EEnRating));
      }
    }

    [DataMember]
    public int ESAPRating
    {
      get => this.ESAPRatingField;
      set
      {
        if (this.ESAPRatingField.Equals(value))
          return;
        this.ESAPRatingField = value;
        this.RaisePropertyChanged(nameof (ESAPRating));
      }
    }

    [DataMember]
    public int EnRating
    {
      get => this.EnRatingField;
      set
      {
        if (this.EnRatingField.Equals(value))
          return;
        this.EnRatingField = value;
        this.RaisePropertyChanged(nameof (EnRating));
      }
    }

    [DataMember]
    public string EnergyUse
    {
      get => this.EnergyUseField;
      set
      {
        if (object.ReferenceEquals((object) this.EnergyUseField, (object) value))
          return;
        this.EnergyUseField = value;
        this.RaisePropertyChanged(nameof (EnergyUse));
      }
    }

    [DataMember]
    public string EnergyUsepotential
    {
      get => this.EnergyUsepotentialField;
      set
      {
        if (object.ReferenceEquals((object) this.EnergyUsepotentialField, (object) value))
          return;
        this.EnergyUsepotentialField = value;
        this.RaisePropertyChanged(nameof (EnergyUsepotential));
      }
    }

    [DataMember]
    public string HeatingCurrent
    {
      get => this.HeatingCurrentField;
      set
      {
        if (object.ReferenceEquals((object) this.HeatingCurrentField, (object) value))
          return;
        this.HeatingCurrentField = value;
        this.RaisePropertyChanged(nameof (HeatingCurrent));
      }
    }

    [DataMember]
    public string HeatingPotential
    {
      get => this.HeatingPotentialField;
      set
      {
        if (object.ReferenceEquals((object) this.HeatingPotentialField, (object) value))
          return;
        this.HeatingPotentialField = value;
        this.RaisePropertyChanged(nameof (HeatingPotential));
      }
    }

    [DataMember]
    public string HotWaterCurrent
    {
      get => this.HotWaterCurrentField;
      set
      {
        if (object.ReferenceEquals((object) this.HotWaterCurrentField, (object) value))
          return;
        this.HotWaterCurrentField = value;
        this.RaisePropertyChanged(nameof (HotWaterCurrent));
      }
    }

    [DataMember]
    public string HotWaterPotential
    {
      get => this.HotWaterPotentialField;
      set
      {
        if (object.ReferenceEquals((object) this.HotWaterPotentialField, (object) value))
          return;
        this.HotWaterPotentialField = value;
        this.RaisePropertyChanged(nameof (HotWaterPotential));
      }
    }

    [DataMember]
    public int PEnRating
    {
      get => this.PEnRatingField;
      set
      {
        if (this.PEnRatingField.Equals(value))
          return;
        this.PEnRatingField = value;
        this.RaisePropertyChanged(nameof (PEnRating));
      }
    }

    [DataMember]
    public int PSAPRating
    {
      get => this.PSAPRatingField;
      set
      {
        if (this.PSAPRatingField.Equals(value))
          return;
        this.PSAPRatingField = value;
        this.RaisePropertyChanged(nameof (PSAPRating));
      }
    }

    [DataMember]
    public int SAPRating
    {
      get => this.SAPRatingField;
      set
      {
        if (this.SAPRatingField.Equals(value))
          return;
        this.SAPRatingField = value;
        this.RaisePropertyChanged(nameof (SAPRating));
      }
    }

    [DataMember]
    public string co2current
    {
      get => this.co2currentField;
      set
      {
        if (object.ReferenceEquals((object) this.co2currentField, (object) value))
          return;
        this.co2currentField = value;
        this.RaisePropertyChanged(nameof (co2current));
      }
    }

    [DataMember]
    public string co2potential
    {
      get => this.co2potentialField;
      set
      {
        if (object.ReferenceEquals((object) this.co2potentialField, (object) value))
          return;
        this.co2potentialField = value;
        this.RaisePropertyChanged(nameof (co2potential));
      }
    }

    [DataMember]
    public string lightingCurrent
    {
      get => this.lightingCurrentField;
      set
      {
        if (object.ReferenceEquals((object) this.lightingCurrentField, (object) value))
          return;
        this.lightingCurrentField = value;
        this.RaisePropertyChanged(nameof (lightingCurrent));
      }
    }

    [DataMember]
    public string lightingpotential
    {
      get => this.lightingpotentialField;
      set
      {
        if (object.ReferenceEquals((object) this.lightingpotentialField, (object) value))
          return;
        this.lightingpotentialField = value;
        this.RaisePropertyChanged(nameof (lightingpotential));
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
