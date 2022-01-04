
// Type: SAP2012.RHICalc




using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using SAP2012.RdSAP;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SAP2012
{
  public class RHICalc
  {
    private RHI RHI;
    private RdSAP_TO_SAP.Extensions EXT;
    private SAP_Module.Dwelling Dwelling;
    private bool RHI_A;
    private bool RHI_B;
    private bool RHI_Q;
    private bool[] ChangeUFloor;
    private Calc2012 CalculationImprove2012Regional;
    private bool[] CavityIncludes;

    public RHICalc()
    {
      this.RHI = new RHI();
      this.ChangeUFloor = new bool[6];
      this.CalculationImprove2012Regional = new Calc2012();
      this.CavityIncludes = new bool[5];
    }

    public RHI Calc(
      SAP_Module.Dwelling Dwelling,
      Survey_Class RdSAPDwelling,
      RdSAP_TO_SAP.Extensions EXT,
      bool No_A,
      bool No_B,
      bool No_Q)
    {
      this.EXT = EXT;
      this.Dwelling = this.CalculationImprove2012Regional.CopyDwelling(Dwelling);
      this.Dwelling.Water.Solar.Inlcude = false;
      this.CalculationImprove2012Regional.IsRHICalc = true;
      this.CalculationImprove2012Regional.Dwelling = this.Dwelling;
      this.RHI.SpaceHeatingExisting = checked ((int) Math.Round(this.CalculationImprove2012Regional.Calculation.Space_heating_requirement.Box98));
      if (!No_A)
        this.A(RdSAPDwelling);
      if (!No_B)
        this.B(RdSAPDwelling);
      if (!No_Q)
        this.Q(RdSAPDwelling);
      this.RHI.WaterHeating = checked ((int) Math.Round(unchecked (this.CalculationImprove2012Regional.Calculation.Water_heating.Box64 + this.CalculationImprove2012Regional.Calculation.Water_heating.Box64Imm)));
      return this.RHI;
    }

    private void A(Survey_Class RdSAP)
    {
      Survey_Class surveyClass = RdSAP;
      int CurrFloor = -1;
      if (surveyClass.Extensions[0].RoofConstruction != 7 & surveyClass.Extensions[0].RoofConstruction != 3)
      {
        checked { ++CurrFloor; }
        this.A1(CurrFloor, surveyClass.Extensions[0]);
      }
      if (surveyClass.Extensions[0].RoofRoom)
      {
        if (!surveyClass.Extensions[0].RoofRoom_Edit)
        {
          checked { ++CurrFloor; }
        }
        else
        {
          if (surveyClass.Extensions[0].RoofRoom_FlatCeiling[0].Area != 0.0)
            checked { ++CurrFloor; }
          if (surveyClass.Extensions[0].RoofRoom_FlatCeiling[1].Area != 0.0)
            checked { ++CurrFloor; }
          if (surveyClass.Extensions[0].RoofRoom_Slope[0].Area != 0.0)
            checked { ++CurrFloor; }
          if (surveyClass.Extensions[0].RoofRoom_Slope[1].Area != 0.0)
            checked { ++CurrFloor; }
        }
      }
      if (this.EXT.Ext1 && surveyClass.Extensions[1].RoofConstruction != 7 & surveyClass.Extensions[1].RoofConstruction != 3)
      {
        checked { ++CurrFloor; }
        this.A1(CurrFloor, surveyClass.Extensions[1]);
      }
      if (surveyClass.Extensions[1].RoofRoom)
      {
        if (!surveyClass.Extensions[1].RoofRoom_Edit)
        {
          checked { ++CurrFloor; }
        }
        else
        {
          if (surveyClass.Extensions[1].RoofRoom_FlatCeiling[0].Area != 0.0)
            checked { ++CurrFloor; }
          if (surveyClass.Extensions[1].RoofRoom_FlatCeiling[1].Area != 0.0)
            checked { ++CurrFloor; }
          if (surveyClass.Extensions[1].RoofRoom_Slope[0].Area != 0.0)
            checked { ++CurrFloor; }
          if (surveyClass.Extensions[1].RoofRoom_Slope[1].Area != 0.0)
            checked { ++CurrFloor; }
        }
      }
      if (this.EXT.Ext2 && surveyClass.Extensions[2].RoofConstruction != 7 & surveyClass.Extensions[2].RoofConstruction != 3)
      {
        checked { ++CurrFloor; }
        this.A1(CurrFloor, surveyClass.Extensions[2]);
      }
      if (surveyClass.Extensions[2].RoofRoom)
      {
        if (!surveyClass.Extensions[2].RoofRoom_Edit)
        {
          checked { ++CurrFloor; }
        }
        else
        {
          if (surveyClass.Extensions[2].RoofRoom_FlatCeiling[0].Area != 0.0)
            checked { ++CurrFloor; }
          if (surveyClass.Extensions[2].RoofRoom_FlatCeiling[1].Area != 0.0)
            checked { ++CurrFloor; }
          if (surveyClass.Extensions[2].RoofRoom_Slope[0].Area != 0.0)
            checked { ++CurrFloor; }
          if (surveyClass.Extensions[2].RoofRoom_Slope[1].Area != 0.0)
            checked { ++CurrFloor; }
        }
      }
      if (this.EXT.Ext3 && surveyClass.Extensions[3].RoofConstruction != 7 & surveyClass.Extensions[3].RoofConstruction != 3)
      {
        checked { ++CurrFloor; }
        this.A1(CurrFloor, surveyClass.Extensions[3]);
      }
      if (surveyClass.Extensions[3].RoofRoom)
      {
        if (!surveyClass.Extensions[3].RoofRoom_Edit)
        {
          checked { ++CurrFloor; }
        }
        else
        {
          if (surveyClass.Extensions[3].RoofRoom_FlatCeiling[0].Area != 0.0)
            checked { ++CurrFloor; }
          if (surveyClass.Extensions[3].RoofRoom_FlatCeiling[1].Area != 0.0)
            checked { ++CurrFloor; }
          if (surveyClass.Extensions[3].RoofRoom_Slope[0].Area != 0.0)
            checked { ++CurrFloor; }
          if (surveyClass.Extensions[3].RoofRoom_Slope[1].Area != 0.0)
            checked { ++CurrFloor; }
        }
      }
      if (this.EXT.Ext4 && surveyClass.Extensions[4].RoofConstruction != 7 & surveyClass.Extensions[4].RoofConstruction != 3)
        this.A1(checked (CurrFloor + 1), surveyClass.Extensions[4]);
      if (this.RHI_A)
      {
        this.CalculationImprove2012Regional.Dwelling = this.Dwelling;
        this.RHI.LoftInsulation = checked ((int) Math.Round(unchecked ((double) this.RHI.SpaceHeatingExisting - this.CalculationImprove2012Regional.Calculation.Space_heating_requirement.Box98)));
      }
    }

    private void A1(int CurrFloor, Extension_Class Extension)
    {
      bool flag;
      if (Operators.CompareString(this.Dwelling.Roofs[CurrFloor].Type, "Pitched - insulated joists", false) == 0)
        flag = true;
      if (Extension.RoofConstruction == 4)
        flag = true;
      if (Extension.RoofConstruction == 5)
        flag = true;
      if (Extension.RoofConstruction == 6)
        flag = false;
      if (!flag)
        return;
      if (Extension.RoofInsulation == 1)
      {
        this.RHI_A = true;
        if (Extension.RoofConstruction != 6)
          this.Dwelling.Roofs[CurrFloor].U_Value = 0.16f;
      }
      if (Extension.RoofInsulation == 4)
      {
        switch (Extension.RoofInsulationThickness)
        {
          case 3:
          case 4:
          case 5:
          case 6:
          case 7:
          case 8:
            this.RHI_A = true;
            if (Extension.RoofConstruction != 6)
            {
              this.Dwelling.Roofs[CurrFloor].U_Value = 0.16f;
              break;
            }
            break;
        }
        if (Extension.RoofUValueKnown && (double) this.Dwelling.Roofs[CurrFloor].U_Value >= 0.35)
        {
          this.RHI_A = true;
          this.Dwelling.Roofs[CurrFloor].U_Value = 0.16f;
        }
      }
      else if (Extension.RoofInsulation == 2)
      {
        this.RHI_A = true;
        this.Dwelling.Roofs[CurrFloor].U_Value = 0.16f;
      }
    }

    private void B(Survey_Class RdSAP)
    {
      Survey_Class surveyClass = RdSAP;
      int CurrWall = 0;
      int numberOfExtension1 = surveyClass.Age.NumberOfExtension;
      int Extension1 = 0;
      while (Extension1 <= numberOfExtension1)
      {
        this.B1(CurrWall, (Enums.WallConstructionCode) surveyClass.Extensions[Extension1].WallConstruction, (Enums.WallInsulationCode) surveyClass.Extensions[Extension1].WallInsulation, (Enums.CountryCode) surveyClass.General.Country, Conversions.ToString(surveyClass.Extensions[Extension1].PropAge), Extension1);
        if (surveyClass.Extensions[Extension1].RoofRoom)
        {
          if (!surveyClass.Extensions[Extension1].RoofRoom_Edit)
          {
            checked { ++CurrWall; }
          }
          else
          {
            if (surveyClass.Extensions[Extension1].RoofRoom_GableWall[0].Area != 0.0)
              checked { ++CurrWall; }
            if (surveyClass.Extensions[Extension1].RoofRoom_GableWall[1].Area != 0.0)
              checked { ++CurrWall; }
            if (surveyClass.Extensions[Extension1].RoofRoom_StudWall[0].Area != 0.0)
              checked { ++CurrWall; }
            if (surveyClass.Extensions[Extension1].RoofRoom_StudWall[1].Area != 0.0)
              checked { ++CurrWall; }
          }
        }
        checked { ++CurrWall; }
        checked { ++Extension1; }
      }
      int numberOfExtension2 = surveyClass.Age.NumberOfExtension;
      int Extension2 = 0;
      while (Extension2 <= numberOfExtension2)
      {
        if (surveyClass.Extensions[Extension2].AltPresent)
        {
          this.B1(CurrWall, (Enums.WallConstructionCode) surveyClass.Extensions[Extension2].AltWallConstruction, (Enums.WallInsulationCode) surveyClass.Extensions[Extension2].AltWallInsulationType, (Enums.CountryCode) surveyClass.General.Country, Conversions.ToString(surveyClass.Extensions[Extension2].PropAge), Extension2);
          checked { ++CurrWall; }
        }
        checked { ++Extension2; }
      }
      if (this.RHI_B)
      {
        this.CalculationImprove2012Regional.Dwelling = this.Dwelling;
        this.RHI.CavityInsulation = checked ((int) Math.Round(unchecked (Convert.ToDouble(Math.Round(new Decimal(checked (this.RHI.SpaceHeatingExisting - this.RHI.LoftInsulation)))) - this.CalculationImprove2012Regional.Calculation.Space_heating_requirement.Box98)));
      }
    }

    private string get_age(int age)
    {
      string age1;
      switch (age)
      {
        case 1:
          age1 = "A";
          break;
        case 2:
          age1 = "B";
          break;
        case 3:
          age1 = "C";
          break;
        case 4:
          age1 = "D";
          break;
        case 5:
          age1 = "E";
          break;
        case 6:
          age1 = "F";
          break;
        case 7:
          age1 = "G";
          break;
        case 8:
          age1 = "I";
          break;
        case 9:
          age1 = "J";
          break;
        case 10:
          age1 = "K";
          break;
      }
      return age1;
    }

    private void B1(
      int CurrWall,
      Enums.WallConstructionCode Wall,
      Enums.WallInsulationCode WallInsulation,
      Enums.CountryCode Country,
      string Age,
      int Extension)
    {
      float num = 0.6f;
      if (Wall != Enums.WallConstructionCode.Cavity || WallInsulation != Enums.WallInsulationCode.As_built || (double) this.Dwelling.Walls[CurrWall].U_Value <= (double) num)
        return;
      this.RHI_B = true;
      this.Dwelling.Walls[CurrWall].U_Value = this.B2(Country, this.get_age(Conversions.ToInteger(Age)));
      this.CavityIncludes[Extension] = true;
    }

    private float B2(Enums.CountryCode Country, string Age)
    {
      float num = 0.0f;
      switch (Country)
      {
        case Enums.CountryCode.England:
        case Enums.CountryCode.Wales:
          string str1 = Age;
          // ISSUE: reference to a compiler-generated method
          switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(str1))
          {
            case 3222007936:
              if (Operators.CompareString(str1, "E", false) == 0)
                break;
              goto label_54;
            case 3238785555:
              if (Operators.CompareString(str1, "D", false) == 0)
                break;
              goto label_54;
            case 3255563174:
              if (Operators.CompareString(str1, "G", false) == 0)
                goto label_15;
              else
                goto label_54;
            case 3272340793:
              if (Operators.CompareString(str1, "F", false) == 0)
              {
                num = 0.4f;
                goto label_54;
              }
              else
                goto label_54;
            case 3289118412:
              if (Operators.CompareString(str1, "A", false) == 0)
                break;
              goto label_54;
            case 3322673650:
              if (Operators.CompareString(str1, "C", false) == 0)
                break;
              goto label_54;
            case 3339451269:
              if (Operators.CompareString(str1, "B", false) == 0)
                break;
              goto label_54;
            case 3423339364:
              if (Operators.CompareString(str1, "I", false) == 0)
              {
                num = 0.45f;
                goto label_54;
              }
              else
                goto label_54;
            case 3440116983:
              if (Operators.CompareString(str1, "H", false) == 0)
                goto label_15;
              else
                goto label_54;
            case 3456894602:
              if (Operators.CompareString(str1, "K", false) == 0)
              {
                num = 0.3f;
                goto label_54;
              }
              else
                goto label_54;
            case 3473672221:
              if (Operators.CompareString(str1, "J", false) == 0)
                goto label_15;
              else
                goto label_54;
            default:
              goto label_54;
          }
          num = 0.5f;
          break;
label_15:
          num = 0.35f;
          break;
        case Enums.CountryCode.Scotland:
          string str2 = Age;
          // ISSUE: reference to a compiler-generated method
          switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(str2))
          {
            case 3222007936:
              if (Operators.CompareString(str2, "E", false) == 0)
                break;
              goto label_54;
            case 3238785555:
              if (Operators.CompareString(str2, "D", false) == 0)
                break;
              goto label_54;
            case 3255563174:
              if (Operators.CompareString(str2, "G", false) == 0)
              {
                num = 0.35f;
                goto label_54;
              }
              else
                goto label_54;
            case 3272340793:
              if (Operators.CompareString(str2, "F", false) == 0)
              {
                num = 0.4f;
                goto label_54;
              }
              else
                goto label_54;
            case 3289118412:
              if (Operators.CompareString(str2, "A", false) == 0)
                break;
              goto label_54;
            case 3322673650:
              if (Operators.CompareString(str2, "C", false) == 0)
                break;
              goto label_54;
            case 3339451269:
              if (Operators.CompareString(str2, "B", false) == 0)
                break;
              goto label_54;
            case 3423339364:
              if (Operators.CompareString(str2, "I", false) == 0)
                goto label_33;
              else
                goto label_54;
            case 3440116983:
              if (Operators.CompareString(str2, "H", false) == 0)
                goto label_33;
              else
                goto label_54;
            case 3456894602:
              if (Operators.CompareString(str2, "K", false) == 0)
              {
                num = 0.25f;
                goto label_54;
              }
              else
                goto label_54;
            case 3473672221:
              if (Operators.CompareString(str2, "J", false) == 0)
              {
                num = 0.3f;
                goto label_54;
              }
              else
                goto label_54;
            default:
              goto label_54;
          }
          num = 0.5f;
          break;
label_33:
          num = 0.45f;
          break;
        case Enums.CountryCode.Northern_Ireland:
          string str3 = Age;
          // ISSUE: reference to a compiler-generated method
          switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(str3))
          {
            case 3222007936:
              if (Operators.CompareString(str3, "E", false) == 0)
                break;
              goto label_54;
            case 3238785555:
              if (Operators.CompareString(str3, "D", false) == 0)
                break;
              goto label_54;
            case 3255563174:
              if (Operators.CompareString(str3, "G", false) == 0)
              {
                num = 0.35f;
                goto label_54;
              }
              else
                goto label_54;
            case 3272340793:
              if (Operators.CompareString(str3, "F", false) == 0)
              {
                num = 0.4f;
                goto label_54;
              }
              else
                goto label_54;
            case 3289118412:
              if (Operators.CompareString(str3, "A", false) == 0)
                break;
              goto label_54;
            case 3322673650:
              if (Operators.CompareString(str3, "C", false) == 0)
                break;
              goto label_54;
            case 3339451269:
              if (Operators.CompareString(str3, "B", false) == 0)
                break;
              goto label_54;
            case 3423339364:
              if (Operators.CompareString(str3, "I", false) == 0)
                goto label_51;
              else
                goto label_54;
            case 3440116983:
              if (Operators.CompareString(str3, "H", false) == 0)
                goto label_51;
              else
                goto label_54;
            case 3456894602:
              if (Operators.CompareString(str3, "K", false) == 0)
              {
                num = 0.3f;
                goto label_54;
              }
              else
                goto label_54;
            case 3473672221:
              if (Operators.CompareString(str3, "J", false) == 0)
              {
                num = 0.3f;
                goto label_54;
              }
              else
                goto label_54;
            default:
              goto label_54;
          }
          num = 0.5f;
          break;
label_51:
          num = 0.45f;
          break;
      }
