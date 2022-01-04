
// Type: SAP2012.Space_heating_requirement2012




using System;
using System.ComponentModel;

namespace SAP2012
{
  [TypeConverter(typeof (ExpandableObjectConverter))]
  public class Space_heating_requirement2012
  {
    private Months _Box94m;
    private Months _Box95m;
    private Months _Box96m;
    private Months _Box97m;
    private Months _Box98m;
    private double _Box98;
    private double _Box99;

    public Space_heating_requirement2012()
    {
      this._Box94m = new Months();
      this._Box95m = new Months();
      this._Box96m = new Months();
      this._Box97m = new Months();
      this._Box98m = new Months();
    }

    public override string ToString() => "8. Space heating requirement";

    [ReadOnly(true)]
    public Months Box94_m => this._Box94m;

    [ReadOnly(true)]
    public Months Box95_m => this._Box95m;

    [ReadOnly(true)]
    public Months Box96_m => this._Box96m;

    [ReadOnly(true)]
    public Months Box97_m => this._Box97m;

    [ReadOnly(true)]
    public Months Box98_m => this._Box98m;

    [Description("Space heating requirement in kWh/year")]
    [ReadOnly(true)]
    public double Box98
    {
      get => !SAP_Module.CalcRound ? this._Box98 : Math.Round(this._Box98, SAP_Module.RoundFigure);
      set => this._Box98 = value;
    }

    [Description("Space heating requirement in kWh/m\u00B2/year")]
    [ReadOnly(true)]
    public double Box99
    {
      get => !SAP_Module.CalcRound ? this._Box99 : Math.Round(this._Box99, SAP_Module.RoundFigure);
      set => this._Box99 = value;
    }
  }
}
