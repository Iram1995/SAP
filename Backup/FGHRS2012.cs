
// Type: SAP2012.FGHRS2012




using System;
using System.ComponentModel;

namespace SAP2012
{
  [TypeConverter(typeof (ExpandableObjectConverter))]
  public class FGHRS2012
  {
    private bool _HasStore;
    private double _StoreVolume;
    private double _Kf1;
    private double _Kf2;
    private Months _Qsp_m;
    private Months _Qhw_m;
    private Months _Qsp1_m;
    private Months _Qsp2_m;
    private Months _aLow;
    private Months _bLow;
    private Months _cLow;
    private Months _aUpp;
    private Months _bUpp;
    private Months _cUpp;
    private Months _SavingsLower_m;
    private Months _SavingsUpper_m;
    private Months _S0_m;
    private Months _Sm;
    private double _Vk;
    private double _Kn;
    private FGHRS_Solar_Input _PhotoVoltaic;

    public FGHRS2012()
    {
      this._Qsp_m = new Months();
      this._Qhw_m = new Months();
      this._Qsp1_m = new Months();
      this._Qsp2_m = new Months();
      this._aLow = new Months();
      this._bLow = new Months();
      this._cLow = new Months();
      this._aUpp = new Months();
      this._bUpp = new Months();
      this._cUpp = new Months();
      this._SavingsLower_m = new Months();
      this._SavingsUpper_m = new Months();
      this._S0_m = new Months();
      this._Sm = new Months();
      this._PhotoVoltaic = new FGHRS_Solar_Input();
    }

    public override string ToString() => "Calculation of FGHRS Details";

    public bool HasStore
    {
      get => this._HasStore;
      set => this._HasStore = value;
    }

    public double StoreVolume
    {
      get => !SAP_Module.CalcRound ? this._StoreVolume : Math.Round(this._StoreVolume, SAP_Module.RoundFigure);
      set => this._StoreVolume = value;
    }

    public double Kf1
    {
      get => !SAP_Module.CalcRound ? this._Kf1 : Math.Round(this._Kf1, SAP_Module.RoundFigure);
      set => this._Kf1 = value;
    }

    public double Kf2
    {
      get => !SAP_Module.CalcRound ? this._Kf2 : Math.Round(this._Kf2, SAP_Module.RoundFigure);
      set => this._Kf2 = value;
    }

    [ReadOnly(true)]
    public Months Qsp_m => this._Qsp_m;

    [ReadOnly(true)]
    public Months Qhw_m => this._Qhw_m;

    [ReadOnly(true)]
    public Months Qsp1_m => this._Qsp1_m;

    [ReadOnly(true)]
    public Months Qsp2_m => this._Qsp2_m;

    [ReadOnly(true)]
    public Months aLow => this._aLow;

    [ReadOnly(true)]
    public Months bLow => this._bLow;

    [ReadOnly(true)]
    public Months cLow => this._cLow;

    [ReadOnly(true)]
    public Months aUpp => this._aUpp;

    [ReadOnly(true)]
    public Months bUpp => this._bUpp;

    [ReadOnly(true)]
    public Months cUpp => this._cUpp;

    [ReadOnly(true)]
    public Months SavingsLower_m => this._SavingsLower_m;

    [ReadOnly(true)]
    public Months SavingsUpper_m => this._SavingsUpper_m;

    [ReadOnly(true)]
    public Months S0_m => this._S0_m;

    [ReadOnly(true)]
    public Months Sm => this._Sm;

    [Description("")]
    [ReadOnly(true)]
    public double Vk
    {
      get => !SAP_Module.CalcRound ? this._Vk : Math.Round(this._Vk, SAP_Module.RoundFigure);
      set => this._Vk = value;
    }

    [Description("")]
    [ReadOnly(true)]
    public double Kn
    {
      get => !SAP_Module.CalcRound ? this._Kn : Math.Round(this._Kn, SAP_Module.RoundFigure);
      set => this._Kn = value;
    }

    [ReadOnly(true)]
    public FGHRS_Solar_Input Photo_Solar_Input => this._PhotoVoltaic;
  }
}
