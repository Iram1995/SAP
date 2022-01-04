
// Type: SAP2012.AppendixP




using System;
using System.ComponentModel;

namespace SAP2012
{
  [TypeConverter(typeof (ExpandableObjectConverter))]
  public class AppendixP
  {
    private double _P1;
    private double _P2;
    private Months _P3;
    private Months _P4;
    private Months _P5;
    private Months _P6;
    private Months _P7;
    private Months _P8;
    private string _LikelihoodJune;
    private string _LikelihoodJuly;
    private string _LikelihoodAug;
    private string _Likelihood;

    public AppendixP()
    {
      this._P3 = new Months();
      this._P4 = new Months();
      this._P5 = new Months();
      this._P6 = new Months();
      this._P7 = new Months();
      this._P8 = new Months();
    }

    public override string ToString() => "Overheating Calculation";

    [Description("Ventilation heat loss, Hvsummer")]
    [ReadOnly(true)]
    public double P1
    {
      get => !SAP_Module.CalcRound ? this._P1 : Math.Round(this._P1, 2);
      set => this._P1 = value;
    }

    [Description("Heat loss coefficient")]
    [ReadOnly(true)]
    public double P2
    {
      get => !SAP_Module.CalcRound ? this._P2 : Math.Round(this._P2, 2);
      set => this._P2 = value;
    }

    [Description("Total solar gains for summer period Gsummer/solar")]
    [ReadOnly(true)]
    public Months P3 => this._P3;

    [Description("Total solar gains for summer period Gsummer/solar")]
    [ReadOnly(true)]
    public Months P4 => this._P4;

    [Description("Ventilation heat loss, Hvsummer")]
    [ReadOnly(true)]
    public Months P5 => this._P5;

    [Description("Summer gain/Loss ratio")]
    [ReadOnly(true)]
    public Months P6 => this._P6;

    [Description("Threshold internal temperature")]
    [ReadOnly(true)]
    public Months P7 => this._P7;

    [Description("Likelihood of high internal temperature during June")]
    [ReadOnly(true)]
    public string Likelihood_June
    {
      get => this._LikelihoodJune;
      set => this._LikelihoodJune = value;
    }

    [Description("Likelihood of high internal temperature during July")]
    [ReadOnly(true)]
    public string Likelihood_July
    {
      get => this._LikelihoodJuly;
      set => this._LikelihoodJuly = value;
    }

    [Description("Likelihood of high internal temperature during August")]
    [ReadOnly(true)]
    public string Likelihood_Aug
    {
      get => this._LikelihoodAug;
      set => this._LikelihoodAug = value;
    }

    [Description("Likelihood of high internal temperature during hot weather")]
    [ReadOnly(true)]
    public string Likelihood
    {
      get => this._Likelihood;
      set => this._Likelihood = value;
    }
  }
}
