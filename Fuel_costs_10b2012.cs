
// Type: SAP2012.Fuel_costs_10b2012




using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;

namespace SAP2012
{
  [TypeConverter(typeof (ExpandableObjectConverter))]
  public class Fuel_costs_10b2012
  {
    private double _Box340aP;
    private double _Box340a;
    private double _Box340bP;
    private double _Box340b;
    private double _Box340cP;
    private double _Box340c;
    private double _Box340dP;
    private double _Box340d;
    private double _Box340eP;
    private double _Box340e;
    private double _Box341P;
    private double _Box341;
    private double _Box342aP;
    private double _Box342a;
    private double _Box342bP;
    private double _Box342b;
    private double _Box342cP;
    private double _Box342c;
    private double _Box342dP;
    private double _Box342d;
    private double _Box342eP;
    private double _Box342e;
    private double _Box343;
    private double _Box344;
    private double _Box345P;
    private double _Box345;
    private double _Box346P;
    private double _Box346;
    private double _Box347P;
    private double _Box347;
    private double _Box348P;
    private double _Box348;
    private double _Box349P;
    private double _Box349;
    private double _Box350P;
    private double _Box350;
    private double _Box351;
    private double _Box352;
    private double[] _Box352a;
    private double[] _Box352Pa;
    private double _Box355;
    private Fuel_costs_10b2012.AppendixQ_Items[] _AppendixQ_Item;

    public override string ToString() => "10b. Fuel costs - Community heating scheme";

    [Description("Space heating from CHP Price")]
    [ReadOnly(true)]
    public double Box340aP
    {
      get => !SAP_Module.CalcRound ? this._Box340aP : Math.Round(this._Box340aP, SAP_Module.RoundFigure);
      set => this._Box340aP = value;
    }

    [Description("Space heating from CHP Cost")]
    [ReadOnly(true)]
    public double Box340a
    {
      get => !SAP_Module.CalcRound ? this._Box340a : Math.Round(this._Box340a, SAP_Module.RoundFigure);
      set => this._Box340a = value;
    }

    [Description("Space heating from heat source 2 Price")]
    [ReadOnly(true)]
    public double Box340bP
    {
      get => !SAP_Module.CalcRound ? this._Box340bP : Math.Round(this._Box340bP, SAP_Module.RoundFigure);
      set => this._Box340bP = value;
    }

    [Description("Space heating from heat source 2 Cost")]
    [ReadOnly(true)]
    public double Box340b
    {
      get => !SAP_Module.CalcRound ? this._Box340b : Math.Round(this._Box340b, SAP_Module.RoundFigure);
      set => this._Box340b = value;
    }

    [Description("Space heating from heat source 3 Price")]
    [ReadOnly(true)]
    public double Box340cP
    {
      get => !SAP_Module.CalcRound ? this._Box340cP : Math.Round(this._Box340cP, SAP_Module.RoundFigure);
      set => this._Box340cP = value;
    }

    [Description("Space heating from heat source 3 Cost")]
    [ReadOnly(true)]
    public double Box340c
    {
      get => !SAP_Module.CalcRound ? this._Box340c : Math.Round(this._Box340c, SAP_Module.RoundFigure);
      set => this._Box340c = value;
    }

    [Description("Space heating from heat source 4 Price")]
    [ReadOnly(true)]
    public double Box340dP
    {
      get => !SAP_Module.CalcRound ? this._Box340dP : Math.Round(this._Box340dP, SAP_Module.RoundFigure);
      set => this._Box340dP = value;
    }

    [Description("Space heating from heat source 4 Cost")]
    [ReadOnly(true)]
    public double Box340d
    {
      get => !SAP_Module.CalcRound ? this._Box340d : Math.Round(this._Box340d, SAP_Module.RoundFigure);
      set => this._Box340d = value;
    }

    [Description("Space heating from heat source 5 Price")]
    [ReadOnly(true)]
    public double Box340eP
    {
      get => !SAP_Module.CalcRound ? this._Box340eP : Math.Round(this._Box340eP, SAP_Module.RoundFigure);
      set => this._Box340eP = value;
    }

