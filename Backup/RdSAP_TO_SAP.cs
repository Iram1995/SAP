
// Type: SAP2012.RdSAP_TO_SAP




using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using SAP2012.RdSAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace SAP2012
{
  public class RdSAP_TO_SAP
  {
    public bool CalcRound;
    public bool Occupancy_Calc;
    public SAP_Module.Dwelling x;
    public RdSAP_TO_SAP.Extensions Ext;
    private bool NoPump;
    private bool MainFlue;
    private bool MainFlue2;

    public RdSAP_TO_SAP()
    {
      this.x = new SAP_Module.Dwelling();
      this.Ext = new RdSAP_TO_SAP.Extensions();
    }

    public SAP_Module.Dwelling Convert_2_SAP(Survey_Class RdSAP)
    {
      Survey_Class surveyClass = RdSAP;
      this.x.Address.Line1 = RdSAP.General.AddressLine1;
      this.x.Address.Line2 = RdSAP.General.AddressLine2;
      this.x.Address.Line3 = RdSAP.General.AddressLine3;
      this.x.Address.City = RdSAP.General.City;
      this.x.Address.Country = Conversions.ToString(RdSAP.General.Country);
      this.x.Address.PostCost = RdSAP.General.PostCode;
      this.Ext.MainRoof = surveyClass.Extensions[0].RoofRoom;
      if (surveyClass.Age.NumberOfExtension >= 1)
      {
        this.Ext.Ext1 = true;
        this.Ext.Ext1Roof = surveyClass.Extensions[1].RoofRoom;
      }
      if (surveyClass.Age.NumberOfExtension >= 2)
      {
        this.Ext.Ext2 = true;
        this.Ext.Ext2Roof = surveyClass.Extensions[2].RoofRoom;
      }
      if (surveyClass.Age.NumberOfExtension >= 3)
      {
        this.Ext.Ext3 = true;
        this.Ext.Ext3Roof = surveyClass.Extensions[3].RoofRoom;
      }
      if (surveyClass.Age.NumberOfExtension >= 4)
      {
        this.Ext.Ext4 = true;
        this.Ext.Ext4Roof = surveyClass.Extensions[4].RoofRoom;
      }
      this.Ext.Cons = surveyClass.Conservatory.ConservatoryType == 4;
      this.Ext.Ages.MAge = Conversions.ToString(Microsoft.VisualBasic.Strings.ChrW(checked (surveyClass.Extensions[0].PropAge + 64)));
      if (this.Ext.MainRoof)
        this.Ext.Ages.MRoofAge = Conversions.ToString(Microsoft.VisualBasic.Strings.ChrW(checked (surveyClass.Extensions[0].RoofAge + 64)));
      if (this.Ext.Ext1)
      {
        this.Ext.Ages.E1Age = Conversions.ToString(Microsoft.VisualBasic.Strings.ChrW(checked (surveyClass.Extensions[1].PropAge + 64)));
        if (this.Ext.Ext1Roof)
          this.Ext.Ages.E1RoofAge = Conversions.ToString(Microsoft.VisualBasic.Strings.ChrW(checked (surveyClass.Extensions[1].RoofAge + 64)));
      }
      if (this.Ext.Ext2)
      {
        this.Ext.Ages.E2Age = Conversions.ToString(Microsoft.VisualBasic.Strings.ChrW(checked (surveyClass.Extensions[2].PropAge + 64)));
        if (this.Ext.Ext2Roof)
          this.Ext.Ages.E2RoofAge = Conversions.ToString(Microsoft.VisualBasic.Strings.ChrW(checked (surveyClass.Extensions[2].RoofAge + 64)));
      }
      if (this.Ext.Ext3)
      {
        this.Ext.Ages.E3Age = Conversions.ToString(Microsoft.VisualBasic.Strings.ChrW(checked (surveyClass.Extensions[3].PropAge + 64)));
        if (this.Ext.Ext3Roof)
          this.Ext.Ages.E3RoofAge = Conversions.ToString(Microsoft.VisualBasic.Strings.ChrW(checked (surveyClass.Extensions[3].RoofAge + 64)));
      }
      if (this.Ext.Ext4)
      {
        this.Ext.Ages.E4Age = Conversions.ToString(Microsoft.VisualBasic.Strings.ChrW(checked (surveyClass.Extensions[4].PropAge + 64)));
        if (this.Ext.Ext4Roof)
          this.Ext.Ages.E4RoofAge = Conversions.ToString(Microsoft.VisualBasic.Strings.ChrW(checked (surveyClass.Extensions[4].RoofAge + 64)));
      }
      switch (surveyClass.General.PropertyType1)
      {
        case 1:
          this.x.PropertyType = "House";
          break;
        case 2:
          this.x.PropertyType = "Bungalow";
          break;
        case 3:
          this.x.PropertyType = "Flat";
          break;
        case 4:
          this.x.PropertyType = "Maisonette";
          break;
      }
      this.x.Status = "Existing dwelling (SAP)";
      string propertyType = this.x.PropertyType;
      if (Operators.CompareString(propertyType, "House", false) == 0 || Operators.CompareString(propertyType, "Bungalow", false) == 0)
      {
        switch (surveyClass.General.PropertyType2)
        {
          case 1:
            this.x.BuildForm = "Detached";
            break;
          case 2:
            this.x.BuildForm = "Semi_Detached";
            break;
          case 3:
            this.x.BuildForm = "End_Terrace";
            break;
          case 4:
            this.x.BuildForm = "Mid_Terrace";
            break;
          case 5:
            this.x.BuildForm = "Enclosed_End_Terrace";
            break;
          case 6:
            this.x.BuildForm = "Enclosed_Mid_Terrace";
            break;
        }
      }
      this.Dimensions_1(RdSAP);
      this.OpaqueElements(RdSAP);
      this.Openings(RdSAP);
      this.Ventilation1(RdSAP);
      this.MainHeating_Spec(RdSAP);
      this.SecMainHeating_Spec(RdSAP);
      this.SecHeating_Spec(RdSAP);
      this.Electricity(RdSAP);
      this.Controls(RdSAP);
      this.SpaceCooling(RdSAP);
      if (!this.Occupancy_Calc)
        this.SecondaryHeatingCheck(RdSAP);
      this.FGHRS(RdSAP);
      this.WWHRS(RdSAP);
      this.Water_Spec(RdSAP);
      this.BoilerInterlock(RdSAP);
      this.PhotoVoltaic_Spec(RdSAP);
      this.WindTurbine_Spec(RdSAP);
      this.x.Conservatory = "No conservatory";
      this.x.LELOutlets = checked ((int) Math.Round(surveyClass.Renewable.FixedLightingOutletsCount));
      this.x.LELLights = checked ((int) Math.Round(surveyClass.Renewable.LowEnergyFixedLightingOutlets));
      this.x.LowEnergyLight = (float) Math.Round((double) checked (100 * this.x.LELLights) / (double) this.x.LELOutlets);
      RdSAP.Renewable.LowEnergylightsPercent = (double) this.x.LowEnergyLight;
      switch (surveyClass.Renewable.WindTurbinesTerrainType)
      {
        case 1:
          this.x.Terrain = "Dense urban";
          break;
        case 2:
          this.x.Terrain = "Low rise urban / suburban";
          break;
        case 3:
          this.x.Terrain = "Rural";
          break;
      }
      this.x.TMP.Type = "Indicative Value";
      this.x.TMP.Indicative = "Medium";
      this.x.GrossAreas = true;
      this.x.Location = surveyClass.General.Region;
      int num1 = checked (this.x.Storeys - 1);
      int index1 = 0;
      while (index1 <= num1)
      {
        this.x.Dims[index1].Perimeter = (float) Math.Round((double) this.x.Dims[index1].Perimeter, 2);
        this.x.Dims[index1].Area = (float) Math.Round((double) this.x.Dims[index1].Area, 2);
        this.x.Dims[index1].Height = (float) Math.Round((double) this.x.Dims[index1].Height, 2);
        // ISSUE: variable of a reference type
        float& local;
        // ISSUE: explicit reference operation
        double num2 = (double) ^(local = ref this.x.LivingArea) + (double) this.x.Dims[index1].Area;
        local = (float) num2;
        checked { ++index1; }
      }
      int NoofRooms = surveyClass.Age.MHabRooms;
      if (NoofRooms > 20)
        NoofRooms = 20;
      this.x.LivingFraction = this.Fraction(NoofRooms);
      // ISSUE: variable of a reference type
      float& local1;
      // ISSUE: explicit reference operation
      double num3 = (double) ^(local1 = ref this.x.LivingArea) * (double) this.x.LivingFraction;
      local1 = (float) num3;
      int num4 = checked (this.x.NoofRoofs - 1);
      int index2 = 0;
      while (index2 <= num4)
      {
        this.x.Roofs[index2].Area = (float) Math.Round((double) this.x.Roofs[index2].Area, 2);
        this.x.Roofs[index2].U_Value = (float) Math.Round((double) this.x.Roofs[index2].U_Value, 2);
        checked { ++index2; }
      }
      int num5 = checked (this.x.NoofWalls - 1);
      int index3 = 0;
      while (index3 <= num5)
      {
        this.x.Walls[index3].Area = (float) Math.Round((double) this.x.Walls[index3].Area, 2);
        this.x.Walls[index3].U_Value = (float) Math.Round((double) this.x.Walls[index3].U_Value, 2);
        checked { ++index3; }
      }
      if (this.x.Floors != null)
      {
        int num6 = checked (this.x.NoofFloors - 1);
        int index4 = 0;
        while (index4 <= num6)
        {
          this.x.Floors[index4].Area = (float) Math.Round((double) this.x.Floors[index4].Area, 2);
          this.x.Floors[index4].U_Value = (float) Math.Round((double) this.x.Floors[index4].U_Value, 2);
          checked { ++index4; }
        }
      }
      else
        this.x.Floors = new SAP_Module.Opaques[0];
      if (this.Ext.Ext1)
      {
        RdSAP_TO_SAP.Extensions ext;
        int num7 = checked ((ext = this.Ext).NoofExt + 1);
        ext.NoofExt = num7;
      }
      if (this.Ext.Ext2)
      {
        RdSAP_TO_SAP.Extensions ext;
        int num8 = checked ((ext = this.Ext).NoofExt + 1);
        ext.NoofExt = num8;
      }
      if (this.Ext.Ext3)
      {
        RdSAP_TO_SAP.Extensions ext;
        int num9 = checked ((ext = this.Ext).NoofExt + 1);
        ext.NoofExt = num9;
      }
      if (this.Ext.Ext4)
      {
        RdSAP_TO_SAP.Extensions ext;
        int num10 = checked ((ext = this.Ext).NoofExt + 1);
        ext.NoofExt = num10;
      }
      this.Ext.HabRooms = surveyClass.Age.MHabRooms;
      this.Ext.HeatHabRooms = surveyClass.Age.MHeatHabRooms;
      this.x.Transaction = Conversions.ToString(surveyClass.General.Transaction);
      this.x.Address.Country = Conversions.ToString(surveyClass.General.Country);
      return this.x;
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

    private void Dimensions_1(Survey_Class RdSAP)
    {
      Survey_Class surveyClass = RdSAP;
      this.Ext.MStoreys = surveyClass.Extensions[0].Storeys;
      if (this.Ext.Ext1)
        this.Ext.E1Storeys = surveyClass.Extensions[1].Storeys;
      if (this.Ext.Ext2)
        this.Ext.E2Storeys = surveyClass.Extensions[2].Storeys;
      if (this.Ext.Ext3)
        this.Ext.E3Storeys = surveyClass.Extensions[3].Storeys;
      if (this.Ext.Ext4)
        this.Ext.E4Storeys = surveyClass.Extensions[4].Storeys;
      if (surveyClass.Extensions[0].RoofRoom)
      {
        RdSAP_TO_SAP.Extensions ext;
        int num = checked ((ext = this.Ext).MStoreys + 1);
        ext.MStoreys = num;
      }
      if (surveyClass.Extensions[1].RoofRoom)
      {
        RdSAP_TO_SAP.Extensions ext;
        int num = checked ((ext = this.Ext).E1Storeys + 1);
        ext.E1Storeys = num;
      }
      if (surveyClass.Extensions[2].RoofRoom)
      {
        RdSAP_TO_SAP.Extensions ext;
        int num = checked ((ext = this.Ext).E2Storeys + 1);
        ext.E2Storeys = num;
      }
      if (surveyClass.Extensions[3].RoofRoom)
      {
        RdSAP_TO_SAP.Extensions ext;
        int num = checked ((ext = this.Ext).E3Storeys + 1);
        ext.E3Storeys = num;
      }
      if (surveyClass.Extensions[4].RoofRoom)
      {
        RdSAP_TO_SAP.Extensions ext;
        int num = checked ((ext = this.Ext).E4Storeys + 1);
        ext.E4Storeys = num;
      }
      this.Ext.MaxFloors = this.Ext.MStoreys;
      if (this.Ext.MaxFloors < this.Ext.E1Storeys)
        this.Ext.MaxFloors = this.Ext.E1Storeys;
      if (this.Ext.MaxFloors < this.Ext.E2Storeys)
        this.Ext.MaxFloors = this.Ext.E2Storeys;
      if (this.Ext.MaxFloors < this.Ext.E3Storeys)
        this.Ext.MaxFloors = this.Ext.E3Storeys;
      if (this.Ext.MaxFloors < this.Ext.E4Storeys)
        this.Ext.MaxFloors = this.Ext.E4Storeys;
      this.x.MaxStoreys = this.Ext.MaxFloors;
      this.x.Dims = new SAP_Module.Dimensions[checked (this.Ext.MStoreys + this.Ext.E1Storeys + this.Ext.E2Storeys + this.Ext.E3Storeys + this.Ext.E4Storeys - 1 + 1)];
      this.x.NoofFloors = this.x.Dims.Length;
      int num1 = checked (this.Ext.MStoreys - 1);
      int index1 = 0;
      while (index1 <= num1)
      {
        this.x.Dims[index1] = new SAP_Module.Dimensions();
        if (index1 == 0)
        {
          this.x.Dims[index1].Area = (float) surveyClass.Extensions[0].Storey[index1].Area;
          this.x.Dims[index1].Perimeter = (float) surveyClass.Extensions[0].Storey[index1].Perimeter;
          this.x.Dims[index1].Height = (float) surveyClass.Extensions[0].Storey[index1].Height;
          this.x.Dims[index1].Type = 1;
        }
        else if (index1 == checked (this.Ext.MStoreys - 1) & this.Ext.MainRoof)
        {
          this.x.Dims[index1].Area = (float) surveyClass.Extensions[0].RoofRoomFloor_Area;
          this.x.Dims[index1].Height = 2.45f;
          this.x.Dims[index1].Type = 3;
        }
        else
        {
          this.x.Dims[index1].Area = (float) surveyClass.Extensions[0].Storey[index1].Area;
          this.x.Dims[index1].Perimeter = (float) surveyClass.Extensions[0].Storey[index1].Perimeter;
          this.x.Dims[index1].Height = (float) (surveyClass.Extensions[0].Storey[index1].Height + 0.25);
          this.x.Dims[index1].Type = 2;
          if ((double) this.x.Dims[index1].Area > (double) this.x.Dims[checked (index1 - 1)].Area)
          {
            RdSAP_TO_SAP.ExposedFloor exposed;
            double num2 = (exposed = this.Ext.Exposed).A1_M + ((double) this.x.Dims[index1].Area - (double) this.x.Dims[checked (index1 - 1)].Area);
            exposed.A1_M = num2;
          }
        }
        this.x.Dims[index1].Floor = index1;
        checked { ++index1; }
      }
      if (this.Ext.Exposed.A1_M > 0.0)
        this.Ext.Exposed.Include_M = true;
      if (this.Ext.Ext1)
      {
        int mstoreys = this.Ext.MStoreys;
        int num3 = checked (this.Ext.MStoreys + this.Ext.E1Storeys - 1);
        int index2 = mstoreys;
        while (index2 <= num3)
        {
          int index3 = checked (index2 - this.Ext.MStoreys);
          this.x.Dims[index2] = new SAP_Module.Dimensions();
          if (index2 == this.Ext.MStoreys)
          {
            this.x.Dims[index2].Area = (float) surveyClass.Extensions[1].Storey[index3].Area;
            this.x.Dims[index2].Perimeter = (float) surveyClass.Extensions[1].Storey[index3].Perimeter;
            this.x.Dims[index2].Height = (float) surveyClass.Extensions[1].Storey[index3].Height;
            this.x.Dims[index2].Type = 1;
          }
          else if (index2 == checked (this.Ext.MStoreys + this.Ext.E1Storeys - 1) & this.Ext.Ext1Roof)
          {
            this.x.Dims[index2].Area = (float) surveyClass.Extensions[1].RoofRoomFloor_Area;
            this.x.Dims[index2].Height = 2.45f;
            this.x.Dims[index2].Type = 3;
          }
          else
          {
            this.x.Dims[index2].Area = (float) surveyClass.Extensions[1].Storey[index3].Area;
            this.x.Dims[index2].Perimeter = (float) surveyClass.Extensions[1].Storey[index3].Perimeter;
            this.x.Dims[index2].Height = (float) (surveyClass.Extensions[1].Storey[index3].Height + 0.25);
            this.x.Dims[index2].Type = 2;
            if ((double) this.x.Dims[index2].Area > (double) this.x.Dims[checked (index2 - 1)].Area)
            {
              RdSAP_TO_SAP.ExposedFloor exposed;
              double num4 = (exposed = this.Ext.Exposed).A1_E1 + ((double) this.x.Dims[index2].Area - (double) this.x.Dims[checked (index2 - 1)].Area);
              exposed.A1_E1 = num4;
            }
          }
          this.x.Dims[index2].Floor = checked (index2 - this.Ext.MStoreys);
          checked { ++index2; }
        }
        if (this.Ext.Exposed.A1_E1 > 0.0)
          this.Ext.Exposed.Include_E1 = true;
      }
      if (this.Ext.Ext2)
      {
        int num5 = checked (this.Ext.MStoreys + this.Ext.E1Storeys);
        int num6 = checked (this.Ext.MStoreys + this.Ext.E1Storeys + this.Ext.E2Storeys - 1);
        int index4 = num5;
        while (index4 <= num6)
        {
          int index5 = checked (index4 - this.Ext.MStoreys + this.Ext.E1Storeys);
          this.x.Dims[index4] = new SAP_Module.Dimensions();
          if (index4 == checked (this.Ext.MStoreys + this.Ext.E1Storeys))
          {
            this.x.Dims[index4].Area = (float) surveyClass.Extensions[2].Storey[index5].Area;
            this.x.Dims[index4].Perimeter = (float) surveyClass.Extensions[2].Storey[index5].Perimeter;
            this.x.Dims[index4].Height = (float) surveyClass.Extensions[2].Storey[index5].Height;
            this.x.Dims[index4].Type = 1;
          }
          else if (index4 == checked (this.Ext.MStoreys + this.Ext.E1Storeys + this.Ext.E2Storeys - 1) & this.Ext.Ext2Roof)
          {
            this.x.Dims[index4].Area = (float) surveyClass.Extensions[2].RoofRoomFloor_Area;
            this.x.Dims[index4].Height = 2.45f;
            this.x.Dims[index4].Type = 3;
          }
          else
          {
            this.x.Dims[index4].Area = (float) surveyClass.Extensions[2].Storey[index5].Area;
            this.x.Dims[index4].Perimeter = (float) surveyClass.Extensions[2].Storey[index5].Perimeter;
            this.x.Dims[index4].Height = (float) (surveyClass.Extensions[2].Storey[index5].Height + 0.25);
            this.x.Dims[index4].Type = 2;
            if ((double) this.x.Dims[index4].Area > (double) this.x.Dims[checked (index4 - 1)].Area)
            {
              RdSAP_TO_SAP.ExposedFloor exposed;
              double num7 = (exposed = this.Ext.Exposed).A1_E2 + ((double) this.x.Dims[index4].Area - (double) this.x.Dims[checked (index4 - 1)].Area);
              exposed.A1_E2 = num7;
            }
          }
          this.x.Dims[index4].Floor = index5;
          checked { ++index4; }
        }
        if (this.Ext.Exposed.A1_E2 > 0.0)
          this.Ext.Exposed.Include_E2 = true;
      }
      if (this.Ext.Ext3)
      {
        int num8 = checked (this.Ext.MStoreys + this.Ext.E1Storeys + this.Ext.E2Storeys);
        int num9 = checked (this.Ext.MStoreys + this.Ext.E1Storeys + this.Ext.E2Storeys + this.Ext.E3Storeys - 1);
        int index6 = num8;
        while (index6 <= num9)
        {
          int index7 = checked (index6 - this.Ext.MStoreys + this.Ext.E1Storeys + this.Ext.E2Storeys);
          this.x.Dims[index6] = new SAP_Module.Dimensions();
          if (index6 == checked (this.Ext.MStoreys + this.Ext.E1Storeys + this.Ext.E2Storeys))
          {
            this.x.Dims[index6].Area = (float) surveyClass.Extensions[3].Storey[index7].Area;
            this.x.Dims[index6].Perimeter = (float) surveyClass.Extensions[3].Storey[index7].Perimeter;
            this.x.Dims[index6].Height = (float) surveyClass.Extensions[3].Storey[index7].Height;
            this.x.Dims[index6].Type = 1;
          }
          else if (index6 == checked (this.Ext.MStoreys + this.Ext.E1Storeys + this.Ext.E2Storeys + this.Ext.E3Storeys - 1) & this.Ext.Ext3Roof)
          {
            this.x.Dims[index6].Area = (float) surveyClass.Extensions[3].RoofRoomFloor_Area;
            this.x.Dims[index6].Height = 2.45f;
            this.x.Dims[index6].Type = 3;
          }
          else
          {
            this.x.Dims[index6].Area = (float) surveyClass.Extensions[3].Storey[index7].Area;
            this.x.Dims[index6].Perimeter = (float) surveyClass.Extensions[3].Storey[index7].Perimeter;
            this.x.Dims[index6].Height = (float) (surveyClass.Extensions[3].Storey[index7].Height + 0.25);
            this.x.Dims[index6].Type = 2;
            if ((double) this.x.Dims[index6].Area > (double) this.x.Dims[checked (index6 - 1)].Area)
            {
              RdSAP_TO_SAP.ExposedFloor exposed;
              double num10 = (exposed = this.Ext.Exposed).A1_E3 + ((double) this.x.Dims[index6].Area - (double) this.x.Dims[checked (index6 - 1)].Area);
              exposed.A1_E3 = num10;
            }
          }
          this.x.Dims[index6].Floor = checked (index6 - this.Ext.MStoreys + this.Ext.E1Storeys + this.Ext.E2Storeys);
          checked { ++index6; }
        }
        if (this.Ext.Exposed.A1_E3 > 0.0)
          this.Ext.Exposed.Include_E3 = true;
      }
      if (this.Ext.Ext4)
      {
        int num11 = checked (this.Ext.MStoreys + this.Ext.E1Storeys + this.Ext.E2Storeys + this.Ext.E3Storeys);
        int num12 = checked (this.Ext.MStoreys + this.Ext.E1Storeys + this.Ext.E2Storeys + this.Ext.E3Storeys + this.Ext.E4Storeys - 1);
        int index8 = num11;
        while (index8 <= num12)
        {
          this.x.Dims[index8] = new SAP_Module.Dimensions();
          int index9 = checked (index8 - this.Ext.MStoreys + this.Ext.E1Storeys + this.Ext.E2Storeys + this.Ext.E3Storeys);
          if (index8 == checked (this.Ext.MStoreys + this.Ext.E1Storeys + this.Ext.E2Storeys + this.Ext.E3Storeys))
          {
            this.x.Dims[index8].Area = (float) surveyClass.Extensions[4].Storey[index9].Area;
            this.x.Dims[index8].Perimeter = (float) surveyClass.Extensions[4].Storey[index9].Perimeter;
            this.x.Dims[index8].Height = (float) surveyClass.Extensions[4].Storey[index9].Height;
            this.x.Dims[index8].Type = 1;
          }
          else if (index8 == checked (this.Ext.MStoreys + this.Ext.E1Storeys + this.Ext.E2Storeys + this.Ext.E3Storeys + this.Ext.E4Storeys - 1) & this.Ext.Ext4Roof)
          {
            this.x.Dims[index8].Area = (float) surveyClass.Extensions[4].RoofRoomFloor_Area;
            this.x.Dims[index8].Height = 2.45f;
            this.x.Dims[index8].Type = 3;
          }
          else
          {
            this.x.Dims[index8].Area = (float) surveyClass.Extensions[4].Storey[index9].Area;
            this.x.Dims[index8].Perimeter = (float) surveyClass.Extensions[4].Storey[index9].Perimeter;
            this.x.Dims[index8].Height = (float) (surveyClass.Extensions[4].Storey[index9].Height + 0.25);
            this.x.Dims[index8].Type = 2;
            if ((double) this.x.Dims[index8].Area > (double) this.x.Dims[checked (index8 - 1)].Area)
            {
              RdSAP_TO_SAP.ExposedFloor exposed;
              double num13 = (exposed = this.Ext.Exposed).A1_E4 + ((double) this.x.Dims[index8].Area - (double) this.x.Dims[checked (index8 - 1)].Area);
              exposed.A1_E4 = num13;
            }
          }
          this.x.Dims[index8].Floor = checked (index8 - this.Ext.MStoreys + this.Ext.E1Storeys + this.Ext.E2Storeys + this.Ext.E3Storeys);
          checked { ++index8; }
        }
        if (this.Ext.Exposed.A1_E4 > 0.0)
          this.Ext.Exposed.Include_E4 = true;
      }
      if (surveyClass.Age.DimType != 2)
      {
        this.Ext.WallThickness.M = !surveyClass.Extensions[0].WallThicknessMeasured ? (double) this.GetWallThickNess(RdSAP, 0, false) : surveyClass.Extensions[0].WallThickness / 1000.0;
        int num14 = checked (this.Ext.MaxFloors - 1);
        int num15 = 0;
        while (num15 <= num14)
        {
          double num16 = 0.0;
          double num17 = 0.0;
          int num18 = checked (this.x.NoofFloors - 1);
          int index10 = 0;
          while (index10 <= num18)
          {
            if (this.x.Dims[index10].Type != 3 & this.x.Dims[index10].Floor == num15)
            {
              num16 += (double) this.x.Dims[index10].Perimeter;
              num17 += (double) this.x.Dims[index10].Area;
            }
            checked { ++index10; }
          }
          double num19;
          double num20;
          switch (surveyClass.General.PropertyType2)
          {
            case 1:
              num19 = num16 - 8.0 * this.Ext.WallThickness.M;
              num20 = num17 - this.Ext.WallThickness.M * num19 - 4.0 * this.Ext.WallThickness.M * this.Ext.WallThickness.M;
              break;
            case 2:
            case 3:
              if (num16 * num16 > 8.0 * num17)
              {
                num19 = num16 - 5.0 * this.Ext.WallThickness.M;
                double num21 = 0.5 * (num16 - Math.Sqrt(num16 * num16 - 8.0 * num17));
                num20 = num17 - this.Ext.WallThickness.M * (num16 + 0.5 * num21) + 3.0 * this.Ext.WallThickness.M * this.Ext.WallThickness.M;
                break;
              }
              num19 = num16 - 3.0 * this.Ext.WallThickness.M;
              num20 = num17 - this.Ext.WallThickness.M * num16 + 3.0 * this.Ext.WallThickness.M * this.Ext.WallThickness.M;
              break;
            case 4:
              num19 = num16 - 2.0 * this.Ext.WallThickness.M;
              num20 = num17 - this.Ext.WallThickness.M * (num16 + 2.0 * (num17 / num16)) + 2.0 * this.Ext.WallThickness.M * this.Ext.WallThickness.M;
              break;
            case 5:
              num19 = num16 - 3.0 * this.Ext.WallThickness.M;
              num20 = num17 - 1.5 * this.Ext.WallThickness.M * num16 + 2.25 * this.Ext.WallThickness.M * this.Ext.WallThickness.M;
              break;
            case 6:
              num19 = num16 - this.Ext.WallThickness.M;
              num20 = num17 - this.Ext.WallThickness.M * (num17 / num16 + 1.5 * num16) + 1.5 * this.Ext.WallThickness.M * this.Ext.WallThickness.M;
              break;
          }
          double num22 = num19 / num16;
          double num23 = num20 / num17;
          int num24 = checked (this.x.NoofFloors - 1);
          int index11 = 0;
          while (index11 <= num24)
          {
            if (this.x.Dims[index11].Type != 3 & this.x.Dims[index11].Floor == num15)
            {
              // ISSUE: variable of a reference type
              float& local1;
              // ISSUE: explicit reference operation
              double num25 = (double) (^(local1 = ref this.x.Dims[index11].Perimeter) * (float) num22);
              local1 = (float) num25;
              // ISSUE: variable of a reference type
              float& local2;
              // ISSUE: explicit reference operation
              double num26 = (double) (^(local2 = ref this.x.Dims[index11].Area) * (float) num23);
              local2 = (float) num26;
            }
            checked { ++index11; }
          }
          checked { ++num15; }
        }
        if (this.Ext.Exposed.Include_M)
        {
          int num27 = checked (this.Ext.MStoreys - 1);
          int index12 = 0;
          while (index12 <= num27)
          {
            if (index12 != 0 && !(index12 == checked (this.Ext.MStoreys - 1) & this.Ext.MainRoof) && (double) this.x.Dims[index12].Area > (double) this.x.Dims[checked (index12 - 1)].Area)
            {
              RdSAP_TO_SAP.ExposedFloor exposed;
              double num28 = (exposed = this.Ext.Exposed).A2_M + ((double) this.x.Dims[index12].Area - (double) this.x.Dims[checked (index12 - 1)].Area);
              exposed.A2_M = num28;
            }
            checked { ++index12; }
          }
        }
        if (this.Ext.Ext1 & this.Ext.Exposed.Include_E1)
        {
          int mstoreys = this.Ext.MStoreys;
          int num29 = checked (this.Ext.MStoreys + this.Ext.E1Storeys - 1);
          int index13 = mstoreys;
          while (index13 <= num29)
          {
            if (index13 != this.Ext.MStoreys && !(index13 == checked (this.Ext.MStoreys + this.Ext.E1Storeys - 1) & this.Ext.Ext1Roof) && (double) this.x.Dims[index13].Area > (double) this.x.Dims[checked (index13 - 1)].Area)
            {
              RdSAP_TO_SAP.ExposedFloor exposed;
              double num30 = (exposed = this.Ext.Exposed).A2_E1 + ((double) this.x.Dims[index13].Area - (double) this.x.Dims[checked (index13 - 1)].Area);
              exposed.A2_E1 = num30;
            }
            checked { ++index13; }
          }
        }
        if (this.Ext.Ext2 & this.Ext.Exposed.Include_E2)
        {
          int num31 = checked (this.Ext.MStoreys + this.Ext.E1Storeys);
          int num32 = checked (this.Ext.MStoreys + this.Ext.E1Storeys + this.Ext.E2Storeys - 1);
          int index14 = num31;
          while (index14 <= num32)
          {
            if (index14 != checked (this.Ext.MStoreys + this.Ext.E1Storeys) && !(index14 == checked (this.Ext.MStoreys + this.Ext.E1Storeys + this.Ext.E2Storeys - 1) & this.Ext.Ext2Roof) && (double) this.x.Dims[index14].Area > (double) this.x.Dims[checked (index14 - 1)].Area)
            {
              RdSAP_TO_SAP.ExposedFloor exposed;
              double num33 = (exposed = this.Ext.Exposed).A2_E2 + ((double) this.x.Dims[index14].Area - (double) this.x.Dims[checked (index14 - 1)].Area);
              exposed.A2_E2 = num33;
            }
            checked { ++index14; }
          }
        }
        if (this.Ext.Ext3 & this.Ext.Exposed.Include_E3)
        {
          int num34 = checked (this.Ext.MStoreys + this.Ext.E1Storeys + this.Ext.E2Storeys);
          int num35 = checked (this.Ext.MStoreys + this.Ext.E1Storeys + this.Ext.E2Storeys + this.Ext.E3Storeys - 1);
          int index15 = num34;
          while (index15 <= num35)
          {
            if (index15 != checked (this.Ext.MStoreys + this.Ext.E1Storeys + this.Ext.E2Storeys) && !(index15 == checked (this.Ext.MStoreys + this.Ext.E1Storeys + this.Ext.E2Storeys + this.Ext.E3Storeys - 1) & this.Ext.Ext3Roof) && (double) this.x.Dims[index15].Area > (double) this.x.Dims[checked (index15 - 1)].Area)
            {
              RdSAP_TO_SAP.ExposedFloor exposed;
              double num36 = (exposed = this.Ext.Exposed).A2_E3 + ((double) this.x.Dims[index15].Area - (double) this.x.Dims[checked (index15 - 1)].Area);
              exposed.A2_E3 = num36;
            }
            checked { ++index15; }
          }
        }
        if (this.Ext.Ext4 & this.Ext.Exposed.Include_E4)
        {
          int num37 = checked (this.Ext.MStoreys + this.Ext.E1Storeys + this.Ext.E2Storeys + this.Ext.E3Storeys);
          int num38 = checked (this.Ext.MStoreys + this.Ext.E1Storeys + this.Ext.E2Storeys + this.Ext.E3Storeys + this.Ext.E4Storeys - 1);
          int index16 = num37;
          while (index16 <= num38)
          {
            if (index16 != checked (this.Ext.MStoreys + this.Ext.E1Storeys + this.Ext.E2Storeys) && !(index16 == checked (this.Ext.MStoreys + this.Ext.E1Storeys + this.Ext.E2Storeys + this.Ext.E3Storeys + this.Ext.E4Storeys - 1) & this.Ext.Ext4Roof) && (double) this.x.Dims[index16].Area > (double) this.x.Dims[checked (index16 - 1)].Area)
            {
              RdSAP_TO_SAP.ExposedFloor exposed;
              double num39 = (exposed = this.Ext.Exposed).A2_E4 + ((double) this.x.Dims[index16].Area - (double) this.x.Dims[checked (index16 - 1)].Area);
              exposed.A2_E4 = num39;
            }
            checked { ++index16; }
          }
        }
      }
      if (this.Ext.Cons)
      {
        // ISSUE: variable of a reference type
        SAP_Module.Dimensions[]& local;
        // ISSUE: explicit reference operation
        SAP_Module.Dimensions[] dimensionsArray = (SAP_Module.Dimensions[]) Utils.CopyArray((Array) ^(local = ref this.x.Dims), (Array) new SAP_Module.Dimensions[checked (this.x.Dims.Length + 1)]);
        local = dimensionsArray;
        this.x.Dims[checked (this.x.Dims.Length - 1)] = new SAP_Module.Dimensions();
        this.x.Dims[checked (this.x.Dims.Length - 1)].Area = (float) surveyClass.Conservatory.FloorArea;
        this.x.Dims[checked (this.x.Dims.Length - 1)].Perimeter = (float) surveyClass.Conservatory.GlazedPerimeter;
        switch (surveyClass.Conservatory.RoomHeight)
        {
          case 1:
            this.x.Dims[checked (this.x.Dims.Length - 1)].Height = (float) Math.Round(surveyClass.Extensions[0].Storey[0].Height, 2);
            break;
          case 2:
            this.x.Dims[checked (this.x.Dims.Length - 1)].Height = (float) (Math.Round(surveyClass.Extensions[0].Storey[0].Height, 2) + 0.25 + 0.5 * Math.Round(surveyClass.Extensions[0].Storey[1].Height, 2));
            break;
          case 3:
            this.x.Dims[checked (this.x.Dims.Length - 1)].Height = (float) (Math.Round(surveyClass.Extensions[0].Storey[0].Height, 2) + 0.25 + Math.Round(surveyClass.Extensions[0].Storey[1].Height, 2));
            break;
          case 4:
            this.x.Dims[checked (this.x.Dims.Length - 1)].Height = (float) (Math.Round(surveyClass.Extensions[0].Storey[0].Height, 2) + 0.25 + Math.Round(surveyClass.Extensions[0].Storey[1].Height, 2) + 0.5 * Math.Round(surveyClass.Extensions[0].Storey[2].Height, 2));
            break;
        }
      }
      this.x.Storeys = this.x.Dims.Length;
    }

    private void OpaqueElements(Survey_Class RdSAP)
    {
      Survey_Class surveyClass = RdSAP;
      string mage = this.Ext.Ages.MAge;
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
            break;
          goto default;
        case 3440116983:
          if (Operators.CompareString(mage, "H", false) == 0)
            break;
          goto default;
        case 3456894602:
          if (Operators.CompareString(mage, "K", false) == 0)
          {
            this.x.Thermal.YValue = 0.08f;
            goto default;
          }
          else
            goto default;
        case 3473672221:
          if (Operators.CompareString(mage, "J", false) == 0)
          {
            this.x.Thermal.YValue = 0.11f;
            goto default;
          }
          else
            goto default;
        default:
label_15:
          this.x.Thermal.ManualHtb = false;
          this.x.Thermal.ManualY = true;
          this.x.Thermal.HtbValue = 0.0f;
          this.x.Thermal.Reference = nameof (RdSAP);
          this.Floors(RdSAP);
          this.Walls(RdSAP);
          this.Roofs(RdSAP);
          surveyClass = (Survey_Class) null;
          return;
      }
      this.x.Thermal.YValue = 0.15f;
      goto label_15;
    }

    private void Floors(Survey_Class RdSAP)
    {
      Survey_Class surveyClass = RdSAP;
      float num1;
      if (surveyClass.Extensions[0].LowestFloor == 5)
      {
        this.x.Floors = new SAP_Module.Opaques[1];
        this.x.Floors[0] = new SAP_Module.Opaques();
        if (surveyClass.General.Country == 4)
        {
          string mage = this.Ext.Ages.MAge;
          // ISSUE: reference to a compiler-generated method
          switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(mage))
          {
            case 3222007936:
              if (Operators.CompareString(mage, "E", false) == 0)
                break;
              goto label_54;
            case 3238785555:
              if (Operators.CompareString(mage, "D", false) == 0)
                break;
              goto label_54;
            case 3255563174:
              if (Operators.CompareString(mage, "G", false) == 0)
                break;
              goto label_54;
            case 3272340793:
              if (Operators.CompareString(mage, "F", false) == 0)
                break;
              goto label_54;
            case 3289118412:
              if (Operators.CompareString(mage, "A", false) == 0)
                break;
              goto label_54;
            case 3322673650:
              if (Operators.CompareString(mage, "C", false) == 0)
                break;
              goto label_54;
            case 3339451269:
              if (Operators.CompareString(mage, "B", false) == 0)
                break;
              goto label_54;
            case 3423339364:
              if (Operators.CompareString(mage, "I", false) == 0)
              {
                num1 = 0.05f;
                goto label_54;
              }
              else
                goto label_54;
            case 3440116983:
              if (Operators.CompareString(mage, "H", false) == 0)
              {
                num1 = 0.025f;
                goto label_54;
              }
              else
                goto label_54;
            case 3456894602:
              if (Operators.CompareString(mage, "K", false) == 0)
              {
                num1 = 0.1f;
                goto label_54;
              }
              else
                goto label_54;
            case 3473672221:
              if (Operators.CompareString(mage, "J", false) == 0)
              {
                num1 = 0.0f;
                goto label_54;
              }
              else
                goto label_54;
            default:
              goto label_54;
          }
          num1 = 0.0f;
        }
        else if (surveyClass.General.Country == 3)
        {
          string mage = this.Ext.Ages.MAge;
          // ISSUE: reference to a compiler-generated method
          switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(mage))
          {
            case 3222007936:
              if (Operators.CompareString(mage, "E", false) == 0)
                break;
              goto label_54;
            case 3238785555:
              if (Operators.CompareString(mage, "D", false) == 0)
                break;
              goto label_54;
            case 3255563174:
              if (Operators.CompareString(mage, "G", false) == 0)
                break;
              goto label_54;
            case 3272340793:
              if (Operators.CompareString(mage, "F", false) == 0)
                break;
              goto label_54;
            case 3289118412:
              if (Operators.CompareString(mage, "A", false) == 0)
                break;
              goto label_54;
            case 3322673650:
              if (Operators.CompareString(mage, "C", false) == 0)
                break;
              goto label_54;
            case 3339451269:
              if (Operators.CompareString(mage, "B", false) == 0)
                break;
              goto label_54;
            case 3423339364:
              if (Operators.CompareString(mage, "I", false) == 0)
              {
                num1 = 0.05f;
                goto label_54;
              }
              else
                goto label_54;
            case 3440116983:
              if (Operators.CompareString(mage, "H", false) == 0)
              {
                num1 = 0.025f;
                goto label_54;
              }
              else
                goto label_54;
            case 3456894602:
              if (Operators.CompareString(mage, "K", false) == 0)
              {
                num1 = 0.1f;
                goto label_54;
              }
              else
                goto label_54;
            case 3473672221:
              if (Operators.CompareString(mage, "J", false) == 0)
              {
                num1 = 0.075f;
                goto label_54;
              }
              else
                goto label_54;
            default:
              goto label_54;
          }
          num1 = 0.0f;
        }
        else
        {
          string mage = this.Ext.Ages.MAge;
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
label_53:
              goto label_54;
          }
          num1 = 0.0f;
          goto label_53;
        }
label_54:
        if (surveyClass.Extensions[0].FloorInsulation == 3)
        {
          switch (surveyClass.Extensions[0].FloorInsulationThickness)
          {
            case 1:
              if ((double) num1 < 0.05)
              {
                num1 = 0.05f;
                break;
              }
              break;
            case 2:
              num1 = 0.05f;
              break;
            case 3:
              num1 = 0.1f;
              break;
            case 4:
              num1 = 0.15f;
              break;
          }
        }
        float num2 = 2f * this.x.Dims[0].Area / this.x.Dims[0].Perimeter;
        this.Ext.WallThickness.M = !surveyClass.Extensions[0].WallThicknessMeasured ? (double) this.GetWallThickNess(RdSAP, 0, false) : surveyClass.Extensions[0].WallThickness / 1000.0;
        if (surveyClass.Extensions[0].FloorConstruction == 1)
        {
          string mage = this.Ext.Ages.MAge;
          if (Operators.CompareString(mage, "A", false) == 0 || Operators.CompareString(mage, "B", false) == 0)
          {
            float num3 = (float) (this.Ext.WallThickness.M + 0.315);
            this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = (float) Math.Round(1.0 / (0.54 + 1.0 / (3.0 * Math.Log(Math.PI * (double) num2 / (double) num3 + 1.0) / (Math.PI * (double) num2 + (double) num3) + (9.0 / 10.0 / (double) num2 + 87.0 / 80.0 / (double) num2))), 2);
          }
          else
          {
            float num4 = (float) (this.Ext.WallThickness.M + 1.5 * (0.17 + (double) num1 / 0.035 + 0.04));
            this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = (double) num4 >= (double) num2 ? (float) Math.Round(1.5 / (0.457 * (double) num2 + (double) num4), 2) : (float) Math.Round(3.0 * Math.Log(Math.PI * (double) num2 / (double) num4 + 1.0) / (Math.PI * (double) num2 + (double) num4), 2);
          }
        }
        else if (surveyClass.Extensions[0].FloorConstruction == 3 | surveyClass.Extensions[0].FloorConstruction == 4)
        {
          float num5 = (float) (this.Ext.WallThickness.M + 0.315);
          float num6 = (float) (3.0 * Math.Log(Math.PI * (double) num2 / (double) num5 + 1.0) / (Math.PI * (double) num2 + (double) num5));
          float num7 = (float) (9.0 / 10.0 / (double) num2 + 87.0 / 80.0 / (double) num2);
          this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = (float) Math.Round(1.0 / (0.34 + (double) num1 / 0.035 + 0.2 + 1.0 / ((double) num6 + (double) num7)), 2);
        }
        else if (surveyClass.Extensions[0].FloorConstruction == 2)
        {
          float num8 = (float) (this.Ext.WallThickness.M + 1.5 * (0.17 + (double) num1 / 0.035 + 0.04));
          this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = (double) num8 >= (double) num2 ? (float) Math.Round(1.5 / (0.457 * (double) num2 + (double) num8), 2) : (float) Math.Round(3.0 * Math.Log(Math.PI * (double) num2 / (double) num8 + 1.0) / (Math.PI * (double) num2 + (double) num8), 2);
        }
        this.x.Floors[checked (this.x.Floors.Length - 1)].Name = "Main Ground Floor";
        this.x.Floors[checked (this.x.Floors.Length - 1)].Type = "Ground floor";
        this.x.Floors[checked (this.x.Floors.Length - 1)].Area = (float) Math.Round((double) this.x.Dims[0].Area, 2);
      }
      else if (surveyClass.Extensions[0].LowestFloor == 3)
      {
        this.x.Floors = new SAP_Module.Opaques[1];
        this.x.Floors[0] = new SAP_Module.Opaques();
        this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = 0.7f;
        this.x.Floors[checked (this.x.Floors.Length - 1)].Name = "Main Floor";
        this.x.Floors[checked (this.x.Floors.Length - 1)].Type = "Exposed floor";
        this.x.Floors[checked (this.x.Floors.Length - 1)].Area = (float) Math.Round((double) this.x.Dims[0].Area, 2);
      }
      else if (surveyClass.Extensions[0].LowestFloor == 2 | surveyClass.Extensions[0].LowestFloor == 1 | surveyClass.Extensions[0].LowestFloor == 7)
      {
        this.x.Floors = new SAP_Module.Opaques[1];
        if (surveyClass.Extensions[0].FloorInsulation == 1 | surveyClass.Extensions[0].FloorInsulation == 2)
        {
          this.x.Floors[0] = new SAP_Module.Opaques();
          string mage = this.Ext.Ages.MAge;
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
                goto label_88;
              else
                goto default;
            case 3440116983:
              if (Operators.CompareString(mage, "H", false) == 0)
                goto label_88;
              else
                goto default;
            case 3456894602:
              if (Operators.CompareString(mage, "K", false) == 0)
              {
                this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = 0.22f;
                goto default;
              }
              else
                goto default;
            case 3473672221:
              if (Operators.CompareString(mage, "J", false) == 0)
              {
                this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = 0.25f;
                goto default;
              }
              else
                goto default;
            default:
label_91:
              goto label_92;
          }
          this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = 1.2f;
          goto label_91;
label_88:
          this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = 0.51f;
          goto label_91;
        }
label_92:
        if (surveyClass.Extensions[0].FloorInsulation == 3)
        {
          this.x.Floors[0] = new SAP_Module.Opaques();
          string mage = this.Ext.Ages.MAge;
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
                goto label_106;
              else
                goto default;
            case 3440116983:
              if (Operators.CompareString(mage, "H", false) == 0)
                goto label_106;
              else
                goto default;
            case 3456894602:
              if (Operators.CompareString(mage, "K", false) == 0)
              {
                this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = 0.22f;
                goto default;
              }
              else
                goto default;
            case 3473672221:
              if (Operators.CompareString(mage, "J", false) == 0)
              {
                this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = 0.25f;
                goto default;
              }
              else
                goto default;
            default:
label_109:
              goto label_110;
          }
          this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = 0.5f;
          goto label_109;
label_106:
          this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = 0.5f;
          goto label_109;
        }
label_110:
        this.x.Floors[checked (this.x.Floors.Length - 1)].Name = "Main Floor";
        this.x.Floors[checked (this.x.Floors.Length - 1)].Type = surveyClass.Extensions[0].LowestFloor != 7 ? "Exposed floor" : "To External Air";
        this.x.Floors[checked (this.x.Floors.Length - 1)].Area = (float) Math.Round((double) this.x.Dims[0].Area, 2);
      }
      else if (surveyClass.Extensions[0].LowestFloor == 4)
      {
        if (this.Ext.EPCFloors == null)
        {
          RdSAP_TO_SAP.Extensions ext;
          RdSAP_TO_SAP.EPCFloors[] epcFloorsArray = (RdSAP_TO_SAP.EPCFloors[]) Utils.CopyArray((Array) (ext = this.Ext).EPCFloors, (Array) new RdSAP_TO_SAP.EPCFloors[1]);
          ext.EPCFloors = epcFloorsArray;
          this.Ext.EPCFloors[0] = new RdSAP_TO_SAP.EPCFloors();
        }
        else
        {
          RdSAP_TO_SAP.Extensions ext;
          RdSAP_TO_SAP.EPCFloors[] epcFloorsArray = (RdSAP_TO_SAP.EPCFloors[]) Utils.CopyArray((Array) (ext = this.Ext).EPCFloors, (Array) new RdSAP_TO_SAP.EPCFloors[checked (this.Ext.EPCFloors.Length + 1)]);
          ext.EPCFloors = epcFloorsArray;
          this.Ext.EPCFloors[checked (this.Ext.EPCFloors.Length - 1)] = new RdSAP_TO_SAP.EPCFloors();
        }
        this.Ext.EPCFloors[checked (this.Ext.EPCFloors.Length - 1)].Area = (float) Math.Round((double) this.x.Dims[0].Area, 2);
        this.Ext.EPCFloors[checked (this.Ext.EPCFloors.Length - 1)].Desc = "(other premises below)";
        this.Ext.EPCFloors[checked (this.Ext.EPCFloors.Length - 1)].Ext = 0;
        surveyClass.Extensions[0].FloorUValueKnown = false;
      }
      else if (surveyClass.Extensions[0].LowestFloor == 6)
      {
        if (this.Ext.EPCFloors == null)
        {
          RdSAP_TO_SAP.Extensions ext;
          RdSAP_TO_SAP.EPCFloors[] epcFloorsArray = (RdSAP_TO_SAP.EPCFloors[]) Utils.CopyArray((Array) (ext = this.Ext).EPCFloors, (Array) new RdSAP_TO_SAP.EPCFloors[1]);
          ext.EPCFloors = epcFloorsArray;
          this.Ext.EPCFloors[0] = new RdSAP_TO_SAP.EPCFloors();
        }
        else
        {
          RdSAP_TO_SAP.Extensions ext;
          RdSAP_TO_SAP.EPCFloors[] epcFloorsArray = (RdSAP_TO_SAP.EPCFloors[]) Utils.CopyArray((Array) (ext = this.Ext).EPCFloors, (Array) new RdSAP_TO_SAP.EPCFloors[checked (this.Ext.EPCFloors.Length + 1)]);
          ext.EPCFloors = epcFloorsArray;
          this.Ext.EPCFloors[checked (this.Ext.EPCFloors.Length - 1)] = new RdSAP_TO_SAP.EPCFloors();
        }
        this.Ext.EPCFloors[checked (this.Ext.EPCFloors.Length - 1)].Area = (float) Math.Round((double) this.x.Dims[0].Area, 2);
        this.Ext.EPCFloors[checked (this.Ext.EPCFloors.Length - 1)].Desc = "(Same dwelling below)";
        this.Ext.EPCFloors[checked (this.Ext.EPCFloors.Length - 1)].Ext = 0;
        surveyClass.Extensions[0].FloorUValueKnown = false;
      }
      if (surveyClass.Extensions[0].FloorUValueKnown)
      {
        if (this.x.Floors == null)
          throw new Exception("Floor U-value specified incorrectly");
        this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = (float) surveyClass.Extensions[0].FloorUValue;
      }
      if (this.x.Floors != null && string.IsNullOrEmpty(this.x.Floors[checked (this.x.Floors.Length - 1)].EPCDesc))
        this.x.Floors[checked (this.x.Floors.Length - 1)].EPCDesc = SAP_Module.Get_Enum_Desc(typeof (Enums.FloorConstructionCode), surveyClass.Extensions[0].FloorConstruction) + ", " + SAP_Module.Get_Enum_Desc(typeof (Enums.FloorInsulationCode), surveyClass.Extensions[0].FloorInsulation) + SAP_Module.Get_Enum_Desc(typeof (Enums.LowestFloorType), surveyClass.Extensions[0].LowestFloor);
      if (surveyClass.Extensions[0].FloorConstruction == 1 && this.x.Floors != null)
        this.x.Floors[checked (this.x.Floors.Length - 1)].Construction = SAP_Module.Get_Enum_Desc(typeof (Enums.FloorConstructionCode), surveyClass.Extensions[0].FloorConstruction);
      if (this.Ext.Exposed.Include_M)
      {
        if (this.x.Floors != null)
        {
          // ISSUE: variable of a reference type
          SAP_Module.Opaques[]& local;
          // ISSUE: explicit reference operation
          SAP_Module.Opaques[] opaquesArray = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local = ref this.x.Floors), (Array) new SAP_Module.Opaques[checked (this.x.Floors.Length + 1)]);
          local = opaquesArray;
        }
        else
        {
          // ISSUE: variable of a reference type
          SAP_Module.Opaques[]& local;
          // ISSUE: explicit reference operation
          SAP_Module.Opaques[] opaquesArray = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local = ref this.x.Floors), (Array) new SAP_Module.Opaques[1]);
          local = opaquesArray;
        }
        this.x.Floors[checked (this.x.Floors.Length - 1)] = new SAP_Module.Opaques();
        if (surveyClass.Extensions[0].FloorInsulation == 1 | surveyClass.Extensions[0].FloorInsulation == 2)
        {
          string mage = this.Ext.Ages.MAge;
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
                goto label_147;
              else
                goto default;
            case 3440116983:
              if (Operators.CompareString(mage, "H", false) == 0)
                goto label_147;
              else
                goto default;
            case 3456894602:
              if (Operators.CompareString(mage, "K", false) == 0)
              {
                this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = 0.22f;
                goto default;
              }
              else
                goto default;
            case 3473672221:
              if (Operators.CompareString(mage, "J", false) == 0)
              {
                this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = 0.25f;
                goto default;
              }
              else
                goto default;
            default:
label_150:
              goto label_151;
          }
          this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = 1.2f;
          goto label_150;
label_147:
          this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = 0.51f;
          goto label_150;
        }
label_151:
        if (surveyClass.Extensions[0].FloorInsulation == 3)
        {
          string mage = this.Ext.Ages.MAge;
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
                goto label_165;
              else
                goto default;
            case 3440116983:
              if (Operators.CompareString(mage, "H", false) == 0)
                goto label_165;
              else
                goto default;
            case 3456894602:
              if (Operators.CompareString(mage, "K", false) == 0)
              {
                this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = 0.22f;
                goto default;
              }
              else
                goto default;
            case 3473672221:
              if (Operators.CompareString(mage, "J", false) == 0)
              {
                this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = 0.25f;
                goto default;
              }
              else
                goto default;
            default:
label_168:
              goto label_169;
          }
          this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = 0.5f;
          goto label_168;
label_165:
          this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = 0.5f;
          goto label_168;
        }
label_169:
        this.x.Floors[checked (this.x.Floors.Length - 1)].Name = "Overhangs";
        this.x.Floors[checked (this.x.Floors.Length - 1)].Type = "Exposed floor";
        this.x.Floors[checked (this.x.Floors.Length - 1)].Area = !(this.Ext.Exposed.A2_M < this.Ext.Exposed.A1_M & this.Ext.Exposed.A2_M != 0.0) ? (float) Math.Round(this.Ext.Exposed.A1_M, 2) : (float) Math.Round(this.Ext.Exposed.A2_M, 2);
      }
      if (this.Ext.Ext1)
      {
        if (surveyClass.Extensions[1].LowestFloor == 5)
        {
          if (this.x.Floors != null)
          {
            // ISSUE: variable of a reference type
            SAP_Module.Opaques[]& local;
            // ISSUE: explicit reference operation
            SAP_Module.Opaques[] opaquesArray = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local = ref this.x.Floors), (Array) new SAP_Module.Opaques[checked (this.x.Floors.Length + 1)]);
            local = opaquesArray;
          }
          else
          {
            // ISSUE: variable of a reference type
            SAP_Module.Opaques[]& local;
            // ISSUE: explicit reference operation
            SAP_Module.Opaques[] opaquesArray = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local = ref this.x.Floors), (Array) new SAP_Module.Opaques[1]);
            local = opaquesArray;
          }
          this.x.Floors[checked (this.x.Floors.Length - 1)] = new SAP_Module.Opaques();
          if (surveyClass.General.Country == 4)
          {
            string e1Age = this.Ext.Ages.E1Age;
            // ISSUE: reference to a compiler-generated method
            switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(e1Age))
            {
              case 3222007936:
                if (Operators.CompareString(e1Age, "E", false) == 0)
                  break;
                goto label_228;
              case 3238785555:
                if (Operators.CompareString(e1Age, "D", false) == 0)
                  break;
                goto label_228;
              case 3255563174:
                if (Operators.CompareString(e1Age, "G", false) == 0)
                  break;
                goto label_228;
              case 3272340793:
                if (Operators.CompareString(e1Age, "F", false) == 0)
                  break;
                goto label_228;
              case 3289118412:
                if (Operators.CompareString(e1Age, "A", false) == 0)
                  break;
                goto label_228;
              case 3322673650:
                if (Operators.CompareString(e1Age, "C", false) == 0)
                  break;
                goto label_228;
              case 3339451269:
                if (Operators.CompareString(e1Age, "B", false) == 0)
                  break;
                goto label_228;
              case 3423339364:
                if (Operators.CompareString(e1Age, "I", false) == 0)
                {
                  num1 = 0.05f;
                  goto label_228;
                }
                else
                  goto label_228;
              case 3440116983:
                if (Operators.CompareString(e1Age, "H", false) == 0)
                {
                  num1 = 0.025f;
                  goto label_228;
                }
                else
                  goto label_228;
              case 3456894602:
                if (Operators.CompareString(e1Age, "K", false) == 0)
                {
                  num1 = 0.1f;
                  goto label_228;
                }
                else
                  goto label_228;
              case 3473672221:
                if (Operators.CompareString(e1Age, "J", false) == 0)
                {
                  num1 = 0.0f;
                  goto label_228;
                }
                else
                  goto label_228;
              default:
                goto label_228;
            }
            num1 = 0.0f;
          }
          else if (surveyClass.General.Country == 3)
          {
            string e1Age = this.Ext.Ages.E1Age;
            // ISSUE: reference to a compiler-generated method
            switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(e1Age))
            {
              case 3222007936:
                if (Operators.CompareString(e1Age, "E", false) == 0)
                  break;
                goto label_228;
              case 3238785555:
                if (Operators.CompareString(e1Age, "D", false) == 0)
                  break;
                goto label_228;
              case 3255563174:
                if (Operators.CompareString(e1Age, "G", false) == 0)
                  break;
                goto label_228;
              case 3272340793:
                if (Operators.CompareString(e1Age, "F", false) == 0)
                  break;
                goto label_228;
              case 3289118412:
                if (Operators.CompareString(e1Age, "A", false) == 0)
                  break;
                goto label_228;
              case 3322673650:
                if (Operators.CompareString(e1Age, "C", false) == 0)
                  break;
                goto label_228;
              case 3339451269:
                if (Operators.CompareString(e1Age, "B", false) == 0)
                  break;
                goto label_228;
              case 3423339364:
                if (Operators.CompareString(e1Age, "I", false) == 0)
                {
                  num1 = 0.05f;
                  goto label_228;
                }
                else
                  goto label_228;
              case 3440116983:
                if (Operators.CompareString(e1Age, "H", false) == 0)
                {
                  num1 = 0.025f;
                  goto label_228;
                }
                else
                  goto label_228;
              case 3456894602:
                if (Operators.CompareString(e1Age, "K", false) == 0)
                {
                  num1 = 0.1f;
                  goto label_228;
                }
                else
                  goto label_228;
              case 3473672221:
                if (Operators.CompareString(e1Age, "J", false) == 0)
                {
                  num1 = 0.075f;
                  goto label_228;
                }
                else
                  goto label_228;
              default:
                goto label_228;
            }
            num1 = 0.0f;
          }
          else
          {
            string e1Age = this.Ext.Ages.E1Age;
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
label_227:
                goto label_228;
            }
            num1 = 0.0f;
            goto label_227;
          }
label_228:
          if (surveyClass.Extensions[1].FloorInsulation == 3)
          {
            switch (surveyClass.Extensions[1].FloorInsulationThickness)
            {
              case 1:
                if ((double) num1 < 0.05)
                {
                  num1 = 0.05f;
                  break;
                }
                break;
              case 2:
                num1 = 0.05f;
                break;
              case 3:
                num1 = 0.1f;
                break;
              case 4:
                num1 = 0.15f;
                break;
            }
          }
          float num9 = 2f * this.x.Dims[this.Ext.MStoreys].Area / this.x.Dims[this.Ext.MStoreys].Perimeter;
          this.Ext.WallThickness.E1 = !surveyClass.Extensions[1].WallThicknessMeasured ? (double) this.GetWallThickNess(RdSAP, 1, false) : surveyClass.Extensions[1].WallThickness / 1000.0;
          if (surveyClass.Extensions[1].FloorConstruction == 1)
          {
            string e1Age = this.Ext.Ages.E1Age;
            if (Operators.CompareString(e1Age, "A", false) == 0 || Operators.CompareString(e1Age, "B", false) == 0)
            {
              float num10 = (float) (this.Ext.WallThickness.E1 + 0.315);
              this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = (float) Math.Round(1.0 / (0.54 + 1.0 / (3.0 * Math.Log(Math.PI * (double) num9 / (double) num10 + 1.0) / (Math.PI * (double) num9 + (double) num10) + (9.0 / 10.0 / (double) num9 + 87.0 / 80.0 / (double) num9))), 2);
            }
            else
            {
              float num11 = (float) (this.Ext.WallThickness.E1 + 1.5 * (0.17 + (double) num1 / 0.035 + 0.04));
              this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = (double) num11 >= (double) num9 ? (float) Math.Round(1.5 / (0.457 * (double) num9 + (double) num11), 2) : (float) Math.Round(3.0 * Math.Log(Math.PI * (double) num9 / (double) num11 + 1.0) / (Math.PI * (double) num9 + (double) num11), 2);
            }
          }
          else if (surveyClass.Extensions[1].FloorConstruction == 3 | surveyClass.Extensions[1].FloorConstruction == 4)
          {
            float num12 = (float) (this.Ext.WallThickness.E1 + 0.315);
            float num13 = (float) (3.0 * Math.Log(Math.PI * (double) num9 / (double) num12 + 1.0) / (Math.PI * (double) num9 + (double) num12));
            float num14 = (float) (9.0 / 10.0 / (double) num9 + 87.0 / 80.0 / (double) num9);
            this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = (float) Math.Round(1.0 / (0.34 + (double) num1 / 0.035 + 0.2 + 1.0 / ((double) num13 + (double) num14)), 2);
          }
          else if (surveyClass.Extensions[1].FloorConstruction == 2)
          {
            float num15 = (float) (this.Ext.WallThickness.E1 + 1.5 * (0.17 + (double) num1 / 0.035 + 0.04));
            this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = (double) num15 >= (double) num9 ? (float) Math.Round(1.5 / (0.457 * (double) num9 + (double) num15), 2) : (float) Math.Round(3.0 * Math.Log(Math.PI * (double) num9 / (double) num15 + 1.0) / (Math.PI * (double) num9 + (double) num15), 2);
          }
          this.x.Floors[checked (this.x.Floors.Length - 1)].Name = "Extention 1 Floor";
          this.x.Floors[checked (this.x.Floors.Length - 1)].Type = "Ground floor";
          this.x.Floors[checked (this.x.Floors.Length - 1)].Area = (float) Math.Round((double) this.x.Dims[this.Ext.MStoreys].Area, 2);
        }
        else if (surveyClass.Extensions[1].LowestFloor == 3)
        {
          if (this.x.Floors != null)
          {
            // ISSUE: variable of a reference type
            SAP_Module.Opaques[]& local;
            // ISSUE: explicit reference operation
            SAP_Module.Opaques[] opaquesArray = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local = ref this.x.Floors), (Array) new SAP_Module.Opaques[checked (this.x.Floors.Length + 1)]);
            local = opaquesArray;
          }
          else
          {
            // ISSUE: variable of a reference type
            SAP_Module.Opaques[]& local;
            // ISSUE: explicit reference operation
            SAP_Module.Opaques[] opaquesArray = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local = ref this.x.Floors), (Array) new SAP_Module.Opaques[1]);
            local = opaquesArray;
          }
          this.x.Floors[checked (this.x.Floors.Length - 1)] = new SAP_Module.Opaques();
          this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = 0.7f;
          this.x.Floors[checked (this.x.Floors.Length - 1)].Name = "Extention 1 Floor";
          this.x.Floors[checked (this.x.Floors.Length - 1)].Type = "Exposed floor";
          this.x.Floors[checked (this.x.Floors.Length - 1)].Area = this.x.Dims[this.Ext.MStoreys].Area;
        }
        else if (surveyClass.Extensions[1].LowestFloor == 2 | surveyClass.Extensions[1].LowestFloor == 1 | surveyClass.Extensions[1].LowestFloor == 7)
        {
          if (this.x.Floors != null)
          {
            // ISSUE: variable of a reference type
            SAP_Module.Opaques[]& local;
            // ISSUE: explicit reference operation
            SAP_Module.Opaques[] opaquesArray = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local = ref this.x.Floors), (Array) new SAP_Module.Opaques[checked (this.x.Floors.Length + 1)]);
            local = opaquesArray;
          }
          else
          {
            // ISSUE: variable of a reference type
            SAP_Module.Opaques[]& local;
            // ISSUE: explicit reference operation
            SAP_Module.Opaques[] opaquesArray = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local = ref this.x.Floors), (Array) new SAP_Module.Opaques[1]);
            local = opaquesArray;
          }
          this.x.Floors[checked (this.x.Floors.Length - 1)] = new SAP_Module.Opaques();
          if (surveyClass.Extensions[1].FloorInsulation == 1 | surveyClass.Extensions[1].FloorInsulation == 2)
          {
            string e1Age = this.Ext.Ages.E1Age;
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
                  goto label_268;
                else
                  goto default;
              case 3440116983:
                if (Operators.CompareString(e1Age, "H", false) == 0)
                  goto label_268;
                else
                  goto default;
              case 3456894602:
                if (Operators.CompareString(e1Age, "K", false) == 0)
                {
                  this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = 0.22f;
                  goto default;
                }
                else
                  goto default;
              case 3473672221:
                if (Operators.CompareString(e1Age, "J", false) == 0)
                {
                  this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = 0.25f;
                  goto default;
                }
                else
                  goto default;
              default:
label_271:
                goto label_272;
            }
            this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = 1.2f;
            goto label_271;
label_268:
            this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = 0.51f;
            goto label_271;
          }
label_272:
          if (surveyClass.Extensions[1].FloorInsulation == 3)
          {
            string e1Age = this.Ext.Ages.E1Age;
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
                  goto label_286;
                else
                  goto default;
              case 3440116983:
                if (Operators.CompareString(e1Age, "H", false) == 0)
                  goto label_286;
                else
                  goto default;
              case 3456894602:
                if (Operators.CompareString(e1Age, "K", false) == 0)
                {
                  this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = 0.22f;
                  goto default;
                }
                else
                  goto default;
              case 3473672221:
                if (Operators.CompareString(e1Age, "J", false) == 0)
                {
                  this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = 0.25f;
                  goto default;
                }
                else
                  goto default;
              default:
label_289:
                goto label_290;
            }
            this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = 0.5f;
            goto label_289;
label_286:
            this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = 0.5f;
            goto label_289;
          }
label_290:
          this.x.Floors[checked (this.x.Floors.Length - 1)].Name = "Extention 1 Floor";
          this.x.Floors[checked (this.x.Floors.Length - 1)].Type = surveyClass.Extensions[1].LowestFloor != 7 ? "Exposed floor" : "To External Air";
          this.x.Floors[checked (this.x.Floors.Length - 1)].Area = (float) Math.Round((double) this.x.Dims[this.Ext.MStoreys].Area, 2);
        }
        else if (surveyClass.Extensions[1].LowestFloor == 4)
        {
          if (this.Ext.EPCFloors == null)
          {
            RdSAP_TO_SAP.Extensions ext;
            RdSAP_TO_SAP.EPCFloors[] epcFloorsArray = (RdSAP_TO_SAP.EPCFloors[]) Utils.CopyArray((Array) (ext = this.Ext).EPCFloors, (Array) new RdSAP_TO_SAP.EPCFloors[1]);
            ext.EPCFloors = epcFloorsArray;
            this.Ext.EPCFloors[0] = new RdSAP_TO_SAP.EPCFloors();
          }
          else
          {
            RdSAP_TO_SAP.Extensions ext;
            RdSAP_TO_SAP.EPCFloors[] epcFloorsArray = (RdSAP_TO_SAP.EPCFloors[]) Utils.CopyArray((Array) (ext = this.Ext).EPCFloors, (Array) new RdSAP_TO_SAP.EPCFloors[checked (this.Ext.EPCFloors.Length + 1)]);
            ext.EPCFloors = epcFloorsArray;
            this.Ext.EPCFloors[checked (this.Ext.EPCFloors.Length - 1)] = new RdSAP_TO_SAP.EPCFloors();
          }
          this.Ext.EPCFloors[checked (this.Ext.EPCFloors.Length - 1)].Area = (float) Math.Round((double) this.x.Dims[this.Ext.MStoreys].Area, 2);
          this.Ext.EPCFloors[checked (this.Ext.EPCFloors.Length - 1)].Desc = "(other premises below)";
          this.Ext.EPCFloors[checked (this.Ext.EPCFloors.Length - 1)].Ext = 1;
          surveyClass.Extensions[1].FloorUValueKnown = false;
        }
        else if (surveyClass.Extensions[1].LowestFloor == 6)
        {
          if (this.Ext.EPCFloors == null)
          {
            RdSAP_TO_SAP.Extensions ext;
            RdSAP_TO_SAP.EPCFloors[] epcFloorsArray = (RdSAP_TO_SAP.EPCFloors[]) Utils.CopyArray((Array) (ext = this.Ext).EPCFloors, (Array) new RdSAP_TO_SAP.EPCFloors[1]);
            ext.EPCFloors = epcFloorsArray;
            this.Ext.EPCFloors[0] = new RdSAP_TO_SAP.EPCFloors();
          }
          else
          {
            RdSAP_TO_SAP.Extensions ext;
            RdSAP_TO_SAP.EPCFloors[] epcFloorsArray = (RdSAP_TO_SAP.EPCFloors[]) Utils.CopyArray((Array) (ext = this.Ext).EPCFloors, (Array) new RdSAP_TO_SAP.EPCFloors[checked (this.Ext.EPCFloors.Length + 1)]);
            ext.EPCFloors = epcFloorsArray;
            this.Ext.EPCFloors[checked (this.Ext.EPCFloors.Length - 1)] = new RdSAP_TO_SAP.EPCFloors();
          }
          this.Ext.EPCFloors[checked (this.Ext.EPCFloors.Length - 1)].Area = (float) Math.Round((double) this.x.Dims[this.Ext.MStoreys].Area, 2);
          this.Ext.EPCFloors[checked (this.Ext.EPCFloors.Length - 1)].Desc = "(Same dwelling below)";
          this.Ext.EPCFloors[checked (this.Ext.EPCFloors.Length - 1)].Ext = 1;
          surveyClass.Extensions[1].FloorUValueKnown = false;
        }
        if (surveyClass.Extensions[1].FloorUValueKnown)
          this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = (float) surveyClass.Extensions[1].FloorUValue;
        if (surveyClass.Extensions[1].LowestFloor != 6 & surveyClass.Extensions[1].LowestFloor != 4)
        {
          if (this.x.Floors != null && string.IsNullOrEmpty(this.x.Floors[checked (this.x.Floors.Length - 1)].EPCDesc))
            this.x.Floors[checked (this.x.Floors.Length - 1)].EPCDesc = SAP_Module.Get_Enum_Desc(typeof (Enums.FloorConstructionCode), surveyClass.Extensions[1].FloorConstruction) + ", " + SAP_Module.Get_Enum_Desc(typeof (Enums.FloorInsulationCode), surveyClass.Extensions[1].FloorInsulation) + SAP_Module.Get_Enum_Desc(typeof (Enums.LowestFloorType), surveyClass.Extensions[1].LowestFloor);
          if (surveyClass.Extensions[1].FloorConstruction == 1 && this.x.Floors != null)
            this.x.Floors[checked (this.x.Floors.Length - 1)].Construction = SAP_Module.Get_Enum_Desc(typeof (Enums.FloorConstructionCode), surveyClass.Extensions[1].FloorConstruction);
        }
        if (this.Ext.Exposed.Include_E1)
        {
          if (this.x.Floors != null)
          {
            // ISSUE: variable of a reference type
            SAP_Module.Opaques[]& local;
            // ISSUE: explicit reference operation
            SAP_Module.Opaques[] opaquesArray = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local = ref this.x.Floors), (Array) new SAP_Module.Opaques[checked (this.x.Floors.Length + 1)]);
            local = opaquesArray;
          }
          else
          {
            // ISSUE: variable of a reference type
            SAP_Module.Opaques[]& local;
            // ISSUE: explicit reference operation
            SAP_Module.Opaques[] opaquesArray = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local = ref this.x.Floors), (Array) new SAP_Module.Opaques[1]);
            local = opaquesArray;
          }
          this.x.Floors[checked (this.x.Floors.Length - 1)] = new SAP_Module.Opaques();
          if (surveyClass.Extensions[1].FloorInsulation == 1 | surveyClass.Extensions[1].FloorInsulation == 2)
          {
            string e1Age = this.Ext.Ages.E1Age;
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
                  goto label_327;
                else
                  goto default;
              case 3440116983:
                if (Operators.CompareString(e1Age, "H", false) == 0)
                  goto label_327;
                else
                  goto default;
              case 3456894602:
                if (Operators.CompareString(e1Age, "K", false) == 0)
                {
                  this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = 0.22f;
                  goto default;
                }
                else
                  goto default;
              case 3473672221:
                if (Operators.CompareString(e1Age, "J", false) == 0)
                {
                  this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = 0.25f;
                  goto default;
                }
                else
                  goto default;
              default:
label_330:
                goto label_331;
            }
            this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = 1.2f;
            goto label_330;
label_327:
            this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = 0.51f;
            goto label_330;
          }
label_331:
          if (surveyClass.Extensions[1].FloorInsulation == 3)
          {
            string e1Age = this.Ext.Ages.E1Age;
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
                  goto label_345;
                else
                  goto default;
              case 3440116983:
                if (Operators.CompareString(e1Age, "H", false) == 0)
                  goto label_345;
                else
                  goto default;
              case 3456894602:
                if (Operators.CompareString(e1Age, "K", false) == 0)
                {
                  this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = 0.22f;
                  goto default;
                }
                else
                  goto default;
              case 3473672221:
                if (Operators.CompareString(e1Age, "J", false) == 0)
                {
                  this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = 0.25f;
                  goto default;
                }
                else
                  goto default;
              default:
label_348:
                goto label_349;
            }
            this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = 0.5f;
            goto label_348;
label_345:
            this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = 0.5f;
            goto label_348;
          }
label_349:
          this.x.Floors[checked (this.x.Floors.Length - 1)].Name = "Overhangs";
          this.x.Floors[checked (this.x.Floors.Length - 1)].Type = "Exposed floor";
          this.x.Floors[checked (this.x.Floors.Length - 1)].Area = !(this.Ext.Exposed.A2_E1 < this.Ext.Exposed.A1_E1 & this.Ext.Exposed.A2_E1 != 0.0) ? (float) Math.Round(this.Ext.Exposed.A1_E1, 2) : (float) Math.Round(this.Ext.Exposed.A2_E1, 2);
        }
      }
      if (this.Ext.Ext2)
      {
        if (surveyClass.Extensions[2].LowestFloor == 5)
        {
          if (this.x.Floors != null)
          {
            // ISSUE: variable of a reference type
            SAP_Module.Opaques[]& local;
            // ISSUE: explicit reference operation
            SAP_Module.Opaques[] opaquesArray = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local = ref this.x.Floors), (Array) new SAP_Module.Opaques[checked (this.x.Floors.Length + 1)]);
            local = opaquesArray;
          }
          else
          {
            // ISSUE: variable of a reference type
            SAP_Module.Opaques[]& local;
            // ISSUE: explicit reference operation
            SAP_Module.Opaques[] opaquesArray = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local = ref this.x.Floors), (Array) new SAP_Module.Opaques[1]);
            local = opaquesArray;
          }
          this.x.Floors[checked (this.x.Floors.Length - 1)] = new SAP_Module.Opaques();
          if (surveyClass.General.Country == 4)
          {
            string e2Age = this.Ext.Ages.E2Age;
            // ISSUE: reference to a compiler-generated method
            switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(e2Age))
            {
              case 3222007936:
                if (Operators.CompareString(e2Age, "E", false) == 0)
                  break;
                goto label_409;
              case 3238785555:
                if (Operators.CompareString(e2Age, "D", false) == 0)
                  break;
                goto label_409;
              case 3255563174:
                if (Operators.CompareString(e2Age, "G", false) == 0)
                  break;
                goto label_409;
              case 3272340793:
                if (Operators.CompareString(e2Age, "F", false) == 0)
                  break;
                goto label_409;
              case 3289118412:
                if (Operators.CompareString(e2Age, "A", false) == 0)
                  break;
                goto label_409;
              case 3322673650:
                if (Operators.CompareString(e2Age, "C", false) == 0)
                  break;
                goto label_409;
              case 3339451269:
                if (Operators.CompareString(e2Age, "B", false) == 0)
                  break;
                goto label_409;
              case 3423339364:
                if (Operators.CompareString(e2Age, "I", false) == 0)
                {
                  num1 = 0.05f;
                  goto label_409;
                }
                else
                  goto label_409;
              case 3440116983:
                if (Operators.CompareString(e2Age, "H", false) == 0)
                {
                  num1 = 0.025f;
                  goto label_409;
                }
                else
                  goto label_409;
              case 3456894602:
                if (Operators.CompareString(e2Age, "K", false) == 0)
                {
                  num1 = 0.1f;
                  goto label_409;
                }
                else
                  goto label_409;
              case 3473672221:
                if (Operators.CompareString(e2Age, "J", false) == 0)
                {
                  num1 = 0.0f;
                  goto label_409;
                }
                else
                  goto label_409;
              default:
                goto label_409;
            }
            num1 = 0.0f;
          }
          else if (surveyClass.General.Country == 3)
          {
            string e2Age = this.Ext.Ages.E2Age;
            // ISSUE: reference to a compiler-generated method
            switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(e2Age))
            {
              case 3222007936:
                if (Operators.CompareString(e2Age, "E", false) == 0)
                  break;
                goto label_409;
              case 3238785555:
                if (Operators.CompareString(e2Age, "D", false) == 0)
                  break;
                goto label_409;
              case 3255563174:
                if (Operators.CompareString(e2Age, "G", false) == 0)
                  break;
                goto label_409;
              case 3272340793:
                if (Operators.CompareString(e2Age, "F", false) == 0)
                  break;
                goto label_409;
              case 3289118412:
                if (Operators.CompareString(e2Age, "A", false) == 0)
                  break;
                goto label_409;
              case 3322673650:
                if (Operators.CompareString(e2Age, "C", false) == 0)
                  break;
                goto label_409;
              case 3339451269:
                if (Operators.CompareString(e2Age, "B", false) == 0)
                  break;
                goto label_409;
              case 3423339364:
                if (Operators.CompareString(e2Age, "I", false) == 0)
                {
                  num1 = 0.05f;
                  goto label_409;
                }
                else
                  goto label_409;
              case 3440116983:
                if (Operators.CompareString(e2Age, "H", false) == 0)
                {
                  num1 = 0.025f;
                  goto label_409;
                }
                else
                  goto label_409;
              case 3456894602:
                if (Operators.CompareString(e2Age, "K", false) == 0)
                {
                  num1 = 0.1f;
                  goto label_409;
                }
                else
                  goto label_409;
              case 3473672221:
                if (Operators.CompareString(e2Age, "J", false) == 0)
                {
                  num1 = 0.075f;
                  goto label_409;
                }
                else
                  goto label_409;
              default:
                goto label_409;
            }
            num1 = 0.0f;
          }
          else
          {
            string e2Age = this.Ext.Ages.E2Age;
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
label_408:
                goto label_409;
            }
            num1 = 0.0f;
            goto label_408;
          }
label_409:
          if (surveyClass.Extensions[2].FloorInsulation == 3)
          {
            switch (surveyClass.Extensions[2].FloorInsulationThickness)
            {
              case 1:
                if ((double) num1 < 0.05)
                {
                  num1 = 0.05f;
                  break;
                }
                break;
              case 2:
                num1 = 0.05f;
                break;
              case 3:
                num1 = 0.1f;
                break;
              case 4:
                num1 = 0.15f;
                break;
            }
          }
          float num16 = 2f * this.x.Dims[checked (this.Ext.MStoreys + this.Ext.E1Storeys)].Area / this.x.Dims[checked (this.Ext.MStoreys + this.Ext.E1Storeys)].Perimeter;
          this.Ext.WallThickness.E2 = !surveyClass.Extensions[2].WallThicknessMeasured ? (double) this.GetWallThickNess(RdSAP, 2, false) : surveyClass.Extensions[2].WallThickness / 1000.0;
          if (surveyClass.Extensions[2].FloorConstruction == 1)
          {
            string e2Age = this.Ext.Ages.E2Age;
            if (Operators.CompareString(e2Age, "A", false) == 0 || Operators.CompareString(e2Age, "B", false) == 0)
            {
              float num17 = (float) (this.Ext.WallThickness.E2 + 0.315);
              this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = (float) Math.Round(1.0 / (0.54 + 1.0 / (3.0 * Math.Log(Math.PI * (double) num16 / (double) num17 + 1.0) / (Math.PI * (double) num16 + (double) num17) + (9.0 / 10.0 / (double) num16 + 87.0 / 80.0 / (double) num16))), 2);
            }
            else
            {
              float num18 = (float) (this.Ext.WallThickness.E2 + 1.5 * (0.17 + (double) num1 / 0.035 + 0.04));
              this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = (double) num18 >= (double) num16 ? (float) Math.Round(1.5 / (0.457 * (double) num16 + (double) num18), 2) : (float) Math.Round(3.0 * Math.Log(Math.PI * (double) num16 / (double) num18 + 1.0) / (Math.PI * (double) num16 + (double) num18), 2);
            }
          }
          else if (surveyClass.Extensions[2].FloorConstruction == 3 | surveyClass.Extensions[2].FloorConstruction == 4)
          {
            float num19 = (float) (this.Ext.WallThickness.E2 + 0.315);
            float num20 = (float) (3.0 * Math.Log(Math.PI * (double) num16 / (double) num19 + 1.0) / (Math.PI * (double) num16 + (double) num19));
            float num21 = (float) (9.0 / 10.0 / (double) num16 + 87.0 / 80.0 / (double) num16);
            this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = (float) Math.Round(1.0 / (0.34 + (double) num1 / 0.035 + 0.2 + 1.0 / ((double) num20 + (double) num21)), 2);
          }
          else if (surveyClass.Extensions[2].FloorConstruction == 2)
          {
            float num22 = (float) (this.Ext.WallThickness.E2 + 1.5 * (0.17 + (double) num1 / 0.035 + 0.04));
            this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = (double) num22 >= (double) num16 ? (float) Math.Round(1.5 / (0.457 * (double) num16 + (double) num22), 2) : (float) Math.Round(3.0 * Math.Log(Math.PI * (double) num16 / (double) num22 + 1.0) / (Math.PI * (double) num16 + (double) num22), 2);
          }
          this.x.Floors[checked (this.x.Floors.Length - 1)].Name = "Extention 2 Floor";
          this.x.Floors[checked (this.x.Floors.Length - 1)].Type = "Ground floor";
          this.x.Floors[checked (this.x.Floors.Length - 1)].Area = (float) Math.Round((double) this.x.Dims[checked (this.Ext.MStoreys + this.Ext.E1Storeys)].Area, 2);
        }
        else if (surveyClass.Extensions[2].LowestFloor == 3)
        {
          if (this.x.Floors != null)
          {
            // ISSUE: variable of a reference type
            SAP_Module.Opaques[]& local;
            // ISSUE: explicit reference operation
            SAP_Module.Opaques[] opaquesArray = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local = ref this.x.Floors), (Array) new SAP_Module.Opaques[checked (this.x.Floors.Length + 1)]);
            local = opaquesArray;
          }
          else
          {
            // ISSUE: variable of a reference type
            SAP_Module.Opaques[]& local;
            // ISSUE: explicit reference operation
            SAP_Module.Opaques[] opaquesArray = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local = ref this.x.Floors), (Array) new SAP_Module.Opaques[1]);
            local = opaquesArray;
          }
          this.x.Floors[checked (this.x.Floors.Length - 1)] = new SAP_Module.Opaques();
          this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = 0.7f;
          this.x.Floors[checked (this.x.Floors.Length - 1)].Name = "Extention 2 Floor";
          this.x.Floors[checked (this.x.Floors.Length - 1)].Type = "Exposed floor";
          this.x.Floors[checked (this.x.Floors.Length - 1)].Area = (float) Math.Round((double) this.x.Dims[checked (this.Ext.MStoreys + this.Ext.E1Storeys)].Area, 2);
        }
        else if (surveyClass.Extensions[2].LowestFloor == 2 | surveyClass.Extensions[2].LowestFloor == 1 | surveyClass.Extensions[2].LowestFloor == 7)
        {
          if (this.x.Floors != null)
          {
            // ISSUE: variable of a reference type
            SAP_Module.Opaques[]& local;
            // ISSUE: explicit reference operation
            SAP_Module.Opaques[] opaquesArray = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local = ref this.x.Floors), (Array) new SAP_Module.Opaques[checked (this.x.Floors.Length + 1)]);
            local = opaquesArray;
          }
          else
          {
            // ISSUE: variable of a reference type
            SAP_Module.Opaques[]& local;
            // ISSUE: explicit reference operation
            SAP_Module.Opaques[] opaquesArray = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local = ref this.x.Floors), (Array) new SAP_Module.Opaques[1]);
            local = opaquesArray;
          }
          this.x.Floors[checked (this.x.Floors.Length - 1)] = new SAP_Module.Opaques();
          if (surveyClass.Extensions[2].FloorInsulation == 1 | surveyClass.Extensions[2].FloorInsulation == 2)
          {
            string e2Age = this.Ext.Ages.E2Age;
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
                  goto label_449;
                else
                  goto default;
              case 3440116983:
                if (Operators.CompareString(e2Age, "H", false) == 0)
                  goto label_449;
                else
                  goto default;
              case 3456894602:
                if (Operators.CompareString(e2Age, "K", false) == 0)
                {
                  this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = 0.22f;
                  goto default;
                }
                else
                  goto default;
              case 3473672221:
                if (Operators.CompareString(e2Age, "J", false) == 0)
                {
                  this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = 0.25f;
                  goto default;
                }
                else
                  goto default;
              default:
label_452:
                goto label_453;
            }
            this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = 1.2f;
            goto label_452;
label_449:
            this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = 0.51f;
            goto label_452;
          }
label_453:
          if (surveyClass.Extensions[2].FloorInsulation == 3)
          {
            string e2Age = this.Ext.Ages.E2Age;
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
                  goto label_467;
                else
                  goto default;
              case 3440116983:
                if (Operators.CompareString(e2Age, "H", false) == 0)
                  goto label_467;
                else
                  goto default;
              case 3456894602:
                if (Operators.CompareString(e2Age, "K", false) == 0)
                {
                  this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = 0.22f;
                  goto default;
                }
                else
                  goto default;
              case 3473672221:
                if (Operators.CompareString(e2Age, "J", false) == 0)
                {
                  this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = 0.25f;
                  goto default;
                }
                else
                  goto default;
              default:
label_470:
                goto label_471;
            }
            this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = 0.5f;
            goto label_470;
label_467:
            this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = 0.5f;
            goto label_470;
          }
label_471:
          this.x.Floors[checked (this.x.Floors.Length - 1)].Name = "Extention 2 Floor";
          this.x.Floors[checked (this.x.Floors.Length - 1)].Type = surveyClass.Extensions[2].LowestFloor != 7 ? "Exposed floor" : "To External Air";
          this.x.Floors[checked (this.x.Floors.Length - 1)].Area = (float) Math.Round((double) this.x.Dims[checked (this.Ext.MStoreys + this.Ext.E1Storeys)].Area, 2);
        }
        else if (surveyClass.Extensions[2].LowestFloor == 4)
        {
          if (this.Ext.EPCFloors == null)
          {
            RdSAP_TO_SAP.Extensions ext;
            RdSAP_TO_SAP.EPCFloors[] epcFloorsArray = (RdSAP_TO_SAP.EPCFloors[]) Utils.CopyArray((Array) (ext = this.Ext).EPCFloors, (Array) new RdSAP_TO_SAP.EPCFloors[1]);
            ext.EPCFloors = epcFloorsArray;
            this.Ext.EPCFloors[0] = new RdSAP_TO_SAP.EPCFloors();
          }
          else
          {
            RdSAP_TO_SAP.Extensions ext;
            RdSAP_TO_SAP.EPCFloors[] epcFloorsArray = (RdSAP_TO_SAP.EPCFloors[]) Utils.CopyArray((Array) (ext = this.Ext).EPCFloors, (Array) new RdSAP_TO_SAP.EPCFloors[checked (this.Ext.EPCFloors.Length + 1)]);
            ext.EPCFloors = epcFloorsArray;
            this.Ext.EPCFloors[checked (this.Ext.EPCFloors.Length - 1)] = new RdSAP_TO_SAP.EPCFloors();
          }
          this.Ext.EPCFloors[checked (this.Ext.EPCFloors.Length - 1)].Area = (float) Math.Round((double) this.x.Dims[checked (this.Ext.MStoreys + this.Ext.E1Storeys)].Area, 2);
          this.Ext.EPCFloors[checked (this.Ext.EPCFloors.Length - 1)].Desc = "(other premises below)";
          this.Ext.EPCFloors[checked (this.Ext.EPCFloors.Length - 1)].Ext = 2;
          surveyClass.Extensions[2].FloorUValueKnown = false;
        }
        else if (surveyClass.Extensions[2].LowestFloor == 6)
        {
          if (this.Ext.EPCFloors == null)
          {
            RdSAP_TO_SAP.Extensions ext;
            RdSAP_TO_SAP.EPCFloors[] epcFloorsArray = (RdSAP_TO_SAP.EPCFloors[]) Utils.CopyArray((Array) (ext = this.Ext).EPCFloors, (Array) new RdSAP_TO_SAP.EPCFloors[1]);
            ext.EPCFloors = epcFloorsArray;
            this.Ext.EPCFloors[0] = new RdSAP_TO_SAP.EPCFloors();
          }
          else
          {
            RdSAP_TO_SAP.Extensions ext;
            RdSAP_TO_SAP.EPCFloors[] epcFloorsArray = (RdSAP_TO_SAP.EPCFloors[]) Utils.CopyArray((Array) (ext = this.Ext).EPCFloors, (Array) new RdSAP_TO_SAP.EPCFloors[checked (this.Ext.EPCFloors.Length + 1)]);
            ext.EPCFloors = epcFloorsArray;
            this.Ext.EPCFloors[checked (this.Ext.EPCFloors.Length - 1)] = new RdSAP_TO_SAP.EPCFloors();
          }
          this.Ext.EPCFloors[checked (this.Ext.EPCFloors.Length - 1)].Area = (float) Math.Round((double) this.x.Dims[checked (this.Ext.MStoreys + this.Ext.E1Storeys)].Area, 2);
          this.Ext.EPCFloors[checked (this.Ext.EPCFloors.Length - 1)].Desc = "(Same dwelling below)";
          this.Ext.EPCFloors[checked (this.Ext.EPCFloors.Length - 1)].Ext = 2;
          surveyClass.Extensions[2].FloorUValueKnown = false;
        }
        if (surveyClass.Extensions[2].FloorUValueKnown)
          this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = (float) surveyClass.Extensions[2].FloorUValue;
        if (surveyClass.Extensions[2].LowestFloor != 6 & surveyClass.Extensions[2].LowestFloor != 4)
        {
          if (this.x.Floors != null && string.IsNullOrEmpty(this.x.Floors[checked (this.x.Floors.Length - 1)].EPCDesc))
            this.x.Floors[checked (this.x.Floors.Length - 1)].EPCDesc = SAP_Module.Get_Enum_Desc(typeof (Enums.FloorConstructionCode), surveyClass.Extensions[2].FloorConstruction) + ", " + SAP_Module.Get_Enum_Desc(typeof (Enums.FloorInsulationCode), surveyClass.Extensions[2].FloorInsulation) + SAP_Module.Get_Enum_Desc(typeof (Enums.LowestFloorType), surveyClass.Extensions[2].LowestFloor);
          if (surveyClass.Extensions[2].FloorConstruction == 1 && this.x.Floors != null)
            this.x.Floors[checked (this.x.Floors.Length - 1)].Construction = SAP_Module.Get_Enum_Desc(typeof (Enums.FloorConstructionCode), surveyClass.Extensions[1].FloorConstruction);
        }
        if (this.Ext.Exposed.Include_E2)
        {
          if (this.x.Floors != null)
          {
            // ISSUE: variable of a reference type
            SAP_Module.Opaques[]& local;
            // ISSUE: explicit reference operation
            SAP_Module.Opaques[] opaquesArray = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local = ref this.x.Floors), (Array) new SAP_Module.Opaques[checked (this.x.Floors.Length + 1)]);
            local = opaquesArray;
          }
          else
          {
            // ISSUE: variable of a reference type
            SAP_Module.Opaques[]& local;
            // ISSUE: explicit reference operation
            SAP_Module.Opaques[] opaquesArray = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local = ref this.x.Floors), (Array) new SAP_Module.Opaques[1]);
            local = opaquesArray;
          }
          this.x.Floors[checked (this.x.Floors.Length - 1)] = new SAP_Module.Opaques();
          if (surveyClass.Extensions[2].FloorInsulation == 1 | surveyClass.Extensions[2].FloorInsulation == 2)
          {
            string e2Age = this.Ext.Ages.E2Age;
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
                  goto label_508;
                else
                  goto default;
              case 3440116983:
                if (Operators.CompareString(e2Age, "H", false) == 0)
                  goto label_508;
                else
                  goto default;
              case 3456894602:
                if (Operators.CompareString(e2Age, "K", false) == 0)
                {
                  this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = 0.22f;
                  goto default;
                }
                else
                  goto default;
              case 3473672221:
                if (Operators.CompareString(e2Age, "J", false) == 0)
                {
                  this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = 0.25f;
                  goto default;
                }
                else
                  goto default;
              default:
label_511:
                goto label_512;
            }
            this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = 1.2f;
            goto label_511;
label_508:
            this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = 0.51f;
            goto label_511;
          }
label_512:
          if (surveyClass.Extensions[2].FloorInsulation == 3)
          {
            string e2Age = this.Ext.Ages.E2Age;
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
                  goto label_526;
                else
                  goto default;
              case 3440116983:
                if (Operators.CompareString(e2Age, "H", false) == 0)
                  goto label_526;
                else
                  goto default;
              case 3456894602:
                if (Operators.CompareString(e2Age, "K", false) == 0)
                {
                  this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = 0.22f;
                  goto default;
                }
                else
                  goto default;
              case 3473672221:
                if (Operators.CompareString(e2Age, "J", false) == 0)
                {
                  this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = 0.25f;
                  goto default;
                }
                else
                  goto default;
              default:
label_529:
                goto label_530;
            }
            this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = 0.5f;
            goto label_529;
label_526:
            this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = 0.5f;
            goto label_529;
          }
label_530:
          this.x.Floors[checked (this.x.Floors.Length - 1)].Name = "Overhangs E2";
          this.x.Floors[checked (this.x.Floors.Length - 1)].Type = "Exposed floor";
          this.x.Floors[checked (this.x.Floors.Length - 1)].Area = !(this.Ext.Exposed.A2_E2 < this.Ext.Exposed.A1_E2 & this.Ext.Exposed.A2_E2 != 0.0) ? (float) Math.Round(this.Ext.Exposed.A1_E2, 2) : (float) Math.Round(this.Ext.Exposed.A2_E2, 2);
        }
      }
      if (this.Ext.Ext3)
      {
        if (surveyClass.Extensions[3].LowestFloor == 5)
        {
          if (this.x.Floors != null)
          {
            // ISSUE: variable of a reference type
            SAP_Module.Opaques[]& local;
            // ISSUE: explicit reference operation
            SAP_Module.Opaques[] opaquesArray = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local = ref this.x.Floors), (Array) new SAP_Module.Opaques[checked (this.x.Floors.Length + 1)]);
            local = opaquesArray;
          }
          else
          {
            // ISSUE: variable of a reference type
            SAP_Module.Opaques[]& local;
            // ISSUE: explicit reference operation
            SAP_Module.Opaques[] opaquesArray = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local = ref this.x.Floors), (Array) new SAP_Module.Opaques[1]);
            local = opaquesArray;
          }
          this.x.Floors[checked (this.x.Floors.Length - 1)] = new SAP_Module.Opaques();
          if (surveyClass.General.Country == 4)
          {
            string e3Age = this.Ext.Ages.E3Age;
            // ISSUE: reference to a compiler-generated method
            switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(e3Age))
            {
              case 3222007936:
                if (Operators.CompareString(e3Age, "E", false) == 0)
                  break;
                goto label_590;
              case 3238785555:
                if (Operators.CompareString(e3Age, "D", false) == 0)
                  break;
                goto label_590;
              case 3255563174:
                if (Operators.CompareString(e3Age, "G", false) == 0)
                  break;
                goto label_590;
              case 3272340793:
                if (Operators.CompareString(e3Age, "F", false) == 0)
                  break;
                goto label_590;
              case 3289118412:
                if (Operators.CompareString(e3Age, "A", false) == 0)
                  break;
                goto label_590;
              case 3322673650:
                if (Operators.CompareString(e3Age, "C", false) == 0)
                  break;
                goto label_590;
              case 3339451269:
                if (Operators.CompareString(e3Age, "B", false) == 0)
                  break;
                goto label_590;
              case 3423339364:
                if (Operators.CompareString(e3Age, "I", false) == 0)
                {
                  num1 = 0.05f;
                  goto label_590;
                }
                else
                  goto label_590;
              case 3440116983:
                if (Operators.CompareString(e3Age, "H", false) == 0)
                {
                  num1 = 0.025f;
                  goto label_590;
                }
                else
                  goto label_590;
              case 3456894602:
                if (Operators.CompareString(e3Age, "K", false) == 0)
                {
                  num1 = 0.1f;
                  goto label_590;
                }
                else
                  goto label_590;
              case 3473672221:
                if (Operators.CompareString(e3Age, "J", false) == 0)
                {
                  num1 = 0.0f;
                  goto label_590;
                }
                else
                  goto label_590;
              default:
                goto label_590;
            }
            num1 = 0.0f;
          }
          else if (surveyClass.General.Country == 3)
          {
            string e3Age = this.Ext.Ages.E3Age;
            // ISSUE: reference to a compiler-generated method
            switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(e3Age))
            {
              case 3222007936:
                if (Operators.CompareString(e3Age, "E", false) == 0)
                  break;
                goto label_590;
              case 3238785555:
                if (Operators.CompareString(e3Age, "D", false) == 0)
                  break;
                goto label_590;
              case 3255563174:
                if (Operators.CompareString(e3Age, "G", false) == 0)
                  break;
                goto label_590;
              case 3272340793:
                if (Operators.CompareString(e3Age, "F", false) == 0)
                  break;
                goto label_590;
              case 3289118412:
                if (Operators.CompareString(e3Age, "A", false) == 0)
                  break;
                goto label_590;
              case 3322673650:
                if (Operators.CompareString(e3Age, "C", false) == 0)
                  break;
                goto label_590;
              case 3339451269:
                if (Operators.CompareString(e3Age, "B", false) == 0)
                  break;
                goto label_590;
              case 3423339364:
                if (Operators.CompareString(e3Age, "I", false) == 0)
                {
                  num1 = 0.05f;
                  goto label_590;
                }
                else
                  goto label_590;
              case 3440116983:
                if (Operators.CompareString(e3Age, "H", false) == 0)
                {
                  num1 = 0.025f;
                  goto label_590;
                }
                else
                  goto label_590;
              case 3456894602:
                if (Operators.CompareString(e3Age, "K", false) == 0)
                {
                  num1 = 0.1f;
                  goto label_590;
                }
                else
                  goto label_590;
              case 3473672221:
                if (Operators.CompareString(e3Age, "J", false) == 0)
                {
                  num1 = 0.075f;
                  goto label_590;
                }
                else
                  goto label_590;
              default:
                goto label_590;
            }
            num1 = 0.0f;
          }
          else
          {
            string e3Age = this.Ext.Ages.E3Age;
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
label_589:
                goto label_590;
            }
            num1 = 0.0f;
            goto label_589;
          }
label_590:
          if (surveyClass.Extensions[3].FloorInsulation == 3)
          {
            switch (surveyClass.Extensions[3].FloorInsulationThickness)
            {
              case 1:
                if ((double) num1 < 0.05)
                {
                  num1 = 0.05f;
                  break;
                }
                break;
              case 2:
                num1 = 0.05f;
                break;
              case 3:
                num1 = 0.1f;
                break;
              case 4:
                num1 = 0.15f;
                break;
            }
          }
          float num23 = 2f * this.x.Dims[checked (this.Ext.MStoreys + this.Ext.E1Storeys + this.Ext.E2Storeys)].Area / this.x.Dims[checked (this.Ext.MStoreys + this.Ext.E1Storeys + this.Ext.E2Storeys)].Perimeter;
          this.Ext.WallThickness.E3 = !surveyClass.Extensions[3].WallThicknessMeasured ? (double) this.GetWallThickNess(RdSAP, 3, false) : surveyClass.Extensions[3].WallThickness / 1000.0;
          if (surveyClass.Extensions[3].FloorInsulation == 1)
          {
            string e3Age = this.Ext.Ages.E3Age;
            if (Operators.CompareString(e3Age, "A", false) == 0 || Operators.CompareString(e3Age, "B", false) == 0)
            {
              float num24 = (float) (this.Ext.WallThickness.E3 + 0.315);
              this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = (float) Math.Round(1.0 / (0.54 + 1.0 / (3.0 * Math.Log(Math.PI * (double) num23 / (double) num24 + 1.0) / (Math.PI * (double) num23 + (double) num24) + (9.0 / 10.0 / (double) num23 + 87.0 / 80.0 / (double) num23))), 2);
            }
            else
            {
              float num25 = (float) (this.Ext.WallThickness.E3 + 1.5 * (0.17 + (double) num1 / 0.035 + 0.04));
              this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = (double) num25 >= (double) num23 ? (float) Math.Round(1.5 / (0.457 * (double) num23 + (double) num25), 2) : (float) Math.Round(3.0 * Math.Log(Math.PI * (double) num23 / (double) num25 + 1.0) / (Math.PI * (double) num23 + (double) num25), 2);
            }
          }
          else if (surveyClass.Extensions[3].FloorConstruction == 3 | surveyClass.Extensions[3].FloorConstruction == 4)
          {
            float num26 = (float) (this.Ext.WallThickness.E3 + 0.315);
            float num27 = (float) (3.0 * Math.Log(Math.PI * (double) num23 / (double) num26 + 1.0) / (Math.PI * (double) num23 + (double) num26));
            float num28 = (float) (9.0 / 10.0 / (double) num23 + 87.0 / 80.0 / (double) num23);
            this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = (float) Math.Round(1.0 / (0.34 + (double) num1 / 0.035 + 0.2 + 1.0 / ((double) num27 + (double) num28)), 2);
          }
          else if (surveyClass.Extensions[3].FloorConstruction == 2)
          {
            float num29 = (float) (this.Ext.WallThickness.E3 + 1.5 * (0.17 + (double) num1 / 0.035 + 0.04));
            this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = (double) num29 >= (double) num23 ? (float) Math.Round(1.5 / (0.457 * (double) num23 + (double) num29), 2) : (float) Math.Round(3.0 * Math.Log(Math.PI * (double) num23 / (double) num29 + 1.0) / (Math.PI * (double) num23 + (double) num29), 2);
          }
          this.x.Floors[checked (this.x.Floors.Length - 1)].Name = "Extention 3 Floor";
          this.x.Floors[checked (this.x.Floors.Length - 1)].Type = "Ground floor";
          this.x.Floors[checked (this.x.Floors.Length - 1)].Area = (float) Math.Round((double) this.x.Dims[checked (this.Ext.MStoreys + this.Ext.E1Storeys + this.Ext.E2Storeys)].Area, 2);
        }
        else if (surveyClass.Extensions[3].LowestFloor == 3)
        {
          if (this.x.Floors != null)
          {
            // ISSUE: variable of a reference type
            SAP_Module.Opaques[]& local;
            // ISSUE: explicit reference operation
            SAP_Module.Opaques[] opaquesArray = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local = ref this.x.Floors), (Array) new SAP_Module.Opaques[checked (this.x.Floors.Length + 1)]);
            local = opaquesArray;
          }
          else
          {
            // ISSUE: variable of a reference type
            SAP_Module.Opaques[]& local;
            // ISSUE: explicit reference operation
            SAP_Module.Opaques[] opaquesArray = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local = ref this.x.Floors), (Array) new SAP_Module.Opaques[1]);
            local = opaquesArray;
          }
          this.x.Floors[checked (this.x.Floors.Length - 1)] = new SAP_Module.Opaques();
          this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = 0.7f;
          this.x.Floors[checked (this.x.Floors.Length - 1)].Name = "Extention 3 Floor";
          this.x.Floors[checked (this.x.Floors.Length - 1)].Type = "Exposed floor";
          this.x.Floors[checked (this.x.Floors.Length - 1)].Area = (float) Math.Round((double) this.x.Dims[checked (this.Ext.MStoreys + this.Ext.E1Storeys + this.Ext.E2Storeys)].Area, 2);
        }
        else if (surveyClass.Extensions[3].LowestFloor == 2 | surveyClass.Extensions[3].LowestFloor == 1 | surveyClass.Extensions[3].LowestFloor == 7)
        {
          if (this.x.Floors != null)
          {
            // ISSUE: variable of a reference type
            SAP_Module.Opaques[]& local;
            // ISSUE: explicit reference operation
            SAP_Module.Opaques[] opaquesArray = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local = ref this.x.Floors), (Array) new SAP_Module.Opaques[checked (this.x.Floors.Length + 1)]);
            local = opaquesArray;
          }
          else
          {
            // ISSUE: variable of a reference type
            SAP_Module.Opaques[]& local;
            // ISSUE: explicit reference operation
            SAP_Module.Opaques[] opaquesArray = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local = ref this.x.Floors), (Array) new SAP_Module.Opaques[1]);
            local = opaquesArray;
          }
          this.x.Floors[checked (this.x.Floors.Length - 1)] = new SAP_Module.Opaques();
          if (surveyClass.Extensions[3].FloorInsulation == 1 | surveyClass.Extensions[3].FloorInsulation == 2)
          {
            string e3Age = this.Ext.Ages.E3Age;
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
                  goto label_630;
                else
                  goto default;
              case 3440116983:
                if (Operators.CompareString(e3Age, "H", false) == 0)
                  goto label_630;
                else
                  goto default;
              case 3456894602:
                if (Operators.CompareString(e3Age, "K", false) == 0)
                {
                  this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = 0.22f;
                  goto default;
                }
                else
                  goto default;
              case 3473672221:
                if (Operators.CompareString(e3Age, "J", false) == 0)
                {
                  this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = 0.25f;
                  goto default;
                }
                else
                  goto default;
              default:
label_633:
                goto label_634;
            }
            this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = 1.2f;
            goto label_633;
label_630:
            this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = 0.51f;
            goto label_633;
          }
label_634:
          if (surveyClass.Extensions[3].FloorInsulation == 3)
          {
            string e3Age = this.Ext.Ages.E3Age;
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
                  goto label_648;
                else
                  goto default;
              case 3440116983:
                if (Operators.CompareString(e3Age, "H", false) == 0)
                  goto label_648;
                else
                  goto default;
              case 3456894602:
                if (Operators.CompareString(e3Age, "K", false) == 0)
                {
                  this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = 0.22f;
                  goto default;
                }
                else
                  goto default;
              case 3473672221:
                if (Operators.CompareString(e3Age, "J", false) == 0)
                {
                  this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = 0.25f;
                  goto default;
                }
                else
                  goto default;
              default:
label_651:
                goto label_652;
            }
            this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = 0.5f;
            goto label_651;
label_648:
            this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = 0.5f;
            goto label_651;
          }
label_652:
          this.x.Floors[checked (this.x.Floors.Length - 1)].Name = "Extention 3 Floor";
          this.x.Floors[checked (this.x.Floors.Length - 1)].Type = surveyClass.Extensions[3].LowestFloor != 7 ? "Exposed floor" : "To External Air";
          this.x.Floors[checked (this.x.Floors.Length - 1)].Area = (float) Math.Round((double) this.x.Dims[checked (this.Ext.MStoreys + this.Ext.E1Storeys + this.Ext.E2Storeys)].Area, 2);
        }
        else if (surveyClass.Extensions[3].LowestFloor == 4)
        {
          if (this.Ext.EPCFloors == null)
          {
            RdSAP_TO_SAP.Extensions ext;
            RdSAP_TO_SAP.EPCFloors[] epcFloorsArray = (RdSAP_TO_SAP.EPCFloors[]) Utils.CopyArray((Array) (ext = this.Ext).EPCFloors, (Array) new RdSAP_TO_SAP.EPCFloors[1]);
            ext.EPCFloors = epcFloorsArray;
            this.Ext.EPCFloors[0] = new RdSAP_TO_SAP.EPCFloors();
          }
          else
          {
            RdSAP_TO_SAP.Extensions ext;
            RdSAP_TO_SAP.EPCFloors[] epcFloorsArray = (RdSAP_TO_SAP.EPCFloors[]) Utils.CopyArray((Array) (ext = this.Ext).EPCFloors, (Array) new RdSAP_TO_SAP.EPCFloors[checked (this.Ext.EPCFloors.Length + 1)]);
            ext.EPCFloors = epcFloorsArray;
            this.Ext.EPCFloors[checked (this.Ext.EPCFloors.Length - 1)] = new RdSAP_TO_SAP.EPCFloors();
          }
          this.Ext.EPCFloors[checked (this.Ext.EPCFloors.Length - 1)].Area = (float) Math.Round((double) this.x.Dims[checked (this.Ext.MStoreys + this.Ext.E1Storeys + this.Ext.E2Storeys)].Area, 2);
          this.Ext.EPCFloors[checked (this.Ext.EPCFloors.Length - 1)].Desc = "(other premises below)";
          this.Ext.EPCFloors[checked (this.Ext.EPCFloors.Length - 1)].Ext = 3;
          surveyClass.Extensions[3].FloorUValueKnown = false;
        }
        else if (surveyClass.Extensions[3].LowestFloor == 6)
        {
          if (this.Ext.EPCFloors == null)
          {
            RdSAP_TO_SAP.Extensions ext;
            RdSAP_TO_SAP.EPCFloors[] epcFloorsArray = (RdSAP_TO_SAP.EPCFloors[]) Utils.CopyArray((Array) (ext = this.Ext).EPCFloors, (Array) new RdSAP_TO_SAP.EPCFloors[1]);
            ext.EPCFloors = epcFloorsArray;
            this.Ext.EPCFloors[0] = new RdSAP_TO_SAP.EPCFloors();
          }
          else
          {
            RdSAP_TO_SAP.Extensions ext;
            RdSAP_TO_SAP.EPCFloors[] epcFloorsArray = (RdSAP_TO_SAP.EPCFloors[]) Utils.CopyArray((Array) (ext = this.Ext).EPCFloors, (Array) new RdSAP_TO_SAP.EPCFloors[checked (this.Ext.EPCFloors.Length + 1)]);
            ext.EPCFloors = epcFloorsArray;
            this.Ext.EPCFloors[checked (this.Ext.EPCFloors.Length - 1)] = new RdSAP_TO_SAP.EPCFloors();
          }
          this.Ext.EPCFloors[checked (this.Ext.EPCFloors.Length - 1)].Area = (float) Math.Round((double) this.x.Dims[checked (this.Ext.MStoreys + this.Ext.E1Storeys + this.Ext.E2Storeys)].Area, 2);
          this.Ext.EPCFloors[checked (this.Ext.EPCFloors.Length - 1)].Desc = "(Same dwelling below)";
          this.Ext.EPCFloors[checked (this.Ext.EPCFloors.Length - 1)].Ext = 3;
          surveyClass.Extensions[3].FloorUValueKnown = false;
        }
        if (surveyClass.Extensions[3].FloorUValueKnown)
          this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = (float) surveyClass.Extensions[3].FloorUValue;
        if (surveyClass.Extensions[3].LowestFloor != 4 | surveyClass.Extensions[3].LowestFloor != 6)
        {
          if (this.x.Floors != null && string.IsNullOrEmpty(this.x.Floors[checked (this.x.Floors.Length - 1)].EPCDesc))
            this.x.Floors[checked (this.x.Floors.Length - 1)].EPCDesc = SAP_Module.Get_Enum_Desc(typeof (Enums.FloorConstructionCode), surveyClass.Extensions[3].FloorConstruction) + ", " + SAP_Module.Get_Enum_Desc(typeof (Enums.FloorInsulationCode), surveyClass.Extensions[3].FloorInsulation) + SAP_Module.Get_Enum_Desc(typeof (Enums.LowestFloorType), surveyClass.Extensions[3].LowestFloor);
          if (surveyClass.Extensions[3].FloorConstruction == 1 && this.x.Floors != null)
            this.x.Floors[checked (this.x.Floors.Length - 1)].Construction = SAP_Module.Get_Enum_Desc(typeof (Enums.FloorConstructionCode), surveyClass.Extensions[3].FloorConstruction);
        }
        if (this.Ext.Exposed.Include_E3)
        {
          if (this.x.Floors != null)
          {
            // ISSUE: variable of a reference type
            SAP_Module.Opaques[]& local;
            // ISSUE: explicit reference operation
            SAP_Module.Opaques[] opaquesArray = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local = ref this.x.Floors), (Array) new SAP_Module.Opaques[checked (this.x.Floors.Length + 1)]);
            local = opaquesArray;
          }
          else
          {
            // ISSUE: variable of a reference type
            SAP_Module.Opaques[]& local;
            // ISSUE: explicit reference operation
            SAP_Module.Opaques[] opaquesArray = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local = ref this.x.Floors), (Array) new SAP_Module.Opaques[1]);
            local = opaquesArray;
          }
          this.x.Floors[checked (this.x.Floors.Length - 1)] = new SAP_Module.Opaques();
          if (surveyClass.Extensions[3].FloorInsulation == 1 | surveyClass.Extensions[3].FloorInsulation == 2)
          {
            string e3Age = this.Ext.Ages.E3Age;
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
                  goto label_689;
                else
                  goto default;
              case 3440116983:
                if (Operators.CompareString(e3Age, "H", false) == 0)
                  goto label_689;
                else
                  goto default;
              case 3456894602:
                if (Operators.CompareString(e3Age, "K", false) == 0)
                {
                  this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = 0.22f;
                  goto default;
                }
                else
                  goto default;
              case 3473672221:
                if (Operators.CompareString(e3Age, "J", false) == 0)
                {
                  this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = 0.25f;
                  goto default;
                }
                else
                  goto default;
              default:
label_692:
                goto label_693;
            }
            this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = 1.2f;
            goto label_692;
label_689:
            this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = 0.51f;
            goto label_692;
          }
label_693:
          if (surveyClass.Extensions[3].FloorInsulation == 3)
          {
            string e3Age = this.Ext.Ages.E3Age;
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
                  goto label_707;
                else
                  goto default;
              case 3440116983:
                if (Operators.CompareString(e3Age, "H", false) == 0)
                  goto label_707;
                else
                  goto default;
              case 3456894602:
                if (Operators.CompareString(e3Age, "K", false) == 0)
                {
                  this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = 0.22f;
                  goto default;
                }
                else
                  goto default;
              case 3473672221:
                if (Operators.CompareString(e3Age, "J", false) == 0)
                {
                  this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = 0.25f;
                  goto default;
                }
                else
                  goto default;
              default:
label_710:
                goto label_711;
            }
            this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = 0.5f;
            goto label_710;
label_707:
            this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = 0.5f;
            goto label_710;
          }
label_711:
          this.x.Floors[checked (this.x.Floors.Length - 1)].Name = "Overhangs E3";
          this.x.Floors[checked (this.x.Floors.Length - 1)].Type = "Exposed floor";
          this.x.Floors[checked (this.x.Floors.Length - 1)].Area = !(this.Ext.Exposed.A2_E3 < this.Ext.Exposed.A1_E3 & this.Ext.Exposed.A2_E3 != 0.0) ? (float) Math.Round(this.Ext.Exposed.A1_E3, 2) : (float) Math.Round(this.Ext.Exposed.A2_E3, 2);
        }
      }
      if (this.Ext.Ext4)
      {
        if (surveyClass.Extensions[4].LowestFloor == 5)
        {
          if (this.x.Floors != null)
          {
            // ISSUE: variable of a reference type
            SAP_Module.Opaques[]& local;
            // ISSUE: explicit reference operation
            SAP_Module.Opaques[] opaquesArray = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local = ref this.x.Floors), (Array) new SAP_Module.Opaques[checked (this.x.Floors.Length + 1)]);
            local = opaquesArray;
          }
          else
          {
            // ISSUE: variable of a reference type
            SAP_Module.Opaques[]& local;
            // ISSUE: explicit reference operation
            SAP_Module.Opaques[] opaquesArray = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local = ref this.x.Floors), (Array) new SAP_Module.Opaques[1]);
            local = opaquesArray;
          }
          this.x.Floors[checked (this.x.Floors.Length - 1)] = new SAP_Module.Opaques();
          if (surveyClass.General.Country == 4)
          {
            string e4Age = this.Ext.Ages.E4Age;
            // ISSUE: reference to a compiler-generated method
            switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(e4Age))
            {
              case 3222007936:
                if (Operators.CompareString(e4Age, "E", false) == 0)
                  break;
                goto label_771;
              case 3238785555:
                if (Operators.CompareString(e4Age, "D", false) == 0)
                  break;
                goto label_771;
              case 3255563174:
                if (Operators.CompareString(e4Age, "G", false) == 0)
                  break;
                goto label_771;
              case 3272340793:
                if (Operators.CompareString(e4Age, "F", false) == 0)
                  break;
                goto label_771;
              case 3289118412:
                if (Operators.CompareString(e4Age, "A", false) == 0)
                  break;
                goto label_771;
              case 3322673650:
                if (Operators.CompareString(e4Age, "C", false) == 0)
                  break;
                goto label_771;
              case 3339451269:
                if (Operators.CompareString(e4Age, "B", false) == 0)
                  break;
                goto label_771;
              case 3423339364:
                if (Operators.CompareString(e4Age, "I", false) == 0)
                {
                  num1 = 0.05f;
                  goto label_771;
                }
                else
                  goto label_771;
              case 3440116983:
                if (Operators.CompareString(e4Age, "H", false) == 0)
                {
                  num1 = 0.025f;
                  goto label_771;
                }
                else
                  goto label_771;
              case 3456894602:
                if (Operators.CompareString(e4Age, "K", false) == 0)
                {
                  num1 = 0.1f;
                  goto label_771;
                }
                else
                  goto label_771;
              case 3473672221:
                if (Operators.CompareString(e4Age, "J", false) == 0)
                {
                  num1 = 0.0f;
                  goto label_771;
                }
                else
                  goto label_771;
              default:
                goto label_771;
            }
            num1 = 0.0f;
          }
          else if (surveyClass.General.Country == 3)
          {
            string e4Age = this.Ext.Ages.E4Age;
            // ISSUE: reference to a compiler-generated method
            switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(e4Age))
            {
              case 3222007936:
                if (Operators.CompareString(e4Age, "E", false) == 0)
                  break;
                goto label_771;
              case 3238785555:
                if (Operators.CompareString(e4Age, "D", false) == 0)
                  break;
                goto label_771;
              case 3255563174:
                if (Operators.CompareString(e4Age, "G", false) == 0)
                  break;
                goto label_771;
              case 3272340793:
                if (Operators.CompareString(e4Age, "F", false) == 0)
                  break;
                goto label_771;
              case 3289118412:
                if (Operators.CompareString(e4Age, "A", false) == 0)
                  break;
                goto label_771;
              case 3322673650:
                if (Operators.CompareString(e4Age, "C", false) == 0)
                  break;
                goto label_771;
              case 3339451269:
                if (Operators.CompareString(e4Age, "B", false) == 0)
                  break;
                goto label_771;
              case 3423339364:
                if (Operators.CompareString(e4Age, "I", false) == 0)
                {
                  num1 = 0.05f;
                  goto label_771;
                }
                else
                  goto label_771;
              case 3440116983:
                if (Operators.CompareString(e4Age, "H", false) == 0)
                {
                  num1 = 0.025f;
                  goto label_771;
                }
                else
                  goto label_771;
              case 3456894602:
                if (Operators.CompareString(e4Age, "K", false) == 0)
                {
                  num1 = 0.1f;
                  goto label_771;
                }
                else
                  goto label_771;
              case 3473672221:
                if (Operators.CompareString(e4Age, "J", false) == 0)
                {
                  num1 = 0.075f;
                  goto label_771;
                }
                else
                  goto label_771;
              default:
                goto label_771;
            }
            num1 = 0.0f;
          }
          else
          {
            string e4Age = this.Ext.Ages.E4Age;
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
label_770:
                goto label_771;
            }
            num1 = 0.0f;
            goto label_770;
          }
label_771:
          if (surveyClass.Extensions[4].FloorInsulation == 3)
          {
            switch (surveyClass.Extensions[4].FloorInsulationThickness)
            {
              case 1:
                if ((double) num1 < 0.05)
                {
                  num1 = 0.05f;
                  break;
                }
                break;
              case 2:
                num1 = 0.05f;
                break;
              case 3:
                num1 = 0.1f;
                break;
              case 4:
                num1 = 0.15f;
                break;
            }
          }
          float num30 = 2f * this.x.Dims[checked (this.Ext.MStoreys + this.Ext.E1Storeys + this.Ext.E2Storeys + this.Ext.E3Storeys)].Area / this.x.Dims[checked (this.Ext.MStoreys + this.Ext.E1Storeys + this.Ext.E2Storeys + this.Ext.E3Storeys)].Perimeter;
          this.Ext.WallThickness.E4 = !surveyClass.Extensions[4].WallThicknessMeasured ? (double) this.GetWallThickNess(RdSAP, 4, false) : surveyClass.Extensions[4].WallThickness / 1000.0;
          if (surveyClass.Extensions[4].FloorConstruction == 1)
          {
            string e4Age = this.Ext.Ages.E4Age;
            if (Operators.CompareString(e4Age, "A", false) == 0 || Operators.CompareString(e4Age, "B", false) == 0)
            {
              float num31 = (float) (this.Ext.WallThickness.E4 + 0.315);
              this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = (float) Math.Round(1.0 / (0.54 + 1.0 / (3.0 * Math.Log(Math.PI * (double) num30 / (double) num31 + 1.0) / (Math.PI * (double) num30 + (double) num31) + (9.0 / 10.0 / (double) num30 + 87.0 / 80.0 / (double) num30))), 2);
            }
            else
            {
              float num32 = (float) (this.Ext.WallThickness.E4 + 1.5 * (0.17 + (double) num1 / 0.035 + 0.04));
              this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = (double) num32 >= (double) num30 ? (float) Math.Round(1.5 / (0.457 * (double) num30 + (double) num32), 2) : (float) Math.Round(3.0 * Math.Log(Math.PI * (double) num30 / (double) num32 + 1.0) / (Math.PI * (double) num30 + (double) num32), 2);
            }
          }
          else if (surveyClass.Extensions[4].FloorConstruction == 3 | surveyClass.Extensions[4].FloorConstruction == 4)
          {
            float num33 = (float) (this.Ext.WallThickness.E4 + 0.315);
            float num34 = (float) (3.0 * Math.Log(Math.PI * (double) num30 / (double) num33 + 1.0) / (Math.PI * (double) num30 + (double) num33));
            float num35 = (float) (9.0 / 10.0 / (double) num30 + 87.0 / 80.0 / (double) num30);
            this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = (float) Math.Round(1.0 / (0.34 + (double) num1 / 0.035 + 0.2 + 1.0 / ((double) num34 + (double) num35)), 2);
          }
          else if (surveyClass.Extensions[4].FloorConstruction == 2)
          {
            float num36 = (float) (this.Ext.WallThickness.E4 + 1.5 * (0.17 + (double) num1 / 0.035 + 0.04));
            this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = (double) num36 >= (double) num30 ? (float) Math.Round(1.5 / (0.457 * (double) num30 + (double) num36), 2) : (float) Math.Round(3.0 * Math.Log(Math.PI * (double) num30 / (double) num36 + 1.0) / (Math.PI * (double) num30 + (double) num36), 2);
          }
          this.x.Floors[checked (this.x.Floors.Length - 1)].Name = "Extention 4 Floor";
          this.x.Floors[checked (this.x.Floors.Length - 1)].Type = "Ground floor";
          this.x.Floors[checked (this.x.Floors.Length - 1)].Area = this.x.Dims[checked (this.Ext.MStoreys + this.Ext.E1Storeys + this.Ext.E2Storeys + this.Ext.E3Storeys)].Area;
        }
        else if (surveyClass.Extensions[4].LowestFloor == 3)
        {
          if (this.x.Floors != null)
          {
            // ISSUE: variable of a reference type
            SAP_Module.Opaques[]& local;
            // ISSUE: explicit reference operation
            SAP_Module.Opaques[] opaquesArray = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local = ref this.x.Floors), (Array) new SAP_Module.Opaques[checked (this.x.Floors.Length + 1)]);
            local = opaquesArray;
          }
          else
          {
            // ISSUE: variable of a reference type
            SAP_Module.Opaques[]& local;
            // ISSUE: explicit reference operation
            SAP_Module.Opaques[] opaquesArray = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local = ref this.x.Floors), (Array) new SAP_Module.Opaques[1]);
            local = opaquesArray;
          }
          this.x.Floors[checked (this.x.Floors.Length - 1)] = new SAP_Module.Opaques();
          this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = 0.7f;
          this.x.Floors[checked (this.x.Floors.Length - 1)].Name = "Extention 4 Floor";
          this.x.Floors[checked (this.x.Floors.Length - 1)].Type = "Exposed floor";
          this.x.Floors[checked (this.x.Floors.Length - 1)].Area = this.x.Dims[checked (this.Ext.MStoreys + this.Ext.E1Storeys + this.Ext.E2Storeys + this.Ext.E3Storeys)].Area;
        }
        else if (surveyClass.Extensions[4].LowestFloor == 2 | surveyClass.Extensions[4].LowestFloor == 1 | surveyClass.Extensions[4].LowestFloor == 7)
        {
          if (this.x.Floors != null)
          {
            // ISSUE: variable of a reference type
            SAP_Module.Opaques[]& local;
            // ISSUE: explicit reference operation
            SAP_Module.Opaques[] opaquesArray = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local = ref this.x.Floors), (Array) new SAP_Module.Opaques[checked (this.x.Floors.Length + 1)]);
            local = opaquesArray;
          }
          else
          {
            // ISSUE: variable of a reference type
            SAP_Module.Opaques[]& local;
            // ISSUE: explicit reference operation
            SAP_Module.Opaques[] opaquesArray = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local = ref this.x.Floors), (Array) new SAP_Module.Opaques[1]);
            local = opaquesArray;
          }
          this.x.Floors[checked (this.x.Floors.Length - 1)] = new SAP_Module.Opaques();
          if (surveyClass.Extensions[4].FloorInsulation == 1 | surveyClass.Extensions[4].FloorInsulation == 2)
          {
            string e4Age = this.Ext.Ages.E4Age;
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
                  goto label_811;
                else
                  goto default;
              case 3440116983:
                if (Operators.CompareString(e4Age, "H", false) == 0)
                  goto label_811;
                else
                  goto default;
              case 3456894602:
                if (Operators.CompareString(e4Age, "K", false) == 0)
                {
                  this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = 0.22f;
                  goto default;
                }
                else
                  goto default;
              case 3473672221:
                if (Operators.CompareString(e4Age, "J", false) == 0)
                {
                  this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = 0.25f;
                  goto default;
                }
                else
                  goto default;
              default:
label_814:
                goto label_815;
            }
            this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = 1.2f;
            goto label_814;
label_811:
            this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = 0.51f;
            goto label_814;
          }
label_815:
          if (surveyClass.Extensions[4].FloorInsulation == 3)
          {
            string e4Age = this.Ext.Ages.E4Age;
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
                  goto label_829;
                else
                  goto default;
              case 3440116983:
                if (Operators.CompareString(e4Age, "H", false) == 0)
                  goto label_829;
                else
                  goto default;
              case 3456894602:
                if (Operators.CompareString(e4Age, "K", false) == 0)
                {
                  this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = 0.22f;
                  goto default;
                }
                else
                  goto default;
              case 3473672221:
                if (Operators.CompareString(e4Age, "J", false) == 0)
                {
                  this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = 0.25f;
                  goto default;
                }
                else
                  goto default;
              default:
label_832:
                goto label_833;
            }
            this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = 0.5f;
            goto label_832;
label_829:
            this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = 0.5f;
            goto label_832;
          }
label_833:
          this.x.Floors[checked (this.x.Floors.Length - 1)].Name = "Extention 4 Floor";
          this.x.Floors[checked (this.x.Floors.Length - 1)].Type = surveyClass.Extensions[4].LowestFloor != 7 ? "Exposed floor" : "To External Air";
          this.x.Floors[checked (this.x.Floors.Length - 1)].Area = (float) Math.Round((double) this.x.Dims[checked (this.Ext.MStoreys + this.Ext.E1Storeys + this.Ext.E2Storeys + this.Ext.E3Storeys)].Area, 2);
        }
        else if (surveyClass.Extensions[4].LowestFloor == 4 | surveyClass.Extensions[4].LowestFloor == 6)
        {
          if (this.Ext.EPCFloors == null)
          {
            RdSAP_TO_SAP.Extensions ext;
            RdSAP_TO_SAP.EPCFloors[] epcFloorsArray = (RdSAP_TO_SAP.EPCFloors[]) Utils.CopyArray((Array) (ext = this.Ext).EPCFloors, (Array) new RdSAP_TO_SAP.EPCFloors[1]);
            ext.EPCFloors = epcFloorsArray;
            this.Ext.EPCFloors[0] = new RdSAP_TO_SAP.EPCFloors();
          }
          else
          {
            RdSAP_TO_SAP.Extensions ext;
            RdSAP_TO_SAP.EPCFloors[] epcFloorsArray = (RdSAP_TO_SAP.EPCFloors[]) Utils.CopyArray((Array) (ext = this.Ext).EPCFloors, (Array) new RdSAP_TO_SAP.EPCFloors[checked (this.Ext.EPCFloors.Length + 1)]);
            ext.EPCFloors = epcFloorsArray;
            this.Ext.EPCFloors[checked (this.Ext.EPCFloors.Length - 1)] = new RdSAP_TO_SAP.EPCFloors();
          }
          this.Ext.EPCFloors[checked (this.Ext.EPCFloors.Length - 1)].Area = (float) Math.Round((double) this.x.Dims[checked (this.Ext.MStoreys + this.Ext.E1Storeys + this.Ext.E2Storeys + this.Ext.E3Storeys)].Area, 2);
          this.Ext.EPCFloors[checked (this.Ext.EPCFloors.Length - 1)].Desc = "(other premises below)";
          this.Ext.EPCFloors[checked (this.Ext.EPCFloors.Length - 1)].Ext = 4;
          surveyClass.Extensions[4].FloorUValueKnown = false;
        }
        else if (surveyClass.Extensions[4].LowestFloor == 6)
        {
          if (this.Ext.EPCFloors == null)
          {
            RdSAP_TO_SAP.Extensions ext;
            RdSAP_TO_SAP.EPCFloors[] epcFloorsArray = (RdSAP_TO_SAP.EPCFloors[]) Utils.CopyArray((Array) (ext = this.Ext).EPCFloors, (Array) new RdSAP_TO_SAP.EPCFloors[1]);
            ext.EPCFloors = epcFloorsArray;
            this.Ext.EPCFloors[0] = new RdSAP_TO_SAP.EPCFloors();
          }
          else
          {
            RdSAP_TO_SAP.Extensions ext;
            RdSAP_TO_SAP.EPCFloors[] epcFloorsArray = (RdSAP_TO_SAP.EPCFloors[]) Utils.CopyArray((Array) (ext = this.Ext).EPCFloors, (Array) new RdSAP_TO_SAP.EPCFloors[checked (this.Ext.EPCFloors.Length + 1)]);
            ext.EPCFloors = epcFloorsArray;
            this.Ext.EPCFloors[checked (this.Ext.EPCFloors.Length - 1)] = new RdSAP_TO_SAP.EPCFloors();
          }
          this.Ext.EPCFloors[checked (this.Ext.EPCFloors.Length - 1)].Area = (float) Math.Round((double) this.x.Dims[checked (this.Ext.MStoreys + this.Ext.E1Storeys + this.Ext.E2Storeys + this.Ext.E3Storeys)].Area, 2);
          this.Ext.EPCFloors[checked (this.Ext.EPCFloors.Length - 1)].Desc = "(Same dwelling below)";
          this.Ext.EPCFloors[checked (this.Ext.EPCFloors.Length - 1)].Ext = 4;
          surveyClass.Extensions[4].FloorUValueKnown = false;
        }
        if (surveyClass.Extensions[4].FloorUValueKnown)
          this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = (float) surveyClass.Extensions[4].FloorUValue;
        if (surveyClass.Extensions[4].LowestFloor != 6 | surveyClass.Extensions[4].LowestFloor < 4)
        {
          if (this.x.Floors != null && string.IsNullOrEmpty(this.x.Floors[checked (this.x.Floors.Length - 1)].EPCDesc))
            this.x.Floors[checked (this.x.Floors.Length - 1)].EPCDesc = SAP_Module.Get_Enum_Desc(typeof (Enums.FloorConstructionCode), surveyClass.Extensions[4].FloorConstruction) + ", " + SAP_Module.Get_Enum_Desc(typeof (Enums.FloorInsulationCode), surveyClass.Extensions[4].FloorInsulation) + SAP_Module.Get_Enum_Desc(typeof (Enums.LowestFloorType), surveyClass.Extensions[4].LowestFloor);
          if (surveyClass.Extensions[4].FloorConstruction == 1 && this.x.Floors != null)
            this.x.Floors[checked (this.x.Floors.Length - 1)].Construction = SAP_Module.Get_Enum_Desc(typeof (Enums.FloorConstructionCode), surveyClass.Extensions[3].FloorConstruction);
        }
        if (this.Ext.Exposed.Include_E4)
        {
          if (this.x.Floors != null)
          {
            // ISSUE: variable of a reference type
            SAP_Module.Opaques[]& local;
            // ISSUE: explicit reference operation
            SAP_Module.Opaques[] opaquesArray = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local = ref this.x.Floors), (Array) new SAP_Module.Opaques[checked (this.x.Floors.Length + 1)]);
            local = opaquesArray;
          }
          else
          {
            // ISSUE: variable of a reference type
            SAP_Module.Opaques[]& local;
            // ISSUE: explicit reference operation
            SAP_Module.Opaques[] opaquesArray = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local = ref this.x.Floors), (Array) new SAP_Module.Opaques[1]);
            local = opaquesArray;
          }
          this.x.Floors[checked (this.x.Floors.Length - 1)] = new SAP_Module.Opaques();
          if (surveyClass.Extensions[4].FloorInsulation == 1 | surveyClass.Extensions[4].FloorInsulation == 2)
          {
            string e4Age = this.Ext.Ages.E4Age;
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
                  goto label_870;
                else
                  goto default;
              case 3440116983:
                if (Operators.CompareString(e4Age, "H", false) == 0)
                  goto label_870;
                else
                  goto default;
              case 3456894602:
                if (Operators.CompareString(e4Age, "K", false) == 0)
                {
                  this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = 0.22f;
                  goto default;
                }
                else
                  goto default;
              case 3473672221:
                if (Operators.CompareString(e4Age, "J", false) == 0)
                {
                  this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = 0.25f;
                  goto default;
                }
                else
                  goto default;
              default:
label_873:
                goto label_874;
            }
            this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = 1.2f;
            goto label_873;
label_870:
            this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = 0.51f;
            goto label_873;
          }
label_874:
          if (surveyClass.Extensions[4].FloorInsulation == 3)
          {
            string e4Age = this.Ext.Ages.E4Age;
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
                  goto label_888;
                else
                  goto default;
              case 3440116983:
                if (Operators.CompareString(e4Age, "H", false) == 0)
                  goto label_888;
                else
                  goto default;
              case 3456894602:
                if (Operators.CompareString(e4Age, "K", false) == 0)
                {
                  this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = 0.22f;
                  goto default;
                }
                else
                  goto default;
              case 3473672221:
                if (Operators.CompareString(e4Age, "J", false) == 0)
                {
                  this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = 0.25f;
                  goto default;
                }
                else
                  goto default;
              default:
label_891:
                goto label_892;
            }
            this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = 0.5f;
            goto label_891;
label_888:
            this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = 0.5f;
            goto label_891;
          }
label_892:
          this.x.Floors[checked (this.x.Floors.Length - 1)].Name = "Overhangs E4";
          this.x.Floors[checked (this.x.Floors.Length - 1)].Type = "Exposed floor";
          this.x.Floors[checked (this.x.Floors.Length - 1)].Area = !(this.Ext.Exposed.A2_E4 < this.Ext.Exposed.A1_E4 & this.Ext.Exposed.A2_E4 != 0.0) ? (float) Math.Round(this.Ext.Exposed.A1_E4, 2) : (float) Math.Round(this.Ext.Exposed.A2_E4, 2);
        }
      }
      if (this.Ext.Cons)
      {
        if (this.x.Floors != null)
        {
          // ISSUE: variable of a reference type
          SAP_Module.Opaques[]& local;
          // ISSUE: explicit reference operation
          SAP_Module.Opaques[] opaquesArray = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local = ref this.x.Floors), (Array) new SAP_Module.Opaques[checked (this.x.Floors.Length + 1)]);
          local = opaquesArray;
        }
        else
        {
          // ISSUE: variable of a reference type
          SAP_Module.Opaques[]& local;
          // ISSUE: explicit reference operation
          SAP_Module.Opaques[] opaquesArray = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local = ref this.x.Floors), (Array) new SAP_Module.Opaques[1]);
          local = opaquesArray;
        }
        this.x.Floors[checked (this.x.Floors.Length - 1)] = new SAP_Module.Opaques();
        this.x.Floors[checked (this.x.Floors.Length - 1)].Name = "Conservatory";
        this.x.Floors[checked (this.x.Floors.Length - 1)].Type = "Ground floor";
        this.x.Floors[checked (this.x.Floors.Length - 1)].Area = this.x.Dims[checked (this.x.Dims.Length - 1)].Area;
        float num37 = 2f * this.x.Dims[checked (this.x.Dims.Length - 1)].Area / this.x.Dims[checked (this.x.Dims.Length - 1)].Perimeter;
        float num38 = 0.615f;
        this.x.Floors[checked (this.x.Floors.Length - 1)].U_Value = (double) num38 >= (double) num37 ? (float) Math.Round(1.5 / (0.457 * (double) num37 + (double) num38), 2) : (float) Math.Round(3.0 * Math.Log(Math.PI * (double) num37 / (double) num38 + 1.0) / (Math.PI * (double) num37 + (double) num38), 2);
        if (this.x.Floors != null)
          this.x.Floors[checked (this.x.Floors.Length - 1)].EPCDesc = "Conservatory";
      }
      this.x.NoofFloors = this.x.Floors == null ? 0 : this.x.Floors.Length;
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
          closure_0 = !(wallInsulationCode != Enums.WallInsulationCode.Internal & wallInsulationCode != Enums.WallInsulationCode.External) ? "Stone + insulation" : "Stone as built";
          break;
        case Enums.WallConstructionCode.Sandstone:
          closure_0 = !(wallInsulationCode != Enums.WallInsulationCode.Internal & wallInsulationCode != Enums.WallInsulationCode.External) ? "Stone + insulation" : "Stone as built";
          break;
        case Enums.WallConstructionCode.Solid_brick:
          closure_0 = !(wallInsulationCode != Enums.WallInsulationCode.Internal & wallInsulationCode != Enums.WallInsulationCode.External) ? "Solid Brick + insulation" : "Solid Brick";
          break;
        case Enums.WallConstructionCode.Cavity:
          switch (wallInsulationCode)
          {
            case Enums.WallInsulationCode.External:
            case Enums.WallInsulationCode.Internal:
            case Enums.WallInsulationCode.Filled_cavity_external:
            case Enums.WallInsulationCode.Filled_cavity_internal:
              closure_0 = "Cavity + insulation";
              break;
            default:
              closure_0 = "Cavity";
              break;
          }
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
          this.Ext.FloorType.M = closure_0;
          Right = this.Ext.Ages.MAge;
          break;
        case 1:
          this.Ext.FloorType.E1 = closure_0;
          Right = this.Ext.Ages.E1Age;
          break;
        case 2:
          this.Ext.FloorType.E2 = closure_0;
          Right = this.Ext.Ages.E2Age;
          break;
        case 3:
          this.Ext.FloorType.E3 = closure_0;
          Right = this.Ext.Ages.E3Age;
          break;
        case 4:
          this.Ext.FloorType.M = closure_0;
          Right = this.Ext.Ages.E4Age;
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

    private void Walls(Survey_Class RdSAP)
    {
      Survey_Class surveyClass = RdSAP;
      this.x.Walls = new SAP_Module.Opaques[1];
      this.x.Walls[checked (this.x.Walls.Length - 1)] = new SAP_Module.Opaques();
      int num1 = checked (this.Ext.MStoreys - 1);
      int index1 = 0;
      while (index1 <= num1)
      {
        if (this.x.Dims[index1].Type != 3)
        {
          // ISSUE: variable of a reference type
          float& local;
          // ISSUE: explicit reference operation
          double num2 = (double) ^(local = ref this.x.Walls[0].Area) + (double) this.x.Dims[index1].Perimeter * (double) this.x.Dims[index1].Height;
          local = (float) num2;
        }
        checked { ++index1; }
      }
      if (surveyClass.Extensions[0].AltPresent)
      {
        if (surveyClass.Extensions[0].AltShelteredWall == 1 & (surveyClass.General.PropertyType1 == 3 | surveyClass.General.PropertyType1 == 4))
        {
          // ISSUE: variable of a reference type
          float& local;
          // ISSUE: explicit reference operation
          double num3 = (double) (^(local = ref this.x.Walls[0].Area) - (float) Math.Round((double) this.x.Dims[0].Height * surveyClass.Flat_Maisonette.UnHeatedCorridorLength, 2));
          local = (float) num3;
        }
        else
        {
          // ISSUE: variable of a reference type
          float& local;
          // ISSUE: explicit reference operation
          double num4 = (double) (^(local = ref this.x.Walls[0].Area) - (float) surveyClass.Extensions[0].AltWallArea);
          local = (float) num4;
        }
      }
      this.x.Walls[0].Name = "Main Wall";
      this.x.Walls[0].Type = "Exposed wall";
      this.x.Walls[0].Construction = "";
      this.x.Walls[0].U_Value = this.WallUValue(RdSAP, this.Ext.Ages.MAge, 0, false);
      this.x.Walls[0].Ru = 0.0f;
      this.x.Walls[0].Curtain = false;
      this.x.Walls[0].K = 0.0f;
      this.x.Walls[0].Area = (float) Math.Round((double) this.x.Walls[0].Area, 2);
      this.x.Walls[0].EPCDesc = SAP_Module.Get_Enum_Desc(typeof (Enums.WallConstructionCode), surveyClass.Extensions[0].WallConstruction) + ", " + SAP_Module.Get_Enum_Desc(typeof (Enums.WallInsulationCode), surveyClass.Extensions[0].WallInsulation);
      if (this.Ext.MainRoof)
      {
        if (!surveyClass.Extensions[0].RoofRoom_Edit)
        {
          // ISSUE: variable of a reference type
          SAP_Module.Opaques[]& local;
          // ISSUE: explicit reference operation
          SAP_Module.Opaques[] opaquesArray = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local = ref this.x.Walls), (Array) new SAP_Module.Opaques[checked (this.x.Walls.Length + 1)]);
          local = opaquesArray;
          this.x.Walls[checked (this.x.Walls.Length - 1)] = new SAP_Module.Opaques();
          this.x.Walls[checked (this.x.Walls.Length - 1)].Area = !surveyClass.Extensions[0].RoomRoofConnected ? (float) Math.Round(11.0 * Math.Sqrt(surveyClass.Extensions[0].RoofRoomFloor_Area / 1.5), 2) : (float) Math.Round(8.25 * Math.Sqrt(surveyClass.Extensions[0].RoofRoomFloor_Area / 1.5), 2);
          this.x.Walls[checked (this.x.Walls.Length - 1)].Name = "Main Roof Room";
          this.x.Walls[checked (this.x.Walls.Length - 1)].Type = "Exposed wall";
          this.x.Walls[checked (this.x.Walls.Length - 1)].Construction = "";
          this.x.Walls[checked (this.x.Walls.Length - 1)].U_Value = this.RoofRoomUValue(RdSAP, 0, "Wall");
          this.x.Walls[checked (this.x.Walls.Length - 1)].Ru = 0.0f;
          this.x.Walls[checked (this.x.Walls.Length - 1)].Curtain = false;
          this.x.Walls[checked (this.x.Walls.Length - 1)].K = 0.0f;
        }
        else
        {
          if (surveyClass.Extensions[0].RoofRoom_GableWall[0].Area != 0.0)
          {
            // ISSUE: variable of a reference type
            SAP_Module.Opaques[]& local;
            // ISSUE: explicit reference operation
            SAP_Module.Opaques[] opaquesArray = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local = ref this.x.Walls), (Array) new SAP_Module.Opaques[checked (this.x.Walls.Length + 1)]);
            local = opaquesArray;
            this.x.Walls[checked (this.x.Walls.Length - 1)] = new SAP_Module.Opaques();
            this.x.Walls[checked (this.x.Walls.Length - 1)].Area = (float) surveyClass.Extensions[0].RoofRoom_GableWall[0].Area;
            this.x.Walls[checked (this.x.Walls.Length - 1)].U_Value = (float) surveyClass.Extensions[0].RoofRoom_GableWall[0].U_Value;
            this.x.Walls[checked (this.x.Walls.Length - 1)].Name = "Main Roof Room Gable Wall 1";
          }
          if (surveyClass.Extensions[0].RoofRoom_GableWall[1].Area != 0.0)
          {
            // ISSUE: variable of a reference type
            SAP_Module.Opaques[]& local;
            // ISSUE: explicit reference operation
            SAP_Module.Opaques[] opaquesArray = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local = ref this.x.Walls), (Array) new SAP_Module.Opaques[checked (this.x.Walls.Length + 1)]);
            local = opaquesArray;
            this.x.Walls[checked (this.x.Walls.Length - 1)] = new SAP_Module.Opaques();
            this.x.Walls[checked (this.x.Walls.Length - 1)].Area = (float) surveyClass.Extensions[0].RoofRoom_GableWall[1].Area;
            this.x.Walls[checked (this.x.Walls.Length - 1)].U_Value = (float) surveyClass.Extensions[0].RoofRoom_GableWall[1].U_Value;
            this.x.Walls[checked (this.x.Walls.Length - 1)].Name = "Main Roof Room Gable Wall 2";
          }
          if (surveyClass.Extensions[0].RoofRoom_StudWall[0].Area != 0.0)
          {
            // ISSUE: variable of a reference type
            SAP_Module.Opaques[]& local;
            // ISSUE: explicit reference operation
            SAP_Module.Opaques[] opaquesArray = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local = ref this.x.Walls), (Array) new SAP_Module.Opaques[checked (this.x.Walls.Length + 1)]);
            local = opaquesArray;
            this.x.Walls[checked (this.x.Walls.Length - 1)] = new SAP_Module.Opaques();
            this.x.Walls[checked (this.x.Walls.Length - 1)].Area = (float) surveyClass.Extensions[0].RoofRoom_StudWall[0].Area;
            this.x.Walls[checked (this.x.Walls.Length - 1)].U_Value = (float) surveyClass.Extensions[0].RoofRoom_StudWall[0].U_Value;
            this.x.Walls[checked (this.x.Walls.Length - 1)].Name = "Main Roof Room Gable Wall 1";
          }
          if (surveyClass.Extensions[0].RoofRoom_StudWall[1].Area != 0.0)
          {
            // ISSUE: variable of a reference type
            SAP_Module.Opaques[]& local;
            // ISSUE: explicit reference operation
            SAP_Module.Opaques[] opaquesArray = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local = ref this.x.Walls), (Array) new SAP_Module.Opaques[checked (this.x.Walls.Length + 1)]);
            local = opaquesArray;
            this.x.Walls[checked (this.x.Walls.Length - 1)] = new SAP_Module.Opaques();
            this.x.Walls[checked (this.x.Walls.Length - 1)].Area = (float) surveyClass.Extensions[0].RoofRoom_StudWall[1].Area;
            this.x.Walls[checked (this.x.Walls.Length - 1)].U_Value = (float) surveyClass.Extensions[0].RoofRoom_StudWall[1].U_Value;
            this.x.Walls[checked (this.x.Walls.Length - 1)].Name = "Main Roof Room Gable Wall 2";
          }
        }
      }
      if (this.Ext.Ext1)
      {
        // ISSUE: variable of a reference type
        SAP_Module.Opaques[]& local1;
        // ISSUE: explicit reference operation
        SAP_Module.Opaques[] opaquesArray1 = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local1 = ref this.x.Walls), (Array) new SAP_Module.Opaques[checked (this.x.Walls.Length + 1)]);
        local1 = opaquesArray1;
        this.x.Walls[checked (this.x.Walls.Length - 1)] = new SAP_Module.Opaques();
        int mstoreys = this.Ext.MStoreys;
        int num5 = checked (this.Ext.MStoreys + this.Ext.E1Storeys - 1);
        int index2 = mstoreys;
        while (index2 <= num5)
        {
          if (this.x.Dims[index2].Type != 3)
          {
            // ISSUE: variable of a reference type
            float& local2;
            // ISSUE: explicit reference operation
            double num6 = (double) ^(local2 = ref this.x.Walls[checked (this.x.Walls.Length - 1)].Area) + (double) this.x.Dims[index2].Perimeter * (double) this.x.Dims[index2].Height;
            local2 = (float) num6;
          }
          checked { ++index2; }
        }
        if (surveyClass.Extensions[1].AltPresent)
        {
          // ISSUE: variable of a reference type
          float& local3;
          // ISSUE: explicit reference operation
          double num7 = (double) (^(local3 = ref this.x.Walls[checked (this.x.Walls.Length - 1)].Area) - (float) surveyClass.Extensions[1].AltWallArea);
          local3 = (float) num7;
        }
        this.x.Walls[checked (this.x.Walls.Length - 1)].Name = "Extension 1 Wall";
        this.x.Walls[checked (this.x.Walls.Length - 1)].Type = "Exposed wall";
        this.x.Walls[checked (this.x.Walls.Length - 1)].Construction = "";
        this.x.Walls[checked (this.x.Walls.Length - 1)].U_Value = this.WallUValue(RdSAP, this.Ext.Ages.E1Age, 1, false);
        this.x.Walls[checked (this.x.Walls.Length - 1)].Ru = 0.0f;
        this.x.Walls[checked (this.x.Walls.Length - 1)].Curtain = false;
        this.x.Walls[checked (this.x.Walls.Length - 1)].K = 0.0f;
        this.x.Walls[checked (this.x.Walls.Length - 1)].Area = (float) Math.Round((double) this.x.Walls[checked (this.x.Walls.Length - 1)].Area, 2);
        this.x.Walls[checked (this.x.Walls.Length - 1)].EPCDesc = SAP_Module.Get_Enum_Desc(typeof (Enums.WallConstructionCode), surveyClass.Extensions[1].WallConstruction) + ", " + SAP_Module.Get_Enum_Desc(typeof (Enums.WallInsulationCode), surveyClass.Extensions[1].WallInsulation);
        if (this.Ext.Ext1Roof)
        {
          if (!surveyClass.Extensions[1].RoofRoom_Edit)
          {
            // ISSUE: variable of a reference type
            SAP_Module.Opaques[]& local4;
            // ISSUE: explicit reference operation
            SAP_Module.Opaques[] opaquesArray2 = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local4 = ref this.x.Walls), (Array) new SAP_Module.Opaques[checked (this.x.Walls.Length + 1)]);
            local4 = opaquesArray2;
            this.x.Walls[checked (this.x.Walls.Length - 1)] = new SAP_Module.Opaques();
            bool flag = false;
            if (this.Ext.MStoreys == this.Ext.E1Storeys & this.Ext.MainRoof)
              flag = true;
            if (this.Ext.MStoreys > this.Ext.E1Storeys)
              flag = true;
            if (this.Ext.E2Storeys == this.Ext.E1Storeys & this.Ext.Ext2Roof)
              flag = true;
            if (this.Ext.E2Storeys > this.Ext.E1Storeys)
              flag = true;
            if (this.Ext.E3Storeys == this.Ext.E1Storeys & this.Ext.Ext3Roof)
              flag = true;
            if (this.Ext.E3Storeys > this.Ext.E1Storeys)
              flag = true;
            if (this.Ext.E4Storeys == this.Ext.E1Storeys & this.Ext.Ext4Roof)
              flag = true;
            if (this.Ext.E4Storeys > this.Ext.E1Storeys)
              flag = true;
            this.x.Walls[checked (this.x.Walls.Length - 1)].Area = !flag ? (float) Math.Round(11.0 * Math.Sqrt(surveyClass.Extensions[1].RoofRoomFloor_Area / 1.5), 2) : (float) Math.Round(8.25 * Math.Sqrt(surveyClass.Extensions[1].RoofRoomFloor_Area / 1.5), 2);
            this.x.Walls[checked (this.x.Walls.Length - 1)].Name = "Extension 1 Roof Room";
            this.x.Walls[checked (this.x.Walls.Length - 1)].Type = "Exposed wall";
            this.x.Walls[checked (this.x.Walls.Length - 1)].Construction = "";
            this.x.Walls[checked (this.x.Walls.Length - 1)].U_Value = this.RoofRoomUValue(RdSAP, 1, "Wall");
            this.x.Walls[checked (this.x.Walls.Length - 1)].Ru = 0.0f;
            this.x.Walls[checked (this.x.Walls.Length - 1)].Curtain = false;
            this.x.Walls[checked (this.x.Walls.Length - 1)].K = 0.0f;
          }
          else
          {
            if (surveyClass.Extensions[1].RoofRoom_GableWall[0].Area != 0.0)
            {
              // ISSUE: variable of a reference type
              SAP_Module.Opaques[]& local5;
              // ISSUE: explicit reference operation
              SAP_Module.Opaques[] opaquesArray3 = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local5 = ref this.x.Walls), (Array) new SAP_Module.Opaques[checked (this.x.Walls.Length + 1)]);
              local5 = opaquesArray3;
              this.x.Walls[checked (this.x.Walls.Length - 1)] = new SAP_Module.Opaques();
              this.x.Walls[checked (this.x.Walls.Length - 1)].Area = (float) surveyClass.Extensions[1].RoofRoom_GableWall[0].Area;
              this.x.Walls[checked (this.x.Walls.Length - 1)].U_Value = (float) surveyClass.Extensions[1].RoofRoom_GableWall[0].U_Value;
              this.x.Walls[checked (this.x.Walls.Length - 1)].Name = "E1 Roof Room Gable Wall 1";
            }
            if (surveyClass.Extensions[1].RoofRoom_GableWall[1].Area != 0.0)
            {
              // ISSUE: variable of a reference type
              SAP_Module.Opaques[]& local6;
              // ISSUE: explicit reference operation
              SAP_Module.Opaques[] opaquesArray4 = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local6 = ref this.x.Walls), (Array) new SAP_Module.Opaques[checked (this.x.Walls.Length + 1)]);
              local6 = opaquesArray4;
              this.x.Walls[checked (this.x.Walls.Length - 1)] = new SAP_Module.Opaques();
              this.x.Walls[checked (this.x.Walls.Length - 1)].Area = (float) surveyClass.Extensions[1].RoofRoom_GableWall[1].Area;
              this.x.Walls[checked (this.x.Walls.Length - 1)].U_Value = (float) surveyClass.Extensions[1].RoofRoom_GableWall[1].U_Value;
              this.x.Walls[checked (this.x.Walls.Length - 1)].Name = "E1 Roof Room Gable Wall 2";
            }
            if (surveyClass.Extensions[1].RoofRoom_StudWall[0].Area != 0.0)
            {
              // ISSUE: variable of a reference type
              SAP_Module.Opaques[]& local7;
              // ISSUE: explicit reference operation
              SAP_Module.Opaques[] opaquesArray5 = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local7 = ref this.x.Walls), (Array) new SAP_Module.Opaques[checked (this.x.Walls.Length + 1)]);
              local7 = opaquesArray5;
              this.x.Walls[checked (this.x.Walls.Length - 1)] = new SAP_Module.Opaques();
              this.x.Walls[checked (this.x.Walls.Length - 1)].Area = (float) surveyClass.Extensions[1].RoofRoom_StudWall[0].Area;
              this.x.Walls[checked (this.x.Walls.Length - 1)].U_Value = (float) surveyClass.Extensions[1].RoofRoom_StudWall[0].U_Value;
              this.x.Walls[checked (this.x.Walls.Length - 1)].Name = "E1 Roof Room Stud Wall 1";
            }
            if (surveyClass.Extensions[1].RoofRoom_StudWall[1].Area != 0.0)
            {
              // ISSUE: variable of a reference type
              SAP_Module.Opaques[]& local8;
              // ISSUE: explicit reference operation
              SAP_Module.Opaques[] opaquesArray6 = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local8 = ref this.x.Walls), (Array) new SAP_Module.Opaques[checked (this.x.Walls.Length + 1)]);
              local8 = opaquesArray6;
              this.x.Walls[checked (this.x.Walls.Length - 1)] = new SAP_Module.Opaques();
              this.x.Walls[checked (this.x.Walls.Length - 1)].Area = (float) surveyClass.Extensions[1].RoofRoom_StudWall[1].Area;
              this.x.Walls[checked (this.x.Walls.Length - 1)].U_Value = (float) surveyClass.Extensions[1].RoofRoom_StudWall[1].U_Value;
              this.x.Walls[checked (this.x.Walls.Length - 1)].Name = "E1 Roof Room Stud Wall 2";
            }
          }
        }
      }
      if (this.Ext.Ext2)
      {
        // ISSUE: variable of a reference type
        SAP_Module.Opaques[]& local9;
        // ISSUE: explicit reference operation
        SAP_Module.Opaques[] opaquesArray7 = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local9 = ref this.x.Walls), (Array) new SAP_Module.Opaques[checked (this.x.Walls.Length + 1)]);
        local9 = opaquesArray7;
        this.x.Walls[checked (this.x.Walls.Length - 1)] = new SAP_Module.Opaques();
        int num8 = checked (this.Ext.MStoreys + this.Ext.E1Storeys);
        int num9 = checked (this.Ext.MStoreys + this.Ext.E1Storeys + this.Ext.E2Storeys - 1);
        int index3 = num8;
        while (index3 <= num9)
        {
          if (this.x.Dims[index3].Type != 3)
          {
            // ISSUE: variable of a reference type
            float& local10;
            // ISSUE: explicit reference operation
            double num10 = (double) ^(local10 = ref this.x.Walls[checked (this.x.Walls.Length - 1)].Area) + (double) this.x.Dims[index3].Perimeter * (double) this.x.Dims[index3].Height;
            local10 = (float) num10;
          }
          checked { ++index3; }
        }
        if (surveyClass.Extensions[2].AltPresent)
        {
          // ISSUE: variable of a reference type
          float& local11;
          // ISSUE: explicit reference operation
          double num11 = (double) (^(local11 = ref this.x.Walls[checked (this.x.Walls.Length - 1)].Area) - (float) surveyClass.Extensions[2].AltWallArea);
          local11 = (float) num11;
        }
        this.x.Walls[checked (this.x.Walls.Length - 1)].Name = "Extension 2 Wall";
        this.x.Walls[checked (this.x.Walls.Length - 1)].Type = "Exposed wall";
        this.x.Walls[checked (this.x.Walls.Length - 1)].Construction = "";
        this.x.Walls[checked (this.x.Walls.Length - 1)].U_Value = this.WallUValue(RdSAP, this.Ext.Ages.E2Age, 2, false);
        this.x.Walls[checked (this.x.Walls.Length - 1)].Ru = 0.0f;
        this.x.Walls[checked (this.x.Walls.Length - 1)].Curtain = false;
        this.x.Walls[checked (this.x.Walls.Length - 1)].K = 0.0f;
        this.x.Walls[checked (this.x.Walls.Length - 1)].Area = (float) Math.Round((double) this.x.Walls[checked (this.x.Walls.Length - 1)].Area, 2);
        this.x.Walls[checked (this.x.Walls.Length - 1)].EPCDesc = SAP_Module.Get_Enum_Desc(typeof (Enums.WallConstructionCode), surveyClass.Extensions[2].WallConstruction) + ", " + SAP_Module.Get_Enum_Desc(typeof (Enums.WallInsulationCode), surveyClass.Extensions[2].WallInsulation);
        if (this.Ext.Ext2Roof)
        {
          if (!surveyClass.Extensions[2].RoofRoom_Edit)
          {
            // ISSUE: variable of a reference type
            SAP_Module.Opaques[]& local12;
            // ISSUE: explicit reference operation
            SAP_Module.Opaques[] opaquesArray8 = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local12 = ref this.x.Walls), (Array) new SAP_Module.Opaques[checked (this.x.Walls.Length + 1)]);
            local12 = opaquesArray8;
            this.x.Walls[checked (this.x.Walls.Length - 1)] = new SAP_Module.Opaques();
            bool flag = false;
            if (this.Ext.MStoreys == this.Ext.E2Storeys & this.Ext.MainRoof)
              flag = true;
            if (this.Ext.MStoreys > this.Ext.E2Storeys)
              flag = true;
            if (this.Ext.E1Storeys == this.Ext.E2Storeys & this.Ext.Ext1Roof)
              flag = true;
            if (this.Ext.E1Storeys > this.Ext.E2Storeys)
              flag = true;
            if (this.Ext.E3Storeys == this.Ext.E2Storeys & this.Ext.Ext3Roof)
              flag = true;
            if (this.Ext.E3Storeys > this.Ext.E2Storeys)
              flag = true;
            if (this.Ext.E4Storeys == this.Ext.E2Storeys & this.Ext.Ext4Roof)
              flag = true;
            if (this.Ext.E4Storeys > this.Ext.E2Storeys)
              flag = true;
            this.x.Walls[checked (this.x.Walls.Length - 1)].Area = !flag ? (float) Math.Round(11.0 * Math.Sqrt(surveyClass.Extensions[2].RoofRoomFloor_Area / 1.5), 2) : (float) Math.Round(8.25 * Math.Sqrt(surveyClass.Extensions[2].RoofRoomFloor_Area / 1.5), 2);
            this.x.Walls[checked (this.x.Walls.Length - 1)].Name = "Extension 2 Roof Room";
            this.x.Walls[checked (this.x.Walls.Length - 1)].Type = "Exposed wall";
            this.x.Walls[checked (this.x.Walls.Length - 1)].Construction = "";
            this.x.Walls[checked (this.x.Walls.Length - 1)].U_Value = this.RoofRoomUValue(RdSAP, 2, "Wall");
            this.x.Walls[checked (this.x.Walls.Length - 1)].Ru = 0.0f;
            this.x.Walls[checked (this.x.Walls.Length - 1)].Curtain = false;
            this.x.Walls[checked (this.x.Walls.Length - 1)].K = 0.0f;
          }
          else
          {
            if (surveyClass.Extensions[2].RoofRoom_GableWall[0].Area != 0.0)
            {
              // ISSUE: variable of a reference type
              SAP_Module.Opaques[]& local13;
              // ISSUE: explicit reference operation
              SAP_Module.Opaques[] opaquesArray9 = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local13 = ref this.x.Walls), (Array) new SAP_Module.Opaques[checked (this.x.Walls.Length + 1)]);
              local13 = opaquesArray9;
              this.x.Walls[checked (this.x.Walls.Length - 1)] = new SAP_Module.Opaques();
              this.x.Walls[checked (this.x.Walls.Length - 1)].Area = (float) surveyClass.Extensions[2].RoofRoom_GableWall[0].Area;
              this.x.Walls[checked (this.x.Walls.Length - 1)].U_Value = (float) surveyClass.Extensions[2].RoofRoom_GableWall[0].U_Value;
              this.x.Walls[checked (this.x.Walls.Length - 1)].Name = "E2 Roof Room Gable Wall 1";
            }
            if (surveyClass.Extensions[2].RoofRoom_GableWall[1].Area != 0.0)
            {
              // ISSUE: variable of a reference type
              SAP_Module.Opaques[]& local14;
              // ISSUE: explicit reference operation
              SAP_Module.Opaques[] opaquesArray10 = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local14 = ref this.x.Walls), (Array) new SAP_Module.Opaques[checked (this.x.Walls.Length + 1)]);
              local14 = opaquesArray10;
              this.x.Walls[checked (this.x.Walls.Length - 1)] = new SAP_Module.Opaques();
              this.x.Walls[checked (this.x.Walls.Length - 1)].Area = (float) surveyClass.Extensions[2].RoofRoom_GableWall[1].Area;
              this.x.Walls[checked (this.x.Walls.Length - 1)].U_Value = (float) surveyClass.Extensions[2].RoofRoom_GableWall[1].U_Value;
              this.x.Walls[checked (this.x.Walls.Length - 1)].Name = "E2 Roof Room Gable Wall 2";
            }
            if (surveyClass.Extensions[2].RoofRoom_StudWall[0].Area != 0.0)
            {
              // ISSUE: variable of a reference type
              SAP_Module.Opaques[]& local15;
              // ISSUE: explicit reference operation
              SAP_Module.Opaques[] opaquesArray11 = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local15 = ref this.x.Walls), (Array) new SAP_Module.Opaques[checked (this.x.Walls.Length + 1)]);
              local15 = opaquesArray11;
              this.x.Walls[checked (this.x.Walls.Length - 1)] = new SAP_Module.Opaques();
              this.x.Walls[checked (this.x.Walls.Length - 1)].Area = (float) surveyClass.Extensions[2].RoofRoom_StudWall[0].Area;
              this.x.Walls[checked (this.x.Walls.Length - 1)].U_Value = (float) surveyClass.Extensions[2].RoofRoom_StudWall[0].U_Value;
              this.x.Walls[checked (this.x.Walls.Length - 1)].Name = "E2 Roof Room Stud Wall 1";
            }
            if (surveyClass.Extensions[2].RoofRoom_StudWall[1].Area != 0.0)
            {
              // ISSUE: variable of a reference type
              SAP_Module.Opaques[]& local16;
              // ISSUE: explicit reference operation
              SAP_Module.Opaques[] opaquesArray12 = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local16 = ref this.x.Walls), (Array) new SAP_Module.Opaques[checked (this.x.Walls.Length + 1)]);
              local16 = opaquesArray12;
              this.x.Walls[checked (this.x.Walls.Length - 1)] = new SAP_Module.Opaques();
              this.x.Walls[checked (this.x.Walls.Length - 1)].Area = (float) surveyClass.Extensions[2].RoofRoom_StudWall[1].Area;
              this.x.Walls[checked (this.x.Walls.Length - 1)].U_Value = (float) surveyClass.Extensions[2].RoofRoom_StudWall[1].U_Value;
              this.x.Walls[checked (this.x.Walls.Length - 1)].Name = "E2 Roof Room Stud Wall 2";
            }
          }
        }
      }
      if (this.Ext.Ext3)
      {
        // ISSUE: variable of a reference type
        SAP_Module.Opaques[]& local17;
        // ISSUE: explicit reference operation
        SAP_Module.Opaques[] opaquesArray13 = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local17 = ref this.x.Walls), (Array) new SAP_Module.Opaques[checked (this.x.Walls.Length + 1)]);
        local17 = opaquesArray13;
        this.x.Walls[checked (this.x.Walls.Length - 1)] = new SAP_Module.Opaques();
        int num12 = checked (this.Ext.MStoreys + this.Ext.E1Storeys + this.Ext.E2Storeys);
        int num13 = checked (this.Ext.MStoreys + this.Ext.E1Storeys + this.Ext.E2Storeys + this.Ext.E3Storeys - 1);
        int index4 = num12;
        while (index4 <= num13)
        {
          if (this.x.Dims[index4].Type != 3)
          {
            // ISSUE: variable of a reference type
            float& local18;
            // ISSUE: explicit reference operation
            double num14 = (double) ^(local18 = ref this.x.Walls[checked (this.x.Walls.Length - 1)].Area) + (double) this.x.Dims[index4].Perimeter * (double) this.x.Dims[index4].Height;
            local18 = (float) num14;
          }
          checked { ++index4; }
        }
        if (surveyClass.Extensions[3].AltPresent)
        {
          // ISSUE: variable of a reference type
          float& local19;
          // ISSUE: explicit reference operation
          double num15 = (double) (^(local19 = ref this.x.Walls[checked (this.x.Walls.Length - 1)].Area) - (float) surveyClass.Extensions[3].AltWallArea);
          local19 = (float) num15;
        }
        this.x.Walls[checked (this.x.Walls.Length - 1)].Name = "Extension 3 Wall";
        this.x.Walls[checked (this.x.Walls.Length - 1)].Type = "Exposed wall";
        this.x.Walls[checked (this.x.Walls.Length - 1)].Construction = "";
        this.x.Walls[checked (this.x.Walls.Length - 1)].U_Value = this.WallUValue(RdSAP, this.Ext.Ages.E3Age, 3, false);
        this.x.Walls[checked (this.x.Walls.Length - 1)].Ru = 0.0f;
        this.x.Walls[checked (this.x.Walls.Length - 1)].Curtain = false;
        this.x.Walls[checked (this.x.Walls.Length - 1)].K = 0.0f;
        this.x.Walls[checked (this.x.Walls.Length - 1)].Area = (float) Math.Round((double) this.x.Walls[checked (this.x.Walls.Length - 1)].Area, 2);
        this.x.Walls[checked (this.x.Walls.Length - 1)].EPCDesc = SAP_Module.Get_Enum_Desc(typeof (Enums.WallConstructionCode), surveyClass.Extensions[3].WallConstruction) + ", " + SAP_Module.Get_Enum_Desc(typeof (Enums.WallInsulationCode), surveyClass.Extensions[3].WallInsulation);
        if (this.Ext.Ext3Roof)
        {
          if (!surveyClass.Extensions[3].RoofRoom_Edit)
          {
            // ISSUE: variable of a reference type
            SAP_Module.Opaques[]& local20;
            // ISSUE: explicit reference operation
            SAP_Module.Opaques[] opaquesArray14 = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local20 = ref this.x.Walls), (Array) new SAP_Module.Opaques[checked (this.x.Walls.Length + 1)]);
            local20 = opaquesArray14;
            this.x.Walls[checked (this.x.Walls.Length - 1)] = new SAP_Module.Opaques();
            bool flag = false;
            if (this.Ext.MStoreys == this.Ext.E3Storeys & this.Ext.MainRoof)
              flag = true;
            if (this.Ext.MStoreys > this.Ext.E3Storeys)
              flag = true;
            if (this.Ext.E1Storeys == this.Ext.E3Storeys & this.Ext.Ext1Roof)
              flag = true;
            if (this.Ext.E1Storeys > this.Ext.E3Storeys)
              flag = true;
            if (this.Ext.E2Storeys == this.Ext.E3Storeys & this.Ext.Ext2Roof)
              flag = true;
            if (this.Ext.E2Storeys > this.Ext.E3Storeys)
              flag = true;
            if (this.Ext.E4Storeys == this.Ext.E3Storeys & this.Ext.Ext4Roof)
              flag = true;
            if (this.Ext.E4Storeys > this.Ext.E3Storeys)
              flag = true;
            this.x.Walls[checked (this.x.Walls.Length - 1)].Area = !flag ? (float) Math.Round(11.0 * Math.Sqrt(surveyClass.Extensions[3].RoofRoomFloor_Area / 1.5), 2) : (float) Math.Round(8.25 * Math.Sqrt(surveyClass.Extensions[3].RoofRoomFloor_Area / 1.5), 2);
            this.x.Walls[checked (this.x.Walls.Length - 1)].Name = "Extension 3 Roof Room";
            this.x.Walls[checked (this.x.Walls.Length - 1)].Type = "Exposed wall";
            this.x.Walls[checked (this.x.Walls.Length - 1)].Construction = "";
            this.x.Walls[checked (this.x.Walls.Length - 1)].U_Value = this.RoofRoomUValue(RdSAP, 3, "Wall");
            this.x.Walls[checked (this.x.Walls.Length - 1)].Ru = 0.0f;
            this.x.Walls[checked (this.x.Walls.Length - 1)].Curtain = false;
            this.x.Walls[checked (this.x.Walls.Length - 1)].K = 0.0f;
          }
          else
          {
            if (surveyClass.Extensions[3].RoofRoom_GableWall[0].Area != 0.0)
            {
              // ISSUE: variable of a reference type
              SAP_Module.Opaques[]& local21;
              // ISSUE: explicit reference operation
              SAP_Module.Opaques[] opaquesArray15 = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local21 = ref this.x.Walls), (Array) new SAP_Module.Opaques[checked (this.x.Walls.Length + 1)]);
              local21 = opaquesArray15;
              this.x.Walls[checked (this.x.Walls.Length - 1)] = new SAP_Module.Opaques();
              this.x.Walls[checked (this.x.Walls.Length - 1)].Area = (float) surveyClass.Extensions[3].RoofRoom_GableWall[0].Area;
              this.x.Walls[checked (this.x.Walls.Length - 1)].U_Value = (float) surveyClass.Extensions[3].RoofRoom_GableWall[0].U_Value;
              this.x.Walls[checked (this.x.Walls.Length - 1)].Name = "E3 Roof Room Gable Wall 1";
            }
            if (surveyClass.Extensions[3].RoofRoom_GableWall[1].Area != 0.0)
            {
              // ISSUE: variable of a reference type
              SAP_Module.Opaques[]& local22;
              // ISSUE: explicit reference operation
              SAP_Module.Opaques[] opaquesArray16 = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local22 = ref this.x.Walls), (Array) new SAP_Module.Opaques[checked (this.x.Walls.Length + 1)]);
              local22 = opaquesArray16;
              this.x.Walls[checked (this.x.Walls.Length - 1)] = new SAP_Module.Opaques();
              this.x.Walls[checked (this.x.Walls.Length - 1)].Area = (float) surveyClass.Extensions[3].RoofRoom_GableWall[1].Area;
              this.x.Walls[checked (this.x.Walls.Length - 1)].U_Value = (float) surveyClass.Extensions[3].RoofRoom_GableWall[1].U_Value;
              this.x.Walls[checked (this.x.Walls.Length - 1)].Name = "E3 Roof Room Gable Wall 2";
            }
            if (surveyClass.Extensions[3].RoofRoom_StudWall[0].Area != 0.0)
            {
              // ISSUE: variable of a reference type
              SAP_Module.Opaques[]& local23;
              // ISSUE: explicit reference operation
              SAP_Module.Opaques[] opaquesArray17 = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local23 = ref this.x.Walls), (Array) new SAP_Module.Opaques[checked (this.x.Walls.Length + 1)]);
              local23 = opaquesArray17;
              this.x.Walls[checked (this.x.Walls.Length - 1)] = new SAP_Module.Opaques();
              this.x.Walls[checked (this.x.Walls.Length - 1)].Area = (float) surveyClass.Extensions[3].RoofRoom_StudWall[0].Area;
              this.x.Walls[checked (this.x.Walls.Length - 1)].U_Value = (float) surveyClass.Extensions[3].RoofRoom_StudWall[0].U_Value;
              this.x.Walls[checked (this.x.Walls.Length - 1)].Name = "E3 Roof Room Stud Wall 1";
            }
            if (surveyClass.Extensions[3].RoofRoom_StudWall[1].Area != 0.0)
            {
              // ISSUE: variable of a reference type
              SAP_Module.Opaques[]& local24;
              // ISSUE: explicit reference operation
              SAP_Module.Opaques[] opaquesArray18 = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local24 = ref this.x.Walls), (Array) new SAP_Module.Opaques[checked (this.x.Walls.Length + 1)]);
              local24 = opaquesArray18;
              this.x.Walls[checked (this.x.Walls.Length - 1)] = new SAP_Module.Opaques();
              this.x.Walls[checked (this.x.Walls.Length - 1)].Area = (float) surveyClass.Extensions[3].RoofRoom_StudWall[1].Area;
              this.x.Walls[checked (this.x.Walls.Length - 1)].U_Value = (float) surveyClass.Extensions[3].RoofRoom_StudWall[1].U_Value;
              this.x.Walls[checked (this.x.Walls.Length - 1)].Name = "E3 Roof Room Stud Wall 2";
            }
          }
        }
      }
      if (this.Ext.Ext4)
      {
        // ISSUE: variable of a reference type
        SAP_Module.Opaques[]& local25;
        // ISSUE: explicit reference operation
        SAP_Module.Opaques[] opaquesArray19 = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local25 = ref this.x.Walls), (Array) new SAP_Module.Opaques[checked (this.x.Walls.Length + 1)]);
        local25 = opaquesArray19;
        this.x.Walls[checked (this.x.Walls.Length - 1)] = new SAP_Module.Opaques();
        int num16 = checked (this.Ext.MStoreys + this.Ext.E1Storeys + this.Ext.E2Storeys + this.Ext.E3Storeys);
        int num17 = checked (this.Ext.MStoreys + this.Ext.E1Storeys + this.Ext.E2Storeys + this.Ext.E3Storeys + this.Ext.E4Storeys - 1);
        int index5 = num16;
        while (index5 <= num17)
        {
          if (this.x.Dims[index5].Type != 3)
          {
            // ISSUE: variable of a reference type
            float& local26;
            // ISSUE: explicit reference operation
            double num18 = (double) ^(local26 = ref this.x.Walls[checked (this.x.Walls.Length - 1)].Area) + (double) this.x.Dims[index5].Perimeter * (double) this.x.Dims[index5].Height;
            local26 = (float) num18;
          }
          checked { ++index5; }
        }
        if (surveyClass.Extensions[4].AltPresent)
        {
          // ISSUE: variable of a reference type
          float& local27;
          // ISSUE: explicit reference operation
          double num19 = (double) (^(local27 = ref this.x.Walls[checked (this.x.Walls.Length - 1)].Area) - (float) surveyClass.Extensions[4].AltWallArea);
          local27 = (float) num19;
        }
        this.x.Walls[checked (this.x.Walls.Length - 1)].Name = "Extension 4 Wall";
        this.x.Walls[checked (this.x.Walls.Length - 1)].Type = "Exposed wall";
        this.x.Walls[checked (this.x.Walls.Length - 1)].Construction = "";
        this.x.Walls[checked (this.x.Walls.Length - 1)].U_Value = this.WallUValue(RdSAP, this.Ext.Ages.E4Age, 4, false);
        this.x.Walls[checked (this.x.Walls.Length - 1)].Ru = 0.0f;
        this.x.Walls[checked (this.x.Walls.Length - 1)].Curtain = false;
        this.x.Walls[checked (this.x.Walls.Length - 1)].K = 0.0f;
        this.x.Walls[checked (this.x.Walls.Length - 1)].Area = (float) Math.Round((double) this.x.Walls[checked (this.x.Walls.Length - 1)].Area, 2);
        this.x.Walls[checked (this.x.Walls.Length - 1)].EPCDesc = SAP_Module.Get_Enum_Desc(typeof (Enums.WallConstructionCode), surveyClass.Extensions[4].WallConstruction) + ", " + SAP_Module.Get_Enum_Desc(typeof (Enums.WallInsulationCode), surveyClass.Extensions[4].WallInsulation);
        if (this.Ext.Ext4Roof)
        {
          if (!surveyClass.Extensions[4].RoofRoom_Edit)
          {
            // ISSUE: variable of a reference type
            SAP_Module.Opaques[]& local28;
            // ISSUE: explicit reference operation
            SAP_Module.Opaques[] opaquesArray20 = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local28 = ref this.x.Walls), (Array) new SAP_Module.Opaques[checked (this.x.Walls.Length + 1)]);
            local28 = opaquesArray20;
            this.x.Walls[checked (this.x.Walls.Length - 1)] = new SAP_Module.Opaques();
            bool flag = false;
            if (this.Ext.MStoreys == this.Ext.E4Storeys & this.Ext.MainRoof)
              flag = true;
            if (this.Ext.MStoreys > this.Ext.E4Storeys)
              flag = true;
            if (this.Ext.E1Storeys == this.Ext.E4Storeys & this.Ext.Ext1Roof)
              flag = true;
            if (this.Ext.E1Storeys > this.Ext.E4Storeys)
              flag = true;
            if (this.Ext.E2Storeys == this.Ext.E4Storeys & this.Ext.Ext2Roof)
              flag = true;
            if (this.Ext.E2Storeys > this.Ext.E4Storeys)
              flag = true;
            if (this.Ext.E3Storeys == this.Ext.E4Storeys & this.Ext.Ext3Roof)
              flag = true;
            if (this.Ext.E3Storeys > this.Ext.E4Storeys)
              flag = true;
            this.x.Walls[checked (this.x.Walls.Length - 1)].Area = !flag ? (float) Math.Round(11.0 * Math.Sqrt(surveyClass.Extensions[4].RoofRoomFloor_Area / 1.5), 2) : (float) Math.Round(8.25 * Math.Sqrt(surveyClass.Extensions[4].RoofRoomFloor_Area / 1.5), 2);
            this.x.Walls[checked (this.x.Walls.Length - 1)].Name = "Extension 4 Roof Room";
            this.x.Walls[checked (this.x.Walls.Length - 1)].Type = "Exposed wall";
            this.x.Walls[checked (this.x.Walls.Length - 1)].Construction = "";
            this.x.Walls[checked (this.x.Walls.Length - 1)].U_Value = this.RoofRoomUValue(RdSAP, 4, "Wall");
            this.x.Walls[checked (this.x.Walls.Length - 1)].Ru = 0.0f;
            this.x.Walls[checked (this.x.Walls.Length - 1)].Curtain = false;
            this.x.Walls[checked (this.x.Walls.Length - 1)].K = 0.0f;
          }
          else
          {
            if (surveyClass.Extensions[4].RoofRoom_GableWall[0].Area != 0.0)
            {
              // ISSUE: variable of a reference type
              SAP_Module.Opaques[]& local29;
              // ISSUE: explicit reference operation
              SAP_Module.Opaques[] opaquesArray21 = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local29 = ref this.x.Walls), (Array) new SAP_Module.Opaques[checked (this.x.Walls.Length + 1)]);
              local29 = opaquesArray21;
              this.x.Walls[checked (this.x.Walls.Length - 1)] = new SAP_Module.Opaques();
              this.x.Walls[checked (this.x.Walls.Length - 1)].Area = (float) surveyClass.Extensions[4].RoofRoom_GableWall[0].Area;
              this.x.Walls[checked (this.x.Walls.Length - 1)].U_Value = (float) surveyClass.Extensions[4].RoofRoom_GableWall[0].U_Value;
              this.x.Walls[checked (this.x.Walls.Length - 1)].Name = "E4 Roof Room Gable Wall 1";
            }
            if (surveyClass.Extensions[4].RoofRoom_GableWall[1].Area != 0.0)
            {
              // ISSUE: variable of a reference type
              SAP_Module.Opaques[]& local30;
              // ISSUE: explicit reference operation
              SAP_Module.Opaques[] opaquesArray22 = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local30 = ref this.x.Walls), (Array) new SAP_Module.Opaques[checked (this.x.Walls.Length + 1)]);
              local30 = opaquesArray22;
              this.x.Walls[checked (this.x.Walls.Length - 1)] = new SAP_Module.Opaques();
              this.x.Walls[checked (this.x.Walls.Length - 1)].Area = (float) surveyClass.Extensions[4].RoofRoom_GableWall[1].Area;
              this.x.Walls[checked (this.x.Walls.Length - 1)].U_Value = (float) surveyClass.Extensions[4].RoofRoom_GableWall[1].U_Value;
              this.x.Walls[checked (this.x.Walls.Length - 1)].Name = "E4 Roof Room Gable Wall 2";
            }
            if (surveyClass.Extensions[4].RoofRoom_StudWall[0].Area != 0.0)
            {
              // ISSUE: variable of a reference type
              SAP_Module.Opaques[]& local31;
              // ISSUE: explicit reference operation
              SAP_Module.Opaques[] opaquesArray23 = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local31 = ref this.x.Walls), (Array) new SAP_Module.Opaques[checked (this.x.Walls.Length + 1)]);
              local31 = opaquesArray23;
              this.x.Walls[checked (this.x.Walls.Length - 1)] = new SAP_Module.Opaques();
              this.x.Walls[checked (this.x.Walls.Length - 1)].Area = (float) surveyClass.Extensions[4].RoofRoom_StudWall[0].Area;
              this.x.Walls[checked (this.x.Walls.Length - 1)].U_Value = (float) surveyClass.Extensions[4].RoofRoom_StudWall[0].U_Value;
              this.x.Walls[checked (this.x.Walls.Length - 1)].Name = "E4 Roof Room Stud Wall 1";
            }
            if (surveyClass.Extensions[4].RoofRoom_StudWall[1].Area != 0.0)
            {
              // ISSUE: variable of a reference type
              SAP_Module.Opaques[]& local32;
              // ISSUE: explicit reference operation
              SAP_Module.Opaques[] opaquesArray24 = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local32 = ref this.x.Walls), (Array) new SAP_Module.Opaques[checked (this.x.Walls.Length + 1)]);
              local32 = opaquesArray24;
              this.x.Walls[checked (this.x.Walls.Length - 1)] = new SAP_Module.Opaques();
              this.x.Walls[checked (this.x.Walls.Length - 1)].Area = (float) surveyClass.Extensions[4].RoofRoom_StudWall[1].Area;
              this.x.Walls[checked (this.x.Walls.Length - 1)].U_Value = (float) surveyClass.Extensions[4].RoofRoom_StudWall[1].U_Value;
              this.x.Walls[checked (this.x.Walls.Length - 1)].Name = "E4 Roof Room Stud Wall 2";
            }
          }
        }
      }
      int numberOfExtension = surveyClass.Age.NumberOfExtension;
      int Extension = 0;
      while (Extension <= numberOfExtension)
      {
        if (surveyClass.Extensions[Extension].AltPresent)
        {
          // ISSUE: variable of a reference type
          SAP_Module.Opaques[]& local;
          // ISSUE: explicit reference operation
          SAP_Module.Opaques[] opaquesArray = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local = ref this.x.Walls), (Array) new SAP_Module.Opaques[checked (this.x.Walls.Length + 1)]);
          local = opaquesArray;
          this.x.Walls[checked (this.x.Walls.Length - 1)] = new SAP_Module.Opaques();
          this.x.Walls[checked (this.x.Walls.Length - 1)].Area = !(Extension == 0 & surveyClass.Extensions[Extension].AltShelteredWall == 1 & (surveyClass.General.PropertyType1 == 3 | surveyClass.General.PropertyType1 == 4)) ? (float) surveyClass.Extensions[Extension].AltWallArea : (float) Math.Round((double) this.x.Dims[0].Height * surveyClass.Flat_Maisonette.UnHeatedCorridorLength, 2);
          this.x.Walls[checked (this.x.Walls.Length - 1)].Name = "Alternative Wall " + Conversions.ToString(Extension);
          this.x.Walls[checked (this.x.Walls.Length - 1)].Type = "Exposed wall";
          this.x.Walls[checked (this.x.Walls.Length - 1)].Construction = "";
          this.x.Walls[checked (this.x.Walls.Length - 1)].EPCDesc = SAP_Module.Get_Enum_Desc(typeof (Enums.WallConstructionCode), surveyClass.Extensions[Extension].AltWallConstruction) + ", " + SAP_Module.Get_Enum_Desc(typeof (Enums.WallInsulationCode), surveyClass.Extensions[Extension].AltWallInsulationType);
          string WallAge = "";
          switch (Extension)
          {
            case 0:
              WallAge = this.Ext.Ages.MAge;
              break;
            case 1:
              WallAge = this.Ext.Ages.E1Age;
              break;
            case 2:
              WallAge = this.Ext.Ages.E2Age;
              break;
            case 3:
              WallAge = this.Ext.Ages.E3Age;
              break;
            case 4:
              WallAge = this.Ext.Ages.E4Age;
              break;
          }
          this.x.Walls[checked (this.x.Walls.Length - 1)].U_Value = this.WallUValue(RdSAP, WallAge, Extension, true);
          if (Extension == 0 & surveyClass.Extensions[Extension].AltShelteredWall == 1 & (surveyClass.General.PropertyType1 == 3 | surveyClass.General.PropertyType1 == 4))
            this.x.Walls[checked (this.x.Walls.Length - 1)].U_Value = (float) Math.Round(1.0 / (1.0 / (double) this.x.Walls[checked (this.x.Walls.Length - 1)].U_Value + 0.4), 2);
          this.x.Walls[checked (this.x.Walls.Length - 1)].Ru = 0.0f;
          this.x.Walls[checked (this.x.Walls.Length - 1)].Curtain = false;
          this.x.Walls[checked (this.x.Walls.Length - 1)].K = 0.0f;
        }
        checked { ++Extension; }
      }
      if (surveyClass.Flat_Maisonette.HeatLossCorridor == 3 && surveyClass.General.PropertyType1 == 3 | surveyClass.General.PropertyType1 == 4 && surveyClass.Extensions[0].AltShelteredWall != 1)
      {
        this.Ext.IncFlatCorridor = true;
        // ISSUE: variable of a reference type
        SAP_Module.Opaques[]& local33;
        // ISSUE: explicit reference operation
        SAP_Module.Opaques[] opaquesArray = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local33 = ref this.x.Walls), (Array) new SAP_Module.Opaques[checked (this.x.Walls.Length + 1)]);
        local33 = opaquesArray;
        this.x.Walls[checked (this.x.Walls.Length - 1)] = new SAP_Module.Opaques();
        this.x.Walls[checked (this.x.Walls.Length - 1)].U_Value = (float) Math.Round(1.0 / (1.0 / (double) this.x.Walls[0].U_Value + 0.4), 2);
        this.x.Walls[checked (this.x.Walls.Length - 1)].Name = "Flat Corridor";
        this.x.Walls[checked (this.x.Walls.Length - 1)].Type = "Exposed wall";
        this.x.Walls[checked (this.x.Walls.Length - 1)].Construction = "";
        this.x.Walls[checked (this.x.Walls.Length - 1)].Ru = 0.0f;
        this.x.Walls[checked (this.x.Walls.Length - 1)].Curtain = false;
        this.x.Walls[checked (this.x.Walls.Length - 1)].K = 0.0f;
        this.x.Walls[checked (this.x.Walls.Length - 1)].Area = (float) surveyClass.Flat_Maisonette.UnHeatedCorridorLength * this.x.Dims[0].Height;
        // ISSUE: variable of a reference type
        float& local34;
        // ISSUE: explicit reference operation
        double num20 = (double) ^(local34 = ref this.x.Walls[0].Area) - (double) this.x.Walls[checked (this.x.Walls.Length - 1)].Area;
        local34 = (float) num20;
      }
      this.x.NoofWalls = this.x.Walls.Length;
    }

    public float WallUValue(Survey_Class RdSAP, string WallAge, int Extension, bool Alternative)
    {
      float num1 = 0.0f;
      string str = "";
      Enums.WallConstructionCode wallConstruction;
      Enums.WallInsulationCode wallInsulationCode;
      Enums.WallInsulationThicknessCode insulationThickness;
      if (Alternative)
      {
        if (RdSAP.Extensions[Extension].AltWallUValueKnown)
          return (float) RdSAP.Extensions[Extension].AltWallUValue;
        wallConstruction = (Enums.WallConstructionCode) RdSAP.Extensions[Extension].AltWallConstruction;
        wallInsulationCode = (Enums.WallInsulationCode) RdSAP.Extensions[Extension].AltWallInsulationType;
        insulationThickness = (Enums.WallInsulationThicknessCode) RdSAP.Extensions[Extension].AltWallInsulationThickness;
      }
      else
      {
        if (RdSAP.Extensions[Extension].WallUValueKnown)
          return (float) RdSAP.Extensions[Extension].WallUValue;
        wallConstruction = (Enums.WallConstructionCode) RdSAP.Extensions[Extension].WallConstruction;
        wallInsulationCode = (Enums.WallInsulationCode) RdSAP.Extensions[Extension].WallInsulation;
        insulationThickness = (Enums.WallInsulationThicknessCode) RdSAP.Extensions[Extension].WallInsulationThickness;
      }
      bool flag = false;
      RdSAP_TO_SAP.WallCalc wallCalc;
      switch (wallConstruction)
      {
        case Enums.WallConstructionCode.Granite_or_whinstone:
          if (wallInsulationCode != Enums.WallInsulationCode.Internal & wallInsulationCode != Enums.WallInsulationCode.External)
          {
            str = "Stone: granite or whinstone";
            string Left = WallAge;
            if (Operators.CompareString(Left, "A", false) != 0 && Operators.CompareString(Left, "B", false) != 0 && Operators.CompareString(Left, "C", false) != 0 && Operators.CompareString(Left, "D", false) != 0)
            {
              if (Operators.CompareString(Left, "E", false) == 0)
                wallCalc = RdSAP_TO_SAP.WallCalc.Granite_b;
            }
            else
              wallCalc = RdSAP_TO_SAP.WallCalc.Granite_a;
          }
          else
          {
            switch (insulationThickness)
            {
              case Enums.WallInsulationThicknessCode.Unknown:
              case Enums.WallInsulationThicknessCode._50mm:
                str = "Stone / solid brick + insulation";
                break;
              case Enums.WallInsulationThicknessCode._100mm:
                str = "Stone / solid brick + insulation100";
                break;
              case Enums.WallInsulationThicknessCode._150mm:
                str = "Stone / solid brick + insulation150";
                break;
            }
          }
          flag = true;
          break;
        case Enums.WallConstructionCode.Sandstone:
          if (wallInsulationCode != Enums.WallInsulationCode.Internal & wallInsulationCode != Enums.WallInsulationCode.External)
          {
            str = "Stone: sandstone";
            string Left = WallAge;
            if (Operators.CompareString(Left, "A", false) != 0 && Operators.CompareString(Left, "B", false) != 0 && Operators.CompareString(Left, "C", false) != 0 && Operators.CompareString(Left, "D", false) != 0)
            {
              if (Operators.CompareString(Left, "E", false) == 0)
                wallCalc = RdSAP_TO_SAP.WallCalc.SandStone_b;
            }
            else
              wallCalc = RdSAP_TO_SAP.WallCalc.SandStone_a;
          }
          else
          {
            switch (insulationThickness)
            {
              case Enums.WallInsulationThicknessCode.Unknown:
              case Enums.WallInsulationThicknessCode._50mm:
                str = "Stone / solid brick + insulation";
                break;
              case Enums.WallInsulationThicknessCode._100mm:
                str = "Stone / solid brick + insulation100";
                break;
              case Enums.WallInsulationThicknessCode._150mm:
                str = "Stone / solid brick + insulation150";
                break;
            }
          }
          flag = true;
          break;
        case Enums.WallConstructionCode.Solid_brick:
          if (wallInsulationCode != Enums.WallInsulationCode.Internal & wallInsulationCode != Enums.WallInsulationCode.External)
          {
            str = "Solid Brick";
          }
          else
          {
            switch (insulationThickness)
            {
              case Enums.WallInsulationThicknessCode.Unknown:
              case Enums.WallInsulationThicknessCode._50mm:
                str = "Stone / solid brick + insulation";
                break;
              case Enums.WallInsulationThicknessCode._100mm:
                str = "Stone / solid brick + insulation100";
                break;
              case Enums.WallInsulationThicknessCode._150mm:
                str = "Stone / solid brick + insulation150";
                break;
            }
          }
          flag = true;
          break;
        case Enums.WallConstructionCode.Cavity:
          if (wallInsulationCode == Enums.WallInsulationCode.Internal | wallInsulationCode == Enums.WallInsulationCode.Filled_cavity | wallInsulationCode == Enums.WallInsulationCode.External)
          {
            str = "Cavity + insulation";
            break;
          }
          if (wallInsulationCode == Enums.WallInsulationCode.Filled_cavity_external | wallInsulationCode == Enums.WallInsulationCode.Filled_cavity_internal)
          {
            switch (insulationThickness)
            {
              case Enums.WallInsulationThicknessCode.Unknown:
              case Enums.WallInsulationThicknessCode._50mm:
                str = "Cavity + insulation50";
                break;
              case Enums.WallInsulationThicknessCode._100mm:
                str = "Cavity + insulation100";
                break;
              case Enums.WallInsulationThicknessCode._150mm:
                str = "Cavity + insulation150";
                break;
            }
          }
          else
          {
            str = "Cavity";
            break;
          }
          break;
        case Enums.WallConstructionCode.Timber_frame:
          str = !(wallInsulationCode != Enums.WallInsulationCode.Internal & wallInsulationCode != Enums.WallInsulationCode.External) ? "Timber Frame + insulation" : "Timber Frame";
          break;
        case Enums.WallConstructionCode.System_built:
          if (wallInsulationCode != Enums.WallInsulationCode.Internal & wallInsulationCode != Enums.WallInsulationCode.External)
          {
            str = "System Build";
            break;
          }
          switch (insulationThickness)
          {
            case Enums.WallInsulationThicknessCode.Unknown:
            case Enums.WallInsulationThicknessCode._50mm:
              str = "System Build + insulation";
              break;
            case Enums.WallInsulationThicknessCode._100mm:
              str = "System Build + insulation100";
              break;
            case Enums.WallInsulationThicknessCode._150mm:
              str = "System Build + insulation150";
              break;
          }
          break;
        case Enums.WallConstructionCode.Cob_wall:
          if (wallInsulationCode != Enums.WallInsulationCode.Internal & wallInsulationCode != Enums.WallInsulationCode.External)
          {
            str = "Cob";
            break;
          }
          switch (insulationThickness)
          {
            case Enums.WallInsulationThicknessCode.Unknown:
            case Enums.WallInsulationThicknessCode._50mm:
              str = "Cob + Insulation";
              break;
            case Enums.WallInsulationThicknessCode._100mm:
              str = "Cob + Insulation100";
              break;
            case Enums.WallInsulationThicknessCode._150mm:
              str = "Cob + Insulation150";
              break;
          }
          break;
      }
      float num2;
      if ((uint) wallCalc > 0U)
        num2 = !RdSAP.Extensions[Extension].WallThicknessMeasured ? this.GetWallThickNess(RdSAP, Extension, Alternative) * 1000f : (float) RdSAP.Extensions[Extension].WallThickness;
      if (wallCalc != RdSAP_TO_SAP.WallCalc.Granite_a & wallCalc != RdSAP_TO_SAP.WallCalc.SandStone_a)
      {
        num1 = RdSAP.General.Country != 4 ? (RdSAP.General.Country != 3 ? (float) Conversion.Val(SAP_Module.AppenS.s7.Where<AppendixS.WallUvalue>((Func<AppendixS.WallUvalue, bool>) (b => Operators.CompareString(b.WallType.ToUpper(), str.ToUpper(), false) == 0 & Operators.CompareString(b.AgeBand, WallAge, false) == 0)).Single<AppendixS.WallUvalue>().Uvalue) : (float) Conversion.Val(SAP_Module.AppenS.s9.Where<AppendixS.WallUvalue>((Func<AppendixS.WallUvalue, bool>) (b => Operators.CompareString(b.WallType.ToUpper(), str.ToUpper(), false) == 0 & Operators.CompareString(b.AgeBand, WallAge, false) == 0)).Single<AppendixS.WallUvalue>().Uvalue)) : (float) Conversion.Val(SAP_Module.AppenS.s8.Where<AppendixS.WallUvalue>((Func<AppendixS.WallUvalue, bool>) (b => Operators.CompareString(b.WallType.ToUpper(), str.ToUpper(), false) == 0 & Operators.CompareString(b.AgeBand, WallAge, false) == 0)).Single<AppendixS.WallUvalue>().Uvalue);
        if (wallCalc == RdSAP_TO_SAP.WallCalc.Granite_b)
          num1 = 3.3 - 0.002 * (double) num2 < (double) num1 ? (float) (3.3 - 0.002 * (double) num2) : num1;
        if (wallCalc == RdSAP_TO_SAP.WallCalc.SandStone_b)
          num1 = 3.0 - 0.002 * (double) num2 < (double) num1 ? (float) (3.0 - 0.002 * (double) num2) : num1;
      }
      else
      {
        if (wallCalc == RdSAP_TO_SAP.WallCalc.Granite_a)
          num1 = (float) (3.3 - 0.002 * (double) num2);
        if (wallCalc == RdSAP_TO_SAP.WallCalc.SandStone_a)
          num1 = (float) (3.0 - 0.002 * (double) num2);
      }
      if (flag & RdSAP.Extensions[Extension].DryLining & !Alternative)
        num1 = (float) (1.0 / (1.0 / (double) num1 + 0.17));
      return num1;
    }

    private float RoofRoomUValue(Survey_Class RdSAP, int Extension, string WallOrRoof)
    {
      string str;
      switch (Extension)
      {
        case 0:
          str = this.Ext.Ages.MRoofAge;
          break;
        case 1:
          str = this.Ext.Ages.E1RoofAge;
          break;
        case 2:
          str = this.Ext.Ages.E2RoofAge;
          break;
        case 3:
          str = this.Ext.Ages.E3RoofAge;
          break;
        case 4:
          str = this.Ext.Ages.E4RoofAge;
          break;
      }
      Survey_Class surveyClass = RdSAP;
      if ((uint) Operators.CompareString(WallOrRoof, "Wall", false) > 0U & surveyClass.Extensions[Extension].RoofRoom_Insulation == 3 & surveyClass.Extensions[Extension].RoofRoom_Tickness == 12)
        WallOrRoof = "Wall";
      if (Operators.CompareString(WallOrRoof, "Wall", false) == 0)
      {
        float num;
        if (surveyClass.Extensions[Extension].RoofRoom_Insulation == 1)
        {
          num = surveyClass.Extensions[Extension].RoofConstruction != 6 ? 2.3f : 0.25f;
        }
        else
        {
          num = surveyClass.Extensions[Extension].RoofConstruction != 6 ? Conversions.ToSingle(SAP_Module.AppenS.s10.Where<AppendixS.RoofUValue>((Func<AppendixS.RoofUValue, bool>) (b => Operators.CompareString(b.AgeBand, str, false) == 0 & Operators.CompareString(b.RoofType, "Room-in-roof", false) == 0)).Single<AppendixS.RoofUValue>().Uvalue) : Conversions.ToSingle(SAP_Module.AppenS.s10.Where<AppendixS.RoofUValue>((Func<AppendixS.RoofUValue, bool>) (b => Operators.CompareString(b.AgeBand, str, false) == 0 & Operators.CompareString(b.RoofType, "Thatched room-in-roof", false) == 0)).Single<AppendixS.RoofUValue>().Uvalue);
          if (surveyClass.General.Country == 3 && surveyClass.Extensions[Extension].RoofAge == 11 & (double) num == 0.25)
            num = 0.2f;
          if (surveyClass.Extensions[Extension].RoofRoom_Insulation == 3)
          {
            switch (surveyClass.Extensions[Extension].RoomRoofInsulationAtSlope)
            {
              case 2:
                if ((double) num > 0.68)
                {
                  num = 0.68f;
                  break;
                }
                break;
              case 3:
                if ((double) num > 0.4)
                {
                  num = 0.4f;
                  break;
                }
                break;
              case 4:
                if ((double) num > 0.3)
                {
                  num = 0.3f;
                  break;
                }
                break;
            }
          }
        }
        return num;
      }
      float num1;
      if (surveyClass.Extensions[Extension].RoofRoom_Insulation == 1)
        num1 = surveyClass.Extensions[Extension].RoofConstruction != 6 ? 2.3f : 0.35f;
      bool flag;
      if (surveyClass.Extensions[Extension].RoofRoom_Insulation == 2 | surveyClass.Extensions[Extension].RoofRoom_Insulation == 3)
      {
        if (surveyClass.Extensions[Extension].RoofConstruction == 6)
        {
          switch (surveyClass.Extensions[Extension].RoofRoom_Tickness)
          {
            case 1:
              num1 = 0.35f;
              break;
            case 2:
              flag = true;
              break;
            case 3:
              num1 = 0.32f;
              break;
            case 4:
              num1 = 0.3f;
              break;
            case 5:
              num1 = 0.25f;
              break;
            case 6:
              num1 = 0.22f;
              break;
            case 7:
              num1 = 0.2f;
              break;
            case 8:
              num1 = 0.16f;
              break;
            case 9:
              num1 = 0.13f;
              break;
            case 10:
              num1 = 0.11f;
              break;
            case 11:
              num1 = 0.1f;
              break;
          }
        }
        else
        {
          switch (surveyClass.Extensions[Extension].RoofRoom_Tickness)
          {
            case 1:
              num1 = 2.3f;
              break;
            case 2:
              flag = true;
              break;
            case 3:
              num1 = 1.5f;
              break;
            case 4:
              num1 = 1f;
              break;
            case 5:
              num1 = 0.68f;
              break;
            case 6:
              num1 = 0.5f;
              break;
            case 7:
              num1 = 0.4f;
              break;
            case 8:
              num1 = 0.29f;
              break;
            case 9:
              num1 = 0.2f;
              break;
            case 10:
              num1 = 0.16f;
              break;
            case 11:
              num1 = 0.13f;
              break;
          }
        }
      }
      if (surveyClass.Extensions[Extension].RoofRoom_Insulation == 0 | flag)
      {
        num1 = surveyClass.Extensions[Extension].RoofConstruction != 6 ? Conversions.ToSingle(SAP_Module.AppenS.s10.Where<AppendixS.RoofUValue>((Func<AppendixS.RoofUValue, bool>) (b => Operators.CompareString(b.AgeBand, str, false) == 0 & Operators.CompareString(b.RoofType, "Room-in-roof", false) == 0)).Single<AppendixS.RoofUValue>().Uvalue) : Conversions.ToSingle(SAP_Module.AppenS.s10.Where<AppendixS.RoofUValue>((Func<AppendixS.RoofUValue, bool>) (b => Operators.CompareString(b.AgeBand, str, false) == 0 & Operators.CompareString(b.RoofType, "Thatched room-in-roof", false) == 0)).Single<AppendixS.RoofUValue>().Uvalue);
        if (surveyClass.General.Country == 3 && Operators.CompareString(str, "K", false) == 0 & (double) num1 == 0.25)
          num1 = 0.2f;
      }
      return num1;
    }

    private void Roofs(Survey_Class Rdsap)
    {
      Survey_Class surveyClass = Rdsap;
      switch (surveyClass.Extensions[0].RoofConstruction)
      {
        case 2:
        case 4:
        case 5:
        case 6:
          this.x.Roofs = new SAP_Module.Opaques[1];
          this.x.Roofs[checked (this.x.Roofs.Length - 1)] = new SAP_Module.Opaques();
          int num1 = checked (this.Ext.MStoreys - 1);
          int index1 = 0;
          while (index1 <= num1)
          {
            if ((double) this.x.Dims[index1].Area > (double) this.x.Roofs[0].Area)
              this.x.Roofs[0].Area = this.x.Dims[index1].Area;
            checked { ++index1; }
          }
          if (this.Ext.MainRoof)
          {
            // ISSUE: variable of a reference type
            float& local;
            // ISSUE: explicit reference operation
            double num2 = (double) (^(local = ref this.x.Roofs[0].Area) - (float) surveyClass.Extensions[0].RoofRoomFloor_Area);
            local = (float) num2;
          }
          this.x.Roofs[0].Name = "Main Roof";
          switch (surveyClass.Extensions[0].RoofConstruction)
          {
            case 4:
            case 5:
            case 6:
              if (surveyClass.Extensions[0].RoofInsulation == 4)
              {
                this.x.Roofs[0].Type = "Pitched - insulated joists";
                this.x.Roofs[0].LoftInsulation = this.CheckJoists((Enums.RoofInsulationCode) surveyClass.Extensions[0].RoofInsulationThickness);
                break;
              }
              this.x.Roofs[0].Type = surveyClass.Extensions[0].RoofInsulation != 3 ? "Pitched" : "Pichted - insulated rafters";
              break;
            default:
              this.x.Roofs[0].Type = "Flat roof";
              break;
          }
          switch (surveyClass.Extensions[0].RoofInsulation)
          {
            case 1:
              this.x.Roofs[0].Construction = "None";
              break;
            case 2:
              this.x.Roofs[0].Construction = "Unknown";
              break;
            case 3:
              this.x.Roofs[0].Construction = "Rafters";
              break;
            case 4:
              this.x.Roofs[0].Construction = "Joists";
              break;
            case 5:
              this.x.Roofs[0].Construction = "Flat roof Insulation";
              break;
          }
          this.x.Roofs[0].U_Value = this.RoofUValue(Rdsap, this.Ext.Ages.MAge, 0);
          if (surveyClass.Extensions[0].RoofUValueKnown)
            this.x.Roofs[0].U_Value = (float) surveyClass.Extensions[0].RoofUValue;
          this.x.Roofs[0].UvalueKnown = surveyClass.Extensions[0].RoofUValueKnown;
          this.x.Roofs[0].K = 0.0f;
          this.x.Roofs[0].EPCDesc = SAP_Module.Get_Enum_Desc(typeof (Enums.RoofConstructionCode), surveyClass.Extensions[0].RoofConstruction) + ", " + SAP_Module.Get_Enum_Desc(typeof (Enums.RoofInsulationCode), surveyClass.Extensions[0].RoofInsulation);
          break;
      }
      if (this.Ext.MainRoof)
      {
        if (!surveyClass.Extensions[0].RoofRoom_Edit)
        {
          if (this.x.Roofs == null)
          {
            this.x.Roofs = new SAP_Module.Opaques[1];
          }
          else
          {
            // ISSUE: variable of a reference type
            SAP_Module.Opaques[]& local;
            // ISSUE: explicit reference operation
            SAP_Module.Opaques[] opaquesArray = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local = ref this.x.Roofs), (Array) new SAP_Module.Opaques[checked (this.x.Roofs.Length + 1)]);
            local = opaquesArray;
          }
          this.x.Roofs[checked (this.x.Roofs.Length - 1)] = new SAP_Module.Opaques();
          this.x.Roofs[checked (this.x.Roofs.Length - 1)].Area = (float) surveyClass.Extensions[0].RoofRoomFloor_Area;
          this.x.Roofs[checked (this.x.Roofs.Length - 1)].Name = "Main Roof Room";
          this.x.Roofs[checked (this.x.Roofs.Length - 1)].Type = "Roof Room";
          switch (surveyClass.Extensions[0].RoofRoom_Insulation)
          {
            case 0:
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].Construction = "Unknown";
              break;
            case 1:
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].Construction = "None";
              break;
            case 2:
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].Construction = "Flat ceiling only";
              break;
            case 3:
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].Construction = "All Elements";
              break;
          }
          this.x.Roofs[checked (this.x.Roofs.Length - 1)].U_Value = this.RoofRoomUValue(Rdsap, 0, "Roof");
          this.x.Roofs[checked (this.x.Roofs.Length - 1)].Ru = 0.0f;
          this.x.Roofs[checked (this.x.Roofs.Length - 1)].Curtain = false;
          this.x.Roofs[checked (this.x.Roofs.Length - 1)].K = 0.0f;
          this.x.Roofs[checked (this.x.Roofs.Length - 1)].EPCDesc = SAP_Module.Get_Enum_Desc(typeof (Enums.RoofRoomInsulationCode), surveyClass.Extensions[0].RoofRoom_Insulation);
        }
        else
        {
          if (surveyClass.Extensions[0].RoofRoom_FlatCeiling[0].Area != 0.0)
          {
            // ISSUE: variable of a reference type
            SAP_Module.Opaques[]& local;
            // ISSUE: explicit reference operation
            SAP_Module.Opaques[] opaquesArray = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local = ref this.x.Roofs), (Array) new SAP_Module.Opaques[checked (this.x.Roofs.Length + 1)]);
            local = opaquesArray;
            this.x.Roofs[checked (this.x.Roofs.Length - 1)] = new SAP_Module.Opaques();
            this.x.Roofs[checked (this.x.Roofs.Length - 1)].Area = (float) surveyClass.Extensions[0].RoofRoom_FlatCeiling[0].Area;
            this.x.Roofs[checked (this.x.Roofs.Length - 1)].U_Value = (float) surveyClass.Extensions[0].RoofRoom_FlatCeiling[0].U_Value;
            this.x.Roofs[checked (this.x.Roofs.Length - 1)].Name = "Main Roof Room Flat Ceiling 1";
            this.x.Roofs[checked (this.x.Roofs.Length - 1)].Type = "Roof Room";
            this.x.Roofs[checked (this.x.Roofs.Length - 1)].Type = "Roof Room Edit";
            this.x.Roofs[checked (this.x.Roofs.Length - 1)].UvalueKnown = true;
          }
          if (surveyClass.Extensions[0].RoofRoom_FlatCeiling[1].Area != 0.0)
          {
            // ISSUE: variable of a reference type
            SAP_Module.Opaques[]& local;
            // ISSUE: explicit reference operation
            SAP_Module.Opaques[] opaquesArray = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local = ref this.x.Roofs), (Array) new SAP_Module.Opaques[checked (this.x.Roofs.Length + 1)]);
            local = opaquesArray;
            this.x.Roofs[checked (this.x.Roofs.Length - 1)] = new SAP_Module.Opaques();
            this.x.Roofs[checked (this.x.Roofs.Length - 1)].Area = (float) surveyClass.Extensions[0].RoofRoom_FlatCeiling[1].Area;
            this.x.Roofs[checked (this.x.Roofs.Length - 1)].U_Value = (float) surveyClass.Extensions[0].RoofRoom_FlatCeiling[1].U_Value;
            this.x.Roofs[checked (this.x.Roofs.Length - 1)].Name = "Main Roof Room Flat Ceiling 2";
            this.x.Roofs[checked (this.x.Roofs.Length - 1)].Type = "Roof Room";
            this.x.Roofs[checked (this.x.Roofs.Length - 1)].Type = "Roof Room Edit";
            this.x.Roofs[checked (this.x.Roofs.Length - 1)].UvalueKnown = true;
          }
          if (surveyClass.Extensions[0].RoofRoom_Slope[0].Area != 0.0)
          {
            // ISSUE: variable of a reference type
            SAP_Module.Opaques[]& local;
            // ISSUE: explicit reference operation
            SAP_Module.Opaques[] opaquesArray = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local = ref this.x.Roofs), (Array) new SAP_Module.Opaques[checked (this.x.Roofs.Length + 1)]);
            local = opaquesArray;
            this.x.Roofs[checked (this.x.Roofs.Length - 1)] = new SAP_Module.Opaques();
            this.x.Roofs[checked (this.x.Roofs.Length - 1)].Area = (float) surveyClass.Extensions[0].RoofRoom_Slope[0].Area;
            this.x.Roofs[checked (this.x.Roofs.Length - 1)].U_Value = (float) surveyClass.Extensions[0].RoofRoom_Slope[0].U_Value;
            this.x.Roofs[checked (this.x.Roofs.Length - 1)].Name = "Main Roof Room Sloped Roof 1";
            this.x.Roofs[checked (this.x.Roofs.Length - 1)].Type = "Roof Room";
            this.x.Roofs[checked (this.x.Roofs.Length - 1)].Type = "Roof Room Edit";
            this.x.Roofs[checked (this.x.Roofs.Length - 1)].UvalueKnown = true;
          }
          if (surveyClass.Extensions[0].RoofRoom_Slope[1].Area != 0.0)
          {
            // ISSUE: variable of a reference type
            SAP_Module.Opaques[]& local;
            // ISSUE: explicit reference operation
            SAP_Module.Opaques[] opaquesArray = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local = ref this.x.Roofs), (Array) new SAP_Module.Opaques[checked (this.x.Roofs.Length + 1)]);
            local = opaquesArray;
            this.x.Roofs[checked (this.x.Roofs.Length - 1)] = new SAP_Module.Opaques();
            this.x.Roofs[checked (this.x.Roofs.Length - 1)].Area = (float) surveyClass.Extensions[0].RoofRoom_Slope[1].Area;
            this.x.Roofs[checked (this.x.Roofs.Length - 1)].U_Value = (float) surveyClass.Extensions[0].RoofRoom_Slope[1].U_Value;
            this.x.Roofs[checked (this.x.Roofs.Length - 1)].Name = "Main Roof Room Sloped Roof 2";
            this.x.Roofs[checked (this.x.Roofs.Length - 1)].EPCDesc = "Roof Room";
            this.x.Roofs[checked (this.x.Roofs.Length - 1)].Type = "Roof Room Edit";
            this.x.Roofs[checked (this.x.Roofs.Length - 1)].UvalueKnown = true;
          }
        }
      }
      if (this.Ext.Ext1)
      {
        switch (surveyClass.Extensions[1].RoofConstruction)
        {
          case 2:
          case 4:
          case 5:
          case 6:
            if (this.x.Roofs == null)
            {
              this.x.Roofs = new SAP_Module.Opaques[1];
            }
            else
            {
              // ISSUE: variable of a reference type
              SAP_Module.Opaques[]& local;
              // ISSUE: explicit reference operation
              SAP_Module.Opaques[] opaquesArray = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local = ref this.x.Roofs), (Array) new SAP_Module.Opaques[checked (this.x.Roofs.Length + 1)]);
              local = opaquesArray;
            }
            this.x.Roofs[checked (this.x.Roofs.Length - 1)] = new SAP_Module.Opaques();
            int mstoreys = this.Ext.MStoreys;
            int num3 = checked (this.Ext.MStoreys + this.Ext.E1Storeys - 1);
            int index2 = mstoreys;
            while (index2 <= num3)
            {
              if ((double) this.x.Dims[index2].Area > (double) this.x.Roofs[checked (this.x.Roofs.Length - 1)].Area)
                this.x.Roofs[checked (this.x.Roofs.Length - 1)].Area = this.x.Dims[index2].Area;
              checked { ++index2; }
            }
            if (this.Ext.Ext1Roof)
            {
              // ISSUE: variable of a reference type
              float& local;
              // ISSUE: explicit reference operation
              double num4 = (double) (^(local = ref this.x.Roofs[checked (this.x.Roofs.Length - 1)].Area) - (float) surveyClass.Extensions[1].RoofRoomFloor_Area);
              local = (float) num4;
            }
            this.x.Roofs[checked (this.x.Roofs.Length - 1)].Name = "Extension 1 Roof";
            switch (surveyClass.Extensions[1].RoofConstruction)
            {
              case 4:
              case 5:
              case 6:
                if (surveyClass.Extensions[1].RoofInsulation == 4)
                {
                  this.x.Roofs[checked (this.x.Roofs.Length - 1)].Type = "Pitched - insulated joists";
                  this.x.Roofs[checked (this.x.Roofs.Length - 1)].LoftInsulation = this.CheckJoists((Enums.RoofInsulationCode) surveyClass.Extensions[1].RoofInsulationThickness);
                  break;
                }
                this.x.Roofs[checked (this.x.Roofs.Length - 1)].Type = surveyClass.Extensions[1].RoofInsulation != 3 ? "Pitched" : "Pichted - insulated rafters";
                break;
              default:
                this.x.Roofs[checked (this.x.Roofs.Length - 1)].Type = "Flat roof";
                break;
            }
            this.x.Roofs[checked (this.x.Roofs.Length - 1)].Construction = "";
            switch (surveyClass.Extensions[1].RoofInsulation)
            {
              case 1:
                this.x.Roofs[checked (this.x.Roofs.Length - 1)].Construction = "None";
                break;
              case 2:
                this.x.Roofs[checked (this.x.Roofs.Length - 1)].Construction = "Unknown";
                break;
              case 3:
                this.x.Roofs[checked (this.x.Roofs.Length - 1)].Construction = "Rafters";
                break;
              case 4:
                this.x.Roofs[checked (this.x.Roofs.Length - 1)].Construction = "Joists";
                break;
              case 5:
                this.x.Roofs[checked (this.x.Roofs.Length - 1)].Construction = "Flat roof Insulation";
                break;
            }
            this.x.Roofs[checked (this.x.Roofs.Length - 1)].U_Value = this.RoofUValue(Rdsap, this.Ext.Ages.E1Age, 1);
            if (surveyClass.Extensions[1].RoofUValueKnown)
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].U_Value = (float) surveyClass.Extensions[1].RoofUValue;
            this.x.Roofs[checked (this.x.Roofs.Length - 1)].UvalueKnown = surveyClass.Extensions[1].RoofUValueKnown;
            this.x.Roofs[checked (this.x.Roofs.Length - 1)].K = 0.0f;
            this.x.Roofs[checked (this.x.Roofs.Length - 1)].EPCDesc = SAP_Module.Get_Enum_Desc(typeof (Enums.RoofConstructionCode), surveyClass.Extensions[1].RoofConstruction) + ", " + SAP_Module.Get_Enum_Desc(typeof (Enums.RoofInsulationCode), surveyClass.Extensions[1].RoofInsulation);
            break;
        }
        if (this.Ext.Ext1Roof)
        {
          if (!surveyClass.Extensions[1].RoofRoom_Edit)
          {
            if (this.x.Roofs == null)
            {
              this.x.Roofs = new SAP_Module.Opaques[1];
            }
            else
            {
              // ISSUE: variable of a reference type
              SAP_Module.Opaques[]& local;
              // ISSUE: explicit reference operation
              SAP_Module.Opaques[] opaquesArray = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local = ref this.x.Roofs), (Array) new SAP_Module.Opaques[checked (this.x.Roofs.Length + 1)]);
              local = opaquesArray;
            }
            this.x.Roofs[checked (this.x.Roofs.Length - 1)] = new SAP_Module.Opaques();
            this.x.Roofs[checked (this.x.Roofs.Length - 1)].Area = (float) surveyClass.Extensions[1].RoofRoomFloor_Area;
            this.x.Roofs[checked (this.x.Roofs.Length - 1)].Name = "Extension 1 Roof Room";
            this.x.Roofs[checked (this.x.Roofs.Length - 1)].Type = "Roof Room";
            this.x.Roofs[checked (this.x.Roofs.Length - 1)].U_Value = this.RoofRoomUValue(Rdsap, 1, "Roof");
            this.x.Roofs[checked (this.x.Roofs.Length - 1)].Ru = 0.0f;
            this.x.Roofs[checked (this.x.Roofs.Length - 1)].Curtain = false;
            this.x.Roofs[checked (this.x.Roofs.Length - 1)].K = 0.0f;
            switch (surveyClass.Extensions[1].RoofRoom_Insulation)
            {
              case 0:
                this.x.Roofs[checked (this.x.Roofs.Length - 1)].Construction = "Unknown";
                break;
              case 1:
                this.x.Roofs[checked (this.x.Roofs.Length - 1)].Construction = "None";
                break;
              case 2:
                this.x.Roofs[checked (this.x.Roofs.Length - 1)].Construction = "Flat ceiling only";
                break;
              case 3:
                this.x.Roofs[checked (this.x.Roofs.Length - 1)].Construction = "All Elements";
                break;
            }
            this.x.Roofs[checked (this.x.Roofs.Length - 1)].EPCDesc = SAP_Module.Get_Enum_Desc(typeof (Enums.RoofRoomInsulationCode), surveyClass.Extensions[1].RoofRoom_Insulation);
          }
          else
          {
            if (surveyClass.Extensions[1].RoofRoom_FlatCeiling[0].Area != 0.0)
            {
              // ISSUE: variable of a reference type
              SAP_Module.Opaques[]& local;
              // ISSUE: explicit reference operation
              SAP_Module.Opaques[] opaquesArray = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local = ref this.x.Roofs), (Array) new SAP_Module.Opaques[checked (this.x.Roofs.Length + 1)]);
              local = opaquesArray;
              this.x.Roofs[checked (this.x.Roofs.Length - 1)] = new SAP_Module.Opaques();
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].Area = (float) surveyClass.Extensions[1].RoofRoom_FlatCeiling[0].Area;
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].U_Value = (float) surveyClass.Extensions[1].RoofRoom_FlatCeiling[0].U_Value;
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].Name = "E1 Roof Room Flat Ceiling 1";
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].EPCDesc = "Roof Room";
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].Type = "Roof Room Edit";
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].UvalueKnown = true;
            }
            if (surveyClass.Extensions[1].RoofRoom_FlatCeiling[1].Area != 0.0)
            {
              // ISSUE: variable of a reference type
              SAP_Module.Opaques[]& local;
              // ISSUE: explicit reference operation
              SAP_Module.Opaques[] opaquesArray = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local = ref this.x.Roofs), (Array) new SAP_Module.Opaques[checked (this.x.Roofs.Length + 1)]);
              local = opaquesArray;
              this.x.Roofs[checked (this.x.Roofs.Length - 1)] = new SAP_Module.Opaques();
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].Area = (float) surveyClass.Extensions[1].RoofRoom_FlatCeiling[1].Area;
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].U_Value = (float) surveyClass.Extensions[1].RoofRoom_FlatCeiling[1].U_Value;
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].Name = "E1 Roof Room Flat Ceiling 2";
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].EPCDesc = "Roof Room";
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].Type = "Roof Room Edit";
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].UvalueKnown = true;
            }
            if (surveyClass.Extensions[1].RoofRoom_Slope[0].Area != 0.0)
            {
              // ISSUE: variable of a reference type
              SAP_Module.Opaques[]& local;
              // ISSUE: explicit reference operation
              SAP_Module.Opaques[] opaquesArray = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local = ref this.x.Roofs), (Array) new SAP_Module.Opaques[checked (this.x.Roofs.Length + 1)]);
              local = opaquesArray;
              this.x.Roofs[checked (this.x.Roofs.Length - 1)] = new SAP_Module.Opaques();
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].Area = (float) surveyClass.Extensions[1].RoofRoom_Slope[0].Area;
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].U_Value = (float) surveyClass.Extensions[1].RoofRoom_Slope[0].U_Value;
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].Name = "E1 Roof Room Sloped Roof 1";
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].EPCDesc = "Roof Room";
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].Type = "Roof Room Edit";
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].UvalueKnown = true;
            }
            if (surveyClass.Extensions[1].RoofRoom_Slope[1].Area != 0.0)
            {
              // ISSUE: variable of a reference type
              SAP_Module.Opaques[]& local;
              // ISSUE: explicit reference operation
              SAP_Module.Opaques[] opaquesArray = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local = ref this.x.Roofs), (Array) new SAP_Module.Opaques[checked (this.x.Roofs.Length + 1)]);
              local = opaquesArray;
              this.x.Roofs[checked (this.x.Roofs.Length - 1)] = new SAP_Module.Opaques();
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].Area = (float) surveyClass.Extensions[1].RoofRoom_Slope[1].Area;
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].U_Value = (float) surveyClass.Extensions[1].RoofRoom_Slope[1].U_Value;
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].Name = "E1 Roof Room Sloped Roof 2";
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].EPCDesc = "Roof Room Sloped Roof";
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].Type = "Roof Room Edit";
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].EPCDesc = "Roof Room";
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].UvalueKnown = true;
            }
          }
        }
      }
      if (this.Ext.Ext2)
      {
        switch (surveyClass.Extensions[2].RoofConstruction)
        {
          case 2:
          case 4:
          case 5:
          case 6:
            if (this.x.Roofs == null)
            {
              this.x.Roofs = new SAP_Module.Opaques[1];
            }
            else
            {
              // ISSUE: variable of a reference type
              SAP_Module.Opaques[]& local;
              // ISSUE: explicit reference operation
              SAP_Module.Opaques[] opaquesArray = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local = ref this.x.Roofs), (Array) new SAP_Module.Opaques[checked (this.x.Roofs.Length + 1)]);
              local = opaquesArray;
            }
            this.x.Roofs[checked (this.x.Roofs.Length - 1)] = new SAP_Module.Opaques();
            int num5 = checked (this.Ext.MStoreys + this.Ext.E1Storeys);
            int num6 = checked (this.Ext.MStoreys + this.Ext.E1Storeys + this.Ext.E2Storeys - 1);
            int index3 = num5;
            while (index3 <= num6)
            {
              if ((double) this.x.Dims[index3].Area > (double) this.x.Roofs[checked (this.x.Roofs.Length - 1)].Area)
                this.x.Roofs[checked (this.x.Roofs.Length - 1)].Area = this.x.Dims[index3].Area;
              checked { ++index3; }
            }
            if (this.Ext.Ext2Roof)
            {
              // ISSUE: variable of a reference type
              float& local;
              // ISSUE: explicit reference operation
              double num7 = (double) (^(local = ref this.x.Roofs[checked (this.x.Roofs.Length - 1)].Area) - (float) surveyClass.Extensions[2].RoofRoomFloor_Area);
              local = (float) num7;
            }
            this.x.Roofs[checked (this.x.Roofs.Length - 1)].Name = "Extension 2 Roof";
            switch (surveyClass.Extensions[2].RoofConstruction)
            {
              case 4:
              case 5:
              case 6:
                if (surveyClass.Extensions[2].RoofInsulation == 4)
                {
                  this.x.Roofs[checked (this.x.Roofs.Length - 1)].Type = "Pitched - insulated joists";
                  this.x.Roofs[checked (this.x.Roofs.Length - 1)].LoftInsulation = this.CheckJoists((Enums.RoofInsulationCode) surveyClass.Extensions[2].RoofInsulationThickness);
                  break;
                }
                this.x.Roofs[checked (this.x.Roofs.Length - 1)].Type = surveyClass.Extensions[2].RoofInsulation != 3 ? "Pitched" : "Pichted - insulated rafters";
                break;
              default:
                this.x.Roofs[checked (this.x.Roofs.Length - 1)].Type = "Flat roof";
                break;
            }
            switch (surveyClass.Extensions[2].RoofInsulation)
            {
              case 1:
                this.x.Roofs[checked (this.x.Roofs.Length - 1)].Construction = "None";
                break;
              case 2:
                this.x.Roofs[checked (this.x.Roofs.Length - 1)].Construction = "Unknown";
                break;
              case 3:
                this.x.Roofs[checked (this.x.Roofs.Length - 1)].Construction = "Rafters";
                break;
              case 4:
                this.x.Roofs[checked (this.x.Roofs.Length - 1)].Construction = "Joists";
                break;
              case 5:
                this.x.Roofs[checked (this.x.Roofs.Length - 1)].Construction = "Flat roof Insulation";
                break;
            }
            this.x.Roofs[checked (this.x.Roofs.Length - 1)].U_Value = this.RoofUValue(Rdsap, this.Ext.Ages.E2Age, 2);
            if (surveyClass.Extensions[2].RoofUValueKnown)
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].U_Value = (float) surveyClass.Extensions[2].RoofUValue;
            this.x.Roofs[checked (this.x.Roofs.Length - 1)].UvalueKnown = surveyClass.Extensions[2].RoofUValueKnown;
            this.x.Roofs[checked (this.x.Roofs.Length - 1)].K = 0.0f;
            this.x.Roofs[checked (this.x.Roofs.Length - 1)].EPCDesc = SAP_Module.Get_Enum_Desc(typeof (Enums.RoofConstructionCode), surveyClass.Extensions[2].RoofConstruction) + ", " + SAP_Module.Get_Enum_Desc(typeof (Enums.RoofInsulationCode), surveyClass.Extensions[2].RoofInsulation);
            break;
        }
        if (this.Ext.Ext2Roof)
        {
          if (!surveyClass.Extensions[2].RoofRoom_Edit)
          {
            if (this.x.Roofs == null)
            {
              this.x.Roofs = new SAP_Module.Opaques[1];
            }
            else
            {
              // ISSUE: variable of a reference type
              SAP_Module.Opaques[]& local;
              // ISSUE: explicit reference operation
              SAP_Module.Opaques[] opaquesArray = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local = ref this.x.Roofs), (Array) new SAP_Module.Opaques[checked (this.x.Roofs.Length + 1)]);
              local = opaquesArray;
            }
            this.x.Roofs[checked (this.x.Roofs.Length - 1)] = new SAP_Module.Opaques();
            this.x.Roofs[checked (this.x.Roofs.Length - 1)].Area = (float) surveyClass.Extensions[2].RoofRoomFloor_Area;
            this.x.Roofs[checked (this.x.Roofs.Length - 1)].Name = "Extension 2 Roof Room";
            this.x.Roofs[checked (this.x.Roofs.Length - 1)].Type = "Roof Room";
            this.x.Roofs[checked (this.x.Roofs.Length - 1)].Construction = "";
            switch (surveyClass.Extensions[2].RoofRoom_Insulation)
            {
              case 0:
                this.x.Roofs[checked (this.x.Roofs.Length - 1)].Construction = "Unknown";
                break;
              case 1:
                this.x.Roofs[checked (this.x.Roofs.Length - 1)].Construction = "None";
                break;
              case 2:
                this.x.Roofs[checked (this.x.Roofs.Length - 1)].Construction = "Flat ceiling only";
                break;
              case 3:
                this.x.Roofs[checked (this.x.Roofs.Length - 1)].Construction = "All Elements";
                break;
            }
            this.x.Roofs[checked (this.x.Roofs.Length - 1)].U_Value = this.RoofRoomUValue(Rdsap, 2, "Roof");
            this.x.Roofs[checked (this.x.Roofs.Length - 1)].Ru = 0.0f;
            this.x.Roofs[checked (this.x.Roofs.Length - 1)].Curtain = false;
            this.x.Roofs[checked (this.x.Roofs.Length - 1)].K = 0.0f;
            this.x.Roofs[checked (this.x.Roofs.Length - 1)].EPCDesc = SAP_Module.Get_Enum_Desc(typeof (Enums.RoofRoomInsulationCode), surveyClass.Extensions[2].RoofRoom_Insulation);
          }
          else
          {
            if (surveyClass.Extensions[2].RoofRoom_FlatCeiling[0].Area != 0.0)
            {
              // ISSUE: variable of a reference type
              SAP_Module.Opaques[]& local;
              // ISSUE: explicit reference operation
              SAP_Module.Opaques[] opaquesArray = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local = ref this.x.Roofs), (Array) new SAP_Module.Opaques[checked (this.x.Roofs.Length + 1)]);
              local = opaquesArray;
              this.x.Roofs[checked (this.x.Roofs.Length - 1)] = new SAP_Module.Opaques();
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].Area = (float) surveyClass.Extensions[2].RoofRoom_FlatCeiling[0].Area;
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].U_Value = (float) surveyClass.Extensions[2].RoofRoom_FlatCeiling[0].U_Value;
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].Name = "E2 Roof Room Flat Ceiling 1";
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].EPCDesc = "Roof Room";
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].Type = "Roof Room Edit";
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].UvalueKnown = true;
            }
            if (surveyClass.Extensions[2].RoofRoom_FlatCeiling[1].Area != 0.0)
            {
              // ISSUE: variable of a reference type
              SAP_Module.Opaques[]& local;
              // ISSUE: explicit reference operation
              SAP_Module.Opaques[] opaquesArray = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local = ref this.x.Roofs), (Array) new SAP_Module.Opaques[checked (this.x.Roofs.Length + 1)]);
              local = opaquesArray;
              this.x.Roofs[checked (this.x.Roofs.Length - 1)] = new SAP_Module.Opaques();
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].Area = (float) surveyClass.Extensions[2].RoofRoom_FlatCeiling[1].Area;
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].U_Value = (float) surveyClass.Extensions[2].RoofRoom_FlatCeiling[1].U_Value;
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].Name = "E2 Roof Room Flat Ceiling 2";
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].EPCDesc = "Roof Room";
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].Type = "Roof Room Edit";
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].UvalueKnown = true;
            }
            if (surveyClass.Extensions[2].RoofRoom_Slope[0].Area != 0.0)
            {
              // ISSUE: variable of a reference type
              SAP_Module.Opaques[]& local;
              // ISSUE: explicit reference operation
              SAP_Module.Opaques[] opaquesArray = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local = ref this.x.Roofs), (Array) new SAP_Module.Opaques[checked (this.x.Roofs.Length + 1)]);
              local = opaquesArray;
              this.x.Roofs[checked (this.x.Roofs.Length - 1)] = new SAP_Module.Opaques();
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].Area = (float) surveyClass.Extensions[2].RoofRoom_Slope[0].Area;
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].U_Value = (float) surveyClass.Extensions[2].RoofRoom_Slope[0].U_Value;
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].Name = "E2 Roof Room Sloped Roof 1";
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].EPCDesc = "Roof Room";
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].Type = "Roof Room Edit";
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].UvalueKnown = true;
            }
            if (surveyClass.Extensions[2].RoofRoom_Slope[1].Area != 0.0)
            {
              // ISSUE: variable of a reference type
              SAP_Module.Opaques[]& local;
              // ISSUE: explicit reference operation
              SAP_Module.Opaques[] opaquesArray = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local = ref this.x.Roofs), (Array) new SAP_Module.Opaques[checked (this.x.Roofs.Length + 1)]);
              local = opaquesArray;
              this.x.Roofs[checked (this.x.Roofs.Length - 1)] = new SAP_Module.Opaques();
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].Area = (float) surveyClass.Extensions[2].RoofRoom_Slope[1].Area;
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].U_Value = (float) surveyClass.Extensions[2].RoofRoom_Slope[1].U_Value;
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].Name = "E2 Roof Room Sloped Roof 2";
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].EPCDesc = "Roof Room";
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].Type = "Roof Room Edit";
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].UvalueKnown = true;
            }
          }
        }
      }
      if (this.Ext.Ext3)
      {
        switch (surveyClass.Extensions[3].RoofConstruction)
        {
          case 2:
          case 4:
          case 5:
          case 6:
            if (this.x.Roofs == null)
            {
              this.x.Roofs = new SAP_Module.Opaques[1];
            }
            else
            {
              // ISSUE: variable of a reference type
              SAP_Module.Opaques[]& local;
              // ISSUE: explicit reference operation
              SAP_Module.Opaques[] opaquesArray = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local = ref this.x.Roofs), (Array) new SAP_Module.Opaques[checked (this.x.Roofs.Length + 1)]);
              local = opaquesArray;
            }
            this.x.Roofs[checked (this.x.Roofs.Length - 1)] = new SAP_Module.Opaques();
            int num8 = checked (this.Ext.MStoreys + this.Ext.E1Storeys + this.Ext.E2Storeys);
            int num9 = checked (this.Ext.MStoreys + this.Ext.E1Storeys + this.Ext.E2Storeys + this.Ext.E3Storeys - 1);
            int index4 = num8;
            while (index4 <= num9)
            {
              if ((double) this.x.Dims[index4].Area > (double) this.x.Roofs[checked (this.x.Roofs.Length - 1)].Area)
                this.x.Roofs[checked (this.x.Roofs.Length - 1)].Area = this.x.Dims[index4].Area;
              checked { ++index4; }
            }
            if (this.Ext.Ext3Roof)
            {
              // ISSUE: variable of a reference type
              float& local;
              // ISSUE: explicit reference operation
              double num10 = (double) (^(local = ref this.x.Roofs[checked (this.x.Roofs.Length - 1)].Area) - (float) surveyClass.Extensions[3].RoofRoomFloor_Area);
              local = (float) num10;
            }
            this.x.Roofs[checked (this.x.Roofs.Length - 1)].Name = "Extension 3 Roof";
            switch (surveyClass.Extensions[3].RoofConstruction)
            {
              case 4:
              case 5:
              case 6:
                if (surveyClass.Extensions[3].RoofInsulation == 4)
                {
                  this.x.Roofs[checked (this.x.Roofs.Length - 1)].Type = "Pitched - insulated joists";
                  this.x.Roofs[checked (this.x.Roofs.Length - 1)].LoftInsulation = this.CheckJoists((Enums.RoofInsulationCode) surveyClass.Extensions[3].RoofInsulationThickness);
                  break;
                }
                this.x.Roofs[checked (this.x.Roofs.Length - 1)].Type = surveyClass.Extensions[3].RoofInsulation != 3 ? "Pitched" : "Pichted - insulated rafters";
                break;
              default:
                this.x.Roofs[checked (this.x.Roofs.Length - 1)].Type = "Flat roof";
                break;
            }
            this.x.Roofs[checked (this.x.Roofs.Length - 1)].Construction = "";
            switch (surveyClass.Extensions[3].RoofInsulation)
            {
              case 1:
                this.x.Roofs[checked (this.x.Roofs.Length - 1)].Construction = "None";
                break;
              case 2:
                this.x.Roofs[checked (this.x.Roofs.Length - 1)].Construction = "Unknown";
                break;
              case 3:
                this.x.Roofs[checked (this.x.Roofs.Length - 1)].Construction = "Rafters";
                break;
              case 4:
                this.x.Roofs[checked (this.x.Roofs.Length - 1)].Construction = "Joists";
                break;
              case 5:
                this.x.Roofs[checked (this.x.Roofs.Length - 1)].Construction = "Flat roof Insulation";
                break;
            }
            this.x.Roofs[checked (this.x.Roofs.Length - 1)].U_Value = this.RoofUValue(Rdsap, this.Ext.Ages.E3Age, 3);
            if (surveyClass.Extensions[3].RoofUValueKnown)
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].U_Value = (float) surveyClass.Extensions[3].RoofUValue;
            this.x.Roofs[checked (this.x.Roofs.Length - 1)].UvalueKnown = surveyClass.Extensions[3].RoofUValueKnown;
            this.x.Roofs[checked (this.x.Roofs.Length - 1)].K = 0.0f;
            this.x.Roofs[checked (this.x.Roofs.Length - 1)].EPCDesc = SAP_Module.Get_Enum_Desc(typeof (Enums.RoofConstructionCode), surveyClass.Extensions[3].RoofConstruction) + ", " + SAP_Module.Get_Enum_Desc(typeof (Enums.RoofInsulationCode), surveyClass.Extensions[3].RoofInsulation);
            break;
        }
        if (this.Ext.Ext3Roof)
        {
          if (!surveyClass.Extensions[3].RoofRoom_Edit)
          {
            if (this.x.Roofs == null)
            {
              this.x.Roofs = new SAP_Module.Opaques[1];
            }
            else
            {
              // ISSUE: variable of a reference type
              SAP_Module.Opaques[]& local;
              // ISSUE: explicit reference operation
              SAP_Module.Opaques[] opaquesArray = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local = ref this.x.Roofs), (Array) new SAP_Module.Opaques[checked (this.x.Roofs.Length + 1)]);
              local = opaquesArray;
            }
            this.x.Roofs[checked (this.x.Roofs.Length - 1)] = new SAP_Module.Opaques();
            this.x.Roofs[checked (this.x.Roofs.Length - 1)].Area = (float) surveyClass.Extensions[3].RoofRoomFloor_Area;
            this.x.Roofs[checked (this.x.Roofs.Length - 1)].Name = "Extension 3 Roof Room";
            this.x.Roofs[checked (this.x.Roofs.Length - 1)].Type = "Roof Room";
            this.x.Roofs[checked (this.x.Roofs.Length - 1)].Construction = "";
            switch (surveyClass.Extensions[1].RoofRoom_Insulation)
            {
              case 0:
                this.x.Roofs[checked (this.x.Roofs.Length - 1)].Construction = "Unknown";
                break;
              case 1:
                this.x.Roofs[checked (this.x.Roofs.Length - 1)].Construction = "None";
                break;
              case 2:
                this.x.Roofs[checked (this.x.Roofs.Length - 1)].Construction = "Flat ceiling only";
                break;
              case 3:
                this.x.Roofs[checked (this.x.Roofs.Length - 1)].Construction = "All Elements";
                break;
            }
            this.x.Roofs[checked (this.x.Roofs.Length - 1)].U_Value = this.RoofRoomUValue(Rdsap, 3, "Roof");
            this.x.Roofs[checked (this.x.Roofs.Length - 1)].Ru = 0.0f;
            this.x.Roofs[checked (this.x.Roofs.Length - 1)].Curtain = false;
            this.x.Roofs[checked (this.x.Roofs.Length - 1)].K = 0.0f;
            this.x.Roofs[checked (this.x.Roofs.Length - 1)].EPCDesc = SAP_Module.Get_Enum_Desc(typeof (Enums.RoofRoomInsulationCode), surveyClass.Extensions[3].RoofRoom_Insulation);
          }
          else
          {
            if (surveyClass.Extensions[3].RoofRoom_FlatCeiling[0].Area != 0.0)
            {
              // ISSUE: variable of a reference type
              SAP_Module.Opaques[]& local;
              // ISSUE: explicit reference operation
              SAP_Module.Opaques[] opaquesArray = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local = ref this.x.Roofs), (Array) new SAP_Module.Opaques[checked (this.x.Roofs.Length + 1)]);
              local = opaquesArray;
              this.x.Roofs[checked (this.x.Roofs.Length - 1)] = new SAP_Module.Opaques();
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].Area = (float) surveyClass.Extensions[3].RoofRoom_FlatCeiling[0].Area;
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].U_Value = (float) surveyClass.Extensions[3].RoofRoom_FlatCeiling[0].U_Value;
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].Name = "E3 Roof Room Flat Ceiling 1";
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].EPCDesc = "Roof Room";
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].Type = "Roof Room Edit";
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].UvalueKnown = true;
            }
            if (surveyClass.Extensions[3].RoofRoom_FlatCeiling[1].Area != 0.0)
            {
              // ISSUE: variable of a reference type
              SAP_Module.Opaques[]& local;
              // ISSUE: explicit reference operation
              SAP_Module.Opaques[] opaquesArray = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local = ref this.x.Roofs), (Array) new SAP_Module.Opaques[checked (this.x.Roofs.Length + 1)]);
              local = opaquesArray;
              this.x.Roofs[checked (this.x.Roofs.Length - 1)] = new SAP_Module.Opaques();
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].Area = (float) surveyClass.Extensions[3].RoofRoom_FlatCeiling[1].Area;
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].U_Value = (float) surveyClass.Extensions[3].RoofRoom_FlatCeiling[1].U_Value;
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].Name = "E3 Roof Room Flat Ceiling 2";
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].EPCDesc = "Roof Room";
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].Type = "Roof Room Edit";
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].UvalueKnown = true;
            }
            if (surveyClass.Extensions[3].RoofRoom_Slope[0].Area != 0.0)
            {
              // ISSUE: variable of a reference type
              SAP_Module.Opaques[]& local;
              // ISSUE: explicit reference operation
              SAP_Module.Opaques[] opaquesArray = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local = ref this.x.Roofs), (Array) new SAP_Module.Opaques[checked (this.x.Roofs.Length + 1)]);
              local = opaquesArray;
              this.x.Roofs[checked (this.x.Roofs.Length - 1)] = new SAP_Module.Opaques();
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].Area = (float) surveyClass.Extensions[3].RoofRoom_Slope[0].Area;
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].U_Value = (float) surveyClass.Extensions[3].RoofRoom_Slope[0].U_Value;
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].Name = "E3 Roof Room Sloped Roof 1";
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].EPCDesc = "Roof Room";
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].Type = "Roof Room Edit";
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].UvalueKnown = true;
            }
            if (surveyClass.Extensions[3].RoofRoom_Slope[1].Area != 0.0)
            {
              // ISSUE: variable of a reference type
              SAP_Module.Opaques[]& local;
              // ISSUE: explicit reference operation
              SAP_Module.Opaques[] opaquesArray = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local = ref this.x.Roofs), (Array) new SAP_Module.Opaques[checked (this.x.Roofs.Length + 1)]);
              local = opaquesArray;
              this.x.Roofs[checked (this.x.Roofs.Length - 1)] = new SAP_Module.Opaques();
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].Area = (float) surveyClass.Extensions[3].RoofRoom_Slope[1].Area;
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].U_Value = (float) surveyClass.Extensions[3].RoofRoom_Slope[1].U_Value;
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].Name = "E3 Roof Room Sloped Roof 2";
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].EPCDesc = "Roof Room";
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].Type = "Roof Room Edit";
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].UvalueKnown = true;
            }
          }
        }
      }
      if (this.Ext.Ext4)
      {
        switch (surveyClass.Extensions[4].RoofConstruction)
        {
          case 2:
          case 4:
          case 5:
          case 6:
            if (this.x.Roofs == null)
            {
              this.x.Roofs = new SAP_Module.Opaques[1];
            }
            else
            {
              // ISSUE: variable of a reference type
              SAP_Module.Opaques[]& local;
              // ISSUE: explicit reference operation
              SAP_Module.Opaques[] opaquesArray = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local = ref this.x.Roofs), (Array) new SAP_Module.Opaques[checked (this.x.Roofs.Length + 1)]);
              local = opaquesArray;
            }
            this.x.Roofs[checked (this.x.Roofs.Length - 1)] = new SAP_Module.Opaques();
            int num11 = checked (this.Ext.MStoreys + this.Ext.E1Storeys + this.Ext.E2Storeys + this.Ext.E3Storeys);
            int num12 = checked (this.Ext.MStoreys + this.Ext.E1Storeys + this.Ext.E2Storeys + this.Ext.E3Storeys + this.Ext.E4Storeys - 1);
            int index5 = num11;
            while (index5 <= num12)
            {
              if ((double) this.x.Dims[index5].Area > (double) this.x.Roofs[checked (this.x.Roofs.Length - 1)].Area)
                this.x.Roofs[checked (this.x.Roofs.Length - 1)].Area = this.x.Dims[index5].Area;
              checked { ++index5; }
            }
            if (this.Ext.Ext4Roof)
            {
              // ISSUE: variable of a reference type
              float& local;
              // ISSUE: explicit reference operation
              double num13 = (double) (^(local = ref this.x.Roofs[checked (this.x.Roofs.Length - 1)].Area) - (float) surveyClass.Extensions[4].RoofRoomFloor_Area);
              local = (float) num13;
            }
            this.x.Roofs[checked (this.x.Roofs.Length - 1)].Name = "Extension 4 Roof";
            switch (surveyClass.Extensions[4].RoofConstruction)
            {
              case 4:
              case 5:
              case 6:
                if (surveyClass.Extensions[4].RoofInsulation == 4)
                {
                  this.x.Roofs[checked (this.x.Roofs.Length - 1)].Type = "Pitched - insulated joists";
                  this.x.Roofs[checked (this.x.Roofs.Length - 1)].LoftInsulation = this.CheckJoists((Enums.RoofInsulationCode) surveyClass.Extensions[4].RoofInsulationThickness);
                  break;
                }
                this.x.Roofs[checked (this.x.Roofs.Length - 1)].Type = surveyClass.Extensions[4].RoofInsulation != 3 ? "Pitched" : "Pichted - insulated rafters";
                break;
              default:
                this.x.Roofs[checked (this.x.Roofs.Length - 1)].Type = "Flat roof";
                break;
            }
            this.x.Roofs[checked (this.x.Roofs.Length - 1)].Construction = "";
            switch (surveyClass.Extensions[4].RoofInsulation)
            {
              case 1:
                this.x.Roofs[checked (this.x.Roofs.Length - 1)].Construction = "None";
                break;
              case 2:
                this.x.Roofs[checked (this.x.Roofs.Length - 1)].Construction = "Unknown";
                break;
              case 3:
                this.x.Roofs[checked (this.x.Roofs.Length - 1)].Construction = "Rafters";
                break;
              case 4:
                this.x.Roofs[checked (this.x.Roofs.Length - 1)].Construction = "Joists";
                break;
              case 5:
                this.x.Roofs[checked (this.x.Roofs.Length - 1)].Construction = "Flat roof Insulation";
                break;
            }
            this.x.Roofs[checked (this.x.Roofs.Length - 1)].U_Value = this.RoofUValue(Rdsap, this.Ext.Ages.E4Age, 4);
            if (surveyClass.Extensions[4].RoofUValueKnown)
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].U_Value = (float) surveyClass.Extensions[4].RoofUValue;
            this.x.Roofs[checked (this.x.Roofs.Length - 1)].UvalueKnown = surveyClass.Extensions[4].RoofUValueKnown;
            this.x.Roofs[checked (this.x.Roofs.Length - 1)].K = 0.0f;
            this.x.Roofs[checked (this.x.Roofs.Length - 1)].EPCDesc = SAP_Module.Get_Enum_Desc(typeof (Enums.RoofConstructionCode), surveyClass.Extensions[4].RoofConstruction) + ", " + SAP_Module.Get_Enum_Desc(typeof (Enums.RoofInsulationCode), surveyClass.Extensions[4].RoofInsulation);
            break;
        }
        if (this.Ext.Ext4Roof)
        {
          if (!surveyClass.Extensions[4].RoofRoom_Edit)
          {
            if (this.x.Roofs == null)
            {
              this.x.Roofs = new SAP_Module.Opaques[1];
            }
            else
            {
              // ISSUE: variable of a reference type
              SAP_Module.Opaques[]& local;
              // ISSUE: explicit reference operation
              SAP_Module.Opaques[] opaquesArray = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local = ref this.x.Roofs), (Array) new SAP_Module.Opaques[checked (this.x.Roofs.Length + 1)]);
              local = opaquesArray;
            }
            this.x.Roofs[checked (this.x.Roofs.Length - 1)] = new SAP_Module.Opaques();
            this.x.Roofs[checked (this.x.Roofs.Length - 1)].Area = (float) surveyClass.Extensions[4].RoofRoomFloor_Area;
            this.x.Roofs[checked (this.x.Roofs.Length - 1)].Name = "Extension 4 Roof Room";
            this.x.Roofs[checked (this.x.Roofs.Length - 1)].Type = "Roof Room";
            this.x.Roofs[checked (this.x.Roofs.Length - 1)].Construction = "";
            switch (surveyClass.Extensions[4].RoofRoom_Insulation)
            {
              case 0:
                this.x.Roofs[checked (this.x.Roofs.Length - 1)].Construction = "Unknown";
                break;
              case 1:
                this.x.Roofs[checked (this.x.Roofs.Length - 1)].Construction = "None";
                break;
              case 2:
                this.x.Roofs[checked (this.x.Roofs.Length - 1)].Construction = "Flat ceiling only";
                break;
              case 3:
                this.x.Roofs[checked (this.x.Roofs.Length - 1)].Construction = "All Elements";
                break;
            }
            this.x.Roofs[checked (this.x.Roofs.Length - 1)].U_Value = this.RoofRoomUValue(Rdsap, 4, "Roof");
            this.x.Roofs[checked (this.x.Roofs.Length - 1)].Ru = 0.0f;
            this.x.Roofs[checked (this.x.Roofs.Length - 1)].Curtain = false;
            this.x.Roofs[checked (this.x.Roofs.Length - 1)].K = 0.0f;
            this.x.Roofs[checked (this.x.Roofs.Length - 1)].EPCDesc = SAP_Module.Get_Enum_Desc(typeof (Enums.RoofRoomInsulationCode), surveyClass.Extensions[4].RoofRoom_Insulation);
          }
          else
          {
            if (surveyClass.Extensions[4].RoofRoom_FlatCeiling[0].Area != 0.0)
            {
              // ISSUE: variable of a reference type
              SAP_Module.Opaques[]& local;
              // ISSUE: explicit reference operation
              SAP_Module.Opaques[] opaquesArray = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local = ref this.x.Roofs), (Array) new SAP_Module.Opaques[checked (this.x.Roofs.Length + 1)]);
              local = opaquesArray;
              this.x.Roofs[checked (this.x.Roofs.Length - 1)] = new SAP_Module.Opaques();
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].Area = (float) surveyClass.Extensions[4].RoofRoom_FlatCeiling[0].Area;
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].U_Value = (float) surveyClass.Extensions[4].RoofRoom_FlatCeiling[0].U_Value;
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].Name = "E4 Roof Room Flat Ceiling 1";
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].EPCDesc = "Roof Room";
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].Type = "Roof Room Edit";
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].UvalueKnown = true;
            }
            if (surveyClass.Extensions[4].RoofRoom_FlatCeiling[1].Area != 0.0)
            {
              // ISSUE: variable of a reference type
              SAP_Module.Opaques[]& local;
              // ISSUE: explicit reference operation
              SAP_Module.Opaques[] opaquesArray = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local = ref this.x.Roofs), (Array) new SAP_Module.Opaques[checked (this.x.Roofs.Length + 1)]);
              local = opaquesArray;
              this.x.Roofs[checked (this.x.Roofs.Length - 1)] = new SAP_Module.Opaques();
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].Area = (float) surveyClass.Extensions[4].RoofRoom_FlatCeiling[1].Area;
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].U_Value = (float) surveyClass.Extensions[4].RoofRoom_FlatCeiling[1].U_Value;
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].Name = "E4 Roof Room Flat Ceiling 2";
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].EPCDesc = "Roof Room";
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].Type = "Roof Room Edit";
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].UvalueKnown = true;
            }
            if (surveyClass.Extensions[4].RoofRoom_Slope[0].Area != 0.0)
            {
              // ISSUE: variable of a reference type
              SAP_Module.Opaques[]& local;
              // ISSUE: explicit reference operation
              SAP_Module.Opaques[] opaquesArray = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local = ref this.x.Roofs), (Array) new SAP_Module.Opaques[checked (this.x.Roofs.Length + 1)]);
              local = opaquesArray;
              this.x.Roofs[checked (this.x.Roofs.Length - 1)] = new SAP_Module.Opaques();
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].Area = (float) surveyClass.Extensions[4].RoofRoom_Slope[0].Area;
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].U_Value = (float) surveyClass.Extensions[4].RoofRoom_Slope[0].U_Value;
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].Name = "E4 Roof Room Sloped Roof 1";
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].EPCDesc = "Roof Room";
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].Type = "Roof Room Edit";
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].UvalueKnown = true;
            }
            if (surveyClass.Extensions[4].RoofRoom_Slope[1].Area != 0.0)
            {
              // ISSUE: variable of a reference type
              SAP_Module.Opaques[]& local;
              // ISSUE: explicit reference operation
              SAP_Module.Opaques[] opaquesArray = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local = ref this.x.Roofs), (Array) new SAP_Module.Opaques[checked (this.x.Roofs.Length + 1)]);
              local = opaquesArray;
              this.x.Roofs[checked (this.x.Roofs.Length - 1)] = new SAP_Module.Opaques();
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].Area = (float) surveyClass.Extensions[4].RoofRoom_Slope[1].Area;
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].U_Value = (float) surveyClass.Extensions[4].RoofRoom_Slope[1].U_Value;
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].Name = "E4 Roof Room Sloped Roof 2";
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].EPCDesc = "Roof Room";
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].Type = "Roof Room Edit";
              this.x.Roofs[checked (this.x.Roofs.Length - 1)].UvalueKnown = true;
            }
          }
        }
      }
      if (this.x.Roofs != null)
        this.x.NoofRoofs = this.x.Roofs.Length;
    }

    private float RoofUValue(Survey_Class RdSAP, string WallAge, int Extension)
    {
      float num = 0.0f;
      string Right = "";
      Survey_Class surveyClass = RdSAP;
      bool flag;
      if (surveyClass.Extensions[Extension].RoofInsulation == 4)
      {
        if (surveyClass.Extensions[Extension].RoofConstruction == 4 | surveyClass.Extensions[Extension].RoofConstruction == 5)
        {
          switch (surveyClass.Extensions[Extension].RoofInsulationThickness)
          {
            case 1:
              num = 2.3f;
              break;
            case 3:
              num = 1.5f;
              break;
            case 4:
              num = 1f;
              break;
            case 5:
              num = 0.68f;
              break;
            case 6:
              num = 0.5f;
              break;
            case 7:
              num = 0.4f;
              break;
            case 8:
              num = 0.29f;
              break;
            case 9:
              num = 0.2f;
              break;
            case 10:
              num = 0.16f;
              break;
            case 11:
              num = 0.13f;
              break;
          }
        }
        else if (surveyClass.Extensions[Extension].RoofConstruction == 6)
        {
          switch (surveyClass.Extensions[Extension].RoofInsulationThickness)
          {
            case 1:
              num = 0.35f;
              break;
            case 3:
              num = 0.32f;
              break;
            case 4:
              num = 0.3f;
              break;
            case 5:
              num = 0.25f;
              break;
            case 6:
              num = 0.22f;
              break;
            case 7:
              num = 0.2f;
              break;
            case 8:
              num = 0.16f;
              break;
            case 9:
              num = 0.13f;
              break;
            case 10:
              num = 0.11f;
              break;
            case 11:
              num = 0.1f;
              break;
          }
        }
        else
          flag = true;
      }
      else
        flag = true;
      if (flag)
      {
        switch (surveyClass.Extensions[Extension].RoofConstruction)
        {
          case 2:
            Right = "Flat roof";
            break;
          case 3:
            Right = "Room-in-roof";
            return 0.0f;
          case 4:
            switch (surveyClass.Extensions[Extension].RoofInsulation)
            {
              case 1:
                Right = "Pitched rafters";
                break;
              case 2:
                Right = "Pitched joists";
                break;
              case 3:
                Right = "Pitched rafters";
                break;
              case 4:
                Right = "Pitched joists";
                break;
            }
            break;
          case 5:
            Right = "Pitched joists";
            break;
          case 6:
            Right = "Thatched roof";
            break;
        }
        num = surveyClass.Extensions[Extension].RoofInsulation != 1 ? (float) Conversion.Val(SAP_Module.AppenS.s10.Where<AppendixS.RoofUValue>((Func<AppendixS.RoofUValue, bool>) (b => Operators.CompareString(b.AgeBand, WallAge, false) == 0 & Operators.CompareString(b.RoofType, Right, false) == 0)).Single<AppendixS.RoofUValue>().Uvalue) : (float) Conversion.Val(SAP_Module.AppenS.s10.Where<AppendixS.RoofUValue>((Func<AppendixS.RoofUValue, bool>) (b => Operators.CompareString(b.AgeBand, "A", false) == 0 & Operators.CompareString(b.RoofType, Right, false) == 0)).Single<AppendixS.RoofUValue>().Uvalue);
        if (surveyClass.General.Country == 3 && Operators.CompareString(WallAge, "K", false) == 0 & (double) num == 0.25)
          num = 0.2f;
        if (surveyClass.Extensions[Extension].RoofConstruction == 2)
        {
          if (surveyClass.Extensions[Extension].RoofInsulation == 5)
          {
            try
            {
              switch (surveyClass.Extensions[Extension].RoofInsulationThickness)
              {
                case 2:
                case 5:
                  if ((double) num > 0.68)
                  {
                    num = 0.68f;
                    break;
                  }
                  break;
                case 7:
                  if ((double) num > 0.4)
                  {
                    num = 0.4f;
                    break;
                  }
                  break;
                case 8:
                  if ((double) num > 0.3)
                  {
                    num = 0.3f;
                    break;
                  }
                  break;
              }
            }
            catch (Exception ex)
            {
              ProjectData.SetProjectError(ex);
              ProjectData.ClearProjectError();
            }
          }
        }
        if ((surveyClass.Extensions[Extension].RoofConstruction == 4 | surveyClass.Extensions[Extension].RoofConstruction == 5) & surveyClass.Extensions[Extension].RoofInsulation == 3)
        {
          switch (surveyClass.Extensions[Extension].RoofInsulationThickness)
          {
            case 5:
              if ((double) num > 0.68)
              {
                num = 0.68f;
                break;
              }
              break;
            case 7:
              if ((double) num > 0.4)
              {
                num = 0.4f;
                break;
              }
              break;
            case 8:
              if ((double) num > 0.3)
              {
                num = 0.3f;
                break;
              }
              break;
          }
        }
        if (surveyClass.Extensions[Extension].RoofConstruction == 4 & surveyClass.Extensions[Extension].RoofInsulation == 1)
          num = 2.3f;
        if (surveyClass.Extensions[Extension].RoofConstruction == 6 & surveyClass.Extensions[Extension].RoofInsulation == 1)
          num = 0.35f;
      }
      return num;
    }

    private void Openings(Survey_Class RdSAP)
    {
      Survey_Class surveyClass = RdSAP;
      float num1 = 0.0f;
      this.x.NoofDoors = surveyClass.Openings.DoorCount;
      bool flag1;
      switch (surveyClass.General.PropertyType1)
      {
        case 3:
        case 4:
          switch (surveyClass.Flat_Maisonette.HeatLossCorridor)
          {
            case 1:
              num1 = 3f;
              break;
            case 2:
              break;
            default:
              num1 = 1.4f;
              flag1 = true;
              break;
          }
          break;
        default:
          num1 = Operators.CompareString(this.Ext.Ages.MAge, "K", false) != 0 ? 3f : 2f;
          break;
      }
      this.x.Doors = new SAP_Module.Door[checked (this.x.NoofDoors - 1 + 1)];
      int num2 = checked (this.x.NoofDoors - 1);
      int index1 = 0;
      while (index1 <= num2)
      {
        this.x.Doors[index1] = new SAP_Module.Door();
        this.x.Doors[index1].Area = 1.85f;
        this.x.Doors[index1].Count = 1;
        this.x.Doors[index1].DoorType = "Solid";
        this.x.Doors[index1].FF = 0.0f;
        this.x.Doors[index1].g = 0.0f;
        if (index1 == 0 & (surveyClass.Flat_Maisonette.HeatLossCorridor == 2 | surveyClass.Flat_Maisonette.HeatLossCorridor == 3) & (surveyClass.General.PropertyType1 == 3 | surveyClass.General.PropertyType1 == 4))
        {
          this.x.Doors[index1].Location = "Flat Corridor";
          if (surveyClass.Extensions[0].AltPresent & surveyClass.Extensions[0].AltShelteredWall == 1)
            this.x.Doors[index1].Location = "Alternative Wall 0";
        }
        else
          this.x.Doors[index1].Location = "Main Wall";
        this.x.Doors[index1].Overshading = "Average or unknown";
        this.x.Doors[index1].UValueSource = "Manufacturer";
        if (index1 >= checked (surveyClass.Openings.DoorCount - surveyClass.Openings.InsulatedDoorCount))
        {
          this.x.Doors[index1].Name = "Insulated Door";
          this.x.Doors[index1].U = (float) surveyClass.Openings.InsulatedUValue;
        }
        else
        {
          this.x.Doors[index1].Name = "UnInsulated Door";
          this.x.Doors[index1].U = num1;
          if (index1 > 0 & flag1)
            this.x.Doors[index1].U = 3f;
        }
        checked { ++index1; }
      }
      switch (surveyClass.Openings.GlazedArea)
      {
        case 1:
        case 2:
        case 3:
          float num3 = 0.0f;
          float num4 = 0.0f;
          int num5 = checked (this.x.Dims.Length - 1);
          int index2 = 0;
          while (index2 <= num5)
          {
            num4 += this.x.Dims[index2].Area;
            checked { ++index2; }
          }
          if (this.Ext.Cons)
            num4 -= this.x.Dims[checked (this.x.Dims.Length - 1)].Area;
          int num6 = checked (this.Ext.MStoreys - 1);
          int index3 = 0;
          while (index3 <= num6)
          {
            if (index3 == 0 || !(index3 == checked (this.Ext.MStoreys - 1) & this.Ext.MainRoof))
              ;
            RdSAP_TO_SAP.Extensions ext;
            double num7 = (double) (ext = this.Ext).MArea + (double) this.x.Dims[index3].Area;
            ext.MArea = (float) num7;
            checked { ++index3; }
          }
          if (this.Ext.Ext1)
          {
            int mstoreys = this.Ext.MStoreys;
            int num8 = checked (this.Ext.MStoreys + this.Ext.E1Storeys - 1);
            int index4 = mstoreys;
            while (index4 <= num8)
            {
              if (index4 == this.Ext.MStoreys || !(index4 == checked (this.Ext.MStoreys + this.Ext.E1Storeys - 1) & this.Ext.Ext1Roof))
                ;
              RdSAP_TO_SAP.Extensions ext;
              double num9 = (double) (ext = this.Ext).E1Area + (double) this.x.Dims[index4].Area;
              ext.E1Area = (float) num9;
              checked { ++index4; }
            }
          }
          if (this.Ext.Ext2)
          {
            int num10 = checked (this.Ext.MStoreys + this.Ext.E1Storeys);
            int num11 = checked (this.Ext.MStoreys + this.Ext.E1Storeys + this.Ext.E2Storeys - 1);
            int index5 = num10;
            while (index5 <= num11)
            {
              if (index5 == checked (this.Ext.MStoreys + this.Ext.E1Storeys) || !(index5 == checked (this.Ext.MStoreys + this.Ext.E1Storeys + this.Ext.E2Storeys - 1) & this.Ext.Ext2Roof))
                ;
              RdSAP_TO_SAP.Extensions ext;
              double num12 = (double) (ext = this.Ext).E2Area + (double) this.x.Dims[index5].Area;
              ext.E2Area = (float) num12;
              checked { ++index5; }
            }
          }
          if (this.Ext.Ext3)
          {
            int num13 = checked (this.Ext.MStoreys + this.Ext.E1Storeys + this.Ext.E2Storeys);
            int num14 = checked (this.Ext.MStoreys + this.Ext.E1Storeys + this.Ext.E2Storeys + this.Ext.E3Storeys - 1);
            int index6 = num13;
            while (index6 <= num14)
            {
              if (index6 == checked (this.Ext.MStoreys + this.Ext.E1Storeys + this.Ext.E2Storeys) || !(index6 == checked (this.Ext.MStoreys + this.Ext.E1Storeys + this.Ext.E2Storeys + this.Ext.E3Storeys - 1) & this.Ext.Ext3Roof))
                ;
              RdSAP_TO_SAP.Extensions ext;
              double num15 = (double) (ext = this.Ext).E3Area + (double) this.x.Dims[index6].Area;
              ext.E3Area = (float) num15;
              checked { ++index6; }
            }
          }
          if (this.Ext.Ext4)
          {
            int num16 = checked (this.Ext.MStoreys + this.Ext.E1Storeys + this.Ext.E2Storeys + this.Ext.E3Storeys);
            int num17 = checked (this.Ext.MStoreys + this.Ext.E1Storeys + this.Ext.E2Storeys + this.Ext.E3Storeys + this.Ext.E4Storeys - 1);
            int index7 = num16;
            while (index7 <= num17)
            {
              if (index7 == checked (this.Ext.MStoreys + this.Ext.E1Storeys + this.Ext.E2Storeys) || !(index7 == checked (this.Ext.MStoreys + this.Ext.E1Storeys + this.Ext.E2Storeys + this.Ext.E3Storeys + this.Ext.E4Storeys - 1) & this.Ext.Ext4Roof))
                ;
              RdSAP_TO_SAP.Extensions ext;
              double num18 = (double) (ext = this.Ext).E4Area + (double) this.x.Dims[index7].Area;
              ext.E4Area = (float) num18;
              checked { ++index7; }
            }
          }
          if (surveyClass.General.PropertyType1 == 1 | surveyClass.General.PropertyType1 == 2)
          {
            string mage = this.Ext.Ages.MAge;
            // ISSUE: reference to a compiler-generated method
            switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(mage))
            {
              case 3222007936:
                if (Operators.CompareString(mage, "E", false) == 0)
                {
                  num3 = (float) (0.1239 * (double) num4 + 7.332);
                  goto label_89;
                }
                else
                  goto label_89;
              case 3238785555:
                if (Operators.CompareString(mage, "D", false) == 0)
                {
                  num3 = (float) (0.1294 * (double) num4 + 5.515);
                  goto label_89;
                }
                else
                  goto label_89;
              case 3255563174:
                if (Operators.CompareString(mage, "G", false) == 0)
                {
                  num3 = (float) (0.1356 * (double) num4 + 5.242);
                  goto label_89;
                }
                else
                  goto label_89;
              case 3272340793:
                if (Operators.CompareString(mage, "F", false) == 0)
                {
                  num3 = (float) (0.1252 * (double) num4 + 5.52);
                  goto label_89;
                }
                else
                  goto label_89;
              case 3289118412:
                if (Operators.CompareString(mage, "A", false) == 0)
                  break;
                goto label_89;
              case 3322673650:
                if (Operators.CompareString(mage, "C", false) == 0)
                  break;
                goto label_89;
              case 3339451269:
                if (Operators.CompareString(mage, "B", false) == 0)
                  break;
                goto label_89;
              case 3423339364:
                if (Operators.CompareString(mage, "I", false) == 0)
                {
                  num3 = (float) (0.1382 * (double) num4 - 0.027);
                  goto label_89;
                }
                else
                  goto label_89;
              case 3440116983:
                if (Operators.CompareString(mage, "H", false) == 0)
                {
                  num3 = (float) (0.0948 * (double) num4 + 6.534);
                  goto label_89;
                }
                else
                  goto label_89;
              case 3456894602:
                if (Operators.CompareString(mage, "K", false) == 0)
                  goto label_67;
                else
                  goto label_89;
              case 3473672221:
                if (Operators.CompareString(mage, "J", false) == 0)
                  goto label_67;
                else
                  goto label_89;
              default:
                goto label_89;
            }
            num3 = (float) (0.122 * (double) num4 + 6.875);
            goto label_89;
label_67:
            num3 = (float) (0.1435 * (double) num4 - 0.403);
          }
          else
          {
            string mage = this.Ext.Ages.MAge;
            // ISSUE: reference to a compiler-generated method
            switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(mage))
            {
              case 3222007936:
                if (Operators.CompareString(mage, "E", false) == 0)
                {
                  num3 = (float) (0.0717 * (double) num4 + 6.56);
                  goto default;
                }
                else
                  goto default;
              case 3238785555:
                if (Operators.CompareString(mage, "D", false) == 0)
                {
                  num3 = (float) (0.0341 * (double) num4 + 8.562);
                  goto default;
                }
                else
                  goto default;
              case 3255563174:
                if (Operators.CompareString(mage, "G", false) == 0)
                {
                  num3 = (float) (0.051 * (double) num4 + 4.554);
                  goto default;
                }
                else
                  goto default;
              case 3272340793:
                if (Operators.CompareString(mage, "F", false) == 0)
                {
                  num3 = (float) (0.1199 * (double) num4 + 1.975);
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
                  num3 = (float) (0.1148 * (double) num4 + 0.392);
                  goto default;
                }
                else
                  goto default;
              case 3440116983:
                if (Operators.CompareString(mage, "H", false) == 0)
                {
                  num3 = (float) (0.0813 * (double) num4 + 3.744);
                  goto default;
                }
                else
                  goto default;
              case 3456894602:
                if (Operators.CompareString(mage, "K", false) == 0)
                  goto label_87;
                else
                  goto default;
              case 3473672221:
                if (Operators.CompareString(mage, "J", false) == 0)
                  goto label_87;
                else
                  goto default;
              default:
label_88:
                goto label_89;
            }
            num3 = (float) (0.0801 * (double) num4 + 5.58);
            goto label_88;
label_87:
            num3 = (float) (0.1148 * (double) num4 + 0.392);
            goto label_88;
          }
label_89:
          if (surveyClass.Openings.GlazedArea == 3)
            num3 *= 0.75f;
          if (surveyClass.Openings.GlazedArea == 2)
            num3 *= 1.25f;
          bool flag2 = false;
          float num19;
          float num20;
          switch (surveyClass.Openings.WindowMultipleGlazedType)
          {
            case 1:
            case 3:
              num19 = 3.1f;
              num20 = 0.76f;
              break;
            case 2:
              num19 = 2f;
              num20 = 0.72f;
              break;
            case 4:
              num19 = 2.4f;
              num20 = 0.76f;
              break;
            case 6:
              num19 = 1.8f;
              num20 = 0.68f;
              break;
            case 7:
            case 8:
              num19 = (float) surveyClass.Openings.WindowsUValue;
              num20 = (float) surveyClass.Openings.WindowSolarTransmittance;
              if (surveyClass.Openings.WindowDataSource == 2)
              {
                flag2 = true;
                break;
              }
              break;
          }
          int num21 = !(surveyClass.Openings.MultipleGlazedProportion == 0.0 | surveyClass.Openings.MultipleGlazedProportion == 100.0) ? 2 : 1;
          this.x.Windows = !this.Ext.Ext1 ? new SAP_Module.Window[checked (num21 - 1 + 1)] : (!this.Ext.Ext2 ? new SAP_Module.Window[checked (2 * num21 - 1 + 1)] : (!this.Ext.Ext3 ? new SAP_Module.Window[checked (3 * num21 - 1 + 1)] : (!this.Ext.Ext4 ? new SAP_Module.Window[checked (4 * num21 - 1 + 1)] : new SAP_Module.Window[checked (5 * num21 - 1 + 1)])));
          int num22 = checked (this.x.Windows.Length - 1);
          int index8 = 0;
          while (index8 <= num22)
          {
            this.x.Windows[index8] = new SAP_Module.Window();
            checked { ++index8; }
          }
          if (surveyClass.Openings.MultipleGlazedProportion == 0.0)
          {
            this.x.Windows[0].Area = num3 * this.Ext.MArea / num4;
            this.x.Windows[0].U = 4.8f;
            this.x.Windows[0].g = 0.85f;
            this.x.Windows[0].Location = "Main Wall";
            this.x.Windows[0].GlazingType = "Single-glazed";
          }
          else if (surveyClass.Openings.MultipleGlazedProportion == 100.0)
          {
            this.x.Windows[0].Area = num3 * this.Ext.MArea / num4;
            this.x.Windows[0].U = num19;
            this.x.Windows[0].g = num20;
            this.x.Windows[0].Location = "Main Wall";
            this.x.Windows[0].GlazingType = this.WindowType((Enums.GlazedType) surveyClass.Openings.WindowMultipleGlazedType);
            if ((double) this.x.Windows[0].Area > (double) this.x.Walls[0].Area * 0.9)
              this.x.Windows[0].Area = 0.9f * this.x.Walls[0].Area;
          }
          else
          {
            this.x.Windows[0].Area = (float) ((double) num3 * (double) this.Ext.MArea / (double) num4 * surveyClass.Openings.MultipleGlazedProportion / 100.0);
            this.x.Windows[0].U = num19;
            this.x.Windows[0].g = num20;
            this.x.Windows[0].Location = "Main Wall";
            this.x.Windows[0].GlazingType = this.WindowType((Enums.GlazedType) surveyClass.Openings.WindowMultipleGlazedType);
            this.x.Windows[1].Area = (float) ((double) num3 * (double) this.Ext.MArea / (double) num4 * (100.0 - surveyClass.Openings.MultipleGlazedProportion) / 100.0);
            this.x.Windows[1].U = 4.8f;
            this.x.Windows[1].g = 0.85f;
            this.x.Windows[1].Location = "Main Wall";
            this.x.Windows[1].GlazingType = "Single-glazed";
          }
          if (this.Ext.Ext1)
          {
            if (surveyClass.Openings.MultipleGlazedProportion == 0.0)
            {
              this.x.Windows[1].Area = (float) Math.Round((double) num3 * (double) this.Ext.E1Area / (double) num4, 2);
              this.x.Windows[1].U = 4.8f;
              this.x.Windows[1].g = 0.85f;
              this.x.Windows[1].Location = "Extension 1 Wall";
              this.x.Windows[1].GlazingType = "Single-glazed";
            }
            else if (surveyClass.Openings.MultipleGlazedProportion == 100.0)
            {
              this.x.Windows[1].Area = (float) Math.Round((double) num3 * (double) this.Ext.E1Area / (double) num4, 2);
              this.x.Windows[1].U = num19;
              this.x.Windows[1].g = num20;
              this.x.Windows[1].Location = "Extension 1 Wall";
              this.x.Windows[1].GlazingType = this.WindowType((Enums.GlazedType) surveyClass.Openings.WindowMultipleGlazedType);
            }
            else
            {
              this.x.Windows[2].Area = (float) Math.Round((double) num3 * (double) this.Ext.E1Area / (double) num4 * surveyClass.Openings.MultipleGlazedProportion / 100.0, 2);
              this.x.Windows[2].U = num19;
              this.x.Windows[2].g = num20;
              this.x.Windows[2].Location = "Extension 1 Wall";
              this.x.Windows[2].GlazingType = this.WindowType((Enums.GlazedType) surveyClass.Openings.WindowMultipleGlazedType);
              this.x.Windows[3].Area = (float) Math.Round((double) num3 * (double) this.Ext.E1Area / (double) num4 * (100.0 - surveyClass.Openings.MultipleGlazedProportion) / 100.0, 2);
              this.x.Windows[3].U = 4.8f;
              this.x.Windows[3].g = 0.85f;
              this.x.Windows[3].Location = "Extension 1 Wall";
              this.x.Windows[3].GlazingType = "Single-glazed";
            }
          }
          if (this.Ext.Ext2)
          {
            if (surveyClass.Openings.MultipleGlazedProportion == 0.0)
            {
              this.x.Windows[2].Area = (float) Math.Round((double) num3 * (double) this.Ext.E2Area / (double) num4, 2);
              this.x.Windows[2].U = 4.8f;
              this.x.Windows[2].g = 0.85f;
              this.x.Windows[2].Location = "Extension 2 Wall";
              this.x.Windows[2].GlazingType = "Single-glazed";
            }
            else if (surveyClass.Openings.MultipleGlazedProportion == 100.0)
            {
              this.x.Windows[2].Area = (float) Math.Round((double) num3 * (double) this.Ext.E2Area / (double) num4, 2);
              this.x.Windows[2].U = num19;
              this.x.Windows[2].g = num20;
              this.x.Windows[2].Location = "Extension 2 Wall";
              this.x.Windows[2].GlazingType = this.WindowType((Enums.GlazedType) surveyClass.Openings.WindowMultipleGlazedType);
            }
            else
            {
              this.x.Windows[4].Area = (float) Math.Round((double) num3 * (double) this.Ext.E2Area / (double) num4 * surveyClass.Openings.MultipleGlazedProportion / 100.0, 2);
              this.x.Windows[4].U = num19;
              this.x.Windows[4].g = num20;
              this.x.Windows[4].Location = "Extension 2 Wall";
              this.x.Windows[4].GlazingType = this.WindowType((Enums.GlazedType) surveyClass.Openings.WindowMultipleGlazedType);
              this.x.Windows[5].Area = (float) Math.Round((double) num3 * (double) this.Ext.E2Area / (double) num4 * (100.0 - surveyClass.Openings.MultipleGlazedProportion) / 100.0, 2);
              this.x.Windows[5].U = 4.8f;
              this.x.Windows[5].g = 0.85f;
              this.x.Windows[5].Location = "Extension 2 Wall";
              this.x.Windows[5].GlazingType = "Single-glazed";
            }
          }
          if (this.Ext.Ext3)
          {
            if (surveyClass.Openings.MultipleGlazedProportion == 0.0)
            {
              this.x.Windows[3].Area = (float) Math.Round((double) num3 * (double) this.Ext.E3Area / (double) num4, 2);
              this.x.Windows[3].U = 4.8f;
              this.x.Windows[3].g = 0.85f;
              this.x.Windows[3].Location = "Extension 3 Wall";
              this.x.Windows[3].GlazingType = "Single-glazed";
            }
            else if (surveyClass.Openings.MultipleGlazedProportion == 100.0)
            {
              this.x.Windows[3].Area = (float) Math.Round((double) num3 * (double) this.Ext.E3Area / (double) num4, 2);
              this.x.Windows[3].U = num19;
              this.x.Windows[3].g = num20;
              this.x.Windows[3].Location = "Extension 3 Wall";
              this.x.Windows[3].GlazingType = this.WindowType((Enums.GlazedType) surveyClass.Openings.WindowMultipleGlazedType);
            }
            else
            {
              this.x.Windows[6].Area = (float) Math.Round((double) num3 * (double) this.Ext.E3Area / (double) num4 * surveyClass.Openings.MultipleGlazedProportion / 100.0, 2);
              this.x.Windows[6].U = num19;
              this.x.Windows[6].g = num20;
              this.x.Windows[6].Location = "Extension 3 Wall";
              this.x.Windows[6].GlazingType = this.WindowType((Enums.GlazedType) surveyClass.Openings.WindowMultipleGlazedType);
              this.x.Windows[7].Area = (float) Math.Round((double) num3 * (double) this.Ext.E3Area / (double) num4 * (100.0 - surveyClass.Openings.MultipleGlazedProportion) / 100.0, 2);
              this.x.Windows[7].U = 4.8f;
              this.x.Windows[7].g = 0.85f;
              this.x.Windows[7].Location = "Extension 3 Wall";
              this.x.Windows[7].GlazingType = "Single-glazed";
            }
          }
          if (this.Ext.Ext4)
          {
            if (surveyClass.Openings.MultipleGlazedProportion == 0.0)
            {
              this.x.Windows[4].Area = (float) Math.Round((double) num3 * (double) this.Ext.E4Area / (double) num4, 2);
              this.x.Windows[4].U = 4.8f;
              this.x.Windows[4].g = 0.85f;
              this.x.Windows[4].Location = "Extension 4 Wall";
              this.x.Windows[4].GlazingType = "Single-glazed";
            }
            else if (surveyClass.Openings.MultipleGlazedProportion == 100.0)
            {
              this.x.Windows[4].Area = (float) Math.Round((double) num3 * (double) this.Ext.E4Area / (double) num4, 2);
              this.x.Windows[4].U = num19;
              this.x.Windows[4].g = num20;
              this.x.Windows[4].Location = "Extension 4 Wall";
              this.x.Windows[4].GlazingType = this.WindowType((Enums.GlazedType) surveyClass.Openings.WindowMultipleGlazedType);
            }
            else
            {
              this.x.Windows[8].Area = (float) Math.Round((double) num3 * (double) this.Ext.E4Area / (double) num4 * surveyClass.Openings.MultipleGlazedProportion / 100.0, 2);
              this.x.Windows[8].U = num19;
              this.x.Windows[8].g = num20;
              this.x.Windows[8].Location = "Extension 4 Wall";
              this.x.Windows[8].GlazingType = this.WindowType((Enums.GlazedType) surveyClass.Openings.WindowMultipleGlazedType);
              this.x.Windows[9].Area = (float) Math.Round((double) num3 * (double) this.Ext.E4Area / (double) num4 * (100.0 - surveyClass.Openings.MultipleGlazedProportion) / 100.0, 2);
              this.x.Windows[9].U = 4.8f;
              this.x.Windows[9].g = 0.85f;
              this.x.Windows[9].Location = "Extension 4 Wall";
              this.x.Windows[9].GlazingType = "Single-glazed";
            }
          }
          if (surveyClass.Openings.MultipleGlazedProportion == 0.0)
            this.x.Windows[0].Area = (float) Math.Round((double) this.x.Windows[0].Area, 2);
          else if (surveyClass.Openings.MultipleGlazedProportion == 100.0)
          {
            this.x.Windows[0].Area = (float) Math.Round((double) this.x.Windows[0].Area, 2);
          }
          else
          {
            this.x.Windows[0].Area = (float) Math.Round((double) this.x.Windows[0].Area, 2);
            this.x.Windows[1].Area = (float) Math.Round((double) this.x.Windows[1].Area, 2);
          }
          int num23 = checked (this.x.Windows.Length - 1);
          int index9 = 0;
          while (index9 <= num23)
          {
            this.x.Windows[index9].Name = "Window " + Conversions.ToString(checked (index9 + 1));
            float num24 = 4.8f;
            this.x.Windows[index9].FF = 0.7f;
            this.x.Windows[index9].Count = 1;
            this.x.Windows[index9].Orientation = "East";
            this.x.Windows[index9].Overshading = "Average or unknown";
            this.x.Windows[index9].UValueSource = flag2 & (double) this.x.Windows[index9].U != (double) num24 ? "BFRC" : "Manufacturer";
            checked { ++index9; }
          }
          break;
        default:
          Survey_Class.ExtendedWindows[] extendedWindows1 = surveyClass.Openings.ExtendedWindows;
          int index10 = 0;
          while (index10 < extendedWindows1.Length)
          {
            Survey_Class.ExtendedWindows extendedWindows2 = extendedWindows1[index10];
            bool flag3;
            if (extendedWindows2.WindowType == 0)
            {
              flag3 = false;
              if (this.x.Windows == null)
              {
                this.x.Windows = new SAP_Module.Window[1];
              }
              else
              {
                // ISSUE: variable of a reference type
                SAP_Module.Window[]& local;
                // ISSUE: explicit reference operation
                SAP_Module.Window[] windowArray = (SAP_Module.Window[]) Utils.CopyArray((Array) ^(local = ref this.x.Windows), (Array) new SAP_Module.Window[checked (this.x.Windows.Length + 1)]);
                local = windowArray;
              }
              this.x.Windows[checked (this.x.Windows.Length - 1)] = new SAP_Module.Window();
              this.x.Windows[checked (this.x.Windows.Length - 1)].Area = (float) extendedWindows2.WindowArea;
              this.x.Windows[checked (this.x.Windows.Length - 1)].Name = "Window " + Conversions.ToString(this.x.Windows.Length);
              this.x.Windows[checked (this.x.Windows.Length - 1)].FF = 0.7f;
              this.x.Windows[checked (this.x.Windows.Length - 1)].Count = 1;
              this.x.Windows[checked (this.x.Windows.Length - 1)].Location = "";
              this.x.Windows[checked (this.x.Windows.Length - 1)].Orientation = this.WindowOrientation((Enums.Orientation) extendedWindows2.WindowsOrientation);
              this.x.Windows[checked (this.x.Windows.Length - 1)].Overshading = "Average or unknown";
              this.x.Windows[checked (this.x.Windows.Length - 1)].UValueSource = (extendedWindows2.WindowMultipleGlazedType == 7 | extendedWindows2.WindowMultipleGlazedType == 8) & extendedWindows2.WindowDataSource == 2 ? "BFRC" : "Manufacturer";
            }
            else if (extendedWindows2.WindowType == 1)
            {
              flag3 = true;
              if (this.x.RoofLights == null)
              {
                this.x.RoofLights = new SAP_Module.RoofLight[1];
              }
              else
              {
                // ISSUE: variable of a reference type
                SAP_Module.RoofLight[]& local;
                // ISSUE: explicit reference operation
                SAP_Module.RoofLight[] roofLightArray = (SAP_Module.RoofLight[]) Utils.CopyArray((Array) ^(local = ref this.x.RoofLights), (Array) new SAP_Module.RoofLight[checked (this.x.RoofLights.Length + 1)]);
                local = roofLightArray;
              }
              this.x.RoofLights[checked (this.x.RoofLights.Length - 1)] = new SAP_Module.RoofLight();
              this.x.RoofLights[checked (this.x.RoofLights.Length - 1)].Area = (float) extendedWindows2.WindowArea;
              this.x.RoofLights[checked (this.x.RoofLights.Length - 1)].Name = "RoofLight " + Conversions.ToString(this.x.RoofLights.Length);
              this.x.RoofLights[checked (this.x.RoofLights.Length - 1)].FF = 0.7f;
              this.x.RoofLights[checked (this.x.RoofLights.Length - 1)].Count = 1;
              this.x.RoofLights[checked (this.x.RoofLights.Length - 1)].Location = "";
              this.x.RoofLights[checked (this.x.RoofLights.Length - 1)].Orientation = this.WindowOrientation((Enums.Orientation) extendedWindows2.WindowsOrientation);
              this.x.RoofLights[checked (this.x.RoofLights.Length - 1)].Overshading = "Average or unknown";
              this.x.RoofLights[checked (this.x.RoofLights.Length - 1)].UValueSource = (extendedWindows2.WindowMultipleGlazedType == 7 | extendedWindows2.WindowMultipleGlazedType == 8) & extendedWindows2.WindowDataSource == 2 ? "BFRC" : "Manufacturer";
            }
            switch (extendedWindows2.WindowMultipleGlazedType)
            {
              case 1:
              case 3:
                if (!flag3)
                {
                  this.x.Windows[checked (this.x.Windows.Length - 1)].U = 3.1f;
                  this.x.Windows[checked (this.x.Windows.Length - 1)].g = 0.76f;
                  break;
                }
                this.x.RoofLights[checked (this.x.RoofLights.Length - 1)].U = 3.3f;
                this.x.RoofLights[checked (this.x.RoofLights.Length - 1)].g = 0.76f;
                break;
              case 2:
                if (!flag3)
                {
                  this.x.Windows[checked (this.x.Windows.Length - 1)].U = 2f;
                  this.x.Windows[checked (this.x.Windows.Length - 1)].g = 0.72f;
                  break;
                }
                this.x.RoofLights[checked (this.x.RoofLights.Length - 1)].U = 2.2f;
                this.x.RoofLights[checked (this.x.RoofLights.Length - 1)].g = 0.72f;
                break;
              case 4:
                if (!flag3)
                {
                  this.x.Windows[checked (this.x.Windows.Length - 1)].U = 2.4f;
                  this.x.Windows[checked (this.x.Windows.Length - 1)].g = 0.76f;
                  break;
                }
                this.x.RoofLights[checked (this.x.RoofLights.Length - 1)].U = 2.6f;
                this.x.RoofLights[checked (this.x.RoofLights.Length - 1)].g = 0.76f;
                break;
              case 5:
                if (!flag3)
                {
                  this.x.Windows[checked (this.x.Windows.Length - 1)].U = 4.8f;
                  this.x.Windows[checked (this.x.Windows.Length - 1)].g = 0.85f;
                  break;
                }
                this.x.RoofLights[checked (this.x.RoofLights.Length - 1)].U = 5.1f;
                this.x.RoofLights[checked (this.x.RoofLights.Length - 1)].g = 0.85f;
                break;
              case 6:
                if (!flag3)
                {
                  this.x.Windows[checked (this.x.Windows.Length - 1)].U = 1.8f;
                  this.x.Windows[checked (this.x.Windows.Length - 1)].g = 0.68f;
                  break;
                }
                this.x.RoofLights[checked (this.x.RoofLights.Length - 1)].U = 2f;
                this.x.RoofLights[checked (this.x.RoofLights.Length - 1)].g = 0.68f;
                break;
              case 7:
              case 8:
                if (!flag3)
                {
                  this.x.Windows[checked (this.x.Windows.Length - 1)].U = (float) extendedWindows2.WindowsUValue;
                  this.x.Windows[checked (this.x.Windows.Length - 1)].g = (float) extendedWindows2.WindowSolarTransmittance;
                  break;
                }
                this.x.RoofLights[checked (this.x.RoofLights.Length - 1)].U = (float) extendedWindows2.WindowsUValue;
                this.x.RoofLights[checked (this.x.RoofLights.Length - 1)].g = (float) extendedWindows2.WindowSolarTransmittance;
                break;
            }
            switch (extendedWindows2.WindowsLoc)
            {
              case 0:
                if (flag3)
                {
                  this.x.RoofLights[checked (this.x.RoofLights.Length - 1)].Location = "Main Roof";
                  break;
                }
                this.x.Windows[checked (this.x.Windows.Length - 1)].Location = "Main Wall";
                break;
              case 1:
                if (flag3)
                {
                  this.x.RoofLights[checked (this.x.RoofLights.Length - 1)].Location = "Extension 1 Roof";
                  break;
                }
                this.x.Windows[checked (this.x.Windows.Length - 1)].Location = "Extension 1 Wall";
                break;
              case 2:
                if (flag3)
                {
                  this.x.RoofLights[checked (this.x.RoofLights.Length - 1)].Location = "Extension 2 Roof";
                  break;
                }
                this.x.Windows[checked (this.x.Windows.Length - 1)].Location = "Extension 2 Wall";
                break;
              case 3:
                if (flag3)
                {
                  this.x.RoofLights[checked (this.x.RoofLights.Length - 1)].Location = "Extension 3 Roof";
                  break;
                }
                this.x.Windows[checked (this.x.Windows.Length - 1)].Location = "Extension 3 Wall";
                break;
              case 4:
                if (flag3)
                {
                  this.x.RoofLights[checked (this.x.RoofLights.Length - 1)].Location = "Extension 4 Roof";
                  break;
                }
                this.x.Windows[checked (this.x.Windows.Length - 1)].Location = "Extension 4 Wall";
                break;
            }
            checked { ++index10; }
          }
          if (this.x.Windows != null)
          {
            int num25 = checked (this.x.Windows.Length - 1);
            int index11 = 0;
            while (index11 <= num25)
            {
              float u = this.x.Windows[index11].U;
              this.x.Windows[index11].GlazingType = (double) u != 4.80000019073486 ? ((double) u != 3.09999990463257 ? ((double) u != 2.0 ? ((double) u != 2.40000009536743 ? ((double) u != 1.79999995231628 ? "double-glazed, argon filled" : "triple-glazed, air filled") : "Secondary glazing") : "double-glazed, argon filled") : "double-glazed, air filled") : "Single-glazed";
              checked { ++index11; }
            }
          }
          if (this.x.RoofLights != null)
          {
            int num26 = checked (this.x.RoofLights.Length - 1);
            int index12 = 0;
            while (index12 <= num26)
            {
              float u = this.x.RoofLights[index12].U;
              this.x.RoofLights[index12].GlazingType = (double) u != 5.09999990463257 ? ((double) u != 3.29999995231628 ? ((double) u != 2.20000004768372 ? ((double) u != 2.59999990463257 ? ((double) u != 2.0 ? "double-glazed, argon filled" : "triple-glazed, air filled") : "Secondary glazing") : "double-glazed, argon filled") : "double-glazed, air filled") : "Single-glazed";
              checked { ++index12; }
            }
            break;
          }
          break;
      }
      if (this.Ext.Cons)
      {
        // ISSUE: variable of a reference type
        SAP_Module.Window[]& local1;
        // ISSUE: explicit reference operation
        SAP_Module.Window[] windowArray = (SAP_Module.Window[]) Utils.CopyArray((Array) ^(local1 = ref this.x.Windows), (Array) new SAP_Module.Window[checked (this.x.Windows.Length + 1)]);
        local1 = windowArray;
        this.x.Windows[checked (this.x.Windows.Length - 1)] = new SAP_Module.Window();
        this.x.Windows[checked (this.x.Windows.Length - 1)].Area = this.x.Dims[checked (this.x.Dims.Length - 1)].Height * this.x.Dims[checked (this.x.Dims.Length - 1)].Perimeter;
        this.x.Windows[checked (this.x.Windows.Length - 1)].Name = "Conservatory";
        this.x.Windows[checked (this.x.Windows.Length - 1)].FF = 0.7f;
        this.x.Windows[checked (this.x.Windows.Length - 1)].Count = 1;
        this.x.Windows[checked (this.x.Windows.Length - 1)].Orientation = "East";
        this.x.Windows[checked (this.x.Windows.Length - 1)].Overshading = "Average or unknown";
        this.x.Windows[checked (this.x.Windows.Length - 1)].UValueSource = "Manufacturer";
        this.x.Windows[checked (this.x.Windows.Length - 1)].Location = "";
        if (surveyClass.Conservatory.DoubleGlazed)
        {
          this.x.Windows[checked (this.x.Windows.Length - 1)].GlazingType = "double-glazed, air filled";
          this.x.Windows[checked (this.x.Windows.Length - 1)].U = 3.1f;
          this.x.Windows[checked (this.x.Windows.Length - 1)].g = 0.76f;
        }
        else
        {
          this.x.Windows[checked (this.x.Windows.Length - 1)].GlazingType = "Single-glazed";
          this.x.Windows[checked (this.x.Windows.Length - 1)].U = 4.8f;
          this.x.Windows[checked (this.x.Windows.Length - 1)].g = 0.85f;
        }
        if (this.x.RoofLights == null)
        {
          this.x.RoofLights = new SAP_Module.RoofLight[1];
        }
        else
        {
          // ISSUE: variable of a reference type
          SAP_Module.RoofLight[]& local2;
          // ISSUE: explicit reference operation
          SAP_Module.RoofLight[] roofLightArray = (SAP_Module.RoofLight[]) Utils.CopyArray((Array) ^(local2 = ref this.x.RoofLights), (Array) new SAP_Module.RoofLight[checked (this.x.RoofLights.Length + 1)]);
          local2 = roofLightArray;
        }
        this.x.RoofLights[checked (this.x.RoofLights.Length - 1)] = new SAP_Module.RoofLight();
        this.x.RoofLights[checked (this.x.RoofLights.Length - 1)].Area = this.x.Dims[checked (this.x.Dims.Length - 1)].Area;
        this.x.RoofLights[checked (this.x.RoofLights.Length - 1)].Name = "Conservatory";
        this.x.RoofLights[checked (this.x.RoofLights.Length - 1)].FF = 0.7f;
        this.x.RoofLights[checked (this.x.RoofLights.Length - 1)].Count = 1;
        this.x.RoofLights[checked (this.x.RoofLights.Length - 1)].Pitch = 0.0f;
        this.x.RoofLights[checked (this.x.RoofLights.Length - 1)].Location = "";
        this.x.RoofLights[checked (this.x.RoofLights.Length - 1)].Orientation = "East";
        this.x.RoofLights[checked (this.x.RoofLights.Length - 1)].Overshading = "Average or unknown";
        this.x.RoofLights[checked (this.x.RoofLights.Length - 1)].UValueSource = "Manufacturer";
        if (surveyClass.Conservatory.DoubleGlazed)
        {
          this.x.RoofLights[checked (this.x.RoofLights.Length - 1)].GlazingType = "double-glazed, air filled";
          this.x.RoofLights[checked (this.x.RoofLights.Length - 1)].U = 3.4f;
          this.x.RoofLights[checked (this.x.RoofLights.Length - 1)].g = 0.76f;
        }
        else
        {
          this.x.RoofLights[checked (this.x.RoofLights.Length - 1)].GlazingType = "Single-glazed";
          this.x.RoofLights[checked (this.x.RoofLights.Length - 1)].U = 5.3f;
          this.x.RoofLights[checked (this.x.RoofLights.Length - 1)].g = 0.85f;
        }
      }
      if (this.x.Windows != null)
        this.x.NoofWindows = this.x.Windows.Length;
      if (this.x.RoofLights != null)
        this.x.NoofRoofLights = this.x.RoofLights.Length;
    }

    private string WindowOrientation(Enums.Orientation orientation)
    {
      string str;
      switch (orientation)
      {
        case Enums.Orientation.North:
          str = "North";
          break;
        case Enums.Orientation.North_east:
          str = "North East";
          break;
        case Enums.Orientation.East:
          str = "East";
          break;
        case Enums.Orientation.South_East:
          str = "South East";
          break;
        case Enums.Orientation.South:
          str = "South";
          break;
        case Enums.Orientation.South_West:
          str = "South West";
          break;
        case Enums.Orientation.West:
          str = "West";
          break;
        case Enums.Orientation.North_West:
          str = "North West";
          break;
        case Enums.Orientation.Horizontal:
          str = "Unspecified";
          break;
      }
      return str;
    }

    private string WindowType(Enums.GlazedType Window)
    {
      string str = "";
      switch (Window)
      {
        case Enums.GlazedType.Double_glazing_installed_before_2002:
        case Enums.GlazedType.Double_Glazed_UnknownDate:
          str = "double-glazed, air filled";
          break;
        case Enums.GlazedType.Double_glazing_installed_during_or_after_2002:
        case Enums.GlazedType.Double_known_data:
          str = "double-glazed, argon filled";
          break;
        case Enums.GlazedType.Secondary_glazing:
          str = "Secondary glazing";
          break;
        case Enums.GlazedType.Single_glazing:
          str = "Single-glazed";
          break;
        case Enums.GlazedType.Triple_glazing:
        case Enums.GlazedType.Triple_known_data:
          str = "triple-glazed, air filled";
          break;
      }
      return str;
    }

    private void Ventilation1(Survey_Class RdSAP)
    {
      Survey_Class surveyClass = RdSAP;
      this.x.Ventilation.ChimneysOther = surveyClass.General.FirePlacesCount;
      this.x.Ventilation.Chimneys = this.x.Ventilation.ChimneysOther;
      if (surveyClass.MainHeating[0].DataSource == 1)
      {
        if ((uint) surveyClass.MainHeating[0].BoilerCode > 0U)
        {
          if (surveyClass.MainHeating[0].SecondaryType == 0)
          {
            this.x.MainHeating.SEDBUK = this.SEDBUKFull(Conversions.ToString(surveyClass.MainHeating[0].BoilerCode));
            if (Operators.CompareString(SAP_Module.PCDFData.Boilers.Where<PCDF.SEDBUK>((Func<PCDF.SEDBUK, bool>) (b => Operators.CompareString(b.ID, this.x.MainHeating.SEDBUK, false) == 0)).Single<PCDF.SEDBUK>().FlueType, "1", false) == 0)
            {
              // ISSUE: variable of a reference type
              int& local;
              // ISSUE: explicit reference operation
              int num = checked (^(local = ref this.x.Ventilation.FluesMain) + 1);
              local = num;
            }
          }
          else if (surveyClass.MainHeating[0].SecondaryType == 1)
          {
            this.x.MainHeating.SEDBUK = this.SEDBUKFull(Conversions.ToString(surveyClass.MainHeating[0].BoilerCode));
            PCDF.CHP chp = SAP_Module.PCDFData.CHPs.Where<PCDF.CHP>((Func<PCDF.CHP, bool>) (b => Operators.CompareString(b.ID, this.x.MainHeating.SEDBUK, false) == 0)).Single<PCDF.CHP>();
            if (Operators.CompareString(chp.Flue_Type, "1", false) == 0)
            {
              // ISSUE: variable of a reference type
              int& local;
              // ISSUE: explicit reference operation
              int num = checked (^(local = ref this.x.Ventilation.FluesMain) + 1);
              local = num;
            }
            if (Operators.CompareString(chp.SepCirculator, "1", false) == 0)
            {
              this.NoPump = true;
              if (Operators.CompareString(chp.ServiceProvision, "2", false) == 0)
                this.x.Water.Cylinder.HPImmersion = "Yes";
            }
          }
          else if (surveyClass.MainHeating[0].SecondaryType != 2 && surveyClass.MainHeating[0].SecondaryType == 4)
          {
            this.x.MainHeating.SEDBUK = this.SEDBUKFull(Conversions.ToString(surveyClass.MainHeating[0].BoilerCode));
            PCDF.HeatPump heatPump = SAP_Module.PCDFData.HeatPumps.Where<PCDF.HeatPump>((Func<PCDF.HeatPump, bool>) (b => Operators.CompareString(b.ID, this.x.MainHeating.SEDBUK, false) == 0)).Single<PCDF.HeatPump>();
            if (Operators.CompareString(heatPump.Flue_Type, "1", false) == 0)
            {
              // ISSUE: variable of a reference type
              int& local;
              // ISSUE: explicit reference operation
              int num = checked (^(local = ref this.x.Ventilation.FluesMain) + 1);
              local = num;
            }
            if (Operators.CompareString(heatPump.SepCirculator, "1", false) == 0)
            {
              this.NoPump = true;
              if (Operators.CompareString(heatPump.ServiceProvision, "2", false) == 0)
                this.x.Water.Cylinder.HPImmersion = "Yes";
            }
          }
        }
      }
      else
      {
        int sapCode = surveyClass.MainHeating[0].SAPCode;
        if (sapCode >= 115 && sapCode <= 119 || sapCode >= 601 && sapCode <= 607 || sapCode >= 621 && sapCode <= 624 || sapCode == 159 || sapCode == 158 || sapCode == 609)
        {
          // ISSUE: variable of a reference type
          int& local;
          // ISSUE: explicit reference operation
          int num = checked (^(local = ref this.x.Ventilation.FluesMain) + 1);
          local = num;
        }
        else if (sapCode == 155 || sapCode == 151 || sapCode == 160 || sapCode == 134 || sapCode >= 125 && sapCode <= 132 || sapCode == 140 || sapCode >= 101 && sapCode <= 109 || sapCode >= 506 && sapCode <= 511)
        {
          if (surveyClass.MainHeating[0].BoilerFlueType == 1)
          {
            // ISSUE: variable of a reference type
            int& local;
            // ISSUE: explicit reference operation
            int num = checked (^(local = ref this.x.Ventilation.FluesMain) + 1);
            local = num;
          }
        }
        else if (sapCode == 613)
        {
          // ISSUE: variable of a reference type
          int& local;
          // ISSUE: explicit reference operation
          int num = checked (^(local = ref this.x.Ventilation.Fires) + 1);
          local = num;
        }
      }
      if (this.x.Ventilation.FluesMain == 1)
        this.MainFlue = true;
      if (surveyClass.MainHeating[1].Present)
      {
        if (surveyClass.MainHeating[1].DataSource == 1)
        {
          this.x.MainHeating2.SEDBUK = this.SEDBUKFull(Conversions.ToString(surveyClass.MainHeating[1].BoilerCode));
          if (surveyClass.MainHeating[1].SecondaryType == 0)
          {
            if (Operators.CompareString(SAP_Module.PCDFData.Boilers.Where<PCDF.SEDBUK>((Func<PCDF.SEDBUK, bool>) (b => Operators.CompareString(b.ID, this.x.MainHeating2.SEDBUK, false) == 0)).Single<PCDF.SEDBUK>().FlueType, "1", false) == 0)
            {
              // ISSUE: variable of a reference type
              int& local;
              // ISSUE: explicit reference operation
              int num = checked (^(local = ref this.x.Ventilation.FluesMain) + 1);
              local = num;
            }
          }
          else if (surveyClass.MainHeating[1].SecondaryType != 2)
            ;
        }
        else
        {
          int sapCode = surveyClass.MainHeating[1].SAPCode;
          if (sapCode >= 115 && sapCode <= 119 || sapCode >= 601 && sapCode <= 607 || sapCode >= 621 && sapCode <= 624 || sapCode == 159 || sapCode == 158 || sapCode == 609)
          {
            // ISSUE: variable of a reference type
            int& local;
            // ISSUE: explicit reference operation
            int num = checked (^(local = ref this.x.Ventilation.FluesMain) + 1);
            local = num;
          }
          else if (sapCode == 155 || sapCode == 151 || sapCode == 160 || sapCode == 134 || sapCode >= 125 && sapCode <= 132 || sapCode == 140 || sapCode >= 101 && sapCode <= 109 || sapCode >= 506 && sapCode <= 511)
          {
            if (surveyClass.MainHeating[1].BoilerFlueType == 1)
            {
              // ISSUE: variable of a reference type
              int& local;
              // ISSUE: explicit reference operation
              int num = checked (^(local = ref this.x.Ventilation.FluesMain) + 1);
              local = num;
            }
          }
          else if (sapCode == 613)
          {
            // ISSUE: variable of a reference type
            int& local;
            // ISSUE: explicit reference operation
            int num = checked (^(local = ref this.x.Ventilation.Fires) + 1);
            local = num;
          }
        }
      }
      if (this.x.Ventilation.FluesMain == 2)
        this.MainFlue2 = true;
      else if (this.x.Ventilation.FluesMain == 1 & !this.MainFlue)
        this.MainFlue2 = true;
      if (surveyClass.SecondaryHeating.Present)
      {
        int code = surveyClass.SecondaryHeating.Code;
        if (code >= 601 && code <= 607 || code >= 621 && code <= 624 || code >= 633 && code <= 636 || code == 609)
        {
          // ISSUE: variable of a reference type
          int& local;
          // ISSUE: explicit reference operation
          int num = checked (^(local = ref this.x.Ventilation.FluesSec) + 1);
          local = num;
        }
        else if (code == 613)
        {
          // ISSUE: variable of a reference type
          int& local;
          // ISSUE: explicit reference operation
          int num = checked (^(local = ref this.x.Ventilation.Fires) + 1);
          local = num;
        }
      }
      this.x.Ventilation.Flues = checked (this.x.Ventilation.FluesSec + this.x.Ventilation.FluesMain);
      bool flag1;
      if (surveyClass.OtherDetails.MechanicalVentilation)
        flag1 = true;
      if (!flag1)
      {
        string mage = this.Ext.Ages.MAge;
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
              goto label_72;
            else
              goto default;
          case 3272340793:
            if (Operators.CompareString(mage, "F", false) == 0)
              goto label_72;
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
              goto label_73;
            else
              goto default;
          case 3440116983:
            if (Operators.CompareString(mage, "H", false) == 0)
              goto label_73;
            else
              goto default;
          case 3456894602:
            if (Operators.CompareString(mage, "K", false) == 0)
              goto label_73;
            else
              goto default;
          case 3473672221:
            if (Operators.CompareString(mage, "J", false) == 0)
              goto label_73;
            else
              goto default;
          default:
label_78:
            goto label_79;
        }
        this.x.Ventilation.Fans = 0;
        goto label_78;
label_72:
        this.x.Ventilation.Fans = 1;
        goto label_78;
label_73:
        switch (surveyClass.Age.MHabRooms)
        {
          case 1:
          case 2:
            this.x.Ventilation.Fans = 1;
            goto label_78;
          case 3:
          case 4:
          case 5:
            this.x.Ventilation.Fans = 2;
            goto label_78;
          case 6:
          case 7:
          case 8:
            this.x.Ventilation.Fans = 3;
            goto label_78;
          default:
            this.x.Ventilation.Fans = 4;
            goto label_78;
        }
      }
label_79:
      this.x.Ventilation.Shelter = !(surveyClass.General.PropertyType1 == 3 | surveyClass.General.PropertyType1 == 4) ? 2f : (surveyClass.Flat_Maisonette.FlatLocation > 5 ? 2f : 4f);
      this.Ext.NetAreas = new RdSAP_TO_SAP.NetWallAreas[5];
      this.Ext.NetAreas[0] = new RdSAP_TO_SAP.NetWallAreas();
      this.Ext.NetAreas[1] = new RdSAP_TO_SAP.NetWallAreas();
      this.Ext.NetAreas[2] = new RdSAP_TO_SAP.NetWallAreas();
      this.Ext.NetAreas[3] = new RdSAP_TO_SAP.NetWallAreas();
      this.Ext.NetAreas[4] = new RdSAP_TO_SAP.NetWallAreas();
      int num1 = checked (this.x.Walls.Length - 1);
      int index1 = 0;
      while (index1 <= num1)
      {
        string name = this.x.Walls[index1].Name;
        if (Operators.CompareString(name, "Main Wall", false) != 0)
        {
          if (Operators.CompareString(name, "Extension 1 Wall", false) != 0)
          {
            if (Operators.CompareString(name, "Extension 2 Wall", false) != 0)
            {
              if (Operators.CompareString(name, "Extension 3 Wall", false) != 0)
              {
                if (Operators.CompareString(name, "Extension 4 Wall", false) == 0)
                  this.Ext.NetAreas[4].Area = this.x.Walls[index1].Area;
              }
              else
                this.Ext.NetAreas[3].Area = this.x.Walls[index1].Area;
            }
            else
              this.Ext.NetAreas[2].Area = this.x.Walls[index1].Area;
          }
          else
            this.Ext.NetAreas[1].Area = this.x.Walls[index1].Area;
        }
        else
          this.Ext.NetAreas[0].Area = this.x.Walls[index1].Area;
        checked { ++index1; }
      }
      this.Ext.NetAreas[0].WallDesc = "MainWall";
      this.Ext.NetAreas[1].WallDesc = "E1Wall";
      this.Ext.NetAreas[2].WallDesc = "E2Wall";
      this.Ext.NetAreas[3].WallDesc = "E3Wall";
      this.Ext.NetAreas[4].WallDesc = "E4Wall";
      if (this.x.Windows != null)
      {
        int num2 = checked (this.x.Windows.Length - 1);
        int index2 = 0;
        while (index2 <= num2)
        {
          string location = this.x.Windows[index2].Location;
          if (Operators.CompareString(location, "Main Wall", false) != 0)
          {
            if (Operators.CompareString(location, "Extension 1 Wall", false) != 0)
            {
              if (Operators.CompareString(location, "Extension 2 Wall", false) != 0)
              {
                if (Operators.CompareString(location, "Extension 3 Wall", false) != 0)
                {
                  if (Operators.CompareString(location, "Extension 4 Wall", false) == 0)
                  {
                    RdSAP_TO_SAP.NetWallAreas netArea;
                    double num3 = (double) (netArea = this.Ext.NetAreas[4]).Area - (double) this.x.Windows[index2].Area;
                    netArea.Area = (float) num3;
                  }
                }
                else
                {
                  RdSAP_TO_SAP.NetWallAreas netArea;
                  double num4 = (double) (netArea = this.Ext.NetAreas[3]).Area - (double) this.x.Windows[index2].Area;
                  netArea.Area = (float) num4;
                }
              }
              else
              {
                RdSAP_TO_SAP.NetWallAreas netArea;
                double num5 = (double) (netArea = this.Ext.NetAreas[2]).Area - (double) this.x.Windows[index2].Area;
                netArea.Area = (float) num5;
              }
            }
            else
            {
              RdSAP_TO_SAP.NetWallAreas netArea;
              double num6 = (double) (netArea = this.Ext.NetAreas[1]).Area - (double) this.x.Windows[index2].Area;
              netArea.Area = (float) num6;
            }
          }
          else
          {
            RdSAP_TO_SAP.NetWallAreas netArea;
            double num7 = (double) (netArea = this.Ext.NetAreas[0]).Area - (double) this.x.Windows[index2].Area;
            netArea.Area = (float) num7;
          }
          checked { ++index2; }
        }
      }
      int numberOfExtension = surveyClass.Age.NumberOfExtension;
      int index3 = 0;
      float num8;
      float num9;
      while (index3 <= numberOfExtension)
      {
        if ((double) this.Ext.NetAreas[index3].Area > 0.0)
        {
          if (surveyClass.Extensions[index3].WallConstruction == 5)
            num8 += this.Ext.NetAreas[index3].Area;
          else
            num9 += this.Ext.NetAreas[index3].Area;
        }
        checked { ++index3; }
      }
      this.x.Ventilation.Infiltration.Construction = (double) num9 < (double) num8 ? "Timber or metal frame" : "Masonary";
      bool flag2;
      if (surveyClass.Extensions[0].FloorConstruction == 1)
      {
        string mage = this.Ext.Ages.MAge;
        flag2 = Operators.CompareString(mage, "A", false) == 0 || Operators.CompareString(mage, "B", false) == 0;
      }
      else if (surveyClass.Extensions[0].FloorConstruction == 3)
        flag2 = true;
      else if (surveyClass.Extensions[0].FloorConstruction == 4)
        flag2 = false;
      else if (surveyClass.Extensions[0].FloorConstruction == 2)
        flag2 = false;
      if (flag2)
      {
        string mage = this.Ext.Ages.MAge;
        this.x.Ventilation.Infiltration.Floor = Operators.CompareString(mage, "A", false) == 0 || Operators.CompareString(mage, "B", false) == 0 || Operators.CompareString(mage, "C", false) == 0 || Operators.CompareString(mage, "D", false) == 0 || Operators.CompareString(mage, "E", false) == 0 ? "Suspended timber floor - Unsealed" : "Suspended timber floor - Sealed";
      }
      else
        this.x.Ventilation.Infiltration.Floor = "Non timber floor";
      if (surveyClass.Extensions[0].LowestFloor == 4 | surveyClass.Extensions[0].LowestFloor == 7 | surveyClass.Extensions[0].LowestFloor == 1)
        this.x.Ventilation.Infiltration.Floor = "Non timber floor";
      switch (surveyClass.General.PropertyType1)
      {
        case 3:
        case 4:
          this.x.Ventilation.Infiltration.Lobby = !(surveyClass.Flat_Maisonette.HeatLossCorridor == 2 | surveyClass.Flat_Maisonette.HeatLossCorridor == 3) ? "No Draught Lobby" : "Draught Lobby";
          break;
        default:
          this.x.Ventilation.Infiltration.Lobby = "No Draught Lobby";
          break;
      }
      this.x.Ventilation.Infiltration.DraguthP = (float) surveyClass.Openings.PercentDraughtProofed;
      if (surveyClass.OtherDetails.MechanicalVentilation)
      {
        if (surveyClass.OtherDetails.VentType == 1)
        {
          this.x.Ventilation.MechVent = "Centralised whole house extract";
          this.x.Ventilation.Parameters = "SAP 2009";
          int mhabRooms = surveyClass.Age.MHabRooms;
          if (mhabRooms >= 1 && mhabRooms <= 2)
            this.x.Ventilation.WetRooms = 1;
          else if (mhabRooms >= 3 && mhabRooms <= 4)
            this.x.Ventilation.WetRooms = 2;
          else if (mhabRooms >= 5 && mhabRooms <= 6)
            this.x.Ventilation.WetRooms = 3;
          else if (mhabRooms >= 7 && mhabRooms <= 8)
            this.x.Ventilation.WetRooms = 4;
          else if (mhabRooms >= 9 && mhabRooms <= 10)
            this.x.Ventilation.WetRooms = 5;
          else if (mhabRooms >= 11)
            this.x.Ventilation.WetRooms = 6;
          if (this.x.MainHeating.SEDBUK != null && this.x.MainHeating.SEDBUK.Length > 0 && surveyClass.MainHeating[0].SecondaryType == 4)
          {
            PCDF.HeatPump heatPump = SAP_Module.PCDFData.HeatPumps.Where<PCDF.HeatPump>((Func<PCDF.HeatPump, bool>) (b => Operators.CompareString(b.ID, this.x.MainHeating.SEDBUK, false) == 0)).Single<PCDF.HeatPump>();
            if (Conversions.ToDouble(heatPump.Heat_Source) == 4.0)
            {
              this.x.Ventilation.Parameters = "Database";
              this.x.Ventilation.ProductID = Conversions.ToInteger(heatPump.MEV_MVHR);
            }
          }
        }
        else
        {
          this.x.Ventilation.MechVent = "Balanced with heat recovery";
          this.x.Ventilation.Parameters = "SAP 2009";
        }
      }
      else
      {
        this.x.Ventilation.MechVent = "Natural ventilation";
        this.x.Ventilation.Parameters = "";
      }
      this.x.Ventilation.Pressure = "Calculated";
    }

    private void MainHeating_Spec(Survey_Class RdSAP)
    {
      if (RdSAP.MainHeating[0].SAPCode < 100)
        RdSAP.MainHeating[0].SAPCode = 0;
      this.x.MainHeating = this.Heating_Both_Spec(RdSAP, (Enums.SecondaryHeatingType) RdSAP.MainHeating[0].SecondaryType, Conversions.ToString(RdSAP.MainHeating[0].BoilerCode), RdSAP.MainHeating[0].SAPCode, 1);
      this.x.MainHeating.Boiler.FanFlued = RdSAP.MainHeating[0].FanFluePresent ? "Yes" : "No";
      this.x.MainHeating.Fuel = this.Fuel((Enums.HeatingFuelType) RdSAP.MainHeating[0].Fuel);
      if (this.x.MainHeating.SAPTableCode == 699)
      {
        this.x.MainHeating.Fuel = "Electricity";
        this.x.MainHeating.ControlCode = 2699;
        RdSAP.MainHeating[0].ControlsCode = 2699;
      }
      if (!this.MainFlue)
        return;
      this.x.MainHeating.Boiler.FlueType = "Open";
    }

    private void SecMainHeating_Spec(Survey_Class RdSAP)
    {
      if (!RdSAP.MainHeating[1].Present)
        return;
      if (RdSAP.MainHeating[1].SAPCode < 100)
        RdSAP.MainHeating[1].SAPCode = 0;
      this.x.MainHeating2 = this.Heating_Both_Spec(RdSAP, (Enums.SecondaryHeatingType) RdSAP.MainHeating[1].SecondaryType, Conversions.ToString(RdSAP.MainHeating[1].BoilerCode), RdSAP.MainHeating[1].SAPCode, 2);
      this.x.MainHeating2.Boiler.FanFlued = RdSAP.MainHeating[1].FanFluePresent ? "Yes" : "No";
      this.x.MainHeating2.Fuel = this.Fuel((Enums.HeatingFuelType) RdSAP.MainHeating[1].Fuel);
      this.x.IncludeMainHeating2 = true;
      this.x.Include_SecMain_Heat_Whole = true;
      if (this.MainFlue2)
        this.x.MainHeating2.Boiler.FlueType = "Open";
      try
      {
        this.x.HeatFractionSec = (float) RdSAP.MainHeating[1].Fraction;
        if ((double) this.x.HeatFractionSec > 1.0)
        {
          // ISSUE: variable of a reference type
          float& local;
          // ISSUE: explicit reference operation
          double num = (double) ^(local = ref this.x.HeatFractionSec) / 100.0;
          local = (float) num;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private SAP_Module.MainHeating Heating_Both_Spec(
      Survey_Class RdSAP,
      Enums.SecondaryHeatingType Type,
      string SEDBUK,
      int AltMethodRef,
      int System)
    {
      SEDBUK = this.SEDBUKFull(SEDBUK);
      SAP_Module.MainHeating mainHeating = new SAP_Module.MainHeating();
      Survey_Class surveyClass = RdSAP;
      mainHeating.SAPTableCode = AltMethodRef;
      mainHeating.SEDBUK = SEDBUK;
      mainHeating.Boiler = new SAP_Module.Boiler();
      mainHeating.Boiler.FlueType = "";
      mainHeating.InforSource = "SAP Tables";
      Enums.HeatingFuelType FuelType = System != 2 ? (Enums.HeatingFuelType) RdSAP.MainHeating[0].Fuel : (Enums.HeatingFuelType) RdSAP.MainHeating[1].Fuel;
      int num = AltMethodRef;
      if (num == 0)
      {
        mainHeating.InforSource = "Boiler Database";
        mainHeating.HGroup = "Central heating systems with radiators or underfloor heating";
        mainHeating.Boiler.PumpHP = "Yes";
        if (this.NoPump & System == 1)
          mainHeating.Boiler.PumpHP = "No";
        mainHeating.Emitter = System != 2 ? this.Emmiter((Enums.HeatingEmitterType) RdSAP.MainHeating[0].EmitterType, RdSAP) : this.Emmiter((Enums.HeatingEmitterType) RdSAP.MainHeating[1].EmitterType, RdSAP);
        switch (Type)
        {
          case Enums.SecondaryHeatingType.Gas_Oil_Boilers:
            mainHeating.SGroup = "Gas boilers and oil boilers";
            break;
          case Enums.SecondaryHeatingType.Micro_CHP:
            mainHeating.SGroup = "Micro-cogeneration (micro-CHP)";
            break;
          case Enums.SecondaryHeatingType.Solid_Fuel:
            mainHeating.SGroup = "Solid fuel boilers";
            break;
          case Enums.SecondaryHeatingType.Heat_Pumps:
            mainHeating.SGroup = "Heat pumps";
            break;
        }
      }
      else if (num >= 101 && num <= 109)
      {
        mainHeating.HGroup = "Central heating systems with radiators or underfloor heating";
        mainHeating.SGroup = "Gas boilers and oil boilers";
        mainHeating.BSubGroup = "Gas boilers (including LPG) 1998 or later";
        mainHeating.InforSource = "SAP Tables";
        mainHeating.Emitter = System != 2 ? this.Emmiter((Enums.HeatingEmitterType) RdSAP.MainHeating[0].EmitterType, RdSAP) : this.Emmiter((Enums.HeatingEmitterType) RdSAP.MainHeating[1].EmitterType, RdSAP);
        mainHeating.Boiler.PumpHP = "Yes";
        switch (AltMethodRef)
        {
          case 101:
            mainHeating.MHType = "Regular non-condensing with automatic ignition";
            break;
          case 102:
            mainHeating.MHType = "Regular condensing with automatic ignition";
            break;
          case 103:
            mainHeating.MHType = "Non-condensing combi with automatic ignition";
            break;
          case 104:
            mainHeating.MHType = "Condensing combi with automatic ignition";
            break;
          case 105:
            mainHeating.MHType = "Regular non-condensing with permanent pilot light";
            break;
          case 107:
            mainHeating.MHType = "Non-condensing combi with permanent pilot light";
            break;
          case 109:
            mainHeating.MHType = "Back boiler to radiators";
            break;
        }
      }
      else if (num >= 110 && num <= 114)
      {
        mainHeating.HGroup = "Central heating systems with radiators or underfloor heating";
        mainHeating.SGroup = "Gas boilers and oil boilers";
        mainHeating.BSubGroup = "Gas boilers (including LPG) pre-1998, with fan-assisted flue";
        mainHeating.Boiler.PumpHP = "Yes";
        mainHeating.Emitter = System != 2 ? this.Emmiter((Enums.HeatingEmitterType) RdSAP.MainHeating[0].EmitterType, RdSAP) : this.Emmiter((Enums.HeatingEmitterType) RdSAP.MainHeating[1].EmitterType, RdSAP);
        switch (AltMethodRef)
        {
          case 111:
            mainHeating.MHType = "Regular, high or unknown thermal capacity";
            break;
          case 112:
            mainHeating.MHType = "Combi";
            break;
          case 113:
            mainHeating.MHType = "Condensing combi";
            break;
          case 114:
            mainHeating.MHType = "Regular, condensing";
            break;
        }
      }
      else if (num >= 115 && num <= 119)
      {
        mainHeating.HGroup = "Central heating systems with radiators or underfloor heating";
        mainHeating.SGroup = "Gas boilers and oil boilers";
        mainHeating.BSubGroup = "Gas boilers (including LPG) pre-1998, with balanced or open flue";
        mainHeating.Boiler.FlueType = "Open";
        mainHeating.Boiler.PumpHP = "Yes";
        mainHeating.Emitter = System != 2 ? this.Emmiter((Enums.HeatingEmitterType) RdSAP.MainHeating[0].EmitterType, RdSAP) : this.Emmiter((Enums.HeatingEmitterType) RdSAP.MainHeating[1].EmitterType, RdSAP);
        switch (AltMethodRef)
        {
          case 115:
            mainHeating.MHType = "Regular, wall mounted";
            break;
          case 116:
            mainHeating.MHType = "Regular, floor mounted, pre 1979";
            break;
          case 117:
            mainHeating.MHType = "Regular, floor mounted, 1979 to 1997";
            break;
          case 118:
            mainHeating.MHType = "Combi";
            break;
          case 119:
            mainHeating.MHType = "Back boiler to radiators";
            break;
        }
      }
      else if (num >= 120 && num <= 123)
      {
        mainHeating.HGroup = "Central heating systems with radiators or underfloor heating";
        mainHeating.SGroup = "Gas boilers and oil boilers";
        mainHeating.BSubGroup = "Combined Primary Storage Units (CPSU) (mains gas and LPG)";
        mainHeating.Boiler.PumpHP = "Yes";
        mainHeating.Emitter = System != 2 ? this.Emmiter((Enums.HeatingEmitterType) RdSAP.MainHeating[0].EmitterType, RdSAP) : this.Emmiter((Enums.HeatingEmitterType) RdSAP.MainHeating[1].EmitterType, RdSAP);
        switch (AltMethodRef)
        {
          case 120:
            mainHeating.MHType = "With automatic ignition (non-condensing)";
            break;
          case 121:
            mainHeating.MHType = "With automatic ignition (condensing)";
            break;
        }
      }
      else if (num >= 124 && num <= 132)
      {
        mainHeating.HGroup = "Central heating systems with radiators or underfloor heating";
        mainHeating.SGroup = "Gas boilers and oil boilers";
        mainHeating.BSubGroup = "Oil boilers";
        mainHeating.Boiler.PumpHP = "Yes";
        mainHeating.Emitter = System != 2 ? this.Emmiter((Enums.HeatingEmitterType) RdSAP.MainHeating[0].EmitterType, RdSAP) : this.Emmiter((Enums.HeatingEmitterType) RdSAP.MainHeating[1].EmitterType, RdSAP);
        switch (AltMethodRef)
        {
          case 125:
            mainHeating.MHType = "Standard oil boiler 1985 to 1997";
            break;
          case 126:
            mainHeating.MHType = "Standard oil boiler, 1998 or later";
            break;
          case (int) sbyte.MaxValue:
            mainHeating.MHType = "Condensing";
            break;
          case 128:
            mainHeating.MHType = "Combi, pre-1998";
            break;
          case 129:
            mainHeating.MHType = "Combi, 1998 or later";
            break;
          case 130:
            mainHeating.MHType = "Condensing combi";
            break;
          case 131:
            mainHeating.MHType = "Oil room heater with boiler to radiators, pre 2000";
            break;
          case 132:
            mainHeating.MHType = "Oil room heater with boiler to radiators, 2000 or later";
            break;
        }
      }
      else if (num >= 133 && num <= 138)
      {
        mainHeating.HGroup = "Central heating systems with radiators or underfloor heating";
        mainHeating.SGroup = "Gas boilers and oil boilers";
        mainHeating.BSubGroup = "Range cooker boilers (mains gas and LPG)";
        mainHeating.Boiler.PumpHP = "Yes";
        mainHeating.Emitter = System != 2 ? this.Emmiter((Enums.HeatingEmitterType) RdSAP.MainHeating[0].EmitterType, RdSAP) : this.Emmiter((Enums.HeatingEmitterType) RdSAP.MainHeating[1].EmitterType, RdSAP);
        switch (AltMethodRef)
        {
          case 133:
            mainHeating.MHType = "Single burner with permanent pilot";
            break;
          case 134:
            mainHeating.MHType = "Single burner with automatic ignition";
            break;
          case 136:
            mainHeating.MHType = "Twin burner with automatic ignition (non-condensing) pre 1998";
            break;
        }
      }
      else if (num >= 139 && num <= 140)
      {
        mainHeating.HGroup = "Central heating systems with radiators or underfloor heating";
        mainHeating.SGroup = "Gas boilers and oil boilers";
        mainHeating.BSubGroup = "Range cooker boilers (oil)";
        mainHeating.Boiler.PumpHP = "Yes";
        mainHeating.Emitter = System != 2 ? this.Emmiter((Enums.HeatingEmitterType) RdSAP.MainHeating[0].EmitterType, RdSAP) : this.Emmiter((Enums.HeatingEmitterType) RdSAP.MainHeating[1].EmitterType, RdSAP);
        switch (AltMethodRef)
        {
          case 139:
            mainHeating.MHType = "Single burner";
            break;
          case 140:
            mainHeating.MHType = "Twin burner (non-condensing) pre 1998";
            break;
        }
      }
      else if (num >= 151 && num <= 161)
      {
        mainHeating.HGroup = "Central heating systems with radiators or underfloor heating";
        mainHeating.SGroup = "Solid fuel boilers";
        mainHeating.BSubGroup = "";
        mainHeating.Boiler.PumpHP = "Yes";
        mainHeating.Emitter = System != 2 ? this.Emmiter((Enums.HeatingEmitterType) RdSAP.MainHeating[0].EmitterType, RdSAP) : this.Emmiter((Enums.HeatingEmitterType) RdSAP.MainHeating[1].EmitterType, RdSAP);
        switch (AltMethodRef)
        {
          case 151:
            mainHeating.MHType = "Manual feed independent boiler in heated space";
            mainHeating.MainEff = 60f;
            break;
          case 152:
            mainHeating.MHType = "Manual feed independent boiler in unheated space";
            mainHeating.MainEff = 55f;
            break;
          case 153:
            mainHeating.MHType = "Auto (gravity) feed independent boiler in heated space";
            mainHeating.MainEff = 65f;
            break;
          case 154:
            mainHeating.MHType = "Auto (gravity) feed independent boiler in unheated space";
            mainHeating.MainEff = 60f;
            break;
          case 155:
            mainHeating.MHType = "Wood chip/pellet independent boiler";
            mainHeating.MainEff = 63f;
            break;
          case 156:
            mainHeating.MHType = "Open fire with back boiler to radiators";
            mainHeating.MainEff = 55f;
            break;
          case 158:
            mainHeating.MHType = "Closed roomheater with boiler to radiators";
            mainHeating.MainEff = 65f;
            break;
          case 159:
            mainHeating.MHType = "Closed roomheater with boiler to radiators";
            mainHeating.MainEff = 63f;
            break;
          case 160:
            mainHeating.MHType = "Range cooker boiler (integral oven and boiler)";
            mainHeating.MainEff = 45f;
            break;
        }
      }
      else if (num >= 191 && num <= 195)
      {
        mainHeating.HGroup = "Central heating systems with radiators or underfloor heating";
        mainHeating.SGroup = "Electric boilers";
        mainHeating.BSubGroup = "";
        mainHeating.Boiler.PumpHP = "Yes";
        mainHeating.Emitter = System != 2 ? this.Emmiter((Enums.HeatingEmitterType) RdSAP.MainHeating[0].EmitterType, RdSAP) : this.Emmiter((Enums.HeatingEmitterType) RdSAP.MainHeating[1].EmitterType, RdSAP);
        switch (AltMethodRef)
        {
          case 191:
            mainHeating.MHType = "Direct acting electric boiler";
            mainHeating.MainEff = 100f;
            break;
          case 192:
            mainHeating.MHType = "Electric CPSU";
            mainHeating.MainEff = 100f;
            break;
          case 193:
            mainHeating.MHType = "Electric dry core storage boiler";
            mainHeating.MainEff = 100f;
            break;
          case 195:
            mainHeating.MHType = "Electric water storage boiler";
            mainHeating.MainEff = 100f;
            break;
        }
      }
      else if (num >= 201 && num <= 204)
      {
        mainHeating.HGroup = "Central heating systems with radiators or underfloor heating";
        mainHeating.SGroup = "Heat pumps";
        mainHeating.BSubGroup = "";
        mainHeating.Boiler.PumpHP = "Yes";
        mainHeating.Emitter = System != 2 ? this.Emmiter((Enums.HeatingEmitterType) RdSAP.MainHeating[0].EmitterType, RdSAP) : this.Emmiter((Enums.HeatingEmitterType) RdSAP.MainHeating[1].EmitterType, RdSAP);
        switch (AltMethodRef)
        {
          case 201:
            mainHeating.MHType = "Ground-to-water heat pump (electric)";
            mainHeating.MainEff = 320f;
            break;
          case 202:
            mainHeating.MHType = "Ground-to-water heat pump with auxiliary heater (electric)";
            mainHeating.MainEff = 300f;
            break;
          case 203:
            mainHeating.MHType = "Water-to-water heat pump (electric)";
            mainHeating.MainEff = 300f;
            break;
          case 204:
            mainHeating.MHType = "Air-to-water heat pump (electric)";
            mainHeating.MainEff = 250f;
            break;
        }
      }
      else
      {
        switch (num)
        {
          case 301:
            mainHeating.HGroup = "Community heating schemes";
            mainHeating.InforSource = "SAP Tables";
            mainHeating.MHType = "Community boilers";
            mainHeating.SAPTableCode = 306;
            mainHeating.CommunityH.Boiler1Efficiency = 80f;
            mainHeating.CommunityH.Boiler1HeatFraction = 1f;
            mainHeating.CommunityH.HeatDSystem = "Piping<=1990, pre-insulated, low temp, full flow";
            mainHeating.CommunityH.NoOfAdditionalHeatSources = 0;
            break;
          case 302:
            mainHeating.HGroup = "Community heating schemes";
            mainHeating.InforSource = "SAP Tables";
            mainHeating.MHType = "Community CHP";
            mainHeating.SAPTableCode = 307;
            mainHeating.CommunityH.Boiler1Efficiency = 75f;
            mainHeating.CommunityH.Boiler1HeatFraction = 0.35f;
            mainHeating.CommunityH.HeatDSystem = "Piping<=1990, pre-insulated, low temp, full flow";
            mainHeating.CommunityH.NoOfAdditionalHeatSources = 1;
            mainHeating.CommunityH.HeatToPowerRatio = 2f;
            mainHeating.CommunityH.HeatToPowerRatio = 25f;
            mainHeating.CommunityH.HeatSource1.Type = 306;
            mainHeating.CommunityH.HeatSource1.Fuel = this.Fuel(FuelType);
            mainHeating.CommunityH.HeatSource1.HeatFraction = 0.65f;
            mainHeating.CommunityH.HeatSource1.Efficiency = 80f;
            break;
          case 304:
            mainHeating.HGroup = "Community heating schemes";
            mainHeating.InforSource = "SAP Tables";
            mainHeating.MHType = "Community heat pump";
            mainHeating.SAPTableCode = 309;
            mainHeating.CommunityH.Boiler1Efficiency = 300f;
            mainHeating.CommunityH.Boiler1HeatFraction = 1f;
            mainHeating.CommunityH.HeatDSystem = "Piping<=1990, pre-insulated, low temp, full flow";
            mainHeating.CommunityH.NoOfAdditionalHeatSources = 0;
            break;
          default:
            if (num >= 401 && num <= 408)
            {
              mainHeating.HGroup = "Electric storage systems";
              mainHeating.SGroup = "Off-peak tariffs";
              mainHeating.BSubGroup = "";
              mainHeating.MainEff = 100f;
              switch (AltMethodRef)
              {
                case 401:
                  mainHeating.MHType = "Old (large volume) storage heaters";
                  break;
                case 402:
                  mainHeating.MHType = "Modern (slimline) storage heaters";
                  break;
                case 404:
                  mainHeating.MHType = "Fan storage heaters";
                  break;
                case 408:
                  mainHeating.MHType = "Integrated storage+direct-acting heater";
                  break;
              }
            }
            else if (num >= 421 && num <= 425)
            {
              mainHeating.HGroup = "Electric underfloor heating";
              mainHeating.BSubGroup = "";
              mainHeating.MainEff = 100f;
              switch (AltMethodRef)
              {
                case 421:
                  mainHeating.MHType = "Old (large volume) storage heaters";
                  mainHeating.SGroup = "Off-peak tariffs";
                  break;
                case 422:
                  mainHeating.MHType = "Modern (slimline) storage heaters";
                  mainHeating.SGroup = "Off-peak tariffs";
                  break;
                case 424:
                  mainHeating.MHType = "Fan storage heaters";
                  mainHeating.SGroup = "Standard tariff";
                  break;
              }
            }
            else
            {
              if (num >= 501 && num <= 505)
              {
                mainHeating.HGroup = "Warm air systems";
                mainHeating.SGroup = "Gas-fired warm air with fan-assisted flue";
                mainHeating.BSubGroup = "";
                if (AltMethodRef == 502)
                {
                  mainHeating.MHType = "Ducted, on-off control, 1998 or later";
                  mainHeating.MainEff = 76f;
                  break;
                }
                break;
              }
              if (num >= 506 && num <= 511)
              {
                mainHeating.HGroup = "Warm air systems";
                mainHeating.SGroup = "Gas fired warm air with balanced or open flue";
                mainHeating.BSubGroup = "";
                switch (AltMethodRef)
                {
                  case 506:
                    mainHeating.MHType = "Ducted or stub-ducted, on-off control, pre 1998";
                    mainHeating.MainEff = 70f;
                    break;
                  case 510:
                    mainHeating.MHType = "Ducted or stub-ducted with flue heat recovery";
                    mainHeating.MainEff = 85f;
                    break;
                  case 511:
                    mainHeating.MHType = "Condensing";
                    mainHeating.MainEff = 81f;
                    break;
                }
              }
              else
              {
                switch (num)
                {
                  case 512:
                    mainHeating.HGroup = "Warm air systems";
                    mainHeating.SGroup = "Oil-fired warm air";
                    mainHeating.BSubGroup = "";
                    mainHeating.MHType = "Ducted output";
                    mainHeating.MainEff = 70f;
                    break;
                  case 515:
                    mainHeating.HGroup = "Warm air systems";
                    mainHeating.SGroup = "Oil-fired warm air";
                    mainHeating.BSubGroup = "";
                    mainHeating.MHType = "Electricaire system";
                    mainHeating.MainEff = 100f;
                    break;
                  default:
                    if (num >= 521 && num <= 527)
                    {
                      mainHeating.HGroup = "Warm air systems";
                      mainHeating.SGroup = "Heat pumps";
                      mainHeating.BSubGroup = "";
                      switch (AltMethodRef)
                      {
                        case 521:
                          mainHeating.MHType = "Ground-to-air heat pump (electric)";
                          mainHeating.MainEff = 320f;
                          break;
                        case 522:
                          mainHeating.MHType = "Ground-to-air heat pump with auxiliary heater (electric)";
                          mainHeating.MainEff = 300f;
                          break;
                        case 523:
                          mainHeating.MHType = "Water-to-air heat pump (electric)";
                          mainHeating.MainEff = 300f;
                          break;
                        case 524:
                          mainHeating.MHType = "Air-to-air heat pump (electric)";
                          mainHeating.MainEff = 250f;
                          break;
                      }
                    }
                    else if (num >= 601 && num <= 613)
                    {
                      mainHeating.HGroup = "Room heaters";
                      mainHeating.SGroup = "Gas (including LPG) room heaters";
                      mainHeating.BSubGroup = "";
                      switch (AltMethodRef)
                      {
                        case 601:
                          mainHeating.MainEff = 50f;
                          mainHeating.MHType = "Gas fire, open flue, pre-1980 (open fronted)";
                          break;
                        case 602:
                          mainHeating.MainEff = 50f;
                          mainHeating.MHType = "Gas fire, open flue, pre-1980 (open fronted), with back boiler unit";
                          break;
                        case 603:
                          mainHeating.MainEff = FuelType != Enums.HeatingFuelType.Mains_Gas ? 64f : 63f;
                          mainHeating.MHType = "Gas fire, open flue, 1980 or later (open fronted),sitting proud of, and sealed to, fireplace opening";
                          break;
                        case 604:
                          mainHeating.MainEff = FuelType != Enums.HeatingFuelType.Mains_Gas ? 64f : 63f;
                          mainHeating.MHType = "Gas fire, open flue, 1980 or later (open fronted), sitting proud of, and sealed to, fireplace opening, with back boiler unit";
                          break;
                        case 605:
                          mainHeating.MainEff = FuelType != Enums.HeatingFuelType.Mains_Gas ? 41f : 40f;
                          mainHeating.MHType = "Flush fitting Live Fuel Effect gas fire (open fronted), sealed to fireplace opening";
                          break;
                        case 606:
                          mainHeating.MainEff = FuelType != Enums.HeatingFuelType.Mains_Gas ? 41f : 40f;
                          mainHeating.MHType = "Flush fitting Live Fuel Effect gas fire (open fronted), sealed to fireplace opening, with back boiler unit";
                          break;
                        case 607:
                          mainHeating.MainEff = FuelType != Enums.HeatingFuelType.Mains_Gas ? 46f : 45f;
                          mainHeating.MHType = "Flush fitting Live Fuel Effect gas fire (open fronted), fan assisted, sealed to fireplace opening";
                          break;
                        case 609:
                          mainHeating.MainEff = FuelType != Enums.HeatingFuelType.Mains_Gas ? 60f : 58f;
                          mainHeating.MHType = "Gas fire or wall heater, balanced flue";
                          break;
                        case 610:
                          mainHeating.MainEff = FuelType != Enums.HeatingFuelType.Mains_Gas ? 73f : 72f;
                          mainHeating.MHType = "Gas fire, closed fronted, fan assisted";
                          break;
                        case 611:
                          mainHeating.MainEff = FuelType != Enums.HeatingFuelType.Mains_Gas ? 85f : 85f;
                          mainHeating.MHType = "Condensing gas fire";
                          break;
                        case 612:
                          mainHeating.MainEff = FuelType != Enums.HeatingFuelType.Mains_Gas ? 20f : 20f;
                          mainHeating.MHType = "Decorative Fuel Effect gas fire, open to chimney";
                          break;
                        case 613:
                          mainHeating.MainEff = FuelType != Enums.HeatingFuelType.Mains_Gas ? 92f : 90f;
                          mainHeating.MHType = "Flueless gas fire, secondary heating only";
                          break;
                      }
                    }
                    else if (num >= 621 && num <= 625)
                    {
                      mainHeating.HGroup = "Room heaters";
                      mainHeating.SGroup = "Oil room heaters";
                      mainHeating.BSubGroup = "";
                      switch (AltMethodRef)
                      {
                        case 621:
                          mainHeating.MainEff = 55f;
                          mainHeating.MHType = "Room heater, pre 2000";
                          break;
                        case 622:
                          mainHeating.MainEff = 65f;
                          mainHeating.MHType = "Room heater, pre 2000, with boiler (no radiators)";
                          break;
                        case 623:
                          mainHeating.MainEff = 60f;
                          mainHeating.MHType = "Room heater, 2000 or later";
                          break;
                        case 624:
                          mainHeating.MainEff = 70f;
                          mainHeating.MHType = "Room heater, 2000 or later with boiler (no radiators)";
                          break;
                        case 625:
                          mainHeating.MainEff = 94f;
                          mainHeating.MHType = "Bioethanol heater, secondary heating only";
                          break;
                      }
                    }
                    else if (num >= 631 && num <= 636)
                    {
                      mainHeating.HGroup = "Room heaters";
                      mainHeating.SGroup = "Solid fuel room heaters";
                      mainHeating.HETAS = "No";
                      mainHeating.BSubGroup = "";
                      switch (AltMethodRef)
                      {
                        case 631:
                          mainHeating.MainEff = 32f;
                          mainHeating.MHType = "Open fire in grate";
                          break;
                        case 632:
                          mainHeating.MainEff = 50f;
                          mainHeating.MHType = "Open fire with back boiler (no radiators)";
                          break;
                        case 633:
                          mainHeating.MainEff = 60f;
                          mainHeating.MHType = "Closed room heater";
                          break;
                        case 634:
                          mainHeating.MainEff = 65f;
                          mainHeating.MHType = "Closed room heater with boiler (no radiators)";
                          break;
                        case 635:
                          mainHeating.MainEff = 63f;
                          mainHeating.MHType = "Stove (pellet fired)";
                          break;
                        case 636:
                          mainHeating.MainEff = 63f;
                          mainHeating.MHType = "Stove (pellet fired) with boiler (no radiators)";
                          break;
                      }
                    }
                    else if (num >= 691 && num <= 694)
                    {
                      mainHeating.HGroup = "Room heaters";
                      mainHeating.SGroup = "Electric (direct acting) room heaters";
                      mainHeating.MainEff = 100f;
                      mainHeating.BSubGroup = "";
                      switch (AltMethodRef)
                      {
                        case 691:
                          mainHeating.MHType = "Panel, convector or radiant heaters";
                          break;
                        case 692:
                          mainHeating.MHType = "Fan heaters";
                          break;
                        case 693:
                          mainHeating.MHType = "Portable electric heaters";
                          break;
                        case 694:
                          mainHeating.MHType = "Water- or oil-filled radiators";
                          break;
                      }
                    }
                    else
                    {
                      switch (num)
                      {
                        case 699:
                          mainHeating.MainEff = 100f;
                          break;
                        case 701:
                          mainHeating.MainEff = 100f;
                          break;
                      }
                    }
                    break;
                }
              }
            }
            break;
        }
      }
      surveyClass = (Survey_Class) null;
      return mainHeating;
    }

    private string Emmiter(Enums.HeatingEmitterType Em, Survey_Class RdSAP)
    {
      string str = "";
      Survey_Class surveyClass = RdSAP;
      switch (Em)
      {
        case Enums.HeatingEmitterType.Radiators:
          str = "Systems with radiators";
          break;
        case Enums.HeatingEmitterType.Fan_Coil_Units:
          str = "Fan coil units";
          break;
        default:
          if (surveyClass.Extensions[0].LowestFloor == 5)
          {
            if (surveyClass.Extensions[0].FloorConstruction == 1)
            {
              string mage1 = this.Ext.Ages.MAge;
              if (Operators.CompareString(mage1, "A", false) == 0 || Operators.CompareString(mage1, "B", false) == 0)
              {
                str = "Underfloor heating, pipes in insulated timber floor";
              }
              else
              {
                string mage2 = this.Ext.Ages.MAge;
                str = Operators.CompareString(mage2, "C", false) == 0 || Operators.CompareString(mage2, "D", false) == 0 || Operators.CompareString(mage2, "E", false) == 0 ? "Underfloor heating, pipes in concrete slab" : "Underfloor heating, pipes in screed above insulation";
              }
            }
            else if (surveyClass.Extensions[0].FloorConstruction == 3)
              str = "Underfloor heating, pipes in insulated timber floor";
            else if (surveyClass.Extensions[0].FloorConstruction == 4)
              str = "Underfloor heating, pipes in screed above insulation";
            else if (surveyClass.Extensions[0].FloorConstruction == 2)
            {
              string mage = this.Ext.Ages.MAge;
              str = Operators.CompareString(mage, "A", false) == 0 || Operators.CompareString(mage, "B", false) == 0 || Operators.CompareString(mage, "C", false) == 0 || Operators.CompareString(mage, "D", false) == 0 || Operators.CompareString(mage, "E", false) == 0 ? "Underfloor heating, pipes in concrete slab" : "Underfloor heating, pipes in screed above insulation";
            }
          }
          else if (surveyClass.Extensions[0].LowestFloor == 3 | surveyClass.Extensions[0].LowestFloor == 4)
          {
            if (surveyClass.Extensions[0].WallConstruction == 5)
            {
              str = "Underfloor heating, pipes in insulated timber floor";
            }
            else
            {
              string mage = this.Ext.Ages.MAge;
              str = Operators.CompareString(mage, "A", false) == 0 || Operators.CompareString(mage, "B", false) == 0 || Operators.CompareString(mage, "C", false) == 0 || Operators.CompareString(mage, "D", false) == 0 || Operators.CompareString(mage, "E", false) == 0 ? "Underfloor heating, pipes in concrete slab" : "Underfloor heating, pipes in screed above insulation";
            }
          }
          else if (surveyClass.Extensions[0].LowestFloor == 2 | surveyClass.Extensions[0].LowestFloor == 1)
          {
            if (surveyClass.Extensions[0].WallConstruction == 5)
            {
              str = "Underfloor heating, pipes in insulated timber floor";
            }
            else
            {
              string mage = this.Ext.Ages.MAge;
              str = Operators.CompareString(mage, "A", false) == 0 || Operators.CompareString(mage, "B", false) == 0 || Operators.CompareString(mage, "C", false) == 0 || Operators.CompareString(mage, "D", false) == 0 || Operators.CompareString(mage, "E", false) == 0 ? "Underfloor heating, pipes in concrete slab" : "Underfloor heating, pipes in screed above insulation";
            }
          }
          break;
      }
      return str;
    }

    private void SecHeating_Spec(Survey_Class RdSAP)
    {
      Survey_Class surveyClass = RdSAP;
      if (surveyClass.SecondaryHeating.Present)
      {
        this.x.SecHeating.HGroup = "Room heaters";
        this.x.SecHeating.InforSource = "SAP Tables";
        this.x.SecHeating.Fuel = this.Fuel((Enums.HeatingFuelType) surveyClass.SecondaryHeating.Fuel);
        this.x.SecHeating.SAPTableCode = surveyClass.SecondaryHeating.Code;
        int sapTableCode = this.x.SecHeating.SAPTableCode;
        if (sapTableCode >= 601 && sapTableCode <= 613)
        {
          this.x.SecHeating.SGroup = "Gas (including LPG) room heaters";
          switch (this.x.SecHeating.SAPTableCode)
          {
            case 601:
              this.x.SecHeating.SecEff = 50f;
              this.x.SecHeating.MHType = "Gas fire, open flue, pre-1980 (open fronted)";
              break;
            case 602:
              this.x.SecHeating.SecEff = 50f;
              this.x.SecHeating.MHType = "Gas fire, open flue, pre-1980 (open fronted), with back boiler unit";
              break;
            case 603:
              this.x.SecHeating.SecEff = surveyClass.SecondaryHeating.Fuel != 1 ? 64f : 63f;
              this.x.SecHeating.MHType = "Gas fire, open flue, 1980 or later (open fronted),sitting proud of, and sealed to, fireplace opening";
              break;
            case 604:
              this.x.SecHeating.SecEff = surveyClass.SecondaryHeating.Fuel != 1 ? 64f : 63f;
              this.x.SecHeating.MHType = "Gas fire, open flue, 1980 or later (open fronted), sitting proud of, and sealed to, fireplace opening, with back boiler unit";
              break;
            case 605:
              this.x.SecHeating.SecEff = surveyClass.SecondaryHeating.Fuel != 1 ? 41f : 40f;
              this.x.SecHeating.MHType = "Flush fitting Live Fuel Effect gas fire (open fronted), sealed to fireplace opening";
              break;
            case 606:
              this.x.SecHeating.SecEff = surveyClass.SecondaryHeating.Fuel != 1 ? 41f : 40f;
              this.x.SecHeating.MHType = "Flush fitting Live Fuel Effect gas fire (open fronted), sealed to fireplace opening, with back boiler unit";
              break;
            case 607:
              this.x.SecHeating.SecEff = surveyClass.SecondaryHeating.Fuel != 1 ? 46f : 45f;
              this.x.SecHeating.MHType = "Flush fitting Live Fuel Effect gas fire (open fronted), fan assisted, sealed to fireplace opening";
              break;
            case 609:
              this.x.SecHeating.SecEff = surveyClass.SecondaryHeating.Fuel != 1 ? 60f : 58f;
              this.x.SecHeating.MHType = "Gas fire or wall heater, balanced flue";
              break;
            case 610:
              this.x.SecHeating.SecEff = surveyClass.SecondaryHeating.Fuel != 1 ? 73f : 72f;
              this.x.SecHeating.MHType = "Gas fire, closed fronted, fan assisted";
              break;
            case 611:
              this.x.SecHeating.SecEff = surveyClass.SecondaryHeating.Fuel != 1 ? 85f : 85f;
              this.x.SecHeating.MHType = "Condensing gas fire";
              break;
            case 612:
              this.x.SecHeating.SecEff = surveyClass.SecondaryHeating.Fuel != 1 ? 20f : 20f;
              this.x.SecHeating.MHType = "Decorative Fuel Effect gas fire, open to chimney";
              break;
            case 613:
              this.x.SecHeating.SecEff = surveyClass.SecondaryHeating.Fuel != 1 ? 92f : 90f;
              this.x.SecHeating.MHType = "Flueless gas fire, secondary heating only";
              break;
          }
        }
        else if (sapTableCode >= 621 && sapTableCode <= 625)
        {
          this.x.SecHeating.SGroup = "Oil room heaters";
          switch (this.x.SecHeating.SAPTableCode)
          {
            case 621:
              this.x.SecHeating.SecEff = 55f;
              this.x.SecHeating.MHType = "Room heater, pre 2000";
              break;
            case 622:
              this.x.SecHeating.SecEff = 65f;
              this.x.SecHeating.MHType = "Room heater, pre 2000, with boiler (no radiators)";
              break;
            case 623:
              this.x.SecHeating.SecEff = 60f;
              this.x.SecHeating.MHType = "Room heater, 2000 or later";
              break;
            case 624:
              this.x.SecHeating.SecEff = 70f;
              this.x.SecHeating.MHType = "Room heater, 2000 or later with boiler (no radiators)";
              break;
            case 625:
              this.x.SecHeating.SecEff = 94f;
              this.x.SecHeating.MHType = "Bioethanol heater, secondary heating only";
              break;
          }
        }
        else if (sapTableCode >= 631 && sapTableCode <= 636)
        {
          this.x.SecHeating.SGroup = "Solid fuel room heaters";
          this.x.SecHeating.HETAS = "No";
          switch (this.x.SecHeating.SAPTableCode)
          {
            case 631:
              this.x.SecHeating.SecEff = 32f;
              this.x.SecHeating.MHType = "Open fire in grate";
              break;
            case 632:
              this.x.SecHeating.SecEff = 50f;
              this.x.SecHeating.MHType = "Open fire with back boiler (no radiators)";
              break;
            case 633:
              this.x.SecHeating.SecEff = 60f;
              this.x.SecHeating.MHType = "Closed room heater";
              break;
            case 634:
              this.x.SecHeating.SecEff = 65f;
              this.x.SecHeating.MHType = "Closed room heater with boiler (no radiators)";
              break;
            case 635:
              this.x.SecHeating.SecEff = 63f;
              this.x.SecHeating.MHType = "Stove (pellet fired)";
              break;
            case 636:
              this.x.SecHeating.SecEff = 63f;
              this.x.SecHeating.MHType = "Stove (pellet fired) with boiler (no radiators)";
              break;
          }
        }
        else if (sapTableCode >= 691 && sapTableCode <= 694)
        {
          this.x.SecHeating.SGroup = "Electric (direct acting) room heaters";
          this.x.SecHeating.SecEff = 100f;
          switch (this.x.SecHeating.SAPTableCode)
          {
            case 691:
              this.x.SecHeating.MHType = "Panel, convector or radiant heaters";
              break;
            case 692:
              this.x.SecHeating.MHType = "Fan heaters";
              break;
            case 693:
              this.x.SecHeating.MHType = "Portable electric heaters";
              break;
            case 694:
              this.x.SecHeating.MHType = "Water- or oil-filled radiators";
              break;
          }
        }
      }
    }

    private string SEDBUKFull(string SEDBUKRef)
    {
      string str = "";
      switch (SEDBUKRef.Length)
      {
        case 1:
          if ((uint) Operators.CompareString(SEDBUKRef, "0", false) > 0U)
          {
            str = "00000" + SEDBUKRef;
            break;
          }
          break;
        case 2:
          str = "0000" + SEDBUKRef;
          break;
        case 3:
          str = "000" + SEDBUKRef;
          break;
        case 4:
          str = "00" + SEDBUKRef;
          break;
        case 5:
          str = "0" + SEDBUKRef;
          break;
        default:
          str = SEDBUKRef;
          break;
      }
      return str;
    }

    private string Fuel(Enums.HeatingFuelType FuelType)
    {
      string str = "";
      switch (FuelType)
      {
        case Enums.HeatingFuelType.Mains_Gas:
          str = "mains gas";
          break;
        case Enums.HeatingFuelType.Bulk_LPG:
          str = "bulk LPG";
          break;
        case Enums.HeatingFuelType.Bottle_LPG:
          str = "bottled LPG";
          break;
        case Enums.HeatingFuelType.Heating_Oil:
          str = "heating oil";
          break;
        case Enums.HeatingFuelType.LNG:
          str = "LNG";
          break;
        case Enums.HeatingFuelType.LPG_special_condition:
          str = "LPG subject to Special Condition 18";
          break;
        case Enums.HeatingFuelType.Dual_Fuel_Mineral_Wood:
        case Enums.HeatingFuelType.Dual_Fuel_Mineral_Wood2:
          str = "dual fuel appliance (mineral and wood)";
          break;
        case Enums.HeatingFuelType.House_Coal:
          str = "house coal";
          break;
        case Enums.HeatingFuelType.Smokeless_Coal:
          str = "manufactured smokeless fuel";
          break;
        case Enums.HeatingFuelType.Anthracite:
          str = "anthracite";
          break;
        case Enums.HeatingFuelType.Wood_Logs:
          str = "wood logs";
          break;
        case Enums.HeatingFuelType.Wood_Chips:
          str = "wood chips";
          break;
        case Enums.HeatingFuelType.wood_pellets_in_bags_for_secondary_heating:
        case Enums.HeatingFuelType.wood_pellets_in_bags_for_secondary_heating2:
          str = "wood pellets (in bags, for secondary heating)";
          break;
        case Enums.HeatingFuelType.Bulk_Wood_Pellets:
          str = "wood pellets (bulk supply in bags, for main heating)";
          break;
        case Enums.HeatingFuelType._7_hour_tariff_low_rate:
        case Enums.HeatingFuelType._7_hour_tariff_high_rate:
        case Enums.HeatingFuelType._10_hour_tariff_low_rate:
        case Enums.HeatingFuelType._10_hour_tariff_high_rate:
        case Enums.HeatingFuelType._24_hour_heating_tariff:
        case Enums.HeatingFuelType.electricity_sold_to_grid:
        case Enums.HeatingFuelType.electricity_displaced_from_grid:
        case Enums.HeatingFuelType.electricity_unspecified:
        case Enums.HeatingFuelType.electricity:
          str = "Electricity";
          break;
        case Enums.HeatingFuelType.Electricity_Community:
          str = "heat from electric heat pump";
          break;
        case Enums.HeatingFuelType.Waste_Combustion_Community:
          str = "heat from boilers - waste combustion";
          break;
        case Enums.HeatingFuelType.Biomass_Community:
          str = "heat from boilers – biomass";
          break;
        case Enums.HeatingFuelType.Biogas_Community:
          str = "heat from boilers – biogas";
          break;
        case Enums.HeatingFuelType.WasteHeat:
          str = "waste heat from power stations";
          break;
        case Enums.HeatingFuelType.geothermal_Community:
          str = "geothermal heat source";
          break;
        case Enums.HeatingFuelType.CHP_Community:
          str = "heat from CHP";
          break;
        case Enums.HeatingFuelType.Mains_Gas_Community:
          str = "heat from boilers - mains gas";
          break;
        case Enums.HeatingFuelType.LPG_Community:
          str = "heat from boilers – LPG";
          break;
        case Enums.HeatingFuelType.Heating_Oil_Community:
          str = "heat from boilers – oil";
          break;
        case Enums.HeatingFuelType.Coal_Community_:
          str = "heat from boilers – coal";
          break;
        case Enums.HeatingFuelType.B30D_Community_:
          str = "heat from boilers – B30D";
          break;
        case Enums.HeatingFuelType.biodiesel_from_any_biomass_source:
          str = "biodiesel from any biomass source";
          break;
        case Enums.HeatingFuelType.Biodiesel_from_used_cooking_oil_only:
          str = "biodiesel from used cooking oil only";
          break;
        case Enums.HeatingFuelType.Rapeseed_oil:
          str = "rapeseed oil";
          break;
        case Enums.HeatingFuelType.Appliances_able_to_use_mineral_oil_or_liquid_biofuel:
          str = "appliances able to use mineral oil or liquid biofuel";
          break;
        case Enums.HeatingFuelType.B30K__not_community:
          str = "B30K";
          break;
        case Enums.HeatingFuelType.Bioethanol:
          str = "bioethanol from any biomass source";
          break;
      }
      return str;
    }

    private void Electricity(Survey_Class RdSAP)
    {
      Survey_Class surveyClass = RdSAP;
      switch (surveyClass.OtherDetails.MeterType)
      {
        case 1:
          this.x.MainHeating.ElectricityTariff = "7-hour tariff";
          int sapCode1 = surveyClass.MainHeating[0].SAPCode;
          switch (sapCode1)
          {
            case 191:
              this.x.MainHeating.ElectricityTariff = "10-hour tariff";
              break;
            case 192:
              this.x.MainHeating.ElectricityTariff = "10-hour tariff";
              break;
            default:
              if (sapCode1 >= 201 && sapCode1 <= 204 || sapCode1 >= 521 && sapCode1 <= 524)
              {
                this.x.MainHeating.ElectricityTariff = "10-hour tariff";
                break;
              }
              if (sapCode1 >= 691 && sapCode1 <= 694)
              {
                this.x.MainHeating.ElectricityTariff = "10-hour tariff";
                break;
              }
              if (sapCode1 == 0 && Operators.CompareString(this.x.MainHeating.SGroup, "Heat pumps", false) == 0)
              {
                this.x.MainHeating.ElectricityTariff = "10-hour tariff";
                break;
              }
              break;
          }
          break;
        case 2:
          this.x.MainHeating.ElectricityTariff = "standard tariff";
          break;
        case 3:
          this.x.MainHeating.ElectricityTariff = "standard tariff";
          int sapCode2 = surveyClass.MainHeating[0].SAPCode;
          switch (sapCode2)
          {
            case 191:
              this.x.MainHeating.ElectricityTariff = "10-hour tariff";
              break;
            case 192:
              this.x.MainHeating.ElectricityTariff = "10-hour tariff";
              break;
            default:
              if (sapCode2 >= 193 && sapCode2 <= 196)
              {
                this.x.MainHeating.ElectricityTariff = "7-hour tariff";
                break;
              }
              if (sapCode2 >= 201 && sapCode2 <= 204 || sapCode2 >= 521 && sapCode2 <= 524)
              {
                this.x.MainHeating.ElectricityTariff = "10-hour tariff";
                break;
              }
              if (sapCode2 >= 401 && sapCode2 <= 408)
              {
                this.x.MainHeating.ElectricityTariff = "7-hour tariff";
                break;
              }
              if (sapCode2 >= 421 && sapCode2 <= 422)
              {
                this.x.MainHeating.ElectricityTariff = "7-hour tariff";
                break;
              }
              break;
          }
          if (surveyClass.MainHeating[1].Present)
          {
            int sapCode3 = surveyClass.MainHeating[1].SAPCode;
            if (sapCode3 >= 193 && sapCode3 <= 196)
              this.x.MainHeating.ElectricityTariff = "7-hour tariff";
            else if (sapCode3 >= 401 && sapCode3 <= 408)
              this.x.MainHeating.ElectricityTariff = "7-hour tariff";
            else if (sapCode3 >= 421 && sapCode3 <= 422)
              this.x.MainHeating.ElectricityTariff = "7-hour tariff";
          }
          if (surveyClass.WaterHeating.Code == 903 && surveyClass.WaterHeating.ImmersionHeatingType == 1 & Operators.CompareString(this.x.MainHeating.ElectricityTariff, "7-hour tariff", false) == 0)
          {
            this.x.MainHeating.ElectricityTariff = "7-hour tariff";
            break;
          }
          break;
        case 4:
          this.x.MainHeating.ElectricityTariff = "24-hour tariff";
          break;
      }
    }

    private void Controls(Survey_Class RdSAP)
    {
      Survey_Class surveyClass = RdSAP;
      this.x.MainHeating.ControlCode = surveyClass.MainHeating[0].ControlsCode;
      this.x.MainHeating.Controls = this.GetControlText(this.x.MainHeating.ControlCode);
      try
      {
        this.x.MainHeating2.ControlCode = surveyClass.MainHeating[1].ControlsCode;
        this.x.MainHeating2.Controls = this.GetControlText(this.x.MainHeating2.ControlCode);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private string GetControlText(int Code)
    {
      string controlText = "";
      switch (Code)
      {
        case 2101:
          controlText = "No time or thermostatic control of room temperature";
          break;
        case 2102:
          controlText = "Programmer, no room thermostat";
          break;
        case 2103:
          controlText = "Room thermostat only";
          break;
        case 2104:
          controlText = "Programmer and room thermostat";
          break;
        case 2105:
          controlText = "Programmer and at least two room thermostats";
          break;
        case 2106:
          controlText = "Programmer, room thermostat and TRVs";
          break;
        case 2107:
          controlText = "Programmer, TRVs and bypass";
          break;
        case 2109:
          controlText = "Programmer, TRVs and boiler energy manager";
          break;
        case 2110:
          controlText = "Time and temperature zone control";
          break;
        case 2201:
          controlText = "No time or thermostatic control of room temperature";
          break;
        case 2202:
          controlText = "Programmer, no room thermostat";
          break;
        case 2203:
          controlText = "Room thermostat only";
          break;
        case 2204:
          controlText = "Programmer and room thermostat";
          break;
        case 2205:
          controlText = "Programmer and at least two room thermostats";
          break;
        case 2206:
          controlText = "Programmer, TRVs and bypass";
          break;
        case 2207:
          controlText = "Time and temperature zone control";
          break;
        case 2301:
          controlText = "Flat rate charging, no thermostatic control of room temperature";
          break;
        case 2302:
          controlText = "Flat rate charging, programmer, no room thermostat";
          break;
        case 2303:
          controlText = "Flat rate charging, room thermostat only";
          break;
        case 2304:
          controlText = "Flat rate charging, programmer and room thermostat";
          break;
        case 2305:
          controlText = "Flat rate charging*, programmer and TRVs";
          break;
        case 2401:
          controlText = "Manual charge control";
          break;
        case 2402:
          controlText = "Automatic charge control";
          break;
        case 2501:
          controlText = "No thermostatic control of room temperature";
          break;
        case 2502:
          controlText = "Programmer, no room thermostat";
          break;
        case 2503:
          controlText = "Room thermostat only";
          break;
        case 2504:
          controlText = "Programmer and room thermostat";
          break;
        case 2505:
          controlText = "Programmer and at least two room thermostats";
          break;
        case 2506:
          controlText = "Time and temperature zone control";
          break;
        case 2601:
          controlText = "No thermostatic control of room temperature";
          break;
        case 2602:
          controlText = "Appliance thermostats";
          break;
        case 2603:
          controlText = "Programmer and appliance thermostats";
          break;
        case 2604:
          controlText = "Room thermostats only";
          break;
        case 2605:
          controlText = "Programmer and room thermostats";
          break;
        case 2701:
          controlText = "No thermostatic control of room temperature";
          break;
        case 2702:
          controlText = "Programmer, no room thermostat";
          break;
        case 2703:
          controlText = "Room thermostat only";
          break;
        case 2704:
          controlText = "Programmer and room thermostat";
          break;
        case 2705:
          controlText = "Temperature zone control";
          break;
        case 2706:
          controlText = "Time and temperature zone control";
          break;
      }
      return controlText;
    }

    private void SpaceCooling(Survey_Class rdsap)
    {
      if (!rdsap.OtherDetails.SpaceCooling)
        ;
    }

    private void BoilerInterlock(Survey_Class RdSAP)
    {
      if (this.x.MainHeating.SAPTableCode < 150)
      {
        switch (this.x.MainHeating.ControlCode)
        {
          case 2103:
          case 2104:
          case 2105:
          case 2106:
          case 2110:
            this.x.MainHeating.Boiler.BILock = this.x.Water.SystemRef != 901 ? "Yes" : ((double) this.x.Water.Cylinder.Volume <= 0.0 ? "Yes" : (!this.x.Water.Cylinder.Thermostat ? "No" : "Yes"));
            break;
          default:
            this.x.MainHeating.Boiler.BILock = "No";
            break;
        }
      }
      if (this.Ext.IsCPSU)
        this.x.MainHeating.Boiler.BILock = "Yes";
      if (!this.x.IncludeMainHeating2 || this.x.MainHeating2.SAPTableCode >= 150)
        return;
      switch (this.x.MainHeating2.ControlCode)
      {
        case 2103:
        case 2104:
        case 2105:
        case 2106:
        case 2110:
          if (this.x.Water.SystemRef == 914)
          {
            this.x.MainHeating2.Boiler.BILock = (double) this.x.Water.Cylinder.Volume <= 0.0 ? "Yes" : (!this.x.Water.Cylinder.Thermostat ? "No" : "Yes");
            break;
          }
          this.x.MainHeating.Boiler.BILock = "Yes";
          break;
        default:
          this.x.MainHeating2.Boiler.BILock = "No";
          break;
      }
    }

    private void SecondaryHeatingCheck(Survey_Class RdSAP)
    {
      Survey_Class surveyClass = RdSAP;
      if ((double) surveyClass.Age.MHeatHabRooms / (double) surveyClass.Age.MHabRooms <= 0.25)
      {
        if (this.x.MainHeating.SAPTableCode >= 601 & this.x.MainHeating.SAPTableCode <= 636)
        {
          string electricityTariff = this.x.MainHeating.ElectricityTariff;
          this.Ext.DoneHeatingSwap = true;
          this.x.SecHeating.SAPTableCode = this.x.MainHeating.SAPTableCode;
          this.x.SecHeating.Fuel = this.x.MainHeating.Fuel;
          this.x.SecHeating.SecEff = this.x.MainHeating.MainEff;
          this.x.SecHeating.SGroup = this.x.MainHeating.SGroup;
          this.x.SecHeating.InforSource = "SAP Tables";
          this.x.SecHeating.MHType = this.x.MainHeating.MHType;
          this.x.SecHeating.HETAS = this.x.MainHeating.HETAS;
          this.x.SecHeating.HGroup = this.x.MainHeating.HGroup;
          this.x.MainHeating = new SAP_Module.MainHeating();
          this.x.MainHeating.HGroup = "Room heaters";
          this.x.MainHeating.SGroup = "Electric (direct acting) room heaters";
          this.x.MainHeating.InforSource = "SAP Tables";
          this.x.MainHeating.MHType = "Portable electric heaters";
          this.x.MainHeating.SAPTableCode = 693;
          this.x.MainHeating.Controls = "No thermostatic control of room temperature";
          this.x.MainHeating.ControlCode = 2601;
          this.x.MainHeating.Fuel = "Electricity";
          this.x.MainHeating.ElectricityTariff = electricityTariff;
          this.x.MainHeating.MainEff = 100f;
          if (this.x.Water.SystemRef == 901)
            this.x.Water.SystemRef = 902;
          if (this.x.IncludeMainHeating2)
            this.x.HeatFractionSec = (float) surveyClass.Age.MHeatHabRooms / (float) surveyClass.Age.MHabRooms;
          if (this.MainFlue && this.x.SecHeating.SAPTableCode != 633)
          {
            // ISSUE: variable of a reference type
            int& local1;
            // ISSUE: explicit reference operation
            int num1 = checked (^(local1 = ref this.x.Ventilation.FluesMain) - 1);
            local1 = num1;
            // ISSUE: variable of a reference type
            int& local2;
            // ISSUE: explicit reference operation
            int num2 = checked (^(local2 = ref this.x.Ventilation.Flues) - 1);
            local2 = num2;
          }
        }
      }
      else if (surveyClass.Age.MHabRooms > surveyClass.Age.MHeatHabRooms & this.x.SecHeating.SAPTableCode == 0)
      {
        this.Ext.IncSecondary = true;
        this.x.SecHeating.HGroup = "Room heaters";
        this.x.SecHeating.InforSource = "SAP Tables";
        this.x.SecHeating.Fuel = "Electricity";
        this.x.SecHeating.SAPTableCode = 693;
        this.x.SecHeating.SGroup = "Electric (direct acting) room heaters";
        this.x.SecHeating.SecEff = 100f;
        this.x.SecHeating.MHType = "Portable electric heaters";
      }
      else if (this.x.SecHeating.SAPTableCode == 0)
      {
        switch (this.x.MainHeating.SAPTableCode)
        {
          case 401:
          case 402:
          case 404:
          case 421:
            this.Ext.IncSecondary = true;
            this.x.SecHeating.HGroup = "Room heaters";
            this.x.SecHeating.InforSource = "SAP Tables";
            this.x.SecHeating.Fuel = "Electricity";
            this.x.SecHeating.SAPTableCode = 693;
            this.x.SecHeating.SGroup = "Electric (direct acting) room heaters";
            this.x.SecHeating.SecEff = 100f;
            this.x.SecHeating.MHType = "Portable electric heaters";
            break;
        }
      }
    }

    private void FGHRS(Survey_Class RdSAP)
    {
      Survey_Class surveyClass = RdSAP;
      if (surveyClass.MainHeating[0].HasFGHRS)
      {
        this.x.Water.FGHRS.Include = surveyClass.MainHeating[0].HasFGHRS;
        this.x.Water.FGHRS.IndexNo = this.SEDBUKFull(Conversions.ToString(surveyClass.MainHeating[0].FGHRSIndexNum));
        if (surveyClass.MainHeating[0].FGHRPVInclude)
        {
          this.x.Water.FGHRS.PV.Inlcude = true;
          this.x.Water.FGHRS.PV.PPower = (float) surveyClass.MainHeating[0].FGHRPVPeakPower;
          switch (surveyClass.MainHeating[0].FGHRPVPitch)
          {
            case 1:
              this.x.Water.FGHRS.PV.PTilt = "Horizontal";
              break;
            case 2:
              this.x.Water.FGHRS.PV.PTilt = "30°";
              break;
            case 3:
              this.x.Water.FGHRS.PV.PTilt = "45°";
              break;
            case 4:
              this.x.Water.FGHRS.PV.PTilt = "60°";
              break;
            case 5:
              this.x.Water.FGHRS.PV.PTilt = "Vertical";
              break;
          }
          switch (surveyClass.MainHeating[0].FGHRPVOrientation)
          {
            case 1:
              this.x.Water.FGHRS.PV.PCOrientation = "North";
              break;
            case 2:
              this.x.Water.FGHRS.PV.PCOrientation = "North East";
              break;
            case 3:
              this.x.Water.FGHRS.PV.PCOrientation = "East";
              break;
            case 4:
              this.x.Water.FGHRS.PV.PCOrientation = "South East";
              break;
            case 5:
              this.x.Water.FGHRS.PV.PCOrientation = "South";
              break;
            case 6:
              this.x.Water.FGHRS.PV.PCOrientation = "South West";
              break;
            case 7:
              this.x.Water.FGHRS.PV.PCOrientation = "West";
              break;
            case 8:
              this.x.Water.FGHRS.PV.PCOrientation = "North West";
              break;
          }
          switch (surveyClass.MainHeating[0].FGHRPVOvershading)
          {
            case 1:
              this.x.Water.FGHRS.PV.POvershading = "None or very little";
              break;
            case 2:
              this.x.Water.FGHRS.PV.POvershading = "Modest";
              break;
            case 3:
              this.x.Water.FGHRS.PV.POvershading = "Significant";
              break;
            case 4:
              this.x.Water.FGHRS.PV.POvershading = "Heavy";
              break;
          }
        }
      }
    }

    private void WWHRS(Survey_Class RdSAP)
    {
      Survey_Class surveyClass = RdSAP;
      if ((uint) surveyClass.WaterHeating.WWHRS.Present > 0U)
      {
        this.x.Water.WWHRS.Include = true;
        this.x.Water.WWHRS.TotalRooms = (float) surveyClass.WaterHeating.WWHRS.RoomsWithBathAndOrShower;
        this.x.Water.WWHRS.Systems = new SAP_Module.WWHRS_Systems[checked (((IEnumerable<Survey_Class.WaterHeating_Class.WWHRS_Class.System_Class>) surveyClass.WaterHeating.WWHRS.System).Count<Survey_Class.WaterHeating_Class.WWHRS_Class.System_Class>() - 1 + 1)];
        int num = checked (((IEnumerable<Survey_Class.WaterHeating_Class.WWHRS_Class.System_Class>) surveyClass.WaterHeating.WWHRS.System).Count<Survey_Class.WaterHeating_Class.WWHRS_Class.System_Class>() - 1);
        int index = 0;
        while (index <= num)
        {
          this.x.Water.WWHRS.Systems[index] = new SAP_Module.WWHRS_Systems();
          this.x.Water.WWHRS.Systems[index].SystemsRef = this.SEDBUKFull(Conversions.ToString(surveyClass.WaterHeating.WWHRS.System[index].IndexNum));
          this.x.Water.WWHRS.Systems[index].WithBath = surveyClass.WaterHeating.WWHRS.System[index].MixedShowerWithSystemWithBath;
          this.x.Water.WWHRS.Systems[index].WithNoBath = surveyClass.WaterHeating.WWHRS.System[index].MixedShowerWithSystemWithoutBath;
          checked { ++index; }
        }
      }
    }

    private void Water_Spec(Survey_Class RdSAP)
    {
      Survey_Class surveyClass = RdSAP;
      if (surveyClass.WaterHeating.Code == 902)
      {
        this.x.Water.System = "From secondary system";
        this.x.Water.SystemRef = 902;
      }
      else
      {
        this.x.Water.System = SAP_Module.Get_Enum_Desc(typeof (Enums.WaterCode), surveyClass.WaterHeating.Code);
        this.x.Water.SystemRef = surveyClass.WaterHeating.Code;
      }
      if (this.Ext.DoneHeatingSwap & this.x.Water.SystemRef == 901)
      {
        this.x.Water.System = "From secondary system";
        this.x.Water.SystemRef = 902;
      }
      switch (surveyClass.WaterHeating.CylinderSize)
      {
        case 1:
          this.x.Water.Cylinder.Volume = 0.0f;
          break;
        case 2:
          switch (this.x.Water.SystemRef)
          {
            case 901:
              int sapTableCode1 = this.x.MainHeating.SAPTableCode;
              this.x.Water.Cylinder.Volume = sapTableCode1 < 151 || sapTableCode1 > 161 ? (sapTableCode1 != 0 ? 110f : (!this.Ext.Solid ? 110f : 160f)) : 160f;
              break;
            case 902:
              int sapTableCode2 = this.x.MainHeating2.SAPTableCode;
              this.x.Water.Cylinder.Volume = sapTableCode2 < 151 || sapTableCode2 > 161 ? (sapTableCode2 != 0 ? 110f : (!this.Ext.Solid ? 110f : 160f)) : 160f;
              break;
            case 903:
              if (surveyClass.OtherDetails.MeterType == 1)
              {
                this.x.Water.Cylinder.Immersion = "Dual";
                this.x.Water.Cylinder.Volume = 210f;
                break;
              }
              this.x.Water.Cylinder.Immersion = "Single";
              this.x.Water.Cylinder.Volume = 110f;
              break;
            case 913:
            case 930:
            case 931:
              this.x.Water.Cylinder.Volume = 160f;
              break;
            default:
              this.x.Water.Cylinder.Volume = 110f;
              break;
          }
          string mage1 = this.Ext.Ages.MAge;
          // ISSUE: reference to a compiler-generated method
          switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(mage1))
          {
            case 3222007936:
              if (Operators.CompareString(mage1, "E", false) == 0)
                break;
              goto default;
            case 3238785555:
              if (Operators.CompareString(mage1, "D", false) == 0)
                break;
              goto default;
            case 3255563174:
              if (Operators.CompareString(mage1, "G", false) == 0)
                goto label_28;
              else
                goto default;
            case 3272340793:
              if (Operators.CompareString(mage1, "F", false) == 0)
                break;
              goto default;
            case 3289118412:
              if (Operators.CompareString(mage1, "A", false) == 0)
                break;
              goto default;
            case 3322673650:
              if (Operators.CompareString(mage1, "C", false) == 0)
                break;
              goto default;
            case 3339451269:
              if (Operators.CompareString(mage1, "B", false) == 0)
                break;
              goto default;
            case 3423339364:
              if (Operators.CompareString(mage1, "I", false) == 0)
                goto label_29;
              else
                goto default;
            case 3440116983:
              if (Operators.CompareString(mage1, "H", false) == 0)
                goto label_28;
              else
                goto default;
            case 3456894602:
              if (Operators.CompareString(mage1, "K", false) == 0)
                goto label_29;
              else
                goto default;
            case 3473672221:
              if (Operators.CompareString(mage1, "J", false) == 0)
                goto label_29;
              else
                goto default;
            default:
label_30:
              this.x.Water.Cylinder.Thermostat = false;
              goto label_65;
          }
          this.x.Water.Cylinder.Insulation = "Jacket";
          this.x.Water.Cylinder.InsThick = 12f;
          goto label_30;
label_28:
          this.x.Water.Cylinder.Insulation = "Factory";
          this.x.Water.Cylinder.InsThick = 25f;
          goto label_30;
label_29:
          this.x.Water.Cylinder.Insulation = "Factory";
          this.x.Water.Cylinder.InsThick = 38f;
          goto label_30;
        case 3:
          this.x.Water.Cylinder.Volume = 110f;
          switch (surveyClass.WaterHeating.CylinderInsulationType)
          {
            case 1:
              this.x.Water.Cylinder.Insulation = "Jacket";
              break;
            case 2:
              this.x.Water.Cylinder.Insulation = "Factory";
              break;
            case 3:
              this.x.Water.Cylinder.Insulation = "Jacket";
              break;
          }
          switch (surveyClass.WaterHeating.CylinderInsulationThickness)
          {
            case 1:
              this.x.Water.Cylinder.InsThick = 12f;
              break;
            case 2:
              this.x.Water.Cylinder.InsThick = 25f;
              break;
            case 3:
              this.x.Water.Cylinder.InsThick = 38f;
              break;
            case 4:
              this.x.Water.Cylinder.InsThick = 50f;
              break;
            case 5:
              this.x.Water.Cylinder.InsThick = 80f;
              break;
            case 6:
              this.x.Water.Cylinder.InsThick = 120f;
              break;
            case 7:
              this.x.Water.Cylinder.InsThick = 160f;
              break;
          }
          break;
        case 4:
          this.x.Water.Cylinder.Volume = 160f;
          switch (surveyClass.WaterHeating.CylinderInsulationType)
          {
            case 2:
              this.x.Water.Cylinder.Insulation = "Factory";
              break;
            case 3:
              this.x.Water.Cylinder.Insulation = "Jacket";
              break;
          }
          switch (surveyClass.WaterHeating.CylinderInsulationThickness)
          {
            case 1:
              this.x.Water.Cylinder.InsThick = 12f;
              break;
            case 2:
              this.x.Water.Cylinder.InsThick = 25f;
              break;
            case 3:
              this.x.Water.Cylinder.InsThick = 38f;
              break;
            case 4:
              this.x.Water.Cylinder.InsThick = 50f;
              break;
            case 5:
              this.x.Water.Cylinder.InsThick = 80f;
              break;
            case 6:
              this.x.Water.Cylinder.InsThick = 120f;
              break;
            case 7:
              this.x.Water.Cylinder.InsThick = 160f;
              break;
          }
          break;
        case 5:
          this.x.Water.Cylinder.Volume = 210f;
          switch (surveyClass.WaterHeating.CylinderInsulationType)
          {
            case 2:
              this.x.Water.Cylinder.Insulation = "Factory";
              break;
            case 3:
              this.x.Water.Cylinder.Insulation = "Jacket";
              break;
          }
          switch (surveyClass.WaterHeating.CylinderInsulationThickness)
          {
            case 1:
              this.x.Water.Cylinder.InsThick = 12f;
              break;
            case 2:
              this.x.Water.Cylinder.InsThick = 25f;
              break;
            case 3:
              this.x.Water.Cylinder.InsThick = 38f;
              break;
            case 4:
              this.x.Water.Cylinder.InsThick = 50f;
              break;
            case 5:
              this.x.Water.Cylinder.InsThick = 80f;
              break;
            case 6:
              this.x.Water.Cylinder.InsThick = 120f;
              break;
            case 7:
              this.x.Water.Cylinder.InsThick = 160f;
              break;
          }
          break;
      }
label_65:
      this.x.Water.Cylinder.Thermostat = surveyClass.WaterHeating.CylinderThermostat;
      int systemRef1 = this.x.Water.SystemRef;
      if (systemRef1 == 901)
      {
        this.x.Water.Fuel = this.x.MainHeating.Fuel;
        int sapTableCode3 = this.x.MainHeating.SAPTableCode;
        switch (sapTableCode3)
        {
          case 191:
            this.x.Water.Cylinder.Immersion = "Dual";
            if (Operators.CompareString(this.x.Water.Cylinder.Immersion, "", false) == 0)
              this.x.Water.Cylinder.Immersion = "Dual";
            this.x.Water.Cylinder.Thermostat = true;
            break;
          case 192:
            this.x.Water.Cylinder.Volume = 300f;
            this.x.Water.Cylinder.ManuSpecified = true;
            this.x.Water.Cylinder.DeclaredLoss = 3.16f;
            this.x.Water.CPSUTemp = 90f;
            this.x.Water.Cylinder.InHeatedSpace = true;
            this.x.Water.Cylinder.PipeWorkInsulated = true;
            this.x.Water.Cylinder.Thermostat = true;
            this.x.Water.Cylinder.Timed = true;
            this.x.Water.Thermal.Location = "In an airing cupboard";
            break;
          default:
            if (sapTableCode3 >= 120 && sapTableCode3 <= 123)
            {
              this.x.Water.Cylinder.Volume = 80f;
              this.x.Water.Cylinder.ManuSpecified = true;
              this.x.Water.Cylinder.DeclaredLoss = 2.72f;
              this.x.Water.CPSUTemp = 90f;
              this.x.Water.Cylinder.InHeatedSpace = true;
              this.x.Water.Cylinder.PipeWorkInsulated = true;
              this.x.Water.Cylinder.Thermostat = true;
              this.x.Water.Cylinder.Timed = true;
              this.x.Water.Thermal.Location = "In an airing cupboard";
              break;
            }
            if (sapTableCode3 == 0 && Operators.CompareString(this.x.MainHeating.InforSource, "Boiler Database", false) == 0 && Operators.CompareString(this.x.MainHeating.SGroup, "Gas boilers and oil boilers", false) == 0 && Operators.CompareString(Calc2012.SEDBUK(this.x.MainHeating.SEDBUK).MainType, "3", false) == 0)
            {
              this.Ext.IsCPSU = true;
              break;
            }
            break;
        }
        int sapTableCode4 = this.x.MainHeating.SAPTableCode;
        if (sapTableCode4 >= 156 && sapTableCode4 <= 158 || sapTableCode4 >= 631 && sapTableCode4 <= 636)
        {
          this.x.Water.Cylinder.SummerImmersion = true;
          this.x.Water.Cylinder.Immersion = "Single";
        }
        else if (sapTableCode4 < 201 || sapTableCode4 > 204)
        {
          int sapTableCode5 = this.x.MainHeating.SAPTableCode;
          if (sapTableCode5 != 191 && (sapTableCode5 < 193 || sapTableCode5 > 196))
            ;
        }
      }
      else if (systemRef1 == 914)
      {
        this.x.Water.Fuel = this.x.MainHeating2.Fuel;
        int sapTableCode6 = this.x.MainHeating2.SAPTableCode;
        switch (sapTableCode6)
        {
          case 191:
            this.x.Water.Cylinder.Immersion = SAP_Module.Get_Enum_Desc(typeof (Enums.WaterImmersionHeatingType), surveyClass.WaterHeating.ImmersionHeatingType);
            this.x.Water.Cylinder.Thermostat = true;
            break;
          case 192:
            this.x.Water.Cylinder.Volume = 300f;
            this.x.Water.Cylinder.ManuSpecified = true;
            this.x.Water.Cylinder.DeclaredLoss = 3.16f;
            this.x.Water.CPSUTemp = 90f;
            this.x.Water.Cylinder.InHeatedSpace = true;
            this.x.Water.Cylinder.PipeWorkInsulated = true;
            this.x.Water.Cylinder.Thermostat = true;
            this.x.Water.Cylinder.Timed = true;
            this.x.Water.Thermal.Location = "In an airing cupboard";
            break;
          default:
            if (sapTableCode6 >= 120 && sapTableCode6 <= 123)
            {
              this.x.Water.Cylinder.Volume = 80f;
              this.x.Water.Cylinder.ManuSpecified = true;
              this.x.Water.Cylinder.DeclaredLoss = 2.72f;
              this.x.Water.CPSUTemp = 90f;
              this.x.Water.Cylinder.InHeatedSpace = true;
              this.x.Water.Cylinder.PipeWorkInsulated = true;
              this.x.Water.Cylinder.Thermostat = true;
              this.x.Water.Cylinder.Timed = true;
              this.x.Water.Thermal.Location = "In an airing cupboard";
              break;
            }
            if (sapTableCode6 == 0 && Operators.CompareString(this.x.MainHeating2.InforSource, "Boiler Database", false) == 0 && Operators.CompareString(this.x.MainHeating2.SGroup, "Gas boilers and oil boilers", false) == 0 && Operators.CompareString(Calc2012.SEDBUK(this.x.MainHeating2.SEDBUK).MainType, "3", false) == 0)
            {
              this.Ext.IsCPSU = true;
              break;
            }
            break;
        }
        int sapTableCode7 = this.x.MainHeating2.SAPTableCode;
        if (sapTableCode7 >= 156 && sapTableCode7 <= 158 || sapTableCode7 >= 631 && sapTableCode7 <= 636)
        {
          this.x.Water.Cylinder.SummerImmersion = true;
          this.x.Water.Cylinder.Immersion = "Single";
        }
        else if (sapTableCode7 >= 201 && sapTableCode7 <= 204)
        {
          this.x.Water.Cylinder.HPImmersion = "Yes";
        }
        else
        {
          int sapTableCode8 = this.x.MainHeating.SAPTableCode;
          if (sapTableCode8 != 191 && (sapTableCode8 < 193 || sapTableCode8 > 196))
            ;
        }
      }
      else if (systemRef1 == 902)
      {
        this.x.Water.Fuel = this.x.SecHeating.Fuel;
        int sapTableCode9 = this.x.SecHeating.SAPTableCode;
        if (sapTableCode9 >= 631 && sapTableCode9 <= 636)
        {
          this.x.Water.Cylinder.SummerImmersion = true;
          this.x.Water.Cylinder.Immersion = "Single";
        }
        else
        {
          int sapTableCode10 = this.x.MainHeating.SAPTableCode;
          if (sapTableCode10 != 191 && (sapTableCode10 < 193 || sapTableCode10 > 196))
            ;
        }
      }
      else if (systemRef1 == 903)
      {
        this.x.Water.Fuel = "Electricity";
        this.x.Water.Cylinder.Thermostat = true;
        if (surveyClass.WaterHeating.CylinderSize != 2)
          this.x.Water.Cylinder.Immersion = SAP_Module.Get_Enum_Desc(typeof (Enums.WaterImmersionHeatingType), surveyClass.WaterHeating.ImmersionHeatingType);
      }
      else if (systemRef1 == 901)
        this.x.Water.Fuel = "Electricity";
      else if (systemRef1 == 907)
        this.x.Water.Fuel = "mains gas";
      else if (systemRef1 == 908)
        this.x.Water.Fuel = "mains gas";
      else if (systemRef1 == 909)
        this.x.Water.Fuel = "Electricity";
      else if (systemRef1 >= 911 && systemRef1 <= 952)
        this.x.Water.Fuel = this.Fuel((Enums.HeatingFuelType) surveyClass.WaterHeating.Fuel);
      else if (systemRef1 == 999)
      {
        this.x.Water.Fuel = "Electricity";
        if (surveyClass.OtherDetails.MeterType == 1)
        {
          this.x.Water.Cylinder.Immersion = "Dual";
          this.x.Water.Cylinder.Volume = 210f;
        }
        else
        {
          this.x.Water.Cylinder.Immersion = "Single";
          this.x.Water.Cylinder.Volume = 110f;
        }
        string mage2 = this.Ext.Ages.MAge;
        // ISSUE: reference to a compiler-generated method
        switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(mage2))
        {
          case 3222007936:
            if (Operators.CompareString(mage2, "E", false) == 0)
              break;
            goto default;
          case 3238785555:
            if (Operators.CompareString(mage2, "D", false) == 0)
              break;
            goto default;
          case 3255563174:
            if (Operators.CompareString(mage2, "G", false) == 0)
              goto label_129;
            else
              goto default;
          case 3272340793:
            if (Operators.CompareString(mage2, "F", false) == 0)
              break;
            goto default;
          case 3289118412:
            if (Operators.CompareString(mage2, "A", false) == 0)
              break;
            goto default;
          case 3322673650:
            if (Operators.CompareString(mage2, "C", false) == 0)
              break;
            goto default;
          case 3339451269:
            if (Operators.CompareString(mage2, "B", false) == 0)
              break;
            goto default;
          case 3423339364:
            if (Operators.CompareString(mage2, "I", false) == 0)
              goto label_130;
            else
              goto default;
          case 3440116983:
            if (Operators.CompareString(mage2, "H", false) == 0)
              goto label_129;
            else
              goto default;
          case 3456894602:
            if (Operators.CompareString(mage2, "K", false) == 0)
              goto label_130;
            else
              goto default;
          case 3473672221:
            if (Operators.CompareString(mage2, "J", false) == 0)
              goto label_130;
            else
              goto default;
          default:
label_131:
            this.x.Water.Cylinder.Thermostat = false;
            this.x.Water.Cylinder.InHeatedSpace = true;
            goto label_132;
        }
        this.x.Water.Cylinder.Insulation = "Jacket";
        this.x.Water.Cylinder.InsThick = 12f;
        goto label_131;
label_129:
        this.x.Water.Cylinder.Insulation = "Factory";
        this.x.Water.Cylinder.InsThick = 25f;
        goto label_131;
label_130:
        this.x.Water.Cylinder.Insulation = "Factory";
        this.x.Water.Cylinder.InsThick = 38f;
        goto label_131;
      }
label_132:
      switch (this.x.Water.SystemRef)
      {
        case 950:
          this.x.Water.HWSComm.HDS = "Piping<=1990, pre-insulated, low temp, full flow";
          this.x.Water.HWSComm.Efficiency = 80f;
          this.x.Water.HWSComm.Boiler1Fraction = 1f;
          this.x.Water.HWSComm.NoOfAdditionalHeatSources = 0;
          this.x.Water.HWSComm.Charging = "Flat Rate Charging";
          break;
        case 951:
          this.x.Water.HWSComm.CHPRatio = 2f;
          this.x.Water.HWSComm.HDS = "Piping<=1990, pre-insulated, low temp, full flow";
          this.x.Water.HWSComm.Efficiency = 75f;
          this.x.Water.HWSComm.Boiler1Fraction = 1f;
          this.x.Water.HWSComm.NoOfAdditionalHeatSources = 0;
          this.x.Water.HWSComm.Charging = "Flat Rate Charging";
          break;
        case 952:
          this.x.Water.HWSComm.HDS = "Piping<=1990, pre-insulated, low temp, full flow";
          this.x.Water.HWSComm.Efficiency = 300f;
          this.x.Water.HWSComm.Boiler1Fraction = 1f;
          this.x.Water.HWSComm.NoOfAdditionalHeatSources = 0;
          this.x.Water.HWSComm.Charging = "Flat Rate Charging";
          break;
      }
      if (surveyClass.WaterHeating.CylinderSize != 1)
      {
        this.x.Water.Cylinder.InHeatedSpace = true;
        string mage3 = this.Ext.Ages.MAge;
        // ISSUE: reference to a compiler-generated method
        switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(mage3))
        {
          case 3222007936:
            if (Operators.CompareString(mage3, "E", false) == 0)
              break;
            goto default;
          case 3238785555:
            if (Operators.CompareString(mage3, "D", false) == 0)
              break;
            goto default;
          case 3255563174:
            if (Operators.CompareString(mage3, "G", false) == 0)
              break;
            goto default;
          case 3272340793:
            if (Operators.CompareString(mage3, "F", false) == 0)
              break;
            goto default;
          case 3289118412:
            if (Operators.CompareString(mage3, "A", false) == 0)
              break;
            goto default;
          case 3322673650:
            if (Operators.CompareString(mage3, "C", false) == 0)
              break;
            goto default;
          case 3339451269:
            if (Operators.CompareString(mage3, "B", false) == 0)
              break;
            goto default;
          case 3423339364:
            if (Operators.CompareString(mage3, "I", false) == 0)
              break;
            goto default;
          case 3440116983:
            if (Operators.CompareString(mage3, "H", false) == 0)
              break;
            goto default;
          case 3456894602:
            if (Operators.CompareString(mage3, "K", false) == 0)
            {
              this.x.Water.Cylinder.PipeWorkInsulated = true;
              goto default;
            }
            else
              goto default;
          case 3473672221:
            if (Operators.CompareString(mage3, "J", false) == 0)
              break;
            goto default;
          default:
label_151:
            string mage4 = this.Ext.Ages.MAge;
            // ISSUE: reference to a compiler-generated method
            switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(mage4))
            {
              case 3222007936:
                if (Operators.CompareString(mage4, "E", false) == 0)
                  break;
                goto label_165;
              case 3238785555:
                if (Operators.CompareString(mage4, "D", false) == 0)
                  break;
                goto label_165;
              case 3255563174:
                if (Operators.CompareString(mage4, "G", false) == 0)
                  break;
                goto label_165;
              case 3272340793:
                if (Operators.CompareString(mage4, "F", false) == 0)
                  break;
                goto label_165;
              case 3289118412:
                if (Operators.CompareString(mage4, "A", false) == 0)
                  break;
                goto label_165;
              case 3322673650:
                if (Operators.CompareString(mage4, "C", false) == 0)
                  break;
                goto label_165;
              case 3339451269:
                if (Operators.CompareString(mage4, "B", false) == 0)
                  break;
                goto label_165;
              case 3423339364:
                if (Operators.CompareString(mage4, "I", false) == 0)
                  break;
                goto label_165;
              case 3440116983:
                if (Operators.CompareString(mage4, "H", false) == 0)
                  break;
                goto label_165;
              case 3456894602:
                if (Operators.CompareString(mage4, "K", false) == 0)
                  goto label_164;
                else
                  goto label_165;
              case 3473672221:
                if (Operators.CompareString(mage4, "J", false) == 0)
                  goto label_164;
                else
                  goto label_165;
              default:
                goto label_165;
            }
            this.x.Water.Cylinder.Timed = false;
            goto label_165;
label_164:
            this.x.Water.Cylinder.Timed = true;
            goto label_165;
        }
        this.x.Water.Cylinder.PipeWorkInsulated = false;
        goto label_151;
      }
label_165:
      if (this.x.MainHeating.SAPTableCode > 300 & this.x.MainHeating.SAPTableCode < 310 & this.x.Water.SystemRef == 901 && (double) this.x.Water.Cylinder.Volume > 0.0)
        this.x.Water.HWSComm.CylinderInDwelling = true;
      if (this.x.Water.SystemRef > 949 && (double) this.x.Water.Cylinder.Volume > 0.0)
        this.x.Water.HWSComm.CylinderInDwelling = true;
      if (surveyClass.WaterHeating.SolarWater.Present)
      {
        this.x.Water.Solar.Inlcude = true;
        bool flag1;
        if (surveyClass.WaterHeating.SolarWater.Details)
        {
          this.x.Water.Solar.SolarType = SAP_Module.Get_Enum_Desc(typeof (Enums.SolarCollectorType), surveyClass.WaterHeating.SolarWater.CollectorType);
          switch (surveyClass.WaterHeating.SolarWater.CollectorType)
          {
            case 1:
              this.x.Water.Solar.SolarType = "Unglazed";
              this.x.Water.Solar.SolarZero = 0.9f;
              this.x.Water.Solar.SolarHLoss = 20f;
              break;
            case 2:
              this.x.Water.Solar.SolarType = "Flat plate, glazed";
              this.x.Water.Solar.SolarZero = 0.75f;
              this.x.Water.Solar.SolarHLoss = 6f;
              break;
            case 3:
              this.x.Water.Solar.SolarType = "Evacuated tube";
              this.x.Water.Solar.SolarZero = 0.6f;
              this.x.Water.Solar.SolarHLoss = 3f;
              break;
          }
          this.x.Water.Solar.SolarZero = (float) surveyClass.WaterHeating.SolarWater.Efficiency;
          this.x.Water.Solar.SolarHLoss = (float) surveyClass.WaterHeating.SolarWater.HeatLoss;
          this.x.Water.Solar.SolarArea = (float) surveyClass.WaterHeating.SolarWater.ApertureArea;
          switch (surveyClass.WaterHeating.SolarWater.Pitch)
          {
            case 1:
              this.x.Water.Solar.SolarTilt = "Horizontal";
              break;
            case 2:
              this.x.Water.Solar.SolarTilt = "30°";
              break;
            case 3:
              this.x.Water.Solar.SolarTilt = "45°";
              break;
            case 4:
              this.x.Water.Solar.SolarTilt = "60°";
              break;
            case 5:
              this.x.Water.Solar.SolarTilt = "Vertical";
              break;
          }
          switch (surveyClass.WaterHeating.SolarWater.Orientation)
          {
            case 1:
              this.x.Water.Solar.SolarOrientation = "North";
              break;
            case 2:
            case 8:
              this.x.Water.Solar.SolarOrientation = "NE/NW";
              break;
            case 3:
            case 7:
              this.x.Water.Solar.SolarOrientation = "E/W";
              break;
            case 4:
            case 6:
              this.x.Water.Solar.SolarOrientation = "SE/SW";
              break;
            case 5:
              this.x.Water.Solar.SolarOrientation = "South";
              break;
          }
          switch (surveyClass.WaterHeating.SolarWater.Overshading)
          {
            case 1:
              this.x.Water.Solar.SolarOvershading = "None or Very Little (<20%)";
              break;
            case 2:
              this.x.Water.Solar.SolarOvershading = "Modest (20% - 60%)";
              break;
            case 3:
              this.x.Water.Solar.SolarOvershading = "Significant (>60% - 80%)";
              break;
            case 4:
              this.x.Water.Solar.SolarOvershading = "Heavy (>80%)";
              break;
          }
          if (surveyClass.WaterHeating.SolarWater.StoreDetailsKnown)
          {
            this.x.Water.Solar.SolarSeperate = !surveyClass.WaterHeating.SolarWater.Combined;
            this.x.Water.Solar.SolarVolume = (float) surveyClass.WaterHeating.SolarWater.StoreVolume;
          }
          else
            flag1 = true;
          switch (surveyClass.WaterHeating.SolarWater.WaterPump)
          {
            case 1:
            case 2:
              this.x.Water.Solar.Pumped = false;
              break;
            case 3:
              this.x.Water.Solar.Pumped = true;
              break;
          }
        }
        else
        {
          flag1 = true;
          this.x.Water.Solar.Gross = false;
          this.x.Water.Solar.SolarArea = 3f;
          this.x.Water.Solar.SolarZero = 0.8f;
          this.x.Water.Solar.SolarHLoss = 4f;
          this.x.Water.Solar.SolarOrientation = "South";
          this.x.Water.Solar.SolarTilt = "30°";
          this.x.Water.Solar.SolarOvershading = "Modest (20% - 60%)";
          this.x.Water.Solar.Pumped = false;
        }
        if (flag1)
        {
          int systemRef2 = this.x.Water.SystemRef;
          bool flag2;
          if (systemRef2 == 901)
          {
            if (Operators.CompareString(this.x.MainHeating.InforSource, "Boiler Database", false) == 0)
            {
              if (Operators.CompareString(this.x.MainHeating.SGroup, "Gas boilers and oil boilers", false) == 0)
              {
                string mainType = Calc2012.SEDBUK(this.x.MainHeating.SEDBUK).MainType;
                flag2 = Operators.CompareString(mainType, "2", false) == 0 || Operators.CompareString(mainType, "3", false) == 0;
              }
              else
                flag2 = Operators.CompareString(this.x.MainHeating.SGroup, "Micro-cogeneration (micro-CHP)", false) != 0 ? Operators.CompareString(this.x.MainHeating.SGroup, "Solid fuel boilers", false) != 0 && Operators.CompareString(this.x.MainHeating.SGroup, "Heat pumps", false) == 0 : !this.x.Water.Cylinder.PipeWorkInsulated;
            }
            else if (Operators.CompareString(this.x.MainHeating.SGroup, "Heat pumps", false) == 0)
            {
              flag2 = true;
            }
            else
            {
              int sapTableCode11 = this.x.MainHeating.SAPTableCode;
              int num;
              switch (sapTableCode11)
              {
                case 103:
                case 104:
                case 107:
                case 108:
                case 112:
                case 113:
                case 118:
                case 120:
                case 121:
                case 122:
                case 123:
                case 128:
                case 129:
                case 130:
                  num = 1;
                  break;
                default:
                  num = sapTableCode11 == 192 ? 1 : 0;
                  break;
              }
              flag2 = num != 0 || sapTableCode11 >= 301 && sapTableCode11 <= 305 && !this.x.Water.HWSComm.CylinderInDwelling;
            }
          }
          else if (systemRef2 == 902 || systemRef2 == 903 || systemRef2 == 904 || systemRef2 == 905 || systemRef2 == 906 || systemRef2 == 911 || systemRef2 == 912 || systemRef2 == 913 || systemRef2 >= 921 && systemRef2 <= 931)
            flag2 = false;
          else if (systemRef2 == 907 || systemRef2 == 908 || systemRef2 == 909)
            flag2 = true;
          else if (systemRef2 == 950 || systemRef2 == 951 || systemRef2 == 952)
            flag2 = !this.x.Water.HWSComm.CylinderInDwelling;
          if (flag2)
          {
            this.x.Water.Solar.SolarVolume = 75f;
            this.x.Water.Solar.SolarSeperate = true;
          }
          else
          {
            this.x.Water.Solar.SolarSeperate = false;
            this.x.Water.Solar.SolarVolume = (float) Math.Round((double) this.x.Water.Cylinder.Volume / 3.0);
          }
        }
      }
    }

    private void PhotoVoltaic_Spec(Survey_Class RdSAP)
    {
      Survey_Class surveyClass = RdSAP;
      if (surveyClass.Renewable.PhotovoltaicSupplyPresent)
      {
        this.x.Renewable.Photovoltaic.Inlcude = true;
        if (surveyClass.Renewable.PVDetails)
        {
          this.x.Renewable.Photovoltaic.Photovoltaics = new SAP_Module.PhotoVoltaics[0];
          Survey_Class.Renewable_Class.PVArray_Class[] pvArray = surveyClass.Renewable.PVArray;
          int index = 0;
          while (index < pvArray.Length)
          {
            Survey_Class.Renewable_Class.PVArray_Class pvArrayClass = pvArray[index];
            if (pvArrayClass.Present)
            {
              // ISSUE: variable of a reference type
              SAP_Module.PhotoVoltaics[]& local;
              // ISSUE: explicit reference operation
              SAP_Module.PhotoVoltaics[] photoVoltaicsArray = (SAP_Module.PhotoVoltaics[]) Utils.CopyArray((Array) ^(local = ref this.x.Renewable.Photovoltaic.Photovoltaics), (Array) new SAP_Module.PhotoVoltaics[checked (this.x.Renewable.Photovoltaic.Photovoltaics.Length + 1)]);
              local = photoVoltaicsArray;
              this.x.Renewable.Photovoltaic.Photovoltaics[checked (this.x.Renewable.Photovoltaic.Photovoltaics.Length - 1)] = new SAP_Module.PhotoVoltaics();
              this.x.Renewable.Photovoltaic.Photovoltaics[checked (this.x.Renewable.Photovoltaic.Photovoltaics.Length - 1)].PPower = (float) pvArrayClass.PeakPower;
              switch (pvArrayClass.Pitch)
              {
                case 1:
                  this.x.Renewable.Photovoltaic.Photovoltaics[checked (this.x.Renewable.Photovoltaic.Photovoltaics.Length - 1)].PTilt = "Horizontal";
                  break;
                case 2:
                  this.x.Renewable.Photovoltaic.Photovoltaics[checked (this.x.Renewable.Photovoltaic.Photovoltaics.Length - 1)].PTilt = "30°";
                  break;
                case 3:
                  this.x.Renewable.Photovoltaic.Photovoltaics[checked (this.x.Renewable.Photovoltaic.Photovoltaics.Length - 1)].PTilt = "45°";
                  break;
                case 4:
                  this.x.Renewable.Photovoltaic.Photovoltaics[checked (this.x.Renewable.Photovoltaic.Photovoltaics.Length - 1)].PTilt = "60°";
                  break;
                case 5:
                  this.x.Renewable.Photovoltaic.Photovoltaics[checked (this.x.Renewable.Photovoltaic.Photovoltaics.Length - 1)].PTilt = "Vertical";
                  break;
              }
              switch (pvArrayClass.Orientation)
              {
                case 1:
                  this.x.Renewable.Photovoltaic.Photovoltaics[checked (this.x.Renewable.Photovoltaic.Photovoltaics.Length - 1)].PCOrientation = "North";
                  break;
                case 2:
                  this.x.Renewable.Photovoltaic.Photovoltaics[checked (this.x.Renewable.Photovoltaic.Photovoltaics.Length - 1)].PCOrientation = "North East";
                  break;
                case 3:
                  this.x.Renewable.Photovoltaic.Photovoltaics[checked (this.x.Renewable.Photovoltaic.Photovoltaics.Length - 1)].PCOrientation = "East";
                  break;
                case 4:
                  this.x.Renewable.Photovoltaic.Photovoltaics[checked (this.x.Renewable.Photovoltaic.Photovoltaics.Length - 1)].PCOrientation = "South East";
                  break;
                case 5:
                  this.x.Renewable.Photovoltaic.Photovoltaics[checked (this.x.Renewable.Photovoltaic.Photovoltaics.Length - 1)].PCOrientation = "South";
                  break;
                case 6:
                  this.x.Renewable.Photovoltaic.Photovoltaics[checked (this.x.Renewable.Photovoltaic.Photovoltaics.Length - 1)].PCOrientation = "South West";
                  break;
                case 7:
                  this.x.Renewable.Photovoltaic.Photovoltaics[checked (this.x.Renewable.Photovoltaic.Photovoltaics.Length - 1)].PCOrientation = "West";
                  break;
                case 8:
                  this.x.Renewable.Photovoltaic.Photovoltaics[checked (this.x.Renewable.Photovoltaic.Photovoltaics.Length - 1)].PCOrientation = "North West";
                  break;
              }
              switch (pvArrayClass.Overshading)
              {
                case 1:
                  this.x.Renewable.Photovoltaic.Photovoltaics[checked (this.x.Renewable.Photovoltaic.Photovoltaics.Length - 1)].POvershading = "None or very little";
                  break;
                case 2:
                  this.x.Renewable.Photovoltaic.Photovoltaics[checked (this.x.Renewable.Photovoltaic.Photovoltaics.Length - 1)].POvershading = "Modest";
                  break;
                case 3:
                  this.x.Renewable.Photovoltaic.Photovoltaics[checked (this.x.Renewable.Photovoltaic.Photovoltaics.Length - 1)].POvershading = "Significant";
                  break;
                case 4:
                  this.x.Renewable.Photovoltaic.Photovoltaics[checked (this.x.Renewable.Photovoltaic.Photovoltaics.Length - 1)].POvershading = "Heavy";
                  break;
              }
            }
            checked { ++index; }
          }
        }
        else
        {
          float num1 = 0.0f;
          int index1 = 0;
          if (surveyClass.Extensions[0].RoofConstruction == 4 | surveyClass.Extensions[0].RoofConstruction == 5 | surveyClass.Extensions[0].RoofConstruction == 6)
            num1 = !this.Ext.MainRoof ? this.x.Roofs[0].Area / (float) Math.Cos(7.0 * Math.PI / 36.0) : (float) (((double) this.x.Roofs[0].Area + surveyClass.Extensions[0].RoofRoomFloor_Area) / Math.Cos(7.0 * Math.PI / 36.0));
          else if (surveyClass.Extensions[0].RoofConstruction == 3 | surveyClass.Extensions[0].RoofConstruction == 7)
            checked { --index1; }
          else
            num1 = !this.Ext.MainRoof ? this.x.Roofs[0].Area : this.x.Roofs[index1].Area + (float) surveyClass.Extensions[0].RoofRoomFloor_Area;
          if (this.Ext.Ext1)
          {
            checked { ++index1; }
            if (surveyClass.Extensions[0].RoofRoom)
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
            if (surveyClass.Extensions[1].RoofConstruction == 4 | surveyClass.Extensions[1].RoofConstruction == 5 | surveyClass.Extensions[1].RoofConstruction == 6)
            {
              if (this.Ext.Ext1Roof)
                num1 += (float) (((double) this.x.Roofs[index1].Area + surveyClass.Extensions[1].RoofRoomFloor_Area) / Math.Cos(7.0 * Math.PI / 36.0));
              else
                num1 += this.x.Roofs[index1].Area / (float) Math.Cos(7.0 * Math.PI / 36.0);
            }
            else if (surveyClass.Extensions[1].RoofConstruction == 3 | surveyClass.Extensions[1].RoofConstruction == 7)
              checked { --index1; }
            else if (this.Ext.Ext1Roof)
              num1 += this.x.Roofs[index1].Area + (float) surveyClass.Extensions[1].RoofRoomFloor_Area;
            else
              num1 += this.x.Roofs[index1].Area;
          }
          if (this.Ext.Ext2)
          {
            checked { ++index1; }
            if (surveyClass.Extensions[1].RoofRoom)
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
            if (surveyClass.Extensions[2].RoofConstruction == 4 | surveyClass.Extensions[2].RoofConstruction == 5 | surveyClass.Extensions[2].RoofConstruction == 6)
            {
              if (this.Ext.Ext2Roof)
                num1 += (float) (((double) this.x.Roofs[index1].Area + surveyClass.Extensions[2].RoofRoomFloor_Area) / Math.Cos(7.0 * Math.PI / 36.0));
              else
                num1 += this.x.Roofs[index1].Area / (float) Math.Cos(7.0 * Math.PI / 36.0);
            }
            else if (surveyClass.Extensions[2].RoofConstruction == 3 | surveyClass.Extensions[2].RoofConstruction == 7)
              checked { --index1; }
            else if (this.Ext.Ext2Roof)
              num1 += this.x.Roofs[index1].Area + (float) surveyClass.Extensions[2].RoofRoomFloor_Area;
            else
              num1 += this.x.Roofs[index1].Area;
          }
          if (this.Ext.Ext3)
          {
            checked { ++index1; }
            if (surveyClass.Extensions[2].RoofRoom)
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
            if (surveyClass.Extensions[3].RoofConstruction == 4 | surveyClass.Extensions[3].RoofConstruction == 5 | surveyClass.Extensions[3].RoofConstruction == 6)
            {
              if (this.Ext.Ext3Roof)
                num1 += (float) (((double) this.x.Roofs[index1].Area + surveyClass.Extensions[3].RoofRoomFloor_Area) / Math.Cos(7.0 * Math.PI / 36.0));
              else
                num1 += this.x.Roofs[index1].Area / (float) Math.Cos(7.0 * Math.PI / 36.0);
            }
            else if (surveyClass.Extensions[3].RoofConstruction == 3 | surveyClass.Extensions[3].RoofConstruction == 7)
              checked { --index1; }
            else if (this.Ext.Ext3Roof)
              num1 += this.x.Roofs[index1].Area + (float) surveyClass.Extensions[3].RoofRoomFloor_Area;
            else
              num1 += this.x.Roofs[index1].Area;
          }
          if (this.Ext.Ext4)
          {
            int index2 = checked (index1 + 1);
            if (surveyClass.Extensions[3].RoofRoom)
            {
              if (!surveyClass.Extensions[3].RoofRoom_Edit)
              {
                checked { ++index2; }
              }
              else
              {
                if (surveyClass.Extensions[3].RoofRoom_FlatCeiling[0].Area != 0.0)
                  checked { ++index2; }
                if (surveyClass.Extensions[3].RoofRoom_FlatCeiling[1].Area != 0.0)
                  checked { ++index2; }
                if (surveyClass.Extensions[3].RoofRoom_Slope[0].Area != 0.0)
                  checked { ++index2; }
                if (surveyClass.Extensions[3].RoofRoom_Slope[1].Area != 0.0)
                  checked { ++index2; }
              }
            }
            if (surveyClass.Extensions[4].RoofConstruction == 4 | surveyClass.Extensions[4].RoofConstruction == 5 | surveyClass.Extensions[4].RoofConstruction == 6)
            {
              if (this.Ext.Ext4Roof)
                num1 += (float) (((double) this.x.Roofs[index2].Area + surveyClass.Extensions[4].RoofRoomFloor_Area) / Math.Cos(7.0 * Math.PI / 36.0));
              else
                num1 += this.x.Roofs[index2].Area / (float) Math.Cos(7.0 * Math.PI / 36.0);
            }
            else if (surveyClass.Extensions[4].RoofConstruction == 3 | surveyClass.Extensions[4].RoofConstruction == 7)
            {
              int num2 = checked (index2 - 1);
            }
            else if (this.Ext.Ext4Roof)
              num1 += this.x.Roofs[index2].Area + (float) surveyClass.Extensions[4].RoofRoomFloor_Area;
            else
              num1 += this.x.Roofs[index2].Area;
          }
          this.x.Renewable.Photovoltaic.Photovoltaics = new SAP_Module.PhotoVoltaics[1];
          this.x.Renewable.Photovoltaic.Inlcude = true;
          this.x.Renewable.Photovoltaic.Photovoltaics[0] = new SAP_Module.PhotoVoltaics();
          this.x.Renewable.Photovoltaic.Photovoltaics[0].PPower = (float) Math.Round(0.12 * (double) num1 * surveyClass.Renewable.PVPercentRoofArea / 100.0, 2);
          this.x.Renewable.Photovoltaic.Photovoltaics[0].PTilt = "30°";
          this.x.Renewable.Photovoltaic.Photovoltaics[0].PCOrientation = "South";
          this.x.Renewable.Photovoltaic.Photovoltaics[0].POvershading = "Modest";
        }
      }
    }

    private void WindTurbine_Spec(Survey_Class RdSAP)
    {
      Survey_Class surveyClass = RdSAP;
      if (surveyClass.Renewable.WindTurbinePresent)
      {
        this.x.Renewable.WindTurbine.Inlcude = true;
        if (surveyClass.Renewable.WindTurbineDetails)
        {
          this.x.Renewable.WindTurbine.WNumber = surveyClass.Renewable.WindTurbinesCount;
          this.x.Renewable.WindTurbine.WHeight = Conversions.ToString(surveyClass.Renewable.WindTurbineHubHeight);
          this.x.Renewable.WindTurbine.WRDiameter = Conversions.ToString(surveyClass.Renewable.WindTurbineRotoDiameter);
        }
        else
        {
          this.x.Renewable.WindTurbine.WNumber = 1;
          this.x.Renewable.WindTurbine.WHeight = Conversions.ToString(2);
          this.x.Renewable.WindTurbine.WRDiameter = Conversions.ToString(2);
        }
      }
    }

    private string CheckJoists(Enums.RoofInsulationCode Val)
    {
      string str = "";
      switch (Val)
      {
        case Enums.RoofInsulationCode.Unknown:
          str = "0 mm";
          break;
        case Enums.RoofInsulationCode.Rafters:
          str = "12 mm";
          break;
        case Enums.RoofInsulationCode.Joists:
          str = "25 mm";
          break;
        case Enums.RoofInsulationCode.Flat_roof_insulation:
          str = "50 mm";
          break;
        case Enums.RoofInsulationCode.Unknown | Enums.RoofInsulationCode.Joists:
          str = "75 mm";
          break;
        case Enums.RoofInsulationCode.Rafters | Enums.RoofInsulationCode.Joists:
          str = "100 mm";
          break;
        case (Enums.RoofInsulationCode) 8:
          str = "150 mm";
          break;
        case (Enums.RoofInsulationCode) 9:
          str = "200 mm";
          break;
        case (Enums.RoofInsulationCode) 10:
          str = "250 mm";
          break;
        case (Enums.RoofInsulationCode) 11:
          str = "300+ mm";
          break;
      }
      return str;
    }

    [DataContract(Name = "Extension")]
    public class Extensions
    {
      public Extensions()
      {
        this.Ages = new RdSAP_TO_SAP.Ages();
        this.FloorType = new RdSAP_TO_SAP.FloorType();
        this.WallThickness = new RdSAP_TO_SAP.WallThickness();
        this.Exposed = new RdSAP_TO_SAP.ExposedFloor();
      }

      [DataMember]
      public bool MainRoof { get; set; }

      [DataMember]
      public bool Ext1 { get; set; }

      [DataMember]
      public bool Ext1Roof { get; set; }

      [DataMember]
      public bool Ext2 { get; set; }

      [DataMember]
      public bool Ext2Roof { get; set; }

      [DataMember]
      public bool Ext3 { get; set; }

      [DataMember]
      public bool Ext3Roof { get; set; }

      [DataMember]
      public bool Ext4 { get; set; }

      [DataMember]
      public bool Ext4Roof { get; set; }

      [DataMember]
      public bool IncFlatCorridor { get; set; }

      [DataMember]
      public bool Cons { get; set; }

      [DataMember]
      public bool AltWall { get; set; }

      [DataMember]
      public RdSAP_TO_SAP.Ages Ages { get; set; }

      [DataMember]
      public RdSAP_TO_SAP.FloorType FloorType { get; set; }

      [DataMember]
      public RdSAP_TO_SAP.WallThickness WallThickness { get; set; }

      [DataMember]
      public RdSAP_TO_SAP.ExposedFloor Exposed { get; set; }

      [DataMember]
      public int MStoreys { get; set; }

      [DataMember]
      public int E1Storeys { get; set; }

      [DataMember]
      public int E2Storeys { get; set; }

      [DataMember]
      public int E3Storeys { get; set; }

      [DataMember]
      public int E4Storeys { get; set; }

      [DataMember]
      public int MaxFloors { get; set; }

      [DataMember]
      public float MArea { get; set; }

      [DataMember]
      public float E1Area { get; set; }

      [DataMember]
      public float E2Area { get; set; }

      [DataMember]
      public float E3Area { get; set; }

      [DataMember]
      public float E4Area { get; set; }

      [DataMember]
      public RdSAP_TO_SAP.NetWallAreas[] NetAreas { get; set; }

      [DataMember]
      public bool Solid { get; set; }

      [DataMember]
      public bool IncSecondary { get; set; }

      [DataMember]
      public bool DoneHeatingSwap { get; set; }

      [DataMember]
      public bool IsCPSU { get; set; }

      [DataMember]
      public int NoofExt { get; set; }

      [DataMember]
      public int HabRooms { get; set; }

      [DataMember]
      public int HeatHabRooms { get; set; }

      [DataMember]
      public RdSAP_TO_SAP.EPCFloors[] EPCFloors { get; set; }

      [DataMember]
      public int GraphType { get; set; }
    }

    [DataContract(Name = "EPCFloors")]
    public class EPCFloors
    {
      public EPCFloors() => this.Desc = "";

      [DataMember]
      public string Desc { get; set; }

      [DataMember]
      public int Ext { get; set; }

      [DataMember]
      public float Area { get; set; }
    }

    [DataContract(Name = "Ages")]
    public class Ages
    {
      public Ages()
      {
        this.MAge = "";
        this.MRoofAge = "";
        this.E1Age = "";
        this.E1RoofAge = "";
        this.E2Age = "";
        this.E2RoofAge = "";
        this.E3Age = "";
        this.E3RoofAge = "";
        this.E4Age = "";
        this.E4RoofAge = "";
      }

      [DataMember]
      public string MAge { get; set; }

      [DataMember]
      public string MRoofAge { get; set; }

      [DataMember]
      public string E1Age { get; set; }

      [DataMember]
      public string E1RoofAge { get; set; }

      [DataMember]
      public string E2Age { get; set; }

      [DataMember]
      public string E2RoofAge { get; set; }

      [DataMember]
      public string E3Age { get; set; }

      [DataMember]
      public string E3RoofAge { get; set; }

      [DataMember]
      public string E4Age { get; set; }

      [DataMember]
      public string E4RoofAge { get; set; }
    }

    [DataContract(Name = "FloorType")]
    public class FloorType
    {
      public FloorType()
      {
        this.M = "";
        this.E1 = "";
        this.E2 = "";
        this.E3 = "";
        this.E4 = "";
      }

      [DataMember]
      public string M { get; set; }

      [DataMember]
      public string E1 { get; set; }

      [DataMember]
      public string E2 { get; set; }

      [DataMember]
      public string E3 { get; set; }

      [DataMember]
      public string E4 { get; set; }
    }

    [DataContract(Name = "WallThickness")]
    public class WallThickness
    {
      [DataMember]
      public double M { get; set; }

      [DataMember]
      public double E1 { get; set; }

      [DataMember]
      public double E2 { get; set; }

      [DataMember]
      public double E3 { get; set; }

      [DataMember]
      public double E4 { get; set; }
    }

    [DataContract(Name = "ExposedFloor")]
    public class ExposedFloor
    {
      [DataMember]
      public bool Include_M { get; set; }

      [DataMember]
      public bool Include_E1 { get; set; }

      [DataMember]
      public bool Include_E2 { get; set; }

      [DataMember]
      public bool Include_E3 { get; set; }

      [DataMember]
      public bool Include_E4 { get; set; }

      [DataMember]
      public double A1_M { get; set; }

      [DataMember]
      public double A1_E1 { get; set; }

      [DataMember]
      public double A1_E2 { get; set; }

      [DataMember]
      public double A1_E3 { get; set; }

      [DataMember]
      public double A1_E4 { get; set; }

      [DataMember]
      public double A2_M { get; set; }

      [DataMember]
      public double A2_E1 { get; set; }

      [DataMember]
      public double A2_E2 { get; set; }

      [DataMember]
      public double A2_E3 { get; set; }

      [DataMember]
      public double A2_E4 { get; set; }
    }

    [DataContract(Name = "NetWallAreas")]
    public class NetWallAreas
    {
      public NetWallAreas() => this.WallDesc = "";

      [DataMember]
      public float Area { get; set; }

      [DataMember]
      public string WallDesc { get; set; }
    }

    private enum LevelType
    {
      Ground = 1,
      Midfloor = 2,
      RoofRoom = 3,
    }

    private enum WallCalc
    {
      None,
      Granite_a,
      Granite_b,
      SandStone_a,
      SandStone_b,
    }
  }
}
