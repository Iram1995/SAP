
// Type: SAP2012.Energy_Requirements_9a2012




using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;

namespace SAP2012
{
  [TypeConverter(typeof (ExpandableObjectConverter))]
  public class Energy_Requirements_9a2012
  {
    private double _Box201;
    private double _Box202;
    private double _Box203;
    private double _Box204;
    private double _Box205;
    private double _Box206;
    public double Box206Uncorrected;
    public double _Box206Uncorrected;
    private double _Box207;
    public double Box207Uncorrected;
    public double _Box207Uncorrected;
    private double _Box208;
    private double _Box209;
    private Months _Box210m;
    private Months _Box211m;
    private double _Box211;
    private double _Box211_corrected;
    private double _Box211_factor;
    private Months _Box212m;
    private Months _Box213m;
    private double _Box213;
    private double _Box213_corrected;
    private double _Box213_factor;
    private Months _Box214m;
    private Months _Box215m;
    private double _Box215;
    private double _Box215_corrected;
    private double _Box215_factor;
    private Months _Box216m;
    private double _Box216;
    public double Box216Uncorrected;
    public double _Box216Uncorrected;
    private Months _Box217m;
    private Months _Box217mImm;
    private Months _Box218m;
    private Months _Box219m;
    private double _Box219;
    private double _Box219_corrected;
    private double _Box219_factor;
    private Months _Box219mImm;
    private double _Box219Imm;
    private double _Box219Imm_corrected;
    private double _Box219Imm_factor;
    private Months _Box220m;
    private Months _Box221m;
    private double _Box221;
    private double _Box230a;
    private double _Box230b;
    private double _Box230c;
    private double _Box230d;
    private double _Box230e;
    private double _Box230f;
    private double _Box230g;
    private double _Box230h;
    private double _Box231;
    private double _Box231_corrected;
    private double _Box231_factor;
    private double _Box232;
    private double _Box232_corrected;
    private double _Box232_factor;
    private double _Box232a;
    private double _Box232a_corrected;
    private double _Box232a_factor;
    private double _Box232b;
    private double _Box232b_corrected;
    private double _Box232b_factor;
    private double _Box232c;
    private double _Box232c_corrected;
    private double _Box232c_factor;
    private double _Box232e;
    private double _Box232e_corrected;
    private double _Box232e_factor;
    private double[] _Box233;
    private double[] _Box234;
    private double _Box235;
    private double _Box235a;
    private double _Box236a;
    private double _Box237a;
    private double _Box236b;
    private double _Box237b;
    private Energy_Requirements_9a2012.AppendixQ_Items[] _AppendixQ_Item;
    private AppendixF_Items _AppendixF;

    public Energy_Requirements_9a2012()
    {
      this._Box210m = new Months();
      this._Box211m = new Months();
      this._Box212m = new Months();
      this._Box213m = new Months();
      this._Box214m = new Months();
      this._Box215m = new Months();
      this._Box216m = new Months();
      this._Box217m = new Months();
      this._Box217mImm = new Months();
      this._Box218m = new Months();
      this._Box219m = new Months();
      this._Box219mImm = new Months();
      this._Box220m = new Months();
      this._Box221m = new Months();
      this._AppendixF = new AppendixF_Items();
    }

    public override string ToString() => "9a. Energy requirements – Individual heating systems including micro-CHP";

    [Description("Fraction of space heat from secondary/supplementary system")]
    [ReadOnly(true)]
    public double Box201
    {
      get => !SAP_Module.CalcRound ? this._Box201 : Math.Round(this._Box201, SAP_Module.RoundFigure);
      set => this._Box201 = value;
    }

    [Description("Fraction of space heat from main system(s)")]
    [ReadOnly(true)]
    public double Box202
    {
      get => !SAP_Module.CalcRound ? this._Box202 : Math.Round(this._Box202, SAP_Module.RoundFigure);
      set => this._Box202 = value;
    }

    [Description("Fraction of main heating from main system 2")]
    [ReadOnly(true)]
    public double Box203
    {
      get => !SAP_Module.CalcRound ? this._Box203 : Math.Round(this._Box203, SAP_Module.RoundFigure);
      set => this._Box203 = value;
    }

    [Description("Fraction of total heating from main system 1")]
    [ReadOnly(true)]
    public double Box204
    {
      get => !SAP_Module.CalcRound ? this._Box204 : Math.Round(this._Box204, SAP_Module.RoundFigure);
      set => this._Box204 = value;
    }

