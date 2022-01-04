
// Type: SAP2012.Water_heating2012




using System;
using System.ComponentModel;

namespace SAP2012
{
  [TypeConverter(typeof (ExpandableObjectConverter))]
  public class Water_heating2012
  {
    private double _Box42;
    private double _Box43;
    private Months _Box44m;
    private double _Box44;
    private Months _Box45m;
    private double _Box45;
    private Months _Box46m;
    private double _Box47;
    private double _Box48;
    private double _Box49;
    private double _Box50;
    private double _Box51;
    private double _Box52;
    private double _Box53;
    private double _Box54;
    private double _Box55;
    private Months _Box56m;
    private Months _Box57m;
    private double _Box58;
    private Months _Box59m;
    private double _Box60;
    private Months _Box61m;
    private Months _Box62m;
    private Months _Box63m;
    private Months _Box64m;
    private double _Box64;
    private Months _Box64mImm;
    private double _Box64Imm;
    private Months _Box65m;
    private Solar_Water2012 _Solar;
    private WWHRS2012 _WWHRS;
    private FGHRS2012 _FGHRS;

    public Water_heating2012()
    {
      this._Box44m = new Months();
      this._Box45m = new Months();
      this._Box46m = new Months();
      this._Box56m = new Months();
      this._Box57m = new Months();
      this._Box59m = new Months();
      this._Box61m = new Months();
      this._Box62m = new Months();
      this._Box63m = new Months();
      this._Box64m = new Months();
      this._Box64mImm = new Months();
      this._Box65m = new Months();
      this._Solar = new Solar_Water2012();
      this._WWHRS = new WWHRS2012();
      this._FGHRS = new FGHRS2012();
    }

    public override string ToString() => "4. Water heating energy requirements";

    [Description("Assumed occupancy, N")]
    [ReadOnly(true)]
    public double Box42
    {
      get => !SAP_Module.CalcRound ? this._Box42 : Math.Round(this._Box42, SAP_Module.RoundFigure);
      set => this._Box42 = value;
    }

    [Description("Annual average hot water usage in litres per day Vd,average")]
    [ReadOnly(true)]
    public double Box43
    {
      get => !SAP_Module.CalcRound ? this._Box43 : Math.Round(this._Box43, SAP_Module.RoundFigure);
      set => this._Box43 = value;
    }

    [ReadOnly(true)]
    public Months Box44_m => this._Box44m;

    [Description("Hot water usage in litres per day")]
    [ReadOnly(true)]
    public double Box44
    {
      get => !SAP_Module.CalcRound ? this._Box44 : Math.Round(this._Box44, SAP_Module.RoundFigure);
      set => this._Box44 = value;
    }

    [ReadOnly(true)]
    public Months Box45_m => this._Box45m;

    [Description("Energy content of hot water used")]
    [ReadOnly(true)]
    public double Box45
    {
      get => !SAP_Module.CalcRound ? this._Box45 : Math.Round(this._Box45, SAP_Module.RoundFigure);
      set => this._Box45 = value;
    }

    [ReadOnly(true)]
    public Months Box46_m => this._Box46m;

    [Description("If manufacturer’s declared loss factor is known")]
    [ReadOnly(true)]
    public double Box47
    {
      get => !SAP_Module.CalcRound ? this._Box47 : Math.Round(this._Box47, SAP_Module.RoundFigure);
      set => this._Box47 = value;
    }

    [Description("Temperature factor from Table 2b")]
    [ReadOnly(true)]
    public double Box48
    {
      get => !SAP_Module.CalcRound ? this._Box48 : Math.Round(this._Box48, SAP_Module.RoundFigure);
      set => this._Box48 = value;
    }

    [Description("Energy lost from water storage")]
    [ReadOnly(true)]
    public double Box49
    {
      get => !SAP_Module.CalcRound ? this._Box49 : Math.Round(this._Box49, SAP_Module.RoundFigure);
      set => this._Box49 = value;
    }

