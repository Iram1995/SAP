
// Type: SAP2012.HQMXML




using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;

namespace SAP2012
{
  public class HQMXML
  {
    private XmlTextWriter XMLobj;
    private string MainBrand;
    private string MainBrand2;
    private string secMainBrand;
    private string secMainBrand2;
    private string HeatingHeading;
    private string HeatingHeadingwWALES2;
    private string HeatingHeadingwWALES;
    private double responsiveness;
    private double calHeatingVal;
    private double calHeatingValCO2;
    private double Eff;
    private string MyMainCode;
    private string MyMainCode2;
    private string XML_controlCode;
    private string XML_controlCode2;
    private double carbonEmm;
    private double carbonEmm2;
    private double Waterband;
    private double Waterband2;
    private string WaterBanding;
    private string WaterBanding2;
    private string XML_WaterBanding;
    private string XML_WaterBanding2;
    private string LowCarbonTex;
    private string MeasuredText;
    private string MeasuredTextLast;
    private string TextHeader;
    private string HotWaterDesc;
    private PCDF.SEDBUK SearchRow;
    private PCDF.HeatPump SearchRowHP;
    private PCDF.CHP SearchRowCHP;
    private PCDF.SEDBUK SearchBoilerRow;
    private PCDF.SEDBUK_Solid SearchSolidBoilerRow;
    private PCDF.Products321 Products321;
    private string[] PrintText;
    private string InitialText;
    private string AddressLineUse;
    private int count;
    private int G;
    private int LastCount;
    private double indicative;
    private bool combine_heat;
    private bool geothermal_heat;
    private bool ground_source;
    private bool exhaust_air;
    private string HeatingHeading2;
    private HQMXML.Opening[] OpeningTypes;
    private ValidationEventHandler schemaValidation;

    public HQMXML()
    {
      this.HeatingHeading = "";
      this.HeatingHeadingwWALES = "";
      this.MyMainCode = "";
      this.MyMainCode2 = "";
      this.PrintText = new string[23];
      this.combine_heat = false;
      this.geothermal_heat = false;
      this.ground_source = false;
      this.exhaust_air = false;
      this.schemaValidation = new ValidationEventHandler(this.ValidationHandler);
    }

    public int CheckRelatedParty(string Desc)
    {
      int integer;
      try
      {
        string str1 = Desc;
        string str2;
        // ISSUE: reference to a compiler-generated method
        switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(str1))
        {
          case 17217633:
            if (Operators.CompareString(str1, "Yn byw yn yr eiddo", false) == 0)
              goto label_18;
            else
              goto default;
          case 363948515:
            if (Operators.CompareString(str1, "Buddiant ariannol yn yr eiddo", false) == 0)
              goto label_19;
            else
              goto default;
          case 699887717:
            if (Operators.CompareString(str1, "Employed by the professional dealing with the property transaction", false) == 0)
              goto label_21;
            else
              goto default;
          case 714563493:
            if (Operators.CompareString(str1, "Perthynas i’r person proffesiynol sy’n delio â’r trafodyn eiddo", false) == 0)
              goto label_22;
            else
              goto default;
          case 906552670:
            if (Operators.CompareString(str1, "Relative of the professional dealing with the property transaction", false) == 0)
              goto label_22;
            else
              goto default;
          case 1423711376:
            if (Operators.CompareString(str1, "Wedi’i gyflogi gan y person proffesiynol sy’n delio â’r trafodyn eiddo", false) == 0)
              goto label_21;
            else
              goto default;
          case 2325797555:
            if (Operators.CompareString(str1, "Financial interest in the property", false) == 0)
              goto label_19;
            else
              goto default;
          case 2392311570:
            if (Operators.CompareString(str1, "Relative of homeowner or occupier of the property", false) == 0)
              goto label_17;
            else
              goto default;
          case 2457169943:
            if (Operators.CompareString(str1, "Residing at the property", false) == 0)
              goto label_18;
            else
              goto default;
          case 2648119767:
            if (Operators.CompareString(str1, "Perthynas i berchennog y cartref neu ddeiliad yr eiddo", false) == 0)
              goto label_17;
            else
              goto default;
          case 2851230164:
            if (Operators.CompareString(str1, "Perchennog neu Gyfarwyddwr y corff sy’n delio â’r trafodyn eiddo", false) == 0)
              goto label_20;
            else
              goto default;
          case 3056024431:
            if (Operators.CompareString(str1, "Dim parti perthnasol", false) == 0)
              break;
            goto default;
          case 3407112949:
            if (Operators.CompareString(str1, "No related party", false) == 0)
              break;
            goto default;
          case 3560267305:
            if (Operators.CompareString(str1, "Owner or Director of the organisation dealing with the property transaction", false) == 0)
              goto label_20;
            else
              goto default;
          default:
            str2 = Conversions.ToString(1);
            goto label_24;
        }
        str2 = Conversions.ToString(1);
        goto label_24;
label_17:
        str2 = Conversions.ToString(2);
        goto label_24;
label_18:
        str2 = Conversions.ToString(3);
        goto label_24;
label_19:
        str2 = Conversions.ToString(4);
        goto label_24;
label_20:
        str2 = Conversions.ToString(5);
        goto label_24;
label_21:
        str2 = Conversions.ToString(6);
        goto label_24;
label_22:
        str2 = Conversions.ToString(7);
label_24:
        integer = Conversions.ToInteger(str2);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) "There is a problem during Related Party Disclosure", MsgBoxStyle.Critical);
        ProjectData.ClearProjectError();
      }
      return integer;
    }

    public void DefineOpenings(int House)
    {
      this.OpeningTypes = new HQMXML.Opening[0];
      try
      {
        int num1 = checked (SAP_Module.Proj.Dwellings[House].NoofDoors - 1);
        int index1 = 0;
        while (index1 <= num1)
        {
          bool flag = false;
          if (index1 == 0)
          {
            // ISSUE: variable of a reference type
            HQMXML.Opening[]& local;
            // ISSUE: explicit reference operation
            HQMXML.Opening[] openingArray = (HQMXML.Opening[]) Utils.CopyArray((Array) ^(local = ref this.OpeningTypes), (Array) new HQMXML.Opening[checked (index1 + 1)]);
            local = openingArray;
            if (Operators.CompareString(SAP_Module.Proj.Dwellings[House].Doors[index1].GlazingType, (string) null, false) == 0)
              SAP_Module.Proj.Dwellings[House].Doors[index1].GlazingType = "";
            this.OpeningTypes[checked (this.OpeningTypes.Length - 1)].Name = "Door (" + Conversions.ToString(this.OpeningTypes.Length) + ")";
            SAP_Module.Proj.Dwellings[House].Doors[index1].OpeningType = this.OpeningTypes[checked (this.OpeningTypes.Length - 1)].Name;
            this.OpeningTypes[checked (this.OpeningTypes.Length - 1)].DSource = SAP_Module.Proj.Dwellings[House].Doors[index1].UValueSource;
            this.OpeningTypes[checked (this.OpeningTypes.Length - 1)].Type = SAP_Module.Proj.Dwellings[House].Doors[index1].DoorType;
            this.OpeningTypes[checked (this.OpeningTypes.Length - 1)].GlazingType = SAP_Module.Proj.Dwellings[House].Doors[index1].GlazingType;
            this.OpeningTypes[checked (this.OpeningTypes.Length - 1)].GlazingGap = SAP_Module.Proj.Dwellings[House].Doors[index1].AirGap;
            this.OpeningTypes[checked (this.OpeningTypes.Length - 1)].Argon = SAP_Module.Proj.Dwellings[House].Doors[index1].GlazingType.Contains("argon");
            this.OpeningTypes[checked (this.OpeningTypes.Length - 1)].FrameType = SAP_Module.Proj.Dwellings[House].Doors[index1].FrameType;
            this.OpeningTypes[checked (this.OpeningTypes.Length - 1)].MetalFrameType = SAP_Module.Proj.Dwellings[House].Doors[index1].ThermalBreak;
            this.OpeningTypes[checked (this.OpeningTypes.Length - 1)].U_Value = SAP_Module.Proj.Dwellings[House].Doors[index1].U;
          }
          else
          {
            int num2 = checked (this.OpeningTypes.Length - 1);
            int index2 = 0;
            while (index2 <= num2)
            {
              if (!((uint) Operators.CompareString(SAP_Module.Proj.Dwellings[House].Doors[index1].UValueSource, this.OpeningTypes[index2].DSource, false) > 0U | (uint) Operators.CompareString(SAP_Module.Proj.Dwellings[House].Doors[index1].DoorType, this.OpeningTypes[index2].Type, false) > 0U | (uint) Operators.CompareString(SAP_Module.Proj.Dwellings[House].Doors[index1].GlazingType, this.OpeningTypes[index2].GlazingType, false) > 0U | (uint) Operators.CompareString(SAP_Module.Proj.Dwellings[House].Doors[index1].AirGap, this.OpeningTypes[index2].GlazingGap, false) > 0U | SAP_Module.Proj.Dwellings[House].Doors[index1].GlazingType.Contains("argon") != this.OpeningTypes[index2].Argon | (uint) Operators.CompareString(SAP_Module.Proj.Dwellings[House].Doors[index1].FrameType, this.OpeningTypes[index2].FrameType, false) > 0U | (double) SAP_Module.Proj.Dwellings[House].Doors[index1].U != (double) this.OpeningTypes[index2].U_Value))
              {
                SAP_Module.Proj.Dwellings[House].Doors[index1].OpeningType = this.OpeningTypes[index2].Name;
                flag = true;
                break;
              }
              checked { ++index2; }
            }
            if (!flag)
            {
              // ISSUE: variable of a reference type
              HQMXML.Opening[]& local;
              // ISSUE: explicit reference operation
              HQMXML.Opening[] openingArray = (HQMXML.Opening[]) Utils.CopyArray((Array) ^(local = ref this.OpeningTypes), (Array) new HQMXML.Opening[checked (this.OpeningTypes.Length + 1)]);
              local = openingArray;
              this.OpeningTypes[checked (this.OpeningTypes.Length - 1)].Name = "Door (" + Conversions.ToString(this.OpeningTypes.Length) + ")";
              SAP_Module.Proj.Dwellings[House].Doors[index1].OpeningType = this.OpeningTypes[checked (this.OpeningTypes.Length - 1)].Name;
              this.OpeningTypes[checked (this.OpeningTypes.Length - 1)].DSource = SAP_Module.Proj.Dwellings[House].Doors[index1].UValueSource;
              this.OpeningTypes[checked (this.OpeningTypes.Length - 1)].Type = SAP_Module.Proj.Dwellings[House].Doors[index1].DoorType;
              this.OpeningTypes[checked (this.OpeningTypes.Length - 1)].GlazingType = SAP_Module.Proj.Dwellings[House].Doors[index1].GlazingType;
              this.OpeningTypes[checked (this.OpeningTypes.Length - 1)].GlazingGap = SAP_Module.Proj.Dwellings[House].Doors[index1].AirGap;
              this.OpeningTypes[checked (this.OpeningTypes.Length - 1)].Argon = SAP_Module.Proj.Dwellings[House].Doors[index1].GlazingType.Contains("argon");
              this.OpeningTypes[checked (this.OpeningTypes.Length - 1)].FrameType = SAP_Module.Proj.Dwellings[House].Doors[index1].FrameType;
              this.OpeningTypes[checked (this.OpeningTypes.Length - 1)].MetalFrameType = SAP_Module.Proj.Dwellings[House].Doors[index1].ThermalBreak;
              this.OpeningTypes[checked (this.OpeningTypes.Length - 1)].U_Value = SAP_Module.Proj.Dwellings[House].Doors[index1].U;
            }
          }
          checked { ++index1; }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      int num3 = 1;
      int length1 = this.OpeningTypes.Length;
      try
      {
        int num4 = checked (SAP_Module.Proj.Dwellings[House].NoofWindows - 1);
        int index3 = 0;
        while (index3 <= num4)
        {
          bool flag = false;
          if (index3 == 0)
          {
            // ISSUE: variable of a reference type
            HQMXML.Opening[]& local;
            // ISSUE: explicit reference operation
            HQMXML.Opening[] openingArray = (HQMXML.Opening[]) Utils.CopyArray((Array) ^(local = ref this.OpeningTypes), (Array) new HQMXML.Opening[checked (this.OpeningTypes.Length + 1)]);
            local = openingArray;
            this.OpeningTypes[checked (this.OpeningTypes.Length - 1)].Name = "Windows (" + Conversions.ToString(num3) + ")";
            SAP_Module.Proj.Dwellings[House].Windows[index3].OpeningType = this.OpeningTypes[checked (this.OpeningTypes.Length - 1)].Name;
            this.OpeningTypes[checked (this.OpeningTypes.Length - 1)].DSource = SAP_Module.Proj.Dwellings[House].Windows[index3].UValueSource;
            this.OpeningTypes[checked (this.OpeningTypes.Length - 1)].Type = Conversions.ToString(4);
            this.OpeningTypes[checked (this.OpeningTypes.Length - 1)].GlazingType = SAP_Module.Proj.Dwellings[House].Windows[index3].GlazingType;
            this.OpeningTypes[checked (this.OpeningTypes.Length - 1)].GlazingGap = SAP_Module.Proj.Dwellings[House].Windows[index3].AirGap;
            this.OpeningTypes[checked (this.OpeningTypes.Length - 1)].Argon = SAP_Module.Proj.Dwellings[House].Windows[index3].GlazingType.Contains("argon");
            this.OpeningTypes[checked (this.OpeningTypes.Length - 1)].FrameType = SAP_Module.Proj.Dwellings[House].Windows[index3].FrameType;
            this.OpeningTypes[checked (this.OpeningTypes.Length - 1)].MetalFrameType = SAP_Module.Proj.Dwellings[House].Windows[index3].ThermalBreak;
            this.OpeningTypes[checked (this.OpeningTypes.Length - 1)].SolarT = SAP_Module.Proj.Dwellings[House].Windows[index3].g;
            this.OpeningTypes[checked (this.OpeningTypes.Length - 1)].FrameFactor = SAP_Module.Proj.Dwellings[House].Windows[index3].FF;
            this.OpeningTypes[checked (this.OpeningTypes.Length - 1)].U_Value = SAP_Module.Proj.Dwellings[House].Windows[index3].U;
          }
          else
          {
            int num5 = length1;
            int num6 = checked (this.OpeningTypes.Length - 1);
            int index4 = num5;
            while (index4 <= num6)
            {
              if (!((uint) Operators.CompareString(SAP_Module.Proj.Dwellings[House].Windows[index3].UValueSource, this.OpeningTypes[index4].DSource, false) > 0U | (uint) Operators.CompareString(SAP_Module.Proj.Dwellings[House].Windows[index3].GlazingType, this.OpeningTypes[index4].GlazingType, false) > 0U | (uint) Operators.CompareString(SAP_Module.Proj.Dwellings[House].Windows[index3].AirGap, this.OpeningTypes[index4].GlazingGap, false) > 0U | SAP_Module.Proj.Dwellings[House].Windows[index3].GlazingType.Contains("argon") != this.OpeningTypes[index4].Argon | (uint) Operators.CompareString(SAP_Module.Proj.Dwellings[House].Windows[index3].FrameType, this.OpeningTypes[index4].FrameType, false) > 0U | (double) SAP_Module.Proj.Dwellings[House].Windows[index3].g != (double) this.OpeningTypes[index4].SolarT | (double) SAP_Module.Proj.Dwellings[House].Windows[index3].FF != (double) this.OpeningTypes[index4].FrameFactor | (double) SAP_Module.Proj.Dwellings[House].Windows[index3].U != (double) this.OpeningTypes[index4].U_Value))
              {
                SAP_Module.Proj.Dwellings[House].Windows[index3].OpeningType = this.OpeningTypes[index4].Name;
                flag = true;
                break;
              }
              checked { ++index4; }
            }
            if (!flag)
            {
              // ISSUE: variable of a reference type
              HQMXML.Opening[]& local;
              // ISSUE: explicit reference operation
              HQMXML.Opening[] openingArray = (HQMXML.Opening[]) Utils.CopyArray((Array) ^(local = ref this.OpeningTypes), (Array) new HQMXML.Opening[checked (this.OpeningTypes.Length + 1)]);
              local = openingArray;
              checked { ++num3; }
              this.OpeningTypes[checked (this.OpeningTypes.Length - 1)].Name = "Windows (" + Conversions.ToString(num3) + ")";
              SAP_Module.Proj.Dwellings[House].Windows[index3].OpeningType = this.OpeningTypes[checked (this.OpeningTypes.Length - 1)].Name;
              this.OpeningTypes[checked (this.OpeningTypes.Length - 1)].DSource = SAP_Module.Proj.Dwellings[House].Windows[index3].UValueSource;
              this.OpeningTypes[checked (this.OpeningTypes.Length - 1)].Type = Conversions.ToString(4);
              this.OpeningTypes[checked (this.OpeningTypes.Length - 1)].GlazingType = SAP_Module.Proj.Dwellings[House].Windows[index3].GlazingType;
              this.OpeningTypes[checked (this.OpeningTypes.Length - 1)].GlazingGap = SAP_Module.Proj.Dwellings[House].Windows[index3].AirGap;
              this.OpeningTypes[checked (this.OpeningTypes.Length - 1)].Argon = SAP_Module.Proj.Dwellings[House].Windows[index3].GlazingType.Contains("argon");
              this.OpeningTypes[checked (this.OpeningTypes.Length - 1)].FrameType = SAP_Module.Proj.Dwellings[House].Windows[index3].FrameType;
              this.OpeningTypes[checked (this.OpeningTypes.Length - 1)].MetalFrameType = SAP_Module.Proj.Dwellings[House].Windows[index3].ThermalBreak;
              this.OpeningTypes[checked (this.OpeningTypes.Length - 1)].SolarT = SAP_Module.Proj.Dwellings[House].Windows[index3].g;
              this.OpeningTypes[checked (this.OpeningTypes.Length - 1)].FrameFactor = SAP_Module.Proj.Dwellings[House].Windows[index3].FF;
              this.OpeningTypes[checked (this.OpeningTypes.Length - 1)].U_Value = SAP_Module.Proj.Dwellings[House].Windows[index3].U;
            }
          }
          checked { ++index3; }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      int num7 = 1;
      int length2 = this.OpeningTypes.Length;
      try
      {
        int num8 = checked (SAP_Module.Proj.Dwellings[House].NoofRoofLights - 1);
        int index5 = 0;
        while (index5 <= num8)
        {
          bool flag = false;
          if (index5 == 0)
          {
            // ISSUE: variable of a reference type
            HQMXML.Opening[]& local;
            // ISSUE: explicit reference operation
            HQMXML.Opening[] openingArray = (HQMXML.Opening[]) Utils.CopyArray((Array) ^(local = ref this.OpeningTypes), (Array) new HQMXML.Opening[checked (this.OpeningTypes.Length + 1)]);
            local = openingArray;
            this.OpeningTypes[checked (this.OpeningTypes.Length - 1)].Name = "Roof windows (" + Conversions.ToString(num7) + ")";
            SAP_Module.Proj.Dwellings[House].RoofLights[index5].OpeningType = this.OpeningTypes[checked (this.OpeningTypes.Length - 1)].Name;
            this.OpeningTypes[checked (this.OpeningTypes.Length - 1)].DSource = SAP_Module.Proj.Dwellings[House].RoofLights[index5].UValueSource;
            this.OpeningTypes[checked (this.OpeningTypes.Length - 1)].Type = Conversions.ToString(5);
            this.OpeningTypes[checked (this.OpeningTypes.Length - 1)].GlazingType = SAP_Module.Proj.Dwellings[House].RoofLights[index5].GlazingType;
            this.OpeningTypes[checked (this.OpeningTypes.Length - 1)].GlazingGap = SAP_Module.Proj.Dwellings[House].RoofLights[index5].AirGap;
            this.OpeningTypes[checked (this.OpeningTypes.Length - 1)].Argon = SAP_Module.Proj.Dwellings[House].RoofLights[index5].GlazingType.Contains("argon");
            this.OpeningTypes[checked (this.OpeningTypes.Length - 1)].FrameType = SAP_Module.Proj.Dwellings[House].RoofLights[index5].FrameType;
            this.OpeningTypes[checked (this.OpeningTypes.Length - 1)].MetalFrameType = SAP_Module.Proj.Dwellings[House].RoofLights[index5].ThermalBreak;
            this.OpeningTypes[checked (this.OpeningTypes.Length - 1)].SolarT = SAP_Module.Proj.Dwellings[House].RoofLights[index5].g;
            this.OpeningTypes[checked (this.OpeningTypes.Length - 1)].FrameFactor = SAP_Module.Proj.Dwellings[House].RoofLights[index5].FF;
            this.OpeningTypes[checked (this.OpeningTypes.Length - 1)].U_Value = SAP_Module.Proj.Dwellings[House].RoofLights[index5].U;
            this.OpeningTypes[checked (this.OpeningTypes.Length - 1)].Pitch = Conversions.ToString(SAP_Module.Proj.Dwellings[House].RoofLights[index5].Pitch);
          }
          else
          {
            int num9 = length2;
            int num10 = checked (this.OpeningTypes.Length - 1);
            int index6 = num9;
            while (index6 <= num10)
            {
              if (!((uint) Operators.CompareString(SAP_Module.Proj.Dwellings[House].RoofLights[index5].UValueSource, this.OpeningTypes[index6].DSource, false) > 0U | (uint) Operators.CompareString(SAP_Module.Proj.Dwellings[House].RoofLights[index5].GlazingType, this.OpeningTypes[index6].GlazingType, false) > 0U | (uint) Operators.CompareString(SAP_Module.Proj.Dwellings[House].RoofLights[index5].AirGap, this.OpeningTypes[index6].GlazingGap, false) > 0U | SAP_Module.Proj.Dwellings[House].RoofLights[index5].GlazingType.Contains("argon") != this.OpeningTypes[index6].Argon | (uint) Operators.CompareString(SAP_Module.Proj.Dwellings[House].RoofLights[index5].FrameType, this.OpeningTypes[index6].FrameType, false) > 0U | (double) SAP_Module.Proj.Dwellings[House].RoofLights[index5].g != (double) this.OpeningTypes[index6].SolarT | (double) SAP_Module.Proj.Dwellings[House].RoofLights[index5].FF != (double) this.OpeningTypes[index6].FrameFactor | (double) SAP_Module.Proj.Dwellings[House].RoofLights[index5].U != (double) this.OpeningTypes[index6].U_Value))
              {
                SAP_Module.Proj.Dwellings[House].RoofLights[index5].OpeningType = this.OpeningTypes[index6].Name;
                flag = true;
                break;
              }
              checked { ++index6; }
            }
            if (!flag)
            {
              // ISSUE: variable of a reference type
              HQMXML.Opening[]& local;
              // ISSUE: explicit reference operation
              HQMXML.Opening[] openingArray = (HQMXML.Opening[]) Utils.CopyArray((Array) ^(local = ref this.OpeningTypes), (Array) new HQMXML.Opening[checked (this.OpeningTypes.Length + 1)]);
              local = openingArray;
              checked { ++num7; }
              this.OpeningTypes[checked (this.OpeningTypes.Length - 1)].Name = "Roof windows (" + Conversions.ToString(num7) + ")";
              SAP_Module.Proj.Dwellings[House].RoofLights[index5].OpeningType = this.OpeningTypes[checked (this.OpeningTypes.Length - 1)].Name;
              this.OpeningTypes[checked (this.OpeningTypes.Length - 1)].DSource = SAP_Module.Proj.Dwellings[House].RoofLights[index5].UValueSource;
              this.OpeningTypes[checked (this.OpeningTypes.Length - 1)].Type = Conversions.ToString(5);
              this.OpeningTypes[checked (this.OpeningTypes.Length - 1)].GlazingType = SAP_Module.Proj.Dwellings[House].RoofLights[index5].GlazingType;
              this.OpeningTypes[checked (this.OpeningTypes.Length - 1)].GlazingGap = SAP_Module.Proj.Dwellings[House].RoofLights[index5].AirGap;
              this.OpeningTypes[checked (this.OpeningTypes.Length - 1)].Argon = SAP_Module.Proj.Dwellings[House].RoofLights[index5].GlazingType.Contains("argon");
              this.OpeningTypes[checked (this.OpeningTypes.Length - 1)].FrameType = SAP_Module.Proj.Dwellings[House].RoofLights[index5].FrameType;
              this.OpeningTypes[checked (this.OpeningTypes.Length - 1)].MetalFrameType = SAP_Module.Proj.Dwellings[House].RoofLights[index5].ThermalBreak;
              this.OpeningTypes[checked (this.OpeningTypes.Length - 1)].SolarT = SAP_Module.Proj.Dwellings[House].RoofLights[index5].g;
              this.OpeningTypes[checked (this.OpeningTypes.Length - 1)].FrameFactor = SAP_Module.Proj.Dwellings[House].RoofLights[index5].FF;
              this.OpeningTypes[checked (this.OpeningTypes.Length - 1)].U_Value = SAP_Module.Proj.Dwellings[House].RoofLights[index5].U;
            }
          }
          checked { ++index5; }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private int FuelCheck(string Fuel, int House)
    {
      string str = Fuel;
      int num;
      // ISSUE: reference to a compiler-generated method
      switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(str))
      {
        case 157581269:
          if (Operators.CompareString(str, "heating oil", false) == 0)
          {
            num = 4;
            goto default;
          }
          else
            goto default;
        case 335024745:
          if (Operators.CompareString(str, "heat from boilers – biogas", false) == 0)
          {
            num = 44;
            goto default;
          }
          else
            goto default;
        case 575487477:
          if (Operators.CompareString(str, "wood pellets (bulk supply in bags, for main heating)", false) == 0)
          {
            num = 23;
            goto default;
          }
          else
            goto default;
        case 604697910:
          if (Operators.CompareString(str, "manufactured smokeless fuel", false) == 0)
          {
            num = 12;
            goto default;
          }
          else
            goto default;
        case 664172296:
          if (Operators.CompareString(str, "heat from CHP", false) == 0)
          {
            num = 46;
            goto default;
          }
          else
            goto default;
        case 721524493:
          if (Operators.CompareString(str, "dual fuel appliance (mineral and wood)", false) == 0)
            break;
          goto default;
        case 842919835:
          if (Operators.CompareString(str, "heat from boilers – LPG", false) == 0)
          {
            num = 52;
            goto default;
          }
          else
            goto default;
        case 857289046:
          if (Operators.CompareString(str, "house coal", false) == 0)
          {
            num = 11;
            goto default;
          }
          else
            goto default;
        case 975024876:
          if (Operators.CompareString(str, "bulk LPG", false) == 0)
          {
            num = 2;
            goto default;
          }
          else
            goto default;
        case 1086463322:
          if (Operators.CompareString(str, "LPG subject to Special Condition 18", false) == 0)
          {
            num = 9;
            goto default;
          }
          else
            goto default;
        case 1384014791:
          if (Operators.CompareString(str, "B30K", false) == 0)
          {
            num = 75;
            goto default;
          }
          else
            goto default;
        case 1424221758:
          if (Operators.CompareString(str, "geothermal heat source", false) == 0)
          {
            num = 46;
            goto default;
          }
          else
            goto default;
        case 1441345278:
          if (Operators.CompareString(str, "Electricity", false) == 0)
          {
            num = 39;
            goto default;
          }
          else
            goto default;
        case 1522447619:
          if (Operators.CompareString(str, "wood chips", false) == 0)
          {
            num = 21;
            goto default;
          }
          else
            goto default;
        case 1538586610:
          if (Operators.CompareString(str, "heat from boilers – oil", false) == 0)
          {
            num = 53;
            goto default;
          }
          else
            goto default;
        case 1597764060:
          if (Operators.CompareString(str, "mains gas", false) == 0)
          {
            num = 1;
            goto default;
          }
          else
            goto default;
        case 1770949684:
          if (Operators.CompareString(str, "appliances able to use mineral oil or liquid biofuel", false) == 0)
          {
            num = 74;
            goto default;
          }
          else
            goto default;
        case 1860525480:
          if (Operators.CompareString(str, "heat from electric heat pump", false) == 0)
          {
            num = 41;
            goto default;
          }
          else
            goto default;
        case 1946790875:
          if (Operators.CompareString(str, "wood logs", false) == 0)
          {
            num = 20;
            goto default;
          }
          else
            goto default;
        case 2251322125:
          if (Operators.CompareString(str, "wood pellets (in bags, for secondary heating)", false) == 0)
          {
            num = 22;
            goto default;
          }
          else
            goto default;
        case 2313921600:
          if (Operators.CompareString(str, "anthracite", false) == 0)
          {
            num = 15;
            goto default;
          }
          else
            goto default;
        case 2340757125:
          if (Operators.CompareString(str, "heat from boilers - waste combustion", false) == 0)
          {
            num = 42;
            goto default;
          }
          else
            goto default;
        case 2343415715:
          if (Operators.CompareString(str, "waste heat from power stations", false) == 0)
          {
            num = 45;
            goto default;
          }
          else
            goto default;
        case 2442528761:
          if (Operators.CompareString(str, "heat from heat pump", false) == 0)
            goto default;
          else
            goto default;
        case 2685417441:
          if (Operators.CompareString(str, "bioethanol from any biomass source", false) == 0)
          {
            num = 76;
            goto default;
          }
          else
            goto default;
        case 3198893402:
          if (Operators.CompareString(str, "rapeseed oil", false) == 0)
          {
            num = 73;
            goto default;
          }
          else
            goto default;
        case 3216529428:
          if (Operators.CompareString(str, "heat from boilers – biomass", false) == 0)
          {
            num = 43;
            goto default;
          }
          else
            goto default;
        case 3349323758:
          if (Operators.CompareString(str, "biodiesel from any biomass source", false) == 0)
          {
            num = 71;
            goto default;
          }
          else
            goto default;
        case 3398809853:
          if (Operators.CompareString(str, "heat from boilers – B30D", false) == 0)
          {
            num = 55;
            goto default;
          }
          else
            goto default;
        case 3722837730:
          if (Operators.CompareString(str, "bottled LPG", false) == 0)
          {
            num = 3;
            goto default;
          }
          else
            goto default;
        case 3794681384:
          if (Operators.CompareString(str, "LNG", false) == 0)
          {
            num = 8;
            goto default;
          }
          else
            goto default;
        case 3824947145:
          if (Operators.CompareString(str, "heat from boilers – coal", false) == 0)
          {
            num = 54;
            goto default;
          }
          else
            goto default;
        case 4235694608:
          if (Operators.CompareString(str, "biodiesel from used cooking oil only", false) == 0)
          {
            num = 72;
            goto default;
          }
          else
            goto default;
        case 4241528165:
          if (Operators.CompareString(str, "heat from boilers – mains gas", false) == 0)
          {
            num = 51;
            goto default;
          }
          else
            goto default;
        case 4242022632:
          if (Operators.CompareString(str, "dual fuel (mineral and wood)", false) == 0)
            break;
          goto default;
        default:
label_69:
          return num;
      }
      num = 10;
      goto label_69;
    }

    public HQMXML.HQMXMLReturn CreateHQMXML(int House, int country)
    {
      HQMXML.HQMXMLReturn hqmxml = new HQMXML.HQMXMLReturn();
      try
      {
        this._FileName_Path();
        this.XMLobj = this._InitializeXML(this.XMLobj);
        this._InitializeNameSpace(this.XMLobj);
        this._SAPReport(this.XMLobj, House, country);
        this._CloseDocument(this.XMLobj);
        FileInfo fileInfo = new FileInfo(SAP_Module.HQMXMLName);
        StreamReader streamReader = File.OpenText(SAP_Module.HQMXMLName);
        hqmxml.XML = streamReader.ReadToEnd();
        streamReader.Close();
        HQMXML.HQMXMLReturn hqmxmlReturn1 = new HQMXML.HQMXMLReturn();
        HQMXML.HQMXMLReturn hqmxmlReturn2 = Operators.CompareString(SAP_Module.Proj.Dwellings[House].Address.Country, "Scotland", false) != 0 ? this.ValidateXml(hqmxml.XML, Application.StartupPath + "\\Resources\\HQM.xsd") : this.ValidateXml(hqmxml.XML, Application.StartupPath + "\\Resources\\HQM0-Scotland.xsd");
        hqmxml.Validated = hqmxmlReturn2.Validated;
        hqmxml.Msg = hqmxmlReturn2.Msg;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        hqmxml.Msg = exception.Message + exception.StackTrace;
        ProjectData.ClearProjectError();
      }
      return hqmxml;
    }

    private HQMXML.HQMXMLReturn ValidateXml(string xmlFileName, string xmlSchemaName)
    {
      HQMXML.HQMXMLReturn hqmxmlReturn = new HQMXML.HQMXMLReturn();
      XmlDocument xmlDocument = new XmlDocument();
      xmlDocument.LoadXml(xmlFileName);
      xmlDocument.Schemas.Add(this.GetSchema(xmlSchemaName));
      try
      {
        xmlDocument.Validate(this.schemaValidation);
        hqmxmlReturn.Validated = true;
      }
      catch (XmlSchemaValidationException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        XmlSchemaValidationException validationException = ex;
        hqmxmlReturn.Msg = validationException.ToString();
        hqmxmlReturn.Validated = false;
        ProjectData.ClearProjectError();
      }
      catch (XmlSchemaException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        XmlSchemaException xmlSchemaException = ex;
        hqmxmlReturn.Msg = xmlSchemaException.ToString();
        hqmxmlReturn.Validated = false;
        ProjectData.ClearProjectError();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        hqmxmlReturn.Msg = exception.ToString();
        hqmxmlReturn.Validated = false;
        ProjectData.ClearProjectError();
      }
      return hqmxmlReturn;
    }

    private void ValidationHandler(object sender, ValidationEventArgs e) => throw e.Exception;

    private XmlSchema GetSchema(string filePath)
    {
      XmlSchema schema;
      using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
      {
        using (StreamReader reader = new StreamReader((Stream) fileStream))
          schema = XmlSchema.Read((TextReader) reader, (ValidationEventHandler) null);
      }
      return schema;
    }

    public static bool IsValidXml(string xmlFilePath, string xsdFilePath)
    {
      XDocument source = XDocument.Load(xmlFilePath);
      XmlSchemaSet schemas = new XmlSchemaSet();
      schemas.Add(schemas);
      bool flag;
      try
      {
        source.Validate(schemas, (ValidationEventHandler) null);
      }
      catch (XmlSchemaValidationException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        flag = false;
        ProjectData.ClearProjectError();
        goto label_4;
      }
      flag = true;
label_4:
      return flag;
    }

    private void _FileName_Path()
    {
      SAP_Module.HQMXMLName = "";
      try
      {
        object folderPath = (object) Environment.GetFolderPath(Environment.SpecialFolder.Personal);
        DirectoryInfo directoryInfo1 = new DirectoryInfo(Conversions.ToString(Operators.ConcatenateObject(folderPath, (object) " \\ Stroma SAP 2012")));
        DirectoryInfo directoryInfo2 = new DirectoryInfo(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(folderPath, (object) "\\Stroma SAP 2012\\"), (object) SAP_Module.Proj.Name)));
        if (!Directory.Exists(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(folderPath, (object) "\\Stroma SAP 2012\\"), (object) SAP_Module.Proj.Name))))
          Directory.CreateDirectory(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(folderPath, (object) "\\Stroma SAP 2012\\"), (object) SAP_Module.Proj.Name)));
        DirectoryInfo directoryInfo3 = new DirectoryInfo(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(folderPath, (object) "\\Stroma SAP 2012\\"), (object) SAP_Module.Proj.Name), (object) "\\"), (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Name)));
        if (!Directory.Exists(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(folderPath, (object) "\\Stroma SAP 2012\\"), (object) SAP_Module.Proj.Name), (object) "\\"), (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Name))))
          Directory.CreateDirectory(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(folderPath, (object) "\\Stroma SAP 2012\\"), (object) SAP_Module.Proj.Name), (object) "\\"), (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Name)));
        SAP_Module.HQMXMLPath = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(folderPath, (object) "\\Stroma SAP 2012\\"), (object) SAP_Module.Proj.Name));
        SAP_Module.HQMXMLName = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(folderPath, (object) "\\Stroma SAP 2012\\"), (object) SAP_Module.Proj.Name), (object) "\\"), (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Name), (object) "-HQM"), (object) ".xml"));
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      if (!File.Exists(SAP_Module.HQMXMLName))
        return;
      File.Delete(SAP_Module.HQMXMLName);
    }

    private XmlTextWriter _InitializeXML(XmlTextWriter XMLobj)
    {
      UTF8Encoding utF8Encoding = new UTF8Encoding();
      XMLobj = new XmlTextWriter(SAP_Module.HQMXMLName, (Encoding) utF8Encoding);
      XMLobj.Formatting = Formatting.Indented;
      XMLobj.Indentation = 2;
      XMLobj.WriteStartDocument();
      return XMLobj;
    }

    private void _CloseDocument(XmlTextWriter XMLobj)
    {
      XMLobj.WriteEndElement();
      XMLobj.Close();
    }

    private void _InitializeNameSpace(XmlTextWriter XMLobj)
    {
      XMLobj.WriteStartElement("BREEAM");
      XMLobj.WriteStartAttribute("xmlns:xsi");
      XMLobj.WriteString("http://www.w3.org/2001/XMLSchema-instance");
      XMLobj.WriteEndAttribute();
      XMLobj.WriteStartAttribute("xmlns");
      XMLobj.WriteString("http://www.homequalitymark.com");
      XMLobj.WriteEndAttribute();
      XMLobj.WriteStartElement("Assessment");
      XMLobj.WriteStartElement("HQMregistration");
      XMLobj.WriteEndElement();
    }

    private void _SAPReport(XmlTextWriter XMLobj, int House, int Country)
    {
      try
      {
        this._SectionID(XMLobj);
        this._CategoryID(XMLobj);
        this._IssueID(XMLobj);
        XMLobj.WriteStartElement("Criterion");
        XMLobj.WriteStartElement("inputs");
        XMLobj.WriteStartElement("SAP2012Data");
        this._dataType(XMLobj, House, Country);
        XMLobj.WriteStartElement("SAPDetails");
        this._SAPSchemaversion(XMLobj);
        this._SAPVersion(XMLobj);
        this._SAPPSoftwareName(XMLobj);
        this._SAPPSoftwareVersion(XMLobj);
        this._RRN(XMLobj, House, Country);
        XMLobj.WriteEndElement();
        this._HQMPropertyDetails(XMLobj, House, Country);
        XMLobj.WriteEndElement();
        XMLobj.WriteEndElement();
        XMLobj.WriteEndElement();
        XMLobj.WriteEndElement();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void _dataType(XmlTextWriter XMLobj, int House, int Country)
    {
      XMLobj.WriteStartElement("DataType");
      string status = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Status;
      if (Operators.CompareString(status, "New dwelling design stage", false) != 0)
      {
        if (Operators.CompareString(status, "New dwelling as built", false) != 0)
        {
          if (Operators.CompareString(status, "Existing dwelling (SAP)", false) == 0 || Operators.CompareString(status, "New extension to existing dwelling", false) == 0 || Operators.CompareString(status, "New dwelling created by change of use", false) == 0)
            XMLobj.WriteValue(3);
        }
        else
          XMLobj.WriteValue(2);
      }
      else
        XMLobj.WriteValue(1);
      XMLobj.WriteEndElement();
    }

    private void _SAPSchemaversion(XmlTextWriter XMLobj)
    {
      XMLobj.WriteStartElement("SchemaVersion");
      XMLobj.WriteValue("HQM0.1");
      XMLobj.WriteEndElement();
    }

    private void _SAPVersion(XmlTextWriter XMLobj)
    {
      XMLobj.WriteStartElement("SAPVersion");
      XMLobj.WriteValue("9.92");
      XMLobj.WriteEndElement();
    }

    private void _SectionID(XmlTextWriter XMLobj)
    {
      XMLobj.WriteStartElement("Section");
      XMLobj.WriteStartAttribute("id");
      XMLobj.WriteValue("2");
      XMLobj.WriteEndAttribute();
    }

    private void _CategoryID(XmlTextWriter XMLobj)
    {
      XMLobj.WriteStartElement("Category");
      XMLobj.WriteStartAttribute("id");
      XMLobj.WriteValue("2.02");
      XMLobj.WriteEndAttribute();
    }

    private void _IssueID(XmlTextWriter XMLobj)
    {
      XMLobj.WriteStartElement("Issue");
      XMLobj.WriteStartAttribute("id");
      XMLobj.WriteValue("2.02.01");
      XMLobj.WriteEndAttribute();
      XMLobj.WriteStartAttribute("toolType");
      XMLobj.WriteValue("data_input");
      XMLobj.WriteEndAttribute();
      XMLobj.WriteStartAttribute("toolStatus");
      XMLobj.WriteValue("Export");
      XMLobj.WriteEndAttribute();
    }

    private void _SAPPSoftwareVersion(XmlTextWriter XMLobj)
    {
      XMLobj.WriteStartElement("CalculationSoftwareVersion");
      XMLobj.WriteValue(SAP_Module.CurrVersion);
      XMLobj.WriteEndElement();
    }

    private void _SAPPSoftwareName(XmlTextWriter XMLobj)
    {
      XMLobj.WriteStartElement("CalculationSoftwareName");
      XMLobj.WriteValue("Stroma FSAP 2012");
      XMLobj.WriteEndElement();
    }

    private void _RRN(XmlTextWriter XMLobj, int House, int Country)
    {
      XMLobj.WriteStartElement("RRN");
      if (Validation.RefNum == null)
        Validation.RefNum = "0000-0000-0000-0000-0000";
      XMLobj.WriteValue(Validation.RefNum);
      XMLobj.WriteEndElement();
    }

    private void _ReportHeaderRegions(XmlTextWriter XMLobj, int House)
    {
      XMLobj.WriteStartElement("RegionCode");
      string location = SAP_Module.Proj.Dwellings[House].Location;
      // ISSUE: reference to a compiler-generated method
      switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(location))
      {
        case 85627527:
          if (Operators.CompareString(location, "Orkney", false) == 0)
          {
            XMLobj.WriteValue(11);
            goto default;
          }
          else
            goto default;
        case 417745194:
          if (Operators.CompareString(location, "Thames valley", false) == 0)
          {
            XMLobj.WriteValue(17);
            goto default;
          }
          else
            goto default;
        case 419820972:
          if (Operators.CompareString(location, "Borders", false) == 0)
          {
            XMLobj.WriteValue(1);
            goto default;
          }
          else
            goto default;
        case 423237023:
          if (Operators.CompareString(location, "South England", false) == 0)
          {
            XMLobj.WriteValue(16);
            goto default;
          }
          else
            goto default;
        case 463047147:
          if (Operators.CompareString(location, "Wales", false) == 0)
          {
            XMLobj.WriteValue(18);
            goto default;
          }
          else
            goto default;
        case 1121445140:
          if (Operators.CompareString(location, "South West England", false) == 0)
          {
            XMLobj.WriteValue(15);
            goto default;
          }
          else
            goto default;
        case 1253063607:
          if (Operators.CompareString(location, "Isle of Man", false) == 0)
          {
            XMLobj.WriteValue(24);
            goto default;
          }
          else
            goto default;
        case 1486598274:
          if (Operators.CompareString(location, "Shetland", false) == 0)
          {
            XMLobj.WriteValue(13);
            goto default;
          }
          else
            goto default;
        case 1608233300:
          if (Operators.CompareString(location, "East pennines", false) == 0)
            break;
          goto default;
        case 1809119403:
          if (Operators.CompareString(location, "Guernsey", false) == 0)
          {
            XMLobj.WriteValue(23);
            goto default;
          }
          else
            goto default;
        case 2227903623:
          if (Operators.CompareString(location, "South West Scotland", false) == 0)
            goto label_35;
          else
            goto default;
        case 2536965870:
          if (Operators.CompareString(location, "East Anglia", false) == 0)
          {
            XMLobj.WriteValue(2);
            goto default;
          }
          else
            goto default;
        case 2574711555:
          if (Operators.CompareString(location, "Severn valley", false) == 0)
          {
            XMLobj.WriteValue(12);
            goto default;
          }
          else
            goto default;
        case 2627101428:
          if (Operators.CompareString(location, "Highland", false) == 0)
          {
            XMLobj.WriteValue(5);
            goto default;
          }
          else
            goto default;
        case 3009355918:
          if (Operators.CompareString(location, "North West England", false) == 0)
            goto label_35;
          else
            goto default;
        case 3088137120:
          if (Operators.CompareString(location, "North East England", false) == 0)
          {
            XMLobj.WriteValue(7);
            goto default;
          }
          else
            goto default;
        case 3158107624:
          if (Operators.CompareString(location, "East Scotland", false) == 0)
          {
            XMLobj.WriteValue(4);
            goto default;
          }
          else
            goto default;
        case 3255183281:
          if (Operators.CompareString(location, "Western Isles", false) == 0)
          {
            XMLobj.WriteValue(21);
            goto default;
          }
          else
            goto default;
        case 3381936845:
          if (Operators.CompareString(location, "Jersey", false) == 0)
          {
            XMLobj.WriteValue(22);
            goto default;
          }
          else
            goto default;
        case 3757789148:
          if (Operators.CompareString(location, "Northern Ireland", false) == 0)
          {
            XMLobj.WriteValue(10);
            goto default;
          }
          else
            goto default;
        case 3790857268:
          if (Operators.CompareString(location, "East Pennines", false) == 0)
            break;
          goto default;
        case 4003211866:
          if (Operators.CompareString(location, "South East England", false) == 0)
          {
            XMLobj.WriteValue(14);
            goto default;
          }
          else
            goto default;
        case 4013004195:
          if (Operators.CompareString(location, "North East Scotland", false) == 0)
          {
            XMLobj.WriteValue(8);
            goto default;
          }
          else
            goto default;
        case 4072253181:
          if (Operators.CompareString(location, "Midlands", false) == 0)
          {
            XMLobj.WriteValue(6);
            goto default;
          }
          else
            goto default;
        case 4111412702:
          if (Operators.CompareString(location, "West Scotland", false) == 0)
          {
            XMLobj.WriteValue(20);
            goto default;
          }
          else
            goto default;
        case 4162830650:
          if (Operators.CompareString(location, "West Pennines", false) == 0)
          {
            XMLobj.WriteValue(19);
            goto default;
          }
          else
            goto default;
        default:
label_51:
          XMLobj.WriteEndElement();
          return;
      }
      XMLobj.WriteValue(3);
      goto label_51;
label_35:
      XMLobj.WriteValue(9);
      goto label_51;
    }

    private void _ReportHeaderProperty(XmlTextWriter XMLobj, int House, int Country)
    {
      XMLobj.WriteStartElement("PropertyLocation");
      XMLobj.WriteStartElement("Address");
      XMLobj.WriteStartElement("AddressLine1");
      XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Address.Line1);
      XMLobj.WriteEndElement();
      if ((uint) Operators.CompareString(SAP_Module.Proj.Dwellings[House].Address.Line2, "", false) > 0U)
      {
        XMLobj.WriteStartElement("AddressLine2");
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Address.Line2);
        XMLobj.WriteEndElement();
      }
      if ((uint) Operators.CompareString(SAP_Module.Proj.Dwellings[House].Address.Line3, "", false) > 0U)
      {
        XMLobj.WriteStartElement("AddressLine3");
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Address.Line3);
        XMLobj.WriteEndElement();
      }
      XMLobj.WriteEndElement();
      XMLobj.WriteEndElement();
      XMLobj.WriteStartElement("SiteLocation");
      XMLobj.WriteStartElement("Address");
      XMLobj.WriteStartElement("PostTown");
      XMLobj.WriteValue(Microsoft.VisualBasic.Strings.UCase(SAP_Module.Proj.Dwellings[House].Address.City));
      XMLobj.WriteEndElement();
      XMLobj.WriteStartElement("Postcode");
      XMLobj.WriteValue(Microsoft.VisualBasic.Strings.UCase(SAP_Module.Proj.Dwellings[House].Address.PostCost));
      XMLobj.WriteEndElement();
      XMLobj.WriteEndElement();
      this._ReportHeaderRegions(XMLobj, House);
      XMLobj.WriteStartElement("CountryCode");
      switch (Country)
      {
        case 2:
          XMLobj.WriteValue("WLS");
          break;
        case 3:
          XMLobj.WriteValue("NIR");
          break;
        case 4:
          XMLobj.WriteValue("SCT");
          break;
        default:
          XMLobj.WriteValue("ENG");
          break;
      }
      XMLobj.WriteEndElement();
      XMLobj.WriteEndElement();
    }

    private void _SAP09DataPropertyDetails_propertyType(
      XmlTextWriter XMLobj,
      int House,
      int Country)
    {
      XMLobj.WriteStartElement("PropertyType");
      string propertyType = SAP_Module.Proj.Dwellings[House].PropertyType;
      if (Operators.CompareString(propertyType, nameof (House), false) != 0)
      {
        if (Operators.CompareString(propertyType, "Bungalow", false) != 0)
        {
          if (Operators.CompareString(propertyType, "Flat", false) != 0)
          {
            if (Operators.CompareString(propertyType, "Maisonette", false) == 0)
              XMLobj.WriteValue(3);
            else
              XMLobj.WriteValue(0);
          }
          else
            XMLobj.WriteValue(2);
        }
        else
          XMLobj.WriteValue(1);
      }
      else
        XMLobj.WriteValue(0);
      XMLobj.WriteEndElement();
    }

    private void HeatingBanding(int House)
    {
      this.Eff = SAP_Module.Calculation2012.Calculation.Energy_Requirements_9a.Box206 != 0.0 ? SAP_Module.Calculation2012.Calculation.Energy_Requirements_9a._Box206Uncorrected : SAP_Module.Calculation2012.Calculation.Energy_Requirements_9b.Box306;
      this.calHeatingVal = SAP_Module.Calculation2012.Calculation.Fuel_costs_10a.Box240P == 0.0 ? 100.0 * SAP_Module.Calculation2012.Calculation.Fuel_costs_10b.Box340aP / this.Eff : 100.0 * SAP_Module.Calculation2012.Calculation.Fuel_costs_10a.Box240P / this.Eff;
      this.calHeatingValCO2 = SAP_Module.Calculation2012.Calculation.CO2_Emissions_12a.Box261E != 0.0 ? 100.0 * SAP_Module.Calculation2012.Calculation.CO2_Emissions_12a.Box261E / this.Eff : 100.0 * SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box361W / this.Eff;
      this.responsiveness = SAP_Module.Calculation2012._Add_Variable.C7._Responsiveness;
      if (this.responsiveness < 1.0)
      {
        this.calHeatingVal *= 1.0 + 0.29 * (1.0 - this.responsiveness);
        this.calHeatingValCO2 *= 1.0 + 0.29 * (1.0 - this.responsiveness);
      }
      if (SAP_Module.Proj.Dwellings[House].MainHeating.Emitter == null)
        SAP_Module.Proj.Dwellings[House].MainHeating.Emitter = "";
      if (SAP_Module.Proj.Dwellings[House].MainHeating.SGroup.Contains("heat pumps") & SAP_Module.Proj.Dwellings[House].MainHeating.Emitter.Contains("radiators") & (uint) Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.InforSource, "Boiler Database", false) > 0U && this.calHeatingVal > 0.0)
      {
        this.calHeatingVal /= 0.7;
        this.calHeatingValCO2 /= 0.7;
      }
      if (Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.HGroup, "Community heating schemes", false) == 0)
      {
        if (SAP_Module.Proj.Dwellings[House].MainHeating.CommunityH.NoOfAdditionalHeatSources == 0)
        {
          this.calHeatingVal = SAP_Module.Calculation2012.Calculation.Fuel_costs_10b.Box340aP * this.Eff;
          this.calHeatingValCO2 = Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.MHType, "Community CHP", false) != 0 ? SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box367_E / (SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box367a / 100.0) * this.Eff : (SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box363E - SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box361 / 100.0 * SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box364E) / (SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box362 / 100.0) * this.Eff;
        }
        else
        {
          double num1 = Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.MHType, "Community CHP", false) != 0 ? SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box367_E * SAP_Module.Calculation2012.Calculation.Energy_Requirements_9b.Box303a / (SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box367a / 100.0) : (SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box363E - SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box361 / 100.0 * SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box364E) / (SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box362 / 100.0) * SAP_Module.Calculation2012.Calculation.Energy_Requirements_9b.Box303a;
          double num2;
          switch (SAP_Module.Proj.Dwellings[House].MainHeating.CommunityH.NoOfAdditionalHeatSources)
          {
            case 1:
              num2 = num1 + SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box368E * SAP_Module.Calculation2012.Calculation.Energy_Requirements_9b.Box303b / (SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box367b / 100.0);
              break;
            case 2:
              num2 = num1 + SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box368E * SAP_Module.Calculation2012.Calculation.Energy_Requirements_9b.Box303b / (SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box367b / 100.0) + SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box369E * SAP_Module.Calculation2012.Calculation.Energy_Requirements_9b.Box303c / (SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box367c / 100.0);
              break;
            case 3:
              num2 = num1 + SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box368E * SAP_Module.Calculation2012.Calculation.Energy_Requirements_9b.Box303b / (SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box367b / 100.0) + SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box369E * SAP_Module.Calculation2012.Calculation.Energy_Requirements_9b.Box303c / (SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box367c / 100.0) + SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box370E * SAP_Module.Calculation2012.Calculation.Energy_Requirements_9b.Box303d / (SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box367d / 100.0);
              break;
            case 4:
              num2 = num1 + SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box368E * SAP_Module.Calculation2012.Calculation.Energy_Requirements_9b.Box303b / (SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box367b / 100.0) + SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box369E * SAP_Module.Calculation2012.Calculation.Energy_Requirements_9b.Box303c / (SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box367c / 100.0) + SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box370E * SAP_Module.Calculation2012.Calculation.Energy_Requirements_9b.Box303d / (SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box367d / 100.0) + SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box371E * SAP_Module.Calculation2012.Calculation.Energy_Requirements_9b.Box303e / (SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box367e / 100.0);
              break;
          }
          this.calHeatingVal = (SAP_Module.Calculation2012.Calculation.Energy_Requirements_9b.Box303a * SAP_Module.Calculation2012.Calculation.Fuel_costs_10b.Box340aP + SAP_Module.Calculation2012.Calculation.Energy_Requirements_9b.Box303b * SAP_Module.Calculation2012.Calculation.Fuel_costs_10b.Box340bP + SAP_Module.Calculation2012.Calculation.Energy_Requirements_9b.Box303c * SAP_Module.Calculation2012.Calculation.Fuel_costs_10b.Box340cP + SAP_Module.Calculation2012.Calculation.Energy_Requirements_9b.Box303d * SAP_Module.Calculation2012.Calculation.Fuel_costs_10b.Box340dP + SAP_Module.Calculation2012.Calculation.Energy_Requirements_9b.Box303e * SAP_Module.Calculation2012.Calculation.Fuel_costs_10b.Box340eP) * this.Eff;
          this.calHeatingValCO2 = num2 * this.Eff;
        }
      }
      this.MainBrand = PDFFunctions.BandCheckHeating(this.calHeatingVal, "XML");
      this.MainBrand2 = PDFFunctions.BandCheckHeating2(this.calHeatingValCO2, "XML");
      try
      {
        if (SAP_Module.Proj.Dwellings[House].MainHeating.SGroup.Contains("heat pumps"))
        {
          if (Conversions.ToDouble(this.MainBrand2) < 5.0)
            this.MainBrand2 = Conversions.ToString(Conversion.Val(this.MainBrand2) + 1.0);
          if (Conversions.ToDouble(this.MainBrand) < 5.0)
            this.MainBrand = Conversions.ToString(Conversion.Val(this.MainBrand) + 1.0);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      try
      {
        if (SAP_Module.Proj.Dwellings[House].MainHeating.SGroup.Contains("Micro-cogeneration (micro-CHP)"))
        {
          if (Conversions.ToDouble(this.MainBrand2) < 5.0)
            this.MainBrand2 = Conversions.ToString(Conversion.Val(this.MainBrand2) + 1.0);
          if (Conversions.ToDouble(this.MainBrand) < 5.0)
            this.MainBrand = Conversions.ToString(Conversion.Val(this.MainBrand) + 1.0);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      if (!SAP_Module.Proj.Dwellings[House].IncludeMainHeating2)
        return;
      this.Eff = SAP_Module.Calculation2012.Calculation.Energy_Requirements_9a._Box207Uncorrected != 0.0 ? SAP_Module.Calculation2012.Calculation.Energy_Requirements_9a._Box207Uncorrected : SAP_Module.Calculation2012.Calculation.Energy_Requirements_9b.Box306;
      this.calHeatingVal = 100.0 * SAP_Module.Calculation2012.Calculation.Fuel_costs_10a.Box241P / this.Eff;
      this.calHeatingValCO2 = 100.0 * SAP_Module.Calculation2012.Calculation.CO2_Emissions_12a.Box262E / this.Eff;
      this.responsiveness = SAP_Module.Calculation2012._Add_Variable.C7._Responsiveness;
      if (this.responsiveness < 1.0)
      {
        this.calHeatingVal *= 1.0 + 0.29 * (1.0 - this.responsiveness);
        this.calHeatingValCO2 *= 1.0 + 0.29 * (1.0 - this.responsiveness);
      }
      if (Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating2.SGroup, "Heat pumps", false) == 0 & SAP_Module.Proj.Dwellings[House].MainHeating2.Emitter.Contains("radiators") & (uint) Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating2.InforSource, "Boiler Database", false) > 0U && this.calHeatingVal > 0.0)
      {
        this.calHeatingVal /= 0.7;
        this.calHeatingValCO2 /= 0.7;
      }
      this.secMainBrand = PDFFunctions.BandCheckHeating(this.calHeatingVal, "XML");
      this.secMainBrand2 = PDFFunctions.BandCheckHeating2(this.calHeatingValCO2, "XML");
      try
      {
        if (SAP_Module.Proj.Dwellings[House].MainHeating2.SGroup.Contains("heat pumps"))
          this.secMainBrand2 = Conversions.ToString(Conversion.Val(this.secMainBrand2) + 1.0);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      try
      {
        if (SAP_Module.Proj.Dwellings[House].MainHeating2.SGroup.Contains("Micro-cogeneration (micro-CHP)"))
        {
          if (Conversions.ToDouble(this.secMainBrand2) < 5.0)
            this.secMainBrand2 = Conversions.ToString(Conversion.Val(this.secMainBrand2) + 1.0);
          if (Conversions.ToDouble(this.secMainBrand) < 5.0)
            this.secMainBrand = Conversions.ToString(Conversion.Val(this.secMainBrand) + 1.0);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private bool Compare_Heaters(int House) => !((double) SAP_Module.Proj.Dwellings[House].HeatFractionSec > 0.1 & (double) SAP_Module.Proj.Dwellings[House].HeatFractionSec < 0.9);

    private void _propertySummaryWater_Cylinder(XmlTextWriter XMLobj, int House, int Country)
    {
      XMLobj.WriteStartElement("HasHotWaterCylinder", (string) null);
      if ((double) SAP_Module.Proj.Dwellings[House].Water.Cylinder.Volume != 0.0 & SAP_Module.Proj.Dwellings[House].Water.SystemRef != 999)
      {
        if (SAP_Module.Proj.Dwellings[House].Water.Cylinder.ManuSpecified)
        {
          if (-(SAP_Module.Proj.Dwellings[House].Water.SystemRef == 901 ? 1 : 0) == 901 & this.isCPSU(0))
            XMLobj.WriteValue("false");
          else if (SAP_Module.Proj.Dwellings[House].Water.SystemRef == 914 & this.isCPSU(1))
            XMLobj.WriteValue("false");
          else
            XMLobj.WriteValue("true");
        }
        else if (this.isCPSU(0))
          XMLobj.WriteValue("false");
        else
          XMLobj.WriteValue("true");
      }
      else
        XMLobj.WriteValue("false");
      XMLobj.WriteEndElement();
    }

    private void _propertySummaryAirConditioning(XmlTextWriter XMLobj, int House, int Country)
    {
      XMLobj.WriteStartElement("HasFixedAirConditioning");
      if (!SAP_Module.Proj.Dwellings[House].Cooling.Include)
        XMLobj.WriteValue("false");
      else
        XMLobj.WriteValue("true");
      XMLobj.WriteEndElement();
    }

    private void _propertySummarySeparated_conservatory(
      XmlTextWriter XMLobj,
      int House,
      int Country)
    {
      XMLobj.WriteStartElement("HasHeatedSeparateConservatory");
      if (!string.IsNullOrEmpty(SAP_Module.Proj.Dwellings[House].Conservatory))
      {
        if (Operators.CompareString(SAP_Module.Proj.Dwellings[House].Conservatory, "Separated heated conservatory", false) == 0)
          XMLobj.WriteValue("true");
        else
          XMLobj.WriteValue("false");
      }
      else
        XMLobj.WriteValue("false");
      XMLobj.WriteEndElement();
    }

    private void _propertySummaryDwellingType(XmlTextWriter XMLobj, int House, int Country)
    {
      XMLobj.WriteStartElement("DwellingType");
      if (Country == 2 | Country == 4)
      {
        XMLobj.WriteStartAttribute("language");
        if (Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].EPCLanguage, "Welsh", false) == 0)
          XMLobj.WriteValue("2");
        else
          XMLobj.WriteValue("1");
        XMLobj.WriteEndAttribute();
      }
      if (Country == 2 & Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].EPCLanguage, "Welsh", false) == 0)
      {
        if (Operators.CompareString(SAP_Module.Proj.Dwellings[House].PropertyType, nameof (House), false) == 0 | Operators.CompareString(SAP_Module.Proj.Dwellings[House].PropertyType, "Bungalow", false) == 0)
          XMLobj.WriteValue(PDFFunctions.CheckWalesDwellingType(SAP_Module.Proj.Dwellings[House].BuildForm + " " + SAP_Module.Proj.Dwellings[House].PropertyType));
        else
          XMLobj.WriteValue(PDFFunctions.CheckWalesDwellingType(SAP_Module.Proj.Dwellings[House].FlatType.Replace(" ", "-") + " " + Microsoft.VisualBasic.Strings.LCase(SAP_Module.Proj.Dwellings[House].PropertyType)));
      }
      else if (Operators.CompareString(SAP_Module.Proj.Dwellings[House].PropertyType, nameof (House), false) == 0 | Operators.CompareString(SAP_Module.Proj.Dwellings[House].PropertyType, "Bungalow", false) == 0)
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].BuildForm + " " + Microsoft.VisualBasic.Strings.LCase(SAP_Module.Proj.Dwellings[House].PropertyType));
      else
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].FlatType.Replace(" ", "-") + " " + Microsoft.VisualBasic.Strings.LCase(SAP_Module.Proj.Dwellings[House].PropertyType));
      XMLobj.WriteEndElement();
    }

    private void _propertySummary_TotalFloorArea(XmlTextWriter XMLobj, int House, int Country)
    {
      XMLobj.WriteStartElement("TotalFloorArea");
      double box4 = SAP_Module.Calculation2012.Calculation.Dimensions.Box4;
      XMLobj.WriteValue(Math.Round(SAP_Module.Calculation2012.Calculation.Dimensions.Box4, 0));
      XMLobj.WriteEndElement();
      if (SAP_Module.Calculation2012.Calculation.CO2_Emissions_12a.Box272 != 0.0)
        this.carbonEmm = SAP_Module.Calculation2012.Calculation.CO2_Emissions_12a.Box272 / 1000.0;
      else
        this.carbonEmm = SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box383 / 1000.0;
    }

    private void _propertySummary_ZeroCarbonHouse(XmlTextWriter XMLobj, int House, int Country)
    {
      if (Math.Round(SAP_Module.CalcualtionDER2012.Calculation.AssessmentLZC2012.ZC8, 2) > 0.0)
        return;
      XMLobj.WriteStartElement("IsZeroCarbonHome");
      XMLobj.WriteValue("Yes");
      XMLobj.WriteEndElement();
    }

    private void _propertySummary_MultipleGlazedPercentage(
      XmlTextWriter XMLobj,
      int House,
      int Country)
    {
      XMLobj.WriteStartElement("MultipleGlazedPercentage");
      XMLobj.WriteValue("100");
      XMLobj.WriteEndElement();
    }

    private void _EnergyAssessment_PropertySummary(XmlTextWriter XMLobj, int House, int Country)
    {
      try
      {
        XMLobj.WriteStartElement("PropertySummary");
        this._propertySummaryAirConditioning(XMLobj, House, Country);
        this._propertySummaryWater_Cylinder(XMLobj, House, Country);
        this._propertySummarySeparated_conservatory(XMLobj, House, Country);
        this._propertySummaryDwellingType(XMLobj, House, Country);
        this._propertySummary_TotalFloorArea(XMLobj, House, Country);
        this._propertySummary_MultipleGlazedPercentage(XMLobj, House, Country);
        XMLobj.WriteEndElement();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void _EnergyAssessment_EnergyUse(XmlTextWriter XMLobj, int House, int Country)
    {
      XMLobj.WriteStartElement("EnergyUse");
      XMLobj.WriteStartElement("EnergyRatingAverage");
      if (Operators.CompareString(SAP_Module.Proj.Dwellings[House].Address.Country, "Northern Ireland", false) == 0)
        XMLobj.WriteValue(57);
      else if (Operators.CompareString(SAP_Module.Proj.Dwellings[House].Address.Country, "Scotland", false) == 0)
        XMLobj.WriteValue(61);
      else
        XMLobj.WriteValue(60);
      XMLobj.WriteEndElement();
      if (Operators.CompareString(SAP_Module.Proj.Dwellings[House].Address.Country, "Northern Ireland", false) == 0)
      {
        XMLobj.WriteStartElement("EnergyRatingTypicalNewbuild");
        XMLobj.WriteValue(Functions.FindNewDwellingRatingNI(SAP_Module.CurrDwelling));
        XMLobj.WriteEndElement();
      }
      XMLobj.WriteStartElement("EnergyRatingCurrent");
      if (SAP_Module.Calculation2012.Calculation.SAP_rating_11a.SAPRating <= 0.0 & SAP_Module.Calculation2012.Calculation.SAP_rating_11b.SAPRating <= 0.0)
        XMLobj.WriteValue(1);
      else if (SAP_Module.Calculation2012.Calculation.SAP_rating_11a.SAPRating == 0.0)
        XMLobj.WriteValue(SAP_Module.Calculation2012.Calculation.SAP_rating_11b.SAPRating);
      else
        XMLobj.WriteValue(SAP_Module.Calculation2012.Calculation.SAP_rating_11a.SAPRating);
      XMLobj.WriteEndElement();
      XMLobj.WriteStartElement("EnergyRatingPotential");
      if (SAP_Module.CalculationImprove2012.Calculation.SAP_rating_11a.SAPRating <= 0.0 & SAP_Module.CalculationImprove2012.Calculation.SAP_rating_11b.SAPRating <= 0.0)
        XMLobj.WriteValue(1);
      else if (SAP_Module.CalculationImprove2012.Calculation.SAP_rating_11a.SAPRating == 0.0)
      {
        if (SAP_Module.CalculationImprove2012.Calculation.SAP_rating_11b.SAPRating < SAP_Module.Calculation2012.Calculation.SAP_rating_11b.SAPRating)
          XMLobj.WriteValue(Math.Round(SAP_Module.Calculation2012.Calculation.SAP_rating_11b.SAPRating, 0));
        else
          XMLobj.WriteValue(Math.Round(SAP_Module.CalculationImprove2012.Calculation.SAP_rating_11b.SAPRating, 0));
      }
      else if (SAP_Module.CalculationImprove2012.Calculation.SAP_rating_11a.SAPRating < SAP_Module.Calculation2012.Calculation.SAP_rating_11a.SAPRating)
        XMLobj.WriteValue(Math.Round(SAP_Module.Calculation2012.Calculation.SAP_rating_11a.SAPRating, 0));
      else
        XMLobj.WriteValue(Math.Round(SAP_Module.CalculationImprove2012.Calculation.SAP_rating_11a.SAPRating, 0));
      XMLobj.WriteEndElement();
      if (Country == 4)
      {
        XMLobj.WriteStartElement("EnvironmentalImpactAverage");
        XMLobj.WriteValue("59");
        XMLobj.WriteEndElement();
      }
      XMLobj.WriteStartElement("EnvironmentalImpactCurrent");
      if (SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.EIRating <= 0.0 & SAP_Module.Calculation2012.Calculation.CO2_Emissions_12a.EIValue <= 0.0)
        XMLobj.WriteValue(1);
      else if (SAP_Module.Calculation2012.Calculation.CO2_Emissions_12a.EIValue == 0.0)
        XMLobj.WriteValue(Math.Round(SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.EIRating, 0));
      else
        XMLobj.WriteValue(Math.Round(SAP_Module.Calculation2012.Calculation.CO2_Emissions_12a.EIValue, 0));
      XMLobj.WriteEndElement();
      XMLobj.WriteStartElement("EnergyConsumptionCurrent");
      if (SAP_Module.Calculation2012Regional.Calculation.Primary_Energy_13a.Box273 == 0.0)
        XMLobj.WriteValue(Math.Round(SAP_Module.Calculation2012Regional.Calculation.Primary_Energy_13b.Box383 / SAP_Module.Calculation2012Regional.Calculation.Dimensions.Box4, 0));
      else
        XMLobj.WriteValue(Math.Round(SAP_Module.Calculation2012Regional.Calculation.Primary_Energy_13a.Box273, 0));
      XMLobj.WriteEndElement();
      if (Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Address.Country, "Scotland", false) == 0)
      {
        XMLobj.WriteStartElement("EnergyDeliveredCurrent");
        if (SAP_Module.Calculation2012Regional.Calculation.Primary_Energy_13a.Box273 != 0.0)
          XMLobj.WriteValue(Math.Round((SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9a.Box211 + SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9a.Box213 + SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9a.Box215 + SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9a.Box219 + SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9a.Box230a + SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9a.Box230b + SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9a.Box230c + SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9a.Box230d + SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9a.Box230e + SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9a.Box231 + SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9a.Box232 + SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9a.Box233 + SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9a.Box234 + SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9a.Box235) / SAP_Module.Calculation2012Regional.Calculation.Dimensions.Box4, 0));
        else
          XMLobj.WriteValue(Math.Round((SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9b.Box307a + SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9b.Box307b + SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9b.Box307c + SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9b.Box307d + SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9b.Box307e + SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9b.Box309 + SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9b.Box310a + SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9b.Box310b + SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9b.Box310c + SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9b.Box310d + SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9b.Box310e + SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9b.Box310aW + SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9b.Box310bW + SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9b.Box310cW + SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9b.Box310dW + SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9b.Box310eW + SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9b.Box312 + SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9b.Box315 + SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9b.Box331 + SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9b.Box332 + SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9b.Box333 + SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9b.Box334) / SAP_Module.Calculation2012Regional.Calculation.Dimensions.Box4, 0));
        XMLobj.WriteEndElement();
      }
      XMLobj.WriteStartElement("CO2EmissionsCurrent");
      if (SAP_Module.Calculation2012.Calculation.CO2_Emissions_12a.Box272 != 0.0)
      {
        this.carbonEmm = SAP_Module.Calculation2012Regional.Calculation.CO2_Emissions_12a.Box272 / 1000.0;
        this.carbonEmm2 = SAP_Module.CalculationImprove2012Regional.Calculation.CO2_Emissions_12a.Box272 / 1000.0;
      }
      else
      {
        this.carbonEmm = SAP_Module.Calculation2012Regional.Calculation.CO2_Emissions_12b.Box383 / 1000.0;
        this.carbonEmm2 = SAP_Module.CalculationImprove2012Regional.Calculation.CO2_Emissions_12b.Box383 / 1000.0;
      }
      if (this.carbonEmm > 10.0)
        XMLobj.WriteValue(Math.Round(this.carbonEmm, 0));
      else
        XMLobj.WriteValue(Microsoft.VisualBasic.Strings.Format((object) this.carbonEmm, "0.0"));
      XMLobj.WriteEndElement();
      XMLobj.WriteStartElement("CO2EmissionsCurrentPerFloorArea");
      if (SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box384 == 0.0)
      {
        if (SAP_Module.Calculation2012Regional.Calculation.CO2_Emissions_12a.Box273 < 0.0)
          XMLobj.WriteValue(Math.Round(SAP_Module.Calculation2012Regional.Calculation.CO2_Emissions_12a.Box273, 1));
        else
          XMLobj.WriteValue(Math.Round(SAP_Module.Calculation2012Regional.Calculation.CO2_Emissions_12a.Box273, 0));
      }
      else if (SAP_Module.Calculation2012Regional.Calculation.CO2_Emissions_12b.Box384 < 0.0)
        XMLobj.WriteValue(Math.Round(SAP_Module.Calculation2012Regional.Calculation.CO2_Emissions_12b.Box384, 1));
      else
        XMLobj.WriteValue(Math.Round(SAP_Module.Calculation2012Regional.Calculation.CO2_Emissions_12b.Box384, 0));
      XMLobj.WriteEndElement();
      XMLobj.WriteEndElement();
    }

    private void _SAP09Data_SpecialFeature(XmlTextWriter XMLobj, int House, int Country)
    {
      if (!SAP_Module.Proj.Dwellings[House].Renewable.Special.Include)
        return;
      XMLobj.WriteStartElement("SpecialFeatures");
      int num = checked (SAP_Module.Proj.Dwellings[House].Renewable.Special.Special.Length - 1);
      int index = 0;
      while (index <= num)
      {
        XMLobj.WriteStartElement("SpecialFeature");
        XMLobj.WriteStartElement("Description");
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Renewable.Special.Special[index].Description);
        XMLobj.WriteEndElement();
        if (SAP_Module.Proj.Dwellings[House].Renewable.Special.Special[index].MakeEmissionsOnly)
          XMLobj.WriteStartElement("EmissionsFeature");
        else
          XMLobj.WriteStartElement("EnergyFeature");
        if (SAP_Module.Proj.Dwellings[House].Renewable.Special.Special[index].MakeEmissionsOnly)
        {
          XMLobj.WriteStartElement("EmissionsSaved");
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Renewable.Special.Special[index].EmissionsAmount);
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("EmissionsCreated");
          XMLobj.WriteValue(this.FuelCheck(Conversions.ToString(SAP_Module.Proj.Dwellings[House].Renewable.Special.Special[index].EmissionsAmountCreated), House));
          XMLobj.WriteEndElement();
        }
        else
        {
          XMLobj.WriteStartElement("EnergySavedOrGenerated");
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Renewable.Special.Special[index].EnergySaved);
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("SavedOrGeneratedFuel");
          XMLobj.WriteValue(this.FuelCheck(SAP_Module.Proj.Dwellings[House].Renewable.Special.Special[index].FuelSaved, House));
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("EnergyUsed");
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Renewable.Special.Special[index].EnergyUsed);
          XMLobj.WriteEndElement();
          if ((double) SAP_Module.Proj.Dwellings[House].Renewable.Special.Special[index].EnergyUsed > 0.0)
          {
            XMLobj.WriteStartElement("EnergyUsedFuel");
            XMLobj.WriteValue(this.FuelCheck(SAP_Module.Proj.Dwellings[House].Renewable.Special.Special[index].FuelUsed, House));
            XMLobj.WriteEndElement();
          }
        }
        if (SAP_Module.Proj.Dwellings[House].Renewable.Special.Special[index].IncludeMonthly)
        {
          XMLobj.WriteStartElement("AirChangeRates");
          XMLobj.WriteStartElement("AirChangeRate");
          XMLobj.WriteStartElement("Month");
          XMLobj.WriteValue("Jan");
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("AirChangeRateValue");
          XMLobj.WriteValue(Math.Round((double) SAP_Module.Proj.Dwellings[House].Renewable.Special.Special[index].M1, 2));
          XMLobj.WriteEndElement();
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("AirChangeRate");
          XMLobj.WriteStartElement("Month");
          XMLobj.WriteValue("Feb");
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("AirChangeRateValue");
          XMLobj.WriteValue(Math.Round((double) SAP_Module.Proj.Dwellings[House].Renewable.Special.Special[index].M2, 2));
          XMLobj.WriteEndElement();
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("AirChangeRate");
          XMLobj.WriteStartElement("Month");
          XMLobj.WriteValue("Mar");
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("AirChangeRateValue");
          XMLobj.WriteValue(Math.Round((double) SAP_Module.Proj.Dwellings[House].Renewable.Special.Special[index].M3, 2));
          XMLobj.WriteEndElement();
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("AirChangeRate");
          XMLobj.WriteStartElement("Month");
          XMLobj.WriteValue("Apr");
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("AirChangeRateValue");
          XMLobj.WriteValue(Math.Round((double) SAP_Module.Proj.Dwellings[House].Renewable.Special.Special[index].M4, 2));
          XMLobj.WriteEndElement();
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("AirChangeRate");
          XMLobj.WriteStartElement("Month");
          XMLobj.WriteValue("May");
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("AirChangeRateValue");
          XMLobj.WriteValue(Math.Round((double) SAP_Module.Proj.Dwellings[House].Renewable.Special.Special[index].M5, 2));
          XMLobj.WriteEndElement();
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("AirChangeRate");
          XMLobj.WriteStartElement("Month");
          XMLobj.WriteValue("Jun");
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("AirChangeRateValue");
          XMLobj.WriteValue(Math.Round((double) SAP_Module.Proj.Dwellings[House].Renewable.Special.Special[index].M6, 2));
          XMLobj.WriteEndElement();
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("AirChangeRate");
          XMLobj.WriteStartElement("Month");
          XMLobj.WriteValue("Jul");
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("AirChangeRateValue");
          XMLobj.WriteValue(Math.Round((double) SAP_Module.Proj.Dwellings[House].Renewable.Special.Special[index].M7, 2));
          XMLobj.WriteEndElement();
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("AirChangeRate");
          XMLobj.WriteStartElement("Month");
          XMLobj.WriteValue("Aug");
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("AirChangeRateValue");
          XMLobj.WriteValue(Math.Round((double) SAP_Module.Proj.Dwellings[House].Renewable.Special.Special[index].M8, 2));
          XMLobj.WriteEndElement();
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("AirChangeRate");
          XMLobj.WriteStartElement("Month");
          XMLobj.WriteValue("Sep");
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("AirChangeRateValue");
          XMLobj.WriteValue(Math.Round((double) SAP_Module.Proj.Dwellings[House].Renewable.Special.Special[index].M9, 2));
          XMLobj.WriteEndElement();
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("AirChangeRate");
          XMLobj.WriteStartElement("Month");
          XMLobj.WriteValue("Oct");
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("AirChangeRateValue");
          XMLobj.WriteValue(Math.Round((double) SAP_Module.Proj.Dwellings[House].Renewable.Special.Special[index].M10, 2));
          XMLobj.WriteEndElement();
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("AirChangeRate");
          XMLobj.WriteStartElement("Month");
          XMLobj.WriteValue("Nov");
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("AirChangeRateValue");
          XMLobj.WriteValue(Math.Round((double) SAP_Module.Proj.Dwellings[House].Renewable.Special.Special[index].M11, 2));
          XMLobj.WriteEndElement();
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("AirChangeRate");
          XMLobj.WriteStartElement("Month");
          XMLobj.WriteValue("Dec");
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("AirChangeRateValue");
          XMLobj.WriteValue(Math.Round((double) SAP_Module.Proj.Dwellings[House].Renewable.Special.Special[index].M12, 2));
          XMLobj.WriteEndElement();
          XMLobj.WriteEndElement();
          XMLobj.WriteEndElement();
        }
        XMLobj.WriteEndElement();
        XMLobj.WriteEndElement();
        checked { ++index; }
      }
      XMLobj.WriteEndElement();
    }

    private void _SAP09DataPropertyDetails_LivingArea(XmlTextWriter XMLobj, int House, int Country)
    {
      XMLobj.WriteStartElement("LivingArea");
      XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].LivingArea);
      XMLobj.WriteEndElement();
    }

    private void _SAP09DataPropertyDetails_Orientation(
      XmlTextWriter XMLobj,
      int House,
      int Country)
    {
      XMLobj.WriteStartElement("Orientation");
      string orientation = SAP_Module.Proj.Dwellings[House].Orientation;
      // ISSUE: reference to a compiler-generated method
      switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(orientation))
      {
        case 105265260:
          if (Operators.CompareString(orientation, "Unspecified", false) == 0)
          {
            XMLobj.WriteValue("0");
            break;
          }
          break;
        case 1128440633:
          if (Operators.CompareString(orientation, "North East", false) == 0)
          {
            XMLobj.WriteValue("2");
            break;
          }
          break;
        case 1409318971:
          if (Operators.CompareString(orientation, "North West", false) == 0)
          {
            XMLobj.WriteValue("8");
            break;
          }
          break;
        case 1731397980:
          if (Operators.CompareString(orientation, "East", false) == 0)
          {
            XMLobj.WriteValue("3");
            break;
          }
          break;
        case 1734234020:
          if (Operators.CompareString(orientation, "North", false) == 0)
          {
            XMLobj.WriteValue("1");
            break;
          }
          break;
        case 1796576718:
          if (Operators.CompareString(orientation, "West", false) == 0)
          {
            XMLobj.WriteValue("7");
            break;
          }
          break;
        case 2417407149:
          if (Operators.CompareString(orientation, "South West", false) == 0)
          {
            XMLobj.WriteValue("6");
            break;
          }
          break;
        case 2853841879:
          if (Operators.CompareString(orientation, "South East", false) == 0)
          {
            XMLobj.WriteValue("4");
            break;
          }
          break;
        case 3017973530:
          if (Operators.CompareString(orientation, "South", false) == 0)
          {
            XMLobj.WriteValue("5");
            break;
          }
          break;
      }
      XMLobj.WriteEndElement();
    }

    private void _SAP09DataPropertyDetails_ConservatoryType(
      XmlTextWriter XMLobj,
      int House,
      int Country)
    {
      XMLobj.WriteStartElement("ConservatoryType");
      string Left = Microsoft.VisualBasic.Strings.UCase(SAP_Module.Proj.Dwellings[House].Conservatory);
      if (Operators.CompareString(Left, Microsoft.VisualBasic.Strings.UCase("No conservatory"), false) == 0)
        XMLobj.WriteValue("1");
      else if (Operators.CompareString(Left, Microsoft.VisualBasic.Strings.UCase("Separated unheated conservatory"), false) == 0)
        XMLobj.WriteValue("2");
      else if (Operators.CompareString(Left, Microsoft.VisualBasic.Strings.UCase("Separated heated conservatory"), false) == 0)
        XMLobj.WriteValue("3");
      else if (Operators.CompareString(Left, Microsoft.VisualBasic.Strings.UCase("Not separated"), false) == 0)
        XMLobj.WriteValue("4");
      XMLobj.WriteEndElement();
    }

    private void _SAP09DataPropertyDetails_SmokedArea(XmlTextWriter XMLobj, int House, int Country)
    {
      XMLobj.WriteStartElement("IsInSmokeControlArea");
      string smokeArea = SAP_Module.Proj.Dwellings[House].SmokeArea;
      if (Operators.CompareString(smokeArea, "No", false) != 0)
      {
        if (Operators.CompareString(smokeArea, "Yes", false) != 0)
        {
          if (Operators.CompareString(smokeArea, "Unknown", false) == 0 || Operators.CompareString(smokeArea, "unknown", false) == 0)
            XMLobj.WriteValue("unknown");
        }
        else
          XMLobj.WriteValue("true");
      }
      else
        XMLobj.WriteValue("false");
      XMLobj.WriteEndElement();
    }

    private void _SAP09DataPropertyDetails_ElectricityGeneration(
      XmlTextWriter XMLobj,
      int House,
      int Country)
    {
      if ((double) SAP_Module.Proj.Dwellings[House].Renewable.AAEGeneration.EGenerated <= 0.0)
        return;
      XMLobj.WriteStartElement("AdditionalAllowableElectricityGeneration");
      XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Renewable.AAEGeneration.EGenerated);
      XMLobj.WriteEndElement();
    }

    private void _SAP09DataPropertyDetails_Design_Water_Use(
      XmlTextWriter XMLobj,
      int House,
      int Country)
    {
      if (!SAP_Module.Proj.Dwellings[House].LessThan125Litre)
        return;
      XMLobj.WriteStartElement("DesignWaterUse");
      XMLobj.WriteValue(1);
      XMLobj.WriteEndElement();
    }

    private void _SAP09DataPropertyDetails_Flat_Details(
      XmlTextWriter XMLobj,
      int House,
      int Country)
    {
      if (string.IsNullOrEmpty(SAP_Module.Proj.Dwellings[House].FlatType))
        return;
      XMLobj.WriteStartElement("FlatDetails");
      XMLobj.WriteStartElement("Level");
      string flatType = SAP_Module.Proj.Dwellings[House].FlatType;
      if (Operators.CompareString(flatType, "Ground floor", false) != 0)
      {
        if (Operators.CompareString(flatType, "Mid floor", false) != 0)
        {
          if (Operators.CompareString(flatType, "Top floor", false) == 0)
            XMLobj.WriteValue("3");
          else
            XMLobj.WriteValue("0");
        }
        else
          XMLobj.WriteValue("2");
      }
      else
        XMLobj.WriteValue("1");
      XMLobj.WriteEndElement();
      if (Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Address.Country, "Scotland", false) == 0)
      {
        XMLobj.WriteStartElement("NumberOfDwellingsBelow");
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoOFDwellingsBelow);
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("NumberOfDwellingsAbove");
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoOFDwellingsAbove);
        XMLobj.WriteEndElement();
      }
      XMLobj.WriteEndElement();
    }

    private void _SAP09DataPropertyDetails_Openings(XmlTextWriter XMLobj, int House, int Country)
    {
      XMLobj.WriteStartElement("OpeningTypes");
      int num = checked (this.OpeningTypes.Length - 1);
      int index = 0;
      while (index <= num)
      {
        XMLobj.WriteStartElement("OpeningType");
        XMLobj.WriteStartElement("Name");
        XMLobj.WriteValue(this.OpeningTypes[index].Name);
        XMLobj.WriteEndElement();
        if (Operators.CompareString(this.OpeningTypes[index].DSource, "BFRC", false) == 0 & !this.OpeningTypes[index].Name.Contains("Door"))
        {
          XMLobj.WriteStartElement("Description");
          XMLobj.WriteValue("BFRC data");
          XMLobj.WriteEndElement();
        }
        if (Operators.CompareString(this.OpeningTypes[index].DSource, "Manufacturer", false) == 0)
        {
          XMLobj.WriteStartElement("Description");
          XMLobj.WriteValue("Data from Manufacturer");
          XMLobj.WriteEndElement();
        }
        XMLobj.WriteStartElement("DataSource");
        string dsource = this.OpeningTypes[index].DSource;
        if (Operators.CompareString(dsource, "SAP 2005", false) != 0 && Operators.CompareString(dsource, "SAP 2009", false) != 0 && Operators.CompareString(dsource, "SAP 2012", false) != 0)
        {
          if (Operators.CompareString(dsource, "Manufacturer", false) != 0)
          {
            if (Operators.CompareString(dsource, "BFRC", false) == 0)
              XMLobj.WriteValue(4);
          }
          else
            XMLobj.WriteValue(2);
        }
        else
          XMLobj.WriteValue(3);
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("Type");
        if (this.OpeningTypes[index].Name.Contains("Door"))
        {
          string type = this.OpeningTypes[index].Type;
          if (Operators.CompareString(type, "Solid", false) != 0)
          {
            if (Operators.CompareString(type, "Half glazed", false) != 0)
            {
              if (Operators.CompareString(type, "Fully glazed", false) == 0)
                XMLobj.WriteValue(3);
            }
            else
              XMLobj.WriteValue(2);
          }
          else
            XMLobj.WriteValue(1);
        }
        else
          XMLobj.WriteValue(this.OpeningTypes[index].Type);
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("GlazingType");
        string glazingType = this.OpeningTypes[index].GlazingType;
        // ISSUE: reference to a compiler-generated method
        switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(glazingType))
        {
          case 68605829:
            if (Operators.CompareString(glazingType, "triple-glazed, argon filled (low-E, En = 0.2, hard coat)", false) == 0)
              goto label_51;
            else
              goto default;
          case 763250309:
            if (Operators.CompareString(glazingType, "double-glazed, air filled (low-E, En = 0.2, hard coat)", false) == 0)
              goto label_46;
            else
              goto default;
          case 1070237142:
            if (Operators.CompareString(glazingType, "triple-glazed, argon filled", false) == 0)
              goto label_50;
            else
              goto default;
          case 1119002789:
            if (Operators.CompareString(glazingType, "double-glazed, argon filled", false) == 0)
              break;
            goto default;
          case 1129292894:
            if (Operators.CompareString(glazingType, "triple-glazed, air filled (low-E, En = 0.15, hard coat)", false) == 0)
              goto label_52;
            else
              goto default;
          case 1508940614:
            if (Operators.CompareString(glazingType, "double-glazed, argon filled (low-E, En = 0.15, hard coat)", false) == 0)
              goto label_47;
            else
              goto default;
          case 1617436365:
            if (Operators.CompareString(glazingType, "triple-glazed, argon filled (low-E, En = 0.1, soft coat)", false) == 0)
              goto label_53;
            else
              goto default;
          case 1917834200:
            if (Operators.CompareString(glazingType, "double-glazed, argon filled (low-E, En = 0.1, soft coat)", false) == 0)
              goto label_48;
            else
              goto default;
          case 2282570948:
            if (Operators.CompareString(glazingType, "triple-glazed, air filled (low-E, En = 0.2, hard coat)", false) == 0)
              goto label_51;
            else
              goto default;
          case 2312080845:
            if (Operators.CompareString(glazingType, "double-glazed, air filled (low-E, En = 0.1, soft coat)", false) == 0)
              goto label_48;
            else
              goto default;
          case 2413948722:
            if (Operators.CompareString(glazingType, "double-glazed, argon filled (low-E, En = 0.05, soft coat)", false) == 0)
              goto label_49;
            else
              goto default;
          case 2482092156:
            if (Operators.CompareString(glazingType, "double-glazed, argon filled (low-E, En = 0.2, hard coat)", false) == 0)
              goto label_46;
            else
              goto default;
          case 2498216925:
            if (Operators.CompareString(glazingType, "triple-glazed, air filled", false) == 0)
              goto label_50;
            else
              goto default;
          case 2915735968:
            if (Operators.CompareString(glazingType, "triple-glazed, air filled (low-E, En = 0.1, soft coat)", false) == 0)
              goto label_53;
            else
              goto default;
          case 3074690985:
            if (Operators.CompareString(glazingType, "triple-glazed, argon filled (low-E, En = 0.05, soft coat)", false) == 0)
              goto label_54;
            else
              goto default;
          case 3361248225:
            if (Operators.CompareString(glazingType, "triple-glazed, argon filled (low-E, En = 0.15, hard coat)", false) == 0)
              goto label_52;
            else
              goto default;
          case 3689514233:
            if (Operators.CompareString(glazingType, "Single-glazed", false) == 0)
            {
              XMLobj.WriteValue("2");
              goto label_56;
            }
            else
              goto default;
          case 3838377526:
            if (Operators.CompareString(glazingType, "double-glazed", false) == 0)
              break;
            goto default;
          case 3843542185:
            if (Operators.CompareString(glazingType, "double-glazed, air filled (low-E, En = 0.05, soft coat)", false) == 0)
              goto label_49;
            else
              goto default;
          case 4014901974:
            if (Operators.CompareString(glazingType, "double-glazed, air filled", false) == 0)
              break;
            goto default;
          case 4130099425:
            if (Operators.CompareString(glazingType, "double-glazed, air filled (low-E, En = 0.15, hard coat)", false) == 0)
              goto label_47;
            else
              goto default;
          case 4251481834:
            if (Operators.CompareString(glazingType, "triple-glazed, air filled (low-E, En = 0.05, soft coat)", false) == 0)
              goto label_54;
            else
              goto default;
          case 4255679661:
            if (Operators.CompareString(glazingType, "Secondary glazing", false) == 0)
            {
              XMLobj.WriteValue("13");
              goto label_56;
            }
            else
              goto default;
          default:
            XMLobj.WriteValue("1");
            goto label_56;
        }
        XMLobj.WriteValue("3");
        goto label_56;
label_46:
        XMLobj.WriteValue("4");
        goto label_56;
label_47:
        XMLobj.WriteValue("5");
        goto label_56;
label_48:
        XMLobj.WriteValue("6");
        goto label_56;
label_49:
        XMLobj.WriteValue("7");
        goto label_56;
label_50:
        XMLobj.WriteValue("8");
        goto label_56;
label_51:
        XMLobj.WriteValue("9");
        goto label_56;
label_52:
        XMLobj.WriteValue("10");
        goto label_56;
label_53:
        XMLobj.WriteValue("11");
        goto label_56;
label_54:
        XMLobj.WriteValue("12");
label_56:
        XMLobj.WriteEndElement();
        if (Operators.CompareString(this.OpeningTypes[index].DSource, "SAP 2005", false) == 0 | Operators.CompareString(this.OpeningTypes[index].DSource, "SAP 2009", false) == 0 | Operators.CompareString(this.OpeningTypes[index].DSource, "SAP 2012", false) == 0 && (uint) Operators.CompareString(this.OpeningTypes[index].GlazingGap, "", false) > 0U)
        {
          XMLobj.WriteStartElement("GlazingGap");
          string glazingGap = this.OpeningTypes[index].GlazingGap;
          if (Operators.CompareString(glazingGap, "6mm", false) != 0)
          {
            if (Operators.CompareString(glazingGap, "12mm", false) != 0)
            {
              if (Operators.CompareString(glazingGap, "16mm or more ", false) == 0)
                XMLobj.WriteValue("3");
              else
                XMLobj.WriteValue("1");
            }
            else
              XMLobj.WriteValue("2");
          }
          else
            XMLobj.WriteValue("1");
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("IsArgonFilled");
          XMLobj.WriteValue(this.OpeningTypes[index].Argon);
          XMLobj.WriteEndElement();
        }
        if ((uint) Operators.CompareString(this.OpeningTypes[index].Type, "Solid", false) > 0U & (uint) Operators.CompareString(this.OpeningTypes[index].Type, "Fully glazed", false) > 0U && (uint) Operators.CompareString(this.OpeningTypes[index].FrameType, "", false) > 0U)
        {
          XMLobj.WriteStartElement("FrameType");
          string frameType = this.OpeningTypes[index].FrameType;
          if (Operators.CompareString(frameType, "Wood", false) != 0)
          {
            if (Operators.CompareString(frameType, "Metal", false) != 0 && Operators.CompareString(frameType, "Metal, thermal break", false) != 0)
            {
              if (Operators.CompareString(frameType, "PVC-U", false) == 0)
                XMLobj.WriteValue("2");
            }
            else
            {
              string metalFrameType = this.OpeningTypes[index].MetalFrameType;
              // ISSUE: reference to a compiler-generated method
              switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(metalFrameType))
              {
                case 333502473:
                  if (Operators.CompareString(metalFrameType, "8mm", false) == 0)
                  {
                    XMLobj.WriteValue("5");
                    goto label_85;
                  }
                  else
                    goto label_85;
                case 473775746:
                  if (Operators.CompareString(metalFrameType, "No thermal break", false) == 0)
                    break;
                  goto label_85;
                case 536439224:
                  if (Operators.CompareString(metalFrameType, "12mm", false) == 0)
                  {
                    XMLobj.WriteValue("6");
                    goto label_85;
                  }
                  else
                    goto label_85;
                case 2166136261:
                  if (Operators.CompareString(metalFrameType, "", false) == 0)
                    break;
                  goto label_85;
                case 2186527966:
                  if (Operators.CompareString(metalFrameType, "32mm", false) == 0)
                  {
                    XMLobj.WriteValue("8");
                    goto label_85;
                  }
                  else
                    goto label_85;
                case 2560045537:
                  if (Operators.CompareString(metalFrameType, "20mm", false) == 0)
                  {
                    XMLobj.WriteValue("7");
                    goto label_85;
                  }
                  else
                    goto label_85;
                case 3632641573:
                  if (Operators.CompareString(metalFrameType, "4mm", false) == 0)
                  {
                    XMLobj.WriteValue("4");
                    goto label_85;
                  }
                  else
                    goto label_85;
                default:
                  goto label_85;
              }
              XMLobj.WriteValue("3");
            }
          }
          else
            XMLobj.WriteValue("1");
label_85:
          XMLobj.WriteEndElement();
        }
        if (!this.OpeningTypes[index].Name.Contains("Door"))
        {
          XMLobj.WriteStartElement("SolarTransmittance");
          XMLobj.WriteValue(this.OpeningTypes[index].SolarT);
          XMLobj.WriteEndElement();
        }
        if ((uint) Operators.CompareString(this.OpeningTypes[index].DSource, "BFRC", false) > 0U && (double) this.OpeningTypes[index].FrameFactor != 0.0)
        {
          XMLobj.WriteStartElement("FrameFactor");
          XMLobj.WriteValue(this.OpeningTypes[index].FrameFactor);
          XMLobj.WriteEndElement();
        }
        XMLobj.WriteStartElement("UValue");
        XMLobj.WriteValue(this.OpeningTypes[index].U_Value);
        XMLobj.WriteEndElement();
        XMLobj.WriteEndElement();
        checked { ++index; }
      }
      XMLobj.WriteEndElement();
    }

    private void _SAP09DataPropertyDetails_BuitForm(XmlTextWriter XMLobj, int House, int Country)
    {
      string propertyType = SAP_Module.Proj.Dwellings[House].PropertyType;
      if (Operators.CompareString(propertyType, "Flat", false) == 0 || Operators.CompareString(propertyType, "Maisonette", false) == 0)
        return;
      XMLobj.WriteStartElement("BuiltForm");
      string Left = Microsoft.VisualBasic.Strings.UCase(SAP_Module.Proj.Dwellings[House].BuildForm);
      if (Operators.CompareString(Left, Microsoft.VisualBasic.Strings.UCase("Detached"), false) == 0)
        XMLobj.WriteValue("1");
      else if (Operators.CompareString(Left, Microsoft.VisualBasic.Strings.UCase("Semi-Detached"), false) == 0)
        XMLobj.WriteValue("2");
      else if (Operators.CompareString(Left, Microsoft.VisualBasic.Strings.UCase("Mid-Terrace"), false) == 0)
        XMLobj.WriteValue("4");
      else if (Operators.CompareString(Left, Microsoft.VisualBasic.Strings.UCase("End-Terrace"), false) == 0 || Operators.CompareString(Left, Microsoft.VisualBasic.Strings.UCase("End-terrace"), false) == 0)
        XMLobj.WriteValue("3");
      else if (Operators.CompareString(Left, Microsoft.VisualBasic.Strings.UCase("Enclosed End-Terrace"), false) == 0 || Operators.CompareString(Left, Microsoft.VisualBasic.Strings.UCase("Enclosed end"), false) == 0)
        XMLobj.WriteValue("5");
      else if (Operators.CompareString(Left, Microsoft.VisualBasic.Strings.UCase("Enclosed Mid-Terrace"), false) == 0 || Operators.CompareString(Left, Microsoft.VisualBasic.Strings.UCase("Enclosed mid"), false) == 0)
        XMLobj.WriteValue("6");
      else if (Operators.CompareString(Left, Microsoft.VisualBasic.Strings.UCase("Linked Detached"), false) == 0)
        XMLobj.WriteValue("7");
      XMLobj.WriteEndElement();
    }

    private void _BuildingPartsNumber(XmlTextWriter XMLobj, int House, int Country)
    {
      XMLobj.WriteStartElement("BuildingPartNumber");
      XMLobj.WriteValue("1");
      XMLobj.WriteEndElement();
    }

    private void _BuildingPartsIdentifier(XmlTextWriter XMLobj, int House, int Country)
    {
      XMLobj.WriteStartElement("Identifier");
      XMLobj.WriteValue("Main Dwelling");
      XMLobj.WriteEndElement();
    }

    private void _BuildingPartsConstruction(XmlTextWriter XMLobj, int House, int Country)
    {
      XMLobj.WriteStartElement("ConstructionYear");
      XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].YearBuilt);
      XMLobj.WriteEndElement();
    }

    private void _BuildingPartsOvershading(XmlTextWriter XMLobj, int House, int Country)
    {
      XMLobj.WriteStartElement("Overshading");
      string overshading = SAP_Module.Proj.Dwellings[House].Overshading;
      if (Operators.CompareString(overshading, "Heavy", false) != 0)
      {
        if (Operators.CompareString(overshading, "More than average", false) != 0)
        {
          if (Operators.CompareString(overshading, "Average or unknown", false) != 0)
          {
            if (Operators.CompareString(overshading, "Very Little", false) == 0)
              XMLobj.WriteValue(1);
          }
          else
            XMLobj.WriteValue(2);
        }
        else
          XMLobj.WriteValue(3);
      }
      else
        XMLobj.WriteValue(4);
      XMLobj.WriteEndElement();
    }

    private void _BuildingPartsDoors(XmlTextWriter XMLobj, int House, int Country)
    {
      int num1 = checked (SAP_Module.Proj.Dwellings[House].NoofDoors - 1);
      int index = 0;
      while (index <= num1)
      {
        if (SAP_Module.Proj.Dwellings[House].Doors[index].Count > 1)
        {
          int num2 = checked (SAP_Module.Proj.Dwellings[House].Doors[index].Count - 1);
          int num3 = 0;
          while (num3 <= num2)
          {
            // ISSUE: variable of a reference type
            int& local;
            // ISSUE: explicit reference operation
            int num4 = checked (^(local = ref this.count) + 1);
            local = num4;
            XMLobj.WriteStartElement("Opening");
            XMLobj.WriteStartElement("Name");
            XMLobj.WriteValue(this.count);
            XMLobj.WriteEndElement();
            XMLobj.WriteStartElement("Type");
            XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Doors[index].OpeningType);
            XMLobj.WriteEndElement();
            XMLobj.WriteStartElement("Location");
            XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Doors[index].Location);
            XMLobj.WriteEndElement();
            XMLobj.WriteStartElement("Orientation");
            string orientation = SAP_Module.Proj.Dwellings[House].Doors[index].Orientation;
            // ISSUE: reference to a compiler-generated method
            switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(orientation))
            {
              case 1128440633:
                if (Operators.CompareString(orientation, "North East", false) == 0)
                {
                  XMLobj.WriteValue("2");
                  break;
                }
                goto default;
              case 1409318971:
                if (Operators.CompareString(orientation, "North West", false) == 0)
                {
                  XMLobj.WriteValue("8");
                  break;
                }
                goto default;
              case 1731397980:
                if (Operators.CompareString(orientation, "East", false) == 0)
                {
                  XMLobj.WriteValue("3");
                  break;
                }
                goto default;
              case 1734234020:
                if (Operators.CompareString(orientation, "North", false) == 0)
                {
                  XMLobj.WriteValue("1");
                  break;
                }
                goto default;
              case 1796576718:
                if (Operators.CompareString(orientation, "West", false) == 0)
                {
                  XMLobj.WriteValue("7");
                  break;
                }
                goto default;
              case 2417407149:
                if (Operators.CompareString(orientation, "South West", false) == 0)
                {
                  XMLobj.WriteValue("6");
                  break;
                }
                goto default;
              case 2853841879:
                if (Operators.CompareString(orientation, "South East", false) == 0)
                {
                  XMLobj.WriteValue("4");
                  break;
                }
                goto default;
              case 3017973530:
                if (Operators.CompareString(orientation, "South", false) == 0)
                {
                  XMLobj.WriteValue("5");
                  break;
                }
                goto default;
              default:
                XMLobj.WriteValue("0");
                break;
            }
            XMLobj.WriteEndElement();
            if ((double) SAP_Module.Proj.Dwellings[House].Doors[index].Width == 0.0 & (double) SAP_Module.Proj.Dwellings[House].Doors[index].Height == 0.0 & (double) SAP_Module.Proj.Dwellings[House].Doors[index].Area != 0.0)
            {
              XMLobj.WriteStartElement("Width");
              XMLobj.WriteValue(1);
              XMLobj.WriteEndElement();
              XMLobj.WriteStartElement("Height");
              XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Doors[index].Area);
              XMLobj.WriteEndElement();
            }
            else
            {
              XMLobj.WriteStartElement("Width");
              XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Doors[index].Width / 1000f);
              XMLobj.WriteEndElement();
              XMLobj.WriteStartElement("Height");
              XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Doors[index].Height / 1000f);
              XMLobj.WriteEndElement();
            }
            XMLobj.WriteEndElement();
            checked { ++num3; }
          }
        }
        else
        {
          // ISSUE: variable of a reference type
          int& local;
          // ISSUE: explicit reference operation
          int num5 = checked (^(local = ref this.count) + 1);
          local = num5;
          XMLobj.WriteStartElement("Opening");
          XMLobj.WriteStartElement("Name");
          XMLobj.WriteValue(this.count);
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("Type");
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Doors[index].OpeningType);
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("Location");
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Doors[index].Location);
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("Orientation");
          string orientation = SAP_Module.Proj.Dwellings[House].Doors[index].Orientation;
          // ISSUE: reference to a compiler-generated method
          switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(orientation))
          {
            case 1128440633:
              if (Operators.CompareString(orientation, "North East", false) == 0)
              {
                XMLobj.WriteValue("2");
                break;
              }
              goto default;
            case 1409318971:
              if (Operators.CompareString(orientation, "North West", false) == 0)
              {
                XMLobj.WriteValue("8");
                break;
              }
              goto default;
            case 1731397980:
              if (Operators.CompareString(orientation, "East", false) == 0)
              {
                XMLobj.WriteValue("3");
                break;
              }
              goto default;
            case 1734234020:
              if (Operators.CompareString(orientation, "North", false) == 0)
              {
                XMLobj.WriteValue("1");
                break;
              }
              goto default;
            case 1796576718:
              if (Operators.CompareString(orientation, "West", false) == 0)
              {
                XMLobj.WriteValue("7");
                break;
              }
              goto default;
            case 2417407149:
              if (Operators.CompareString(orientation, "South West", false) == 0)
              {
                XMLobj.WriteValue("6");
                break;
              }
              goto default;
            case 2853841879:
              if (Operators.CompareString(orientation, "South East", false) == 0)
              {
                XMLobj.WriteValue("4");
                break;
              }
              goto default;
            case 3017973530:
              if (Operators.CompareString(orientation, "South", false) == 0)
              {
                XMLobj.WriteValue("5");
                break;
              }
              goto default;
            default:
              XMLobj.WriteValue("0");
              break;
          }
          XMLobj.WriteEndElement();
          if ((double) SAP_Module.Proj.Dwellings[House].Doors[index].Width == 0.0 & (double) SAP_Module.Proj.Dwellings[House].Doors[index].Height == 0.0 & (double) SAP_Module.Proj.Dwellings[House].Doors[index].Area != 0.0)
          {
            XMLobj.WriteStartElement("Width");
            XMLobj.WriteValue(1);
            XMLobj.WriteEndElement();
            XMLobj.WriteStartElement("Height");
            XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Doors[index].Area);
            XMLobj.WriteEndElement();
          }
          else
          {
            XMLobj.WriteStartElement("Width");
            XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Doors[index].Width / 1000f);
            XMLobj.WriteEndElement();
            XMLobj.WriteStartElement("Height");
            XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Doors[index].Height / 1000f);
            XMLobj.WriteEndElement();
          }
          XMLobj.WriteEndElement();
        }
        checked { ++index; }
      }
    }

    private void _BuildingPartsWindows(XmlTextWriter XMLobj, int House, int Country)
    {
      int num1 = checked (SAP_Module.Proj.Dwellings[House].NoofWindows - 1);
      int index = 0;
      while (index <= num1)
      {
        if (SAP_Module.Proj.Dwellings[House].Windows[index].Count > 1)
        {
          int num2 = checked (SAP_Module.Proj.Dwellings[House].Windows[index].Count - 1);
          int num3 = 0;
          while (num3 <= num2)
          {
            // ISSUE: variable of a reference type
            int& local;
            // ISSUE: explicit reference operation
            int num4 = checked (^(local = ref this.count) + 1);
            local = num4;
            XMLobj.WriteStartElement("Opening");
            XMLobj.WriteStartElement("Name");
            XMLobj.WriteValue(this.count);
            XMLobj.WriteEndElement();
            XMLobj.WriteStartElement("Type");
            XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Windows[index].OpeningType);
            XMLobj.WriteEndElement();
            XMLobj.WriteStartElement("Location");
            XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Windows[index].Location);
            XMLobj.WriteEndElement();
            XMLobj.WriteStartElement("Orientation");
            string orientation = SAP_Module.Proj.Dwellings[House].Windows[index].Orientation;
            // ISSUE: reference to a compiler-generated method
            switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(orientation))
            {
              case 1128440633:
                if (Operators.CompareString(orientation, "North East", false) == 0)
                {
                  XMLobj.WriteValue("2");
                  break;
                }
                goto default;
              case 1409318971:
                if (Operators.CompareString(orientation, "North West", false) == 0)
                {
                  XMLobj.WriteValue("8");
                  break;
                }
                goto default;
              case 1731397980:
                if (Operators.CompareString(orientation, "East", false) == 0)
                {
                  XMLobj.WriteValue("3");
                  break;
                }
                goto default;
              case 1734234020:
                if (Operators.CompareString(orientation, "North", false) == 0)
                {
                  XMLobj.WriteValue("1");
                  break;
                }
                goto default;
              case 1796576718:
                if (Operators.CompareString(orientation, "West", false) == 0)
                {
                  XMLobj.WriteValue("7");
                  break;
                }
                goto default;
              case 2417407149:
                if (Operators.CompareString(orientation, "South West", false) == 0)
                {
                  XMLobj.WriteValue("6");
                  break;
                }
                goto default;
              case 2853841879:
                if (Operators.CompareString(orientation, "South East", false) == 0)
                {
                  XMLobj.WriteValue("4");
                  break;
                }
                goto default;
              case 3017973530:
                if (Operators.CompareString(orientation, "South", false) == 0)
                {
                  XMLobj.WriteValue("5");
                  break;
                }
                goto default;
              default:
                XMLobj.WriteValue("0");
                break;
            }
            XMLobj.WriteEndElement();
            if ((double) SAP_Module.Proj.Dwellings[House].Windows[index].Width == 0.0 & (double) SAP_Module.Proj.Dwellings[House].Windows[index].Height == 0.0 & (double) SAP_Module.Proj.Dwellings[House].Windows[index].Area != 0.0)
            {
              XMLobj.WriteStartElement("Width");
              XMLobj.WriteValue(1);
              XMLobj.WriteEndElement();
              XMLobj.WriteStartElement("Height");
              XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Windows[index].Area);
              XMLobj.WriteEndElement();
            }
            else
            {
              XMLobj.WriteStartElement("Width");
              XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Windows[index].Width / 1000f);
              XMLobj.WriteEndElement();
              XMLobj.WriteStartElement("Height");
              XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Windows[index].Height / 1000f);
              XMLobj.WriteEndElement();
            }
            XMLobj.WriteEndElement();
            checked { ++num3; }
          }
        }
        else
        {
          // ISSUE: variable of a reference type
          int& local;
          // ISSUE: explicit reference operation
          int num5 = checked (^(local = ref this.count) + 1);
          local = num5;
          XMLobj.WriteStartElement("Opening");
          XMLobj.WriteStartElement("Name");
          XMLobj.WriteValue(this.count);
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("Type");
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Windows[index].OpeningType);
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("Location");
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Windows[index].Location);
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("Orientation");
          string orientation = SAP_Module.Proj.Dwellings[House].Windows[index].Orientation;
          // ISSUE: reference to a compiler-generated method
          switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(orientation))
          {
            case 1128440633:
              if (Operators.CompareString(orientation, "North East", false) == 0)
              {
                XMLobj.WriteValue("2");
                break;
              }
              goto default;
            case 1409318971:
              if (Operators.CompareString(orientation, "North West", false) == 0)
              {
                XMLobj.WriteValue("8");
                break;
              }
              goto default;
            case 1731397980:
              if (Operators.CompareString(orientation, "East", false) == 0)
              {
                XMLobj.WriteValue("3");
                break;
              }
              goto default;
            case 1734234020:
              if (Operators.CompareString(orientation, "North", false) == 0)
              {
                XMLobj.WriteValue("1");
                break;
              }
              goto default;
            case 1796576718:
              if (Operators.CompareString(orientation, "West", false) == 0)
              {
                XMLobj.WriteValue("7");
                break;
              }
              goto default;
            case 2417407149:
              if (Operators.CompareString(orientation, "South West", false) == 0)
              {
                XMLobj.WriteValue("6");
                break;
              }
              goto default;
            case 2853841879:
              if (Operators.CompareString(orientation, "South East", false) == 0)
              {
                XMLobj.WriteValue("4");
                break;
              }
              goto default;
            case 3017973530:
              if (Operators.CompareString(orientation, "South", false) == 0)
              {
                XMLobj.WriteValue("5");
                break;
              }
              goto default;
            default:
              XMLobj.WriteValue("0");
              break;
          }
          XMLobj.WriteEndElement();
          if ((double) SAP_Module.Proj.Dwellings[House].Windows[index].Width == 0.0 & (double) SAP_Module.Proj.Dwellings[House].Windows[index].Height == 0.0 & (double) SAP_Module.Proj.Dwellings[House].Windows[index].Area != 0.0)
          {
            XMLobj.WriteStartElement("Width");
            XMLobj.WriteValue(1);
            XMLobj.WriteEndElement();
            XMLobj.WriteStartElement("Height");
            XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Windows[index].Area);
            XMLobj.WriteEndElement();
          }
          else
          {
            XMLobj.WriteStartElement("Width");
            XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Windows[index].Width / 1000f);
            XMLobj.WriteEndElement();
            XMLobj.WriteStartElement("Height");
            XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Windows[index].Height / 1000f);
            XMLobj.WriteEndElement();
          }
          XMLobj.WriteEndElement();
        }
        checked { ++index; }
      }
    }

    private void _BuildingPartsRoofLights(XmlTextWriter XMLobj, int House, int Country)
    {
      int num1 = checked (SAP_Module.Proj.Dwellings[House].NoofRoofLights - 1);
      int index = 0;
      while (index <= num1)
      {
        if (SAP_Module.Proj.Dwellings[House].RoofLights[index].Count > 1)
        {
          int num2 = checked (SAP_Module.Proj.Dwellings[House].RoofLights[index].Count - 1);
          int num3 = 0;
          while (num3 <= num2)
          {
            // ISSUE: variable of a reference type
            int& local;
            // ISSUE: explicit reference operation
            int num4 = checked (^(local = ref this.count) + 1);
            local = num4;
            XMLobj.WriteStartElement("Opening");
            XMLobj.WriteStartElement("Name");
            XMLobj.WriteValue(this.count);
            XMLobj.WriteEndElement();
            XMLobj.WriteStartElement("Type");
            if (SAP_Module.Proj.Dwellings[House].RoofLights[index].OpeningType != null)
              XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].RoofLights[index].OpeningType);
            else
              XMLobj.WriteValue(0);
            XMLobj.WriteEndElement();
            XMLobj.WriteStartElement("Location");
            XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].RoofLights[index].Location);
            XMLobj.WriteEndElement();
            XMLobj.WriteStartElement("Orientation");
            string orientation = SAP_Module.Proj.Dwellings[House].RoofLights[index].Orientation;
            // ISSUE: reference to a compiler-generated method
            switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(orientation))
            {
              case 1128440633:
                if (Operators.CompareString(orientation, "North East", false) == 0)
                {
                  XMLobj.WriteValue("2");
                  break;
                }
                goto default;
              case 1409318971:
                if (Operators.CompareString(orientation, "North West", false) == 0)
                {
                  XMLobj.WriteValue("8");
                  break;
                }
                goto default;
              case 1731397980:
                if (Operators.CompareString(orientation, "East", false) == 0)
                {
                  XMLobj.WriteValue("3");
                  break;
                }
                goto default;
              case 1734234020:
                if (Operators.CompareString(orientation, "North", false) == 0)
                {
                  XMLobj.WriteValue("1");
                  break;
                }
                goto default;
              case 1796576718:
                if (Operators.CompareString(orientation, "West", false) == 0)
                {
                  XMLobj.WriteValue("7");
                  break;
                }
                goto default;
              case 1811125385:
                if (Operators.CompareString(orientation, "Horizontal", false) == 0)
                {
                  XMLobj.WriteValue("9");
                  break;
                }
                goto default;
              case 2417407149:
                if (Operators.CompareString(orientation, "South West", false) == 0)
                {
                  XMLobj.WriteValue("6");
                  break;
                }
                goto default;
              case 2853841879:
                if (Operators.CompareString(orientation, "South East", false) == 0)
                {
                  XMLobj.WriteValue("4");
                  break;
                }
                goto default;
              case 3017973530:
                if (Operators.CompareString(orientation, "South", false) == 0)
                {
                  XMLobj.WriteValue("5");
                  break;
                }
                goto default;
              default:
                XMLobj.WriteValue("0");
                break;
            }
            XMLobj.WriteEndElement();
            if ((double) SAP_Module.Proj.Dwellings[House].RoofLights[index].Width == 0.0 & (double) SAP_Module.Proj.Dwellings[House].RoofLights[index].Height == 0.0 & (double) SAP_Module.Proj.Dwellings[House].RoofLights[index].Area != 0.0)
            {
              XMLobj.WriteStartElement("Width");
              XMLobj.WriteValue(1);
              XMLobj.WriteEndElement();
              XMLobj.WriteStartElement("Height");
              XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].RoofLights[index].Area);
              XMLobj.WriteEndElement();
            }
            else
            {
              XMLobj.WriteStartElement("Width");
              XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].RoofLights[index].Width / 1000f);
              XMLobj.WriteEndElement();
              XMLobj.WriteStartElement("Height");
              XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].RoofLights[index].Height / 1000f);
              XMLobj.WriteEndElement();
            }
            try
            {
              XMLobj.WriteStartElement("Pitch");
              XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].RoofLights[index].Pitch);
              XMLobj.WriteEndElement();
            }
            catch (Exception ex)
            {
              ProjectData.SetProjectError(ex);
              ProjectData.ClearProjectError();
            }
            XMLobj.WriteEndElement();
            checked { ++num3; }
          }
        }
        else
        {
          // ISSUE: variable of a reference type
          int& local;
          // ISSUE: explicit reference operation
          int num5 = checked (^(local = ref this.count) + 1);
          local = num5;
          XMLobj.WriteStartElement("Opening");
          XMLobj.WriteStartElement("Name");
          XMLobj.WriteValue(this.count);
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("Type");
          if (SAP_Module.Proj.Dwellings[House].RoofLights[index].OpeningType != null)
          {
            XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].RoofLights[index].OpeningType);
            XMLobj.WriteEndElement();
          }
          else
          {
            XMLobj.WriteValue(0);
            XMLobj.WriteEndElement();
          }
          XMLobj.WriteStartElement("Location");
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].RoofLights[index].Location);
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("Orientation");
          string orientation = SAP_Module.Proj.Dwellings[House].RoofLights[index].Orientation;
          // ISSUE: reference to a compiler-generated method
          switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(orientation))
          {
            case 1128440633:
              if (Operators.CompareString(orientation, "North East", false) == 0)
              {
                XMLobj.WriteValue("2");
                break;
              }
              goto default;
            case 1409318971:
              if (Operators.CompareString(orientation, "North West", false) == 0)
              {
                XMLobj.WriteValue("8");
                break;
              }
              goto default;
            case 1731397980:
              if (Operators.CompareString(orientation, "East", false) == 0)
              {
                XMLobj.WriteValue("3");
                break;
              }
              goto default;
            case 1734234020:
              if (Operators.CompareString(orientation, "North", false) == 0)
              {
                XMLobj.WriteValue("1");
                break;
              }
              goto default;
            case 1796576718:
              if (Operators.CompareString(orientation, "West", false) == 0)
              {
                XMLobj.WriteValue("7");
                break;
              }
              goto default;
            case 1811125385:
              if (Operators.CompareString(orientation, "Horizontal", false) == 0)
              {
                XMLobj.WriteValue("9");
                break;
              }
              goto default;
            case 2417407149:
              if (Operators.CompareString(orientation, "South West", false) == 0)
              {
                XMLobj.WriteValue("6");
                break;
              }
              goto default;
            case 2853841879:
              if (Operators.CompareString(orientation, "South East", false) == 0)
              {
                XMLobj.WriteValue("4");
                break;
              }
              goto default;
            case 3017973530:
              if (Operators.CompareString(orientation, "South", false) == 0)
              {
                XMLobj.WriteValue("5");
                break;
              }
              goto default;
            default:
              XMLobj.WriteValue("0");
              break;
          }
          XMLobj.WriteEndElement();
          if ((double) SAP_Module.Proj.Dwellings[House].RoofLights[index].Width == 0.0 & (double) SAP_Module.Proj.Dwellings[House].RoofLights[index].Height == 0.0 & (double) SAP_Module.Proj.Dwellings[House].RoofLights[index].Area != 0.0)
          {
            XMLobj.WriteStartElement("Width");
            XMLobj.WriteValue(1);
            XMLobj.WriteEndElement();
            XMLobj.WriteStartElement("Height");
            XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].RoofLights[index].Area);
            XMLobj.WriteEndElement();
          }
          else
          {
            XMLobj.WriteStartElement("Width");
            XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].RoofLights[index].Width / 1000f);
            XMLobj.WriteEndElement();
            XMLobj.WriteStartElement("Height");
            XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].RoofLights[index].Height / 1000f);
            XMLobj.WriteEndElement();
          }
          try
          {
            XMLobj.WriteStartElement("Pitch");
            XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].RoofLights[index].Pitch);
            XMLobj.WriteEndElement();
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
          XMLobj.WriteEndElement();
        }
        checked { ++index; }
      }
    }

    private void _BuildingPartsFloor(XmlTextWriter XMLobj, int House, int Country)
    {
      if (checked (SAP_Module.Proj.Dwellings[House].NoofFloors + SAP_Module.Proj.Dwellings[House].NoofIFloors) > 0)
      {
        XMLobj.WriteStartElement("FloorDimensions");
        int num1 = 0;
        int index1 = 0;
        int index2 = 0;
        int num2 = 0;
        int num3 = checked (SAP_Module.Proj.Dwellings[House].Storeys - 1);
        int index3 = 0;
        while (index3 <= num3)
        {
          XMLobj.WriteStartElement("FloorDimension");
          XMLobj.WriteStartElement("Storey");
          if (SAP_Module.Proj.Dwellings[House].Dims[0].Basement == null)
            SAP_Module.Proj.Dwellings[House].Dims[0].Basement = "";
          if (Operators.CompareString(SAP_Module.Proj.Dwellings[House].Dims[0].Basement, "Yes", false) == 0)
          {
            XMLobj.WriteValue(checked (index3 - 1));
            XMLobj.WriteEndElement();
          }
          else
          {
            XMLobj.WriteValue(index3);
            XMLobj.WriteEndElement();
          }
          checked { ++num1; }
          checked { num2 += index3; }
          if (checked (SAP_Module.Proj.Dwellings[House].NoofFloors - 1) >= index3 && (uint) Operators.CompareString(SAP_Module.Proj.Dwellings[House].Floors[index3].Type, "Exposed floor", false) > 0U)
          {
            XMLobj.WriteStartElement("Description");
            if (SAP_Module.Proj.Dwellings[House].Floors[index3].Name != null)
              XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Floors[index3].Name);
            XMLobj.WriteEndElement();
          }
          XMLobj.WriteStartElement("FloorType");
          if (checked (SAP_Module.Proj.Dwellings[House].NoofFloors - 1) >= index3)
          {
            string type = SAP_Module.Proj.Dwellings[House].Floors[index3].Type;
            if (Operators.CompareString(type, "Basement floor", false) != 0)
            {
              if (Operators.CompareString(type, "Ground floor", false) != 0)
              {
                if (Operators.CompareString(type, "Exposed floor", false) == 0)
                  XMLobj.WriteValue(3);
              }
              else
                XMLobj.WriteValue(2);
            }
            else
              XMLobj.WriteValue(1);
          }
          else
            XMLobj.WriteValue(3);
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("TotalFloorArea");
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Dims[index3].Area);
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("StoreyHeight");
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Dims[index3].Height);
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("HeatLossArea");
          if (checked (SAP_Module.Proj.Dwellings[House].NoofFloors - 1) >= index3)
            XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Floors[index3].Area);
          else
            XMLobj.WriteValue(0);
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("UValue");
          if (checked (SAP_Module.Proj.Dwellings[House].NoofFloors - 1) >= index3)
            XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Floors[index3].U_Value);
          else
            XMLobj.WriteValue(0);
          XMLobj.WriteEndElement();
          if (checked (SAP_Module.Proj.Dwellings[House].NoofFloors - 1) >= index3)
          {
            if ((double) SAP_Module.Proj.Dwellings[House].Floors[index3].K > 0.0)
            {
              XMLobj.WriteStartElement("KappaValue");
              XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Floors[index3].K);
              XMLobj.WriteEndElement();
            }
            else if (SAP_Module.Proj.Dwellings[House].NoofFloors <= SAP_Module.Proj.Dwellings[House].Storeys)
            {
              if (SAP_Module.Proj.Dwellings[House].NoofIFloors > 0)
              {
                try
                {
                  if ((double) SAP_Module.Proj.Dwellings[House].IFloors[index1].K > 0.0)
                  {
                    XMLobj.WriteStartElement("KappaValue");
                    XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].IFloors[index1].K);
                    XMLobj.WriteEndElement();
                    checked { ++index1; }
                  }
                }
                catch (Exception ex)
                {
                  ProjectData.SetProjectError(ex);
                  ProjectData.ClearProjectError();
                }
              }
              if (SAP_Module.Proj.Dwellings[House].NoofICeilings > 0)
              {
                try
                {
                  if ((double) SAP_Module.Proj.Dwellings[House].ICeilings[index2].K > 0.0)
                  {
                    XMLobj.WriteStartElement("KappaValueFromBelow");
                    XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].ICeilings[index2].K);
                    XMLobj.WriteEndElement();
                    checked { ++index2; }
                  }
                }
                catch (Exception ex)
                {
                  ProjectData.SetProjectError(ex);
                  ProjectData.ClearProjectError();
                }
              }
            }
          }
          else if (SAP_Module.Proj.Dwellings[House].NoofFloors <= SAP_Module.Proj.Dwellings[House].Storeys)
          {
            if (SAP_Module.Proj.Dwellings[House].NoofIFloors > 0)
            {
              try
              {
                if ((double) SAP_Module.Proj.Dwellings[House].IFloors[index1].K > 0.0)
                {
                  XMLobj.WriteStartElement("KappaValue");
                  XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].IFloors[index1].K);
                  XMLobj.WriteEndElement();
                  checked { ++index1; }
                }
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
              }
            }
            if (SAP_Module.Proj.Dwellings[House].NoofICeilings > 0)
            {
              try
              {
                if ((double) SAP_Module.Proj.Dwellings[House].ICeilings[index2].K > 0.0)
                {
                  XMLobj.WriteStartElement("KappaValueFromBelow");
                  XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].ICeilings[index2].K);
                  XMLobj.WriteEndElement();
                  checked { ++index2; }
                }
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
              }
            }
          }
          XMLobj.WriteEndElement();
          checked { ++index3; }
        }
        XMLobj.WriteEndElement();
      }
      else
      {
        XMLobj.WriteStartElement("FloorDimensions");
        int num4 = 0;
        XMLobj.WriteStartElement("FloorDimension");
        XMLobj.WriteStartElement("Storey");
        if (SAP_Module.Proj.Dwellings[House].Dims[0].Basement == null)
          SAP_Module.Proj.Dwellings[House].Dims[0].Basement = "";
        if (Operators.CompareString(SAP_Module.Proj.Dwellings[House].Dims[0].Basement, "Yes", false) == 0)
        {
          XMLobj.WriteValue(-1);
          XMLobj.WriteEndElement();
        }
        else
        {
          XMLobj.WriteValue(0);
          XMLobj.WriteEndElement();
        }
        int num5 = checked (num4 + 1);
        XMLobj.WriteStartElement("FloorType");
        XMLobj.WriteValue(4);
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("TotalFloorArea");
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Dims[0].Area);
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("StoreyHeight");
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Dims[0].Height);
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("HeatLossArea");
        if (checked (SAP_Module.Proj.Dwellings[House].NoofFloors - 1) >= 0)
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Floors[0].Area);
        else
          XMLobj.WriteValue(0);
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("UValue");
        XMLobj.WriteValue(0);
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("KappaValue");
        XMLobj.WriteValue(40);
        XMLobj.WriteEndElement();
        XMLobj.WriteEndElement();
        XMLobj.WriteEndElement();
      }
    }

    private void _BuildingPartsRoofs(XmlTextWriter XMLobj, int House, int Country)
    {
      XMLobj.WriteStartElement("Roofs");
      if (SAP_Module.Proj.Dwellings[House].NoofRoofs == 0)
      {
        XMLobj.WriteStartElement("Roof");
        XMLobj.WriteStartElement("Name");
        XMLobj.WriteValue("Exposed Roof");
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("Description");
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("RoofType");
        XMLobj.WriteValue(2);
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("TotalRoofArea");
        XMLobj.WriteValue(0);
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("UValue");
        XMLobj.WriteValue(0);
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("KappaValue");
        if (SAP_Module.Proj.Dwellings[House].NoofRoofs > 0)
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Roofs[0].K);
        else
          XMLobj.WriteValue(0);
        XMLobj.WriteEndElement();
        XMLobj.WriteEndElement();
      }
      else
      {
        int num = checked (SAP_Module.Proj.Dwellings[House].NoofRoofs - 1);
        int index = 0;
        while (index <= num)
        {
          XMLobj.WriteStartElement("Roof");
          XMLobj.WriteStartElement("Name");
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Roofs[index].Name);
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("Description");
          if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Roofs[index].Name != null)
            XMLobj.WriteValue(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Roofs[index].Name);
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("RoofType");
          XMLobj.WriteValue(2);
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("TotalRoofArea");
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Roofs[index].Area);
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("UValue");
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Roofs[index].U_Value);
          XMLobj.WriteEndElement();
          if ((double) SAP_Module.Proj.Dwellings[House].Roofs[index].K > 0.0)
          {
            XMLobj.WriteStartElement("KappaValue");
            XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Roofs[index].K);
            XMLobj.WriteEndElement();
          }
          XMLobj.WriteEndElement();
          checked { ++index; }
        }
      }
      int num1 = checked (SAP_Module.Proj.Dwellings[House].NoofPCeilings - 1);
      int index1 = 0;
      while (index1 <= num1)
      {
        XMLobj.WriteStartElement("Roof");
        XMLobj.WriteStartElement("Name");
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].PCeilings[index1].Name);
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("Description");
        if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PCeilings[index1].Name != null)
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PCeilings[index1].Name);
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("RoofType");
        XMLobj.WriteValue(4);
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("TotalRoofArea");
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].PCeilings[index1].Area);
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("UValue");
        XMLobj.WriteValue(0);
        XMLobj.WriteEndElement();
        if ((double) SAP_Module.Proj.Dwellings[House].PCeilings[index1].K > 0.0)
        {
          XMLobj.WriteStartElement("KappaValue");
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].PCeilings[index1].K);
          XMLobj.WriteEndElement();
        }
        XMLobj.WriteEndElement();
        checked { ++index1; }
      }
      XMLobj.WriteEndElement();
    }

    private void _BuildingPartsWalls(XmlTextWriter XMLobj, int House, int Country)
    {
      XMLobj.WriteStartElement("Walls");
      int num1 = checked (SAP_Module.Proj.Dwellings[House].NoofWalls - 1);
      int index1 = 0;
      while (index1 <= num1)
      {
        XMLobj.WriteStartElement("Wall");
        XMLobj.WriteStartElement("Name");
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Walls[index1].Name);
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("Description");
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("WallType");
        string type = SAP_Module.Proj.Dwellings[House].Walls[index1].Type;
        if (Operators.CompareString(type, "Basement wall", false) != 0)
        {
          if (Operators.CompareString(type, "Exposed wall", false) != 0)
          {
            if (Operators.CompareString(type, "Sheltered wall", false) == 0)
              XMLobj.WriteValue("3");
          }
          else
            XMLobj.WriteValue("2");
        }
        else
          XMLobj.WriteValue("1");
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("TotalWallArea");
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Walls[index1].Area);
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("UValue");
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Walls[index1].U_Value);
        XMLobj.WriteEndElement();
        if ((double) SAP_Module.Proj.Dwellings[House].Walls[index1].K > 0.0)
        {
          XMLobj.WriteStartElement("KappaValue");
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Walls[index1].K);
          XMLobj.WriteEndElement();
        }
        if (!SAP_Module.Proj.Dwellings[House].Walls[index1].Type.Contains("ment"))
        {
          XMLobj.WriteStartElement("IsCurtainWalling");
          if (SAP_Module.Proj.Dwellings[House].Walls[index1].Curtain)
            XMLobj.WriteValue("true");
          else
            XMLobj.WriteValue("false");
          XMLobj.WriteEndElement();
        }
        XMLobj.WriteEndElement();
        checked { ++index1; }
      }
      int num2 = checked (SAP_Module.Proj.Dwellings[House].NoofIWalls - 1);
      int index2 = 0;
      while (index2 <= num2)
      {
        XMLobj.WriteStartElement("Wall");
        XMLobj.WriteStartElement("Name");
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].IWalls[index2].Name);
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("WallType");
        XMLobj.WriteValue("5");
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("TotalWallArea");
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].IWalls[index2].Area);
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("UValue");
        XMLobj.WriteValue(0);
        XMLobj.WriteEndElement();
        if ((double) SAP_Module.Proj.Dwellings[House].IWalls[index2].K > 0.0)
        {
          XMLobj.WriteStartElement("KappaValue");
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].IWalls[index2].K);
          XMLobj.WriteEndElement();
        }
        XMLobj.WriteEndElement();
        checked { ++index2; }
      }
      int num3 = checked (SAP_Module.Proj.Dwellings[House].NoofPWalls - 1);
      int index3 = 0;
      while (index3 <= num3)
      {
        XMLobj.WriteStartElement("Wall");
        XMLobj.WriteStartElement("Name");
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].PWalls[index3].Name);
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("WallType");
        XMLobj.WriteValue("4");
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("TotalWallArea");
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].PWalls[index3].Area);
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("UValue");
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].PWalls[index3].U_Value);
        XMLobj.WriteEndElement();
        if ((double) SAP_Module.Proj.Dwellings[House].PWalls[index3].K > 0.0)
        {
          XMLobj.WriteStartElement("KappaValue");
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].PWalls[index3].K);
          XMLobj.WriteEndElement();
        }
        XMLobj.WriteEndElement();
        checked { ++index3; }
      }
      XMLobj.WriteEndElement();
    }

    private void _BuildingPartsThermalmass(XmlTextWriter XMLobj, int House, int Country)
    {
      XMLobj.WriteStartElement("ThermalMassParameter");
      XMLobj.WriteValue(Math.Round(SAP_Module.Calculation2012.Calculation.HeatLoss.Box35, 2));
      XMLobj.WriteEndElement();
    }

    private void _SAP09DataPropertyDetails_Ventilation(
      XmlTextWriter XMLobj,
      int House,
      int Country)
    {
      float num1;
      if (Country == 2)
      {
        if ((double) SAP_Module.Proj.Dwellings[House].Ventilation.DesignAir != 0.0)
          num1 = SAP_Module.Proj.Dwellings[House].Ventilation.DesignAir;
        if ((double) SAP_Module.Proj.Dwellings[House].Ventilation.MeasuredAir != 0.0)
          num1 = SAP_Module.Proj.Dwellings[House].Ventilation.MeasuredAir;
      }
      else
      {
        if (SAP_Module.Proj.Dwellings[House].Ventilation.AveragePerm)
          num1 = Operators.CompareString(SAP_Module.Proj.Dwellings[House].Ventilation.Pressure, "As built", false) != 0 ? SAP_Module.Proj.Dwellings[House].Ventilation.DesignAir : SAP_Module.Proj.Dwellings[House].Ventilation.MeasuredAir;
        else if ((double) SAP_Module.Proj.Dwellings[House].Ventilation.DesignAir != 0.0)
          num1 = SAP_Module.Proj.Dwellings[House].Ventilation.DesignAir;
        else if ((double) SAP_Module.Proj.Dwellings[House].Ventilation.MeasuredAir != 0.0)
          num1 = SAP_Module.Proj.Dwellings[House].Ventilation.MeasuredAir;
        else if ((double) SAP_Module.Proj.Dwellings[House].Ventilation.AssumedAir != 0.0)
          num1 = SAP_Module.Proj.Dwellings[House].Ventilation.MeasuredAir;
        if ((double) SAP_Module.Proj.Dwellings[House].Ventilation.AssumedAir != 0.0)
          num1 = SAP_Module.Proj.Dwellings[House].Ventilation.AssumedAir;
      }
      XMLobj.WriteStartElement("Ventilation");
      XMLobj.WriteStartElement("OpenFireplacesCount");
      XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Ventilation.Chimneys);
      XMLobj.WriteEndElement();
      XMLobj.WriteStartElement("OpenFluesCount");
      XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Ventilation.Flues);
      XMLobj.WriteEndElement();
      XMLobj.WriteStartElement("ExtractFansCount");
      XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Ventilation.Fans);
      XMLobj.WriteEndElement();
      XMLobj.WriteStartElement("PSVCount");
      XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Ventilation.Vents);
      XMLobj.WriteEndElement();
      XMLobj.WriteStartElement("FluelessGasFiresCount");
      XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Ventilation.Fires);
      XMLobj.WriteEndElement();
      XMLobj.WriteStartElement("PressureTest");
      if (SAP_Module.Proj.Dwellings[House].Ventilation.AveragePerm)
        XMLobj.WriteValue("5");
      else if (Operators.CompareString(SAP_Module.Proj.Dwellings[House].Status, "Existing dwelling (SAP)", false) == 0 & Operators.CompareString(SAP_Module.Proj.Dwellings[House].Ventilation.Pressure, "Calculated", false) == 0)
      {
        XMLobj.WriteValue("6");
      }
      else
      {
        string pressure = SAP_Module.Proj.Dwellings[House].Ventilation.Pressure;
        // ISSUE: reference to a compiler-generated method
        switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(pressure))
        {
          case 336955853:
            if (Operators.CompareString(pressure, "As built", false) == 0)
              break;
            goto default;
          case 774849489:
            if (Operators.CompareString(pressure, "Assumed", false) == 0)
            {
              XMLobj.WriteValue("3");
              goto default;
            }
            else
              goto default;
          case 864291923:
            if (Operators.CompareString(pressure, "As measured", false) == 0)
              break;
            goto default;
          case 1158145841:
            if (Operators.CompareString(pressure, "Calculated", false) == 0)
              goto label_32;
            else
              goto default;
          case 1647734778:
            if (Operators.CompareString(pressure, "no", false) == 0)
              goto label_32;
            else
              goto default;
          case 1942325214:
            if (Operators.CompareString(pressure, "yes (design value)", false) == 0)
              goto label_30;
            else
              goto default;
          case 2121038188:
            if (Operators.CompareString(pressure, "As designed", false) == 0)
              goto label_30;
            else
              goto default;
          default:
label_33:
            goto label_34;
        }
        XMLobj.WriteValue("1");
        goto label_33;
label_30:
        XMLobj.WriteValue("2");
        goto label_33;
label_32:
        XMLobj.WriteValue("4");
        goto label_33;
      }
label_34:
      XMLobj.WriteEndElement();
      if ((uint) Operators.CompareString(SAP_Module.Proj.Dwellings[House].Ventilation.Pressure, "Calculated", false) > 0U & (uint) Operators.CompareString(SAP_Module.Proj.Dwellings[House].Ventilation.Pressure, "As built", false) > 0U)
      {
        XMLobj.WriteStartElement("AirPermeability");
        XMLobj.WriteValue(num1);
        XMLobj.WriteEndElement();
      }
      else if (Operators.CompareString(SAP_Module.Proj.Dwellings[House].Ventilation.Pressure, "As built", false) == 0)
      {
        XMLobj.WriteStartElement("AirPermeability");
        XMLobj.WriteValue(num1);
        XMLobj.WriteEndElement();
      }
      XMLobj.WriteStartElement("ShelteredSidesCount");
      XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Ventilation.Shelter);
      XMLobj.WriteEndElement();
      XMLobj.WriteStartElement("VentilationType");
      string mechVent1 = SAP_Module.Proj.Dwellings[House].Ventilation.MechVent;
      // ISSUE: reference to a compiler-generated method
      switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(mechVent1))
      {
        case 428439872:
          if (Operators.CompareString(mechVent1, "natural with intermittent extract fans", false) == 0)
            break;
          goto default;
        case 625191264:
          if (Operators.CompareString(mechVent1, "Balanced without heat recovery", false) == 0)
          {
            XMLobj.WriteValue("7");
            goto default;
          }
          else
            goto default;
        case 918396964:
          if (Operators.CompareString(mechVent1, "Decentralised whole house extract", false) == 0)
          {
            XMLobj.WriteValue("6");
            goto default;
          }
          else
            goto default;
        case 1101494137:
          if (Operators.CompareString(mechVent1, "Centralised whole house extract", false) == 0)
          {
            XMLobj.WriteValue("5");
            goto default;
          }
          else
            goto default;
        case 2533751361:
          if (Operators.CompareString(mechVent1, "Positive input from loft", false) == 0)
          {
            XMLobj.WriteValue("3");
            goto default;
          }
          else
            goto default;
        case 3118369032:
          if (Operators.CompareString(mechVent1, "natural with intermittent extract fans and passive vents", false) == 0)
          {
            XMLobj.WriteValue("10");
            goto default;
          }
          else
            goto default;
        case 3225008057:
          if (Operators.CompareString(mechVent1, "Positive input from outside", false) == 0)
          {
            XMLobj.WriteValue("4");
            goto default;
          }
          else
            goto default;
        case 3236691049:
          if (Operators.CompareString(mechVent1, "Natural ventilation", false) == 0)
            break;
          goto default;
        case 3255421954:
          if (Operators.CompareString(mechVent1, "Balanced with heat recovery", false) == 0)
          {
            XMLobj.WriteValue("8");
            goto default;
          }
          else
            goto default;
        default:
label_66:
          XMLobj.WriteEndElement();
          string mechVent2 = SAP_Module.Proj.Dwellings[House].Ventilation.MechVent;
          if (Operators.CompareString(mechVent2, "Natural ventilation", false) != 0 && Operators.CompareString(mechVent2, "natural with intermittent extract fans", false) != 0 && Operators.CompareString(mechVent2, "Positive input from loft", false) != 0)
          {
            XMLobj.WriteStartElement("IsMechanicalVentApprovedInstallerScheme");
            if (SAP_Module.Proj.Dwellings[House].Ventilation.ApprovedScheme)
              XMLobj.WriteValue("true");
            else
              XMLobj.WriteValue("false");
            XMLobj.WriteEndElement();
          }
          string mechVent3 = SAP_Module.Proj.Dwellings[House].Ventilation.MechVent;
          if (Operators.CompareString(mechVent3, "Balanced without heat recovery", false) != 0 && Operators.CompareString(mechVent3, "Positive input from outside", false) != 0)
          {
            if (Operators.CompareString(mechVent3, "Balanced with heat recovery", false) != 0 && Operators.CompareString(mechVent3, "Centralised whole house extract", false) != 0)
            {
              if (Operators.CompareString(mechVent3, "Decentralised whole house extract", false) == 0)
              {
                XMLobj.WriteStartElement("MechanicalVentilationDataSource");
                string parameters = SAP_Module.Proj.Dwellings[House].Ventilation.Parameters;
                if (Operators.CompareString(parameters, "User defined", false) != 0)
                {
                  if (Operators.CompareString(parameters, "SAP 2005", false) != 0 && Operators.CompareString(parameters, "SAP 2012", false) != 0)
                  {
                    if (Operators.CompareString(parameters, "Database", false) == 0)
                    {
                      XMLobj.WriteValue(1);
                      XMLobj.WriteEndElement();
                      XMLobj.WriteStartElement("MechanicalVentSystemIndexNumber");
                      XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Ventilation.ProductID);
                      XMLobj.WriteEndElement();
                      XMLobj.WriteStartElement("WetRoomsCount");
                      int num2 = checked ((int) Math.Round(Math.Round(unchecked (1.0 + (double) SAP_Module.Proj.Dwellings[House].Ventilation.Decentralised.OTP1 + (double) SAP_Module.Proj.Dwellings[House].Ventilation.Decentralised.OTP2 + (double) SAP_Module.Proj.Dwellings[House].Ventilation.Decentralised.OTP3), 0)));
                      XMLobj.WriteValue(num2);
                      XMLobj.WriteEndElement();
                      if (Operators.CompareString(SAP_Module.Proj.Dwellings[House].Ventilation.Parameters, "Database", false) == 0)
                      {
                        PCDF.Products322 products322 = SAP_Module.PCDFData.Products322s.Where<PCDF.Products322>((Func<PCDF.Products322, bool>) (b => b.ID.Equals(SAP_Module.Proj.Dwellings[House].Ventilation.ProductID.ToString()))).SingleOrDefault<PCDF.Products322>();
                        XMLobj.WriteStartElement("MechanicalVentDuctType");
                        if (products322 == null)
                          XMLobj.WriteValue("2");
                        else
                          XMLobj.WriteValue(products322.DuctingType);
                        XMLobj.WriteEndElement();
                      }
                      else
                      {
                        XMLobj.WriteStartElement("MechanicalVentDuctType");
                        string ductType = SAP_Module.Proj.Dwellings[House].Ventilation.DuctType;
                        if (Operators.CompareString(ductType, "Rigid", false) != 0)
                        {
                          if (Operators.CompareString(ductType, "Semirigid", false) != 0)
                          {
                            if (Operators.CompareString(ductType, "Flexible", false) == 0)
                              XMLobj.WriteValue(1);
                          }
                          else
                            XMLobj.WriteValue(3);
                        }
                        else
                          XMLobj.WriteValue(2);
                        XMLobj.WriteEndElement();
                      }
                    }
                  }
                  else
                  {
                    XMLobj.WriteValue(3);
                    XMLobj.WriteEndElement();
                  }
                }
                else
                {
                  XMLobj.WriteValue(2);
                  XMLobj.WriteEndElement();
                  XMLobj.WriteStartElement("MechanicalVentSystemMakeModel");
                  XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Ventilation.MVDetails.ProductName);
                  XMLobj.WriteEndElement();
                  XMLobj.WriteStartElement("WetRoomsCount");
                  XMLobj.WriteValue(Math.Round(1.0 + (double) SAP_Module.Proj.Dwellings[House].Ventilation.Decentralised.OTP1 + (double) SAP_Module.Proj.Dwellings[House].Ventilation.Decentralised.OTP2 + (double) SAP_Module.Proj.Dwellings[House].Ventilation.Decentralised.OTP3, 0));
                  XMLobj.WriteEndElement();
                  XMLobj.WriteStartElement("MechanicalVentDuctType");
                  string ductingType = SAP_Module.Proj.Dwellings[House].Ventilation.MVDetails.DuctingType;
                  if (Operators.CompareString(ductingType, "Rigid", false) != 0)
                  {
                    if (Operators.CompareString(ductingType, "Semirigid", false) != 0)
                    {
                      if (Operators.CompareString(ductingType, "Flexible", false) == 0)
                        XMLobj.WriteValue(1);
                    }
                    else
                      XMLobj.WriteValue(3);
                  }
                  else
                    XMLobj.WriteValue(2);
                  XMLobj.WriteEndElement();
                }
                if (Operators.CompareString(SAP_Module.Proj.Dwellings[House].Ventilation.Parameters, "User defined", false) == 0 | Operators.CompareString(SAP_Module.Proj.Dwellings[House].Ventilation.Parameters, "Database", false) == 0)
                {
                  XMLobj.WriteStartElement("KitchenRoomFansCount");
                  XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Ventilation.Decentralised.KTP1);
                  XMLobj.WriteEndElement();
                }
                if (Operators.CompareString(SAP_Module.Proj.Dwellings[House].Ventilation.Parameters, "User defined", false) == 0)
                {
                  XMLobj.WriteStartElement("KitchenRoomFansSpecificPower");
                  XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Ventilation.Decentralised.KSPF1);
                  XMLobj.WriteEndElement();
                }
                if (Operators.CompareString(SAP_Module.Proj.Dwellings[House].Ventilation.Parameters, "User defined", false) == 0 | Operators.CompareString(SAP_Module.Proj.Dwellings[House].Ventilation.Parameters, "Database", false) == 0)
                {
                  XMLobj.WriteStartElement("NonKitchenRoomFansCount");
                  XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Ventilation.Decentralised.OTP1);
                  XMLobj.WriteEndElement();
                }
                if (Operators.CompareString(SAP_Module.Proj.Dwellings[House].Ventilation.Parameters, "User defined", false) == 0)
                {
                  XMLobj.WriteStartElement("NonKitchenRoomFansSpecificPower");
                  XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Ventilation.Decentralised.OSPF1);
                  XMLobj.WriteEndElement();
                }
                if (Operators.CompareString(SAP_Module.Proj.Dwellings[House].Ventilation.Parameters, "User defined", false) == 0 | Operators.CompareString(SAP_Module.Proj.Dwellings[House].Ventilation.Parameters, "Database", false) == 0)
                {
                  XMLobj.WriteStartElement("KitchenDuctFansCount");
                  XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Ventilation.Decentralised.KTP2);
                  XMLobj.WriteEndElement();
                }
                if (Operators.CompareString(SAP_Module.Proj.Dwellings[House].Ventilation.Parameters, "User defined", false) == 0)
                {
                  XMLobj.WriteStartElement("KitchenDuctFansSpecificPower");
                  XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Ventilation.Decentralised.KSPF2);
                  XMLobj.WriteEndElement();
                }
                if (Operators.CompareString(SAP_Module.Proj.Dwellings[House].Ventilation.Parameters, "User defined", false) == 0 | Operators.CompareString(SAP_Module.Proj.Dwellings[House].Ventilation.Parameters, "Database", false) == 0)
                {
                  XMLobj.WriteStartElement("NonKitchenDuctFansCount");
                  XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Ventilation.Decentralised.OTP2);
                  XMLobj.WriteEndElement();
                }
                if (Operators.CompareString(SAP_Module.Proj.Dwellings[House].Ventilation.Parameters, "User defined", false) == 0)
                {
                  XMLobj.WriteStartElement("NonKitchenDuctFansSpecificPower");
                  XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Ventilation.Decentralised.OSPF2);
                  XMLobj.WriteEndElement();
                }
                if (Operators.CompareString(SAP_Module.Proj.Dwellings[House].Ventilation.Parameters, "User defined", false) == 0 | Operators.CompareString(SAP_Module.Proj.Dwellings[House].Ventilation.Parameters, "Database", false) == 0)
                {
                  XMLobj.WriteStartElement("KitchenWallFansCount");
                  XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Ventilation.Decentralised.KTP3);
                  XMLobj.WriteEndElement();
                }
                if (Operators.CompareString(SAP_Module.Proj.Dwellings[House].Ventilation.Parameters, "User defined", false) == 0)
                {
                  XMLobj.WriteStartElement("KitchenWallFansSpecificPower");
                  XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Ventilation.Decentralised.KSPF3);
                  XMLobj.WriteEndElement();
                }
                if (Operators.CompareString(SAP_Module.Proj.Dwellings[House].Ventilation.Parameters, "User defined", false) == 0 | Operators.CompareString(SAP_Module.Proj.Dwellings[House].Ventilation.Parameters, "Database", false) == 0)
                {
                  XMLobj.WriteStartElement("NonKitchenWallFansCount");
                  XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Ventilation.Decentralised.OTP3);
                  XMLobj.WriteEndElement();
                }
                if (Operators.CompareString(SAP_Module.Proj.Dwellings[House].Ventilation.Parameters, "User defined", false) == 0)
                {
                  XMLobj.WriteStartElement("NonKitchenWallFansSpecificPower");
                  XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Ventilation.Decentralised.OSPF3);
                  XMLobj.WriteEndElement();
                }
              }
            }
            else
            {
              XMLobj.WriteStartElement("MechanicalVentilationDataSource");
              string parameters = SAP_Module.Proj.Dwellings[House].Ventilation.Parameters;
              if (Operators.CompareString(parameters, "User defined", false) != 0)
              {
                if (Operators.CompareString(parameters, "SAP 2005", false) != 0 && Operators.CompareString(parameters, "SAP 2009", false) != 0 && Operators.CompareString(parameters, "SAP 2012", false) != 0)
                {
                  if (Operators.CompareString(parameters, "Database", false) == 0)
                    XMLobj.WriteValue(1);
                }
                else
                  XMLobj.WriteValue(3);
              }
              else
                XMLobj.WriteValue(2);
              XMLobj.WriteEndElement();
              if ((uint) Operators.CompareString(SAP_Module.Proj.Dwellings[House].Ventilation.Parameters, "Database", false) > 0U & (uint) Operators.CompareString(SAP_Module.Proj.Dwellings[House].Ventilation.Parameters, "SAP 2012", false) > 0U)
              {
                XMLobj.WriteStartElement("MechanicalVentSystemMakeModel");
                XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Ventilation.MVDetails.ProductName);
                XMLobj.WriteEndElement();
                XMLobj.WriteStartElement("MechanicalVentSpecificFanPower");
                XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Ventilation.MVDetails.SFP);
                XMLobj.WriteEndElement();
                if ((double) SAP_Module.Proj.Dwellings[House].Ventilation.MVDetails.HEE != 0.0)
                {
                  XMLobj.WriteStartElement("MechanicalVentHeatRecoveryEfficiency");
                  XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Ventilation.MVDetails.HEE);
                  XMLobj.WriteEndElement();
                }
                XMLobj.WriteStartElement("WetRoomsCount");
                XMLobj.WriteValue(checked (SAP_Module.Proj.Dwellings[House].Ventilation.WetRooms + 1));
                XMLobj.WriteEndElement();
                if (Conversions.ToDouble(SAP_Module.Proj.Dwellings[House].Ventilation.MVDetails.DuctProductID) != 0.0)
                {
                  XMLobj.WriteStartElement("MechanicalVentDuctsIndexNumber");
                  XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Ventilation.MVDetails.DuctProductID);
                  XMLobj.WriteEndElement();
                }
                if ((uint) Operators.CompareString(SAP_Module.Proj.Dwellings[House].Ventilation.MVDetails.DuctingType, "", false) > 0U && Operators.CompareString(SAP_Module.Proj.Dwellings[House].Ventilation.MechVent, "Balanced with heat recovery", false) == 0)
                {
                  XMLobj.WriteStartElement("MechanicalVentDuctInsulation");
                  if (Operators.CompareString(SAP_Module.Proj.Dwellings[House].Ventilation.DuctType, "Insulation", false) == 0)
                    XMLobj.WriteValue(2);
                  else
                    XMLobj.WriteValue(1);
                  XMLobj.WriteEndElement();
                }
                XMLobj.WriteStartElement("MechanicalVentDuctType");
                if (Operators.CompareString(SAP_Module.Proj.Dwellings[House].Ventilation.MVDetails.DuctingType, "Flexible", false) == 0)
                  XMLobj.WriteValue(1);
                else if (Operators.CompareString(SAP_Module.Proj.Dwellings[House].Ventilation.MVDetails.DuctingType, "Semirigid", false) == 0)
                  XMLobj.WriteValue(3);
                else
                  XMLobj.WriteValue(2);
                XMLobj.WriteEndElement();
              }
              else if (Operators.CompareString(SAP_Module.Proj.Dwellings[House].Ventilation.Parameters, "Database", false) == 0)
              {
                XMLobj.WriteStartElement("MechanicalVentSystemIndexNumber");
                XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Ventilation.ProductID);
                XMLobj.WriteEndElement();
                XMLobj.WriteStartElement("WetRoomsCount");
                XMLobj.WriteValue(checked (SAP_Module.Proj.Dwellings[House].Ventilation.WetRooms + 1));
                XMLobj.WriteEndElement();
                if ((uint) Operators.CompareString(SAP_Module.Proj.Dwellings[House].Ventilation.Parameters, "SAP 2012", false) > 0U && Operators.CompareString(SAP_Module.Proj.Dwellings[House].Ventilation.MechVent, "Balanced with heat recovery", false) == 0 && (uint) Operators.CompareString(SAP_Module.Proj.Dwellings[House].Ventilation.DuctType, "", false) > 0U)
                {
                  XMLobj.WriteStartElement("MechanicalVentDuctInsulation");
                  if (Operators.CompareString(SAP_Module.Proj.Dwellings[House].Ventilation.DuctType, "Insulation", false) == 0)
                    XMLobj.WriteValue(2);
                  else
                    XMLobj.WriteValue(1);
                  XMLobj.WriteEndElement();
                }
                PCDF.Products321 products321 = SAP_Module.PCDFData.Products321s.Where<PCDF.Products321>((Func<PCDF.Products321, bool>) (b => b.ID.Equals(SAP_Module.Proj.Dwellings[House].Ventilation.ProductID.ToString()))).SingleOrDefault<PCDF.Products321>();
                XMLobj.WriteStartElement("MechanicalVentDuctType");
                if (products321 == null)
                  XMLobj.WriteValue("2");
                else
                  XMLobj.WriteValue(products321.DuctingType);
                XMLobj.WriteEndElement();
              }
            }
          }
          else
          {
            XMLobj.WriteStartElement("MechanicalVentilationDataSource");
            string parameters1 = SAP_Module.Proj.Dwellings[House].Ventilation.Parameters;
            if (Operators.CompareString(parameters1, "User defined", false) != 0)
            {
              if (Operators.CompareString(parameters1, "SAP 2005", false) != 0 && Operators.CompareString(parameters1, "SAP 2009", false) != 0 && Operators.CompareString(parameters1, "SAP 2012", false) != 0)
              {
                if (Operators.CompareString(parameters1, "Database", false) == 0)
                  XMLobj.WriteValue(1);
              }
              else
                XMLobj.WriteValue(3);
            }
            else
              XMLobj.WriteValue(2);
            XMLobj.WriteEndElement();
            bool flag = true;
            if (Operators.CompareString(SAP_Module.Proj.Dwellings[House].Ventilation.Parameters, "Manufacturer Declaration", false) == 0 | Operators.CompareString(SAP_Module.Proj.Dwellings[House].Ventilation.Parameters, "User defined", false) == 0)
            {
              XMLobj.WriteStartElement("MechanicalVentSystemMakeModel");
              XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Ventilation.MVDetails.ProductName);
              XMLobj.WriteEndElement();
              XMLobj.WriteStartElement("MechanicalVentSpecificFanPower");
              XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Ventilation.MVDetails.SFP);
              XMLobj.WriteEndElement();
              XMLobj.WriteStartElement("WetRoomsCount");
              XMLobj.WriteValue(checked (SAP_Module.Proj.Dwellings[House].Ventilation.WetRooms + 1));
              XMLobj.WriteEndElement();
              XMLobj.WriteStartElement("MechanicalVentDuctType");
              if (Operators.CompareString(SAP_Module.Proj.Dwellings[House].Ventilation.MVDetails.DuctingType, "Flexible", false) == 0)
                XMLobj.WriteValue(1);
              else if (Operators.CompareString(SAP_Module.Proj.Dwellings[House].Ventilation.DuctType, "Semirigid", false) == 0)
                XMLobj.WriteValue(3);
              else
                XMLobj.WriteValue(2);
              XMLobj.WriteEndElement();
            }
            if (Operators.CompareString(SAP_Module.Proj.Dwellings[House].Ventilation.MechVent, "Positive input from outside", false) == 0)
            {
              string parameters2 = SAP_Module.Proj.Dwellings[House].Ventilation.Parameters;
              if (Operators.CompareString(parameters2, "SAP 2005", false) != 0 && Operators.CompareString(parameters2, "SAP 2009", false) != 0 && Operators.CompareString(parameters2, "SAP 2012", false) != 0 && !flag)
              {
                XMLobj.WriteStartElement("MechanicalVentSystemMakeModel");
                XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Ventilation.MVDetails.ProductName);
                XMLobj.WriteEndElement();
                XMLobj.WriteStartElement("MechanicalVentSpecificFanPower");
                XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Ventilation.MVDetails.SFP);
                XMLobj.WriteEndElement();
                XMLobj.WriteStartElement("WetRoomsCount");
                XMLobj.WriteValue(Math.Round(1.0 + (double) SAP_Module.Proj.Dwellings[House].Ventilation.Decentralised.OTP1 + (double) SAP_Module.Proj.Dwellings[House].Ventilation.Decentralised.OTP2 + (double) SAP_Module.Proj.Dwellings[House].Ventilation.Decentralised.OTP3, 0));
                XMLobj.WriteEndElement();
                XMLobj.WriteStartElement("MechanicalVentDuctType");
                if (Operators.CompareString(SAP_Module.Proj.Dwellings[House].Ventilation.DuctType, "UnInsulated", false) == 0)
                  XMLobj.WriteValue(1);
                else
                  XMLobj.WriteValue(2);
                XMLobj.WriteEndElement();
              }
            }
          }
          if (Operators.CompareString(SAP_Module.Proj.Dwellings[House].Ventilation.Pressure, "Calculated", false) == 0 && SAP_Module.Proj.Dwellings[House].Ventilation.Infiltration.Lobby.Contains("Draught"))
          {
            XMLobj.WriteStartElement("HasDraughtLobby");
            if (Operators.CompareString(SAP_Module.Proj.Dwellings[House].Ventilation.Infiltration.Lobby, "Draught Lobby", false) == 0)
              XMLobj.WriteValue(true);
            else
              XMLobj.WriteValue(false);
            XMLobj.WriteEndElement();
            XMLobj.WriteStartElement("DraughtStripping");
            XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Ventilation.Infiltration.DraguthP);
            XMLobj.WriteEndElement();
          }
          XMLobj.WriteEndElement();
          return;
      }
      if (SAP_Module.Proj.Dwellings[House].Ventilation.Fans > 0 & SAP_Module.Proj.Dwellings[House].Ventilation.Vents == 0)
      {
        XMLobj.WriteValue("1");
        goto label_66;
      }
      else if (SAP_Module.Proj.Dwellings[House].Ventilation.Fans > 0 & SAP_Module.Proj.Dwellings[House].Ventilation.Vents > 0)
      {
        XMLobj.WriteValue("10");
        goto label_66;
      }
      else if (SAP_Module.Proj.Dwellings[House].Ventilation.Vents > 0 & SAP_Module.Proj.Dwellings[House].Ventilation.Fans == 0)
      {
        XMLobj.WriteValue("2");
        goto label_66;
      }
      else if (Operators.CompareString(SAP_Module.Proj.Dwellings[House].Ventilation.MechVent, "natural with passive vents", false) == 0)
      {
        XMLobj.WriteValue("2");
        goto label_66;
      }
      else if (SAP_Module.Proj.Dwellings[House].Ventilation.Vents > 0 & SAP_Module.Proj.Dwellings[House].Ventilation.Fans > 0)
      {
        XMLobj.WriteValue("9");
        goto label_66;
      }
      else
      {
        XMLobj.WriteValue("1");
        goto label_66;
      }
    }

    private void _BuildingPartsThermal_Bridges(XmlTextWriter XMLobj, int House, int Country)
    {
      XMLobj.WriteStartElement("ThermalBridges");
      XMLobj.WriteStartElement("ThermalBridgeCode");
      if (!SAP_Module.Proj.Dwellings[House].Thermal.ManualHtb)
      {
        if (SAP_Module.Proj.Dwellings[House].Thermal.ConstDetails.Contains("Scotland simplified"))
        {
          XMLobj.WriteValue(3);
          XMLobj.WriteEndElement();
        }
        else
        {
          XMLobj.WriteValue(1);
          XMLobj.WriteEndElement();
        }
      }
      else
      {
        XMLobj.WriteValue(5);
        XMLobj.WriteEndElement();
        try
        {
          if (SAP_Module.Proj.Dwellings[House].Thermal.ExternalJunctions != null)
          {
            int num = checked (SAP_Module.Proj.Dwellings[House].Thermal.ExternalJunctions.Count - 1);
            int index = 0;
            while (index <= num)
            {
              if (SAP_Module.Proj.Dwellings[House].Thermal.ExternalJunctions[index].Ref != null)
              {
                XMLobj.WriteStartElement("ThermalBridge");
                XMLobj.WriteStartElement("ThermalBridgeType");
                XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Thermal.ExternalJunctions[index].Ref);
                XMLobj.WriteEndElement();
                XMLobj.WriteStartElement("Length");
                XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Thermal.ExternalJunctions[index].Length);
                XMLobj.WriteEndElement();
                XMLobj.WriteStartElement("PsiValue");
                XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Thermal.ExternalJunctions[index].ThermalTransmittance);
                XMLobj.WriteEndElement();
                XMLobj.WriteStartElement("PsiValueSource");
                if (SAP_Module.Proj.Dwellings[House].Thermal.ExternalJunctions[index].IsAccredited)
                  XMLobj.WriteValue(2);
                else if (SAP_Module.Proj.Dwellings[House].Thermal.ExternalJunctions[index].IsDefault)
                  XMLobj.WriteValue(4);
                else
                  XMLobj.WriteValue(3);
                XMLobj.WriteEndElement();
                XMLobj.WriteEndElement();
              }
              checked { ++index; }
            }
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        try
        {
          if (SAP_Module.Proj.Dwellings[House].Thermal.PartyJunctions != null)
          {
            int num = checked (SAP_Module.Proj.Dwellings[House].Thermal.PartyJunctions.Count - 1);
            int index = 0;
            while (index <= num)
            {
              if (SAP_Module.Proj.Dwellings[House].Thermal.PartyJunctions[index].Ref != null)
              {
                XMLobj.WriteStartElement("ThermalBridge");
                XMLobj.WriteStartElement("ThermalBridgeType");
                XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Thermal.PartyJunctions[index].Ref);
                XMLobj.WriteEndElement();
                XMLobj.WriteStartElement("Length");
                XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Thermal.PartyJunctions[index].Length);
                XMLobj.WriteEndElement();
                XMLobj.WriteStartElement("PsiValue");
                XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Thermal.PartyJunctions[index].ThermalTransmittance);
                XMLobj.WriteEndElement();
                XMLobj.WriteStartElement("PsiValueSource");
                if (SAP_Module.Proj.Dwellings[House].Thermal.PartyJunctions[index].IsAccredited)
                  XMLobj.WriteValue(2);
                else if (SAP_Module.Proj.Dwellings[House].Thermal.PartyJunctions[index].IsDefault)
                  XMLobj.WriteValue(4);
                else
                  XMLobj.WriteValue(3);
                XMLobj.WriteEndElement();
                XMLobj.WriteEndElement();
              }
              checked { ++index; }
            }
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        try
        {
          if (SAP_Module.Proj.Dwellings[House].Thermal.RoofJunctions != null)
          {
            int num = checked (SAP_Module.Proj.Dwellings[House].Thermal.RoofJunctions.Count - 1);
            int index = 0;
            while (index <= num)
            {
              if (SAP_Module.Proj.Dwellings[House].Thermal.RoofJunctions[index].Ref != null)
              {
                XMLobj.WriteStartElement("ThermalBridge");
                XMLobj.WriteStartElement("ThermalBridgeType");
                XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Thermal.RoofJunctions[index].Ref);
                XMLobj.WriteEndElement();
                XMLobj.WriteStartElement("Length");
                XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Thermal.RoofJunctions[index].Length);
                XMLobj.WriteEndElement();
                XMLobj.WriteStartElement("PsiValue");
                XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Thermal.RoofJunctions[index].ThermalTransmittance);
                XMLobj.WriteEndElement();
                XMLobj.WriteStartElement("PsiValueSource");
                if (SAP_Module.Proj.Dwellings[House].Thermal.RoofJunctions[index].IsAccredited)
                  XMLobj.WriteValue(2);
                else if (SAP_Module.Proj.Dwellings[House].Thermal.RoofJunctions[index].IsDefault)
                  XMLobj.WriteValue(4);
                else
                  XMLobj.WriteValue(3);
                XMLobj.WriteEndElement();
                XMLobj.WriteEndElement();
              }
              checked { ++index; }
            }
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
      }
      XMLobj.WriteEndElement();
    }

    private void _CommunityHeating(XmlTextWriter XMLobj, int House, int Country)
    {
      List<PCDF.CommunityScheme_Sub> communitySchemeSubList1 = new List<PCDF.CommunityScheme_Sub>();
      List<PCDF.CommunityScheme_Sub> communitySchemeSubList2 = new List<PCDF.CommunityScheme_Sub>();
      int sapTableCode = SAP_Module.Proj.Dwellings[House].MainHeating.SAPTableCode;
      bool flag1;
      bool flag2;
      if (sapTableCode >= 306 && sapTableCode <= 310)
      {
        flag1 = true;
        XMLobj.WriteStartElement("CommunityHeatingSystems");
        XMLobj.WriteStartElement("CommunityHeatingSystem");
        flag2 = true;
        XMLobj.WriteStartElement("CommunityHeatingUse");
        if (SAP_Module.Proj.Dwellings[House].Water.SystemRef == 901)
          XMLobj.WriteValue(3);
        else
          XMLobj.WriteValue(1);
        XMLobj.WriteEndElement();
        try
        {
          if (!string.IsNullOrEmpty(SAP_Module.Proj.Dwellings[House].MainHeating.SEDBUK))
          {
            XMLobj.WriteStartElement("HeatNetworkIndexNumber");
            XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].MainHeating.SEDBUK);
            XMLobj.WriteEndElement();
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        XMLobj.WriteStartElement("CommunityHeatSources");
        XMLobj.WriteStartElement("CommunityHeatSource");
        XMLobj.WriteStartElement("HeatSourceType");
        switch (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SAPTableCode)
        {
          case 306:
            XMLobj.WriteValue(2);
            break;
          case 307:
            XMLobj.WriteValue(1);
            break;
          case 308:
            XMLobj.WriteValue(4);
            break;
          case 309:
            XMLobj.WriteValue(3);
            break;
          case 310:
            XMLobj.WriteValue(5);
            break;
        }
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("Description");
        XMLobj.WriteEndElement();
        if (SAP_Module.Proj.Dwellings[House].MainHeating.InforSource.Equals("Boiler Database") && (uint) Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.SEDBUK, "", false) > 0U)
          communitySchemeSubList1 = SAP_Module.PCDFData.CommunitySchemes_Sub.Where<PCDF.CommunityScheme_Sub>((Func<PCDF.CommunityScheme_Sub, bool>) (b => b.ID.Equals(SAP_Module.Proj.Dwellings[House].MainHeating.SEDBUK.ToString()))).ToList<PCDF.CommunityScheme_Sub>();
        if (communitySchemeSubList1.Count > 0)
        {
          if (communitySchemeSubList1[0].CommunityFuel.Equals("99"))
          {
            XMLobj.WriteStartElement("FuelType");
            XMLobj.WriteValue(99);
            XMLobj.WriteEndElement();
          }
          else
          {
            XMLobj.WriteStartElement("FuelType");
            XMLobj.WriteValue(PDFFunctions.CheckFuelCode(SAP_Module.Proj.Dwellings[House].MainHeating.Fuel));
            XMLobj.WriteEndElement();
          }
        }
        else
        {
          XMLobj.WriteStartElement("FuelType");
          XMLobj.WriteValue(PDFFunctions.CheckFuelCode(SAP_Module.Proj.Dwellings[House].MainHeating.Fuel));
          XMLobj.WriteEndElement();
        }
        XMLobj.WriteStartElement("HeatEfficiency");
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].MainHeating.CommunityH.Boiler1Efficiency);
        XMLobj.WriteEndElement();
        if ((double) SAP_Module.Proj.Dwellings[House].MainHeating.CommunityH.HeatToPowerRatio > 0.0)
        {
          XMLobj.WriteStartElement("PowerEfficiency");
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].MainHeating.CommunityH.HeatToPowerRatio);
          XMLobj.WriteEndElement();
        }
        XMLobj.WriteStartElement("HeatFraction");
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].MainHeating.CommunityH.Boiler1HeatFraction);
        XMLobj.WriteEndElement();
        XMLobj.WriteEndElement();
        if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.NoOfAdditionalHeatSources > 0)
        {
          XMLobj.WriteStartElement("CommunityHeatSource");
          XMLobj.WriteStartElement("HeatSourceType");
          switch (SAP_Module.Proj.Dwellings[House].MainHeating.CommunityH.HeatSource1.Type)
          {
            case 306:
              XMLobj.WriteValue(2);
              break;
            case 307:
              XMLobj.WriteValue(1);
              break;
            case 308:
              XMLobj.WriteValue(4);
              break;
            case 309:
              XMLobj.WriteValue(3);
              break;
            case 310:
              XMLobj.WriteValue(5);
              break;
          }
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("Description");
          XMLobj.WriteEndElement();
          if (communitySchemeSubList1.Count > 0)
          {
            if (communitySchemeSubList1[1].CommunityFuel.Equals("99"))
            {
              XMLobj.WriteStartElement("FuelType");
              XMLobj.WriteValue(99);
              XMLobj.WriteEndElement();
            }
            else
            {
              XMLobj.WriteStartElement("FuelType");
              XMLobj.WriteValue(PDFFunctions.CheckFuelCode(SAP_Module.Proj.Dwellings[House].MainHeating.CommunityH.HeatSource1.Fuel));
              XMLobj.WriteEndElement();
            }
          }
          else
          {
            XMLobj.WriteStartElement("FuelType");
            XMLobj.WriteValue(PDFFunctions.CheckFuelCode(SAP_Module.Proj.Dwellings[House].MainHeating.CommunityH.HeatSource1.Fuel));
            XMLobj.WriteEndElement();
          }
          XMLobj.WriteStartElement("HeatFraction");
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].MainHeating.CommunityH.HeatSource1.HeatFraction);
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("HeatEfficiency");
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].MainHeating.CommunityH.HeatSource1.Efficiency);
          XMLobj.WriteEndElement();
          XMLobj.WriteEndElement();
        }
        if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.NoOfAdditionalHeatSources > 1)
        {
          XMLobj.WriteStartElement("CommunityHeatSource");
          XMLobj.WriteStartElement("HeatSourceType");
          switch (SAP_Module.Proj.Dwellings[House].MainHeating.CommunityH.HeatSource2.Type)
          {
            case 306:
              XMLobj.WriteValue(2);
              break;
            case 307:
              XMLobj.WriteValue(1);
              break;
            case 308:
              XMLobj.WriteValue(4);
              break;
            case 309:
              XMLobj.WriteValue(3);
              break;
            case 310:
              XMLobj.WriteValue(5);
              break;
          }
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("Description");
          XMLobj.WriteEndElement();
          if (communitySchemeSubList1.Count > 0)
          {
            if (communitySchemeSubList1[2].CommunityFuel.Equals("99"))
            {
              XMLobj.WriteStartElement("FuelType");
              XMLobj.WriteValue(99);
              XMLobj.WriteEndElement();
            }
            else
            {
              XMLobj.WriteStartElement("FuelType");
              XMLobj.WriteValue(PDFFunctions.CheckFuelCode(SAP_Module.Proj.Dwellings[House].MainHeating.CommunityH.HeatSource2.Fuel));
              XMLobj.WriteEndElement();
            }
          }
          else if ((uint) Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.CommunityH.HeatSource2.Fuel, "", false) > 0U)
          {
            XMLobj.WriteStartElement("FuelType");
            XMLobj.WriteValue(PDFFunctions.CheckFuelCode(SAP_Module.Proj.Dwellings[House].MainHeating.CommunityH.HeatSource2.Fuel));
            XMLobj.WriteEndElement();
          }
          XMLobj.WriteStartElement("HeatFraction");
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].MainHeating.CommunityH.HeatSource2.HeatFraction);
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("HeatEfficiency");
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].MainHeating.CommunityH.HeatSource2.Efficiency);
          XMLobj.WriteEndElement();
          XMLobj.WriteEndElement();
        }
        if (SAP_Module.Proj.Dwellings[House].MainHeating.CommunityH.NoOfAdditionalHeatSources > 2)
        {
          XMLobj.WriteStartElement("CommunityHeatSource");
          XMLobj.WriteStartElement("HeatSourceType");
          switch (SAP_Module.Proj.Dwellings[House].MainHeating.CommunityH.HeatSource3.Type)
          {
            case 306:
              XMLobj.WriteValue(2);
              break;
            case 307:
              XMLobj.WriteValue(1);
              break;
            case 308:
              XMLobj.WriteValue(4);
              break;
            case 309:
              XMLobj.WriteValue(3);
              break;
            case 310:
              XMLobj.WriteValue(5);
              break;
          }
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("Description");
          XMLobj.WriteEndElement();
          if (communitySchemeSubList1.Count > 0)
          {
            if (communitySchemeSubList1[3].CommunityFuel.Equals("99"))
            {
              XMLobj.WriteStartElement("FuelType");
              XMLobj.WriteValue(99);
              XMLobj.WriteEndElement();
            }
            else if ((uint) Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.CommunityH.HeatSource3.Fuel, "", false) > 0U)
            {
              XMLobj.WriteStartElement("FuelType");
              XMLobj.WriteValue(PDFFunctions.CheckFuelCode(SAP_Module.Proj.Dwellings[House].MainHeating.CommunityH.HeatSource3.Fuel));
              XMLobj.WriteEndElement();
            }
          }
          else if ((uint) Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.CommunityH.HeatSource3.Fuel, "", false) > 0U)
          {
            XMLobj.WriteStartElement("FuelType");
            XMLobj.WriteValue(PDFFunctions.CheckFuelCode(SAP_Module.Proj.Dwellings[House].MainHeating.CommunityH.HeatSource3.Fuel));
            XMLobj.WriteEndElement();
          }
          XMLobj.WriteStartElement("HeatFraction");
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].MainHeating.CommunityH.HeatSource3.HeatFraction);
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("HeatEfficiency");
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].MainHeating.CommunityH.HeatSource3.Efficiency);
          XMLobj.WriteEndElement();
          XMLobj.WriteEndElement();
        }
        if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.NoOfAdditionalHeatSources > 3)
        {
          XMLobj.WriteStartElement("CommunityHeatSource");
          XMLobj.WriteStartElement("HeatSourceType");
          switch (SAP_Module.Proj.Dwellings[House].MainHeating.CommunityH.HeatSource4.Type)
          {
            case 306:
              XMLobj.WriteValue(2);
              break;
            case 307:
              XMLobj.WriteValue(1);
              break;
            case 308:
              XMLobj.WriteValue(4);
              break;
            case 309:
              XMLobj.WriteValue(3);
              break;
            case 310:
              XMLobj.WriteValue(5);
              break;
          }
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("Description");
          XMLobj.WriteEndElement();
          if (communitySchemeSubList1.Count > 0)
          {
            if (communitySchemeSubList1[4].CommunityFuel.Equals("99"))
            {
              XMLobj.WriteStartElement("FuelType");
              XMLobj.WriteValue(99);
              XMLobj.WriteEndElement();
            }
            else if ((uint) Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.CommunityH.HeatSource3.Fuel, "", false) > 0U)
            {
              XMLobj.WriteStartElement("FuelType");
              XMLobj.WriteValue(PDFFunctions.CheckFuelCode(SAP_Module.Proj.Dwellings[House].MainHeating.CommunityH.HeatSource4.Fuel));
              XMLobj.WriteEndElement();
            }
          }
          else if ((uint) Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.CommunityH.HeatSource4.Fuel, "", false) > 0U)
          {
            XMLobj.WriteStartElement("FuelType");
            XMLobj.WriteValue(PDFFunctions.CheckFuelCode(SAP_Module.Proj.Dwellings[House].MainHeating.CommunityH.HeatSource4.Fuel));
            XMLobj.WriteEndElement();
          }
          XMLobj.WriteStartElement("HeatFraction");
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].MainHeating.CommunityH.HeatSource4.HeatFraction);
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("HeatEfficiency");
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].MainHeating.CommunityH.HeatSource4.Efficiency);
          XMLobj.WriteEndElement();
          XMLobj.WriteEndElement();
        }
        XMLobj.WriteEndElement();
        if (!string.IsNullOrEmpty(SAP_Module.Proj.Dwellings[House].Water.HWSComm.Charging))
        {
          XMLobj.WriteStartElement("ChargingLinkedToHeatUse");
          if (SAP_Module.Proj.Dwellings[House].Water.HWSComm.Charging.Contains("Charged"))
            XMLobj.WriteValue("true");
          else
            XMLobj.WriteValue("false");
          XMLobj.WriteEndElement();
        }
        XMLobj.WriteStartElement("CommunityHeatingDistributionType");
        string heatDsystem = SAP_Module.Proj.Dwellings[House].MainHeating.CommunityH.HeatDSystem;
        // ISSUE: reference to a compiler-generated method
        switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(heatDsystem))
        {
          case 1158145841:
            if (Operators.CompareString(heatDsystem, "Calculated", false) == 0)
            {
              XMLobj.WriteValue(5);
              goto default;
            }
            else
              goto default;
          case 1676941291:
            if (Operators.CompareString(heatDsystem, "Piping<=1990, not pre-insulated, medium/high temp, full flow", false) == 0)
            {
              XMLobj.WriteValue(1);
              goto default;
            }
            else
              goto default;
          case 2166136261:
            if (Operators.CompareString(heatDsystem, "", false) == 0)
              break;
            goto default;
          case 2475089181:
            if (Operators.CompareString(heatDsystem, "Piping>=1991, pre-insulated, medium temp, variable flow", false) == 0)
            {
              XMLobj.WriteValue(3);
              goto default;
            }
            else
              goto default;
          case 3085999378:
            if (Operators.CompareString(heatDsystem, "Piping<=1990, pre-insulated, low temp, full flow", false) == 0)
            {
              XMLobj.WriteValue(2);
              goto default;
            }
            else
              goto default;
          case 3424652889:
            if (Operators.CompareString(heatDsystem, "Unknown", false) == 0)
              break;
            goto default;
          case 4232637720:
            if (Operators.CompareString(heatDsystem, "Piping>=1991, pre-insulated, low temp, variable flow", false) == 0)
            {
              XMLobj.WriteValue(4);
              goto default;
            }
            else
              goto default;
          default:
label_104:
            XMLobj.WriteEndElement();
            if (SAP_Module.Proj.Dwellings[House].Water.SystemRef != 903)
            {
              XMLobj.WriteStartElement("IsCommunityHeatingCylinderInDwelling");
              if (SAP_Module.Proj.Dwellings[House].Water.HWSComm.CylinderInDwelling)
                XMLobj.WriteValue("true");
              else
                XMLobj.WriteValue("false");
              XMLobj.WriteEndElement();
            }
            XMLobj.WriteEndElement();
            goto label_110;
        }
        XMLobj.WriteValue(6);
        goto label_104;
      }
label_110:
      int systemRef1 = SAP_Module.Proj.Dwellings[House].Water.SystemRef;
      bool flag3;
      if (systemRef1 >= 950 && systemRef1 <= 952)
      {
        if (!flag1)
          XMLobj.WriteStartElement("CommunityHeatingSystems");
        flag3 = true;
        flag1 = true;
        XMLobj.WriteStartElement("CommunityHeatingSystem");
        XMLobj.WriteStartElement("CommunityHeatingUse");
        XMLobj.WriteValue(2);
        XMLobj.WriteEndElement();
        if (!string.IsNullOrEmpty(SAP_Module.Proj.Dwellings[House].Water.HWSComm.SystemRef))
        {
          XMLobj.WriteStartElement("HeatNetworkIndexNumber");
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Water.HWSComm.SystemRef);
          XMLobj.WriteEndElement();
        }
        XMLobj.WriteStartElement("CommunityHeatSources");
        XMLobj.WriteStartElement("CommunityHeatSource");
        XMLobj.WriteStartElement("HeatSourceType");
        switch (SAP_Module.Proj.Dwellings[House].Water.SystemRef)
        {
          case 950:
            XMLobj.WriteValue(2);
            break;
          case 951:
            XMLobj.WriteValue(1);
            break;
          case 952:
            XMLobj.WriteValue(3);
            break;
        }
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("Description");
        XMLobj.WriteEndElement();
        if (communitySchemeSubList1.Count > 0)
        {
          if (communitySchemeSubList1[0].CommunityFuel.Equals("99"))
          {
            XMLobj.WriteStartElement("FuelType");
            XMLobj.WriteValue(99);
            XMLobj.WriteEndElement();
          }
          else if (Operators.CompareString(SAP_Module.Proj.Dwellings[House].Water.Fuel, "", false) == 0)
          {
            XMLobj.WriteStartElement("FuelType");
            XMLobj.WriteValue(99);
            XMLobj.WriteEndElement();
          }
          else
          {
            XMLobj.WriteStartElement("FuelType");
            XMLobj.WriteValue(PDFFunctions.CheckFuelCode(SAP_Module.Proj.Dwellings[House].Water.Fuel));
            XMLobj.WriteEndElement();
          }
        }
        else if (Operators.CompareString(SAP_Module.Proj.Dwellings[House].Water.Fuel, "", false) == 0)
        {
          XMLobj.WriteStartElement("FuelType");
          XMLobj.WriteValue(99);
          XMLobj.WriteEndElement();
        }
        else
        {
          XMLobj.WriteStartElement("FuelType");
          XMLobj.WriteValue(PDFFunctions.CheckFuelCode(SAP_Module.Proj.Dwellings[House].Water.Fuel));
          XMLobj.WriteEndElement();
        }
        XMLobj.WriteStartElement("HeatFraction");
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Water.HWSComm.Boiler1Fraction);
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("HeatEfficiency");
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Water.HWSComm.Efficiency);
        XMLobj.WriteEndElement();
        XMLobj.WriteEndElement();
        if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.NoOfAdditionalHeatSources > 0)
        {
          XMLobj.WriteStartElement("CommunityHeatSource");
          XMLobj.WriteStartElement("HeatSourceType");
          switch (SAP_Module.Proj.Dwellings[House].Water.HWSComm.HeatSource1.Type)
          {
            case 950:
              XMLobj.WriteValue(2);
              break;
            case 951:
              XMLobj.WriteValue(1);
              break;
            case 952:
              XMLobj.WriteValue(3);
              break;
          }
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("Description");
          XMLobj.WriteEndElement();
          if (communitySchemeSubList1.Count > 0)
          {
            if (communitySchemeSubList1[1].CommunityFuel.Equals("99"))
            {
              XMLobj.WriteStartElement("FuelType");
              XMLobj.WriteValue(99);
              XMLobj.WriteEndElement();
            }
            else
            {
              XMLobj.WriteStartElement("FuelType");
              XMLobj.WriteValue(PDFFunctions.CheckFuelCode(SAP_Module.Proj.Dwellings[House].Water.HWSComm.HeatSource1.Fuel));
              XMLobj.WriteEndElement();
            }
          }
          else
          {
            XMLobj.WriteStartElement("FuelType");
            XMLobj.WriteValue(PDFFunctions.CheckFuelCode(SAP_Module.Proj.Dwellings[House].Water.HWSComm.HeatSource1.Fuel));
            XMLobj.WriteEndElement();
          }
          XMLobj.WriteStartElement("HeatFraction");
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Water.HWSComm.HeatSource1.HeatFraction);
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("HeatEfficiency");
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Water.HWSComm.HeatSource1.Efficiency);
          XMLobj.WriteEndElement();
          XMLobj.WriteEndElement();
        }
        if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.NoOfAdditionalHeatSources > 1)
        {
          XMLobj.WriteStartElement("CommunityHeatSource");
          XMLobj.WriteStartElement("HeatSourceType");
          switch (SAP_Module.Proj.Dwellings[House].Water.HWSComm.HeatSource2.Type)
          {
            case 950:
              XMLobj.WriteValue(2);
              break;
            case 951:
              XMLobj.WriteValue(1);
              break;
            case 952:
              XMLobj.WriteValue(3);
              break;
          }
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("Description");
          XMLobj.WriteEndElement();
          if (communitySchemeSubList1.Count > 0)
          {
            if (communitySchemeSubList1[2].CommunityFuel.Equals("99"))
            {
              XMLobj.WriteStartElement("FuelType");
              XMLobj.WriteValue(99);
              XMLobj.WriteEndElement();
            }
            else
            {
              XMLobj.WriteStartElement("FuelType");
              XMLobj.WriteValue(PDFFunctions.CheckFuelCode(SAP_Module.Proj.Dwellings[House].Water.HWSComm.HeatSource2.Fuel));
              XMLobj.WriteEndElement();
            }
          }
          else
          {
            XMLobj.WriteStartElement("FuelType");
            XMLobj.WriteValue(PDFFunctions.CheckFuelCode(SAP_Module.Proj.Dwellings[House].Water.HWSComm.HeatSource2.Fuel));
            XMLobj.WriteEndElement();
          }
          XMLobj.WriteStartElement("HeatFraction");
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Water.HWSComm.HeatSource2.HeatFraction);
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("HeatEfficiency");
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Water.HWSComm.HeatSource2.Efficiency);
          XMLobj.WriteEndElement();
          XMLobj.WriteEndElement();
        }
        if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.NoOfAdditionalHeatSources > 2)
        {
          XMLobj.WriteStartElement("CommunityHeatSource");
          XMLobj.WriteStartElement("HeatSourceType");
          switch (SAP_Module.Proj.Dwellings[House].Water.HWSComm.HeatSource3.Type)
          {
            case 950:
              XMLobj.WriteValue(2);
              break;
            case 951:
              XMLobj.WriteValue(1);
              break;
            case 952:
              XMLobj.WriteValue(3);
              break;
          }
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("Description");
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("FuelType");
          XMLobj.WriteValue(PDFFunctions.CheckFuelCode(SAP_Module.Proj.Dwellings[House].Water.HWSComm.HeatSource3.Fuel));
          XMLobj.WriteEndElement();
          if (communitySchemeSubList1.Count > 0)
          {
            if (communitySchemeSubList1[3].CommunityFuel.Equals("99"))
            {
              XMLobj.WriteStartElement("FuelType");
              XMLobj.WriteValue(99);
              XMLobj.WriteEndElement();
            }
            else
            {
              XMLobj.WriteStartElement("FuelType");
              XMLobj.WriteValue(PDFFunctions.CheckFuelCode(SAP_Module.Proj.Dwellings[House].Water.HWSComm.HeatSource3.Fuel));
              XMLobj.WriteEndElement();
            }
          }
          else
          {
            XMLobj.WriteStartElement("FuelType");
            XMLobj.WriteValue(PDFFunctions.CheckFuelCode(SAP_Module.Proj.Dwellings[House].Water.HWSComm.HeatSource3.Fuel));
            XMLobj.WriteEndElement();
          }
          XMLobj.WriteStartElement("HeatFraction");
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Water.HWSComm.HeatSource4.HeatFraction);
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("HeatEfficiency");
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Water.HWSComm.HeatSource3.Efficiency);
          XMLobj.WriteEndElement();
          XMLobj.WriteEndElement();
        }
        if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.NoOfAdditionalHeatSources > 3)
        {
          XMLobj.WriteStartElement("CommunityHeatSource");
          XMLobj.WriteStartElement("HeatSourceType");
          switch (SAP_Module.Proj.Dwellings[House].Water.HWSComm.HeatSource4.Type)
          {
            case 950:
              XMLobj.WriteValue(2);
              break;
            case 951:
              XMLobj.WriteValue(1);
              break;
            case 952:
              XMLobj.WriteValue(3);
              break;
          }
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("Description");
          XMLobj.WriteEndElement();
          if (communitySchemeSubList1.Count > 0)
          {
            if (communitySchemeSubList1[4].CommunityFuel.Equals("99"))
            {
              XMLobj.WriteStartElement("FuelType");
              XMLobj.WriteValue(99);
              XMLobj.WriteEndElement();
            }
            else
            {
              XMLobj.WriteStartElement("FuelType");
              XMLobj.WriteValue(PDFFunctions.CheckFuelCode(SAP_Module.Proj.Dwellings[House].Water.HWSComm.HeatSource4.Fuel));
              XMLobj.WriteEndElement();
            }
          }
          else
          {
            XMLobj.WriteStartElement("FuelType");
            XMLobj.WriteValue(PDFFunctions.CheckFuelCode(SAP_Module.Proj.Dwellings[House].Water.HWSComm.HeatSource4.Fuel));
            XMLobj.WriteEndElement();
          }
          XMLobj.WriteStartElement("HeatFraction");
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Water.HWSComm.HeatSource4.HeatFraction);
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("HeatEfficiency");
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Water.HWSComm.HeatSource4.Efficiency);
          XMLobj.WriteEndElement();
          XMLobj.WriteEndElement();
        }
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("CommunityHeatingDistributionType");
        if (SAP_Module.Proj.Dwellings[House].Water.HWSComm.KnownLossFactor)
        {
          XMLobj.WriteValue(5);
        }
        else
        {
          string hds = SAP_Module.Proj.Dwellings[House].Water.HWSComm.HDS;
          // ISSUE: reference to a compiler-generated method
          switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(hds))
          {
            case 1158145841:
              if (Operators.CompareString(hds, "Calculated", false) == 0)
              {
                XMLobj.WriteValue(5);
                goto default;
              }
              else
                goto default;
            case 1676941291:
              if (Operators.CompareString(hds, "Piping<=1990, not pre-insulated, medium/high temp, full flow", false) == 0)
              {
                XMLobj.WriteValue(1);
                goto default;
              }
              else
                goto default;
            case 2166136261:
              if (Operators.CompareString(hds, "", false) == 0)
                break;
              goto default;
            case 2475089181:
              if (Operators.CompareString(hds, "Piping>=1991, pre-insulated, medium temp, variable flow", false) == 0)
              {
                XMLobj.WriteValue(3);
                goto default;
              }
              else
                goto default;
            case 3085999378:
              if (Operators.CompareString(hds, "Piping<=1990, pre-insulated, low temp, full flow", false) == 0)
              {
                XMLobj.WriteValue(2);
                goto default;
              }
              else
                goto default;
            case 3424652889:
              if (Operators.CompareString(hds, "Unknown", false) == 0)
                break;
              goto default;
            case 4232637720:
              if (Operators.CompareString(hds, "Piping>=1991, pre-insulated, low temp, variable flow", false) == 0)
              {
                XMLobj.WriteValue(4);
                goto default;
              }
              else
                goto default;
            default:
label_190:
              goto label_191;
          }
          XMLobj.WriteValue(6);
          goto label_190;
        }
label_191:
        XMLobj.WriteEndElement();
      }
      if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.HGroup.Equals("Community heating schemes"))
      {
        int systemRef2 = SAP_Module.Proj.Dwellings[House].Water.SystemRef;
        if (systemRef2 >= 950 && systemRef2 <= 952 || systemRef2 == 901 || systemRef2 == 903)
        {
          PCDF.CommunityScheme communityScheme1 = new PCDF.CommunityScheme();
          if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.HGroup.Equals("Community heating schemes") & SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.InforSource.Equals("Boiler Database"))
          {
            List<PCDF.CommunityScheme> communitySchemes = SAP_Module.PCDFData.CommunitySchemes;
            Func<PCDF.CommunityScheme, bool> predicate;
            // ISSUE: reference to a compiler-generated field
            if (HQMXML._Closure\u0024__.\u0024I111\u002D1 != null)
            {
              // ISSUE: reference to a compiler-generated field
              predicate = HQMXML._Closure\u0024__.\u0024I111\u002D1;
            }
            else
            {
              // ISSUE: reference to a compiler-generated field
              HQMXML._Closure\u0024__.\u0024I111\u002D1 = predicate = (Func<PCDF.CommunityScheme, bool>) (b => b.ID.Equals(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SEDBUK));
            }
            PCDF.CommunityScheme communityScheme2 = communitySchemes.Where<PCDF.CommunityScheme>(predicate).SingleOrDefault<PCDF.CommunityScheme>();
            XMLobj.WriteStartElement("CommunityHeatingDistributionLossFactor");
            XMLobj.WriteValue(communityScheme2.DistributionLossFactor);
            XMLobj.WriteEndElement();
          }
          else if (SAP_Module.Proj.Dwellings[House].Water.HWSComm.KnownLossFactor)
          {
            XMLobj.WriteStartElement("CommunityHeatingDistributionLossFactor");
            XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Water.HWSComm.LossFactor);
            XMLobj.WriteEndElement();
          }
        }
      }
      if (flag2 & flag3)
        XMLobj.WriteEndElement();
      else if (!flag2 & flag3)
        XMLobj.WriteEndElement();
      if (flag1)
        XMLobj.WriteEndElement();
      int num;
      if (Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.InforSource, "Boiler Database", false) == 0)
        num = 1;
      else if (Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.InforSource, "Manufacturer Declaration", false) == 0)
        num = 2;
      else
        num = 3;
    }

    private void _SecondaryHeating(XmlTextWriter XMLobj, int House, int Country)
    {
      XMLobj.WriteStartElement("SecondaryHeatingCategory");
      if (Operators.CompareString(SAP_Module.Proj.Dwellings[House].SecHeating.HGroup, "Room heaters", false) == 0)
        XMLobj.WriteValue(10);
      else
        XMLobj.WriteValue(1);
      XMLobj.WriteEndElement();
      XMLobj.WriteStartElement("HasFixedAirConditioning");
      if (!SAP_Module.Proj.Dwellings[House].Cooling.Include)
        XMLobj.WriteValue("false");
      else
        XMLobj.WriteValue("true");
      XMLobj.WriteEndElement();
      if (SAP_Module.Proj.Dwellings[House].Water.SystemRef == 951)
      {
        XMLobj.WriteStartElement("WaterHeatingCode");
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Water.SystemRef);
        XMLobj.WriteEndElement();
      }
      else
      {
        XMLobj.WriteStartElement("WaterHeatingCode");
        switch (SAP_Module.Proj.Dwellings[House].Water.SystemRef)
        {
          case 901:
            switch (SAP_Module.Proj.Dwellings[House].MainHeating.SAPTableCode)
            {
              case 501:
              case 503:
              case 506:
              case 508:
                XMLobj.WriteValue(905);
                break;
              case 502:
              case 504:
              case 509:
                XMLobj.WriteValue(906);
                break;
              case 507:
                XMLobj.WriteValue(901);
                break;
              default:
                XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Water.SystemRef);
                break;
            }
            break;
          case 902:
            switch (SAP_Module.Proj.Dwellings[House].MainHeating.SAPTableCode)
            {
              case 602:
              case 604:
              case 606:
                XMLobj.WriteValue(904);
                break;
              default:
                XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Water.SystemRef);
                break;
            }
            break;
          default:
            XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Water.SystemRef);
            break;
        }
        XMLobj.WriteEndElement();
        int sapTableCode = SAP_Module.Proj.Dwellings[House].MainHeating.SAPTableCode;
        if (sapTableCode >= 306 && sapTableCode <= 310)
        {
          if (SAP_Module.Proj.Dwellings[House].Water.SystemRef == 903)
          {
            XMLobj.WriteStartElement("WaterFuelType");
            XMLobj.WriteValue(this.FuelCheck(SAP_Module.Proj.Dwellings[House].Water.Fuel, House));
            XMLobj.WriteEndElement();
          }
        }
        else
        {
          XMLobj.WriteStartElement("WaterFuelType");
          XMLobj.WriteValue(this.FuelCheck(SAP_Module.Proj.Dwellings[House].Water.Fuel, House));
          XMLobj.WriteEndElement();
        }
      }
      XMLobj.WriteStartElement("HasHotWaterCylinder", (string) null);
      if ((double) SAP_Module.Proj.Dwellings[House].Water.Cylinder.Volume != 0.0 & SAP_Module.Proj.Dwellings[House].Water.SystemRef != 999)
      {
        if (SAP_Module.Proj.Dwellings[House].Water.Cylinder.ManuSpecified)
        {
          if (-(SAP_Module.Proj.Dwellings[House].Water.SystemRef == 901 ? 1 : 0) == 901 & this.isCPSU(0))
            XMLobj.WriteValue("false");
          else if (SAP_Module.Proj.Dwellings[House].Water.SystemRef == 914 & this.isCPSU(1))
            XMLobj.WriteValue("false");
          else
            XMLobj.WriteValue("true");
        }
        else if (this.isCPSU(0))
          XMLobj.WriteValue("false");
        else
          XMLobj.WriteValue("true");
      }
      else
        XMLobj.WriteValue("false");
      XMLobj.WriteEndElement();
      string hgroup = SAP_Module.Proj.Dwellings[House].MainHeating.HGroup;
      if (Operators.CompareString(hgroup, "Heat pumps with radiators or underfloor heating", false) != 0 && Operators.CompareString(hgroup, "Community heating schemes", false) != 0 && Operators.CompareString(hgroup, "Room heaters", false) != 0 && SAP_Module.Proj.Dwellings[House].Water.Thermal.Include)
      {
        XMLobj.WriteStartElement("ThermalStore");
        if (SAP_Module.Proj.Dwellings[House].Water.Thermal.Type.Contains("ntegrate"))
          XMLobj.WriteValue(3);
        else if (SAP_Module.Proj.Dwellings[House].Water.Thermal.Type.Contains("ater"))
          XMLobj.WriteValue(2);
        else
          XMLobj.WriteValue(1);
        XMLobj.WriteEndElement();
      }
      if (SAP_Module.Proj.Dwellings[House].Water.Cylinder.SummerImmersion)
      {
        XMLobj.WriteStartElement("IsImmersionForSummerUse");
        XMLobj.WriteValue("true");
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("ImmersionHeatingType");
        if (Operators.CompareString(SAP_Module.Proj.Dwellings[House].Water.Cylinder.Immersion, "Dual", false) == 0)
          XMLobj.WriteValue(1);
        else
          XMLobj.WriteValue(2);
        XMLobj.WriteEndElement();
      }
      else if (Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.HPImmersion, "Yes", false) == 0)
      {
        XMLobj.WriteStartElement("IsImmersionForSummerUse");
        XMLobj.WriteValue("true");
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("ImmersionHeatingType");
        if (Operators.CompareString(SAP_Module.Proj.Dwellings[House].Water.Cylinder.Immersion, "Dual", false) == 0)
          XMLobj.WriteValue(1);
        else
          XMLobj.WriteValue(2);
        XMLobj.WriteEndElement();
      }
      else if ((uint) Operators.CompareString(SAP_Module.Proj.Dwellings[House].Water.Cylinder.Immersion, "", false) > 0U && Operators.CompareString(SAP_Module.Proj.Dwellings[House].Water.Fuel, "Electricity", false) == 0)
      {
        if (Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.HGroup, "Heat pumps", false) == 0)
        {
          XMLobj.WriteStartElement("ImmersionHeatingType");
          if (Operators.CompareString(SAP_Module.Proj.Dwellings[House].Water.Cylinder.Immersion, "Dual", false) == 0)
            XMLobj.WriteValue(1);
          else
            XMLobj.WriteValue(2);
          XMLobj.WriteEndElement();
        }
        else if (Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.HGroup, "Community heating schemes", false) == 0)
        {
          XMLobj.WriteStartElement("ImmersionHeatingType");
          if (Operators.CompareString(SAP_Module.Proj.Dwellings[House].Water.Cylinder.Immersion, "Dual", false) == 0)
            XMLobj.WriteValue(1);
          else
            XMLobj.WriteValue(2);
          XMLobj.WriteEndElement();
        }
        else if (Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.SGroup, "Gas boilers and oil boilers", false) == 0)
        {
          XMLobj.WriteStartElement("ImmersionHeatingType");
          if (Operators.CompareString(SAP_Module.Proj.Dwellings[House].Water.Cylinder.Immersion, "Dual", false) == 0)
            XMLobj.WriteValue(1);
          else
            XMLobj.WriteValue(2);
          XMLobj.WriteEndElement();
        }
        else if (SAP_Module.Proj.Dwellings[House].Water.SystemRef == 903)
        {
          XMLobj.WriteStartElement("ImmersionHeatingType");
          if (Operators.CompareString(SAP_Module.Proj.Dwellings[House].Water.Cylinder.Immersion, "Dual", false) == 0)
            XMLobj.WriteValue(1);
          else
            XMLobj.WriteValue(2);
          XMLobj.WriteEndElement();
        }
        else
        {
          int sapTableCode = SAP_Module.Proj.Dwellings[House].MainHeating.SAPTableCode;
          if ((sapTableCode == 191 || sapTableCode == (int) sbyte.MaxValue || sapTableCode == 158 || sapTableCode == 153 || sapTableCode == 156 || sapTableCode == 102 || sapTableCode == 309 || sapTableCode == 402 || sapTableCode == 510 || sapTableCode == 421 || sapTableCode == 701 || sapTableCode == 408 || sapTableCode == 423 || sapTableCode == 306 || sapTableCode == 694 || sapTableCode >= 305 && sapTableCode <= 311) && !string.IsNullOrEmpty(SAP_Module.Proj.Dwellings[House].Water.Cylinder.Immersion))
          {
            XMLobj.WriteStartElement("ImmersionHeatingType");
            if (Operators.CompareString(SAP_Module.Proj.Dwellings[House].Water.Cylinder.Immersion, "Dual", false) == 0)
            {
              XMLobj.WriteValue(1);
              XMLobj.WriteEndElement();
            }
            else
            {
              XMLobj.WriteValue(2);
              XMLobj.WriteEndElement();
            }
          }
        }
      }
      if (!((uint) SAP_Module.Proj.Dwellings[House].SecHeating.SAPTableCode > 0U & SAP_Module.Proj.Dwellings[House].SecHeating.SAPTableCode != 192) || (uint) Operators.CompareString(SAP_Module.Proj.Dwellings[House].SecHeating.InforSource, "", false) <= 0U)
        return;
      XMLobj.WriteStartElement("SecondaryHeatingDataSource");
      if (SAP_Module.Proj.Dwellings[House].SecHeating.InforSource.Contains("anu"))
        XMLobj.WriteValue(2);
      else
        XMLobj.WriteValue(3);
      XMLobj.WriteEndElement();
      string inforSource = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.InforSource;
      XMLobj.WriteStartElement("SecondaryFuelType");
      XMLobj.WriteValue(this.FuelCheck(SAP_Module.Proj.Dwellings[House].SecHeating.Fuel, House));
      XMLobj.WriteEndElement();
      if (!SAP_Module.Proj.Dwellings[House].SecHeating.InforSource.Contains("anu"))
      {
        XMLobj.WriteStartElement("SecondaryHeatingCode");
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].SecHeating.SAPTableCode);
        XMLobj.WriteEndElement();
        int sapTableCode = SAP_Module.Proj.Dwellings[House].SecHeating.SAPTableCode;
        if (sapTableCode >= 631 && sapTableCode <= 636)
        {
          XMLobj.WriteStartElement("IsSecondaryHeatingHETASApproved");
          if (Operators.CompareString(SAP_Module.Proj.Dwellings[House].SecHeating.HETAS, "Yes", false) == 0)
            XMLobj.WriteValue("true");
          else
            XMLobj.WriteValue("false");
          XMLobj.WriteEndElement();
        }
        if ((uint) Operators.CompareString(SAP_Module.Proj.Dwellings[House].SecHeating.FlueType, "", false) > 0U)
        {
          XMLobj.WriteStartElement("SecondaryHeatingFlueType");
          string flueType = SAP_Module.Proj.Dwellings[House].SecHeating.FlueType;
          if (Operators.CompareString(flueType, "Open", false) != 0)
          {
            if (Operators.CompareString(flueType, "Chimney", false) != 0)
            {
              if (Operators.CompareString(flueType, "Room-sealed", false) != 0)
              {
                if (Operators.CompareString(flueType, "Unknown", false) == 0)
                  XMLobj.WriteValue(5);
              }
              else
                XMLobj.WriteValue(2);
            }
            else
              XMLobj.WriteValue(3);
          }
          else
            XMLobj.WriteValue(1);
          XMLobj.WriteEndElement();
        }
      }
      else
      {
        XMLobj.WriteStartElement("SecondaryHeatingDeclaredValues");
        XMLobj.WriteStartElement("MakeModel");
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].SecHeating.MDescription);
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("TestMethod");
        if (SAP_Module.Proj.Dwellings[House].SecHeating.TestMethod == null)
          SAP_Module.Proj.Dwellings[House].SecHeating.TestMethod = "";
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].SecHeating.TestMethod);
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("Efficiency");
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].SecHeating.SecEff);
        XMLobj.WriteEndElement();
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("SecondaryHeatingFlueType");
        string flueType = SAP_Module.Proj.Dwellings[House].SecHeating.FlueType;
        // ISSUE: reference to a compiler-generated method
        switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(flueType))
        {
          case 572081497:
            if (Operators.CompareString(flueType, "omitted", false) == 0)
              goto label_116;
            else
              goto default;
          case 1401622761:
            if (Operators.CompareString(flueType, "Open", false) == 0)
              break;
            goto default;
          case 1533154807:
            if (Operators.CompareString(flueType, "balanced flue", false) == 0)
              goto label_114;
            else
              goto default;
          case 1537289947:
            if (Operators.CompareString(flueType, "open flue", false) == 0)
              break;
            goto default;
          case 1708018833:
            if (Operators.CompareString(flueType, "Room-sealed", false) == 0)
              goto label_114;
            else
              goto default;
          case 1845819738:
            if (Operators.CompareString(flueType, "unknown (there is a flue, but its type could not be determined)", false) == 0)
              goto label_117;
            else
              goto default;
          case 2166136261:
            if (Operators.CompareString(flueType, "", false) == 0)
              goto label_116;
            else
              goto default;
          case 2391940020:
            if (Operators.CompareString(flueType, "Chimney", false) == 0)
            {
              XMLobj.WriteValue(3);
              goto label_119;
            }
            else
              goto default;
          case 3424652889:
            if (Operators.CompareString(flueType, "Unknown", false) == 0)
              goto label_117;
            else
              goto default;
          default:
            XMLobj.WriteValue(1);
            goto label_119;
        }
        XMLobj.WriteValue(1);
        goto label_119;
label_114:
        XMLobj.WriteValue(2);
        goto label_119;
label_116:
        XMLobj.WriteValue(4);
        goto label_119;
label_117:
        XMLobj.WriteValue(5);
label_119:
        XMLobj.WriteEndElement();
      }
    }

    private void _WaterHeating(XmlTextWriter XMLobj, int House, int Country)
    {
      bool flag1;
      try
      {
        if (Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.InforSource, "Boiler Database", false) == 0)
        {
          if (this.IsCombi(SAP_Module.Proj.Dwellings[House]))
            flag1 = true;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      if (!flag1 && (double) SAP_Module.Proj.Dwellings[House].Water.Cylinder.Volume != 0.0)
      {
        XMLobj.WriteStartElement("HotWaterStoreSize");
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Water.Cylinder.Volume);
        XMLobj.WriteEndElement();
        bool flag2 = false;
        if (SAP_Module.Proj.Dwellings[House].MainHeating.SGroup.Contains("heat pumps") & SAP_Module.Proj.Dwellings[House].Water.SystemRef == 901 | SAP_Module.Proj.Dwellings[House].MainHeating.SGroup.Contains("heat pumps") & SAP_Module.Proj.Dwellings[House].Water.SystemRef == 903 | SAP_Module.Proj.Dwellings[House].WaterOnlyHeatPump && (double) SAP_Module.Proj.Dwellings[House].Water.Cylinder.HPExchanger > 0.0)
        {
          XMLobj.WriteStartElement("HotWaterStoreHeatTransferArea");
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Water.Cylinder.HPExchanger);
          XMLobj.WriteEndElement();
          flag2 = true;
        }
        if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].IncludeMainHeating2 & !flag2 && SAP_Module.Proj.Dwellings[House].MainHeating2.SGroup.Contains("heat pumps") & SAP_Module.Proj.Dwellings[House].Water.SystemRef == 901 | SAP_Module.Proj.Dwellings[House].MainHeating2.SGroup.Contains("heat pumps") & SAP_Module.Proj.Dwellings[House].Water.SystemRef == 903 | SAP_Module.Proj.Dwellings[House].WaterOnlyHeatPump)
        {
          XMLobj.WriteStartElement("HotWaterStoreHeatTransferArea");
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Water.Cylinder.HPExchanger);
          XMLobj.WriteEndElement();
        }
        bool flag3 = false;
        if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Thermal.Include | (double) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.Volume > 0.0)
          ;
        string hgroup = SAP_Module.Proj.Dwellings[House].MainHeating.HGroup;
        if (Operators.CompareString(hgroup, "Heat pumps with radiators or underfloor heating", false) != 0 && Operators.CompareString(hgroup, "Community heating schemes", false) != 0 && Operators.CompareString(hgroup, "Room heaters", false) != 0)
          flag3 = true;
        if (this.IsCombi(SAP_Module.Proj.Dwellings[House]) & SAP_Module.Proj.Dwellings[House].MainHeating.InforSource.Contains("Database"))
          flag3 = false;
        if (this.IsCombi(SAP_Module.Proj.Dwellings[House]) & SAP_Module.Proj.Dwellings[House].MainHeating.InforSource.Contains("SAP"))
          flag3 = false;
        bool flag4;
        if (flag3 && !this.IsCombi(SAP_Module.Proj.Dwellings[House]) & (double) SAP_Module.Proj.Dwellings[House].Water.Cylinder.Volume > 0.0)
          flag4 = true;
        if ((double) SAP_Module.Proj.Dwellings[House].Water.Cylinder.Volume > 0.0 & Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.HGroup, "Community heating schemes", false) == 0 & SAP_Module.Proj.Dwellings[House].Water.SystemRef == 903)
          flag4 = true;
        if (SAP_Module.Proj.Dwellings[House].Water.HWSComm.CylinderInDwelling)
          flag4 = true;
        if ((double) SAP_Module.Proj.Dwellings[House].Water.Cylinder.DeclaredLoss != 0.0)
        {
          XMLobj.WriteStartElement("HotWaterStoreHeatLossSource");
          XMLobj.WriteValue(2);
          XMLobj.WriteEndElement();
        }
        else
        {
          XMLobj.WriteStartElement("HotWaterStoreHeatLossSource");
          XMLobj.WriteValue(3);
          XMLobj.WriteEndElement();
        }
        if (!flag1)
        {
          XMLobj.WriteStartElement("HotWaterStoreInsulationType");
          if (Operators.CompareString(SAP_Module.Proj.Dwellings[House].Water.Cylinder.Insulation, "Factory", false) == 0)
            XMLobj.WriteValue(1);
          else
            XMLobj.WriteValue(2);
          XMLobj.WriteEndElement();
          if ((double) SAP_Module.Proj.Dwellings[House].Water.Cylinder.InsThick > 0.0)
          {
            XMLobj.WriteStartElement("HotWaterStoreInsulationThickness");
            XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Water.Cylinder.InsThick);
            XMLobj.WriteEndElement();
          }
        }
      }
      bool flag5;
      try
      {
        flag5 = !this.IsCombi(SAP_Module.Proj.Dwellings[House]);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      if (SAP_Module.Proj.Dwellings[House].Water.Thermal.Include & !flag5 & Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.BSubGroup, "Combined Primary Storage Units (CPSU) (mains gas and LPG)", false) == 0)
      {
        XMLobj.WriteStartElement("IsThermalStoreNearBoiler");
        if (Operators.CompareString(SAP_Module.Proj.Dwellings[House].Water.Thermal.Connection, "> 1.5 m of primary pipework", false) == 0)
          XMLobj.WriteValue("false");
        else
          XMLobj.WriteValue("true");
        XMLobj.WriteEndElement();
      }
      if (SAP_Module.Proj.Dwellings[House].Water.Thermal.Include & !flag5 & Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.BSubGroup, "Combined Primary Storage Units (CPSU) (mains gas and LPG)", false) == 0)
      {
        XMLobj.WriteStartElement("PrimaryPipeworkInsulation");
        string workInsulationType = SAP_Module.Proj.Dwellings[House].Water.Cylinder.PipeWorkInsulationType;
        if (Operators.CompareString(workInsulationType, "Fully insulated primary pipework", false) != 0)
        {
          if (Operators.CompareString(workInsulationType, "First 1m from cylinder insulated", false) != 0)
          {
            if (Operators.CompareString(workInsulationType, "All accessible pipework insulated", false) == 0)
              XMLobj.WriteValue("3");
            else
              XMLobj.WriteValue("1");
          }
          else
            XMLobj.WriteValue("2");
        }
        else
          XMLobj.WriteValue("4");
        XMLobj.WriteEndElement();
      }
      if (!this.IsCombi(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling]))
      {
        if (Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.HGroup, "Community heating schemes", false) == 0 | SAP_Module.Proj.Dwellings[House].Water.SystemRef == 950)
        {
          bool flag6 = false;
          if (SAP_Module.Proj.Dwellings[House].Water.HWSComm.CylinderInDwelling)
            flag6 = true;
          if ((double) SAP_Module.Proj.Dwellings[House].Water.Cylinder.Volume > 0.0 & SAP_Module.Proj.Dwellings[House].Water.SystemRef == 903)
            flag6 = true;
          if (flag6)
          {
            XMLobj.WriteStartElement("HasCylinderThermostat");
            XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Water.Cylinder.Thermostat);
            XMLobj.WriteEndElement();
            if (!this.isCPSU(0) & !SAP_Module.Proj.Dwellings[House].Water.HWSComm.CylinderInDwelling)
            {
              XMLobj.WriteStartElement("IsCylinderInHeatedSpace");
              XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Water.Cylinder.InHeatedSpace);
              XMLobj.WriteEndElement();
            }
            if ((uint) Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.HGroup, "Community heating schemes", false) > 0U && SAP_Module.Proj.Dwellings[House].Water.Thermal.Include & !flag5 & Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.BSubGroup, "Combined Primary Storage Units (CPSU) (mains gas and LPG)", false) == 0)
            {
              XMLobj.WriteStartElement("IsHotWaterSeparatelyTimed");
              XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Water.Cylinder.Timed);
              XMLobj.WriteEndElement();
            }
          }
        }
        else
        {
          XMLobj.WriteStartElement("HasCylinderThermostat");
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Water.Cylinder.Thermostat);
          XMLobj.WriteEndElement();
          if (!this.isCPSU(0))
          {
            XMLobj.WriteStartElement("IsCylinderInHeatedSpace");
            XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Water.Cylinder.InHeatedSpace);
            XMLobj.WriteEndElement();
          }
          if ((uint) Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.HGroup, "Community heating schemes", false) > 0U && SAP_Module.Proj.Dwellings[House].Water.Thermal.Include & !flag5 & Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.BSubGroup, "Combined Primary Storage Units (CPSU) (mains gas and LPG)", false) == 0)
          {
            XMLobj.WriteStartElement("IsHotWaterSeparatelyTimed");
            XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Water.Cylinder.Timed);
            XMLobj.WriteEndElement();
          }
        }
      }
      string hgroup1 = SAP_Module.Proj.Dwellings[House].MainHeating.HGroup;
      if (Operators.CompareString(hgroup1, "Heat pumps with radiators or underfloor heating", false) != 0 && Operators.CompareString(hgroup1, "Community heating schemes", false) != 0 && Operators.CompareString(hgroup1, "Room heaters", false) != 0 && this.isCPSU(0))
      {
        string inforSource = SAP_Module.Proj.Dwellings[House].MainHeating.InforSource;
        if (Operators.CompareString(inforSource, "SAP Tables", false) != 0 && Operators.CompareString(inforSource, "Manufacturer Declaration", false) != 0)
        {
          if (Operators.CompareString(inforSource, "Boiler Database", false) == 0)
          {
            PCDF.SEDBUK sedbuk = SAP_Module.PCDFData.Boilers.Where<PCDF.SEDBUK>((Func<PCDF.SEDBUK, bool>) (b => b.ID.ToUpper().Equals(SAP_Module.Proj.Dwellings[House].MainHeating.SEDBUK.ToUpper()))).SingleOrDefault<PCDF.SEDBUK>();
            if (sedbuk != null && sedbuk.MainType.Equals("1"))
            {
              XMLobj.WriteStartElement("IsThermalStoreOrCPSUInAiringCupboard");
              if ((uint) Operators.CompareString(SAP_Module.Proj.Dwellings[House].Water.Thermal.Location, "Not in an airing cupboard", false) > 0U | (uint) Operators.CompareString(SAP_Module.Proj.Dwellings[House].Water.Thermal.Location, "", false) > 0U)
                XMLobj.WriteValue("true");
              else
                XMLobj.WriteValue("false");
              XMLobj.WriteEndElement();
            }
          }
        }
        else if (Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.BSubGroup, "Combined Primary Storage Units (CPSU) (mains gas and LPG)", false) == 0)
        {
          if ((uint) Operators.CompareString(SAP_Module.Proj.Dwellings[House].Water.Thermal.Location, "Not in an airing cupboard", false) > 0U | (uint) Operators.CompareString(SAP_Module.Proj.Dwellings[House].Water.Thermal.Location, "", false) > 0U)
          {
            XMLobj.WriteStartElement("IsThermalStoreOrCPSUInAiringCupboard");
            XMLobj.WriteValue("true");
          }
          else
            XMLobj.WriteValue("false");
          XMLobj.WriteEndElement();
        }
      }
      if ((uint) Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.HGroup, "Heat pumps with radiators or underfloor heating", false) <= 0U && Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.HGroup, "Community heating schemes", false) == 0 & (uint) Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.InforSource, "Boiler Database", false) > 0U && !this.IsCombi(SAP_Module.Proj.Dwellings[House]))
      {
        XMLobj.WriteStartElement("HasCylinderThermostat");
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Water.Cylinder.Thermostat);
        XMLobj.WriteEndElement();
        if (!this.isCPSU(0))
        {
          XMLobj.WriteStartElement("IsCylinderInHeatedSpace");
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Water.Cylinder.InHeatedSpace);
          XMLobj.WriteEndElement();
        }
      }
      if ((double) SAP_Module.Proj.Dwellings[House].Water.Cylinder.DeclaredLoss > 0.0)
      {
        XMLobj.WriteStartElement("HotWaterStoreHeatLoss");
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Water.Cylinder.DeclaredLoss);
        XMLobj.WriteEndElement();
      }
      if (!SAP_Module.Proj.Dwellings[House].LessThan125Litre)
        return;
      XMLobj.WriteStartElement("HeatingDesignWaterUse");
      XMLobj.WriteValue(1);
      XMLobj.WriteEndElement();
    }

    private void _WaterHeatingWWHRS(XmlTextWriter XMLobj, int House, int Country)
    {
      // ISSUE: variable of a compiler-generated type
      HQMXML._Closure\u0024__114\u002D0 closure1140_1;
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      HQMXML._Closure\u0024__114\u002D0 closure1140_2 = new HQMXML._Closure\u0024__114\u002D0(closure1140_1);
      // ISSUE: reference to a compiler-generated field
      closure1140_2.\u0024VB\u0024Local_House = House;
      // ISSUE: reference to a compiler-generated field
      if (!SAP_Module.Proj.Dwellings[closure1140_2.\u0024VB\u0024Local_House].Water.WWHRS.Include)
        return;
      bool flag;
      // ISSUE: reference to a compiler-generated field
      if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure1140_2.\u0024VB\u0024Local_House].MainHeating.InforSource, "Boiler Database", false) == 0)
      {
        // ISSUE: reference to a compiler-generated method
        PCDF.SEDBUK sedbuk = SAP_Module.PCDFData.Boilers.Where<PCDF.SEDBUK>(new Func<PCDF.SEDBUK, bool>(closure1140_2._Lambda\u0024__0)).SingleOrDefault<PCDF.SEDBUK>();
        if (sedbuk != null && !sedbuk.MainType.Equals("2"))
        {
          if (sedbuk.MainType.Equals("1"))
            flag = true;
          else if (!sedbuk.MainType.Equals("3"))
            ;
        }
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        switch (SAP_Module.Proj.Dwellings[closure1140_2.\u0024VB\u0024Local_House].MainHeating.SAPTableCode)
        {
          case 103:
          case 104:
          case 107:
          case 108:
          case 112:
          case 113:
          case 118:
          case 120:
          case 128:
          case 129:
          case 130:
          case 515:
            break;
          default:
            flag = true;
            goto case 103;
        }
      }
      // ISSUE: reference to a compiler-generated field
      if (SAP_Module.Proj.Dwellings[closure1140_2.\u0024VB\u0024Local_House].Water.Thermal.Include)
        flag = false;
      // ISSUE: reference to a compiler-generated field
      int num1 = checked (SAP_Module.Proj.Dwellings[closure1140_2.\u0024VB\u0024Local_House].Water.WWHRS.Systems.Length - 1);
      int index1 = 0;
      while (index1 <= num1)
      {
        // ISSUE: reference to a compiler-generated field
        flag = (double) SAP_Module.Proj.Dwellings[closure1140_2.\u0024VB\u0024Local_House].Water.WWHRS.Systems[index1].DedicatedStorage > 0.0;
        checked { ++index1; }
      }
      try
      {
        // ISSUE: reference to a compiler-generated field
        if (SAP_Module.Proj.Dwellings[closure1140_2.\u0024VB\u0024Local_House].Water.WWHRS.Include)
        {
          // ISSUE: reference to a compiler-generated field
          int num2 = checked (SAP_Module.Proj.Dwellings[closure1140_2.\u0024VB\u0024Local_House].Water.WWHRS.Systems.Length - 1);
          int index2 = 0;
          while (index2 <= num2)
          {
            // ISSUE: reference to a compiler-generated field
            if ((double) SAP_Module.Proj.Dwellings[closure1140_2.\u0024VB\u0024Local_House].Water.WWHRS.Systems[index2].DedicatedStorage > 0.0)
              flag = true;
            checked { ++index2; }
          }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      if (flag)
      {
        XMLobj.WriteStartElement("StorageWWHRS");
        XMLobj.WriteStartElement("WWHRSIndeNumber");
        // ISSUE: reference to a compiler-generated field
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[closure1140_2.\u0024VB\u0024Local_House].Water.WWHRS.Systems[0].SystemsRef);
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("TotalShowersAndBaths");
        // ISSUE: reference to a compiler-generated field
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[closure1140_2.\u0024VB\u0024Local_House].Water.WWHRS.TotalRooms);
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("BathsAndShowersToWWHRS");
        // ISSUE: reference to a compiler-generated field
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[closure1140_2.\u0024VB\u0024Local_House].Water.WWHRS.Systems[0].WithBath);
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("WWHRSStoreVolume");
        // ISSUE: reference to a compiler-generated field
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[closure1140_2.\u0024VB\u0024Local_House].Water.WWHRS.Systems[0].DedicatedStorage);
        XMLobj.WriteEndElement();
        XMLobj.WriteEndElement();
      }
      else
      {
        XMLobj.WriteStartElement("InstantaneousWWHRS");
        XMLobj.WriteStartElement("WWHRSIndexNumber1");
        // ISSUE: reference to a compiler-generated field
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[closure1140_2.\u0024VB\u0024Local_House].Water.WWHRS.Systems[0].SystemsRef);
        XMLobj.WriteEndElement();
        // ISSUE: reference to a compiler-generated field
        if ((uint) Operators.CompareString(SAP_Module.Proj.Dwellings[closure1140_2.\u0024VB\u0024Local_House].Water.WWHRS.Systems[1].SystemsRef, "", false) > 0U)
        {
          XMLobj.WriteStartElement("WWHRSIndexNumber2");
          // ISSUE: reference to a compiler-generated field
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[closure1140_2.\u0024VB\u0024Local_House].Water.WWHRS.Systems[1].SystemsRef);
          XMLobj.WriteEndElement();
        }
        XMLobj.WriteStartElement("RoomsWithBathAndOrShower");
        // ISSUE: reference to a compiler-generated field
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[closure1140_2.\u0024VB\u0024Local_House].Water.WWHRS.TotalRooms);
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("MixerShowersWithSystem1WithBath");
        // ISSUE: reference to a compiler-generated field
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[closure1140_2.\u0024VB\u0024Local_House].Water.WWHRS.Systems[0].WithBath);
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("MixerShowersWithSystem1WithoutBath");
        // ISSUE: reference to a compiler-generated field
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[closure1140_2.\u0024VB\u0024Local_House].Water.WWHRS.Systems[0].WithNoBath);
        XMLobj.WriteEndElement();
        // ISSUE: reference to a compiler-generated field
        if ((uint) Operators.CompareString(SAP_Module.Proj.Dwellings[closure1140_2.\u0024VB\u0024Local_House].Water.WWHRS.Systems[1].SystemsRef, "", false) > 0U)
        {
          XMLobj.WriteStartElement("MixerShowersWithSystem2WithBath");
          // ISSUE: reference to a compiler-generated field
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[closure1140_2.\u0024VB\u0024Local_House].Water.WWHRS.Systems[1].WithBath);
          XMLobj.WriteEndElement();
        }
        // ISSUE: reference to a compiler-generated field
        if ((uint) Operators.CompareString(SAP_Module.Proj.Dwellings[closure1140_2.\u0024VB\u0024Local_House].Water.WWHRS.Systems[1].SystemsRef, "", false) > 0U)
        {
          XMLobj.WriteStartElement("MixerShowersWithSystem2WithoutBath");
          // ISSUE: reference to a compiler-generated field
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[closure1140_2.\u0024VB\u0024Local_House].Water.WWHRS.Systems[1].WithNoBath);
          XMLobj.WriteEndElement();
        }
        XMLobj.WriteEndElement();
      }
    }

    private void _WaterHeatingSolar(XmlTextWriter XMLobj, int House, int Country)
    {
      if (!SAP_Module.Proj.Dwellings[House].Water.Solar.Inlcude)
        return;
      XMLobj.WriteStartElement("SolarHeatingDetails");
      XMLobj.WriteStartElement("SolarPanelApertureArea");
      XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Water.Solar.SolarArea);
      XMLobj.WriteEndElement();
      XMLobj.WriteStartElement("SolarPanelCollectorType");
      string solarType = SAP_Module.Proj.Dwellings[House].Water.Solar.SolarType;
      if (Operators.CompareString(solarType, "Unglazed", false) != 0)
      {
        if (Operators.CompareString(solarType, "Flat plate", false) != 0 && Operators.CompareString(solarType, "Flat plate, glazed", false) != 0)
        {
          if (Operators.CompareString(solarType, "Evacuated tube", false) == 0)
            XMLobj.WriteValue(3);
        }
        else
          XMLobj.WriteValue(2);
      }
      else
        XMLobj.WriteValue(1);
      XMLobj.WriteEndElement();
      XMLobj.WriteStartElement("SolarPanelCollectorDataSource");
      if (SAP_Module.Proj.Dwellings[House].Water.Solar.Overide)
        XMLobj.WriteValue(2);
      else
        XMLobj.WriteValue(1);
      XMLobj.WriteEndElement();
      if (SAP_Module.Proj.Dwellings[House].Water.Solar.Overide)
      {
        XMLobj.WriteStartElement("SolarPanelCollectorZeroLossEfficiency");
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Water.Solar.SolarZero * 100f);
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("SolarPanelCollectorLinearHeatLossCoefficient");
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Water.Solar.SolarHLoss);
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("SolarPanelCollectorSecondOrderHeatLossCoefficient");
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Water.Solar.SolarHLoss2);
        XMLobj.WriteEndElement();
      }
      XMLobj.WriteStartElement("SolarPanelCollectorOrientation");
      if (Operators.CompareString(SAP_Module.Proj.Dwellings[House].Water.Solar.SolarTilt, "Horizontal", false) == 0)
      {
        XMLobj.WriteValue("ND");
      }
      else
      {
        string solarOrientation = SAP_Module.Proj.Dwellings[House].Water.Solar.SolarOrientation;
        // ISSUE: reference to a compiler-generated method
        switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(solarOrientation))
        {
          case 912749504:
            if (Operators.CompareString(solarOrientation, "SE/SW", false) == 0)
              break;
            goto default;
          case 1128440633:
            if (Operators.CompareString(solarOrientation, "North East", false) == 0)
              goto label_31;
            else
              goto default;
          case 1409318971:
            if (Operators.CompareString(solarOrientation, "North West", false) == 0)
            {
              XMLobj.WriteValue(8);
              goto default;
            }
            else
              goto default;
          case 1682370166:
            if (Operators.CompareString(solarOrientation, "NE/NW", false) == 0)
              goto label_31;
            else
              goto default;
          case 1731397980:
            if (Operators.CompareString(solarOrientation, "East", false) == 0)
            {
              XMLobj.WriteValue(3);
              goto default;
            }
            else
              goto default;
          case 1734234020:
            if (Operators.CompareString(solarOrientation, "North", false) == 0)
            {
              XMLobj.WriteValue(1);
              goto default;
            }
            else
              goto default;
          case 1796576718:
            if (Operators.CompareString(solarOrientation, "West", false) == 0)
              goto label_30;
            else
              goto default;
          case 2417407149:
            if (Operators.CompareString(solarOrientation, "South West", false) == 0)
            {
              XMLobj.WriteValue(4);
              goto default;
            }
            else
              goto default;
          case 2853841879:
            if (Operators.CompareString(solarOrientation, "South East", false) == 0)
              break;
            goto default;
          case 3017973530:
            if (Operators.CompareString(solarOrientation, "South", false) == 0)
            {
              XMLobj.WriteValue(5);
              goto default;
            }
            else
              goto default;
          case 4260797214:
            if (Operators.CompareString(solarOrientation, "E/W", false) == 0)
              goto label_30;
            else
              goto default;
          default:
label_34:
            goto label_35;
        }
        XMLobj.WriteValue(6);
        goto label_34;
label_30:
        XMLobj.WriteValue(7);
        goto label_34;
label_31:
        XMLobj.WriteValue(2);
        goto label_34;
      }
label_35:
      XMLobj.WriteEndElement();
      XMLobj.WriteStartElement("SolarPanelCollectorPitch");
      string solarTilt = SAP_Module.Proj.Dwellings[House].Water.Solar.SolarTilt;
      if (Operators.CompareString(solarTilt, "Horizontal", false) != 0)
      {
        if (Operators.CompareString(solarTilt, "30°", false) != 0)
        {
          if (Operators.CompareString(solarTilt, "45°", false) != 0)
          {
            if (Operators.CompareString(solarTilt, "60°", false) != 0)
            {
              if (Operators.CompareString(solarTilt, "Vertical", false) == 0)
                XMLobj.WriteValue(5);
            }
            else
              XMLobj.WriteValue(4);
          }
          else
            XMLobj.WriteValue(3);
        }
        else
          XMLobj.WriteValue(2);
      }
      else
        XMLobj.WriteValue(1);
      XMLobj.WriteEndElement();
      XMLobj.WriteStartElement("SolarPanelCollectorOvershading");
      string solarOvershading = SAP_Module.Proj.Dwellings[House].Water.Solar.SolarOvershading;
      if (Operators.CompareString(solarOvershading, "None or Very Little (<20%)", false) != 0)
      {
        if (Operators.CompareString(solarOvershading, "Modest (20% - 60%)", false) != 0)
        {
          if (Operators.CompareString(solarOvershading, "Significant (>60% - 80%)", false) != 0)
          {
            if (Operators.CompareString(solarOvershading, "Heavy (>80%)", false) == 0)
              XMLobj.WriteValue(4);
          }
          else
            XMLobj.WriteValue(3);
        }
        else
          XMLobj.WriteValue(2);
      }
      else
        XMLobj.WriteValue(1);
      XMLobj.WriteEndElement();
      XMLobj.WriteStartElement("HasSolarPoweredPump");
      XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Water.Solar.Pumped);
      XMLobj.WriteEndElement();
      XMLobj.WriteStartElement("SolarStoreVolume");
      XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Water.Solar.SolarVolume);
      XMLobj.WriteEndElement();
      XMLobj.WriteStartElement("IsSolarStoreCombinedCylinder");
      XMLobj.WriteValue(!SAP_Module.Proj.Dwellings[House].Water.Solar.SolarSeperate);
      XMLobj.WriteEndElement();
      XMLobj.WriteStartElement("ShowerTypes");
      string showerType = SAP_Module.Proj.Dwellings[House].Water.Solar.ShowerType;
      if (Operators.CompareString(showerType, "Non-electric shower(s) only", false) != 0)
      {
        if (Operators.CompareString(showerType, "Electric shower(s) only", false) != 0)
        {
          if (Operators.CompareString(showerType, "Both electric and non-electric showers", false) != 0)
          {
            if (Operators.CompareString(showerType, "No shower (bath only)", false) == 0)
              XMLobj.WriteValue(4);
            else
              XMLobj.WriteValue(0);
          }
          else
            XMLobj.WriteValue(3);
        }
        else
          XMLobj.WriteValue(2);
      }
      else
        XMLobj.WriteValue(1);
      XMLobj.WriteEndElement();
      XMLobj.WriteEndElement();
    }

    private void _SAP09DataPropertyDetails_Heating(XmlTextWriter XMLobj, int House, int Country)
    {
      XMLobj.WriteStartElement("Heating");
      XMLobj.WriteStartElement("MainHeatingDetails");
      this._HeatingMain1(XMLobj, House, Country);
      this._HeatingMain2(XMLobj, House, Country);
      XMLobj.WriteEndElement();
      if (SAP_Module.Proj.Dwellings[House].IncludeMainHeating2)
      {
        XMLobj.WriteStartElement("MainHeatingSystemsInteraction");
        if (SAP_Module.Proj.Dwellings[House].Include_SecMain_Heat_Separat_Part)
          XMLobj.WriteValue(2);
        else if (SAP_Module.Proj.Dwellings[House].Include_SecMain_Heat_Whole)
          XMLobj.WriteValue(1);
        else
          XMLobj.WriteValue(2);
        XMLobj.WriteEndElement();
      }
      this._SecondaryHeating(XMLobj, House, Country);
      this._WaterHeating(XMLobj, House, Country);
      this._WaterHeatingWWHRS(XMLobj, House, Country);
      this._WaterHeatingSolar(XMLobj, House, Country);
      this._CommunityHeating(XMLobj, House, Country);
      XMLobj.WriteEndElement();
    }

    private void _SAP09DataPropertyDetails_Cooling(XmlTextWriter XMLobj, int House, int Country)
    {
      int num = Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.InforSource, "Boiler Database", false) != 0 ? (Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.InforSource, "Manufacturer Declaration", false) != 0 ? 3 : 2) : 1;
      if (!SAP_Module.Proj.Dwellings[House].Cooling.Include)
        return;
      XMLobj.WriteStartElement("Cooling");
      XMLobj.WriteStartElement("CooledArea");
      XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Cooling.Cooled_Area);
      XMLobj.WriteEndElement();
      XMLobj.WriteStartElement("CoolingSystemDataSource");
      XMLobj.WriteValue(3);
      XMLobj.WriteEndElement();
      XMLobj.WriteStartElement("CoolingSystemType");
      if (Operators.CompareString(SAP_Module.Proj.Dwellings[House].Cooling.SystemType, "Split/multiple systems", false) == 0)
        XMLobj.WriteValue(1);
      else
        XMLobj.WriteValue(2);
      XMLobj.WriteEndElement();
      if (SAP_Module.Proj.Dwellings[House].Cooling.ERRMeasuredInclude)
      {
        XMLobj.WriteStartElement("CoolingSystemEER");
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Cooling.ERR);
        XMLobj.WriteEndElement();
      }
      else
      {
        XMLobj.WriteStartElement("CoolingSystemClass");
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Cooling.Energylabel);
        XMLobj.WriteEndElement();
      }
      XMLobj.WriteStartElement("CoolingSystemControl");
      if (Operators.CompareString(SAP_Module.Proj.Dwellings[House].Cooling.Compressorcontrol, "Systems with On/Off control", false) == 0)
        XMLobj.WriteValue(1);
      else
        XMLobj.WriteValue(2);
      XMLobj.WriteEndElement();
      XMLobj.WriteEndElement();
    }

    private void _SAP09DataPropertyDetails_SpecialFeatures(
      XmlTextWriter XMLobj,
      int House,
      int Country)
    {
      XMLobj.WriteStartElement("EnergySource");
      if (SAP_Module.Proj.Dwellings[House].Renewable.Photovoltaic.Inlcude)
      {
        XMLobj.WriteStartElement("PVArrays");
        int num = checked (SAP_Module.Proj.Dwellings[House].Renewable.Photovoltaic.Photovoltaics.Length - 1);
        int index = 0;
        while (index <= num)
        {
          XMLobj.WriteStartElement("PVArray");
          XMLobj.WriteStartElement("PeakPower");
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Renewable.Photovoltaic.Photovoltaics[index].PPower);
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("Orientation");
          if (Operators.CompareString(SAP_Module.Proj.Dwellings[House].Renewable.Photovoltaic.Photovoltaics[index].PTilt, "Horizontal", false) == 0)
          {
            XMLobj.WriteValue("ND");
          }
          else
          {
            string pcOrientation = SAP_Module.Proj.Dwellings[House].Renewable.Photovoltaic.Photovoltaics[index].PCOrientation;
            // ISSUE: reference to a compiler-generated method
            switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(pcOrientation))
            {
              case 912749504:
                if (Operators.CompareString(pcOrientation, "SE/SW", false) == 0)
                  break;
                goto default;
              case 1128440633:
                if (Operators.CompareString(pcOrientation, "North East", false) == 0)
                {
                  XMLobj.WriteValue(2);
                  goto default;
                }
                else
                  goto default;
              case 1409318971:
                if (Operators.CompareString(pcOrientation, "North West", false) == 0)
                  goto label_22;
                else
                  goto default;
              case 1682370166:
                if (Operators.CompareString(pcOrientation, "NE/NW", false) == 0)
                  goto label_22;
                else
                  goto default;
              case 1731397980:
                if (Operators.CompareString(pcOrientation, "East", false) == 0)
                  goto label_19;
                else
                  goto default;
              case 1734234020:
                if (Operators.CompareString(pcOrientation, "North", false) == 0)
                {
                  XMLobj.WriteValue(1);
                  goto default;
                }
                else
                  goto default;
              case 1796576718:
                if (Operators.CompareString(pcOrientation, "West", false) == 0)
                {
                  XMLobj.WriteValue(7);
                  goto default;
                }
                else
                  goto default;
              case 2417407149:
                if (Operators.CompareString(pcOrientation, "South West", false) == 0)
                {
                  XMLobj.WriteValue(6);
                  goto default;
                }
                else
                  goto default;
              case 2853841879:
                if (Operators.CompareString(pcOrientation, "South East", false) == 0)
                  break;
                goto default;
              case 3017973530:
                if (Operators.CompareString(pcOrientation, "South", false) == 0)
                {
                  XMLobj.WriteValue(5);
                  goto default;
                }
                else
                  goto default;
              case 4260797214:
                if (Operators.CompareString(pcOrientation, "E/W", false) == 0)
                  goto label_19;
                else
                  goto default;
              default:
label_24:
                goto label_25;
            }
            XMLobj.WriteValue(4);
            goto label_24;
label_19:
            XMLobj.WriteValue(3);
            goto label_24;
label_22:
            XMLobj.WriteValue(8);
            goto label_24;
          }
label_25:
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("Pitch");
          string ptilt = SAP_Module.Proj.Dwellings[House].Renewable.Photovoltaic.Photovoltaics[index].PTilt;
          if (Operators.CompareString(ptilt, "Horizontal", false) != 0)
          {
            if (Operators.CompareString(ptilt, "30°", false) != 0)
            {
              if (Operators.CompareString(ptilt, "45°", false) != 0)
              {
                if (Operators.CompareString(ptilt, "60°", false) != 0)
                {
                  if (Operators.CompareString(ptilt, "Vertical", false) == 0)
                    XMLobj.WriteValue(5);
                }
                else
                  XMLobj.WriteValue(4);
              }
              else
                XMLobj.WriteValue(3);
            }
            else
              XMLobj.WriteValue(2);
          }
          else
            XMLobj.WriteValue(1);
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("Overshading");
          string povershading = SAP_Module.Proj.Dwellings[House].Renewable.Photovoltaic.Photovoltaics[index].POvershading;
          if (Operators.CompareString(povershading, "Heavy", false) != 0)
          {
            if (Operators.CompareString(povershading, "Significant", false) != 0)
            {
              if (Operators.CompareString(povershading, "Modest", false) != 0)
              {
                if (Operators.CompareString(povershading, "None or very little", false) == 0)
                  XMLobj.WriteValue(1);
              }
              else
                XMLobj.WriteValue(2);
            }
            else
              XMLobj.WriteValue(3);
          }
          else
            XMLobj.WriteValue(4);
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("PVConnection");
          if (SAP_Module.Proj.Dwellings[House].Renewable.Photovoltaic.Photovoltaics[0].DirectlyConnected)
          {
            XMLobj.WriteValue(2);
          }
          else
          {
            string flatConnection = SAP_Module.Proj.Dwellings[House].Renewable.Photovoltaic.Photovoltaics[0].FlatConnection;
            if (Operators.CompareString(flatConnection, "PV output goes to particular individual flats", false) != 0)
            {
              if (Operators.CompareString(flatConnection, "PV output goes to all flats in proportion to floor area", false) == 0)
                XMLobj.WriteValue(1);
              else
                XMLobj.WriteValue(0);
            }
            else
              XMLobj.WriteValue(2);
          }
          XMLobj.WriteEndElement();
          XMLobj.WriteEndElement();
          checked { ++index; }
        }
        XMLobj.WriteEndElement();
      }
      XMLobj.WriteStartElement("WindTurbinesCount");
      XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Renewable.WindTurbine.WNumber);
      XMLobj.WriteEndElement();
      if (SAP_Module.Proj.Dwellings[House].Renewable.WindTurbine.Inlcude)
      {
        XMLobj.WriteStartElement("WindTurbineRotorDiameter");
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Renewable.WindTurbine.WRDiameter);
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("WindTurbineHubHeight");
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Renewable.WindTurbine.WHeight);
        XMLobj.WriteEndElement();
      }
      XMLobj.WriteStartElement("WindTurbineTerrainType");
      string terrain = SAP_Module.Proj.Dwellings[House].Terrain;
      if (Operators.CompareString(terrain, "Dense urban", false) != 0)
      {
        if (Operators.CompareString(terrain, "Low rise urban / suburban", false) != 0)
        {
          if (Operators.CompareString(terrain, "Rural", false) == 0)
            XMLobj.WriteValue(3);
          else
            XMLobj.WriteValue(1);
        }
        else
          XMLobj.WriteValue(2);
      }
      else
        XMLobj.WriteValue(1);
      XMLobj.WriteEndElement();
      if (SAP_Module.Proj.Dwellings[House].Renewable.AAEGeneration.Inlcude)
      {
        XMLobj.WriteStartElement("HydroElectricGeneration");
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Renewable.AAEGeneration.EGenerated);
        XMLobj.WriteEndElement();
      }
      if ((double) SAP_Module.Proj.Dwellings[House].LowEnergyLight != 0.0)
      {
        XMLobj.WriteStartElement("FixedLightingOutletsCount");
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].LELOutlets);
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("LowEnergyFixedLightingOutletsCount");
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].LELLights);
        XMLobj.WriteEndElement();
      }
      XMLobj.WriteStartElement("LowEnergyFixedLightingOutletsPercentage");
      XMLobj.WriteValue(Math.Round((double) SAP_Module.Proj.Dwellings[House].LowEnergyLight, 0));
      XMLobj.WriteEndElement();
      XMLobj.WriteStartElement("ElectricityTariff");
      string electricityTariff = SAP_Module.Proj.Dwellings[House].MainHeating.ElectricityTariff;
      // ISSUE: reference to a compiler-generated method
      switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(electricityTariff))
      {
        case 1880739446:
          if (Operators.CompareString(electricityTariff, "24-hour tariff", false) == 0)
            goto label_79;
          else
            goto default;
        case 1958420467:
          if (Operators.CompareString(electricityTariff, "24 hour", false) == 0)
            goto label_79;
          else
            goto default;
        case 2140445595:
          if (Operators.CompareString(electricityTariff, "7-hour tariff", false) == 0)
            break;
          goto default;
        case 2339516933:
          if (Operators.CompareString(electricityTariff, "10-hour tariff", false) == 0)
            goto label_78;
          else
            goto default;
        case 3640417453:
          if (Operators.CompareString(electricityTariff, "18-hour tariff", false) == 0)
          {
            XMLobj.WriteValue(5);
            goto default;
          }
          else
            goto default;
        case 3875898503:
          if (Operators.CompareString(electricityTariff, "off-peak 10 hour", false) == 0)
            goto label_78;
          else
            goto default;
        case 4020509270:
          if (Operators.CompareString(electricityTariff, "standard tariff", false) == 0)
          {
            XMLobj.WriteValue(1);
            goto default;
          }
          else
            goto default;
        case 4219766515:
          if (Operators.CompareString(electricityTariff, "off-peak 7 hour", false) == 0)
            break;
          goto default;
        default:
label_81:
          XMLobj.WriteEndElement();
          XMLobj.WriteEndElement();
          return;
      }
      XMLobj.WriteValue(2);
      goto label_81;
label_78:
      XMLobj.WriteValue(3);
      goto label_81;
label_79:
      XMLobj.WriteValue(4);
      goto label_81;
    }

    private void _SAP09DataPropertyDetails_BuildingParts(
      XmlTextWriter XMLobj,
      int House,
      int Country)
    {
      XMLobj.WriteStartElement("BuildingParts");
      XMLobj.WriteStartElement("BuildingPart");
      this._BuildingPartsNumber(XMLobj, House, Country);
      this._BuildingPartsIdentifier(XMLobj, House, Country);
      this._BuildingPartsConstruction(XMLobj, House, Country);
      this._BuildingPartsOvershading(XMLobj, House, Country);
      XMLobj.WriteStartElement("Openings");
      int num = 0;
      if (Operators.CompareString(SAP_Module.Proj.Dwellings[House].PropertyType, "Flat", false) == 0 && (uint) Operators.CompareString(SAP_Module.Proj.Dwellings[House].FlatType, "Ground floor", false) > 0U)
        num = 1;
      this._BuildingPartsDoors(XMLobj, House, Country);
      this._BuildingPartsWindows(XMLobj, House, Country);
      this._BuildingPartsRoofLights(XMLobj, House, Country);
      XMLobj.WriteEndElement();
      this._BuildingPartsFloor(XMLobj, House, Country);
      this._BuildingPartsRoofs(XMLobj, House, Country);
      this._BuildingPartsWalls(XMLobj, House, Country);
      this._BuildingPartsThermal_Bridges(XMLobj, House, Country);
      this._BuildingPartsThermalmass(XMLobj, House, Country);
      XMLobj.WriteEndElement();
      XMLobj.WriteEndElement();
    }

    private void _HQMPropertyDetails(XmlTextWriter XMLobj, int House, int Country)
    {
      XMLobj.WriteStartElement("PropertyDetails");
      try
      {
        this._ReportHeaderProperty(XMLobj, House, Country);
        this._SAP09DataPropertyDetails_propertyType(XMLobj, House, Country);
        this._SAP09DataPropertyDetails_BuitForm(XMLobj, House, Country);
        this._EnergyAssessment_EnergyUse(XMLobj, House, Country);
        this._SAP09DataPropertyDetails_LivingArea(XMLobj, House, Country);
        this._SAP09DataPropertyDetails_Orientation(XMLobj, House, Country);
        this._SAP09DataPropertyDetails_ConservatoryType(XMLobj, House, Country);
        this._SAP09Data_SpecialFeature(XMLobj, House, Country);
        this._SAP09DataPropertyDetails_SmokedArea(XMLobj, House, Country);
        this._SAP09DataPropertyDetails_ElectricityGeneration(XMLobj, House, Country);
        this._SAP09DataPropertyDetails_Design_Water_Use(XMLobj, House, Country);
        this._SAP09DataPropertyDetails_Flat_Details(XMLobj, House, Country);
        this.DefineOpenings(House);
        this._SAP09DataPropertyDetails_Openings(XMLobj, House, Country);
        this._SAP09DataPropertyDetails_BuildingParts(XMLobj, House, Country);
        this._SAP09DataPropertyDetails_Ventilation(XMLobj, House, Country);
        this._SAP09DataPropertyDetails_Heating(XMLobj, House, Country);
        this._SAP09DataPropertyDetails_Cooling(XMLobj, House, Country);
        this._SAP09DataPropertyDetails_SpecialFeatures(XMLobj, House, Country);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      XMLobj.WriteEndElement();
    }

    private bool IsCombi(SAP_Module.Dwelling _House)
    {
      bool flag;
      try
      {
        if (_House.Water.SystemRef == 901)
        {
          if (Operators.CompareString(_House.MainHeating.InforSource, "Boiler Database", false) == 0)
          {
            if (Operators.CompareString(_House.MainHeating.HGroup, "Community heating schemes", false) == 0)
            {
              flag = false;
              goto label_21;
            }
            else
            {
              string sgroup = _House.MainHeating.SGroup;
              if (Operators.CompareString(sgroup, "Heat pumps", false) == 0 || Operators.CompareString(sgroup, "Solid fuel boilers", false) == 0 || Operators.CompareString(sgroup, "Micro-cogeneration (micro-CHP)", false) == 0 || Operators.CompareString(sgroup, "Electric heat pumps", false) == 0)
              {
                flag = false;
                goto label_21;
              }
              else
              {
                object Instance = (object) Calc2012.SEDBUK(_House.MainHeating.SEDBUK);
                if (Instance != null)
                {
                  flag = Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(Instance, (System.Type) null, "MainType", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) 2, false);
                  goto label_21;
                }
              }
            }
          }
          else
          {
            switch (_House.MainHeating.SAPTableCode)
            {
              case 103:
              case 104:
              case 107:
              case 108:
              case 112:
              case 113:
              case 118:
              case 128:
              case 129:
              case 130:
                flag = true;
                goto label_21;
              default:
                flag = false;
                goto label_21;
            }
          }
        }
        else if (_House.Water.SystemRef == 914)
        {
          if (Operators.CompareString(_House.MainHeating2.InforSource, "Boiler Database", false) == 0)
          {
            string sgroup = _House.MainHeating2.SGroup;
            flag = Operators.CompareString(sgroup, "Heat pumps", false) != 0 && Operators.CompareString(sgroup, "Solid fuel boilers", false) != 0 && Operators.CompareString(sgroup, "Micro-cogeneration (micro-CHP)", false) != 0 && Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet((object) Calc2012.SEDBUK(_House.MainHeating2.SEDBUK), (System.Type) null, "MainType", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) 2, false);
            goto label_21;
          }
          else
          {
            switch (_House.MainHeating2.SAPTableCode)
            {
              case 103:
              case 104:
              case 107:
              case 108:
              case 112:
              case 113:
              case 118:
              case 128:
              case 129:
              case 130:
                flag = true;
                goto label_21;
              default:
                flag = false;
                goto label_21;
            }
          }
        }
        else
        {
          flag = false;
          goto label_21;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
label_21:
      return flag;
    }

    public bool IsWetSystem(int SAPcode)
    {
      int num = SAPcode;
      bool flag;
      if (num >= 0 && num <= 400 || num == 602 || num == 604 || num == 606 || num == 622 || num == 624 || num == 632 || num == 636)
        flag = true;
      return flag;
    }

    private void _HeatingMain1(XmlTextWriter XMLobj, int House, int Country)
    {
      // ISSUE: variable of a compiler-generated type
      HQMXML._Closure\u0024__123\u002D0 closure1230_1;
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      HQMXML._Closure\u0024__123\u002D0 closure1230_2 = new HQMXML._Closure\u0024__123\u002D0(closure1230_1);
      // ISSUE: reference to a compiler-generated field
      closure1230_2.\u0024VB\u0024Local_House = House;
      XMLobj.WriteStartElement("MainHeating");
      // ISSUE: reference to a compiler-generated field
      if (!string.IsNullOrEmpty(SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.Fuel))
      {
        XMLobj.WriteStartElement("MainHeatingNumber");
        XMLobj.WriteValue(1);
        XMLobj.WriteEndElement();
      }
      XMLobj.WriteStartElement("MainHeatingCategory");
      // ISSUE: reference to a compiler-generated field
      if (SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.SAPTableCode == 0)
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.InforSource, "Boiler Database", false) == 0 & Operators.CompareString(SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.SGroup, "Microcogeneration (microCHP)", false) == 0)
        {
          XMLobj.WriteValue(3);
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.InforSource, "Boiler Database", false) == 0 & Operators.CompareString(SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.HGroup, "Heat pumps with radiators or underfloor heating", false) == 0)
          {
            XMLobj.WriteValue(4);
          }
          else
          {
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.InforSource, "Boiler Database", false) == 0 & Operators.CompareString(SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.SGroup, "Heat pumps with warm air distribution", false) == 0)
              XMLobj.WriteValue(5);
            else
              XMLobj.WriteValue(2);
          }
        }
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        int sapTableCode = SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.SAPTableCode;
        if (sapTableCode == 699)
          XMLobj.WriteValue(1);
        else if (sapTableCode <= 200)
          XMLobj.WriteValue(2);
        else if (sapTableCode == 1)
          XMLobj.WriteValue(3);
        else if (sapTableCode >= 201 && sapTableCode <= 207 || sapTableCode >= 211 && sapTableCode <= 227)
          XMLobj.WriteValue(4);
        else if (sapTableCode >= 521 && sapTableCode <= 527)
          XMLobj.WriteValue(5);
        else if (sapTableCode >= 301 && sapTableCode <= 310)
          XMLobj.WriteValue(6);
        else if (sapTableCode >= 401 && sapTableCode <= 409)
          XMLobj.WriteValue(7);
        else if (sapTableCode >= 421 && sapTableCode <= 425)
          XMLobj.WriteValue(8);
        else if (sapTableCode >= 501 && sapTableCode <= 527)
          XMLobj.WriteValue(9);
        else if (sapTableCode >= 601 && sapTableCode <= 701)
          XMLobj.WriteValue(10);
        else if (sapTableCode == 701)
          XMLobj.WriteValue(11);
        else
          XMLobj.WriteValue(12);
      }
      XMLobj.WriteEndElement();
      // ISSUE: reference to a compiler-generated field
      string inforSource = SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.InforSource;
      int num1 = Operators.CompareString(inforSource, "Boiler Database", false) == 0 ? 1 : (Operators.CompareString(inforSource, "Manufacturer Declaration", false) == 0 ? 2 : 3);
      XMLobj.WriteStartElement("MainHeatingDataSource");
      XMLobj.WriteValue(num1);
      XMLobj.WriteEndElement();
      if (num1 == 1)
      {
        // ISSUE: reference to a compiler-generated field
        int sapTableCode = SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.SAPTableCode;
        if (sapTableCode < 305 || sapTableCode > 311)
        {
          XMLobj.WriteStartElement("MainHeatingIndexNumber");
          // ISSUE: reference to a compiler-generated field
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.SEDBUK);
          XMLobj.WriteEndElement();
        }
      }
      if (num1 == 2)
      {
        XMLobj.WriteStartElement("IsCondensingBoiler");
        // ISSUE: reference to a compiler-generated field
        switch (SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.SAPTableCode)
        {
          case 132:
          case 133:
            XMLobj.WriteValue("true");
            break;
          default:
            // ISSUE: reference to a compiler-generated field
            if (!string.IsNullOrEmpty(SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.MHType))
            {
              // ISSUE: reference to a compiler-generated field
              if (SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.MHType.Contains("ondens"))
              {
                // ISSUE: reference to a compiler-generated field
                if (SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.MHType.Contains("non"))
                {
                  XMLobj.WriteValue("false");
                  break;
                }
                XMLobj.WriteValue("true");
                break;
              }
              XMLobj.WriteValue("false");
              break;
            }
            XMLobj.WriteValue("false");
            break;
        }
        XMLobj.WriteEndElement();
        // ISSUE: reference to a compiler-generated field
        string fuel = SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.Fuel;
        if (Operators.CompareString(fuel, "mains gas", false) == 0 || Operators.CompareString(fuel, "heating oil", false) == 0 || Operators.CompareString(fuel, "LNG", false) == 0)
        {
          // ISSUE: reference to a compiler-generated field
          int sapTableCode = SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.SAPTableCode;
          int num2;
          switch (sapTableCode)
          {
            case 101:
            case 102:
            case 105:
            case 106:
            case 109:
            case 110:
            case 111:
            case 114:
            case 115:
            case 116:
            case 117:
            case 119:
            case 124:
            case 125:
            case 126:
            case (int) sbyte.MaxValue:
            case 131:
              num2 = 1;
              break;
            default:
              num2 = sapTableCode == 132 ? 1 : 0;
              break;
          }
          if (num2 != 0)
          {
            XMLobj.WriteStartElement("GasOrOilBoilerType");
            XMLobj.WriteValue("1");
            XMLobj.WriteEndElement();
          }
          else if (sapTableCode == 103 || sapTableCode == 104 || sapTableCode == 107 || sapTableCode == 108 || sapTableCode == 112 || sapTableCode == 113 || sapTableCode == 118 || sapTableCode == 128 || sapTableCode == 129 || sapTableCode == 130)
          {
            XMLobj.WriteStartElement("GasOrOilBoilerType");
            XMLobj.WriteValue("2");
            XMLobj.WriteEndElement();
          }
          else if (sapTableCode >= 120 && sapTableCode <= 123)
          {
            XMLobj.WriteStartElement("GasOrOilBoilerType");
            XMLobj.WriteValue("3");
            XMLobj.WriteEndElement();
          }
          else if (sapTableCode >= 133 && sapTableCode <= 141)
          {
            XMLobj.WriteStartElement("GasOrOilBoilerType");
            XMLobj.WriteValue("4");
            XMLobj.WriteEndElement();
          }
        }
        // ISSUE: reference to a compiler-generated field
        switch (SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.SAPTableCode)
        {
          case 103:
          case 104:
          case 107:
          case 108:
          case 112:
          case 113:
          case 118:
          case 128:
          case 129:
          case 130:
            XMLobj.WriteStartElement("CombiBoilerType");
            // ISSUE: reference to a compiler-generated field
            string combiType = SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].Water.CombiType;
            if (Operators.CompareString(combiType, "Instantaneous Combi", false) != 0 && Operators.CompareString(combiType, "", false) != 0)
            {
              if (Operators.CompareString(combiType, "Storage combi boiler, primary store", false) != 0)
              {
                if (Operators.CompareString(combiType, "Storage combi boiler, secondary store", false) == 0)
                  XMLobj.WriteValue("3");
              }
              else
                XMLobj.WriteValue("2");
            }
            else
            {
              // ISSUE: reference to a compiler-generated field
              if (SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.Boiler.IncludeKeepHot)
              {
                // ISSUE: reference to a compiler-generated field
                if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.Boiler.KeepHotFuel, "Main Fuel", false) == 0)
                {
                  // ISSUE: reference to a compiler-generated field
                  if (SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.Boiler.KeepHotTimed)
                    XMLobj.WriteValue("6");
                  else
                    XMLobj.WriteValue("5");
                }
                else
                {
                  // ISSUE: reference to a compiler-generated field
                  if (SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.Boiler.KeepHotTimed)
                    XMLobj.WriteValue("8");
                  else
                    XMLobj.WriteValue("7");
                }
              }
              else
                XMLobj.WriteValue("2");
            }
            XMLobj.WriteEndElement();
            break;
          case 120:
          case 122:
          case 123:
            XMLobj.WriteStartElement("CombiBoilerType");
            XMLobj.WriteValue("4");
            XMLobj.WriteEndElement();
            break;
          case 121:
            XMLobj.WriteStartElement("CombiBoilerType");
            XMLobj.WriteValue("1");
            XMLobj.WriteEndElement();
            break;
          case 133:
          case 139:
            XMLobj.WriteStartElement("CaseHeatEmission");
            // ISSUE: reference to a compiler-generated field
            XMLobj.WriteValue(SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.Range.CasekW);
            XMLobj.WriteEndElement();
            XMLobj.WriteStartElement("HeatTransferToWater");
            // ISSUE: reference to a compiler-generated field
            XMLobj.WriteValue(SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.Range.WaterkW);
            XMLobj.WriteEndElement();
            break;
        }
        // ISSUE: reference to a compiler-generated field
        if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.SGroup, "Solid fuel boilers", false) == 0)
        {
          // ISSUE: reference to a compiler-generated field
          switch (SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.SAPTableCode)
          {
            case 151:
            case 152:
            case 153:
            case 154:
            case 155:
            case 161:
              XMLobj.WriteStartElement("SolidFuelBoilerType");
              XMLobj.WriteValue(1);
              XMLobj.WriteEndElement();
              break;
            case 156:
            case 160:
              XMLobj.WriteStartElement("SolidFuelBoilerType");
              XMLobj.WriteValue(2);
              XMLobj.WriteEndElement();
              break;
            case 158:
            case 159:
              XMLobj.WriteStartElement("SolidFuelBoilerType");
              XMLobj.WriteValue(3);
              XMLobj.WriteEndElement();
              break;
          }
        }
      }
      if (num1 == 3)
      {
        // ISSUE: reference to a compiler-generated field
        int sapTableCode = SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.SAPTableCode;
        if (sapTableCode >= 306 && sapTableCode <= 310)
        {
          // ISSUE: reference to a compiler-generated field
          if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.MHType, "Community boilers", false) == 0)
          {
            XMLobj.WriteStartElement("MainHeatingCode");
            // ISSUE: reference to a compiler-generated field
            XMLobj.WriteValue(SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.SAPTableCode);
            XMLobj.WriteEndElement();
          }
        }
        else
        {
          XMLobj.WriteStartElement("MainHeatingCode");
          // ISSUE: reference to a compiler-generated field
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.SAPTableCode);
          XMLobj.WriteEndElement();
        }
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        if (num1 == 2 && (uint) Operators.CompareString(SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.HGroup, "Community heating schemes", false) > 0U)
        {
          XMLobj.WriteStartElement("MainHeatingDeclaredValues");
          XMLobj.WriteStartElement("MakeModel");
          // ISSUE: reference to a compiler-generated field
          if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.Boiler.Description, (string) null, false) == 0)
          {
            // ISSUE: reference to a compiler-generated field
            SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.Boiler.Description = "";
          }
          // ISSUE: reference to a compiler-generated field
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.Boiler.Description);
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("TestMethod");
          XMLobj.WriteValue("");
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("Efficiency");
          // ISSUE: reference to a compiler-generated field
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.MainEff);
          XMLobj.WriteEndElement();
          XMLobj.WriteEndElement();
        }
      }
      // ISSUE: reference to a compiler-generated field
      if (SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.TableGroup != 3)
      {
        XMLobj.WriteStartElement("MainFuelType");
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        XMLobj.WriteValue(this.FuelCheck(SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.Fuel, closure1230_2.\u0024VB\u0024Local_House));
        XMLobj.WriteEndElement();
      }
      XMLobj.WriteStartElement("MainHeatingControl");
      // ISSUE: reference to a compiler-generated field
      XMLobj.WriteValue(SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.ControlCode);
      XMLobj.WriteEndElement();
      switch (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.ControlCode)
      {
        case 2112:
        case 2207:
        case 2208:
          try
          {
            if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.ControlCodePCDF != null)
            {
              XMLobj.WriteStartElement("TTZCIndexNumber");
              XMLobj.WriteValue(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.ControlCodePCDF);
              XMLobj.WriteEndElement();
              break;
            }
            break;
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
            break;
          }
      }
      // ISSUE: reference to a compiler-generated field
      int sapTableCode1 = SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.SAPTableCode;
      // ISSUE: reference to a compiler-generated field
      if ((sapTableCode1 < 401 || sapTableCode1 > 409) && (sapTableCode1 < 502 || sapTableCode1 > 527) && sapTableCode1 != 156 && sapTableCode1 != 301 && sapTableCode1 != 302 && sapTableCode1 != 304 && sapTableCode1 != 310 && (sapTableCode1 < 601 || sapTableCode1 > 694) && sapTableCode1 != 699 && (uint) Operators.CompareString(SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.HGroup, "Community heating schemes", false) > 0U)
      {
        XMLobj.WriteStartElement("HeatEmitterType");
        // ISSUE: reference to a compiler-generated field
        string emitter1 = SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.Emitter;
        // ISSUE: reference to a compiler-generated method
        switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(emitter1))
        {
          case 83421456:
            if (Operators.CompareString(emitter1, "Underfloor heating and radiators, pipes in concrete slab", false) == 0)
            {
              XMLobj.WriteValue(3);
              XMLobj.WriteEndElement();
              XMLobj.WriteStartElement("UnderfloorHeatEmitterType");
              XMLobj.WriteValue(1);
              XMLobj.WriteEndElement();
              goto label_147;
            }
            else
              goto default;
          case 1150666285:
            if (Operators.CompareString(emitter1, "Underfloor heating and radiators, pipes in insulated timber floor", false) == 0)
            {
              XMLobj.WriteValue(3);
              XMLobj.WriteEndElement();
              XMLobj.WriteStartElement("UnderfloorHeatEmitterType");
              // ISSUE: reference to a compiler-generated field
              string emitter2 = SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.Emitter;
              if (Operators.CompareString(emitter2, "Underfloor heating, pipes in insulated timber floor", false) != 0 && Operators.CompareString(emitter2, "Underfloor heating and radiators, pipes in insulated timber floor", false) != 0)
              {
                if (Operators.CompareString(emitter2, "Underfloor heating, pipes in screed above insulation", false) != 0 && Operators.CompareString(emitter2, "Underfloor heating and radiators, pipes in screed above insulation", false) != 0)
                {
                  if (Operators.CompareString(emitter2, "Underfloor heating, pipes in concrete slab", false) == 0)
                  {
                    XMLobj.WriteValue(1);
                    XMLobj.WriteEndElement();
                    goto label_147;
                  }
                  else
                    goto label_147;
                }
                else
                {
                  XMLobj.WriteValue(2);
                  XMLobj.WriteEndElement();
                  goto label_147;
                }
              }
              else
              {
                XMLobj.WriteValue(3);
                XMLobj.WriteEndElement();
                goto label_147;
              }
            }
            else
              goto default;
          case 1251058319:
            if (Operators.CompareString(emitter1, "Underfloor heating, pipes in insulated timber floor", false) == 0)
              break;
            goto default;
          case 1501161800:
            if (Operators.CompareString(emitter1, "Underfloor heating, pipes in screed above insulation", false) == 0)
            {
              XMLobj.WriteValue(2);
              XMLobj.WriteEndElement();
              XMLobj.WriteStartElement("UnderfloorHeatEmitterType");
              XMLobj.WriteValue(2);
              XMLobj.WriteEndElement();
              goto label_147;
            }
            else
              goto default;
          case 2395580722:
            if (Operators.CompareString(emitter1, "Underfloor heating and radiators, pipes in screed above insulation", false) == 0)
            {
              XMLobj.WriteValue(3);
              XMLobj.WriteEndElement();
              XMLobj.WriteStartElement("UnderfloorHeatEmitterType");
              // ISSUE: reference to a compiler-generated field
              string emitter3 = SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.Emitter;
              if (Operators.CompareString(emitter3, "Underfloor heating, pipes in insulated timber floor", false) != 0)
              {
                if (Operators.CompareString(emitter3, "Underfloor heating, pipes in screed above insulation", false) != 0 && Operators.CompareString(emitter3, "Underfloor heating and radiators, pipes in insulated timber floor", false) != 0 && Operators.CompareString(emitter3, "Underfloor heating and radiators, pipes in screed above insulation", false) != 0)
                {
                  if (Operators.CompareString(emitter3, "Underfloor heating, pipes in concrete slab", false) == 0)
                    XMLobj.WriteValue(1);
                  else
                    XMLobj.WriteValue(2);
                }
                else
                  XMLobj.WriteValue(2);
              }
              else
                XMLobj.WriteValue(3);
              XMLobj.WriteEndElement();
              goto label_147;
            }
            else
              goto default;
          case 2409319762:
            if (Operators.CompareString(emitter1, "Underfloor heating, pipes in concrete slab", false) == 0)
              break;
            goto default;
          case 2565474752:
            if (Operators.CompareString(emitter1, "Systems with radiators", false) == 0)
            {
              XMLobj.WriteValue(1);
              XMLobj.WriteEndElement();
              goto label_147;
            }
            else
              goto default;
          case 3146736266:
            if (Operators.CompareString(emitter1, "Fan coil units", false) == 0)
            {
              XMLobj.WriteValue(4);
              XMLobj.WriteEndElement();
              XMLobj.WriteStartElement("UnderfloorHeatEmitterType");
              // ISSUE: reference to a compiler-generated field
              string emitter4 = SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.Emitter;
              if (Operators.CompareString(emitter4, "Underfloor heating, pipes in insulated timber floor", false) != 0)
              {
                if (Operators.CompareString(emitter4, "Underfloor heating, pipes in screed above insulation", false) != 0 && Operators.CompareString(emitter4, "Underfloor heating and radiators, pipes in insulated timber floor", false) != 0 && Operators.CompareString(emitter4, "Underfloor heating and radiators, pipes in screed above insulation", false) != 0)
                {
                  if (Operators.CompareString(emitter4, "Underfloor heating, pipes in concrete slab", false) == 0)
                    XMLobj.WriteValue(1);
                  else
                    XMLobj.WriteValue(2);
                }
                else
                  XMLobj.WriteValue(2);
              }
              else
                XMLobj.WriteValue(3);
              XMLobj.WriteEndElement();
              goto label_147;
            }
            else
              goto default;
          default:
            XMLobj.WriteValue(1);
            XMLobj.WriteEndElement();
            goto label_147;
        }
        XMLobj.WriteValue(2);
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("UnderfloorHeatEmitterType");
        // ISSUE: reference to a compiler-generated field
        string emitter5 = SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.Emitter;
        if (Operators.CompareString(emitter5, "Underfloor heating, pipes in insulated timber floor", false) != 0)
        {
          if (Operators.CompareString(emitter5, "Underfloor heating, pipes in screed above insulation", false) != 0 && Operators.CompareString(emitter5, "Underfloor heating and radiators, pipes in insulated timber floor", false) != 0 && Operators.CompareString(emitter5, "Underfloor heating and radiators, pipes in screed above insulation", false) != 0)
          {
            if (Operators.CompareString(emitter5, "Systems with radiators", false) == 0 || Operators.CompareString(emitter5, "Underfloor heating, pipes in concrete slab", false) == 0)
              XMLobj.WriteValue(1);
            else
              XMLobj.WriteValue(2);
          }
          else
            XMLobj.WriteValue(2);
        }
        else
          XMLobj.WriteValue(3);
        XMLobj.WriteEndElement();
label_147:;
      }
      bool flag;
      // ISSUE: reference to a compiler-generated field
      if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.HGroup, "Community heating schemes", false) == 0)
        flag = true;
      // ISSUE: reference to a compiler-generated field
      if (!flag && SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.Boiler.LoadWeather)
      {
        // ISSUE: reference to a compiler-generated field
        if (Conversion.Val(SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.ControlCodePCDFWeather) > 0.0)
        {
          XMLobj.WriteStartElement("LoadOrWeatherCompensation");
          XMLobj.WriteValue(4);
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("CompensatingControllerIndexNumber");
          // ISSUE: reference to a compiler-generated field
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.ControlCodePCDFWeather);
          XMLobj.WriteEndElement();
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          if (SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.Compensator != null)
          {
            XMLobj.WriteStartElement("LoadOrWeatherCompensation");
            // ISSUE: reference to a compiler-generated field
            string compensator = SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.Compensator;
            if (Operators.CompareString(compensator, "Weather Compensation", false) != 0 && Operators.CompareString(compensator, "Weather Compensator", false) != 0)
            {
              if (Operators.CompareString(compensator, "Load Compensation", false) != 0 && Operators.CompareString(compensator, "Load compensator", false) != 0)
              {
                if (Operators.CompareString(compensator, "Enhanced Load Compensator", false) != 0)
                {
                  if (Operators.CompareString(compensator, "Load or weather compensation (database)", false) == 0)
                    XMLobj.WriteValue(4);
                  else
                    XMLobj.WriteValue(0);
                }
                else
                  XMLobj.WriteValue(3);
              }
              else
                XMLobj.WriteValue(1);
            }
            else
              XMLobj.WriteValue(2);
            XMLobj.WriteEndElement();
          }
        }
      }
      if (num1 == 1)
      {
        // ISSUE: reference to a compiler-generated field
        if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.SGroup, "Microcogeneration (microCHP)", false) == 0)
        {
          // ISSUE: reference to a compiler-generated method
          this.SearchRowCHP = SAP_Module.PCDFData.CHPs.Where<PCDF.CHP>(new Func<PCDF.CHP, bool>(closure1230_2._Lambda\u0024__0)).SingleOrDefault<PCDF.CHP>();
          XMLobj.WriteStartElement("MainHeatingFlueType");
          XMLobj.WriteValue(this.SearchRowCHP.Flue_Type);
          XMLobj.WriteEndElement();
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.SGroup, "Solid fuel boilers", false) == 0)
          {
            XMLobj.WriteStartElement("MainHeatingFlueType");
            // ISSUE: reference to a compiler-generated method
            this.SearchSolidBoilerRow = SAP_Module.PCDFData.Solid_Boilers.Where<PCDF.SEDBUK_Solid>(new Func<PCDF.SEDBUK_Solid, bool>(closure1230_2._Lambda\u0024__1)).SingleOrDefault<PCDF.SEDBUK_Solid>();
            if (string.IsNullOrEmpty(this.SearchSolidBoilerRow.Flue))
              XMLobj.WriteValue(1);
            else
              XMLobj.WriteValue(this.SearchSolidBoilerRow.Flue);
            XMLobj.WriteEndElement();
            if (Operators.CompareString(this.SearchSolidBoilerRow.FanAssist, Conversions.ToString(2), false) == 0)
            {
              XMLobj.WriteStartElement("IsFlueFanPresent");
              XMLobj.WriteValue("true");
              XMLobj.WriteEndElement();
            }
            else
            {
              XMLobj.WriteStartElement("IsFlueFanPresent");
              XMLobj.WriteValue("false");
              XMLobj.WriteEndElement();
            }
          }
          else
          {
            // ISSUE: reference to a compiler-generated field
            if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.SGroup, "Gas boilers and oil boilers", false) == 0)
            {
              XMLobj.WriteStartElement("MainHeatingFlueType");
              // ISSUE: reference to a compiler-generated method
              this.SearchBoilerRow = SAP_Module.PCDFData.Boilers.Where<PCDF.SEDBUK>(new Func<PCDF.SEDBUK, bool>(closure1230_2._Lambda\u0024__2)).SingleOrDefault<PCDF.SEDBUK>();
              if (this.SearchBoilerRow.FlueType == null)
                XMLobj.WriteValue(1);
              else
                XMLobj.WriteValue(this.SearchBoilerRow.FlueType);
              XMLobj.WriteEndElement();
              XMLobj.WriteStartElement("IsFlueFanPresent");
              if (Operators.CompareString(this.SearchBoilerRow.FanAssist, "2", false) == 0)
                XMLobj.WriteValue("true");
              else
                XMLobj.WriteValue("false");
              XMLobj.WriteEndElement();
            }
          }
        }
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        int sapTableCode2 = SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.SAPTableCode;
        // ISSUE: reference to a compiler-generated field
        if ((sapTableCode2 < 300 || sapTableCode2 >= 501 && sapTableCode2 <= 527 || sapTableCode2 == 636) && (uint) Operators.CompareString(SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.Fuel, "Electricity", false) > 0U)
        {
          XMLobj.WriteStartElement("MainHeatingFlueType");
          // ISSUE: reference to a compiler-generated field
          string flueType = SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.Boiler.FlueType;
          // ISSUE: reference to a compiler-generated method
          switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(flueType))
          {
            case 572081497:
              if (Operators.CompareString(flueType, "omitted", false) == 0)
              {
                XMLobj.WriteValue(4);
                goto default;
              }
              else
                goto default;
            case 1401622761:
              if (Operators.CompareString(flueType, "Open", false) == 0)
                break;
              goto default;
            case 1533154807:
              if (Operators.CompareString(flueType, "balanced flue", false) == 0)
                goto label_197;
              else
                goto default;
            case 1537289947:
              if (Operators.CompareString(flueType, "open flue", false) == 0)
                break;
              goto default;
            case 1708018833:
              if (Operators.CompareString(flueType, "Room-sealed", false) == 0)
                goto label_197;
              else
                goto default;
            case 1845819738:
              if (Operators.CompareString(flueType, "unknown (there is a flue, but its type could not be determined)", false) == 0)
                goto label_200;
              else
                goto default;
            case 2166136261:
              if (Operators.CompareString(flueType, "", false) == 0)
                goto label_200;
              else
                goto default;
            case 2391940020:
              if (Operators.CompareString(flueType, "Chimney", false) == 0)
              {
                XMLobj.WriteValue(3);
                goto default;
              }
              else
                goto default;
            case 3424652889:
              if (Operators.CompareString(flueType, "Unknown", false) == 0)
                goto label_200;
              else
                goto default;
            default:
label_201:
              XMLobj.WriteEndElement();
              // ISSUE: reference to a compiler-generated field
              if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.InforSource, "SAP Tables", false) == 0)
              {
                XMLobj.WriteStartElement("IsFlueFanPresent");
                // ISSUE: reference to a compiler-generated field
                if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.Boiler.FanFlued, "Yes", false) == 0)
                  XMLobj.WriteValue("true");
                else
                  XMLobj.WriteValue("false");
                XMLobj.WriteEndElement();
              }
              goto label_207;
          }
          XMLobj.WriteValue(1);
          goto label_201;
label_197:
          XMLobj.WriteValue(2);
          goto label_201;
label_200:
          XMLobj.WriteValue(5);
          goto label_201;
        }
label_207:;
      }
      // ISSUE: reference to a compiler-generated field
      if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SAPTableCode != 527 && !string.IsNullOrEmpty(SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.Emitter))
      {
        XMLobj.WriteStartElement("IsCentralHeatingPumpInHeatedSpace");
        // ISSUE: reference to a compiler-generated field
        if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.Boiler.PumpHP, "Yes", false) == 0)
          XMLobj.WriteValue("true");
        else
          XMLobj.WriteValue("false");
        XMLobj.WriteEndElement();
      }
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.Fuel, "heating oil", false) == 0 | Operators.CompareString(SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.Fuel, "biodiesel from any biomass source", false) == 0 | Operators.CompareString(SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.Fuel, "appliances able to use mineral oil or liquid biofuel", false) == 0)
      {
        XMLobj.WriteStartElement("IsOilPumpInHeatedSpace");
        // ISSUE: reference to a compiler-generated field
        if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.Boiler.PumpHP, "Yes", false) == 0)
          XMLobj.WriteValue("true");
        else
          XMLobj.WriteValue("false");
        XMLobj.WriteEndElement();
      }
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      if (this.IsWetSystem(SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.SAPTableCode) && !string.IsNullOrEmpty(SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.Emitter) && SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.Emitter.Contains("radiator") | SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.Emitter.Contains("nderfloor") && (uint) Operators.CompareString(SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.HGroup, "MicroCongeneration (MicroCHP)", false) > 0U)
      {
        XMLobj.WriteStartElement("IsInterlockedSystem");
        // ISSUE: reference to a compiler-generated field
        if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.Boiler.BILock, "Yes", false) == 0)
          XMLobj.WriteValue("true");
        else
          XMLobj.WriteValue("false");
        XMLobj.WriteEndElement();
      }
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      if ((uint) Operators.CompareString(SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.HGroup, "Heat pumps with radiators or underfloor heating", false) > 0U & (uint) Operators.CompareString(SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.HGroup, "Community heating schemes", false) > 0U)
      {
        // ISSUE: reference to a compiler-generated field
        int sapTableCode3 = SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.SAPTableCode;
        if (sapTableCode3 != 223 && (sapTableCode3 < 305 || sapTableCode3 > 311))
        {
          XMLobj.WriteStartElement("HasSeparateDelayedStart");
          // ISSUE: reference to a compiler-generated field
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.DelayedStart);
          XMLobj.WriteEndElement();
        }
      }
      // ISSUE: reference to a compiler-generated field
      if (num1 == 3 & Operators.CompareString(SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.SGroup, "Solid fuel boilers", false) == 0)
      {
        XMLobj.WriteStartElement("BoilerFuelFeed");
        XMLobj.WriteValue(1);
        XMLobj.WriteEndElement();
      }
      // ISSUE: reference to a compiler-generated field
      int sapTableCode4 = SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.SAPTableCode;
      if (sapTableCode4 >= 151 && sapTableCode4 <= 161 || sapTableCode4 >= 631 && sapTableCode4 <= 636)
      {
        XMLobj.WriteStartElement("IsMainHeatingHETASApproved");
        // ISSUE: reference to a compiler-generated field
        if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.HETAS, "Yes", false) == 0)
          XMLobj.WriteValue("true");
        else
          XMLobj.WriteValue("false");
        XMLobj.WriteEndElement();
      }
      // ISSUE: reference to a compiler-generated field
      if (SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.SAPTableCode == 192)
      {
        XMLobj.WriteStartElement("ElectricCPSUOperatingTemperature");
        // ISSUE: reference to a compiler-generated field
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].Water.CPSUTemp);
        XMLobj.WriteEndElement();
      }
      // ISSUE: reference to a compiler-generated field
      if (!SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].IncludeMainHeating2)
      {
        XMLobj.WriteStartElement("MainHeatingFraction");
        XMLobj.WriteValue(1);
        XMLobj.WriteEndElement();
      }
      else
      {
        XMLobj.WriteStartElement("MainHeatingFraction");
        // ISSUE: reference to a compiler-generated field
        XMLobj.WriteValue(Math.Round(1.0 - (double) SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].HeatFractionSec, 2));
        XMLobj.WriteEndElement();
      }
      if (num1 == 2)
      {
        // ISSUE: reference to a compiler-generated field
        switch (SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.SAPTableCode)
        {
          case 130:
          case 133:
            XMLobj.WriteStartElement("BurnerControl");
            // ISSUE: reference to a compiler-generated field
            string fuelBurningType = SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.FuelBurningType;
            if (Operators.CompareString(fuelBurningType, "Unknown", false) != 0)
            {
              if (Operators.CompareString(fuelBurningType, "On/off", false) != 0)
              {
                if (Operators.CompareString(fuelBurningType, "Modulation", false) != 0)
                {
                  if (Operators.CompareString(fuelBurningType, "electrical", false) != 0)
                  {
                    if (Operators.CompareString(fuelBurningType, "manual", false) == 0)
                      XMLobj.WriteValue("5");
                    else
                      XMLobj.WriteValue("1");
                  }
                  else
                    XMLobj.WriteValue("4");
                }
                else
                  XMLobj.WriteValue("3");
              }
              else
                XMLobj.WriteValue("2");
            }
            else
              XMLobj.WriteValue("1");
            XMLobj.WriteEndElement();
            break;
        }
      }
      // ISSUE: reference to a compiler-generated field
      if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.InforSource, "Boiler Database", false) == 0)
      {
        try
        {
          // ISSUE: reference to a compiler-generated field
          PCDF.SEDBUK sedbuk = Calc2012.SEDBUK(SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.SEDBUK);
          try
          {
            if (sedbuk.SubType.Equals("1"))
            {
              // ISSUE: reference to a compiler-generated field
              SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].Water.FGHRS.Include = true;
            }
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
      }
      // ISSUE: reference to a compiler-generated field
      if (SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].Water.FGHRS.Include)
      {
        XMLobj.WriteStartElement("HasFGHRS");
        // ISSUE: reference to a compiler-generated field
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].Water.FGHRS.Include);
        XMLobj.WriteEndElement();
        // ISSUE: reference to a compiler-generated field
        if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.InforSource, "Boiler Database", false) == 0)
        {
          // ISSUE: reference to a compiler-generated field
          if (!string.IsNullOrEmpty(SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].Water.FGHRS.IndexNo))
          {
            XMLobj.WriteStartElement("FGHRSIndexNumber");
            // ISSUE: reference to a compiler-generated field
            XMLobj.WriteValue(SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].Water.FGHRS.IndexNo);
            XMLobj.WriteEndElement();
          }
          else
          {
            // ISSUE: reference to a compiler-generated field
            PCDF.SEDBUK sedbuk = Calc2012.SEDBUK(SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.SEDBUK);
            try
            {
              if (sedbuk.SubType.Equals("1"))
              {
                XMLobj.WriteStartElement("FGHRSIndexNumber");
                // ISSUE: reference to a compiler-generated field
                XMLobj.WriteValue(SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.SEDBUK);
                XMLobj.WriteEndElement();
              }
            }
            catch (Exception ex)
            {
              ProjectData.SetProjectError(ex);
              ProjectData.ClearProjectError();
            }
          }
        }
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        if (SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].Water.FGHRS.PV.Photovoltaics != null && SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].Water.FGHRS.PV.Photovoltaics.Length > 0)
        {
          XMLobj.WriteStartElement("FGHRSEnergySource");
          XMLobj.WriteStartElement("PVArrays");
          XMLobj.WriteStartElement("PVArray");
          XMLobj.WriteStartElement("PeakPower");
          // ISSUE: reference to a compiler-generated field
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].Water.FGHRS.PV.Photovoltaics[0].PPower);
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("Orientation");
          // ISSUE: reference to a compiler-generated field
          string pcOrientation = SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].Water.FGHRS.PV.Photovoltaics[0].PCOrientation;
          // ISSUE: reference to a compiler-generated method
          switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(pcOrientation))
          {
            case 912749504:
              if (Operators.CompareString(pcOrientation, "SE/SW", false) == 0)
                break;
              goto default;
            case 1128440633:
              if (Operators.CompareString(pcOrientation, "North East", false) == 0)
              {
                XMLobj.WriteValue(2);
                goto default;
              }
              else
                goto default;
            case 1409318971:
              if (Operators.CompareString(pcOrientation, "North West", false) == 0)
                goto label_290;
              else
                goto default;
            case 1682370166:
              if (Operators.CompareString(pcOrientation, "NE/NW", false) == 0)
                goto label_290;
              else
                goto default;
            case 1731397980:
              if (Operators.CompareString(pcOrientation, "East", false) == 0)
                goto label_287;
              else
                goto default;
            case 1734234020:
              if (Operators.CompareString(pcOrientation, "North", false) == 0)
              {
                XMLobj.WriteValue(1);
                goto default;
              }
              else
                goto default;
            case 1796576718:
              if (Operators.CompareString(pcOrientation, "West", false) == 0)
              {
                XMLobj.WriteValue(7);
                goto default;
              }
              else
                goto default;
            case 2417407149:
              if (Operators.CompareString(pcOrientation, "South West", false) == 0)
              {
                XMLobj.WriteValue(6);
                goto default;
              }
              else
                goto default;
            case 2853841879:
              if (Operators.CompareString(pcOrientation, "South East", false) == 0)
                break;
              goto default;
            case 3017973530:
              if (Operators.CompareString(pcOrientation, "South", false) == 0)
              {
                XMLobj.WriteValue(5);
                goto default;
              }
              else
                goto default;
            case 4260797214:
              if (Operators.CompareString(pcOrientation, "E/W", false) == 0)
                goto label_287;
              else
                goto default;
            default:
label_292:
              XMLobj.WriteEndElement();
              XMLobj.WriteStartElement("Pitch");
              // ISSUE: reference to a compiler-generated field
              string ptilt = SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].Water.FGHRS.PV.Photovoltaics[0].PTilt;
              if (Operators.CompareString(ptilt, "Horizontal", false) != 0)
              {
                if (Operators.CompareString(ptilt, "30°", false) != 0)
                {
                  if (Operators.CompareString(ptilt, "45°", false) != 0)
                  {
                    if (Operators.CompareString(ptilt, "60°", false) != 0)
                    {
                      if (Operators.CompareString(ptilt, "Vertical", false) == 0)
                        XMLobj.WriteValue(5);
                    }
                    else
                      XMLobj.WriteValue(4);
                  }
                  else
                    XMLobj.WriteValue(3);
                }
                else
                  XMLobj.WriteValue(2);
              }
              else
                XMLobj.WriteValue(1);
              XMLobj.WriteEndElement();
              XMLobj.WriteStartElement("Overshading");
              // ISSUE: reference to a compiler-generated field
              string povershading = SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].Water.FGHRS.PV.Photovoltaics[0].POvershading;
              if (Operators.CompareString(povershading, "Heavy", false) != 0)
              {
                if (Operators.CompareString(povershading, "Significant", false) != 0)
                {
                  if (Operators.CompareString(povershading, "Modest", false) != 0)
                  {
                    if (Operators.CompareString(povershading, "None or very little", false) == 0)
                      XMLobj.WriteValue(1);
                  }
                  else
                    XMLobj.WriteValue(2);
                }
                else
                  XMLobj.WriteValue(3);
              }
              else
                XMLobj.WriteValue(4);
              XMLobj.WriteEndElement();
              XMLobj.WriteStartElement("PVConnection");
              // ISSUE: reference to a compiler-generated field
              if (SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].Water.FGHRS.PV.Photovoltaics[0].DirectlyConnected)
              {
                XMLobj.WriteValue(2);
              }
              else
              {
                // ISSUE: reference to a compiler-generated field
                string flatConnection = SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].Water.FGHRS.PV.Photovoltaics[0].FlatConnection;
                if (Operators.CompareString(flatConnection, "PV output goes to particular individual flats", false) != 0)
                {
                  if (Operators.CompareString(flatConnection, "PV output goes to all flats in proportion to floor area", false) == 0)
                    XMLobj.WriteValue(1);
                  else
                    XMLobj.WriteValue(0);
                }
                else
                  XMLobj.WriteValue(2);
              }
              XMLobj.WriteEndElement();
              XMLobj.WriteEndElement();
              XMLobj.WriteEndElement();
              goto label_319;
          }
          XMLobj.WriteValue(4);
          goto label_292;
label_287:
          XMLobj.WriteValue(3);
          goto label_292;
label_290:
          XMLobj.WriteValue(8);
          goto label_292;
        }
label_319:;
      }
      // ISSUE: reference to a compiler-generated field
      int sapTableCode5 = SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.SAPTableCode;
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      if (sapTableCode5 >= 401 && sapTableCode5 <= 409 && SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.StorageHeaters != null && SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.MHType != null && Operators.CompareString(SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.MHType, "High heat retention storage heaters", false) == 0)
      {
        XMLobj.WriteStartElement("StorageHeaters");
        // ISSUE: reference to a compiler-generated field
        int num3 = checked (SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.StorageHeaters.Count - 1);
        int index = 0;
        while (index <= num3)
        {
          XMLobj.WriteStartElement("StorageHeater");
          XMLobj.WriteStartElement("NumberOfHeaters");
          // ISSUE: reference to a compiler-generated field
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.StorageHeaters[index].Number_Of_Heaters);
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("IndexNumber");
          // ISSUE: reference to a compiler-generated field
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.StorageHeaters[index].Index_Number);
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("HighHeatRetention");
          XMLobj.WriteValue("true");
          XMLobj.WriteEndElement();
          XMLobj.WriteEndElement();
          checked { ++index; }
        }
        XMLobj.WriteEndElement();
      }
      // ISSUE: reference to a compiler-generated field
      if (SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.Boiler.FlowTemp != null)
      {
        XMLobj.WriteStartElement("EmitterTemperature");
        // ISSUE: reference to a compiler-generated field
        string flowTemp = SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.Boiler.FlowTemp;
        if (Operators.CompareString(flowTemp, "Unknown", false) != 0)
        {
          if (Operators.CompareString(flowTemp, "Design flow temperature >45°C", false) != 0)
          {
            if (Operators.CompareString(flowTemp, "Design flow temperature<=45°C", false) != 0)
            {
              if (Operators.CompareString(flowTemp, "Design flow temperature<=35°C", false) == 0)
                XMLobj.WriteValue(4);
              else
                XMLobj.WriteValue("NA");
            }
            else
              XMLobj.WriteValue(2);
          }
          else
            XMLobj.WriteValue(1);
        }
        else
          XMLobj.WriteValue(0);
        XMLobj.WriteEndElement();
        // ISSUE: reference to a compiler-generated field
        string sgroup = SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.SGroup;
        // ISSUE: reference to a compiler-generated field
        if (Operators.CompareString(sgroup, "Solid fuel room heaters", false) != 0 && Operators.CompareString(sgroup, "Microcogeneration (microCHP)", false) != 0 && Operators.CompareString(sgroup, "MicroCongeneration (MicroCHP)", false) != 0 && (uint) Operators.CompareString(SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.HGroup, "Community heating schemes", false) > 0U)
        {
          XMLobj.WriteStartElement("CentralHeatingPumpAge");
          // ISSUE: reference to a compiler-generated field
          string pumpType = SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.Boiler.PumpType;
          if (Operators.CompareString(pumpType, "2013 or later", false) != 0)
          {
            if (Operators.CompareString(pumpType, "2012 or earlier", false) == 0)
              XMLobj.WriteValue(1);
            else
              XMLobj.WriteValue(0);
          }
          else
            XMLobj.WriteValue(2);
          XMLobj.WriteEndElement();
        }
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.HGroup, "MicroCongeneration (MicroCHP)", false) == 0 | Operators.CompareString(SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.HGroup, "Microcongeneration (MicroCHP)", false) == 0 | Operators.CompareString(SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.HGroup, "Community heating schemes", false) == 0 | Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.HGroup, "Electric storage systems", false) == 0)
        {
          XMLobj.WriteStartElement("EmitterTemperature");
          // ISSUE: reference to a compiler-generated field
          string flowTemp = SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.Boiler.FlowTemp;
          if (Operators.CompareString(flowTemp, "Unknown", false) != 0)
          {
            if (Operators.CompareString(flowTemp, "Design flow temperature >45°C", false) != 0)
            {
              if (Operators.CompareString(flowTemp, "Design flow temperature<=45°C", false) != 0)
              {
                if (Operators.CompareString(flowTemp, "Design flow temperature<=35°C", false) == 0)
                  XMLobj.WriteValue(4);
                else
                  XMLobj.WriteValue("NA");
              }
              else
                XMLobj.WriteValue(2);
            }
            else
              XMLobj.WriteValue(1);
          }
          else
            XMLobj.WriteValue(0);
          XMLobj.WriteEndElement();
        }
      }
      // ISSUE: reference to a compiler-generated field
      if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.HGroup, "Heat pumps with radiators or underfloor heating", false) == 0)
      {
        XMLobj.WriteStartElement("MCSInstalledHeatPump");
        // ISSUE: reference to a compiler-generated field
        if (SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.MCSCert)
          XMLobj.WriteValue("true");
        else
          XMLobj.WriteValue("false");
        XMLobj.WriteEndElement();
      }
      // ISSUE: reference to a compiler-generated field
      if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.HGroup, "MicroCongeneration (MicroCHP)", false) == 0)
      {
        XMLobj.WriteStartElement("CentralHeatingPumpAge");
        // ISSUE: reference to a compiler-generated field
        string pumpType = SAP_Module.Proj.Dwellings[closure1230_2.\u0024VB\u0024Local_House].MainHeating.Boiler.PumpType;
        if (Operators.CompareString(pumpType, "2013 or later", false) != 0)
        {
          if (Operators.CompareString(pumpType, "2012 or earlier", false) == 0)
            XMLobj.WriteValue(1);
          else
            XMLobj.WriteValue(0);
        }
        else
          XMLobj.WriteValue(2);
        XMLobj.WriteEndElement();
      }
      XMLobj.WriteEndElement();
    }

    private void _HeatingMain2(XmlTextWriter XMLobj, int House, int Country)
    {
      // ISSUE: variable of a compiler-generated type
      HQMXML._Closure\u0024__124\u002D0 closure1240_1;
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      HQMXML._Closure\u0024__124\u002D0 closure1240_2 = new HQMXML._Closure\u0024__124\u002D0(closure1240_1);
      // ISSUE: reference to a compiler-generated field
      closure1240_2.\u0024VB\u0024Local_House = House;
      // ISSUE: reference to a compiler-generated field
      if (!SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].IncludeMainHeating2)
        return;
      XMLobj.WriteStartElement("MainHeating");
      // ISSUE: reference to a compiler-generated field
      if (!string.IsNullOrEmpty(SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating2.Fuel))
      {
        XMLobj.WriteStartElement("MainHeatingNumber");
        XMLobj.WriteValue(2);
        XMLobj.WriteEndElement();
      }
      XMLobj.WriteStartElement("MainHeatingCategory");
      // ISSUE: reference to a compiler-generated field
      if (SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating2.SAPTableCode == 0)
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating2.InforSource, "Boiler Database", false) == 0 & Operators.CompareString(SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating2.SGroup, "Microcogeneration (microCHP)", false) == 0)
        {
          XMLobj.WriteValue(3);
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating2.InforSource, "Boiler Database", false) == 0 & Operators.CompareString(SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating2.HGroup, "Heat pumps with radiators or underfloor heating", false) == 0)
          {
            XMLobj.WriteValue(4);
          }
          else
          {
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating2.InforSource, "Boiler Database", false) == 0 & Operators.CompareString(SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating2.SGroup, "Heat pumps with warm air distribution", false) == 0)
              XMLobj.WriteValue(5);
            else
              XMLobj.WriteValue(2);
          }
        }
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        int sapTableCode = SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating2.SAPTableCode;
        if (sapTableCode == 699)
          XMLobj.WriteValue(1);
        else if (sapTableCode <= 200)
          XMLobj.WriteValue(2);
        else if (sapTableCode == 1)
          XMLobj.WriteValue(3);
        else if (sapTableCode >= 201 && sapTableCode <= 207 || sapTableCode >= 211 && sapTableCode <= 227)
          XMLobj.WriteValue(4);
        else if (sapTableCode >= 521 && sapTableCode <= 527)
          XMLobj.WriteValue(5);
        else if (sapTableCode >= 301 && sapTableCode <= 310)
          XMLobj.WriteValue(6);
        else if (sapTableCode >= 401 && sapTableCode <= 409)
          XMLobj.WriteValue(7);
        else if (sapTableCode >= 421 && sapTableCode <= 425)
          XMLobj.WriteValue(8);
        else if (sapTableCode >= 501 && sapTableCode <= 527)
          XMLobj.WriteValue(9);
        else if (sapTableCode >= 601 && sapTableCode <= 701)
          XMLobj.WriteValue(10);
        else if (sapTableCode == 701)
          XMLobj.WriteValue(11);
        else
          XMLobj.WriteValue(12);
      }
      XMLobj.WriteEndElement();
      // ISSUE: reference to a compiler-generated field
      string inforSource = SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating2.InforSource;
      int num1 = Operators.CompareString(inforSource, "Boiler Database", false) == 0 ? 1 : (Operators.CompareString(inforSource, "Manufacturer Declaration", false) == 0 ? 2 : 3);
      XMLobj.WriteStartElement("MainHeatingDataSource");
      XMLobj.WriteValue(num1);
      XMLobj.WriteEndElement();
      if (num1 == 1)
      {
        // ISSUE: reference to a compiler-generated field
        int sapTableCode = SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating2.SAPTableCode;
        if (sapTableCode < 305 || sapTableCode > 311)
        {
          XMLobj.WriteStartElement("MainHeatingIndexNumber");
          // ISSUE: reference to a compiler-generated field
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating2.SEDBUK);
          XMLobj.WriteEndElement();
        }
      }
      if (num1 == 2)
      {
        XMLobj.WriteStartElement("IsCondensingBoiler");
        // ISSUE: reference to a compiler-generated field
        switch (SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating2.SAPTableCode)
        {
          case 132:
          case 133:
            XMLobj.WriteValue("true");
            break;
          default:
            // ISSUE: reference to a compiler-generated field
            if (!string.IsNullOrEmpty(SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating2.MHType))
            {
              // ISSUE: reference to a compiler-generated field
              if (SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating2.MHType.Contains("ondens"))
              {
                // ISSUE: reference to a compiler-generated field
                if (SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating2.MHType.Contains("non"))
                {
                  XMLobj.WriteValue("false");
                  break;
                }
                XMLobj.WriteValue("true");
                break;
              }
              XMLobj.WriteValue("false");
              break;
            }
            XMLobj.WriteValue("false");
            break;
        }
        XMLobj.WriteEndElement();
        // ISSUE: reference to a compiler-generated field
        string fuel = SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating2.Fuel;
        if (Operators.CompareString(fuel, "mains gas", false) == 0 || Operators.CompareString(fuel, "heating oil", false) == 0 || Operators.CompareString(fuel, "LNG", false) == 0)
        {
          // ISSUE: reference to a compiler-generated field
          int sapTableCode = SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating2.SAPTableCode;
          int num2;
          switch (sapTableCode)
          {
            case 101:
            case 102:
            case 105:
            case 106:
            case 109:
            case 110:
            case 111:
            case 114:
            case 115:
            case 116:
            case 117:
            case 119:
            case 124:
            case 125:
            case 126:
            case (int) sbyte.MaxValue:
            case 131:
              num2 = 1;
              break;
            default:
              num2 = sapTableCode == 132 ? 1 : 0;
              break;
          }
          if (num2 != 0)
          {
            XMLobj.WriteStartElement("GasOrOilBoilerType");
            XMLobj.WriteValue("1");
            XMLobj.WriteEndElement();
          }
          else if (sapTableCode == 103 || sapTableCode == 104 || sapTableCode == 107 || sapTableCode == 108 || sapTableCode == 112 || sapTableCode == 113 || sapTableCode == 118 || sapTableCode == 128 || sapTableCode == 129 || sapTableCode == 130)
          {
            XMLobj.WriteStartElement("GasOrOilBoilerType");
            XMLobj.WriteValue("2");
            XMLobj.WriteEndElement();
          }
          else if (sapTableCode >= 120 && sapTableCode <= 123)
          {
            XMLobj.WriteStartElement("GasOrOilBoilerType");
            XMLobj.WriteValue("3");
            XMLobj.WriteEndElement();
          }
          else if (sapTableCode >= 133 && sapTableCode <= 141)
          {
            XMLobj.WriteStartElement("GasOrOilBoilerType");
            XMLobj.WriteValue("4");
            XMLobj.WriteEndElement();
          }
        }
        // ISSUE: reference to a compiler-generated field
        switch (SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating2.SAPTableCode)
        {
          case 103:
          case 104:
          case 107:
          case 108:
          case 112:
          case 113:
          case 118:
          case 128:
          case 129:
          case 130:
            XMLobj.WriteStartElement("CombiBoilerType");
            // ISSUE: reference to a compiler-generated field
            string combiType = SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].Water.CombiType;
            if (Operators.CompareString(combiType, "Instantaneous Combi", false) != 0 && Operators.CompareString(combiType, "", false) != 0)
            {
              if (Operators.CompareString(combiType, "Storage combi boiler, primary store", false) != 0)
              {
                if (Operators.CompareString(combiType, "Storage combi boiler, secondary store", false) == 0)
                  XMLobj.WriteValue("3");
              }
              else
                XMLobj.WriteValue("2");
            }
            else
            {
              // ISSUE: reference to a compiler-generated field
              if (SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating2.Boiler.IncludeKeepHot)
              {
                // ISSUE: reference to a compiler-generated field
                if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating2.Boiler.KeepHotFuel, "Main Fuel", false) == 0)
                {
                  // ISSUE: reference to a compiler-generated field
                  if (SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating2.Boiler.KeepHotTimed)
                    XMLobj.WriteValue("6");
                  else
                    XMLobj.WriteValue("5");
                }
                else
                {
                  // ISSUE: reference to a compiler-generated field
                  if (SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating2.Boiler.KeepHotTimed)
                    XMLobj.WriteValue("8");
                  else
                    XMLobj.WriteValue("7");
                }
              }
              else
                XMLobj.WriteValue("2");
            }
            XMLobj.WriteEndElement();
            break;
          case 120:
          case 122:
          case 123:
            XMLobj.WriteStartElement("CombiBoilerType");
            XMLobj.WriteValue("4");
            XMLobj.WriteEndElement();
            break;
          case 121:
            XMLobj.WriteStartElement("CombiBoilerType");
            XMLobj.WriteValue("1");
            XMLobj.WriteEndElement();
            break;
          case 133:
          case 139:
            XMLobj.WriteStartElement("CaseHeatEmission");
            // ISSUE: reference to a compiler-generated field
            XMLobj.WriteValue(SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating2.Range.CasekW);
            XMLobj.WriteEndElement();
            XMLobj.WriteStartElement("HeatTransferToWater");
            // ISSUE: reference to a compiler-generated field
            XMLobj.WriteValue(SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating2.Range.WaterkW);
            XMLobj.WriteEndElement();
            break;
        }
        // ISSUE: reference to a compiler-generated field
        if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating2.SGroup, "Solid fuel boilers", false) == 0)
        {
          // ISSUE: reference to a compiler-generated field
          switch (SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating2.SAPTableCode)
          {
            case 151:
            case 152:
            case 153:
            case 154:
            case 155:
            case 161:
              XMLobj.WriteStartElement("SolidFuelBoilerType");
              XMLobj.WriteValue(1);
              XMLobj.WriteEndElement();
              break;
            case 156:
            case 160:
              XMLobj.WriteStartElement("SolidFuelBoilerType");
              XMLobj.WriteValue(2);
              XMLobj.WriteEndElement();
              break;
            case 158:
            case 159:
              XMLobj.WriteStartElement("SolidFuelBoilerType");
              XMLobj.WriteValue(3);
              XMLobj.WriteEndElement();
              break;
          }
        }
      }
      if (num1 == 3)
      {
        // ISSUE: reference to a compiler-generated field
        int sapTableCode = SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating2.SAPTableCode;
        if (sapTableCode >= 306 && sapTableCode <= 310)
        {
          // ISSUE: reference to a compiler-generated field
          if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating2.MHType, "Community boilers", false) == 0)
          {
            XMLobj.WriteStartElement("MainHeatingCode");
            // ISSUE: reference to a compiler-generated field
            XMLobj.WriteValue(SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating2.SAPTableCode);
            XMLobj.WriteEndElement();
          }
        }
        else
        {
          XMLobj.WriteStartElement("MainHeatingCode");
          // ISSUE: reference to a compiler-generated field
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating2.SAPTableCode);
          XMLobj.WriteEndElement();
        }
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        if (num1 == 2 && (uint) Operators.CompareString(SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating2.HGroup, "Community heating schemes", false) > 0U)
        {
          XMLobj.WriteStartElement("MainHeatingDeclaredValues");
          XMLobj.WriteStartElement("MakeModel");
          // ISSUE: reference to a compiler-generated field
          if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating2.Boiler.Description, (string) null, false) == 0)
          {
            // ISSUE: reference to a compiler-generated field
            SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating2.Boiler.Description = "";
          }
          // ISSUE: reference to a compiler-generated field
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating2.Boiler.Description);
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("TestMethod");
          XMLobj.WriteValue("");
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("Efficiency");
          // ISSUE: reference to a compiler-generated field
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating2.MainEff);
          XMLobj.WriteEndElement();
          XMLobj.WriteEndElement();
        }
      }
      // ISSUE: reference to a compiler-generated field
      if (SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating2.TableGroup != 3)
      {
        XMLobj.WriteStartElement("MainFuelType");
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        XMLobj.WriteValue(this.FuelCheck(SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating2.Fuel, closure1240_2.\u0024VB\u0024Local_House));
        XMLobj.WriteEndElement();
      }
      XMLobj.WriteStartElement("MainHeatingControl");
      // ISSUE: reference to a compiler-generated field
      XMLobj.WriteValue(SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating2.ControlCode);
      XMLobj.WriteEndElement();
      switch (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.ControlCode)
      {
        case 2112:
        case 2207:
        case 2208:
          if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.ControlCodePCDF != null)
          {
            XMLobj.WriteStartElement("TTZCIndexNumber");
            XMLobj.WriteValue(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.ControlCodePCDF);
            XMLobj.WriteEndElement();
            break;
          }
          break;
      }
      // ISSUE: reference to a compiler-generated field
      int sapTableCode1 = SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating2.SAPTableCode;
      if ((sapTableCode1 < 401 || sapTableCode1 > 409) && (sapTableCode1 < 502 || sapTableCode1 > 527) && sapTableCode1 != 156 && sapTableCode1 != 301 && sapTableCode1 != 302 && sapTableCode1 != 304 && sapTableCode1 != 310 && (sapTableCode1 < 601 || sapTableCode1 > 694) && sapTableCode1 != 699)
      {
        XMLobj.WriteStartElement("HeatEmitterType");
        // ISSUE: reference to a compiler-generated field
        string emitter1 = SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating2.Emitter;
        // ISSUE: reference to a compiler-generated method
        switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(emitter1))
        {
          case 83421456:
            if (Operators.CompareString(emitter1, "Underfloor heating and radiators, pipes in concrete slab", false) == 0)
            {
              XMLobj.WriteValue(3);
              XMLobj.WriteEndElement();
              XMLobj.WriteStartElement("UnderfloorHeatEmitterType");
              XMLobj.WriteValue(1);
              XMLobj.WriteEndElement();
              goto label_146;
            }
            else
              goto default;
          case 1150666285:
            if (Operators.CompareString(emitter1, "Underfloor heating and radiators, pipes in insulated timber floor", false) == 0)
            {
              XMLobj.WriteValue(3);
              XMLobj.WriteEndElement();
              XMLobj.WriteStartElement("UnderfloorHeatEmitterType");
              // ISSUE: reference to a compiler-generated field
              string emitter2 = SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating2.Emitter;
              if (Operators.CompareString(emitter2, "Underfloor heating, pipes in insulated timber floor", false) != 0 && Operators.CompareString(emitter2, "Underfloor heating and radiators, pipes in insulated timber floor", false) != 0)
              {
                if (Operators.CompareString(emitter2, "Underfloor heating, pipes in screed above insulation", false) != 0 && Operators.CompareString(emitter2, "Underfloor heating and radiators, pipes in screed above insulation", false) != 0)
                {
                  if (Operators.CompareString(emitter2, "Underfloor heating, pipes in concrete slab", false) == 0)
                  {
                    XMLobj.WriteValue(1);
                    XMLobj.WriteEndElement();
                    goto label_146;
                  }
                  else
                    goto label_146;
                }
                else
                {
                  XMLobj.WriteValue(2);
                  XMLobj.WriteEndElement();
                  goto label_146;
                }
              }
              else
              {
                XMLobj.WriteValue(3);
                XMLobj.WriteEndElement();
                goto label_146;
              }
            }
            else
              goto default;
          case 1251058319:
            if (Operators.CompareString(emitter1, "Underfloor heating, pipes in insulated timber floor", false) == 0)
              break;
            goto default;
          case 1501161800:
            if (Operators.CompareString(emitter1, "Underfloor heating, pipes in screed above insulation", false) == 0)
            {
              XMLobj.WriteValue(2);
              XMLobj.WriteEndElement();
              XMLobj.WriteStartElement("UnderfloorHeatEmitterType");
              XMLobj.WriteValue(2);
              XMLobj.WriteEndElement();
              goto label_146;
            }
            else
              goto default;
          case 2395580722:
            if (Operators.CompareString(emitter1, "Underfloor heating and radiators, pipes in screed above insulation", false) == 0)
            {
              XMLobj.WriteValue(3);
              XMLobj.WriteEndElement();
              XMLobj.WriteStartElement("UnderfloorHeatEmitterType");
              // ISSUE: reference to a compiler-generated field
              string emitter3 = SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating2.Emitter;
              if (Operators.CompareString(emitter3, "Underfloor heating, pipes in insulated timber floor", false) != 0)
              {
                if (Operators.CompareString(emitter3, "Underfloor heating, pipes in screed above insulation", false) != 0 && Operators.CompareString(emitter3, "Underfloor heating and radiators, pipes in insulated timber floor", false) != 0 && Operators.CompareString(emitter3, "Underfloor heating and radiators, pipes in screed above insulation", false) != 0)
                {
                  if (Operators.CompareString(emitter3, "Underfloor heating, pipes in concrete slab", false) == 0)
                    XMLobj.WriteValue(1);
                  else
                    XMLobj.WriteValue(2);
                }
                else
                  XMLobj.WriteValue(2);
              }
              else
                XMLobj.WriteValue(3);
              XMLobj.WriteEndElement();
              goto label_146;
            }
            else
              goto default;
          case 2409319762:
            if (Operators.CompareString(emitter1, "Underfloor heating, pipes in concrete slab", false) == 0)
              break;
            goto default;
          case 2565474752:
            if (Operators.CompareString(emitter1, "Systems with radiators", false) == 0)
            {
              XMLobj.WriteValue(1);
              XMLobj.WriteEndElement();
              goto label_146;
            }
            else
              goto default;
          case 3146736266:
            if (Operators.CompareString(emitter1, "Fan coil units", false) == 0)
            {
              XMLobj.WriteValue(4);
              XMLobj.WriteEndElement();
              XMLobj.WriteStartElement("UnderfloorHeatEmitterType");
              // ISSUE: reference to a compiler-generated field
              string emitter4 = SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating2.Emitter;
              if (Operators.CompareString(emitter4, "Underfloor heating, pipes in insulated timber floor", false) != 0)
              {
                if (Operators.CompareString(emitter4, "Underfloor heating, pipes in screed above insulation", false) != 0 && Operators.CompareString(emitter4, "Underfloor heating and radiators, pipes in insulated timber floor", false) != 0 && Operators.CompareString(emitter4, "Underfloor heating and radiators, pipes in screed above insulation", false) != 0)
                {
                  if (Operators.CompareString(emitter4, "Underfloor heating, pipes in concrete slab", false) == 0)
                    XMLobj.WriteValue(1);
                  else
                    XMLobj.WriteValue(2);
                }
                else
                  XMLobj.WriteValue(2);
              }
              else
                XMLobj.WriteValue(3);
              XMLobj.WriteEndElement();
              goto label_146;
            }
            else
              goto default;
          default:
            XMLobj.WriteValue(1);
            XMLobj.WriteEndElement();
            goto label_146;
        }
        XMLobj.WriteValue(2);
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("UnderfloorHeatEmitterType");
        // ISSUE: reference to a compiler-generated field
        string emitter5 = SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating2.Emitter;
        if (Operators.CompareString(emitter5, "Underfloor heating, pipes in insulated timber floor", false) != 0)
        {
          if (Operators.CompareString(emitter5, "Underfloor heating, pipes in screed above insulation", false) != 0 && Operators.CompareString(emitter5, "Underfloor heating and radiators, pipes in insulated timber floor", false) != 0 && Operators.CompareString(emitter5, "Underfloor heating and radiators, pipes in screed above insulation", false) != 0)
          {
            if (Operators.CompareString(emitter5, "Systems with radiators", false) == 0 || Operators.CompareString(emitter5, "Underfloor heating, pipes in concrete slab", false) == 0)
              XMLobj.WriteValue(1);
            else
              XMLobj.WriteValue(2);
          }
          else
            XMLobj.WriteValue(2);
        }
        else
          XMLobj.WriteValue(3);
        XMLobj.WriteEndElement();
label_146:;
      }
      bool flag;
      // ISSUE: reference to a compiler-generated field
      if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating2.HGroup, "Community heating schemes", false) == 0)
        flag = true;
      if (!flag)
      {
        // ISSUE: reference to a compiler-generated field
        if (Conversions.ToDouble(SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating2.ControlCodePCDFWeather) > 0.0)
        {
          XMLobj.WriteStartElement("LoadOrWeatherCompensation");
          XMLobj.WriteValue(4);
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("CompensatingControllerIndexNumber");
          // ISSUE: reference to a compiler-generated field
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating2.ControlCodePCDFWeather);
          XMLobj.WriteEndElement();
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          if (!string.IsNullOrEmpty(SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating2.Compensator))
          {
            XMLobj.WriteStartElement("LoadOrWeatherCompensation");
            // ISSUE: reference to a compiler-generated field
            string compensator = SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating2.Compensator;
            if (Operators.CompareString(compensator, "Weather Compensation", false) != 0 && Operators.CompareString(compensator, "Weather Compensator", false) != 0)
            {
              if (Operators.CompareString(compensator, "Load Compensation", false) != 0 && Operators.CompareString(compensator, "Load compensator", false) != 0)
              {
                if (Operators.CompareString(compensator, "Enhanced Load Compensator", false) != 0)
                {
                  if (Operators.CompareString(compensator, "Load or weather compensation (database)", false) == 0)
                    XMLobj.WriteValue(4);
                  else
                    XMLobj.WriteValue(0);
                }
                else
                  XMLobj.WriteValue(3);
              }
              else
                XMLobj.WriteValue(1);
            }
            else
              XMLobj.WriteValue(2);
            XMLobj.WriteEndElement();
          }
        }
      }
      if (num1 == 1)
      {
        // ISSUE: reference to a compiler-generated field
        if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating2.SGroup, "Microcogeneration (microCHP)", false) == 0)
        {
          // ISSUE: reference to a compiler-generated method
          this.SearchRowCHP = SAP_Module.PCDFData.CHPs.Where<PCDF.CHP>(new Func<PCDF.CHP, bool>(closure1240_2._Lambda\u0024__0)).SingleOrDefault<PCDF.CHP>();
          XMLobj.WriteStartElement("MainHeatingFlueType");
          XMLobj.WriteValue(this.SearchRowCHP.Flue_Type);
          XMLobj.WriteEndElement();
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating2.SGroup, "Solid fuel boilers", false) == 0)
          {
            XMLobj.WriteStartElement("MainHeatingFlueType");
            // ISSUE: reference to a compiler-generated method
            this.SearchSolidBoilerRow = SAP_Module.PCDFData.Solid_Boilers.Where<PCDF.SEDBUK_Solid>(new Func<PCDF.SEDBUK_Solid, bool>(closure1240_2._Lambda\u0024__1)).SingleOrDefault<PCDF.SEDBUK_Solid>();
            if (string.IsNullOrEmpty(this.SearchSolidBoilerRow.Flue))
              XMLobj.WriteValue(1);
            else
              XMLobj.WriteValue(this.SearchSolidBoilerRow.Flue);
            XMLobj.WriteEndElement();
            if (Operators.CompareString(this.SearchSolidBoilerRow.FanAssist, Conversions.ToString(2), false) == 0)
            {
              XMLobj.WriteStartElement("IsFlueFanPresent");
              XMLobj.WriteValue("true");
              XMLobj.WriteEndElement();
            }
            else
            {
              XMLobj.WriteStartElement("IsFlueFanPresent");
              XMLobj.WriteValue("false");
              XMLobj.WriteEndElement();
            }
          }
          else
          {
            // ISSUE: reference to a compiler-generated field
            if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating2.SGroup, "Gas boilers and oil boilers", false) == 0)
            {
              XMLobj.WriteStartElement("MainHeatingFlueType");
              // ISSUE: reference to a compiler-generated method
              this.SearchBoilerRow = SAP_Module.PCDFData.Boilers.Where<PCDF.SEDBUK>(new Func<PCDF.SEDBUK, bool>(closure1240_2._Lambda\u0024__2)).SingleOrDefault<PCDF.SEDBUK>();
              if (this.SearchBoilerRow.FlueType == null)
                XMLobj.WriteValue(1);
              else
                XMLobj.WriteValue(this.SearchBoilerRow.FlueType);
              XMLobj.WriteEndElement();
              XMLobj.WriteStartElement("IsFlueFanPresent");
              if (Operators.CompareString(this.SearchBoilerRow.FanAssist, "2", false) == 0)
                XMLobj.WriteValue("true");
              else
                XMLobj.WriteValue("false");
              XMLobj.WriteEndElement();
            }
          }
        }
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        int sapTableCode2 = SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating2.SAPTableCode;
        // ISSUE: reference to a compiler-generated field
        if (sapTableCode2 != 636 && (sapTableCode2 < 300 || sapTableCode2 >= 501 && sapTableCode2 <= 527 || sapTableCode2 == 636) && (uint) Operators.CompareString(SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating2.Fuel, "Electricity", false) > 0U)
        {
          XMLobj.WriteStartElement("MainHeatingFlueType");
          // ISSUE: reference to a compiler-generated field
          string flueType = SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating2.Boiler.FlueType;
          // ISSUE: reference to a compiler-generated method
          switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(flueType))
          {
            case 572081497:
              if (Operators.CompareString(flueType, "omitted", false) == 0)
              {
                XMLobj.WriteValue(4);
                goto default;
              }
              else
                goto default;
            case 1401622761:
              if (Operators.CompareString(flueType, "Open", false) == 0)
                break;
              goto default;
            case 1533154807:
              if (Operators.CompareString(flueType, "balanced flue", false) == 0)
                goto label_196;
              else
                goto default;
            case 1537289947:
              if (Operators.CompareString(flueType, "open flue", false) == 0)
                break;
              goto default;
            case 1708018833:
              if (Operators.CompareString(flueType, "Room-sealed", false) == 0)
                goto label_196;
              else
                goto default;
            case 1845819738:
              if (Operators.CompareString(flueType, "unknown (there is a flue, but its type could not be determined)", false) == 0)
                goto label_199;
              else
                goto default;
            case 2166136261:
              if (Operators.CompareString(flueType, "", false) == 0)
                goto label_199;
              else
                goto default;
            case 2391940020:
              if (Operators.CompareString(flueType, "Chimney", false) == 0)
              {
                XMLobj.WriteValue(3);
                goto default;
              }
              else
                goto default;
            case 3424652889:
              if (Operators.CompareString(flueType, "Unknown", false) == 0)
                goto label_199;
              else
                goto default;
            default:
label_200:
              XMLobj.WriteEndElement();
              // ISSUE: reference to a compiler-generated field
              if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating2.InforSource, "SAP Tables", false) == 0)
              {
                XMLobj.WriteStartElement("IsFlueFanPresent");
                // ISSUE: reference to a compiler-generated field
                if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating2.Boiler.FanFlued, "Yes", false) == 0)
                  XMLobj.WriteValue("true");
                else
                  XMLobj.WriteValue("false");
                XMLobj.WriteEndElement();
              }
              goto label_206;
          }
          XMLobj.WriteValue(1);
          goto label_200;
label_196:
          XMLobj.WriteValue(2);
          goto label_200;
label_199:
          XMLobj.WriteValue(5);
          goto label_200;
        }
label_206:;
      }
      // ISSUE: reference to a compiler-generated field
      if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SAPTableCode != 527 && !string.IsNullOrEmpty(SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating2.Emitter))
      {
        XMLobj.WriteStartElement("IsCentralHeatingPumpInHeatedSpace");
        // ISSUE: reference to a compiler-generated field
        if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating2.Boiler.PumpHP, "Yes", false) == 0)
          XMLobj.WriteValue("true");
        else
          XMLobj.WriteValue("false");
        XMLobj.WriteEndElement();
      }
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating2.Fuel, "heating oil", false) == 0 | Operators.CompareString(SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating2.Fuel, "biodiesel from any biomass source", false) == 0 | Operators.CompareString(SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating2.Fuel, "appliances able to use mineral oil or liquid biofuel", false) == 0)
      {
        XMLobj.WriteStartElement("IsOilPumpInHeatedSpace");
        // ISSUE: reference to a compiler-generated field
        if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating2.Boiler.PumpHP, "Yes", false) == 0)
          XMLobj.WriteValue("true");
        else
          XMLobj.WriteValue("false");
        XMLobj.WriteEndElement();
      }
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      if (this.IsWetSystem(SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating2.SAPTableCode) && !string.IsNullOrEmpty(SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating2.Emitter) && SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating2.Emitter.Contains("radiator") | SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating2.Emitter.Contains("nderfloor"))
      {
        XMLobj.WriteStartElement("IsInterlockedSystem");
        // ISSUE: reference to a compiler-generated field
        if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating2.Boiler.BILock, "Yes", false) == 0)
          XMLobj.WriteValue("true");
        else
          XMLobj.WriteValue("false");
        XMLobj.WriteEndElement();
      }
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      if ((uint) Operators.CompareString(SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating2.HGroup, "Heat pumps with radiators or underfloor heating", false) > 0U & (uint) Operators.CompareString(SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating2.HGroup, "Community heating schemes", false) > 0U)
      {
        // ISSUE: reference to a compiler-generated field
        int sapTableCode3 = SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating2.SAPTableCode;
        if (sapTableCode3 != 223 && (sapTableCode3 < 305 || sapTableCode3 > 311))
        {
          XMLobj.WriteStartElement("HasSeparateDelayedStart");
          // ISSUE: reference to a compiler-generated field
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating2.DelayedStart);
          XMLobj.WriteEndElement();
        }
      }
      // ISSUE: reference to a compiler-generated field
      if (num1 == 3 & Operators.CompareString(SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating2.SGroup, "Solid fuel boilers", false) == 0)
      {
        XMLobj.WriteStartElement("BoilerFuelFeed");
        XMLobj.WriteValue(1);
        XMLobj.WriteEndElement();
      }
      // ISSUE: reference to a compiler-generated field
      int sapTableCode4 = SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating2.SAPTableCode;
      if (sapTableCode4 >= 151 && sapTableCode4 <= 161 || sapTableCode4 >= 631 && sapTableCode4 <= 636)
      {
        XMLobj.WriteStartElement("IsMainHeatingHETASApproved");
        // ISSUE: reference to a compiler-generated field
        if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating2.HETAS, "Yes", false) == 0)
          XMLobj.WriteValue("true");
        else
          XMLobj.WriteValue("false");
        XMLobj.WriteEndElement();
      }
      // ISSUE: reference to a compiler-generated field
      if (SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating2.SAPTableCode == 192)
      {
        XMLobj.WriteStartElement("ElectricCPSUOperatingTemperature");
        // ISSUE: reference to a compiler-generated field
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].Water.CPSUTemp);
        XMLobj.WriteEndElement();
      }
      // ISSUE: reference to a compiler-generated field
      if (!SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].IncludeMainHeating2)
      {
        XMLobj.WriteStartElement("MainHeatingFraction");
        XMLobj.WriteValue(1);
        XMLobj.WriteEndElement();
      }
      else
      {
        XMLobj.WriteStartElement("MainHeatingFraction");
        // ISSUE: reference to a compiler-generated field
        XMLobj.WriteValue(Math.Round((double) SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].HeatFractionSec, 2));
        XMLobj.WriteEndElement();
      }
      if (num1 == 2)
      {
        // ISSUE: reference to a compiler-generated field
        switch (SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating2.SAPTableCode)
        {
          case 130:
          case 133:
            XMLobj.WriteStartElement("BurnerControl");
            // ISSUE: reference to a compiler-generated field
            string fuelBurningType = SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating2.FuelBurningType;
            if (Operators.CompareString(fuelBurningType, "Unknown", false) != 0)
            {
              if (Operators.CompareString(fuelBurningType, "On/off", false) != 0)
              {
                if (Operators.CompareString(fuelBurningType, "Modulation", false) != 0)
                {
                  if (Operators.CompareString(fuelBurningType, "electrical", false) != 0)
                  {
                    if (Operators.CompareString(fuelBurningType, "manual", false) == 0)
                      XMLobj.WriteValue("5");
                    else
                      XMLobj.WriteValue("1");
                  }
                  else
                    XMLobj.WriteValue("4");
                }
                else
                  XMLobj.WriteValue("3");
              }
              else
                XMLobj.WriteValue("2");
            }
            else
              XMLobj.WriteValue("1");
            XMLobj.WriteEndElement();
            XMLobj.WriteStartElement("EfficiencyType");
            // ISSUE: reference to a compiler-generated field
            if (SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating2.SEDBUK2005)
            {
              XMLobj.WriteValue(2);
            }
            else
            {
              // ISSUE: reference to a compiler-generated field
              if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating2.SEDBUK, "", false) == 0)
              {
                XMLobj.WriteValue(3);
              }
              else
              {
                // ISSUE: reference to a compiler-generated field
                if (Conversions.ToBoolean(SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating2.SEDBUK))
                  XMLobj.WriteValue(4);
                else
                  XMLobj.WriteValue(1);
              }
            }
            XMLobj.WriteEndElement();
            break;
        }
      }
      // ISSUE: reference to a compiler-generated field
      if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating2.InforSource, "Boiler Database", false) == 0)
      {
        try
        {
          // ISSUE: reference to a compiler-generated field
          PCDF.SEDBUK sedbuk = Calc2012.SEDBUK(SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating2.SEDBUK);
          try
          {
            if (sedbuk.SubType.Equals("1"))
            {
              // ISSUE: reference to a compiler-generated field
              SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].Water.FGHRS.Include = true;
            }
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
      }
      // ISSUE: reference to a compiler-generated field
      if (SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].Water.FGHRS.Include)
      {
        XMLobj.WriteStartElement("HasFGHRS");
        // ISSUE: reference to a compiler-generated field
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].Water.FGHRS.Include);
        XMLobj.WriteEndElement();
        // ISSUE: reference to a compiler-generated field
        if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating2.InforSource, "Boiler Database", false) == 0)
        {
          // ISSUE: reference to a compiler-generated field
          if (!string.IsNullOrEmpty(SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].Water.FGHRS.IndexNo))
          {
            XMLobj.WriteStartElement("FGHRSIndexNumber");
            // ISSUE: reference to a compiler-generated field
            XMLobj.WriteValue(SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].Water.FGHRS.IndexNo);
            XMLobj.WriteEndElement();
          }
          else
          {
            // ISSUE: reference to a compiler-generated field
            PCDF.SEDBUK sedbuk = Calc2012.SEDBUK(SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating2.SEDBUK);
            try
            {
              if (sedbuk.SubType.Equals("1"))
              {
                XMLobj.WriteStartElement("FGHRSIndexNumber");
                // ISSUE: reference to a compiler-generated field
                XMLobj.WriteValue(SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating2.SEDBUK);
                XMLobj.WriteEndElement();
              }
            }
            catch (Exception ex)
            {
              ProjectData.SetProjectError(ex);
              ProjectData.ClearProjectError();
            }
          }
        }
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        if (SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].Water.FGHRS.PV.Photovoltaics != null && SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].Water.FGHRS.PV.Photovoltaics.Length > 0)
        {
          XMLobj.WriteStartElement("FGHRSEnergySource");
          XMLobj.WriteStartElement("PVArrays");
          XMLobj.WriteStartElement("PVArray");
          XMLobj.WriteStartElement("PeakPower");
          // ISSUE: reference to a compiler-generated field
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].Water.FGHRS.PV.Photovoltaics[0].PPower);
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("Orientation");
          // ISSUE: reference to a compiler-generated field
          string pcOrientation = SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].Water.FGHRS.PV.Photovoltaics[0].PCOrientation;
          // ISSUE: reference to a compiler-generated method
          switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(pcOrientation))
          {
            case 912749504:
              if (Operators.CompareString(pcOrientation, "SE/SW", false) == 0)
                break;
              goto default;
            case 1128440633:
              if (Operators.CompareString(pcOrientation, "North East", false) == 0)
              {
                XMLobj.WriteValue(2);
                goto default;
              }
              else
                goto default;
            case 1409318971:
              if (Operators.CompareString(pcOrientation, "North West", false) == 0)
                goto label_296;
              else
                goto default;
            case 1682370166:
              if (Operators.CompareString(pcOrientation, "NE/NW", false) == 0)
                goto label_296;
              else
                goto default;
            case 1731397980:
              if (Operators.CompareString(pcOrientation, "East", false) == 0)
                goto label_293;
              else
                goto default;
            case 1734234020:
              if (Operators.CompareString(pcOrientation, "North", false) == 0)
              {
                XMLobj.WriteValue(1);
                goto default;
              }
              else
                goto default;
            case 1796576718:
              if (Operators.CompareString(pcOrientation, "West", false) == 0)
              {
                XMLobj.WriteValue(7);
                goto default;
              }
              else
                goto default;
            case 2417407149:
              if (Operators.CompareString(pcOrientation, "South West", false) == 0)
              {
                XMLobj.WriteValue(6);
                goto default;
              }
              else
                goto default;
            case 2853841879:
              if (Operators.CompareString(pcOrientation, "South East", false) == 0)
                break;
              goto default;
            case 3017973530:
              if (Operators.CompareString(pcOrientation, "South", false) == 0)
              {
                XMLobj.WriteValue(5);
                goto default;
              }
              else
                goto default;
            case 4260797214:
              if (Operators.CompareString(pcOrientation, "E/W", false) == 0)
                goto label_293;
              else
                goto default;
            default:
label_298:
              XMLobj.WriteEndElement();
              XMLobj.WriteStartElement("Pitch");
              // ISSUE: reference to a compiler-generated field
              string ptilt = SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].Water.FGHRS.PV.Photovoltaics[0].PTilt;
              if (Operators.CompareString(ptilt, "Horizontal", false) != 0)
              {
                if (Operators.CompareString(ptilt, "30°", false) != 0)
                {
                  if (Operators.CompareString(ptilt, "45°", false) != 0)
                  {
                    if (Operators.CompareString(ptilt, "60°", false) != 0)
                    {
                      if (Operators.CompareString(ptilt, "Vertical", false) == 0)
                        XMLobj.WriteValue(5);
                    }
                    else
                      XMLobj.WriteValue(4);
                  }
                  else
                    XMLobj.WriteValue(3);
                }
                else
                  XMLobj.WriteValue(2);
              }
              else
                XMLobj.WriteValue(1);
              XMLobj.WriteEndElement();
              XMLobj.WriteStartElement("Overshading");
              // ISSUE: reference to a compiler-generated field
              string povershading = SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].Water.FGHRS.PV.Photovoltaics[0].POvershading;
              if (Operators.CompareString(povershading, "Heavy", false) != 0)
              {
                if (Operators.CompareString(povershading, "Significant", false) != 0)
                {
                  if (Operators.CompareString(povershading, "Modest", false) != 0)
                  {
                    if (Operators.CompareString(povershading, "None or very little", false) == 0)
                      XMLobj.WriteValue(1);
                  }
                  else
                    XMLobj.WriteValue(2);
                }
                else
                  XMLobj.WriteValue(3);
              }
              else
                XMLobj.WriteValue(4);
              XMLobj.WriteEndElement();
              XMLobj.WriteStartElement("PVConnection");
              // ISSUE: reference to a compiler-generated field
              if (SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].Water.FGHRS.PV.Photovoltaics[0].DirectlyConnected)
              {
                XMLobj.WriteValue(2);
              }
              else
              {
                // ISSUE: reference to a compiler-generated field
                string flatConnection = SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].Water.FGHRS.PV.Photovoltaics[0].FlatConnection;
                if (Operators.CompareString(flatConnection, "PV output goes to particular individual flats", false) != 0)
                {
                  if (Operators.CompareString(flatConnection, "PV output goes to all flats in proportion to floor area", false) == 0)
                    XMLobj.WriteValue(1);
                  else
                    XMLobj.WriteValue(0);
                }
                else
                  XMLobj.WriteValue(2);
              }
              XMLobj.WriteEndElement();
              XMLobj.WriteEndElement();
              XMLobj.WriteEndElement();
              goto label_325;
          }
          XMLobj.WriteValue(4);
          goto label_298;
label_293:
          XMLobj.WriteValue(3);
          goto label_298;
label_296:
          XMLobj.WriteValue(8);
          goto label_298;
        }
label_325:;
      }
      // ISSUE: reference to a compiler-generated field
      switch (SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating2.SAPTableCode)
      {
        case 401:
        case 402:
        case 403:
        case 404:
        case 405:
        case 406:
        case 407:
        case 408:
        case 409:
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          if (SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating2.StorageHeaters != null && SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating.MHType != null && Operators.CompareString(SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating.MHType, "High heat retention storage heaters", false) == 0)
          {
            XMLobj.WriteStartElement("StorageHeaters");
            // ISSUE: reference to a compiler-generated field
            int num3 = checked (SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating2.StorageHeaters.Count - 1);
            int index = 0;
            while (index <= num3)
            {
              XMLobj.WriteStartElement("StorageHeater");
              XMLobj.WriteStartElement("NumberOfHeaters");
              // ISSUE: reference to a compiler-generated field
              XMLobj.WriteValue(SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating2.StorageHeaters[index].Number_Of_Heaters);
              XMLobj.WriteEndElement();
              XMLobj.WriteStartElement("IndexNumber");
              // ISSUE: reference to a compiler-generated field
              XMLobj.WriteValue(SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating2.StorageHeaters[index].Index_Number);
              XMLobj.WriteEndElement();
              XMLobj.WriteStartElement("HighHeatRetention");
              XMLobj.WriteValue("true");
              XMLobj.WriteEndElement();
              XMLobj.WriteEndElement();
              checked { ++index; }
            }
            XMLobj.WriteEndElement();
            break;
          }
          break;
      }
      // ISSUE: reference to a compiler-generated field
      if (SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating2.Boiler.FlowTemp != null)
      {
        XMLobj.WriteStartElement("EmitterTemperature");
        // ISSUE: reference to a compiler-generated field
        string flowTemp = SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating2.Boiler.FlowTemp;
        if (Operators.CompareString(flowTemp, "Unknown", false) != 0)
        {
          if (Operators.CompareString(flowTemp, "Design flow temperature >45°C", false) != 0)
          {
            if (Operators.CompareString(flowTemp, "Design flow temperature<=45°C", false) != 0)
            {
              if (Operators.CompareString(flowTemp, "Design flow temperature<=35°C", false) == 0)
                XMLobj.WriteValue(4);
              else
                XMLobj.WriteValue("NA");
            }
            else
              XMLobj.WriteValue(2);
          }
          else
            XMLobj.WriteValue(1);
        }
        else
          XMLobj.WriteValue(0);
        XMLobj.WriteEndElement();
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating2.SGroup, "Solid fuel room heaters", false) != 0 && (uint) Operators.CompareString(SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating2.HGroup, "Community heating schemes", false) > 0U)
        {
          XMLobj.WriteStartElement("CentralHeatingPumpAge");
          // ISSUE: reference to a compiler-generated field
          string pumpType = SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating2.Boiler.PumpType;
          if (Operators.CompareString(pumpType, "2013 or later", false) != 0)
          {
            if (Operators.CompareString(pumpType, "2012 or earlier", false) == 0)
              XMLobj.WriteValue(1);
            else
              XMLobj.WriteValue(0);
          }
          else
            XMLobj.WriteValue(2);
          XMLobj.WriteEndElement();
        }
      }
      else
      {
        XMLobj.WriteStartElement("EmitterTemperature");
        // ISSUE: reference to a compiler-generated field
        string flowTemp = SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating2.Boiler.FlowTemp;
        if (Operators.CompareString(flowTemp, "Unknown", false) != 0)
        {
          if (Operators.CompareString(flowTemp, "Design flow temperature >45°C", false) != 0)
          {
            if (Operators.CompareString(flowTemp, "Design flow temperature<=45°C", false) != 0)
            {
              if (Operators.CompareString(flowTemp, "Design flow temperature<=35°C", false) == 0)
                XMLobj.WriteValue(4);
              else
                XMLobj.WriteValue("NA");
            }
            else
              XMLobj.WriteValue(2);
          }
          else
            XMLobj.WriteValue(1);
        }
        else
          XMLobj.WriteValue(0);
        XMLobj.WriteEndElement();
      }
      // ISSUE: reference to a compiler-generated field
      if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating2.HGroup, "Heat pumps with radiators or underfloor heating", false) == 0)
      {
        XMLobj.WriteStartElement("MCSInstalledHeatPump");
        // ISSUE: reference to a compiler-generated field
        if (SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating2.MCSCert)
          XMLobj.WriteValue("true");
        else
          XMLobj.WriteValue("false");
        XMLobj.WriteEndElement();
      }
      // ISSUE: reference to a compiler-generated field
      if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating2.HGroup, "MicroCongeneration (MicroCHP)", false) == 0)
      {
        XMLobj.WriteStartElement("CentralHeatingPumpAge");
        // ISSUE: reference to a compiler-generated field
        string pumpType = SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating2.Boiler.PumpType;
        if (Operators.CompareString(pumpType, "2013 or later", false) != 0)
        {
          if (Operators.CompareString(pumpType, "2012 or earlier", false) == 0)
            XMLobj.WriteValue(1);
          else
            XMLobj.WriteValue(0);
        }
        else
          XMLobj.WriteValue(2);
        XMLobj.WriteEndElement();
      }
      XMLobj.WriteEndElement();
    }

    private bool isCPSU(int Value)
    {
      bool flag = false;
      if (Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.InforSource, "Boiler Database", false) == 0)
      {
        if (Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SGroup, "Gas boilers and oil boilers", false) == 0)
        {
          PCDF.SEDBUK sedbuk;
          switch (Value)
          {
            case 0:
              sedbuk = Calc2012.SEDBUK(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SEDBUK);
              break;
            case 1:
              sedbuk = Calc2012.SEDBUK(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SEDBUK);
              break;
          }
          if (sedbuk != null && Conversions.ToDouble(sedbuk.Type) == 3.0)
            flag = true;
        }
      }
      else
      {
        switch (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SAPTableCode)
        {
          case 120:
          case 121:
          case 192:
            flag = true;
            break;
        }
      }
      return flag;
    }

    private struct Opening
    {
      public string Name;
      public string DSource;
      public string Type;
      public string GlazingType;
      public string GlazingGap;
      public bool Argon;
      public string FrameType;
      public string MetalFrameType;
      public float SolarT;
      public float FrameFactor;
      public float U_Value;
      public string Pitch;
    }

    public class HQMXMLReturn
    {
      public string XML { get; set; }

      public bool Validated { get; set; }

      public string Msg { get; set; }
    }
  }
}