label_54:
      return num;
    }

    private void Q(Survey_Class RdSAP)
    {
      Survey_Class surveyClass = RdSAP;
      int index1 = 0;
      switch (surveyClass.Extensions[0].WallConstruction)
      {
        case 1:
        case 2:
        case 3:
          if (surveyClass.Extensions[0].WallInsulation == 4 | surveyClass.Extensions[0].WallInsulation == 5 && (double) this.Dwelling.Walls[index1].U_Value > 0.6)
          {
            this.Dwelling.Walls[index1].U_Value = 0.3f;
            if (this.EXT.IncFlatCorridor)
              this.Dwelling.Walls[checked (this.Dwelling.Walls.Length - 1)].U_Value = (float) Math.Round(1.0 / (1.0 / (double) this.Dwelling.Walls[0].U_Value + 0.4), 2);
            this.RHI_Q = true;
            if (!surveyClass.Extensions[0].WallThicknessMeasured)
            {
              this.ChangeUFloor[0] = true;
              this.EXT.WallThickness.M = (double) this.GetWallThickNess(RdSAP, 0, false);
              break;
            }
            break;
          }
          break;
      }
      if (this.EXT.MainRoof)
      {
        if (!surveyClass.Extensions[0].RoofRoom_Edit)
        {
          checked { ++index1; }
        }
        else
        {
          if (surveyClass.Extensions[0].RoofRoom_GableWall[0].Area != 0.0)
            checked { ++index1; }
          if (surveyClass.Extensions[0].RoofRoom_GableWall[1].Area != 0.0)
            checked { ++index1; }
          if (surveyClass.Extensions[0].RoofRoom_StudWall[0].Area != 0.0)
            checked { ++index1; }
          if (surveyClass.Extensions[0].RoofRoom_StudWall[1].Area != 0.0)
            checked { ++index1; }
        }
      }
      if (this.EXT.Ext1)
        checked { ++index1; }
      if (this.EXT.Ext1)
      {
        switch (surveyClass.Extensions[1].WallConstruction)
        {
          case 1:
          case 2:
          case 3:
            if (surveyClass.Extensions[1].WallInsulation == 4 | surveyClass.Extensions[1].WallInsulation == 5 && (double) this.Dwelling.Walls[index1].U_Value > 0.6)
            {
              this.Dwelling.Walls[index1].U_Value = 0.3f;
              this.RHI_Q = true;
              if (!surveyClass.Extensions[1].WallThicknessMeasured)
              {
                this.ChangeUFloor[1] = true;
                this.EXT.WallThickness.E1 = (double) this.GetWallThickNess(RdSAP, 1, false);
                break;
              }
              break;
            }
            break;
        }
      }
      if (this.EXT.Ext1Roof)
      {
        if (!surveyClass.Extensions[1].RoofRoom_Edit)
        {
          checked { ++index1; }
        }
        else
        {
          if (surveyClass.Extensions[1].RoofRoom_GableWall[0].Area != 0.0)
            checked { ++index1; }
          if (surveyClass.Extensions[1].RoofRoom_GableWall[1].Area != 0.0)
            checked { ++index1; }
          if (surveyClass.Extensions[1].RoofRoom_StudWall[0].Area != 0.0)
            checked { ++index1; }
          if (surveyClass.Extensions[1].RoofRoom_StudWall[1].Area != 0.0)
            checked { ++index1; }
        }
      }
      if (this.EXT.Ext2)
        checked { ++index1; }
      if (this.EXT.Ext2)
      {
        switch (surveyClass.Extensions[2].WallConstruction)
        {
          case 1:
          case 2:
          case 3:
            if (surveyClass.Extensions[2].WallInsulation == 4 | surveyClass.Extensions[2].WallInsulation == 5 && (double) this.Dwelling.Walls[index1].U_Value > 0.6)
            {
              this.Dwelling.Walls[index1].U_Value = 0.3f;
              this.RHI_Q = true;
              if (!surveyClass.Extensions[2].WallThicknessMeasured)
              {
                this.ChangeUFloor[2] = true;
                this.EXT.WallThickness.E2 = (double) this.GetWallThickNess(RdSAP, 2, false);
                break;
              }
              break;
            }
            break;
        }
      }
      if (this.EXT.Ext2Roof)
      {
        if (!surveyClass.Extensions[2].RoofRoom_Edit)
        {
          checked { ++index1; }
        }
        else
        {
          if (surveyClass.Extensions[2].RoofRoom_GableWall[0].Area != 0.0)
            checked { ++index1; }
          if (surveyClass.Extensions[2].RoofRoom_GableWall[1].Area != 0.0)
            checked { ++index1; }
          if (surveyClass.Extensions[2].RoofRoom_StudWall[0].Area != 0.0)
            checked { ++index1; }
          if (surveyClass.Extensions[2].RoofRoom_StudWall[1].Area != 0.0)
            checked { ++index1; }
        }
      }
      if (this.EXT.Ext3)
        checked { ++index1; }
      if (this.EXT.Ext3)
      {
        switch (surveyClass.Extensions[3].WallConstruction)
        {
          case 1:
          case 2:
          case 3:
            if (surveyClass.Extensions[3].WallInsulation == 4 | surveyClass.Extensions[3].WallInsulation == 5 && (double) this.Dwelling.Walls[index1].U_Value > 0.6)
            {
              this.Dwelling.Walls[index1].U_Value = 0.3f;
              this.RHI_Q = true;
              if (!surveyClass.Extensions[3].WallThicknessMeasured)
              {
                this.ChangeUFloor[3] = true;
                this.EXT.WallThickness.E3 = (double) this.GetWallThickNess(RdSAP, 3, false);
                break;
              }
              break;
            }
            break;
        }
      }
      if (this.EXT.Ext3Roof)
      {
        if (!surveyClass.Extensions[3].RoofRoom_Edit)
        {
          checked { ++index1; }
        }
        else
        {
          if (surveyClass.Extensions[3].RoofRoom_GableWall[0].Area != 0.0)
            checked { ++index1; }
          if (surveyClass.Extensions[3].RoofRoom_GableWall[1].Area != 0.0)
            checked { ++index1; }
          if (surveyClass.Extensions[3].RoofRoom_StudWall[0].Area != 0.0)
            checked { ++index1; }
          if (surveyClass.Extensions[3].RoofRoom_StudWall[1].Area != 0.0)
            checked { ++index1; }
        }
      }
      if (this.EXT.Ext4)
        checked { ++index1; }
      if (this.EXT.Ext4)
      {
        switch (surveyClass.Extensions[4].WallConstruction)
        {
          case 1:
          case 2:
          case 3:
            if (surveyClass.Extensions[4].WallInsulation == 4 | surveyClass.Extensions[4].WallInsulation == 5 && (double) this.Dwelling.Walls[index1].U_Value > 0.6)
            {
              this.Dwelling.Walls[index1].U_Value = 0.3f;
              this.RHI_Q = true;
              if (!surveyClass.Extensions[4].WallThicknessMeasured)
              {
                this.ChangeUFloor[4] = true;
                this.EXT.WallThickness.E3 = (double) this.GetWallThickNess(RdSAP, 4, false);
                break;
              }
              break;
            }
            break;
        }
      }
      if (this.EXT.Ext4Roof)
      {
        if (!surveyClass.Extensions[4].RoofRoom_Edit)
        {
          checked { ++index1; }
        }
        else
        {
          if (surveyClass.Extensions[4].RoofRoom_GableWall[0].Area != 0.0)
            checked { ++index1; }
          if (surveyClass.Extensions[4].RoofRoom_GableWall[1].Area != 0.0)
            checked { ++index1; }
          if (surveyClass.Extensions[4].RoofRoom_StudWall[0].Area != 0.0)
            checked { ++index1; }
          if (surveyClass.Extensions[4].RoofRoom_StudWall[1].Area != 0.0)
            checked { ++index1; }
        }
      }
      int numberOfExtension = RdSAP.Age.NumberOfExtension;
      int index2 = 0;
      while (index2 <= numberOfExtension)
      {
        if (surveyClass.Extensions[index2].AltPresent)
        {
          checked { ++index1; }
          switch (surveyClass.Extensions[index2].AltWallConstruction)
          {
            case 1:
            case 2:
            case 3:
              if (surveyClass.Extensions[index2].AltWallInsulationType == 4 && (double) this.Dwelling.Walls[index1].U_Value > 0.6)
              {
                string str = "";
                switch (index2)
                {
                  case 0:
                    str = this.EXT.Ages.MAge;
                    break;
                  case 1:
                    str = this.EXT.Ages.E1Age;
                    break;
                  case 2:
                    str = this.EXT.Ages.E2Age;
                    break;
                  case 3:
                    str = this.EXT.Ages.E3Age;
                    break;
                  case 4:
                    str = this.EXT.Ages.E4Age;
                    break;
                }
                this.Dwelling.Walls[index1].U_Value = 0.3f;
                this.RHI_Q = true;
                this.ChangeUFloor[5] = true;
                break;
              }
              break;
          }
        }
        checked { ++index2; }
      }
      if (this.RHI_Q)
      {
        if (this.ChangeUFloor[0] | this.ChangeUFloor[1] | this.ChangeUFloor[2] | this.ChangeUFloor[3] | this.ChangeUFloor[4])
        {
          this.Dimensions_1(RdSAP);
          this.WallAreas(RdSAP);
          this.RoofAreas(RdSAP);
          this.WindowArea(RdSAP);
          this.Floors(RdSAP);
        }
        if (this.ChangeUFloor[0])
        {
          this.Dwelling.LivingArea = 0.0f;
          int num1 = checked (this.Dwelling.Storeys - 1);
          int index3 = 0;
          while (index3 <= num1)
          {
            this.Dwelling.Dims[index3].Perimeter = (float) Math.Round((double) this.Dwelling.Dims[index3].Perimeter, 2);
            this.Dwelling.Dims[index3].Area = (float) Math.Round((double) this.Dwelling.Dims[index3].Area, 2);
            this.Dwelling.Dims[index3].Height = (float) Math.Round((double) this.Dwelling.Dims[index3].Height, 2);
            // ISSUE: variable of a reference type
            float& local;
            // ISSUE: explicit reference operation
            double num2 = (double) ^(local = ref this.Dwelling.LivingArea) + (double) this.Dwelling.Dims[index3].Area;
            local = (float) num2;
            checked { ++index3; }
          }
          int NoofRooms = surveyClass.Age.MHabRooms;
          if (NoofRooms > 20)
            NoofRooms = 20;
          this.Dwelling.LivingFraction = this.Fraction(NoofRooms);
          // ISSUE: variable of a reference type
          float& local1;
          // ISSUE: explicit reference operation
          double num3 = (double) ^(local1 = ref this.Dwelling.LivingArea) * (double) this.Dwelling.LivingFraction;
          local1 = (float) num3;
        }
        this.CalculationImprove2012Regional.Dwelling = this.Dwelling;
        this.RHI.SolidInsulation = checked ((int) Math.Round(unchecked (Convert.ToDouble(Math.Round(new Decimal(checked (this.RHI.SpaceHeatingExisting - this.RHI.LoftInsulation - this.RHI.CavityInsulation)))) - this.CalculationImprove2012Regional.Calculation.Space_heating_requirement.Box98)));
      }
    }

    private float Fraction(int NoofRooms)
    {
      switch (NoofRooms)
      {
        case 1:
          return 0.75f;
        case 2:
          return 0.5f;
        case 3:
          return 0.3f;
        case 4:
          return 0.25f;
        case 5:
          return 0.21f;
        case 6:
          return 0.18f;
        case 7:
          return 0.16f;
        case 8:
          return 0.14f;
        case 9:
          return 0.13f;
        case 10:
          return 0.12f;
        case 11:
          return 0.11f;
        case 12:
          return 0.1f;
        case 13:
          return 0.1f;
        case 14:
        case 15:
        case 16:
        case 17:
        case 18:
        case 19:
        case 20:
          return 0.09f;
        default:
          return 0.0f;
      }
    }

    private float GetWallThickNess(Survey_Class RdSAP, int E, bool Alt)
    {
      string str = "";
      Enums.WallConstructionCode wallConstruction;
      Enums.WallInsulationCode wallInsulationCode;
      if (Alt)
      {
        wallConstruction = (Enums.WallConstructionCode) RdSAP.Extensions[E].AltWallConstruction;
        wallInsulationCode = (Enums.WallInsulationCode) RdSAP.Extensions[E].AltWallInsulationType;
      }
      else
      {
        wallConstruction = (Enums.WallConstructionCode) RdSAP.Extensions[E].WallConstruction;
        wallInsulationCode = (Enums.WallInsulationCode) RdSAP.Extensions[E].WallInsulation;
      }
      Survey_Class surveyClass = RdSAP;
      switch (wallConstruction)
      {
        case Enums.WallConstructionCode.Granite_or_whinstone:
          closure_0 = !(wallInsulationCode != Enums.WallInsulationCode.Internal & wallInsulationCode != Enums.WallInsulationCode.External) ? "Stone + insulation" : "Stone + insulation";
          break;
        case Enums.WallConstructionCode.Sandstone:
          closure_0 = !(wallInsulationCode != Enums.WallInsulationCode.Internal & wallInsulationCode != Enums.WallInsulationCode.External) ? "Stone + insulation" : "Stone + insulation";
          break;
        case Enums.WallConstructionCode.Solid_brick:
          closure_0 = !(wallInsulationCode != Enums.WallInsulationCode.Internal & wallInsulationCode != Enums.WallInsulationCode.External) ? "Solid Brick + insulation" : "Solid Brick + insulation";
          break;
        case Enums.WallConstructionCode.Cavity:
          closure_0 = "Cavity";
          break;
        case Enums.WallConstructionCode.Timber_frame:
          closure_0 = !(wallInsulationCode != Enums.WallInsulationCode.Internal & wallInsulationCode != Enums.WallInsulationCode.External) ? "Timber Frame + insulation" : "Timber Frame";
          break;
        case Enums.WallConstructionCode.System_built:
          closure_0 = !(wallInsulationCode != Enums.WallInsulationCode.Internal & wallInsulationCode != Enums.WallInsulationCode.External) ? "System Build + insulation" : "System Build";
          break;
        case Enums.WallConstructionCode.Cob_wall:
          closure_0 = !(wallInsulationCode != Enums.WallInsulationCode.Internal & wallInsulationCode != Enums.WallInsulationCode.External) ? "Cob+ Insulation" : "Cob";
          break;
      }
      string Right = "";
      switch (E)
      {
        case 0:
          this.EXT.FloorType.M = closure_0;
          Right = this.EXT.Ages.MAge;
          break;
        case 1:
          this.EXT.FloorType.E1 = closure_0;
          Right = this.EXT.Ages.E1Age;
          break;
        case 2:
          this.EXT.FloorType.E2 = closure_0;
          Right = this.EXT.Ages.E2Age;
          break;
        case 3:
          this.EXT.FloorType.E3 = closure_0;
          Right = this.EXT.Ages.E3Age;
          break;
        case 4:
          this.EXT.FloorType.M = closure_0;
          Right = this.EXT.Ages.E4Age;
          break;
      }
      float wallThickNess;
      if (surveyClass.General.Country == 3)
      {
        List<AppendixS.WallThickness> list = SAP_Module.AppenS.s3Scotland.Where<AppendixS.WallThickness>((Func<AppendixS.WallThickness, bool>) (b => Operators.CompareString(b.WallType, closure_0, false) == 0 & Operators.CompareString(b.AgeBand, Right, false) == 0)).ToList<AppendixS.WallThickness>();
        try
        {
          wallThickNess = (float) (Conversion.Val(list[0].WallThickness) / 1000.0);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          wallThickNess = 0.0f;
          ProjectData.ClearProjectError();
        }
      }
      else
      {
        List<AppendixS.WallThickness> list = SAP_Module.AppenS.s3.Where<AppendixS.WallThickness>((Func<AppendixS.WallThickness, bool>) (b => Operators.CompareString(b.WallType, closure_0, false) == 0 & Operators.CompareString(b.AgeBand, Right, false) == 0)).ToList<AppendixS.WallThickness>();
        try
        {
          wallThickNess = (float) (Conversion.Val(list[0].WallThickness) / 1000.0);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          wallThickNess = 0.0f;
          ProjectData.ClearProjectError();
        }
      }
      return wallThickNess;
    }

    private void Dimensions_1(Survey_Class RdSAP)
    {
      Survey_Class surveyClass = RdSAP;
      this.Dwelling.Dims = new SAP_Module.Dimensions[checked (this.EXT.MStoreys + this.EXT.E1Storeys + this.EXT.E2Storeys + this.EXT.E3Storeys + this.EXT.E4Storeys - 1 + 1)];
      int num1 = checked (this.EXT.MStoreys - 1);
      int index1 = 0;
      while (index1 <= num1)
      {
        this.Dwelling.Dims[index1] = new SAP_Module.Dimensions();
        if (index1 == 0)
        {
          this.Dwelling.Dims[index1].Area = (float) surveyClass.Extensions[0].Storey[0].Area;
          this.Dwelling.Dims[index1].Perimeter = (float) surveyClass.Extensions[0].Storey[0].Perimeter;
          this.Dwelling.Dims[index1].Height = (float) surveyClass.Extensions[0].Storey[0].Height;
          this.Dwelling.Dims[index1].Type = 1;
        }
        else if (index1 == checked (this.EXT.MStoreys - 1) & this.EXT.MainRoof)
        {
          this.Dwelling.Dims[index1].Area = (float) surveyClass.Extensions[0].RoofRoomFloor_Area;
          this.Dwelling.Dims[index1].Height = 2.45f;
          this.Dwelling.Dims[index1].Type = 3;
        }
        else
        {
          int index2 = index1;
          this.Dwelling.Dims[index1].Area = (float) surveyClass.Extensions[0].Storey[index2].Area;
          this.Dwelling.Dims[index1].Perimeter = (float) surveyClass.Extensions[0].Storey[index2].Perimeter;
          this.Dwelling.Dims[index1].Height = (float) (surveyClass.Extensions[0].Storey[index2].Height + 0.25);
          this.Dwelling.Dims[index1].Type = 2;
          if ((double) this.Dwelling.Dims[index1].Area > (double) this.Dwelling.Dims[checked (index1 - 1)].Area)
          {
            RdSAP_TO_SAP.ExposedFloor exposed;
            double num2 = (exposed = this.EXT.Exposed).A1_M + ((double) this.Dwelling.Dims[index1].Area - (double) this.Dwelling.Dims[checked (index1 - 1)].Area);
            exposed.A1_M = num2;
          }
        }
        this.Dwelling.Dims[index1].Floor = index1;
        checked { ++index1; }
      }
      if (this.EXT.Exposed.A1_M > 0.0)
        this.EXT.Exposed.Include_M = true;
      if (this.EXT.Ext1)
      {
        int mstoreys = this.EXT.MStoreys;
        int num3 = checked (this.EXT.MStoreys + this.EXT.E1Storeys - 1);
        int index3 = mstoreys;
        while (index3 <= num3)
        {
          int index4 = checked (index3 - this.EXT.MStoreys);
          this.Dwelling.Dims[index3] = new SAP_Module.Dimensions();
          if (index3 == this.EXT.MStoreys)
          {
            this.Dwelling.Dims[index3].Area = (float) surveyClass.Extensions[1].Storey[index4].Area;
            this.Dwelling.Dims[index3].Perimeter = (float) surveyClass.Extensions[1].Storey[index4].Perimeter;
            this.Dwelling.Dims[index3].Height = (float) surveyClass.Extensions[1].Storey[index4].Height;
            this.Dwelling.Dims[index3].Type = 1;
          }
          else if (index3 == checked (this.EXT.MStoreys + this.EXT.E1Storeys - 1) & this.EXT.Ext1Roof)
          {
            this.Dwelling.Dims[index3].Area = (float) surveyClass.Extensions[1].RoofRoomFloor_Area;
            this.Dwelling.Dims[index3].Height = 2.45f;
            this.Dwelling.Dims[index3].Type = 3;
          }
          else
          {
            this.Dwelling.Dims[index3].Area = (float) surveyClass.Extensions[1].Storey[index4].Area;
            this.Dwelling.Dims[index3].Perimeter = (float) surveyClass.Extensions[1].Storey[index4].Perimeter;
            this.Dwelling.Dims[index3].Height = (float) (surveyClass.Extensions[1].Storey[index4].Height + 0.25);
            this.Dwelling.Dims[index3].Type = 2;
            if ((double) this.Dwelling.Dims[index3].Area > (double) this.Dwelling.Dims[checked (index3 - 1)].Area)
            {
              RdSAP_TO_SAP.ExposedFloor exposed;
              double num4 = (exposed = this.EXT.Exposed).A1_E1 + ((double) this.Dwelling.Dims[index3].Area - (double) this.Dwelling.Dims[checked (index3 - 1)].Area);
              exposed.A1_E1 = num4;
            }
          }
          this.Dwelling.Dims[index3].Floor = checked (index3 - this.EXT.MStoreys);
          checked { ++index3; }
        }
        if (this.EXT.Exposed.A1_E1 > 0.0)
          this.EXT.Exposed.Include_E1 = true;
      }
      if (this.EXT.Ext2)
      {
        int num5 = checked (this.EXT.MStoreys + this.EXT.E1Storeys);
        int num6 = checked (this.EXT.MStoreys + this.EXT.E1Storeys + this.EXT.E2Storeys - 1);
        int index5 = num5;
        while (index5 <= num6)
        {
          int index6 = checked (index5 - this.EXT.MStoreys + this.EXT.E1Storeys);
          this.Dwelling.Dims[index5] = new SAP_Module.Dimensions();
          if (index5 == checked (this.EXT.MStoreys + this.EXT.E1Storeys))
          {
            this.Dwelling.Dims[index5].Area = (float) surveyClass.Extensions[2].Storey[index6].Area;
            this.Dwelling.Dims[index5].Perimeter = (float) surveyClass.Extensions[2].Storey[index6].Perimeter;
            this.Dwelling.Dims[index5].Height = (float) surveyClass.Extensions[2].Storey[index6].Height;
            this.Dwelling.Dims[index5].Type = 1;
          }
          else if (index5 == checked (this.EXT.MStoreys + this.EXT.E1Storeys + this.EXT.E2Storeys - 1) & this.EXT.Ext2Roof)
          {
            this.Dwelling.Dims[index5].Area = (float) surveyClass.Extensions[2].RoofRoomFloor_Area;
            this.Dwelling.Dims[index5].Height = 2.45f;
            this.Dwelling.Dims[index5].Type = 3;
          }
          else
          {
            this.Dwelling.Dims[index5].Area = (float) surveyClass.Extensions[2].Storey[index6].Area;
            this.Dwelling.Dims[index5].Perimeter = (float) surveyClass.Extensions[2].Storey[index6].Perimeter;
            this.Dwelling.Dims[index5].Height = (float) (surveyClass.Extensions[2].Storey[index6].Height + 0.25);
            this.Dwelling.Dims[index5].Type = 2;
            if ((double) this.Dwelling.Dims[index5].Area > (double) this.Dwelling.Dims[checked (index5 - 1)].Area)
            {
              RdSAP_TO_SAP.ExposedFloor exposed;
              double num7 = (exposed = this.EXT.Exposed).A1_E2 + ((double) this.Dwelling.Dims[index5].Area - (double) this.Dwelling.Dims[checked (index5 - 1)].Area);
              exposed.A1_E2 = num7;
            }
          }
          this.Dwelling.Dims[index5].Floor = checked (index5 - this.EXT.MStoreys + this.EXT.E1Storeys);
          checked { ++index5; }
        }
        if (this.EXT.Exposed.A1_E2 > 0.0)
          this.EXT.Exposed.Include_E2 = true;
      }
      if (this.EXT.Ext3)
      {
        int num8 = checked (this.EXT.MStoreys + this.EXT.E1Storeys + this.EXT.E2Storeys);
        int num9 = checked (this.EXT.MStoreys + this.EXT.E1Storeys + this.EXT.E2Storeys + this.EXT.E3Storeys - 1);
        int index7 = num8;
        while (index7 <= num9)
        {
          int index8 = checked (index7 - this.EXT.MStoreys + this.EXT.E1Storeys + this.EXT.E2Storeys);
          this.Dwelling.Dims[index7] = new SAP_Module.Dimensions();
          if (index7 == checked (this.EXT.MStoreys + this.EXT.E1Storeys + this.EXT.E2Storeys))
          {
            this.Dwelling.Dims[index7].Area = (float) surveyClass.Extensions[3].Storey[index8].Area;
            this.Dwelling.Dims[index7].Perimeter = (float) surveyClass.Extensions[3].Storey[index8].Perimeter;
            this.Dwelling.Dims[index7].Height = (float) surveyClass.Extensions[3].Storey[index8].Height;
            this.Dwelling.Dims[index7].Type = 1;
          }
          else if (index7 == checked (this.EXT.MStoreys + this.EXT.E1Storeys + this.EXT.E2Storeys + this.EXT.E3Storeys - 1) & this.EXT.Ext3Roof)
          {
            this.Dwelling.Dims[index7].Area = (float) surveyClass.Extensions[3].RoofRoomFloor_Area;
            this.Dwelling.Dims[index7].Height = 2.45f;
            this.Dwelling.Dims[index7].Type = 3;
          }
          else
          {
            this.Dwelling.Dims[index7].Area = (float) surveyClass.Extensions[3].Storey[index8].Area;
            this.Dwelling.Dims[index7].Perimeter = (float) surveyClass.Extensions[3].Storey[index8].Perimeter;
            this.Dwelling.Dims[index7].Height = (float) (surveyClass.Extensions[3].Storey[index8].Height + 0.25);
            this.Dwelling.Dims[index7].Type = 2;
            if ((double) this.Dwelling.Dims[index7].Area > (double) this.Dwelling.Dims[checked (index7 - 1)].Area)
            {
              RdSAP_TO_SAP.ExposedFloor exposed;
              double num10 = (exposed = this.EXT.Exposed).A1_E3 + ((double) this.Dwelling.Dims[index7].Area - (double) this.Dwelling.Dims[checked (index7 - 1)].Area);
              exposed.A1_E3 = num10;
            }
          }
          this.Dwelling.Dims[index7].Floor = checked (index7 - this.EXT.MStoreys + this.EXT.E1Storeys + this.EXT.E2Storeys);
          checked { ++index7; }
        }
        if (this.EXT.Exposed.A1_E3 > 0.0)
          this.EXT.Exposed.Include_E3 = true;
      }
      if (this.EXT.Ext4)
      {
        int num11 = checked (this.EXT.MStoreys + this.EXT.E1Storeys + this.EXT.E2Storeys + this.EXT.E3Storeys);
        int num12 = checked (this.EXT.MStoreys + this.EXT.E1Storeys + this.EXT.E2Storeys + this.EXT.E3Storeys + this.EXT.E4Storeys - 1);
        int index9 = num11;
        while (index9 <= num12)
        {
          int index10 = checked (index9 - this.EXT.MStoreys + this.EXT.E1Storeys + this.EXT.E2Storeys + this.EXT.E3Storeys);
          this.Dwelling.Dims[index9] = new SAP_Module.Dimensions();
          if (index9 == checked (this.EXT.MStoreys + this.EXT.E1Storeys + this.EXT.E2Storeys + this.EXT.E3Storeys))
          {
            this.Dwelling.Dims[index9].Area = (float) surveyClass.Extensions[4].Storey[index10].Area;
            this.Dwelling.Dims[index9].Perimeter = (float) surveyClass.Extensions[4].Storey[index10].Perimeter;
            this.Dwelling.Dims[index9].Height = (float) surveyClass.Extensions[4].Storey[index10].Height;
            this.Dwelling.Dims[index9].Type = 1;
          }
          else if (index9 == checked (this.EXT.MStoreys + this.EXT.E1Storeys + this.EXT.E2Storeys + this.EXT.E3Storeys + this.EXT.E4Storeys - 1) & this.EXT.Ext4Roof)
          {
            this.Dwelling.Dims[index9].Area = (float) surveyClass.Extensions[4].RoofRoomFloor_Area;
            this.Dwelling.Dims[index9].Height = 2.45f;
            this.Dwelling.Dims[index9].Type = 3;
          }
          else
          {
            this.Dwelling.Dims[index9].Area = (float) surveyClass.Extensions[4].Storey[index10].Area;
            this.Dwelling.Dims[index9].Perimeter = (float) surveyClass.Extensions[4].Storey[index10].Perimeter;
            this.Dwelling.Dims[index9].Height = (float) (surveyClass.Extensions[4].Storey[index10].Height + 0.25);
            this.Dwelling.Dims[index9].Type = 2;
            if ((double) this.Dwelling.Dims[index9].Area > (double) this.Dwelling.Dims[checked (index9 - 1)].Area)
            {
              RdSAP_TO_SAP.ExposedFloor exposed;
              double num13 = (exposed = this.EXT.Exposed).A1_E4 + ((double) this.Dwelling.Dims[index9].Area - (double) this.Dwelling.Dims[checked (index9 - 1)].Area);
              exposed.A1_E4 = num13;
            }
          }
          this.Dwelling.Dims[index9].Floor = checked (index9 - this.EXT.MStoreys + this.EXT.E1Storeys + this.EXT.E2Storeys + this.EXT.E3Storeys);
          checked { ++index9; }
        }
        if (this.EXT.Exposed.A1_E4 > 0.0)
          this.EXT.Exposed.Include_E4 = true;
      }
      if (surveyClass.Age.DimType != 2)
      {
        int num14 = checked (this.EXT.MaxFloors - 1);
        int num15 = 0;
        while (num15 <= num14)
        {
          double num16 = 0.0;
          double num17 = 0.0;
          int num18 = checked (this.Dwelling.Dims.Length - 1);
          int index11 = 0;
          while (index11 <= num18)
          {
            if (this.Dwelling.Dims[index11].Type != 3 & this.Dwelling.Dims[index11].Floor == num15)
            {
              num16 += (double) this.Dwelling.Dims[index11].Perimeter;
              num17 += (double) this.Dwelling.Dims[index11].Area;
            }
            checked { ++index11; }
          }
          double num19;
          double num20;
          switch (surveyClass.General.PropertyType2)
          {
            case 1:
              num19 = num16 - 8.0 * this.EXT.WallThickness.M;
              num20 = num17 - this.EXT.WallThickness.M * num19 - 4.0 * this.EXT.WallThickness.M * this.EXT.WallThickness.M;
              break;
            case 2:
            case 3:
              if (num16 * num16 > 8.0 * num17)
              {
                num19 = num16 - 5.0 * this.EXT.WallThickness.M;
                double num21 = 0.5 * (num16 - Math.Sqrt(num16 * num16 - 8.0 * num17));
                num20 = num17 - this.EXT.WallThickness.M * (num16 + 0.5 * num21) + 3.0 * this.EXT.WallThickness.M * this.EXT.WallThickness.M;
                break;
              }
              num19 = num16 - 3.0 * this.EXT.WallThickness.M;
              num20 = num17 - this.EXT.WallThickness.M * num16 + 3.0 * this.EXT.WallThickness.M * this.EXT.WallThickness.M;
              break;
            case 4:
              num19 = num16 - 2.0 * this.EXT.WallThickness.M;
              num20 = num17 - this.EXT.WallThickness.M * (num16 + 2.0 * (num17 / num16)) + 2.0 * this.EXT.WallThickness.M * this.EXT.WallThickness.M;
              break;
            case 5:
              num19 = num16 - 3.0 * this.EXT.WallThickness.M;
              num20 = num17 - 1.5 * this.EXT.WallThickness.M * num16 + 2.25 * this.EXT.WallThickness.M * this.EXT.WallThickness.M;
              break;
            case 6:
              num19 = num16 - this.EXT.WallThickness.M;
              num20 = num17 - this.EXT.WallThickness.M * (num17 / num16 + 1.5 * num16) + 1.5 * this.EXT.WallThickness.M * this.EXT.WallThickness.M;
              break;
          }
          double num22 = num19 / num16;
          double num23 = num20 / num17;
          int num24 = checked (this.Dwelling.Dims.Length - 1);
          int index12 = 0;
          while (index12 <= num24)
          {
            if (this.Dwelling.Dims[index12].Type != 3 & this.Dwelling.Dims[index12].Floor == num15)
            {
              // ISSUE: variable of a reference type
              float& local1;
              // ISSUE: explicit reference operation
              double num25 = (double) (^(local1 = ref this.Dwelling.Dims[index12].Perimeter) * (float) num22);
              local1 = (float) num25;
              // ISSUE: variable of a reference type
              float& local2;
              // ISSUE: explicit reference operation
              double num26 = (double) (^(local2 = ref this.Dwelling.Dims[index12].Area) * (float) num23);
              local2 = (float) num26;
            }
            checked { ++index12; }
          }
          checked { ++num15; }
        }
        if (this.EXT.Exposed.Include_M)
        {
          int num27 = checked (this.EXT.MStoreys - 1);
          int index13 = 0;
          while (index13 <= num27)
          {
            if (index13 != 0 && !(index13 == checked (this.EXT.MStoreys - 1) & this.EXT.MainRoof) && (double) this.Dwelling.Dims[index13].Area > (double) this.Dwelling.Dims[checked (index13 - 1)].Area)
            {
              RdSAP_TO_SAP.ExposedFloor exposed;
              double num28 = (exposed = this.EXT.Exposed).A2_M + ((double) this.Dwelling.Dims[index13].Area - (double) this.Dwelling.Dims[checked (index13 - 1)].Area);
              exposed.A2_M = num28;
            }
            checked { ++index13; }
          }
        }
        if (this.EXT.Ext1 & this.EXT.Exposed.Include_E1)
        {
          int mstoreys = this.EXT.MStoreys;
          int num29 = checked (this.EXT.MStoreys + this.EXT.E1Storeys - 1);
          int index14 = mstoreys;
          while (index14 <= num29)
          {
            if (index14 != this.EXT.MStoreys && !(index14 == checked (this.EXT.MStoreys + this.EXT.E1Storeys - 1) & this.EXT.Ext1Roof) && (double) this.Dwelling.Dims[index14].Area > (double) this.Dwelling.Dims[checked (index14 - 1)].Area)
            {
              RdSAP_TO_SAP.ExposedFloor exposed;
              double num30 = (exposed = this.EXT.Exposed).A2_E2 + ((double) this.Dwelling.Dims[index14].Area - (double) this.Dwelling.Dims[checked (index14 - 1)].Area);
              exposed.A2_E2 = num30;
            }
            checked { ++index14; }
          }
        }
        if (this.EXT.Ext2 & this.EXT.Exposed.Include_E2)
        {
          int num31 = checked (this.EXT.MStoreys + this.EXT.E1Storeys);
          int num32 = checked (this.EXT.MStoreys + this.EXT.E1Storeys + this.EXT.E2Storeys - 1);
          int index15 = num31;
          while (index15 <= num32)
          {
            if (index15 != checked (this.EXT.MStoreys + this.EXT.E1Storeys) && !(index15 == checked (this.EXT.MStoreys + this.EXT.E1Storeys + this.EXT.E2Storeys - 1) & this.EXT.Ext2Roof) && (double) this.Dwelling.Dims[index15].Area > (double) this.Dwelling.Dims[checked (index15 - 1)].Area)
            {
              RdSAP_TO_SAP.ExposedFloor exposed;
              double num33 = (exposed = this.EXT.Exposed).A2_E2 + ((double) this.Dwelling.Dims[index15].Area - (double) this.Dwelling.Dims[checked (index15 - 1)].Area);
              exposed.A2_E2 = num33;
            }
            checked { ++index15; }
          }
        }
        if (this.EXT.Ext3 & this.EXT.Exposed.Include_E3)
        {
          int num34 = checked (this.EXT.MStoreys + this.EXT.E1Storeys + this.EXT.E2Storeys);
          int num35 = checked (this.EXT.MStoreys + this.EXT.E1Storeys + this.EXT.E2Storeys + this.EXT.E3Storeys - 1);
          int index16 = num34;
          while (index16 <= num35)
          {
            if (index16 != checked (this.EXT.MStoreys + this.EXT.E1Storeys + this.EXT.E2Storeys) && !(index16 == checked (this.EXT.MStoreys + this.EXT.E1Storeys + this.EXT.E2Storeys + this.EXT.E3Storeys - 1) & this.EXT.Ext3Roof) && (double) this.Dwelling.Dims[index16].Area > (double) this.Dwelling.Dims[checked (index16 - 1)].Area)
            {
              RdSAP_TO_SAP.ExposedFloor exposed;
              double num36 = (exposed = this.EXT.Exposed).A2_E3 + ((double) this.Dwelling.Dims[index16].Area - (double) this.Dwelling.Dims[checked (index16 - 1)].Area);
              exposed.A2_E3 = num36;
            }
            checked { ++index16; }
          }
        }
        if (this.EXT.Ext4 & this.EXT.Exposed.Include_E4)
        {
          int num37 = checked (this.EXT.MStoreys + this.EXT.E1Storeys + this.EXT.E2Storeys + this.EXT.E3Storeys);
          int num38 = checked (this.EXT.MStoreys + this.EXT.E1Storeys + this.EXT.E2Storeys + this.EXT.E3Storeys + this.EXT.E4Storeys - 1);
          int index17 = num37;
          while (index17 <= num38)
          {
            if (index17 != checked (this.EXT.MStoreys + this.EXT.E1Storeys + this.EXT.E2Storeys) && !(index17 == checked (this.EXT.MStoreys + this.EXT.E1Storeys + this.EXT.E2Storeys + this.EXT.E3Storeys + this.EXT.E4Storeys - 1) & this.EXT.Ext4Roof) && (double) this.Dwelling.Dims[index17].Area > (double) this.Dwelling.Dims[checked (index17 - 1)].Area)
            {
              RdSAP_TO_SAP.ExposedFloor exposed;
              double num39 = (exposed = this.EXT.Exposed).A2_E4 + ((double) this.Dwelling.Dims[index17].Area - (double) this.Dwelling.Dims[checked (index17 - 1)].Area);
              exposed.A2_E4 = num39;
            }
            checked { ++index17; }
          }
        }
      }
      if (this.EXT.Cons)
      {
        // ISSUE: variable of a reference type
        SAP_Module.Dimensions[]& local;
        // ISSUE: explicit reference operation
        SAP_Module.Dimensions[] dimensionsArray = (SAP_Module.Dimensions[]) Utils.CopyArray((Array) ^(local = ref this.Dwelling.Dims), (Array) new SAP_Module.Dimensions[checked (this.Dwelling.Dims.Length + 1)]);
        local = dimensionsArray;
        this.Dwelling.Dims[checked (this.Dwelling.Dims.Length - 1)] = new SAP_Module.Dimensions();
        this.Dwelling.Dims[checked (this.Dwelling.Dims.Length - 1)].Area = (float) surveyClass.Conservatory.FloorArea;
        this.Dwelling.Dims[checked (this.Dwelling.Dims.Length - 1)].Perimeter = (float) surveyClass.Conservatory.GlazedPerimeter;
        switch (surveyClass.Conservatory.RoomHeight)
        {
          case 1:
            this.Dwelling.Dims[checked (this.Dwelling.Dims.Length - 1)].Height = (float) Math.Round(surveyClass.Extensions[0].Storey[0].Height, 2);
            break;
          case 2:
            this.Dwelling.Dims[checked (this.Dwelling.Dims.Length - 1)].Height = (float) Math.Round(surveyClass.Extensions[0].Storey[0].Height + 0.25 + 0.5 * surveyClass.Extensions[0].Storey[1].Height, 2);
            break;
          case 3:
            this.Dwelling.Dims[checked (this.Dwelling.Dims.Length - 1)].Height = (float) Math.Round(surveyClass.Extensions[0].Storey[0].Height + 0.25 + surveyClass.Extensions[0].Storey[1].Height, 2);
            break;
          case 4:
            this.Dwelling.Dims[checked (this.Dwelling.Dims.Length - 1)].Height = (float) Math.Round(surveyClass.Extensions[0].Storey[0].Height + 0.5 + surveyClass.Extensions[0].Storey[1].Height + 0.5 * surveyClass.Extensions[0].Storey[2].Height, 2);
            break;
        }
      }
      this.Dwelling.Storeys = this.Dwelling.Dims.Length;
    }

    private void Floors(Survey_Class RdSAP)
    {
      Survey_Class surveyClass = RdSAP;
      int index1 = 0;
      float num1;
      if (this.ChangeUFloor[0])
      {
        if (surveyClass.Extensions[0].LowestFloor == 5)
        {
          if (surveyClass.General.Country == 4)
          {
            string mage = this.EXT.Ages.MAge;
            // ISSUE: reference to a compiler-generated method
            switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(mage))
            {
              case 3222007936:
                if (Operators.CompareString(mage, "E", false) == 0)
                  break;
                goto label_55;
              case 3238785555:
                if (Operators.CompareString(mage, "D", false) == 0)
                  break;
                goto label_55;
              case 3255563174:
                if (Operators.CompareString(mage, "G", false) == 0)
                  break;
                goto label_55;
              case 3272340793:
                if (Operators.CompareString(mage, "F", false) == 0)
                  break;
                goto label_55;
              case 3289118412:
                if (Operators.CompareString(mage, "A", false) == 0)
                  break;
                goto label_55;
              case 3322673650:
                if (Operators.CompareString(mage, "C", false) == 0)
                  break;
                goto label_55;
              case 3339451269:
                if (Operators.CompareString(mage, "B", false) == 0)
                  break;
                goto label_55;
              case 3423339364:
                if (Operators.CompareString(mage, "I", false) == 0)
                {
                  num1 = 0.05f;
                  goto label_55;
                }
                else
                  goto label_55;
              case 3440116983:
                if (Operators.CompareString(mage, "H", false) == 0)
                {
                  num1 = 0.025f;
                  goto label_55;
                }
                else
                  goto label_55;
              case 3456894602:
                if (Operators.CompareString(mage, "K", false) == 0)
                {
                  num1 = 0.1f;
                  goto label_55;
                }
                else
                  goto label_55;
              case 3473672221:
                if (Operators.CompareString(mage, "J", false) == 0)
                {
                  num1 = 0.0f;
                  goto label_55;
                }
                else
                  goto label_55;
              default:
                goto label_55;
            }
            num1 = 0.0f;
          }
          else if (surveyClass.General.Country == 3)
          {
            string mage = this.EXT.Ages.MAge;
            // ISSUE: reference to a compiler-generated method
            switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(mage))
            {
              case 3222007936:
                if (Operators.CompareString(mage, "E", false) == 0)
                  break;
                goto label_55;
              case 3238785555:
                if (Operators.CompareString(mage, "D", false) == 0)
                  break;
                goto label_55;
              case 3255563174:
                if (Operators.CompareString(mage, "G", false) == 0)
                  break;
                goto label_55;
              case 3272340793:
                if (Operators.CompareString(mage, "F", false) == 0)
                  break;
                goto label_55;
              case 3289118412:
                if (Operators.CompareString(mage, "A", false) == 0)
                  break;
                goto label_55;
              case 3322673650:
                if (Operators.CompareString(mage, "C", false) == 0)
                  break;
                goto label_55;
              case 3339451269:
                if (Operators.CompareString(mage, "B", false) == 0)
                  break;
                goto label_55;
              case 3423339364:
                if (Operators.CompareString(mage, "I", false) == 0)
                {
                  num1 = 0.05f;
                  goto label_55;
                }
                else
                  goto label_55;
              case 3440116983:
                if (Operators.CompareString(mage, "H", false) == 0)
                {
                  num1 = 0.025f;
                  goto label_55;
                }
                else
                  goto label_55;
              case 3456894602:
                if (Operators.CompareString(mage, "K", false) == 0)
                {
                  num1 = 0.1f;
                  goto label_55;
                }
                else
                  goto label_55;
              case 3473672221:
                if (Operators.CompareString(mage, "J", false) == 0)
                {
                  num1 = 0.075f;
                  goto label_55;
                }
                else
                  goto label_55;
              default:
                goto label_55;
            }
            num1 = 0.0f;
          }
          else
          {
            string mage = this.EXT.Ages.MAge;
            // ISSUE: reference to a compiler-generated method
            switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(mage))
            {
              case 3222007936:
                if (Operators.CompareString(mage, "E", false) == 0)
                  break;
                goto default;
              case 3238785555:
                if (Operators.CompareString(mage, "D", false) == 0)
                  break;
                goto default;
              case 3255563174:
                if (Operators.CompareString(mage, "G", false) == 0)
                  break;
                goto default;
              case 3272340793:
                if (Operators.CompareString(mage, "F", false) == 0)
                  break;
                goto default;
              case 3289118412:
                if (Operators.CompareString(mage, "A", false) == 0)
                  break;
                goto default;
              case 3322673650:
                if (Operators.CompareString(mage, "C", false) == 0)
                  break;
                goto default;
              case 3339451269:
                if (Operators.CompareString(mage, "B", false) == 0)
                  break;
                goto default;
              case 3423339364:
                if (Operators.CompareString(mage, "I", false) == 0)
                {
                  num1 = 0.025f;
                  goto default;
                }
                else
                  goto default;
              case 3440116983:
                if (Operators.CompareString(mage, "H", false) == 0)
                  break;
                goto default;
              case 3456894602:
                if (Operators.CompareString(mage, "K", false) == 0)
                {
                  num1 = 0.1f;
                  goto default;
                }
                else
                  goto default;
              case 3473672221:
                if (Operators.CompareString(mage, "J", false) == 0)
                {
                  num1 = 0.075f;
                  goto default;
                }
                else
                  goto default;
              default:
label_54:
                goto label_55;
            }
            num1 = 0.0f;
            goto label_54;
          }