    [Description("Fraction of total heating from main system 2")]
    [ReadOnly(true)]
    public double Box205
    {
      get => !SAP_Module.CalcRound ? this._Box205 : Math.Round(this._Box205, SAP_Module.RoundFigure);
      set => this._Box205 = value;
    }

    [Description("Efficiency of main space heating system 1 (in %)")]
    [ReadOnly(true)]
    public double Box206
    {
      get => !SAP_Module.CalcRound ? this._Box206 : Math.Round(this._Box206, SAP_Module.RoundFigure);
      set => this._Box206 = value;
    }

    [Description("Efficiency of main space heating system 2 (in %)")]
    [ReadOnly(true)]
    public double Box207
    {
      get => !SAP_Module.CalcRound ? this._Box207 : Math.Round(this._Box207, SAP_Module.RoundFigure);
      set => this._Box207 = value;
    }

    [Description("Efficiency of secondary/supplementary heating system")]
    [ReadOnly(true)]
    public double Box208
    {
      get => !SAP_Module.CalcRound ? this._Box208 : Math.Round(this._Box208, SAP_Module.RoundFigure);
      set => this._Box208 = value;
    }

    [Description("Cooling System Energy Efficiency Ratio")]
    [ReadOnly(true)]
    public double Box209
    {
      get => !SAP_Module.CalcRound ? this._Box209 : Math.Round(this._Box209, SAP_Module.RoundFigure);
      set => this._Box209 = value;
    }

    [ReadOnly(true)]
    public AppendixF_Items AppendixF => this._AppendixF;

    [ReadOnly(true)]
    public Months Box210_m => this._Box210m;

    [ReadOnly(true)]
    public Months Box211_m => this._Box211m;

    [Description("space heating fuel")]
    [ReadOnly(true)]
    public double Box211
    {
      get => !SAP_Module.CalcRound ? this._Box211 : Math.Round(this._Box211, SAP_Module.RoundFigure);
      set => this._Box211 = value;
    }

    [Description("Bill Info space heating fuel")]
    [ReadOnly(true)]
    public double Box211_corrected
    {
      get => !SAP_Module.CalcRound ? this._Box211_corrected : Math.Round(this._Box211_corrected, SAP_Module.RoundFigure);
      set => this._Box211_corrected = value;
    }

    public double Box211_High_corrected { get; set; }

    public double Box211_High_factor { get; set; }

    public double Box211_Dual_corrected { get; set; }

    public double Box211_Dual_factor { get; set; }

    public double Box211_factor
    {
      get => !SAP_Module.CalcRound ? this._Box211_factor : Math.Round(this._Box211_factor, SAP_Module.RoundFigure);
      set => this._Box211_factor = value;
    }

    [ReadOnly(true)]
    public Months Box212_m => this._Box212m;

    [ReadOnly(true)]
    public Months Box213_m => this._Box213m;

    [Description("space heating fuel - 2")]
    [ReadOnly(true)]
    public double Box213
    {
      get => !SAP_Module.CalcRound ? this._Box213 : Math.Round(this._Box213, SAP_Module.RoundFigure);
      set => this._Box213 = value;
    }

    [Description("Bill Info space heating fuel - 2")]
    [ReadOnly(true)]
    public double Box213_corrected
    {
      get => !SAP_Module.CalcRound ? this._Box213_corrected : Math.Round(this._Box213_corrected, SAP_Module.RoundFigure);
      set => this._Box213_corrected = value;
    }

    public double Box213_High_corrected { get; set; }

    public double Box213_High_factor { get; set; }

    public double Box213_Dual_corrected { get; set; }

    public double Box213_Dual_factor { get; set; }

    public double Box213_factor
    {
      get => !SAP_Module.CalcRound ? this._Box213_factor : Math.Round(this._Box213_factor, SAP_Module.RoundFigure);
      set => this._Box213_factor = value;
    }

    public Months Box214_m
    {
      get => this._Box214m;
      set => this._Box214m = value;
    }

    public Months Box215_m
    {
      get => this._Box215m;
      set => this._Box215m = value;
    }

    [Description("Space heating fuel (secondary)")]
    [ReadOnly(true)]
    public double Box215
    {
      get => !SAP_Module.CalcRound ? this._Box215 : Math.Round(this._Box215, SAP_Module.RoundFigure);
      set => this._Box215 = value;
    }

