
// Type: SAP2012.Averages




using System;
using System.ComponentModel;

namespace SAP2012
{
  [TypeConverter(typeof (ExpandableObjectConverter))]
  public class Averages
  {
    private double _Wall_U;
    private double _CWall_U;
    private double _Roof_U;
    private double _Floor_U;
    private double _Party_U;
    private double _Window_U;
    private double _Multiple_Glazed;
    private string _Description;

    public double Wall_U
    {
      get => !SAP_Module.CalcRound ? this._Wall_U : Math.Round(this._Wall_U, 2);
      set => this._Wall_U = value;
    }

    public double CWall_U
    {
      get => !SAP_Module.CalcRound ? this._CWall_U : Math.Round(this._CWall_U, 2);
      set => this._CWall_U = value;
    }

    public double Party_U
    {
      get => !SAP_Module.CalcRound ? this._Party_U : Math.Round(this._Party_U, 2);
      set => this._Party_U = value;
    }

    public double Roof_U
    {
      get => !SAP_Module.CalcRound ? this._Roof_U : Math.Round(this._Roof_U, 2);
      set => this._Roof_U = value;
    }

    public double Floor_U
    {
      get => !SAP_Module.CalcRound ? this._Floor_U : Math.Round(this._Floor_U, 2);
      set => this._Floor_U = value;
    }

    public double Window_U
    {
      get => !SAP_Module.CalcRound ? this._Window_U : Math.Round(this._Window_U, 2);
      set => this._Window_U = value;
    }

    public double Multiple_GlazedP
    {
      get => !SAP_Module.CalcRound ? this._Multiple_Glazed : Math.Round(this._Multiple_Glazed, 2);
      set => this._Multiple_Glazed = value;
    }

    public string Description
    {
      get => this._Description;
      set => this._Description = value;
    }
  }
}
