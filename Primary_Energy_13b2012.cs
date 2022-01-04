
// Type: SAP2012.Primary_Energy_13b2012




using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;

namespace SAP2012
{
  [TypeConverter(typeof (ExpandableObjectConverter))]
  public class Primary_Energy_13b2012
  {
    private double _Box361;
    private double _Box362;
    private double _Box363En;
    private double _Box363E;
    private double _Box363;
    private double _Box364En;
    private double _Box364E;
    private double _Box364;
    private double _Box365En;
    private double _Box365E;
    private double _Box365;
    private double _Box366En;
    private double _Box366E;
    private double _Box366;
    private double _Box367a;
    private double _Box367b;
    private double _Box367c;
    private double _Box367d;
    private double _Box367e;
    private double _Box367_E;
    private double _Box367;
    private double _Box368E;
    private double _Box368;
    private double _Box369E;
    private double _Box369;
    private double _Box370E;
    private double _Box370;
    private double _Box371E;
    private double _Box371;
    private double _Box372E;
    private double _Box372;
    private double _Box361W;
    private double _Box362W;
    private double _Box363EnW;
    private double _Box363EW;
    private double _Box363W;
    private double _Box364EnW;
    private double _Box364EW;
    private double _Box364W;
    private double _Box365EnW;
    private double _Box365EW;
    private double _Box365W;
    private double _Box366EnW;
    private double _Box366EW;
    private double _Box366W;
    private double _Box367aW;
    private double _Box367bW;
    private double _Box367cW;
    private double _Box367dW;
    private double _Box367eW;
    private double _Box367_EW;
    private double _Box367W;
    private double _Box368EW;
    private double _Box368W;
    private double _Box369EW;
    private double _Box369W;
    private double _Box370EW;
    private double _Box370W;
    private double _Box371EW;
    private double _Box371W;
    private double _Box372EW;
    private double _Box372W;
    private double _Box373;
    private double _Box374E;
    private double _Box374;
    private double _Box375E;
    private double _Box375;
    private double _Box376;
    private double _Box377E;
    private double _Box377;
    private double _Box378E;
    private double _Box378;
    private double _Box379E;
    private double _Box379;
    private double _Box380E;
    private double _Box380;
    private double[] _Box380a;
    private double[] _Box380Ea;
    private Primary_Energy_13b2012.AppendixQ_Items[] _AppendixQ_Item;
    private double _Box383;

    public override string ToString() => "13b Primary Energy - for community heating schemes";

    [Description("Electrical efficiency of CHP unit")]
    [ReadOnly(true)]
    public double Box361
    {
      get => !SAP_Module.CalcRound ? this._Box361 : Math.Round(this._Box361, SAP_Module.RoundFigure);
      set => this._Box361 = value;
    }

    [Description("Heat efficiency of CHP unit")]
    [ReadOnly(true)]
    public double Box362
    {
      get => !SAP_Module.CalcRound ? this._Box362 : Math.Round(this._Box362, SAP_Module.RoundFigure);
      set => this._Box362 = value;
    }

    [Description("Space heating from CHP Energy Used")]
    [ReadOnly(true)]
    public double Box363En
    {
      get => !SAP_Module.CalcRound ? this._Box363En : Math.Round(this._Box363En, SAP_Module.RoundFigure);
      set => this._Box363En = value;
    }

    [Description("Space heating from CHP Emission factor")]
    [ReadOnly(true)]
    public double Box363E
    {
      get => !SAP_Module.CalcRound ? this._Box363E : Math.Round(this._Box363E, SAP_Module.RoundFigure);
      set => this._Box363E = value;
    }

    [Description("Space heating from CHP Emissions")]
    [ReadOnly(true)]
    public double Box363
    {
      get => !SAP_Module.CalcRound ? this._Box363 : Math.Round(this._Box363, SAP_Module.RoundFigure);
      set => this._Box363 = value;
    }

    [Description("less credit emissions for electricity Energy Used")]
    [ReadOnly(true)]
    public double Box364En
    {
      get => !SAP_Module.CalcRound ? this._Box364En : Math.Round(this._Box364En, SAP_Module.RoundFigure);
      set => this._Box364En = value;
    }

