
// Type: SAP2012.XML2012




using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace SAP2012
{
  public class XML2012
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
    private XML2012.Opening[] OpeningTypes;

    public XML2012()
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
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str1, "Yn byw yn yr eiddo", false) == 0)
              goto label_18;
            else
              goto default;
          case 363948515:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str1, "Buddiant ariannol yn yr eiddo", false) == 0)
              goto label_19;
            else
              goto default;
          case 699887717:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str1, "Employed by the professional dealing with the property transaction", false) == 0)
              goto label_21;
            else
              goto default;
          case 714563493:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str1, "Perthynas i’r person proffesiynol sy’n delio â’r trafodyn eiddo", false) == 0)
              goto label_22;
            else
              goto default;
          case 906552670:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str1, "Relative of the professional dealing with the property transaction", false) == 0)
              goto label_22;
            else
              goto default;
          case 1423711376:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str1, "Wedi’i gyflogi gan y person proffesiynol sy’n delio â’r trafodyn eiddo", false) == 0)
              goto label_21;
            else
              goto default;
          case 2325797555:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str1, "Financial interest in the property", false) == 0)
              goto label_19;
            else
              goto default;
          case 2392311570:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str1, "Relative of homeowner or occupier of the property", false) == 0)
              goto label_17;
            else
              goto default;
          case 2457169943:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str1, "Residing at the property", false) == 0)
              goto label_18;
            else
              goto default;
          case 2648119767:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str1, "Perthynas i berchennog y cartref neu ddeiliad yr eiddo", false) == 0)
              goto label_17;
            else
              goto default;
          case 2851230164:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str1, "Perchennog neu Gyfarwyddwr y corff sy’n delio â’r trafodyn eiddo", false) == 0)
              goto label_20;
            else
              goto default;
          case 3056024431:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str1, "Dim parti perthnasol", false) == 0)
              break;
            goto default;
          case 3407112949:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str1, "No related party", false) == 0)
              break;
            goto default;
          case 3560267305:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str1, "Owner or Director of the organisation dealing with the property transaction", false) == 0)
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
      this.OpeningTypes = new XML2012.Opening[0];
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
            XML2012.Opening[]& local;
            // ISSUE: explicit reference operation
            XML2012.Opening[] openingArray = (XML2012.Opening[]) Utils.CopyArray((Array) ^(local = ref this.OpeningTypes), (Array) new XML2012.Opening[checked (index1 + 1)]);
            local = openingArray;
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].Doors[index1].GlazingType, (string) null, false) == 0)
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
              if (!((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].Doors[index1].UValueSource, this.OpeningTypes[index2].DSource, false) > 0U | (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].Doors[index1].DoorType, this.OpeningTypes[index2].Type, false) > 0U | (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].Doors[index1].GlazingType, this.OpeningTypes[index2].GlazingType, false) > 0U | (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].Doors[index1].AirGap, this.OpeningTypes[index2].GlazingGap, false) > 0U | SAP_Module.Proj.Dwellings[House].Doors[index1].GlazingType.Contains("argon") != this.OpeningTypes[index2].Argon | (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].Doors[index1].FrameType, this.OpeningTypes[index2].FrameType, false) > 0U | (double) SAP_Module.Proj.Dwellings[House].Doors[index1].U != (double) this.OpeningTypes[index2].U_Value))
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
              XML2012.Opening[]& local;
              // ISSUE: explicit reference operation
              XML2012.Opening[] openingArray = (XML2012.Opening[]) Utils.CopyArray((Array) ^(local = ref this.OpeningTypes), (Array) new XML2012.Opening[checked (this.OpeningTypes.Length + 1)]);
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
            XML2012.Opening[]& local;
            // ISSUE: explicit reference operation
            XML2012.Opening[] openingArray = (XML2012.Opening[]) Utils.CopyArray((Array) ^(local = ref this.OpeningTypes), (Array) new XML2012.Opening[checked (this.OpeningTypes.Length + 1)]);
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
              if (!((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].Windows[index3].UValueSource, this.OpeningTypes[index4].DSource, false) > 0U | (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].Windows[index3].GlazingType, this.OpeningTypes[index4].GlazingType, false) > 0U | (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].Windows[index3].AirGap, this.OpeningTypes[index4].GlazingGap, false) > 0U | SAP_Module.Proj.Dwellings[House].Windows[index3].GlazingType.Contains("argon") != this.OpeningTypes[index4].Argon | (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].Windows[index3].FrameType, this.OpeningTypes[index4].FrameType, false) > 0U | (double) SAP_Module.Proj.Dwellings[House].Windows[index3].g != (double) this.OpeningTypes[index4].SolarT | (double) SAP_Module.Proj.Dwellings[House].Windows[index3].FF != (double) this.OpeningTypes[index4].FrameFactor | (double) SAP_Module.Proj.Dwellings[House].Windows[index3].U != (double) this.OpeningTypes[index4].U_Value))
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
              XML2012.Opening[]& local;
              // ISSUE: explicit reference operation
              XML2012.Opening[] openingArray = (XML2012.Opening[]) Utils.CopyArray((Array) ^(local = ref this.OpeningTypes), (Array) new XML2012.Opening[checked (this.OpeningTypes.Length + 1)]);
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
            XML2012.Opening[]& local;
            // ISSUE: explicit reference operation
            XML2012.Opening[] openingArray = (XML2012.Opening[]) Utils.CopyArray((Array) ^(local = ref this.OpeningTypes), (Array) new XML2012.Opening[checked (this.OpeningTypes.Length + 1)]);
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
          }
          else
          {
            int num9 = length2;
            int num10 = checked (this.OpeningTypes.Length - 1);
            int index6 = num9;
            while (index6 <= num10)
            {
              if (!((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].RoofLights[index5].UValueSource, this.OpeningTypes[index6].DSource, false) > 0U | (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].RoofLights[index5].GlazingType, this.OpeningTypes[index6].GlazingType, false) > 0U | (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].RoofLights[index5].AirGap, this.OpeningTypes[index6].GlazingGap, false) > 0U | SAP_Module.Proj.Dwellings[House].RoofLights[index5].GlazingType.Contains("argon") != this.OpeningTypes[index6].Argon | (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].RoofLights[index5].FrameType, this.OpeningTypes[index6].FrameType, false) > 0U | (double) SAP_Module.Proj.Dwellings[House].RoofLights[index5].g != (double) this.OpeningTypes[index6].SolarT | (double) SAP_Module.Proj.Dwellings[House].RoofLights[index5].FF != (double) this.OpeningTypes[index6].FrameFactor | (double) SAP_Module.Proj.Dwellings[House].RoofLights[index5].U != (double) this.OpeningTypes[index6].U_Value))
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
              XML2012.Opening[]& local;
              // ISSUE: explicit reference operation
              XML2012.Opening[] openingArray = (XML2012.Opening[]) Utils.CopyArray((Array) ^(local = ref this.OpeningTypes), (Array) new XML2012.Opening[checked (this.OpeningTypes.Length + 1)]);
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
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "heating oil", false) == 0)
          {
            num = 4;
            goto default;
          }
          else
            goto default;
        case 335024745:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "heat from boilers – biogas", false) == 0)
          {
            num = 44;
            goto default;
          }
          else
            goto default;
        case 575487477:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "wood pellets (bulk supply in bags, for main heating)", false) == 0)
          {
            num = 23;
            goto default;
          }
          else
            goto default;
        case 604697910:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "manufactured smokeless fuel", false) == 0)
          {
            num = 12;
            goto default;
          }
          else
            goto default;
        case 664172296:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "heat from CHP", false) == 0)
          {
            num = 46;
            goto default;
          }
          else
            goto default;
        case 721524493:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "dual fuel appliance (mineral and wood)", false) == 0)
            break;
          goto default;
        case 842919835:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "heat from boilers – LPG", false) == 0)
          {
            num = 52;
            goto default;
          }
          else
            goto default;
        case 857289046:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "house coal", false) == 0)
          {
            num = 11;
            goto default;
          }
          else
            goto default;
        case 975024876:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "bulk LPG", false) == 0)
          {
            num = 2;
            goto default;
          }
          else
            goto default;
        case 1086463322:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "LPG subject to Special Condition 18", false) == 0)
          {
            num = 9;
            goto default;
          }
          else
            goto default;
        case 1384014791:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "B30K", false) == 0)
          {
            num = 75;
            goto default;
          }
          else
            goto default;
        case 1424221758:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "geothermal heat source", false) == 0)
          {
            num = 46;
            goto default;
          }
          else
            goto default;
        case 1441345278:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Electricity", false) == 0)
          {
            num = 39;
            goto default;
          }
          else
            goto default;
        case 1522447619:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "wood chips", false) == 0)
          {
            num = 21;
            goto default;
          }
          else
            goto default;
        case 1538586610:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "heat from boilers – oil", false) == 0)
          {
            num = 53;
            goto default;
          }
          else
            goto default;
        case 1597764060:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "mains gas", false) == 0)
          {
            num = 1;
            goto default;
          }
          else
            goto default;
        case 1770949684:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "appliances able to use mineral oil or liquid biofuel", false) == 0)
          {
            num = 74;
            goto default;
          }
          else
            goto default;
        case 1860525480:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "heat from electric heat pump", false) == 0)
          {
            num = 41;
            goto default;
          }
          else
            goto default;
        case 1946790875:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "wood logs", false) == 0)
          {
            num = 20;
            goto default;
          }
          else
            goto default;
        case 2251322125:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "wood pellets (in bags, for secondary heating)", false) == 0)
          {
            num = 22;
            goto default;
          }
          else
            goto default;
        case 2313921600:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "anthracite", false) == 0)
          {
            num = 15;
            goto default;
          }
          else
            goto default;
        case 2340757125:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "heat from boilers - waste combustion", false) == 0)
          {
            num = 42;
            goto default;
          }
          else
            goto default;
        case 2343415715:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "waste heat from power stations", false) == 0)
          {
            num = 45;
            goto default;
          }
          else
            goto default;
        case 2442528761:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "heat from heat pump", false) == 0)
            goto default;
          else
            goto default;
        case 2685417441:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "bioethanol from any biomass source", false) == 0)
          {
            num = 76;
            goto default;
          }
          else
            goto default;
        case 3198893402:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "rapeseed oil", false) == 0)
          {
            num = 73;
            goto default;
          }
          else
            goto default;
        case 3216529428:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "heat from boilers – biomass", false) == 0)
          {
            num = 43;
            goto default;
          }
          else
            goto default;
        case 3349323758:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "biodiesel from any biomass source", false) == 0)
          {
            num = 71;
            goto default;
          }
          else
            goto default;
        case 3398809853:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "heat from boilers – B30D", false) == 0)
          {
            num = 55;
            goto default;
          }
          else
            goto default;
        case 3722837730:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "bottled LPG", false) == 0)
          {
            num = 3;
            goto default;
          }
          else
            goto default;
        case 3794681384:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "LNG", false) == 0)
          {
            num = 8;
            goto default;
          }
          else
            goto default;
        case 3824947145:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "heat from boilers – coal", false) == 0)
          {
            num = 54;
            goto default;
          }
          else
            goto default;
        case 4235694608:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "biodiesel from used cooking oil only", false) == 0)
          {
            num = 72;
            goto default;
          }
          else
            goto default;
        case 4241528165:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "heat from boilers – mains gas", false) == 0)
          {
            num = 51;
            goto default;
          }
          else
            goto default;
        case 4242022632:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "dual fuel (mineral and wood)", false) == 0)
            break;
          goto default;
        default:
label_69:
          return num;
      }
      num = 10;
      goto label_69;
    }

    private void _SAPReport(XmlTextWriter XMLobj, int House, int Country)
    {
      try
      {
        this._SAPSchemaversion(XMLobj);
        this._SAPVersion(XMLobj);
        this._SAPSDataVersion(XMLobj);
        this._SAPPCDFVersion(XMLobj);
        this._SAPPSoftwareName(XMLobj);
        this._SAPPSoftwareVersion(XMLobj);
        this._ReportHeader(XMLobj, House, Country);
        this._EnergyAssessment(XMLobj, House, Country);
        this._SAP09Data(XMLobj, House, Country);
        this._PDF(XMLobj);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void _SAPSchemaversion(XmlTextWriter XMLobj)
    {
      XMLobj.WriteStartElement("Schema-Version-Original");
      XMLobj.WriteValue("LIG-17.0");
      XMLobj.WriteEndElement();
    }

    private void _InsuranceDetails(XmlTextWriter XMLobj)
    {
      XMLobj.WriteStartElement("Insurance-Details");
      XMLobj.WriteStartElement("Insurer");
      XMLobj.WriteValue(Validation.Insurance.Insurer);
      XMLobj.WriteEndElement();
      XMLobj.WriteStartElement("Policy-No");
      XMLobj.WriteValue(Validation.Insurance.PolicyNo);
      XMLobj.WriteEndElement();
      XMLobj.WriteStartElement("Effective-Date");
      XMLobj.WriteValue(Validation.Insurance.StartDate);
      XMLobj.WriteEndElement();
      XMLobj.WriteStartElement("Expiry-Date");
      XMLobj.WriteValue(Validation.Insurance.Enddate);
      XMLobj.WriteEndElement();
      XMLobj.WriteStartElement("PI-Limit");
      XMLobj.WriteValue(Validation.Insurance.PLLimit);
      XMLobj.WriteEndElement();
      XMLobj.WriteEndElement();
    }

    private void _SAPVersion(XmlTextWriter XMLobj)
    {
      XMLobj.WriteStartElement("SAP-Version");
      XMLobj.WriteValue("9.92");
      XMLobj.WriteEndElement();
    }

    private void _SAPSDataVersion(XmlTextWriter XMLobj)
    {
      XMLobj.WriteStartElement("SAP-Data-Version");
      XMLobj.WriteValue("9.92");
      XMLobj.WriteEndElement();
    }

    private void _SAPPCDFVersion(XmlTextWriter XMLobj)
    {
      XMLobj.WriteStartElement("PCDF-Revision-Number");
      XMLobj.WriteValue(SAP_Module.PCDFData.Version);
      XMLobj.WriteEndElement();
    }

    private void _SAPPSoftwareVersion(XmlTextWriter XMLobj)
    {
      XMLobj.WriteStartElement("Calculation-Software-Version");
      XMLobj.WriteValue(SAP_Module.CurrVersion);
      XMLobj.WriteEndElement();
    }

    private void _SAPPSoftwareName(XmlTextWriter XMLobj)
    {
      XMLobj.WriteStartElement("Calculation-Software-Name");
      XMLobj.WriteValue("Stroma FSAP 2012");
      XMLobj.WriteEndElement();
    }

    private void _ReportHeader(XmlTextWriter XMLobj, int House, int Country)
    {
      XMLobj.WriteStartElement("Report-Header");
      if (PDFFunctions.Draft_PDF)
        Validation.RefNum = "0000-0000-0000-0000-0000";
      if (string.IsNullOrEmpty(Validation.RefNum))
        Validation.RefNum = "0000-0000-0000-0000-0000";
      if (!PDFFunctions.Draft_PDF)
        Validation.RefNum = PDFFunctions.RequestRRNByUPRN(SAP_Module.Proj.Dwellings[House].UPRN, Microsoft.VisualBasic.Strings.Format((object) SAP_Module.Proj.Dwellings[House].DateAssessment, "yyMMdd"));
      XMLobj.WriteStartElement("RRN");
      XMLobj.WriteValue(Validation.RefNum);
      XMLobj.WriteEndElement();
      XMLobj.WriteStartElement("Inspection-Date");
      XMLobj.WriteValue(Microsoft.VisualBasic.Strings.Format((object) SAP_Module.Proj.Dwellings[House].DateAssessment, "yyyy-MM-dd"));
      XMLobj.WriteEndElement();
      XMLobj.WriteStartElement("Report-Type");
      XMLobj.WriteValue(3);
      XMLobj.WriteEndElement();
      XMLobj.WriteStartElement("Completion-Date");
      XMLobj.WriteValue(Microsoft.VisualBasic.Strings.Format((object) DateAndTime.Now, "yyyy-MM-dd"));
      XMLobj.WriteEndElement();
      XMLobj.WriteStartElement("Registration-Date");
      XMLobj.WriteValue(Microsoft.VisualBasic.Strings.Format((object) DateAndTime.Now, "yyyy-MM-dd"));
      XMLobj.WriteEndElement();
      XMLobj.WriteStartElement("Status");
      XMLobj.WriteValue("entered");
      XMLobj.WriteEndElement();
      XMLobj.WriteStartElement("Language-Code");
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].EPCLanguage, "Welsh", false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].Address.Country, "Wales", false) == 0)
        XMLobj.WriteValue(2);
      else
        XMLobj.WriteValue(1);
      XMLobj.WriteEndElement();
      XMLobj.WriteStartElement("Tenure");
      string tenure = SAP_Module.Proj.Dwellings[House].Tenure;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(tenure, "Owner-occupied", false) != 0)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(tenure, "Rented (social)", false) != 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(tenure, "Rented (private)", false) == 0)
            XMLobj.WriteValue(3);
          else
            XMLobj.WriteValue("ND");
        }
        else
          XMLobj.WriteValue(2);
      }
      else
        XMLobj.WriteValue(1);
      XMLobj.WriteEndElement();
      XMLobj.WriteStartElement("Transaction-Type");
      string transaction = SAP_Module.Proj.Dwellings[House].Transaction;
      // ISSUE: reference to a compiler-generated method
      switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(transaction))
      {
        case 359166155:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(transaction, "Rental (social)", false) == 0)
            break;
          goto default;
        case 1765198695:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(transaction, "Rental", false) == 0)
            break;
          goto default;
        case 1893705044:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(transaction, "Non marketed sale", false) == 0)
          {
            XMLobj.WriteValue(2);
            goto label_36;
          }
          else
            goto default;
        case 2094602017:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(transaction, "Rental (private)", false) == 0)
            break;
          goto default;
        case 2398018890:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(transaction, "FiT application", false) == 0)
          {
            XMLobj.WriteValue(11);
            goto label_36;
          }
          else
            goto default;
        case 3124205971:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(transaction, "Assessment for Green Deal", false) == 0)
          {
            XMLobj.WriteValue(9);
            goto label_36;
          }
          else
            goto default;
        case 3387929955:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(transaction, "Marketed sale", false) == 0)
          {
            XMLobj.WriteValue(1);
            goto label_36;
          }
          else
            goto default;
        case 3741002162:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(transaction, "None of the above", false) == 0)
          {
            XMLobj.WriteValue(5);
            goto label_36;
          }
          else
            goto default;
        case 4206055543:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(transaction, "New dwelling", false) == 0)
          {
            XMLobj.WriteValue(6);
            goto label_36;
          }
          else
            goto default;
        case 4287547971:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(transaction, "Following Green Deal", false) == 0)
          {
            XMLobj.WriteValue(10);
            goto label_36;
          }
          else
            goto default;
        default:
          XMLobj.WriteValue(5);
          goto label_36;
      }
      XMLobj.WriteValue(8);
label_36:
      XMLobj.WriteEndElement();
      XMLobj.WriteStartElement("Seller-Commission-Report");
      XMLobj.WriteValue("Y");
      XMLobj.WriteEndElement();
      XMLobj.WriteStartElement("Property-Type");
      string propertyType = SAP_Module.Proj.Dwellings[House].PropertyType;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(propertyType, nameof (House), false) != 0)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(propertyType, "Bungalow", false) != 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(propertyType, "Flat", false) != 0)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(propertyType, "Maisonette", false) == 0)
              XMLobj.WriteValue(3);
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
      try
      {
        this._ReportHeaderHomeInspector(XMLobj);
        this._ReportHeaderProperty(XMLobj, House, Country);
        this._ReportHeaderRegions(XMLobj, House);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      XMLobj.WriteStartElement("Country-Code");
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
      XMLobj.WriteStartElement("Related-Party-Disclosure");
      XMLobj.WriteStartElement("Related-Party-Disclosure-Number");
      string str = Conversions.ToString(this.CheckRelatedParty(SAP_Module.Proj.Dwellings[House].RPD));
      XMLobj.WriteValue(str);
      XMLobj.WriteEndElement();
      XMLobj.WriteEndElement();
      XMLobj.WriteEndElement();
    }

    private void _ReportHeaderRegions(XmlTextWriter XMLobj, int House)
    {
      XMLobj.WriteStartElement("Region-Code");
      string location = SAP_Module.Proj.Dwellings[House].Location;
      // ISSUE: reference to a compiler-generated method
      switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(location))
      {
        case 85627527:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(location, "Orkney", false) == 0)
          {
            XMLobj.WriteValue(11);
            goto default;
          }
          else
            goto default;
        case 417745194:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(location, "Thames valley", false) == 0)
          {
            XMLobj.WriteValue(17);
            goto default;
          }
          else
            goto default;
        case 419820972:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(location, "Borders", false) == 0)
          {
            XMLobj.WriteValue(1);
            goto default;
          }
          else
            goto default;
        case 423237023:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(location, "South England", false) == 0)
          {
            XMLobj.WriteValue(16);
            goto default;
          }
          else
            goto default;
        case 463047147:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(location, "Wales", false) == 0)
          {
            XMLobj.WriteValue(18);
            goto default;
          }
          else
            goto default;
        case 1121445140:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(location, "South West England", false) == 0)
          {
            XMLobj.WriteValue(15);
            goto default;
          }
          else
            goto default;
        case 1253063607:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(location, "Isle of Man", false) == 0)
          {
            XMLobj.WriteValue(24);
            goto default;
          }
          else
            goto default;
        case 1486598274:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(location, "Shetland", false) == 0)
          {
            XMLobj.WriteValue(13);
            goto default;
          }
          else
            goto default;
        case 1608233300:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(location, "East pennines", false) == 0)
            break;
          goto default;
        case 1809119403:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(location, "Guernsey", false) == 0)
          {
            XMLobj.WriteValue(23);
            goto default;
          }
          else
            goto default;
        case 2227903623:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(location, "South West Scotland", false) == 0)
            goto label_35;
          else
            goto default;
        case 2536965870:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(location, "East Anglia", false) == 0)
          {
            XMLobj.WriteValue(2);
            goto default;
          }
          else
            goto default;
        case 2574711555:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(location, "Severn valley", false) == 0)
          {
            XMLobj.WriteValue(12);
            goto default;
          }
          else
            goto default;
        case 2627101428:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(location, "Highland", false) == 0)
          {
            XMLobj.WriteValue(5);
            goto default;
          }
          else
            goto default;
        case 3009355918:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(location, "North West England", false) == 0)
            goto label_35;
          else
            goto default;
        case 3088137120:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(location, "North East England", false) == 0)
          {
            XMLobj.WriteValue(7);
            goto default;
          }
          else
            goto default;
        case 3158107624:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(location, "East Scotland", false) == 0)
          {
            XMLobj.WriteValue(4);
            goto default;
          }
          else
            goto default;
        case 3255183281:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(location, "Western Isles", false) == 0)
          {
            XMLobj.WriteValue(21);
            goto default;
          }
          else
            goto default;
        case 3381936845:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(location, "Jersey", false) == 0)
          {
            XMLobj.WriteValue(22);
            goto default;
          }
          else
            goto default;
        case 3757789148:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(location, "Northern Ireland", false) == 0)
          {
            XMLobj.WriteValue(10);
            goto default;
          }
          else
            goto default;
        case 3790857268:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(location, "East Pennines", false) == 0)
            break;
          goto default;
        case 4003211866:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(location, "South East England", false) == 0)
          {
            XMLobj.WriteValue(14);
            goto default;
          }
          else
            goto default;
        case 4013004195:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(location, "North East Scotland", false) == 0)
          {
            XMLobj.WriteValue(8);
            goto default;
          }
          else
            goto default;
        case 4072253181:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(location, "Midlands", false) == 0)
          {
            XMLobj.WriteValue(6);
            goto default;
          }
          else
            goto default;
        case 4111412702:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(location, "West Scotland", false) == 0)
          {
            XMLobj.WriteValue(20);
            goto default;
          }
          else
            goto default;
        case 4162830650:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(location, "West Pennines", false) == 0)
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

    private void _ReportHeaderHomeInspector(XmlTextWriter XMLobj)
    {
      XMLobj.WriteStartElement("Home-Inspector");
      XMLobj.WriteStartElement("Name");
      XMLobj.WriteValue(Validation.AssessorFN + " " + Validation.AssessorLN);
      XMLobj.WriteEndElement();
      XMLobj.WriteStartElement("Notify-Lodgement");
      XMLobj.WriteValue("Y");
      XMLobj.WriteEndElement();
      XMLobj.WriteStartElement("Contact-Address");
      XMLobj.WriteStartElement("Address-Line-1");
      XMLobj.WriteValue(Validation.EA_Address1);
      XMLobj.WriteEndElement();
      XMLobj.WriteStartElement("Address-Line-2");
      XMLobj.WriteValue(Validation.EA_Address2);
      XMLobj.WriteEndElement();
      XMLobj.WriteStartElement("Post-Town");
      XMLobj.WriteValue(Validation.EA_Town);
      XMLobj.WriteEndElement();
      XMLobj.WriteStartElement("Postcode");
      XMLobj.WriteValue(Validation.EA_Postcode);
      XMLobj.WriteEndElement();
      XMLobj.WriteEndElement();
      XMLobj.WriteStartElement("Web-Site");
      XMLobj.WriteValue(Validation.EA_Web);
      XMLobj.WriteEndElement();
      XMLobj.WriteStartElement("E-Mail");
      XMLobj.WriteValue(Validation.EA_Email);
      XMLobj.WriteEndElement();
      XMLobj.WriteStartElement("Fax");
      XMLobj.WriteValue(Validation.AssessorFax);
      XMLobj.WriteEndElement();
      XMLobj.WriteStartElement("Telephone");
      XMLobj.WriteValue(Validation.AssessorPhone);
      XMLobj.WriteEndElement();
      XMLobj.WriteStartElement("Company-Name");
      XMLobj.WriteValue(Validation.AssessorCompany);
      XMLobj.WriteEndElement();
      XMLobj.WriteStartElement("Scheme-Name");
      XMLobj.WriteValue("Stroma Certification");
      XMLobj.WriteEndElement();
      XMLobj.WriteStartElement("Scheme-Web-Site");
      XMLobj.WriteValue("www.stroma.com");
      XMLobj.WriteEndElement();
      XMLobj.WriteStartElement("Identification-Number");
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Address.Country, "Scotland", false) == 0)
        XMLobj.WriteStartElement("Membership-Number");
      else
        XMLobj.WriteStartElement("Certificate-Number");
      XMLobj.WriteValue(Validation.AssessorNO);
      XMLobj.WriteEndElement();
      XMLobj.WriteEndElement();
      XMLobj.WriteEndElement();
    }

    private void _ReportHeaderProperty(XmlTextWriter XMLobj, int House, int Country)
    {
      XMLobj.WriteStartElement("Property");
      XMLobj.WriteStartElement("Address");
      XMLobj.WriteStartElement("Address-Line-1");
      XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Address.Line1);
      XMLobj.WriteEndElement();
      if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].Address.Line2, "", false) > 0U)
      {
        XMLobj.WriteStartElement("Address-Line-2");
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Address.Line2);
        XMLobj.WriteEndElement();
      }
      if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].Address.Line3, "", false) > 0U)
      {
        XMLobj.WriteStartElement("Address-Line-3");
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Address.Line3);
        XMLobj.WriteEndElement();
      }
      XMLobj.WriteStartElement("Post-Town");
      XMLobj.WriteValue(Microsoft.VisualBasic.Strings.UCase(SAP_Module.Proj.Dwellings[House].Address.City));
      XMLobj.WriteEndElement();
      XMLobj.WriteStartElement("Postcode");
      XMLobj.WriteValue(Microsoft.VisualBasic.Strings.UCase(SAP_Module.Proj.Dwellings[House].Address.PostCost));
      XMLobj.WriteEndElement();
      XMLobj.WriteEndElement();
      XMLobj.WriteStartElement("UPRN");
      XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].UPRN);
      XMLobj.WriteEndElement();
      XMLobj.WriteEndElement();
    }

    private object Get_Headding(int SAPCode)
    {
      int num = SAPCode;
      object headding;
      switch (num)
      {
        case 201:
          headding = (object) "Ground source heat pump";
          break;
        case 202:
          headding = (object) "Ground source heat pump";
          break;
        case 203:
          headding = (object) "Water source heat pump";
          break;
        case 204:
          headding = (object) "Air source heat pump";
          break;
        case 205:
          headding = (object) "Ground source heat pump";
          break;
        case 206:
          headding = (object) "Water source heat pump";
          break;
        case 207:
          headding = (object) "Air source heat pump";
          break;
        case 306:
          headding = (object) "Community scheme";
          break;
        case 307:
          headding = (object) "Community scheme with CHP";
          break;
        case 308:
          headding = (object) "Community scheme utilising waste heat";
          break;
        case 309:
          headding = (object) "Community heat pump";
          break;
        case 310:
          headding = (object) "Community heat pump";
          break;
        default:
          if (num >= 401 && num <= 409)
          {
            headding = (object) "Electric storage heaters";
            break;
          }
          if (num >= 421 && num <= 424)
          {
            headding = (object) "Electric underfloor heating";
            break;
          }
          if (num >= 501 && num <= 515)
          {
            headding = (object) "Warm air";
            break;
          }
          if (num >= 521 && num <= 523)
          {
            headding = (object) "Warm air heat pump";
            break;
          }
          switch (num)
          {
            case 525:
              headding = (object) "Ground source heat pump";
              break;
            case 526:
              headding = (object) "Water source heat pump";
              break;
            case 527:
              headding = (object) "Air source heat pump";
              break;
            default:
              if (num >= 601 && num <= 694)
              {
                headding = (object) "Room heaters";
                break;
              }
              switch (num)
              {
                case 524:
                  headding = (object) "Air source heat pump";
                  break;
                case 699:
                  headding = (object) "No system present: electric heaters assumed";
                  break;
                case 701:
                  headding = (object) "Electric ceiling";
                  break;
                default:
                  headding = (object) "";
                  break;
              }
              break;
          }
          break;
      }
      return headding;
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
      if (SAP_Module.Proj.Dwellings[House].MainHeating.SGroup.Contains("heat pumps") & SAP_Module.Proj.Dwellings[House].MainHeating.Emitter.Contains("radiators") & (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.InforSource, "Boiler Database", false) > 0U && this.calHeatingVal > 0.0)
      {
        this.calHeatingVal /= 0.7;
        this.calHeatingValCO2 /= 0.7;
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.HGroup, "Community heating schemes", false) == 0)
      {
        if (SAP_Module.Proj.Dwellings[House].MainHeating.CommunityH.NoOfAdditionalHeatSources == 0)
        {
          this.calHeatingVal = SAP_Module.Calculation2012.Calculation.Fuel_costs_10b.Box340aP * this.Eff;
          this.calHeatingValCO2 = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.MHType, "Community CHP", false) != 0 ? SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box367_E / (SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box367a / 100.0) * this.Eff : (SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box363E - SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box361 / 100.0 * SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box364E) / (SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box362 / 100.0) * this.Eff;
        }
        else
        {
          double num1 = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.MHType, "Community CHP", false) != 0 ? SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box367_E * SAP_Module.Calculation2012.Calculation.Energy_Requirements_9b.Box303a / (SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box367a / 100.0) : (SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box363E - SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box361 / 100.0 * SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box364E) / (SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box362 / 100.0) * SAP_Module.Calculation2012.Calculation.Energy_Requirements_9b.Box303a;
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
      if (SAP_Module.Proj.Dwellings[House].IncludeMainHeating2)
      {
        this.Eff = SAP_Module.Calculation2012.Calculation.Energy_Requirements_9a._Box207Uncorrected != 0.0 ? SAP_Module.Calculation2012.Calculation.Energy_Requirements_9a._Box207Uncorrected : SAP_Module.Calculation2012.Calculation.Energy_Requirements_9b.Box306;
        this.calHeatingVal = 100.0 * SAP_Module.Calculation2012.Calculation.Fuel_costs_10a.Box241P / this.Eff;
        this.calHeatingValCO2 = 100.0 * SAP_Module.Calculation2012.Calculation.CO2_Emissions_12a.Box262E / this.Eff;
        this.responsiveness = SAP_Module.Calculation2012._Add_Variable.C7._Responsiveness;
        if (this.responsiveness < 1.0)
        {
          this.calHeatingVal *= 1.0 + 0.29 * (1.0 - this.responsiveness);
          this.calHeatingValCO2 *= 1.0 + 0.29 * (1.0 - this.responsiveness);
        }
        if (SAP_Module.Proj.Dwellings[House].MainHeating2.SGroup.Contains("heat pumps") & SAP_Module.Proj.Dwellings[House].MainHeating2.Emitter.Contains("radiators") & (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating2.InforSource, "Boiler Database", false) > 0U && this.calHeatingVal > 0.0)
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
      if (Conversions.ToDouble(this.secMainBrand2) > 5.0)
        this.secMainBrand2 = Conversions.ToString(5);
      if (Conversions.ToDouble(this.secMainBrand) > 5.0)
        this.secMainBrand = Conversions.ToString(5);
      if (Conversions.ToDouble(this.MainBrand2) > 5.0)
        this.MainBrand2 = Conversions.ToString(5);
      if (Conversions.ToDouble(this.MainBrand) <= 5.0)
        return;
      this.MainBrand = Conversions.ToString(5);
    }

    private void HeatingDescription(int House, int country)
    {
      Calc2012.SEDBUK(SAP_Module.Proj.Dwellings[House].MainHeating.SEDBUK);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.InforSource, "Boiler Database", false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.SGroup, "Micro-cogeneration (micro-CHP)", false) == 0)
        this.HeatingHeading = "Micro-cogeneration";
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.InforSource, "Boiler Database", false) == 0 & SAP_Module.Proj.Dwellings[House].MainHeating.SGroup.Contains("heat pumps"))
      {
        string heatSource = Calc2012.SEDBUK_HeatPump(SAP_Module.Proj.Dwellings[House].MainHeating.SEDBUK).Heat_Source;
        // ISSUE: reference to a compiler-generated method
        switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(heatSource))
        {
          case 806133968:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(heatSource, "5", false) == 0)
            {
              this.HeatingHeading = "Exhaust source heat pump";
              break;
            }
            goto default;
          case 822911587:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(heatSource, "4", false) == 0)
            {
              this.HeatingHeading = "Exhaust air MEV source heat pump";
              break;
            }
            goto default;
          case 839689206:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(heatSource, "7", false) == 0)
            {
              this.HeatingHeading = "Ground water source heat pump";
              break;
            }
            goto default;
          case 856466825:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(heatSource, "6", false) == 0)
            {
              this.HeatingHeading = "Mixed exhaust air source heat pump";
              break;
            }
            goto default;
          case 873244444:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(heatSource, "1", false) == 0)
            {
              this.HeatingHeading = "Ground source heat pump";
              break;
            }
            goto default;
          case 906799682:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(heatSource, "3", false) == 0)
            {
              this.HeatingHeading = "Air source heat pump";
              break;
            }
            goto default;
          case 923577301:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(heatSource, "2", false) == 0)
            {
              this.HeatingHeading = "Water source heat pump";
              break;
            }
            goto default;
          case 1007465396:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(heatSource, "9", false) == 0)
            {
              this.HeatingHeading = "Solar assisted source heat pump";
              break;
            }
            goto default;
          case 1024243015:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(heatSource, "8", false) == 0)
            {
              this.HeatingHeading = "Surface water source heat pump";
              break;
            }
            goto default;
          default:
            this.HeatingHeading = "Air source heat pump";
            break;
        }
        if (SAP_Module.Proj.Dwellings[House].MainHeating.SGroup.Contains("heat pumps"))
          this.HeatingHeading = this.HeatingHeading + ", " + SAP_Module.Proj.Dwellings[House].MainHeating.Emitter;
      }
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.HGroup, "Warm air systems (Not heat pump)", false) == 0)
        this.HeatingHeading = "Warm air";
      else if (SAP_Module.Proj.Dwellings[House].MainHeating.SAPTableCode <= 200 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.InforSource, "Boiler Database", false) == 0)
      {
        if (SAP_Module.Proj.Dwellings[House].MainHeating.Emitter.Contains("radiators") & !SAP_Module.Proj.Dwellings[House].MainHeating.Emitter.Contains("Underfloor"))
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.SGroup, "Electric heat pumps", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.SGroup, "Gas-fired heat pumps", false) == 0)
          {
            string type = Calc2012.SEDBUK(SAP_Module.Proj.Dwellings[House].MainHeating.SEDBUK).Type;
            // ISSUE: reference to a compiler-generated method
            switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(type))
            {
              case 806133968:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(type, "5", false) == 0)
                {
                  this.HeatingHeading = "Exhaust source heat pump";
                  break;
                }
                goto default;
              case 822911587:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(type, "4", false) == 0)
                {
                  this.HeatingHeading = "Exhaust air MEV source heat pump";
                  break;
                }
                goto default;
              case 839689206:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(type, "7", false) == 0)
                {
                  this.HeatingHeading = "Ground water source heat pump";
                  break;
                }
                goto default;
              case 856466825:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(type, "6", false) == 0)
                {
                  this.HeatingHeading = "Mixed exhaust air source heat pump";
                  break;
                }
                goto default;
              case 873244444:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(type, "1", false) == 0)
                {
                  this.HeatingHeading = "Ground source heat pump";
                  break;
                }
                goto default;
              case 906799682:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(type, "3", false) == 0)
                {
                  this.HeatingHeading = "Air source heat pump";
                  break;
                }
                goto default;
              case 923577301:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(type, "2", false) == 0)
                {
                  this.HeatingHeading = "Water source heat pump";
                  break;
                }
                goto default;
              case 1007465396:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(type, "9", false) == 0)
                {
                  this.HeatingHeading = "Solar assisted source heat pump";
                  break;
                }
                goto default;
              case 1024243015:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(type, "8", false) == 0)
                {
                  this.HeatingHeading = "Surface water source heat pump";
                  break;
                }
                goto default;
              default:
                this.HeatingHeading = "Air source heat pump";
                break;
            }
            this.HeatingHeading = !(SAP_Module.Proj.Dwellings[House].MainHeating.Emitter.Contains("radiators") & !SAP_Module.Proj.Dwellings[House].MainHeating.Emitter.Contains("Underfloor")) ? (!SAP_Module.Proj.Dwellings[House].MainHeating.Emitter.Contains("Underfloor") ? this.HeatingHeading + ", fan coil units" : this.HeatingHeading + ", underfloor") : this.HeatingHeading + ", radiators";
          }
          else
            this.HeatingHeading = "Boiler and radiators";
        }
        else
          this.HeatingHeading = !(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.SGroup, "Electric heat pumps", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.SGroup, "Gas-fired heat pumps", false) == 0) ? (!(SAP_Module.Proj.Dwellings[House].MainHeating.Emitter.Contains("radiators") & !SAP_Module.Proj.Dwellings[House].MainHeating.Emitter.Contains("Underfloor")) ? (!SAP_Module.Proj.Dwellings[House].MainHeating.Emitter.Contains("Underfloor") ? (!SAP_Module.Proj.Dwellings[House].MainHeating.Emitter.Contains("coil") ? "Boiler and radiators" : "Boiler & fan coil units") : "Boiler & underfloor") : "Boiler & radiators") : (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.Emitter, "Fan coil units", false) != 0 ? "Ground source heat pump, underfloor" : "Ground source heat pump, fan coil units");
      }
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.SGroup, "Electric heat pumps", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.SGroup, "Gas-fired heat pumps", false) == 0)
      {
        switch (SAP_Module.Proj.Dwellings[House].MainHeating.SAPTableCode)
        {
          case 211:
          case 221:
            this.HeatingHeading = "Ground source heat pump ";
            break;
          case 212:
          case 224:
            this.HeatingHeading = "Air source heat pump ";
            break;
          case 213:
          case 223:
            this.HeatingHeading = "Water source heat pump ";
            break;
          case 214:
          case 524:
          case 527:
            this.HeatingHeading = "Air source heat pump ";
            break;
          case 523:
          case 526:
            this.HeatingHeading = "Water source heat pump ";
            break;
          default:
            this.HeatingHeading = "Ground source heat pump ";
            break;
        }
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.Emitter, "Fan coil units", false) == 0)
          this.HeatingHeading += "fan coil units";
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.MHType, "Ground source heat pump In other cases", false) == 0)
        {
          this.HeatingHeading = "Ground source heat pump";
          if (SAP_Module.Proj.Dwellings[House].MainHeating.Emitter.Contains("Underfloor"))
            this.HeatingHeading = !this.HeatingHeading.Contains(",") ? this.HeatingHeading + ", underfloor" : this.HeatingHeading + "underfloor";
        }
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.HGroup, "Heat pumps With warm air distribution", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.HGroup, "Warm air systems", false) == 0)
        {
          this.HeatingHeading = "Warm air ";
          if (SAP_Module.Proj.Dwellings[House].MainHeating.MHType.Contains("round"))
            this.HeatingHeading = "Ground source heat pump, warm air";
          if (SAP_Module.Proj.Dwellings[House].MainHeating.MHType.Contains("Water"))
            this.HeatingHeading = "Water source heat pump, warm air";
          if (SAP_Module.Proj.Dwellings[House].MainHeating.MHType.Contains("Air"))
            this.HeatingHeading = "Air source heat pump, warm air";
        }
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.HGroup, "Heat pumps With radiators Or underfloor heating", false) == 0)
        {
          this.HeatingHeading += SAP_Module.Proj.Dwellings[House].MainHeating.SGroup;
        }
        else
        {
          switch (SAP_Module.Proj.Dwellings[House].MainHeating.SAPTableCode)
          {
            case 201:
            case 202:
            case 205:
              this.HeatingHeading = "Ground source heat pump";
              this.HeatingHeading = !(SAP_Module.Proj.Dwellings[House].MainHeating.Emitter.Contains("radiators") & !SAP_Module.Proj.Dwellings[House].MainHeating.Emitter.Contains("Underfloor")) ? (!SAP_Module.Proj.Dwellings[House].MainHeating.Emitter.Contains("Underfloor") ? Conversions.ToString(this.Get_Headding(SAP_Module.Proj.Dwellings[House].MainHeating.SAPTableCode)) : Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(this.Get_Headding(SAP_Module.Proj.Dwellings[House].MainHeating.SAPTableCode), (object) ", underfloor"))) : Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(this.Get_Headding(SAP_Module.Proj.Dwellings[House].MainHeating.SAPTableCode), (object) ", radiators"));
              break;
          }
        }
      }
      else
        this.HeatingHeading = !(SAP_Module.Proj.Dwellings[House].MainHeating.Emitter.Contains("radiators") & !SAP_Module.Proj.Dwellings[House].MainHeating.Emitter.Contains("Underfloor")) ? (!SAP_Module.Proj.Dwellings[House].MainHeating.Emitter.Contains("Underfloor") ? Conversions.ToString(this.Get_Headding(SAP_Module.Proj.Dwellings[House].MainHeating.SAPTableCode)) : Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(this.Get_Headding(SAP_Module.Proj.Dwellings[House].MainHeating.SAPTableCode), (object) ", underfloor"))) : Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(this.Get_Headding(SAP_Module.Proj.Dwellings[House].MainHeating.SAPTableCode), (object) ", radiators"));
      if (SAP_Module.Proj.Dwellings[House].MainHeating.SAPTableCode == 204)
      {
        this.HeatingHeading = "Air source heat pump";
        this.HeatingHeading = !(SAP_Module.Proj.Dwellings[House].MainHeating.Emitter.Contains("radiators") & !SAP_Module.Proj.Dwellings[House].MainHeating.Emitter.Contains("Underfloor")) ? (!SAP_Module.Proj.Dwellings[House].MainHeating.Emitter.Contains("Underfloor") ? Conversions.ToString(this.Get_Headding(SAP_Module.Proj.Dwellings[House].MainHeating.SAPTableCode)) : Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(this.Get_Headding(SAP_Module.Proj.Dwellings[House].MainHeating.SAPTableCode), (object) ", underfloor"))) : Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(this.Get_Headding(SAP_Module.Proj.Dwellings[House].MainHeating.SAPTableCode), (object) ", radiators"));
      }
      bool flag;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.HeatingHeading, "Community scheme With CHP", false) == 0)
        flag = true;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.HeatingHeading, "Cynllun cymunedol", false) == 0)
        flag = true;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.HeatingHeading, "Community scheme", false) == 0)
        flag = true;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.HGroup, "Electric storage systems", false) == 0)
      {
        flag = true;
        if (country == 2 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].EPCLanguage, "Welsh", false) == 0)
          this.HeatingHeading = "Stôr wresogyddion trydan";
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.HGroup, "Electric underfloor heating", false) == 0)
      {
        flag = true;
        if (country == 2 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].EPCLanguage, "Welsh", false) == 0)
          this.HeatingHeading = "Gwresogi dan y llawr trydan";
      }
      if (!flag && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].EPCLanguage, "Welsh", false) == 0)
        this.HeatingHeading = PDFFunctions.CheckWalesHeatingHeading(this.HeatingHeading, country) + ", " + PDFFunctions.CheckWalesFuel(SAP_Module.Proj.Dwellings[House].MainHeating.Fuel);
      this.HeatingHeadingwWALES = PDFFunctions.CheckWalesHeatingHeading(this.HeatingHeading, country);
      if (!flag)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.MHType, "Electricaire system", false) == 0)
          this.HeatingHeading += ", Electricaire";
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.HeatingHeading, "Electric underfloor heating", false) != 0 && (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.MHType, "Electric ceiling heating", false) > 0U & (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.HGroup, "Electric storage systems", false) > 0U)
          this.HeatingHeading = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(PDFFunctions.CheckFuel((object) SAP_Module.Proj.Dwellings[House].MainHeating.Fuel), "LNG", false) != 0 ? (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.Fuel, "LPG subject To Special Condition 18", false) != 0 ? (!(SAP_Module.Proj.Dwellings[House].MainHeating.Fuel.Contains("biodiesel") | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.Fuel, "rapeseed oil", false) == 0) ? (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.Fuel, "appliances able To use mineral oil Or liquid biofuel", false) != 0 ? this.HeatingHeading + ", " + PDFFunctions.CheckFuel((object) SAP_Module.Proj.Dwellings[House].MainHeating.Fuel) : this.HeatingHeading + ", oil") : this.HeatingHeading + ", liquid biofuel") : this.HeatingHeading + ", LPG") : this.HeatingHeading + ", mains gas";
      }
      if (country != 2)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.HGroup, "Community heating schemes", false) == 0)
          this.HeatingHeading = "Community scheme";
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.HGroup, "Electric underfloor heating", false) == 0)
          this.HeatingHeading = "Electric underfloor heating";
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.HGroup, "Electric underfloor heating", false) == 0)
          this.HeatingHeading = "Electric underfloor heating";
      }
      if (!SAP_Module.Proj.Dwellings[House].IncludeMainHeating2)
        return;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating2.InforSource, "Boiler Database", false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating2.SGroup, "Micro-cogeneration (micro-CHP)", false) == 0)
        this.HeatingHeading2 = "Micro-cogeneration";
      else if (SAP_Module.Proj.Dwellings[House].MainHeating2.SAPTableCode <= 200 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating2.InforSource, "Boiler Database", false) == 0)
      {
        if (SAP_Module.Proj.Dwellings[House].MainHeating2.Emitter.Contains("radiators") & !SAP_Module.Proj.Dwellings[House].MainHeating2.Emitter.Contains("Underfloor"))
          this.HeatingHeading2 = "Boiler And radiators";
        else if (SAP_Module.Proj.Dwellings[House].MainHeating2.SGroup.Contains("heat pumps"))
        {
          this.HeatingHeading2 = "Ground source heat pump, underfloor";
        }
        else
        {
          this.HeatingHeading2 = "Boiler And underfloor heating";
          this.HeatingHeading2 = !SAP_Module.Proj.Dwellings[House].MainHeating2.SGroup.Contains("heat pumps") ? "Boiler And underfloor heating" : "Ground source heat pump, underfloor";
        }
      }
      else
        this.HeatingHeading2 = !(SAP_Module.Proj.Dwellings[House].MainHeating2.Emitter.Contains("radiators") & !SAP_Module.Proj.Dwellings[House].MainHeating2.Emitter.Contains("Underfloor")) ? Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(this.Get_Headding(SAP_Module.Proj.Dwellings[House].MainHeating2.SAPTableCode), (object) ", underfloor")) : Conversions.ToString(this.Get_Headding(SAP_Module.Proj.Dwellings[House].MainHeating2.SAPTableCode));
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.HeatingHeading2, "Room heaters, underfloor", false) == 0)
        this.HeatingHeading2 = "Room heaters";
      if (country == 2 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].EPCLanguage, "Welsh", false) == 0)
      {
        this.HeatingHeading2 = PDFFunctions.CheckWalesHeatingHeading(this.HeatingHeading2, country) + ", " + PDFFunctions.CheckWalesFuel(SAP_Module.Proj.Dwellings[House].MainHeating2.Fuel);
        this.HeatingHeadingwWALES2 = this.HeatingHeading2;
      }
      else
        this.HeatingHeading2 = this.HeatingHeading2 + ", " + PDFFunctions.CheckFuel((object) SAP_Module.Proj.Dwellings[House].MainHeating2.Fuel);
    }

    private bool Compare_Heaters(int House) => !((double) SAP_Module.Proj.Dwellings[House].HeatFractionSec > 0.1 & (double) SAP_Module.Proj.Dwellings[House].HeatFractionSec < 0.9);

    public string CheckWalesRating(string Value, int country)
    {
      string str;
      try
      {
        if (country == 2 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].EPCLanguage, "Welsh", false) == 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Value, "Very good", false) == 0)
            Value = "Da iawn";
          else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Value, "Good", false) == 0)
            Value = "Da";
          else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Value, "Average", false) == 0)
            Value = "Cymedrol";
          else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Value, "Poor", false) == 0)
            Value = "Gwael";
          else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Value, "Very poor", false) == 0)
            Value = "Gwael iawn";
          else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Value, "Compliant", false) == 0)
            Value = "Yn cydymffurfio";
        }
        str = Value;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) "There Is a problem during Rating Check", MsgBoxStyle.Critical);
        ProjectData.ClearProjectError();
      }
      return str;
    }

    private void HeatingControl_banidng(int House, int Country)
    {
      this.MyMainCode2 = Calc2012.Table4e(Conversions.ToString(SAP_Module.Proj.Dwellings[House].MainHeating.ControlCode)).Band;
      bool flag1 = false;
      try
      {
        if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.SEDBUK, "", false) > 0U)
        {
          object obj = (object) Calc2012.SEDBUK(SAP_Module.Proj.Dwellings[House].MainHeating.SEDBUK);
          if (obj != null && (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.Boiler.LoadWeatherType, "Enhanced Load Compensator", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.Boiler.LoadWeatherType, "Weather Compensator", false) == 0) & Math.Round(SAP_Module.Calculation2012.Calculation.Energy_Requirements_9a.Box206, 1) < Math.Round(SAP_Module.Calculation2012.Calculation.Energy_Requirements_9a._Box206Uncorrected, 1) & Conversions.ToDouble(((PCDF.SEDBUK) obj).Condensing) == 2.0)
            flag1 = true;
        }
        else if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.MHType, (string) null, false) > 0U && SAP_Module.Proj.Dwellings[House].MainHeating.MHType.Contains("Condensing") & !SAP_Module.Proj.Dwellings[House].MainHeating.MHType.Contains("non-condensing") && (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.Boiler.LoadWeatherType, "Enhanced Load Compensator", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.Boiler.LoadWeatherType, "Weather Compensator", false) == 0) & Math.Round(SAP_Module.Calculation2012.Calculation.Energy_Requirements_9a.Box206, 1) < Math.Round(SAP_Module.Calculation2012.Calculation.Energy_Requirements_9a._Box206Uncorrected, 1))
          flag1 = true;
        if (flag1)
        {
          string mainCode2 = this.MyMainCode2;
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(mainCode2, "Very poor", false) != 0)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(mainCode2, "Poor", false) != 0)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(mainCode2, "Average", false) != 0)
              {
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(mainCode2, "Good", false) == 0)
                  this.MyMainCode2 = "Very good";
              }
              else
                this.MyMainCode2 = "Good";
            }
            else
              this.MyMainCode2 = "Average";
          }
          else
            this.MyMainCode2 = "Poor";
        }
        string mainCode2_1 = this.MyMainCode2;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(mainCode2_1, "Very poor", false) != 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(mainCode2_1, "Poor", false) != 0)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(mainCode2_1, "Average", false) != 0)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(mainCode2_1, "Good", false) != 0)
              {
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(mainCode2_1, "Very good", false) == 0)
                  this.XML_controlCode = Conversions.ToString(5);
              }
              else
                this.XML_controlCode = Conversions.ToString(4);
            }
            else
              this.XML_controlCode = Conversions.ToString(3);
          }
          else
            this.XML_controlCode = Conversions.ToString(2);
        }
        else
          this.XML_controlCode = Conversions.ToString(1);
        this.MyMainCode = this.MyMainCode2;
        if (Country == 2 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].EPCLanguage, "Welsh", false) == 0)
          this.CheckWalesRating(this.MyMainCode, Country);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      if (SAP_Module.Proj.Dwellings[House].IncludeMainHeating2 & (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.Controls, SAP_Module.Proj.Dwellings[House].MainHeating2.Controls, false) > 0U)
      {
        string Left = Calc2012.Table4e(Conversions.ToString(SAP_Module.Proj.Dwellings[House].MainHeating2.ControlCode)).Band;
        bool flag2 = false;
        if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating2.SEDBUK, "", false) > 0U)
        {
          object obj = (object) Calc2012.SEDBUK(SAP_Module.Proj.Dwellings[House].MainHeating2.SEDBUK);
          if (obj != null && (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating2.Boiler.LoadWeatherType, "Enhanced Load Compensator", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating2.Boiler.LoadWeatherType, "Weather Compensator", false) == 0) & Math.Round(SAP_Module.Calculation2012.Calculation.Energy_Requirements_9a.Box207, 1) < Math.Round(SAP_Module.Calculation2012.Calculation.Energy_Requirements_9a._Box207Uncorrected, 1) & Conversions.ToDouble(((PCDF.SEDBUK) obj).Condensing) == 2.0)
            flag2 = true;
        }
        else if (SAP_Module.Proj.Dwellings[House].MainHeating2.MHType.Contains("condensing") & !SAP_Module.Proj.Dwellings[House].MainHeating2.MHType.Contains("non-condensing") && (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating2.Boiler.LoadWeatherType, "Enhanced Load Compensator", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating2.Boiler.LoadWeatherType, "Weather Compensator", false) == 0) & Math.Round(SAP_Module.Calculation2012.Calculation.Energy_Requirements_9a.Box207, 1) < Math.Round(SAP_Module.Calculation2012.Calculation.Energy_Requirements_9a._Box207Uncorrected, 1))
          flag2 = true;
        if (flag2)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "Very poor", false) != 0)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "Poor", false) != 0)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "Average", false) != 0)
              {
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "Good", false) == 0)
                  Left = "Very good";
              }
              else
                Left = "Good";
            }
            else
              Left = "Average";
          }
          else
            Left = "Poor";
        }
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "Very poor", false) != 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "Poor", false) != 0)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "Average", false) != 0)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "Good", false) != 0)
              {
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "Very good", false) == 0)
                  this.XML_controlCode2 = Conversions.ToString(5);
              }
              else
                this.XML_controlCode2 = Conversions.ToString(4);
            }
            else
              this.XML_controlCode2 = Conversions.ToString(3);
          }
          else
            this.XML_controlCode2 = Conversions.ToString(2);
        }
        else
          this.XML_controlCode2 = Conversions.ToString(1);
        if (Country == 2 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].EPCLanguage, "Welsh", false) == 0)
          this.CheckWalesRating(Left, Country);
      }
      if (!(SAP_Module.Proj.Dwellings[House].IncludeMainHeating2 & (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.Controls, SAP_Module.Proj.Dwellings[House].MainHeating2.Controls, false) > 0U) || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].Transaction, "New dwelling", false) != 0 || !(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.XML_controlCode2, "1", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.XML_controlCode2, "2", false) == 0))
        return;
      this.XML_controlCode2 = Conversions.ToString(0);
    }

    private void _Banding_Desc_Water(int House, int Country)
    {
      bool flag = false;
      this.HotWaterDesc = SAP_Module.Proj.Dwellings[House].Water.System;
      if (this.HotWaterDesc.Contains("For water heating only"))
        this.HotWaterDesc = Microsoft.VisualBasic.Strings.Mid(this.HotWaterDesc, 1, checked (Microsoft.VisualBasic.Strings.InStr(this.HotWaterDesc, "For water heating only") - 2));
      switch (SAP_Module.Proj.Dwellings[House].Water.SystemRef)
      {
        case 901:
          this.HotWaterDesc = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.HGroup, "Community heating schemes", false) != 0 ? "From main system" : "Community scheme";
          int sapTableCode1 = SAP_Module.Proj.Dwellings[House].MainHeating.SAPTableCode;
          if ((sapTableCode1 < 201 || sapTableCode1 > 207) && (sapTableCode1 < 521 || sapTableCode1 > 527))
            break;
          break;
        case 902:
          this.HotWaterDesc = !(!SAP_Module.Proj.Dwellings[House].Water.Cylinder.Thermostat & !SAP_Module.Proj.Dwellings[House].Water.Thermal.Include & (double) SAP_Module.Proj.Dwellings[House].Water.Cylinder.Volume != 0.0) ? "From secondary system" : "From secondary system, no cylinder thermostat";
          break;
        case 903:
          this.HotWaterDesc = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.ElectricityTariff, "standard tariff", false) != 0 ? "Electric immersion, off-peak" : "Electric immersion, standard tariff";
          break;
      }
      if (SAP_Module.Proj.Dwellings[House].Water.SystemRef == 901)
      {
        int sapTableCode2 = SAP_Module.Proj.Dwellings[House].MainHeating.SAPTableCode;
        if (sapTableCode2 != 104 && sapTableCode2 != 105 && sapTableCode2 != 107 && sapTableCode2 != 108 && sapTableCode2 != 112 && sapTableCode2 != 113 && sapTableCode2 != 118 && sapTableCode2 != 128 && sapTableCode2 != 129 && (sapTableCode2 < 191 || sapTableCode2 > 196) && (sapTableCode2 < 120 || sapTableCode2 > 123) && (sapTableCode2 < 306 || sapTableCode2 > 310) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.HotWaterDesc, "From main heating system", false) == 0 & !SAP_Module.Proj.Dwellings[House].Water.Cylinder.Thermostat & !SAP_Module.Proj.Dwellings[House].Water.Thermal.Include & (double) SAP_Module.Proj.Dwellings[House].Water.Cylinder.Volume != 0.0)
          this.HotWaterDesc = "From main system, no cylinder thermostat";
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].Water.System, "Community scheme With CHP", false) == 0)
        this.HotWaterDesc = "Community scheme";
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Microsoft.VisualBasic.Strings.Mid(SAP_Module.Proj.Dwellings[House].Water.System, 1, 4), "Gas,", false) == 0)
        this.HotWaterDesc = "Gas range cooker";
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Microsoft.VisualBasic.Strings.Mid(SAP_Module.Proj.Dwellings[House].Water.System, 1, 4), "Oil,", false) == 0)
        this.HotWaterDesc = "Oil range cooker";
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Microsoft.VisualBasic.Strings.Mid(SAP_Module.Proj.Dwellings[House].Water.System, 1, 11), "Solid fuel,", false) == 0)
        this.HotWaterDesc = "Solid fuel range cooker";
      if (Country == 4 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.HotWaterDesc, "From second main heating system", false) == 0)
        this.HotWaterDesc = "From main system";
      try
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.InforSource, "Boiler Database", false) == 0 & SAP_Module.Proj.Dwellings[House].Water.SystemRef == 901 && Calc2012.SEDBUK(SAP_Module.Proj.Dwellings[House].MainHeating.SEDBUK).SubType.Equals("1"))
        {
          flag = true;
          this.HotWaterDesc += ", flue gas heat recovery";
        }
        if (!flag && SAP_Module.Proj.Dwellings[House].Water.FGHRS.Include)
        {
          this.HotWaterDesc += ", flue gas heat recovery";
          flag = true;
        }
        if (SAP_Module.Proj.Dwellings[House].WaterOnlyHeatPump)
          this.HotWaterDesc = "From main system";
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      double num1;
      switch (SAP_Module.Proj.Dwellings[House].Water.SystemRef)
      {
        case 901:
          if ((uint) SAP_Module.Proj.Dwellings[House].MainHeating.SAPTableCode > 0U & (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.InforSource, "Manufacturer Declaration", false) > 0U)
          {
            int sapTableCode3 = SAP_Module.Proj.Dwellings[House].MainHeating.SAPTableCode;
            num1 = (sapTableCode3 < 100 || sapTableCode3 > 161) && (sapTableCode3 < 191 || sapTableCode3 > 196) ? SAP_Module.Calculation2012.Calculation.Energy_Requirements_9a._Box216Uncorrected : (SAP_Module.Calculation2012.Calculation.Energy_Requirements_9a._Box216Uncorrected + SAP_Module.Calculation2012.Calculation.Energy_Requirements_9a._Box206Uncorrected) / 2.0;
            break;
          }
          num1 = SAP_Module.Proj.Dwellings[House].MainHeating.SAPTableCode != 0 ? SAP_Module.Calculation2012.Calculation.Energy_Requirements_9a._Box216Uncorrected : (SAP_Module.Calculation2012.Calculation.Energy_Requirements_9a._Box216Uncorrected + SAP_Module.Calculation2012.Calculation.Energy_Requirements_9a._Box206Uncorrected) / 2.0;
          break;
        case 914:
          if ((uint) SAP_Module.Proj.Dwellings[House].MainHeating2.SAPTableCode > 0U & (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating2.InforSource, "Manufacturer Declaration", false) > 0U)
          {
            int sapTableCode4 = SAP_Module.Proj.Dwellings[House].MainHeating2.SAPTableCode;
            num1 = (sapTableCode4 < 100 || sapTableCode4 > 161) && (sapTableCode4 < 191 || sapTableCode4 > 196) ? SAP_Module.Calculation2012.Calculation.Energy_Requirements_9a._Box216Uncorrected : (SAP_Module.Calculation2012.Calculation.Energy_Requirements_9a._Box216Uncorrected + SAP_Module.Calculation2012.Calculation.Energy_Requirements_9a._Box207Uncorrected) / 2.0;
            break;
          }
          num1 = SAP_Module.Calculation2012.Calculation.Energy_Requirements_9a._Box216Uncorrected;
          break;
        default:
          num1 = SAP_Module.Calculation2012.Calculation.Energy_Requirements_9a._Box216Uncorrected;
          break;
      }
      if (SAP_Module.Proj.Dwellings[House].Water.SystemRef == 901 & SAP_Module.Proj.Dwellings[House].MainHeating.SGroup.Contains("heat pumps"))
        num1 = SAP_Module.Calculation2012.Calculation.Energy_Requirements_9a._Box216Uncorrected;
      try
      {
        if (SAP_Module.Proj.Dwellings[House].Water.SystemRef == 914 & SAP_Module.Proj.Dwellings[House].MainHeating2.SGroup.Contains("heat pumps"))
          num1 = SAP_Module.Calculation2012.Calculation.Energy_Requirements_9a._Box216Uncorrected;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      double num2 = !(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.HotWaterDesc, "Electric immersion, off-peak", false) == 0 | SAP_Module.Proj.Dwellings[House].Water.SystemRef == 901 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.MHType, "Direct acting electric boiler", false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.Fuel, "Electricity", false) == 0) ? (SAP_Module.Calculation2012.Calculation.Fuel_costs_10a.Box247P != 0.0 ? 100.0 * SAP_Module.Calculation2012.Calculation.Fuel_costs_10a.Box247P : 100.0 * SAP_Module.Calculation2012.Calculation.Fuel_costs_10a.Box240P) : SAP_Module.Calculation2012.Calculation.Fuel_costs_10a.Box243 * 100.0 * SAP_Module.Calculation2012.Calculation.Fuel_costs_10a.Box245P + SAP_Module.Calculation2012.Calculation.Fuel_costs_10a.Box244 * 100.0 * SAP_Module.Calculation2012.Calculation.Fuel_costs_10a.Box246P;
      this.Waterband = num2 != 0.0 ? num2 / num1 : 10.0;
      if (SAP_Module.Proj.Dwellings[House].Water.SystemRef == 901 & SAP_Module.Proj.Dwellings[House].MainHeating.SGroup.Contains("heat pumps"))
        this.Waterband2 = 100.0 * SAP_Module.Calculation2012.Calculation.CO2_Emissions_12a.Box261E / num1;
      else if (SAP_Module.Proj.Dwellings[House].Water.SystemRef == 914)
      {
        try
        {
          if (SAP_Module.Proj.Dwellings[House].MainHeating2.SGroup.Contains("heat pumps"))
            this.Waterband2 = 100.0 * SAP_Module.Calculation2012.Calculation.CO2_Emissions_12a.Box262E / num1;
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
      }
      else
        this.Waterband2 = 100.0 * SAP_Module.Calculation2012.Calculation.CO2_Emissions_12a.Box264E / num1;
      if (SAP_Module.Proj.Dwellings[House].Water.SystemRef == 901 & SAP_Module.Proj.Dwellings[House].MainHeating.SGroup.Contains("heat pumps") & (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.InforSource, "Boiler Database", false) > 0U)
      {
        this.Waterband /= 0.7;
        this.Waterband2 /= 0.7;
      }
      try
      {
        if (SAP_Module.Proj.Dwellings[House].Water.SystemRef == 914 & SAP_Module.Proj.Dwellings[House].MainHeating2.SGroup.Contains("heat pumps") & (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating2.InforSource, "Boiler Database", false) > 0U)
        {
          this.Waterband /= 0.7;
          this.Waterband2 /= 0.7;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      if (SAP_Module.Proj.Dwellings[House].Water.SystemRef == 901 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.HGroup, "Community heating schemes", false) == 0)
      {
        this.Waterband = this.calHeatingVal;
        this.Waterband2 = this.calHeatingValCO2;
      }
      if (SAP_Module.Proj.Dwellings[House].Water.System.Contains("From hot-water only community"))
      {
        double box306 = SAP_Module.Calculation2012.Calculation.Energy_Requirements_9b.Box306;
        double num3;
        double num4;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.HGroup, "Community heating schemes", false) == 0)
        {
          if (SAP_Module.Proj.Dwellings[House].Water.HWSComm.NoOfAdditionalHeatSources == 0)
          {
            this.Waterband = SAP_Module.Calculation2012.Calculation.Fuel_costs_10b.Box342aP * box306;
            this.Waterband2 = SAP_Module.Proj.Dwellings[House].Water.SystemRef != 951 ? SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box367_EW / (SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box367aW / 100.0) * box306 : (SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box365EW - SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box361W / 100.0 * SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box366EW) / (SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box362W / 100.0) * box306;
          }
          else
          {
            double num5 = SAP_Module.Proj.Dwellings[House].Water.SystemRef != 951 ? SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box367_EW * SAP_Module.Calculation2012.Calculation.Energy_Requirements_9b.Box303aW / (SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box367aW / 100.0) : (SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box365EW - SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box361W / 100.0 * SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box366EW) / (SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box362W / 100.0) * SAP_Module.Calculation2012.Calculation.Energy_Requirements_9b.Box303aW;
            switch (SAP_Module.Proj.Dwellings[House].Water.HWSComm.NoOfAdditionalHeatSources)
            {
              case 1:
                num3 = num5 + SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box368EW * SAP_Module.Calculation2012.Calculation.Energy_Requirements_9b.Box303bW / (SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box367bW / 100.0);
                break;
              case 2:
                num3 = num5 + SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box368EW * SAP_Module.Calculation2012.Calculation.Energy_Requirements_9b.Box303bW / (SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box367bW / 100.0) + SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box369EW * SAP_Module.Calculation2012.Calculation.Energy_Requirements_9b.Box303cW / (SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box367cW / 100.0);
                break;
              case 3:
                num3 = num5 + SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box368EW * SAP_Module.Calculation2012.Calculation.Energy_Requirements_9b.Box303bW / (SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box367bW / 100.0) + SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box369EW * SAP_Module.Calculation2012.Calculation.Energy_Requirements_9b.Box303cW / (SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box367cW / 100.0) + SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box370EW * SAP_Module.Calculation2012.Calculation.Energy_Requirements_9b.Box303dW / (SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box367dW / 100.0);
                break;
              case 4:
                num3 = num5 + SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box368EW * SAP_Module.Calculation2012.Calculation.Energy_Requirements_9b.Box303bW / (SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box367bW / 100.0) + SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box369EW * SAP_Module.Calculation2012.Calculation.Energy_Requirements_9b.Box303cW / (SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box367cW / 100.0) + SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box370EW * SAP_Module.Calculation2012.Calculation.Energy_Requirements_9b.Box303dW / (SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box367dW / 100.0) + SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box371EW * SAP_Module.Calculation2012.Calculation.Energy_Requirements_9b.Box303eW / (SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box367eW / 100.0);
                break;
            }
            num4 = SAP_Module.Calculation2012.Calculation.Energy_Requirements_9b.Box303aW * SAP_Module.Calculation2012.Calculation.Fuel_costs_10b.Box342aP + SAP_Module.Calculation2012.Calculation.Energy_Requirements_9b.Box303bW * SAP_Module.Calculation2012.Calculation.Fuel_costs_10b.Box342bP + SAP_Module.Calculation2012.Calculation.Energy_Requirements_9b.Box303cW * SAP_Module.Calculation2012.Calculation.Fuel_costs_10b.Box342cP + SAP_Module.Calculation2012.Calculation.Energy_Requirements_9b.Box303dW * SAP_Module.Calculation2012.Calculation.Fuel_costs_10b.Box342dP + SAP_Module.Calculation2012.Calculation.Energy_Requirements_9b.Box303eW * SAP_Module.Calculation2012.Calculation.Fuel_costs_10b.Box342eP;
          }
        }
        else if (SAP_Module.Proj.Dwellings[House].Water.HWSComm.NoOfAdditionalHeatSources == 0)
        {
          this.Waterband = SAP_Module.Calculation2012.Calculation.Fuel_costs_10b.Box342aP * box306;
          this.Waterband2 = SAP_Module.Proj.Dwellings[House].Water.SystemRef != 951 ? SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box367_E / (SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box367a / 100.0) * box306 : (SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box365E - SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box361 / 100.0 * SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box366E) / (SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box362 / 100.0) * box306;
        }
        else
        {
          double num6 = SAP_Module.Proj.Dwellings[House].Water.SystemRef != 951 ? SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box367_E * SAP_Module.Calculation2012.Calculation.Energy_Requirements_9b.Box303a / (SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box367a / 100.0) : (SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box365E - SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box361 / 100.0 * SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box366E) / (SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box362 / 100.0) * SAP_Module.Calculation2012.Calculation.Energy_Requirements_9b.Box303a;
          switch (SAP_Module.Proj.Dwellings[House].Water.HWSComm.NoOfAdditionalHeatSources)
          {
            case 1:
              num3 = num6 + SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box368E * SAP_Module.Calculation2012.Calculation.Energy_Requirements_9b.Box303b / (SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box367b / 100.0);
              break;
            case 2:
              num3 = num6 + SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box368E * SAP_Module.Calculation2012.Calculation.Energy_Requirements_9b.Box303b / (SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box367b / 100.0) + SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box369E * SAP_Module.Calculation2012.Calculation.Energy_Requirements_9b.Box303c / (SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box367c / 100.0);
              break;
            case 3:
              num3 = num6 + SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box368E * SAP_Module.Calculation2012.Calculation.Energy_Requirements_9b.Box303b / (SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box367b / 100.0) + SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box369E * SAP_Module.Calculation2012.Calculation.Energy_Requirements_9b.Box303c / (SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box367c / 100.0) + SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box370E * SAP_Module.Calculation2012.Calculation.Energy_Requirements_9b.Box303d / (SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box367d / 100.0);
              break;
            case 4:
              num3 = num6 + SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box368E * SAP_Module.Calculation2012.Calculation.Energy_Requirements_9b.Box303b / (SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box367b / 100.0) + SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box369E * SAP_Module.Calculation2012.Calculation.Energy_Requirements_9b.Box303c / (SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box367c / 100.0) + SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box370E * SAP_Module.Calculation2012.Calculation.Energy_Requirements_9b.Box303d / (SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box367d / 100.0) + SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box371E * SAP_Module.Calculation2012.Calculation.Energy_Requirements_9b.Box303e / (SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box367e / 100.0);
              break;
          }
          num4 = SAP_Module.Calculation2012.Calculation.Energy_Requirements_9b.Box303a * SAP_Module.Calculation2012.Calculation.Fuel_costs_10b.Box342aP + SAP_Module.Calculation2012.Calculation.Energy_Requirements_9b.Box303b * SAP_Module.Calculation2012.Calculation.Fuel_costs_10b.Box342bP + SAP_Module.Calculation2012.Calculation.Energy_Requirements_9b.Box303c * SAP_Module.Calculation2012.Calculation.Fuel_costs_10b.Box342cP + SAP_Module.Calculation2012.Calculation.Energy_Requirements_9b.Box303d * SAP_Module.Calculation2012.Calculation.Fuel_costs_10b.Box342dP + SAP_Module.Calculation2012.Calculation.Energy_Requirements_9b.Box303e * SAP_Module.Calculation2012.Calculation.Fuel_costs_10b.Box342eP;
        }
        this.Waterband = num4 * box306;
        this.Waterband2 = num3 * box306;
      }
      this.WaterBanding = PDFFunctions.BandCheckHeating(this.Waterband, "PDF");
      this.WaterBanding2 = PDFFunctions.BandCheckHeating2(this.Waterband2, "PDF");
      if ((double) SAP_Module.Proj.Dwellings[House].Water.Cylinder.Volume != 0.0 & (double) SAP_Module.Proj.Dwellings[House].Water.Cylinder.InsThick == 0.0 & !SAP_Module.Proj.Dwellings[House].Water.Cylinder.ManuSpecified)
      {
        string waterBanding = this.WaterBanding;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(waterBanding, "★★★★★", false) != 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(waterBanding, "★★★★☆", false) != 0)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(waterBanding, "★★★☆☆", false) != 0)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(waterBanding, "★★☆☆☆", false) == 0)
                this.WaterBanding = "★☆☆☆☆";
            }
            else
              this.WaterBanding = "★★☆☆☆";
          }
          else
            this.WaterBanding = "★★★☆☆";
        }
        else
          this.WaterBanding = "★★★★☆";
        string waterBanding2 = this.WaterBanding2;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(waterBanding2, "★★★★★", false) != 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(waterBanding2, "★★★★☆", false) != 0)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(waterBanding2, "★★★☆☆", false) != 0)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(waterBanding2, "★★☆☆☆", false) == 0)
                this.WaterBanding2 = "★☆☆☆☆";
            }
            else
              this.WaterBanding2 = "★★☆☆☆";
          }
          else
            this.WaterBanding2 = "★★★☆☆";
        }
        else
          this.WaterBanding2 = "★★★★☆";
      }
      int systemRef = SAP_Module.Proj.Dwellings[House].Water.SystemRef;
      if (systemRef != 901 && systemRef != 914 && (systemRef < 921 || systemRef > 931) && !SAP_Module.Proj.Dwellings[House].Water.System.Contains("From hot-water only community") && !this.HotWaterDesc.Contains("Electric immersion") && !SAP_Module.Proj.Dwellings[House].Water.Cylinder.Thermostat)
      {
        string waterBanding = this.WaterBanding;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(waterBanding, "★★★★★", false) != 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(waterBanding, "★★★★☆", false) != 0)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(waterBanding, "★★★☆☆", false) != 0)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(waterBanding, "★★☆☆☆", false) == 0)
                this.WaterBanding = "★☆☆☆☆";
            }
            else
              this.WaterBanding = "★★☆☆☆";
          }
          else
            this.WaterBanding = "★★★☆☆";
        }
        else
          this.WaterBanding = "★★★★☆";
        string waterBanding2 = this.WaterBanding2;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(waterBanding2, "★★★★★", false) != 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(waterBanding2, "★★★★☆", false) != 0)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(waterBanding2, "★★★☆☆", false) != 0)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(waterBanding2, "★★☆☆☆", false) == 0)
                this.WaterBanding2 = "★☆☆☆☆";
            }
            else
              this.WaterBanding2 = "★★☆☆☆";
          }
          else
            this.WaterBanding2 = "★★★☆☆";
        }
        else
          this.WaterBanding2 = "★★★★☆";
      }
      if (flag)
      {
        string waterBanding2 = this.WaterBanding2;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(waterBanding2, "★★★★☆", false) != 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(waterBanding2, "★★★☆☆", false) != 0)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(waterBanding2, "★★☆☆☆", false) != 0)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(waterBanding2, "★☆☆☆☆", false) == 0)
                this.WaterBanding2 = "★★☆☆☆";
            }
            else
              this.WaterBanding2 = "★★★☆☆";
          }
          else
            this.WaterBanding2 = "★★★★☆";
        }
        else
          this.WaterBanding2 = "★★★★★";
        string waterBanding = this.WaterBanding;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(waterBanding, "★★★★☆", false) != 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(waterBanding, "★★★☆☆", false) != 0)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(waterBanding, "★★☆☆☆", false) != 0)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(waterBanding, "★☆☆☆☆", false) == 0)
                this.WaterBanding = "★★☆☆☆";
            }
            else
              this.WaterBanding = "★★★☆☆";
          }
          else
            this.WaterBanding = "★★★★☆";
        }
        else
          this.WaterBanding = "★★★★★";
      }
      if (SAP_Module.Proj.Dwellings[House].Water.Solar.Inlcude)
      {
        this.HotWaterDesc += ", plus solar";
        string waterBanding2 = this.WaterBanding2;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(waterBanding2, "★★★★☆", false) != 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(waterBanding2, "★★★☆☆", false) != 0)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(waterBanding2, "★★☆☆☆", false) != 0)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(waterBanding2, "★☆☆☆☆", false) == 0)
                this.WaterBanding = "★★☆☆☆";
            }
            else
              this.WaterBanding = "★★★☆☆";
          }
          else
          {
            this.WaterBanding2 = "★★★★☆";
            string waterBanding = this.WaterBanding;
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(waterBanding, "★★☆☆☆", false) != 0)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(waterBanding, "★☆☆☆☆", false) == 0)
                this.WaterBanding2 = "★★☆☆☆";
            }
            else
              this.WaterBanding2 = "★★★☆☆";
          }
        }
        else
          this.WaterBanding2 = "★★★★★";
      }
      if (SAP_Module.Proj.Dwellings[House].Water.WWHRS.Include)
      {
        this.HotWaterDesc += ", waste water heat recovery";
        string waterBanding2 = this.WaterBanding2;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(waterBanding2, "★★★★☆", false) != 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(waterBanding2, "★★★☆☆", false) != 0)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(waterBanding2, "★★☆☆☆", false) != 0)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(waterBanding2, "★☆☆☆☆", false) == 0)
                this.WaterBanding2 = "★★☆☆☆";
            }
            else
              this.WaterBanding2 = "★★★☆☆";
          }
          else
            this.WaterBanding2 = "★★★★☆";
        }
        else
          this.WaterBanding2 = "★★★★★";
        string waterBanding = this.WaterBanding;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(waterBanding, "★★★★☆", false) != 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(waterBanding, "★★★☆☆", false) != 0)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(waterBanding, "★★☆☆☆", false) != 0)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(waterBanding, "★☆☆☆☆", false) == 0)
                this.WaterBanding = "★★☆☆☆";
            }
            else
              this.WaterBanding = "★★★☆☆";
          }
          else
            this.WaterBanding = "★★★★☆";
        }
        else
          this.WaterBanding = "★★★★★";
      }
      this.XML_WaterBanding = this.WaterBanding;
      this.XML_WaterBanding2 = this.WaterBanding2;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].Transaction, "New dwelling", false) != 0)
        return;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.WaterBanding, "★★☆☆☆", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.WaterBanding, "★☆☆☆☆", false) == 0)
        this.WaterBanding = "-";
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.WaterBanding2, "★★☆☆☆", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.WaterBanding2, "★☆☆☆☆", false) == 0)
        this.WaterBanding2 = "-";
    }

    private void _PropertySummaryWalls(XmlTextWriter XMLobj, int House, int Country)
    {
      XMLobj.WriteStartElement("Walls");
      XMLobj.WriteStartElement("Description");
      XMLobj.WriteStartAttribute("language");
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].EPCLanguage, "Welsh", false) == 0)
        XMLobj.WriteValue("2");
      else
        XMLobj.WriteValue("1");
      XMLobj.WriteEndAttribute();
      if (Country == 2 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].EPCLanguage, "Welsh", false) == 0)
        XMLobj.WriteValue("Trawsyriannedd thermol cyfartalog " + Microsoft.VisualBasic.Strings.Format((object) SAP_Module.Calculation2012._Add_Variable.Averages.Wall_U, "0.00") + " W/m\u00B2K");
      else
        XMLobj.WriteValue("Average thermal transmittance " + Microsoft.VisualBasic.Strings.Format((object) SAP_Module.Calculation2012._Add_Variable.Averages.Wall_U, "0.00") + " W/m\u00B2K");
      XMLobj.WriteEndElement();
      XMLobj.WriteStartElement("Energy-Efficiency-Rating");
      XMLobj.WriteValue(PDFFunctions.BandCheckWall(Math.Round(SAP_Module.Calculation2012._Add_Variable.Averages.Wall_U, 2), "XML"));
      XMLobj.WriteEndElement();
      XMLobj.WriteStartElement("Environmental-Efficiency-Rating");
      XMLobj.WriteValue(PDFFunctions.BandCheckWall(Math.Round(SAP_Module.Calculation2012._Add_Variable.Averages.Wall_U, 2), "XML"));
      XMLobj.WriteEndElement();
      XMLobj.WriteEndElement();
    }

    private void _PropertySummaryRoofs(XmlTextWriter XMLobj, int House, int Country)
    {
      XMLobj.WriteStartElement("Roof");
      XMLobj.WriteStartElement("Description");
      XMLobj.WriteStartAttribute("language");
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].EPCLanguage, "Welsh", false) == 0)
        XMLobj.WriteValue("2");
      else
        XMLobj.WriteValue("1");
      XMLobj.WriteEndAttribute();
      if (Country == 2 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].EPCLanguage, "Welsh", false) == 0)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Calculation2012._Add_Variable.Averages.Roof_U.ToString(), "NaN", false) == 0)
          XMLobj.WriteValue("(eiddo arall uwchben)");
        else
          XMLobj.WriteValue("Trawsyriannedd thermol cyfartalog " + Conversions.ToString(Math.Round(SAP_Module.Calculation2012._Add_Variable.Averages.Roof_U, 2)) + " W/m\u00B2K");
      }
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Calculation2012._Add_Variable.Averages.Roof_U.ToString(), "NaN", false) == 0)
        XMLobj.WriteValue("(other premises above)");
      else if (SAP_Module.Calculation2012._Add_Variable.Averages.Roof_U == 0.0)
        XMLobj.WriteValue("(other premises above)");
      else if (SAP_Module.Proj.Dwellings[House].NoofRoofs == 0)
        XMLobj.WriteValue("Average thermal transmittance 0 W/m\u00B2K");
      else
        XMLobj.WriteValue("Average thermal transmittance " + Conversions.ToString(Math.Round(SAP_Module.Calculation2012._Add_Variable.Averages.Roof_U, 2)) + " W/m\u00B2K");
      XMLobj.WriteEndElement();
      XMLobj.WriteStartElement("Energy-Efficiency-Rating");
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(PDFFunctions.BandCheckRoof(Math.Round(SAP_Module.Calculation2012._Add_Variable.Averages.Roof_U, 2), "XML"), "", false) == 0)
        XMLobj.WriteValue(0);
      else if (SAP_Module.Calculation2012._Add_Variable.Averages.Roof_U == 0.0)
        XMLobj.WriteValue(0);
      else
        XMLobj.WriteValue(PDFFunctions.BandCheckRoof(Math.Round(SAP_Module.Calculation2012._Add_Variable.Averages.Roof_U, 2), "XML"));
      XMLobj.WriteEndElement();
      XMLobj.WriteStartElement("Environmental-Efficiency-Rating");
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(PDFFunctions.BandCheckRoof(Math.Round(SAP_Module.Calculation2012._Add_Variable.Averages.Roof_U, 2), "XML"), "", false) == 0)
        XMLobj.WriteValue(0);
      else if (SAP_Module.Calculation2012._Add_Variable.Averages.Roof_U == 0.0)
        XMLobj.WriteValue(0);
      else
        XMLobj.WriteValue(PDFFunctions.BandCheckRoof(Math.Round(SAP_Module.Calculation2012._Add_Variable.Averages.Roof_U, 2), "XML"));
      XMLobj.WriteEndElement();
      XMLobj.WriteEndElement();
    }

    private void _PropertySummaryFloors(XmlTextWriter XMLobj, int House, int Country)
    {
      XMLobj.WriteStartElement("Floor");
      XMLobj.WriteStartElement("Description");
      if (SAP_Module.Proj.Dwellings[House].NoofFloors == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Calculation2012._Add_Variable.Averages.Floor_U.ToString(), "NaN", false) == 0)
      {
        XMLobj.WriteStartAttribute("language");
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].EPCLanguage, "Welsh", false) == 0)
          XMLobj.WriteValue("2");
        else
          XMLobj.WriteValue("1");
        XMLobj.WriteEndAttribute();
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].EPCLanguage, "Welsh", false) == 0)
          XMLobj.WriteValue("(eiddo arall islaw)");
        else
          XMLobj.WriteValue("(other premises below)");
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("Energy-Efficiency-Rating");
        XMLobj.WriteValue(0);
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("Environmental-Efficiency-Rating");
        XMLobj.WriteValue(0);
        XMLobj.WriteEndElement();
      }
      else
      {
        XMLobj.WriteStartAttribute("language");
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].EPCLanguage, "Welsh", false) == 0)
          XMLobj.WriteValue("2");
        else
          XMLobj.WriteValue("1");
        XMLobj.WriteEndAttribute();
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].EPCLanguage, "Welsh", false) == 0)
          XMLobj.WriteValue("Trawsyriannedd thermol cyfartalog " + Microsoft.VisualBasic.Strings.Format((object) Math.Round(SAP_Module.Calculation2012._Add_Variable.Averages.Floor_U, 2), "0.00") + " W/m\u00B2K");
        else
          XMLobj.WriteValue("Average thermal transmittance " + Microsoft.VisualBasic.Strings.Format((object) Math.Round(SAP_Module.Calculation2012._Add_Variable.Averages.Floor_U, 2), "0.00") + " W/m\u00B2K");
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("Energy-Efficiency-Rating");
        XMLobj.WriteValue(PDFFunctions.BandCheckFloor(Math.Round(SAP_Module.Calculation2012._Add_Variable.Averages.Floor_U, 2), "XML"));
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("Environmental-Efficiency-Rating");
        XMLobj.WriteValue(PDFFunctions.BandCheckFloor(Math.Round(SAP_Module.Calculation2012._Add_Variable.Averages.Floor_U, 2), "XML"));
        XMLobj.WriteEndElement();
      }
      XMLobj.WriteEndElement();
    }

    private void _PropertySummaryHeating(XmlTextWriter XMLobj, int House, int Country)
    {
      this.HeatingBanding(House);
      this.HeatingDescription(House, Country);
      XMLobj.WriteStartElement("Main-Heating");
      XMLobj.WriteStartElement("Description");
      XMLobj.WriteStartAttribute("language");
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].EPCLanguage, "Welsh", false) == 0)
        XMLobj.WriteValue("2");
      else
        XMLobj.WriteValue("1");
      XMLobj.WriteEndAttribute();
      if (Country == 2 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].EPCLanguage, "Welsh", false) == 0)
        XMLobj.WriteValue(this.HeatingHeadingwWALES);
      else
        XMLobj.WriteValue(this.HeatingHeading);
      XMLobj.WriteEndElement();
      XMLobj.WriteStartElement("Energy-Efficiency-Rating");
      XMLobj.WriteValue(this.MainBrand);
      XMLobj.WriteEndElement();
      XMLobj.WriteStartElement("Environmental-Efficiency-Rating");
      XMLobj.WriteValue(this.MainBrand2);
      XMLobj.WriteEndElement();
      XMLobj.WriteEndElement();
      if (!SAP_Module.Proj.Dwellings[House].IncludeMainHeating2 || (double) SAP_Module.Proj.Dwellings[House].HeatFractionSec < 0.1)
        return;
      XMLobj.WriteStartElement("Main-Heating");
      XMLobj.WriteStartElement("Description");
      if (this.Compare_Heaters(House))
        this.HeatingHeading2 = this.HeatingHeading;
      XMLobj.WriteStartAttribute("language");
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].EPCLanguage, "Welsh", false) == 0)
        XMLobj.WriteValue("2");
      else
        XMLobj.WriteValue("1");
      XMLobj.WriteEndAttribute();
      if (Country == 2 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].EPCLanguage, "Welsh", false) == 0)
        XMLobj.WriteValue(this.HeatingHeadingwWALES2);
      else
        XMLobj.WriteValue(this.HeatingHeading2);
      XMLobj.WriteEndElement();
      if (this.Compare_Heaters(House))
      {
        this.secMainBrand = this.MainBrand;
        this.secMainBrand2 = this.MainBrand2;
      }
      XMLobj.WriteStartElement("Energy-Efficiency-Rating");
      XMLobj.WriteValue(this.secMainBrand);
      XMLobj.WriteEndElement();
      XMLobj.WriteStartElement("Environmental-Efficiency-Rating");
      XMLobj.WriteValue(this.secMainBrand2);
      XMLobj.WriteEndElement();
      XMLobj.WriteEndElement();
    }

    private void _PropertySummaryHeatingControl(XmlTextWriter XMLobj, int House, int Country)
    {
      this.HeatingControl_banidng(House, Country);
      XMLobj.WriteStartElement("Main-Heating-Controls");
      XMLobj.WriteStartElement("Description");
      XMLobj.WriteStartAttribute("language");
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].EPCLanguage, "Welsh", false) == 0)
        XMLobj.WriteValue("2");
      else
        XMLobj.WriteValue("1");
      XMLobj.WriteEndAttribute();
      XMLobj.WriteValue(PDFFunctions.CheckWalesHeatingControl(SAP_Module.Proj.Dwellings[House].MainHeating.Controls, Country));
      XMLobj.WriteEndElement();
      try
      {
        if (this.XML_controlCode == null)
          this.XML_controlCode = "0";
        XMLobj.WriteStartElement("Energy-Efficiency-Rating");
        XMLobj.WriteValue(this.XML_controlCode);
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("Environmental-Efficiency-Rating");
        XMLobj.WriteValue(this.XML_controlCode);
        XMLobj.WriteEndElement();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      XMLobj.WriteEndElement();
      if (!(SAP_Module.Proj.Dwellings[House].IncludeMainHeating2 & !this.Compare_Heaters(House)) || (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.Controls, SAP_Module.Proj.Dwellings[House].MainHeating2.Controls, false) <= 0U)
        return;
      XMLobj.WriteStartElement("Main-Heating-Controls");
      XMLobj.WriteStartElement("Description");
      XMLobj.WriteStartAttribute("language");
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].EPCLanguage, "Welsh", false) == 0)
        XMLobj.WriteValue("2");
      else
        XMLobj.WriteValue("1");
      XMLobj.WriteEndAttribute();
      XMLobj.WriteValue(PDFFunctions.CheckWalesHeatingControl(SAP_Module.Proj.Dwellings[House].MainHeating2.Controls, Country));
      XMLobj.WriteEndElement();
      XMLobj.WriteStartElement("Energy-Efficiency-Rating");
      XMLobj.WriteValue(this.XML_controlCode2);
      XMLobj.WriteEndElement();
      XMLobj.WriteStartElement("Environmental-Efficiency-Rating");
      XMLobj.WriteValue(this.XML_controlCode2);
      XMLobj.WriteEndElement();
      XMLobj.WriteEndElement();
    }

    private void _PropertySummaryWaterHeating(XmlTextWriter XMLobj, int House, int Country)
    {
      this._Banding_Desc_Water(House, Country);
      XMLobj.WriteStartElement("Hot-Water");
      string xmlWaterBanding = this.XML_WaterBanding;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(xmlWaterBanding, "★★★★★", false) != 0)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(xmlWaterBanding, "★★★★☆", false) != 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(xmlWaterBanding, "★★★☆☆", false) != 0)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(xmlWaterBanding, "★★☆☆☆", false) != 0)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(xmlWaterBanding, "★☆☆☆☆", false) != 0)
              {
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(xmlWaterBanding, "-", false) == 0)
                  this.XML_WaterBanding = Conversions.ToString(0);
              }
              else
                this.XML_WaterBanding = Conversions.ToString(1);
            }
            else
              this.XML_WaterBanding = Conversions.ToString(2);
          }
          else
            this.XML_WaterBanding = Conversions.ToString(3);
        }
        else
          this.XML_WaterBanding = Conversions.ToString(4);
      }
      else
        this.XML_WaterBanding = Conversions.ToString(5);
      string xmlWaterBanding2 = this.XML_WaterBanding2;
      // ISSUE: reference to a compiler-generated method
      switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(xmlWaterBanding2))
      {
        case 508431260:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(xmlWaterBanding2, "★★★★★", false) == 0)
          {
            this.XML_WaterBanding2 = Conversions.ToString(5);
            goto default;
          }
          else
            goto default;
        case 558764117:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(xmlWaterBanding2, "★★★★☆", false) == 0)
          {
            this.XML_WaterBanding2 = Conversions.ToString(4);
            goto default;
          }
          else
            goto default;
        case 671913016:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(xmlWaterBanding2, "-", false) == 0)
            break;
          goto default;
        case 2166136261:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(xmlWaterBanding2, "", false) == 0)
            break;
          goto default;
        case 2649900595:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(xmlWaterBanding2, "★★☆☆☆", false) == 0)
          {
            this.XML_WaterBanding2 = Conversions.ToString(2);
            goto default;
          }
          else
            goto default;
        case 2825656824:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(xmlWaterBanding2, "★☆☆☆☆", false) == 0)
          {
            this.XML_WaterBanding2 = Conversions.ToString(1);
            goto default;
          }
          else
            goto default;
        case 2939816218:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(xmlWaterBanding2, "★★★☆☆", false) == 0)
          {
            this.XML_WaterBanding2 = Conversions.ToString(3);
            goto default;
          }
          else
            goto default;
        default:
label_26:
          try
          {
            if (Conversions.ToDouble(this.XML_WaterBanding2) != 5.0 && SAP_Module.Proj.Dwellings[House].MainHeating.SGroup.Contains("heat pumps"))
              this.XML_WaterBanding2 = Conversions.ToString(Conversion.Val(this.XML_WaterBanding2) + 1.0);
            if (Conversions.ToDouble(this.XML_WaterBanding) != 5.0)
            {
              if (SAP_Module.Proj.Dwellings[House].MainHeating.SGroup.Contains("heat pumps"))
                this.XML_WaterBanding = Conversions.ToString(Conversion.Val(this.XML_WaterBanding) + 1.0);
            }
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
          try
          {
            if (Conversions.ToDouble(this.XML_WaterBanding2) != 5.0)
            {
              if (SAP_Module.Proj.Dwellings[House].MainHeating.SGroup.Contains("Micro-cogeneration (micro-CHP)") & SAP_Module.Proj.Dwellings[House].Water.SystemRef == 901)
              {
                if (Conversions.ToDouble(this.XML_WaterBanding2) < 5.0)
                  this.XML_WaterBanding2 = Conversions.ToString(Conversion.Val(this.XML_WaterBanding2) + 1.0);
                if (Conversions.ToDouble(this.XML_WaterBanding) < 5.0)
                  this.XML_WaterBanding = Conversions.ToString(Conversion.Val(this.XML_WaterBanding) + 1.0);
              }
            }
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
          XMLobj.WriteStartElement("Description");
          XMLobj.WriteStartAttribute("language");
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].EPCLanguage, "Welsh", false) == 0)
            XMLobj.WriteValue("2");
          else
            XMLobj.WriteValue("1");
          XMLobj.WriteEndAttribute();
          XMLobj.WriteValue(PDFFunctions.checkWalesWater(PDFFunctions.CheckSecHeating_Heading(this.HotWaterDesc), Country));
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("Energy-Efficiency-Rating");
          XMLobj.WriteValue(this.XML_WaterBanding);
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("Environmental-Efficiency-Rating");
          XMLobj.WriteValue(this.XML_WaterBanding2);
          XMLobj.WriteEndElement();
          XMLobj.WriteEndElement();
          return;
      }
      this.XML_WaterBanding2 = Conversions.ToString(0);
      goto label_26;
    }

    private void _PropertySummarySecHeating(XmlTextWriter XMLobj, int House, int Country)
    {
      XMLobj.WriteStartElement("Secondary-Heating");
      XMLobj.WriteStartElement("Description");
      XMLobj.WriteStartAttribute("language");
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].EPCLanguage, "Welsh", false) == 0)
        XMLobj.WriteValue("2");
      else
        XMLobj.WriteValue("1");
      XMLobj.WriteEndAttribute();
      if (Country == 2 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].EPCLanguage, "Welsh", false) == 0)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].SecHeating.HGroup, "", false) == 0)
          XMLobj.WriteValue("Dim");
        else
          XMLobj.WriteValue("Gwresogyddion ystafell, " + PDFFunctions.CheckWalesFuel(SAP_Module.Proj.Dwellings[House].SecHeating.Fuel));
      }
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].SecHeating.HGroup, "", false) == 0)
        XMLobj.WriteValue("None");
      else
        XMLobj.WriteValue("Room heaters, " + PDFFunctions.CheckFuel((object) SAP_Module.Proj.Dwellings[House].SecHeating.Fuel));
      XMLobj.WriteEndElement();
      XMLobj.WriteStartElement("Energy-Efficiency-Rating");
      XMLobj.WriteValue(0);
      XMLobj.WriteEndElement();
      XMLobj.WriteStartElement("Environmental-Efficiency-Rating");
      XMLobj.WriteValue(0);
      XMLobj.WriteEndElement();
      XMLobj.WriteEndElement();
    }

    private void _PropertySummaryLighting(XmlTextWriter XMLobj, int House, int Country)
    {
      XMLobj.WriteStartElement("Lighting");
      XMLobj.WriteStartElement("Description");
      XMLobj.WriteStartAttribute("language");
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].EPCLanguage, "Welsh", false) == 0)
        XMLobj.WriteValue("2");
      else
        XMLobj.WriteValue("1");
      XMLobj.WriteEndAttribute();
      if (Country == 2 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].EPCLanguage, "Welsh", false) == 0)
      {
        if ((double) SAP_Module.Proj.Dwellings[House].LowEnergyLight == 0.0)
          XMLobj.WriteValue("Dim goleuadau ynni-isel");
        else if ((double) SAP_Module.Proj.Dwellings[House].LowEnergyLight == 100.0)
          XMLobj.WriteValue("Goleuadau ynni-isel ym mhob un o’r mannau gosod");
        else
          XMLobj.WriteValue("Goleuadau ynni-isel mewn " + Conversions.ToString(Math.Round((double) SAP_Module.Proj.Dwellings[House].LowEnergyLight, 0)) + "% o’r mannau gosod");
      }
      else if ((double) SAP_Module.Proj.Dwellings[House].LowEnergyLight == 0.0)
        XMLobj.WriteValue("No Low energy lighting");
      else if ((double) SAP_Module.Proj.Dwellings[House].LowEnergyLight == 100.0)
        XMLobj.WriteValue("Low energy lighting in all fixed outlets");
      else
        XMLobj.WriteValue("Low energy lighting in " + Conversions.ToString(Math.Round((double) SAP_Module.Proj.Dwellings[House].LowEnergyLight, 0)) + "% of fixed outlets");
      XMLobj.WriteEndElement();
      XMLobj.WriteStartElement("Energy-Efficiency-Rating");
      XMLobj.WriteValue(PDFFunctions.BandCheckLighting((double) SAP_Module.Proj.Dwellings[House].LowEnergyLight, "XML"));
      XMLobj.WriteEndElement();
      XMLobj.WriteStartElement("Environmental-Efficiency-Rating");
      XMLobj.WriteValue(PDFFunctions.BandCheckLighting((double) SAP_Module.Proj.Dwellings[House].LowEnergyLight, "XML"));
      XMLobj.WriteEndElement();
      XMLobj.WriteEndElement();
    }

    private void _PropertySummaryAirTightness(XmlTextWriter XMLobj, int House, int Country)
    {
      if (!((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].Status, "Existing dwelling (SAP)", false) > 0U | (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].Status, "New extension to existing dwelling", false) > 0U))
        return;
      XMLobj.WriteStartElement("Air-Tightness");
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].Ventilation.Pressure, "Calculated", false) == 0)
      {
        XMLobj.WriteStartElement("Description");
        if (Country == 2 | Country == 4)
        {
          XMLobj.WriteStartAttribute("language");
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].EPCLanguage, "Welsh", false) == 0)
            XMLobj.WriteValue("2");
          else
            XMLobj.WriteValue("1");
          XMLobj.WriteEndAttribute();
          XMLobj.WriteValue("(heb ei brofi)");
        }
        else
          XMLobj.WriteValue("(not tested)");
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("Energy-Efficiency-Rating");
        XMLobj.WriteValue(0);
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("Environmental-Efficiency-Rating");
        XMLobj.WriteValue(0);
        XMLobj.WriteEndElement();
      }
      else
      {
        XMLobj.WriteStartElement("Description");
        XMLobj.WriteStartAttribute("language");
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].EPCLanguage, "Welsh", false) == 0)
          XMLobj.WriteValue("2");
        else
          XMLobj.WriteValue("1");
        XMLobj.WriteEndAttribute();
        float num;
        if (Country == 2 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].EPCLanguage, "Welsh", false) == 0)
        {
          if ((double) SAP_Module.Proj.Dwellings[House].Ventilation.DesignAir != 0.0)
          {
            XMLobj.WriteValue("Athreiddedd aer " + Microsoft.VisualBasic.Strings.Format((object) SAP_Module.Proj.Dwellings[House].Ventilation.DesignAir, "0.0") + " m\u00B3/h.m\u00B2 (rhagdybiaeth)");
            num = SAP_Module.Proj.Dwellings[House].Ventilation.DesignAir;
          }
          if ((double) SAP_Module.Proj.Dwellings[House].Ventilation.MeasuredAir != 0.0)
          {
            if (SAP_Module.Proj.Dwellings[House].Ventilation.AveragePerm)
            {
              XMLobj.WriteValue("Athreiddedd aer " + Microsoft.VisualBasic.Strings.Format((object) (float) ((double) SAP_Module.Proj.Dwellings[House].Ventilation.MeasuredAir + 2.0), "0.0") + " m\u00B3/h.m\u00B2  (cyfartaledd wedi’i asesu)");
              num = SAP_Module.Proj.Dwellings[House].Ventilation.MeasuredAir + 2f;
            }
            else
            {
              XMLobj.WriteValue("Athreiddedd aer " + Microsoft.VisualBasic.Strings.Format((object) SAP_Module.Proj.Dwellings[House].Ventilation.MeasuredAir, "0.0") + " m\u00B3/h.m\u00B2  (wedi’i brofi)");
              num = SAP_Module.Proj.Dwellings[House].Ventilation.MeasuredAir;
            }
          }
        }
        else
        {
          if (SAP_Module.Proj.Dwellings[House].Ventilation.AveragePerm)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].Ventilation.Pressure, "As built", false) == 0)
            {
              XMLobj.WriteValue("Air permeability " + Microsoft.VisualBasic.Strings.Format((object) (float) ((double) SAP_Module.Proj.Dwellings[House].Ventilation.MeasuredAir + 2.0), "0.0") + " m\u00B3/h.m\u00B2 (assessed average)");
              num = SAP_Module.Proj.Dwellings[House].Ventilation.MeasuredAir;
            }
            else
            {
              XMLobj.WriteValue("Air permeability " + Microsoft.VisualBasic.Strings.Format((object) (float) ((double) SAP_Module.Proj.Dwellings[House].Ventilation.DesignAir + 2.0), "0.0") + " m\u00B3/h.m\u00B2 (assessed average)");
              num = SAP_Module.Proj.Dwellings[House].Ventilation.DesignAir;
            }
          }
          else if ((double) SAP_Module.Proj.Dwellings[House].Ventilation.MeasuredAir != 0.0)
          {
            XMLobj.WriteValue("Air permeability " + Microsoft.VisualBasic.Strings.Format((object) SAP_Module.Proj.Dwellings[House].Ventilation.MeasuredAir, "0.0") + " m\u00B3/h.m\u00B2 (as tested)");
            num = SAP_Module.Proj.Dwellings[House].Ventilation.MeasuredAir;
          }
          else if ((double) SAP_Module.Proj.Dwellings[House].Ventilation.DesignAir != 0.0)
          {
            XMLobj.WriteValue("Air permeability " + Microsoft.VisualBasic.Strings.Format((object) SAP_Module.Proj.Dwellings[House].Ventilation.DesignAir, "0.0") + " m\u00B3/h.m\u00B2 (assumed)");
            num = SAP_Module.Proj.Dwellings[House].Ventilation.DesignAir;
          }
          else if ((double) SAP_Module.Proj.Dwellings[House].Ventilation.AssumedAir != 0.0)
          {
            XMLobj.WriteValue("(not tested)");
            num = SAP_Module.Proj.Dwellings[House].Ventilation.MeasuredAir;
          }
          if ((double) SAP_Module.Proj.Dwellings[House].Ventilation.AssumedAir != 0.0)
          {
            if (Country == 2 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].EPCLanguage, "Welsh", false) == 0)
              XMLobj.WriteValue("(heb ei brofi)");
            num = SAP_Module.Proj.Dwellings[House].Ventilation.AssumedAir;
          }
        }
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("Energy-Efficiency-Rating");
        if ((double) SAP_Module.Proj.Dwellings[House].Ventilation.AssumedAir == 0.0)
          XMLobj.WriteValue(PDFFunctions.BandCheckAirPressure((double) num, "XML"));
        else
          XMLobj.WriteValue(0);
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("Environmental-Efficiency-Rating");
        if ((double) SAP_Module.Proj.Dwellings[House].Ventilation.AssumedAir == 0.0)
          XMLobj.WriteValue(PDFFunctions.BandCheckAirPressure((double) num, "XML"));
        else
          XMLobj.WriteValue(0);
        XMLobj.WriteEndElement();
      }
      XMLobj.WriteEndElement();
    }

    private void _PropertySummaryWindows(XmlTextWriter XMLobj, int House, int Country)
    {
      XMLobj.WriteStartElement("Windows");
      XMLobj.WriteStartElement("Description");
      XMLobj.WriteStartAttribute("language");
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].EPCLanguage, "Welsh", false) == 0)
        XMLobj.WriteValue("2");
      else
        XMLobj.WriteValue("1");
      XMLobj.WriteEndAttribute();
      if (SAP_Module.Calculation2012._Add_Variable.Averages.Description != null)
        XMLobj.WriteValue(PDFFunctions.CheckWalesWindows(SAP_Module.Calculation2012._Add_Variable.Averages.Description, Country));
      XMLobj.WriteEndElement();
      XMLobj.WriteStartElement("Energy-Efficiency-Rating");
      XMLobj.WriteValue(PDFFunctions.BandCheckWindows(Math.Round(SAP_Module.Calculation2012._Add_Variable.Averages.Window_U, 2), "XML"));
      XMLobj.WriteEndElement();
      XMLobj.WriteStartElement("Environmental-Efficiency-Rating");
      XMLobj.WriteValue(PDFFunctions.BandCheckWindows(Math.Round(SAP_Module.Calculation2012._Add_Variable.Averages.Window_U, 2), "XML"));
      XMLobj.WriteEndElement();
      XMLobj.WriteEndElement();
    }

    private void _propertySummaryWater_Cylinder(XmlTextWriter XMLobj, int House, int Country)
    {
      if (SAP_Module.Proj.Dwellings[House].WaterOnlyHeatPump)
      {
        if (SAP_Module.Proj.Dwellings[House].MainHeating2.HPOnly.HotWaterHP_Integral)
        {
          XMLobj.WriteStartElement("Has-Hot-Water-Cylinder", (string) null);
          XMLobj.WriteValue("false");
          XMLobj.WriteEndElement();
        }
        else
        {
          XMLobj.WriteStartElement("Has-Hot-Water-Cylinder", (string) null);
          XMLobj.WriteValue("true");
          XMLobj.WriteEndElement();
        }
      }
      else
      {
        XMLobj.WriteStartElement("Has-Hot-Water-Cylinder", (string) null);
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
    }

    private void _propertySummaryAirConditioning(XmlTextWriter XMLobj, int House, int Country)
    {
      XMLobj.WriteStartElement("Has-Fixed-Air-Conditioning");
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
      XMLobj.WriteStartElement("Has-Heated-Separate-Conservatory");
      if (!string.IsNullOrEmpty(SAP_Module.Proj.Dwellings[House].Conservatory))
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].Conservatory, "Separated heated conservatory", false) == 0)
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
      XMLobj.WriteStartElement("Dwelling-Type");
      XMLobj.WriteStartAttribute("language");
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].EPCLanguage, "Welsh", false) == 0)
        XMLobj.WriteValue("2");
      else
        XMLobj.WriteValue("1");
      XMLobj.WriteEndAttribute();
      if (Country == 2 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].EPCLanguage, "Welsh", false) == 0)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].PropertyType, nameof (House), false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].PropertyType, "Bungalow", false) == 0)
          XMLobj.WriteValue(PDFFunctions.CheckWalesDwellingType(SAP_Module.Proj.Dwellings[House].BuildForm + " " + SAP_Module.Proj.Dwellings[House].PropertyType));
        else
          XMLobj.WriteValue(PDFFunctions.CheckWalesDwellingType(SAP_Module.Proj.Dwellings[House].FlatType.Replace(" ", "-") + " " + Microsoft.VisualBasic.Strings.LCase(SAP_Module.Proj.Dwellings[House].PropertyType)));
      }
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].PropertyType, nameof (House), false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].PropertyType, "Bungalow", false) == 0)
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].BuildForm + " " + Microsoft.VisualBasic.Strings.LCase(SAP_Module.Proj.Dwellings[House].PropertyType));
      else
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].FlatType.Replace(" ", "-") + " " + Microsoft.VisualBasic.Strings.LCase(SAP_Module.Proj.Dwellings[House].PropertyType));
      XMLobj.WriteEndElement();
    }

    private void _propertySummary_TotalFloorArea(XmlTextWriter XMLobj, int House, int Country)
    {
      XMLobj.WriteStartElement("Total-Floor-Area");
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
      XMLobj.WriteStartElement("Is-Zero-Carbon-Home");
      XMLobj.WriteValue("Yes");
      XMLobj.WriteEndElement();
    }

    private void _propertySummary_MultipleGlazedPercentage(
      XmlTextWriter XMLobj,
      int House,
      int Country)
    {
      XMLobj.WriteStartElement("Multiple-Glazed-Percentage");
      XMLobj.WriteValue("100");
      XMLobj.WriteEndElement();
    }

    private void _EnergyAssessment_PropertySummary(XmlTextWriter XMLobj, int House, int Country)
    {
      try
      {
        XMLobj.WriteStartElement("Property-Summary");
        this._PropertySummaryWalls(XMLobj, House, Country);
        this._PropertySummaryRoofs(XMLobj, House, Country);
        this._PropertySummaryFloors(XMLobj, House, Country);
        this._PropertySummaryWindows(XMLobj, House, Country);
        this._PropertySummaryHeating(XMLobj, House, Country);
        this._PropertySummaryHeatingControl(XMLobj, House, Country);
        this._PropertySummarySecHeating(XMLobj, House, Country);
        this._PropertySummaryWaterHeating(XMLobj, House, Country);
        this._PropertySummaryLighting(XMLobj, House, Country);
        this._PropertySummaryAirTightness(XMLobj, House, Country);
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
      XMLobj.WriteStartElement("Energy-Use");
      XMLobj.WriteStartElement("Energy-Rating-Average");
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].Address.Country, "Northern Ireland", false) == 0)
        XMLobj.WriteValue(57);
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].Address.Country, "Scotland", false) == 0)
        XMLobj.WriteValue(61);
      else
        XMLobj.WriteValue(60);
      XMLobj.WriteEndElement();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].Address.Country, "Northern Ireland", false) == 0)
      {
        XMLobj.WriteStartElement("Energy-Rating-Typical-Newbuild");
        XMLobj.WriteValue(Functions.FindNewDwellingRatingNI(SAP_Module.CurrDwelling));
        XMLobj.WriteEndElement();
      }
      XMLobj.WriteStartElement("Energy-Rating-Current");
      if (SAP_Module.Calculation2012.Calculation.SAP_rating_11a.SAPRating <= 0.0 & SAP_Module.Calculation2012.Calculation.SAP_rating_11b.SAPRating <= 0.0)
        XMLobj.WriteValue(1);
      else if (SAP_Module.Calculation2012.Calculation.SAP_rating_11a.SAPRating == 0.0)
        XMLobj.WriteValue(SAP_Module.Calculation2012.Calculation.SAP_rating_11b.SAPRating);
      else
        XMLobj.WriteValue(SAP_Module.Calculation2012.Calculation.SAP_rating_11a.SAPRating);
      XMLobj.WriteEndElement();
      XMLobj.WriteStartElement("Energy-Rating-Potential");
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
        XMLobj.WriteStartElement("Environmental-Impact-Average");
        XMLobj.WriteValue("59");
        XMLobj.WriteEndElement();
      }
      XMLobj.WriteStartElement("Environmental-Impact-Current");
      if (SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.EIRating <= 0.0 & SAP_Module.Calculation2012.Calculation.CO2_Emissions_12a.EIValue <= 0.0)
        XMLobj.WriteValue(1);
      else if (SAP_Module.Calculation2012.Calculation.CO2_Emissions_12a.EIValue == 0.0)
        XMLobj.WriteValue(Math.Round(SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.EIRating, 0));
      else
        XMLobj.WriteValue(Math.Round(SAP_Module.Calculation2012.Calculation.CO2_Emissions_12a.EIValue, 0));
      XMLobj.WriteEndElement();
      XMLobj.WriteStartElement("Environmental-Impact-Potential");
      if (SAP_Module.CalculationImprove2012.Calculation.CO2_Emissions_12a.EIValue <= 0.0 & SAP_Module.CalculationImprove2012.Calculation.CO2_Emissions_12b.EIRating <= 0.0)
        XMLobj.WriteValue(1);
      else if (SAP_Module.CalculationImprove2012.Calculation.CO2_Emissions_12a.EIValue == 0.0)
        XMLobj.WriteValue(Math.Round(SAP_Module.CalculationImprove2012.Calculation.CO2_Emissions_12b.EIRating, 0));
      else
        XMLobj.WriteValue(Math.Round(SAP_Module.CalculationImprove2012.Calculation.CO2_Emissions_12a.EIValue, 0));
      XMLobj.WriteEndElement();
      XMLobj.WriteStartElement("Energy-Consumption-Current");
      if (SAP_Module.Calculation2012Regional.Calculation.Primary_Energy_13a.Box273 == 0.0)
        XMLobj.WriteValue(Math.Round(SAP_Module.Calculation2012Regional.Calculation.Primary_Energy_13b.Box383 / SAP_Module.Calculation2012Regional.Calculation.Dimensions.Box4, 0));
      else
        XMLobj.WriteValue(Math.Round(SAP_Module.Calculation2012Regional.Calculation.Primary_Energy_13a.Box273, 0));
      XMLobj.WriteEndElement();
      XMLobj.WriteStartElement("Energy-Consumption-Potential");
      if (SAP_Module.Calculation2012Regional.Calculation.Primary_Energy_13a.Box273 != 0.0)
        XMLobj.WriteValue(Math.Round(SAP_Module.CalculationImprove2012Regional.Calculation.Primary_Energy_13a.Box273, 0));
      else
        XMLobj.WriteValue(Math.Round(SAP_Module.CalculationImprove2012Regional.Calculation.Primary_Energy_13b.Box383 / SAP_Module.Calculation2012.Calculation.Dimensions.Box4, 0));
      XMLobj.WriteEndElement();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Address.Country, "Scotland", false) == 0)
      {
        XMLobj.WriteStartElement("Energy-Delivered-Current");
        if (SAP_Module.Calculation2012Regional.Calculation.Primary_Energy_13a.Box273 != 0.0)
          XMLobj.WriteValue(Math.Round((SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9a.Box211 + SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9a.Box213 + SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9a.Box215 + SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9a.Box219 + SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9a.Box230a + SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9a.Box230b + SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9a.Box230c + SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9a.Box230d + SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9a.Box230e + SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9a.Box231 + SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9a.Box232 + SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9a.Box233 + SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9a.Box234 + SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9a.Box235) / SAP_Module.Calculation2012Regional.Calculation.Dimensions.Box4, 0));
        else
          XMLobj.WriteValue(Math.Round((SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9b.Box307a + SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9b.Box307b + SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9b.Box307c + SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9b.Box307d + SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9b.Box307e + SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9b.Box309 + SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9b.Box310a + SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9b.Box310b + SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9b.Box310c + SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9b.Box310d + SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9b.Box310e + SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9b.Box310aW + SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9b.Box310bW + SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9b.Box310cW + SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9b.Box310dW + SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9b.Box310eW + SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9b.Box312 + SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9b.Box315 + SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9b.Box331 + SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9b.Box332 + SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9b.Box333 + SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9b.Box334) / SAP_Module.Calculation2012Regional.Calculation.Dimensions.Box4, 0));
        XMLobj.WriteEndElement();
      }
      XMLobj.WriteStartElement("CO2-Emissions-Current");
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
      XMLobj.WriteStartElement("CO2-Emissions-Potential");
      if (this.carbonEmm2 > 10.0)
        XMLobj.WriteValue(Math.Round(this.carbonEmm2, 0));
      else
        XMLobj.WriteValue(Microsoft.VisualBasic.Strings.Format((object) this.carbonEmm2, "0.0"));
      XMLobj.WriteEndElement();
      XMLobj.WriteStartElement("CO2-Emissions-Current-Per-Floor-Area");
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
      XMLobj.WriteStartElement("Lighting-Cost-Current");
      XMLobj.WriteStartAttribute("currency");
      XMLobj.WriteValue("GBP");
      XMLobj.WriteEndAttribute();
      if (SAP_Module.Calculation2012.Calculation.Actual_costs_10a.Box250 != 0.0)
        XMLobj.WriteValue(Math.Round(SAP_Module.Calculation2012Regional.Calculation.Actual_costs_10a.Box250, 0));
      else
        XMLobj.WriteValue(Math.Round(SAP_Module.Calculation2012Regional.Calculation.Actual_costs_10b.Box350, 0));
      XMLobj.WriteEndElement();
      XMLobj.WriteStartElement("Lighting-Cost-Potential");
      XMLobj.WriteStartAttribute("currency");
      XMLobj.WriteValue("GBP");
      XMLobj.WriteEndAttribute();
      if (SAP_Module.Calculation2012Regional.Calculation.Actual_costs_10a.Box250 != 0.0)
        XMLobj.WriteValue(Math.Round(SAP_Module.CalculationImprove2012.Calculation.Actual_costs_10a.Box250, 0));
      else
        XMLobj.WriteValue(Math.Round(SAP_Module.CalculationImprove2012.Calculation.Actual_costs_10b.Box350, 0));
      XMLobj.WriteEndElement();
      XMLobj.WriteStartElement("Heating-Cost-Current");
      XMLobj.WriteStartAttribute("currency");
      XMLobj.WriteValue("GBP");
      XMLobj.WriteEndAttribute();
      if (Math.Round(SAP_Module.Calculation2012Regional.Calculation.Actual_costs_10a.Box240 + SAP_Module.Calculation2012Regional.Calculation.Actual_costs_10a.Box241 + SAP_Module.Calculation2012Regional.Calculation.Actual_costs_10a.Box242 + SAP_Module.Calculation2012Regional.Calculation.Actual_costs_10a.Box249 + SAP_Module.Calculation2012Regional.Calculation.Actual_costs_10a.Box251, 0) != 0.0)
        XMLobj.WriteValue(Math.Round(SAP_Module.Calculation2012Regional.Calculation.Actual_costs_10a.Box240 + SAP_Module.Calculation2012Regional.Calculation.Actual_costs_10a.Box241 + SAP_Module.Calculation2012Regional.Calculation.Actual_costs_10a.Box242 + SAP_Module.Calculation2012Regional.Calculation.Actual_costs_10a.Box249 + SAP_Module.Calculation2012Regional.Calculation.Actual_costs_10a.Box251, 0));
      else
        XMLobj.WriteValue(Math.Round(SAP_Module.Calculation2012Regional.Calculation.Actual_costs_10b.Box340a + SAP_Module.Calculation2012Regional.Calculation.Actual_costs_10b.Box340b + SAP_Module.Calculation2012Regional.Calculation.Actual_costs_10b.Box340c + SAP_Module.Calculation2012Regional.Calculation.Actual_costs_10b.Box340d + SAP_Module.Calculation2012Regional.Calculation.Actual_costs_10b.Box340e + SAP_Module.Calculation2012Regional.Calculation.Actual_costs_10b.Box341 + SAP_Module.Calculation2012Regional.Calculation.Actual_costs_10b.Box349 + SAP_Module.Calculation2012.Calculation.Actual_costs_10b.Box351, 0));
      XMLobj.WriteEndElement();
      XMLobj.WriteStartElement("Heating-Cost-Potential");
      XMLobj.WriteStartAttribute("currency");
      XMLobj.WriteValue("GBP");
      XMLobj.WriteEndAttribute();
      if (Math.Round(SAP_Module.Calculation2012Regional.Calculation.Actual_costs_10a.Box240 + SAP_Module.Calculation2012.Calculation.Actual_costs_10a.Box241 + SAP_Module.Calculation2012.Calculation.Actual_costs_10a.Box242 + SAP_Module.Calculation2012.Calculation.Actual_costs_10a.Box249 + SAP_Module.Calculation2012.Calculation.Actual_costs_10a.Box251, 0) != 0.0)
        XMLobj.WriteValue(Microsoft.VisualBasic.Strings.Format((object) Math.Round(SAP_Module.CalculationImprove2012Regional.Calculation.Actual_costs_10a.Box240 + SAP_Module.CalculationImprove2012Regional.Calculation.Actual_costs_10a.Box241 + SAP_Module.CalculationImprove2012Regional.Calculation.Actual_costs_10a.Box242 + SAP_Module.CalculationImprove2012Regional.Calculation.Actual_costs_10a.Box249 - SAP_Module.CalculationImprove2012Regional.Calculation.Actual_costs_10a.Box249Water + SAP_Module.CalculationImprove2012Regional.Calculation.Actual_costs_10a.Box251, 0), "####"));
      else
        XMLobj.WriteValue(Microsoft.VisualBasic.Strings.Format((object) Math.Round(SAP_Module.CalculationImprove2012Regional.Calculation.Actual_costs_10b.Box340a + SAP_Module.CalculationImprove2012Regional.Calculation.Actual_costs_10b.Box340b + SAP_Module.CalculationImprove2012Regional.Calculation.Actual_costs_10b.Box340c + SAP_Module.CalculationImprove2012Regional.Calculation.Actual_costs_10b.Box340d + SAP_Module.CalculationImprove2012Regional.Calculation.Actual_costs_10b.Box340e + SAP_Module.CalculationImprove2012Regional.Calculation.Actual_costs_10b.Box341 + SAP_Module.CalculationImprove2012Regional.Calculation.Actual_costs_10b.Box349 + SAP_Module.CalculationImprove2012Regional.Calculation.Actual_costs_10b.Box351, 0), "####"));
      XMLobj.WriteEndElement();
      XMLobj.WriteStartElement("Hot-Water-Cost-Current");
      XMLobj.WriteStartAttribute("currency");
      XMLobj.WriteValue("GBP");
      XMLobj.WriteEndAttribute();
      if (SAP_Module.Calculation2012Regional.Calculation.Actual_costs_10a.Box245 + SAP_Module.Calculation2012Regional.Calculation.Actual_costs_10a.Box246 + SAP_Module.Calculation2012Regional.Calculation.Actual_costs_10a.Box247 + SAP_Module.Calculation2012Regional.Calculation.Actual_costs_10a.Box247Imm != 0.0)
        XMLobj.WriteValue(Math.Round(SAP_Module.Calculation2012Regional.Calculation.Actual_costs_10a.Box245 + SAP_Module.Calculation2012Regional.Calculation.Actual_costs_10a.Box246 + SAP_Module.Calculation2012Regional.Calculation.Actual_costs_10a.Box247 + SAP_Module.Calculation2012Regional.Calculation.Actual_costs_10a.Box247Imm, 0));
      else
        XMLobj.WriteValue(Math.Round(SAP_Module.Calculation2012Regional.Calculation.Actual_costs_10b.Box342e + SAP_Module.Calculation2012Regional.Calculation.Actual_costs_10b.Box342d + SAP_Module.Calculation2012Regional.Calculation.Actual_costs_10b.Box342c + SAP_Module.Calculation2012Regional.Calculation.Actual_costs_10b.Box342b + SAP_Module.Calculation2012.Calculation.Actual_costs_10b.Box342a, 0));
      XMLobj.WriteEndElement();
      XMLobj.WriteStartElement("Hot-Water-Cost-Potential");
      XMLobj.WriteStartAttribute("currency");
      XMLobj.WriteValue("GBP");
      XMLobj.WriteEndAttribute();
      if (SAP_Module.Calculation2012Regional.Calculation.Actual_costs_10a.Box245 + SAP_Module.Calculation2012Regional.Calculation.Actual_costs_10a.Box246 + SAP_Module.Calculation2012Regional.Calculation.Actual_costs_10a.Box247 + SAP_Module.Calculation2012Regional.Calculation.Actual_costs_10a.Box247Imm != 0.0)
        XMLobj.WriteValue(Math.Round(SAP_Module.CalculationImprove2012Regional.Calculation.Actual_costs_10a.Box245 + SAP_Module.CalculationImprove2012Regional.Calculation.Actual_costs_10a.Box246 + SAP_Module.CalculationImprove2012Regional.Calculation.Actual_costs_10a.Box247 + SAP_Module.CalculationImprove2012Regional.Calculation.Actual_costs_10a.Box247Imm + SAP_Module.CalculationImprove2012Regional.Calculation.Actual_costs_10a.Box249Water, 0));
      else
        XMLobj.WriteValue(Math.Round(SAP_Module.CalculationImprove2012Regional.Calculation.Actual_costs_10b.Box342e + SAP_Module.CalculationImprove2012Regional.Calculation.Actual_costs_10b.Box342d + SAP_Module.CalculationImprove2012Regional.Calculation.Actual_costs_10b.Box342c + SAP_Module.CalculationImprove2012Regional.Calculation.Actual_costs_10b.Box342b + SAP_Module.CalculationImprove2012Regional.Calculation.Actual_costs_10b.Box342a, 0));
      XMLobj.WriteEndElement();
      XMLobj.WriteEndElement();
    }

    private void _EnergyAssessment_SuggestedImprovements(
      XmlTextWriter XMLobj,
      int House,
      int Country)
    {
      int num1;
      if (SAP_Module.Improve.LowerCost.E.Include)
      {
        int num2;
        num1 = checked (num2 + 1);
      }
      if (SAP_Module.Improve.Further.N.Include)
        checked { ++num1; }
      if (SAP_Module.Improve.Further.U.Include)
        checked { ++num1; }
      if (SAP_Module.Improve.Further.V.Include)
        checked { ++num1; }
      if ((uint) num1 <= 0U)
        return;
      XMLobj.WriteStartElement("Suggested-Improvements");
      int num3 = 1;
      if (SAP_Module.Improve.LowerCost.E.Include)
      {
        XMLobj.WriteStartElement("Improvement");
        XMLobj.WriteStartElement("Sequence");
        XMLobj.WriteValue(num3);
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("Improvement-Category");
        XMLobj.WriteValue(5);
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("Green-Deal-Category");
        XMLobj.WriteValue("NI");
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("Improvement-Type");
        XMLobj.WriteValue("E");
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("Improvement-Details");
        XMLobj.WriteStartElement("Improvement-Number");
        XMLobj.WriteValue(35);
        XMLobj.WriteEndElement();
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("Typical-Saving");
        XMLobj.WriteStartAttribute("currency");
        XMLobj.WriteValue("GBP");
        XMLobj.WriteEndAttribute();
        XMLobj.WriteValue(Math.Round(Math.Abs(SAP_Module.Improve.LowerCost.E.CostChange), 0));
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("Indicative-Cost");
        XMLobj.WriteValue("£" + Conversions.ToString(Conversions.ToDouble(SAP_Module.Improve.LowerCost.E.GreenDeal.IndicativeCost) * (double) checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].LELOutlets - SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].LELLights)));
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("Energy-Performance-Rating");
        XMLobj.WriteValue(SAP_Module.Improve.LowerCost.E.Energy.Substring(2, checked (SAP_Module.Improve.LowerCost.E.Energy.Length - 2)));
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("Environmental-Impact-Rating");
        XMLobj.WriteValue(SAP_Module.Improve.LowerCost.E.Environ.Substring(2, checked (SAP_Module.Improve.LowerCost.E.Environ.Length - 2)));
        XMLobj.WriteEndElement();
        XMLobj.WriteEndElement();
        checked { ++num3; }
      }
      if (SAP_Module.Improve.Further.N.Include)
      {
        XMLobj.WriteStartElement("Improvement");
        XMLobj.WriteStartElement("Sequence");
        XMLobj.WriteValue(num3);
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("Improvement-Category");
        XMLobj.WriteValue(5);
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("Green-Deal-Category");
        XMLobj.WriteValue("NI");
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("Improvement-Type");
        XMLobj.WriteValue("N");
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("Improvement-Details");
        XMLobj.WriteStartElement("Improvement-Number");
        XMLobj.WriteValue(19);
        XMLobj.WriteEndElement();
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("Typical-Saving");
        XMLobj.WriteStartAttribute("currency");
        XMLobj.WriteValue("GBP");
        XMLobj.WriteEndAttribute();
        XMLobj.WriteValue(Math.Round(Math.Abs(SAP_Module.Improve.Further.N.CostChange), 0));
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("Indicative-Cost");
        XMLobj.WriteValue(SAP_Module.Improve.Further.N.GreenDeal.IndicativeCost);
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("Energy-Performance-Rating");
        XMLobj.WriteValue(SAP_Module.Improve.Further.N.Energy.Substring(2, checked (SAP_Module.Improve.Further.N.Energy.Length - 2)));
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("Environmental-Impact-Rating");
        XMLobj.WriteValue(SAP_Module.Improve.Further.N.Environ.Substring(2, checked (SAP_Module.Improve.Further.N.Environ.Length - 2)));
        XMLobj.WriteEndElement();
        XMLobj.WriteEndElement();
        checked { ++num3; }
      }
      if (SAP_Module.Improve.Further.U.Include)
      {
        XMLobj.WriteStartElement("Improvement");
        XMLobj.WriteStartElement("Sequence");
        XMLobj.WriteValue(num3);
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("Improvement-Category");
        XMLobj.WriteValue(5);
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("Green-Deal-Category");
        XMLobj.WriteValue("NI");
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("Improvement-Type");
        XMLobj.WriteValue("U");
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("Improvement-Details");
        XMLobj.WriteStartElement("Improvement-Number");
        XMLobj.WriteValue(34);
        XMLobj.WriteEndElement();
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("Typical-Saving");
        XMLobj.WriteStartAttribute("currency");
        XMLobj.WriteValue("GBP");
        XMLobj.WriteEndAttribute();
        XMLobj.WriteValue(Math.Round(Math.Abs(SAP_Module.Improve.Further.U.CostChange), 0));
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("Indicative-Cost");
        XMLobj.WriteValue(SAP_Module.Improve.Further.U.GreenDeal.IndicativeCost);
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("Energy-Performance-Rating");
        XMLobj.WriteValue(SAP_Module.Improve.Further.U.Energy.Substring(2, checked (SAP_Module.Improve.Further.U.Energy.Length - 2)));
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("Environmental-Impact-Rating");
        XMLobj.WriteValue(SAP_Module.Improve.Further.U.Environ.Substring(2, checked (SAP_Module.Improve.Further.U.Environ.Length - 2)));
        XMLobj.WriteEndElement();
        XMLobj.WriteEndElement();
        checked { ++num3; }
      }
      if (SAP_Module.Improve.Further.V2.Include)
      {
        XMLobj.WriteStartElement("Improvement");
        XMLobj.WriteStartElement("Sequence");
        XMLobj.WriteValue(num3);
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("Improvement-Category");
        XMLobj.WriteValue(5);
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("Green-Deal-Category");
        XMLobj.WriteValue("NI");
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("Improvement-Type");
        XMLobj.WriteValue("V2");
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("Improvement-Details");
        XMLobj.WriteStartElement("Improvement-Number");
        XMLobj.WriteValue(44);
        XMLobj.WriteEndElement();
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("Typical-Saving");
        XMLobj.WriteStartAttribute("currency");
        XMLobj.WriteValue("GBP");
        XMLobj.WriteEndAttribute();
        XMLobj.WriteValue(Math.Round(Math.Abs(SAP_Module.Improve.Further.V2.CostChange), 0));
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("Indicative-Cost");
        XMLobj.WriteValue(SAP_Module.Improve.Further.V2.GreenDeal.IndicativeCost);
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("Energy-Performance-Rating");
        XMLobj.WriteValue(SAP_Module.Improve.Further.V2.Energy.Substring(2, checked (SAP_Module.Improve.Further.V2.Energy.Length - 2)));
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("Environmental-Impact-Rating");
        XMLobj.WriteValue(SAP_Module.Improve.Further.V2.Environ.Substring(2, checked (SAP_Module.Improve.Further.V2.Environ.Length - 2)));
        XMLobj.WriteEndElement();
        XMLobj.WriteEndElement();
        int num4 = checked (num3 + 1);
      }
      XMLobj.WriteEndElement();
    }

    private void _EnergyAssessment_Energy_Sorces(XmlTextWriter XMLobj, int House, int Country)
    {
      string[] arySrc = new string[1];
      XML2012.LZCSection lzcSection = new XML2012.LZCSection();
      if (SAP_Module.Proj.Dwellings[House].MainHeating.Fuel.Contains("wood"))
      {
        int sapTableCode = SAP_Module.Proj.Dwellings[House].MainHeating.SAPTableCode;
        if (sapTableCode < 310 || sapTableCode > 315)
        {
          arySrc[lzcSection.Count] = Conversions.ToString(1);
          lzcSection.Count = 1;
          arySrc = (string[]) Utils.CopyArray((Array) arySrc, (Array) new string[checked (lzcSection.Count + 1)]);
          lzcSection.Include = true;
        }
      }
      bool flag1;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.CommunityH.Boiler2CHPFuel, (string) null, false) == 0)
        flag1 = false;
      else if (SAP_Module.Proj.Dwellings[House].MainHeating.CommunityH.Boiler2CHPFuel.Contains("iomass"))
        flag1 = true;
      if (SAP_Module.Proj.Dwellings[House].MainHeating.Fuel.Contains("iomass") | flag1 | SAP_Module.Proj.Dwellings[House].Water.Fuel.Contains("iomass"))
      {
        int sapTableCode = SAP_Module.Proj.Dwellings[House].MainHeating.SAPTableCode;
        if (sapTableCode >= 308 && sapTableCode <= 310)
        {
          arySrc[lzcSection.Count] = Conversions.ToString(2);
          lzcSection.Count = 1;
          arySrc = (string[]) Utils.CopyArray((Array) arySrc, (Array) new string[checked (lzcSection.Count + 1)]);
          lzcSection.Include = true;
        }
        else if (sapTableCode == 306 || sapTableCode == 307)
        {
          arySrc[lzcSection.Count] = Conversions.ToString(3);
          lzcSection.Count = 1;
          arySrc = (string[]) Utils.CopyArray((Array) arySrc, (Array) new string[checked (lzcSection.Count + 1)]);
          lzcSection.Include = true;
        }
        else
        {
          arySrc[lzcSection.Count] = Conversions.ToString(3);
          lzcSection.Count = 1;
          arySrc = (string[]) Utils.CopyArray((Array) arySrc, (Array) new string[checked (lzcSection.Count + 1)]);
          lzcSection.Include = true;
        }
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].SecHeating.Fuel, (string) null, false) == 0)
        SAP_Module.Proj.Dwellings[House].SecHeating.Fuel = "";
      if (SAP_Module.Proj.Dwellings[House].SecHeating.Fuel.Contains("wood") & !SAP_Module.Proj.Dwellings[House].SecHeating.Fuel.Contains("dual"))
      {
        arySrc[lzcSection.Count] = Conversions.ToString(4);
        lzcSection.Count = 1;
        arySrc = (string[]) Utils.CopyArray((Array) arySrc, (Array) new string[checked (lzcSection.Count + 1)]);
        lzcSection.Include = true;
      }
      if (this.exhaust_air)
      {
        arySrc[lzcSection.Count] = Conversions.ToString(16);
        lzcSection.Count = 1;
        arySrc = (string[]) Utils.CopyArray((Array) arySrc, (Array) new string[checked (lzcSection.Count + 1)]);
        lzcSection.Include = true;
      }
      if (this.combine_heat)
      {
        arySrc[lzcSection.Count] = Conversions.ToString(6);
        lzcSection.Count = 1;
        arySrc = (string[]) Utils.CopyArray((Array) arySrc, (Array) new string[checked (lzcSection.Count + 1)]);
        lzcSection.Include = true;
      }
      if (this.geothermal_heat)
      {
        arySrc[lzcSection.Count] = Conversions.ToString(5);
        lzcSection.Count = 1;
        arySrc = (string[]) Utils.CopyArray((Array) arySrc, (Array) new string[checked (lzcSection.Count + 1)]);
        lzcSection.Include = true;
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.SGroup, "Micro-cogeneration (micro-CHP)", false) == 0 | SAP_Module.Proj.Dwellings[House].Water.SystemRef == 951)
      {
        arySrc[lzcSection.Count] = Conversions.ToString(15);
        lzcSection.Count = 1;
        arySrc = (string[]) Utils.CopyArray((Array) arySrc, (Array) new string[checked (lzcSection.Count + 1)]);
        lzcSection.Include = true;
      }
      else
      {
        switch (SAP_Module.Proj.Dwellings[House].MainHeating.SAPTableCode)
        {
          case 201:
          case 202:
          case 205:
          case 521:
          case 525:
            arySrc[lzcSection.Count] = Conversions.ToString(7);
            lzcSection.Count = 1;
            arySrc = (string[]) Utils.CopyArray((Array) arySrc, (Array) new string[checked (lzcSection.Count + 1)]);
            lzcSection.Include = true;
            break;
          case 204:
          case 207:
          case 214:
          case 217:
          case 224:
          case 227:
          case 524:
          case 527:
            arySrc[lzcSection.Count] = Conversions.ToString(9);
            lzcSection.Count = 1;
            arySrc = (string[]) Utils.CopyArray((Array) arySrc, (Array) new string[checked (lzcSection.Count + 1)]);
            lzcSection.Include = true;
            break;
          case 211:
          case 215:
          case 221:
          case 225:
            arySrc[lzcSection.Count] = Conversions.ToString(7);
            lzcSection.Count = 1;
            arySrc = (string[]) Utils.CopyArray((Array) arySrc, (Array) new string[checked (lzcSection.Count + 1)]);
            lzcSection.Include = true;
            break;
          case 213:
          case 216:
          case 223:
          case 226:
          case 523:
          case 526:
            arySrc[lzcSection.Count] = Conversions.ToString(8);
            lzcSection.Count = 1;
            arySrc = (string[]) Utils.CopyArray((Array) arySrc, (Array) new string[checked (lzcSection.Count + 1)]);
            lzcSection.Include = true;
            break;
          case 307:
            arySrc[lzcSection.Count] = Conversions.ToString(6);
            lzcSection.Count = 1;
            arySrc = (string[]) Utils.CopyArray((Array) arySrc, (Array) new string[checked (lzcSection.Count + 1)]);
            lzcSection.Include = true;
            break;
          case 310:
            arySrc[lzcSection.Count] = Conversions.ToString(5);
            lzcSection.Count = 1;
            arySrc = (string[]) Utils.CopyArray((Array) arySrc, (Array) new string[checked (lzcSection.Count + 1)]);
            lzcSection.Include = true;
            break;
          default:
            bool flag2;
            if (this.ground_source)
            {
              arySrc[lzcSection.Count] = Conversions.ToString(7);
              lzcSection.Count = 1;
              arySrc = (string[]) Utils.CopyArray((Array) arySrc, (Array) new string[checked (lzcSection.Count + 1)]);
              lzcSection.Include = true;
              flag2 = true;
            }
            bool flag3;
            if (flag3 & !flag2)
            {
              arySrc[lzcSection.Count] = Conversions.ToString(9);
              lzcSection.Count = 1;
              arySrc = (string[]) Utils.CopyArray((Array) arySrc, (Array) new string[checked (lzcSection.Count + 1)]);
              lzcSection.Include = true;
            }
            if (SAP_Module.Proj.Dwellings[House].Renewable.AAEGeneration.Inlcude)
            {
              arySrc[lzcSection.Count] = Conversions.ToString(14);
              lzcSection.Count = 1;
              arySrc = (string[]) Utils.CopyArray((Array) arySrc, (Array) new string[checked (lzcSection.Count + 1)]);
              lzcSection.Include = true;
              break;
            }
            break;
        }
      }
      if (SAP_Module.Proj.Dwellings[House].Water.Solar.Inlcude)
      {
        arySrc[lzcSection.Count] = Conversions.ToString(10);
        lzcSection.Count = 1;
        arySrc = (string[]) Utils.CopyArray((Array) arySrc, (Array) new string[checked (lzcSection.Count + 1)]);
        lzcSection.Include = true;
      }
      if (SAP_Module.Proj.Dwellings[House].Renewable.Photovoltaic.Inlcude)
      {
        arySrc[lzcSection.Count] = Conversions.ToString(11);
        lzcSection.Count = 1;
        arySrc = (string[]) Utils.CopyArray((Array) arySrc, (Array) new string[checked (lzcSection.Count + 1)]);
        lzcSection.Include = true;
      }
      if (SAP_Module.Proj.Dwellings[House].Renewable.WindTurbine.Inlcude)
      {
        arySrc[lzcSection.Count] = Conversions.ToString(12);
        lzcSection.Count = 1;
        arySrc = (string[]) Utils.CopyArray((Array) arySrc, (Array) new string[checked (lzcSection.Count + 1)]);
        lzcSection.Include = true;
      }
      if (SAP_Module.Proj.Dwellings[House].MainHeating.SAPTableCode == 309)
      {
        arySrc[lzcSection.Count] = Conversions.ToString(13);
        lzcSection.Count = 1;
        arySrc = (string[]) Utils.CopyArray((Array) arySrc, (Array) new string[checked (lzcSection.Count + 1)]);
        lzcSection.Include = true;
      }
      if (!lzcSection.Include)
        return;
      XMLobj.WriteStartElement("LZC-Energy-Sources");
      int num = checked (arySrc.Length - 1);
      int index = 0;
      while (index <= num)
      {
        if (arySrc[index] != null)
        {
          XMLobj.WriteStartElement("LZC-Energy-Source");
          XMLobj.WriteValue(arySrc[index]);
          XMLobj.WriteEndElement();
        }
        checked { ++index; }
      }
      XMLobj.WriteEndElement();
    }

    private void _EnergyAssessment_Renewable_Heat_Incentive(
      XmlTextWriter XMLobj,
      int House,
      int Country)
    {
      Calc2012 calc2012 = new Calc2012();
      SAP_Module.Dwelling dwelling1 = new SAP_Module.Dwelling();
      SAP_Module.Dwelling dwelling2 = Functions.CopyDwelling(SAP_Module.Proj.Dwellings[House]);
      dwelling2.Water.Solar.Inlcude = false;
      dwelling2.Water.FGHRS.Include = false;
      dwelling2.Water.WWHRS.Include = false;
      try
      {
        calc2012.IsHeatDemand = true;
        calc2012.IsForRhiCalc = true;
        calc2012.Dwelling = dwelling2;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      XMLobj.WriteStartElement("Renewable-Heat-Incentive");
      if (SAP_Module.Proj.Dwellings[House].Status.Equals("Existing dwelling (SAP)") | SAP_Module.Proj.Dwellings[House].Status.Equals("New extension to existing dwelling"))
      {
        XMLobj.WriteStartElement("RHI-Existing-Dwelling");
        XMLobj.WriteStartElement("Space-Heating-Existing-Dwelling");
        XMLobj.WriteValue(Microsoft.VisualBasic.Strings.Format((object) Math.Round(calc2012.Calculation.Space_heating_requirement.Box98, 0), "####"));
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("Water-Heating");
        XMLobj.WriteValue(Microsoft.VisualBasic.Strings.Format((object) Math.Round(calc2012.Calculation.Water_heating.Box64 + calc2012.Calculation.Water_heating.Box64Imm, 0), "####"));
        XMLobj.WriteEndElement();
        XMLobj.WriteEndElement();
      }
      else
      {
        XMLobj.WriteStartElement("RHI-New-Dwelling");
        XMLobj.WriteStartElement("Space-Heating");
        if (Math.Round(calc2012.Calculation.Space_heating_requirement.Box98, 0) == 0.0)
          XMLobj.WriteValue(1);
        else
          XMLobj.WriteValue(Microsoft.VisualBasic.Strings.Format((object) Math.Round(calc2012.Calculation.Space_heating_requirement.Box98, 0), "####"));
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("Water-Heating");
        XMLobj.WriteValue(Microsoft.VisualBasic.Strings.Format((object) Math.Round(calc2012.Calculation.Water_heating.Box64 + calc2012.Calculation.Water_heating.Box64Imm, 0), "####"));
        XMLobj.WriteEndElement();
        XMLobj.WriteEndElement();
      }
      XMLobj.WriteEndElement();
    }

    private void _SAP09Data_DataType(XmlTextWriter XMLobj, int House, int Country)
    {
      XMLobj.WriteStartElement("SAP2012-Data");
      XMLobj.WriteStartElement("Data-Type");
      string status = SAP_Module.Proj.Dwellings[House].Status;
      // ISSUE: reference to a compiler-generated method
      switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(status))
      {
        case 474629829:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(status, "New dwelling design stage", false) == 0)
          {
            XMLobj.WriteValue("1");
            goto default;
          }
          else
            goto default;
        case 2124250502:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(status, "New extension to existing dwelling", false) == 0)
            break;
          goto default;
        case 2282162442:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(status, "New dwelling created by change of use", false) == 0)
            goto label_12;
          else
            goto default;
        case 2887295594:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(status, "new dwelling created by change of use", false) == 0)
            goto label_12;
          else
            goto default;
        case 3242632573:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(status, "New dwelling as built", false) == 0)
          {
            XMLobj.WriteValue("2");
            goto default;
          }
          else
            goto default;
        case 3363671541:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(status, "other", false) == 0)
          {
            XMLobj.WriteValue("6");
            goto default;
          }
          else
            goto default;
        case 4000587366:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(status, "new extension to existing dwelling", false) == 0)
            break;
          goto default;
        case 4068971131:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(status, "Existing dwelling (SAP)", false) == 0)
          {
            XMLobj.WriteValue("5");
            goto default;
          }
          else
            goto default;
        default:
label_15:
          XMLobj.WriteEndElement();
          return;
      }
      XMLobj.WriteValue("3");
      goto label_15;
label_12:
      XMLobj.WriteValue("4");
      goto label_15;
    }

    private void _SAP09Data_SchemaVersion(XmlTextWriter XMLobj, int House, int Country)
    {
    }

    private void _SAP09Data_SpecialFeature(XmlTextWriter XMLobj, int House, int Country)
    {
      if (!SAP_Module.Proj.Dwellings[House].Renewable.Special.Include)
        return;
      XMLobj.WriteStartElement("SAP-Special-Features");
      int num = checked (SAP_Module.Proj.Dwellings[House].Renewable.Special.Special.Length - 1);
      int index = 0;
      while (index <= num)
      {
        XMLobj.WriteStartElement("SAP-Special-Feature");
        XMLobj.WriteStartElement("Description");
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Renewable.Special.Special[index].Description);
        XMLobj.WriteEndElement();
        if (SAP_Module.Proj.Dwellings[House].Renewable.Special.Special[index].MakeEmissionsOnly)
          XMLobj.WriteStartElement("Emissions-Feature");
        else
          XMLobj.WriteStartElement("Energy-Feature");
        if (SAP_Module.Proj.Dwellings[House].Renewable.Special.Special[index].MakeEmissionsOnly)
        {
          XMLobj.WriteStartElement("Emissions-Saved");
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Renewable.Special.Special[index].EmissionsAmount);
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("Emissions-Created");
          XMLobj.WriteValue(this.FuelCheck(Conversions.ToString(SAP_Module.Proj.Dwellings[House].Renewable.Special.Special[index].EmissionsAmountCreated), House));
          XMLobj.WriteEndElement();
        }
        else
        {
          XMLobj.WriteStartElement("Energy-Saved-Or-Generated");
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Renewable.Special.Special[index].EnergySaved);
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("Saved-Or-Generated-Fuel");
          XMLobj.WriteValue(this.FuelCheck(SAP_Module.Proj.Dwellings[House].Renewable.Special.Special[index].FuelSaved, House));
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("Energy-Used");
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Renewable.Special.Special[index].EnergyUsed);
          XMLobj.WriteEndElement();
          if ((double) SAP_Module.Proj.Dwellings[House].Renewable.Special.Special[index].EnergyUsed > 0.0)
          {
            XMLobj.WriteStartElement("Energy-Used-Fuel");
            XMLobj.WriteValue(this.FuelCheck(SAP_Module.Proj.Dwellings[House].Renewable.Special.Special[index].FuelUsed, House));
            XMLobj.WriteEndElement();
          }
        }
        if (SAP_Module.Proj.Dwellings[House].Renewable.Special.Special[index].IncludeMonthly)
        {
          XMLobj.WriteStartElement("Air-Change-Rates");
          XMLobj.WriteStartElement("Air-Change-Rate");
          XMLobj.WriteStartElement("Air-Change-Rate-Month");
          XMLobj.WriteValue("Jan");
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("Air-Change-Rate-Value");
          XMLobj.WriteValue(Math.Round((double) SAP_Module.Proj.Dwellings[House].Renewable.Special.Special[index].M1, 2));
          XMLobj.WriteEndElement();
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("Air-Change-Rate");
          XMLobj.WriteStartElement("Air-Change-Rate-Month");
          XMLobj.WriteValue("Feb");
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("Air-Change-Rate-Value");
          XMLobj.WriteValue(Math.Round((double) SAP_Module.Proj.Dwellings[House].Renewable.Special.Special[index].M2, 2));
          XMLobj.WriteEndElement();
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("Air-Change-Rate");
          XMLobj.WriteStartElement("Air-Change-Rate-Month");
          XMLobj.WriteValue("Mar");
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("Air-Change-Rate-Value");
          XMLobj.WriteValue(Math.Round((double) SAP_Module.Proj.Dwellings[House].Renewable.Special.Special[index].M3, 2));
          XMLobj.WriteEndElement();
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("Air-Change-Rate");
          XMLobj.WriteStartElement("Air-Change-Rate-Month");
          XMLobj.WriteValue("Apr");
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("Air-Change-Rate-Value");
          XMLobj.WriteValue(Math.Round((double) SAP_Module.Proj.Dwellings[House].Renewable.Special.Special[index].M4, 2));
          XMLobj.WriteEndElement();
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("Air-Change-Rate");
          XMLobj.WriteStartElement("Air-Change-Rate-Month");
          XMLobj.WriteValue("May");
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("Air-Change-Rate-Value");
          XMLobj.WriteValue(Math.Round((double) SAP_Module.Proj.Dwellings[House].Renewable.Special.Special[index].M5, 2));
          XMLobj.WriteEndElement();
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("Air-Change-Rate");
          XMLobj.WriteStartElement("Air-Change-Rate-Month");
          XMLobj.WriteValue("Jun");
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("Air-Change-Rate-Value");
          XMLobj.WriteValue(Math.Round((double) SAP_Module.Proj.Dwellings[House].Renewable.Special.Special[index].M6, 2));
          XMLobj.WriteEndElement();
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("Air-Change-Rate");
          XMLobj.WriteStartElement("Air-Change-Rate-Month");
          XMLobj.WriteValue("Jul");
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("Air-Change-Rate-Value");
          XMLobj.WriteValue(Math.Round((double) SAP_Module.Proj.Dwellings[House].Renewable.Special.Special[index].M7, 2));
          XMLobj.WriteEndElement();
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("Air-Change-Rate");
          XMLobj.WriteStartElement("Air-Change-Rate-Month");
          XMLobj.WriteValue("Aug");
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("Air-Change-Rate-Value");
          XMLobj.WriteValue(Math.Round((double) SAP_Module.Proj.Dwellings[House].Renewable.Special.Special[index].M8, 2));
          XMLobj.WriteEndElement();
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("Air-Change-Rate");
          XMLobj.WriteStartElement("Air-Change-Rate-Month");
          XMLobj.WriteValue("Sep");
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("Air-Change-Rate-Value");
          XMLobj.WriteValue(Math.Round((double) SAP_Module.Proj.Dwellings[House].Renewable.Special.Special[index].M9, 2));
          XMLobj.WriteEndElement();
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("Air-Change-Rate");
          XMLobj.WriteStartElement("Air-Change-Rate-Month");
          XMLobj.WriteValue("Oct");
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("Air-Change-Rate-Value");
          XMLobj.WriteValue(Math.Round((double) SAP_Module.Proj.Dwellings[House].Renewable.Special.Special[index].M10, 2));
          XMLobj.WriteEndElement();
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("Air-Change-Rate");
          XMLobj.WriteStartElement("Air-Change-Rate-Month");
          XMLobj.WriteValue("Nov");
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("Air-Change-Rate-Value");
          XMLobj.WriteValue(Math.Round((double) SAP_Module.Proj.Dwellings[House].Renewable.Special.Special[index].M11, 2));
          XMLobj.WriteEndElement();
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("Air-Change-Rate");
          XMLobj.WriteStartElement("Air-Change-Rate-Month");
          XMLobj.WriteValue("Dec");
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("Air-Change-Rate-Value");
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

    private void _SAP09DataPropertyDetails_propertyType(
      XmlTextWriter XMLobj,
      int House,
      int Country)
    {
      XMLobj.WriteStartElement("Property-Type");
      string propertyType = SAP_Module.Proj.Dwellings[House].PropertyType;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(propertyType, nameof (House), false) != 0)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(propertyType, "Bungalow", false) != 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(propertyType, "Flat", false) != 0)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(propertyType, "Maisonette", false) == 0)
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

    private void _SAP09DataPropertyDetails_BuitForm(XmlTextWriter XMLobj, int House, int Country)
    {
      XMLobj.WriteStartElement("Built-Form");
      string Left = Microsoft.VisualBasic.Strings.UCase(SAP_Module.Proj.Dwellings[House].BuildForm);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, Microsoft.VisualBasic.Strings.UCase("Detached"), false) == 0)
        XMLobj.WriteValue("1");
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, Microsoft.VisualBasic.Strings.UCase("Semi-Detached"), false) == 0)
        XMLobj.WriteValue("2");
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, Microsoft.VisualBasic.Strings.UCase("Mid-Terrace"), false) == 0)
        XMLobj.WriteValue("4");
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, Microsoft.VisualBasic.Strings.UCase("End-Terrace"), false) == 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, Microsoft.VisualBasic.Strings.UCase("End-terrace"), false) == 0)
        XMLobj.WriteValue("3");
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, Microsoft.VisualBasic.Strings.UCase("Enclosed End-Terrace"), false) == 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, Microsoft.VisualBasic.Strings.UCase("Enclosed end"), false) == 0)
        XMLobj.WriteValue("5");
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, Microsoft.VisualBasic.Strings.UCase("Enclosed Mid-Terrace"), false) == 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, Microsoft.VisualBasic.Strings.UCase("Enclosed mid"), false) == 0)
        XMLobj.WriteValue("6");
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, Microsoft.VisualBasic.Strings.UCase("Linked Detached"), false) == 0)
        XMLobj.WriteValue("7");
      else
        XMLobj.WriteValue("1");
      XMLobj.WriteEndElement();
    }

    private void _SAP09DataPropertyDetails_LivingArea(XmlTextWriter XMLobj, int House, int Country)
    {
      XMLobj.WriteStartElement("Living-Area");
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
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation, "Unspecified", false) == 0)
          {
            XMLobj.WriteValue("0");
            break;
          }
          break;
        case 1128440633:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation, "North East", false) == 0)
          {
            XMLobj.WriteValue("2");
            break;
          }
          break;
        case 1409318971:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation, "North West", false) == 0)
          {
            XMLobj.WriteValue("8");
            break;
          }
          break;
        case 1731397980:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation, "East", false) == 0)
          {
            XMLobj.WriteValue("3");
            break;
          }
          break;
        case 1734234020:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation, "North", false) == 0)
          {
            XMLobj.WriteValue("1");
            break;
          }
          break;
        case 1796576718:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation, "West", false) == 0)
          {
            XMLobj.WriteValue("7");
            break;
          }
          break;
        case 2417407149:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation, "South West", false) == 0)
          {
            XMLobj.WriteValue("6");
            break;
          }
          break;
        case 2853841879:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation, "South East", false) == 0)
          {
            XMLobj.WriteValue("4");
            break;
          }
          break;
        case 3017973530:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation, "South", false) == 0)
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
      XMLobj.WriteStartElement("Conservatory-Type");
      string Left = Microsoft.VisualBasic.Strings.UCase(SAP_Module.Proj.Dwellings[House].Conservatory);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, Microsoft.VisualBasic.Strings.UCase("No conservatory"), false) == 0)
        XMLobj.WriteValue("1");
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, Microsoft.VisualBasic.Strings.UCase("Separated unheated conservatory"), false) == 0)
        XMLobj.WriteValue("2");
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, Microsoft.VisualBasic.Strings.UCase("Separated heated conservatory"), false) == 0)
        XMLobj.WriteValue("3");
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, Microsoft.VisualBasic.Strings.UCase("Not separated"), false) == 0)
        XMLobj.WriteValue("4");
      XMLobj.WriteEndElement();
    }

    private void _SAP09DataPropertyDetails_SmokedArea(XmlTextWriter XMLobj, int House, int Country)
    {
      XMLobj.WriteStartElement("Is-In-Smoke-Control-Area");
      string smokeArea = SAP_Module.Proj.Dwellings[House].SmokeArea;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(smokeArea, "No", false) != 0)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(smokeArea, "Yes", false) != 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(smokeArea, "Unknown", false) == 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(smokeArea, "unknown", false) == 0)
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
    }

    private void _SAP09DataPropertyDetails_Design_Water_Use(
      XmlTextWriter XMLobj,
      int House,
      int Country)
    {
      if (!SAP_Module.Proj.Dwellings[House].LessThan125Litre)
        return;
      XMLobj.WriteStartElement("Design-Water-Use");
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
      XMLobj.WriteStartElement("SAP-Flat-Details");
      XMLobj.WriteStartElement("Level");
      string flatType = SAP_Module.Proj.Dwellings[House].FlatType;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(flatType, "Ground floor", false) != 0)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(flatType, "Mid floor", false) != 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(flatType, "Top floor", false) == 0)
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
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Address.Country, "Scotland", false) == 0)
      {
        XMLobj.WriteStartElement("Number-Of-Dwellings-Below");
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoOFDwellingsBelow);
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("Number-Of-Dwellings-Above");
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoOFDwellingsAbove);
        XMLobj.WriteEndElement();
      }
      XMLobj.WriteEndElement();
    }

    private void _SAP09DataPropertyDetails_Openings(XmlTextWriter XMLobj, int House, int Country)
    {
      XMLobj.WriteStartElement("SAP-Opening-Types");
      int num = checked (this.OpeningTypes.Length - 1);
      int index = 0;
      while (index <= num)
      {
        XMLobj.WriteStartElement("SAP-Opening-Type");
        XMLobj.WriteStartElement("Name");
        XMLobj.WriteValue(this.OpeningTypes[index].Name);
        XMLobj.WriteEndElement();
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.OpeningTypes[index].DSource, "BFRC", false) == 0 & !this.OpeningTypes[index].Name.Contains("Door"))
        {
          XMLobj.WriteStartElement("Description");
          XMLobj.WriteValue("BFRC data");
          XMLobj.WriteEndElement();
        }
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.OpeningTypes[index].DSource, "Manufacturer", false) == 0)
        {
          XMLobj.WriteStartElement("Description");
          XMLobj.WriteValue("Data from Manufacturer");
          XMLobj.WriteEndElement();
        }
        XMLobj.WriteStartElement("Data-Source");
        string dsource = this.OpeningTypes[index].DSource;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(dsource, "SAP 2005", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(dsource, "SAP 2009", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(dsource, "SAP 2012", false) != 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(dsource, "Manufacturer", false) != 0)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(dsource, "BFRC", false) == 0)
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
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(type, "Solid", false) != 0)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(type, "Half glazed", false) != 0)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(type, "Fully glazed", false) == 0)
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
        XMLobj.WriteStartElement("Glazing-Type");
        string glazingType = this.OpeningTypes[index].GlazingType;
        // ISSUE: reference to a compiler-generated method
        switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(glazingType))
        {
          case 68605829:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(glazingType, "triple-glazed, argon filled (low-E, En = 0.2, hard coat)", false) == 0)
              goto label_51;
            else
              goto default;
          case 763250309:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(glazingType, "double-glazed, air filled (low-E, En = 0.2, hard coat)", false) == 0)
              goto label_46;
            else
              goto default;
          case 1070237142:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(glazingType, "triple-glazed, argon filled", false) == 0)
              goto label_50;
            else
              goto default;
          case 1119002789:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(glazingType, "double-glazed, argon filled", false) == 0)
              break;
            goto default;
          case 1129292894:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(glazingType, "triple-glazed, air filled (low-E, En = 0.15, hard coat)", false) == 0)
              goto label_52;
            else
              goto default;
          case 1508940614:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(glazingType, "double-glazed, argon filled (low-E, En = 0.15, hard coat)", false) == 0)
              goto label_47;
            else
              goto default;
          case 1617436365:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(glazingType, "triple-glazed, argon filled (low-E, En = 0.1, soft coat)", false) == 0)
              goto label_53;
            else
              goto default;
          case 1917834200:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(glazingType, "double-glazed, argon filled (low-E, En = 0.1, soft coat)", false) == 0)
              goto label_48;
            else
              goto default;
          case 2282570948:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(glazingType, "triple-glazed, air filled (low-E, En = 0.2, hard coat)", false) == 0)
              goto label_51;
            else
              goto default;
          case 2312080845:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(glazingType, "double-glazed, air filled (low-E, En = 0.1, soft coat)", false) == 0)
              goto label_48;
            else
              goto default;
          case 2413948722:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(glazingType, "double-glazed, argon filled (low-E, En = 0.05, soft coat)", false) == 0)
              goto label_49;
            else
              goto default;
          case 2482092156:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(glazingType, "double-glazed, argon filled (low-E, En = 0.2, hard coat)", false) == 0)
              goto label_46;
            else
              goto default;
          case 2498216925:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(glazingType, "triple-glazed, air filled", false) == 0)
              goto label_50;
            else
              goto default;
          case 2915735968:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(glazingType, "triple-glazed, air filled (low-E, En = 0.1, soft coat)", false) == 0)
              goto label_53;
            else
              goto default;
          case 3074690985:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(glazingType, "triple-glazed, argon filled (low-E, En = 0.05, soft coat)", false) == 0)
              goto label_54;
            else
              goto default;
          case 3361248225:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(glazingType, "triple-glazed, argon filled (low-E, En = 0.15, hard coat)", false) == 0)
              goto label_52;
            else
              goto default;
          case 3689514233:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(glazingType, "Single-glazed", false) == 0)
            {
              XMLobj.WriteValue("2");
              goto label_56;
            }
            else
              goto default;
          case 3838377526:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(glazingType, "double-glazed", false) == 0)
              break;
            goto default;
          case 3843542185:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(glazingType, "double-glazed, air filled (low-E, En = 0.05, soft coat)", false) == 0)
              goto label_49;
            else
              goto default;
          case 4014901974:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(glazingType, "double-glazed, air filled", false) == 0)
              break;
            goto default;
          case 4130099425:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(glazingType, "double-glazed, air filled (low-E, En = 0.15, hard coat)", false) == 0)
              goto label_47;
            else
              goto default;
          case 4251481834:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(glazingType, "triple-glazed, air filled (low-E, En = 0.05, soft coat)", false) == 0)
              goto label_54;
            else
              goto default;
          case 4255679661:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(glazingType, "Secondary glazing", false) == 0)
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
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.OpeningTypes[index].DSource, "SAP 2005", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.OpeningTypes[index].DSource, "SAP 2009", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.OpeningTypes[index].DSource, "SAP 2012", false) == 0 && (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.OpeningTypes[index].GlazingGap, "", false) > 0U)
        {
          XMLobj.WriteStartElement("Glazing-Gap");
          string glazingGap = this.OpeningTypes[index].GlazingGap;
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(glazingGap, "6mm", false) != 0)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(glazingGap, "12mm", false) != 0)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(glazingGap, "16mm or more ", false) == 0)
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
        if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.OpeningTypes[index].Type, "Solid", false) > 0U & (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.OpeningTypes[index].Type, "Fully glazed", false) > 0U && (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.OpeningTypes[index].FrameType, "", false) > 0U)
        {
          XMLobj.WriteStartElement("Frame-Type");
          string frameType = this.OpeningTypes[index].FrameType;
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(frameType, "Wood", false) != 0)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(frameType, "Metal", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(frameType, "Metal, thermal break", false) != 0)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(frameType, "PVC-U", false) == 0)
                XMLobj.WriteValue("2");
            }
            else
            {
              string metalFrameType = this.OpeningTypes[index].MetalFrameType;
              // ISSUE: reference to a compiler-generated method
              switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(metalFrameType))
              {
                case 333502473:
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(metalFrameType, "8mm", false) == 0)
                  {
                    XMLobj.WriteValue("5");
                    goto label_85;
                  }
                  else
                    goto label_85;
                case 473775746:
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(metalFrameType, "No thermal break", false) == 0)
                    break;
                  goto label_85;
                case 536439224:
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(metalFrameType, "12mm", false) == 0)
                  {
                    XMLobj.WriteValue("6");
                    goto label_85;
                  }
                  else
                    goto label_85;
                case 2166136261:
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(metalFrameType, "", false) == 0)
                    break;
                  goto label_85;
                case 2186527966:
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(metalFrameType, "32mm", false) == 0)
                  {
                    XMLobj.WriteValue("8");
                    goto label_85;
                  }
                  else
                    goto label_85;
                case 2560045537:
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(metalFrameType, "20mm", false) == 0)
                  {
                    XMLobj.WriteValue("7");
                    goto label_85;
                  }
                  else
                    goto label_85;
                case 3632641573:
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(metalFrameType, "4mm", false) == 0)
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
          XMLobj.WriteStartElement("Solar-Transmittance");
          XMLobj.WriteValue(this.OpeningTypes[index].SolarT);
          XMLobj.WriteEndElement();
        }
        if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.OpeningTypes[index].DSource, "BFRC", false) > 0U && (double) this.OpeningTypes[index].FrameFactor != 0.0)
        {
          XMLobj.WriteStartElement("Frame-Factor");
          XMLobj.WriteValue(this.OpeningTypes[index].FrameFactor);
          XMLobj.WriteEndElement();
        }
        XMLobj.WriteStartElement("U-Value");
        XMLobj.WriteValue(this.OpeningTypes[index].U_Value);
        XMLobj.WriteEndElement();
        XMLobj.WriteEndElement();
        checked { ++index; }
      }
      XMLobj.WriteEndElement();
    }

    private void _BuildingPartsNumber(XmlTextWriter XMLobj, int House, int Country)
    {
      XMLobj.WriteStartElement("Building-Part-Number");
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
      XMLobj.WriteStartElement("Construction-Year");
      XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].YearBuilt);
      XMLobj.WriteEndElement();
    }

    private void _BuildingPartsOvershading(XmlTextWriter XMLobj, int House, int Country)
    {
      XMLobj.WriteStartElement("Overshading");
      string overshading = SAP_Module.Proj.Dwellings[House].Overshading;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(overshading, "Heavy", false) != 0)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(overshading, "More than average", false) != 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(overshading, "Average or unknown", false) != 0)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(overshading, "Very Little", false) == 0)
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
            XMLobj.WriteStartElement("SAP-Opening");
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
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation, "North East", false) == 0)
                {
                  XMLobj.WriteValue("2");
                  break;
                }
                goto default;
              case 1409318971:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation, "North West", false) == 0)
                {
                  XMLobj.WriteValue("8");
                  break;
                }
                goto default;
              case 1731397980:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation, "East", false) == 0)
                {
                  XMLobj.WriteValue("3");
                  break;
                }
                goto default;
              case 1734234020:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation, "North", false) == 0)
                {
                  XMLobj.WriteValue("1");
                  break;
                }
                goto default;
              case 1796576718:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation, "West", false) == 0)
                {
                  XMLobj.WriteValue("7");
                  break;
                }
                goto default;
              case 2417407149:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation, "South West", false) == 0)
                {
                  XMLobj.WriteValue("6");
                  break;
                }
                goto default;
              case 2853841879:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation, "South East", false) == 0)
                {
                  XMLobj.WriteValue("4");
                  break;
                }
                goto default;
              case 3017973530:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation, "South", false) == 0)
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
          XMLobj.WriteStartElement("SAP-Opening");
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
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation, "North East", false) == 0)
              {
                XMLobj.WriteValue("2");
                break;
              }
              goto default;
            case 1409318971:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation, "North West", false) == 0)
              {
                XMLobj.WriteValue("8");
                break;
              }
              goto default;
            case 1731397980:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation, "East", false) == 0)
              {
                XMLobj.WriteValue("3");
                break;
              }
              goto default;
            case 1734234020:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation, "North", false) == 0)
              {
                XMLobj.WriteValue("1");
                break;
              }
              goto default;
            case 1796576718:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation, "West", false) == 0)
              {
                XMLobj.WriteValue("7");
                break;
              }
              goto default;
            case 2417407149:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation, "South West", false) == 0)
              {
                XMLobj.WriteValue("6");
                break;
              }
              goto default;
            case 2853841879:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation, "South East", false) == 0)
              {
                XMLobj.WriteValue("4");
                break;
              }
              goto default;
            case 3017973530:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation, "South", false) == 0)
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
            XMLobj.WriteStartElement("SAP-Opening");
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
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation, "North East", false) == 0)
                {
                  XMLobj.WriteValue("2");
                  break;
                }
                goto default;
              case 1409318971:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation, "North West", false) == 0)
                {
                  XMLobj.WriteValue("8");
                  break;
                }
                goto default;
              case 1731397980:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation, "East", false) == 0)
                {
                  XMLobj.WriteValue("3");
                  break;
                }
                goto default;
              case 1734234020:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation, "North", false) == 0)
                {
                  XMLobj.WriteValue("1");
                  break;
                }
                goto default;
              case 1796576718:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation, "West", false) == 0)
                {
                  XMLobj.WriteValue("7");
                  break;
                }
                goto default;
              case 2417407149:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation, "South West", false) == 0)
                {
                  XMLobj.WriteValue("6");
                  break;
                }
                goto default;
              case 2853841879:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation, "South East", false) == 0)
                {
                  XMLobj.WriteValue("4");
                  break;
                }
                goto default;
              case 3017973530:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation, "South", false) == 0)
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
          XMLobj.WriteStartElement("SAP-Opening");
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
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation, "North East", false) == 0)
              {
                XMLobj.WriteValue("2");
                break;
              }
              goto default;
            case 1409318971:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation, "North West", false) == 0)
              {
                XMLobj.WriteValue("8");
                break;
              }
              goto default;
            case 1731397980:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation, "East", false) == 0)
              {
                XMLobj.WriteValue("3");
                break;
              }
              goto default;
            case 1734234020:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation, "North", false) == 0)
              {
                XMLobj.WriteValue("1");
                break;
              }
              goto default;
            case 1796576718:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation, "West", false) == 0)
              {
                XMLobj.WriteValue("7");
                break;
              }
              goto default;
            case 2417407149:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation, "South West", false) == 0)
              {
                XMLobj.WriteValue("6");
                break;
              }
              goto default;
            case 2853841879:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation, "South East", false) == 0)
              {
                XMLobj.WriteValue("4");
                break;
              }
              goto default;
            case 3017973530:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation, "South", false) == 0)
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
            XMLobj.WriteStartElement("SAP-Opening");
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
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation, "North East", false) == 0)
                {
                  XMLobj.WriteValue("2");
                  break;
                }
                goto default;
              case 1409318971:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation, "North West", false) == 0)
                {
                  XMLobj.WriteValue("8");
                  break;
                }
                goto default;
              case 1731397980:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation, "East", false) == 0)
                {
                  XMLobj.WriteValue("3");
                  break;
                }
                goto default;
              case 1734234020:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation, "North", false) == 0)
                {
                  XMLobj.WriteValue("1");
                  break;
                }
                goto default;
              case 1796576718:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation, "West", false) == 0)
                {
                  XMLobj.WriteValue("7");
                  break;
                }
                goto default;
              case 1811125385:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation, "Horizontal", false) == 0)
                {
                  XMLobj.WriteValue("9");
                  break;
                }
                goto default;
              case 2417407149:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation, "South West", false) == 0)
                {
                  XMLobj.WriteValue("6");
                  break;
                }
                goto default;
              case 2853841879:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation, "South East", false) == 0)
                {
                  XMLobj.WriteValue("4");
                  break;
                }
                goto default;
              case 3017973530:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation, "South", false) == 0)
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
              if ((double) SAP_Module.Proj.Dwellings[House].RoofLights[index].Pitch != Conversions.ToDouble(""))
              {
                XMLobj.WriteStartElement("Pitch");
                XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].RoofLights[index].Pitch);
                XMLobj.WriteEndElement();
              }
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
          XMLobj.WriteStartElement("SAP-Opening");
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
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation, "North East", false) == 0)
              {
                XMLobj.WriteValue("2");
                break;
              }
              goto default;
            case 1409318971:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation, "North West", false) == 0)
              {
                XMLobj.WriteValue("8");
                break;
              }
              goto default;
            case 1731397980:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation, "East", false) == 0)
              {
                XMLobj.WriteValue("3");
                break;
              }
              goto default;
            case 1734234020:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation, "North", false) == 0)
              {
                XMLobj.WriteValue("1");
                break;
              }
              goto default;
            case 1796576718:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation, "West", false) == 0)
              {
                XMLobj.WriteValue("7");
                break;
              }
              goto default;
            case 1811125385:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation, "Horizontal", false) == 0)
              {
                XMLobj.WriteValue("9");
                break;
              }
              goto default;
            case 2417407149:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation, "South West", false) == 0)
              {
                XMLobj.WriteValue("6");
                break;
              }
              goto default;
            case 2853841879:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation, "South East", false) == 0)
              {
                XMLobj.WriteValue("4");
                break;
              }
              goto default;
            case 3017973530:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation, "South", false) == 0)
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
      if (checked (SAP_Module.Proj.Dwellings[House].NoofFloors + SAP_Module.Proj.Dwellings[House].NoofIFloors) <= 0)
        return;
      XMLobj.WriteStartElement("SAP-Floor-Dimensions");
      int num1 = 0;
      int index1 = 0;
      int index2 = 0;
      int num2 = 0;
      int num3 = checked (SAP_Module.Proj.Dwellings[House].Storeys - 1);
      int index3 = 0;
      while (index3 <= num3)
      {
        XMLobj.WriteStartElement("SAP-Floor-Dimension");
        XMLobj.WriteStartElement("Storey");
        if (SAP_Module.Proj.Dwellings[House].Dims[0].Basement == null)
          SAP_Module.Proj.Dwellings[House].Dims[0].Basement = "";
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].Dims[0].Basement, "Yes", false) == 0)
        {
          XMLobj.WriteValue(checked (index3 - 1));
          XMLobj.WriteEndElement();
        }
        else
        {
          if (index3 > 6)
            XMLobj.WriteValue(99);
          else
            XMLobj.WriteValue(index3);
          XMLobj.WriteEndElement();
        }
        checked { ++num1; }
        checked { num2 += index3; }
        if (checked (SAP_Module.Proj.Dwellings[House].NoofFloors - 1) >= index3 && (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].Floors[index3].Type, "Exposed floor", false) > 0U)
        {
          XMLobj.WriteStartElement("Description");
          XMLobj.WriteEndElement();
        }
        XMLobj.WriteStartElement("Floor-Type");
        if (checked (SAP_Module.Proj.Dwellings[House].NoofFloors - 1) >= index3)
        {
          string type = SAP_Module.Proj.Dwellings[House].Floors[index3].Type;
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(type, "Basement floor", false) != 0)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(type, "Ground floor", false) != 0)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(type, "Exposed floor", false) == 0)
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
        XMLobj.WriteStartElement("Total-Floor-Area");
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Dims[index3].Area);
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("Storey-Height");
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Dims[index3].Height);
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("Heat-Loss-Area");
        if (checked (SAP_Module.Proj.Dwellings[House].NoofFloors - 1) >= index3)
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Floors[index3].Area);
        else
          XMLobj.WriteValue(0);
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("U-Value");
        if (checked (SAP_Module.Proj.Dwellings[House].NoofFloors - 1) >= index3)
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Floors[index3].U_Value);
        else
          XMLobj.WriteValue(0);
        XMLobj.WriteEndElement();
        if (checked (SAP_Module.Proj.Dwellings[House].NoofFloors - 1) >= index3)
        {
          if ((double) SAP_Module.Proj.Dwellings[House].Floors[index3].K > 0.0)
          {
            XMLobj.WriteStartElement("Kappa-Value");
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
                  XMLobj.WriteStartElement("Kappa-Value");
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
                  XMLobj.WriteStartElement("Kappa-Value-From-Below");
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
                XMLobj.WriteStartElement("Kappa-Value");
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
                XMLobj.WriteStartElement("Kappa-Value-From-Below");
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

    private void _BuildingPartsRoofs(XmlTextWriter XMLobj, int House, int Country)
    {
      XMLobj.WriteStartElement("SAP-Roofs");
      if (SAP_Module.Proj.Dwellings[House].NoofRoofs == 0)
      {
        XMLobj.WriteStartElement("SAP-Roof");
        XMLobj.WriteStartElement("Name");
        XMLobj.WriteValue("Exposed Roof");
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("Description");
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("Roof-Type");
        XMLobj.WriteValue(2);
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("Total-Roof-Area");
        XMLobj.WriteValue(0);
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("U-Value");
        XMLobj.WriteValue(0);
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("Kappa-Value");
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
          XMLobj.WriteStartElement("SAP-Roof");
          XMLobj.WriteStartElement("Name");
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Roofs[index].Name);
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("Description");
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("Roof-Type");
          XMLobj.WriteValue(2);
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("Total-Roof-Area");
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Roofs[index].Area);
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("U-Value");
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Roofs[index].U_Value);
          XMLobj.WriteEndElement();
          if ((double) SAP_Module.Proj.Dwellings[House].Roofs[index].K > 0.0)
          {
            XMLobj.WriteStartElement("Kappa-Value");
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
        XMLobj.WriteStartElement("SAP-Roof");
        XMLobj.WriteStartElement("Name");
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].PCeilings[index1].Name);
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("Description");
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("Roof-Type");
        XMLobj.WriteValue(4);
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("Total-Roof-Area");
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].PCeilings[index1].Area);
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("U-Value");
        XMLobj.WriteValue(0);
        XMLobj.WriteEndElement();
        if ((double) SAP_Module.Proj.Dwellings[House].PCeilings[index1].K > 0.0)
        {
          XMLobj.WriteStartElement("Kappa-Value");
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
      XMLobj.WriteStartElement("SAP-Walls");
      int num1 = checked (SAP_Module.Proj.Dwellings[House].NoofWalls - 1);
      int index1 = 0;
      while (index1 <= num1)
      {
        XMLobj.WriteStartElement("SAP-Wall");
        XMLobj.WriteStartElement("Name");
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Walls[index1].Name);
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("Description");
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("Wall-Type");
        string type = SAP_Module.Proj.Dwellings[House].Walls[index1].Type;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(type, "Basement wall", false) != 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(type, "Exposed wall", false) != 0)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(type, "Sheltered wall", false) == 0)
              XMLobj.WriteValue("3");
          }
          else
            XMLobj.WriteValue("2");
        }
        else
          XMLobj.WriteValue("1");
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("Total-Wall-Area");
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Walls[index1].Area);
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("U-Value");
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Walls[index1].U_Value);
        XMLobj.WriteEndElement();
        if ((double) SAP_Module.Proj.Dwellings[House].Walls[index1].K > 0.0)
        {
          XMLobj.WriteStartElement("Kappa-Value");
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Walls[index1].K);
          XMLobj.WriteEndElement();
        }
        if (!SAP_Module.Proj.Dwellings[House].Walls[index1].Type.Contains("ment"))
        {
          XMLobj.WriteStartElement("Is-Curtain-Walling");
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
        XMLobj.WriteStartElement("SAP-Wall");
        XMLobj.WriteStartElement("Name");
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].IWalls[index2].Name);
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("Wall-Type");
        XMLobj.WriteValue("5");
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("Total-Wall-Area");
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].IWalls[index2].Area);
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("U-Value");
        XMLobj.WriteValue(0);
        XMLobj.WriteEndElement();
        if ((double) SAP_Module.Proj.Dwellings[House].IWalls[index2].K > 0.0)
        {
          XMLobj.WriteStartElement("Kappa-Value");
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
        XMLobj.WriteStartElement("SAP-Wall");
        XMLobj.WriteStartElement("Name");
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].PWalls[index3].Name);
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("Wall-Type");
        XMLobj.WriteValue("4");
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("Total-Wall-Area");
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].PWalls[index3].Area);
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("U-Value");
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].PWalls[index3].U_Value);
        XMLobj.WriteEndElement();
        if ((double) SAP_Module.Proj.Dwellings[House].PWalls[index3].K > 0.0)
        {
          XMLobj.WriteStartElement("Kappa-Value");
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
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].TMP.Type, "User Value", false) != 0)
        return;
      XMLobj.WriteStartElement("Thermal-Mass-Parameter");
      XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].TMP.UserDefined);
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
          num1 = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].Ventilation.Pressure, "As built", false) != 0 ? SAP_Module.Proj.Dwellings[House].Ventilation.DesignAir : SAP_Module.Proj.Dwellings[House].Ventilation.MeasuredAir;
        else if ((double) SAP_Module.Proj.Dwellings[House].Ventilation.DesignAir != 0.0)
          num1 = SAP_Module.Proj.Dwellings[House].Ventilation.DesignAir;
        else if ((double) SAP_Module.Proj.Dwellings[House].Ventilation.MeasuredAir != 0.0)
          num1 = SAP_Module.Proj.Dwellings[House].Ventilation.MeasuredAir;
        else if ((double) SAP_Module.Proj.Dwellings[House].Ventilation.AssumedAir != 0.0)
          num1 = SAP_Module.Proj.Dwellings[House].Ventilation.MeasuredAir;
        if ((double) SAP_Module.Proj.Dwellings[House].Ventilation.AssumedAir != 0.0)
          num1 = SAP_Module.Proj.Dwellings[House].Ventilation.AssumedAir;
      }
      XMLobj.WriteStartElement("SAP-Ventilation");
      XMLobj.WriteStartElement("Open-Fireplaces-Count");
      XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Ventilation.Chimneys);
      XMLobj.WriteEndElement();
      XMLobj.WriteStartElement("Open-Flues-Count");
      XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Ventilation.Flues);
      XMLobj.WriteEndElement();
      XMLobj.WriteStartElement("Extract-Fans-Count");
      XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Ventilation.Fans);
      XMLobj.WriteEndElement();
      XMLobj.WriteStartElement("PSV-Count");
      XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Ventilation.Vents);
      XMLobj.WriteEndElement();
      XMLobj.WriteStartElement("Flueless-Gas-Fires-Count");
      XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Ventilation.Fires);
      XMLobj.WriteEndElement();
      XMLobj.WriteStartElement("Pressure-Test");
      if (SAP_Module.Proj.Dwellings[House].Ventilation.AveragePerm)
        XMLobj.WriteValue("5");
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].Status, "Existing dwelling (SAP)", false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].Ventilation.Pressure, "Calculated", false) == 0)
        XMLobj.WriteValue("6");
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].Status, "New extension to existing dwelling", false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].Ventilation.Pressure, "Calculated", false) == 0)
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
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(pressure, "As built", false) == 0)
              break;
            goto default;
          case 774849489:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(pressure, "Assumed", false) == 0)
            {
              XMLobj.WriteValue("3");
              goto default;
            }
            else
              goto default;
          case 864291923:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(pressure, "As measured", false) == 0)
              break;
            goto default;
          case 1158145841:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(pressure, "Calculated", false) == 0)
              goto label_34;
            else
              goto default;
          case 1647734778:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(pressure, "no", false) == 0)
              goto label_34;
            else
              goto default;
          case 1942325214:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(pressure, "yes (design value)", false) == 0)
              goto label_32;
            else
              goto default;
          case 2121038188:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(pressure, "As designed", false) == 0)
              goto label_32;
            else
              goto default;
          default:
label_35:
            goto label_36;
        }
        XMLobj.WriteValue("1");
        goto label_35;
label_32:
        XMLobj.WriteValue("2");
        goto label_35;
label_34:
        XMLobj.WriteValue("4");
        goto label_35;
      }
label_36:
      XMLobj.WriteEndElement();
      if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].Ventilation.Pressure, "Calculated", false) > 0U & (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].Ventilation.Pressure, "As built", false) > 0U)
      {
        XMLobj.WriteStartElement("Air-Permeability");
        XMLobj.WriteValue(num1);
        XMLobj.WriteEndElement();
      }
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].Ventilation.Pressure, "As built", false) == 0)
      {
        XMLobj.WriteStartElement("Air-Permeability");
        XMLobj.WriteValue(num1);
        XMLobj.WriteEndElement();
      }
      XMLobj.WriteStartElement("Sheltered-Sides-Count");
      XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Ventilation.Shelter);
      XMLobj.WriteEndElement();
      XMLobj.WriteStartElement("Ventilation-Type");
      string mechVent1 = SAP_Module.Proj.Dwellings[House].Ventilation.MechVent;
      // ISSUE: reference to a compiler-generated method
      switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(mechVent1))
      {
        case 428439872:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(mechVent1, "natural with intermittent extract fans", false) == 0)
            break;
          goto default;
        case 625191264:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(mechVent1, "Balanced without heat recovery", false) == 0)
          {
            XMLobj.WriteValue("7");
            goto default;
          }
          else
            goto default;
        case 918396964:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(mechVent1, "Decentralised whole house extract", false) == 0)
          {
            XMLobj.WriteValue("6");
            goto default;
          }
          else
            goto default;
        case 1101494137:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(mechVent1, "Centralised whole house extract", false) == 0)
          {
            XMLobj.WriteValue("5");
            goto default;
          }
          else
            goto default;
        case 2533751361:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(mechVent1, "Positive input from loft", false) == 0)
          {
            XMLobj.WriteValue("3");
            goto default;
          }
          else
            goto default;
        case 3118369032:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(mechVent1, "natural with intermittent extract fans and passive vents", false) == 0)
          {
            XMLobj.WriteValue("10");
            goto default;
          }
          else
            goto default;
        case 3225008057:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(mechVent1, "Positive input from outside", false) == 0)
          {
            XMLobj.WriteValue("4");
            goto default;
          }
          else
            goto default;
        case 3236691049:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(mechVent1, "Natural ventilation", false) == 0)
            break;
          goto default;
        case 3255421954:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(mechVent1, "Balanced with heat recovery", false) == 0)
          {
            XMLobj.WriteValue("8");
            goto default;
          }
          else
            goto default;
        default:
label_68:
          XMLobj.WriteEndElement();
          string mechVent2 = SAP_Module.Proj.Dwellings[House].Ventilation.MechVent;
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(mechVent2, "Natural ventilation", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(mechVent2, "natural with intermittent extract fans", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(mechVent2, "Positive input from loft", false) != 0)
          {
            XMLobj.WriteStartElement("Is-Mechanical-Vent-Approved-Installer-Scheme");
            if (SAP_Module.Proj.Dwellings[House].Ventilation.ApprovedScheme)
              XMLobj.WriteValue("true");
            else
              XMLobj.WriteValue("false");
            XMLobj.WriteEndElement();
          }
          string mechVent3 = SAP_Module.Proj.Dwellings[House].Ventilation.MechVent;
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(mechVent3, "Balanced without heat recovery", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(mechVent3, "Positive input from outside", false) != 0)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(mechVent3, "Balanced with heat recovery", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(mechVent3, "Centralised whole house extract", false) != 0)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(mechVent3, "Decentralised whole house extract", false) == 0)
              {
                XMLobj.WriteStartElement("Mechanical-Ventilation-Data-Source");
                string parameters = SAP_Module.Proj.Dwellings[House].Ventilation.Parameters;
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(parameters, "User defined", false) != 0)
                {
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(parameters, "SAP 2005", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(parameters, "SAP 2012", false) != 0)
                  {
                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(parameters, "Database", false) == 0)
                    {
                      XMLobj.WriteValue(1);
                      XMLobj.WriteEndElement();
                      XMLobj.WriteStartElement("Mechanical-Vent-System-Index-Number");
                      XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Ventilation.ProductID);
                      XMLobj.WriteEndElement();
                      XMLobj.WriteStartElement("Wet-Rooms-Count");
                      int num2 = checked ((int) Math.Round(Math.Round(unchecked (1.0 + (double) SAP_Module.Proj.Dwellings[House].Ventilation.Decentralised.OTP1 + (double) SAP_Module.Proj.Dwellings[House].Ventilation.Decentralised.OTP2 + (double) SAP_Module.Proj.Dwellings[House].Ventilation.Decentralised.OTP3), 0)));
                      XMLobj.WriteValue(num2);
                      XMLobj.WriteEndElement();
                      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].Ventilation.Parameters, "Database", false) == 0)
                      {
                        PCDF.Products322 products322 = SAP_Module.PCDFData.Products322s.Where<PCDF.Products322>((Func<PCDF.Products322, bool>) (b => b.ID.Equals(SAP_Module.Proj.Dwellings[House].Ventilation.ProductID.ToString()))).SingleOrDefault<PCDF.Products322>();
                        XMLobj.WriteStartElement("Mechanical-Vent-Duct-Type");
                        if (products322 == null)
                          XMLobj.WriteValue("2");
                        else
                          XMLobj.WriteValue(products322.DuctingType);
                        XMLobj.WriteEndElement();
                      }
                      else
                      {
                        XMLobj.WriteStartElement("Mechanical-Vent-Duct-Type");
                        string ductType = SAP_Module.Proj.Dwellings[House].Ventilation.DuctType;
                        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(ductType, "Rigid", false) != 0)
                        {
                          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(ductType, "Semi-rigid", false) != 0)
                          {
                            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(ductType, "Flexible", false) == 0)
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
                  XMLobj.WriteStartElement("Mechanical-Vent-System-Make-Model");
                  XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Ventilation.MVDetails.ProductName);
                  XMLobj.WriteEndElement();
                  XMLobj.WriteStartElement("Wet-Rooms-Count");
                  XMLobj.WriteValue(Math.Round(1.0 + (double) SAP_Module.Proj.Dwellings[House].Ventilation.Decentralised.OTP1 + (double) SAP_Module.Proj.Dwellings[House].Ventilation.Decentralised.OTP2 + (double) SAP_Module.Proj.Dwellings[House].Ventilation.Decentralised.OTP3, 0));
                  XMLobj.WriteEndElement();
                  XMLobj.WriteStartElement("Mechanical-Vent-Duct-Type");
                  string ductingType = SAP_Module.Proj.Dwellings[House].Ventilation.MVDetails.DuctingType;
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(ductingType, "Rigid", false) != 0)
                  {
                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(ductingType, "Semi-rigid", false) != 0)
                    {
                      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(ductingType, "Flexible", false) == 0)
                        XMLobj.WriteValue(1);
                    }
                    else
                      XMLobj.WriteValue(3);
                  }
                  else
                    XMLobj.WriteValue(2);
                  XMLobj.WriteEndElement();
                }
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].Ventilation.Parameters, "User defined", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].Ventilation.Parameters, "Database", false) == 0)
                {
                  XMLobj.WriteStartElement("Kitchen-Room-Fans-Count");
                  XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Ventilation.Decentralised.KTP1);
                  XMLobj.WriteEndElement();
                }
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].Ventilation.Parameters, "User defined", false) == 0)
                {
                  XMLobj.WriteStartElement("Kitchen-Room-Fans-Specific-Power");
                  XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Ventilation.Decentralised.KSPF1);
                  XMLobj.WriteEndElement();
                }
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].Ventilation.Parameters, "User defined", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].Ventilation.Parameters, "Database", false) == 0)
                {
                  XMLobj.WriteStartElement("Non-Kitchen-Room-Fans-Count");
                  XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Ventilation.Decentralised.OTP1);
                  XMLobj.WriteEndElement();
                }
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].Ventilation.Parameters, "User defined", false) == 0)
                {
                  XMLobj.WriteStartElement("Non-Kitchen-Room-Fans-Specific-Power");
                  XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Ventilation.Decentralised.OSPF1);
                  XMLobj.WriteEndElement();
                }
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].Ventilation.Parameters, "User defined", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].Ventilation.Parameters, "Database", false) == 0)
                {
                  XMLobj.WriteStartElement("Kitchen-Duct-Fans-Count");
                  XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Ventilation.Decentralised.KTP2);
                  XMLobj.WriteEndElement();
                }
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].Ventilation.Parameters, "User defined", false) == 0)
                {
                  XMLobj.WriteStartElement("Kitchen-Duct-Fans-Specific-Power");
                  XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Ventilation.Decentralised.KSPF2);
                  XMLobj.WriteEndElement();
                }
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].Ventilation.Parameters, "User defined", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].Ventilation.Parameters, "Database", false) == 0)
                {
                  XMLobj.WriteStartElement("Non-Kitchen-Duct-Fans-Count");
                  XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Ventilation.Decentralised.OTP2);
                  XMLobj.WriteEndElement();
                }
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].Ventilation.Parameters, "User defined", false) == 0)
                {
                  XMLobj.WriteStartElement("Non-Kitchen-Duct-Fans-Specific-Power");
                  XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Ventilation.Decentralised.OSPF2);
                  XMLobj.WriteEndElement();
                }
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].Ventilation.Parameters, "User defined", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].Ventilation.Parameters, "Database", false) == 0)
                {
                  XMLobj.WriteStartElement("Kitchen-Wall-Fans-Count");
                  XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Ventilation.Decentralised.KTP3);
                  XMLobj.WriteEndElement();
                }
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].Ventilation.Parameters, "User defined", false) == 0)
                {
                  XMLobj.WriteStartElement("Kitchen-Wall-Fans-Specific-Power");
                  XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Ventilation.Decentralised.KSPF3);
                  XMLobj.WriteEndElement();
                }
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].Ventilation.Parameters, "User defined", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].Ventilation.Parameters, "Database", false) == 0)
                {
                  XMLobj.WriteStartElement("Non-Kitchen-Wall-Fans-Count");
                  XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Ventilation.Decentralised.OTP3);
                  XMLobj.WriteEndElement();
                }
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].Ventilation.Parameters, "User defined", false) == 0)
                {
                  XMLobj.WriteStartElement("Non-Kitchen-Wall-Fans-Specific-Power");
                  XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Ventilation.Decentralised.OSPF3);
                  XMLobj.WriteEndElement();
                }
              }
            }
            else
            {
              XMLobj.WriteStartElement("Mechanical-Ventilation-Data-Source");
              string parameters = SAP_Module.Proj.Dwellings[House].Ventilation.Parameters;
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(parameters, "User defined", false) != 0)
              {
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(parameters, "SAP 2005", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(parameters, "SAP 2009", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(parameters, "SAP 2012", false) != 0)
                {
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(parameters, "Database", false) == 0)
                    XMLobj.WriteValue(1);
                }
                else
                  XMLobj.WriteValue(3);
              }
              else
                XMLobj.WriteValue(2);
              XMLobj.WriteEndElement();
              if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].Ventilation.Parameters, "Database", false) > 0U & (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].Ventilation.Parameters, "SAP 2012", false) > 0U)
              {
                XMLobj.WriteStartElement("Mechanical-Vent-System-Make-Model");
                XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Ventilation.MVDetails.ProductName);
                XMLobj.WriteEndElement();
                XMLobj.WriteStartElement("Mechanical-Vent-Specific-Fan-Power");
                XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Ventilation.MVDetails.SFP);
                XMLobj.WriteEndElement();
                if ((double) SAP_Module.Proj.Dwellings[House].Ventilation.MVDetails.HEE != 0.0)
                {
                  XMLobj.WriteStartElement("Mechanical-Vent-Heat-Recovery-Efficiency");
                  XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Ventilation.MVDetails.HEE);
                  XMLobj.WriteEndElement();
                }
                XMLobj.WriteStartElement("Wet-Rooms-Count");
                XMLobj.WriteValue(checked (SAP_Module.Proj.Dwellings[House].Ventilation.WetRooms + 1));
                XMLobj.WriteEndElement();
                if (Conversions.ToDouble(SAP_Module.Proj.Dwellings[House].Ventilation.MVDetails.DuctProductID) != 0.0)
                {
                  XMLobj.WriteStartElement("Mechanical-Vent-Ducts-Index-Number");
                  XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Ventilation.MVDetails.DuctProductID);
                  XMLobj.WriteEndElement();
                }
                if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].Ventilation.MVDetails.DuctingType, "", false) > 0U && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].Ventilation.MechVent, "Balanced with heat recovery", false) == 0)
                {
                  XMLobj.WriteStartElement("Mechanical-Vent-Duct-Insulation");
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].Ventilation.DuctType, "Insulation", false) == 0)
                    XMLobj.WriteValue(2);
                  else
                    XMLobj.WriteValue(1);
                  XMLobj.WriteEndElement();
                }
                XMLobj.WriteStartElement("Mechanical-Vent-Duct-Type");
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].Ventilation.MVDetails.DuctingType, "Flexible", false) == 0)
                  XMLobj.WriteValue(1);
                else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].Ventilation.MVDetails.DuctingType, "Semi-rigid", false) == 0)
                  XMLobj.WriteValue(3);
                else
                  XMLobj.WriteValue(2);
                XMLobj.WriteEndElement();
              }
              else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].Ventilation.Parameters, "Database", false) == 0)
              {
                XMLobj.WriteStartElement("Mechanical-Vent-System-Index-Number");
                XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Ventilation.ProductID);
                XMLobj.WriteEndElement();
                XMLobj.WriteStartElement("Wet-Rooms-Count");
                XMLobj.WriteValue(checked (SAP_Module.Proj.Dwellings[House].Ventilation.WetRooms + 1));
                XMLobj.WriteEndElement();
                if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].Ventilation.Parameters, "SAP 2012", false) > 0U && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].Ventilation.MechVent, "Balanced with heat recovery", false) == 0 && (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].Ventilation.DuctType, "", false) > 0U)
                {
                  XMLobj.WriteStartElement("Mechanical-Vent-Duct-Insulation");
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].Ventilation.DuctType, "Insulation", false) == 0)
                    XMLobj.WriteValue(2);
                  else
                    XMLobj.WriteValue(1);
                  XMLobj.WriteEndElement();
                }
                PCDF.Products321 products321 = SAP_Module.PCDFData.Products321s.Where<PCDF.Products321>((Func<PCDF.Products321, bool>) (b => b.ID.Equals(SAP_Module.Proj.Dwellings[House].Ventilation.ProductID.ToString()))).SingleOrDefault<PCDF.Products321>();
                XMLobj.WriteStartElement("Mechanical-Vent-Duct-Type");
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
            XMLobj.WriteStartElement("Mechanical-Ventilation-Data-Source");
            string parameters1 = SAP_Module.Proj.Dwellings[House].Ventilation.Parameters;
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(parameters1, "User defined", false) != 0)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(parameters1, "SAP 2005", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(parameters1, "SAP 2009", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(parameters1, "SAP 2012", false) != 0)
              {
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(parameters1, "Database", false) == 0)
                  XMLobj.WriteValue(1);
              }
              else
                XMLobj.WriteValue(3);
            }
            else
              XMLobj.WriteValue(2);
            XMLobj.WriteEndElement();
            bool flag = true;
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].Ventilation.Parameters, "Manufacturer Declaration", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].Ventilation.Parameters, "User defined", false) == 0)
            {
              XMLobj.WriteStartElement("Mechanical-Vent-System-Make-Model");
              XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Ventilation.MVDetails.ProductName);
              XMLobj.WriteEndElement();
              XMLobj.WriteStartElement("Mechanical-Vent-Specific-Fan-Power");
              XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Ventilation.MVDetails.SFP);
              XMLobj.WriteEndElement();
              XMLobj.WriteStartElement("Wet-Rooms-Count");
              XMLobj.WriteValue(checked (SAP_Module.Proj.Dwellings[House].Ventilation.WetRooms + 1));
              XMLobj.WriteEndElement();
              XMLobj.WriteStartElement("Mechanical-Vent-Duct-Type");
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].Ventilation.MVDetails.DuctingType, "Flexible", false) == 0)
                XMLobj.WriteValue(1);
              else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].Ventilation.DuctType, "Semi-rigid", false) == 0)
                XMLobj.WriteValue(3);
              else
                XMLobj.WriteValue(2);
              XMLobj.WriteEndElement();
            }
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].Ventilation.MechVent, "Positive input from outside", false) == 0)
            {
              string parameters2 = SAP_Module.Proj.Dwellings[House].Ventilation.Parameters;
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(parameters2, "SAP 2005", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(parameters2, "SAP 2009", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(parameters2, "SAP 2012", false) != 0 && !flag)
              {
                XMLobj.WriteStartElement("Mechanical-Vent-System-Make-Model");
                XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Ventilation.MVDetails.ProductName);
                XMLobj.WriteEndElement();
                XMLobj.WriteStartElement("Mechanical-Vent-Specific-Fan-Power");
                XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Ventilation.MVDetails.SFP);
                XMLobj.WriteEndElement();
                XMLobj.WriteStartElement("Wet-Rooms-Count");
                XMLobj.WriteValue(Math.Round(1.0 + (double) SAP_Module.Proj.Dwellings[House].Ventilation.Decentralised.OTP1 + (double) SAP_Module.Proj.Dwellings[House].Ventilation.Decentralised.OTP2 + (double) SAP_Module.Proj.Dwellings[House].Ventilation.Decentralised.OTP3, 0));
                XMLobj.WriteEndElement();
                XMLobj.WriteStartElement("Mechanical-Vent-Duct-Type");
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].Ventilation.DuctType, "Un-Insulated", false) == 0)
                  XMLobj.WriteValue(1);
                else
                  XMLobj.WriteValue(2);
                XMLobj.WriteEndElement();
              }
            }
          }
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].Ventilation.Pressure, "Calculated", false) == 0 && SAP_Module.Proj.Dwellings[House].Ventilation.Infiltration.Lobby.Contains("Draught"))
          {
            XMLobj.WriteStartElement("Has-Draught-Lobby");
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].Ventilation.Infiltration.Lobby, "Draught Lobby", false) == 0)
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
        goto label_68;
      }
      else if (SAP_Module.Proj.Dwellings[House].Ventilation.Fans > 0 & SAP_Module.Proj.Dwellings[House].Ventilation.Vents > 0)
      {
        XMLobj.WriteValue("10");
        goto label_68;
      }
      else if (SAP_Module.Proj.Dwellings[House].Ventilation.Vents > 0 & SAP_Module.Proj.Dwellings[House].Ventilation.Fans == 0)
      {
        XMLobj.WriteValue("2");
        goto label_68;
      }
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].Ventilation.MechVent, "natural with passive vents", false) == 0)
      {
        XMLobj.WriteValue("2");
        goto label_68;
      }
      else if (SAP_Module.Proj.Dwellings[House].Ventilation.Vents > 0 & SAP_Module.Proj.Dwellings[House].Ventilation.Fans > 0)
      {
        XMLobj.WriteValue("9");
        goto label_68;
      }
      else
      {
        XMLobj.WriteValue("1");
        goto label_68;
      }
    }

    private void _BuildingPartsThermal_Bridges(XmlTextWriter XMLobj, int House, int Country)
    {
      XMLobj.WriteStartElement("SAP-Thermal-Bridges");
      XMLobj.WriteStartElement("Thermal-Bridge-Code");
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
                XMLobj.WriteStartElement("SAP-Thermal-Bridge");
                XMLobj.WriteStartElement("Thermal-Bridge-Type");
                XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Thermal.ExternalJunctions[index].Ref);
                XMLobj.WriteEndElement();
                XMLobj.WriteStartElement("Length");
                XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Thermal.ExternalJunctions[index].Length);
                XMLobj.WriteEndElement();
                XMLobj.WriteStartElement("Psi-Value");
                XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Thermal.ExternalJunctions[index].ThermalTransmittance);
                XMLobj.WriteEndElement();
                XMLobj.WriteStartElement("Psi-Value-Source");
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
                XMLobj.WriteStartElement("SAP-Thermal-Bridge");
                XMLobj.WriteStartElement("Thermal-Bridge-Type");
                XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Thermal.PartyJunctions[index].Ref);
                XMLobj.WriteEndElement();
                XMLobj.WriteStartElement("Length");
                XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Thermal.PartyJunctions[index].Length);
                XMLobj.WriteEndElement();
                XMLobj.WriteStartElement("Psi-Value");
                XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Thermal.PartyJunctions[index].ThermalTransmittance);
                XMLobj.WriteEndElement();
                XMLobj.WriteStartElement("Psi-Value-Source");
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
                XMLobj.WriteStartElement("SAP-Thermal-Bridge");
                XMLobj.WriteStartElement("Thermal-Bridge-Type");
                XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Thermal.RoofJunctions[index].Ref);
                XMLobj.WriteEndElement();
                XMLobj.WriteStartElement("Length");
                XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Thermal.RoofJunctions[index].Length);
                XMLobj.WriteEndElement();
                XMLobj.WriteStartElement("Psi-Value");
                XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Thermal.RoofJunctions[index].ThermalTransmittance);
                XMLobj.WriteEndElement();
                XMLobj.WriteStartElement("Psi-Value-Source");
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
        XMLobj.WriteStartElement("SAP-Community-Heating-Systems");
        XMLobj.WriteStartElement("SAP-Community-Heating-System");
        flag2 = true;
        XMLobj.WriteStartElement("Community-Heating-Use");
        if (SAP_Module.Proj.Dwellings[House].Water.SystemRef == 901)
          XMLobj.WriteValue(3);
        else
          XMLobj.WriteValue(1);
        XMLobj.WriteEndElement();
        try
        {
          if (!string.IsNullOrEmpty(SAP_Module.Proj.Dwellings[House].MainHeating.SEDBUK))
          {
            XMLobj.WriteStartElement("Heat-Network-Index-Number");
            XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].MainHeating.SEDBUK);
            XMLobj.WriteEndElement();
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        XMLobj.WriteStartElement("Community-Heat-Sources");
        XMLobj.WriteStartElement("Community-Heat-Source");
        XMLobj.WriteStartElement("Heat-Source-Type");
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
        if (SAP_Module.Proj.Dwellings[House].MainHeating.InforSource.Equals("Boiler Database") && (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.SEDBUK, "", false) > 0U)
          communitySchemeSubList1 = SAP_Module.PCDFData.CommunitySchemes_Sub.Where<PCDF.CommunityScheme_Sub>((Func<PCDF.CommunityScheme_Sub, bool>) (b => b.ID.Equals(SAP_Module.Proj.Dwellings[House].MainHeating.SEDBUK.ToString()))).ToList<PCDF.CommunityScheme_Sub>();
        if (communitySchemeSubList1.Count > 0)
        {
          if (communitySchemeSubList1[0].CommunityFuel.Equals("99"))
          {
            XMLobj.WriteStartElement("Fuel-Type");
            XMLobj.WriteValue(99);
            XMLobj.WriteEndElement();
          }
          else
          {
            XMLobj.WriteStartElement("Fuel-Type");
            XMLobj.WriteValue(PDFFunctions.CheckFuelCode(SAP_Module.Proj.Dwellings[House].MainHeating.Fuel));
            XMLobj.WriteEndElement();
          }
        }
        else
        {
          XMLobj.WriteStartElement("Fuel-Type");
          XMLobj.WriteValue(PDFFunctions.CheckFuelCode(SAP_Module.Proj.Dwellings[House].MainHeating.Fuel));
          XMLobj.WriteEndElement();
        }
        XMLobj.WriteStartElement("Heat-Fraction");
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].MainHeating.CommunityH.Boiler1HeatFraction);
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("Heat-Efficiency");
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].MainHeating.CommunityH.Boiler1Efficiency);
        XMLobj.WriteEndElement();
        if ((double) SAP_Module.Proj.Dwellings[House].MainHeating.CommunityH.HeatToPowerRatio > 0.0)
        {
          XMLobj.WriteStartElement("Power-Efficiency");
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].MainHeating.CommunityH.HeatToPowerRatio);
          XMLobj.WriteEndElement();
        }
        XMLobj.WriteEndElement();
        if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.NoOfAdditionalHeatSources > 0)
        {
          XMLobj.WriteStartElement("Community-Heat-Source");
          XMLobj.WriteStartElement("Heat-Source-Type");
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
              XMLobj.WriteStartElement("Fuel-Type");
              XMLobj.WriteValue(99);
              XMLobj.WriteEndElement();
            }
            else
            {
              XMLobj.WriteStartElement("Fuel-Type");
              XMLobj.WriteValue(PDFFunctions.CheckFuelCode(SAP_Module.Proj.Dwellings[House].MainHeating.CommunityH.HeatSource1.Fuel));
              XMLobj.WriteEndElement();
            }
          }
          else
          {
            XMLobj.WriteStartElement("Fuel-Type");
            XMLobj.WriteValue(PDFFunctions.CheckFuelCode(SAP_Module.Proj.Dwellings[House].MainHeating.CommunityH.HeatSource1.Fuel));
            XMLobj.WriteEndElement();
          }
          XMLobj.WriteStartElement("Heat-Fraction");
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].MainHeating.CommunityH.HeatSource1.HeatFraction);
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("Heat-Efficiency");
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].MainHeating.CommunityH.HeatSource1.Efficiency);
          XMLobj.WriteEndElement();
          XMLobj.WriteEndElement();
        }
        if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.NoOfAdditionalHeatSources > 1)
        {
          XMLobj.WriteStartElement("Community-Heat-Source");
          XMLobj.WriteStartElement("Heat-Source-Type");
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
              XMLobj.WriteStartElement("Fuel-Type");
              XMLobj.WriteValue(99);
              XMLobj.WriteEndElement();
            }
            else
            {
              XMLobj.WriteStartElement("Fuel-Type");
              XMLobj.WriteValue(PDFFunctions.CheckFuelCode(SAP_Module.Proj.Dwellings[House].MainHeating.CommunityH.HeatSource2.Fuel));
              XMLobj.WriteEndElement();
            }
          }
          else
          {
            XMLobj.WriteStartElement("Fuel-Type");
            XMLobj.WriteValue(PDFFunctions.CheckFuelCode(SAP_Module.Proj.Dwellings[House].MainHeating.CommunityH.HeatSource2.Fuel));
            XMLobj.WriteEndElement();
          }
          XMLobj.WriteStartElement("Heat-Fraction");
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].MainHeating.CommunityH.HeatSource2.HeatFraction);
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("Heat-Efficiency");
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].MainHeating.CommunityH.HeatSource2.Efficiency);
          XMLobj.WriteEndElement();
          XMLobj.WriteEndElement();
        }
        if (SAP_Module.Proj.Dwellings[House].MainHeating.CommunityH.NoOfAdditionalHeatSources > 2)
        {
          XMLobj.WriteStartElement("Community-Heat-Source");
          XMLobj.WriteStartElement("Heat-Source-Type");
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
              XMLobj.WriteStartElement("Fuel-Type");
              XMLobj.WriteValue(99);
              XMLobj.WriteEndElement();
            }
            else
            {
              XMLobj.WriteStartElement("Fuel-Type");
              XMLobj.WriteValue(PDFFunctions.CheckFuelCode(SAP_Module.Proj.Dwellings[House].MainHeating.CommunityH.HeatSource3.Fuel));
              XMLobj.WriteEndElement();
            }
          }
          else
          {
            XMLobj.WriteStartElement("Fuel-Type");
            XMLobj.WriteValue(PDFFunctions.CheckFuelCode(SAP_Module.Proj.Dwellings[House].MainHeating.CommunityH.HeatSource3.Fuel));
            XMLobj.WriteEndElement();
          }
          XMLobj.WriteStartElement("Heat-Fraction");
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].MainHeating.CommunityH.HeatSource3.HeatFraction);
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("Heat-Efficiency");
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].MainHeating.CommunityH.HeatSource3.Efficiency);
          XMLobj.WriteEndElement();
          XMLobj.WriteEndElement();
        }
        if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.NoOfAdditionalHeatSources > 3)
        {
          XMLobj.WriteStartElement("Community-Heat-Source");
          XMLobj.WriteStartElement("Heat-Source-Type");
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
              XMLobj.WriteStartElement("Fuel-Type");
              XMLobj.WriteValue(99);
              XMLobj.WriteEndElement();
            }
            else
            {
              XMLobj.WriteStartElement("Fuel-Type");
              XMLobj.WriteValue(PDFFunctions.CheckFuelCode(SAP_Module.Proj.Dwellings[House].MainHeating.CommunityH.HeatSource4.Fuel));
              XMLobj.WriteEndElement();
            }
          }
          else
          {
            XMLobj.WriteStartElement("Fuel-Type");
            XMLobj.WriteValue(PDFFunctions.CheckFuelCode(SAP_Module.Proj.Dwellings[House].MainHeating.CommunityH.HeatSource4.Fuel));
            XMLobj.WriteEndElement();
          }
          XMLobj.WriteStartElement("Heat-Fraction");
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].MainHeating.CommunityH.HeatSource4.HeatFraction);
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("Heat-Efficiency");
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].MainHeating.CommunityH.HeatSource4.Efficiency);
          XMLobj.WriteEndElement();
          XMLobj.WriteEndElement();
        }
        XMLobj.WriteEndElement();
        if (!string.IsNullOrEmpty(SAP_Module.Proj.Dwellings[House].Water.HWSComm.Charging))
        {
          XMLobj.WriteStartElement("Charging-Linked-To-Heat-Use");
          if (SAP_Module.Proj.Dwellings[House].Water.HWSComm.Charging.Contains("Charged"))
            XMLobj.WriteValue("true");
          else
            XMLobj.WriteValue("false");
          XMLobj.WriteEndElement();
        }
        XMLobj.WriteStartElement("Community-Heating-Distribution-Type");
        string heatDsystem = SAP_Module.Proj.Dwellings[House].MainHeating.CommunityH.HeatDSystem;
        // ISSUE: reference to a compiler-generated method
        switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(heatDsystem))
        {
          case 1158145841:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(heatDsystem, "Calculated", false) == 0)
            {
              XMLobj.WriteValue(5);
              goto default;
            }
            else
              goto default;
          case 1676941291:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(heatDsystem, "Piping<=1990, not pre-insulated, medium/high temp, full flow", false) == 0)
            {
              XMLobj.WriteValue(1);
              goto default;
            }
            else
              goto default;
          case 2166136261:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(heatDsystem, "", false) == 0)
              break;
            goto default;
          case 2475089181:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(heatDsystem, "Piping>=1991, pre-insulated, medium temp, variable flow", false) == 0)
            {
              XMLobj.WriteValue(3);
              goto default;
            }
            else
              goto default;
          case 3085999378:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(heatDsystem, "Piping<=1990, pre-insulated, low temp, full flow", false) == 0)
            {
              XMLobj.WriteValue(2);
              goto default;
            }
            else
              goto default;
          case 3424652889:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(heatDsystem, "Unknown", false) == 0)
              break;
            goto default;
          case 4232637720:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(heatDsystem, "Piping>=1991, pre-insulated, low temp, variable flow", false) == 0)
            {
              XMLobj.WriteValue(4);
              goto default;
            }
            else
              goto default;
          default:
label_94:
            XMLobj.WriteEndElement();
            if (SAP_Module.Proj.Dwellings[House].Water.SystemRef != 903)
            {
              XMLobj.WriteStartElement("Is-Community-Heating-Cylinder-In-Dwelling");
              if (SAP_Module.Proj.Dwellings[House].Water.HWSComm.CylinderInDwelling)
                XMLobj.WriteValue("true");
              else
                XMLobj.WriteValue("false");
              XMLobj.WriteEndElement();
            }
            if (!SAP_Module.Proj.Dwellings[House].Water.HWSComm.KnownLossFactor)
            {
              XMLobj.WriteEndElement();
              goto label_101;
            }
            else
              goto label_101;
        }
        XMLobj.WriteValue(6);
        goto label_94;
      }
label_101:
      int systemRef1 = SAP_Module.Proj.Dwellings[House].Water.SystemRef;
      bool flag3;
      if (systemRef1 >= 950 && systemRef1 <= 952)
      {
        if (!flag1)
          XMLobj.WriteStartElement("SAP-Community-Heating-Systems");
        flag3 = true;
        flag1 = true;
        XMLobj.WriteStartElement("SAP-Community-Heating-System");
        XMLobj.WriteStartElement("Community-Heating-Use");
        XMLobj.WriteValue(2);
        XMLobj.WriteEndElement();
        if (!string.IsNullOrEmpty(SAP_Module.Proj.Dwellings[House].Water.HWSComm.SystemRef))
        {
          XMLobj.WriteStartElement("Heat-Network-Index-Number");
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Water.HWSComm.SystemRef);
          XMLobj.WriteEndElement();
        }
        XMLobj.WriteStartElement("Community-Heat-Sources");
        XMLobj.WriteStartElement("Community-Heat-Source");
        XMLobj.WriteStartElement("Heat-Source-Type");
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
            XMLobj.WriteStartElement("Fuel-Type");
            XMLobj.WriteValue(99);
            XMLobj.WriteEndElement();
          }
          else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].Water.Fuel, "", false) == 0)
          {
            XMLobj.WriteStartElement("Fuel-Type");
            XMLobj.WriteValue(99);
            XMLobj.WriteEndElement();
          }
          else
          {
            XMLobj.WriteStartElement("Fuel-Type");
            XMLobj.WriteValue(PDFFunctions.CheckFuelCode(SAP_Module.Proj.Dwellings[House].Water.Fuel));
            XMLobj.WriteEndElement();
          }
        }
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].Water.Fuel, "", false) == 0)
        {
          XMLobj.WriteStartElement("Fuel-Type");
          XMLobj.WriteValue(99);
          XMLobj.WriteEndElement();
        }
        else
        {
          XMLobj.WriteStartElement("Fuel-Type");
          XMLobj.WriteValue(PDFFunctions.CheckFuelCode(SAP_Module.Proj.Dwellings[House].Water.Fuel));
          XMLobj.WriteEndElement();
        }
        XMLobj.WriteStartElement("Heat-Fraction");
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Water.HWSComm.Boiler1Fraction);
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("Heat-Efficiency");
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Water.HWSComm.Efficiency);
        XMLobj.WriteEndElement();
        XMLobj.WriteEndElement();
        if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.NoOfAdditionalHeatSources > 0)
        {
          XMLobj.WriteStartElement("Community-Heat-Source");
          XMLobj.WriteStartElement("Heat-Source-Type");
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
              XMLobj.WriteStartElement("Fuel-Type");
              XMLobj.WriteValue(99);
              XMLobj.WriteEndElement();
            }
            else
            {
              XMLobj.WriteStartElement("Fuel-Type");
              XMLobj.WriteValue(PDFFunctions.CheckFuelCode(SAP_Module.Proj.Dwellings[House].Water.HWSComm.HeatSource1.Fuel));
              XMLobj.WriteEndElement();
            }
          }
          else
          {
            XMLobj.WriteStartElement("Fuel-Type");
            XMLobj.WriteValue(PDFFunctions.CheckFuelCode(SAP_Module.Proj.Dwellings[House].Water.HWSComm.HeatSource1.Fuel));
            XMLobj.WriteEndElement();
          }
          XMLobj.WriteStartElement("Heat-Fraction");
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Water.HWSComm.HeatSource1.HeatFraction);
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("Heat-Efficiency");
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Water.HWSComm.HeatSource1.Efficiency);
          XMLobj.WriteEndElement();
          XMLobj.WriteEndElement();
        }
        if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.NoOfAdditionalHeatSources > 1)
        {
          XMLobj.WriteStartElement("Community-Heat-Source");
          XMLobj.WriteStartElement("Heat-Source-Type");
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
              XMLobj.WriteStartElement("Fuel-Type");
              XMLobj.WriteValue(99);
              XMLobj.WriteEndElement();
            }
            else
            {
              XMLobj.WriteStartElement("Fuel-Type");
              XMLobj.WriteValue(PDFFunctions.CheckFuelCode(SAP_Module.Proj.Dwellings[House].Water.HWSComm.HeatSource2.Fuel));
              XMLobj.WriteEndElement();
            }
          }
          else
          {
            XMLobj.WriteStartElement("Fuel-Type");
            XMLobj.WriteValue(PDFFunctions.CheckFuelCode(SAP_Module.Proj.Dwellings[House].Water.HWSComm.HeatSource2.Fuel));
            XMLobj.WriteEndElement();
          }
          XMLobj.WriteStartElement("Heat-Fraction");
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Water.HWSComm.HeatSource2.HeatFraction);
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("Heat-Efficiency");
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Water.HWSComm.HeatSource2.Efficiency);
          XMLobj.WriteEndElement();
          XMLobj.WriteEndElement();
        }
        if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.NoOfAdditionalHeatSources > 2)
        {
          XMLobj.WriteStartElement("Community-Heat-Source");
          XMLobj.WriteStartElement("Heat-Source-Type");
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
          XMLobj.WriteStartElement("Fuel-Type");
          XMLobj.WriteValue(PDFFunctions.CheckFuelCode(SAP_Module.Proj.Dwellings[House].Water.HWSComm.HeatSource3.Fuel));
          XMLobj.WriteEndElement();
          if (communitySchemeSubList1.Count > 0)
          {
            if (communitySchemeSubList1[3].CommunityFuel.Equals("99"))
            {
              XMLobj.WriteStartElement("Fuel-Type");
              XMLobj.WriteValue(99);
              XMLobj.WriteEndElement();
            }
            else
            {
              XMLobj.WriteStartElement("Fuel-Type");
              XMLobj.WriteValue(PDFFunctions.CheckFuelCode(SAP_Module.Proj.Dwellings[House].Water.HWSComm.HeatSource3.Fuel));
              XMLobj.WriteEndElement();
            }
          }
          else
          {
            XMLobj.WriteStartElement("Fuel-Type");
            XMLobj.WriteValue(PDFFunctions.CheckFuelCode(SAP_Module.Proj.Dwellings[House].Water.HWSComm.HeatSource3.Fuel));
            XMLobj.WriteEndElement();
          }
          XMLobj.WriteStartElement("Heat-Fraction");
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Water.HWSComm.HeatSource4.HeatFraction);
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("Heat-Efficiency");
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Water.HWSComm.HeatSource3.Efficiency);
          XMLobj.WriteEndElement();
          XMLobj.WriteEndElement();
        }
        if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.NoOfAdditionalHeatSources > 3)
        {
          XMLobj.WriteStartElement("Community-Heat-Source");
          XMLobj.WriteStartElement("Heat-Source-Type");
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
              XMLobj.WriteStartElement("Fuel-Type");
              XMLobj.WriteValue(99);
              XMLobj.WriteEndElement();
            }
            else
            {
              XMLobj.WriteStartElement("Fuel-Type");
              XMLobj.WriteValue(PDFFunctions.CheckFuelCode(SAP_Module.Proj.Dwellings[House].Water.HWSComm.HeatSource4.Fuel));
              XMLobj.WriteEndElement();
            }
          }
          else
          {
            XMLobj.WriteStartElement("Fuel-Type");
            XMLobj.WriteValue(PDFFunctions.CheckFuelCode(SAP_Module.Proj.Dwellings[House].Water.HWSComm.HeatSource4.Fuel));
            XMLobj.WriteEndElement();
          }
          XMLobj.WriteStartElement("Heat-Fraction");
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Water.HWSComm.HeatSource4.HeatFraction);
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("Heat-Efficiency");
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Water.HWSComm.HeatSource4.Efficiency);
          XMLobj.WriteEndElement();
          XMLobj.WriteEndElement();
        }
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("Community-Heating-Distribution-Type");
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
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(hds, "Calculated", false) == 0)
              {
                XMLobj.WriteValue(5);
                goto default;
              }
              else
                goto default;
            case 1676941291:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(hds, "Piping<=1990, not pre-insulated, medium/high temp, full flow", false) == 0)
              {
                XMLobj.WriteValue(1);
                goto default;
              }
              else
                goto default;
            case 2166136261:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(hds, "", false) == 0)
                break;
              goto default;
            case 2475089181:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(hds, "Piping>=1991, pre-insulated, medium temp, variable flow", false) == 0)
              {
                XMLobj.WriteValue(3);
                goto default;
              }
              else
                goto default;
            case 3085999378:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(hds, "Piping<=1990, pre-insulated, low temp, full flow", false) == 0)
              {
                XMLobj.WriteValue(2);
                goto default;
              }
              else
                goto default;
            case 3424652889:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(hds, "Unknown", false) == 0)
                break;
              goto default;
            case 4232637720:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(hds, "Piping>=1991, pre-insulated, low temp, variable flow", false) == 0)
              {
                XMLobj.WriteValue(4);
                goto default;
              }
              else
                goto default;
            default:
label_181:
              goto label_182;
          }
          XMLobj.WriteValue(6);
          goto label_181;
        }
label_182:
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
            if (XML2012._Closure\u0024__.\u0024I121\u002D1 != null)
            {
              // ISSUE: reference to a compiler-generated field
              predicate = XML2012._Closure\u0024__.\u0024I121\u002D1;
            }
            else
            {
              // ISSUE: reference to a compiler-generated field
              XML2012._Closure\u0024__.\u0024I121\u002D1 = predicate = (Func<PCDF.CommunityScheme, bool>) (b => b.ID.Equals(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SEDBUK));
            }
            PCDF.CommunityScheme communityScheme2 = communitySchemes.Where<PCDF.CommunityScheme>(predicate).SingleOrDefault<PCDF.CommunityScheme>();
            XMLobj.WriteStartElement("Community-Heating-Distribution-Loss-Factor");
            XMLobj.WriteValue(communityScheme2.DistributionLossFactor);
            XMLobj.WriteEndElement();
            XMLobj.WriteEndElement();
          }
          else if (SAP_Module.Proj.Dwellings[House].Water.HWSComm.KnownLossFactor)
          {
            XMLobj.WriteStartElement("Community-Heating-Distribution-Loss-Factor");
            XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Water.HWSComm.LossFactor);
            XMLobj.WriteEndElement();
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
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.InforSource, "Boiler Database", false) == 0)
        num = 1;
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.InforSource, "Manufacturer Declaration", false) == 0)
        num = 2;
      else
        num = 3;
    }

    private void _SecondaryHeating(XmlTextWriter XMLobj, int House, int Country)
    {
      XMLobj.WriteStartElement("Secondary-Heating-Category");
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].SecHeating.HGroup, "Room heaters", false) == 0)
        XMLobj.WriteValue(10);
      else
        XMLobj.WriteValue(1);
      XMLobj.WriteEndElement();
      XMLobj.WriteStartElement("Has-Fixed-Air-Conditioning");
      if (!SAP_Module.Proj.Dwellings[House].Cooling.Include)
        XMLobj.WriteValue("false");
      else
        XMLobj.WriteValue("true");
      XMLobj.WriteEndElement();
      if (SAP_Module.Proj.Dwellings[House].Water.SystemRef == 951)
      {
        XMLobj.WriteStartElement("Water-Heating-Code");
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Water.SystemRef);
        XMLobj.WriteEndElement();
      }
      else
      {
        XMLobj.WriteStartElement("Water-Heating-Code");
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
            XMLobj.WriteStartElement("Water-Fuel-Type");
            XMLobj.WriteValue(this.FuelCheck(SAP_Module.Proj.Dwellings[House].Water.Fuel, House));
            XMLobj.WriteEndElement();
          }
        }
        else
        {
          XMLobj.WriteStartElement("Water-Fuel-Type");
          XMLobj.WriteValue(this.FuelCheck(SAP_Module.Proj.Dwellings[House].Water.Fuel, House));
          XMLobj.WriteEndElement();
        }
      }
      if (SAP_Module.Proj.Dwellings[House].WaterOnlyHeatPump & SAP_Module.Proj.Dwellings[House].MainHeating2.HPOnly.HotWaterHP_Integral)
      {
        XMLobj.WriteStartElement("Has-Hot-Water-Cylinder", (string) null);
        XMLobj.WriteValue("false");
        XMLobj.WriteEndElement();
      }
      else
      {
        XMLobj.WriteStartElement("Has-Hot-Water-Cylinder", (string) null);
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
      string hgroup = SAP_Module.Proj.Dwellings[House].MainHeating.HGroup;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(hgroup, "Heat pumps with radiators or underfloor heating", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(hgroup, "Community heating schemes", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(hgroup, "Room heaters", false) != 0 && SAP_Module.Proj.Dwellings[House].Water.Thermal.Include)
      {
        XMLobj.WriteStartElement("Thermal-Store");
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
        XMLobj.WriteStartElement("Is-Immersion-For-Summer-Use");
        XMLobj.WriteValue("true");
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("Immersion-Heating-Type");
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].Water.Cylinder.Immersion, "Dual", false) == 0)
          XMLobj.WriteValue(1);
        else
          XMLobj.WriteValue(2);
        XMLobj.WriteEndElement();
      }
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.HPImmersion, "Yes", false) == 0)
      {
        XMLobj.WriteStartElement("Is-Immersion-For-Summer-Use");
        XMLobj.WriteValue("true");
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("Immersion-Heating-Type");
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].Water.Cylinder.Immersion, "Dual", false) == 0)
          XMLobj.WriteValue(1);
        else
          XMLobj.WriteValue(2);
        XMLobj.WriteEndElement();
      }
      else if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].Water.Cylinder.Immersion, "", false) > 0U && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].Water.Fuel, "Electricity", false) == 0)
      {
        if (SAP_Module.Proj.Dwellings[House].MainHeating.HGroup.Contains("Heat pumps") | SAP_Module.Proj.Dwellings[House].MainHeating.HGroup.Contains("Heat Pumps"))
        {
          XMLobj.WriteStartElement("Immersion-Heating-Type");
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].Water.Cylinder.Immersion, "Dual", false) == 0)
            XMLobj.WriteValue(1);
          else
            XMLobj.WriteValue(2);
          XMLobj.WriteEndElement();
        }
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.HGroup, "Community heating schemes", false) == 0)
        {
          XMLobj.WriteStartElement("Immersion-Heating-Type");
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].Water.Cylinder.Immersion, "Dual", false) == 0)
            XMLobj.WriteValue(1);
          else
            XMLobj.WriteValue(2);
          XMLobj.WriteEndElement();
        }
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.SGroup, "Gas boilers and oil boilers", false) == 0)
        {
          XMLobj.WriteStartElement("Immersion-Heating-Type");
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].Water.Cylinder.Immersion, "Dual", false) == 0)
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
            XMLobj.WriteStartElement("Immersion-Heating-Type");
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].Water.Cylinder.Immersion, "Dual", false) == 0)
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
      if (!((uint) SAP_Module.Proj.Dwellings[House].SecHeating.SAPTableCode > 0U & SAP_Module.Proj.Dwellings[House].SecHeating.SAPTableCode != 192) || (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].SecHeating.InforSource, "", false) <= 0U)
        return;
      XMLobj.WriteStartElement("Secondary-Heating-Data-Source");
      if (SAP_Module.Proj.Dwellings[House].SecHeating.InforSource.Contains("anu"))
        XMLobj.WriteValue(2);
      else
        XMLobj.WriteValue(3);
      XMLobj.WriteEndElement();
      string inforSource = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.InforSource;
      XMLobj.WriteStartElement("Secondary-Fuel-Type");
      XMLobj.WriteValue(this.FuelCheck(SAP_Module.Proj.Dwellings[House].SecHeating.Fuel, House));
      XMLobj.WriteEndElement();
      if (!SAP_Module.Proj.Dwellings[House].SecHeating.InforSource.Contains("anu"))
      {
        XMLobj.WriteStartElement("Secondary-Heating-Code");
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].SecHeating.SAPTableCode);
        XMLobj.WriteEndElement();
        int sapTableCode = SAP_Module.Proj.Dwellings[House].SecHeating.SAPTableCode;
        if (sapTableCode >= 631 && sapTableCode <= 636)
        {
          XMLobj.WriteStartElement("Is-Secondary-Heating-HETAS-Approved");
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].SecHeating.HETAS, "Yes", false) == 0)
            XMLobj.WriteValue("true");
          else
            XMLobj.WriteValue("false");
          XMLobj.WriteEndElement();
        }
        if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].SecHeating.FlueType, "", false) > 0U)
        {
          XMLobj.WriteStartElement("Secondary-Heating-Flue-Type");
          string flueType = SAP_Module.Proj.Dwellings[House].SecHeating.FlueType;
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(flueType, "Open", false) != 0)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(flueType, "Chimney", false) != 0)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(flueType, "Room-sealed", false) != 0)
              {
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(flueType, "Unknown", false) == 0)
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
        XMLobj.WriteStartElement("Secondary-Heating-Declared-Values");
        XMLobj.WriteStartElement("Make-Model");
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].SecHeating.MDescription);
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("Test-Method");
        if (SAP_Module.Proj.Dwellings[House].SecHeating.TestMethod == null)
          SAP_Module.Proj.Dwellings[House].SecHeating.TestMethod = "";
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].SecHeating.TestMethod);
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("Efficiency");
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].SecHeating.SecEff);
        XMLobj.WriteEndElement();
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("Secondary-Heating-Flue-Type");
        string flueType = SAP_Module.Proj.Dwellings[House].SecHeating.FlueType;
        // ISSUE: reference to a compiler-generated method
        switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(flueType))
        {
          case 572081497:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(flueType, "omitted", false) == 0)
              goto label_114;
            else
              goto default;
          case 1401622761:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(flueType, "Open", false) == 0)
              break;
            goto default;
          case 1533154807:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(flueType, "balanced flue", false) == 0)
              goto label_112;
            else
              goto default;
          case 1537289947:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(flueType, "open flue", false) == 0)
              break;
            goto default;
          case 1708018833:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(flueType, "Room-sealed", false) == 0)
              goto label_112;
            else
              goto default;
          case 1845819738:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(flueType, "unknown (there is a flue, but its type could not be determined)", false) == 0)
              goto label_115;
            else
              goto default;
          case 2166136261:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(flueType, "", false) == 0)
              goto label_114;
            else
              goto default;
          case 2391940020:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(flueType, "Chimney", false) == 0)
            {
              XMLobj.WriteValue(3);
              goto label_117;
            }
            else
              goto default;
          case 3424652889:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(flueType, "Unknown", false) == 0)
              goto label_115;
            else
              goto default;
          default:
            XMLobj.WriteValue(1);
            goto label_117;
        }
        XMLobj.WriteValue(1);
        goto label_117;
label_112:
        XMLobj.WriteValue(2);
        goto label_117;
label_114:
        XMLobj.WriteValue(4);
        goto label_117;
label_115:
        XMLobj.WriteValue(5);
label_117:
        XMLobj.WriteEndElement();
      }
    }

    private void _WaterHeating(XmlTextWriter XMLobj, int House, int Country)
    {
      bool flag1;
      try
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.InforSource, "Boiler Database", false) == 0 && this.IsCombi(SAP_Module.Proj.Dwellings[House]))
          flag1 = true;
        if (SAP_Module.Proj.Dwellings[House].WaterOnlyHeatPump & SAP_Module.Proj.Dwellings[House].MainHeating2.HPOnly.HotWaterHP_Integral)
          flag1 = true;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      if (!flag1 && (double) SAP_Module.Proj.Dwellings[House].Water.Cylinder.Volume != 0.0)
      {
        XMLobj.WriteStartElement("Hot-Water-Store-Size");
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Water.Cylinder.Volume);
        XMLobj.WriteEndElement();
        bool flag2 = false;
        if (SAP_Module.Proj.Dwellings[House].MainHeating.SGroup.Contains("heat pumps") & SAP_Module.Proj.Dwellings[House].Water.SystemRef == 901 | SAP_Module.Proj.Dwellings[House].MainHeating.SGroup.Contains("heat pumps") & SAP_Module.Proj.Dwellings[House].Water.SystemRef == 903 | SAP_Module.Proj.Dwellings[House].WaterOnlyHeatPump && (double) SAP_Module.Proj.Dwellings[House].Water.Cylinder.HPExchanger > 0.0)
        {
          XMLobj.WriteStartElement("Hot-Water-Store-Heat-Transfer-Area");
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Water.Cylinder.HPExchanger);
          XMLobj.WriteEndElement();
          flag2 = true;
        }
        if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].IncludeMainHeating2 & !flag2 && SAP_Module.Proj.Dwellings[House].MainHeating2.SGroup.Contains("heat pumps") & SAP_Module.Proj.Dwellings[House].Water.SystemRef == 901 | SAP_Module.Proj.Dwellings[House].MainHeating2.SGroup.Contains("heat pumps") & SAP_Module.Proj.Dwellings[House].Water.SystemRef == 903 | SAP_Module.Proj.Dwellings[House].WaterOnlyHeatPump)
        {
          XMLobj.WriteStartElement("Hot-Water-Store-Heat-Transfer-Area");
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Water.Cylinder.HPExchanger);
          XMLobj.WriteEndElement();
        }
        bool flag3 = false;
        if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Thermal.Include | (double) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.Volume > 0.0)
          ;
        string hgroup = SAP_Module.Proj.Dwellings[House].MainHeating.HGroup;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(hgroup, "Heat pumps with radiators or underfloor heating", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(hgroup, "Community heating schemes", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(hgroup, "Room heaters", false) != 0)
          flag3 = true;
        if (this.IsCombi(SAP_Module.Proj.Dwellings[House]) & SAP_Module.Proj.Dwellings[House].MainHeating.InforSource.Contains("Database"))
          flag3 = false;
        if (this.IsCombi(SAP_Module.Proj.Dwellings[House]) & SAP_Module.Proj.Dwellings[House].MainHeating.InforSource.Contains("SAP"))
          flag3 = false;
        bool flag4;
        if (flag3 && !this.IsCombi(SAP_Module.Proj.Dwellings[House]) & (double) SAP_Module.Proj.Dwellings[House].Water.Cylinder.Volume > 0.0)
          flag4 = true;
        if ((double) SAP_Module.Proj.Dwellings[House].Water.Cylinder.Volume > 0.0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.HGroup, "Community heating schemes", false) == 0 & SAP_Module.Proj.Dwellings[House].Water.SystemRef == 903)
          flag4 = true;
        if (SAP_Module.Proj.Dwellings[House].Water.HWSComm.CylinderInDwelling)
          flag4 = true;
        if (SAP_Module.Proj.Dwellings[House].WaterOnlyHeatPump & !SAP_Module.Proj.Dwellings[House].MainHeating2.HPOnly.HotWaterHP_Integral & SAP_Module.Proj.Dwellings[House].Water.SystemRef == 914)
          flag4 = true;
        bool flag5 = false;
        if ((double) SAP_Module.Proj.Dwellings[House].Water.Cylinder.DeclaredLoss != 0.0)
        {
          XMLobj.WriteStartElement("Hot-Water-Store-Heat-Loss-Source");
          XMLobj.WriteValue(2);
          XMLobj.WriteEndElement();
        }
        else
        {
          XMLobj.WriteStartElement("Hot-Water-Store-Heat-Loss-Source");
          XMLobj.WriteValue(3);
          XMLobj.WriteEndElement();
        }
        if (!flag1)
        {
          if ((double) SAP_Module.Proj.Dwellings[House].Water.Cylinder.Volume > 0.0 & SAP_Module.Proj.Dwellings[House].Water.SystemRef == 903)
            flag5 = true;
          if (SAP_Module.Proj.Dwellings[House].Water.HWSComm.CylinderInDwelling)
            flag5 = true;
          if (SAP_Module.Proj.Dwellings[House].WaterOnlyHeatPump & !SAP_Module.Proj.Dwellings[House].MainHeating2.HPOnly.HotWaterHP_Integral & SAP_Module.Proj.Dwellings[House].Water.SystemRef == 914 & (double) SAP_Module.Proj.Dwellings[House].Water.Cylinder.InsThick > 0.0)
            flag5 = true;
          if (flag5)
          {
            XMLobj.WriteStartElement("Hot-Water-Store-Insulation-Type");
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].Water.Cylinder.Insulation, "Factory", false) == 0)
              XMLobj.WriteValue(1);
            else
              XMLobj.WriteValue(2);
            XMLobj.WriteEndElement();
            if ((double) SAP_Module.Proj.Dwellings[House].Water.Cylinder.InsThick > 0.0)
            {
              XMLobj.WriteStartElement("Hot-Water-Store-Insulation-Thickness");
              XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Water.Cylinder.InsThick);
              XMLobj.WriteEndElement();
            }
          }
        }
      }
      bool flag6;
      try
      {
        flag6 = !this.IsCombi(SAP_Module.Proj.Dwellings[House]);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      if (SAP_Module.Proj.Dwellings[House].Water.Thermal.Include & !flag6 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.BSubGroup, "Combined Primary Storage Units (CPSU) (mains gas and LPG)", false) == 0)
      {
        XMLobj.WriteStartElement("Is-Thermal-Store-Near-Boiler");
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].Water.Thermal.Connection, "> 1.5 m of primary pipework", false) == 0)
          XMLobj.WriteValue("false");
        else
          XMLobj.WriteValue("true");
        XMLobj.WriteEndElement();
      }
      if (SAP_Module.Proj.Dwellings[House].Water.Thermal.Include & !flag6 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.BSubGroup, "Combined Primary Storage Units (CPSU) (mains gas and LPG)", false) == 0)
      {
        XMLobj.WriteStartElement("Primary-Pipework-Insulation");
        string workInsulationType = SAP_Module.Proj.Dwellings[House].Water.Cylinder.PipeWorkInsulationType;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(workInsulationType, "Fully insulated primary pipework", false) != 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(workInsulationType, "First 1m from cylinder insulated", false) != 0)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(workInsulationType, "All accessible pipework insulated", false) == 0)
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
      else if (SAP_Module.Proj.Dwellings[House].WaterOnlyHeatPump & !SAP_Module.Proj.Dwellings[House].MainHeating2.HPOnly.HotWaterHP_Integral & SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.SystemRef == 914)
      {
        XMLobj.WriteStartElement("Primary-Pipework-Insulation");
        string workInsulationType = SAP_Module.Proj.Dwellings[House].Water.Cylinder.PipeWorkInsulationType;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(workInsulationType, "Fully insulated primary pipework", false) != 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(workInsulationType, "First 1m from cylinder insulated", false) != 0)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(workInsulationType, "All accessible pipework insulated", false) == 0)
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
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.HGroup, "Community heating schemes", false) == 0 | SAP_Module.Proj.Dwellings[House].Water.SystemRef == 950)
        {
          bool flag7 = false;
          if (SAP_Module.Proj.Dwellings[House].Water.HWSComm.CylinderInDwelling)
            flag7 = true;
          if ((double) SAP_Module.Proj.Dwellings[House].Water.Cylinder.Volume > 0.0 & SAP_Module.Proj.Dwellings[House].Water.SystemRef == 903)
            flag7 = true;
          if (SAP_Module.Proj.Dwellings[House].WaterOnlyHeatPump & !SAP_Module.Proj.Dwellings[House].MainHeating2.HPOnly.HotWaterHP_Integral)
            flag7 = true;
          if (flag7)
          {
            XMLobj.WriteStartElement("Has-Cylinder-Thermostat");
            XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Water.Cylinder.Thermostat);
            XMLobj.WriteEndElement();
            if (!this.isCPSU(0) & !SAP_Module.Proj.Dwellings[House].Water.HWSComm.CylinderInDwelling)
            {
              XMLobj.WriteStartElement("Is-Cylinder-In-Heated-Space");
              XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Water.Cylinder.InHeatedSpace);
              XMLobj.WriteEndElement();
            }
            if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.HGroup, "Community heating schemes", false) > 0U && SAP_Module.Proj.Dwellings[House].Water.Thermal.Include & !flag6 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.BSubGroup, "Combined Primary Storage Units (CPSU) (mains gas and LPG)", false) == 0)
            {
              XMLobj.WriteStartElement("Is-Hot-Water-Separately-Timed");
              XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Water.Cylinder.Timed);
              XMLobj.WriteEndElement();
            }
          }
        }
        else
        {
          if (SAP_Module.Proj.Dwellings[House].WaterOnlyHeatPump)
          {
            if (!SAP_Module.Proj.Dwellings[House].MainHeating2.HPOnly.HotWaterHP_Integral)
            {
              XMLobj.WriteStartElement("Has-Cylinder-Thermostat");
              XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Water.Cylinder.Thermostat);
              XMLobj.WriteEndElement();
              if (!this.isCPSU(0))
              {
                XMLobj.WriteStartElement("Is-Cylinder-In-Heated-Space");
                XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Water.Cylinder.InHeatedSpace);
                XMLobj.WriteEndElement();
              }
            }
          }
          else
          {
            XMLobj.WriteStartElement("Has-Cylinder-Thermostat");
            XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Water.Cylinder.Thermostat);
            XMLobj.WriteEndElement();
            if (!this.isCPSU(0))
            {
              XMLobj.WriteStartElement("Is-Cylinder-In-Heated-Space");
              XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Water.Cylinder.InHeatedSpace);
              XMLobj.WriteEndElement();
            }
          }
          if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.HGroup, "Community heating schemes", false) > 0U)
          {
            if (SAP_Module.Proj.Dwellings[House].Water.Thermal.Include & !flag6 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.BSubGroup, "Combined Primary Storage Units (CPSU) (mains gas and LPG)", false) == 0)
            {
              XMLobj.WriteStartElement("Is-Hot-Water-Separately-Timed");
              XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Water.Cylinder.Timed);
              XMLobj.WriteEndElement();
            }
            else if (SAP_Module.Proj.Dwellings[House].WaterOnlyHeatPump && !SAP_Module.Proj.Dwellings[House].MainHeating2.HPOnly.HotWaterHP_Integral)
            {
              XMLobj.WriteStartElement("Is-Hot-Water-Separately-Timed");
              XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Water.Cylinder.Timed);
              XMLobj.WriteEndElement();
            }
          }
        }
      }
      string hgroup1 = SAP_Module.Proj.Dwellings[House].MainHeating.HGroup;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(hgroup1, "Heat pumps with radiators or underfloor heating", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(hgroup1, "Community heating schemes", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(hgroup1, "Room heaters", false) != 0 && this.isCPSU(0))
      {
        string inforSource = SAP_Module.Proj.Dwellings[House].MainHeating.InforSource;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(inforSource, "SAP Tables", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(inforSource, "Manufacturer Declaration", false) != 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(inforSource, "Boiler Database", false) == 0)
          {
            PCDF.SEDBUK sedbuk = SAP_Module.PCDFData.Boilers.Where<PCDF.SEDBUK>((Func<PCDF.SEDBUK, bool>) (b => b.ID.ToUpper().Equals(SAP_Module.Proj.Dwellings[House].MainHeating.SEDBUK.ToUpper()))).SingleOrDefault<PCDF.SEDBUK>();
            if (sedbuk != null && sedbuk.MainType.Equals("1"))
            {
              XMLobj.WriteStartElement("Is-Thermal-Store-Or-CPSU-In-Airing-Cupboard");
              if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].Water.Thermal.Location, "Not in an airing cupboard", false) > 0U | (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].Water.Thermal.Location, "", false) > 0U)
                XMLobj.WriteValue("true");
              else
                XMLobj.WriteValue("false");
              XMLobj.WriteEndElement();
            }
          }
        }
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.BSubGroup, "Combined Primary Storage Units (CPSU) (mains gas and LPG)", false) == 0)
        {
          if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].Water.Thermal.Location, "Not in an airing cupboard", false) > 0U | (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].Water.Thermal.Location, "", false) > 0U)
          {
            XMLobj.WriteStartElement("Is-Thermal-Store-Or-CPSU-In-Airing-Cupboard");
            XMLobj.WriteValue("true");
          }
          else
            XMLobj.WriteValue("false");
          XMLobj.WriteEndElement();
        }
      }
      if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.HGroup, "Heat pumps with radiators or underfloor heating", false) <= 0U && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.HGroup, "Community heating schemes", false) == 0 & (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.InforSource, "Boiler Database", false) > 0U && !this.IsCombi(SAP_Module.Proj.Dwellings[House]))
      {
        XMLobj.WriteStartElement("Has-Cylinder-Thermostat");
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Water.Cylinder.Thermostat);
        XMLobj.WriteEndElement();
        if (!this.isCPSU(0))
        {
          XMLobj.WriteStartElement("Is-Cylinder-In-Heated-Space");
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Water.Cylinder.InHeatedSpace);
          XMLobj.WriteEndElement();
        }
      }
      if (SAP_Module.Proj.Dwellings[House].WaterOnlyHeatPump)
      {
        if (!SAP_Module.Proj.Dwellings[House].MainHeating2.HPOnly.HotWaterHP_Integral & SAP_Module.Proj.Dwellings[House].Water.SystemRef == 914 && (double) SAP_Module.Proj.Dwellings[House].Water.Cylinder.DeclaredLoss > 0.0)
        {
          XMLobj.WriteStartElement("Hot-Water-Store-Heat-Loss");
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Water.Cylinder.DeclaredLoss);
          XMLobj.WriteEndElement();
        }
      }
      else if ((double) SAP_Module.Proj.Dwellings[House].Water.Cylinder.DeclaredLoss > 0.0)
      {
        XMLobj.WriteStartElement("Hot-Water-Store-Heat-Loss");
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Water.Cylinder.DeclaredLoss);
        XMLobj.WriteEndElement();
      }
      int sapTableCode = SAP_Module.Proj.Dwellings[House].MainHeating.SAPTableCode;
      if (sapTableCode >= 401 && sapTableCode <= 425 || !SAP_Module.Proj.Dwellings[House].LessThan125Litre)
        return;
      XMLobj.WriteStartElement("SAP-Heating-Design-Water-Use");
      XMLobj.WriteValue(1);
      XMLobj.WriteEndElement();
    }

    private void _WaterHeatingWWHRS(XmlTextWriter XMLobj, int House, int Country)
    {
      // ISSUE: variable of a compiler-generated type
      XML2012._Closure\u0024__124\u002D0 closure1240_1;
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      XML2012._Closure\u0024__124\u002D0 closure1240_2 = new XML2012._Closure\u0024__124\u002D0(closure1240_1);
      // ISSUE: reference to a compiler-generated field
      closure1240_2.\u0024VB\u0024Local_House = House;
      // ISSUE: reference to a compiler-generated field
      if (!SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].Water.WWHRS.Include)
        return;
      bool flag;
      // ISSUE: reference to a compiler-generated field
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating.InforSource, "Boiler Database", false) == 0)
      {
        // ISSUE: reference to a compiler-generated method
        PCDF.SEDBUK sedbuk = SAP_Module.PCDFData.Boilers.Where<PCDF.SEDBUK>(new Func<PCDF.SEDBUK, bool>(closure1240_2._Lambda\u0024__0)).SingleOrDefault<PCDF.SEDBUK>();
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
        switch (SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].MainHeating.SAPTableCode)
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
      if (SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].Water.Thermal.Include)
        flag = false;
      // ISSUE: reference to a compiler-generated field
      int num1 = checked (SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].Water.WWHRS.Systems.Length - 1);
      int index1 = 0;
      while (index1 <= num1)
      {
        // ISSUE: reference to a compiler-generated field
        flag = (double) SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].Water.WWHRS.Systems[index1].DedicatedStorage > 0.0;
        checked { ++index1; }
      }
      try
      {
        // ISSUE: reference to a compiler-generated field
        if (SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].Water.WWHRS.Include)
        {
          // ISSUE: reference to a compiler-generated field
          int num2 = checked (SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].Water.WWHRS.Systems.Length - 1);
          int index2 = 0;
          while (index2 <= num2)
          {
            // ISSUE: reference to a compiler-generated field
            if ((double) SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].Water.WWHRS.Systems[index2].DedicatedStorage > 0.0)
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
        XMLobj.WriteStartElement("Storage-WWHRS");
        XMLobj.WriteStartElement("WWHRS-Index-Number");
        // ISSUE: reference to a compiler-generated field
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].Water.WWHRS.Systems[0].SystemsRef);
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("Total-Showers-And-Baths");
        // ISSUE: reference to a compiler-generated field
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].Water.WWHRS.TotalRooms);
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("Baths-And-Showers-To-WWHRS");
        // ISSUE: reference to a compiler-generated field
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].Water.WWHRS.Systems[0].WithBath);
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("WWHRS-Store-Volume");
        // ISSUE: reference to a compiler-generated field
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].Water.WWHRS.Systems[0].DedicatedStorage);
        XMLobj.WriteEndElement();
        XMLobj.WriteEndElement();
      }
      else
      {
        XMLobj.WriteStartElement("Instantaneous-WWHRS");
        XMLobj.WriteStartElement("WWHRS-Index-Number1");
        // ISSUE: reference to a compiler-generated field
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].Water.WWHRS.Systems[0].SystemsRef);
        XMLobj.WriteEndElement();
        // ISSUE: reference to a compiler-generated field
        if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].Water.WWHRS.Systems[1].SystemsRef, "", false) > 0U)
        {
          XMLobj.WriteStartElement("WWHRS-Index-Number2");
          // ISSUE: reference to a compiler-generated field
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].Water.WWHRS.Systems[1].SystemsRef);
          XMLobj.WriteEndElement();
        }
        XMLobj.WriteStartElement("Rooms-With-Bath-And-Or-Shower");
        // ISSUE: reference to a compiler-generated field
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].Water.WWHRS.TotalRooms);
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("Mixer-Showers-With-System1-With-Bath");
        // ISSUE: reference to a compiler-generated field
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].Water.WWHRS.Systems[0].WithBath);
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("Mixer-Showers-With-System1-Without-Bath");
        // ISSUE: reference to a compiler-generated field
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].Water.WWHRS.Systems[0].WithNoBath);
        XMLobj.WriteEndElement();
        // ISSUE: reference to a compiler-generated field
        if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].Water.WWHRS.Systems[1].SystemsRef, "", false) > 0U)
        {
          XMLobj.WriteStartElement("Mixer-Showers-With-System2-With-Bath");
          // ISSUE: reference to a compiler-generated field
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].Water.WWHRS.Systems[1].WithBath);
          XMLobj.WriteEndElement();
        }
        // ISSUE: reference to a compiler-generated field
        if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].Water.WWHRS.Systems[1].SystemsRef, "", false) > 0U)
        {
          XMLobj.WriteStartElement("Mixer-Showers-With-System2-Without-Bath");
          // ISSUE: reference to a compiler-generated field
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[closure1240_2.\u0024VB\u0024Local_House].Water.WWHRS.Systems[1].WithNoBath);
          XMLobj.WriteEndElement();
        }
        XMLobj.WriteEndElement();
      }
    }

    private void _WaterHeatingSolar(XmlTextWriter XMLobj, int House, int Country)
    {
      if (!SAP_Module.Proj.Dwellings[House].Water.Solar.Inlcude)
        return;
      XMLobj.WriteStartElement("Solar-Heating-Details");
      XMLobj.WriteStartElement("Solar-Panel-Aperture-Area");
      XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Water.Solar.SolarArea);
      XMLobj.WriteEndElement();
      XMLobj.WriteStartElement("Solar-Panel-Collector-Type");
      string solarType = SAP_Module.Proj.Dwellings[House].Water.Solar.SolarType;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(solarType, "Unglazed", false) != 0)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(solarType, "Flat plate", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(solarType, "Flat plate, glazed", false) != 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(solarType, "Evacuated tube", false) == 0)
            XMLobj.WriteValue(3);
        }
        else
          XMLobj.WriteValue(2);
      }
      else
        XMLobj.WriteValue(1);
      XMLobj.WriteEndElement();
      XMLobj.WriteStartElement("Solar-Panel-Collector-Data-Source");
      if (SAP_Module.Proj.Dwellings[House].Water.Solar.Overide)
        XMLobj.WriteValue(2);
      else
        XMLobj.WriteValue(1);
      XMLobj.WriteEndElement();
      if (SAP_Module.Proj.Dwellings[House].Water.Solar.Overide)
      {
        XMLobj.WriteStartElement("Solar-Panel-Collector-Zero-Loss-Efficiency");
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Water.Solar.SolarZero * 100f);
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("Solar-Panel-Collector-Linear-Heat-Loss-Coefficient");
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Water.Solar.SolarHLoss);
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("Solar-Panel-Collector-Second-Order-Heat-Loss-Coefficient");
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Water.Solar.SolarHLoss2);
        XMLobj.WriteEndElement();
      }
      XMLobj.WriteStartElement("Solar-Panel-Collector-Orientation");
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].Water.Solar.SolarTilt, "Horizontal", false) == 0)
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
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(solarOrientation, "SE/SW", false) == 0)
              break;
            goto default;
          case 1128440633:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(solarOrientation, "North East", false) == 0)
              goto label_31;
            else
              goto default;
          case 1409318971:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(solarOrientation, "North West", false) == 0)
            {
              XMLobj.WriteValue(8);
              goto default;
            }
            else
              goto default;
          case 1682370166:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(solarOrientation, "NE/NW", false) == 0)
              goto label_31;
            else
              goto default;
          case 1731397980:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(solarOrientation, "East", false) == 0)
            {
              XMLobj.WriteValue(3);
              goto default;
            }
            else
              goto default;
          case 1734234020:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(solarOrientation, "North", false) == 0)
            {
              XMLobj.WriteValue(1);
              goto default;
            }
            else
              goto default;
          case 1796576718:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(solarOrientation, "West", false) == 0)
              goto label_30;
            else
              goto default;
          case 2417407149:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(solarOrientation, "South West", false) == 0)
            {
              XMLobj.WriteValue(4);
              goto default;
            }
            else
              goto default;
          case 2853841879:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(solarOrientation, "South East", false) == 0)
              break;
            goto default;
          case 3017973530:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(solarOrientation, "South", false) == 0)
            {
              XMLobj.WriteValue(5);
              goto default;
            }
            else
              goto default;
          case 4260797214:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(solarOrientation, "E/W", false) == 0)
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
      XMLobj.WriteStartElement("Solar-Panel-Collector-Pitch");
      string solarTilt = SAP_Module.Proj.Dwellings[House].Water.Solar.SolarTilt;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(solarTilt, "Horizontal", false) != 0)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(solarTilt, "30°", false) != 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(solarTilt, "45°", false) != 0)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(solarTilt, "60°", false) != 0)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(solarTilt, "Vertical", false) == 0)
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
      XMLobj.WriteStartElement("Solar-Panel-Collector-Overshading");
      string solarOvershading = SAP_Module.Proj.Dwellings[House].Water.Solar.SolarOvershading;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(solarOvershading, "None or Very Little (<20%)", false) != 0)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(solarOvershading, "Modest (20% - 60%)", false) != 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(solarOvershading, "Significant (>60% - 80%)", false) != 0)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(solarOvershading, "Heavy (>80%)", false) == 0)
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
      XMLobj.WriteStartElement("Has-Solar-Powered-Pump");
      XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Water.Solar.Pumped);
      XMLobj.WriteEndElement();
      XMLobj.WriteStartElement("Solar-Store-Volume");
      XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Water.Solar.SolarVolume);
      XMLobj.WriteEndElement();
      XMLobj.WriteStartElement("Is-Solar-Store-Combined-Cylinder");
      XMLobj.WriteValue(!SAP_Module.Proj.Dwellings[House].Water.Solar.SolarSeperate);
      XMLobj.WriteEndElement();
      XMLobj.WriteStartElement("Shower-Types");
      string showerType = SAP_Module.Proj.Dwellings[House].Water.Solar.ShowerType;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(showerType, "Non-electric shower(s) only", false) != 0)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(showerType, "Electric shower(s) only", false) != 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(showerType, "Both electric and non-electric showers", false) != 0)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(showerType, "No shower (bath only)", false) == 0)
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
      XMLobj.WriteStartElement("SAP-Heating");
      XMLobj.WriteStartElement("Main-Heating-Details");
      this._HeatingMain1(XMLobj, House, Country);
      this._HeatingMain2(XMLobj, House, Country);
      XMLobj.WriteEndElement();
      if (SAP_Module.Proj.Dwellings[House].IncludeMainHeating2)
      {
        XMLobj.WriteStartElement("Main-Heating-Systems-Interaction");
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
      int num = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.InforSource, "Boiler Database", false) != 0 ? (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.InforSource, "Manufacturer Declaration", false) != 0 ? 3 : 2) : 1;
      if (!SAP_Module.Proj.Dwellings[House].Cooling.Include)
        return;
      XMLobj.WriteStartElement("SAP-Cooling");
      XMLobj.WriteStartElement("Cooled-Area");
      XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Cooling.Cooled_Area);
      XMLobj.WriteEndElement();
      XMLobj.WriteStartElement("Cooling-System-Data-Source");
      XMLobj.WriteValue(3);
      XMLobj.WriteEndElement();
      XMLobj.WriteStartElement("Cooling-System-Type");
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].Cooling.SystemType, "Split/multiple systems", false) == 0)
        XMLobj.WriteValue(1);
      else
        XMLobj.WriteValue(2);
      XMLobj.WriteEndElement();
      if (SAP_Module.Proj.Dwellings[House].Cooling.ERRMeasuredInclude)
      {
        XMLobj.WriteStartElement("Cooling-System-EER");
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Cooling.ERR);
        XMLobj.WriteEndElement();
      }
      else
      {
        XMLobj.WriteStartElement("Cooling-System-Class");
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].Cooling.Energylabel, "Unknown", false) == 0)
          XMLobj.WriteValue("ND");
        else
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Cooling.Energylabel);
        XMLobj.WriteEndElement();
      }
      XMLobj.WriteStartElement("Cooling-System-Control");
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].Cooling.Compressorcontrol, "Systems with On/Off control", false) == 0)
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
      XMLobj.WriteStartElement("SAP-Energy-Source");
      if (SAP_Module.Proj.Dwellings[House].Renewable.Photovoltaic.Inlcude)
      {
        XMLobj.WriteStartElement("PV-Arrays");
        int num = checked (SAP_Module.Proj.Dwellings[House].Renewable.Photovoltaic.Photovoltaics.Length - 1);
        int index = 0;
        while (index <= num)
        {
          XMLobj.WriteStartElement("PV-Array");
          XMLobj.WriteStartElement("Peak-Power");
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Renewable.Photovoltaic.Photovoltaics[index].PPower);
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("Orientation");
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].Renewable.Photovoltaic.Photovoltaics[index].PTilt, "Horizontal", false) == 0)
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
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(pcOrientation, "SE/SW", false) == 0)
                  break;
                goto default;
              case 1128440633:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(pcOrientation, "North East", false) == 0)
                {
                  XMLobj.WriteValue(2);
                  goto default;
                }
                else
                  goto default;
              case 1409318971:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(pcOrientation, "North West", false) == 0)
                  goto label_22;
                else
                  goto default;
              case 1682370166:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(pcOrientation, "NE/NW", false) == 0)
                  goto label_22;
                else
                  goto default;
              case 1731397980:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(pcOrientation, "East", false) == 0)
                  goto label_19;
                else
                  goto default;
              case 1734234020:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(pcOrientation, "North", false) == 0)
                {
                  XMLobj.WriteValue(1);
                  goto default;
                }
                else
                  goto default;
              case 1796576718:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(pcOrientation, "West", false) == 0)
                {
                  XMLobj.WriteValue(7);
                  goto default;
                }
                else
                  goto default;
              case 2417407149:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(pcOrientation, "South West", false) == 0)
                {
                  XMLobj.WriteValue(6);
                  goto default;
                }
                else
                  goto default;
              case 2853841879:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(pcOrientation, "South East", false) == 0)
                  break;
                goto default;
              case 3017973530:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(pcOrientation, "South", false) == 0)
                {
                  XMLobj.WriteValue(5);
                  goto default;
                }
                else
                  goto default;
              case 4260797214:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(pcOrientation, "E/W", false) == 0)
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
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(ptilt, "Horizontal", false) != 0)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(ptilt, "30°", false) != 0)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(ptilt, "45°", false) != 0)
              {
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(ptilt, "60°", false) != 0)
                {
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(ptilt, "Vertical", false) == 0)
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
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(povershading, "Heavy", false) != 0)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(povershading, "Significant", false) != 0)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(povershading, "Modest", false) != 0)
              {
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(povershading, "None or very little", false) == 0)
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
          XMLobj.WriteStartElement("PV-Connection");
          if (SAP_Module.Proj.Dwellings[House].Renewable.Photovoltaic.Photovoltaics[0].DirectlyConnected)
          {
            XMLobj.WriteValue(2);
          }
          else
          {
            string flatConnection = SAP_Module.Proj.Dwellings[House].Renewable.Photovoltaic.Photovoltaics[0].FlatConnection;
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(flatConnection, "PV output goes to particular individual flats", false) != 0)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(flatConnection, "PV output goes to all flats in proportion to floor area", false) == 0)
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
      XMLobj.WriteStartElement("Wind-Turbines-Count");
      XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Renewable.WindTurbine.WNumber);
      XMLobj.WriteEndElement();
      if (SAP_Module.Proj.Dwellings[House].Renewable.WindTurbine.Inlcude)
      {
        XMLobj.WriteStartElement("Wind-Turbine-Rotor-Diameter");
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Renewable.WindTurbine.WRDiameter);
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("Wind-Turbine-Hub-Height");
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Renewable.WindTurbine.WHeight);
        XMLobj.WriteEndElement();
      }
      XMLobj.WriteStartElement("Wind-Turbine-Terrain-Type");
      string terrain = SAP_Module.Proj.Dwellings[House].Terrain;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(terrain, "Dense urban", false) != 0)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(terrain, "Low rise urban / suburban", false) != 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(terrain, "Rural", false) == 0)
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
      if (SAP_Module.Proj.Dwellings[House].Renewable.HydroGeneration.Inlcude)
      {
        XMLobj.WriteStartElement("Hydro-Electric-Generation");
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].Renewable.HydroGeneration.HydroGenerated);
        XMLobj.WriteEndElement();
      }
      if ((double) SAP_Module.Proj.Dwellings[House].LowEnergyLight != 0.0)
      {
        XMLobj.WriteStartElement("Fixed-Lighting-Outlets-Count");
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].LELOutlets);
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("Low-Energy-Fixed-Lighting-Outlets-Count");
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[House].LELLights);
        XMLobj.WriteEndElement();
      }
      XMLobj.WriteStartElement("Low-Energy-Fixed-Lighting-Outlets-Percentage");
      XMLobj.WriteValue(Math.Round((double) SAP_Module.Proj.Dwellings[House].LowEnergyLight, 0));
      XMLobj.WriteEndElement();
      XMLobj.WriteStartElement("Electricity-Tariff");
      string electricityTariff = SAP_Module.Proj.Dwellings[House].MainHeating.ElectricityTariff;
      // ISSUE: reference to a compiler-generated method
      switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(electricityTariff))
      {
        case 1880739446:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(electricityTariff, "24-hour tariff", false) == 0)
            goto label_79;
          else
            goto default;
        case 1958420467:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(electricityTariff, "24 hour", false) == 0)
            goto label_79;
          else
            goto default;
        case 2140445595:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(electricityTariff, "7-hour tariff", false) == 0)
            break;
          goto default;
        case 2339516933:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(electricityTariff, "10-hour tariff", false) == 0)
            goto label_78;
          else
            goto default;
        case 3640417453:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(electricityTariff, "18-hour tariff", false) == 0)
          {
            XMLobj.WriteValue(5);
            goto default;
          }
          else
            goto default;
        case 3875898503:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(electricityTariff, "off-peak 10 hour", false) == 0)
            goto label_78;
          else
            goto default;
        case 4020509270:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(electricityTariff, "standard tariff", false) == 0)
          {
            XMLobj.WriteValue(1);
            goto default;
          }
          else
            goto default;
        case 4219766515:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(electricityTariff, "off-peak 7 hour", false) == 0)
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
      XMLobj.WriteStartElement("SAP-Building-Parts");
      XMLobj.WriteStartElement("SAP-Building-Part");
      this._BuildingPartsNumber(XMLobj, House, Country);
      this._BuildingPartsIdentifier(XMLobj, House, Country);
      this._BuildingPartsConstruction(XMLobj, House, Country);
      this._BuildingPartsOvershading(XMLobj, House, Country);
      XMLobj.WriteStartElement("SAP-Openings");
      int num = 0;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].PropertyType, "Flat", false) == 0 && (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].FlatType, "Ground floor", false) > 0U)
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

    private void _SAP09DataPropertyDetails(XmlTextWriter XMLobj, int House, int Country)
    {
      XMLobj.WriteStartElement("SAP-Property-Details");
      try
      {
        this._SAP09DataPropertyDetails_propertyType(XMLobj, House, Country);
        this._SAP09DataPropertyDetails_BuitForm(XMLobj, House, Country);
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
      XMLobj.WriteEndElement();
    }

    private void _SAP09Data(XmlTextWriter XMLobj, int House, int Country)
    {
      this._SAP09Data_DataType(XMLobj, House, Country);
      this._SAP09Data_SchemaVersion(XMLobj, House, Country);
      this._SAP09DataPropertyDetails(XMLobj, House, Country);
    }

    private void _EnergyAssessment(XmlTextWriter XMLobj, int House, int Country)
    {
      XMLobj.WriteStartElement("Energy-Assessment");
      XMLobj.WriteStartElement("Assessment-Date");
      XMLobj.WriteValue(Microsoft.VisualBasic.Strings.Format((object) SAP_Module.Proj.Dwellings[House].DateAssessment, "yyyy-MM-dd"));
      XMLobj.WriteEndElement();
      this._EnergyAssessment_PropertySummary(XMLobj, House, Country);
      this._EnergyAssessment_EnergyUse(XMLobj, House, Country);
      this._EnergyAssessment_SuggestedImprovements(XMLobj, House, Country);
      this._EnergyAssessment_Energy_Sorces(XMLobj, House, Country);
      this._EnergyAssessment_Renewable_Heat_Incentive(XMLobj, House, Country);
      XMLobj.WriteEndElement();
    }

    public string CreateSAPXML(int House, int country)
    {
      string sapxml = "";
      try
      {
        this._FileName_Path();
        this.XMLobj = this._InitializeXML(this.XMLobj);
        this._InitializeNameSpace(this.XMLobj, country);
        this._SAPReport(this.XMLobj, House, country);
        this._InsuranceDetails(this.XMLobj);
        this._ExternalDefinitions(this.XMLobj);
        this._CloseDocument(this.XMLobj);
        FileInfo fileInfo = new FileInfo(SAP_Module.SAPXMLName);
        StreamReader streamReader = File.OpenText(SAP_Module.SAPXMLName);
        sapxml = streamReader.ReadToEnd();
        streamReader.Close();
        fileInfo.Delete();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        Console.Write(exception.Message + exception.StackTrace);
        ProjectData.ClearProjectError();
      }
      return sapxml;
    }

    private void _ExternalDefinitions(XmlTextWriter XMLobj)
    {
      DataSet dataSet = new DataSet();
      int num = (int) dataSet.ReadXml(Application.StartupPath + "\\Data\\ExternalDefinitions.xml");
      XMLobj.WriteStartElement("ExternalDefinitions-Revision-Number");
      XMLobj.WriteValue(RuntimeHelpers.GetObjectValue(dataSet.Tables[0].Rows[0].ItemArray[0]));
      XMLobj.WriteEndElement();
    }

    private void _PDF(XmlTextWriter XMLobj)
    {
    }

    private void _FileName_Path()
    {
      SAP_Module.SAPXMLName = "";
      try
      {
        object folderPath = (object) Environment.GetFolderPath(Environment.SpecialFolder.Personal);
        DirectoryInfo directoryInfo1 = new DirectoryInfo(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(folderPath, (object) "\\Stroma SAP 2012")));
        DirectoryInfo directoryInfo2 = new DirectoryInfo(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(folderPath, (object) "\\Stroma SAP 2012\\"), (object) SAP_Module.Proj.Name)));
        if (!Directory.Exists(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(folderPath, (object) "\\Stroma SAP 2012\\"), (object) SAP_Module.Proj.Name))))
          Directory.CreateDirectory(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(folderPath, (object) "\\Stroma SAP 2012\\"), (object) SAP_Module.Proj.Name)));
        DirectoryInfo directoryInfo3 = new DirectoryInfo(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(folderPath, (object) "\\Stroma SAP 2012\\"), (object) SAP_Module.Proj.Name), (object) "\\"), (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Name)));
        if (!Directory.Exists(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(folderPath, (object) "\\Stroma SAP 2012\\"), (object) SAP_Module.Proj.Name), (object) "\\"), (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Name))))
          Directory.CreateDirectory(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(folderPath, (object) "\\Stroma SAP 2012\\"), (object) SAP_Module.Proj.Name), (object) "\\"), (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Name)));
        SAP_Module.SAPXMLName = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(folderPath, (object) "\\Stroma SAP 2012\\"), (object) SAP_Module.Proj.Name), (object) "\\"), (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Name), (object) "-SAP Lodgement"), (object) ".xml"));
        SAP_Module.ScottishFileName = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(folderPath, (object) "\\Stroma SAP 2012\\"), (object) SAP_Module.Proj.Name), (object) "\\"), (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Name), (object) ".pdf"));
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      try
      {
        if (File.Exists(SAP_Module.ScottishFileName))
          File.Delete(SAP_Module.ScottishFileName);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      try
      {
        if (!File.Exists(SAP_Module.SAPXMLName))
          return;
        File.Delete(SAP_Module.SAPXMLName);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private XmlTextWriter _InitializeXML(XmlTextWriter XMLobj)
    {
      UTF8Encoding utF8Encoding = new UTF8Encoding();
      XMLobj = new XmlTextWriter(SAP_Module.SAPXMLName, (Encoding) utF8Encoding);
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

    private void _InitializeNameSpace(XmlTextWriter XMLobj, int country)
    {
      if (country == 4)
      {
        XMLobj.WriteStartElement("SAP-Report");
        XMLobj.WriteStartAttribute("xmlns:xsi");
        XMLobj.WriteString("http://www.w3.org/2001/XMLSchema-instance");
        XMLobj.WriteEndAttribute();
        XMLobj.WriteStartAttribute("xmlns");
        XMLobj.WriteString("http://www.epcregister.com/xsd/sap");
        XMLobj.WriteEndAttribute();
        XMLobj.WriteStartAttribute("xsi:schemaLocation");
        XMLobj.WriteString("http://www.epcregister.com/xsd/sap http://www.epcregister.com/xsd/SAP/Templates/SAP-Report.xsd");
        XMLobj.WriteEndAttribute();
      }
      else
      {
        XMLobj.WriteStartElement("SAP-Report");
        XMLobj.WriteStartAttribute("xmlns:xsi");
        XMLobj.WriteString("http://www.w3.org/2001/XMLSchema-instance");
        XMLobj.WriteEndAttribute();
        XMLobj.WriteStartAttribute("xmlns");
        XMLobj.WriteString("https://epbr.digital.communities.gov.uk/xsd/sap");
        XMLobj.WriteEndAttribute();
        XMLobj.WriteStartAttribute("xsi:schemaLocation");
        XMLobj.WriteString("https://epbr.digital.communities.gov.uk/xsd/sap ../SAP-Schema-18.0.0/SAP/Templates/SAP-Report.xsd");
        XMLobj.WriteEndAttribute();
      }
    }

    public bool IsCombi(SAP_Module.Dwelling _House)
    {
      bool flag;
      try
      {
        if (_House.Water.SystemRef == 901)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(_House.MainHeating.InforSource, "Boiler Database", false) == 0)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(_House.MainHeating.HGroup, "Community heating schemes", false) == 0)
            {
              flag = false;
              goto label_21;
            }
            else
            {
              string sgroup = _House.MainHeating.SGroup;
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(sgroup, "Gas-fired heat pumps", false) == 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(sgroup, "Solid fuel boilers", false) == 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(sgroup, "Micro-cogeneration (micro-CHP)", false) == 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(sgroup, "Electric heat pumps", false) == 0)
              {
                flag = false;
                goto label_21;
              }
              else
              {
                object Instance = (object) Calc2012.SEDBUK(_House.MainHeating.SEDBUK);
                if (Instance != null)
                {
                  flag = Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(Instance, (System.Type) null, "MainType", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) 2, false);
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
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(_House.MainHeating2.InforSource, "Boiler Database", false) == 0)
          {
            string sgroup = _House.MainHeating2.SGroup;
            flag = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(sgroup, "Gas-fired heat pumps", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(sgroup, "Solid fuel boilers", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(sgroup, "Micro-cogeneration (micro-CHP)", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(sgroup, "Electric heat pumps", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet((object) Calc2012.SEDBUK(_House.MainHeating2.SEDBUK), (System.Type) null, "MainType", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) 2, false);
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
      XML2012._Closure\u0024__142\u002D0 closure1420_1;
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      XML2012._Closure\u0024__142\u002D0 closure1420_2 = new XML2012._Closure\u0024__142\u002D0(closure1420_1);
      // ISSUE: reference to a compiler-generated field
      closure1420_2.\u0024VB\u0024Local_House = House;
      bool flag1 = false;
      XMLobj.WriteStartElement("Main-Heating");
      // ISSUE: reference to a compiler-generated field
      if (!string.IsNullOrEmpty(SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.Fuel))
      {
        XMLobj.WriteStartElement("Main-Heating-Number");
        XMLobj.WriteValue(1);
        XMLobj.WriteEndElement();
      }
      XMLobj.WriteStartElement("Main-Heating-Category");
      // ISSUE: reference to a compiler-generated field
      if (SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.SAPTableCode == 0)
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.InforSource, "Boiler Database", false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.SGroup, "Micro-cogeneration (micro-CHP)", false) == 0)
        {
          XMLobj.WriteValue(3);
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.InforSource, "Boiler Database", false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.HGroup, "Heat pumps with radiators or underfloor heating", false) == 0)
          {
            XMLobj.WriteValue(4);
          }
          else
          {
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.InforSource, "Boiler Database", false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.SGroup, "Heat pumps with warm air distribution", false) == 0)
              XMLobj.WriteValue(5);
            else
              XMLobj.WriteValue(2);
          }
        }
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        int sapTableCode = SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.SAPTableCode;
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
      string inforSource = SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.InforSource;
      int num1 = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(inforSource, "Boiler Database", false) == 0 ? 1 : (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(inforSource, "Manufacturer Declaration", false) == 0 ? 2 : 3);
      XMLobj.WriteStartElement("Main-Heating-Data-Source");
      XMLobj.WriteValue(num1);
      XMLobj.WriteEndElement();
      if (num1 == 1)
      {
        // ISSUE: reference to a compiler-generated field
        int sapTableCode = SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.SAPTableCode;
        if (sapTableCode < 305 || sapTableCode > 311)
        {
          XMLobj.WriteStartElement("Main-Heating-Index-Number");
          // ISSUE: reference to a compiler-generated field
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.SEDBUK);
          XMLobj.WriteEndElement();
        }
      }
      if (num1 == 2)
      {
        XMLobj.WriteStartElement("Is-Condensing-Boiler");
        // ISSUE: reference to a compiler-generated field
        switch (SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.SAPTableCode)
        {
          case 132:
          case 133:
            XMLobj.WriteValue("true");
            break;
          default:
            // ISSUE: reference to a compiler-generated field
            if (!string.IsNullOrEmpty(SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.MHType))
            {
              // ISSUE: reference to a compiler-generated field
              if (SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.MHType.Contains("ondens"))
              {
                // ISSUE: reference to a compiler-generated field
                if (SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.MHType.Contains("non-"))
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
        string fuel = SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.Fuel;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel, "mains gas", false) == 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel, "heating oil", false) == 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel, "LNG", false) == 0)
        {
          // ISSUE: reference to a compiler-generated field
          int sapTableCode = SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.SAPTableCode;
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
            XMLobj.WriteStartElement("Gas-Or-Oil-Boiler-Type");
            XMLobj.WriteValue("1");
            XMLobj.WriteEndElement();
          }
          else if (sapTableCode == 103 || sapTableCode == 104 || sapTableCode == 107 || sapTableCode == 108 || sapTableCode == 112 || sapTableCode == 113 || sapTableCode == 118 || sapTableCode == 128 || sapTableCode == 129 || sapTableCode == 130)
          {
            XMLobj.WriteStartElement("Gas-Or-Oil-Boiler-Type");
            XMLobj.WriteValue("2");
            XMLobj.WriteEndElement();
          }
          else if (sapTableCode >= 120 && sapTableCode <= 123)
          {
            XMLobj.WriteStartElement("Gas-Or-Oil-Boiler-Type");
            XMLobj.WriteValue("3");
            XMLobj.WriteEndElement();
          }
          else if (sapTableCode >= 133 && sapTableCode <= 141)
          {
            XMLobj.WriteStartElement("Gas-Or-Oil-Boiler-Type");
            XMLobj.WriteValue("4");
            XMLobj.WriteEndElement();
          }
        }
        // ISSUE: reference to a compiler-generated field
        switch (SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.SAPTableCode)
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
            XMLobj.WriteStartElement("Combi-Boiler-Type");
            // ISSUE: reference to a compiler-generated field
            string combiType = SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].Water.CombiType;
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(combiType, "Instantaneous Combi", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(combiType, "", false) != 0)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(combiType, "Storage combi boiler, primary store", false) != 0)
              {
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(combiType, "Storage combi boiler, secondary store", false) == 0)
                  XMLobj.WriteValue("3");
              }
              else
                XMLobj.WriteValue("2");
            }
            else
            {
              // ISSUE: reference to a compiler-generated field
              if (SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.Boiler.IncludeKeepHot)
              {
                // ISSUE: reference to a compiler-generated field
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.Boiler.KeepHotFuel, "Main Fuel", false) == 0)
                {
                  // ISSUE: reference to a compiler-generated field
                  if (SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.Boiler.KeepHotTimed)
                    XMLobj.WriteValue("6");
                  else
                    XMLobj.WriteValue("5");
                }
                else
                {
                  // ISSUE: reference to a compiler-generated field
                  if (SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.Boiler.KeepHotTimed)
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
            XMLobj.WriteStartElement("Combi-Boiler-Type");
            XMLobj.WriteValue("4");
            XMLobj.WriteEndElement();
            break;
          case 121:
            XMLobj.WriteStartElement("Combi-Boiler-Type");
            XMLobj.WriteValue("1");
            XMLobj.WriteEndElement();
            break;
          case 133:
          case 139:
            XMLobj.WriteStartElement("Case-Heat-Emission");
            // ISSUE: reference to a compiler-generated field
            XMLobj.WriteValue(SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.Range.CasekW);
            XMLobj.WriteEndElement();
            XMLobj.WriteStartElement("Heat-Transfer-To-Water");
            // ISSUE: reference to a compiler-generated field
            XMLobj.WriteValue(SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.Range.WaterkW);
            XMLobj.WriteEndElement();
            break;
        }
        // ISSUE: reference to a compiler-generated field
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.SGroup, "Solid fuel boilers", false) == 0)
        {
          // ISSUE: reference to a compiler-generated field
          switch (SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.SAPTableCode)
          {
            case 151:
            case 152:
            case 153:
            case 154:
            case 155:
            case 161:
              XMLobj.WriteStartElement("Solid-Fuel-Boiler-Type");
              XMLobj.WriteValue(1);
              XMLobj.WriteEndElement();
              break;
            case 156:
            case 160:
              XMLobj.WriteStartElement("Solid-Fuel-Boiler-Type");
              XMLobj.WriteValue(2);
              XMLobj.WriteEndElement();
              break;
            case 158:
            case 159:
              XMLobj.WriteStartElement("Solid-Fuel-Boiler-Type");
              XMLobj.WriteValue(3);
              XMLobj.WriteEndElement();
              break;
          }
        }
      }
      if (num1 == 3)
      {
        // ISSUE: reference to a compiler-generated field
        int sapTableCode = SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.SAPTableCode;
        if (sapTableCode >= 306 && sapTableCode <= 310)
        {
          // ISSUE: reference to a compiler-generated field
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.MHType, "Community boilers", false) == 0)
          {
            XMLobj.WriteStartElement("Main-Heating-Code");
            // ISSUE: reference to a compiler-generated field
            XMLobj.WriteValue(SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.SAPTableCode);
            XMLobj.WriteEndElement();
          }
        }
        else
        {
          XMLobj.WriteStartElement("Main-Heating-Code");
          // ISSUE: reference to a compiler-generated field
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.SAPTableCode);
          XMLobj.WriteEndElement();
        }
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        if (num1 == 2 && (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.HGroup, "Community heating schemes", false) > 0U)
        {
          XMLobj.WriteStartElement("Main-Heating-Declared-Values");
          XMLobj.WriteStartElement("Make-Model");
          // ISSUE: reference to a compiler-generated field
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.Boiler.Description, (string) null, false) == 0)
          {
            // ISSUE: reference to a compiler-generated field
            SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.Boiler.Description = "";
          }
          // ISSUE: reference to a compiler-generated field
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.Boiler.Description);
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("Test-Method");
          XMLobj.WriteValue("");
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("Efficiency");
          // ISSUE: reference to a compiler-generated field
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.MainEff);
          XMLobj.WriteEndElement();
          XMLobj.WriteEndElement();
        }
      }
      // ISSUE: reference to a compiler-generated field
      if (SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.TableGroup != 3)
      {
        XMLobj.WriteStartElement("Main-Fuel-Type");
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        XMLobj.WriteValue(this.FuelCheck(SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.Fuel, closure1420_2.\u0024VB\u0024Local_House));
        XMLobj.WriteEndElement();
      }
      XMLobj.WriteStartElement("Main-Heating-Control");
      // ISSUE: reference to a compiler-generated field
      XMLobj.WriteValue(SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.ControlCode);
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
              XMLobj.WriteStartElement("TTZC-Index-Number");
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
      int sapTableCode1 = SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.SAPTableCode;
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      if ((sapTableCode1 < 401 || sapTableCode1 > 409) && (sapTableCode1 < 502 || sapTableCode1 > 527) && sapTableCode1 != 156 && sapTableCode1 != 301 && sapTableCode1 != 302 && sapTableCode1 != 304 && sapTableCode1 != 310 && (sapTableCode1 < 601 || sapTableCode1 > 694) && sapTableCode1 != 699 && (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.HGroup, "Community heating schemes", false) > 0U & (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.HGroup, "Electric underfloor heating", false) > 0U)
      {
        XMLobj.WriteStartElement("Heat-Emitter-Type");
        // ISSUE: reference to a compiler-generated field
        string emitter1 = SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.Emitter;
        // ISSUE: reference to a compiler-generated method
        switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(emitter1))
        {
          case 83421456:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter1, "Underfloor heating and radiators, pipes in concrete slab", false) == 0)
            {
              XMLobj.WriteValue(3);
              XMLobj.WriteEndElement();
              XMLobj.WriteStartElement("Underfloor-Heat-Emitter-Type");
              XMLobj.WriteValue(1);
              XMLobj.WriteEndElement();
              goto label_147;
            }
            else
              goto default;
          case 1150666285:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter1, "Underfloor heating and radiators, pipes in insulated timber floor", false) == 0)
            {
              XMLobj.WriteValue(3);
              XMLobj.WriteEndElement();
              XMLobj.WriteStartElement("Underfloor-Heat-Emitter-Type");
              // ISSUE: reference to a compiler-generated field
              string emitter2 = SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.Emitter;
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter2, "Underfloor heating, pipes in insulated timber floor", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter2, "Underfloor heating and radiators, pipes in insulated timber floor", false) != 0)
              {
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter2, "Underfloor heating, pipes in screed above insulation", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter2, "Underfloor heating and radiators, pipes in screed above insulation", false) != 0)
                {
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter2, "Underfloor heating, pipes in concrete slab", false) == 0)
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
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter1, "Underfloor heating, pipes in insulated timber floor", false) == 0)
              break;
            goto default;
          case 1501161800:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter1, "Underfloor heating, pipes in screed above insulation", false) == 0)
            {
              XMLobj.WriteValue(2);
              XMLobj.WriteEndElement();
              XMLobj.WriteStartElement("Underfloor-Heat-Emitter-Type");
              XMLobj.WriteValue(2);
              XMLobj.WriteEndElement();
              goto label_147;
            }
            else
              goto default;
          case 2395580722:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter1, "Underfloor heating and radiators, pipes in screed above insulation", false) == 0)
            {
              XMLobj.WriteValue(3);
              XMLobj.WriteEndElement();
              XMLobj.WriteStartElement("Underfloor-Heat-Emitter-Type");
              // ISSUE: reference to a compiler-generated field
              string emitter3 = SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.Emitter;
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter3, "Underfloor heating, pipes in insulated timber floor", false) != 0)
              {
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter3, "Underfloor heating, pipes in screed above insulation", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter3, "Underfloor heating and radiators, pipes in insulated timber floor", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter3, "Underfloor heating and radiators, pipes in screed above insulation", false) != 0)
                {
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter3, "Underfloor heating, pipes in concrete slab", false) == 0)
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
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter1, "Underfloor heating, pipes in concrete slab", false) == 0)
              break;
            goto default;
          case 2565474752:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter1, "Systems with radiators", false) == 0)
            {
              XMLobj.WriteValue(1);
              XMLobj.WriteEndElement();
              goto label_147;
            }
            else
              goto default;
          case 3146736266:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter1, "Fan coil units", false) == 0)
            {
              XMLobj.WriteValue(4);
              XMLobj.WriteEndElement();
              XMLobj.WriteStartElement("Underfloor-Heat-Emitter-Type");
              // ISSUE: reference to a compiler-generated field
              string emitter4 = SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.Emitter;
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter4, "Underfloor heating, pipes in insulated timber floor", false) != 0)
              {
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter4, "Underfloor heating, pipes in screed above insulation", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter4, "Underfloor heating and radiators, pipes in insulated timber floor", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter4, "Underfloor heating and radiators, pipes in screed above insulation", false) != 0)
                {
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter4, "Underfloor heating, pipes in concrete slab", false) == 0)
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
        XMLobj.WriteStartElement("Underfloor-Heat-Emitter-Type");
        // ISSUE: reference to a compiler-generated field
        string emitter5 = SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.Emitter;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter5, "Underfloor heating, pipes in insulated timber floor", false) != 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter5, "Underfloor heating, pipes in screed above insulation", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter5, "Underfloor heating and radiators, pipes in insulated timber floor", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter5, "Underfloor heating and radiators, pipes in screed above insulation", false) != 0)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter5, "Systems with radiators", false) == 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter5, "Underfloor heating, pipes in concrete slab", false) == 0)
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
      bool flag2;
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.HGroup, "Community heating schemes", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.HGroup, "Electric storage systems", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.HGroup, "Heat pumps with radiators or underfloor heating", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.HGroup, "Electric underfloor heating", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.HGroup, "Room heaters", false) == 0)
        flag2 = true;
      // ISSUE: reference to a compiler-generated field
      if (!flag2 && SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.Boiler.LoadWeather)
      {
        // ISSUE: reference to a compiler-generated field
        if (Conversion.Val(SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.ControlCodePCDFWeather) > 0.0)
        {
          XMLobj.WriteStartElement("Load-Or-Weather-Compensation");
          XMLobj.WriteValue(4);
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("Compensating-Controller-Index-Number");
          // ISSUE: reference to a compiler-generated field
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.ControlCodePCDFWeather);
          XMLobj.WriteEndElement();
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          if (SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.Compensator != null)
          {
            XMLobj.WriteStartElement("Load-Or-Weather-Compensation");
            // ISSUE: reference to a compiler-generated field
            string compensator = SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.Compensator;
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(compensator, "Weather Compensation", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(compensator, "Weather Compensator", false) != 0)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(compensator, "Load Compensation", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(compensator, "Load compensator", false) != 0)
              {
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(compensator, "Enhanced Load Compensator", false) != 0)
                {
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(compensator, "Load or weather compensation (database)", false) == 0)
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
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.SGroup, "Micro-cogeneration (micro-CHP)", false) == 0)
        {
          // ISSUE: reference to a compiler-generated method
          this.SearchRowCHP = SAP_Module.PCDFData.CHPs.Where<PCDF.CHP>(new Func<PCDF.CHP, bool>(closure1420_2._Lambda\u0024__0)).SingleOrDefault<PCDF.CHP>();
          XMLobj.WriteStartElement("Main-Heating-Flue-Type");
          XMLobj.WriteValue(this.SearchRowCHP.Flue_Type);
          XMLobj.WriteEndElement();
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.SGroup, "Solid fuel boilers", false) == 0)
          {
            XMLobj.WriteStartElement("Main-Heating-Flue-Type");
            // ISSUE: reference to a compiler-generated method
            this.SearchSolidBoilerRow = SAP_Module.PCDFData.Solid_Boilers.Where<PCDF.SEDBUK_Solid>(new Func<PCDF.SEDBUK_Solid, bool>(closure1420_2._Lambda\u0024__1)).SingleOrDefault<PCDF.SEDBUK_Solid>();
            if (string.IsNullOrEmpty(this.SearchSolidBoilerRow.Flue))
              XMLobj.WriteValue(1);
            else
              XMLobj.WriteValue(this.SearchSolidBoilerRow.Flue);
            XMLobj.WriteEndElement();
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.SearchSolidBoilerRow.FanAssist, Conversions.ToString(2), false) == 0)
            {
              XMLobj.WriteStartElement("Is-Flue-Fan-Present");
              XMLobj.WriteValue("true");
              XMLobj.WriteEndElement();
            }
            else
            {
              XMLobj.WriteStartElement("Is-Flue-Fan-Present");
              XMLobj.WriteValue("false");
              XMLobj.WriteEndElement();
            }
          }
          else
          {
            // ISSUE: reference to a compiler-generated field
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.SGroup, "Gas boilers and oil boilers", false) == 0)
            {
              XMLobj.WriteStartElement("Main-Heating-Flue-Type");
              // ISSUE: reference to a compiler-generated method
              this.SearchBoilerRow = SAP_Module.PCDFData.Boilers.Where<PCDF.SEDBUK>(new Func<PCDF.SEDBUK, bool>(closure1420_2._Lambda\u0024__2)).SingleOrDefault<PCDF.SEDBUK>();
              if (this.SearchBoilerRow.FlueType == null)
                XMLobj.WriteValue(1);
              else
                XMLobj.WriteValue(this.SearchBoilerRow.FlueType);
              XMLobj.WriteEndElement();
              XMLobj.WriteStartElement("Is-Flue-Fan-Present");
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.SearchBoilerRow.FanAssist, "2", false) == 0)
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
        int sapTableCode2 = SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.SAPTableCode;
        // ISSUE: reference to a compiler-generated field
        if ((sapTableCode2 < 300 || sapTableCode2 >= 501 && sapTableCode2 <= 527 || sapTableCode2 == 636) && (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.Fuel, "Electricity", false) > 0U)
        {
          XMLobj.WriteStartElement("Main-Heating-Flue-Type");
          // ISSUE: reference to a compiler-generated field
          string flueType = SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.Boiler.FlueType;
          // ISSUE: reference to a compiler-generated method
          switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(flueType))
          {
            case 572081497:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(flueType, "omitted", false) == 0)
              {
                XMLobj.WriteValue(4);
                goto default;
              }
              else
                goto default;
            case 1401622761:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(flueType, "Open", false) == 0)
                break;
              goto default;
            case 1533154807:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(flueType, "balanced flue", false) == 0)
                goto label_197;
              else
                goto default;
            case 1537289947:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(flueType, "open flue", false) == 0)
                break;
              goto default;
            case 1708018833:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(flueType, "Room-sealed", false) == 0)
                goto label_197;
              else
                goto default;
            case 1845819738:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(flueType, "unknown (there is a flue, but its type could not be determined)", false) == 0)
                goto label_200;
              else
                goto default;
            case 2166136261:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(flueType, "", false) == 0)
                goto label_200;
              else
                goto default;
            case 2391940020:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(flueType, "Chimney", false) == 0)
              {
                XMLobj.WriteValue(3);
                goto default;
              }
              else
                goto default;
            case 3424652889:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(flueType, "Unknown", false) == 0)
                goto label_200;
              else
                goto default;
            default:
label_201:
              XMLobj.WriteEndElement();
              // ISSUE: reference to a compiler-generated field
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.InforSource, "SAP Tables", false) == 0)
              {
                XMLobj.WriteStartElement("Is-Flue-Fan-Present");
                // ISSUE: reference to a compiler-generated field
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.Boiler.FanFlued, "Yes", false) == 0)
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
      if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SAPTableCode != 527 && !string.IsNullOrEmpty(SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.Emitter))
      {
        XMLobj.WriteStartElement("Is-Central-Heating-Pump-In-Heated-Space");
        // ISSUE: reference to a compiler-generated field
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.Boiler.PumpHP, "Yes", false) == 0)
          XMLobj.WriteValue("true");
        else
          XMLobj.WriteValue("false");
        XMLobj.WriteEndElement();
      }
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.Fuel, "heating oil", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.Fuel, "biodiesel from any biomass source", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.Fuel, "appliances able to use mineral oil or liquid biofuel", false) == 0)
      {
        XMLobj.WriteStartElement("Is-Oil-Pump-In-Heated-Space");
        // ISSUE: reference to a compiler-generated field
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.Boiler.PumpHP, "Yes", false) == 0)
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
      if (this.IsWetSystem(SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.SAPTableCode) && !string.IsNullOrEmpty(SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.Emitter) && SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.Emitter.Contains("radiator") | SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.Emitter.Contains("nderfloor") && (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.HGroup, "Micro-Congeneration (Micro-CHP)", false) > 0U)
      {
        XMLobj.WriteStartElement("Is-Interlocked-System");
        // ISSUE: reference to a compiler-generated field
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.Boiler.BILock, "Yes", false) == 0)
          XMLobj.WriteValue("true");
        else
          XMLobj.WriteValue("false");
        XMLobj.WriteEndElement();
      }
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.HGroup, "Heat pumps with radiators and  underfloor heating", false) > 0U & (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.HGroup, "Community heating schemes", false) > 0U & (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.HGroup, "Electric underfloor heating", false) > 0U & (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.HGroup, "Room heaters", false) > 0U)
      {
        // ISSUE: reference to a compiler-generated field
        int sapTableCode3 = SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.SAPTableCode;
        if (sapTableCode3 != 223 && (sapTableCode3 < 305 || sapTableCode3 > 311) && (sapTableCode3 < 401 || sapTableCode3 > 409))
        {
          XMLobj.WriteStartElement("Has-Separate-Delayed-Start");
          // ISSUE: reference to a compiler-generated field
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.DelayedStart);
          XMLobj.WriteEndElement();
        }
      }
      // ISSUE: reference to a compiler-generated field
      if (num1 == 3 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.SGroup, "Solid fuel boilers", false) == 0)
      {
        XMLobj.WriteStartElement("Boiler-Fuel-Feed");
        XMLobj.WriteValue(1);
        XMLobj.WriteEndElement();
      }
      // ISSUE: reference to a compiler-generated field
      int sapTableCode4 = SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.SAPTableCode;
      if (sapTableCode4 >= 151 && sapTableCode4 <= 161 || sapTableCode4 >= 631 && sapTableCode4 <= 636)
      {
        XMLobj.WriteStartElement("Is-Main-Heating-HETAS-Approved");
        // ISSUE: reference to a compiler-generated field
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.HETAS, "Yes", false) == 0)
          XMLobj.WriteValue("true");
        else
          XMLobj.WriteValue("false");
        XMLobj.WriteEndElement();
      }
      // ISSUE: reference to a compiler-generated field
      if (SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.SAPTableCode == 192)
      {
        XMLobj.WriteStartElement("Electric-CPSU-Operating-Temperature");
        // ISSUE: reference to a compiler-generated field
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].Water.CPSUTemp);
        XMLobj.WriteEndElement();
      }
      // ISSUE: reference to a compiler-generated field
      if (!SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].IncludeMainHeating2)
      {
        XMLobj.WriteStartElement("Main-Heating-Fraction");
        XMLobj.WriteValue(1);
        XMLobj.WriteEndElement();
      }
      else
      {
        XMLobj.WriteStartElement("Main-Heating-Fraction");
        // ISSUE: reference to a compiler-generated field
        XMLobj.WriteValue(Math.Round(1.0 - (double) SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].HeatFractionSec, 2));
        XMLobj.WriteEndElement();
      }
      if (num1 == 2)
      {
        // ISSUE: reference to a compiler-generated field
        switch (SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.SAPTableCode)
        {
          case 130:
          case 133:
            XMLobj.WriteStartElement("Burner-Control");
            // ISSUE: reference to a compiler-generated field
            string fuelBurningType = SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.FuelBurningType;
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuelBurningType, "Unknown", false) != 0)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuelBurningType, "On/off", false) != 0)
              {
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuelBurningType, "Modulation", false) != 0)
                {
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuelBurningType, "electrical", false) != 0)
                  {
                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuelBurningType, "manual", false) == 0)
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
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.InforSource, "Boiler Database", false) == 0)
      {
        try
        {
          // ISSUE: reference to a compiler-generated field
          PCDF.SEDBUK sedbuk = Calc2012.SEDBUK(SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.SEDBUK);
          try
          {
            if (sedbuk.SubType.Equals("1"))
            {
              // ISSUE: reference to a compiler-generated field
              SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].Water.FGHRS.Include = true;
              // ISSUE: reference to a compiler-generated field
              SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].Water.FGHRS.IndexNo = sedbuk.SubTypeIndex;
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
      if (SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].Water.FGHRS.Include)
      {
        XMLobj.WriteStartElement("Has-FGHRS");
        // ISSUE: reference to a compiler-generated field
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].Water.FGHRS.Include);
        XMLobj.WriteEndElement();
        // ISSUE: reference to a compiler-generated field
        if (SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].Water.FGHRS.Include)
          flag1 = true;
        // ISSUE: reference to a compiler-generated field
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.InforSource, "Boiler Database", false) == 0)
        {
          // ISSUE: reference to a compiler-generated field
          if (!string.IsNullOrEmpty(SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].Water.FGHRS.IndexNo))
          {
            XMLobj.WriteStartElement("FGHRS-Index-Number");
            // ISSUE: reference to a compiler-generated field
            XMLobj.WriteValue(SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].Water.FGHRS.IndexNo);
            XMLobj.WriteEndElement();
          }
          else
          {
            // ISSUE: reference to a compiler-generated field
            PCDF.SEDBUK sedbuk = Calc2012.SEDBUK(SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.SEDBUK);
            try
            {
              if (sedbuk.SubType.Equals("1"))
              {
                XMLobj.WriteStartElement("FGHRS-Index-Number");
                // ISSUE: reference to a compiler-generated field
                XMLobj.WriteValue(SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.SEDBUK);
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
        if (SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].Water.FGHRS.PV.Photovoltaics != null && SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].Water.FGHRS.PV.Photovoltaics.Length > 0)
        {
          XMLobj.WriteStartElement("FGHRS-Energy-Source");
          XMLobj.WriteStartElement("PV-Arrays");
          XMLobj.WriteStartElement("PV-Array");
          XMLobj.WriteStartElement("Peak-Power");
          // ISSUE: reference to a compiler-generated field
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].Water.FGHRS.PV.Photovoltaics[0].PPower);
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("Orientation");
          // ISSUE: reference to a compiler-generated field
          string pcOrientation = SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].Water.FGHRS.PV.Photovoltaics[0].PCOrientation;
          // ISSUE: reference to a compiler-generated method
          switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(pcOrientation))
          {
            case 912749504:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(pcOrientation, "SE/SW", false) == 0)
                break;
              goto default;
            case 1128440633:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(pcOrientation, "North East", false) == 0)
              {
                XMLobj.WriteValue(2);
                goto default;
              }
              else
                goto default;
            case 1409318971:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(pcOrientation, "North West", false) == 0)
                goto label_292;
              else
                goto default;
            case 1682370166:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(pcOrientation, "NE/NW", false) == 0)
                goto label_292;
              else
                goto default;
            case 1731397980:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(pcOrientation, "East", false) == 0)
                goto label_289;
              else
                goto default;
            case 1734234020:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(pcOrientation, "North", false) == 0)
              {
                XMLobj.WriteValue(1);
                goto default;
              }
              else
                goto default;
            case 1796576718:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(pcOrientation, "West", false) == 0)
              {
                XMLobj.WriteValue(7);
                goto default;
              }
              else
                goto default;
            case 2417407149:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(pcOrientation, "South West", false) == 0)
              {
                XMLobj.WriteValue(6);
                goto default;
              }
              else
                goto default;
            case 2853841879:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(pcOrientation, "South East", false) == 0)
                break;
              goto default;
            case 3017973530:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(pcOrientation, "South", false) == 0)
              {
                XMLobj.WriteValue(5);
                goto default;
              }
              else
                goto default;
            case 4260797214:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(pcOrientation, "E/W", false) == 0)
                goto label_289;
              else
                goto default;
            default:
label_294:
              XMLobj.WriteEndElement();
              XMLobj.WriteStartElement("Pitch");
              // ISSUE: reference to a compiler-generated field
              string ptilt = SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].Water.FGHRS.PV.Photovoltaics[0].PTilt;
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(ptilt, "Horizontal", false) != 0)
              {
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(ptilt, "30°", false) != 0)
                {
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(ptilt, "45°", false) != 0)
                  {
                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(ptilt, "60°", false) != 0)
                    {
                      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(ptilt, "Vertical", false) == 0)
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
              string povershading = SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].Water.FGHRS.PV.Photovoltaics[0].POvershading;
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(povershading, "Heavy", false) != 0)
              {
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(povershading, "Significant", false) != 0)
                {
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(povershading, "Modest", false) != 0)
                  {
                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(povershading, "None or very little", false) == 0)
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
              XMLobj.WriteStartElement("PV-Connection");
              // ISSUE: reference to a compiler-generated field
              if (SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].Water.FGHRS.PV.Photovoltaics[0].DirectlyConnected)
              {
                XMLobj.WriteValue(2);
              }
              else
              {
                // ISSUE: reference to a compiler-generated field
                string flatConnection = SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].Water.FGHRS.PV.Photovoltaics[0].FlatConnection;
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(flatConnection, "PV output goes to particular individual flats", false) != 0)
                {
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(flatConnection, "PV output goes to all flats in proportion to floor area", false) == 0)
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
              goto label_321;
          }
          XMLobj.WriteValue(4);
          goto label_294;
label_289:
          XMLobj.WriteValue(3);
          goto label_294;
label_292:
          XMLobj.WriteValue(8);
          goto label_294;
        }
label_321:;
      }
      // ISSUE: reference to a compiler-generated field
      int sapTableCode5 = SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.SAPTableCode;
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      if (sapTableCode5 >= 401 && sapTableCode5 <= 409 && SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.StorageHeaters != null && SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.MHType != null && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.MHType, "High heat retention storage heaters", false) == 0)
      {
        XMLobj.WriteStartElement("Storage-Heaters");
        // ISSUE: reference to a compiler-generated field
        int num3 = checked (SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.StorageHeaters.Count - 1);
        int index = 0;
        while (index <= num3)
        {
          XMLobj.WriteStartElement("Storage-Heater");
          XMLobj.WriteStartElement("Number-Of-Heaters");
          // ISSUE: reference to a compiler-generated field
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.StorageHeaters[index].Number_Of_Heaters);
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("Index-Number");
          // ISSUE: reference to a compiler-generated field
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.StorageHeaters[index].Index_Number);
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("High-Heat-Retention");
          XMLobj.WriteValue("true");
          XMLobj.WriteEndElement();
          XMLobj.WriteEndElement();
          checked { ++index; }
        }
        XMLobj.WriteEndElement();
      }
      // ISSUE: reference to a compiler-generated field
      if (SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.Boiler.FlowTemp != null)
      {
        XMLobj.WriteStartElement("Emitter-Temperature");
        // ISSUE: reference to a compiler-generated field
        string flowTemp = SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.Boiler.FlowTemp;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(flowTemp, "Unknown", false) != 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(flowTemp, "Design flow temperature >45°C", false) != 0)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(flowTemp, "Design flow temperature<=45°C", false) != 0)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(flowTemp, "Design flow temperature<=35°C", false) == 0)
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
        string hgroup = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.HGroup;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(hgroup, "Community heating schemes", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(hgroup, "Room heaters", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(hgroup, "Electric storage systems", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(hgroup, "Electric underfloor heating", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(hgroup, "Other space heating systems", false) != 0)
        {
          // ISSUE: reference to a compiler-generated field
          string sgroup = SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.SGroup;
          // ISSUE: reference to a compiler-generated field
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(sgroup, "Solid fuel room heaters", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(sgroup, "Micro-cogeneration (micro-CHP)", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(sgroup, "Micro-Congeneration (Micro-CHP)", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(sgroup, "Room heaters", false) != 0 && (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.HGroup, "Community heating schemes", false) > 0U)
          {
            XMLobj.WriteStartElement("Central-Heating-Pump-Age");
            // ISSUE: reference to a compiler-generated field
            string pumpType = SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.Boiler.PumpType;
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(pumpType, "2013 or later", false) != 0)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(pumpType, "2012 or earlier", false) == 0)
                XMLobj.WriteValue(1);
              else
                XMLobj.WriteValue(0);
            }
            else
              XMLobj.WriteValue(2);
            XMLobj.WriteEndElement();
          }
        }
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.HGroup, "Micro-Congeneration (Micro-CHP)", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.HGroup, "Micro-congeneration (Micro-CHP)", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.HGroup, "Community heating schemes", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.HGroup, "Electric storage systems", false) == 0)
        {
          XMLobj.WriteStartElement("Emitter-Temperature");
          // ISSUE: reference to a compiler-generated field
          string flowTemp = SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.Boiler.FlowTemp;
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(flowTemp, "Unknown", false) != 0)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(flowTemp, "Design flow temperature >45°C", false) != 0)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(flowTemp, "Design flow temperature<=45°C", false) != 0)
              {
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(flowTemp, "Design flow temperature<=35°C", false) == 0)
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
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.HGroup, "Heat pumps with radiators or underfloor heating", false) == 0)
      {
        XMLobj.WriteStartElement("MCS-Installed-Heat-Pump");
        // ISSUE: reference to a compiler-generated field
        if (SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.MCSCert)
          XMLobj.WriteValue("true");
        else
          XMLobj.WriteValue("false");
        XMLobj.WriteEndElement();
      }
      // ISSUE: reference to a compiler-generated field
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.HGroup, "Micro-Congeneration (Micro-CHP)", false) == 0)
      {
        XMLobj.WriteStartElement("Central-Heating-Pump-Age");
        // ISSUE: reference to a compiler-generated field
        string pumpType = SAP_Module.Proj.Dwellings[closure1420_2.\u0024VB\u0024Local_House].MainHeating.Boiler.PumpType;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(pumpType, "2013 or later", false) != 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(pumpType, "2012 or earlier", false) == 0)
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
      XML2012._Closure\u0024__143\u002D0 closure1430_1;
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      XML2012._Closure\u0024__143\u002D0 closure1430_2 = new XML2012._Closure\u0024__143\u002D0(closure1430_1);
      // ISSUE: reference to a compiler-generated field
      closure1430_2.\u0024VB\u0024Local_House = House;
      // ISSUE: reference to a compiler-generated field
      if (!SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].IncludeMainHeating2)
        return;
      XMLobj.WriteStartElement("Main-Heating");
      // ISSUE: reference to a compiler-generated field
      if (!string.IsNullOrEmpty(SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.Fuel))
      {
        XMLobj.WriteStartElement("Main-Heating-Number");
        XMLobj.WriteValue(2);
        XMLobj.WriteEndElement();
      }
      XMLobj.WriteStartElement("Main-Heating-Category");
      // ISSUE: reference to a compiler-generated field
      if (SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.SAPTableCode == 0)
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.InforSource, "Boiler Database", false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.SGroup, "Micro-cogeneration (micro-CHP)", false) == 0)
        {
          XMLobj.WriteValue(3);
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.InforSource, "Boiler Database", false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.HGroup, "Heat pumps with radiators or underfloor heating", false) == 0)
          {
            XMLobj.WriteValue(4);
          }
          else
          {
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.InforSource, "Boiler Database", false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.SGroup, "Heat pumps with warm air distribution", false) == 0)
              XMLobj.WriteValue(5);
            else
              XMLobj.WriteValue(2);
          }
        }
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        int sapTableCode = SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.SAPTableCode;
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
      string inforSource = SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.InforSource;
      int num1 = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(inforSource, "Boiler Database", false) == 0 ? 1 : (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(inforSource, "Manufacturer Declaration", false) == 0 ? 2 : 3);
      XMLobj.WriteStartElement("Main-Heating-Data-Source");
      XMLobj.WriteValue(num1);
      XMLobj.WriteEndElement();
      if (num1 == 1)
      {
        // ISSUE: reference to a compiler-generated field
        int sapTableCode = SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.SAPTableCode;
        if (sapTableCode < 305 || sapTableCode > 311)
        {
          XMLobj.WriteStartElement("Main-Heating-Index-Number");
          // ISSUE: reference to a compiler-generated field
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.SEDBUK);
          XMLobj.WriteEndElement();
        }
      }
      if (num1 == 2)
      {
        XMLobj.WriteStartElement("Is-Condensing-Boiler");
        // ISSUE: reference to a compiler-generated field
        switch (SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.SAPTableCode)
        {
          case 132:
          case 133:
            XMLobj.WriteValue("true");
            break;
          default:
            // ISSUE: reference to a compiler-generated field
            if (!string.IsNullOrEmpty(SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.MHType))
            {
              // ISSUE: reference to a compiler-generated field
              if (SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.MHType.Contains("ondens"))
              {
                // ISSUE: reference to a compiler-generated field
                if (SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.MHType.Contains("non-"))
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
        string fuel = SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.Fuel;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel, "mains gas", false) == 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel, "heating oil", false) == 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel, "LNG", false) == 0)
        {
          // ISSUE: reference to a compiler-generated field
          int sapTableCode = SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.SAPTableCode;
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
            XMLobj.WriteStartElement("Gas-Or-Oil-Boiler-Type");
            XMLobj.WriteValue("1");
            XMLobj.WriteEndElement();
          }
          else if (sapTableCode == 103 || sapTableCode == 104 || sapTableCode == 107 || sapTableCode == 108 || sapTableCode == 112 || sapTableCode == 113 || sapTableCode == 118 || sapTableCode == 128 || sapTableCode == 129 || sapTableCode == 130)
          {
            XMLobj.WriteStartElement("Gas-Or-Oil-Boiler-Type");
            XMLobj.WriteValue("2");
            XMLobj.WriteEndElement();
          }
          else if (sapTableCode >= 120 && sapTableCode <= 123)
          {
            XMLobj.WriteStartElement("Gas-Or-Oil-Boiler-Type");
            XMLobj.WriteValue("3");
            XMLobj.WriteEndElement();
          }
          else if (sapTableCode >= 133 && sapTableCode <= 141)
          {
            XMLobj.WriteStartElement("Gas-Or-Oil-Boiler-Type");
            XMLobj.WriteValue("4");
            XMLobj.WriteEndElement();
          }
        }
        // ISSUE: reference to a compiler-generated field
        switch (SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.SAPTableCode)
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
            XMLobj.WriteStartElement("Combi-Boiler-Type");
            // ISSUE: reference to a compiler-generated field
            string combiType = SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].Water.CombiType;
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(combiType, "Instantaneous Combi", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(combiType, "", false) != 0)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(combiType, "Storage combi boiler, primary store", false) != 0)
              {
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(combiType, "Storage combi boiler, secondary store", false) == 0)
                  XMLobj.WriteValue("3");
              }
              else
                XMLobj.WriteValue("2");
            }
            else
            {
              // ISSUE: reference to a compiler-generated field
              if (SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.Boiler.IncludeKeepHot)
              {
                // ISSUE: reference to a compiler-generated field
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.Boiler.KeepHotFuel, "Main Fuel", false) == 0)
                {
                  // ISSUE: reference to a compiler-generated field
                  if (SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.Boiler.KeepHotTimed)
                    XMLobj.WriteValue("6");
                  else
                    XMLobj.WriteValue("5");
                }
                else
                {
                  // ISSUE: reference to a compiler-generated field
                  if (SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.Boiler.KeepHotTimed)
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
            XMLobj.WriteStartElement("Combi-Boiler-Type");
            XMLobj.WriteValue("4");
            XMLobj.WriteEndElement();
            break;
          case 121:
            XMLobj.WriteStartElement("Combi-Boiler-Type");
            XMLobj.WriteValue("1");
            XMLobj.WriteEndElement();
            break;
          case 133:
          case 139:
            XMLobj.WriteStartElement("Case-Heat-Emission");
            // ISSUE: reference to a compiler-generated field
            XMLobj.WriteValue(SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.Range.CasekW);
            XMLobj.WriteEndElement();
            XMLobj.WriteStartElement("Heat-Transfer-To-Water");
            // ISSUE: reference to a compiler-generated field
            XMLobj.WriteValue(SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.Range.WaterkW);
            XMLobj.WriteEndElement();
            break;
        }
        // ISSUE: reference to a compiler-generated field
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.SGroup, "Solid fuel boilers", false) == 0)
        {
          // ISSUE: reference to a compiler-generated field
          switch (SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.SAPTableCode)
          {
            case 151:
            case 152:
            case 153:
            case 154:
            case 155:
            case 161:
              XMLobj.WriteStartElement("Solid-Fuel-Boiler-Type");
              XMLobj.WriteValue(1);
              XMLobj.WriteEndElement();
              break;
            case 156:
            case 160:
              XMLobj.WriteStartElement("Solid-Fuel-Boiler-Type");
              XMLobj.WriteValue(2);
              XMLobj.WriteEndElement();
              break;
            case 158:
            case 159:
              XMLobj.WriteStartElement("Solid-Fuel-Boiler-Type");
              XMLobj.WriteValue(3);
              XMLobj.WriteEndElement();
              break;
          }
        }
      }
      if (num1 == 3)
      {
        // ISSUE: reference to a compiler-generated field
        int sapTableCode = SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.SAPTableCode;
        if (sapTableCode >= 306 && sapTableCode <= 310)
        {
          // ISSUE: reference to a compiler-generated field
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.MHType, "Community boilers", false) == 0)
          {
            XMLobj.WriteStartElement("Main-Heating-Code");
            // ISSUE: reference to a compiler-generated field
            XMLobj.WriteValue(SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.SAPTableCode);
            XMLobj.WriteEndElement();
          }
        }
        else
        {
          XMLobj.WriteStartElement("Main-Heating-Code");
          // ISSUE: reference to a compiler-generated field
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.SAPTableCode);
          XMLobj.WriteEndElement();
        }
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        if (num1 == 2 && (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.HGroup, "Community heating schemes", false) > 0U)
        {
          XMLobj.WriteStartElement("Main-Heating-Declared-Values");
          XMLobj.WriteStartElement("Make-Model");
          // ISSUE: reference to a compiler-generated field
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.Boiler.Description, (string) null, false) == 0)
          {
            // ISSUE: reference to a compiler-generated field
            SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.Boiler.Description = "";
          }
          // ISSUE: reference to a compiler-generated field
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.Boiler.Description);
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("Test-Method");
          XMLobj.WriteValue("");
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("Efficiency");
          // ISSUE: reference to a compiler-generated field
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.MainEff);
          XMLobj.WriteEndElement();
          XMLobj.WriteEndElement();
        }
      }
      // ISSUE: reference to a compiler-generated field
      if (SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.TableGroup != 3)
      {
        XMLobj.WriteStartElement("Main-Fuel-Type");
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        XMLobj.WriteValue(this.FuelCheck(SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.Fuel, closure1430_2.\u0024VB\u0024Local_House));
        XMLobj.WriteEndElement();
      }
      XMLobj.WriteStartElement("Main-Heating-Control");
      // ISSUE: reference to a compiler-generated field
      XMLobj.WriteValue(SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.ControlCode);
      XMLobj.WriteEndElement();
      switch (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.ControlCode)
      {
        case 2112:
        case 2207:
        case 2208:
          if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.ControlCodePCDF != null)
          {
            XMLobj.WriteStartElement("TTZC-Index-Number");
            XMLobj.WriteValue(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.ControlCodePCDF);
            XMLobj.WriteEndElement();
            break;
          }
          break;
      }
      // ISSUE: reference to a compiler-generated field
      if (!SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].WaterOnlyHeatPump & (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.HGroup, "Electric underfloor heating", false) > 0U)
      {
        // ISSUE: reference to a compiler-generated field
        int sapTableCode = SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.SAPTableCode;
        if ((sapTableCode < 401 || sapTableCode > 409) && (sapTableCode < 502 || sapTableCode > 527) && sapTableCode != 156 && sapTableCode != 301 && sapTableCode != 302 && sapTableCode != 304 && sapTableCode != 310 && (sapTableCode < 601 || sapTableCode > 694) && sapTableCode != 699)
        {
          XMLobj.WriteStartElement("Heat-Emitter-Type");
          // ISSUE: reference to a compiler-generated field
          string emitter1 = SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.Emitter;
          // ISSUE: reference to a compiler-generated method
          switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(emitter1))
          {
            case 83421456:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter1, "Underfloor heating and radiators, pipes in concrete slab", false) == 0)
              {
                XMLobj.WriteValue(3);
                XMLobj.WriteEndElement();
                XMLobj.WriteStartElement("Underfloor-Heat-Emitter-Type");
                XMLobj.WriteValue(1);
                XMLobj.WriteEndElement();
                goto label_147;
              }
              else
                goto default;
            case 1150666285:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter1, "Underfloor heating and radiators, pipes in insulated timber floor", false) == 0)
              {
                XMLobj.WriteValue(3);
                XMLobj.WriteEndElement();
                XMLobj.WriteStartElement("Underfloor-Heat-Emitter-Type");
                // ISSUE: reference to a compiler-generated field
                string emitter2 = SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.Emitter;
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter2, "Underfloor heating, pipes in insulated timber floor", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter2, "Underfloor heating and radiators, pipes in insulated timber floor", false) != 0)
                {
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter2, "Underfloor heating, pipes in screed above insulation", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter2, "Underfloor heating and radiators, pipes in screed above insulation", false) != 0)
                  {
                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter2, "Underfloor heating, pipes in concrete slab", false) == 0)
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
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter1, "Underfloor heating, pipes in insulated timber floor", false) == 0)
                break;
              goto default;
            case 1501161800:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter1, "Underfloor heating, pipes in screed above insulation", false) == 0)
              {
                XMLobj.WriteValue(2);
                XMLobj.WriteEndElement();
                XMLobj.WriteStartElement("Underfloor-Heat-Emitter-Type");
                XMLobj.WriteValue(2);
                XMLobj.WriteEndElement();
                goto label_147;
              }
              else
                goto default;
            case 2395580722:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter1, "Underfloor heating and radiators, pipes in screed above insulation", false) == 0)
              {
                XMLobj.WriteValue(3);
                XMLobj.WriteEndElement();
                XMLobj.WriteStartElement("Underfloor-Heat-Emitter-Type");
                // ISSUE: reference to a compiler-generated field
                string emitter3 = SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.Emitter;
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter3, "Underfloor heating, pipes in insulated timber floor", false) != 0)
                {
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter3, "Underfloor heating, pipes in screed above insulation", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter3, "Underfloor heating and radiators, pipes in insulated timber floor", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter3, "Underfloor heating and radiators, pipes in screed above insulation", false) != 0)
                  {
                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter3, "Underfloor heating, pipes in concrete slab", false) == 0)
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
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter1, "Underfloor heating, pipes in concrete slab", false) == 0)
                break;
              goto default;
            case 2565474752:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter1, "Systems with radiators", false) == 0)
              {
                XMLobj.WriteValue(1);
                XMLobj.WriteEndElement();
                goto label_147;
              }
              else
                goto default;
            case 3146736266:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter1, "Fan coil units", false) == 0)
              {
                XMLobj.WriteValue(4);
                XMLobj.WriteEndElement();
                XMLobj.WriteStartElement("Underfloor-Heat-Emitter-Type");
                // ISSUE: reference to a compiler-generated field
                string emitter4 = SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.Emitter;
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter4, "Underfloor heating, pipes in insulated timber floor", false) != 0)
                {
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter4, "Underfloor heating, pipes in screed above insulation", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter4, "Underfloor heating and radiators, pipes in insulated timber floor", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter4, "Underfloor heating and radiators, pipes in screed above insulation", false) != 0)
                  {
                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter4, "Underfloor heating, pipes in concrete slab", false) == 0)
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
          XMLobj.WriteStartElement("Underfloor-Heat-Emitter-Type");
          // ISSUE: reference to a compiler-generated field
          string emitter5 = SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.Emitter;
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter5, "Underfloor heating, pipes in insulated timber floor", false) != 0)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter5, "Underfloor heating, pipes in screed above insulation", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter5, "Underfloor heating and radiators, pipes in insulated timber floor", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter5, "Underfloor heating and radiators, pipes in screed above insulation", false) != 0)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter5, "Systems with radiators", false) == 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter5, "Underfloor heating, pipes in concrete slab", false) == 0)
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
      }
      bool flag;
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.HGroup, "Community heating schemes", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating.HGroup, "Electric storage systems", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.HGroup, "Heat pumps with radiators or underfloor heating", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.HGroup, "Electric underfloor heating", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.HGroup, "Room heaters", false) == 0)
        flag = true;
      if (!flag)
      {
        // ISSUE: reference to a compiler-generated field
        if (Conversions.ToDouble(SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.ControlCodePCDFWeather) > 0.0)
        {
          XMLobj.WriteStartElement("Load-Or-Weather-Compensation");
          XMLobj.WriteValue(4);
          XMLobj.WriteEndElement();
          XMLobj.WriteStartElement("Compensating-Controller-Index-Number");
          // ISSUE: reference to a compiler-generated field
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.ControlCodePCDFWeather);
          XMLobj.WriteEndElement();
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          if (!string.IsNullOrEmpty(SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.Compensator))
          {
            XMLobj.WriteStartElement("Load-Or-Weather-Compensation");
            // ISSUE: reference to a compiler-generated field
            string compensator = SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.Compensator;
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(compensator, "Weather Compensation", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(compensator, "Weather Compensator", false) != 0)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(compensator, "Load Compensation", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(compensator, "Load compensator", false) != 0)
              {
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(compensator, "Enhanced Load Compensator", false) != 0)
                {
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(compensator, "Load or weather compensation (database)", false) == 0)
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
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.SGroup, "Micro-cogeneration (micro-CHP)", false) == 0)
        {
          // ISSUE: reference to a compiler-generated method
          this.SearchRowCHP = SAP_Module.PCDFData.CHPs.Where<PCDF.CHP>(new Func<PCDF.CHP, bool>(closure1430_2._Lambda\u0024__0)).SingleOrDefault<PCDF.CHP>();
          XMLobj.WriteStartElement("Main-Heating-Flue-Type");
          XMLobj.WriteValue(this.SearchRowCHP.Flue_Type);
          XMLobj.WriteEndElement();
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.SGroup, "Solid fuel boilers", false) == 0)
          {
            XMLobj.WriteStartElement("Main-Heating-Flue-Type");
            // ISSUE: reference to a compiler-generated method
            this.SearchSolidBoilerRow = SAP_Module.PCDFData.Solid_Boilers.Where<PCDF.SEDBUK_Solid>(new Func<PCDF.SEDBUK_Solid, bool>(closure1430_2._Lambda\u0024__1)).SingleOrDefault<PCDF.SEDBUK_Solid>();
            if (string.IsNullOrEmpty(this.SearchSolidBoilerRow.Flue))
              XMLobj.WriteValue(1);
            else
              XMLobj.WriteValue(this.SearchSolidBoilerRow.Flue);
            XMLobj.WriteEndElement();
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.SearchSolidBoilerRow.FanAssist, Conversions.ToString(2), false) == 0)
            {
              XMLobj.WriteStartElement("Is-Flue-Fan-Present");
              XMLobj.WriteValue("true");
              XMLobj.WriteEndElement();
            }
            else
            {
              XMLobj.WriteStartElement("Is-Flue-Fan-Present");
              XMLobj.WriteValue("false");
              XMLobj.WriteEndElement();
            }
          }
          else
          {
            // ISSUE: reference to a compiler-generated field
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.SGroup, "Gas boilers and oil boilers", false) == 0)
            {
              XMLobj.WriteStartElement("Main-Heating-Flue-Type");
              // ISSUE: reference to a compiler-generated method
              this.SearchBoilerRow = SAP_Module.PCDFData.Boilers.Where<PCDF.SEDBUK>(new Func<PCDF.SEDBUK, bool>(closure1430_2._Lambda\u0024__2)).SingleOrDefault<PCDF.SEDBUK>();
              if (this.SearchBoilerRow.FlueType == null)
                XMLobj.WriteValue(1);
              else
                XMLobj.WriteValue(this.SearchBoilerRow.FlueType);
              XMLobj.WriteEndElement();
              XMLobj.WriteStartElement("Is-Flue-Fan-Present");
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.SearchBoilerRow.FanAssist, "2", false) == 0)
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
        int sapTableCode = SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.SAPTableCode;
        // ISSUE: reference to a compiler-generated field
        if (sapTableCode != 636 && (sapTableCode < 300 || sapTableCode >= 501 && sapTableCode <= 527 || sapTableCode == 636) && (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.Fuel, "Electricity", false) > 0U)
        {
          XMLobj.WriteStartElement("Main-Heating-Flue-Type");
          // ISSUE: reference to a compiler-generated field
          string flueType = SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.Boiler.FlueType;
          // ISSUE: reference to a compiler-generated method
          switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(flueType))
          {
            case 572081497:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(flueType, "omitted", false) == 0)
              {
                XMLobj.WriteValue(4);
                goto default;
              }
              else
                goto default;
            case 1401622761:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(flueType, "Open", false) == 0)
                break;
              goto default;
            case 1533154807:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(flueType, "balanced flue", false) == 0)
                goto label_198;
              else
                goto default;
            case 1537289947:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(flueType, "open flue", false) == 0)
                break;
              goto default;
            case 1708018833:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(flueType, "Room-sealed", false) == 0)
                goto label_198;
              else
                goto default;
            case 1845819738:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(flueType, "unknown (there is a flue, but its type could not be determined)", false) == 0)
                goto label_201;
              else
                goto default;
            case 2166136261:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(flueType, "", false) == 0)
                goto label_201;
              else
                goto default;
            case 2391940020:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(flueType, "Chimney", false) == 0)
              {
                XMLobj.WriteValue(3);
                goto default;
              }
              else
                goto default;
            case 3424652889:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(flueType, "Unknown", false) == 0)
                goto label_201;
              else
                goto default;
            default:
label_202:
              XMLobj.WriteEndElement();
              // ISSUE: reference to a compiler-generated field
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.InforSource, "SAP Tables", false) == 0)
              {
                XMLobj.WriteStartElement("Is-Flue-Fan-Present");
                // ISSUE: reference to a compiler-generated field
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.Boiler.FanFlued, "Yes", false) == 0)
                  XMLobj.WriteValue("true");
                else
                  XMLobj.WriteValue("false");
                XMLobj.WriteEndElement();
              }
              goto label_208;
          }
          XMLobj.WriteValue(1);
          goto label_202;
label_198:
          XMLobj.WriteValue(2);
          goto label_202;
label_201:
          XMLobj.WriteValue(5);
          goto label_202;
        }
label_208:;
      }
      // ISSUE: reference to a compiler-generated field
      if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SAPTableCode != 527 && !string.IsNullOrEmpty(SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.Emitter))
      {
        XMLobj.WriteStartElement("Is-Central-Heating-Pump-In-Heated-Space");
        // ISSUE: reference to a compiler-generated field
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.Boiler.PumpHP, "Yes", false) == 0)
          XMLobj.WriteValue("true");
        else
          XMLobj.WriteValue("false");
        XMLobj.WriteEndElement();
      }
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.Fuel, "heating oil", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.Fuel, "biodiesel from any biomass source", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.Fuel, "appliances able to use mineral oil or liquid biofuel", false) == 0)
      {
        XMLobj.WriteStartElement("Is-Oil-Pump-In-Heated-Space");
        // ISSUE: reference to a compiler-generated field
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.Boiler.PumpHP, "Yes", false) == 0)
          XMLobj.WriteValue("true");
        else
          XMLobj.WriteValue("false");
        XMLobj.WriteEndElement();
      }
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      if (this.IsWetSystem(SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.SAPTableCode) && !string.IsNullOrEmpty(SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.Emitter) && SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.Emitter.Contains("radiator") | SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.Emitter.Contains("nderfloor"))
      {
        XMLobj.WriteStartElement("Is-Interlocked-System");
        // ISSUE: reference to a compiler-generated field
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.Boiler.BILock, "Yes", false) == 0)
          XMLobj.WriteValue("true");
        else
          XMLobj.WriteValue("false");
        XMLobj.WriteEndElement();
      }
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.HGroup, "Heat pumps with radiators or underfloor heating", false) > 0U & (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.HGroup, "Community heating schemes", false) > 0U)
      {
        // ISSUE: reference to a compiler-generated field
        int sapTableCode = SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.SAPTableCode;
        if (sapTableCode != 223 && (sapTableCode < 305 || sapTableCode > 311) && (sapTableCode < 401 || sapTableCode > 409))
        {
          XMLobj.WriteStartElement("Has-Separate-Delayed-Start");
          // ISSUE: reference to a compiler-generated field
          XMLobj.WriteValue(SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.DelayedStart);
          XMLobj.WriteEndElement();
        }
      }
      // ISSUE: reference to a compiler-generated field
      if (num1 == 3 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.SGroup, "Solid fuel boilers", false) == 0)
      {
        XMLobj.WriteStartElement("Boiler-Fuel-Feed");
        XMLobj.WriteValue(1);
        XMLobj.WriteEndElement();
      }
      // ISSUE: reference to a compiler-generated field
      int sapTableCode1 = SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.SAPTableCode;
      if (sapTableCode1 >= 151 && sapTableCode1 <= 161 || sapTableCode1 >= 631 && sapTableCode1 <= 636)
      {
        XMLobj.WriteStartElement("Is-Main-Heating-HETAS-Approved");
        // ISSUE: reference to a compiler-generated field
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.HETAS, "Yes", false) == 0)
          XMLobj.WriteValue("true");
        else
          XMLobj.WriteValue("false");
        XMLobj.WriteEndElement();
      }
      // ISSUE: reference to a compiler-generated field
      if (SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.SAPTableCode == 192)
      {
        XMLobj.WriteStartElement("Electric-CPSU-Operating-Temperature");
        // ISSUE: reference to a compiler-generated field
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].Water.CPSUTemp);
        XMLobj.WriteEndElement();
      }
      // ISSUE: reference to a compiler-generated field
      if (!SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].IncludeMainHeating2)
      {
        XMLobj.WriteStartElement("Main-Heating-Fraction");
        XMLobj.WriteValue(1);
        XMLobj.WriteEndElement();
      }
      else
      {
        XMLobj.WriteStartElement("Main-Heating-Fraction");
        // ISSUE: reference to a compiler-generated field
        XMLobj.WriteValue(Math.Round((double) SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].HeatFractionSec, 2));
        XMLobj.WriteEndElement();
      }
      if (num1 == 2)
      {
        // ISSUE: reference to a compiler-generated field
        switch (SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.SAPTableCode)
        {
          case 130:
          case 133:
            XMLobj.WriteStartElement("Burner-Control");
            // ISSUE: reference to a compiler-generated field
            string fuelBurningType = SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.FuelBurningType;
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuelBurningType, "Unknown", false) != 0)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuelBurningType, "On/off", false) != 0)
              {
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuelBurningType, "Modulation", false) != 0)
                {
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuelBurningType, "electrical", false) != 0)
                  {
                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuelBurningType, "manual", false) == 0)
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
            XMLobj.WriteStartElement("Efficiency-Type");
            // ISSUE: reference to a compiler-generated field
            if (SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.SEDBUK2005)
            {
              XMLobj.WriteValue(2);
            }
            else
            {
              // ISSUE: reference to a compiler-generated field
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.SEDBUK, "", false) == 0)
              {
                XMLobj.WriteValue(3);
              }
              else
              {
                // ISSUE: reference to a compiler-generated field
                if (Conversions.ToBoolean(SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.SEDBUK))
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
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.InforSource, "Boiler Database", false) == 0)
      {
        try
        {
          // ISSUE: reference to a compiler-generated field
          PCDF.SEDBUK sedbuk = Calc2012.SEDBUK(SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.SEDBUK);
          try
          {
            if (sedbuk != null)
            {
              if (sedbuk.SubType.Equals("1"))
              {
                // ISSUE: reference to a compiler-generated field
                SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].Water.FGHRS.Include = true;
              }
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
      // ISSUE: reference to a compiler-generated field
      if (SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].Water.FGHRS.PV.Photovoltaics != null && SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].Water.FGHRS.PV.Photovoltaics.Length > 0)
      {
        XMLobj.WriteStartElement("FGHRS-Energy-Source");
        XMLobj.WriteStartElement("PV-Arrays");
        XMLobj.WriteStartElement("PV-Array");
        XMLobj.WriteStartElement("Peak-Power");
        // ISSUE: reference to a compiler-generated field
        XMLobj.WriteValue(SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].Water.FGHRS.PV.Photovoltaics[0].PPower);
        XMLobj.WriteEndElement();
        XMLobj.WriteStartElement("Orientation");
        // ISSUE: reference to a compiler-generated field
        string pcOrientation = SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].Water.FGHRS.PV.Photovoltaics[0].PCOrientation;
        // ISSUE: reference to a compiler-generated method
        switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(pcOrientation))
        {
          case 912749504:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(pcOrientation, "SE/SW", false) == 0)
              break;
            goto default;
          case 1128440633:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(pcOrientation, "North East", false) == 0)
            {
              XMLobj.WriteValue(2);
              goto default;
            }
            else
              goto default;
          case 1409318971:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(pcOrientation, "North West", false) == 0)
              goto label_290;
            else
              goto default;
          case 1682370166:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(pcOrientation, "NE/NW", false) == 0)
              goto label_290;
            else
              goto default;
          case 1731397980:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(pcOrientation, "East", false) == 0)
              goto label_287;
            else
              goto default;
          case 1734234020:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(pcOrientation, "North", false) == 0)
            {
              XMLobj.WriteValue(1);
              goto default;
            }
            else
              goto default;
          case 1796576718:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(pcOrientation, "West", false) == 0)
            {
              XMLobj.WriteValue(7);
              goto default;
            }
            else
              goto default;
          case 2417407149:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(pcOrientation, "South West", false) == 0)
            {
              XMLobj.WriteValue(6);
              goto default;
            }
            else
              goto default;
          case 2853841879:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(pcOrientation, "South East", false) == 0)
              break;
            goto default;
          case 3017973530:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(pcOrientation, "South", false) == 0)
            {
              XMLobj.WriteValue(5);
              goto default;
            }
            else
              goto default;
          case 4260797214:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(pcOrientation, "E/W", false) == 0)
              goto label_287;
            else
              goto default;
          default:
label_292:
            XMLobj.WriteEndElement();
            XMLobj.WriteStartElement("Pitch");
            // ISSUE: reference to a compiler-generated field
            string ptilt = SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].Water.FGHRS.PV.Photovoltaics[0].PTilt;
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(ptilt, "Horizontal", false) != 0)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(ptilt, "30°", false) != 0)
              {
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(ptilt, "45°", false) != 0)
                {
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(ptilt, "60°", false) != 0)
                  {
                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(ptilt, "Vertical", false) == 0)
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
            string povershading = SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].Water.FGHRS.PV.Photovoltaics[0].POvershading;
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(povershading, "Heavy", false) != 0)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(povershading, "Significant", false) != 0)
              {
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(povershading, "Modest", false) != 0)
                {
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(povershading, "None or very little", false) == 0)
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
            XMLobj.WriteStartElement("PV-Connection");
            // ISSUE: reference to a compiler-generated field
            if (SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].Water.FGHRS.PV.Photovoltaics[0].DirectlyConnected)
            {
              XMLobj.WriteValue(2);
            }
            else
            {
              // ISSUE: reference to a compiler-generated field
              string flatConnection = SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].Water.FGHRS.PV.Photovoltaics[0].FlatConnection;
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(flatConnection, "PV output goes to particular individual flats", false) != 0)
              {
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(flatConnection, "PV output goes to all flats in proportion to floor area", false) == 0)
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
label_319:
      // ISSUE: reference to a compiler-generated field
      switch (SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.SAPTableCode)
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
          if (SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.StorageHeaters != null && SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating.MHType != null && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating.MHType, "High heat retention storage heaters", false) == 0)
          {
            XMLobj.WriteStartElement("Storage-Heaters");
            // ISSUE: reference to a compiler-generated field
            int num3 = checked (SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.StorageHeaters.Count - 1);
            int index = 0;
            while (index <= num3)
            {
              XMLobj.WriteStartElement("Storage-Heater");
              XMLobj.WriteStartElement("Number-Of-Heaters");
              // ISSUE: reference to a compiler-generated field
              XMLobj.WriteValue(SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.StorageHeaters[index].Number_Of_Heaters);
              XMLobj.WriteEndElement();
              XMLobj.WriteStartElement("Index-Number");
              // ISSUE: reference to a compiler-generated field
              XMLobj.WriteValue(SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.StorageHeaters[index].Index_Number);
              XMLobj.WriteEndElement();
              XMLobj.WriteStartElement("High-Heat-Retention");
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
      if (!SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].WaterOnlyHeatPump)
      {
        // ISSUE: reference to a compiler-generated field
        if (SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.Boiler.FlowTemp != null)
        {
          XMLobj.WriteStartElement("Emitter-Temperature");
          // ISSUE: reference to a compiler-generated field
          string flowTemp = SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.Boiler.FlowTemp;
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(flowTemp, "Unknown", false) != 0)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(flowTemp, "Design flow temperature >45°C", false) != 0)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(flowTemp, "Design flow temperature<=45°C", false) != 0)
              {
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(flowTemp, "Design flow temperature<=35°C", false) == 0)
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
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.SGroup, "Solid fuel room heaters", false) != 0 && (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.HGroup, "Community heating schemes", false) > 0U)
          {
            XMLobj.WriteStartElement("Central-Heating-Pump-Age");
            // ISSUE: reference to a compiler-generated field
            string pumpType = SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.Boiler.PumpType;
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(pumpType, "2013 or later", false) != 0)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(pumpType, "2012 or earlier", false) == 0)
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
          XMLobj.WriteStartElement("Emitter-Temperature");
          // ISSUE: reference to a compiler-generated field
          string flowTemp = SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.Boiler.FlowTemp;
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(flowTemp, "Unknown", false) != 0)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(flowTemp, "Design flow temperature >45°C", false) != 0)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(flowTemp, "Design flow temperature<=45°C", false) != 0)
              {
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(flowTemp, "Design flow temperature<=35°C", false) == 0)
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
      else
      {
        XMLobj.WriteStartElement("Emitter-Temperature");
        // ISSUE: reference to a compiler-generated field
        string flowTemp = SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.Boiler.FlowTemp;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(flowTemp, "Unknown", false) != 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(flowTemp, "Design flow temperature >45°C", false) != 0)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(flowTemp, "Design flow temperature<=45°C", false) != 0)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(flowTemp, "Design flow temperature<=35°C", false) == 0)
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
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.HGroup, "Heat pumps with radiators or underfloor heating", false) == 0)
      {
        XMLobj.WriteStartElement("MCS-Installed-Heat-Pump");
        // ISSUE: reference to a compiler-generated field
        if (SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.MCSCert)
          XMLobj.WriteValue("true");
        else
          XMLobj.WriteValue("false");
        XMLobj.WriteEndElement();
      }
      // ISSUE: reference to a compiler-generated field
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.HGroup, "Micro-Congeneration (Micro-CHP)", false) == 0)
      {
        XMLobj.WriteStartElement("Central-Heating-Pump-Age");
        // ISSUE: reference to a compiler-generated field
        string pumpType = SAP_Module.Proj.Dwellings[closure1430_2.\u0024VB\u0024Local_House].MainHeating2.Boiler.PumpType;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(pumpType, "2013 or later", false) != 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(pumpType, "2012 or earlier", false) == 0)
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

    public bool isCPSU(int Value)
    {
      bool flag = false;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.InforSource, "Boiler Database", false) == 0)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SGroup, "Gas boilers and oil boilers", false) == 0)
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
    }

    public class LZCSection
    {
      public bool Include;
      public int Count;
    }
  }
}
