
// Type: SAP2012.Ventilation2012




using System;
using System.ComponentModel;

namespace SAP2012
{
  [TypeConverter(typeof (ExpandableObjectConverter))]
  public class Ventilation2012
  {
    private double _Box6a;
    private double _Box6b;
    private double _Box7a;
    private double _Box7b;
    private double _Box7c;
    private double _Box8;
    private double _Box9;
    private double _Box10;
    private double _Box11;
    private double _Box12;
    private double _Box13;
    private double _Box14;
    private double _Box15;
    private double _Box16;
    private double _Box17;
    private double _Box18;
    private double _Box19;
    private double _Box20;
    private double _Box21;
    private Months _Box22m;
    private double _Box22;
    private Months _Box22am;
    private double _Box22a;
    private Months _Box22bm;
    private double _Box22b;
    private double _Box23a;
    private double _Box23b;
    private double _Box23c;
    private Months _Box24am;
    private Months _Box24bm;
    private Months _Box24cm;
    private Months _Box24dm;
    private Months _Box25m;

    public Ventilation2012()
    {
      this._Box22m = new Months();
      this._Box22am = new Months();
      this._Box22bm = new Months();
      this._Box24am = new Months();
      this._Box24bm = new Months();
      this._Box24cm = new Months();
      this._Box24dm = new Months();
      this._Box25m = new Months();
    }

    public override string ToString() => "2. Ventilation rate";

    [Description("Infiltration due to chimneys")]
    [ReadOnly(true)]
    public double Box6a
    {
      get => !SAP_Module.CalcRound ? this._Box6a : Math.Round(this._Box6a, SAP_Module.RoundFigure);
      set => this._Box6a = value;
    }

    [Description("Infiltration due to flues")]
    [ReadOnly(true)]
    public double Box6b
    {
      get => !SAP_Module.CalcRound ? this._Box6b : Math.Round(this._Box6b, SAP_Module.RoundFigure);
      set => this._Box6b = value;
    }

    [Description("Infiltration due to intermittant fans")]
    [ReadOnly(true)]
    public double Box7a
    {
      get => !SAP_Module.CalcRound ? this._Box7a : Math.Round(this._Box7a, SAP_Module.RoundFigure);
      set => this._Box7a = value;
    }

    [Description("Infiltration due to passive vents")]
    [ReadOnly(true)]
    public double Box7b
    {
      get => !SAP_Module.CalcRound ? this._Box7b : Math.Round(this._Box7b, SAP_Module.RoundFigure);
      set => this._Box7b = value;
    }

    [Description("Infiltration due to flueless gas fires")]
    [ReadOnly(true)]
    public double Box7c
    {
      get => !SAP_Module.CalcRound ? this._Box7c : Math.Round(this._Box7c, SAP_Module.RoundFigure);
      set => this._Box7c = value;
    }

    [Description("Infiltration due to chimneys, flues and fans")]
    [ReadOnly(true)]
    public double Box8
    {
      get => !SAP_Module.CalcRound ? this._Box8 : Math.Round(this._Box8, SAP_Module.RoundFigure);
      set => this._Box8 = value;
    }

    [Description("Number of storeys in the dwelling")]
    [ReadOnly(true)]
    public double Box9
    {
      get => !SAP_Module.CalcRound ? this._Box9 : Math.Round(this._Box9, SAP_Module.RoundFigure);
      set => this._Box9 = value;
    }

    [Description("Additional infiltration")]
    [ReadOnly(true)]
    public double Box10
    {
      get => !SAP_Module.CalcRound ? this._Box10 : Math.Round(this._Box10, SAP_Module.RoundFigure);
      set => this._Box10 = value;
    }

    [Description("Structural infiltration")]
    [ReadOnly(true)]
    public double Box11
    {
      get => !SAP_Module.CalcRound ? this._Box11 : Math.Round(this._Box11, SAP_Module.RoundFigure);
      set => this._Box11 = value;
    }

    [Description("Box 12 Value")]
    [ReadOnly(true)]
    public double Box12
    {
      get => !SAP_Module.CalcRound ? this._Box12 : Math.Round(this._Box12, SAP_Module.RoundFigure);
      set => this._Box12 = value;
    }

    [Description("Box 13 Value")]
    [ReadOnly(true)]
    public double Box13
    {
      get => !SAP_Module.CalcRound ? this._Box13 : Math.Round(this._Box13, SAP_Module.RoundFigure);
      set => this._Box13 = value;
    }