    [Description("less credit emissions for electricity Emission factor")]
    [ReadOnly(true)]
    public double Box364E
    {
      get => !SAP_Module.CalcRound ? this._Box364E : Math.Round(this._Box364E, SAP_Module.RoundFigure);
      set => this._Box364E = value;
    }

    [Description("less credit emissions for electricity Emissions")]
    [ReadOnly(true)]
    public double Box364
    {
      get => !SAP_Module.CalcRound ? this._Box364 : Math.Round(this._Box364, SAP_Module.RoundFigure);
      set => this._Box364 = value;
    }

    [Description("Water heated by CHP Energy Used")]
    [ReadOnly(true)]
    public double Box365En
    {
      get => !SAP_Module.CalcRound ? this._Box365En : Math.Round(this._Box365En, SAP_Module.RoundFigure);
      set => this._Box365En = value;
    }

    [Description("Water heated by CHP Emission factor")]
    [ReadOnly(true)]
    public double Box365E
    {
      get => !SAP_Module.CalcRound ? this._Box365E : Math.Round(this._Box365E, SAP_Module.RoundFigure);
      set => this._Box365E = value;
    }

    [Description("Water heated by CHP Emissions")]
    [ReadOnly(true)]
    public double Box365
    {
      get => !SAP_Module.CalcRound ? this._Box365 : Math.Round(this._Box365, SAP_Module.RoundFigure);
      set => this._Box365 = value;
    }

    [Description("less credit emissions for electricity Energy Used")]
    [ReadOnly(true)]
    public double Box366En
    {
      get => !SAP_Module.CalcRound ? this._Box366En : Math.Round(this._Box366En, SAP_Module.RoundFigure);
      set => this._Box366En = value;
    }

    [Description("less credit emissions for electricity Emission factor")]
    [ReadOnly(true)]
    public double Box366E
    {
      get => !SAP_Module.CalcRound ? this._Box366E : Math.Round(this._Box366E, SAP_Module.RoundFigure);
      set => this._Box366E = value;
    }

    [Description("less credit emissions for electricity Emissions")]
    [ReadOnly(true)]
    public double Box366
    {
      get => !SAP_Module.CalcRound ? this._Box366 : Math.Round(this._Box366, SAP_Module.RoundFigure);
      set => this._Box366 = value;
    }

    [Description("Efficiency of heat source 1")]
    [ReadOnly(true)]
    public double Box367a
    {
      get => !SAP_Module.CalcRound ? this._Box367a : Math.Round(this._Box367a, SAP_Module.RoundFigure);
      set => this._Box367a = value;
    }

    [Description("Efficiency of heat source 2")]
    [ReadOnly(true)]
    public double Box367b
    {
      get => !SAP_Module.CalcRound ? this._Box367b : Math.Round(this._Box367b, SAP_Module.RoundFigure);
      set => this._Box367b = value;
    }

    [Description("Efficiency of heat source 3")]
    [ReadOnly(true)]
    public double Box367c
    {
      get => !SAP_Module.CalcRound ? this._Box367c : Math.Round(this._Box367c, SAP_Module.RoundFigure);
      set => this._Box367c = value;
    }

    [Description("Efficiency of heat source 4")]
    [ReadOnly(true)]
    public double Box367d
    {
      get => !SAP_Module.CalcRound ? this._Box367d : Math.Round(this._Box367d, SAP_Module.RoundFigure);
      set => this._Box367d = value;
    }

    [Description("Efficiency of heat source 5")]
    [ReadOnly(true)]
    public double Box367e
    {
      get => !SAP_Module.CalcRound ? this._Box367e : Math.Round(this._Box367e, SAP_Module.RoundFigure);
      set => this._Box367e = value;
    }

    [Description("CO2 associated with heat source1 Emission factor")]
    [ReadOnly(true)]
    public double Box367_E
    {
      get => !SAP_Module.CalcRound ? this._Box367_E : Math.Round(this._Box367_E, SAP_Module.RoundFigure);
      set => this._Box367_E = value;
    }

