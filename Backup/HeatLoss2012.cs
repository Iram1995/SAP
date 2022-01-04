
// Type: SAP2012.HeatLoss2012




using System;
using System.ComponentModel;

namespace SAP2012
{
  [TypeConverter(typeof (ExpandableObjectConverter))]
  public class HeatLoss2012
  {
    private double _Box26HL;
    private double _Box27HL;
    private double _Box27aHL;
    private double _Box28HL;
    private double _Box28HC;
    private double _Box28aHL;
    private double _Box28aHC;
    private double _Box28bHL;
    private double _Box28bHC;
    private double _Box29HL;
    private double _Box29HC;
    private double _Box29aHL;
    private double _Box29aHC;
    private double _Box30HL;
    private double _Box30HC;
    private double _Box31;
    private double _Box32HC;
    private double _Box32HL;
    private double _Box32aHC;
    private double _Box32bHC;
    private double _Box32cHC;
    private double _Box32dHC;
    private double _Box32eHC;
    private double _Box33;
    private double _Box34;
    private double _Box35;
    private double _Box36;
    private double _Box37;
    private Months _Box38m;
    private Months _Box39m;
    private double _Box39;
    private Months _Box40m;
    private double _Box40;
    private Months _Box41m;
    private MicroCHP_Values2012 _CHPCalc;
    private HeatPumps_Values2012 _HPCalc;

    public HeatLoss2012()
    {
      this._Box38m = new Months();
      this._Box39m = new Months();
      this._Box40m = new Months();
      this._Box41m = new Months();
      this._CHPCalc = new MicroCHP_Values2012();
      this._HPCalc = new HeatPumps_Values2012();
    }

    public override string ToString() => "3. Heat losses and heat loss parameter";

    [Description("Doors")]
    [ReadOnly(true)]
    public double Box26HL
    {
      get => !SAP_Module.CalcRound ? this._Box26HL : Math.Round(this._Box26HL, SAP_Module.RoundFigure);
      set => this._Box26HL = value;
    }

    [Description("Window")]
    [ReadOnly(true)]
    public double Box27HL
    {
      get => !SAP_Module.CalcRound ? this._Box27HL : Math.Round(this._Box27HL, SAP_Module.RoundFigure);
      set => this._Box27HL = value;
    }

    [Description("Roof windows")]
    [ReadOnly(true)]
    public double Box27aHL
    {
      get => !SAP_Module.CalcRound ? this._Box27aHL : Math.Round(this._Box27aHL, SAP_Module.RoundFigure);
      set => this._Box27aHL = value;
    }

    [Description("Basement floor")]
    [ReadOnly(true)]
    public double Box28HL
    {
      get => !SAP_Module.CalcRound ? this._Box28HL : Math.Round(this._Box28HL, SAP_Module.RoundFigure);
      set => this._Box28HL = value;
    }

    [Description("Basement floor")]
    [ReadOnly(true)]
    public double Box28HC
    {
      get => !SAP_Module.CalcRound ? this._Box28HC : Math.Round(this._Box28HC, SAP_Module.RoundFigure);
      set => this._Box28HC = value;
    }

    [Description("Ground floor")]
    [ReadOnly(true)]
    public double Box28aHL
    {
      get => !SAP_Module.CalcRound ? this._Box28aHL : Math.Round(this._Box28aHL, SAP_Module.RoundFigure);
      set => this._Box28aHL = value;
    }

    [Description("Ground floor")]
    [ReadOnly(true)]
    public double Box28aHC
    {
      get => !SAP_Module.CalcRound ? this._Box28aHC : Math.Round(this._Box28aHC, SAP_Module.RoundFigure);
      set => this._Box28aHC = value;
    }

    [Description("Exposed floor")]
    [ReadOnly(true)]
    public double Box28bHL
    {
      get => !SAP_Module.CalcRound ? this._Box28bHL : Math.Round(this._Box28bHL, SAP_Module.RoundFigure);
      set => this._Box28bHL = value;
    }

    [Description("Exposed floor")]
    [ReadOnly(true)]
    public double Box28bHC
    {
      get => !SAP_Module.CalcRound ? this._Box28bHC : Math.Round(this._Box28bHC, SAP_Module.RoundFigure);
      set => this._Box28bHC = value;
    }

    [Description("Basement walls")]
    [ReadOnly(true)]
    public double Box29HL
    {
      get => !SAP_Module.CalcRound ? this._Box29HL : Math.Round(this._Box29HL, SAP_Module.RoundFigure);
      set => this._Box29HL = value;
    }

    [Description("Basement walls")]
    [ReadOnly(true)]
    public double Box29HC
    {
      get => !SAP_Module.CalcRound ? this._Box29HC : Math.Round(this._Box29HC, SAP_Module.RoundFigure);
      set => this._Box29HC = value;
    }

    [Description("External wall")]
    [ReadOnly(true)]
    public double Box29aHL
    {
      get => !SAP_Module.CalcRound ? this._Box29aHL : Math.Round(this._Box29aHL, SAP_Module.RoundFigure);
      set => this._Box29aHL = value;
    }

    [Description("External wall")]
    [ReadOnly(true)]
    public double Box29aHC
    {
      get => !SAP_Module.CalcRound ? this._Box29aHC : Math.Round(this._Box29aHC, SAP_Module.RoundFigure);
      set => this._Box29aHC = value;
    }

