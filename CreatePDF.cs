
// Type: SAP2012.CreatePDF




using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using SAP2012.My;
using SAP2012.SAPRef;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace SAP2012
{
  public class CreatePDF
  {
    public int k;
    public int R;
    public int Col;
    public int T_Count;
    public int RC1;
    public int CC1;
    public int RM;
    public int TblHeadingNUm;
    public int HeadingNum;
    private double TotalSavingLow;
    public string[] Address;
    public string SQL;
    public Stream PDFCreated;
    private string LowCarbonTex;
    private string MeasuredText;
    private string MeasuredTextLast;
    private string TextHeader;
    private string HotWaterDesc;
    private PCDF.SEDBUK SearchRow;
    private PCDF.HeatPump SearchRowHP;
    private PCDF.CHP SearchRowCHP;
    private PCDF.SEDBUK SearchBoilerRow;
    private string[] PrintText;
    private string InitialText;
    private string AddressLineUse;
    private int count;
    private int G;
    private int LastCount;
    private bool Low;
    private bool High;
    private bool Further;
    private string[] LowRec;
    private string[] HighRec;
    private string[] FurtherRec;
    private string WaterBanding;
    private string WaterBanding2;
    private string XML_WaterBanding;
    private string XML_WaterBanding2;
    private string HeatingHeading;
    private string HeatingHeadingwWALES;
    private string WCH;
    private string WCH2;
    private string ExternalDefinitions;
    private double responsiveness;
    private double calHeatingVal;
    private double calHeatingValCO2;
    private DataRow[] ControlRow;
    private double carbonEmm;
    private double carbonEmm2;
    private double Waterband;
    private double Waterband2;
    private string MainBrand;
    private string MainBrand2;
    private string XML_MainBrand;
    private string XML_MainBrand2;
    private string MyMainCode;
    private string MyMainCode2;
    private string XML_MyMainCode;
    private string XML_MyMainCode2;
    private string XML_secMainBrand;
    private string XML_secMainBrand2;
    private string XMLsecMyMainCode;
    private string XMLsecMyMainCode2;
    private object DateOfCertificate;
    private object dateofAssessment;
    private double indicative;
    private bool combine_heat;
    private bool geothermal_heat;
    private bool ground_source;
    private bool air_source;
    private bool water_source;
    private bool comunity_heat;
    private int additional_heating;
    private int additional_water;
    private bool water_only;
    private bool biomass;
    private bool exhaust_air;
    private string HeatingHeading2;
    private CreatePDF.Opening[] OpeningTypes;

    public CreatePDF()
    {
      this.Address = new string[5];
      this.PrintText = new string[23];
      this.LowRec = new string[9];
      this.HighRec = new string[6];
      this.FurtherRec = new string[9];
      this.HeatingHeading = "";
      this.HeatingHeadingwWALES = "";
      this.MyMainCode = "";
      this.MyMainCode2 = "";
      this.combine_heat = false;
      this.geothermal_heat = false;
      this.ground_source = false;
      this.air_source = false;
      this.water_source = false;
      this.comunity_heat = false;
      this.water_only = false;
      this.biomass = false;
      this.exhaust_air = false;
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
          if (num >= 401 && num <= 408)
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

    private bool Compare_Heaters(int House) => !((double) SAP_Module.Proj.Dwellings[House].HeatFractionSec > 0.1 & (double) SAP_Module.Proj.Dwellings[House].HeatFractionSec < 0.9);

    public void checkCarbon(int country, int House)
    {
      bool flag = false;
      if (country == 2 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].EPCLanguage, "Welsh", false) == 0)
        flag = true;
      this.CC1 = checked (this.RC1 + 22);
      PDFFunctions.xBrush1 = XBrush.op_Implicit((Brush) new SolidBrush(Color.FromArgb(179, 3, 55)));
      PDFFunctions.Points[0].X = 20f;
      PDFFunctions.Points[0].Y = (float) this.RC1;
      ref PointF local1 = ref PDFFunctions.Points[1];
      XUnit width1 = PDFFunctions.pages[this.k].Width;
      double num1 = ((XUnit) ref width1).Point - 20.0;
      local1.X = (float) num1;
      PDFFunctions.Points[1].Y = (float) this.RC1;
      ref PointF local2 = ref PDFFunctions.Points[2];
      XUnit width2 = PDFFunctions.pages[this.k].Width;
      double num2 = ((XUnit) ref width2).Point - 20.0;
      local2.X = (float) num2;
      PDFFunctions.Points[2].Y = (float) this.CC1;
      PDFFunctions.Points[3].X = 20f;
      PDFFunctions.Points[3].Y = (float) this.CC1;
      XPen xpen = new XPen(XColor.FromArgb(179, 3, 55));
      PDFFunctions.gfx[this.k].DrawPolygon(xpen, PDFFunctions.xBrush1, PDFFunctions.Points, PDFFunctions.Fill);
      XUnit xunit;
      if (flag)
      {
        XGraphics xgraphics = PDFFunctions.gfx[this.k];
        XFont arialFont12Bold = PDFFunctions.ArialFont12Bold;
        XSolidBrush white = XBrushes.White;
        double num3 = (double) checked (this.RC1 + 4);
        xunit = PDFFunctions.pages[this.k].Width;
        double point = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[this.k].Height;
        double num4 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect = new XRect(25.0, num3, point, num4);
        XStringFormat topLeft = XStringFormat.TopLeft;
        xgraphics.DrawString("Ffynonellau ynni carbon isel a dim carbon", arialFont12Bold, (XBrush) white, xrect, topLeft);
      }
      else
      {
        XGraphics xgraphics = PDFFunctions.gfx[this.k];
        XFont arialFont12Bold = PDFFunctions.ArialFont12Bold;
        XSolidBrush white = XBrushes.White;
        double num5 = (double) checked (this.RC1 + 4);
        XUnit width3 = PDFFunctions.pages[this.k].Width;
        double point = ((XUnit) ref width3).Point;
        XUnit height = PDFFunctions.pages[this.k].Height;
        double num6 = ((XUnit) ref height).Point / 2.0;
        XRect xrect = new XRect(25.0, num5, point, num6);
        XStringFormat topLeft = XStringFormat.TopLeft;
        xgraphics.DrawString("Low and zero carbon energy sources", arialFont12Bold, (XBrush) white, xrect, topLeft);
      }
      this.CC1 = checked ((int) Math.Round((double) PDFFunctions.Points[3].Y));
      this.RC1 = checked ((int) Math.Round((double) PDFFunctions.Points[0].Y));
      checked { this.CC1 += 30; }
      checked { this.RC1 += 30; }
      int rc1_1 = this.RC1;
      int num7 = 0;
      string str1 = !flag ? "The following low or zero carbon energy sources are provided for this home:" : "Darperir y ffynonellau carbon isel neu’r ffynonellau dim carbon canlynol ar gyfer y cartref hwn:";
      this.LowCarbonTex = "";
      checked { this.RC1 += 15; }
      if (flag)
      {
        if (SAP_Module.Proj.Dwellings[House].Renewable.Photovoltaic.Inlcude)
        {
          // ISSUE: variable of a reference type
          string& local3;
          // ISSUE: explicit reference operation
          string str2 = ^(local3 = ref this.LowCarbonTex) + "• Ffotofoltäeg ynni'r haul\r\n";
          local3 = str2;
          XGraphics xgraphics = PDFFunctions.gfx[this.k];
          string lowCarbonTex = this.LowCarbonTex;
          XFont arialFont11 = PDFFunctions.ArialFont11;
          XSolidBrush black = XBrushes.Black;
          double rc1_2 = (double) this.RC1;
          xunit = PDFFunctions.pages[this.k].Width;
          double point1 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[this.k].Height;
          double point2 = ((XUnit) ref xunit).Point;
          XRect xrect = new XRect(25.0, rc1_2, point1, point2);
          XStringFormat topLeft = XStringFormat.TopLeft;
          xgraphics.DrawString(lowCarbonTex, arialFont11, (XBrush) black, xrect, topLeft);
          this.LowCarbonTex = "";
          checked { ++num7; }
          checked { this.RC1 += 12; }
        }
        if (SAP_Module.Proj.Dwellings[House].Water.Solar.Inlcude)
        {
          // ISSUE: variable of a reference type
          string& local4;
          // ISSUE: explicit reference operation
          string str3 = ^(local4 = ref this.LowCarbonTex) + "• Gwresogi drwy ynni'r haul\r\n";
          local4 = str3;
          XGraphics xgraphics = PDFFunctions.gfx[this.k];
          string lowCarbonTex = this.LowCarbonTex;
          XFont arialFont11 = PDFFunctions.ArialFont11;
          XSolidBrush black = XBrushes.Black;
          double rc1_3 = (double) this.RC1;
          xunit = PDFFunctions.pages[this.k].Width;
          double point3 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[this.k].Height;
          double point4 = ((XUnit) ref xunit).Point;
          XRect xrect = new XRect(25.0, rc1_3, point3, point4);
          XStringFormat topLeft = XStringFormat.TopLeft;
          xgraphics.DrawString(lowCarbonTex, arialFont11, (XBrush) black, xrect, topLeft);
          this.LowCarbonTex = "";
          checked { ++num7; }
          checked { this.RC1 += 12; }
        }
        if (SAP_Module.Proj.Dwellings[House].Renewable.WindTurbine.Inlcude)
        {
          this.LowCarbonTex = "• Tyrbin gwynt\r\n";
          XGraphics xgraphics = PDFFunctions.gfx[this.k];
          string lowCarbonTex = this.LowCarbonTex;
          XFont arialFont11 = PDFFunctions.ArialFont11;
          XSolidBrush black = XBrushes.Black;
          double rc1_4 = (double) this.RC1;
          xunit = PDFFunctions.pages[this.k].Width;
          double point5 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[this.k].Height;
          double point6 = ((XUnit) ref xunit).Point;
          XRect xrect = new XRect(25.0, rc1_4, point5, point6);
          XStringFormat topLeft = XStringFormat.TopLeft;
          xgraphics.DrawString(lowCarbonTex, arialFont11, (XBrush) black, xrect, topLeft);
          this.LowCarbonTex = "";
          checked { ++num7; }
          checked { this.RC1 += 12; }
        }
        if (SAP_Module.Proj.Dwellings[House].MainHeating.Fuel.Contains("wood") | SAP_Module.Proj.Dwellings[House].MainHeating2.Fuel.Contains("wood"))
        {
          int sapTableCode = SAP_Module.Proj.Dwellings[House].MainHeating.SAPTableCode;
          if (sapTableCode < 306 || sapTableCode > 310)
          {
            this.LowCarbonTex = "• Prif wres biomas\r\n";
            XGraphics xgraphics = PDFFunctions.gfx[this.k];
            string lowCarbonTex = this.LowCarbonTex;
            XFont arialFont11 = PDFFunctions.ArialFont11;
            XSolidBrush black = XBrushes.Black;
            double rc1_5 = (double) this.RC1;
            xunit = PDFFunctions.pages[this.k].Width;
            double point7 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[this.k].Height;
            double point8 = ((XUnit) ref xunit).Point;
            XRect xrect = new XRect(25.0, rc1_5, point7, point8);
            XStringFormat topLeft = XStringFormat.TopLeft;
            xgraphics.DrawString(lowCarbonTex, arialFont11, (XBrush) black, xrect, topLeft);
            this.LowCarbonTex = "";
            checked { ++num7; }
            checked { this.RC1 += 12; }
          }
        }
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.CommunityH.Boiler2CHPFuel, "", false) == 0)
        {
          if (SAP_Module.Proj.Dwellings[House].MainHeating.Fuel.Contains("iomass"))
          {
            int sapTableCode = SAP_Module.Proj.Dwellings[House].MainHeating.SAPTableCode;
            if (sapTableCode == 306 || sapTableCode >= 308 && sapTableCode <= 310)
            {
              this.LowCarbonTex = "• Gwres cymunedol biomas\r\n";
              XGraphics xgraphics = PDFFunctions.gfx[this.k];
              string lowCarbonTex = this.LowCarbonTex;
              XFont arialFont11 = PDFFunctions.ArialFont11;
              XSolidBrush black = XBrushes.Black;
              double rc1_6 = (double) this.RC1;
              xunit = PDFFunctions.pages[this.k].Width;
              double point9 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[this.k].Height;
              double point10 = ((XUnit) ref xunit).Point;
              XRect xrect = new XRect(25.0, rc1_6, point9, point10);
              XStringFormat topLeft = XStringFormat.TopLeft;
              xgraphics.DrawString(lowCarbonTex, arialFont11, (XBrush) black, xrect, topLeft);
              this.LowCarbonTex = "";
              checked { ++num7; }
              checked { this.RC1 += 12; }
            }
            else if (sapTableCode == 307)
            {
              this.LowCarbonTex = "• Gwres cymunedol biomas ar gyfer peth o'r gwres\r\n";
              XGraphics xgraphics = PDFFunctions.gfx[this.k];
              string lowCarbonTex = this.LowCarbonTex;
              XFont arialFont11 = PDFFunctions.ArialFont11;
              XSolidBrush black = XBrushes.Black;
              double rc1_7 = (double) this.RC1;
              xunit = PDFFunctions.pages[this.k].Width;
              double point11 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[this.k].Height;
              double point12 = ((XUnit) ref xunit).Point;
              XRect xrect = new XRect(25.0, rc1_7, point11, point12);
              XStringFormat topLeft = XStringFormat.TopLeft;
              xgraphics.DrawString(lowCarbonTex, arialFont11, (XBrush) black, xrect, topLeft);
              this.LowCarbonTex = "";
              checked { ++num7; }
              checked { this.RC1 += 12; }
            }
          }
        }
        else if (SAP_Module.Proj.Dwellings[House].MainHeating.Fuel.Contains("iomass") | SAP_Module.Proj.Dwellings[House].MainHeating.CommunityH.Boiler2CHPFuel.Contains("iomass") | SAP_Module.Proj.Dwellings[House].Water.Fuel.Contains("iomass"))
        {
          int sapTableCode = SAP_Module.Proj.Dwellings[House].MainHeating.SAPTableCode;
          if (sapTableCode == 306 || sapTableCode >= 308 && sapTableCode <= 310)
          {
            this.LowCarbonTex = "• Gwres cymunedol biomas\r\n";
            XGraphics xgraphics = PDFFunctions.gfx[this.k];
            string lowCarbonTex = this.LowCarbonTex;
            XFont arialFont11 = PDFFunctions.ArialFont11;
            XSolidBrush black = XBrushes.Black;
            double rc1_8 = (double) this.RC1;
            xunit = PDFFunctions.pages[this.k].Width;
            double point13 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[this.k].Height;
            double point14 = ((XUnit) ref xunit).Point;
            XRect xrect = new XRect(25.0, rc1_8, point13, point14);
            XStringFormat topLeft = XStringFormat.TopLeft;
            xgraphics.DrawString(lowCarbonTex, arialFont11, (XBrush) black, xrect, topLeft);
            this.LowCarbonTex = "";
            checked { ++num7; }
            checked { this.RC1 += 12; }
          }
          else if (sapTableCode == 307)
          {
            this.LowCarbonTex = "• Gwres cymunedol biomas ar gyfer peth o'r gwres\r\n";
            XGraphics xgraphics = PDFFunctions.gfx[this.k];
            string lowCarbonTex = this.LowCarbonTex;
            XFont arialFont11 = PDFFunctions.ArialFont11;
            XSolidBrush black = XBrushes.Black;
            double rc1_9 = (double) this.RC1;
            xunit = PDFFunctions.pages[this.k].Width;
            double point15 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[this.k].Height;
            double point16 = ((XUnit) ref xunit).Point;
            XRect xrect = new XRect(25.0, rc1_9, point15, point16);
            XStringFormat topLeft = XStringFormat.TopLeft;
            xgraphics.DrawString(lowCarbonTex, arialFont11, (XBrush) black, xrect, topLeft);
            this.LowCarbonTex = "";
            checked { ++num7; }
            checked { this.RC1 += 12; }
          }
          else
          {
            this.LowCarbonTex = "• Gwres cymunedol biomas ar gyfer peth o'r gwres\r\n";
            XGraphics xgraphics = PDFFunctions.gfx[this.k];
            string lowCarbonTex = this.LowCarbonTex;
            XFont arialFont11 = PDFFunctions.ArialFont11;
            XSolidBrush black = XBrushes.Black;
            double rc1_10 = (double) this.RC1;
            xunit = PDFFunctions.pages[this.k].Width;
            double point17 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[this.k].Height;
            double point18 = ((XUnit) ref xunit).Point;
            XRect xrect = new XRect(25.0, rc1_10, point17, point18);
            XStringFormat topLeft = XStringFormat.TopLeft;
            xgraphics.DrawString(lowCarbonTex, arialFont11, (XBrush) black, xrect, topLeft);
            this.LowCarbonTex = "";
            checked { ++num7; }
            checked { this.RC1 += 12; }
          }
        }
        if (SAP_Module.Proj.Dwellings[House].SecHeating.Fuel.Contains("wood") & !SAP_Module.Proj.Dwellings[House].SecHeating.Fuel.Contains("dual"))
        {
          this.LowCarbonTex = "• Gwres eilaidd biomas\r\n";
          XGraphics xgraphics = PDFFunctions.gfx[this.k];
          string lowCarbonTex = this.LowCarbonTex;
          XFont arialFont11 = PDFFunctions.ArialFont11;
          XSolidBrush black = XBrushes.Black;
          double rc1_11 = (double) this.RC1;
          xunit = PDFFunctions.pages[this.k].Width;
          double point19 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[this.k].Height;
          double point20 = ((XUnit) ref xunit).Point;
          XRect xrect = new XRect(25.0, rc1_11, point19, point20);
          XStringFormat topLeft = XStringFormat.TopLeft;
          xgraphics.DrawString(lowCarbonTex, arialFont11, (XBrush) black, xrect, topLeft);
          this.LowCarbonTex = "";
          checked { ++num7; }
          checked { this.RC1 += 12; }
        }
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.SGroup, "Micro-cogeneration (micro-CHP)", false) == 0 | SAP_Module.Proj.Dwellings[House].Water.SystemRef == 951)
        {
          this.LowCarbonTex = "• Gwres a phŵer cyfun\r\n";
          XGraphics xgraphics = PDFFunctions.gfx[this.k];
          string lowCarbonTex = this.LowCarbonTex;
          XFont arialFont11 = PDFFunctions.ArialFont11;
          XSolidBrush black = XBrushes.Black;
          double rc1_12 = (double) this.RC1;
          xunit = PDFFunctions.pages[this.k].Width;
          double point21 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[this.k].Height;
          double point22 = ((XUnit) ref xunit).Point;
          XRect xrect = new XRect(25.0, rc1_12, point21, point22);
          XStringFormat topLeft = XStringFormat.TopLeft;
          xgraphics.DrawString(lowCarbonTex, arialFont11, (XBrush) black, xrect, topLeft);
          this.LowCarbonTex = "";
          checked { ++num7; }
          checked { this.RC1 += 12; }
        }
        else
        {
          switch (SAP_Module.Proj.Dwellings[House].MainHeating.SAPTableCode)
          {
            case 201:
            case 202:
            case 205:
            case 525:
              this.LowCarbonTex = "• Pwmp gwres sy'n tarddu yn y ddaear\r\n";
              XGraphics xgraphics1 = PDFFunctions.gfx[this.k];
              string lowCarbonTex1 = this.LowCarbonTex;
              XFont arialFont11_1 = PDFFunctions.ArialFont11;
              XSolidBrush black1 = XBrushes.Black;
              double rc1_13 = (double) this.RC1;
              xunit = PDFFunctions.pages[this.k].Width;
              double point23 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[this.k].Height;
              double point24 = ((XUnit) ref xunit).Point;
              XRect xrect1 = new XRect(25.0, rc1_13, point23, point24);
              XStringFormat topLeft1 = XStringFormat.TopLeft;
              xgraphics1.DrawString(lowCarbonTex1, arialFont11_1, (XBrush) black1, xrect1, topLeft1);
              this.LowCarbonTex = "";
              checked { ++num7; }
              checked { this.RC1 += 12; }
              break;
            case 204:
            case 207:
            case 524:
            case 527:
              this.LowCarbonTex = "• Pwmp gwres sy’n tarddu yn yr awyr\r\n";
              XGraphics xgraphics2 = PDFFunctions.gfx[this.k];
              string lowCarbonTex2 = this.LowCarbonTex;
              XFont arialFont11_2 = PDFFunctions.ArialFont11;
              XSolidBrush black2 = XBrushes.Black;
              double rc1_14 = (double) this.RC1;
              xunit = PDFFunctions.pages[this.k].Width;
              double point25 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[this.k].Height;
              double point26 = ((XUnit) ref xunit).Point;
              XRect xrect2 = new XRect(25.0, rc1_14, point25, point26);
              XStringFormat topLeft2 = XStringFormat.TopLeft;
              xgraphics2.DrawString(lowCarbonTex2, arialFont11_2, (XBrush) black2, xrect2, topLeft2);
              this.LowCarbonTex = "";
              checked { ++num7; }
              checked { this.RC1 += 12; }
              break;
            case 206:
            case 526:
              this.LowCarbonTex = "• Pwmp gwres sy'n tarddu mewn dŵr\r\n";
              XGraphics xgraphics3 = PDFFunctions.gfx[this.k];
              string lowCarbonTex3 = this.LowCarbonTex;
              XFont arialFont11_3 = PDFFunctions.ArialFont11;
              XSolidBrush black3 = XBrushes.Black;
              double rc1_15 = (double) this.RC1;
              xunit = PDFFunctions.pages[this.k].Width;
              double point27 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[this.k].Height;
              double point28 = ((XUnit) ref xunit).Point;
              XRect xrect3 = new XRect(25.0, rc1_15, point27, point28);
              XStringFormat topLeft3 = XStringFormat.TopLeft;
              xgraphics3.DrawString(lowCarbonTex3, arialFont11_3, (XBrush) black3, xrect3, topLeft3);
              this.LowCarbonTex = "";
              checked { ++num7; }
              checked { this.RC1 += 12; }
              break;
            case 307:
              this.LowCarbonTex = "• Gwres a phŵer cyfun\r\n";
              XGraphics xgraphics4 = PDFFunctions.gfx[this.k];
              string lowCarbonTex4 = this.LowCarbonTex;
              XFont arialFont11_4 = PDFFunctions.ArialFont11;
              XSolidBrush black4 = XBrushes.Black;
              double rc1_16 = (double) this.RC1;
              xunit = PDFFunctions.pages[this.k].Width;
              double point29 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[this.k].Height;
              double point30 = ((XUnit) ref xunit).Point;
              XRect xrect4 = new XRect(25.0, rc1_16, point29, point30);
              XStringFormat topLeft4 = XStringFormat.TopLeft;
              xgraphics4.DrawString(lowCarbonTex4, arialFont11_4, (XBrush) black4, xrect4, topLeft4);
              this.LowCarbonTex = "";
              checked { ++num7; }
              checked { this.RC1 += 12; }
              break;
            case 310:
              this.LowCarbonTex = "• Ffynhonnell wres geothermol\r\n";
              XGraphics xgraphics5 = PDFFunctions.gfx[this.k];
              string lowCarbonTex5 = this.LowCarbonTex;
              XFont arialFont11_5 = PDFFunctions.ArialFont11;
              XSolidBrush black5 = XBrushes.Black;
              double rc1_17 = (double) this.RC1;
              xunit = PDFFunctions.pages[this.k].Width;
              double point31 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[this.k].Height;
              double point32 = ((XUnit) ref xunit).Point;
              XRect xrect5 = new XRect(25.0, rc1_17, point31, point32);
              XStringFormat topLeft5 = XStringFormat.TopLeft;
              xgraphics5.DrawString(lowCarbonTex5, arialFont11_5, (XBrush) black5, xrect5, topLeft5);
              this.LowCarbonTex = "";
              checked { ++num7; }
              checked { this.RC1 += 12; }
              break;
          }
        }
        if (SAP_Module.Proj.Dwellings[House].MainHeating.SAPTableCode == 309)
        {
          this.LowCarbonTex = "• Pwmp gwres cymunedol\r\n";
          XGraphics xgraphics6 = PDFFunctions.gfx[this.k];
          string lowCarbonTex6 = this.LowCarbonTex;
          XFont arialFont11_6 = PDFFunctions.ArialFont11;
          XSolidBrush black6 = XBrushes.Black;
          double rc1_18 = (double) this.RC1;
          xunit = PDFFunctions.pages[this.k].Width;
          double point33 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[this.k].Height;
          double point34 = ((XUnit) ref xunit).Point;
          XRect xrect6 = new XRect(25.0, rc1_18, point33, point34);
          XStringFormat topLeft6 = XStringFormat.TopLeft;
          xgraphics6.DrawString(lowCarbonTex6, arialFont11_6, (XBrush) black6, xrect6, topLeft6);
          this.LowCarbonTex = "";
          checked { ++num7; }
          checked { this.RC1 += 12; }
        }
        if (num7 == 0)
        {
          this.LowCarbonTex = "Dim";
          str1 = "";
        }
        if (country == 4)
        {
          XGraphics xgraphics7 = PDFFunctions.gfx[this.k];
          XFont arialFont11_7 = PDFFunctions.ArialFont11;
          XSolidBrush black7 = XBrushes.Black;
          double num8 = (double) checked (rc1_1 - 16);
          xunit = PDFFunctions.pages[this.k].Width;
          double point35 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[this.k].Height;
          double point36 = ((XUnit) ref xunit).Point;
          XRect xrect7 = new XRect(25.0, num8, point35, point36);
          XStringFormat topLeft7 = XStringFormat.TopLeft;
          xgraphics7.DrawString("These are sources of energy (producing or providing electricity or hot water) which emit little or no carbon", arialFont11_7, (XBrush) black7, xrect7, topLeft7);
          XGraphics xgraphics8 = PDFFunctions.gfx[this.k];
          XFont arialFont11_8 = PDFFunctions.ArialFont11;
          XSolidBrush black8 = XBrushes.Black;
          double num9 = (double) rc1_1;
          xunit = PDFFunctions.pages[this.k].Width;
          double point37 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[this.k].Height;
          double point38 = ((XUnit) ref xunit).Point;
          XRect xrect8 = new XRect(25.0, num9, point37, point38);
          XStringFormat topLeft8 = XStringFormat.TopLeft;
          xgraphics8.DrawString("dioxide into the atmosphere. The following are provided for this home:", arialFont11_8, (XBrush) black8, xrect8, topLeft8);
          checked { this.RC1 += 20; }
        }
        else
        {
          XGraphics xgraphics9 = PDFFunctions.gfx[this.k];
          string str4 = str1;
          XFont arialFont11_9 = PDFFunctions.ArialFont11;
          XSolidBrush black9 = XBrushes.Black;
          double num10 = (double) rc1_1;
          xunit = PDFFunctions.pages[this.k].Width;
          double point39 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[this.k].Height;
          double point40 = ((XUnit) ref xunit).Point;
          XRect xrect9 = new XRect(25.0, num10, point39, point40);
          XStringFormat topLeft9 = XStringFormat.TopLeft;
          xgraphics9.DrawString(str4, arialFont11_9, (XBrush) black9, xrect9, topLeft9);
          checked { this.RC1 += 17; }
        }
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.LowCarbonTex, "Dim", false) == 0)
        {
          XGraphics xgraphics10 = PDFFunctions.gfx[this.k];
          string lowCarbonTex7 = this.LowCarbonTex;
          XFont arialFont11_10 = PDFFunctions.ArialFont11;
          XSolidBrush black10 = XBrushes.Black;
          double num11 = (double) rc1_1;
          xunit = PDFFunctions.pages[this.k].Width;
          double point41 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[this.k].Height;
          double point42 = ((XUnit) ref xunit).Point;
          XRect xrect10 = new XRect(25.0, num11, point41, point42);
          XStringFormat topLeft10 = XStringFormat.TopLeft;
          xgraphics10.DrawString(lowCarbonTex7, arialFont11_10, (XBrush) black10, xrect10, topLeft10);
          checked { this.RC1 += 12; }
        }
      }
      else
      {
        if (SAP_Module.Proj.Dwellings[House].Renewable.Photovoltaic.Inlcude)
        {
          // ISSUE: variable of a reference type
          string& local5;
          // ISSUE: explicit reference operation
          string str5 = ^(local5 = ref this.LowCarbonTex) + "• Solar photovoltaics\r\n";
          local5 = str5;
          XGraphics xgraphics = PDFFunctions.gfx[this.k];
          string lowCarbonTex = this.LowCarbonTex;
          XFont arialFont11 = PDFFunctions.ArialFont11;
          XSolidBrush black = XBrushes.Black;
          double rc1_19 = (double) this.RC1;
          xunit = PDFFunctions.pages[this.k].Width;
          double point43 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[this.k].Height;
          double point44 = ((XUnit) ref xunit).Point;
          XRect xrect = new XRect(25.0, rc1_19, point43, point44);
          XStringFormat topLeft = XStringFormat.TopLeft;
          xgraphics.DrawString(lowCarbonTex, arialFont11, (XBrush) black, xrect, topLeft);
          this.LowCarbonTex = "";
          checked { ++num7; }
          checked { this.RC1 += 12; }
        }
        if (SAP_Module.Proj.Dwellings[House].Water.Solar.Inlcude)
        {
          // ISSUE: variable of a reference type
          string& local6;
          // ISSUE: explicit reference operation
          string str6 = ^(local6 = ref this.LowCarbonTex) + "• Solar water heating\r\n";
          local6 = str6;
          XGraphics xgraphics = PDFFunctions.gfx[this.k];
          string lowCarbonTex = this.LowCarbonTex;
          XFont arialFont11 = PDFFunctions.ArialFont11;
          XSolidBrush black = XBrushes.Black;
          double rc1_20 = (double) this.RC1;
          xunit = PDFFunctions.pages[this.k].Width;
          double point45 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[this.k].Height;
          double point46 = ((XUnit) ref xunit).Point;
          XRect xrect = new XRect(25.0, rc1_20, point45, point46);
          XStringFormat topLeft = XStringFormat.TopLeft;
          xgraphics.DrawString(lowCarbonTex, arialFont11, (XBrush) black, xrect, topLeft);
          this.LowCarbonTex = "";
          checked { ++num7; }
          checked { this.RC1 += 12; }
        }
        if (SAP_Module.Proj.Dwellings[House].Renewable.WindTurbine.Inlcude)
        {
          this.LowCarbonTex = "• Wind turbine\r\n";
          XGraphics xgraphics = PDFFunctions.gfx[this.k];
          string lowCarbonTex = this.LowCarbonTex;
          XFont arialFont11 = PDFFunctions.ArialFont11;
          XSolidBrush black = XBrushes.Black;
          double rc1_21 = (double) this.RC1;
          xunit = PDFFunctions.pages[this.k].Width;
          double point47 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[this.k].Height;
          double point48 = ((XUnit) ref xunit).Point;
          XRect xrect = new XRect(25.0, rc1_21, point47, point48);
          XStringFormat topLeft = XStringFormat.TopLeft;
          xgraphics.DrawString(lowCarbonTex, arialFont11, (XBrush) black, xrect, topLeft);
          this.LowCarbonTex = "";
          checked { ++num7; }
          checked { this.RC1 += 12; }
        }
        if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.Fuel, (string) null, false) > 0U)
        {
          if (SAP_Module.Proj.Dwellings[House].MainHeating.Fuel.Contains("rapeseed"))
          {
            this.LowCarbonTex = "• Biomass Main heating\r\n";
            XGraphics xgraphics = PDFFunctions.gfx[this.k];
            string lowCarbonTex = this.LowCarbonTex;
            XFont arialFont11 = PDFFunctions.ArialFont11;
            XSolidBrush black = XBrushes.Black;
            double rc1_22 = (double) this.RC1;
            xunit = PDFFunctions.pages[this.k].Width;
            double point49 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[this.k].Height;
            double point50 = ((XUnit) ref xunit).Point;
            XRect xrect = new XRect(25.0, rc1_22, point49, point50);
            XStringFormat topLeft = XStringFormat.TopLeft;
            xgraphics.DrawString(lowCarbonTex, arialFont11, (XBrush) black, xrect, topLeft);
            this.LowCarbonTex = "";
            checked { ++num7; }
            checked { this.RC1 += 12; }
          }
          if (SAP_Module.Proj.Dwellings[House].MainHeating.Fuel.Contains("diesel"))
          {
            this.LowCarbonTex = "• Biomass Main heating\r\n";
            XGraphics xgraphics = PDFFunctions.gfx[this.k];
            string lowCarbonTex = this.LowCarbonTex;
            XFont arialFont11 = PDFFunctions.ArialFont11;
            XSolidBrush black = XBrushes.Black;
            double rc1_23 = (double) this.RC1;
            xunit = PDFFunctions.pages[this.k].Width;
            double point51 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[this.k].Height;
            double point52 = ((XUnit) ref xunit).Point;
            XRect xrect = new XRect(25.0, rc1_23, point51, point52);
            XStringFormat topLeft = XStringFormat.TopLeft;
            xgraphics.DrawString(lowCarbonTex, arialFont11, (XBrush) black, xrect, topLeft);
            this.LowCarbonTex = "";
            checked { ++num7; }
            checked { this.RC1 += 12; }
          }
        }
        if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.Fuel, (string) null, false) > 0U && SAP_Module.Proj.Dwellings[House].MainHeating.Fuel.Contains("wood"))
        {
          int sapTableCode = SAP_Module.Proj.Dwellings[House].MainHeating.SAPTableCode;
          if (sapTableCode < 310 || sapTableCode > 315)
          {
            this.LowCarbonTex = "• Biomass Main heating\r\n";
            XGraphics xgraphics = PDFFunctions.gfx[this.k];
            string lowCarbonTex = this.LowCarbonTex;
            XFont arialFont11 = PDFFunctions.ArialFont11;
            XSolidBrush black = XBrushes.Black;
            double rc1_24 = (double) this.RC1;
            xunit = PDFFunctions.pages[this.k].Width;
            double point53 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[this.k].Height;
            double point54 = ((XUnit) ref xunit).Point;
            XRect xrect = new XRect(25.0, rc1_24, point53, point54);
            XStringFormat topLeft = XStringFormat.TopLeft;
            xgraphics.DrawString(lowCarbonTex, arialFont11, (XBrush) black, xrect, topLeft);
            this.LowCarbonTex = "";
            checked { ++num7; }
            checked { this.RC1 += 12; }
          }
        }
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.CommunityH.Boiler2CHPFuel, "", false) == 0)
        {
          if (SAP_Module.Proj.Dwellings[House].MainHeating.Fuel.Contains("iomass"))
          {
            int sapTableCode = SAP_Module.Proj.Dwellings[House].MainHeating.SAPTableCode;
            if (sapTableCode >= 308 && sapTableCode <= 310)
            {
              this.LowCarbonTex = "• Biomass community heating\r\n";
              XGraphics xgraphics = PDFFunctions.gfx[this.k];
              string lowCarbonTex = this.LowCarbonTex;
              XFont arialFont11 = PDFFunctions.ArialFont11;
              XSolidBrush black = XBrushes.Black;
              double rc1_25 = (double) this.RC1;
              xunit = PDFFunctions.pages[this.k].Width;
              double point55 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[this.k].Height;
              double point56 = ((XUnit) ref xunit).Point;
              XRect xrect = new XRect(25.0, rc1_25, point55, point56);
              XStringFormat topLeft = XStringFormat.TopLeft;
              xgraphics.DrawString(lowCarbonTex, arialFont11, (XBrush) black, xrect, topLeft);
              this.LowCarbonTex = "";
              checked { ++num7; }
              checked { this.RC1 += 12; }
            }
            else if (sapTableCode == 307)
            {
              this.LowCarbonTex = "• Biomass community heating for some of heat generation\r\n";
              XGraphics xgraphics = PDFFunctions.gfx[this.k];
              string lowCarbonTex = this.LowCarbonTex;
              XFont arialFont11 = PDFFunctions.ArialFont11;
              XSolidBrush black = XBrushes.Black;
              double rc1_26 = (double) this.RC1;
              xunit = PDFFunctions.pages[this.k].Width;
              double point57 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[this.k].Height;
              double point58 = ((XUnit) ref xunit).Point;
              XRect xrect = new XRect(25.0, rc1_26, point57, point58);
              XStringFormat topLeft = XStringFormat.TopLeft;
              xgraphics.DrawString(lowCarbonTex, arialFont11, (XBrush) black, xrect, topLeft);
              this.LowCarbonTex = "";
              checked { ++num7; }
              checked { this.RC1 += 12; }
            }
          }
        }
        else if (SAP_Module.Proj.Dwellings[House].MainHeating.Fuel.Contains("iomass") | SAP_Module.Proj.Dwellings[House].MainHeating.CommunityH.Boiler2CHPFuel.Contains("iomass") | SAP_Module.Proj.Dwellings[House].Water.Fuel.Contains("iomass"))
        {
          int sapTableCode = SAP_Module.Proj.Dwellings[House].MainHeating.SAPTableCode;
          if (sapTableCode == 306 || sapTableCode >= 308 && sapTableCode <= 310)
          {
            this.LowCarbonTex = "• Biomass community heating\r\n";
            XGraphics xgraphics = PDFFunctions.gfx[this.k];
            string lowCarbonTex = this.LowCarbonTex;
            XFont arialFont11 = PDFFunctions.ArialFont11;
            XSolidBrush black = XBrushes.Black;
            double rc1_27 = (double) this.RC1;
            xunit = PDFFunctions.pages[this.k].Width;
            double point59 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[this.k].Height;
            double point60 = ((XUnit) ref xunit).Point;
            XRect xrect = new XRect(25.0, rc1_27, point59, point60);
            XStringFormat topLeft = XStringFormat.TopLeft;
            xgraphics.DrawString(lowCarbonTex, arialFont11, (XBrush) black, xrect, topLeft);
            this.LowCarbonTex = "";
            checked { ++num7; }
            checked { this.RC1 += 12; }
          }
          else if (sapTableCode == 307)
          {
            this.LowCarbonTex = "• Biomass community heating for some of heat generation\r\n";
            XGraphics xgraphics = PDFFunctions.gfx[this.k];
            string lowCarbonTex = this.LowCarbonTex;
            XFont arialFont11 = PDFFunctions.ArialFont11;
            XSolidBrush black = XBrushes.Black;
            double rc1_28 = (double) this.RC1;
            xunit = PDFFunctions.pages[this.k].Width;
            double point61 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[this.k].Height;
            double point62 = ((XUnit) ref xunit).Point;
            XRect xrect = new XRect(25.0, rc1_28, point61, point62);
            XStringFormat topLeft = XStringFormat.TopLeft;
            xgraphics.DrawString(lowCarbonTex, arialFont11, (XBrush) black, xrect, topLeft);
            this.LowCarbonTex = "";
            checked { ++num7; }
            checked { this.RC1 += 12; }
          }
          else
          {
            this.LowCarbonTex = "• Biomass community heating for some of heat generation\r\n";
            XGraphics xgraphics = PDFFunctions.gfx[this.k];
            string lowCarbonTex = this.LowCarbonTex;
            XFont arialFont11 = PDFFunctions.ArialFont11;
            XSolidBrush black = XBrushes.Black;
            double rc1_29 = (double) this.RC1;
            xunit = PDFFunctions.pages[this.k].Width;
            double point63 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[this.k].Height;
            double point64 = ((XUnit) ref xunit).Point;
            XRect xrect = new XRect(25.0, rc1_29, point63, point64);
            XStringFormat topLeft = XStringFormat.TopLeft;
            xgraphics.DrawString(lowCarbonTex, arialFont11, (XBrush) black, xrect, topLeft);
            this.LowCarbonTex = "";
            checked { ++num7; }
            checked { this.RC1 += 12; }
          }
        }
        if (SAP_Module.Proj.Dwellings[House].SecHeating.Fuel.Contains("wood") & !SAP_Module.Proj.Dwellings[House].SecHeating.Fuel.Contains("dual"))
        {
          this.LowCarbonTex = "• Biomass secondary heating\r\n";
          XGraphics xgraphics = PDFFunctions.gfx[this.k];
          string lowCarbonTex = this.LowCarbonTex;
          XFont arialFont11 = PDFFunctions.ArialFont11;
          XSolidBrush black = XBrushes.Black;
          double rc1_30 = (double) this.RC1;
          xunit = PDFFunctions.pages[this.k].Width;
          double point65 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[this.k].Height;
          double point66 = ((XUnit) ref xunit).Point;
          XRect xrect = new XRect(25.0, rc1_30, point65, point66);
          XStringFormat topLeft = XStringFormat.TopLeft;
          xgraphics.DrawString(lowCarbonTex, arialFont11, (XBrush) black, xrect, topLeft);
          this.LowCarbonTex = "";
          checked { ++num7; }
          checked { this.RC1 += 12; }
        }
        this.additional_heating = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.HGroup, "Community heating schemes", false) != 0 ? 0 : SAP_Module.Proj.Dwellings[House].MainHeating.CommunityH.NoOfAdditionalHeatSources;
        this.additional_water = !SAP_Module.Proj.Dwellings[House].Water.System.Contains("From hot-water only community scheme") ? 0 : SAP_Module.Proj.Dwellings[House].Water.HWSComm.NoOfAdditionalHeatSources;
        int num12 = checked (this.additional_heating + this.additional_water + 1);
        int num13 = 0;
        while (num13 <= num12)
        {
          // ISSUE: object of a compiler-generated type is created
          // ISSUE: variable of a compiler-generated type
          CreatePDF._Closure\u0024__83\u002D0 closure830 = new CreatePDF._Closure\u0024__83\u002D0(closure830);
          string fuel;
          string Left1;
          string str7;
          switch (num13)
          {
            case 0:
              fuel = SAP_Module.Proj.Dwellings[House].MainHeating.Fuel;
              Left1 = SAP_Module.Proj.Dwellings[House].MainHeating.SGroup;
              str7 = Conversions.ToString(SAP_Module.Proj.Dwellings[House].MainHeating.SAPTableCode);
              // ISSUE: reference to a compiler-generated field
              closure830.\u0024VB\u0024Local_heating_sedbuk = (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating.SEDBUK, "", false) <= 0U ? 0 : Conversions.ToInteger(SAP_Module.Proj.Dwellings[House].MainHeating.SEDBUK);
              break;
            case 1:
              fuel = SAP_Module.Proj.Dwellings[House].MainHeating2.Fuel;
              Left1 = SAP_Module.Proj.Dwellings[House].MainHeating2.SGroup;
              str7 = Conversions.ToString(SAP_Module.Proj.Dwellings[House].MainHeating2.SAPTableCode);
              // ISSUE: reference to a compiler-generated field
              closure830.\u0024VB\u0024Local_heating_sedbuk = (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[House].MainHeating2.SEDBUK, "", false) <= 0U ? 0 : Conversions.ToInteger(SAP_Module.Proj.Dwellings[House].MainHeating2.SEDBUK);
              break;
            case 2:
              if (checked (num13 - 2) >= this.additional_heating)
              {
                fuel = SAP_Module.Proj.Dwellings[House].Water.HWSComm.HeatSource1.Fuel;
                Left1 = SAP_Module.Proj.Dwellings[House].Water.HWSComm.HeatSource1.Fuel;
                str7 = Conversions.ToString(SAP_Module.Proj.Dwellings[House].Water.HWSComm.HeatSource1.Type);
                break;
              }
              fuel = SAP_Module.Proj.Dwellings[House].MainHeating.CommunityH.HeatSource1.Fuel;
              Left1 = SAP_Module.Proj.Dwellings[House].MainHeating.CommunityH.HeatSource1.Fuel;
              str7 = Conversions.ToString(SAP_Module.Proj.Dwellings[House].MainHeating.CommunityH.HeatSource1.Type);
              break;
            case 3:
              if (checked (num13 - 2) >= this.additional_heating)
              {
                if (this.additional_heating == 1)
                {
                  fuel = SAP_Module.Proj.Dwellings[House].Water.HWSComm.HeatSource1.Fuel;
                  Left1 = SAP_Module.Proj.Dwellings[House].Water.HWSComm.HeatSource1.Fuel;
                  str7 = Conversions.ToString(SAP_Module.Proj.Dwellings[House].Water.HWSComm.HeatSource1.Type);
                  break;
                }
                fuel = SAP_Module.Proj.Dwellings[House].Water.HWSComm.HeatSource2.Fuel;
                Left1 = SAP_Module.Proj.Dwellings[House].Water.HWSComm.HeatSource2.Fuel;
                str7 = Conversions.ToString(SAP_Module.Proj.Dwellings[House].Water.HWSComm.HeatSource2.Type);
                break;
              }
              fuel = SAP_Module.Proj.Dwellings[House].MainHeating.CommunityH.HeatSource2.Fuel;
              Left1 = SAP_Module.Proj.Dwellings[House].MainHeating.CommunityH.HeatSource2.Fuel;
              str7 = Conversions.ToString(SAP_Module.Proj.Dwellings[House].MainHeating.CommunityH.HeatSource2.Type);
              break;
            case 4:
              if (checked (num13 - 2) >= this.additional_heating)
              {
                if (this.additional_heating == 2)
                {
                  fuel = SAP_Module.Proj.Dwellings[House].Water.HWSComm.HeatSource1.Fuel;
                  Left1 = SAP_Module.Proj.Dwellings[House].Water.HWSComm.HeatSource1.Fuel;
                  str7 = Conversions.ToString(SAP_Module.Proj.Dwellings[House].Water.HWSComm.HeatSource1.Type);
                  break;
                }
                if (this.additional_heating == 1)
                {
                  fuel = SAP_Module.Proj.Dwellings[House].Water.HWSComm.HeatSource2.Fuel;
                  Left1 = SAP_Module.Proj.Dwellings[House].Water.HWSComm.HeatSource2.Fuel;
                  str7 = Conversions.ToString(SAP_Module.Proj.Dwellings[House].Water.HWSComm.HeatSource2.Type);
                  break;
                }
                fuel = SAP_Module.Proj.Dwellings[House].Water.HWSComm.HeatSource3.Fuel;
                Left1 = SAP_Module.Proj.Dwellings[House].Water.HWSComm.HeatSource3.Fuel;
                str7 = Conversions.ToString(SAP_Module.Proj.Dwellings[House].Water.HWSComm.HeatSource3.Type);
                break;
              }
              fuel = SAP_Module.Proj.Dwellings[House].MainHeating.CommunityH.HeatSource3.Fuel;
              Left1 = SAP_Module.Proj.Dwellings[House].MainHeating.CommunityH.HeatSource3.Fuel;
              str7 = Conversions.ToString(SAP_Module.Proj.Dwellings[House].MainHeating.CommunityH.HeatSource3.Type);
              break;
            case 5:
              if (checked (num13 - 2) >= this.additional_heating)
              {
                if (this.additional_heating == 3)
                {
                  fuel = SAP_Module.Proj.Dwellings[House].Water.HWSComm.HeatSource1.Fuel;
                  Left1 = SAP_Module.Proj.Dwellings[House].Water.HWSComm.HeatSource1.Fuel;
                  str7 = Conversions.ToString(SAP_Module.Proj.Dwellings[House].Water.HWSComm.HeatSource1.Type);
                  break;
                }
                if (this.additional_heating == 2)
                {
                  fuel = SAP_Module.Proj.Dwellings[House].Water.HWSComm.HeatSource2.Fuel;
                  Left1 = SAP_Module.Proj.Dwellings[House].Water.HWSComm.HeatSource2.Fuel;
                  str7 = Conversions.ToString(SAP_Module.Proj.Dwellings[House].Water.HWSComm.HeatSource2.Type);
                  break;
                }
                if (this.additional_heating == 1)
                {
                  fuel = SAP_Module.Proj.Dwellings[House].Water.HWSComm.HeatSource3.Fuel;
                  Left1 = SAP_Module.Proj.Dwellings[House].Water.HWSComm.HeatSource3.Fuel;
                  str7 = Conversions.ToString(SAP_Module.Proj.Dwellings[House].Water.HWSComm.HeatSource3.Type);
                  break;
                }
                fuel = SAP_Module.Proj.Dwellings[House].Water.HWSComm.HeatSource4.Fuel;
                Left1 = SAP_Module.Proj.Dwellings[House].Water.HWSComm.HeatSource4.Fuel;
                str7 = Conversions.ToString(SAP_Module.Proj.Dwellings[House].Water.HWSComm.HeatSource4.Type);
                break;
              }
              fuel = SAP_Module.Proj.Dwellings[House].MainHeating.CommunityH.HeatSource4.Fuel;
              Left1 = SAP_Module.Proj.Dwellings[House].MainHeating.CommunityH.HeatSource4.Fuel;
              str7 = Conversions.ToString(SAP_Module.Proj.Dwellings[House].MainHeating.CommunityH.HeatSource4.Type);
              break;
            case 6:
              if (this.additional_heating == 4)
              {
                fuel = SAP_Module.Proj.Dwellings[House].Water.HWSComm.HeatSource1.Fuel;
                Left1 = SAP_Module.Proj.Dwellings[House].Water.HWSComm.HeatSource1.Fuel;
                str7 = Conversions.ToString(SAP_Module.Proj.Dwellings[House].Water.HWSComm.HeatSource1.Type);
                break;
              }
              if (this.additional_heating == 3)
              {
                fuel = SAP_Module.Proj.Dwellings[House].Water.HWSComm.HeatSource2.Fuel;
                Left1 = SAP_Module.Proj.Dwellings[House].Water.HWSComm.HeatSource2.Fuel;
                str7 = Conversions.ToString(SAP_Module.Proj.Dwellings[House].Water.HWSComm.HeatSource2.Type);
                break;
              }
              if (this.additional_heating == 2)
              {
                fuel = SAP_Module.Proj.Dwellings[House].Water.HWSComm.HeatSource3.Fuel;
                Left1 = SAP_Module.Proj.Dwellings[House].Water.HWSComm.HeatSource3.Fuel;
                str7 = Conversions.ToString(SAP_Module.Proj.Dwellings[House].Water.HWSComm.HeatSource3.Type);
                break;
              }
              fuel = SAP_Module.Proj.Dwellings[House].Water.HWSComm.HeatSource4.Fuel;
              Left1 = SAP_Module.Proj.Dwellings[House].Water.HWSComm.HeatSource4.Fuel;
              str7 = Conversions.ToString(SAP_Module.Proj.Dwellings[House].Water.HWSComm.HeatSource4.Type);
              break;
            case 7:
              if (this.additional_heating == 4)
              {
                fuel = SAP_Module.Proj.Dwellings[House].Water.HWSComm.HeatSource2.Fuel;
                Left1 = SAP_Module.Proj.Dwellings[House].Water.HWSComm.HeatSource2.Fuel;
                str7 = Conversions.ToString(SAP_Module.Proj.Dwellings[House].Water.HWSComm.HeatSource2.Type);
                break;
              }
              if (this.additional_heating == 3)
              {
                fuel = SAP_Module.Proj.Dwellings[House].Water.HWSComm.HeatSource3.Fuel;
                Left1 = SAP_Module.Proj.Dwellings[House].Water.HWSComm.HeatSource3.Fuel;
                str7 = Conversions.ToString(SAP_Module.Proj.Dwellings[House].Water.HWSComm.HeatSource3.Type);
                break;
              }
              fuel = SAP_Module.Proj.Dwellings[House].Water.HWSComm.HeatSource4.Fuel;
              Left1 = SAP_Module.Proj.Dwellings[House].Water.HWSComm.HeatSource4.Fuel;
              str7 = Conversions.ToString(SAP_Module.Proj.Dwellings[House].Water.HWSComm.HeatSource4.Type);
              break;
            case 8:
              if (this.additional_heating == 4)
              {
                fuel = SAP_Module.Proj.Dwellings[House].Water.HWSComm.HeatSource3.Fuel;
                Left1 = SAP_Module.Proj.Dwellings[House].Water.HWSComm.HeatSource3.Fuel;
                str7 = Conversions.ToString(SAP_Module.Proj.Dwellings[House].Water.HWSComm.HeatSource3.Type);
                break;
              }
              fuel = SAP_Module.Proj.Dwellings[House].Water.HWSComm.HeatSource4.Fuel;
              Left1 = SAP_Module.Proj.Dwellings[House].Water.HWSComm.HeatSource4.Fuel;
              str7 = Conversions.ToString(SAP_Module.Proj.Dwellings[House].Water.HWSComm.HeatSource4.Type);
              break;
            case 9:
              fuel = SAP_Module.Proj.Dwellings[House].Water.HWSComm.HeatSource4.Fuel;
              Left1 = SAP_Module.Proj.Dwellings[House].Water.HWSComm.HeatSource4.Fuel;
              str7 = Conversions.ToString(SAP_Module.Proj.Dwellings[House].Water.HWSComm.HeatSource4.Type);
              break;
          }
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left1, "Micro-cogeneration (micro-CHP)", false) == 0 | SAP_Module.Proj.Dwellings[House].Water.SystemRef == 951 & num13 == 0)
          {
            this.combine_heat = true;
          }
          else
          {
            string Left2 = str7;
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left2, Conversions.ToString(310), false) == 0)
              this.geothermal_heat = true;
            else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left2, Conversions.ToString(307), false) == 0)
              this.combine_heat = true;
            else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left2, Conversions.ToString(205), false) == 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left2, Conversions.ToString(525), false) == 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left2, Conversions.ToString(201), false) == 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left2, Conversions.ToString(202), false) == 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left2, Conversions.ToString(521), false) == 0)
              this.ground_source = true;
            else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left2, Conversions.ToString(206), false) == 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left2, Conversions.ToString(526), false) == 0)
              this.water_source = true;
            else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left2, Conversions.ToString(207), false) == 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left2, Conversions.ToString(204), false) == 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left2, Conversions.ToString(527), false) == 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left2, Conversions.ToString(524), false) == 0)
              this.air_source = true;
            else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left2, Conversions.ToString(304), false) == 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left2, Conversions.ToString(309), false) == 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left2, Conversions.ToString(952), false) == 0)
            {
              this.comunity_heat = true;
            }
            else
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left1, "Heat pumps", false) == 0)
              {
                // ISSUE: reference to a compiler-generated method
                this.SearchRowHP = SAP_Module.PCDFData.HeatPumps.Where<PCDF.HeatPump>(new Func<PCDF.HeatPump, bool>(closure830._Lambda\u0024__0)).SingleOrDefault<PCDF.HeatPump>();
                if (this.SearchRowHP != null)
                {
                  string heatSource = this.SearchRowHP.Heat_Source;
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(heatSource, Conversions.ToString(1), false) == 0)
                    this.ground_source = true;
                  else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(heatSource, Conversions.ToString(2), false) == 0)
                    this.water_source = true;
                  else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(heatSource, Conversions.ToString(3), false) == 0)
                    this.air_source = true;
                  else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(heatSource, Conversions.ToString(4), false) == 0)
                    this.exhaust_air = true;
                }
              }
              if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel, (string) null, false) > 0U && fuel.Contains("iomass"))
                this.biomass = true;
            }
          }
          checked { ++num13; }
        }
        if (this.combine_heat)
        {
          this.LowCarbonTex = "• Combined heat and power\r\n";
          if (flag)
            this.LowCarbonTex = "• Gwres a phŵer cyfun cymunedol\r\n";
          XGraphics xgraphics = PDFFunctions.gfx[this.k];
          string lowCarbonTex = this.LowCarbonTex;
          XFont arialFont11 = PDFFunctions.ArialFont11;
          XSolidBrush black = XBrushes.Black;
          double rc1_31 = (double) this.RC1;
          xunit = PDFFunctions.pages[this.k].Width;
          double point67 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[this.k].Height;
          double point68 = ((XUnit) ref xunit).Point;
          XRect xrect = new XRect(25.0, rc1_31, point67, point68);
          XStringFormat topLeft = XStringFormat.TopLeft;
          xgraphics.DrawString(lowCarbonTex, arialFont11, (XBrush) black, xrect, topLeft);
          this.LowCarbonTex = "";
          checked { ++num7; }
          checked { this.RC1 += 12; }
        }
        if (this.geothermal_heat)
        {
          this.LowCarbonTex = "• Geothermal heat source\r\n";
          if (flag)
            this.LowCarbonTex = "• Ffynhonnell wres geothermol\r\n";
          XGraphics xgraphics = PDFFunctions.gfx[this.k];
          string lowCarbonTex = this.LowCarbonTex;
          XFont arialFont11 = PDFFunctions.ArialFont11;
          XSolidBrush black = XBrushes.Black;
          double rc1_32 = (double) this.RC1;
          xunit = PDFFunctions.pages[this.k].Width;
          double point69 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[this.k].Height;
          double point70 = ((XUnit) ref xunit).Point;
          XRect xrect = new XRect(25.0, rc1_32, point69, point70);
          XStringFormat topLeft = XStringFormat.TopLeft;
          xgraphics.DrawString(lowCarbonTex, arialFont11, (XBrush) black, xrect, topLeft);
          this.LowCarbonTex = "";
          checked { ++num7; }
          checked { this.RC1 += 12; }
        }
        if (this.ground_source)
        {
          this.LowCarbonTex = "• Ground source heat pump\r\n";
          if (flag)
            this.LowCarbonTex = "• Pwmp gwres sy'n tarddu yn y ddaear\r\n";
          XGraphics xgraphics = PDFFunctions.gfx[this.k];
          string lowCarbonTex = this.LowCarbonTex;
          XFont arialFont11 = PDFFunctions.ArialFont11;
          XSolidBrush black = XBrushes.Black;
          double rc1_33 = (double) this.RC1;
          xunit = PDFFunctions.pages[this.k].Width;
          double point71 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[this.k].Height;
          double point72 = ((XUnit) ref xunit).Point;
          XRect xrect = new XRect(25.0, rc1_33, point71, point72);
          XStringFormat topLeft = XStringFormat.TopLeft;
          xgraphics.DrawString(lowCarbonTex, arialFont11, (XBrush) black, xrect, topLeft);
          this.LowCarbonTex = "";
          checked { ++num7; }
          checked { this.RC1 += 12; }
        }
        if (this.water_source)
        {
          this.LowCarbonTex = "• Water source heat pump\r\n";
          if (flag)
            this.LowCarbonTex = "• Pwmp gwres sy'n tarddu mewn dŵr\r\n";
          XGraphics xgraphics = PDFFunctions.gfx[this.k];
          string lowCarbonTex = this.LowCarbonTex;
          XFont arialFont11 = PDFFunctions.ArialFont11;
          XSolidBrush black = XBrushes.Black;
          double rc1_34 = (double) this.RC1;
          xunit = PDFFunctions.pages[this.k].Width;
          double point73 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[this.k].Height;
          double point74 = ((XUnit) ref xunit).Point;
          XRect xrect = new XRect(25.0, rc1_34, point73, point74);
          XStringFormat topLeft = XStringFormat.TopLeft;
          xgraphics.DrawString(lowCarbonTex, arialFont11, (XBrush) black, xrect, topLeft);
          this.LowCarbonTex = "";
          checked { ++num7; }
          checked { this.RC1 += 12; }
        }
        if (this.exhaust_air)
        {
          this.LowCarbonTex = "• Exhaust air heat pump\r\n";
          if (flag)
            this.LowCarbonTex = "• Pwmp gwres aer gwacáu \r\n";
          XGraphics xgraphics = PDFFunctions.gfx[this.k];
          string lowCarbonTex = this.LowCarbonTex;
          XFont arialFont11 = PDFFunctions.ArialFont11;
          XSolidBrush black = XBrushes.Black;
          double rc1_35 = (double) this.RC1;
          xunit = PDFFunctions.pages[this.k].Width;
          double point75 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[this.k].Height;
          double point76 = ((XUnit) ref xunit).Point;
          XRect xrect = new XRect(25.0, rc1_35, point75, point76);
          XStringFormat topLeft = XStringFormat.TopLeft;
          xgraphics.DrawString(lowCarbonTex, arialFont11, (XBrush) black, xrect, topLeft);
          this.LowCarbonTex = "";
          checked { ++num7; }
          checked { this.RC1 += 12; }
        }
        if (this.air_source)
        {
          this.LowCarbonTex = "• Air source heat pump\r\n";
          if (flag)
            this.LowCarbonTex = "• Pwmp gwres sy’n tarddu yn yr awyr\r\n";
          XGraphics xgraphics = PDFFunctions.gfx[this.k];
          string lowCarbonTex = this.LowCarbonTex;
          XFont arialFont11 = PDFFunctions.ArialFont11;
          XSolidBrush black = XBrushes.Black;
          double rc1_36 = (double) this.RC1;
          xunit = PDFFunctions.pages[this.k].Width;
          double point77 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[this.k].Height;
          double point78 = ((XUnit) ref xunit).Point;
          XRect xrect = new XRect(25.0, rc1_36, point77, point78);
          XStringFormat topLeft = XStringFormat.TopLeft;
          xgraphics.DrawString(lowCarbonTex, arialFont11, (XBrush) black, xrect, topLeft);
          this.LowCarbonTex = "";
          checked { ++num7; }
          checked { this.RC1 += 12; }
        }
        if (this.comunity_heat)
        {
          this.LowCarbonTex = "• Community heat pump\r\n";
          if (flag)
            this.LowCarbonTex = "• Pwmp gwres cymunedol\r\n";
          XGraphics xgraphics = PDFFunctions.gfx[this.k];
          string lowCarbonTex = this.LowCarbonTex;
          XFont arialFont11 = PDFFunctions.ArialFont11;
          XSolidBrush black = XBrushes.Black;
          double rc1_37 = (double) this.RC1;
          xunit = PDFFunctions.pages[this.k].Width;
          double point79 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[this.k].Height;
          double point80 = ((XUnit) ref xunit).Point;
          XRect xrect = new XRect(25.0, rc1_37, point79, point80);
          XStringFormat topLeft = XStringFormat.TopLeft;
          xgraphics.DrawString(lowCarbonTex, arialFont11, (XBrush) black, xrect, topLeft);
          this.LowCarbonTex = "";
          checked { ++num7; }
          checked { this.RC1 += 12; }
        }
        if (this.biomass)
        {
          this.LowCarbonTex = "• Biomass community heating for some of heat generation\r\n";
          if (flag)
            this.LowCarbonTex = "• Gwres cymunedol biomas ar gyfer peth o'r gwres\r\n";
          XGraphics xgraphics = PDFFunctions.gfx[this.k];
          string lowCarbonTex = this.LowCarbonTex;
          XFont arialFont11 = PDFFunctions.ArialFont11;
          XSolidBrush black = XBrushes.Black;
          double rc1_38 = (double) this.RC1;
          xunit = PDFFunctions.pages[this.k].Width;
          double point81 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[this.k].Height;
          double point82 = ((XUnit) ref xunit).Point;
          XRect xrect = new XRect(25.0, rc1_38, point81, point82);
          XStringFormat topLeft = XStringFormat.TopLeft;
          xgraphics.DrawString(lowCarbonTex, arialFont11, (XBrush) black, xrect, topLeft);
          this.LowCarbonTex = "";
          checked { ++num7; }
          checked { this.RC1 += 12; }
        }
        if (SAP_Module.Proj.Dwellings[House].Renewable.AAEGeneration.Inlcude)
        {
          this.LowCarbonTex = "• Small-scale hydro-electric generation\r\n";
          if (flag)
            this.LowCarbonTex = "• Cynhyrchu trydan dŵr\r\n";
          XGraphics xgraphics = PDFFunctions.gfx[this.k];
          string lowCarbonTex = this.LowCarbonTex;
          XFont arialFont11 = PDFFunctions.ArialFont11;
          XSolidBrush black = XBrushes.Black;
          double rc1_39 = (double) this.RC1;
          xunit = PDFFunctions.pages[this.k].Width;
          double point83 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[this.k].Height;
          double point84 = ((XUnit) ref xunit).Point;
          XRect xrect = new XRect(25.0, rc1_39, point83, point84);
          XStringFormat topLeft = XStringFormat.TopLeft;
          xgraphics.DrawString(lowCarbonTex, arialFont11, (XBrush) black, xrect, topLeft);
          this.LowCarbonTex = "";
          checked { ++num7; }
          checked { this.RC1 += 12; }
        }
        if (num7 == 0)
        {
          this.LowCarbonTex = "None";
          str1 = "";
        }
        if (country == 4)
        {
          XGraphics xgraphics11 = PDFFunctions.gfx[this.k];
          XFont arialFont11_11 = PDFFunctions.ArialFont11;
          XSolidBrush black11 = XBrushes.Black;
          double num14 = (double) checked (rc1_1 - 8);
          xunit = PDFFunctions.pages[this.k].Width;
          double point85 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[this.k].Height;
          double point86 = ((XUnit) ref xunit).Point;
          XRect xrect11 = new XRect(25.0, num14, point85, point86);
          XStringFormat topLeft11 = XStringFormat.TopLeft;
          xgraphics11.DrawString("These are sources of energy (producing or providing electricity or hot water) which emit little or no carbon", arialFont11_11, (XBrush) black11, xrect11, topLeft11);
          checked { this.RC1 += 12; }
          XGraphics xgraphics12 = PDFFunctions.gfx[this.k];
          XFont arialFont11_12 = PDFFunctions.ArialFont11;
          XSolidBrush black12 = XBrushes.Black;
          double num15 = (double) checked (rc1_1 + 4);
          xunit = PDFFunctions.pages[this.k].Width;
          double point87 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[this.k].Height;
          double point88 = ((XUnit) ref xunit).Point;
          XRect xrect12 = new XRect(25.0, num15, point87, point88);
          XStringFormat topLeft12 = XStringFormat.TopLeft;
          xgraphics12.DrawString("dioxide into the atmosphere. The following are provided for this home:", arialFont11_12, (XBrush) black12, xrect12, topLeft12);
          checked { this.RC1 += 23; }
        }
        else
        {
          XGraphics xgraphics = PDFFunctions.gfx[this.k];
          string str8 = str1;
          XFont arialFont11 = PDFFunctions.ArialFont11;
          XSolidBrush black = XBrushes.Black;
          double num16 = (double) rc1_1;
          xunit = PDFFunctions.pages[this.k].Width;
          double point89 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[this.k].Height;
          double point90 = ((XUnit) ref xunit).Point;
          XRect xrect = new XRect(25.0, num16, point89, point90);
          XStringFormat topLeft = XStringFormat.TopLeft;
          xgraphics.DrawString(str8, arialFont11, (XBrush) black, xrect, topLeft);
          checked { this.RC1 += 17; }
        }
        if (country != 4 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.LowCarbonTex, "None", false) == 0)
        {
          XGraphics xgraphics = PDFFunctions.gfx[this.k];
          string lowCarbonTex = this.LowCarbonTex;
          XFont arialFont11 = PDFFunctions.ArialFont11;
          XSolidBrush black = XBrushes.Black;
          double num17 = (double) rc1_1;
          xunit = PDFFunctions.pages[this.k].Width;
          double point91 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[this.k].Height;
          double point92 = ((XUnit) ref xunit).Point;
          XRect xrect = new XRect(25.0, num17, point91, point92);
          XStringFormat topLeft = XStringFormat.TopLeft;
          xgraphics.DrawString(lowCarbonTex, arialFont11, (XBrush) black, xrect, topLeft);
          checked { this.RC1 += 12; }
        }
      }
      if (!flag || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.LowCarbonTex, "None", false) != 0)
        return;
      this.LowCarbonTex = "Dim";
    }

    public string CheckTextWidth2(string Desc)
    {
      int num1;
      string str;
      int num2;
      try
      {
label_2:
        ProjectData.ClearProjectError();
        num1 = -2;
label_3:
        int num3 = 2;
        this.InitialText = "";
label_4:
        num3 = 3;
        this.LastCount = 0;
label_5:
        num3 = 4;
        int length = 0;
label_6:
        num3 = 5;
        this.PrintText[length] = "";
label_7:
        num3 = 6;
        checked { ++length; }
        if (length <= 21)
          goto label_6;
label_8:
        num3 = 7;
        this.count = 0;
label_9:
        num3 = 8;
        this.InitialText = Desc;
label_10:
label_11:
        num3 = 9;
        int num4 = Microsoft.VisualBasic.Strings.Len(this.InitialText);
        length = 0;
        goto label_36;
label_12:
        num3 = 10;
        this.MeasuredText = this.InitialText.Substring(0, length);
label_13:
        num3 = 11;
        if (!this.MeasuredText.EndsWith(" "))
          goto label_22;
label_14:
        num3 = 12;
        XSize xsize1 = PDFFunctions.gfx[this.k].MeasureString(this.MeasuredText, PDFFunctions.ArialFont11);
        double width1 = ((XSize) ref xsize1).Width;
        XSize pageSize1 = PDFFunctions.gfx[this.k].PageSize;
        double num5 = ((XSize) ref pageSize1).Width - 400.0;
        if (width1 <= num5)
          goto label_18;
label_15:
        num3 = 13;
        this.PrintText[this.count] = this.MeasuredTextLast;
label_16:
        num3 = 14;
        // ISSUE: variable of a reference type
        int& local1;
        // ISSUE: explicit reference operation
        int num6 = checked (^(local1 = ref this.count) + 1);
        local1 = num6;
label_17:
        num3 = 15;
        this.InitialText = this.InitialText.Substring(this.LastCount, checked (Microsoft.VisualBasic.Strings.Len(this.InitialText) - this.LastCount));
        goto label_10;
label_18:
label_19:
        num3 = 18;
        this.MeasuredTextLast = this.MeasuredText;
label_20:
        num3 = 19;
        this.LastCount = length;
label_21:
label_22:
label_23:
        num3 = 21;
        if (length != Microsoft.VisualBasic.Strings.Len(Desc))
          goto label_32;
label_24:
        num3 = 22;
        XSize xsize2 = PDFFunctions.gfx[this.k].MeasureString(this.MeasuredText, PDFFunctions.ArialFont11);
        double width2 = ((XSize) ref xsize2).Width;
        XSize pageSize2 = PDFFunctions.gfx[this.k].PageSize;
        double num7 = ((XSize) ref pageSize2).Width - 400.0;
        if (width2 <= num7)
          goto label_28;
label_25:
        num3 = 23;
        this.PrintText[this.count] = this.MeasuredTextLast;
label_26:
        num3 = 24;
        // ISSUE: variable of a reference type
        int& local2;
        // ISSUE: explicit reference operation
        int num8 = checked (^(local2 = ref this.count) + 1);
        local2 = num8;
label_27:
        num3 = 25;
        this.InitialText = this.InitialText.Substring(this.LastCount, checked (Microsoft.VisualBasic.Strings.Len(this.InitialText) - this.LastCount));
        goto label_10;
label_28:
label_29:
        num3 = 28;
        this.MeasuredTextLast = this.MeasuredText;
label_30:
        num3 = 29;
        this.LastCount = length;
label_31:
label_32:
label_33:
        num3 = 31;
        if (length != Microsoft.VisualBasic.Strings.Len(this.InitialText))
          goto label_35;
label_34:
        num3 = 32;
        this.PrintText[this.count] = this.InitialText;
label_35:
        num3 = 33;
        checked { ++length; }
label_36:
        if (length <= num4)
          goto label_12;
label_37:
        num3 = 34;
        str = this.PrintText[length];
        goto label_43;
label_39:
        num2 = num3;
        switch (num1 > -2 ? num1 : 1)
        {
          case 1:
            int num9 = num2 + 1;
            num2 = 0;
            switch (num9)
            {
              case 1:
                goto label_2;
              case 2:
                goto label_3;
              case 3:
                goto label_4;
              case 4:
                goto label_5;
              case 5:
                goto label_6;
              case 6:
                goto label_7;
              case 7:
                goto label_8;
              case 8:
                goto label_9;
              case 9:
                goto label_11;
              case 10:
                goto label_12;
              case 11:
                goto label_13;
              case 12:
                goto label_14;
              case 13:
                goto label_15;
              case 14:
                goto label_16;
              case 15:
                goto label_17;
              case 16:
              case 26:
                goto label_10;
              case 17:
                goto label_18;
              case 18:
                goto label_19;
              case 19:
                goto label_20;
              case 20:
                goto label_21;
              case 21:
                goto label_23;
              case 22:
                goto label_24;
              case 23:
                goto label_25;
              case 24:
                goto label_26;
              case 25:
                goto label_27;
              case 27:
                goto label_28;
              case 28:
                goto label_29;
              case 29:
                goto label_30;
              case 30:
                goto label_31;
              case 31:
                goto label_33;
              case 32:
                goto label_34;
              case 33:
                goto label_35;
              case 34:
                goto label_37;
              case 35:
                goto label_43;
            }
            break;
        }
      }
      catch (Exception ex) when (ex is Exception & (uint) num1 > 0U & num2 == 0)
      {
        ProjectData.SetProjectError(ex);
        goto label_39;
      }
      throw ProjectData.CreateProjectError(-2146828237);
label_43:
      if (num2 != 0)
        ProjectData.ClearProjectError();
      return str;
    }

    public string CreateSAPXML(int House, int country)
    {
      // ISSUE: variable of a compiler-generated type
      CreatePDF._Closure\u0024__85\u002D0 closure850_1;
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      CreatePDF._Closure\u0024__85\u002D0 closure850_2 = new CreatePDF._Closure\u0024__85\u002D0(closure850_1);
      // ISSUE: reference to a compiler-generated field
      closure850_2.\u0024VB\u0024Local_House = House;
      string sapxml = "";
      try
      {
        MemoryStream memoryStream = new MemoryStream();
        if (Validation.OldFormat)
        {
          // ISSUE: reference to a compiler-generated field
          PDFFunctions.PDFInputvalues = PDFFunctions.EncodeByte(((MemoryStream) SAPInput.CreateSAPInput(closure850_2.\u0024VB\u0024Local_House, country)).ToArray());
        }
        byte[] array = new MemoryStream().ToArray();
        if (Validation.OldFormat)
          PDFFunctions.PDFData = PDFFunctions.EncodeByte(array);
        string[] strArray1 = new string[5];
        DateTime now = DateAndTime.Now;
        strArray1[0] = Conversions.ToString(now.Hour);
        strArray1[1] = "--";
        now = DateAndTime.Now;
        strArray1[2] = Conversions.ToString(now.Minute);
        strArray1[3] = "-";
        now = DateAndTime.Now;
        strArray1[4] = Conversions.ToString(now.Second);
        string.Concat(strArray1);
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(PDFFunctions.PDFInputvalues, (string) null, false) == 0)
          PDFFunctions.PDFInputvalues = "";
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(PDFFunctions.PDFData, (string) null, false) == 0)
          PDFFunctions.PDFData = "";
        UTF8Encoding utF8Encoding = new UTF8Encoding();
        VBMath.Randomize();
        int num1 = checked ((int) Conversion.Int((float) unchecked (9999999.0 * (double) VBMath.Rnd() + 1.0)));
        now = DateAndTime.Now;
        string Expression1 = Microsoft.VisualBasic.Strings.Format((object) Conversion.Val((object) now.Month), "00");
        if (Microsoft.VisualBasic.Strings.Len(Expression1) == 1)
          Expression1 = "0" + Expression1;
        now = DateAndTime.Now;
        string Expression2 = Microsoft.VisualBasic.Strings.Format((object) Conversion.Val((object) now.Day), "00");
        if (Microsoft.VisualBasic.Strings.Len(Expression2) == 1)
          Expression2 = "0" + Expression2;
        now = DateAndTime.Now;
        string Expression3 = Microsoft.VisualBasic.Strings.Format((object) Conversion.Val((object) now.Hour), "00");
        if (Microsoft.VisualBasic.Strings.Len(Expression3) == 1)
          Expression3 = "0" + Expression3;
        now = DateAndTime.Now;
        string Expression4 = Microsoft.VisualBasic.Strings.Format((object) Conversion.Val((object) now.Minute), "00");
        if (Microsoft.VisualBasic.Strings.Len(Expression4) == 1)
          Expression4 = "0" + Expression4;
        now = DateAndTime.Now;
        string Expression5 = Microsoft.VisualBasic.Strings.Format((object) Conversion.Val((object) now.Second), "00");
        if (Microsoft.VisualBasic.Strings.Len(Expression5) == 1)
          Expression5 = "0" + Expression5;
        string[] strArray2 = new string[12];
        now = DateAndTime.Now;
        strArray2[0] = Microsoft.VisualBasic.Strings.Format((object) now.Year);
        strArray2[1] = "-";
        strArray2[2] = Expression1;
        strArray2[3] = "-";
        strArray2[4] = Expression2;
        strArray2[5] = "T";
        strArray2[6] = Expression3;
        strArray2[7] = ":";
        strArray2[8] = Expression4;
        strArray2[9] = ":";
        strArray2[10] = Expression5;
        strArray2[11] = ".0Z";
        string str1 = string.Concat(strArray2);
        now = DateAndTime.Now;
        // ISSUE: reference to a compiler-generated field
        string str2 = Conversions.ToString(now.Day) + SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].UPRN;
        SAP_Module.SAPXMLName = "";
        object folderPath = (object) Environment.GetFolderPath(Environment.SpecialFolder.Personal);
        DirectoryInfo directoryInfo1 = new DirectoryInfo(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(folderPath, (object) "\\Stroma SAP 2012")));
        DirectoryInfo directoryInfo2 = new DirectoryInfo(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(folderPath, (object) "\\Stroma SAP 2012\\"), (object) SAP_Module.Proj.Name)));
        DirectoryInfo directoryInfo3 = new DirectoryInfo(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(folderPath, (object) "\\Stroma SAP 2012\\"), (object) SAP_Module.Proj.Name), (object) "\\"), (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Name)));
        SAP_Module.SAPXMLName = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(folderPath, (object) "\\Stroma SAP 2012\\"), (object) SAP_Module.Proj.Name), (object) "\\"), (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Name), (object) "\\"), (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Name), (object) "-SAP Lodgement"), (object) ".xml"));
        if (File.Exists(SAP_Module.SAPXMLName))
          File.Delete(SAP_Module.SAPXMLName);
        XmlTextWriter xmlTextWriter = new XmlTextWriter(SAP_Module.SAPXMLName, (Encoding) utF8Encoding);
        xmlTextWriter.Formatting = Formatting.Indented;
        xmlTextWriter.Indentation = 2;
        xmlTextWriter.WriteStartDocument();
        switch (country)
        {
          case 3:
            xmlTextWriter.WriteStartElement("ConditionReportCreateRequest_1");
            xmlTextWriter.WriteStartAttribute("xmlns:xsi");
            xmlTextWriter.WriteString("http://www.w3.org/2001/XMLSchema-instance");
            xmlTextWriter.WriteEndAttribute();
            xmlTextWriter.WriteStartAttribute("xsi:schemaLocation");
            xmlTextWriter.WriteString("http://www.epbniregister.com https://www.epbniregister.com/RequestServices/xsd/Messages/ConditionReportCreateRequest_1.xsd");
            xmlTextWriter.WriteEndAttribute();
            xmlTextWriter.WriteStartAttribute("xmlns");
            xmlTextWriter.WriteString("http://www.epbniregister.com");
            xmlTextWriter.WriteEndAttribute();
            xmlTextWriter.WriteStartAttribute("xmlns:HIP");
            xmlTextWriter.WriteString("DCLG-HIP");
            xmlTextWriter.WriteEndAttribute();
            xmlTextWriter.WriteStartAttribute("xmlns:SAP");
            xmlTextWriter.WriteString("DCLG-SAP");
            xmlTextWriter.WriteEndAttribute();
            xmlTextWriter.WriteStartAttribute("xmlns:SAP09");
            xmlTextWriter.WriteString("DCLG-SAP09");
            xmlTextWriter.WriteEndAttribute();
            xmlTextWriter.WriteStartAttribute("xmlns:CS");
            xmlTextWriter.WriteString("DCLG-HIP/CommonStructures");
            xmlTextWriter.WriteEndAttribute();
            xmlTextWriter.WriteStartElement("Identification");
            break;
          case 4:
            xmlTextWriter.WriteStartElement("Energy-Performance-Certificate");
            xmlTextWriter.WriteStartAttribute("xmlns:xsi");
            xmlTextWriter.WriteString("http://www.w3.org/2001/XMLSchema-instance");
            xmlTextWriter.WriteEndAttribute();
            xmlTextWriter.WriteStartAttribute("xsi:schemaLocation");
            xmlTextWriter.WriteString("http://www.est.org.uk/epc/estcrV1/DCLG-SAP09 https://shared.scottishepcregister.org.uk/Schemas/Domestic/V16.1/SAP-EPC/Templates/SAP09-Report.xsd");
            xmlTextWriter.WriteEndAttribute();
            xmlTextWriter.WriteStartAttribute("xmlns:SAP09");
            xmlTextWriter.WriteString("http://www.est.org.uk/epc/estcrV1/DCLG-SAP09");
            xmlTextWriter.WriteEndAttribute();
            xmlTextWriter.WriteStartAttribute("xmlns");
            xmlTextWriter.WriteString("http://www.est.org.uk/epc/estcrV1/DCLG-SAP09");
            xmlTextWriter.WriteEndAttribute();
            break;
          default:
            xmlTextWriter.WriteStartElement("ConditionReportCreateRequest_1");
            xmlTextWriter.WriteStartAttribute("xmlns:xsi");
            xmlTextWriter.WriteString("http://www.w3.org/2001/XMLSchema-instance");
            xmlTextWriter.WriteEndAttribute();
            xmlTextWriter.WriteStartAttribute("xmlns:pfdt");
            xmlTextWriter.WriteString("DCLG-HIP/BaseDataTypes");
            xmlTextWriter.WriteEndAttribute();
            xmlTextWriter.WriteStartAttribute("xmlns:ERR");
            xmlTextWriter.WriteString("DCLG-HIP/Exceptions");
            xmlTextWriter.WriteEndAttribute();
            xmlTextWriter.WriteStartAttribute("xmlns:SAP");
            xmlTextWriter.WriteString("DCLG-SAP09");
            xmlTextWriter.WriteEndAttribute();
            xmlTextWriter.WriteStartAttribute("xmlns:CS");
            xmlTextWriter.WriteString("DCLG-HIP/CommonStructures");
            xmlTextWriter.WriteEndAttribute();
            xmlTextWriter.WriteStartAttribute("xmlns");
            xmlTextWriter.WriteString("http://www.epcregister.com");
            xmlTextWriter.WriteEndAttribute();
            xmlTextWriter.WriteStartAttribute("xsi:schemaLocation");
            xmlTextWriter.WriteString("http://www.epcregister.com https://www.epcregister.com/RequestServices/xsd/Messages/ConditionReportCreateRequest_1.xsd");
            xmlTextWriter.WriteEndAttribute();
            xmlTextWriter.WriteStartElement("Identification");
            break;
        }
        if (country != 4)
        {
          xmlTextWriter.WriteStartElement("CS:ServiceName");
          xmlTextWriter.WriteValue("CreateReport");
          xmlTextWriter.WriteEndElement();
          xmlTextWriter.WriteStartElement("CS:Operation");
          xmlTextWriter.WriteValue("Create");
          xmlTextWriter.WriteEndElement();
          xmlTextWriter.WriteStartElement("CS:TransactionDetails");
          xmlTextWriter.WriteStartElement("CS:OriginatingID");
          xmlTextWriter.WriteValue("Stroma Certification");
          xmlTextWriter.WriteEndElement();
          xmlTextWriter.WriteStartElement("CS:RecipientID");
          xmlTextWriter.WriteValue("Landmark");
          xmlTextWriter.WriteEndElement();
          xmlTextWriter.WriteStartElement("CS:Timestamp");
          xmlTextWriter.WriteValue(str1);
          xmlTextWriter.WriteEndElement();
          xmlTextWriter.WriteStartElement("CS:TransactionID");
          xmlTextWriter.WriteValue(num1);
          xmlTextWriter.WriteEndElement();
          xmlTextWriter.WriteEndElement();
          xmlTextWriter.WriteStartElement("CS:TermsAndConditions");
          xmlTextWriter.WriteValue("Y");
          xmlTextWriter.WriteEndElement();
          xmlTextWriter.WriteEndElement();
          xmlTextWriter.WriteStartElement("Configuration");
          xmlTextWriter.WriteStartElement("CS:StopOnFirstError");
          xmlTextWriter.WriteValue("No");
          xmlTextWriter.WriteEndElement();
          xmlTextWriter.WriteStartElement("CS:ReasonForChange");
          xmlTextWriter.WriteValue("NA");
          xmlTextWriter.WriteEndElement();
          xmlTextWriter.WriteEndElement();
          xmlTextWriter.WriteStartElement("Content");
          xmlTextWriter.WriteStartElement("SAP-EPC-Data");
        }
        xmlTextWriter.WriteStartElement("SAP:SAP-Version");
        xmlTextWriter.WriteValue("9.90");
        xmlTextWriter.WriteEndElement();
        xmlTextWriter.WriteStartElement("SAP:BEDF-Revision-Number");
        xmlTextWriter.WriteValue(SAP_Module.DataBVersion);
        xmlTextWriter.WriteEndElement();
        xmlTextWriter.WriteStartElement("SAP:Calculation-Software-Name");
        xmlTextWriter.WriteValue("Stroma FSAP");
        xmlTextWriter.WriteEndElement();
        xmlTextWriter.WriteStartElement("SAP:Calculation-Software-Version");
        xmlTextWriter.WriteValue(SAP_Module.CurrVersion);
        xmlTextWriter.WriteEndElement();
        string str3 = Microsoft.VisualBasic.Strings.Format((object) Microsoft.VisualBasic.Strings.Format((object) DateAndTime.Now, "yyMMdd"), "yyMMdd");
        string str4 = Microsoft.VisualBasic.Strings.Left(Microsoft.VisualBasic.Strings.Format((object) str3), 2);
        Microsoft.VisualBasic.Strings.Right(Microsoft.VisualBasic.Strings.Format((object) str3), 4) + "-" + Microsoft.VisualBasic.Strings.Mid(str3, 4, 2) + "-" + str4;
        now = DateAndTime.Now;
        string Expression6 = Conversions.ToString(Math.Round(Conversion.Val((object) now.Month), 2));
        if (Microsoft.VisualBasic.Strings.Len(Expression6) == 1)
          Expression6 = "0" + Expression6;
        now = DateAndTime.Now;
        string Expression7 = Conversions.ToString(Math.Round(Conversion.Val((object) now.Day), 2));
        if (Microsoft.VisualBasic.Strings.Len(Expression7) == 1)
          Expression7 = "0" + Expression7;
        now = DateAndTime.Now;
        string str5 = now.Year.ToString() + "-" + Expression6 + "-" + Expression7;
        xmlTextWriter.WriteStartElement("SAP:Report-Header");
        xmlTextWriter.WriteStartElement("SAP:RRN");
        if (PDFFunctions.Draft_PDF)
          Validation.RefNum = "0000-0000-0000-0000-0000";
        xmlTextWriter.WriteValue(Validation.RefNum);
        xmlTextWriter.WriteEndElement();
        xmlTextWriter.WriteStartElement("SAP:Inspection-Date");
        // ISSUE: reference to a compiler-generated field
        xmlTextWriter.WriteValue(Microsoft.VisualBasic.Strings.Format((object) SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].DateAssessment, "yyyy-MM-dd"));
        xmlTextWriter.WriteEndElement();
        xmlTextWriter.WriteStartElement("SAP:Report-Type");
        xmlTextWriter.WriteValue(3);
        xmlTextWriter.WriteEndElement();
        xmlTextWriter.WriteStartElement("SAP:Completion-Date");
        xmlTextWriter.WriteValue(str5);
        xmlTextWriter.WriteEndElement();
        xmlTextWriter.WriteStartElement("SAP:Registration-Date");
        xmlTextWriter.WriteValue(str5);
        xmlTextWriter.WriteEndElement();
        xmlTextWriter.WriteStartElement("SAP:Status");
        xmlTextWriter.WriteValue("entered");
        xmlTextWriter.WriteEndElement();
        xmlTextWriter.WriteStartElement("SAP:Language-Code");
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].EPCLanguage, "Welsh", false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Address.Country, "Wales", false) == 0)
          xmlTextWriter.WriteValue(2);
        else
          xmlTextWriter.WriteValue(1);
        xmlTextWriter.WriteEndElement();
        xmlTextWriter.WriteStartElement("SAP:Restricted-Access");
        xmlTextWriter.WriteValue(0);
        xmlTextWriter.WriteEndElement();
        if (country == 4)
        {
          xmlTextWriter.WriteStartElement("SAP:Tenure");
          // ISSUE: reference to a compiler-generated field
          string tenure = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Tenure;
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(tenure, "Owner-occupied", false) != 0)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(tenure, "Rented (social)", false) != 0)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(tenure, "Rented (private)", false) == 0)
                xmlTextWriter.WriteValue(3);
              else
                xmlTextWriter.WriteValue("ND");
            }
            else
              xmlTextWriter.WriteValue(2);
          }
          else
            xmlTextWriter.WriteValue(1);
          xmlTextWriter.WriteEndElement();
        }
        xmlTextWriter.WriteStartElement("SAP:Transaction-Type");
        if (country == 3)
        {
          // ISSUE: reference to a compiler-generated field
          string transaction = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Transaction;
          // ISSUE: reference to a compiler-generated method
          switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(transaction))
          {
            case 1765198695:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(transaction, "Rental", false) == 0)
              {
                xmlTextWriter.WriteValue(8);
                break;
              }
              break;
            case 1893705044:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(transaction, "Non marketed sale", false) == 0)
              {
                xmlTextWriter.WriteValue(2);
                break;
              }
              break;
            case 2398018890:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(transaction, "FiT application", false) == 0)
              {
                xmlTextWriter.WriteValue(11);
                break;
              }
              break;
            case 3124205971:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(transaction, "Assessment for Green Deal", false) == 0)
              {
                xmlTextWriter.WriteValue(9);
                break;
              }
              break;
            case 3387929955:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(transaction, "Marketed sale", false) == 0)
              {
                xmlTextWriter.WriteValue(1);
                break;
              }
              break;
            case 3741002162:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(transaction, "None of the above", false) == 0)
              {
                xmlTextWriter.WriteValue(5);
                break;
              }
              break;
            case 4206055543:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(transaction, "New dwelling", false) == 0)
              {
                xmlTextWriter.WriteValue(6);
                break;
              }
              break;
            case 4287547971:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(transaction, "Following Green Deal", false) == 0)
              {
                xmlTextWriter.WriteValue(10);
                break;
              }
              break;
          }
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          string transaction = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Transaction;
          // ISSUE: reference to a compiler-generated method
          switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(transaction))
          {
            case 359166155:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(transaction, "Rental (social)", false) == 0)
              {
                xmlTextWriter.WriteValue(3);
                break;
              }
              break;
            case 473558456:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(transaction, "Not sale or rental", false) == 0)
              {
                xmlTextWriter.WriteValue(5);
                break;
              }
              break;
            case 491244916:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(transaction, "not recored", false) == 0)
              {
                xmlTextWriter.WriteValue(7);
                break;
              }
              break;
            case 1893705044:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(transaction, "Non marketed sale", false) == 0)
              {
                xmlTextWriter.WriteValue(2);
                break;
              }
              break;
            case 2094602017:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(transaction, "Rental (private)", false) == 0)
              {
                xmlTextWriter.WriteValue(4);
                break;
              }
              break;
            case 2398018890:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(transaction, "FiT application", false) == 0)
              {
                xmlTextWriter.WriteValue(11);
                break;
              }
              break;
            case 3387929955:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(transaction, "Marketed sale", false) == 0)
              {
                xmlTextWriter.WriteValue(1);
                break;
              }
              break;
            case 4206055543:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(transaction, "New dwelling", false) == 0)
              {
                xmlTextWriter.WriteValue(6);
                break;
              }
              break;
            case 4287547971:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(transaction, "Following Green Deal", false) == 0)
              {
                xmlTextWriter.WriteValue(10);
                break;
              }
              break;
          }
        }
        xmlTextWriter.WriteEndElement();
        if (country == 3)
        {
          xmlTextWriter.WriteStartElement("SAP:Tenure");
          // ISSUE: reference to a compiler-generated field
          string tenure = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Tenure;
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(tenure, "Owner-occupied", false) != 0)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(tenure, "Rented (social)", false) != 0)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(tenure, "Rented (private)", false) == 0)
                xmlTextWriter.WriteValue(3);
              else
                xmlTextWriter.WriteValue("ND");
            }
            else
              xmlTextWriter.WriteValue(2);
          }
          else
            xmlTextWriter.WriteValue(1);
          xmlTextWriter.WriteEndElement();
        }
        xmlTextWriter.WriteStartElement("SAP:Seller-Commission-Report");
        xmlTextWriter.WriteValue("Y");
        xmlTextWriter.WriteEndElement();
        xmlTextWriter.WriteStartElement("SAP:Property-Type");
        // ISSUE: reference to a compiler-generated field
        string propertyType1 = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].PropertyType;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(propertyType1, nameof (House), false) != 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(propertyType1, "Bungalow", false) != 0)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(propertyType1, "Flat", false) != 0)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(propertyType1, "Maisonette", false) == 0)
                xmlTextWriter.WriteValue(3);
            }
            else
              xmlTextWriter.WriteValue(2);
          }
          else
            xmlTextWriter.WriteValue(1);
        }
        else
          xmlTextWriter.WriteValue(0);
        xmlTextWriter.WriteEndElement();
        xmlTextWriter.WriteStartElement("SAP:Home-Inspector");
        xmlTextWriter.WriteStartElement("SAP:Certification-Scheme");
        xmlTextWriter.WriteStartElement("SAP:Scheme-Name");
        xmlTextWriter.WriteValue("Stroma Certification");
        xmlTextWriter.WriteEndElement();
        xmlTextWriter.WriteStartElement("SAP:Complaints-Address");
        xmlTextWriter.WriteStartElement("SAP:Address-Line-1");
        xmlTextWriter.WriteValue("Unit 4, Pioneer Way ");
        xmlTextWriter.WriteEndElement();
        xmlTextWriter.WriteStartElement("SAP:Address-Line-2");
        xmlTextWriter.WriteValue("Pioneer Business Park");
        xmlTextWriter.WriteEndElement();
        xmlTextWriter.WriteStartElement("SAP:Post-Town");
        xmlTextWriter.WriteValue("Castleford");
        xmlTextWriter.WriteEndElement();
        xmlTextWriter.WriteStartElement("SAP:Postcode");
        xmlTextWriter.WriteValue("WF10 5QU");
        xmlTextWriter.WriteEndElement();
        xmlTextWriter.WriteEndElement();
        xmlTextWriter.WriteStartElement("SAP:Contact-Address");
        xmlTextWriter.WriteStartElement("SAP:Address-Line-1");
        xmlTextWriter.WriteValue("Unit 4, Pioneer Way ");
        xmlTextWriter.WriteEndElement();
        xmlTextWriter.WriteStartElement("SAP:Post-Town");
        xmlTextWriter.WriteValue("Castleford");
        xmlTextWriter.WriteEndElement();
        xmlTextWriter.WriteStartElement("SAP:Postcode");
        xmlTextWriter.WriteValue("WF10 5QU");
        xmlTextWriter.WriteEndElement();
        xmlTextWriter.WriteEndElement();
        xmlTextWriter.WriteStartElement("SAP:Web-Site");
        xmlTextWriter.WriteValue("www.stroma.com");
        xmlTextWriter.WriteEndElement();
        xmlTextWriter.WriteStartElement("SAP:E-Mail");
        xmlTextWriter.WriteValue("info@stroma.com");
        xmlTextWriter.WriteEndElement();
        xmlTextWriter.WriteStartElement("SAP:Fax");
        xmlTextWriter.WriteValue("0845 6211112");
        xmlTextWriter.WriteEndElement();
        xmlTextWriter.WriteStartElement("SAP:Telephone");
        xmlTextWriter.WriteValue("0845 6211111");
        xmlTextWriter.WriteEndElement();
        xmlTextWriter.WriteStartElement("SAP:Registered-Name");
        xmlTextWriter.WriteValue(Validation.AssessorFN + " " + Validation.AssessorLN);
        xmlTextWriter.WriteEndElement();
        xmlTextWriter.WriteEndElement();
        xmlTextWriter.WriteStartElement("SAP:Identification-Number");
        if (country == 4)
          xmlTextWriter.WriteStartElement("SAP:Membership-Number");
        else
          xmlTextWriter.WriteStartElement("SAP:Certificate-Number");
        xmlTextWriter.WriteValue(Validation.AssessorNO);
        xmlTextWriter.WriteEndElement();
        xmlTextWriter.WriteEndElement();
        xmlTextWriter.WriteStartElement("SAP:Name");
        xmlTextWriter.WriteStartElement("SAP:Prefix");
        xmlTextWriter.WriteValue(Validation.EA_Prefix);
        xmlTextWriter.WriteEndElement();
        xmlTextWriter.WriteStartElement("SAP:First-Name");
        xmlTextWriter.WriteValue(Validation.AssessorFN);
        xmlTextWriter.WriteEndElement();
        xmlTextWriter.WriteStartElement("SAP:Surname");
        xmlTextWriter.WriteValue(Validation.AssessorLN);
        xmlTextWriter.WriteEndElement();
        xmlTextWriter.WriteStartElement("SAP:Suffix");
        xmlTextWriter.WriteValue(Validation.EA_Suffix);
        xmlTextWriter.WriteEndElement();
        xmlTextWriter.WriteEndElement();
        xmlTextWriter.WriteStartElement("SAP:Certification-Date");
        xmlTextWriter.WriteValue(Validation.EA_CertificationDate);
        xmlTextWriter.WriteEndElement();
        xmlTextWriter.WriteStartElement("SAP:Status");
        xmlTextWriter.WriteValue(Validation.EA_Status);
        xmlTextWriter.WriteEndElement();
        xmlTextWriter.WriteStartElement("SAP:Notify-Lodgement");
        xmlTextWriter.WriteValue("Y");
        xmlTextWriter.WriteEndElement();
        xmlTextWriter.WriteStartElement("SAP:Contact-Address");
        xmlTextWriter.WriteStartElement("SAP:Address-Line-1");
        xmlTextWriter.WriteValue(Validation.EA_Address1);
        xmlTextWriter.WriteEndElement();
        xmlTextWriter.WriteStartElement("SAP:Address-Line-2");
        xmlTextWriter.WriteValue(Validation.EA_Address2);
        xmlTextWriter.WriteEndElement();
        xmlTextWriter.WriteStartElement("SAP:Post-Town");
        xmlTextWriter.WriteValue(Validation.EA_Town);
        xmlTextWriter.WriteEndElement();
        xmlTextWriter.WriteStartElement("SAP:Postcode");
        xmlTextWriter.WriteValue(Validation.EA_Postcode);
        xmlTextWriter.WriteEndElement();
        xmlTextWriter.WriteEndElement();
        xmlTextWriter.WriteStartElement("SAP:Web-Site");
        xmlTextWriter.WriteValue(Validation.EA_Web);
        xmlTextWriter.WriteEndElement();
        xmlTextWriter.WriteStartElement("SAP:E-Mail");
        xmlTextWriter.WriteValue(Validation.EA_Email);
        xmlTextWriter.WriteEndElement();
        xmlTextWriter.WriteStartElement("SAP:Fax");
        xmlTextWriter.WriteValue(Validation.AssessorFax);
        xmlTextWriter.WriteEndElement();
        xmlTextWriter.WriteStartElement("SAP:Telephone");
        xmlTextWriter.WriteValue(Validation.AssessorPhone);
        xmlTextWriter.WriteEndElement();
        xmlTextWriter.WriteStartElement("SAP:Qualifications");
        xmlTextWriter.WriteValue("");
        xmlTextWriter.WriteEndElement();
        xmlTextWriter.WriteStartElement("SAP:Specialisms");
        xmlTextWriter.WriteValue("");
        xmlTextWriter.WriteEndElement();
        xmlTextWriter.WriteStartElement("SAP:Company-Name");
        xmlTextWriter.WriteValue(Validation.AssessorCompany);
        xmlTextWriter.WriteEndElement();
        xmlTextWriter.WriteStartElement("SAP:Inspector-Report-Types");
        xmlTextWriter.WriteStartElement("SAP:Report-Type");
        xmlTextWriter.WriteValue(3);
        xmlTextWriter.WriteEndElement();
        xmlTextWriter.WriteEndElement();
        xmlTextWriter.WriteEndElement();
        xmlTextWriter.WriteStartElement("SAP:Property");
        xmlTextWriter.WriteStartElement("SAP:Address");
        xmlTextWriter.WriteStartElement("SAP:Address-Line-1");
        // ISSUE: reference to a compiler-generated field
        xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Address.Line1);
        xmlTextWriter.WriteEndElement();
        // ISSUE: reference to a compiler-generated field
        if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Address.Line2, "", false) > 0U)
        {
          xmlTextWriter.WriteStartElement("SAP:Address-Line-2");
          // ISSUE: reference to a compiler-generated field
          xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Address.Line2);
          xmlTextWriter.WriteEndElement();
        }
        // ISSUE: reference to a compiler-generated field
        if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Address.Line3, "", false) > 0U)
        {
          xmlTextWriter.WriteStartElement("SAP:Address-Line-3");
          // ISSUE: reference to a compiler-generated field
          xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Address.Line3);
          xmlTextWriter.WriteEndElement();
        }
        xmlTextWriter.WriteStartElement("SAP:Post-Town");
        // ISSUE: reference to a compiler-generated field
        xmlTextWriter.WriteValue(Microsoft.VisualBasic.Strings.UCase(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Address.City));
        xmlTextWriter.WriteEndElement();
        xmlTextWriter.WriteStartElement("SAP:Postcode");
        // ISSUE: reference to a compiler-generated field
        xmlTextWriter.WriteValue(Microsoft.VisualBasic.Strings.UCase(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Address.PostCost));
        xmlTextWriter.WriteEndElement();
        xmlTextWriter.WriteEndElement();
        xmlTextWriter.WriteStartElement("SAP:UPRN");
        // ISSUE: reference to a compiler-generated field
        xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].UPRN);
        xmlTextWriter.WriteEndElement();
        xmlTextWriter.WriteEndElement();
        xmlTextWriter.WriteStartElement("SAP:Region-Code");
        // ISSUE: reference to a compiler-generated field
        string location = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Location;
        // ISSUE: reference to a compiler-generated method
        switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(location))
        {
          case 85627527:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(location, "Orkney", false) == 0)
            {
              xmlTextWriter.WriteValue(11);
              goto default;
            }
            else
              goto default;
          case 417745194:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(location, "Thames valley", false) == 0)
            {
              xmlTextWriter.WriteValue(17);
              goto default;
            }
            else
              goto default;
          case 419820972:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(location, "Borders", false) == 0)
            {
              xmlTextWriter.WriteValue(1);
              goto default;
            }
            else
              goto default;
          case 423237023:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(location, "South England", false) == 0)
            {
              xmlTextWriter.WriteValue(16);
              goto default;
            }
            else
              goto default;
          case 463047147:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(location, "Wales", false) == 0)
            {
              xmlTextWriter.WriteValue(18);
              goto default;
            }
            else
              goto default;
          case 1121445140:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(location, "South West England", false) == 0)
            {
              xmlTextWriter.WriteValue(15);
              goto default;
            }
            else
              goto default;
          case 1253063607:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(location, "Isle of Man", false) == 0)
            {
              xmlTextWriter.WriteValue(24);
              goto default;
            }
            else
              goto default;
          case 1486598274:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(location, "Shetland", false) == 0)
            {
              xmlTextWriter.WriteValue(13);
              goto default;
            }
            else
              goto default;
          case 1809119403:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(location, "Guernsey", false) == 0)
            {
              xmlTextWriter.WriteValue(23);
              goto default;
            }
            else
              goto default;
          case 2227903623:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(location, "South West Scotland", false) == 0)
              break;
            goto default;
          case 2536965870:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(location, "East Anglia", false) == 0)
            {
              xmlTextWriter.WriteValue(2);
              goto default;
            }
            else
              goto default;
          case 2574711555:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(location, "Severn valley", false) == 0)
            {
              xmlTextWriter.WriteValue(12);
              goto default;
            }
            else
              goto default;
          case 2627101428:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(location, "Highland", false) == 0)
            {
              xmlTextWriter.WriteValue(5);
              goto default;
            }
            else
              goto default;
          case 3009355918:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(location, "North West England", false) == 0)
              break;
            goto default;
          case 3088137120:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(location, "North East England", false) == 0)
            {
              xmlTextWriter.WriteValue(7);
              goto default;
            }
            else
              goto default;
          case 3158107624:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(location, "East Scotland", false) == 0)
            {
              xmlTextWriter.WriteValue(4);
              goto default;
            }
            else
              goto default;
          case 3255183281:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(location, "Western Isles", false) == 0)
            {
              xmlTextWriter.WriteValue(21);
              goto default;
            }
            else
              goto default;
          case 3381936845:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(location, "Jersey", false) == 0)
            {
              xmlTextWriter.WriteValue(22);
              goto default;
            }
            else
              goto default;
          case 3757789148:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(location, "Northern Ireland", false) == 0)
            {
              xmlTextWriter.WriteValue(10);
              goto default;
            }
            else
              goto default;
          case 3790857268:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(location, "East Pennines", false) == 0)
            {
              xmlTextWriter.WriteValue(3);
              goto default;
            }
            else
              goto default;
          case 4003211866:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(location, "South East England", false) == 0)
            {
              xmlTextWriter.WriteValue(14);
              goto default;
            }
            else
              goto default;
          case 4013004195:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(location, "North East Scotland", false) == 0)
            {
              xmlTextWriter.WriteValue(8);
              goto default;
            }
            else
              goto default;
          case 4072253181:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(location, "Midlands", false) == 0)
            {
              xmlTextWriter.WriteValue(6);
              goto default;
            }
            else
              goto default;
          case 4111412702:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(location, "West Scotland", false) == 0)
            {
              xmlTextWriter.WriteValue(20);
              goto default;
            }
            else
              goto default;
          case 4162830650:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(location, "West Pennines", false) == 0)
            {
              xmlTextWriter.WriteValue(19);
              goto default;
            }
            else
              goto default;
          default:
label_157:
            xmlTextWriter.WriteEndElement();
            xmlTextWriter.WriteStartElement("SAP:Country-Code");
            switch (country)
            {
              case 3:
                xmlTextWriter.WriteValue("NIR");
                break;
              case 4:
                xmlTextWriter.WriteValue("SCT");
                break;
              default:
                xmlTextWriter.WriteValue("EAW");
                break;
            }
            xmlTextWriter.WriteEndElement();
            xmlTextWriter.WriteStartElement("SAP:Related-Party-Disclosure");
            xmlTextWriter.WriteStartElement("SAP:Related-Party-Disclosure-Number");
            // ISSUE: reference to a compiler-generated field
            string str6 = Conversions.ToString(this.CheckRelatedParty(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].RPD));
            xmlTextWriter.WriteValue(str6);
            xmlTextWriter.WriteEndElement();
            xmlTextWriter.WriteEndElement();
            xmlTextWriter.WriteEndElement();
            xmlTextWriter.WriteStartElement("SAP:Energy-Assessment");
            xmlTextWriter.WriteStartElement("SAP:Assessment-Date");
            // ISSUE: reference to a compiler-generated field
            xmlTextWriter.WriteValue(Microsoft.VisualBasic.Strings.Format((object) SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].DateAssessment, "yyyy-MM-dd"));
            xmlTextWriter.WriteEndElement();
            xmlTextWriter.WriteStartElement("SAP:Property-Summary");
            xmlTextWriter.WriteStartElement("SAP:Walls");
            xmlTextWriter.WriteStartElement("SAP:Description");
            if (country == 2)
              xmlTextWriter.WriteValue("Trawsyriannedd thermol cyfartalog " + Microsoft.VisualBasic.Strings.Format((object) SAP_Module.Calculation2012._Add_Variable.Averages.Wall_U, "0.00") + " W/m\u00B2K");
            else
              xmlTextWriter.WriteValue("Average thermal transmittance " + Microsoft.VisualBasic.Strings.Format((object) SAP_Module.Calculation2012._Add_Variable.Averages.Wall_U, "0.00") + " W/m\u00B2K");
            xmlTextWriter.WriteEndElement();
            xmlTextWriter.WriteStartElement("SAP:Energy-Efficiency-Rating");
            xmlTextWriter.WriteValue(PDFFunctions.BandCheckWall(Math.Round(SAP_Module.Calculation2012._Add_Variable.Averages.Wall_U, 2), "XML"));
            xmlTextWriter.WriteEndElement();
            xmlTextWriter.WriteStartElement("SAP:Environmental-Efficiency-Rating");
            xmlTextWriter.WriteValue(PDFFunctions.BandCheckWall(Math.Round(SAP_Module.Calculation2012._Add_Variable.Averages.Wall_U, 2), "XML"));
            xmlTextWriter.WriteEndElement();
            xmlTextWriter.WriteEndElement();
            xmlTextWriter.WriteStartElement("SAP:Roof");
            xmlTextWriter.WriteStartElement("SAP:Description");
            double num2;
            if (country == 2)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Calculation2012._Add_Variable.Averages.Roof_U.ToString(), "NaN", false) == 0)
                xmlTextWriter.WriteValue("(eiddo arall uwchben)");
              else
                xmlTextWriter.WriteValue("Trawsyriannedd thermol cyfartalog " + Conversions.ToString(Math.Round(SAP_Module.Calculation2012._Add_Variable.Averages.Roof_U, 2)) + " W/m\u00B2K");
            }
            else
            {
              num2 = SAP_Module.Calculation2012._Add_Variable.Averages.Roof_U;
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(num2.ToString(), "NaN", false) == 0)
                xmlTextWriter.WriteValue("(other premises above)");
              else if (SAP_Module.Calculation2012._Add_Variable.Averages.Roof_U == 0.0)
              {
                xmlTextWriter.WriteValue("(other premises above)");
              }
              else
              {
                // ISSUE: reference to a compiler-generated field
                if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].NoofRoofs == 0)
                  xmlTextWriter.WriteValue("Average thermal transmittance 0 W/m\u00B2K");
                else
                  xmlTextWriter.WriteValue("Average thermal transmittance " + Conversions.ToString(Math.Round(SAP_Module.Calculation2012._Add_Variable.Averages.Roof_U, 2)) + " W/m\u00B2K");
              }
            }
            xmlTextWriter.WriteEndElement();
            xmlTextWriter.WriteStartElement("SAP:Energy-Efficiency-Rating");
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(PDFFunctions.BandCheckRoof(Math.Round(SAP_Module.Calculation2012._Add_Variable.Averages.Roof_U, 2), "XML"), "", false) == 0)
              xmlTextWriter.WriteValue(0);
            else if (SAP_Module.Calculation2012._Add_Variable.Averages.Roof_U == 0.0)
              xmlTextWriter.WriteValue(0);
            else
              xmlTextWriter.WriteValue(PDFFunctions.BandCheckRoof(Math.Round(SAP_Module.Calculation2012._Add_Variable.Averages.Roof_U, 2), "XML"));
            xmlTextWriter.WriteEndElement();
            xmlTextWriter.WriteStartElement("SAP:Environmental-Efficiency-Rating");
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(PDFFunctions.BandCheckRoof(Math.Round(SAP_Module.Calculation2012._Add_Variable.Averages.Roof_U, 2), "XML"), "", false) == 0)
              xmlTextWriter.WriteValue(0);
            else if (SAP_Module.Calculation2012._Add_Variable.Averages.Roof_U == 0.0)
              xmlTextWriter.WriteValue(0);
            else
              xmlTextWriter.WriteValue(PDFFunctions.BandCheckRoof(Math.Round(SAP_Module.Calculation2012._Add_Variable.Averages.Roof_U, 2), "XML"));
            xmlTextWriter.WriteEndElement();
            xmlTextWriter.WriteEndElement();
            xmlTextWriter.WriteStartElement("SAP:Floor");
            xmlTextWriter.WriteStartElement("SAP:Description");
            // ISSUE: reference to a compiler-generated field
            int num3 = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].NoofFloors == 0 ? 1 : 0;
            num2 = SAP_Module.Calculation2012._Add_Variable.Averages.Floor_U;
            int num4 = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(num2.ToString(), "NaN", false) == 0 ? 1 : 0;
            if ((num3 | num4) != 0)
            {
              if (country == 2)
                xmlTextWriter.WriteValue("(eiddo arall islaw)");
              else
                xmlTextWriter.WriteValue("(other premises below)");
              xmlTextWriter.WriteEndElement();
              xmlTextWriter.WriteStartElement("SAP:Energy-Efficiency-Rating");
              xmlTextWriter.WriteValue(0);
              xmlTextWriter.WriteEndElement();
              xmlTextWriter.WriteStartElement("SAP:Environmental-Efficiency-Rating");
              xmlTextWriter.WriteValue(0);
              xmlTextWriter.WriteEndElement();
            }
            else
            {
              if (country == 2)
                xmlTextWriter.WriteValue("Trawsyriannedd thermol cyfartalog " + Microsoft.VisualBasic.Strings.Format((object) Math.Round(SAP_Module.Calculation2012._Add_Variable.Averages.Floor_U, 2), "0.00") + " W/m\u00B2K");
              else
                xmlTextWriter.WriteValue("Average thermal transmittance " + Microsoft.VisualBasic.Strings.Format((object) Math.Round(SAP_Module.Calculation2012._Add_Variable.Averages.Floor_U, 2), "0.00") + " W/m\u00B2K");
              xmlTextWriter.WriteEndElement();
              xmlTextWriter.WriteStartElement("SAP:Energy-Efficiency-Rating");
              xmlTextWriter.WriteValue(PDFFunctions.BandCheckFloor(Math.Round(SAP_Module.Calculation2012._Add_Variable.Averages.Floor_U, 2), "XML"));
              xmlTextWriter.WriteEndElement();
              xmlTextWriter.WriteStartElement("SAP:Environmental-Efficiency-Rating");
              xmlTextWriter.WriteValue(PDFFunctions.BandCheckFloor(Math.Round(SAP_Module.Calculation2012._Add_Variable.Averages.Floor_U, 2), "XML"));
              xmlTextWriter.WriteEndElement();
            }
            xmlTextWriter.WriteEndElement();
            xmlTextWriter.WriteStartElement("SAP:Windows");
            xmlTextWriter.WriteStartElement("SAP:Description");
            if (SAP_Module.Calculation2012._Add_Variable.Averages.Description != null)
              xmlTextWriter.WriteValue(PDFFunctions.CheckWalesWindows(SAP_Module.Calculation2012._Add_Variable.Averages.Description, country));
            xmlTextWriter.WriteEndElement();
            xmlTextWriter.WriteStartElement("SAP:Energy-Efficiency-Rating");
            xmlTextWriter.WriteValue(PDFFunctions.BandCheckWindows(Math.Round(SAP_Module.Calculation2012._Add_Variable.Averages.Window_U, 2), "XML"));
            xmlTextWriter.WriteEndElement();
            xmlTextWriter.WriteStartElement("SAP:Environmental-Efficiency-Rating");
            xmlTextWriter.WriteValue(PDFFunctions.BandCheckWindows(Math.Round(SAP_Module.Calculation2012._Add_Variable.Averages.Window_U, 2), "XML"));
            xmlTextWriter.WriteEndElement();
            xmlTextWriter.WriteEndElement();
            xmlTextWriter.WriteStartElement("SAP:Main-Heating");
            xmlTextWriter.WriteStartElement("SAP:Description");
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.HeatingHeading, "Community scheme utilising waste geothermal heat, electric", false) == 0)
              this.HeatingHeading = "Community heat pump, electric";
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.HeatingHeading, "Community scheme, mains gas", false) == 0)
              this.HeatingHeading = "Community scheme, mains gas and biomass";
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.HeatingHeading, "Electric underfloor heating, electric", false) == 0)
              this.HeatingHeading = "Electric underfloor heating";
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.HeatingHeading, "Gwresogi dan y llawr trydan, trydan", false) == 0)
              this.HeatingHeading = "Gwresogi dan y llawr trydan";
            if (country == 2)
              xmlTextWriter.WriteValue(this.HeatingHeadingwWALES);
            else
              xmlTextWriter.WriteValue(this.HeatingHeading);
            string xmlMainBrand = this.XML_MainBrand;
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(xmlMainBrand, "★★★★★", false) != 0)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(xmlMainBrand, "★★★★☆", false) != 0)
              {
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(xmlMainBrand, "★★★☆☆", false) != 0)
                {
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(xmlMainBrand, "★★☆☆☆", false) != 0)
                  {
                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(xmlMainBrand, "★☆☆☆☆", false) != 0)
                    {
                      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(xmlMainBrand, "-", false) == 0)
                        this.XML_MainBrand = Conversions.ToString(0);
                    }
                    else
                      this.XML_MainBrand = Conversions.ToString(1);
                  }
                  else
                    this.XML_MainBrand = Conversions.ToString(2);
                }
                else
                  this.XML_MainBrand = Conversions.ToString(3);
              }
              else
                this.XML_MainBrand = Conversions.ToString(4);
            }
            else
              this.XML_MainBrand = Conversions.ToString(5);
            string xmlMainBrand2 = this.XML_MainBrand2;
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(xmlMainBrand2, "★★★★★", false) != 0)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(xmlMainBrand2, "★★★★☆", false) != 0)
              {
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(xmlMainBrand2, "★★★☆☆", false) != 0)
                {
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(xmlMainBrand2, "★★☆☆☆", false) != 0)
                  {
                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(xmlMainBrand2, "★☆☆☆☆", false) != 0)
                    {
                      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(xmlMainBrand2, "-", false) == 0)
                        this.XML_MainBrand2 = Conversions.ToString(0);
                    }
                    else
                      this.XML_MainBrand2 = Conversions.ToString(1);
                  }
                  else
                    this.XML_MainBrand2 = Conversions.ToString(2);
                }
                else
                  this.XML_MainBrand2 = Conversions.ToString(3);
              }
              else
                this.XML_MainBrand2 = Conversions.ToString(4);
            }
            else
              this.XML_MainBrand2 = Conversions.ToString(5);
            xmlTextWriter.WriteEndElement();
            xmlTextWriter.WriteStartElement("SAP:Energy-Efficiency-Rating");
            xmlTextWriter.WriteValue(this.XML_MainBrand);
            xmlTextWriter.WriteEndElement();
            xmlTextWriter.WriteStartElement("SAP:Environmental-Efficiency-Rating");
            xmlTextWriter.WriteValue(this.XML_MainBrand2);
            xmlTextWriter.WriteEndElement();
            xmlTextWriter.WriteEndElement();
            // ISSUE: reference to a compiler-generated field
            if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].IncludeMainHeating2)
            {
              xmlTextWriter.WriteStartElement("SAP:Main-Heating");
              xmlTextWriter.WriteStartElement("SAP:Description");
              // ISSUE: reference to a compiler-generated field
              if (this.Compare_Heaters(closure850_2.\u0024VB\u0024Local_House))
                this.HeatingHeading2 = this.HeatingHeading;
              if (country == 2)
                xmlTextWriter.WriteValue(this.HeatingHeadingwWALES);
              else
                xmlTextWriter.WriteValue(this.HeatingHeading2);
              // ISSUE: reference to a compiler-generated field
              if (this.Compare_Heaters(closure850_2.\u0024VB\u0024Local_House))
              {
                this.XML_secMainBrand = this.XML_MainBrand;
                this.XML_secMainBrand2 = this.XML_MainBrand2;
              }
              string xmlSecMainBrand = this.XML_secMainBrand;
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(xmlSecMainBrand, "★★★★★", false) != 0)
              {
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(xmlSecMainBrand, "★★★★☆", false) != 0)
                {
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(xmlSecMainBrand, "★★★☆☆", false) != 0)
                  {
                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(xmlSecMainBrand, "★★☆☆☆", false) != 0)
                    {
                      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(xmlSecMainBrand, "★☆☆☆☆", false) != 0)
                      {
                        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(xmlSecMainBrand, "-", false) == 0)
                          this.XML_secMainBrand = Conversions.ToString(0);
                      }
                      else
                        this.XML_secMainBrand = Conversions.ToString(1);
                    }
                    else
                      this.XML_secMainBrand = Conversions.ToString(2);
                  }
                  else
                    this.XML_secMainBrand = Conversions.ToString(3);
                }
                else
                  this.XML_secMainBrand = Conversions.ToString(4);
              }
              else
                this.XML_secMainBrand = Conversions.ToString(5);
              string xmlSecMainBrand2 = this.XML_secMainBrand2;
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(xmlSecMainBrand2, "★★★★★", false) != 0)
              {
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(xmlSecMainBrand2, "★★★★☆", false) != 0)
                {
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(xmlSecMainBrand2, "★★★☆☆", false) != 0)
                  {
                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(xmlSecMainBrand2, "★★☆☆☆", false) != 0)
                    {
                      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(xmlSecMainBrand2, "★☆☆☆☆", false) != 0)
                      {
                        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(xmlSecMainBrand2, "-", false) == 0)
                          this.XML_secMainBrand2 = Conversions.ToString(0);
                      }
                      else
                        this.XML_secMainBrand2 = Conversions.ToString(1);
                    }
                    else
                      this.XML_secMainBrand2 = Conversions.ToString(2);
                  }
                  else
                    this.XML_secMainBrand2 = Conversions.ToString(3);
                }
                else
                  this.XML_secMainBrand2 = Conversions.ToString(4);
              }
              else
                this.XML_secMainBrand2 = Conversions.ToString(5);
              xmlTextWriter.WriteEndElement();
              xmlTextWriter.WriteStartElement("SAP:Energy-Efficiency-Rating");
              xmlTextWriter.WriteValue(this.XML_secMainBrand);
              xmlTextWriter.WriteEndElement();
              xmlTextWriter.WriteStartElement("SAP:Environmental-Efficiency-Rating");
              xmlTextWriter.WriteValue(this.XML_secMainBrand2);
              xmlTextWriter.WriteEndElement();
              xmlTextWriter.WriteEndElement();
            }
            xmlTextWriter.WriteStartElement("SAP:Main-Heating-Controls");
            xmlTextWriter.WriteStartElement("SAP:Description");
            // ISSUE: reference to a compiler-generated field
            xmlTextWriter.WriteValue(PDFFunctions.CheckWalesHeatingControl(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.Controls, country));
            xmlTextWriter.WriteEndElement();
            xmlTextWriter.WriteStartElement("SAP:Energy-Efficiency-Rating");
            xmlTextWriter.WriteValue(this.XML_MyMainCode);
            xmlTextWriter.WriteEndElement();
            xmlTextWriter.WriteStartElement("SAP:Environmental-Efficiency-Rating");
            xmlTextWriter.WriteValue(this.XML_MyMainCode2);
            xmlTextWriter.WriteEndElement();
            xmlTextWriter.WriteEndElement();
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].IncludeMainHeating2 & !this.Compare_Heaters(closure850_2.\u0024VB\u0024Local_House) && (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.Controls, SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating2.Controls, false) > 0U)
            {
              xmlTextWriter.WriteStartElement("SAP:Main-Heating-Controls");
              xmlTextWriter.WriteStartElement("SAP:Description");
              // ISSUE: reference to a compiler-generated field
              xmlTextWriter.WriteValue(PDFFunctions.CheckWalesHeatingControl(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating2.Controls, country));
              xmlTextWriter.WriteEndElement();
              xmlTextWriter.WriteStartElement("SAP:Energy-Efficiency-Rating");
              xmlTextWriter.WriteValue(this.XMLsecMyMainCode2);
              xmlTextWriter.WriteEndElement();
              xmlTextWriter.WriteStartElement("SAP:Environmental-Efficiency-Rating");
              xmlTextWriter.WriteValue(this.XMLsecMyMainCode2);
              xmlTextWriter.WriteEndElement();
              xmlTextWriter.WriteEndElement();
            }
            xmlTextWriter.WriteStartElement("SAP:Secondary-Heating");
            xmlTextWriter.WriteStartElement("SAP:Description");
            if (country == 2)
            {
              // ISSUE: reference to a compiler-generated field
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].SecHeating.HGroup, "", false) == 0)
              {
                xmlTextWriter.WriteValue("Dim");
              }
              else
              {
                // ISSUE: reference to a compiler-generated field
                xmlTextWriter.WriteValue("Gwresogyddion ystafell, " + PDFFunctions.CheckWalesFuel(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].SecHeating.Fuel));
              }
            }
            else
            {
              // ISSUE: reference to a compiler-generated field
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].SecHeating.HGroup, "", false) == 0)
              {
                xmlTextWriter.WriteValue("None");
              }
              else
              {
                // ISSUE: reference to a compiler-generated field
                xmlTextWriter.WriteValue("Room heaters, " + PDFFunctions.CheckFuel((object) SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].SecHeating.Fuel));
              }
            }
            xmlTextWriter.WriteEndElement();
            xmlTextWriter.WriteStartElement("SAP:Energy-Efficiency-Rating");
            xmlTextWriter.WriteValue(0);
            xmlTextWriter.WriteEndElement();
            xmlTextWriter.WriteStartElement("SAP:Environmental-Efficiency-Rating");
            xmlTextWriter.WriteValue(0);
            xmlTextWriter.WriteEndElement();
            xmlTextWriter.WriteEndElement();
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
label_305:
                xmlTextWriter.WriteStartElement("SAP:Hot-Water");
                xmlTextWriter.WriteStartElement("SAP:Description");
                xmlTextWriter.WriteValue(PDFFunctions.checkWalesWater(PDFFunctions.CheckSecHeating_Heading(this.HotWaterDesc), country));
                xmlTextWriter.WriteEndElement();
                xmlTextWriter.WriteStartElement("SAP:Energy-Efficiency-Rating");
                xmlTextWriter.WriteValue(this.XML_WaterBanding);
                xmlTextWriter.WriteEndElement();
                xmlTextWriter.WriteStartElement("SAP:Environmental-Efficiency-Rating");
                xmlTextWriter.WriteValue(this.XML_WaterBanding2);
                xmlTextWriter.WriteEndElement();
                xmlTextWriter.WriteEndElement();
                xmlTextWriter.WriteStartElement("SAP:Lighting");
                xmlTextWriter.WriteStartElement("SAP:Description");
                if (country == 2)
                {
                  // ISSUE: reference to a compiler-generated field
                  if ((double) SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].LowEnergyLight == 0.0)
                  {
                    xmlTextWriter.WriteValue("Dim goleuadau ynni-isel");
                  }
                  else
                  {
                    // ISSUE: reference to a compiler-generated field
                    if ((double) SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].LowEnergyLight == 100.0)
                    {
                      // ISSUE: reference to a compiler-generated field
                      xmlTextWriter.WriteValue("Goleuadau ynni-isel mewn " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].LowEnergyLight) + "%  o’r mannau gosod");
                    }
                    else
                    {
                      // ISSUE: reference to a compiler-generated field
                      xmlTextWriter.WriteValue("Goleuadau ynni-isel mewn " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].LowEnergyLight) + "% o’r mannau gosod");
                    }
                  }
                }
                else
                {
                  // ISSUE: reference to a compiler-generated field
                  if ((double) SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].LowEnergyLight == 0.0)
                  {
                    xmlTextWriter.WriteValue("No Low energy lighting");
                  }
                  else
                  {
                    // ISSUE: reference to a compiler-generated field
                    if ((double) SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].LowEnergyLight == 100.0)
                    {
                      xmlTextWriter.WriteValue("Low energy lighting in all fixed outlets");
                    }
                    else
                    {
                      // ISSUE: reference to a compiler-generated field
                      xmlTextWriter.WriteValue("Low energy lighting in " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].LowEnergyLight) + "% of fixed outlets");
                    }
                  }
                }
                xmlTextWriter.WriteEndElement();
                xmlTextWriter.WriteStartElement("SAP:Energy-Efficiency-Rating");
                // ISSUE: reference to a compiler-generated field
                xmlTextWriter.WriteValue(PDFFunctions.BandCheckLighting((double) SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].LowEnergyLight, "XML"));
                xmlTextWriter.WriteEndElement();
                xmlTextWriter.WriteStartElement("SAP:Environmental-Efficiency-Rating");
                // ISSUE: reference to a compiler-generated field
                xmlTextWriter.WriteValue(PDFFunctions.BandCheckLighting((double) SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].LowEnergyLight, "XML"));
                xmlTextWriter.WriteEndElement();
                xmlTextWriter.WriteEndElement();
                float num5;
                // ISSUE: reference to a compiler-generated field
                if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Status, "Existing dwelling (SAP)", false) > 0U)
                {
                  xmlTextWriter.WriteStartElement("SAP:Air-Tightness");
                  // ISSUE: reference to a compiler-generated field
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.Pressure, "Calculated", false) == 0)
                  {
                    xmlTextWriter.WriteStartElement("SAP:Description");
                    if (country == 2)
                      xmlTextWriter.WriteValue("(heb ei brofi)");
                    else
                      xmlTextWriter.WriteValue("(not tested)");
                    xmlTextWriter.WriteEndElement();
                    xmlTextWriter.WriteStartElement("SAP:Energy-Efficiency-Rating");
                    xmlTextWriter.WriteValue(0);
                    xmlTextWriter.WriteEndElement();
                    xmlTextWriter.WriteStartElement("SAP:Environmental-Efficiency-Rating");
                    xmlTextWriter.WriteValue(0);
                    xmlTextWriter.WriteEndElement();
                  }
                  else
                  {
                    xmlTextWriter.WriteStartElement("SAP:Description");
                    if (country == 2)
                    {
                      // ISSUE: reference to a compiler-generated field
                      if ((double) SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.DesignAir != 0.0)
                      {
                        // ISSUE: reference to a compiler-generated field
                        xmlTextWriter.WriteValue("Athreiddedd aer " + Microsoft.VisualBasic.Strings.Format((object) SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.DesignAir, "0.0") + " m\u00B3/h.m\u00B2 (rhagdybiaeth)");
                        // ISSUE: reference to a compiler-generated field
                        num5 = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.DesignAir;
                      }
                      // ISSUE: reference to a compiler-generated field
                      if ((double) SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.MeasuredAir != 0.0)
                      {
                        // ISSUE: reference to a compiler-generated field
                        xmlTextWriter.WriteValue("Athreiddedd aer " + Microsoft.VisualBasic.Strings.Format((object) SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.MeasuredAir, "0.0") + " m\u00B3/h.m\u00B2  (wedi’i brofi)");
                        // ISSUE: reference to a compiler-generated field
                        num5 = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.MeasuredAir;
                      }
                    }
                    else
                    {
                      // ISSUE: reference to a compiler-generated field
                      if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.AveragePerm)
                      {
                        // ISSUE: reference to a compiler-generated field
                        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.Pressure, "As built", false) == 0)
                        {
                          // ISSUE: reference to a compiler-generated field
                          xmlTextWriter.WriteValue("Air permeability " + Microsoft.VisualBasic.Strings.Format((object) (float) ((double) SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.MeasuredAir + 2.0), "0.0") + " m\u00B3/h.m\u00B2 (assessed average)");
                          // ISSUE: reference to a compiler-generated field
                          num5 = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.MeasuredAir;
                        }
                        else
                        {
                          // ISSUE: reference to a compiler-generated field
                          xmlTextWriter.WriteValue("Air permeability " + Microsoft.VisualBasic.Strings.Format((object) (float) ((double) SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.DesignAir + 2.0), "0.0") + " m\u00B3/h.m\u00B2 (assessed average)");
                          // ISSUE: reference to a compiler-generated field
                          num5 = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.DesignAir;
                        }
                      }
                      else
                      {
                        // ISSUE: reference to a compiler-generated field
                        if ((double) SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.DesignAir != 0.0)
                        {
                          // ISSUE: reference to a compiler-generated field
                          xmlTextWriter.WriteValue("Air permeability " + Microsoft.VisualBasic.Strings.Format((object) SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.DesignAir, "0.0") + " m\u00B3/h.m\u00B2 (assumed)");
                          // ISSUE: reference to a compiler-generated field
                          num5 = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.DesignAir;
                        }
                        else
                        {
                          // ISSUE: reference to a compiler-generated field
                          if ((double) SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.MeasuredAir != 0.0)
                          {
                            // ISSUE: reference to a compiler-generated field
                            xmlTextWriter.WriteValue("Air permeability " + Microsoft.VisualBasic.Strings.Format((object) SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.MeasuredAir, "0.0") + " m\u00B3/h.m\u00B2 (as tested)");
                            // ISSUE: reference to a compiler-generated field
                            num5 = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.MeasuredAir;
                          }
                          else
                          {
                            // ISSUE: reference to a compiler-generated field
                            if ((double) SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.AssumedAir != 0.0)
                            {
                              xmlTextWriter.WriteValue("(not tested)");
                              // ISSUE: reference to a compiler-generated field
                              num5 = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.MeasuredAir;
                            }
                          }
                        }
                      }
                      // ISSUE: reference to a compiler-generated field
                      if ((double) SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.AssumedAir != 0.0)
                      {
                        if (country == 2)
                          xmlTextWriter.WriteValue("(heb ei brofi)");
                        // ISSUE: reference to a compiler-generated field
                        num5 = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.AssumedAir;
                      }
                    }
                    xmlTextWriter.WriteEndElement();
                    xmlTextWriter.WriteStartElement("SAP:Energy-Efficiency-Rating");
                    // ISSUE: reference to a compiler-generated field
                    if ((double) SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.AssumedAir == 0.0)
                      xmlTextWriter.WriteValue(PDFFunctions.BandCheckAirPressure((double) num5, "XML"));
                    else
                      xmlTextWriter.WriteValue(0);
                    xmlTextWriter.WriteEndElement();
                    xmlTextWriter.WriteStartElement("SAP:Environmental-Efficiency-Rating");
                    // ISSUE: reference to a compiler-generated field
                    if ((double) SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.AssumedAir == 0.0)
                      xmlTextWriter.WriteValue(PDFFunctions.BandCheckAirPressure((double) num5, "XML"));
                    else
                      xmlTextWriter.WriteValue(0);
                    xmlTextWriter.WriteEndElement();
                  }
                  xmlTextWriter.WriteEndElement();
                }
                xmlTextWriter.WriteStartElement("SAP:Has-Fixed-Air-Conditioning");
                // ISSUE: reference to a compiler-generated field
                if (!SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Cooling.Include)
                  xmlTextWriter.WriteValue("false");
                else
                  xmlTextWriter.WriteValue("true");
                xmlTextWriter.WriteEndElement();
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.SystemRef == 901 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.SGroup, "Heat pumps", false) == 0 & !SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.Cylinder.Thermostat)
                {
                  xmlTextWriter.WriteStartElement("SAP:Has-Hot-Water-Cylinder");
                  xmlTextWriter.WriteValue("false");
                  xmlTextWriter.WriteEndElement();
                }
                else
                {
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.SystemRef == 901 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.HGroup, "Community heating schemes", false) == 0 & !SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.Cylinder.Thermostat)
                  {
                    xmlTextWriter.WriteStartElement("SAP:Has-Hot-Water-Cylinder");
                    xmlTextWriter.WriteValue("false");
                    xmlTextWriter.WriteEndElement();
                  }
                  else
                  {
                    // ISSUE: reference to a compiler-generated field
                    if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.Cylinder.Thermostat)
                    {
                      xmlTextWriter.WriteStartElement("SAP:Has-Hot-Water-Cylinder");
                      xmlTextWriter.WriteValue("true");
                      xmlTextWriter.WriteEndElement();
                    }
                    else
                    {
                      xmlTextWriter.WriteStartElement("SAP:Has-Hot-Water-Cylinder");
                      // ISSUE: reference to a compiler-generated field
                      // ISSUE: reference to a compiler-generated field
                      if ((double) SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.Cylinder.Volume != 0.0 & SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.SAPTableCode != 192)
                      {
                        // ISSUE: reference to a compiler-generated field
                        if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.Cylinder.Thermostat)
                        {
                          xmlTextWriter.WriteValue("true");
                        }
                        else
                        {
                          // ISSUE: reference to a compiler-generated field
                          if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.Thermal.Location, "", false) > 0U)
                          {
                            xmlTextWriter.WriteValue("false");
                          }
                          else
                          {
                            // ISSUE: reference to a compiler-generated field
                            if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.Thermal.Location, "", false) > 0U)
                            {
                              xmlTextWriter.WriteValue("false");
                            }
                            else
                            {
                              // ISSUE: reference to a compiler-generated field
                              if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.Thermal.Include)
                              {
                                xmlTextWriter.WriteValue("false");
                              }
                              else
                              {
                                // ISSUE: reference to a compiler-generated field
                                if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.SAPTableCode == 130)
                                  xmlTextWriter.WriteValue("false");
                                else
                                  xmlTextWriter.WriteValue("true");
                              }
                            }
                          }
                        }
                      }
                      else
                      {
                        // ISSUE: reference to a compiler-generated field
                        switch (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.SAPTableCode)
                        {
                          case 306:
                          case 307:
                            xmlTextWriter.WriteValue("true");
                            break;
                          default:
                            xmlTextWriter.WriteValue("false");
                            break;
                        }
                      }
                      xmlTextWriter.WriteEndElement();
                    }
                  }
                }
                xmlTextWriter.WriteStartElement("SAP:Has-Heated-Separate-Conservatory");
                // ISSUE: reference to a compiler-generated field
                if (!string.IsNullOrEmpty(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Conservatory))
                {
                  // ISSUE: reference to a compiler-generated field
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Conservatory, "Separated heated conservatory", false) == 0)
                    xmlTextWriter.WriteValue("true");
                  else
                    xmlTextWriter.WriteValue("false");
                }
                else
                  xmlTextWriter.WriteValue("false");
                xmlTextWriter.WriteEndElement();
                xmlTextWriter.WriteStartElement("SAP:Dwelling-Type");
                if (country == 2)
                {
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].PropertyType, nameof (House), false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].PropertyType, "Bungalow", false) == 0)
                  {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    xmlTextWriter.WriteValue(PDFFunctions.CheckWalesDwellingType(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].BuildForm + " " + SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].PropertyType));
                  }
                  else
                  {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    xmlTextWriter.WriteValue(PDFFunctions.CheckWalesDwellingType(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].FlatType.Replace(" ", "-") + " " + Microsoft.VisualBasic.Strings.LCase(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].PropertyType)));
                  }
                }
                else
                {
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].PropertyType, nameof (House), false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].PropertyType, "Bungalow", false) == 0)
                  {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].BuildForm + " " + Microsoft.VisualBasic.Strings.LCase(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].PropertyType));
                  }
                  else
                  {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].FlatType.Replace(" ", "-") + " " + Microsoft.VisualBasic.Strings.LCase(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].PropertyType));
                  }
                }
                xmlTextWriter.WriteEndElement();
                xmlTextWriter.WriteStartElement("SAP:Total-Floor-Area");
                double box4 = SAP_Module.Calculation2012.Calculation.Dimensions.Box4;
                xmlTextWriter.WriteValue(Math.Round(SAP_Module.Calculation2012.Calculation.Dimensions.Box4, 0));
                xmlTextWriter.WriteEndElement();
                this.carbonEmm = SAP_Module.Calculation2012.Calculation.CO2_Emissions_12a.Box272 == 0.0 ? SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box383 / 1000.0 : SAP_Module.Calculation2012.Calculation.CO2_Emissions_12a.Box272 / 1000.0;
                xmlTextWriter.WriteEndElement();
                xmlTextWriter.WriteStartElement("SAP:Energy-Use");
                xmlTextWriter.WriteStartElement("SAP:Energy-Rating-Average");
                // ISSUE: reference to a compiler-generated field
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Address.Country, "Northern Ireland", false) == 0)
                  xmlTextWriter.WriteValue(57);
                else
                  xmlTextWriter.WriteValue(60);
                xmlTextWriter.WriteEndElement();
                // ISSUE: reference to a compiler-generated field
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Address.Country, "Northern Ireland", false) == 0)
                {
                  xmlTextWriter.WriteStartElement("SAP:Energy-Rating-Typical-Newbuild");
                  xmlTextWriter.WriteValue(Functions.FindNewDwellingRatingNI(SAP_Module.CurrDwelling));
                  xmlTextWriter.WriteEndElement();
                }
                xmlTextWriter.WriteStartElement("SAP:Energy-Rating-Current");
                if (SAP_Module.Calculation2012.Calculation.SAP_rating_11a.SAPRating <= 0.0 & SAP_Module.Calculation2012.Calculation.SAP_rating_11b.SAPRating <= 0.0)
                  xmlTextWriter.WriteValue(1);
                else if (SAP_Module.Calculation2012.Calculation.SAP_rating_11a.SAPRating == 0.0)
                  xmlTextWriter.WriteValue(SAP_Module.Calculation2012.Calculation.SAP_rating_11b.SAPRating);
                else
                  xmlTextWriter.WriteValue(SAP_Module.Calculation2012.Calculation.SAP_rating_11a.SAPRating);
                xmlTextWriter.WriteEndElement();
                xmlTextWriter.WriteStartElement("SAP:Energy-Rating-Potential");
                if (SAP_Module.CalculationImprove2012.Calculation.SAP_rating_11a.SAPRating <= 0.0 & SAP_Module.CalculationImprove2012.Calculation.SAP_rating_11b.SAPRating <= 0.0)
                  xmlTextWriter.WriteValue(1);
                else if (SAP_Module.CalculationImprove2012.Calculation.SAP_rating_11a.SAPRating == 0.0)
                  xmlTextWriter.WriteValue(Math.Round(SAP_Module.CalculationImprove2012.Calculation.SAP_rating_11b.SAPRating, 0));
                else
                  xmlTextWriter.WriteValue(Math.Round(SAP_Module.CalculationImprove2012.Calculation.SAP_rating_11a.SAPRating, 0));
                xmlTextWriter.WriteEndElement();
                if (country == 4)
                {
                  xmlTextWriter.WriteStartElement("SAP:Environmental-Impact-Average");
                  xmlTextWriter.WriteValue("59");
                  xmlTextWriter.WriteEndElement();
                }
                xmlTextWriter.WriteStartElement("SAP:Environmental-Impact-Current");
                if (SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.EIRating <= 0.0 & SAP_Module.Calculation2012.Calculation.CO2_Emissions_12a.EIValue <= 0.0)
                  xmlTextWriter.WriteValue(1);
                else if (SAP_Module.Calculation2012.Calculation.CO2_Emissions_12a.EIValue == 0.0)
                  xmlTextWriter.WriteValue(Math.Round(SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.EIRating, 0));
                else
                  xmlTextWriter.WriteValue(Math.Round(SAP_Module.Calculation2012.Calculation.CO2_Emissions_12a.EIValue, 0));
                xmlTextWriter.WriteEndElement();
                xmlTextWriter.WriteStartElement("SAP:Environmental-Impact-Potential");
                if (SAP_Module.CalculationImprove2012.Calculation.CO2_Emissions_12a.EIValue <= 0.0 & SAP_Module.CalculationImprove2012.Calculation.CO2_Emissions_12b.EIRating <= 0.0)
                  xmlTextWriter.WriteValue(1);
                else if (SAP_Module.CalculationImprove2012.Calculation.CO2_Emissions_12a.EIValue == 0.0)
                  xmlTextWriter.WriteValue(Math.Round(SAP_Module.CalculationImprove2012.Calculation.CO2_Emissions_12b.EIRating, 0));
                else
                  xmlTextWriter.WriteValue(Math.Round(SAP_Module.CalculationImprove2012.Calculation.CO2_Emissions_12a.EIValue, 0));
                xmlTextWriter.WriteEndElement();
                xmlTextWriter.WriteStartElement("SAP:Energy-Consumption-Current");
                if (SAP_Module.Calculation2012.Calculation.Primary_Energy_13a.Box273 == 0.0)
                  xmlTextWriter.WriteValue(Math.Round(SAP_Module.Calculation2012.Calculation.Primary_Energy_13b.Box383 / SAP_Module.Calculation2012.Calculation.Dimensions.Box4, 0));
                else
                  xmlTextWriter.WriteValue(Math.Round(SAP_Module.Calculation2012.Calculation.Primary_Energy_13a.Box273, 0));
                xmlTextWriter.WriteEndElement();
                xmlTextWriter.WriteStartElement("SAP:Energy-Consumption-Potential");
                if (SAP_Module.Calculation2012.Calculation.Primary_Energy_13a.Box273 != 0.0)
                  xmlTextWriter.WriteValue(Math.Round(SAP_Module.CalculationImprove2012.Calculation.Primary_Energy_13a.Box273, 0));
                else
                  xmlTextWriter.WriteValue(Math.Round(SAP_Module.CalculationImprove2012.Calculation.Primary_Energy_13b.Box383 / SAP_Module.Calculation2012.Calculation.Dimensions.Box4, 0));
                xmlTextWriter.WriteEndElement();
                xmlTextWriter.WriteStartElement("SAP:CO2-Emissions-Current");
                if (SAP_Module.Calculation2012.Calculation.CO2_Emissions_12a.Box272 != 0.0)
                {
                  this.carbonEmm = SAP_Module.Calculation2012.Calculation.CO2_Emissions_12a.Box272 / 1000.0;
                  this.carbonEmm2 = SAP_Module.CalculationImprove2012.Calculation.CO2_Emissions_12a.Box272 / 1000.0;
                }
                else
                {
                  this.carbonEmm = SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box383 / 1000.0;
                  this.carbonEmm2 = SAP_Module.CalculationImprove2012.Calculation.CO2_Emissions_12b.Box383 / 1000.0;
                }
                if (this.carbonEmm > 10.0)
                  xmlTextWriter.WriteValue(Math.Round(this.carbonEmm, 0));
                else
                  xmlTextWriter.WriteValue(Microsoft.VisualBasic.Strings.Format((object) this.carbonEmm, "0.0"));
                xmlTextWriter.WriteEndElement();
                xmlTextWriter.WriteStartElement("SAP:CO2-Emissions-Potential");
                if (this.carbonEmm2 > 10.0)
                  xmlTextWriter.WriteValue(Math.Round(this.carbonEmm2, 0));
                else
                  xmlTextWriter.WriteValue(Microsoft.VisualBasic.Strings.Format((object) this.carbonEmm2, "0.0"));
                xmlTextWriter.WriteEndElement();
                xmlTextWriter.WriteStartElement("SAP:CO2-Emissions-Current-Per-Floor-Area");
                if (SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box384 == 0.0)
                {
                  if (SAP_Module.Calculation2012.Calculation.CO2_Emissions_12a.Box273 < 0.0)
                    xmlTextWriter.WriteValue(Math.Round(SAP_Module.Calculation2012.Calculation.CO2_Emissions_12a.Box273, 1));
                  else
                    xmlTextWriter.WriteValue(Math.Round(SAP_Module.Calculation2012.Calculation.CO2_Emissions_12a.Box273, 0));
                }
                else if (SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box384 < 0.0)
                  xmlTextWriter.WriteValue(Math.Round(SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box384, 1));
                else
                  xmlTextWriter.WriteValue(Math.Round(SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box384, 0));
                xmlTextWriter.WriteEndElement();
                xmlTextWriter.WriteStartElement("SAP:Lighting-Cost-Current");
                xmlTextWriter.WriteStartAttribute("currency");
                xmlTextWriter.WriteValue("GBP");
                xmlTextWriter.WriteEndAttribute();
                if (SAP_Module.Calculation2012.Calculation.Actual_costs_10a.Box250 != 0.0)
                  xmlTextWriter.WriteValue(Math.Round(SAP_Module.Calculation2012.Calculation.Actual_costs_10a.Box250, 0));
                else
                  xmlTextWriter.WriteValue(Math.Round(SAP_Module.Calculation2012.Calculation.Actual_costs_10b.Box350, 0));
                xmlTextWriter.WriteEndElement();
                xmlTextWriter.WriteStartElement("SAP:Lighting-Cost-Potential");
                xmlTextWriter.WriteStartAttribute("currency");
                xmlTextWriter.WriteValue("GBP");
                xmlTextWriter.WriteEndAttribute();
                if (SAP_Module.Calculation2012.Calculation.Actual_costs_10a.Box250 != 0.0)
                  xmlTextWriter.WriteValue(Math.Round(SAP_Module.CalculationImprove2012.Calculation.Actual_costs_10a.Box250, 0));
                else
                  xmlTextWriter.WriteValue(Math.Round(SAP_Module.CalculationImprove2012.Calculation.Actual_costs_10b.Box350, 0));
                xmlTextWriter.WriteEndElement();
                xmlTextWriter.WriteStartElement("SAP:Heating-Cost-Current");
                xmlTextWriter.WriteStartAttribute("currency");
                xmlTextWriter.WriteValue("GBP");
                xmlTextWriter.WriteEndAttribute();
                if (Math.Round(SAP_Module.Calculation2012.Calculation.Actual_costs_10a.Box240 + SAP_Module.Calculation2012.Calculation.Actual_costs_10a.Box241 + SAP_Module.Calculation2012.Calculation.Actual_costs_10a.Box242 + SAP_Module.Calculation2012.Calculation.Actual_costs_10a.Box249 + SAP_Module.Calculation2012.Calculation.Actual_costs_10a.Box251, 0) != 0.0)
                  xmlTextWriter.WriteValue(Math.Round(SAP_Module.Calculation2012.Calculation.Actual_costs_10a.Box240 + SAP_Module.Calculation2012.Calculation.Actual_costs_10a.Box241 + SAP_Module.Calculation2012.Calculation.Actual_costs_10a.Box242 + SAP_Module.Calculation2012.Calculation.Actual_costs_10a.Box249 + SAP_Module.Calculation2012.Calculation.Actual_costs_10a.Box251, 0));
                else
                  xmlTextWriter.WriteValue(Math.Round(SAP_Module.Calculation2012.Calculation.Actual_costs_10b.Box340a + SAP_Module.Calculation2012.Calculation.Actual_costs_10b.Box340b + SAP_Module.Calculation2012.Calculation.Actual_costs_10b.Box340c + SAP_Module.Calculation2012.Calculation.Actual_costs_10b.Box340d + SAP_Module.Calculation2012.Calculation.Actual_costs_10b.Box340e + SAP_Module.Calculation2012.Calculation.Actual_costs_10b.Box341 + SAP_Module.Calculation2012.Calculation.Actual_costs_10b.Box349 + SAP_Module.Calculation2012.Calculation.Actual_costs_10b.Box351, 0));
                xmlTextWriter.WriteEndElement();
                xmlTextWriter.WriteStartElement("SAP:Heating-Cost-Potential");
                xmlTextWriter.WriteStartAttribute("currency");
                xmlTextWriter.WriteValue("GBP");
                xmlTextWriter.WriteEndAttribute();
                if (Math.Round(SAP_Module.Calculation2012.Calculation.Actual_costs_10a.Box240 + SAP_Module.Calculation2012.Calculation.Actual_costs_10a.Box241 + SAP_Module.Calculation2012.Calculation.Actual_costs_10a.Box242 + SAP_Module.Calculation2012.Calculation.Actual_costs_10a.Box249 + SAP_Module.Calculation2012.Calculation.Actual_costs_10a.Box251, 0) != 0.0)
                  xmlTextWriter.WriteValue(Microsoft.VisualBasic.Strings.Format((object) Math.Round(SAP_Module.CalculationImprove2012.Calculation.Actual_costs_10a.Box240 + SAP_Module.CalculationImprove2012.Calculation.Actual_costs_10a.Box241 + SAP_Module.CalculationImprove2012.Calculation.Actual_costs_10a.Box242 + SAP_Module.CalculationImprove2012.Calculation.Actual_costs_10a.Box249 - SAP_Module.CalculationImprove2012.Calculation.Actual_costs_10a.Box249Water + SAP_Module.CalculationImprove2012.Calculation.Actual_costs_10a.Box251, 0), "####"));
                else
                  xmlTextWriter.WriteValue(Microsoft.VisualBasic.Strings.Format((object) Math.Round(SAP_Module.CalculationImprove2012.Calculation.Actual_costs_10b.Box340a + SAP_Module.CalculationImprove2012.Calculation.Actual_costs_10b.Box340b + SAP_Module.CalculationImprove2012.Calculation.Actual_costs_10b.Box340c + SAP_Module.CalculationImprove2012.Calculation.Actual_costs_10b.Box340d + SAP_Module.CalculationImprove2012.Calculation.Actual_costs_10b.Box340e + SAP_Module.CalculationImprove2012.Calculation.Actual_costs_10b.Box341 + SAP_Module.CalculationImprove2012.Calculation.Actual_costs_10b.Box349 + SAP_Module.CalculationImprove2012.Calculation.Actual_costs_10b.Box351, 0), "####"));
                xmlTextWriter.WriteEndElement();
                xmlTextWriter.WriteStartElement("SAP:Hot-Water-Cost-Current");
                xmlTextWriter.WriteStartAttribute("currency");
                xmlTextWriter.WriteValue("GBP");
                xmlTextWriter.WriteEndAttribute();
                if (SAP_Module.Calculation2012.Calculation.Actual_costs_10a.Box245 + SAP_Module.Calculation2012.Calculation.Actual_costs_10a.Box246 + SAP_Module.Calculation2012.Calculation.Actual_costs_10a.Box247 + SAP_Module.Calculation2012.Calculation.Actual_costs_10a.Box247Imm != 0.0)
                  xmlTextWriter.WriteValue(Math.Round(SAP_Module.Calculation2012.Calculation.Actual_costs_10a.Box245 + SAP_Module.Calculation2012.Calculation.Actual_costs_10a.Box246 + SAP_Module.Calculation2012.Calculation.Actual_costs_10a.Box247 + SAP_Module.Calculation2012.Calculation.Actual_costs_10a.Box247Imm, 0));
                else
                  xmlTextWriter.WriteValue(Math.Round(SAP_Module.Calculation2012.Calculation.Actual_costs_10b.Box342e + SAP_Module.Calculation2012.Calculation.Actual_costs_10b.Box342d + SAP_Module.Calculation2012.Calculation.Actual_costs_10b.Box342c + SAP_Module.Calculation2012.Calculation.Actual_costs_10b.Box342b + SAP_Module.Calculation2012.Calculation.Actual_costs_10b.Box342a, 0));
                xmlTextWriter.WriteEndElement();
                xmlTextWriter.WriteStartElement("SAP:Hot-Water-Cost-Potential");
                xmlTextWriter.WriteStartAttribute("currency");
                xmlTextWriter.WriteValue("GBP");
                xmlTextWriter.WriteEndAttribute();
                if (SAP_Module.Calculation2012.Calculation.Actual_costs_10a.Box245 + SAP_Module.Calculation2012.Calculation.Actual_costs_10a.Box246 + SAP_Module.Calculation2012.Calculation.Actual_costs_10a.Box247 + SAP_Module.Calculation2012.Calculation.Actual_costs_10a.Box247Imm != 0.0)
                  xmlTextWriter.WriteValue(Math.Round(SAP_Module.CalculationImprove2012.Calculation.Actual_costs_10a.Box245 + SAP_Module.CalculationImprove2012.Calculation.Actual_costs_10a.Box246 + SAP_Module.CalculationImprove2012.Calculation.Actual_costs_10a.Box247 + SAP_Module.CalculationImprove2012.Calculation.Actual_costs_10a.Box247Imm + SAP_Module.CalculationImprove2012.Calculation.Actual_costs_10a.Box249Water, 0));
                else
                  xmlTextWriter.WriteValue(Math.Round(SAP_Module.CalculationImprove2012.Calculation.Actual_costs_10b.Box342e + SAP_Module.CalculationImprove2012.Calculation.Actual_costs_10b.Box342d + SAP_Module.CalculationImprove2012.Calculation.Actual_costs_10b.Box342c + SAP_Module.CalculationImprove2012.Calculation.Actual_costs_10b.Box342b + SAP_Module.CalculationImprove2012.Calculation.Actual_costs_10b.Box342a, 0));
                xmlTextWriter.WriteEndElement();
                xmlTextWriter.WriteEndElement();
                int num6;
                if (SAP_Module.Improve.LowerCost.E.Include)
                {
                  int num7;
                  num6 = checked (num7 + 1);
                }
                if (SAP_Module.Improve.Further.N.Include)
                  checked { ++num6; }
                if (SAP_Module.Improve.Further.U.Include)
                  checked { ++num6; }
                if (SAP_Module.Improve.Further.V.Include)
                  checked { ++num6; }
                if ((uint) num6 > 0U)
                {
                  xmlTextWriter.WriteStartElement("SAP:Suggested-Improvements");
                  int num8 = 1;
                  if (SAP_Module.Improve.LowerCost.E.Include)
                  {
                    xmlTextWriter.WriteStartElement("SAP:Improvement");
                    xmlTextWriter.WriteStartElement("SAP:Sequence");
                    xmlTextWriter.WriteValue(num8);
                    xmlTextWriter.WriteEndElement();
                    xmlTextWriter.WriteStartElement("SAP:Improvement-Category");
                    xmlTextWriter.WriteValue(1);
                    xmlTextWriter.WriteEndElement();
                    xmlTextWriter.WriteStartElement("SAP:Improvement-Type");
                    xmlTextWriter.WriteValue("E");
                    xmlTextWriter.WriteEndElement();
                    xmlTextWriter.WriteStartElement("SAP:Improvement-Details");
                    xmlTextWriter.WriteStartElement("SAP:Improvement-Number");
                    xmlTextWriter.WriteValue(35);
                    xmlTextWriter.WriteEndElement();
                    xmlTextWriter.WriteEndElement();
                    xmlTextWriter.WriteStartElement("SAP:Typical-Saving");
                    xmlTextWriter.WriteStartAttribute("currency");
                    xmlTextWriter.WriteValue("GBP");
                    xmlTextWriter.WriteEndAttribute();
                    xmlTextWriter.WriteValue(Math.Abs(SAP_Module.Improve.LowerCost.E.CostChange));
                    xmlTextWriter.WriteEndElement();
                    xmlTextWriter.WriteStartElement("SAP:Indicative-Cost");
                    xmlTextWriter.WriteValue("£" + Conversions.ToString(Math.Round(this.indicative, 0, MidpointRounding.AwayFromZero)));
                    xmlTextWriter.WriteEndElement();
                    xmlTextWriter.WriteStartElement("SAP:Energy-Performance-Rating");
                    xmlTextWriter.WriteValue(SAP_Module.Improve.LowerCost.E.Energy.Substring(2, checked (SAP_Module.Improve.LowerCost.E.Energy.Length - 2)));
                    xmlTextWriter.WriteEndElement();
                    xmlTextWriter.WriteStartElement("SAP:Environmental-Impact-Rating");
                    xmlTextWriter.WriteValue(SAP_Module.Improve.LowerCost.E.Environ.Substring(2, checked (SAP_Module.Improve.LowerCost.E.Environ.Length - 2)));
                    xmlTextWriter.WriteEndElement();
                    xmlTextWriter.WriteEndElement();
                    checked { ++num8; }
                  }
                  if (SAP_Module.Improve.Further.N.Include)
                  {
                    xmlTextWriter.WriteStartElement("SAP:Improvement");
                    xmlTextWriter.WriteStartElement("SAP:Sequence");
                    xmlTextWriter.WriteValue(num8);
                    xmlTextWriter.WriteEndElement();
                    xmlTextWriter.WriteStartElement("SAP:Improvement-Category");
                    xmlTextWriter.WriteValue(3);
                    xmlTextWriter.WriteEndElement();
                    xmlTextWriter.WriteStartElement("SAP:Improvement-Type");
                    xmlTextWriter.WriteValue("N");
                    xmlTextWriter.WriteEndElement();
                    xmlTextWriter.WriteStartElement("SAP:Improvement-Details");
                    xmlTextWriter.WriteStartElement("SAP:Improvement-Number");
                    xmlTextWriter.WriteValue(19);
                    xmlTextWriter.WriteEndElement();
                    xmlTextWriter.WriteEndElement();
                    xmlTextWriter.WriteStartElement("SAP:Typical-Saving");
                    xmlTextWriter.WriteStartAttribute("currency");
                    xmlTextWriter.WriteValue("GBP");
                    xmlTextWriter.WriteEndAttribute();
                    xmlTextWriter.WriteValue(Math.Abs(SAP_Module.Improve.Further.N.CostChange));
                    xmlTextWriter.WriteEndElement();
                    xmlTextWriter.WriteStartElement("SAP:Indicative-Cost");
                    xmlTextWriter.WriteValue("£4,000 - £6,000");
                    xmlTextWriter.WriteEndElement();
                    xmlTextWriter.WriteStartElement("SAP:Energy-Performance-Rating");
                    xmlTextWriter.WriteValue(SAP_Module.Improve.Further.N.Energy.Substring(2, checked (SAP_Module.Improve.Further.N.Energy.Length - 2)));
                    xmlTextWriter.WriteEndElement();
                    xmlTextWriter.WriteStartElement("SAP:Environmental-Impact-Rating");
                    xmlTextWriter.WriteValue(SAP_Module.Improve.Further.N.Environ.Substring(2, checked (SAP_Module.Improve.Further.N.Environ.Length - 2)));
                    xmlTextWriter.WriteEndElement();
                    xmlTextWriter.WriteEndElement();
                    checked { ++num8; }
                  }
                  if (SAP_Module.Improve.Further.U.Include)
                  {
                    xmlTextWriter.WriteStartElement("SAP:Improvement");
                    xmlTextWriter.WriteStartElement("SAP:Sequence");
                    xmlTextWriter.WriteValue(num8);
                    xmlTextWriter.WriteEndElement();
                    xmlTextWriter.WriteStartElement("SAP:Improvement-Category");
                    xmlTextWriter.WriteValue(3);
                    xmlTextWriter.WriteEndElement();
                    xmlTextWriter.WriteStartElement("SAP:Improvement-Type");
                    xmlTextWriter.WriteValue("U");
                    xmlTextWriter.WriteEndElement();
                    xmlTextWriter.WriteStartElement("SAP:Improvement-Details");
                    xmlTextWriter.WriteStartElement("SAP:Improvement-Number");
                    xmlTextWriter.WriteValue(34);
                    xmlTextWriter.WriteEndElement();
                    xmlTextWriter.WriteEndElement();
                    xmlTextWriter.WriteStartElement("SAP:Typical-Saving");
                    xmlTextWriter.WriteStartAttribute("currency");
                    xmlTextWriter.WriteValue("GBP");
                    xmlTextWriter.WriteEndAttribute();
                    xmlTextWriter.WriteValue(Math.Abs(SAP_Module.Improve.Further.U.CostChange));
                    xmlTextWriter.WriteEndElement();
                    xmlTextWriter.WriteStartElement("SAP:Indicative-Cost");
                    xmlTextWriter.WriteValue("£11,000 - £20,000");
                    xmlTextWriter.WriteEndElement();
                    xmlTextWriter.WriteStartElement("SAP:Energy-Performance-Rating");
                    xmlTextWriter.WriteValue(SAP_Module.Improve.Further.U.Energy.Substring(2, checked (SAP_Module.Improve.Further.U.Energy.Length - 2)));
                    xmlTextWriter.WriteEndElement();
                    xmlTextWriter.WriteStartElement("SAP:Environmental-Impact-Rating");
                    xmlTextWriter.WriteValue(SAP_Module.Improve.Further.U.Environ.Substring(2, checked (SAP_Module.Improve.Further.U.Environ.Length - 2)));
                    xmlTextWriter.WriteEndElement();
                    xmlTextWriter.WriteEndElement();
                    checked { ++num8; }
                  }
                  if (SAP_Module.Improve.Further.V.Include)
                  {
                    xmlTextWriter.WriteStartElement("SAP:Improvement");
                    xmlTextWriter.WriteStartElement("SAP:Sequence");
                    xmlTextWriter.WriteValue(num8);
                    xmlTextWriter.WriteEndElement();
                    xmlTextWriter.WriteStartElement("SAP:Improvement-Category");
                    xmlTextWriter.WriteValue(3);
                    xmlTextWriter.WriteEndElement();
                    xmlTextWriter.WriteStartElement("SAP:Improvement-Type");
                    xmlTextWriter.WriteValue("V");
                    xmlTextWriter.WriteEndElement();
                    xmlTextWriter.WriteStartElement("SAP:Improvement-Details");
                    xmlTextWriter.WriteStartElement("SAP:Improvement-Number");
                    xmlTextWriter.WriteValue(44);
                    xmlTextWriter.WriteEndElement();
                    xmlTextWriter.WriteEndElement();
                    xmlTextWriter.WriteStartElement("SAP:Typical-Saving");
                    xmlTextWriter.WriteStartAttribute("currency");
                    xmlTextWriter.WriteValue("GBP");
                    xmlTextWriter.WriteEndAttribute();
                    xmlTextWriter.WriteValue(Math.Abs(SAP_Module.Improve.Further.V.CostChange));
                    xmlTextWriter.WriteEndElement();
                    xmlTextWriter.WriteStartElement("SAP:Indicative-Cost");
                    xmlTextWriter.WriteValue("£1,500 - £4,000");
                    xmlTextWriter.WriteEndElement();
                    xmlTextWriter.WriteStartElement("SAP:Energy-Performance-Rating");
                    xmlTextWriter.WriteValue(SAP_Module.Improve.Further.V.Energy.Substring(2, checked (SAP_Module.Improve.Further.V.Energy.Length - 2)));
                    xmlTextWriter.WriteEndElement();
                    xmlTextWriter.WriteStartElement("SAP:Environmental-Impact-Rating");
                    xmlTextWriter.WriteValue(SAP_Module.Improve.Further.V.Environ.Substring(2, checked (SAP_Module.Improve.Further.V.Environ.Length - 2)));
                    xmlTextWriter.WriteEndElement();
                    xmlTextWriter.WriteEndElement();
                    int num9 = checked (num8 + 1);
                  }
                  xmlTextWriter.WriteEndElement();
                }
                if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.LowCarbonTex, "None", false) > 0U & (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.LowCarbonTex, "Dim", false) > 0U)
                {
                  xmlTextWriter.WriteStartElement("SAP:LZC-Energy-Sources");
                  // ISSUE: reference to a compiler-generated field
                  if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.Fuel.Contains("wood"))
                  {
                    // ISSUE: reference to a compiler-generated field
                    int sapTableCode = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.SAPTableCode;
                    if (sapTableCode < 310 || sapTableCode > 315)
                    {
                      xmlTextWriter.WriteStartElement("SAP:LZC-Energy-Source");
                      xmlTextWriter.WriteValue(1);
                      xmlTextWriter.WriteEndElement();
                    }
                  }
                  bool flag1;
                  // ISSUE: reference to a compiler-generated field
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.Boiler2CHPFuel, (string) null, false) == 0)
                  {
                    flag1 = false;
                  }
                  else
                  {
                    // ISSUE: reference to a compiler-generated field
                    if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.Boiler2CHPFuel.Contains("iomass"))
                      flag1 = true;
                  }
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.Fuel.Contains("iomass") | flag1 | SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.Fuel.Contains("iomass"))
                  {
                    // ISSUE: reference to a compiler-generated field
                    int sapTableCode = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.SAPTableCode;
                    if (sapTableCode >= 308 && sapTableCode <= 310)
                    {
                      xmlTextWriter.WriteStartElement("SAP:LZC-Energy-Source");
                      xmlTextWriter.WriteValue(2);
                      xmlTextWriter.WriteEndElement();
                    }
                    else if (sapTableCode == 306 || sapTableCode == 307)
                    {
                      xmlTextWriter.WriteStartElement("SAP:LZC-Energy-Source");
                      xmlTextWriter.WriteValue(3);
                      xmlTextWriter.WriteEndElement();
                    }
                    else
                    {
                      xmlTextWriter.WriteStartElement("SAP:LZC-Energy-Source");
                      xmlTextWriter.WriteValue(3);
                      xmlTextWriter.WriteEndElement();
                    }
                  }
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].SecHeating.Fuel.Contains("wood") & !SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].SecHeating.Fuel.Contains("dual"))
                  {
                    xmlTextWriter.WriteStartElement("SAP:LZC-Energy-Source");
                    xmlTextWriter.WriteValue(4);
                    xmlTextWriter.WriteEndElement();
                  }
                  if (this.exhaust_air)
                  {
                    xmlTextWriter.WriteStartElement("SAP:LZC-Energy-Source");
                    xmlTextWriter.WriteValue(16);
                    xmlTextWriter.WriteEndElement();
                  }
                  if (this.combine_heat)
                  {
                    xmlTextWriter.WriteStartElement("SAP:LZC-Energy-Source");
                    xmlTextWriter.WriteValue(6);
                    xmlTextWriter.WriteEndElement();
                  }
                  if (this.geothermal_heat)
                  {
                    xmlTextWriter.WriteStartElement("SAP:LZC-Energy-Source");
                    xmlTextWriter.WriteValue(5);
                    xmlTextWriter.WriteEndElement();
                  }
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.SGroup, "Micro-cogeneration (micro-CHP)", false) == 0 | SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.SystemRef == 951)
                  {
                    xmlTextWriter.WriteStartElement("SAP:LZC-Energy-Source");
                    xmlTextWriter.WriteValue(15);
                    xmlTextWriter.WriteEndElement();
                  }
                  else
                  {
                    // ISSUE: reference to a compiler-generated field
                    switch (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.SAPTableCode)
                    {
                      case 201:
                      case 202:
                      case 205:
                      case 525:
                        xmlTextWriter.WriteStartElement("SAP:LZC-Energy-Source");
                        xmlTextWriter.WriteValue(7);
                        xmlTextWriter.WriteEndElement();
                        break;
                      case 204:
                      case 207:
                      case 524:
                      case 527:
                        xmlTextWriter.WriteStartElement("SAP:LZC-Energy-Source");
                        xmlTextWriter.WriteValue(9);
                        xmlTextWriter.WriteEndElement();
                        break;
                      case 206:
                      case 526:
                        xmlTextWriter.WriteStartElement("SAP:LZC-Energy-Source");
                        xmlTextWriter.WriteValue(8);
                        xmlTextWriter.WriteEndElement();
                        break;
                      case 307:
                        xmlTextWriter.WriteStartElement("SAP:LZC-Energy-Source");
                        xmlTextWriter.WriteValue(13);
                        xmlTextWriter.WriteEndElement();
                        break;
                      case 310:
                        xmlTextWriter.WriteStartElement("SAP:LZC-Energy-Source");
                        xmlTextWriter.WriteValue(5);
                        xmlTextWriter.WriteEndElement();
                        break;
                      default:
                        bool flag2;
                        if (this.ground_source)
                        {
                          xmlTextWriter.WriteStartElement("SAP:LZC-Energy-Source");
                          xmlTextWriter.WriteValue(7);
                          xmlTextWriter.WriteEndElement();
                          flag2 = true;
                        }
                        if (this.air_source & !flag2)
                        {
                          xmlTextWriter.WriteStartElement("SAP:LZC-Energy-Source");
                          xmlTextWriter.WriteValue(9);
                          xmlTextWriter.WriteEndElement();
                        }
                        // ISSUE: reference to a compiler-generated field
                        if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Renewable.AAEGeneration.Inlcude)
                        {
                          xmlTextWriter.WriteStartElement("SAP:LZC-Energy-Source");
                          xmlTextWriter.WriteValue(14);
                          xmlTextWriter.WriteEndElement();
                          break;
                        }
                        break;
                    }
                  }
                  // ISSUE: reference to a compiler-generated field
                  if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.Solar.Inlcude)
                  {
                    xmlTextWriter.WriteStartElement("SAP:LZC-Energy-Source");
                    xmlTextWriter.WriteValue(10);
                    xmlTextWriter.WriteEndElement();
                  }
                  // ISSUE: reference to a compiler-generated field
                  if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Renewable.Photovoltaic.Inlcude)
                  {
                    xmlTextWriter.WriteStartElement("SAP:LZC-Energy-Source");
                    xmlTextWriter.WriteValue(11);
                    xmlTextWriter.WriteEndElement();
                  }
                  // ISSUE: reference to a compiler-generated field
                  if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Renewable.WindTurbine.Inlcude)
                  {
                    xmlTextWriter.WriteStartElement("SAP:LZC-Energy-Source");
                    xmlTextWriter.WriteValue(12);
                    xmlTextWriter.WriteEndElement();
                  }
                  // ISSUE: reference to a compiler-generated field
                  if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.SAPTableCode == 309)
                  {
                    xmlTextWriter.WriteStartElement("SAP:LZC-Energy-Source");
                    xmlTextWriter.WriteValue(13);
                    xmlTextWriter.WriteEndElement();
                  }
                  xmlTextWriter.WriteEndElement();
                }
                // ISSUE: reference to a compiler-generated field
                if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Address.Country, "Northern Ireland", false) > 0U)
                {
                  xmlTextWriter.WriteStartElement("SAP:Renewable-Heat-Incentive");
                  Calc2012 calc2012 = new Calc2012();
                  SAP_Module.Dwelling dwelling1 = new SAP_Module.Dwelling();
                  // ISSUE: reference to a compiler-generated field
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Status, "Existing dwelling (SAP)", false) == 0)
                  {
                    xmlTextWriter.WriteStartElement("SAP:RHI-Existing-Dwelling");
                    xmlTextWriter.WriteStartElement("SAP:Space-Heating-Existing-Dwelling");
                    // ISSUE: reference to a compiler-generated field
                    SAP_Module.Dwelling dwelling2 = Functions.CopyDwelling(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House]);
                    dwelling2.Water.Solar.Inlcude = false;
                    if (SAP_Module.Calculation2012.Calculation.Fuel_costs_10b.Box340a == 0.0)
                      calc2012.IsRHICalc = true;
                    calc2012.Dwelling = dwelling2;
                    xmlTextWriter.WriteValue(Microsoft.VisualBasic.Strings.Format((object) Math.Round(calc2012.Calculation.Space_heating_requirement.Box98, 0), "####"));
                    xmlTextWriter.WriteEndElement();
                  }
                  else
                  {
                    xmlTextWriter.WriteStartElement("SAP:RHI-New-Dwelling");
                    xmlTextWriter.WriteStartElement("SAP:Space-Heating");
                    // ISSUE: reference to a compiler-generated field
                    SAP_Module.Dwelling dwelling3 = Functions.CopyDwelling(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House]);
                    dwelling3.Water.Solar.Inlcude = false;
                    if (SAP_Module.Calculation2012.Calculation.Fuel_costs_10b.Box340a == 0.0)
                      calc2012.IsRHICalc = true;
                    calc2012.Dwelling = dwelling3;
                    xmlTextWriter.WriteValue(Microsoft.VisualBasic.Strings.Format((object) Math.Round(calc2012.Calculation.Space_heating_requirement.Box98, 0), "####"));
                    xmlTextWriter.WriteEndElement();
                  }
                  xmlTextWriter.WriteStartElement("SAP:Water-Heating");
                  xmlTextWriter.WriteValue(Microsoft.VisualBasic.Strings.Format((object) Math.Round(calc2012.Calculation.Water_heating.Box64 + calc2012.Calculation.Water_heating.Box64Imm, 0), "####"));
                  xmlTextWriter.WriteEndElement();
                  xmlTextWriter.WriteEndElement();
                  xmlTextWriter.WriteEndElement();
                }
                xmlTextWriter.WriteEndElement();
                xmlTextWriter.WriteStartElement("SAP:SAP09-Data");
                xmlTextWriter.WriteStartElement("SAP:Data-Type");
                // ISSUE: reference to a compiler-generated field
                string status = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Status;
                // ISSUE: reference to a compiler-generated method
                switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(status))
                {
                  case 474629829:
                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(status, "New dwelling design stage", false) == 0)
                    {
                      xmlTextWriter.WriteValue("1");
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
                      goto label_555;
                    else
                      goto default;
                  case 2887295594:
                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(status, "new dwelling created by change of use", false) == 0)
                      goto label_555;
                    else
                      goto default;
                  case 3242632573:
                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(status, "New dwelling as built", false) == 0)
                    {
                      xmlTextWriter.WriteValue("2");
                      goto default;
                    }
                    else
                      goto default;
                  case 3363671541:
                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(status, "other", false) == 0)
                    {
                      xmlTextWriter.WriteValue("6");
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
                      xmlTextWriter.WriteValue("5");
                      goto default;
                    }
                    else
                      goto default;
                  default:
label_558:
                    xmlTextWriter.WriteEndElement();
                    xmlTextWriter.WriteStartElement("SAP:Schema-Version");
                    // ISSUE: reference to a compiler-generated field
                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Address.Country, "Northern Ireland", false) == 0)
                      xmlTextWriter.WriteValue("LIG-NI-17.0");
                    else
                      xmlTextWriter.WriteValue("LIG-16.1");
                    xmlTextWriter.WriteEndElement();
                    xmlTextWriter.WriteStartElement("SAP:SAP-Property-Details");
                    xmlTextWriter.WriteStartElement("SAP:Property-Type");
                    // ISSUE: reference to a compiler-generated field
                    string propertyType2 = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].PropertyType;
                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(propertyType2, nameof (House), false) != 0)
                    {
                      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(propertyType2, "Bungalow", false) != 0)
                      {
                        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(propertyType2, "Flat", false) != 0)
                        {
                          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(propertyType2, "Maisonette", false) == 0)
                            xmlTextWriter.WriteValue(3);
                          else
                            xmlTextWriter.WriteValue(0);
                        }
                        else
                          xmlTextWriter.WriteValue(2);
                      }
                      else
                        xmlTextWriter.WriteValue(1);
                    }
                    else
                      xmlTextWriter.WriteValue(0);
                    xmlTextWriter.WriteEndElement();
                    xmlTextWriter.WriteStartElement("SAP:Built-Form");
                    // ISSUE: reference to a compiler-generated field
                    string Left1 = Microsoft.VisualBasic.Strings.UCase(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].BuildForm);
                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left1, Microsoft.VisualBasic.Strings.UCase("Detached"), false) == 0)
                      xmlTextWriter.WriteValue("1");
                    else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left1, Microsoft.VisualBasic.Strings.UCase("Semi-Detached"), false) == 0)
                      xmlTextWriter.WriteValue("2");
                    else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left1, Microsoft.VisualBasic.Strings.UCase("Mid-Terrace"), false) == 0)
                      xmlTextWriter.WriteValue("4");
                    else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left1, Microsoft.VisualBasic.Strings.UCase("End-Terrace"), false) == 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left1, Microsoft.VisualBasic.Strings.UCase("End-terrace"), false) == 0)
                      xmlTextWriter.WriteValue("3");
                    else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left1, Microsoft.VisualBasic.Strings.UCase("Enclosed End-Terrace"), false) == 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left1, Microsoft.VisualBasic.Strings.UCase("Enclosed end"), false) == 0)
                      xmlTextWriter.WriteValue("5");
                    else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left1, Microsoft.VisualBasic.Strings.UCase("Enclosed Mid-Terrace"), false) == 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left1, Microsoft.VisualBasic.Strings.UCase("Enclosed mid"), false) == 0)
                      xmlTextWriter.WriteValue("6");
                    else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left1, Microsoft.VisualBasic.Strings.UCase("Linked Detached"), false) == 0)
                      xmlTextWriter.WriteValue("7");
                    xmlTextWriter.WriteEndElement();
                    xmlTextWriter.WriteStartElement("SAP:Living-Area");
                    // ISSUE: reference to a compiler-generated field
                    xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].LivingArea);
                    xmlTextWriter.WriteEndElement();
                    xmlTextWriter.WriteStartElement("SAP:Orientation");
                    // ISSUE: reference to a compiler-generated field
                    string orientation1 = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Orientation;
                    // ISSUE: reference to a compiler-generated method
                    switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(orientation1))
                    {
                      case 105265260:
                        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation1, "Unspecified", false) == 0)
                        {
                          xmlTextWriter.WriteValue("0");
                          break;
                        }
                        break;
                      case 1128440633:
                        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation1, "North East", false) == 0)
                        {
                          xmlTextWriter.WriteValue("2");
                          break;
                        }
                        break;
                      case 1409318971:
                        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation1, "North West", false) == 0)
                        {
                          xmlTextWriter.WriteValue("8");
                          break;
                        }
                        break;
                      case 1731397980:
                        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation1, "East", false) == 0)
                        {
                          xmlTextWriter.WriteValue("3");
                          break;
                        }
                        break;
                      case 1734234020:
                        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation1, "North", false) == 0)
                        {
                          xmlTextWriter.WriteValue("1");
                          break;
                        }
                        break;
                      case 1796576718:
                        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation1, "West", false) == 0)
                        {
                          xmlTextWriter.WriteValue("7");
                          break;
                        }
                        break;
                      case 2417407149:
                        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation1, "South West", false) == 0)
                        {
                          xmlTextWriter.WriteValue("6");
                          break;
                        }
                        break;
                      case 2853841879:
                        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation1, "South East", false) == 0)
                        {
                          xmlTextWriter.WriteValue("4");
                          break;
                        }
                        break;
                      case 3017973530:
                        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation1, "South", false) == 0)
                        {
                          xmlTextWriter.WriteValue("5");
                          break;
                        }
                        break;
                    }
                    xmlTextWriter.WriteEndElement();
                    xmlTextWriter.WriteStartElement("SAP:Conservatory-Type");
                    // ISSUE: reference to a compiler-generated field
                    string Left2 = Microsoft.VisualBasic.Strings.UCase(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Conservatory);
                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left2, Microsoft.VisualBasic.Strings.UCase("No conservatory"), false) == 0)
                      xmlTextWriter.WriteValue("1");
                    else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left2, Microsoft.VisualBasic.Strings.UCase("Separated unheated conservatory"), false) == 0)
                      xmlTextWriter.WriteValue("2");
                    else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left2, Microsoft.VisualBasic.Strings.UCase("Separated heated conservatory"), false) == 0)
                      xmlTextWriter.WriteValue("3");
                    else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left2, Microsoft.VisualBasic.Strings.UCase("Not separated"), false) == 0)
                      xmlTextWriter.WriteValue("4");
                    xmlTextWriter.WriteEndElement();
                    // ISSUE: reference to a compiler-generated field
                    if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Renewable.Special.Include)
                    {
                      xmlTextWriter.WriteStartElement("SAP:SAP-Special-Features");
                      // ISSUE: reference to a compiler-generated field
                      int num10 = checked (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Renewable.Special.Special.Length - 1);
                      int index = 0;
                      while (index <= num10)
                      {
                        xmlTextWriter.WriteStartElement("SAP:SAP-Special-Feature");
                        xmlTextWriter.WriteStartElement("SAP:Description");
                        // ISSUE: reference to a compiler-generated field
                        xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Renewable.Special.Special[index].Description);
                        xmlTextWriter.WriteEndElement();
                        xmlTextWriter.WriteStartElement("SAP:Energy-Saved-Or-Generated");
                        // ISSUE: reference to a compiler-generated field
                        xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Renewable.Special.Special[index].EnergySaved);
                        xmlTextWriter.WriteEndElement();
                        xmlTextWriter.WriteStartElement("SAP:Saved-Or-Generated-Fuel");
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        xmlTextWriter.WriteValue(this.FuelCheck(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Renewable.Special.Special[index].FuelSaved, closure850_2.\u0024VB\u0024Local_House));
                        xmlTextWriter.WriteEndElement();
                        xmlTextWriter.WriteStartElement("SAP:Energy-Used");
                        // ISSUE: reference to a compiler-generated field
                        xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Renewable.Special.Special[index].EnergyUsed);
                        xmlTextWriter.WriteEndElement();
                        // ISSUE: reference to a compiler-generated field
                        if ((double) SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Renewable.Special.Special[index].EnergyUsed > 0.0)
                        {
                          xmlTextWriter.WriteStartElement("SAP:Energy-Used-Fuel");
                          // ISSUE: reference to a compiler-generated field
                          // ISSUE: reference to a compiler-generated field
                          xmlTextWriter.WriteValue(this.FuelCheck(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Renewable.Special.Special[index].FuelUsed, closure850_2.\u0024VB\u0024Local_House));
                          xmlTextWriter.WriteEndElement();
                        }
                        // ISSUE: reference to a compiler-generated field
                        if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Renewable.Special.Special[index].IncludeMonthly)
                        {
                          xmlTextWriter.WriteStartElement("SAP:Air-Change-Rates");
                          xmlTextWriter.WriteStartElement("SAP:Air-Change-Rate");
                          xmlTextWriter.WriteStartElement("SAP:Air-Change-Rate-Month");
                          xmlTextWriter.WriteValue("Jan");
                          xmlTextWriter.WriteEndElement();
                          xmlTextWriter.WriteStartElement("SAP:Air-Change-Rate-Value");
                          // ISSUE: reference to a compiler-generated field
                          xmlTextWriter.WriteValue(Math.Round((double) SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Renewable.Special.Special[index].M1, 2));
                          xmlTextWriter.WriteEndElement();
                          xmlTextWriter.WriteEndElement();
                          xmlTextWriter.WriteStartElement("SAP:Air-Change-Rate");
                          xmlTextWriter.WriteStartElement("SAP:Air-Change-Rate-Month");
                          xmlTextWriter.WriteValue("Feb");
                          xmlTextWriter.WriteEndElement();
                          xmlTextWriter.WriteStartElement("SAP:Air-Change-Rate-Value");
                          // ISSUE: reference to a compiler-generated field
                          xmlTextWriter.WriteValue(Math.Round((double) SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Renewable.Special.Special[index].M2, 2));
                          xmlTextWriter.WriteEndElement();
                          xmlTextWriter.WriteEndElement();
                          xmlTextWriter.WriteStartElement("SAP:Air-Change-Rate");
                          xmlTextWriter.WriteStartElement("SAP:Air-Change-Rate-Month");
                          xmlTextWriter.WriteValue("Mar");
                          xmlTextWriter.WriteEndElement();
                          xmlTextWriter.WriteStartElement("SAP:Air-Change-Rate-Value");
                          // ISSUE: reference to a compiler-generated field
                          xmlTextWriter.WriteValue(Math.Round((double) SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Renewable.Special.Special[index].M3, 2));
                          xmlTextWriter.WriteEndElement();
                          xmlTextWriter.WriteEndElement();
                          xmlTextWriter.WriteStartElement("SAP:Air-Change-Rate");
                          xmlTextWriter.WriteStartElement("SAP:Air-Change-Rate-Month");
                          xmlTextWriter.WriteValue("Apr");
                          xmlTextWriter.WriteEndElement();
                          xmlTextWriter.WriteStartElement("SAP:Air-Change-Rate-Value");
                          // ISSUE: reference to a compiler-generated field
                          xmlTextWriter.WriteValue(Math.Round((double) SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Renewable.Special.Special[index].M4, 2));
                          xmlTextWriter.WriteEndElement();
                          xmlTextWriter.WriteEndElement();
                          xmlTextWriter.WriteStartElement("SAP:Air-Change-Rate");
                          xmlTextWriter.WriteStartElement("SAP:Air-Change-Rate-Month");
                          xmlTextWriter.WriteValue("May");
                          xmlTextWriter.WriteEndElement();
                          xmlTextWriter.WriteStartElement("SAP:Air-Change-Rate-Value");
                          // ISSUE: reference to a compiler-generated field
                          xmlTextWriter.WriteValue(Math.Round((double) SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Renewable.Special.Special[index].M5, 2));
                          xmlTextWriter.WriteEndElement();
                          xmlTextWriter.WriteEndElement();
                          xmlTextWriter.WriteStartElement("SAP:Air-Change-Rate");
                          xmlTextWriter.WriteStartElement("SAP:Air-Change-Rate-Month");
                          xmlTextWriter.WriteValue("Jun");
                          xmlTextWriter.WriteEndElement();
                          xmlTextWriter.WriteStartElement("SAP:Air-Change-Rate-Value");
                          // ISSUE: reference to a compiler-generated field
                          xmlTextWriter.WriteValue(Math.Round((double) SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Renewable.Special.Special[index].M6, 2));
                          xmlTextWriter.WriteEndElement();
                          xmlTextWriter.WriteEndElement();
                          xmlTextWriter.WriteStartElement("SAP:Air-Change-Rate");
                          xmlTextWriter.WriteStartElement("SAP:Air-Change-Rate-Month");
                          xmlTextWriter.WriteValue("Jul");
                          xmlTextWriter.WriteEndElement();
                          xmlTextWriter.WriteStartElement("SAP:Air-Change-Rate-Value");
                          // ISSUE: reference to a compiler-generated field
                          xmlTextWriter.WriteValue(Math.Round((double) SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Renewable.Special.Special[index].M7, 2));
                          xmlTextWriter.WriteEndElement();
                          xmlTextWriter.WriteEndElement();
                          xmlTextWriter.WriteStartElement("SAP:Air-Change-Rate");
                          xmlTextWriter.WriteStartElement("SAP:Air-Change-Rate-Month");
                          xmlTextWriter.WriteValue("Aug");
                          xmlTextWriter.WriteEndElement();
                          xmlTextWriter.WriteStartElement("SAP:Air-Change-Rate-Value");
                          // ISSUE: reference to a compiler-generated field
                          xmlTextWriter.WriteValue(Math.Round((double) SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Renewable.Special.Special[index].M8, 2));
                          xmlTextWriter.WriteEndElement();
                          xmlTextWriter.WriteEndElement();
                          xmlTextWriter.WriteStartElement("SAP:Air-Change-Rate");
                          xmlTextWriter.WriteStartElement("SAP:Air-Change-Rate-Month");
                          xmlTextWriter.WriteValue("Sep");
                          xmlTextWriter.WriteEndElement();
                          xmlTextWriter.WriteStartElement("SAP:Air-Change-Rate-Value");
                          // ISSUE: reference to a compiler-generated field
                          xmlTextWriter.WriteValue(Math.Round((double) SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Renewable.Special.Special[index].M9, 2));
                          xmlTextWriter.WriteEndElement();
                          xmlTextWriter.WriteEndElement();
                          xmlTextWriter.WriteStartElement("SAP:Air-Change-Rate");
                          xmlTextWriter.WriteStartElement("SAP:Air-Change-Rate-Month");
                          xmlTextWriter.WriteValue("Oct");
                          xmlTextWriter.WriteEndElement();
                          xmlTextWriter.WriteStartElement("SAP:Air-Change-Rate-Value");
                          // ISSUE: reference to a compiler-generated field
                          xmlTextWriter.WriteValue(Math.Round((double) SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Renewable.Special.Special[index].M10, 2));
                          xmlTextWriter.WriteEndElement();
                          xmlTextWriter.WriteEndElement();
                          xmlTextWriter.WriteStartElement("SAP:Air-Change-Rate");
                          xmlTextWriter.WriteStartElement("SAP:Air-Change-Rate-Month");
                          xmlTextWriter.WriteValue("Nov");
                          xmlTextWriter.WriteEndElement();
                          xmlTextWriter.WriteStartElement("SAP:Air-Change-Rate-Value");
                          // ISSUE: reference to a compiler-generated field
                          xmlTextWriter.WriteValue(Math.Round((double) SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Renewable.Special.Special[index].M11, 2));
                          xmlTextWriter.WriteEndElement();
                          xmlTextWriter.WriteEndElement();
                          xmlTextWriter.WriteStartElement("SAP:Air-Change-Rate");
                          xmlTextWriter.WriteStartElement("SAP:Air-Change-Rate-Month");
                          xmlTextWriter.WriteValue("Dec");
                          xmlTextWriter.WriteEndElement();
                          xmlTextWriter.WriteStartElement("SAP:Air-Change-Rate-Value");
                          // ISSUE: reference to a compiler-generated field
                          xmlTextWriter.WriteValue(Math.Round((double) SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Renewable.Special.Special[index].M12, 2));
                          xmlTextWriter.WriteEndElement();
                          xmlTextWriter.WriteEndElement();
                          xmlTextWriter.WriteEndElement();
                        }
                        xmlTextWriter.WriteEndElement();
                        checked { ++index; }
                      }
                      xmlTextWriter.WriteEndElement();
                    }
                    // ISSUE: reference to a compiler-generated field
                    if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].LessThan125Litre)
                    {
                      xmlTextWriter.WriteStartElement("SAP:Design-Water-Use");
                      xmlTextWriter.WriteValue(1);
                      xmlTextWriter.WriteEndElement();
                    }
                    xmlTextWriter.WriteStartElement("SAP:Is-In-Smoke-Control-Area");
                    // ISSUE: reference to a compiler-generated field
                    string smokeArea = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].SmokeArea;
                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(smokeArea, "No", false) != 0)
                    {
                      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(smokeArea, "Yes", false) != 0)
                      {
                        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(smokeArea, "Unknown", false) == 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(smokeArea, "unknown", false) == 0)
                          xmlTextWriter.WriteValue("unknown");
                      }
                      else
                        xmlTextWriter.WriteValue("true");
                    }
                    else
                      xmlTextWriter.WriteValue("false");
                    xmlTextWriter.WriteEndElement();
                    bool flag3;
                    if (flag3)
                    {
                      xmlTextWriter.WriteStartElement("SAP:Additional-Allowable-Electricity-Generation");
                      // ISSUE: reference to a compiler-generated field
                      xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Renewable.AAEGeneration.EGenerated);
                      xmlTextWriter.WriteEndElement();
                    }
                    // ISSUE: reference to a compiler-generated field
                    if (!string.IsNullOrEmpty(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].FlatType))
                    {
                      xmlTextWriter.WriteStartElement("SAP:SAP-Flat-Details");
                      xmlTextWriter.WriteStartElement("SAP:Level");
                      // ISSUE: reference to a compiler-generated field
                      string flatType = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].FlatType;
                      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(flatType, "Ground floor", false) != 0)
                      {
                        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(flatType, "Mid floor", false) != 0)
                        {
                          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(flatType, "Top floor", false) == 0)
                            xmlTextWriter.WriteValue("3");
                          else
                            xmlTextWriter.WriteValue("0");
                        }
                        else
                          xmlTextWriter.WriteValue("2");
                      }
                      else
                        xmlTextWriter.WriteValue("1");
                      xmlTextWriter.WriteEndElement();
                      xmlTextWriter.WriteEndElement();
                    }
                    // ISSUE: reference to a compiler-generated field
                    this.DefineOpenings(closure850_2.\u0024VB\u0024Local_House);
                    xmlTextWriter.WriteStartElement("SAP:SAP-Opening-Types");
                    int num11 = checked (this.OpeningTypes.Length - 1);
                    int index1 = 0;
                    while (index1 <= num11)
                    {
                      xmlTextWriter.WriteStartElement("SAP:SAP-Opening-Type");
                      xmlTextWriter.WriteStartElement("SAP:Name");
                      xmlTextWriter.WriteValue(this.OpeningTypes[index1].Name);
                      xmlTextWriter.WriteEndElement();
                      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.OpeningTypes[index1].DSource, "BFRC", false) == 0 & !this.OpeningTypes[index1].Name.Contains("Door"))
                      {
                        xmlTextWriter.WriteStartElement("SAP:Description");
                        xmlTextWriter.WriteValue("BFRC data");
                        xmlTextWriter.WriteEndElement();
                      }
                      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.OpeningTypes[index1].DSource, "Manufacturer", false) == 0)
                      {
                        xmlTextWriter.WriteStartElement("SAP:Description");
                        xmlTextWriter.WriteValue("Data from Manufacturer");
                        xmlTextWriter.WriteEndElement();
                      }
                      xmlTextWriter.WriteStartElement("SAP:Data-Source");
                      string dsource = this.OpeningTypes[index1].DSource;
                      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(dsource, "SAP 2005", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(dsource, "SAP 2009", false) != 0)
                      {
                        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(dsource, "Manufacturer", false) != 0)
                        {
                          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(dsource, "BFRC", false) == 0)
                            xmlTextWriter.WriteValue(4);
                        }
                        else
                          xmlTextWriter.WriteValue(2);
                      }
                      else
                        xmlTextWriter.WriteValue(3);
                      xmlTextWriter.WriteEndElement();
                      xmlTextWriter.WriteStartElement("SAP:Type");
                      if (this.OpeningTypes[index1].Name.Contains("Door"))
                      {
                        string type = this.OpeningTypes[index1].Type;
                        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(type, "Solid", false) != 0)
                        {
                          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(type, "Half glazed", false) != 0)
                          {
                            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(type, "Fully glazed", false) == 0)
                              xmlTextWriter.WriteValue(3);
                          }
                          else
                            xmlTextWriter.WriteValue(2);
                        }
                        else
                          xmlTextWriter.WriteValue(1);
                      }
                      else
                        xmlTextWriter.WriteValue(this.OpeningTypes[index1].Type);
                      xmlTextWriter.WriteEndElement();
                      xmlTextWriter.WriteStartElement("SAP:Glazing-Type");
                      string glazingType = this.OpeningTypes[index1].GlazingType;
                      // ISSUE: reference to a compiler-generated method
                      switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(glazingType))
                      {
                        case 68605829:
                          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(glazingType, "triple-glazed, argon filled (low-E, En = 0.2, hard coat)", false) == 0)
                            goto label_690;
                          else
                            goto default;
                        case 763250309:
                          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(glazingType, "double-glazed, air filled (low-E, En = 0.2, hard coat)", false) == 0)
                            goto label_685;
                          else
                            goto default;
                        case 1070237142:
                          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(glazingType, "triple-glazed, argon filled", false) == 0)
                            goto label_689;
                          else
                            goto default;
                        case 1119002789:
                          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(glazingType, "double-glazed, argon filled", false) == 0)
                            break;
                          goto default;
                        case 1129292894:
                          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(glazingType, "triple-glazed, air filled (low-E, En = 0.15, hard coat)", false) == 0)
                            goto label_691;
                          else
                            goto default;
                        case 1508940614:
                          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(glazingType, "double-glazed, argon filled (low-E, En = 0.15, hard coat)", false) == 0)
                            goto label_686;
                          else
                            goto default;
                        case 1617436365:
                          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(glazingType, "triple-glazed, argon filled (low-E, En = 0.1, soft coat)", false) == 0)
                            goto label_692;
                          else
                            goto default;
                        case 1917834200:
                          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(glazingType, "double-glazed, argon filled (low-E, En = 0.1, soft coat)", false) == 0)
                            goto label_687;
                          else
                            goto default;
                        case 2282570948:
                          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(glazingType, "triple-glazed, air filled (low-E, En = 0.2, hard coat)", false) == 0)
                            goto label_690;
                          else
                            goto default;
                        case 2312080845:
                          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(glazingType, "double-glazed, air filled (low-E, En = 0.1, soft coat)", false) == 0)
                            goto label_687;
                          else
                            goto default;
                        case 2413948722:
                          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(glazingType, "double-glazed, argon filled (low-E, En = 0.05, soft coat)", false) == 0)
                            goto label_688;
                          else
                            goto default;
                        case 2482092156:
                          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(glazingType, "double-glazed, argon filled (low-E, En = 0.2, hard coat)", false) == 0)
                            goto label_685;
                          else
                            goto default;
                        case 2498216925:
                          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(glazingType, "triple-glazed, air filled", false) == 0)
                            goto label_689;
                          else
                            goto default;
                        case 2915735968:
                          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(glazingType, "triple-glazed, air filled (low-E, En = 0.1, soft coat)", false) == 0)
                            goto label_692;
                          else
                            goto default;
                        case 3074690985:
                          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(glazingType, "triple-glazed, argon filled (low-E, En = 0.05, soft coat)", false) == 0)
                            goto label_693;
                          else
                            goto default;
                        case 3361248225:
                          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(glazingType, "triple-glazed, argon filled (low-E, En = 0.15, hard coat)", false) == 0)
                            goto label_691;
                          else
                            goto default;
                        case 3689514233:
                          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(glazingType, "Single-glazed", false) == 0)
                          {
                            xmlTextWriter.WriteValue("2");
                            goto label_695;
                          }
                          else
                            goto default;
                        case 3838377526:
                          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(glazingType, "double-glazed", false) == 0)
                            break;
                          goto default;
                        case 3843542185:
                          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(glazingType, "double-glazed, air filled (low-E, En = 0.05, soft coat)", false) == 0)
                            goto label_688;
                          else
                            goto default;
                        case 4014901974:
                          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(glazingType, "double-glazed, air filled", false) == 0)
                            break;
                          goto default;
                        case 4130099425:
                          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(glazingType, "double-glazed, air filled (low-E, En = 0.15, hard coat)", false) == 0)
                            goto label_686;
                          else
                            goto default;
                        case 4251481834:
                          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(glazingType, "triple-glazed, air filled (low-E, En = 0.05, soft coat)", false) == 0)
                            goto label_693;
                          else
                            goto default;
                        case 4255679661:
                          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(glazingType, "Secondary glazing", false) == 0)
                          {
                            xmlTextWriter.WriteValue("13");
                            goto label_695;
                          }
                          else
                            goto default;
                        default:
                          xmlTextWriter.WriteValue("1");
                          goto label_695;
                      }
                      xmlTextWriter.WriteValue("3");
                      goto label_695;
label_685:
                      xmlTextWriter.WriteValue("4");
                      goto label_695;
label_686:
                      xmlTextWriter.WriteValue("5");
                      goto label_695;
label_687:
                      xmlTextWriter.WriteValue("6");
                      goto label_695;
label_688:
                      xmlTextWriter.WriteValue("7");
                      goto label_695;
label_689:
                      xmlTextWriter.WriteValue("8");
                      goto label_695;
label_690:
                      xmlTextWriter.WriteValue("9");
                      goto label_695;
label_691:
                      xmlTextWriter.WriteValue("10");
                      goto label_695;
label_692:
                      xmlTextWriter.WriteValue("11");
                      goto label_695;
label_693:
                      xmlTextWriter.WriteValue("12");
label_695:
                      xmlTextWriter.WriteEndElement();
                      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.OpeningTypes[index1].DSource, "SAP 2005", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.OpeningTypes[index1].DSource, "SAP 2009", false) == 0 && (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.OpeningTypes[index1].GlazingGap, "", false) > 0U)
                      {
                        xmlTextWriter.WriteStartElement("SAP:Glazing-Gap");
                        string glazingGap = this.OpeningTypes[index1].GlazingGap;
                        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(glazingGap, "6mm", false) != 0)
                        {
                          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(glazingGap, "12mm", false) != 0)
                          {
                            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(glazingGap, "16mm or more ", false) == 0)
                              xmlTextWriter.WriteValue("3");
                          }
                          else
                            xmlTextWriter.WriteValue("2");
                        }
                        else
                          xmlTextWriter.WriteValue("1");
                        xmlTextWriter.WriteEndElement();
                        xmlTextWriter.WriteStartElement("SAP:IsArgonFilled");
                        xmlTextWriter.WriteValue(this.OpeningTypes[index1].Argon);
                        xmlTextWriter.WriteEndElement();
                      }
                      if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.OpeningTypes[index1].Type, "Solid", false) > 0U & (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.OpeningTypes[index1].Type, "Fully glazed", false) > 0U && (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.OpeningTypes[index1].FrameType, "", false) > 0U)
                      {
                        xmlTextWriter.WriteStartElement("SAP:Frame-Type");
                        string frameType = this.OpeningTypes[index1].FrameType;
                        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(frameType, "Wood", false) != 0)
                        {
                          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(frameType, "Metal", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(frameType, "Metal, thermal break", false) != 0)
                          {
                            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(frameType, "PVC-U", false) == 0)
                              xmlTextWriter.WriteValue("2");
                          }
                          else
                          {
                            string metalFrameType = this.OpeningTypes[index1].MetalFrameType;
                            // ISSUE: reference to a compiler-generated method
                            switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(metalFrameType))
                            {
                              case 333502473:
                                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(metalFrameType, "8mm", false) == 0)
                                {
                                  xmlTextWriter.WriteValue("5");
                                  goto label_723;
                                }
                                else
                                  goto label_723;
                              case 473775746:
                                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(metalFrameType, "No thermal break", false) == 0)
                                  break;
                                goto label_723;
                              case 536439224:
                                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(metalFrameType, "12mm", false) == 0)
                                {
                                  xmlTextWriter.WriteValue("6");
                                  goto label_723;
                                }
                                else
                                  goto label_723;
                              case 2166136261:
                                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(metalFrameType, "", false) == 0)
                                  break;
                                goto label_723;
                              case 2186527966:
                                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(metalFrameType, "32mm", false) == 0)
                                {
                                  xmlTextWriter.WriteValue("8");
                                  goto label_723;
                                }
                                else
                                  goto label_723;
                              case 2560045537:
                                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(metalFrameType, "20mm", false) == 0)
                                {
                                  xmlTextWriter.WriteValue("7");
                                  goto label_723;
                                }
                                else
                                  goto label_723;
                              case 3632641573:
                                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(metalFrameType, "4mm", false) == 0)
                                {
                                  xmlTextWriter.WriteValue("4");
                                  goto label_723;
                                }
                                else
                                  goto label_723;
                              default:
                                goto label_723;
                            }
                            xmlTextWriter.WriteValue("3");
                          }
                        }
                        else
                          xmlTextWriter.WriteValue("1");
label_723:
                        xmlTextWriter.WriteEndElement();
                      }
                      if (!this.OpeningTypes[index1].Name.Contains("Door"))
                      {
                        xmlTextWriter.WriteStartElement("SAP:Solar-Transmittance");
                        xmlTextWriter.WriteValue(this.OpeningTypes[index1].SolarT);
                        xmlTextWriter.WriteEndElement();
                      }
                      if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.OpeningTypes[index1].DSource, "BFRC", false) > 0U && (double) this.OpeningTypes[index1].FrameFactor != 0.0)
                      {
                        xmlTextWriter.WriteStartElement("SAP:Frame-Factor");
                        xmlTextWriter.WriteValue(this.OpeningTypes[index1].FrameFactor);
                        xmlTextWriter.WriteEndElement();
                      }
                      xmlTextWriter.WriteStartElement("SAP:U-Value");
                      xmlTextWriter.WriteValue(this.OpeningTypes[index1].U_Value);
                      xmlTextWriter.WriteEndElement();
                      xmlTextWriter.WriteEndElement();
                      checked { ++index1; }
                    }
                    xmlTextWriter.WriteEndElement();
                    xmlTextWriter.WriteStartElement("SAP:SAP-Building-Parts");
                    xmlTextWriter.WriteStartElement("SAP:SAP-Building-Part");
                    xmlTextWriter.WriteStartElement("SAP:Building-Part-Number");
                    xmlTextWriter.WriteValue("1");
                    xmlTextWriter.WriteEndElement();
                    xmlTextWriter.WriteStartElement("SAP:Identifier");
                    xmlTextWriter.WriteValue("Main Dwelling");
                    xmlTextWriter.WriteEndElement();
                    xmlTextWriter.WriteStartElement("SAP:Construction-Year");
                    // ISSUE: reference to a compiler-generated field
                    xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].YearBuilt);
                    xmlTextWriter.WriteEndElement();
                    xmlTextWriter.WriteStartElement("SAP:Overshading");
                    // ISSUE: reference to a compiler-generated field
                    string overshading = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Overshading;
                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(overshading, "Heavy", false) != 0)
                    {
                      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(overshading, "More than average", false) != 0)
                      {
                        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(overshading, "Average or unknown", false) != 0)
                        {
                          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(overshading, "Very Little", false) == 0)
                            xmlTextWriter.WriteValue(1);
                        }
                        else
                          xmlTextWriter.WriteValue(2);
                      }
                      else
                        xmlTextWriter.WriteValue(3);
                    }
                    else
                      xmlTextWriter.WriteValue(4);
                    xmlTextWriter.WriteEndElement();
                    xmlTextWriter.WriteStartElement("SAP:SAP-Openings");
                    int num12 = 0;
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].PropertyType, "Flat", false) == 0 && (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].FlatType, "Ground floor", false) > 0U)
                      num12 = 1;
                    // ISSUE: reference to a compiler-generated field
                    int num13 = checked (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].NoofDoors - 1);
                    int index2 = 0;
                    while (index2 <= num13)
                    {
                      // ISSUE: reference to a compiler-generated field
                      if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Doors[index2].Count > 1)
                      {
                        // ISSUE: reference to a compiler-generated field
                        int num14 = checked (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Doors[index2].Count - 1);
                        int num15 = 0;
                        while (num15 <= num14)
                        {
                          checked { ++num12; }
                          xmlTextWriter.WriteStartElement("SAP:SAP-Opening");
                          xmlTextWriter.WriteStartElement("SAP:Name");
                          xmlTextWriter.WriteValue(num12);
                          xmlTextWriter.WriteEndElement();
                          xmlTextWriter.WriteStartElement("SAP:Type");
                          // ISSUE: reference to a compiler-generated field
                          xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Doors[index2].OpeningType);
                          xmlTextWriter.WriteEndElement();
                          xmlTextWriter.WriteStartElement("SAP:Location");
                          // ISSUE: reference to a compiler-generated field
                          xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Doors[index2].Location);
                          xmlTextWriter.WriteEndElement();
                          xmlTextWriter.WriteStartElement("SAP:Orientation");
                          // ISSUE: reference to a compiler-generated field
                          string orientation2 = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Doors[index2].Orientation;
                          // ISSUE: reference to a compiler-generated method
                          switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(orientation2))
                          {
                            case 1128440633:
                              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation2, "North East", false) == 0)
                              {
                                xmlTextWriter.WriteValue("2");
                                break;
                              }
                              goto default;
                            case 1409318971:
                              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation2, "North West", false) == 0)
                              {
                                xmlTextWriter.WriteValue("8");
                                break;
                              }
                              goto default;
                            case 1731397980:
                              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation2, "East", false) == 0)
                              {
                                xmlTextWriter.WriteValue("3");
                                break;
                              }
                              goto default;
                            case 1734234020:
                              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation2, "North", false) == 0)
                              {
                                xmlTextWriter.WriteValue("1");
                                break;
                              }
                              goto default;
                            case 1796576718:
                              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation2, "West", false) == 0)
                              {
                                xmlTextWriter.WriteValue("7");
                                break;
                              }
                              goto default;
                            case 2417407149:
                              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation2, "South West", false) == 0)
                              {
                                xmlTextWriter.WriteValue("6");
                                break;
                              }
                              goto default;
                            case 2853841879:
                              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation2, "South East", false) == 0)
                              {
                                xmlTextWriter.WriteValue("4");
                                break;
                              }
                              goto default;
                            case 3017973530:
                              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation2, "South", false) == 0)
                              {
                                xmlTextWriter.WriteValue("5");
                                break;
                              }
                              goto default;
                            default:
                              xmlTextWriter.WriteValue("0");
                              break;
                          }
                          xmlTextWriter.WriteEndElement();
                          xmlTextWriter.WriteStartElement("SAP:Width");
                          // ISSUE: reference to a compiler-generated field
                          xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Doors[index2].Width / 1000f);
                          xmlTextWriter.WriteEndElement();
                          xmlTextWriter.WriteStartElement("SAP:Height");
                          // ISSUE: reference to a compiler-generated field
                          xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Doors[index2].Height / 1000f);
                          xmlTextWriter.WriteEndElement();
                          xmlTextWriter.WriteEndElement();
                          checked { ++num15; }
                        }
                      }
                      else
                      {
                        checked { ++num12; }
                        xmlTextWriter.WriteStartElement("SAP:SAP-Opening");
                        xmlTextWriter.WriteStartElement("SAP:Name");
                        xmlTextWriter.WriteValue(num12);
                        xmlTextWriter.WriteEndElement();
                        xmlTextWriter.WriteStartElement("SAP:Type");
                        // ISSUE: reference to a compiler-generated field
                        xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Doors[index2].OpeningType);
                        xmlTextWriter.WriteEndElement();
                        xmlTextWriter.WriteStartElement("SAP:Location");
                        // ISSUE: reference to a compiler-generated field
                        xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Doors[index2].Location);
                        xmlTextWriter.WriteEndElement();
                        xmlTextWriter.WriteStartElement("SAP:Orientation");
                        // ISSUE: reference to a compiler-generated field
                        string orientation3 = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Doors[index2].Orientation;
                        // ISSUE: reference to a compiler-generated method
                        switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(orientation3))
                        {
                          case 1128440633:
                            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation3, "North East", false) == 0)
                            {
                              xmlTextWriter.WriteValue("2");
                              break;
                            }
                            goto default;
                          case 1409318971:
                            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation3, "North West", false) == 0)
                            {
                              xmlTextWriter.WriteValue("8");
                              break;
                            }
                            goto default;
                          case 1731397980:
                            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation3, "East", false) == 0)
                            {
                              xmlTextWriter.WriteValue("3");
                              break;
                            }
                            goto default;
                          case 1734234020:
                            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation3, "North", false) == 0)
                            {
                              xmlTextWriter.WriteValue("1");
                              break;
                            }
                            goto default;
                          case 1796576718:
                            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation3, "West", false) == 0)
                            {
                              xmlTextWriter.WriteValue("7");
                              break;
                            }
                            goto default;
                          case 2417407149:
                            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation3, "South West", false) == 0)
                            {
                              xmlTextWriter.WriteValue("6");
                              break;
                            }
                            goto default;
                          case 2853841879:
                            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation3, "South East", false) == 0)
                            {
                              xmlTextWriter.WriteValue("4");
                              break;
                            }
                            goto default;
                          case 3017973530:
                            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation3, "South", false) == 0)
                            {
                              xmlTextWriter.WriteValue("5");
                              break;
                            }
                            goto default;
                          default:
                            xmlTextWriter.WriteValue("0");
                            break;
                        }
                        xmlTextWriter.WriteEndElement();
                        xmlTextWriter.WriteStartElement("SAP:Width");
                        // ISSUE: reference to a compiler-generated field
                        xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Doors[index2].Width / 1000f);
                        xmlTextWriter.WriteEndElement();
                        xmlTextWriter.WriteStartElement("SAP:Height");
                        // ISSUE: reference to a compiler-generated field
                        xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Doors[index2].Height / 1000f);
                        xmlTextWriter.WriteEndElement();
                        xmlTextWriter.WriteEndElement();
                      }
                      checked { ++index2; }
                    }
                    // ISSUE: reference to a compiler-generated field
                    int num16 = checked (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].NoofWindows - 1);
                    int index3 = 0;
                    while (index3 <= num16)
                    {
                      // ISSUE: reference to a compiler-generated field
                      if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Windows[index3].Count > 1)
                      {
                        // ISSUE: reference to a compiler-generated field
                        int num17 = checked (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Windows[index3].Count - 1);
                        int num18 = 0;
                        while (num18 <= num17)
                        {
                          checked { ++num12; }
                          xmlTextWriter.WriteStartElement("SAP:SAP-Opening");
                          xmlTextWriter.WriteStartElement("SAP:Name");
                          xmlTextWriter.WriteValue(num12);
                          xmlTextWriter.WriteEndElement();
                          xmlTextWriter.WriteStartElement("SAP:Type");
                          // ISSUE: reference to a compiler-generated field
                          xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Windows[index3].OpeningType);
                          xmlTextWriter.WriteEndElement();
                          xmlTextWriter.WriteStartElement("SAP:Location");
                          // ISSUE: reference to a compiler-generated field
                          xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Windows[index3].Location);
                          xmlTextWriter.WriteEndElement();
                          xmlTextWriter.WriteStartElement("SAP:Orientation");
                          // ISSUE: reference to a compiler-generated field
                          string orientation4 = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Windows[index3].Orientation;
                          // ISSUE: reference to a compiler-generated method
                          switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(orientation4))
                          {
                            case 1128440633:
                              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation4, "North East", false) == 0)
                              {
                                xmlTextWriter.WriteValue("2");
                                break;
                              }
                              goto default;
                            case 1409318971:
                              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation4, "North West", false) == 0)
                              {
                                xmlTextWriter.WriteValue("8");
                                break;
                              }
                              goto default;
                            case 1731397980:
                              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation4, "East", false) == 0)
                              {
                                xmlTextWriter.WriteValue("3");
                                break;
                              }
                              goto default;
                            case 1734234020:
                              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation4, "North", false) == 0)
                              {
                                xmlTextWriter.WriteValue("1");
                                break;
                              }
                              goto default;
                            case 1796576718:
                              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation4, "West", false) == 0)
                              {
                                xmlTextWriter.WriteValue("7");
                                break;
                              }
                              goto default;
                            case 2417407149:
                              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation4, "South West", false) == 0)
                              {
                                xmlTextWriter.WriteValue("6");
                                break;
                              }
                              goto default;
                            case 2853841879:
                              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation4, "South East", false) == 0)
                              {
                                xmlTextWriter.WriteValue("4");
                                break;
                              }
                              goto default;
                            case 3017973530:
                              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation4, "South", false) == 0)
                              {
                                xmlTextWriter.WriteValue("5");
                                break;
                              }
                              goto default;
                            default:
                              xmlTextWriter.WriteValue("0");
                              break;
                          }
                          xmlTextWriter.WriteEndElement();
                          xmlTextWriter.WriteStartElement("SAP:Width");
                          // ISSUE: reference to a compiler-generated field
                          xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Windows[index3].Width / 1000f);
                          xmlTextWriter.WriteEndElement();
                          xmlTextWriter.WriteStartElement("SAP:Height");
                          // ISSUE: reference to a compiler-generated field
                          xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Windows[index3].Height / 1000f);
                          xmlTextWriter.WriteEndElement();
                          xmlTextWriter.WriteEndElement();
                          checked { ++num18; }
                        }
                      }
                      else
                      {
                        checked { ++num12; }
                        xmlTextWriter.WriteStartElement("SAP:SAP-Opening");
                        xmlTextWriter.WriteStartElement("SAP:Name");
                        xmlTextWriter.WriteValue(num12);
                        xmlTextWriter.WriteEndElement();
                        xmlTextWriter.WriteStartElement("SAP:Type");
                        // ISSUE: reference to a compiler-generated field
                        xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Windows[index3].OpeningType);
                        xmlTextWriter.WriteEndElement();
                        xmlTextWriter.WriteStartElement("SAP:Location");
                        // ISSUE: reference to a compiler-generated field
                        xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Windows[index3].Location);
                        xmlTextWriter.WriteEndElement();
                        xmlTextWriter.WriteStartElement("SAP:Orientation");
                        // ISSUE: reference to a compiler-generated field
                        string orientation5 = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Windows[index3].Orientation;
                        // ISSUE: reference to a compiler-generated method
                        switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(orientation5))
                        {
                          case 1128440633:
                            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation5, "North East", false) == 0)
                            {
                              xmlTextWriter.WriteValue("2");
                              break;
                            }
                            goto default;
                          case 1409318971:
                            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation5, "North West", false) == 0)
                            {
                              xmlTextWriter.WriteValue("8");
                              break;
                            }
                            goto default;
                          case 1731397980:
                            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation5, "East", false) == 0)
                            {
                              xmlTextWriter.WriteValue("3");
                              break;
                            }
                            goto default;
                          case 1734234020:
                            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation5, "North", false) == 0)
                            {
                              xmlTextWriter.WriteValue("1");
                              break;
                            }
                            goto default;
                          case 1796576718:
                            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation5, "West", false) == 0)
                            {
                              xmlTextWriter.WriteValue("7");
                              break;
                            }
                            goto default;
                          case 2417407149:
                            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation5, "South West", false) == 0)
                            {
                              xmlTextWriter.WriteValue("6");
                              break;
                            }
                            goto default;
                          case 2853841879:
                            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation5, "South East", false) == 0)
                            {
                              xmlTextWriter.WriteValue("4");
                              break;
                            }
                            goto default;
                          case 3017973530:
                            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation5, "South", false) == 0)
                            {
                              xmlTextWriter.WriteValue("5");
                              break;
                            }
                            goto default;
                          default:
                            xmlTextWriter.WriteValue("0");
                            break;
                        }
                        xmlTextWriter.WriteEndElement();
                        xmlTextWriter.WriteStartElement("SAP:Width");
                        // ISSUE: reference to a compiler-generated field
                        xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Windows[index3].Width / 1000f);
                        xmlTextWriter.WriteEndElement();
                        xmlTextWriter.WriteStartElement("SAP:Height");
                        // ISSUE: reference to a compiler-generated field
                        xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Windows[index3].Height / 1000f);
                        xmlTextWriter.WriteEndElement();
                        xmlTextWriter.WriteEndElement();
                      }
                      checked { ++index3; }
                    }
                    // ISSUE: reference to a compiler-generated field
                    int num19 = checked (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].NoofRoofLights - 1);
                    int index4 = 0;
                    while (index4 <= num19)
                    {
                      // ISSUE: reference to a compiler-generated field
                      if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].RoofLights[index4].Count > 1)
                      {
                        // ISSUE: reference to a compiler-generated field
                        int num20 = checked (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].RoofLights[index4].Count - 1);
                        int num21 = 0;
                        while (num21 <= num20)
                        {
                          checked { ++num12; }
                          xmlTextWriter.WriteStartElement("SAP:SAP-Opening");
                          xmlTextWriter.WriteStartElement("SAP:Name");
                          xmlTextWriter.WriteValue(num12);
                          xmlTextWriter.WriteEndElement();
                          xmlTextWriter.WriteStartElement("SAP:Type");
                          // ISSUE: reference to a compiler-generated field
                          if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].RoofLights[index4].OpeningType != null)
                          {
                            // ISSUE: reference to a compiler-generated field
                            xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].RoofLights[index4].OpeningType);
                          }
                          else
                            xmlTextWriter.WriteValue(0);
                          xmlTextWriter.WriteEndElement();
                          xmlTextWriter.WriteStartElement("SAP:Location");
                          // ISSUE: reference to a compiler-generated field
                          xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].RoofLights[index4].Location);
                          xmlTextWriter.WriteEndElement();
                          xmlTextWriter.WriteStartElement("SAP:Orientation");
                          // ISSUE: reference to a compiler-generated field
                          string orientation6 = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].RoofLights[index4].Orientation;
                          // ISSUE: reference to a compiler-generated method
                          switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(orientation6))
                          {
                            case 1128440633:
                              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation6, "North East", false) == 0)
                              {
                                xmlTextWriter.WriteValue("2");
                                break;
                              }
                              goto default;
                            case 1409318971:
                              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation6, "North West", false) == 0)
                              {
                                xmlTextWriter.WriteValue("8");
                                break;
                              }
                              goto default;
                            case 1731397980:
                              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation6, "East", false) == 0)
                              {
                                xmlTextWriter.WriteValue("3");
                                break;
                              }
                              goto default;
                            case 1734234020:
                              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation6, "North", false) == 0)
                              {
                                xmlTextWriter.WriteValue("1");
                                break;
                              }
                              goto default;
                            case 1796576718:
                              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation6, "West", false) == 0)
                              {
                                xmlTextWriter.WriteValue("7");
                                break;
                              }
                              goto default;
                            case 1811125385:
                              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation6, "Horizontal", false) == 0)
                              {
                                xmlTextWriter.WriteValue("9");
                                break;
                              }
                              goto default;
                            case 2417407149:
                              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation6, "South West", false) == 0)
                              {
                                xmlTextWriter.WriteValue("6");
                                break;
                              }
                              goto default;
                            case 2853841879:
                              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation6, "South East", false) == 0)
                              {
                                xmlTextWriter.WriteValue("4");
                                break;
                              }
                              goto default;
                            case 3017973530:
                              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation6, "South", false) == 0)
                              {
                                xmlTextWriter.WriteValue("5");
                                break;
                              }
                              goto default;
                            default:
                              xmlTextWriter.WriteValue("0");
                              break;
                          }
                          xmlTextWriter.WriteEndElement();
                          xmlTextWriter.WriteStartElement("SAP:Width");
                          // ISSUE: reference to a compiler-generated field
                          xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].RoofLights[index4].Width / 1000f);
                          xmlTextWriter.WriteEndElement();
                          xmlTextWriter.WriteStartElement("SAP:Height");
                          // ISSUE: reference to a compiler-generated field
                          xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].RoofLights[index4].Height / 1000f);
                          xmlTextWriter.WriteEndElement();
                          xmlTextWriter.WriteEndElement();
                          checked { ++num21; }
                        }
                      }
                      else
                      {
                        checked { ++num12; }
                        xmlTextWriter.WriteStartElement("SAP:SAP-Opening");
                        xmlTextWriter.WriteStartElement("SAP:Name");
                        xmlTextWriter.WriteValue(num12);
                        xmlTextWriter.WriteEndElement();
                        xmlTextWriter.WriteStartElement("SAP:Type");
                        // ISSUE: reference to a compiler-generated field
                        if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].RoofLights[index4].OpeningType != null)
                        {
                          // ISSUE: reference to a compiler-generated field
                          xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].RoofLights[index4].OpeningType);
                          xmlTextWriter.WriteEndElement();
                        }
                        else
                        {
                          xmlTextWriter.WriteValue(0);
                          xmlTextWriter.WriteEndElement();
                        }
                        xmlTextWriter.WriteStartElement("SAP:Location");
                        // ISSUE: reference to a compiler-generated field
                        xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].RoofLights[index4].Location);
                        xmlTextWriter.WriteEndElement();
                        xmlTextWriter.WriteStartElement("SAP:Orientation");
                        // ISSUE: reference to a compiler-generated field
                        string orientation7 = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].RoofLights[index4].Orientation;
                        // ISSUE: reference to a compiler-generated method
                        switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(orientation7))
                        {
                          case 1128440633:
                            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation7, "North East", false) == 0)
                            {
                              xmlTextWriter.WriteValue("2");
                              break;
                            }
                            goto default;
                          case 1409318971:
                            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation7, "North West", false) == 0)
                            {
                              xmlTextWriter.WriteValue("8");
                              break;
                            }
                            goto default;
                          case 1731397980:
                            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation7, "East", false) == 0)
                            {
                              xmlTextWriter.WriteValue("3");
                              break;
                            }
                            goto default;
                          case 1734234020:
                            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation7, "North", false) == 0)
                            {
                              xmlTextWriter.WriteValue("1");
                              break;
                            }
                            goto default;
                          case 1796576718:
                            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation7, "West", false) == 0)
                            {
                              xmlTextWriter.WriteValue("7");
                              break;
                            }
                            goto default;
                          case 1811125385:
                            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation7, "Horizontal", false) == 0)
                            {
                              xmlTextWriter.WriteValue("9");
                              break;
                            }
                            goto default;
                          case 2417407149:
                            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation7, "South West", false) == 0)
                            {
                              xmlTextWriter.WriteValue("6");
                              break;
                            }
                            goto default;
                          case 2853841879:
                            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation7, "South East", false) == 0)
                            {
                              xmlTextWriter.WriteValue("4");
                              break;
                            }
                            goto default;
                          case 3017973530:
                            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation7, "South", false) == 0)
                            {
                              xmlTextWriter.WriteValue("5");
                              break;
                            }
                            goto default;
                          default:
                            xmlTextWriter.WriteValue("0");
                            break;
                        }
                        xmlTextWriter.WriteEndElement();
                        xmlTextWriter.WriteStartElement("SAP:Width");
                        // ISSUE: reference to a compiler-generated field
                        xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].RoofLights[index4].Width / 1000f);
                        xmlTextWriter.WriteEndElement();
                        xmlTextWriter.WriteStartElement("SAP:Height");
                        // ISSUE: reference to a compiler-generated field
                        xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].RoofLights[index4].Height / 1000f);
                        xmlTextWriter.WriteEndElement();
                        xmlTextWriter.WriteEndElement();
                      }
                      checked { ++index4; }
                    }
                    xmlTextWriter.WriteEndElement();
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    if (checked (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].NoofFloors + SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].NoofIFloors) > 0)
                    {
                      xmlTextWriter.WriteStartElement("SAP:SAP-Floor-Dimensions");
                      int num22 = 0;
                      int index5 = 0;
                      int index6 = 0;
                      int num23 = 0;
                      // ISSUE: reference to a compiler-generated field
                      int num24 = checked (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Storeys - 1);
                      int index7 = 0;
                      while (index7 <= num24)
                      {
                        xmlTextWriter.WriteStartElement("SAP:SAP-Floor-Dimension");
                        xmlTextWriter.WriteStartElement("SAP:Storey");
                        // ISSUE: reference to a compiler-generated field
                        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Dims[0].Basement, "Yes", false) == 0)
                        {
                          xmlTextWriter.WriteValue(checked (index7 - 1));
                          xmlTextWriter.WriteEndElement();
                        }
                        else
                        {
                          xmlTextWriter.WriteValue(index7);
                          xmlTextWriter.WriteEndElement();
                        }
                        checked { ++num22; }
                        checked { num23 += index7; }
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        if (checked (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].NoofFloors - 1) >= index7 && (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Floors[index7].Type, "Exposed floor", false) > 0U)
                        {
                          xmlTextWriter.WriteStartElement("SAP:Description");
                          xmlTextWriter.WriteEndElement();
                        }
                        xmlTextWriter.WriteStartElement("SAP:Floor-Type");
                        // ISSUE: reference to a compiler-generated field
                        if (checked (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].NoofFloors - 1) >= index7)
                        {
                          // ISSUE: reference to a compiler-generated field
                          string type = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Floors[index7].Type;
                          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(type, "Basement floor", false) != 0)
                          {
                            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(type, "Ground floor", false) != 0)
                            {
                              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(type, "Exposed floor", false) == 0)
                                xmlTextWriter.WriteValue(3);
                            }
                            else
                              xmlTextWriter.WriteValue(2);
                          }
                          else
                            xmlTextWriter.WriteValue(1);
                        }
                        else
                          xmlTextWriter.WriteValue(3);
                        xmlTextWriter.WriteEndElement();
                        xmlTextWriter.WriteStartElement("SAP:Total-Floor-Area");
                        // ISSUE: reference to a compiler-generated field
                        xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Dims[index7].Area);
                        xmlTextWriter.WriteEndElement();
                        xmlTextWriter.WriteStartElement("SAP:Storey-Height");
                        // ISSUE: reference to a compiler-generated field
                        xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Dims[index7].Height);
                        xmlTextWriter.WriteEndElement();
                        xmlTextWriter.WriteStartElement("SAP:Heat-Loss-Area");
                        // ISSUE: reference to a compiler-generated field
                        if (checked (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].NoofFloors - 1) >= index7)
                        {
                          // ISSUE: reference to a compiler-generated field
                          xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Floors[index7].Area);
                        }
                        else
                          xmlTextWriter.WriteValue(0);
                        xmlTextWriter.WriteEndElement();
                        xmlTextWriter.WriteStartElement("SAP:U-Value");
                        // ISSUE: reference to a compiler-generated field
                        if (checked (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].NoofFloors - 1) >= index7)
                        {
                          // ISSUE: reference to a compiler-generated field
                          xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Floors[index7].U_Value);
                        }
                        else
                          xmlTextWriter.WriteValue(0);
                        xmlTextWriter.WriteEndElement();
                        // ISSUE: reference to a compiler-generated field
                        if (checked (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].NoofFloors - 1) >= index7)
                        {
                          // ISSUE: reference to a compiler-generated field
                          if ((double) SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Floors[index7].K > 0.0)
                          {
                            xmlTextWriter.WriteStartElement("SAP:Kappa-Value");
                            // ISSUE: reference to a compiler-generated field
                            xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Floors[index7].K);
                            xmlTextWriter.WriteEndElement();
                          }
                          else
                          {
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].NoofFloors <= SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Storeys)
                            {
                              // ISSUE: reference to a compiler-generated field
                              // ISSUE: reference to a compiler-generated field
                              if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].NoofIFloors > 0 && (double) SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].IFloors[index5].K > 0.0)
                              {
                                xmlTextWriter.WriteStartElement("SAP:Kappa-Value");
                                // ISSUE: reference to a compiler-generated field
                                xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].IFloors[index5].K);
                                xmlTextWriter.WriteEndElement();
                                checked { ++index5; }
                              }
                              // ISSUE: reference to a compiler-generated field
                              // ISSUE: reference to a compiler-generated field
                              if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].NoofICeilings > 0 && (double) SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].ICeilings[index6].K > 0.0)
                              {
                                xmlTextWriter.WriteStartElement("SAP:Kappa-Value-From-Below");
                                // ISSUE: reference to a compiler-generated field
                                xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].ICeilings[index6].K);
                                xmlTextWriter.WriteEndElement();
                                checked { ++index6; }
                              }
                            }
                          }
                        }
                        xmlTextWriter.WriteEndElement();
                        checked { ++index7; }
                      }
                      xmlTextWriter.WriteEndElement();
                    }
                    xmlTextWriter.WriteStartElement("SAP:SAP-Roofs");
                    // ISSUE: reference to a compiler-generated field
                    if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].NoofRoofs == 0)
                    {
                      xmlTextWriter.WriteStartElement("SAP:SAP-Roof");
                      xmlTextWriter.WriteStartElement("SAP:Name");
                      xmlTextWriter.WriteValue("Exposed Roof");
                      xmlTextWriter.WriteEndElement();
                      xmlTextWriter.WriteStartElement("SAP:Description");
                      xmlTextWriter.WriteEndElement();
                      xmlTextWriter.WriteStartElement("SAP:Roof-Type");
                      xmlTextWriter.WriteValue(2);
                      xmlTextWriter.WriteEndElement();
                      xmlTextWriter.WriteStartElement("SAP:Total-Roof-Area");
                      xmlTextWriter.WriteValue(0);
                      xmlTextWriter.WriteEndElement();
                      xmlTextWriter.WriteStartElement("SAP:U-Value");
                      xmlTextWriter.WriteValue(0);
                      xmlTextWriter.WriteEndElement();
                      xmlTextWriter.WriteStartElement("SAP:Kappa-Value");
                      // ISSUE: reference to a compiler-generated field
                      if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].NoofRoofs > 0)
                      {
                        // ISSUE: reference to a compiler-generated field
                        xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Roofs[0].K);
                      }
                      else
                        xmlTextWriter.WriteValue(0);
                      xmlTextWriter.WriteEndElement();
                      xmlTextWriter.WriteEndElement();
                    }
                    else
                    {
                      // ISSUE: reference to a compiler-generated field
                      int num25 = checked (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].NoofRoofs - 1);
                      int index8 = 0;
                      while (index8 <= num25)
                      {
                        xmlTextWriter.WriteStartElement("SAP:SAP-Roof");
                        xmlTextWriter.WriteStartElement("SAP:Name");
                        // ISSUE: reference to a compiler-generated field
                        xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Roofs[index8].Name);
                        xmlTextWriter.WriteEndElement();
                        xmlTextWriter.WriteStartElement("SAP:Description");
                        xmlTextWriter.WriteEndElement();
                        xmlTextWriter.WriteStartElement("SAP:Roof-Type");
                        xmlTextWriter.WriteValue(2);
                        xmlTextWriter.WriteEndElement();
                        xmlTextWriter.WriteStartElement("SAP:Total-Roof-Area");
                        // ISSUE: reference to a compiler-generated field
                        xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Roofs[index8].Area);
                        xmlTextWriter.WriteEndElement();
                        xmlTextWriter.WriteStartElement("SAP:U-Value");
                        // ISSUE: reference to a compiler-generated field
                        xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Roofs[index8].U_Value);
                        xmlTextWriter.WriteEndElement();
                        // ISSUE: reference to a compiler-generated field
                        if ((double) SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Roofs[index8].K > 0.0)
                        {
                          xmlTextWriter.WriteStartElement("SAP:Kappa-Value");
                          // ISSUE: reference to a compiler-generated field
                          xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Roofs[index8].K);
                          xmlTextWriter.WriteEndElement();
                        }
                        xmlTextWriter.WriteEndElement();
                        checked { ++index8; }
                      }
                    }
                    // ISSUE: reference to a compiler-generated field
                    int num26 = checked (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].NoofPCeilings - 1);
                    int index9 = 0;
                    while (index9 <= num26)
                    {
                      xmlTextWriter.WriteStartElement("SAP:SAP-Roof");
                      xmlTextWriter.WriteStartElement("SAP:Name");
                      // ISSUE: reference to a compiler-generated field
                      xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].PCeilings[index9].Name);
                      xmlTextWriter.WriteEndElement();
                      xmlTextWriter.WriteStartElement("SAP:Description");
                      xmlTextWriter.WriteEndElement();
                      xmlTextWriter.WriteStartElement("SAP:Roof-Type");
                      xmlTextWriter.WriteValue(4);
                      xmlTextWriter.WriteEndElement();
                      xmlTextWriter.WriteStartElement("SAP:Total-Roof-Area");
                      // ISSUE: reference to a compiler-generated field
                      xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].PCeilings[index9].Area);
                      xmlTextWriter.WriteEndElement();
                      xmlTextWriter.WriteStartElement("SAP:U-Value");
                      xmlTextWriter.WriteValue(0);
                      xmlTextWriter.WriteEndElement();
                      // ISSUE: reference to a compiler-generated field
                      if ((double) SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].PCeilings[index9].K > 0.0)
                      {
                        xmlTextWriter.WriteStartElement("SAP:Kappa-Value");
                        // ISSUE: reference to a compiler-generated field
                        xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].PCeilings[index9].K);
                        xmlTextWriter.WriteEndElement();
                      }
                      xmlTextWriter.WriteEndElement();
                      checked { ++index9; }
                    }
                    xmlTextWriter.WriteEndElement();
                    xmlTextWriter.WriteStartElement("SAP:SAP-Walls");
                    // ISSUE: reference to a compiler-generated field
                    int num27 = checked (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].NoofWalls - 1);
                    int index10 = 0;
                    while (index10 <= num27)
                    {
                      xmlTextWriter.WriteStartElement("SAP:SAP-Wall");
                      xmlTextWriter.WriteStartElement("SAP:Name");
                      // ISSUE: reference to a compiler-generated field
                      xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Walls[index10].Name);
                      xmlTextWriter.WriteEndElement();
                      xmlTextWriter.WriteStartElement("SAP:Description");
                      xmlTextWriter.WriteEndElement();
                      xmlTextWriter.WriteStartElement("SAP:Wall-Type");
                      // ISSUE: reference to a compiler-generated field
                      string type = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Walls[index10].Type;
                      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(type, "Basement wall", false) != 0)
                      {
                        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(type, "Exposed wall", false) != 0)
                        {
                          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(type, "Sheltered wall", false) == 0)
                            xmlTextWriter.WriteValue("3");
                        }
                        else
                          xmlTextWriter.WriteValue("2");
                      }
                      else
                        xmlTextWriter.WriteValue("1");
                      xmlTextWriter.WriteEndElement();
                      xmlTextWriter.WriteStartElement("SAP:Total-Wall-Area");
                      // ISSUE: reference to a compiler-generated field
                      xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Walls[index10].Area);
                      xmlTextWriter.WriteEndElement();
                      xmlTextWriter.WriteStartElement("SAP:U-Value");
                      // ISSUE: reference to a compiler-generated field
                      xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Walls[index10].U_Value);
                      xmlTextWriter.WriteEndElement();
                      // ISSUE: reference to a compiler-generated field
                      if ((double) SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Walls[index10].K > 0.0)
                      {
                        xmlTextWriter.WriteStartElement("SAP:Kappa-Value");
                        // ISSUE: reference to a compiler-generated field
                        xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Walls[index10].K);
                        xmlTextWriter.WriteEndElement();
                      }
                      // ISSUE: reference to a compiler-generated field
                      if (!SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Walls[index10].Type.Contains("ment"))
                      {
                        xmlTextWriter.WriteStartElement("SAP:Is-Curtain-Walling");
                        // ISSUE: reference to a compiler-generated field
                        if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Walls[index10].Curtain)
                          xmlTextWriter.WriteValue("true");
                        else
                          xmlTextWriter.WriteValue("false");
                        xmlTextWriter.WriteEndElement();
                      }
                      xmlTextWriter.WriteEndElement();
                      checked { ++index10; }
                    }
                    // ISSUE: reference to a compiler-generated field
                    int num28 = checked (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].NoofIWalls - 1);
                    int index11 = 0;
                    while (index11 <= num28)
                    {
                      xmlTextWriter.WriteStartElement("SAP:SAP-Wall");
                      xmlTextWriter.WriteStartElement("SAP:Name");
                      // ISSUE: reference to a compiler-generated field
                      xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].IWalls[index11].Name);
                      xmlTextWriter.WriteEndElement();
                      xmlTextWriter.WriteStartElement("SAP:Wall-Type");
                      xmlTextWriter.WriteValue("5");
                      xmlTextWriter.WriteEndElement();
                      xmlTextWriter.WriteStartElement("SAP:Total-Wall-Area");
                      // ISSUE: reference to a compiler-generated field
                      xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].IWalls[index11].Area);
                      xmlTextWriter.WriteEndElement();
                      xmlTextWriter.WriteStartElement("SAP:U-Value");
                      xmlTextWriter.WriteValue(0);
                      xmlTextWriter.WriteEndElement();
                      // ISSUE: reference to a compiler-generated field
                      if ((double) SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].IWalls[index11].K > 0.0)
                      {
                        xmlTextWriter.WriteStartElement("SAP:Kappa-Value");
                        // ISSUE: reference to a compiler-generated field
                        xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].IWalls[index11].K);
                        xmlTextWriter.WriteEndElement();
                      }
                      xmlTextWriter.WriteEndElement();
                      checked { ++index11; }
                    }
                    // ISSUE: reference to a compiler-generated field
                    int num29 = checked (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].NoofPWalls - 1);
                    int index12 = 0;
                    while (index12 <= num29)
                    {
                      xmlTextWriter.WriteStartElement("SAP:SAP-Wall");
                      xmlTextWriter.WriteStartElement("SAP:Name");
                      // ISSUE: reference to a compiler-generated field
                      xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].PWalls[index12].Name);
                      xmlTextWriter.WriteEndElement();
                      xmlTextWriter.WriteStartElement("SAP:Wall-Type");
                      xmlTextWriter.WriteValue("4");
                      xmlTextWriter.WriteEndElement();
                      xmlTextWriter.WriteStartElement("SAP:Total-Wall-Area");
                      // ISSUE: reference to a compiler-generated field
                      xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].PWalls[index12].Area);
                      xmlTextWriter.WriteEndElement();
                      xmlTextWriter.WriteStartElement("SAP:U-Value");
                      // ISSUE: reference to a compiler-generated field
                      xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].PWalls[index12].U_Value);
                      xmlTextWriter.WriteEndElement();
                      // ISSUE: reference to a compiler-generated field
                      if ((double) SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].PWalls[index12].K > 0.0)
                      {
                        xmlTextWriter.WriteStartElement("SAP:Kappa-Value");
                        // ISSUE: reference to a compiler-generated field
                        xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].PWalls[index12].K);
                        xmlTextWriter.WriteEndElement();
                      }
                      xmlTextWriter.WriteEndElement();
                      checked { ++index12; }
                    }
                    xmlTextWriter.WriteEndElement();
                    xmlTextWriter.WriteStartElement("SAP:SAP-Thermal-Bridges");
                    xmlTextWriter.WriteStartElement("SAP:Thermal-Bridge-Code");
                    // ISSUE: reference to a compiler-generated field
                    if (!SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Thermal.ManualHtb)
                    {
                      // ISSUE: reference to a compiler-generated field
                      if (!SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Thermal.ManualY)
                      {
                        // ISSUE: reference to a compiler-generated field
                        if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Thermal.ConstDetails.Contains("Scotland simplified"))
                        {
                          xmlTextWriter.WriteValue(3);
                          xmlTextWriter.WriteEndElement();
                        }
                        else
                        {
                          xmlTextWriter.WriteValue(1);
                          xmlTextWriter.WriteEndElement();
                        }
                      }
                      else
                      {
                        xmlTextWriter.WriteValue(4);
                        xmlTextWriter.WriteEndElement();
                        xmlTextWriter.WriteStartElement("SAP:User-Defined-Y-Value");
                        // ISSUE: reference to a compiler-generated field
                        xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Thermal.YValue);
                        xmlTextWriter.WriteEndElement();
                        xmlTextWriter.WriteStartElement("SAP:Calculation-Reference");
                        // ISSUE: reference to a compiler-generated field
                        xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Thermal.Reference);
                        xmlTextWriter.WriteEndElement();
                      }
                    }
                    else
                    {
                      xmlTextWriter.WriteValue(5);
                      xmlTextWriter.WriteEndElement();
                    }
                    xmlTextWriter.WriteEndElement();
                    // ISSUE: reference to a compiler-generated field
                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].TMP.Type, "User Value", false) == 0)
                    {
                      xmlTextWriter.WriteStartElement("SAP:Thermal-Mass-Parameter");
                      // ISSUE: reference to a compiler-generated field
                      xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].TMP.UserDefined);
                      xmlTextWriter.WriteEndElement();
                    }
                    xmlTextWriter.WriteEndElement();
                    xmlTextWriter.WriteEndElement();
                    xmlTextWriter.WriteStartElement("SAP:SAP-Ventilation");
                    xmlTextWriter.WriteStartElement("SAP:Open-Fireplaces-Count");
                    // ISSUE: reference to a compiler-generated field
                    xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.Chimneys);
                    xmlTextWriter.WriteEndElement();
                    xmlTextWriter.WriteStartElement("SAP:Open-Flues-Count");
                    // ISSUE: reference to a compiler-generated field
                    xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.Flues);
                    xmlTextWriter.WriteEndElement();
                    xmlTextWriter.WriteStartElement("SAP:Extract-Fans-Count");
                    // ISSUE: reference to a compiler-generated field
                    xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.Fans);
                    xmlTextWriter.WriteEndElement();
                    xmlTextWriter.WriteStartElement("SAP:PSV-Count");
                    // ISSUE: reference to a compiler-generated field
                    xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.Vents);
                    xmlTextWriter.WriteEndElement();
                    xmlTextWriter.WriteStartElement("SAP:Flueless-Gas-Fires-Count");
                    // ISSUE: reference to a compiler-generated field
                    xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.Fires);
                    xmlTextWriter.WriteEndElement();
                    xmlTextWriter.WriteStartElement("SAP:Pressure-Test");
                    // ISSUE: reference to a compiler-generated field
                    if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.AveragePerm)
                    {
                      xmlTextWriter.WriteValue("5");
                    }
                    else
                    {
                      // ISSUE: reference to a compiler-generated field
                      string pressure = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.Pressure;
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
                            xmlTextWriter.WriteValue("3");
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
                            goto label_980;
                          else
                            goto default;
                        case 1647734778:
                          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(pressure, "no", false) == 0)
                            goto label_980;
                          else
                            goto default;
                        case 1942325214:
                          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(pressure, "yes (design value)", false) == 0)
                            goto label_978;
                          else
                            goto default;
                        case 2121038188:
                          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(pressure, "As designed", false) == 0)
                            goto label_978;
                          else
                            goto default;
                        default:
label_981:
                          goto label_982;
                      }
                      xmlTextWriter.WriteValue("1");
                      goto label_981;
label_978:
                      xmlTextWriter.WriteValue("2");
                      goto label_981;
label_980:
                      xmlTextWriter.WriteValue("4");
                      goto label_981;
                    }
label_982:
                    xmlTextWriter.WriteEndElement();
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.Pressure, "Calculated", false) > 0U & (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.Pressure, "As built", false) > 0U)
                    {
                      xmlTextWriter.WriteStartElement("SAP:Air-Permeability");
                      xmlTextWriter.WriteValue(num5);
                      xmlTextWriter.WriteEndElement();
                    }
                    else
                    {
                      // ISSUE: reference to a compiler-generated field
                      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.Pressure, "As built", false) == 0)
                      {
                        xmlTextWriter.WriteStartElement("SAP:Air-Permeability");
                        xmlTextWriter.WriteValue(num5);
                        xmlTextWriter.WriteEndElement();
                      }
                    }
                    // ISSUE: reference to a compiler-generated field
                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.Pressure, "Calculated", false) == 0)
                    {
                      xmlTextWriter.WriteStartElement("SAP:Ground-Floor-Type");
                      // ISSUE: reference to a compiler-generated field
                      string floor = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.Infiltration.Floor;
                      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(floor, "Non timber floor", false) != 0)
                      {
                        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(floor, "Suspended timber floor - Sealed", false) != 0)
                        {
                          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(floor, "Suspended timber floor - Unsealed", false) == 0)
                            xmlTextWriter.WriteValue("3");
                        }
                        else
                          xmlTextWriter.WriteValue("2");
                      }
                      else
                        xmlTextWriter.WriteValue("1");
                      xmlTextWriter.WriteEndElement();
                    }
                    xmlTextWriter.WriteStartElement("SAP:Sheltered-Sides-Count");
                    // ISSUE: reference to a compiler-generated field
                    xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.Shelter);
                    xmlTextWriter.WriteEndElement();
                    xmlTextWriter.WriteStartElement("SAP:Ventilation-Type");
                    // ISSUE: reference to a compiler-generated field
                    string mechVent1 = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.MechVent;
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
                          xmlTextWriter.WriteValue("7");
                          goto default;
                        }
                        else
                          goto default;
                      case 918396964:
                        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(mechVent1, "Decentralised whole house extract", false) == 0)
                        {
                          xmlTextWriter.WriteValue("6");
                          goto default;
                        }
                        else
                          goto default;
                      case 1101494137:
                        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(mechVent1, "Centralised whole house extract", false) == 0)
                        {
                          xmlTextWriter.WriteValue("5");
                          goto default;
                        }
                        else
                          goto default;
                      case 2533751361:
                        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(mechVent1, "Positive input from loft", false) == 0)
                        {
                          xmlTextWriter.WriteValue("3");
                          goto default;
                        }
                        else
                          goto default;
                      case 3118369032:
                        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(mechVent1, "natural with intermittent extract fans and passive vents", false) == 0)
                        {
                          xmlTextWriter.WriteValue("10");
                          goto default;
                        }
                        else
                          goto default;
                      case 3225008057:
                        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(mechVent1, "Positive input from outside", false) == 0)
                        {
                          xmlTextWriter.WriteValue("4");
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
                          xmlTextWriter.WriteValue("8");
                          goto default;
                        }
                        else
                          goto default;
                      default:
label_1022:
                        xmlTextWriter.WriteEndElement();
                        // ISSUE: reference to a compiler-generated field
                        string mechVent2 = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.MechVent;
                        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(mechVent2, "Natural ventilation", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(mechVent2, "natural with intermittent extract fans", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(mechVent2, "Positive input from loft", false) != 0)
                        {
                          xmlTextWriter.WriteStartElement("SAP:Is-Mechanical-Vent-Approved-Installer-Scheme");
                          // ISSUE: reference to a compiler-generated field
                          if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.ApprovedScheme)
                            xmlTextWriter.WriteValue("true");
                          else
                            xmlTextWriter.WriteValue("false");
                          xmlTextWriter.WriteEndElement();
                        }
                        // ISSUE: reference to a compiler-generated field
                        string mechVent3 = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.MechVent;
                        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(mechVent3, "Balanced without heat recovery", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(mechVent3, "Positive input from outside", false) != 0)
                        {
                          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(mechVent3, "Balanced with heat recovery", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(mechVent3, "Centralised whole house extract", false) != 0)
                          {
                            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(mechVent3, "Decentralised whole house extract", false) == 0)
                            {
                              xmlTextWriter.WriteStartElement("SAP:Mechanical-Ventilation-Data-Source");
                              // ISSUE: reference to a compiler-generated field
                              string parameters = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.Parameters;
                              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(parameters, "User defined", false) != 0)
                              {
                                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(parameters, "SAP 2005", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(parameters, "SAP 2009", false) != 0)
                                {
                                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(parameters, "Database", false) == 0)
                                  {
                                    xmlTextWriter.WriteValue(1);
                                    xmlTextWriter.WriteEndElement();
                                    xmlTextWriter.WriteStartElement("SAP:Mechanical-Vent-System-Index-Number");
                                    // ISSUE: reference to a compiler-generated field
                                    xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.ProductID);
                                    xmlTextWriter.WriteEndElement();
                                    xmlTextWriter.WriteStartElement("SAP:Wet-Rooms-Count");
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    xmlTextWriter.WriteValue(Math.Round(1.0 + (double) SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.Decentralised.OTP1 + (double) SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.Decentralised.OTP2 + (double) SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.Decentralised.OTP3, 0));
                                    xmlTextWriter.WriteEndElement();
                                    // ISSUE: reference to a compiler-generated method
                                    PCDF.Products321 products321 = SAP_Module.PCDFData.Products321s.Where<PCDF.Products321>(new Func<PCDF.Products321, bool>(closure850_2._Lambda\u0024__1)).SingleOrDefault<PCDF.Products321>();
                                    xmlTextWriter.WriteStartElement("SAP:Mechanical-Vent-Duct-Type");
                                    if (products321 != null)
                                      xmlTextWriter.WriteValue(2);
                                    else
                                      xmlTextWriter.WriteValue(products321.DuctingType);
                                    xmlTextWriter.WriteEndElement();
                                  }
                                }
                                else
                                {
                                  xmlTextWriter.WriteValue(3);
                                  xmlTextWriter.WriteEndElement();
                                }
                              }
                              else
                              {
                                xmlTextWriter.WriteValue(2);
                                xmlTextWriter.WriteEndElement();
                                xmlTextWriter.WriteStartElement("SAP:Mechanical-Vent-System-Make-Model");
                                // ISSUE: reference to a compiler-generated field
                                xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.MVDetails.ProductName);
                                xmlTextWriter.WriteEndElement();
                                xmlTextWriter.WriteStartElement("SAP:Wet-Rooms-Count");
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                xmlTextWriter.WriteValue(Math.Round(1.0 + (double) SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.Decentralised.OTP1 + (double) SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.Decentralised.OTP2 + (double) SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.Decentralised.OTP3, 0));
                                xmlTextWriter.WriteEndElement();
                                xmlTextWriter.WriteStartElement("SAP:Mechanical-Vent-Duct-Type");
                                // ISSUE: reference to a compiler-generated field
                                string ductingType = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.MVDetails.DuctingType;
                                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(ductingType, "Rigid", false) != 0)
                                {
                                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(ductingType, "Flexible", false) == 0)
                                    xmlTextWriter.WriteValue(1);
                                }
                                else
                                  xmlTextWriter.WriteValue(2);
                                xmlTextWriter.WriteEndElement();
                              }
                              // ISSUE: reference to a compiler-generated field
                              // ISSUE: reference to a compiler-generated field
                              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.Parameters, "User defined", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.Parameters, "Database", false) == 0)
                              {
                                xmlTextWriter.WriteStartElement("SAP:Kitchen-Room-Fans-Count");
                                // ISSUE: reference to a compiler-generated field
                                xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.Decentralised.KTP1);
                                xmlTextWriter.WriteEndElement();
                              }
                              // ISSUE: reference to a compiler-generated field
                              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.Parameters, "User defined", false) == 0)
                              {
                                xmlTextWriter.WriteStartElement("SAP:Kitchen-Room-Fans-Specific-Power");
                                // ISSUE: reference to a compiler-generated field
                                xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.Decentralised.KSPF1);
                                xmlTextWriter.WriteEndElement();
                              }
                              // ISSUE: reference to a compiler-generated field
                              // ISSUE: reference to a compiler-generated field
                              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.Parameters, "User defined", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.Parameters, "Database", false) == 0)
                              {
                                xmlTextWriter.WriteStartElement("SAP:Non-Kitchen-Room-Fans-Count");
                                // ISSUE: reference to a compiler-generated field
                                xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.Decentralised.OTP1);
                                xmlTextWriter.WriteEndElement();
                              }
                              // ISSUE: reference to a compiler-generated field
                              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.Parameters, "User defined", false) == 0)
                              {
                                xmlTextWriter.WriteStartElement("SAP:Non-Kitchen-Room-Fans-Specific-Power");
                                // ISSUE: reference to a compiler-generated field
                                xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.Decentralised.OSPF1);
                                xmlTextWriter.WriteEndElement();
                              }
                              // ISSUE: reference to a compiler-generated field
                              // ISSUE: reference to a compiler-generated field
                              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.Parameters, "User defined", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.Parameters, "Database", false) == 0)
                              {
                                xmlTextWriter.WriteStartElement("SAP:Kitchen-Duct-Fans-Count");
                                // ISSUE: reference to a compiler-generated field
                                xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.Decentralised.KTP2);
                                xmlTextWriter.WriteEndElement();
                              }
                              // ISSUE: reference to a compiler-generated field
                              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.Parameters, "User defined", false) == 0)
                              {
                                xmlTextWriter.WriteStartElement("SAP:Kitchen-Duct-Fans-Specific-Power");
                                // ISSUE: reference to a compiler-generated field
                                xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.Decentralised.KSPF2);
                                xmlTextWriter.WriteEndElement();
                              }
                              // ISSUE: reference to a compiler-generated field
                              // ISSUE: reference to a compiler-generated field
                              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.Parameters, "User defined", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.Parameters, "Database", false) == 0)
                              {
                                xmlTextWriter.WriteStartElement("SAP:Non-Kitchen-Duct-Fans-Count");
                                // ISSUE: reference to a compiler-generated field
                                xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.Decentralised.OTP2);
                                xmlTextWriter.WriteEndElement();
                              }
                              // ISSUE: reference to a compiler-generated field
                              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.Parameters, "User defined", false) == 0)
                              {
                                xmlTextWriter.WriteStartElement("SAP:Non-Kitchen-Duct-Fans-Specific-Power");
                                // ISSUE: reference to a compiler-generated field
                                xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.Decentralised.OSPF2);
                                xmlTextWriter.WriteEndElement();
                              }
                              // ISSUE: reference to a compiler-generated field
                              // ISSUE: reference to a compiler-generated field
                              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.Parameters, "User defined", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.Parameters, "Database", false) == 0)
                              {
                                xmlTextWriter.WriteStartElement("SAP:Kitchen-Wall-Fans-Count");
                                // ISSUE: reference to a compiler-generated field
                                xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.Decentralised.KTP3);
                                xmlTextWriter.WriteEndElement();
                              }
                              // ISSUE: reference to a compiler-generated field
                              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.Parameters, "User defined", false) == 0)
                              {
                                xmlTextWriter.WriteStartElement("SAP:Kitchen-Wall-Fans-Specific-Power");
                                // ISSUE: reference to a compiler-generated field
                                xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.Decentralised.KSPF3);
                                xmlTextWriter.WriteEndElement();
                              }
                              // ISSUE: reference to a compiler-generated field
                              // ISSUE: reference to a compiler-generated field
                              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.Parameters, "User defined", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.Parameters, "Database", false) == 0)
                              {
                                xmlTextWriter.WriteStartElement("SAP:Non-Kitchen-Wall-Fans-Count");
                                // ISSUE: reference to a compiler-generated field
                                xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.Decentralised.OTP3);
                                xmlTextWriter.WriteEndElement();
                              }
                              // ISSUE: reference to a compiler-generated field
                              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.Parameters, "User defined", false) == 0)
                              {
                                xmlTextWriter.WriteStartElement("SAP:Non-Kitchen-Wall-Fans-Specific-Power");
                                // ISSUE: reference to a compiler-generated field
                                xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.Decentralised.OSPF3);
                                xmlTextWriter.WriteEndElement();
                              }
                            }
                          }
                          else
                          {
                            xmlTextWriter.WriteStartElement("SAP:Mechanical-Ventilation-Data-Source");
                            // ISSUE: reference to a compiler-generated field
                            string parameters = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.Parameters;
                            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(parameters, "User defined", false) != 0)
                            {
                              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(parameters, "SAP 2005", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(parameters, "SAP 2009", false) != 0)
                              {
                                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(parameters, "Database", false) == 0)
                                  xmlTextWriter.WriteValue(1);
                              }
                              else
                                xmlTextWriter.WriteValue(3);
                            }
                            else
                              xmlTextWriter.WriteValue(2);
                            xmlTextWriter.WriteEndElement();
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.Parameters, "Database", false) > 0U & (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.Parameters, "SAP 2009", false) > 0U)
                            {
                              xmlTextWriter.WriteStartElement("SAP:Mechanical-Vent-System-Make-Model");
                              // ISSUE: reference to a compiler-generated field
                              xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.MVDetails.ProductName);
                              xmlTextWriter.WriteEndElement();
                              xmlTextWriter.WriteStartElement("SAP:Mechanical-Vent-Specific-Fan-Power");
                              // ISSUE: reference to a compiler-generated field
                              xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.MVDetails.SFP);
                              xmlTextWriter.WriteEndElement();
                              // ISSUE: reference to a compiler-generated field
                              if ((double) SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.MVDetails.HEE != 0.0)
                              {
                                xmlTextWriter.WriteStartElement("SAP:Mechanical-Vent-Heat-Recovery-Efficiency");
                                // ISSUE: reference to a compiler-generated field
                                xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.MVDetails.HEE);
                                xmlTextWriter.WriteEndElement();
                              }
                              xmlTextWriter.WriteStartElement("SAP:Wet-Rooms-Count");
                              // ISSUE: reference to a compiler-generated field
                              xmlTextWriter.WriteValue(checked (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.WetRooms + 1));
                              xmlTextWriter.WriteEndElement();
                              // ISSUE: reference to a compiler-generated field
                              if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.DuctType, "", false) > 0U)
                              {
                                xmlTextWriter.WriteStartElement("SAP:Mechanical-Vent-Duct-Insulation");
                                // ISSUE: reference to a compiler-generated field
                                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.DuctType, "Insulation", false) == 0)
                                  xmlTextWriter.WriteValue(2);
                                else
                                  xmlTextWriter.WriteValue(1);
                                xmlTextWriter.WriteEndElement();
                              }
                              xmlTextWriter.WriteStartElement("SAP:Mechanical-Vent-Duct-Type");
                              // ISSUE: reference to a compiler-generated field
                              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.MVDetails.DuctingType, "Flexible", false) == 0)
                                xmlTextWriter.WriteValue(1);
                              else
                                xmlTextWriter.WriteValue(2);
                              xmlTextWriter.WriteEndElement();
                            }
                            else
                            {
                              // ISSUE: reference to a compiler-generated field
                              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.Parameters, "Database", false) == 0)
                              {
                                xmlTextWriter.WriteStartElement("SAP:Mechanical-Vent-System-Index-Number");
                                // ISSUE: reference to a compiler-generated field
                                xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.ProductID);
                                xmlTextWriter.WriteEndElement();
                                xmlTextWriter.WriteStartElement("SAP:Wet-Rooms-Count");
                                // ISSUE: reference to a compiler-generated field
                                xmlTextWriter.WriteValue(checked (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.WetRooms + 1));
                                xmlTextWriter.WriteEndElement();
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.Parameters, "SAP 2009", false) > 0U && (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.DuctType, "", false) > 0U)
                                {
                                  xmlTextWriter.WriteStartElement("SAP:Mechanical-Vent-Duct-Insulation");
                                  // ISSUE: reference to a compiler-generated field
                                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.DuctType, "Insulation", false) == 0)
                                    xmlTextWriter.WriteValue(2);
                                  else
                                    xmlTextWriter.WriteValue(1);
                                  xmlTextWriter.WriteEndElement();
                                }
                                // ISSUE: reference to a compiler-generated method
                                PCDF.Products321 products321 = SAP_Module.PCDFData.Products321s.Where<PCDF.Products321>(new Func<PCDF.Products321, bool>(closure850_2._Lambda\u0024__0)).SingleOrDefault<PCDF.Products321>();
                                xmlTextWriter.WriteStartElement("SAP:Mechanical-Vent-Duct-Type");
                                xmlTextWriter.WriteValue(products321.DuctingType);
                                xmlTextWriter.WriteEndElement();
                              }
                            }
                          }
                        }
                        else
                        {
                          xmlTextWriter.WriteStartElement("SAP:Mechanical-Ventilation-Data-Source");
                          // ISSUE: reference to a compiler-generated field
                          string parameters1 = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.Parameters;
                          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(parameters1, "User defined", false) != 0)
                          {
                            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(parameters1, "SAP 2005", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(parameters1, "SAP 2009", false) != 0)
                            {
                              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(parameters1, "Database", false) == 0)
                                xmlTextWriter.WriteValue(1);
                            }
                            else
                              xmlTextWriter.WriteValue(3);
                          }
                          else
                            xmlTextWriter.WriteValue(2);
                          xmlTextWriter.WriteEndElement();
                          bool flag4 = true;
                          // ISSUE: reference to a compiler-generated field
                          // ISSUE: reference to a compiler-generated field
                          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.Parameters, "Manufacturer Declaration", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.Parameters, "User defined", false) == 0)
                          {
                            xmlTextWriter.WriteStartElement("SAP:Mechanical-Vent-System-Make-Model");
                            // ISSUE: reference to a compiler-generated field
                            xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.MVDetails.ProductName);
                            xmlTextWriter.WriteEndElement();
                            xmlTextWriter.WriteStartElement("SAP:Mechanical-Vent-Specific-Fan-Power");
                            // ISSUE: reference to a compiler-generated field
                            xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.MVDetails.SFP);
                            xmlTextWriter.WriteEndElement();
                            xmlTextWriter.WriteStartElement("SAP:Wet-Rooms-Count");
                            // ISSUE: reference to a compiler-generated field
                            xmlTextWriter.WriteValue(checked (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.WetRooms + 1));
                            xmlTextWriter.WriteEndElement();
                            xmlTextWriter.WriteStartElement("SAP:Mechanical-Vent-Duct-Type");
                            // ISSUE: reference to a compiler-generated field
                            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.MVDetails.DuctingType, "Flexible", false) == 0)
                              xmlTextWriter.WriteValue(1);
                            else
                              xmlTextWriter.WriteValue(2);
                            xmlTextWriter.WriteEndElement();
                          }
                          // ISSUE: reference to a compiler-generated field
                          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.MechVent, "Positive input from outside", false) == 0)
                          {
                            // ISSUE: reference to a compiler-generated field
                            string parameters2 = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.Parameters;
                            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(parameters2, "SAP 2005", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(parameters2, "SAP 2009", false) != 0 && !flag4)
                            {
                              xmlTextWriter.WriteStartElement("SAP:Mechanical-Vent-System-Make-Model");
                              // ISSUE: reference to a compiler-generated field
                              xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.MVDetails.ProductName);
                              xmlTextWriter.WriteEndElement();
                              xmlTextWriter.WriteStartElement("SAP:Mechanical-Vent-Specific-Fan-Power");
                              // ISSUE: reference to a compiler-generated field
                              xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.MVDetails.SFP);
                              xmlTextWriter.WriteEndElement();
                              xmlTextWriter.WriteStartElement("SAP:Wet-Rooms-Count");
                              // ISSUE: reference to a compiler-generated field
                              // ISSUE: reference to a compiler-generated field
                              // ISSUE: reference to a compiler-generated field
                              xmlTextWriter.WriteValue(Math.Round(1.0 + (double) SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.Decentralised.OTP1 + (double) SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.Decentralised.OTP2 + (double) SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.Decentralised.OTP3, 0));
                              xmlTextWriter.WriteEndElement();
                              xmlTextWriter.WriteStartElement("SAP:Mechanical-Vent-Duct-Type");
                              // ISSUE: reference to a compiler-generated field
                              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.DuctType, "Un-Insulated", false) == 0)
                                xmlTextWriter.WriteValue(1);
                              else
                                xmlTextWriter.WriteValue(2);
                              xmlTextWriter.WriteEndElement();
                            }
                          }
                        }
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.Pressure, "Calculated", false) == 0 && SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.Infiltration.Lobby.Contains("Draught"))
                        {
                          xmlTextWriter.WriteStartElement("SAP:Has-Draught-Lobby");
                          // ISSUE: reference to a compiler-generated field
                          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.Infiltration.Lobby, "Draught Lobby", false) == 0)
                            xmlTextWriter.WriteValue(true);
                          else
                            xmlTextWriter.WriteValue(false);
                          xmlTextWriter.WriteEndElement();
                          xmlTextWriter.WriteStartElement("SAP:DraughtStripping");
                          // ISSUE: reference to a compiler-generated field
                          xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.Infiltration.DraguthP);
                          xmlTextWriter.WriteEndElement();
                        }
                        xmlTextWriter.WriteEndElement();
                        xmlTextWriter.WriteStartElement("SAP:SAP-Heating");
                        xmlTextWriter.WriteStartElement("SAP:Main-Heating-Details");
                        xmlTextWriter.WriteStartElement("SAP:Main-Heating");
                        // ISSUE: reference to a compiler-generated field
                        if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.Fuel, "", false) > 0U)
                        {
                          xmlTextWriter.WriteStartElement("SAP:Main-Heating-Number");
                          xmlTextWriter.WriteValue(1);
                          xmlTextWriter.WriteEndElement();
                        }
                        xmlTextWriter.WriteStartElement("SAP:Main-Heating-Category");
                        // ISSUE: reference to a compiler-generated field
                        if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.SAPTableCode == 0)
                        {
                          // ISSUE: reference to a compiler-generated field
                          // ISSUE: reference to a compiler-generated field
                          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.InforSource, "Boiler Database", false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.SGroup, "Micro-cogeneration (micro-CHP)", false) == 0)
                          {
                            xmlTextWriter.WriteValue(3);
                          }
                          else
                          {
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.InforSource, "Boiler Database", false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.SGroup, "Heat pumps", false) == 0 & (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.HGroup, "Warm air systems", false) > 0U)
                            {
                              xmlTextWriter.WriteValue(4);
                            }
                            else
                            {
                              // ISSUE: reference to a compiler-generated field
                              // ISSUE: reference to a compiler-generated field
                              // ISSUE: reference to a compiler-generated field
                              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.InforSource, "Boiler Database", false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.SGroup, "Heat pumps", false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.HGroup, "Warm air systems", false) == 0)
                                xmlTextWriter.WriteValue(5);
                              else
                                xmlTextWriter.WriteValue(2);
                            }
                          }
                        }
                        else
                        {
                          // ISSUE: reference to a compiler-generated field
                          int sapTableCode = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.SAPTableCode;
                          if (sapTableCode == 699)
                            xmlTextWriter.WriteValue(1);
                          else if (sapTableCode <= 200)
                            xmlTextWriter.WriteValue(2);
                          else if (sapTableCode == 1)
                            xmlTextWriter.WriteValue(3);
                          else if (sapTableCode >= 201 && sapTableCode <= 207)
                            xmlTextWriter.WriteValue(4);
                          else if (sapTableCode >= 521 && sapTableCode <= 527)
                            xmlTextWriter.WriteValue(5);
                          else if (sapTableCode >= 306 && sapTableCode <= 310)
                            xmlTextWriter.WriteValue(6);
                          else if (sapTableCode >= 401 && sapTableCode <= 408)
                            xmlTextWriter.WriteValue(7);
                          else if (sapTableCode >= 421 && sapTableCode <= 425)
                            xmlTextWriter.WriteValue(8);
                          else if (sapTableCode >= 501 && sapTableCode <= 515)
                            xmlTextWriter.WriteValue(9);
                          else if (sapTableCode >= 601 && sapTableCode <= 694)
                            xmlTextWriter.WriteValue(10);
                          else if (sapTableCode == 701)
                            xmlTextWriter.WriteValue(11);
                          else
                            xmlTextWriter.WriteValue(12);
                        }
                        xmlTextWriter.WriteEndElement();
                        // ISSUE: reference to a compiler-generated field
                        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating2.Fuel, "", false) == 0)
                        {
                          xmlTextWriter.WriteStartElement("SAP:Main-Heating-Fraction");
                          xmlTextWriter.WriteValue(1);
                          xmlTextWriter.WriteEndElement();
                        }
                        else
                        {
                          xmlTextWriter.WriteStartElement("SAP:Main-Heating-Fraction");
                          // ISSUE: reference to a compiler-generated field
                          xmlTextWriter.WriteValue(Math.Round(1.0 - (double) SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].HeatFractionSec, 2));
                          xmlTextWriter.WriteEndElement();
                        }
                        xmlTextWriter.WriteStartElement("SAP:Main-Heating-Data-Source");
                        int num30;
                        // ISSUE: reference to a compiler-generated field
                        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.InforSource, "Boiler Database", false) == 0)
                        {
                          xmlTextWriter.WriteValue("1");
                          num30 = 1;
                          // ISSUE: reference to a compiler-generated field
                          // ISSUE: reference to a compiler-generated field
                          // ISSUE: reference to a compiler-generated field
                          // ISSUE: reference to a compiler-generated field
                          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.InforSource, "Boiler Database", false) != 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.SGroup, "Gas boilers and oil boilers", false) == 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.SGroup, "Micro-cogeneration (micro-CHP)", false) == 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.SGroup, "Solid fuel boilers", false) != 0)
                            ;
                        }
                        else
                        {
                          // ISSUE: reference to a compiler-generated field
                          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.InforSource, "Manufacturer Declaration", false) == 0)
                          {
                            xmlTextWriter.WriteValue("2");
                            num30 = 2;
                          }
                          else
                          {
                            xmlTextWriter.WriteValue("3");
                            num30 = 3;
                          }
                        }
                        xmlTextWriter.WriteEndElement();
                        // ISSUE: reference to a compiler-generated field
                        int sapTableCode1 = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.SAPTableCode;
                        if (sapTableCode1 >= 151 && sapTableCode1 <= 161 || sapTableCode1 >= 631 && sapTableCode1 <= 636)
                        {
                          xmlTextWriter.WriteStartElement("SAP:Is-Main-Heating-HETAS-Approved");
                          // ISSUE: reference to a compiler-generated field
                          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.HETAS, "Yes", false) == 0)
                            xmlTextWriter.WriteValue("true");
                          else
                            xmlTextWriter.WriteValue("false");
                          xmlTextWriter.WriteEndElement();
                        }
                        if (num30 == 3)
                        {
                          // ISSUE: reference to a compiler-generated field
                          int sapTableCode2 = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.SAPTableCode;
                          if (sapTableCode2 < 306 || sapTableCode2 > 310)
                          {
                            xmlTextWriter.WriteStartElement("SAP:Main-Heating-Code");
                            // ISSUE: reference to a compiler-generated field
                            xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.SAPTableCode);
                            xmlTextWriter.WriteEndElement();
                          }
                        }
                        else if (num30 == 2)
                        {
                          xmlTextWriter.WriteStartElement("SAP:Main-Heating-Make-Model");
                          // ISSUE: reference to a compiler-generated field
                          xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.Boiler.Description);
                          xmlTextWriter.WriteEndElement();
                        }
                        if (num30 == 1)
                        {
                          xmlTextWriter.WriteStartElement("SAP:Boiler-Index-Number");
                          // ISSUE: reference to a compiler-generated field
                          xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.SEDBUK);
                          xmlTextWriter.WriteEndElement();
                        }
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.InforSource, "Manufacturer Declaration", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.InforSource, "Boiler Database", false) == 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.SGroup, "Solid fuel boilers", false) == 0)
                        {
                          // ISSUE: reference to a compiler-generated field
                          switch (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.SAPTableCode)
                          {
                            case 0:
                            case 153:
                              xmlTextWriter.WriteStartElement("SAP:Boiler-Fuel-Feed");
                              xmlTextWriter.WriteValue(1);
                              xmlTextWriter.WriteEndElement();
                              break;
                          }
                        }
                        if (num30 == 2)
                        {
                          // ISSUE: reference to a compiler-generated field
                          if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.TableGroup != 3)
                          {
                            xmlTextWriter.WriteStartElement("SAP:Main-Heating-Efficiency");
                            // ISSUE: reference to a compiler-generated field
                            xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.MainEff);
                            xmlTextWriter.WriteEndElement();
                          }
                          // ISSUE: reference to a compiler-generated field
                          int sapTableCode3 = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.SAPTableCode;
                          if (sapTableCode3 < 306 || sapTableCode3 > 310)
                          {
                            xmlTextWriter.WriteStartElement("SAP:Efficiency-Type");
                            // ISSUE: reference to a compiler-generated field
                            if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.SEDBUK2005)
                            {
                              xmlTextWriter.WriteValue(2);
                            }
                            else
                            {
                              // ISSUE: reference to a compiler-generated field
                              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.SEDBUK, "", false) == 0)
                              {
                                xmlTextWriter.WriteValue(3);
                              }
                              else
                              {
                                // ISSUE: reference to a compiler-generated field
                                if (Conversions.ToBoolean(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.SEDBUK))
                                  xmlTextWriter.WriteValue(4);
                                else
                                  xmlTextWriter.WriteValue(1);
                              }
                            }
                            xmlTextWriter.WriteEndElement();
                          }
                          // ISSUE: reference to a compiler-generated field
                          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.SGroup, "Solid fuel boilers", false) == 0)
                          {
                            // ISSUE: reference to a compiler-generated field
                            switch (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.SAPTableCode)
                            {
                              case 151:
                              case 152:
                              case 153:
                              case 154:
                              case 155:
                              case 161:
                                xmlTextWriter.WriteStartElement("SAP:Solid-Fuel-Boiler-Type");
                                xmlTextWriter.WriteValue(1);
                                xmlTextWriter.WriteEndElement();
                                break;
                              case 156:
                              case 160:
                                xmlTextWriter.WriteStartElement("SAP:Solid-Fuel-Boiler-Type");
                                xmlTextWriter.WriteValue(2);
                                xmlTextWriter.WriteEndElement();
                                break;
                              case 158:
                              case 159:
                                xmlTextWriter.WriteStartElement("SAP:Solid-Fuel-Boiler-Type");
                                xmlTextWriter.WriteValue(3);
                                xmlTextWriter.WriteEndElement();
                                break;
                            }
                          }
                          // ISSUE: reference to a compiler-generated field
                          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.InforSource, "Manufacturer Declaration", false) == 0)
                          {
                            // ISSUE: reference to a compiler-generated field
                            if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.MHType.Contains("ondens"))
                            {
                              xmlTextWriter.WriteStartElement("SAP:Is-Condensing-Boiler");
                              // ISSUE: reference to a compiler-generated field
                              if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.MHType.Contains("non-"))
                                xmlTextWriter.WriteValue("false");
                              else
                                xmlTextWriter.WriteValue("true");
                              xmlTextWriter.WriteEndElement();
                            }
                            else
                            {
                              // ISSUE: reference to a compiler-generated field
                              if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.SAPTableCode == 134)
                              {
                                xmlTextWriter.WriteStartElement("SAP:Is-Condensing-Boiler");
                                xmlTextWriter.WriteValue("true");
                                xmlTextWriter.WriteEndElement();
                              }
                            }
                          }
                          // ISSUE: reference to a compiler-generated field
                          int sapTableCode4 = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.SAPTableCode;
                          int num31;
                          switch (sapTableCode4)
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
                              num31 = 1;
                              break;
                            default:
                              num31 = sapTableCode4 == 132 ? 1 : 0;
                              break;
                          }
                          if (num31 != 0)
                          {
                            xmlTextWriter.WriteStartElement("SAP:Gas-Or-Oil-Boiler-Type");
                            xmlTextWriter.WriteValue("1");
                            xmlTextWriter.WriteEndElement();
                          }
                          else if (sapTableCode4 == 103 || sapTableCode4 == 104 || sapTableCode4 == 107 || sapTableCode4 == 108 || sapTableCode4 == 112 || sapTableCode4 == 113 || sapTableCode4 == 118 || sapTableCode4 == 128 || sapTableCode4 == 129 || sapTableCode4 == 130)
                          {
                            xmlTextWriter.WriteStartElement("SAP:Gas-Or-Oil-Boiler-Type");
                            xmlTextWriter.WriteValue("2");
                            xmlTextWriter.WriteEndElement();
                          }
                          else if (sapTableCode4 >= 120 && sapTableCode4 <= 123)
                          {
                            xmlTextWriter.WriteStartElement("SAP:Gas-Or-Oil-Boiler-Type");
                            xmlTextWriter.WriteValue("3");
                            xmlTextWriter.WriteEndElement();
                          }
                          else if (sapTableCode4 >= 133 && sapTableCode4 <= 141)
                          {
                            xmlTextWriter.WriteStartElement("SAP:Gas-Or-Oil-Boiler-Type");
                            xmlTextWriter.WriteValue("4");
                            xmlTextWriter.WriteEndElement();
                          }
                          // ISSUE: reference to a compiler-generated field
                          switch (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.SAPTableCode)
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
                              xmlTextWriter.WriteStartElement("SAP:Combi-Boiler-Type");
                              // ISSUE: reference to a compiler-generated field
                              string combiType = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.CombiType;
                              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(combiType, "Instantaneous Combi", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(combiType, "", false) != 0)
                              {
                                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(combiType, "Storage combi boiler, primary store", false) != 0)
                                {
                                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(combiType, "Storage combi boiler, secondary store", false) == 0)
                                    xmlTextWriter.WriteValue("3");
                                }
                                else
                                  xmlTextWriter.WriteValue("2");
                              }
                              else
                              {
                                // ISSUE: reference to a compiler-generated field
                                if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.Boiler.IncludeKeepHot)
                                {
                                  // ISSUE: reference to a compiler-generated field
                                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.Boiler.KeepHotFuel, "Main Fuel", false) == 0)
                                  {
                                    // ISSUE: reference to a compiler-generated field
                                    if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.Boiler.KeepHotTimed)
                                      xmlTextWriter.WriteValue("6");
                                    else
                                      xmlTextWriter.WriteValue("5");
                                  }
                                  else
                                  {
                                    // ISSUE: reference to a compiler-generated field
                                    if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.Boiler.KeepHotTimed)
                                      xmlTextWriter.WriteValue("8");
                                    else
                                      xmlTextWriter.WriteValue("7");
                                  }
                                }
                                else
                                  xmlTextWriter.WriteValue("1");
                              }
                              xmlTextWriter.WriteEndElement();
                              break;
                            case 120:
                            case 122:
                            case 123:
                              xmlTextWriter.WriteStartElement("SAP:Combi-Boiler-Type");
                              xmlTextWriter.WriteValue("4");
                              xmlTextWriter.WriteEndElement();
                              break;
                            case 121:
                              xmlTextWriter.WriteStartElement("SAP:Combi-Boiler-Type");
                              xmlTextWriter.WriteValue("1");
                              xmlTextWriter.WriteEndElement();
                              break;
                            case 134:
                            case 139:
                              // ISSUE: reference to a compiler-generated field
                              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.InforSource, "Manufacturer Declaration", false) == 0)
                              {
                                xmlTextWriter.WriteStartElement("SAP:Case-Heat-Emission");
                                // ISSUE: reference to a compiler-generated field
                                xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.Range.CasekW);
                                xmlTextWriter.WriteEndElement();
                                xmlTextWriter.WriteStartElement("SAP:Heat-Transfer-To-Water");
                                // ISSUE: reference to a compiler-generated field
                                xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.Range.WaterkW);
                                xmlTextWriter.WriteEndElement();
                                break;
                              }
                              break;
                          }
                        }
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.SGroup, "Gas boilers and oil boilers", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.SGroup, "Micro-cogeneration (micro-CHP)", false) == 0)
                        {
                          // ISSUE: reference to a compiler-generated field
                          switch (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.SAPTableCode)
                          {
                            case 102:
                            case 104:
                            case 121:
                            case (int) sbyte.MaxValue:
                            case 130:
                            case 134:
                              xmlTextWriter.WriteStartElement("SAP:Burner-Control");
                              xmlTextWriter.WriteValue("3");
                              xmlTextWriter.WriteEndElement();
                              break;
                          }
                        }
                        else
                        {
                          // ISSUE: reference to a compiler-generated field
                          // ISSUE: reference to a compiler-generated field
                          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.SGroup, "Heat pumps", false) != 0 && (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.FuelBurningType, "", false) > 0U)
                          {
                            xmlTextWriter.WriteStartElement("SAP:Burner-Control");
                            // ISSUE: reference to a compiler-generated field
                            string fuelBurningType = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.FuelBurningType;
                            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuelBurningType, "Unknown", false) != 0)
                            {
                              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuelBurningType, "On/off", false) != 0)
                              {
                                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuelBurningType, "Modulation", false) != 0)
                                {
                                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuelBurningType, "electrical", false) != 0)
                                  {
                                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuelBurningType, "manual", false) == 0)
                                      xmlTextWriter.WriteValue("5");
                                  }
                                  else
                                    xmlTextWriter.WriteValue("4");
                                }
                                else
                                  xmlTextWriter.WriteValue("3");
                              }
                              else
                                xmlTextWriter.WriteValue("2");
                            }
                            else
                              xmlTextWriter.WriteValue("1");
                            xmlTextWriter.WriteEndElement();
                          }
                        }
                        // ISSUE: reference to a compiler-generated field
                        if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.TableGroup != 3)
                        {
                          xmlTextWriter.WriteStartElement("SAP:Main-Fuel-Type");
                          // ISSUE: reference to a compiler-generated field
                          // ISSUE: reference to a compiler-generated field
                          xmlTextWriter.WriteValue(this.FuelCheck(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.Fuel, closure850_2.\u0024VB\u0024Local_House));
                          xmlTextWriter.WriteEndElement();
                        }
                        xmlTextWriter.WriteStartElement("SAP:Main-Heating-Control");
                        // ISSUE: reference to a compiler-generated field
                        xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.ControlCode);
                        xmlTextWriter.WriteEndElement();
                        // ISSUE: reference to a compiler-generated field
                        if (!string.IsNullOrEmpty(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.Emitter))
                        {
                          xmlTextWriter.WriteStartElement("SAP:Heat-Emitter-Type");
                          // ISSUE: reference to a compiler-generated field
                          string emitter1 = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.Emitter;
                          // ISSUE: reference to a compiler-generated method
                          switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(emitter1))
                          {
                            case 83421456:
                              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter1, "Underfloor heating and radiators, pipes in concrete slab", false) == 0)
                              {
                                xmlTextWriter.WriteValue(3);
                                xmlTextWriter.WriteEndElement();
                                xmlTextWriter.WriteStartElement("SAP:Underfloor-Heat-Emitter-Type");
                                xmlTextWriter.WriteValue(1);
                                xmlTextWriter.WriteEndElement();
                                goto label_1296;
                              }
                              else
                                goto default;
                            case 1150666285:
                              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter1, "Underfloor heating and radiators, pipes in insulated timber floor", false) == 0)
                              {
                                xmlTextWriter.WriteValue(3);
                                xmlTextWriter.WriteEndElement();
                                xmlTextWriter.WriteStartElement("SAP:Underfloor-Heat-Emitter-Type");
                                // ISSUE: reference to a compiler-generated field
                                string emitter2 = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.Emitter;
                                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter2, "Underfloor heating, pipes in insulated timber floor", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter2, "Underfloor heating and radiators, pipes in insulated timber floor", false) != 0)
                                {
                                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter2, "Underfloor heating, pipes in screed above insulation", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter2, "Underfloor heating and radiators, pipes in screed above insulation", false) != 0)
                                  {
                                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter2, "Underfloor heating, pipes in concrete slab", false) == 0)
                                    {
                                      xmlTextWriter.WriteValue(1);
                                      xmlTextWriter.WriteEndElement();
                                      goto label_1296;
                                    }
                                    else
                                      goto label_1296;
                                  }
                                  else
                                  {
                                    xmlTextWriter.WriteValue(2);
                                    xmlTextWriter.WriteEndElement();
                                    goto label_1296;
                                  }
                                }
                                else
                                {
                                  xmlTextWriter.WriteValue(3);
                                  xmlTextWriter.WriteEndElement();
                                  goto label_1296;
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
                                xmlTextWriter.WriteValue(2);
                                xmlTextWriter.WriteEndElement();
                                xmlTextWriter.WriteStartElement("SAP:Underfloor-Heat-Emitter-Type");
                                xmlTextWriter.WriteValue(2);
                                xmlTextWriter.WriteEndElement();
                                goto label_1296;
                              }
                              else
                                goto default;
                            case 2395580722:
                              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter1, "Underfloor heating and radiators, pipes in screed above insulation", false) == 0)
                              {
                                xmlTextWriter.WriteValue(3);
                                xmlTextWriter.WriteEndElement();
                                xmlTextWriter.WriteStartElement("SAP:Underfloor-Heat-Emitter-Type");
                                // ISSUE: reference to a compiler-generated field
                                string emitter3 = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.Emitter;
                                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter3, "Underfloor heating, pipes in insulated timber floor", false) != 0)
                                {
                                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter3, "Underfloor heating, pipes in screed above insulation", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter3, "Underfloor heating and radiators, pipes in insulated timber floor", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter3, "Underfloor heating and radiators, pipes in screed above insulation", false) != 0)
                                  {
                                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter3, "Underfloor heating, pipes in concrete slab", false) == 0)
                                      xmlTextWriter.WriteValue(1);
                                    else
                                      xmlTextWriter.WriteValue(2);
                                  }
                                  else
                                    xmlTextWriter.WriteValue(2);
                                }
                                else
                                  xmlTextWriter.WriteValue(3);
                                xmlTextWriter.WriteEndElement();
                                goto label_1296;
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
                                xmlTextWriter.WriteValue(1);
                                xmlTextWriter.WriteEndElement();
                                goto label_1296;
                              }
                              else
                                goto default;
                            case 3146736266:
                              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter1, "Fan coil units", false) == 0)
                              {
                                xmlTextWriter.WriteValue(4);
                                xmlTextWriter.WriteEndElement();
                                xmlTextWriter.WriteStartElement("SAP:Underfloor-Heat-Emitter-Type");
                                // ISSUE: reference to a compiler-generated field
                                string emitter4 = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.Emitter;
                                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter4, "Underfloor heating, pipes in insulated timber floor", false) != 0)
                                {
                                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter4, "Underfloor heating, pipes in screed above insulation", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter4, "Underfloor heating and radiators, pipes in insulated timber floor", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter4, "Underfloor heating and radiators, pipes in screed above insulation", false) != 0)
                                  {
                                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter4, "Underfloor heating, pipes in concrete slab", false) == 0)
                                      xmlTextWriter.WriteValue(1);
                                    else
                                      xmlTextWriter.WriteValue(2);
                                  }
                                  else
                                    xmlTextWriter.WriteValue(2);
                                }
                                else
                                  xmlTextWriter.WriteValue(3);
                                xmlTextWriter.WriteEndElement();
                                goto label_1296;
                              }
                              else
                                goto default;
                            default:
                              xmlTextWriter.WriteValue(1);
                              xmlTextWriter.WriteEndElement();
                              goto label_1296;
                          }
                          xmlTextWriter.WriteValue(2);
                          xmlTextWriter.WriteEndElement();
                          xmlTextWriter.WriteStartElement("SAP:Underfloor-Heat-Emitter-Type");
                          // ISSUE: reference to a compiler-generated field
                          string emitter5 = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.Emitter;
                          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter5, "Underfloor heating, pipes in insulated timber floor", false) != 0)
                          {
                            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter5, "Underfloor heating, pipes in screed above insulation", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter5, "Underfloor heating and radiators, pipes in insulated timber floor", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter5, "Underfloor heating and radiators, pipes in screed above insulation", false) != 0)
                            {
                              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter5, "Systems with radiators", false) == 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter5, "Underfloor heating, pipes in concrete slab", false) == 0)
                                xmlTextWriter.WriteValue(1);
                              else
                                xmlTextWriter.WriteValue(2);
                            }
                            else
                              xmlTextWriter.WriteValue(2);
                          }
                          else
                            xmlTextWriter.WriteValue(3);
                          xmlTextWriter.WriteEndElement();
label_1296:;
                        }
                        if (num30 == 1)
                        {
                          // ISSUE: reference to a compiler-generated field
                          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.SGroup, "Micro-cogeneration (micro-CHP)", false) == 0)
                          {
                            // ISSUE: reference to a compiler-generated method
                            this.SearchRowCHP = SAP_Module.PCDFData.CHPs.Where<PCDF.CHP>(new Func<PCDF.CHP, bool>(closure850_2._Lambda\u0024__2)).SingleOrDefault<PCDF.CHP>();
                            xmlTextWriter.WriteStartElement("SAP:Main-Heating-Flue-Type");
                            xmlTextWriter.WriteValue(this.SearchRowCHP.Flue_Type);
                            xmlTextWriter.WriteEndElement();
                            xmlTextWriter.WriteStartElement("SAP:Is-Flue-Fan-Present");
                            xmlTextWriter.WriteValue("false");
                            xmlTextWriter.WriteEndElement();
                          }
                          else
                          {
                            // ISSUE: reference to a compiler-generated field
                            if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.SGroup, "Heat pumps", false) > 0U)
                            {
                              xmlTextWriter.WriteStartElement("SAP:Main-Heating-Flue-Type");
                              // ISSUE: reference to a compiler-generated method
                              this.SearchBoilerRow = SAP_Module.PCDFData.Boilers.Where<PCDF.SEDBUK>(new Func<PCDF.SEDBUK, bool>(closure850_2._Lambda\u0024__3)).SingleOrDefault<PCDF.SEDBUK>();
                              if (this.SearchBoilerRow != null)
                              {
                                xmlTextWriter.WriteValue(1);
                                xmlTextWriter.WriteEndElement();
                              }
                              else
                              {
                                if (Information.IsDBNull((object) this.SearchBoilerRow.FlueType))
                                  xmlTextWriter.WriteValue(1);
                                else
                                  xmlTextWriter.WriteValue(this.SearchBoilerRow.FlueType);
                                xmlTextWriter.WriteEndElement();
                              }
                              xmlTextWriter.WriteStartElement("SAP:Is-Flue-Fan-Present");
                              if (this.SearchBoilerRow != null)
                              {
                                xmlTextWriter.WriteValue("false");
                                xmlTextWriter.WriteEndElement();
                              }
                              else
                              {
                                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(!Information.IsDBNull((object) this.SearchBoilerRow.FanAssist) ? this.SearchBoilerRow.FanAssist : this.SearchBoilerRow.FanAssist, "2", false) == 0)
                                  xmlTextWriter.WriteValue("true");
                                else
                                  xmlTextWriter.WriteValue("false");
                                xmlTextWriter.WriteEndElement();
                              }
                            }
                          }
                        }
                        else
                        {
                          // ISSUE: reference to a compiler-generated field
                          int sapTableCode5 = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.SAPTableCode;
                          if (sapTableCode5 == 631)
                          {
                            xmlTextWriter.WriteStartElement("SAP:Main-Heating-Flue-Type");
                            xmlTextWriter.WriteValue(3);
                            xmlTextWriter.WriteEndElement();
                            xmlTextWriter.WriteStartElement("SAP:Is-Flue-Fan-Present");
                            // ISSUE: reference to a compiler-generated field
                            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.Boiler.FanFlued, "Yes", false) == 0)
                              xmlTextWriter.WriteValue("true");
                            else
                              xmlTextWriter.WriteValue("false");
                            xmlTextWriter.WriteEndElement();
                          }
                          else
                          {
                            // ISSUE: reference to a compiler-generated field
                            if ((sapTableCode5 < 300 || sapTableCode5 >= 501 && sapTableCode5 <= 527) && (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.Fuel, "Electricity", false) > 0U)
                            {
                              xmlTextWriter.WriteStartElement("SAP:Main-Heating-Flue-Type");
                              // ISSUE: reference to a compiler-generated field
                              string flueType = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.Boiler.FlueType;
                              // ISSUE: reference to a compiler-generated method
                              switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(flueType))
                              {
                                case 572081497:
                                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(flueType, "omitted", false) == 0)
                                  {
                                    xmlTextWriter.WriteValue(4);
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
                                    goto label_1332;
                                  else
                                    goto default;
                                case 1537289947:
                                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(flueType, "open flue", false) == 0)
                                    break;
                                  goto default;
                                case 1708018833:
                                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(flueType, "Room-sealed", false) == 0)
                                    goto label_1332;
                                  else
                                    goto default;
                                case 1845819738:
                                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(flueType, "unknown (there is a flue, but its type could not be determined)", false) == 0)
                                    goto label_1335;
                                  else
                                    goto default;
                                case 2166136261:
                                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(flueType, "", false) == 0)
                                    goto label_1335;
                                  else
                                    goto default;
                                case 2391940020:
                                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(flueType, "Chimney", false) == 0)
                                  {
                                    xmlTextWriter.WriteValue(3);
                                    goto default;
                                  }
                                  else
                                    goto default;
                                case 3424652889:
                                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(flueType, "Unknown", false) == 0)
                                    goto label_1335;
                                  else
                                    goto default;
                                default:
label_1336:
                                  xmlTextWriter.WriteEndElement();
                                  xmlTextWriter.WriteStartElement("SAP:Is-Flue-Fan-Present");
                                  // ISSUE: reference to a compiler-generated field
                                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.Boiler.FanFlued, "Yes", false) == 0)
                                    xmlTextWriter.WriteValue("true");
                                  else
                                    xmlTextWriter.WriteValue("false");
                                  xmlTextWriter.WriteEndElement();
                                  goto label_1340;
                              }
                              xmlTextWriter.WriteValue(1);
                              goto label_1336;
label_1332:
                              xmlTextWriter.WriteValue(2);
                              goto label_1336;
label_1335:
                              xmlTextWriter.WriteValue(5);
                              goto label_1336;
                            }
                          }
label_1340:;
                        }
                        // ISSUE: reference to a compiler-generated field
                        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.InforSource, "Boiler Database", false) == 0)
                        {
                          // ISSUE: reference to a compiler-generated field
                          if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.TableGroup != 3)
                          {
                            xmlTextWriter.WriteStartElement("SAP:Is-Central-Heating-Pump-In-Heated-Space");
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.SGroup, "Heat pumps", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.SGroup, "Micro-cogeneration (micro-CHP)", false) == 0)
                            {
                              xmlTextWriter.WriteValue("true");
                            }
                            else
                            {
                              // ISSUE: reference to a compiler-generated field
                              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.Boiler.PumpHP, "Yes", false) == 0)
                                xmlTextWriter.WriteValue("true");
                              else
                                xmlTextWriter.WriteValue("false");
                            }
                            xmlTextWriter.WriteEndElement();
                          }
                          // ISSUE: reference to a compiler-generated field
                          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.SGroup, "Gas boilers and oil boilers", false) == 0)
                          {
                            xmlTextWriter.WriteStartElement("SAP:Is-Interlocked-System");
                            // ISSUE: reference to a compiler-generated field
                            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.Boiler.BILock, "Yes", false) == 0)
                              xmlTextWriter.WriteValue("true");
                            else
                              xmlTextWriter.WriteValue("false");
                            xmlTextWriter.WriteEndElement();
                          }
                        }
                        else
                        {
                          // ISSUE: reference to a compiler-generated field
                          if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.TableGroup != 3)
                          {
                            // ISSUE: reference to a compiler-generated field
                            int sapTableCode6 = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.SAPTableCode;
                            if (sapTableCode6 >= 101 && sapTableCode6 <= 310 || sapTableCode6 == 602 || sapTableCode6 == 604 || sapTableCode6 == 606)
                            {
                              xmlTextWriter.WriteStartElement("SAP:Is-Central-Heating-Pump-In-Heated-Space");
                              // ISSUE: reference to a compiler-generated field
                              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.Boiler.PumpHP, "Yes", false) == 0)
                                xmlTextWriter.WriteValue("true");
                              else
                                xmlTextWriter.WriteValue("false");
                              xmlTextWriter.WriteEndElement();
                            }
                          }
                          // ISSUE: reference to a compiler-generated field
                          int sapTableCode7 = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.SAPTableCode;
                          if (sapTableCode7 >= 1 && sapTableCode7 <= 149)
                          {
                            xmlTextWriter.WriteStartElement("SAP:Is-Interlocked-System");
                            // ISSUE: reference to a compiler-generated field
                            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.Boiler.BILock, "Yes", false) == 0)
                              xmlTextWriter.WriteValue("true");
                            else
                              xmlTextWriter.WriteValue("false");
                            xmlTextWriter.WriteEndElement();
                          }
                        }
                        // ISSUE: reference to a compiler-generated field
                        if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.SAPTableCode < 200)
                        {
                          // ISSUE: reference to a compiler-generated field
                          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.Fuel, "heating oil", false) == 0)
                          {
                            xmlTextWriter.WriteStartElement("SAP:Is-Oil-Pump-In-Heated-Space");
                            // ISSUE: reference to a compiler-generated field
                            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.Boiler.PumpHP, "Yes", false) == 0)
                              xmlTextWriter.WriteValue("true");
                            else
                              xmlTextWriter.WriteValue("false");
                            xmlTextWriter.WriteEndElement();
                          }
                          else
                          {
                            // ISSUE: reference to a compiler-generated field
                            if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.OilPump)
                            {
                              xmlTextWriter.WriteStartElement("SAP:Is-Oil-Pump-In-Heated-Space");
                              xmlTextWriter.WriteValue("true");
                              xmlTextWriter.WriteEndElement();
                            }
                          }
                        }
                        // ISSUE: reference to a compiler-generated field
                        switch (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.ControlCode)
                        {
                          case 2101:
                          case 2102:
                          case 2103:
                          case 2104:
                          case 2105:
                          case 2106:
                          case 2107:
                          case 2108:
                          case 2109:
                          case 2110:
                          case 2111:
                          case 2202:
                          case 2205:
                          case 2206:
                          case 2207:
                            xmlTextWriter.WriteStartElement("SAP:Has-Delayed-Start-Thermostat");
                            // ISSUE: reference to a compiler-generated field
                            xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.DelayedStart);
                            xmlTextWriter.WriteEndElement();
                            break;
                        }
                        if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SAPTableCode < 300)
                        {
                          // ISSUE: reference to a compiler-generated field
                          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.SGroup, "Heat pumps", false) == 0)
                          {
                            // ISSUE: reference to a compiler-generated field
                            if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.Boiler.LoadWeather)
                            {
                              xmlTextWriter.WriteStartElement("SAP:Load-Or-Weather-Compensation");
                              // ISSUE: reference to a compiler-generated field
                              string compensator = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.Compensator;
                              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(compensator, "Weather Compensation", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(compensator, "Weather Compensator", false) != 0)
                              {
                                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(compensator, "Load Compensation", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(compensator, "Load compensator", false) != 0)
                                {
                                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(compensator, "Enhanced Load Compensator", false) == 0)
                                    xmlTextWriter.WriteValue(3);
                                  else
                                    xmlTextWriter.WriteValue(0);
                                }
                                else
                                  xmlTextWriter.WriteValue(1);
                              }
                              else
                                xmlTextWriter.WriteValue(2);
                              xmlTextWriter.WriteEndElement();
                            }
                          }
                          else
                          {
                            xmlTextWriter.WriteStartElement("SAP:Load-Or-Weather-Compensation");
                            // ISSUE: reference to a compiler-generated field
                            if (!SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.Boiler.LoadWeather)
                            {
                              // ISSUE: reference to a compiler-generated field
                              string compensator = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.Compensator;
                              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(compensator, "Weather Compensation", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(compensator, "Weather Compensator", false) != 0)
                              {
                                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(compensator, "Load Compensation", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(compensator, "Load compensator", false) != 0)
                                {
                                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(compensator, "Enhanced Load Compensator", false) == 0)
                                    xmlTextWriter.WriteValue(3);
                                  else
                                    xmlTextWriter.WriteValue(0);
                                }
                                else
                                  xmlTextWriter.WriteValue(1);
                              }
                              else
                                xmlTextWriter.WriteValue(2);
                              xmlTextWriter.WriteEndElement();
                            }
                            else
                            {
                              // ISSUE: reference to a compiler-generated field
                              string loadWeatherType = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.Boiler.LoadWeatherType;
                              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(loadWeatherType, "Weather Compensation", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(loadWeatherType, "Weather Compensator", false) != 0)
                              {
                                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(loadWeatherType, "Load Compensation", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(loadWeatherType, "Load compensator", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(loadWeatherType, "Load Compensator", false) != 0)
                                {
                                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(loadWeatherType, "Enhanced Load Compensator", false) == 0)
                                    xmlTextWriter.WriteValue(3);
                                }
                                else
                                  xmlTextWriter.WriteValue(1);
                              }
                              else
                                xmlTextWriter.WriteValue(2);
                              xmlTextWriter.WriteEndElement();
                            }
                          }
                        }
                        // ISSUE: reference to a compiler-generated field
                        if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.SAPTableCode == 192)
                        {
                          xmlTextWriter.WriteStartElement("SAP:Electric-CPSU-Operating-Temperature");
                          // ISSUE: reference to a compiler-generated field
                          xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.CPSUTemp);
                          xmlTextWriter.WriteEndElement();
                        }
                        // ISSUE: reference to a compiler-generated field
                        if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.FGHRS.Include)
                        {
                          xmlTextWriter.WriteStartElement("SAP:Has-FGHRS");
                          // ISSUE: reference to a compiler-generated field
                          xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.FGHRS.Include);
                          xmlTextWriter.WriteEndElement();
                          xmlTextWriter.WriteStartElement("SAP:FGHRS-Index-Number");
                          // ISSUE: reference to a compiler-generated field
                          xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.FGHRS.IndexNo);
                          xmlTextWriter.WriteEndElement();
                          // ISSUE: reference to a compiler-generated field
                          if ((double) SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.FGHRS.PV.PPower > 0.0)
                          {
                            xmlTextWriter.WriteStartElement("SAP:FGHRS-Energy-Source");
                            xmlTextWriter.WriteStartElement("SAP:PV-Arrays");
                            xmlTextWriter.WriteStartElement("SAP:PV-Array");
                            xmlTextWriter.WriteStartElement("SAP:Peak-Power");
                            // ISSUE: reference to a compiler-generated field
                            xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.FGHRS.PV.PPower);
                            xmlTextWriter.WriteEndElement();
                            xmlTextWriter.WriteStartElement("SAP:Orientation");
                            // ISSUE: reference to a compiler-generated field
                            string pcOrientation = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.FGHRS.PV.PCOrientation;
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
                                  xmlTextWriter.WriteValue(2);
                                  goto default;
                                }
                                else
                                  goto default;
                              case 1409318971:
                                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(pcOrientation, "North West", false) == 0)
                                  goto label_1429;
                                else
                                  goto default;
                              case 1682370166:
                                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(pcOrientation, "NE/NW", false) == 0)
                                  goto label_1429;
                                else
                                  goto default;
                              case 1731397980:
                                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(pcOrientation, "East", false) == 0)
                                  goto label_1426;
                                else
                                  goto default;
                              case 1734234020:
                                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(pcOrientation, "North", false) == 0)
                                {
                                  xmlTextWriter.WriteValue(1);
                                  goto default;
                                }
                                else
                                  goto default;
                              case 1796576718:
                                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(pcOrientation, "West", false) == 0)
                                {
                                  xmlTextWriter.WriteValue(7);
                                  goto default;
                                }
                                else
                                  goto default;
                              case 2417407149:
                                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(pcOrientation, "South West", false) == 0)
                                {
                                  xmlTextWriter.WriteValue(6);
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
                                  xmlTextWriter.WriteValue(5);
                                  goto default;
                                }
                                else
                                  goto default;
                              case 4260797214:
                                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(pcOrientation, "E/W", false) == 0)
                                  goto label_1426;
                                else
                                  goto default;
                              default:
label_1431:
                                xmlTextWriter.WriteEndElement();
                                xmlTextWriter.WriteStartElement("SAP:Pitch");
                                // ISSUE: reference to a compiler-generated field
                                string ptilt = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.FGHRS.PV.PTilt;
                                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(ptilt, "Horizontal", false) != 0)
                                {
                                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(ptilt, "30°", false) != 0)
                                  {
                                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(ptilt, "45°", false) != 0)
                                    {
                                      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(ptilt, "60°", false) != 0)
                                      {
                                        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(ptilt, "Vertical", false) == 0)
                                          xmlTextWriter.WriteValue(5);
                                      }
                                      else
                                        xmlTextWriter.WriteValue(4);
                                    }
                                    else
                                      xmlTextWriter.WriteValue(3);
                                  }
                                  else
                                    xmlTextWriter.WriteValue(2);
                                }
                                else
                                  xmlTextWriter.WriteValue(1);
                                xmlTextWriter.WriteEndElement();
                                xmlTextWriter.WriteStartElement("SAP:Overshading");
                                // ISSUE: reference to a compiler-generated field
                                string povershading = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.FGHRS.PV.POvershading;
                                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(povershading, "Heavy", false) != 0)
                                {
                                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(povershading, "Significant", false) != 0)
                                  {
                                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(povershading, "Modest", false) != 0)
                                    {
                                      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(povershading, "None or very little", false) == 0)
                                        xmlTextWriter.WriteValue(1);
                                    }
                                    else
                                      xmlTextWriter.WriteValue(2);
                                  }
                                  else
                                    xmlTextWriter.WriteValue(3);
                                }
                                else
                                  xmlTextWriter.WriteValue(4);
                                xmlTextWriter.WriteEndElement();
                                xmlTextWriter.WriteEndElement();
                                xmlTextWriter.WriteEndElement();
                                xmlTextWriter.WriteStartElement("SAP:Wind-Turbines-Count");
                                // ISSUE: reference to a compiler-generated field
                                xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Renewable.WindTurbine.WNumber);
                                xmlTextWriter.WriteEndElement();
                                xmlTextWriter.WriteStartElement("SAP:Electricity-Tariff");
                                xmlTextWriter.WriteValue("ND");
                                xmlTextWriter.WriteEndElement();
                                xmlTextWriter.WriteEndElement();
                                goto label_1450;
                            }
                            xmlTextWriter.WriteValue(4);
                            goto label_1431;
label_1426:
                            xmlTextWriter.WriteValue(3);
                            goto label_1431;
label_1429:
                            xmlTextWriter.WriteValue(8);
                            goto label_1431;
                          }
label_1450:;
                        }
                        xmlTextWriter.WriteEndElement();
                        // ISSUE: reference to a compiler-generated field
                        if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].IncludeMainHeating2)
                        {
                          xmlTextWriter.WriteStartElement("SAP:Main-Heating");
                          xmlTextWriter.WriteStartElement("SAP:Main-Heating-Number");
                          xmlTextWriter.WriteValue(2);
                          xmlTextWriter.WriteEndElement();
                          xmlTextWriter.WriteStartElement("SAP:Main-Heating-Category");
                          // ISSUE: reference to a compiler-generated field
                          if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating2.SAPTableCode == 0)
                          {
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating2.InforSource, "Boiler Database", false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating2.SGroup, "Micro-cogeneration (micro-CHP)", false) == 0)
                            {
                              xmlTextWriter.WriteValue(3);
                            }
                            else
                            {
                              // ISSUE: reference to a compiler-generated field
                              // ISSUE: reference to a compiler-generated field
                              // ISSUE: reference to a compiler-generated field
                              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating2.InforSource, "Boiler Database", false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating2.SGroup, "Heat pumps", false) == 0 & (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating2.HGroup, "Warm air systems", false) > 0U)
                              {
                                xmlTextWriter.WriteValue(4);
                              }
                              else
                              {
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating2.InforSource, "Boiler Database", false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating2.SGroup, "Heat pumps", false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating2.HGroup, "Warm air systems", false) == 0)
                                  xmlTextWriter.WriteValue(5);
                                else
                                  xmlTextWriter.WriteValue(2);
                              }
                            }
                          }
                          else
                          {
                            // ISSUE: reference to a compiler-generated field
                            int sapTableCode8 = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating2.SAPTableCode;
                            if (sapTableCode8 == 699)
                              xmlTextWriter.WriteValue(1);
                            else if (sapTableCode8 <= 200)
                              xmlTextWriter.WriteValue(2);
                            else if (sapTableCode8 == 1)
                              xmlTextWriter.WriteValue(3);
                            else if (sapTableCode8 >= 201 && sapTableCode8 <= 207)
                              xmlTextWriter.WriteValue(4);
                            else if (sapTableCode8 >= 521 && sapTableCode8 <= 527)
                              xmlTextWriter.WriteValue(5);
                            else if (sapTableCode8 >= 306 && sapTableCode8 <= 310)
                              xmlTextWriter.WriteValue(6);
                            else if (sapTableCode8 >= 401 && sapTableCode8 <= 408)
                              xmlTextWriter.WriteValue(7);
                            else if (sapTableCode8 >= 421 && sapTableCode8 <= 425)
                              xmlTextWriter.WriteValue(8);
                            else if (sapTableCode8 >= 501 && sapTableCode8 <= 515)
                              xmlTextWriter.WriteValue(9);
                            else if (sapTableCode8 >= 601 && sapTableCode8 <= 694)
                              xmlTextWriter.WriteValue(10);
                            else if (sapTableCode8 == 701)
                              xmlTextWriter.WriteValue(11);
                            else
                              xmlTextWriter.WriteValue(12);
                          }
                          xmlTextWriter.WriteEndElement();
                          xmlTextWriter.WriteStartElement("SAP:Main-Heating-Fraction");
                          // ISSUE: reference to a compiler-generated field
                          xmlTextWriter.WriteValue(Math.Round((double) SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].HeatFractionSec, 2));
                          xmlTextWriter.WriteEndElement();
                          xmlTextWriter.WriteStartElement("SAP:Main-Heating-Data-Source");
                          int num32;
                          // ISSUE: reference to a compiler-generated field
                          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating2.InforSource, "Boiler Database", false) == 0)
                          {
                            xmlTextWriter.WriteValue("1");
                            num32 = 1;
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating2.InforSource, "Boiler Database", false) != 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating2.SGroup, "Gas boilers and oil boilers", false) == 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating2.SGroup, "Micro-cogeneration (micro-CHP)", false) == 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating2.SGroup, "Solid fuel boilers", false) != 0)
                              ;
                          }
                          else
                          {
                            // ISSUE: reference to a compiler-generated field
                            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating2.InforSource, "Manufacturer Declaration", false) == 0)
                            {
                              xmlTextWriter.WriteValue("2");
                              num32 = 2;
                            }
                            else
                            {
                              xmlTextWriter.WriteValue("3");
                              num32 = 3;
                            }
                          }
                          xmlTextWriter.WriteEndElement();
                          // ISSUE: reference to a compiler-generated field
                          int sapTableCode9 = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating2.SAPTableCode;
                          if (sapTableCode9 >= 151 && sapTableCode9 <= 161 || sapTableCode9 >= 631 && sapTableCode9 <= 636)
                          {
                            xmlTextWriter.WriteStartElement("SAP:Is-Main-Heating-HETAS-Approved");
                            // ISSUE: reference to a compiler-generated field
                            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating2.HETAS, "Yes", false) == 0)
                              xmlTextWriter.WriteValue("true");
                            else
                              xmlTextWriter.WriteValue("false");
                            xmlTextWriter.WriteEndElement();
                          }
                          if (num32 == 3)
                          {
                            // ISSUE: reference to a compiler-generated field
                            int sapTableCode10 = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating2.SAPTableCode;
                            if (sapTableCode10 < 306 || sapTableCode10 > 310)
                            {
                              xmlTextWriter.WriteStartElement("SAP:Main-Heating-Code");
                              // ISSUE: reference to a compiler-generated field
                              xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating2.SAPTableCode);
                              xmlTextWriter.WriteEndElement();
                            }
                          }
                          else if (num32 == 2)
                          {
                            // ISSUE: reference to a compiler-generated field
                            int sapTableCode11 = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating2.SAPTableCode;
                            if (sapTableCode11 < 306 || sapTableCode11 > 310)
                            {
                              xmlTextWriter.WriteStartElement("SAP:Main-Heating-Code");
                              // ISSUE: reference to a compiler-generated field
                              xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating2.SAPTableCode);
                              xmlTextWriter.WriteEndElement();
                            }
                          }
                          if (num32 == 1)
                          {
                            xmlTextWriter.WriteStartElement("SAP:Boiler-Index-Number");
                            // ISSUE: reference to a compiler-generated field
                            xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating2.SEDBUK);
                            xmlTextWriter.WriteEndElement();
                          }
                          // ISSUE: reference to a compiler-generated field
                          // ISSUE: reference to a compiler-generated field
                          // ISSUE: reference to a compiler-generated field
                          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating2.InforSource, "Manufacturer Declaration", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating2.InforSource, "Boiler Database", false) == 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating2.SGroup, "Solid fuel boilers", false) == 0)
                          {
                            // ISSUE: reference to a compiler-generated field
                            switch (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating2.SAPTableCode)
                            {
                              case 0:
                              case 153:
                                xmlTextWriter.WriteStartElement("SAP:Boiler-Fuel-Feed");
                                xmlTextWriter.WriteValue(1);
                                xmlTextWriter.WriteEndElement();
                                break;
                            }
                          }
                          // ISSUE: reference to a compiler-generated field
                          if (num32 == 2 && SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating2.TableGroup != 3)
                          {
                            xmlTextWriter.WriteStartElement("SAP:Main-Heating-Make-Model");
                            // ISSUE: reference to a compiler-generated field
                            xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating2.Boiler.Description);
                            xmlTextWriter.WriteEndElement();
                          }
                          if (num32 == 2)
                          {
                            // ISSUE: reference to a compiler-generated field
                            if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating2.TableGroup != 3)
                            {
                              xmlTextWriter.WriteStartElement("SAP:Main-Heating-Efficiency");
                              // ISSUE: reference to a compiler-generated field
                              xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating2.MainEff);
                              xmlTextWriter.WriteEndElement();
                            }
                            // ISSUE: reference to a compiler-generated field
                            int sapTableCode12 = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating2.SAPTableCode;
                            if (sapTableCode12 < 306 || sapTableCode12 > 310)
                            {
                              xmlTextWriter.WriteStartElement("SAP:Efficiency-Type");
                              // ISSUE: reference to a compiler-generated field
                              if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating2.SEDBUK2005)
                              {
                                xmlTextWriter.WriteValue(2);
                              }
                              else
                              {
                                // ISSUE: reference to a compiler-generated field
                                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating2.SEDBUK, "", false) == 0)
                                {
                                  xmlTextWriter.WriteValue(3);
                                }
                                else
                                {
                                  // ISSUE: reference to a compiler-generated field
                                  if (Conversions.ToBoolean(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating2.SEDBUK))
                                    xmlTextWriter.WriteValue(4);
                                  else
                                    xmlTextWriter.WriteValue(1);
                                }
                              }
                              xmlTextWriter.WriteEndElement();
                            }
                            // ISSUE: reference to a compiler-generated field
                            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating2.SGroup, "Solid fuel boilers", false) == 0)
                            {
                              // ISSUE: reference to a compiler-generated field
                              switch (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating2.SAPTableCode)
                              {
                                case 151:
                                case 152:
                                case 153:
                                case 154:
                                case 155:
                                case 161:
                                  xmlTextWriter.WriteStartElement("SAP:Solid-Fuel-Boiler-Type");
                                  xmlTextWriter.WriteValue(1);
                                  xmlTextWriter.WriteEndElement();
                                  break;
                                case 156:
                                case 160:
                                  xmlTextWriter.WriteStartElement("SAP:Solid-Fuel-Boiler-Type");
                                  xmlTextWriter.WriteValue(2);
                                  xmlTextWriter.WriteEndElement();
                                  break;
                                case 158:
                                case 159:
                                  xmlTextWriter.WriteStartElement("SAP:Solid-Fuel-Boiler-Type");
                                  xmlTextWriter.WriteValue(3);
                                  xmlTextWriter.WriteEndElement();
                                  break;
                              }
                            }
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating2.InforSource, "Manufacturer Declaration", false) == 0 && SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating2.MHType.Contains("ondens"))
                            {
                              xmlTextWriter.WriteStartElement("SAP:Is-Condensing-Boiler");
                              // ISSUE: reference to a compiler-generated field
                              if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating2.MHType.Contains("non-"))
                                xmlTextWriter.WriteValue("false");
                              else
                                xmlTextWriter.WriteValue("true");
                              xmlTextWriter.WriteEndElement();
                            }
                            // ISSUE: reference to a compiler-generated field
                            int sapTableCode13 = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating2.SAPTableCode;
                            int num33;
                            switch (sapTableCode13)
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
                                num33 = 1;
                                break;
                              default:
                                num33 = sapTableCode13 == 132 ? 1 : 0;
                                break;
                            }
                            if (num33 != 0)
                            {
                              xmlTextWriter.WriteStartElement("SAP:Gas-Or-Oil-Boiler-Type");
                              xmlTextWriter.WriteValue("1");
                              xmlTextWriter.WriteEndElement();
                            }
                            else if (sapTableCode13 == 103 || sapTableCode13 == 104 || sapTableCode13 == 107 || sapTableCode13 == 108 || sapTableCode13 == 112 || sapTableCode13 == 113 || sapTableCode13 == 118 || sapTableCode13 == 128 || sapTableCode13 == 129 || sapTableCode13 == 130)
                            {
                              xmlTextWriter.WriteStartElement("SAP:Gas-Or-Oil-Boiler-Type");
                              xmlTextWriter.WriteValue("2");
                              xmlTextWriter.WriteEndElement();
                            }
                            else if (sapTableCode13 >= 120 && sapTableCode13 <= 123)
                            {
                              xmlTextWriter.WriteStartElement("SAP:Gas-Or-Oil-Boiler-Type");
                              xmlTextWriter.WriteValue("3");
                              xmlTextWriter.WriteEndElement();
                            }
                            else if (sapTableCode13 >= 133 && sapTableCode13 <= 141)
                            {
                              xmlTextWriter.WriteStartElement("SAP:Gas-Or-Oil-Boiler-Type");
                              xmlTextWriter.WriteValue("4");
                              xmlTextWriter.WriteEndElement();
                            }
                            // ISSUE: reference to a compiler-generated field
                            int sapTableCode14 = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating2.SAPTableCode;
                            if (sapTableCode14 == 134 || sapTableCode14 == 139)
                            {
                              // ISSUE: reference to a compiler-generated field
                              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating2.InforSource, "Manufacturer Declaration", false) == 0)
                              {
                                xmlTextWriter.WriteStartElement("SAP:Case-Heat-Emission");
                                // ISSUE: reference to a compiler-generated field
                                xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating2.Range.CasekW);
                                xmlTextWriter.WriteEndElement();
                                xmlTextWriter.WriteStartElement("SAP:Heat-Transfer-To-Water");
                                // ISSUE: reference to a compiler-generated field
                                xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating2.Range.WaterkW);
                                xmlTextWriter.WriteEndElement();
                              }
                            }
                            else if (sapTableCode14 == 103 || sapTableCode14 == 104 || sapTableCode14 == 107 || sapTableCode14 == 108 || sapTableCode14 == 112 || sapTableCode14 == 113 || sapTableCode14 == 118 || sapTableCode14 == 128 || sapTableCode14 == 129 || sapTableCode14 == 130)
                            {
                              xmlTextWriter.WriteStartElement("SAP:Combi-Boiler-Type");
                              // ISSUE: reference to a compiler-generated field
                              string combiType = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.CombiType;
                              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(combiType, "Instantaneous Combi", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(combiType, "", false) != 0)
                              {
                                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(combiType, "Storage combi boiler, primary store", false) != 0)
                                {
                                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(combiType, "Storage combi boiler, secondary store", false) == 0)
                                    xmlTextWriter.WriteValue("3");
                                }
                                else
                                  xmlTextWriter.WriteValue("2");
                              }
                              else
                              {
                                // ISSUE: reference to a compiler-generated field
                                if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating2.Boiler.IncludeKeepHot)
                                {
                                  // ISSUE: reference to a compiler-generated field
                                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating2.Boiler.KeepHotFuel, "Main Fuel", false) == 0)
                                  {
                                    // ISSUE: reference to a compiler-generated field
                                    if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating2.Boiler.KeepHotTimed)
                                      xmlTextWriter.WriteValue("6");
                                    else
                                      xmlTextWriter.WriteValue("5");
                                  }
                                  else
                                  {
                                    // ISSUE: reference to a compiler-generated field
                                    if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating2.Boiler.KeepHotTimed)
                                      xmlTextWriter.WriteValue("8");
                                    else
                                      xmlTextWriter.WriteValue("7");
                                  }
                                }
                                else
                                  xmlTextWriter.WriteValue("1");
                              }
                              xmlTextWriter.WriteEndElement();
                            }
                            else if (sapTableCode14 >= 120 && sapTableCode14 <= 123)
                            {
                              xmlTextWriter.WriteStartElement("SAP:Combi-Boiler-Type");
                              xmlTextWriter.WriteValue("4");
                              xmlTextWriter.WriteEndElement();
                            }
                          }
                          // ISSUE: reference to a compiler-generated field
                          // ISSUE: reference to a compiler-generated field
                          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating2.SGroup, "Gas boilers and oil boilers", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating2.SGroup, "Micro-cogeneration (micro-CHP)", false) == 0)
                          {
                            // ISSUE: reference to a compiler-generated field
                            if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating2.SAPTableCode == (int) sbyte.MaxValue)
                            {
                              xmlTextWriter.WriteStartElement("SAP:Burner-Control");
                              xmlTextWriter.WriteValue("3");
                              xmlTextWriter.WriteEndElement();
                            }
                          }
                          else
                          {
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating2.SGroup, "Heat pumps", false) != 0 && (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating2.FuelBurningType, "", false) > 0U)
                            {
                              xmlTextWriter.WriteStartElement("SAP:Burner-Control");
                              // ISSUE: reference to a compiler-generated field
                              string fuelBurningType = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating2.FuelBurningType;
                              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuelBurningType, "Unknown", false) != 0)
                              {
                                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuelBurningType, "On/off", false) != 0)
                                {
                                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuelBurningType, "Modulation", false) != 0)
                                  {
                                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuelBurningType, "electrical", false) != 0)
                                    {
                                      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuelBurningType, "manual", false) == 0)
                                        xmlTextWriter.WriteValue("5");
                                    }
                                    else
                                      xmlTextWriter.WriteValue("4");
                                  }
                                  else
                                    xmlTextWriter.WriteValue("3");
                                }
                                else
                                  xmlTextWriter.WriteValue("2");
                              }
                              else
                                xmlTextWriter.WriteValue("1");
                              xmlTextWriter.WriteEndElement();
                            }
                          }
                          // ISSUE: reference to a compiler-generated field
                          if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating2.TableGroup != 3)
                          {
                            xmlTextWriter.WriteStartElement("SAP:Main-Fuel-Type");
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            xmlTextWriter.WriteValue(this.FuelCheck(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating2.Fuel, closure850_2.\u0024VB\u0024Local_House));
                            xmlTextWriter.WriteEndElement();
                          }
                          xmlTextWriter.WriteStartElement("SAP:Main-Heating-Control");
                          // ISSUE: reference to a compiler-generated field
                          xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating2.ControlCode);
                          xmlTextWriter.WriteEndElement();
                          // ISSUE: reference to a compiler-generated field
                          if (!string.IsNullOrEmpty(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating2.Emitter))
                          {
                            xmlTextWriter.WriteStartElement("SAP:Heat-Emitter-Type");
                            // ISSUE: reference to a compiler-generated field
                            string emitter6 = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating2.Emitter;
                            // ISSUE: reference to a compiler-generated method
                            switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(emitter6))
                            {
                              case 1150666285:
                                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter6, "Underfloor heating and radiators, pipes in insulated timber floor", false) == 0)
                                {
                                  xmlTextWriter.WriteValue(3);
                                  xmlTextWriter.WriteEndElement();
                                  xmlTextWriter.WriteStartElement("SAP:Underfloor-Heat-Emitter-Type");
                                  // ISSUE: reference to a compiler-generated field
                                  string emitter7 = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating2.Emitter;
                                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter7, "Underfloor heating, pipes in insulated timber floor", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter7, "Underfloor heating and radiators, pipes in insulated timber floor", false) != 0)
                                  {
                                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter7, "Underfloor heating, pipes in screed above insulation", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter7, "Underfloor heating and radiators, pipes in screed above insulation", false) != 0)
                                    {
                                      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter7, "Underfloor heating, pipes in concrete slab", false) == 0)
                                      {
                                        xmlTextWriter.WriteValue(1);
                                        xmlTextWriter.WriteEndElement();
                                        goto label_1624;
                                      }
                                      else
                                        goto label_1624;
                                    }
                                    else
                                    {
                                      xmlTextWriter.WriteValue(2);
                                      xmlTextWriter.WriteEndElement();
                                      goto label_1624;
                                    }
                                  }
                                  else
                                  {
                                    xmlTextWriter.WriteValue(3);
                                    xmlTextWriter.WriteEndElement();
                                    goto label_1624;
                                  }
                                }
                                else
                                  goto default;
                              case 1251058319:
                                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter6, "Underfloor heating, pipes in insulated timber floor", false) == 0)
                                  break;
                                goto default;
                              case 1501161800:
                                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter6, "Underfloor heating, pipes in screed above insulation", false) == 0)
                                {
                                  xmlTextWriter.WriteValue(2);
                                  xmlTextWriter.WriteEndElement();
                                  xmlTextWriter.WriteStartElement("SAP:Underfloor-Heat-Emitter-Type");
                                  xmlTextWriter.WriteValue(2);
                                  xmlTextWriter.WriteEndElement();
                                  goto label_1624;
                                }
                                else
                                  goto default;
                              case 2395580722:
                                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter6, "Underfloor heating and radiators, pipes in screed above insulation", false) == 0)
                                {
                                  xmlTextWriter.WriteValue(3);
                                  xmlTextWriter.WriteEndElement();
                                  xmlTextWriter.WriteStartElement("SAP:Underfloor-Heat-Emitter-Type");
                                  // ISSUE: reference to a compiler-generated field
                                  string emitter8 = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating2.Emitter;
                                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter8, "Underfloor heating, pipes in insulated timber floor", false) != 0)
                                  {
                                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter8, "Underfloor heating, pipes in screed above insulation", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter8, "Underfloor heating and radiators, pipes in insulated timber floor", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter8, "Underfloor heating and radiators, pipes in screed above insulation", false) != 0)
                                    {
                                      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter8, "Underfloor heating, pipes in concrete slab", false) == 0)
                                        xmlTextWriter.WriteValue(1);
                                      else
                                        xmlTextWriter.WriteValue(2);
                                    }
                                    else
                                      xmlTextWriter.WriteValue(2);
                                  }
                                  else
                                    xmlTextWriter.WriteValue(3);
                                  xmlTextWriter.WriteEndElement();
                                  goto label_1624;
                                }
                                else
                                  goto default;
                              case 2409319762:
                                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter6, "Underfloor heating, pipes in concrete slab", false) == 0)
                                  break;
                                goto default;
                              case 2565474752:
                                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter6, "Systems with radiators", false) == 0)
                                {
                                  xmlTextWriter.WriteValue(1);
                                  xmlTextWriter.WriteEndElement();
                                  goto label_1624;
                                }
                                else
                                  goto default;
                              case 3146736266:
                                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter6, "Fan coil units", false) == 0)
                                {
                                  xmlTextWriter.WriteValue(4);
                                  xmlTextWriter.WriteEndElement();
                                  xmlTextWriter.WriteStartElement("SAP:Underfloor-Heat-Emitter-Type");
                                  // ISSUE: reference to a compiler-generated field
                                  string emitter9 = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating2.Emitter;
                                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter9, "Underfloor heating, pipes in insulated timber floor", false) != 0)
                                  {
                                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter9, "Underfloor heating, pipes in screed above insulation", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter9, "Underfloor heating and radiators, pipes in insulated timber floor", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter9, "Underfloor heating and radiators, pipes in screed above insulation", false) != 0)
                                    {
                                      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter9, "Underfloor heating, pipes in concrete slab", false) == 0)
                                        xmlTextWriter.WriteValue(1);
                                      else
                                        xmlTextWriter.WriteValue(2);
                                    }
                                    else
                                      xmlTextWriter.WriteValue(2);
                                  }
                                  else
                                    xmlTextWriter.WriteValue(3);
                                  xmlTextWriter.WriteEndElement();
                                  goto label_1624;
                                }
                                else
                                  goto default;
                              default:
                                xmlTextWriter.WriteValue(1);
                                xmlTextWriter.WriteEndElement();
                                goto label_1624;
                            }
                            xmlTextWriter.WriteValue(2);
                            xmlTextWriter.WriteEndElement();
                            xmlTextWriter.WriteStartElement("SAP:Underfloor-Heat-Emitter-Type");
                            // ISSUE: reference to a compiler-generated field
                            string emitter10 = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating2.Emitter;
                            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter10, "Underfloor heating, pipes in insulated timber floor", false) != 0)
                            {
                              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter10, "Underfloor heating and radiators, pipes in insulated timber floor", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter10, "Underfloor heating and radiators, pipes in screed above insulation", false) != 0)
                              {
                                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter10, "Underfloor heating, pipes in concrete slab", false) == 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(emitter10, "Underfloor heating, pipes in screed above insulation", false) == 0)
                                  xmlTextWriter.WriteValue(1);
                                else
                                  xmlTextWriter.WriteValue(2);
                              }
                              else
                                xmlTextWriter.WriteValue(2);
                            }
                            else
                              xmlTextWriter.WriteValue(3);
                            xmlTextWriter.WriteEndElement();
label_1624:;
                          }
                          if (num32 == 1)
                          {
                            // ISSUE: reference to a compiler-generated field
                            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating2.SGroup, "Micro-cogeneration (micro-CHP)", false) == 0)
                            {
                              // ISSUE: reference to a compiler-generated method
                              this.SearchRowCHP = SAP_Module.PCDFData.CHPs.Where<PCDF.CHP>(new Func<PCDF.CHP, bool>(closure850_2._Lambda\u0024__4)).SingleOrDefault<PCDF.CHP>();
                              xmlTextWriter.WriteStartElement("SAP:Main-Heating-Flue-Type");
                              xmlTextWriter.WriteValue(this.SearchRowCHP.Flue_Type);
                              xmlTextWriter.WriteEndElement();
                              xmlTextWriter.WriteStartElement("SAP:Is-Flue-Fan-Present");
                              xmlTextWriter.WriteValue("false");
                              xmlTextWriter.WriteEndElement();
                            }
                            else
                            {
                              // ISSUE: reference to a compiler-generated field
                              if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating2.SGroup, "Heat pumps", false) > 0U)
                              {
                                xmlTextWriter.WriteStartElement("SAP:Main-Heating-Flue-Type");
                                List<PCDF.SEDBUK> boilers = SAP_Module.PCDFData.Boilers;
                                Func<PCDF.SEDBUK, bool> predicate;
                                // ISSUE: reference to a compiler-generated field
                                if (CreatePDF._Closure\u0024__.\u0024I85\u002D5 != null)
                                {
                                  // ISSUE: reference to a compiler-generated field
                                  predicate = CreatePDF._Closure\u0024__.\u0024I85\u002D5;
                                }
                                else
                                {
                                  // ISSUE: reference to a compiler-generated field
                                  CreatePDF._Closure\u0024__.\u0024I85\u002D5 = predicate = (Func<PCDF.SEDBUK, bool>) (b => b.ID.Equals(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SEDBUK));
                                }
                                this.SearchBoilerRow = boilers.Where<PCDF.SEDBUK>(predicate).SingleOrDefault<PCDF.SEDBUK>();
                                if (this.SearchBoilerRow != null)
                                {
                                  xmlTextWriter.WriteValue(1);
                                  xmlTextWriter.WriteEndElement();
                                }
                                else
                                {
                                  if (Information.IsDBNull((object) this.SearchBoilerRow.FlueType))
                                    xmlTextWriter.WriteValue(1);
                                  else
                                    xmlTextWriter.WriteValue(this.SearchBoilerRow.FlueType);
                                  xmlTextWriter.WriteEndElement();
                                }
                                xmlTextWriter.WriteStartElement("SAP:Is-Flue-Fan-Present");
                                if (this.SearchBoilerRow != null)
                                {
                                  xmlTextWriter.WriteValue("false");
                                  xmlTextWriter.WriteEndElement();
                                }
                                else
                                {
                                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(!Information.IsDBNull((object) this.SearchBoilerRow.FanAssist) ? this.SearchBoilerRow.FanAssist : this.SearchBoilerRow.FanAssist, "2", false) == 0)
                                    xmlTextWriter.WriteValue("true");
                                  else
                                    xmlTextWriter.WriteValue("false");
                                  xmlTextWriter.WriteEndElement();
                                }
                              }
                            }
                          }
                          else
                          {
                            // ISSUE: reference to a compiler-generated field
                            int sapTableCode15 = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating2.SAPTableCode;
                            if (sapTableCode15 == 635)
                            {
                              xmlTextWriter.WriteStartElement("SAP:Main-Heating-Flue-Type");
                              xmlTextWriter.WriteValue(1);
                              xmlTextWriter.WriteEndElement();
                              xmlTextWriter.WriteStartElement("SAP:Is-Flue-Fan-Present");
                              // ISSUE: reference to a compiler-generated field
                              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating2.Boiler.FanFlued, "Yes", false) == 0)
                                xmlTextWriter.WriteValue("true");
                              else
                                xmlTextWriter.WriteValue("false");
                              xmlTextWriter.WriteEndElement();
                            }
                            else
                            {
                              // ISSUE: reference to a compiler-generated field
                              if ((sapTableCode15 < 300 || sapTableCode15 >= 501 && sapTableCode15 <= 527) && (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating2.Fuel, "Electricity", false) > 0U)
                              {
                                xmlTextWriter.WriteStartElement("SAP:Main-Heating-Flue-Type");
                                // ISSUE: reference to a compiler-generated field
                                string flueType = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating2.Boiler.FlueType;
                                // ISSUE: reference to a compiler-generated method
                                switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(flueType))
                                {
                                  case 572081497:
                                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(flueType, "omitted", false) == 0)
                                      goto label_1665;
                                    else
                                      goto default;
                                  case 1401622761:
                                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(flueType, "Open", false) == 0)
                                      break;
                                    goto default;
                                  case 1533154807:
                                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(flueType, "balanced flue", false) == 0)
                                      goto label_1663;
                                    else
                                      goto default;
                                  case 1537289947:
                                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(flueType, "open flue", false) == 0)
                                      break;
                                    goto default;
                                  case 1708018833:
                                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(flueType, "Room-sealed", false) == 0)
                                      goto label_1663;
                                    else
                                      goto default;
                                  case 1845819738:
                                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(flueType, "unknown (there is a flue, but its type could not be determined)", false) == 0)
                                      goto label_1666;
                                    else
                                      goto default;
                                  case 2166136261:
                                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(flueType, "", false) == 0)
                                      goto label_1665;
                                    else
                                      goto default;
                                  case 2391940020:
                                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(flueType, "Chimney", false) == 0)
                                    {
                                      xmlTextWriter.WriteValue(3);
                                      goto default;
                                    }
                                    else
                                      goto default;
                                  case 3424652889:
                                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(flueType, "Unknown", false) == 0)
                                      goto label_1666;
                                    else
                                      goto default;
                                  default:
label_1667:
                                    xmlTextWriter.WriteEndElement();
                                    goto label_1668;
                                }
                                xmlTextWriter.WriteValue(1);
                                goto label_1667;
label_1663:
                                xmlTextWriter.WriteValue(2);
                                goto label_1667;
label_1665:
                                xmlTextWriter.WriteValue(4);
                                goto label_1667;
label_1666:
                                xmlTextWriter.WriteValue(5);
                                goto label_1667;
                              }
                            }
label_1668:;
                          }
                          // ISSUE: reference to a compiler-generated field
                          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating2.InforSource, "Boiler Database", false) == 0)
                          {
                            // ISSUE: reference to a compiler-generated field
                            if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating2.TableGroup != 3)
                            {
                              xmlTextWriter.WriteStartElement("SAP:Is-Central-Heating-Pump-In-Heated-Space");
                              // ISSUE: reference to a compiler-generated field
                              // ISSUE: reference to a compiler-generated field
                              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating2.SGroup, "Heat pumps", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating2.SGroup, "Micro-cogeneration (micro-CHP)", false) == 0)
                              {
                                xmlTextWriter.WriteValue("true");
                              }
                              else
                              {
                                // ISSUE: reference to a compiler-generated field
                                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating2.Boiler.PumpHP, "Yes", false) == 0)
                                  xmlTextWriter.WriteValue("true");
                                else
                                  xmlTextWriter.WriteValue("false");
                              }
                              xmlTextWriter.WriteEndElement();
                            }
                            // ISSUE: reference to a compiler-generated field
                            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating2.SGroup, "Gas boilers and oil boilers", false) == 0)
                            {
                              xmlTextWriter.WriteStartElement("SAP:Is-Interlocked-System");
                              // ISSUE: reference to a compiler-generated field
                              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating2.Boiler.BILock, "Yes", false) == 0)
                                xmlTextWriter.WriteValue("true");
                              else
                                xmlTextWriter.WriteValue("false");
                              xmlTextWriter.WriteEndElement();
                            }
                          }
                          else
                          {
                            // ISSUE: reference to a compiler-generated field
                            if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating2.TableGroup != 3)
                            {
                              // ISSUE: reference to a compiler-generated field
                              int sapTableCode16 = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating2.SAPTableCode;
                              if (sapTableCode16 >= 101 && sapTableCode16 <= 310 || sapTableCode16 == 602 || sapTableCode16 == 604 || sapTableCode16 == 606)
                              {
                                xmlTextWriter.WriteStartElement("SAP:Is-Central-Heating-Pump-In-Heated-Space");
                                // ISSUE: reference to a compiler-generated field
                                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating2.Boiler.PumpHP, "Yes", false) == 0)
                                  xmlTextWriter.WriteValue("true");
                                else
                                  xmlTextWriter.WriteValue("false");
                                xmlTextWriter.WriteEndElement();
                              }
                            }
                            // ISSUE: reference to a compiler-generated field
                            int sapTableCode17 = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating2.SAPTableCode;
                            if (sapTableCode17 >= 1 && sapTableCode17 <= 149)
                            {
                              xmlTextWriter.WriteStartElement("SAP:Is-Interlocked-System");
                              // ISSUE: reference to a compiler-generated field
                              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating2.Boiler.BILock, "Yes", false) == 0)
                                xmlTextWriter.WriteValue("true");
                              else
                                xmlTextWriter.WriteValue("false");
                              xmlTextWriter.WriteEndElement();
                            }
                          }
                          // ISSUE: reference to a compiler-generated field
                          if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating2.SAPTableCode < 200)
                          {
                            // ISSUE: reference to a compiler-generated field
                            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating2.Fuel, "heating oil", false) == 0)
                            {
                              xmlTextWriter.WriteStartElement("SAP:Is-Oil-Pump-In-Heated-Space");
                              // ISSUE: reference to a compiler-generated field
                              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating2.Boiler.PumpHP, "Yes", false) == 0)
                                xmlTextWriter.WriteValue("true");
                              else
                                xmlTextWriter.WriteValue("false");
                              xmlTextWriter.WriteEndElement();
                            }
                            else
                            {
                              // ISSUE: reference to a compiler-generated field
                              if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating2.OilPump)
                              {
                                xmlTextWriter.WriteStartElement("SAP:Is-Oil-Pump-In-Heated-Space");
                                xmlTextWriter.WriteValue("true");
                                xmlTextWriter.WriteEndElement();
                              }
                            }
                          }
                          // ISSUE: reference to a compiler-generated field
                          switch (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating2.ControlCode)
                          {
                            case 2101:
                            case 2102:
                            case 2104:
                            case 2105:
                            case 2106:
                            case 2107:
                            case 2108:
                            case 2109:
                            case 2110:
                            case 2202:
                            case 2204:
                            case 2205:
                            case 2206:
                            case 2207:
                              xmlTextWriter.WriteStartElement("SAP:Has-Delayed-Start-Thermostat");
                              // ISSUE: reference to a compiler-generated field
                              xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating2.DelayedStart);
                              xmlTextWriter.WriteEndElement();
                              break;
                          }
                          if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SAPTableCode < 300)
                          {
                            // ISSUE: reference to a compiler-generated field
                            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating2.SGroup, "Heat pumps", false) == 0)
                            {
                              // ISSUE: reference to a compiler-generated field
                              if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating2.Boiler.LoadWeather)
                              {
                                xmlTextWriter.WriteStartElement("SAP:Load-Or-Weather-Compensation");
                                // ISSUE: reference to a compiler-generated field
                                string compensator = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating2.Compensator;
                                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(compensator, "Weather Compensation", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(compensator, "Weather Compensator", false) != 0)
                                {
                                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(compensator, "Load Compensation", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(compensator, "Load compensator", false) != 0)
                                  {
                                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(compensator, "Enhanced Load Compensator", false) == 0)
                                      xmlTextWriter.WriteValue(3);
                                    else
                                      xmlTextWriter.WriteValue(0);
                                  }
                                  else
                                    xmlTextWriter.WriteValue(1);
                                }
                                else
                                  xmlTextWriter.WriteValue(2);
                                xmlTextWriter.WriteEndElement();
                              }
                            }
                            else
                            {
                              xmlTextWriter.WriteStartElement("SAP:Load-Or-Weather-Compensation");
                              // ISSUE: reference to a compiler-generated field
                              if (!SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating2.Boiler.LoadWeather)
                              {
                                // ISSUE: reference to a compiler-generated field
                                string compensator = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating2.Compensator;
                                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(compensator, "Weather Compensation", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(compensator, "Weather Compensator", false) != 0)
                                {
                                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(compensator, "Load Compensation", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(compensator, "Load compensator", false) != 0)
                                  {
                                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(compensator, "Enhanced Load Compensator", false) == 0)
                                      xmlTextWriter.WriteValue(3);
                                    else
                                      xmlTextWriter.WriteValue(0);
                                  }
                                  else
                                    xmlTextWriter.WriteValue(1);
                                }
                                else
                                  xmlTextWriter.WriteValue(2);
                                xmlTextWriter.WriteEndElement();
                              }
                              else
                              {
                                // ISSUE: reference to a compiler-generated field
                                string loadWeatherType = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating2.Boiler.LoadWeatherType;
                                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(loadWeatherType, "Weather Compensation", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(loadWeatherType, "Weather Compensator", false) != 0)
                                {
                                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(loadWeatherType, "Load Compensation", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(loadWeatherType, "Load compensator", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(loadWeatherType, "Load Compensator", false) != 0)
                                  {
                                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(loadWeatherType, "Enhanced Load Compensator", false) == 0)
                                      xmlTextWriter.WriteValue(3);
                                  }
                                  else
                                    xmlTextWriter.WriteValue(1);
                                }
                                else
                                  xmlTextWriter.WriteValue(2);
                                xmlTextWriter.WriteEndElement();
                              }
                            }
                          }
                          // ISSUE: reference to a compiler-generated field
                          if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating2.SAPTableCode == 192)
                          {
                            xmlTextWriter.WriteStartElement("SAP:Electric-CPSU-Operating-Temperature");
                            // ISSUE: reference to a compiler-generated field
                            xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.CPSUTemp);
                            xmlTextWriter.WriteEndElement();
                          }
                          xmlTextWriter.WriteEndElement();
                        }
                        xmlTextWriter.WriteEndElement();
                        // ISSUE: reference to a compiler-generated field
                        if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].IncludeMainHeating2)
                        {
                          xmlTextWriter.WriteStartElement("SAP:Main-Heating-Systems-Interaction");
                          // ISSUE: reference to a compiler-generated field
                          if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Include_SecMain_Heat_Separat_Part)
                          {
                            xmlTextWriter.WriteValue(2);
                          }
                          else
                          {
                            // ISSUE: reference to a compiler-generated field
                            if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Include_SecMain_Heat_Whole)
                              xmlTextWriter.WriteValue(1);
                            else
                              xmlTextWriter.WriteValue(2);
                          }
                          xmlTextWriter.WriteEndElement();
                        }
                        xmlTextWriter.WriteStartElement("SAP:Secondary-Heating-Category");
                        // ISSUE: reference to a compiler-generated field
                        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].SecHeating.HGroup, "Room heaters", false) == 0)
                          xmlTextWriter.WriteValue(10);
                        else
                          xmlTextWriter.WriteValue(1);
                        xmlTextWriter.WriteEndElement();
                        xmlTextWriter.WriteStartElement("SAP:Has-Fixed-Air-Conditioning");
                        // ISSUE: reference to a compiler-generated field
                        if (!SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Cooling.Include)
                          xmlTextWriter.WriteValue("false");
                        else
                          xmlTextWriter.WriteValue("true");
                        xmlTextWriter.WriteEndElement();
                        // ISSUE: reference to a compiler-generated field
                        if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.SystemRef == 951)
                        {
                          xmlTextWriter.WriteStartElement("SAP:Water-Heating-Code");
                          // ISSUE: reference to a compiler-generated field
                          xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.SystemRef);
                          xmlTextWriter.WriteEndElement();
                        }
                        else
                        {
                          xmlTextWriter.WriteStartElement("SAP:Water-Heating-Code");
                          // ISSUE: reference to a compiler-generated field
                          switch (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.SystemRef)
                          {
                            case 901:
                              // ISSUE: reference to a compiler-generated field
                              switch (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.SAPTableCode)
                              {
                                case 501:
                                case 503:
                                case 506:
                                case 508:
                                  xmlTextWriter.WriteValue(905);
                                  break;
                                case 502:
                                case 504:
                                case 509:
                                  xmlTextWriter.WriteValue(906);
                                  break;
                                case 507:
                                  xmlTextWriter.WriteValue(901);
                                  break;
                                default:
                                  // ISSUE: reference to a compiler-generated field
                                  xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.SystemRef);
                                  break;
                              }
                              break;
                            case 902:
                              // ISSUE: reference to a compiler-generated field
                              switch (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.SAPTableCode)
                              {
                                case 602:
                                case 604:
                                case 606:
                                  xmlTextWriter.WriteValue(904);
                                  break;
                                default:
                                  // ISSUE: reference to a compiler-generated field
                                  xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.SystemRef);
                                  break;
                              }
                              break;
                            default:
                              // ISSUE: reference to a compiler-generated field
                              xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.SystemRef);
                              break;
                          }
                          xmlTextWriter.WriteEndElement();
                          // ISSUE: reference to a compiler-generated field
                          int sapTableCode18 = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.SAPTableCode;
                          if (sapTableCode18 < 306 || sapTableCode18 > 310)
                          {
                            xmlTextWriter.WriteStartElement("SAP:Water-Fuel-Type");
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            xmlTextWriter.WriteValue(this.FuelCheck(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.Fuel, closure850_2.\u0024VB\u0024Local_House));
                            xmlTextWriter.WriteEndElement();
                          }
                        }
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.SystemRef == 901 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.SGroup, "Heat pumps", false) == 0 & !SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.Cylinder.Thermostat)
                        {
                          xmlTextWriter.WriteStartElement("SAP:Has-Hot-Water-Cylinder");
                          xmlTextWriter.WriteValue("false");
                          xmlTextWriter.WriteEndElement();
                        }
                        else
                        {
                          // ISSUE: reference to a compiler-generated field
                          // ISSUE: reference to a compiler-generated field
                          // ISSUE: reference to a compiler-generated field
                          if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.SystemRef == 901 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.HGroup, "Community heating schemes", false) == 0 & !SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.Cylinder.Thermostat)
                          {
                            xmlTextWriter.WriteStartElement("SAP:Has-Hot-Water-Cylinder");
                            xmlTextWriter.WriteValue("false");
                            xmlTextWriter.WriteEndElement();
                          }
                          else
                          {
                            // ISSUE: reference to a compiler-generated field
                            if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.Cylinder.Thermostat)
                            {
                              xmlTextWriter.WriteStartElement("SAP:Has-Hot-Water-Cylinder");
                              xmlTextWriter.WriteValue("true");
                              xmlTextWriter.WriteEndElement();
                            }
                            else
                            {
                              xmlTextWriter.WriteStartElement("SAP:Has-Hot-Water-Cylinder");
                              // ISSUE: reference to a compiler-generated field
                              // ISSUE: reference to a compiler-generated field
                              if ((double) SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.Cylinder.Volume != 0.0 & SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.SAPTableCode != 192)
                              {
                                // ISSUE: reference to a compiler-generated field
                                if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.Cylinder.Thermostat)
                                {
                                  xmlTextWriter.WriteValue("true");
                                }
                                else
                                {
                                  // ISSUE: reference to a compiler-generated field
                                  if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.HWSComm.CylinderInDwelling)
                                  {
                                    xmlTextWriter.WriteValue("true");
                                  }
                                  else
                                  {
                                    // ISSUE: reference to a compiler-generated field
                                    if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.Thermal.Location, "", false) > 0U)
                                    {
                                      xmlTextWriter.WriteValue("false");
                                    }
                                    else
                                    {
                                      // ISSUE: reference to a compiler-generated field
                                      if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.Thermal.Include)
                                      {
                                        xmlTextWriter.WriteValue("false");
                                      }
                                      else
                                      {
                                        // ISSUE: reference to a compiler-generated field
                                        if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.SAPTableCode == 130)
                                          xmlTextWriter.WriteValue("false");
                                        else
                                          xmlTextWriter.WriteValue("true");
                                      }
                                    }
                                  }
                                }
                              }
                              else
                              {
                                // ISSUE: reference to a compiler-generated field
                                switch (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.SAPTableCode)
                                {
                                  case 311:
                                  case 312:
                                    xmlTextWriter.WriteValue("true");
                                    break;
                                  default:
                                    xmlTextWriter.WriteValue("false");
                                    break;
                                }
                              }
                              xmlTextWriter.WriteEndElement();
                            }
                          }
                        }
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        if ((uint) SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].SecHeating.SAPTableCode > 0U & SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].SecHeating.SAPTableCode != 192 && (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].SecHeating.InforSource, "", false) > 0U)
                        {
                          xmlTextWriter.WriteStartElement("SAP:Secondary-Heating-Data-Source");
                          // ISSUE: reference to a compiler-generated field
                          if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].SecHeating.InforSource.Contains("anu"))
                            xmlTextWriter.WriteValue(2);
                          else
                            xmlTextWriter.WriteValue(3);
                          xmlTextWriter.WriteEndElement();
                          xmlTextWriter.WriteStartElement("SAP:Secondary-Fuel-Type");
                          // ISSUE: reference to a compiler-generated field
                          // ISSUE: reference to a compiler-generated field
                          xmlTextWriter.WriteValue(this.FuelCheck(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].SecHeating.Fuel, closure850_2.\u0024VB\u0024Local_House));
                          xmlTextWriter.WriteEndElement();
                          // ISSUE: reference to a compiler-generated field
                          if (!SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].SecHeating.InforSource.Contains("anu"))
                          {
                            xmlTextWriter.WriteStartElement("SAP:Secondary-Heating-Code");
                            // ISSUE: reference to a compiler-generated field
                            xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].SecHeating.SAPTableCode);
                            xmlTextWriter.WriteEndElement();
                            // ISSUE: reference to a compiler-generated field
                            int sapTableCode19 = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].SecHeating.SAPTableCode;
                            if (sapTableCode19 >= 631 && sapTableCode19 <= 636)
                            {
                              xmlTextWriter.WriteStartElement("SAP:Is-Secondary-Heating-HETAS-Approved");
                              // ISSUE: reference to a compiler-generated field
                              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].SecHeating.HETAS, "Yes", false) == 0)
                                xmlTextWriter.WriteValue("true");
                              else
                                xmlTextWriter.WriteValue("false");
                              xmlTextWriter.WriteEndElement();
                            }
                            // ISSUE: reference to a compiler-generated field
                            switch (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].SecHeating.SAPTableCode)
                            {
                              case 603:
                              case 604:
                              case 606:
                              case 621:
                              case 633:
                                xmlTextWriter.WriteStartElement("SAP:Secondary-Heating-Flue-Type");
                                xmlTextWriter.WriteValue(1);
                                xmlTextWriter.WriteEndElement();
                                break;
                              case 612:
                              case 631:
                                xmlTextWriter.WriteStartElement("SAP:Secondary-Heating-Flue-Type");
                                xmlTextWriter.WriteValue(3);
                                xmlTextWriter.WriteEndElement();
                                break;
                              case 613:
                                xmlTextWriter.WriteStartElement("SAP:Secondary-Heating-Flue-Type");
                                xmlTextWriter.WriteValue(4);
                                xmlTextWriter.WriteEndElement();
                                break;
                            }
                          }
                          else
                          {
                            xmlTextWriter.WriteStartElement("SAP:Secondary-Heating-Make-Model");
                            // ISSUE: reference to a compiler-generated field
                            xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].SecHeating.MDescription);
                            xmlTextWriter.WriteEndElement();
                            xmlTextWriter.WriteStartElement("SAP:Secondary-Heating-Test-Method");
                            // ISSUE: reference to a compiler-generated field
                            xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].SecHeating.TestMethod);
                            xmlTextWriter.WriteEndElement();
                            xmlTextWriter.WriteStartElement("SAP:Secondary-Heating-Efficiency");
                            // ISSUE: reference to a compiler-generated field
                            xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].SecHeating.SecEff);
                            xmlTextWriter.WriteEndElement();
                            xmlTextWriter.WriteStartElement("SAP:Secondary-Heating-Flue-Type");
                            // ISSUE: reference to a compiler-generated field
                            string flueType = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].SecHeating.FlueType;
                            // ISSUE: reference to a compiler-generated method
                            switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(flueType))
                            {
                              case 572081497:
                                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(flueType, "omitted", false) == 0)
                                  goto label_1819;
                                else
                                  goto default;
                              case 1401622761:
                                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(flueType, "Open", false) == 0)
                                  break;
                                goto default;
                              case 1533154807:
                                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(flueType, "balanced flue", false) == 0)
                                  goto label_1817;
                                else
                                  goto default;
                              case 1537289947:
                                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(flueType, "open flue", false) == 0)
                                  break;
                                goto default;
                              case 1708018833:
                                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(flueType, "Room-sealed", false) == 0)
                                  goto label_1817;
                                else
                                  goto default;
                              case 1845819738:
                                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(flueType, "unknown (there is a flue, but its type could not be determined)", false) == 0)
                                  goto label_1820;
                                else
                                  goto default;
                              case 2166136261:
                                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(flueType, "", false) == 0)
                                  goto label_1819;
                                else
                                  goto default;
                              case 2391940020:
                                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(flueType, "Chimney", false) == 0)
                                {
                                  xmlTextWriter.WriteValue(3);
                                  goto default;
                                }
                                else
                                  goto default;
                              case 3424652889:
                                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(flueType, "Unknown", false) == 0)
                                  goto label_1820;
                                else
                                  goto default;
                              default:
label_1821:
                                xmlTextWriter.WriteEndElement();
                                goto label_1822;
                            }
                            xmlTextWriter.WriteValue(1);
                            goto label_1821;
label_1817:
                            xmlTextWriter.WriteValue(2);
                            goto label_1821;
label_1819:
                            xmlTextWriter.WriteValue(4);
                            goto label_1821;
label_1820:
                            xmlTextWriter.WriteValue(5);
                            goto label_1821;
                          }
label_1822:;
                        }
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.SAPTableCode < 200 && (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.SGroup, "Heat pumps", false) > 0U)
                        {
                          xmlTextWriter.WriteStartElement("SAP:Thermal-Store");
                          // ISSUE: reference to a compiler-generated field
                          if (!SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.Thermal.Include)
                          {
                            xmlTextWriter.WriteValue(1);
                          }
                          else
                          {
                            // ISSUE: reference to a compiler-generated field
                            if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.Thermal.Type.Contains("ntegrate"))
                            {
                              xmlTextWriter.WriteValue(3);
                            }
                            else
                            {
                              // ISSUE: reference to a compiler-generated field
                              if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.Thermal.Type.Contains("ater"))
                                xmlTextWriter.WriteValue(2);
                              else
                                xmlTextWriter.WriteValue(1);
                            }
                          }
                          xmlTextWriter.WriteEndElement();
                        }
                        bool flag5;
                        // ISSUE: reference to a compiler-generated field
                        if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.SystemRef == 901)
                        {
                          // ISSUE: reference to a compiler-generated field
                          // ISSUE: reference to a compiler-generated field
                          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.HGroup, "Room heaters", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.SGroup, "Solid fuel boilers", false) == 0)
                          {
                            xmlTextWriter.WriteStartElement("SAP:Is-Immersion-For-Summer-Use");
                            // ISSUE: reference to a compiler-generated field
                            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.Cylinder.HPImmersion, "Yes", false) == 0)
                              xmlTextWriter.WriteValue("true");
                            else
                              xmlTextWriter.WriteValue("false");
                            xmlTextWriter.WriteEndElement();
                            flag5 = true;
                          }
                          else
                          {
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.HGroup, "Room heaters", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.SGroup, "Solid fuel boilers", false) == 0)
                            {
                              int sapTableCode20 = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SAPTableCode;
                              if (sapTableCode20 >= 156 && sapTableCode20 <= 161 || sapTableCode20 == 632 || sapTableCode20 == 634 || sapTableCode20 == 636)
                              {
                                xmlTextWriter.WriteStartElement("SAP:Is-Immersion-For-Summer-Use");
                                // ISSUE: reference to a compiler-generated field
                                if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.Cylinder.SummerImmersion)
                                {
                                  xmlTextWriter.WriteValue("true");
                                  xmlTextWriter.WriteEndElement();
                                }
                                else
                                {
                                  xmlTextWriter.WriteValue("false");
                                  xmlTextWriter.WriteEndElement();
                                }
                                flag5 = true;
                              }
                            }
                          }
                        }
                        // ISSUE: reference to a compiler-generated field
                        if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.Cylinder.SummerImmersion & !flag5)
                        {
                          xmlTextWriter.WriteStartElement("SAP:Is-Immersion-For-Summer-Use");
                          xmlTextWriter.WriteValue("true");
                          xmlTextWriter.WriteEndElement();
                          xmlTextWriter.WriteStartElement("SAP:Immersion-Heating-Type");
                          // ISSUE: reference to a compiler-generated field
                          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.Cylinder.Immersion, "Dual", false) == 0)
                            xmlTextWriter.WriteValue(1);
                          else
                            xmlTextWriter.WriteValue(2);
                          xmlTextWriter.WriteEndElement();
                        }
                        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.HPImmersion, "Yes", false) == 0 & !flag5)
                        {
                          xmlTextWriter.WriteStartElement("SAP:Is-Immersion-For-Summer-Use");
                          xmlTextWriter.WriteValue("true");
                          xmlTextWriter.WriteEndElement();
                          xmlTextWriter.WriteStartElement("SAP:Immersion-Heating-Type");
                          // ISSUE: reference to a compiler-generated field
                          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.Cylinder.Immersion, "Dual", false) == 0)
                            xmlTextWriter.WriteValue(1);
                          else
                            xmlTextWriter.WriteValue(2);
                          xmlTextWriter.WriteEndElement();
                        }
                        else
                        {
                          // ISSUE: reference to a compiler-generated field
                          // ISSUE: reference to a compiler-generated field
                          if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.Cylinder.Immersion, "", false) > 0U && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.Fuel, "Electricity", false) == 0)
                          {
                            // ISSUE: reference to a compiler-generated field
                            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.SGroup, "Heat pumps", false) == 0)
                            {
                              xmlTextWriter.WriteStartElement("SAP:Immersion-Heating-Type");
                              // ISSUE: reference to a compiler-generated field
                              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.Cylinder.Immersion, "Dual", false) == 0)
                                xmlTextWriter.WriteValue(1);
                              else
                                xmlTextWriter.WriteValue(2);
                              xmlTextWriter.WriteEndElement();
                            }
                            else
                            {
                              // ISSUE: reference to a compiler-generated field
                              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.SGroup, "Gas boilers and oil boilers", false) == 0)
                              {
                                xmlTextWriter.WriteStartElement("SAP:Immersion-Heating-Type");
                                // ISSUE: reference to a compiler-generated field
                                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.Cylinder.Immersion, "Dual", false) == 0)
                                  xmlTextWriter.WriteValue(1);
                                else
                                  xmlTextWriter.WriteValue(2);
                                xmlTextWriter.WriteEndElement();
                              }
                              else
                              {
                                // ISSUE: reference to a compiler-generated field
                                switch (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.SAPTableCode)
                                {
                                  case 102:
                                  case (int) sbyte.MaxValue:
                                  case 153:
                                  case 156:
                                  case 158:
                                  case 191:
                                  case 306:
                                  case 309:
                                  case 402:
                                  case 408:
                                  case 421:
                                  case 423:
                                  case 510:
                                  case 694:
                                  case 701:
                                    // ISSUE: reference to a compiler-generated field
                                    if (!string.IsNullOrEmpty(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.Cylinder.Immersion))
                                    {
                                      xmlTextWriter.WriteStartElement("SAP:Immersion-Heating-Type");
                                      // ISSUE: reference to a compiler-generated field
                                      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.Cylinder.Immersion, "Dual", false) == 0)
                                      {
                                        xmlTextWriter.WriteValue(1);
                                        xmlTextWriter.WriteEndElement();
                                      }
                                      else
                                      {
                                        xmlTextWriter.WriteValue(2);
                                        xmlTextWriter.WriteEndElement();
                                      }
                                      break;
                                    }
                                    break;
                                }
                              }
                            }
                          }
                        }
                        // ISSUE: reference to a compiler-generated field
                        if ((double) SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.Cylinder.Volume != 0.0)
                        {
                          xmlTextWriter.WriteStartElement("SAP:Hot-Water-Store-Size");
                          // ISSUE: reference to a compiler-generated field
                          xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.Cylinder.Volume);
                          xmlTextWriter.WriteEndElement();
                          // ISSUE: reference to a compiler-generated field
                          // ISSUE: reference to a compiler-generated field
                          // ISSUE: reference to a compiler-generated field
                          // ISSUE: reference to a compiler-generated field
                          // ISSUE: reference to a compiler-generated field
                          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.SGroup, "Heat pumps", false) == 0 & SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.SystemRef == 901 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.SGroup, "Heat pumps", false) == 0 & SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.SystemRef == 903 && (double) SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.Cylinder.HPExchanger > 0.0)
                          {
                            xmlTextWriter.WriteStartElement("SAP:Hot-Water-Store-Heat-Transfer-Area");
                            // ISSUE: reference to a compiler-generated field
                            xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.Cylinder.HPExchanger);
                            xmlTextWriter.WriteEndElement();
                          }
                          xmlTextWriter.WriteStartElement("SAP:Hot-Water-Store-Heat-Loss-Source");
                          // ISSUE: reference to a compiler-generated field
                          if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.Cylinder.ManuSpecified)
                          {
                            xmlTextWriter.WriteValue(2);
                            xmlTextWriter.WriteEndElement();
                            xmlTextWriter.WriteStartElement("SAP:Hot-Water-Store-Heat-Loss");
                            // ISSUE: reference to a compiler-generated field
                            xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.Cylinder.DeclaredLoss);
                            xmlTextWriter.WriteEndElement();
                          }
                          else
                          {
                            xmlTextWriter.WriteValue(3);
                            xmlTextWriter.WriteEndElement();
                            xmlTextWriter.WriteStartElement("SAP:Hot-Water-Store-Insulation-Type");
                            // ISSUE: reference to a compiler-generated field
                            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.Cylinder.Insulation, "Factory", false) == 0)
                              xmlTextWriter.WriteValue(1);
                            else
                              xmlTextWriter.WriteValue(2);
                            xmlTextWriter.WriteEndElement();
                            xmlTextWriter.WriteStartElement("SAP:Hot-Water-Store-Insulation-Thickness");
                            // ISSUE: reference to a compiler-generated field
                            xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.Cylinder.InsThick);
                            xmlTextWriter.WriteEndElement();
                          }
                        }
                        // ISSUE: reference to a compiler-generated field
                        int systemRef1 = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.SystemRef;
                        if (systemRef1 == 901)
                        {
                          // ISSUE: reference to a compiler-generated field
                          int sapTableCode21 = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.SAPTableCode;
                          // ISSUE: reference to a compiler-generated field
                          if (sapTableCode21 != 104 && sapTableCode21 != 105 && sapTableCode21 != 107 && sapTableCode21 != 108 && sapTableCode21 != 112 && sapTableCode21 != 113 && sapTableCode21 != 118 && sapTableCode21 != 128 && sapTableCode21 != 129 && (sapTableCode21 < 191 || sapTableCode21 > 196) && (sapTableCode21 < 120 || sapTableCode21 > 123) && (sapTableCode21 < 306 || sapTableCode21 > 310) && (double) SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.Cylinder.Volume != 0.0)
                          {
                            xmlTextWriter.WriteStartElement("SAP:Is-Primary-Pipework-Insulated");
                            // ISSUE: reference to a compiler-generated field
                            xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.Cylinder.PipeWorkInsulated);
                            xmlTextWriter.WriteEndElement();
                            // ISSUE: reference to a compiler-generated field
                            if (!SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.Thermal.Include)
                            {
                              xmlTextWriter.WriteStartElement("SAP:Has-Cylinder-Thermostat");
                              // ISSUE: reference to a compiler-generated field
                              xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.Cylinder.Thermostat);
                              xmlTextWriter.WriteEndElement();
                            }
                          }
                        }
                        else if (systemRef1 >= 911 && systemRef1 <= 931)
                        {
                          xmlTextWriter.WriteStartElement("SAP:Is-Primary-Pipework-Insulated");
                          // ISSUE: reference to a compiler-generated field
                          xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.Cylinder.PipeWorkInsulated);
                          xmlTextWriter.WriteEndElement();
                          // ISSUE: reference to a compiler-generated field
                          if (!SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.Thermal.Include)
                          {
                            xmlTextWriter.WriteStartElement("SAP:Has-Cylinder-Thermostat");
                            // ISSUE: reference to a compiler-generated field
                            xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.Cylinder.Thermostat);
                            xmlTextWriter.WriteEndElement();
                          }
                        }
                        else
                        {
                          // ISSUE: reference to a compiler-generated field
                          if (systemRef1 == 902 && SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].SecHeating.SAPTableCode == 606)
                          {
                            xmlTextWriter.WriteStartElement("SAP:Has-Cylinder-Thermostat");
                            // ISSUE: reference to a compiler-generated field
                            xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.Cylinder.Thermostat);
                            xmlTextWriter.WriteEndElement();
                          }
                        }
                        // ISSUE: reference to a compiler-generated field
                        if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.Cylinder.InHeatedSpace)
                        {
                          // ISSUE: reference to a compiler-generated field
                          if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.SAPTableCode != 192)
                          {
                            xmlTextWriter.WriteStartElement("SAP:Is-Cylinder-In-Heated-Space");
                            xmlTextWriter.WriteValue("true");
                            xmlTextWriter.WriteEndElement();
                          }
                        }
                        else
                        {
                          bool flag6;
                          if (!flag6)
                          {
                            // ISSUE: reference to a compiler-generated field
                            if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.SystemRef == 901)
                            {
                              // ISSUE: reference to a compiler-generated field
                              int sapTableCode22 = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.SAPTableCode;
                              if (sapTableCode22 != 104 && sapTableCode22 != 105 && sapTableCode22 != 107 && sapTableCode22 != 108 && sapTableCode22 != 112 && sapTableCode22 != 113 && sapTableCode22 != 118 && sapTableCode22 != 128 && sapTableCode22 != 129 && sapTableCode22 != (int) sbyte.MaxValue && (sapTableCode22 < 191 || sapTableCode22 > 196) && (sapTableCode22 < 120 || sapTableCode22 > 123) && (sapTableCode22 < 306 || sapTableCode22 > 310))
                              {
                                if (sapTableCode22 == 0)
                                {
                                  // ISSUE: reference to a compiler-generated field
                                  // ISSUE: reference to a compiler-generated field
                                  // ISSUE: reference to a compiler-generated field
                                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.SGroup, "Gas boilers and oil boilers", false) == 0 && SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.Thermal.Include && (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.Thermal.Location, "In an airing cupboard", false) > 0U)
                                  {
                                    xmlTextWriter.WriteStartElement("SAP:Is-Cylinder-In-Heated-Space");
                                    // ISSUE: reference to a compiler-generated field
                                    xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.Cylinder.InHeatedSpace);
                                    xmlTextWriter.WriteEndElement();
                                    flag6 = true;
                                  }
                                }
                                else
                                {
                                  xmlTextWriter.WriteStartElement("SAP:Is-Cylinder-In-Heated-Space");
                                  // ISSUE: reference to a compiler-generated field
                                  xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.Cylinder.InHeatedSpace);
                                  xmlTextWriter.WriteEndElement();
                                  flag6 = true;
                                }
                              }
                            }
                            flag6 = true;
                          }
                        }
                        // ISSUE: reference to a compiler-generated field
                        switch (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.SystemRef)
                        {
                          case 901:
                            // ISSUE: reference to a compiler-generated field
                            int sapTableCode23 = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.SAPTableCode;
                            if (sapTableCode23 != 104 && sapTableCode23 != 105 && sapTableCode23 != 107 && sapTableCode23 != 108 && sapTableCode23 != 112 && sapTableCode23 != 113 && sapTableCode23 != 118 && sapTableCode23 != 128 && sapTableCode23 != 129 && (sapTableCode23 < 191 || sapTableCode23 > 196) && (sapTableCode23 < 306 || sapTableCode23 > 310))
                            {
                              if (sapTableCode23 >= 120 && sapTableCode23 <= 123 || sapTableCode23 == (int) sbyte.MaxValue)
                              {
                                xmlTextWriter.WriteStartElement("SAP:Is-Hot-Water-Separately-Timed");
                                // ISSUE: reference to a compiler-generated field
                                xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.Cylinder.Timed);
                                xmlTextWriter.WriteEndElement();
                                break;
                              }
                              switch (sapTableCode23)
                              {
                                case 0:
                                  // ISSUE: reference to a compiler-generated field
                                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.SGroup, "Gas boilers and oil boilers", false) == 0)
                                  {
                                    if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.SearchBoilerRow.MainType, "2", false) > 0U)
                                    {
                                      xmlTextWriter.WriteStartElement("SAP:Is-Hot-Water-Separately-Timed");
                                      // ISSUE: reference to a compiler-generated field
                                      xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.Cylinder.Timed);
                                      xmlTextWriter.WriteEndElement();
                                      break;
                                    }
                                    break;
                                  }
                                  // ISSUE: reference to a compiler-generated field
                                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.SGroup, "Micro-cogeneration (micro-CHP)", false) == 0)
                                  {
                                    // ISSUE: reference to a compiler-generated field
                                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.Fuel, "mains gas", false) == 0)
                                    {
                                      xmlTextWriter.WriteStartElement("SAP:Is-Hot-Water-Separately-Timed");
                                      // ISSUE: reference to a compiler-generated field
                                      xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.Cylinder.Timed);
                                      xmlTextWriter.WriteEndElement();
                                      break;
                                    }
                                    break;
                                  }
                                  // ISSUE: reference to a compiler-generated field
                                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.SGroup, "Heat pumps", false) == 0)
                                  {
                                    // ISSUE: reference to a compiler-generated field
                                    if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.Cylinder.Timed)
                                    {
                                      xmlTextWriter.WriteStartElement("SAP:Is-Hot-Water-Separately-Timed");
                                      // ISSUE: reference to a compiler-generated field
                                      xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.Cylinder.Timed);
                                      xmlTextWriter.WriteEndElement();
                                    }
                                    else
                                    {
                                      // ISSUE: reference to a compiler-generated field
                                      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.Fuel, "Electricity", false) == 0)
                                      {
                                        xmlTextWriter.WriteStartElement("SAP:Is-Hot-Water-Separately-Timed");
                                        // ISSUE: reference to a compiler-generated field
                                        xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.Cylinder.Timed);
                                        xmlTextWriter.WriteEndElement();
                                      }
                                    }
                                    break;
                                  }
                                  break;
                                case 636:
                                  break;
                                default:
                                  xmlTextWriter.WriteStartElement("SAP:Is-Hot-Water-Separately-Timed");
                                  // ISSUE: reference to a compiler-generated field
                                  xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.Cylinder.Timed);
                                  xmlTextWriter.WriteEndElement();
                                  break;
                              }
                            }
                            else
                              break;
                            break;
                          case 914:
                            xmlTextWriter.WriteStartElement("SAP:Is-Hot-Water-Separately-Timed");
                            // ISSUE: reference to a compiler-generated field
                            xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.Cylinder.Timed);
                            xmlTextWriter.WriteEndElement();
                            break;
                        }
                        // ISSUE: reference to a compiler-generated field
                        if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.Thermal.Include)
                        {
                          xmlTextWriter.WriteStartElement("SAP:Is-Thermal-Store-Or-CPSU-In-Airing-Cupboard");
                          // ISSUE: reference to a compiler-generated field
                          // ISSUE: reference to a compiler-generated field
                          if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.Thermal.Location, "Not in an airing cupboard", false) > 0U | (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.Thermal.Location, "", false) > 0U)
                            xmlTextWriter.WriteValue("true");
                          else
                            xmlTextWriter.WriteValue("false");
                          xmlTextWriter.WriteEndElement();
                        }
                        else
                        {
                          // ISSUE: reference to a compiler-generated field
                          int sapTableCode24 = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.SAPTableCode;
                          if (sapTableCode24 == 102 || sapTableCode24 == (int) sbyte.MaxValue)
                          {
                            // ISSUE: reference to a compiler-generated field
                            if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.Thermal.Include)
                            {
                              xmlTextWriter.WriteStartElement("SAP:Is-Thermal-Store-Or-CPSU-In-Airing-Cupboard");
                              // ISSUE: reference to a compiler-generated field
                              if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.Thermal.Location, "Not in an airing cupboard", false) > 0U)
                                xmlTextWriter.WriteValue("true");
                              else
                                xmlTextWriter.WriteValue("false");
                              xmlTextWriter.WriteEndElement();
                            }
                          }
                          else if (sapTableCode24 >= 120 && sapTableCode24 <= 123)
                          {
                            xmlTextWriter.WriteStartElement("SAP:Is-Thermal-Store-Or-CPSU-In-Airing-Cupboard");
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.Thermal.Location, "Not in an airing cupboard", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.Thermal.Location, "", false) == 0)
                              xmlTextWriter.WriteValue("false");
                            else
                              xmlTextWriter.WriteValue("true");
                            xmlTextWriter.WriteEndElement();
                          }
                          else if (sapTableCode24 == 192)
                          {
                            xmlTextWriter.WriteStartElement("SAP:Is-Thermal-Store-Or-CPSU-In-Airing-Cupboard");
                            xmlTextWriter.WriteValue("false");
                            xmlTextWriter.WriteEndElement();
                          }
                        }
                        // ISSUE: reference to a compiler-generated field
                        if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.Thermal.Include)
                        {
                          xmlTextWriter.WriteStartElement("SAP:Is-Thermal-Store-Near-Boiler");
                          // ISSUE: reference to a compiler-generated field
                          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.Thermal.Connection, "> 1.5 m of primary pipework", false) == 0)
                            xmlTextWriter.WriteValue("false");
                          else
                            xmlTextWriter.WriteValue("true");
                          xmlTextWriter.WriteEndElement();
                        }
                        // ISSUE: reference to a compiler-generated field
                        if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.WWHRS.Include)
                        {
                          xmlTextWriter.WriteStartElement("SAP:Has-WWHRS");
                          // ISSUE: reference to a compiler-generated field
                          xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.WWHRS.Include);
                          xmlTextWriter.WriteEndElement();
                          xmlTextWriter.WriteStartElement("SAP:WWHRS-Index-Number1");
                          // ISSUE: reference to a compiler-generated field
                          xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.WWHRS.Systems[0].SystemsRef);
                          xmlTextWriter.WriteEndElement();
                          xmlTextWriter.WriteStartElement("SAP:WWHRS-Index-Number2");
                          // ISSUE: reference to a compiler-generated field
                          if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.WWHRS.Systems[1].SystemsRef, "", false) > 0U)
                          {
                            // ISSUE: reference to a compiler-generated field
                            xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.WWHRS.Systems[1].SystemsRef);
                          }
                          else
                            xmlTextWriter.WriteValue(0);
                          xmlTextWriter.WriteEndElement();
                          xmlTextWriter.WriteStartElement("SAP:Rooms-With-Bath-And-Or-Shower");
                          // ISSUE: reference to a compiler-generated field
                          xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.WWHRS.TotalRooms);
                          xmlTextWriter.WriteEndElement();
                          xmlTextWriter.WriteStartElement("SAP:Mixer-Showers-With-System1-With-Bath");
                          // ISSUE: reference to a compiler-generated field
                          xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.WWHRS.Systems[0].WithBath);
                          xmlTextWriter.WriteEndElement();
                          xmlTextWriter.WriteStartElement("SAP:Mixer-Showers-With-System1-Without-Bath");
                          // ISSUE: reference to a compiler-generated field
                          xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.WWHRS.Systems[0].WithNoBath);
                          xmlTextWriter.WriteEndElement();
                          xmlTextWriter.WriteStartElement("SAP:Mixer-Showers-With-System2-With-Bath");
                          // ISSUE: reference to a compiler-generated field
                          if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.WWHRS.Systems[1].SystemsRef, "", false) > 0U)
                          {
                            // ISSUE: reference to a compiler-generated field
                            xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.WWHRS.Systems[1].WithBath);
                          }
                          else
                            xmlTextWriter.WriteValue(0);
                          xmlTextWriter.WriteEndElement();
                          xmlTextWriter.WriteStartElement("SAP:Mixer-Showers-With-System2-Without-Bath");
                          // ISSUE: reference to a compiler-generated field
                          if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.WWHRS.Systems[1].SystemsRef, "", false) > 0U)
                          {
                            // ISSUE: reference to a compiler-generated field
                            xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.WWHRS.Systems[1].WithNoBath);
                          }
                          else
                            xmlTextWriter.WriteValue(0);
                          xmlTextWriter.WriteEndElement();
                        }
                        xmlTextWriter.WriteStartElement("SAP:Has-Solar-Panel");
                        // ISSUE: reference to a compiler-generated field
                        xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.Solar.Inlcude);
                        xmlTextWriter.WriteEndElement();
                        // ISSUE: reference to a compiler-generated field
                        if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.Solar.Inlcude)
                        {
                          xmlTextWriter.WriteStartElement("SAP:Solar-Panel-Aperture-Area");
                          // ISSUE: reference to a compiler-generated field
                          xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.Solar.SolarArea);
                          xmlTextWriter.WriteEndElement();
                          xmlTextWriter.WriteStartElement("SAP:Solar-Panel-Collector-Type");
                          // ISSUE: reference to a compiler-generated field
                          string solarType = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.Solar.SolarType;
                          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(solarType, "Unglazed", false) != 0)
                          {
                            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(solarType, "Flat plate", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(solarType, "Flat plate, glazed", false) != 0)
                            {
                              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(solarType, "Evacuated tube", false) == 0)
                                xmlTextWriter.WriteValue(3);
                            }
                            else
                              xmlTextWriter.WriteValue(2);
                          }
                          else
                            xmlTextWriter.WriteValue(1);
                          xmlTextWriter.WriteEndElement();
                          xmlTextWriter.WriteStartElement("SAP:Solar-Panel-Collector-Data-Source");
                          // ISSUE: reference to a compiler-generated field
                          if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.Solar.Overide)
                            xmlTextWriter.WriteValue(2);
                          else
                            xmlTextWriter.WriteValue(1);
                          xmlTextWriter.WriteEndElement();
                          // ISSUE: reference to a compiler-generated field
                          if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.Solar.Overide)
                          {
                            xmlTextWriter.WriteStartElement("SAP:Solar-Panel-Collector-Zero-Loss-Efficiency");
                            // ISSUE: reference to a compiler-generated field
                            xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.Solar.SolarZero * 100f);
                            xmlTextWriter.WriteEndElement();
                            xmlTextWriter.WriteStartElement("SAP:Solar-Panel-Collector-Heat-Loss-Rate");
                            // ISSUE: reference to a compiler-generated field
                            xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.Solar.SolarHLoss);
                            xmlTextWriter.WriteEndElement();
                          }
                          xmlTextWriter.WriteStartElement("SAP:Solar-Panel-Collector-Orientation");
                          // ISSUE: reference to a compiler-generated field
                          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.Solar.SolarTilt, "Horizontal", false) == 0)
                          {
                            xmlTextWriter.WriteValue("ND");
                          }
                          else
                          {
                            // ISSUE: reference to a compiler-generated field
                            string solarOrientation = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.Solar.SolarOrientation;
                            // ISSUE: reference to a compiler-generated method
                            switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(solarOrientation))
                            {
                              case 912749504:
                                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(solarOrientation, "SE/SW", false) == 0)
                                  break;
                                goto default;
                              case 1128440633:
                                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(solarOrientation, "North East", false) == 0)
                                  goto label_1995;
                                else
                                  goto default;
                              case 1409318971:
                                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(solarOrientation, "North West", false) == 0)
                                {
                                  xmlTextWriter.WriteValue(8);
                                  goto default;
                                }
                                else
                                  goto default;
                              case 1682370166:
                                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(solarOrientation, "NE/NW", false) == 0)
                                  goto label_1995;
                                else
                                  goto default;
                              case 1731397980:
                                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(solarOrientation, "East", false) == 0)
                                {
                                  xmlTextWriter.WriteValue(3);
                                  goto default;
                                }
                                else
                                  goto default;
                              case 1734234020:
                                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(solarOrientation, "North", false) == 0)
                                {
                                  xmlTextWriter.WriteValue(1);
                                  goto default;
                                }
                                else
                                  goto default;
                              case 1796576718:
                                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(solarOrientation, "West", false) == 0)
                                  goto label_1994;
                                else
                                  goto default;
                              case 2417407149:
                                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(solarOrientation, "South West", false) == 0)
                                {
                                  xmlTextWriter.WriteValue(4);
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
                                  xmlTextWriter.WriteValue(5);
                                  goto default;
                                }
                                else
                                  goto default;
                              case 4260797214:
                                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(solarOrientation, "E/W", false) == 0)
                                  goto label_1994;
                                else
                                  goto default;
                              default:
label_1998:
                                goto label_1999;
                            }
                            xmlTextWriter.WriteValue(6);
                            goto label_1998;
label_1994:
                            xmlTextWriter.WriteValue(7);
                            goto label_1998;
label_1995:
                            xmlTextWriter.WriteValue(2);
                            goto label_1998;
                          }
label_1999:
                          xmlTextWriter.WriteEndElement();
                          xmlTextWriter.WriteStartElement("SAP:Solar-Panel-Collector-Pitch");
                          // ISSUE: reference to a compiler-generated field
                          string solarTilt = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.Solar.SolarTilt;
                          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(solarTilt, "Horizontal", false) != 0)
                          {
                            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(solarTilt, "30°", false) != 0)
                            {
                              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(solarTilt, "45°", false) != 0)
                              {
                                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(solarTilt, "60°", false) != 0)
                                {
                                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(solarTilt, "Vertical", false) == 0)
                                    xmlTextWriter.WriteValue(5);
                                }
                                else
                                  xmlTextWriter.WriteValue(4);
                              }
                              else
                                xmlTextWriter.WriteValue(3);
                            }
                            else
                              xmlTextWriter.WriteValue(2);
                          }
                          else
                            xmlTextWriter.WriteValue(1);
                          xmlTextWriter.WriteEndElement();
                          xmlTextWriter.WriteStartElement("SAP:Solar-Panel-Collector-Overshading");
                          // ISSUE: reference to a compiler-generated field
                          string solarOvershading = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.Solar.SolarOvershading;
                          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(solarOvershading, "None or Very Little (<20%)", false) != 0)
                          {
                            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(solarOvershading, "Modest (20% - 60%)", false) != 0)
                            {
                              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(solarOvershading, "Significant (>60% - 80%)", false) != 0)
                              {
                                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(solarOvershading, "Heavy (>80%)", false) == 0)
                                  xmlTextWriter.WriteValue(4);
                              }
                              else
                                xmlTextWriter.WriteValue(3);
                            }
                            else
                              xmlTextWriter.WriteValue(2);
                          }
                          else
                            xmlTextWriter.WriteValue(1);
                          xmlTextWriter.WriteEndElement();
                          xmlTextWriter.WriteStartElement("SAP:Has-Solar-Powered-Pump");
                          // ISSUE: reference to a compiler-generated field
                          xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.Solar.Pumped);
                          xmlTextWriter.WriteEndElement();
                          xmlTextWriter.WriteStartElement("SAP:Solar-Store-Volume");
                          // ISSUE: reference to a compiler-generated field
                          xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.Solar.SolarVolume);
                          xmlTextWriter.WriteEndElement();
                          xmlTextWriter.WriteStartElement("SAP:Is-Solar-Store-Combined-Cylinder");
                          // ISSUE: reference to a compiler-generated field
                          xmlTextWriter.WriteValue(!SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.Solar.SolarSeperate);
                          xmlTextWriter.WriteEndElement();
                        }
                        // ISSUE: reference to a compiler-generated field
                        int sapTableCode25 = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.SAPTableCode;
                        bool flag7;
                        bool flag8;
                        if (sapTableCode25 >= 306 && sapTableCode25 <= 310)
                        {
                          flag7 = true;
                          xmlTextWriter.WriteStartElement("SAP:SAP-Community-Heating-Systems");
                          xmlTextWriter.WriteStartElement("SAP:SAP-Community-Heating-System");
                          flag8 = true;
                          xmlTextWriter.WriteStartElement("SAP:Community-Heating-Use");
                          // ISSUE: reference to a compiler-generated field
                          if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.SystemRef == 901)
                            xmlTextWriter.WriteValue(3);
                          else
                            xmlTextWriter.WriteValue(1);
                          xmlTextWriter.WriteEndElement();
                          xmlTextWriter.WriteStartElement("SAP:Community-Heat-Sources");
                          xmlTextWriter.WriteStartElement("SAP:Community-Heat-Source");
                          xmlTextWriter.WriteStartElement("SAP:Heat-Source-Type");
                          switch (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SAPTableCode)
                          {
                            case 306:
                              xmlTextWriter.WriteValue(2);
                              break;
                            case 307:
                              xmlTextWriter.WriteValue(1);
                              break;
                            case 308:
                              xmlTextWriter.WriteValue(4);
                              break;
                            case 309:
                              xmlTextWriter.WriteValue(3);
                              break;
                            case 310:
                              xmlTextWriter.WriteValue(5);
                              break;
                          }
                          xmlTextWriter.WriteEndElement();
                          xmlTextWriter.WriteStartElement("SAP:Description");
                          xmlTextWriter.WriteEndElement();
                          xmlTextWriter.WriteStartElement("SAP:Fuel-Type");
                          // ISSUE: reference to a compiler-generated field
                          xmlTextWriter.WriteValue(PDFFunctions.CheckFuelCode(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.Fuel));
                          xmlTextWriter.WriteEndElement();
                          xmlTextWriter.WriteStartElement("SAP:Heat-Fraction");
                          // ISSUE: reference to a compiler-generated field
                          xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.Boiler1HeatFraction);
                          xmlTextWriter.WriteEndElement();
                          xmlTextWriter.WriteStartElement("SAP:Efficiency");
                          // ISSUE: reference to a compiler-generated field
                          xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.Boiler1Efficiency);
                          xmlTextWriter.WriteEndElement();
                          // ISSUE: reference to a compiler-generated field
                          if ((double) SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatToPowerRatio > 0.0)
                          {
                            xmlTextWriter.WriteStartElement("SAP:CHP-Heat-To-Power-Ratio");
                            // ISSUE: reference to a compiler-generated field
                            xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatToPowerRatio);
                            xmlTextWriter.WriteEndElement();
                          }
                          xmlTextWriter.WriteEndElement();
                          if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.NoOfAdditionalHeatSources > 0)
                          {
                            xmlTextWriter.WriteStartElement("SAP:Community-Heat-Source");
                            xmlTextWriter.WriteStartElement("SAP:Heat-Source-Type");
                            // ISSUE: reference to a compiler-generated field
                            switch (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatSource1.Type)
                            {
                              case 306:
                                xmlTextWriter.WriteValue(2);
                                break;
                              case 307:
                                xmlTextWriter.WriteValue(1);
                                break;
                              case 308:
                                xmlTextWriter.WriteValue(4);
                                break;
                              case 309:
                                xmlTextWriter.WriteValue(3);
                                break;
                              case 310:
                                xmlTextWriter.WriteValue(5);
                                break;
                            }
                            xmlTextWriter.WriteEndElement();
                            xmlTextWriter.WriteStartElement("SAP:Description");
                            xmlTextWriter.WriteEndElement();
                            xmlTextWriter.WriteStartElement("SAP:Fuel-Type");
                            // ISSUE: reference to a compiler-generated field
                            xmlTextWriter.WriteValue(PDFFunctions.CheckFuelCode(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatSource1.Fuel));
                            xmlTextWriter.WriteEndElement();
                            xmlTextWriter.WriteStartElement("SAP:Heat-Fraction");
                            // ISSUE: reference to a compiler-generated field
                            xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatSource1.HeatFraction);
                            xmlTextWriter.WriteEndElement();
                            xmlTextWriter.WriteStartElement("SAP:Efficiency");
                            // ISSUE: reference to a compiler-generated field
                            xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatSource1.Efficiency);
                            xmlTextWriter.WriteEndElement();
                            xmlTextWriter.WriteEndElement();
                          }
                          if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.NoOfAdditionalHeatSources > 1)
                          {
                            xmlTextWriter.WriteStartElement("SAP:Community-Heat-Source");
                            xmlTextWriter.WriteStartElement("SAP:Heat-Source-Type");
                            // ISSUE: reference to a compiler-generated field
                            switch (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatSource2.Type)
                            {
                              case 306:
                                xmlTextWriter.WriteValue(2);
                                break;
                              case 307:
                                xmlTextWriter.WriteValue(1);
                                break;
                              case 308:
                                xmlTextWriter.WriteValue(4);
                                break;
                              case 309:
                                xmlTextWriter.WriteValue(3);
                                break;
                              case 310:
                                xmlTextWriter.WriteValue(5);
                                break;
                            }
                            xmlTextWriter.WriteEndElement();
                            xmlTextWriter.WriteStartElement("SAP:Description");
                            xmlTextWriter.WriteEndElement();
                            xmlTextWriter.WriteStartElement("SAP:Fuel-Type");
                            // ISSUE: reference to a compiler-generated field
                            xmlTextWriter.WriteValue(PDFFunctions.CheckFuelCode(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatSource2.Fuel));
                            xmlTextWriter.WriteEndElement();
                            xmlTextWriter.WriteStartElement("SAP:Heat-Fraction");
                            // ISSUE: reference to a compiler-generated field
                            xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatSource2.HeatFraction);
                            xmlTextWriter.WriteEndElement();
                            xmlTextWriter.WriteStartElement("SAP:Efficiency");
                            // ISSUE: reference to a compiler-generated field
                            xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatSource2.Efficiency);
                            xmlTextWriter.WriteEndElement();
                            xmlTextWriter.WriteEndElement();
                          }
                          // ISSUE: reference to a compiler-generated field
                          if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.NoOfAdditionalHeatSources > 2)
                          {
                            xmlTextWriter.WriteStartElement("SAP:Community-Heat-Source");
                            xmlTextWriter.WriteStartElement("SAP:Heat-Source-Type");
                            // ISSUE: reference to a compiler-generated field
                            switch (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatSource3.Type)
                            {
                              case 306:
                                xmlTextWriter.WriteValue(2);
                                break;
                              case 307:
                                xmlTextWriter.WriteValue(1);
                                break;
                              case 308:
                                xmlTextWriter.WriteValue(4);
                                break;
                              case 309:
                                xmlTextWriter.WriteValue(3);
                                break;
                              case 310:
                                xmlTextWriter.WriteValue(5);
                                break;
                            }
                            xmlTextWriter.WriteEndElement();
                            xmlTextWriter.WriteStartElement("SAP:Description");
                            xmlTextWriter.WriteEndElement();
                            xmlTextWriter.WriteStartElement("SAP:Fuel-Type");
                            // ISSUE: reference to a compiler-generated field
                            xmlTextWriter.WriteValue(PDFFunctions.CheckFuelCode(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatSource3.Fuel));
                            xmlTextWriter.WriteEndElement();
                            xmlTextWriter.WriteStartElement("SAP:Heat-Fraction");
                            // ISSUE: reference to a compiler-generated field
                            xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatSource3.HeatFraction);
                            xmlTextWriter.WriteEndElement();
                            xmlTextWriter.WriteStartElement("SAP:Efficiency");
                            // ISSUE: reference to a compiler-generated field
                            xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatSource3.Efficiency);
                            xmlTextWriter.WriteEndElement();
                            xmlTextWriter.WriteEndElement();
                          }
                          if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.NoOfAdditionalHeatSources > 3)
                          {
                            xmlTextWriter.WriteStartElement("SAP:Community-Heat-Source");
                            xmlTextWriter.WriteStartElement("SAP:Heat-Source-Type");
                            // ISSUE: reference to a compiler-generated field
                            switch (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatSource4.Type)
                            {
                              case 306:
                                xmlTextWriter.WriteValue(2);
                                break;
                              case 307:
                                xmlTextWriter.WriteValue(1);
                                break;
                              case 308:
                                xmlTextWriter.WriteValue(4);
                                break;
                              case 309:
                                xmlTextWriter.WriteValue(3);
                                break;
                              case 310:
                                xmlTextWriter.WriteValue(5);
                                break;
                            }
                            xmlTextWriter.WriteEndElement();
                            xmlTextWriter.WriteStartElement("SAP:Description");
                            xmlTextWriter.WriteEndElement();
                            xmlTextWriter.WriteStartElement("SAP:Fuel-Type");
                            // ISSUE: reference to a compiler-generated field
                            xmlTextWriter.WriteValue(PDFFunctions.CheckFuelCode(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatSource4.Fuel));
                            xmlTextWriter.WriteEndElement();
                            xmlTextWriter.WriteStartElement("SAP:Heat-Fraction");
                            // ISSUE: reference to a compiler-generated field
                            xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatSource4.HeatFraction);
                            xmlTextWriter.WriteEndElement();
                            xmlTextWriter.WriteStartElement("SAP:Efficiency");
                            // ISSUE: reference to a compiler-generated field
                            xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatSource4.Efficiency);
                            xmlTextWriter.WriteEndElement();
                            xmlTextWriter.WriteEndElement();
                          }
                          xmlTextWriter.WriteEndElement();
                          // ISSUE: reference to a compiler-generated field
                          if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.HWSComm.Charging != null)
                          {
                            xmlTextWriter.WriteStartElement("SAP:Charging-Linked-To-Heat-Use");
                            // ISSUE: reference to a compiler-generated field
                            if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.HWSComm.Charging.Contains("Charged"))
                              xmlTextWriter.WriteValue("true");
                            else
                              xmlTextWriter.WriteValue("false");
                            xmlTextWriter.WriteEndElement();
                          }
                          else
                          {
                            xmlTextWriter.WriteStartElement("SAP:Charging-Linked-To-Heat-Use");
                            xmlTextWriter.WriteValue("false");
                            xmlTextWriter.WriteEndElement();
                          }
                          xmlTextWriter.WriteStartElement("SAP:Community-Heating-Distribution-Type");
                          // ISSUE: reference to a compiler-generated field
                          string heatDsystem = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatDSystem;
                          // ISSUE: reference to a compiler-generated method
                          switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(heatDsystem))
                          {
                            case 1158145841:
                              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(heatDsystem, "Calculated", false) == 0)
                              {
                                xmlTextWriter.WriteValue(5);
                                goto default;
                              }
                              else
                                goto default;
                            case 1676941291:
                              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(heatDsystem, "Piping<=1990, not pre-insulated, medium/high temp, full flow", false) == 0)
                              {
                                xmlTextWriter.WriteValue(1);
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
                                xmlTextWriter.WriteValue(3);
                                goto default;
                              }
                              else
                                goto default;
                            case 3085999378:
                              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(heatDsystem, "Piping<=1990, pre-insulated, low temp, full flow", false) == 0)
                              {
                                xmlTextWriter.WriteValue(2);
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
                                xmlTextWriter.WriteValue(4);
                                goto default;
                              }
                              else
                                goto default;
                            default:
label_2082:
                              xmlTextWriter.WriteEndElement();
                              xmlTextWriter.WriteStartElement("SAP:Is-Community-Heating-Cylinder-In-Dwelling");
                              // ISSUE: reference to a compiler-generated field
                              if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.Cylinder.InHeatedSpace)
                                xmlTextWriter.WriteValue("true");
                              else
                                xmlTextWriter.WriteValue("false");
                              xmlTextWriter.WriteEndElement();
                              xmlTextWriter.WriteEndElement();
                              goto label_2086;
                          }
                          xmlTextWriter.WriteValue(6);
                          goto label_2082;
                        }
label_2086:
                        // ISSUE: reference to a compiler-generated field
                        int systemRef2 = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.SystemRef;
                        bool flag9;
                        if (systemRef2 >= 950 && systemRef2 <= 952)
                        {
                          if (!flag7)
                            xmlTextWriter.WriteStartElement("SAP:SAP-Community-Heating-Systems");
                          flag9 = true;
                          flag7 = true;
                          xmlTextWriter.WriteStartElement("SAP:SAP-Community-Heating-System");
                          xmlTextWriter.WriteStartElement("SAP:Community-Heating-Use");
                          xmlTextWriter.WriteValue(2);
                          xmlTextWriter.WriteEndElement();
                          xmlTextWriter.WriteStartElement("SAP:Community-Heat-Sources");
                          xmlTextWriter.WriteStartElement("SAP:Community-Heat-Source");
                          xmlTextWriter.WriteStartElement("SAP:Heat-Source-Type");
                          // ISSUE: reference to a compiler-generated field
                          switch (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.SystemRef)
                          {
                            case 950:
                              xmlTextWriter.WriteValue(2);
                              break;
                            case 951:
                              xmlTextWriter.WriteValue(1);
                              break;
                            case 952:
                              xmlTextWriter.WriteValue(3);
                              break;
                          }
                          xmlTextWriter.WriteEndElement();
                          xmlTextWriter.WriteStartElement("SAP:Description");
                          xmlTextWriter.WriteEndElement();
                          xmlTextWriter.WriteStartElement("SAP:Fuel-Type");
                          // ISSUE: reference to a compiler-generated field
                          xmlTextWriter.WriteValue(PDFFunctions.CheckFuelCode(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.Fuel));
                          xmlTextWriter.WriteEndElement();
                          xmlTextWriter.WriteStartElement("SAP:Heat-Fraction");
                          // ISSUE: reference to a compiler-generated field
                          xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.HWSComm.Boiler1Fraction);
                          xmlTextWriter.WriteEndElement();
                          xmlTextWriter.WriteStartElement("SAP:Efficiency");
                          // ISSUE: reference to a compiler-generated field
                          xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.HWSComm.Efficiency);
                          xmlTextWriter.WriteEndElement();
                          xmlTextWriter.WriteEndElement();
                          if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.NoOfAdditionalHeatSources > 0)
                          {
                            xmlTextWriter.WriteStartElement("SAP:Community-Heat-Source");
                            xmlTextWriter.WriteStartElement("SAP:Heat-Source-Type");
                            // ISSUE: reference to a compiler-generated field
                            switch (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.HWSComm.HeatSource1.Type)
                            {
                              case 950:
                                xmlTextWriter.WriteValue(2);
                                break;
                              case 951:
                                xmlTextWriter.WriteValue(1);
                                break;
                              case 952:
                                xmlTextWriter.WriteValue(3);
                                break;
                            }
                            xmlTextWriter.WriteEndElement();
                            xmlTextWriter.WriteStartElement("SAP:Description");
                            xmlTextWriter.WriteEndElement();
                            xmlTextWriter.WriteStartElement("SAP:Fuel-Type");
                            // ISSUE: reference to a compiler-generated field
                            xmlTextWriter.WriteValue(PDFFunctions.CheckFuelCode(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.HWSComm.HeatSource1.Fuel));
                            xmlTextWriter.WriteEndElement();
                            xmlTextWriter.WriteStartElement("SAP:Heat-Fraction");
                            // ISSUE: reference to a compiler-generated field
                            xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.HWSComm.HeatSource1.HeatFraction);
                            xmlTextWriter.WriteEndElement();
                            xmlTextWriter.WriteStartElement("SAP:Efficiency");
                            // ISSUE: reference to a compiler-generated field
                            xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.HWSComm.HeatSource1.Efficiency);
                            xmlTextWriter.WriteEndElement();
                            xmlTextWriter.WriteEndElement();
                          }
                          if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.NoOfAdditionalHeatSources > 1)
                          {
                            xmlTextWriter.WriteStartElement("SAP:Community-Heat-Source");
                            xmlTextWriter.WriteStartElement("SAP:Heat-Source-Type");
                            // ISSUE: reference to a compiler-generated field
                            switch (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.HWSComm.HeatSource2.Type)
                            {
                              case 950:
                                xmlTextWriter.WriteValue(2);
                                break;
                              case 951:
                                xmlTextWriter.WriteValue(1);
                                break;
                              case 952:
                                xmlTextWriter.WriteValue(3);
                                break;
                            }
                            xmlTextWriter.WriteEndElement();
                            xmlTextWriter.WriteStartElement("SAP:Description");
                            xmlTextWriter.WriteEndElement();
                            xmlTextWriter.WriteStartElement("SAP:Fuel-Type");
                            // ISSUE: reference to a compiler-generated field
                            xmlTextWriter.WriteValue(PDFFunctions.CheckFuelCode(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.HWSComm.HeatSource2.Fuel));
                            xmlTextWriter.WriteEndElement();
                            xmlTextWriter.WriteStartElement("SAP:Heat-Fraction");
                            // ISSUE: reference to a compiler-generated field
                            xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.HWSComm.HeatSource2.HeatFraction);
                            xmlTextWriter.WriteEndElement();
                            xmlTextWriter.WriteStartElement("SAP:Efficiency");
                            // ISSUE: reference to a compiler-generated field
                            xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.HWSComm.HeatSource2.Efficiency);
                            xmlTextWriter.WriteEndElement();
                            xmlTextWriter.WriteEndElement();
                          }
                          if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.NoOfAdditionalHeatSources > 2)
                          {
                            xmlTextWriter.WriteStartElement("SAP:Community-Heat-Source");
                            xmlTextWriter.WriteStartElement("SAP:Heat-Source-Type");
                            // ISSUE: reference to a compiler-generated field
                            switch (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.HWSComm.HeatSource3.Type)
                            {
                              case 950:
                                xmlTextWriter.WriteValue(2);
                                break;
                              case 951:
                                xmlTextWriter.WriteValue(1);
                                break;
                              case 952:
                                xmlTextWriter.WriteValue(3);
                                break;
                            }
                            xmlTextWriter.WriteEndElement();
                            xmlTextWriter.WriteStartElement("SAP:Description");
                            xmlTextWriter.WriteEndElement();
                            xmlTextWriter.WriteStartElement("SAP:Fuel-Type");
                            // ISSUE: reference to a compiler-generated field
                            xmlTextWriter.WriteValue(PDFFunctions.CheckFuelCode(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.HWSComm.HeatSource3.Fuel));
                            xmlTextWriter.WriteEndElement();
                            xmlTextWriter.WriteStartElement("SAP:Heat-Fraction");
                            // ISSUE: reference to a compiler-generated field
                            xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.HWSComm.HeatSource3.HeatFraction);
                            xmlTextWriter.WriteEndElement();
                            xmlTextWriter.WriteStartElement("SAP:Efficiency");
                            // ISSUE: reference to a compiler-generated field
                            xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.HWSComm.HeatSource3.Efficiency);
                            xmlTextWriter.WriteEndElement();
                            xmlTextWriter.WriteEndElement();
                          }
                          if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.NoOfAdditionalHeatSources > 3)
                          {
                            xmlTextWriter.WriteStartElement("SAP:Community-Heat-Source");
                            xmlTextWriter.WriteStartElement("SAP:Heat-Source-Type");
                            // ISSUE: reference to a compiler-generated field
                            switch (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.HWSComm.HeatSource4.Type)
                            {
                              case 950:
                                xmlTextWriter.WriteValue(2);
                                break;
                              case 951:
                                xmlTextWriter.WriteValue(1);
                                break;
                              case 952:
                                xmlTextWriter.WriteValue(3);
                                break;
                            }
                            xmlTextWriter.WriteEndElement();
                            xmlTextWriter.WriteStartElement("SAP:Description");
                            xmlTextWriter.WriteEndElement();
                            xmlTextWriter.WriteStartElement("SAP:Fuel-Type");
                            // ISSUE: reference to a compiler-generated field
                            xmlTextWriter.WriteValue(PDFFunctions.CheckFuelCode(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.HWSComm.HeatSource4.Fuel));
                            xmlTextWriter.WriteEndElement();
                            xmlTextWriter.WriteStartElement("SAP:Heat-Fraction");
                            // ISSUE: reference to a compiler-generated field
                            xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.HWSComm.HeatSource4.HeatFraction);
                            xmlTextWriter.WriteEndElement();
                            xmlTextWriter.WriteStartElement("SAP:Efficiency");
                            // ISSUE: reference to a compiler-generated field
                            xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.HWSComm.HeatSource4.Efficiency);
                            xmlTextWriter.WriteEndElement();
                            xmlTextWriter.WriteEndElement();
                          }
                          xmlTextWriter.WriteEndElement();
                          xmlTextWriter.WriteStartElement("SAP:Community-Heating-Distribution-Type");
                          // ISSUE: reference to a compiler-generated field
                          string hds = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.HWSComm.HDS;
                          // ISSUE: reference to a compiler-generated method
                          switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(hds))
                          {
                            case 1158145841:
                              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(hds, "Calculated", false) == 0)
                              {
                                xmlTextWriter.WriteValue(5);
                                goto default;
                              }
                              else
                                goto default;
                            case 1676941291:
                              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(hds, "Piping<=1990, not pre-insulated, medium/high temp, full flow", false) == 0)
                              {
                                xmlTextWriter.WriteValue(1);
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
                                xmlTextWriter.WriteValue(3);
                                goto default;
                              }
                              else
                                goto default;
                            case 3085999378:
                              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(hds, "Piping<=1990, pre-insulated, low temp, full flow", false) == 0)
                              {
                                xmlTextWriter.WriteValue(2);
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
                                xmlTextWriter.WriteValue(4);
                                goto default;
                              }
                              else
                                goto default;
                            default:
label_2131:
                              xmlTextWriter.WriteEndElement();
                              // ISSUE: reference to a compiler-generated field
                              if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.HWSComm.Charging.Contains("Charged"))
                              {
                                xmlTextWriter.WriteStartElement("SAP:Charging-Linked-To-Heat-Use");
                                xmlTextWriter.WriteValue("true");
                              }
                              else
                              {
                                xmlTextWriter.WriteStartElement("SAP:Charging-Linked-To-Heat-Use");
                                xmlTextWriter.WriteValue("false");
                              }
                              xmlTextWriter.WriteEndElement();
                              xmlTextWriter.WriteStartElement("SAP:Is-Community-Heating-Cylinder-In-Dwelling");
                              // ISSUE: reference to a compiler-generated field
                              if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.Cylinder.InHeatedSpace)
                              {
                                xmlTextWriter.WriteValue("true");
                              }
                              else
                              {
                                // ISSUE: reference to a compiler-generated field
                                if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Water.HWSComm.CylinderInDwelling)
                                  xmlTextWriter.WriteValue("true");
                                else
                                  xmlTextWriter.WriteValue("false");
                              }
                              xmlTextWriter.WriteEndElement();
                              goto label_2141;
                          }
                          xmlTextWriter.WriteValue(6);
                          goto label_2131;
                        }
label_2141:
                        if (flag7)
                        {
                          if (flag8 & flag9)
                          {
                            xmlTextWriter.WriteEndElement();
                            xmlTextWriter.WriteEndElement();
                          }
                          else if (!flag8 & flag9)
                          {
                            xmlTextWriter.WriteEndElement();
                            xmlTextWriter.WriteEndElement();
                          }
                          else
                            xmlTextWriter.WriteEndElement();
                        }
                        xmlTextWriter.WriteEndElement();
                        // ISSUE: reference to a compiler-generated field
                        if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Cooling.Include)
                        {
                          xmlTextWriter.WriteStartElement("SAP:SAP-Cooling");
                          xmlTextWriter.WriteStartElement("SAP:Cooled-Area");
                          // ISSUE: reference to a compiler-generated field
                          xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Cooling.Cooled_Area);
                          xmlTextWriter.WriteEndElement();
                          xmlTextWriter.WriteStartElement("SAP:Cooling-System-Data-Source");
                          if (num30 == 2 | num30 == 3)
                            xmlTextWriter.WriteValue(3);
                          else
                            xmlTextWriter.WriteValue(num30);
                          xmlTextWriter.WriteEndElement();
                          xmlTextWriter.WriteStartElement("SAP:Cooling-System-Type");
                          // ISSUE: reference to a compiler-generated field
                          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Cooling.SystemType, "Split/multiple systems", false) == 0)
                            xmlTextWriter.WriteValue(1);
                          else
                            xmlTextWriter.WriteValue(2);
                          xmlTextWriter.WriteEndElement();
                          // ISSUE: reference to a compiler-generated field
                          if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Cooling.ERRMeasuredInclude)
                          {
                            xmlTextWriter.WriteStartElement("SAP:Cooling-System-EER");
                            // ISSUE: reference to a compiler-generated field
                            xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Cooling.ERR);
                            xmlTextWriter.WriteEndElement();
                          }
                          else
                          {
                            xmlTextWriter.WriteStartElement("SAP:Cooling-System-Class");
                            // ISSUE: reference to a compiler-generated field
                            xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Cooling.Energylabel);
                            xmlTextWriter.WriteEndElement();
                          }
                          xmlTextWriter.WriteStartElement("SAP:Cooling-System-Control");
                          // ISSUE: reference to a compiler-generated field
                          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Cooling.Compressorcontrol, "Systems with On/Off control", false) == 0)
                            xmlTextWriter.WriteValue(1);
                          else
                            xmlTextWriter.WriteValue(2);
                          xmlTextWriter.WriteEndElement();
                          xmlTextWriter.WriteEndElement();
                        }
                        xmlTextWriter.WriteStartElement("SAP:SAP-Energy-Source");
                        // ISSUE: reference to a compiler-generated field
                        if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Renewable.Photovoltaic.Inlcude)
                        {
                          xmlTextWriter.WriteStartElement("SAP:PV-Arrays");
                          // ISSUE: reference to a compiler-generated field
                          int num34 = checked (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Renewable.Photovoltaic.Photovoltaics.Length - 1);
                          int index13 = 0;
                          while (index13 <= num34)
                          {
                            xmlTextWriter.WriteStartElement("SAP:PV-Array");
                            xmlTextWriter.WriteStartElement("SAP:Peak-Power");
                            // ISSUE: reference to a compiler-generated field
                            xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Renewable.Photovoltaic.Photovoltaics[index13].PPower);
                            xmlTextWriter.WriteEndElement();
                            xmlTextWriter.WriteStartElement("SAP:Orientation");
                            // ISSUE: reference to a compiler-generated field
                            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Renewable.Photovoltaic.Photovoltaics[index13].PTilt, "Horizontal", false) == 0)
                            {
                              xmlTextWriter.WriteValue("ND");
                            }
                            else
                            {
                              // ISSUE: reference to a compiler-generated field
                              string pcOrientation = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Renewable.Photovoltaic.Photovoltaics[index13].PCOrientation;
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
                                    xmlTextWriter.WriteValue(2);
                                    goto default;
                                  }
                                  else
                                    goto default;
                                case 1409318971:
                                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(pcOrientation, "North West", false) == 0)
                                    goto label_2184;
                                  else
                                    goto default;
                                case 1682370166:
                                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(pcOrientation, "NE/NW", false) == 0)
                                    goto label_2184;
                                  else
                                    goto default;
                                case 1731397980:
                                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(pcOrientation, "East", false) == 0)
                                    goto label_2181;
                                  else
                                    goto default;
                                case 1734234020:
                                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(pcOrientation, "North", false) == 0)
                                  {
                                    xmlTextWriter.WriteValue(1);
                                    goto default;
                                  }
                                  else
                                    goto default;
                                case 1796576718:
                                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(pcOrientation, "West", false) == 0)
                                  {
                                    xmlTextWriter.WriteValue(7);
                                    goto default;
                                  }
                                  else
                                    goto default;
                                case 2417407149:
                                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(pcOrientation, "South West", false) == 0)
                                  {
                                    xmlTextWriter.WriteValue(6);
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
                                    xmlTextWriter.WriteValue(5);
                                    goto default;
                                  }
                                  else
                                    goto default;
                                case 4260797214:
                                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(pcOrientation, "E/W", false) == 0)
                                    goto label_2181;
                                  else
                                    goto default;
                                default:
label_2186:
                                  goto label_2187;
                              }
                              xmlTextWriter.WriteValue(4);
                              goto label_2186;
label_2181:
                              xmlTextWriter.WriteValue(3);
                              goto label_2186;
label_2184:
                              xmlTextWriter.WriteValue(8);
                              goto label_2186;
                            }
label_2187:
                            xmlTextWriter.WriteEndElement();
                            xmlTextWriter.WriteStartElement("SAP:Pitch");
                            // ISSUE: reference to a compiler-generated field
                            string ptilt = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Renewable.Photovoltaic.Photovoltaics[index13].PTilt;
                            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(ptilt, "Horizontal", false) != 0)
                            {
                              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(ptilt, "30°", false) != 0)
                              {
                                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(ptilt, "45°", false) != 0)
                                {
                                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(ptilt, "60°", false) != 0)
                                  {
                                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(ptilt, "Vertical", false) == 0)
                                      xmlTextWriter.WriteValue(5);
                                  }
                                  else
                                    xmlTextWriter.WriteValue(4);
                                }
                                else
                                  xmlTextWriter.WriteValue(3);
                              }
                              else
                                xmlTextWriter.WriteValue(2);
                            }
                            else
                              xmlTextWriter.WriteValue(1);
                            xmlTextWriter.WriteEndElement();
                            xmlTextWriter.WriteStartElement("SAP:Overshading");
                            // ISSUE: reference to a compiler-generated field
                            string povershading = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Renewable.Photovoltaic.Photovoltaics[index13].POvershading;
                            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(povershading, "Heavy", false) != 0)
                            {
                              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(povershading, "Significant", false) != 0)
                              {
                                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(povershading, "Modest", false) != 0)
                                {
                                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(povershading, "None or very little", false) == 0)
                                    xmlTextWriter.WriteValue(1);
                                }
                                else
                                  xmlTextWriter.WriteValue(2);
                              }
                              else
                                xmlTextWriter.WriteValue(3);
                            }
                            else
                              xmlTextWriter.WriteValue(4);
                            xmlTextWriter.WriteEndElement();
                            xmlTextWriter.WriteEndElement();
                            checked { ++index13; }
                          }
                          xmlTextWriter.WriteEndElement();
                        }
                        xmlTextWriter.WriteStartElement("SAP:Wind-Turbines-Count");
                        // ISSUE: reference to a compiler-generated field
                        xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Renewable.WindTurbine.WNumber);
                        xmlTextWriter.WriteEndElement();
                        xmlTextWriter.WriteStartElement("SAP:Wind-Turbine-Terrain-Type");
                        // ISSUE: reference to a compiler-generated field
                        string terrain = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Terrain;
                        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(terrain, "Dense urban", false) != 0)
                        {
                          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(terrain, "Low rise urban / suburban", false) != 0)
                          {
                            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(terrain, "Rural", false) != 0)
                            {
                              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(terrain, "not recorded", false) == 0)
                                xmlTextWriter.WriteValue(4);
                              else
                                xmlTextWriter.WriteValue(4);
                            }
                            else
                              xmlTextWriter.WriteValue(3);
                          }
                          else
                            xmlTextWriter.WriteValue(2);
                        }
                        else
                          xmlTextWriter.WriteValue(1);
                        xmlTextWriter.WriteEndElement();
                        // ISSUE: reference to a compiler-generated field
                        if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Renewable.WindTurbine.Inlcude)
                        {
                          xmlTextWriter.WriteStartElement("SAP:Wind-Turbine-Rotor-Diameter");
                          // ISSUE: reference to a compiler-generated field
                          xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Renewable.WindTurbine.WRDiameter);
                          xmlTextWriter.WriteEndElement();
                          xmlTextWriter.WriteStartElement("SAP:Wind-Turbine-Hub-Height");
                          // ISSUE: reference to a compiler-generated field
                          xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Renewable.WindTurbine.WHeight);
                          xmlTextWriter.WriteEndElement();
                        }
                        // ISSUE: reference to a compiler-generated field
                        if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Renewable.AAEGeneration.Inlcude)
                        {
                          xmlTextWriter.WriteStartElement("SAP:Hydro-Electric-Generation");
                          // ISSUE: reference to a compiler-generated field
                          xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Renewable.AAEGeneration.EGenerated);
                          xmlTextWriter.WriteEndElement();
                        }
                        // ISSUE: reference to a compiler-generated field
                        if ((double) SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].LowEnergyLight != 0.0)
                        {
                          xmlTextWriter.WriteStartElement("SAP:Fixed-Lighting-Outlets-Count");
                          // ISSUE: reference to a compiler-generated field
                          xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].LELOutlets);
                          xmlTextWriter.WriteEndElement();
                          xmlTextWriter.WriteStartElement("SAP:Low-Energy-Fixed-Lighting-Outlets-Count");
                          // ISSUE: reference to a compiler-generated field
                          xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].LELLights);
                          xmlTextWriter.WriteEndElement();
                        }
                        xmlTextWriter.WriteStartElement("SAP:Low-Energy-Fixed-Lighting-Outlets-Percentage");
                        // ISSUE: reference to a compiler-generated field
                        xmlTextWriter.WriteValue(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].LowEnergyLight);
                        xmlTextWriter.WriteEndElement();
                        xmlTextWriter.WriteStartElement("SAP:Electricity-Tariff");
                        // ISSUE: reference to a compiler-generated field
                        string electricityTariff = SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].MainHeating.ElectricityTariff;
                        // ISSUE: reference to a compiler-generated method
                        switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(electricityTariff))
                        {
                          case 1880739446:
                            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(electricityTariff, "24-hour tariff", false) == 0)
                              goto label_2234;
                            else
                              goto default;
                          case 1958420467:
                            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(electricityTariff, "24 hour", false) == 0)
                              goto label_2234;
                            else
                              goto default;
                          case 2140445595:
                            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(electricityTariff, "7-hour tariff", false) == 0)
                              break;
                            goto default;
                          case 2339516933:
                            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(electricityTariff, "10-hour tariff", false) == 0)
                              goto label_2233;
                            else
                              goto default;
                          case 3875898503:
                            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(electricityTariff, "off-peak 10 hour", false) == 0)
                              goto label_2233;
                            else
                              goto default;
                          case 4020509270:
                            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(electricityTariff, "standard tariff", false) == 0)
                            {
                              xmlTextWriter.WriteValue(1);
                              goto default;
                            }
                            else
                              goto default;
                          case 4219766515:
                            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(electricityTariff, "off-peak 7 hour", false) == 0)
                              break;
                            goto default;
                          default:
label_2235:
                            xmlTextWriter.WriteEndElement();
                            xmlTextWriter.WriteEndElement();
                            xmlTextWriter.WriteEndElement();
                            xmlTextWriter.WriteEndElement();
                            xmlTextWriter.WriteStartElement("SAP:PDF");
                            xmlTextWriter.WriteValue("UERGIG9mIGlucHV0IGRhdGEgZ29lcyBoZXJl");
                            xmlTextWriter.WriteEndElement();
                            xmlTextWriter.WriteStartElement("SAP:ExternalDefinitions-Revision-Number");
                            xmlTextWriter.WriteValue(this.ExternalDefinitions);
                            xmlTextWriter.WriteEndElement();
                            xmlTextWriter.WriteEndElement();
                            xmlTextWriter.Close();
                            FileInfo fileInfo = new FileInfo(SAP_Module.SAPXMLName);
                            StreamReader streamReader = File.OpenText(SAP_Module.SAPXMLName);
                            sapxml = streamReader.ReadToEnd();
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Address.Country, "Northern Ireland", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Address.Country, "Scotland", false) == 0)
                            {
                              string str7 = "";
                              sapxml = sapxml.Replace("SAP:", "SAP09:");
                              str7 = "";
                            }
                            streamReader.Close();
                            fileInfo.Delete();
                            goto label_2239;
                        }
                        xmlTextWriter.WriteValue(2);
                        goto label_2235;
label_2233:
                        xmlTextWriter.WriteValue(3);
                        goto label_2235;
label_2234:
                        xmlTextWriter.WriteValue(4);
                        goto label_2235;
                    }
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.Fans > 0 & SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.Vents == 0)
                    {
                      xmlTextWriter.WriteValue("1");
                      goto label_1022;
                    }
                    else
                    {
                      // ISSUE: reference to a compiler-generated field
                      // ISSUE: reference to a compiler-generated field
                      if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.Fans > 0 & SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.Vents > 0)
                      {
                        xmlTextWriter.WriteValue("10");
                        goto label_1022;
                      }
                      else
                      {
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.Vents > 0 & SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.Fans == 0)
                        {
                          xmlTextWriter.WriteValue("2");
                          goto label_1022;
                        }
                        else
                        {
                          // ISSUE: reference to a compiler-generated field
                          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.MechVent, "natural with passive vents", false) == 0)
                          {
                            xmlTextWriter.WriteValue("2");
                            goto label_1022;
                          }
                          else
                          {
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            if (SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.Vents > 0 & SAP_Module.Proj.Dwellings[closure850_2.\u0024VB\u0024Local_House].Ventilation.Fans > 0)
                            {
                              xmlTextWriter.WriteValue("9");
                              goto label_1022;
                            }
                            else
                            {
                              xmlTextWriter.WriteValue("1");
                              goto label_1022;
                            }
                          }
                        }
                      }
                    }
                }
                xmlTextWriter.WriteValue("3");
                goto label_558;
label_555:
                xmlTextWriter.WriteValue("4");
                goto label_558;
            }
            this.XML_WaterBanding2 = Conversions.ToString(0);
            goto label_305;
        }
        xmlTextWriter.WriteValue(9);
        goto label_157;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        Console.Write(exception.Message + exception.StackTrace);
        ProjectData.ClearProjectError();
      }
label_2239:
      return sapxml;
    }

    public string[] GetValue() => new string[23]
    {
      Conversions.ToString(0.5),
      Conversions.ToString(0.3),
      Conversions.ToString(0.04),
      Conversions.ToString(0.05),
      Conversions.ToString(0.16),
      Conversions.ToString(0.07),
      Conversions.ToString(0.14),
      Conversions.ToString(0.0),
      Conversions.ToString(0.04),
      Conversions.ToString(0.06),
      Conversions.ToString(0.04),
      Conversions.ToString(0.24),
      Conversions.ToString(0.04),
      Conversions.ToString(0.04),
      Conversions.ToString(0.28),
      Conversions.ToString(0.09),
      Conversions.ToString(-0.09),
      Conversions.ToString(0.06),
      Conversions.ToString(0.08),
      Conversions.ToString(0.0),
      Conversions.ToString(0.0),
      Conversions.ToString(0.12),
      Conversions.ToString(0.02)
    };

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
          {
            num = 1;
            goto default;
          }
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
label_60:
          return num;
      }
      num = 10;
      goto label_60;
    }

    public void DefineOpenings(int House)
    {
      this.OpeningTypes = new CreatePDF.Opening[0];
      int num1 = checked (SAP_Module.Proj.Dwellings[House].NoofDoors - 1);
      int index1 = 0;
      while (index1 <= num1)
      {
        bool flag = false;
        if (index1 == 0)
        {
          // ISSUE: variable of a reference type
          CreatePDF.Opening[]& local;
          // ISSUE: explicit reference operation
          CreatePDF.Opening[] openingArray = (CreatePDF.Opening[]) Utils.CopyArray((Array) ^(local = ref this.OpeningTypes), (Array) new CreatePDF.Opening[checked (index1 + 1)]);
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
            CreatePDF.Opening[]& local;
            // ISSUE: explicit reference operation
            CreatePDF.Opening[] openingArray = (CreatePDF.Opening[]) Utils.CopyArray((Array) ^(local = ref this.OpeningTypes), (Array) new CreatePDF.Opening[checked (this.OpeningTypes.Length + 1)]);
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
      int num3 = 1;
      int length1 = this.OpeningTypes.Length;
      int num4 = checked (SAP_Module.Proj.Dwellings[House].NoofWindows - 1);
      int index3 = 0;
      while (index3 <= num4)
      {
        bool flag = false;
        if (index3 == 0)
        {
          // ISSUE: variable of a reference type
          CreatePDF.Opening[]& local;
          // ISSUE: explicit reference operation
          CreatePDF.Opening[] openingArray = (CreatePDF.Opening[]) Utils.CopyArray((Array) ^(local = ref this.OpeningTypes), (Array) new CreatePDF.Opening[checked (this.OpeningTypes.Length + 1)]);
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
            CreatePDF.Opening[]& local;
            // ISSUE: explicit reference operation
            CreatePDF.Opening[] openingArray = (CreatePDF.Opening[]) Utils.CopyArray((Array) ^(local = ref this.OpeningTypes), (Array) new CreatePDF.Opening[checked (this.OpeningTypes.Length + 1)]);
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
      int num7 = 1;
      int length2 = this.OpeningTypes.Length;
      int num8 = checked (SAP_Module.Proj.Dwellings[House].NoofRoofLights - 1);
      int index5 = 0;
      while (index5 <= num8)
      {
        bool flag = false;
        if (index5 == 0)
        {
          // ISSUE: variable of a reference type
          CreatePDF.Opening[]& local;
          // ISSUE: explicit reference operation
          CreatePDF.Opening[] openingArray = (CreatePDF.Opening[]) Utils.CopyArray((Array) ^(local = ref this.OpeningTypes), (Array) new CreatePDF.Opening[checked (this.OpeningTypes.Length + 1)]);
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
            CreatePDF.Opening[]& local;
            // ISSUE: explicit reference operation
            CreatePDF.Opening[] openingArray = (CreatePDF.Opening[]) Utils.CopyArray((Array) ^(local = ref this.OpeningTypes), (Array) new CreatePDF.Opening[checked (this.OpeningTypes.Length + 1)]);
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

    public string RequestRRNByUPRN(string UPRN, string InspectionDate)
    {
      string[] strArray1 = new string[20];
      string[] strArray2 = new string[20];
      string[] strArray3 = new string[6];
      if (Microsoft.VisualBasic.Strings.Len(InspectionDate) != 6 || !Versioned.IsNumeric((object) InspectionDate))
        return "Incorrect Date Format. Correct Format is YYMMDD";
      int index1 = 0;
      do
      {
        strArray3[index1] = Microsoft.VisualBasic.Strings.Right(Microsoft.VisualBasic.Strings.Left(InspectionDate, checked (index1 + 1)), 1);
        if (Conversion.Val(strArray3[index1]) % 2.0 != 0.0)
          strArray3[index1] = Conversions.ToString(10.0 - Conversion.Val(strArray3[index1]));
        checked { ++index1; }
      }
      while (index1 <= 5);
      VBMath.Randomize();
      string str1 = Conversions.ToString(Math.Round(9.0 * (double) VBMath.Rnd() + 1.0));
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str1, "10", false) == 0)
        str1 = "9";
      VBMath.Randomize();
      string str2 = Conversions.ToString(Math.Round(9.0 * (double) VBMath.Rnd() + 1.0));
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "10", false) == 0)
        str2 = "9";
      int index2 = 0;
      do
      {
        strArray1[index2] = Microsoft.VisualBasic.Strings.Right(Microsoft.VisualBasic.Strings.Left(UPRN, checked (index2 + 1)), 1);
        checked { ++index2; }
      }
      while (index2 <= 9);
      int index3 = 10;
      do
      {
        strArray1[index3] = strArray3[checked (index3 - 10)];
        checked { ++index3; }
      }
      while (index3 <= 15);
      strArray1[16] = Microsoft.VisualBasic.Strings.Right(Microsoft.VisualBasic.Strings.Left(str1, 1), 1);
      strArray1[17] = Microsoft.VisualBasic.Strings.Right(Microsoft.VisualBasic.Strings.Left(str2, 2), 1);
      strArray1[18] = Conversions.ToString(3);
      int index4 = 0;
      int num1;
      do
      {
        num1 = checked ((int) Math.Round(unchecked ((double) num1 + Conversion.Val(strArray1[index4]))));
        checked { ++index4; }
      }
      while (index4 <= 18);
      int num2 = num1 % 7;
      strArray2[19] = Conversions.ToString(num2);
      switch (num2)
      {
        case 0:
        case 4:
          strArray2[0] = strArray1[14];
          strArray2[1] = strArray1[16];
          strArray2[2] = strArray1[15];
          strArray2[3] = strArray1[9];
          strArray2[4] = strArray1[0];
          strArray2[5] = strArray1[12];
          strArray2[6] = strArray1[3];
          strArray2[7] = strArray1[4];
          strArray2[8] = strArray1[8];
          strArray2[9] = strArray1[18];
          strArray2[10] = strArray1[2];
          strArray2[11] = strArray1[13];
          strArray2[12] = strArray1[7];
          strArray2[13] = strArray1[17];
          strArray2[14] = strArray1[6];
          strArray2[15] = strArray1[11];
          strArray2[16] = strArray1[5];
          strArray2[17] = strArray1[10];
          strArray2[18] = strArray1[1];
          break;
        case 1:
        case 5:
          strArray2[0] = strArray1[12];
          strArray2[1] = strArray1[0];
          strArray2[2] = strArray1[7];
          strArray2[3] = strArray1[1];
          strArray2[4] = strArray1[18];
          strArray2[5] = strArray1[9];
          strArray2[6] = strArray1[6];
          strArray2[7] = strArray1[15];
          strArray2[8] = strArray1[8];
          strArray2[9] = strArray1[3];
          strArray2[10] = strArray1[13];
          strArray2[11] = strArray1[2];
          strArray2[12] = strArray1[10];
          strArray2[13] = strArray1[5];
          strArray2[14] = strArray1[14];
          strArray2[15] = strArray1[11];
          strArray2[16] = strArray1[17];
          strArray2[17] = strArray1[4];
          strArray2[18] = strArray1[16];
          break;
        case 2:
        case 6:
          strArray2[0] = strArray1[9];
          strArray2[1] = strArray1[17];
          strArray2[2] = strArray1[0];
          strArray2[3] = strArray1[11];
          strArray2[4] = strArray1[8];
          strArray2[5] = strArray1[5];
          strArray2[6] = strArray1[18];
          strArray2[7] = strArray1[13];
          strArray2[8] = strArray1[7];
          strArray2[9] = strArray1[3];
          strArray2[10] = strArray1[2];
          strArray2[11] = strArray1[12];
          strArray2[12] = strArray1[1];
          strArray2[13] = strArray1[6];
          strArray2[14] = strArray1[16];
          strArray2[15] = strArray1[15];
          strArray2[16] = strArray1[4];
          strArray2[17] = strArray1[10];
          strArray2[18] = strArray1[14];
          break;
        case 3:
          strArray2[0] = strArray1[9];
          strArray2[1] = strArray1[4];
          strArray2[2] = strArray1[12];
          strArray2[3] = strArray1[1];
          strArray2[4] = strArray1[16];
          strArray2[5] = strArray1[5];
          strArray2[6] = strArray1[15];
          strArray2[7] = strArray1[7];
          strArray2[8] = strArray1[2];
          strArray2[9] = strArray1[6];
          strArray2[10] = strArray1[18];
          strArray2[11] = strArray1[10];
          strArray2[12] = strArray1[17];
          strArray2[13] = strArray1[3];
          strArray2[14] = strArray1[14];
          strArray2[15] = strArray1[8];
          strArray2[16] = strArray1[0];
          strArray2[17] = strArray1[13];
          strArray2[18] = strArray1[11];
          break;
      }
      return strArray2[0] + strArray2[1] + strArray2[2] + strArray2[3] + "-" + strArray2[4] + strArray2[5] + strArray2[6] + strArray2[7] + "-" + strArray2[8] + strArray2[9] + strArray2[10] + strArray2[11] + "-" + strArray2[12] + strArray2[13] + strArray2[14] + strArray2[15] + "-" + strArray2[16] + strArray2[17] + strArray2[18] + strArray2[19];
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

    public int RatingConverter(string ratingValue) => !(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Microsoft.VisualBasic.Strings.UCase(ratingValue), Microsoft.VisualBasic.Strings.UCase("Very Poor"), false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Microsoft.VisualBasic.Strings.UCase(ratingValue), Microsoft.VisualBasic.Strings.UCase("Gwael iawn"), false) == 0) ? (!(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Microsoft.VisualBasic.Strings.UCase(ratingValue), Microsoft.VisualBasic.Strings.UCase("Poor"), false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Microsoft.VisualBasic.Strings.UCase(ratingValue), Microsoft.VisualBasic.Strings.UCase("Gwael"), false) == 0) ? (!(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Microsoft.VisualBasic.Strings.UCase(ratingValue), Microsoft.VisualBasic.Strings.UCase("Average"), false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Microsoft.VisualBasic.Strings.UCase(ratingValue), Microsoft.VisualBasic.Strings.UCase("Cymedrol"), false) == 0) ? (!(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Microsoft.VisualBasic.Strings.UCase(ratingValue), Microsoft.VisualBasic.Strings.UCase("Good"), false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Microsoft.VisualBasic.Strings.UCase(ratingValue), Microsoft.VisualBasic.Strings.UCase("Da"), false) == 0) ? (!(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Microsoft.VisualBasic.Strings.UCase(ratingValue), Microsoft.VisualBasic.Strings.UCase("Very good"), false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Microsoft.VisualBasic.Strings.UCase(ratingValue), Microsoft.VisualBasic.Strings.UCase("Da iawn"), false) == 0) ? (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Microsoft.VisualBasic.Strings.UCase(ratingValue), Microsoft.VisualBasic.Strings.UCase("-"), false) != 0 ? 0 : 0) : 5) : 4) : 3) : 2) : 1;

    public string CheckWalesRating(string Value, int country)
    {
      string str;
      try
      {
        if (country == 2)
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
        int num = (int) Interaction.MsgBox((object) "There is a problem during Rating Check", MsgBoxStyle.Critical);
        ProjectData.ClearProjectError();
      }
      return str;
    }

    public Stream GenerateNIPDF(int Country, int House)
    {
      Stream nipdf;
      return nipdf;
    }

    public Stream GeneratePredictedPDF(int Country, int House)
    {
      try
      {
        Functions.CalculateNow();
        this.HeadingNum = 1;
        PDFFunctions.document = new PdfDocument();
        PDFFunctions.pages[this.k] = PDFFunctions.document.AddPage();
        PDFFunctions.gfx[this.k] = XGraphics.FromPdfPage(PDFFunctions.pages[this.k]);
        PDFFunctions.xBrush1 = XBrush.op_Implicit((Brush) new SolidBrush(Color.FromArgb(179, 3, 55)));
        PDFFunctions.Points[0].X = 20f;
        PDFFunctions.Points[0].Y = 20f;
        ref PointF local1 = ref PDFFunctions.Points[1];
        XUnit width1 = PDFFunctions.pages[this.k].Width;
        double num1 = ((XUnit) ref width1).Point - 20.0;
        local1.X = (float) num1;
        PDFFunctions.Points[1].Y = 20f;
        ref PointF local2 = ref PDFFunctions.Points[2];
        XUnit width2 = PDFFunctions.pages[this.k].Width;
        double num2 = ((XUnit) ref width2).Point - 20.0;
        local2.X = (float) num2;
        PDFFunctions.Points[2].Y = 60f;
        PDFFunctions.Points[3].X = 20f;
        PDFFunctions.Points[3].Y = 60f;
        this.R = 67;
        this.Address[0] = SAP_Module.Proj.Dwellings[House].Address.Line1;
        this.Address[1] = SAP_Module.Proj.Dwellings[House].Address.Line2;
        this.Address[2] = SAP_Module.Proj.Dwellings[House].Address.Line3;
        this.Address[3] = SAP_Module.Proj.Dwellings[House].Address.City;
        this.Address[4] = SAP_Module.Proj.Dwellings[House].Address.PostCost;
        XPen xpen = new XPen(XColor.FromArgb(179, 3, 55));
        PDFFunctions.gfx[this.k].DrawPolygon(xpen, PDFFunctions.xBrush1, PDFFunctions.Points, PDFFunctions.Fill);
        XGraphics xgraphics1 = PDFFunctions.gfx[this.k];
        XFont arialfont = PDFFunctions.Arialfont;
        XSolidBrush white1 = XBrushes.White;
        XUnit xunit1 = PDFFunctions.pages[this.k].Width;
        double point1 = ((XUnit) ref xunit1).Point;
        xunit1 = PDFFunctions.pages[this.k].Height;
        double num3 = ((XUnit) ref xunit1).Point / 2.0;
        XRect xrect1 = new XRect(25.0, 30.0, point1, num3);
        XStringFormat topLeft1 = XStringFormat.TopLeft;
        xgraphics1.DrawString("Predicted Energy Assessment", arialfont, (XBrush) white1, xrect1, topLeft1);
        int index = 0;
        XUnit xunit2;
        do
        {
          if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.Address[index], "", false) > 0U)
          {
            XGraphics xgraphics2 = PDFFunctions.gfx[this.k];
            string str = this.Address[index];
            XFont arialFont11 = PDFFunctions.ArialFont11;
            XSolidBrush black = XBrushes.Black;
            double r = (double) this.R;
            xunit2 = PDFFunctions.pages[this.k].Width;
            double num4 = ((XUnit) ref xunit2).Point / 4.0;
            xunit2 = PDFFunctions.pages[this.k].Height;
            double num5 = ((XUnit) ref xunit2).Point / 4.0;
            XRect xrect2 = new XRect(20.0, r, num4, num5);
            XStringFormat topLeft2 = XStringFormat.TopLeft;
            xgraphics2.DrawString(str, arialFont11, (XBrush) black, xrect2, topLeft2);
            // ISSUE: variable of a reference type
            int& local3;
            // ISSUE: explicit reference operation
            int num6 = checked (^(local3 = ref this.R) + 10);
            local3 = num6;
          }
          checked { ++index; }
        }
        while (index <= 4);
        this.R = 67;
        XGraphics xgraphics3 = PDFFunctions.gfx[this.k];
        XFont arialFont11_1 = PDFFunctions.ArialFont11;
        XSolidBrush black1 = XBrushes.Black;
        double r1 = (double) this.R;
        xunit2 = PDFFunctions.pages[this.k].Width;
        double num7 = ((XUnit) ref xunit2).Point / 4.0;
        xunit2 = PDFFunctions.pages[this.k].Height;
        double num8 = ((XUnit) ref xunit2).Point / 4.0;
        XRect xrect3 = new XRect(250.0, r1, num7, num8);
        XStringFormat topLeft3 = XStringFormat.TopLeft;
        xgraphics3.DrawString("Dwelling type:", arialFont11_1, (XBrush) black1, xrect3, topLeft3);
        string propertyType = SAP_Module.Proj.Dwellings[House].PropertyType;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(propertyType, "Maisonette", false) == 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(propertyType, "Flat", false) == 0)
        {
          XGraphics xgraphics4 = PDFFunctions.gfx[this.k];
          string str = SAP_Module.Proj.Dwellings[House].BuildForm + " " + SAP_Module.Proj.Dwellings[House].FlatType + " " + SAP_Module.Proj.Dwellings[House].PropertyType;
          XFont arialFont11_2 = PDFFunctions.ArialFont11;
          XSolidBrush black2 = XBrushes.Black;
          double r2 = (double) this.R;
          xunit2 = PDFFunctions.pages[this.k].Width;
          double num9 = ((XUnit) ref xunit2).Point / 4.0;
          xunit2 = PDFFunctions.pages[this.k].Height;
          double num10 = ((XUnit) ref xunit2).Point / 4.0;
          XRect xrect4 = new XRect(380.0, r2, num9, num10);
          XStringFormat topLeft4 = XStringFormat.TopLeft;
          xgraphics4.DrawString(str, arialFont11_2, (XBrush) black2, xrect4, topLeft4);
        }
        else
        {
          XGraphics xgraphics5 = PDFFunctions.gfx[this.k];
          string str = SAP_Module.Proj.Dwellings[House].BuildForm + " " + SAP_Module.Proj.Dwellings[House].PropertyType;
          XFont arialFont11_3 = PDFFunctions.ArialFont11;
          XSolidBrush black3 = XBrushes.Black;
          double r3 = (double) this.R;
          xunit2 = PDFFunctions.pages[this.k].Width;
          double num11 = ((XUnit) ref xunit2).Point / 4.0;
          xunit2 = PDFFunctions.pages[this.k].Height;
          double num12 = ((XUnit) ref xunit2).Point / 4.0;
          XRect xrect5 = new XRect(380.0, r3, num11, num12);
          XStringFormat topLeft5 = XStringFormat.TopLeft;
          xgraphics5.DrawString(str, arialFont11_3, (XBrush) black3, xrect5, topLeft5);
        }
        checked { this.R += 10; }
        XGraphics xgraphics6 = PDFFunctions.gfx[this.k];
        XFont arialFont11_4 = PDFFunctions.ArialFont11;
        XSolidBrush black4 = XBrushes.Black;
        double r4 = (double) this.R;
        xunit2 = PDFFunctions.pages[this.k].Width;
        double num13 = ((XUnit) ref xunit2).Point / 4.0;
        xunit2 = PDFFunctions.pages[this.k].Height;
        double num14 = ((XUnit) ref xunit2).Point / 4.0;
        XRect xrect6 = new XRect(250.0, r4, num13, num14);
        XStringFormat topLeft6 = XStringFormat.TopLeft;
        xgraphics6.DrawString("Date of assessment:", arialFont11_4, (XBrush) black4, xrect6, topLeft6);
        XGraphics xgraphics7 = PDFFunctions.gfx[this.k];
        string str1 = Microsoft.VisualBasic.Strings.FormatDateTime(SAP_Module.Proj.Dwellings[House].DateAssessment, DateFormat.LongDate);
        XFont arialFont11_5 = PDFFunctions.ArialFont11;
        XSolidBrush black5 = XBrushes.Black;
        double r5 = (double) this.R;
        xunit2 = PDFFunctions.pages[this.k].Width;
        double num15 = ((XUnit) ref xunit2).Point / 4.0;
        xunit2 = PDFFunctions.pages[this.k].Height;
        double num16 = ((XUnit) ref xunit2).Point / 4.0;
        XRect xrect7 = new XRect(380.0, r5, num15, num16);
        XStringFormat topLeft7 = XStringFormat.TopLeft;
        xgraphics7.DrawString(str1, arialFont11_5, (XBrush) black5, xrect7, topLeft7);
        checked { this.R += 10; }
        XGraphics xgraphics8 = PDFFunctions.gfx[this.k];
        XFont arialFont11_6 = PDFFunctions.ArialFont11;
        XSolidBrush black6 = XBrushes.Black;
        double r6 = (double) this.R;
        xunit2 = PDFFunctions.pages[this.k].Width;
        double num17 = ((XUnit) ref xunit2).Point / 4.0;
        xunit2 = PDFFunctions.pages[this.k].Height;
        double num18 = ((XUnit) ref xunit2).Point / 4.0;
        XRect xrect8 = new XRect(250.0, r6, num17, num18);
        XStringFormat topLeft8 = XStringFormat.TopLeft;
        xgraphics8.DrawString("Produced by:", arialFont11_6, (XBrush) black6, xrect8, topLeft8);
        if (!Validation.UserLogged)
        {
          XGraphics xgraphics9 = PDFFunctions.gfx[this.k];
          XFont arialFont11_7 = PDFFunctions.ArialFont11;
          XSolidBrush black7 = XBrushes.Black;
          double r7 = (double) this.R;
          xunit2 = PDFFunctions.pages[this.k].Width;
          double num19 = ((XUnit) ref xunit2).Point / 4.0;
          xunit2 = PDFFunctions.pages[this.k].Height;
          double num20 = ((XUnit) ref xunit2).Point / 4.0;
          XRect xrect9 = new XRect(380.0, r7, num19, num20);
          XStringFormat topLeft9 = XStringFormat.TopLeft;
          xgraphics9.DrawString("Stroma Certification", arialFont11_7, (XBrush) black7, xrect9, topLeft9);
        }
        else
        {
          XGraphics xgraphics10 = PDFFunctions.gfx[this.k];
          string str2 = Validation.AssessorFN + " " + Validation.AssessorLN;
          XFont arialFont11_8 = PDFFunctions.ArialFont11;
          XSolidBrush black8 = XBrushes.Black;
          double r8 = (double) this.R;
          xunit2 = PDFFunctions.pages[this.k].Width;
          double num21 = ((XUnit) ref xunit2).Point / 4.0;
          xunit2 = PDFFunctions.pages[this.k].Height;
          double num22 = ((XUnit) ref xunit2).Point / 4.0;
          XRect xrect10 = new XRect(380.0, r8, num21, num22);
          XStringFormat topLeft10 = XStringFormat.TopLeft;
          xgraphics10.DrawString(str2, arialFont11_8, (XBrush) black8, xrect10, topLeft10);
        }
        checked { this.R += 10; }
        XGraphics xgraphics11 = PDFFunctions.gfx[this.k];
        XFont arialFont11_9 = PDFFunctions.ArialFont11;
        XSolidBrush black9 = XBrushes.Black;
        double r9 = (double) this.R;
        xunit2 = PDFFunctions.pages[this.k].Width;
        double num23 = ((XUnit) ref xunit2).Point / 4.0;
        xunit2 = PDFFunctions.pages[this.k].Height;
        double num24 = ((XUnit) ref xunit2).Point / 4.0;
        XRect xrect11 = new XRect(250.0, r9, num23, num24);
        XStringFormat topLeft11 = XStringFormat.TopLeft;
        xgraphics11.DrawString("Total floor area:", arialFont11_9, (XBrush) black9, xrect11, topLeft11);
        XGraphics xgraphics12 = PDFFunctions.gfx[this.k];
        string str3 = Conversions.ToString(Math.Round(SAP_Module.Calculation2012.Calculation.Dimensions.Box4, 2)) + " m\u00B2";
        XFont arialFont11_10 = PDFFunctions.ArialFont11;
        XSolidBrush black10 = XBrushes.Black;
        double r10 = (double) this.R;
        xunit2 = PDFFunctions.pages[this.k].Width;
        double num25 = ((XUnit) ref xunit2).Point / 4.0;
        xunit2 = PDFFunctions.pages[this.k].Height;
        double num26 = ((XUnit) ref xunit2).Point / 4.0;
        XRect xrect12 = new XRect(380.0, r10, num25, num26);
        XStringFormat topLeft12 = XStringFormat.TopLeft;
        xgraphics12.DrawString(str3, arialFont11_10, (XBrush) black10, xrect12, topLeft12);
        checked { this.R += 20; }
        XGraphics xgraphics13 = PDFFunctions.gfx[this.k];
        XFont arialFont11_11 = PDFFunctions.ArialFont11;
        XSolidBrush black11 = XBrushes.Black;
        double r11 = (double) this.R;
        xunit2 = PDFFunctions.pages[this.k].Width;
        double num27 = ((XUnit) ref xunit2).Point / 4.0;
        xunit2 = PDFFunctions.pages[this.k].Height;
        double num28 = ((XUnit) ref xunit2).Point / 4.0;
        XRect xrect13 = new XRect(20.0, r11, num27, num28);
        XStringFormat topLeft13 = XStringFormat.TopLeft;
        xgraphics13.DrawString("This is a Predicted Energy Assessment for a property which is not yet complete. It includes a predicted energy", arialFont11_11, (XBrush) black11, xrect13, topLeft13);
        checked { this.R += 12; }
        XGraphics xgraphics14 = PDFFunctions.gfx[this.k];
        XFont arialFont11_12 = PDFFunctions.ArialFont11;
        XSolidBrush black12 = XBrushes.Black;
        double r12 = (double) this.R;
        xunit2 = PDFFunctions.pages[this.k].Width;
        double num29 = ((XUnit) ref xunit2).Point / 4.0;
        xunit2 = PDFFunctions.pages[this.k].Height;
        double num30 = ((XUnit) ref xunit2).Point / 4.0;
        XRect xrect14 = new XRect(20.0, r12, num29, num30);
        XStringFormat topLeft14 = XStringFormat.TopLeft;
        xgraphics14.DrawString("rating which might not represent the final energy rating of the property on completion. Once the property is", arialFont11_12, (XBrush) black12, xrect14, topLeft14);
        checked { this.R += 12; }
        XGraphics xgraphics15 = PDFFunctions.gfx[this.k];
        XFont arialFont11_13 = PDFFunctions.ArialFont11;
        XSolidBrush black13 = XBrushes.Black;
        double r13 = (double) this.R;
        xunit2 = PDFFunctions.pages[this.k].Width;
        double num31 = ((XUnit) ref xunit2).Point / 4.0;
        xunit2 = PDFFunctions.pages[this.k].Height;
        double num32 = ((XUnit) ref xunit2).Point / 4.0;
        XRect xrect15 = new XRect(20.0, r13, num31, num32);
        XStringFormat topLeft15 = XStringFormat.TopLeft;
        xgraphics15.DrawString("completed, an Energy Performance Certificate is required providing information about the energy performance", arialFont11_13, (XBrush) black13, xrect15, topLeft15);
        checked { this.R += 12; }
        XGraphics xgraphics16 = PDFFunctions.gfx[this.k];
        XFont arialFont11_14 = PDFFunctions.ArialFont11;
        XSolidBrush black14 = XBrushes.Black;
        double r14 = (double) this.R;
        xunit2 = PDFFunctions.pages[this.k].Width;
        double num33 = ((XUnit) ref xunit2).Point / 4.0;
        xunit2 = PDFFunctions.pages[this.k].Height;
        double num34 = ((XUnit) ref xunit2).Point / 4.0;
        XRect xrect16 = new XRect(20.0, r14, num33, num34);
        XStringFormat topLeft16 = XStringFormat.TopLeft;
        xgraphics16.DrawString("of the completed property.", arialFont11_14, (XBrush) black14, xrect16, topLeft16);
        checked { this.R += 17; }
        XGraphics xgraphics17 = PDFFunctions.gfx[this.k];
        XFont arialFont11_15 = PDFFunctions.ArialFont11;
        XSolidBrush black15 = XBrushes.Black;
        double r15 = (double) this.R;
        xunit2 = PDFFunctions.pages[this.k].Width;
        double num35 = ((XUnit) ref xunit2).Point / 4.0;
        xunit2 = PDFFunctions.pages[this.k].Height;
        double num36 = ((XUnit) ref xunit2).Point / 4.0;
        XRect xrect17 = new XRect(20.0, r15, num35, num36);
        XStringFormat topLeft17 = XStringFormat.TopLeft;
        xgraphics17.DrawString("Energy performance has been assessed using the SAP 2012 methodology and is rated in terms of the energy", arialFont11_15, (XBrush) black15, xrect17, topLeft17);
        checked { this.R += 12; }
        XGraphics xgraphics18 = PDFFunctions.gfx[this.k];
        XFont arialFont11_16 = PDFFunctions.ArialFont11;
        XSolidBrush black16 = XBrushes.Black;
        double r16 = (double) this.R;
        xunit2 = PDFFunctions.pages[this.k].Width;
        double num37 = ((XUnit) ref xunit2).Point / 4.0;
        xunit2 = PDFFunctions.pages[this.k].Height;
        double num38 = ((XUnit) ref xunit2).Point / 4.0;
        XRect xrect18 = new XRect(20.0, r16, num37, num38);
        XStringFormat topLeft18 = XStringFormat.TopLeft;
        xgraphics18.DrawString("use per square metre of floor area, energy efficiency based on fuel costs and environmental impact based on", arialFont11_16, (XBrush) black16, xrect18, topLeft18);
        checked { this.R += 12; }
        XGraphics xgraphics19 = PDFFunctions.gfx[this.k];
        XFont arialFont11_17 = PDFFunctions.ArialFont11;
        XSolidBrush black17 = XBrushes.Black;
        double r17 = (double) this.R;
        xunit2 = PDFFunctions.pages[this.k].Width;
        double num39 = ((XUnit) ref xunit2).Point / 4.0;
        xunit2 = PDFFunctions.pages[this.k].Height;
        double num40 = ((XUnit) ref xunit2).Point / 4.0;
        XRect xrect19 = new XRect(20.0, r17, num39, num40);
        XStringFormat topLeft19 = XStringFormat.TopLeft;
        xgraphics19.DrawString("carbon dioxide (CO2) emissions.", arialFont11_17, (XBrush) black17, xrect19, topLeft19);
        checked { this.R += 20; }
        checked { this.R += 14; }
        PDFFunctions.xBrush1 = XBrush.op_Implicit((Brush) new SolidBrush(Color.FromArgb(0, 115, 187)));
        PDFFunctions.Points[0].X = 20f;
        PDFFunctions.Points[0].Y = (float) this.R;
        ref PointF local4 = ref PDFFunctions.Points[1];
        xunit2 = PDFFunctions.pages[this.k].Width;
        double num41 = ((XUnit) ref xunit2).Point - 300.0;
        local4.X = (float) num41;
        PDFFunctions.Points[1].Y = (float) this.R;
        ref PointF local5 = ref PDFFunctions.Points[2];
        xunit2 = PDFFunctions.pages[this.k].Width;
        double num42 = ((XUnit) ref xunit2).Point - 300.0;
        local5.X = (float) num42;
        PDFFunctions.Points[2].Y = (float) checked (this.R + 20);
        PDFFunctions.Points[3].X = 20f;
        PDFFunctions.Points[3].Y = (float) checked (this.R + 20);
        PDFFunctions.gfx[this.k].DrawPolygon(PDFFunctions.polygraphics, PDFFunctions.xBrush1, PDFFunctions.Points, PDFFunctions.Fill);
        this.Col = this.R;
        XGraphics xgraphics20 = PDFFunctions.gfx[this.k];
        XFont arialFont12Bold1 = PDFFunctions.ArialFont12Bold;
        XSolidBrush white2 = XBrushes.White;
        double num43 = (double) checked (this.R + 2);
        xunit2 = PDFFunctions.pages[this.k].Width;
        double num44 = ((XUnit) ref xunit2).Point - 40.0;
        xunit2 = PDFFunctions.pages[this.k].Height;
        double num45 = ((XUnit) ref xunit2).Point / 2.0;
        XRect xrect20 = new XRect(25.0, num43, num44, num45);
        XStringFormat topLeft20 = XStringFormat.TopLeft;
        xgraphics20.DrawString("Energy Efficiency Rating", arialFont12Bold1, (XBrush) white2, xrect20, topLeft20);
        PDFFunctions.xBrush1 = XBrush.op_Implicit((Brush) new SolidBrush(Color.FromArgb(0, 115, 187)));
        PDFFunctions.Points[0].X = 300f;
        PDFFunctions.Points[0].Y = (float) this.R;
        ref PointF local6 = ref PDFFunctions.Points[1];
        xunit2 = PDFFunctions.pages[this.k].Width;
        double num46 = ((XUnit) ref xunit2).Point - 20.0;
        local6.X = (float) num46;
        PDFFunctions.Points[1].Y = (float) this.R;
        ref PointF local7 = ref PDFFunctions.Points[2];
        xunit2 = PDFFunctions.pages[this.k].Width;
        double num47 = ((XUnit) ref xunit2).Point - 20.0;
        local7.X = (float) num47;
        PDFFunctions.Points[2].Y = (float) checked (this.R + 20);
        PDFFunctions.Points[3].X = 300f;
        PDFFunctions.Points[3].Y = (float) checked (this.R + 20);
        PDFFunctions.gfx[this.k].DrawPolygon(PDFFunctions.polygraphics, PDFFunctions.xBrush1, PDFFunctions.Points, PDFFunctions.Fill);
        XGraphics xgraphics21 = PDFFunctions.gfx[this.k];
        XFont arialFont12Bold2 = PDFFunctions.ArialFont12Bold;
        XSolidBrush white3 = XBrushes.White;
        double num48 = (double) checked (this.R + 2);
        xunit2 = PDFFunctions.pages[this.k].Width;
        double num49 = ((XUnit) ref xunit2).Point - 40.0;
        xunit2 = PDFFunctions.pages[this.k].Height;
        double num50 = ((XUnit) ref xunit2).Point / 2.0;
        XRect xrect21 = new XRect(305.0, num48, num49, num50);
        XStringFormat topLeft21 = XStringFormat.TopLeft;
        xgraphics21.DrawString("Environmental Impact (CO ) Rating", arialFont12Bold2, (XBrush) white3, xrect21, topLeft21);
        XGraphics xgraphics22 = PDFFunctions.gfx[this.k];
        string str4 = Conversions.ToString(2);
        XFont arialFont8Bold = PDFFunctions.ArialFont8Bold;
        XSolidBrush white4 = XBrushes.White;
        double num51 = (double) checked (this.R + 8);
        xunit2 = PDFFunctions.pages[this.k].Width;
        double num52 = ((XUnit) ref xunit2).Point - 40.0;
        xunit2 = PDFFunctions.pages[this.k].Height;
        double num53 = ((XUnit) ref xunit2).Point / 2.0;
        XRect xrect22 = new XRect(455.0, num51, num52, num53);
        XStringFormat topLeft22 = XStringFormat.TopLeft;
        xgraphics22.DrawString(str4, arialFont8Bold, (XBrush) white4, xrect22, topLeft22);
        checked { this.R += 5; }
        PDFFunctions.myImage = Image.FromFile(Application.StartupPath + "\\Resources\\SAP_red.bmp");
        PDFFunctions.gfx[this.k].DrawImage(XImage.op_Implicit(PDFFunctions.myImage), 510, 20, 60, 40);
        PDFFunctions.myImage2 = PDFFunctions.DrawEnvironGraphPredicted(Country, House);
        PDFFunctions.myImage3 = PDFFunctions.DrawEnergyGraphPredicated(Country, House);
        PDFFunctions.gfx[this.k].DrawImage(XImage.op_Implicit(PDFFunctions.myImage2), 300, checked (this.R + 20), 275, 230);
        PDFFunctions.gfx[this.k].DrawImage(XImage.op_Implicit(PDFFunctions.myImage3), 20, checked (this.R + 20), 275, 230);
        this.R = 520;
        XGraphics xgraphics23 = PDFFunctions.gfx[this.k];
        XFont arialFont11_18 = PDFFunctions.ArialFont11;
        XSolidBrush black18 = XBrushes.Black;
        double r18 = (double) this.R;
        xunit2 = PDFFunctions.pages[this.k].Width;
        double point2 = ((XUnit) ref xunit2).Point;
        xunit2 = PDFFunctions.pages[this.k].Height;
        double point3 = ((XUnit) ref xunit2).Point;
        XRect xrect23 = new XRect(20.0, r18, point2, point3);
        XStringFormat topLeft23 = XStringFormat.TopLeft;
        xgraphics23.DrawString("The energy efficiency rating is a measure of the", arialFont11_18, (XBrush) black18, xrect23, topLeft23);
        XGraphics xgraphics24 = PDFFunctions.gfx[this.k];
        XFont arialFont11_19 = PDFFunctions.ArialFont11;
        XSolidBrush black19 = XBrushes.Black;
        double r19 = (double) this.R;
        xunit2 = PDFFunctions.pages[this.k].Width;
        double point4 = ((XUnit) ref xunit2).Point;
        xunit2 = PDFFunctions.pages[this.k].Height;
        double point5 = ((XUnit) ref xunit2).Point;
        XRect xrect24 = new XRect(300.0, r19, point4, point5);
        XStringFormat topLeft24 = XStringFormat.TopLeft;
        xgraphics24.DrawString("The environmental impact rating is a measure of a", arialFont11_19, (XBrush) black19, xrect24, topLeft24);
        checked { this.R += 12; }
        XGraphics xgraphics25 = PDFFunctions.gfx[this.k];
        XFont arialFont11_20 = PDFFunctions.ArialFont11;
        XSolidBrush black20 = XBrushes.Black;
        double r20 = (double) this.R;
        xunit2 = PDFFunctions.pages[this.k].Width;
        double point6 = ((XUnit) ref xunit2).Point;
        xunit2 = PDFFunctions.pages[this.k].Height;
        double point7 = ((XUnit) ref xunit2).Point;
        XRect xrect25 = new XRect(20.0, r20, point6, point7);
        XStringFormat topLeft25 = XStringFormat.TopLeft;
        xgraphics25.DrawString("overall efficiency of a home. The higher the rating", arialFont11_20, (XBrush) black20, xrect25, topLeft25);
        XGraphics xgraphics26 = PDFFunctions.gfx[this.k];
        XFont arialFont11_21 = PDFFunctions.ArialFont11;
        XSolidBrush black21 = XBrushes.Black;
        double r21 = (double) this.R;
        xunit2 = PDFFunctions.pages[this.k].Width;
        double point8 = ((XUnit) ref xunit2).Point;
        xunit2 = PDFFunctions.pages[this.k].Height;
        double point9 = ((XUnit) ref xunit2).Point;
        XRect xrect26 = new XRect(300.0, r21, point8, point9);
        XStringFormat topLeft26 = XStringFormat.TopLeft;
        xgraphics26.DrawString("home’s impact on the environment in terms of", arialFont11_21, (XBrush) black21, xrect26, topLeft26);
        checked { this.R += 12; }
        XGraphics xgraphics27 = PDFFunctions.gfx[this.k];
        XFont arialFont11_22 = PDFFunctions.ArialFont11;
        XSolidBrush black22 = XBrushes.Black;
        double r22 = (double) this.R;
        xunit2 = PDFFunctions.pages[this.k].Width;
        double point10 = ((XUnit) ref xunit2).Point;
        xunit2 = PDFFunctions.pages[this.k].Height;
        double point11 = ((XUnit) ref xunit2).Point;
        XRect xrect27 = new XRect(20.0, r22, point10, point11);
        XStringFormat topLeft27 = XStringFormat.TopLeft;
        xgraphics27.DrawString("the more energy efficient the home is and the lower", arialFont11_22, (XBrush) black22, xrect27, topLeft27);
        XGraphics xgraphics28 = PDFFunctions.gfx[this.k];
        XFont arialFont11_23 = PDFFunctions.ArialFont11;
        XSolidBrush black23 = XBrushes.Black;
        double r23 = (double) this.R;
        xunit2 = PDFFunctions.pages[this.k].Width;
        double point12 = ((XUnit) ref xunit2).Point;
        xunit2 = PDFFunctions.pages[this.k].Height;
        double point13 = ((XUnit) ref xunit2).Point;
        XRect xrect28 = new XRect(300.0, r23, point12, point13);
        XStringFormat topLeft28 = XStringFormat.TopLeft;
        xgraphics28.DrawString("carbon dioxide (CO2) emissions. The higher the", arialFont11_23, (XBrush) black23, xrect28, topLeft28);
        checked { this.R += 12; }
        XGraphics xgraphics29 = PDFFunctions.gfx[this.k];
        XFont arialFont11_24 = PDFFunctions.ArialFont11;
        XSolidBrush black24 = XBrushes.Black;
        double r24 = (double) this.R;
        xunit2 = PDFFunctions.pages[this.k].Width;
        double point14 = ((XUnit) ref xunit2).Point;
        xunit2 = PDFFunctions.pages[this.k].Height;
        double point15 = ((XUnit) ref xunit2).Point;
        XRect xrect29 = new XRect(20.0, r24, point14, point15);
        XStringFormat topLeft29 = XStringFormat.TopLeft;
        xgraphics29.DrawString("the fuel bills are likely to be.", arialFont11_24, (XBrush) black24, xrect29, topLeft29);
        XGraphics xgraphics30 = PDFFunctions.gfx[this.k];
        XFont arialFont11_25 = PDFFunctions.ArialFont11;
        XSolidBrush black25 = XBrushes.Black;
        double r25 = (double) this.R;
        xunit2 = PDFFunctions.pages[this.k].Width;
        double point16 = ((XUnit) ref xunit2).Point;
        xunit2 = PDFFunctions.pages[this.k].Height;
        double point17 = ((XUnit) ref xunit2).Point;
        XRect xrect30 = new XRect(300.0, r25, point16, point17);
        XStringFormat topLeft30 = XStringFormat.TopLeft;
        xgraphics30.DrawString("rating the less impact it has on the environment.", arialFont11_25, (XBrush) black25, xrect30, topLeft30);
        checked { this.R += 12; }
        this.RC1 = this.R;
        this.CC1 = checked (this.R + 20);
        if (!Validation.UserLogged)
        {
          PDFFunctions.transbrush = XBrush.op_Implicit((Brush) new SolidBrush(Color.FromArgb(128, Color.Olive)));
          XGraphics xgraphics31 = PDFFunctions.gfx[this.k];
          XFont draftArialFont200 = PDFFunctions.DraftArialFont200;
          XBrush transbrush = PDFFunctions.transbrush;
          xunit2 = PDFFunctions.pages[this.k].Width;
          double point18 = ((XUnit) ref xunit2).Point;
          xunit2 = PDFFunctions.pages[this.k].Height;
          double point19 = ((XUnit) ref xunit2).Point;
          XRect xrect31 = new XRect(0.0, 0.0, point18, point19);
          XStringFormat center = XStringFormat.Center;
          xgraphics31.DrawString("DRAFT", draftArialFont200, transbrush, xrect31, center);
        }
        SAP_Module.PredicatedEPC = "";
        object folderPath = (object) Environment.GetFolderPath(Environment.SpecialFolder.Personal);
        DirectoryInfo directoryInfo1 = new DirectoryInfo(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(folderPath, (object) "\\Stroma SAP 2012")));
        DirectoryInfo directoryInfo2 = new DirectoryInfo(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(folderPath, (object) "\\Stroma SAP 2012\\"), (object) SAP_Module.Proj.Name)));
        DirectoryInfo directoryInfo3 = new DirectoryInfo(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(folderPath, (object) "\\Stroma SAP 2012\\"), (object) SAP_Module.Proj.Name), (object) "\\"), (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Name)));
        SAP_Module.PredicatedEPC = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(folderPath, (object) "\\Stroma SAP 2012\\"), (object) SAP_Module.Proj.Name), (object) "\\"), (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Name), (object) "\\"), (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Name), (object) "-Predicted EPC"), (object) ".pdf"));
        if (!Directory.Exists(SAP_Module.PredicatedEPC))
          Directory.CreateDirectory(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(folderPath, (object) "\\Stroma SAP 2012\\"), (object) SAP_Module.Proj.Name), (object) "\\"), (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Name)));
        PDFFunctions.document.Save(SAP_Module.PredicatedEPC);
        this.PDFCreated = (Stream) new MemoryStream();
        if (Validation.PredicatedCheck)
        {
          MyProject.Forms.EPC_Viewer.EPCViewer.Navigate(SAP_Module.PredicatedEPC);
          int num54 = (int) MyProject.Forms.EPC_Viewer.ShowDialog();
          Validation.PredicatedCheck = false;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num55 = (int) Interaction.MsgBox((object) (ex.Message + Information.Err().Description));
        int num56 = (int) Interaction.MsgBox((object) "There is a problem during Creating the English EPC", MsgBoxStyle.Critical);
        ProjectData.ClearProjectError();
      }
      return this.PDFCreated;
    }

    public CreatePDF.DraftDetails CreateDraft(int Country)
    {
      CreatePDF.DraftDetails draft = new CreatePDF.DraftDetails();
      CreatePDF createPdf = new CreatePDF();
      SAP2012.SAPRef.DraftDetails draftDetails = new SAP2012.SAPRef.DraftDetails();
      PDFFunctions.Draft_PDF = true;
      if (File.Exists(SAP_Module.SAPEPCName))
        File.Delete(SAP_Module.SAPEPCName);
      try
      {
        SAPSoapClient sapSoapClient = new SAPSoapClient();
        Calc2012 calc2012 = new Calc2012();
        calc2012.SETPCDF(SAP_Module.PCDFData);
        calc2012.Dwelling = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling];
        XML2012 xmL2012 = new XML2012();
        SAP_Module.Calculation2012 = calc2012;
        SAP_Module.Proj.NoOfDwells = SAP_Module.Proj.NoOfDwells;
        string sapxml = xmL2012.CreateSAPXML(SAP_Module.CurrDwelling, Country);
        draftDetails = sapSoapClient.SAP_Drafts(sapxml, Validation.AssessorNO, "0000-0000-0000-0000-0000", Country, MyProject.Forms.Members_Details.txtUser.Text, Functions.MD5_Hash(MyProject.Forms.Members_Details.txtPassword.Text), Functions.TransactionID, Functions.Encrypt);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Console.Write((object) ex.InnerException);
        ProjectData.ClearProjectError();
      }
      draft.DraftCrated = draftDetails.DraftCrated;
      if (Country == 4)
        draft.Filename = SAP_Module.ScottishFileName;
      draft.Filename = draftDetails.Filename;
      draft.DraftEPC = draftDetails.DraftEPC;
      return draft;
    }

    private void CheckNotesPageLength()
    {
      if (this.R < 700)
        return;
      this.CreateNewNotesPage();
    }

    private void CreateNewNotesPage()
    {
      checked { ++this.k; }
      try
      {
        PDFFunctions.pages[this.k] = PDFFunctions.document.AddPage();
        PDFFunctions.gfx[this.k] = XGraphics.FromPdfPage(PDFFunctions.pages[this.k]);
        this.R = 50;
        PDFFunctions.xBrush1 = XBrush.op_Implicit((Brush) new SolidBrush(Color.FromArgb(159, 172, 62)));
        PDFFunctions.Points[0].X = 20f;
        PDFFunctions.Points[0].Y = (float) this.R;
        ref PointF local1 = ref PDFFunctions.Points[1];
        XUnit width1 = PDFFunctions.pages[this.k].Width;
        double num1 = ((XUnit) ref width1).Point - 20.0;
        local1.X = (float) num1;
        PDFFunctions.Points[1].Y = (float) this.R;
        ref PointF local2 = ref PDFFunctions.Points[2];
        XUnit width2 = PDFFunctions.pages[this.k].Width;
        double num2 = ((XUnit) ref width2).Point - 20.0;
        local2.X = (float) num2;
        PDFFunctions.Points[2].Y = (float) checked (this.R + 40);
        PDFFunctions.Points[3].X = 20f;
        PDFFunctions.Points[3].Y = (float) checked (this.R + 40);
        PDFFunctions.gfx[this.k].DrawPolygon(PDFFunctions.polyGreen2, PDFFunctions.xBrush1, PDFFunctions.Points, PDFFunctions.Fill);
        XGraphics xgraphics = PDFFunctions.gfx[this.k];
        XFont dilleniaUpC16 = PDFFunctions.DilleniaUPC16;
        XSolidBrush black = XBrushes.Black;
        XUnit xunit = PDFFunctions.pages[this.k].Width;
        double point1 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[this.k].Height;
        double point2 = ((XUnit) ref xunit).Point;
        XRect xrect = new XRect(25.0, 50.0, point1, point2);
        XStringFormat topLeft = XStringFormat.TopLeft;
        xgraphics.DrawString("Project & Dwelling Notes", dilleniaUpC16, (XBrush) black, xrect, topLeft);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      checked { this.R += 60; }
    }

    public string PrintNotes()
    {
      string[] strArray1 = new string[1001];
      string str1;
      try
      {
        string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\Stroma SAP 2012\\";
        if (!Directory.Exists(path))
          Directory.CreateDirectory(path);
        PDFFunctions.document = new PdfDocument();
        PDFFunctions.pages[this.k] = PDFFunctions.document.AddPage();
        PDFFunctions.gfx[this.k] = XGraphics.FromPdfPage(PDFFunctions.pages[this.k]);
        this.R = 50;
        PDFFunctions.xBrush1 = XBrush.op_Implicit((Brush) new SolidBrush(Color.FromArgb(159, 172, 62)));
        PDFFunctions.Points[0].X = 20f;
        PDFFunctions.Points[0].Y = (float) this.R;
        ref PointF local1 = ref PDFFunctions.Points[1];
        XUnit width1 = PDFFunctions.pages[this.k].Width;
        double num1 = ((XUnit) ref width1).Point - 20.0;
        local1.X = (float) num1;
        PDFFunctions.Points[1].Y = (float) this.R;
        ref PointF local2 = ref PDFFunctions.Points[2];
        XUnit width2 = PDFFunctions.pages[this.k].Width;
        double num2 = ((XUnit) ref width2).Point - 20.0;
        local2.X = (float) num2;
        PDFFunctions.Points[2].Y = (float) checked (this.R + 40);
        PDFFunctions.Points[3].X = 20f;
        PDFFunctions.Points[3].Y = (float) checked (this.R + 40);
        PDFFunctions.gfx[this.k].DrawPolygon(PDFFunctions.polyGreen2, PDFFunctions.xBrush1, PDFFunctions.Points, PDFFunctions.Fill);
        XGraphics xgraphics1 = PDFFunctions.gfx[this.k];
        XFont dilleniaUpC16 = PDFFunctions.DilleniaUPC16;
        XSolidBrush black1 = XBrushes.Black;
        XUnit width3 = PDFFunctions.pages[this.k].Width;
        double point1 = ((XUnit) ref width3).Point;
        XUnit height1 = PDFFunctions.pages[this.k].Height;
        double point2 = ((XUnit) ref height1).Point;
        XRect xrect1 = new XRect(25.0, 50.0, point1, point2);
        XStringFormat topLeft1 = XStringFormat.TopLeft;
        xgraphics1.DrawString("Project & Dwelling Notes", dilleniaUpC16, (XBrush) black1, xrect1, topLeft1);
        checked { this.R += 60; }
        int index1 = 0;
        do
        {
          strArray1[index1] = "";
          checked { ++index1; }
        }
        while (index1 <= 1000);
        try
        {
          if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Name, "", false) > 0U)
          {
            if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Comments, "", false) > 0U)
            {
              XGraphics xgraphics2 = PDFFunctions.gfx[this.k];
              string name = SAP_Module.Proj.Name;
              XFont dilleniaUpC11Bold = PDFFunctions.DilleniaUPC11Bold;
              XSolidBrush black2 = XBrushes.Black;
              double r1 = (double) this.R;
              XUnit width4 = PDFFunctions.pages[this.k].Width;
              double point3 = ((XUnit) ref width4).Point;
              XUnit height2 = PDFFunctions.pages[this.k].Height;
              double point4 = ((XUnit) ref height2).Point;
              XRect xrect2 = new XRect(20.0, r1, point3, point4);
              XStringFormat topLeft2 = XStringFormat.TopLeft;
              xgraphics2.DrawString(name, dilleniaUpC11Bold, (XBrush) black2, xrect2, topLeft2);
              // ISSUE: variable of a reference type
              int& local3;
              // ISSUE: explicit reference operation
              int num3 = checked (^(local3 = ref this.R) + 20);
              local3 = num3;
              string[] strArray2 = SAP_Module.Proj.Comments.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
              int num4 = checked (strArray2.Length - 1);
              int index2 = 0;
              while (index2 <= num4)
              {
                string[] strArray3 = PDFFunctions.CheckNotesWidth(strArray2[index2], 0);
                int num5 = checked (strArray3.Length - 1);
                int index3 = 0;
                while (index3 <= num5)
                {
                  if (strArray3 != null && (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(strArray3[index3], "", false) > 0U)
                  {
                    XGraphics xgraphics3 = PDFFunctions.gfx[this.k];
                    string str2 = strArray3[index3];
                    XFont dilleniaUpC10 = PDFFunctions.DilleniaUPC10;
                    XSolidBrush black3 = XBrushes.Black;
                    double r2 = (double) this.R;
                    XUnit xunit = PDFFunctions.pages[this.k].Width;
                    double point5 = ((XUnit) ref xunit).Point;
                    xunit = PDFFunctions.pages[this.k].Height;
                    double point6 = ((XUnit) ref xunit).Point;
                    XRect xrect3 = new XRect(20.0, r2, point5, point6);
                    XStringFormat topLeft3 = XStringFormat.TopLeft;
                    xgraphics3.DrawString(str2, dilleniaUpC10, (XBrush) black3, xrect3, topLeft3);
                    // ISSUE: variable of a reference type
                    int& local4;
                    // ISSUE: explicit reference operation
                    int num6 = checked (^(local4 = ref this.R) + 10);
                    local4 = num6;
                    this.CheckNotesPageLength();
                  }
                  checked { ++index3; }
                }
                checked { ++index2; }
              }
              // ISSUE: variable of a reference type
              int& local5;
              // ISSUE: explicit reference operation
              int num7 = checked (^(local5 = ref this.R) + 20);
              local5 = num7;
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
          int num8 = checked (SAP_Module.Proj.NoOfDwells - 1);
          int k = 0;
          while (k <= num8)
          {
            if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[k].Comments, "", false) > 0U)
            {
              XGraphics xgraphics4 = PDFFunctions.gfx[this.k];
              string name = SAP_Module.Proj.Dwellings[k].Name;
              XFont dilleniaUpC11Bold = PDFFunctions.DilleniaUPC11Bold;
              XSolidBrush black4 = XBrushes.Black;
              double r3 = (double) this.R;
              XUnit xunit = PDFFunctions.pages[this.k].Width;
              double point7 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[this.k].Height;
              double point8 = ((XUnit) ref xunit).Point;
              XRect xrect4 = new XRect(20.0, r3, point7, point8);
              XStringFormat topLeft4 = XStringFormat.TopLeft;
              xgraphics4.DrawString(name, dilleniaUpC11Bold, (XBrush) black4, xrect4, topLeft4);
              // ISSUE: variable of a reference type
              int& local6;
              // ISSUE: explicit reference operation
              int num9 = checked (^(local6 = ref this.R) + 20);
              local6 = num9;
              string[] strArray4 = SAP_Module.Proj.Dwellings[k].Comments.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
              int num10 = checked (strArray4.Length - 1);
              int index4 = 0;
              while (index4 <= num10)
              {
                string[] strArray5 = PDFFunctions.CheckNotesWidth(strArray4[index4], k);
                int num11 = checked (strArray5.Length - 1);
                int index5 = 0;
                while (index5 <= num11)
                {
                  if (strArray5 != null && (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(strArray5[index5], "", false) > 0U)
                  {
                    XGraphics xgraphics5 = PDFFunctions.gfx[this.k];
                    string str3 = strArray5[index5];
                    XFont dilleniaUpC10 = PDFFunctions.DilleniaUPC10;
                    XSolidBrush black5 = XBrushes.Black;
                    double r4 = (double) this.R;
                    xunit = PDFFunctions.pages[this.k].Width;
                    double point9 = ((XUnit) ref xunit).Point;
                    xunit = PDFFunctions.pages[this.k].Height;
                    double point10 = ((XUnit) ref xunit).Point;
                    XRect xrect5 = new XRect(20.0, r4, point9, point10);
                    XStringFormat topLeft5 = XStringFormat.TopLeft;
                    xgraphics5.DrawString(str3, dilleniaUpC10, (XBrush) black5, xrect5, topLeft5);
                    // ISSUE: variable of a reference type
                    int& local7;
                    // ISSUE: explicit reference operation
                    int num12 = checked (^(local7 = ref this.R) + 10);
                    local7 = num12;
                    this.CheckNotesPageLength();
                  }
                  checked { ++index5; }
                }
                checked { ++index4; }
              }
              // ISSUE: variable of a reference type
              int& local8;
              // ISSUE: explicit reference operation
              int num13 = checked (^(local8 = ref this.R) + 20);
              local8 = num13;
            }
            checked { ++k; }
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        object folderPath = (object) Environment.GetFolderPath(Environment.SpecialFolder.Personal);
        DirectoryInfo directoryInfo1 = new DirectoryInfo(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(folderPath, (object) "\\Stroma SAP 2012")));
        DirectoryInfo directoryInfo2 = new DirectoryInfo(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(folderPath, (object) "\\Stroma SAP 2012\\"), (object) SAP_Module.Proj.Name)));
        if (!directoryInfo2.Exists)
          directoryInfo2.Create();
        string str4 = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(folderPath, (object) "\\Stroma SAP 2012\\"), (object) SAP_Module.Proj.Name), (object) "\\"), (object) "Notes"), (object) ".pdf"));
        if (File.Exists(str4))
          File.Delete(str4);
        PDFFunctions.document.Save(str4);
        MyProject.Forms.EPC_Viewer.EPCViewer.Navigate(str4);
        int num14 = (int) MyProject.Forms.EPC_Viewer.ShowDialog();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        str1 = "Error creating notes";
        ProjectData.ClearProjectError();
      }
      return str1;
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

    public class DraftDetails
    {
      public string Filename { get; set; }

      public string DraftEPC { get; set; }

      public bool DraftCrated { get; set; }
    }
  }
}
