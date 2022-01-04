
// Type: SAP2012.Photovoltaic2012




using System;
using System.ComponentModel;

namespace SAP2012
{
  [TypeConverter(typeof (ExpandableObjectConverter))]
  public class Photovoltaic2012
  {
    private double _PeakPower;
    private double _Radiation;
    private double _Overshading;
    private double _ElectricityProduced;

    [Description("Annual solar radiation")]
    [ReadOnly(true)]
    public double Radiation
    {
      get => !SAP_Module.CalcRound ? this._Radiation : Math.Round(this._Radiation, SAP_Module.RoundFigure);
      set => this._Radiation = value;
    }

    [Description("Overshading factor")]
    [ReadOnly(true)]
    public double Overshading
    {
      get => !SAP_Module.CalcRound ? this._Overshading : Math.Round(this._Overshading, SAP_Module.RoundFigure);
      set => this._Overshading = value;
    }

    [Description("Electricity produced by the PV module")]
    [ReadOnly(true)]
    public double ElectricityProduced
    {
      get => !SAP_Module.CalcRound ? this._ElectricityProduced : Math.Round(this._ElectricityProduced, SAP_Module.RoundFigure);
      set => this._ElectricityProduced = value;
    }

    [Description("Peak Power of the PV Unit")]
    [ReadOnly(true)]
    public double PeakPower
    {
      get => !SAP_Module.CalcRound ? this._PeakPower : Math.Round(this._PeakPower, SAP_Module.RoundFigure);
      set => this._PeakPower = value;
    }
  }
}
