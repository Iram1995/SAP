
// Type: SAP2012.AssessmentLZC_2012




using System;
using System.ComponentModel;

namespace SAP2012
{
  [TypeConverter(typeof (ExpandableObjectConverter))]
  public class AssessmentLZC_2012
  {
    private double _ZC1;
    private double _ZC2;
    private double _ZC3;
    private double _ZC4;
    private double _ZC5;
    private double _ZC6;
    private double _ZC7;
    private double _ZC8;
    private double _N;

    public override string ToString() => "ASSESSMENT OF LZC TECHNOLOGY AND ZERO CARBON HOME";

    [Description("DER")]
    [ReadOnly(true)]
    public double ZC1
    {
      get => !SAP_Module.CalcRound ? this._ZC1 : Math.Round(this._ZC1, SAP_Module.RoundFigure);
      set => this._ZC1 = value;
    }

    [Description("CO2 emissions from appliances and cooking")]
    [ReadOnly(true)]
    public double N
    {
      get => !SAP_Module.CalcRound ? this._N : Math.Round(this._N, SAP_Module.RoundFigure);
      set => this._N = value;
    }

    [Description("CO2 emissions from appliances and cooking")]
    [ReadOnly(true)]
    public double ZC2
    {
      get => !SAP_Module.CalcRound ? this._ZC2 : Math.Round(this._ZC2, SAP_Module.RoundFigure);
      set => this._ZC2 = value;
    }

    [Description("Total CO2 emissions")]
    [ReadOnly(true)]
    public double ZC3
    {
      get => !SAP_Module.CalcRound ? this._ZC3 : Math.Round(this._ZC3, SAP_Module.RoundFigure);
      set => this._ZC3 = value;
    }

    [Description("CO2 saving from additional low-energy lights and omission of secondary heating (where applicable)")]
    [ReadOnly(true)]
    public double ZC4
    {
      get => !SAP_Module.CalcRound ? this._ZC4 : Math.Round(this._ZC4, SAP_Module.RoundFigure);
      set => this._ZC4 = value;
    }

    [Description("Residual CO2 emissions offset from biomass CHP")]
    [ReadOnly(true)]
    public double ZC5
    {
      get => !SAP_Module.CalcRound ? this._ZC5 : Math.Round(this._ZC5, SAP_Module.RoundFigure);
      set => this._ZC5 = value;
    }

    [Description("Additional allowable electricity generation, kWh/m\u00B2/year")]
    [ReadOnly(true)]
    public double ZC6
    {
      get => !SAP_Module.CalcRound ? this._ZC6 : Math.Round(this._ZC6, SAP_Module.RoundFigure);
      set => this._ZC6 = value;
    }

    [Description("Resulting CO2 emissions offset from additional allowable electricity generation")]
    [ReadOnly(true)]
    public double ZC7
    {
      get => !SAP_Module.CalcRound ? this._ZC7 : Math.Round(this._ZC7, SAP_Module.RoundFigure);
      set => this._ZC7 = value;
    }

    [Description("Net CO2 emissions")]
    [ReadOnly(true)]
    public double ZC8
    {
      get => !SAP_Module.CalcRound ? this._ZC8 : Math.Round(this._ZC8, 1);
      set => this._ZC8 = value;
    }
  }
}
