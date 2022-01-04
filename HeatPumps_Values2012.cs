
// Type: SAP2012.HeatPumps_Values2012




using System;
using System.ComponentModel;

namespace SAP2012
{
  [TypeConverter(typeof (ExpandableObjectConverter))]
  public class HeatPumps_Values2012
  {
    private double _DHL;
    private double _PSR;
    private int _Hours;
    private double _SecFraction;
    private int _HeatingDuration;
    private double _ThroughPut;
    private double _Rhp;
    private double _hhp;
    private double _Fmv;
    private double _nspace;
    private double _espace;
    private double _esummer;
    private double _nsummer;
    private Months _N24_16;
    private Months _N24_9;
    private Months _N16_9;
    private double _E;

    public HeatPumps_Values2012()
    {
      this._N24_16 = new Months();
      this._N24_9 = new Months();
      this._N16_9 = new Months();
    }

    public override string ToString() => "Appendix N Heat Pumps Calculation";

    [Description("Design Heat Loss (W)")]
    [ReadOnly(true)]
    public double DHL
    {
      get => !SAP_Module.CalcRound ? this._DHL : Math.Round(this._DHL, SAP_Module.RoundFigure);
      set => this._DHL = value;
    }

    [Description("Plant size ratio for which data apply")]
    [ReadOnly(true)]
    public double PSR
    {
      get => !SAP_Module.CalcRound ? this._PSR : Math.Round(this._PSR, SAP_Module.RoundFigure);
      set => this._PSR = value;
    }

    [Description("The fraction of the total space heating requirement not provided by the main heating")]
    [ReadOnly(true)]
    public double SecFraction
    {
      get => !SAP_Module.CalcRound ? this._SecFraction : Math.Round(this._SecFraction, SAP_Module.RoundFigure);
      set => this._SecFraction = value;
    }

    [Description("The fraction of the total space heating requirement not provided by the main heating")]
    [ReadOnly(true)]
    public int HeatingDuration
    {
      get => this._HeatingDuration;
      set => this._HeatingDuration = value;
    }

    [Description("")]
    [ReadOnly(true)]
    public double ThroughPut
    {
      get => !SAP_Module.CalcRound ? this._ThroughPut : Math.Round(this._ThroughPut, SAP_Module.RoundFigure);
      set => this._ThroughPut = value;
    }

    [Description("")]
    [ReadOnly(true)]
    public double Rhp
    {
      get => !SAP_Module.CalcRound ? this._Rhp : Math.Round(this._Rhp, SAP_Module.RoundFigure);
      set => this._Rhp = value;
    }

    [Description("")]
    [ReadOnly(true)]
    public double hhp
    {
      get => !SAP_Module.CalcRound ? this._hhp : Math.Round(this._hhp, SAP_Module.RoundFigure);
      set => this._hhp = value;
    }

    [Description("")]
    [ReadOnly(true)]
    public double Fmv
    {
      get => !SAP_Module.CalcRound ? this._Fmv : Math.Round(this._Fmv, SAP_Module.RoundFigure);
      set => this._Fmv = value;
    }

    [Description("Space heating thermal efficiency")]
    [ReadOnly(true)]
    public double nspace
    {
      get => !SAP_Module.CalcRound ? this._nspace : Math.Round(this._nspace, SAP_Module.RoundFigure);
      set => this._nspace = value;
    }

    [Description("Thermal efficiency for water heating")]
    [ReadOnly(true)]
    public double nsummer
    {
      get => !SAP_Module.CalcRound ? this._nsummer : Math.Round(this._nsummer, SAP_Module.RoundFigure);
      set => this._nsummer = value;
    }

    [Description("Electricity consumed for space heating or, if negative, net electricity generated, per unit of heat generated for space heating")]
    [ReadOnly(true)]
    public double espace
    {
      get => !SAP_Module.CalcRound ? this._espace : Math.Round(this._espace, SAP_Module.RoundFigure);
      set => this._espace = value;
    }

    [Description("Electricity consumed for space heating or, if negative, net electricity generated, per unit of heat generated for space heating")]
    [ReadOnly(true)]
    public double esummer
    {
      get => !SAP_Module.CalcRound ? this._esummer : Math.Round(this._esummer, SAP_Module.RoundFigure);
      set => this._esummer = value;
    }

    [ReadOnly(true)]
    public Months N24_16 => this._N24_16;

    [ReadOnly(true)]
    public Months N24_9 => this._N24_9;

    [ReadOnly(true)]
    public Months N16_9 => this._N16_9;

    [Description("Electricity produced/consumed")]
    [ReadOnly(true)]
    public double E
    {
      get => !SAP_Module.CalcRound ? this._E : Math.Round(this._E, SAP_Module.RoundFigure);
      set => this._E = value;
    }

    public enum SecondaryFraction
    {
      Variable = 4,
      _11 = 11, // 0x0000000B
      _16 = 16, // 0x00000010
      _24 = 24, // 0x00000018
    }
  }
}
