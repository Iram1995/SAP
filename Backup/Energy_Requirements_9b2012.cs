
// Type: SAP2012.Energy_Requirements_9b2012




using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;

namespace SAP2012
{
  [TypeConverter(typeof (ExpandableObjectConverter))]
  public class Energy_Requirements_9b2012
  {
    private double _Box301;
    private double _Box302;
    private double _Box303a;
    private double _Box303b;
    private double _Box303c;
    private double _Box303d;
    private double _Box303e;
    private double _Box303aW;
    private double _Box303bW;
    private double _Box303cW;
    private double _Box303dW;
    private double _Box303eW;
    private double _Box304a;
    private double _Box304b;
    private double _Box304c;
    private double _Box304d;
    private double _Box304e;
    private double _Box305;
    private double _Box305a;
    private double _Box306;
    private double _Box306W;
    private double _Box307a;
    private double _Box307b;
    private double _Box307c;
    private double _Box307d;
    private double _Box307e;
    private double _Box308;
    private double _Box309;
    private double _Box310a;
    private double _Box310b;
    private double _Box310c;
    private double _Box310d;
    private double _Box310e;
    private double _Box310aW;
    private double _Box310bW;
    private double _Box310cW;
    private double _Box310dW;
    private double _Box310eW;
    private double _Box311;
    private double _Box312;
    private double _Box313;
    private double _Box313W;
    private double _Box314;
    private double _Box315;
    private double _Box330a;
    private double _Box330b;
    private double _Box330g;
    private double _Box331;
    private double _Box332;
    private double[] _Box333;
    private double[] _Box334;
    private double _Box235;
    private double _Box335a;
    private Energy_Requirements_9b2012.AppendixQ_Items[] _AppendixQ_Item;

    public override string ToString() => "9b. Energy requirements - Community heating scheme";

    [Description("Fraction of space heat from secondary/supplementary heating")]
    [ReadOnly(true)]
    public double Box301
    {
      get => !SAP_Module.CalcRound ? this._Box301 : Math.Round(this._Box301, SAP_Module.RoundFigure);
      set => this._Box301 = value;
    }

    [Description("Fraction of space heat from community system")]
    [ReadOnly(true)]
    public double Box302
    {
      get => !SAP_Module.CalcRound ? this._Box302 : Math.Round(this._Box302, SAP_Module.RoundFigure);
      set => this._Box302 = value;
    }

    [Description("Fraction of heat from community CHP")]
    [ReadOnly(true)]
    public double Box303a
    {
      get => !SAP_Module.CalcRound ? this._Box303a : Math.Round(this._Box303a, SAP_Module.RoundFigure);
      set => this._Box303a = value;
    }

    [Description("Fraction of heat from community heat source 2")]
    [ReadOnly(true)]
    public double Box303b
    {
      get => !SAP_Module.CalcRound ? this._Box303b : Math.Round(this._Box303b, SAP_Module.RoundFigure);
      set => this._Box303b = value;
    }

    [Description("Fraction of heat from community heat source 3")]
    [ReadOnly(true)]
    public double Box303c
    {
      get => !SAP_Module.CalcRound ? this._Box303c : Math.Round(this._Box303c, SAP_Module.RoundFigure);
      set => this._Box303c = value;
    }

    [Description("Fraction of heat from community heat source 4")]
    [ReadOnly(true)]
    public double Box303d
    {
      get => !SAP_Module.CalcRound ? this._Box303d : Math.Round(this._Box303d, SAP_Module.RoundFigure);
      set => this._Box303d = value;
    }

    [Description("Fraction of heat from community heat source 4")]
    [ReadOnly(true)]
    public double Box303e
    {
      get => !SAP_Module.CalcRound ? this._Box303e : Math.Round(this._Box303e, SAP_Module.RoundFigure);
      set => this._Box303e = value;
    }

    [Description("Fraction of heat from community CHP")]
    [ReadOnly(true)]
    public double Box303aW
    {
      get => !SAP_Module.CalcRound ? this._Box303aW : Math.Round(this._Box303aW, SAP_Module.RoundFigure);
      set => this._Box303aW = value;
    }

    [Description("Fraction of heat from community heat source 2")]
    [ReadOnly(true)]
    public double Box303bW
    {
      get => !SAP_Module.CalcRound ? this._Box303bW : Math.Round(this._Box303bW, SAP_Module.RoundFigure);
      set => this._Box303bW = value;
    }

