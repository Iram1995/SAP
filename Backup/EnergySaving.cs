
// Type: SAP2012.EnergySaving




using System.ComponentModel;

namespace SAP2012
{
  [TypeConverter(typeof (ExpandableObjectConverter))]
  public class EnergySaving
  {
    public Values Photovoltaics;
    public Values Wind;
    public Values Additional;
    public Values micro_CHP;
    public AppendixQ AppendixQ;

    public EnergySaving()
    {
      this.Photovoltaics = new Values();
      this.Wind = new Values();
      this.Additional = new Values();
      this.micro_CHP = new Values();
      this.AppendixQ = new AppendixQ();
    }
  }
}
