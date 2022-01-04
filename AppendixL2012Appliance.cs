
// Type: SAP2012.AppendixL2012Appliance




using System;
using System.ComponentModel;

namespace SAP2012
{
  [TypeConverter(typeof (ExpandableObjectConverter))]
  public class AppendixL2012Appliance
  {
    private double _EA;
    private Months _EAm;
    private double _EA_Final;

    public AppendixL2012Appliance() => this._EAm = new Months();

    public override string ToString() => "Appendix L: Electrical Appliances";

    [Description("Initial Anual Energy")]
    [ReadOnly(true)]
    public double EA
    {
      get => !SAP_Module.CalcRound ? this._EA : Math.Round(this._EA, SAP_Module.RoundFigure);
      set => this._EA = value;
    }

    [ReadOnly(true)]
    public Months EAm => this._EAm;

    [Description("Annual total as the sum of monthly values")]
    [ReadOnly(true)]
    public double EA_Final
    {
      get => !SAP_Module.CalcRound ? this._EA_Final : Math.Round(this._EA_Final, SAP_Module.RoundFigure);
      set => this._EA_Final = value;
    }
  }
}