    [Description("CO2 associated with heat source1 Emissions")]
    [ReadOnly(true)]
    public double Box367
    {
      get => !SAP_Module.CalcRound ? this._Box367 : Math.Round(this._Box367, SAP_Module.RoundFigure);
      set => this._Box367 = value;
    }

    [Description("CO2 associated with heat source2 Emission factor")]
    [ReadOnly(true)]
    public double Box368E
    {
      get => !SAP_Module.CalcRound ? this._Box368E : Math.Round(this._Box368E, SAP_Module.RoundFigure);
      set => this._Box368E = value;
    }

    [Description("CO2 associated with heat source2 Emissions")]
    [ReadOnly(true)]
    public double Box368
    {
      get => !SAP_Module.CalcRound ? this._Box368 : Math.Round(this._Box368, SAP_Module.RoundFigure);
      set => this._Box368 = value;
    }

    [Description("CO2 associated with heat source 3 Emission factor")]
    [ReadOnly(true)]
    public double Box369E
    {
      get => !SAP_Module.CalcRound ? this._Box369E : Math.Round(this._Box369E, SAP_Module.RoundFigure);
      set => this._Box369E = value;
    }

    [Description("CO2 associated with heat source 3 Emissions")]
    [ReadOnly(true)]
    public double Box369
    {
      get => !SAP_Module.CalcRound ? this._Box369 : Math.Round(this._Box369, SAP_Module.RoundFigure);
      set => this._Box369 = value;
    }

    [Description("CO2 associated with heat source 4 Emission factor")]
    [ReadOnly(true)]
    public double Box370E
    {
      get => !SAP_Module.CalcRound ? this._Box370E : Math.Round(this._Box370E, SAP_Module.RoundFigure);
      set => this._Box370E = value;
    }

    [Description("CO2 associated with heat source 4 Emissions")]
    [ReadOnly(true)]
    public double Box370
    {
      get => !SAP_Module.CalcRound ? this._Box370 : Math.Round(this._Box370, SAP_Module.RoundFigure);
      set => this._Box370 = value;
    }

    [Description("CO2 associated with heat source 5 Emission factor")]
    [ReadOnly(true)]
    public double Box371E
    {
      get => !SAP_Module.CalcRound ? this._Box371E : Math.Round(this._Box371E, SAP_Module.RoundFigure);
      set => this._Box371E = value;
    }

    [Description("CO2 associated with heat source 5 Emissions")]
    [ReadOnly(true)]
    public double Box371
    {
      get => !SAP_Module.CalcRound ? this._Box371 : Math.Round(this._Box371, SAP_Module.RoundFigure);
      set => this._Box371 = value;
    }

    [Description("Electrical energy for heat distribution Emission factor")]
    [ReadOnly(true)]
    public double Box372E
    {
      get => !SAP_Module.CalcRound ? this._Box372E : Math.Round(this._Box372E, SAP_Module.RoundFigure);
      set => this._Box372E = value;
    }

    [Description("Electrical energy for heat distribution Emissions")]
    [ReadOnly(true)]
    public double Box372
    {
      get => !SAP_Module.CalcRound ? this._Box372 : Math.Round(this._Box372, SAP_Module.RoundFigure);
      set => this._Box372 = value;
    }

    [Description("Electrical efficiency of CHP unit")]
    [ReadOnly(true)]
    public double Box361W
    {
      get => !SAP_Module.CalcRound ? this._Box361W : Math.Round(this._Box361W, SAP_Module.RoundFigure);
      set => this._Box361W = value;
    }

    [Description("Heat efficiency of CHP unit")]
    [ReadOnly(true)]
    public double Box362W
    {
      get => !SAP_Module.CalcRound ? this._Box362W : Math.Round(this._Box362W, SAP_Module.RoundFigure);
      set => this._Box362W = value;
    }

    [Description("Space heating from CHP Energy Used")]
    [ReadOnly(true)]
    public double Box363EnW
    {
      get => !SAP_Module.CalcRound ? this._Box363EnW : Math.Round(this._Box363EnW, SAP_Module.RoundFigure);
      set => this._Box363EnW = value;
    }

