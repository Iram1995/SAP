
// Type: SAP2012.Solar_Water2012




using System;
using System.ComponentModel;

namespace SAP2012
{
  [TypeConverter(typeof (ExpandableObjectConverter))]
  public class Solar_Water2012
  {
    private double _H1;
    private double _H2;
    private double _H3;
    private double _H3a;
    private double _H3b;
    private double _H4;
    private double _H5;
    private double _H6;
    private double _H7;
    private double _H7a;
    private double _H8;
    private double _H9;
    private double _H10;
    private double _H11;
    private double _H12;
    private double _H13;
    private double _H14;
    private double _H15;
    private double _H16;
    private double _H17;

    public override string ToString() => "Calculation of solar input for solar water heating";

    [Description("Aperture area of solar collector, m\u00B2")]
    [ReadOnly(true)]
    public double H1
    {
      get => !SAP_Module.CalcRound ? this._H1 : Math.Round(this._H1, SAP_Module.RoundFigure);
      set => this._H1 = value;
    }

    [Description("Zero-loss collector efficiency, n0, from test certificate or Table H1")]
    [ReadOnly(true)]
    public double H2
    {
      get => !SAP_Module.CalcRound ? this._H2 : Math.Round(this._H2, SAP_Module.RoundFigure);
      set => this._H2 = value;
    }

    [Description("Collector heat loss coefficient, a1, from test certificate or Table H1")]
    [ReadOnly(true)]
    public double H3
    {
      get => !SAP_Module.CalcRound ? this._H3 : Math.Round(this._H3, SAP_Module.RoundFigure);
      set => this._H3 = value;
    }

    [Description("Collector 2nd order heat loss coefficient, a2, from test certificate")]
    [ReadOnly(true)]
    public double H3a
    {
      get => !SAP_Module.CalcRound ? this._H3a : Math.Round(this._H3a, SAP_Module.RoundFigure);
      set => this._H3a = value;
    }

    [Description("a*=0.892(a1 + 45a2) or a* fromTableH1")]
    [ReadOnly(true)]
    public double H3b
    {
      get => !SAP_Module.CalcRound ? this._H3b : Math.Round(this._H3b, SAP_Module.RoundFigure);
      set => this._H3b = value;
    }

    [Description("Collector performance ratio a1/n0")]
    [ReadOnly(true)]
    public double H4
    {
      get => !SAP_Module.CalcRound ? this._H4 : Math.Round(this._H4, SAP_Module.RoundFigure);
      set => this._H4 = value;
    }

    [Description("Annual solar radiation per m\u00B2 from Table H2")]
    [ReadOnly(true)]
    public double H5
    {
      get => !SAP_Module.CalcRound ? this._H5 : Math.Round(this._H5, SAP_Module.RoundFigure);
      set => this._H5 = value;
    }

    [Description("Overshading factor from Table H3")]
    [ReadOnly(true)]
    public double H6
    {
      get => !SAP_Module.CalcRound ? this._H6 : Math.Round(this._H6, SAP_Module.RoundFigure);
      set => this._H6 = value;
    }

    [Description("Solar energy available [(H1) x (H2) x (H5) x (H6)]")]
    [ReadOnly(true)]
    public double H7
    {
      get => !SAP_Module.CalcRound ? this._H7 : Math.Round(this._H7, SAP_Module.RoundFigure);
      set => this._H7 = value;
    }

    [Description("Solar energy available [(H1) x (H2) x (H5) x (H6)]")]
    [ReadOnly(true)]
    public double H7a
    {
      get => !SAP_Module.CalcRound ? this._H7a : Math.Round(this._H7a, SAP_Module.RoundFigure);
      set => this._H7a = value;
    }

    [Description("Solar-to-load ratio (H7) ÷ [(39) + (40)]")]
    [ReadOnly(true)]
    public double H8
    {
      get => !SAP_Module.CalcRound ? this._H8 : Math.Round(this._H8, SAP_Module.RoundFigure);
      set => this._H8 = value;
    }

    [Description("Utilisation factor")]
    [ReadOnly(true)]
    public double H9
    {
      get => !SAP_Module.CalcRound ? this._H9 : Math.Round(this._H9, SAP_Module.RoundFigure);
      set => this._H9 = value;
    }

    [Description("Collector performance factor")]
    [ReadOnly(true)]
    public double H10
    {
      get => !SAP_Module.CalcRound ? this._H10 : Math.Round(this._H10, SAP_Module.RoundFigure);
      set => this._H10 = value;
    }

    [Description("Dedicated solar storage volume,")]
    [ReadOnly(true)]
    public double H11
    {
      get => !SAP_Module.CalcRound ? this._H11 : Math.Round(this._H11, SAP_Module.RoundFigure);
      set => this._H11 = value;
    }

    [Description("If combined cylinder, total volume of cylinder, litres")]
    [ReadOnly(true)]
    public double H12
    {
      get => !SAP_Module.CalcRound ? this._H12 : Math.Round(this._H12, SAP_Module.RoundFigure);
      set => this._H12 = value;
    }

    [Description("Effective solar volume, Veff")]
    [ReadOnly(true)]
    public double H13
    {
      get => !SAP_Module.CalcRound ? this._H13 : Math.Round(this._H13, SAP_Module.RoundFigure);
      set => this._H13 = value;
    }

    [Description("Daily hot water demand, Vd, (litres) from Table 1")]
    [ReadOnly(true)]
    public double H14
    {
      get => !SAP_Module.CalcRound ? this._H14 : Math.Round(this._H14, SAP_Module.RoundFigure);
      set => this._H14 = value;
    }

    [Description("Volume ratio Veff/Vd")]
    [ReadOnly(true)]
    public double H15
    {
      get => !SAP_Module.CalcRound ? this._H15 : Math.Round(this._H15, SAP_Module.RoundFigure);
      set => this._H15 = value;
    }

    [Description("Solar storage volume factor f(Veff/Vd)")]
    [ReadOnly(true)]
    public double H16
    {
      get => !SAP_Module.CalcRound ? this._H16 : Math.Round(this._H16, SAP_Module.RoundFigure);
      set => this._H16 = value;
    }

    [Description("Solar input Qs")]
    [ReadOnly(true)]
    public double H17
    {
      get => !SAP_Module.CalcRound ? this._H17 : Math.Round(this._H17, SAP_Module.RoundFigure);
      set => this._H17 = value;
    }
  }
}
