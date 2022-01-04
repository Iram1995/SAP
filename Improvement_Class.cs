
// Type: SAP2012.Improvement_Class




using System.ComponentModel;

namespace SAP2012
{
  [TypeConverter(typeof (ExpandableObjectConverter))]
  public class Improvement_Class
  {
    private LowerCost _LowerCost;
    private Further _Further;

    public Improvement_Class()
    {
      this._LowerCost = new LowerCost();
      this._Further = new Further();
    }

    public LowerCost LowerCost => this._LowerCost;

    public Further Further => this._Further;
  }
}