label_55:
          if (surveyClass.Extensions[0].FloorInsulation == 3 & (double) num1 < 0.05)
            num1 = 0.05f;
          float num2 = 2f * this.Dwelling.Dims[0].Area / this.Dwelling.Dims[0].Perimeter;
          if (this.EXT.WallThickness.M == 0.0)
            this.EXT.WallThickness.M = (double) this.GetWallThickNess(RdSAP, 0, false);
          if (surveyClass.Extensions[0].FloorConstruction == 1)
          {
            string mage = this.EXT.Ages.MAge;
            if (Operators.CompareString(mage, "A", false) == 0 || Operators.CompareString(mage, "B", false) == 0)
            {
              float num3 = (float) (this.EXT.WallThickness.M + 0.315);
              float num4 = (float) (3.0 * Math.Log(Math.PI * (double) num2 / (double) num3 + 1.0) / (Math.PI * (double) num2 + (double) num3));
              float num5 = (float) (9.0 / 10.0 / (double) num2 + 87.0 / 80.0 / (double) num2);
              this.Dwelling.Floors[index1].U_Value = (float) Math.Round(1.0 / (0.54 + 1.0 / ((double) num4 + (double) num5)), 2);
            }
            else
            {
              float num6 = (float) (this.EXT.WallThickness.M + 1.5 * (0.17 + (double) num1 / 0.035 + 0.04));
              this.Dwelling.Floors[index1].U_Value = (double) num6 >= (double) num2 ? (float) Math.Round(1.5 / (0.457 * (double) num2 + (double) num6), 2) : (float) Math.Round(3.0 * Math.Log(Math.PI * (double) num2 / (double) num6 + 1.0) / (Math.PI * (double) num2 + (double) num6), 2);
            }
          }
          else if (surveyClass.Extensions[0].FloorConstruction == 3 | surveyClass.Extensions[0].FloorConstruction == 4)
          {
            float num7 = (float) (this.EXT.WallThickness.M + 0.315);
            float num8 = (float) (3.0 * Math.Log(Math.PI * (double) num2 / (double) num7 + 1.0) / (Math.PI * (double) num2 + (double) num7));
            float num9 = (float) (9.0 / 10.0 / (double) num2 + 87.0 / 80.0 / (double) num2);
            this.Dwelling.Floors[index1].U_Value = (float) Math.Round(1.0 / (0.34 + (double) num1 / 0.035 + 0.2 + 1.0 / ((double) num8 + (double) num9)), 2);
          }
          else if (surveyClass.Extensions[0].FloorConstruction == 2)
          {
            float num10 = (float) (this.EXT.WallThickness.M + 1.5 * (0.17 + (double) num1 / 0.035 + 0.04));
            this.Dwelling.Floors[index1].U_Value = (double) num10 >= (double) num2 ? (float) Math.Round(1.5 / (0.457 * (double) num2 + (double) num10), 2) : (float) Math.Round(3.0 * Math.Log(Math.PI * (double) num2 / (double) num10 + 1.0) / (Math.PI * (double) num2 + (double) num10), 2);
          }
          this.Dwelling.Floors[index1].Name = "Main Ground Floor";
          this.Dwelling.Floors[index1].Type = "Ground floor";
          this.Dwelling.Floors[index1].Area = (float) Math.Round((double) this.Dwelling.Dims[0].Area, 2);
        }
        else if (surveyClass.Extensions[0].LowestFloor == 3)
        {
          this.Dwelling.Floors[index1].U_Value = 0.7f;
          this.Dwelling.Floors[index1].Name = "Main Floor";
          this.Dwelling.Floors[index1].Type = "Exposed floor";
          this.Dwelling.Floors[index1].Area = (float) Math.Round((double) this.Dwelling.Dims[0].Area, 2);
        }
        else if (surveyClass.Extensions[0].LowestFloor == 2 | surveyClass.Extensions[0].LowestFloor == 1)
        {
          if (surveyClass.Extensions[0].FloorInsulation == 1 | surveyClass.Extensions[0].FloorInsulation == 2)
          {
            string mage = this.EXT.Ages.MAge;
            // ISSUE: reference to a compiler-generated method
            switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(mage))
            {
              case 3222007936:
                if (Operators.CompareString(mage, "E", false) == 0)
                  break;
                goto default;
              case 3238785555:
                if (Operators.CompareString(mage, "D", false) == 0)
                  break;
                goto default;
              case 3255563174:
                if (Operators.CompareString(mage, "G", false) == 0)
                  break;
                goto default;
              case 3272340793:
                if (Operators.CompareString(mage, "F", false) == 0)
                  break;
                goto default;
              case 3289118412:
                if (Operators.CompareString(mage, "A", false) == 0)
                  break;
                goto default;
              case 3322673650:
                if (Operators.CompareString(mage, "C", false) == 0)
                  break;
                goto default;
              case 3339451269:
                if (Operators.CompareString(mage, "B", false) == 0)
                  break;
                goto default;
              case 3423339364:
                if (Operators.CompareString(mage, "I", false) == 0)
                  goto label_85;
                else
                  goto default;
              case 3440116983:
                if (Operators.CompareString(mage, "H", false) == 0)
                  goto label_85;
                else
                  goto default;
              case 3456894602:
                if (Operators.CompareString(mage, "K", false) == 0)
                {
                  this.Dwelling.Floors[index1].U_Value = 0.22f;
                  goto default;
                }
                else
                  goto default;
              case 3473672221:
                if (Operators.CompareString(mage, "J", false) == 0)
                {
                  this.Dwelling.Floors[index1].U_Value = 0.25f;
                  goto default;
                }
                else
                  goto default;
              default:
label_88:
                goto label_89;
            }
            this.Dwelling.Floors[index1].U_Value = 1.2f;
            goto label_88;
label_85:
            this.Dwelling.Floors[index1].U_Value = 0.51f;
            goto label_88;
          }