    [Description("Space heating from heat source 5 Cost")]
    [ReadOnly(true)]
    public double Box340e
    {
      get => !SAP_Module.CalcRound ? this._Box340e : Math.Round(this._Box340e, SAP_Module.RoundFigure);
      set => this._Box340e = value;
    }

    [Description("Space heating (secondary) Price")]
    [ReadOnly(true)]
    public double Box341P
    {
      get => !SAP_Module.CalcRound ? this._Box341P : Math.Round(this._Box341P, SAP_Module.RoundFigure);
      set => this._Box341P = value;
    }

    [Description("Space heating (secondary) Cost")]
    [ReadOnly(true)]
    public double Box341
    {
      get => !SAP_Module.CalcRound ? this._Box341 : Math.Round(this._Box341, SAP_Module.RoundFigure);
      set => this._Box341 = value;
    }

    [Description("Water heating from CHP Price")]
    [ReadOnly(true)]
    public double Box342aP
    {
      get => !SAP_Module.CalcRound ? this._Box342aP : Math.Round(this._Box342aP, SAP_Module.RoundFigure);
      set => this._Box342aP = value;
    }

    [Description("Water heating from CHP Cost")]
    [ReadOnly(true)]
    public double Box342a
    {
      get => !SAP_Module.CalcRound ? this._Box342a : Math.Round(this._Box342a, SAP_Module.RoundFigure);
      set => this._Box342a = value;
    }

    [Description("Water heating from heat source 2 Price")]
    [ReadOnly(true)]
    public double Box342bP
    {
      get => !SAP_Module.CalcRound ? this._Box342bP : Math.Round(this._Box342bP, SAP_Module.RoundFigure);
      set => this._Box342bP = value;
    }

    [Description("Water heating from heat source 2 Cost")]
    [ReadOnly(true)]
    public double Box342b
    {
      get => !SAP_Module.CalcRound ? this._Box342b : Math.Round(this._Box342b, SAP_Module.RoundFigure);
      set => this._Box342b = value;
    }

    [Description("Water heating from heat source 3 Price")]
    [ReadOnly(true)]
    public double Box342cP
    {
      get => !SAP_Module.CalcRound ? this._Box342cP : Math.Round(this._Box342cP, SAP_Module.RoundFigure);
      set => this._Box342cP = value;
    }

    [Description("Water heating from heat source 3 Cost")]
    [ReadOnly(true)]
    public double Box342c
    {
      get => !SAP_Module.CalcRound ? this._Box342c : Math.Round(this._Box342c, SAP_Module.RoundFigure);
      set => this._Box342c = value;
    }

    [Description("Water heating from heat source 4 Price")]
    [ReadOnly(true)]
    public double Box342dP
    {
      get => !SAP_Module.CalcRound ? this._Box342dP : Math.Round(this._Box342dP, SAP_Module.RoundFigure);
      set => this._Box342dP = value;
    }

    [Description("Water heating from heat source 4 Cost")]
    [ReadOnly(true)]
    public double Box342d
    {
      get => !SAP_Module.CalcRound ? this._Box342d : Math.Round(this._Box342d, SAP_Module.RoundFigure);
      set => this._Box342d = value;
    }

    [Description("Water heating from heat source 5 Price")]
    [ReadOnly(true)]
    public double Box342eP
    {
      get => !SAP_Module.CalcRound ? this._Box342eP : Math.Round(this._Box342eP, SAP_Module.RoundFigure);
      set => this._Box342eP = value;
    }

    [Description("Water heating from heat source 5 Cost")]
    [ReadOnly(true)]
    public double Box342e
    {
      get => !SAP_Module.CalcRound ? this._Box342e : Math.Round(this._Box342e, SAP_Module.RoundFigure);
      set => this._Box342e = value;
    }

    [Description("Water heating High-rate fraction")]
    [ReadOnly(true)]
    public double Box343
    {
      get => !SAP_Module.CalcRound ? this._Box343 : Math.Round(this._Box343, SAP_Module.RoundFigure);
      set => this._Box343 = value;
    }

