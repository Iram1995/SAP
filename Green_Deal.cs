
// Type: SAP2012.Green_Deal




using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;

namespace SAP2012
{
  public class Green_Deal
  {
    private float _R;
    private float _ir;
    private float _n;
    private TickType _TickType;
    private float _Lower;
    private float _Higher;
    private string _Catagory;

    public override string ToString() => "Green Deal";

    public Green_Deal()
    {
      this.MainFuel = "";
      this.AddFuel = "";
      this.SecFuel = "";
      this.WaterFuel = "";
      this._ir = 0.07f;
    }

    public TickType TickType
    {
      get => this._TickType;
      set => this._TickType = value;
    }

    public float Lower
    {
      get => this._Lower;
      set => this._Lower = value;
    }

    public float Higher
    {
      get => this._Higher;
      set => this._Higher = value;
    }

    public float R
    {
      get => this._R;
      set => this._R = value;
    }

    public float GreenDealCost { get; set; }

    public float C
    {
      get
      {
        if ((double) this._Higher == 0.0)
          return this._Lower;
        return (double) this.GreenDealCost == 0.0 ? (float) Math.Round(((double) this._Lower + (double) this._Higher) / 2.0, 2) : this.GreenDealCost;
      }
    }

    public double Cost { get; set; }

    public float ir
    {
      get => this._ir;
      set => this._ir = value;
    }

    public float n
    {
      get => this._n;
      set => this._n = value;
    }

    public string Catagory
    {
      get => this._Catagory;
      set => this._Catagory = value;
    }

    public string IndicativeCost => (double) this._Higher == 0.0 | (double) this._Higher <= (double) this._Lower ? Strings.FormatCurrency((object) this.Lower, 0) : Strings.FormatCurrency((object) this.Lower, 0) + " - " + Strings.FormatCurrency((object) this.Higher, 0);

    public float ElectricSaving
    {
      get
      {
        float num1 = 0.0f;
        if (Operators.CompareString(this.MainFuel, "Electricity", false) == 0)
          num1 += this.Main;
        if (Operators.CompareString(this.AddFuel, "Electricity", false) == 0)
          num1 += this.Add;
        if (Operators.CompareString(this.SecFuel, "Electricity", false) == 0)
          num1 += this.Sec;
        if (Operators.CompareString(this.WaterFuel, "Electricity", false) == 0)
          num1 += this.Water;
        float num2 = num1 + this.WaterImm + this.Cooling + this.Fans;
        if (this.IsElectricBeforeSwitch)
          num2 += this.MainBeforeSwitch;
        return (float) Math.Round((double) num2, 2);
      }
    }

    public float GasSaving
    {
      get
      {
        string str = "mains gas,LNG,,LPG subject to Special Condition 18";
        float num = 0.0f;
        if (str.Contains(this.MainFuel) & (uint) Operators.CompareString(this.WaterFuel, "", false) > 0U)
          num += this.Main;
        if (str.Contains(this.AddFuel) & (uint) Operators.CompareString(this.AddFuel, "", false) > 0U)
          num += this.Add;
        if (str.Contains(this.SecFuel) & (uint) Operators.CompareString(this.SecFuel, "", false) > 0U)
          num += this.Sec;
        if (str.Contains(this.WaterFuel) & (uint) Operators.CompareString(this.WaterFuel, "", false) > 0U)
          num += this.Water;
        return (float) Math.Round((double) num, 2);
      }
    }

    public float OtherSaving
    {
      get
      {
        string str = "mains gas,LNG,LPG subject to Special Condition 18,Electricity";
        float num = 0.0f;
        if (!str.Contains(this.MainFuel) & (uint) Operators.CompareString(this.WaterFuel, "", false) > 0U)
          num += this.Main;
        if (!str.Contains(this.AddFuel) & (uint) Operators.CompareString(this.WaterFuel, "", false) > 0U)
          num += this.Add;
        if (!str.Contains(this.SecFuel) & (uint) Operators.CompareString(this.WaterFuel, "", false) > 0U)
          num += this.Sec;
        if (!str.Contains(this.WaterFuel) & (uint) Operators.CompareString(this.WaterFuel, "", false) > 0U)
          num += this.Water;
        if (!this.IsElectricBeforeSwitch)
          num += this.MainBeforeSwitch;
        return (float) Math.Round((double) num, 2);
      }
    }

    public float Main { get; set; }

    public float Add { get; set; }

    public float Sec { get; set; }

    public float Water { get; set; }

    public float WaterImm { get; set; }

    public float Cooling { get; set; }

    public float Fans { get; set; }

    public string MainFuel { get; set; }

    public string AddFuel { get; set; }

    public string SecFuel { get; set; }

    public string WaterFuel { get; set; }

    public float MainBeforeSwitch { get; set; }

    public bool IsElectricBeforeSwitch { get; set; }
  }
}
