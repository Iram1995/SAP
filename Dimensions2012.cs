
// Type: SAP2012.Dimensions2012




using System;
using System.ComponentModel;

namespace SAP2012
{
  [TypeConverter(typeof (ExpandableObjectConverter))]
  public class Dimensions2012
  {
    private Dimensions2012.FloorDims[] _Dimensions;
    private double _Box4;
    private double _Box5;

    public override string ToString() => "1. Overall Dwelling Dimensions";

    public Dimensions2012.FloorDims get_Dimensions(int FloorNo)
    {
      if (this._Dimensions[FloorNo] == null)
        this._Dimensions[FloorNo] = new Dimensions2012.FloorDims();
      return this._Dimensions[FloorNo];
    }

    public void set_Dimensions(int FloorNo, Dimensions2012.FloorDims value)
    {
      if (this._Dimensions[FloorNo] == null)
        this._Dimensions[FloorNo] = new Dimensions2012.FloorDims();
      this._Dimensions[FloorNo] = value;
    }

    [Description("Floor Areas,Heights & Volumes")]
    [ReadOnly(true)]
    public Dimensions2012.FloorDims[] Dims => this._Dimensions;

    [Description("Total Dwelling Floor Area")]
    [ReadOnly(true)]
    public double Box4
    {
      get => !SAP_Module.CalcRound ? this._Box4 : Math.Round(this._Box4, SAP_Module.RoundFigure);
      set => this._Box4 = value;
    }

    [Description("Total Dwelling Volume")]
    [ReadOnly(true)]
    public double Box5
    {
      get => !SAP_Module.CalcRound ? this._Box5 : Math.Round(this._Box5, SAP_Module.RoundFigure);
      set => this._Box5 = value;
    }

    public int Floors
    {
      set => this._Dimensions = new Dimensions2012.FloorDims[checked (value - 1 + 1)];
    }

    [TypeConverter(typeof (ExpandableObjectConverter))]
    public class FloorDims
    {
      private double _1;
      private double _2;
      private double _3;

      public override string ToString() => "Floor Area,Height & Volume";

      [Description("Area")]
      [ReadOnly(true)]
      public double Area
      {
        get => !SAP_Module.CalcRound ? this._1 : Math.Round(this._1, SAP_Module.RoundFigure);
        set => this._1 = value;
      }

      [Description("Height")]
      [ReadOnly(true)]
      public double Height
      {
        get => !SAP_Module.CalcRound ? this._2 : Math.Round(this._2, SAP_Module.RoundFigure);
        set => this._2 = value;
      }

      [Description("Volume")]
      [ReadOnly(true)]
      public double Volume
      {
        get => !SAP_Module.CalcRound ? this._3 : Math.Round(this._3, SAP_Module.RoundFigure);
        set => this._3 = value;
      }
    }
  }
}