    [Description("Bill Info Space heating fuel (secondary)")]
    [ReadOnly(true)]
    public double Box215_corrected
    {
      get => !SAP_Module.CalcRound ? this._Box215_corrected : Math.Round(this._Box215_corrected, SAP_Module.RoundFigure);
      set => this._Box215_corrected = value;
    }

    public double Box215_High_corrected { get; set; }

    public double Box215_High_factor { get; set; }

    public double Box215_Dual_corrected { get; set; }

    public double Box215_Dual_factor { get; set; }

    public double Box215_factor
    {
      get => !SAP_Module.CalcRound ? this._Box215_factor : Math.Round(this._Box215_factor, SAP_Module.RoundFigure);
      set => this._Box215_factor = value;
    }

    [Description("Efficiency of water heater")]
    [ReadOnly(true)]
    public double Box216
    {
      get => !SAP_Module.CalcRound ? this._Box216 : Math.Round(this._Box216, SAP_Module.RoundFigure);
      set => this._Box216 = value;
    }

    public Months Box217_m
    {
      get => this._Box217m;
      set => this._Box217m = value;
    }

    public Months Box217_mImm
    {
      get => this._Box217mImm;
      set => this._Box217mImm = value;
    }

    public Months Box218_m
    {
      get => this._Box218m;
      set => this._Box218m = value;
    }

    public Months Box219_m
    {
      get => this._Box219m;
      set => this._Box219m = value;
    }

    [Description("Fuel for water heating")]
    [ReadOnly(true)]
    public double Box219
    {
      get => !SAP_Module.CalcRound ? this._Box219 : Math.Round(this._Box219, SAP_Module.RoundFigure);
      set => this._Box219 = value;
    }

    [Description("Bill Info Fuel for water heating")]
    [ReadOnly(true)]
    public double Box219_corrected
    {
      get => !SAP_Module.CalcRound ? this._Box219_corrected : Math.Round(this._Box219_corrected, SAP_Module.RoundFigure);
      set => this._Box219_corrected = value;
    }

    public double Box219_High_corrected { get; set; }

    public double Box219_High_factor { get; set; }

    public double Box219_Dual_corrected { get; set; }

    public double Box219_Dual_factor { get; set; }

    public double Box219_factor
    {
      get => !SAP_Module.CalcRound ? this._Box219_factor : Math.Round(this._Box219_factor, SAP_Module.RoundFigure);
      set => this._Box219_factor = value;
    }

    [ReadOnly(true)]
    public Months Box219_mImm => this._Box219mImm;

    [Description("Fuel for water heating")]
    [ReadOnly(true)]
    public double Box219Imm
    {
      get => !SAP_Module.CalcRound ? this._Box219Imm : Math.Round(this._Box219Imm, SAP_Module.RoundFigure);
      set => this._Box219Imm = value;
    }

    [Description("Bill Info Fuel for water heating")]
    [ReadOnly(true)]
    public double Box219Imm_corrected
    {
      get => !SAP_Module.CalcRound ? this._Box219Imm_corrected : Math.Round(this._Box219Imm_corrected, SAP_Module.RoundFigure);
      set => this._Box219Imm_corrected = value;
    }

    public double Box219Imm_High_corrected { get; set; }

    public double Box219Imm_High_factor { get; set; }

    public double Box219Imm_factor
    {
      get => !SAP_Module.CalcRound ? this._Box219Imm_factor : Math.Round(this._Box219Imm_factor, SAP_Module.RoundFigure);
      set => this._Box219Imm_factor = value;
    }

    public double Box219a { get; set; }

    public double Box219a_corrected { get; set; }

    public double Box219a_High_corrected { get; set; }

    public double Box219a_High_factor { get; set; }

    public double Box219a_factor { get; set; }

    [ReadOnly(true)]
    public Months Box220_m => this._Box220m;

    [ReadOnly(true)]
    public Months Box221_m => this._Box221m;

    [Description("Energy required for space cooling")]
    [ReadOnly(true)]
    public double Box221
    {
      get => !SAP_Module.CalcRound ? this._Box221 : Math.Round(this._Box221, SAP_Module.RoundFigure);
      set => this._Box221 = value;
    }

    [Description("Mechanical ventilation - balanced, extract or positive input from outside")]
    [ReadOnly(true)]
    public double Box230a
    {
      get => !SAP_Module.CalcRound ? this._Box230a : Math.Round(this._Box230a, SAP_Module.RoundFigure);
      set => this._Box230a = value;
    }

