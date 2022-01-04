
// Type: SAP2012.AppendixF_Items




using System;
using System.ComponentModel;

namespace SAP2012
{
  [TypeConverter(typeof (ExpandableObjectConverter))]
  public class AppendixF_Items
  {
    private double _Cmax;
    private Months _Tmin;
    private Months _Eon_peak;
    private Months _Fhigh;
    private Months _Flow;

    public AppendixF_Items()
    {
      this._Tmin = new Months();
      this._Eon_peak = new Months();
      this._Fhigh = new Months();
      this._Flow = new Months();
    }

    public override string ToString() => "AppendixF Items";

    [Description("")]
    [ReadOnly(true)]
    public double Cmax
    {
      get => !SAP_Module.CalcRound ? this._Cmax : Math.Round(this._Cmax, SAP_Module.RoundFigure);
      set => this._Cmax = value;
    }

    [ReadOnly(true)]
    public Months Tmin => this._Tmin;

    [ReadOnly(true)]
    public Months Eon_peak => this._Eon_peak;

    [ReadOnly(true)]
    public Months Fhigh => this._Fhigh;

    [ReadOnly(true)]
    public Months Flow => this._Flow;
  }
}