    [Description("Fraction of heat from community heat source 3")]
    [ReadOnly(true)]
    public double Box303cW
    {
      get => !SAP_Module.CalcRound ? this._Box303cW : Math.Round(this._Box303cW, SAP_Module.RoundFigure);
      set => this._Box303cW = value;
    }

    [Description("Fraction of heat from community heat source 4")]
    [ReadOnly(true)]
    public double Box303dW
    {
      get => !SAP_Module.CalcRound ? this._Box303dW : Math.Round(this._Box303dW, SAP_Module.RoundFigure);
      set => this._Box303dW = value;
    }

    [Description("Fraction of heat from community heat source 4")]
    [ReadOnly(true)]
    public double Box303eW
    {
      get => !SAP_Module.CalcRound ? this._Box303eW : Math.Round(this._Box303eW, SAP_Module.RoundFigure);
      set => this._Box303eW = value;
    }

    [Description("Fraction of total heating from community CHP")]
    [ReadOnly(true)]
    public double Box304a
    {
      get => !SAP_Module.CalcRound ? this._Box304a : Math.Round(this._Box304a, SAP_Module.RoundFigure);
      set => this._Box304a = value;
    }

    [Description("Fraction of total heating from community heat source 2")]
    [ReadOnly(true)]
    public double Box304b
    {
      get => !SAP_Module.CalcRound ? this._Box304b : Math.Round(this._Box304b, SAP_Module.RoundFigure);
      set => this._Box304b = value;
    }

    [Description("Fraction of total heating from community heat source 3")]
    [ReadOnly(true)]
    public double Box304c
    {
      get => !SAP_Module.CalcRound ? this._Box304c : Math.Round(this._Box304c, SAP_Module.RoundFigure);
      set => this._Box304c = value;
    }

    [Description("Fraction of total heating from community heat source 4")]
    [ReadOnly(true)]
    public double Box304d
    {
      get => !SAP_Module.CalcRound ? this._Box304d : Math.Round(this._Box304d, SAP_Module.RoundFigure);
      set => this._Box304d = value;
    }

    [Description("Fraction of total heating from community heat source 5")]
    [ReadOnly(true)]
    public double Box304e
    {
      get => !SAP_Module.CalcRound ? this._Box304e : Math.Round(this._Box304e, SAP_Module.RoundFigure);
      set => this._Box304e = value;
    }

    [Description("Factor for control and charging method for community space heating")]
    [ReadOnly(true)]
    public double Box305
    {
      get => !SAP_Module.CalcRound ? this._Box305 : Math.Round(this._Box305, SAP_Module.RoundFigure);
      set => this._Box305 = value;
    }

    [Description("Factor for control and charging method for community water heating")]
    [ReadOnly(true)]
    public double Box305a
    {
      get => !SAP_Module.CalcRound ? this._Box305a : Math.Round(this._Box305a, SAP_Module.RoundFigure);
      set => this._Box305a = value;
    }

    [Description("Distribution loss factor")]
    [ReadOnly(true)]
    public double Box306
    {
      get => !SAP_Module.CalcRound ? this._Box306 : Math.Round(this._Box306, SAP_Module.RoundFigure);
      set => this._Box306 = value;
    }

    [Description("Distribution loss factor")]
    [ReadOnly(true)]
    public double Box306W
    {
      get => !SAP_Module.CalcRound ? this._Box306W : Math.Round(this._Box306W, SAP_Module.RoundFigure);
      set => this._Box306W = value;
    }

    [Description("Space heat from CHP")]
    [ReadOnly(true)]
    public double Box307a
    {
      get => !SAP_Module.CalcRound ? this._Box307a : Math.Round(this._Box307a, SAP_Module.RoundFigure);
      set => this._Box307a = value;
    }

    public double Box307a_factor { get; set; }

    [Description("Space heat from heat source 2")]
    [ReadOnly(true)]
    public double Box307b
    {
      get => !SAP_Module.CalcRound ? this._Box307b : Math.Round(this._Box307b, SAP_Module.RoundFigure);
      set => this._Box307b = value;
    }

    [Description("Space heat from heat source 3")]
    [ReadOnly(true)]
    public double Box307c
    {
      get => !SAP_Module.CalcRound ? this._Box307c : Math.Round(this._Box307c, SAP_Module.RoundFigure);
      set => this._Box307c = value;
    }

