
// Type: SAP2012.AdditionalVariables




using System.ComponentModel;

namespace SAP2012
{
  public class AdditionalVariables
  {
    public _3 _3;
    private _6a _6a;
    private _7 _7;
    private _10 _10a;
    private Emm_Energy _12a;
    private Emm_Energy _13a;
    private Emm_Energy _12b;
    private Emm_Energy _13b;
    public EnergySaving _EnergySaving;
    private Averages _Averages;
    private Highest _Highest;

    public AdditionalVariables()
    {
      this._3 = new _3();
      this._6a = new _6a();
      this._7 = new _7();
      this._10a = new _10();
      this._12a = new Emm_Energy();
      this._13a = new Emm_Energy();
      this._12b = new Emm_Energy();
      this._13b = new Emm_Energy();
      this._EnergySaving = new EnergySaving();
      this._Averages = new Averages();
      this._Highest = new Highest();
    }

    [ReadOnly(true)]
    public _6a C6a => this._6a;

    [ReadOnly(true)]
    public _7 C7 => this._7;

    [ReadOnly(true)]
    public _10 C10a => this._10a;

    [ReadOnly(true)]
    public Emm_Energy C12a => this._12a;

    [ReadOnly(true)]
    public Emm_Energy C13a => this._13a;

    [ReadOnly(true)]
    public Emm_Energy C12b => this._12b;

    [ReadOnly(true)]
    public Emm_Energy C13b => this._13b;

    [ReadOnly(true)]
    public Averages Averages => this._Averages;

    [ReadOnly(true)]
    public Highest Highest => this._Highest;
  }
}
