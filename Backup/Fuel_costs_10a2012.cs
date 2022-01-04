
// Type: SAP2012.Fuel_costs_10a2012




using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;

namespace SAP2012
{
  [TypeConverter(typeof (ExpandableObjectConverter))]
  public class Fuel_costs_10a2012
  {
    private double _Box240P;
    private double _Box240;
    private double _Box241P;
    private double _Box241;
    private double _Box242P;
    private double _Box242;
    private double _Box243;
    private double _Box244;
    private double _Box245P;
    private double _Box245;
    private double _Box246P;
    private double _Box246;
    private double _Box247P;
    private double _Box247;
    private double _Box247PImm;
    private double _Box247Imm;
    private double _Box248P;
    private double _Box248;
    private double _Box249P;
    private double _Box249;
    private double _Box250P;
    private double _Box250;
    private double _Box250a;
    private double _Box250b;
    private double _Box250c;
    private double _Box250e;
    private double _Box251;
    private double _Box252;
    private double[] _Box252a;
    private double[] _Box252Pa;
    private double _Box255;
    private Fuel_costs_10a2012.AppendixQ_Items[] _AppendixQ_Item;

    public override string ToString() => "10a. Fuel costs - Individual heating systems including micro-CHP";

    [Description("Space heating - main system 1 Fuel Price")]
    [ReadOnly(true)]
    public double Box240P
    {
      get => !SAP_Module.CalcRound ? this._Box240P : Math.Round(this._Box240P, SAP_Module.RoundFigure);
      set => this._Box240P = value;
    }

    [Description("Space heating - main system 1 Fuel Cost")]
    [ReadOnly(true)]
    public double Box240
    {
      get => !SAP_Module.CalcRound ? this._Box240 : Math.Round(this._Box240, SAP_Module.RoundFigure);
      set => this._Box240 = value;
    }

    [Description("Space heating - main system 2 Fuel Price")]
    [ReadOnly(true)]
    public double Box241P
    {
      get => !SAP_Module.CalcRound ? this._Box241P : Math.Round(this._Box241P, SAP_Module.RoundFigure);
      set => this._Box241P = value;
    }

    [Description("Space heating - main system 2 Fuel Cost")]
    [ReadOnly(true)]
    public double Box241
    {
      get => !SAP_Module.CalcRound ? this._Box241 : Math.Round(this._Box241, SAP_Module.RoundFigure);
      set => this._Box241 = value;
    }

    [Description("Space heating - Secondary Fuel Price")]
    [ReadOnly(true)]
    public double Box242P
    {
      get => !SAP_Module.CalcRound ? this._Box242P : Math.Round(this._Box242P, SAP_Module.RoundFigure);
      set => this._Box242P = value;
    }

    [Description("Space heating - Secondary Fuel Cost")]
    [ReadOnly(true)]
    public double Box242
    {
      get => !SAP_Module.CalcRound ? this._Box242 : Math.Round(this._Box242, SAP_Module.RoundFigure);
      set => this._Box242 = value;
    }

    [Description("Water heating (electric off-peak tariff) High-rate fraction")]
    [ReadOnly(true)]
    public double Box243
    {
      get => !SAP_Module.CalcRound ? this._Box243 : Math.Round(this._Box243, SAP_Module.RoundFigure);
      set => this._Box243 = value;
    }

    [Description("Water heating (electric off-peak tariff) Low-rate fraction")]
    [ReadOnly(true)]
    public double Box244
    {
      get => !SAP_Module.CalcRound ? this._Box244 : Math.Round(this._Box244, SAP_Module.RoundFigure);
      set => this._Box244 = value;
    }

    [Description("Water heating (electric off-peak tariff) High-rate Price")]
    [ReadOnly(true)]
    public double Box245P
    {
      get => !SAP_Module.CalcRound ? this._Box245P : Math.Round(this._Box245P, SAP_Module.RoundFigure);
      set => this._Box245P = value;
    }

