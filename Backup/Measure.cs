
// Type: SAP2012.Measure




using System;
using System.ComponentModel;

namespace SAP2012
{
  [TypeConverter(typeof (ExpandableObjectConverter))]
  public class Measure
  {
    private bool _Include;
    private bool _Already;
    private bool _NotApplicable;
    private double _SAPChange;
    private double _CostChange;
    private double _CostChangeOA;
    private double _CO2Change;
    private string _Energy;
    private string _Environ;
    private int _RecNumber;
    private bool _Cancelled;
    private bool _Superseded;
    private bool _TooSmallEffect;
    private Green_Deal _GreenDeal;
    private float _InUse;
    private float _InUseOA;
    private float _MinSAP;
    private int _Catagory;

    public Measure() => this._GreenDeal = new Green_Deal();

    public override string ToString() => nameof (Measure);

    public string Description { get; set; }

    public float InUse
    {
      get => this._InUse;
      set => this._InUse = value;
    }

    public float InUseOA
    {
      get => this._InUseOA;
      set => this._InUseOA = value;
    }

    public float MinSAP
    {
      get => this._MinSAP;
      set => this._MinSAP = value;
    }

    public Green_Deal GreenDeal
    {
      get => this._GreenDeal;
      set => this._GreenDeal = value;
    }

    public bool Superseded
    {
      get => this._Superseded;
      set => this._Superseded = value;
    }

    public bool TooSmallEffect
    {
      get => this._TooSmallEffect;
      set => this._TooSmallEffect = value;
    }

    public bool Include
    {
      get => this._Include;
      set => this._Include = value;
    }

    public bool Cancelled
    {
      get => this._Cancelled;
      set => this._Cancelled = value;
    }

    public int RecNumber
    {
      get => this._RecNumber;
      set => this._RecNumber = value;
    }

    public bool Already
    {
      get => this._Already;
      set => this._Already = value;
    }

    public bool NotApplicable
    {
      get => this._NotApplicable;
      set => this._NotApplicable = value;
    }

    public double SAPChange
    {
      get => Math.Round(this._SAPChange, 1);
      set => this._SAPChange = value;
    }

    public double CostChange
    {
      get => this._CostChange;
      set => this._CostChange = value;
    }

    public double CostChangeOA
    {
      get => this._CostChangeOA;
      set => this._CostChangeOA = value;
    }

    public double CO2Change
    {
      get => Math.Round(this._CO2Change);
      set => this._CO2Change = value;
    }

    public double EnergyChange { get; set; }

    public string Energy
    {
      get => this._Energy;
      set => this._Energy = value;
    }

    public string Environ
    {
      get => this._Environ;
      set => this._Environ = value;
    }

    public int Catagory
    {
      get => this._Catagory;
      set => this._Catagory = value;
    }
  }
}