    [Description("Warm air heating system fans")]
    [ReadOnly(true)]
    public double Box230b
    {
      get => !SAP_Module.CalcRound ? this._Box230b : Math.Round(this._Box230b, SAP_Module.RoundFigure);
      set => this._Box230b = value;
    }

    [Description("Central heating pump")]
    [ReadOnly(true)]
    public double Box230c
    {
      get => !SAP_Module.CalcRound ? this._Box230c : Math.Round(this._Box230c, SAP_Module.RoundFigure);
      set => this._Box230c = value;
    }

    [Description("Oil boiler pump")]
    [ReadOnly(true)]
    public double Box230d
    {
      get => !SAP_Module.CalcRound ? this._Box230d : Math.Round(this._Box230d, SAP_Module.RoundFigure);
      set => this._Box230d = value;
    }

    [Description("Boiler with a fan-assisted flue")]
    [ReadOnly(true)]
    public double Box230e
    {
      get => !SAP_Module.CalcRound ? this._Box230e : Math.Round(this._Box230e, SAP_Module.RoundFigure);
      set => this._Box230e = value;
    }

    [Description("Maintaining electric keep-hot facility for gas combi boiler")]
    [ReadOnly(true)]
    public double Box230f
    {
      get => !SAP_Module.CalcRound ? this._Box230f : Math.Round(this._Box230f, SAP_Module.RoundFigure);
      set => this._Box230f = value;
    }

    [Description("Pump for solar water heating")]
    [ReadOnly(true)]
    public double Box230g
    {
      get => !SAP_Module.CalcRound ? this._Box230g : Math.Round(this._Box230g, SAP_Module.RoundFigure);
      set => this._Box230g = value;
    }

    [Description("WWHRS Pump")]
    [ReadOnly(true)]
    public double Box230h
    {
      get => !SAP_Module.CalcRound ? this._Box230h : Math.Round(this._Box230h, SAP_Module.RoundFigure);
      set => this._Box230h = value;
    }

    [Description("Total electricity for 230a to 230g, kWh/year")]
    [ReadOnly(true)]
    public double Box231
    {
      get => !SAP_Module.CalcRound ? this._Box231 : Math.Round(this._Box231, SAP_Module.RoundFigure);
      set => this._Box231 = value;
    }

    [Description("Bill Info Total electricity for 230a to 230g, kWh/year")]
    [ReadOnly(true)]
    public double Box231_corrected
    {
      get => !SAP_Module.CalcRound ? this._Box231_corrected : Math.Round(this._Box231_corrected, SAP_Module.RoundFigure);
      set => this._Box231_corrected = value;
    }

    public double Box231_High_corrected { get; set; }

    public double Box231_High_factor { get; set; }

    public double Box231_factor
    {
      get => !SAP_Module.CalcRound ? this._Box231_factor : Math.Round(this._Box231_factor, SAP_Module.RoundFigure);
      set => this._Box231_factor = value;
    }

    [Description("Electricity for lighting")]
    [ReadOnly(true)]
    public double Box232
    {
      get => !SAP_Module.CalcRound ? this._Box232 : Math.Round(this._Box232, SAP_Module.RoundFigure);
      set => this._Box232 = value;
    }

    [Description("Bill Info Electricity for lighting")]
    [ReadOnly(true)]
    public double Box232_corrected
    {
      get => !SAP_Module.CalcRound ? this._Box232_corrected : Math.Round(this._Box232_corrected, SAP_Module.RoundFigure);
      set => this._Box232_corrected = value;
    }

    public double Box232_High_corrected { get; set; }

    public double Box232_High_factor { get; set; }

    public double Box232_factor
    {
      get => !SAP_Module.CalcRound ? this._Box232_factor : Math.Round(this._Box232_factor, SAP_Module.RoundFigure);
      set => this._Box232_factor = value;
    }

    [Description("Electricity for Appliances")]
    [ReadOnly(true)]
    public double Box232a
    {
      get => !SAP_Module.CalcRound ? this._Box232a : Math.Round(this._Box232a, SAP_Module.RoundFigure);
      set => this._Box232a = value;
    }

    [Description("Bill Info Electricity for Appliances")]
    [ReadOnly(true)]
    public double Box232a_corrected
    {
      get => !SAP_Module.CalcRound ? this._Box232a_corrected : Math.Round(this._Box232a_corrected, SAP_Module.RoundFigure);
      set => this._Box232a_corrected = value;
    }

    public double Box232a_High_corrected { get; set; }

