
// Type: SAP2012.SolarParts




using System.ComponentModel;

namespace SAP2012
{
  [TypeConverter(typeof (ExpandableObjectConverter))]
  public class SolarParts
  {
    private double _Table6d;
    private double _Area;
    private double _Flux;
    private double _Table6b;
    private double _Table6c;
    private int _Count;
    private string _Name;
    private string _Orientation;
    private double _Value;
    private string _WindowSource;

    public double Table6d
    {
      get => this._Table6d;
      set => this._Table6d = value;
    }

    public double Area
    {
      get => this._Area;
      set => this._Area = value;
    }

    public double Flux
    {
      get => this._Flux;
      set => this._Flux = value;
    }

    public double Table6b
    {
      get => this._Table6b;
      set => this._Table6b = value;
    }

    public double Table6c
    {
      get => this._Table6c;
      set => this._Table6c = value;
    }

    public int Count
    {
      get => this._Count;
      set => this._Count = value;
    }

    public string Orientation
    {
      get => this._Orientation;
      set => this._Orientation = value;
    }

    public string WindowSource
    {
      get => this._WindowSource;
      set => this._WindowSource = value;
    }

    public string Name
    {
      get => this._Name;
      set => this._Name = value;
    }

    public double Value
    {
      get => this._Value;
      set => this._Value = value;
    }
  }
}