    [Description("Space heat from heat source 4")]
    [ReadOnly(true)]
    public double Box307d
    {
      get => !SAP_Module.CalcRound ? this._Box307d : Math.Round(this._Box307d, SAP_Module.RoundFigure);
      set => this._Box307d = value;
    }

    [Description("Space heat from heat source 5")]
    [ReadOnly(true)]
    public double Box307e
    {
      get => !SAP_Module.CalcRound ? this._Box307e : Math.Round(this._Box307e, SAP_Module.RoundFigure);
      set => this._Box307e = value;
    }

    [Description("Efficiency of secondary/supplementary heating system in %")]
    [ReadOnly(true)]
    public double Box308
    {
      get => !SAP_Module.CalcRound ? this._Box308 : Math.Round(this._Box308, SAP_Module.RoundFigure);
      set => this._Box308 = value;
    }

    [Description("Space heating requirement from secondary/supplementary system")]
    [ReadOnly(true)]
    public double Box309
    {
      get => !SAP_Module.CalcRound ? this._Box309 : Math.Round(this._Box309, SAP_Module.RoundFigure);
      set => this._Box309 = value;
    }

    public double Box309_corrected { get; set; }

    public double Box309_Dual_corrected { get; set; }

    public double Box309_Dual_factor { get; set; }

    public double Box309_factor { get; set; }

    public double Box309_High_corrected { get; set; }

    public double Box309_High_factor { get; set; }

    [Description("Water heat from CHP")]
    [ReadOnly(true)]
    public double Box310a
    {
      get => !SAP_Module.CalcRound ? this._Box310a : Math.Round(this._Box310a, SAP_Module.RoundFigure);
      set => this._Box310a = value;
    }

    public double Box310a_factor { get; set; }

    [Description("Water heat from heat source 2")]
    [ReadOnly(true)]
    public double Box310b
    {
      get => !SAP_Module.CalcRound ? this._Box310b : Math.Round(this._Box310b, SAP_Module.RoundFigure);
      set => this._Box310b = value;
    }

    [Description("Water heat from heat source 3")]
    [ReadOnly(true)]
    public double Box310c
    {
      get => !SAP_Module.CalcRound ? this._Box310c : Math.Round(this._Box310c, SAP_Module.RoundFigure);
      set => this._Box310c = value;
    }

    [Description("Water heat from heat source 4")]
    [ReadOnly(true)]
    public double Box310d
    {
      get => !SAP_Module.CalcRound ? this._Box310d : Math.Round(this._Box310d, SAP_Module.RoundFigure);
      set => this._Box310d = value;
    }

    [Description("Water heat from heat source 5")]
    [ReadOnly(true)]
    public double Box310e
    {
      get => !SAP_Module.CalcRound ? this._Box310e : Math.Round(this._Box310e, SAP_Module.RoundFigure);
      set => this._Box310e = value;
    }

    [Description("Water heat from CHP")]
    [ReadOnly(true)]
    public double Box310aW
    {
      get => !SAP_Module.CalcRound ? this._Box310aW : Math.Round(this._Box310aW, SAP_Module.RoundFigure);
      set => this._Box310aW = value;
    }

    [Description("Water heat from heat source 2")]
    [ReadOnly(true)]
    public double Box310bW
    {
      get => !SAP_Module.CalcRound ? this._Box310bW : Math.Round(this._Box310bW, SAP_Module.RoundFigure);
      set => this._Box310bW = value;
    }

    [Description("Water heat from heat source 3")]
    [ReadOnly(true)]
    public double Box310cW
    {
      get => !SAP_Module.CalcRound ? this._Box310cW : Math.Round(this._Box310cW, SAP_Module.RoundFigure);
      set => this._Box310cW = value;
    }

    [Description("Water heat from heat source 4")]
    [ReadOnly(true)]
    public double Box310dW
    {
      get => !SAP_Module.CalcRound ? this._Box310dW : Math.Round(this._Box310dW, SAP_Module.RoundFigure);
      set => this._Box310dW = value;
    }

    [Description("Water heat from heat source 5")]
    [ReadOnly(true)]
    public double Box310eW
    {
      get => !SAP_Module.CalcRound ? this._Box310eW : Math.Round(this._Box310eW, SAP_Module.RoundFigure);
      set => this._Box310eW = value;
    }