label_89:
          if (surveyClass.Extensions[0].FloorInsulation == 3)
          {
            string mage = this.EXT.Ages.MAge;
            // ISSUE: reference to a compiler-generated method
            switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(mage))
            {
              case 3222007936:
                if (Operators.CompareString(mage, "E", false) == 0)
                  break;
                goto default;
              case 3238785555:
                if (Operators.CompareString(mage, "D", false) == 0)
                  break;
                goto default;
              case 3255563174:
                if (Operators.CompareString(mage, "G", false) == 0)
                  break;
                goto default;
              case 3272340793:
                if (Operators.CompareString(mage, "F", false) == 0)
                  break;
                goto default;
              case 3289118412:
                if (Operators.CompareString(mage, "A", false) == 0)
                  break;
                goto default;
              case 3322673650:
                if (Operators.CompareString(mage, "C", false) == 0)
                  break;
                goto default;
              case 3339451269:
                if (Operators.CompareString(mage, "B", false) == 0)
                  break;
                goto default;
              case 3423339364:
                if (Operators.CompareString(mage, "I", false) == 0)
                  goto label_103;
                else
                  goto default;
              case 3440116983:
                if (Operators.CompareString(mage, "H", false) == 0)
                  goto label_103;
                else
                  goto default;
              case 3456894602:
                if (Operators.CompareString(mage, "K", false) == 0)
                {
                  this.Dwelling.Floors[index1].U_Value = 0.22f;
                  goto default;
                }
                else
                  goto default;
              case 3473672221:
                if (Operators.CompareString(mage, "J", false) == 0)
                {
                  this.Dwelling.Floors[index1].U_Value = 0.25f;
                  goto default;
                }
                else
                  goto default;
              default:
label_106:
                goto label_107;
            }
            this.Dwelling.Floors[index1].U_Value = 0.5f;
            goto label_106;
label_103:
            this.Dwelling.Floors[index1].U_Value = 0.5f;
            goto label_106;
          }
label_107:
          this.Dwelling.Floors[index1].Name = "Main Floor";
          this.Dwelling.Floors[index1].Type = "Exposed floor";
          this.Dwelling.Floors[index1].Area = (float) Math.Round((double) this.Dwelling.Dims[0].Area, 2);
        }
        else if (surveyClass.Extensions[0].LowestFloor == 6 | surveyClass.Extensions[0].LowestFloor == 4)
          checked { --index1; }
      }
      else if (surveyClass.Extensions[0].LowestFloor == 6 | surveyClass.Extensions[0].LowestFloor == 4)
        checked { --index1; }
      if (this.EXT.Exposed.Include_M)
        checked { ++index1; }
      int index2 = checked (index1 + 1);
      if (this.ChangeUFloor[1] | this.ChangeUFloor[0])
      {
        if (this.EXT.Ext1)
        {
          if (surveyClass.Extensions[1].LowestFloor == 5)
          {
            if (surveyClass.General.Country == 4)
            {
              string e1Age = this.EXT.Ages.E1Age;
              // ISSUE: reference to a compiler-generated method
              switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(e1Age))
              {
                case 3222007936:
                  if (Operators.CompareString(e1Age, "E", false) == 0)
                    break;
                  goto label_171;
                case 3238785555:
                  if (Operators.CompareString(e1Age, "D", false) == 0)
                    break;
                  goto label_171;
                case 3255563174:
                  if (Operators.CompareString(e1Age, "G", false) == 0)
                    break;
                  goto label_171;
                case 3272340793:
                  if (Operators.CompareString(e1Age, "F", false) == 0)
                    break;
                  goto label_171;
                case 3289118412:
                  if (Operators.CompareString(e1Age, "A", false) == 0)
                    break;
                  goto label_171;
                case 3322673650:
                  if (Operators.CompareString(e1Age, "C", false) == 0)
                    break;
                  goto label_171;
                case 3339451269:
                  if (Operators.CompareString(e1Age, "B", false) == 0)
                    break;
                  goto label_171;
                case 3423339364:
                  if (Operators.CompareString(e1Age, "I", false) == 0)
                  {
                    num1 = 0.05f;
                    goto label_171;
                  }
                  else
                    goto label_171;
                case 3440116983:
                  if (Operators.CompareString(e1Age, "H", false) == 0)
                  {
                    num1 = 0.025f;
                    goto label_171;
                  }
                  else
                    goto label_171;
                case 3456894602:
                  if (Operators.CompareString(e1Age, "K", false) == 0)
                  {
                    num1 = 0.1f;
                    goto label_171;
                  }
                  else
                    goto label_171;
                case 3473672221:
                  if (Operators.CompareString(e1Age, "J", false) == 0)
                  {
                    num1 = 0.0f;
                    goto label_171;
                  }
                  else
                    goto label_171;
                default:
                  goto label_171;
              }
              num1 = 0.0f;
            }
            else if (surveyClass.General.Country == 3)
            {
              string e1Age = this.EXT.Ages.E1Age;
              // ISSUE: reference to a compiler-generated method
              switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(e1Age))
              {
                case 3222007936:
                  if (Operators.CompareString(e1Age, "E", false) == 0)
                    break;
                  goto label_171;
                case 3238785555:
                  if (Operators.CompareString(e1Age, "D", false) == 0)
                    break;
                  goto label_171;
                case 3255563174:
                  if (Operators.CompareString(e1Age, "G", false) == 0)
                    break;
                  goto label_171;
                case 3272340793:
                  if (Operators.CompareString(e1Age, "F", false) == 0)
                    break;
                  goto label_171;
                case 3289118412:
                  if (Operators.CompareString(e1Age, "A", false) == 0)
                    break;
                  goto label_171;
                case 3322673650:
                  if (Operators.CompareString(e1Age, "C", false) == 0)
                    break;
                  goto label_171;
                case 3339451269:
                  if (Operators.CompareString(e1Age, "B", false) == 0)
                    break;
                  goto label_171;
                case 3423339364:
                  if (Operators.CompareString(e1Age, "I", false) == 0)
                  {
                    num1 = 0.05f;
                    goto label_171;
                  }
                  else
                    goto label_171;
                case 3440116983:
                  if (Operators.CompareString(e1Age, "H", false) == 0)
                  {
                    num1 = 0.025f;
                    goto label_171;
                  }
                  else
                    goto label_171;
                case 3456894602:
                  if (Operators.CompareString(e1Age, "K", false) == 0)
                  {
                    num1 = 0.1f;
                    goto label_171;
                  }
                  else
                    goto label_171;
                case 3473672221:
                  if (Operators.CompareString(e1Age, "J", false) == 0)
                  {
                    num1 = 0.075f;
                    goto label_171;
                  }
                  else
                    goto label_171;
                default:
                  goto label_171;
              }
              num1 = 0.0f;
            }
            else
            {
              string e1Age = this.EXT.Ages.E1Age;
              // ISSUE: reference to a compiler-generated method
              switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(e1Age))
              {
                case 3222007936:
                  if (Operators.CompareString(e1Age, "E", false) == 0)
                    break;
                  goto default;
                case 3238785555:
                  if (Operators.CompareString(e1Age, "D", false) == 0)
                    break;
                  goto default;
                case 3255563174:
                  if (Operators.CompareString(e1Age, "G", false) == 0)
                    break;
                  goto default;
                case 3272340793:
                  if (Operators.CompareString(e1Age, "F", false) == 0)
                    break;
                  goto default;
                case 3289118412:
                  if (Operators.CompareString(e1Age, "A", false) == 0)
                    break;
                  goto default;
                case 3322673650:
                  if (Operators.CompareString(e1Age, "C", false) == 0)
                    break;
                  goto default;
                case 3339451269:
                  if (Operators.CompareString(e1Age, "B", false) == 0)
                    break;
                  goto default;
                case 3423339364:
                  if (Operators.CompareString(e1Age, "I", false) == 0)
                  {
                    num1 = 0.025f;
                    goto default;
                  }
                  else
                    goto default;
                case 3440116983:
                  if (Operators.CompareString(e1Age, "H", false) == 0)
                    break;
                  goto default;
                case 3456894602:
                  if (Operators.CompareString(e1Age, "K", false) == 0)
                  {
                    num1 = 0.1f;
                    goto default;
                  }
                  else
                    goto default;
                case 3473672221:
                  if (Operators.CompareString(e1Age, "J", false) == 0)
                  {
                    num1 = 0.075f;
                    goto default;
                  }
                  else
                    goto default;
                default:
label_170:
                  goto label_171;
              }
              num1 = 0.0f;
              goto label_170;
            }
label_171:
            if (surveyClass.Extensions[1].FloorInsulation == 3 & (double) num1 < 0.05)
              num1 = 0.05f;
            float num11 = 2f * this.Dwelling.Dims[this.EXT.MStoreys].Area / this.Dwelling.Dims[this.EXT.MStoreys].Perimeter;
            if (this.EXT.WallThickness.E1 == 0.0)
              this.EXT.WallThickness.E1 = (double) this.GetWallThickNess(RdSAP, 1, false);
            if (surveyClass.Extensions[1].FloorConstruction == 1)
            {
              string e1Age = this.EXT.Ages.E1Age;
              if (Operators.CompareString(e1Age, "A", false) == 0 || Operators.CompareString(e1Age, "B", false) == 0)
              {
                float num12 = (float) (this.EXT.WallThickness.E1 + 0.315);
                float num13 = (float) (3.0 * Math.Log(Math.PI * (double) num11 / (double) num12 + 1.0) / (Math.PI * (double) num11 + (double) num12));
                float num14 = (float) (9.0 / 10.0 / (double) num11 + 87.0 / 80.0 / (double) num11);
                this.Dwelling.Floors[index2].U_Value = (float) Math.Round(1.0 / (0.54 + 1.0 / ((double) num13 + (double) num14)), 2);
              }
              else
              {
                float num15 = (float) (this.EXT.WallThickness.E1 + 1.5 * (0.17 + (double) num1 / 0.035 + 0.04));
                this.Dwelling.Floors[index2].U_Value = (double) num15 >= (double) num11 ? (float) Math.Round(1.5 / (0.457 * (double) num11 + (double) num15), 2) : (float) Math.Round(3.0 * Math.Log(Math.PI * (double) num11 / (double) num15 + 1.0) / (Math.PI * (double) num11 + (double) num15), 2);
              }
            }
            else if (surveyClass.Extensions[1].FloorConstruction == 3 | surveyClass.Extensions[1].FloorConstruction == 4)
            {
              float num16 = (float) (this.EXT.WallThickness.E1 + 0.315);
              float num17 = (float) (3.0 * Math.Log(Math.PI * (double) num11 / (double) num16 + 1.0) / (Math.PI * (double) num11 + (double) num16));
              float num18 = (float) (9.0 / 10.0 / (double) num11 + 87.0 / 80.0 / (double) num11);
              this.Dwelling.Floors[index2].U_Value = (float) Math.Round(1.0 / (0.34 + (double) num1 / 0.035 + 0.2 + 1.0 / ((double) num17 + (double) num18)), 2);
            }
            else if (surveyClass.Extensions[1].FloorConstruction == 2)
            {
              float num19 = (float) (this.EXT.WallThickness.E1 + 1.5 * (0.17 + (double) num1 / 0.035 + 0.04));
              this.Dwelling.Floors[index2].U_Value = (double) num19 >= (double) num11 ? (float) Math.Round(1.5 / (0.457 * (double) num11 + (double) num19), 2) : (float) Math.Round(3.0 * Math.Log(Math.PI * (double) num11 / (double) num19 + 1.0) / (Math.PI * (double) num11 + (double) num19), 2);
            }
            this.Dwelling.Floors[index2].Name = "Extention 1 Floor";
            this.Dwelling.Floors[index2].Type = "Ground floor";
            this.Dwelling.Floors[index2].Area = (float) Math.Round((double) this.Dwelling.Dims[this.EXT.MStoreys].Area, 2);
          }
          else if (surveyClass.Extensions[1].LowestFloor == 3)
          {
            this.Dwelling.Floors[index2].U_Value = 0.7f;
            this.Dwelling.Floors[index2].Name = "Extention 1 Floor";
            this.Dwelling.Floors[index2].Type = "Exposed floor";
            this.Dwelling.Floors[index2].Area = this.Dwelling.Dims[this.EXT.MStoreys].Area;
          }
          else if (surveyClass.Extensions[1].LowestFloor == 2 | surveyClass.Extensions[1].LowestFloor == 1)
          {
            if (surveyClass.Extensions[1].FloorInsulation == 1 | surveyClass.Extensions[1].FloorInsulation == 2)
            {
              string e1Age = this.EXT.Ages.E1Age;
              // ISSUE: reference to a compiler-generated method
              switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(e1Age))
              {
                case 3222007936:
                  if (Operators.CompareString(e1Age, "E", false) == 0)
                    break;
                  goto default;
                case 3238785555:
                  if (Operators.CompareString(e1Age, "D", false) == 0)
                    break;
                  goto default;
                case 3255563174:
                  if (Operators.CompareString(e1Age, "G", false) == 0)
                    break;
                  goto default;
                case 3272340793:
                  if (Operators.CompareString(e1Age, "F", false) == 0)
                    break;
                  goto default;
                case 3289118412:
                  if (Operators.CompareString(e1Age, "A", false) == 0)
                    break;
                  goto default;
                case 3322673650:
                  if (Operators.CompareString(e1Age, "C", false) == 0)
                    break;
                  goto default;
                case 3339451269:
                  if (Operators.CompareString(e1Age, "B", false) == 0)
                    break;
                  goto default;
                case 3423339364:
                  if (Operators.CompareString(e1Age, "I", false) == 0)
                    goto label_201;
                  else
                    goto default;
                case 3440116983:
                  if (Operators.CompareString(e1Age, "H", false) == 0)
                    goto label_201;
                  else
                    goto default;
                case 3456894602:
                  if (Operators.CompareString(e1Age, "K", false) == 0)
                  {
                    this.Dwelling.Floors[index2].U_Value = 0.22f;
                    goto default;
                  }
                  else
                    goto default;
                case 3473672221:
                  if (Operators.CompareString(e1Age, "J", false) == 0)
                  {
                    this.Dwelling.Floors[index2].U_Value = 0.25f;
                    goto default;
                  }
                  else
                    goto default;
                default:
label_204:
                  goto label_205;
              }
              this.Dwelling.Floors[index2].U_Value = 1.2f;
              goto label_204;
label_201:
              this.Dwelling.Floors[index2].U_Value = 0.51f;
              goto label_204;
            }