    [Description("Percentage of windows and doors draught stripped")]
    [ReadOnly(true)]
    public double Box14
    {
      get => !SAP_Module.CalcRound ? this._Box14 : Math.Round(this._Box14, SAP_Module.RoundFigure);
      set => this._Box14 = value;
    }

    [Description("Window infiltration")]
    [ReadOnly(true)]
    public double Box15
    {
      get => !SAP_Module.CalcRound ? this._Box15 : Math.Round(this._Box15, SAP_Module.RoundFigure);
      set => this._Box15 = value;
    }

    [Description("Infiltration rate")]
    [ReadOnly(true)]
    public double Box16
    {
      get => !SAP_Module.CalcRound ? this._Box16 : Math.Round(this._Box16, SAP_Module.RoundFigure);
      set => this._Box16 = value;
    }

    [Description("Air permeability value,")]
    [ReadOnly(true)]
    public double Box17
    {
      get => !SAP_Module.CalcRound ? this._Box17 : Math.Round(this._Box17, SAP_Module.RoundFigure);
      set => this._Box17 = value;
    }

    [Description("Box 18 Value")]
    [ReadOnly(true)]
    public double Box18
    {
      get => !SAP_Module.CalcRound ? this._Box18 : Math.Round(this._Box18, SAP_Module.RoundFigure);
      set => this._Box18 = value;
    }

    [Description("Number of sides on which dwelling is sheltered")]
    [ReadOnly(true)]
    public double Box19
    {
      get => !SAP_Module.CalcRound ? this._Box19 : Math.Round(this._Box19, SAP_Module.RoundFigure);
      set => this._Box19 = value;
    }

    [Description("Shelter factor")]
    [ReadOnly(true)]
    public double Box20
    {
      get => !SAP_Module.CalcRound ? this._Box20 : Math.Round(this._Box20, SAP_Module.RoundFigure);
      set => this._Box20 = value;
    }

    [Description("Infiltration rate incorporating shelter factor")]
    [ReadOnly(true)]
    public double Box21
    {
      get => !SAP_Module.CalcRound ? this._Box21 : Math.Round(this._Box21, SAP_Module.RoundFigure);
      set => this._Box21 = value;
    }

    public Months Box22_m => this._Box22m;

    [Description("Monthly average wind")]
    [ReadOnly(true)]
    public double Box22
    {
      get => !SAP_Module.CalcRound ? this._Box22 : Math.Round(this._Box22, SAP_Module.RoundFigure);
      set => this._Box22 = value;
    }

    public Months Box22a_m => this._Box22am;

    [Description("Wind Factor")]
    [ReadOnly(true)]
    public double Box22a
    {
      get => !SAP_Module.CalcRound ? this._Box22a : Math.Round(this._Box22a, SAP_Module.RoundFigure);
      set => this._Box22a = value;
    }

    public Months Box22b_m => this._Box22bm;

    [Description("Infiltration rate incorporating shelter factor")]
    [ReadOnly(true)]
    public double Box22b
    {
      get => !SAP_Module.CalcRound ? this._Box22b : Math.Round(this._Box22b, SAP_Module.RoundFigure);
      set => this._Box22b = value;
    }

    [Description("If mechanical ventilation")]
    [ReadOnly(true)]
    public double Box23a
    {
      get => !SAP_Module.CalcRound ? this._Box23a : Math.Round(this._Box23a, SAP_Module.RoundFigure);
      set => this._Box23a = value;
    }

    [Description("If exhaust air heat pump")]
    [ReadOnly(true)]
    public double Box23b
    {
      get => !SAP_Module.CalcRound ? this._Box23b : Math.Round(this._Box23b, SAP_Module.RoundFigure);
      set => this._Box23b = value;
    }

    [Description("If balanced with heat recovery")]
    [ReadOnly(true)]
    public double Box23c
    {
      get => !SAP_Module.CalcRound ? this._Box23c : Math.Round(this._Box23c, SAP_Module.RoundFigure);
      set => this._Box23c = value;
    }

    public Months Box24a_m => this._Box24am;

    public Months Box24b_m => this._Box24bm;

    public Months Box24c_m => this._Box24cm;

    public Months Box24d_m => this._Box24dm;

    public Months Box25_m => this._Box25m;
  }
}
