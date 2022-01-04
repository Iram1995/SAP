
// Type: SAP2012.Fabric_Energy_Efficiency2012




using System;
using System.ComponentModel;

namespace SAP2012
{
  [TypeConverter(typeof (ExpandableObjectConverter))]
  public class Fabric_Energy_Efficiency2012
  {
    private double _Box109;

    public override string ToString() => "8f. Fabric Energy Efficiency";

    [Description("Fabric Energy Efficiency")]
    [ReadOnly(true)]
    public double Box109
    {
      get => !SAP_Module.CalcRound ? this._Box109 : Math.Round(this._Box109, SAP_Module.RoundFigure);
      set => this._Box109 = value;
    }
  }
}