    public double Box232a_High_factor { get; set; }

    public double Box232a_factor
    {
      get => !SAP_Module.CalcRound ? this._Box232a_factor : Math.Round(this._Box232a_factor, SAP_Module.RoundFigure);
      set => this._Box232a_factor = value;
    }

    [Description("Electric for Cooking")]
    [ReadOnly(true)]
    public double Box232b
    {
      get => !SAP_Module.CalcRound ? this._Box232b : Math.Round(this._Box232b, SAP_Module.RoundFigure);
      set => this._Box232b = value;
    }

    [Description("Bill Info Electric for Cooking")]
    [ReadOnly(true)]
    public double Box232b_corrected
    {
      get => !SAP_Module.CalcRound ? this._Box232b_corrected : Math.Round(this._Box232b_corrected, SAP_Module.RoundFigure);
      set => this._Box232b_corrected = value;
    }

    public double Box232b_High_corrected { get; set; }

    public double Box232b_High_factor { get; set; }

    public double Box232b_factor
    {
      get => !SAP_Module.CalcRound ? this._Box232b_factor : Math.Round(this._Box232b_factor, SAP_Module.RoundFigure);
      set => this._Box232b_factor = value;
    }

    [Description("Gas for Cooking")]
    [ReadOnly(true)]
    public double Box232c
    {
      get => !SAP_Module.CalcRound ? this._Box232c : Math.Round(this._Box232c, SAP_Module.RoundFigure);
      set => this._Box232c = value;
    }

    [Description("Bill Info Gas for Cooking")]
    [ReadOnly(true)]
    public double Box232c_corrected
    {
      get => !SAP_Module.CalcRound ? this._Box232c_corrected : Math.Round(this._Box232c_corrected, SAP_Module.RoundFigure);
      set => this._Box232c_corrected = value;
    }

    public double Box232c_High_factor { get; set; }

    public double Box232c_factor
    {
      get => !SAP_Module.CalcRound ? this._Box232c_factor : Math.Round(this._Box232c_factor, SAP_Module.RoundFigure);
      set => this._Box232c_factor = value;
    }

    [Description("Electricity for showers")]
    [ReadOnly(true)]
    public double Box232e
    {
      get => !SAP_Module.CalcRound ? this._Box232e : Math.Round(this._Box232e, SAP_Module.RoundFigure);
      set => this._Box232e = value;
    }

    [Description("Electricity for showers Corrected")]
    [ReadOnly(true)]
    public double Box232e_corrected
    {
      get => !SAP_Module.CalcRound ? this._Box232e_corrected : Math.Round(this._Box232e_corrected, SAP_Module.RoundFigure);
      set => this._Box232e_corrected = value;
    }

    public double Box232e_factor
    {
      get => !SAP_Module.CalcRound ? this._Box232e_factor : Math.Round(this._Box232e_factor, SAP_Module.RoundFigure);
      set => this._Box232e_factor = value;
    }

    [Description("Number of Photovoltaic Elements")]
    [ReadOnly(true)]
    public int Box233_Count
    {
      get => this._Box233 == null ? 0 : this._Box233.Length;
      set
      {
        double[]& local;
        double[] numArray = (double[]) Utils.CopyArray((Array) ^(local = ref this._Box233), (Array) new double[checked (value - 1 + 1)]);
        local = numArray;
      }
    }

    public double get_Box233_Parts(int index) => !SAP_Module.CalcRound ? this._Box233[index] : Math.Round(this._Box233[index], SAP_Module.RoundFigure);

    public void set_Box233_Parts(int index, double value) => this._Box233[index] = value;

    [Description("Electricity generated by PVs")]
    [ReadOnly(true)]
    public double[] Box233_Parts => this._Box233;

    [Description("Electricity generated by PVs")]
    [ReadOnly(true)]
    public double Box233
    {
      get
      {
        if (this._Box233 == null)
          return 0.0;
        int num1 = checked (this._Box233.Length - 1);
        int index = 0;
        double num2;
        while (index <= num1)
        {
          num2 += this._Box233[index];
          checked { ++index; }
        }
        return !SAP_Module.CalcRound ? num2 : Math.Round(num2, SAP_Module.RoundFigure);
      }
    }

    public double Box233_OA { get; set; }

    [Description("Number of wind turbine Elements")]
    [ReadOnly(true)]
    public int Box234_Count
    {
      get => this._Box234 == null ? 0 : this._Box234.Length;
      set
      {
        double[]& local;
        double[] numArray = (double[]) Utils.CopyArray((Array) ^(local = ref this._Box234), (Array) new double[checked (value - 1 + 1)]);
        local = numArray;
      }
    }