    [Description("Water heating Low-rate fraction")]
    [ReadOnly(true)]
    public double Box344
    {
      get => !SAP_Module.CalcRound ? this._Box344 : Math.Round(this._Box344, SAP_Module.RoundFigure);
      set => this._Box344 = value;
    }

    [Description("High-rate cost, or cost for an instantaneous water heater Price")]
    [ReadOnly(true)]
    public double Box345P
    {
      get => !SAP_Module.CalcRound ? this._Box345P : Math.Round(this._Box345P, SAP_Module.RoundFigure);
      set => this._Box345P = value;
    }

    [Description("High-rate cost, or cost for an instantaneous water heater Cost")]
    [ReadOnly(true)]
    public double Box345
    {
      get => !SAP_Module.CalcRound ? this._Box345 : Math.Round(this._Box345, SAP_Module.RoundFigure);
      set => this._Box345 = value;
    }

    [Description("Low-rate cost, or cost for an instantaneous water heater Price")]
    [ReadOnly(true)]
    public double Box346P
    {
      get => !SAP_Module.CalcRound ? this._Box346P : Math.Round(this._Box346P, SAP_Module.RoundFigure);
      set => this._Box346P = value;
    }

    [Description("Low-rate cost, or cost for an instantaneous water heater Cost")]
    [ReadOnly(true)]
    public double Box346
    {
      get => !SAP_Module.CalcRound ? this._Box346 : Math.Round(this._Box346, SAP_Module.RoundFigure);
      set => this._Box346 = value;
    }

    [Description("If water heated by instantaneous water heater Price")]
    [ReadOnly(true)]
    public double Box347P
    {
      get => !SAP_Module.CalcRound ? this._Box347P : Math.Round(this._Box347P, SAP_Module.RoundFigure);
      set => this._Box347P = value;
    }

    [Description("If water heated by instantaneous water heater Cost")]
    [ReadOnly(true)]
    public double Box347
    {
      get => !SAP_Module.CalcRound ? this._Box347 : Math.Round(this._Box347, SAP_Module.RoundFigure);
      set => this._Box347 = value;
    }

    public double Box347a { get; set; }

    [Description("Space cooling (community cooling system) Price")]
    [ReadOnly(true)]
    public double Box348P
    {
      get => !SAP_Module.CalcRound ? this._Box348P : Math.Round(this._Box348P, SAP_Module.RoundFigure);
      set => this._Box348P = value;
    }

    [Description("Space cooling (community cooling system) Cost")]
    [ReadOnly(true)]
    public double Box348
    {
      get => !SAP_Module.CalcRound ? this._Box348 : Math.Round(this._Box348, SAP_Module.RoundFigure);
      set => this._Box348 = value;
    }

    [Description("Pumps and fans Price")]
    [ReadOnly(true)]
    public double Box349P
    {
      get => !SAP_Module.CalcRound ? this._Box349P : Math.Round(this._Box349P, SAP_Module.RoundFigure);
      set => this._Box349P = value;
    }

    [Description("Pumps and fans Cost")]
    [ReadOnly(true)]
    public double Box349
    {
      get => !SAP_Module.CalcRound ? this._Box349 : Math.Round(this._Box349, SAP_Module.RoundFigure);
      set => this._Box349 = value;
    }

    [Description("Electricity for lighting Price")]
    [ReadOnly(true)]
    public double Box350P
    {
      get => !SAP_Module.CalcRound ? this._Box350P : Math.Round(this._Box350P, SAP_Module.RoundFigure);
      set => this._Box350P = value;
    }

    [Description("Electricity for lighting Cost")]
    [ReadOnly(true)]
    public double Box350
    {
      get => !SAP_Module.CalcRound ? this._Box350 : Math.Round(this._Box350, SAP_Module.RoundFigure);
      set => this._Box350 = value;
    }

    public double Box350a { get; set; }

    public double Box350b { get; set; }