    [Description("Water heating (electric off-peak tariff) High-rate Cost")]
    [ReadOnly(true)]
    public double Box245
    {
      get => !SAP_Module.CalcRound ? this._Box245 : Math.Round(this._Box245, SAP_Module.RoundFigure);
      set => this._Box245 = value;
    }

    [Description("Water heating (electric off-peak tariff) Low-rate Price")]
    [ReadOnly(true)]
    public double Box246P
    {
      get => !SAP_Module.CalcRound ? this._Box246P : Math.Round(this._Box246P, SAP_Module.RoundFigure);
      set => this._Box246P = value;
    }

    [Description("Water heating (electric off-peak tariff) Low-rate Cost")]
    [ReadOnly(true)]
    public double Box246
    {
      get => !SAP_Module.CalcRound ? this._Box246 : Math.Round(this._Box246, SAP_Module.RoundFigure);
      set => this._Box246 = value;
    }

    [Description("Water heating cost (other fuel) Price")]
    [ReadOnly(true)]
    public double Box247P
    {
      get => !SAP_Module.CalcRound ? this._Box247P : Math.Round(this._Box247P, SAP_Module.RoundFigure);
      set => this._Box247P = value;
    }

    [Description("Water heating cost (other fuel) Cost")]
    [ReadOnly(true)]
    public double Box247
    {
      get => !SAP_Module.CalcRound ? this._Box247 : Math.Round(this._Box247, SAP_Module.RoundFigure);
      set => this._Box247 = value;
    }

    public double Box247a { get; set; }

    [Description("Water heating cost (other fuel) Price")]
    [ReadOnly(true)]
    public double Box247PImm
    {
      get => !SAP_Module.CalcRound ? this._Box247PImm : Math.Round(this._Box247PImm, SAP_Module.RoundFigure);
      set => this._Box247PImm = value;
    }

    [Description("Water heating cost (other fuel) Cost")]
    [ReadOnly(true)]
    public double Box247Imm
    {
      get => !SAP_Module.CalcRound ? this._Box247Imm : Math.Round(this._Box247Imm, SAP_Module.RoundFigure);
      set => this._Box247Imm = value;
    }

    [Description("Space Cooling Price")]
    [ReadOnly(true)]
    public double Box248P
    {
      get => !SAP_Module.CalcRound ? this._Box248P : Math.Round(this._Box248P, SAP_Module.RoundFigure);
      set => this._Box248P = value;
    }

    [Description("Space Cooling Cost")]
    [ReadOnly(true)]
    public double Box248
    {
      get => !SAP_Module.CalcRound ? this._Box248 : Math.Round(this._Box248, SAP_Module.RoundFigure);
      set => this._Box248 = value;
    }

    [Description("Pumps, fans and electric keep-hot Price")]
    [ReadOnly(true)]
    public double Box249P
    {
      get => !SAP_Module.CalcRound ? this._Box249P : Math.Round(this._Box249P, SAP_Module.RoundFigure);
      set => this._Box249P = value;
    }

    [Description("Pumps, fans and electric keep-hot Cost")]
    [ReadOnly(true)]
    public double Box249
    {
      get => !SAP_Module.CalcRound ? this._Box249 : Math.Round(this._Box249, SAP_Module.RoundFigure);
      set => this._Box249 = value;
    }

    [Description("Energy for lighting Price")]
    [ReadOnly(true)]
    public double Box250P
    {
      get => !SAP_Module.CalcRound ? this._Box250P : Math.Round(this._Box250P, SAP_Module.RoundFigure);
      set => this._Box250P = value;
    }

    [Description("Energy for lighting Cost")]
    [ReadOnly(true)]
    public double Box250
    {
      get => !SAP_Module.CalcRound ? this._Box250 : Math.Round(this._Box250, SAP_Module.RoundFigure);
      set => this._Box250 = value;
    }