    [Description("Efficiency of water heater")]
    [ReadOnly(true)]
    public double Box311
    {
      get => !SAP_Module.CalcRound ? this._Box311 : Math.Round(this._Box311, SAP_Module.RoundFigure);
      set => this._Box311 = value;
    }

    [Description("Water heated by immersion or instantaneous heater")]
    [ReadOnly(true)]
    public double Box312
    {
      get => !SAP_Module.CalcRound ? this._Box312 : Math.Round(this._Box312, SAP_Module.RoundFigure);
      set => this._Box312 = value;
    }

    public double Box312_corrected { get; set; }

    public double Box312_factor { get; set; }

    public double Box312_High_corrected { get; set; }

    public double Box312_High_factor { get; set; }

    public double Box312a { get; set; }

    public double Box312a_corrected { get; set; }

    public double Box312a_factor { get; set; }

    public double Box312a_High_corrected { get; set; }

    public double Box312a_High_factor { get; set; }

    [Description("Electricity used for heat distribution")]
    [ReadOnly(true)]
    public double Box313
    {
      get => !SAP_Module.CalcRound ? this._Box313 : Math.Round(this._Box313, SAP_Module.RoundFigure);
      set => this._Box313 = value;
    }

    [Description("Electricity used for heat distribution")]
    [ReadOnly(true)]
    public double Box313W
    {
      get => !SAP_Module.CalcRound ? this._Box313W : Math.Round(this._Box313W, SAP_Module.RoundFigure);
      set => this._Box313W = value;
    }

    [Description("Cooling System Energy Efficiency Ratio")]
    [ReadOnly(true)]
    public double Box314
    {
      get => !SAP_Module.CalcRound ? this._Box314 : Math.Round(this._Box314, SAP_Module.RoundFigure);
      set => this._Box314 = value;
    }

    [Description("Space cooling")]
    [ReadOnly(true)]
    public double Box315
    {
      get => !SAP_Module.CalcRound ? this._Box315 : Math.Round(this._Box315, SAP_Module.RoundFigure);
      set => this._Box315 = value;
    }

    [Description("mechanical ventilation - balanced, extract or positive input from outside")]
    [ReadOnly(true)]
    public double Box330a
    {
      get => !SAP_Module.CalcRound ? this._Box330a : Math.Round(this._Box330a, SAP_Module.RoundFigure);
      set => this._Box330a = value;
    }

    [Description("warm air heating system fans")]
    [ReadOnly(true)]
    public double Box330b
    {
      get => !SAP_Module.CalcRound ? this._Box330b : Math.Round(this._Box330b, SAP_Module.RoundFigure);
      set => this._Box330b = value;
    }

    [Description("pump for solar water heating")]
    [ReadOnly(true)]
    public double Box330g
    {
      get => !SAP_Module.CalcRound ? this._Box330g : Math.Round(this._Box330g, SAP_Module.RoundFigure);
      set => this._Box330g = value;
    }

    [Description("Total electricity for the above, kWh/year")]
    [ReadOnly(true)]
    public double Box331
    {
      get => !SAP_Module.CalcRound ? this._Box331 : Math.Round(this._Box331, SAP_Module.RoundFigure);
      set => this._Box331 = value;
    }

    public double Box331_corrected { get; set; }

    public double Box331_factor { get; set; }

    public double Box331_High_corrected { get; set; }

    public double Box331_High_factor { get; set; }

    [Description("Energy for lighting (calculated in Appendix L)")]
    [ReadOnly(true)]
    public double Box332
    {
      get => !SAP_Module.CalcRound ? this._Box332 : Math.Round(this._Box332, SAP_Module.RoundFigure);
      set => this._Box332 = value;
    }

    public double Box332_corrected { get; set; }

    public double Box332_factor { get; set; }

    public double Box332_High_corrected { get; set; }

    public double Box332_High_factor { get; set; }

    public double Box332a { get; set; }

    public double Box332a_corrected { get; set; }

    public double Box332a_factor { get; set; }

    public double Box332a_High_corrected { get; set; }

    public double Box332a_High_factor { get; set; }

    public double Box332b { get; set; }

    public double Box332b_corrected { get; set; }

    public double Box332b_factor { get; set; }

    public double Box332b_High_corrected { get; set; }

    public double Box332b_High_factor { get; set; }