    [Description("Space heating from CHP Emission factor")]
    [ReadOnly(true)]
    public double Box363EW
    {
      get => !SAP_Module.CalcRound ? this._Box363EW : Math.Round(this._Box363EW, SAP_Module.RoundFigure);
      set => this._Box363EW = value;
    }

    [Description("Space heating from CHP Emissions")]
    [ReadOnly(true)]
    public double Box363W
    {
      get => !SAP_Module.CalcRound ? this._Box363W : Math.Round(this._Box363W, SAP_Module.RoundFigure);
      set => this._Box363W = value;
    }

    [Description("less credit emissions for electricity Energy Used")]
    [ReadOnly(true)]
    public double Box364EnW
    {
      get => !SAP_Module.CalcRound ? this._Box364EnW : Math.Round(this._Box364EnW, SAP_Module.RoundFigure);
      set => this._Box364EnW = value;
    }

    [Description("less credit emissions for electricity Emission factor")]
    [ReadOnly(true)]
    public double Box364EW
    {
      get => !SAP_Module.CalcRound ? this._Box364EW : Math.Round(this._Box364EW, SAP_Module.RoundFigure);
      set => this._Box364EW = value;
    }

    [Description("less credit emissions for electricity Emissions")]
    [ReadOnly(true)]
    public double Box364W
    {
      get => !SAP_Module.CalcRound ? this._Box364W : Math.Round(this._Box364W, SAP_Module.RoundFigure);
      set => this._Box364W = value;
    }

    [Description("Water heated by CHP Energy Used")]
    [ReadOnly(true)]
    public double Box365EnW
    {
      get => !SAP_Module.CalcRound ? this._Box365EnW : Math.Round(this._Box365EnW, SAP_Module.RoundFigure);
      set => this._Box365EnW = value;
    }

    [Description("Water heated by CHP Emission factor")]
    [ReadOnly(true)]
    public double Box365EW
    {
      get => !SAP_Module.CalcRound ? this._Box365EW : Math.Round(this._Box365EW, SAP_Module.RoundFigure);
      set => this._Box365EW = value;
    }

    [Description("Water heated by CHP Emissions")]
    [ReadOnly(true)]
    public double Box365W
    {
      get => !SAP_Module.CalcRound ? this._Box365W : Math.Round(this._Box365W, SAP_Module.RoundFigure);
      set => this._Box365W = value;
    }

    [Description("less credit emissions for electricity Energy Used")]
    [ReadOnly(true)]
    public double Box366EnW
    {
      get => !SAP_Module.CalcRound ? this._Box366EnW : Math.Round(this._Box366EnW, SAP_Module.RoundFigure);
      set => this._Box366EnW = value;
    }

    [Description("less credit emissions for electricity Emission factor")]
    [ReadOnly(true)]
    public double Box366EW
    {
      get => !SAP_Module.CalcRound ? this._Box366EW : Math.Round(this._Box366EW, SAP_Module.RoundFigure);
      set => this._Box366EW = value;
    }

    [Description("less credit emissions for electricity Emissions")]
    [ReadOnly(true)]
    public double Box366W
    {
      get => !SAP_Module.CalcRound ? this._Box366W : Math.Round(this._Box366W, SAP_Module.RoundFigure);
      set => this._Box366W = value;
    }

    [Description("Efficiency of heat source 1")]
    [ReadOnly(true)]
    public double Box367aW
    {
      get => !SAP_Module.CalcRound ? this._Box367aW : Math.Round(this._Box367aW, SAP_Module.RoundFigure);
      set => this._Box367aW = value;
    }

    [Description("Efficiency of heat source 2")]
    [ReadOnly(true)]
    public double Box367bW
    {
      get => !SAP_Module.CalcRound ? this._Box367bW : Math.Round(this._Box367bW, SAP_Module.RoundFigure);
      set => this._Box367bW = value;
    }

    [Description("Efficiency of heat source 3")]
    [ReadOnly(true)]
    public double Box367cW
    {
      get => !SAP_Module.CalcRound ? this._Box367cW : Math.Round(this._Box367cW, SAP_Module.RoundFigure);
      set => this._Box367cW = value;
    }

