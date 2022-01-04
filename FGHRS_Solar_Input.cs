
// Type: SAP2012.FGHRS_Solar_Input




using System;
using System.ComponentModel;

namespace SAP2012
{
  [TypeConverter(typeof (ExpandableObjectConverter))]
  public class FGHRS_Solar_Input
  {
    private double _G1;
    private double _G2;
    private double _G3;
    private double _G4;
    private double _G5;
    private double _G6;
    private double _G7;
    private double _G8;
    private double _G9;
    private double _G10;
    private double _G11;
    private double _G12;
    private double _G13;
    private Months _Qsm;

    public FGHRS_Solar_Input() => this._Qsm = new Months();

    public override string ToString() => "Calculation of solar input for directly-powered solar water heating for FGHRS";

    [Description("Peak power of PV array")]
    [ReadOnly(true)]
    public double G1
    {
      get => !SAP_Module.CalcRound ? this._G1 : Math.Round(this._G1, SAP_Module.RoundFigure);
      set => this._G1 = value;
    }

    [Description("Annual solar radiation per m\u00B2 from Table H2")]
    [ReadOnly(true)]
    public double G2
    {
      get => !SAP_Module.CalcRound ? this._G2 : Math.Round(this._G2, SAP_Module.RoundFigure);
      set => this._G2 = value;
    }

    [Description("Overshading factor from Table H4")]
    [ReadOnly(true)]
    public double G3
    {
      get => !SAP_Module.CalcRound ? this._G3 : Math.Round(this._G3, SAP_Module.RoundFigure);
      set => this._G3 = value;
    }

    [Description("Cable loss (provided in database record)")]
    [ReadOnly(true)]
    public double G4
    {
      get => !SAP_Module.CalcRound ? this._G4 : Math.Round(this._G4, SAP_Module.RoundFigure);
      set => this._G4 = value;
    }

    [Description("Solar energy available")]
    [ReadOnly(true)]
    public double G5
    {
      get => !SAP_Module.CalcRound ? this._G5 : Math.Round(this._G5, SAP_Module.RoundFigure);
      set => this._G5 = value;
    }

    [Description("Solar-to-load ratio")]
    [ReadOnly(true)]
    public double G6
    {
      get => !SAP_Module.CalcRound ? this._G6 : Math.Round(this._G6, SAP_Module.RoundFigure);
      set => this._G6 = value;
    }

    [Description("Utilisation factor")]
    [ReadOnly(true)]
    public double G7
    {
      get => !SAP_Module.CalcRound ? this._G7 : Math.Round(this._G7, SAP_Module.RoundFigure);
      set => this._G7 = value;
    }

    [Description("Volume of store, Vk (provided in database record)")]
    [ReadOnly(true)]
    public double G8
    {
      get => !SAP_Module.CalcRound ? this._G8 : Math.Round(this._G8, SAP_Module.RoundFigure);
      set => this._G8 = value;
    }

    [Description("Effective solar volume, Veff = 0.76 × (G8)")]
    [ReadOnly(true)]
    public double G9
    {
      get => !SAP_Module.CalcRound ? this._G9 : Math.Round(this._G9, SAP_Module.RoundFigure);
      set => this._G9 = value;
    }

    [Description("Daily hot water demand, Vd,average, (litres)")]
    [ReadOnly(true)]
    public double G10
    {
      get => !SAP_Module.CalcRound ? this._G10 : Math.Round(this._G10, SAP_Module.RoundFigure);
      set => this._G10 = value;
    }

    [Description("Volume ratio Veff/Vd")]
    [ReadOnly(true)]
    public double G11
    {
      get => !SAP_Module.CalcRound ? this._G11 : Math.Round(this._G11, SAP_Module.RoundFigure);
      set => this._G11 = value;
    }

    [Description("Solar storage volume factor f(Veff/Vd)")]
    [ReadOnly(true)]
    public double G12
    {
      get => !SAP_Module.CalcRound ? this._G12 : Math.Round(this._G12, SAP_Module.RoundFigure);
      set => this._G12 = value;
    }

    [Description("Annual solar input Qs (kWh)")]
    [ReadOnly(true)]
    public double Qs
    {
      get => !SAP_Module.CalcRound ? this._G13 : Math.Round(this._G13, SAP_Module.RoundFigure);
      set => this._G13 = value;
    }

    [ReadOnly(true)]
    public Months Qs_m => this._Qsm;
  }
}
