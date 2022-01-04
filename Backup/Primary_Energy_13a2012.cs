
// Type: SAP2012.Primary_Energy_13a2012




using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;

namespace SAP2012
{
  [TypeConverter(typeof (ExpandableObjectConverter))]
  public class Primary_Energy_13a2012
  {
    private double _Box261E;
    private double _Box261;
    private double _Box262E;
    private double _Box262;
    private double _Box263E;
    private double _Box263;
    private double _Box264E;
    private double _Box264;
    private double _Box264EImm;
    private double _Box264Imm;
    private double _Box265;
    private double _Box266E;
    private double _Box266;
    private double _Box267E;
    private double _Box267;
    private double _Box268E;
    private double _Box268;
    private double _Box269;
    private double[] _Box269a;
    private double[] _Box269Ea;
    private Primary_Energy_13a2012.AppendixQ_Items[] _AppendixQ_Item;
    private double _Box270;
    private double _EI;
    private double _Box271;
    private double _Box272;
    private double _Box273;
    private int _EIRating;
    private string _EIBand;

    public override string ToString() => "13a. Primary Energy - for individual heating systems (including micro-CHP) and community heating without CHP";

    [Description("Space heating (main system 1) Emissions Factor")]
    [ReadOnly(true)]
    public double Box261E
    {
      get => !SAP_Module.CalcRound ? this._Box261E : Math.Round(this._Box261E, SAP_Module.RoundFigure);
      set => this._Box261E = value;
    }

    [Description("Space heating (main system 1) Emissions")]
    [ReadOnly(true)]
    public double Box261
    {
      get => !SAP_Module.CalcRound ? this._Box261 : Math.Round(this._Box261, SAP_Module.RoundFigure);
      set => this._Box261 = value;
    }

    [Description("Space heating (main system 2) Emissions Factor")]
    [ReadOnly(true)]
    public double Box262E
    {
      get => !SAP_Module.CalcRound ? this._Box262E : Math.Round(this._Box262E, SAP_Module.RoundFigure);
      set => this._Box262E = value;
    }

    [Description("Space heating (main system 2) Emissions")]
    [ReadOnly(true)]
    public double Box262
    {
      get => !SAP_Module.CalcRound ? this._Box262 : Math.Round(this._Box262, SAP_Module.RoundFigure);
      set => this._Box262 = value;
    }

    [Description("Space heating (secondary) Emissions Factor")]
    [ReadOnly(true)]
    public double Box263E
    {
      get => !SAP_Module.CalcRound ? this._Box263E : Math.Round(this._Box263E, SAP_Module.RoundFigure);
      set => this._Box263E = value;
    }

    [Description("Space heating (secondary) Emissions")]
    [ReadOnly(true)]
    public double Box263
    {
      get => !SAP_Module.CalcRound ? this._Box263 : Math.Round(this._Box263, SAP_Module.RoundFigure);
      set => this._Box263 = value;
    }

    [Description("Energy for water heating Emissions Factor")]
    [ReadOnly(true)]
    public double Box264E
    {
      get => !SAP_Module.CalcRound ? this._Box264E : Math.Round(this._Box264E, SAP_Module.RoundFigure);
      set => this._Box264E = value;
    }

    [Description("Energy for water heating Emissions")]
    [ReadOnly(true)]
    public double Box264
    {
      get => !SAP_Module.CalcRound ? this._Box264 : Math.Round(this._Box264, SAP_Module.RoundFigure);
      set => this._Box264 = value;
    }

    [Description("Energy for water heating Emissions Factor")]
    [ReadOnly(true)]
    public double Box264EImm
    {
      get => !SAP_Module.CalcRound ? this._Box264EImm : Math.Round(this._Box264EImm, SAP_Module.RoundFigure);
      set => this._Box264EImm = value;
    }

    [Description("Energy for water heating Emissions")]
    [ReadOnly(true)]
    public double Box264Imm
    {
      get => !SAP_Module.CalcRound ? this._Box264Imm : Math.Round(this._Box264Imm, SAP_Module.RoundFigure);
      set => this._Box264Imm = value;
    }