label_205:
            if (surveyClass.Extensions[1].FloorInsulation == 3)
            {
              string e1Age = this.EXT.Ages.E1Age;
              // ISSUE: reference to a compiler-generated method
              switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(e1Age))
              {
                case 3222007936:
                  if (Operators.CompareString(e1Age, "E", false) == 0)
                    break;
                  goto default;
                case 3238785555:
                  if (Operators.CompareString(e1Age, "D", false) == 0)
                    break;
                  goto default;
                case 3255563174:
                  if (Operators.CompareString(e1Age, "G", false) == 0)
                    break;
                  goto default;
                case 3272340793:
                  if (Operators.CompareString(e1Age, "F", false) == 0)
                    break;
                  goto default;
                case 3289118412:
                  if (Operators.CompareString(e1Age, "A", false) == 0)
                    break;
                  goto default;
                case 3322673650:
                  if (Operators.CompareString(e1Age, "C", false) == 0)
                    break;
                  goto default;
                case 3339451269:
                  if (Operators.CompareString(e1Age, "B", false) == 0)
                    break;
                  goto default;
                case 3423339364:
                  if (Operators.CompareString(e1Age, "I", false) == 0)
                    goto label_219;
                  else
                    goto default;
                case 3440116983:
                  if (Operators.CompareString(e1Age, "H", false) == 0)
                    goto label_219;
                  else
                    goto default;
                case 3456894602:
                  if (Operators.CompareString(e1Age, "K", false) == 0)
                  {
                    this.Dwelling.Floors[index2].U_Value = 0.22f;
                    goto default;
                  }
                  else
                    goto default;
                case 3473672221:
                  if (Operators.CompareString(e1Age, "J", false) == 0)
                  {
                    this.Dwelling.Floors[index2].U_Value = 0.25f;
                    goto default;
                  }
                  else
                    goto default;
                default:
label_222:
                  goto label_223;
              }
              this.Dwelling.Floors[index2].U_Value = 0.5f;
              goto label_222;
label_219:
              this.Dwelling.Floors[index2].U_Value = 0.5f;
              goto label_222;
            }
label_223:
            this.Dwelling.Floors[index2].Name = "Extention 1 Floor";
            this.Dwelling.Floors[index2].Type = "Exposed floor";
            this.Dwelling.Floors[index2].Area = (float) Math.Round((double) this.Dwelling.Dims[this.EXT.MStoreys].Area, 2);
          }
          else if (surveyClass.Extensions[1].LowestFloor == 6 | surveyClass.Extensions[1].LowestFloor == 4)
            checked { --index2; }
        }
      }
      else if (surveyClass.Extensions[1].LowestFloor == 6 | surveyClass.Extensions[1].LowestFloor == 4)
        checked { --index2; }
      if (this.EXT.Exposed.Include_E1)
        checked { ++index2; }
      int index3 = checked (index2 + 1);
      if (this.ChangeUFloor[2] | this.ChangeUFloor[0])
      {
        if (this.EXT.Ext2)
        {
          if (surveyClass.Extensions[2].LowestFloor == 5)
          {
            if (surveyClass.General.Country == 4)
            {
              string e2Age = this.EXT.Ages.E2Age;
              // ISSUE: reference to a compiler-generated method
              switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(e2Age))
              {
                case 3222007936:
                  if (Operators.CompareString(e2Age, "E", false) == 0)
                    break;
                  goto label_288;
                case 3238785555:
                  if (Operators.CompareString(e2Age, "D", false) == 0)
                    break;
                  goto label_288;
                case 3255563174:
                  if (Operators.CompareString(e2Age, "G", false) == 0)
                    break;
                  goto label_288;
                case 3272340793:
                  if (Operators.CompareString(e2Age, "F", false) == 0)
                    break;
                  goto label_288;
                case 3289118412:
                  if (Operators.CompareString(e2Age, "A", false) == 0)
                    break;
                  goto label_288;
                case 3322673650:
                  if (Operators.CompareString(e2Age, "C", false) == 0)
                    break;
                  goto label_288;
                case 3339451269:
                  if (Operators.CompareString(e2Age, "B", false) == 0)
                    break;
                  goto label_288;
                case 3423339364:
                  if (Operators.CompareString(e2Age, "I", false) == 0)
                  {
                    num1 = 0.05f;
                    goto label_288;
                  }
                  else
                    goto label_288;
                case 3440116983:
                  if (Operators.CompareString(e2Age, "H", false) == 0)
                  {
                    num1 = 0.025f;
                    goto label_288;
                  }
                  else
                    goto label_288;
                case 3456894602:
                  if (Operators.CompareString(e2Age, "K", false) == 0)
                  {
                    num1 = 0.1f;
                    goto label_288;
                  }
                  else
                    goto label_288;
                case 3473672221:
                  if (Operators.CompareString(e2Age, "J", false) == 0)
                  {
                    num1 = 0.0f;
                    goto label_288;
                  }
                  else
                    goto label_288;
                default:
                  goto label_288;
              }
              num1 = 0.0f;
            }
            else if (surveyClass.General.Country == 3)
            {
              string e2Age = this.EXT.Ages.E2Age;
              // ISSUE: reference to a compiler-generated method
              switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(e2Age))
              {
                case 3222007936:
                  if (Operators.CompareString(e2Age, "E", false) == 0)
                    break;
                  goto label_288;
                case 3238785555:
                  if (Operators.CompareString(e2Age, "D", false) == 0)
                    break;
                  goto label_288;
                case 3255563174:
                  if (Operators.CompareString(e2Age, "G", false) == 0)
                    break;
                  goto label_288;
                case 3272340793:
                  if (Operators.CompareString(e2Age, "F", false) == 0)
                    break;
                  goto label_288;
                case 3289118412:
                  if (Operators.CompareString(e2Age, "A", false) == 0)
                    break;
                  goto label_288;
                case 3322673650:
                  if (Operators.CompareString(e2Age, "C", false) == 0)
                    break;
                  goto label_288;
                case 3339451269:
                  if (Operators.CompareString(e2Age, "B", false) == 0)
                    break;
                  goto label_288;
                case 3423339364:
                  if (Operators.CompareString(e2Age, "I", false) == 0)
                  {
                    num1 = 0.05f;
                    goto label_288;
                  }
                  else
                    goto label_288;
                case 3440116983:
                  if (Operators.CompareString(e2Age, "H", false) == 0)
                  {
                    num1 = 0.025f;
                    goto label_288;
                  }
                  else
                    goto label_288;
                case 3456894602:
                  if (Operators.CompareString(e2Age, "K", false) == 0)
                  {
                    num1 = 0.1f;
                    goto label_288;
                  }
                  else
                    goto label_288;
                case 3473672221:
                  if (Operators.CompareString(e2Age, "J", false) == 0)
                  {
                    num1 = 0.075f;
                    goto label_288;
                  }
                  else
                    goto label_288;
                default:
                  goto label_288;
              }
              num1 = 0.0f;
            }
            else
            {
              string e2Age = this.EXT.Ages.E2Age;
              // ISSUE: reference to a compiler-generated method
              switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(e2Age))
              {
                case 3222007936:
                  if (Operators.CompareString(e2Age, "E", false) == 0)
                    break;
                  goto default;
                case 3238785555:
                  if (Operators.CompareString(e2Age, "D", false) == 0)
                    break;
                  goto default;
                case 3255563174:
                  if (Operators.CompareString(e2Age, "G", false) == 0)
                    break;
                  goto default;
                case 3272340793:
                  if (Operators.CompareString(e2Age, "F", false) == 0)
                    break;
                  goto default;
                case 3289118412:
                  if (Operators.CompareString(e2Age, "A", false) == 0)
                    break;
                  goto default;
                case 3322673650:
                  if (Operators.CompareString(e2Age, "C", false) == 0)
                    break;
                  goto default;
                case 3339451269:
                  if (Operators.CompareString(e2Age, "B", false) == 0)
                    break;
                  goto default;
                case 3423339364:
                  if (Operators.CompareString(e2Age, "I", false) == 0)
                  {
                    num1 = 0.025f;
                    goto default;
                  }
                  else
                    goto default;
                case 3440116983:
                  if (Operators.CompareString(e2Age, "H", false) == 0)
                    break;
                  goto default;
                case 3456894602:
                  if (Operators.CompareString(e2Age, "K", false) == 0)
                  {
                    num1 = 0.1f;
                    goto default;
                  }
                  else
                    goto default;
                case 3473672221:
                  if (Operators.CompareString(e2Age, "J", false) == 0)
                  {
                    num1 = 0.075f;
                    goto default;
                  }
                  else
                    goto default;
                default:
label_287:
                  goto label_288;
              }
              num1 = 0.0f;
              goto label_287;
            }
label_288:
            if (surveyClass.Extensions[2].FloorInsulation == 3 & (double) num1 < 0.05)
              num1 = 0.05f;
            float num20 = 2f * this.Dwelling.Dims[checked (this.EXT.MStoreys + this.EXT.E1Storeys)].Area / this.Dwelling.Dims[checked (this.EXT.MStoreys + this.EXT.E1Storeys)].Perimeter;
            if (this.EXT.WallThickness.E2 == 0.0)
              this.EXT.WallThickness.E2 = (double) this.GetWallThickNess(RdSAP, 2, false);
            if (surveyClass.Extensions[2].FloorConstruction == 1)
            {
              string e2Age = this.EXT.Ages.E2Age;
              if (Operators.CompareString(e2Age, "A", false) == 0 || Operators.CompareString(e2Age, "B", false) == 0)
              {
                float num21 = (float) (this.EXT.WallThickness.E2 + 0.315);
                float num22 = (float) (3.0 * Math.Log(Math.PI * (double) num20 / (double) num21 + 1.0) / (Math.PI * (double) num20 + (double) num21));
                float num23 = (float) (9.0 / 10.0 / (double) num20 + 87.0 / 80.0 / (double) num20);
                this.Dwelling.Floors[index3].U_Value = (float) Math.Round(1.0 / (0.54 + 1.0 / ((double) num22 + (double) num23)), 2);
              }
              else
              {
                float num24 = (float) (this.EXT.WallThickness.E2 + 1.5 * (0.17 + (double) num1 / 0.035 + 0.04));
                this.Dwelling.Floors[index3].U_Value = (double) num24 >= (double) num20 ? (float) Math.Round(1.5 / (0.457 * (double) num20 + (double) num24), 2) : (float) Math.Round(3.0 * Math.Log(Math.PI * (double) num20 / (double) num24 + 1.0) / (Math.PI * (double) num20 + (double) num24), 2);
              }
            }
            else if (surveyClass.Extensions[2].FloorConstruction == 3 | surveyClass.Extensions[2].FloorConstruction == 4)
            {
              float num25 = (float) (this.EXT.WallThickness.E2 + 0.315);
              float num26 = (float) (3.0 * Math.Log(Math.PI * (double) num20 / (double) num25 + 1.0) / (Math.PI * (double) num20 + (double) num25));
              float num27 = (float) (9.0 / 10.0 / (double) num20 + 87.0 / 80.0 / (double) num20);
              this.Dwelling.Floors[index3].U_Value = (float) Math.Round(1.0 / (0.34 + (double) num1 / 0.035 + 0.2 + 1.0 / ((double) num26 + (double) num27)), 2);
            }
            else if (surveyClass.Extensions[2].FloorConstruction == 2)
            {
              float num28 = (float) (this.EXT.WallThickness.E2 + 1.5 * (0.17 + (double) num1 / 0.035 + 0.04));
              this.Dwelling.Floors[index3].U_Value = (double) num28 >= (double) num20 ? (float) Math.Round(1.5 / (0.457 * (double) num20 + (double) num28), 2) : (float) Math.Round(3.0 * Math.Log(Math.PI * (double) num20 / (double) num28 + 1.0) / (Math.PI * (double) num20 + (double) num28), 2);
            }
            this.Dwelling.Floors[index3].Name = "Extention 2 Floor";
            this.Dwelling.Floors[index3].Type = "Ground floor";
            this.Dwelling.Floors[index3].Area = (float) Math.Round((double) this.Dwelling.Dims[checked (this.EXT.MStoreys + this.EXT.E1Storeys)].Area, 2);
          }
          else if (surveyClass.Extensions[2].LowestFloor == 3)
          {
            this.Dwelling.Floors[index3].U_Value = 0.7f;
            this.Dwelling.Floors[index3].Name = "Extention 2 Floor";
            this.Dwelling.Floors[index3].Type = "Exposed floor";
            this.Dwelling.Floors[index3].Area = (float) Math.Round((double) this.Dwelling.Dims[checked (this.EXT.MStoreys + this.EXT.E1Storeys)].Area, 2);
          }
          else if (surveyClass.Extensions[2].LowestFloor == 2 | surveyClass.Extensions[2].LowestFloor == 1)
          {
            if (surveyClass.Extensions[2].FloorInsulation == 1 | surveyClass.Extensions[2].FloorInsulation == 2)
            {
              string e2Age = this.EXT.Ages.E2Age;
              // ISSUE: reference to a compiler-generated method
              switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(e2Age))
              {
                case 3222007936:
                  if (Operators.CompareString(e2Age, "E", false) == 0)
                    break;
                  goto default;
                case 3238785555:
                  if (Operators.CompareString(e2Age, "D", false) == 0)
                    break;
                  goto default;
                case 3255563174:
                  if (Operators.CompareString(e2Age, "G", false) == 0)
                    break;
                  goto default;
                case 3272340793:
                  if (Operators.CompareString(e2Age, "F", false) == 0)
                    break;
                  goto default;
                case 3289118412:
                  if (Operators.CompareString(e2Age, "A", false) == 0)
                    break;
                  goto default;
                case 3322673650:
                  if (Operators.CompareString(e2Age, "C", false) == 0)
                    break;
                  goto default;
                case 3339451269:
                  if (Operators.CompareString(e2Age, "B", false) == 0)
                    break;
                  goto default;
                case 3423339364:
                  if (Operators.CompareString(e2Age, "I", false) == 0)
                    goto label_318;
                  else
                    goto default;
                case 3440116983:
                  if (Operators.CompareString(e2Age, "H", false) == 0)
                    goto label_318;
                  else
                    goto default;
                case 3456894602:
                  if (Operators.CompareString(e2Age, "K", false) == 0)
                  {
                    this.Dwelling.Floors[index3].U_Value = 0.22f;
                    goto default;
                  }
                  else
                    goto default;
                case 3473672221:
                  if (Operators.CompareString(e2Age, "J", false) == 0)
                  {
                    this.Dwelling.Floors[index3].U_Value = 0.25f;
                    goto default;
                  }
                  else
                    goto default;
                default:
label_321:
                  goto label_322;
              }
              this.Dwelling.Floors[index3].U_Value = 1.2f;
              goto label_321;
label_318:
              this.Dwelling.Floors[index3].U_Value = 0.51f;
              goto label_321;
            }
label_322:
            if (surveyClass.Extensions[2].FloorInsulation == 3)
            {
              string e2Age = this.EXT.Ages.E2Age;
              // ISSUE: reference to a compiler-generated method
              switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(e2Age))
              {
                case 3222007936:
                  if (Operators.CompareString(e2Age, "E", false) == 0)
                    break;
                  goto default;
                case 3238785555:
                  if (Operators.CompareString(e2Age, "D", false) == 0)
                    break;
                  goto default;
                case 3255563174:
                  if (Operators.CompareString(e2Age, "G", false) == 0)
                    break;
                  goto default;
                case 3272340793:
                  if (Operators.CompareString(e2Age, "F", false) == 0)
                    break;
                  goto default;
                case 3289118412:
                  if (Operators.CompareString(e2Age, "A", false) == 0)
                    break;
                  goto default;
                case 3322673650:
                  if (Operators.CompareString(e2Age, "C", false) == 0)
                    break;
                  goto default;
                case 3339451269:
                  if (Operators.CompareString(e2Age, "B", false) == 0)
                    break;
                  goto default;
                case 3423339364:
                  if (Operators.CompareString(e2Age, "I", false) == 0)
                    goto label_336;
                  else
                    goto default;
                case 3440116983:
                  if (Operators.CompareString(e2Age, "H", false) == 0)
                    goto label_336;
                  else
                    goto default;
                case 3456894602:
                  if (Operators.CompareString(e2Age, "K", false) == 0)
                  {
                    this.Dwelling.Floors[index3].U_Value = 0.22f;
                    goto default;
                  }
                  else
                    goto default;
                case 3473672221:
                  if (Operators.CompareString(e2Age, "J", false) == 0)
                  {
                    this.Dwelling.Floors[index3].U_Value = 0.25f;
                    goto default;
                  }
                  else
                    goto default;
                default:
label_339:
                  goto label_340;
              }
              this.Dwelling.Floors[index3].U_Value = 0.5f;
              goto label_339;
label_336:
              this.Dwelling.Floors[index3].U_Value = 0.5f;
              goto label_339;
            }