    [Description("Energy for Applicances")]
    [ReadOnly(true)]
    public double Box250a
    {
      get => !SAP_Module.CalcRound ? this._Box250a : Math.Round(this._Box250a, SAP_Module.RoundFigure);
      set => this._Box250a = value;
    }

    [Description("Energy for lighting Cost")]
    [ReadOnly(true)]
    public double Box250b
    {
      get => !SAP_Module.CalcRound ? this._Box250b : Math.Round(this._Box250b, SAP_Module.RoundFigure);
      set => this._Box250b = value;
    }

    [Description("Energy for cooking")]
    [ReadOnly(true)]
    public double Box250c
    {
      get => !SAP_Module.CalcRound ? this._Box250c : Math.Round(this._Box250c, SAP_Module.RoundFigure);
      set => this._Box250c = value;
    }

    [Description("Energy for showers")]
    [ReadOnly(true)]
    public double Box250e
    {
      get => !SAP_Module.CalcRound ? this._Box250e : Math.Round(this._Box250e, SAP_Module.RoundFigure);
      set => this._Box250e = value;
    }

    [Description("Additional standing charges")]
    [ReadOnly(true)]
    public double Box251
    {
      get => !SAP_Module.CalcRound ? this._Box251 : Math.Round(this._Box251, SAP_Module.RoundFigure);
      set => this._Box251 = value;
    }

    [Description("Number of Energy saving/generation technologies")]
    [ReadOnly(true)]
    public int Box252_Count
    {
      get => this._Box252Pa == null ? 0 : this._Box252Pa.Length;
      set
      {
        double[]& local1;
        double[] numArray1 = (double[]) Utils.CopyArray((Array) ^(local1 = ref this._Box252Pa), (Array) new double[checked (value - 1 + 1)]);
        local1 = numArray1;
        double[]& local2;
        double[] numArray2 = (double[]) Utils.CopyArray((Array) ^(local2 = ref this._Box252a), (Array) new double[checked (value - 1 + 1)]);
        local2 = numArray2;
      }
    }

    [Description("Electricity generated by wind turbine")]
    [ReadOnly(true)]
    public double[] Box252_Prices => this._Box252Pa;

    [Description("Electricity generated by wind turbine")]
    [ReadOnly(true)]
    public double[] Box252_Costs => this._Box252a;

    [Description("Total Energy Cost")]
    [ReadOnly(true)]
    public double Box252
    {
      get
      {
        if (this._Box252a == null)
          return 0.0;
        int num1 = checked (this._Box252a.Length - 1);
        int index = 0;
        double num2;
        while (index <= num1)
        {
          num2 += this._Box252a[index];
          checked { ++index; }
        }
        return !SAP_Module.CalcRound ? num2 : Math.Round(num2, SAP_Module.RoundFigure);
      }
    }

    public double get_Box252_Prices(int index) => !SAP_Module.CalcRound ? this._Box252Pa[index] : Math.Round(this._Box252Pa[index], SAP_Module.RoundFigure);

    public void set_Box252_Prices(int index, double value) => this._Box252Pa[index] = value;

    public double get_Box252_Costs(int index) => !SAP_Module.CalcRound ? this._Box252a[index] : Math.Round(this._Box252a[index], SAP_Module.RoundFigure);

    public void set_Box252_Costs(int index, double value) => this._Box252a[index] = value;

    public double Box252_OA { get; set; }

    public double Box253_OA { get; set; }

    public double Box254_OA { get; set; }

    public Fuel_costs_10a2012.AppendixQ_Items get_AppendixQ_Item(int Index)
    {
      if (this._AppendixQ_Item[Index] == null)
        this._AppendixQ_Item[Index] = new Fuel_costs_10a2012.AppendixQ_Items();
      return this._AppendixQ_Item[Index];
    }