    [Description("Efficiency of heat source 4")]
    [ReadOnly(true)]
    public double Box367dW
    {
      get => !SAP_Module.CalcRound ? this._Box367dW : Math.Round(this._Box367dW, SAP_Module.RoundFigure);
      set => this._Box367dW = value;
    }

    [Description("Efficiency of heat source 5")]
    [ReadOnly(true)]
    public double Box367eW
    {
      get => !SAP_Module.CalcRound ? this._Box367eW : Math.Round(this._Box367eW, SAP_Module.RoundFigure);
      set => this._Box367eW = value;
    }

    [Description("CO2 associated with heat source1 Emission factor")]
    [ReadOnly(true)]
    public double Box367_EW
    {
      get => !SAP_Module.CalcRound ? this._Box367_EW : Math.Round(this._Box367_EW, SAP_Module.RoundFigure);
      set => this._Box367_EW = value;
    }

    [Description("CO2 associated with heat source1 Emissions")]
    [ReadOnly(true)]
    public double Box367W
    {
      get => !SAP_Module.CalcRound ? this._Box367W : Math.Round(this._Box367W, SAP_Module.RoundFigure);
      set => this._Box367W = value;
    }

    [Description("CO2 associated with heat source2 Emission factor")]
    [ReadOnly(true)]
    public double Box368EW
    {
      get => !SAP_Module.CalcRound ? this._Box368EW : Math.Round(this._Box368EW, SAP_Module.RoundFigure);
      set => this._Box368EW = value;
    }

    [Description("CO2 associated with heat source2 Emissions")]
    [ReadOnly(true)]
    public double Box368W
    {
      get => !SAP_Module.CalcRound ? this._Box368W : Math.Round(this._Box368W, SAP_Module.RoundFigure);
      set => this._Box368W = value;
    }

    [Description("CO2 associated with heat source 3 Emission factor")]
    [ReadOnly(true)]
    public double Box369EW
    {
      get => !SAP_Module.CalcRound ? this._Box369EW : Math.Round(this._Box369EW, SAP_Module.RoundFigure);
      set => this._Box369EW = value;
    }

    [Description("CO2 associated with heat source 3 Emissions")]
    [ReadOnly(true)]
    public double Box369W
    {
      get => !SAP_Module.CalcRound ? this._Box369W : Math.Round(this._Box369W, SAP_Module.RoundFigure);
      set => this._Box369W = value;
    }

    [Description("CO2 associated with heat source 4 Emission factor")]
    [ReadOnly(true)]
    public double Box370EW
    {
      get => !SAP_Module.CalcRound ? this._Box370EW : Math.Round(this._Box370EW, SAP_Module.RoundFigure);
      set => this._Box370EW = value;
    }

    [Description("CO2 associated with heat source 4 Emissions")]
    [ReadOnly(true)]
    public double Box370W
    {
      get => !SAP_Module.CalcRound ? this._Box370W : Math.Round(this._Box370W, SAP_Module.RoundFigure);
      set => this._Box370W = value;
    }

    [Description("CO2 associated with heat source 5 Emission factor")]
    [ReadOnly(true)]
    public double Box371EW
    {
      get => !SAP_Module.CalcRound ? this._Box371EW : Math.Round(this._Box371EW, SAP_Module.RoundFigure);
      set => this._Box371EW = value;
    }

    [Description("CO2 associated with heat source 5 Emissions")]
    [ReadOnly(true)]
    public double Box371W
    {
      get => !SAP_Module.CalcRound ? this._Box371W : Math.Round(this._Box371W, SAP_Module.RoundFigure);
      set => this._Box371W = value;
    }

    [Description("Electrical energy for heat distribution Emission factor")]
    [ReadOnly(true)]
    public double Box372EW
    {
      get => !SAP_Module.CalcRound ? this._Box372EW : Math.Round(this._Box372EW, SAP_Module.RoundFigure);
      set => this._Box372EW = value;
    }