label_340:
            this.Dwelling.Floors[index3].Name = "Extention 2 Floor";
            this.Dwelling.Floors[index3].Type = "Exposed floor";
            this.Dwelling.Floors[index3].Area = (float) Math.Round((double) this.Dwelling.Dims[checked (this.EXT.MStoreys + this.EXT.E1Storeys)].Area, 2);
          }
          else if (surveyClass.Extensions[2].LowestFloor == 6 | surveyClass.Extensions[2].LowestFloor == 4)
            checked { --index3; }
        }
      }
      else if (surveyClass.Extensions[2].LowestFloor == 6 | surveyClass.Extensions[2].LowestFloor == 4)
        checked { --index3; }
      if (this.EXT.Exposed.Include_E2)
        checked { ++index3; }
      int index4 = checked (index3 + 1);
      if (this.ChangeUFloor[3] | this.ChangeUFloor[0])
      {
        if (this.EXT.Ext3)
        {
          if (surveyClass.Extensions[3].LowestFloor == 5)
          {
            if (surveyClass.General.Country == 4)
            {
              string e3Age = this.EXT.Ages.E3Age;
              // ISSUE: reference to a compiler-generated method
              switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(e3Age))
              {
                case 3222007936:
                  if (Operators.CompareString(e3Age, "E", false) == 0)
                    break;
                  goto label_405;
                case 3238785555:
                  if (Operators.CompareString(e3Age, "D", false) == 0)
                    break;
                  goto label_405;
                case 3255563174:
                  if (Operators.CompareString(e3Age, "G", false) == 0)
                    break;
                  goto label_405;
                case 3272340793:
                  if (Operators.CompareString(e3Age, "F", false) == 0)
                    break;
                  goto label_405;
                case 3289118412:
                  if (Operators.CompareString(e3Age, "A", false) == 0)
                    break;
                  goto label_405;
                case 3322673650:
                  if (Operators.CompareString(e3Age, "C", false) == 0)
                    break;
                  goto label_405;
                case 3339451269:
                  if (Operators.CompareString(e3Age, "B", false) == 0)
                    break;
                  goto label_405;
                case 3423339364:
                  if (Operators.CompareString(e3Age, "I", false) == 0)
                  {
                    num1 = 0.05f;
                    goto label_405;
                  }
                  else
                    goto label_405;
                case 3440116983:
                  if (Operators.CompareString(e3Age, "H", false) == 0)
                  {
                    num1 = 0.025f;
                    goto label_405;
                  }
                  else
                    goto label_405;
                case 3456894602:
                  if (Operators.CompareString(e3Age, "K", false) == 0)
                  {
                    num1 = 0.1f;
                    goto label_405;
                  }
                  else
                    goto label_405;
                case 3473672221:
                  if (Operators.CompareString(e3Age, "J", false) == 0)
                  {
                    num1 = 0.0f;
                    goto label_405;
                  }
                  else
                    goto label_405;
                default:
                  goto label_405;
              }
              num1 = 0.0f;
            }
            else if (surveyClass.General.Country == 3)
            {
              string e3Age = this.EXT.Ages.E3Age;
              // ISSUE: reference to a compiler-generated method
              switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(e3Age))
              {
                case 3222007936:
                  if (Operators.CompareString(e3Age, "E", false) == 0)
                    break;
                  goto label_405;
                case 3238785555:
                  if (Operators.CompareString(e3Age, "D", false) == 0)
                    break;
                  goto label_405;
                case 3255563174:
                  if (Operators.CompareString(e3Age, "G", false) == 0)
                    break;
                  goto label_405;
                case 3272340793:
                  if (Operators.CompareString(e3Age, "F", false) == 0)
                    break;
                  goto label_405;
                case 3289118412:
                  if (Operators.CompareString(e3Age, "A", false) == 0)
                    break;
                  goto label_405;
                case 3322673650:
                  if (Operators.CompareString(e3Age, "C", false) == 0)
                    break;
                  goto label_405;
                case 3339451269:
                  if (Operators.CompareString(e3Age, "B", false) == 0)
                    break;
                  goto label_405;
                case 3423339364:
                  if (Operators.CompareString(e3Age, "I", false) == 0)
                  {
                    num1 = 0.05f;
                    goto label_405;
                  }
                  else
                    goto label_405;
                case 3440116983:
                  if (Operators.CompareString(e3Age, "H", false) == 0)
                  {
                    num1 = 0.025f;
                    goto label_405;
                  }
                  else
                    goto label_405;
                case 3456894602:
                  if (Operators.CompareString(e3Age, "K", false) == 0)
                  {
                    num1 = 0.1f;
                    goto label_405;
                  }
                  else
                    goto label_405;
                case 3473672221:
                  if (Operators.CompareString(e3Age, "J", false) == 0)
                  {
                    num1 = 0.075f;
                    goto label_405;
                  }
                  else
                    goto label_405;
                default:
                  goto label_405;
              }
              num1 = 0.0f;
            }
            else
            {
              string e3Age = this.EXT.Ages.E3Age;
              // ISSUE: reference to a compiler-generated method
              switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(e3Age))
              {
                case 3222007936:
                  if (Operators.CompareString(e3Age, "E", false) == 0)
                    break;
                  goto default;
                case 3238785555:
                  if (Operators.CompareString(e3Age, "D", false) == 0)
                    break;
                  goto default;
                case 3255563174:
                  if (Operators.CompareString(e3Age, "G", false) == 0)
                    break;
                  goto default;
                case 3272340793:
                  if (Operators.CompareString(e3Age, "F", false) == 0)
                    break;
                  goto default;
                case 3289118412:
                  if (Operators.CompareString(e3Age, "A", false) == 0)
                    break;
                  goto default;
                case 3322673650:
                  if (Operators.CompareString(e3Age, "C", false) == 0)
                    break;
                  goto default;
                case 3339451269:
                  if (Operators.CompareString(e3Age, "B", false) == 0)
                    break;
                  goto default;
                case 3423339364:
                  if (Operators.CompareString(e3Age, "I", false) == 0)
                  {
                    num1 = 0.025f;
                    goto default;
                  }
                  else
                    goto default;
                case 3440116983:
                  if (Operators.CompareString(e3Age, "H", false) == 0)
                    break;
                  goto default;
                case 3456894602:
                  if (Operators.CompareString(e3Age, "K", false) == 0)
                  {
                    num1 = 0.1f;
                    goto default;
                  }
                  else
                    goto default;
                case 3473672221:
                  if (Operators.CompareString(e3Age, "J", false) == 0)
                  {
                    num1 = 0.075f;
                    goto default;
                  }
                  else
                    goto default;
                default:
label_404:
                  goto label_405;
              }
              num1 = 0.0f;
              goto label_404;
            }
label_405:
            if (surveyClass.Extensions[3].FloorInsulation == 3 & (double) num1 < 0.05)
              num1 = 0.05f;
            float num29 = 2f * this.Dwelling.Dims[checked (this.EXT.MStoreys + this.EXT.E1Storeys + this.EXT.E2Storeys)].Area / this.Dwelling.Dims[checked (this.EXT.MStoreys + this.EXT.E1Storeys + this.EXT.E2Storeys)].Perimeter;
            if (this.EXT.WallThickness.E3 == 0.0)
              this.EXT.WallThickness.E3 = (double) this.GetWallThickNess(RdSAP, 3, false);
            if (surveyClass.Extensions[3].FloorConstruction == 1)
            {
              string e3Age = this.EXT.Ages.E3Age;
              if (Operators.CompareString(e3Age, "A", false) == 0 || Operators.CompareString(e3Age, "B", false) == 0)
              {
                float num30 = (float) (this.EXT.WallThickness.E3 + 0.315);
                float num31 = (float) (3.0 * Math.Log(Math.PI * (double) num29 / (double) num30 + 1.0) / (Math.PI * (double) num29 + (double) num30));
                float num32 = (float) (9.0 / 10.0 / (double) num29 + 87.0 / 80.0 / (double) num29);
                this.Dwelling.Floors[index4].U_Value = (float) Math.Round(1.0 / (0.54 + 1.0 / ((double) num31 + (double) num32)), 2);
              }
              else
              {
                float num33 = (float) (this.EXT.WallThickness.E3 + 1.5 * (0.17 + (double) num1 / 0.035 + 0.04));
                this.Dwelling.Floors[index4].U_Value = (double) num33 >= (double) num29 ? (float) Math.Round(1.5 / (0.457 * (double) num29 + (double) num33), 2) : (float) Math.Round(3.0 * Math.Log(Math.PI * (double) num29 / (double) num33 + 1.0) / (Math.PI * (double) num29 + (double) num33), 2);
              }
            }
            else if (surveyClass.Extensions[3].FloorConstruction == 3 | surveyClass.Extensions[3].FloorConstruction == 4)
            {
              float num34 = (float) (this.EXT.WallThickness.E3 + 0.315);
              float num35 = (float) (3.0 * Math.Log(Math.PI * (double) num29 / (double) num34 + 1.0) / (Math.PI * (double) num29 + (double) num34));
              float num36 = (float) (9.0 / 10.0 / (double) num29 + 87.0 / 80.0 / (double) num29);
              this.Dwelling.Floors[index4].U_Value = (float) Math.Round(1.0 / (0.34 + (double) num1 / 0.035 + 0.2 + 1.0 / ((double) num35 + (double) num36)), 2);
            }
            else if (surveyClass.Extensions[3].FloorConstruction == 2)
            {
              float num37 = (float) (this.EXT.WallThickness.E3 + 1.5 * (0.17 + (double) num1 / 0.035 + 0.04));
              this.Dwelling.Floors[index4].U_Value = (double) num37 >= (double) num29 ? (float) Math.Round(1.5 / (0.457 * (double) num29 + (double) num37), 2) : (float) Math.Round(3.0 * Math.Log(Math.PI * (double) num29 / (double) num37 + 1.0) / (Math.PI * (double) num29 + (double) num37), 2);
            }
            this.Dwelling.Floors[index4].Name = "Extention 3 Floor";
            this.Dwelling.Floors[index4].Type = "Ground floor";
            this.Dwelling.Floors[index4].Area = (float) Math.Round((double) this.Dwelling.Dims[checked (this.EXT.MStoreys + this.EXT.E1Storeys + this.EXT.E2Storeys)].Area, 2);
          }
          else if (surveyClass.Extensions[3].LowestFloor == 3)
          {
            this.Dwelling.Floors[index4].U_Value = 0.7f;
            this.Dwelling.Floors[index4].Name = "Extention 3 Floor";
            this.Dwelling.Floors[index4].Type = "Exposed floor";
            this.Dwelling.Floors[index4].Area = (float) Math.Round((double) this.Dwelling.Dims[checked (this.EXT.MStoreys + this.EXT.E1Storeys + this.EXT.E2Storeys)].Area, 2);
          }
          else if (surveyClass.Extensions[3].LowestFloor == 2 | surveyClass.Extensions[3].LowestFloor == 1)
          {
            if (surveyClass.Extensions[3].FloorInsulation == 1 | surveyClass.Extensions[3].FloorInsulation == 2)
            {
              string e3Age = this.EXT.Ages.E3Age;
              // ISSUE: reference to a compiler-generated method
              switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(e3Age))
              {
                case 3222007936:
                  if (Operators.CompareString(e3Age, "E", false) == 0)
                    break;
                  goto default;
                case 3238785555:
                  if (Operators.CompareString(e3Age, "D", false) == 0)
                    break;
                  goto default;
                case 3255563174:
                  if (Operators.CompareString(e3Age, "G", false) == 0)
                    break;
                  goto default;
                case 3272340793:
                  if (Operators.CompareString(e3Age, "F", false) == 0)
                    break;
                  goto default;
                case 3289118412:
                  if (Operators.CompareString(e3Age, "A", false) == 0)
                    break;
                  goto default;
                case 3322673650:
                  if (Operators.CompareString(e3Age, "C", false) == 0)
                    break;
                  goto default;
                case 3339451269:
                  if (Operators.CompareString(e3Age, "B", false) == 0)
                    break;
                  goto default;
                case 3423339364:
                  if (Operators.CompareString(e3Age, "I", false) == 0)
                    goto label_435;
                  else
                    goto default;
                case 3440116983:
                  if (Operators.CompareString(e3Age, "H", false) == 0)
                    goto label_435;
                  else
                    goto default;
                case 3456894602:
                  if (Operators.CompareString(e3Age, "K", false) == 0)
                  {
                    this.Dwelling.Floors[index4].U_Value = 0.22f;
                    goto default;
                  }
                  else
                    goto default;
                case 3473672221:
                  if (Operators.CompareString(e3Age, "J", false) == 0)
                  {
                    this.Dwelling.Floors[index4].U_Value = 0.25f;
                    goto default;
                  }
                  else
                    goto default;
                default:
label_438:
                  goto label_439;
              }
              this.Dwelling.Floors[index4].U_Value = 1.2f;
              goto label_438;
label_435:
              this.Dwelling.Floors[index4].U_Value = 0.51f;
              goto label_438;
            }
label_439:
            if (surveyClass.Extensions[3].FloorInsulation == 3)
            {
              string e3Age = this.EXT.Ages.E3Age;
              // ISSUE: reference to a compiler-generated method
              switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(e3Age))
              {
                case 3222007936:
                  if (Operators.CompareString(e3Age, "E", false) == 0)
                    break;
                  goto default;
                case 3238785555:
                  if (Operators.CompareString(e3Age, "D", false) == 0)
                    break;
                  goto default;
                case 3255563174:
                  if (Operators.CompareString(e3Age, "G", false) == 0)
                    break;
                  goto default;
                case 3272340793:
                  if (Operators.CompareString(e3Age, "F", false) == 0)
                    break;
                  goto default;
                case 3289118412:
                  if (Operators.CompareString(e3Age, "A", false) == 0)
                    break;
                  goto default;
                case 3322673650:
                  if (Operators.CompareString(e3Age, "C", false) == 0)
                    break;
                  goto default;
                case 3339451269:
                  if (Operators.CompareString(e3Age, "B", false) == 0)
                    break;
                  goto default;
                case 3423339364:
                  if (Operators.CompareString(e3Age, "I", false) == 0)
                    goto label_453;
                  else
                    goto default;
                case 3440116983:
                  if (Operators.CompareString(e3Age, "H", false) == 0)
                    goto label_453;
                  else
                    goto default;
                case 3456894602:
                  if (Operators.CompareString(e3Age, "K", false) == 0)
                  {
                    this.Dwelling.Floors[index4].U_Value = 0.22f;
                    goto default;
                  }
                  else
                    goto default;
                case 3473672221:
                  if (Operators.CompareString(e3Age, "J", false) == 0)
                  {
                    this.Dwelling.Floors[index4].U_Value = 0.25f;
                    goto default;
                  }
                  else
                    goto default;
                default:
label_456:
                  goto label_457;
              }
              this.Dwelling.Floors[index4].U_Value = 0.5f;
              goto label_456;
label_453:
              this.Dwelling.Floors[index4].U_Value = 0.5f;
              goto label_456;
            }
label_457:
            this.Dwelling.Floors[index4].Name = "Extention 3 Floor";
            this.Dwelling.Floors[index4].Type = "Exposed floor";
            this.Dwelling.Floors[index4].Area = (float) Math.Round((double) this.Dwelling.Dims[checked (this.EXT.MStoreys + this.EXT.E1Storeys + this.EXT.E2Storeys)].Area, 2);
          }
          else if (surveyClass.Extensions[3].LowestFloor == 6 | surveyClass.Extensions[3].LowestFloor == 4)
            checked { --index4; }
        }
      }
      else if (surveyClass.Extensions[3].LowestFloor == 6 | surveyClass.Extensions[3].LowestFloor == 4)
        checked { --index4; }
      if (this.EXT.Exposed.Include_E3)
        checked { ++index4; }
      int index5 = checked (index4 + 1);
      if (this.ChangeUFloor[4] | this.ChangeUFloor[0] && this.EXT.Ext4)
      {
        if (surveyClass.Extensions[4].LowestFloor == 5)
        {
          if (surveyClass.General.Country == 4)
          {
            string e4Age = this.EXT.Ages.E4Age;
            // ISSUE: reference to a compiler-generated method
            switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(e4Age))
            {
              case 3222007936:
                if (Operators.CompareString(e4Age, "E", false) == 0)
                  break;
                goto label_521;
              case 3238785555:
                if (Operators.CompareString(e4Age, "D", false) == 0)
                  break;
                goto label_521;
              case 3255563174:
                if (Operators.CompareString(e4Age, "G", false) == 0)
                  break;
                goto label_521;
              case 3272340793:
                if (Operators.CompareString(e4Age, "F", false) == 0)
                  break;
                goto label_521;
              case 3289118412:
                if (Operators.CompareString(e4Age, "A", false) == 0)
                  break;
                goto label_521;
              case 3322673650:
                if (Operators.CompareString(e4Age, "C", false) == 0)
                  break;
                goto label_521;
              case 3339451269:
                if (Operators.CompareString(e4Age, "B", false) == 0)
                  break;
                goto label_521;
              case 3423339364:
                if (Operators.CompareString(e4Age, "I", false) == 0)
                {
                  num1 = 0.05f;
                  goto label_521;
                }
                else
                  goto label_521;
              case 3440116983:
                if (Operators.CompareString(e4Age, "H", false) == 0)
                {
                  num1 = 0.025f;
                  goto label_521;
                }
                else
                  goto label_521;
              case 3456894602:
                if (Operators.CompareString(e4Age, "K", false) == 0)
                {
                  num1 = 0.1f;
                  goto label_521;
                }
                else
                  goto label_521;
              case 3473672221:
                if (Operators.CompareString(e4Age, "J", false) == 0)
                {
                  num1 = 0.0f;
                  goto label_521;
                }
                else
                  goto label_521;
              default:
                goto label_521;
            }
            num1 = 0.0f;
          }
          else if (surveyClass.General.Country == 3)
          {
            string e4Age = this.EXT.Ages.E4Age;
            // ISSUE: reference to a compiler-generated method
            switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(e4Age))
            {
              case 3222007936:
                if (Operators.CompareString(e4Age, "E", false) == 0)
                  break;
                goto label_521;
              case 3238785555:
                if (Operators.CompareString(e4Age, "D", false) == 0)
                  break;
                goto label_521;
              case 3255563174:
                if (Operators.CompareString(e4Age, "G", false) == 0)
                  break;
                goto label_521;
              case 3272340793:
                if (Operators.CompareString(e4Age, "F", false) == 0)
                  break;
                goto label_521;
              case 3289118412:
                if (Operators.CompareString(e4Age, "A", false) == 0)
                  break;
                goto label_521;
              case 3322673650:
                if (Operators.CompareString(e4Age, "C", false) == 0)
                  break;
                goto label_521;
              case 3339451269:
                if (Operators.CompareString(e4Age, "B", false) == 0)
                  break;
                goto label_521;
              case 3423339364:
                if (Operators.CompareString(e4Age, "I", false) == 0)
                {
                  num1 = 0.05f;
                  goto label_521;
                }
                else
                  goto label_521;
              case 3440116983:
                if (Operators.CompareString(e4Age, "H", false) == 0)
                {
                  num1 = 0.025f;
                  goto label_521;
                }
                else
                  goto label_521;
              case 3456894602:
                if (Operators.CompareString(e4Age, "K", false) == 0)
                {
                  num1 = 0.1f;
                  goto label_521;
                }
                else
                  goto label_521;
              case 3473672221:
                if (Operators.CompareString(e4Age, "J", false) == 0)
                {
                  num1 = 0.075f;
                  goto label_521;
                }
                else
                  goto label_521;
              default:
                goto label_521;
            }
            num1 = 0.0f;
          }
          else
          {
            string e4Age = this.EXT.Ages.E4Age;
            // ISSUE: reference to a compiler-generated method
            switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(e4Age))
            {
              case 3222007936:
                if (Operators.CompareString(e4Age, "E", false) == 0)
                  break;
                goto default;
              case 3238785555:
                if (Operators.CompareString(e4Age, "D", false) == 0)
                  break;
                goto default;
              case 3255563174:
                if (Operators.CompareString(e4Age, "G", false) == 0)
                  break;
                goto default;
              case 3272340793:
                if (Operators.CompareString(e4Age, "F", false) == 0)
                  break;
                goto default;
              case 3289118412:
                if (Operators.CompareString(e4Age, "A", false) == 0)
                  break;
                goto default;
              case 3322673650:
                if (Operators.CompareString(e4Age, "C", false) == 0)
                  break;
                goto default;
              case 3339451269:
                if (Operators.CompareString(e4Age, "B", false) == 0)
                  break;
                goto default;
              case 3423339364:
                if (Operators.CompareString(e4Age, "I", false) == 0)
                {
                  num1 = 0.025f;
                  goto default;
                }
                else
                  goto default;
              case 3440116983:
                if (Operators.CompareString(e4Age, "H", false) == 0)
                  break;
                goto default;
              case 3456894602:
                if (Operators.CompareString(e4Age, "K", false) == 0)
                {
                  num1 = 0.1f;
                  goto default;
                }
                else
                  goto default;
              case 3473672221:
                if (Operators.CompareString(e4Age, "J", false) == 0)
                {
                  num1 = 0.075f;
                  goto default;
                }
                else
                  goto default;
              default:
label_520:
                goto label_521;
            }
            num1 = 0.0f;
            goto label_520;
          }
