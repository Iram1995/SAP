
// Type: SAP2012.WindTurbine2012




using System;
using System.ComponentModel;

namespace SAP2012
{
  [TypeConverter(typeof (ExpandableObjectConverter))]
  public class WindTurbine2012
  {
    private double _Pwind;
    private double _PA;
    private double _A;
    private double _Ewind;
    private int _NTurbines;
    private double _CF;

    [Description("Wind Turnbine Calculation")]
    [ReadOnly(true)]
    public double Pwind
    {
      get => !SAP_Module.CalcRound ? this._Pwind : Math.Round(this._Pwind, SAP_Module.RoundFigure);
      set => this._Pwind = value;
    }

    [Description("Power density of the wind")]
    [ReadOnly(true)]
    public double PA
    {
      get => !SAP_Module.CalcRound ? this._PA : Math.Round(this._PA, SAP_Module.RoundFigure);
      set => this._PA = value;
    }

    [Description("Swept area of the blade")]
    [ReadOnly(true)]
    public double A
    {
      get => !SAP_Module.CalcRound ? this._A : Math.Round(this._A, SAP_Module.RoundFigure);
      set => this._A = value;
    }

    [Description("Wind Speed Correction Factor")]
    [ReadOnly(true)]
    public double CF
    {
      get => !SAP_Module.CalcRound ? this._CF : Math.Round(this._CF, SAP_Module.RoundFigure);
      set => this._CF = value;
    }

    [Description("Number of Turbines")]
    [ReadOnly(true)]
    public double NTurbines
    {
      get => !SAP_Module.CalcRound ? (double) this._NTurbines : Convert.ToDouble(Math.Round(new Decimal(this._NTurbines), SAP_Module.RoundFigure));
      set => this._NTurbines = checked ((int) Math.Round(value));
    }

    [Description("Annual Energy kWh/year")]
    [ReadOnly(true)]
    public double Ewind
    {
      get => !SAP_Module.CalcRound ? this._Ewind : Math.Round(this._Ewind, SAP_Module.RoundFigure);
      set => this._Ewind = value;
    }
  }
}
