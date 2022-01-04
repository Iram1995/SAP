
// Type: SAP2012.Ene1




using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;

namespace SAP2012
{
  public class Ene1
  {
    private Ene1.Ene1_Calc _Calc;
    private Calc2012 _EneCalc;

    public bool Calc()
    {
      bool flag;
      try
      {
        SAP_Module.CalcRound = false;
        this._Calc = new Ene1.Ene1_Calc();
        this._EneCalc = new Calc2012();
        this._EneCalc.DTER = true;
        this._EneCalc.IsEneCalc = true;
        SAP_Module.CalcAssessmentLZCPlease = true;
        this._EneCalc.Dwelling = Functions.CopyDwelling(SAP_Module.DERDwelling);
        SAP_Module.CalcAssessmentLZCPlease = false;
        this.StandardCalc();
        this.ActualCalc();
        SAP_Module.CalcRound = true;
        flag = true;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) ex.Message);
        flag = false;
        ProjectData.ClearProjectError();
      }
      return flag;
    }

    private void StandardCalc()
    {
      Ene1.Ene1_Calc.Cat1_2 part1 = this._Calc.Part1;
      part1.P1 = this._EneCalc.Calculation.CO2_Emissions_12a.Box273 != 0.0 ? this._EneCalc.Calculation.CO2_Emissions_12a.Box273 : this._EneCalc.Calculation.CO2_Emissions_12b.Box384;
      part1.P1 = Math.Round(part1.P1, 2);
      part1.P2 = Functions.TER();
      part1.P3 = this._EneCalc.Calculation.AssessmentLZC2012.ZC7;
      part1.P4 = this._EneCalc.Calculation.AssessmentLZC2012.ZC5;
      part1.P5 = part1.P3 + part1.P4;
      part1.P6 = part1.P1 + part1.P5;
      double num = Math.Round(100.0 * (1.0 - part1.P6 / part1.P2), 1);
      part1.P7 = num;
    }

    private void ActualCalc() => this._Calc.Part2.P1 = this._EneCalc.Calculation.AssessmentLZC2012.ZC8;

    public Ene1.Ene1_Calc Ene1_ => this._Calc;

    public class Ene1_Calc
    {
      private Ene1.Ene1_Calc.Cat1_2 _Part1;
      private Ene1.Ene1_Calc.Cat1_3 _Part2;

      public Ene1_Calc()
      {
        this._Part1 = new Ene1.Ene1_Calc.Cat1_2();
        this._Part2 = new Ene1.Ene1_Calc.Cat1_3();
      }

      public Ene1.Ene1_Calc.Cat1_2 Part1 => this._Part1;

      public Ene1.Ene1_Calc.Cat1_3 Part2 => this._Part2;

      public class Cat1_2
      {
        private double _P1;
        private double _P2;
        private double _P3;
        private double _P4;
        private double _P5;
        private double _P6;
        private double _P7;

        public double P1
        {
          get => !SAP_Module.CalcRound ? this._P1 : Math.Round(this._P1, SAP_Module.RoundFigure);
          set => this._P1 = value;
        }

        public double P2
        {
          get => !SAP_Module.CalcRound ? this._P2 : Math.Round(this._P2, SAP_Module.RoundFigure);
          set => this._P2 = value;
        }

        public double P3
        {
          get => !SAP_Module.CalcRound ? this._P3 : Math.Round(this._P3, SAP_Module.RoundFigure);
          set => this._P3 = value;
        }

        public double P4
        {
          get => !SAP_Module.CalcRound ? this._P4 : Math.Round(this._P4, SAP_Module.RoundFigure);
          set => this._P4 = value;
        }

        public double P5
        {
          get => !SAP_Module.CalcRound ? this._P5 : Math.Round(this._P5, SAP_Module.RoundFigure);
          set => this._P5 = value;
        }

        public double P6
        {
          get => !SAP_Module.CalcRound ? this._P6 : Math.Round(this._P6, SAP_Module.RoundFigure);
          set => this._P6 = value;
        }

        public double P7
        {
          get => !SAP_Module.CalcRound ? this._P7 : Math.Round(this._P7, SAP_Module.RoundFigure);
          set => this._P7 = value;
        }
      }

      public class Cat1_3
      {
        private double _P1;

        public double P1
        {
          get => !SAP_Module.CalcRound ? this._P1 : Math.Round(this._P1, SAP_Module.RoundFigure);
          set => this._P1 = value;
        }
      }
    }
  }
}
