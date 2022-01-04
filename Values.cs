
// Type: SAP2012.Values




using System.ComponentModel;

namespace SAP2012
{
  [TypeConverter(typeof (ExpandableObjectConverter))]
  public class Values
  {
    public double Energy;
    public double Cost;
    public double Emissions;
    public double PrimaryEnergy;
  }
}
