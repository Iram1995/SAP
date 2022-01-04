
// Type: SAP2012.Space_cooling_requirement2012




using System;
using System.ComponentModel;

namespace SAP2012
{
  [TypeConverter(typeof (ExpandableObjectConverter))]
  public class Space_cooling_requirement2012
  {
    private Months _Box100m;
    private Months _Box101m;
    private Months _Box102m;
    private Months _Box103m;
    private Months _Box104m;
    private double _Box104;
    private double _Box105;
    private Months _Box106m;
    private double _Box106;
    private Months _Box107m;
    private double _Box107;
    private double _Box108;

    public Space_cooling_requirement2012()
    {
      this._Box100m = new Months();
      this._Box101m = new Months();
      this._Box102m = new Months();
      this._Box103m = new Months();
      this._Box104m = new Months();
      this._Box106m = new Months();
      this._Box107m = new Months();
    }

    public override string ToString() => "8c. Space cooling requirement";

    [ReadOnly(true)]
    public Months Box100_m => this._Box100m;

    [ReadOnly(true)]
    public Months Box101_m => this._Box101m;

    [ReadOnly(true)]
    public Months Box102_m => this._Box102m;

    [ReadOnly(true)]
    public Months Box103_m => this._Box103m;

    [ReadOnly(true)]
    public Months Box104_m => this._Box104m;

    [Description("Space cooling requirement")]
    [ReadOnly(true)]
    public double Box104
    {
      get => !SAP_Module.CalcRound ? this._Box104 : Math.Round(this._Box104, SAP_Module.RoundFigure);
      set => this._Box104 = value;
    }

    [Description("Cooled fraction")]
    [ReadOnly(true)]
    public double Box105
    {
      get => !SAP_Module.CalcRound ? this._Box105 : Math.Round(this._Box105, SAP_Module.RoundFigure);
      set => this._Box105 = value;
    }

    [ReadOnly(true)]
    public Months Box106_m => this._Box106m;

    [Description("Intermittency factor")]
    [ReadOnly(true)]
    public double Box106
    {
      get => !SAP_Module.CalcRound ? this._Box106 : Math.Round(this._Box106, SAP_Module.RoundFigure);
      set => this._Box106 = value;
    }

    [ReadOnly(true)]
    public Months Box107_m => this._Box107m;

    [Description("Space cooling requirement")]
    [ReadOnly(true)]
    public double Box107
    {
      get => !SAP_Module.CalcRound ? this._Box107 : Math.Round(this._Box107, SAP_Module.RoundFigure);
      set => this._Box107 = value;
    }

    [Description("Space cooling requirement in kWh/m\u00B2/year")]
    [ReadOnly(true)]
    public double Box108
    {
      get => !SAP_Module.CalcRound ? this._Box108 : Math.Round(this._Box108, SAP_Module.RoundFigure);
      set => this._Box108 = value;
    }
  }
}