    [Description("Space and water heating")]
    [ReadOnly(true)]
    public double Box265
    {
      get => !SAP_Module.CalcRound ? this._Box265 : Math.Round(this._Box265, SAP_Module.RoundFigure);
      set => this._Box265 = value;
    }

    [Description("Space cooling Emissions Factor")]
    [ReadOnly(true)]
    public double Box266E
    {
      get => !SAP_Module.CalcRound ? this._Box266E : Math.Round(this._Box266E, SAP_Module.RoundFigure);
      set => this._Box266E = value;
    }

    [Description("Space cooling Emissions")]
    [ReadOnly(true)]
    public double Box266
    {
      get => !SAP_Module.CalcRound ? this._Box266 : Math.Round(this._Box266, SAP_Module.RoundFigure);
      set => this._Box266 = value;
    }

    [Description("Space cooling Emissions Factor")]
    [ReadOnly(true)]
    public double Box267E
    {
      get => !SAP_Module.CalcRound ? this._Box267E : Math.Round(this._Box267E, SAP_Module.RoundFigure);
      set => this._Box267E = value;
    }

    [Description("Space cooling Emissions")]
    [ReadOnly(true)]
    public double Box267
    {
      get => !SAP_Module.CalcRound ? this._Box267 : Math.Round(this._Box267, SAP_Module.RoundFigure);
      set => this._Box267 = value;
    }

    [Description("Space cooling Emissions Factor")]
    [ReadOnly(true)]
    public double Box268E
    {
      get => !SAP_Module.CalcRound ? this._Box268E : Math.Round(this._Box268E, SAP_Module.RoundFigure);
      set => this._Box268E = value;
    }

    [Description("Space cooling Emissions")]
    [ReadOnly(true)]
    public double Box268
    {
      get => !SAP_Module.CalcRound ? this._Box268 : Math.Round(this._Box268, SAP_Module.RoundFigure);
      set => this._Box268 = value;
    }

    [Description("Number of Energy saving/generation technologies")]
    [ReadOnly(true)]
    public int Box269_Count
    {
      get => this._Box269Ea == null ? 0 : this._Box269Ea.Length;
      set
      {
        double[]& local1;
        double[] numArray1 = (double[]) Utils.CopyArray((Array) ^(local1 = ref this._Box269Ea), (Array) new double[checked (value - 1 + 1)]);
        local1 = numArray1;
        double[]& local2;
        double[] numArray2 = (double[]) Utils.CopyArray((Array) ^(local2 = ref this._Box269a), (Array) new double[checked (value - 1 + 1)]);
        local2 = numArray2;
      }
    }

    [Description("Energy saving/generation Energy Factors")]
    [ReadOnly(true)]
    public double[] Box269_EFactors => this._Box269Ea;

    [Description("Energy saving/generation Energy")]
    [ReadOnly(true)]
    public double[] Box269_Emissions => this._Box269a;

    [Description("Energy saving/generation Energy")]
    [ReadOnly(true)]
    public double Box269
    {
      get
      {
        if (this._Box269a == null)
          return 0.0;
        int num1 = checked (this._Box269a.Length - 1);
        int index = 0;
        double num2;
        while (index <= num1)
        {
          num2 += this._Box269a[index];
          checked { ++index; }
        }
        return !SAP_Module.CalcRound ? num2 : Math.Round(num2, SAP_Module.RoundFigure);
      }
    }

    public double get_Box269_EFactors(int index) => !SAP_Module.CalcRound ? this._Box269Ea[index] : Math.Round(this._Box269Ea[index], SAP_Module.RoundFigure);

    public void set_Box269_EFactors(int index, double value) => this._Box269Ea[index] = value;

    public double get_Box252_Emissions(int index) => !SAP_Module.CalcRound ? this._Box269a[index] : Math.Round(this._Box269a[index], SAP_Module.RoundFigure);

    public void set_Box252_Emissions(int index, double value) => this._Box269a[index] = value;

    [Description("")]
    [ReadOnly(true)]
    public double Box270
    {
      get
      {
        if (this._AppendixQ_Item == null)
          return 0.0;
        int num = checked (this._AppendixQ_Item.Length - 1);
        int index = 0;
        float box270;
        while (index <= num)
        {
          box270 += (float) this._AppendixQ_Item[index].Energy_Saved_Energy;
          checked { ++index; }
        }
        return (double) box270;
      }
    }