label_521:
          if (surveyClass.Extensions[4].FloorInsulation == 3 & (double) num1 < 0.05)
            num1 = 0.05f;
          float num38 = 2f * this.Dwelling.Dims[checked (this.EXT.MStoreys + this.EXT.E1Storeys + this.EXT.E2Storeys + this.EXT.E3Storeys)].Area / this.Dwelling.Dims[checked (this.EXT.MStoreys + this.EXT.E1Storeys + this.EXT.E2Storeys + this.EXT.E3Storeys)].Perimeter;
          if (this.EXT.WallThickness.E4 == 0.0)
            this.EXT.WallThickness.E4 = (double) this.GetWallThickNess(RdSAP, 4, false);
          if (surveyClass.Extensions[4].FloorConstruction == 1)
          {
            string e4Age = this.EXT.Ages.E4Age;
            if (Operators.CompareString(e4Age, "A", false) == 0 || Operators.CompareString(e4Age, "B", false) == 0)
            {
              float num39 = (float) (this.EXT.WallThickness.E4 + 0.315);
              float num40 = (float) (3.0 * Math.Log(Math.PI * (double) num38 / (double) num39 + 1.0) / (Math.PI * (double) num38 + (double) num39));
              float num41 = (float) (9.0 / 10.0 / (double) num38 + 87.0 / 80.0 / (double) num38);
              this.Dwelling.Floors[index5].U_Value = (float) Math.Round(1.0 / (0.54 + 1.0 / ((double) num40 + (double) num41)), 2);
            }
            else
            {
              float num42 = (float) (this.EXT.WallThickness.E4 + 1.5 * (0.17 + (double) num1 / 0.035 + 0.04));
              this.Dwelling.Floors[index5].U_Value = (double) num42 >= (double) num38 ? (float) Math.Round(1.5 / (0.457 * (double) num38 + (double) num42), 2) : (float) Math.Round(3.0 * Math.Log(Math.PI * (double) num38 / (double) num42 + 1.0) / (Math.PI * (double) num38 + (double) num42), 2);
            }
          }
          else if (surveyClass.Extensions[4].FloorConstruction == 3 | surveyClass.Extensions[4].FloorConstruction == 4)
          {
            float num43 = (float) (this.EXT.WallThickness.E4 + 0.315);
            float num44 = (float) (3.0 * Math.Log(Math.PI * (double) num38 / (double) num43 + 1.0) / (Math.PI * (double) num38 + (double) num43));
            float num45 = (float) (9.0 / 10.0 / (double) num38 + 87.0 / 80.0 / (double) num38);
            this.Dwelling.Floors[index5].U_Value = (float) Math.Round(1.0 / (0.34 + (double) num1 / 0.035 + 0.2 + 1.0 / ((double) num44 + (double) num45)), 2);
          }
          else if (surveyClass.Extensions[4].FloorConstruction == 2)
          {
            float num46 = (float) (this.EXT.WallThickness.E4 + 1.5 * (0.17 + (double) num1 / 0.035 + 0.04));
            this.Dwelling.Floors[index5].U_Value = (double) num46 >= (double) num38 ? (float) Math.Round(1.5 / (0.457 * (double) num38 + (double) num46), 2) : (float) Math.Round(3.0 * Math.Log(Math.PI * (double) num38 / (double) num46 + 1.0) / (Math.PI * (double) num38 + (double) num46), 2);
          }
          this.Dwelling.Floors[index5].Name = "Extention 4 Floor";
          this.Dwelling.Floors[index5].Type = "Ground floor";
          this.Dwelling.Floors[index5].Area = this.Dwelling.Dims[checked (this.EXT.MStoreys + this.EXT.E1Storeys + this.EXT.E2Storeys + this.EXT.E3Storeys)].Area;
        }
        else if (surveyClass.Extensions[4].LowestFloor == 3)
        {
          this.Dwelling.Floors[index5].U_Value = 0.7f;
          this.Dwelling.Floors[index5].Name = "Extention 4 Floor";
          this.Dwelling.Floors[index5].Type = "Exposed floor";
          this.Dwelling.Floors[index5].Area = this.Dwelling.Dims[checked (this.EXT.MStoreys + this.EXT.E1Storeys + this.EXT.E2Storeys + this.EXT.E3Storeys)].Area;
        }
        else if (surveyClass.Extensions[4].LowestFloor == 2 | surveyClass.Extensions[4].LowestFloor == 1)
        {
          if (surveyClass.Extensions[4].FloorInsulation == 1 | surveyClass.Extensions[4].FloorInsulation == 2)
          {
            string e4Age = this.EXT.Ages.E4Age;
            // ISSUE: reference to a compiler-generated method
            switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(e4Age))
            {
              case 3222007936:
                if (Operators.CompareString(e4Age, "E", false) == 0)
                  break;
                goto default;
              case 3238785555:
                if (Operators.CompareString(e4Age, "D", false) == 0)
                  break;
                goto default;
              case 3255563174:
                if (Operators.CompareString(e4Age, "G", false) == 0)
                  break;
                goto default;
              case 3272340793:
                if (Operators.CompareString(e4Age, "F", false) == 0)
                  break;
                goto default;
              case 3289118412:
                if (Operators.CompareString(e4Age, "A", false) == 0)
                  break;
                goto default;
              case 3322673650:
                if (Operators.CompareString(e4Age, "C", false) == 0)
                  break;
                goto default;
              case 3339451269:
                if (Operators.CompareString(e4Age, "B", false) == 0)
                  break;
                goto default;
              case 3423339364:
                if (Operators.CompareString(e4Age, "I", false) == 0)
                  goto label_551;
                else
                  goto default;
              case 3440116983:
                if (Operators.CompareString(e4Age, "H", false) == 0)
                  goto label_551;
                else
                  goto default;
              case 3456894602:
                if (Operators.CompareString(e4Age, "K", false) == 0)
                {
                  this.Dwelling.Floors[index5].U_Value = 0.22f;
                  goto default;
                }
                else
                  goto default;
              case 3473672221:
                if (Operators.CompareString(e4Age, "J", false) == 0)
                {
                  this.Dwelling.Floors[index5].U_Value = 0.25f;
                  goto default;
                }
                else
                  goto default;
              default:
label_554:
                goto label_555;
            }
            this.Dwelling.Floors[index5].U_Value = 1.2f;
            goto label_554;
label_551:
            this.Dwelling.Floors[index5].U_Value = 0.51f;
            goto label_554;
          }
label_555:
          if (surveyClass.Extensions[4].FloorInsulation == 3)
          {
            string e4Age = this.EXT.Ages.E4Age;
            // ISSUE: reference to a compiler-generated method
            switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(e4Age))
            {
              case 3222007936:
                if (Operators.CompareString(e4Age, "E", false) == 0)
                  break;
                goto default;
              case 3238785555:
                if (Operators.CompareString(e4Age, "D", false) == 0)
                  break;
                goto default;
              case 3255563174:
                if (Operators.CompareString(e4Age, "G", false) == 0)
                  break;
                goto default;
              case 3272340793:
                if (Operators.CompareString(e4Age, "F", false) == 0)
                  break;
                goto default;
              case 3289118412:
                if (Operators.CompareString(e4Age, "A", false) == 0)
                  break;
                goto default;
              case 3322673650:
                if (Operators.CompareString(e4Age, "C", false) == 0)
                  break;
                goto default;
              case 3339451269:
                if (Operators.CompareString(e4Age, "B", false) == 0)
                  break;
                goto default;
              case 3423339364:
                if (Operators.CompareString(e4Age, "I", false) == 0)
                  goto label_569;
                else
                  goto default;
              case 3440116983:
                if (Operators.CompareString(e4Age, "H", false) == 0)
                  goto label_569;
                else
                  goto default;
              case 3456894602:
                if (Operators.CompareString(e4Age, "K", false) == 0)
                {
                  this.Dwelling.Floors[index5].U_Value = 0.22f;
                  goto default;
                }
                else
                  goto default;
              case 3473672221:
                if (Operators.CompareString(e4Age, "J", false) == 0)
                {
                  this.Dwelling.Floors[index5].U_Value = 0.25f;
                  goto default;
                }
                else
                  goto default;
              default:
label_572:
                goto label_573;
            }
            this.Dwelling.Floors[index5].U_Value = 0.5f;
            goto label_572;
label_569:
            this.Dwelling.Floors[index5].U_Value = 0.5f;
            goto label_572;
          }
