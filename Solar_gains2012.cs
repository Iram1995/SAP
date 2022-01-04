
// Type: SAP2012.Solar_gains2012




using System.ComponentModel;

namespace SAP2012
{
  [TypeConverter(typeof (ExpandableObjectConverter))]
  public class Solar_gains2012
  {
    private Months _Box74m;
    private Months _Box75m;
    private Months _Box76m;
    private Months _Box77m;
    private Months _Box78m;
    private Months _Box79m;
    private Months _Box80m;
    private Months _Box81m;
    private Months _Box82m;
    private Months _Box83m;
    private Months _Box84m;

    public Solar_gains2012()
    {
      this._Box74m = new Months();
      this._Box75m = new Months();
      this._Box76m = new Months();
      this._Box77m = new Months();
      this._Box78m = new Months();
      this._Box79m = new Months();
      this._Box80m = new Months();
      this._Box81m = new Months();
      this._Box82m = new Months();
      this._Box83m = new Months();
      this._Box84m = new Months();
    }

    public override string ToString() => "6. Solar gains";

    [ReadOnly(true)]
    public Months Box74_m => this._Box74m;

    [ReadOnly(true)]
    public Months Box75_m => this._Box75m;

    [ReadOnly(true)]
    public Months Box76_m => this._Box76m;

    [ReadOnly(true)]
    public Months Box77_m => this._Box77m;

    [ReadOnly(true)]
    public Months Box78_m => this._Box78m;

    [ReadOnly(true)]
    public Months Box79_m => this._Box79m;

    [ReadOnly(true)]
    public Months Box80_m => this._Box80m;

    [ReadOnly(true)]
    public Months Box81_m => this._Box81m;

    [ReadOnly(true)]
    public Months Box82_m => this._Box82m;

    [ReadOnly(true)]
    public Months Box83_m => this._Box83m;

    [ReadOnly(true)]
    public Months Box84_m => this._Box84m;
  }
}
