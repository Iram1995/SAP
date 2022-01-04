
// Type: SAP2012.Internal_gains2012




using System.ComponentModel;

namespace SAP2012
{
  [TypeConverter(typeof (ExpandableObjectConverter))]
  public class Internal_gains2012
  {
    private Months _Box66m;
    private Months _Box67m;
    private Months _Box68m;
    private Months _Box69m;
    private Months _Box70m;
    private Months _Box71m;
    private Months _Box72m;
    private Months _Box72am;
    private Months _Box73m;
    private AppendixL2012 _AppendixL;
    private AppendixL2012Appliance _AppendixLApps;

    public Internal_gains2012()
    {
      this._Box66m = new Months();
      this._Box67m = new Months();
      this._Box68m = new Months();
      this._Box69m = new Months();
      this._Box70m = new Months();
      this._Box71m = new Months();
      this._Box72m = new Months();
      this._Box72am = new Months();
      this._Box73m = new Months();
      this._AppendixL = new AppendixL2012();
      this._AppendixLApps = new AppendixL2012Appliance();
    }

    public override string ToString() => "5. Internal gains";

    [ReadOnly(true)]
    public Months Box66_m => this._Box66m;

    [ReadOnly(true)]
    public Months Box67_m => this._Box67m;

    [ReadOnly(true)]
    public Months Box68_m => this._Box68m;

    [ReadOnly(true)]
    public Months Box69_m => this._Box69m;

    [ReadOnly(true)]
    public Months Box70_m => this._Box70m;

    [ReadOnly(true)]
    public Months Box71_m => this._Box71m;

    [ReadOnly(true)]
    public Months Box72_m => this._Box72m;

    [ReadOnly(true)]
    public Months Box72a_m => this._Box72am;

    [ReadOnly(true)]
    public Months Box73_m => this._Box73m;

    [Description("Appendix L Calculation")]
    [ReadOnly(true)]
    public AppendixL2012 AppendixL => this._AppendixL;

    [Description("Appendix L Calculation")]
    [ReadOnly(true)]
    public AppendixL2012Appliance AppendixLAppliaces => this._AppendixLApps;
  }
}
