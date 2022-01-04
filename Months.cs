
// Type: SAP2012.Months




using System;
using System.ComponentModel;

namespace SAP2012
{
  [TypeConverter(typeof (ExpandableObjectConverter))]
  public class Months
  {
    private double _1;
    private double _2;
    private double _3;
    private double _4;
    private double _5;
    private double _6;
    private double _7;
    private double _8;
    private double _9;
    private double _10;
    private double _11;
    private double _12;

    public override string ToString() => nameof (Months);

    [Description("January")]
    [ReadOnly(true)]
    public double M1
    {
      get => !SAP_Module.CalcRound ? this._1 : Math.Round(this._1, SAP_Module.RoundFigure);
      set => this._1 = value;
    }

    [Description("February")]
    [ReadOnly(true)]
    public double M2
    {
      get => !SAP_Module.CalcRound ? this._2 : Math.Round(this._2, SAP_Module.RoundFigure);
      set => this._2 = value;
    }

    [Description("March")]
    [ReadOnly(true)]
    public double M3
    {
      get => !SAP_Module.CalcRound ? this._3 : Math.Round(this._3, SAP_Module.RoundFigure);
      set => this._3 = value;
    }

    [Description("April")]
    [ReadOnly(true)]
    public double M4
    {
      get => !SAP_Module.CalcRound ? this._4 : Math.Round(this._4, SAP_Module.RoundFigure);
      set => this._4 = value;
    }

    [Description("May")]
    [ReadOnly(true)]
    public double M5
    {
      get => !SAP_Module.CalcRound ? this._5 : Math.Round(this._5, SAP_Module.RoundFigure);
      set => this._5 = value;
    }

    [Description("June")]
    [ReadOnly(true)]
    public double M6
    {
      get => !SAP_Module.CalcRound ? this._6 : Math.Round(this._6, SAP_Module.RoundFigure);
      set => this._6 = value;
    }

    [Description("July")]
    [ReadOnly(true)]
    public double M7
    {
      get => !SAP_Module.CalcRound ? this._7 : Math.Round(this._7, SAP_Module.RoundFigure);
      set => this._7 = value;
    }

    [Description("Aug")]
    [ReadOnly(true)]
    public double M8
    {
      get => !SAP_Module.CalcRound ? this._8 : Math.Round(this._8, SAP_Module.RoundFigure);
      set => this._8 = value;
    }

    [Description("Sept")]
    [ReadOnly(true)]
    public double M9
    {
      get => !SAP_Module.CalcRound ? this._9 : Math.Round(this._9, SAP_Module.RoundFigure);
      set => this._9 = value;
    }

    [Description("Oct")]
    [ReadOnly(true)]
    public double M10
    {
      get => !SAP_Module.CalcRound ? this._10 : Math.Round(this._10, SAP_Module.RoundFigure);
      set => this._10 = value;
    }

    [Description("Nov")]
    [ReadOnly(true)]
    public double M11
    {
      get => !SAP_Module.CalcRound ? this._11 : Math.Round(this._11, SAP_Module.RoundFigure);
      set => this._11 = value;
    }

    [Description("Dec")]
    [ReadOnly(true)]
    public double M12
    {
      get => !SAP_Module.CalcRound ? this._12 : Math.Round(this._12, SAP_Module.RoundFigure);
      set => this._12 = value;
    }
  }
}
