
// Type: SAP2012.AppendixQ




using System.ComponentModel;

namespace SAP2012
{
  [TypeConverter(typeof (ExpandableObjectConverter))]
  public class AppendixQ
  {
    public Values Used;
    public Values Saved;

    public AppendixQ()
    {
      this.Used = new Values();
      this.Saved = new Values();
    }
  }
}
