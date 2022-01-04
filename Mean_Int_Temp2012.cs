
// Type: SAP2012.Mean_Int_Temp2012




using System;
using System.ComponentModel;

namespace SAP2012
{
  [TypeConverter(typeof (ExpandableObjectConverter))]
  public class Mean_Int_Temp2012
  {
    private double _Box85;
    private Months _Box86m;
    private Months _Box87m;
    private Months _Box88m;
    private Months _Box89m;
    private Months _Box90m;
    private double _Box91;
    private Months _Box92m;
    private Months _Box93m;
    private Months _Box93am;
    private double _Box93b;
    private Months _Box93cm;

    public Mean_Int_Temp2012()
    {
      this._Box86m = new Months();
      this._Box87m = new Months();
      this._Box88m = new Months();
      this._Box89m = new Months();
      this._Box90m = new Months();
      this._Box92m = new Months();
      this._Box93m = new Months();
      this._Box93am = new Months();
      this._Box93b = new double();
      this._Box93cm = new Months();
    }

    public override string ToString() => "7. Mean internal temperature (heating season)";

    [Description("Temperature during heating periods in the living area from Table 9")]
    [ReadOnly(true)]
    public double Box85
    {
      get => !SAP_Module.CalcRound ? this._Box85 : Math.Round(this._Box85, SAP_Module.RoundFigure);
      set => this._Box85 = value;
    }

    [ReadOnly(true)]
    public Months Box86_m => this._Box86m;

    [ReadOnly(true)]
    public Months Box87_m => this._Box87m;

    [ReadOnly(true)]
    public Months Box88_m => this._Box88m;

    [ReadOnly(true)]
    public Months Box89_m => this._Box89m;

    [ReadOnly(true)]
    public Months Box90_m => this._Box90m;

    [Description("Living area fraction")]
    [ReadOnly(true)]
    public double Box91
    {
      get => !SAP_Module.CalcRound ? this._Box91 : Math.Round(this._Box91, SAP_Module.RoundFigure);
      set => this._Box91 = value;
    }

    [ReadOnly(true)]
    public Months Box92_m => this._Box92m;

    [ReadOnly(true)]
    public Months Box93_m => this._Box93m;

    [ReadOnly(true)]
    public Months Box93a_m => this._Box93am;

    [ReadOnly(true)]
    public double Box93b
    {
      get => this._Box93b;
      set => this._Box93b = value;
    }

    [ReadOnly(true)]
    public Months Box93c_m => this._Box93cm;
  }
}