    [Description("Electrical energy for heat distribution Emissions")]
    [ReadOnly(true)]
    public double Box372W
    {
      get => !SAP_Module.CalcRound ? this._Box372W : Math.Round(this._Box372W, SAP_Module.RoundFigure);
      set => this._Box372W = value;
    }

    [Description("Total CO2 associated with community systems")]
    [ReadOnly(true)]
    public double Box373
    {
      get => !SAP_Module.CalcRound ? this._Box373 : Math.Round(this._Box373, SAP_Module.RoundFigure);
      set => this._Box373 = value;
    }

    [Description("CO2 associated with space heating Emission factor")]
    [ReadOnly(true)]
    public double Box374E
    {
      get => !SAP_Module.CalcRound ? this._Box374E : Math.Round(this._Box374E, SAP_Module.RoundFigure);
      set => this._Box374E = value;
    }

    [Description("CO2 associated with space heating Emissions")]
    [ReadOnly(true)]
    public double Box374
    {
      get => !SAP_Module.CalcRound ? this._Box374 : Math.Round(this._Box374, SAP_Module.RoundFigure);
      set => this._Box374 = value;
    }

    [Description("CO2 associated with water from immersion heater or instantaneous heater Emission factor")]
    [ReadOnly(true)]
    public double Box375E
    {
      get => !SAP_Module.CalcRound ? this._Box375E : Math.Round(this._Box375E, SAP_Module.RoundFigure);
      set => this._Box375E = value;
    }

    [Description("CO2 associated with water from immersion heater or instantaneous heater Emissions")]
    [ReadOnly(true)]
    public double Box375
    {
      get => !SAP_Module.CalcRound ? this._Box375 : Math.Round(this._Box375, SAP_Module.RoundFigure);
      set => this._Box375 = value;
    }

    [Description("Total CO2 associated with space and water heating")]
    [ReadOnly(true)]
    public double Box376
    {
      get => !SAP_Module.CalcRound ? this._Box376 : Math.Round(this._Box376, SAP_Module.RoundFigure);
      set => this._Box376 = value;
    }

    [Description("CO2 associated with space cooling Emission factor")]
    [ReadOnly(true)]
    public double Box377E
    {
      get => !SAP_Module.CalcRound ? this._Box377E : Math.Round(this._Box377E, SAP_Module.RoundFigure);
      set => this._Box377E = value;
    }

    [Description("CO2 associated with space cooling Emissions")]
    [ReadOnly(true)]
    public double Box377
    {
      get => !SAP_Module.CalcRound ? this._Box377 : Math.Round(this._Box377, SAP_Module.RoundFigure);
      set => this._Box377 = value;
    }

    [Description("CO2 associated with electricity for pumps and fans within dwelling Emission factor")]
    [ReadOnly(true)]
    public double Box378E
    {
      get => !SAP_Module.CalcRound ? this._Box378E : Math.Round(this._Box378E, SAP_Module.RoundFigure);
      set => this._Box378E = value;
    }

    [Description("CO2 associated with electricity for pumps and fans within dwelling Emissions")]
    [ReadOnly(true)]
    public double Box378
    {
      get => !SAP_Module.CalcRound ? this._Box378 : Math.Round(this._Box378, SAP_Module.RoundFigure);
      set => this._Box378 = value;
    }

    [Description("CO2 associated with electricity for lighting Emission factor")]
    [ReadOnly(true)]
    public double Box379E
    {
      get => !SAP_Module.CalcRound ? this._Box379E : Math.Round(this._Box379E, SAP_Module.RoundFigure);
      set => this._Box379E = value;
    }

    [Description("CO2 associated with electricity for lighting Emissions")]
    [ReadOnly(true)]
    public double Box379
    {
      get => !SAP_Module.CalcRound ? this._Box379 : Math.Round(this._Box379, SAP_Module.RoundFigure);
      set => this._Box379 = value;
    }