    public double Box332c { get; set; }

    public double Box332c_corrected { get; set; }

    public double Box332c_factor { get; set; }

    [Description("Number of Photovoltaic Elements")]
    [ReadOnly(true)]
    public int Box333_Count
    {
      get => this._Box333 == null ? 0 : this._Box333.Length;
      set
      {
        double[]& local;
        double[] numArray = (double[]) Utils.CopyArray((Array) ^(local = ref this._Box333), (Array) new double[checked (value - 1 + 1)]);
        local = numArray;
      }
    }

    public double get_Box333_Parts(int index) => !SAP_Module.CalcRound ? this._Box333[index] : Math.Round(this._Box333[index], SAP_Module.RoundFigure);

    public void set_Box333_Parts(int index, double value) => this._Box333[index] = value;

    [Description("Electricity generated by PVs")]
    [ReadOnly(true)]
    public double[] Box233_Parts => this._Box333;

    [Description("Electricity generated by PVs")]
    [ReadOnly(true)]
    public double Box333
    {
      get
      {
        if (this._Box333 == null)
          return 0.0;
        int num1 = checked (this._Box333.Length - 1);
        int index = 0;
        double num2;
        while (index <= num1)
        {
          num2 += this._Box333[index];
          checked { ++index; }
        }
        return !SAP_Module.CalcRound ? num2 : Math.Round(num2, SAP_Module.RoundFigure);
      }
    }

    public double Box333_OA { get; set; }

    [Description("Number of wind turbine Elements")]
    [ReadOnly(true)]
    public int Box334_Count
    {
      get => this._Box334 == null ? 0 : this._Box334.Length;
      set
      {
        double[]& local;
        double[] numArray = (double[]) Utils.CopyArray((Array) ^(local = ref this._Box334), (Array) new double[checked (value - 1 + 1)]);
        local = numArray;
      }
    }

    [Description("Electricity generated by hydro-electric generator")]
    [ReadOnly(true)]
    public double Box335a
    {
      get => !SAP_Module.CalcRound ? this._Box335a : Math.Round(this._Box335a, SAP_Module.RoundFigure);
      set => this._Box335a = value;
    }

    public double get_Box334_Parts(int index) => !SAP_Module.CalcRound ? this._Box334[index] : Math.Round(this._Box334[index], SAP_Module.RoundFigure);

    public void set_Box334_Parts(int index, double value) => this._Box334[index] = value;

    [Description("Electricity generated by wind turbine")]
    [ReadOnly(true)]
    public double[] Box334_Parts => this._Box334;

    [Description("Electricity generated by wind turbine")]
    [ReadOnly(true)]
    public double Box334
    {
      get
      {
        if (this._Box334 == null)
          return 0.0;
        int num1 = checked (this._Box334.Length - 1);
        int index = 0;
        double num2;
        while (index <= num1)
        {
          num2 += this._Box334[index];
          checked { ++index; }
        }
        return !SAP_Module.CalcRound ? num2 : Math.Round(num2, SAP_Module.RoundFigure);
      }
    }

    public double Box334_OA { get; set; }

    public Energy_Requirements_9b2012.AppendixQ_Items get_AppendixQ_Item(
      int Index)
    {
      if (this._AppendixQ_Item[Index] == null)
        this._AppendixQ_Item[Index] = new Energy_Requirements_9b2012.AppendixQ_Items();
      return this._AppendixQ_Item[Index];
    }

    public void set_AppendixQ_Item(int Index, Energy_Requirements_9b2012.AppendixQ_Items value)
    {
      if (this._AppendixQ_Item[Index] == null)
        this._AppendixQ_Item[Index] = new Energy_Requirements_9b2012.AppendixQ_Items();
      this._AppendixQ_Item[Index] = value;
    }

    [Description("")]
    [ReadOnly(true)]
    public Energy_Requirements_9b2012.AppendixQ_Items[] AppendixQ_Item => this._AppendixQ_Item;

    public int AppendixQ_Item_Count
    {
      set
      {
        this._AppendixQ_Item = new Energy_Requirements_9b2012.AppendixQ_Items[checked (value - 1 + 1)];
        int num = checked (value - 1);
        int index = 0;
        while (index <= num)
        {
          this._AppendixQ_Item[index] = new Energy_Requirements_9b2012.AppendixQ_Items();
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