    [Description("")]
    [ReadOnly(true)]
    public double Box271
    {
      get
      {
        if (this._AppendixQ_Item == null)
          return 0.0;
        int num = checked (this._AppendixQ_Item.Length - 1);
        int index = 0;
        float box271;
        while (index <= num)
        {
          box271 += (float) this._AppendixQ_Item[index].Energy_Used_Energy;
          checked { ++index; }
        }
        return (double) box271;
      }
    }

    public Primary_Energy_13a2012.AppendixQ_Items get_AppendixQ_Item(int Index)
    {
      if (this._AppendixQ_Item[Index] == null)
        this._AppendixQ_Item[Index] = new Primary_Energy_13a2012.AppendixQ_Items();
      return this._AppendixQ_Item[Index];
    }

    public void set_AppendixQ_Item(int Index, Primary_Energy_13a2012.AppendixQ_Items value)
    {
      if (this._AppendixQ_Item[Index] == null)
        this._AppendixQ_Item[Index] = new Primary_Energy_13a2012.AppendixQ_Items();
      this._AppendixQ_Item[Index] = value;
    }

    [Description("")]
    [ReadOnly(true)]
    public Primary_Energy_13a2012.AppendixQ_Items[] AppendixQ_Item => this._AppendixQ_Item;

    public int AppendixQ_Item_Count
    {
      set
      {
        this._AppendixQ_Item = new Primary_Energy_13a2012.AppendixQ_Items[checked (value - 1 + 1)];
        int num = checked (value - 1);
        int index = 0;
        while (index <= num)
        {
          this._AppendixQ_Item[index] = new Primary_Energy_13a2012.AppendixQ_Items();
          checked { ++index; }
        }
      }
    }

    [Description("Total Energy, kWh/year")]
    [ReadOnly(true)]
    public double Box272
    {
      get => !SAP_Module.CalcRound ? this._Box272 : Math.Round(this._Box272, SAP_Module.RoundFigure);
      set => this._Box272 = value;
    }

    [Description("")]
    [ReadOnly(true)]
    public double Box273
    {
      get => !SAP_Module.CalcRound ? this._Box273 : Math.Round(this._Box273, SAP_Module.RoundFigure);
      set => this._Box273 = value;
    }

    [TypeConverter(typeof (ExpandableObjectConverter))]
    public class AppendixQ_Items
    {
      private double _Energy_Saved_EF;
      private double _Energy_Saved_Emissions;
      private double _Energy_Used_EF;
      private double _Energy_Used_Emissions;

      public override string ToString() => "AppendixQ Items";

      [Description("Energy Saved Energy Factor")]
      [ReadOnly(true)]
      public double Energy_Saved_EF
      {
        get => !SAP_Module.CalcRound ? this._Energy_Saved_EF : Math.Round(this._Energy_Saved_EF, SAP_Module.RoundFigure);
        set => this._Energy_Saved_EF = value;
      }

      [Description("Energy Saved Energy")]
      [ReadOnly(true)]
      public double Energy_Saved_Energy
      {
        get => !SAP_Module.CalcRound ? this._Energy_Saved_Emissions : Math.Round(this._Energy_Saved_Emissions, SAP_Module.RoundFigure);
        set => this._Energy_Saved_Emissions = value;
      }

      [Description("Energy Used Energy Factor")]
      [ReadOnly(true)]
      public double Energy_Used_EF
      {
        get => !SAP_Module.CalcRound ? this._Energy_Used_EF : Math.Round(this._Energy_Used_EF, SAP_Module.RoundFigure);
        set => this._Energy_Used_EF = value;
      }

      [Description("Energy Used Energy")]
      [ReadOnly(true)]
      public double Energy_Used_Energy
      {
        get => !SAP_Module.CalcRound ? this._Energy_Used_Emissions : Math.Round(this._Energy_Used_Emissions, SAP_Module.RoundFigure);
        set => this._Energy_Used_Emissions = value;
      }
    }
  }
}