    [Category("Calculation")]
    [ReadOnly(true)]
    public WWHRS2012 WWHRS => this._WWHRS;

    [Category("Calculation")]
    [ReadOnly(true)]
    public Solar_Water2012 Solar => this._Solar;

    [Category("Calculation")]
    [ReadOnly(true)]
    public FGHRS2012 FGHRS => this._FGHRS;

    [Description("Cylinder volume (litres) including any solar storage within same cylinder")]
    [ReadOnly(true)]
    public double Box50
    {
      get => !SAP_Module.CalcRound ? this._Box50 : Math.Round(this._Box50, SAP_Module.RoundFigure);
      set => this._Box50 = value;
    }

    [Description("Hot water storage loss factor from Table 2")]
    [ReadOnly(true)]
    public double Box51
    {
      get => !SAP_Module.CalcRound ? this._Box51 : Math.Round(this._Box51, SAP_Module.RoundFigure);
      set => this._Box51 = value;
    }

    [Description("Volume factor from Table 2a")]
    [ReadOnly(true)]
    public double Box52
    {
      get => !SAP_Module.CalcRound ? this._Box52 : Math.Round(this._Box52, SAP_Module.RoundFigure);
      set => this._Box52 = value;
    }

    [Description("Temperature factor from Table 2b")]
    [ReadOnly(true)]
    public double Box53
    {
      get => !SAP_Module.CalcRound ? this._Box53 : Math.Round(this._Box53, SAP_Module.RoundFigure);
      set => this._Box53 = value;
    }

    [Description("Energy lost from water storage")]
    [ReadOnly(true)]
    public double Box54
    {
      get => !SAP_Module.CalcRound ? this._Box54 : Math.Round(this._Box54, SAP_Module.RoundFigure);
      set => this._Box54 = value;
    }

    [Description("(49) or (54)")]
    [ReadOnly(true)]
    public double Box55
    {
      get => !SAP_Module.CalcRound ? this._Box55 : Math.Round(this._Box55, SAP_Module.RoundFigure);
      set => this._Box55 = value;
    }

    [ReadOnly(true)]
    public Months Box56_m => this._Box56m;

    [ReadOnly(true)]
    public Months Box57_m => this._Box57m;

    [Description("Primary circuit loss (annual) from Table 3")]
    [ReadOnly(true)]
    public double Box58
    {
      get => !SAP_Module.CalcRound ? this._Box58 : Math.Round(this._Box58, SAP_Module.RoundFigure);
      set => this._Box58 = value;
    }

    [ReadOnly(true)]
    public Months Box59_m => this._Box59m;

    [Description("Combi loss (annual) from Table 3a, 3b or 3c ( \"0\" if not a combi boiler)")]
    [ReadOnly(true)]
    public double Box60
    {
      get => !SAP_Module.CalcRound ? this._Box60 : Math.Round(this._Box60, SAP_Module.RoundFigure);
      set => this._Box60 = value;
    }

    [ReadOnly(true)]
    public Months Box61_m => this._Box61m;

    [ReadOnly(true)]
    public Months Box62_m => this._Box62m;

    [ReadOnly(true)]
    public Months Box63_m => this._Box63m;

    [ReadOnly(true)]
    public Months Box64_m => this._Box64m;

    [Description("Output from water heater")]
    [ReadOnly(true)]
    public double Box64
    {
      get => !SAP_Module.CalcRound ? this._Box64 : Math.Round(this._Box64, SAP_Module.RoundFigure);
      set => this._Box64 = value;
    }

    [ReadOnly(true)]
    public Months Box64_mImm => this._Box64mImm;

    [Description("Output from Immersion water heater")]
    [ReadOnly(true)]
    public double Box64Imm
    {
      get => !SAP_Module.CalcRound ? this._Box64Imm : Math.Round(this._Box64Imm, SAP_Module.RoundFigure);
      set => this._Box64Imm = value;
    }

    [ReadOnly(true)]
    public Months Box65_m => this._Box65m;
  }
}