    public double Box350c { get; set; }

    [Description("Additional standing charges")]
    [ReadOnly(true)]
    public double Box351
    {
      get => !SAP_Module.CalcRound ? this._Box351 : Math.Round(this._Box351, SAP_Module.RoundFigure);
      set => this._Box351 = value;
    }

    [Description("Number of Energy saving/generation technologies")]
    [ReadOnly(true)]
    public int Box352_Count
    {
      get => this._Box352Pa == null ? 0 : this._Box352Pa.Length;
      set
      {
        double[]& local1;
        double[] numArray1 = (double[]) Utils.CopyArray((Array) ^(local1 = ref this._Box352Pa), (Array) new double[checked (value - 1 + 1)]);
        local1 = numArray1;
        double[]& local2;
        double[] numArray2 = (double[]) Utils.CopyArray((Array) ^(local2 = ref this._Box352a), (Array) new double[checked (value - 1 + 1)]);
        local2 = numArray2;
      }
    }

    [Description("Electricity generated by wind turbine")]
    [ReadOnly(true)]
    public double[] Box352_Prices => this._Box352Pa;

    [Description("Electricity generated by wind turbine")]
    [ReadOnly(true)]
    public double[] Box352_Costs => this._Box352a;

    public double Box352_OA { get; set; }

    public double Box353_OA { get; set; }

    [Description("Energy saving/generation technologies Cost")]
    [ReadOnly(true)]
    public double Box352
    {
      get
      {
        if (this._Box352a == null)
          return 0.0;
        int num1 = checked (this._Box352a.Length - 1);
        int index = 0;
        double num2;
        while (index <= num1)
        {
          num2 += this._Box352a[index];
          checked { ++index; }
        }
        return !SAP_Module.CalcRound ? num2 : Math.Round(num2, SAP_Module.RoundFigure);
      }
    }

    public double get_Box352_Prices(int index) => !SAP_Module.CalcRound ? this._Box352Pa[index] : Math.Round(this._Box352Pa[index], SAP_Module.RoundFigure);

    public void set_Box352_Prices(int index, double value) => this._Box352Pa[index] = value;

    public double get_Box352_Costs(int index) => !SAP_Module.CalcRound ? this._Box352a[index] : Math.Round(this._Box352a[index], SAP_Module.RoundFigure);

    public void set_Box352_Costs(int index, double value) => this._Box352a[index] = value;

    public Fuel_costs_10b2012.AppendixQ_Items get_AppendixQ_Item(int Index)
    {
      if (this._AppendixQ_Item[Index] == null)
        this._AppendixQ_Item[Index] = new Fuel_costs_10b2012.AppendixQ_Items();
      return this._AppendixQ_Item[Index];
    }

    public void set_AppendixQ_Item(int Index, Fuel_costs_10b2012.AppendixQ_Items value)
    {
      if (this._AppendixQ_Item[Index] == null)
        this._AppendixQ_Item[Index] = new Fuel_costs_10b2012.AppendixQ_Items();
      this._AppendixQ_Item[Index] = value;
    }

    [Description("")]
    [ReadOnly(true)]
    public Fuel_costs_10b2012.AppendixQ_Items[] AppendixQ_Item => this._AppendixQ_Item;

    public int AppendixQ_Item_Count
    {
      set
      {
        this._AppendixQ_Item = new Fuel_costs_10b2012.AppendixQ_Items[checked (value - 1 + 1)];
        int num = checked (value - 1);
        int index = 0;
        while (index <= num)
        {
          this._AppendixQ_Item[index] = new Fuel_costs_10b2012.AppendixQ_Items();
          checked { ++index; }
        }
      }
    }

    [Description("")]
    [ReadOnly(true)]
    public double Box353
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
    public double Box354
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

    [Description("Total Energy Costs")]
    [ReadOnly(true)]
    public double Box355
    {
      get => !SAP_Module.CalcRound ? this._Box355 : Math.Round(this._Box355, SAP_Module.RoundFigure);
      set => this._Box355 = value;
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
