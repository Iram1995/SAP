
// Type: SAP2012.Further




using System.ComponentModel;

namespace SAP2012
{
  [TypeConverter(typeof (ExpandableObjectConverter))]
  public class Further
  {
    private Measure _N;
    private Measure _U;
    private Measure _V;

    public Further()
    {
      this._N = new Measure();
      this._U = new Measure();
      this._V = new Measure();
    }

    public Measure N => this._N;

    public Measure U => this._U;

    public Measure V => this._V;

    public Measure V2 => this._V;
  }
}
