
// Type: SAP2012.AppendixL2012




using System;
using System.ComponentModel;

namespace SAP2012
{
  [TypeConverter(typeof (ExpandableObjectConverter))]
  public class AppendixL2012
  {
    private double _Eb;
    private double _C1;
    private double _C2;
    private double _GL;
    private double _EL;
    private Months _ELm;
    private double _EL_Final;

    public AppendixL2012() => this._ELm = new Months();

    public override string ToString() => "Appendix L: Energy for lighting";

    [Description("Average energy consumption for lighting")]
    [ReadOnly(true)]
    public double Eb
    {
      get => !SAP_Module.CalcRound ? this._Eb : Math.Round(this._Eb, SAP_Module.RoundFigure);
      set => this._Eb = value;
    }

    [Description("Correction factor C1:")]
    [ReadOnly(true)]
    public double C1
    {
      get => !SAP_Module.CalcRound ? this._C1 : Math.Round(this._C1, SAP_Module.RoundFigure);
      set => this._C1 = value;
    }

    [Description("Correction factor, C2")]
    [ReadOnly(true)]
    public double C2
    {
      get => !SAP_Module.CalcRound ? this._C2 : Math.Round(this._C2, SAP_Module.RoundFigure);
      set => this._C2 = value;
    }

    [ReadOnly(true)]
    public double GL
    {
      get => !SAP_Module.CalcRound ? this._GL : Math.Round(this._GL, SAP_Module.RoundFigure);
      set => this._GL = value;
    }

    [Description("The annual energy used for lighting in the house, EL")]
    [ReadOnly(true)]
    public double EL
    {
      get => !SAP_Module.CalcRound ? this._EL : Math.Round(this._EL, SAP_Module.RoundFigure);
      set => this._EL = value;
    }

    [ReadOnly(true)]
    public Months ELm => this._ELm;

    [Description("The annual energy used for lighting in the house, EL")]
    [ReadOnly(true)]
    public double EL_Final
    {
      get => !SAP_Module.CalcRound ? this._EL_Final : Math.Round(this._EL_Final, SAP_Module.RoundFigure);
      set => this._EL_Final = value;
    }
  }
}
