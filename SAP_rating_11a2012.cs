
// Type: SAP2012.SAP_rating_11a2012




using System;
using System.ComponentModel;

namespace SAP2012
{
  [TypeConverter(typeof (ExpandableObjectConverter))]
  public class SAP_rating_11a2012
  {
    private double _Box256;
    private double _Box257;
    private double _Box258;
    private double _SAPRating;
    private string _SAPBand;

    public override string ToString() => "11a. SAP rating - individual heating systems";

    [Description("Energy cost deflator (Table 12):")]
    [ReadOnly(true)]
    public double Box256
    {
      get => !SAP_Module.CalcRound ? this._Box256 : Math.Round(this._Box256, SAP_Module.RoundFigure);
      set => this._Box256 = value;
    }

    [Description("Energy cost factor (ECF)")]
    [ReadOnly(true)]
    public double Box257
    {
      get => !SAP_Module.CalcRound ? this._Box257 : Math.Round(this._Box257, SAP_Module.RoundFigure);
      set => this._Box257 = value;
    }

    [Description("SAP rating")]
    [ReadOnly(true)]
    public double Box258
    {
      get => !SAP_Module.CalcRound ? this._Box258 : Math.Round(this._Box258, SAP_Module.RoundFigure);
      set => this._Box258 = value;
    }

    [Description("SAP Rating")]
    [ReadOnly(true)]
    public double SAPRating
    {
      get => this._SAPRating;
      set => this._SAPRating = value;
    }

    [Description("SAP Band")]
    [ReadOnly(true)]
    public string SAPBand
    {
      get => this._SAPBand;
      set => this._SAPBand = value;
    }
  }
}