    [Description("Number of Energy saving/generation technologies")]
    [ReadOnly(true)]
    public int Box380_Count
    {
      get => this._Box380Ea == null ? 0 : this._Box380Ea.Length;
      set
      {
        double[]& local1;
        double[] numArray1 = (double[]) Utils.CopyArray((Array) ^(local1 = ref this._Box380Ea), (Array) new double[checked (value - 1 + 1)]);
        local1 = numArray1;
        double[]& local2;
        double[] numArray2 = (double[]) Utils.CopyArray((Array) ^(local2 = ref this._Box380a), (Array) new double[checked (value - 1 + 1)]);
        local2 = numArray2;
      }
    }

    [Description("Energy saving/generation Energy Factors")]
    [ReadOnly(true)]
    public double[] Box380_EFactors => this._Box380Ea;

    [Description("Energy saving/generation Energy")]
    [ReadOnly(true)]
    public double[] Box380_Energy => this._Box380a;

    [Description("Energy saving/generation Energy")]
    [ReadOnly(true)]
    public double Box380
    {
      get
      {
        if (this._Box380a == null)
          return 0.0;
        int num1 = checked (this._Box380a.Length - 1);
        int index = 0;
        double num2;
        while (index <= num1)
        {
          num2 += this._Box380a[index];
          checked { ++index; }
        }
        return !SAP_Module.CalcRound ? num2 : Math.Round(num2, SAP_Module.RoundFigure);
      }
    }

    public double get_Box380_EFactors(int index) => !SAP_Module.CalcRound ? this._Box380Ea[index] : Math.Round(this._Box380Ea[index], SAP_Module.RoundFigure);

    public void set_Box380_EFactors(int index, double value) => this._Box380Ea[index] = value;

    public double get_Box380_Energy(int index) => !SAP_Module.CalcRound ? this._Box380a[index] : Math.Round(this._Box380a[index], SAP_Module.RoundFigure);

    public void set_Box380_Energy(int index, double value) => this._Box380a[index] = value;

    [Description("")]
    [ReadOnly(true)]
    public double Box381
    {
      get
      {
        if (this._AppendixQ_Item == null)
          return 0.0;
        int num = checked (this._AppendixQ_Item.Length - 1);
        int index = 0;
        float box381;
        while (index <= num)
        {
          box381 += (float) this._AppendixQ_Item[index].Energy_Saved_Energy;
          checked { ++index; }
        }
        return (double) box381;
      }
    }

    [Description("")]
    [ReadOnly(true)]
    public double Box382
    {
      get
      {
        if (this._AppendixQ_Item == null)
          return 0.0;
        int num = checked (this._AppendixQ_Item.Length - 1);
        int index = 0;
        float box382;
        while (index <= num)
        {
          box382 += (float) this._AppendixQ_Item[index].Energy_Used_Energy;
          checked { ++index; }
        }
        return (double) box382;
      }
    }

    public Primary_Energy_13b2012.AppendixQ_Items get_AppendixQ_Item(int Index)
    {
      if (this._AppendixQ_Item[Index] == null)
        this._AppendixQ_Item[Index] = new Primary_Energy_13b2012.AppendixQ_Items();
      return this._AppendixQ_Item[Index];
    }

    public void set_AppendixQ_Item(int Index, Primary_Energy_13b2012.AppendixQ_Items value)
    {
      if (this._AppendixQ_Item[Index] == null)
        this._AppendixQ_Item[Index] = new Primary_Energy_13b2012.AppendixQ_Items();
      this._AppendixQ_Item[Index] = value;
    }

    [Description("")]
    [ReadOnly(true)]
    public Primary_Energy_13b2012.AppendixQ_Items[] AppendixQ_Item => this._AppendixQ_Item;

    public int AppendixQ_Item_Count
    {
      set
      {
        this._AppendixQ_Item = new Primary_Energy_13b2012.AppendixQ_Items[checked (value - 1 + 1)];
        int num = checked (value - 1);
        int index = 0;
        while (index <= num)
        {
          this._AppendixQ_Item[index] = new Primary_Energy_13b2012.AppendixQ_Items();
          checked { ++index; }
        }
      }
    }

    [Description("Total Energy")]
    [ReadOnly(true)]
    public double Box383
    {
      get => !SAP_Module.CalcRound ? this._Box383 : Math.Round(this._Box383, SAP_Module.RoundFigure);
      set => this._Box383 = value;
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
