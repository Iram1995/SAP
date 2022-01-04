
// Type: SAP2012.SAP_rating_11b2012




using System;
using System.ComponentModel;

namespace SAP2012
{
  [TypeConverter(typeof (ExpandableObjectConverter))]
  public class SAP_rating_11b2012
  {
    private double _Box356;
    private double _Box357;
    private double _Box358;
    private double _SAPRating;
    private string _SAPBand;

    public override string ToString() => "11b. SAP rating - Community heating scheme";

    [Description("Energy cost deflator")]
    [ReadOnly(true)]
    public double Box356
    {
      get => !SAP_Module.CalcRound ? this._Box356 : Math.Round(this._Box356, SAP_Module.RoundFigure);
      set => this._Box356 = value;
    }

    [Description("Energy cost factor")]
    [ReadOnly(true)]
    public double Box357
    {
      get => !SAP_Module.CalcRound ? this._Box357 : Math.Round(this._Box357, SAP_Module.RoundFigure);
      set => this._Box357 = value;
    }

    [Description("SAP rating")]
    [ReadOnly(true)]
    public double Box358
    {
      get => !SAP_Module.CalcRound ? this._Box358 : Math.Round(this._Box358, SAP_Module.RoundFigure);
      set => this._Box358 = value;
    }

    [Description("SAP rating")]
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