label_573:
          this.Dwelling.Floors[index5].Name = "Extention 4 Floor";
          this.Dwelling.Floors[index5].Type = "Exposed floor";
          this.Dwelling.Floors[index5].Area = (float) Math.Round((double) this.Dwelling.Dims[checked (this.EXT.MStoreys + this.EXT.E1Storeys + this.EXT.E2Storeys + this.EXT.E3Storeys)].Area, 2);
        }
      }
    }

    private void WallAreas(Survey_Class RdSAP)
    {
      Survey_Class surveyClass = RdSAP;
      int index1 = 0;
      this.Dwelling.Walls[index1].Area = 0.0f;
      int num1 = checked (this.EXT.MStoreys - 1);
      int index2 = 0;
      while (index2 <= num1)
      {
        if (this.Dwelling.Dims[index2].Type != 3)
        {
          // ISSUE: variable of a reference type
          float& local;
          // ISSUE: explicit reference operation
          double num2 = (double) ^(local = ref this.Dwelling.Walls[index1].Area) + (double) this.Dwelling.Dims[index2].Perimeter * (double) this.Dwelling.Dims[index2].Height;
          local = (float) num2;
        }
        checked { ++index2; }
      }
      if (surveyClass.Extensions[0].AltPresent)
      {
        // ISSUE: variable of a reference type
        float& local;
        // ISSUE: explicit reference operation
        double num3 = (double) (^(local = ref this.Dwelling.Walls[index1].Area) - (float) surveyClass.Extensions[0].AltWallArea);
        local = (float) num3;
      }
      if (this.EXT.IncFlatCorridor)
      {
        // ISSUE: variable of a reference type
        float& local;
        // ISSUE: explicit reference operation
        double num4 = (double) ^(local = ref this.Dwelling.Walls[index1].Area) - (double) this.Dwelling.Walls[checked (this.Dwelling.Walls.Length - 1)].Area;
        local = (float) num4;
      }
      this.Dwelling.Walls[index1].Area = (float) Math.Round((double) this.Dwelling.Walls[index1].Area, 2);
      if (this.EXT.MainRoof)
      {
        if (!surveyClass.Extensions[0].RoofRoom_Edit)
        {
          checked { ++index1; }
        }
        else
        {
          if (surveyClass.Extensions[0].RoofRoom_GableWall[0].Area != 0.0)
            checked { ++index1; }
          if (surveyClass.Extensions[0].RoofRoom_GableWall[1].Area != 0.0)
            checked { ++index1; }
          if (surveyClass.Extensions[0].RoofRoom_StudWall[0].Area != 0.0)
            checked { ++index1; }
          if (surveyClass.Extensions[0].RoofRoom_StudWall[1].Area != 0.0)
            checked { ++index1; }
        }
      }
      if (this.EXT.Ext1)
      {
        checked { ++index1; }
        this.Dwelling.Walls[index1].Area = 0.0f;
        int mstoreys = this.EXT.MStoreys;
        int num5 = checked (this.EXT.MStoreys + this.EXT.E1Storeys - 1);
        int index3 = mstoreys;
        while (index3 <= num5)
        {
          if (this.Dwelling.Dims[index3].Type != 3)
          {
            // ISSUE: variable of a reference type
            float& local;
            // ISSUE: explicit reference operation
            double num6 = (double) ^(local = ref this.Dwelling.Walls[index1].Area) + (double) this.Dwelling.Dims[index3].Perimeter * (double) this.Dwelling.Dims[index3].Height;
            local = (float) num6;
          }
          checked { ++index3; }
        }
        if (surveyClass.Extensions[1].AltPresent)
        {
          // ISSUE: variable of a reference type
          float& local;
          // ISSUE: explicit reference operation
          double num7 = (double) (^(local = ref this.Dwelling.Walls[index1].Area) - (float) surveyClass.Extensions[1].AltWallArea);
          local = (float) num7;
        }
        this.Dwelling.Walls[index1].Area = (float) Math.Round((double) this.Dwelling.Walls[index1].Area, 2);
        if (this.EXT.Ext1Roof)
        {
          if (!surveyClass.Extensions[1].RoofRoom_Edit)
          {
            checked { ++index1; }
          }
          else
          {
            if (surveyClass.Extensions[1].RoofRoom_GableWall[0].Area != 0.0)
              checked { ++index1; }
            if (surveyClass.Extensions[1].RoofRoom_GableWall[1].Area != 0.0)
              checked { ++index1; }
            if (surveyClass.Extensions[1].RoofRoom_StudWall[0].Area != 0.0)
              checked { ++index1; }
            if (surveyClass.Extensions[1].RoofRoom_StudWall[1].Area != 0.0)
              checked { ++index1; }
          }
        }
      }
      if (this.EXT.Ext2)
      {
        checked { ++index1; }
        this.Dwelling.Walls[index1].Area = 0.0f;
        int num8 = checked (this.EXT.MStoreys + this.EXT.E1Storeys);
        int num9 = checked (this.EXT.MStoreys + this.EXT.E1Storeys + this.EXT.E2Storeys - 1);
        int index4 = num8;
        while (index4 <= num9)
        {
          if (this.Dwelling.Dims[index4].Type != 3)
          {
            // ISSUE: variable of a reference type
            float& local;
            // ISSUE: explicit reference operation
            double num10 = (double) ^(local = ref this.Dwelling.Walls[index1].Area) + (double) this.Dwelling.Dims[index4].Perimeter * (double) this.Dwelling.Dims[index4].Height;
            local = (float) num10;
          }
          checked { ++index4; }
        }
        if (surveyClass.Extensions[2].AltPresent)
        {
          // ISSUE: variable of a reference type
          float& local;
          // ISSUE: explicit reference operation
          double num11 = (double) (^(local = ref this.Dwelling.Walls[index1].Area) - (float) surveyClass.Extensions[2].AltWallArea);
          local = (float) num11;
        }
        this.Dwelling.Walls[index1].Area = (float) Math.Round((double) this.Dwelling.Walls[index1].Area, 2);
        if (this.EXT.Ext2Roof)
        {
          if (!surveyClass.Extensions[2].RoofRoom_Edit)
          {
            checked { ++index1; }
          }
          else
          {
            if (surveyClass.Extensions[2].RoofRoom_GableWall[0].Area != 0.0)
              checked { ++index1; }
            if (surveyClass.Extensions[2].RoofRoom_GableWall[1].Area != 0.0)
              checked { ++index1; }
            if (surveyClass.Extensions[2].RoofRoom_StudWall[0].Area != 0.0)
              checked { ++index1; }
            if (surveyClass.Extensions[2].RoofRoom_StudWall[1].Area != 0.0)
              checked { ++index1; }
          }
        }
      }
      if (this.EXT.Ext3)
      {
        checked { ++index1; }
        this.Dwelling.Walls[index1].Area = 0.0f;
        int num12 = checked (this.EXT.MStoreys + this.EXT.E1Storeys + this.EXT.E2Storeys);
        int num13 = checked (this.EXT.MStoreys + this.EXT.E1Storeys + this.EXT.E2Storeys + this.EXT.E3Storeys - 1);
        int index5 = num12;
        while (index5 <= num13)
        {
          if (this.Dwelling.Dims[index5].Type != 3)
          {
            // ISSUE: variable of a reference type
            float& local;
            // ISSUE: explicit reference operation
            double num14 = (double) ^(local = ref this.Dwelling.Walls[index1].Area) + (double) this.Dwelling.Dims[index5].Perimeter * (double) this.Dwelling.Dims[index5].Height;
            local = (float) num14;
          }
          checked { ++index5; }
        }
        if (surveyClass.Extensions[3].AltPresent)
        {
          // ISSUE: variable of a reference type
          float& local;
          // ISSUE: explicit reference operation
          double num15 = (double) (^(local = ref this.Dwelling.Walls[index1].Area) - (float) surveyClass.Extensions[3].AltWallArea);
          local = (float) num15;
        }
        this.Dwelling.Walls[index1].Area = (float) Math.Round((double) this.Dwelling.Walls[index1].Area, 2);
        if (this.EXT.Ext3Roof)
        {
          if (!surveyClass.Extensions[3].RoofRoom_Edit)
          {
            checked { ++index1; }
          }
          else
          {
            if (surveyClass.Extensions[3].RoofRoom_GableWall[0].Area != 0.0)
              checked { ++index1; }
            if (surveyClass.Extensions[3].RoofRoom_GableWall[1].Area != 0.0)
              checked { ++index1; }
            if (surveyClass.Extensions[3].RoofRoom_StudWall[0].Area != 0.0)
              checked { ++index1; }
            if (surveyClass.Extensions[3].RoofRoom_StudWall[1].Area != 0.0)
              checked { ++index1; }
          }
        }
      }
      if (this.EXT.Ext4)
      {
        int index6 = checked (index1 + 1);
        this.Dwelling.Walls[index6].Area = 0.0f;
        int num16 = checked (this.EXT.MStoreys + this.EXT.E1Storeys + this.EXT.E2Storeys + this.EXT.E3Storeys);
        int num17 = checked (this.EXT.MStoreys + this.EXT.E1Storeys + this.EXT.E2Storeys + this.EXT.E3Storeys + this.EXT.E4Storeys - 1);
        int index7 = num16;
        while (index7 <= num17)
        {
          if (this.Dwelling.Dims[index7].Type != 3)
          {
            // ISSUE: variable of a reference type
            float& local;
            // ISSUE: explicit reference operation
            double num18 = (double) ^(local = ref this.Dwelling.Walls[index6].Area) + (double) this.Dwelling.Dims[index7].Perimeter * (double) this.Dwelling.Dims[index7].Height;
            local = (float) num18;
          }
          checked { ++index7; }
        }
        if (surveyClass.Extensions[4].AltPresent)
        {
          // ISSUE: variable of a reference type
          float& local;
          // ISSUE: explicit reference operation
          double num19 = (double) (^(local = ref this.Dwelling.Walls[index6].Area) - (float) surveyClass.Extensions[4].AltWallArea);
          local = (float) num19;
        }
        this.Dwelling.Walls[index6].Area = (float) Math.Round((double) this.Dwelling.Walls[index6].Area, 2);
      }
    }

    private void RoofAreas(Survey_Class RdSAP)
    {
      int index1 = -1;
      Survey_Class surveyClass = RdSAP;
      switch (surveyClass.Extensions[0].RoofConstruction)
      {
        case 2:
        case 4:
        case 5:
        case 6:
          checked { ++index1; }
          this.Dwelling.Roofs[index1].Area = 0.0f;
          int num1 = checked (this.EXT.MStoreys - 1);
          int index2 = 0;
          while (index2 <= num1)
          {
            if ((double) this.Dwelling.Dims[index2].Area > (double) this.Dwelling.Roofs[0].Area)
              this.Dwelling.Roofs[0].Area = this.Dwelling.Dims[index2].Area;
            checked { ++index2; }
          }
          if (this.EXT.MainRoof)
          {
            // ISSUE: variable of a reference type
            float& local;
            // ISSUE: explicit reference operation
            double num2 = (double) (^(local = ref this.Dwelling.Roofs[0].Area) - (float) surveyClass.Extensions[0].RoofRoomFloor_Area);
            local = (float) num2;
          }
          this.Dwelling.Roofs[index1].Area = (float) Math.Round((double) this.Dwelling.Roofs[index1].Area, 2);
          break;
      }
      if (this.EXT.MainRoof)
      {
        if (!surveyClass.Extensions[0].RoofRoom_Edit)
        {
          checked { ++index1; }
        }
        else
        {
          if (surveyClass.Extensions[0].RoofRoom_FlatCeiling[0].Area != 0.0)
            checked { ++index1; }
          if (surveyClass.Extensions[0].RoofRoom_FlatCeiling[1].Area != 0.0)
            checked { ++index1; }
          if (surveyClass.Extensions[0].RoofRoom_Slope[0].Area != 0.0)
            checked { ++index1; }
          if (surveyClass.Extensions[0].RoofRoom_Slope[1].Area != 0.0)
            checked { ++index1; }
        }
      }
      if (this.EXT.Ext1)
      {
        switch (surveyClass.Extensions[1].RoofConstruction)
        {
          case 2:
          case 4:
          case 5:
          case 6:
            checked { ++index1; }
            this.Dwelling.Roofs[index1].Area = 0.0f;
            int mstoreys = this.EXT.MStoreys;
            int num3 = checked (this.EXT.MStoreys + this.EXT.E1Storeys - 1);
            int index3 = mstoreys;
            while (index3 <= num3)
            {
              if ((double) this.Dwelling.Dims[index3].Area > (double) this.Dwelling.Roofs[index1].Area)
                this.Dwelling.Roofs[index1].Area = this.Dwelling.Dims[index3].Area;
              checked { ++index3; }
            }
            if (this.EXT.Ext1Roof)
            {
              // ISSUE: variable of a reference type
              float& local;
              // ISSUE: explicit reference operation
              double num4 = (double) (^(local = ref this.Dwelling.Roofs[index1].Area) - (float) surveyClass.Extensions[1].RoofRoomFloor_Area);
              local = (float) num4;
            }
            this.Dwelling.Roofs[index1].Area = (float) Math.Round((double) this.Dwelling.Roofs[index1].Area, 2);
            break;
        }
        if (this.EXT.Ext1Roof)
        {
          if (!surveyClass.Extensions[1].RoofRoom_Edit)
          {
            checked { ++index1; }
          }
          else
          {
            if (surveyClass.Extensions[1].RoofRoom_FlatCeiling[0].Area != 0.0)
              checked { ++index1; }
            if (surveyClass.Extensions[1].RoofRoom_FlatCeiling[1].Area != 0.0)
              checked { ++index1; }
            if (surveyClass.Extensions[1].RoofRoom_Slope[0].Area != 0.0)
              checked { ++index1; }
            if (surveyClass.Extensions[1].RoofRoom_Slope[1].Area != 0.0)
              checked { ++index1; }
          }
        }
      }
      if (this.EXT.Ext2)
      {
        switch (surveyClass.Extensions[2].RoofConstruction)
        {
          case 2:
          case 4:
          case 5:
          case 6:
            checked { ++index1; }
            this.Dwelling.Roofs[index1].Area = 0.0f;
            int num5 = checked (this.EXT.MStoreys + this.EXT.E1Storeys);
            int num6 = checked (this.EXT.MStoreys + this.EXT.E1Storeys + this.EXT.E2Storeys - 1);
            int index4 = num5;
            while (index4 <= num6)
            {
              if ((double) this.Dwelling.Dims[index4].Area > (double) this.Dwelling.Roofs[index1].Area)
                this.Dwelling.Roofs[index1].Area = this.Dwelling.Dims[index4].Area;
              checked { ++index4; }
            }
            if (this.EXT.Ext2Roof)
            {
              // ISSUE: variable of a reference type
              float& local;
              // ISSUE: explicit reference operation
              double num7 = (double) (^(local = ref this.Dwelling.Roofs[index1].Area) - (float) surveyClass.Extensions[2].RoofRoomFloor_Area);
              local = (float) num7;
            }
            this.Dwelling.Roofs[index1].Area = (float) Math.Round((double) this.Dwelling.Roofs[index1].Area, 2);
            break;
        }
        if (this.EXT.Ext2Roof)
        {
          if (!surveyClass.Extensions[2].RoofRoom_Edit)
          {
            checked { ++index1; }
          }
          else
          {
            if (surveyClass.Extensions[2].RoofRoom_FlatCeiling[0].Area != 0.0)
              checked { ++index1; }
            if (surveyClass.Extensions[2].RoofRoom_FlatCeiling[1].Area != 0.0)
              checked { ++index1; }
            if (surveyClass.Extensions[2].RoofRoom_Slope[0].Area != 0.0)
              checked { ++index1; }
            if (surveyClass.Extensions[2].RoofRoom_Slope[1].Area != 0.0)
              checked { ++index1; }
          }
        }
      }
      if (this.EXT.Ext3)
      {
        switch (surveyClass.Extensions[3].RoofConstruction)
        {
          case 2:
          case 4:
          case 5:
          case 6:
            checked { ++index1; }
            this.Dwelling.Roofs[index1].Area = 0.0f;
            int num8 = checked (this.EXT.MStoreys + this.EXT.E1Storeys + this.EXT.E2Storeys);
            int num9 = checked (this.EXT.MStoreys + this.EXT.E1Storeys + this.EXT.E2Storeys + this.EXT.E3Storeys - 1);
            int index5 = num8;
            while (index5 <= num9)
            {
              if ((double) this.Dwelling.Dims[index5].Area > (double) this.Dwelling.Roofs[index1].Area)
                this.Dwelling.Roofs[index1].Area = this.Dwelling.Dims[index5].Area;
              checked { ++index5; }
            }
            if (this.EXT.Ext3Roof)
            {
              // ISSUE: variable of a reference type
              float& local;
              // ISSUE: explicit reference operation
              double num10 = (double) (^(local = ref this.Dwelling.Roofs[index1].Area) - (float) surveyClass.Extensions[3].RoofRoomFloor_Area);
              local = (float) num10;
            }
            this.Dwelling.Roofs[index1].Area = (float) Math.Round((double) this.Dwelling.Roofs[index1].Area, 2);
            break;
        }
        if (this.EXT.Ext3Roof)
        {
          if (!surveyClass.Extensions[3].RoofRoom_Edit)
          {
            checked { ++index1; }
          }
          else
          {
            if (surveyClass.Extensions[3].RoofRoom_FlatCeiling[0].Area != 0.0)
              checked { ++index1; }
            if (surveyClass.Extensions[3].RoofRoom_FlatCeiling[1].Area != 0.0)
              checked { ++index1; }
            if (surveyClass.Extensions[3].RoofRoom_Slope[0].Area != 0.0)
              checked { ++index1; }
            if (surveyClass.Extensions[3].RoofRoom_Slope[1].Area != 0.0)
              checked { ++index1; }
          }
        }
      }
      if (this.EXT.Ext4)
      {
        switch (surveyClass.Extensions[4].RoofConstruction)
        {
          case 2:
          case 4:
          case 5:
          case 6:
            int index6 = checked (index1 + 1);
            this.Dwelling.Roofs[index6].Area = 0.0f;
            int num11 = checked (this.EXT.MStoreys + this.EXT.E1Storeys + this.EXT.E2Storeys + this.EXT.E3Storeys);
            int num12 = checked (this.EXT.MStoreys + this.EXT.E1Storeys + this.EXT.E2Storeys + this.EXT.E3Storeys + this.EXT.E4Storeys - 1);
            int index7 = num11;
            while (index7 <= num12)
            {
              if ((double) this.Dwelling.Dims[index7].Area > (double) this.Dwelling.Roofs[index6].Area)
                this.Dwelling.Roofs[index6].Area = this.Dwelling.Dims[index7].Area;
              checked { ++index7; }
            }
            if (this.EXT.Ext4Roof)
            {
              // ISSUE: variable of a reference type
              float& local;
              // ISSUE: explicit reference operation
              double num13 = (double) (^(local = ref this.Dwelling.Roofs[index6].Area) - (float) surveyClass.Extensions[4].RoofRoomFloor_Area);
              local = (float) num13;
            }
            this.Dwelling.Roofs[index6].Area = (float) Math.Round((double) this.Dwelling.Roofs[index6].Area, 2);
            break;
        }
      }
    }

    private void WindowArea(Survey_Class RdSAP)
    {
      Survey_Class surveyClass = RdSAP;
      switch (surveyClass.Openings.GlazedArea)
      {
        case 1:
        case 2:
        case 3:
          float num1 = 0.0f;
          float num2 = 0.0f;
          int num3 = checked (this.Dwelling.Dims.Length - 1);
          int index1 = 0;
          while (index1 <= num3)
          {
            num2 += this.Dwelling.Dims[index1].Area;
            checked { ++index1; }
          }
          if (this.EXT.Cons)
            num2 -= this.Dwelling.Dims[checked (this.Dwelling.Dims.Length - 1)].Area;
          this.EXT.MArea = 0.0f;
          int num4 = checked (this.EXT.MStoreys - 1);
          int index2 = 0;
          while (index2 <= num4)
          {
            RdSAP_TO_SAP.Extensions ext;
            double num5 = (double) (ext = this.EXT).MArea + (double) this.Dwelling.Dims[index2].Area;
            ext.MArea = (float) num5;
            checked { ++index2; }
          }
          if (this.EXT.Ext1)
          {
            this.EXT.E1Area = 0.0f;
            int mstoreys = this.EXT.MStoreys;
            int num6 = checked (this.EXT.MStoreys + this.EXT.E1Storeys - 1);
            int index3 = mstoreys;
            while (index3 <= num6)
            {
              RdSAP_TO_SAP.Extensions ext;
              double num7 = (double) (ext = this.EXT).E1Area + (double) this.Dwelling.Dims[index3].Area;
              ext.E1Area = (float) num7;
              checked { ++index3; }
            }
          }
          if (this.EXT.Ext2)
          {
            this.EXT.E2Area = 0.0f;
            int num8 = checked (this.EXT.MStoreys + this.EXT.E1Storeys);
            int num9 = checked (this.EXT.MStoreys + this.EXT.E1Storeys + this.EXT.E2Storeys - 1);
            int index4 = num8;
            while (index4 <= num9)
            {
              RdSAP_TO_SAP.Extensions ext;
              double num10 = (double) (ext = this.EXT).E2Area + (double) this.Dwelling.Dims[index4].Area;
              ext.E2Area = (float) num10;
              checked { ++index4; }
            }
          }
          if (this.EXT.Ext3)
          {
            this.EXT.E3Area = 0.0f;
            int num11 = checked (this.EXT.MStoreys + this.EXT.E1Storeys + this.EXT.E2Storeys);
            int num12 = checked (this.EXT.MStoreys + this.EXT.E1Storeys + this.EXT.E2Storeys + this.EXT.E3Storeys - 1);
            int index5 = num11;
            while (index5 <= num12)
            {
              RdSAP_TO_SAP.Extensions ext;
              double num13 = (double) (ext = this.EXT).E3Area + (double) this.Dwelling.Dims[index5].Area;
              ext.E3Area = (float) num13;
              checked { ++index5; }
            }
          }
          if (this.EXT.Ext4)
          {
            this.EXT.E4Area = 0.0f;
            int num14 = checked (this.EXT.MStoreys + this.EXT.E1Storeys + this.EXT.E2Storeys + this.EXT.E3Storeys);
            int num15 = checked (this.EXT.MStoreys + this.EXT.E1Storeys + this.EXT.E2Storeys + this.EXT.E3Storeys + this.EXT.E4Storeys - 1);
            int index6 = num14;
            while (index6 <= num15)
            {
              RdSAP_TO_SAP.Extensions ext;
              double num16 = (double) (ext = this.EXT).E4Area + (double) this.Dwelling.Dims[index6].Area;
              ext.E4Area = (float) num16;
              checked { ++index6; }
            }
          }
          if (surveyClass.General.PropertyType1 == 1 | surveyClass.General.PropertyType1 == 2)
          {
            string mage = this.EXT.Ages.MAge;
            // ISSUE: reference to a compiler-generated method
            switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(mage))
            {
              case 3222007936:
                if (Operators.CompareString(mage, "E", false) == 0)
                {
                  num1 = (float) (0.1239 * (double) num2 + 7.332);
                  goto label_67;
                }
                else
                  goto label_67;
              case 3238785555:
                if (Operators.CompareString(mage, "D", false) == 0)
                {
                  num1 = (float) (0.1294 * (double) num2 + 5.515);
                  goto label_67;
                }
                else
                  goto label_67;
              case 3255563174:
                if (Operators.CompareString(mage, "G", false) == 0)
                {
                  num1 = (float) (0.1356 * (double) num2 + 5.242);
                  goto label_67;
                }
                else
                  goto label_67;
              case 3272340793:
                if (Operators.CompareString(mage, "F", false) == 0)
                {
                  num1 = (float) (0.1252 * (double) num2 + 5.52);
                  goto label_67;
                }
                else
                  goto label_67;
              case 3289118412:
                if (Operators.CompareString(mage, "A", false) == 0)
                  break;
                goto label_67;
              case 3322673650:
                if (Operators.CompareString(mage, "C", false) == 0)
                  break;
                goto label_67;
              case 3339451269:
                if (Operators.CompareString(mage, "B", false) == 0)
                  break;
                goto label_67;
              case 3423339364:
                if (Operators.CompareString(mage, "I", false) == 0)
                {
                  num1 = (float) (0.1382 * (double) num2 - 0.027);
                  goto label_67;
                }
                else
                  goto label_67;
              case 3440116983:
                if (Operators.CompareString(mage, "H", false) == 0)
                {
                  num1 = (float) (0.0948 * (double) num2 + 6.534);
                  goto label_67;
                }
                else
                  goto label_67;
              case 3456894602:
                if (Operators.CompareString(mage, "K", false) == 0)
                  goto label_45;
                else
                  goto label_67;
              case 3473672221:
                if (Operators.CompareString(mage, "J", false) == 0)
                  goto label_45;
                else
                  goto label_67;
              default:
                goto label_67;
            }
            num1 = (float) (0.122 * (double) num2 + 6.875);
            goto label_67;
label_45:
            num1 = (float) (0.1435 * (double) num2 - 0.403);
          }
          else
          {
            string mage = this.EXT.Ages.MAge;
            // ISSUE: reference to a compiler-generated method
            switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(mage))
            {
              case 3222007936:
                if (Operators.CompareString(mage, "E", false) == 0)
                {
                  num1 = (float) (0.0717 * (double) num2 + 6.56);
                  goto default;
                }
                else
                  goto default;
              case 3238785555:
                if (Operators.CompareString(mage, "D", false) == 0)
                {
                  num1 = (float) (0.0341 * (double) num2 + 8.562);
                  goto default;
                }
                else
                  goto default;
              case 3255563174:
                if (Operators.CompareString(mage, "G", false) == 0)
                {
                  num1 = (float) (0.051 * (double) num2 + 4.554);
                  goto default;
                }
                else
                  goto default;
              case 3272340793:
                if (Operators.CompareString(mage, "F", false) == 0)
                {
                  num1 = (float) (0.1199 * (double) num2 + 1.975);
                  goto default;
                }
                else
                  goto default;
              case 3289118412:
                if (Operators.CompareString(mage, "A", false) == 0)
                  break;
                goto default;
              case 3322673650:
                if (Operators.CompareString(mage, "C", false) == 0)
                  break;
                goto default;
              case 3339451269:
                if (Operators.CompareString(mage, "B", false) == 0)
                  break;
                goto default;
              case 3423339364:
                if (Operators.CompareString(mage, "I", false) == 0)
                {
                  num1 = (float) (0.1148 * (double) num2 + 0.392);
                  goto default;
                }
                else
                  goto default;
              case 3440116983:
                if (Operators.CompareString(mage, "H", false) == 0)
                {
                  num1 = (float) (0.0813 * (double) num2 + 3.744);
                  goto default;
                }
                else
                  goto default;
              case 3456894602:
                if (Operators.CompareString(mage, "K", false) == 0)
                  goto label_65;
                else
                  goto default;
              case 3473672221:
                if (Operators.CompareString(mage, "J", false) == 0)
                  goto label_65;
                else
                  goto default;
              default:
label_66:
                goto label_67;
            }
            num1 = (float) (0.0801 * (double) num2 + 5.58);
            goto label_66;
label_65:
            num1 = (float) (0.1148 * (double) num2 + 0.392);
            goto label_66;
          }
label_67:
          if (surveyClass.Openings.GlazedArea == 3)
            num1 *= 0.75f;
          if (surveyClass.Openings.GlazedArea == 2)
            num1 *= 1.25f;
          if (surveyClass.Openings.MultipleGlazedProportion == 100.0)
            this.Dwelling.Windows[0].Area = (float) Math.Round((double) num1 * (double) this.EXT.MArea / (double) num2, 2);
          else if (surveyClass.Openings.MultipleGlazedProportion == 0.0)
          {
            this.Dwelling.Windows[0].Area = (float) Math.Round((double) num1 * (double) this.EXT.MArea / (double) num2, 2);
          }
          else
          {
            this.Dwelling.Windows[0].Area = (float) Math.Round((double) num1 * (double) this.EXT.MArea / (double) num2 * surveyClass.Openings.MultipleGlazedProportion / 100.0, 2);
            this.Dwelling.Windows[1].Area = (float) Math.Round((double) num1 * (double) this.EXT.MArea / (double) num2 * (100.0 - surveyClass.Openings.MultipleGlazedProportion) / 100.0, 2);
          }
          if (this.EXT.Ext1)
          {
            if (surveyClass.Openings.MultipleGlazedProportion == 0.0)
              this.Dwelling.Windows[1].Area = (float) Math.Round((double) num1 * (double) this.EXT.E1Area / (double) num2, 2);
            else if (surveyClass.Openings.MultipleGlazedProportion == 100.0)
            {
              this.Dwelling.Windows[1].Area = (float) Math.Round((double) num1 * (double) this.EXT.E1Area / (double) num2, 2);
            }
            else
            {
              this.Dwelling.Windows[2].Area = (float) Math.Round((double) num1 * (double) this.EXT.E1Area / (double) num2 * surveyClass.Openings.MultipleGlazedProportion / 100.0, 2);
              this.Dwelling.Windows[3].Area = (float) Math.Round((double) num1 * (double) this.EXT.E1Area / (double) num2 * (100.0 - surveyClass.Openings.MultipleGlazedProportion) / 100.0, 2);
            }
          }
          if (this.EXT.Ext2)
          {
            if (surveyClass.Openings.MultipleGlazedProportion == 0.0)
              this.Dwelling.Windows[2].Area = (float) Math.Round((double) num1 * (double) this.EXT.E2Area / (double) num2, 2);
            else if (surveyClass.Openings.MultipleGlazedProportion == 100.0)
            {
              this.Dwelling.Windows[2].Area = (float) Math.Round((double) num1 * (double) this.EXT.E2Area / (double) num2, 2);
            }
            else
            {
              this.Dwelling.Windows[4].Area = (float) Math.Round((double) num1 * (double) this.EXT.E2Area / (double) num2 * surveyClass.Openings.MultipleGlazedProportion / 100.0, 2);
              this.Dwelling.Windows[5].Area = (float) Math.Round((double) num1 * (double) this.EXT.E2Area / (double) num2 * (100.0 - surveyClass.Openings.MultipleGlazedProportion) / 100.0, 2);
            }
          }
          if (this.EXT.Ext3)
          {
            if (surveyClass.Openings.MultipleGlazedProportion == 0.0)
              this.Dwelling.Windows[3].Area = (float) Math.Round((double) num1 * (double) this.EXT.E3Area / (double) num2, 2);
            else if (surveyClass.Openings.MultipleGlazedProportion == 100.0)
            {
              this.Dwelling.Windows[3].Area = (float) Math.Round((double) num1 * (double) this.EXT.E3Area / (double) num2, 2);
            }
            else
            {
              this.Dwelling.Windows[6].Area = (float) Math.Round((double) num1 * (double) this.EXT.E3Area / (double) num2 * surveyClass.Openings.MultipleGlazedProportion / 100.0, 2);
              this.Dwelling.Windows[7].Area = (float) Math.Round((double) num1 * (double) this.EXT.E3Area / (double) num2 * (100.0 - surveyClass.Openings.MultipleGlazedProportion) / 100.0, 2);
            }
          }
          if (this.EXT.Ext4)
          {
            if (surveyClass.Openings.MultipleGlazedProportion == 0.0)
              this.Dwelling.Windows[4].Area = (float) Math.Round((double) num1 * (double) this.EXT.E4Area / (double) num2, 2);
            else if (surveyClass.Openings.MultipleGlazedProportion == 100.0)
            {
              this.Dwelling.Windows[4].Area = (float) Math.Round((double) num1 * (double) this.EXT.E4Area / (double) num2, 2);
            }
            else
            {
              this.Dwelling.Windows[8].Area = (float) Math.Round((double) num1 * (double) this.EXT.E4Area / (double) num2 * surveyClass.Openings.MultipleGlazedProportion / 100.0, 2);
              this.Dwelling.Windows[9].Area = (float) Math.Round((double) num1 * (double) this.EXT.E4Area / (double) num2 * (100.0 - surveyClass.Openings.MultipleGlazedProportion) / 100.0, 2);
            }
            break;
          }
          break;
      }
    }

    private enum LevelType
    {
      Ground = 1,
      Midfloor = 2,
      RoofRoom = 3,
    }
  }
}
