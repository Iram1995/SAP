
// Type: SAP2012.Renewable2012




using System.ComponentModel;

namespace SAP2012
{
  [TypeConverter(typeof (ExpandableObjectConverter))]
  public class Renewable2012
  {
    private WindTurbine2012[] _WindTurbine2012;
    private Photovoltaic2012[] _Photovoltaic2012;

    public override string ToString() => "Renewable Technology (Not Solar)";

    [Description("Wind Turnbine Calculation")]
    [ReadOnly(true)]
    public WindTurbine2012[] WindTurbine
    {
      get => this._WindTurbine2012;
      set => this._WindTurbine2012 = value;
    }

    [Description("Photovoltaic calculation")]
    [ReadOnly(true)]
    public Photovoltaic2012[] Photovoltaic
    {
      get => this._Photovoltaic2012;
      set => this._Photovoltaic2012 = value;
    }
  }
}