    public double get_Box234_Parts(int index) => !SAP_Module.CalcRound ? this._Box234[index] : Math.Round(this._Box234[index], SAP_Module.RoundFigure);

    public void set_Box234_Parts(int index, double value) => this._Box234[index] = value;

    [Description("Electricity generated by wind turbine")]
    [ReadOnly(true)]
    public double[] Box234_Parts => this._Box234;

    [Description("Electricity generated by wind turbine")]
    [ReadOnly(true)]
    public double Box234
    {
      get
      {
        if (this._Box234 == null)
          return 0.0;
        int num1 = checked (this._Box234.Length - 1);
        int index = 0;
        double num2;
        while (index <= num1)
        {
          num2 += this._Box234[index];
          checked { ++index; }
        }
        return !SAP_Module.CalcRound ? num2 : Math.Round(num2, SAP_Module.RoundFigure);
      }
    }

    public double Box234_OA { get; set; }

    [Description("Electricity used or net electricity generated by micro-CHP")]
    [ReadOnly(true)]
    public double Box235
    {
      get => !SAP_Module.CalcRound ? this._Box235 : Math.Round(this._Box235, SAP_Module.RoundFigure);
      set => this._Box235 = value;
    }

    public double Box235_OA { get; set; }

    [Description("Hydro-electric generation")]
    [ReadOnly(true)]
    public double Box235a
    {
      get => !SAP_Module.CalcRound ? this._Box235a : Math.Round(this._Box235a, SAP_Module.RoundFigure);
      set => this._Box235a = value;
    }

    public Energy_Requirements_9a2012.AppendixQ_Items get_AppendixQ_Item(
      int Index)
    {
      if (this._AppendixQ_Item[Index] == null)
        this._AppendixQ_Item[Index] = new Energy_Requirements_9a2012.AppendixQ_Items();
      return this._AppendixQ_Item[Index];
    }

    public void set_AppendixQ_Item(int Index, Energy_Requirements_9a2012.AppendixQ_Items value)
    {
      if (this._AppendixQ_Item[Index] == null)
        this._AppendixQ_Item[Index] = new Energy_Requirements_9a2012.AppendixQ_Items();
      this._AppendixQ_Item[Index] = value;
    }

    [Description("")]
    [ReadOnly(true)]
    public Energy_Requirements_9a2012.AppendixQ_Items[] AppendixQ_Item => this._AppendixQ_Item;

    public int AppendixQ_Item_Count
    {
      set
      {
        this._AppendixQ_Item = new Energy_Requirements_9a2012.AppendixQ_Items[checked (value - 1 + 1)];
        int num = checked (value - 1);
        int index = 0;
        while (index <= num)
        {
          this._AppendixQ_Item[index] = new Energy_Requirements_9a2012.AppendixQ_Items();
          checked { ++index; }
        }
      }
    }

    [TypeConverter(typeof (ExpandableObjectConverter))]
    public class AppendixQ_Items
    {
      private double _Energy_Saved;
      private double _Energy_Used;
      private string _Description;
      private string _Fuel_Used;
      private string _Fuel_Saved;

      public override string ToString() => "AppendixQ Items";

      [Description("Description")]
      [ReadOnly(true)]
      public string Description
      {
        get => this._Description;
        set => this._Description = value;
      }

      [Description("Fuel Saved")]
      [ReadOnly(true)]
      public string Fuel_Saved
      {
        get => this._Fuel_Saved;
        set => this._Fuel_Saved = value;
      }

      [Description("Energy Saved")]
      [ReadOnly(true)]
      public double Energy_Saved
      {
        get => !SAP_Module.CalcRound ? this._Energy_Saved : Math.Round(this._Energy_Saved, SAP_Module.RoundFigure);
        set => this._Energy_Saved = value;
      }

      [Description("Fuel Used")]
      [ReadOnly(true)]
      public string Fuel_Used
      {
        get => this._Fuel_Used;
        set => this._Fuel_Used = value;
      }

      [Description("Energy Used")]
      [ReadOnly(true)]
      public double Energy_Used
      {
        get => !SAP_Module.CalcRound ? this._Energy_Used : Math.Round(this._Energy_Used, SAP_Module.RoundFigure);
        set => this._Energy_Used = value;
      }
    }
  }
}