    [Description("Roof")]
    [ReadOnly(true)]
    public double Box30HL
    {
      get => !SAP_Module.CalcRound ? this._Box30HL : Math.Round(this._Box30HL, SAP_Module.RoundFigure);
      set => this._Box30HL = value;
    }

    [Description("Roof")]
    [ReadOnly(true)]
    public double Box30HC
    {
      get => !SAP_Module.CalcRound ? this._Box30HC : Math.Round(this._Box30HC, SAP_Module.RoundFigure);
      set => this._Box30HC = value;
    }

    [Description("Total area of elements A, m\u00B2")]
    [ReadOnly(true)]
    public double Box31
    {
      get => !SAP_Module.CalcRound ? this._Box31 : Math.Round(this._Box31, SAP_Module.RoundFigure);
      set => this._Box31 = value;
    }

    [Description("Party wall")]
    [ReadOnly(true)]
    public double Box32HL
    {
      get => !SAP_Module.CalcRound ? this._Box32HL : Math.Round(this._Box32HL, SAP_Module.RoundFigure);
      set => this._Box32HL = value;
    }

    [Description("Party wall heat capacity")]
    [ReadOnly(true)]
    public double Box32HC
    {
      get => !SAP_Module.CalcRound ? this._Box32HC : Math.Round(this._Box32HC, SAP_Module.RoundFigure);
      set => this._Box32HC = value;
    }

    [Description("Party floor")]
    [ReadOnly(true)]
    public double Box32aHC
    {
      get => !SAP_Module.CalcRound ? this._Box32aHC : Math.Round(this._Box32aHC, SAP_Module.RoundFigure);
      set => this._Box32aHC = value;
    }

    [Description("Party ceiling")]
    [ReadOnly(true)]
    public double Box32bHC
    {
      get => !SAP_Module.CalcRound ? this._Box32bHC : Math.Round(this._Box32bHC, SAP_Module.RoundFigure);
      set => this._Box32bHC = value;
    }

    [Description("Internal wall")]
    [ReadOnly(true)]
    public double Box32cHC
    {
      get => !SAP_Module.CalcRound ? this._Box32cHC : Math.Round(this._Box32cHC, SAP_Module.RoundFigure);
      set => this._Box32cHC = value;
    }

    [Description("Internal floor")]
    [ReadOnly(true)]
    public double Box32dHC
    {
      get => !SAP_Module.CalcRound ? this._Box32dHC : Math.Round(this._Box32dHC, SAP_Module.RoundFigure);
      set => this._Box32dHC = value;
    }

    [Description("Internal ceiling")]
    [ReadOnly(true)]
    public double Box32eHC
    {
      get => !SAP_Module.CalcRound ? this._Box32eHC : Math.Round(this._Box32eHC, SAP_Module.RoundFigure);
      set => this._Box32eHC = value;
    }

    [Description("Fabric heat loss, W/K")]
    [ReadOnly(true)]
    public double Box33
    {
      get => !SAP_Module.CalcRound ? this._Box33 : Math.Round(this._Box33, SAP_Module.RoundFigure);
      set => this._Box33 = value;
    }

    [Description("Heat capacity")]
    [ReadOnly(true)]
    public double Box34
    {
      get => !SAP_Module.CalcRound ? this._Box34 : Math.Round(this._Box34, SAP_Module.RoundFigure);
      set => this._Box34 = value;
    }

    [Description("Thermal mass parameter")]
    [ReadOnly(true)]
    public double Box35
    {
      get => !SAP_Module.CalcRound ? this._Box35 : Math.Round(this._Box35, SAP_Module.RoundFigure);
      set => this._Box35 = value;
    }

    [Description("Thermal bridges")]
    [ReadOnly(true)]
    public double Box36
    {
      get => !SAP_Module.CalcRound ? this._Box36 : Math.Round(this._Box36, SAP_Module.RoundFigure);
      set => this._Box36 = value;
    }

    [Description("Total fabric heat loss")]
    [ReadOnly(true)]
    public double Box37
    {
      get => !SAP_Module.CalcRound ? this._Box37 : Math.Round(this._Box37, SAP_Module.RoundFigure);
      set => this._Box37 = value;
    }

    [ReadOnly(true)]
    public Months Box38_m => this._Box38m;

    [ReadOnly(true)]
    public Months Box39_m => this._Box39m;

    [Description("Heat transfer coefficient")]
    [ReadOnly(true)]
    public double Box39
    {
      get => !SAP_Module.CalcRound ? this._Box39 : Math.Round(this._Box39, SAP_Module.RoundFigure);
      set => this._Box39 = value;
    }

    [ReadOnly(true)]
    public Months Box40_m => this._Box40m;

    [Description("Heat loss parameter")]
    [ReadOnly(true)]
    public double Box40
    {
      get => !SAP_Module.CalcRound ? this._Box40 : Math.Round(this._Box40, SAP_Module.RoundFigure);
      set => this._Box40 = value;
    }

    public MicroCHP_Values2012 CHPCalc => this._CHPCalc;

    public HeatPumps_Values2012 HPCalc => this._HPCalc;

    [Description("Number of days in month")]
    [ReadOnly(true)]
    public Months Box41_m => this._Box41m;
  }
}
