
// Type: SAP2012.WWHRS2012




using System;
using System.ComponentModel;

namespace SAP2012
{
  [TypeConverter(typeof (ExpandableObjectConverter))]
  public class WWHRS2012
  {
    private double _Seff;
    private Months _Sm;

    public WWHRS2012() => this._Sm = new Months();

    public override string ToString() => "Calculation of WWHRS Details";

    [Description("Average System Effectiveness")]
    [ReadOnly(true)]
    public double Seff
    {
      get => !SAP_Module.CalcRound ? this._Seff : Math.Round(this._Seff, SAP_Module.RoundFigure);
      set => this._Seff = value;
    }

    [ReadOnly(true)]
    public Months Sm => this._Sm;

    [Description("")]
    [ReadOnly(true)]
    public double Sum_Sm => !SAP_Module.CalcRound ? this._Sm.M1 + this._Sm.M2 + this._Sm.M3 + this._Sm.M4 + this._Sm.M5 + this._Sm.M6 + this._Sm.M7 + this._Sm.M8 + this._Sm.M9 + this._Sm.M10 + this._Sm.M11 + this._Sm.M12 : Math.Round(this._Sm.M1 + this._Sm.M2 + this._Sm.M3 + this._Sm.M4 + this._Sm.M5 + this._Sm.M6 + this._Sm.M7 + this._Sm.M8 + this._Sm.M9 + this._Sm.M10 + this._Sm.M11 + this._Sm.M12, SAP_Module.RoundFigure);
  }
}
