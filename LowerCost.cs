
// Type: SAP2012.LowerCost




using System.ComponentModel;

namespace SAP2012
{
  [TypeConverter(typeof (ExpandableObjectConverter))]
  public class LowerCost
  {
    private Measure _E;

    public LowerCost() => this._E = new Measure();

    public Measure E => this._E;
  }
}
