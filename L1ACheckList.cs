
// Type: SAP2012.L1ACheckList




using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using SAP2012.SAP09Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;

namespace SAP2012
{
  [StandardModule]
  internal sealed class L1ACheckList
  {
    private static float ImageHeight;
    private static float ImageWidth;
    private static float ImageX;
    private static float ImageY;
    private static int k;
    private static int R;
    private static int Col;
    private static int T_Count;
    private static int RC1;
    private static int CC1;
    private static int RM;
    public static bool SAP09DataOperation;
    private static string[] Address = new string[5];
    private static float Con = 2.833f;
    private static bool NewPageRequired;
    private static double Cylindercheck;
    private static double CylindercheckOriginal;
    private static bool CylinderFound;
    private static bool CPSUFound;
    private static DataRow[] MainVent;
    private static object SubVent;
    private static double DERCHeck;
    private static bool SpecialFeatureFound;
    private static bool CommFeature_found;
    private static bool CPSU;

    public static void L1ACheckListCreate(int House, Calc2012 MyCal)
    {
      // ISSUE: variable of a compiler-generated type
      L1ACheckList._Closure\u0024__26\u002D0 closure260_1;
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      L1ACheckList._Closure\u0024__26\u002D0 closure260_2 = new L1ACheckList._Closure\u0024__26\u002D0(closure260_1);
      // ISSUE: reference to a compiler-generated field
      closure260_2.\u0024VB\u0024Local_House = House;
      L1ACheckList.k = 0;
      XPen xpen = new XPen(XColor.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue));
      PDFFunctions.document = new PdfDocument();
      PDFFunctions.pages[L1ACheckList.k] = PDFFunctions.document.AddPage();
      PDFFunctions.gfx[L1ACheckList.k] = XGraphics.FromPdfPage(PDFFunctions.pages[L1ACheckList.k]);
      PDFFunctions.transbrush = XBrush.op_Implicit((Brush) new SolidBrush(Color.FromArgb(128, Color.Olive)));
      if (!Validation.UserLogged)
      {
        XGraphics xgraphics = PDFFunctions.gfx[0];
        XFont draftArialFont200 = PDFFunctions.DraftArialFont200;
        XBrush transbrush = PDFFunctions.transbrush;
        XUnit width = PDFFunctions.pages[L1ACheckList.k].Width;
        double point1 = ((XUnit) ref width).Point;
        XUnit height = PDFFunctions.pages[L1ACheckList.k].Height;
        double point2 = ((XUnit) ref height).Point;
        XRect xrect = new XRect(0.0, 0.0, point1, point2);
        XStringFormat center = XStringFormat.Center;
        xgraphics.DrawString("DRAFT", draftArialFont200, transbrush, xrect, center);
      }
      if (!L1ACheckList.SAP09DataOperation)
      {
        XGraphics xgraphics = PDFFunctions.gfx[0];
        XFont draftArialFont200 = PDFFunctions.DraftArialFont200;
        XBrush transbrush = PDFFunctions.transbrush;
        XUnit width = PDFFunctions.pages[L1ACheckList.k].Width;
        double point3 = ((XUnit) ref width).Point;
        XUnit height = PDFFunctions.pages[L1ACheckList.k].Height;
        double point4 = ((XUnit) ref height).Point;
        XRect xrect = new XRect(0.0, 0.0, point3, point4);
        XStringFormat center = XStringFormat.Center;
        xgraphics.DrawString("DRAFT", draftArialFont200, transbrush, xrect, center);
      }
      XSize pageSize = PDFFunctions.gfx[L1ACheckList.k].PageSize;
      double num1 = ((XSize) ref pageSize).Width / 2.0;
      XSize xsize = PDFFunctions.gfx[L1ACheckList.k].MeasureString("Regulations Compliance Report", PDFFunctions.ArialFont16Bold);
      double num2 = ((XSize) ref xsize).Width / 2.0;
      int num3 = checked ((int) Math.Round(unchecked (num1 - num2)));
      XGraphics xgraphics1 = PDFFunctions.gfx[L1ACheckList.k];
      XFont arialFont16Bold = PDFFunctions.ArialFont16Bold;
      XSolidBrush black1 = XBrushes.Black;
      double num4 = (double) num3;
      XUnit width1 = PDFFunctions.pages[L1ACheckList.k].Width;
      double point5 = ((XUnit) ref width1).Point;
      XUnit xunit = PDFFunctions.pages[L1ACheckList.k].Height;
      double num5 = ((XUnit) ref xunit).Point / 2.0;
      XRect xrect1 = new XRect(num4, 30.0, point5, num5);
      XStringFormat topLeft1 = XStringFormat.TopLeft;
      xgraphics1.DrawString("Regulations Compliance Report", arialFont16Bold, (XBrush) black1, xrect1, topLeft1);
      string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\Stroma SAP 2012\\";
      if (!Directory.Exists(path))
        Directory.CreateDirectory(path);
      if (File.Exists(path + "Logo.jpg"))
      {
        Image image = Image.FromFile(path + "Logo.jpg");
        int num6;
        int num7;
        int num8;
        int num9;
        if ((double) image.Width / (double) image.Height > 5.0 / 3.0)
        {
          num6 = 475;
          num7 = 100;
          num8 = checked ((int) Math.Round((double) L1ACheckList.ImageY));
          num9 = checked ((int) Math.Round(unchecked ((double) checked (image.Height * 100) / (double) image.Width)));
        }
        else
        {
          num8 = checked ((int) Math.Round((double) L1ACheckList.ImageY));
          num9 = 60;
          num6 = checked ((int) Math.Round(unchecked (575.0 - (double) image.Width / (double) image.Height * 60.0)));
          num7 = checked ((int) Math.Round(unchecked ((double) image.Width / (double) image.Height * 60.0)));
        }
        PDFFunctions.gfx[L1ACheckList.k].DrawImage(XImage.op_Implicit(image), num6, num8, num7, num9);
        image.Dispose();
      }
      if (UserSettings.USettings.PrintUserSettings.Print)
        PDFFunctions.PrintUserDetails(PDFFunctions.gfx[L1ACheckList.k]);
      L1ACheckList.RC1 = 65;
      // ISSUE: reference to a compiler-generated field
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Address.Country, "Scotland", false) == 0)
      {
        if (!SAP_Module.Proj.OverRide)
        {
          XGraphics xgraphics2 = PDFFunctions.gfx[L1ACheckList.k];
          string str = "Technical Handbook 2017, Domestic, Section 6 Summary of compliance with standard 6.1  , " + SAP_Module.CurrVersion;
          XFont arialFont10 = PDFFunctions.ArialFont10;
          XSolidBrush black2 = XBrushes.Black;
          double rc1 = (double) L1ACheckList.RC1;
          xunit = PDFFunctions.pages[L1ACheckList.k].Width;
          double point6 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[L1ACheckList.k].Height;
          double num10 = ((XUnit) ref xunit).Point / 2.0;
          XRect xrect2 = new XRect(20.0, rc1, point6, num10);
          XStringFormat topLeft2 = XStringFormat.TopLeft;
          xgraphics2.DrawString(str, arialFont10, (XBrush) black2, xrect2, topLeft2);
        }
        else
        {
          XGraphics xgraphics3 = PDFFunctions.gfx[L1ACheckList.k];
          string str = "Technical Handbook 2010, Domestic, Section 6 assessed by program FSAP 2012 , " + SAP_Module.Proj.CalcVersion;
          XFont arialFont10 = PDFFunctions.ArialFont10;
          XSolidBrush black3 = XBrushes.Black;
          double rc1 = (double) L1ACheckList.RC1;
          xunit = PDFFunctions.pages[L1ACheckList.k].Width;
          double point7 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[L1ACheckList.k].Height;
          double num11 = ((XUnit) ref xunit).Point / 2.0;
          XRect xrect3 = new XRect(20.0, rc1, point7, num11);
          XStringFormat topLeft3 = XStringFormat.TopLeft;
          xgraphics3.DrawString(str, arialFont10, (XBrush) black3, xrect3, topLeft3);
        }
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Address.Country, "Northern Ireland", false) == 0)
        {
          XGraphics xgraphics4 = PDFFunctions.gfx[L1ACheckList.k];
          string str = "Technical Booklet F1, 2012 Edition , " + SAP_Module.Proj.CalcVersion;
          XFont arialFont10 = PDFFunctions.ArialFont10;
          XSolidBrush black4 = XBrushes.Black;
          double rc1 = (double) L1ACheckList.RC1;
          xunit = PDFFunctions.pages[L1ACheckList.k].Width;
          double point8 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[L1ACheckList.k].Height;
          double num12 = ((XUnit) ref xunit).Point / 2.0;
          XRect xrect4 = new XRect(20.0, rc1, point8, num12);
          XStringFormat topLeft4 = XStringFormat.TopLeft;
          xgraphics4.DrawString(str, arialFont10, (XBrush) black4, xrect4, topLeft4);
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Address.Country, "Wales", false) == 0)
          {
            XGraphics xgraphics5 = PDFFunctions.gfx[L1ACheckList.k];
            string str = "Approved Document L1A 2014 Edition, Wales assessed by Stroma FSAP 2012 program, " + SAP_Module.Proj.CalcVersion;
            XFont arialFont10 = PDFFunctions.ArialFont10;
            XSolidBrush black5 = XBrushes.Black;
            double rc1 = (double) L1ACheckList.RC1;
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point9 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num13 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect5 = new XRect(20.0, rc1, point9, num13);
            XStringFormat topLeft5 = XStringFormat.TopLeft;
            xgraphics5.DrawString(str, arialFont10, (XBrush) black5, xrect5, topLeft5);
          }
          else if (!SAP_Module.Proj.OverRide)
          {
            XGraphics xgraphics6 = PDFFunctions.gfx[L1ACheckList.k];
            string str = "Approved Document L1A, 2013 Edition, England assessed by Stroma FSAP 2012 program, " + SAP_Module.CurrVersion;
            XFont arialFont10 = PDFFunctions.ArialFont10;
            XSolidBrush black6 = XBrushes.Black;
            double rc1 = (double) L1ACheckList.RC1;
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point10 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num14 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect6 = new XRect(20.0, rc1, point10, num14);
            XStringFormat topLeft6 = XStringFormat.TopLeft;
            xgraphics6.DrawString(str, arialFont10, (XBrush) black6, xrect6, topLeft6);
          }
          else
          {
            XGraphics xgraphics7 = PDFFunctions.gfx[L1ACheckList.k];
            string str = "Approved Document L1A, 2013 Edition, England assessed by Stroma FSAP 2012 program, " + SAP_Module.Proj.CalcVersion;
            XFont arialFont10 = PDFFunctions.ArialFont10;
            XSolidBrush black7 = XBrushes.Black;
            double rc1 = (double) L1ACheckList.RC1;
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point11 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num15 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect7 = new XRect(20.0, rc1, point11, num15);
            XStringFormat topLeft7 = XStringFormat.TopLeft;
            xgraphics7.DrawString(str, arialFont10, (XBrush) black7, xrect7, topLeft7);
          }
        }
      }
      checked { L1ACheckList.RC1 += 13; }
      XGraphics xgraphics8 = PDFFunctions.gfx[L1ACheckList.k];
      DateTime now = DateAndTime.Now;
      string longDateString = now.ToLongDateString();
      now = DateAndTime.Now;
      string longTimeString = now.ToLongTimeString();
      string str1 = "Printed on " + longDateString + " at " + longTimeString;
      XFont arialFont10Italic = PDFFunctions.ArialFont10Italic;
      XSolidBrush black8 = XBrushes.Black;
      double rc1_1 = (double) L1ACheckList.RC1;
      xunit = PDFFunctions.pages[L1ACheckList.k].Width;
      double point12 = ((XUnit) ref xunit).Point;
      xunit = PDFFunctions.pages[L1ACheckList.k].Height;
      double num16 = ((XUnit) ref xunit).Point / 2.0;
      XRect xrect8 = new XRect(20.0, rc1_1, point12, num16);
      XStringFormat topLeft8 = XStringFormat.TopLeft;
      xgraphics8.DrawString(str1, arialFont10Italic, (XBrush) black8, xrect8, topLeft8);
      checked { L1ACheckList.RC1 += 13; }
      PDFFunctions.xBrush1 = XBrush.op_Implicit((Brush) new SolidBrush(Color.FromArgb(159, 172, 62)));
      PDFFunctions.Points[0].X = 20f;
      PDFFunctions.Points[0].Y = (float) L1ACheckList.RC1;
      ref PointF local1 = ref PDFFunctions.Points[1];
      xunit = PDFFunctions.pages[L1ACheckList.k].Width;
      double num17 = ((XUnit) ref xunit).Point - 20.0;
      local1.X = (float) num17;
      PDFFunctions.Points[1].Y = (float) L1ACheckList.RC1;
      ref PointF local2 = ref PDFFunctions.Points[2];
      xunit = PDFFunctions.pages[L1ACheckList.k].Width;
      double num18 = ((XUnit) ref xunit).Point - 20.0;
      local2.X = (float) num18;
      PDFFunctions.Points[2].Y = (float) checked (L1ACheckList.RC1 + 12);
      PDFFunctions.Points[3].X = 20f;
      PDFFunctions.Points[3].Y = (float) checked (L1ACheckList.RC1 + 12);
      PDFFunctions.gfx[L1ACheckList.k].DrawPolygon(PDFFunctions.polyGreen2, PDFFunctions.xBrush1, PDFFunctions.Points, PDFFunctions.Fill);
      XGraphics xgraphics9 = PDFFunctions.gfx[L1ACheckList.k];
      XFont arialFont10_1 = PDFFunctions.ArialFont10;
      XSolidBrush white1 = XBrushes.White;
      double num19 = (double) checked (L1ACheckList.RC1 + 1);
      xunit = PDFFunctions.pages[L1ACheckList.k].Width;
      double point13 = ((XUnit) ref xunit).Point;
      xunit = PDFFunctions.pages[L1ACheckList.k].Height;
      double num20 = ((XUnit) ref xunit).Point / 2.0;
      XRect xrect9 = new XRect(25.0, num19, point13, num20);
      XStringFormat topLeft9 = XStringFormat.TopLeft;
      xgraphics9.DrawString("Project Information:", arialFont10_1, (XBrush) white1, xrect9, topLeft9);
      L1ACheckList.RC1 = checked ((int) Math.Round(unchecked ((double) PDFFunctions.Points[3].Y + 10.0)));
      XGraphics xgraphics10 = PDFFunctions.gfx[L1ACheckList.k];
      XFont arialFont10Bold1 = PDFFunctions.ArialFont10Bold;
      XSolidBrush black9 = XBrushes.Black;
      double rc1_2 = (double) L1ACheckList.RC1;
      xunit = PDFFunctions.pages[L1ACheckList.k].Width;
      double point14 = ((XUnit) ref xunit).Point;
      xunit = PDFFunctions.pages[L1ACheckList.k].Height;
      double num21 = ((XUnit) ref xunit).Point / 2.0;
      XRect xrect10 = new XRect(20.0, rc1_2, point14, num21);
      XStringFormat topLeft10 = XStringFormat.TopLeft;
      xgraphics10.DrawString("Assessed By:", arialFont10Bold1, (XBrush) black9, xrect10, topLeft10);
      XGraphics xgraphics11 = PDFFunctions.gfx[L1ACheckList.k];
      string str2 = Validation.AssessorFN + " " + Validation.AssessorLN + " (" + Validation.AssessorNO + ")";
      XFont arialFont10_2 = PDFFunctions.ArialFont10;
      XSolidBrush black10 = XBrushes.Black;
      double rc1_3 = (double) L1ACheckList.RC1;
      xunit = PDFFunctions.pages[L1ACheckList.k].Width;
      double point15 = ((XUnit) ref xunit).Point;
      xunit = PDFFunctions.pages[L1ACheckList.k].Height;
      double num22 = ((XUnit) ref xunit).Point / 2.0;
      XRect xrect11 = new XRect(110.0, rc1_3, point15, num22);
      XStringFormat topLeft11 = XStringFormat.TopLeft;
      xgraphics11.DrawString(str2, arialFont10_2, (XBrush) black10, xrect11, topLeft11);
      XGraphics xgraphics12 = PDFFunctions.gfx[L1ACheckList.k];
      XFont arialFont10Bold2 = PDFFunctions.ArialFont10Bold;
      XSolidBrush black11 = XBrushes.Black;
      double rc1_4 = (double) L1ACheckList.RC1;
      xunit = PDFFunctions.pages[L1ACheckList.k].Width;
      double point16 = ((XUnit) ref xunit).Point;
      xunit = PDFFunctions.pages[L1ACheckList.k].Height;
      double num23 = ((XUnit) ref xunit).Point / 2.0;
      XRect xrect12 = new XRect(360.0, rc1_4, point16, num23);
      XStringFormat topLeft12 = XStringFormat.TopLeft;
      xgraphics12.DrawString("Building Type:", arialFont10Bold2, (XBrush) black11, xrect12, topLeft12);
      XGraphics xgraphics13 = PDFFunctions.gfx[L1ACheckList.k];
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      string str3 = SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].BuildForm + " " + SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].PropertyType;
      XFont arialFont10_3 = PDFFunctions.ArialFont10;
      XSolidBrush black12 = XBrushes.Black;
      double rc1_5 = (double) L1ACheckList.RC1;
      xunit = PDFFunctions.pages[L1ACheckList.k].Width;
      double point17 = ((XUnit) ref xunit).Point;
      xunit = PDFFunctions.pages[L1ACheckList.k].Height;
      double num24 = ((XUnit) ref xunit).Point / 2.0;
      XRect xrect13 = new XRect(450.0, rc1_5, point17, num24);
      XStringFormat topLeft13 = XStringFormat.TopLeft;
      xgraphics13.DrawString(str3, arialFont10_3, (XBrush) black12, xrect13, topLeft13);
      checked { L1ACheckList.RC1 += 17; }
      PDFFunctions.xBrush1 = XBrush.op_Implicit((Brush) new SolidBrush(Color.FromArgb(159, 172, 62)));
      PDFFunctions.Points[0].X = 20f;
      PDFFunctions.Points[0].Y = (float) L1ACheckList.RC1;
      ref PointF local3 = ref PDFFunctions.Points[1];
      xunit = PDFFunctions.pages[L1ACheckList.k].Width;
      double num25 = ((XUnit) ref xunit).Point - 20.0;
      local3.X = (float) num25;
      PDFFunctions.Points[1].Y = (float) L1ACheckList.RC1;
      ref PointF local4 = ref PDFFunctions.Points[2];
      xunit = PDFFunctions.pages[L1ACheckList.k].Width;
      double num26 = ((XUnit) ref xunit).Point - 20.0;
      local4.X = (float) num26;
      PDFFunctions.Points[2].Y = (float) checked (L1ACheckList.RC1 + 12);
      PDFFunctions.Points[3].X = 20f;
      PDFFunctions.Points[3].Y = (float) checked (L1ACheckList.RC1 + 12);
      PDFFunctions.gfx[L1ACheckList.k].DrawPolygon(PDFFunctions.polyGreen2, PDFFunctions.xBrush1, PDFFunctions.Points, PDFFunctions.Fill);
      XGraphics xgraphics14 = PDFFunctions.gfx[L1ACheckList.k];
      XFont arialFont10_4 = PDFFunctions.ArialFont10;
      XSolidBrush white2 = XBrushes.White;
      double num27 = (double) checked (L1ACheckList.RC1 + 1);
      xunit = PDFFunctions.pages[L1ACheckList.k].Width;
      double point18 = ((XUnit) ref xunit).Point;
      xunit = PDFFunctions.pages[L1ACheckList.k].Height;
      double num28 = ((XUnit) ref xunit).Point / 2.0;
      XRect xrect14 = new XRect(25.0, num27, point18, num28);
      XStringFormat topLeft14 = XStringFormat.TopLeft;
      xgraphics14.DrawString("Dwelling Details:", arialFont10_4, (XBrush) white2, xrect14, topLeft14);
      checked { L1ACheckList.RC1 += 17; }
      XGraphics xgraphics15 = PDFFunctions.gfx[L1ACheckList.k];
      // ISSUE: reference to a compiler-generated field
      string str4 = Microsoft.VisualBasic.Strings.UCase(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Status);
      XFont arialFont10Bold3 = PDFFunctions.ArialFont10Bold;
      XSolidBrush black13 = XBrushes.Black;
      double rc1_6 = (double) L1ACheckList.RC1;
      xunit = PDFFunctions.pages[L1ACheckList.k].Width;
      double point19 = ((XUnit) ref xunit).Point;
      xunit = PDFFunctions.pages[L1ACheckList.k].Height;
      double num29 = ((XUnit) ref xunit).Point / 2.0;
      XRect xrect15 = new XRect(20.0, rc1_6, point19, num29);
      XStringFormat topLeft15 = XStringFormat.TopLeft;
      xgraphics15.DrawString(str4, arialFont10Bold3, (XBrush) black13, xrect15, topLeft15);
      XGraphics xgraphics16 = PDFFunctions.gfx[L1ACheckList.k];
      string str5 = "Total Floor Area: " + Conversions.ToString(Math.Round(MyCal.Calculation.Dimensions.Box4, 2)) + "m\u00B2";
      XFont arialFont10_5 = PDFFunctions.ArialFont10;
      XSolidBrush black14 = XBrushes.Black;
      double rc1_7 = (double) L1ACheckList.RC1;
      xunit = PDFFunctions.pages[L1ACheckList.k].Width;
      double point20 = ((XUnit) ref xunit).Point;
      xunit = PDFFunctions.pages[L1ACheckList.k].Height;
      double num30 = ((XUnit) ref xunit).Point / 2.0;
      XRect xrect16 = new XRect(360.0, rc1_7, point20, num30);
      XStringFormat topLeft16 = XStringFormat.TopLeft;
      xgraphics16.DrawString(str5, arialFont10_5, (XBrush) black14, xrect16, topLeft16);
      checked { L1ACheckList.RC1 += 15; }
      XGraphics xgraphics17 = PDFFunctions.gfx[L1ACheckList.k];
      XFont arialFont10Bold4 = PDFFunctions.ArialFont10Bold;
      XSolidBrush black15 = XBrushes.Black;
      double rc1_8 = (double) L1ACheckList.RC1;
      xunit = PDFFunctions.pages[L1ACheckList.k].Width;
      double point21 = ((XUnit) ref xunit).Point;
      xunit = PDFFunctions.pages[L1ACheckList.k].Height;
      double num31 = ((XUnit) ref xunit).Point / 2.0;
      XRect xrect17 = new XRect(20.0, rc1_8, point21, num31);
      XStringFormat topLeft17 = XStringFormat.TopLeft;
      xgraphics17.DrawString("Site Reference :", arialFont10Bold4, (XBrush) black15, xrect17, topLeft17);
      XGraphics xgraphics18 = PDFFunctions.gfx[L1ACheckList.k];
      string name1 = SAP_Module.Proj.Name;
      XFont arialFont10_6 = PDFFunctions.ArialFont10;
      XSolidBrush black16 = XBrushes.Black;
      double rc1_9 = (double) L1ACheckList.RC1;
      xunit = PDFFunctions.pages[L1ACheckList.k].Width;
      double point22 = ((XUnit) ref xunit).Point;
      xunit = PDFFunctions.pages[L1ACheckList.k].Height;
      double num32 = ((XUnit) ref xunit).Point / 2.0;
      XRect xrect18 = new XRect(110.0, rc1_9, point22, num32);
      XStringFormat topLeft18 = XStringFormat.TopLeft;
      xgraphics18.DrawString(name1, arialFont10_6, (XBrush) black16, xrect18, topLeft18);
      XGraphics xgraphics19 = PDFFunctions.gfx[L1ACheckList.k];
      XFont arialFont10Bold5 = PDFFunctions.ArialFont10Bold;
      XSolidBrush black17 = XBrushes.Black;
      double rc1_10 = (double) L1ACheckList.RC1;
      xunit = PDFFunctions.pages[L1ACheckList.k].Width;
      double point23 = ((XUnit) ref xunit).Point;
      xunit = PDFFunctions.pages[L1ACheckList.k].Height;
      double num33 = ((XUnit) ref xunit).Point / 2.0;
      XRect xrect19 = new XRect(360.0, rc1_10, point23, num33);
      XStringFormat topLeft19 = XStringFormat.TopLeft;
      xgraphics19.DrawString("Plot Reference:", arialFont10Bold5, (XBrush) black17, xrect19, topLeft19);
      XGraphics xgraphics20 = PDFFunctions.gfx[L1ACheckList.k];
      // ISSUE: reference to a compiler-generated field
      string name2 = SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Name;
      XFont arialFont10_7 = PDFFunctions.ArialFont10;
      XSolidBrush black18 = XBrushes.Black;
      double rc1_11 = (double) L1ACheckList.RC1;
      xunit = PDFFunctions.pages[L1ACheckList.k].Width;
      double point24 = ((XUnit) ref xunit).Point;
      xunit = PDFFunctions.pages[L1ACheckList.k].Height;
      double num34 = ((XUnit) ref xunit).Point / 2.0;
      XRect xrect20 = new XRect(450.0, rc1_11, point24, num34);
      XStringFormat topLeft20 = XStringFormat.TopLeft;
      xgraphics20.DrawString(name2, arialFont10_7, (XBrush) black18, xrect20, topLeft20);
      checked { L1ACheckList.RC1 += 17; }
      string str6 = "";
      // ISSUE: reference to a compiler-generated field
      if (!string.IsNullOrEmpty(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Address.Line1))
      {
        // ISSUE: reference to a compiler-generated field
        str6 += SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Address.Line1;
      }
      // ISSUE: reference to a compiler-generated field
      if (!string.IsNullOrEmpty(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Address.Line2))
      {
        // ISSUE: reference to a compiler-generated field
        str6 = str6 + ", " + SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Address.Line2;
      }
      // ISSUE: reference to a compiler-generated field
      if (!string.IsNullOrEmpty(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Address.Line3))
      {
        // ISSUE: reference to a compiler-generated field
        str6 = str6 + ", " + SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Address.Line3;
      }
      // ISSUE: reference to a compiler-generated field
      if (!string.IsNullOrEmpty(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Address.City))
      {
        // ISSUE: reference to a compiler-generated field
        str6 = str6 + ", " + SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Address.City;
      }
      // ISSUE: reference to a compiler-generated field
      if (!string.IsNullOrEmpty(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Address.PostCost))
      {
        // ISSUE: reference to a compiler-generated field
        str6 = str6 + ", " + SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Address.PostCost;
      }
      XGraphics xgraphics21 = PDFFunctions.gfx[L1ACheckList.k];
      XFont arialFont10Bold6 = PDFFunctions.ArialFont10Bold;
      XSolidBrush black19 = XBrushes.Black;
      double rc1_12 = (double) L1ACheckList.RC1;
      xunit = PDFFunctions.pages[L1ACheckList.k].Width;
      double point25 = ((XUnit) ref xunit).Point;
      xunit = PDFFunctions.pages[L1ACheckList.k].Height;
      double num35 = ((XUnit) ref xunit).Point / 2.0;
      XRect xrect21 = new XRect(20.0, rc1_12, point25, num35);
      XStringFormat topLeft21 = XStringFormat.TopLeft;
      xgraphics21.DrawString("Address :", arialFont10Bold6, (XBrush) black19, xrect21, topLeft21);
      XGraphics xgraphics22 = PDFFunctions.gfx[L1ACheckList.k];
      string str7 = str6;
      XFont arialFont10_8 = PDFFunctions.ArialFont10;
      XSolidBrush black20 = XBrushes.Black;
      double rc1_13 = (double) L1ACheckList.RC1;
      xunit = PDFFunctions.pages[L1ACheckList.k].Width;
      double point26 = ((XUnit) ref xunit).Point;
      xunit = PDFFunctions.pages[L1ACheckList.k].Height;
      double num36 = ((XUnit) ref xunit).Point / 2.0;
      XRect xrect22 = new XRect(110.0, rc1_13, point26, num36);
      XStringFormat topLeft22 = XStringFormat.TopLeft;
      xgraphics22.DrawString(str7, arialFont10_8, (XBrush) black20, xrect22, topLeft22);
      checked { L1ACheckList.RC1 += 17; }
      PDFFunctions.xBrush1 = XBrush.op_Implicit((Brush) new SolidBrush(Color.FromArgb(159, 172, 62)));
      PDFFunctions.Points[0].X = 20f;
      PDFFunctions.Points[0].Y = (float) L1ACheckList.RC1;
      ref PointF local5 = ref PDFFunctions.Points[1];
      xunit = PDFFunctions.pages[L1ACheckList.k].Width;
      double num37 = ((XUnit) ref xunit).Point - 20.0;
      local5.X = (float) num37;
      PDFFunctions.Points[1].Y = (float) L1ACheckList.RC1;
      ref PointF local6 = ref PDFFunctions.Points[2];
      xunit = PDFFunctions.pages[L1ACheckList.k].Width;
      double num38 = ((XUnit) ref xunit).Point - 20.0;
      local6.X = (float) num38;
      PDFFunctions.Points[2].Y = (float) checked (L1ACheckList.RC1 + 12);
      PDFFunctions.Points[3].X = 20f;
      PDFFunctions.Points[3].Y = (float) checked (L1ACheckList.RC1 + 12);
      PDFFunctions.gfx[L1ACheckList.k].DrawPolygon(PDFFunctions.polyGreen2, PDFFunctions.xBrush1, PDFFunctions.Points, PDFFunctions.Fill);
      XGraphics xgraphics23 = PDFFunctions.gfx[L1ACheckList.k];
      XFont arialFont10_9 = PDFFunctions.ArialFont10;
      XSolidBrush white3 = XBrushes.White;
      double num39 = (double) checked (L1ACheckList.RC1 + 1);
      xunit = PDFFunctions.pages[L1ACheckList.k].Width;
      double point27 = ((XUnit) ref xunit).Point;
      xunit = PDFFunctions.pages[L1ACheckList.k].Height;
      double num40 = ((XUnit) ref xunit).Point / 2.0;
      XRect xrect23 = new XRect(25.0, num39, point27, num40);
      XStringFormat topLeft23 = XStringFormat.TopLeft;
      xgraphics23.DrawString("Client Details:", arialFont10_9, (XBrush) white3, xrect23, topLeft23);
      checked { L1ACheckList.RC1 += 17; }
      XGraphics xgraphics24 = PDFFunctions.gfx[L1ACheckList.k];
      XFont arialFont10Bold7 = PDFFunctions.ArialFont10Bold;
      XSolidBrush black21 = XBrushes.Black;
      double rc1_14 = (double) L1ACheckList.RC1;
      xunit = PDFFunctions.pages[L1ACheckList.k].Width;
      double point28 = ((XUnit) ref xunit).Point;
      xunit = PDFFunctions.pages[L1ACheckList.k].Height;
      double num41 = ((XUnit) ref xunit).Point / 2.0;
      XRect xrect24 = new XRect(20.0, rc1_14, point28, num41);
      XStringFormat topLeft24 = XStringFormat.TopLeft;
      xgraphics24.DrawString("Name:", arialFont10Bold7, (XBrush) black21, xrect24, topLeft24);
      XGraphics xgraphics25 = PDFFunctions.gfx[L1ACheckList.k];
      string name3 = SAP_Module.Proj.Client.Name;
      XFont arialFont10_10 = PDFFunctions.ArialFont10;
      XSolidBrush black22 = XBrushes.Black;
      double rc1_15 = (double) L1ACheckList.RC1;
      xunit = PDFFunctions.pages[L1ACheckList.k].Width;
      double point29 = ((XUnit) ref xunit).Point;
      xunit = PDFFunctions.pages[L1ACheckList.k].Height;
      double num42 = ((XUnit) ref xunit).Point / 2.0;
      XRect xrect25 = new XRect(110.0, rc1_15, point29, num42);
      XStringFormat topLeft25 = XStringFormat.TopLeft;
      xgraphics25.DrawString(name3, arialFont10_10, (XBrush) black22, xrect25, topLeft25);
      checked { L1ACheckList.RC1 += 14; }
      string str8 = "";
      if (!string.IsNullOrEmpty(SAP_Module.Proj.Client.Address.Line1))
        str8 += SAP_Module.Proj.Client.Address.Line1;
      if (!string.IsNullOrEmpty(SAP_Module.Proj.Client.Address.Line2))
        str8 = str8 + ", " + SAP_Module.Proj.Client.Address.Line2;
      if (!string.IsNullOrEmpty(SAP_Module.Proj.Client.Address.Line3))
        str8 = str8 + ", " + SAP_Module.Proj.Client.Address.Line3;
      if (!string.IsNullOrEmpty(SAP_Module.Proj.Client.Address.City))
        str8 = str8 + ", " + SAP_Module.Proj.Client.Address.City;
      if (!string.IsNullOrEmpty(SAP_Module.Proj.Client.Address.PostCost))
        str8 = str8 + ", " + SAP_Module.Proj.Client.Address.PostCost;
      XGraphics xgraphics26 = PDFFunctions.gfx[L1ACheckList.k];
      XFont arialFont10Bold8 = PDFFunctions.ArialFont10Bold;
      XSolidBrush black23 = XBrushes.Black;
      double rc1_16 = (double) L1ACheckList.RC1;
      xunit = PDFFunctions.pages[L1ACheckList.k].Width;
      double point30 = ((XUnit) ref xunit).Point;
      xunit = PDFFunctions.pages[L1ACheckList.k].Height;
      double num43 = ((XUnit) ref xunit).Point / 2.0;
      XRect xrect26 = new XRect(20.0, rc1_16, point30, num43);
      XStringFormat topLeft26 = XStringFormat.TopLeft;
      xgraphics26.DrawString("Address :", arialFont10Bold8, (XBrush) black23, xrect26, topLeft26);
      XGraphics xgraphics27 = PDFFunctions.gfx[L1ACheckList.k];
      string str9 = str8;
      XFont arialFont10_11 = PDFFunctions.ArialFont10;
      XSolidBrush black24 = XBrushes.Black;
      double rc1_17 = (double) L1ACheckList.RC1;
      xunit = PDFFunctions.pages[L1ACheckList.k].Width;
      double point31 = ((XUnit) ref xunit).Point;
      xunit = PDFFunctions.pages[L1ACheckList.k].Height;
      double num44 = ((XUnit) ref xunit).Point / 2.0;
      XRect xrect27 = new XRect(110.0, rc1_17, point31, num44);
      XStringFormat topLeft27 = XStringFormat.TopLeft;
      xgraphics27.DrawString(str9, arialFont10_11, (XBrush) black24, xrect27, topLeft27);
      checked { L1ACheckList.RC1 += 17; }
      XGraphics xgraphics28 = PDFFunctions.gfx[L1ACheckList.k];
      XFont arialFont10Bold9 = PDFFunctions.ArialFont10Bold;
      XSolidBrush black25 = XBrushes.Black;
      double num45 = (double) checked (L1ACheckList.RC1 + 1);
      xunit = PDFFunctions.pages[L1ACheckList.k].Width;
      double point32 = ((XUnit) ref xunit).Point;
      xunit = PDFFunctions.pages[L1ACheckList.k].Height;
      double num46 = ((XUnit) ref xunit).Point / 2.0;
      XRect xrect28 = new XRect(20.0, num45, point32, num46);
      XStringFormat topLeft28 = XStringFormat.TopLeft;
      xgraphics28.DrawString("This report covers items included within the SAP calculations.", arialFont10Bold9, (XBrush) black25, xrect28, topLeft28);
      checked { L1ACheckList.RC1 += 13; }
      XGraphics xgraphics29 = PDFFunctions.gfx[L1ACheckList.k];
      XFont arialFont10Bold10 = PDFFunctions.ArialFont10Bold;
      XSolidBrush black26 = XBrushes.Black;
      double num47 = (double) checked (L1ACheckList.RC1 + 1);
      xunit = PDFFunctions.pages[L1ACheckList.k].Width;
      double point33 = ((XUnit) ref xunit).Point;
      xunit = PDFFunctions.pages[L1ACheckList.k].Height;
      double num48 = ((XUnit) ref xunit).Point / 2.0;
      XRect xrect29 = new XRect(20.0, num47, point33, num48);
      XStringFormat topLeft29 = XStringFormat.TopLeft;
      xgraphics29.DrawString("It is not a complete report of regulations compliance.", arialFont10Bold10, (XBrush) black26, xrect29, topLeft29);
      checked { L1ACheckList.RC1 += 17; }
      PDFFunctions.xBrush1 = XBrush.op_Implicit((Brush) new SolidBrush(Color.FromArgb(159, 172, 62)));
      PDFFunctions.Points[0].X = 20f;
      PDFFunctions.Points[0].Y = (float) L1ACheckList.RC1;
      ref PointF local7 = ref PDFFunctions.Points[1];
      xunit = PDFFunctions.pages[L1ACheckList.k].Width;
      double num49 = ((XUnit) ref xunit).Point - 20.0;
      local7.X = (float) num49;
      PDFFunctions.Points[1].Y = (float) L1ACheckList.RC1;
      ref PointF local8 = ref PDFFunctions.Points[2];
      xunit = PDFFunctions.pages[L1ACheckList.k].Width;
      double num50 = ((XUnit) ref xunit).Point - 20.0;
      local8.X = (float) num50;
      PDFFunctions.Points[2].Y = (float) checked (L1ACheckList.RC1 + 12);
      PDFFunctions.Points[3].X = 20f;
      PDFFunctions.Points[3].Y = (float) checked (L1ACheckList.RC1 + 12);
      PDFFunctions.gfx[L1ACheckList.k].DrawPolygon(PDFFunctions.polyGreen2, PDFFunctions.xBrush1, PDFFunctions.Points, PDFFunctions.Fill);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Address.Country, "Wales", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Address.Country, "Scotland", false) == 0)
      {
        XGraphics xgraphics30 = PDFFunctions.gfx[L1ACheckList.k];
        XFont arialFont10Bold11 = PDFFunctions.ArialFont10Bold;
        XSolidBrush white4 = XBrushes.White;
        double num51 = (double) checked (L1ACheckList.RC1 + 1);
        xunit = PDFFunctions.pages[L1ACheckList.k].Width;
        double point34 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[L1ACheckList.k].Height;
        double num52 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect30 = new XRect(25.0, num51, point34, num52);
        XStringFormat topLeft30 = XStringFormat.TopLeft;
        xgraphics30.DrawString("1 TER and DER", arialFont10Bold11, (XBrush) white4, xrect30, topLeft30);
      }
      else
      {
        XGraphics xgraphics31 = PDFFunctions.gfx[L1ACheckList.k];
        XFont arialFont10Bold12 = PDFFunctions.ArialFont10Bold;
        XSolidBrush white5 = XBrushes.White;
        double num53 = (double) checked (L1ACheckList.RC1 + 1);
        xunit = PDFFunctions.pages[L1ACheckList.k].Width;
        double point35 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[L1ACheckList.k].Height;
        double num54 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect31 = new XRect(25.0, num53, point35, num54);
        XStringFormat topLeft31 = XStringFormat.TopLeft;
        xgraphics31.DrawString("1a TER and DER", arialFont10Bold12, (XBrush) white5, xrect31, topLeft31);
      }
      checked { L1ACheckList.RC1 += 14; }
      bool flag1 = false;
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      if (SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].IncludeMainHeating2 && (double) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].HeatFractionSec > 0.5)
        flag1 = true;
      string Left1;
      if (flag1)
      {
        // ISSUE: reference to a compiler-generated field
        string fuel = SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.Fuel;
        // ISSUE: reference to a compiler-generated method
        switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(fuel))
        {
          case 157581269:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel, "heating oil", false) == 0)
              goto label_86;
            else
              goto default;
          case 335024745:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel, "heat from boilers – biogas", false) == 0)
              goto label_96;
            else
              goto default;
          case 575487477:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel, "wood pellets (bulk supply in bags, for main heating)", false) == 0)
            {
              Left1 = "Wood pellets (bulk)";
              goto label_146;
            }
            else
              goto default;
          case 604697910:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel, "manufactured smokeless fuel", false) == 0)
              goto label_91;
            else
              goto default;
          case 664172296:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel, "heat from CHP", false) == 0)
              break;
            goto default;
          case 842919835:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel, "heat from boilers – LPG", false) == 0)
              goto label_85;
            else
              goto default;
          case 855763190:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel, "dual fuel appliance (mineral and wood", false) == 0)
            {
              Left1 = "Solid multi-fuel";
              goto label_146;
            }
            else
              goto default;
          case 857289046:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel, "house coal", false) == 0)
              goto label_91;
            else
              goto default;
          case 975024876:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel, "bulk LPG", false) == 0)
            {
              Left1 = "Bulk LPG";
              goto label_146;
            }
            else
              goto default;
          case 1086463322:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel, "LPG subject to Special Condition 18", false) == 0)
              goto label_85;
            else
              goto default;
          case 1384014791:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel, "B30K", false) == 0)
            {
              Left1 = "B30K";
              goto label_146;
            }
            else
              goto default;
          case 1424221758:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel, "geothermal heat source", false) == 0)
              goto label_96;
            else
              goto default;
          case 1441345278:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel, "Electricity", false) == 0)
            {
              Left1 = "Electricity";
              goto label_146;
            }
            else
              goto default;
          case 1522447619:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel, "wood chips", false) == 0)
              goto label_92;
            else
              goto default;
          case 1538586610:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel, "heat from boilers – oil", false) == 0)
              goto label_86;
            else
              goto default;
          case 1597764060:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel, "mains gas", false) == 0)
              break;
            goto default;
          case 1770949684:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel, "appliances able to use mineral oil or liquid biofuel", false) == 0)
              goto label_86;
            else
              goto default;
          case 1946790875:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel, "wood logs", false) == 0)
              goto label_92;
            else
              goto default;
          case 2313921600:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel, "anthracite", false) == 0)
              goto label_91;
            else
              goto default;
          case 2340757125:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel, "heat from boilers - waste combustion", false) == 0)
              goto label_96;
            else
              goto default;
          case 2343415715:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel, "waste heat from power stations", false) == 0)
              goto label_96;
            else
              goto default;
          case 2442528761:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel, "heat from heat pump", false) == 0)
              goto label_96;
            else
              goto default;
          case 3198893402:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel, "rapeseed oil", false) == 0)
              goto label_87;
            else
              goto default;
          case 3216529428:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel, "heat from boilers – biomass", false) == 0)
              goto label_96;
            else
              goto default;
          case 3280312190:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel, "wood pellets (bulk supply in bags, for main heating", false) == 0)
              goto label_92;
            else
              goto default;
          case 3349323758:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel, "biodiesel from any biomass source", false) == 0)
              goto label_87;
            else
              goto default;
          case 3398809853:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel, "heat from boilers – B30D", false) == 0)
            {
              Left1 = "B30D";
              goto label_146;
            }
            else
              goto default;
          case 3722837730:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel, "bottled LPG", false) == 0)
              goto label_85;
            else
              goto default;
          case 3824947145:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel, "heat from boilers – coal", false) == 0)
              goto label_91;
            else
              goto default;
          case 3939572982:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel, "wood pellets (in bags, for secondary heating", false) == 0)
              goto label_92;
            else
              goto default;
          case 4235694608:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel, "biodiesel from used cooking oil only", false) == 0)
              goto label_87;
            else
              goto default;
          case 4241528165:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel, "heat from boilers – mains gas", false) == 0)
              break;
            goto default;
          default:
            // ISSUE: reference to a compiler-generated field
            Left1 = SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.Fuel;
            goto label_146;
        }
        Left1 = "Mains gas";
        goto label_146;
label_85:
        Left1 = "LPG";
        goto label_146;
label_86:
        Left1 = "Oil";
        goto label_146;
label_87:
        Left1 = "Liquid biofuel";
        goto label_146;
label_91:
        Left1 = "Solid mineral fuel";
        goto label_146;
label_92:
        Left1 = "Renewable energy";
        goto label_146;
label_96:
        // ISSUE: reference to a compiler-generated field
        Left1 = SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.Fuel;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        string fuel = SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.Fuel;
        // ISSUE: reference to a compiler-generated method
        switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(fuel))
        {
          case 157581269:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel, "heating oil", false) == 0)
              goto label_133;
            else
              goto default;
          case 335024745:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel, "heat from boilers – biogas", false) == 0)
              goto label_143;
            else
              goto default;
          case 575487477:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel, "wood pellets (bulk supply in bags, for main heating)", false) == 0)
            {
              Left1 = "Wood pellets (bulk)";
              goto label_145;
            }
            else
              goto default;
          case 604697910:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel, "manufactured smokeless fuel", false) == 0)
              goto label_138;
            else
              goto default;
          case 664172296:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel, "heat from CHP", false) == 0)
              break;
            goto default;
          case 721524493:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel, "dual fuel appliance (mineral and wood)", false) == 0)
            {
              Left1 = "Solid multi-fuel";
              goto label_145;
            }
            else
              goto default;
          case 842919835:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel, "heat from boilers – LPG", false) == 0)
              goto label_132;
            else
              goto default;
          case 857289046:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel, "house coal", false) == 0)
              goto label_138;
            else
              goto default;
          case 975024876:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel, "bulk LPG", false) == 0)
            {
              Left1 = "Bulk LPG";
              goto label_145;
            }
            else
              goto default;
          case 1086463322:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel, "LPG subject to Special Condition 18", false) == 0)
              goto label_132;
            else
              goto default;
          case 1384014791:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel, "B30K", false) == 0)
            {
              Left1 = "B30K";
              goto label_145;
            }
            else
              goto default;
          case 1424221758:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel, "geothermal heat source", false) == 0)
              goto label_143;
            else
              goto default;
          case 1441345278:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel, "Electricity", false) == 0)
            {
              Left1 = "Electricity";
              goto label_145;
            }
            else
              goto default;
          case 1522447619:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel, "wood chips", false) == 0)
              goto label_139;
            else
              goto default;
          case 1538586610:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel, "heat from boilers – oil", false) == 0)
              goto label_133;
            else
              goto default;
          case 1597764060:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel, "mains gas", false) == 0)
              break;
            goto default;
          case 1770949684:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel, "appliances able to use mineral oil or liquid biofuel", false) == 0)
              goto label_133;
            else
              goto default;
          case 1946790875:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel, "wood logs", false) == 0)
              goto label_139;
            else
              goto default;
          case 2313921600:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel, "anthracite", false) == 0)
              goto label_138;
            else
              goto default;
          case 2340757125:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel, "heat from boilers - waste combustion", false) == 0)
              goto label_143;
            else
              goto default;
          case 2343415715:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel, "waste heat from power stations", false) == 0)
              goto label_143;
            else
              goto default;
          case 2442528761:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel, "heat from heat pump", false) == 0)
              goto label_143;
            else
              goto default;
          case 3198893402:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel, "rapeseed oil", false) == 0)
              goto label_134;
            else
              goto default;
          case 3216529428:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel, "heat from boilers – biomass", false) == 0)
              goto label_143;
            else
              goto default;
          case 3280312190:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel, "wood pellets (bulk supply in bags, for main heating", false) == 0)
              goto label_139;
            else
              goto default;
          case 3349323758:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel, "biodiesel from any biomass source", false) == 0)
              goto label_134;
            else
              goto default;
          case 3398809853:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel, "heat from boilers – B30D", false) == 0)
            {
              Left1 = "B30D";
              goto label_145;
            }
            else
              goto default;
          case 3722837730:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel, "bottled LPG", false) == 0)
              goto label_132;
            else
              goto default;
          case 3824947145:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel, "heat from boilers – coal", false) == 0)
              goto label_138;
            else
              goto default;
          case 3939572982:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel, "wood pellets (in bags, for secondary heating", false) == 0)
              goto label_139;
            else
              goto default;
          case 4235694608:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel, "biodiesel from used cooking oil only", false) == 0)
              goto label_134;
            else
              goto default;
          case 4241528165:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel, "heat from boilers – mains gas", false) == 0)
              break;
            goto default;
          default:
            // ISSUE: reference to a compiler-generated field
            Left1 = SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.Fuel;
            goto label_145;
        }
        Left1 = "Mains gas";
        goto label_145;
label_132:
        Left1 = "LPG";
        goto label_145;
label_133:
        Left1 = "Oil";
        goto label_145;
label_134:
        Left1 = "Liquid biofuel";
        goto label_145;
label_138:
        Left1 = "Solid mineral fuel";
        goto label_145;
label_139:
        Left1 = "Renewable energy";
        goto label_145;
label_143:
        // ISSUE: reference to a compiler-generated field
        Left1 = SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.Fuel;
label_145:;
      }
label_146:
      // ISSUE: reference to a compiler-generated field
      if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left1, "Mains gas", false) > 0U && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].SecHeating.Fuel, "mains gas", false) == 0)
        Left1 += " (mains gas used for secondary heating)";
      if (flag1)
      {
        // ISSUE: reference to a compiler-generated field
        int sapTableCode = SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.SAPTableCode;
        if (sapTableCode >= 305 && sapTableCode <= 310)
        {
          // ISSUE: reference to a compiler-generated field
          Left1 = L1ACheckList.CheckCommunityFuelDescription(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.Fuel) + " (c)";
          // ISSUE: reference to a compiler-generated field
          if (SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.CommunityH.NoOfAdditionalHeatSources > 0)
          {
            // ISSUE: reference to a compiler-generated field
            Left1 = Left1 + ", " + L1ACheckList.CheckCommunityFuelDescription(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.CommunityH.HeatSource1.Fuel) + " (c)";
          }
          // ISSUE: reference to a compiler-generated field
          if (SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.CommunityH.NoOfAdditionalHeatSources > 1)
          {
            // ISSUE: reference to a compiler-generated field
            Left1 = Left1 + ", " + L1ACheckList.CheckCommunityFuelDescription(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.CommunityH.HeatSource2.Fuel) + " (c)";
          }
          // ISSUE: reference to a compiler-generated field
          if (SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.CommunityH.NoOfAdditionalHeatSources > 2)
          {
            // ISSUE: reference to a compiler-generated field
            Left1 = Left1 + ", " + L1ACheckList.CheckCommunityFuelDescription(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.CommunityH.HeatSource3.Fuel) + " (c)";
          }
          // ISSUE: reference to a compiler-generated field
          if (SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.CommunityH.NoOfAdditionalHeatSources > 3)
          {
            // ISSUE: reference to a compiler-generated field
            Left1 = Left1 + ", " + L1ACheckList.CheckCommunityFuelDescription(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.CommunityH.HeatSource4.Fuel) + " (c)";
          }
        }
        XGraphics xgraphics32 = PDFFunctions.gfx[L1ACheckList.k];
        string str10 = "Fuel for main heating system: " + Left1;
        XFont arialFont10_12 = PDFFunctions.ArialFont10;
        XSolidBrush black27 = XBrushes.Black;
        double num55 = (double) checked (L1ACheckList.RC1 + 1);
        xunit = PDFFunctions.pages[L1ACheckList.k].Width;
        double point36 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[L1ACheckList.k].Height;
        double num56 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect32 = new XRect(20.0, num55, point36, num56);
        XStringFormat topLeft32 = XStringFormat.TopLeft;
        xgraphics32.DrawString(str10, arialFont10_12, (XBrush) black27, xrect32, topLeft32);
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        int sapTableCode = SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.SAPTableCode;
        if (sapTableCode >= 305 && sapTableCode <= 310)
        {
          // ISSUE: reference to a compiler-generated field
          Left1 = L1ACheckList.CheckCommunityFuelDescription(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.Fuel) + " (c)";
          // ISSUE: reference to a compiler-generated field
          if (SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.NoOfAdditionalHeatSources > 0)
          {
            // ISSUE: reference to a compiler-generated field
            Left1 = Left1 + ", " + L1ACheckList.CheckCommunityFuelDescription(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatSource1.Fuel) + " (c)";
          }
          // ISSUE: reference to a compiler-generated field
          if (SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.NoOfAdditionalHeatSources > 1)
          {
            // ISSUE: reference to a compiler-generated field
            Left1 = Left1 + ", " + L1ACheckList.CheckCommunityFuelDescription(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatSource2.Fuel) + " (c)";
          }
          // ISSUE: reference to a compiler-generated field
          if (SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.NoOfAdditionalHeatSources > 2)
          {
            // ISSUE: reference to a compiler-generated field
            Left1 = Left1 + ", " + L1ACheckList.CheckCommunityFuelDescription(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatSource3.Fuel) + " (c)";
          }
          // ISSUE: reference to a compiler-generated field
          if (SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.NoOfAdditionalHeatSources > 3)
          {
            // ISSUE: reference to a compiler-generated field
            Left1 = Left1 + ", " + L1ACheckList.CheckCommunityFuelDescription(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatSource4.Fuel) + " (c)";
          }
        }
        XGraphics xgraphics33 = PDFFunctions.gfx[L1ACheckList.k];
        string str11 = "Fuel for main heating system: " + Left1;
        XFont arialFont10_13 = PDFFunctions.ArialFont10;
        XSolidBrush black28 = XBrushes.Black;
        double num57 = (double) checked (L1ACheckList.RC1 + 1);
        xunit = PDFFunctions.pages[L1ACheckList.k].Width;
        double point37 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[L1ACheckList.k].Height;
        double num58 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect33 = new XRect(20.0, num57, point37, num58);
        XStringFormat topLeft33 = XStringFormat.TopLeft;
        xgraphics33.DrawString(str11, arialFont10_13, (XBrush) black28, xrect33, topLeft33);
      }
      checked { L1ACheckList.RC1 += 13; }
      // ISSUE: reference to a compiler-generated field
      string fuel1 = SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.Fuel;
      double Expression1;
      // ISSUE: reference to a compiler-generated method
      switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(fuel1))
      {
        case 157581269:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel1, "heating oil", false) == 0)
          {
            Expression1 = 1.17;
            goto label_196;
          }
          else
            goto default;
        case 604697910:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel1, "manufactured smokeless fuel", false) == 0)
            goto label_189;
          else
            goto default;
        case 857289046:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel1, "house coal", false) == 0)
            goto label_189;
          else
            goto default;
        case 975024876:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel1, "bulk LPG", false) == 0)
            break;
          goto default;
        case 1086463322:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel1, "LPG subject to Special Condition 18", false) == 0)
          {
            Expression1 = 1.06;
            goto label_196;
          }
          else
            goto default;
        case 1441345278:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel1, "Electricity", false) == 0)
          {
            Expression1 = 1.55;
            goto label_196;
          }
          else
            goto default;
        case 1538586610:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel1, "heat from boilers – oil", false) == 0)
            goto label_193;
          else
            goto default;
        case 1597764060:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel1, "mains gas", false) == 0)
            goto label_190;
          else
            goto default;
        case 1770949684:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel1, "appliances able to use mineral oil or liquid biofuel", false) == 0)
            goto label_193;
          else
            goto default;
        case 1860525480:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel1, "heat from electric heat pump", false) == 0)
          {
            Expression1 = 1.55;
            goto label_196;
          }
          else
            goto default;
        case 2313921600:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel1, "anthracite", false) == 0)
            goto label_189;
          else
            goto default;
        case 3722837730:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel1, "bottled LPG", false) == 0)
            break;
          goto default;
        case 3794681384:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel1, "LNG", false) == 0)
            goto label_190;
          else
            goto default;
        case 3824947145:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel1, "heat from boilers – coal", false) == 0)
          {
            Expression1 = 1.35;
            goto label_196;
          }
          else
            goto default;
        default:
          Expression1 = 1.0;
          goto label_196;
      }
      Expression1 = 1.06;
      goto label_196;
label_189:
      Expression1 = 1.35;
      goto label_196;
label_190:
      Expression1 = 1.0;
      goto label_196;
label_193:
      Expression1 = 1.17;
label_196:
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left1, "Wood pellets (bulk)", false) == 0)
        Left1 = "Wood pellets";
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left1, "Bulk LPG", false) == 0)
        Left1 = "LPG";
      string str12 = Microsoft.VisualBasic.Strings.Format((object) Expression1, "0.00") + " (" + Microsoft.VisualBasic.Strings.LCase(Left1) + ")";
      XGraphics xgraphics34 = PDFFunctions.gfx[L1ACheckList.k];
      string str13 = "Fuel factor: " + str12;
      XFont arialFont10_14 = PDFFunctions.ArialFont10;
      XSolidBrush black29 = XBrushes.Black;
      double num59 = (double) checked (L1ACheckList.RC1 + 1);
      xunit = PDFFunctions.pages[L1ACheckList.k].Width;
      double point38 = ((XUnit) ref xunit).Point;
      xunit = PDFFunctions.pages[L1ACheckList.k].Height;
      double num60 = ((XUnit) ref xunit).Point / 2.0;
      XRect xrect34 = new XRect(20.0, num59, point38, num60);
      XStringFormat topLeft34 = XStringFormat.TopLeft;
      xgraphics34.DrawString(str13, arialFont10_14, (XBrush) black29, xrect34, topLeft34);
      checked { L1ACheckList.RC1 += 13; }
      XGraphics xgraphics35 = PDFFunctions.gfx[L1ACheckList.k];
      XFont arialFont10_15 = PDFFunctions.ArialFont10;
      XSolidBrush black30 = XBrushes.Black;
      double num61 = (double) checked (L1ACheckList.RC1 + 1);
      xunit = PDFFunctions.pages[L1ACheckList.k].Width;
      double point39 = ((XUnit) ref xunit).Point;
      xunit = PDFFunctions.pages[L1ACheckList.k].Height;
      double num62 = ((XUnit) ref xunit).Point / 2.0;
      XRect xrect35 = new XRect(20.0, num61, point39, num62);
      XStringFormat topLeft35 = XStringFormat.TopLeft;
      xgraphics35.DrawString("Target Carbon Dioxide Emission Rate (TER)", arialFont10_15, (XBrush) black30, xrect35, topLeft35);
      XGraphics xgraphics36 = PDFFunctions.gfx[L1ACheckList.k];
      string str14 = Microsoft.VisualBasic.Strings.Format((object) Functions.TER(), "#.##") + " kg/m\u00B2";
      XFont arialFont10_16 = PDFFunctions.ArialFont10;
      XSolidBrush black31 = XBrushes.Black;
      double num63 = (double) checked (L1ACheckList.RC1 + 1);
      xunit = PDFFunctions.pages[L1ACheckList.k].Width;
      double point40 = ((XUnit) ref xunit).Point;
      xunit = PDFFunctions.pages[L1ACheckList.k].Height;
      double num64 = ((XUnit) ref xunit).Point / 2.0;
      XRect xrect36 = new XRect(370.0, num63, point40, num64);
      XStringFormat topLeft36 = XStringFormat.TopLeft;
      xgraphics36.DrawString(str14, arialFont10_16, (XBrush) black31, xrect36, topLeft36);
      checked { L1ACheckList.RC1 += 13; }
      XGraphics xgraphics37 = PDFFunctions.gfx[L1ACheckList.k];
      XFont arialFont10_17 = PDFFunctions.ArialFont10;
      XSolidBrush black32 = XBrushes.Black;
      double num65 = (double) checked (L1ACheckList.RC1 + 1);
      xunit = PDFFunctions.pages[L1ACheckList.k].Width;
      double point41 = ((XUnit) ref xunit).Point;
      xunit = PDFFunctions.pages[L1ACheckList.k].Height;
      double num66 = ((XUnit) ref xunit).Point / 2.0;
      XRect xrect37 = new XRect(20.0, num65, point41, num66);
      XStringFormat topLeft37 = XStringFormat.TopLeft;
      xgraphics37.DrawString("Dwelling Carbon Dioxide Emission Rate (DER)", arialFont10_17, (XBrush) black32, xrect37, topLeft37);
      L1ACheckList.DERCHeck = SAP_Module.CalcualtionDER2012.Calculation.CO2_Emissions_12a.Box273 != 0.0 ? SAP_Module.CalcualtionDER2012.Calculation.CO2_Emissions_12a.Box273 : SAP_Module.CalcualtionDER2012.Calculation.CO2_Emissions_12b.Box384;
      XGraphics xgraphics38 = PDFFunctions.gfx[L1ACheckList.k];
      string str15 = Microsoft.VisualBasic.Strings.Format((object) Math.Round(L1ACheckList.DERCHeck, 2), "0.00") + " kg/m\u00B2";
      XFont arialFont10_18 = PDFFunctions.ArialFont10;
      XSolidBrush black33 = XBrushes.Black;
      double num67 = (double) checked (L1ACheckList.RC1 + 1);
      xunit = PDFFunctions.pages[L1ACheckList.k].Width;
      double point42 = ((XUnit) ref xunit).Point;
      xunit = PDFFunctions.pages[L1ACheckList.k].Height;
      double num68 = ((XUnit) ref xunit).Point / 2.0;
      XRect xrect38 = new XRect(370.0, num67, point42, num68);
      XStringFormat topLeft38 = XStringFormat.TopLeft;
      xgraphics38.DrawString(str15, arialFont10_18, (XBrush) black33, xrect38, topLeft38);
      L1ACheckList.DERCHeck = Math.Round(L1ACheckList.DERCHeck, 2);
      bool flag2;
      if (L1ACheckList.DERCHeck > Functions.TER())
      {
        float num69 = (float) Math.Round(L1ACheckList.DERCHeck - Functions.TER(), 2);
        float num70 = (float) Math.Round((double) num69 * 100.0 / Functions.TER(), 1);
        if ((double) num70 > 100.0)
          num70 = (float) Math.Round((double) num70, 0);
        XGraphics xgraphics39 = PDFFunctions.gfx[L1ACheckList.k];
        XFont arialFont10Bold13 = PDFFunctions.ArialFont10Bold;
        XSolidBrush red = XBrushes.Red;
        double num71 = (double) checked (L1ACheckList.RC1 + 1);
        xunit = PDFFunctions.pages[L1ACheckList.k].Width;
        double point43 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[L1ACheckList.k].Height;
        double num72 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect39 = new XRect(540.0, num71, point43, num72);
        XStringFormat topLeft39 = XStringFormat.TopLeft;
        xgraphics39.DrawString("Fail", arialFont10Bold13, (XBrush) red, xrect39, topLeft39);
        checked { L1ACheckList.RC1 += 13; }
        XGraphics xgraphics40 = PDFFunctions.gfx[L1ACheckList.k];
        string str16 = "Excess emissions = " + Conversions.ToString(Math.Round((double) num69, 2)) + " kg/m\u00B2 (" + Conversions.ToString(Math.Round((double) num70, 2)) + " %)";
        XFont arialFont10_19 = PDFFunctions.ArialFont10;
        XSolidBrush black34 = XBrushes.Black;
        double num73 = (double) checked (L1ACheckList.RC1 + 1);
        xunit = PDFFunctions.pages[L1ACheckList.k].Width;
        double point44 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[L1ACheckList.k].Height;
        double num74 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect40 = new XRect(20.0, num73, point44, num74);
        XStringFormat topLeft40 = XStringFormat.TopLeft;
        xgraphics40.DrawString(str16, arialFont10_19, (XBrush) black34, xrect40, topLeft40);
        flag2 = true;
      }
      else
      {
        XGraphics xgraphics41 = PDFFunctions.gfx[L1ACheckList.k];
        XFont arialFont10Bold14 = PDFFunctions.ArialFont10Bold;
        XSolidBrush green = XBrushes.Green;
        double num75 = (double) checked (L1ACheckList.RC1 + 1);
        xunit = PDFFunctions.pages[L1ACheckList.k].Width;
        double point45 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[L1ACheckList.k].Height;
        double num76 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect41 = new XRect(540.0, num75, point45, num76);
        XStringFormat topLeft41 = XStringFormat.TopLeft;
        xgraphics41.DrawString("OK", arialFont10Bold14, (XBrush) green, xrect41, topLeft41);
      }
      checked { L1ACheckList.RC1 += 13; }
      // ISSUE: reference to a compiler-generated field
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Address.Country, "England", false) == 0)
      {
        PDFFunctions.xBrush1 = XBrush.op_Implicit((Brush) new SolidBrush(Color.FromArgb(159, 172, 62)));
        PDFFunctions.Points[0].X = 20f;
        PDFFunctions.Points[0].Y = (float) L1ACheckList.RC1;
        ref PointF local9 = ref PDFFunctions.Points[1];
        xunit = PDFFunctions.pages[L1ACheckList.k].Width;
        double num77 = ((XUnit) ref xunit).Point - 20.0;
        local9.X = (float) num77;
        PDFFunctions.Points[1].Y = (float) L1ACheckList.RC1;
        ref PointF local10 = ref PDFFunctions.Points[2];
        xunit = PDFFunctions.pages[L1ACheckList.k].Width;
        double num78 = ((XUnit) ref xunit).Point - 20.0;
        local10.X = (float) num78;
        PDFFunctions.Points[2].Y = (float) checked (L1ACheckList.RC1 + 12);
        PDFFunctions.Points[3].X = 20f;
        PDFFunctions.Points[3].Y = (float) checked (L1ACheckList.RC1 + 12);
        PDFFunctions.gfx[L1ACheckList.k].DrawPolygon(PDFFunctions.polyGreen2, PDFFunctions.xBrush1, PDFFunctions.Points, PDFFunctions.Fill);
        XGraphics xgraphics42 = PDFFunctions.gfx[L1ACheckList.k];
        XFont arialFont10Bold15 = PDFFunctions.ArialFont10Bold;
        XSolidBrush white6 = XBrushes.White;
        double num79 = (double) checked (L1ACheckList.RC1 + 1);
        xunit = PDFFunctions.pages[L1ACheckList.k].Width;
        double point46 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[L1ACheckList.k].Height;
        double num80 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect42 = new XRect(25.0, num79, point46, num80);
        XStringFormat topLeft42 = XStringFormat.TopLeft;
        xgraphics42.DrawString("1b TFEE and DFEE", arialFont10Bold15, (XBrush) white6, xrect42, topLeft42);
        checked { L1ACheckList.RC1 += 14; }
        Calc2012 calc2012 = new Calc2012();
        calc2012.SETPCDF(SAP_Module.PCDFData);
        calc2012.IsFabricEfficiency = true;
        calc2012.Dwelling = Functions.GetFEEDwelling(ref SAP_Module.TERDwelling);
        double num81 = Math.Round(1.15 * calc2012.Calculation.Fabric_Energy_Efficiency.Box109, 2);
        double num82 = Math.Round(SAP_Module.CalculationFabric.Calculation.Fabric_Energy_Efficiency.Box109, 2);
        XGraphics xgraphics43 = PDFFunctions.gfx[L1ACheckList.k];
        XFont arialFont10_20 = PDFFunctions.ArialFont10;
        XSolidBrush black35 = XBrushes.Black;
        double num83 = (double) checked (L1ACheckList.RC1 + 1);
        xunit = PDFFunctions.pages[L1ACheckList.k].Width;
        double point47 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[L1ACheckList.k].Height;
        double num84 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect43 = new XRect(20.0, num83, point47, num84);
        XStringFormat topLeft43 = XStringFormat.TopLeft;
        xgraphics43.DrawString("Target Fabric Energy Efficiency (TFEE)", arialFont10_20, (XBrush) black35, xrect43, topLeft43);
        XGraphics xgraphics44 = PDFFunctions.gfx[L1ACheckList.k];
        string str17 = Microsoft.VisualBasic.Strings.Format((object) Math.Round(num81, 1), "0.0") + " kWh/m\u00B2";
        XFont arialFont10_21 = PDFFunctions.ArialFont10;
        XSolidBrush black36 = XBrushes.Black;
        double num85 = (double) checked (L1ACheckList.RC1 + 1);
        xunit = PDFFunctions.pages[L1ACheckList.k].Width;
        double point48 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[L1ACheckList.k].Height;
        double num86 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect44 = new XRect(370.0, num85, point48, num86);
        XStringFormat topLeft44 = XStringFormat.TopLeft;
        xgraphics44.DrawString(str17, arialFont10_21, (XBrush) black36, xrect44, topLeft44);
        checked { L1ACheckList.RC1 += 13; }
        XGraphics xgraphics45 = PDFFunctions.gfx[L1ACheckList.k];
        XFont arialFont10_22 = PDFFunctions.ArialFont10;
        XSolidBrush black37 = XBrushes.Black;
        double num87 = (double) checked (L1ACheckList.RC1 + 1);
        xunit = PDFFunctions.pages[L1ACheckList.k].Width;
        double point49 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[L1ACheckList.k].Height;
        double num88 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect45 = new XRect(20.0, num87, point49, num88);
        XStringFormat topLeft45 = XStringFormat.TopLeft;
        xgraphics45.DrawString("Dwelling Fabric Energy Efficiency (DFEE)", arialFont10_22, (XBrush) black37, xrect45, topLeft45);
        XGraphics xgraphics46 = PDFFunctions.gfx[L1ACheckList.k];
        string str18 = Microsoft.VisualBasic.Strings.Format((object) Math.Round(num82, 1), "0.0") + " kWh/m\u00B2";
        XFont arialFont10_23 = PDFFunctions.ArialFont10;
        XSolidBrush black38 = XBrushes.Black;
        double num89 = (double) checked (L1ACheckList.RC1 + 1);
        xunit = PDFFunctions.pages[L1ACheckList.k].Width;
        double point50 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[L1ACheckList.k].Height;
        double num90 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect46 = new XRect(370.0, num89, point50, num90);
        XStringFormat topLeft46 = XStringFormat.TopLeft;
        xgraphics46.DrawString(str18, arialFont10_23, (XBrush) black38, xrect46, topLeft46);
        checked { L1ACheckList.RC1 += 13; }
        double num91 = Math.Round(num82, 1);
        if (num91 > Math.Round(num81, 1))
        {
          float Expression2 = (float) Math.Round(num91 - num81, 2);
          float Expression3 = (float) Math.Round((double) Expression2 * 100.0 / num81, 1);
          if ((double) Expression3 > 100.0)
            Expression3 = (float) Math.Round((double) Expression3, 0);
          XGraphics xgraphics47 = PDFFunctions.gfx[L1ACheckList.k];
          XFont arialFont10Bold16 = PDFFunctions.ArialFont10Bold;
          XSolidBrush red = XBrushes.Red;
          double num92 = (double) checked (L1ACheckList.RC1 + 1);
          xunit = PDFFunctions.pages[L1ACheckList.k].Width;
          double point51 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[L1ACheckList.k].Height;
          double num93 = ((XUnit) ref xunit).Point / 2.0;
          XRect xrect47 = new XRect(540.0, num92, point51, num93);
          XStringFormat topLeft47 = XStringFormat.TopLeft;
          xgraphics47.DrawString("Fail", arialFont10Bold16, (XBrush) red, xrect47, topLeft47);
          checked { L1ACheckList.RC1 += 13; }
          XGraphics xgraphics48 = PDFFunctions.gfx[L1ACheckList.k];
          string str19 = "Excess energy  = " + Microsoft.VisualBasic.Strings.Format((object) Expression2, "0.00") + " kg/m\u00B2 (" + Microsoft.VisualBasic.Strings.Format((object) Expression3, "00.0") + " %)";
          XFont arialFont10_24 = PDFFunctions.ArialFont10;
          XSolidBrush black39 = XBrushes.Black;
          double num94 = (double) checked (L1ACheckList.RC1 + 1);
          xunit = PDFFunctions.pages[L1ACheckList.k].Width;
          double point52 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[L1ACheckList.k].Height;
          double num95 = ((XUnit) ref xunit).Point / 2.0;
          XRect xrect48 = new XRect(20.0, num94, point52, num95);
          XStringFormat topLeft48 = XStringFormat.TopLeft;
          xgraphics48.DrawString(str19, arialFont10_24, (XBrush) black39, xrect48, topLeft48);
          flag2 = true;
        }
        else
        {
          XGraphics xgraphics49 = PDFFunctions.gfx[L1ACheckList.k];
          XFont arialFont10Bold17 = PDFFunctions.ArialFont10Bold;
          XSolidBrush green = XBrushes.Green;
          double num96 = (double) checked (L1ACheckList.RC1 + 1);
          xunit = PDFFunctions.pages[L1ACheckList.k].Width;
          double point53 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[L1ACheckList.k].Height;
          double num97 = ((XUnit) ref xunit).Point / 2.0;
          XRect xrect49 = new XRect(540.0, num96, point53, num97);
          XStringFormat topLeft49 = XStringFormat.TopLeft;
          xgraphics49.DrawString("OK", arialFont10Bold17, (XBrush) green, xrect49, topLeft49);
        }
      }
      checked { L1ACheckList.RC1 += 15; }
      PDFFunctions.xBrush1 = XBrush.op_Implicit((Brush) new SolidBrush(Color.FromArgb(159, 172, 62)));
      PDFFunctions.Points[0].X = 20f;
      PDFFunctions.Points[0].Y = (float) L1ACheckList.RC1;
      ref PointF local11 = ref PDFFunctions.Points[1];
      xunit = PDFFunctions.pages[L1ACheckList.k].Width;
      double num98 = ((XUnit) ref xunit).Point - 20.0;
      local11.X = (float) num98;
      PDFFunctions.Points[1].Y = (float) L1ACheckList.RC1;
      ref PointF local12 = ref PDFFunctions.Points[2];
      xunit = PDFFunctions.pages[L1ACheckList.k].Width;
      double num99 = ((XUnit) ref xunit).Point - 20.0;
      local12.X = (float) num99;
      PDFFunctions.Points[2].Y = (float) checked (L1ACheckList.RC1 + 12);
      PDFFunctions.Points[3].X = 20f;
      PDFFunctions.Points[3].Y = (float) checked (L1ACheckList.RC1 + 12);
      PDFFunctions.gfx[L1ACheckList.k].DrawPolygon(PDFFunctions.polyGreen2, PDFFunctions.xBrush1, PDFFunctions.Points, PDFFunctions.Fill);
      XGraphics xgraphics50 = PDFFunctions.gfx[L1ACheckList.k];
      XFont arialFont10Bold18 = PDFFunctions.ArialFont10Bold;
      XSolidBrush white7 = XBrushes.White;
      double num100 = (double) checked (L1ACheckList.RC1 + 1);
      xunit = PDFFunctions.pages[L1ACheckList.k].Width;
      double point54 = ((XUnit) ref xunit).Point;
      xunit = PDFFunctions.pages[L1ACheckList.k].Height;
      double num101 = ((XUnit) ref xunit).Point / 2.0;
      XRect xrect50 = new XRect(25.0, num100, point54, num101);
      XStringFormat topLeft50 = XStringFormat.TopLeft;
      xgraphics50.DrawString("2 Fabric U-values", arialFont10Bold18, (XBrush) white7, xrect50, topLeft50);
      checked { L1ACheckList.RC1 += 15; }
      XGraphics xgraphics51 = PDFFunctions.gfx[L1ACheckList.k];
      XFont arialFont10Bold19 = PDFFunctions.ArialFont10Bold;
      XSolidBrush black40 = XBrushes.Black;
      double num102 = (double) checked (L1ACheckList.RC1 + 1);
      xunit = PDFFunctions.pages[L1ACheckList.k].Width;
      double point55 = ((XUnit) ref xunit).Point;
      xunit = PDFFunctions.pages[L1ACheckList.k].Height;
      double num103 = ((XUnit) ref xunit).Point / 2.0;
      XRect xrect51 = new XRect(60.0, num102, point55, num103);
      XStringFormat topLeft51 = XStringFormat.TopLeft;
      xgraphics51.DrawString("Element", arialFont10Bold19, (XBrush) black40, xrect51, topLeft51);
      XGraphics xgraphics52 = PDFFunctions.gfx[L1ACheckList.k];
      XFont arialFont10Bold20 = PDFFunctions.ArialFont10Bold;
      XSolidBrush black41 = XBrushes.Black;
      double num104 = (double) checked (L1ACheckList.RC1 + 1);
      xunit = PDFFunctions.pages[L1ACheckList.k].Width;
      double point56 = ((XUnit) ref xunit).Point;
      xunit = PDFFunctions.pages[L1ACheckList.k].Height;
      double num105 = ((XUnit) ref xunit).Point / 2.0;
      XRect xrect52 = new XRect(210.0, num104, point56, num105);
      XStringFormat topLeft52 = XStringFormat.TopLeft;
      xgraphics52.DrawString("Average", arialFont10Bold20, (XBrush) black41, xrect52, topLeft52);
      XGraphics xgraphics53 = PDFFunctions.gfx[L1ACheckList.k];
      XFont arialFont10Bold21 = PDFFunctions.ArialFont10Bold;
      XSolidBrush black42 = XBrushes.Black;
      double num106 = (double) checked (L1ACheckList.RC1 + 1);
      xunit = PDFFunctions.pages[L1ACheckList.k].Width;
      double point57 = ((XUnit) ref xunit).Point;
      xunit = PDFFunctions.pages[L1ACheckList.k].Height;
      double num107 = ((XUnit) ref xunit).Point / 2.0;
      XRect xrect53 = new XRect(360.0, num106, point57, num107);
      XStringFormat topLeft53 = XStringFormat.TopLeft;
      xgraphics53.DrawString("Highest", arialFont10Bold21, (XBrush) black42, xrect53, topLeft53);
      checked { L1ACheckList.RC1 += 13; }
      XGraphics xgraphics54 = PDFFunctions.gfx[L1ACheckList.k];
      XFont arialFont10_25 = PDFFunctions.ArialFont10;
      XSolidBrush black43 = XBrushes.Black;
      double num108 = (double) checked (L1ACheckList.RC1 + 1);
      xunit = PDFFunctions.pages[L1ACheckList.k].Width;
      double point58 = ((XUnit) ref xunit).Point;
      xunit = PDFFunctions.pages[L1ACheckList.k].Height;
      double num109 = ((XUnit) ref xunit).Point / 2.0;
      XRect xrect54 = new XRect(60.0, num108, point58, num109);
      XStringFormat topLeft54 = XStringFormat.TopLeft;
      xgraphics54.DrawString("External wall", arialFont10_25, (XBrush) black43, xrect54, topLeft54);
      // ISSUE: reference to a compiler-generated field
      if (SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].NoofWalls > 0)
      {
        float num110;
        float num111 = (float) Math.Round(1.0 / (1.0 / SAP_Module.Calculation2012._Add_Variable.Averages.Wall_U + (double) num110), 2);
        // ISSUE: reference to a compiler-generated field
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Address.Country, "Scotland", false) == 0)
        {
          XGraphics xgraphics55 = PDFFunctions.gfx[L1ACheckList.k];
          string str20 = Microsoft.VisualBasic.Strings.Format((object) SAP_Module.Calculation2012._Add_Variable.Averages.Wall_U, "0.00") + " (max. 0.22)";
          XFont arialFont10_26 = PDFFunctions.ArialFont10;
          XSolidBrush black44 = XBrushes.Black;
          double num112 = (double) checked (L1ACheckList.RC1 + 1);
          xunit = PDFFunctions.pages[L1ACheckList.k].Width;
          double point59 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[L1ACheckList.k].Height;
          double num113 = ((XUnit) ref xunit).Point / 2.0;
          XRect xrect55 = new XRect(210.0, num112, point59, num113);
          XStringFormat topLeft55 = XStringFormat.TopLeft;
          xgraphics55.DrawString(str20, arialFont10_26, (XBrush) black44, xrect55, topLeft55);
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Address.Country, "Wales", false) == 0)
          {
            XGraphics xgraphics56 = PDFFunctions.gfx[L1ACheckList.k];
            string str21 = Microsoft.VisualBasic.Strings.Format((object) SAP_Module.Calculation2012._Add_Variable.Averages.Wall_U, "0.00") + " (max. 0.21)";
            XFont arialFont10_27 = PDFFunctions.ArialFont10;
            XSolidBrush black45 = XBrushes.Black;
            double num114 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point60 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num115 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect56 = new XRect(210.0, num114, point60, num115);
            XStringFormat topLeft56 = XStringFormat.TopLeft;
            xgraphics56.DrawString(str21, arialFont10_27, (XBrush) black45, xrect56, topLeft56);
          }
          else
          {
            XGraphics xgraphics57 = PDFFunctions.gfx[L1ACheckList.k];
            string str22 = Microsoft.VisualBasic.Strings.Format((object) SAP_Module.Calculation2012._Add_Variable.Averages.Wall_U, "0.00") + " (max. 0.30)";
            XFont arialFont10_28 = PDFFunctions.ArialFont10;
            XSolidBrush black46 = XBrushes.Black;
            double num116 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point61 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num117 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect57 = new XRect(210.0, num116, point61, num117);
            XStringFormat topLeft57 = XStringFormat.TopLeft;
            xgraphics57.DrawString(str22, arialFont10_28, (XBrush) black46, xrect57, topLeft57);
          }
        }
        XGraphics xgraphics58 = PDFFunctions.gfx[L1ACheckList.k];
        string str23 = Microsoft.VisualBasic.Strings.Format((object) SAP_Module.Calculation2012._Add_Variable.Highest.Wall_U, "0.00") + " (max. 0.70)";
        XFont arialFont10_29 = PDFFunctions.ArialFont10;
        XSolidBrush black47 = XBrushes.Black;
        double num118 = (double) checked (L1ACheckList.RC1 + 1);
        xunit = PDFFunctions.pages[L1ACheckList.k].Width;
        double point62 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[L1ACheckList.k].Height;
        double num119 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect58 = new XRect(360.0, num118, point62, num119);
        XStringFormat topLeft58 = XStringFormat.TopLeft;
        xgraphics58.DrawString(str23, arialFont10_29, (XBrush) black47, xrect58, topLeft58);
        // ISSUE: reference to a compiler-generated field
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Address.Country, "Scotland", false) == 0)
        {
          if (SAP_Module.Calculation2012._Add_Variable.Averages.Wall_U > 0.2249999999 | SAP_Module.Calculation2012._Add_Variable.Highest.Wall_U > 0.6999)
          {
            XGraphics xgraphics59 = PDFFunctions.gfx[L1ACheckList.k];
            XFont arialFont10Bold22 = PDFFunctions.ArialFont10Bold;
            XSolidBrush red = XBrushes.Red;
            double num120 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point63 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num121 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect59 = new XRect(540.0, num120, point63, num121);
            XStringFormat topLeft59 = XStringFormat.TopLeft;
            xgraphics59.DrawString("Fail", arialFont10Bold22, (XBrush) red, xrect59, topLeft59);
            flag2 = true;
          }
          else
          {
            XGraphics xgraphics60 = PDFFunctions.gfx[L1ACheckList.k];
            XFont arialFont10Bold23 = PDFFunctions.ArialFont10Bold;
            XSolidBrush green = XBrushes.Green;
            double num122 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point64 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num123 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect60 = new XRect(540.0, num122, point64, num123);
            XStringFormat topLeft60 = XStringFormat.TopLeft;
            xgraphics60.DrawString("OK", arialFont10Bold23, (XBrush) green, xrect60, topLeft60);
          }
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Address.Country, "Wales", false) == 0)
          {
            double wallU = SAP_Module.Calculation2012._Add_Variable.Averages.Wall_U;
            if (SAP_Module.Calculation2012._Add_Variable.Averages.Wall_U > 0.21499999 | SAP_Module.Calculation2012._Add_Variable.Highest.Wall_U > 0.6999)
            {
              XGraphics xgraphics61 = PDFFunctions.gfx[L1ACheckList.k];
              XFont arialFont10Bold24 = PDFFunctions.ArialFont10Bold;
              XSolidBrush red = XBrushes.Red;
              double num124 = (double) checked (L1ACheckList.RC1 + 1);
              xunit = PDFFunctions.pages[L1ACheckList.k].Width;
              double point65 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[L1ACheckList.k].Height;
              double num125 = ((XUnit) ref xunit).Point / 2.0;
              XRect xrect61 = new XRect(540.0, num124, point65, num125);
              XStringFormat topLeft61 = XStringFormat.TopLeft;
              xgraphics61.DrawString("Fail", arialFont10Bold24, (XBrush) red, xrect61, topLeft61);
              flag2 = true;
            }
            else
            {
              XGraphics xgraphics62 = PDFFunctions.gfx[L1ACheckList.k];
              XFont arialFont10Bold25 = PDFFunctions.ArialFont10Bold;
              XSolidBrush green = XBrushes.Green;
              double num126 = (double) checked (L1ACheckList.RC1 + 1);
              xunit = PDFFunctions.pages[L1ACheckList.k].Width;
              double point66 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[L1ACheckList.k].Height;
              double num127 = ((XUnit) ref xunit).Point / 2.0;
              XRect xrect62 = new XRect(540.0, num126, point66, num127);
              XStringFormat topLeft62 = XStringFormat.TopLeft;
              xgraphics62.DrawString("OK", arialFont10Bold25, (XBrush) green, xrect62, topLeft62);
            }
          }
          else
          {
            double wallU = SAP_Module.Calculation2012._Add_Variable.Averages.Wall_U;
            if (SAP_Module.Calculation2012._Add_Variable.Averages.Wall_U > 0.3049999999 | SAP_Module.Calculation2012._Add_Variable.Highest.Wall_U > 0.6999)
            {
              XGraphics xgraphics63 = PDFFunctions.gfx[L1ACheckList.k];
              XFont arialFont10Bold26 = PDFFunctions.ArialFont10Bold;
              XSolidBrush red = XBrushes.Red;
              double num128 = (double) checked (L1ACheckList.RC1 + 1);
              xunit = PDFFunctions.pages[L1ACheckList.k].Width;
              double point67 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[L1ACheckList.k].Height;
              double num129 = ((XUnit) ref xunit).Point / 2.0;
              XRect xrect63 = new XRect(540.0, num128, point67, num129);
              XStringFormat topLeft63 = XStringFormat.TopLeft;
              xgraphics63.DrawString("Fail", arialFont10Bold26, (XBrush) red, xrect63, topLeft63);
              flag2 = true;
            }
            else
            {
              XGraphics xgraphics64 = PDFFunctions.gfx[L1ACheckList.k];
              XFont arialFont10Bold27 = PDFFunctions.ArialFont10Bold;
              XSolidBrush green = XBrushes.Green;
              double num130 = (double) checked (L1ACheckList.RC1 + 1);
              xunit = PDFFunctions.pages[L1ACheckList.k].Width;
              double point68 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[L1ACheckList.k].Height;
              double num131 = ((XUnit) ref xunit).Point / 2.0;
              XRect xrect64 = new XRect(540.0, num130, point68, num131);
              XStringFormat topLeft64 = XStringFormat.TopLeft;
              xgraphics64.DrawString("OK", arialFont10Bold27, (XBrush) green, xrect64, topLeft64);
            }
          }
        }
        checked { L1ACheckList.RC1 += 13; }
      }
      // ISSUE: reference to a compiler-generated field
      if (SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].NoofPWalls > 0)
      {
        XGraphics xgraphics65 = PDFFunctions.gfx[L1ACheckList.k];
        XFont arialFont10_30 = PDFFunctions.ArialFont10;
        XSolidBrush black48 = XBrushes.Black;
        double num132 = (double) checked (L1ACheckList.RC1 + 1);
        xunit = PDFFunctions.pages[L1ACheckList.k].Width;
        double point69 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[L1ACheckList.k].Height;
        double num133 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect65 = new XRect(60.0, num132, point69, num133);
        XStringFormat topLeft65 = XStringFormat.TopLeft;
        xgraphics65.DrawString("Party wall", arialFont10_30, (XBrush) black48, xrect65, topLeft65);
        XGraphics xgraphics66 = PDFFunctions.gfx[L1ACheckList.k];
        string str24 = Microsoft.VisualBasic.Strings.Format((object) SAP_Module.Calculation2012._Add_Variable.Averages.Party_U, "0.00") + " (max. 0.20)";
        XFont arialFont10_31 = PDFFunctions.ArialFont10;
        XSolidBrush black49 = XBrushes.Black;
        double num134 = (double) checked (L1ACheckList.RC1 + 1);
        xunit = PDFFunctions.pages[L1ACheckList.k].Width;
        double point70 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[L1ACheckList.k].Height;
        double num135 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect66 = new XRect(210.0, num134, point70, num135);
        XStringFormat topLeft66 = XStringFormat.TopLeft;
        xgraphics66.DrawString(str24, arialFont10_31, (XBrush) black49, xrect66, topLeft66);
        XGraphics xgraphics67 = PDFFunctions.gfx[L1ACheckList.k];
        XFont arialFont10_32 = PDFFunctions.ArialFont10;
        XSolidBrush black50 = XBrushes.Black;
        double num136 = (double) checked (L1ACheckList.RC1 + 1);
        xunit = PDFFunctions.pages[L1ACheckList.k].Width;
        double point71 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[L1ACheckList.k].Height;
        double num137 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect67 = new XRect(360.0, num136, point71, num137);
        XStringFormat topLeft67 = XStringFormat.TopLeft;
        xgraphics67.DrawString("-", arialFont10_32, (XBrush) black50, xrect67, topLeft67);
        double partyU = SAP_Module.Calculation2012._Add_Variable.Averages.Party_U;
        if (SAP_Module.Calculation2012._Add_Variable.Averages.Party_U > 0.20001)
        {
          XGraphics xgraphics68 = PDFFunctions.gfx[L1ACheckList.k];
          XFont arialFont10Bold28 = PDFFunctions.ArialFont10Bold;
          XSolidBrush red = XBrushes.Red;
          double num138 = (double) checked (L1ACheckList.RC1 + 1);
          xunit = PDFFunctions.pages[L1ACheckList.k].Width;
          double point72 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[L1ACheckList.k].Height;
          double num139 = ((XUnit) ref xunit).Point / 2.0;
          XRect xrect68 = new XRect(540.0, num138, point72, num139);
          XStringFormat topLeft68 = XStringFormat.TopLeft;
          xgraphics68.DrawString("Fail", arialFont10Bold28, (XBrush) red, xrect68, topLeft68);
          flag2 = true;
        }
        else
        {
          XGraphics xgraphics69 = PDFFunctions.gfx[L1ACheckList.k];
          XFont arialFont10Bold29 = PDFFunctions.ArialFont10Bold;
          XSolidBrush green = XBrushes.Green;
          double num140 = (double) checked (L1ACheckList.RC1 + 1);
          xunit = PDFFunctions.pages[L1ACheckList.k].Width;
          double point73 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[L1ACheckList.k].Height;
          double num141 = ((XUnit) ref xunit).Point / 2.0;
          XRect xrect69 = new XRect(540.0, num140, point73, num141);
          XStringFormat topLeft69 = XStringFormat.TopLeft;
          xgraphics69.DrawString("OK", arialFont10Bold29, (XBrush) green, xrect69, topLeft69);
        }
        checked { L1ACheckList.RC1 += 13; }
      }
      XGraphics xgraphics70 = PDFFunctions.gfx[L1ACheckList.k];
      XFont arialFont10_33 = PDFFunctions.ArialFont10;
      XSolidBrush black51 = XBrushes.Black;
      double num142 = (double) checked (L1ACheckList.RC1 + 1);
      xunit = PDFFunctions.pages[L1ACheckList.k].Width;
      double point74 = ((XUnit) ref xunit).Point;
      xunit = PDFFunctions.pages[L1ACheckList.k].Height;
      double num143 = ((XUnit) ref xunit).Point / 2.0;
      XRect xrect70 = new XRect(60.0, num142, point74, num143);
      XStringFormat topLeft70 = XStringFormat.TopLeft;
      xgraphics70.DrawString("Floor", arialFont10_33, (XBrush) black51, xrect70, topLeft70);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Calculation2012._Add_Variable.Averages.Floor_U.ToString(), "NaN", false) == 0)
      {
        XGraphics xgraphics71 = PDFFunctions.gfx[L1ACheckList.k];
        XFont arialFont10_34 = PDFFunctions.ArialFont10;
        XSolidBrush black52 = XBrushes.Black;
        double num144 = (double) checked (L1ACheckList.RC1 + 1);
        xunit = PDFFunctions.pages[L1ACheckList.k].Width;
        double point75 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[L1ACheckList.k].Height;
        double num145 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect71 = new XRect(210.0, num144, point75, num145);
        XStringFormat topLeft71 = XStringFormat.TopLeft;
        xgraphics71.DrawString("(no floor)", arialFont10_34, (XBrush) black52, xrect71, topLeft71);
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        if (SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].NoofFloors == 0)
        {
          XGraphics xgraphics72 = PDFFunctions.gfx[L1ACheckList.k];
          XFont arialFont10_35 = PDFFunctions.ArialFont10;
          XSolidBrush black53 = XBrushes.Black;
          double num146 = (double) checked (L1ACheckList.RC1 + 1);
          xunit = PDFFunctions.pages[L1ACheckList.k].Width;
          double point76 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[L1ACheckList.k].Height;
          double num147 = ((XUnit) ref xunit).Point / 2.0;
          XRect xrect72 = new XRect(210.0, num146, point76, num147);
          XStringFormat topLeft72 = XStringFormat.TopLeft;
          xgraphics72.DrawString("(no floor)", arialFont10_35, (XBrush) black53, xrect72, topLeft72);
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Address.Country, "Wales", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Address.Country, "Scotland", false) == 0)
          {
            XGraphics xgraphics73 = PDFFunctions.gfx[L1ACheckList.k];
            string str25 = Microsoft.VisualBasic.Strings.Format((object) SAP_Module.Calculation2012._Add_Variable.Averages.Floor_U, "0.00") + " (max. 0.18)";
            XFont arialFont10_36 = PDFFunctions.ArialFont10;
            XSolidBrush black54 = XBrushes.Black;
            double num148 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point77 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num149 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect73 = new XRect(210.0, num148, point77, num149);
            XStringFormat topLeft73 = XStringFormat.TopLeft;
            xgraphics73.DrawString(str25, arialFont10_36, (XBrush) black54, xrect73, topLeft73);
            XGraphics xgraphics74 = PDFFunctions.gfx[L1ACheckList.k];
            string str26 = Microsoft.VisualBasic.Strings.Format((object) SAP_Module.Calculation2012._Add_Variable.Highest.Floor_U, "0.00") + " (max. 0.70)";
            XFont arialFont10_37 = PDFFunctions.ArialFont10;
            XSolidBrush black55 = XBrushes.Black;
            double num150 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point78 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num151 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect74 = new XRect(360.0, num150, point78, num151);
            XStringFormat topLeft74 = XStringFormat.TopLeft;
            xgraphics74.DrawString(str26, arialFont10_37, (XBrush) black55, xrect74, topLeft74);
            if (SAP_Module.Calculation2012._Add_Variable.Averages.Floor_U > 0.1849999999 | SAP_Module.Calculation2012._Add_Variable.Highest.Floor_U > 0.7049)
            {
              XGraphics xgraphics75 = PDFFunctions.gfx[L1ACheckList.k];
              XFont arialFont10Bold30 = PDFFunctions.ArialFont10Bold;
              XSolidBrush red = XBrushes.Red;
              double num152 = (double) checked (L1ACheckList.RC1 + 1);
              xunit = PDFFunctions.pages[L1ACheckList.k].Width;
              double point79 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[L1ACheckList.k].Height;
              double num153 = ((XUnit) ref xunit).Point / 2.0;
              XRect xrect75 = new XRect(540.0, num152, point79, num153);
              XStringFormat topLeft75 = XStringFormat.TopLeft;
              xgraphics75.DrawString("Fail", arialFont10Bold30, (XBrush) red, xrect75, topLeft75);
              flag2 = true;
            }
            else
            {
              XGraphics xgraphics76 = PDFFunctions.gfx[L1ACheckList.k];
              XFont arialFont10Bold31 = PDFFunctions.ArialFont10Bold;
              XSolidBrush green = XBrushes.Green;
              double num154 = (double) checked (L1ACheckList.RC1 + 1);
              xunit = PDFFunctions.pages[L1ACheckList.k].Width;
              double point80 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[L1ACheckList.k].Height;
              double num155 = ((XUnit) ref xunit).Point / 2.0;
              XRect xrect76 = new XRect(540.0, num154, point80, num155);
              XStringFormat topLeft76 = XStringFormat.TopLeft;
              xgraphics76.DrawString("OK", arialFont10Bold31, (XBrush) green, xrect76, topLeft76);
            }
          }
          else
          {
            if (SAP_Module.Calculation2012._Add_Variable.Averages.Floor_U > 0.254999999 | SAP_Module.Calculation2012._Add_Variable.Highest.Floor_U > 0.7049)
            {
              XGraphics xgraphics77 = PDFFunctions.gfx[L1ACheckList.k];
              XFont arialFont10Bold32 = PDFFunctions.ArialFont10Bold;
              XSolidBrush red = XBrushes.Red;
              double num156 = (double) checked (L1ACheckList.RC1 + 1);
              xunit = PDFFunctions.pages[L1ACheckList.k].Width;
              double point81 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[L1ACheckList.k].Height;
              double num157 = ((XUnit) ref xunit).Point / 2.0;
              XRect xrect77 = new XRect(540.0, num156, point81, num157);
              XStringFormat topLeft77 = XStringFormat.TopLeft;
              xgraphics77.DrawString("Fail", arialFont10Bold32, (XBrush) red, xrect77, topLeft77);
              flag2 = true;
            }
            else
            {
              XGraphics xgraphics78 = PDFFunctions.gfx[L1ACheckList.k];
              XFont arialFont10Bold33 = PDFFunctions.ArialFont10Bold;
              XSolidBrush green = XBrushes.Green;
              double num158 = (double) checked (L1ACheckList.RC1 + 1);
              xunit = PDFFunctions.pages[L1ACheckList.k].Width;
              double point82 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[L1ACheckList.k].Height;
              double num159 = ((XUnit) ref xunit).Point / 2.0;
              XRect xrect78 = new XRect(540.0, num158, point82, num159);
              XStringFormat topLeft78 = XStringFormat.TopLeft;
              xgraphics78.DrawString("OK", arialFont10Bold33, (XBrush) green, xrect78, topLeft78);
            }
            XGraphics xgraphics79 = PDFFunctions.gfx[L1ACheckList.k];
            string str27 = Microsoft.VisualBasic.Strings.Format((object) SAP_Module.Calculation2012._Add_Variable.Averages.Floor_U, "0.00") + " (max. 0.25)";
            XFont arialFont10_38 = PDFFunctions.ArialFont10;
            XSolidBrush black56 = XBrushes.Black;
            double num160 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point83 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num161 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect79 = new XRect(210.0, num160, point83, num161);
            XStringFormat topLeft79 = XStringFormat.TopLeft;
            xgraphics79.DrawString(str27, arialFont10_38, (XBrush) black56, xrect79, topLeft79);
          }
          XGraphics xgraphics80 = PDFFunctions.gfx[L1ACheckList.k];
          string str28 = Microsoft.VisualBasic.Strings.Format((object) SAP_Module.Calculation2012._Add_Variable.Highest.Floor_U, "0.00") + " (max. 0.70)";
          XFont arialFont10_39 = PDFFunctions.ArialFont10;
          XSolidBrush black57 = XBrushes.Black;
          double num162 = (double) checked (L1ACheckList.RC1 + 1);
          xunit = PDFFunctions.pages[L1ACheckList.k].Width;
          double point84 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[L1ACheckList.k].Height;
          double num163 = ((XUnit) ref xunit).Point / 2.0;
          XRect xrect80 = new XRect(360.0, num162, point84, num163);
          XStringFormat topLeft80 = XStringFormat.TopLeft;
          xgraphics80.DrawString(str28, arialFont10_39, (XBrush) black57, xrect80, topLeft80);
        }
      }
      checked { L1ACheckList.RC1 += 13; }
      XGraphics xgraphics81 = PDFFunctions.gfx[L1ACheckList.k];
      XFont arialFont10_40 = PDFFunctions.ArialFont10;
      XSolidBrush black58 = XBrushes.Black;
      double num164 = (double) checked (L1ACheckList.RC1 + 1);
      xunit = PDFFunctions.pages[L1ACheckList.k].Width;
      double point85 = ((XUnit) ref xunit).Point;
      xunit = PDFFunctions.pages[L1ACheckList.k].Height;
      double num165 = ((XUnit) ref xunit).Point / 2.0;
      XRect xrect81 = new XRect(60.0, num164, point85, num165);
      XStringFormat topLeft81 = XStringFormat.TopLeft;
      xgraphics81.DrawString("Roof", arialFont10_40, (XBrush) black58, xrect81, topLeft81);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Calculation2012._Add_Variable.Averages.Roof_U.ToString(), "NaN", false) == 0)
      {
        XGraphics xgraphics82 = PDFFunctions.gfx[L1ACheckList.k];
        XFont arialFont10_41 = PDFFunctions.ArialFont10;
        XSolidBrush black59 = XBrushes.Black;
        double num166 = (double) checked (L1ACheckList.RC1 + 1);
        xunit = PDFFunctions.pages[L1ACheckList.k].Width;
        double point86 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[L1ACheckList.k].Height;
        double num167 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect82 = new XRect(210.0, num166, point86, num167);
        XStringFormat topLeft82 = XStringFormat.TopLeft;
        xgraphics82.DrawString("(no roof)", arialFont10_41, (XBrush) black59, xrect82, topLeft82);
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        if (SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].NoofRoofs == 0)
        {
          XGraphics xgraphics83 = PDFFunctions.gfx[L1ACheckList.k];
          XFont arialFont10_42 = PDFFunctions.ArialFont10;
          XSolidBrush black60 = XBrushes.Black;
          double num168 = (double) checked (L1ACheckList.RC1 + 1);
          xunit = PDFFunctions.pages[L1ACheckList.k].Width;
          double point87 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[L1ACheckList.k].Height;
          double num169 = ((XUnit) ref xunit).Point / 2.0;
          XRect xrect83 = new XRect(210.0, num168, point87, num169);
          XStringFormat topLeft83 = XStringFormat.TopLeft;
          xgraphics83.DrawString("(no roof)", arialFont10_42, (XBrush) black60, xrect83, topLeft83);
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Address.Country, "Wales", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Address.Country, "Scotland", false) == 0)
          {
            XGraphics xgraphics84 = PDFFunctions.gfx[L1ACheckList.k];
            string str29 = Microsoft.VisualBasic.Strings.Format((object) SAP_Module.Calculation2012._Add_Variable.Averages.Roof_U, "0.00") + " (max. 0.15)";
            XFont arialFont10_43 = PDFFunctions.ArialFont10;
            XSolidBrush black61 = XBrushes.Black;
            double num170 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point88 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num171 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect84 = new XRect(210.0, num170, point88, num171);
            XStringFormat topLeft84 = XStringFormat.TopLeft;
            xgraphics84.DrawString(str29, arialFont10_43, (XBrush) black61, xrect84, topLeft84);
            XGraphics xgraphics85 = PDFFunctions.gfx[L1ACheckList.k];
            string str30 = Microsoft.VisualBasic.Strings.Format((object) SAP_Module.Calculation2012._Add_Variable.Highest.Roof_U, "0.00") + " (max. 0.35)";
            XFont arialFont10_44 = PDFFunctions.ArialFont10;
            XSolidBrush black62 = XBrushes.Black;
            double num172 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point89 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num173 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect85 = new XRect(360.0, num172, point89, num173);
            XStringFormat topLeft85 = XStringFormat.TopLeft;
            xgraphics85.DrawString(str30, arialFont10_44, (XBrush) black62, xrect85, topLeft85);
            if (SAP_Module.Calculation2012._Add_Variable.Averages.Roof_U > 0.154999999 | SAP_Module.Calculation2012._Add_Variable.Highest.Roof_U > 0.351)
            {
              XGraphics xgraphics86 = PDFFunctions.gfx[L1ACheckList.k];
              XFont arialFont10Bold34 = PDFFunctions.ArialFont10Bold;
              XSolidBrush red = XBrushes.Red;
              double num174 = (double) checked (L1ACheckList.RC1 + 1);
              xunit = PDFFunctions.pages[L1ACheckList.k].Width;
              double point90 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[L1ACheckList.k].Height;
              double num175 = ((XUnit) ref xunit).Point / 2.0;
              XRect xrect86 = new XRect(540.0, num174, point90, num175);
              XStringFormat topLeft86 = XStringFormat.TopLeft;
              xgraphics86.DrawString("Fail", arialFont10Bold34, (XBrush) red, xrect86, topLeft86);
              flag2 = true;
            }
            else
            {
              XGraphics xgraphics87 = PDFFunctions.gfx[L1ACheckList.k];
              XFont arialFont10Bold35 = PDFFunctions.ArialFont10Bold;
              XSolidBrush green = XBrushes.Green;
              double num176 = (double) checked (L1ACheckList.RC1 + 1);
              xunit = PDFFunctions.pages[L1ACheckList.k].Width;
              double point91 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[L1ACheckList.k].Height;
              double num177 = ((XUnit) ref xunit).Point / 2.0;
              XRect xrect87 = new XRect(540.0, num176, point91, num177);
              XStringFormat topLeft87 = XStringFormat.TopLeft;
              xgraphics87.DrawString("OK", arialFont10Bold35, (XBrush) green, xrect87, topLeft87);
            }
          }
          else
          {
            XGraphics xgraphics88 = PDFFunctions.gfx[L1ACheckList.k];
            string str31 = Microsoft.VisualBasic.Strings.Format((object) SAP_Module.Calculation2012._Add_Variable.Averages.Roof_U, "0.00") + " (max. 0.20)";
            XFont arialFont10_45 = PDFFunctions.ArialFont10;
            XSolidBrush black63 = XBrushes.Black;
            double num178 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point92 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num179 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect88 = new XRect(210.0, num178, point92, num179);
            XStringFormat topLeft88 = XStringFormat.TopLeft;
            xgraphics88.DrawString(str31, arialFont10_45, (XBrush) black63, xrect88, topLeft88);
            XGraphics xgraphics89 = PDFFunctions.gfx[L1ACheckList.k];
            string str32 = Microsoft.VisualBasic.Strings.Format((object) SAP_Module.Calculation2012._Add_Variable.Highest.Roof_U, "0.00") + " (max. 0.35)";
            XFont arialFont10_46 = PDFFunctions.ArialFont10;
            XSolidBrush black64 = XBrushes.Black;
            double num180 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point93 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num181 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect89 = new XRect(360.0, num180, point93, num181);
            XStringFormat topLeft89 = XStringFormat.TopLeft;
            xgraphics89.DrawString(str32, arialFont10_46, (XBrush) black64, xrect89, topLeft89);
            if (SAP_Module.Calculation2012._Add_Variable.Averages.Roof_U > 0.2049 | SAP_Module.Calculation2012._Add_Variable.Highest.Roof_U > 0.351)
            {
              XGraphics xgraphics90 = PDFFunctions.gfx[L1ACheckList.k];
              XFont arialFont10Bold36 = PDFFunctions.ArialFont10Bold;
              XSolidBrush red = XBrushes.Red;
              double num182 = (double) checked (L1ACheckList.RC1 + 1);
              xunit = PDFFunctions.pages[L1ACheckList.k].Width;
              double point94 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[L1ACheckList.k].Height;
              double num183 = ((XUnit) ref xunit).Point / 2.0;
              XRect xrect90 = new XRect(540.0, num182, point94, num183);
              XStringFormat topLeft90 = XStringFormat.TopLeft;
              xgraphics90.DrawString("Fail", arialFont10Bold36, (XBrush) red, xrect90, topLeft90);
              flag2 = true;
            }
            else
            {
              XGraphics xgraphics91 = PDFFunctions.gfx[L1ACheckList.k];
              XFont arialFont10Bold37 = PDFFunctions.ArialFont10Bold;
              XSolidBrush green = XBrushes.Green;
              double num184 = (double) checked (L1ACheckList.RC1 + 1);
              xunit = PDFFunctions.pages[L1ACheckList.k].Width;
              double point95 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[L1ACheckList.k].Height;
              double num185 = ((XUnit) ref xunit).Point / 2.0;
              XRect xrect91 = new XRect(540.0, num184, point95, num185);
              XStringFormat topLeft91 = XStringFormat.TopLeft;
              xgraphics91.DrawString("OK", arialFont10Bold37, (XBrush) green, xrect91, topLeft91);
            }
          }
        }
      }
      checked { L1ACheckList.RC1 += 13; }
      // ISSUE: reference to a compiler-generated field
      if (SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].NoofWalls > 0)
      {
        // ISSUE: reference to a compiler-generated field
        int num186 = checked (SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].NoofWalls - 1);
        int index = 0;
        while (index <= num186)
        {
          // ISSUE: reference to a compiler-generated field
          if (SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Walls[index].Curtain)
            ;
          checked { ++index; }
        }
      }
      if (SAP_Module.Calculation2012._Add_Variable.Averages.CWall_U == 0.0)
      {
        XGraphics xgraphics92 = PDFFunctions.gfx[L1ACheckList.k];
        XFont arialFont10_47 = PDFFunctions.ArialFont10;
        XSolidBrush black65 = XBrushes.Black;
        double num187 = (double) checked (L1ACheckList.RC1 + 1);
        xunit = PDFFunctions.pages[L1ACheckList.k].Width;
        double point96 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[L1ACheckList.k].Height;
        double num188 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect92 = new XRect(60.0, num187, point96, num188);
        XStringFormat topLeft92 = XStringFormat.TopLeft;
        xgraphics92.DrawString("Openings", arialFont10_47, (XBrush) black65, xrect92, topLeft92);
      }
      else
      {
        XGraphics xgraphics93 = PDFFunctions.gfx[L1ACheckList.k];
        XFont arialFont10_48 = PDFFunctions.ArialFont10;
        XSolidBrush black66 = XBrushes.Black;
        double num189 = (double) checked (L1ACheckList.RC1 + 1);
        xunit = PDFFunctions.pages[L1ACheckList.k].Width;
        double point97 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[L1ACheckList.k].Height;
        double num190 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect93 = new XRect(60.0, num189, point97, num190);
        XStringFormat topLeft93 = XStringFormat.TopLeft;
        xgraphics93.DrawString("Openings and", arialFont10_48, (XBrush) black66, xrect93, topLeft93);
        checked { L1ACheckList.RC1 += 15; }
        XGraphics xgraphics94 = PDFFunctions.gfx[L1ACheckList.k];
        XFont arialFont10_49 = PDFFunctions.ArialFont10;
        XSolidBrush black67 = XBrushes.Black;
        double num191 = (double) checked (L1ACheckList.RC1 + 1);
        xunit = PDFFunctions.pages[L1ACheckList.k].Width;
        double point98 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[L1ACheckList.k].Height;
        double num192 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect94 = new XRect(60.0, num191, point98, num192);
        XStringFormat topLeft94 = XStringFormat.TopLeft;
        xgraphics94.DrawString("curtain wall(s)", arialFont10_49, (XBrush) black67, xrect94, topLeft94);
      }
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Address.Country, "Wales", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Address.Country, "Scotland", false) == 0)
      {
        XGraphics xgraphics95 = PDFFunctions.gfx[L1ACheckList.k];
        string str33 = Microsoft.VisualBasic.Strings.Format((object) SAP_Module.Calculation2012._Add_Variable.Averages.Window_U, "0.00") + " (max. 1.60)";
        XFont arialFont10_50 = PDFFunctions.ArialFont10;
        XSolidBrush black68 = XBrushes.Black;
        double num193 = (double) checked (L1ACheckList.RC1 + 1);
        xunit = PDFFunctions.pages[L1ACheckList.k].Width;
        double point99 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[L1ACheckList.k].Height;
        double num194 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect95 = new XRect(210.0, num193, point99, num194);
        XStringFormat topLeft95 = XStringFormat.TopLeft;
        xgraphics95.DrawString(str33, arialFont10_50, (XBrush) black68, xrect95, topLeft95);
        XGraphics xgraphics96 = PDFFunctions.gfx[L1ACheckList.k];
        string str34 = Microsoft.VisualBasic.Strings.Format((object) SAP_Module.Calculation2012._Add_Variable.Highest.Window_U, "0.00") + " (max. 3.30)";
        XFont arialFont10_51 = PDFFunctions.ArialFont10;
        XSolidBrush black69 = XBrushes.Black;
        double num195 = (double) checked (L1ACheckList.RC1 + 1);
        xunit = PDFFunctions.pages[L1ACheckList.k].Width;
        double point100 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[L1ACheckList.k].Height;
        double num196 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect96 = new XRect(360.0, num195, point100, num196);
        XStringFormat topLeft96 = XStringFormat.TopLeft;
        xgraphics96.DrawString(str34, arialFont10_51, (XBrush) black69, xrect96, topLeft96);
        if (SAP_Module.Calculation2012._Add_Variable.Averages.Window_U > 1.604999999 | SAP_Module.Calculation2012._Add_Variable.Highest.Window_U > 3.31)
        {
          XGraphics xgraphics97 = PDFFunctions.gfx[L1ACheckList.k];
          XFont arialFont10Bold38 = PDFFunctions.ArialFont10Bold;
          XSolidBrush red = XBrushes.Red;
          double num197 = (double) checked (L1ACheckList.RC1 + 1);
          xunit = PDFFunctions.pages[L1ACheckList.k].Width;
          double point101 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[L1ACheckList.k].Height;
          double num198 = ((XUnit) ref xunit).Point / 2.0;
          XRect xrect97 = new XRect(540.0, num197, point101, num198);
          XStringFormat topLeft97 = XStringFormat.TopLeft;
          xgraphics97.DrawString("Fail", arialFont10Bold38, (XBrush) red, xrect97, topLeft97);
          flag2 = true;
        }
        else
        {
          XGraphics xgraphics98 = PDFFunctions.gfx[L1ACheckList.k];
          XFont arialFont10Bold39 = PDFFunctions.ArialFont10Bold;
          XSolidBrush green = XBrushes.Green;
          double num199 = (double) checked (L1ACheckList.RC1 + 1);
          xunit = PDFFunctions.pages[L1ACheckList.k].Width;
          double point102 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[L1ACheckList.k].Height;
          double num200 = ((XUnit) ref xunit).Point / 2.0;
          XRect xrect98 = new XRect(540.0, num199, point102, num200);
          XStringFormat topLeft98 = XStringFormat.TopLeft;
          xgraphics98.DrawString("OK", arialFont10Bold39, (XBrush) green, xrect98, topLeft98);
        }
      }
      else
      {
        XGraphics xgraphics99 = PDFFunctions.gfx[L1ACheckList.k];
        string str35 = Microsoft.VisualBasic.Strings.Format((object) SAP_Module.Calculation2012._Add_Variable.Averages.Window_U, "0.00") + " (max. 2.00)";
        XFont arialFont10_52 = PDFFunctions.ArialFont10;
        XSolidBrush black70 = XBrushes.Black;
        double num201 = (double) checked (L1ACheckList.RC1 + 1);
        xunit = PDFFunctions.pages[L1ACheckList.k].Width;
        double point103 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[L1ACheckList.k].Height;
        double num202 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect99 = new XRect(210.0, num201, point103, num202);
        XStringFormat topLeft99 = XStringFormat.TopLeft;
        xgraphics99.DrawString(str35, arialFont10_52, (XBrush) black70, xrect99, topLeft99);
        XGraphics xgraphics100 = PDFFunctions.gfx[L1ACheckList.k];
        string str36 = Microsoft.VisualBasic.Strings.Format((object) SAP_Module.Calculation2012._Add_Variable.Highest.Window_U, "0.00") + " (max. 3.30)";
        XFont arialFont10_53 = PDFFunctions.ArialFont10;
        XSolidBrush black71 = XBrushes.Black;
        double num203 = (double) checked (L1ACheckList.RC1 + 1);
        xunit = PDFFunctions.pages[L1ACheckList.k].Width;
        double point104 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[L1ACheckList.k].Height;
        double num204 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect100 = new XRect(360.0, num203, point104, num204);
        XStringFormat topLeft100 = XStringFormat.TopLeft;
        xgraphics100.DrawString(str36, arialFont10_53, (XBrush) black71, xrect100, topLeft100);
        if (SAP_Module.Calculation2012._Add_Variable.Averages.Window_U > 2.00499999 | SAP_Module.Calculation2012._Add_Variable.Highest.Window_U > 3.3)
        {
          XGraphics xgraphics101 = PDFFunctions.gfx[L1ACheckList.k];
          XFont arialFont10Bold40 = PDFFunctions.ArialFont10Bold;
          XSolidBrush red = XBrushes.Red;
          double num205 = (double) checked (L1ACheckList.RC1 + 1);
          xunit = PDFFunctions.pages[L1ACheckList.k].Width;
          double point105 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[L1ACheckList.k].Height;
          double num206 = ((XUnit) ref xunit).Point / 2.0;
          XRect xrect101 = new XRect(540.0, num205, point105, num206);
          XStringFormat topLeft101 = XStringFormat.TopLeft;
          xgraphics101.DrawString("Fail", arialFont10Bold40, (XBrush) red, xrect101, topLeft101);
          flag2 = true;
        }
        else
        {
          XGraphics xgraphics102 = PDFFunctions.gfx[L1ACheckList.k];
          XFont arialFont10Bold41 = PDFFunctions.ArialFont10Bold;
          XSolidBrush green = XBrushes.Green;
          double num207 = (double) checked (L1ACheckList.RC1 + 1);
          xunit = PDFFunctions.pages[L1ACheckList.k].Width;
          double point106 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[L1ACheckList.k].Height;
          double num208 = ((XUnit) ref xunit).Point / 2.0;
          XRect xrect102 = new XRect(540.0, num207, point106, num208);
          XStringFormat topLeft102 = XStringFormat.TopLeft;
          xgraphics102.DrawString("OK", arialFont10Bold41, (XBrush) green, xrect102, topLeft102);
        }
      }
      checked { L1ACheckList.RC1 += 15; }
      PDFFunctions.xBrush1 = XBrush.op_Implicit((Brush) new SolidBrush(Color.FromArgb(159, 172, 62)));
      PDFFunctions.Points[0].X = 20f;
      PDFFunctions.Points[0].Y = (float) L1ACheckList.RC1;
      ref PointF local13 = ref PDFFunctions.Points[1];
      xunit = PDFFunctions.pages[L1ACheckList.k].Width;
      double num209 = ((XUnit) ref xunit).Point - 20.0;
      local13.X = (float) num209;
      PDFFunctions.Points[1].Y = (float) L1ACheckList.RC1;
      ref PointF local14 = ref PDFFunctions.Points[2];
      xunit = PDFFunctions.pages[L1ACheckList.k].Width;
      double num210 = ((XUnit) ref xunit).Point - 20.0;
      local14.X = (float) num210;
      PDFFunctions.Points[2].Y = (float) checked (L1ACheckList.RC1 + 12);
      PDFFunctions.Points[3].X = 20f;
      PDFFunctions.Points[3].Y = (float) checked (L1ACheckList.RC1 + 12);
      PDFFunctions.gfx[L1ACheckList.k].DrawPolygon(PDFFunctions.polyGreen2, PDFFunctions.xBrush1, PDFFunctions.Points, PDFFunctions.Fill);
      XGraphics xgraphics103 = PDFFunctions.gfx[L1ACheckList.k];
      XFont arialFont10Bold42 = PDFFunctions.ArialFont10Bold;
      XSolidBrush white8 = XBrushes.White;
      double num211 = (double) checked (L1ACheckList.RC1 + 1);
      xunit = PDFFunctions.pages[L1ACheckList.k].Width;
      double point107 = ((XUnit) ref xunit).Point;
      xunit = PDFFunctions.pages[L1ACheckList.k].Height;
      double num212 = ((XUnit) ref xunit).Point / 2.0;
      XRect xrect103 = new XRect(25.0, num211, point107, num212);
      XStringFormat topLeft103 = XStringFormat.TopLeft;
      xgraphics103.DrawString("2a Thermal bridging", arialFont10Bold42, (XBrush) white8, xrect103, topLeft103);
      checked { L1ACheckList.RC1 += 15; }
      // ISSUE: reference to a compiler-generated field
      if (SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Thermal.ManualY)
      {
        // ISSUE: reference to a compiler-generated field
        string country = SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Address.Country;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(country, "England", false) == 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(country, "Wales", false) == 0)
        {
          // ISSUE: reference to a compiler-generated field
          SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Thermal.YValue = 0.15f;
        }
        XGraphics xgraphics104 = PDFFunctions.gfx[L1ACheckList.k];
        // ISSUE: reference to a compiler-generated field
        string str37 = "Thermal bridging calculated using user-specified y-value of " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Thermal.YValue);
        XFont arialFont10_54 = PDFFunctions.ArialFont10;
        XSolidBrush black72 = XBrushes.Black;
        double num213 = (double) checked (L1ACheckList.RC1 + 1);
        xunit = PDFFunctions.pages[L1ACheckList.k].Width;
        double point108 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[L1ACheckList.k].Height;
        double num214 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect104 = new XRect(60.0, num213, point108, num214);
        XStringFormat topLeft104 = XStringFormat.TopLeft;
        xgraphics104.DrawString(str37, arialFont10_54, (XBrush) black72, xrect104, topLeft104);
        checked { L1ACheckList.RC1 += 13; }
        XGraphics xgraphics105 = PDFFunctions.gfx[L1ACheckList.k];
        // ISSUE: reference to a compiler-generated field
        string str38 = "Reference: " + SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Thermal.Reference;
        XFont arialFont10_55 = PDFFunctions.ArialFont10;
        XSolidBrush black73 = XBrushes.Black;
        double num215 = (double) checked (L1ACheckList.RC1 + 1);
        xunit = PDFFunctions.pages[L1ACheckList.k].Width;
        double point109 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[L1ACheckList.k].Height;
        double num216 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect105 = new XRect(60.0, num215, point109, num216);
        XStringFormat topLeft105 = XStringFormat.TopLeft;
        xgraphics105.DrawString(str38, arialFont10_55, (XBrush) black73, xrect105, topLeft105);
        checked { L1ACheckList.RC1 += 13; }
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        if (SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Thermal.ManualHtb)
        {
          XGraphics xgraphics106 = PDFFunctions.gfx[L1ACheckList.k];
          XFont arialFont10_56 = PDFFunctions.ArialFont10;
          XSolidBrush black74 = XBrushes.Black;
          double num217 = (double) checked (L1ACheckList.RC1 + 1);
          xunit = PDFFunctions.pages[L1ACheckList.k].Width;
          double point110 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[L1ACheckList.k].Height;
          double num218 = ((XUnit) ref xunit).Point / 2.0;
          XRect xrect106 = new XRect(60.0, num217, point110, num218);
          XStringFormat topLeft106 = XStringFormat.TopLeft;
          xgraphics106.DrawString("Thermal bridging calculated from linear thermal transmittances for each junction", arialFont10_56, (XBrush) black74, xrect106, topLeft106);
          checked { L1ACheckList.RC1 += 13; }
        }
        else
        {
          XGraphics xgraphics107 = PDFFunctions.gfx[L1ACheckList.k];
          // ISSUE: reference to a compiler-generated field
          string str39 = "Thermal bridging calculated using user-specified y-value of " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Thermal.YValue);
          XFont arialFont10_57 = PDFFunctions.ArialFont10;
          XSolidBrush black75 = XBrushes.Black;
          double num219 = (double) checked (L1ACheckList.RC1 + 1);
          xunit = PDFFunctions.pages[L1ACheckList.k].Width;
          double point111 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[L1ACheckList.k].Height;
          double num220 = ((XUnit) ref xunit).Point / 2.0;
          XRect xrect107 = new XRect(60.0, num219, point111, num220);
          XStringFormat topLeft107 = XStringFormat.TopLeft;
          xgraphics107.DrawString(str39, arialFont10_57, (XBrush) black75, xrect107, topLeft107);
          checked { L1ACheckList.RC1 += 13; }
        }
      }
      PDFFunctions.xBrush1 = XBrush.op_Implicit((Brush) new SolidBrush(Color.FromArgb(159, 172, 62)));
      PDFFunctions.Points[0].X = 20f;
      PDFFunctions.Points[0].Y = (float) L1ACheckList.RC1;
      ref PointF local15 = ref PDFFunctions.Points[1];
      xunit = PDFFunctions.pages[L1ACheckList.k].Width;
      double num221 = ((XUnit) ref xunit).Point - 20.0;
      local15.X = (float) num221;
      PDFFunctions.Points[1].Y = (float) L1ACheckList.RC1;
      ref PointF local16 = ref PDFFunctions.Points[2];
      xunit = PDFFunctions.pages[L1ACheckList.k].Width;
      double num222 = ((XUnit) ref xunit).Point - 20.0;
      local16.X = (float) num222;
      PDFFunctions.Points[2].Y = (float) checked (L1ACheckList.RC1 + 12);
      PDFFunctions.Points[3].X = 20f;
      PDFFunctions.Points[3].Y = (float) checked (L1ACheckList.RC1 + 12);
      PDFFunctions.gfx[L1ACheckList.k].DrawPolygon(PDFFunctions.polyGreen2, PDFFunctions.xBrush1, PDFFunctions.Points, PDFFunctions.Fill);
      XGraphics xgraphics108 = PDFFunctions.gfx[L1ACheckList.k];
      XFont arialFont10Bold43 = PDFFunctions.ArialFont10Bold;
      XSolidBrush white9 = XBrushes.White;
      double num223 = (double) checked (L1ACheckList.RC1 + 1);
      xunit = PDFFunctions.pages[L1ACheckList.k].Width;
      double point112 = ((XUnit) ref xunit).Point;
      xunit = PDFFunctions.pages[L1ACheckList.k].Height;
      double num224 = ((XUnit) ref xunit).Point / 2.0;
      XRect xrect108 = new XRect(25.0, num223, point112, num224);
      XStringFormat topLeft108 = XStringFormat.TopLeft;
      xgraphics108.DrawString("3 Air permeability", arialFont10Bold43, (XBrush) white9, xrect108, topLeft108);
      checked { L1ACheckList.RC1 += 15; }
      XGraphics xgraphics109 = PDFFunctions.gfx[L1ACheckList.k];
      XFont arialFont10_58 = PDFFunctions.ArialFont10;
      XSolidBrush black76 = XBrushes.Black;
      double num225 = (double) checked (L1ACheckList.RC1 + 1);
      xunit = PDFFunctions.pages[L1ACheckList.k].Width;
      double point113 = ((XUnit) ref xunit).Point;
      xunit = PDFFunctions.pages[L1ACheckList.k].Height;
      double num226 = ((XUnit) ref xunit).Point / 2.0;
      XRect xrect109 = new XRect(50.0, num225, point113, num226);
      XStringFormat topLeft109 = XStringFormat.TopLeft;
      xgraphics109.DrawString("Air permeability at 50 pascals", arialFont10_58, (XBrush) black76, xrect109, topLeft109);
      string Left2 = "";
      bool flag3;
      // ISSUE: reference to a compiler-generated field
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Ventilation.Pressure, "As designed", false) == 0)
      {
        // ISSUE: reference to a compiler-generated field
        Left2 = Microsoft.VisualBasic.Strings.Format((object) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Ventilation.DesignAir, "0.00") + " (design value)";
        flag3 = true;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Ventilation.Pressure, "Assumed", false) == 0)
        {
          // ISSUE: reference to a compiler-generated field
          Left2 = Microsoft.VisualBasic.Strings.Format((object) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Ventilation.AssumedAir, "0.00");
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Ventilation.Pressure, "As built", false) == 0)
          {
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            Left2 = (double) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Ventilation.AssumedAir != -1.0 ? Microsoft.VisualBasic.Strings.Format((object) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Ventilation.MeasuredAir, "0.00") : Microsoft.VisualBasic.Strings.Format((object) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Ventilation.AssumedAir, "0.00");
            flag3 = true;
          }
          else
          {
            // ISSUE: reference to a compiler-generated field
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Ventilation.Pressure, "Calculated", false) == 0)
            {
              XGraphics xgraphics110 = PDFFunctions.gfx[L1ACheckList.k];
              XFont arialFont10_59 = PDFFunctions.ArialFont10;
              XSolidBrush black77 = XBrushes.Black;
              double num227 = (double) checked (L1ACheckList.RC1 + 1);
              xunit = PDFFunctions.pages[L1ACheckList.k].Width;
              double point114 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[L1ACheckList.k].Height;
              double num228 = ((XUnit) ref xunit).Point / 2.0;
              XRect xrect110 = new XRect(370.0, num227, point114, num228);
              XStringFormat topLeft110 = XStringFormat.TopLeft;
              xgraphics110.DrawString("None", arialFont10_59, (XBrush) black77, xrect110, topLeft110);
            }
          }
        }
      }
      // ISSUE: reference to a compiler-generated field
      if (SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Ventilation.AveragePerm)
      {
        if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left2, "", false) > 0U)
        {
          // ISSUE: reference to a compiler-generated field
          if ((double) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Ventilation.MeasuredAir > 0.0)
          {
            // ISSUE: reference to a compiler-generated field
            if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Address.Country, "Scotland", false) > 0U)
            {
              XGraphics xgraphics111 = PDFFunctions.gfx[L1ACheckList.k];
              // ISSUE: reference to a compiler-generated field
              string str40 = Microsoft.VisualBasic.Strings.Format((object) (float) ((double) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Ventilation.MeasuredAir + 2.0), "0.0") + "m\u00B3/m\u00B2h (average for dwelling type)";
              XFont arialFont10_60 = PDFFunctions.ArialFont10;
              XSolidBrush black78 = XBrushes.Black;
              double num229 = (double) checked (L1ACheckList.RC1 + 1);
              xunit = PDFFunctions.pages[L1ACheckList.k].Width;
              double point115 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[L1ACheckList.k].Height;
              double num230 = ((XUnit) ref xunit).Point / 2.0;
              XRect xrect111 = new XRect(370.0, num229, point115, num230);
              XStringFormat topLeft111 = XStringFormat.TopLeft;
              xgraphics111.DrawString(str40, arialFont10_60, (XBrush) black78, xrect111, topLeft111);
            }
            else
            {
              XGraphics xgraphics112 = PDFFunctions.gfx[L1ACheckList.k];
              // ISSUE: reference to a compiler-generated field
              string str41 = Microsoft.VisualBasic.Strings.Format((object) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Ventilation.MeasuredAir, "0.0") + "m\u00B3/m\u00B2h (average for dwelling type)";
              XFont arialFont10_61 = PDFFunctions.ArialFont10;
              XSolidBrush black79 = XBrushes.Black;
              double num231 = (double) checked (L1ACheckList.RC1 + 1);
              xunit = PDFFunctions.pages[L1ACheckList.k].Width;
              double point116 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[L1ACheckList.k].Height;
              double num232 = ((XUnit) ref xunit).Point / 2.0;
              XRect xrect112 = new XRect(370.0, num231, point116, num232);
              XStringFormat topLeft112 = XStringFormat.TopLeft;
              xgraphics112.DrawString(str41, arialFont10_61, (XBrush) black79, xrect112, topLeft112);
            }
          }
          else
          {
            // ISSUE: reference to a compiler-generated field
            if ((double) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Ventilation.MeasuredAir > 0.0)
            {
              Left2 += " (measured in this dwelling)";
            }
            else
            {
              // ISSUE: reference to a compiler-generated field
              if ((double) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Ventilation.AssumedAir > 0.0)
                Left2 += " (As in this dwelling)";
            }
            XGraphics xgraphics113 = PDFFunctions.gfx[L1ACheckList.k];
            string str42 = Left2;
            XFont arialFont10_62 = PDFFunctions.ArialFont10;
            XSolidBrush black80 = XBrushes.Black;
            double num233 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point117 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num234 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect113 = new XRect(370.0, num233, point117, num234);
            XStringFormat topLeft113 = XStringFormat.TopLeft;
            xgraphics113.DrawString(str42, arialFont10_62, (XBrush) black80, xrect113, topLeft113);
          }
        }
      }
      else
      {
        XGraphics xgraphics114 = PDFFunctions.gfx[L1ACheckList.k];
        string str43 = Left2;
        XFont arialFont10_63 = PDFFunctions.ArialFont10;
        XSolidBrush black81 = XBrushes.Black;
        double num235 = (double) checked (L1ACheckList.RC1 + 1);
        xunit = PDFFunctions.pages[L1ACheckList.k].Width;
        double point118 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[L1ACheckList.k].Height;
        double num236 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect114 = new XRect(370.0, num235, point118, num236);
        XStringFormat topLeft114 = XStringFormat.TopLeft;
        xgraphics114.DrawString(str43, arialFont10_63, (XBrush) black81, xrect114, topLeft114);
      }
      // ISSUE: reference to a compiler-generated field
      if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Address.Country, "Scotland", false) > 0U)
      {
        if (flag3)
        {
          checked { L1ACheckList.RC1 += 12; }
          L1ACheckList.CheckCheckListRC1();
          XGraphics xgraphics115 = PDFFunctions.gfx[L1ACheckList.k];
          XFont arialFont10_64 = PDFFunctions.ArialFont10;
          XSolidBrush black82 = XBrushes.Black;
          double num237 = (double) checked (L1ACheckList.RC1 + 1);
          xunit = PDFFunctions.pages[L1ACheckList.k].Width;
          double point119 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[L1ACheckList.k].Height;
          double num238 = ((XUnit) ref xunit).Point / 2.0;
          XRect xrect115 = new XRect(50.0, num237, point119, num238);
          XStringFormat topLeft115 = XStringFormat.TopLeft;
          xgraphics115.DrawString("Maximum", arialFont10_64, (XBrush) black82, xrect115, topLeft115);
          XGraphics xgraphics116 = PDFFunctions.gfx[L1ACheckList.k];
          XFont arialFont10_65 = PDFFunctions.ArialFont10;
          XSolidBrush black83 = XBrushes.Black;
          double num239 = (double) checked (L1ACheckList.RC1 + 1);
          xunit = PDFFunctions.pages[L1ACheckList.k].Width;
          double point120 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[L1ACheckList.k].Height;
          double num240 = ((XUnit) ref xunit).Point / 2.0;
          XRect xrect116 = new XRect(370.0, num239, point120, num240);
          XStringFormat topLeft116 = XStringFormat.TopLeft;
          xgraphics116.DrawString("10.0", arialFont10_65, (XBrush) black83, xrect116, topLeft116);
        }
        int num241;
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Ventilation.Pressure, "Assumed", false) == 0 & (double) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Ventilation.AssumedAir <= 15.0)
        {
          num241 = 1;
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Ventilation.Pressure, "As designed", false) == 0 & (double) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Ventilation.DesignAir <= 10.0)
          {
            num241 = 1;
          }
          else
          {
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Ventilation.Pressure, "As built", false) == 0 & (double) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Ventilation.MeasuredAir <= 10.0)
            {
              num241 = 1;
            }
            else
            {
              // ISSUE: reference to a compiler-generated field
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Ventilation.Pressure, "Calculated", false) == 0)
              {
                num241 = 2;
              }
              else
              {
                // ISSUE: reference to a compiler-generated field
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Ventilation.Pressure, "", false) == 0)
                  num241 = 2;
              }
            }
          }
        }
        if ((double) num241 == Conversions.ToDouble("0"))
        {
          XGraphics xgraphics117 = PDFFunctions.gfx[L1ACheckList.k];
          XFont arialFont10Bold44 = PDFFunctions.ArialFont10Bold;
          XSolidBrush red = XBrushes.Red;
          double num242 = (double) checked (L1ACheckList.RC1 + 1);
          xunit = PDFFunctions.pages[L1ACheckList.k].Width;
          double point121 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[L1ACheckList.k].Height;
          double num243 = ((XUnit) ref xunit).Point / 2.0;
          XRect xrect117 = new XRect(540.0, num242, point121, num243);
          XStringFormat topLeft117 = XStringFormat.TopLeft;
          xgraphics117.DrawString("Fail", arialFont10Bold44, (XBrush) red, xrect117, topLeft117);
        }
        else if ((double) num241 == Conversions.ToDouble("1"))
        {
          XGraphics xgraphics118 = PDFFunctions.gfx[L1ACheckList.k];
          XFont arialFont10Bold45 = PDFFunctions.ArialFont10Bold;
          XSolidBrush green = XBrushes.Green;
          double num244 = (double) checked (L1ACheckList.RC1 + 1);
          xunit = PDFFunctions.pages[L1ACheckList.k].Width;
          double point122 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[L1ACheckList.k].Height;
          double num245 = ((XUnit) ref xunit).Point / 2.0;
          XRect xrect118 = new XRect(540.0, num244, point122, num245);
          XStringFormat topLeft118 = XStringFormat.TopLeft;
          xgraphics118.DrawString("OK", arialFont10Bold45, (XBrush) green, xrect118, topLeft118);
        }
        else if ((double) num241 == Conversions.ToDouble("2"))
        {
          XGraphics xgraphics119 = PDFFunctions.gfx[L1ACheckList.k];
          XFont arialFont10Bold46 = PDFFunctions.ArialFont10Bold;
          XSolidBrush blue = XBrushes.Blue;
          double num246 = (double) checked (L1ACheckList.RC1 + 1);
          xunit = PDFFunctions.pages[L1ACheckList.k].Width;
          double point123 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[L1ACheckList.k].Height;
          double num247 = ((XUnit) ref xunit).Point / 2.0;
          XRect xrect119 = new XRect(540.0, num246, point123, num247);
          XStringFormat topLeft119 = XStringFormat.TopLeft;
          xgraphics119.DrawString("?", arialFont10Bold46, (XBrush) blue, xrect119, topLeft119);
        }
      }
      checked { L1ACheckList.RC1 += 20; }
      L1ACheckList.CheckCheckListRC1();
      PDFFunctions.xBrush1 = XBrush.op_Implicit((Brush) new SolidBrush(Color.FromArgb(159, 172, 62)));
      PDFFunctions.Points[0].X = 20f;
      PDFFunctions.Points[0].Y = (float) L1ACheckList.RC1;
      ref PointF local17 = ref PDFFunctions.Points[1];
      xunit = PDFFunctions.pages[L1ACheckList.k].Width;
      double num248 = ((XUnit) ref xunit).Point - 20.0;
      local17.X = (float) num248;
      PDFFunctions.Points[1].Y = (float) L1ACheckList.RC1;
      ref PointF local18 = ref PDFFunctions.Points[2];
      xunit = PDFFunctions.pages[L1ACheckList.k].Width;
      double num249 = ((XUnit) ref xunit).Point - 20.0;
      local18.X = (float) num249;
      PDFFunctions.Points[2].Y = (float) checked (L1ACheckList.RC1 + 12);
      PDFFunctions.Points[3].X = 20f;
      PDFFunctions.Points[3].Y = (float) checked (L1ACheckList.RC1 + 12);
      PDFFunctions.gfx[L1ACheckList.k].DrawPolygon(PDFFunctions.polyGreen2, PDFFunctions.xBrush1, PDFFunctions.Points, PDFFunctions.Fill);
      string Left3 = "";
      string str44 = "";
      string str45 = "";
      string str46 = "";
      string str47 = "";
      XGraphics xgraphics120 = PDFFunctions.gfx[L1ACheckList.k];
      XFont arialFont10Bold47 = PDFFunctions.ArialFont10Bold;
      XSolidBrush white10 = XBrushes.White;
      double num250 = (double) checked (L1ACheckList.RC1 + 1);
      xunit = PDFFunctions.pages[L1ACheckList.k].Width;
      double point124 = ((XUnit) ref xunit).Point;
      xunit = PDFFunctions.pages[L1ACheckList.k].Height;
      double num251 = ((XUnit) ref xunit).Point / 2.0;
      XRect xrect120 = new XRect(25.0, num250, point124, num251);
      XStringFormat topLeft120 = XStringFormat.TopLeft;
      xgraphics120.DrawString("4 Heating efficiency", arialFont10Bold47, (XBrush) white10, xrect120, topLeft120);
      checked { L1ACheckList.RC1 += 15; }
      XGraphics xgraphics121 = PDFFunctions.gfx[L1ACheckList.k];
      XFont arialFont10_66 = PDFFunctions.ArialFont10;
      XSolidBrush black84 = XBrushes.Black;
      double num252 = (double) checked (L1ACheckList.RC1 + 1);
      xunit = PDFFunctions.pages[L1ACheckList.k].Width;
      double point125 = ((XUnit) ref xunit).Point;
      xunit = PDFFunctions.pages[L1ACheckList.k].Height;
      double num253 = ((XUnit) ref xunit).Point / 2.0;
      XRect xrect121 = new XRect(50.0, num252, point125, num253);
      XStringFormat topLeft121 = XStringFormat.TopLeft;
      xgraphics121.DrawString("Main Heating system:", arialFont10_66, (XBrush) black84, xrect121, topLeft121);
      // ISSUE: reference to a compiler-generated field
      int sapTableCode1 = SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.SAPTableCode;
      if (sapTableCode1 >= 120 && sapTableCode1 <= 123)
      {
        // ISSUE: reference to a compiler-generated field
        if (SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Water.SystemRef == 901)
          L1ACheckList.CPSUFound = true;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        if (sapTableCode1 == 192 && SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Water.Thermal.Include)
          L1ACheckList.CPSUFound = true;
      }
      // ISSUE: reference to a compiler-generated field
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.InforSource, "Boiler Database", false) == 0)
      {
        // ISSUE: reference to a compiler-generated field
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.SGroup, "Gas boilers and oil boilers", false) == 0)
        {
          // ISSUE: reference to a compiler-generated method
          PCDF.SEDBUK sedbuk = SAP_Module.PCDFData.Boilers.Where<PCDF.SEDBUK>(new Func<PCDF.SEDBUK, bool>(closure260_2._Lambda\u0024__0)).SingleOrDefault<PCDF.SEDBUK>();
          if (sedbuk != null)
          {
            str44 = sedbuk.BrandName;
            str46 = sedbuk.ModelName;
            str45 = sedbuk.ModelQualifier;
            double num254 = Conversion.Val(sedbuk.MainType);
            if (num254 == 0.0)
              str47 = "Unknown";
            else if (num254 == 1.0)
              str47 = "Regular";
            else if (num254 == 2.0)
              str47 = "Combi";
            else if (num254 == 3.0)
              str47 = "CPSU";
          }
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.SGroup, "Micro-cogeneration (micro-CHP)", false) == 0)
          {
            // ISSUE: reference to a compiler-generated method
            PCDF.CHP chp = SAP_Module.PCDFData.CHPs.Where<PCDF.CHP>(new Func<PCDF.CHP, bool>(closure260_2._Lambda\u0024__1)).SingleOrDefault<PCDF.CHP>();
            if (chp != null)
            {
              str44 = chp.Brand;
              str46 = chp.Model;
              str45 = chp.Qualifier;
              Left3 = Microsoft.VisualBasic.Strings.Format((object) Math.Round(SAP_Module.Calculation2012.Calculation.Energy_Requirements_9a.Box206), "00.0");
            }
          }
          else
          {
            // ISSUE: reference to a compiler-generated field
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.SGroup, "Solid fuel boilers", false) == 0)
            {
              // ISSUE: reference to a compiler-generated method
              PCDF.SEDBUK_Solid sedbukSolid = SAP_Module.PCDFData.Solid_Boilers.Where<PCDF.SEDBUK_Solid>(new Func<PCDF.SEDBUK_Solid, bool>(closure260_2._Lambda\u0024__2)).SingleOrDefault<PCDF.SEDBUK_Solid>();
              if (sedbukSolid != null)
              {
                str44 = sedbukSolid.BrandName;
                str46 = sedbukSolid.ModelName;
                str45 = sedbukSolid.ModelQualifier;
                double num255 = Conversion.Val(sedbukSolid.MainType);
                if (num255 == 0.0)
                  str47 = "Unknown";
                else if (num255 == 1.0)
                  str47 = "Regular";
                else if (num255 == 2.0)
                  str47 = "Combi";
                else if (num255 == 3.0)
                  str47 = "CPSU";
                Left3 = Microsoft.VisualBasic.Strings.Format((object) Math.Round(SAP_Module.Calculation2012.Calculation.Energy_Requirements_9a.Box206), "00.0");
                if (Conversions.ToDouble(Left3) == 0.0)
                {
                  // ISSUE: reference to a compiler-generated field
                  Left3 = Microsoft.VisualBasic.Strings.Format((object) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.MainEff, "00.0");
                }
              }
            }
          }
        }
        // ISSUE: reference to a compiler-generated field
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.SGroup, "Micro-cogeneration (micro-CHP)", false) == 0)
        {
          XGraphics xgraphics122 = PDFFunctions.gfx[L1ACheckList.k];
          // ISSUE: reference to a compiler-generated field
          string str48 = "Micro-cogeneration - " + PDFFunctions.CheckFuel((object) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.Fuel);
          XFont arialFont10_67 = PDFFunctions.ArialFont10;
          XSolidBrush black85 = XBrushes.Black;
          double rc1_18 = (double) L1ACheckList.RC1;
          xunit = PDFFunctions.pages[L1ACheckList.k].Width;
          double point126 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[L1ACheckList.k].Height;
          double num256 = ((XUnit) ref xunit).Point / 2.0;
          XRect xrect122 = new XRect(200.0, rc1_18, point126, num256);
          XStringFormat topLeft122 = XStringFormat.TopLeft;
          xgraphics122.DrawString(str48, arialFont10_67, (XBrush) black85, xrect122, topLeft122);
          checked { L1ACheckList.RC1 += 13; }
          XGraphics xgraphics123 = PDFFunctions.gfx[L1ACheckList.k];
          XFont arialFont10_68 = PDFFunctions.ArialFont10;
          XSolidBrush black86 = XBrushes.Black;
          double rc1_19 = (double) L1ACheckList.RC1;
          xunit = PDFFunctions.pages[L1ACheckList.k].Width;
          double point127 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[L1ACheckList.k].Height;
          double num257 = ((XUnit) ref xunit).Point / 2.0;
          XRect xrect123 = new XRect(200.0, rc1_19, point127, num257);
          XStringFormat topLeft123 = XStringFormat.TopLeft;
          xgraphics123.DrawString("Data from database ", arialFont10_68, (XBrush) black86, xrect123, topLeft123);
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.SGroup, "Electric heat pumps", false) > 0U & (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.SGroup, "Gas-fired heat pumps", false) > 0U)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left3, (string) null, false) == 0)
            {
              XGraphics xgraphics124 = PDFFunctions.gfx[L1ACheckList.k];
              // ISSUE: reference to a compiler-generated field
              string str49 = "Database: (rev " + Conversions.ToString(SAP_Module.DataBVersion) + ", product index " + SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.SEDBUK + "):";
              XFont arialFont10_69 = PDFFunctions.ArialFont10;
              XSolidBrush black87 = XBrushes.Black;
              double rc1_20 = (double) L1ACheckList.RC1;
              xunit = PDFFunctions.pages[L1ACheckList.k].Width;
              double point128 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[L1ACheckList.k].Height;
              double num258 = ((XUnit) ref xunit).Point / 2.0;
              XRect xrect124 = new XRect(200.0, rc1_20, point128, num258);
              XStringFormat topLeft124 = XStringFormat.TopLeft;
              xgraphics124.DrawString(str49, arialFont10_69, (XBrush) black87, xrect124, topLeft124);
            }
            else
            {
              XGraphics xgraphics125 = PDFFunctions.gfx[L1ACheckList.k];
              // ISSUE: reference to a compiler-generated field
              string str50 = "Database: (rev " + Conversions.ToString(SAP_Module.DataBVersion) + ", product index " + SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.SEDBUK + "):";
              XFont arialFont10_70 = PDFFunctions.ArialFont10;
              XSolidBrush black88 = XBrushes.Black;
              double rc1_21 = (double) L1ACheckList.RC1;
              xunit = PDFFunctions.pages[L1ACheckList.k].Width;
              double point129 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[L1ACheckList.k].Height;
              double num259 = ((XUnit) ref xunit).Point / 2.0;
              XRect xrect125 = new XRect(200.0, rc1_21, point129, num259);
              XStringFormat topLeft125 = XStringFormat.TopLeft;
              xgraphics125.DrawString(str50, arialFont10_70, (XBrush) black88, xrect125, topLeft125);
            }
          }
        }
        checked { L1ACheckList.RC1 += 13; }
      }
      L1ACheckList.CheckCheckListRC1();
      // ISSUE: reference to a compiler-generated field
      string hgroup1 = SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.HGroup;
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      string str51 = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(hgroup1, "Central heating systems with radiators or underfloor heating", false) == 0 ? (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.SGroup, "Heat pumps", false) != 0 ? "Boiler system with radiators or underfloor" : "Heat pumps with radiators or underfloor") : (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(hgroup1, "Warm air systems", false) == 0 ? (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.SGroup, "Heat pumps", false) != 0 ? SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.HGroup + " (not heat pump)" : "Heat pump with warm air distribution") : SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.HGroup);
      // ISSUE: reference to a compiler-generated field
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.Fuel, "heating oil", false) == 0)
      {
        XGraphics xgraphics126 = PDFFunctions.gfx[L1ACheckList.k];
        // ISSUE: reference to a compiler-generated field
        string str52 = str51 + " - " + SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.Fuel;
        XFont arialFont10_71 = PDFFunctions.ArialFont10;
        XSolidBrush black89 = XBrushes.Black;
        double num260 = (double) checked (L1ACheckList.RC1 + 1);
        xunit = PDFFunctions.pages[L1ACheckList.k].Width;
        double point130 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[L1ACheckList.k].Height;
        double num261 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect126 = new XRect(200.0, num260, point130, num261);
        XStringFormat topLeft126 = XStringFormat.TopLeft;
        xgraphics126.DrawString(str52, arialFont10_71, (XBrush) black89, xrect126, topLeft126);
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.SGroup, "Micro-cogeneration (micro-CHP)", false) > 0U)
        {
          XGraphics xgraphics127 = PDFFunctions.gfx[L1ACheckList.k];
          // ISSUE: reference to a compiler-generated field
          string str53 = str51 + " - " + PDFFunctions.CheckFuel((object) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.Fuel);
          XFont arialFont10_72 = PDFFunctions.ArialFont10;
          XSolidBrush black90 = XBrushes.Black;
          double num262 = (double) checked (L1ACheckList.RC1 + 1);
          xunit = PDFFunctions.pages[L1ACheckList.k].Width;
          double point131 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[L1ACheckList.k].Height;
          double num263 = ((XUnit) ref xunit).Point / 2.0;
          XRect xrect127 = new XRect(200.0, num262, point131, num263);
          XStringFormat topLeft127 = XStringFormat.TopLeft;
          xgraphics127.DrawString(str53, arialFont10_72, (XBrush) black90, xrect127, topLeft127);
        }
      }
      checked { L1ACheckList.RC1 += 13; }
      L1ACheckList.CheckCheckListRC1();
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.SGroup, "Gas boilers and oil boilers", false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.InforSource, "Manufacturer Declaration", false) == 0)
      {
        XGraphics xgraphics128 = PDFFunctions.gfx[L1ACheckList.k];
        XFont arialFont10_73 = PDFFunctions.ArialFont10;
        XSolidBrush black91 = XBrushes.Black;
        double num264 = (double) checked (L1ACheckList.RC1 + 1);
        xunit = PDFFunctions.pages[L1ACheckList.k].Width;
        double point132 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[L1ACheckList.k].Height;
        double num265 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect128 = new XRect(200.0, num264, point132, num265);
        XStringFormat topLeft128 = XStringFormat.TopLeft;
        xgraphics128.DrawString("Data from manufacturer", arialFont10_73, (XBrush) black91, xrect128, topLeft128);
        checked { L1ACheckList.RC1 += 13; }
        // ISSUE: reference to a compiler-generated field
        if (SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.BSubGroup.Contains("CPSU"))
        {
          XGraphics xgraphics129 = PDFFunctions.gfx[L1ACheckList.k];
          XFont arialFont10_74 = PDFFunctions.ArialFont10;
          XSolidBrush black92 = XBrushes.Black;
          double num266 = (double) checked (L1ACheckList.RC1 + 1);
          xunit = PDFFunctions.pages[L1ACheckList.k].Width;
          double point133 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[L1ACheckList.k].Height;
          double num267 = ((XUnit) ref xunit).Point / 2.0;
          XRect xrect129 = new XRect(200.0, num266, point133, num267);
          XStringFormat topLeft129 = XStringFormat.TopLeft;
          xgraphics129.DrawString("CPSU", arialFont10_74, (XBrush) black92, xrect129, topLeft129);
          checked { L1ACheckList.RC1 += 13; }
        }
      }
      // ISSUE: reference to a compiler-generated field
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.InforSource, "Boiler Database", false) == 0)
      {
        // ISSUE: reference to a compiler-generated field
        if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.HGroup, "Community heating schemes", false) > 0U)
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.SGroup, "Electric heat pumps", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.SGroup, "Gas-fired heat pumps", false) == 0)
          {
            // ISSUE: reference to a compiler-generated method
            PCDF.HeatPump heatPump = SAP_Module.PCDFData.HeatPumps.Where<PCDF.HeatPump>(new Func<PCDF.HeatPump, bool>(closure260_2._Lambda\u0024__3)).SingleOrDefault<PCDF.HeatPump>();
            if (heatPump != null)
            {
              str44 = heatPump.Brand;
              str46 = heatPump.Model;
              str45 = heatPump.Qualifier;
              XGraphics xgraphics130 = PDFFunctions.gfx[L1ACheckList.k];
              string str54 = str44 + " " + str46;
              XFont arialFont10_75 = PDFFunctions.ArialFont10;
              XSolidBrush black93 = XBrushes.Black;
              double rc1_22 = (double) L1ACheckList.RC1;
              xunit = PDFFunctions.pages[L1ACheckList.k].Width;
              double point134 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[L1ACheckList.k].Height;
              double num268 = ((XUnit) ref xunit).Point / 2.0;
              XRect xrect130 = new XRect(200.0, rc1_22, point134, num268);
              XStringFormat topLeft130 = XStringFormat.TopLeft;
              xgraphics130.DrawString(str54, arialFont10_75, (XBrush) black93, xrect130, topLeft130);
            }
            checked { L1ACheckList.RC1 += 12; }
          }
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.SGroup, "Micro-cogeneration (micro-CHP)", false) > 0U & (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.SGroup, "Electric heat pumps", false) > 0U & (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.SGroup, "Gas-fired heat pumps", false) > 0U)
          {
            XGraphics xgraphics131 = PDFFunctions.gfx[L1ACheckList.k];
            string str55 = "Brand name: " + str44;
            XFont arialFont10_76 = PDFFunctions.ArialFont10;
            XSolidBrush black94 = XBrushes.Black;
            double rc1_23 = (double) L1ACheckList.RC1;
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point135 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num269 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect131 = new XRect(200.0, rc1_23, point135, num269);
            XStringFormat topLeft131 = XStringFormat.TopLeft;
            xgraphics131.DrawString(str55, arialFont10_76, (XBrush) black94, xrect131, topLeft131);
            checked { L1ACheckList.RC1 += 12; }
            XGraphics xgraphics132 = PDFFunctions.gfx[L1ACheckList.k];
            string str56 = "Model: " + str46;
            XFont arialFont10_77 = PDFFunctions.ArialFont10;
            XSolidBrush black95 = XBrushes.Black;
            double rc1_24 = (double) L1ACheckList.RC1;
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point136 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num270 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect132 = new XRect(200.0, rc1_24, point136, num270);
            XStringFormat topLeft132 = XStringFormat.TopLeft;
            xgraphics132.DrawString(str56, arialFont10_77, (XBrush) black95, xrect132, topLeft132);
            checked { L1ACheckList.RC1 += 12; }
            XGraphics xgraphics133 = PDFFunctions.gfx[L1ACheckList.k];
            string str57 = "Model qualifier: " + str45;
            XFont arialFont10_78 = PDFFunctions.ArialFont10;
            XSolidBrush black96 = XBrushes.Black;
            double rc1_25 = (double) L1ACheckList.RC1;
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point137 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num271 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect133 = new XRect(200.0, rc1_25, point137, num271);
            XStringFormat topLeft133 = XStringFormat.TopLeft;
            xgraphics133.DrawString(str57, arialFont10_78, (XBrush) black96, xrect133, topLeft133);
            checked { L1ACheckList.RC1 += 12; }
            // ISSUE: reference to a compiler-generated field
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.SGroup, "Micro-cogeneration (micro-CHP)", false) == 0)
            {
              XGraphics xgraphics134 = PDFFunctions.gfx[L1ACheckList.k];
              XFont arialFont10_79 = PDFFunctions.ArialFont10;
              XSolidBrush black97 = XBrushes.Black;
              double rc1_26 = (double) L1ACheckList.RC1;
              xunit = PDFFunctions.pages[L1ACheckList.k].Width;
              double point138 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[L1ACheckList.k].Height;
              double num272 = ((XUnit) ref xunit).Point / 2.0;
              XRect xrect134 = new XRect(200.0, rc1_26, point138, num272);
              XStringFormat topLeft134 = XStringFormat.TopLeft;
              xgraphics134.DrawString("(provides DHW all year)", arialFont10_79, (XBrush) black97, xrect134, topLeft134);
            }
            else
            {
              XGraphics xgraphics135 = PDFFunctions.gfx[L1ACheckList.k];
              string str58 = "(" + str47 + ")";
              XFont arialFont10_80 = PDFFunctions.ArialFont10;
              XSolidBrush black98 = XBrushes.Black;
              double rc1_27 = (double) L1ACheckList.RC1;
              xunit = PDFFunctions.pages[L1ACheckList.k].Width;
              double point139 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[L1ACheckList.k].Height;
              double num273 = ((XUnit) ref xunit).Point / 2.0;
              XRect xrect135 = new XRect(200.0, rc1_27, point139, num273);
              XStringFormat topLeft135 = XStringFormat.TopLeft;
              xgraphics135.DrawString(str58, arialFont10_80, (XBrush) black98, xrect135, topLeft135);
            }
            checked { L1ACheckList.RC1 += 12; }
          }
          else
          {
            // ISSUE: reference to a compiler-generated field
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.InforSource, "Manufacturer Declaration", false) == 0)
            {
              XGraphics xgraphics136 = PDFFunctions.gfx[L1ACheckList.k];
              // ISSUE: reference to a compiler-generated field
              string str59 = "Data from manufacturer - " + PDFFunctions.CheckFuel((object) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.Fuel);
              XFont arialFont10_81 = PDFFunctions.ArialFont10;
              XSolidBrush black99 = XBrushes.Black;
              double rc1_28 = (double) L1ACheckList.RC1;
              xunit = PDFFunctions.pages[L1ACheckList.k].Width;
              double point140 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[L1ACheckList.k].Height;
              double num274 = ((XUnit) ref xunit).Point / 2.0;
              XRect xrect136 = new XRect(200.0, rc1_28, point140, num274);
              XStringFormat topLeft136 = XStringFormat.TopLeft;
              xgraphics136.DrawString(str59, arialFont10_81, (XBrush) black99, xrect136, topLeft136);
              checked { L1ACheckList.RC1 += 12; }
              XGraphics xgraphics137 = PDFFunctions.gfx[L1ACheckList.k];
              // ISSUE: reference to a compiler-generated field
              string description = SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.Boiler.Description;
              XFont arialFont10_82 = PDFFunctions.ArialFont10;
              XSolidBrush black100 = XBrushes.Black;
              double rc1_29 = (double) L1ACheckList.RC1;
              xunit = PDFFunctions.pages[L1ACheckList.k].Width;
              double point141 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[L1ACheckList.k].Height;
              double num275 = ((XUnit) ref xunit).Point / 2.0;
              XRect xrect137 = new XRect(200.0, rc1_29, point141, num275);
              XStringFormat topLeft137 = XStringFormat.TopLeft;
              xgraphics137.DrawString(description, arialFont10_82, (XBrush) black100, xrect137, topLeft137);
              checked { L1ACheckList.RC1 += 12; }
            }
            else
            {
              // ISSUE: reference to a compiler-generated field
              if (!string.IsNullOrEmpty(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.BSubGroup))
              {
                XGraphics xgraphics138 = PDFFunctions.gfx[L1ACheckList.k];
                // ISSUE: reference to a compiler-generated field
                string bsubGroup = SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.BSubGroup;
                XFont arialFont10_83 = PDFFunctions.ArialFont10;
                XSolidBrush black101 = XBrushes.Black;
                double rc1_30 = (double) L1ACheckList.RC1;
                xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                double point142 = ((XUnit) ref xunit).Point;
                xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                double num276 = ((XUnit) ref xunit).Point / 2.0;
                XRect xrect138 = new XRect(200.0, rc1_30, point142, num276);
                XStringFormat topLeft138 = XStringFormat.TopLeft;
                xgraphics138.DrawString(bsubGroup, arialFont10_83, (XBrush) black101, xrect138, topLeft138);
                checked { L1ACheckList.RC1 += 12; }
              }
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.SGroup, "Electric heat pumps", false) > 0U | (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.SGroup, "Gas-fired heat pumps", false) > 0U)
              {
                XGraphics xgraphics139 = PDFFunctions.gfx[L1ACheckList.k];
                // ISSUE: reference to a compiler-generated field
                string mhType = SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.MHType;
                XFont arialFont10_84 = PDFFunctions.ArialFont10;
                XSolidBrush black102 = XBrushes.Black;
                double rc1_31 = (double) L1ACheckList.RC1;
                xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                double point143 = ((XUnit) ref xunit).Point;
                xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                double num277 = ((XUnit) ref xunit).Point / 2.0;
                XRect xrect139 = new XRect(200.0, rc1_31, point143, num277);
                XStringFormat topLeft139 = XStringFormat.TopLeft;
                xgraphics139.DrawString(mhType, arialFont10_84, (XBrush) black102, xrect139, topLeft139);
              }
              else
              {
                // ISSUE: reference to a compiler-generated method
                PCDF.HeatPump heatPump = SAP_Module.PCDFData.HeatPumps.Where<PCDF.HeatPump>(new Func<PCDF.HeatPump, bool>(closure260_2._Lambda\u0024__4)).SingleOrDefault<PCDF.HeatPump>();
                if (heatPump != null)
                {
                  str44 = heatPump.Brand;
                  str46 = heatPump.Model;
                  str45 = heatPump.Qualifier;
                  XGraphics xgraphics140 = PDFFunctions.gfx[L1ACheckList.k];
                  string str60 = str44 + " " + str46;
                  XFont arialFont10_85 = PDFFunctions.ArialFont10;
                  XSolidBrush black103 = XBrushes.Black;
                  double rc1_32 = (double) L1ACheckList.RC1;
                  xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                  double point144 = ((XUnit) ref xunit).Point;
                  xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                  double num278 = ((XUnit) ref xunit).Point / 2.0;
                  XRect xrect140 = new XRect(200.0, rc1_32, point144, num278);
                  XStringFormat topLeft140 = XStringFormat.TopLeft;
                  xgraphics140.DrawString(str60, arialFont10_85, (XBrush) black103, xrect140, topLeft140);
                }
                checked { L1ACheckList.RC1 += 12; }
              }
            }
          }
        }
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.InforSource, "SAP Tables", false) == 0)
        {
          if (L1ACheckList.CPSUFound)
          {
            // ISSUE: reference to a compiler-generated field
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.MHType, "With automatic ignition (non-condensing)", false) == 0)
            {
              XGraphics xgraphics141 = PDFFunctions.gfx[L1ACheckList.k];
              XFont arialFont10_86 = PDFFunctions.ArialFont10;
              XSolidBrush black104 = XBrushes.Black;
              double rc1_33 = (double) L1ACheckList.RC1;
              xunit = PDFFunctions.pages[L1ACheckList.k].Width;
              double point145 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[L1ACheckList.k].Height;
              double num279 = ((XUnit) ref xunit).Point / 2.0;
              XRect xrect141 = new XRect(200.0, rc1_33, point145, num279);
              XStringFormat topLeft141 = XStringFormat.TopLeft;
              xgraphics141.DrawString("CPSU - Combined Primary Storage Unit (non condensing)", arialFont10_86, (XBrush) black104, xrect141, topLeft141);
            }
            else
            {
              XGraphics xgraphics142 = PDFFunctions.gfx[L1ACheckList.k];
              // ISSUE: reference to a compiler-generated field
              string str61 = "CPSU- " + SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.MHType;
              XFont arialFont10_87 = PDFFunctions.ArialFont10;
              XSolidBrush black105 = XBrushes.Black;
              double rc1_34 = (double) L1ACheckList.RC1;
              xunit = PDFFunctions.pages[L1ACheckList.k].Width;
              double point146 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[L1ACheckList.k].Height;
              double num280 = ((XUnit) ref xunit).Point / 2.0;
              XRect xrect142 = new XRect(200.0, rc1_34, point146, num280);
              XStringFormat topLeft142 = XStringFormat.TopLeft;
              xgraphics142.DrawString(str61, arialFont10_87, (XBrush) black105, xrect142, topLeft142);
            }
          }
          else
          {
            // ISSUE: reference to a compiler-generated field
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.MHType, "Ground source heat pump in other cases", false) == 0)
            {
              XGraphics xgraphics143 = PDFFunctions.gfx[L1ACheckList.k];
              XFont arialFont10_88 = PDFFunctions.ArialFont10;
              XSolidBrush black106 = XBrushes.Black;
              double rc1_35 = (double) L1ACheckList.RC1;
              xunit = PDFFunctions.pages[L1ACheckList.k].Width;
              double point147 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[L1ACheckList.k].Height;
              double num281 = ((XUnit) ref xunit).Point / 2.0;
              XRect xrect143 = new XRect(200.0, rc1_35, point147, num281);
              XStringFormat topLeft143 = XStringFormat.TopLeft;
              xgraphics143.DrawString("Ground source heat pump (flow temperature <= 35°C)", arialFont10_88, (XBrush) black106, xrect143, topLeft143);
            }
            else
            {
              XGraphics xgraphics144 = PDFFunctions.gfx[L1ACheckList.k];
              // ISSUE: reference to a compiler-generated field
              string mhType = SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.MHType;
              XFont arialFont10_89 = PDFFunctions.ArialFont10;
              XSolidBrush black107 = XBrushes.Black;
              double rc1_36 = (double) L1ACheckList.RC1;
              xunit = PDFFunctions.pages[L1ACheckList.k].Width;
              double point148 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[L1ACheckList.k].Height;
              double num282 = ((XUnit) ref xunit).Point / 2.0;
              XRect xrect144 = new XRect(200.0, rc1_36, point148, num282);
              XStringFormat topLeft144 = XStringFormat.TopLeft;
              xgraphics144.DrawString(mhType, arialFont10_89, (XBrush) black107, xrect144, topLeft144);
            }
          }
          checked { L1ACheckList.RC1 += 12; }
        }
      }
      L1ACheckList.CheckCheckListRC1();
      // ISSUE: reference to a compiler-generated field
      if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.InforSource, "Boiler Database", false) > 0U)
      {
        // ISSUE: reference to a compiler-generated field
        switch (SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.SAPTableCode)
        {
          case 103:
          case 104:
          case 108:
          case 112:
          case 113:
          case 118:
          case 128:
          case 129:
          case 130:
            // ISSUE: reference to a compiler-generated field
            string combiType1 = SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Water.CombiType;
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(combiType1, "", false) == 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(combiType1, "Instantaneous Combi", false) == 0)
            {
              XGraphics xgraphics145 = PDFFunctions.gfx[L1ACheckList.k];
              XFont arialFont10_90 = PDFFunctions.ArialFont10;
              XSolidBrush black108 = XBrushes.Black;
              double rc1_37 = (double) L1ACheckList.RC1;
              xunit = PDFFunctions.pages[L1ACheckList.k].Width;
              double point149 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[L1ACheckList.k].Height;
              double num283 = ((XUnit) ref xunit).Point / 2.0;
              XRect xrect145 = new XRect(200.0, rc1_37, point149, num283);
              XStringFormat topLeft145 = XStringFormat.TopLeft;
              xgraphics145.DrawString("Combi boiler", arialFont10_90, (XBrush) black108, xrect145, topLeft145);
              checked { L1ACheckList.RC1 += 12; }
              break;
            }
            break;
        }
      }
      L1ACheckList.CheckCheckListRC1();
      // ISSUE: reference to a compiler-generated field
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.InforSource, "Boiler Database", false) == 0)
      {
        // ISSUE: reference to a compiler-generated field
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.SGroup, "Gas boilers and oil boilers", false) == 0)
        {
          XGraphics xgraphics146 = PDFFunctions.gfx[L1ACheckList.k];
          // ISSUE: reference to a compiler-generated field
          string str62 = "Efficiency " + Microsoft.VisualBasic.Strings.Format((object) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.MainEff, "00.0") + " % SEDBUK2009";
          XFont arialFont10_91 = PDFFunctions.ArialFont10;
          XSolidBrush black109 = XBrushes.Black;
          double num284 = (double) checked (L1ACheckList.RC1 + 1);
          xunit = PDFFunctions.pages[L1ACheckList.k].Width;
          double point150 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[L1ACheckList.k].Height;
          double num285 = ((XUnit) ref xunit).Point / 2.0;
          XRect xrect146 = new XRect(200.0, num284, point150, num285);
          XStringFormat topLeft146 = XStringFormat.TopLeft;
          xgraphics146.DrawString(str62, arialFont10_91, (XBrush) black109, xrect146, topLeft146);
          checked { L1ACheckList.RC1 += 13; }
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.SGroup, "Micro-cogeneration (micro-CHP)", false) == 0)
          {
            float num286 = 0.23f;
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            float num287 = !(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Water.SystemRef == 901 | SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Water.SystemRef == 903) ? (float) ((SAP_Module.CalcualtionDER2012.Calculation.CO2_Emissions_12a.Box261 + SAP_Module.CalcualtionDER2012.Calculation.CO2_Emissions_12a.Box263 + SAP_Module.CalcualtionDER2012.Calculation.CO2_Emissions_12a.Box269) / SAP_Module.CalcualtionDER2012.Calculation.Space_heating_requirement.Box98) : (float) ((SAP_Module.CalcualtionDER2012.Calculation.CO2_Emissions_12a.Box261 + SAP_Module.CalcualtionDER2012.Calculation.CO2_Emissions_12a.Box263 + SAP_Module.CalcualtionDER2012.Calculation.CO2_Emissions_12a.Box264 + SAP_Module.CalcualtionDER2012.Calculation.CO2_Emissions_12a.Box269) / (SAP_Module.CalcualtionDER2012.Calculation.Space_heating_requirement.Box98 + SAP_Module.CalcualtionDER2012.Calculation.Water_heating.Box64));
            XGraphics xgraphics147 = PDFFunctions.gfx[L1ACheckList.k];
            string str63 = "HPER: " + Conversions.ToString(Math.Round((double) num287, 2));
            XFont arialFont10_92 = PDFFunctions.ArialFont10;
            XSolidBrush black110 = XBrushes.Black;
            double num288 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point151 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num289 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect147 = new XRect(200.0, num288, point151, num289);
            XStringFormat topLeft147 = XStringFormat.TopLeft;
            xgraphics147.DrawString(str63, arialFont10_92, (XBrush) black110, xrect147, topLeft147);
            checked { L1ACheckList.RC1 += 13; }
            XGraphics xgraphics148 = PDFFunctions.gfx[L1ACheckList.k];
            string str64 = "Maximum: " + Conversions.ToString(Math.Round((double) num286, 2));
            XFont arialFont10_93 = PDFFunctions.ArialFont10;
            XSolidBrush black111 = XBrushes.Black;
            double num290 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point152 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num291 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect148 = new XRect(200.0, num290, point152, num291);
            XStringFormat topLeft148 = XStringFormat.TopLeft;
            xgraphics148.DrawString(str64, arialFont10_93, (XBrush) black111, xrect148, topLeft148);
            if ((double) num287 > (double) num286)
            {
              XGraphics xgraphics149 = PDFFunctions.gfx[L1ACheckList.k];
              XFont arialFont10Bold48 = PDFFunctions.ArialFont10Bold;
              XSolidBrush red = XBrushes.Red;
              double num292 = (double) checked (L1ACheckList.RC1 + 1);
              xunit = PDFFunctions.pages[L1ACheckList.k].Width;
              double point153 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[L1ACheckList.k].Height;
              double num293 = ((XUnit) ref xunit).Point / 2.0;
              XRect xrect149 = new XRect(540.0, num292, point153, num293);
              XStringFormat topLeft149 = XStringFormat.TopLeft;
              xgraphics149.DrawString("Fail", arialFont10Bold48, (XBrush) red, xrect149, topLeft149);
              flag2 = true;
              checked { L1ACheckList.RC1 += 13; }
            }
          }
          else
          {
            // ISSUE: reference to a compiler-generated field
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.SGroup, "Solid fuel boilers", false) == 0)
            {
              XGraphics xgraphics150 = PDFFunctions.gfx[L1ACheckList.k];
              // ISSUE: reference to a compiler-generated field
              string str65 = "Efficiency " + Microsoft.VisualBasic.Strings.Format((object) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.MainEff, "00.0") + " % ";
              XFont arialFont10_94 = PDFFunctions.ArialFont10;
              XSolidBrush black112 = XBrushes.Black;
              double num294 = (double) checked (L1ACheckList.RC1 + 1);
              xunit = PDFFunctions.pages[L1ACheckList.k].Width;
              double point154 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[L1ACheckList.k].Height;
              double num295 = ((XUnit) ref xunit).Point / 2.0;
              XRect xrect150 = new XRect(200.0, num294, point154, num295);
              XStringFormat topLeft150 = XStringFormat.TopLeft;
              xgraphics150.DrawString(str65, arialFont10_94, (XBrush) black112, xrect150, topLeft150);
              checked { L1ACheckList.RC1 += 13; }
            }
            else
            {
              // ISSUE: reference to a compiler-generated field
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.SGroup, "Heat pumps", false) != 0)
                ;
            }
          }
        }
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.InforSource, "Manufacturer Declaration", false) == 0)
        {
          // ISSUE: reference to a compiler-generated field
          int sapTableCode2 = SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.SAPTableCode;
          if (sapTableCode2 >= 301 && sapTableCode2 <= 311)
            checked { L1ACheckList.RC1 -= 13; }
          else if (sapTableCode2 < 150)
          {
            // ISSUE: reference to a compiler-generated field
            if (SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.SEDBUK2005)
            {
              XGraphics xgraphics151 = PDFFunctions.gfx[L1ACheckList.k];
              // ISSUE: reference to a compiler-generated field
              string str66 = "Efficiency " + Microsoft.VisualBasic.Strings.Format((object) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.MainEff, "00.0") + " % SEDBUK2005";
              XFont arialFont10_95 = PDFFunctions.ArialFont10;
              XSolidBrush black113 = XBrushes.Black;
              double num296 = (double) checked (L1ACheckList.RC1 + 1);
              xunit = PDFFunctions.pages[L1ACheckList.k].Width;
              double point155 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[L1ACheckList.k].Height;
              double num297 = ((XUnit) ref xunit).Point / 2.0;
              XRect xrect151 = new XRect(200.0, num296, point155, num297);
              XStringFormat topLeft151 = XStringFormat.TopLeft;
              xgraphics151.DrawString(str66, arialFont10_95, (XBrush) black113, xrect151, topLeft151);
            }
            else
            {
              XGraphics xgraphics152 = PDFFunctions.gfx[L1ACheckList.k];
              // ISSUE: reference to a compiler-generated field
              string str67 = "Efficiency " + Microsoft.VisualBasic.Strings.Format((object) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.MainEff, "00.0") + " % SEDBUK2009";
              XFont arialFont10_96 = PDFFunctions.ArialFont10;
              XSolidBrush black114 = XBrushes.Black;
              double num298 = (double) checked (L1ACheckList.RC1 + 1);
              xunit = PDFFunctions.pages[L1ACheckList.k].Width;
              double point156 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[L1ACheckList.k].Height;
              double num299 = ((XUnit) ref xunit).Point / 2.0;
              XRect xrect152 = new XRect(200.0, num298, point156, num299);
              XStringFormat topLeft152 = XStringFormat.TopLeft;
              xgraphics152.DrawString(str67, arialFont10_96, (XBrush) black114, xrect152, topLeft152);
            }
          }
          else
          {
            XGraphics xgraphics153 = PDFFunctions.gfx[L1ACheckList.k];
            // ISSUE: reference to a compiler-generated field
            string str68 = "Efficiency " + Microsoft.VisualBasic.Strings.Format((object) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.MainEff, "00.0");
            XFont arialFont10_97 = PDFFunctions.ArialFont10;
            XSolidBrush black115 = XBrushes.Black;
            double num300 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point157 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num301 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect153 = new XRect(200.0, num300, point157, num301);
            XStringFormat topLeft153 = XStringFormat.TopLeft;
            xgraphics153.DrawString(str68, arialFont10_97, (XBrush) black115, xrect153, topLeft153);
          }
          checked { L1ACheckList.RC1 += 13; }
        }
      }
      L1ACheckList.CheckCheckListRC1();
      // ISSUE: reference to a compiler-generated field
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.InforSource, "Boiler Database", false) == 0)
      {
        // ISSUE: reference to a compiler-generated field
        string sgroup = SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.SGroup;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(sgroup, "Solid fuel boilers", false) != 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(sgroup, "Micro-cogeneration (micro-CHP)", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(sgroup, "Heat pumps", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(sgroup, "Electric heat pumps", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(sgroup, "Gas-fired heat pumps", false) != 0)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(sgroup, "Gas boilers and oil boilers", false) == 0)
            {
              // ISSUE: reference to a compiler-generated field
              string fuel2 = SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.Fuel;
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel2, "bulk LPG", false) == 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel2, "Mains gas", false) == 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel2, "mains gas", false) == 0)
              {
                // ISSUE: reference to a compiler-generated field
                if (!SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.SEDBUK2005)
                {
                  XGraphics xgraphics154 = PDFFunctions.gfx[L1ACheckList.k];
                  XFont arialFont10_98 = PDFFunctions.ArialFont10;
                  XSolidBrush black116 = XBrushes.Black;
                  double num302 = (double) checked (L1ACheckList.RC1 + 1);
                  xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                  double point158 = ((XUnit) ref xunit).Point;
                  xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                  double num303 = ((XUnit) ref xunit).Point / 2.0;
                  XRect xrect154 = new XRect(200.0, num302, point158, num303);
                  XStringFormat topLeft154 = XStringFormat.TopLeft;
                  xgraphics154.DrawString("Minimum 88.0 %", arialFont10_98, (XBrush) black116, xrect154, topLeft154);
                }
                else
                {
                  XGraphics xgraphics155 = PDFFunctions.gfx[L1ACheckList.k];
                  XFont arialFont10_99 = PDFFunctions.ArialFont10;
                  XSolidBrush black117 = XBrushes.Black;
                  double num304 = (double) checked (L1ACheckList.RC1 + 1);
                  xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                  double point159 = ((XUnit) ref xunit).Point;
                  xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                  double num305 = ((XUnit) ref xunit).Point / 2.0;
                  XRect xrect155 = new XRect(200.0, num304, point159, num305);
                  XStringFormat topLeft155 = XStringFormat.TopLeft;
                  xgraphics155.DrawString("Minimum 90.0 %", arialFont10_99, (XBrush) black117, xrect155, topLeft155);
                }
              }
              else
              {
                XGraphics xgraphics156 = PDFFunctions.gfx[L1ACheckList.k];
                XFont arialFont10_100 = PDFFunctions.ArialFont10;
                XSolidBrush black118 = XBrushes.Black;
                double num306 = (double) checked (L1ACheckList.RC1 + 1);
                xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                double point160 = ((XUnit) ref xunit).Point;
                xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                double num307 = ((XUnit) ref xunit).Point / 2.0;
                XRect xrect156 = new XRect(200.0, num306, point160, num307);
                XStringFormat topLeft156 = XStringFormat.TopLeft;
                xgraphics156.DrawString("Minimum 80.0 %", arialFont10_100, (XBrush) black118, xrect156, topLeft156);
              }
            }
            else
            {
              XGraphics xgraphics157 = PDFFunctions.gfx[L1ACheckList.k];
              XFont arialFont10_101 = PDFFunctions.ArialFont10;
              XSolidBrush black119 = XBrushes.Black;
              double num308 = (double) checked (L1ACheckList.RC1 + 1);
              xunit = PDFFunctions.pages[L1ACheckList.k].Width;
              double point161 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[L1ACheckList.k].Height;
              double num309 = ((XUnit) ref xunit).Point / 2.0;
              XRect xrect157 = new XRect(200.0, num308, point161, num309);
              XStringFormat topLeft157 = XStringFormat.TopLeft;
              xgraphics157.DrawString("Minimum 88.0 %", arialFont10_101, (XBrush) black119, xrect157, topLeft157);
            }
          }
        }
        else
        {
          XGraphics xgraphics158 = PDFFunctions.gfx[L1ACheckList.k];
          XFont arialFont10_102 = PDFFunctions.ArialFont10;
          XSolidBrush black120 = XBrushes.Black;
          double num310 = (double) checked (L1ACheckList.RC1 + 1);
          xunit = PDFFunctions.pages[L1ACheckList.k].Width;
          double point162 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[L1ACheckList.k].Height;
          double num311 = ((XUnit) ref xunit).Point / 2.0;
          XRect xrect158 = new XRect(200.0, num310, point162, num311);
          XStringFormat topLeft158 = XStringFormat.TopLeft;
          xgraphics158.DrawString("Minimum 67.0 %", arialFont10_102, (XBrush) black120, xrect158, topLeft158);
        }
        L1ACheckList.CheckCheckListRC1();
        // ISSUE: reference to a compiler-generated field
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.SGroup, "Gas boilers and oil boilers", false) == 0)
        {
          // ISSUE: reference to a compiler-generated field
          string fuel3 = SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.Fuel;
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel3, "mains gas", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel3, "bulk LPG", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel3, "LPG subject to Special Condition 18", false) != 0)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel3, "heating oil", false) == 0)
            {
              // ISSUE: reference to a compiler-generated field
              if ((double) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.MainEff < 80.0)
              {
                XGraphics xgraphics159 = PDFFunctions.gfx[L1ACheckList.k];
                XFont arialFont10Bold49 = PDFFunctions.ArialFont10Bold;
                XSolidBrush red = XBrushes.Red;
                double num312 = (double) checked (L1ACheckList.RC1 + 1);
                xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                double point163 = ((XUnit) ref xunit).Point;
                xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                double num313 = ((XUnit) ref xunit).Point / 2.0;
                XRect xrect159 = new XRect(540.0, num312, point163, num313);
                XStringFormat topLeft159 = XStringFormat.TopLeft;
                xgraphics159.DrawString("Fail", arialFont10Bold49, (XBrush) red, xrect159, topLeft159);
                flag2 = true;
              }
              else
              {
                XGraphics xgraphics160 = PDFFunctions.gfx[L1ACheckList.k];
                XFont arialFont10Bold50 = PDFFunctions.ArialFont10Bold;
                XSolidBrush green = XBrushes.Green;
                double num314 = (double) checked (L1ACheckList.RC1 + 1);
                xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                double point164 = ((XUnit) ref xunit).Point;
                xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                double num315 = ((XUnit) ref xunit).Point / 2.0;
                XRect xrect160 = new XRect(540.0, num314, point164, num315);
                XStringFormat topLeft160 = XStringFormat.TopLeft;
                xgraphics160.DrawString("OK", arialFont10Bold50, (XBrush) green, xrect160, topLeft160);
              }
            }
          }
          else
          {
            // ISSUE: reference to a compiler-generated field
            if ((double) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.MainEff < 88.0)
            {
              XGraphics xgraphics161 = PDFFunctions.gfx[L1ACheckList.k];
              XFont arialFont10Bold51 = PDFFunctions.ArialFont10Bold;
              XSolidBrush red = XBrushes.Red;
              double num316 = (double) checked (L1ACheckList.RC1 + 1);
              xunit = PDFFunctions.pages[L1ACheckList.k].Width;
              double point165 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[L1ACheckList.k].Height;
              double num317 = ((XUnit) ref xunit).Point / 2.0;
              XRect xrect161 = new XRect(540.0, num316, point165, num317);
              XStringFormat topLeft161 = XStringFormat.TopLeft;
              xgraphics161.DrawString("Fail", arialFont10Bold51, (XBrush) red, xrect161, topLeft161);
              flag2 = true;
            }
            else
            {
              XGraphics xgraphics162 = PDFFunctions.gfx[L1ACheckList.k];
              XFont arialFont10Bold52 = PDFFunctions.ArialFont10Bold;
              XSolidBrush green = XBrushes.Green;
              double num318 = (double) checked (L1ACheckList.RC1 + 1);
              xunit = PDFFunctions.pages[L1ACheckList.k].Width;
              double point166 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[L1ACheckList.k].Height;
              double num319 = ((XUnit) ref xunit).Point / 2.0;
              XRect xrect162 = new XRect(540.0, num318, point166, num319);
              XStringFormat topLeft162 = XStringFormat.TopLeft;
              xgraphics162.DrawString("OK", arialFont10Bold52, (XBrush) green, xrect162, topLeft162);
            }
          }
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.SGroup, "Micro-cogeneration (micro-CHP)", false) == 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.SGroup, "Solid fuel boilers", false) != 0)
            ;
        }
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        int sapTableCode3 = SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.SAPTableCode;
        if (sapTableCode3 >= 101 && sapTableCode3 <= 123)
        {
          // ISSUE: reference to a compiler-generated field
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.InforSource, "Manufacturer Declaration", false) == 0)
          {
            // ISSUE: reference to a compiler-generated field
            if (SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.SEDBUK2005)
            {
              XGraphics xgraphics163 = PDFFunctions.gfx[L1ACheckList.k];
              XFont arialFont10_103 = PDFFunctions.ArialFont10;
              XSolidBrush black121 = XBrushes.Black;
              double num320 = (double) checked (L1ACheckList.RC1 + 1);
              xunit = PDFFunctions.pages[L1ACheckList.k].Width;
              double point167 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[L1ACheckList.k].Height;
              double num321 = ((XUnit) ref xunit).Point / 2.0;
              XRect xrect163 = new XRect(200.0, num320, point167, num321);
              XStringFormat topLeft163 = XStringFormat.TopLeft;
              xgraphics163.DrawString("Minimum 90.0 %", arialFont10_103, (XBrush) black121, xrect163, topLeft163);
              // ISSUE: reference to a compiler-generated field
              if ((double) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.MainEff < 90.0)
              {
                XGraphics xgraphics164 = PDFFunctions.gfx[L1ACheckList.k];
                XFont arialFont10Bold53 = PDFFunctions.ArialFont10Bold;
                XSolidBrush red = XBrushes.Red;
                double num322 = (double) checked (L1ACheckList.RC1 + 1);
                xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                double point168 = ((XUnit) ref xunit).Point;
                xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                double num323 = ((XUnit) ref xunit).Point / 2.0;
                XRect xrect164 = new XRect(540.0, num322, point168, num323);
                XStringFormat topLeft164 = XStringFormat.TopLeft;
                xgraphics164.DrawString("Fail", arialFont10Bold53, (XBrush) red, xrect164, topLeft164);
                flag2 = true;
              }
              else
              {
                XGraphics xgraphics165 = PDFFunctions.gfx[L1ACheckList.k];
                XFont arialFont10Bold54 = PDFFunctions.ArialFont10Bold;
                XSolidBrush green = XBrushes.Green;
                double num324 = (double) checked (L1ACheckList.RC1 + 1);
                xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                double point169 = ((XUnit) ref xunit).Point;
                xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                double num325 = ((XUnit) ref xunit).Point / 2.0;
                XRect xrect165 = new XRect(540.0, num324, point169, num325);
                XStringFormat topLeft165 = XStringFormat.TopLeft;
                xgraphics165.DrawString("OK", arialFont10Bold54, (XBrush) green, xrect165, topLeft165);
              }
            }
            else
            {
              XGraphics xgraphics166 = PDFFunctions.gfx[L1ACheckList.k];
              XFont arialFont10_104 = PDFFunctions.ArialFont10;
              XSolidBrush black122 = XBrushes.Black;
              double num326 = (double) checked (L1ACheckList.RC1 + 1);
              xunit = PDFFunctions.pages[L1ACheckList.k].Width;
              double point170 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[L1ACheckList.k].Height;
              double num327 = ((XUnit) ref xunit).Point / 2.0;
              XRect xrect166 = new XRect(200.0, num326, point170, num327);
              XStringFormat topLeft166 = XStringFormat.TopLeft;
              xgraphics166.DrawString("Minimum 88.0 %", arialFont10_104, (XBrush) black122, xrect166, topLeft166);
              // ISSUE: reference to a compiler-generated field
              if ((double) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.MainEff < 88.0)
              {
                XGraphics xgraphics167 = PDFFunctions.gfx[L1ACheckList.k];
                XFont arialFont10Bold55 = PDFFunctions.ArialFont10Bold;
                XSolidBrush red = XBrushes.Red;
                double num328 = (double) checked (L1ACheckList.RC1 + 1);
                xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                double point171 = ((XUnit) ref xunit).Point;
                xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                double num329 = ((XUnit) ref xunit).Point / 2.0;
                XRect xrect167 = new XRect(540.0, num328, point171, num329);
                XStringFormat topLeft167 = XStringFormat.TopLeft;
                xgraphics167.DrawString("Fail", arialFont10Bold55, (XBrush) red, xrect167, topLeft167);
                flag2 = true;
              }
              else
              {
                XGraphics xgraphics168 = PDFFunctions.gfx[L1ACheckList.k];
                XFont arialFont10Bold56 = PDFFunctions.ArialFont10Bold;
                XSolidBrush green = XBrushes.Green;
                double num330 = (double) checked (L1ACheckList.RC1 + 1);
                xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                double point172 = ((XUnit) ref xunit).Point;
                xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                double num331 = ((XUnit) ref xunit).Point / 2.0;
                XRect xrect168 = new XRect(540.0, num330, point172, num331);
                XStringFormat topLeft168 = XStringFormat.TopLeft;
                xgraphics168.DrawString("OK", arialFont10Bold56, (XBrush) green, xrect168, topLeft168);
              }
            }
          }
          else
          {
            XGraphics xgraphics169 = PDFFunctions.gfx[L1ACheckList.k];
            XFont arialFont10_105 = PDFFunctions.ArialFont10;
            XSolidBrush black123 = XBrushes.Black;
            double num332 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point173 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num333 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect169 = new XRect(200.0, num332, point173, num333);
            XStringFormat topLeft169 = XStringFormat.TopLeft;
            xgraphics169.DrawString("SAP default data", arialFont10_105, (XBrush) black123, xrect169, topLeft169);
            XGraphics xgraphics170 = PDFFunctions.gfx[L1ACheckList.k];
            XFont arialFont10Bold57 = PDFFunctions.ArialFont10Bold;
            XSolidBrush red = XBrushes.Red;
            double num334 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point174 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num335 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect170 = new XRect(540.0, num334, point174, num335);
            XStringFormat topLeft170 = XStringFormat.TopLeft;
            xgraphics170.DrawString("Fail", arialFont10Bold57, (XBrush) red, xrect170, topLeft170);
            flag2 = true;
          }
        }
        else if (sapTableCode3 >= 128 && sapTableCode3 <= 130)
        {
          XGraphics xgraphics171 = PDFFunctions.gfx[L1ACheckList.k];
          XFont arialFont10_106 = PDFFunctions.ArialFont10;
          XSolidBrush black124 = XBrushes.Black;
          double num336 = (double) checked (L1ACheckList.RC1 + 1);
          xunit = PDFFunctions.pages[L1ACheckList.k].Width;
          double point175 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[L1ACheckList.k].Height;
          double num337 = ((XUnit) ref xunit).Point / 2.0;
          XRect xrect171 = new XRect(200.0, num336, point175, num337);
          XStringFormat topLeft171 = XStringFormat.TopLeft;
          xgraphics171.DrawString("Minimum 86.0 %", arialFont10_106, (XBrush) black124, xrect171, topLeft171);
          checked { L1ACheckList.RC1 += 13; }
          // ISSUE: reference to a compiler-generated field
          if ((double) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.MainEff < 86.0)
          {
            XGraphics xgraphics172 = PDFFunctions.gfx[L1ACheckList.k];
            XFont arialFont10Bold58 = PDFFunctions.ArialFont10Bold;
            XSolidBrush red = XBrushes.Red;
            double num338 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point176 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num339 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect172 = new XRect(540.0, num338, point176, num339);
            XStringFormat topLeft172 = XStringFormat.TopLeft;
            xgraphics172.DrawString("Fail", arialFont10Bold58, (XBrush) red, xrect172, topLeft172);
            flag2 = true;
          }
          else
          {
            XGraphics xgraphics173 = PDFFunctions.gfx[L1ACheckList.k];
            XFont arialFont10Bold59 = PDFFunctions.ArialFont10Bold;
            XSolidBrush green = XBrushes.Green;
            double num340 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point177 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num341 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect173 = new XRect(540.0, num340, point177, num341);
            XStringFormat topLeft173 = XStringFormat.TopLeft;
            xgraphics173.DrawString("OK", arialFont10Bold59, (XBrush) green, xrect173, topLeft173);
          }
        }
        else if (sapTableCode3 == 124 || sapTableCode3 == 125 || sapTableCode3 == 126 || sapTableCode3 == (int) sbyte.MaxValue)
        {
          // ISSUE: reference to a compiler-generated field
          double num342 = !SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.SEDBUK2005 ? 88.0 : 90.0;
          XGraphics xgraphics174 = PDFFunctions.gfx[L1ACheckList.k];
          string str69 = "Minimum " + Conversions.ToString(num342) + " %";
          XFont arialFont10_107 = PDFFunctions.ArialFont10;
          XSolidBrush black125 = XBrushes.Black;
          double num343 = (double) checked (L1ACheckList.RC1 + 1);
          xunit = PDFFunctions.pages[L1ACheckList.k].Width;
          double point178 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[L1ACheckList.k].Height;
          double num344 = ((XUnit) ref xunit).Point / 2.0;
          XRect xrect174 = new XRect(200.0, num343, point178, num344);
          XStringFormat topLeft174 = XStringFormat.TopLeft;
          xgraphics174.DrawString(str69, arialFont10_107, (XBrush) black125, xrect174, topLeft174);
          checked { L1ACheckList.RC1 += 13; }
          // ISSUE: reference to a compiler-generated field
          if ((double) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.MainEff < num342)
          {
            XGraphics xgraphics175 = PDFFunctions.gfx[L1ACheckList.k];
            XFont arialFont10Bold60 = PDFFunctions.ArialFont10Bold;
            XSolidBrush red = XBrushes.Red;
            double num345 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point179 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num346 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect175 = new XRect(540.0, num345, point179, num346);
            XStringFormat topLeft175 = XStringFormat.TopLeft;
            xgraphics175.DrawString("Fail", arialFont10Bold60, (XBrush) red, xrect175, topLeft175);
            flag2 = true;
          }
          else
          {
            XGraphics xgraphics176 = PDFFunctions.gfx[L1ACheckList.k];
            XFont arialFont10Bold61 = PDFFunctions.ArialFont10Bold;
            XSolidBrush green = XBrushes.Green;
            double num347 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point180 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num348 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect176 = new XRect(540.0, num347, point180, num348);
            XStringFormat topLeft176 = XStringFormat.TopLeft;
            xgraphics176.DrawString("OK", arialFont10Bold61, (XBrush) green, xrect176, topLeft176);
          }
        }
        else if (sapTableCode3 >= 131 && sapTableCode3 <= 132)
        {
          XGraphics xgraphics177 = PDFFunctions.gfx[L1ACheckList.k];
          XFont arialFont10_108 = PDFFunctions.ArialFont10;
          XSolidBrush black126 = XBrushes.Black;
          double num349 = (double) checked (L1ACheckList.RC1 + 1);
          xunit = PDFFunctions.pages[L1ACheckList.k].Width;
          double point181 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[L1ACheckList.k].Height;
          double num350 = ((XUnit) ref xunit).Point / 2.0;
          XRect xrect177 = new XRect(200.0, num349, point181, num350);
          XStringFormat topLeft177 = XStringFormat.TopLeft;
          xgraphics177.DrawString("Minimum 60.0 %", arialFont10_108, (XBrush) black126, xrect177, topLeft177);
          checked { L1ACheckList.RC1 += 13; }
          // ISSUE: reference to a compiler-generated field
          if ((double) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.MainEff < 60.0)
          {
            XGraphics xgraphics178 = PDFFunctions.gfx[L1ACheckList.k];
            XFont arialFont10Bold62 = PDFFunctions.ArialFont10Bold;
            XSolidBrush red = XBrushes.Red;
            double num351 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point182 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num352 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect178 = new XRect(540.0, num351, point182, num352);
            XStringFormat topLeft178 = XStringFormat.TopLeft;
            xgraphics178.DrawString("Fail", arialFont10Bold62, (XBrush) red, xrect178, topLeft178);
            flag2 = true;
          }
          else
          {
            XGraphics xgraphics179 = PDFFunctions.gfx[L1ACheckList.k];
            XFont arialFont10Bold63 = PDFFunctions.ArialFont10Bold;
            XSolidBrush green = XBrushes.Green;
            double num353 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point183 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num354 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect179 = new XRect(540.0, num353, point183, num354);
            XStringFormat topLeft179 = XStringFormat.TopLeft;
            xgraphics179.DrawString("OK", arialFont10Bold63, (XBrush) green, xrect179, topLeft179);
          }
        }
        else if (sapTableCode3 >= 133 && sapTableCode3 <= 138)
        {
          // ISSUE: reference to a compiler-generated field
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.InforSource, "Manufacturer Declaration", false) == 0)
          {
            XGraphics xgraphics180 = PDFFunctions.gfx[L1ACheckList.k];
            XFont arialFont10_109 = PDFFunctions.ArialFont10;
            XSolidBrush black127 = XBrushes.Black;
            double num355 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point184 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num356 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect180 = new XRect(200.0, num355, point184, num356);
            XStringFormat topLeft180 = XStringFormat.TopLeft;
            xgraphics180.DrawString("Minimum 75.0 %", arialFont10_109, (XBrush) black127, xrect180, topLeft180);
            checked { L1ACheckList.RC1 += 13; }
            // ISSUE: reference to a compiler-generated field
            if ((double) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.MainEff < 75.0)
            {
              XGraphics xgraphics181 = PDFFunctions.gfx[L1ACheckList.k];
              XFont arialFont10Bold64 = PDFFunctions.ArialFont10Bold;
              XSolidBrush red = XBrushes.Red;
              double num357 = (double) checked (L1ACheckList.RC1 + 1);
              xunit = PDFFunctions.pages[L1ACheckList.k].Width;
              double point185 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[L1ACheckList.k].Height;
              double num358 = ((XUnit) ref xunit).Point / 2.0;
              XRect xrect181 = new XRect(540.0, num357, point185, num358);
              XStringFormat topLeft181 = XStringFormat.TopLeft;
              xgraphics181.DrawString("Fail", arialFont10Bold64, (XBrush) red, xrect181, topLeft181);
              flag2 = true;
            }
            else
            {
              XGraphics xgraphics182 = PDFFunctions.gfx[L1ACheckList.k];
              XFont arialFont10Bold65 = PDFFunctions.ArialFont10Bold;
              XSolidBrush green = XBrushes.Green;
              double num359 = (double) checked (L1ACheckList.RC1 + 1);
              xunit = PDFFunctions.pages[L1ACheckList.k].Width;
              double point186 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[L1ACheckList.k].Height;
              double num360 = ((XUnit) ref xunit).Point / 2.0;
              XRect xrect182 = new XRect(540.0, num359, point186, num360);
              XStringFormat topLeft182 = XStringFormat.TopLeft;
              xgraphics182.DrawString("OK", arialFont10Bold65, (XBrush) green, xrect182, topLeft182);
            }
          }
          L1ACheckList.CheckCheckListRC1();
        }
        else if (sapTableCode3 != 191 && (sapTableCode3 < 421 || sapTableCode3 > 425) && (sapTableCode3 < 691 || sapTableCode3 > 694) && sapTableCode3 != 515 && (sapTableCode3 < 211 || sapTableCode3 > 224) && (sapTableCode3 < 401 || sapTableCode3 > 409))
        {
          if (sapTableCode3 >= 133 && sapTableCode3 <= 138)
          {
            // ISSUE: reference to a compiler-generated field
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.InforSource, "SAP Tables", false) == 0)
            {
              XGraphics xgraphics183 = PDFFunctions.gfx[L1ACheckList.k];
              // ISSUE: reference to a compiler-generated field
              string str70 = "Efficiency " + Microsoft.VisualBasic.Strings.Format((object) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.MainEff, "00.0") + " %";
              XFont arialFont10_110 = PDFFunctions.ArialFont10;
              XSolidBrush black128 = XBrushes.Black;
              double num361 = (double) checked (L1ACheckList.RC1 + 1);
              xunit = PDFFunctions.pages[L1ACheckList.k].Width;
              double point187 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[L1ACheckList.k].Height;
              double num362 = ((XUnit) ref xunit).Point / 2.0;
              XRect xrect183 = new XRect(200.0, num361, point187, num362);
              XStringFormat topLeft183 = XStringFormat.TopLeft;
              xgraphics183.DrawString(str70, arialFont10_110, (XBrush) black128, xrect183, topLeft183);
              checked { L1ACheckList.RC1 += 13; }
            }
            XGraphics xgraphics184 = PDFFunctions.gfx[L1ACheckList.k];
            XFont arialFont10_111 = PDFFunctions.ArialFont10;
            XSolidBrush black129 = XBrushes.Black;
            double num363 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point188 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num364 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect184 = new XRect(200.0, num363, point188, num364);
            XStringFormat topLeft184 = XStringFormat.TopLeft;
            xgraphics184.DrawString("Minimum 75.0 %", arialFont10_111, (XBrush) black129, xrect184, topLeft184);
            checked { L1ACheckList.RC1 += 13; }
            // ISSUE: reference to a compiler-generated field
            if ((double) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.MainEff < 75.0)
            {
              XGraphics xgraphics185 = PDFFunctions.gfx[L1ACheckList.k];
              XFont arialFont10Bold66 = PDFFunctions.ArialFont10Bold;
              XSolidBrush red = XBrushes.Red;
              double num365 = (double) checked (L1ACheckList.RC1 + 1);
              xunit = PDFFunctions.pages[L1ACheckList.k].Width;
              double point189 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[L1ACheckList.k].Height;
              double num366 = ((XUnit) ref xunit).Point / 2.0;
              XRect xrect185 = new XRect(540.0, num365, point189, num366);
              XStringFormat topLeft185 = XStringFormat.TopLeft;
              xgraphics185.DrawString("Fail", arialFont10Bold66, (XBrush) red, xrect185, topLeft185);
              flag2 = true;
            }
            else
            {
              XGraphics xgraphics186 = PDFFunctions.gfx[L1ACheckList.k];
              XFont arialFont10Bold67 = PDFFunctions.ArialFont10Bold;
              XSolidBrush green = XBrushes.Green;
              double num367 = (double) checked (L1ACheckList.RC1 + 1);
              xunit = PDFFunctions.pages[L1ACheckList.k].Width;
              double point190 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[L1ACheckList.k].Height;
              double num368 = ((XUnit) ref xunit).Point / 2.0;
              XRect xrect186 = new XRect(540.0, num367, point190, num368);
              XStringFormat topLeft186 = XStringFormat.TopLeft;
              xgraphics186.DrawString("OK", arialFont10Bold67, (XBrush) green, xrect186, topLeft186);
            }
          }
          else if (sapTableCode3 >= 139 && sapTableCode3 <= 141)
          {
            XGraphics xgraphics187 = PDFFunctions.gfx[L1ACheckList.k];
            XFont arialFont10_112 = PDFFunctions.ArialFont10;
            XSolidBrush black130 = XBrushes.Black;
            double num369 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point191 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num370 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect187 = new XRect(200.0, num369, point191, num370);
            XStringFormat topLeft187 = XStringFormat.TopLeft;
            xgraphics187.DrawString("Minimum 80.0 %", arialFont10_112, (XBrush) black130, xrect187, topLeft187);
            checked { L1ACheckList.RC1 += 13; }
            // ISSUE: reference to a compiler-generated field
            if ((double) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.MainEff < 80.0)
            {
              XGraphics xgraphics188 = PDFFunctions.gfx[L1ACheckList.k];
              XFont arialFont10_113 = PDFFunctions.ArialFont10;
              XSolidBrush black131 = XBrushes.Black;
              double num371 = (double) checked (L1ACheckList.RC1 + 1);
              xunit = PDFFunctions.pages[L1ACheckList.k].Width;
              double point192 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[L1ACheckList.k].Height;
              double num372 = ((XUnit) ref xunit).Point / 2.0;
              XRect xrect188 = new XRect(200.0, num371, point192, num372);
              XStringFormat topLeft188 = XStringFormat.TopLeft;
              xgraphics188.DrawString("SAP default data", arialFont10_113, (XBrush) black131, xrect188, topLeft188);
              XGraphics xgraphics189 = PDFFunctions.gfx[L1ACheckList.k];
              XFont arialFont10Bold68 = PDFFunctions.ArialFont10Bold;
              XSolidBrush red = XBrushes.Red;
              double num373 = (double) checked (L1ACheckList.RC1 + 1);
              xunit = PDFFunctions.pages[L1ACheckList.k].Width;
              double point193 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[L1ACheckList.k].Height;
              double num374 = ((XUnit) ref xunit).Point / 2.0;
              XRect xrect189 = new XRect(540.0, num373, point193, num374);
              XStringFormat topLeft189 = XStringFormat.TopLeft;
              xgraphics189.DrawString("Fail", arialFont10Bold68, (XBrush) red, xrect189, topLeft189);
              flag2 = true;
            }
            else
            {
              XGraphics xgraphics190 = PDFFunctions.gfx[L1ACheckList.k];
              XFont arialFont10Bold69 = PDFFunctions.ArialFont10Bold;
              XSolidBrush green = XBrushes.Green;
              double num375 = (double) checked (L1ACheckList.RC1 + 1);
              xunit = PDFFunctions.pages[L1ACheckList.k].Width;
              double point194 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[L1ACheckList.k].Height;
              double num376 = ((XUnit) ref xunit).Point / 2.0;
              XRect xrect190 = new XRect(540.0, num375, point194, num376);
              XStringFormat topLeft190 = XStringFormat.TopLeft;
              xgraphics190.DrawString("OK", arialFont10Bold69, (XBrush) green, xrect190, topLeft190);
            }
          }
          else if (sapTableCode3 >= 151 && sapTableCode3 <= 161)
          {
            float Expression4;
            // ISSUE: reference to a compiler-generated field
            switch (SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.SAPTableCode)
            {
              case 151:
                Expression4 = 65f;
                break;
              case 152:
                Expression4 = 60f;
                break;
              case 153:
                Expression4 = 70f;
                break;
              case 154:
                Expression4 = 65f;
                break;
              case 155:
                Expression4 = 65f;
                break;
              case 156:
                Expression4 = 63f;
                break;
              case 158:
                Expression4 = 67f;
                break;
              case 159:
                Expression4 = 65f;
                break;
              case 160:
                Expression4 = 50f;
                break;
              case 161:
                Expression4 = 60f;
                break;
            }
            // ISSUE: reference to a compiler-generated field
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.Fuel, "wood pellets (bulk supply in bags, for main heating)", false) == 0)
              Expression4 = 75f;
            // ISSUE: reference to a compiler-generated field
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.InforSource, "SAP Tables", false) == 0)
            {
              XGraphics xgraphics191 = PDFFunctions.gfx[L1ACheckList.k];
              // ISSUE: reference to a compiler-generated field
              string str71 = "Efficiency " + Microsoft.VisualBasic.Strings.Format((object) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.MainEff, "00.0") + " %";
              XFont arialFont10_114 = PDFFunctions.ArialFont10;
              XSolidBrush black132 = XBrushes.Black;
              double num377 = (double) checked (L1ACheckList.RC1 + 1);
              xunit = PDFFunctions.pages[L1ACheckList.k].Width;
              double point195 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[L1ACheckList.k].Height;
              double num378 = ((XUnit) ref xunit).Point / 2.0;
              XRect xrect191 = new XRect(200.0, num377, point195, num378);
              XStringFormat topLeft191 = XStringFormat.TopLeft;
              xgraphics191.DrawString(str71, arialFont10_114, (XBrush) black132, xrect191, topLeft191);
              checked { L1ACheckList.RC1 += 13; }
            }
            XGraphics xgraphics192 = PDFFunctions.gfx[L1ACheckList.k];
            string str72 = "Minimum " + Microsoft.VisualBasic.Strings.Format((object) Expression4, "00.0") + " %";
            XFont arialFont10_115 = PDFFunctions.ArialFont10;
            XSolidBrush black133 = XBrushes.Black;
            double num379 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point196 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num380 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect192 = new XRect(200.0, num379, point196, num380);
            XStringFormat topLeft192 = XStringFormat.TopLeft;
            xgraphics192.DrawString(str72, arialFont10_115, (XBrush) black133, xrect192, topLeft192);
            checked { L1ACheckList.RC1 += 13; }
            // ISSUE: reference to a compiler-generated field
            if ((double) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.MainEff < (double) Expression4)
            {
              XGraphics xgraphics193 = PDFFunctions.gfx[L1ACheckList.k];
              XFont arialFont10Bold70 = PDFFunctions.ArialFont10Bold;
              XSolidBrush red = XBrushes.Red;
              double num381 = (double) checked (L1ACheckList.RC1 + 1);
              xunit = PDFFunctions.pages[L1ACheckList.k].Width;
              double point197 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[L1ACheckList.k].Height;
              double num382 = ((XUnit) ref xunit).Point / 2.0;
              XRect xrect193 = new XRect(540.0, num381, point197, num382);
              XStringFormat topLeft193 = XStringFormat.TopLeft;
              xgraphics193.DrawString("Fail", arialFont10Bold70, (XBrush) red, xrect193, topLeft193);
              flag2 = true;
            }
            else
            {
              XGraphics xgraphics194 = PDFFunctions.gfx[L1ACheckList.k];
              XFont arialFont10Bold71 = PDFFunctions.ArialFont10Bold;
              XSolidBrush green = XBrushes.Green;
              double num383 = (double) checked (L1ACheckList.RC1 + 1);
              xunit = PDFFunctions.pages[L1ACheckList.k].Width;
              double point198 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[L1ACheckList.k].Height;
              double num384 = ((XUnit) ref xunit).Point / 2.0;
              XRect xrect194 = new XRect(540.0, num383, point198, num384);
              XStringFormat topLeft194 = XStringFormat.TopLeft;
              xgraphics194.DrawString("OK", arialFont10Bold71, (XBrush) green, xrect194, topLeft194);
            }
          }
          else if ((sapTableCode3 < 305 || sapTableCode3 > 310) && sapTableCode3 != 701)
          {
            if (sapTableCode3 >= 501 && sapTableCode3 <= 511)
            {
              // ISSUE: reference to a compiler-generated field
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.InforSource, "SAP Tables", false) == 0)
              {
                XGraphics xgraphics195 = PDFFunctions.gfx[L1ACheckList.k];
                // ISSUE: reference to a compiler-generated field
                string str73 = "Efficiency " + Microsoft.VisualBasic.Strings.Format((object) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.MainEff, "00.0") + " %";
                XFont arialFont10_116 = PDFFunctions.ArialFont10;
                XSolidBrush black134 = XBrushes.Black;
                double num385 = (double) checked (L1ACheckList.RC1 + 1);
                xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                double point199 = ((XUnit) ref xunit).Point;
                xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                double num386 = ((XUnit) ref xunit).Point / 2.0;
                XRect xrect195 = new XRect(200.0, num385, point199, num386);
                XStringFormat topLeft195 = XStringFormat.TopLeft;
                xgraphics195.DrawString(str73, arialFont10_116, (XBrush) black134, xrect195, topLeft195);
                checked { L1ACheckList.RC1 += 13; }
              }
              XGraphics xgraphics196 = PDFFunctions.gfx[L1ACheckList.k];
              XFont arialFont10_117 = PDFFunctions.ArialFont10;
              XSolidBrush black135 = XBrushes.Black;
              double num387 = (double) checked (L1ACheckList.RC1 + 1);
              xunit = PDFFunctions.pages[L1ACheckList.k].Width;
              double point200 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[L1ACheckList.k].Height;
              double num388 = ((XUnit) ref xunit).Point / 2.0;
              XRect xrect196 = new XRect(200.0, num387, point200, num388);
              XStringFormat topLeft196 = XStringFormat.TopLeft;
              xgraphics196.DrawString("Minimum 76.0 %", arialFont10_117, (XBrush) black135, xrect196, topLeft196);
              // ISSUE: reference to a compiler-generated field
              if ((double) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.MainEff < 76.0)
              {
                XGraphics xgraphics197 = PDFFunctions.gfx[L1ACheckList.k];
                XFont arialFont10Bold72 = PDFFunctions.ArialFont10Bold;
                XSolidBrush red = XBrushes.Red;
                double num389 = (double) checked (L1ACheckList.RC1 + 1);
                xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                double point201 = ((XUnit) ref xunit).Point;
                xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                double num390 = ((XUnit) ref xunit).Point / 2.0;
                XRect xrect197 = new XRect(540.0, num389, point201, num390);
                XStringFormat topLeft197 = XStringFormat.TopLeft;
                xgraphics197.DrawString("Fail", arialFont10Bold72, (XBrush) red, xrect197, topLeft197);
                flag2 = true;
              }
              else
              {
                XGraphics xgraphics198 = PDFFunctions.gfx[L1ACheckList.k];
                XFont arialFont10Bold73 = PDFFunctions.ArialFont10Bold;
                XSolidBrush green = XBrushes.Green;
                double num391 = (double) checked (L1ACheckList.RC1 + 1);
                xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                double point202 = ((XUnit) ref xunit).Point;
                xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                double num392 = ((XUnit) ref xunit).Point / 2.0;
                XRect xrect198 = new XRect(540.0, num391, point202, num392);
                XStringFormat topLeft198 = XStringFormat.TopLeft;
                xgraphics198.DrawString("OK", arialFont10Bold73, (XBrush) green, xrect198, topLeft198);
              }
            }
            else if (sapTableCode3 == 632 || sapTableCode3 == 634 || sapTableCode3 == 636)
            {
              // ISSUE: reference to a compiler-generated field
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.InforSource, "SAP Tables", false) == 0)
              {
                XGraphics xgraphics199 = PDFFunctions.gfx[L1ACheckList.k];
                // ISSUE: reference to a compiler-generated field
                string str74 = "Efficiency " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.MainEff) + " %";
                XFont arialFont10_118 = PDFFunctions.ArialFont10;
                XSolidBrush black136 = XBrushes.Black;
                double num393 = (double) checked (L1ACheckList.RC1 + 1);
                xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                double point203 = ((XUnit) ref xunit).Point;
                xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                double num394 = ((XUnit) ref xunit).Point / 2.0;
                XRect xrect199 = new XRect(200.0, num393, point203, num394);
                XStringFormat topLeft199 = XStringFormat.TopLeft;
                xgraphics199.DrawString(str74, arialFont10_118, (XBrush) black136, xrect199, topLeft199);
                checked { L1ACheckList.RC1 += 13; }
              }
              XGraphics xgraphics200 = PDFFunctions.gfx[L1ACheckList.k];
              XFont arialFont10_119 = PDFFunctions.ArialFont10;
              XSolidBrush black137 = XBrushes.Black;
              double num395 = (double) checked (L1ACheckList.RC1 + 1);
              xunit = PDFFunctions.pages[L1ACheckList.k].Width;
              double point204 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[L1ACheckList.k].Height;
              double num396 = ((XUnit) ref xunit).Point / 2.0;
              XRect xrect200 = new XRect(200.0, num395, point204, num396);
              XStringFormat topLeft200 = XStringFormat.TopLeft;
              xgraphics200.DrawString("Minimum 65.0 %", arialFont10_119, (XBrush) black137, xrect200, topLeft200);
              // ISSUE: reference to a compiler-generated field
              if ((double) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.MainEff < 65.0)
              {
                XGraphics xgraphics201 = PDFFunctions.gfx[L1ACheckList.k];
                XFont arialFont10Bold74 = PDFFunctions.ArialFont10Bold;
                XSolidBrush red = XBrushes.Red;
                double num397 = (double) checked (L1ACheckList.RC1 + 1);
                xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                double point205 = ((XUnit) ref xunit).Point;
                xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                double num398 = ((XUnit) ref xunit).Point / 2.0;
                XRect xrect201 = new XRect(540.0, num397, point205, num398);
                XStringFormat topLeft201 = XStringFormat.TopLeft;
                xgraphics201.DrawString("Fail", arialFont10Bold74, (XBrush) red, xrect201, topLeft201);
                flag2 = true;
              }
              else
              {
                XGraphics xgraphics202 = PDFFunctions.gfx[L1ACheckList.k];
                XFont arialFont10Bold75 = PDFFunctions.ArialFont10Bold;
                XSolidBrush green = XBrushes.Green;
                double num399 = (double) checked (L1ACheckList.RC1 + 1);
                xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                double point206 = ((XUnit) ref xunit).Point;
                xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                double num400 = ((XUnit) ref xunit).Point / 2.0;
                XRect xrect202 = new XRect(540.0, num399, point206, num400);
                XStringFormat topLeft202 = XStringFormat.TopLeft;
                xgraphics202.DrawString("OK", arialFont10Bold75, (XBrush) green, xrect202, topLeft202);
              }
            }
            else if (sapTableCode3 != 202 && sapTableCode3 != 203 && sapTableCode3 != 204)
            {
              if (sapTableCode3 >= 621 && sapTableCode3 <= 624)
              {
                // ISSUE: reference to a compiler-generated field
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.InforSource, "SAP Tables", false) == 0)
                {
                  XGraphics xgraphics203 = PDFFunctions.gfx[L1ACheckList.k];
                  // ISSUE: reference to a compiler-generated field
                  string str75 = "Efficiency " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.MainEff) + " %";
                  XFont arialFont10_120 = PDFFunctions.ArialFont10;
                  XSolidBrush black138 = XBrushes.Black;
                  double num401 = (double) checked (L1ACheckList.RC1 + 1);
                  xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                  double point207 = ((XUnit) ref xunit).Point;
                  xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                  double num402 = ((XUnit) ref xunit).Point / 2.0;
                  XRect xrect203 = new XRect(200.0, num401, point207, num402);
                  XStringFormat topLeft203 = XStringFormat.TopLeft;
                  xgraphics203.DrawString(str75, arialFont10_120, (XBrush) black138, xrect203, topLeft203);
                  checked { L1ACheckList.RC1 += 13; }
                }
                XGraphics xgraphics204 = PDFFunctions.gfx[L1ACheckList.k];
                XFont arialFont10_121 = PDFFunctions.ArialFont10;
                XSolidBrush black139 = XBrushes.Black;
                double num403 = (double) checked (L1ACheckList.RC1 + 1);
                xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                double point208 = ((XUnit) ref xunit).Point;
                xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                double num404 = ((XUnit) ref xunit).Point / 2.0;
                XRect xrect204 = new XRect(200.0, num403, point208, num404);
                XStringFormat topLeft204 = XStringFormat.TopLeft;
                xgraphics204.DrawString("Minimum 60.0 %", arialFont10_121, (XBrush) black139, xrect204, topLeft204);
                // ISSUE: reference to a compiler-generated field
                if ((double) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.MainEff < 60.0)
                {
                  XGraphics xgraphics205 = PDFFunctions.gfx[L1ACheckList.k];
                  XFont arialFont10Bold76 = PDFFunctions.ArialFont10Bold;
                  XSolidBrush red = XBrushes.Red;
                  double num405 = (double) checked (L1ACheckList.RC1 + 1);
                  xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                  double point209 = ((XUnit) ref xunit).Point;
                  xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                  double num406 = ((XUnit) ref xunit).Point / 2.0;
                  XRect xrect205 = new XRect(540.0, num405, point209, num406);
                  XStringFormat topLeft205 = XStringFormat.TopLeft;
                  xgraphics205.DrawString("Fail", arialFont10Bold76, (XBrush) red, xrect205, topLeft205);
                  flag2 = true;
                }
                else
                {
                  XGraphics xgraphics206 = PDFFunctions.gfx[L1ACheckList.k];
                  XFont arialFont10Bold77 = PDFFunctions.ArialFont10Bold;
                  XSolidBrush green = XBrushes.Green;
                  double num407 = (double) checked (L1ACheckList.RC1 + 1);
                  xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                  double point210 = ((XUnit) ref xunit).Point;
                  xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                  double num408 = ((XUnit) ref xunit).Point / 2.0;
                  XRect xrect206 = new XRect(540.0, num407, point210, num408);
                  XStringFormat topLeft206 = XStringFormat.TopLeft;
                  xgraphics206.DrawString("OK", arialFont10Bold77, (XBrush) green, xrect206, topLeft206);
                }
              }
              else
              {
                // ISSUE: reference to a compiler-generated field
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.InforSource, "Manufacturer Declaration", false) == 0)
                {
                  XGraphics xgraphics207 = PDFFunctions.gfx[L1ACheckList.k];
                  // ISSUE: reference to a compiler-generated field
                  string str76 = "Minimum " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.MainEff) + " %";
                  XFont arialFont10_122 = PDFFunctions.ArialFont10;
                  XSolidBrush black140 = XBrushes.Black;
                  double num409 = (double) checked (L1ACheckList.RC1 + 1);
                  xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                  double point211 = ((XUnit) ref xunit).Point;
                  xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                  double num410 = ((XUnit) ref xunit).Point / 2.0;
                  XRect xrect207 = new XRect(200.0, num409, point211, num410);
                  XStringFormat topLeft207 = XStringFormat.TopLeft;
                  xgraphics207.DrawString(str76, arialFont10_122, (XBrush) black140, xrect207, topLeft207);
                  checked { L1ACheckList.RC1 += 13; }
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  if ((double) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.MainEff < (double) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.MainEff)
                  {
                    XGraphics xgraphics208 = PDFFunctions.gfx[L1ACheckList.k];
                    XFont arialFont10Bold78 = PDFFunctions.ArialFont10Bold;
                    XSolidBrush red = XBrushes.Red;
                    double num411 = (double) checked (L1ACheckList.RC1 + 1);
                    xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                    double point212 = ((XUnit) ref xunit).Point;
                    xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                    double num412 = ((XUnit) ref xunit).Point / 2.0;
                    XRect xrect208 = new XRect(540.0, num411, point212, num412);
                    XStringFormat topLeft208 = XStringFormat.TopLeft;
                    xgraphics208.DrawString("Fail", arialFont10Bold78, (XBrush) red, xrect208, topLeft208);
                    flag2 = true;
                  }
                  else
                  {
                    XGraphics xgraphics209 = PDFFunctions.gfx[L1ACheckList.k];
                    XFont arialFont10Bold79 = PDFFunctions.ArialFont10Bold;
                    XSolidBrush green = XBrushes.Green;
                    double num413 = (double) checked (L1ACheckList.RC1 + 1);
                    xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                    double point213 = ((XUnit) ref xunit).Point;
                    xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                    double num414 = ((XUnit) ref xunit).Point / 2.0;
                    XRect xrect209 = new XRect(540.0, num413, point213, num414);
                    XStringFormat topLeft209 = XStringFormat.TopLeft;
                    xgraphics209.DrawString("OK", arialFont10Bold79, (XBrush) green, xrect209, topLeft209);
                  }
                }
                else
                {
                  // ISSUE: reference to a compiler-generated field
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.InforSource, "SAP Tables", false) == 0)
                  {
                    XGraphics xgraphics210 = PDFFunctions.gfx[L1ACheckList.k];
                    // ISSUE: reference to a compiler-generated field
                    string str77 = "Efficiency " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.MainEff) + " %";
                    XFont arialFont10_123 = PDFFunctions.ArialFont10;
                    XSolidBrush black141 = XBrushes.Black;
                    double num415 = (double) checked (L1ACheckList.RC1 + 1);
                    xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                    double point214 = ((XUnit) ref xunit).Point;
                    xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                    double num416 = ((XUnit) ref xunit).Point / 2.0;
                    XRect xrect210 = new XRect(200.0, num415, point214, num416);
                    XStringFormat topLeft210 = XStringFormat.TopLeft;
                    xgraphics210.DrawString(str77, arialFont10_123, (XBrush) black141, xrect210, topLeft210);
                    checked { L1ACheckList.RC1 += 13; }
                    XGraphics xgraphics211 = PDFFunctions.gfx[L1ACheckList.k];
                    // ISSUE: reference to a compiler-generated field
                    string str78 = "Minimum " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.MainEff) + " %";
                    XFont arialFont10_124 = PDFFunctions.ArialFont10;
                    XSolidBrush black142 = XBrushes.Black;
                    double num417 = (double) checked (L1ACheckList.RC1 + 1);
                    xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                    double point215 = ((XUnit) ref xunit).Point;
                    xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                    double num418 = ((XUnit) ref xunit).Point / 2.0;
                    XRect xrect211 = new XRect(200.0, num417, point215, num418);
                    XStringFormat topLeft211 = XStringFormat.TopLeft;
                    xgraphics211.DrawString(str78, arialFont10_124, (XBrush) black142, xrect211, topLeft211);
                    checked { L1ACheckList.RC1 += 13; }
                  }
                }
              }
            }
          }
        }
      }
      checked { L1ACheckList.RC1 += 26; }
      L1ACheckList.CheckCheckListRC1();
      // ISSUE: reference to a compiler-generated field
      if (SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].IncludeMainHeating2)
      {
        XGraphics xgraphics212 = PDFFunctions.gfx[L1ACheckList.k];
        XFont arialFont10_125 = PDFFunctions.ArialFont10;
        XSolidBrush black143 = XBrushes.Black;
        double num419 = (double) checked (L1ACheckList.RC1 + 1);
        xunit = PDFFunctions.pages[L1ACheckList.k].Width;
        double point216 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[L1ACheckList.k].Height;
        double num420 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect212 = new XRect(50.0, num419, point216, num420);
        XStringFormat topLeft212 = XStringFormat.TopLeft;
        xgraphics212.DrawString("Main Heating system 2:", arialFont10_125, (XBrush) black143, xrect212, topLeft212);
        // ISSUE: reference to a compiler-generated field
        int sapTableCode4 = SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.SAPTableCode;
        if (sapTableCode4 >= 120 && sapTableCode4 <= 123)
        {
          // ISSUE: reference to a compiler-generated field
          if (SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Water.SystemRef == 901)
            L1ACheckList.CPSUFound = true;
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          if (sapTableCode4 == 192 && SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Water.Thermal.Include)
            L1ACheckList.CPSUFound = true;
        }
        // ISSUE: reference to a compiler-generated field
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.InforSource, "Boiler Database", false) == 0)
        {
          // ISSUE: reference to a compiler-generated field
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.SGroup, "Gas boilers and oil boilers", false) == 0)
          {
            // ISSUE: reference to a compiler-generated method
            PCDF.SEDBUK sedbuk = SAP_Module.PCDFData.Boilers.Where<PCDF.SEDBUK>(new Func<PCDF.SEDBUK, bool>(closure260_2._Lambda\u0024__5)).SingleOrDefault<PCDF.SEDBUK>();
            if (sedbuk != null)
            {
              str44 = sedbuk.BrandName;
              str46 = sedbuk.ModelName;
              str45 = sedbuk.ModelQualifier;
              double num421 = Conversion.Val(sedbuk.MainType);
              if (num421 == 0.0)
                str47 = "Unknown";
              else if (num421 == 1.0)
                str47 = "Regular";
              else if (num421 == 2.0)
                str47 = "Combi";
              else if (num421 == 3.0)
                str47 = "CPSU";
            }
          }
          else
          {
            // ISSUE: reference to a compiler-generated field
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.SGroup, "Micro-cogeneration (micro-CHP)", false) == 0)
            {
              // ISSUE: reference to a compiler-generated method
              PCDF.CHP chp = SAP_Module.PCDFData.CHPs.Where<PCDF.CHP>(new Func<PCDF.CHP, bool>(closure260_2._Lambda\u0024__6)).SingleOrDefault<PCDF.CHP>();
              if (chp != null)
              {
                str44 = chp.Brand;
                str46 = chp.Model;
                str45 = chp.Qualifier;
                Left3 = Microsoft.VisualBasic.Strings.Format((object) Math.Round(SAP_Module.Calculation2012.Calculation.Energy_Requirements_9a.Box206), "00.0");
              }
            }
            else
            {
              // ISSUE: reference to a compiler-generated field
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.SGroup, "Solid fuel boilers", false) == 0)
              {
                // ISSUE: reference to a compiler-generated method
                PCDF.SEDBUK_Solid sedbukSolid = SAP_Module.PCDFData.Solid_Boilers.Where<PCDF.SEDBUK_Solid>(new Func<PCDF.SEDBUK_Solid, bool>(closure260_2._Lambda\u0024__7)).SingleOrDefault<PCDF.SEDBUK_Solid>();
                if (sedbukSolid != null)
                {
                  str44 = sedbukSolid.BrandName;
                  str46 = sedbukSolid.ModelName;
                  str45 = sedbukSolid.ModelQualifier;
                  double num422 = Conversion.Val(sedbukSolid.MainType);
                  if (num422 == 0.0)
                    str47 = "Unknown";
                  else if (num422 == 1.0)
                    str47 = "Regular";
                  else if (num422 == 2.0)
                    str47 = "Combi";
                  else if (num422 == 3.0)
                    str47 = "CPSU";
                  Left3 = Microsoft.VisualBasic.Strings.Format((object) Math.Round(SAP_Module.Calculation2012.Calculation.Energy_Requirements_9a.Box206), "00.0");
                  if (Conversions.ToDouble(Left3) == 0.0)
                  {
                    // ISSUE: reference to a compiler-generated field
                    Left3 = Microsoft.VisualBasic.Strings.Format((object) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.MainEff, "00.0");
                  }
                }
              }
            }
          }
          // ISSUE: reference to a compiler-generated field
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.SGroup, "Micro-cogeneration (micro-CHP)", false) == 0)
          {
            XGraphics xgraphics213 = PDFFunctions.gfx[L1ACheckList.k];
            // ISSUE: reference to a compiler-generated field
            string str79 = "Micro-cogeneration - " + PDFFunctions.CheckFuel((object) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.Fuel);
            XFont arialFont10_126 = PDFFunctions.ArialFont10;
            XSolidBrush black144 = XBrushes.Black;
            double rc1_38 = (double) L1ACheckList.RC1;
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point217 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num423 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect213 = new XRect(200.0, rc1_38, point217, num423);
            XStringFormat topLeft213 = XStringFormat.TopLeft;
            xgraphics213.DrawString(str79, arialFont10_126, (XBrush) black144, xrect213, topLeft213);
            checked { L1ACheckList.RC1 += 13; }
            XGraphics xgraphics214 = PDFFunctions.gfx[L1ACheckList.k];
            XFont arialFont10_127 = PDFFunctions.ArialFont10;
            XSolidBrush black145 = XBrushes.Black;
            double rc1_39 = (double) L1ACheckList.RC1;
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point218 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num424 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect214 = new XRect(200.0, rc1_39, point218, num424);
            XStringFormat topLeft214 = XStringFormat.TopLeft;
            xgraphics214.DrawString("Data from database ", arialFont10_127, (XBrush) black145, xrect214, topLeft214);
          }
          else
          {
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.SGroup, "Electric heat pumps", false) > 0U & (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.SGroup, "Gas-fired heat pumps", false) > 0U)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left3, (string) null, false) == 0)
              {
                XGraphics xgraphics215 = PDFFunctions.gfx[L1ACheckList.k];
                // ISSUE: reference to a compiler-generated field
                string str80 = "Database: (rev " + Conversions.ToString(SAP_Module.DataBVersion) + ", product index " + SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.SEDBUK + "):";
                XFont arialFont10_128 = PDFFunctions.ArialFont10;
                XSolidBrush black146 = XBrushes.Black;
                double rc1_40 = (double) L1ACheckList.RC1;
                xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                double point219 = ((XUnit) ref xunit).Point;
                xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                double num425 = ((XUnit) ref xunit).Point / 2.0;
                XRect xrect215 = new XRect(200.0, rc1_40, point219, num425);
                XStringFormat topLeft215 = XStringFormat.TopLeft;
                xgraphics215.DrawString(str80, arialFont10_128, (XBrush) black146, xrect215, topLeft215);
              }
              else
              {
                XGraphics xgraphics216 = PDFFunctions.gfx[L1ACheckList.k];
                // ISSUE: reference to a compiler-generated field
                string str81 = "Database: (rev " + Conversions.ToString(SAP_Module.DataBVersion) + ", product index " + SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.SEDBUK + "):";
                XFont arialFont10_129 = PDFFunctions.ArialFont10;
                XSolidBrush black147 = XBrushes.Black;
                double rc1_41 = (double) L1ACheckList.RC1;
                xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                double point220 = ((XUnit) ref xunit).Point;
                xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                double num426 = ((XUnit) ref xunit).Point / 2.0;
                XRect xrect216 = new XRect(200.0, rc1_41, point220, num426);
                XStringFormat topLeft216 = XStringFormat.TopLeft;
                xgraphics216.DrawString(str81, arialFont10_129, (XBrush) black147, xrect216, topLeft216);
              }
            }
          }
          checked { L1ACheckList.RC1 += 13; }
        }
        L1ACheckList.CheckCheckListRC1();
        // ISSUE: reference to a compiler-generated field
        string hgroup2 = SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.HGroup;
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        string str82 = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(hgroup2, "Central heating systems with radiators or underfloor heating", false) == 0 ? (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.SGroup, "Heat pumps", false) != 0 ? "Boiler system with radiators or underfloor" : "Heat pumps with radiators or underfloor") : (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(hgroup2, "Warm air systems", false) == 0 ? (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.SGroup, "Heat pumps", false) != 0 ? SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.HGroup + " (not heat pump)" : "Heat pump with warm air distribution") : SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.HGroup);
        // ISSUE: reference to a compiler-generated field
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.Fuel, "heating oil", false) == 0)
        {
          XGraphics xgraphics217 = PDFFunctions.gfx[L1ACheckList.k];
          // ISSUE: reference to a compiler-generated field
          string str83 = str82 + " - " + SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.Fuel;
          XFont arialFont10_130 = PDFFunctions.ArialFont10;
          XSolidBrush black148 = XBrushes.Black;
          double num427 = (double) checked (L1ACheckList.RC1 + 1);
          xunit = PDFFunctions.pages[L1ACheckList.k].Width;
          double point221 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[L1ACheckList.k].Height;
          double num428 = ((XUnit) ref xunit).Point / 2.0;
          XRect xrect217 = new XRect(200.0, num427, point221, num428);
          XStringFormat topLeft217 = XStringFormat.TopLeft;
          xgraphics217.DrawString(str83, arialFont10_130, (XBrush) black148, xrect217, topLeft217);
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.SGroup, "Micro-cogeneration (micro-CHP)", false) > 0U)
          {
            XGraphics xgraphics218 = PDFFunctions.gfx[L1ACheckList.k];
            // ISSUE: reference to a compiler-generated field
            string str84 = str82 + " - " + PDFFunctions.CheckFuel((object) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.Fuel);
            XFont arialFont10_131 = PDFFunctions.ArialFont10;
            XSolidBrush black149 = XBrushes.Black;
            double num429 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point222 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num430 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect218 = new XRect(200.0, num429, point222, num430);
            XStringFormat topLeft218 = XStringFormat.TopLeft;
            xgraphics218.DrawString(str84, arialFont10_131, (XBrush) black149, xrect218, topLeft218);
          }
        }
        checked { L1ACheckList.RC1 += 13; }
        L1ACheckList.CheckCheckListRC1();
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.SGroup, "Gas boilers and oil boilers", false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.InforSource, "Manufacturer Declaration", false) == 0)
        {
          XGraphics xgraphics219 = PDFFunctions.gfx[L1ACheckList.k];
          XFont arialFont10_132 = PDFFunctions.ArialFont10;
          XSolidBrush black150 = XBrushes.Black;
          double num431 = (double) checked (L1ACheckList.RC1 + 1);
          xunit = PDFFunctions.pages[L1ACheckList.k].Width;
          double point223 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[L1ACheckList.k].Height;
          double num432 = ((XUnit) ref xunit).Point / 2.0;
          XRect xrect219 = new XRect(200.0, num431, point223, num432);
          XStringFormat topLeft219 = XStringFormat.TopLeft;
          xgraphics219.DrawString("Data from manufacturer", arialFont10_132, (XBrush) black150, xrect219, topLeft219);
          checked { L1ACheckList.RC1 += 13; }
          // ISSUE: reference to a compiler-generated field
          if (SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.BSubGroup.Contains("CPSU"))
          {
            XGraphics xgraphics220 = PDFFunctions.gfx[L1ACheckList.k];
            XFont arialFont10_133 = PDFFunctions.ArialFont10;
            XSolidBrush black151 = XBrushes.Black;
            double num433 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point224 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num434 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect220 = new XRect(200.0, num433, point224, num434);
            XStringFormat topLeft220 = XStringFormat.TopLeft;
            xgraphics220.DrawString("CPSU", arialFont10_133, (XBrush) black151, xrect220, topLeft220);
            checked { L1ACheckList.RC1 += 13; }
          }
        }
        // ISSUE: reference to a compiler-generated field
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.InforSource, "Boiler Database", false) == 0)
        {
          // ISSUE: reference to a compiler-generated field
          if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.HGroup, "Community heating schemes", false) > 0U)
          {
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.SGroup, "Electric heat pumps", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.SGroup, "Gas-fired heat pumps", false) == 0)
            {
              // ISSUE: reference to a compiler-generated method
              PCDF.HeatPump heatPump = SAP_Module.PCDFData.HeatPumps.Where<PCDF.HeatPump>(new Func<PCDF.HeatPump, bool>(closure260_2._Lambda\u0024__8)).SingleOrDefault<PCDF.HeatPump>();
              if (heatPump != null)
              {
                str44 = heatPump.Brand;
                str46 = heatPump.Model;
                str45 = heatPump.Qualifier;
                XGraphics xgraphics221 = PDFFunctions.gfx[L1ACheckList.k];
                string str85 = str44 + " " + str46;
                XFont arialFont10_134 = PDFFunctions.ArialFont10;
                XSolidBrush black152 = XBrushes.Black;
                double rc1_42 = (double) L1ACheckList.RC1;
                xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                double point225 = ((XUnit) ref xunit).Point;
                xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                double num435 = ((XUnit) ref xunit).Point / 2.0;
                XRect xrect221 = new XRect(200.0, rc1_42, point225, num435);
                XStringFormat topLeft221 = XStringFormat.TopLeft;
                xgraphics221.DrawString(str85, arialFont10_134, (XBrush) black152, xrect221, topLeft221);
              }
              checked { L1ACheckList.RC1 += 12; }
            }
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.SGroup, "Micro-cogeneration (micro-CHP)", false) > 0U & (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.SGroup, "Electric heat pumps", false) > 0U & (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.SGroup, "Gas-fired heat pumps", false) > 0U)
            {
              XGraphics xgraphics222 = PDFFunctions.gfx[L1ACheckList.k];
              string str86 = "Brand name: " + str44;
              XFont arialFont10_135 = PDFFunctions.ArialFont10;
              XSolidBrush black153 = XBrushes.Black;
              double rc1_43 = (double) L1ACheckList.RC1;
              xunit = PDFFunctions.pages[L1ACheckList.k].Width;
              double point226 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[L1ACheckList.k].Height;
              double num436 = ((XUnit) ref xunit).Point / 2.0;
              XRect xrect222 = new XRect(200.0, rc1_43, point226, num436);
              XStringFormat topLeft222 = XStringFormat.TopLeft;
              xgraphics222.DrawString(str86, arialFont10_135, (XBrush) black153, xrect222, topLeft222);
              checked { L1ACheckList.RC1 += 12; }
              XGraphics xgraphics223 = PDFFunctions.gfx[L1ACheckList.k];
              string str87 = "Model: " + str46;
              XFont arialFont10_136 = PDFFunctions.ArialFont10;
              XSolidBrush black154 = XBrushes.Black;
              double rc1_44 = (double) L1ACheckList.RC1;
              xunit = PDFFunctions.pages[L1ACheckList.k].Width;
              double point227 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[L1ACheckList.k].Height;
              double num437 = ((XUnit) ref xunit).Point / 2.0;
              XRect xrect223 = new XRect(200.0, rc1_44, point227, num437);
              XStringFormat topLeft223 = XStringFormat.TopLeft;
              xgraphics223.DrawString(str87, arialFont10_136, (XBrush) black154, xrect223, topLeft223);
              checked { L1ACheckList.RC1 += 12; }
              XGraphics xgraphics224 = PDFFunctions.gfx[L1ACheckList.k];
              string str88 = "Model qualifier: " + str45;
              XFont arialFont10_137 = PDFFunctions.ArialFont10;
              XSolidBrush black155 = XBrushes.Black;
              double rc1_45 = (double) L1ACheckList.RC1;
              xunit = PDFFunctions.pages[L1ACheckList.k].Width;
              double point228 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[L1ACheckList.k].Height;
              double num438 = ((XUnit) ref xunit).Point / 2.0;
              XRect xrect224 = new XRect(200.0, rc1_45, point228, num438);
              XStringFormat topLeft224 = XStringFormat.TopLeft;
              xgraphics224.DrawString(str88, arialFont10_137, (XBrush) black155, xrect224, topLeft224);
              checked { L1ACheckList.RC1 += 12; }
              // ISSUE: reference to a compiler-generated field
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.SGroup, "Micro-cogeneration (micro-CHP)", false) == 0)
              {
                XGraphics xgraphics225 = PDFFunctions.gfx[L1ACheckList.k];
                XFont arialFont10_138 = PDFFunctions.ArialFont10;
                XSolidBrush black156 = XBrushes.Black;
                double rc1_46 = (double) L1ACheckList.RC1;
                xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                double point229 = ((XUnit) ref xunit).Point;
                xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                double num439 = ((XUnit) ref xunit).Point / 2.0;
                XRect xrect225 = new XRect(200.0, rc1_46, point229, num439);
                XStringFormat topLeft225 = XStringFormat.TopLeft;
                xgraphics225.DrawString("(provides DHW all year)", arialFont10_138, (XBrush) black156, xrect225, topLeft225);
              }
              else
              {
                XGraphics xgraphics226 = PDFFunctions.gfx[L1ACheckList.k];
                string str89 = "(" + str47 + ")";
                XFont arialFont10_139 = PDFFunctions.ArialFont10;
                XSolidBrush black157 = XBrushes.Black;
                double rc1_47 = (double) L1ACheckList.RC1;
                xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                double point230 = ((XUnit) ref xunit).Point;
                xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                double num440 = ((XUnit) ref xunit).Point / 2.0;
                XRect xrect226 = new XRect(200.0, rc1_47, point230, num440);
                XStringFormat topLeft226 = XStringFormat.TopLeft;
                xgraphics226.DrawString(str89, arialFont10_139, (XBrush) black157, xrect226, topLeft226);
              }
              checked { L1ACheckList.RC1 += 12; }
            }
            else
            {
              // ISSUE: reference to a compiler-generated field
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.InforSource, "Manufacturer Declaration", false) == 0)
              {
                XGraphics xgraphics227 = PDFFunctions.gfx[L1ACheckList.k];
                // ISSUE: reference to a compiler-generated field
                string str90 = "Data from manufacturer - " + PDFFunctions.CheckFuel((object) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.Fuel);
                XFont arialFont10_140 = PDFFunctions.ArialFont10;
                XSolidBrush black158 = XBrushes.Black;
                double rc1_48 = (double) L1ACheckList.RC1;
                xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                double point231 = ((XUnit) ref xunit).Point;
                xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                double num441 = ((XUnit) ref xunit).Point / 2.0;
                XRect xrect227 = new XRect(200.0, rc1_48, point231, num441);
                XStringFormat topLeft227 = XStringFormat.TopLeft;
                xgraphics227.DrawString(str90, arialFont10_140, (XBrush) black158, xrect227, topLeft227);
                checked { L1ACheckList.RC1 += 12; }
                XGraphics xgraphics228 = PDFFunctions.gfx[L1ACheckList.k];
                // ISSUE: reference to a compiler-generated field
                string description = SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.Boiler.Description;
                XFont arialFont10_141 = PDFFunctions.ArialFont10;
                XSolidBrush black159 = XBrushes.Black;
                double rc1_49 = (double) L1ACheckList.RC1;
                xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                double point232 = ((XUnit) ref xunit).Point;
                xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                double num442 = ((XUnit) ref xunit).Point / 2.0;
                XRect xrect228 = new XRect(200.0, rc1_49, point232, num442);
                XStringFormat topLeft228 = XStringFormat.TopLeft;
                xgraphics228.DrawString(description, arialFont10_141, (XBrush) black159, xrect228, topLeft228);
                checked { L1ACheckList.RC1 += 12; }
              }
              else
              {
                // ISSUE: reference to a compiler-generated field
                if (!string.IsNullOrEmpty(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.BSubGroup))
                {
                  XGraphics xgraphics229 = PDFFunctions.gfx[L1ACheckList.k];
                  // ISSUE: reference to a compiler-generated field
                  string bsubGroup = SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.BSubGroup;
                  XFont arialFont10_142 = PDFFunctions.ArialFont10;
                  XSolidBrush black160 = XBrushes.Black;
                  double rc1_50 = (double) L1ACheckList.RC1;
                  xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                  double point233 = ((XUnit) ref xunit).Point;
                  xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                  double num443 = ((XUnit) ref xunit).Point / 2.0;
                  XRect xrect229 = new XRect(200.0, rc1_50, point233, num443);
                  XStringFormat topLeft229 = XStringFormat.TopLeft;
                  xgraphics229.DrawString(bsubGroup, arialFont10_142, (XBrush) black160, xrect229, topLeft229);
                  checked { L1ACheckList.RC1 += 12; }
                }
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.SGroup, "Electric heat pumps", false) > 0U | (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.SGroup, "Gas-fired heat pumps", false) > 0U)
                {
                  XGraphics xgraphics230 = PDFFunctions.gfx[L1ACheckList.k];
                  // ISSUE: reference to a compiler-generated field
                  string mhType = SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.MHType;
                  XFont arialFont10_143 = PDFFunctions.ArialFont10;
                  XSolidBrush black161 = XBrushes.Black;
                  double rc1_51 = (double) L1ACheckList.RC1;
                  xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                  double point234 = ((XUnit) ref xunit).Point;
                  xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                  double num444 = ((XUnit) ref xunit).Point / 2.0;
                  XRect xrect230 = new XRect(200.0, rc1_51, point234, num444);
                  XStringFormat topLeft230 = XStringFormat.TopLeft;
                  xgraphics230.DrawString(mhType, arialFont10_143, (XBrush) black161, xrect230, topLeft230);
                }
                else
                {
                  // ISSUE: reference to a compiler-generated method
                  PCDF.HeatPump heatPump = SAP_Module.PCDFData.HeatPumps.Where<PCDF.HeatPump>(new Func<PCDF.HeatPump, bool>(closure260_2._Lambda\u0024__9)).SingleOrDefault<PCDF.HeatPump>();
                  if (heatPump != null)
                  {
                    string brand = heatPump.Brand;
                    string model = heatPump.Model;
                    string qualifier = heatPump.Qualifier;
                    XGraphics xgraphics231 = PDFFunctions.gfx[L1ACheckList.k];
                    string str91 = brand + " " + model;
                    XFont arialFont10_144 = PDFFunctions.ArialFont10;
                    XSolidBrush black162 = XBrushes.Black;
                    double rc1_52 = (double) L1ACheckList.RC1;
                    xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                    double point235 = ((XUnit) ref xunit).Point;
                    xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                    double num445 = ((XUnit) ref xunit).Point / 2.0;
                    XRect xrect231 = new XRect(200.0, rc1_52, point235, num445);
                    XStringFormat topLeft231 = XStringFormat.TopLeft;
                    xgraphics231.DrawString(str91, arialFont10_144, (XBrush) black162, xrect231, topLeft231);
                  }
                  checked { L1ACheckList.RC1 += 12; }
                }
              }
            }
          }
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.InforSource, "SAP Tables", false) == 0)
          {
            if (L1ACheckList.CPSUFound)
            {
              // ISSUE: reference to a compiler-generated field
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.MHType, "With automatic ignition (non-condensing)", false) == 0)
              {
                XGraphics xgraphics232 = PDFFunctions.gfx[L1ACheckList.k];
                XFont arialFont10_145 = PDFFunctions.ArialFont10;
                XSolidBrush black163 = XBrushes.Black;
                double rc1_53 = (double) L1ACheckList.RC1;
                xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                double point236 = ((XUnit) ref xunit).Point;
                xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                double num446 = ((XUnit) ref xunit).Point / 2.0;
                XRect xrect232 = new XRect(200.0, rc1_53, point236, num446);
                XStringFormat topLeft232 = XStringFormat.TopLeft;
                xgraphics232.DrawString("CPSU - Combined Primary Storage Unit (non condensing)", arialFont10_145, (XBrush) black163, xrect232, topLeft232);
              }
              else
              {
                XGraphics xgraphics233 = PDFFunctions.gfx[L1ACheckList.k];
                // ISSUE: reference to a compiler-generated field
                string str92 = "CPSU- " + SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.MHType;
                XFont arialFont10_146 = PDFFunctions.ArialFont10;
                XSolidBrush black164 = XBrushes.Black;
                double rc1_54 = (double) L1ACheckList.RC1;
                xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                double point237 = ((XUnit) ref xunit).Point;
                xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                double num447 = ((XUnit) ref xunit).Point / 2.0;
                XRect xrect233 = new XRect(200.0, rc1_54, point237, num447);
                XStringFormat topLeft233 = XStringFormat.TopLeft;
                xgraphics233.DrawString(str92, arialFont10_146, (XBrush) black164, xrect233, topLeft233);
              }
            }
            else
            {
              // ISSUE: reference to a compiler-generated field
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.MHType, "Ground source heat pump in other cases", false) == 0)
              {
                XGraphics xgraphics234 = PDFFunctions.gfx[L1ACheckList.k];
                XFont arialFont10_147 = PDFFunctions.ArialFont10;
                XSolidBrush black165 = XBrushes.Black;
                double rc1_55 = (double) L1ACheckList.RC1;
                xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                double point238 = ((XUnit) ref xunit).Point;
                xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                double num448 = ((XUnit) ref xunit).Point / 2.0;
                XRect xrect234 = new XRect(200.0, rc1_55, point238, num448);
                XStringFormat topLeft234 = XStringFormat.TopLeft;
                xgraphics234.DrawString("Ground source heat pump (flow temperature <= 35°C)", arialFont10_147, (XBrush) black165, xrect234, topLeft234);
              }
              else
              {
                XGraphics xgraphics235 = PDFFunctions.gfx[L1ACheckList.k];
                // ISSUE: reference to a compiler-generated field
                string mhType = SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.MHType;
                XFont arialFont10_148 = PDFFunctions.ArialFont10;
                XSolidBrush black166 = XBrushes.Black;
                double rc1_56 = (double) L1ACheckList.RC1;
                xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                double point239 = ((XUnit) ref xunit).Point;
                xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                double num449 = ((XUnit) ref xunit).Point / 2.0;
                XRect xrect235 = new XRect(200.0, rc1_56, point239, num449);
                XStringFormat topLeft235 = XStringFormat.TopLeft;
                xgraphics235.DrawString(mhType, arialFont10_148, (XBrush) black166, xrect235, topLeft235);
              }
            }
            checked { L1ACheckList.RC1 += 12; }
          }
        }
        L1ACheckList.CheckCheckListRC1();
        // ISSUE: reference to a compiler-generated field
        if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.InforSource, "Boiler Database", false) > 0U)
        {
          // ISSUE: reference to a compiler-generated field
          switch (SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.SAPTableCode)
          {
            case 103:
            case 104:
            case 108:
            case 112:
            case 113:
            case 118:
            case 128:
            case 129:
            case 130:
              // ISSUE: reference to a compiler-generated field
              string combiType2 = SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Water.CombiType;
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(combiType2, "", false) == 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(combiType2, "Instantaneous Combi", false) == 0)
              {
                XGraphics xgraphics236 = PDFFunctions.gfx[L1ACheckList.k];
                XFont arialFont10_149 = PDFFunctions.ArialFont10;
                XSolidBrush black167 = XBrushes.Black;
                double rc1_57 = (double) L1ACheckList.RC1;
                xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                double point240 = ((XUnit) ref xunit).Point;
                xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                double num450 = ((XUnit) ref xunit).Point / 2.0;
                XRect xrect236 = new XRect(200.0, rc1_57, point240, num450);
                XStringFormat topLeft236 = XStringFormat.TopLeft;
                xgraphics236.DrawString("Combi boiler", arialFont10_149, (XBrush) black167, xrect236, topLeft236);
                checked { L1ACheckList.RC1 += 12; }
                break;
              }
              break;
          }
        }
        L1ACheckList.CheckCheckListRC1();
        // ISSUE: reference to a compiler-generated field
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.InforSource, "Boiler Database", false) == 0)
        {
          // ISSUE: reference to a compiler-generated field
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.SGroup, "Gas boilers and oil boilers", false) == 0)
          {
            XGraphics xgraphics237 = PDFFunctions.gfx[L1ACheckList.k];
            // ISSUE: reference to a compiler-generated field
            string str93 = "Efficiency " + Microsoft.VisualBasic.Strings.Format((object) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.MainEff, "00.0") + " % SEDBUK2009";
            XFont arialFont10_150 = PDFFunctions.ArialFont10;
            XSolidBrush black168 = XBrushes.Black;
            double num451 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point241 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num452 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect237 = new XRect(200.0, num451, point241, num452);
            XStringFormat topLeft237 = XStringFormat.TopLeft;
            xgraphics237.DrawString(str93, arialFont10_150, (XBrush) black168, xrect237, topLeft237);
            checked { L1ACheckList.RC1 += 13; }
          }
          else
          {
            // ISSUE: reference to a compiler-generated field
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.SGroup, "Micro-cogeneration (micro-CHP)", false) == 0)
            {
              float num453 = 0.23f;
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              float num454 = !(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Water.SystemRef == 901 | SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Water.SystemRef == 903) ? (float) ((SAP_Module.CalcualtionDER2012.Calculation.CO2_Emissions_12a.Box261 + SAP_Module.CalcualtionDER2012.Calculation.CO2_Emissions_12a.Box263 + SAP_Module.CalcualtionDER2012.Calculation.CO2_Emissions_12a.Box269) / SAP_Module.CalcualtionDER2012.Calculation.Space_heating_requirement.Box98) : (float) ((SAP_Module.CalcualtionDER2012.Calculation.CO2_Emissions_12a.Box261 + SAP_Module.CalcualtionDER2012.Calculation.CO2_Emissions_12a.Box263 + SAP_Module.CalcualtionDER2012.Calculation.CO2_Emissions_12a.Box264 + SAP_Module.CalcualtionDER2012.Calculation.CO2_Emissions_12a.Box269) / (SAP_Module.CalcualtionDER2012.Calculation.Space_heating_requirement.Box98 + SAP_Module.CalcualtionDER2012.Calculation.Water_heating.Box64));
              XGraphics xgraphics238 = PDFFunctions.gfx[L1ACheckList.k];
              string str94 = "HPER: " + Conversions.ToString(Math.Round((double) num454, 2));
              XFont arialFont10_151 = PDFFunctions.ArialFont10;
              XSolidBrush black169 = XBrushes.Black;
              double num455 = (double) checked (L1ACheckList.RC1 + 1);
              xunit = PDFFunctions.pages[L1ACheckList.k].Width;
              double point242 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[L1ACheckList.k].Height;
              double num456 = ((XUnit) ref xunit).Point / 2.0;
              XRect xrect238 = new XRect(200.0, num455, point242, num456);
              XStringFormat topLeft238 = XStringFormat.TopLeft;
              xgraphics238.DrawString(str94, arialFont10_151, (XBrush) black169, xrect238, topLeft238);
              checked { L1ACheckList.RC1 += 13; }
              XGraphics xgraphics239 = PDFFunctions.gfx[L1ACheckList.k];
              string str95 = "Maximum: " + Conversions.ToString(Math.Round((double) num453, 2));
              XFont arialFont10_152 = PDFFunctions.ArialFont10;
              XSolidBrush black170 = XBrushes.Black;
              double num457 = (double) checked (L1ACheckList.RC1 + 1);
              xunit = PDFFunctions.pages[L1ACheckList.k].Width;
              double point243 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[L1ACheckList.k].Height;
              double num458 = ((XUnit) ref xunit).Point / 2.0;
              XRect xrect239 = new XRect(200.0, num457, point243, num458);
              XStringFormat topLeft239 = XStringFormat.TopLeft;
              xgraphics239.DrawString(str95, arialFont10_152, (XBrush) black170, xrect239, topLeft239);
              if ((double) num454 > (double) num453)
              {
                XGraphics xgraphics240 = PDFFunctions.gfx[L1ACheckList.k];
                XFont arialFont10Bold80 = PDFFunctions.ArialFont10Bold;
                XSolidBrush red = XBrushes.Red;
                double num459 = (double) checked (L1ACheckList.RC1 + 1);
                xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                double point244 = ((XUnit) ref xunit).Point;
                xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                double num460 = ((XUnit) ref xunit).Point / 2.0;
                XRect xrect240 = new XRect(540.0, num459, point244, num460);
                XStringFormat topLeft240 = XStringFormat.TopLeft;
                xgraphics240.DrawString("Fail", arialFont10Bold80, (XBrush) red, xrect240, topLeft240);
                flag2 = true;
                checked { L1ACheckList.RC1 += 13; }
              }
            }
            else
            {
              // ISSUE: reference to a compiler-generated field
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.SGroup, "Solid fuel boilers", false) == 0)
              {
                XGraphics xgraphics241 = PDFFunctions.gfx[L1ACheckList.k];
                // ISSUE: reference to a compiler-generated field
                string str96 = "Efficiency " + Microsoft.VisualBasic.Strings.Format((object) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.MainEff, "00.0") + " % ";
                XFont arialFont10_153 = PDFFunctions.ArialFont10;
                XSolidBrush black171 = XBrushes.Black;
                double num461 = (double) checked (L1ACheckList.RC1 + 1);
                xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                double point245 = ((XUnit) ref xunit).Point;
                xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                double num462 = ((XUnit) ref xunit).Point / 2.0;
                XRect xrect241 = new XRect(200.0, num461, point245, num462);
                XStringFormat topLeft241 = XStringFormat.TopLeft;
                xgraphics241.DrawString(str96, arialFont10_153, (XBrush) black171, xrect241, topLeft241);
                checked { L1ACheckList.RC1 += 13; }
              }
              else
              {
                // ISSUE: reference to a compiler-generated field
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.SGroup, "Heat pumps", false) != 0)
                  ;
              }
            }
          }
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.InforSource, "Manufacturer Declaration", false) == 0)
          {
            // ISSUE: reference to a compiler-generated field
            int sapTableCode5 = SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.SAPTableCode;
            if (sapTableCode5 >= 301 && sapTableCode5 <= 311)
              checked { L1ACheckList.RC1 -= 13; }
            else if (sapTableCode5 < 150)
            {
              // ISSUE: reference to a compiler-generated field
              if (SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.SEDBUK2005)
              {
                XGraphics xgraphics242 = PDFFunctions.gfx[L1ACheckList.k];
                // ISSUE: reference to a compiler-generated field
                string str97 = "Efficiency " + Microsoft.VisualBasic.Strings.Format((object) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.MainEff, "00.0") + " % SEDBUK2005";
                XFont arialFont10_154 = PDFFunctions.ArialFont10;
                XSolidBrush black172 = XBrushes.Black;
                double num463 = (double) checked (L1ACheckList.RC1 + 1);
                xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                double point246 = ((XUnit) ref xunit).Point;
                xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                double num464 = ((XUnit) ref xunit).Point / 2.0;
                XRect xrect242 = new XRect(200.0, num463, point246, num464);
                XStringFormat topLeft242 = XStringFormat.TopLeft;
                xgraphics242.DrawString(str97, arialFont10_154, (XBrush) black172, xrect242, topLeft242);
              }
              else
              {
                XGraphics xgraphics243 = PDFFunctions.gfx[L1ACheckList.k];
                // ISSUE: reference to a compiler-generated field
                string str98 = "Efficiency " + Microsoft.VisualBasic.Strings.Format((object) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.MainEff, "00.0") + " % SEDBUK2009";
                XFont arialFont10_155 = PDFFunctions.ArialFont10;
                XSolidBrush black173 = XBrushes.Black;
                double num465 = (double) checked (L1ACheckList.RC1 + 1);
                xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                double point247 = ((XUnit) ref xunit).Point;
                xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                double num466 = ((XUnit) ref xunit).Point / 2.0;
                XRect xrect243 = new XRect(200.0, num465, point247, num466);
                XStringFormat topLeft243 = XStringFormat.TopLeft;
                xgraphics243.DrawString(str98, arialFont10_155, (XBrush) black173, xrect243, topLeft243);
              }
            }
            else
            {
              XGraphics xgraphics244 = PDFFunctions.gfx[L1ACheckList.k];
              // ISSUE: reference to a compiler-generated field
              string str99 = "Efficiency " + Microsoft.VisualBasic.Strings.Format((object) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.MainEff, "00.0");
              XFont arialFont10_156 = PDFFunctions.ArialFont10;
              XSolidBrush black174 = XBrushes.Black;
              double num467 = (double) checked (L1ACheckList.RC1 + 1);
              xunit = PDFFunctions.pages[L1ACheckList.k].Width;
              double point248 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[L1ACheckList.k].Height;
              double num468 = ((XUnit) ref xunit).Point / 2.0;
              XRect xrect244 = new XRect(200.0, num467, point248, num468);
              XStringFormat topLeft244 = XStringFormat.TopLeft;
              xgraphics244.DrawString(str99, arialFont10_156, (XBrush) black174, xrect244, topLeft244);
            }
            checked { L1ACheckList.RC1 += 13; }
          }
        }
        L1ACheckList.CheckCheckListRC1();
        // ISSUE: reference to a compiler-generated field
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.InforSource, "Boiler Database", false) == 0)
        {
          // ISSUE: reference to a compiler-generated field
          string sgroup = SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.SGroup;
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(sgroup, "Solid fuel boilers", false) != 0)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(sgroup, "Micro-cogeneration (micro-CHP)", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(sgroup, "Heat pumps", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(sgroup, "Electric heat pumps", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(sgroup, "Gas-fired heat pumps", false) != 0)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(sgroup, "Gas boilers and oil boilers", false) == 0)
              {
                // ISSUE: reference to a compiler-generated field
                string fuel4 = SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.Fuel;
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel4, "bulk LPG", false) == 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel4, "Mains gas", false) == 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel4, "mains gas", false) == 0)
                {
                  // ISSUE: reference to a compiler-generated field
                  if (!SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.SEDBUK2005)
                  {
                    XGraphics xgraphics245 = PDFFunctions.gfx[L1ACheckList.k];
                    XFont arialFont10_157 = PDFFunctions.ArialFont10;
                    XSolidBrush black175 = XBrushes.Black;
                    double num469 = (double) checked (L1ACheckList.RC1 + 1);
                    xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                    double point249 = ((XUnit) ref xunit).Point;
                    xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                    double num470 = ((XUnit) ref xunit).Point / 2.0;
                    XRect xrect245 = new XRect(200.0, num469, point249, num470);
                    XStringFormat topLeft245 = XStringFormat.TopLeft;
                    xgraphics245.DrawString("Minimum 88.0 %", arialFont10_157, (XBrush) black175, xrect245, topLeft245);
                  }
                  else
                  {
                    XGraphics xgraphics246 = PDFFunctions.gfx[L1ACheckList.k];
                    XFont arialFont10_158 = PDFFunctions.ArialFont10;
                    XSolidBrush black176 = XBrushes.Black;
                    double num471 = (double) checked (L1ACheckList.RC1 + 1);
                    xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                    double point250 = ((XUnit) ref xunit).Point;
                    xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                    double num472 = ((XUnit) ref xunit).Point / 2.0;
                    XRect xrect246 = new XRect(200.0, num471, point250, num472);
                    XStringFormat topLeft246 = XStringFormat.TopLeft;
                    xgraphics246.DrawString("Minimum 90.0 %", arialFont10_158, (XBrush) black176, xrect246, topLeft246);
                  }
                }
                else
                {
                  XGraphics xgraphics247 = PDFFunctions.gfx[L1ACheckList.k];
                  XFont arialFont10_159 = PDFFunctions.ArialFont10;
                  XSolidBrush black177 = XBrushes.Black;
                  double num473 = (double) checked (L1ACheckList.RC1 + 1);
                  xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                  double point251 = ((XUnit) ref xunit).Point;
                  xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                  double num474 = ((XUnit) ref xunit).Point / 2.0;
                  XRect xrect247 = new XRect(200.0, num473, point251, num474);
                  XStringFormat topLeft247 = XStringFormat.TopLeft;
                  xgraphics247.DrawString("Minimum 80.0 %", arialFont10_159, (XBrush) black177, xrect247, topLeft247);
                }
              }
              else
              {
                XGraphics xgraphics248 = PDFFunctions.gfx[L1ACheckList.k];
                XFont arialFont10_160 = PDFFunctions.ArialFont10;
                XSolidBrush black178 = XBrushes.Black;
                double num475 = (double) checked (L1ACheckList.RC1 + 1);
                xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                double point252 = ((XUnit) ref xunit).Point;
                xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                double num476 = ((XUnit) ref xunit).Point / 2.0;
                XRect xrect248 = new XRect(200.0, num475, point252, num476);
                XStringFormat topLeft248 = XStringFormat.TopLeft;
                xgraphics248.DrawString("Minimum 88.0 %", arialFont10_160, (XBrush) black178, xrect248, topLeft248);
              }
            }
          }
          else
          {
            XGraphics xgraphics249 = PDFFunctions.gfx[L1ACheckList.k];
            XFont arialFont10_161 = PDFFunctions.ArialFont10;
            XSolidBrush black179 = XBrushes.Black;
            double num477 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point253 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num478 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect249 = new XRect(200.0, num477, point253, num478);
            XStringFormat topLeft249 = XStringFormat.TopLeft;
            xgraphics249.DrawString("Minimum 67.0 %", arialFont10_161, (XBrush) black179, xrect249, topLeft249);
          }
          L1ACheckList.CheckCheckListRC1();
          // ISSUE: reference to a compiler-generated field
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.SGroup, "Gas boilers and oil boilers", false) == 0)
          {
            // ISSUE: reference to a compiler-generated field
            string fuel5 = SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.Fuel;
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel5, "mains gas", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel5, "bulk LPG", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel5, "LPG subject to Special Condition 18", false) != 0)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel5, "heating oil", false) == 0)
              {
                // ISSUE: reference to a compiler-generated field
                if ((double) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.MainEff < 80.0)
                {
                  XGraphics xgraphics250 = PDFFunctions.gfx[L1ACheckList.k];
                  XFont arialFont10Bold81 = PDFFunctions.ArialFont10Bold;
                  XSolidBrush red = XBrushes.Red;
                  double num479 = (double) checked (L1ACheckList.RC1 + 1);
                  xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                  double point254 = ((XUnit) ref xunit).Point;
                  xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                  double num480 = ((XUnit) ref xunit).Point / 2.0;
                  XRect xrect250 = new XRect(540.0, num479, point254, num480);
                  XStringFormat topLeft250 = XStringFormat.TopLeft;
                  xgraphics250.DrawString("Fail", arialFont10Bold81, (XBrush) red, xrect250, topLeft250);
                  flag2 = true;
                }
                else
                {
                  XGraphics xgraphics251 = PDFFunctions.gfx[L1ACheckList.k];
                  XFont arialFont10Bold82 = PDFFunctions.ArialFont10Bold;
                  XSolidBrush green = XBrushes.Green;
                  double num481 = (double) checked (L1ACheckList.RC1 + 1);
                  xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                  double point255 = ((XUnit) ref xunit).Point;
                  xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                  double num482 = ((XUnit) ref xunit).Point / 2.0;
                  XRect xrect251 = new XRect(540.0, num481, point255, num482);
                  XStringFormat topLeft251 = XStringFormat.TopLeft;
                  xgraphics251.DrawString("OK", arialFont10Bold82, (XBrush) green, xrect251, topLeft251);
                }
              }
            }
            else
            {
              // ISSUE: reference to a compiler-generated field
              if ((double) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.MainEff < 88.0)
              {
                XGraphics xgraphics252 = PDFFunctions.gfx[L1ACheckList.k];
                XFont arialFont10Bold83 = PDFFunctions.ArialFont10Bold;
                XSolidBrush red = XBrushes.Red;
                double num483 = (double) checked (L1ACheckList.RC1 + 1);
                xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                double point256 = ((XUnit) ref xunit).Point;
                xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                double num484 = ((XUnit) ref xunit).Point / 2.0;
                XRect xrect252 = new XRect(540.0, num483, point256, num484);
                XStringFormat topLeft252 = XStringFormat.TopLeft;
                xgraphics252.DrawString("Fail", arialFont10Bold83, (XBrush) red, xrect252, topLeft252);
                flag2 = true;
              }
              else
              {
                XGraphics xgraphics253 = PDFFunctions.gfx[L1ACheckList.k];
                XFont arialFont10Bold84 = PDFFunctions.ArialFont10Bold;
                XSolidBrush green = XBrushes.Green;
                double num485 = (double) checked (L1ACheckList.RC1 + 1);
                xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                double point257 = ((XUnit) ref xunit).Point;
                xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                double num486 = ((XUnit) ref xunit).Point / 2.0;
                XRect xrect253 = new XRect(540.0, num485, point257, num486);
                XStringFormat topLeft253 = XStringFormat.TopLeft;
                xgraphics253.DrawString("OK", arialFont10Bold84, (XBrush) green, xrect253, topLeft253);
              }
            }
          }
          else
          {
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.SGroup, "Micro-cogeneration (micro-CHP)", false) == 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.SGroup, "Solid fuel boilers", false) != 0)
              ;
          }
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          int sapTableCode6 = SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.SAPTableCode;
          if (sapTableCode6 >= 101 && sapTableCode6 <= 123)
          {
            // ISSUE: reference to a compiler-generated field
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.InforSource, "Manufacturer Declaration", false) == 0)
            {
              // ISSUE: reference to a compiler-generated field
              if (SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.SEDBUK2005)
              {
                XGraphics xgraphics254 = PDFFunctions.gfx[L1ACheckList.k];
                XFont arialFont10_162 = PDFFunctions.ArialFont10;
                XSolidBrush black180 = XBrushes.Black;
                double num487 = (double) checked (L1ACheckList.RC1 + 1);
                xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                double point258 = ((XUnit) ref xunit).Point;
                xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                double num488 = ((XUnit) ref xunit).Point / 2.0;
                XRect xrect254 = new XRect(200.0, num487, point258, num488);
                XStringFormat topLeft254 = XStringFormat.TopLeft;
                xgraphics254.DrawString("Minimum 90.0 %", arialFont10_162, (XBrush) black180, xrect254, topLeft254);
                // ISSUE: reference to a compiler-generated field
                if ((double) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.MainEff < 90.0)
                {
                  XGraphics xgraphics255 = PDFFunctions.gfx[L1ACheckList.k];
                  XFont arialFont10Bold85 = PDFFunctions.ArialFont10Bold;
                  XSolidBrush red = XBrushes.Red;
                  double num489 = (double) checked (L1ACheckList.RC1 + 1);
                  xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                  double point259 = ((XUnit) ref xunit).Point;
                  xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                  double num490 = ((XUnit) ref xunit).Point / 2.0;
                  XRect xrect255 = new XRect(540.0, num489, point259, num490);
                  XStringFormat topLeft255 = XStringFormat.TopLeft;
                  xgraphics255.DrawString("Fail", arialFont10Bold85, (XBrush) red, xrect255, topLeft255);
                  flag2 = true;
                }
                else
                {
                  XGraphics xgraphics256 = PDFFunctions.gfx[L1ACheckList.k];
                  XFont arialFont10Bold86 = PDFFunctions.ArialFont10Bold;
                  XSolidBrush green = XBrushes.Green;
                  double num491 = (double) checked (L1ACheckList.RC1 + 1);
                  xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                  double point260 = ((XUnit) ref xunit).Point;
                  xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                  double num492 = ((XUnit) ref xunit).Point / 2.0;
                  XRect xrect256 = new XRect(540.0, num491, point260, num492);
                  XStringFormat topLeft256 = XStringFormat.TopLeft;
                  xgraphics256.DrawString("OK", arialFont10Bold86, (XBrush) green, xrect256, topLeft256);
                }
              }
              else
              {
                XGraphics xgraphics257 = PDFFunctions.gfx[L1ACheckList.k];
                XFont arialFont10_163 = PDFFunctions.ArialFont10;
                XSolidBrush black181 = XBrushes.Black;
                double num493 = (double) checked (L1ACheckList.RC1 + 1);
                xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                double point261 = ((XUnit) ref xunit).Point;
                xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                double num494 = ((XUnit) ref xunit).Point / 2.0;
                XRect xrect257 = new XRect(200.0, num493, point261, num494);
                XStringFormat topLeft257 = XStringFormat.TopLeft;
                xgraphics257.DrawString("Minimum 88.0 %", arialFont10_163, (XBrush) black181, xrect257, topLeft257);
                // ISSUE: reference to a compiler-generated field
                if ((double) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.MainEff < 88.0)
                {
                  XGraphics xgraphics258 = PDFFunctions.gfx[L1ACheckList.k];
                  XFont arialFont10Bold87 = PDFFunctions.ArialFont10Bold;
                  XSolidBrush red = XBrushes.Red;
                  double num495 = (double) checked (L1ACheckList.RC1 + 1);
                  xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                  double point262 = ((XUnit) ref xunit).Point;
                  xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                  double num496 = ((XUnit) ref xunit).Point / 2.0;
                  XRect xrect258 = new XRect(540.0, num495, point262, num496);
                  XStringFormat topLeft258 = XStringFormat.TopLeft;
                  xgraphics258.DrawString("Fail", arialFont10Bold87, (XBrush) red, xrect258, topLeft258);
                  flag2 = true;
                }
                else
                {
                  XGraphics xgraphics259 = PDFFunctions.gfx[L1ACheckList.k];
                  XFont arialFont10Bold88 = PDFFunctions.ArialFont10Bold;
                  XSolidBrush green = XBrushes.Green;
                  double num497 = (double) checked (L1ACheckList.RC1 + 1);
                  xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                  double point263 = ((XUnit) ref xunit).Point;
                  xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                  double num498 = ((XUnit) ref xunit).Point / 2.0;
                  XRect xrect259 = new XRect(540.0, num497, point263, num498);
                  XStringFormat topLeft259 = XStringFormat.TopLeft;
                  xgraphics259.DrawString("OK", arialFont10Bold88, (XBrush) green, xrect259, topLeft259);
                }
              }
            }
            else
            {
              XGraphics xgraphics260 = PDFFunctions.gfx[L1ACheckList.k];
              XFont arialFont10_164 = PDFFunctions.ArialFont10;
              XSolidBrush black182 = XBrushes.Black;
              double num499 = (double) checked (L1ACheckList.RC1 + 1);
              xunit = PDFFunctions.pages[L1ACheckList.k].Width;
              double point264 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[L1ACheckList.k].Height;
              double num500 = ((XUnit) ref xunit).Point / 2.0;
              XRect xrect260 = new XRect(200.0, num499, point264, num500);
              XStringFormat topLeft260 = XStringFormat.TopLeft;
              xgraphics260.DrawString("SAP default data", arialFont10_164, (XBrush) black182, xrect260, topLeft260);
              XGraphics xgraphics261 = PDFFunctions.gfx[L1ACheckList.k];
              XFont arialFont10Bold89 = PDFFunctions.ArialFont10Bold;
              XSolidBrush red = XBrushes.Red;
              double num501 = (double) checked (L1ACheckList.RC1 + 1);
              xunit = PDFFunctions.pages[L1ACheckList.k].Width;
              double point265 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[L1ACheckList.k].Height;
              double num502 = ((XUnit) ref xunit).Point / 2.0;
              XRect xrect261 = new XRect(540.0, num501, point265, num502);
              XStringFormat topLeft261 = XStringFormat.TopLeft;
              xgraphics261.DrawString("Fail", arialFont10Bold89, (XBrush) red, xrect261, topLeft261);
              flag2 = true;
            }
          }
          else if (sapTableCode6 >= 128 && sapTableCode6 <= 130)
          {
            XGraphics xgraphics262 = PDFFunctions.gfx[L1ACheckList.k];
            XFont arialFont10_165 = PDFFunctions.ArialFont10;
            XSolidBrush black183 = XBrushes.Black;
            double num503 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point266 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num504 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect262 = new XRect(200.0, num503, point266, num504);
            XStringFormat topLeft262 = XStringFormat.TopLeft;
            xgraphics262.DrawString("Minimum 86.0 %", arialFont10_165, (XBrush) black183, xrect262, topLeft262);
            checked { L1ACheckList.RC1 += 13; }
            // ISSUE: reference to a compiler-generated field
            if ((double) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.MainEff < 86.0)
            {
              XGraphics xgraphics263 = PDFFunctions.gfx[L1ACheckList.k];
              XFont arialFont10Bold90 = PDFFunctions.ArialFont10Bold;
              XSolidBrush red = XBrushes.Red;
              double num505 = (double) checked (L1ACheckList.RC1 + 1);
              xunit = PDFFunctions.pages[L1ACheckList.k].Width;
              double point267 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[L1ACheckList.k].Height;
              double num506 = ((XUnit) ref xunit).Point / 2.0;
              XRect xrect263 = new XRect(540.0, num505, point267, num506);
              XStringFormat topLeft263 = XStringFormat.TopLeft;
              xgraphics263.DrawString("Fail", arialFont10Bold90, (XBrush) red, xrect263, topLeft263);
              flag2 = true;
            }
            else
            {
              XGraphics xgraphics264 = PDFFunctions.gfx[L1ACheckList.k];
              XFont arialFont10Bold91 = PDFFunctions.ArialFont10Bold;
              XSolidBrush green = XBrushes.Green;
              double num507 = (double) checked (L1ACheckList.RC1 + 1);
              xunit = PDFFunctions.pages[L1ACheckList.k].Width;
              double point268 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[L1ACheckList.k].Height;
              double num508 = ((XUnit) ref xunit).Point / 2.0;
              XRect xrect264 = new XRect(540.0, num507, point268, num508);
              XStringFormat topLeft264 = XStringFormat.TopLeft;
              xgraphics264.DrawString("OK", arialFont10Bold91, (XBrush) green, xrect264, topLeft264);
            }
          }
          else if (sapTableCode6 == 124 || sapTableCode6 == 125 || sapTableCode6 == 126 || sapTableCode6 == (int) sbyte.MaxValue)
          {
            // ISSUE: reference to a compiler-generated field
            double num509 = !SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.SEDBUK2005 ? 88.0 : 90.0;
            XGraphics xgraphics265 = PDFFunctions.gfx[L1ACheckList.k];
            string str100 = "Minimum " + Conversions.ToString(num509) + " %";
            XFont arialFont10_166 = PDFFunctions.ArialFont10;
            XSolidBrush black184 = XBrushes.Black;
            double num510 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point269 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num511 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect265 = new XRect(200.0, num510, point269, num511);
            XStringFormat topLeft265 = XStringFormat.TopLeft;
            xgraphics265.DrawString(str100, arialFont10_166, (XBrush) black184, xrect265, topLeft265);
            checked { L1ACheckList.RC1 += 13; }
            // ISSUE: reference to a compiler-generated field
            if ((double) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.MainEff < num509)
            {
              XGraphics xgraphics266 = PDFFunctions.gfx[L1ACheckList.k];
              XFont arialFont10Bold92 = PDFFunctions.ArialFont10Bold;
              XSolidBrush red = XBrushes.Red;
              double num512 = (double) checked (L1ACheckList.RC1 + 1);
              xunit = PDFFunctions.pages[L1ACheckList.k].Width;
              double point270 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[L1ACheckList.k].Height;
              double num513 = ((XUnit) ref xunit).Point / 2.0;
              XRect xrect266 = new XRect(540.0, num512, point270, num513);
              XStringFormat topLeft266 = XStringFormat.TopLeft;
              xgraphics266.DrawString("Fail", arialFont10Bold92, (XBrush) red, xrect266, topLeft266);
              flag2 = true;
            }
            else
            {
              XGraphics xgraphics267 = PDFFunctions.gfx[L1ACheckList.k];
              XFont arialFont10Bold93 = PDFFunctions.ArialFont10Bold;
              XSolidBrush green = XBrushes.Green;
              double num514 = (double) checked (L1ACheckList.RC1 + 1);
              xunit = PDFFunctions.pages[L1ACheckList.k].Width;
              double point271 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[L1ACheckList.k].Height;
              double num515 = ((XUnit) ref xunit).Point / 2.0;
              XRect xrect267 = new XRect(540.0, num514, point271, num515);
              XStringFormat topLeft267 = XStringFormat.TopLeft;
              xgraphics267.DrawString("OK", arialFont10Bold93, (XBrush) green, xrect267, topLeft267);
            }
          }
          else if (sapTableCode6 >= 131 && sapTableCode6 <= 132)
          {
            XGraphics xgraphics268 = PDFFunctions.gfx[L1ACheckList.k];
            XFont arialFont10_167 = PDFFunctions.ArialFont10;
            XSolidBrush black185 = XBrushes.Black;
            double num516 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point272 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num517 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect268 = new XRect(200.0, num516, point272, num517);
            XStringFormat topLeft268 = XStringFormat.TopLeft;
            xgraphics268.DrawString("Minimum 60.0 %", arialFont10_167, (XBrush) black185, xrect268, topLeft268);
            checked { L1ACheckList.RC1 += 13; }
            // ISSUE: reference to a compiler-generated field
            if ((double) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.MainEff < 60.0)
            {
              XGraphics xgraphics269 = PDFFunctions.gfx[L1ACheckList.k];
              XFont arialFont10Bold94 = PDFFunctions.ArialFont10Bold;
              XSolidBrush red = XBrushes.Red;
              double num518 = (double) checked (L1ACheckList.RC1 + 1);
              xunit = PDFFunctions.pages[L1ACheckList.k].Width;
              double point273 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[L1ACheckList.k].Height;
              double num519 = ((XUnit) ref xunit).Point / 2.0;
              XRect xrect269 = new XRect(540.0, num518, point273, num519);
              XStringFormat topLeft269 = XStringFormat.TopLeft;
              xgraphics269.DrawString("Fail", arialFont10Bold94, (XBrush) red, xrect269, topLeft269);
              flag2 = true;
            }
            else
            {
              XGraphics xgraphics270 = PDFFunctions.gfx[L1ACheckList.k];
              XFont arialFont10Bold95 = PDFFunctions.ArialFont10Bold;
              XSolidBrush green = XBrushes.Green;
              double num520 = (double) checked (L1ACheckList.RC1 + 1);
              xunit = PDFFunctions.pages[L1ACheckList.k].Width;
              double point274 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[L1ACheckList.k].Height;
              double num521 = ((XUnit) ref xunit).Point / 2.0;
              XRect xrect270 = new XRect(540.0, num520, point274, num521);
              XStringFormat topLeft270 = XStringFormat.TopLeft;
              xgraphics270.DrawString("OK", arialFont10Bold95, (XBrush) green, xrect270, topLeft270);
            }
          }
          else if (sapTableCode6 >= 133 && sapTableCode6 <= 138)
          {
            // ISSUE: reference to a compiler-generated field
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.InforSource, "Manufacturer Declaration", false) == 0)
            {
              XGraphics xgraphics271 = PDFFunctions.gfx[L1ACheckList.k];
              XFont arialFont10_168 = PDFFunctions.ArialFont10;
              XSolidBrush black186 = XBrushes.Black;
              double num522 = (double) checked (L1ACheckList.RC1 + 1);
              xunit = PDFFunctions.pages[L1ACheckList.k].Width;
              double point275 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[L1ACheckList.k].Height;
              double num523 = ((XUnit) ref xunit).Point / 2.0;
              XRect xrect271 = new XRect(200.0, num522, point275, num523);
              XStringFormat topLeft271 = XStringFormat.TopLeft;
              xgraphics271.DrawString("Minimum 75.0 %", arialFont10_168, (XBrush) black186, xrect271, topLeft271);
              checked { L1ACheckList.RC1 += 13; }
              // ISSUE: reference to a compiler-generated field
              if ((double) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.MainEff < 75.0)
              {
                XGraphics xgraphics272 = PDFFunctions.gfx[L1ACheckList.k];
                XFont arialFont10Bold96 = PDFFunctions.ArialFont10Bold;
                XSolidBrush red = XBrushes.Red;
                double num524 = (double) checked (L1ACheckList.RC1 + 1);
                xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                double point276 = ((XUnit) ref xunit).Point;
                xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                double num525 = ((XUnit) ref xunit).Point / 2.0;
                XRect xrect272 = new XRect(540.0, num524, point276, num525);
                XStringFormat topLeft272 = XStringFormat.TopLeft;
                xgraphics272.DrawString("Fail", arialFont10Bold96, (XBrush) red, xrect272, topLeft272);
                flag2 = true;
              }
              else
              {
                XGraphics xgraphics273 = PDFFunctions.gfx[L1ACheckList.k];
                XFont arialFont10Bold97 = PDFFunctions.ArialFont10Bold;
                XSolidBrush green = XBrushes.Green;
                double num526 = (double) checked (L1ACheckList.RC1 + 1);
                xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                double point277 = ((XUnit) ref xunit).Point;
                xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                double num527 = ((XUnit) ref xunit).Point / 2.0;
                XRect xrect273 = new XRect(540.0, num526, point277, num527);
                XStringFormat topLeft273 = XStringFormat.TopLeft;
                xgraphics273.DrawString("OK", arialFont10Bold97, (XBrush) green, xrect273, topLeft273);
              }
            }
            L1ACheckList.CheckCheckListRC1();
          }
          else if (sapTableCode6 != 191 && (sapTableCode6 < 421 || sapTableCode6 > 425) && (sapTableCode6 < 691 || sapTableCode6 > 694) && sapTableCode6 != 515 && (sapTableCode6 < 211 || sapTableCode6 > 224) && (sapTableCode6 < 401 || sapTableCode6 > 409))
          {
            if (sapTableCode6 >= 133 && sapTableCode6 <= 138)
            {
              // ISSUE: reference to a compiler-generated field
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.InforSource, "SAP Tables", false) == 0)
              {
                XGraphics xgraphics274 = PDFFunctions.gfx[L1ACheckList.k];
                // ISSUE: reference to a compiler-generated field
                string str101 = "Efficiency " + Microsoft.VisualBasic.Strings.Format((object) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.MainEff, "00.0") + " %";
                XFont arialFont10_169 = PDFFunctions.ArialFont10;
                XSolidBrush black187 = XBrushes.Black;
                double num528 = (double) checked (L1ACheckList.RC1 + 1);
                xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                double point278 = ((XUnit) ref xunit).Point;
                xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                double num529 = ((XUnit) ref xunit).Point / 2.0;
                XRect xrect274 = new XRect(200.0, num528, point278, num529);
                XStringFormat topLeft274 = XStringFormat.TopLeft;
                xgraphics274.DrawString(str101, arialFont10_169, (XBrush) black187, xrect274, topLeft274);
                checked { L1ACheckList.RC1 += 13; }
              }
              XGraphics xgraphics275 = PDFFunctions.gfx[L1ACheckList.k];
              XFont arialFont10_170 = PDFFunctions.ArialFont10;
              XSolidBrush black188 = XBrushes.Black;
              double num530 = (double) checked (L1ACheckList.RC1 + 1);
              xunit = PDFFunctions.pages[L1ACheckList.k].Width;
              double point279 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[L1ACheckList.k].Height;
              double num531 = ((XUnit) ref xunit).Point / 2.0;
              XRect xrect275 = new XRect(200.0, num530, point279, num531);
              XStringFormat topLeft275 = XStringFormat.TopLeft;
              xgraphics275.DrawString("Minimum 75.0 %", arialFont10_170, (XBrush) black188, xrect275, topLeft275);
              checked { L1ACheckList.RC1 += 13; }
              // ISSUE: reference to a compiler-generated field
              if ((double) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.MainEff < 75.0)
              {
                XGraphics xgraphics276 = PDFFunctions.gfx[L1ACheckList.k];
                XFont arialFont10Bold98 = PDFFunctions.ArialFont10Bold;
                XSolidBrush red = XBrushes.Red;
                double num532 = (double) checked (L1ACheckList.RC1 + 1);
                xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                double point280 = ((XUnit) ref xunit).Point;
                xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                double num533 = ((XUnit) ref xunit).Point / 2.0;
                XRect xrect276 = new XRect(540.0, num532, point280, num533);
                XStringFormat topLeft276 = XStringFormat.TopLeft;
                xgraphics276.DrawString("Fail", arialFont10Bold98, (XBrush) red, xrect276, topLeft276);
                flag2 = true;
              }
              else
              {
                XGraphics xgraphics277 = PDFFunctions.gfx[L1ACheckList.k];
                XFont arialFont10Bold99 = PDFFunctions.ArialFont10Bold;
                XSolidBrush green = XBrushes.Green;
                double num534 = (double) checked (L1ACheckList.RC1 + 1);
                xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                double point281 = ((XUnit) ref xunit).Point;
                xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                double num535 = ((XUnit) ref xunit).Point / 2.0;
                XRect xrect277 = new XRect(540.0, num534, point281, num535);
                XStringFormat topLeft277 = XStringFormat.TopLeft;
                xgraphics277.DrawString("OK", arialFont10Bold99, (XBrush) green, xrect277, topLeft277);
              }
            }
            else if (sapTableCode6 >= 139 && sapTableCode6 <= 141)
            {
              XGraphics xgraphics278 = PDFFunctions.gfx[L1ACheckList.k];
              XFont arialFont10_171 = PDFFunctions.ArialFont10;
              XSolidBrush black189 = XBrushes.Black;
              double num536 = (double) checked (L1ACheckList.RC1 + 1);
              xunit = PDFFunctions.pages[L1ACheckList.k].Width;
              double point282 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[L1ACheckList.k].Height;
              double num537 = ((XUnit) ref xunit).Point / 2.0;
              XRect xrect278 = new XRect(200.0, num536, point282, num537);
              XStringFormat topLeft278 = XStringFormat.TopLeft;
              xgraphics278.DrawString("Minimum 80.0 %", arialFont10_171, (XBrush) black189, xrect278, topLeft278);
              checked { L1ACheckList.RC1 += 13; }
              // ISSUE: reference to a compiler-generated field
              if ((double) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.MainEff < 80.0)
              {
                XGraphics xgraphics279 = PDFFunctions.gfx[L1ACheckList.k];
                XFont arialFont10_172 = PDFFunctions.ArialFont10;
                XSolidBrush black190 = XBrushes.Black;
                double num538 = (double) checked (L1ACheckList.RC1 + 1);
                xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                double point283 = ((XUnit) ref xunit).Point;
                xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                double num539 = ((XUnit) ref xunit).Point / 2.0;
                XRect xrect279 = new XRect(200.0, num538, point283, num539);
                XStringFormat topLeft279 = XStringFormat.TopLeft;
                xgraphics279.DrawString("SAP default data", arialFont10_172, (XBrush) black190, xrect279, topLeft279);
                XGraphics xgraphics280 = PDFFunctions.gfx[L1ACheckList.k];
                XFont arialFont10Bold100 = PDFFunctions.ArialFont10Bold;
                XSolidBrush red = XBrushes.Red;
                double num540 = (double) checked (L1ACheckList.RC1 + 1);
                xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                double point284 = ((XUnit) ref xunit).Point;
                xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                double num541 = ((XUnit) ref xunit).Point / 2.0;
                XRect xrect280 = new XRect(540.0, num540, point284, num541);
                XStringFormat topLeft280 = XStringFormat.TopLeft;
                xgraphics280.DrawString("Fail", arialFont10Bold100, (XBrush) red, xrect280, topLeft280);
                flag2 = true;
              }
              else
              {
                XGraphics xgraphics281 = PDFFunctions.gfx[L1ACheckList.k];
                XFont arialFont10Bold101 = PDFFunctions.ArialFont10Bold;
                XSolidBrush green = XBrushes.Green;
                double num542 = (double) checked (L1ACheckList.RC1 + 1);
                xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                double point285 = ((XUnit) ref xunit).Point;
                xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                double num543 = ((XUnit) ref xunit).Point / 2.0;
                XRect xrect281 = new XRect(540.0, num542, point285, num543);
                XStringFormat topLeft281 = XStringFormat.TopLeft;
                xgraphics281.DrawString("OK", arialFont10Bold101, (XBrush) green, xrect281, topLeft281);
              }
            }
            else if (sapTableCode6 >= 151 && sapTableCode6 <= 161)
            {
              float Expression5;
              // ISSUE: reference to a compiler-generated field
              switch (SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.SAPTableCode)
              {
                case 151:
                  Expression5 = 65f;
                  break;
                case 152:
                  Expression5 = 60f;
                  break;
                case 153:
                  Expression5 = 70f;
                  break;
                case 154:
                  Expression5 = 65f;
                  break;
                case 155:
                  Expression5 = 65f;
                  break;
                case 156:
                  Expression5 = 63f;
                  break;
                case 158:
                  Expression5 = 67f;
                  break;
                case 159:
                  Expression5 = 65f;
                  break;
                case 160:
                  Expression5 = 50f;
                  break;
                case 161:
                  Expression5 = 60f;
                  break;
              }
              // ISSUE: reference to a compiler-generated field
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.Fuel, "wood pellets (bulk supply in bags, for main heating)", false) == 0)
                Expression5 = 75f;
              // ISSUE: reference to a compiler-generated field
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.InforSource, "SAP Tables", false) == 0)
              {
                XGraphics xgraphics282 = PDFFunctions.gfx[L1ACheckList.k];
                // ISSUE: reference to a compiler-generated field
                string str102 = "Efficiency " + Microsoft.VisualBasic.Strings.Format((object) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.MainEff, "00.0") + " %";
                XFont arialFont10_173 = PDFFunctions.ArialFont10;
                XSolidBrush black191 = XBrushes.Black;
                double num544 = (double) checked (L1ACheckList.RC1 + 1);
                xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                double point286 = ((XUnit) ref xunit).Point;
                xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                double num545 = ((XUnit) ref xunit).Point / 2.0;
                XRect xrect282 = new XRect(200.0, num544, point286, num545);
                XStringFormat topLeft282 = XStringFormat.TopLeft;
                xgraphics282.DrawString(str102, arialFont10_173, (XBrush) black191, xrect282, topLeft282);
                checked { L1ACheckList.RC1 += 13; }
              }
              XGraphics xgraphics283 = PDFFunctions.gfx[L1ACheckList.k];
              string str103 = "Minimum " + Microsoft.VisualBasic.Strings.Format((object) Expression5, "00.0") + " %";
              XFont arialFont10_174 = PDFFunctions.ArialFont10;
              XSolidBrush black192 = XBrushes.Black;
              double num546 = (double) checked (L1ACheckList.RC1 + 1);
              xunit = PDFFunctions.pages[L1ACheckList.k].Width;
              double point287 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[L1ACheckList.k].Height;
              double num547 = ((XUnit) ref xunit).Point / 2.0;
              XRect xrect283 = new XRect(200.0, num546, point287, num547);
              XStringFormat topLeft283 = XStringFormat.TopLeft;
              xgraphics283.DrawString(str103, arialFont10_174, (XBrush) black192, xrect283, topLeft283);
              checked { L1ACheckList.RC1 += 13; }
              // ISSUE: reference to a compiler-generated field
              if ((double) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.MainEff < (double) Expression5)
              {
                XGraphics xgraphics284 = PDFFunctions.gfx[L1ACheckList.k];
                XFont arialFont10Bold102 = PDFFunctions.ArialFont10Bold;
                XSolidBrush red = XBrushes.Red;
                double num548 = (double) checked (L1ACheckList.RC1 + 1);
                xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                double point288 = ((XUnit) ref xunit).Point;
                xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                double num549 = ((XUnit) ref xunit).Point / 2.0;
                XRect xrect284 = new XRect(540.0, num548, point288, num549);
                XStringFormat topLeft284 = XStringFormat.TopLeft;
                xgraphics284.DrawString("Fail", arialFont10Bold102, (XBrush) red, xrect284, topLeft284);
                flag2 = true;
              }
              else
              {
                XGraphics xgraphics285 = PDFFunctions.gfx[L1ACheckList.k];
                XFont arialFont10Bold103 = PDFFunctions.ArialFont10Bold;
                XSolidBrush green = XBrushes.Green;
                double num550 = (double) checked (L1ACheckList.RC1 + 1);
                xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                double point289 = ((XUnit) ref xunit).Point;
                xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                double num551 = ((XUnit) ref xunit).Point / 2.0;
                XRect xrect285 = new XRect(540.0, num550, point289, num551);
                XStringFormat topLeft285 = XStringFormat.TopLeft;
                xgraphics285.DrawString("OK", arialFont10Bold103, (XBrush) green, xrect285, topLeft285);
              }
            }
            else if ((sapTableCode6 < 305 || sapTableCode6 > 310) && sapTableCode6 != 701)
            {
              if (sapTableCode6 >= 501 && sapTableCode6 <= 511)
              {
                // ISSUE: reference to a compiler-generated field
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.InforSource, "SAP Tables", false) == 0)
                {
                  XGraphics xgraphics286 = PDFFunctions.gfx[L1ACheckList.k];
                  // ISSUE: reference to a compiler-generated field
                  string str104 = "Efficiency " + Microsoft.VisualBasic.Strings.Format((object) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.MainEff, "00.0") + " %";
                  XFont arialFont10_175 = PDFFunctions.ArialFont10;
                  XSolidBrush black193 = XBrushes.Black;
                  double num552 = (double) checked (L1ACheckList.RC1 + 1);
                  xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                  double point290 = ((XUnit) ref xunit).Point;
                  xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                  double num553 = ((XUnit) ref xunit).Point / 2.0;
                  XRect xrect286 = new XRect(200.0, num552, point290, num553);
                  XStringFormat topLeft286 = XStringFormat.TopLeft;
                  xgraphics286.DrawString(str104, arialFont10_175, (XBrush) black193, xrect286, topLeft286);
                  checked { L1ACheckList.RC1 += 13; }
                }
                XGraphics xgraphics287 = PDFFunctions.gfx[L1ACheckList.k];
                XFont arialFont10_176 = PDFFunctions.ArialFont10;
                XSolidBrush black194 = XBrushes.Black;
                double num554 = (double) checked (L1ACheckList.RC1 + 1);
                xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                double point291 = ((XUnit) ref xunit).Point;
                xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                double num555 = ((XUnit) ref xunit).Point / 2.0;
                XRect xrect287 = new XRect(200.0, num554, point291, num555);
                XStringFormat topLeft287 = XStringFormat.TopLeft;
                xgraphics287.DrawString("Minimum 76.0 %", arialFont10_176, (XBrush) black194, xrect287, topLeft287);
                // ISSUE: reference to a compiler-generated field
                if ((double) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.MainEff < 76.0)
                {
                  XGraphics xgraphics288 = PDFFunctions.gfx[L1ACheckList.k];
                  XFont arialFont10Bold104 = PDFFunctions.ArialFont10Bold;
                  XSolidBrush red = XBrushes.Red;
                  double num556 = (double) checked (L1ACheckList.RC1 + 1);
                  xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                  double point292 = ((XUnit) ref xunit).Point;
                  xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                  double num557 = ((XUnit) ref xunit).Point / 2.0;
                  XRect xrect288 = new XRect(540.0, num556, point292, num557);
                  XStringFormat topLeft288 = XStringFormat.TopLeft;
                  xgraphics288.DrawString("Fail", arialFont10Bold104, (XBrush) red, xrect288, topLeft288);
                  flag2 = true;
                }
                else
                {
                  XGraphics xgraphics289 = PDFFunctions.gfx[L1ACheckList.k];
                  XFont arialFont10Bold105 = PDFFunctions.ArialFont10Bold;
                  XSolidBrush green = XBrushes.Green;
                  double num558 = (double) checked (L1ACheckList.RC1 + 1);
                  xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                  double point293 = ((XUnit) ref xunit).Point;
                  xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                  double num559 = ((XUnit) ref xunit).Point / 2.0;
                  XRect xrect289 = new XRect(540.0, num558, point293, num559);
                  XStringFormat topLeft289 = XStringFormat.TopLeft;
                  xgraphics289.DrawString("OK", arialFont10Bold105, (XBrush) green, xrect289, topLeft289);
                }
              }
              else if (sapTableCode6 == 632 || sapTableCode6 == 634 || sapTableCode6 == 636)
              {
                // ISSUE: reference to a compiler-generated field
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.InforSource, "SAP Tables", false) == 0)
                {
                  XGraphics xgraphics290 = PDFFunctions.gfx[L1ACheckList.k];
                  // ISSUE: reference to a compiler-generated field
                  string str105 = "Efficiency " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.MainEff) + " %";
                  XFont arialFont10_177 = PDFFunctions.ArialFont10;
                  XSolidBrush black195 = XBrushes.Black;
                  double num560 = (double) checked (L1ACheckList.RC1 + 1);
                  xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                  double point294 = ((XUnit) ref xunit).Point;
                  xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                  double num561 = ((XUnit) ref xunit).Point / 2.0;
                  XRect xrect290 = new XRect(200.0, num560, point294, num561);
                  XStringFormat topLeft290 = XStringFormat.TopLeft;
                  xgraphics290.DrawString(str105, arialFont10_177, (XBrush) black195, xrect290, topLeft290);
                  checked { L1ACheckList.RC1 += 13; }
                }
                XGraphics xgraphics291 = PDFFunctions.gfx[L1ACheckList.k];
                XFont arialFont10_178 = PDFFunctions.ArialFont10;
                XSolidBrush black196 = XBrushes.Black;
                double num562 = (double) checked (L1ACheckList.RC1 + 1);
                xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                double point295 = ((XUnit) ref xunit).Point;
                xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                double num563 = ((XUnit) ref xunit).Point / 2.0;
                XRect xrect291 = new XRect(200.0, num562, point295, num563);
                XStringFormat topLeft291 = XStringFormat.TopLeft;
                xgraphics291.DrawString("Minimum 65.0 %", arialFont10_178, (XBrush) black196, xrect291, topLeft291);
                // ISSUE: reference to a compiler-generated field
                if ((double) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.MainEff < 65.0)
                {
                  XGraphics xgraphics292 = PDFFunctions.gfx[L1ACheckList.k];
                  XFont arialFont10Bold106 = PDFFunctions.ArialFont10Bold;
                  XSolidBrush red = XBrushes.Red;
                  double num564 = (double) checked (L1ACheckList.RC1 + 1);
                  xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                  double point296 = ((XUnit) ref xunit).Point;
                  xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                  double num565 = ((XUnit) ref xunit).Point / 2.0;
                  XRect xrect292 = new XRect(540.0, num564, point296, num565);
                  XStringFormat topLeft292 = XStringFormat.TopLeft;
                  xgraphics292.DrawString("Fail", arialFont10Bold106, (XBrush) red, xrect292, topLeft292);
                  flag2 = true;
                }
                else
                {
                  XGraphics xgraphics293 = PDFFunctions.gfx[L1ACheckList.k];
                  XFont arialFont10Bold107 = PDFFunctions.ArialFont10Bold;
                  XSolidBrush green = XBrushes.Green;
                  double num566 = (double) checked (L1ACheckList.RC1 + 1);
                  xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                  double point297 = ((XUnit) ref xunit).Point;
                  xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                  double num567 = ((XUnit) ref xunit).Point / 2.0;
                  XRect xrect293 = new XRect(540.0, num566, point297, num567);
                  XStringFormat topLeft293 = XStringFormat.TopLeft;
                  xgraphics293.DrawString("OK", arialFont10Bold107, (XBrush) green, xrect293, topLeft293);
                }
              }
              else if (sapTableCode6 != 202 && sapTableCode6 != 203 && sapTableCode6 != 204)
              {
                if (sapTableCode6 >= 621 && sapTableCode6 <= 624)
                {
                  // ISSUE: reference to a compiler-generated field
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.InforSource, "SAP Tables", false) == 0)
                  {
                    XGraphics xgraphics294 = PDFFunctions.gfx[L1ACheckList.k];
                    // ISSUE: reference to a compiler-generated field
                    string str106 = "Efficiency " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.MainEff) + " %";
                    XFont arialFont10_179 = PDFFunctions.ArialFont10;
                    XSolidBrush black197 = XBrushes.Black;
                    double num568 = (double) checked (L1ACheckList.RC1 + 1);
                    xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                    double point298 = ((XUnit) ref xunit).Point;
                    xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                    double num569 = ((XUnit) ref xunit).Point / 2.0;
                    XRect xrect294 = new XRect(200.0, num568, point298, num569);
                    XStringFormat topLeft294 = XStringFormat.TopLeft;
                    xgraphics294.DrawString(str106, arialFont10_179, (XBrush) black197, xrect294, topLeft294);
                    checked { L1ACheckList.RC1 += 13; }
                  }
                  XGraphics xgraphics295 = PDFFunctions.gfx[L1ACheckList.k];
                  XFont arialFont10_180 = PDFFunctions.ArialFont10;
                  XSolidBrush black198 = XBrushes.Black;
                  double num570 = (double) checked (L1ACheckList.RC1 + 1);
                  xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                  double point299 = ((XUnit) ref xunit).Point;
                  xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                  double num571 = ((XUnit) ref xunit).Point / 2.0;
                  XRect xrect295 = new XRect(200.0, num570, point299, num571);
                  XStringFormat topLeft295 = XStringFormat.TopLeft;
                  xgraphics295.DrawString("Minimum 60.0 %", arialFont10_180, (XBrush) black198, xrect295, topLeft295);
                  // ISSUE: reference to a compiler-generated field
                  if ((double) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.MainEff < 60.0)
                  {
                    XGraphics xgraphics296 = PDFFunctions.gfx[L1ACheckList.k];
                    XFont arialFont10Bold108 = PDFFunctions.ArialFont10Bold;
                    XSolidBrush red = XBrushes.Red;
                    double num572 = (double) checked (L1ACheckList.RC1 + 1);
                    xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                    double point300 = ((XUnit) ref xunit).Point;
                    xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                    double num573 = ((XUnit) ref xunit).Point / 2.0;
                    XRect xrect296 = new XRect(540.0, num572, point300, num573);
                    XStringFormat topLeft296 = XStringFormat.TopLeft;
                    xgraphics296.DrawString("Fail", arialFont10Bold108, (XBrush) red, xrect296, topLeft296);
                    flag2 = true;
                  }
                  else
                  {
                    XGraphics xgraphics297 = PDFFunctions.gfx[L1ACheckList.k];
                    XFont arialFont10Bold109 = PDFFunctions.ArialFont10Bold;
                    XSolidBrush green = XBrushes.Green;
                    double num574 = (double) checked (L1ACheckList.RC1 + 1);
                    xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                    double point301 = ((XUnit) ref xunit).Point;
                    xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                    double num575 = ((XUnit) ref xunit).Point / 2.0;
                    XRect xrect297 = new XRect(540.0, num574, point301, num575);
                    XStringFormat topLeft297 = XStringFormat.TopLeft;
                    xgraphics297.DrawString("OK", arialFont10Bold109, (XBrush) green, xrect297, topLeft297);
                  }
                }
                else
                {
                  // ISSUE: reference to a compiler-generated field
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.InforSource, "Manufacturer Declaration", false) == 0)
                  {
                    XGraphics xgraphics298 = PDFFunctions.gfx[L1ACheckList.k];
                    // ISSUE: reference to a compiler-generated field
                    string str107 = "Minimum " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.MainEff) + " %";
                    XFont arialFont10_181 = PDFFunctions.ArialFont10;
                    XSolidBrush black199 = XBrushes.Black;
                    double num576 = (double) checked (L1ACheckList.RC1 + 1);
                    xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                    double point302 = ((XUnit) ref xunit).Point;
                    xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                    double num577 = ((XUnit) ref xunit).Point / 2.0;
                    XRect xrect298 = new XRect(200.0, num576, point302, num577);
                    XStringFormat topLeft298 = XStringFormat.TopLeft;
                    xgraphics298.DrawString(str107, arialFont10_181, (XBrush) black199, xrect298, topLeft298);
                    checked { L1ACheckList.RC1 += 13; }
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    if ((double) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.MainEff < (double) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.MainEff)
                    {
                      XGraphics xgraphics299 = PDFFunctions.gfx[L1ACheckList.k];
                      XFont arialFont10Bold110 = PDFFunctions.ArialFont10Bold;
                      XSolidBrush red = XBrushes.Red;
                      double num578 = (double) checked (L1ACheckList.RC1 + 1);
                      xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                      double point303 = ((XUnit) ref xunit).Point;
                      xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                      double num579 = ((XUnit) ref xunit).Point / 2.0;
                      XRect xrect299 = new XRect(540.0, num578, point303, num579);
                      XStringFormat topLeft299 = XStringFormat.TopLeft;
                      xgraphics299.DrawString("Fail", arialFont10Bold110, (XBrush) red, xrect299, topLeft299);
                      flag2 = true;
                    }
                    else
                    {
                      XGraphics xgraphics300 = PDFFunctions.gfx[L1ACheckList.k];
                      XFont arialFont10Bold111 = PDFFunctions.ArialFont10Bold;
                      XSolidBrush green = XBrushes.Green;
                      double num580 = (double) checked (L1ACheckList.RC1 + 1);
                      xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                      double point304 = ((XUnit) ref xunit).Point;
                      xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                      double num581 = ((XUnit) ref xunit).Point / 2.0;
                      XRect xrect300 = new XRect(540.0, num580, point304, num581);
                      XStringFormat topLeft300 = XStringFormat.TopLeft;
                      xgraphics300.DrawString("OK", arialFont10Bold111, (XBrush) green, xrect300, topLeft300);
                    }
                  }
                  else
                  {
                    // ISSUE: reference to a compiler-generated field
                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.InforSource, "SAP Tables", false) == 0)
                    {
                      XGraphics xgraphics301 = PDFFunctions.gfx[L1ACheckList.k];
                      // ISSUE: reference to a compiler-generated field
                      string str108 = "Efficiency " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.MainEff) + " %";
                      XFont arialFont10_182 = PDFFunctions.ArialFont10;
                      XSolidBrush black200 = XBrushes.Black;
                      double num582 = (double) checked (L1ACheckList.RC1 + 1);
                      xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                      double point305 = ((XUnit) ref xunit).Point;
                      xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                      double num583 = ((XUnit) ref xunit).Point / 2.0;
                      XRect xrect301 = new XRect(200.0, num582, point305, num583);
                      XStringFormat topLeft301 = XStringFormat.TopLeft;
                      xgraphics301.DrawString(str108, arialFont10_182, (XBrush) black200, xrect301, topLeft301);
                      checked { L1ACheckList.RC1 += 13; }
                      XGraphics xgraphics302 = PDFFunctions.gfx[L1ACheckList.k];
                      // ISSUE: reference to a compiler-generated field
                      string str109 = "Minimum " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.MainEff) + " %";
                      XFont arialFont10_183 = PDFFunctions.ArialFont10;
                      XSolidBrush black201 = XBrushes.Black;
                      double num584 = (double) checked (L1ACheckList.RC1 + 1);
                      xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                      double point306 = ((XUnit) ref xunit).Point;
                      xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                      double num585 = ((XUnit) ref xunit).Point / 2.0;
                      XRect xrect302 = new XRect(200.0, num584, point306, num585);
                      XStringFormat topLeft302 = XStringFormat.TopLeft;
                      xgraphics302.DrawString(str109, arialFont10_183, (XBrush) black201, xrect302, topLeft302);
                      checked { L1ACheckList.RC1 += 13; }
                    }
                  }
                }
              }
            }
          }
        }
        checked { L1ACheckList.RC1 += 26; }
      }
      L1ACheckList.CheckCheckListRC1();
      XGraphics xgraphics303 = PDFFunctions.gfx[L1ACheckList.k];
      XFont arialFont10_184 = PDFFunctions.ArialFont10;
      XSolidBrush black202 = XBrushes.Black;
      double num586 = (double) checked (L1ACheckList.RC1 + 1);
      xunit = PDFFunctions.pages[L1ACheckList.k].Width;
      double point307 = ((XUnit) ref xunit).Point;
      xunit = PDFFunctions.pages[L1ACheckList.k].Height;
      double num587 = ((XUnit) ref xunit).Point / 2.0;
      XRect xrect303 = new XRect(50.0, num586, point307, num587);
      XStringFormat topLeft303 = XStringFormat.TopLeft;
      xgraphics303.DrawString("Secondary heating system:", arialFont10_184, (XBrush) black202, xrect303, topLeft303);
      // ISSUE: reference to a compiler-generated field
      string fuel6 = SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].SecHeating.Fuel;
      string str110;
      // ISSUE: reference to a compiler-generated method
      switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(fuel6))
      {
        case 157581269:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel6, "heating oil", false) == 0)
          {
            str110 = "oil";
            goto label_771;
          }
          else
            goto default;
        case 721524493:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel6, "dual fuel appliance (mineral and wood)", false) == 0)
          {
            str110 = "dual fuel";
            goto label_771;
          }
          else
            goto default;
        case 975024876:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel6, "bulk LPG", false) == 0)
            break;
          goto default;
        case 1086463322:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel6, "LPG subject to Special Condition 18", false) == 0)
            break;
          goto default;
        case 1441345278:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel6, "Electricity", false) == 0)
          {
            str110 = "electric";
            goto label_771;
          }
          else
            goto default;
        case 1597764060:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel6, "mains gas", false) == 0)
            break;
          goto default;
        case 1946790875:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel6, "wood logs", false) == 0)
            goto label_768;
          else
            goto default;
        case 2251322125:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel6, "wood pellets (in bags, for secondary heating)", false) == 0)
            goto label_768;
          else
            goto default;
        case 3722837730:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel6, "bottled LPG", false) == 0)
            break;
          goto default;
        default:
          // ISSUE: reference to a compiler-generated field
          str110 = SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].SecHeating.Fuel;
          goto label_771;
      }
      str110 = "gas";
      goto label_771;
label_768:
      str110 = "wood";
label_771:
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      if (SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].SecHeating.SAPTableCode == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].SecHeating.Fuel, "", false) == 0)
      {
        XGraphics xgraphics304 = PDFFunctions.gfx[L1ACheckList.k];
        XFont arialFont10_185 = PDFFunctions.ArialFont10;
        XSolidBrush black203 = XBrushes.Black;
        double num588 = (double) checked (L1ACheckList.RC1 + 1);
        xunit = PDFFunctions.pages[L1ACheckList.k].Width;
        double point308 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[L1ACheckList.k].Height;
        double num589 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect304 = new XRect(200.0, num588, point308, num589);
        XStringFormat topLeft304 = XStringFormat.TopLeft;
        xgraphics304.DrawString("None", arialFont10_185, (XBrush) black203, xrect304, topLeft304);
        checked { L1ACheckList.RC1 += 13; }
      }
      else
      {
        XGraphics xgraphics305 = PDFFunctions.gfx[L1ACheckList.k];
        // ISSUE: reference to a compiler-generated field
        string str111 = SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].SecHeating.HGroup + " - " + str110;
        XFont arialFont10_186 = PDFFunctions.ArialFont10;
        XSolidBrush black204 = XBrushes.Black;
        double num590 = (double) checked (L1ACheckList.RC1 + 1);
        xunit = PDFFunctions.pages[L1ACheckList.k].Width;
        double point309 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[L1ACheckList.k].Height;
        double num591 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect305 = new XRect(200.0, num590, point309, num591);
        XStringFormat topLeft305 = XStringFormat.TopLeft;
        xgraphics305.DrawString(str111, arialFont10_186, (XBrush) black204, xrect305, topLeft305);
        checked { L1ACheckList.RC1 += 13; }
        // ISSUE: reference to a compiler-generated field
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].SecHeating.InforSource, "Manufacturer Declaration", false) == 0)
        {
          XGraphics xgraphics306 = PDFFunctions.gfx[L1ACheckList.k];
          // ISSUE: reference to a compiler-generated field
          string str112 = "Data from manufacturer - " + SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].SecHeating.TestMethod;
          XFont arialFont10_187 = PDFFunctions.ArialFont10;
          XSolidBrush black205 = XBrushes.Black;
          double num592 = (double) checked (L1ACheckList.RC1 + 1);
          xunit = PDFFunctions.pages[L1ACheckList.k].Width;
          double point310 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[L1ACheckList.k].Height;
          double num593 = ((XUnit) ref xunit).Point / 2.0;
          XRect xrect306 = new XRect(200.0, num592, point310, num593);
          XStringFormat topLeft306 = XStringFormat.TopLeft;
          xgraphics306.DrawString(str112, arialFont10_187, (XBrush) black205, xrect306, topLeft306);
          checked { L1ACheckList.RC1 += 13; }
        }
        // ISSUE: reference to a compiler-generated field
        switch (SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].SecHeating.SAPTableCode)
        {
          case 604:
            XGraphics xgraphics307 = PDFFunctions.gfx[L1ACheckList.k];
            XFont arialFont10_188 = PDFFunctions.ArialFont10;
            XSolidBrush black206 = XBrushes.Black;
            double num594 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point311 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num595 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect307 = new XRect(200.0, num594, point311, num595);
            XStringFormat topLeft307 = XStringFormat.TopLeft;
            xgraphics307.DrawString("Gas fire, open flue, 1980 or later (open fronted) with BBU", arialFont10_188, (XBrush) black206, xrect307, topLeft307);
            break;
          case 606:
            XGraphics xgraphics308 = PDFFunctions.gfx[L1ACheckList.k];
            XFont arialFont10_189 = PDFFunctions.ArialFont10;
            XSolidBrush black207 = XBrushes.Black;
            double num596 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point312 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num597 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect308 = new XRect(200.0, num596, point312, num597);
            XStringFormat topLeft308 = XStringFormat.TopLeft;
            xgraphics308.DrawString("Flush fitting LFE gas fire with BBU", arialFont10_189, (XBrush) black207, xrect308, topLeft308);
            break;
          default:
            // ISSUE: reference to a compiler-generated field
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].SecHeating.MHType, "Gas fire, open flue, 1980 or later (open fronted),sitting proud of, and sealed to, fireplace opening", false) == 0)
            {
              XGraphics xgraphics309 = PDFFunctions.gfx[L1ACheckList.k];
              XFont arialFont10_190 = PDFFunctions.ArialFont10;
              XSolidBrush black208 = XBrushes.Black;
              double num598 = (double) checked (L1ACheckList.RC1 + 1);
              xunit = PDFFunctions.pages[L1ACheckList.k].Width;
              double point313 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[L1ACheckList.k].Height;
              double num599 = ((XUnit) ref xunit).Point / 2.0;
              XRect xrect309 = new XRect(200.0, num598, point313, num599);
              XStringFormat topLeft309 = XStringFormat.TopLeft;
              xgraphics309.DrawString("Gas fire, open flue, 1980 or later (open fronted)", arialFont10_190, (XBrush) black208, xrect309, topLeft309);
              break;
            }
            XGraphics xgraphics310 = PDFFunctions.gfx[L1ACheckList.k];
            // ISSUE: reference to a compiler-generated field
            string mhType = SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].SecHeating.MHType;
            XFont arialFont10_191 = PDFFunctions.ArialFont10;
            XSolidBrush black209 = XBrushes.Black;
            double num600 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point314 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num601 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect310 = new XRect(200.0, num600, point314, num601);
            XStringFormat topLeft310 = XStringFormat.TopLeft;
            xgraphics310.DrawString(mhType, arialFont10_191, (XBrush) black209, xrect310, topLeft310);
            break;
        }
        checked { L1ACheckList.RC1 += 13; }
        // ISSUE: reference to a compiler-generated field
        if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Address.Country, "Scotland", false) > 0U)
        {
          // ISSUE: reference to a compiler-generated field
          string fuel7 = SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].SecHeating.Fuel;
          // ISSUE: reference to a compiler-generated method
          switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(fuel7))
          {
            case 157581269:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel7, "heating oil", false) == 0)
                goto label_809;
              else
                goto default;
            case 575487477:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel7, "wood pellets (bulk supply in bags, for main heating)", false) == 0)
                goto label_813;
              else
                goto default;
            case 604697910:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel7, "manufactured smokeless fuel", false) == 0)
                goto label_813;
              else
                goto default;
            case 721524493:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel7, "dual fuel appliance (mineral and wood)", false) == 0)
                goto label_813;
              else
                goto default;
            case 857289046:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel7, "house coal", false) == 0)
                goto label_813;
              else
                goto default;
            case 975024876:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel7, "bulk LPG", false) == 0)
                goto default;
              else
                goto default;
            case 1384014791:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel7, "B30K", false) == 0)
                goto label_809;
              else
                goto default;
            case 1441345278:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel7, "Electricity", false) == 0)
                goto default;
              else
                goto default;
            case 1522447619:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel7, "wood chips", false) == 0)
                goto label_813;
              else
                goto default;
            case 1597764060:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel7, "mains gas", false) == 0)
                break;
              goto default;
            case 1770949684:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel7, "appliances able to use mineral oil or liquid biofuel", false) == 0)
                goto label_809;
              else
                goto default;
            case 1946790875:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel7, "wood logs", false) == 0)
                goto label_813;
              else
                goto default;
            case 2251322125:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel7, "wood pellets (in bags, for secondary heating)", false) == 0)
                goto label_813;
              else
                goto default;
            case 2313921600:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel7, "anthracite", false) == 0)
                goto label_813;
              else
                goto default;
            case 2685417441:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel7, "bioethanol from any biomass source", false) == 0)
                goto label_809;
              else
                goto default;
            case 3198893402:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel7, "rapeseed oil", false) == 0)
                goto label_809;
              else
                goto default;
            case 3349323758:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel7, "biodiesel from any biomass source", false) == 0)
                goto label_809;
              else
                goto default;
            case 3722837730:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel7, "bottled LPG", false) == 0)
                break;
              goto default;
            case 4235694608:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel7, "biodiesel from used cooking oil only", false) == 0)
                goto label_809;
              else
                goto default;
            default:
label_826:
              goto label_827;
          }
          // ISSUE: reference to a compiler-generated field
          switch (SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].SecHeating.SAPTableCode)
          {
            case 605:
            case 606:
            case 607:
              XGraphics xgraphics311 = PDFFunctions.gfx[L1ACheckList.k];
              // ISSUE: reference to a compiler-generated field
              string str113 = "Efficiency " + Microsoft.VisualBasic.Strings.Format((object) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].SecHeating.SecEff, "00.0") + " %";
              XFont arialFont10_192 = PDFFunctions.ArialFont10;
              XSolidBrush black210 = XBrushes.Black;
              double num602 = (double) checked (L1ACheckList.RC1 + 1);
              xunit = PDFFunctions.pages[L1ACheckList.k].Width;
              double point315 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[L1ACheckList.k].Height;
              double num603 = ((XUnit) ref xunit).Point / 2.0;
              XRect xrect311 = new XRect(200.0, num602, point315, num603);
              XStringFormat topLeft311 = XStringFormat.TopLeft;
              xgraphics311.DrawString(str113, arialFont10_192, (XBrush) black210, xrect311, topLeft311);
              checked { L1ACheckList.RC1 += 13; }
              XGraphics xgraphics312 = PDFFunctions.gfx[L1ACheckList.k];
              XFont arialFont10_193 = PDFFunctions.ArialFont10;
              XSolidBrush black211 = XBrushes.Black;
              double num604 = (double) checked (L1ACheckList.RC1 + 1);
              xunit = PDFFunctions.pages[L1ACheckList.k].Width;
              double point316 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[L1ACheckList.k].Height;
              double num605 = ((XUnit) ref xunit).Point / 2.0;
              XRect xrect312 = new XRect(200.0, num604, point316, num605);
              XStringFormat topLeft312 = XStringFormat.TopLeft;
              xgraphics312.DrawString("Minimum 45.0 %", arialFont10_193, (XBrush) black211, xrect312, topLeft312);
              // ISSUE: reference to a compiler-generated field
              if ((double) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].SecHeating.SecEff < 45.0)
              {
                XGraphics xgraphics313 = PDFFunctions.gfx[L1ACheckList.k];
                XFont arialFont10Bold112 = PDFFunctions.ArialFont10Bold;
                XSolidBrush red = XBrushes.Red;
                double num606 = (double) checked (L1ACheckList.RC1 + 1);
                xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                double point317 = ((XUnit) ref xunit).Point;
                xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                double num607 = ((XUnit) ref xunit).Point / 2.0;
                XRect xrect313 = new XRect(540.0, num606, point317, num607);
                XStringFormat topLeft313 = XStringFormat.TopLeft;
                xgraphics313.DrawString("Fail", arialFont10Bold112, (XBrush) red, xrect313, topLeft313);
                flag2 = true;
                goto label_826;
              }
              else
              {
                XGraphics xgraphics314 = PDFFunctions.gfx[L1ACheckList.k];
                XFont arialFont10Bold113 = PDFFunctions.ArialFont10Bold;
                XSolidBrush green = XBrushes.Green;
                double num608 = (double) checked (L1ACheckList.RC1 + 1);
                xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                double point318 = ((XUnit) ref xunit).Point;
                xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                double num609 = ((XUnit) ref xunit).Point / 2.0;
                XRect xrect314 = new XRect(540.0, num608, point318, num609);
                XStringFormat topLeft314 = XStringFormat.TopLeft;
                xgraphics314.DrawString("OK", arialFont10Bold113, (XBrush) green, xrect314, topLeft314);
                goto label_826;
              }
            case 612:
            case 613:
              goto label_826;
            default:
              XGraphics xgraphics315 = PDFFunctions.gfx[L1ACheckList.k];
              // ISSUE: reference to a compiler-generated field
              string str114 = "Efficiency " + Microsoft.VisualBasic.Strings.Format((object) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].SecHeating.SecEff, "0.0") + " %";
              XFont arialFont10_194 = PDFFunctions.ArialFont10;
              XSolidBrush black212 = XBrushes.Black;
              double num610 = (double) checked (L1ACheckList.RC1 + 1);
              xunit = PDFFunctions.pages[L1ACheckList.k].Width;
              double point319 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[L1ACheckList.k].Height;
              double num611 = ((XUnit) ref xunit).Point / 2.0;
              XRect xrect315 = new XRect(200.0, num610, point319, num611);
              XStringFormat topLeft315 = XStringFormat.TopLeft;
              xgraphics315.DrawString(str114, arialFont10_194, (XBrush) black212, xrect315, topLeft315);
              checked { L1ACheckList.RC1 += 13; }
              XGraphics xgraphics316 = PDFFunctions.gfx[L1ACheckList.k];
              XFont arialFont10_195 = PDFFunctions.ArialFont10;
              XSolidBrush black213 = XBrushes.Black;
              double num612 = (double) checked (L1ACheckList.RC1 + 1);
              xunit = PDFFunctions.pages[L1ACheckList.k].Width;
              double point320 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[L1ACheckList.k].Height;
              double num613 = ((XUnit) ref xunit).Point / 2.0;
              XRect xrect316 = new XRect(200.0, num612, point320, num613);
              XStringFormat topLeft316 = XStringFormat.TopLeft;
              xgraphics316.DrawString("Minimum 63.0 %", arialFont10_195, (XBrush) black213, xrect316, topLeft316);
              // ISSUE: reference to a compiler-generated field
              if ((double) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].SecHeating.SecEff < 60.0)
              {
                XGraphics xgraphics317 = PDFFunctions.gfx[L1ACheckList.k];
                XFont arialFont10Bold114 = PDFFunctions.ArialFont10Bold;
                XSolidBrush red = XBrushes.Red;
                double num614 = (double) checked (L1ACheckList.RC1 + 1);
                xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                double point321 = ((XUnit) ref xunit).Point;
                xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                double num615 = ((XUnit) ref xunit).Point / 2.0;
                XRect xrect317 = new XRect(540.0, num614, point321, num615);
                XStringFormat topLeft317 = XStringFormat.TopLeft;
                xgraphics317.DrawString("Fail", arialFont10Bold114, (XBrush) red, xrect317, topLeft317);
                flag2 = true;
                goto label_826;
              }
              else
              {
                XGraphics xgraphics318 = PDFFunctions.gfx[L1ACheckList.k];
                XFont arialFont10Bold115 = PDFFunctions.ArialFont10Bold;
                XSolidBrush green = XBrushes.Green;
                double num616 = (double) checked (L1ACheckList.RC1 + 1);
                xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                double point322 = ((XUnit) ref xunit).Point;
                xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                double num617 = ((XUnit) ref xunit).Point / 2.0;
                XRect xrect318 = new XRect(540.0, num616, point322, num617);
                XStringFormat topLeft318 = XStringFormat.TopLeft;
                xgraphics318.DrawString("OK", arialFont10Bold115, (XBrush) green, xrect318, topLeft318);
                goto label_826;
              }
          }
label_809:
          // ISSUE: reference to a compiler-generated field
          int sapTableCode7 = SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].SecHeating.SAPTableCode;
          if (sapTableCode7 >= 621 && sapTableCode7 <= 625)
          {
            XGraphics xgraphics319 = PDFFunctions.gfx[L1ACheckList.k];
            // ISSUE: reference to a compiler-generated field
            string str115 = "Efficiency " + Microsoft.VisualBasic.Strings.Format((object) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].SecHeating.SecEff, "00.0") + " %";
            XFont arialFont10_196 = PDFFunctions.ArialFont10;
            XSolidBrush black214 = XBrushes.Black;
            double num618 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point323 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num619 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect319 = new XRect(200.0, num618, point323, num619);
            XStringFormat topLeft319 = XStringFormat.TopLeft;
            xgraphics319.DrawString(str115, arialFont10_196, (XBrush) black214, xrect319, topLeft319);
            checked { L1ACheckList.RC1 += 13; }
            XGraphics xgraphics320 = PDFFunctions.gfx[L1ACheckList.k];
            XFont arialFont10_197 = PDFFunctions.ArialFont10;
            XSolidBrush black215 = XBrushes.Black;
            double num620 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point324 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num621 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect320 = new XRect(200.0, num620, point324, num621);
            XStringFormat topLeft320 = XStringFormat.TopLeft;
            xgraphics320.DrawString("Minimum 60.0 %", arialFont10_197, (XBrush) black215, xrect320, topLeft320);
            // ISSUE: reference to a compiler-generated field
            if ((double) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].SecHeating.SecEff < 60.0)
            {
              XGraphics xgraphics321 = PDFFunctions.gfx[L1ACheckList.k];
              XFont arialFont10Bold116 = PDFFunctions.ArialFont10Bold;
              XSolidBrush red = XBrushes.Red;
              double num622 = (double) checked (L1ACheckList.RC1 + 1);
              xunit = PDFFunctions.pages[L1ACheckList.k].Width;
              double point325 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[L1ACheckList.k].Height;
              double num623 = ((XUnit) ref xunit).Point / 2.0;
              XRect xrect321 = new XRect(540.0, num622, point325, num623);
              XStringFormat topLeft321 = XStringFormat.TopLeft;
              xgraphics321.DrawString("Fail", arialFont10Bold116, (XBrush) red, xrect321, topLeft321);
              flag2 = true;
              goto label_826;
            }
            else
            {
              XGraphics xgraphics322 = PDFFunctions.gfx[L1ACheckList.k];
              XFont arialFont10Bold117 = PDFFunctions.ArialFont10Bold;
              XSolidBrush green = XBrushes.Green;
              double num624 = (double) checked (L1ACheckList.RC1 + 1);
              xunit = PDFFunctions.pages[L1ACheckList.k].Width;
              double point326 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[L1ACheckList.k].Height;
              double num625 = ((XUnit) ref xunit).Point / 2.0;
              XRect xrect322 = new XRect(540.0, num624, point326, num625);
              XStringFormat topLeft322 = XStringFormat.TopLeft;
              xgraphics322.DrawString("OK", arialFont10Bold117, (XBrush) green, xrect322, topLeft322);
              goto label_826;
            }
          }
          else
            goto label_826;
label_813:
          // ISSUE: reference to a compiler-generated field
          switch (SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].SecHeating.SAPTableCode)
          {
            case 631:
              XGraphics xgraphics323 = PDFFunctions.gfx[L1ACheckList.k];
              // ISSUE: reference to a compiler-generated field
              string str116 = "Efficiency " + Microsoft.VisualBasic.Strings.Format((object) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].SecHeating.SecEff, "00.0") + " %";
              XFont arialFont10_198 = PDFFunctions.ArialFont10;
              XSolidBrush black216 = XBrushes.Black;
              double num626 = (double) checked (L1ACheckList.RC1 + 1);
              xunit = PDFFunctions.pages[L1ACheckList.k].Width;
              double point327 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[L1ACheckList.k].Height;
              double num627 = ((XUnit) ref xunit).Point / 2.0;
              XRect xrect323 = new XRect(200.0, num626, point327, num627);
              XStringFormat topLeft323 = XStringFormat.TopLeft;
              xgraphics323.DrawString(str116, arialFont10_198, (XBrush) black216, xrect323, topLeft323);
              checked { L1ACheckList.RC1 += 13; }
              float num628 = 37f;
              XGraphics xgraphics324 = PDFFunctions.gfx[L1ACheckList.k];
              XFont arialFont10_199 = PDFFunctions.ArialFont10;
              XSolidBrush black217 = XBrushes.Black;
              double num629 = (double) checked (L1ACheckList.RC1 + 1);
              xunit = PDFFunctions.pages[L1ACheckList.k].Width;
              double point328 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[L1ACheckList.k].Height;
              double num630 = ((XUnit) ref xunit).Point / 2.0;
              XRect xrect324 = new XRect(200.0, num629, point328, num630);
              XStringFormat topLeft324 = XStringFormat.TopLeft;
              xgraphics324.DrawString("Minimum 37.0 %", arialFont10_199, (XBrush) black217, xrect324, topLeft324);
              // ISSUE: reference to a compiler-generated field
              if ((double) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].SecHeating.SecEff < (double) num628)
              {
                XGraphics xgraphics325 = PDFFunctions.gfx[L1ACheckList.k];
                XFont arialFont10Bold118 = PDFFunctions.ArialFont10Bold;
                XSolidBrush red = XBrushes.Red;
                double num631 = (double) checked (L1ACheckList.RC1 + 1);
                xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                double point329 = ((XUnit) ref xunit).Point;
                xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                double num632 = ((XUnit) ref xunit).Point / 2.0;
                XRect xrect325 = new XRect(540.0, num631, point329, num632);
                XStringFormat topLeft325 = XStringFormat.TopLeft;
                xgraphics325.DrawString("Fail", arialFont10Bold118, (XBrush) red, xrect325, topLeft325);
                flag2 = true;
                goto label_826;
              }
              else
              {
                XGraphics xgraphics326 = PDFFunctions.gfx[L1ACheckList.k];
                XFont arialFont10Bold119 = PDFFunctions.ArialFont10Bold;
                XSolidBrush green = XBrushes.Green;
                double num633 = (double) checked (L1ACheckList.RC1 + 1);
                xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                double point330 = ((XUnit) ref xunit).Point;
                xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                double num634 = ((XUnit) ref xunit).Point / 2.0;
                XRect xrect326 = new XRect(540.0, num633, point330, num634);
                XStringFormat topLeft326 = XStringFormat.TopLeft;
                xgraphics326.DrawString("OK", arialFont10Bold119, (XBrush) green, xrect326, topLeft326);
                goto label_826;
              }
            case 632:
              XGraphics xgraphics327 = PDFFunctions.gfx[L1ACheckList.k];
              // ISSUE: reference to a compiler-generated field
              string str117 = "Efficiency " + Microsoft.VisualBasic.Strings.Format((object) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].SecHeating.SecEff, "00.0") + " %";
              XFont arialFont10_200 = PDFFunctions.ArialFont10;
              XSolidBrush black218 = XBrushes.Black;
              double num635 = (double) checked (L1ACheckList.RC1 + 1);
              xunit = PDFFunctions.pages[L1ACheckList.k].Width;
              double point331 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[L1ACheckList.k].Height;
              double num636 = ((XUnit) ref xunit).Point / 2.0;
              XRect xrect327 = new XRect(200.0, num635, point331, num636);
              XStringFormat topLeft327 = XStringFormat.TopLeft;
              xgraphics327.DrawString(str117, arialFont10_200, (XBrush) black218, xrect327, topLeft327);
              checked { L1ACheckList.RC1 += 13; }
              XGraphics xgraphics328 = PDFFunctions.gfx[L1ACheckList.k];
              XFont arialFont10_201 = PDFFunctions.ArialFont10;
              XSolidBrush black219 = XBrushes.Black;
              double num637 = (double) checked (L1ACheckList.RC1 + 1);
              xunit = PDFFunctions.pages[L1ACheckList.k].Width;
              double point332 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[L1ACheckList.k].Height;
              double num638 = ((XUnit) ref xunit).Point / 2.0;
              XRect xrect328 = new XRect(200.0, num637, point332, num638);
              XStringFormat topLeft328 = XStringFormat.TopLeft;
              xgraphics328.DrawString("Minimum 50.0 %", arialFont10_201, (XBrush) black219, xrect328, topLeft328);
              // ISSUE: reference to a compiler-generated field
              if ((double) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].SecHeating.SecEff < 50.0)
              {
                XGraphics xgraphics329 = PDFFunctions.gfx[L1ACheckList.k];
                XFont arialFont10Bold120 = PDFFunctions.ArialFont10Bold;
                XSolidBrush red = XBrushes.Red;
                double num639 = (double) checked (L1ACheckList.RC1 + 1);
                xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                double point333 = ((XUnit) ref xunit).Point;
                xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                double num640 = ((XUnit) ref xunit).Point / 2.0;
                XRect xrect329 = new XRect(540.0, num639, point333, num640);
                XStringFormat topLeft329 = XStringFormat.TopLeft;
                xgraphics329.DrawString("Fail", arialFont10Bold120, (XBrush) red, xrect329, topLeft329);
                flag2 = true;
                goto label_826;
              }
              else
              {
                XGraphics xgraphics330 = PDFFunctions.gfx[L1ACheckList.k];
                XFont arialFont10Bold121 = PDFFunctions.ArialFont10Bold;
                XSolidBrush green = XBrushes.Green;
                double num641 = (double) checked (L1ACheckList.RC1 + 1);
                xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                double point334 = ((XUnit) ref xunit).Point;
                xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                double num642 = ((XUnit) ref xunit).Point / 2.0;
                XRect xrect330 = new XRect(540.0, num641, point334, num642);
                XStringFormat topLeft330 = XStringFormat.TopLeft;
                xgraphics330.DrawString("OK", arialFont10Bold121, (XBrush) green, xrect330, topLeft330);
                goto label_826;
              }
            case 633:
            case 635:
            case 636:
              XGraphics xgraphics331 = PDFFunctions.gfx[L1ACheckList.k];
              // ISSUE: reference to a compiler-generated field
              string str118 = "Efficiency " + Microsoft.VisualBasic.Strings.Format((object) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].SecHeating.SecEff, "00.0") + " %";
              XFont arialFont10_202 = PDFFunctions.ArialFont10;
              XSolidBrush black220 = XBrushes.Black;
              double num643 = (double) checked (L1ACheckList.RC1 + 1);
              xunit = PDFFunctions.pages[L1ACheckList.k].Width;
              double point335 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[L1ACheckList.k].Height;
              double num644 = ((XUnit) ref xunit).Point / 2.0;
              XRect xrect331 = new XRect(200.0, num643, point335, num644);
              XStringFormat topLeft331 = XStringFormat.TopLeft;
              xgraphics331.DrawString(str118, arialFont10_202, (XBrush) black220, xrect331, topLeft331);
              checked { L1ACheckList.RC1 += 13; }
              XGraphics xgraphics332 = PDFFunctions.gfx[L1ACheckList.k];
              XFont arialFont10_203 = PDFFunctions.ArialFont10;
              XSolidBrush black221 = XBrushes.Black;
              double num645 = (double) checked (L1ACheckList.RC1 + 1);
              xunit = PDFFunctions.pages[L1ACheckList.k].Width;
              double point336 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[L1ACheckList.k].Height;
              double num646 = ((XUnit) ref xunit).Point / 2.0;
              XRect xrect332 = new XRect(200.0, num645, point336, num646);
              XStringFormat topLeft332 = XStringFormat.TopLeft;
              xgraphics332.DrawString("Minimum 65.0 %", arialFont10_203, (XBrush) black221, xrect332, topLeft332);
              // ISSUE: reference to a compiler-generated field
              if ((double) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].SecHeating.SecEff < 65.0)
              {
                XGraphics xgraphics333 = PDFFunctions.gfx[L1ACheckList.k];
                XFont arialFont10Bold122 = PDFFunctions.ArialFont10Bold;
                XSolidBrush red = XBrushes.Red;
                double num647 = (double) checked (L1ACheckList.RC1 + 1);
                xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                double point337 = ((XUnit) ref xunit).Point;
                xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                double num648 = ((XUnit) ref xunit).Point / 2.0;
                XRect xrect333 = new XRect(540.0, num647, point337, num648);
                XStringFormat topLeft333 = XStringFormat.TopLeft;
                xgraphics333.DrawString("Fail", arialFont10Bold122, (XBrush) red, xrect333, topLeft333);
                flag2 = true;
                goto label_826;
              }
              else
              {
                XGraphics xgraphics334 = PDFFunctions.gfx[L1ACheckList.k];
                XFont arialFont10Bold123 = PDFFunctions.ArialFont10Bold;
                XSolidBrush green = XBrushes.Green;
                double num649 = (double) checked (L1ACheckList.RC1 + 1);
                xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                double point338 = ((XUnit) ref xunit).Point;
                xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                double num650 = ((XUnit) ref xunit).Point / 2.0;
                XRect xrect334 = new XRect(540.0, num649, point338, num650);
                XStringFormat topLeft334 = XStringFormat.TopLeft;
                xgraphics334.DrawString("OK", arialFont10Bold123, (XBrush) green, xrect334, topLeft334);
                goto label_826;
              }
            case 634:
              XGraphics xgraphics335 = PDFFunctions.gfx[L1ACheckList.k];
              // ISSUE: reference to a compiler-generated field
              string str119 = "Efficiency " + Microsoft.VisualBasic.Strings.Format((object) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].SecHeating.SecEff, "00.0") + " %";
              XFont arialFont10_204 = PDFFunctions.ArialFont10;
              XSolidBrush black222 = XBrushes.Black;
              double num651 = (double) checked (L1ACheckList.RC1 + 1);
              xunit = PDFFunctions.pages[L1ACheckList.k].Width;
              double point339 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[L1ACheckList.k].Height;
              double num652 = ((XUnit) ref xunit).Point / 2.0;
              XRect xrect335 = new XRect(200.0, num651, point339, num652);
              XStringFormat topLeft335 = XStringFormat.TopLeft;
              xgraphics335.DrawString(str119, arialFont10_204, (XBrush) black222, xrect335, topLeft335);
              checked { L1ACheckList.RC1 += 13; }
              XGraphics xgraphics336 = PDFFunctions.gfx[L1ACheckList.k];
              XFont arialFont10_205 = PDFFunctions.ArialFont10;
              XSolidBrush black223 = XBrushes.Black;
              double num653 = (double) checked (L1ACheckList.RC1 + 1);
              xunit = PDFFunctions.pages[L1ACheckList.k].Width;
              double point340 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[L1ACheckList.k].Height;
              double num654 = ((XUnit) ref xunit).Point / 2.0;
              XRect xrect336 = new XRect(200.0, num653, point340, num654);
              XStringFormat topLeft336 = XStringFormat.TopLeft;
              xgraphics336.DrawString("Minimum 67.0 %", arialFont10_205, (XBrush) black223, xrect336, topLeft336);
              // ISSUE: reference to a compiler-generated field
              if ((double) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].SecHeating.SecEff < 67.0)
              {
                XGraphics xgraphics337 = PDFFunctions.gfx[L1ACheckList.k];
                XFont arialFont10Bold124 = PDFFunctions.ArialFont10Bold;
                XSolidBrush red = XBrushes.Red;
                double num655 = (double) checked (L1ACheckList.RC1 + 1);
                xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                double point341 = ((XUnit) ref xunit).Point;
                xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                double num656 = ((XUnit) ref xunit).Point / 2.0;
                XRect xrect337 = new XRect(540.0, num655, point341, num656);
                XStringFormat topLeft337 = XStringFormat.TopLeft;
                xgraphics337.DrawString("Fail", arialFont10Bold124, (XBrush) red, xrect337, topLeft337);
                flag2 = true;
                goto label_826;
              }
              else
              {
                XGraphics xgraphics338 = PDFFunctions.gfx[L1ACheckList.k];
                XFont arialFont10Bold125 = PDFFunctions.ArialFont10Bold;
                XSolidBrush green = XBrushes.Green;
                double num657 = (double) checked (L1ACheckList.RC1 + 1);
                xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                double point342 = ((XUnit) ref xunit).Point;
                xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                double num658 = ((XUnit) ref xunit).Point / 2.0;
                XRect xrect338 = new XRect(540.0, num657, point342, num658);
                XStringFormat topLeft338 = XStringFormat.TopLeft;
                xgraphics338.DrawString("OK", arialFont10Bold125, (XBrush) green, xrect338, topLeft338);
                goto label_826;
              }
            default:
              goto label_826;
          }
        }
label_827:;
      }
      checked { L1ACheckList.RC1 += 13; }
      L1ACheckList.CheckCheckListRC1();
      PDFFunctions.xBrush1 = XBrush.op_Implicit((Brush) new SolidBrush(Color.FromArgb(159, 172, 62)));
      PDFFunctions.Points[0].X = 20f;
      PDFFunctions.Points[0].Y = (float) L1ACheckList.RC1;
      ref PointF local19 = ref PDFFunctions.Points[1];
      xunit = PDFFunctions.pages[L1ACheckList.k].Width;
      double num659 = ((XUnit) ref xunit).Point - 20.0;
      local19.X = (float) num659;
      PDFFunctions.Points[1].Y = (float) L1ACheckList.RC1;
      ref PointF local20 = ref PDFFunctions.Points[2];
      xunit = PDFFunctions.pages[L1ACheckList.k].Width;
      double num660 = ((XUnit) ref xunit).Point - 20.0;
      local20.X = (float) num660;
      PDFFunctions.Points[2].Y = (float) checked (L1ACheckList.RC1 + 12);
      PDFFunctions.Points[3].X = 20f;
      PDFFunctions.Points[3].Y = (float) checked (L1ACheckList.RC1 + 12);
      PDFFunctions.gfx[L1ACheckList.k].DrawPolygon(PDFFunctions.polyGreen2, PDFFunctions.xBrush1, PDFFunctions.Points, PDFFunctions.Fill);
      XGraphics xgraphics339 = PDFFunctions.gfx[L1ACheckList.k];
      XFont arialFont10Bold126 = PDFFunctions.ArialFont10Bold;
      XSolidBrush white11 = XBrushes.White;
      double num661 = (double) checked (L1ACheckList.RC1 + 1);
      xunit = PDFFunctions.pages[L1ACheckList.k].Width;
      double point343 = ((XUnit) ref xunit).Point;
      xunit = PDFFunctions.pages[L1ACheckList.k].Height;
      double num662 = ((XUnit) ref xunit).Point / 2.0;
      XRect xrect339 = new XRect(25.0, num661, point343, num662);
      XStringFormat topLeft339 = XStringFormat.TopLeft;
      xgraphics339.DrawString("5 Cylinder insulation", arialFont10Bold126, (XBrush) white11, xrect339, topLeft339);
      checked { L1ACheckList.RC1 += 15; }
      XGraphics xgraphics340 = PDFFunctions.gfx[L1ACheckList.k];
      XFont arialFont10_206 = PDFFunctions.ArialFont10;
      XSolidBrush black224 = XBrushes.Black;
      double num663 = (double) checked (L1ACheckList.RC1 + 1);
      xunit = PDFFunctions.pages[L1ACheckList.k].Width;
      double point344 = ((XUnit) ref xunit).Point;
      xunit = PDFFunctions.pages[L1ACheckList.k].Height;
      double num664 = ((XUnit) ref xunit).Point / 2.0;
      XRect xrect340 = new XRect(50.0, num663, point344, num664);
      XStringFormat topLeft340 = XStringFormat.TopLeft;
      xgraphics340.DrawString("Hot water Storage: ", arialFont10_206, (XBrush) black224, xrect340, topLeft340);
      bool flag4 = false;
      string sgroup1 = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SGroup;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(sgroup1, "Gas-fired heat pumps", false) == 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(sgroup1, "Electric heat pumps", false) == 0)
      {
        List<PCDF.HeatPump> heatPumps = SAP_Module.PCDFData.HeatPumps;
        Func<PCDF.HeatPump, bool> predicate;
        // ISSUE: reference to a compiler-generated field
        if (L1ACheckList._Closure\u0024__.\u0024I26\u002D10 != null)
        {
          // ISSUE: reference to a compiler-generated field
          predicate = L1ACheckList._Closure\u0024__.\u0024I26\u002D10;
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          L1ACheckList._Closure\u0024__.\u0024I26\u002D10 = predicate = (Func<PCDF.HeatPump, bool>) (b => b.ID.Equals(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SEDBUK));
        }
        PCDF.HeatPump heatPump = heatPumps.Where<PCDF.HeatPump>(predicate).SingleOrDefault<PCDF.HeatPump>();
        if (heatPump != null && Conversion.Val(heatPump.HWvessel) == 1.0)
          flag4 = true;
      }
      if (flag4)
      {
        XGraphics xgraphics341 = PDFFunctions.gfx[L1ACheckList.k];
        XFont arialFont10_207 = PDFFunctions.ArialFont10;
        XSolidBrush black225 = XBrushes.Black;
        double num665 = (double) checked (L1ACheckList.RC1 + 1);
        xunit = PDFFunctions.pages[L1ACheckList.k].Width;
        double point345 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[L1ACheckList.k].Height;
        double num666 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect341 = new XRect(200.0, num665, point345, num666);
        XStringFormat topLeft341 = XStringFormat.TopLeft;
        xgraphics341.DrawString("No Separate Cylinder", arialFont10_207, (XBrush) black225, xrect341, topLeft341);
        checked { L1ACheckList.RC1 += 15; }
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        if ((double) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Water.Cylinder.Volume != 0.0)
        {
          // ISSUE: reference to a compiler-generated field
          switch (SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.SAPTableCode)
          {
            case 103:
            case 104:
            case 108:
            case 112:
            case 113:
            case 118:
            case 128:
            case 129:
            case 130:
              // ISSUE: reference to a compiler-generated field
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Water.CombiType, "Storage combi boiler, primary store", false) == 0)
              {
                L1ACheckList.CylinderFound = false;
                XGraphics xgraphics342 = PDFFunctions.gfx[L1ACheckList.k];
                XFont arialFont10_208 = PDFFunctions.ArialFont10;
                XSolidBrush black226 = XBrushes.Black;
                double num667 = (double) checked (L1ACheckList.RC1 + 1);
                xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                double point346 = ((XUnit) ref xunit).Point;
                xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                double num668 = ((XUnit) ref xunit).Point / 2.0;
                XRect xrect342 = new XRect(200.0, num667, point346, num668);
                XStringFormat topLeft342 = XStringFormat.TopLeft;
                xgraphics342.DrawString("No cylinder thermostat", arialFont10_208, (XBrush) black226, xrect342, topLeft342);
                checked { L1ACheckList.RC1 += 15; }
                break;
              }
              L1ACheckList.CylinderFound = true;
              break;
            default:
              L1ACheckList.CylinderFound = true;
              break;
          }
        }
        else
        {
          XGraphics xgraphics343 = PDFFunctions.gfx[L1ACheckList.k];
          XFont arialFont10_209 = PDFFunctions.ArialFont10;
          XSolidBrush black227 = XBrushes.Black;
          double num669 = (double) checked (L1ACheckList.RC1 + 1);
          xunit = PDFFunctions.pages[L1ACheckList.k].Width;
          double point347 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[L1ACheckList.k].Height;
          double num670 = ((XUnit) ref xunit).Point / 2.0;
          XRect xrect343 = new XRect(200.0, num669, point347, num670);
          XStringFormat topLeft343 = XStringFormat.TopLeft;
          xgraphics343.DrawString("No cylinder", arialFont10_209, (XBrush) black227, xrect343, topLeft343);
          checked { L1ACheckList.RC1 += 15; }
        }
      }
      if (L1ACheckList.CylinderFound)
      {
        // ISSUE: reference to a compiler-generated field
        L1ACheckList.Cylindercheck = !SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.ManuSpecified ? SAP_Module.Calculation2012.Calculation.Water_heating.Box51 * SAP_Module.Calculation2012.Calculation.Water_heating.Box52 * (double) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Water.Cylinder.Volume : (double) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.DeclaredLoss;
        // ISSUE: reference to a compiler-generated field
        int sapTableCode8 = SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.SAPTableCode;
        // ISSUE: reference to a compiler-generated field
        if ((sapTableCode8 >= 120 && sapTableCode8 <= 123 || sapTableCode8 == 192) && SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Water.SystemRef == 901 && (double) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.DeclaredLoss == 0.0)
        {
          L1ACheckList.Cylindercheck *= 1.22;
          L1ACheckList.CPSU = true;
        }
        L1ACheckList.CheckCheckListRC1();
        if (L1ACheckList.CPSU)
        {
          XGraphics xgraphics344 = PDFFunctions.gfx[L1ACheckList.k];
          string str120 = "Nominal CPSU loss: " + Microsoft.VisualBasic.Strings.Format((object) Math.Round(L1ACheckList.Cylindercheck, 2), "0.00") + " kWh/day ";
          XFont arialFont10_210 = PDFFunctions.ArialFont10;
          XSolidBrush black228 = XBrushes.Black;
          double num671 = (double) checked (L1ACheckList.RC1 + 1);
          xunit = PDFFunctions.pages[L1ACheckList.k].Width;
          double point348 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[L1ACheckList.k].Height;
          double num672 = ((XUnit) ref xunit).Point / 2.0;
          XRect xrect344 = new XRect(200.0, num671, point348, num672);
          XStringFormat topLeft344 = XStringFormat.TopLeft;
          xgraphics344.DrawString(str120, arialFont10_210, (XBrush) black228, xrect344, topLeft344);
        }
        else
        {
          XGraphics xgraphics345 = PDFFunctions.gfx[L1ACheckList.k];
          string str121 = "Measured cylinder loss: " + Microsoft.VisualBasic.Strings.Format((object) Math.Round(L1ACheckList.Cylindercheck, 2), "0.00") + " kWh/day ";
          XFont arialFont10_211 = PDFFunctions.ArialFont10;
          XSolidBrush black229 = XBrushes.Black;
          double num673 = (double) checked (L1ACheckList.RC1 + 1);
          xunit = PDFFunctions.pages[L1ACheckList.k].Width;
          double point349 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[L1ACheckList.k].Height;
          double num674 = ((XUnit) ref xunit).Point / 2.0;
          XRect xrect345 = new XRect(200.0, num673, point349, num674);
          XStringFormat topLeft345 = XStringFormat.TopLeft;
          xgraphics345.DrawString(str121, arialFont10_211, (XBrush) black229, xrect345, topLeft345);
        }
        checked { L1ACheckList.RC1 += 13; }
        // ISSUE: reference to a compiler-generated field
        if (SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Water.Thermal.Include | L1ACheckList.CPSU)
        {
          // ISSUE: reference to a compiler-generated field
          L1ACheckList.CylindercheckOriginal = 1.28 * (0.2 + 0.051 * Math.Pow((double) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Water.Cylinder.Volume, 2.0 / 3.0));
          XGraphics xgraphics346 = PDFFunctions.gfx[L1ACheckList.k];
          string str122 = "Permitted by DBSCG: " + Microsoft.VisualBasic.Strings.Format((object) Math.Round(L1ACheckList.CylindercheckOriginal, 2), "0.00") + " kWh/day ";
          XFont arialFont10_212 = PDFFunctions.ArialFont10;
          XSolidBrush black230 = XBrushes.Black;
          double num675 = (double) checked (L1ACheckList.RC1 + 1);
          xunit = PDFFunctions.pages[L1ACheckList.k].Width;
          double point350 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[L1ACheckList.k].Height;
          double num676 = ((XUnit) ref xunit).Point / 2.0;
          XRect xrect346 = new XRect(200.0, num675, point350, num676);
          XStringFormat topLeft346 = XStringFormat.TopLeft;
          xgraphics346.DrawString(str122, arialFont10_212, (XBrush) black230, xrect346, topLeft346);
          checked { L1ACheckList.RC1 += 13; }
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          string fuel8 = SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Water.Fuel;
          // ISSUE: reference to a compiler-generated method
          switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(fuel8))
          {
            case 157581269:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel8, "heating oil", false) == 0)
                break;
              goto default;
            case 975024876:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel8, "bulk LPG", false) == 0)
                break;
              goto default;
            case 1086463322:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel8, "LPG subject to Special Condition 18", false) == 0)
                break;
              goto default;
            case 1384014791:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel8, "B30K", false) == 0)
                break;
              goto default;
            case 1441345278:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel8, "Electricity", false) == 0)
                break;
              goto default;
            case 1597764060:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel8, "mains gas", false) == 0)
                break;
              goto default;
            case 1770949684:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel8, "appliances able to use mineral oil or liquid biofuel", false) == 0)
                break;
              goto default;
            case 1860525480:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel8, "heat from electric heat pump", false) == 0)
                break;
              goto default;
            case 2685417441:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel8, "bioethanol from any biomass source", false) == 0)
                break;
              goto default;
            case 3198893402:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel8, "rapeseed oil", false) == 0)
                break;
              goto default;
            case 3349323758:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel8, "biodiesel from any biomass source", false) == 0)
                break;
              goto default;
            case 3722837730:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel8, "bottled LPG", false) == 0)
                break;
              goto default;
            case 3794681384:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel8, "LNG", false) == 0)
                break;
              goto default;
            case 4235694608:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel8, "biodiesel from used cooking oil only", false) == 0)
                break;
              goto default;
            case 4241528165:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel8, "heat from boilers – mains gas", false) == 0)
                break;
              goto default;
            default:
              // ISSUE: reference to a compiler-generated field
              L1ACheckList.CylindercheckOriginal = 1.6 * (0.2 + 0.051 * Math.Pow((double) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Water.Cylinder.Volume, 2.0 / 3.0));
              XGraphics xgraphics347 = PDFFunctions.gfx[L1ACheckList.k];
              string str123 = "Permitted by DBSCG: " + Microsoft.VisualBasic.Strings.Format((object) Math.Round(L1ACheckList.CylindercheckOriginal, 2), "0.00") + " kWh/day ";
              XFont arialFont10_213 = PDFFunctions.ArialFont10;
              XSolidBrush black231 = XBrushes.Black;
              double num677 = (double) checked (L1ACheckList.RC1 + 1);
              xunit = PDFFunctions.pages[L1ACheckList.k].Width;
              double point351 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[L1ACheckList.k].Height;
              double num678 = ((XUnit) ref xunit).Point / 2.0;
              XRect xrect347 = new XRect(200.0, num677, point351, num678);
              XStringFormat topLeft347 = XStringFormat.TopLeft;
              xgraphics347.DrawString(str123, arialFont10_213, (XBrush) black231, xrect347, topLeft347);
              if (Math.Round(L1ACheckList.Cylindercheck, 2) <= Math.Round(L1ACheckList.CylindercheckOriginal, 2))
              {
                XGraphics xgraphics348 = PDFFunctions.gfx[L1ACheckList.k];
                XFont arialFont10Bold127 = PDFFunctions.ArialFont10Bold;
                XSolidBrush green = XBrushes.Green;
                double num679 = (double) checked (L1ACheckList.RC1 + 1);
                xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                double point352 = ((XUnit) ref xunit).Point;
                xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                double num680 = ((XUnit) ref xunit).Point / 2.0;
                XRect xrect348 = new XRect(540.0, num679, point352, num680);
                XStringFormat topLeft348 = XStringFormat.TopLeft;
                xgraphics348.DrawString("OK", arialFont10Bold127, (XBrush) green, xrect348, topLeft348);
              }
              else
              {
                XGraphics xgraphics349 = PDFFunctions.gfx[L1ACheckList.k];
                XFont arialFont10Bold128 = PDFFunctions.ArialFont10Bold;
                XSolidBrush red = XBrushes.Red;
                double num681 = (double) checked (L1ACheckList.RC1 + 1);
                xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                double point353 = ((XUnit) ref xunit).Point;
                xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                double num682 = ((XUnit) ref xunit).Point / 2.0;
                XRect xrect349 = new XRect(540.0, num681, point353, num682);
                XStringFormat topLeft349 = XStringFormat.TopLeft;
                xgraphics349.DrawString("Fail", arialFont10Bold128, (XBrush) red, xrect349, topLeft349);
              }
              checked { L1ACheckList.RC1 += 13; }
              goto label_876;
          }
          // ISSUE: reference to a compiler-generated field
          L1ACheckList.CylindercheckOriginal = 1.15 * (0.2 + 0.051 * Math.Pow((double) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Water.Cylinder.Volume, 2.0 / 3.0));
          XGraphics xgraphics350 = PDFFunctions.gfx[L1ACheckList.k];
          string str124 = "Permitted by DBSCG: " + Microsoft.VisualBasic.Strings.Format((object) Math.Round(L1ACheckList.CylindercheckOriginal, 2), "0.00") + " kWh/day ";
          XFont arialFont10_214 = PDFFunctions.ArialFont10;
          XSolidBrush black232 = XBrushes.Black;
          double num683 = (double) checked (L1ACheckList.RC1 + 1);
          xunit = PDFFunctions.pages[L1ACheckList.k].Width;
          double point354 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[L1ACheckList.k].Height;
          double num684 = ((XUnit) ref xunit).Point / 2.0;
          XRect xrect350 = new XRect(200.0, num683, point354, num684);
          XStringFormat topLeft350 = XStringFormat.TopLeft;
          xgraphics350.DrawString(str124, arialFont10_214, (XBrush) black232, xrect350, topLeft350);
          if (Math.Round(L1ACheckList.Cylindercheck, 2) <= Math.Round(L1ACheckList.CylindercheckOriginal, 2))
          {
            XGraphics xgraphics351 = PDFFunctions.gfx[L1ACheckList.k];
            XFont arialFont10Bold129 = PDFFunctions.ArialFont10Bold;
            XSolidBrush green = XBrushes.Green;
            double num685 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point355 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num686 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect351 = new XRect(540.0, num685, point355, num686);
            XStringFormat topLeft351 = XStringFormat.TopLeft;
            xgraphics351.DrawString("OK", arialFont10Bold129, (XBrush) green, xrect351, topLeft351);
          }
          else
          {
            XGraphics xgraphics352 = PDFFunctions.gfx[L1ACheckList.k];
            XFont arialFont10Bold130 = PDFFunctions.ArialFont10Bold;
            XSolidBrush red = XBrushes.Red;
            double num687 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point356 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num688 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect352 = new XRect(540.0, num687, point356, num688);
            XStringFormat topLeft352 = XStringFormat.TopLeft;
            xgraphics352.DrawString("Fail", arialFont10Bold130, (XBrush) red, xrect352, topLeft352);
          }
          checked { L1ACheckList.RC1 += 13; }
label_876:;
        }
        L1ACheckList.CheckCheckListRC1();
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        if (SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Water.SystemRef == 901 | SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Water.SystemRef == 903)
        {
          // ISSUE: reference to a compiler-generated field
          int sapTableCode9 = SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.SAPTableCode;
          if (sapTableCode9 == 192 || sapTableCode9 >= 120 && sapTableCode9 <= 123)
            L1ACheckList.CPSU = true;
        }
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        if (SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].WaterOnlyHeatPump & SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.HPOnly.HotWaterHP_Integral)
          L1ACheckList.CPSU = true;
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        if (L1ACheckList.CPSU | SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Water.SystemRef == 903 | SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].WaterOnlyHeatPump)
        {
          // ISSUE: reference to a compiler-generated field
          if (SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].WaterOnlyHeatPump)
          {
            XGraphics xgraphics353 = PDFFunctions.gfx[L1ACheckList.k];
            XFont arialFont10_215 = PDFFunctions.ArialFont10;
            XSolidBrush black233 = XBrushes.Black;
            double num689 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point357 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num690 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect353 = new XRect(50.0, num689, point357, num690);
            XStringFormat topLeft353 = XStringFormat.TopLeft;
            xgraphics353.DrawString("Primary pipework insulated:", arialFont10_215, (XBrush) black233, xrect353, topLeft353);
            XGraphics xgraphics354 = PDFFunctions.gfx[L1ACheckList.k];
            XFont arialFont10_216 = PDFFunctions.ArialFont10;
            XSolidBrush black234 = XBrushes.Black;
            double num691 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point358 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num692 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect354 = new XRect(200.0, num691, point358, num692);
            XStringFormat topLeft354 = XStringFormat.TopLeft;
            xgraphics354.DrawString("", arialFont10_216, (XBrush) black234, xrect354, topLeft354);
            checked { L1ACheckList.RC1 += 13; }
          }
          else
          {
            XGraphics xgraphics355 = PDFFunctions.gfx[L1ACheckList.k];
            XFont arialFont10_217 = PDFFunctions.ArialFont10;
            XSolidBrush black235 = XBrushes.Black;
            double num693 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point359 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num694 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect355 = new XRect(50.0, num693, point359, num694);
            XStringFormat topLeft355 = XStringFormat.TopLeft;
            xgraphics355.DrawString("Primary pipework insulated:", arialFont10_217, (XBrush) black235, xrect355, topLeft355);
            XGraphics xgraphics356 = PDFFunctions.gfx[L1ACheckList.k];
            XFont arialFont10_218 = PDFFunctions.ArialFont10;
            XSolidBrush black236 = XBrushes.Black;
            double num695 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point360 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num696 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect356 = new XRect(200.0, num695, point360, num696);
            XStringFormat topLeft356 = XStringFormat.TopLeft;
            xgraphics356.DrawString("No primary pipework", arialFont10_218, (XBrush) black236, xrect356, topLeft356);
            checked { L1ACheckList.RC1 += 13; }
          }
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          if (SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Water.Cylinder.PipeWorkInsulated)
          {
            if (SAP_Module.Proj.OverRide)
            {
              // ISSUE: reference to a compiler-generated field
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Water.Cylinder.PipeWorkInsulationType, "First 1m from cylinder insulated", false) == 0)
              {
                XGraphics xgraphics357 = PDFFunctions.gfx[L1ACheckList.k];
                XFont arialFont10_219 = PDFFunctions.ArialFont10;
                XSolidBrush black237 = XBrushes.Black;
                double num697 = (double) checked (L1ACheckList.RC1 + 1);
                xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                double point361 = ((XUnit) ref xunit).Point;
                xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                double num698 = ((XUnit) ref xunit).Point / 2.0;
                XRect xrect357 = new XRect(50.0, num697, point361, num698);
                XStringFormat topLeft357 = XStringFormat.TopLeft;
                xgraphics357.DrawString("Primary pipework insulated:", arialFont10_219, (XBrush) black237, xrect357, topLeft357);
                XGraphics xgraphics358 = PDFFunctions.gfx[L1ACheckList.k];
                XFont arialFont10_220 = PDFFunctions.ArialFont10;
                XSolidBrush black238 = XBrushes.Black;
                double num699 = (double) checked (L1ACheckList.RC1 + 1);
                xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                double point362 = ((XUnit) ref xunit).Point;
                xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                double num700 = ((XUnit) ref xunit).Point / 2.0;
                XRect xrect358 = new XRect(200.0, num699, point362, num700);
                XStringFormat topLeft358 = XStringFormat.TopLeft;
                xgraphics358.DrawString("No", arialFont10_220, (XBrush) black238, xrect358, topLeft358);
                XGraphics xgraphics359 = PDFFunctions.gfx[L1ACheckList.k];
                XFont arialFont10Bold131 = PDFFunctions.ArialFont10Bold;
                XSolidBrush green = XBrushes.Green;
                double num701 = (double) checked (L1ACheckList.RC1 + 1);
                xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                double point363 = ((XUnit) ref xunit).Point;
                xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                double num702 = ((XUnit) ref xunit).Point / 2.0;
                XRect xrect359 = new XRect(540.0, num701, point363, num702);
                XStringFormat topLeft359 = XStringFormat.TopLeft;
                xgraphics359.DrawString("Fail", arialFont10Bold131, (XBrush) green, xrect359, topLeft359);
              }
              else
              {
                XGraphics xgraphics360 = PDFFunctions.gfx[L1ACheckList.k];
                XFont arialFont10_221 = PDFFunctions.ArialFont10;
                XSolidBrush black239 = XBrushes.Black;
                double num703 = (double) checked (L1ACheckList.RC1 + 1);
                xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                double point364 = ((XUnit) ref xunit).Point;
                xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                double num704 = ((XUnit) ref xunit).Point / 2.0;
                XRect xrect360 = new XRect(50.0, num703, point364, num704);
                XStringFormat topLeft360 = XStringFormat.TopLeft;
                xgraphics360.DrawString("Primary pipework insulated:", arialFont10_221, (XBrush) black239, xrect360, topLeft360);
                XGraphics xgraphics361 = PDFFunctions.gfx[L1ACheckList.k];
                XFont arialFont10_222 = PDFFunctions.ArialFont10;
                XSolidBrush black240 = XBrushes.Black;
                double num705 = (double) checked (L1ACheckList.RC1 + 1);
                xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                double point365 = ((XUnit) ref xunit).Point;
                xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                double num706 = ((XUnit) ref xunit).Point / 2.0;
                XRect xrect361 = new XRect(200.0, num705, point365, num706);
                XStringFormat topLeft361 = XStringFormat.TopLeft;
                xgraphics361.DrawString("Yes", arialFont10_222, (XBrush) black240, xrect361, topLeft361);
                XGraphics xgraphics362 = PDFFunctions.gfx[L1ACheckList.k];
                XFont arialFont10Bold132 = PDFFunctions.ArialFont10Bold;
                XSolidBrush green = XBrushes.Green;
                double num707 = (double) checked (L1ACheckList.RC1 + 1);
                xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                double point366 = ((XUnit) ref xunit).Point;
                xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                double num708 = ((XUnit) ref xunit).Point / 2.0;
                XRect xrect362 = new XRect(540.0, num707, point366, num708);
                XStringFormat topLeft362 = XStringFormat.TopLeft;
                xgraphics362.DrawString("OK", arialFont10Bold132, (XBrush) green, xrect362, topLeft362);
              }
            }
            else
            {
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Water.Cylinder.PipeWorkInsulationType, "First 1m from cylinder insulated", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Water.Cylinder.PipeWorkInsulationType, "All accessible pipework insulated", false) == 0)
              {
                XGraphics xgraphics363 = PDFFunctions.gfx[L1ACheckList.k];
                XFont arialFont10_223 = PDFFunctions.ArialFont10;
                XSolidBrush black241 = XBrushes.Black;
                double num709 = (double) checked (L1ACheckList.RC1 + 1);
                xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                double point367 = ((XUnit) ref xunit).Point;
                xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                double num710 = ((XUnit) ref xunit).Point / 2.0;
                XRect xrect363 = new XRect(50.0, num709, point367, num710);
                XStringFormat topLeft363 = XStringFormat.TopLeft;
                xgraphics363.DrawString("Primary pipework insulated:", arialFont10_223, (XBrush) black241, xrect363, topLeft363);
                XGraphics xgraphics364 = PDFFunctions.gfx[L1ACheckList.k];
                XFont arialFont10_224 = PDFFunctions.ArialFont10;
                XSolidBrush black242 = XBrushes.Black;
                double num711 = (double) checked (L1ACheckList.RC1 + 1);
                xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                double point368 = ((XUnit) ref xunit).Point;
                xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                double num712 = ((XUnit) ref xunit).Point / 2.0;
                XRect xrect364 = new XRect(200.0, num711, point368, num712);
                XStringFormat topLeft364 = XStringFormat.TopLeft;
                xgraphics364.DrawString("No", arialFont10_224, (XBrush) black242, xrect364, topLeft364);
                XGraphics xgraphics365 = PDFFunctions.gfx[L1ACheckList.k];
                XFont arialFont10Bold133 = PDFFunctions.ArialFont10Bold;
                XSolidBrush green = XBrushes.Green;
                double num713 = (double) checked (L1ACheckList.RC1 + 1);
                xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                double point369 = ((XUnit) ref xunit).Point;
                xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                double num714 = ((XUnit) ref xunit).Point / 2.0;
                XRect xrect365 = new XRect(540.0, num713, point369, num714);
                XStringFormat topLeft365 = XStringFormat.TopLeft;
                xgraphics365.DrawString("Fail", arialFont10Bold133, (XBrush) green, xrect365, topLeft365);
              }
              else
              {
                XGraphics xgraphics366 = PDFFunctions.gfx[L1ACheckList.k];
                XFont arialFont10_225 = PDFFunctions.ArialFont10;
                XSolidBrush black243 = XBrushes.Black;
                double num715 = (double) checked (L1ACheckList.RC1 + 1);
                xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                double point370 = ((XUnit) ref xunit).Point;
                xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                double num716 = ((XUnit) ref xunit).Point / 2.0;
                XRect xrect366 = new XRect(50.0, num715, point370, num716);
                XStringFormat topLeft366 = XStringFormat.TopLeft;
                xgraphics366.DrawString("Primary pipework insulated:", arialFont10_225, (XBrush) black243, xrect366, topLeft366);
                XGraphics xgraphics367 = PDFFunctions.gfx[L1ACheckList.k];
                XFont arialFont10_226 = PDFFunctions.ArialFont10;
                XSolidBrush black244 = XBrushes.Black;
                double num717 = (double) checked (L1ACheckList.RC1 + 1);
                xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                double point371 = ((XUnit) ref xunit).Point;
                xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                double num718 = ((XUnit) ref xunit).Point / 2.0;
                XRect xrect367 = new XRect(200.0, num717, point371, num718);
                XStringFormat topLeft367 = XStringFormat.TopLeft;
                xgraphics367.DrawString("Yes", arialFont10_226, (XBrush) black244, xrect367, topLeft367);
                XGraphics xgraphics368 = PDFFunctions.gfx[L1ACheckList.k];
                XFont arialFont10Bold134 = PDFFunctions.ArialFont10Bold;
                XSolidBrush green = XBrushes.Green;
                double num719 = (double) checked (L1ACheckList.RC1 + 1);
                xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                double point372 = ((XUnit) ref xunit).Point;
                xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                double num720 = ((XUnit) ref xunit).Point / 2.0;
                XRect xrect368 = new XRect(540.0, num719, point372, num720);
                XStringFormat topLeft368 = XStringFormat.TopLeft;
                xgraphics368.DrawString("OK", arialFont10Bold134, (XBrush) green, xrect368, topLeft368);
              }
            }
            checked { L1ACheckList.RC1 += 13; }
          }
          else
          {
            // ISSUE: reference to a compiler-generated field
            int sapTableCode10 = SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.SAPTableCode;
            if (sapTableCode10 >= 305 && sapTableCode10 <= 310)
            {
              XGraphics xgraphics369 = PDFFunctions.gfx[L1ACheckList.k];
              XFont arialFont10_227 = PDFFunctions.ArialFont10;
              XSolidBrush black245 = XBrushes.Black;
              double num721 = (double) checked (L1ACheckList.RC1 + 1);
              xunit = PDFFunctions.pages[L1ACheckList.k].Width;
              double point373 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[L1ACheckList.k].Height;
              double num722 = ((XUnit) ref xunit).Point / 2.0;
              XRect xrect369 = new XRect(200.0, num721, point373, num722);
              XStringFormat topLeft369 = XStringFormat.TopLeft;
              xgraphics369.DrawString("Primary pipework insulated: (Yes assumed) ", arialFont10_227, (XBrush) black245, xrect369, topLeft369);
              checked { L1ACheckList.RC1 += 13; }
            }
            else if (sapTableCode10 == 408 || sapTableCode10 == 191 || sapTableCode10 == 701 || sapTableCode10 == 694 || sapTableCode10 == 204)
            {
              XGraphics xgraphics370 = PDFFunctions.gfx[L1ACheckList.k];
              XFont arialFont10_228 = PDFFunctions.ArialFont10;
              XSolidBrush black246 = XBrushes.Black;
              double num723 = (double) checked (L1ACheckList.RC1 + 1);
              xunit = PDFFunctions.pages[L1ACheckList.k].Width;
              double point374 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[L1ACheckList.k].Height;
              double num724 = ((XUnit) ref xunit).Point / 2.0;
              XRect xrect370 = new XRect(50.0, num723, point374, num724);
              XStringFormat topLeft370 = XStringFormat.TopLeft;
              xgraphics370.DrawString("Primary pipework insulated:", arialFont10_228, (XBrush) black246, xrect370, topLeft370);
              XGraphics xgraphics371 = PDFFunctions.gfx[L1ACheckList.k];
              XFont arialFont10_229 = PDFFunctions.ArialFont10;
              XSolidBrush black247 = XBrushes.Black;
              double num725 = (double) checked (L1ACheckList.RC1 + 1);
              xunit = PDFFunctions.pages[L1ACheckList.k].Width;
              double point375 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[L1ACheckList.k].Height;
              double num726 = ((XUnit) ref xunit).Point / 2.0;
              XRect xrect371 = new XRect(200.0, num725, point375, num726);
              XStringFormat topLeft371 = XStringFormat.TopLeft;
              xgraphics371.DrawString("No primary pipework", arialFont10_229, (XBrush) black247, xrect371, topLeft371);
              checked { L1ACheckList.RC1 += 13; }
            }
            else
            {
              // ISSUE: reference to a compiler-generated field
              string sgroup2 = SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.SGroup;
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(sgroup2, "Gas boilers and oil boilers", false) == 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(sgroup2, "Electric (direct acting) room heaters", false) == 0)
              {
                // ISSUE: reference to a compiler-generated field
                if (!SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Water.Cylinder.PipeWorkInsulated)
                {
                  XGraphics xgraphics372 = PDFFunctions.gfx[L1ACheckList.k];
                  XFont arialFont10_230 = PDFFunctions.ArialFont10;
                  XSolidBrush black248 = XBrushes.Black;
                  double num727 = (double) checked (L1ACheckList.RC1 + 1);
                  xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                  double point376 = ((XUnit) ref xunit).Point;
                  xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                  double num728 = ((XUnit) ref xunit).Point / 2.0;
                  XRect xrect372 = new XRect(50.0, num727, point376, num728);
                  XStringFormat topLeft372 = XStringFormat.TopLeft;
                  xgraphics372.DrawString("Primary pipework insulated:", arialFont10_230, (XBrush) black248, xrect372, topLeft372);
                  XGraphics xgraphics373 = PDFFunctions.gfx[L1ACheckList.k];
                  XFont arialFont10_231 = PDFFunctions.ArialFont10;
                  XSolidBrush black249 = XBrushes.Black;
                  double num729 = (double) checked (L1ACheckList.RC1 + 1);
                  xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                  double point377 = ((XUnit) ref xunit).Point;
                  xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                  double num730 = ((XUnit) ref xunit).Point / 2.0;
                  XRect xrect373 = new XRect(200.0, num729, point377, num730);
                  XStringFormat topLeft373 = XStringFormat.TopLeft;
                  xgraphics373.DrawString("No primary pipework", arialFont10_231, (XBrush) black249, xrect373, topLeft373);
                  XGraphics xgraphics374 = PDFFunctions.gfx[L1ACheckList.k];
                  XFont arialFont10Bold135 = PDFFunctions.ArialFont10Bold;
                  XSolidBrush red = XBrushes.Red;
                  double num731 = (double) checked (L1ACheckList.RC1 + 1);
                  xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                  double point378 = ((XUnit) ref xunit).Point;
                  xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                  double num732 = ((XUnit) ref xunit).Point / 2.0;
                  XRect xrect374 = new XRect(540.0, num731, point378, num732);
                  XStringFormat topLeft374 = XStringFormat.TopLeft;
                  xgraphics374.DrawString("N/A", arialFont10Bold135, (XBrush) red, xrect374, topLeft374);
                  checked { L1ACheckList.RC1 += 13; }
                }
                else
                {
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Water.Cylinder.PipeWorkInsulationType, "First 1m from cylinder insulated", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Water.Cylinder.PipeWorkInsulationType, "All accessible pipework insulated", false) == 0)
                  {
                    XGraphics xgraphics375 = PDFFunctions.gfx[L1ACheckList.k];
                    XFont arialFont10_232 = PDFFunctions.ArialFont10;
                    XSolidBrush black250 = XBrushes.Black;
                    double num733 = (double) checked (L1ACheckList.RC1 + 1);
                    xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                    double point379 = ((XUnit) ref xunit).Point;
                    xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                    double num734 = ((XUnit) ref xunit).Point / 2.0;
                    XRect xrect375 = new XRect(50.0, num733, point379, num734);
                    XStringFormat topLeft375 = XStringFormat.TopLeft;
                    xgraphics375.DrawString("Primary pipework insulated:", arialFont10_232, (XBrush) black250, xrect375, topLeft375);
                    XGraphics xgraphics376 = PDFFunctions.gfx[L1ACheckList.k];
                    XFont arialFont10_233 = PDFFunctions.ArialFont10;
                    XSolidBrush black251 = XBrushes.Black;
                    double num735 = (double) checked (L1ACheckList.RC1 + 1);
                    xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                    double point380 = ((XUnit) ref xunit).Point;
                    xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                    double num736 = ((XUnit) ref xunit).Point / 2.0;
                    XRect xrect376 = new XRect(200.0, num735, point380, num736);
                    XStringFormat topLeft376 = XStringFormat.TopLeft;
                    xgraphics376.DrawString("No", arialFont10_233, (XBrush) black251, xrect376, topLeft376);
                    XGraphics xgraphics377 = PDFFunctions.gfx[L1ACheckList.k];
                    XFont arialFont10Bold136 = PDFFunctions.ArialFont10Bold;
                    XSolidBrush red = XBrushes.Red;
                    double num737 = (double) checked (L1ACheckList.RC1 + 1);
                    xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                    double point381 = ((XUnit) ref xunit).Point;
                    xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                    double num738 = ((XUnit) ref xunit).Point / 2.0;
                    XRect xrect377 = new XRect(540.0, num737, point381, num738);
                    XStringFormat topLeft377 = XStringFormat.TopLeft;
                    xgraphics377.DrawString("Fail", arialFont10Bold136, (XBrush) red, xrect377, topLeft377);
                  }
                  else
                  {
                    XGraphics xgraphics378 = PDFFunctions.gfx[L1ACheckList.k];
                    XFont arialFont10_234 = PDFFunctions.ArialFont10;
                    XSolidBrush black252 = XBrushes.Black;
                    double num739 = (double) checked (L1ACheckList.RC1 + 1);
                    xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                    double point382 = ((XUnit) ref xunit).Point;
                    xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                    double num740 = ((XUnit) ref xunit).Point / 2.0;
                    XRect xrect378 = new XRect(50.0, num739, point382, num740);
                    XStringFormat topLeft378 = XStringFormat.TopLeft;
                    xgraphics378.DrawString("Primary pipework insulated:", arialFont10_234, (XBrush) black252, xrect378, topLeft378);
                    XGraphics xgraphics379 = PDFFunctions.gfx[L1ACheckList.k];
                    XFont arialFont10_235 = PDFFunctions.ArialFont10;
                    XSolidBrush black253 = XBrushes.Black;
                    double num741 = (double) checked (L1ACheckList.RC1 + 1);
                    xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                    double point383 = ((XUnit) ref xunit).Point;
                    xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                    double num742 = ((XUnit) ref xunit).Point / 2.0;
                    XRect xrect379 = new XRect(200.0, num741, point383, num742);
                    XStringFormat topLeft379 = XStringFormat.TopLeft;
                    xgraphics379.DrawString("Yes", arialFont10_235, (XBrush) black253, xrect379, topLeft379);
                    XGraphics xgraphics380 = PDFFunctions.gfx[L1ACheckList.k];
                    XFont arialFont10Bold137 = PDFFunctions.ArialFont10Bold;
                    XSolidBrush green = XBrushes.Green;
                    double num743 = (double) checked (L1ACheckList.RC1 + 1);
                    xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                    double point384 = ((XUnit) ref xunit).Point;
                    xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                    double num744 = ((XUnit) ref xunit).Point / 2.0;
                    XRect xrect380 = new XRect(540.0, num743, point384, num744);
                    XStringFormat topLeft380 = XStringFormat.TopLeft;
                    xgraphics380.DrawString("OK", arialFont10Bold137, (XBrush) green, xrect380, topLeft380);
                  }
                  checked { L1ACheckList.RC1 += 13; }
                }
              }
              else
              {
                XGraphics xgraphics381 = PDFFunctions.gfx[L1ACheckList.k];
                XFont arialFont10_236 = PDFFunctions.ArialFont10;
                XSolidBrush black254 = XBrushes.Black;
                double num745 = (double) checked (L1ACheckList.RC1 + 1);
                xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                double point385 = ((XUnit) ref xunit).Point;
                xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                double num746 = ((XUnit) ref xunit).Point / 2.0;
                XRect xrect381 = new XRect(50.0, num745, point385, num746);
                XStringFormat topLeft381 = XStringFormat.TopLeft;
                xgraphics381.DrawString("Primary pipework insulated:", arialFont10_236, (XBrush) black254, xrect381, topLeft381);
                XGraphics xgraphics382 = PDFFunctions.gfx[L1ACheckList.k];
                XFont arialFont10_237 = PDFFunctions.ArialFont10;
                XSolidBrush black255 = XBrushes.Black;
                double num747 = (double) checked (L1ACheckList.RC1 + 1);
                xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                double point386 = ((XUnit) ref xunit).Point;
                xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                double num748 = ((XUnit) ref xunit).Point / 2.0;
                XRect xrect382 = new XRect(200.0, num747, point386, num748);
                XStringFormat topLeft382 = XStringFormat.TopLeft;
                xgraphics382.DrawString("No", arialFont10_237, (XBrush) black255, xrect382, topLeft382);
                XGraphics xgraphics383 = PDFFunctions.gfx[L1ACheckList.k];
                XFont arialFont10Bold138 = PDFFunctions.ArialFont10Bold;
                XSolidBrush red = XBrushes.Red;
                double num749 = (double) checked (L1ACheckList.RC1 + 1);
                xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                double point387 = ((XUnit) ref xunit).Point;
                xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                double num750 = ((XUnit) ref xunit).Point / 2.0;
                XRect xrect383 = new XRect(540.0, num749, point387, num750);
                XStringFormat topLeft383 = XStringFormat.TopLeft;
                xgraphics383.DrawString("Fail", arialFont10Bold138, (XBrush) red, xrect383, topLeft383);
              }
              checked { L1ACheckList.RC1 += 13; }
            }
          }
        }
      }
      else
      {
        XGraphics xgraphics384 = PDFFunctions.gfx[L1ACheckList.k];
        XFont arialFont10Bold139 = PDFFunctions.ArialFont10Bold;
        XSolidBrush blue = XBrushes.Blue;
        double num751 = (double) checked (L1ACheckList.RC1 + 1);
        xunit = PDFFunctions.pages[L1ACheckList.k].Width;
        double point388 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[L1ACheckList.k].Height;
        double num752 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect384 = new XRect(540.0, num751, point388, num752);
        XStringFormat topLeft384 = XStringFormat.TopLeft;
        xgraphics384.DrawString("N/A", arialFont10Bold139, (XBrush) blue, xrect384, topLeft384);
      }
      L1ACheckList.CheckCheckListRC1();
      // ISSUE: reference to a compiler-generated field
      if (SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Water.Solar.Inlcude)
      {
        checked { L1ACheckList.RC1 += 13; }
        L1ACheckList.CheckCheckListRC1();
        XGraphics xgraphics385 = PDFFunctions.gfx[L1ACheckList.k];
        XFont arialFont10_238 = PDFFunctions.ArialFont10;
        XSolidBrush black256 = XBrushes.Black;
        double num753 = (double) checked (L1ACheckList.RC1 + 1);
        xunit = PDFFunctions.pages[L1ACheckList.k].Width;
        double point389 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[L1ACheckList.k].Height;
        double num754 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect385 = new XRect(50.0, num753, point389, num754);
        XStringFormat topLeft385 = XStringFormat.TopLeft;
        xgraphics385.DrawString("Solar water heating", arialFont10_238, (XBrush) black256, xrect385, topLeft385);
        checked { L1ACheckList.RC1 += 13; }
        L1ACheckList.CheckCheckListRC1();
        // ISSUE: reference to a compiler-generated field
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Address.Country, "Scotland", false) == 0)
        {
          XGraphics xgraphics386 = PDFFunctions.gfx[L1ACheckList.k];
          XFont arialFont10_239 = PDFFunctions.ArialFont10;
          XSolidBrush black257 = XBrushes.Black;
          double num755 = (double) checked (L1ACheckList.RC1 + 1);
          xunit = PDFFunctions.pages[L1ACheckList.k].Width;
          double point390 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[L1ACheckList.k].Height;
          double num756 = ((XUnit) ref xunit).Point / 2.0;
          XRect xrect386 = new XRect(50.0, num755, point390, num756);
          XStringFormat topLeft386 = XStringFormat.TopLeft;
          xgraphics386.DrawString("Effective solar storage volume:", arialFont10_239, (XBrush) black257, xrect386, topLeft386);
        }
        else
        {
          XGraphics xgraphics387 = PDFFunctions.gfx[L1ACheckList.k];
          XFont arialFont10_240 = PDFFunctions.ArialFont10;
          XSolidBrush black258 = XBrushes.Black;
          double num757 = (double) checked (L1ACheckList.RC1 + 1);
          xunit = PDFFunctions.pages[L1ACheckList.k].Width;
          double point391 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[L1ACheckList.k].Height;
          double num758 = ((XUnit) ref xunit).Point / 2.0;
          XRect xrect387 = new XRect(50.0, num757, point391, num758);
          XStringFormat topLeft387 = XStringFormat.TopLeft;
          xgraphics387.DrawString("Dedicated solar storage volume:", arialFont10_240, (XBrush) black258, xrect387, topLeft387);
        }
        // ISSUE: reference to a compiler-generated field
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Address.Country, "Scotland", false) == 0)
        {
          XGraphics xgraphics388 = PDFFunctions.gfx[L1ACheckList.k];
          string str125 = Conversions.ToString(Math.Round(SAP_Module.Calculation2012.Calculation.Water_heating.Solar.H13, 0)) + " litres";
          XFont arialFont10_241 = PDFFunctions.ArialFont10;
          XSolidBrush black259 = XBrushes.Black;
          double num759 = (double) checked (L1ACheckList.RC1 + 1);
          xunit = PDFFunctions.pages[L1ACheckList.k].Width;
          double point392 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[L1ACheckList.k].Height;
          double num760 = ((XUnit) ref xunit).Point / 2.0;
          XRect xrect388 = new XRect(200.0, num759, point392, num760);
          XStringFormat topLeft388 = XStringFormat.TopLeft;
          xgraphics388.DrawString(str125, arialFont10_241, (XBrush) black259, xrect388, topLeft388);
        }
        else
        {
          XGraphics xgraphics389 = PDFFunctions.gfx[L1ACheckList.k];
          // ISSUE: reference to a compiler-generated field
          string str126 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Water.Solar.SolarVolume) + " litres";
          XFont arialFont10_242 = PDFFunctions.ArialFont10;
          XSolidBrush black260 = XBrushes.Black;
          double num761 = (double) checked (L1ACheckList.RC1 + 1);
          xunit = PDFFunctions.pages[L1ACheckList.k].Width;
          double point393 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[L1ACheckList.k].Height;
          double num762 = ((XUnit) ref xunit).Point / 2.0;
          XRect xrect389 = new XRect(200.0, num761, point393, num762);
          XStringFormat topLeft389 = XStringFormat.TopLeft;
          xgraphics389.DrawString(str126, arialFont10_242, (XBrush) black260, xrect389, topLeft389);
        }
        checked { L1ACheckList.RC1 += 13; }
        L1ACheckList.CheckCheckListRC1();
        XGraphics xgraphics390 = PDFFunctions.gfx[L1ACheckList.k];
        XFont arialFont10_243 = PDFFunctions.ArialFont10;
        XSolidBrush black261 = XBrushes.Black;
        double num763 = (double) checked (L1ACheckList.RC1 + 1);
        xunit = PDFFunctions.pages[L1ACheckList.k].Width;
        double point394 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[L1ACheckList.k].Height;
        double num764 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect390 = new XRect(50.0, num763, point394, num764);
        XStringFormat topLeft390 = XStringFormat.TopLeft;
        xgraphics390.DrawString("Minimum:", arialFont10_243, (XBrush) black261, xrect390, topLeft390);
        // ISSUE: reference to a compiler-generated field
        float num765 = 25f * SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Water.Solar.SolarArea;
        if (SAP_Module.Calculation2012.Calculation.Water_heating.Box43 * 0.8 < (double) num765)
          num765 = (float) (SAP_Module.Calculation2012.Calculation.Water_heating.Box43 * 0.8);
        XGraphics xgraphics391 = PDFFunctions.gfx[L1ACheckList.k];
        string str127 = Conversions.ToString(Math.Round((double) num765, 0)) + " litres";
        XFont arialFont10_244 = PDFFunctions.ArialFont10;
        XSolidBrush black262 = XBrushes.Black;
        double num766 = (double) checked (L1ACheckList.RC1 + 1);
        xunit = PDFFunctions.pages[L1ACheckList.k].Width;
        double point395 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[L1ACheckList.k].Height;
        double num767 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect391 = new XRect(200.0, num766, point395, num767);
        XStringFormat topLeft391 = XStringFormat.TopLeft;
        xgraphics391.DrawString(str127, arialFont10_244, (XBrush) black262, xrect391, topLeft391);
        // ISSUE: reference to a compiler-generated field
        if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Address.Country, "Scotland", false) > 0U)
        {
          // ISSUE: reference to a compiler-generated field
          if ((double) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Water.Solar.SolarVolume < (double) num765)
          {
            XGraphics xgraphics392 = PDFFunctions.gfx[L1ACheckList.k];
            XFont arialFont10Bold140 = PDFFunctions.ArialFont10Bold;
            XSolidBrush red = XBrushes.Red;
            double num768 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point396 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num769 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect392 = new XRect(540.0, num768, point396, num769);
            XStringFormat topLeft392 = XStringFormat.TopLeft;
            xgraphics392.DrawString("Fail", arialFont10Bold140, (XBrush) red, xrect392, topLeft392);
          }
          else
          {
            XGraphics xgraphics393 = PDFFunctions.gfx[L1ACheckList.k];
            XFont arialFont10Bold141 = PDFFunctions.ArialFont10Bold;
            XSolidBrush green = XBrushes.Green;
            double num770 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point397 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num771 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect393 = new XRect(540.0, num770, point397, num771);
            XStringFormat topLeft393 = XStringFormat.TopLeft;
            xgraphics393.DrawString("OK", arialFont10Bold141, (XBrush) green, xrect393, topLeft393);
          }
        }
        else if (SAP_Module.Calculation2012.Calculation.Water_heating.Solar.H13 < (double) num765)
        {
          XGraphics xgraphics394 = PDFFunctions.gfx[L1ACheckList.k];
          XFont arialFont10Bold142 = PDFFunctions.ArialFont10Bold;
          XSolidBrush red = XBrushes.Red;
          double num772 = (double) checked (L1ACheckList.RC1 + 1);
          xunit = PDFFunctions.pages[L1ACheckList.k].Width;
          double point398 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[L1ACheckList.k].Height;
          double num773 = ((XUnit) ref xunit).Point / 2.0;
          XRect xrect394 = new XRect(540.0, num772, point398, num773);
          XStringFormat topLeft394 = XStringFormat.TopLeft;
          xgraphics394.DrawString("Fail", arialFont10Bold142, (XBrush) red, xrect394, topLeft394);
        }
        else
        {
          XGraphics xgraphics395 = PDFFunctions.gfx[L1ACheckList.k];
          XFont arialFont10Bold143 = PDFFunctions.ArialFont10Bold;
          XSolidBrush green = XBrushes.Green;
          double num774 = (double) checked (L1ACheckList.RC1 + 1);
          xunit = PDFFunctions.pages[L1ACheckList.k].Width;
          double point399 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[L1ACheckList.k].Height;
          double num775 = ((XUnit) ref xunit).Point / 2.0;
          XRect xrect395 = new XRect(540.0, num774, point399, num775);
          XStringFormat topLeft395 = XStringFormat.TopLeft;
          xgraphics395.DrawString("OK", arialFont10Bold143, (XBrush) green, xrect395, topLeft395);
        }
        checked { L1ACheckList.RC1 += 13; }
        L1ACheckList.CheckCheckListRC1();
      }
      PDFFunctions.xBrush1 = XBrush.op_Implicit((Brush) new SolidBrush(Color.FromArgb(159, 172, 62)));
      PDFFunctions.Points[0].X = 20f;
      PDFFunctions.Points[0].Y = (float) L1ACheckList.RC1;
      ref PointF local21 = ref PDFFunctions.Points[1];
      xunit = PDFFunctions.pages[L1ACheckList.k].Width;
      double num776 = ((XUnit) ref xunit).Point - 20.0;
      local21.X = (float) num776;
      PDFFunctions.Points[1].Y = (float) L1ACheckList.RC1;
      ref PointF local22 = ref PDFFunctions.Points[2];
      xunit = PDFFunctions.pages[L1ACheckList.k].Width;
      double num777 = ((XUnit) ref xunit).Point - 20.0;
      local22.X = (float) num777;
      PDFFunctions.Points[2].Y = (float) checked (L1ACheckList.RC1 + 12);
      PDFFunctions.Points[3].X = 20f;
      PDFFunctions.Points[3].Y = (float) checked (L1ACheckList.RC1 + 12);
      PDFFunctions.gfx[L1ACheckList.k].DrawPolygon(PDFFunctions.polyGreen2, PDFFunctions.xBrush1, PDFFunctions.Points, PDFFunctions.Fill);
      // ISSUE: reference to a compiler-generated field
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Address.Country, "Northern Ireland", false) == 0)
      {
        XGraphics xgraphics396 = PDFFunctions.gfx[L1ACheckList.k];
        XFont arialFont10Bold144 = PDFFunctions.ArialFont10Bold;
        XSolidBrush white12 = XBrushes.White;
        double num778 = (double) checked (L1ACheckList.RC1 + 1);
        xunit = PDFFunctions.pages[L1ACheckList.k].Width;
        double point400 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[L1ACheckList.k].Height;
        double num779 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect396 = new XRect(25.0, num778, point400, num779);
        XStringFormat topLeft396 = XStringFormat.TopLeft;
        xgraphics396.DrawString("10 Controls", arialFont10Bold144, (XBrush) white12, xrect396, topLeft396);
      }
      else
      {
        XGraphics xgraphics397 = PDFFunctions.gfx[L1ACheckList.k];
        XFont arialFont10Bold145 = PDFFunctions.ArialFont10Bold;
        XSolidBrush white13 = XBrushes.White;
        double num780 = (double) checked (L1ACheckList.RC1 + 1);
        xunit = PDFFunctions.pages[L1ACheckList.k].Width;
        double point401 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[L1ACheckList.k].Height;
        double num781 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect397 = new XRect(25.0, num780, point401, num781);
        XStringFormat topLeft397 = XStringFormat.TopLeft;
        xgraphics397.DrawString("6 Controls", arialFont10Bold145, (XBrush) white13, xrect397, topLeft397);
      }
      checked { L1ACheckList.RC1 += 30; }
      XGraphics xgraphics398 = PDFFunctions.gfx[L1ACheckList.k];
      XFont arialFont10_245 = PDFFunctions.ArialFont10;
      XSolidBrush black263 = XBrushes.Black;
      double num782 = (double) checked (L1ACheckList.RC1 + 1);
      xunit = PDFFunctions.pages[L1ACheckList.k].Width;
      double point402 = ((XUnit) ref xunit).Point;
      xunit = PDFFunctions.pages[L1ACheckList.k].Height;
      double num783 = ((XUnit) ref xunit).Point / 2.0;
      XRect xrect398 = new XRect(50.0, num782, point402, num783);
      XStringFormat topLeft398 = XStringFormat.TopLeft;
      xgraphics398.DrawString("Space heating controls", arialFont10_245, (XBrush) black263, xrect398, topLeft398);
      // ISSUE: reference to a compiler-generated field
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.Controls, "Time and temperature zone control by suitable arrangement of plumbing and electrical services", false) == 0)
      {
        XGraphics xgraphics399 = PDFFunctions.gfx[L1ACheckList.k];
        XFont arialFont10_246 = PDFFunctions.ArialFont10;
        XSolidBrush black264 = XBrushes.Black;
        double num784 = (double) checked (L1ACheckList.RC1 + 1);
        xunit = PDFFunctions.pages[L1ACheckList.k].Width;
        double point403 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[L1ACheckList.k].Height;
        double num785 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect399 = new XRect(200.0, num784, point403, num785);
        XStringFormat topLeft399 = XStringFormat.TopLeft;
        xgraphics399.DrawString("TTZC by plumbing and electrical services", arialFont10_246, (XBrush) black264, xrect399, topLeft399);
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.Controls, "Charging system linked to use of community heating, programmer and at least two room thermostats", false) == 0)
        {
          XGraphics xgraphics400 = PDFFunctions.gfx[L1ACheckList.k];
          XFont arialFont10_247 = PDFFunctions.ArialFont10;
          XSolidBrush black265 = XBrushes.Black;
          double num786 = (double) checked (L1ACheckList.RC1 + 1);
          xunit = PDFFunctions.pages[L1ACheckList.k].Width;
          double point404 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[L1ACheckList.k].Height;
          double num787 = ((XUnit) ref xunit).Point / 2.0;
          XRect xrect400 = new XRect(200.0, num786, point404, num787);
          XStringFormat topLeft400 = XStringFormat.TopLeft;
          xgraphics400.DrawString("Charging system linked to use of community heating,", arialFont10_247, (XBrush) black265, xrect400, topLeft400);
          XGraphics xgraphics401 = PDFFunctions.gfx[L1ACheckList.k];
          XFont arialFont10_248 = PDFFunctions.ArialFont10;
          XSolidBrush black266 = XBrushes.Black;
          double num788 = (double) checked (L1ACheckList.RC1 + 12);
          xunit = PDFFunctions.pages[L1ACheckList.k].Width;
          double point405 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[L1ACheckList.k].Height;
          double num789 = ((XUnit) ref xunit).Point / 2.0;
          XRect xrect401 = new XRect(200.0, num788, point405, num789);
          XStringFormat topLeft401 = XStringFormat.TopLeft;
          xgraphics401.DrawString("programmer and at least two room thermostats", arialFont10_248, (XBrush) black266, xrect401, topLeft401);
          checked { L1ACheckList.RC1 += 12; }
        }
        else
        {
          XGraphics xgraphics402 = PDFFunctions.gfx[L1ACheckList.k];
          // ISSUE: reference to a compiler-generated field
          string controls = SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.Controls;
          XFont arialFont10_249 = PDFFunctions.ArialFont10;
          XSolidBrush black267 = XBrushes.Black;
          double num790 = (double) checked (L1ACheckList.RC1 + 1);
          xunit = PDFFunctions.pages[L1ACheckList.k].Width;
          double point406 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[L1ACheckList.k].Height;
          double num791 = ((XUnit) ref xunit).Point / 2.0;
          XRect xrect402 = new XRect(200.0, num790, point406, num791);
          XStringFormat topLeft402 = XStringFormat.TopLeft;
          xgraphics402.DrawString(controls, arialFont10_249, (XBrush) black267, xrect402, topLeft402);
        }
      }
      bool flag5;
      // ISSUE: reference to a compiler-generated field
      switch (SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.ControlCode)
      {
        case 2101:
        case 2102:
        case 2103:
        case 2107:
        case 2111:
          flag5 = true;
          break;
        case 2104:
          // ISSUE: reference to a compiler-generated field
          if (SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Storeys == 1)
          {
            // ISSUE: reference to a compiler-generated field
            if ((double) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].LivingFraction < 0.7)
            {
              flag5 = true;
              break;
            }
            break;
          }
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          if (!(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].NoofFloors == 1 & (double) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].LivingFraction >= 0.7))
          {
            flag5 = true;
            break;
          }
          break;
        case 2105:
        case 2106:
        case 2108:
        case 2109:
          if (SAP_Module.Calculation2012.Calculation.Dimensions.Box4 > 150.0)
          {
            flag5 = true;
            break;
          }
          break;
      }
      // ISSUE: reference to a compiler-generated field
      if (flag5 && SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.SAPTableCode == 632)
        flag5 = false;
      // ISSUE: reference to a compiler-generated field
      switch (SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.ControlCode)
      {
        case 2201:
        case 2202:
        case 2203:
          flag5 = true;
          break;
      }
      // ISSUE: reference to a compiler-generated field
      switch (SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.ControlCode)
      {
        case 2301:
        case 2302:
        case 2303:
        case 2304:
        case 2307:
        case 2308:
        case 2309:
          flag5 = true;
          break;
      }
      // ISSUE: reference to a compiler-generated field
      if (SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.ControlCode == 2401)
        flag5 = true;
      // ISSUE: reference to a compiler-generated field
      switch (SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.ControlCode)
      {
        case 2501:
        case 2502:
        case 2503:
          flag5 = true;
          break;
      }
      // ISSUE: reference to a compiler-generated field
      if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.Fuel, "Electricity", false) > 0U)
      {
        // ISSUE: reference to a compiler-generated field
        if (SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.ControlCode == 2601)
        {
          flag5 = true;
          // ISSUE: reference to a compiler-generated field
          if (SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.SAPTableCode == 632)
            flag5 = false;
        }
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        switch (SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.ControlCode)
        {
          case 2601:
          case 2602:
            flag5 = true;
            break;
        }
      }
      // ISSUE: reference to a compiler-generated field
      int controlCode1 = SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.ControlCode;
      if (controlCode1 == 2601 || controlCode1 == 2602 || controlCode1 >= 2701 && controlCode1 <= 2704)
        flag5 = true;
      if (flag5)
      {
        XGraphics xgraphics403 = PDFFunctions.gfx[L1ACheckList.k];
        XFont arialFont10Bold146 = PDFFunctions.ArialFont10Bold;
        XSolidBrush red = XBrushes.Red;
        double num792 = (double) checked (L1ACheckList.RC1 + 1);
        xunit = PDFFunctions.pages[L1ACheckList.k].Width;
        double point407 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[L1ACheckList.k].Height;
        double num793 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect403 = new XRect(540.0, num792, point407, num793);
        XStringFormat topLeft403 = XStringFormat.TopLeft;
        xgraphics403.DrawString("Fail", arialFont10Bold146, (XBrush) red, xrect403, topLeft403);
      }
      else
      {
        XGraphics xgraphics404 = PDFFunctions.gfx[L1ACheckList.k];
        XFont arialFont10Bold147 = PDFFunctions.ArialFont10Bold;
        XSolidBrush green = XBrushes.Green;
        double num794 = (double) checked (L1ACheckList.RC1 + 1);
        xunit = PDFFunctions.pages[L1ACheckList.k].Width;
        double point408 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[L1ACheckList.k].Height;
        double num795 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect404 = new XRect(540.0, num794, point408, num795);
        XStringFormat topLeft404 = XStringFormat.TopLeft;
        xgraphics404.DrawString("OK", arialFont10Bold147, (XBrush) green, xrect404, topLeft404);
      }
      checked { L1ACheckList.RC1 += 13; }
      // ISSUE: reference to a compiler-generated field
      if (SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].IncludeMainHeating2)
      {
        XGraphics xgraphics405 = PDFFunctions.gfx[L1ACheckList.k];
        XFont arialFont10_250 = PDFFunctions.ArialFont10;
        XSolidBrush black268 = XBrushes.Black;
        double num796 = (double) checked (L1ACheckList.RC1 + 1);
        xunit = PDFFunctions.pages[L1ACheckList.k].Width;
        double point409 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[L1ACheckList.k].Height;
        double num797 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect405 = new XRect(50.0, num796, point409, num797);
        XStringFormat topLeft405 = XStringFormat.TopLeft;
        xgraphics405.DrawString("Space heating controls 2:", arialFont10_250, (XBrush) black268, xrect405, topLeft405);
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.Controls, "Not applicable (boiler provides DHW only)", false) == 0 & SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].WaterOnlyHeatPump)
        {
          XGraphics xgraphics406 = PDFFunctions.gfx[L1ACheckList.k];
          // ISSUE: reference to a compiler-generated field
          string controls = SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.Controls;
          XFont arialFont10_251 = PDFFunctions.ArialFont10;
          XSolidBrush black269 = XBrushes.Black;
          double num798 = (double) checked (L1ACheckList.RC1 + 1);
          xunit = PDFFunctions.pages[L1ACheckList.k].Width;
          double point410 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[L1ACheckList.k].Height;
          double num799 = ((XUnit) ref xunit).Point / 2.0;
          XRect xrect406 = new XRect(200.0, num798, point410, num799);
          XStringFormat topLeft406 = XStringFormat.TopLeft;
          xgraphics406.DrawString(controls, arialFont10_251, (XBrush) black269, xrect406, topLeft406);
        }
        else
        {
          XGraphics xgraphics407 = PDFFunctions.gfx[L1ACheckList.k];
          // ISSUE: reference to a compiler-generated field
          string controls = SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.Controls;
          XFont arialFont10_252 = PDFFunctions.ArialFont10;
          XSolidBrush black270 = XBrushes.Black;
          double num800 = (double) checked (L1ACheckList.RC1 + 1);
          xunit = PDFFunctions.pages[L1ACheckList.k].Width;
          double point411 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[L1ACheckList.k].Height;
          double num801 = ((XUnit) ref xunit).Point / 2.0;
          XRect xrect407 = new XRect(200.0, num800, point411, num801);
          XStringFormat topLeft407 = XStringFormat.TopLeft;
          xgraphics407.DrawString(controls, arialFont10_252, (XBrush) black270, xrect407, topLeft407);
        }
        bool flag6;
        // ISSUE: reference to a compiler-generated field
        switch (SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.ControlCode)
        {
          case 2101:
          case 2102:
          case 2103:
          case 2107:
          case 2111:
            flag6 = true;
            break;
          case 2104:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            if (!(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].NoofFloors == 1 & (double) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].LivingFraction >= 0.7))
            {
              flag6 = true;
              break;
            }
            break;
          case 2105:
          case 2106:
          case 2108:
          case 2109:
            if (SAP_Module.Calculation2012.Calculation.Dimensions.Box4 > 150.0)
            {
              flag6 = true;
              break;
            }
            break;
        }
        // ISSUE: reference to a compiler-generated field
        if (flag6 && SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.SAPTableCode == 632)
          flag6 = false;
        // ISSUE: reference to a compiler-generated field
        switch (SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.ControlCode)
        {
          case 2201:
          case 2202:
          case 2203:
            flag6 = true;
            break;
        }
        // ISSUE: reference to a compiler-generated field
        switch (SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.ControlCode)
        {
          case 2301:
          case 2302:
          case 2303:
          case 2304:
          case 2307:
          case 2308:
          case 2309:
            flag6 = true;
            break;
        }
        // ISSUE: reference to a compiler-generated field
        if (SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.ControlCode == 2401)
          flag6 = true;
        // ISSUE: reference to a compiler-generated field
        switch (SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.ControlCode)
        {
          case 2501:
          case 2502:
          case 2503:
            flag6 = true;
            break;
        }
        // ISSUE: reference to a compiler-generated field
        if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.Fuel, "Electricity", false) > 0U)
        {
          // ISSUE: reference to a compiler-generated field
          if (SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.ControlCode == 2601)
          {
            flag6 = true;
            // ISSUE: reference to a compiler-generated field
            if (SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.SAPTableCode == 632)
              flag6 = false;
          }
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          switch (SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.ControlCode)
          {
            case 2601:
            case 2602:
              flag6 = true;
              break;
          }
        }
        // ISSUE: reference to a compiler-generated field
        int controlCode2 = SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.ControlCode;
        if (controlCode2 == 2601 || controlCode2 == 2602 || controlCode2 >= 2701 && controlCode2 <= 2704)
          flag6 = true;
        if (flag6)
        {
          XGraphics xgraphics408 = PDFFunctions.gfx[L1ACheckList.k];
          XFont arialFont10Bold148 = PDFFunctions.ArialFont10Bold;
          XSolidBrush red = XBrushes.Red;
          double num802 = (double) checked (L1ACheckList.RC1 + 1);
          xunit = PDFFunctions.pages[L1ACheckList.k].Width;
          double point412 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[L1ACheckList.k].Height;
          double num803 = ((XUnit) ref xunit).Point / 2.0;
          XRect xrect408 = new XRect(540.0, num802, point412, num803);
          XStringFormat topLeft408 = XStringFormat.TopLeft;
          xgraphics408.DrawString("Fail", arialFont10Bold148, (XBrush) red, xrect408, topLeft408);
        }
        else
        {
          XGraphics xgraphics409 = PDFFunctions.gfx[L1ACheckList.k];
          XFont arialFont10Bold149 = PDFFunctions.ArialFont10Bold;
          XSolidBrush green = XBrushes.Green;
          double num804 = (double) checked (L1ACheckList.RC1 + 1);
          xunit = PDFFunctions.pages[L1ACheckList.k].Width;
          double point413 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[L1ACheckList.k].Height;
          double num805 = ((XUnit) ref xunit).Point / 2.0;
          XRect xrect409 = new XRect(540.0, num804, point413, num805);
          XStringFormat topLeft409 = XStringFormat.TopLeft;
          xgraphics409.DrawString("OK", arialFont10Bold149, (XBrush) green, xrect409, topLeft409);
        }
        checked { L1ACheckList.RC1 += 13; }
      }
      XGraphics xgraphics410 = PDFFunctions.gfx[L1ACheckList.k];
      XFont arialFont10_253 = PDFFunctions.ArialFont10;
      XSolidBrush black271 = XBrushes.Black;
      double num806 = (double) checked (L1ACheckList.RC1 + 1);
      xunit = PDFFunctions.pages[L1ACheckList.k].Width;
      double point414 = ((XUnit) ref xunit).Point;
      xunit = PDFFunctions.pages[L1ACheckList.k].Height;
      double num807 = ((XUnit) ref xunit).Point / 2.0;
      XRect xrect410 = new XRect(50.0, num806, point414, num807);
      XStringFormat topLeft410 = XStringFormat.TopLeft;
      xgraphics410.DrawString("Hot water controls:", arialFont10_253, (XBrush) black271, xrect410, topLeft410);
      if (!L1ACheckList.CylinderFound)
      {
        XGraphics xgraphics411 = PDFFunctions.gfx[L1ACheckList.k];
        XFont arialFont10_254 = PDFFunctions.ArialFont10;
        XSolidBrush black272 = XBrushes.Black;
        double num808 = (double) checked (L1ACheckList.RC1 + 1);
        xunit = PDFFunctions.pages[L1ACheckList.k].Width;
        double point415 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[L1ACheckList.k].Height;
        double num809 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect411 = new XRect(200.0, num808, point415, num809);
        XStringFormat topLeft411 = XStringFormat.TopLeft;
        xgraphics411.DrawString("No cylinder thermostat", arialFont10_254, (XBrush) black272, xrect411, topLeft411);
        checked { L1ACheckList.RC1 += 13; }
      }
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      if (SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].WaterOnlyHeatPump & SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating2.HPOnly.HotWaterHP_Integral)
        L1ACheckList.CylinderFound = false;
      bool flag7;
      if (L1ACheckList.CylinderFound)
      {
        // ISSUE: reference to a compiler-generated field
        int sapTableCode11 = SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.SAPTableCode;
        if (sapTableCode11 >= 305 && sapTableCode11 <= 310)
        {
          XGraphics xgraphics412 = PDFFunctions.gfx[L1ACheckList.k];
          XFont arialFont10_255 = PDFFunctions.ArialFont10;
          XSolidBrush black273 = XBrushes.Black;
          double num810 = (double) checked (L1ACheckList.RC1 + 1);
          xunit = PDFFunctions.pages[L1ACheckList.k].Width;
          double point416 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[L1ACheckList.k].Height;
          double num811 = ((XUnit) ref xunit).Point / 2.0;
          XRect xrect412 = new XRect(200.0, num810, point416, num811);
          XStringFormat topLeft412 = XStringFormat.TopLeft;
          xgraphics412.DrawString("Cylinderstat", arialFont10_255, (XBrush) black273, xrect412, topLeft412);
          XGraphics xgraphics413 = PDFFunctions.gfx[L1ACheckList.k];
          XFont arialFont10Bold150 = PDFFunctions.ArialFont10Bold;
          XSolidBrush green = XBrushes.Green;
          double num812 = (double) checked (L1ACheckList.RC1 + 1);
          xunit = PDFFunctions.pages[L1ACheckList.k].Width;
          double point417 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[L1ACheckList.k].Height;
          double num813 = ((XUnit) ref xunit).Point / 2.0;
          XRect xrect413 = new XRect(540.0, num812, point417, num813);
          XStringFormat topLeft413 = XStringFormat.TopLeft;
          xgraphics413.DrawString("OK", arialFont10Bold150, (XBrush) green, xrect413, topLeft413);
          checked { L1ACheckList.RC1 += 13; }
        }
        else if (sapTableCode11 == 130)
        {
          XGraphics xgraphics414 = PDFFunctions.gfx[L1ACheckList.k];
          XFont arialFont10_256 = PDFFunctions.ArialFont10;
          XSolidBrush black274 = XBrushes.Black;
          double num814 = (double) checked (L1ACheckList.RC1 + 1);
          xunit = PDFFunctions.pages[L1ACheckList.k].Width;
          double point418 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[L1ACheckList.k].Height;
          double num815 = ((XUnit) ref xunit).Point / 2.0;
          XRect xrect414 = new XRect(200.0, num814, point418, num815);
          XStringFormat topLeft414 = XStringFormat.TopLeft;
          xgraphics414.DrawString("No cylinder thermostat", arialFont10_256, (XBrush) black274, xrect414, topLeft414);
          checked { L1ACheckList.RC1 += 13; }
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.SEDBUK, "10108", false) == 0)
          {
            XGraphics xgraphics415 = PDFFunctions.gfx[L1ACheckList.k];
            XFont arialFont10_257 = PDFFunctions.ArialFont10;
            XSolidBrush black275 = XBrushes.Black;
            double num816 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point419 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num817 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect415 = new XRect(200.0, num816, point419, num817);
            XStringFormat topLeft415 = XStringFormat.TopLeft;
            xgraphics415.DrawString("No cylinder thermostat", arialFont10_257, (XBrush) black275, xrect415, topLeft415);
            checked { L1ACheckList.RC1 += 13; }
          }
          else
          {
            // ISSUE: reference to a compiler-generated field
            if (SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Water.Cylinder.Thermostat)
            {
              XGraphics xgraphics416 = PDFFunctions.gfx[L1ACheckList.k];
              XFont arialFont10_258 = PDFFunctions.ArialFont10;
              XSolidBrush black276 = XBrushes.Black;
              double num818 = (double) checked (L1ACheckList.RC1 + 1);
              xunit = PDFFunctions.pages[L1ACheckList.k].Width;
              double point420 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[L1ACheckList.k].Height;
              double num819 = ((XUnit) ref xunit).Point / 2.0;
              XRect xrect416 = new XRect(200.0, num818, point420, num819);
              XStringFormat topLeft416 = XStringFormat.TopLeft;
              xgraphics416.DrawString("Cylinderstat", arialFont10_258, (XBrush) black276, xrect416, topLeft416);
              XGraphics xgraphics417 = PDFFunctions.gfx[L1ACheckList.k];
              XFont arialFont10Bold151 = PDFFunctions.ArialFont10Bold;
              XSolidBrush green = XBrushes.Green;
              double num820 = (double) checked (L1ACheckList.RC1 + 1);
              xunit = PDFFunctions.pages[L1ACheckList.k].Width;
              double point421 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[L1ACheckList.k].Height;
              double num821 = ((XUnit) ref xunit).Point / 2.0;
              XRect xrect417 = new XRect(540.0, num820, point421, num821);
              XStringFormat topLeft417 = XStringFormat.TopLeft;
              xgraphics417.DrawString("OK", arialFont10Bold151, (XBrush) green, xrect417, topLeft417);
              checked { L1ACheckList.RC1 += 13; }
            }
            else
            {
              // ISSUE: reference to a compiler-generated field
              if (SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.SAPTableCode == 192)
              {
                XGraphics xgraphics418 = PDFFunctions.gfx[L1ACheckList.k];
                XFont arialFont10_259 = PDFFunctions.ArialFont10;
                XSolidBrush black277 = XBrushes.Black;
                double num822 = (double) checked (L1ACheckList.RC1 + 1);
                xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                double point422 = ((XUnit) ref xunit).Point;
                xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                double num823 = ((XUnit) ref xunit).Point / 2.0;
                XRect xrect418 = new XRect(200.0, num822, point422, num823);
                XStringFormat topLeft418 = XStringFormat.TopLeft;
                xgraphics418.DrawString("Cylinderstat", arialFont10_259, (XBrush) black277, xrect418, topLeft418);
                XGraphics xgraphics419 = PDFFunctions.gfx[L1ACheckList.k];
                XFont arialFont10Bold152 = PDFFunctions.ArialFont10Bold;
                XSolidBrush green = XBrushes.Green;
                double num824 = (double) checked (L1ACheckList.RC1 + 1);
                xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                double point423 = ((XUnit) ref xunit).Point;
                xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                double num825 = ((XUnit) ref xunit).Point / 2.0;
                XRect xrect419 = new XRect(540.0, num824, point423, num825);
                XStringFormat topLeft419 = XStringFormat.TopLeft;
                xgraphics419.DrawString("OK", arialFont10Bold152, (XBrush) green, xrect419, topLeft419);
              }
              else
              {
                XGraphics xgraphics420 = PDFFunctions.gfx[L1ACheckList.k];
                XFont arialFont10_260 = PDFFunctions.ArialFont10;
                XSolidBrush black278 = XBrushes.Black;
                double num826 = (double) checked (L1ACheckList.RC1 + 1);
                xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                double point424 = ((XUnit) ref xunit).Point;
                xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                double num827 = ((XUnit) ref xunit).Point / 2.0;
                XRect xrect420 = new XRect(200.0, num826, point424, num827);
                XStringFormat topLeft420 = XStringFormat.TopLeft;
                xgraphics420.DrawString("No cylinder thermostat", arialFont10_260, (XBrush) black278, xrect420, topLeft420);
                XGraphics xgraphics421 = PDFFunctions.gfx[L1ACheckList.k];
                XFont arialFont10Bold153 = PDFFunctions.ArialFont10Bold;
                XSolidBrush red = XBrushes.Red;
                double num828 = (double) checked (L1ACheckList.RC1 + 1);
                xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                double point425 = ((XUnit) ref xunit).Point;
                xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                double num829 = ((XUnit) ref xunit).Point / 2.0;
                XRect xrect421 = new XRect(540.0, num828, point425, num829);
                XStringFormat topLeft421 = XStringFormat.TopLeft;
                xgraphics421.DrawString("Fail", arialFont10Bold153, (XBrush) red, xrect421, topLeft421);
                flag7 = true;
                flag2 = true;
              }
              checked { L1ACheckList.RC1 += 13; }
            }
          }
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          if (SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Water.SystemRef == 901 | SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Water.SystemRef == 911)
          {
            // ISSUE: reference to a compiler-generated field
            int sapTableCode12 = SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.SAPTableCode;
            if (sapTableCode12 != 191 && (sapTableCode12 < 501 || sapTableCode12 > 511) && sapTableCode12 != 525 && sapTableCode12 != 526 && sapTableCode12 != 527)
            {
              // ISSUE: reference to a compiler-generated field
              if (SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Water.Cylinder.Timed)
              {
                XGraphics xgraphics422 = PDFFunctions.gfx[L1ACheckList.k];
                XFont arialFont10_261 = PDFFunctions.ArialFont10;
                XSolidBrush black279 = XBrushes.Black;
                double num830 = (double) checked (L1ACheckList.RC1 + 1);
                xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                double point426 = ((XUnit) ref xunit).Point;
                xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                double num831 = ((XUnit) ref xunit).Point / 2.0;
                XRect xrect422 = new XRect(200.0, num830, point426, num831);
                XStringFormat topLeft422 = XStringFormat.TopLeft;
                xgraphics422.DrawString("Independent timer for DHW", arialFont10_261, (XBrush) black279, xrect422, topLeft422);
                XGraphics xgraphics423 = PDFFunctions.gfx[L1ACheckList.k];
                XFont arialFont10Bold154 = PDFFunctions.ArialFont10Bold;
                XSolidBrush green = XBrushes.Green;
                double num832 = (double) checked (L1ACheckList.RC1 + 1);
                xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                double point427 = ((XUnit) ref xunit).Point;
                xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                double num833 = ((XUnit) ref xunit).Point / 2.0;
                XRect xrect423 = new XRect(540.0, num832, point427, num833);
                XStringFormat topLeft423 = XStringFormat.TopLeft;
                xgraphics423.DrawString("OK", arialFont10Bold154, (XBrush) green, xrect423, topLeft423);
                checked { L1ACheckList.RC1 += 13; }
              }
              else
              {
                // ISSUE: reference to a compiler-generated field
                if (SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.SAPTableCode == 192)
                {
                  XGraphics xgraphics424 = PDFFunctions.gfx[L1ACheckList.k];
                  XFont arialFont10_262 = PDFFunctions.ArialFont10;
                  XSolidBrush black280 = XBrushes.Black;
                  double num834 = (double) checked (L1ACheckList.RC1 + 1);
                  xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                  double point428 = ((XUnit) ref xunit).Point;
                  xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                  double num835 = ((XUnit) ref xunit).Point / 2.0;
                  XRect xrect424 = new XRect(200.0, num834, point428, num835);
                  XStringFormat topLeft424 = XStringFormat.TopLeft;
                  xgraphics424.DrawString("Independent timer for DHW ", arialFont10_262, (XBrush) black280, xrect424, topLeft424);
                  XGraphics xgraphics425 = PDFFunctions.gfx[L1ACheckList.k];
                  XFont arialFont10Bold155 = PDFFunctions.ArialFont10Bold;
                  XSolidBrush green = XBrushes.Green;
                  double num836 = (double) checked (L1ACheckList.RC1 + 1);
                  xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                  double point429 = ((XUnit) ref xunit).Point;
                  xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                  double num837 = ((XUnit) ref xunit).Point / 2.0;
                  XRect xrect425 = new XRect(540.0, num836, point429, num837);
                  XStringFormat topLeft425 = XStringFormat.TopLeft;
                  xgraphics425.DrawString("OK", arialFont10Bold155, (XBrush) green, xrect425, topLeft425);
                }
                else
                {
                  XGraphics xgraphics426 = PDFFunctions.gfx[L1ACheckList.k];
                  XFont arialFont10_263 = PDFFunctions.ArialFont10;
                  XSolidBrush black281 = XBrushes.Black;
                  double num838 = (double) checked (L1ACheckList.RC1 + 1);
                  xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                  double point430 = ((XUnit) ref xunit).Point;
                  xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                  double num839 = ((XUnit) ref xunit).Point / 2.0;
                  XRect xrect426 = new XRect(200.0, num838, point430, num839);
                  XStringFormat topLeft426 = XStringFormat.TopLeft;
                  xgraphics426.DrawString("No independent timer for DHW:", arialFont10_263, (XBrush) black281, xrect426, topLeft426);
                  XGraphics xgraphics427 = PDFFunctions.gfx[L1ACheckList.k];
                  XFont arialFont10Bold156 = PDFFunctions.ArialFont10Bold;
                  XSolidBrush red = XBrushes.Red;
                  double num840 = (double) checked (L1ACheckList.RC1 + 1);
                  xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                  double point431 = ((XUnit) ref xunit).Point;
                  xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                  double num841 = ((XUnit) ref xunit).Point / 2.0;
                  XRect xrect427 = new XRect(540.0, num840, point431, num841);
                  XStringFormat topLeft427 = XStringFormat.TopLeft;
                  xgraphics427.DrawString("Fail", arialFont10Bold156, (XBrush) red, xrect427, topLeft427);
                  flag7 = true;
                  flag2 = true;
                }
                checked { L1ACheckList.RC1 += 13; }
              }
            }
          }
        }
      }
      else
      {
        XGraphics xgraphics428 = PDFFunctions.gfx[L1ACheckList.k];
        XFont arialFont10_264 = PDFFunctions.ArialFont10;
        XSolidBrush black282 = XBrushes.Black;
        double num842 = (double) checked (L1ACheckList.RC1 + 1);
        xunit = PDFFunctions.pages[L1ACheckList.k].Width;
        double point432 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[L1ACheckList.k].Height;
        double num843 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect428 = new XRect(200.0, num842, point432, num843);
        XStringFormat topLeft428 = XStringFormat.TopLeft;
        xgraphics428.DrawString("No cylinder", arialFont10_264, (XBrush) black282, xrect428, topLeft428);
        checked { L1ACheckList.RC1 += 13; }
      }
      // ISSUE: reference to a compiler-generated field
      if (!flag4 && SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.SAPTableCode < 150)
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.SGroup, "Micro-cogeneration (micro-CHP)", false) > 0U & (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.SGroup, "Heat pumps", false) > 0U)
        {
          XGraphics xgraphics429 = PDFFunctions.gfx[L1ACheckList.k];
          XFont arialFont10_265 = PDFFunctions.ArialFont10;
          XSolidBrush black283 = XBrushes.Black;
          double num844 = (double) checked (L1ACheckList.RC1 + 1);
          xunit = PDFFunctions.pages[L1ACheckList.k].Width;
          double point433 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[L1ACheckList.k].Height;
          double num845 = ((XUnit) ref xunit).Point / 2.0;
          XRect xrect429 = new XRect(50.0, num844, point433, num845);
          XStringFormat topLeft429 = XStringFormat.TopLeft;
          xgraphics429.DrawString("Boiler interlock:", arialFont10_265, (XBrush) black283, xrect429, topLeft429);
        }
        // ISSUE: reference to a compiler-generated field
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.Boiler.BILock, "Yes", false) == 0)
        {
          XGraphics xgraphics430 = PDFFunctions.gfx[L1ACheckList.k];
          XFont arialFont10_266 = PDFFunctions.ArialFont10;
          XSolidBrush black284 = XBrushes.Black;
          double num846 = (double) checked (L1ACheckList.RC1 + 1);
          xunit = PDFFunctions.pages[L1ACheckList.k].Width;
          double point434 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[L1ACheckList.k].Height;
          double num847 = ((XUnit) ref xunit).Point / 2.0;
          XRect xrect430 = new XRect(200.0, num846, point434, num847);
          XStringFormat topLeft430 = XStringFormat.TopLeft;
          xgraphics430.DrawString("Yes", arialFont10_266, (XBrush) black284, xrect430, topLeft430);
          XGraphics xgraphics431 = PDFFunctions.gfx[L1ACheckList.k];
          XFont arialFont10Bold157 = PDFFunctions.ArialFont10Bold;
          XSolidBrush green = XBrushes.Green;
          double num848 = (double) checked (L1ACheckList.RC1 + 1);
          xunit = PDFFunctions.pages[L1ACheckList.k].Width;
          double point435 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[L1ACheckList.k].Height;
          double num849 = ((XUnit) ref xunit).Point / 2.0;
          XRect xrect431 = new XRect(540.0, num848, point435, num849);
          XStringFormat topLeft431 = XStringFormat.TopLeft;
          xgraphics431.DrawString("OK", arialFont10Bold157, (XBrush) green, xrect431, topLeft431);
          checked { L1ACheckList.RC1 += 13; }
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.SGroup, "Micro-cogeneration (micro-CHP)", false) > 0U & (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.SGroup, "Heat pumps", false) > 0U)
          {
            XGraphics xgraphics432 = PDFFunctions.gfx[L1ACheckList.k];
            XFont arialFont10_267 = PDFFunctions.ArialFont10;
            XSolidBrush black285 = XBrushes.Black;
            double num850 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point436 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num851 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect432 = new XRect(200.0, num850, point436, num851);
            XStringFormat topLeft432 = XStringFormat.TopLeft;
            xgraphics432.DrawString("No", arialFont10_267, (XBrush) black285, xrect432, topLeft432);
            XGraphics xgraphics433 = PDFFunctions.gfx[L1ACheckList.k];
            XFont arialFont10Bold158 = PDFFunctions.ArialFont10Bold;
            XSolidBrush red = XBrushes.Red;
            double num852 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point437 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num853 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect433 = new XRect(540.0, num852, point437, num853);
            XStringFormat topLeft433 = XStringFormat.TopLeft;
            xgraphics433.DrawString("Fail", arialFont10Bold158, (XBrush) red, xrect433, topLeft433);
            checked { L1ACheckList.RC1 += 13; }
          }
        }
      }
      L1ACheckList.CheckCheckListRC1();
      PDFFunctions.xBrush1 = XBrush.op_Implicit((Brush) new SolidBrush(Color.FromArgb(159, 172, 62)));
      PDFFunctions.Points[0].X = 20f;
      PDFFunctions.Points[0].Y = (float) L1ACheckList.RC1;
      ref PointF local23 = ref PDFFunctions.Points[1];
      xunit = PDFFunctions.pages[L1ACheckList.k].Width;
      double num854 = ((XUnit) ref xunit).Point - 20.0;
      local23.X = (float) num854;
      PDFFunctions.Points[1].Y = (float) L1ACheckList.RC1;
      ref PointF local24 = ref PDFFunctions.Points[2];
      xunit = PDFFunctions.pages[L1ACheckList.k].Width;
      double num855 = ((XUnit) ref xunit).Point - 20.0;
      local24.X = (float) num855;
      PDFFunctions.Points[2].Y = (float) checked (L1ACheckList.RC1 + 12);
      PDFFunctions.Points[3].X = 20f;
      PDFFunctions.Points[3].Y = (float) checked (L1ACheckList.RC1 + 12);
      PDFFunctions.gfx[L1ACheckList.k].DrawPolygon(PDFFunctions.polyGreen2, PDFFunctions.xBrush1, PDFFunctions.Points, PDFFunctions.Fill);
      XGraphics xgraphics434 = PDFFunctions.gfx[L1ACheckList.k];
      XFont arialFont10Bold159 = PDFFunctions.ArialFont10Bold;
      XSolidBrush white14 = XBrushes.White;
      double num856 = (double) checked (L1ACheckList.RC1 + 1);
      xunit = PDFFunctions.pages[L1ACheckList.k].Width;
      double point438 = ((XUnit) ref xunit).Point;
      xunit = PDFFunctions.pages[L1ACheckList.k].Height;
      double num857 = ((XUnit) ref xunit).Point / 2.0;
      XRect xrect434 = new XRect(25.0, num856, point438, num857);
      XStringFormat topLeft434 = XStringFormat.TopLeft;
      xgraphics434.DrawString("7 Low energy lights", arialFont10Bold159, (XBrush) white14, xrect434, topLeft434);
      checked { L1ACheckList.RC1 += 15; }
      XGraphics xgraphics435 = PDFFunctions.gfx[L1ACheckList.k];
      XFont arialFont10_268 = PDFFunctions.ArialFont10;
      XSolidBrush black286 = XBrushes.Black;
      double num858 = (double) checked (L1ACheckList.RC1 + 1);
      xunit = PDFFunctions.pages[L1ACheckList.k].Width;
      double point439 = ((XUnit) ref xunit).Point;
      xunit = PDFFunctions.pages[L1ACheckList.k].Height;
      double num859 = ((XUnit) ref xunit).Point / 2.0;
      XRect xrect435 = new XRect(50.0, num858, point439, num859);
      XStringFormat topLeft435 = XStringFormat.TopLeft;
      xgraphics435.DrawString("Percentage of fixed lights with low-energy fittings", arialFont10_268, (XBrush) black286, xrect435, topLeft435);
      XGraphics xgraphics436 = PDFFunctions.gfx[L1ACheckList.k];
      // ISSUE: reference to a compiler-generated field
      string str128 = Microsoft.VisualBasic.Strings.Format((object) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].LowEnergyLight, "00.0") + "%";
      XFont arialFont10_269 = PDFFunctions.ArialFont10;
      XSolidBrush black287 = XBrushes.Black;
      double num860 = (double) checked (L1ACheckList.RC1 + 1);
      xunit = PDFFunctions.pages[L1ACheckList.k].Width;
      double point440 = ((XUnit) ref xunit).Point;
      xunit = PDFFunctions.pages[L1ACheckList.k].Height;
      double num861 = ((XUnit) ref xunit).Point / 2.0;
      XRect xrect436 = new XRect(360.0, num860, point440, num861);
      XStringFormat topLeft436 = XStringFormat.TopLeft;
      xgraphics436.DrawString(str128, arialFont10_269, (XBrush) black287, xrect436, topLeft436);
      checked { L1ACheckList.RC1 += 13; }
      XGraphics xgraphics437 = PDFFunctions.gfx[L1ACheckList.k];
      XFont arialFont10_270 = PDFFunctions.ArialFont10;
      XSolidBrush black288 = XBrushes.Black;
      double num862 = (double) checked (L1ACheckList.RC1 + 1);
      xunit = PDFFunctions.pages[L1ACheckList.k].Width;
      double point441 = ((XUnit) ref xunit).Point;
      xunit = PDFFunctions.pages[L1ACheckList.k].Height;
      double num863 = ((XUnit) ref xunit).Point / 2.0;
      XRect xrect437 = new XRect(50.0, num862, point441, num863);
      XStringFormat topLeft437 = XStringFormat.TopLeft;
      xgraphics437.DrawString("Minimum", arialFont10_270, (XBrush) black288, xrect437, topLeft437);
      XGraphics xgraphics438 = PDFFunctions.gfx[L1ACheckList.k];
      XFont arialFont10_271 = PDFFunctions.ArialFont10;
      XSolidBrush black289 = XBrushes.Black;
      double num864 = (double) checked (L1ACheckList.RC1 + 1);
      xunit = PDFFunctions.pages[L1ACheckList.k].Width;
      double point442 = ((XUnit) ref xunit).Point;
      xunit = PDFFunctions.pages[L1ACheckList.k].Height;
      double num865 = ((XUnit) ref xunit).Point / 2.0;
      XRect xrect438 = new XRect(360.0, num864, point442, num865);
      XStringFormat topLeft438 = XStringFormat.TopLeft;
      xgraphics438.DrawString("75.0%", arialFont10_271, (XBrush) black289, xrect438, topLeft438);
      // ISSUE: reference to a compiler-generated field
      if ((double) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].LowEnergyLight < 75.0)
      {
        XGraphics xgraphics439 = PDFFunctions.gfx[L1ACheckList.k];
        XFont arialFont10Bold160 = PDFFunctions.ArialFont10Bold;
        XSolidBrush red = XBrushes.Red;
        double num866 = (double) checked (L1ACheckList.RC1 + 1);
        xunit = PDFFunctions.pages[L1ACheckList.k].Width;
        double point443 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[L1ACheckList.k].Height;
        double num867 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect439 = new XRect(540.0, num866, point443, num867);
        XStringFormat topLeft439 = XStringFormat.TopLeft;
        xgraphics439.DrawString("Fail", arialFont10Bold160, (XBrush) red, xrect439, topLeft439);
      }
      else
      {
        XGraphics xgraphics440 = PDFFunctions.gfx[L1ACheckList.k];
        XFont arialFont10Bold161 = PDFFunctions.ArialFont10Bold;
        XSolidBrush green = XBrushes.Green;
        double num868 = (double) checked (L1ACheckList.RC1 + 1);
        xunit = PDFFunctions.pages[L1ACheckList.k].Width;
        double point444 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[L1ACheckList.k].Height;
        double num869 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect440 = new XRect(540.0, num868, point444, num869);
        XStringFormat topLeft440 = XStringFormat.TopLeft;
        xgraphics440.DrawString("OK", arialFont10Bold161, (XBrush) green, xrect440, topLeft440);
      }
      checked { L1ACheckList.RC1 += 15; }
      L1ACheckList.CheckCheckListRC1();
      PDFFunctions.xBrush1 = XBrush.op_Implicit((Brush) new SolidBrush(Color.FromArgb(159, 172, 62)));
      PDFFunctions.Points[0].X = 20f;
      PDFFunctions.Points[0].Y = (float) L1ACheckList.RC1;
      ref PointF local25 = ref PDFFunctions.Points[1];
      xunit = PDFFunctions.pages[L1ACheckList.k].Width;
      double num870 = ((XUnit) ref xunit).Point - 20.0;
      local25.X = (float) num870;
      PDFFunctions.Points[1].Y = (float) L1ACheckList.RC1;
      ref PointF local26 = ref PDFFunctions.Points[2];
      xunit = PDFFunctions.pages[L1ACheckList.k].Width;
      double num871 = ((XUnit) ref xunit).Point - 20.0;
      local26.X = (float) num871;
      PDFFunctions.Points[2].Y = (float) checked (L1ACheckList.RC1 + 12);
      PDFFunctions.Points[3].X = 20f;
      PDFFunctions.Points[3].Y = (float) checked (L1ACheckList.RC1 + 12);
      PDFFunctions.gfx[L1ACheckList.k].DrawPolygon(PDFFunctions.polyGreen2, PDFFunctions.xBrush1, PDFFunctions.Points, PDFFunctions.Fill);
      XGraphics xgraphics441 = PDFFunctions.gfx[L1ACheckList.k];
      XFont arialFont10Bold162 = PDFFunctions.ArialFont10Bold;
      XSolidBrush white15 = XBrushes.White;
      double num872 = (double) checked (L1ACheckList.RC1 + 1);
      xunit = PDFFunctions.pages[L1ACheckList.k].Width;
      double point445 = ((XUnit) ref xunit).Point;
      xunit = PDFFunctions.pages[L1ACheckList.k].Height;
      double num873 = ((XUnit) ref xunit).Point / 2.0;
      XRect xrect441 = new XRect(25.0, num872, point445, num873);
      XStringFormat topLeft441 = XStringFormat.TopLeft;
      xgraphics441.DrawString("8 Mechanical ventilation", arialFont10Bold162, (XBrush) white15, xrect441, topLeft441);
      checked { L1ACheckList.RC1 += 15; }
      // ISSUE: reference to a compiler-generated field
      string mechVent = SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Ventilation.MechVent;
      // ISSUE: reference to a compiler-generated method
      switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(mechVent))
      {
        case 625191264:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(mechVent, "Balanced without heat recovery", false) == 0)
          {
            XGraphics xgraphics442 = PDFFunctions.gfx[L1ACheckList.k];
            XFont arialFont10_272 = PDFFunctions.ArialFont10;
            XSolidBrush black290 = XBrushes.Black;
            double num874 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point446 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num875 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect442 = new XRect(50.0, num874, point446, num875);
            XStringFormat topLeft442 = XStringFormat.TopLeft;
            xgraphics442.DrawString("Continuous supply and extract system without heat recovery", arialFont10_272, (XBrush) black290, xrect442, topLeft442);
            break;
          }
          break;
        case 918396964:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(mechVent, "Decentralised whole house extract", false) == 0)
          {
            XGraphics xgraphics443 = PDFFunctions.gfx[L1ACheckList.k];
            XFont arialFont10_273 = PDFFunctions.ArialFont10;
            XSolidBrush black291 = XBrushes.Black;
            double num876 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point447 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num877 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect443 = new XRect(50.0, num876, point447, num877);
            XStringFormat topLeft443 = XStringFormat.TopLeft;
            xgraphics443.DrawString("Continuous extract system (decentralised)", arialFont10_273, (XBrush) black291, xrect443, topLeft443);
            checked { L1ACheckList.RC1 += 13; }
            L1ACheckList.CheckCheckListRC1();
            string str129 = "";
            float num878;
            // ISSUE: reference to a compiler-generated field
            if ((double) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Ventilation.Decentralised.KTP1 != 0.0)
            {
              // ISSUE: reference to a compiler-generated field
              str129 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Ventilation.Decentralised.KSPF1);
              float num879;
              // ISSUE: reference to a compiler-generated field
              if ((double) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Ventilation.Decentralised.KSPF1 > (double) num879)
              {
                // ISSUE: reference to a compiler-generated field
                num878 = SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Ventilation.Decentralised.KSPF1;
              }
            }
            // ISSUE: reference to a compiler-generated field
            if ((double) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Ventilation.Decentralised.KTP2 != 0.0)
            {
              // ISSUE: reference to a compiler-generated field
              str129 = str129 + " " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Ventilation.Decentralised.KSPF2);
              // ISSUE: reference to a compiler-generated field
              if ((double) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Ventilation.Decentralised.KSPF2 > (double) num878)
              {
                // ISSUE: reference to a compiler-generated field
                num878 = SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Ventilation.Decentralised.KSPF2;
              }
            }
            // ISSUE: reference to a compiler-generated field
            if ((double) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Ventilation.Decentralised.KTP3 != 0.0)
            {
              // ISSUE: reference to a compiler-generated field
              str129 = str129 + " " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Ventilation.Decentralised.KSPF3);
              // ISSUE: reference to a compiler-generated field
              if ((double) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Ventilation.Decentralised.KSPF3 > (double) num878)
              {
                // ISSUE: reference to a compiler-generated field
                num878 = SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Ventilation.Decentralised.KSPF3;
              }
            }
            // ISSUE: reference to a compiler-generated field
            if ((double) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Ventilation.Decentralised.OTP1 != 0.0)
            {
              // ISSUE: reference to a compiler-generated field
              str129 = str129 + " " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Ventilation.Decentralised.OSPF1);
              // ISSUE: reference to a compiler-generated field
              if ((double) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Ventilation.Decentralised.OSPF1 > (double) num878)
              {
                // ISSUE: reference to a compiler-generated field
                num878 = SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Ventilation.Decentralised.OSPF1;
              }
            }
            // ISSUE: reference to a compiler-generated field
            if ((double) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Ventilation.Decentralised.OTP2 != 0.0)
            {
              // ISSUE: reference to a compiler-generated field
              str129 = str129 + " " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Ventilation.Decentralised.OSPF2);
              // ISSUE: reference to a compiler-generated field
              if ((double) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Ventilation.Decentralised.OSPF2 > (double) num878)
              {
                // ISSUE: reference to a compiler-generated field
                num878 = SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Ventilation.Decentralised.OSPF2;
              }
            }
            // ISSUE: reference to a compiler-generated field
            if ((double) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Ventilation.Decentralised.OTP3 != 0.0)
            {
              // ISSUE: reference to a compiler-generated field
              str129 = str129 + " " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Ventilation.Decentralised.OSPF3);
              // ISSUE: reference to a compiler-generated field
              if ((double) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Ventilation.Decentralised.OSPF3 > (double) num878)
              {
                // ISSUE: reference to a compiler-generated field
                num878 = SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Ventilation.Decentralised.OSPF3;
              }
            }
            string str130 = Microsoft.VisualBasic.Strings.Trim(str129);
            XGraphics xgraphics444 = PDFFunctions.gfx[L1ACheckList.k];
            XFont arialFont10_274 = PDFFunctions.ArialFont10;
            XSolidBrush black292 = XBrushes.Black;
            double num880 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point448 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num881 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect444 = new XRect(50.0, num880, point448, num881);
            XStringFormat topLeft444 = XStringFormat.TopLeft;
            xgraphics444.DrawString("Specific fan power: ", arialFont10_274, (XBrush) black292, xrect444, topLeft444);
            XGraphics xgraphics445 = PDFFunctions.gfx[L1ACheckList.k];
            string str131 = str130;
            XFont arialFont10_275 = PDFFunctions.ArialFont10;
            XSolidBrush black293 = XBrushes.Black;
            double num882 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point449 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num883 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect445 = new XRect(360.0, num882, point449, num883);
            XStringFormat topLeft445 = XStringFormat.TopLeft;
            xgraphics445.DrawString(str131, arialFont10_275, (XBrush) black293, xrect445, topLeft445);
            checked { L1ACheckList.RC1 += 13; }
            L1ACheckList.CheckCheckListRC1();
            XGraphics xgraphics446 = PDFFunctions.gfx[L1ACheckList.k];
            XFont arialFont10_276 = PDFFunctions.ArialFont10;
            XSolidBrush black294 = XBrushes.Black;
            double num884 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point450 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num885 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect446 = new XRect(50.0, num884, point450, num885);
            XStringFormat topLeft446 = XStringFormat.TopLeft;
            xgraphics446.DrawString("Maximum", arialFont10_276, (XBrush) black294, xrect446, topLeft446);
            XGraphics xgraphics447 = PDFFunctions.gfx[L1ACheckList.k];
            string str132 = Conversions.ToString(0.7);
            XFont arialFont10_277 = PDFFunctions.ArialFont10;
            XSolidBrush black295 = XBrushes.Black;
            double num886 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point451 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num887 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect447 = new XRect(360.0, num886, point451, num887);
            XStringFormat topLeft447 = XStringFormat.TopLeft;
            xgraphics447.DrawString(str132, arialFont10_277, (XBrush) black295, xrect447, topLeft447);
            if ((double) num878 < 0.7)
            {
              XGraphics xgraphics448 = PDFFunctions.gfx[L1ACheckList.k];
              XFont arialFont10Bold163 = PDFFunctions.ArialFont10Bold;
              XSolidBrush green = XBrushes.Green;
              double num888 = (double) checked (L1ACheckList.RC1 + 1);
              xunit = PDFFunctions.pages[L1ACheckList.k].Width;
              double point452 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[L1ACheckList.k].Height;
              double num889 = ((XUnit) ref xunit).Point / 2.0;
              XRect xrect448 = new XRect(540.0, num888, point452, num889);
              XStringFormat topLeft448 = XStringFormat.TopLeft;
              xgraphics448.DrawString("OK", arialFont10Bold163, (XBrush) green, xrect448, topLeft448);
              break;
            }
            XGraphics xgraphics449 = PDFFunctions.gfx[L1ACheckList.k];
            XFont arialFont10Bold164 = PDFFunctions.ArialFont10Bold;
            XSolidBrush red = XBrushes.Red;
            double num890 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point453 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num891 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect449 = new XRect(540.0, num890, point453, num891);
            XStringFormat topLeft449 = XStringFormat.TopLeft;
            xgraphics449.DrawString("Fail", arialFont10Bold164, (XBrush) red, xrect449, topLeft449);
            flag2 = true;
            break;
          }
          break;
        case 1101494137:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(mechVent, "Centralised whole house extract", false) == 0)
          {
            XGraphics xgraphics450 = PDFFunctions.gfx[L1ACheckList.k];
            XFont arialFont10_278 = PDFFunctions.ArialFont10;
            XSolidBrush black296 = XBrushes.Black;
            double num892 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point454 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num893 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect450 = new XRect(50.0, num892, point454, num893);
            XStringFormat topLeft450 = XStringFormat.TopLeft;
            xgraphics450.DrawString("Continuous extract system", arialFont10_278, (XBrush) black296, xrect450, topLeft450);
            checked { L1ACheckList.RC1 += 13; }
            // ISSUE: reference to a compiler-generated field
            string parameters = SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Ventilation.Parameters;
            float num894;
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(parameters, "Database", false) != 0)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(parameters, "SAP 2012", false) != 0)
              {
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(parameters, "User defined", false) == 0)
                {
                  // ISSUE: reference to a compiler-generated field
                  num894 = SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Ventilation.MVDetails.SFP;
                }
              }
              else
                num894 = 0.8f;
            }
            else
            {
              // ISSUE: reference to a compiler-generated method
              object obj = (object) SAP_Module.PCDFData.Products321s.Where<PCDF.Products321>(new Func<PCDF.Products321, bool>(closure260_2._Lambda\u0024__16)).SingleOrDefault<PCDF.Products321>();
              // ISSUE: reference to a compiler-generated method
              num894 = Conversions.ToSingle(SAP_Module.PCDFData.Products321s_Sub.Where<PCDF.Products321_Sub>(new Func<PCDF.Products321_Sub, bool>(closure260_2._Lambda\u0024__17)).ToList<PCDF.Products321_Sub>()[0].SFP);
            }
            XGraphics xgraphics451 = PDFFunctions.gfx[L1ACheckList.k];
            XFont arialFont10_279 = PDFFunctions.ArialFont10;
            XSolidBrush black297 = XBrushes.Black;
            double num895 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point455 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num896 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect451 = new XRect(50.0, num895, point455, num896);
            XStringFormat topLeft451 = XStringFormat.TopLeft;
            xgraphics451.DrawString("Specific fan power:", arialFont10_279, (XBrush) black297, xrect451, topLeft451);
            XGraphics xgraphics452 = PDFFunctions.gfx[L1ACheckList.k];
            string str133 = Conversions.ToString(num894);
            XFont arialFont10_280 = PDFFunctions.ArialFont10;
            XSolidBrush black298 = XBrushes.Black;
            double num897 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point456 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num898 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect452 = new XRect(360.0, num897, point456, num898);
            XStringFormat topLeft452 = XStringFormat.TopLeft;
            xgraphics452.DrawString(str133, arialFont10_280, (XBrush) black298, xrect452, topLeft452);
            checked { L1ACheckList.RC1 += 13; }
            L1ACheckList.CheckCheckListRC1();
            XGraphics xgraphics453 = PDFFunctions.gfx[L1ACheckList.k];
            XFont arialFont10_281 = PDFFunctions.ArialFont10;
            XSolidBrush black299 = XBrushes.Black;
            double num899 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point457 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num900 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect453 = new XRect(50.0, num899, point457, num900);
            XStringFormat topLeft453 = XStringFormat.TopLeft;
            xgraphics453.DrawString("Maximum", arialFont10_281, (XBrush) black299, xrect453, topLeft453);
            XGraphics xgraphics454 = PDFFunctions.gfx[L1ACheckList.k];
            string str134 = Conversions.ToString(0.7);
            XFont arialFont10_282 = PDFFunctions.ArialFont10;
            XSolidBrush black300 = XBrushes.Black;
            double num901 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point458 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num902 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect454 = new XRect(360.0, num901, point458, num902);
            XStringFormat topLeft454 = XStringFormat.TopLeft;
            xgraphics454.DrawString(str134, arialFont10_282, (XBrush) black300, xrect454, topLeft454);
            if ((double) num894 < 0.7)
            {
              XGraphics xgraphics455 = PDFFunctions.gfx[L1ACheckList.k];
              XFont arialFont10Bold165 = PDFFunctions.ArialFont10Bold;
              XSolidBrush green = XBrushes.Green;
              double num903 = (double) checked (L1ACheckList.RC1 + 1);
              xunit = PDFFunctions.pages[L1ACheckList.k].Width;
              double point459 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[L1ACheckList.k].Height;
              double num904 = ((XUnit) ref xunit).Point / 2.0;
              XRect xrect455 = new XRect(540.0, num903, point459, num904);
              XStringFormat topLeft455 = XStringFormat.TopLeft;
              xgraphics455.DrawString("OK", arialFont10Bold165, (XBrush) green, xrect455, topLeft455);
              break;
            }
            XGraphics xgraphics456 = PDFFunctions.gfx[L1ACheckList.k];
            XFont arialFont10Bold166 = PDFFunctions.ArialFont10Bold;
            XSolidBrush red = XBrushes.Red;
            double num905 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point460 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num906 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect456 = new XRect(540.0, num905, point460, num906);
            XStringFormat topLeft456 = XStringFormat.TopLeft;
            xgraphics456.DrawString("Fail", arialFont10Bold166, (XBrush) red, xrect456, topLeft456);
            flag2 = true;
            break;
          }
          break;
        case 2533751361:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(mechVent, "Positive input from loft", false) == 0)
          {
            XGraphics xgraphics457 = PDFFunctions.gfx[L1ACheckList.k];
            XFont arialFont10_283 = PDFFunctions.ArialFont10;
            XSolidBrush black301 = XBrushes.Black;
            double num907 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point461 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num908 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect457 = new XRect(50.0, num907, point461, num908);
            XStringFormat topLeft457 = XStringFormat.TopLeft;
            xgraphics457.DrawString("Not applicable", arialFont10_283, (XBrush) black301, xrect457, topLeft457);
            break;
          }
          break;
        case 3225008057:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(mechVent, "Positive input from outside", false) == 0)
          {
            XGraphics xgraphics458 = PDFFunctions.gfx[L1ACheckList.k];
            XFont arialFont10_284 = PDFFunctions.ArialFont10;
            XSolidBrush black302 = XBrushes.Black;
            double num909 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point462 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num910 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect458 = new XRect(50.0, num909, point462, num910);
            XStringFormat topLeft458 = XStringFormat.TopLeft;
            xgraphics458.DrawString("Continuous supply system:", arialFont10_284, (XBrush) black302, xrect458, topLeft458);
            checked { L1ACheckList.RC1 += 13; }
            // ISSUE: reference to a compiler-generated field
            string parameters = SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Ventilation.Parameters;
            float num911;
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(parameters, "Database", false) != 0)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(parameters, "SAP 2012", false) != 0)
              {
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(parameters, "User defined", false) == 0)
                {
                  // ISSUE: reference to a compiler-generated field
                  num911 = SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Ventilation.MVDetails.SFP;
                }
              }
              else
                num911 = 0.8f;
            }
            else
            {
              // ISSUE: reference to a compiler-generated method
              object obj = (object) SAP_Module.PCDFData.Products321s.Where<PCDF.Products321>(new Func<PCDF.Products321, bool>(closure260_2._Lambda\u0024__11)).SingleOrDefault<PCDF.Products321>();
              // ISSUE: reference to a compiler-generated method
              num911 = Conversions.ToSingle(SAP_Module.PCDFData.Products321s_Sub.Where<PCDF.Products321_Sub>(new Func<PCDF.Products321_Sub, bool>(closure260_2._Lambda\u0024__12)).ToList<PCDF.Products321_Sub>()[0].SFP);
            }
            XGraphics xgraphics459 = PDFFunctions.gfx[L1ACheckList.k];
            XFont arialFont10_285 = PDFFunctions.ArialFont10;
            XSolidBrush black303 = XBrushes.Black;
            double num912 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point463 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num913 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect459 = new XRect(50.0, num912, point463, num913);
            XStringFormat topLeft459 = XStringFormat.TopLeft;
            xgraphics459.DrawString("Specific fan power:", arialFont10_285, (XBrush) black303, xrect459, topLeft459);
            XGraphics xgraphics460 = PDFFunctions.gfx[L1ACheckList.k];
            string str135 = Conversions.ToString(num911);
            XFont arialFont10_286 = PDFFunctions.ArialFont10;
            XSolidBrush black304 = XBrushes.Black;
            double num914 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point464 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num915 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect460 = new XRect(360.0, num914, point464, num915);
            XStringFormat topLeft460 = XStringFormat.TopLeft;
            xgraphics460.DrawString(str135, arialFont10_286, (XBrush) black304, xrect460, topLeft460);
            checked { L1ACheckList.RC1 += 13; }
            XGraphics xgraphics461 = PDFFunctions.gfx[L1ACheckList.k];
            XFont arialFont10_287 = PDFFunctions.ArialFont10;
            XSolidBrush black305 = XBrushes.Black;
            double num916 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point465 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num917 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect461 = new XRect(50.0, num916, point465, num917);
            XStringFormat topLeft461 = XStringFormat.TopLeft;
            xgraphics461.DrawString("Maximum", arialFont10_287, (XBrush) black305, xrect461, topLeft461);
            XGraphics xgraphics462 = PDFFunctions.gfx[L1ACheckList.k];
            XFont arialFont10_288 = PDFFunctions.ArialFont10;
            XSolidBrush black306 = XBrushes.Black;
            double num918 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point466 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num919 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect462 = new XRect(360.0, num918, point466, num919);
            XStringFormat topLeft462 = XStringFormat.TopLeft;
            xgraphics462.DrawString("0.5", arialFont10_288, (XBrush) black306, xrect462, topLeft462);
            if ((double) num911 < 0.5)
            {
              XGraphics xgraphics463 = PDFFunctions.gfx[L1ACheckList.k];
              XFont arialFont10Bold167 = PDFFunctions.ArialFont10Bold;
              XSolidBrush green = XBrushes.Green;
              double num920 = (double) checked (L1ACheckList.RC1 + 1);
              xunit = PDFFunctions.pages[L1ACheckList.k].Width;
              double point467 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[L1ACheckList.k].Height;
              double num921 = ((XUnit) ref xunit).Point / 2.0;
              XRect xrect463 = new XRect(540.0, num920, point467, num921);
              XStringFormat topLeft463 = XStringFormat.TopLeft;
              xgraphics463.DrawString("OK", arialFont10Bold167, (XBrush) green, xrect463, topLeft463);
            }
            else
            {
              XGraphics xgraphics464 = PDFFunctions.gfx[L1ACheckList.k];
              XFont arialFont10Bold168 = PDFFunctions.ArialFont10Bold;
              XSolidBrush red = XBrushes.Red;
              double num922 = (double) checked (L1ACheckList.RC1 + 1);
              xunit = PDFFunctions.pages[L1ACheckList.k].Width;
              double point468 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[L1ACheckList.k].Height;
              double num923 = ((XUnit) ref xunit).Point / 2.0;
              XRect xrect464 = new XRect(540.0, num922, point468, num923);
              XStringFormat topLeft464 = XStringFormat.TopLeft;
              xgraphics464.DrawString("Fail", arialFont10Bold168, (XBrush) red, xrect464, topLeft464);
              flag2 = true;
            }
            checked { L1ACheckList.RC1 += 13; }
            break;
          }
          break;
        case 3236691049:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(mechVent, "Natural ventilation", false) == 0)
          {
            XGraphics xgraphics465 = PDFFunctions.gfx[L1ACheckList.k];
            XFont arialFont10_289 = PDFFunctions.ArialFont10;
            XSolidBrush black307 = XBrushes.Black;
            double num924 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point469 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num925 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect465 = new XRect(50.0, num924, point469, num925);
            XStringFormat topLeft465 = XStringFormat.TopLeft;
            xgraphics465.DrawString("Not applicable", arialFont10_289, (XBrush) black307, xrect465, topLeft465);
            break;
          }
          break;
        case 3255421954:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(mechVent, "Balanced with heat recovery", false) == 0)
          {
            XGraphics xgraphics466 = PDFFunctions.gfx[L1ACheckList.k];
            XFont arialFont10_290 = PDFFunctions.ArialFont10;
            XSolidBrush black308 = XBrushes.Black;
            double num926 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point470 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num927 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect466 = new XRect(50.0, num926, point470, num927);
            XStringFormat topLeft466 = XStringFormat.TopLeft;
            xgraphics466.DrawString("Continuous supply and extract system", arialFont10_290, (XBrush) black308, xrect466, topLeft466);
            checked { L1ACheckList.RC1 += 13; }
            L1ACheckList.CheckCheckListRC1();
            XGraphics xgraphics467 = PDFFunctions.gfx[L1ACheckList.k];
            XFont arialFont10_291 = PDFFunctions.ArialFont10;
            XSolidBrush black309 = XBrushes.Black;
            double num928 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point471 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num929 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect467 = new XRect(50.0, num928, point471, num929);
            XStringFormat topLeft467 = XStringFormat.TopLeft;
            xgraphics467.DrawString("Specific fan power:", arialFont10_291, (XBrush) black309, xrect467, topLeft467);
            // ISSUE: reference to a compiler-generated field
            string parameters = SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Ventilation.Parameters;
            float num930;
            float num931;
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(parameters, "Database", false) != 0)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(parameters, "SAP 2012", false) != 0)
              {
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(parameters, "User defined", false) == 0)
                {
                  // ISSUE: reference to a compiler-generated field
                  num930 = SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Ventilation.MVDetails.SFP;
                  // ISSUE: reference to a compiler-generated field
                  num931 = SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Ventilation.MVDetails.HEE;
                }
              }
              else
              {
                num930 = 2f;
                num931 = 66f;
              }
            }
            else
            {
              // ISSUE: reference to a compiler-generated method
              L1ACheckList.SubVent = (object) SAP_Module.PCDFData.Products321s.Where<PCDF.Products321>(new Func<PCDF.Products321, bool>(closure260_2._Lambda\u0024__13)).SingleOrDefault<PCDF.Products321>();
              // ISSUE: reference to a compiler-generated method
              List<PCDF.Products321_Sub> list = SAP_Module.PCDFData.Products321s_Sub.Where<PCDF.Products321_Sub>(new Func<PCDF.Products321_Sub, bool>(closure260_2._Lambda\u0024__14)).ToList<PCDF.Products321_Sub>();
              if (L1ACheckList.SubVent == null)
              {
                // ISSUE: reference to a compiler-generated method
                L1ACheckList.SubVent = (object) SAP_Module.PCDFData.Products322s.Where<PCDF.Products322>(new Func<PCDF.Products322, bool>(closure260_2._Lambda\u0024__15)).SingleOrDefault<PCDF.Products322>();
              }
              num930 = Conversions.ToSingle(list[0].SFP);
              num931 = Conversions.ToSingle(list[0].HeatExchangerEfficiency);
            }
            XGraphics xgraphics468 = PDFFunctions.gfx[L1ACheckList.k];
            string str136 = Conversions.ToString(num930);
            XFont arialFont10_292 = PDFFunctions.ArialFont10;
            XSolidBrush black310 = XBrushes.Black;
            double num932 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point472 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num933 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect468 = new XRect(360.0, num932, point472, num933);
            XStringFormat topLeft468 = XStringFormat.TopLeft;
            xgraphics468.DrawString(str136, arialFont10_292, (XBrush) black310, xrect468, topLeft468);
            checked { L1ACheckList.RC1 += 13; }
            L1ACheckList.CheckCheckListRC1();
            XGraphics xgraphics469 = PDFFunctions.gfx[L1ACheckList.k];
            XFont arialFont10_293 = PDFFunctions.ArialFont10;
            XSolidBrush black311 = XBrushes.Black;
            double num934 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point473 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num935 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect469 = new XRect(50.0, num934, point473, num935);
            XStringFormat topLeft469 = XStringFormat.TopLeft;
            xgraphics469.DrawString("Maximum", arialFont10_293, (XBrush) black311, xrect469, topLeft469);
            XGraphics xgraphics470 = PDFFunctions.gfx[L1ACheckList.k];
            XFont arialFont10_294 = PDFFunctions.ArialFont10;
            XSolidBrush black312 = XBrushes.Black;
            double num936 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point474 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num937 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect470 = new XRect(360.0, num936, point474, num937);
            XStringFormat topLeft470 = XStringFormat.TopLeft;
            xgraphics470.DrawString("1.5", arialFont10_294, (XBrush) black312, xrect470, topLeft470);
            if ((double) num930 <= 1.5)
            {
              XGraphics xgraphics471 = PDFFunctions.gfx[L1ACheckList.k];
              XFont arialFont10Bold169 = PDFFunctions.ArialFont10Bold;
              XSolidBrush green = XBrushes.Green;
              double num938 = (double) checked (L1ACheckList.RC1 + 1);
              xunit = PDFFunctions.pages[L1ACheckList.k].Width;
              double point475 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[L1ACheckList.k].Height;
              double num939 = ((XUnit) ref xunit).Point / 2.0;
              XRect xrect471 = new XRect(540.0, num938, point475, num939);
              XStringFormat topLeft471 = XStringFormat.TopLeft;
              xgraphics471.DrawString("OK", arialFont10Bold169, (XBrush) green, xrect471, topLeft471);
            }
            else
            {
              XGraphics xgraphics472 = PDFFunctions.gfx[L1ACheckList.k];
              XFont arialFont10Bold170 = PDFFunctions.ArialFont10Bold;
              XSolidBrush red = XBrushes.Red;
              double num940 = (double) checked (L1ACheckList.RC1 + 1);
              xunit = PDFFunctions.pages[L1ACheckList.k].Width;
              double point476 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[L1ACheckList.k].Height;
              double num941 = ((XUnit) ref xunit).Point / 2.0;
              XRect xrect472 = new XRect(540.0, num940, point476, num941);
              XStringFormat topLeft472 = XStringFormat.TopLeft;
              xgraphics472.DrawString("Fail", arialFont10Bold170, (XBrush) red, xrect472, topLeft472);
              flag2 = true;
            }
            checked { L1ACheckList.RC1 += 13; }
            L1ACheckList.CheckCheckListRC1();
            XGraphics xgraphics473 = PDFFunctions.gfx[L1ACheckList.k];
            XFont arialFont10_295 = PDFFunctions.ArialFont10;
            XSolidBrush black313 = XBrushes.Black;
            double num942 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point477 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num943 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect473 = new XRect(50.0, num942, point477, num943);
            XStringFormat topLeft473 = XStringFormat.TopLeft;
            xgraphics473.DrawString("MVHR efficiency: ", arialFont10_295, (XBrush) black313, xrect473, topLeft473);
            XGraphics xgraphics474 = PDFFunctions.gfx[L1ACheckList.k];
            string str137 = Conversions.ToString(num931) + "%";
            XFont arialFont10_296 = PDFFunctions.ArialFont10;
            XSolidBrush black314 = XBrushes.Black;
            double num944 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point478 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num945 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect474 = new XRect(360.0, num944, point478, num945);
            XStringFormat topLeft474 = XStringFormat.TopLeft;
            xgraphics474.DrawString(str137, arialFont10_296, (XBrush) black314, xrect474, topLeft474);
            checked { L1ACheckList.RC1 += 13; }
            L1ACheckList.CheckCheckListRC1();
            XGraphics xgraphics475 = PDFFunctions.gfx[L1ACheckList.k];
            XFont arialFont10_297 = PDFFunctions.ArialFont10;
            XSolidBrush black315 = XBrushes.Black;
            double num946 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point479 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num947 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect475 = new XRect(50.0, num946, point479, num947);
            XStringFormat topLeft475 = XStringFormat.TopLeft;
            xgraphics475.DrawString("Minimum", arialFont10_297, (XBrush) black315, xrect475, topLeft475);
            XGraphics xgraphics476 = PDFFunctions.gfx[L1ACheckList.k];
            XFont arialFont10_298 = PDFFunctions.ArialFont10;
            XSolidBrush black316 = XBrushes.Black;
            double num948 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point480 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num949 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect476 = new XRect(360.0, num948, point480, num949);
            XStringFormat topLeft476 = XStringFormat.TopLeft;
            xgraphics476.DrawString("70%", arialFont10_298, (XBrush) black316, xrect476, topLeft476);
            if ((double) num930 <= 1.5 & (double) num931 > 69.0)
            {
              XGraphics xgraphics477 = PDFFunctions.gfx[L1ACheckList.k];
              XFont arialFont10Bold171 = PDFFunctions.ArialFont10Bold;
              XSolidBrush green = XBrushes.Green;
              double num950 = (double) checked (L1ACheckList.RC1 + 1);
              xunit = PDFFunctions.pages[L1ACheckList.k].Width;
              double point481 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[L1ACheckList.k].Height;
              double num951 = ((XUnit) ref xunit).Point / 2.0;
              XRect xrect477 = new XRect(540.0, num950, point481, num951);
              XStringFormat topLeft477 = XStringFormat.TopLeft;
              xgraphics477.DrawString("OK", arialFont10Bold171, (XBrush) green, xrect477, topLeft477);
              break;
            }
            XGraphics xgraphics478 = PDFFunctions.gfx[L1ACheckList.k];
            XFont arialFont10Bold172 = PDFFunctions.ArialFont10Bold;
            XSolidBrush red1 = XBrushes.Red;
            double num952 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point482 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num953 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect478 = new XRect(540.0, num952, point482, num953);
            XStringFormat topLeft478 = XStringFormat.TopLeft;
            xgraphics478.DrawString("Fail", arialFont10Bold172, (XBrush) red1, xrect478, topLeft478);
            flag2 = true;
            break;
          }
          break;
      }
      checked { L1ACheckList.RC1 += 15; }
      L1ACheckList.CheckCheckListRC1();
      PDFFunctions.xBrush1 = XBrush.op_Implicit((Brush) new SolidBrush(Color.FromArgb(159, 172, 62)));
      PDFFunctions.Points[0].X = 20f;
      PDFFunctions.Points[0].Y = (float) L1ACheckList.RC1;
      ref PointF local27 = ref PDFFunctions.Points[1];
      xunit = PDFFunctions.pages[L1ACheckList.k].Width;
      double num954 = ((XUnit) ref xunit).Point - 20.0;
      local27.X = (float) num954;
      PDFFunctions.Points[1].Y = (float) L1ACheckList.RC1;
      ref PointF local28 = ref PDFFunctions.Points[2];
      xunit = PDFFunctions.pages[L1ACheckList.k].Width;
      double num955 = ((XUnit) ref xunit).Point - 20.0;
      local28.X = (float) num955;
      PDFFunctions.Points[2].Y = (float) checked (L1ACheckList.RC1 + 12);
      PDFFunctions.Points[3].X = 20f;
      PDFFunctions.Points[3].Y = (float) checked (L1ACheckList.RC1 + 12);
      PDFFunctions.gfx[L1ACheckList.k].DrawPolygon(PDFFunctions.polyGreen2, PDFFunctions.xBrush1, PDFFunctions.Points, PDFFunctions.Fill);
      XGraphics xgraphics479 = PDFFunctions.gfx[L1ACheckList.k];
      XFont arialFont10Bold173 = PDFFunctions.ArialFont10Bold;
      XSolidBrush white16 = XBrushes.White;
      double num956 = (double) checked (L1ACheckList.RC1 + 1);
      xunit = PDFFunctions.pages[L1ACheckList.k].Width;
      double point483 = ((XUnit) ref xunit).Point;
      xunit = PDFFunctions.pages[L1ACheckList.k].Height;
      double num957 = ((XUnit) ref xunit).Point / 2.0;
      XRect xrect479 = new XRect(25.0, num956, point483, num957);
      XStringFormat topLeft479 = XStringFormat.TopLeft;
      xgraphics479.DrawString("9 Summertime temperature", arialFont10Bold173, (XBrush) white16, xrect479, topLeft479);
      checked { L1ACheckList.RC1 += 15; }
      XGraphics xgraphics480 = PDFFunctions.gfx[L1ACheckList.k];
      // ISSUE: reference to a compiler-generated field
      string str138 = "Overheating risk (" + SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Location + "):";
      XFont arialFont10_299 = PDFFunctions.ArialFont10;
      XSolidBrush black317 = XBrushes.Black;
      double num958 = (double) checked (L1ACheckList.RC1 + 1);
      xunit = PDFFunctions.pages[L1ACheckList.k].Width;
      double point484 = ((XUnit) ref xunit).Point;
      xunit = PDFFunctions.pages[L1ACheckList.k].Height;
      double num959 = ((XUnit) ref xunit).Point / 2.0;
      XRect xrect480 = new XRect(50.0, num958, point484, num959);
      XStringFormat topLeft480 = XStringFormat.TopLeft;
      xgraphics480.DrawString(str138, arialFont10_299, (XBrush) black317, xrect480, topLeft480);
      // ISSUE: reference to a compiler-generated field
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Overheat, "Yes", false) == 0)
      {
        if (SAP_Module.OverHeat.AppendixP.Likelihood != null)
        {
          XGraphics xgraphics481 = PDFFunctions.gfx[L1ACheckList.k];
          string likelihood = SAP_Module.OverHeat.AppendixP.Likelihood;
          XFont arialFont10_300 = PDFFunctions.ArialFont10;
          XSolidBrush black318 = XBrushes.Black;
          double num960 = (double) checked (L1ACheckList.RC1 + 1);
          xunit = PDFFunctions.pages[L1ACheckList.k].Width;
          double point485 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[L1ACheckList.k].Height;
          double num961 = ((XUnit) ref xunit).Point / 2.0;
          XRect xrect481 = new XRect(360.0, num960, point485, num961);
          XStringFormat topLeft481 = XStringFormat.TopLeft;
          xgraphics481.DrawString(likelihood, arialFont10_300, (XBrush) black318, xrect481, topLeft481);
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.OverHeat.AppendixP.Likelihood, "High", false) == 0)
          {
            XGraphics xgraphics482 = PDFFunctions.gfx[L1ACheckList.k];
            XFont arialFont10Bold174 = PDFFunctions.ArialFont10Bold;
            XSolidBrush red = XBrushes.Red;
            double num962 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point486 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num963 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect482 = new XRect(540.0, num962, point486, num963);
            XStringFormat topLeft482 = XStringFormat.TopLeft;
            xgraphics482.DrawString("Fail", arialFont10Bold174, (XBrush) red, xrect482, topLeft482);
            flag2 = true;
          }
          else
          {
            XGraphics xgraphics483 = PDFFunctions.gfx[L1ACheckList.k];
            XFont arialFont10Bold175 = PDFFunctions.ArialFont10Bold;
            XSolidBrush green = XBrushes.Green;
            double num964 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point487 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num965 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect483 = new XRect(540.0, num964, point487, num965);
            XStringFormat topLeft483 = XStringFormat.TopLeft;
            xgraphics483.DrawString("OK", arialFont10Bold175, (XBrush) green, xrect483, topLeft483);
          }
        }
        checked { L1ACheckList.RC1 += 13; }
        L1ACheckList.CheckCheckListRC1();
        XGraphics xgraphics484 = PDFFunctions.gfx[L1ACheckList.k];
        XFont arialFont10_301 = PDFFunctions.ArialFont10;
        XSolidBrush black319 = XBrushes.Black;
        double num966 = (double) checked (L1ACheckList.RC1 + 1);
        xunit = PDFFunctions.pages[L1ACheckList.k].Width;
        double point488 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[L1ACheckList.k].Height;
        double num967 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect484 = new XRect(20.0, num966, point488, num967);
        XStringFormat topLeft484 = XStringFormat.TopLeft;
        xgraphics484.DrawString("Based on:", arialFont10_301, (XBrush) black319, xrect484, topLeft484);
        checked { L1ACheckList.RC1 += 13; }
        L1ACheckList.CheckCheckListRC1();
        XGraphics xgraphics485 = PDFFunctions.gfx[L1ACheckList.k];
        XFont arialFont10_302 = PDFFunctions.ArialFont10;
        XSolidBrush black320 = XBrushes.Black;
        double num968 = (double) checked (L1ACheckList.RC1 + 1);
        xunit = PDFFunctions.pages[L1ACheckList.k].Width;
        double point489 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[L1ACheckList.k].Height;
        double num969 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect485 = new XRect(50.0, num968, point489, num969);
        XStringFormat topLeft485 = XStringFormat.TopLeft;
        xgraphics485.DrawString("Overshading:", arialFont10_302, (XBrush) black320, xrect485, topLeft485);
        XGraphics xgraphics486 = PDFFunctions.gfx[L1ACheckList.k];
        // ISSUE: reference to a compiler-generated field
        string overshading = SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Overshading;
        XFont arialFont10_303 = PDFFunctions.ArialFont10;
        XSolidBrush black321 = XBrushes.Black;
        double num970 = (double) checked (L1ACheckList.RC1 + 1);
        xunit = PDFFunctions.pages[L1ACheckList.k].Width;
        double point490 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[L1ACheckList.k].Height;
        double num971 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect486 = new XRect(360.0, num970, point490, num971);
        XStringFormat topLeft486 = XStringFormat.TopLeft;
        xgraphics486.DrawString(overshading, arialFont10_303, (XBrush) black321, xrect486, topLeft486);
        checked { L1ACheckList.RC1 += 13; }
        L1ACheckList.CheckCheckListRC1();
        string str139 = "";
        // ISSUE: reference to a compiler-generated field
        int num972 = checked (SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].NoofWindows - 1);
        int index1 = 0;
        while (index1 <= num972)
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          if ((double) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Windows[index1].OverhangDepth > 0.0 && (double) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Windows[index1].Width * 2.0 <= (double) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Windows[index1].OverhangWidth)
          {
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            str139 = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Windows[index1].CurtainType, "None", false) == 0 ? "No overhang" : SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Windows[index1].CurtainType;
            // ISSUE: reference to a compiler-generated field
            if ((double) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Windows[index1].Height > 0.0)
            {
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              str139 = str139 + " " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Windows[index1].OverhangDepth / SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Windows[index1].Height);
            }
          }
          XGraphics xgraphics487 = PDFFunctions.gfx[L1ACheckList.k];
          // ISSUE: reference to a compiler-generated field
          string str140 = "Windows facing: " + SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Windows[index1].Orientation;
          XFont arialFont10_304 = PDFFunctions.ArialFont10;
          XSolidBrush black322 = XBrushes.Black;
          double num973 = (double) checked (L1ACheckList.RC1 + 1);
          xunit = PDFFunctions.pages[L1ACheckList.k].Width;
          double point491 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[L1ACheckList.k].Height;
          double num974 = ((XUnit) ref xunit).Point / 2.0;
          XRect xrect487 = new XRect(50.0, num973, point491, num974);
          XStringFormat topLeft487 = XStringFormat.TopLeft;
          xgraphics487.DrawString(str140, arialFont10_304, (XBrush) black322, xrect487, topLeft487);
          XGraphics xgraphics488 = PDFFunctions.gfx[L1ACheckList.k];
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          string str141 = Conversions.ToString(Math.Round((double) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Windows[index1].Area * (double) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Windows[index1].Count, 2)) + "m\u00B2  " + str139;
          XFont arialFont8 = PDFFunctions.ArialFont8;
          XSolidBrush black323 = XBrushes.Black;
          double num975 = (double) checked (L1ACheckList.RC1 + 1);
          xunit = PDFFunctions.pages[L1ACheckList.k].Width;
          double point492 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[L1ACheckList.k].Height;
          double num976 = ((XUnit) ref xunit).Point / 2.0;
          XRect xrect488 = new XRect(360.0, num975, point492, num976);
          XStringFormat topLeft488 = XStringFormat.TopLeft;
          xgraphics488.DrawString(str141, arialFont8, (XBrush) black323, xrect488, topLeft488);
          checked { L1ACheckList.RC1 += 13; }
          str139 = "";
          L1ACheckList.CheckCheckListRC1();
          checked { ++index1; }
        }
        // ISSUE: reference to a compiler-generated field
        int num977 = checked (SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].NoofRoofLights - 1);
        int index2 = 0;
        while (index2 <= num977)
        {
          XGraphics xgraphics489 = PDFFunctions.gfx[L1ACheckList.k];
          // ISSUE: reference to a compiler-generated field
          string str142 = "Roof windows facing: " + SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].RoofLights[index2].Orientation;
          XFont arialFont10_305 = PDFFunctions.ArialFont10;
          XSolidBrush black324 = XBrushes.Black;
          double num978 = (double) checked (L1ACheckList.RC1 + 1);
          xunit = PDFFunctions.pages[L1ACheckList.k].Width;
          double point493 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[L1ACheckList.k].Height;
          double num979 = ((XUnit) ref xunit).Point / 2.0;
          XRect xrect489 = new XRect(50.0, num978, point493, num979);
          XStringFormat topLeft489 = XStringFormat.TopLeft;
          xgraphics489.DrawString(str142, arialFont10_305, (XBrush) black324, xrect489, topLeft489);
          XGraphics xgraphics490 = PDFFunctions.gfx[L1ACheckList.k];
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          string str143 = Conversions.ToString(Math.Round((double) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].RoofLights[index2].Area * (double) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].RoofLights[index2].Count, 2)) + "m\u00B2";
          XFont arialFont8 = PDFFunctions.ArialFont8;
          XSolidBrush black325 = XBrushes.Black;
          double num980 = (double) checked (L1ACheckList.RC1 + 1);
          xunit = PDFFunctions.pages[L1ACheckList.k].Width;
          double point494 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[L1ACheckList.k].Height;
          double num981 = ((XUnit) ref xunit).Point / 2.0;
          XRect xrect490 = new XRect(360.0, num980, point494, num981);
          XStringFormat topLeft490 = XStringFormat.TopLeft;
          xgraphics490.DrawString(str143, arialFont8, (XBrush) black325, xrect490, topLeft490);
          checked { L1ACheckList.RC1 += 13; }
          L1ACheckList.CheckCheckListRC1();
          checked { ++index2; }
        }
        XGraphics xgraphics491 = PDFFunctions.gfx[L1ACheckList.k];
        XFont arialFont10_306 = PDFFunctions.ArialFont10;
        XSolidBrush black326 = XBrushes.Black;
        double num982 = (double) checked (L1ACheckList.RC1 + 1);
        xunit = PDFFunctions.pages[L1ACheckList.k].Width;
        double point495 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[L1ACheckList.k].Height;
        double num983 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect491 = new XRect(50.0, num982, point495, num983);
        XStringFormat topLeft491 = XStringFormat.TopLeft;
        xgraphics491.DrawString("Ventilation rate:", arialFont10_306, (XBrush) black326, xrect491, topLeft491);
        XGraphics xgraphics492 = PDFFunctions.gfx[L1ACheckList.k];
        // ISSUE: reference to a compiler-generated field
        string str144 = Microsoft.VisualBasic.Strings.Format((object) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].OverHeating.EACAirChange, "0.00");
        XFont arialFont10_307 = PDFFunctions.ArialFont10;
        XSolidBrush black327 = XBrushes.Black;
        double num984 = (double) checked (L1ACheckList.RC1 + 1);
        xunit = PDFFunctions.pages[L1ACheckList.k].Width;
        double point496 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[L1ACheckList.k].Height;
        double num985 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect492 = new XRect(360.0, num984, point496, num985);
        XStringFormat topLeft492 = XStringFormat.TopLeft;
        xgraphics492.DrawString(str144, arialFont10_307, (XBrush) black327, xrect492, topLeft492);
        checked { L1ACheckList.RC1 += 13; }
        L1ACheckList.CheckCheckListRC1();
        bool flag8 = false;
        // ISSUE: reference to a compiler-generated field
        if (SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].NoofWindows > 0)
        {
          // ISSUE: reference to a compiler-generated field
          int num986 = checked (SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].NoofWindows - 1);
          int index3 = 0;
          while (index3 <= num986)
          {
            // ISSUE: reference to a compiler-generated field
            if (!string.IsNullOrEmpty(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Windows[index3].CurtainType))
              flag8 = true;
            checked { ++index3; }
          }
          if (flag8)
          {
            XGraphics xgraphics493 = PDFFunctions.gfx[L1ACheckList.k];
            XFont arialFont10_308 = PDFFunctions.ArialFont10;
            XSolidBrush black328 = XBrushes.Black;
            double num987 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point497 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num988 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect493 = new XRect(50.0, num987, point497, num988);
            XStringFormat topLeft493 = XStringFormat.TopLeft;
            xgraphics493.DrawString("Blinds/curtains:", arialFont10_308, (XBrush) black328, xrect493, topLeft493);
            XGraphics xgraphics494 = PDFFunctions.gfx[L1ACheckList.k];
            // ISSUE: reference to a compiler-generated field
            string curtainType = SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Windows[0].CurtainType;
            XFont arialFont10_309 = PDFFunctions.ArialFont10;
            XSolidBrush black329 = XBrushes.Black;
            double num989 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point498 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num990 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect494 = new XRect(360.0, num989, point498, num990);
            XStringFormat topLeft494 = XStringFormat.TopLeft;
            xgraphics494.DrawString(curtainType, arialFont10_309, (XBrush) black329, xrect494, topLeft494);
            checked { L1ACheckList.RC1 += 13; }
            L1ACheckList.CheckCheckListRC1();
          }
        }
        // ISSUE: reference to a compiler-generated field
        if (flag8 && SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].NoofWindows > 0)
        {
          // ISSUE: reference to a compiler-generated field
          int num991 = checked (SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].NoofWindows - 1);
          int index4 = 0;
          double Expression6;
          while (index4 <= num991)
          {
            double area;
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            if ((double) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Windows[index4].Area > area & (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Windows[index4].CurtainType, "None", false) > 0U)
            {
              // ISSUE: reference to a compiler-generated field
              area = (double) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Windows[index4].Area;
              // ISSUE: reference to a compiler-generated field
              Expression6 = (double) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Windows[index4].FractionClosed * 100.0;
            }
            checked { ++index4; }
          }
          if (Expression6 > 0.0)
          {
            XGraphics xgraphics495 = PDFFunctions.gfx[L1ACheckList.k];
            string str145 = "Closed " + Microsoft.VisualBasic.Strings.Format((object) Expression6, Conversions.ToString(0)) + "% of daylight hours";
            XFont arialFont10_310 = PDFFunctions.ArialFont10;
            XSolidBrush black330 = XBrushes.Black;
            double num992 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point499 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num993 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect495 = new XRect(360.0, num992, point499, num993);
            XStringFormat topLeft495 = XStringFormat.TopLeft;
            xgraphics495.DrawString(str145, arialFont10_310, (XBrush) black330, xrect495, topLeft495);
            checked { L1ACheckList.RC1 += 13; }
          }
          L1ACheckList.CheckCheckListRC1();
        }
      }
      else
      {
        XGraphics xgraphics496 = PDFFunctions.gfx[L1ACheckList.k];
        XFont arialFont10_311 = PDFFunctions.ArialFont10;
        XSolidBrush black331 = XBrushes.Black;
        double num994 = (double) checked (L1ACheckList.RC1 + 1);
        xunit = PDFFunctions.pages[L1ACheckList.k].Width;
        double point500 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[L1ACheckList.k].Height;
        double num995 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect496 = new XRect(360.0, num994, point500, num995);
        XStringFormat topLeft496 = XStringFormat.TopLeft;
        xgraphics496.DrawString("Not assessed", arialFont10_311, (XBrush) black331, xrect496, topLeft496);
        XGraphics xgraphics497 = PDFFunctions.gfx[L1ACheckList.k];
        XFont arialFont10Bold176 = PDFFunctions.ArialFont10Bold;
        XSolidBrush blue = XBrushes.Blue;
        double num996 = (double) checked (L1ACheckList.RC1 + 1);
        xunit = PDFFunctions.pages[L1ACheckList.k].Width;
        double point501 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[L1ACheckList.k].Height;
        double num997 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect497 = new XRect(540.0, num996, point501, num997);
        XStringFormat topLeft497 = XStringFormat.TopLeft;
        xgraphics497.DrawString("?", arialFont10Bold176, (XBrush) blue, xrect497, topLeft497);
      }
      checked { L1ACheckList.RC1 += 15; }
      L1ACheckList.CheckCheckListRC1();
      PDFFunctions.xBrush1 = XBrush.op_Implicit((Brush) new SolidBrush(Color.FromArgb(159, 172, 62)));
      PDFFunctions.Points[0].X = 20f;
      PDFFunctions.Points[0].Y = (float) L1ACheckList.RC1;
      ref PointF local29 = ref PDFFunctions.Points[1];
      xunit = PDFFunctions.pages[L1ACheckList.k].Width;
      double num998 = ((XUnit) ref xunit).Point - 20.0;
      local29.X = (float) num998;
      PDFFunctions.Points[1].Y = (float) L1ACheckList.RC1;
      ref PointF local30 = ref PDFFunctions.Points[2];
      xunit = PDFFunctions.pages[L1ACheckList.k].Width;
      double num999 = ((XUnit) ref xunit).Point - 20.0;
      local30.X = (float) num999;
      PDFFunctions.Points[2].Y = (float) checked (L1ACheckList.RC1 + 12);
      PDFFunctions.Points[3].X = 20f;
      PDFFunctions.Points[3].Y = (float) checked (L1ACheckList.RC1 + 12);
      PDFFunctions.gfx[L1ACheckList.k].DrawPolygon(PDFFunctions.polyGreen2, PDFFunctions.xBrush1, PDFFunctions.Points, PDFFunctions.Fill);
      XGraphics xgraphics498 = PDFFunctions.gfx[L1ACheckList.k];
      XFont arialFont10Bold177 = PDFFunctions.ArialFont10Bold;
      XSolidBrush white17 = XBrushes.White;
      double num1000 = (double) checked (L1ACheckList.RC1 + 1);
      xunit = PDFFunctions.pages[L1ACheckList.k].Width;
      double point502 = ((XUnit) ref xunit).Point;
      xunit = PDFFunctions.pages[L1ACheckList.k].Height;
      double num1001 = ((XUnit) ref xunit).Point / 2.0;
      XRect xrect498 = new XRect(25.0, num1000, point502, num1001);
      XStringFormat topLeft498 = XStringFormat.TopLeft;
      xgraphics498.DrawString("10 Key features", arialFont10Bold177, (XBrush) white17, xrect498, topLeft498);
      checked { L1ACheckList.RC1 += 13; }
      if (SAP_Module.Calculation2012.Calculation.HeatLoss.Box36 / SAP_Module.Calculation2012.Calculation.HeatLoss.Box31 < 0.03999)
      {
        XGraphics xgraphics499 = PDFFunctions.gfx[L1ACheckList.k];
        XFont arialFont10_312 = PDFFunctions.ArialFont10;
        XSolidBrush black332 = XBrushes.Black;
        double num1002 = (double) checked (L1ACheckList.RC1 + 1);
        xunit = PDFFunctions.pages[L1ACheckList.k].Width;
        double point503 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[L1ACheckList.k].Height;
        double num1003 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect499 = new XRect(50.0, num1002, point503, num1003);
        XStringFormat topLeft499 = XStringFormat.TopLeft;
        xgraphics499.DrawString("Thermal bridging", arialFont10_312, (XBrush) black332, xrect499, topLeft499);
        XGraphics xgraphics500 = PDFFunctions.gfx[L1ACheckList.k];
        string str146 = Conversions.ToString(Math.Round(SAP_Module.Calculation2012.Calculation.HeatLoss.Box36 / SAP_Module.Calculation2012.Calculation.HeatLoss.Box31, 3)) + " W/m\u00B2K";
        XFont arialFont10_313 = PDFFunctions.ArialFont10;
        XSolidBrush black333 = XBrushes.Black;
        double num1004 = (double) checked (L1ACheckList.RC1 + 1);
        xunit = PDFFunctions.pages[L1ACheckList.k].Width;
        double point504 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[L1ACheckList.k].Height;
        double num1005 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect500 = new XRect(360.0, num1004, point504, num1005);
        XStringFormat topLeft500 = XStringFormat.TopLeft;
        xgraphics500.DrawString(str146, arialFont10_313, (XBrush) black333, xrect500, topLeft500);
        checked { L1ACheckList.RC1 += 13; }
        L1ACheckList.SpecialFeatureFound = true;
      }
      // ISSUE: reference to a compiler-generated field
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Address.Country, "Wales", false) == 0)
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        if ((double) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Ventilation.DesignAir < 4.999 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Ventilation.Pressure, "As designed", false) == 0)
        {
          XGraphics xgraphics501 = PDFFunctions.gfx[L1ACheckList.k];
          XFont arialFont10_314 = PDFFunctions.ArialFont10;
          XSolidBrush black334 = XBrushes.Black;
          double num1006 = (double) checked (L1ACheckList.RC1 + 1);
          xunit = PDFFunctions.pages[L1ACheckList.k].Width;
          double point505 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[L1ACheckList.k].Height;
          double num1007 = ((XUnit) ref xunit).Point / 2.0;
          XRect xrect501 = new XRect(50.0, num1006, point505, num1007);
          XStringFormat topLeft501 = XStringFormat.TopLeft;
          xgraphics501.DrawString("Air permeablility", arialFont10_314, (XBrush) black334, xrect501, topLeft501);
          XGraphics xgraphics502 = PDFFunctions.gfx[L1ACheckList.k];
          // ISSUE: reference to a compiler-generated field
          string str147 = Microsoft.VisualBasic.Strings.Format((object) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Ventilation.DesignAir, "0.0") + " m\u00B3/m\u00B2h";
          XFont arialFont10_315 = PDFFunctions.ArialFont10;
          XSolidBrush black335 = XBrushes.Black;
          double num1008 = (double) checked (L1ACheckList.RC1 + 1);
          xunit = PDFFunctions.pages[L1ACheckList.k].Width;
          double point506 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[L1ACheckList.k].Height;
          double num1009 = ((XUnit) ref xunit).Point / 2.0;
          XRect xrect502 = new XRect(360.0, num1008, point506, num1009);
          XStringFormat topLeft502 = XStringFormat.TopLeft;
          xgraphics502.DrawString(str147, arialFont10_315, (XBrush) black335, xrect502, topLeft502);
          checked { L1ACheckList.RC1 += 13; }
          L1ACheckList.SpecialFeatureFound = true;
        }
        // ISSUE: reference to a compiler-generated field
        if (SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Ventilation.AveragePerm)
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          if ((double) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Ventilation.MeasuredAir < 3.999 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Ventilation.Pressure, "As built", false) == 0)
          {
            XGraphics xgraphics503 = PDFFunctions.gfx[L1ACheckList.k];
            XFont arialFont10_316 = PDFFunctions.ArialFont10;
            XSolidBrush black336 = XBrushes.Black;
            double num1010 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point507 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num1011 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect503 = new XRect(50.0, num1010, point507, num1011);
            XStringFormat topLeft503 = XStringFormat.TopLeft;
            xgraphics503.DrawString("Air permeablility", arialFont10_316, (XBrush) black336, xrect503, topLeft503);
            XGraphics xgraphics504 = PDFFunctions.gfx[L1ACheckList.k];
            // ISSUE: reference to a compiler-generated field
            string str148 = Microsoft.VisualBasic.Strings.Format((object) (float) ((double) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Ventilation.MeasuredAir + 2.0), "0.0") + " m\u00B3/m\u00B2h";
            XFont arialFont10_317 = PDFFunctions.ArialFont10;
            XSolidBrush black337 = XBrushes.Black;
            double num1012 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point508 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num1013 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect504 = new XRect(360.0, num1012, point508, num1013);
            XStringFormat topLeft504 = XStringFormat.TopLeft;
            xgraphics504.DrawString(str148, arialFont10_317, (XBrush) black337, xrect504, topLeft504);
            checked { L1ACheckList.RC1 += 13; }
            L1ACheckList.SpecialFeatureFound = true;
          }
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          if ((double) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Ventilation.MeasuredAir < 4.999 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Ventilation.Pressure, "As built", false) == 0)
          {
            XGraphics xgraphics505 = PDFFunctions.gfx[L1ACheckList.k];
            XFont arialFont10_318 = PDFFunctions.ArialFont10;
            XSolidBrush black338 = XBrushes.Black;
            double num1014 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point509 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num1015 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect505 = new XRect(50.0, num1014, point509, num1015);
            XStringFormat topLeft505 = XStringFormat.TopLeft;
            xgraphics505.DrawString("Air permeablility", arialFont10_318, (XBrush) black338, xrect505, topLeft505);
            XGraphics xgraphics506 = PDFFunctions.gfx[L1ACheckList.k];
            // ISSUE: reference to a compiler-generated field
            string str149 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Ventilation.MeasuredAir) + " m\u00B3/m\u00B2h";
            XFont arialFont10_319 = PDFFunctions.ArialFont10;
            XSolidBrush black339 = XBrushes.Black;
            double num1016 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point510 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num1017 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect506 = new XRect(360.0, num1016, point510, num1017);
            XStringFormat topLeft506 = XStringFormat.TopLeft;
            xgraphics506.DrawString(str149, arialFont10_319, (XBrush) black339, xrect506, topLeft506);
            checked { L1ACheckList.RC1 += 13; }
            L1ACheckList.SpecialFeatureFound = true;
          }
        }
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        if ((double) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Ventilation.DesignAir < 3.999 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Ventilation.Pressure, "As designed", false) == 0)
        {
          XGraphics xgraphics507 = PDFFunctions.gfx[L1ACheckList.k];
          XFont arialFont10_320 = PDFFunctions.ArialFont10;
          XSolidBrush black340 = XBrushes.Black;
          double num1018 = (double) checked (L1ACheckList.RC1 + 1);
          xunit = PDFFunctions.pages[L1ACheckList.k].Width;
          double point511 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[L1ACheckList.k].Height;
          double num1019 = ((XUnit) ref xunit).Point / 2.0;
          XRect xrect507 = new XRect(50.0, num1018, point511, num1019);
          XStringFormat topLeft507 = XStringFormat.TopLeft;
          xgraphics507.DrawString("Air permeablility", arialFont10_320, (XBrush) black340, xrect507, topLeft507);
          XGraphics xgraphics508 = PDFFunctions.gfx[L1ACheckList.k];
          // ISSUE: reference to a compiler-generated field
          string str150 = Microsoft.VisualBasic.Strings.Format((object) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Ventilation.DesignAir, "0.0") + " m\u00B3/m\u00B2h";
          XFont arialFont10_321 = PDFFunctions.ArialFont10;
          XSolidBrush black341 = XBrushes.Black;
          double num1020 = (double) checked (L1ACheckList.RC1 + 1);
          xunit = PDFFunctions.pages[L1ACheckList.k].Width;
          double point512 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[L1ACheckList.k].Height;
          double num1021 = ((XUnit) ref xunit).Point / 2.0;
          XRect xrect508 = new XRect(360.0, num1020, point512, num1021);
          XStringFormat topLeft508 = XStringFormat.TopLeft;
          xgraphics508.DrawString(str150, arialFont10_321, (XBrush) black341, xrect508, topLeft508);
          checked { L1ACheckList.RC1 += 13; }
          L1ACheckList.SpecialFeatureFound = true;
        }
        // ISSUE: reference to a compiler-generated field
        if (SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Ventilation.AveragePerm)
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          if ((double) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Ventilation.MeasuredAir < 2.999 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Ventilation.Pressure, "As built", false) == 0)
          {
            XGraphics xgraphics509 = PDFFunctions.gfx[L1ACheckList.k];
            XFont arialFont10_322 = PDFFunctions.ArialFont10;
            XSolidBrush black342 = XBrushes.Black;
            double num1022 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point513 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num1023 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect509 = new XRect(50.0, num1022, point513, num1023);
            XStringFormat topLeft509 = XStringFormat.TopLeft;
            xgraphics509.DrawString("Air permeablility", arialFont10_322, (XBrush) black342, xrect509, topLeft509);
            // ISSUE: reference to a compiler-generated field
            if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Address.Country, "Scotland", false) > 0U)
            {
              XGraphics xgraphics510 = PDFFunctions.gfx[L1ACheckList.k];
              // ISSUE: reference to a compiler-generated field
              string str151 = Microsoft.VisualBasic.Strings.Format((object) (float) ((double) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Ventilation.MeasuredAir + 2.0), "0.0") + " m\u00B3/m\u00B2h";
              XFont arialFont10_323 = PDFFunctions.ArialFont10;
              XSolidBrush black343 = XBrushes.Black;
              double num1024 = (double) checked (L1ACheckList.RC1 + 1);
              xunit = PDFFunctions.pages[L1ACheckList.k].Width;
              double point514 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[L1ACheckList.k].Height;
              double num1025 = ((XUnit) ref xunit).Point / 2.0;
              XRect xrect510 = new XRect(360.0, num1024, point514, num1025);
              XStringFormat topLeft510 = XStringFormat.TopLeft;
              xgraphics510.DrawString(str151, arialFont10_323, (XBrush) black343, xrect510, topLeft510);
            }
            else
            {
              XGraphics xgraphics511 = PDFFunctions.gfx[L1ACheckList.k];
              // ISSUE: reference to a compiler-generated field
              string str152 = Microsoft.VisualBasic.Strings.Format((object) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Ventilation.MeasuredAir, "0.0") + " m\u00B3/m\u00B2h";
              XFont arialFont10_324 = PDFFunctions.ArialFont10;
              XSolidBrush black344 = XBrushes.Black;
              double num1026 = (double) checked (L1ACheckList.RC1 + 1);
              xunit = PDFFunctions.pages[L1ACheckList.k].Width;
              double point515 = ((XUnit) ref xunit).Point;
              xunit = PDFFunctions.pages[L1ACheckList.k].Height;
              double num1027 = ((XUnit) ref xunit).Point / 2.0;
              XRect xrect511 = new XRect(360.0, num1026, point515, num1027);
              XStringFormat topLeft511 = XStringFormat.TopLeft;
              xgraphics511.DrawString(str152, arialFont10_324, (XBrush) black344, xrect511, topLeft511);
            }
            checked { L1ACheckList.RC1 += 13; }
            L1ACheckList.SpecialFeatureFound = true;
          }
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          if ((double) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Ventilation.MeasuredAir < 3.999 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Ventilation.Pressure, "As built", false) == 0)
          {
            XGraphics xgraphics512 = PDFFunctions.gfx[L1ACheckList.k];
            XFont arialFont10_325 = PDFFunctions.ArialFont10;
            XSolidBrush black345 = XBrushes.Black;
            double num1028 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point516 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num1029 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect512 = new XRect(50.0, num1028, point516, num1029);
            XStringFormat topLeft512 = XStringFormat.TopLeft;
            xgraphics512.DrawString("Air permeablility", arialFont10_325, (XBrush) black345, xrect512, topLeft512);
            XGraphics xgraphics513 = PDFFunctions.gfx[L1ACheckList.k];
            // ISSUE: reference to a compiler-generated field
            string str153 = Microsoft.VisualBasic.Strings.Format((object) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Ventilation.MeasuredAir, "0.0") + " m\u00B3/m\u00B2h";
            XFont arialFont10_326 = PDFFunctions.ArialFont10;
            XSolidBrush black346 = XBrushes.Black;
            double num1030 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point517 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num1031 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect513 = new XRect(360.0, num1030, point517, num1031);
            XStringFormat topLeft513 = XStringFormat.TopLeft;
            xgraphics513.DrawString(str153, arialFont10_326, (XBrush) black346, xrect513, topLeft513);
            checked { L1ACheckList.RC1 += 13; }
            L1ACheckList.SpecialFeatureFound = true;
          }
        }
      }
      float[] numArray1 = new float[0];
      bool flag9 = false;
      float[] numArray2 = new float[0];
      // ISSUE: reference to a compiler-generated field
      if (SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].NoofWindows > 0)
      {
        // ISSUE: reference to a compiler-generated field
        int num1032 = checked (((IEnumerable<SAP_Module.Window>) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Windows).Count<SAP_Module.Window>() - 1);
        int index5 = 0;
        while (index5 <= num1032)
        {
          // ISSUE: reference to a compiler-generated field
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Address.Country, "Wales", false) == 0)
          {
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            if ((double) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Windows[index5].U < 1.39 & !((IEnumerable<float>) numArray2).Contains<float>(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Windows[index5].U))
            {
              numArray2 = (float[]) Utils.CopyArray((Array) numArray2, (Array) new float[checked (numArray2.Length + 1)]);
              // ISSUE: reference to a compiler-generated field
              numArray2[checked (numArray2.Length - 1)] = SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Windows[index5].U;
            }
          }
          else
          {
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            if ((double) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Windows[index5].U < 1.199 & !((IEnumerable<float>) numArray2).Contains<float>(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Windows[index5].U))
            {
              numArray2 = (float[]) Utils.CopyArray((Array) numArray2, (Array) new float[checked (numArray2.Length + 1)]);
              // ISSUE: reference to a compiler-generated field
              numArray2[checked (numArray2.Length - 1)] = SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Windows[index5].U;
            }
          }
          checked { ++index5; }
        }
        int num1033 = checked (numArray2.Length - 1);
        int index6 = 0;
        while (index6 <= num1033)
        {
          if (!flag9)
          {
            XGraphics xgraphics514 = PDFFunctions.gfx[L1ACheckList.k];
            XFont arialFont10_327 = PDFFunctions.ArialFont10;
            XSolidBrush black347 = XBrushes.Black;
            double num1034 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point518 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num1035 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect514 = new XRect(50.0, num1034, point518, num1035);
            XStringFormat topLeft514 = XStringFormat.TopLeft;
            xgraphics514.DrawString("Windows U-value  ", arialFont10_327, (XBrush) black347, xrect514, topLeft514);
            XGraphics xgraphics515 = PDFFunctions.gfx[L1ACheckList.k];
            string str154 = Conversions.ToString(Math.Round((double) numArray2[index6], 2)) + " W/m\u00B2K";
            XFont arialFont10_328 = PDFFunctions.ArialFont10;
            XSolidBrush black348 = XBrushes.Black;
            double num1036 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point519 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num1037 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect515 = new XRect(360.0, num1036, point519, num1037);
            XStringFormat topLeft515 = XStringFormat.TopLeft;
            xgraphics515.DrawString(str154, arialFont10_328, (XBrush) black348, xrect515, topLeft515);
            L1ACheckList.SpecialFeatureFound = true;
            checked { L1ACheckList.RC1 += 13; }
            L1ACheckList.CheckCheckListRC1();
            flag9 = true;
          }
          checked { ++index6; }
        }
      }
      bool flag10 = false;
      float[] numArray3 = new float[0];
      // ISSUE: reference to a compiler-generated field
      if (SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].NoofDoors > 0)
      {
        // ISSUE: reference to a compiler-generated field
        int num1038 = checked (((IEnumerable<SAP_Module.Door>) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Doors).Count<SAP_Module.Door>() - 1);
        int index7 = 0;
        while (index7 <= num1038)
        {
          // ISSUE: reference to a compiler-generated field
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Address.Country, "Wales", false) == 0)
          {
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            if ((double) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Doors[index7].U < 1.399 & !((IEnumerable<float>) numArray3).Contains<float>(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Doors[index7].U))
            {
              numArray3 = (float[]) Utils.CopyArray((Array) numArray3, (Array) new float[checked (numArray3.Length + 1)]);
              // ISSUE: reference to a compiler-generated field
              numArray3[checked (numArray3.Length - 1)] = SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Doors[index7].U;
            }
          }
          else
          {
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            if ((double) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Doors[index7].U < 1.199 & !((IEnumerable<float>) numArray3).Contains<float>(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Doors[index7].U))
            {
              numArray3 = (float[]) Utils.CopyArray((Array) numArray3, (Array) new float[checked (numArray3.Length + 1)]);
              // ISSUE: reference to a compiler-generated field
              numArray3[checked (numArray3.Length - 1)] = SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Doors[index7].U;
            }
          }
          checked { ++index7; }
        }
        int num1039 = checked (numArray3.Length - 1);
        int index8 = 0;
        while (index8 <= num1039)
        {
          if (!flag10)
          {
            XGraphics xgraphics516 = PDFFunctions.gfx[L1ACheckList.k];
            XFont arialFont10_329 = PDFFunctions.ArialFont10;
            XSolidBrush black349 = XBrushes.Black;
            double num1040 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point520 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num1041 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect516 = new XRect(50.0, num1040, point520, num1041);
            XStringFormat topLeft516 = XStringFormat.TopLeft;
            xgraphics516.DrawString("Doors U-value  ", arialFont10_329, (XBrush) black349, xrect516, topLeft516);
            XGraphics xgraphics517 = PDFFunctions.gfx[L1ACheckList.k];
            string str155 = Conversions.ToString(Math.Round((double) numArray3[index8], 2)) + " W/m\u00B2K";
            XFont arialFont10_330 = PDFFunctions.ArialFont10;
            XSolidBrush black350 = XBrushes.Black;
            double num1042 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point521 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num1043 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect517 = new XRect(360.0, num1042, point521, num1043);
            XStringFormat topLeft517 = XStringFormat.TopLeft;
            xgraphics517.DrawString(str155, arialFont10_330, (XBrush) black350, xrect517, topLeft517);
            L1ACheckList.SpecialFeatureFound = true;
            checked { L1ACheckList.RC1 += 13; }
            L1ACheckList.CheckCheckListRC1();
            flag10 = true;
          }
          checked { ++index8; }
        }
      }
      bool flag11 = false;
      float[] numArray4 = new float[0];
      // ISSUE: reference to a compiler-generated field
      if (SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].NoofRoofs > 0)
      {
        // ISSUE: reference to a compiler-generated field
        int num1044 = checked (((IEnumerable<SAP_Module.Opaques>) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Roofs).Count<SAP_Module.Opaques>() - 1);
        int index9 = 0;
        while (index9 <= num1044)
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          float num1045 = (float) Math.Round(1.0 / (1.0 / (double) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Roofs[index9].U_Value + (double) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Roofs[index9].Ru), 2);
          if ((double) num1045 < 0.1299 & !((IEnumerable<float>) numArray4).Contains<float>(num1045))
          {
            numArray4 = (float[]) Utils.CopyArray((Array) numArray4, (Array) new float[checked (numArray4.Length + 1)]);
            numArray4[checked (numArray4.Length - 1)] = num1045;
          }
          checked { ++index9; }
        }
        int num1046 = checked (numArray4.Length - 1);
        int index10 = 0;
        while (index10 <= num1046)
        {
          if (!flag11)
          {
            XGraphics xgraphics518 = PDFFunctions.gfx[L1ACheckList.k];
            XFont arialFont10_331 = PDFFunctions.ArialFont10;
            XSolidBrush black351 = XBrushes.Black;
            double num1047 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point522 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num1048 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect518 = new XRect(50.0, num1047, point522, num1048);
            XStringFormat topLeft518 = XStringFormat.TopLeft;
            xgraphics518.DrawString("Roofs U-value  ", arialFont10_331, (XBrush) black351, xrect518, topLeft518);
            XGraphics xgraphics519 = PDFFunctions.gfx[L1ACheckList.k];
            string str156 = Conversions.ToString(Math.Round((double) numArray4[index10], 2)) + " W/m\u00B2K";
            XFont arialFont10_332 = PDFFunctions.ArialFont10;
            XSolidBrush black352 = XBrushes.Black;
            double num1049 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point523 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num1050 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect519 = new XRect(360.0, num1049, point523, num1050);
            XStringFormat topLeft519 = XStringFormat.TopLeft;
            xgraphics519.DrawString(str156, arialFont10_332, (XBrush) black352, xrect519, topLeft519);
            L1ACheckList.SpecialFeatureFound = true;
            checked { L1ACheckList.RC1 += 13; }
            L1ACheckList.CheckCheckListRC1();
            flag11 = true;
          }
          checked { ++index10; }
        }
      }
      bool flag12 = false;
      float[] numArray5 = new float[0];
      // ISSUE: reference to a compiler-generated field
      if (SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].NoofWalls > 0)
      {
        // ISSUE: reference to a compiler-generated field
        int num1051 = checked (((IEnumerable<SAP_Module.Opaques>) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Walls).Count<SAP_Module.Opaques>() - 1);
        int index11 = 0;
        while (index11 <= num1051)
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          float num1052 = (float) Math.Round(1.0 / (1.0 / (double) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Walls[index11].U_Value + (double) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Walls[index11].Ru), 2);
          // ISSUE: reference to a compiler-generated field
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Address.Country, "Wales", false) == 0)
          {
            if ((double) num1052 < 0.17999 & !((IEnumerable<float>) numArray5).Contains<float>(num1052))
            {
              numArray5 = (float[]) Utils.CopyArray((Array) numArray5, (Array) new float[checked (numArray5.Length + 1)]);
              numArray5[checked (numArray5.Length - 1)] = num1052;
            }
          }
          else if ((double) num1052 < 0.13999 & !((IEnumerable<float>) numArray5).Contains<float>(num1052))
          {
            numArray5 = (float[]) Utils.CopyArray((Array) numArray5, (Array) new float[checked (numArray5.Length + 1)]);
            numArray5[checked (numArray5.Length - 1)] = num1052;
          }
          checked { ++index11; }
        }
        int num1053 = checked (numArray5.Length - 1);
        int index12 = 0;
        while (index12 <= num1053)
        {
          XGraphics xgraphics520 = PDFFunctions.gfx[L1ACheckList.k];
          XFont arialFont10_333 = PDFFunctions.ArialFont10;
          XSolidBrush black353 = XBrushes.Black;
          double num1054 = (double) checked (L1ACheckList.RC1 + 1);
          xunit = PDFFunctions.pages[L1ACheckList.k].Width;
          double point524 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[L1ACheckList.k].Height;
          double num1055 = ((XUnit) ref xunit).Point / 2.0;
          XRect xrect520 = new XRect(50.0, num1054, point524, num1055);
          XStringFormat topLeft520 = XStringFormat.TopLeft;
          xgraphics520.DrawString("External  Walls U-value  ", arialFont10_333, (XBrush) black353, xrect520, topLeft520);
          XGraphics xgraphics521 = PDFFunctions.gfx[L1ACheckList.k];
          string str157 = Conversions.ToString(Math.Round((double) numArray5[index12], 2)) + " W/m\u00B2K";
          XFont arialFont10_334 = PDFFunctions.ArialFont10;
          XSolidBrush black354 = XBrushes.Black;
          double num1056 = (double) checked (L1ACheckList.RC1 + 1);
          xunit = PDFFunctions.pages[L1ACheckList.k].Width;
          double point525 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[L1ACheckList.k].Height;
          double num1057 = ((XUnit) ref xunit).Point / 2.0;
          XRect xrect521 = new XRect(360.0, num1056, point525, num1057);
          XStringFormat topLeft521 = XStringFormat.TopLeft;
          xgraphics521.DrawString(str157, arialFont10_334, (XBrush) black354, xrect521, topLeft521);
          L1ACheckList.SpecialFeatureFound = true;
          checked { L1ACheckList.RC1 += 13; }
          L1ACheckList.CheckCheckListRC1();
          checked { ++index12; }
        }
      }
      float[] numArray6 = new float[0];
      // ISSUE: reference to a compiler-generated field
      if (SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].NoofPWalls > 0)
      {
        // ISSUE: reference to a compiler-generated field
        int num1058 = checked (((IEnumerable<SAP_Module.PartyWall>) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].PWalls).Count<SAP_Module.PartyWall>() - 1);
        int index13 = 0;
        while (index13 <= num1058)
        {
          try
          {
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            float num1059 = (float) Math.Round(1.0 / (1.0 / (double) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].PWalls[index13].U_Value + (double) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Walls[index13].Ru), 2);
            if ((double) num1059 < 0.1 & !((IEnumerable<float>) numArray6).Contains<float>(num1059))
            {
              numArray6 = (float[]) Utils.CopyArray((Array) numArray6, (Array) new float[checked (numArray6.Length + 1)]);
              numArray6[checked (numArray6.Length - 1)] = num1059;
            }
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
          checked { ++index13; }
        }
        int num1060 = checked (numArray6.Length - 1);
        int index14 = 0;
        while (index14 <= num1060)
        {
          XGraphics xgraphics522 = PDFFunctions.gfx[L1ACheckList.k];
          XFont arialFont10_335 = PDFFunctions.ArialFont10;
          XSolidBrush black355 = XBrushes.Black;
          double num1061 = (double) checked (L1ACheckList.RC1 + 1);
          xunit = PDFFunctions.pages[L1ACheckList.k].Width;
          double point526 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[L1ACheckList.k].Height;
          double num1062 = ((XUnit) ref xunit).Point / 2.0;
          XRect xrect522 = new XRect(50.0, num1061, point526, num1062);
          XStringFormat topLeft522 = XStringFormat.TopLeft;
          xgraphics522.DrawString("Party  Walls U-value  ", arialFont10_335, (XBrush) black355, xrect522, topLeft522);
          XGraphics xgraphics523 = PDFFunctions.gfx[L1ACheckList.k];
          string str158 = Conversions.ToString(Math.Round((double) numArray6[index14], 2)) + " W/m\u00B2K";
          XFont arialFont10_336 = PDFFunctions.ArialFont10;
          XSolidBrush black356 = XBrushes.Black;
          double num1063 = (double) checked (L1ACheckList.RC1 + 1);
          xunit = PDFFunctions.pages[L1ACheckList.k].Width;
          double point527 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[L1ACheckList.k].Height;
          double num1064 = ((XUnit) ref xunit).Point / 2.0;
          XRect xrect523 = new XRect(360.0, num1063, point527, num1064);
          XStringFormat topLeft523 = XStringFormat.TopLeft;
          xgraphics523.DrawString(str158, arialFont10_336, (XBrush) black356, xrect523, topLeft523);
          L1ACheckList.SpecialFeatureFound = true;
          checked { L1ACheckList.RC1 += 13; }
          L1ACheckList.CheckCheckListRC1();
          checked { ++index14; }
        }
      }
      flag12 = false;
      string[] strArray = new string[0];
      float[] numArray7 = new float[0];
      // ISSUE: reference to a compiler-generated field
      if (SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].NoofFloors > 0)
      {
        // ISSUE: reference to a compiler-generated field
        int num1065 = checked (((IEnumerable<SAP_Module.Opaques>) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Floors).Count<SAP_Module.Opaques>() - 1);
        int index15 = 0;
        while (index15 <= num1065)
        {
          try
          {
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            float num1066 = (float) Math.Round(1.0 / (1.0 / (double) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Floors[index15].U_Value + (double) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Floors[index15].Ru), 2);
            if ((double) num1066 < 0.129)
            {
              // ISSUE: reference to a compiler-generated field
              if (!((IEnumerable<float>) numArray7).Contains<float>(num1066) | !((IEnumerable<string>) strArray).Contains<string>(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Floors[index15].Type))
              {
                numArray7 = (float[]) Utils.CopyArray((Array) numArray7, (Array) new float[checked (numArray7.Length + 1)]);
                numArray7[checked (numArray7.Length - 1)] = num1066;
                strArray = (string[]) Utils.CopyArray((Array) strArray, (Array) new string[checked (strArray.Length + 1)]);
                // ISSUE: reference to a compiler-generated field
                strArray[checked (strArray.Length - 1)] = SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Floors[index15].Type;
              }
            }
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
          checked { ++index15; }
        }
        int num1067 = checked (numArray7.Length - 1);
        int index16 = 0;
        while (index16 <= num1067)
        {
          XGraphics xgraphics524 = PDFFunctions.gfx[L1ACheckList.k];
          XFont arialFont10_337 = PDFFunctions.ArialFont10;
          XSolidBrush black357 = XBrushes.Black;
          double num1068 = (double) checked (L1ACheckList.RC1 + 1);
          xunit = PDFFunctions.pages[L1ACheckList.k].Width;
          double point528 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[L1ACheckList.k].Height;
          double num1069 = ((XUnit) ref xunit).Point / 2.0;
          XRect xrect524 = new XRect(50.0, num1068, point528, num1069);
          XStringFormat topLeft524 = XStringFormat.TopLeft;
          xgraphics524.DrawString("Floors U-value  ", arialFont10_337, (XBrush) black357, xrect524, topLeft524);
          XGraphics xgraphics525 = PDFFunctions.gfx[L1ACheckList.k];
          string str159 = Conversions.ToString(Math.Round((double) numArray7[index16], 2)) + " W/m\u00B2K";
          XFont arialFont10_338 = PDFFunctions.ArialFont10;
          XSolidBrush black358 = XBrushes.Black;
          double num1070 = (double) checked (L1ACheckList.RC1 + 1);
          xunit = PDFFunctions.pages[L1ACheckList.k].Width;
          double point529 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[L1ACheckList.k].Height;
          double num1071 = ((XUnit) ref xunit).Point / 2.0;
          XRect xrect525 = new XRect(360.0, num1070, point529, num1071);
          XStringFormat topLeft525 = XStringFormat.TopLeft;
          xgraphics525.DrawString(str159, arialFont10_338, (XBrush) black358, xrect525, topLeft525);
          L1ACheckList.SpecialFeatureFound = true;
          checked { L1ACheckList.RC1 += 13; }
          L1ACheckList.CheckCheckListRC1();
          checked { ++index16; }
        }
      }
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.InforSource, "Boiler Database", false) == 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.SGroup, "Micro-cogeneration (micro-CHP)", false) == 0)
      {
        XGraphics xgraphics526 = PDFFunctions.gfx[L1ACheckList.k];
        XFont arialFont10_339 = PDFFunctions.ArialFont10;
        XSolidBrush black359 = XBrushes.Black;
        double num1072 = (double) checked (L1ACheckList.RC1 + 1);
        xunit = PDFFunctions.pages[L1ACheckList.k].Width;
        double point530 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[L1ACheckList.k].Height;
        double num1073 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect526 = new XRect(50.0, num1072, point530, num1073);
        XStringFormat topLeft526 = XStringFormat.TopLeft;
        xgraphics526.DrawString("Main heating by by micro-CHP", arialFont10_339, (XBrush) black359, xrect526, topLeft526);
        checked { L1ACheckList.RC1 += 13; }
        L1ACheckList.SpecialFeatureFound = true;
      }
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      if (SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.SAPTableCode > 304 & SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.SAPTableCode < 311)
      {
        XGraphics xgraphics527 = PDFFunctions.gfx[L1ACheckList.k];
        // ISSUE: reference to a compiler-generated field
        string str160 = "Community heating, " + SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.Fuel;
        XFont arialFont10_340 = PDFFunctions.ArialFont10;
        XSolidBrush black360 = XBrushes.Black;
        double num1074 = (double) checked (L1ACheckList.RC1 + 1);
        xunit = PDFFunctions.pages[L1ACheckList.k].Width;
        double point531 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[L1ACheckList.k].Height;
        double num1075 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect527 = new XRect(50.0, num1074, point531, num1075);
        XStringFormat topLeft527 = XStringFormat.TopLeft;
        xgraphics527.DrawString(str160, arialFont10_340, (XBrush) black360, xrect527, topLeft527);
        checked { L1ACheckList.RC1 += 13; }
        // ISSUE: reference to a compiler-generated field
        if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatSource1.Fuel, "", false) > 0U & !L1ACheckList.CommFeature_found)
        {
          // ISSUE: reference to a compiler-generated field
          float single = Conversions.ToSingle(PDFFunctions.CheckFuelCode(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatSource1.Fuel));
          if ((double) single > 41.0 & (double) single < 47.0)
          {
            XGraphics xgraphics528 = PDFFunctions.gfx[L1ACheckList.k];
            // ISSUE: reference to a compiler-generated field
            string str161 = "Community heating, " + SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatSource1.Fuel;
            XFont arialFont10_341 = PDFFunctions.ArialFont10;
            XSolidBrush black361 = XBrushes.Black;
            double num1076 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point532 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num1077 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect528 = new XRect(50.0, num1076, point532, num1077);
            XStringFormat topLeft528 = XStringFormat.TopLeft;
            xgraphics528.DrawString(str161, arialFont10_341, (XBrush) black361, xrect528, topLeft528);
            checked { L1ACheckList.RC1 += 13; }
            L1ACheckList.CommFeature_found = true;
          }
        }
        // ISSUE: reference to a compiler-generated field
        if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatSource2.Fuel, "", false) > 0U & !L1ACheckList.CommFeature_found)
        {
          // ISSUE: reference to a compiler-generated field
          float single = Conversions.ToSingle(PDFFunctions.CheckFuelCode(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatSource2.Fuel));
          if ((double) single > 41.0 & (double) single < 47.0)
          {
            XGraphics xgraphics529 = PDFFunctions.gfx[L1ACheckList.k];
            // ISSUE: reference to a compiler-generated field
            string str162 = "Community heating, " + SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatSource2.Fuel;
            XFont arialFont10_342 = PDFFunctions.ArialFont10;
            XSolidBrush black362 = XBrushes.Black;
            double num1078 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point533 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num1079 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect529 = new XRect(50.0, num1078, point533, num1079);
            XStringFormat topLeft529 = XStringFormat.TopLeft;
            xgraphics529.DrawString(str162, arialFont10_342, (XBrush) black362, xrect529, topLeft529);
            checked { L1ACheckList.RC1 += 13; }
            L1ACheckList.CommFeature_found = true;
          }
        }
        // ISSUE: reference to a compiler-generated field
        if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatSource3.Fuel, "", false) > 0U & !L1ACheckList.CommFeature_found)
        {
          // ISSUE: reference to a compiler-generated field
          float single = Conversions.ToSingle(PDFFunctions.CheckFuelCode(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatSource3.Fuel));
          if ((double) single > 41.0 & (double) single < 47.0)
          {
            XGraphics xgraphics530 = PDFFunctions.gfx[L1ACheckList.k];
            // ISSUE: reference to a compiler-generated field
            string str163 = "Community heating, " + SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatSource3.Fuel;
            XFont arialFont10_343 = PDFFunctions.ArialFont10;
            XSolidBrush black363 = XBrushes.Black;
            double num1080 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point534 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num1081 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect530 = new XRect(50.0, num1080, point534, num1081);
            XStringFormat topLeft530 = XStringFormat.TopLeft;
            xgraphics530.DrawString(str163, arialFont10_343, (XBrush) black363, xrect530, topLeft530);
            checked { L1ACheckList.RC1 += 13; }
            L1ACheckList.CommFeature_found = true;
          }
        }
        // ISSUE: reference to a compiler-generated field
        if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatSource4.Fuel, "", false) > 0U & !L1ACheckList.CommFeature_found)
        {
          // ISSUE: reference to a compiler-generated field
          float single = Conversions.ToSingle(PDFFunctions.CheckFuelCode(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatSource4.Fuel));
          if ((double) single > 41.0 & (double) single < 47.0)
          {
            XGraphics xgraphics531 = PDFFunctions.gfx[L1ACheckList.k];
            // ISSUE: reference to a compiler-generated field
            string str164 = "Community heating, " + SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatSource4.Fuel;
            XFont arialFont10_344 = PDFFunctions.ArialFont10;
            XSolidBrush black364 = XBrushes.Black;
            double num1082 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point535 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num1083 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect531 = new XRect(50.0, num1082, point535, num1083);
            XStringFormat topLeft531 = XStringFormat.TopLeft;
            xgraphics531.DrawString(str164, arialFont10_344, (XBrush) black364, xrect531, topLeft531);
            checked { L1ACheckList.RC1 += 13; }
            L1ACheckList.CommFeature_found = true;
          }
        }
        L1ACheckList.SpecialFeatureFound = true;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        if (SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Water.SystemRef >= 950 & SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Water.SystemRef <= 952)
        {
          XGraphics xgraphics532 = PDFFunctions.gfx[L1ACheckList.k];
          // ISSUE: reference to a compiler-generated field
          string str165 = "Community heating, " + SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Water.Fuel;
          XFont arialFont10_345 = PDFFunctions.ArialFont10;
          XSolidBrush black365 = XBrushes.Black;
          double num1084 = (double) checked (L1ACheckList.RC1 + 1);
          xunit = PDFFunctions.pages[L1ACheckList.k].Width;
          double point536 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[L1ACheckList.k].Height;
          double num1085 = ((XUnit) ref xunit).Point / 2.0;
          XRect xrect532 = new XRect(50.0, num1084, point536, num1085);
          XStringFormat topLeft532 = XStringFormat.TopLeft;
          xgraphics532.DrawString(str165, arialFont10_345, (XBrush) black365, xrect532, topLeft532);
          checked { L1ACheckList.RC1 += 13; }
          L1ACheckList.SpecialFeatureFound = true;
        }
      }
      // ISSUE: reference to a compiler-generated field
      if (SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Renewable.Photovoltaic.Inlcude)
      {
        XGraphics xgraphics533 = PDFFunctions.gfx[L1ACheckList.k];
        XFont arialFont10_346 = PDFFunctions.ArialFont10;
        XSolidBrush black366 = XBrushes.Black;
        double num1086 = (double) checked (L1ACheckList.RC1 + 1);
        xunit = PDFFunctions.pages[L1ACheckList.k].Width;
        double point537 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[L1ACheckList.k].Height;
        double num1087 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect533 = new XRect(50.0, num1086, point537, num1087);
        XStringFormat topLeft533 = XStringFormat.TopLeft;
        xgraphics533.DrawString("Photovoltaic array", arialFont10_346, (XBrush) black366, xrect533, topLeft533);
        checked { L1ACheckList.RC1 += 13; }
        L1ACheckList.SpecialFeatureFound = true;
      }
      // ISSUE: reference to a compiler-generated field
      if (SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Renewable.WindTurbine.Inlcude)
      {
        XGraphics xgraphics534 = PDFFunctions.gfx[L1ACheckList.k];
        XFont arialFont10_347 = PDFFunctions.ArialFont10;
        XSolidBrush black367 = XBrushes.Black;
        double num1088 = (double) checked (L1ACheckList.RC1 + 1);
        xunit = PDFFunctions.pages[L1ACheckList.k].Width;
        double point538 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[L1ACheckList.k].Height;
        double num1089 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect534 = new XRect(50.0, num1088, point538, num1089);
        XStringFormat topLeft534 = XStringFormat.TopLeft;
        xgraphics534.DrawString("Wind turbine", arialFont10_347, (XBrush) black367, xrect534, topLeft534);
        checked { L1ACheckList.RC1 += 13; }
        L1ACheckList.SpecialFeatureFound = true;
      }
      // ISSUE: reference to a compiler-generated field
      if (SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Renewable.Special.Include)
      {
        // ISSUE: reference to a compiler-generated field
        int num1090 = checked (SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Renewable.Special.Special.Length - 1);
        int index = 0;
        while (index <= num1090)
        {
          XGraphics xgraphics535 = PDFFunctions.gfx[L1ACheckList.k];
          // ISSUE: reference to a compiler-generated field
          string str166 = "Appendix Q : " + SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Renewable.Special.Special[index].Description;
          XFont arialFont10_348 = PDFFunctions.ArialFont10;
          XSolidBrush black368 = XBrushes.Black;
          double num1091 = (double) checked (L1ACheckList.RC1 + 1);
          xunit = PDFFunctions.pages[L1ACheckList.k].Width;
          double point539 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[L1ACheckList.k].Height;
          double num1092 = ((XUnit) ref xunit).Point / 2.0;
          XRect xrect535 = new XRect(50.0, num1091, point539, num1092);
          XStringFormat topLeft535 = XStringFormat.TopLeft;
          xgraphics535.DrawString(str166, arialFont10_348, (XBrush) black368, xrect535, topLeft535);
          checked { L1ACheckList.RC1 += 13; }
          L1ACheckList.SpecialFeatureFound = true;
          checked { ++index; }
        }
      }
      // ISSUE: reference to a compiler-generated field
      string fuel9 = SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.Fuel;
      // ISSUE: reference to a compiler-generated method
      switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(fuel9))
      {
        case 335024745:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel9, "heat from boilers – biogas", false) == 0)
            break;
          goto default;
        case 575487477:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel9, "wood pellets (bulk supply in bags, for main heating)", false) == 0)
            break;
          goto default;
        case 664172296:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel9, "heat from CHP", false) == 0)
            break;
          goto default;
        case 721524493:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel9, "dual fuel appliance (mineral and wood)", false) == 0)
            break;
          goto default;
        case 1424221758:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel9, "geothermal heat source", false) == 0)
            break;
          goto default;
        case 1522447619:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel9, "wood chips", false) == 0)
            break;
          goto default;
        case 1946790875:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel9, "wood logs", false) == 0)
            break;
          goto default;
        case 2251322125:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel9, "wood pellets (in bags, for secondary heating)", false) == 0)
            break;
          goto default;
        case 2340757125:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel9, "heat from boilers - waste combustion", false) == 0)
            break;
          goto default;
        case 2343415715:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel9, "waste heat from power stations", false) == 0)
            break;
          goto default;
        case 2442528761:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel9, "heat from heat pump", false) == 0)
            break;
          goto default;
        case 3198893402:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel9, "rapeseed oil", false) == 0)
            break;
          goto default;
        case 3216529428:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel9, "heat from boilers – biomass", false) == 0)
            break;
          goto default;
        case 3349323758:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel9, "biodiesel from any biomass source", false) == 0)
            break;
          goto default;
        case 4235694608:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel9, "biodiesel from used cooking oil only", false) == 0)
            break;
          goto default;
        default:
label_1299:
          // ISSUE: reference to a compiler-generated field
          if (SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Cooling.Include)
          {
            XGraphics xgraphics536 = PDFFunctions.gfx[L1ACheckList.k];
            XFont arialFont10_349 = PDFFunctions.ArialFont10;
            XSolidBrush black369 = XBrushes.Black;
            double num1093 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point540 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num1094 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect536 = new XRect(50.0, num1093, point540, num1094);
            XStringFormat topLeft536 = XStringFormat.TopLeft;
            xgraphics536.DrawString("Fixed cooling system ", arialFont10_349, (XBrush) black369, xrect536, topLeft536);
            checked { L1ACheckList.RC1 += 13; }
            L1ACheckList.SpecialFeatureFound = true;
          }
          // ISSUE: reference to a compiler-generated field
          if (SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Renewable.AAEGeneration.Inlcude)
          {
            XGraphics xgraphics537 = PDFFunctions.gfx[L1ACheckList.k];
            XFont arialFont10_350 = PDFFunctions.ArialFont10;
            XSolidBrush black370 = XBrushes.Black;
            double num1095 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point541 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num1096 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect537 = new XRect(50.0, num1095, point541, num1096);
            XStringFormat topLeft537 = XStringFormat.TopLeft;
            xgraphics537.DrawString("Allow Electricity Generation", arialFont10_350, (XBrush) black370, xrect537, topLeft537);
            checked { L1ACheckList.RC1 += 13; }
            L1ACheckList.SpecialFeatureFound = true;
          }
          // ISSUE: reference to a compiler-generated field
          if (SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Renewable.HydroGeneration.Inlcude)
          {
            XGraphics xgraphics538 = PDFFunctions.gfx[L1ACheckList.k];
            XFont arialFont10_351 = PDFFunctions.ArialFont10;
            XSolidBrush black371 = XBrushes.Black;
            double num1097 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point542 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num1098 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect538 = new XRect(50.0, num1097, point542, num1098);
            XStringFormat topLeft538 = XStringFormat.TopLeft;
            xgraphics538.DrawString("Small scale hydro-electic generation", arialFont10_351, (XBrush) black371, xrect538, topLeft538);
            checked { L1ACheckList.RC1 += 13; }
            L1ACheckList.SpecialFeatureFound = true;
          }
          // ISSUE: reference to a compiler-generated field
          if (SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Water.Solar.Inlcude)
          {
            XGraphics xgraphics539 = PDFFunctions.gfx[L1ACheckList.k];
            XFont arialFont10_352 = PDFFunctions.ArialFont10;
            XSolidBrush black372 = XBrushes.Black;
            double num1099 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point543 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num1100 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect539 = new XRect(50.0, num1099, point543, num1100);
            XStringFormat topLeft539 = XStringFormat.TopLeft;
            xgraphics539.DrawString("Solar water heating", arialFont10_352, (XBrush) black372, xrect539, topLeft539);
            checked { L1ACheckList.RC1 += 13; }
            L1ACheckList.SpecialFeatureFound = true;
          }
          // ISSUE: reference to a compiler-generated field
          if ((uint) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].SecHeating.SAPTableCode > 0U)
          {
            XGraphics xgraphics540 = PDFFunctions.gfx[L1ACheckList.k];
            // ISSUE: reference to a compiler-generated field
            string str167 = "Secondary heating (" + SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].SecHeating.Fuel + ")";
            XFont arialFont10_353 = PDFFunctions.ArialFont10;
            XSolidBrush black373 = XBrushes.Black;
            double num1101 = (double) checked (L1ACheckList.RC1 + 1);
            xunit = PDFFunctions.pages[L1ACheckList.k].Width;
            double point544 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[L1ACheckList.k].Height;
            double num1102 = ((XUnit) ref xunit).Point / 2.0;
            XRect xrect540 = new XRect(50.0, num1101, point544, num1102);
            XStringFormat topLeft540 = XStringFormat.TopLeft;
            xgraphics540.DrawString(str167, arialFont10_353, (XBrush) black373, xrect540, topLeft540);
            L1ACheckList.SpecialFeatureFound = true;
            checked { L1ACheckList.RC1 += 13; }
          }
          // ISSUE: reference to a compiler-generated field
          string fuel10 = SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].SecHeating.Fuel;
          // ISSUE: reference to a compiler-generated method
          switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(fuel10))
          {
            case 335024745:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel10, "heat from boilers – biogas", false) == 0)
                break;
              goto default;
            case 575487477:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel10, "wood pellets (bulk supply in bags, for main heating)", false) == 0)
                break;
              goto default;
            case 664172296:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel10, "heat from CHP", false) == 0)
                break;
              goto default;
            case 721524493:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel10, "dual fuel appliance (mineral and wood)", false) == 0)
                break;
              goto default;
            case 1424221758:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel10, "geothermal heat source", false) == 0)
                break;
              goto default;
            case 1522447619:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel10, "wood chips", false) == 0)
                break;
              goto default;
            case 1946790875:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel10, "wood logs", false) == 0)
                break;
              goto default;
            case 2251322125:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel10, "wood pellets (in bags, for secondary heating)", false) == 0)
                break;
              goto default;
            case 2340757125:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel10, "heat from boilers - waste combustion", false) == 0)
                break;
              goto default;
            case 2343415715:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel10, "waste heat from power stations", false) == 0)
                break;
              goto default;
            case 2442528761:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel10, "heat from heat pump", false) == 0)
                break;
              goto default;
            case 3198893402:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel10, "rapeseed oil", false) == 0)
                break;
              goto default;
            case 3216529428:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel10, "heat from boilers – biomass", false) == 0)
                break;
              goto default;
            case 3349323758:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel10, "biodiesel from any biomass source", false) == 0)
                break;
              goto default;
            case 4235694608:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fuel10, "biodiesel from used cooking oil only", false) == 0)
                break;
              goto default;
            default:
label_1326:
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              if (!string.IsNullOrEmpty(SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Water.Fuel) && SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Water.SystemRef == 950 && SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Water.Fuel.Contains("heat from"))
              {
                XGraphics xgraphics541 = PDFFunctions.gfx[L1ACheckList.k];
                // ISSUE: reference to a compiler-generated field
                string str168 = "Community water heating, " + SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Water.Fuel;
                XFont arialFont10_354 = PDFFunctions.ArialFont10;
                XSolidBrush black374 = XBrushes.Black;
                double num1103 = (double) checked (L1ACheckList.RC1 + 1);
                xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                double point545 = ((XUnit) ref xunit).Point;
                xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                double num1104 = ((XUnit) ref xunit).Point / 2.0;
                XRect xrect541 = new XRect(50.0, num1103, point545, num1104);
                XStringFormat topLeft541 = XStringFormat.TopLeft;
                xgraphics541.DrawString(str168, arialFont10_354, (XBrush) black374, xrect541, topLeft541);
                checked { L1ACheckList.RC1 += 13; }
                L1ACheckList.SpecialFeatureFound = true;
              }
              if (!L1ACheckList.SpecialFeatureFound)
              {
                XGraphics xgraphics542 = PDFFunctions.gfx[L1ACheckList.k];
                XFont arialFont10_355 = PDFFunctions.ArialFont10;
                XSolidBrush black375 = XBrushes.Black;
                double num1105 = (double) checked (L1ACheckList.RC1 + 1);
                xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                double point546 = ((XUnit) ref xunit).Point;
                xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                double num1106 = ((XUnit) ref xunit).Point / 2.0;
                XRect xrect542 = new XRect(370.0, num1105, point546, num1106);
                XStringFormat topLeft542 = XStringFormat.TopLeft;
                xgraphics542.DrawString("None", arialFont10_355, (XBrush) black375, xrect542, topLeft542);
                checked { L1ACheckList.RC1 += 13; }
              }
              int k = L1ACheckList.k;
              int index17 = 0;
              while (index17 <= k)
              {
                if (!SAP_Module.Proj.OverRide)
                {
                  XGraphics xgraphics543 = PDFFunctions.gfx[index17];
                  string str169 = "Stroma FSAP 2012 " + SAP_Module.CurrVersion + " (SAP 9.92) - http://www.stroma.com";
                  XFont arialFont8 = PDFFunctions.ArialFont8;
                  XSolidBrush black376 = XBrushes.Black;
                  xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                  double point547 = ((XUnit) ref xunit).Point;
                  xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                  double point548 = ((XUnit) ref xunit).Point;
                  XRect xrect543 = new XRect(20.0, 820.0, point547, point548);
                  XStringFormat topLeft543 = XStringFormat.TopLeft;
                  xgraphics543.DrawString(str169, arialFont8, (XBrush) black376, xrect543, topLeft543);
                }
                else
                {
                  XGraphics xgraphics544 = PDFFunctions.gfx[index17];
                  string str170 = "Stroma FSAP 2012 " + SAP_Module.Proj.CalcVersion + " (SAP 9.92) - http://www.stroma.com";
                  XFont arialFont8 = PDFFunctions.ArialFont8;
                  XSolidBrush black377 = XBrushes.Black;
                  xunit = PDFFunctions.pages[L1ACheckList.k].Width;
                  double point549 = ((XUnit) ref xunit).Point;
                  xunit = PDFFunctions.pages[L1ACheckList.k].Height;
                  double point550 = ((XUnit) ref xunit).Point;
                  XRect xrect544 = new XRect(20.0, 820.0, point549, point550);
                  XStringFormat topLeft544 = XStringFormat.TopLeft;
                  xgraphics544.DrawString(str170, arialFont8, (XBrush) black377, xrect544, topLeft544);
                }
                XGraphics xgraphics545 = PDFFunctions.gfx[index17];
                string str171 = "Page " + Conversions.ToString(checked (index17 + 1)) + " of " + Conversions.ToString(checked (L1ACheckList.k + 1));
                XFont arialFont8_1 = PDFFunctions.ArialFont8;
                XSolidBrush black378 = XBrushes.Black;
                xunit = PDFFunctions.pages[index17].Width;
                double point551 = ((XUnit) ref xunit).Point;
                xunit = PDFFunctions.pages[index17].Height;
                double point552 = ((XUnit) ref xunit).Point;
                XRect xrect545 = new XRect(520.0, 820.0, point551, point552);
                XStringFormat topLeft545 = XStringFormat.TopLeft;
                xgraphics545.DrawString(str171, arialFont8_1, (XBrush) black378, xrect545, topLeft545);
                checked { ++index17; }
              }
              L1ACheckList.CheckCheckListRC1();
              SAP_Module.SAPCheckListName = "";
              object folderPath = (object) Environment.GetFolderPath(Environment.SpecialFolder.Personal);
              DirectoryInfo directoryInfo1 = new DirectoryInfo(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(folderPath, (object) "\\Stroma SAP 2012")));
              DirectoryInfo directoryInfo2 = new DirectoryInfo(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(folderPath, (object) "\\Stroma SAP 2012\\"), (object) SAP_Module.Proj.Name)));
              // ISSUE: reference to a compiler-generated field
              DirectoryInfo directoryInfo3 = new DirectoryInfo(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(folderPath, (object) "\\Stroma SAP 2012\\"), (object) SAP_Module.Proj.Name), (object) "\\"), (object) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Name)));
              if (!directoryInfo3.Exists)
                directoryInfo3.Create();
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              SAP_Module.SAPCheckListName = !(Validation.UserLogged & !L1ACheckList.SAP09DataOperation) ? Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(folderPath, (object) "\\Stroma SAP 2012\\"), (object) SAP_Module.Proj.Name), (object) "\\"), (object) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Name), (object) "\\"), (object) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Name), (object) "-SAP Checklist"), (object) ".pdf")) : Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(folderPath, (object) "\\Stroma SAP 2012\\"), (object) SAP_Module.Proj.Name), (object) "\\"), (object) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Name), (object) "\\"), (object) SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Name), (object) "-SAP Checklist with Draft"), (object) ".pdf"));
              if (File.Exists(SAP_Module.SAPCheckListName))
                File.Delete(SAP_Module.SAPCheckListName);
              PDFFunctions.document.Save(SAP_Module.SAPCheckListName);
              flag2 = false;
              L1ACheckList.CPSUFound = false;
              L1ACheckList.CylinderFound = false;
              L1ACheckList.CPSU = false;
              flag7 = false;
              L1ACheckList.SpecialFeatureFound = false;
              flag12 = false;
              L1ACheckList.CommFeature_found = false;
              return;
          }
          XGraphics xgraphics546 = PDFFunctions.gfx[L1ACheckList.k];
          // ISSUE: reference to a compiler-generated field
          string str172 = "Secondary heating fuel  " + SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].SecHeating.Fuel;
          XFont arialFont10_356 = PDFFunctions.ArialFont10;
          XSolidBrush black379 = XBrushes.Black;
          double num1107 = (double) checked (L1ACheckList.RC1 + 1);
          xunit = PDFFunctions.pages[L1ACheckList.k].Width;
          double point553 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[L1ACheckList.k].Height;
          double num1108 = ((XUnit) ref xunit).Point / 2.0;
          XRect xrect546 = new XRect(50.0, num1107, point553, num1108);
          XStringFormat topLeft546 = XStringFormat.TopLeft;
          xgraphics546.DrawString(str172, arialFont10_356, (XBrush) black379, xrect546, topLeft546);
          checked { L1ACheckList.RC1 += 13; }
          L1ACheckList.SpecialFeatureFound = true;
          goto label_1326;
      }
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      if (SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.SAPTableCode > 304 & SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.SAPTableCode < 311)
      {
        // ISSUE: reference to a compiler-generated field
        switch (SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].Water.SystemRef)
        {
        }
      }
      else
      {
        XGraphics xgraphics547 = PDFFunctions.gfx[L1ACheckList.k];
        // ISSUE: reference to a compiler-generated field
        string str173 = "Main heating fuel  " + SAP_Module.Proj.Dwellings[closure260_2.\u0024VB\u0024Local_House].MainHeating.Fuel;
        XFont arialFont10_357 = PDFFunctions.ArialFont10;
        XSolidBrush black380 = XBrushes.Black;
        double num1109 = (double) checked (L1ACheckList.RC1 + 1);
        xunit = PDFFunctions.pages[L1ACheckList.k].Width;
        double point554 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[L1ACheckList.k].Height;
        double num1110 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect547 = new XRect(50.0, num1109, point554, num1110);
        XStringFormat topLeft547 = XStringFormat.TopLeft;
        xgraphics547.DrawString(str173, arialFont10_357, (XBrush) black380, xrect547, topLeft547);
      }
      checked { L1ACheckList.RC1 += 13; }
      L1ACheckList.SpecialFeatureFound = true;
      goto label_1299;
    }

    private static void DrawTable(int RC1, int k, int RM, int T_Count)
    {
      int num1 = checked (T_Count - 1);
      int num2 = 0;
      while (num2 <= num1)
      {
        checked { RC1 += 40; }
        PDFFunctions.Points[0].X = 20f;
        PDFFunctions.Points[0].Y = (float) RC1;
        ref PointF local1 = ref PDFFunctions.Points[1];
        XUnit width1 = PDFFunctions.pages[k].Width;
        double num3 = ((XUnit) ref width1).Point - 20.0;
        local1.X = (float) num3;
        PDFFunctions.Points[1].Y = (float) RC1;
        ref PointF local2 = ref PDFFunctions.Points[2];
        XUnit width2 = PDFFunctions.pages[k].Width;
        double num4 = ((XUnit) ref width2).Point - 20.0;
        local2.X = (float) num4;
        PDFFunctions.Points[2].Y = (float) checked (RC1 + 40);
        PDFFunctions.Points[3].X = 20f;
        PDFFunctions.Points[3].Y = (float) checked (RC1 + 40);
        if (num2 == 0)
        {
          PDFFunctions.xBrush1 = XBrush.op_Implicit((Brush) new SolidBrush(Color.FromArgb(218, 228, 239)));
          PDFFunctions.gfx[k].DrawPolygon(PDFFunctions.BluePen, PDFFunctions.xBrush1, PDFFunctions.Points, PDFFunctions.Fill);
        }
        else
          PDFFunctions.xBrush1 = XBrush.op_Implicit((Brush) new SolidBrush(Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue)));
        PDFFunctions.gfx[k].DrawPolygon(PDFFunctions.BluePen, PDFFunctions.xBrush1, PDFFunctions.Points, PDFFunctions.Fill);
        checked { ++num2; }
      }
      PDFFunctions.gfx[k].DrawLine(PDFFunctions.BluePen, new XPoint(55.0, (double) checked (RM + 40)), new XPoint(55.0, (double) checked (RC1 + 40)));
      PDFFunctions.gfx[k].DrawLine(PDFFunctions.BluePen, new XPoint(230.0, (double) checked (RM + 40)), new XPoint(230.0, (double) checked (RC1 + 40)));
      PDFFunctions.gfx[k].DrawLine(PDFFunctions.BluePen, new XPoint(420.0, (double) checked (RM + 40)), new XPoint(420.0, (double) checked (RC1 + 40)));
      PDFFunctions.gfx[k].DrawLine(PDFFunctions.BluePen, new XPoint(530.0, (double) checked (RM + 40)), new XPoint(530.0, (double) checked (RC1 + 40)));
    }

    private static void CheckCheckListRC1()
    {
      if (L1ACheckList.RC1 < 700)
        return;
      L1ACheckList.CreateCheckListNewPage();
    }

    private static void CreateCheckListNewPage()
    {
      checked { ++L1ACheckList.k; }
      PDFFunctions.pages[L1ACheckList.k] = PDFFunctions.document.AddPage();
      PDFFunctions.gfx[L1ACheckList.k] = XGraphics.FromPdfPage(PDFFunctions.pages[L1ACheckList.k]);
      XSize xsize = PDFFunctions.gfx[L1ACheckList.k].PageSize;
      double num1 = ((XSize) ref xsize).Width / 2.0;
      xsize = PDFFunctions.gfx[L1ACheckList.k].MeasureString("SAP 2012 Overheating Assessment", PDFFunctions.ArialFont16Bold);
      double num2 = ((XSize) ref xsize).Width / 2.0;
      int num3 = checked ((int) Math.Round(unchecked (num1 - num2)));
      XGraphics xgraphics1 = PDFFunctions.gfx[L1ACheckList.k];
      XFont arialFont16Bold = PDFFunctions.ArialFont16Bold;
      XSolidBrush black = XBrushes.Black;
      double num4 = (double) num3;
      XUnit xunit = PDFFunctions.pages[L1ACheckList.k].Width;
      double point1 = ((XUnit) ref xunit).Point;
      xunit = PDFFunctions.pages[L1ACheckList.k].Height;
      double num5 = ((XUnit) ref xunit).Point / 2.0;
      XRect xrect1 = new XRect(num4, 30.0, point1, num5);
      XStringFormat topLeft = XStringFormat.TopLeft;
      xgraphics1.DrawString("Regulations Compliance Report", arialFont16Bold, (XBrush) black, xrect1, topLeft);
      if (!Validation.UserLogged)
      {
        XGraphics xgraphics2 = PDFFunctions.gfx[L1ACheckList.k];
        XFont draftArialFont200 = PDFFunctions.DraftArialFont200;
        XBrush transbrush = PDFFunctions.transbrush;
        XUnit width = PDFFunctions.pages[L1ACheckList.k].Width;
        double point2 = ((XUnit) ref width).Point;
        XUnit height = PDFFunctions.pages[L1ACheckList.k].Height;
        double point3 = ((XUnit) ref height).Point;
        XRect xrect2 = new XRect(0.0, 0.0, point2, point3);
        XStringFormat center = XStringFormat.Center;
        xgraphics2.DrawString("DRAFT", draftArialFont200, transbrush, xrect2, center);
      }
      if (!L1ACheckList.SAP09DataOperation)
      {
        XGraphics xgraphics3 = PDFFunctions.gfx[L1ACheckList.k];
        XFont draftArialFont200 = PDFFunctions.DraftArialFont200;
        XBrush transbrush = PDFFunctions.transbrush;
        XUnit width = PDFFunctions.pages[L1ACheckList.k].Width;
        double point4 = ((XUnit) ref width).Point;
        XUnit height = PDFFunctions.pages[L1ACheckList.k].Height;
        double point5 = ((XUnit) ref height).Point;
        XRect xrect3 = new XRect(0.0, 0.0, point4, point5);
        XStringFormat center = XStringFormat.Center;
        xgraphics3.DrawString("DRAFT", draftArialFont200, transbrush, xrect3, center);
      }
      string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\Stroma SAP 2012\\";
      if (!Directory.Exists(path))
        Directory.CreateDirectory(path);
      if (File.Exists(path + "Logo.jpg"))
      {
        Image image = Image.FromFile(path + "Logo.jpg");
        int num6;
        int num7;
        int num8;
        int num9;
        if ((double) image.Width / (double) image.Height > 5.0 / 3.0)
        {
          num6 = 475;
          num7 = 100;
          num8 = checked ((int) Math.Round((double) L1ACheckList.ImageY));
          num9 = checked ((int) Math.Round(unchecked ((double) checked (image.Height * 100) / (double) image.Width)));
        }
        else
        {
          num8 = checked ((int) Math.Round((double) L1ACheckList.ImageY));
          num9 = 60;
          num6 = checked ((int) Math.Round(unchecked (575.0 - (double) image.Width / (double) image.Height * 60.0)));
          num7 = checked ((int) Math.Round(unchecked ((double) image.Width / (double) image.Height * 60.0)));
        }
        PDFFunctions.gfx[L1ACheckList.k].DrawImage(XImage.op_Implicit(image), num6, num8, num7, num9);
        image.Dispose();
      }
      if (UserSettings.USettings.PrintUserSettings.Print)
        PDFFunctions.PrintUserDetails(PDFFunctions.gfx[L1ACheckList.k]);
      L1ACheckList.RC1 = 70;
    }

    private static double CheckVolfactor(double value) => Math.Pow(120.0 / value, 1.0 / 3.0);

    public static string SaveInput_AND_ComplinaceDetails(int house)
    {
      string str1 = "";
      SAP2012.SAP09Data.Dwelling Dwell = new SAP2012.SAP09Data.Dwelling();
      Dwell.Address = new SAP2012.SAP09Data.Address();
      try
      {
        Dwell.Client = new SAP2012.SAP09Data.Client();
        Dwell.Client.Address = new SAP2012.SAP09Data.Address();
        Dwell.Client.Name = SAP_Module.Proj.Client.Name;
        Dwell.Client.Phone = SAP_Module.Proj.Client.Phone;
        Dwell.Client.Address.Line1 = SAP_Module.Proj.Client.Address.Line1;
        Dwell.Client.Address.Line2 = SAP_Module.Proj.Client.Address.Line2;
        Dwell.Client.Address.Line3 = SAP_Module.Proj.Client.Address.Line3;
        Dwell.Client.Address.City = SAP_Module.Proj.Client.Address.City;
        Dwell.Client.Address.PostCost = SAP_Module.Proj.Client.Address.PostCost;
        Dwell.ProjectAddress = new SAP2012.SAP09Data.Address();
        Dwell.ProjectAddress.Line1 = SAP_Module.Proj.Address.Line1;
        Dwell.ProjectAddress.Line2 = SAP_Module.Proj.Address.Line2;
        Dwell.ProjectAddress.Line3 = SAP_Module.Proj.Address.Line3;
        Dwell.ProjectAddress.City = SAP_Module.Proj.Address.City;
        Dwell.ProjectAddress.PostCost = SAP_Module.Proj.Address.PostCost;
        Dwell.ProjectAddress.Country = SAP_Module.Proj.Address.Country;
        Dwell.Address.Line1 = SAP_Module.Proj.Dwellings[house].Address.Line1;
        Dwell.Address.Line2 = SAP_Module.Proj.Dwellings[house].Address.Line2;
        Dwell.Address.Line3 = SAP_Module.Proj.Dwellings[house].Address.Line3;
        Dwell.Address.City = SAP_Module.Proj.Dwellings[house].Address.City;
        Dwell.Address.Country = SAP_Module.Proj.Dwellings[house].Address.Country;
        Dwell.Address.PostCost = SAP_Module.Proj.Dwellings[house].Address.PostCost;
        Dwell.Reference = SAP_Module.Proj.Dwellings[house].Reference;
        Dwell.PropertyType = SAP_Module.Proj.Dwellings[house].PropertyType;
        Dwell.Name = SAP_Module.Proj.Dwellings[house].Name;
        Dwell.Status = SAP_Module.Proj.Dwellings[house].Status;
        Dwell.BuildForm = SAP_Module.Proj.Dwellings[house].BuildForm;
        Dwell.Location = SAP_Module.Proj.Dwellings[house].Location;
        Dwell.Orientation = SAP_Module.Proj.Dwellings[house].Orientation;
        Dwell.Overshading = SAP_Module.Proj.Dwellings[house].Overshading;
        Dwell.Overheat = SAP_Module.Proj.Dwellings[house].Overheat;
        Dwell.Transaction = SAP_Module.Proj.Dwellings[house].Transaction;
        Dwell.DateAssessment = SAP_Module.Proj.Dwellings[house].DateAssessment;
        Dwell.Transaction = SAP_Module.Proj.Dwellings[house].Transaction;
        Dwell.Storeys = SAP_Module.Proj.Dwellings[house].Storeys;
        Dwell.LivingArea = SAP_Module.Proj.Dwellings[house].LivingArea;
        Dwell.LivingFraction = SAP_Module.Proj.Dwellings[house].LivingFraction;
        Dwell.TrueRoof = SAP_Module.Proj.Dwellings[house].TrueRoof;
        if (SAP_Module.Proj.Dwellings[house].NoofWalls > 0)
        {
          Dwell.NoofWalls = SAP_Module.Proj.Dwellings[house].NoofWalls;
          Dwell.Walls = new SAP2012.SAP09Data.Opaques[checked (SAP_Module.Proj.Dwellings[house].NoofWalls - 1 + 1)];
          int num = checked (SAP_Module.Proj.Dwellings[house].NoofWalls - 1);
          int index = 0;
          while (index <= num)
          {
            Dwell.Walls[index] = new SAP2012.SAP09Data.Opaques();
            Dwell.Walls[index].Name = SAP_Module.Proj.Dwellings[house].Walls[index].Name;
            Dwell.Walls[index].Type = SAP_Module.Proj.Dwellings[house].Walls[index].Type;
            Dwell.Walls[index].Construction = SAP_Module.Proj.Dwellings[house].Walls[index].Construction;
            Dwell.Walls[index].Area = SAP_Module.Proj.Dwellings[house].Walls[index].Area;
            Dwell.Walls[index].U_Value = SAP_Module.Proj.Dwellings[house].Walls[index].U_Value;
            Dwell.Walls[index].K = SAP_Module.Proj.Dwellings[house].Walls[index].K;
            Dwell.Walls[index].UValueSelected = SAP_Module.Proj.Dwellings[house].Walls[index].UValueSelected;
            Dwell.Walls[index].Ru = SAP_Module.Proj.Dwellings[house].Walls[index].Ru;
            checked { ++index; }
          }
        }
        if (SAP_Module.Proj.Dwellings[house].NoofRoofs > 0)
        {
          Dwell.NoofRoofs = SAP_Module.Proj.Dwellings[house].NoofRoofs;
          Dwell.Roofs = new SAP2012.SAP09Data.Opaques[checked (SAP_Module.Proj.Dwellings[house].NoofRoofs - 1 + 1)];
          int num = checked (SAP_Module.Proj.Dwellings[house].NoofRoofs - 1);
          int index = 0;
          while (index <= num)
          {
            Dwell.Roofs[index] = new SAP2012.SAP09Data.Opaques();
            Dwell.Roofs[index].Name = SAP_Module.Proj.Dwellings[house].Roofs[index].Name;
            Dwell.Roofs[index].Type = SAP_Module.Proj.Dwellings[house].Roofs[index].Type;
            Dwell.Roofs[index].Construction = SAP_Module.Proj.Dwellings[house].Roofs[index].Construction;
            Dwell.Roofs[index].Area = SAP_Module.Proj.Dwellings[house].Roofs[index].Area;
            Dwell.Roofs[index].U_Value = SAP_Module.Proj.Dwellings[house].Roofs[index].U_Value;
            Dwell.Roofs[index].K = SAP_Module.Proj.Dwellings[house].Roofs[index].K;
            Dwell.Roofs[index].UValueSelected = SAP_Module.Proj.Dwellings[house].Roofs[index].UValueSelected;
            Dwell.Roofs[index].Ru = SAP_Module.Proj.Dwellings[house].Roofs[index].Ru;
            checked { ++index; }
          }
        }
        if (SAP_Module.Proj.Dwellings[house].NoofFloors > 0)
        {
          Dwell.NoofFloors = SAP_Module.Proj.Dwellings[house].NoofFloors;
          Dwell.Floors = new SAP2012.SAP09Data.Opaques[checked (SAP_Module.Proj.Dwellings[house].NoofFloors - 1 + 1)];
          int num = checked (SAP_Module.Proj.Dwellings[house].NoofFloors - 1);
          int index = 0;
          while (index <= num)
          {
            Dwell.Floors[index] = new SAP2012.SAP09Data.Opaques();
            Dwell.Floors[index].Name = SAP_Module.Proj.Dwellings[house].Floors[index].Name;
            Dwell.Floors[index].Type = SAP_Module.Proj.Dwellings[house].Floors[index].Type;
            Dwell.Floors[index].Construction = SAP_Module.Proj.Dwellings[house].Floors[index].Construction;
            Dwell.Floors[index].Area = SAP_Module.Proj.Dwellings[house].Floors[index].Area;
            Dwell.Floors[index].U_Value = SAP_Module.Proj.Dwellings[house].Floors[index].U_Value;
            Dwell.Floors[index].K = SAP_Module.Proj.Dwellings[house].Floors[index].K;
            Dwell.Floors[index].UValueSelected = SAP_Module.Proj.Dwellings[house].Floors[index].UValueSelected;
            Dwell.Floors[index].Ru = SAP_Module.Proj.Dwellings[house].Floors[index].Ru;
            checked { ++index; }
          }
        }
        if (SAP_Module.Proj.Dwellings[house].NoofPWalls > 0)
        {
          Dwell.NoofPWalls = SAP_Module.Proj.Dwellings[house].NoofPWalls;
          Dwell.PWalls = new SAP2012.SAP09Data.PartyWall[checked (SAP_Module.Proj.Dwellings[house].NoofPWalls - 1 + 1)];
          int num = checked (SAP_Module.Proj.Dwellings[house].NoofPWalls - 1);
          int index = 0;
          while (index <= num)
          {
            Dwell.PWalls[index] = new SAP2012.SAP09Data.PartyWall();
            Dwell.PWalls[index].Name = SAP_Module.Proj.Dwellings[house].PWalls[index].Name;
            Dwell.PWalls[index].Type = SAP_Module.Proj.Dwellings[house].PWalls[index].Type;
            Dwell.PWalls[index].Construction = SAP_Module.Proj.Dwellings[house].PWalls[index].Construction;
            Dwell.PWalls[index].Area = SAP_Module.Proj.Dwellings[house].PWalls[index].Area;
            Dwell.PWalls[index].U_Value = SAP_Module.Proj.Dwellings[house].PWalls[index].U_Value;
            Dwell.PWalls[index].K = SAP_Module.Proj.Dwellings[house].PWalls[index].K;
            checked { ++index; }
          }
        }
        if (SAP_Module.Proj.Dwellings[house].Storeys > 0)
        {
          Dwell.Storeys = SAP_Module.Proj.Dwellings[house].Storeys;
          Dwell.Dims = new SAP2012.SAP09Data.Dimensions[checked (SAP_Module.Proj.Dwellings[house].Storeys - 1 + 1)];
          int num = checked (SAP_Module.Proj.Dwellings[house].Dims.Length - 1);
          int index = 0;
          while (index <= num)
          {
            Dwell.Dims[index] = new SAP2012.SAP09Data.Dimensions();
            Dwell.Dims[index].Basement = SAP_Module.Proj.Dwellings[house].Dims[index].Basement;
            Dwell.Dims[index].Area = SAP_Module.Proj.Dwellings[house].Dims[index].Area;
            Dwell.Dims[index].Height = SAP_Module.Proj.Dwellings[house].Dims[index].Height;
            checked { ++index; }
          }
        }
        Dwell.Renewable = new SAP2012.SAP09Data.ReNewable();
        if (!(SAP_Module.Proj.Dwellings[house].Renewable.Photovoltaic.Inlcude | SAP_Module.Proj.Dwellings[house].Renewable.WindTurbine.Inlcude | SAP_Module.Proj.Dwellings[house].Renewable.Special.Include | SAP_Module.Proj.Dwellings[house].Renewable.AAEGeneration.Inlcude))
          ;
        Dwell.Renewable.WindTurbine = new SAP2012.SAP09Data.WindTurbine();
        if (SAP_Module.Proj.Dwellings[house].Renewable.WindTurbine.Inlcude)
        {
          Dwell.Renewable.WindTurbine.Inlcude = SAP_Module.Proj.Dwellings[house].Renewable.WindTurbine.Inlcude;
          Dwell.Renewable.WindTurbine.WNumber = SAP_Module.Proj.Dwellings[house].Renewable.WindTurbine.WNumber;
          Dwell.Renewable.WindTurbine.WRDiameter = SAP_Module.Proj.Dwellings[house].Renewable.WindTurbine.WRDiameter;
          Dwell.Renewable.WindTurbine.WHeight = SAP_Module.Proj.Dwellings[house].Renewable.WindTurbine.WHeight;
        }
        Dwell.Renewable.AAEGeneration = new SAP2012.SAP09Data.AAEGeneration();
        if (SAP_Module.Proj.Dwellings[house].Renewable.AAEGeneration.Inlcude)
        {
          Dwell.Renewable.AAEGeneration.Inlcude = SAP_Module.Proj.Dwellings[house].Renewable.AAEGeneration.Inlcude;
          Dwell.Renewable.AAEGeneration.EGenerated = SAP_Module.Proj.Dwellings[house].Renewable.AAEGeneration.EGenerated;
          Dwell.Renewable.AAEGeneration.TotalArea = SAP_Module.Proj.Dwellings[house].Renewable.AAEGeneration.TotalArea;
        }
        Dwell.Renewable.Photovoltaic = new SAP2012.SAP09Data.Photovoltaic();
        if (SAP_Module.Proj.Dwellings[house].Renewable.Photovoltaic.Inlcude)
        {
          Dwell.Renewable.Photovoltaic.Photovoltaics = new SAP2012.SAP09Data.PhotoVoltaics[checked (SAP_Module.Proj.Dwellings[house].Renewable.Photovoltaic.Photovoltaics.Length - 1 + 1)];
          int num = checked (SAP_Module.Proj.Dwellings[house].Renewable.Photovoltaic.Photovoltaics.Length - 1);
          int index = 0;
          while (index <= num)
          {
            Dwell.Renewable.Photovoltaic.Photovoltaics[index] = new SAP2012.SAP09Data.PhotoVoltaics();
            Dwell.Renewable.Photovoltaic.Inlcude = SAP_Module.Proj.Dwellings[house].Renewable.Photovoltaic.Inlcude;
            Dwell.Renewable.Photovoltaic.Photovoltaics[index].PPower = SAP_Module.Proj.Dwellings[house].Renewable.Photovoltaic.Photovoltaics[index].PPower;
            Dwell.Renewable.Photovoltaic.Photovoltaics[index].PTilt = SAP_Module.Proj.Dwellings[house].Renewable.Photovoltaic.Photovoltaics[index].PTilt;
            Dwell.Renewable.Photovoltaic.Photovoltaics[index].PCOrientation = SAP_Module.Proj.Dwellings[house].Renewable.Photovoltaic.Photovoltaics[index].PCOrientation;
            Dwell.Renewable.Photovoltaic.Photovoltaics[index].POvershading = SAP_Module.Proj.Dwellings[house].Renewable.Photovoltaic.Photovoltaics[index].POvershading;
            checked { ++index; }
          }
        }
        Dwell.Renewable.Special = new SAP2012.SAP09Data.Special();
        if (SAP_Module.Proj.Dwellings[house].Renewable.Special.Include)
        {
          Dwell.Renewable.Special.Include = SAP_Module.Proj.Dwellings[house].Renewable.Special.Include;
          Dwell.Renewable.Special.SpecialMember = new SAP2012.SAP09Data.SpecialFeatures[checked (SAP_Module.Proj.Dwellings[house].Renewable.Special.Special.Length - 1 + 1)];
          int num1 = checked (SAP_Module.Proj.Dwellings[house].Renewable.Special.Special.Length - 1);
          int index1 = 0;
          while (index1 <= num1)
          {
            Dwell.Renewable.Special.SpecialMember[index1] = new SAP2012.SAP09Data.SpecialFeatures();
            Dwell.Renewable.Special.SpecialMember[index1].Description = SAP_Module.Proj.Dwellings[house].Renewable.Special.Special[index1].Description;
            Dwell.Renewable.Special.SpecialMember[index1].EnergySaved = SAP_Module.Proj.Dwellings[house].Renewable.Special.Special[index1].EnergySaved;
            Dwell.Renewable.Special.SpecialMember[index1].FuelSaved = SAP_Module.Proj.Dwellings[house].Renewable.Special.Special[index1].FuelSaved;
            Dwell.Renewable.Special.SpecialMember[index1].EnergyUsed = SAP_Module.Proj.Dwellings[house].Renewable.Special.Special[index1].EnergyUsed;
            Dwell.Renewable.Special.SpecialMember[index1].FuelUsed = SAP_Module.Proj.Dwellings[house].Renewable.Special.Special[index1].FuelUsed;
            Dwell.Renewable.Special.SpecialMember[index1].IncludeMonthly = SAP_Module.Proj.Dwellings[house].Renewable.Special.Special[index1].IncludeMonthly;
            if (SAP_Module.Proj.Dwellings[house].Renewable.Special.Special[index1].IncludeMonthly)
            {
              int num2 = checked (SAP_Module.Proj.Dwellings[house].Renewable.Special.Special.Length - 1);
              int index2 = 0;
              while (index2 <= num2)
              {
                Dwell.Renewable.Special.SpecialMember[index2].M1 = SAP_Module.Proj.Dwellings[house].Renewable.Special.Special[index2].M1;
                Dwell.Renewable.Special.SpecialMember[index2].M2 = SAP_Module.Proj.Dwellings[house].Renewable.Special.Special[index2].M2;
                Dwell.Renewable.Special.SpecialMember[index2].M3 = SAP_Module.Proj.Dwellings[house].Renewable.Special.Special[index2].M3;
                Dwell.Renewable.Special.SpecialMember[index2].M4 = SAP_Module.Proj.Dwellings[house].Renewable.Special.Special[index2].M4;
                Dwell.Renewable.Special.SpecialMember[index2].M5 = SAP_Module.Proj.Dwellings[house].Renewable.Special.Special[index2].M5;
                Dwell.Renewable.Special.SpecialMember[index2].M6 = SAP_Module.Proj.Dwellings[house].Renewable.Special.Special[index2].M6;
                Dwell.Renewable.Special.SpecialMember[index2].M7 = SAP_Module.Proj.Dwellings[house].Renewable.Special.Special[index2].M7;
                Dwell.Renewable.Special.SpecialMember[index2].M8 = SAP_Module.Proj.Dwellings[house].Renewable.Special.Special[index2].M8;
                Dwell.Renewable.Special.SpecialMember[index2].M9 = SAP_Module.Proj.Dwellings[house].Renewable.Special.Special[index2].M9;
                Dwell.Renewable.Special.SpecialMember[index2].M10 = SAP_Module.Proj.Dwellings[house].Renewable.Special.Special[index2].M10;
                Dwell.Renewable.Special.SpecialMember[index2].M11 = SAP_Module.Proj.Dwellings[house].Renewable.Special.Special[index2].M11;
                Dwell.Renewable.Special.SpecialMember[index2].M12 = SAP_Module.Proj.Dwellings[house].Renewable.Special.Special[index2].M12;
                checked { ++index2; }
              }
            }
            checked { ++index1; }
          }
        }
        Dwell.NoofDoors = SAP_Module.Proj.Dwellings[house].NoofDoors;
        if (SAP_Module.Proj.Dwellings[house].NoofDoors > 0)
        {
          Dwell.Doors = new SAP2012.SAP09Data.Door[checked (SAP_Module.Proj.Dwellings[house].NoofDoors - 1 + 1)];
          int num = checked (SAP_Module.Proj.Dwellings[house].NoofDoors - 1);
          int index = 0;
          while (index <= num)
          {
            Dwell.Doors[index] = new SAP2012.SAP09Data.Door();
            Dwell.Doors[index].Name = SAP_Module.Proj.Dwellings[house].Doors[index].Name;
            Dwell.Doors[index].Location = SAP_Module.Proj.Dwellings[house].Doors[index].Location;
            Dwell.Doors[index].GlazingType = SAP_Module.Proj.Dwellings[house].Doors[index].GlazingType;
            Dwell.Doors[index].Area = SAP_Module.Proj.Dwellings[house].Doors[index].Area;
            Dwell.Doors[index].Count = SAP_Module.Proj.Dwellings[house].Doors[index].Count;
            Dwell.Doors[index].U = SAP_Module.Proj.Dwellings[house].Doors[index].U;
            Dwell.Doors[index].Orientation = SAP_Module.Proj.Dwellings[house].Doors[index].Orientation;
            Dwell.Doors[index].Overshading = SAP_Module.Proj.Dwellings[house].Doors[index].Overshading;
            Dwell.Doors[index].FF = SAP_Module.Proj.Dwellings[house].Doors[index].FF;
            Dwell.Doors[index].g = SAP_Module.Proj.Dwellings[house].Doors[index].g;
            Dwell.Doors[index].FrameType = SAP_Module.Proj.Dwellings[house].Doors[index].FrameType;
            Dwell.Doors[index].ThermalBreak = SAP_Module.Proj.Dwellings[house].Doors[index].ThermalBreak;
            Dwell.Doors[index].UValueSource = SAP_Module.Proj.Dwellings[house].Doors[index].UValueSource;
            checked { ++index; }
          }
        }
        Dwell.NoofWindows = SAP_Module.Proj.Dwellings[house].NoofWindows;
        if (SAP_Module.Proj.Dwellings[house].NoofWindows > 0)
        {
          Dwell.Windows = new SAP2012.SAP09Data.Window[checked (SAP_Module.Proj.Dwellings[house].NoofWindows - 1 + 1)];
          int num = checked (SAP_Module.Proj.Dwellings[house].NoofWindows - 1);
          int index = 0;
          while (index <= num)
          {
            Dwell.Windows[index] = new SAP2012.SAP09Data.Window();
            Dwell.Windows[index].Location = SAP_Module.Proj.Dwellings[house].Windows[index].Location;
            Dwell.Windows[index].GlazingType = SAP_Module.Proj.Dwellings[house].Windows[index].GlazingType;
            Dwell.Windows[index].Area = SAP_Module.Proj.Dwellings[house].Windows[index].Area;
            Dwell.Windows[index].Count = SAP_Module.Proj.Dwellings[house].Windows[index].Count;
            Dwell.Windows[index].U = SAP_Module.Proj.Dwellings[house].Windows[index].U;
            Dwell.Windows[index].Orientation = SAP_Module.Proj.Dwellings[house].Windows[index].Orientation;
            Dwell.Windows[index].Overshading = SAP_Module.Proj.Dwellings[house].Windows[index].Overshading;
            Dwell.Windows[index].FF = SAP_Module.Proj.Dwellings[house].Windows[index].FF;
            Dwell.Windows[index].g = SAP_Module.Proj.Dwellings[house].Windows[index].g;
            Dwell.Windows[index].FrameType = SAP_Module.Proj.Dwellings[house].Windows[index].FrameType;
            Dwell.Windows[index].ThermalBreak = SAP_Module.Proj.Dwellings[house].Windows[index].ThermalBreak;
            Dwell.Windows[index].UValueSource = SAP_Module.Proj.Dwellings[house].Windows[index].UValueSource;
            checked { ++index; }
          }
        }
        Dwell.NoofRoofLights = SAP_Module.Proj.Dwellings[house].NoofRoofLights;
        if (SAP_Module.Proj.Dwellings[house].NoofRoofLights > 0)
        {
          Dwell.RoofLights = new SAP2012.SAP09Data.RoofLight[checked (SAP_Module.Proj.Dwellings[house].NoofRoofLights - 1 + 1)];
          int num = checked (SAP_Module.Proj.Dwellings[house].NoofRoofLights - 1);
          int index = 0;
          while (index <= num)
          {
            Dwell.RoofLights[index] = new SAP2012.SAP09Data.RoofLight();
            Dwell.RoofLights[index].Location = SAP_Module.Proj.Dwellings[house].RoofLights[index].Location;
            Dwell.RoofLights[index].GlazingType = SAP_Module.Proj.Dwellings[house].RoofLights[index].GlazingType;
            Dwell.RoofLights[index].Area = SAP_Module.Proj.Dwellings[house].RoofLights[index].Area;
            Dwell.RoofLights[index].Count = SAP_Module.Proj.Dwellings[house].RoofLights[index].Count;
            Dwell.RoofLights[index].U = SAP_Module.Proj.Dwellings[house].RoofLights[index].U;
            Dwell.RoofLights[index].Orientation = SAP_Module.Proj.Dwellings[house].RoofLights[index].Orientation;
            Dwell.RoofLights[index].Overshading = SAP_Module.Proj.Dwellings[house].RoofLights[index].Overshading;
            Dwell.RoofLights[index].FF = SAP_Module.Proj.Dwellings[house].RoofLights[index].FF;
            Dwell.RoofLights[index].g = SAP_Module.Proj.Dwellings[house].RoofLights[index].g;
            Dwell.RoofLights[index].FrameType = SAP_Module.Proj.Dwellings[house].RoofLights[index].FrameType;
            Dwell.RoofLights[index].ThermalBreak = SAP_Module.Proj.Dwellings[house].RoofLights[index].ThermalBreak;
            Dwell.RoofLights[index].UValueSource = SAP_Module.Proj.Dwellings[house].RoofLights[index].UValueSource;
            checked { ++index; }
          }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        str1 = "Error at stage 1";
        ProjectData.ClearProjectError();
      }
      SAP09ComplianceSoapClient complianceSoapClient = new SAP09ComplianceSoapClient();
      string InputStr;
      try
      {
        InputStr = complianceSoapClient.SendSAP_details(Dwell, Validation.AssessorNO, "201072951671", "f602e12b8c3558bd50a23b1618a63249");
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        str1 += "\r\nError at stage 2";
        ProjectData.ClearProjectError();
      }
      ComplianceDetails SDetails = new ComplianceDetails();
      try
      {
        SDetails.AddressLine1 = SAP_Module.Proj.Dwellings[house].Address.Line1;
        SDetails.AddressLine2 = SAP_Module.Proj.Dwellings[house].Address.Line2;
        SDetails.AddressLine3 = SAP_Module.Proj.Dwellings[house].Address.Line3;
        SDetails.UserID = Validation.AssessorNO;
        SDetails.Country = SAP_Module.Proj.Dwellings[house].Address.Country;
        SDetails.BuildForm = SAP_Module.Proj.Dwellings[house].BuildForm;
        SDetails.SiteReference = SAP_Module.Proj.Dwellings[house].Name;
        SDetails.PlotReference = SAP_Module.Proj.Dwellings[house].Reference;
        SDetails.City = SAP_Module.Proj.Dwellings[house].Address.City;
        SDetails.Postcode = SAP_Module.Proj.Dwellings[house].Address.PostCost;
        SDetails.ClientName = SAP_Module.Proj.Client.Name;
        SDetails.AddressLine1 = SAP_Module.Proj.Client.Address.Line1;
        SDetails.AddressLine2 = SAP_Module.Proj.Client.Address.Line2;
        SDetails.AddressLine3 = SAP_Module.Proj.Client.Address.Line3;
        SDetails.City = SAP_Module.Proj.Client.Address.City;
        SDetails.Postcode = SAP_Module.Proj.Client.Address.PostCost;
        SDetails.MainHeating_fuel = SAP_Module.Proj.Dwellings[house].MainHeating.Fuel;
        SDetails.DER = Conversions.ToDouble(Microsoft.VisualBasic.Strings.Format((object) Math.Round(L1ACheckList.DERCHeck, 2), "0.00"));
        SDetails.TER = Conversions.ToDouble(Microsoft.VisualBasic.Strings.Format((object) Math.Round(Functions.TER(), 2), "0.00"));
        if (SAP_Module.Proj.Dwellings[house].NoofWalls > 0)
        {
          SDetails.IncludeWall = true;
          SDetails.Wall_Average_U = Conversions.ToDouble(Microsoft.VisualBasic.Strings.Format((object) SAP_Module.Calculation2012._Add_Variable.Averages.Wall_U));
          SDetails.Wall_Highest_U = Conversions.ToDouble(Microsoft.VisualBasic.Strings.Format((object) SAP_Module.Calculation2012._Add_Variable.Highest.Wall_U));
        }
        else
          SDetails.IncludeWall = false;
        if (SAP_Module.Proj.Dwellings[house].NoofPWalls > 0)
        {
          SDetails.IncludePWall = true;
          SDetails.PWall_Average_U = Conversions.ToDouble(Microsoft.VisualBasic.Strings.Format((object) SAP_Module.Calculation2012._Add_Variable.Averages.Party_U, "0.00"));
        }
        else
          SDetails.IncludePWall = false;
        if (SAP_Module.Proj.Dwellings[house].NoofFloors > 0)
        {
          SDetails.IncludeFloors = true;
          SDetails.Floor_Average_U = Conversions.ToDouble(Microsoft.VisualBasic.Strings.Format((object) SAP_Module.Calculation2012._Add_Variable.Averages.Floor_U));
        }
        else
          SDetails.IncludeFloors = false;
        if (SAP_Module.Proj.Dwellings[house].NoofRoofs > 0)
        {
          SDetails.IncludeRoof = true;
          SDetails.Roof_Average_U = Conversions.ToDouble(Microsoft.VisualBasic.Strings.Format((object) SAP_Module.Calculation2012._Add_Variable.Averages.Roof_U));
        }
        SDetails.IncludeRoof = false;
        if (SAP_Module.Calculation2012._Add_Variable.Averages.CWall_U == 0.0)
        {
          SDetails.Curtainwall_U = 0.0;
          SDetails.IncludeCurtainwall = true;
        }
        else
        {
          SDetails.Curtainwall_U = SAP_Module.Calculation2012._Add_Variable.Averages.CWall_U;
          SDetails.IncludeCurtainwall = false;
        }
        if (SAP_Module.Proj.Dwellings[house].NoofWindows > 0)
        {
          SDetails.IncludeWindows = true;
          SDetails.WindowsAverage_U = Conversions.ToDouble(Microsoft.VisualBasic.Strings.Format((object) SAP_Module.Calculation2012._Add_Variable.Averages.Window_U, "0.00"));
          SDetails.WindowsHighest_U = Conversions.ToDouble(Microsoft.VisualBasic.Strings.Format((object) SAP_Module.Calculation2012._Add_Variable.Highest.Window_U, "0.00"));
        }
        else
          SDetails.IncludeWindows = false;
        SDetails.AirPermeability_DESC = SAP_Module.Proj.Dwellings[house].Ventilation.Pressure;
        SDetails.AirPermeability_AirPermeability_Value = (double) SAP_Module.Proj.Dwellings[house].Ventilation.DesignAir == 0.0 ? ((double) SAP_Module.Proj.Dwellings[house].Ventilation.AssumedAir == 0.0 ? ((double) SAP_Module.Proj.Dwellings[house].Ventilation.MeasuredAir == 0.0 ? 0.0 : Conversions.ToDouble(Microsoft.VisualBasic.Strings.Format((object) SAP_Module.Proj.Dwellings[house].Ventilation.MeasuredAir, "0.00"))) : Conversions.ToDouble(Microsoft.VisualBasic.Strings.Format((object) SAP_Module.Proj.Dwellings[house].Ventilation.AssumedAir, "0.00"))) : Conversions.ToDouble(Microsoft.VisualBasic.Strings.Format((object) SAP_Module.Proj.Dwellings[house].Ventilation.DesignAir, "0.00"));
        if (L1ACheckList.CPSUFound)
          SDetails.CPSUFound = true;
        SDetails.HeatingSource = SAP_Module.Proj.Dwellings[house].MainHeating.InforSource;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].MainHeating.InforSource, "Boiler Database", false) == 0)
          SDetails.SEDBUKCode = SAP_Module.Proj.Dwellings[house].MainHeating.SEDBUK;
        else
          SDetails.SAPCode = Conversions.ToString(SAP_Module.Proj.Dwellings[house].MainHeating.SAPTableCode);
        SDetails.BoilerSGroup = SAP_Module.Proj.Dwellings[house].MainHeating.SGroup;
        SDetails.BoilerHGroup = SAP_Module.Proj.Dwellings[house].MainHeating.HGroup;
        SDetails.MainFuel = SAP_Module.Proj.Dwellings[house].MainHeating.Fuel;
        if (SAP_Module.Proj.Dwellings[house].MainHeating.SEDBUK2005)
          SDetails.SEDBUK2005 = true;
        SDetails.MainEff = (double) SAP_Module.Proj.Dwellings[house].MainHeating.MainEff;
        if (SAP_Module.Proj.Dwellings[house].IncludeMainHeating2)
        {
          SDetails.HeatingSource2 = SAP_Module.Proj.Dwellings[house].MainHeating2.InforSource;
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].MainHeating2.InforSource, "Boiler Database", false) == 0)
            SDetails.SEDBUKCode2 = SAP_Module.Proj.Dwellings[house].MainHeating2.SEDBUK;
          else
            SDetails.SAPCode2 = Conversions.ToString(SAP_Module.Proj.Dwellings[house].MainHeating2.SAPTableCode);
          SDetails.BoilerSGroup2 = SAP_Module.Proj.Dwellings[house].MainHeating2.SGroup;
          SDetails.BoilerHGroup2 = SAP_Module.Proj.Dwellings[house].MainHeating2.HGroup;
          SDetails.MainFuel2 = SAP_Module.Proj.Dwellings[house].MainHeating2.Fuel;
          if (SAP_Module.Proj.Dwellings[house].MainHeating2.SEDBUK2005)
            SDetails.SEDBUK2005_2 = Conversions.ToString(true);
          SDetails.MainEff2 = Conversions.ToString(SAP_Module.Proj.Dwellings[house].MainHeating2.MainEff);
        }
        if (SAP_Module.Proj.Dwellings[house].SecHeating.SAPTableCode == 0)
        {
          SDetails.Include_SecondaryHeating = true;
          SDetails.SecHeating_Fuel = SAP_Module.Proj.Dwellings[house].SecHeating.Fuel;
          SDetails.Sec_SAPTableCode = (double) SAP_Module.Proj.Dwellings[house].SecHeating.SAPTableCode;
          SDetails.SecHeatingEff = (double) SAP_Module.Proj.Dwellings[house].SecHeating.SecEff;
        }
        SDetails.water_SystemRef = SAP_Module.Proj.Dwellings[house].Water.System;
        SDetails.Water_CylinderFound = Conversions.ToString(L1ACheckList.CylinderFound);
        SDetails.Water_CylinderVolume = Conversions.ToString(SAP_Module.Proj.Dwellings[house].Water.Cylinder.Volume);
        SDetails.IncludeWaterThermal = SAP_Module.Proj.Dwellings[house].Water.Thermal.Include;
        SDetails.CylinderValue = Math.Round(L1ACheckList.Cylindercheck, 2);
        SDetails.CylinderValuePermitted = Math.Round(L1ACheckList.CylindercheckOriginal, 2);
        if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Water.Cylinder.Immersion, (string) null, false) > 0U)
          SDetails.WaterCylinderImmersion = true;
        SDetails.WaterFuel = SAP_Module.Proj.Dwellings[house].Water.Fuel;
        if (L1ACheckList.CPSU | SAP_Module.Proj.Dwellings[house].Water.SystemRef == 903)
          SDetails.Primary_pipework_insulated = "No primary pipework";
        else if (!SAP_Module.Proj.Dwellings[house].WaterOnlyHeatPump)
        {
          if (SAP_Module.Proj.Dwellings[house].Water.Cylinder.PipeWorkInsulated)
          {
            SDetails.Primary_pipework_insulated = "Primary pipework insulated";
          }
          else
          {
            int sapTableCode = SAP_Module.Proj.Dwellings[house].MainHeating.SAPTableCode;
            if (sapTableCode >= 305 && sapTableCode <= 310)
              SDetails.Primary_pipework_insulated = "Primary pipework insulated: (Yes assumed)";
            else if (sapTableCode == 408 || sapTableCode == 191 || sapTableCode == 701 || sapTableCode == 694 || sapTableCode == 204)
            {
              SDetails.Primary_pipework_insulated = "No primary pipework";
            }
            else
            {
              string sgroup = SAP_Module.Proj.Dwellings[house].MainHeating.SGroup;
              SDetails.Primary_pipework_insulated = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(sgroup, "Gas boilers and oil boilers", false) == 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(sgroup, "Electric (direct acting) room heaters", false) == 0 ? (SAP_Module.Proj.Dwellings[house].Water.Cylinder.PipeWorkInsulated ? "Primary pipework insulated" : "No primary pipework") : "No primary pipework";
            }
          }
        }
        string pipeworkInsulated = SDetails.Primary_pipework_insulated;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(pipeworkInsulated, "Primary pipework insulated", false) == 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(pipeworkInsulated, "Primary pipework insulated: (Yes assumed)", false) == 0)
          SDetails.InlcudePrimary_Pipework = true;
        SDetails.Include_SolarWater = SAP_Module.Proj.Dwellings[house].Water.Solar.Inlcude;
        if (SDetails.Include_SolarWater)
        {
          SDetails.SolarVolume = (double) SAP_Module.Proj.Dwellings[house].Water.Solar.SolarVolume;
          SDetails.SolarArea = (double) SAP_Module.Proj.Dwellings[house].Water.Solar.SolarArea;
          SDetails.SolarLimit = Math.Round(25.0 * (double) SAP_Module.Proj.Dwellings[house].Water.Solar.SolarArea, 2);
        }
        SDetails.MainHeatingControl = SAP_Module.Proj.Dwellings[house].MainHeating.Controls;
        SDetails.NoofFloors = SAP_Module.Proj.Dwellings[house].NoofFloors;
        SDetails.LivingFraction = (double) SAP_Module.Proj.Dwellings[house].LivingFraction;
        SDetails.FloorArea = (double) SAP_Module.Proj.Dwellings[house].LivingArea;
        if (SAP_Module.Proj.Dwellings[house].IncludeMainHeating2)
        {
          SDetails.IncludeHeatingControl2 = true;
          SDetails.MainHeatingControl2 = SAP_Module.Proj.Dwellings[house].MainHeating2.Controls;
        }
        SDetails.Cylinderstat = L1ACheckList.CylinderFound;
        if (SAP_Module.Proj.Dwellings[house].Water.SystemRef == 901)
        {
          int sapTableCode = SAP_Module.Proj.Dwellings[house].MainHeating.SAPTableCode;
          if (sapTableCode != 191 && (sapTableCode < 631 || sapTableCode > 636) && (sapTableCode < 501 || sapTableCode > 511) && sapTableCode != 525 && sapTableCode != 526 && sapTableCode != 527)
          {
            if (SAP_Module.Proj.Dwellings[house].Water.Cylinder.Timed)
              SDetails.IndependentTimer = true;
            else if (SAP_Module.Proj.Dwellings[house].MainHeating.SAPTableCode == 192)
              SDetails.IndependentTimer = true;
          }
        }
        if (SAP_Module.Proj.Dwellings[house].MainHeating.SAPTableCode < 150)
        {
          if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].MainHeating.SGroup, "Micro-cogeneration (micro-CHP)", false) > 0U & (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].MainHeating.SGroup, "Heat pumps", false) > 0U)
            SDetails.BoilerInterlock = true;
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].MainHeating.Boiler.BILock, "Yes", false) == 0)
            SDetails.BoilerInterlock = true;
        }
        SDetails.LowEnergyLight_Percent = (double) SAP_Module.Proj.Dwellings[house].LELLights;
        SDetails.MechVent = SAP_Module.Proj.Dwellings[house].Ventilation.MechVent;
        try
        {
          if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Ventilation.Parameters, (string) null, false) > 0U)
          {
            SDetails.Vent_Parameters = SAP_Module.Proj.Dwellings[house].Ventilation.Parameters;
            string parameters = SAP_Module.Proj.Dwellings[house].Ventilation.Parameters;
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(parameters, "Database", false) != 0)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(parameters, "SAP 2012", false) != 0)
              {
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(parameters, "User defined", false) == 0)
                  SDetails.Specific_fan_power = Conversions.ToString(SAP_Module.Proj.Dwellings[house].Ventilation.MVDetails.SFP);
              }
              else
                SDetails.Specific_fan_power = Conversions.ToString(0.8);
            }
            else
              SDetails.Specific_fan_power = Conversions.ToString(L1ACheckList.MainVent[0]["SFP"]);
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SDetails.Specific_fan_power, (string) null, false) == 0)
          SDetails.Specific_fan_power = Conversions.ToString(0);
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Overheat, "Yes", false) == 0)
          SDetails.IncludeOverheating = true;
        SDetails.OverHeatingLikelihood = SAP_Module.OverHeat.AppendixP.Likelihood;
        SDetails.HouseLocation = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SDetails.Overshading, SAP_Module.Proj.Dwellings[house].Overshading, false) == 0);
        SDetails.NoofWindows = SAP_Module.Proj.Dwellings[house].NoofWindows;
        SDetails.NoofRoofLights = SAP_Module.Proj.Dwellings[house].NoofRoofLights;
        try
        {
          if (((IEnumerable<SAP_Module.Window>) SAP_Module.Proj.Dwellings[house].Windows).Count<SAP_Module.Window>() > 0)
            SDetails.CurtainType = SAP_Module.Proj.Dwellings[house].Windows[0].CurtainType;
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        SDetails.VentilationRate = Conversions.ToDouble(Microsoft.VisualBasic.Strings.Format((object) SAP_Module.Proj.Dwellings[house].OverHeating.EACAirChange, "0.00"));
        SDetails.NoofRoofLights = SAP_Module.Proj.Dwellings[house].NoofRoofLights;
        if (L1ACheckList.SpecialFeatureFound)
        {
          SDetails.IncludeKeyfeatures = true;
          if (SAP_Module.Calculation2012.Calculation.HeatLoss.Box36 / SAP_Module.Calculation2012.Calculation.HeatLoss.Box31 < 0.03999)
            SDetails.Key_Thermalbridging = true;
          if ((double) SAP_Module.Proj.Dwellings[house].Ventilation.DesignAir < 4.999 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Ventilation.Pressure, "As designed", false) == 0)
            SDetails.Key_DesignAir_permeablility = true;
          if (SAP_Module.Proj.Dwellings[house].Ventilation.AveragePerm)
          {
            if ((double) SAP_Module.Proj.Dwellings[house].Ventilation.MeasuredAir < 2.999 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Ventilation.Pressure, "As built", false) == 0)
              SDetails.Key_DesignAir_permeablility = true;
          }
          else if ((double) SAP_Module.Proj.Dwellings[house].Ventilation.MeasuredAir < 4.999 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].Ventilation.Pressure, "As built", false) == 0)
            SDetails.Key_DesignAir_permeablility = true;
          float[] source1 = new float[0];
          if (SAP_Module.Proj.Dwellings[house].NoofRoofLights > 0)
          {
            int num = checked (((IEnumerable<SAP_Module.RoofLight>) SAP_Module.Proj.Dwellings[house].RoofLights).Count<SAP_Module.RoofLight>() - 1);
            int index = 0;
            while (index <= num)
            {
              if ((double) SAP_Module.Proj.Dwellings[house].RoofLights[index].U < 1.499 & !((IEnumerable<float>) source1).Contains<float>(SAP_Module.Proj.Dwellings[house].RoofLights[index].U))
                SDetails.Key_Roof_Window_U = true;
              checked { ++index; }
            }
          }
          bool flag = false;
          float[] numArray = new float[0];
          if (SAP_Module.Proj.Dwellings[house].NoofWindows > 0)
          {
            int num = checked (((IEnumerable<SAP_Module.Window>) SAP_Module.Proj.Dwellings[house].Windows).Count<SAP_Module.Window>() - 1);
            int index = 0;
            while (index <= num)
            {
              if ((double) SAP_Module.Proj.Dwellings[house].Windows[index].U < 1.499 & !((IEnumerable<float>) numArray).Contains<float>(SAP_Module.Proj.Dwellings[house].Windows[index].U))
              {
                numArray = (float[]) Utils.CopyArray((Array) numArray, (Array) new float[checked (numArray.Length + 1)]);
                numArray[checked (numArray.Length - 1)] = SAP_Module.Proj.Dwellings[house].Windows[index].U;
              }
              checked { ++index; }
            }
          }
          flag = false;
          float[] source2 = new float[0];
          if (SAP_Module.Proj.Dwellings[house].NoofDoors > 0)
          {
            int num = checked (((IEnumerable<SAP_Module.Door>) SAP_Module.Proj.Dwellings[house].Doors).Count<SAP_Module.Door>() - 1);
            int index = 0;
            while (index <= num)
            {
              if ((double) SAP_Module.Proj.Dwellings[house].Doors[index].U < 1.499 & !((IEnumerable<float>) source2).Contains<float>(SAP_Module.Proj.Dwellings[house].Doors[index].U))
                SDetails.Key_Door_U = true;
              checked { ++index; }
            }
          }
          flag = false;
          float[] source3 = new float[0];
          if (SAP_Module.Proj.Dwellings[house].NoofRoofs > 0)
          {
            int num3 = checked (((IEnumerable<SAP_Module.Opaques>) SAP_Module.Proj.Dwellings[house].Roofs).Count<SAP_Module.Opaques>() - 1);
            int index = 0;
            while (index <= num3)
            {
              float num4 = (float) Math.Round(1.0 / (1.0 / (double) SAP_Module.Proj.Dwellings[house].Roofs[index].U_Value + (double) SAP_Module.Proj.Dwellings[house].Roofs[index].Ru), 2);
              if ((double) num4 < 0.1299 & !((IEnumerable<float>) source3).Contains<float>(num4))
                SDetails.Key_Roof_U = true;
              checked { ++index; }
            }
          }
          flag = false;
          float[] source4 = new float[0];
          if (SAP_Module.Proj.Dwellings[house].NoofWalls > 0)
          {
            int num5 = checked (((IEnumerable<SAP_Module.Opaques>) SAP_Module.Proj.Dwellings[house].Walls).Count<SAP_Module.Opaques>() - 1);
            int index = 0;
            while (index <= num5)
            {
              float num6 = (float) Math.Round(1.0 / (1.0 / (double) SAP_Module.Proj.Dwellings[house].Walls[index].U_Value + (double) SAP_Module.Proj.Dwellings[house].Walls[index].Ru), 2);
              if ((double) num6 < 0.199 & !((IEnumerable<float>) source4).Contains<float>(num6))
                SDetails.Key_External_Wall_U = true;
              checked { ++index; }
            }
          }
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].MainHeating.InforSource, "Boiler Database", false) == 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[house].MainHeating.SGroup, "Micro-cogeneration (micro-CHP)", false) == 0)
            SDetails.Key_microCogeneration = true;
          if (L1ACheckList.CommFeature_found)
            SDetails.Key_Community_Heating = true;
          if (SAP_Module.Proj.Dwellings[house].Renewable.Photovoltaic.Inlcude)
            SDetails.Key_Photovaltaic_Array = true;
          if (SAP_Module.Proj.Dwellings[house].Renewable.WindTurbine.Inlcude)
            SDetails.Key_Wind_Turbine = true;
          if (SAP_Module.Proj.Dwellings[house].Renewable.Special.Include)
          {
            int num7 = checked (SAP_Module.Proj.Dwellings[house].Renewable.Special.Special.Length - 1);
            int num8 = 0;
            while (num8 <= num7)
            {
              SDetails.Key_Appendix_Q = true;
              checked { ++num8; }
            }
          }
          if (SAP_Module.Proj.Dwellings[house].Cooling.Include)
            SDetails.Key_Fixed_Cooling = true;
          if (SAP_Module.Proj.Dwellings[house].Renewable.AAEGeneration.Inlcude)
            SDetails.Key_Allow_Electricity_Generation = true;
          if (SAP_Module.Proj.Dwellings[house].Water.Solar.Inlcude)
            SDetails.Key_Solar_water_heating = true;
          if ((uint) SAP_Module.Proj.Dwellings[house].SecHeating.SAPTableCode > 0U)
            SDetails.Key_Secondary_Heating = true;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        str1 += "\r\nError at stage 3";
        ProjectData.ClearProjectError();
      }
      string str2 = "";
      try
      {
        SDetails.ProjectID = checked ((int) Math.Round(Conversion.Val(InputStr)));
        if (SDetails.ProjectID > 0)
          str2 = complianceSoapClient.SendCompliance_Details(SDetails, "201072951671", "f602e12b8c3558bd50a23b1618a63249");
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        str1 += "\r\nError at stage 4";
        ProjectData.ClearProjectError();
      }
      if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, (string) null, false) > 0U)
      {
        try
        {
          MemoryStream memoryStream = new MemoryStream();
          Stream stream = (Stream) new MemoryStream();
          PDFFunctions.document.Save(stream, false);
          PDFFunctions.PDFData = PDFFunctions.EncodeByte(((MemoryStream) stream).ToArray());
          object obj = (object) complianceSoapClient.Upload_ComplianceSheet(PDFFunctions.PDFData, str2, "201072951671", "f602e12b8c3558bd50a23b1618a63249");
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
      }
      return str1;
    }

    public static string CheckCommunityFuelDescription(string Fuel)
    {
      string str1 = "";
      string str2 = Fuel;
      // ISSUE: reference to a compiler-generated method
      switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(str2))
      {
        case 335024745:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "heat from boilers – biogas", false) == 0)
          {
            str1 = "Biogas";
            goto default;
          }
          else
            goto default;
        case 664172296:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "heat from CHP", false) == 0)
          {
            str1 = "Mains gas";
            goto default;
          }
          else
            goto default;
        case 842919835:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "heat from boilers – LPG", false) == 0)
          {
            str1 = "LPG";
            goto default;
          }
          else
            goto default;
        case 1424221758:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "geothermal heat source", false) == 0)
            break;
          goto default;
        case 1538586610:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "heat from boilers – oil", false) == 0)
          {
            str1 = "Oil";
            goto default;
          }
          else
            goto default;
        case 1860525480:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "heat from electric heat pump", false) == 0)
          {
            str1 = "Electricity ";
            goto default;
          }
          else
            goto default;
        case 2340757125:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "heat from boilers - waste combustion", false) == 0)
          {
            str1 = "Waste combustion";
            goto default;
          }
          else
            goto default;
        case 2343415715:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "waste heat from power stations", false) == 0)
          {
            str1 = "Power stations";
            goto default;
          }
          else
            goto default;
        case 3216529428:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "heat from boilers – biomass", false) == 0)
          {
            str1 = "Biomass";
            goto default;
          }
          else
            goto default;
        case 3398809853:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "heat from boilers – B30D", false) == 0)
          {
            str1 = "B30D";
            goto default;
          }
          else
            goto default;
        case 3824947145:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "heat from boilers – coal", false) == 0)
          {
            str1 = "Coal";
            goto default;
          }
          else
            goto default;
        case 4184750297:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "heat from boilers – geothermal heat source", false) == 0)
            break;
          goto default;
        case 4241528165:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "heat from boilers – mains gas", false) == 0)
          {
            str1 = "Mains gas";
            goto default;
          }
          else
            goto default;
        default:
label_26:
          return str1;
      }
      str1 = "Geothermal";
      goto label_26;
    }
  }
}