    public void set_AppendixQ_Item(int Index, Fuel_costs_10a2012.AppendixQ_Items value)
    {
      if (this._AppendixQ_Item[Index] == null)
        this._AppendixQ_Item[Index] = new Fuel_costs_10a2012.AppendixQ_Items();
      this._AppendixQ_Item[Index] = value;
    }

    [Description("")]
    [ReadOnly(true)]
    public Fuel_costs_10a2012.AppendixQ_Items[] AppendixQ_Item => this._AppendixQ_Item;

    public int AppendixQ_Item_Count
    {
      set
      {
        this._AppendixQ_Item = new Fuel_costs_10a2012.AppendixQ_Items[checked (value - 1 + 1)];
        int num = checked (value - 1);
        int index = 0;
        while (index <= num)
        {
          this._AppendixQ_Item[index] = new Fuel_costs_10a2012.AppendixQ_Items();
          checked { ++index; }
        }
      }
    }

    [Description("")]
    [ReadOnly(true)]
    public double Box253
    {
      get
      {
        if (this._AppendixQ_Item == null)
          return 0.0;
        int num1 = checked (this._AppendixQ_Item.Length - 1);
        int index = 0;
        float num2;
        while (index <= num1)
        {
          num2 += (float) this._AppendixQ_Item[index].Energy_Saved_Cost;
          checked { ++index; }
        }
        return !SAP_Module.CalcRound ? (double) num2 : Math.Round((double) num2, SAP_Module.RoundFigure);
      }
    }

    [Description("")]
    [ReadOnly(true)]
    public double Box254
    {
      get
      {
        if (this._AppendixQ_Item == null)
          return 0.0;
        int num1 = checked (this._AppendixQ_Item.Length - 1);
        int index = 0;
        float num2;
        while (index <= num1)
        {
          num2 += (float) this._AppendixQ_Item[index].Energy_Used_Cost;
          checked { ++index; }
        }
        return !SAP_Module.CalcRound ? (double) num2 : Math.Round((double) num2, SAP_Module.RoundFigure);
      }
    }

    [Description("Energy saving/generation technologies Cost")]
    [ReadOnly(true)]
    public double Box255
    {
      get => !SAP_Module.CalcRound ? this._Box255 : Math.Round(this._Box255, SAP_Module.RoundFigure);
      set => this._Box255 = value;
    }

    [TypeConverter(typeof (ExpandableObjectConverter))]
    public class AppendixQ_Items
    {
      private double _Energy_Saved_Price;
      private double _Energy_Saved_Cost;
      private double _Energy_Used_Price;
      private double _Energy_Used_Cost;

      public override string ToString() => "AppendixQ Items";

      [Description("Energy Saved Price")]
      [ReadOnly(true)]
      public double Energy_Saved_Price
      {
        get => !SAP_Module.CalcRound ? this._Energy_Saved_Price : Math.Round(this._Energy_Saved_Price, SAP_Module.RoundFigure);
        set => this._Energy_Saved_Price = value;
      }

      [Description("Energy Saved Cost")]
      [ReadOnly(true)]
      public double Energy_Saved_Cost
      {
        get => !SAP_Module.CalcRound ? this._Energy_Saved_Cost : Math.Round(this._Energy_Saved_Cost, SAP_Module.RoundFigure);
        set => this._Energy_Saved_Cost = value;
      }

      [Description("Energy Used Price")]
      [ReadOnly(true)]
      public double Energy_Used_Price
      {
        get => !SAP_Module.CalcRound ? this._Energy_Used_Price : Math.Round(this._Energy_Used_Price, SAP_Module.RoundFigure);
        set => this._Energy_Used_Price = value;
      }

      [Description("Energy Used Cost")]
      [ReadOnly(true)]
      public double Energy_Used_Cost
      {
        get => !SAP_Module.CalcRound ? this._Energy_Used_Cost : Math.Round(this._Energy_Used_Cost, SAP_Module.RoundFigure);
        set => this._Energy_Used_Cost = value;
      }
    }
  }
}
