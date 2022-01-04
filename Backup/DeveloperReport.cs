
// Type: SAP2012.DeveloperReport




using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using uValueCalc;

namespace SAP2012
{
  [StandardModule]
  internal sealed class DeveloperReport
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
    private static float Con = 2.833f;
    private static string[] Address = new string[5];

    public static Stream CreateDeveloperReport(int House, int Country)
    {
      // ISSUE: variable of a compiler-generated type
      DeveloperReport._Closure\u0024__14\u002D0 closure140_1;
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      DeveloperReport._Closure\u0024__14\u002D0 closure140_2 = new DeveloperReport._Closure\u0024__14\u002D0(closure140_1);
      // ISSUE: reference to a compiler-generated field
      closure140_2.\u0024VB\u0024Local_House = House;
      Stream developerReport = (Stream) new MemoryStream();
      XFont xfont1 = new XFont("Tahoma", 11.0, (XFontStyle) 1);
      XFont xfont2 = new XFont("Tahoma", 10.0, (XFontStyle) 0);
      XFont xfont3 = new XFont("Tahoma", 12.0, (XFontStyle) 0);
      XFont xfont4 = new XFont("Tahoma", 10.0, (XFontStyle) 4);
      XFont xfont5 = new XFont("Tahoma", 16.0, (XFontStyle) 1);
      XFont xfont6 = new XFont("Tahoma", 10.0, (XFontStyle) 1);
      XFont xfont7 = new XFont("Tahoma", 8.0, (XFontStyle) 1);
      XFont xfont8 = new XFont("Tahoma", 8.0, (XFontStyle) 0);
      XFont xfont9 = new XFont("Tahoma", 6.0, (XFontStyle) 0);
      XPen xpen1 = new XPen(XColor.FromArgb(0, 115, 187));
      XPen xpen2 = new XPen(XColor.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue));
      XPen xpen3 = new XPen(XColor.FromArgb(0, 0, (int) byte.MaxValue));
      DeveloperReport.k = 0;
      PDFFunctions.document = new PdfDocument();
      PDFFunctions.pages[DeveloperReport.k] = PDFFunctions.document.AddPage();
      PDFFunctions.gfx[DeveloperReport.k] = XGraphics.FromPdfPage(PDFFunctions.pages[DeveloperReport.k]);
      XSize xsize = PDFFunctions.gfx[DeveloperReport.k].PageSize;
      double num1 = ((XSize) ref xsize).Width / 2.0;
      xsize = PDFFunctions.gfx[DeveloperReport.k].MeasureString("Developer Confirmation Report", PDFFunctions.ArialFont16Bold);
      double num2 = ((XSize) ref xsize).Width / 2.0;
      int num3 = checked ((int) Math.Round(unchecked (num1 - num2)));
      XGraphics xgraphics1 = PDFFunctions.gfx[DeveloperReport.k];
      XFont arialFont16Bold = PDFFunctions.ArialFont16Bold;
      XSolidBrush black1 = XBrushes.Black;
      double num4 = (double) num3;
      XUnit xunit1 = PDFFunctions.pages[DeveloperReport.k].Width;
      double point1 = ((XUnit) ref xunit1).Point;
      xunit1 = PDFFunctions.pages[DeveloperReport.k].Height;
      double num5 = ((XUnit) ref xunit1).Point / 2.0;
      XRect xrect1 = new XRect(num4, 30.0, point1, num5);
      XStringFormat topLeft1 = XStringFormat.TopLeft;
      xgraphics1.DrawString("Developer Confirmation Report", arialFont16Bold, (XBrush) black1, xrect1, topLeft1);
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
          num8 = checked ((int) Math.Round((double) DeveloperReport.ImageY));
          num9 = checked ((int) Math.Round(unchecked ((double) checked (image.Height * 100) / (double) image.Width)));
        }
        else
        {
          num8 = checked ((int) Math.Round((double) DeveloperReport.ImageY));
          num9 = 60;
          num6 = checked ((int) Math.Round(unchecked (575.0 - (double) image.Width / (double) image.Height * 60.0)));
          num7 = checked ((int) Math.Round(unchecked ((double) image.Width / (double) image.Height * 60.0)));
        }
        PDFFunctions.gfx[DeveloperReport.k].DrawImage(XImage.op_Implicit(image), num6, num8, num7, num9);
        image.Dispose();
      }
      if (UserSettings.USettings.PrintUserSettings.Print)
        PDFFunctions.PrintUserDetails(PDFFunctions.gfx[DeveloperReport.k]);
      DeveloperReport.RC1 = 70;
      PDFFunctions.xBrush1 = XBrush.op_Implicit((Brush) new SolidBrush(Color.FromArgb(159, 172, 62)));
      PDFFunctions.Points[0].X = 20f;
      PDFFunctions.Points[0].Y = (float) DeveloperReport.RC1;
      ref PointF local1 = ref PDFFunctions.Points[1];
      XUnit width1 = PDFFunctions.pages[DeveloperReport.k].Width;
      double num10 = ((XUnit) ref width1).Point - 20.0;
      local1.X = (float) num10;
      PDFFunctions.Points[1].Y = (float) DeveloperReport.RC1;
      ref PointF local2 = ref PDFFunctions.Points[2];
      XUnit width2 = PDFFunctions.pages[DeveloperReport.k].Width;
      double num11 = ((XUnit) ref width2).Point - 20.0;
      local2.X = (float) num11;
      PDFFunctions.Points[2].Y = (float) checked (DeveloperReport.RC1 + 16);
      PDFFunctions.Points[3].X = 20f;
      PDFFunctions.Points[3].Y = (float) checked (DeveloperReport.RC1 + 16);
      XFillMode xfillMode;
      PDFFunctions.gfx[DeveloperReport.k].DrawPolygon(PDFFunctions.polyGreen2, PDFFunctions.xBrush1, PDFFunctions.Points, xfillMode);
      XGraphics xgraphics2 = PDFFunctions.gfx[DeveloperReport.k];
      // ISSUE: reference to a compiler-generated field
      string str1 = "Property Details: " + SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Name;
      XFont xfont10 = xfont3;
      XSolidBrush white1 = XBrushes.White;
      double num12 = (double) checked (DeveloperReport.RC1 + 1);
      XUnit xunit2 = PDFFunctions.pages[DeveloperReport.k].Width;
      double point2 = ((XUnit) ref xunit2).Point;
      xunit2 = PDFFunctions.pages[DeveloperReport.k].Height;
      double num13 = ((XUnit) ref xunit2).Point / 2.0;
      XRect xrect2 = new XRect(25.0, num12, point2, num13);
      XStringFormat topLeft2 = XStringFormat.TopLeft;
      xgraphics2.DrawString(str1, xfont10, (XBrush) white1, xrect2, topLeft2);
      DeveloperReport.RC1 = checked ((int) Math.Round(unchecked ((double) PDFFunctions.Points[3].Y + 6.0)));
      string str2 = "";
      // ISSUE: reference to a compiler-generated field
      if (!string.IsNullOrEmpty(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Address.Line1))
      {
        // ISSUE: reference to a compiler-generated field
        str2 += SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Address.Line1;
      }
      // ISSUE: reference to a compiler-generated field
      if (!string.IsNullOrEmpty(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Address.Line2))
      {
        // ISSUE: reference to a compiler-generated field
        str2 = str2 + ", " + SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Address.Line2;
      }
      // ISSUE: reference to a compiler-generated field
      if (!string.IsNullOrEmpty(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Address.Line3))
      {
        // ISSUE: reference to a compiler-generated field
        str2 = str2 + ", " + SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Address.Line3;
      }
      // ISSUE: reference to a compiler-generated field
      if (!string.IsNullOrEmpty(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Address.City))
      {
        // ISSUE: reference to a compiler-generated field
        str2 = str2 + ", " + SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Address.City;
      }
      // ISSUE: reference to a compiler-generated field
      if (!string.IsNullOrEmpty(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Address.PostCost))
      {
        // ISSUE: reference to a compiler-generated field
        str2 = str2 + ", " + SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Address.PostCost;
      }
      XGraphics xgraphics3 = PDFFunctions.gfx[DeveloperReport.k];
      XFont xfont11 = xfont2;
      XSolidBrush black2 = XBrushes.Black;
      double rc1_1 = (double) DeveloperReport.RC1;
      XUnit width3 = PDFFunctions.pages[DeveloperReport.k].Width;
      double point3 = ((XUnit) ref width3).Point;
      XUnit height1 = PDFFunctions.pages[DeveloperReport.k].Height;
      double num14 = ((XUnit) ref height1).Point / 2.0;
      XRect xrect3 = new XRect(20.0, rc1_1, point3, num14);
      XStringFormat topLeft3 = XStringFormat.TopLeft;
      xgraphics3.DrawString("Address:", xfont11, (XBrush) black2, xrect3, topLeft3);
      XGraphics xgraphics4 = PDFFunctions.gfx[DeveloperReport.k];
      string str3 = str2;
      XFont xfont12 = xfont2;
      XSolidBrush black3 = XBrushes.Black;
      double rc1_2 = (double) DeveloperReport.RC1;
      XUnit xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
      double point4 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
      double num15 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect4 = new XRect(200.0, rc1_2, point4, num15);
      XStringFormat topLeft4 = XStringFormat.TopLeft;
      xgraphics4.DrawString(str3, xfont12, (XBrush) black3, xrect4, topLeft4);
      checked { DeveloperReport.RC1 += 12; }
      XGraphics xgraphics5 = PDFFunctions.gfx[DeveloperReport.k];
      XFont xfont13 = xfont2;
      XSolidBrush black4 = XBrushes.Black;
      double rc1_3 = (double) DeveloperReport.RC1;
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
      double point5 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
      double num16 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect5 = new XRect(20.0, rc1_3, point5, num16);
      XStringFormat topLeft5 = XStringFormat.TopLeft;
      xgraphics5.DrawString("Located in:", xfont13, (XBrush) black4, xrect5, topLeft5);
      XGraphics xgraphics6 = PDFFunctions.gfx[DeveloperReport.k];
      // ISSUE: reference to a compiler-generated field
      string country = SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Address.Country;
      XFont xfont14 = xfont2;
      XSolidBrush black5 = XBrushes.Black;
      double rc1_4 = (double) DeveloperReport.RC1;
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
      double point6 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
      double num17 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect6 = new XRect(200.0, rc1_4, point6, num17);
      XStringFormat topLeft6 = XStringFormat.TopLeft;
      xgraphics6.DrawString(country, xfont14, (XBrush) black5, xrect6, topLeft6);
      checked { DeveloperReport.RC1 += 12; }
      XGraphics xgraphics7 = PDFFunctions.gfx[DeveloperReport.k];
      XFont xfont15 = xfont2;
      XSolidBrush black6 = XBrushes.Black;
      double rc1_5 = (double) DeveloperReport.RC1;
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
      double point7 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
      double num18 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect7 = new XRect(20.0, rc1_5, point7, num18);
      XStringFormat topLeft7 = XStringFormat.TopLeft;
      xgraphics7.DrawString("Region:", xfont15, (XBrush) black6, xrect7, topLeft7);
      XGraphics xgraphics8 = PDFFunctions.gfx[DeveloperReport.k];
      // ISSUE: reference to a compiler-generated field
      string location = SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Location;
      XFont xfont16 = xfont2;
      XSolidBrush black7 = XBrushes.Black;
      double rc1_6 = (double) DeveloperReport.RC1;
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
      double point8 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
      double num19 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect8 = new XRect(200.0, rc1_6, point8, num19);
      XStringFormat topLeft8 = XStringFormat.TopLeft;
      xgraphics8.DrawString(location, xfont16, (XBrush) black7, xrect8, topLeft8);
      checked { DeveloperReport.RC1 += 12; }
      XGraphics xgraphics9 = PDFFunctions.gfx[DeveloperReport.k];
      XFont xfont17 = xfont2;
      XSolidBrush black8 = XBrushes.Black;
      double rc1_7 = (double) DeveloperReport.RC1;
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
      double point9 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
      double num20 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect9 = new XRect(20.0, rc1_7, point9, num20);
      XStringFormat topLeft9 = XStringFormat.TopLeft;
      xgraphics9.DrawString("UPRN:", xfont17, (XBrush) black8, xrect9, topLeft9);
      XGraphics xgraphics10 = PDFFunctions.gfx[DeveloperReport.k];
      // ISSUE: reference to a compiler-generated field
      string uprn = SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].UPRN;
      XFont xfont18 = xfont2;
      XSolidBrush black9 = XBrushes.Black;
      double rc1_8 = (double) DeveloperReport.RC1;
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
      double point10 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
      double num21 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect10 = new XRect(200.0, rc1_8, point10, num21);
      XStringFormat topLeft10 = XStringFormat.TopLeft;
      xgraphics10.DrawString(uprn, xfont18, (XBrush) black9, xrect10, topLeft10);
      checked { DeveloperReport.RC1 += 12; }
      XGraphics xgraphics11 = PDFFunctions.gfx[DeveloperReport.k];
      XFont xfont19 = xfont2;
      XSolidBrush black10 = XBrushes.Black;
      double rc1_9 = (double) DeveloperReport.RC1;
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
      double point11 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
      double num22 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect11 = new XRect(20.0, rc1_9, point11, num22);
      XStringFormat topLeft11 = XStringFormat.TopLeft;
      xgraphics11.DrawString("Date of assessment:", xfont19, (XBrush) black10, xrect11, topLeft11);
      XGraphics xgraphics12 = PDFFunctions.gfx[DeveloperReport.k];
      // ISSUE: reference to a compiler-generated field
      string longDateString1 = SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].DateAssessment.ToLongDateString();
      XFont xfont20 = xfont2;
      XSolidBrush black11 = XBrushes.Black;
      double rc1_10 = (double) DeveloperReport.RC1;
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
      double point12 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
      double num23 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect12 = new XRect(200.0, rc1_10, point12, num23);
      XStringFormat topLeft12 = XStringFormat.TopLeft;
      xgraphics12.DrawString(longDateString1, xfont20, (XBrush) black11, xrect12, topLeft12);
      checked { DeveloperReport.RC1 += 12; }
      XGraphics xgraphics13 = PDFFunctions.gfx[DeveloperReport.k];
      XFont xfont21 = xfont2;
      XSolidBrush black12 = XBrushes.Black;
      double rc1_11 = (double) DeveloperReport.RC1;
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
      double point13 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
      double num24 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect13 = new XRect(20.0, rc1_11, point13, num24);
      XStringFormat topLeft13 = XStringFormat.TopLeft;
      xgraphics13.DrawString("Date of certificate:", xfont21, (XBrush) black12, xrect13, topLeft13);
      XGraphics xgraphics14 = PDFFunctions.gfx[DeveloperReport.k];
      string longDateString2 = DateAndTime.Now.ToLongDateString();
      XFont xfont22 = xfont2;
      XSolidBrush black13 = XBrushes.Black;
      double rc1_12 = (double) DeveloperReport.RC1;
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
      double point14 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
      double num25 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect14 = new XRect(200.0, rc1_12, point14, num25);
      XStringFormat topLeft14 = XStringFormat.TopLeft;
      xgraphics14.DrawString(longDateString2, xfont22, (XBrush) black13, xrect14, topLeft14);
      checked { DeveloperReport.RC1 += 12; }
      XGraphics xgraphics15 = PDFFunctions.gfx[DeveloperReport.k];
      XFont xfont23 = xfont2;
      XSolidBrush black14 = XBrushes.Black;
      double rc1_13 = (double) DeveloperReport.RC1;
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
      double point15 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
      double num26 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect15 = new XRect(20.0, rc1_13, point15, num26);
      XStringFormat topLeft15 = XStringFormat.TopLeft;
      xgraphics15.DrawString("Assessment type:", xfont23, (XBrush) black14, xrect15, topLeft15);
      XGraphics xgraphics16 = PDFFunctions.gfx[DeveloperReport.k];
      // ISSUE: reference to a compiler-generated field
      string status = SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Status;
      XFont xfont24 = xfont2;
      XSolidBrush black15 = XBrushes.Black;
      double rc1_14 = (double) DeveloperReport.RC1;
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
      double point16 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
      double num27 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect16 = new XRect(200.0, rc1_14, point16, num27);
      XStringFormat topLeft16 = XStringFormat.TopLeft;
      xgraphics16.DrawString(status, xfont24, (XBrush) black15, xrect16, topLeft16);
      checked { DeveloperReport.RC1 += 12; }
      XGraphics xgraphics17 = PDFFunctions.gfx[DeveloperReport.k];
      XFont xfont25 = xfont2;
      XSolidBrush black16 = XBrushes.Black;
      double rc1_15 = (double) DeveloperReport.RC1;
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
      double point17 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
      double num28 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect17 = new XRect(20.0, rc1_15, point17, num28);
      XStringFormat topLeft17 = XStringFormat.TopLeft;
      xgraphics17.DrawString("Transaction type:", xfont25, (XBrush) black16, xrect17, topLeft17);
      XGraphics xgraphics18 = PDFFunctions.gfx[DeveloperReport.k];
      // ISSUE: reference to a compiler-generated field
      string transaction = SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Transaction;
      XFont xfont26 = xfont2;
      XSolidBrush black17 = XBrushes.Black;
      double rc1_16 = (double) DeveloperReport.RC1;
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
      double point18 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
      double num29 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect18 = new XRect(200.0, rc1_16, point18, num29);
      XStringFormat topLeft18 = XStringFormat.TopLeft;
      xgraphics18.DrawString(transaction, xfont26, (XBrush) black17, xrect18, topLeft18);
      checked { DeveloperReport.RC1 += 12; }
      // ISSUE: reference to a compiler-generated field
      if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].TMP.Type, "User Value", false) == 0)
      {
        XGraphics xgraphics19 = PDFFunctions.gfx[DeveloperReport.k];
        XFont xfont27 = xfont2;
        XSolidBrush black18 = XBrushes.Black;
        double rc1_17 = (double) DeveloperReport.RC1;
        xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
        double point19 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
        double num30 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect19 = new XRect(20.0, rc1_17, point19, num30);
        XStringFormat topLeft19 = XStringFormat.TopLeft;
        xgraphics19.DrawString("User Value:", xfont27, (XBrush) black18, xrect19, topLeft19);
        XGraphics xgraphics20 = PDFFunctions.gfx[DeveloperReport.k];
        // ISSUE: reference to a compiler-generated field
        string str4 = "TMP = " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].TMP.UserDefined) + "kJ/m\u00B2K";
        XFont xfont28 = xfont2;
        XSolidBrush black19 = XBrushes.Black;
        double rc1_18 = (double) DeveloperReport.RC1;
        xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
        double point20 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
        double num31 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect20 = new XRect(200.0, rc1_18, point20, num31);
        XStringFormat topLeft20 = XStringFormat.TopLeft;
        xgraphics20.DrawString(str4, xfont28, (XBrush) black19, xrect20, topLeft20);
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].TMP.Type, "Indicative Value", false) == 0)
        {
          XGraphics xgraphics21 = PDFFunctions.gfx[DeveloperReport.k];
          XFont xfont29 = xfont2;
          XSolidBrush black20 = XBrushes.Black;
          double rc1_19 = (double) DeveloperReport.RC1;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point21 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num32 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect21 = new XRect(20.0, rc1_19, point21, num32);
          XStringFormat topLeft21 = XStringFormat.TopLeft;
          xgraphics21.DrawString("Thermal Mass Parameter:", xfont29, (XBrush) black20, xrect21, topLeft21);
          XGraphics xgraphics22 = PDFFunctions.gfx[DeveloperReport.k];
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          string str5 = SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].TMP.Type + " " + SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].TMP.Indicative;
          XFont xfont30 = xfont2;
          XSolidBrush black21 = XBrushes.Black;
          double rc1_20 = (double) DeveloperReport.RC1;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point22 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num33 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect22 = new XRect(200.0, rc1_20, point22, num33);
          XStringFormat topLeft22 = XStringFormat.TopLeft;
          xgraphics22.DrawString(str5, xfont30, (XBrush) black21, xrect22, topLeft22);
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].TMP.Type, "Calculated", false) == 0)
          {
            XGraphics xgraphics23 = PDFFunctions.gfx[DeveloperReport.k];
            XFont xfont31 = xfont2;
            XSolidBrush black22 = XBrushes.Black;
            double rc1_21 = (double) DeveloperReport.RC1;
            xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
            double point23 = ((XUnit) ref xunit3).Point;
            xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
            double num34 = ((XUnit) ref xunit3).Point / 2.0;
            XRect xrect23 = new XRect(20.0, rc1_21, point23, num34);
            XStringFormat topLeft23 = XStringFormat.TopLeft;
            xgraphics23.DrawString("Thermal Mass Parameter:", xfont31, (XBrush) black22, xrect23, topLeft23);
            XGraphics xgraphics24 = PDFFunctions.gfx[DeveloperReport.k];
            string str6 = "Calculated " + Conversions.ToString(Math.Round(SAP_Module.Calculation2012.Calculation.HeatLoss.Box35, 2));
            XFont xfont32 = xfont2;
            XSolidBrush black23 = XBrushes.Black;
            double rc1_22 = (double) DeveloperReport.RC1;
            xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
            double point24 = ((XUnit) ref xunit3).Point;
            xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
            double num35 = ((XUnit) ref xunit3).Point / 2.0;
            XRect xrect24 = new XRect(200.0, rc1_22, point24, num35);
            XStringFormat topLeft24 = XStringFormat.TopLeft;
            xgraphics24.DrawString(str6, xfont32, (XBrush) black23, xrect24, topLeft24);
          }
        }
      }
      checked { DeveloperReport.RC1 += 14; }
      DeveloperReport.CreateBox();
      PDFFunctions.xBrush1 = XBrush.op_Implicit((Brush) new SolidBrush(Color.FromArgb(159, 172, 62)));
      PDFFunctions.Points[0].X = 20f;
      PDFFunctions.Points[0].Y = (float) DeveloperReport.RC1;
      ref PointF local3 = ref PDFFunctions.Points[1];
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
      double num36 = ((XUnit) ref xunit3).Point - 20.0;
      local3.X = (float) num36;
      PDFFunctions.Points[1].Y = (float) DeveloperReport.RC1;
      ref PointF local4 = ref PDFFunctions.Points[2];
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
      double num37 = ((XUnit) ref xunit3).Point - 20.0;
      local4.X = (float) num37;
      PDFFunctions.Points[2].Y = (float) checked (DeveloperReport.RC1 + 16);
      PDFFunctions.Points[3].X = 20f;
      PDFFunctions.Points[3].Y = (float) checked (DeveloperReport.RC1 + 16);
      PDFFunctions.gfx[DeveloperReport.k].DrawPolygon(PDFFunctions.polyGreen2, PDFFunctions.xBrush1, PDFFunctions.Points, xfillMode);
      XGraphics xgraphics25 = PDFFunctions.gfx[DeveloperReport.k];
      XFont xfont33 = xfont3;
      XSolidBrush white2 = XBrushes.White;
      double num38 = (double) checked (DeveloperReport.RC1 + 1);
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
      double point25 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
      double num39 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect25 = new XRect(25.0, num38, point25, num39);
      XStringFormat topLeft25 = XStringFormat.TopLeft;
      xgraphics25.DrawString("Property description:", xfont33, (XBrush) white2, xrect25, topLeft25);
      DeveloperReport.RC1 = checked ((int) Math.Round(unchecked ((double) PDFFunctions.Points[3].Y + 6.0)));
      XGraphics xgraphics26 = PDFFunctions.gfx[DeveloperReport.k];
      XFont xfont34 = xfont2;
      XSolidBrush black24 = XBrushes.Black;
      double rc1_23 = (double) DeveloperReport.RC1;
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
      double point26 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
      double num40 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect26 = new XRect(20.0, rc1_23, point26, num40);
      XStringFormat topLeft26 = XStringFormat.TopLeft;
      xgraphics26.DrawString("Dwelling type:", xfont34, (XBrush) black24, xrect26, topLeft26);
      XGraphics xgraphics27 = PDFFunctions.gfx[DeveloperReport.k];
      // ISSUE: reference to a compiler-generated field
      string propertyType = SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].PropertyType;
      XFont xfont35 = xfont2;
      XSolidBrush black25 = XBrushes.Black;
      double rc1_24 = (double) DeveloperReport.RC1;
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
      double point27 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
      double num41 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect27 = new XRect(200.0, rc1_24, point27, num41);
      XStringFormat topLeft27 = XStringFormat.TopLeft;
      xgraphics27.DrawString(propertyType, xfont35, (XBrush) black25, xrect27, topLeft27);
      checked { DeveloperReport.RC1 += 12; }
      XGraphics xgraphics28 = PDFFunctions.gfx[DeveloperReport.k];
      XFont xfont36 = xfont2;
      XSolidBrush black26 = XBrushes.Black;
      double rc1_25 = (double) DeveloperReport.RC1;
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
      double point28 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
      double num42 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect28 = new XRect(20.0, rc1_25, point28, num42);
      XStringFormat topLeft28 = XStringFormat.TopLeft;
      xgraphics28.DrawString("Detachment:", xfont36, (XBrush) black26, xrect28, topLeft28);
      XGraphics xgraphics29 = PDFFunctions.gfx[DeveloperReport.k];
      // ISSUE: reference to a compiler-generated field
      string buildForm = SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].BuildForm;
      XFont xfont37 = xfont2;
      XSolidBrush black27 = XBrushes.Black;
      double rc1_26 = (double) DeveloperReport.RC1;
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
      double point29 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
      double num43 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect29 = new XRect(200.0, rc1_26, point29, num43);
      XStringFormat topLeft29 = XStringFormat.TopLeft;
      xgraphics29.DrawString(buildForm, xfont37, (XBrush) black27, xrect29, topLeft29);
      checked { DeveloperReport.RC1 += 12; }
      XGraphics xgraphics30 = PDFFunctions.gfx[DeveloperReport.k];
      XFont xfont38 = xfont2;
      XSolidBrush black28 = XBrushes.Black;
      double rc1_27 = (double) DeveloperReport.RC1;
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
      double point30 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
      double num44 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect30 = new XRect(20.0, rc1_27, point30, num44);
      XStringFormat topLeft30 = XStringFormat.TopLeft;
      xgraphics30.DrawString("Year Completed:", xfont38, (XBrush) black28, xrect30, topLeft30);
      XGraphics xgraphics31 = PDFFunctions.gfx[DeveloperReport.k];
      // ISSUE: reference to a compiler-generated field
      string str7 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].YearBuilt);
      XFont xfont39 = xfont2;
      XSolidBrush black29 = XBrushes.Black;
      double rc1_28 = (double) DeveloperReport.RC1;
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
      double point31 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
      double num45 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect31 = new XRect(200.0, rc1_28, point31, num45);
      XStringFormat topLeft31 = XStringFormat.TopLeft;
      xgraphics31.DrawString(str7, xfont39, (XBrush) black29, xrect31, topLeft31);
      checked { DeveloperReport.RC1 += 16; }
      XGraphics xgraphics32 = PDFFunctions.gfx[DeveloperReport.k];
      XFont xfont40 = xfont2;
      XSolidBrush black30 = XBrushes.Black;
      double rc1_29 = (double) DeveloperReport.RC1;
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
      double point32 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
      double num46 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect32 = new XRect(20.0, rc1_29, point32, num46);
      XStringFormat topLeft32 = XStringFormat.TopLeft;
      xgraphics32.DrawString("Front of dwelling faces:", xfont40, (XBrush) black30, xrect32, topLeft32);
      XGraphics xgraphics33 = PDFFunctions.gfx[DeveloperReport.k];
      // ISSUE: reference to a compiler-generated field
      string orientation = SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Orientation;
      XFont xfont41 = xfont2;
      XSolidBrush black31 = XBrushes.Black;
      double rc1_30 = (double) DeveloperReport.RC1;
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
      double point33 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
      double num47 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect33 = new XRect(200.0, rc1_30, point33, num47);
      XStringFormat topLeft33 = XStringFormat.TopLeft;
      xgraphics33.DrawString(orientation, xfont41, (XBrush) black31, xrect33, topLeft33);
      checked { DeveloperReport.RC1 += 16; }
      DeveloperReport.CreateBox();
      DeveloperReport.CheckRC1();
      PDFFunctions.xBrush1 = XBrush.op_Implicit((Brush) new SolidBrush(Color.FromArgb(159, 172, 62)));
      PDFFunctions.Points[0].X = 20f;
      PDFFunctions.Points[0].Y = (float) DeveloperReport.RC1;
      ref PointF local5 = ref PDFFunctions.Points[1];
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
      double num48 = ((XUnit) ref xunit3).Point - 20.0;
      local5.X = (float) num48;
      PDFFunctions.Points[1].Y = (float) DeveloperReport.RC1;
      ref PointF local6 = ref PDFFunctions.Points[2];
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
      double num49 = ((XUnit) ref xunit3).Point - 20.0;
      local6.X = (float) num49;
      PDFFunctions.Points[2].Y = (float) checked (DeveloperReport.RC1 + 16);
      PDFFunctions.Points[3].X = 20f;
      PDFFunctions.Points[3].Y = (float) checked (DeveloperReport.RC1 + 16);
      PDFFunctions.gfx[DeveloperReport.k].DrawPolygon(PDFFunctions.polyGreen2, PDFFunctions.xBrush1, PDFFunctions.Points, xfillMode);
      XGraphics xgraphics34 = PDFFunctions.gfx[DeveloperReport.k];
      XFont xfont42 = xfont3;
      XSolidBrush white3 = XBrushes.White;
      double num50 = (double) checked (DeveloperReport.RC1 + 1);
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
      double point34 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
      double num51 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect34 = new XRect(25.0, num50, point34, num51);
      XStringFormat topLeft34 = XStringFormat.TopLeft;
      xgraphics34.DrawString("Opening types:", xfont42, (XBrush) white3, xrect34, topLeft34);
      DeveloperReport.RC1 = checked ((int) Math.Round(unchecked ((double) PDFFunctions.Points[3].Y + 6.0)));
      XGraphics xgraphics35 = PDFFunctions.gfx[DeveloperReport.k];
      XFont xfont43 = xfont6;
      XSolidBrush black32 = XBrushes.Black;
      double rc1_31 = (double) DeveloperReport.RC1;
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
      double point35 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
      double num52 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect35 = new XRect(20.0, rc1_31, point35, num52);
      XStringFormat topLeft35 = XStringFormat.TopLeft;
      xgraphics35.DrawString("Name:", xfont43, (XBrush) black32, xrect35, topLeft35);
      XGraphics xgraphics36 = PDFFunctions.gfx[DeveloperReport.k];
      XFont xfont44 = xfont6;
      XSolidBrush black33 = XBrushes.Black;
      double rc1_32 = (double) DeveloperReport.RC1;
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
      double point36 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
      double num53 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect36 = new XRect(130.0, rc1_32, point36, num53);
      XStringFormat topLeft36 = XStringFormat.TopLeft;
      xgraphics36.DrawString("Type:", xfont44, (XBrush) black33, xrect36, topLeft36);
      XGraphics xgraphics37 = PDFFunctions.gfx[DeveloperReport.k];
      XFont xfont45 = xfont6;
      XSolidBrush black34 = XBrushes.Black;
      double rc1_33 = (double) DeveloperReport.RC1;
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
      double point37 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
      double num54 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect37 = new XRect(240.0, rc1_33, point37, num54);
      XStringFormat topLeft37 = XStringFormat.TopLeft;
      xgraphics37.DrawString("Frame Factor:", xfont45, (XBrush) black34, xrect37, topLeft37);
      XGraphics xgraphics38 = PDFFunctions.gfx[DeveloperReport.k];
      XFont xfont46 = xfont6;
      XSolidBrush black35 = XBrushes.Black;
      double rc1_34 = (double) DeveloperReport.RC1;
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
      double point38 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
      double num55 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect38 = new XRect(330.0, rc1_34, point38, num55);
      XStringFormat topLeft38 = XStringFormat.TopLeft;
      xgraphics38.DrawString("g-value:", xfont46, (XBrush) black35, xrect38, topLeft38);
      XGraphics xgraphics39 = PDFFunctions.gfx[DeveloperReport.k];
      XFont xfont47 = xfont6;
      XSolidBrush black36 = XBrushes.Black;
      double rc1_35 = (double) DeveloperReport.RC1;
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
      double point39 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
      double num56 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect39 = new XRect(430.0, rc1_35, point39, num56);
      XStringFormat topLeft39 = XStringFormat.TopLeft;
      xgraphics39.DrawString("U-Value:", xfont47, (XBrush) black36, xrect39, topLeft39);
      XGraphics xgraphics40 = PDFFunctions.gfx[DeveloperReport.k];
      XFont xfont48 = xfont6;
      XSolidBrush black37 = XBrushes.Black;
      double rc1_36 = (double) DeveloperReport.RC1;
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
      double point40 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
      double num57 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect40 = new XRect(500.0, rc1_36, point40, num57);
      XStringFormat topLeft40 = XStringFormat.TopLeft;
      xgraphics40.DrawString("Area:", xfont48, (XBrush) black37, xrect40, topLeft40);
      checked { DeveloperReport.RC1 += 14; }
      // ISSUE: reference to a compiler-generated field
      int num58 = checked (SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].NoofDoors - 1);
      int index1 = 0;
      while (index1 <= num58)
      {
        XGraphics xgraphics41 = PDFFunctions.gfx[DeveloperReport.k];
        // ISSUE: reference to a compiler-generated field
        string name = SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Doors[index1].Name;
        XFont xfont49 = xfont2;
        XSolidBrush black38 = XBrushes.Black;
        double rc1_37 = (double) DeveloperReport.RC1;
        xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
        double point41 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
        double num59 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect41 = new XRect(20.0, rc1_37, point41, num59);
        XStringFormat topLeft41 = XStringFormat.TopLeft;
        xgraphics41.DrawString(name, xfont49, (XBrush) black38, xrect41, topLeft41);
        XGraphics xgraphics42 = PDFFunctions.gfx[DeveloperReport.k];
        // ISSUE: reference to a compiler-generated field
        string doorType = SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Doors[index1].DoorType;
        XFont xfont50 = xfont2;
        XSolidBrush black39 = XBrushes.Black;
        double rc1_38 = (double) DeveloperReport.RC1;
        xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
        double point42 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
        double num60 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect42 = new XRect(130.0, rc1_38, point42, num60);
        XStringFormat topLeft42 = XStringFormat.TopLeft;
        xgraphics42.DrawString(doorType, xfont50, (XBrush) black39, xrect42, topLeft42);
        XGraphics xgraphics43 = PDFFunctions.gfx[DeveloperReport.k];
        // ISSUE: reference to a compiler-generated field
        string str8 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Doors[index1].FF);
        XFont xfont51 = xfont2;
        XSolidBrush black40 = XBrushes.Black;
        double rc1_39 = (double) DeveloperReport.RC1;
        xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
        double point43 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
        double num61 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect43 = new XRect(240.0, rc1_39, point43, num61);
        XStringFormat topLeft43 = XStringFormat.TopLeft;
        xgraphics43.DrawString(str8, xfont51, (XBrush) black40, xrect43, topLeft43);
        XGraphics xgraphics44 = PDFFunctions.gfx[DeveloperReport.k];
        // ISSUE: reference to a compiler-generated field
        string str9 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Doors[index1].g);
        XFont xfont52 = xfont2;
        XSolidBrush black41 = XBrushes.Black;
        double rc1_40 = (double) DeveloperReport.RC1;
        xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
        double point44 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
        double num62 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect44 = new XRect(330.0, rc1_40, point44, num62);
        XStringFormat topLeft44 = XStringFormat.TopLeft;
        xgraphics44.DrawString(str9, xfont52, (XBrush) black41, xrect44, topLeft44);
        XGraphics xgraphics45 = PDFFunctions.gfx[DeveloperReport.k];
        // ISSUE: reference to a compiler-generated field
        string str10 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Doors[index1].U);
        XFont xfont53 = xfont2;
        XSolidBrush black42 = XBrushes.Black;
        double rc1_41 = (double) DeveloperReport.RC1;
        xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
        double point45 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
        double num63 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect45 = new XRect(430.0, rc1_41, point45, num63);
        XStringFormat topLeft45 = XStringFormat.TopLeft;
        xgraphics45.DrawString(str10, xfont53, (XBrush) black42, xrect45, topLeft45);
        XGraphics xgraphics46 = PDFFunctions.gfx[DeveloperReport.k];
        // ISSUE: reference to a compiler-generated field
        string str11 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Doors[index1].Area);
        XFont xfont54 = xfont2;
        XSolidBrush black43 = XBrushes.Black;
        double rc1_42 = (double) DeveloperReport.RC1;
        xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
        double point46 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
        double num64 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect46 = new XRect(500.0, rc1_42, point46, num64);
        XStringFormat topLeft46 = XStringFormat.TopLeft;
        xgraphics46.DrawString(str11, xfont54, (XBrush) black43, xrect46, topLeft46);
        checked { DeveloperReport.RC1 += 12; }
        DeveloperReport.CheckRC1();
        checked { ++index1; }
      }
      // ISSUE: reference to a compiler-generated field
      int num65 = checked (SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].NoofWindows - 1);
      int index2 = 0;
      while (index2 <= num65)
      {
        XGraphics xgraphics47 = PDFFunctions.gfx[DeveloperReport.k];
        // ISSUE: reference to a compiler-generated field
        string name = SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Windows[index2].Name;
        XFont xfont55 = xfont2;
        XSolidBrush black44 = XBrushes.Black;
        double rc1_43 = (double) DeveloperReport.RC1;
        xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
        double point47 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
        double num66 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect47 = new XRect(20.0, rc1_43, point47, num66);
        XStringFormat topLeft47 = XStringFormat.TopLeft;
        xgraphics47.DrawString(name, xfont55, (XBrush) black44, xrect47, topLeft47);
        XGraphics xgraphics48 = PDFFunctions.gfx[DeveloperReport.k];
        XFont xfont56 = xfont2;
        XSolidBrush black45 = XBrushes.Black;
        double rc1_44 = (double) DeveloperReport.RC1;
        xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
        double point48 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
        double num67 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect48 = new XRect(130.0, rc1_44, point48, num67);
        XStringFormat topLeft48 = XStringFormat.TopLeft;
        xgraphics48.DrawString("Windows", xfont56, (XBrush) black45, xrect48, topLeft48);
        // ISSUE: reference to a compiler-generated field
        if ((uint) Operators.CompareString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Windows[index2].UValueSource, "BFRC", false) > 0U)
        {
          XGraphics xgraphics49 = PDFFunctions.gfx[DeveloperReport.k];
          // ISSUE: reference to a compiler-generated field
          string str12 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Windows[index2].FF);
          XFont xfont57 = xfont2;
          XSolidBrush black46 = XBrushes.Black;
          double rc1_45 = (double) DeveloperReport.RC1;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point49 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num68 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect49 = new XRect(240.0, rc1_45, point49, num68);
          XStringFormat topLeft49 = XStringFormat.TopLeft;
          xgraphics49.DrawString(str12, xfont57, (XBrush) black46, xrect49, topLeft49);
        }
        else
        {
          XGraphics xgraphics50 = PDFFunctions.gfx[DeveloperReport.k];
          string str13 = Conversions.ToString(0);
          XFont xfont58 = xfont2;
          XSolidBrush black47 = XBrushes.Black;
          double rc1_46 = (double) DeveloperReport.RC1;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point50 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num69 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect50 = new XRect(240.0, rc1_46, point50, num69);
          XStringFormat topLeft50 = XStringFormat.TopLeft;
          xgraphics50.DrawString(str13, xfont58, (XBrush) black47, xrect50, topLeft50);
        }
        XGraphics xgraphics51 = PDFFunctions.gfx[DeveloperReport.k];
        // ISSUE: reference to a compiler-generated field
        string str14 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Windows[index2].g);
        XFont xfont59 = xfont2;
        XSolidBrush black48 = XBrushes.Black;
        double rc1_47 = (double) DeveloperReport.RC1;
        xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
        double point51 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
        double num70 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect51 = new XRect(330.0, rc1_47, point51, num70);
        XStringFormat topLeft51 = XStringFormat.TopLeft;
        xgraphics51.DrawString(str14, xfont59, (XBrush) black48, xrect51, topLeft51);
        XGraphics xgraphics52 = PDFFunctions.gfx[DeveloperReport.k];
        // ISSUE: reference to a compiler-generated field
        string str15 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Windows[index2].U);
        XFont xfont60 = xfont2;
        XSolidBrush black49 = XBrushes.Black;
        double rc1_48 = (double) DeveloperReport.RC1;
        xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
        double point52 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
        double num71 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect52 = new XRect(430.0, rc1_48, point52, num71);
        XStringFormat topLeft52 = XStringFormat.TopLeft;
        xgraphics52.DrawString(str15, xfont60, (XBrush) black49, xrect52, topLeft52);
        XGraphics xgraphics53 = PDFFunctions.gfx[DeveloperReport.k];
        // ISSUE: reference to a compiler-generated field
        string str16 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Windows[index2].Area);
        XFont xfont61 = xfont2;
        XSolidBrush black50 = XBrushes.Black;
        double rc1_49 = (double) DeveloperReport.RC1;
        xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
        double point53 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
        double num72 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect53 = new XRect(500.0, rc1_49, point53, num72);
        XStringFormat topLeft53 = XStringFormat.TopLeft;
        xgraphics53.DrawString(str16, xfont61, (XBrush) black50, xrect53, topLeft53);
        checked { DeveloperReport.RC1 += 12; }
        DeveloperReport.CheckRC1();
        checked { ++index2; }
      }
      DeveloperReport.CheckRC1();
      DeveloperReport.CheckRC1();
      // ISSUE: reference to a compiler-generated field
      int num73 = checked (SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].NoofRoofLights - 1);
      int index3 = 0;
      while (index3 <= num73)
      {
        XGraphics xgraphics54 = PDFFunctions.gfx[DeveloperReport.k];
        // ISSUE: reference to a compiler-generated field
        string name = SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].RoofLights[index3].Name;
        XFont xfont62 = xfont2;
        XSolidBrush black51 = XBrushes.Black;
        double rc1_50 = (double) DeveloperReport.RC1;
        xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
        double point54 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
        double num74 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect54 = new XRect(20.0, rc1_50, point54, num74);
        XStringFormat topLeft54 = XStringFormat.TopLeft;
        xgraphics54.DrawString(name, xfont62, (XBrush) black51, xrect54, topLeft54);
        XGraphics xgraphics55 = PDFFunctions.gfx[DeveloperReport.k];
        XFont xfont63 = xfont2;
        XSolidBrush black52 = XBrushes.Black;
        double rc1_51 = (double) DeveloperReport.RC1;
        xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
        double point55 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
        double num75 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect55 = new XRect(130.0, rc1_51, point55, num75);
        XStringFormat topLeft55 = XStringFormat.TopLeft;
        xgraphics55.DrawString("Roof Windows", xfont63, (XBrush) black52, xrect55, topLeft55);
        // ISSUE: reference to a compiler-generated field
        if ((uint) Operators.CompareString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].RoofLights[index3].UValueSource, "BFRC", false) > 0U)
        {
          XGraphics xgraphics56 = PDFFunctions.gfx[DeveloperReport.k];
          // ISSUE: reference to a compiler-generated field
          string str17 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].RoofLights[index3].FF);
          XFont xfont64 = xfont2;
          XSolidBrush black53 = XBrushes.Black;
          double rc1_52 = (double) DeveloperReport.RC1;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point56 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num76 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect56 = new XRect(240.0, rc1_52, point56, num76);
          XStringFormat topLeft56 = XStringFormat.TopLeft;
          xgraphics56.DrawString(str17, xfont64, (XBrush) black53, xrect56, topLeft56);
        }
        else
        {
          XGraphics xgraphics57 = PDFFunctions.gfx[DeveloperReport.k];
          string str18 = Conversions.ToString(0);
          XFont xfont65 = xfont2;
          XSolidBrush black54 = XBrushes.Black;
          double rc1_53 = (double) DeveloperReport.RC1;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point57 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num77 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect57 = new XRect(240.0, rc1_53, point57, num77);
          XStringFormat topLeft57 = XStringFormat.TopLeft;
          xgraphics57.DrawString(str18, xfont65, (XBrush) black54, xrect57, topLeft57);
        }
        XGraphics xgraphics58 = PDFFunctions.gfx[DeveloperReport.k];
        // ISSUE: reference to a compiler-generated field
        string str19 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].RoofLights[index3].g);
        XFont xfont66 = xfont2;
        XSolidBrush black55 = XBrushes.Black;
        double rc1_54 = (double) DeveloperReport.RC1;
        xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
        double point58 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
        double num78 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect58 = new XRect(330.0, rc1_54, point58, num78);
        XStringFormat topLeft58 = XStringFormat.TopLeft;
        xgraphics58.DrawString(str19, xfont66, (XBrush) black55, xrect58, topLeft58);
        XGraphics xgraphics59 = PDFFunctions.gfx[DeveloperReport.k];
        // ISSUE: reference to a compiler-generated field
        string str20 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].RoofLights[index3].U);
        XFont xfont67 = xfont2;
        XSolidBrush black56 = XBrushes.Black;
        double rc1_55 = (double) DeveloperReport.RC1;
        xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
        double point59 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
        double num79 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect59 = new XRect(430.0, rc1_55, point59, num79);
        XStringFormat topLeft59 = XStringFormat.TopLeft;
        xgraphics59.DrawString(str20, xfont67, (XBrush) black56, xrect59, topLeft59);
        XGraphics xgraphics60 = PDFFunctions.gfx[DeveloperReport.k];
        // ISSUE: reference to a compiler-generated field
        string str21 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].RoofLights[index3].Area);
        XFont xfont68 = xfont2;
        XSolidBrush black57 = XBrushes.Black;
        double rc1_56 = (double) DeveloperReport.RC1;
        xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
        double point60 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
        double num80 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect60 = new XRect(500.0, rc1_56, point60, num80);
        XStringFormat topLeft60 = XStringFormat.TopLeft;
        xgraphics60.DrawString(str21, xfont68, (XBrush) black57, xrect60, topLeft60);
        checked { DeveloperReport.RC1 += 12; }
        DeveloperReport.CheckRC1();
        checked { ++index3; }
      }
      DeveloperReport.CheckRC1();
      checked { DeveloperReport.RC1 += 12; }
      XGraphics xgraphics61 = PDFFunctions.gfx[DeveloperReport.k];
      XFont xfont69 = xfont2;
      XSolidBrush black58 = XBrushes.Black;
      double rc1_57 = (double) DeveloperReport.RC1;
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
      double point61 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
      double num81 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect61 = new XRect(20.0, rc1_57, point61, num81);
      XStringFormat topLeft61 = XStringFormat.TopLeft;
      xgraphics61.DrawString("Overshading:", xfont69, (XBrush) black58, xrect61, topLeft61);
      XGraphics xgraphics62 = PDFFunctions.gfx[DeveloperReport.k];
      // ISSUE: reference to a compiler-generated field
      string overshading = SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Overshading;
      XFont xfont70 = xfont2;
      XSolidBrush black59 = XBrushes.Black;
      double rc1_58 = (double) DeveloperReport.RC1;
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
      double point62 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
      double num82 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect62 = new XRect(200.0, rc1_58, point62, num82);
      XStringFormat topLeft62 = XStringFormat.TopLeft;
      xgraphics62.DrawString(overshading, xfont70, (XBrush) black59, xrect62, topLeft62);
      checked { DeveloperReport.RC1 += 14; }
      DeveloperReport.CreateBox();
      DeveloperReport.CheckRC1();
      PDFFunctions.xBrush1 = XBrush.op_Implicit((Brush) new SolidBrush(Color.FromArgb(159, 172, 62)));
      PDFFunctions.Points[0].X = 20f;
      PDFFunctions.Points[0].Y = (float) DeveloperReport.RC1;
      ref PointF local7 = ref PDFFunctions.Points[1];
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
      double num83 = ((XUnit) ref xunit3).Point - 20.0;
      local7.X = (float) num83;
      PDFFunctions.Points[1].Y = (float) DeveloperReport.RC1;
      ref PointF local8 = ref PDFFunctions.Points[2];
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
      double num84 = ((XUnit) ref xunit3).Point - 20.0;
      local8.X = (float) num84;
      PDFFunctions.Points[2].Y = (float) checked (DeveloperReport.RC1 + 16);
      PDFFunctions.Points[3].X = 20f;
      PDFFunctions.Points[3].Y = (float) checked (DeveloperReport.RC1 + 16);
      PDFFunctions.gfx[DeveloperReport.k].DrawPolygon(PDFFunctions.polyGreen2, PDFFunctions.xBrush1, PDFFunctions.Points, xfillMode);
      XGraphics xgraphics63 = PDFFunctions.gfx[DeveloperReport.k];
      XFont xfont71 = xfont3;
      XSolidBrush white4 = XBrushes.White;
      double num85 = (double) checked (DeveloperReport.RC1 + 1);
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
      double point63 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
      double num86 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect63 = new XRect(25.0, num85, point63, num86);
      XStringFormat topLeft63 = XStringFormat.TopLeft;
      xgraphics63.DrawString("Opaque Elements:", xfont71, (XBrush) white4, xrect63, topLeft63);
      DeveloperReport.RC1 = checked ((int) Math.Round(unchecked ((double) PDFFunctions.Points[3].Y + 14.0)));
      XGraphics xgraphics64 = PDFFunctions.gfx[DeveloperReport.k];
      XFont xfont72 = xfont6;
      XSolidBrush black60 = XBrushes.Black;
      double rc1_59 = (double) DeveloperReport.RC1;
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
      double point64 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
      double num87 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect64 = new XRect(20.0, rc1_59, point64, num87);
      XStringFormat topLeft64 = XStringFormat.TopLeft;
      xgraphics64.DrawString("Type:", xfont72, (XBrush) black60, xrect64, topLeft64);
      XGraphics xgraphics65 = PDFFunctions.gfx[DeveloperReport.k];
      XFont xfont73 = xfont6;
      XSolidBrush black61 = XBrushes.Black;
      double rc1_60 = (double) DeveloperReport.RC1;
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
      double point65 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
      double num88 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect65 = new XRect(170.0, rc1_60, point65, num88);
      XStringFormat topLeft65 = XStringFormat.TopLeft;
      xgraphics65.DrawString("U-Value:", xfont73, (XBrush) black61, xrect65, topLeft65);
      XGraphics xgraphics66 = PDFFunctions.gfx[DeveloperReport.k];
      XFont xfont74 = xfont6;
      XSolidBrush black62 = XBrushes.Black;
      double rc1_61 = (double) DeveloperReport.RC1;
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
      double point66 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
      double num89 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect66 = new XRect(532.0, rc1_61, point66, num89);
      XStringFormat topLeft66 = XStringFormat.TopLeft;
      xgraphics66.DrawString("Kappa:", xfont74, (XBrush) black62, xrect66, topLeft66);
      checked { DeveloperReport.RC1 += 12; }
      DeveloperReport.CheckRC1();
      XGraphics xgraphics67 = PDFFunctions.gfx[DeveloperReport.k];
      XFont xfont75 = xfont4;
      XSolidBrush black63 = XBrushes.Black;
      double rc1_62 = (double) DeveloperReport.RC1;
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
      double point67 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
      double num90 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect67 = new XRect(20.0, rc1_62, point67, num90);
      XStringFormat topLeft67 = XStringFormat.TopLeft;
      xgraphics67.DrawString("External Elements", xfont75, (XBrush) black63, xrect67, topLeft67);
      checked { DeveloperReport.RC1 += 12; }
      // ISSUE: reference to a compiler-generated field
      int num91 = checked (SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].NoofWalls - 1);
      int index4 = 0;
      while (index4 <= num91)
      {
        // ISSUE: reference to a compiler-generated field
        if (SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Walls[index4].Name != null)
        {
          XGraphics xgraphics68 = PDFFunctions.gfx[DeveloperReport.k];
          // ISSUE: reference to a compiler-generated field
          string name = SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Walls[index4].Name;
          XFont xfont76 = xfont2;
          XSolidBrush black64 = XBrushes.Black;
          double rc1_63 = (double) DeveloperReport.RC1;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point68 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num92 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect68 = new XRect(20.0, rc1_63, point68, num92);
          XStringFormat topLeft68 = XStringFormat.TopLeft;
          xgraphics68.DrawString(name, xfont76, (XBrush) black64, xrect68, topLeft68);
        }
        XGraphics xgraphics69 = PDFFunctions.gfx[DeveloperReport.k];
        // ISSUE: reference to a compiler-generated field
        string str22 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Walls[index4].U_Value);
        XFont xfont77 = xfont2;
        XSolidBrush black65 = XBrushes.Black;
        double rc1_64 = (double) DeveloperReport.RC1;
        xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
        double point69 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
        double num93 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect69 = new XRect(170.0, rc1_64, point69, num93);
        XStringFormat topLeft69 = XStringFormat.TopLeft;
        xgraphics69.DrawString(str22, xfont77, (XBrush) black65, xrect69, topLeft69);
        XGraphics xgraphics70 = PDFFunctions.gfx[DeveloperReport.k];
        XFont xfont78 = xfont8;
        XSolidBrush black66 = XBrushes.Black;
        double num94 = (double) checked (DeveloperReport.RC1 + 2);
        xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
        double point70 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
        double num95 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect70 = new XRect(200.0, num94, point70, num95);
        XStringFormat topLeft70 = XStringFormat.TopLeft;
        xgraphics70.DrawString("Please provide the U-Value calculation to justify the U-Value entered into the assessment.", xfont78, (XBrush) black66, xrect70, topLeft70);
        // ISSUE: reference to a compiler-generated field
        if ((uint) Operators.CompareString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].TMP.Type, "Calculated", false) > 0U)
        {
          XGraphics xgraphics71 = PDFFunctions.gfx[DeveloperReport.k];
          XFont xfont79 = xfont2;
          XSolidBrush black67 = XBrushes.Black;
          double rc1_65 = (double) DeveloperReport.RC1;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point71 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num96 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect71 = new XRect(542.0, rc1_65, point71, num96);
          XStringFormat topLeft71 = XStringFormat.TopLeft;
          xgraphics71.DrawString("N/A", xfont79, (XBrush) black67, xrect71, topLeft71);
        }
        else
        {
          XGraphics xgraphics72 = PDFFunctions.gfx[DeveloperReport.k];
          // ISSUE: reference to a compiler-generated field
          string str23 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Walls[index4].K);
          XFont xfont80 = xfont2;
          XSolidBrush black68 = XBrushes.Black;
          double rc1_66 = (double) DeveloperReport.RC1;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point72 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num97 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect72 = new XRect(542.0, rc1_66, point72, num97);
          XStringFormat topLeft72 = XStringFormat.TopLeft;
          xgraphics72.DrawString(str23, xfont80, (XBrush) black68, xrect72, topLeft72);
        }
        DeveloperReport.CheckRC1();
        checked { DeveloperReport.RC1 += 12; }
        checked { ++index4; }
      }
      DeveloperReport.CheckRC1();
      bool flag1 = false;
      bool flag2 = false;
      bool flag3 = false;
      if (SAP_Module.Proj.SAPUValues.SAPUValues != null)
      {
        int num98 = checked (((IEnumerable<Output.uValueInfo>) SAP_Module.Proj.SAPUValues.SAPUValues).Count<Output.uValueInfo>() - 1);
        int index5 = 0;
        while (index5 <= num98)
        {
          if (SAP_Module.Proj.SAPUValues.SAPUValues[index5].Wall.prop_elements != null)
            flag1 = true;
          checked { ++index5; }
        }
      }
      // ISSUE: reference to a compiler-generated field
      if (SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].NoofWalls > 0)
      {
        if (flag1)
        {
          checked { DeveloperReport.RC1 += 12; }
          XGraphics xgraphics73 = PDFFunctions.gfx[DeveloperReport.k];
          XFont xfont81 = xfont6;
          XSolidBrush black69 = XBrushes.Black;
          double num99 = (double) checked (DeveloperReport.RC1 + 1);
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point73 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num100 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect73 = new XRect(20.0, num99, point73, num100);
          XStringFormat topLeft73 = XStringFormat.TopLeft;
          xgraphics73.DrawString("Materials Used:", xfont81, (XBrush) black69, xrect73, topLeft73);
          checked { DeveloperReport.RC1 += 14; }
          XGraphics xgraphics74 = PDFFunctions.gfx[DeveloperReport.k];
          XFont xfont82 = xfont6;
          XSolidBrush black70 = XBrushes.Black;
          double rc1_67 = (double) DeveloperReport.RC1;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point74 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num101 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect74 = new XRect(20.0, rc1_67, point74, num101);
          XStringFormat topLeft74 = XStringFormat.TopLeft;
          xgraphics74.DrawString("Type:", xfont82, (XBrush) black70, xrect74, topLeft74);
          XGraphics xgraphics75 = PDFFunctions.gfx[DeveloperReport.k];
          XFont xfont83 = xfont6;
          XSolidBrush black71 = XBrushes.Black;
          double rc1_68 = (double) DeveloperReport.RC1;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point75 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num102 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect75 = new XRect(170.0, rc1_68, point75, num102);
          XStringFormat topLeft75 = XStringFormat.TopLeft;
          xgraphics75.DrawString("Name:", xfont83, (XBrush) black71, xrect75, topLeft75);
          XGraphics xgraphics76 = PDFFunctions.gfx[DeveloperReport.k];
          XFont xfont84 = xfont6;
          XSolidBrush black72 = XBrushes.Black;
          double rc1_69 = (double) DeveloperReport.RC1;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point76 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num103 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect76 = new XRect(390.0, rc1_69, point76, num103);
          XStringFormat topLeft76 = XStringFormat.TopLeft;
          xgraphics76.DrawString("Thickness:", xfont84, (XBrush) black72, xrect76, topLeft76);
          XGraphics xgraphics77 = PDFFunctions.gfx[DeveloperReport.k];
          XFont xfont85 = xfont6;
          XSolidBrush black73 = XBrushes.Black;
          double rc1_70 = (double) DeveloperReport.RC1;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point77 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num104 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect77 = new XRect(450.0, rc1_70, point77, num104);
          XStringFormat topLeft77 = XStringFormat.TopLeft;
          xgraphics77.DrawString("Conductivity:", xfont85, (XBrush) black73, xrect77, topLeft77);
          XGraphics xgraphics78 = PDFFunctions.gfx[DeveloperReport.k];
          XFont xfont86 = xfont6;
          XSolidBrush black74 = XBrushes.Black;
          double rc1_71 = (double) DeveloperReport.RC1;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point78 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num105 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect78 = new XRect(530.0, rc1_71, point78, num105);
          XStringFormat topLeft78 = XStringFormat.TopLeft;
          xgraphics78.DrawString("R-Value:", xfont86, (XBrush) black74, xrect78, topLeft78);
          checked { DeveloperReport.RC1 += 14; }
          int num106 = checked (((IEnumerable<Output.uValueInfo>) SAP_Module.Proj.SAPUValues.SAPUValues).Count<Output.uValueInfo>() - 1);
          int index6 = 0;
          while (index6 <= num106)
          {
            if (SAP_Module.Proj.SAPUValues.SAPUValues[index6].Wall.prop_elements != null)
            {
              try
              {
                if (SAP_Module.Proj.SAPUValues.SAPUValues[index6].prop_entity_type.Equals("Wall"))
                {
                  int num107 = checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofWalls - 1);
                  int index7 = 0;
                  while (index7 <= num107)
                  {
                    if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Walls[index7].UValueSelected & SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Walls[index7].UValueSelection == index6)
                    {
                      int num108 = checked (((IEnumerable<Output.UElement>) SAP_Module.Proj.SAPUValues.SAPUValues[index6].Wall.prop_elements).Count<Output.UElement>() - 1);
                      int index8 = 0;
                      while (index8 <= num108)
                      {
                        XGraphics xgraphics79 = PDFFunctions.gfx[DeveloperReport.k];
                        string name = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Walls[index7].Name;
                        XFont xfont87 = xfont2;
                        XSolidBrush black75 = XBrushes.Black;
                        double rc1_72 = (double) DeveloperReport.RC1;
                        xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
                        double point79 = ((XUnit) ref xunit3).Point;
                        xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
                        double num109 = ((XUnit) ref xunit3).Point / 2.0;
                        XRect xrect79 = new XRect(20.0, rc1_72, point79, num109);
                        XStringFormat topLeft79 = XStringFormat.TopLeft;
                        xgraphics79.DrawString(name, xfont87, (XBrush) black75, xrect79, topLeft79);
                        XGraphics xgraphics80 = PDFFunctions.gfx[DeveloperReport.k];
                        string propName = SAP_Module.Proj.SAPUValues.SAPUValues[index6].Wall.prop_elements[index8].prop_name;
                        XFont xfont88 = xfont2;
                        XSolidBrush black76 = XBrushes.Black;
                        double rc1_73 = (double) DeveloperReport.RC1;
                        xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
                        double point80 = ((XUnit) ref xunit3).Point;
                        xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
                        double num110 = ((XUnit) ref xunit3).Point / 2.0;
                        XRect xrect80 = new XRect(170.0, rc1_73, point80, num110);
                        XStringFormat topLeft80 = XStringFormat.TopLeft;
                        xgraphics80.DrawString(propName, xfont88, (XBrush) black76, xrect80, topLeft80);
                        XGraphics xgraphics81 = PDFFunctions.gfx[DeveloperReport.k];
                        string str24 = Conversions.ToString(SAP_Module.Proj.SAPUValues.SAPUValues[index6].Wall.prop_elements[index8].prop_thickness);
                        XFont xfont89 = xfont2;
                        XSolidBrush black77 = XBrushes.Black;
                        double rc1_74 = (double) DeveloperReport.RC1;
                        xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
                        double point81 = ((XUnit) ref xunit3).Point;
                        xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
                        double num111 = ((XUnit) ref xunit3).Point / 2.0;
                        XRect xrect81 = new XRect(420.0, rc1_74, point81, num111);
                        XStringFormat topLeft81 = XStringFormat.TopLeft;
                        xgraphics81.DrawString(str24, xfont89, (XBrush) black77, xrect81, topLeft81);
                        XGraphics xgraphics82 = PDFFunctions.gfx[DeveloperReport.k];
                        string str25 = Conversions.ToString(SAP_Module.Proj.SAPUValues.SAPUValues[index6].Wall.prop_elements[index8].prop_thermal_conductivity);
                        XFont xfont90 = xfont2;
                        XSolidBrush black78 = XBrushes.Black;
                        double rc1_75 = (double) DeveloperReport.RC1;
                        xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
                        double point82 = ((XUnit) ref xunit3).Point;
                        xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
                        double num112 = ((XUnit) ref xunit3).Point / 2.0;
                        XRect xrect82 = new XRect(490.0, rc1_75, point82, num112);
                        XStringFormat topLeft82 = XStringFormat.TopLeft;
                        xgraphics82.DrawString(str25, xfont90, (XBrush) black78, xrect82, topLeft82);
                        XGraphics xgraphics83 = PDFFunctions.gfx[DeveloperReport.k];
                        string str26 = Conversions.ToString(Math.Round(SAP_Module.Proj.SAPUValues.SAPUValues[index6].Wall.prop_elements[index8].prop_thermal_resistance, 2));
                        XFont xfont91 = xfont2;
                        XSolidBrush black79 = XBrushes.Black;
                        double rc1_76 = (double) DeveloperReport.RC1;
                        xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
                        double point83 = ((XUnit) ref xunit3).Point;
                        xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
                        double num113 = ((XUnit) ref xunit3).Point / 2.0;
                        XRect xrect83 = new XRect(550.0, rc1_76, point83, num113);
                        XStringFormat topLeft83 = XStringFormat.TopLeft;
                        xgraphics83.DrawString(str26, xfont91, (XBrush) black79, xrect83, topLeft83);
                        DeveloperReport.CheckRC1();
                        checked { DeveloperReport.RC1 += 12; }
                        checked { ++index8; }
                      }
                    }
                    checked { ++index7; }
                  }
                }
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
              }
            }
            checked { ++index6; }
          }
        }
        if (flag1)
          DeveloperReport.CreateBox();
      }
      DeveloperReport.CheckRC1();
      // ISSUE: reference to a compiler-generated field
      int num114 = checked (SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].NoofRoofs - 1);
      int index9 = 0;
      while (index9 <= num114)
      {
        // ISSUE: reference to a compiler-generated field
        if (SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Roofs[index9].Name != null)
        {
          XGraphics xgraphics84 = PDFFunctions.gfx[DeveloperReport.k];
          // ISSUE: reference to a compiler-generated field
          string name = SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Roofs[index9].Name;
          XFont xfont92 = xfont2;
          XSolidBrush black80 = XBrushes.Black;
          double rc1_77 = (double) DeveloperReport.RC1;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point84 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num115 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect84 = new XRect(20.0, rc1_77, point84, num115);
          XStringFormat topLeft84 = XStringFormat.TopLeft;
          xgraphics84.DrawString(name, xfont92, (XBrush) black80, xrect84, topLeft84);
        }
        XGraphics xgraphics85 = PDFFunctions.gfx[DeveloperReport.k];
        // ISSUE: reference to a compiler-generated field
        string str27 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Roofs[index9].U_Value);
        XFont xfont93 = xfont2;
        XSolidBrush black81 = XBrushes.Black;
        double rc1_78 = (double) DeveloperReport.RC1;
        xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
        double point85 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
        double num116 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect85 = new XRect(170.0, rc1_78, point85, num116);
        XStringFormat topLeft85 = XStringFormat.TopLeft;
        xgraphics85.DrawString(str27, xfont93, (XBrush) black81, xrect85, topLeft85);
        XGraphics xgraphics86 = PDFFunctions.gfx[DeveloperReport.k];
        XFont xfont94 = xfont8;
        XSolidBrush black82 = XBrushes.Black;
        double num117 = (double) checked (DeveloperReport.RC1 + 2);
        xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
        double point86 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
        double num118 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect86 = new XRect(200.0, num117, point86, num118);
        XStringFormat topLeft86 = XStringFormat.TopLeft;
        xgraphics86.DrawString("Please provide the U-Value calculation to justify the U-Value entered into the assessment.", xfont94, (XBrush) black82, xrect86, topLeft86);
        // ISSUE: reference to a compiler-generated field
        if ((uint) Operators.CompareString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].TMP.Type, "Calculated", false) > 0U)
        {
          XGraphics xgraphics87 = PDFFunctions.gfx[DeveloperReport.k];
          XFont xfont95 = xfont2;
          XSolidBrush black83 = XBrushes.Black;
          double rc1_79 = (double) DeveloperReport.RC1;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point87 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num119 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect87 = new XRect(542.0, rc1_79, point87, num119);
          XStringFormat topLeft87 = XStringFormat.TopLeft;
          xgraphics87.DrawString("N/A", xfont95, (XBrush) black83, xrect87, topLeft87);
        }
        else
        {
          XGraphics xgraphics88 = PDFFunctions.gfx[DeveloperReport.k];
          // ISSUE: reference to a compiler-generated field
          string str28 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Roofs[index9].K);
          XFont xfont96 = xfont2;
          XSolidBrush black84 = XBrushes.Black;
          double rc1_80 = (double) DeveloperReport.RC1;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point88 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num120 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect88 = new XRect(542.0, rc1_80, point88, num120);
          XStringFormat topLeft88 = XStringFormat.TopLeft;
          xgraphics88.DrawString(str28, xfont96, (XBrush) black84, xrect88, topLeft88);
        }
        DeveloperReport.CheckRC1();
        checked { DeveloperReport.RC1 += 12; }
        checked { ++index9; }
      }
      DeveloperReport.CheckRC1();
      if (SAP_Module.Proj.SAPUValues.SAPUValues != null)
      {
        int num121 = checked (((IEnumerable<Output.uValueInfo>) SAP_Module.Proj.SAPUValues.SAPUValues).Count<Output.uValueInfo>() - 1);
        int index10 = 0;
        while (index10 <= num121)
        {
          if (SAP_Module.Proj.SAPUValues.SAPUValues[index10].Roof.prop_elements != null)
            flag2 = true;
          checked { ++index10; }
        }
      }
      // ISSUE: reference to a compiler-generated field
      if (SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].NoofRoofs > 0)
      {
        if (flag2)
        {
          checked { DeveloperReport.RC1 += 12; }
          XGraphics xgraphics89 = PDFFunctions.gfx[DeveloperReport.k];
          XFont xfont97 = xfont6;
          XSolidBrush black85 = XBrushes.Black;
          double num122 = (double) checked (DeveloperReport.RC1 + 1);
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point89 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num123 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect89 = new XRect(20.0, num122, point89, num123);
          XStringFormat topLeft89 = XStringFormat.TopLeft;
          xgraphics89.DrawString("Materials Used:", xfont97, (XBrush) black85, xrect89, topLeft89);
          checked { DeveloperReport.RC1 += 14; }
          XGraphics xgraphics90 = PDFFunctions.gfx[DeveloperReport.k];
          XFont xfont98 = xfont6;
          XSolidBrush black86 = XBrushes.Black;
          double rc1_81 = (double) DeveloperReport.RC1;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point90 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num124 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect90 = new XRect(20.0, rc1_81, point90, num124);
          XStringFormat topLeft90 = XStringFormat.TopLeft;
          xgraphics90.DrawString("Type:", xfont98, (XBrush) black86, xrect90, topLeft90);
          XGraphics xgraphics91 = PDFFunctions.gfx[DeveloperReport.k];
          XFont xfont99 = xfont6;
          XSolidBrush black87 = XBrushes.Black;
          double rc1_82 = (double) DeveloperReport.RC1;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point91 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num125 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect91 = new XRect(170.0, rc1_82, point91, num125);
          XStringFormat topLeft91 = XStringFormat.TopLeft;
          xgraphics91.DrawString("Name:", xfont99, (XBrush) black87, xrect91, topLeft91);
          XGraphics xgraphics92 = PDFFunctions.gfx[DeveloperReport.k];
          XFont xfont100 = xfont6;
          XSolidBrush black88 = XBrushes.Black;
          double rc1_83 = (double) DeveloperReport.RC1;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point92 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num126 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect92 = new XRect(390.0, rc1_83, point92, num126);
          XStringFormat topLeft92 = XStringFormat.TopLeft;
          xgraphics92.DrawString("Thickness:", xfont100, (XBrush) black88, xrect92, topLeft92);
          XGraphics xgraphics93 = PDFFunctions.gfx[DeveloperReport.k];
          XFont xfont101 = xfont6;
          XSolidBrush black89 = XBrushes.Black;
          double rc1_84 = (double) DeveloperReport.RC1;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point93 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num127 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect93 = new XRect(450.0, rc1_84, point93, num127);
          XStringFormat topLeft93 = XStringFormat.TopLeft;
          xgraphics93.DrawString("Conductivity:", xfont101, (XBrush) black89, xrect93, topLeft93);
          XGraphics xgraphics94 = PDFFunctions.gfx[DeveloperReport.k];
          XFont xfont102 = xfont6;
          XSolidBrush black90 = XBrushes.Black;
          double rc1_85 = (double) DeveloperReport.RC1;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point94 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num128 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect94 = new XRect(530.0, rc1_85, point94, num128);
          XStringFormat topLeft94 = XStringFormat.TopLeft;
          xgraphics94.DrawString("R-Value:", xfont102, (XBrush) black90, xrect94, topLeft94);
          checked { DeveloperReport.RC1 += 14; }
          int num129 = checked (((IEnumerable<Output.uValueInfo>) SAP_Module.Proj.SAPUValues.SAPUValues).Count<Output.uValueInfo>() - 1);
          int index11 = 0;
          while (index11 <= num129)
          {
            if (SAP_Module.Proj.SAPUValues.SAPUValues[index11].Roof.prop_elements != null)
            {
              try
              {
                if (SAP_Module.Proj.SAPUValues.SAPUValues[index11].prop_entity_type.Equals("Roof"))
                {
                  int num130 = checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofRoofs - 1);
                  int index12 = 0;
                  while (index12 <= num130)
                  {
                    if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Roofs[index12].UValueSelected & SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Roofs[index12].UValueSelection == index11)
                    {
                      int num131 = checked (((IEnumerable<Output.UElement>) SAP_Module.Proj.SAPUValues.SAPUValues[index11].Roof.prop_elements).Count<Output.UElement>() - 1);
                      int index13 = 0;
                      while (index13 <= num131)
                      {
                        XGraphics xgraphics95 = PDFFunctions.gfx[DeveloperReport.k];
                        string name = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Roofs[index12].Name;
                        XFont xfont103 = xfont2;
                        XSolidBrush black91 = XBrushes.Black;
                        double rc1_86 = (double) DeveloperReport.RC1;
                        xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
                        double point95 = ((XUnit) ref xunit3).Point;
                        xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
                        double num132 = ((XUnit) ref xunit3).Point / 2.0;
                        XRect xrect95 = new XRect(20.0, rc1_86, point95, num132);
                        XStringFormat topLeft95 = XStringFormat.TopLeft;
                        xgraphics95.DrawString(name, xfont103, (XBrush) black91, xrect95, topLeft95);
                        XGraphics xgraphics96 = PDFFunctions.gfx[DeveloperReport.k];
                        string propName = SAP_Module.Proj.SAPUValues.SAPUValues[index11].Roof.prop_elements[index13].prop_name;
                        XFont xfont104 = xfont2;
                        XSolidBrush black92 = XBrushes.Black;
                        double rc1_87 = (double) DeveloperReport.RC1;
                        xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
                        double point96 = ((XUnit) ref xunit3).Point;
                        xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
                        double num133 = ((XUnit) ref xunit3).Point / 2.0;
                        XRect xrect96 = new XRect(170.0, rc1_87, point96, num133);
                        XStringFormat topLeft96 = XStringFormat.TopLeft;
                        xgraphics96.DrawString(propName, xfont104, (XBrush) black92, xrect96, topLeft96);
                        XGraphics xgraphics97 = PDFFunctions.gfx[DeveloperReport.k];
                        string str29 = Conversions.ToString(SAP_Module.Proj.SAPUValues.SAPUValues[index11].Roof.prop_elements[index13].prop_thickness);
                        XFont xfont105 = xfont2;
                        XSolidBrush black93 = XBrushes.Black;
                        double rc1_88 = (double) DeveloperReport.RC1;
                        xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
                        double point97 = ((XUnit) ref xunit3).Point;
                        xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
                        double num134 = ((XUnit) ref xunit3).Point / 2.0;
                        XRect xrect97 = new XRect(420.0, rc1_88, point97, num134);
                        XStringFormat topLeft97 = XStringFormat.TopLeft;
                        xgraphics97.DrawString(str29, xfont105, (XBrush) black93, xrect97, topLeft97);
                        XGraphics xgraphics98 = PDFFunctions.gfx[DeveloperReport.k];
                        string str30 = Conversions.ToString(SAP_Module.Proj.SAPUValues.SAPUValues[index11].Roof.prop_elements[index13].prop_thermal_conductivity);
                        XFont xfont106 = xfont2;
                        XSolidBrush black94 = XBrushes.Black;
                        double rc1_89 = (double) DeveloperReport.RC1;
                        xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
                        double point98 = ((XUnit) ref xunit3).Point;
                        xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
                        double num135 = ((XUnit) ref xunit3).Point / 2.0;
                        XRect xrect98 = new XRect(490.0, rc1_89, point98, num135);
                        XStringFormat topLeft98 = XStringFormat.TopLeft;
                        xgraphics98.DrawString(str30, xfont106, (XBrush) black94, xrect98, topLeft98);
                        XGraphics xgraphics99 = PDFFunctions.gfx[DeveloperReport.k];
                        string str31 = Conversions.ToString(Math.Round(SAP_Module.Proj.SAPUValues.SAPUValues[index11].Roof.prop_elements[index13].prop_thermal_resistance, 2));
                        XFont xfont107 = xfont2;
                        XSolidBrush black95 = XBrushes.Black;
                        double rc1_90 = (double) DeveloperReport.RC1;
                        xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
                        double point99 = ((XUnit) ref xunit3).Point;
                        xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
                        double num136 = ((XUnit) ref xunit3).Point / 2.0;
                        XRect xrect99 = new XRect(550.0, rc1_90, point99, num136);
                        XStringFormat topLeft99 = XStringFormat.TopLeft;
                        xgraphics99.DrawString(str31, xfont107, (XBrush) black95, xrect99, topLeft99);
                        DeveloperReport.CheckRC1();
                        checked { DeveloperReport.RC1 += 12; }
                        checked { ++index13; }
                      }
                    }
                    checked { ++index12; }
                  }
                }
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
              }
            }
            checked { ++index11; }
          }
        }
        if (flag2)
          DeveloperReport.CreateBox();
      }
      DeveloperReport.CheckRC1();
      // ISSUE: reference to a compiler-generated field
      int num137 = checked (SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].NoofFloors - 1);
      int index14 = 0;
      while (index14 <= num137)
      {
        // ISSUE: reference to a compiler-generated field
        if (SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Floors[index14].Name != null)
        {
          XGraphics xgraphics100 = PDFFunctions.gfx[DeveloperReport.k];
          // ISSUE: reference to a compiler-generated field
          string name = SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Floors[index14].Name;
          XFont xfont108 = xfont2;
          XSolidBrush black96 = XBrushes.Black;
          double rc1_91 = (double) DeveloperReport.RC1;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point100 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num138 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect100 = new XRect(20.0, rc1_91, point100, num138);
          XStringFormat topLeft100 = XStringFormat.TopLeft;
          xgraphics100.DrawString(name, xfont108, (XBrush) black96, xrect100, topLeft100);
        }
        XGraphics xgraphics101 = PDFFunctions.gfx[DeveloperReport.k];
        // ISSUE: reference to a compiler-generated field
        string str32 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Floors[index14].U_Value);
        XFont xfont109 = xfont2;
        XSolidBrush black97 = XBrushes.Black;
        double rc1_92 = (double) DeveloperReport.RC1;
        xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
        double point101 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
        double num139 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect101 = new XRect(170.0, rc1_92, point101, num139);
        XStringFormat topLeft101 = XStringFormat.TopLeft;
        xgraphics101.DrawString(str32, xfont109, (XBrush) black97, xrect101, topLeft101);
        XGraphics xgraphics102 = PDFFunctions.gfx[DeveloperReport.k];
        XFont xfont110 = xfont8;
        XSolidBrush black98 = XBrushes.Black;
        double num140 = (double) checked (DeveloperReport.RC1 + 2);
        xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
        double point102 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
        double num141 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect102 = new XRect(200.0, num140, point102, num141);
        XStringFormat topLeft102 = XStringFormat.TopLeft;
        xgraphics102.DrawString("Please provide the U-Value calculation to justify the U-Value entered into the assessment.", xfont110, (XBrush) black98, xrect102, topLeft102);
        // ISSUE: reference to a compiler-generated field
        if ((uint) Operators.CompareString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].TMP.Type, "Calculated", false) > 0U)
        {
          XGraphics xgraphics103 = PDFFunctions.gfx[DeveloperReport.k];
          XFont xfont111 = xfont2;
          XSolidBrush black99 = XBrushes.Black;
          double rc1_93 = (double) DeveloperReport.RC1;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point103 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num142 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect103 = new XRect(542.0, rc1_93, point103, num142);
          XStringFormat topLeft103 = XStringFormat.TopLeft;
          xgraphics103.DrawString("N/A", xfont111, (XBrush) black99, xrect103, topLeft103);
        }
        else
        {
          XGraphics xgraphics104 = PDFFunctions.gfx[DeveloperReport.k];
          // ISSUE: reference to a compiler-generated field
          string str33 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Floors[index14].K);
          XFont xfont112 = xfont2;
          XSolidBrush black100 = XBrushes.Black;
          double rc1_94 = (double) DeveloperReport.RC1;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point104 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num143 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect104 = new XRect(542.0, rc1_94, point104, num143);
          XStringFormat topLeft104 = XStringFormat.TopLeft;
          xgraphics104.DrawString(str33, xfont112, (XBrush) black100, xrect104, topLeft104);
        }
        DeveloperReport.CheckRC1();
        checked { DeveloperReport.RC1 += 12; }
        checked { ++index14; }
      }
      DeveloperReport.CheckRC1();
      if (SAP_Module.Proj.SAPUValues.SAPUValues != null)
      {
        int num144 = checked (((IEnumerable<Output.uValueInfo>) SAP_Module.Proj.SAPUValues.SAPUValues).Count<Output.uValueInfo>() - 1);
        int index15 = 0;
        while (index15 <= num144)
        {
          if (SAP_Module.Proj.SAPUValues.SAPUValues[index15].Roof.prop_elements != null)
            flag3 = true;
          checked { ++index15; }
        }
      }
      // ISSUE: reference to a compiler-generated field
      if (SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].NoofFloors > 0)
      {
        if (flag3)
        {
          checked { DeveloperReport.RC1 += 12; }
          XGraphics xgraphics105 = PDFFunctions.gfx[DeveloperReport.k];
          XFont xfont113 = xfont6;
          XSolidBrush black101 = XBrushes.Black;
          double num145 = (double) checked (DeveloperReport.RC1 + 1);
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point105 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num146 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect105 = new XRect(20.0, num145, point105, num146);
          XStringFormat topLeft105 = XStringFormat.TopLeft;
          xgraphics105.DrawString("Materials Used:", xfont113, (XBrush) black101, xrect105, topLeft105);
          checked { DeveloperReport.RC1 += 14; }
          XGraphics xgraphics106 = PDFFunctions.gfx[DeveloperReport.k];
          XFont xfont114 = xfont6;
          XSolidBrush black102 = XBrushes.Black;
          double rc1_95 = (double) DeveloperReport.RC1;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point106 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num147 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect106 = new XRect(20.0, rc1_95, point106, num147);
          XStringFormat topLeft106 = XStringFormat.TopLeft;
          xgraphics106.DrawString("Type:", xfont114, (XBrush) black102, xrect106, topLeft106);
          XGraphics xgraphics107 = PDFFunctions.gfx[DeveloperReport.k];
          XFont xfont115 = xfont6;
          XSolidBrush black103 = XBrushes.Black;
          double rc1_96 = (double) DeveloperReport.RC1;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point107 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num148 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect107 = new XRect(170.0, rc1_96, point107, num148);
          XStringFormat topLeft107 = XStringFormat.TopLeft;
          xgraphics107.DrawString("Name:", xfont115, (XBrush) black103, xrect107, topLeft107);
          XGraphics xgraphics108 = PDFFunctions.gfx[DeveloperReport.k];
          XFont xfont116 = xfont6;
          XSolidBrush black104 = XBrushes.Black;
          double rc1_97 = (double) DeveloperReport.RC1;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point108 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num149 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect108 = new XRect(390.0, rc1_97, point108, num149);
          XStringFormat topLeft108 = XStringFormat.TopLeft;
          xgraphics108.DrawString("Thickness:", xfont116, (XBrush) black104, xrect108, topLeft108);
          XGraphics xgraphics109 = PDFFunctions.gfx[DeveloperReport.k];
          XFont xfont117 = xfont6;
          XSolidBrush black105 = XBrushes.Black;
          double rc1_98 = (double) DeveloperReport.RC1;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point109 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num150 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect109 = new XRect(450.0, rc1_98, point109, num150);
          XStringFormat topLeft109 = XStringFormat.TopLeft;
          xgraphics109.DrawString("Conductivity:", xfont117, (XBrush) black105, xrect109, topLeft109);
          XGraphics xgraphics110 = PDFFunctions.gfx[DeveloperReport.k];
          XFont xfont118 = xfont6;
          XSolidBrush black106 = XBrushes.Black;
          double rc1_99 = (double) DeveloperReport.RC1;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point110 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num151 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect110 = new XRect(530.0, rc1_99, point110, num151);
          XStringFormat topLeft110 = XStringFormat.TopLeft;
          xgraphics110.DrawString("R-Value:", xfont118, (XBrush) black106, xrect110, topLeft110);
          checked { DeveloperReport.RC1 += 14; }
          int num152 = checked (((IEnumerable<Output.uValueInfo>) SAP_Module.Proj.SAPUValues.SAPUValues).Count<Output.uValueInfo>() - 1);
          int index16 = 0;
          while (index16 <= num152)
          {
            if (SAP_Module.Proj.SAPUValues.SAPUValues[index16].Floor.prop_elements != null)
            {
              try
              {
                if (SAP_Module.Proj.SAPUValues.SAPUValues[index16].prop_entity_type.Equals("Floor"))
                {
                  int num153 = checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofFloors - 1);
                  int index17 = 0;
                  while (index17 <= num153)
                  {
                    if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Floors[index17].UValueSelected & SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Floors[index17].UValueSelection == index16)
                    {
                      int num154 = checked (((IEnumerable<Output.UElement>) SAP_Module.Proj.SAPUValues.SAPUValues[index16].Floor.prop_elements).Count<Output.UElement>() - 1);
                      int index18 = 0;
                      while (index18 <= num154)
                      {
                        XGraphics xgraphics111 = PDFFunctions.gfx[DeveloperReport.k];
                        string name = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Floors[index17].Name;
                        XFont xfont119 = xfont2;
                        XSolidBrush black107 = XBrushes.Black;
                        double rc1_100 = (double) DeveloperReport.RC1;
                        xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
                        double point111 = ((XUnit) ref xunit3).Point;
                        xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
                        double num155 = ((XUnit) ref xunit3).Point / 2.0;
                        XRect xrect111 = new XRect(20.0, rc1_100, point111, num155);
                        XStringFormat topLeft111 = XStringFormat.TopLeft;
                        xgraphics111.DrawString(name, xfont119, (XBrush) black107, xrect111, topLeft111);
                        XGraphics xgraphics112 = PDFFunctions.gfx[DeveloperReport.k];
                        string propName = SAP_Module.Proj.SAPUValues.SAPUValues[index16].Floor.prop_elements[index18].prop_name;
                        XFont xfont120 = xfont2;
                        XSolidBrush black108 = XBrushes.Black;
                        double rc1_101 = (double) DeveloperReport.RC1;
                        xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
                        double point112 = ((XUnit) ref xunit3).Point;
                        xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
                        double num156 = ((XUnit) ref xunit3).Point / 2.0;
                        XRect xrect112 = new XRect(170.0, rc1_101, point112, num156);
                        XStringFormat topLeft112 = XStringFormat.TopLeft;
                        xgraphics112.DrawString(propName, xfont120, (XBrush) black108, xrect112, topLeft112);
                        XGraphics xgraphics113 = PDFFunctions.gfx[DeveloperReport.k];
                        string str34 = Conversions.ToString(SAP_Module.Proj.SAPUValues.SAPUValues[index16].Floor.prop_elements[index18].prop_thickness);
                        XFont xfont121 = xfont2;
                        XSolidBrush black109 = XBrushes.Black;
                        double rc1_102 = (double) DeveloperReport.RC1;
                        xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
                        double point113 = ((XUnit) ref xunit3).Point;
                        xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
                        double num157 = ((XUnit) ref xunit3).Point / 2.0;
                        XRect xrect113 = new XRect(420.0, rc1_102, point113, num157);
                        XStringFormat topLeft113 = XStringFormat.TopLeft;
                        xgraphics113.DrawString(str34, xfont121, (XBrush) black109, xrect113, topLeft113);
                        XGraphics xgraphics114 = PDFFunctions.gfx[DeveloperReport.k];
                        string str35 = Conversions.ToString(SAP_Module.Proj.SAPUValues.SAPUValues[index16].Floor.prop_elements[index18].prop_thermal_conductivity);
                        XFont xfont122 = xfont2;
                        XSolidBrush black110 = XBrushes.Black;
                        double rc1_103 = (double) DeveloperReport.RC1;
                        xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
                        double point114 = ((XUnit) ref xunit3).Point;
                        xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
                        double num158 = ((XUnit) ref xunit3).Point / 2.0;
                        XRect xrect114 = new XRect(490.0, rc1_103, point114, num158);
                        XStringFormat topLeft114 = XStringFormat.TopLeft;
                        xgraphics114.DrawString(str35, xfont122, (XBrush) black110, xrect114, topLeft114);
                        XGraphics xgraphics115 = PDFFunctions.gfx[DeveloperReport.k];
                        string str36 = Conversions.ToString(Math.Round(SAP_Module.Proj.SAPUValues.SAPUValues[index16].Floor.prop_elements[index18].prop_thermal_resistance, 2));
                        XFont xfont123 = xfont2;
                        XSolidBrush black111 = XBrushes.Black;
                        double rc1_104 = (double) DeveloperReport.RC1;
                        xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
                        double point115 = ((XUnit) ref xunit3).Point;
                        xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
                        double num159 = ((XUnit) ref xunit3).Point / 2.0;
                        XRect xrect115 = new XRect(550.0, rc1_104, point115, num159);
                        XStringFormat topLeft115 = XStringFormat.TopLeft;
                        xgraphics115.DrawString(str36, xfont123, (XBrush) black111, xrect115, topLeft115);
                        DeveloperReport.CheckRC1();
                        checked { DeveloperReport.RC1 += 12; }
                        checked { ++index18; }
                      }
                    }
                    checked { ++index17; }
                  }
                }
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
              }
            }
            checked { ++index16; }
          }
        }
        if (flag3)
          DeveloperReport.CreateBox();
      }
      DeveloperReport.CheckRC1();
      XGraphics xgraphics116 = PDFFunctions.gfx[DeveloperReport.k];
      XFont xfont124 = xfont4;
      XSolidBrush black112 = XBrushes.Black;
      double rc1_105 = (double) DeveloperReport.RC1;
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
      double point116 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
      double num160 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect116 = new XRect(20.0, rc1_105, point116, num160);
      XStringFormat topLeft116 = XStringFormat.TopLeft;
      xgraphics116.DrawString("Internal Elements (Area, Kappa)", xfont124, (XBrush) black112, xrect116, topLeft116);
      checked { DeveloperReport.RC1 += 12; }
      // ISSUE: reference to a compiler-generated field
      int num161 = checked (SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].NoofIWalls - 1);
      int index19 = 0;
      while (index19 <= num161)
      {
        // ISSUE: reference to a compiler-generated field
        if (SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].IWalls[index19].Name != null)
        {
          XGraphics xgraphics117 = PDFFunctions.gfx[DeveloperReport.k];
          // ISSUE: reference to a compiler-generated field
          string name = SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].IWalls[index19].Name;
          XFont xfont125 = xfont2;
          XSolidBrush black113 = XBrushes.Black;
          double rc1_106 = (double) DeveloperReport.RC1;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point117 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num162 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect117 = new XRect(20.0, rc1_106, point117, num162);
          XStringFormat topLeft117 = XStringFormat.TopLeft;
          xgraphics117.DrawString(name, xfont125, (XBrush) black113, xrect117, topLeft117);
        }
        XGraphics xgraphics118 = PDFFunctions.gfx[DeveloperReport.k];
        // ISSUE: reference to a compiler-generated field
        string str37 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].IWalls[index19].Area);
        XFont xfont126 = xfont2;
        XSolidBrush black114 = XBrushes.Black;
        double rc1_107 = (double) DeveloperReport.RC1;
        xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
        double point118 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
        double num163 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect118 = new XRect(120.0, rc1_107, point118, num163);
        XStringFormat topLeft118 = XStringFormat.TopLeft;
        xgraphics118.DrawString(str37, xfont126, (XBrush) black114, xrect118, topLeft118);
        // ISSUE: reference to a compiler-generated field
        if ((uint) Operators.CompareString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].TMP.Type, "Calculated", false) > 0U)
        {
          XGraphics xgraphics119 = PDFFunctions.gfx[DeveloperReport.k];
          XFont xfont127 = xfont2;
          XSolidBrush black115 = XBrushes.Black;
          double rc1_108 = (double) DeveloperReport.RC1;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point119 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num164 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect119 = new XRect(542.0, rc1_108, point119, num164);
          XStringFormat topLeft119 = XStringFormat.TopLeft;
          xgraphics119.DrawString("N/A", xfont127, (XBrush) black115, xrect119, topLeft119);
        }
        else
        {
          XGraphics xgraphics120 = PDFFunctions.gfx[DeveloperReport.k];
          // ISSUE: reference to a compiler-generated field
          string str38 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].IWalls[index19].K);
          XFont xfont128 = xfont2;
          XSolidBrush black116 = XBrushes.Black;
          double rc1_109 = (double) DeveloperReport.RC1;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point120 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num165 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect120 = new XRect(542.0, rc1_109, point120, num165);
          XStringFormat topLeft120 = XStringFormat.TopLeft;
          xgraphics120.DrawString(str38, xfont128, (XBrush) black116, xrect120, topLeft120);
        }
        DeveloperReport.CheckRC1();
        checked { DeveloperReport.RC1 += 12; }
        checked { ++index19; }
      }
      DeveloperReport.CheckRC1();
      // ISSUE: reference to a compiler-generated field
      if (SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].NoofIWalls > 0)
        DeveloperReport.CreateBox();
      DeveloperReport.CheckRC1();
      // ISSUE: reference to a compiler-generated field
      int num166 = checked (SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].NoofICeilings - 1);
      int index20 = 0;
      while (index20 <= num166)
      {
        // ISSUE: reference to a compiler-generated field
        if (SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].ICeilings[index20].Name != null)
        {
          XGraphics xgraphics121 = PDFFunctions.gfx[DeveloperReport.k];
          // ISSUE: reference to a compiler-generated field
          string name = SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].ICeilings[index20].Name;
          XFont xfont129 = xfont2;
          XSolidBrush black117 = XBrushes.Black;
          double rc1_110 = (double) DeveloperReport.RC1;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point121 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num167 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect121 = new XRect(20.0, rc1_110, point121, num167);
          XStringFormat topLeft121 = XStringFormat.TopLeft;
          xgraphics121.DrawString(name, xfont129, (XBrush) black117, xrect121, topLeft121);
        }
        XGraphics xgraphics122 = PDFFunctions.gfx[DeveloperReport.k];
        // ISSUE: reference to a compiler-generated field
        string str39 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].ICeilings[index20].Area);
        XFont xfont130 = xfont2;
        XSolidBrush black118 = XBrushes.Black;
        double rc1_111 = (double) DeveloperReport.RC1;
        xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
        double point122 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
        double num168 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect122 = new XRect(120.0, rc1_111, point122, num168);
        XStringFormat topLeft122 = XStringFormat.TopLeft;
        xgraphics122.DrawString(str39, xfont130, (XBrush) black118, xrect122, topLeft122);
        // ISSUE: reference to a compiler-generated field
        if ((uint) Operators.CompareString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].TMP.Type, "Calculated", false) > 0U)
        {
          XGraphics xgraphics123 = PDFFunctions.gfx[DeveloperReport.k];
          XFont xfont131 = xfont2;
          XSolidBrush black119 = XBrushes.Black;
          double rc1_112 = (double) DeveloperReport.RC1;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point123 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num169 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect123 = new XRect(542.0, rc1_112, point123, num169);
          XStringFormat topLeft123 = XStringFormat.TopLeft;
          xgraphics123.DrawString("N/A", xfont131, (XBrush) black119, xrect123, topLeft123);
        }
        else
        {
          XGraphics xgraphics124 = PDFFunctions.gfx[DeveloperReport.k];
          // ISSUE: reference to a compiler-generated field
          string str40 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].ICeilings[index20].K);
          XFont xfont132 = xfont2;
          XSolidBrush black120 = XBrushes.Black;
          double rc1_113 = (double) DeveloperReport.RC1;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point124 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num170 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect124 = new XRect(542.0, rc1_113, point124, num170);
          XStringFormat topLeft124 = XStringFormat.TopLeft;
          xgraphics124.DrawString(str40, xfont132, (XBrush) black120, xrect124, topLeft124);
        }
        DeveloperReport.CheckRC1();
        checked { DeveloperReport.RC1 += 12; }
        checked { ++index20; }
      }
      DeveloperReport.CheckRC1();
      // ISSUE: reference to a compiler-generated field
      if (SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].NoofICeilings > 0)
        DeveloperReport.CreateBox();
      DeveloperReport.CheckRC1();
      // ISSUE: reference to a compiler-generated field
      int num171 = checked (SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].NoofIFloors - 1);
      int index21 = 0;
      while (index21 <= num171)
      {
        // ISSUE: reference to a compiler-generated field
        if (SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].IFloors[index21].Name != null)
        {
          XGraphics xgraphics125 = PDFFunctions.gfx[DeveloperReport.k];
          // ISSUE: reference to a compiler-generated field
          string name = SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].IFloors[index21].Name;
          XFont xfont133 = xfont2;
          XSolidBrush black121 = XBrushes.Black;
          double rc1_114 = (double) DeveloperReport.RC1;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point125 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num172 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect125 = new XRect(20.0, rc1_114, point125, num172);
          XStringFormat topLeft125 = XStringFormat.TopLeft;
          xgraphics125.DrawString(name, xfont133, (XBrush) black121, xrect125, topLeft125);
        }
        XGraphics xgraphics126 = PDFFunctions.gfx[DeveloperReport.k];
        // ISSUE: reference to a compiler-generated field
        string str41 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].IFloors[index21].Area);
        XFont xfont134 = xfont2;
        XSolidBrush black122 = XBrushes.Black;
        double rc1_115 = (double) DeveloperReport.RC1;
        xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
        double point126 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
        double num173 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect126 = new XRect(120.0, rc1_115, point126, num173);
        XStringFormat topLeft126 = XStringFormat.TopLeft;
        xgraphics126.DrawString(str41, xfont134, (XBrush) black122, xrect126, topLeft126);
        // ISSUE: reference to a compiler-generated field
        if ((uint) Operators.CompareString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].TMP.Type, "Calculated", false) > 0U)
        {
          XGraphics xgraphics127 = PDFFunctions.gfx[DeveloperReport.k];
          XFont xfont135 = xfont2;
          XSolidBrush black123 = XBrushes.Black;
          double rc1_116 = (double) DeveloperReport.RC1;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point127 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num174 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect127 = new XRect(542.0, rc1_116, point127, num174);
          XStringFormat topLeft127 = XStringFormat.TopLeft;
          xgraphics127.DrawString("N/A", xfont135, (XBrush) black123, xrect127, topLeft127);
        }
        else
        {
          XGraphics xgraphics128 = PDFFunctions.gfx[DeveloperReport.k];
          // ISSUE: reference to a compiler-generated field
          string str42 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].IFloors[index21].K);
          XFont xfont136 = xfont2;
          XSolidBrush black124 = XBrushes.Black;
          double rc1_117 = (double) DeveloperReport.RC1;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point128 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num175 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect128 = new XRect(542.0, rc1_117, point128, num175);
          XStringFormat topLeft128 = XStringFormat.TopLeft;
          xgraphics128.DrawString(str42, xfont136, (XBrush) black124, xrect128, topLeft128);
        }
        checked { DeveloperReport.RC1 += 12; }
        checked { ++index21; }
      }
      DeveloperReport.CheckRC1();
      // ISSUE: reference to a compiler-generated field
      if (SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].NoofIFloors > 0)
        DeveloperReport.CreateBox();
      DeveloperReport.CheckRC1();
      XGraphics xgraphics129 = PDFFunctions.gfx[DeveloperReport.k];
      XFont xfont137 = xfont4;
      XSolidBrush black125 = XBrushes.Black;
      double rc1_118 = (double) DeveloperReport.RC1;
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
      double point129 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
      double num176 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect129 = new XRect(20.0, rc1_118, point129, num176);
      XStringFormat topLeft129 = XStringFormat.TopLeft;
      xgraphics129.DrawString("Party Elements (Area, Kappa)", xfont137, (XBrush) black125, xrect129, topLeft129);
      checked { DeveloperReport.RC1 += 12; }
      // ISSUE: reference to a compiler-generated field
      int num177 = checked (SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].NoofPWalls - 1);
      int index22 = 0;
      while (index22 <= num177)
      {
        // ISSUE: reference to a compiler-generated field
        if (SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].PWalls[index22].Name != null)
        {
          XGraphics xgraphics130 = PDFFunctions.gfx[DeveloperReport.k];
          // ISSUE: reference to a compiler-generated field
          string name = SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].PWalls[index22].Name;
          XFont xfont138 = xfont2;
          XSolidBrush black126 = XBrushes.Black;
          double rc1_119 = (double) DeveloperReport.RC1;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point130 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num178 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect130 = new XRect(20.0, rc1_119, point130, num178);
          XStringFormat topLeft130 = XStringFormat.TopLeft;
          xgraphics130.DrawString(name, xfont138, (XBrush) black126, xrect130, topLeft130);
        }
        XGraphics xgraphics131 = PDFFunctions.gfx[DeveloperReport.k];
        // ISSUE: reference to a compiler-generated field
        string str43 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].PWalls[index22].Area);
        XFont xfont139 = xfont2;
        XSolidBrush black127 = XBrushes.Black;
        double rc1_120 = (double) DeveloperReport.RC1;
        xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
        double point131 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
        double num179 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect131 = new XRect(120.0, rc1_120, point131, num179);
        XStringFormat topLeft131 = XStringFormat.TopLeft;
        xgraphics131.DrawString(str43, xfont139, (XBrush) black127, xrect131, topLeft131);
        // ISSUE: reference to a compiler-generated field
        if ((uint) Operators.CompareString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].TMP.Type, "Calculated", false) > 0U)
        {
          XGraphics xgraphics132 = PDFFunctions.gfx[DeveloperReport.k];
          XFont xfont140 = xfont2;
          XSolidBrush black128 = XBrushes.Black;
          double rc1_121 = (double) DeveloperReport.RC1;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point132 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num180 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect132 = new XRect(542.0, rc1_121, point132, num180);
          XStringFormat topLeft132 = XStringFormat.TopLeft;
          xgraphics132.DrawString("N/A", xfont140, (XBrush) black128, xrect132, topLeft132);
        }
        else
        {
          XGraphics xgraphics133 = PDFFunctions.gfx[DeveloperReport.k];
          // ISSUE: reference to a compiler-generated field
          string str44 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].PWalls[index22].K);
          XFont xfont141 = xfont2;
          XSolidBrush black129 = XBrushes.Black;
          double rc1_122 = (double) DeveloperReport.RC1;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point133 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num181 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect133 = new XRect(542.0, rc1_122, point133, num181);
          XStringFormat topLeft133 = XStringFormat.TopLeft;
          xgraphics133.DrawString(str44, xfont141, (XBrush) black129, xrect133, topLeft133);
        }
        DeveloperReport.CheckRC1();
        checked { DeveloperReport.RC1 += 12; }
        checked { ++index22; }
      }
      DeveloperReport.CheckRC1();
      // ISSUE: reference to a compiler-generated field
      if (SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].NoofPWalls > 0)
        DeveloperReport.CreateBox();
      DeveloperReport.CheckRC1();
      // ISSUE: reference to a compiler-generated field
      if (SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].NoofPCeilings > 0)
      {
        // ISSUE: reference to a compiler-generated field
        int num182 = checked (SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].NoofPCeilings - 1);
        int index23 = 0;
        while (index23 <= num182)
        {
          XGraphics xgraphics134 = PDFFunctions.gfx[DeveloperReport.k];
          // ISSUE: reference to a compiler-generated field
          string name = SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].PCeilings[index23].Name;
          XFont xfont142 = xfont2;
          XSolidBrush black130 = XBrushes.Black;
          double rc1_123 = (double) DeveloperReport.RC1;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point134 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num183 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect134 = new XRect(20.0, rc1_123, point134, num183);
          XStringFormat topLeft134 = XStringFormat.TopLeft;
          xgraphics134.DrawString(name, xfont142, (XBrush) black130, xrect134, topLeft134);
          XGraphics xgraphics135 = PDFFunctions.gfx[DeveloperReport.k];
          // ISSUE: reference to a compiler-generated field
          string str45 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].PCeilings[index23].Area);
          XFont xfont143 = xfont2;
          XSolidBrush black131 = XBrushes.Black;
          double rc1_124 = (double) DeveloperReport.RC1;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point135 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num184 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect135 = new XRect(120.0, rc1_124, point135, num184);
          XStringFormat topLeft135 = XStringFormat.TopLeft;
          xgraphics135.DrawString(str45, xfont143, (XBrush) black131, xrect135, topLeft135);
          // ISSUE: reference to a compiler-generated field
          if ((uint) Operators.CompareString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].TMP.Type, "Calculated", false) > 0U)
          {
            XGraphics xgraphics136 = PDFFunctions.gfx[DeveloperReport.k];
            XFont xfont144 = xfont2;
            XSolidBrush black132 = XBrushes.Black;
            double rc1_125 = (double) DeveloperReport.RC1;
            xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
            double point136 = ((XUnit) ref xunit3).Point;
            xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
            double num185 = ((XUnit) ref xunit3).Point / 2.0;
            XRect xrect136 = new XRect(542.0, rc1_125, point136, num185);
            XStringFormat topLeft136 = XStringFormat.TopLeft;
            xgraphics136.DrawString("N/A", xfont144, (XBrush) black132, xrect136, topLeft136);
          }
          else
          {
            XGraphics xgraphics137 = PDFFunctions.gfx[DeveloperReport.k];
            // ISSUE: reference to a compiler-generated field
            string str46 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].PCeilings[index23].K);
            XFont xfont145 = xfont2;
            XSolidBrush black133 = XBrushes.Black;
            double rc1_126 = (double) DeveloperReport.RC1;
            xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
            double point137 = ((XUnit) ref xunit3).Point;
            xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
            double num186 = ((XUnit) ref xunit3).Point / 2.0;
            XRect xrect137 = new XRect(542.0, rc1_126, point137, num186);
            XStringFormat topLeft137 = XStringFormat.TopLeft;
            xgraphics137.DrawString(str46, xfont145, (XBrush) black133, xrect137, topLeft137);
          }
          DeveloperReport.CheckRC1();
          checked { DeveloperReport.RC1 += 12; }
          checked { ++index23; }
        }
      }
      DeveloperReport.CheckRC1();
      // ISSUE: reference to a compiler-generated field
      if (SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].NoofPCeilings > 0)
        DeveloperReport.CreateBox();
      DeveloperReport.CheckRC1();
      // ISSUE: reference to a compiler-generated field
      if (SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].NoofpFloors > 0)
      {
        try
        {
          // ISSUE: reference to a compiler-generated field
          int num187 = checked (SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].NoofpFloors - 1);
          int index24 = 0;
          while (index24 <= num187)
          {
            XGraphics xgraphics138 = PDFFunctions.gfx[DeveloperReport.k];
            // ISSUE: reference to a compiler-generated field
            string name = SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].PFloors[index24].Name;
            XFont xfont146 = xfont2;
            XSolidBrush black134 = XBrushes.Black;
            double rc1_127 = (double) DeveloperReport.RC1;
            xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
            double point138 = ((XUnit) ref xunit3).Point;
            xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
            double num188 = ((XUnit) ref xunit3).Point / 2.0;
            XRect xrect138 = new XRect(20.0, rc1_127, point138, num188);
            XStringFormat topLeft138 = XStringFormat.TopLeft;
            xgraphics138.DrawString(name, xfont146, (XBrush) black134, xrect138, topLeft138);
            XGraphics xgraphics139 = PDFFunctions.gfx[DeveloperReport.k];
            // ISSUE: reference to a compiler-generated field
            string str47 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].PFloors[index24].Area);
            XFont xfont147 = xfont2;
            XSolidBrush black135 = XBrushes.Black;
            double rc1_128 = (double) DeveloperReport.RC1;
            xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
            double point139 = ((XUnit) ref xunit3).Point;
            xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
            double num189 = ((XUnit) ref xunit3).Point / 2.0;
            XRect xrect139 = new XRect(120.0, rc1_128, point139, num189);
            XStringFormat topLeft139 = XStringFormat.TopLeft;
            xgraphics139.DrawString(str47, xfont147, (XBrush) black135, xrect139, topLeft139);
            // ISSUE: reference to a compiler-generated field
            if ((uint) Operators.CompareString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].TMP.Type, "Calculated", false) > 0U)
            {
              XGraphics xgraphics140 = PDFFunctions.gfx[DeveloperReport.k];
              XFont xfont148 = xfont2;
              XSolidBrush black136 = XBrushes.Black;
              double rc1_129 = (double) DeveloperReport.RC1;
              xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
              double point140 = ((XUnit) ref xunit3).Point;
              xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
              double num190 = ((XUnit) ref xunit3).Point / 2.0;
              XRect xrect140 = new XRect(542.0, rc1_129, point140, num190);
              XStringFormat topLeft140 = XStringFormat.TopLeft;
              xgraphics140.DrawString("N/A", xfont148, (XBrush) black136, xrect140, topLeft140);
            }
            else
            {
              XGraphics xgraphics141 = PDFFunctions.gfx[DeveloperReport.k];
              // ISSUE: reference to a compiler-generated field
              string str48 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].PFloors[index24].K);
              XFont xfont149 = xfont2;
              XSolidBrush black137 = XBrushes.Black;
              double rc1_130 = (double) DeveloperReport.RC1;
              xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
              double point141 = ((XUnit) ref xunit3).Point;
              xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
              double num191 = ((XUnit) ref xunit3).Point / 2.0;
              XRect xrect141 = new XRect(542.0, rc1_130, point141, num191);
              XStringFormat topLeft141 = XStringFormat.TopLeft;
              xgraphics141.DrawString(str48, xfont149, (XBrush) black137, xrect141, topLeft141);
            }
            DeveloperReport.CheckRC1();
            checked { DeveloperReport.RC1 += 12; }
            checked { ++index24; }
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
      }
      DeveloperReport.CheckRC1();
      // ISSUE: reference to a compiler-generated field
      if (SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].NoofpFloors > 0)
        DeveloperReport.CreateBox();
      DeveloperReport.CheckRC1();
      checked { DeveloperReport.RC1 += 16; }
      PDFFunctions.xBrush1 = XBrush.op_Implicit((Brush) new SolidBrush(Color.FromArgb(159, 172, 62)));
      PDFFunctions.Points[0].X = 20f;
      PDFFunctions.Points[0].Y = (float) DeveloperReport.RC1;
      ref PointF local9 = ref PDFFunctions.Points[1];
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
      double num192 = ((XUnit) ref xunit3).Point - 20.0;
      local9.X = (float) num192;
      PDFFunctions.Points[1].Y = (float) DeveloperReport.RC1;
      ref PointF local10 = ref PDFFunctions.Points[2];
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
      double num193 = ((XUnit) ref xunit3).Point - 20.0;
      local10.X = (float) num193;
      PDFFunctions.Points[2].Y = (float) checked (DeveloperReport.RC1 + 16);
      PDFFunctions.Points[3].X = 20f;
      PDFFunctions.Points[3].Y = (float) checked (DeveloperReport.RC1 + 16);
      PDFFunctions.gfx[DeveloperReport.k].DrawPolygon(PDFFunctions.polyGreen2, PDFFunctions.xBrush1, PDFFunctions.Points, xfillMode);
      XGraphics xgraphics142 = PDFFunctions.gfx[DeveloperReport.k];
      XFont xfont150 = xfont3;
      XSolidBrush white5 = XBrushes.White;
      double num194 = (double) checked (DeveloperReport.RC1 + 1);
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
      double point142 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
      double num195 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect142 = new XRect(25.0, num194, point142, num195);
      XStringFormat topLeft142 = XStringFormat.TopLeft;
      xgraphics142.DrawString("Thermal bridges:", xfont150, (XBrush) white5, xrect142, topLeft142);
      DeveloperReport.RC1 = checked ((int) Math.Round(unchecked ((double) PDFFunctions.Points[3].Y + 6.0)));
      DeveloperReport.CheckRC1();
      // ISSUE: reference to a compiler-generated field
      if (SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Thermal.ManualHtb)
      {
        XGraphics xgraphics143 = PDFFunctions.gfx[DeveloperReport.k];
        XFont xfont151 = xfont2;
        XSolidBrush black138 = XBrushes.Black;
        double rc1_131 = (double) DeveloperReport.RC1;
        xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
        double point143 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
        double num196 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect143 = new XRect(20.0, rc1_131, point143, num196);
        XStringFormat topLeft143 = XStringFormat.TopLeft;
        xgraphics143.DrawString("Thermal bridges:", xfont151, (XBrush) black138, xrect143, topLeft143);
        try
        {
          XGraphics xgraphics144 = PDFFunctions.gfx[DeveloperReport.k];
          string str49 = "User-defined (individual PSI-values) Y-Value =  " + Conversions.ToString(DeveloperReport.ShowY());
          XFont xfont152 = xfont2;
          XSolidBrush black139 = XBrushes.Black;
          double rc1_132 = (double) DeveloperReport.RC1;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point144 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num197 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect144 = new XRect(200.0, rc1_132, point144, num197);
          XStringFormat topLeft144 = XStringFormat.TopLeft;
          xgraphics144.DrawString(str49, xfont152, (XBrush) black139, xrect144, topLeft144);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        checked { DeveloperReport.RC1 += 12; }
        XGraphics xgraphics145 = PDFFunctions.gfx[DeveloperReport.k];
        XFont xfont153 = xfont6;
        XSolidBrush black140 = XBrushes.Black;
        double rc1_133 = (double) DeveloperReport.RC1;
        XUnit width4 = PDFFunctions.pages[DeveloperReport.k].Width;
        double point145 = ((XUnit) ref width4).Point;
        XUnit height2 = PDFFunctions.pages[DeveloperReport.k].Height;
        double num198 = ((XUnit) ref height2).Point / 2.0;
        XRect xrect145 = new XRect(200.0, rc1_133, point145, num198);
        XStringFormat topLeft145 = XStringFormat.TopLeft;
        xgraphics145.DrawString("Length", xfont153, (XBrush) black140, xrect145, topLeft145);
        XGraphics xgraphics146 = PDFFunctions.gfx[DeveloperReport.k];
        XFont xfont154 = xfont6;
        XSolidBrush black141 = XBrushes.Black;
        double rc1_134 = (double) DeveloperReport.RC1;
        XUnit xunit4 = PDFFunctions.pages[DeveloperReport.k].Width;
        double point146 = ((XUnit) ref xunit4).Point;
        xunit4 = PDFFunctions.pages[DeveloperReport.k].Height;
        double num199 = ((XUnit) ref xunit4).Point / 2.0;
        XRect xrect146 = new XRect(260.0, rc1_134, point146, num199);
        XStringFormat topLeft146 = XStringFormat.TopLeft;
        xgraphics146.DrawString("Psi-value", xfont154, (XBrush) black141, xrect146, topLeft146);
        checked { DeveloperReport.RC1 += 12; }
        try
        {
          // ISSUE: reference to a compiler-generated field
          int num200 = checked (SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Thermal.ExternalJunctions.Count - 1);
          int index25 = 0;
          while (index25 <= num200)
          {
            XGraphics xgraphics147 = PDFFunctions.gfx[DeveloperReport.k];
            // ISSUE: reference to a compiler-generated field
            string str50 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Thermal.ExternalJunctions[index25].Length);
            XFont xfont155 = xfont2;
            XSolidBrush black142 = XBrushes.Black;
            double rc1_135 = (double) DeveloperReport.RC1;
            xunit4 = PDFFunctions.pages[DeveloperReport.k].Width;
            double point147 = ((XUnit) ref xunit4).Point;
            xunit4 = PDFFunctions.pages[DeveloperReport.k].Height;
            double num201 = ((XUnit) ref xunit4).Point / 2.0;
            XRect xrect147 = new XRect(200.0, rc1_135, point147, num201);
            XStringFormat topLeft147 = XStringFormat.TopLeft;
            xgraphics147.DrawString(str50, xfont155, (XBrush) black142, xrect147, topLeft147);
            XGraphics xgraphics148 = PDFFunctions.gfx[DeveloperReport.k];
            // ISSUE: reference to a compiler-generated field
            string str51 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Thermal.ExternalJunctions[index25].ThermalTransmittance);
            XFont xfont156 = xfont2;
            XSolidBrush black143 = XBrushes.Black;
            double rc1_136 = (double) DeveloperReport.RC1;
            xunit4 = PDFFunctions.pages[DeveloperReport.k].Width;
            double point148 = ((XUnit) ref xunit4).Point;
            xunit4 = PDFFunctions.pages[DeveloperReport.k].Height;
            double num202 = ((XUnit) ref xunit4).Point / 2.0;
            XRect xrect148 = new XRect(260.0, rc1_136, point148, num202);
            XStringFormat topLeft148 = XStringFormat.TopLeft;
            xgraphics148.DrawString(str51, xfont156, (XBrush) black143, xrect148, topLeft148);
            XGraphics xgraphics149 = PDFFunctions.gfx[DeveloperReport.k];
            // ISSUE: reference to a compiler-generated field
            string str52 = SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Thermal.ExternalJunctions[index25].Ref;
            XFont xfont157 = xfont2;
            XSolidBrush black144 = XBrushes.Black;
            double rc1_137 = (double) DeveloperReport.RC1;
            xunit4 = PDFFunctions.pages[DeveloperReport.k].Width;
            double point149 = ((XUnit) ref xunit4).Point;
            xunit4 = PDFFunctions.pages[DeveloperReport.k].Height;
            double num203 = ((XUnit) ref xunit4).Point / 2.0;
            XRect xrect149 = new XRect(320.0, rc1_137, point149, num203);
            XStringFormat topLeft149 = XStringFormat.TopLeft;
            xgraphics149.DrawString(str52, xfont157, (XBrush) black144, xrect149, topLeft149);
            try
            {
              XGraphics xgraphics150 = PDFFunctions.gfx[DeveloperReport.k];
              // ISSUE: reference to a compiler-generated field
              string junctionDetail = SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Thermal.ExternalJunctions[index25].JunctionDetail;
              XFont xfont158 = xfont8;
              XSolidBrush black145 = XBrushes.Black;
              double rc1_138 = (double) DeveloperReport.RC1;
              xunit4 = PDFFunctions.pages[DeveloperReport.k].Width;
              double point150 = ((XUnit) ref xunit4).Point;
              xunit4 = PDFFunctions.pages[DeveloperReport.k].Height;
              double num204 = ((XUnit) ref xunit4).Point / 2.0;
              XRect xrect150 = new XRect(350.0, rc1_138, point150, num204);
              XStringFormat topLeft150 = XStringFormat.TopLeft;
              xgraphics150.DrawString(junctionDetail, xfont158, (XBrush) black145, xrect150, topLeft150);
            }
            catch (Exception ex)
            {
              ProjectData.SetProjectError(ex);
              ProjectData.ClearProjectError();
            }
            // ISSUE: reference to a compiler-generated field
            if (SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Thermal.ExternalJunctions[index25].IsAccredited)
            {
              XGraphics xgraphics151 = PDFFunctions.gfx[DeveloperReport.k];
              XFont xfont159 = xfont2;
              XSolidBrush black146 = XBrushes.Black;
              double rc1_139 = (double) DeveloperReport.RC1;
              XUnit width5 = PDFFunctions.pages[DeveloperReport.k].Width;
              double point151 = ((XUnit) ref width5).Point;
              XUnit height3 = PDFFunctions.pages[DeveloperReport.k].Height;
              double num205 = ((XUnit) ref height3).Point / 2.0;
              XRect xrect151 = new XRect(100.0, rc1_139, point151, num205);
              XStringFormat topLeft151 = XStringFormat.TopLeft;
              xgraphics151.DrawString("[Approved]", xfont159, (XBrush) black146, xrect151, topLeft151);
            }
            checked { DeveloperReport.RC1 += 12; }
            DeveloperReport.CheckRC1();
            checked { ++index25; }
          }
          // ISSUE: reference to a compiler-generated field
          int num206 = checked (SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Thermal.PartyJunctions.Count - 1);
          int index26 = 0;
          while (index26 <= num206)
          {
            XGraphics xgraphics152 = PDFFunctions.gfx[DeveloperReport.k];
            // ISSUE: reference to a compiler-generated field
            string str53 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Thermal.PartyJunctions[index26].Length);
            XFont xfont160 = xfont2;
            XSolidBrush black147 = XBrushes.Black;
            double rc1_140 = (double) DeveloperReport.RC1;
            xunit4 = PDFFunctions.pages[DeveloperReport.k].Width;
            double point152 = ((XUnit) ref xunit4).Point;
            xunit4 = PDFFunctions.pages[DeveloperReport.k].Height;
            double num207 = ((XUnit) ref xunit4).Point / 2.0;
            XRect xrect152 = new XRect(200.0, rc1_140, point152, num207);
            XStringFormat topLeft152 = XStringFormat.TopLeft;
            xgraphics152.DrawString(str53, xfont160, (XBrush) black147, xrect152, topLeft152);
            XGraphics xgraphics153 = PDFFunctions.gfx[DeveloperReport.k];
            // ISSUE: reference to a compiler-generated field
            string str54 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Thermal.PartyJunctions[index26].ThermalTransmittance);
            XFont xfont161 = xfont2;
            XSolidBrush black148 = XBrushes.Black;
            double rc1_141 = (double) DeveloperReport.RC1;
            xunit4 = PDFFunctions.pages[DeveloperReport.k].Width;
            double point153 = ((XUnit) ref xunit4).Point;
            xunit4 = PDFFunctions.pages[DeveloperReport.k].Height;
            double num208 = ((XUnit) ref xunit4).Point / 2.0;
            XRect xrect153 = new XRect(260.0, rc1_141, point153, num208);
            XStringFormat topLeft153 = XStringFormat.TopLeft;
            xgraphics153.DrawString(str54, xfont161, (XBrush) black148, xrect153, topLeft153);
            XGraphics xgraphics154 = PDFFunctions.gfx[DeveloperReport.k];
            // ISSUE: reference to a compiler-generated field
            string str55 = SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Thermal.PartyJunctions[index26].Ref;
            XFont xfont162 = xfont2;
            XSolidBrush black149 = XBrushes.Black;
            double rc1_142 = (double) DeveloperReport.RC1;
            xunit4 = PDFFunctions.pages[DeveloperReport.k].Width;
            double point154 = ((XUnit) ref xunit4).Point;
            xunit4 = PDFFunctions.pages[DeveloperReport.k].Height;
            double num209 = ((XUnit) ref xunit4).Point / 2.0;
            XRect xrect154 = new XRect(320.0, rc1_142, point154, num209);
            XStringFormat topLeft154 = XStringFormat.TopLeft;
            xgraphics154.DrawString(str55, xfont162, (XBrush) black149, xrect154, topLeft154);
            try
            {
              XGraphics xgraphics155 = PDFFunctions.gfx[DeveloperReport.k];
              // ISSUE: reference to a compiler-generated field
              string junctionDetail = SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Thermal.PartyJunctions[index26].JunctionDetail;
              XFont xfont163 = xfont8;
              XSolidBrush black150 = XBrushes.Black;
              double rc1_143 = (double) DeveloperReport.RC1;
              xunit4 = PDFFunctions.pages[DeveloperReport.k].Width;
              double point155 = ((XUnit) ref xunit4).Point;
              xunit4 = PDFFunctions.pages[DeveloperReport.k].Height;
              double num210 = ((XUnit) ref xunit4).Point / 2.0;
              XRect xrect155 = new XRect(350.0, rc1_143, point155, num210);
              XStringFormat topLeft155 = XStringFormat.TopLeft;
              xgraphics155.DrawString(junctionDetail, xfont163, (XBrush) black150, xrect155, topLeft155);
            }
            catch (Exception ex)
            {
              ProjectData.SetProjectError(ex);
              ProjectData.ClearProjectError();
            }
            // ISSUE: reference to a compiler-generated field
            if (SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Thermal.PartyJunctions[index26].Accredited != 0.0)
            {
              XGraphics xgraphics156 = PDFFunctions.gfx[DeveloperReport.k];
              XFont xfont164 = xfont2;
              XSolidBrush black151 = XBrushes.Black;
              double rc1_144 = (double) DeveloperReport.RC1;
              XUnit width6 = PDFFunctions.pages[DeveloperReport.k].Width;
              double point156 = ((XUnit) ref width6).Point;
              XUnit height4 = PDFFunctions.pages[DeveloperReport.k].Height;
              double num211 = ((XUnit) ref height4).Point / 2.0;
              XRect xrect156 = new XRect(100.0, rc1_144, point156, num211);
              XStringFormat topLeft156 = XStringFormat.TopLeft;
              xgraphics156.DrawString("Approved source", xfont164, (XBrush) black151, xrect156, topLeft156);
            }
            checked { DeveloperReport.RC1 += 12; }
            DeveloperReport.CheckRC1();
            checked { ++index26; }
          }
          // ISSUE: reference to a compiler-generated field
          int num212 = checked (SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Thermal.RoofJunctions.Count - 1);
          int index27 = 0;
          while (index27 <= num212)
          {
            XGraphics xgraphics157 = PDFFunctions.gfx[DeveloperReport.k];
            // ISSUE: reference to a compiler-generated field
            string str56 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Thermal.RoofJunctions[index27].Length);
            XFont xfont165 = xfont2;
            XSolidBrush black152 = XBrushes.Black;
            double rc1_145 = (double) DeveloperReport.RC1;
            xunit4 = PDFFunctions.pages[DeveloperReport.k].Width;
            double point157 = ((XUnit) ref xunit4).Point;
            xunit4 = PDFFunctions.pages[DeveloperReport.k].Height;
            double num213 = ((XUnit) ref xunit4).Point / 2.0;
            XRect xrect157 = new XRect(200.0, rc1_145, point157, num213);
            XStringFormat topLeft157 = XStringFormat.TopLeft;
            xgraphics157.DrawString(str56, xfont165, (XBrush) black152, xrect157, topLeft157);
            XGraphics xgraphics158 = PDFFunctions.gfx[DeveloperReport.k];
            // ISSUE: reference to a compiler-generated field
            string str57 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Thermal.RoofJunctions[index27].ThermalTransmittance);
            XFont xfont166 = xfont2;
            XSolidBrush black153 = XBrushes.Black;
            double rc1_146 = (double) DeveloperReport.RC1;
            xunit4 = PDFFunctions.pages[DeveloperReport.k].Width;
            double point158 = ((XUnit) ref xunit4).Point;
            xunit4 = PDFFunctions.pages[DeveloperReport.k].Height;
            double num214 = ((XUnit) ref xunit4).Point / 2.0;
            XRect xrect158 = new XRect(260.0, rc1_146, point158, num214);
            XStringFormat topLeft158 = XStringFormat.TopLeft;
            xgraphics158.DrawString(str57, xfont166, (XBrush) black153, xrect158, topLeft158);
            XGraphics xgraphics159 = PDFFunctions.gfx[DeveloperReport.k];
            // ISSUE: reference to a compiler-generated field
            string str58 = SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Thermal.RoofJunctions[index27].Ref;
            XFont xfont167 = xfont2;
            XSolidBrush black154 = XBrushes.Black;
            double rc1_147 = (double) DeveloperReport.RC1;
            xunit4 = PDFFunctions.pages[DeveloperReport.k].Width;
            double point159 = ((XUnit) ref xunit4).Point;
            xunit4 = PDFFunctions.pages[DeveloperReport.k].Height;
            double num215 = ((XUnit) ref xunit4).Point / 2.0;
            XRect xrect159 = new XRect(320.0, rc1_147, point159, num215);
            XStringFormat topLeft159 = XStringFormat.TopLeft;
            xgraphics159.DrawString(str58, xfont167, (XBrush) black154, xrect159, topLeft159);
            try
            {
              XGraphics xgraphics160 = PDFFunctions.gfx[DeveloperReport.k];
              // ISSUE: reference to a compiler-generated field
              string junctionDetail = SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Thermal.RoofJunctions[index27].JunctionDetail;
              XFont xfont168 = xfont8;
              XSolidBrush black155 = XBrushes.Black;
              double rc1_148 = (double) DeveloperReport.RC1;
              xunit4 = PDFFunctions.pages[DeveloperReport.k].Width;
              double point160 = ((XUnit) ref xunit4).Point;
              xunit4 = PDFFunctions.pages[DeveloperReport.k].Height;
              double num216 = ((XUnit) ref xunit4).Point / 2.0;
              XRect xrect160 = new XRect(350.0, rc1_148, point160, num216);
              XStringFormat topLeft160 = XStringFormat.TopLeft;
              xgraphics160.DrawString(junctionDetail, xfont168, (XBrush) black155, xrect160, topLeft160);
            }
            catch (Exception ex)
            {
              ProjectData.SetProjectError(ex);
              ProjectData.ClearProjectError();
            }
            // ISSUE: reference to a compiler-generated field
            if (SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Thermal.RoofJunctions[index27].Accredited != 0.0)
            {
              XGraphics xgraphics161 = PDFFunctions.gfx[DeveloperReport.k];
              XFont xfont169 = xfont2;
              XSolidBrush black156 = XBrushes.Black;
              double rc1_149 = (double) DeveloperReport.RC1;
              XUnit width7 = PDFFunctions.pages[DeveloperReport.k].Width;
              double point161 = ((XUnit) ref width7).Point;
              XUnit height5 = PDFFunctions.pages[DeveloperReport.k].Height;
              double num217 = ((XUnit) ref height5).Point / 2.0;
              XRect xrect161 = new XRect(100.0, rc1_149, point161, num217);
              XStringFormat topLeft161 = XStringFormat.TopLeft;
              xgraphics161.DrawString("Approved source", xfont169, (XBrush) black156, xrect161, topLeft161);
            }
            checked { DeveloperReport.RC1 += 12; }
            DeveloperReport.CheckRC1();
            checked { ++index27; }
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        if (SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Thermal.ManualY)
        {
          XGraphics xgraphics162 = PDFFunctions.gfx[DeveloperReport.k];
          XFont xfont170 = xfont2;
          XSolidBrush black157 = XBrushes.Black;
          double rc1_150 = (double) DeveloperReport.RC1;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point162 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num218 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect162 = new XRect(20.0, rc1_150, point162, num218);
          XStringFormat topLeft162 = XStringFormat.TopLeft;
          xgraphics162.DrawString("Thermal bridges:", xfont170, (XBrush) black157, xrect162, topLeft162);
          XGraphics xgraphics163 = PDFFunctions.gfx[DeveloperReport.k];
          XFont xfont171 = xfont2;
          XSolidBrush black158 = XBrushes.Black;
          double rc1_151 = (double) DeveloperReport.RC1;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point163 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num219 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect163 = new XRect(200.0, rc1_151, point163, num219);
          XStringFormat topLeft163 = XStringFormat.TopLeft;
          xgraphics163.DrawString("User-defined y-value", xfont171, (XBrush) black158, xrect163, topLeft163);
          checked { DeveloperReport.RC1 += 12; }
          XGraphics xgraphics164 = PDFFunctions.gfx[DeveloperReport.k];
          // ISSUE: reference to a compiler-generated field
          string str59 = "y =" + Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Thermal.YValue);
          XFont xfont172 = xfont2;
          XSolidBrush black159 = XBrushes.Black;
          double rc1_152 = (double) DeveloperReport.RC1;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point164 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num220 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect164 = new XRect(200.0, rc1_152, point164, num220);
          XStringFormat topLeft164 = XStringFormat.TopLeft;
          xgraphics164.DrawString(str59, xfont172, (XBrush) black159, xrect164, topLeft164);
          checked { DeveloperReport.RC1 += 12; }
          XGraphics xgraphics165 = PDFFunctions.gfx[DeveloperReport.k];
          // ISSUE: reference to a compiler-generated field
          string str60 = "Reference: " + SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Thermal.Reference;
          XFont xfont173 = xfont2;
          XSolidBrush black160 = XBrushes.Black;
          double rc1_153 = (double) DeveloperReport.RC1;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point165 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num221 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect165 = new XRect(200.0, rc1_153, point165, num221);
          XStringFormat topLeft165 = XStringFormat.TopLeft;
          xgraphics165.DrawString(str60, xfont173, (XBrush) black160, xrect165, topLeft165);
          checked { DeveloperReport.RC1 += 12; }
          DeveloperReport.CheckRC1();
          // ISSUE: reference to a compiler-generated field
          if (SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].NoofPCeilings > 0)
            DeveloperReport.CreateBox();
          DeveloperReport.CheckRC1();
        }
        else
        {
          DeveloperReport.CheckRC1();
          // ISSUE: reference to a compiler-generated field
          string str61 = SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Thermal.ConstDetails;
          // ISSUE: reference to a compiler-generated field
          if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Thermal.ConstDetails, "All detailing conforms with Accredited Construction Details", false) == 0)
            str61 = "Accredited Construction Details";
          XGraphics xgraphics166 = PDFFunctions.gfx[DeveloperReport.k];
          XFont xfont174 = xfont2;
          XSolidBrush black161 = XBrushes.Black;
          double rc1_154 = (double) DeveloperReport.RC1;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point166 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num222 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect166 = new XRect(20.0, rc1_154, point166, num222);
          XStringFormat topLeft166 = XStringFormat.TopLeft;
          xgraphics166.DrawString("Thermal bridges:", xfont174, (XBrush) black161, xrect166, topLeft166);
          XGraphics xgraphics167 = PDFFunctions.gfx[DeveloperReport.k];
          // ISSUE: reference to a compiler-generated field
          string str62 = str61 + " (y =" + Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Thermal.YValue) + ")";
          XFont xfont175 = xfont2;
          XSolidBrush black162 = XBrushes.Black;
          double rc1_155 = (double) DeveloperReport.RC1;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point167 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num223 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect167 = new XRect(200.0, rc1_155, point167, num223);
          XStringFormat topLeft167 = XStringFormat.TopLeft;
          xgraphics167.DrawString(str62, xfont175, (XBrush) black162, xrect167, topLeft167);
          DeveloperReport.CheckRC1();
        }
      }
      checked { DeveloperReport.RC1 += 14; }
      DeveloperReport.CreateBox();
      XGraphics xgraphics168 = PDFFunctions.gfx[DeveloperReport.k];
      XFont xfont176 = xfont2;
      XSolidBrush black163 = XBrushes.Black;
      double num224 = (double) checked (DeveloperReport.RC1 - 73);
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
      double point168 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
      double num225 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect168 = new XRect(30.0, num224, point168, num225);
      XStringFormat topLeft168 = XStringFormat.TopLeft;
      xgraphics168.DrawString("If specific construction details have been adopted then please provide the associated checklists; signed and dated.", xfont176, (XBrush) black163, xrect168, topLeft168);
      DeveloperReport.CheckRC1();
      PDFFunctions.xBrush1 = XBrush.op_Implicit((Brush) new SolidBrush(Color.FromArgb(159, 172, 62)));
      PDFFunctions.Points[0].X = 20f;
      PDFFunctions.Points[0].Y = (float) DeveloperReport.RC1;
      ref PointF local11 = ref PDFFunctions.Points[1];
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
      double num226 = ((XUnit) ref xunit3).Point - 20.0;
      local11.X = (float) num226;
      PDFFunctions.Points[1].Y = (float) DeveloperReport.RC1;
      ref PointF local12 = ref PDFFunctions.Points[2];
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
      double num227 = ((XUnit) ref xunit3).Point - 20.0;
      local12.X = (float) num227;
      PDFFunctions.Points[2].Y = (float) checked (DeveloperReport.RC1 + 16);
      PDFFunctions.Points[3].X = 20f;
      PDFFunctions.Points[3].Y = (float) checked (DeveloperReport.RC1 + 16);
      PDFFunctions.gfx[DeveloperReport.k].DrawPolygon(PDFFunctions.polyGreen2, PDFFunctions.xBrush1, PDFFunctions.Points, xfillMode);
      XGraphics xgraphics169 = PDFFunctions.gfx[DeveloperReport.k];
      XFont xfont177 = xfont3;
      XSolidBrush white6 = XBrushes.White;
      double rc1_156 = (double) DeveloperReport.RC1;
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
      double point169 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
      double num228 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect169 = new XRect(25.0, rc1_156, point169, num228);
      XStringFormat topLeft169 = XStringFormat.TopLeft;
      xgraphics169.DrawString("Ventilation:", xfont177, (XBrush) white6, xrect169, topLeft169);
      checked { DeveloperReport.RC1 += 16; }
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      string str63 = !(Operators.CompareString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Ventilation.Pressure, "As built", false) == 0 | Operators.CompareString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Ventilation.Pressure, "As designed", false) == 0) ? "No (" + SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Ventilation.Pressure + ")" : "Yes (" + SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Ventilation.Pressure + ")";
      XGraphics xgraphics170 = PDFFunctions.gfx[DeveloperReport.k];
      XFont xfont178 = xfont2;
      XSolidBrush black164 = XBrushes.Black;
      double rc1_157 = (double) DeveloperReport.RC1;
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
      double point170 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
      double num229 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect170 = new XRect(20.0, rc1_157, point170, num229);
      XStringFormat topLeft170 = XStringFormat.TopLeft;
      xgraphics170.DrawString("Pressure test:", xfont178, (XBrush) black164, xrect170, topLeft170);
      XGraphics xgraphics171 = PDFFunctions.gfx[DeveloperReport.k];
      string str64 = str63;
      XFont xfont179 = xfont2;
      XSolidBrush black165 = XBrushes.Black;
      double rc1_158 = (double) DeveloperReport.RC1;
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
      double point171 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
      double num230 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect171 = new XRect(200.0, rc1_158, point171, num230);
      XStringFormat topLeft171 = XStringFormat.TopLeft;
      xgraphics171.DrawString(str64, xfont179, (XBrush) black165, xrect171, topLeft171);
      checked { DeveloperReport.RC1 += 12; }
      DeveloperReport.CheckRC1();
      XGraphics xgraphics172 = PDFFunctions.gfx[DeveloperReport.k];
      XFont xfont180 = xfont2;
      XSolidBrush black166 = XBrushes.Black;
      double rc1_159 = (double) DeveloperReport.RC1;
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
      double point172 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
      double num231 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect172 = new XRect(20.0, rc1_159, point172, num231);
      XStringFormat topLeft172 = XStringFormat.TopLeft;
      xgraphics172.DrawString("Ventilation:", xfont180, (XBrush) black166, xrect172, topLeft172);
      // ISSUE: reference to a compiler-generated field
      string str65 = SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Ventilation.MechVent;
      // ISSUE: reference to a compiler-generated field
      if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Ventilation.MechVent, "Natural ventilation", false) == 0)
        str65 = "Natural ventilation (extract fans)";
      XGraphics xgraphics173 = PDFFunctions.gfx[DeveloperReport.k];
      string str66 = str65;
      XFont xfont181 = xfont2;
      XSolidBrush black167 = XBrushes.Black;
      double rc1_160 = (double) DeveloperReport.RC1;
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
      double point173 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
      double num232 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect173 = new XRect(200.0, rc1_160, point173, num232);
      XStringFormat topLeft173 = XStringFormat.TopLeft;
      xgraphics173.DrawString(str66, xfont181, (XBrush) black167, xrect173, topLeft173);
      checked { DeveloperReport.RC1 += 12; }
      DeveloperReport.CheckRC1();
      string str67 = "";
      // ISSUE: reference to a compiler-generated field
      if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Ventilation.Parameters, "Database", false) == 0)
      {
        // ISSUE: reference to a compiler-generated field
        string mechVent1 = SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Ventilation.MechVent;
        object Instance;
        List<PCDF.Products321_Sub> list;
        if (Operators.CompareString(mechVent1, "Balanced with heat recovery", false) != 0 && Operators.CompareString(mechVent1, "Centralised whole house extract", false) != 0)
        {
          if (Operators.CompareString(mechVent1, "Decentralised whole house extract", false) == 0)
          {
            // ISSUE: reference to a compiler-generated method
            Instance = (object) SAP_Module.PCDFData.Products322s.Where<PCDF.Products322>(new Func<PCDF.Products322, bool>(closure140_2._Lambda\u0024__2)).SingleOrDefault<PCDF.Products322>();
          }
        }
        else
        {
          // ISSUE: reference to a compiler-generated method
          Instance = (object) SAP_Module.PCDFData.Products321s.Where<PCDF.Products321>(new Func<PCDF.Products321, bool>(closure140_2._Lambda\u0024__0)).SingleOrDefault<PCDF.Products321>();
          // ISSUE: reference to a compiler-generated method
          list = SAP_Module.PCDFData.Products321s_Sub.Where<PCDF.Products321_Sub>(new Func<PCDF.Products321_Sub, bool>(closure140_2._Lambda\u0024__1)).ToList<PCDF.Products321_Sub>();
          object Left = NewLateBinding.LateGet(Instance, (System.Type) null, "DuctingType", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null);
          if (Operators.ConditionalCompareObjectEqual(Left, (object) "1", false))
            str67 = "flexible";
          else if (Operators.ConditionalCompareObjectEqual(Left, (object) "2", false))
            str67 = "rigid";
        }
        try
        {
          if (Operators.ConditionalCompareObjectNotEqual(NewLateBinding.LateGet(Instance, (System.Type) null, "Length", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) 0, false))
          {
            XGraphics xgraphics174 = PDFFunctions.gfx[DeveloperReport.k];
            string str68 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object) "Brand/Model: ", NewLateBinding.LateGet(Instance, (System.Type) null, "Brand", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)), (object) " "), NewLateBinding.LateGet(Instance, (System.Type) null, "Model", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)));
            XFont xfont182 = xfont2;
            XSolidBrush black168 = XBrushes.Black;
            double rc1_161 = (double) DeveloperReport.RC1;
            xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
            double point174 = ((XUnit) ref xunit3).Point;
            xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
            double num233 = ((XUnit) ref xunit3).Point / 2.0;
            XRect xrect174 = new XRect(210.0, rc1_161, point174, num233);
            XStringFormat topLeft174 = XStringFormat.TopLeft;
            xgraphics174.DrawString(str68, xfont182, (XBrush) black168, xrect174, topLeft174);
            checked { DeveloperReport.RC1 += 12; }
            // ISSUE: reference to a compiler-generated field
            string mechVent2 = SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Ventilation.MechVent;
            if (Operators.CompareString(mechVent2, "Balanced with heat recovery", false) == 0 || Operators.CompareString(mechVent2, "Centralised whole house extract", false) == 0)
            {
              XGraphics xgraphics175 = PDFFunctions.gfx[DeveloperReport.k];
              string str69 = "Test efficiency: " + list[0].HeatExchangerEfficiency + "%, SFP: " + list[0].SFP;
              XFont xfont183 = xfont2;
              XSolidBrush black169 = XBrushes.Black;
              double rc1_162 = (double) DeveloperReport.RC1;
              xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
              double point175 = ((XUnit) ref xunit3).Point;
              xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
              double num234 = ((XUnit) ref xunit3).Point / 2.0;
              XRect xrect175 = new XRect(210.0, rc1_162, point175, num234);
              XStringFormat topLeft175 = XStringFormat.TopLeft;
              xgraphics175.DrawString(str69, xfont183, (XBrush) black169, xrect175, topLeft175);
              checked { DeveloperReport.RC1 += 12; }
            }
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
      if ((uint) Operators.CompareString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Ventilation.MechVent, "Natural ventilation", false) > 0U & !SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Ventilation.MechVent.Contains("Positive"))
      {
        // ISSUE: reference to a compiler-generated field
        if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Ventilation.MechVent, "Decentralised whole house extract", false) == 0)
        {
          // ISSUE: reference to a compiler-generated field
          string parameters = SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Ventilation.Parameters;
          if (Operators.CompareString(parameters, "Database", false) == 0 || Operators.CompareString(parameters, "User defined", false) == 0)
          {
            XGraphics xgraphics176 = PDFFunctions.gfx[DeveloperReport.k];
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            string str70 = "Number of fans in Wetroom: Kitchen " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Ventilation.Decentralised.KTP1 + SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Ventilation.Decentralised.KTP2 + SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Ventilation.Decentralised.KTP3) + " Other " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Ventilation.Decentralised.OTP1 + SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Ventilation.Decentralised.OTP2 + SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Ventilation.Decentralised.OTP3);
            XFont xfont184 = xfont2;
            XSolidBrush black170 = XBrushes.Black;
            double rc1_163 = (double) DeveloperReport.RC1;
            xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
            double point176 = ((XUnit) ref xunit3).Point;
            xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
            double num235 = ((XUnit) ref xunit3).Point / 2.0;
            XRect xrect176 = new XRect(200.0, rc1_163, point176, num235);
            XStringFormat topLeft176 = XStringFormat.TopLeft;
            xgraphics176.DrawString(str70, xfont184, (XBrush) black170, xrect176, topLeft176);
            checked { DeveloperReport.RC1 += 12; }
          }
          else
          {
            XGraphics xgraphics177 = PDFFunctions.gfx[DeveloperReport.k];
            // ISSUE: reference to a compiler-generated field
            string str71 = "Number of wet rooms: Kitchen + " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Ventilation.WetRooms);
            XFont xfont185 = xfont2;
            XSolidBrush black171 = XBrushes.Black;
            double rc1_164 = (double) DeveloperReport.RC1;
            xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
            double point177 = ((XUnit) ref xunit3).Point;
            xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
            double num236 = ((XUnit) ref xunit3).Point / 2.0;
            XRect xrect177 = new XRect(200.0, rc1_164, point177, num236);
            XStringFormat topLeft177 = XStringFormat.TopLeft;
            xgraphics177.DrawString(str71, xfont185, (XBrush) black171, xrect177, topLeft177);
            checked { DeveloperReport.RC1 += 12; }
          }
        }
        else
        {
          XGraphics xgraphics178 = PDFFunctions.gfx[DeveloperReport.k];
          // ISSUE: reference to a compiler-generated field
          string str72 = "Number of wet rooms: Kitchen + " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Ventilation.WetRooms);
          XFont xfont186 = xfont2;
          XSolidBrush black172 = XBrushes.Black;
          double rc1_165 = (double) DeveloperReport.RC1;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point178 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num237 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect178 = new XRect(200.0, rc1_165, point178, num237);
          XStringFormat topLeft178 = XStringFormat.TopLeft;
          xgraphics178.DrawString(str72, xfont186, (XBrush) black172, xrect178, topLeft178);
          checked { DeveloperReport.RC1 += 12; }
        }
        // ISSUE: reference to a compiler-generated field
        if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Ventilation.Parameters, "Database", false) == 0)
        {
          XGraphics xgraphics179 = PDFFunctions.gfx[DeveloperReport.k];
          // ISSUE: reference to a compiler-generated field
          string str73 = "Ductwork: " + SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Ventilation.DuctType + ", " + str67;
          XFont xfont187 = xfont2;
          XSolidBrush black173 = XBrushes.Black;
          double rc1_166 = (double) DeveloperReport.RC1;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point179 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num238 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect179 = new XRect(200.0, rc1_166, point179, num238);
          XStringFormat topLeft179 = XStringFormat.TopLeft;
          xgraphics179.DrawString(str73, xfont187, (XBrush) black173, xrect179, topLeft179);
        }
        else
        {
          XGraphics xgraphics180 = PDFFunctions.gfx[DeveloperReport.k];
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          string str74 = "Ductwork: " + SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Ventilation.DuctType + ", " + SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Ventilation.MVDetails.DuctingType;
          XFont xfont188 = xfont2;
          XSolidBrush black174 = XBrushes.Black;
          double rc1_167 = (double) DeveloperReport.RC1;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point180 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num239 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect180 = new XRect(200.0, rc1_167, point180, num239);
          XStringFormat topLeft180 = XStringFormat.TopLeft;
          xgraphics180.DrawString(str74, xfont188, (XBrush) black174, xrect180, topLeft180);
        }
        checked { DeveloperReport.RC1 += 12; }
        XGraphics xgraphics181 = PDFFunctions.gfx[DeveloperReport.k];
        // ISSUE: reference to a compiler-generated field
        string str75 = "Approved Installation Scheme: " + SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Ventilation.ApprovedScheme.ToString();
        XFont xfont189 = xfont2;
        XSolidBrush black175 = XBrushes.Black;
        double rc1_168 = (double) DeveloperReport.RC1;
        xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
        double point181 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
        double num240 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect181 = new XRect(200.0, rc1_168, point181, num240);
        XStringFormat topLeft181 = XStringFormat.TopLeft;
        xgraphics181.DrawString(str75, xfont189, (XBrush) black175, xrect181, topLeft181);
        checked { DeveloperReport.RC1 += 12; }
      }
      DeveloperReport.CheckRC1();
      XGraphics xgraphics182 = PDFFunctions.gfx[DeveloperReport.k];
      XFont xfont190 = xfont2;
      XSolidBrush black176 = XBrushes.Black;
      double rc1_169 = (double) DeveloperReport.RC1;
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
      double point182 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
      double num241 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect182 = new XRect(20.0, rc1_169, point182, num241);
      XStringFormat topLeft182 = XStringFormat.TopLeft;
      xgraphics182.DrawString("Pressure test:", xfont190, (XBrush) black176, xrect182, topLeft182);
      // ISSUE: reference to a compiler-generated field
      if ((double) SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Ventilation.AssumedAir != 0.0)
      {
        XGraphics xgraphics183 = PDFFunctions.gfx[DeveloperReport.k];
        // ISSUE: reference to a compiler-generated field
        string str76 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Ventilation.AssumedAir);
        XFont xfont191 = xfont2;
        XSolidBrush black177 = XBrushes.Black;
        double rc1_170 = (double) DeveloperReport.RC1;
        xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
        double point183 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
        double num242 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect183 = new XRect(200.0, rc1_170, point183, num242);
        XStringFormat topLeft183 = XStringFormat.TopLeft;
        xgraphics183.DrawString(str76, xfont191, (XBrush) black177, xrect183, topLeft183);
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        if ((double) SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Ventilation.DesignAir != 0.0 & (double) SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Ventilation.MeasuredAir == 0.0)
        {
          XGraphics xgraphics184 = PDFFunctions.gfx[DeveloperReport.k];
          // ISSUE: reference to a compiler-generated field
          string str77 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Ventilation.DesignAir);
          XFont xfont192 = xfont2;
          XSolidBrush black178 = XBrushes.Black;
          double rc1_171 = (double) DeveloperReport.RC1;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point184 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num243 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect184 = new XRect(200.0, rc1_171, point184, num243);
          XStringFormat topLeft184 = XStringFormat.TopLeft;
          xgraphics184.DrawString(str77, xfont192, (XBrush) black178, xrect184, topLeft184);
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          if ((double) SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Ventilation.MeasuredAir != 0.0)
          {
            // ISSUE: reference to a compiler-generated field
            if (SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Ventilation.AveragePerm)
            {
              XGraphics xgraphics185 = PDFFunctions.gfx[DeveloperReport.k];
              // ISSUE: reference to a compiler-generated field
              string str78 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Ventilation.MeasuredAir) + " (Average permeability of dwellings of that type was used)";
              XFont xfont193 = xfont2;
              XSolidBrush black179 = XBrushes.Black;
              double rc1_172 = (double) DeveloperReport.RC1;
              xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
              double point185 = ((XUnit) ref xunit3).Point;
              xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
              double num244 = ((XUnit) ref xunit3).Point / 2.0;
              XRect xrect185 = new XRect(200.0, rc1_172, point185, num244);
              XStringFormat topLeft185 = XStringFormat.TopLeft;
              xgraphics185.DrawString(str78, xfont193, (XBrush) black179, xrect185, topLeft185);
            }
            else
            {
              XGraphics xgraphics186 = PDFFunctions.gfx[DeveloperReport.k];
              // ISSUE: reference to a compiler-generated field
              string str79 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Ventilation.MeasuredAir) + " (Assessed dwelling is tested)";
              XFont xfont194 = xfont2;
              XSolidBrush black180 = XBrushes.Black;
              double rc1_173 = (double) DeveloperReport.RC1;
              xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
              double point186 = ((XUnit) ref xunit3).Point;
              xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
              double num245 = ((XUnit) ref xunit3).Point / 2.0;
              XRect xrect186 = new XRect(200.0, rc1_173, point186, num245);
              XStringFormat topLeft186 = XStringFormat.TopLeft;
              xgraphics186.DrawString(str79, xfont194, (XBrush) black180, xrect186, topLeft186);
            }
          }
        }
      }
      checked { DeveloperReport.RC1 += 14; }
      DeveloperReport.CheckRC1();
      DeveloperReport.CreateBox();
      XGraphics xgraphics187 = PDFFunctions.gfx[DeveloperReport.k];
      XFont xfont195 = xfont2;
      XSolidBrush black181 = XBrushes.Black;
      double num246 = (double) checked (DeveloperReport.RC1 - 73);
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
      double point187 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
      double num247 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect187 = new XRect(30.0, num246, point187, num247);
      XStringFormat topLeft187 = XStringFormat.TopLeft;
      xgraphics187.DrawString("Please provide the pressure test certificate, or certificates if the result is based on an average; signed and dated.", xfont195, (XBrush) black181, xrect187, topLeft187);
      DeveloperReport.CheckRC1();
      PDFFunctions.xBrush1 = XBrush.op_Implicit((Brush) new SolidBrush(Color.FromArgb(159, 172, 62)));
      PDFFunctions.Points[0].X = 20f;
      PDFFunctions.Points[0].Y = (float) DeveloperReport.RC1;
      ref PointF local13 = ref PDFFunctions.Points[1];
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
      double num248 = ((XUnit) ref xunit3).Point - 20.0;
      local13.X = (float) num248;
      PDFFunctions.Points[1].Y = (float) DeveloperReport.RC1;
      ref PointF local14 = ref PDFFunctions.Points[2];
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
      double num249 = ((XUnit) ref xunit3).Point - 20.0;
      local14.X = (float) num249;
      PDFFunctions.Points[2].Y = (float) checked (DeveloperReport.RC1 + 16);
      PDFFunctions.Points[3].X = 20f;
      PDFFunctions.Points[3].Y = (float) checked (DeveloperReport.RC1 + 16);
      PDFFunctions.gfx[DeveloperReport.k].DrawPolygon(PDFFunctions.polyGreen2, PDFFunctions.xBrush1, PDFFunctions.Points, xfillMode);
      XGraphics xgraphics188 = PDFFunctions.gfx[DeveloperReport.k];
      XFont xfont196 = xfont3;
      XSolidBrush white7 = XBrushes.White;
      double num250 = (double) checked (DeveloperReport.RC1 + 1);
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
      double point188 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
      double num251 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect188 = new XRect(25.0, num250, point188, num251);
      XStringFormat topLeft188 = XStringFormat.TopLeft;
      xgraphics188.DrawString("Main heating system:", xfont196, (XBrush) white7, xrect188, topLeft188);
      DeveloperReport.RC1 = checked ((int) Math.Round(unchecked ((double) PDFFunctions.Points[3].Y + 6.0)));
      DeveloperReport.CheckRC1();
      XGraphics xgraphics189 = PDFFunctions.gfx[DeveloperReport.k];
      XFont xfont197 = xfont2;
      XSolidBrush black182 = XBrushes.Black;
      double rc1_174 = (double) DeveloperReport.RC1;
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
      double point189 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
      double num252 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect189 = new XRect(20.0, rc1_174, point189, num252);
      XStringFormat topLeft189 = XStringFormat.TopLeft;
      xgraphics189.DrawString("Main heating system: ", xfont197, (XBrush) black182, xrect189, topLeft189);
      XGraphics xgraphics190 = PDFFunctions.gfx[DeveloperReport.k];
      // ISSUE: reference to a compiler-generated field
      string hgroup1 = SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.HGroup;
      XFont xfont198 = xfont2;
      XSolidBrush black183 = XBrushes.Black;
      double rc1_175 = (double) DeveloperReport.RC1;
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
      double point190 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
      double num253 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect190 = new XRect(200.0, rc1_175, point190, num253);
      XStringFormat topLeft190 = XStringFormat.TopLeft;
      xgraphics190.DrawString(hgroup1, xfont198, (XBrush) black183, xrect190, topLeft190);
      checked { DeveloperReport.RC1 += 12; }
      // ISSUE: reference to a compiler-generated field
      if ((uint) Operators.CompareString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.HGroup, "Community heating schemes", false) > 0U)
      {
        XGraphics xgraphics191 = PDFFunctions.gfx[DeveloperReport.k];
        // ISSUE: reference to a compiler-generated field
        string sgroup = SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.SGroup;
        XFont xfont199 = xfont2;
        XSolidBrush black184 = XBrushes.Black;
        double rc1_176 = (double) DeveloperReport.RC1;
        xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
        double point191 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
        double num254 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect191 = new XRect(200.0, rc1_176, point191, num254);
        XStringFormat topLeft191 = XStringFormat.TopLeft;
        xgraphics191.DrawString(sgroup, xfont199, (XBrush) black184, xrect191, topLeft191);
        checked { DeveloperReport.RC1 += 12; }
        XGraphics xgraphics192 = PDFFunctions.gfx[DeveloperReport.k];
        // ISSUE: reference to a compiler-generated field
        string str80 = "Fuel: " + SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.Fuel;
        XFont xfont200 = xfont2;
        XSolidBrush black185 = XBrushes.Black;
        double rc1_177 = (double) DeveloperReport.RC1;
        xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
        double point192 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
        double num255 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect192 = new XRect(200.0, rc1_177, point192, num255);
        XStringFormat topLeft192 = XStringFormat.TopLeft;
        xgraphics192.DrawString(str80, xfont200, (XBrush) black185, xrect192, topLeft192);
        checked { DeveloperReport.RC1 += 12; }
        XGraphics xgraphics193 = PDFFunctions.gfx[DeveloperReport.k];
        // ISSUE: reference to a compiler-generated field
        string str81 = "Info Source: " + SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.InforSource;
        XFont xfont201 = xfont2;
        XSolidBrush black186 = XBrushes.Black;
        double rc1_178 = (double) DeveloperReport.RC1;
        xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
        double point193 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
        double num256 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect193 = new XRect(200.0, rc1_178, point193, num256);
        XStringFormat topLeft193 = XStringFormat.TopLeft;
        xgraphics193.DrawString(str81, xfont201, (XBrush) black186, xrect193, topLeft193);
        checked { DeveloperReport.RC1 += 12; }
        DeveloperReport.CheckRC1();
        // ISSUE: reference to a compiler-generated field
        if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.InforSource, "Boiler Database", false) == 0)
        {
          string str82 = "";
          string str83 = "";
          string str84 = "";
          string Left1 = "";
          string Left2 = "";
          string summerEff;
          string winterEff;
          string Left3;
          // ISSUE: reference to a compiler-generated field
          if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.SGroup, "Gas boilers and oil boilers", false) == 0)
          {
            // ISSUE: reference to a compiler-generated method
            PCDF.SEDBUK sedbuk = SAP_Module.PCDFData.Boilers.Where<PCDF.SEDBUK>(new Func<PCDF.SEDBUK, bool>(closure140_2._Lambda\u0024__3)).SingleOrDefault<PCDF.SEDBUK>();
            if (sedbuk != null)
            {
              str82 = sedbuk.BrandName;
              str84 = sedbuk.ModelName;
              str83 = sedbuk.ModelQualifier;
              summerEff = sedbuk.SummerEff;
              winterEff = sedbuk.WinterEff;
              double num257 = Conversion.Val(sedbuk.MainType);
              if (num257 == 0.0)
                Left1 = "Unknown";
              else if (num257 == 1.0)
                Left1 = "Regular";
              else if (num257 == 2.0)
                Left1 = "Combi";
              else if (num257 == 3.0)
                Left1 = "CPSU";
              try
              {
                if (Operators.CompareString(sedbuk.SubType, "1", false) == 0)
                  Left2 = "Has integral PFGHRD  " + sedbuk.SubTypeIndex;
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
              }
            }
          }
          else
          {
            // ISSUE: reference to a compiler-generated field
            if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.SGroup, "Micro-cogeneration (micro-CHP)", false) == 0)
            {
              // ISSUE: reference to a compiler-generated method
              PCDF.CHP chp = SAP_Module.PCDFData.CHPs.Where<PCDF.CHP>(new Func<PCDF.CHP, bool>(closure140_2._Lambda\u0024__4)).SingleOrDefault<PCDF.CHP>();
              if (chp != null)
              {
                str82 = chp.Brand;
                str84 = chp.Model;
                str83 = chp.Qualifier;
              }
            }
            else
            {
              // ISSUE: reference to a compiler-generated field
              if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.SGroup, "Solid fuel boilers", false) == 0)
              {
                // ISSUE: reference to a compiler-generated method
                PCDF.SEDBUK_Solid sedbukSolid = SAP_Module.PCDFData.Solid_Boilers.Where<PCDF.SEDBUK_Solid>(new Func<PCDF.SEDBUK_Solid, bool>(closure140_2._Lambda\u0024__5)).SingleOrDefault<PCDF.SEDBUK_Solid>();
                if (sedbukSolid != null)
                {
                  str82 = sedbukSolid.BrandName;
                  str84 = sedbukSolid.ModelName;
                  str83 = sedbukSolid.ModelQualifier;
                  double num258 = Conversion.Val(sedbukSolid.MainType);
                  if (num258 == 0.0)
                    Left1 = "Unknown";
                  else if (num258 == 1.0)
                    Left1 = "Regular";
                  else if (num258 == 2.0)
                    Left1 = "Combi";
                  else if (num258 == 3.0)
                    Left1 = "CPSU";
                  Left3 = Conversions.ToString(Math.Round(SAP_Module.Calculation2012.Calculation.Energy_Requirements_9a.Box206));
                }
              }
              else
              {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.SGroup, "Gas-fired heat pumps", false) == 0 | Operators.CompareString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.SGroup, "Electric heat pumps", false) == 0)
                {
                  // ISSUE: reference to a compiler-generated method
                  PCDF.HeatPump heatPump = SAP_Module.PCDFData.HeatPumps.Where<PCDF.HeatPump>(new Func<PCDF.HeatPump, bool>(closure140_2._Lambda\u0024__6)).SingleOrDefault<PCDF.HeatPump>();
                  if (heatPump != null)
                  {
                    str82 = heatPump.Brand;
                    str84 = heatPump.Model;
                    str83 = heatPump.Qualifier;
                    Left3 = Conversions.ToString(Math.Round(SAP_Module.Calculation2012.Calculation.Energy_Requirements_9a.Box206));
                  }
                }
              }
            }
          }
          // ISSUE: reference to a compiler-generated field
          if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.SGroup, "Micro-cogeneration (micro-CHP)", false) == 0)
          {
            XGraphics xgraphics194 = PDFFunctions.gfx[DeveloperReport.k];
            // ISSUE: reference to a compiler-generated field
            string str85 = "Database: (rev " + Conversions.ToString(SAP_Module.DataBVersion) + ", product index " + SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.SEDBUK + "):";
            XFont xfont202 = xfont2;
            XSolidBrush black187 = XBrushes.Black;
            double rc1_179 = (double) DeveloperReport.RC1;
            xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
            double point194 = ((XUnit) ref xunit3).Point;
            xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
            double num259 = ((XUnit) ref xunit3).Point / 2.0;
            XRect xrect194 = new XRect(200.0, rc1_179, point194, num259);
            XStringFormat topLeft194 = XStringFormat.TopLeft;
            xgraphics194.DrawString(str85, xfont202, (XBrush) black187, xrect194, topLeft194);
          }
          else
          {
            if (Operators.CompareString(Left3, (string) null, false) == 0)
              Left3 = "";
            // ISSUE: reference to a compiler-generated field
            if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.SGroup, "Gas boilers and oil boilers", false) == 0)
            {
              XGraphics xgraphics195 = PDFFunctions.gfx[DeveloperReport.k];
              // ISSUE: reference to a compiler-generated field
              string str86 = "Database: (rev " + Conversions.ToString(SAP_Module.DataBVersion) + ", product index " + SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.SEDBUK + ") Efficiency: Winter  " + summerEff + " %  Summer: " + winterEff;
              XFont xfont203 = xfont2;
              XSolidBrush black188 = XBrushes.Black;
              double rc1_180 = (double) DeveloperReport.RC1;
              xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
              double point195 = ((XUnit) ref xunit3).Point;
              xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
              double num260 = ((XUnit) ref xunit3).Point / 2.0;
              XRect xrect195 = new XRect(200.0, rc1_180, point195, num260);
              XStringFormat topLeft195 = XStringFormat.TopLeft;
              xgraphics195.DrawString(str86, xfont203, (XBrush) black188, xrect195, topLeft195);
              if ((uint) Operators.CompareString(Left2, "", false) > 0U)
              {
                checked { DeveloperReport.RC1 += 12; }
                XGraphics xgraphics196 = PDFFunctions.gfx[DeveloperReport.k];
                string str87 = Left2;
                XFont xfont204 = xfont2;
                XSolidBrush black189 = XBrushes.Black;
                double rc1_181 = (double) DeveloperReport.RC1;
                xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
                double point196 = ((XUnit) ref xunit3).Point;
                xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
                double num261 = ((XUnit) ref xunit3).Point / 2.0;
                XRect xrect196 = new XRect(200.0, rc1_181, point196, num261);
                XStringFormat topLeft196 = XStringFormat.TopLeft;
                xgraphics196.DrawString(str87, xfont204, (XBrush) black189, xrect196, topLeft196);
              }
            }
            else
            {
              XGraphics xgraphics197 = PDFFunctions.gfx[DeveloperReport.k];
              // ISSUE: reference to a compiler-generated field
              string str88 = "Database: (rev " + Conversions.ToString(SAP_Module.DataBVersion) + ", product index " + SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.SEDBUK + ", SEDBUK " + Left3 + "%):";
              XFont xfont205 = xfont2;
              XSolidBrush black190 = XBrushes.Black;
              double rc1_182 = (double) DeveloperReport.RC1;
              xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
              double point197 = ((XUnit) ref xunit3).Point;
              xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
              double num262 = ((XUnit) ref xunit3).Point / 2.0;
              XRect xrect197 = new XRect(200.0, rc1_182, point197, num262);
              XStringFormat topLeft197 = XStringFormat.TopLeft;
              xgraphics197.DrawString(str88, xfont205, (XBrush) black190, xrect197, topLeft197);
            }
          }
          checked { DeveloperReport.RC1 += 12; }
          XGraphics xgraphics198 = PDFFunctions.gfx[DeveloperReport.k];
          string str89 = "Brand name: " + str82;
          XFont xfont206 = xfont2;
          XSolidBrush black191 = XBrushes.Black;
          double rc1_183 = (double) DeveloperReport.RC1;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point198 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num263 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect198 = new XRect(200.0, rc1_183, point198, num263);
          XStringFormat topLeft198 = XStringFormat.TopLeft;
          xgraphics198.DrawString(str89, xfont206, (XBrush) black191, xrect198, topLeft198);
          checked { DeveloperReport.RC1 += 12; }
          XGraphics xgraphics199 = PDFFunctions.gfx[DeveloperReport.k];
          string str90 = "Model: " + str84;
          XFont xfont207 = xfont2;
          XSolidBrush black192 = XBrushes.Black;
          double rc1_184 = (double) DeveloperReport.RC1;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point199 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num264 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect199 = new XRect(200.0, rc1_184, point199, num264);
          XStringFormat topLeft199 = XStringFormat.TopLeft;
          xgraphics199.DrawString(str90, xfont207, (XBrush) black192, xrect199, topLeft199);
          checked { DeveloperReport.RC1 += 12; }
          XGraphics xgraphics200 = PDFFunctions.gfx[DeveloperReport.k];
          string str91 = "Model qualifier: " + str83;
          XFont xfont208 = xfont2;
          XSolidBrush black193 = XBrushes.Black;
          double rc1_185 = (double) DeveloperReport.RC1;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point200 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num265 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect200 = new XRect(200.0, rc1_185, point200, num265);
          XStringFormat topLeft200 = XStringFormat.TopLeft;
          xgraphics200.DrawString(str91, xfont208, (XBrush) black193, xrect200, topLeft200);
          checked { DeveloperReport.RC1 += 12; }
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.SGroup, "Micro-cogeneration (micro-CHP)", false) == 0 | Operators.CompareString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.SGroup, "Gas-fired heat pumps", false) == 0 | Operators.CompareString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.SGroup, "Electric heat pumps", false) == 0)
          {
            XGraphics xgraphics201 = PDFFunctions.gfx[DeveloperReport.k];
            XFont xfont209 = xfont2;
            XSolidBrush black194 = XBrushes.Black;
            double rc1_186 = (double) DeveloperReport.RC1;
            xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
            double point201 = ((XUnit) ref xunit3).Point;
            xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
            double num266 = ((XUnit) ref xunit3).Point / 2.0;
            XRect xrect201 = new XRect(200.0, rc1_186, point201, num266);
            XStringFormat topLeft201 = XStringFormat.TopLeft;
            xgraphics201.DrawString("(provides DHW all year)", xfont209, (XBrush) black194, xrect201, topLeft201);
          }
          else
          {
            // ISSUE: reference to a compiler-generated field
            if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.SGroup, "Gas boilers and oil boilers", false) == 0 & Operators.CompareString(Left1, "Combi", false) == 0)
            {
              // ISSUE: reference to a compiler-generated method
              string strType = SAP_Module.PCDFData.Boilers.Where<PCDF.SEDBUK>(new Func<PCDF.SEDBUK, bool>(closure140_2._Lambda\u0024__7)).SingleOrDefault<PCDF.SEDBUK>().StrType;
              if (Operators.CompareString(strType, "0", false) != 0 && Operators.CompareString(strType, "", false) != 0 && Operators.CompareString(strType, "3", false) != 0)
              {
                if (Operators.CompareString(strType, "1", false) != 0)
                {
                  if (Operators.CompareString(strType, "2", false) == 0)
                  {
                    XGraphics xgraphics202 = PDFFunctions.gfx[DeveloperReport.k];
                    string str92 = "(" + Left1 + " boiler with secondary store)";
                    XFont xfont210 = xfont2;
                    XSolidBrush black195 = XBrushes.Black;
                    double rc1_187 = (double) DeveloperReport.RC1;
                    xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
                    double point202 = ((XUnit) ref xunit3).Point;
                    xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
                    double num267 = ((XUnit) ref xunit3).Point / 2.0;
                    XRect xrect202 = new XRect(200.0, rc1_187, point202, num267);
                    XStringFormat topLeft202 = XStringFormat.TopLeft;
                    xgraphics202.DrawString(str92, xfont210, (XBrush) black195, xrect202, topLeft202);
                  }
                }
                else
                {
                  XGraphics xgraphics203 = PDFFunctions.gfx[DeveloperReport.k];
                  string str93 = "(" + Left1 + " boiler with primary store)";
                  XFont xfont211 = xfont2;
                  XSolidBrush black196 = XBrushes.Black;
                  double rc1_188 = (double) DeveloperReport.RC1;
                  xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
                  double point203 = ((XUnit) ref xunit3).Point;
                  xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
                  double num268 = ((XUnit) ref xunit3).Point / 2.0;
                  XRect xrect203 = new XRect(200.0, rc1_188, point203, num268);
                  XStringFormat topLeft203 = XStringFormat.TopLeft;
                  xgraphics203.DrawString(str93, xfont211, (XBrush) black196, xrect203, topLeft203);
                }
              }
              else
              {
                XGraphics xgraphics204 = PDFFunctions.gfx[DeveloperReport.k];
                string str94 = "(" + Left1 + " boiler)";
                XFont xfont212 = xfont2;
                XSolidBrush black197 = XBrushes.Black;
                double rc1_189 = (double) DeveloperReport.RC1;
                xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
                double point204 = ((XUnit) ref xunit3).Point;
                xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
                double num269 = ((XUnit) ref xunit3).Point / 2.0;
                XRect xrect204 = new XRect(200.0, rc1_189, point204, num269);
                XStringFormat topLeft204 = XStringFormat.TopLeft;
                xgraphics204.DrawString(str94, xfont212, (XBrush) black197, xrect204, topLeft204);
              }
            }
            else
            {
              XGraphics xgraphics205 = PDFFunctions.gfx[DeveloperReport.k];
              string str95 = "(" + Left1 + " boiler)";
              XFont xfont213 = xfont2;
              XSolidBrush black198 = XBrushes.Black;
              double rc1_190 = (double) DeveloperReport.RC1;
              xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
              double point205 = ((XUnit) ref xunit3).Point;
              xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
              double num270 = ((XUnit) ref xunit3).Point / 2.0;
              XRect xrect205 = new XRect(200.0, rc1_190, point205, num270);
              XStringFormat topLeft205 = XStringFormat.TopLeft;
              xgraphics205.DrawString(str95, xfont213, (XBrush) black198, xrect205, topLeft205);
            }
          }
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.InforSource, "Manufacturer Declaration", false) == 0)
          {
            XGraphics xgraphics206 = PDFFunctions.gfx[DeveloperReport.k];
            XFont xfont214 = xfont2;
            XSolidBrush black199 = XBrushes.Black;
            double rc1_191 = (double) DeveloperReport.RC1;
            xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
            double point206 = ((XUnit) ref xunit3).Point;
            xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
            double num271 = ((XUnit) ref xunit3).Point / 2.0;
            XRect xrect206 = new XRect(200.0, rc1_191, point206, num271);
            XStringFormat topLeft206 = XStringFormat.TopLeft;
            xgraphics206.DrawString("Manufacturer's data", xfont214, (XBrush) black199, xrect206, topLeft206);
            checked { DeveloperReport.RC1 += 12; }
            // ISSUE: reference to a compiler-generated field
            if (SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.SAPTableCode < 142)
            {
              // ISSUE: reference to a compiler-generated field
              if (SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.SEDBUK2005)
              {
                XGraphics xgraphics207 = PDFFunctions.gfx[DeveloperReport.k];
                // ISSUE: reference to a compiler-generated field
                string str96 = "Efficiency: " + Microsoft.VisualBasic.Strings.Format((object) SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.MainEff, "#0.0") + "% (SEDBUK2005)";
                XFont xfont215 = xfont2;
                XSolidBrush black200 = XBrushes.Black;
                double rc1_192 = (double) DeveloperReport.RC1;
                xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
                double point207 = ((XUnit) ref xunit3).Point;
                xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
                double num272 = ((XUnit) ref xunit3).Point / 2.0;
                XRect xrect207 = new XRect(200.0, rc1_192, point207, num272);
                XStringFormat topLeft207 = XStringFormat.TopLeft;
                xgraphics207.DrawString(str96, xfont215, (XBrush) black200, xrect207, topLeft207);
              }
              else
              {
                XGraphics xgraphics208 = PDFFunctions.gfx[DeveloperReport.k];
                // ISSUE: reference to a compiler-generated field
                string str97 = "Efficiency: " + Microsoft.VisualBasic.Strings.Format((object) SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.MainEff, "#0.0") + "% (SEDBUK2009)";
                XFont xfont216 = xfont2;
                XSolidBrush black201 = XBrushes.Black;
                double rc1_193 = (double) DeveloperReport.RC1;
                xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
                double point208 = ((XUnit) ref xunit3).Point;
                xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
                double num273 = ((XUnit) ref xunit3).Point / 2.0;
                XRect xrect208 = new XRect(200.0, rc1_193, point208, num273);
                XStringFormat topLeft208 = XStringFormat.TopLeft;
                xgraphics208.DrawString(str97, xfont216, (XBrush) black201, xrect208, topLeft208);
              }
            }
            else
            {
              XGraphics xgraphics209 = PDFFunctions.gfx[DeveloperReport.k];
              // ISSUE: reference to a compiler-generated field
              string str98 = "Efficiency: " + Microsoft.VisualBasic.Strings.Format((object) SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.MainEff, "#0.0") + "%";
              XFont xfont217 = xfont2;
              XSolidBrush black202 = XBrushes.Black;
              double rc1_194 = (double) DeveloperReport.RC1;
              xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
              double point209 = ((XUnit) ref xunit3).Point;
              xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
              double num274 = ((XUnit) ref xunit3).Point / 2.0;
              XRect xrect209 = new XRect(200.0, rc1_194, point209, num274);
              XStringFormat topLeft209 = XStringFormat.TopLeft;
              xgraphics209.DrawString(str98, xfont217, (XBrush) black202, xrect209, topLeft209);
            }
            checked { DeveloperReport.RC1 += 12; }
            XGraphics xgraphics210 = PDFFunctions.gfx[DeveloperReport.k];
            // ISSUE: reference to a compiler-generated field
            string mhType = SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.MHType;
            XFont xfont218 = xfont2;
            XSolidBrush black203 = XBrushes.Black;
            double rc1_195 = (double) DeveloperReport.RC1;
            xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
            double point210 = ((XUnit) ref xunit3).Point;
            xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
            double num275 = ((XUnit) ref xunit3).Point / 2.0;
            XRect xrect210 = new XRect(200.0, rc1_195, point210, num275);
            XStringFormat topLeft210 = XStringFormat.TopLeft;
            xgraphics210.DrawString(mhType, xfont218, (XBrush) black203, xrect210, topLeft210);
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.Fuel, "mains gas", false) == 0 | SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.Fuel.Contains("LPG") && Operators.CompareString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.SGroup, "Gas boilers and oil boilers", false) == 0)
            {
              checked { DeveloperReport.RC1 += 12; }
              XGraphics xgraphics211 = PDFFunctions.gfx[DeveloperReport.k];
              // ISSUE: reference to a compiler-generated field
              string str99 = "Fuel Burning Type: " + SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.FuelBurningType;
              XFont xfont219 = xfont2;
              XSolidBrush black204 = XBrushes.Black;
              double rc1_196 = (double) DeveloperReport.RC1;
              xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
              double point211 = ((XUnit) ref xunit3).Point;
              xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
              double num276 = ((XUnit) ref xunit3).Point / 2.0;
              XRect xrect211 = new XRect(200.0, rc1_196, point211, num276);
              XStringFormat topLeft211 = XStringFormat.TopLeft;
              xgraphics211.DrawString(str99, xfont219, (XBrush) black204, xrect211, topLeft211);
            }
          }
          else
          {
            XGraphics xgraphics212 = PDFFunctions.gfx[DeveloperReport.k];
            // ISSUE: reference to a compiler-generated field
            string str100 = "SAP Table: " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.SAPTableCode);
            XFont xfont220 = xfont2;
            XSolidBrush black205 = XBrushes.Black;
            double rc1_197 = (double) DeveloperReport.RC1;
            xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
            double point212 = ((XUnit) ref xunit3).Point;
            xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
            double num277 = ((XUnit) ref xunit3).Point / 2.0;
            XRect xrect212 = new XRect(200.0, rc1_197, point212, num277);
            XStringFormat topLeft212 = XStringFormat.TopLeft;
            xgraphics212.DrawString(str100, xfont220, (XBrush) black205, xrect212, topLeft212);
            checked { DeveloperReport.RC1 += 12; }
            XGraphics xgraphics213 = PDFFunctions.gfx[DeveloperReport.k];
            // ISSUE: reference to a compiler-generated field
            string mhType = SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.MHType;
            XFont xfont221 = xfont2;
            XSolidBrush black206 = XBrushes.Black;
            double rc1_198 = (double) DeveloperReport.RC1;
            xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
            double point213 = ((XUnit) ref xunit3).Point;
            xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
            double num278 = ((XUnit) ref xunit3).Point / 2.0;
            XRect xrect213 = new XRect(200.0, rc1_198, point213, num278);
            XStringFormat topLeft213 = XStringFormat.TopLeft;
            xgraphics213.DrawString(mhType, xfont221, (XBrush) black206, xrect213, topLeft213);
          }
        }
        checked { DeveloperReport.RC1 += 12; }
        XGraphics xgraphics214 = PDFFunctions.gfx[DeveloperReport.k];
        // ISSUE: reference to a compiler-generated field
        string emitter = SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.Emitter;
        XFont xfont222 = xfont2;
        XSolidBrush black207 = XBrushes.Black;
        double rc1_199 = (double) DeveloperReport.RC1;
        xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
        double point214 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
        double num279 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect214 = new XRect(200.0, rc1_199, point214, num279);
        XStringFormat topLeft214 = XStringFormat.TopLeft;
        xgraphics214.DrawString(emitter, xfont222, (XBrush) black207, xrect214, topLeft214);
        DeveloperReport.CheckRC1();
        // ISSUE: reference to a compiler-generated field
        if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.HGroup, "Central heating systems with radiators or underfloor heating", false) == 0)
        {
          checked { DeveloperReport.RC1 += 12; }
          XGraphics xgraphics215 = PDFFunctions.gfx[DeveloperReport.k];
          // ISSUE: reference to a compiler-generated field
          string str101 = "Pump in heat space: " + SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.Boiler.PumpHP;
          XFont xfont223 = xfont2;
          XSolidBrush black208 = XBrushes.Black;
          double rc1_200 = (double) DeveloperReport.RC1;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point215 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num280 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect215 = new XRect(200.0, rc1_200, point215, num280);
          XStringFormat topLeft215 = XStringFormat.TopLeft;
          xgraphics215.DrawString(str101, xfont223, (XBrush) black208, xrect215, topLeft215);
        }
      }
      else
      {
        List<PCDF.CommunityScheme_Sub> communitySchemeSubList = new List<PCDF.CommunityScheme_Sub>();
        // ISSUE: reference to a compiler-generated field
        if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.InforSource, "Boiler Database", false) == 0)
        {
          // ISSUE: reference to a compiler-generated field
          if ((uint) Operators.CompareString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.SEDBUK, "", false) > 0U)
          {
            // ISSUE: reference to a compiler-generated method
            communitySchemeSubList = SAP_Module.PCDFData.CommunitySchemes_Sub.Where<PCDF.CommunityScheme_Sub>(new Func<PCDF.CommunityScheme_Sub, bool>(closure140_2._Lambda\u0024__8)).ToList<PCDF.CommunityScheme_Sub>();
          }
          if (communitySchemeSubList.Count > 0)
          {
            XGraphics xgraphics216 = PDFFunctions.gfx[DeveloperReport.k];
            // ISSUE: reference to a compiler-generated field
            string str102 = "Database ( community network index " + SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.SEDBUK + "):";
            XFont xfont224 = xfont2;
            XSolidBrush black209 = XBrushes.Black;
            double rc1_201 = (double) DeveloperReport.RC1;
            xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
            double point216 = ((XUnit) ref xunit3).Point;
            xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
            double num281 = ((XUnit) ref xunit3).Point / 2.0;
            XRect xrect216 = new XRect(200.0, rc1_201, point216, num281);
            XStringFormat topLeft216 = XStringFormat.TopLeft;
            xgraphics216.DrawString(str102, xfont224, (XBrush) black209, xrect216, topLeft216);
            checked { DeveloperReport.RC1 += 12; }
            DeveloperReport.CheckRC1();
            // ISSUE: reference to a compiler-generated method
            PCDF.CommunityScheme communityScheme = SAP_Module.PCDFData.CommunitySchemes.Where<PCDF.CommunityScheme>(new Func<PCDF.CommunityScheme, bool>(closure140_2._Lambda\u0024__9)).SingleOrDefault<PCDF.CommunityScheme>();
            if (communityScheme != null)
            {
              XGraphics xgraphics217 = PDFFunctions.gfx[DeveloperReport.k];
              string str103 = "Brand name: " + communityScheme.CommunityHeatNetwork;
              XFont xfont225 = xfont2;
              XSolidBrush black210 = XBrushes.Black;
              double rc1_202 = (double) DeveloperReport.RC1;
              xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
              double point217 = ((XUnit) ref xunit3).Point;
              xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
              double num282 = ((XUnit) ref xunit3).Point / 2.0;
              XRect xrect217 = new XRect(200.0, rc1_202, point217, num282);
              XStringFormat topLeft217 = XStringFormat.TopLeft;
              xgraphics217.DrawString(str103, xfont225, (XBrush) black210, xrect217, topLeft217);
              checked { DeveloperReport.RC1 += 12; }
              XGraphics xgraphics218 = PDFFunctions.gfx[DeveloperReport.k];
              string str104 = "Postcode: " + communityScheme.PostcodeEnergyCentre;
              XFont xfont226 = xfont2;
              XSolidBrush black211 = XBrushes.Black;
              double rc1_203 = (double) DeveloperReport.RC1;
              xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
              double point218 = ((XUnit) ref xunit3).Point;
              xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
              double num283 = ((XUnit) ref xunit3).Point / 2.0;
              XRect xrect218 = new XRect(200.0, rc1_203, point218, num283);
              XStringFormat topLeft218 = XStringFormat.TopLeft;
              xgraphics218.DrawString(str104, xfont226, (XBrush) black211, xrect218, topLeft218);
              checked { DeveloperReport.RC1 += 12; }
              XGraphics xgraphics219 = PDFFunctions.gfx[DeveloperReport.k];
              string str105 = "Network Version: " + communityScheme.HeatNetworkVersion;
              XFont xfont227 = xfont2;
              XSolidBrush black212 = XBrushes.Black;
              double rc1_204 = (double) DeveloperReport.RC1;
              xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
              double point219 = ((XUnit) ref xunit3).Point;
              xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
              double num284 = ((XUnit) ref xunit3).Point / 2.0;
              XRect xrect219 = new XRect(200.0, rc1_204, point219, num284);
              XStringFormat topLeft219 = XStringFormat.TopLeft;
              xgraphics219.DrawString(str105, xfont227, (XBrush) black212, xrect219, topLeft219);
              checked { DeveloperReport.RC1 += 12; }
              string serviceProvision = communityScheme.ServiceProvision;
              string str106 = Operators.CompareString(serviceProvision, Conversions.ToString(3), false) != 0 ? (Operators.CompareString(serviceProvision, Conversions.ToString(1), false) != 0 ? (Operators.CompareString(serviceProvision, Conversions.ToString(4), false) != 0 ? communityScheme.ServiceProvision : "water heating only") : "space and water heating") : "space only";
              XGraphics xgraphics220 = PDFFunctions.gfx[DeveloperReport.k];
              string str107 = "Service provision: " + str106;
              XFont xfont228 = xfont2;
              XSolidBrush black213 = XBrushes.Black;
              double rc1_205 = (double) DeveloperReport.RC1;
              xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
              double point220 = ((XUnit) ref xunit3).Point;
              xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
              double num285 = ((XUnit) ref xunit3).Point / 2.0;
              XRect xrect220 = new XRect(200.0, rc1_205, point220, num285);
              XStringFormat topLeft220 = XStringFormat.TopLeft;
              xgraphics220.DrawString(str107, xfont228, (XBrush) black213, xrect220, topLeft220);
              checked { DeveloperReport.RC1 += 12; }
              if (Operators.CompareString(communityScheme.DataType, Conversions.ToString(1), false) == 0)
              {
                XGraphics xgraphics221 = PDFFunctions.gfx[DeveloperReport.k];
                string str108 = "Provisional (estimated) data: " + str106;
                XFont xfont229 = xfont2;
                XSolidBrush black214 = XBrushes.Black;
                double rc1_206 = (double) DeveloperReport.RC1;
                xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
                double point221 = ((XUnit) ref xunit3).Point;
                xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
                double num286 = ((XUnit) ref xunit3).Point / 2.0;
                XRect xrect221 = new XRect(200.0, rc1_206, point221, num286);
                XStringFormat topLeft221 = XStringFormat.TopLeft;
                xgraphics221.DrawString(str108, xfont229, (XBrush) black214, xrect221, topLeft221);
              }
              else
              {
                XGraphics xgraphics222 = PDFFunctions.gfx[DeveloperReport.k];
                XFont xfont230 = xfont2;
                XSolidBrush black215 = XBrushes.Black;
                double rc1_207 = (double) DeveloperReport.RC1;
                xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
                double point222 = ((XUnit) ref xunit3).Point;
                xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
                double num287 = ((XUnit) ref xunit3).Point / 2.0;
                XRect xrect222 = new XRect(200.0, rc1_207, point222, num287);
                XStringFormat topLeft222 = XStringFormat.TopLeft;
                xgraphics222.DrawString("Actual data", xfont230, (XBrush) black215, xrect222, topLeft222);
              }
              checked { DeveloperReport.RC1 += 12; }
            }
            // ISSUE: reference to a compiler-generated field
            switch (SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatSource1.Type)
            {
              case 306:
                XGraphics xgraphics223 = PDFFunctions.gfx[DeveloperReport.k];
                // ISSUE: reference to a compiler-generated field
                string str109 = "Heat source : Community boilers " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatSource1.Type);
                XFont xfont231 = xfont2;
                XSolidBrush black216 = XBrushes.Black;
                double rc1_208 = (double) DeveloperReport.RC1;
                xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
                double point223 = ((XUnit) ref xunit3).Point;
                xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
                double num288 = ((XUnit) ref xunit3).Point / 2.0;
                XRect xrect223 = new XRect(180.0, rc1_208, point223, num288);
                XStringFormat topLeft223 = XStringFormat.TopLeft;
                xgraphics223.DrawString(str109, xfont231, (XBrush) black216, xrect223, topLeft223);
                break;
              case 307:
                XGraphics xgraphics224 = PDFFunctions.gfx[DeveloperReport.k];
                XFont xfont232 = xfont2;
                XSolidBrush black217 = XBrushes.Black;
                double rc1_209 = (double) DeveloperReport.RC1;
                xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
                double point224 = ((XUnit) ref xunit3).Point;
                xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
                double num289 = ((XUnit) ref xunit3).Point / 2.0;
                XRect xrect224 = new XRect(180.0, rc1_209, point224, num289);
                XStringFormat topLeft224 = XStringFormat.TopLeft;
                xgraphics224.DrawString("Heat source : Community CHP", xfont232, (XBrush) black217, xrect224, topLeft224);
                break;
              case 308:
                XGraphics xgraphics225 = PDFFunctions.gfx[DeveloperReport.k];
                XFont xfont233 = xfont2;
                XSolidBrush black218 = XBrushes.Black;
                double rc1_210 = (double) DeveloperReport.RC1;
                xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
                double point225 = ((XUnit) ref xunit3).Point;
                xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
                double num290 = ((XUnit) ref xunit3).Point / 2.0;
                XRect xrect225 = new XRect(180.0, rc1_210, point225, num290);
                XStringFormat topLeft225 = XStringFormat.TopLeft;
                xgraphics225.DrawString("Heat source : Community heat pump", xfont233, (XBrush) black218, xrect225, topLeft225);
                break;
              case 309:
                XGraphics xgraphics226 = PDFFunctions.gfx[DeveloperReport.k];
                XFont xfont234 = xfont2;
                XSolidBrush black219 = XBrushes.Black;
                double rc1_211 = (double) DeveloperReport.RC1;
                xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
                double point226 = ((XUnit) ref xunit3).Point;
                xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
                double num291 = ((XUnit) ref xunit3).Point / 2.0;
                XRect xrect226 = new XRect(180.0, rc1_211, point226, num291);
                XStringFormat topLeft226 = XStringFormat.TopLeft;
                xgraphics226.DrawString("Heat source : Community waste heat from power station", xfont234, (XBrush) black219, xrect226, topLeft226);
                break;
              case 310:
                XGraphics xgraphics227 = PDFFunctions.gfx[DeveloperReport.k];
                XFont xfont235 = xfont2;
                XSolidBrush black220 = XBrushes.Black;
                double rc1_212 = (double) DeveloperReport.RC1;
                xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
                double point227 = ((XUnit) ref xunit3).Point;
                xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
                double num292 = ((XUnit) ref xunit3).Point / 2.0;
                XRect xrect227 = new XRect(180.0, rc1_212, point227, num292);
                XStringFormat topLeft227 = XStringFormat.TopLeft;
                xgraphics227.DrawString("Heat source : Community geothermal heat", xfont235, (XBrush) black220, xrect227, topLeft227);
                break;
            }
            checked { DeveloperReport.RC1 += 20; }
            if (communitySchemeSubList[0].CommunityFuel.Equals("99"))
            {
              XGraphics xgraphics228 = PDFFunctions.gfx[DeveloperReport.k];
              XFont xfont236 = xfont2;
              XSolidBrush black221 = XBrushes.Black;
              double rc1_213 = (double) DeveloperReport.RC1;
              xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
              double point228 = ((XUnit) ref xunit3).Point;
              xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
              double num293 = ((XUnit) ref xunit3).Point / 2.0;
              XRect xrect228 = new XRect(200.0, rc1_213, point228, num293);
              XStringFormat topLeft228 = XStringFormat.TopLeft;
              xgraphics228.DrawString("Fuel : biomethane", xfont236, (XBrush) black221, xrect228, topLeft228);
            }
            else
            {
              XGraphics xgraphics229 = PDFFunctions.gfx[DeveloperReport.k];
              // ISSUE: reference to a compiler-generated field
              string str110 = "Fuel : " + SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.Fuel;
              XFont xfont237 = xfont2;
              XSolidBrush black222 = XBrushes.Black;
              double rc1_214 = (double) DeveloperReport.RC1;
              xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
              double point229 = ((XUnit) ref xunit3).Point;
              xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
              double num294 = ((XUnit) ref xunit3).Point / 2.0;
              XRect xrect229 = new XRect(200.0, rc1_214, point229, num294);
              XStringFormat topLeft229 = XStringFormat.TopLeft;
              xgraphics229.DrawString(str110, xfont237, (XBrush) black222, xrect229, topLeft229);
            }
          }
          else
          {
            XGraphics xgraphics230 = PDFFunctions.gfx[DeveloperReport.k];
            // ISSUE: reference to a compiler-generated field
            string str111 = "Fuel : " + SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.Fuel;
            XFont xfont238 = xfont2;
            XSolidBrush black223 = XBrushes.Black;
            double rc1_215 = (double) DeveloperReport.RC1;
            xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
            double point230 = ((XUnit) ref xunit3).Point;
            xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
            double num295 = ((XUnit) ref xunit3).Point / 2.0;
            XRect xrect230 = new XRect(200.0, rc1_215, point230, num295);
            XStringFormat topLeft230 = XStringFormat.TopLeft;
            xgraphics230.DrawString(str111, xfont238, (XBrush) black223, xrect230, topLeft230);
          }
          checked { DeveloperReport.RC1 += 12; }
          DeveloperReport.CheckRC1();
          XGraphics xgraphics231 = PDFFunctions.gfx[DeveloperReport.k];
          // ISSUE: reference to a compiler-generated field
          string str112 = "Heat Fraction : " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.Boiler1HeatFraction);
          XFont xfont239 = xfont2;
          XSolidBrush black224 = XBrushes.Black;
          double rc1_216 = (double) DeveloperReport.RC1;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point231 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num296 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect231 = new XRect(200.0, rc1_216, point231, num296);
          XStringFormat topLeft231 = XStringFormat.TopLeft;
          xgraphics231.DrawString(str112, xfont239, (XBrush) black224, xrect231, topLeft231);
          checked { DeveloperReport.RC1 += 12; }
          DeveloperReport.CheckRC1();
          XGraphics xgraphics232 = PDFFunctions.gfx[DeveloperReport.k];
          // ISSUE: reference to a compiler-generated field
          string str113 = "Heat Efficiency : " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.Boiler1Efficiency);
          XFont xfont240 = xfont2;
          XSolidBrush black225 = XBrushes.Black;
          double rc1_217 = (double) DeveloperReport.RC1;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point232 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num297 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect232 = new XRect(200.0, rc1_217, point232, num297);
          XStringFormat topLeft232 = XStringFormat.TopLeft;
          xgraphics232.DrawString(str113, xfont240, (XBrush) black225, xrect232, topLeft232);
          checked { DeveloperReport.RC1 += 12; }
          DeveloperReport.CheckRC1();
          // ISSUE: reference to a compiler-generated field
          if ((double) SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatToPowerRatio > 0.0)
          {
            XGraphics xgraphics233 = PDFFunctions.gfx[DeveloperReport.k];
            // ISSUE: reference to a compiler-generated field
            string str114 = "Power-Efficiency : " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatToPowerRatio);
            XFont xfont241 = xfont2;
            XSolidBrush black226 = XBrushes.Black;
            double rc1_218 = (double) DeveloperReport.RC1;
            xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
            double point233 = ((XUnit) ref xunit3).Point;
            xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
            double num298 = ((XUnit) ref xunit3).Point / 2.0;
            XRect xrect233 = new XRect(200.0, rc1_218, point233, num298);
            XStringFormat topLeft233 = XStringFormat.TopLeft;
            xgraphics233.DrawString(str114, xfont241, (XBrush) black226, xrect233, topLeft233);
          }
          checked { DeveloperReport.RC1 += 12; }
          DeveloperReport.CheckRC1();
          if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.NoOfAdditionalHeatSources > 0)
          {
            // ISSUE: reference to a compiler-generated field
            switch (SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatSource1.Type)
            {
              case 306:
                XGraphics xgraphics234 = PDFFunctions.gfx[DeveloperReport.k];
                XFont xfont242 = xfont2;
                XSolidBrush black227 = XBrushes.Black;
                double rc1_219 = (double) DeveloperReport.RC1;
                xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
                double point234 = ((XUnit) ref xunit3).Point;
                xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
                double num299 = ((XUnit) ref xunit3).Point / 2.0;
                XRect xrect234 = new XRect(180.0, rc1_219, point234, num299);
                XStringFormat topLeft234 = XStringFormat.TopLeft;
                xgraphics234.DrawString("Heat source : Community boilers ", xfont242, (XBrush) black227, xrect234, topLeft234);
                break;
              case 307:
                XGraphics xgraphics235 = PDFFunctions.gfx[DeveloperReport.k];
                XFont xfont243 = xfont2;
                XSolidBrush black228 = XBrushes.Black;
                double rc1_220 = (double) DeveloperReport.RC1;
                xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
                double point235 = ((XUnit) ref xunit3).Point;
                xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
                double num300 = ((XUnit) ref xunit3).Point / 2.0;
                XRect xrect235 = new XRect(180.0, rc1_220, point235, num300);
                XStringFormat topLeft235 = XStringFormat.TopLeft;
                xgraphics235.DrawString("Heat source : Community CHP", xfont243, (XBrush) black228, xrect235, topLeft235);
                break;
              case 308:
                XGraphics xgraphics236 = PDFFunctions.gfx[DeveloperReport.k];
                XFont xfont244 = xfont2;
                XSolidBrush black229 = XBrushes.Black;
                double rc1_221 = (double) DeveloperReport.RC1;
                xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
                double point236 = ((XUnit) ref xunit3).Point;
                xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
                double num301 = ((XUnit) ref xunit3).Point / 2.0;
                XRect xrect236 = new XRect(180.0, rc1_221, point236, num301);
                XStringFormat topLeft236 = XStringFormat.TopLeft;
                xgraphics236.DrawString("Heat source : Community heat pump", xfont244, (XBrush) black229, xrect236, topLeft236);
                break;
              case 309:
                XGraphics xgraphics237 = PDFFunctions.gfx[DeveloperReport.k];
                XFont xfont245 = xfont2;
                XSolidBrush black230 = XBrushes.Black;
                double rc1_222 = (double) DeveloperReport.RC1;
                xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
                double point237 = ((XUnit) ref xunit3).Point;
                xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
                double num302 = ((XUnit) ref xunit3).Point / 2.0;
                XRect xrect237 = new XRect(180.0, rc1_222, point237, num302);
                XStringFormat topLeft237 = XStringFormat.TopLeft;
                xgraphics237.DrawString("Heat source : Community waste heat from power station", xfont245, (XBrush) black230, xrect237, topLeft237);
                break;
              case 310:
                XGraphics xgraphics238 = PDFFunctions.gfx[DeveloperReport.k];
                XFont xfont246 = xfont2;
                XSolidBrush black231 = XBrushes.Black;
                double rc1_223 = (double) DeveloperReport.RC1;
                xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
                double point238 = ((XUnit) ref xunit3).Point;
                xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
                double num303 = ((XUnit) ref xunit3).Point / 2.0;
                XRect xrect238 = new XRect(180.0, rc1_223, point238, num303);
                XStringFormat topLeft238 = XStringFormat.TopLeft;
                xgraphics238.DrawString("Heat source : Community geothermal heat", xfont246, (XBrush) black231, xrect238, topLeft238);
                break;
            }
            checked { DeveloperReport.RC1 += 20; }
            DeveloperReport.CheckRC1();
            if (communitySchemeSubList.Count > 0)
            {
              if (communitySchemeSubList[1].CommunityFuel.Equals("99"))
              {
                XGraphics xgraphics239 = PDFFunctions.gfx[DeveloperReport.k];
                XFont xfont247 = xfont2;
                XSolidBrush black232 = XBrushes.Black;
                double rc1_224 = (double) DeveloperReport.RC1;
                xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
                double point239 = ((XUnit) ref xunit3).Point;
                xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
                double num304 = ((XUnit) ref xunit3).Point / 2.0;
                XRect xrect239 = new XRect(200.0, rc1_224, point239, num304);
                XStringFormat topLeft239 = XStringFormat.TopLeft;
                xgraphics239.DrawString("Fuel : biomethane", xfont247, (XBrush) black232, xrect239, topLeft239);
              }
              else
              {
                XGraphics xgraphics240 = PDFFunctions.gfx[DeveloperReport.k];
                // ISSUE: reference to a compiler-generated field
                string str115 = "Fuel : " + SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatSource1.Fuel;
                XFont xfont248 = xfont2;
                XSolidBrush black233 = XBrushes.Black;
                double rc1_225 = (double) DeveloperReport.RC1;
                xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
                double point240 = ((XUnit) ref xunit3).Point;
                xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
                double num305 = ((XUnit) ref xunit3).Point / 2.0;
                XRect xrect240 = new XRect(200.0, rc1_225, point240, num305);
                XStringFormat topLeft240 = XStringFormat.TopLeft;
                xgraphics240.DrawString(str115, xfont248, (XBrush) black233, xrect240, topLeft240);
              }
            }
            else
            {
              XGraphics xgraphics241 = PDFFunctions.gfx[DeveloperReport.k];
              // ISSUE: reference to a compiler-generated field
              string str116 = "Fuel : " + SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatSource1.Fuel;
              XFont xfont249 = xfont2;
              XSolidBrush black234 = XBrushes.Black;
              double rc1_226 = (double) DeveloperReport.RC1;
              xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
              double point241 = ((XUnit) ref xunit3).Point;
              xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
              double num306 = ((XUnit) ref xunit3).Point / 2.0;
              XRect xrect241 = new XRect(200.0, rc1_226, point241, num306);
              XStringFormat topLeft241 = XStringFormat.TopLeft;
              xgraphics241.DrawString(str116, xfont249, (XBrush) black234, xrect241, topLeft241);
            }
            checked { DeveloperReport.RC1 += 12; }
            DeveloperReport.CheckRC1();
            XGraphics xgraphics242 = PDFFunctions.gfx[DeveloperReport.k];
            // ISSUE: reference to a compiler-generated field
            string str117 = "Heat Fraction : " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatSource1.HeatFraction);
            XFont xfont250 = xfont2;
            XSolidBrush black235 = XBrushes.Black;
            double rc1_227 = (double) DeveloperReport.RC1;
            xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
            double point242 = ((XUnit) ref xunit3).Point;
            xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
            double num307 = ((XUnit) ref xunit3).Point / 2.0;
            XRect xrect242 = new XRect(200.0, rc1_227, point242, num307);
            XStringFormat topLeft242 = XStringFormat.TopLeft;
            xgraphics242.DrawString(str117, xfont250, (XBrush) black235, xrect242, topLeft242);
            checked { DeveloperReport.RC1 += 12; }
            DeveloperReport.CheckRC1();
            XGraphics xgraphics243 = PDFFunctions.gfx[DeveloperReport.k];
            // ISSUE: reference to a compiler-generated field
            string str118 = "Heat Efficiency : " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatSource1.Efficiency);
            XFont xfont251 = xfont2;
            XSolidBrush black236 = XBrushes.Black;
            double rc1_228 = (double) DeveloperReport.RC1;
            xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
            double point243 = ((XUnit) ref xunit3).Point;
            xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
            double num308 = ((XUnit) ref xunit3).Point / 2.0;
            XRect xrect243 = new XRect(200.0, rc1_228, point243, num308);
            XStringFormat topLeft243 = XStringFormat.TopLeft;
            xgraphics243.DrawString(str118, xfont251, (XBrush) black236, xrect243, topLeft243);
            checked { DeveloperReport.RC1 += 12; }
            DeveloperReport.CheckRC1();
          }
          if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.NoOfAdditionalHeatSources > 1)
          {
            // ISSUE: reference to a compiler-generated field
            switch (SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatSource2.Type)
            {
              case 306:
                XGraphics xgraphics244 = PDFFunctions.gfx[DeveloperReport.k];
                XFont xfont252 = xfont2;
                XSolidBrush black237 = XBrushes.Black;
                double rc1_229 = (double) DeveloperReport.RC1;
                xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
                double point244 = ((XUnit) ref xunit3).Point;
                xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
                double num309 = ((XUnit) ref xunit3).Point / 2.0;
                XRect xrect244 = new XRect(180.0, rc1_229, point244, num309);
                XStringFormat topLeft244 = XStringFormat.TopLeft;
                xgraphics244.DrawString("Heat source : Community boilers ", xfont252, (XBrush) black237, xrect244, topLeft244);
                break;
              case 307:
                XGraphics xgraphics245 = PDFFunctions.gfx[DeveloperReport.k];
                XFont xfont253 = xfont2;
                XSolidBrush black238 = XBrushes.Black;
                double rc1_230 = (double) DeveloperReport.RC1;
                xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
                double point245 = ((XUnit) ref xunit3).Point;
                xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
                double num310 = ((XUnit) ref xunit3).Point / 2.0;
                XRect xrect245 = new XRect(180.0, rc1_230, point245, num310);
                XStringFormat topLeft245 = XStringFormat.TopLeft;
                xgraphics245.DrawString("Heat source : Community CHP", xfont253, (XBrush) black238, xrect245, topLeft245);
                break;
              case 308:
                XGraphics xgraphics246 = PDFFunctions.gfx[DeveloperReport.k];
                XFont xfont254 = xfont2;
                XSolidBrush black239 = XBrushes.Black;
                double rc1_231 = (double) DeveloperReport.RC1;
                xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
                double point246 = ((XUnit) ref xunit3).Point;
                xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
                double num311 = ((XUnit) ref xunit3).Point / 2.0;
                XRect xrect246 = new XRect(180.0, rc1_231, point246, num311);
                XStringFormat topLeft246 = XStringFormat.TopLeft;
                xgraphics246.DrawString("Heat source : Community heat pump", xfont254, (XBrush) black239, xrect246, topLeft246);
                break;
              case 309:
                XGraphics xgraphics247 = PDFFunctions.gfx[DeveloperReport.k];
                XFont xfont255 = xfont2;
                XSolidBrush black240 = XBrushes.Black;
                double rc1_232 = (double) DeveloperReport.RC1;
                xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
                double point247 = ((XUnit) ref xunit3).Point;
                xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
                double num312 = ((XUnit) ref xunit3).Point / 2.0;
                XRect xrect247 = new XRect(180.0, rc1_232, point247, num312);
                XStringFormat topLeft247 = XStringFormat.TopLeft;
                xgraphics247.DrawString("Heat source : Community waste heat from power station", xfont255, (XBrush) black240, xrect247, topLeft247);
                break;
              case 310:
                XGraphics xgraphics248 = PDFFunctions.gfx[DeveloperReport.k];
                XFont xfont256 = xfont2;
                XSolidBrush black241 = XBrushes.Black;
                double rc1_233 = (double) DeveloperReport.RC1;
                xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
                double point248 = ((XUnit) ref xunit3).Point;
                xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
                double num313 = ((XUnit) ref xunit3).Point / 2.0;
                XRect xrect248 = new XRect(180.0, rc1_233, point248, num313);
                XStringFormat topLeft248 = XStringFormat.TopLeft;
                xgraphics248.DrawString("Heat source : Community geothermal heat", xfont256, (XBrush) black241, xrect248, topLeft248);
                break;
            }
            checked { DeveloperReport.RC1 += 20; }
            DeveloperReport.CheckRC1();
            if (communitySchemeSubList.Count > 0)
            {
              if (communitySchemeSubList[2].CommunityFuel.Equals("99"))
              {
                XGraphics xgraphics249 = PDFFunctions.gfx[DeveloperReport.k];
                XFont xfont257 = xfont2;
                XSolidBrush black242 = XBrushes.Black;
                double rc1_234 = (double) DeveloperReport.RC1;
                xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
                double point249 = ((XUnit) ref xunit3).Point;
                xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
                double num314 = ((XUnit) ref xunit3).Point / 2.0;
                XRect xrect249 = new XRect(200.0, rc1_234, point249, num314);
                XStringFormat topLeft249 = XStringFormat.TopLeft;
                xgraphics249.DrawString("Fuel : biomethane", xfont257, (XBrush) black242, xrect249, topLeft249);
              }
              else
              {
                XGraphics xgraphics250 = PDFFunctions.gfx[DeveloperReport.k];
                // ISSUE: reference to a compiler-generated field
                string str119 = "Fuel : " + SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatSource2.Fuel;
                XFont xfont258 = xfont2;
                XSolidBrush black243 = XBrushes.Black;
                double rc1_235 = (double) DeveloperReport.RC1;
                xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
                double point250 = ((XUnit) ref xunit3).Point;
                xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
                double num315 = ((XUnit) ref xunit3).Point / 2.0;
                XRect xrect250 = new XRect(200.0, rc1_235, point250, num315);
                XStringFormat topLeft250 = XStringFormat.TopLeft;
                xgraphics250.DrawString(str119, xfont258, (XBrush) black243, xrect250, topLeft250);
              }
            }
            else
            {
              XGraphics xgraphics251 = PDFFunctions.gfx[DeveloperReport.k];
              // ISSUE: reference to a compiler-generated field
              string str120 = "Fuel : " + SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatSource2.Fuel;
              XFont xfont259 = xfont2;
              XSolidBrush black244 = XBrushes.Black;
              double rc1_236 = (double) DeveloperReport.RC1;
              xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
              double point251 = ((XUnit) ref xunit3).Point;
              xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
              double num316 = ((XUnit) ref xunit3).Point / 2.0;
              XRect xrect251 = new XRect(200.0, rc1_236, point251, num316);
              XStringFormat topLeft251 = XStringFormat.TopLeft;
              xgraphics251.DrawString(str120, xfont259, (XBrush) black244, xrect251, topLeft251);
            }
            checked { DeveloperReport.RC1 += 12; }
            DeveloperReport.CheckRC1();
            XGraphics xgraphics252 = PDFFunctions.gfx[DeveloperReport.k];
            // ISSUE: reference to a compiler-generated field
            string str121 = "Heat Fraction : " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatSource2.HeatFraction);
            XFont xfont260 = xfont2;
            XSolidBrush black245 = XBrushes.Black;
            double rc1_237 = (double) DeveloperReport.RC1;
            xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
            double point252 = ((XUnit) ref xunit3).Point;
            xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
            double num317 = ((XUnit) ref xunit3).Point / 2.0;
            XRect xrect252 = new XRect(200.0, rc1_237, point252, num317);
            XStringFormat topLeft252 = XStringFormat.TopLeft;
            xgraphics252.DrawString(str121, xfont260, (XBrush) black245, xrect252, topLeft252);
            checked { DeveloperReport.RC1 += 12; }
            DeveloperReport.CheckRC1();
            XGraphics xgraphics253 = PDFFunctions.gfx[DeveloperReport.k];
            // ISSUE: reference to a compiler-generated field
            string str122 = "Heat Efficiency : " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatSource2.Efficiency);
            XFont xfont261 = xfont2;
            XSolidBrush black246 = XBrushes.Black;
            double rc1_238 = (double) DeveloperReport.RC1;
            xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
            double point253 = ((XUnit) ref xunit3).Point;
            xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
            double num318 = ((XUnit) ref xunit3).Point / 2.0;
            XRect xrect253 = new XRect(200.0, rc1_238, point253, num318);
            XStringFormat topLeft253 = XStringFormat.TopLeft;
            xgraphics253.DrawString(str122, xfont261, (XBrush) black246, xrect253, topLeft253);
            checked { DeveloperReport.RC1 += 12; }
            DeveloperReport.CheckRC1();
          }
          // ISSUE: reference to a compiler-generated field
          if (SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.NoOfAdditionalHeatSources > 2)
          {
            // ISSUE: reference to a compiler-generated field
            switch (SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatSource3.Type)
            {
              case 306:
                XGraphics xgraphics254 = PDFFunctions.gfx[DeveloperReport.k];
                XFont xfont262 = xfont2;
                XSolidBrush black247 = XBrushes.Black;
                double rc1_239 = (double) DeveloperReport.RC1;
                xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
                double point254 = ((XUnit) ref xunit3).Point;
                xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
                double num319 = ((XUnit) ref xunit3).Point / 2.0;
                XRect xrect254 = new XRect(180.0, rc1_239, point254, num319);
                XStringFormat topLeft254 = XStringFormat.TopLeft;
                xgraphics254.DrawString("Heat source : Community boilers ", xfont262, (XBrush) black247, xrect254, topLeft254);
                break;
              case 307:
                XGraphics xgraphics255 = PDFFunctions.gfx[DeveloperReport.k];
                XFont xfont263 = xfont2;
                XSolidBrush black248 = XBrushes.Black;
                double rc1_240 = (double) DeveloperReport.RC1;
                xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
                double point255 = ((XUnit) ref xunit3).Point;
                xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
                double num320 = ((XUnit) ref xunit3).Point / 2.0;
                XRect xrect255 = new XRect(180.0, rc1_240, point255, num320);
                XStringFormat topLeft255 = XStringFormat.TopLeft;
                xgraphics255.DrawString("Heat source : Community CHP", xfont263, (XBrush) black248, xrect255, topLeft255);
                break;
              case 308:
                XGraphics xgraphics256 = PDFFunctions.gfx[DeveloperReport.k];
                XFont xfont264 = xfont2;
                XSolidBrush black249 = XBrushes.Black;
                double rc1_241 = (double) DeveloperReport.RC1;
                xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
                double point256 = ((XUnit) ref xunit3).Point;
                xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
                double num321 = ((XUnit) ref xunit3).Point / 2.0;
                XRect xrect256 = new XRect(180.0, rc1_241, point256, num321);
                XStringFormat topLeft256 = XStringFormat.TopLeft;
                xgraphics256.DrawString("Heat source : Community heat pump", xfont264, (XBrush) black249, xrect256, topLeft256);
                break;
              case 309:
                XGraphics xgraphics257 = PDFFunctions.gfx[DeveloperReport.k];
                XFont xfont265 = xfont2;
                XSolidBrush black250 = XBrushes.Black;
                double rc1_242 = (double) DeveloperReport.RC1;
                xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
                double point257 = ((XUnit) ref xunit3).Point;
                xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
                double num322 = ((XUnit) ref xunit3).Point / 2.0;
                XRect xrect257 = new XRect(180.0, rc1_242, point257, num322);
                XStringFormat topLeft257 = XStringFormat.TopLeft;
                xgraphics257.DrawString("Heat source : Community waste heat from power station", xfont265, (XBrush) black250, xrect257, topLeft257);
                break;
              case 310:
                XGraphics xgraphics258 = PDFFunctions.gfx[DeveloperReport.k];
                XFont xfont266 = xfont2;
                XSolidBrush black251 = XBrushes.Black;
                double rc1_243 = (double) DeveloperReport.RC1;
                xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
                double point258 = ((XUnit) ref xunit3).Point;
                xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
                double num323 = ((XUnit) ref xunit3).Point / 2.0;
                XRect xrect258 = new XRect(180.0, rc1_243, point258, num323);
                XStringFormat topLeft258 = XStringFormat.TopLeft;
                xgraphics258.DrawString("Heat source : Community geothermal heat", xfont266, (XBrush) black251, xrect258, topLeft258);
                break;
            }
            checked { DeveloperReport.RC1 += 20; }
            DeveloperReport.CheckRC1();
            DeveloperReport.CheckRC1();
            if (communitySchemeSubList.Count > 0)
            {
              if (communitySchemeSubList[3].CommunityFuel.Equals("99"))
              {
                XGraphics xgraphics259 = PDFFunctions.gfx[DeveloperReport.k];
                XFont xfont267 = xfont2;
                XSolidBrush black252 = XBrushes.Black;
                double rc1_244 = (double) DeveloperReport.RC1;
                xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
                double point259 = ((XUnit) ref xunit3).Point;
                xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
                double num324 = ((XUnit) ref xunit3).Point / 2.0;
                XRect xrect259 = new XRect(200.0, rc1_244, point259, num324);
                XStringFormat topLeft259 = XStringFormat.TopLeft;
                xgraphics259.DrawString("Fuel : biomethane", xfont267, (XBrush) black252, xrect259, topLeft259);
              }
              else
              {
                XGraphics xgraphics260 = PDFFunctions.gfx[DeveloperReport.k];
                // ISSUE: reference to a compiler-generated field
                string str123 = "Fuel : " + SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatSource3.Fuel;
                XFont xfont268 = xfont2;
                XSolidBrush black253 = XBrushes.Black;
                double rc1_245 = (double) DeveloperReport.RC1;
                xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
                double point260 = ((XUnit) ref xunit3).Point;
                xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
                double num325 = ((XUnit) ref xunit3).Point / 2.0;
                XRect xrect260 = new XRect(200.0, rc1_245, point260, num325);
                XStringFormat topLeft260 = XStringFormat.TopLeft;
                xgraphics260.DrawString(str123, xfont268, (XBrush) black253, xrect260, topLeft260);
              }
            }
            else
            {
              XGraphics xgraphics261 = PDFFunctions.gfx[DeveloperReport.k];
              // ISSUE: reference to a compiler-generated field
              string str124 = "Fuel : " + SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatSource3.Fuel;
              XFont xfont269 = xfont2;
              XSolidBrush black254 = XBrushes.Black;
              double rc1_246 = (double) DeveloperReport.RC1;
              xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
              double point261 = ((XUnit) ref xunit3).Point;
              xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
              double num326 = ((XUnit) ref xunit3).Point / 2.0;
              XRect xrect261 = new XRect(200.0, rc1_246, point261, num326);
              XStringFormat topLeft261 = XStringFormat.TopLeft;
              xgraphics261.DrawString(str124, xfont269, (XBrush) black254, xrect261, topLeft261);
            }
            checked { DeveloperReport.RC1 += 12; }
            DeveloperReport.CheckRC1();
            XGraphics xgraphics262 = PDFFunctions.gfx[DeveloperReport.k];
            // ISSUE: reference to a compiler-generated field
            string str125 = "Heat Fraction : " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatSource3.HeatFraction);
            XFont xfont270 = xfont2;
            XSolidBrush black255 = XBrushes.Black;
            double rc1_247 = (double) DeveloperReport.RC1;
            xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
            double point262 = ((XUnit) ref xunit3).Point;
            xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
            double num327 = ((XUnit) ref xunit3).Point / 2.0;
            XRect xrect262 = new XRect(200.0, rc1_247, point262, num327);
            XStringFormat topLeft262 = XStringFormat.TopLeft;
            xgraphics262.DrawString(str125, xfont270, (XBrush) black255, xrect262, topLeft262);
            checked { DeveloperReport.RC1 += 12; }
            DeveloperReport.CheckRC1();
            XGraphics xgraphics263 = PDFFunctions.gfx[DeveloperReport.k];
            // ISSUE: reference to a compiler-generated field
            string str126 = "Heat Efficiency : " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatSource3.Efficiency);
            XFont xfont271 = xfont2;
            XSolidBrush black256 = XBrushes.Black;
            double rc1_248 = (double) DeveloperReport.RC1;
            xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
            double point263 = ((XUnit) ref xunit3).Point;
            xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
            double num328 = ((XUnit) ref xunit3).Point / 2.0;
            XRect xrect263 = new XRect(200.0, rc1_248, point263, num328);
            XStringFormat topLeft263 = XStringFormat.TopLeft;
            xgraphics263.DrawString(str126, xfont271, (XBrush) black256, xrect263, topLeft263);
            checked { DeveloperReport.RC1 += 12; }
            DeveloperReport.CheckRC1();
          }
          if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.NoOfAdditionalHeatSources > 3)
          {
            // ISSUE: reference to a compiler-generated field
            switch (SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatSource4.Type)
            {
              case 306:
                XGraphics xgraphics264 = PDFFunctions.gfx[DeveloperReport.k];
                XFont xfont272 = xfont2;
                XSolidBrush black257 = XBrushes.Black;
                double rc1_249 = (double) DeveloperReport.RC1;
                xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
                double point264 = ((XUnit) ref xunit3).Point;
                xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
                double num329 = ((XUnit) ref xunit3).Point / 2.0;
                XRect xrect264 = new XRect(180.0, rc1_249, point264, num329);
                XStringFormat topLeft264 = XStringFormat.TopLeft;
                xgraphics264.DrawString("Heat source : Community boilers ", xfont272, (XBrush) black257, xrect264, topLeft264);
                break;
              case 307:
                XGraphics xgraphics265 = PDFFunctions.gfx[DeveloperReport.k];
                XFont xfont273 = xfont2;
                XSolidBrush black258 = XBrushes.Black;
                double rc1_250 = (double) DeveloperReport.RC1;
                xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
                double point265 = ((XUnit) ref xunit3).Point;
                xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
                double num330 = ((XUnit) ref xunit3).Point / 2.0;
                XRect xrect265 = new XRect(180.0, rc1_250, point265, num330);
                XStringFormat topLeft265 = XStringFormat.TopLeft;
                xgraphics265.DrawString("Heat source : Community CHP", xfont273, (XBrush) black258, xrect265, topLeft265);
                break;
              case 308:
                XGraphics xgraphics266 = PDFFunctions.gfx[DeveloperReport.k];
                XFont xfont274 = xfont2;
                XSolidBrush black259 = XBrushes.Black;
                double rc1_251 = (double) DeveloperReport.RC1;
                xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
                double point266 = ((XUnit) ref xunit3).Point;
                xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
                double num331 = ((XUnit) ref xunit3).Point / 2.0;
                XRect xrect266 = new XRect(180.0, rc1_251, point266, num331);
                XStringFormat topLeft266 = XStringFormat.TopLeft;
                xgraphics266.DrawString("Heat source : Community heat pump", xfont274, (XBrush) black259, xrect266, topLeft266);
                break;
              case 309:
                XGraphics xgraphics267 = PDFFunctions.gfx[DeveloperReport.k];
                XFont xfont275 = xfont2;
                XSolidBrush black260 = XBrushes.Black;
                double rc1_252 = (double) DeveloperReport.RC1;
                xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
                double point267 = ((XUnit) ref xunit3).Point;
                xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
                double num332 = ((XUnit) ref xunit3).Point / 2.0;
                XRect xrect267 = new XRect(180.0, rc1_252, point267, num332);
                XStringFormat topLeft267 = XStringFormat.TopLeft;
                xgraphics267.DrawString("Heat source : Community waste heat from power station", xfont275, (XBrush) black260, xrect267, topLeft267);
                break;
              case 310:
                XGraphics xgraphics268 = PDFFunctions.gfx[DeveloperReport.k];
                XFont xfont276 = xfont2;
                XSolidBrush black261 = XBrushes.Black;
                double rc1_253 = (double) DeveloperReport.RC1;
                xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
                double point268 = ((XUnit) ref xunit3).Point;
                xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
                double num333 = ((XUnit) ref xunit3).Point / 2.0;
                XRect xrect268 = new XRect(180.0, rc1_253, point268, num333);
                XStringFormat topLeft268 = XStringFormat.TopLeft;
                xgraphics268.DrawString("Heat source : Community geothermal heat", xfont276, (XBrush) black261, xrect268, topLeft268);
                break;
            }
            checked { DeveloperReport.RC1 += 20; }
            DeveloperReport.CheckRC1();
            if (communitySchemeSubList.Count > 0)
            {
              if (communitySchemeSubList[4].CommunityFuel.Equals("99"))
              {
                XGraphics xgraphics269 = PDFFunctions.gfx[DeveloperReport.k];
                XFont xfont277 = xfont2;
                XSolidBrush black262 = XBrushes.Black;
                double rc1_254 = (double) DeveloperReport.RC1;
                xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
                double point269 = ((XUnit) ref xunit3).Point;
                xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
                double num334 = ((XUnit) ref xunit3).Point / 2.0;
                XRect xrect269 = new XRect(200.0, rc1_254, point269, num334);
                XStringFormat topLeft269 = XStringFormat.TopLeft;
                xgraphics269.DrawString("Fuel : biomethane", xfont277, (XBrush) black262, xrect269, topLeft269);
              }
              else
              {
                XGraphics xgraphics270 = PDFFunctions.gfx[DeveloperReport.k];
                // ISSUE: reference to a compiler-generated field
                string str127 = "Fuel : " + SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatSource4.Fuel;
                XFont xfont278 = xfont2;
                XSolidBrush black263 = XBrushes.Black;
                double rc1_255 = (double) DeveloperReport.RC1;
                xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
                double point270 = ((XUnit) ref xunit3).Point;
                xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
                double num335 = ((XUnit) ref xunit3).Point / 2.0;
                XRect xrect270 = new XRect(200.0, rc1_255, point270, num335);
                XStringFormat topLeft270 = XStringFormat.TopLeft;
                xgraphics270.DrawString(str127, xfont278, (XBrush) black263, xrect270, topLeft270);
              }
            }
            else
            {
              XGraphics xgraphics271 = PDFFunctions.gfx[DeveloperReport.k];
              // ISSUE: reference to a compiler-generated field
              string str128 = "Fuel : " + SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatSource4.Fuel;
              XFont xfont279 = xfont2;
              XSolidBrush black264 = XBrushes.Black;
              double rc1_256 = (double) DeveloperReport.RC1;
              xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
              double point271 = ((XUnit) ref xunit3).Point;
              xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
              double num336 = ((XUnit) ref xunit3).Point / 2.0;
              XRect xrect271 = new XRect(200.0, rc1_256, point271, num336);
              XStringFormat topLeft271 = XStringFormat.TopLeft;
              xgraphics271.DrawString(str128, xfont279, (XBrush) black264, xrect271, topLeft271);
            }
            checked { DeveloperReport.RC1 += 12; }
            DeveloperReport.CheckRC1();
            XGraphics xgraphics272 = PDFFunctions.gfx[DeveloperReport.k];
            // ISSUE: reference to a compiler-generated field
            string str129 = "Heat Fraction : " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatSource4.HeatFraction);
            XFont xfont280 = xfont2;
            XSolidBrush black265 = XBrushes.Black;
            double rc1_257 = (double) DeveloperReport.RC1;
            xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
            double point272 = ((XUnit) ref xunit3).Point;
            xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
            double num337 = ((XUnit) ref xunit3).Point / 2.0;
            XRect xrect272 = new XRect(200.0, rc1_257, point272, num337);
            XStringFormat topLeft272 = XStringFormat.TopLeft;
            xgraphics272.DrawString(str129, xfont280, (XBrush) black265, xrect272, topLeft272);
            checked { DeveloperReport.RC1 += 12; }
            DeveloperReport.CheckRC1();
            XGraphics xgraphics273 = PDFFunctions.gfx[DeveloperReport.k];
            // ISSUE: reference to a compiler-generated field
            string str130 = "Heat Efficiency : " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatSource4.Efficiency);
            XFont xfont281 = xfont2;
            XSolidBrush black266 = XBrushes.Black;
            double rc1_258 = (double) DeveloperReport.RC1;
            xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
            double point273 = ((XUnit) ref xunit3).Point;
            xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
            double num338 = ((XUnit) ref xunit3).Point / 2.0;
            XRect xrect273 = new XRect(200.0, rc1_258, point273, num338);
            XStringFormat topLeft273 = XStringFormat.TopLeft;
            xgraphics273.DrawString(str130, xfont281, (XBrush) black266, xrect273, topLeft273);
            checked { DeveloperReport.RC1 += 12; }
            DeveloperReport.CheckRC1();
          }
        }
        else
        {
          XGraphics xgraphics274 = PDFFunctions.gfx[DeveloperReport.k];
          // ISSUE: reference to a compiler-generated field
          string str131 = "Heat source: " + SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.MHType;
          XFont xfont282 = xfont2;
          XSolidBrush black267 = XBrushes.Black;
          double rc1_259 = (double) DeveloperReport.RC1;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point274 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num339 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect274 = new XRect(200.0, rc1_259, point274, num339);
          XStringFormat topLeft274 = XStringFormat.TopLeft;
          xgraphics274.DrawString(str131, xfont282, (XBrush) black267, xrect274, topLeft274);
          checked { DeveloperReport.RC1 += 12; }
          DeveloperReport.CheckRC1();
          XGraphics xgraphics275 = PDFFunctions.gfx[DeveloperReport.k];
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          string str132 = SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.Fuel + ", heat fraction " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.Boiler1HeatFraction) + ", efficiency " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.Boiler1Efficiency);
          XFont xfont283 = xfont2;
          XSolidBrush black268 = XBrushes.Black;
          double rc1_260 = (double) DeveloperReport.RC1;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point275 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num340 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect275 = new XRect(205.0, rc1_260, point275, num340);
          XStringFormat topLeft275 = XStringFormat.TopLeft;
          xgraphics275.DrawString(str132, xfont283, (XBrush) black268, xrect275, topLeft275);
          // ISSUE: reference to a compiler-generated field
          if (SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.NoOfAdditionalHeatSources > 0)
          {
            // ISSUE: reference to a compiler-generated method
            PCDF.Table4a_B table4aB = SAP_Module.PCDFData.Table4a_bs.Where<PCDF.Table4a_B>(new Func<PCDF.Table4a_B, bool>(closure140_2._Lambda\u0024__10)).SingleOrDefault<PCDF.Table4a_B>();
            checked { DeveloperReport.RC1 += 12; }
            DeveloperReport.CheckRC1();
            XGraphics xgraphics276 = PDFFunctions.gfx[DeveloperReport.k];
            string str133 = "Heat source: " + table4aB.Description;
            XFont xfont284 = xfont2;
            XSolidBrush black269 = XBrushes.Black;
            double rc1_261 = (double) DeveloperReport.RC1;
            xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
            double point276 = ((XUnit) ref xunit3).Point;
            xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
            double num341 = ((XUnit) ref xunit3).Point / 2.0;
            XRect xrect276 = new XRect(200.0, rc1_261, point276, num341);
            XStringFormat topLeft276 = XStringFormat.TopLeft;
            xgraphics276.DrawString(str133, xfont284, (XBrush) black269, xrect276, topLeft276);
            checked { DeveloperReport.RC1 += 12; }
            DeveloperReport.CheckRC1();
            XGraphics xgraphics277 = PDFFunctions.gfx[DeveloperReport.k];
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            string str134 = SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatSource1.Fuel + ", heat fraction " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatSource1.HeatFraction) + ", efficiency " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatSource1.Efficiency);
            XFont xfont285 = xfont2;
            XSolidBrush black270 = XBrushes.Black;
            double rc1_262 = (double) DeveloperReport.RC1;
            xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
            double point277 = ((XUnit) ref xunit3).Point;
            xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
            double num342 = ((XUnit) ref xunit3).Point / 2.0;
            XRect xrect277 = new XRect(205.0, rc1_262, point277, num342);
            XStringFormat topLeft277 = XStringFormat.TopLeft;
            xgraphics277.DrawString(str134, xfont285, (XBrush) black270, xrect277, topLeft277);
          }
          // ISSUE: reference to a compiler-generated field
          if (SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.NoOfAdditionalHeatSources > 1)
          {
            // ISSUE: reference to a compiler-generated method
            PCDF.Table4a_B table4aB = SAP_Module.PCDFData.Table4a_bs.Where<PCDF.Table4a_B>(new Func<PCDF.Table4a_B, bool>(closure140_2._Lambda\u0024__11)).SingleOrDefault<PCDF.Table4a_B>();
            checked { DeveloperReport.RC1 += 12; }
            DeveloperReport.CheckRC1();
            XGraphics xgraphics278 = PDFFunctions.gfx[DeveloperReport.k];
            string str135 = "Heat source: " + table4aB.Description;
            XFont xfont286 = xfont2;
            XSolidBrush black271 = XBrushes.Black;
            double rc1_263 = (double) DeveloperReport.RC1;
            xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
            double point278 = ((XUnit) ref xunit3).Point;
            xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
            double num343 = ((XUnit) ref xunit3).Point / 2.0;
            XRect xrect278 = new XRect(200.0, rc1_263, point278, num343);
            XStringFormat topLeft278 = XStringFormat.TopLeft;
            xgraphics278.DrawString(str135, xfont286, (XBrush) black271, xrect278, topLeft278);
            checked { DeveloperReport.RC1 += 12; }
            DeveloperReport.CheckRC1();
            XGraphics xgraphics279 = PDFFunctions.gfx[DeveloperReport.k];
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            string str136 = SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatSource2.Fuel + ", heat fraction " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatSource2.HeatFraction) + ", efficiency " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatSource2.Efficiency);
            XFont xfont287 = xfont2;
            XSolidBrush black272 = XBrushes.Black;
            double rc1_264 = (double) DeveloperReport.RC1;
            xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
            double point279 = ((XUnit) ref xunit3).Point;
            xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
            double num344 = ((XUnit) ref xunit3).Point / 2.0;
            XRect xrect279 = new XRect(205.0, rc1_264, point279, num344);
            XStringFormat topLeft279 = XStringFormat.TopLeft;
            xgraphics279.DrawString(str136, xfont287, (XBrush) black272, xrect279, topLeft279);
          }
          // ISSUE: reference to a compiler-generated field
          if (SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.NoOfAdditionalHeatSources > 2)
          {
            // ISSUE: reference to a compiler-generated method
            PCDF.Table4a_B table4aB = SAP_Module.PCDFData.Table4a_bs.Where<PCDF.Table4a_B>(new Func<PCDF.Table4a_B, bool>(closure140_2._Lambda\u0024__12)).SingleOrDefault<PCDF.Table4a_B>();
            checked { DeveloperReport.RC1 += 12; }
            DeveloperReport.CheckRC1();
            XGraphics xgraphics280 = PDFFunctions.gfx[DeveloperReport.k];
            string str137 = "Heat source: " + table4aB.Description;
            XFont xfont288 = xfont2;
            XSolidBrush black273 = XBrushes.Black;
            double rc1_265 = (double) DeveloperReport.RC1;
            xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
            double point280 = ((XUnit) ref xunit3).Point;
            xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
            double num345 = ((XUnit) ref xunit3).Point / 2.0;
            XRect xrect280 = new XRect(200.0, rc1_265, point280, num345);
            XStringFormat topLeft280 = XStringFormat.TopLeft;
            xgraphics280.DrawString(str137, xfont288, (XBrush) black273, xrect280, topLeft280);
            checked { DeveloperReport.RC1 += 12; }
            DeveloperReport.CheckRC1();
            XGraphics xgraphics281 = PDFFunctions.gfx[DeveloperReport.k];
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            string str138 = SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatSource3.Fuel + ", heat fraction " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatSource3.HeatFraction) + ", efficiency " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatSource3.Efficiency);
            XFont xfont289 = xfont2;
            XSolidBrush black274 = XBrushes.Black;
            double rc1_266 = (double) DeveloperReport.RC1;
            xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
            double point281 = ((XUnit) ref xunit3).Point;
            xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
            double num346 = ((XUnit) ref xunit3).Point / 2.0;
            XRect xrect281 = new XRect(205.0, rc1_266, point281, num346);
            XStringFormat topLeft281 = XStringFormat.TopLeft;
            xgraphics281.DrawString(str138, xfont289, (XBrush) black274, xrect281, topLeft281);
          }
          // ISSUE: reference to a compiler-generated field
          if (SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.NoOfAdditionalHeatSources > 3)
          {
            // ISSUE: reference to a compiler-generated method
            PCDF.Table4a_B table4aB = SAP_Module.PCDFData.Table4a_bs.Where<PCDF.Table4a_B>(new Func<PCDF.Table4a_B, bool>(closure140_2._Lambda\u0024__13)).SingleOrDefault<PCDF.Table4a_B>();
            checked { DeveloperReport.RC1 += 12; }
            DeveloperReport.CheckRC1();
            XGraphics xgraphics282 = PDFFunctions.gfx[DeveloperReport.k];
            string str139 = "Heat source: " + table4aB.Description;
            XFont xfont290 = xfont2;
            XSolidBrush black275 = XBrushes.Black;
            double rc1_267 = (double) DeveloperReport.RC1;
            xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
            double point282 = ((XUnit) ref xunit3).Point;
            xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
            double num347 = ((XUnit) ref xunit3).Point / 2.0;
            XRect xrect282 = new XRect(200.0, rc1_267, point282, num347);
            XStringFormat topLeft282 = XStringFormat.TopLeft;
            xgraphics282.DrawString(str139, xfont290, (XBrush) black275, xrect282, topLeft282);
            checked { DeveloperReport.RC1 += 12; }
            DeveloperReport.CheckRC1();
            XGraphics xgraphics283 = PDFFunctions.gfx[DeveloperReport.k];
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            string str140 = SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatSource4.Fuel + ", heat fraction " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatSource4.HeatFraction) + ", efficiency " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatSource4.Efficiency);
            XFont xfont291 = xfont2;
            XSolidBrush black276 = XBrushes.Black;
            double rc1_268 = (double) DeveloperReport.RC1;
            xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
            double point283 = ((XUnit) ref xunit3).Point;
            xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
            double num348 = ((XUnit) ref xunit3).Point / 2.0;
            XRect xrect283 = new XRect(205.0, rc1_268, point283, num348);
            XStringFormat topLeft283 = XStringFormat.TopLeft;
            xgraphics283.DrawString(str140, xfont291, (XBrush) black276, xrect283, topLeft283);
          }
          checked { DeveloperReport.RC1 += 12; }
          DeveloperReport.CheckRC1();
          XGraphics xgraphics284 = PDFFunctions.gfx[DeveloperReport.k];
          // ISSUE: reference to a compiler-generated field
          string heatDsystem = SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatDSystem;
          XFont xfont292 = xfont2;
          XSolidBrush black277 = XBrushes.Black;
          double rc1_269 = (double) DeveloperReport.RC1;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point284 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num349 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect284 = new XRect(200.0, rc1_269, point284, num349);
          XStringFormat topLeft284 = XStringFormat.TopLeft;
          xgraphics284.DrawString(heatDsystem, xfont292, (XBrush) black277, xrect284, topLeft284);
        }
      }
      checked { DeveloperReport.RC1 += 14; }
      // ISSUE: reference to a compiler-generated field
      if (SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].IncludeMainHeating2)
      {
        XGraphics xgraphics285 = PDFFunctions.gfx[DeveloperReport.k];
        // ISSUE: reference to a compiler-generated field
        string str141 = "Fraction of main heat: " + Conversions.ToString(Math.Round(1.0 - (double) SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].HeatFractionSec, 2));
        XFont xfont293 = xfont2;
        XSolidBrush black278 = XBrushes.Black;
        double rc1_270 = (double) DeveloperReport.RC1;
        xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
        double point285 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
        double num350 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect285 = new XRect(200.0, rc1_270, point285, num350);
        XStringFormat topLeft285 = XStringFormat.TopLeft;
        xgraphics285.DrawString(str141, xfont293, (XBrush) black278, xrect285, topLeft285);
        checked { DeveloperReport.RC1 += 12; }
        DeveloperReport.CheckRC1();
      }
      DeveloperReport.CheckRC1();
      // ISSUE: reference to a compiler-generated field
      if (!string.IsNullOrEmpty(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.Boiler.PumpType))
      {
        XGraphics xgraphics286 = PDFFunctions.gfx[DeveloperReport.k];
        // ISSUE: reference to a compiler-generated field
        string str142 = "Central heating pump : " + SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.Boiler.PumpType;
        XFont xfont294 = xfont2;
        XSolidBrush black279 = XBrushes.Black;
        double rc1_271 = (double) DeveloperReport.RC1;
        xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
        double point286 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
        double num351 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect286 = new XRect(200.0, rc1_271, point286, num351);
        XStringFormat topLeft286 = XStringFormat.TopLeft;
        xgraphics286.DrawString(str142, xfont294, (XBrush) black279, xrect286, topLeft286);
        checked { DeveloperReport.RC1 += 12; }
        DeveloperReport.CheckRC1();
      }
      // ISSUE: reference to a compiler-generated field
      if (!string.IsNullOrEmpty(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.Boiler.FlowTemp))
      {
        XGraphics xgraphics287 = PDFFunctions.gfx[DeveloperReport.k];
        // ISSUE: reference to a compiler-generated field
        string str143 = "Design flow temperature: " + SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.Boiler.FlowTemp;
        XFont xfont295 = xfont2;
        XSolidBrush black280 = XBrushes.Black;
        double rc1_272 = (double) DeveloperReport.RC1;
        xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
        double point287 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
        double num352 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect287 = new XRect(200.0, rc1_272, point287, num352);
        XStringFormat topLeft287 = XStringFormat.TopLeft;
        xgraphics287.DrawString(str143, xfont295, (XBrush) black280, xrect287, topLeft287);
        checked { DeveloperReport.RC1 += 12; }
        DeveloperReport.CheckRC1();
      }
      // ISSUE: reference to a compiler-generated field
      if (!string.IsNullOrEmpty(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.Boiler.FlueType))
      {
        XGraphics xgraphics288 = PDFFunctions.gfx[DeveloperReport.k];
        // ISSUE: reference to a compiler-generated field
        string flueType = SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.Boiler.FlueType;
        XFont xfont296 = xfont2;
        XSolidBrush black281 = XBrushes.Black;
        double rc1_273 = (double) DeveloperReport.RC1;
        xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
        double point288 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
        double num353 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect288 = new XRect(200.0, rc1_273, point288, num353);
        XStringFormat topLeft288 = XStringFormat.TopLeft;
        xgraphics288.DrawString(flueType, xfont296, (XBrush) black281, xrect288, topLeft288);
        checked { DeveloperReport.RC1 += 12; }
        DeveloperReport.CheckRC1();
      }
      // ISSUE: reference to a compiler-generated field
      if (!string.IsNullOrEmpty(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.Boiler.BILock))
      {
        XGraphics xgraphics289 = PDFFunctions.gfx[DeveloperReport.k];
        // ISSUE: reference to a compiler-generated field
        string str144 = "Boiler interlock: " + SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.Boiler.BILock;
        XFont xfont297 = xfont2;
        XSolidBrush black282 = XBrushes.Black;
        double rc1_274 = (double) DeveloperReport.RC1;
        xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
        double point289 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
        double num354 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect289 = new XRect(200.0, rc1_274, point289, num354);
        XStringFormat topLeft289 = XStringFormat.TopLeft;
        xgraphics289.DrawString(str144, xfont297, (XBrush) black282, xrect289, topLeft289);
        checked { DeveloperReport.RC1 += 12; }
        DeveloperReport.CheckRC1();
      }
      try
      {
        // ISSUE: reference to a compiler-generated field
        if ((uint) Operators.CompareString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.Boiler.LoadWeatherType, "", false) > 0U)
        {
          XGraphics xgraphics290 = PDFFunctions.gfx[DeveloperReport.k];
          // ISSUE: reference to a compiler-generated field
          string loadWeatherType = SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.Boiler.LoadWeatherType;
          XFont xfont298 = xfont2;
          XSolidBrush black283 = XBrushes.Black;
          double rc1_275 = (double) DeveloperReport.RC1;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point290 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num355 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect290 = new XRect(200.0, rc1_275, point290, num355);
          XStringFormat topLeft290 = XStringFormat.TopLeft;
          xgraphics290.DrawString(loadWeatherType, xfont298, (XBrush) black283, xrect290, topLeft290);
          checked { DeveloperReport.RC1 += 14; }
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          if ((uint) Operators.CompareString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.Compensator, "", false) > 0U)
          {
            XGraphics xgraphics291 = PDFFunctions.gfx[DeveloperReport.k];
            // ISSUE: reference to a compiler-generated field
            string compensator = SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.Compensator;
            XFont xfont299 = xfont2;
            XSolidBrush black284 = XBrushes.Black;
            double rc1_276 = (double) DeveloperReport.RC1;
            xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
            double point291 = ((XUnit) ref xunit3).Point;
            xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
            double num356 = ((XUnit) ref xunit3).Point / 2.0;
            XRect xrect291 = new XRect(200.0, rc1_276, point291, num356);
            XStringFormat topLeft291 = XStringFormat.TopLeft;
            xgraphics291.DrawString(compensator, xfont299, (XBrush) black284, xrect291, topLeft291);
            checked { DeveloperReport.RC1 += 14; }
            DeveloperReport.CheckRC1();
          }
          else
          {
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            if (!string.IsNullOrEmpty(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.ControlCodePCDFWeather) & SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.Boiler.LoadWeather)
            {
              XGraphics xgraphics292 = PDFFunctions.gfx[DeveloperReport.k];
              XFont xfont300 = xfont2;
              XSolidBrush black285 = XBrushes.Black;
              double rc1_277 = (double) DeveloperReport.RC1;
              xunit3 = PDFFunctions.pages[DeveloperReport.k].Width;
              double point292 = ((XUnit) ref xunit3).Point;
              xunit3 = PDFFunctions.pages[DeveloperReport.k].Height;
              double num357 = ((XUnit) ref xunit3).Point / 2.0;
              XRect xrect292 = new XRect(200.0, rc1_277, point292, num357);
              XStringFormat topLeft292 = XStringFormat.TopLeft;
              xgraphics292.DrawString("Weather Compensator", xfont300, (XBrush) black285, xrect292, topLeft292);
              checked { DeveloperReport.RC1 += 14; }
              DeveloperReport.CheckRC1();
            }
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
        // ISSUE: reference to a compiler-generated field
        if (SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.Boiler.IncludeKeepHot)
        {
          XGraphics xgraphics293 = PDFFunctions.gfx[DeveloperReport.k];
          // ISSUE: reference to a compiler-generated field
          string str145 = "Keep hot Facility " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.Boiler.KeepHotTimed);
          XFont xfont301 = xfont2;
          XSolidBrush black286 = XBrushes.Black;
          double rc1_278 = (double) DeveloperReport.RC1;
          XUnit width8 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point293 = ((XUnit) ref width8).Point;
          XUnit height6 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num358 = ((XUnit) ref height6).Point / 2.0;
          XRect xrect293 = new XRect(200.0, rc1_278, point293, num358);
          XStringFormat topLeft293 = XStringFormat.TopLeft;
          xgraphics293.DrawString(str145, xfont301, (XBrush) black286, xrect293, topLeft293);
          checked { DeveloperReport.RC1 += 12; }
          XGraphics xgraphics294 = PDFFunctions.gfx[DeveloperReport.k];
          // ISSUE: reference to a compiler-generated field
          string str146 = "Keep hot Facility (Fuel used) " + SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.Boiler.KeepHotFuel;
          XFont xfont302 = xfont2;
          XSolidBrush black287 = XBrushes.Black;
          double rc1_279 = (double) DeveloperReport.RC1;
          XUnit width9 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point294 = ((XUnit) ref width9).Point;
          XUnit height7 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num359 = ((XUnit) ref height7).Point / 2.0;
          XRect xrect294 = new XRect(200.0, rc1_279, point294, num359);
          XStringFormat topLeft294 = XStringFormat.TopLeft;
          xgraphics294.DrawString(str146, xfont302, (XBrush) black287, xrect294, topLeft294);
          checked { DeveloperReport.RC1 += 14; }
          DeveloperReport.CheckRC1();
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      try
      {
        // ISSUE: reference to a compiler-generated field
        if (SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.DelayedStart)
        {
          XGraphics xgraphics295 = PDFFunctions.gfx[DeveloperReport.k];
          XFont xfont303 = xfont2;
          XSolidBrush black288 = XBrushes.Black;
          double rc1_280 = (double) DeveloperReport.RC1;
          XUnit width10 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point295 = ((XUnit) ref width10).Point;
          XUnit height8 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num360 = ((XUnit) ref height8).Point / 2.0;
          XRect xrect295 = new XRect(200.0, rc1_280, point295, num360);
          XStringFormat topLeft295 = XStringFormat.TopLeft;
          xgraphics295.DrawString("Delayed start ", xfont303, (XBrush) black288, xrect295, topLeft295);
          checked { DeveloperReport.RC1 += 14; }
          DeveloperReport.CheckRC1();
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      // ISSUE: reference to a compiler-generated field
      if (SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.MCSCert)
      {
        XGraphics xgraphics296 = PDFFunctions.gfx[DeveloperReport.k];
        XFont xfont304 = xfont2;
        XSolidBrush black289 = XBrushes.Black;
        double rc1_281 = (double) DeveloperReport.RC1;
        XUnit width11 = PDFFunctions.pages[DeveloperReport.k].Width;
        double point296 = ((XUnit) ref width11).Point;
        XUnit height9 = PDFFunctions.pages[DeveloperReport.k].Height;
        double num361 = ((XUnit) ref height9).Point / 2.0;
        XRect xrect296 = new XRect(200.0, rc1_281, point296, num361);
        XStringFormat topLeft296 = XStringFormat.TopLeft;
        xgraphics296.DrawString("MCS Installation Certificate", xfont304, (XBrush) black289, xrect296, topLeft296);
        checked { DeveloperReport.RC1 += 14; }
        DeveloperReport.CheckRC1();
      }
      DeveloperReport.CheckRC1();
      DeveloperReport.CreateBox();
      DeveloperReport.CheckRC1();
      PDFFunctions.xBrush1 = XBrush.op_Implicit((Brush) new SolidBrush(Color.FromArgb(159, 172, 62)));
      PDFFunctions.Points[0].X = 20f;
      PDFFunctions.Points[0].Y = (float) DeveloperReport.RC1;
      ref PointF local15 = ref PDFFunctions.Points[1];
      XUnit width12 = PDFFunctions.pages[DeveloperReport.k].Width;
      double num362 = ((XUnit) ref width12).Point - 20.0;
      local15.X = (float) num362;
      PDFFunctions.Points[1].Y = (float) DeveloperReport.RC1;
      ref PointF local16 = ref PDFFunctions.Points[2];
      XUnit width13 = PDFFunctions.pages[DeveloperReport.k].Width;
      double num363 = ((XUnit) ref width13).Point - 20.0;
      local16.X = (float) num363;
      PDFFunctions.Points[2].Y = (float) checked (DeveloperReport.RC1 + 16);
      PDFFunctions.Points[3].X = 20f;
      PDFFunctions.Points[3].Y = (float) checked (DeveloperReport.RC1 + 16);
      PDFFunctions.gfx[DeveloperReport.k].DrawPolygon(PDFFunctions.polyGreen2, PDFFunctions.xBrush1, PDFFunctions.Points, xfillMode);
      XGraphics xgraphics297 = PDFFunctions.gfx[DeveloperReport.k];
      XFont xfont305 = xfont3;
      XSolidBrush white8 = XBrushes.White;
      double num364 = (double) checked (DeveloperReport.RC1 + 1);
      XUnit width14 = PDFFunctions.pages[DeveloperReport.k].Width;
      double point297 = ((XUnit) ref width14).Point;
      XUnit height10 = PDFFunctions.pages[DeveloperReport.k].Height;
      double num365 = ((XUnit) ref height10).Point / 2.0;
      XRect xrect297 = new XRect(25.0, num364, point297, num365);
      XStringFormat topLeft297 = XStringFormat.TopLeft;
      xgraphics297.DrawString("Main heating Control:", xfont305, (XBrush) white8, xrect297, topLeft297);
      DeveloperReport.RC1 = checked ((int) Math.Round(unchecked ((double) PDFFunctions.Points[3].Y + 6.0)));
      DeveloperReport.CheckRC1();
      XGraphics xgraphics298 = PDFFunctions.gfx[DeveloperReport.k];
      XFont xfont306 = xfont2;
      XSolidBrush black290 = XBrushes.Black;
      double rc1_282 = (double) DeveloperReport.RC1;
      XUnit width15 = PDFFunctions.pages[DeveloperReport.k].Width;
      double point298 = ((XUnit) ref width15).Point;
      XUnit height11 = PDFFunctions.pages[DeveloperReport.k].Height;
      double num366 = ((XUnit) ref height11).Point / 2.0;
      XRect xrect298 = new XRect(20.0, rc1_282, point298, num366);
      XStringFormat topLeft298 = XStringFormat.TopLeft;
      xgraphics298.DrawString("Main heating Control: ", xfont306, (XBrush) black290, xrect298, topLeft298);
      checked { DeveloperReport.RC1 += 14; }
      try
      {
        // ISSUE: reference to a compiler-generated field
        string[] strArray = DeveloperReport.CheckTextWidth2(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.Controls, 230);
        if (strArray != null)
        {
          if (strArray[0].Length == 0)
          {
            // ISSUE: reference to a compiler-generated field
            strArray[0] = SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.Controls;
          }
          int num367 = checked (strArray.Length - 1);
          int index28 = 0;
          while (index28 <= num367)
          {
            if ((uint) Operators.CompareString(strArray[index28], "", false) > 0U)
            {
              XGraphics xgraphics299 = PDFFunctions.gfx[DeveloperReport.k];
              string str147 = strArray[index28];
              XFont xfont307 = xfont2;
              XSolidBrush black291 = XBrushes.Black;
              double rc1_283 = (double) DeveloperReport.RC1;
              XUnit width16 = PDFFunctions.pages[DeveloperReport.k].Width;
              double point299 = ((XUnit) ref width16).Point;
              XUnit height12 = PDFFunctions.pages[DeveloperReport.k].Height;
              double num368 = ((XUnit) ref height12).Point / 2.0;
              XRect xrect299 = new XRect(200.0, rc1_283, point299, num368);
              XStringFormat topLeft299 = XStringFormat.TopLeft;
              xgraphics299.DrawString(str147, xfont307, (XBrush) black291, xrect299, topLeft299);
              checked { DeveloperReport.RC1 += 12; }
              DeveloperReport.CheckRC1();
            }
            checked { ++index28; }
          }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      DeveloperReport.CheckRC1();
      DeveloperReport.CreateBox();
      DeveloperReport.CheckRC1();
      XUnit xunit5;
      // ISSUE: reference to a compiler-generated field
      if (SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].IncludeMainHeating2)
      {
        PDFFunctions.xBrush1 = XBrush.op_Implicit((Brush) new SolidBrush(Color.FromArgb(159, 172, 62)));
        PDFFunctions.Points[0].X = 20f;
        PDFFunctions.Points[0].Y = (float) DeveloperReport.RC1;
        ref PointF local17 = ref PDFFunctions.Points[1];
        XUnit xunit6 = PDFFunctions.pages[DeveloperReport.k].Width;
        double num369 = ((XUnit) ref xunit6).Point - 20.0;
        local17.X = (float) num369;
        PDFFunctions.Points[1].Y = (float) DeveloperReport.RC1;
        ref PointF local18 = ref PDFFunctions.Points[2];
        xunit6 = PDFFunctions.pages[DeveloperReport.k].Width;
        double num370 = ((XUnit) ref xunit6).Point - 20.0;
        local18.X = (float) num370;
        PDFFunctions.Points[2].Y = (float) checked (DeveloperReport.RC1 + 16);
        PDFFunctions.Points[3].X = 20f;
        PDFFunctions.Points[3].Y = (float) checked (DeveloperReport.RC1 + 16);
        PDFFunctions.gfx[DeveloperReport.k].DrawPolygon(PDFFunctions.polyGreen2, PDFFunctions.xBrush1, PDFFunctions.Points, xfillMode);
        XGraphics xgraphics300 = PDFFunctions.gfx[DeveloperReport.k];
        XFont xfont308 = xfont2;
        XSolidBrush white9 = XBrushes.White;
        double num371 = (double) checked (DeveloperReport.RC1 + 1);
        xunit6 = PDFFunctions.pages[DeveloperReport.k].Width;
        double point300 = ((XUnit) ref xunit6).Point;
        xunit6 = PDFFunctions.pages[DeveloperReport.k].Height;
        double num372 = ((XUnit) ref xunit6).Point / 2.0;
        XRect xrect300 = new XRect(25.0, num371, point300, num372);
        XStringFormat topLeft300 = XStringFormat.TopLeft;
        xgraphics300.DrawString("Secondary Main heating system:", xfont308, (XBrush) white9, xrect300, topLeft300);
        DeveloperReport.RC1 = checked ((int) Math.Round(unchecked ((double) PDFFunctions.Points[3].Y + 6.0)));
        DeveloperReport.CheckRC1();
        XGraphics xgraphics301 = PDFFunctions.gfx[DeveloperReport.k];
        XFont xfont309 = xfont2;
        XSolidBrush black292 = XBrushes.Black;
        double rc1_284 = (double) DeveloperReport.RC1;
        xunit6 = PDFFunctions.pages[DeveloperReport.k].Width;
        double point301 = ((XUnit) ref xunit6).Point;
        xunit6 = PDFFunctions.pages[DeveloperReport.k].Height;
        double num373 = ((XUnit) ref xunit6).Point / 2.0;
        XRect xrect301 = new XRect(20.0, rc1_284, point301, num373);
        XStringFormat topLeft301 = XStringFormat.TopLeft;
        xgraphics301.DrawString("Secondary Main heating system: ", xfont309, (XBrush) black292, xrect301, topLeft301);
        XGraphics xgraphics302 = PDFFunctions.gfx[DeveloperReport.k];
        // ISSUE: reference to a compiler-generated field
        string hgroup2 = SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.HGroup;
        XFont xfont310 = xfont2;
        XSolidBrush black293 = XBrushes.Black;
        double rc1_285 = (double) DeveloperReport.RC1;
        xunit6 = PDFFunctions.pages[DeveloperReport.k].Width;
        double point302 = ((XUnit) ref xunit6).Point;
        xunit6 = PDFFunctions.pages[DeveloperReport.k].Height;
        double num374 = ((XUnit) ref xunit6).Point / 2.0;
        XRect xrect302 = new XRect(200.0, rc1_285, point302, num374);
        XStringFormat topLeft302 = XStringFormat.TopLeft;
        xgraphics302.DrawString(hgroup2, xfont310, (XBrush) black293, xrect302, topLeft302);
        checked { DeveloperReport.RC1 += 12; }
        // ISSUE: reference to a compiler-generated field
        if ((uint) Operators.CompareString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.HGroup, "Community heating schemes", false) > 0U)
        {
          XGraphics xgraphics303 = PDFFunctions.gfx[DeveloperReport.k];
          // ISSUE: reference to a compiler-generated field
          string sgroup = SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.SGroup;
          XFont xfont311 = xfont2;
          XSolidBrush black294 = XBrushes.Black;
          double rc1_286 = (double) DeveloperReport.RC1;
          xunit6 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point303 = ((XUnit) ref xunit6).Point;
          xunit6 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num375 = ((XUnit) ref xunit6).Point / 2.0;
          XRect xrect303 = new XRect(200.0, rc1_286, point303, num375);
          XStringFormat topLeft303 = XStringFormat.TopLeft;
          xgraphics303.DrawString(sgroup, xfont311, (XBrush) black294, xrect303, topLeft303);
          checked { DeveloperReport.RC1 += 12; }
          XGraphics xgraphics304 = PDFFunctions.gfx[DeveloperReport.k];
          // ISSUE: reference to a compiler-generated field
          string str148 = "Fuel: " + SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.Fuel;
          XFont xfont312 = xfont2;
          XSolidBrush black295 = XBrushes.Black;
          double rc1_287 = (double) DeveloperReport.RC1;
          xunit6 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point304 = ((XUnit) ref xunit6).Point;
          xunit6 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num376 = ((XUnit) ref xunit6).Point / 2.0;
          XRect xrect304 = new XRect(200.0, rc1_287, point304, num376);
          XStringFormat topLeft304 = XStringFormat.TopLeft;
          xgraphics304.DrawString(str148, xfont312, (XBrush) black295, xrect304, topLeft304);
          checked { DeveloperReport.RC1 += 12; }
          XGraphics xgraphics305 = PDFFunctions.gfx[DeveloperReport.k];
          // ISSUE: reference to a compiler-generated field
          string str149 = "Info Source: " + SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.InforSource;
          XFont xfont313 = xfont2;
          XSolidBrush black296 = XBrushes.Black;
          double rc1_288 = (double) DeveloperReport.RC1;
          xunit6 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point305 = ((XUnit) ref xunit6).Point;
          xunit6 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num377 = ((XUnit) ref xunit6).Point / 2.0;
          XRect xrect305 = new XRect(200.0, rc1_288, point305, num377);
          XStringFormat topLeft305 = XStringFormat.TopLeft;
          xgraphics305.DrawString(str149, xfont313, (XBrush) black296, xrect305, topLeft305);
          checked { DeveloperReport.RC1 += 12; }
          DeveloperReport.CheckRC1();
          // ISSUE: reference to a compiler-generated field
          if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.InforSource, "Boiler Database", false) == 0)
          {
            string str150 = "";
            string str151 = "";
            string str152 = "";
            string str153 = "";
            string sapEff;
            string summerEff;
            string winterEff;
            // ISSUE: reference to a compiler-generated field
            if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.SGroup, "Gas boilers and oil boilers", false) == 0)
            {
              // ISSUE: reference to a compiler-generated method
              PCDF.SEDBUK sedbuk = SAP_Module.PCDFData.Boilers.Where<PCDF.SEDBUK>(new Func<PCDF.SEDBUK, bool>(closure140_2._Lambda\u0024__14)).SingleOrDefault<PCDF.SEDBUK>();
              if (sedbuk != null)
              {
                str150 = sedbuk.BrandName;
                str152 = sedbuk.ModelName;
                str151 = sedbuk.ModelQualifier;
                sapEff = sedbuk.SAPEff;
                summerEff = sedbuk.SummerEff;
                winterEff = sedbuk.WinterEff;
                double num378 = Conversion.Val(sedbuk.MainType);
                if (num378 == 0.0)
                  str153 = "Unknown";
                else if (num378 == 1.0)
                  str153 = "Regular";
                else if (num378 == 2.0)
                  str153 = "Combi";
                else if (num378 == 3.0)
                  str153 = "CPSU";
              }
            }
            else
            {
              // ISSUE: reference to a compiler-generated field
              if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.SGroup, "Micro-cogeneration (micro-CHP)", false) == 0)
              {
                // ISSUE: reference to a compiler-generated method
                PCDF.CHP chp = SAP_Module.PCDFData.CHPs.Where<PCDF.CHP>(new Func<PCDF.CHP, bool>(closure140_2._Lambda\u0024__15)).SingleOrDefault<PCDF.CHP>();
                if (chp != null)
                {
                  str150 = chp.Brand;
                  str152 = chp.Model;
                  str151 = chp.Qualifier;
                }
              }
              else
              {
                // ISSUE: reference to a compiler-generated field
                if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.SGroup, "Solid fuel boilers", false) == 0)
                {
                  // ISSUE: reference to a compiler-generated method
                  PCDF.SEDBUK_Solid sedbukSolid = SAP_Module.PCDFData.Solid_Boilers.Where<PCDF.SEDBUK_Solid>(new Func<PCDF.SEDBUK_Solid, bool>(closure140_2._Lambda\u0024__16)).SingleOrDefault<PCDF.SEDBUK_Solid>();
                  if (sedbukSolid != null)
                  {
                    str150 = sedbukSolid.BrandName;
                    str152 = sedbukSolid.ModelName;
                    str151 = sedbukSolid.ModelQualifier;
                    double num379 = Conversion.Val(sedbukSolid.MainType);
                    if (num379 == 0.0)
                      str153 = "Unknown";
                    else if (num379 == 1.0)
                      str153 = "Regular";
                    else if (num379 == 2.0)
                      str153 = "Combi";
                    else if (num379 == 3.0)
                      str153 = "CPSU";
                    sapEff = Conversions.ToString(Math.Round(SAP_Module.Calculation2012.Calculation.Energy_Requirements_9a.Box206));
                  }
                }
                else
                {
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.SGroup, "Gas-fired heat pumps", false) == 0 | Operators.CompareString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.SGroup, "Electric heat pumps", false) == 0)
                  {
                    // ISSUE: reference to a compiler-generated method
                    PCDF.HeatPump heatPump = SAP_Module.PCDFData.HeatPumps.Where<PCDF.HeatPump>(new Func<PCDF.HeatPump, bool>(closure140_2._Lambda\u0024__17)).SingleOrDefault<PCDF.HeatPump>();
                    if (heatPump != null)
                    {
                      str150 = heatPump.Brand;
                      str152 = heatPump.Model;
                      str151 = heatPump.Qualifier;
                      sapEff = Conversions.ToString(Math.Round(SAP_Module.Calculation2012.Calculation.Energy_Requirements_9a.Box206));
                    }
                  }
                }
              }
            }
            // ISSUE: reference to a compiler-generated field
            if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.SGroup, "Micro-cogeneration (micro-CHP)", false) == 0)
            {
              XGraphics xgraphics306 = PDFFunctions.gfx[DeveloperReport.k];
              // ISSUE: reference to a compiler-generated field
              string str154 = "Database: (rev " + Conversions.ToString(SAP_Module.DataBVersion) + ", product index " + SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.SEDBUK + "):";
              XFont xfont314 = xfont2;
              XSolidBrush black297 = XBrushes.Black;
              double rc1_289 = (double) DeveloperReport.RC1;
              xunit6 = PDFFunctions.pages[DeveloperReport.k].Width;
              double point306 = ((XUnit) ref xunit6).Point;
              xunit6 = PDFFunctions.pages[DeveloperReport.k].Height;
              double num380 = ((XUnit) ref xunit6).Point / 2.0;
              XRect xrect306 = new XRect(200.0, rc1_289, point306, num380);
              XStringFormat topLeft306 = XStringFormat.TopLeft;
              xgraphics306.DrawString(str154, xfont314, (XBrush) black297, xrect306, topLeft306);
            }
            else
            {
              // ISSUE: reference to a compiler-generated field
              if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.SGroup, "Gas boilers and oil boilers", false) == 0)
              {
                XGraphics xgraphics307 = PDFFunctions.gfx[DeveloperReport.k];
                // ISSUE: reference to a compiler-generated field
                string str155 = "Database: (rev " + Conversions.ToString(SAP_Module.DataBVersion) + ", product index " + SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.SEDBUK + ") Efficiency: Winter  " + summerEff + " %  Summer: " + winterEff;
                XFont xfont315 = xfont2;
                XSolidBrush black298 = XBrushes.Black;
                double rc1_290 = (double) DeveloperReport.RC1;
                xunit6 = PDFFunctions.pages[DeveloperReport.k].Width;
                double point307 = ((XUnit) ref xunit6).Point;
                xunit6 = PDFFunctions.pages[DeveloperReport.k].Height;
                double num381 = ((XUnit) ref xunit6).Point / 2.0;
                XRect xrect307 = new XRect(200.0, rc1_290, point307, num381);
                XStringFormat topLeft307 = XStringFormat.TopLeft;
                xgraphics307.DrawString(str155, xfont315, (XBrush) black298, xrect307, topLeft307);
              }
              else
              {
                XGraphics xgraphics308 = PDFFunctions.gfx[DeveloperReport.k];
                // ISSUE: reference to a compiler-generated field
                string str156 = "Database: (rev " + Conversions.ToString(SAP_Module.DataBVersion) + ", product index " + SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.SEDBUK + ", SEDBUK " + sapEff + "%):";
                XFont xfont316 = xfont2;
                XSolidBrush black299 = XBrushes.Black;
                double rc1_291 = (double) DeveloperReport.RC1;
                xunit6 = PDFFunctions.pages[DeveloperReport.k].Width;
                double point308 = ((XUnit) ref xunit6).Point;
                xunit6 = PDFFunctions.pages[DeveloperReport.k].Height;
                double num382 = ((XUnit) ref xunit6).Point / 2.0;
                XRect xrect308 = new XRect(200.0, rc1_291, point308, num382);
                XStringFormat topLeft308 = XStringFormat.TopLeft;
                xgraphics308.DrawString(str156, xfont316, (XBrush) black299, xrect308, topLeft308);
              }
            }
            checked { DeveloperReport.RC1 += 12; }
            XGraphics xgraphics309 = PDFFunctions.gfx[DeveloperReport.k];
            string str157 = "Band name: " + str150;
            XFont xfont317 = xfont2;
            XSolidBrush black300 = XBrushes.Black;
            double rc1_292 = (double) DeveloperReport.RC1;
            xunit6 = PDFFunctions.pages[DeveloperReport.k].Width;
            double point309 = ((XUnit) ref xunit6).Point;
            xunit6 = PDFFunctions.pages[DeveloperReport.k].Height;
            double num383 = ((XUnit) ref xunit6).Point / 2.0;
            XRect xrect309 = new XRect(200.0, rc1_292, point309, num383);
            XStringFormat topLeft309 = XStringFormat.TopLeft;
            xgraphics309.DrawString(str157, xfont317, (XBrush) black300, xrect309, topLeft309);
            checked { DeveloperReport.RC1 += 12; }
            XGraphics xgraphics310 = PDFFunctions.gfx[DeveloperReport.k];
            string str158 = "Model: " + str152;
            XFont xfont318 = xfont2;
            XSolidBrush black301 = XBrushes.Black;
            double rc1_293 = (double) DeveloperReport.RC1;
            xunit6 = PDFFunctions.pages[DeveloperReport.k].Width;
            double point310 = ((XUnit) ref xunit6).Point;
            xunit6 = PDFFunctions.pages[DeveloperReport.k].Height;
            double num384 = ((XUnit) ref xunit6).Point / 2.0;
            XRect xrect310 = new XRect(200.0, rc1_293, point310, num384);
            XStringFormat topLeft310 = XStringFormat.TopLeft;
            xgraphics310.DrawString(str158, xfont318, (XBrush) black301, xrect310, topLeft310);
            checked { DeveloperReport.RC1 += 12; }
            XGraphics xgraphics311 = PDFFunctions.gfx[DeveloperReport.k];
            string str159 = "Model qualifier: " + str151;
            XFont xfont319 = xfont2;
            XSolidBrush black302 = XBrushes.Black;
            double rc1_294 = (double) DeveloperReport.RC1;
            xunit6 = PDFFunctions.pages[DeveloperReport.k].Width;
            double point311 = ((XUnit) ref xunit6).Point;
            xunit6 = PDFFunctions.pages[DeveloperReport.k].Height;
            double num385 = ((XUnit) ref xunit6).Point / 2.0;
            XRect xrect311 = new XRect(200.0, rc1_294, point311, num385);
            XStringFormat topLeft311 = XStringFormat.TopLeft;
            xgraphics311.DrawString(str159, xfont319, (XBrush) black302, xrect311, topLeft311);
            checked { DeveloperReport.RC1 += 12; }
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.SGroup, "Micro-cogeneration (micro-CHP)", false) == 0 | Operators.CompareString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.SGroup, "Gas-fired heat pumps", false) == 0 | Operators.CompareString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.SGroup, "Electric heat pumps", false) == 0)
            {
              XGraphics xgraphics312 = PDFFunctions.gfx[DeveloperReport.k];
              XFont xfont320 = xfont2;
              XSolidBrush black303 = XBrushes.Black;
              double rc1_295 = (double) DeveloperReport.RC1;
              xunit6 = PDFFunctions.pages[DeveloperReport.k].Width;
              double point312 = ((XUnit) ref xunit6).Point;
              xunit6 = PDFFunctions.pages[DeveloperReport.k].Height;
              double num386 = ((XUnit) ref xunit6).Point / 2.0;
              XRect xrect312 = new XRect(200.0, rc1_295, point312, num386);
              XStringFormat topLeft312 = XStringFormat.TopLeft;
              xgraphics312.DrawString("(provides DHW all year)", xfont320, (XBrush) black303, xrect312, topLeft312);
            }
            else
            {
              XGraphics xgraphics313 = PDFFunctions.gfx[DeveloperReport.k];
              string str160 = "(" + str153 + " boiler)";
              XFont xfont321 = xfont2;
              XSolidBrush black304 = XBrushes.Black;
              double rc1_296 = (double) DeveloperReport.RC1;
              xunit6 = PDFFunctions.pages[DeveloperReport.k].Width;
              double point313 = ((XUnit) ref xunit6).Point;
              xunit6 = PDFFunctions.pages[DeveloperReport.k].Height;
              double num387 = ((XUnit) ref xunit6).Point / 2.0;
              XRect xrect313 = new XRect(200.0, rc1_296, point313, num387);
              XStringFormat topLeft313 = XStringFormat.TopLeft;
              xgraphics313.DrawString(str160, xfont321, (XBrush) black304, xrect313, topLeft313);
            }
          }
          else
          {
            // ISSUE: reference to a compiler-generated field
            if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.InforSource, "Manufacturer Declaration", false) == 0)
            {
              XGraphics xgraphics314 = PDFFunctions.gfx[DeveloperReport.k];
              XFont xfont322 = xfont2;
              XSolidBrush black305 = XBrushes.Black;
              double rc1_297 = (double) DeveloperReport.RC1;
              xunit6 = PDFFunctions.pages[DeveloperReport.k].Width;
              double point314 = ((XUnit) ref xunit6).Point;
              xunit6 = PDFFunctions.pages[DeveloperReport.k].Height;
              double num388 = ((XUnit) ref xunit6).Point / 2.0;
              XRect xrect314 = new XRect(200.0, rc1_297, point314, num388);
              XStringFormat topLeft314 = XStringFormat.TopLeft;
              xgraphics314.DrawString("Manufacturer's data", xfont322, (XBrush) black305, xrect314, topLeft314);
              checked { DeveloperReport.RC1 += 12; }
              // ISSUE: reference to a compiler-generated field
              if (SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.SAPTableCode < 142)
              {
                // ISSUE: reference to a compiler-generated field
                if (SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.SEDBUK2005)
                {
                  XGraphics xgraphics315 = PDFFunctions.gfx[DeveloperReport.k];
                  // ISSUE: reference to a compiler-generated field
                  string str161 = "Efficiency: " + Microsoft.VisualBasic.Strings.Format((object) SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.MainEff, "#0.0") + "% (SEDBUK2005)";
                  XFont xfont323 = xfont2;
                  XSolidBrush black306 = XBrushes.Black;
                  double rc1_298 = (double) DeveloperReport.RC1;
                  xunit6 = PDFFunctions.pages[DeveloperReport.k].Width;
                  double point315 = ((XUnit) ref xunit6).Point;
                  xunit6 = PDFFunctions.pages[DeveloperReport.k].Height;
                  double num389 = ((XUnit) ref xunit6).Point / 2.0;
                  XRect xrect315 = new XRect(200.0, rc1_298, point315, num389);
                  XStringFormat topLeft315 = XStringFormat.TopLeft;
                  xgraphics315.DrawString(str161, xfont323, (XBrush) black306, xrect315, topLeft315);
                }
                else
                {
                  XGraphics xgraphics316 = PDFFunctions.gfx[DeveloperReport.k];
                  // ISSUE: reference to a compiler-generated field
                  string str162 = "Efficiency: " + Microsoft.VisualBasic.Strings.Format((object) SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.MainEff, "#0.0") + "% (SEDBUK2009)";
                  XFont xfont324 = xfont2;
                  XSolidBrush black307 = XBrushes.Black;
                  double rc1_299 = (double) DeveloperReport.RC1;
                  xunit6 = PDFFunctions.pages[DeveloperReport.k].Width;
                  double point316 = ((XUnit) ref xunit6).Point;
                  xunit6 = PDFFunctions.pages[DeveloperReport.k].Height;
                  double num390 = ((XUnit) ref xunit6).Point / 2.0;
                  XRect xrect316 = new XRect(200.0, rc1_299, point316, num390);
                  XStringFormat topLeft316 = XStringFormat.TopLeft;
                  xgraphics316.DrawString(str162, xfont324, (XBrush) black307, xrect316, topLeft316);
                }
              }
              else
              {
                XGraphics xgraphics317 = PDFFunctions.gfx[DeveloperReport.k];
                // ISSUE: reference to a compiler-generated field
                string str163 = "Efficiency: " + Microsoft.VisualBasic.Strings.Format((object) SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.MainEff, "#0.0") + "%";
                XFont xfont325 = xfont2;
                XSolidBrush black308 = XBrushes.Black;
                double rc1_300 = (double) DeveloperReport.RC1;
                xunit6 = PDFFunctions.pages[DeveloperReport.k].Width;
                double point317 = ((XUnit) ref xunit6).Point;
                xunit6 = PDFFunctions.pages[DeveloperReport.k].Height;
                double num391 = ((XUnit) ref xunit6).Point / 2.0;
                XRect xrect317 = new XRect(200.0, rc1_300, point317, num391);
                XStringFormat topLeft317 = XStringFormat.TopLeft;
                xgraphics317.DrawString(str163, xfont325, (XBrush) black308, xrect317, topLeft317);
              }
              checked { DeveloperReport.RC1 += 12; }
              XGraphics xgraphics318 = PDFFunctions.gfx[DeveloperReport.k];
              // ISSUE: reference to a compiler-generated field
              string mhType = SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.MHType;
              XFont xfont326 = xfont2;
              XSolidBrush black309 = XBrushes.Black;
              double rc1_301 = (double) DeveloperReport.RC1;
              xunit6 = PDFFunctions.pages[DeveloperReport.k].Width;
              double point318 = ((XUnit) ref xunit6).Point;
              xunit6 = PDFFunctions.pages[DeveloperReport.k].Height;
              double num392 = ((XUnit) ref xunit6).Point / 2.0;
              XRect xrect318 = new XRect(200.0, rc1_301, point318, num392);
              XStringFormat topLeft318 = XStringFormat.TopLeft;
              xgraphics318.DrawString(mhType, xfont326, (XBrush) black309, xrect318, topLeft318);
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.Fuel, "mains gas", false) == 0 | SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.Fuel.Contains("LPG") && Operators.CompareString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.SGroup, "Gas boilers and oil boilers", false) == 0)
              {
                checked { DeveloperReport.RC1 += 12; }
                XGraphics xgraphics319 = PDFFunctions.gfx[DeveloperReport.k];
                // ISSUE: reference to a compiler-generated field
                string str164 = "Fuel Burning Type: " + SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.FuelBurningType;
                XFont xfont327 = xfont2;
                XSolidBrush black310 = XBrushes.Black;
                double rc1_302 = (double) DeveloperReport.RC1;
                xunit6 = PDFFunctions.pages[DeveloperReport.k].Width;
                double point319 = ((XUnit) ref xunit6).Point;
                xunit6 = PDFFunctions.pages[DeveloperReport.k].Height;
                double num393 = ((XUnit) ref xunit6).Point / 2.0;
                XRect xrect319 = new XRect(200.0, rc1_302, point319, num393);
                XStringFormat topLeft319 = XStringFormat.TopLeft;
                xgraphics319.DrawString(str164, xfont327, (XBrush) black310, xrect319, topLeft319);
              }
            }
            else
            {
              XGraphics xgraphics320 = PDFFunctions.gfx[DeveloperReport.k];
              // ISSUE: reference to a compiler-generated field
              string str165 = "SAP Table: " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.SAPTableCode);
              XFont xfont328 = xfont2;
              XSolidBrush black311 = XBrushes.Black;
              double rc1_303 = (double) DeveloperReport.RC1;
              xunit6 = PDFFunctions.pages[DeveloperReport.k].Width;
              double point320 = ((XUnit) ref xunit6).Point;
              xunit6 = PDFFunctions.pages[DeveloperReport.k].Height;
              double num394 = ((XUnit) ref xunit6).Point / 2.0;
              XRect xrect320 = new XRect(200.0, rc1_303, point320, num394);
              XStringFormat topLeft320 = XStringFormat.TopLeft;
              xgraphics320.DrawString(str165, xfont328, (XBrush) black311, xrect320, topLeft320);
              checked { DeveloperReport.RC1 += 12; }
              XGraphics xgraphics321 = PDFFunctions.gfx[DeveloperReport.k];
              // ISSUE: reference to a compiler-generated field
              string mhType = SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.MHType;
              XFont xfont329 = xfont2;
              XSolidBrush black312 = XBrushes.Black;
              double rc1_304 = (double) DeveloperReport.RC1;
              xunit6 = PDFFunctions.pages[DeveloperReport.k].Width;
              double point321 = ((XUnit) ref xunit6).Point;
              xunit6 = PDFFunctions.pages[DeveloperReport.k].Height;
              double num395 = ((XUnit) ref xunit6).Point / 2.0;
              XRect xrect321 = new XRect(200.0, rc1_304, point321, num395);
              XStringFormat topLeft321 = XStringFormat.TopLeft;
              xgraphics321.DrawString(mhType, xfont329, (XBrush) black312, xrect321, topLeft321);
            }
          }
          checked { DeveloperReport.RC1 += 12; }
          XGraphics xgraphics322 = PDFFunctions.gfx[DeveloperReport.k];
          // ISSUE: reference to a compiler-generated field
          string emitter = SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.Emitter;
          XFont xfont330 = xfont2;
          XSolidBrush black313 = XBrushes.Black;
          double rc1_305 = (double) DeveloperReport.RC1;
          xunit6 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point322 = ((XUnit) ref xunit6).Point;
          xunit6 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num396 = ((XUnit) ref xunit6).Point / 2.0;
          XRect xrect322 = new XRect(200.0, rc1_305, point322, num396);
          XStringFormat topLeft322 = XStringFormat.TopLeft;
          xgraphics322.DrawString(emitter, xfont330, (XBrush) black313, xrect322, topLeft322);
          DeveloperReport.CheckRC1();
          // ISSUE: reference to a compiler-generated field
          if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.HGroup, "Central heating systems with radiators or underfloor heating", false) == 0)
          {
            checked { DeveloperReport.RC1 += 12; }
            XGraphics xgraphics323 = PDFFunctions.gfx[DeveloperReport.k];
            // ISSUE: reference to a compiler-generated field
            string str166 = "Pump in heat space: " + SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.Boiler.PumpHP;
            XFont xfont331 = xfont2;
            XSolidBrush black314 = XBrushes.Black;
            double rc1_306 = (double) DeveloperReport.RC1;
            xunit6 = PDFFunctions.pages[DeveloperReport.k].Width;
            double point323 = ((XUnit) ref xunit6).Point;
            xunit6 = PDFFunctions.pages[DeveloperReport.k].Height;
            double num397 = ((XUnit) ref xunit6).Point / 2.0;
            XRect xrect323 = new XRect(200.0, rc1_306, point323, num397);
            XStringFormat topLeft323 = XStringFormat.TopLeft;
            xgraphics323.DrawString(str166, xfont331, (XBrush) black314, xrect323, topLeft323);
          }
        }
        else
        {
          List<PCDF.CommunityScheme_Sub> communitySchemeSubList = new List<PCDF.CommunityScheme_Sub>();
          // ISSUE: reference to a compiler-generated field
          if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.InforSource, "Boiler Database", false) == 0)
          {
            // ISSUE: reference to a compiler-generated field
            if ((uint) Operators.CompareString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.SEDBUK, "", false) > 0U)
            {
              // ISSUE: reference to a compiler-generated method
              communitySchemeSubList = SAP_Module.PCDFData.CommunitySchemes_Sub.Where<PCDF.CommunityScheme_Sub>(new Func<PCDF.CommunityScheme_Sub, bool>(closure140_2._Lambda\u0024__18)).ToList<PCDF.CommunityScheme_Sub>();
            }
            if (communitySchemeSubList.Count > 0)
            {
              XGraphics xgraphics324 = PDFFunctions.gfx[DeveloperReport.k];
              // ISSUE: reference to a compiler-generated field
              string str167 = "Database ( community network index " + SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.SEDBUK + "):";
              XFont xfont332 = xfont2;
              XSolidBrush black315 = XBrushes.Black;
              double rc1_307 = (double) DeveloperReport.RC1;
              xunit6 = PDFFunctions.pages[DeveloperReport.k].Width;
              double point324 = ((XUnit) ref xunit6).Point;
              xunit6 = PDFFunctions.pages[DeveloperReport.k].Height;
              double num398 = ((XUnit) ref xunit6).Point / 2.0;
              XRect xrect324 = new XRect(200.0, rc1_307, point324, num398);
              XStringFormat topLeft324 = XStringFormat.TopLeft;
              xgraphics324.DrawString(str167, xfont332, (XBrush) black315, xrect324, topLeft324);
              checked { DeveloperReport.RC1 += 12; }
              DeveloperReport.CheckRC1();
              // ISSUE: reference to a compiler-generated method
              PCDF.CommunityScheme communityScheme = SAP_Module.PCDFData.CommunitySchemes.Where<PCDF.CommunityScheme>(new Func<PCDF.CommunityScheme, bool>(closure140_2._Lambda\u0024__19)).SingleOrDefault<PCDF.CommunityScheme>();
              if (communityScheme != null)
              {
                XGraphics xgraphics325 = PDFFunctions.gfx[DeveloperReport.k];
                string str168 = "Brand name: " + communityScheme.CommunityHeatNetwork;
                XFont xfont333 = xfont2;
                XSolidBrush black316 = XBrushes.Black;
                double rc1_308 = (double) DeveloperReport.RC1;
                xunit6 = PDFFunctions.pages[DeveloperReport.k].Width;
                double point325 = ((XUnit) ref xunit6).Point;
                xunit6 = PDFFunctions.pages[DeveloperReport.k].Height;
                double num399 = ((XUnit) ref xunit6).Point / 2.0;
                XRect xrect325 = new XRect(200.0, rc1_308, point325, num399);
                XStringFormat topLeft325 = XStringFormat.TopLeft;
                xgraphics325.DrawString(str168, xfont333, (XBrush) black316, xrect325, topLeft325);
                checked { DeveloperReport.RC1 += 12; }
                XGraphics xgraphics326 = PDFFunctions.gfx[DeveloperReport.k];
                string str169 = "Postcode: " + communityScheme.PostcodeEnergyCentre;
                XFont xfont334 = xfont2;
                XSolidBrush black317 = XBrushes.Black;
                double rc1_309 = (double) DeveloperReport.RC1;
                xunit6 = PDFFunctions.pages[DeveloperReport.k].Width;
                double point326 = ((XUnit) ref xunit6).Point;
                xunit6 = PDFFunctions.pages[DeveloperReport.k].Height;
                double num400 = ((XUnit) ref xunit6).Point / 2.0;
                XRect xrect326 = new XRect(200.0, rc1_309, point326, num400);
                XStringFormat topLeft326 = XStringFormat.TopLeft;
                xgraphics326.DrawString(str169, xfont334, (XBrush) black317, xrect326, topLeft326);
                checked { DeveloperReport.RC1 += 12; }
                XGraphics xgraphics327 = PDFFunctions.gfx[DeveloperReport.k];
                string str170 = "Network Version: " + communityScheme.HeatNetworkVersion;
                XFont xfont335 = xfont2;
                XSolidBrush black318 = XBrushes.Black;
                double rc1_310 = (double) DeveloperReport.RC1;
                xunit6 = PDFFunctions.pages[DeveloperReport.k].Width;
                double point327 = ((XUnit) ref xunit6).Point;
                xunit6 = PDFFunctions.pages[DeveloperReport.k].Height;
                double num401 = ((XUnit) ref xunit6).Point / 2.0;
                XRect xrect327 = new XRect(200.0, rc1_310, point327, num401);
                XStringFormat topLeft327 = XStringFormat.TopLeft;
                xgraphics327.DrawString(str170, xfont335, (XBrush) black318, xrect327, topLeft327);
                checked { DeveloperReport.RC1 += 12; }
                string serviceProvision = communityScheme.ServiceProvision;
                string str171 = Operators.CompareString(serviceProvision, Conversions.ToString(3), false) != 0 ? (Operators.CompareString(serviceProvision, Conversions.ToString(1), false) != 0 ? (Operators.CompareString(serviceProvision, Conversions.ToString(4), false) != 0 ? communityScheme.ServiceProvision : "water heating only") : "space and water heating") : "space only";
                XGraphics xgraphics328 = PDFFunctions.gfx[DeveloperReport.k];
                string str172 = "Service provision: " + str171;
                XFont xfont336 = xfont2;
                XSolidBrush black319 = XBrushes.Black;
                double rc1_311 = (double) DeveloperReport.RC1;
                xunit6 = PDFFunctions.pages[DeveloperReport.k].Width;
                double point328 = ((XUnit) ref xunit6).Point;
                xunit6 = PDFFunctions.pages[DeveloperReport.k].Height;
                double num402 = ((XUnit) ref xunit6).Point / 2.0;
                XRect xrect328 = new XRect(200.0, rc1_311, point328, num402);
                XStringFormat topLeft328 = XStringFormat.TopLeft;
                xgraphics328.DrawString(str172, xfont336, (XBrush) black319, xrect328, topLeft328);
                checked { DeveloperReport.RC1 += 12; }
                if (Operators.CompareString(communityScheme.DataType, Conversions.ToString(1), false) == 0)
                {
                  XGraphics xgraphics329 = PDFFunctions.gfx[DeveloperReport.k];
                  string str173 = "Provisional (estimated) data: " + str171;
                  XFont xfont337 = xfont2;
                  XSolidBrush black320 = XBrushes.Black;
                  double rc1_312 = (double) DeveloperReport.RC1;
                  xunit6 = PDFFunctions.pages[DeveloperReport.k].Width;
                  double point329 = ((XUnit) ref xunit6).Point;
                  xunit6 = PDFFunctions.pages[DeveloperReport.k].Height;
                  double num403 = ((XUnit) ref xunit6).Point / 2.0;
                  XRect xrect329 = new XRect(200.0, rc1_312, point329, num403);
                  XStringFormat topLeft329 = XStringFormat.TopLeft;
                  xgraphics329.DrawString(str173, xfont337, (XBrush) black320, xrect329, topLeft329);
                }
                else
                {
                  XGraphics xgraphics330 = PDFFunctions.gfx[DeveloperReport.k];
                  XFont xfont338 = xfont2;
                  XSolidBrush black321 = XBrushes.Black;
                  double rc1_313 = (double) DeveloperReport.RC1;
                  xunit6 = PDFFunctions.pages[DeveloperReport.k].Width;
                  double point330 = ((XUnit) ref xunit6).Point;
                  xunit6 = PDFFunctions.pages[DeveloperReport.k].Height;
                  double num404 = ((XUnit) ref xunit6).Point / 2.0;
                  XRect xrect330 = new XRect(200.0, rc1_313, point330, num404);
                  XStringFormat topLeft330 = XStringFormat.TopLeft;
                  xgraphics330.DrawString("Actual data", xfont338, (XBrush) black321, xrect330, topLeft330);
                }
                checked { DeveloperReport.RC1 += 12; }
              }
              // ISSUE: reference to a compiler-generated field
              switch (SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.CommunityH.HeatSource1.Type)
              {
                case 306:
                  XGraphics xgraphics331 = PDFFunctions.gfx[DeveloperReport.k];
                  // ISSUE: reference to a compiler-generated field
                  string str174 = "Heat source : Community boilers " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.CommunityH.HeatSource1.Type);
                  XFont xfont339 = xfont2;
                  XSolidBrush black322 = XBrushes.Black;
                  double rc1_314 = (double) DeveloperReport.RC1;
                  xunit6 = PDFFunctions.pages[DeveloperReport.k].Width;
                  double point331 = ((XUnit) ref xunit6).Point;
                  xunit6 = PDFFunctions.pages[DeveloperReport.k].Height;
                  double num405 = ((XUnit) ref xunit6).Point / 2.0;
                  XRect xrect331 = new XRect(180.0, rc1_314, point331, num405);
                  XStringFormat topLeft331 = XStringFormat.TopLeft;
                  xgraphics331.DrawString(str174, xfont339, (XBrush) black322, xrect331, topLeft331);
                  break;
                case 307:
                  XGraphics xgraphics332 = PDFFunctions.gfx[DeveloperReport.k];
                  XFont xfont340 = xfont2;
                  XSolidBrush black323 = XBrushes.Black;
                  double rc1_315 = (double) DeveloperReport.RC1;
                  xunit6 = PDFFunctions.pages[DeveloperReport.k].Width;
                  double point332 = ((XUnit) ref xunit6).Point;
                  xunit6 = PDFFunctions.pages[DeveloperReport.k].Height;
                  double num406 = ((XUnit) ref xunit6).Point / 2.0;
                  XRect xrect332 = new XRect(180.0, rc1_315, point332, num406);
                  XStringFormat topLeft332 = XStringFormat.TopLeft;
                  xgraphics332.DrawString("Heat source : Community CHP", xfont340, (XBrush) black323, xrect332, topLeft332);
                  break;
                case 308:
                  XGraphics xgraphics333 = PDFFunctions.gfx[DeveloperReport.k];
                  XFont xfont341 = xfont2;
                  XSolidBrush black324 = XBrushes.Black;
                  double rc1_316 = (double) DeveloperReport.RC1;
                  xunit6 = PDFFunctions.pages[DeveloperReport.k].Width;
                  double point333 = ((XUnit) ref xunit6).Point;
                  xunit6 = PDFFunctions.pages[DeveloperReport.k].Height;
                  double num407 = ((XUnit) ref xunit6).Point / 2.0;
                  XRect xrect333 = new XRect(180.0, rc1_316, point333, num407);
                  XStringFormat topLeft333 = XStringFormat.TopLeft;
                  xgraphics333.DrawString("Heat source : Community heat pump", xfont341, (XBrush) black324, xrect333, topLeft333);
                  break;
                case 309:
                  XGraphics xgraphics334 = PDFFunctions.gfx[DeveloperReport.k];
                  XFont xfont342 = xfont2;
                  XSolidBrush black325 = XBrushes.Black;
                  double rc1_317 = (double) DeveloperReport.RC1;
                  xunit6 = PDFFunctions.pages[DeveloperReport.k].Width;
                  double point334 = ((XUnit) ref xunit6).Point;
                  xunit6 = PDFFunctions.pages[DeveloperReport.k].Height;
                  double num408 = ((XUnit) ref xunit6).Point / 2.0;
                  XRect xrect334 = new XRect(180.0, rc1_317, point334, num408);
                  XStringFormat topLeft334 = XStringFormat.TopLeft;
                  xgraphics334.DrawString("Heat source : Community waste heat from power station", xfont342, (XBrush) black325, xrect334, topLeft334);
                  break;
                case 310:
                  XGraphics xgraphics335 = PDFFunctions.gfx[DeveloperReport.k];
                  XFont xfont343 = xfont2;
                  XSolidBrush black326 = XBrushes.Black;
                  double rc1_318 = (double) DeveloperReport.RC1;
                  xunit6 = PDFFunctions.pages[DeveloperReport.k].Width;
                  double point335 = ((XUnit) ref xunit6).Point;
                  xunit6 = PDFFunctions.pages[DeveloperReport.k].Height;
                  double num409 = ((XUnit) ref xunit6).Point / 2.0;
                  XRect xrect335 = new XRect(180.0, rc1_318, point335, num409);
                  XStringFormat topLeft335 = XStringFormat.TopLeft;
                  xgraphics335.DrawString("Heat source : Community geothermal heat", xfont343, (XBrush) black326, xrect335, topLeft335);
                  break;
              }
              checked { DeveloperReport.RC1 += 20; }
              if (communitySchemeSubList[0].CommunityFuel.Equals("99"))
              {
                XGraphics xgraphics336 = PDFFunctions.gfx[DeveloperReport.k];
                XFont xfont344 = xfont2;
                XSolidBrush black327 = XBrushes.Black;
                double rc1_319 = (double) DeveloperReport.RC1;
                xunit6 = PDFFunctions.pages[DeveloperReport.k].Width;
                double point336 = ((XUnit) ref xunit6).Point;
                xunit6 = PDFFunctions.pages[DeveloperReport.k].Height;
                double num410 = ((XUnit) ref xunit6).Point / 2.0;
                XRect xrect336 = new XRect(200.0, rc1_319, point336, num410);
                XStringFormat topLeft336 = XStringFormat.TopLeft;
                xgraphics336.DrawString("Fuel : biomethane", xfont344, (XBrush) black327, xrect336, topLeft336);
              }
              else
              {
                XGraphics xgraphics337 = PDFFunctions.gfx[DeveloperReport.k];
                // ISSUE: reference to a compiler-generated field
                string str175 = "Fuel : " + SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.Fuel;
                XFont xfont345 = xfont2;
                XSolidBrush black328 = XBrushes.Black;
                double rc1_320 = (double) DeveloperReport.RC1;
                xunit6 = PDFFunctions.pages[DeveloperReport.k].Width;
                double point337 = ((XUnit) ref xunit6).Point;
                xunit6 = PDFFunctions.pages[DeveloperReport.k].Height;
                double num411 = ((XUnit) ref xunit6).Point / 2.0;
                XRect xrect337 = new XRect(200.0, rc1_320, point337, num411);
                XStringFormat topLeft337 = XStringFormat.TopLeft;
                xgraphics337.DrawString(str175, xfont345, (XBrush) black328, xrect337, topLeft337);
              }
            }
            else
            {
              XGraphics xgraphics338 = PDFFunctions.gfx[DeveloperReport.k];
              // ISSUE: reference to a compiler-generated field
              string str176 = "Fuel : " + SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.Fuel;
              XFont xfont346 = xfont2;
              XSolidBrush black329 = XBrushes.Black;
              double rc1_321 = (double) DeveloperReport.RC1;
              xunit6 = PDFFunctions.pages[DeveloperReport.k].Width;
              double point338 = ((XUnit) ref xunit6).Point;
              xunit6 = PDFFunctions.pages[DeveloperReport.k].Height;
              double num412 = ((XUnit) ref xunit6).Point / 2.0;
              XRect xrect338 = new XRect(200.0, rc1_321, point338, num412);
              XStringFormat topLeft338 = XStringFormat.TopLeft;
              xgraphics338.DrawString(str176, xfont346, (XBrush) black329, xrect338, topLeft338);
            }
            checked { DeveloperReport.RC1 += 12; }
            DeveloperReport.CheckRC1();
            XGraphics xgraphics339 = PDFFunctions.gfx[DeveloperReport.k];
            // ISSUE: reference to a compiler-generated field
            string str177 = "Heat Fraction : " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.CommunityH.Boiler1HeatFraction);
            XFont xfont347 = xfont2;
            XSolidBrush black330 = XBrushes.Black;
            double rc1_322 = (double) DeveloperReport.RC1;
            xunit6 = PDFFunctions.pages[DeveloperReport.k].Width;
            double point339 = ((XUnit) ref xunit6).Point;
            xunit6 = PDFFunctions.pages[DeveloperReport.k].Height;
            double num413 = ((XUnit) ref xunit6).Point / 2.0;
            XRect xrect339 = new XRect(200.0, rc1_322, point339, num413);
            XStringFormat topLeft339 = XStringFormat.TopLeft;
            xgraphics339.DrawString(str177, xfont347, (XBrush) black330, xrect339, topLeft339);
            checked { DeveloperReport.RC1 += 12; }
            DeveloperReport.CheckRC1();
            XGraphics xgraphics340 = PDFFunctions.gfx[DeveloperReport.k];
            // ISSUE: reference to a compiler-generated field
            string str178 = "Heat Efficiency : " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.CommunityH.Boiler1Efficiency);
            XFont xfont348 = xfont2;
            XSolidBrush black331 = XBrushes.Black;
            double rc1_323 = (double) DeveloperReport.RC1;
            xunit6 = PDFFunctions.pages[DeveloperReport.k].Width;
            double point340 = ((XUnit) ref xunit6).Point;
            xunit6 = PDFFunctions.pages[DeveloperReport.k].Height;
            double num414 = ((XUnit) ref xunit6).Point / 2.0;
            XRect xrect340 = new XRect(200.0, rc1_323, point340, num414);
            XStringFormat topLeft340 = XStringFormat.TopLeft;
            xgraphics340.DrawString(str178, xfont348, (XBrush) black331, xrect340, topLeft340);
            checked { DeveloperReport.RC1 += 12; }
            DeveloperReport.CheckRC1();
            // ISSUE: reference to a compiler-generated field
            if ((double) SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.CommunityH.HeatToPowerRatio > 0.0)
            {
              XGraphics xgraphics341 = PDFFunctions.gfx[DeveloperReport.k];
              // ISSUE: reference to a compiler-generated field
              string str179 = "Power-Efficiency : " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.CommunityH.HeatToPowerRatio);
              XFont xfont349 = xfont2;
              XSolidBrush black332 = XBrushes.Black;
              double rc1_324 = (double) DeveloperReport.RC1;
              xunit6 = PDFFunctions.pages[DeveloperReport.k].Width;
              double point341 = ((XUnit) ref xunit6).Point;
              xunit6 = PDFFunctions.pages[DeveloperReport.k].Height;
              double num415 = ((XUnit) ref xunit6).Point / 2.0;
              XRect xrect341 = new XRect(200.0, rc1_324, point341, num415);
              XStringFormat topLeft341 = XStringFormat.TopLeft;
              xgraphics341.DrawString(str179, xfont349, (XBrush) black332, xrect341, topLeft341);
            }
            checked { DeveloperReport.RC1 += 12; }
            DeveloperReport.CheckRC1();
            if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.CommunityH.NoOfAdditionalHeatSources > 0)
            {
              // ISSUE: reference to a compiler-generated field
              switch (SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.CommunityH.HeatSource1.Type)
              {
                case 306:
                  XGraphics xgraphics342 = PDFFunctions.gfx[DeveloperReport.k];
                  XFont xfont350 = xfont2;
                  XSolidBrush black333 = XBrushes.Black;
                  double rc1_325 = (double) DeveloperReport.RC1;
                  xunit6 = PDFFunctions.pages[DeveloperReport.k].Width;
                  double point342 = ((XUnit) ref xunit6).Point;
                  xunit6 = PDFFunctions.pages[DeveloperReport.k].Height;
                  double num416 = ((XUnit) ref xunit6).Point / 2.0;
                  XRect xrect342 = new XRect(180.0, rc1_325, point342, num416);
                  XStringFormat topLeft342 = XStringFormat.TopLeft;
                  xgraphics342.DrawString("Heat source : Community boilers ", xfont350, (XBrush) black333, xrect342, topLeft342);
                  break;
                case 307:
                  XGraphics xgraphics343 = PDFFunctions.gfx[DeveloperReport.k];
                  XFont xfont351 = xfont2;
                  XSolidBrush black334 = XBrushes.Black;
                  double rc1_326 = (double) DeveloperReport.RC1;
                  xunit6 = PDFFunctions.pages[DeveloperReport.k].Width;
                  double point343 = ((XUnit) ref xunit6).Point;
                  xunit6 = PDFFunctions.pages[DeveloperReport.k].Height;
                  double num417 = ((XUnit) ref xunit6).Point / 2.0;
                  XRect xrect343 = new XRect(180.0, rc1_326, point343, num417);
                  XStringFormat topLeft343 = XStringFormat.TopLeft;
                  xgraphics343.DrawString("Heat source : Community CHP", xfont351, (XBrush) black334, xrect343, topLeft343);
                  break;
                case 308:
                  XGraphics xgraphics344 = PDFFunctions.gfx[DeveloperReport.k];
                  XFont xfont352 = xfont2;
                  XSolidBrush black335 = XBrushes.Black;
                  double rc1_327 = (double) DeveloperReport.RC1;
                  xunit6 = PDFFunctions.pages[DeveloperReport.k].Width;
                  double point344 = ((XUnit) ref xunit6).Point;
                  xunit6 = PDFFunctions.pages[DeveloperReport.k].Height;
                  double num418 = ((XUnit) ref xunit6).Point / 2.0;
                  XRect xrect344 = new XRect(180.0, rc1_327, point344, num418);
                  XStringFormat topLeft344 = XStringFormat.TopLeft;
                  xgraphics344.DrawString("Heat source : Community heat pump", xfont352, (XBrush) black335, xrect344, topLeft344);
                  break;
                case 309:
                  XGraphics xgraphics345 = PDFFunctions.gfx[DeveloperReport.k];
                  XFont xfont353 = xfont2;
                  XSolidBrush black336 = XBrushes.Black;
                  double rc1_328 = (double) DeveloperReport.RC1;
                  xunit6 = PDFFunctions.pages[DeveloperReport.k].Width;
                  double point345 = ((XUnit) ref xunit6).Point;
                  xunit6 = PDFFunctions.pages[DeveloperReport.k].Height;
                  double num419 = ((XUnit) ref xunit6).Point / 2.0;
                  XRect xrect345 = new XRect(180.0, rc1_328, point345, num419);
                  XStringFormat topLeft345 = XStringFormat.TopLeft;
                  xgraphics345.DrawString("Heat source : Community waste heat from power station", xfont353, (XBrush) black336, xrect345, topLeft345);
                  break;
                case 310:
                  XGraphics xgraphics346 = PDFFunctions.gfx[DeveloperReport.k];
                  XFont xfont354 = xfont2;
                  XSolidBrush black337 = XBrushes.Black;
                  double rc1_329 = (double) DeveloperReport.RC1;
                  xunit6 = PDFFunctions.pages[DeveloperReport.k].Width;
                  double point346 = ((XUnit) ref xunit6).Point;
                  xunit6 = PDFFunctions.pages[DeveloperReport.k].Height;
                  double num420 = ((XUnit) ref xunit6).Point / 2.0;
                  XRect xrect346 = new XRect(180.0, rc1_329, point346, num420);
                  XStringFormat topLeft346 = XStringFormat.TopLeft;
                  xgraphics346.DrawString("Heat source : Community geothermal heat", xfont354, (XBrush) black337, xrect346, topLeft346);
                  break;
              }
              checked { DeveloperReport.RC1 += 20; }
              DeveloperReport.CheckRC1();
              if (communitySchemeSubList.Count > 0)
              {
                if (communitySchemeSubList[1].CommunityFuel.Equals("99"))
                {
                  XGraphics xgraphics347 = PDFFunctions.gfx[DeveloperReport.k];
                  XFont xfont355 = xfont2;
                  XSolidBrush black338 = XBrushes.Black;
                  double rc1_330 = (double) DeveloperReport.RC1;
                  xunit6 = PDFFunctions.pages[DeveloperReport.k].Width;
                  double point347 = ((XUnit) ref xunit6).Point;
                  xunit6 = PDFFunctions.pages[DeveloperReport.k].Height;
                  double num421 = ((XUnit) ref xunit6).Point / 2.0;
                  XRect xrect347 = new XRect(200.0, rc1_330, point347, num421);
                  XStringFormat topLeft347 = XStringFormat.TopLeft;
                  xgraphics347.DrawString("Fuel : biomethane", xfont355, (XBrush) black338, xrect347, topLeft347);
                }
                else
                {
                  XGraphics xgraphics348 = PDFFunctions.gfx[DeveloperReport.k];
                  // ISSUE: reference to a compiler-generated field
                  string str180 = "Fuel : " + SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.CommunityH.HeatSource1.Fuel;
                  XFont xfont356 = xfont2;
                  XSolidBrush black339 = XBrushes.Black;
                  double rc1_331 = (double) DeveloperReport.RC1;
                  xunit6 = PDFFunctions.pages[DeveloperReport.k].Width;
                  double point348 = ((XUnit) ref xunit6).Point;
                  xunit6 = PDFFunctions.pages[DeveloperReport.k].Height;
                  double num422 = ((XUnit) ref xunit6).Point / 2.0;
                  XRect xrect348 = new XRect(200.0, rc1_331, point348, num422);
                  XStringFormat topLeft348 = XStringFormat.TopLeft;
                  xgraphics348.DrawString(str180, xfont356, (XBrush) black339, xrect348, topLeft348);
                }
              }
              else
              {
                XGraphics xgraphics349 = PDFFunctions.gfx[DeveloperReport.k];
                // ISSUE: reference to a compiler-generated field
                string str181 = "Fuel : " + SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.CommunityH.HeatSource1.Fuel;
                XFont xfont357 = xfont2;
                XSolidBrush black340 = XBrushes.Black;
                double rc1_332 = (double) DeveloperReport.RC1;
                xunit6 = PDFFunctions.pages[DeveloperReport.k].Width;
                double point349 = ((XUnit) ref xunit6).Point;
                xunit6 = PDFFunctions.pages[DeveloperReport.k].Height;
                double num423 = ((XUnit) ref xunit6).Point / 2.0;
                XRect xrect349 = new XRect(200.0, rc1_332, point349, num423);
                XStringFormat topLeft349 = XStringFormat.TopLeft;
                xgraphics349.DrawString(str181, xfont357, (XBrush) black340, xrect349, topLeft349);
              }
              checked { DeveloperReport.RC1 += 12; }
              DeveloperReport.CheckRC1();
              XGraphics xgraphics350 = PDFFunctions.gfx[DeveloperReport.k];
              // ISSUE: reference to a compiler-generated field
              string str182 = "Heat Fraction : " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.CommunityH.HeatSource1.HeatFraction);
              XFont xfont358 = xfont2;
              XSolidBrush black341 = XBrushes.Black;
              double rc1_333 = (double) DeveloperReport.RC1;
              xunit6 = PDFFunctions.pages[DeveloperReport.k].Width;
              double point350 = ((XUnit) ref xunit6).Point;
              xunit6 = PDFFunctions.pages[DeveloperReport.k].Height;
              double num424 = ((XUnit) ref xunit6).Point / 2.0;
              XRect xrect350 = new XRect(200.0, rc1_333, point350, num424);
              XStringFormat topLeft350 = XStringFormat.TopLeft;
              xgraphics350.DrawString(str182, xfont358, (XBrush) black341, xrect350, topLeft350);
              checked { DeveloperReport.RC1 += 12; }
              DeveloperReport.CheckRC1();
              XGraphics xgraphics351 = PDFFunctions.gfx[DeveloperReport.k];
              // ISSUE: reference to a compiler-generated field
              string str183 = "Heat Efficiency : " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.CommunityH.HeatSource1.Efficiency);
              XFont xfont359 = xfont2;
              XSolidBrush black342 = XBrushes.Black;
              double rc1_334 = (double) DeveloperReport.RC1;
              xunit6 = PDFFunctions.pages[DeveloperReport.k].Width;
              double point351 = ((XUnit) ref xunit6).Point;
              xunit6 = PDFFunctions.pages[DeveloperReport.k].Height;
              double num425 = ((XUnit) ref xunit6).Point / 2.0;
              XRect xrect351 = new XRect(200.0, rc1_334, point351, num425);
              XStringFormat topLeft351 = XStringFormat.TopLeft;
              xgraphics351.DrawString(str183, xfont359, (XBrush) black342, xrect351, topLeft351);
              checked { DeveloperReport.RC1 += 12; }
              DeveloperReport.CheckRC1();
            }
            if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.CommunityH.NoOfAdditionalHeatSources > 1)
            {
              // ISSUE: reference to a compiler-generated field
              switch (SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.CommunityH.HeatSource2.Type)
              {
                case 306:
                  XGraphics xgraphics352 = PDFFunctions.gfx[DeveloperReport.k];
                  XFont xfont360 = xfont2;
                  XSolidBrush black343 = XBrushes.Black;
                  double rc1_335 = (double) DeveloperReport.RC1;
                  xunit6 = PDFFunctions.pages[DeveloperReport.k].Width;
                  double point352 = ((XUnit) ref xunit6).Point;
                  xunit6 = PDFFunctions.pages[DeveloperReport.k].Height;
                  double num426 = ((XUnit) ref xunit6).Point / 2.0;
                  XRect xrect352 = new XRect(180.0, rc1_335, point352, num426);
                  XStringFormat topLeft352 = XStringFormat.TopLeft;
                  xgraphics352.DrawString("Heat source : Community boilers ", xfont360, (XBrush) black343, xrect352, topLeft352);
                  break;
                case 307:
                  XGraphics xgraphics353 = PDFFunctions.gfx[DeveloperReport.k];
                  XFont xfont361 = xfont2;
                  XSolidBrush black344 = XBrushes.Black;
                  double rc1_336 = (double) DeveloperReport.RC1;
                  xunit6 = PDFFunctions.pages[DeveloperReport.k].Width;
                  double point353 = ((XUnit) ref xunit6).Point;
                  xunit6 = PDFFunctions.pages[DeveloperReport.k].Height;
                  double num427 = ((XUnit) ref xunit6).Point / 2.0;
                  XRect xrect353 = new XRect(180.0, rc1_336, point353, num427);
                  XStringFormat topLeft353 = XStringFormat.TopLeft;
                  xgraphics353.DrawString("Heat source : Community CHP", xfont361, (XBrush) black344, xrect353, topLeft353);
                  break;
                case 308:
                  XGraphics xgraphics354 = PDFFunctions.gfx[DeveloperReport.k];
                  XFont xfont362 = xfont2;
                  XSolidBrush black345 = XBrushes.Black;
                  double rc1_337 = (double) DeveloperReport.RC1;
                  xunit6 = PDFFunctions.pages[DeveloperReport.k].Width;
                  double point354 = ((XUnit) ref xunit6).Point;
                  xunit6 = PDFFunctions.pages[DeveloperReport.k].Height;
                  double num428 = ((XUnit) ref xunit6).Point / 2.0;
                  XRect xrect354 = new XRect(180.0, rc1_337, point354, num428);
                  XStringFormat topLeft354 = XStringFormat.TopLeft;
                  xgraphics354.DrawString("Heat source : Community heat pump", xfont362, (XBrush) black345, xrect354, topLeft354);
                  break;
                case 309:
                  XGraphics xgraphics355 = PDFFunctions.gfx[DeveloperReport.k];
                  XFont xfont363 = xfont2;
                  XSolidBrush black346 = XBrushes.Black;
                  double rc1_338 = (double) DeveloperReport.RC1;
                  xunit6 = PDFFunctions.pages[DeveloperReport.k].Width;
                  double point355 = ((XUnit) ref xunit6).Point;
                  xunit6 = PDFFunctions.pages[DeveloperReport.k].Height;
                  double num429 = ((XUnit) ref xunit6).Point / 2.0;
                  XRect xrect355 = new XRect(180.0, rc1_338, point355, num429);
                  XStringFormat topLeft355 = XStringFormat.TopLeft;
                  xgraphics355.DrawString("Heat source : Community waste heat from power station", xfont363, (XBrush) black346, xrect355, topLeft355);
                  break;
                case 310:
                  XGraphics xgraphics356 = PDFFunctions.gfx[DeveloperReport.k];
                  XFont xfont364 = xfont2;
                  XSolidBrush black347 = XBrushes.Black;
                  double rc1_339 = (double) DeveloperReport.RC1;
                  xunit6 = PDFFunctions.pages[DeveloperReport.k].Width;
                  double point356 = ((XUnit) ref xunit6).Point;
                  xunit6 = PDFFunctions.pages[DeveloperReport.k].Height;
                  double num430 = ((XUnit) ref xunit6).Point / 2.0;
                  XRect xrect356 = new XRect(180.0, rc1_339, point356, num430);
                  XStringFormat topLeft356 = XStringFormat.TopLeft;
                  xgraphics356.DrawString("Heat source : Community geothermal heat", xfont364, (XBrush) black347, xrect356, topLeft356);
                  break;
              }
              checked { DeveloperReport.RC1 += 20; }
              DeveloperReport.CheckRC1();
              if (communitySchemeSubList.Count > 0)
              {
                if (communitySchemeSubList[2].CommunityFuel.Equals("99"))
                {
                  XGraphics xgraphics357 = PDFFunctions.gfx[DeveloperReport.k];
                  XFont xfont365 = xfont2;
                  XSolidBrush black348 = XBrushes.Black;
                  double rc1_340 = (double) DeveloperReport.RC1;
                  xunit6 = PDFFunctions.pages[DeveloperReport.k].Width;
                  double point357 = ((XUnit) ref xunit6).Point;
                  xunit6 = PDFFunctions.pages[DeveloperReport.k].Height;
                  double num431 = ((XUnit) ref xunit6).Point / 2.0;
                  XRect xrect357 = new XRect(200.0, rc1_340, point357, num431);
                  XStringFormat topLeft357 = XStringFormat.TopLeft;
                  xgraphics357.DrawString("Fuel : biomethane", xfont365, (XBrush) black348, xrect357, topLeft357);
                }
                else
                {
                  XGraphics xgraphics358 = PDFFunctions.gfx[DeveloperReport.k];
                  // ISSUE: reference to a compiler-generated field
                  string str184 = "Fuel : " + SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.CommunityH.HeatSource2.Fuel;
                  XFont xfont366 = xfont2;
                  XSolidBrush black349 = XBrushes.Black;
                  double rc1_341 = (double) DeveloperReport.RC1;
                  xunit6 = PDFFunctions.pages[DeveloperReport.k].Width;
                  double point358 = ((XUnit) ref xunit6).Point;
                  xunit6 = PDFFunctions.pages[DeveloperReport.k].Height;
                  double num432 = ((XUnit) ref xunit6).Point / 2.0;
                  XRect xrect358 = new XRect(200.0, rc1_341, point358, num432);
                  XStringFormat topLeft358 = XStringFormat.TopLeft;
                  xgraphics358.DrawString(str184, xfont366, (XBrush) black349, xrect358, topLeft358);
                }
              }
              else
              {
                XGraphics xgraphics359 = PDFFunctions.gfx[DeveloperReport.k];
                // ISSUE: reference to a compiler-generated field
                string str185 = "Fuel : " + SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.CommunityH.HeatSource2.Fuel;
                XFont xfont367 = xfont2;
                XSolidBrush black350 = XBrushes.Black;
                double rc1_342 = (double) DeveloperReport.RC1;
                xunit6 = PDFFunctions.pages[DeveloperReport.k].Width;
                double point359 = ((XUnit) ref xunit6).Point;
                xunit6 = PDFFunctions.pages[DeveloperReport.k].Height;
                double num433 = ((XUnit) ref xunit6).Point / 2.0;
                XRect xrect359 = new XRect(200.0, rc1_342, point359, num433);
                XStringFormat topLeft359 = XStringFormat.TopLeft;
                xgraphics359.DrawString(str185, xfont367, (XBrush) black350, xrect359, topLeft359);
              }
              checked { DeveloperReport.RC1 += 12; }
              DeveloperReport.CheckRC1();
              XGraphics xgraphics360 = PDFFunctions.gfx[DeveloperReport.k];
              // ISSUE: reference to a compiler-generated field
              string str186 = "Heat Fraction : " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.CommunityH.HeatSource2.HeatFraction);
              XFont xfont368 = xfont2;
              XSolidBrush black351 = XBrushes.Black;
              double rc1_343 = (double) DeveloperReport.RC1;
              xunit6 = PDFFunctions.pages[DeveloperReport.k].Width;
              double point360 = ((XUnit) ref xunit6).Point;
              xunit6 = PDFFunctions.pages[DeveloperReport.k].Height;
              double num434 = ((XUnit) ref xunit6).Point / 2.0;
              XRect xrect360 = new XRect(200.0, rc1_343, point360, num434);
              XStringFormat topLeft360 = XStringFormat.TopLeft;
              xgraphics360.DrawString(str186, xfont368, (XBrush) black351, xrect360, topLeft360);
              checked { DeveloperReport.RC1 += 12; }
              DeveloperReport.CheckRC1();
              XGraphics xgraphics361 = PDFFunctions.gfx[DeveloperReport.k];
              // ISSUE: reference to a compiler-generated field
              string str187 = "Heat Efficiency : " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.CommunityH.HeatSource2.Efficiency);
              XFont xfont369 = xfont2;
              XSolidBrush black352 = XBrushes.Black;
              double rc1_344 = (double) DeveloperReport.RC1;
              xunit6 = PDFFunctions.pages[DeveloperReport.k].Width;
              double point361 = ((XUnit) ref xunit6).Point;
              xunit6 = PDFFunctions.pages[DeveloperReport.k].Height;
              double num435 = ((XUnit) ref xunit6).Point / 2.0;
              XRect xrect361 = new XRect(200.0, rc1_344, point361, num435);
              XStringFormat topLeft361 = XStringFormat.TopLeft;
              xgraphics361.DrawString(str187, xfont369, (XBrush) black352, xrect361, topLeft361);
              checked { DeveloperReport.RC1 += 12; }
              DeveloperReport.CheckRC1();
            }
            // ISSUE: reference to a compiler-generated field
            if (SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.CommunityH.NoOfAdditionalHeatSources > 2)
            {
              // ISSUE: reference to a compiler-generated field
              switch (SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.CommunityH.HeatSource3.Type)
              {
                case 306:
                  XGraphics xgraphics362 = PDFFunctions.gfx[DeveloperReport.k];
                  XFont xfont370 = xfont2;
                  XSolidBrush black353 = XBrushes.Black;
                  double rc1_345 = (double) DeveloperReport.RC1;
                  xunit6 = PDFFunctions.pages[DeveloperReport.k].Width;
                  double point362 = ((XUnit) ref xunit6).Point;
                  xunit6 = PDFFunctions.pages[DeveloperReport.k].Height;
                  double num436 = ((XUnit) ref xunit6).Point / 2.0;
                  XRect xrect362 = new XRect(180.0, rc1_345, point362, num436);
                  XStringFormat topLeft362 = XStringFormat.TopLeft;
                  xgraphics362.DrawString("Heat source : Community boilers ", xfont370, (XBrush) black353, xrect362, topLeft362);
                  break;
                case 307:
                  XGraphics xgraphics363 = PDFFunctions.gfx[DeveloperReport.k];
                  XFont xfont371 = xfont2;
                  XSolidBrush black354 = XBrushes.Black;
                  double rc1_346 = (double) DeveloperReport.RC1;
                  xunit6 = PDFFunctions.pages[DeveloperReport.k].Width;
                  double point363 = ((XUnit) ref xunit6).Point;
                  xunit6 = PDFFunctions.pages[DeveloperReport.k].Height;
                  double num437 = ((XUnit) ref xunit6).Point / 2.0;
                  XRect xrect363 = new XRect(180.0, rc1_346, point363, num437);
                  XStringFormat topLeft363 = XStringFormat.TopLeft;
                  xgraphics363.DrawString("Heat source : Community CHP", xfont371, (XBrush) black354, xrect363, topLeft363);
                  break;
                case 308:
                  XGraphics xgraphics364 = PDFFunctions.gfx[DeveloperReport.k];
                  XFont xfont372 = xfont2;
                  XSolidBrush black355 = XBrushes.Black;
                  double rc1_347 = (double) DeveloperReport.RC1;
                  xunit6 = PDFFunctions.pages[DeveloperReport.k].Width;
                  double point364 = ((XUnit) ref xunit6).Point;
                  xunit6 = PDFFunctions.pages[DeveloperReport.k].Height;
                  double num438 = ((XUnit) ref xunit6).Point / 2.0;
                  XRect xrect364 = new XRect(180.0, rc1_347, point364, num438);
                  XStringFormat topLeft364 = XStringFormat.TopLeft;
                  xgraphics364.DrawString("Heat source : Community heat pump", xfont372, (XBrush) black355, xrect364, topLeft364);
                  break;
                case 309:
                  XGraphics xgraphics365 = PDFFunctions.gfx[DeveloperReport.k];
                  XFont xfont373 = xfont2;
                  XSolidBrush black356 = XBrushes.Black;
                  double rc1_348 = (double) DeveloperReport.RC1;
                  xunit6 = PDFFunctions.pages[DeveloperReport.k].Width;
                  double point365 = ((XUnit) ref xunit6).Point;
                  xunit6 = PDFFunctions.pages[DeveloperReport.k].Height;
                  double num439 = ((XUnit) ref xunit6).Point / 2.0;
                  XRect xrect365 = new XRect(180.0, rc1_348, point365, num439);
                  XStringFormat topLeft365 = XStringFormat.TopLeft;
                  xgraphics365.DrawString("Heat source : Community waste heat from power station", xfont373, (XBrush) black356, xrect365, topLeft365);
                  break;
                case 310:
                  XGraphics xgraphics366 = PDFFunctions.gfx[DeveloperReport.k];
                  XFont xfont374 = xfont2;
                  XSolidBrush black357 = XBrushes.Black;
                  double rc1_349 = (double) DeveloperReport.RC1;
                  xunit6 = PDFFunctions.pages[DeveloperReport.k].Width;
                  double point366 = ((XUnit) ref xunit6).Point;
                  xunit6 = PDFFunctions.pages[DeveloperReport.k].Height;
                  double num440 = ((XUnit) ref xunit6).Point / 2.0;
                  XRect xrect366 = new XRect(180.0, rc1_349, point366, num440);
                  XStringFormat topLeft366 = XStringFormat.TopLeft;
                  xgraphics366.DrawString("Heat source : Community geothermal heat", xfont374, (XBrush) black357, xrect366, topLeft366);
                  break;
              }
              checked { DeveloperReport.RC1 += 20; }
              DeveloperReport.CheckRC1();
              DeveloperReport.CheckRC1();
              if (communitySchemeSubList.Count > 0)
              {
                if (communitySchemeSubList[3].CommunityFuel.Equals("99"))
                {
                  XGraphics xgraphics367 = PDFFunctions.gfx[DeveloperReport.k];
                  XFont xfont375 = xfont2;
                  XSolidBrush black358 = XBrushes.Black;
                  double rc1_350 = (double) DeveloperReport.RC1;
                  xunit6 = PDFFunctions.pages[DeveloperReport.k].Width;
                  double point367 = ((XUnit) ref xunit6).Point;
                  xunit6 = PDFFunctions.pages[DeveloperReport.k].Height;
                  double num441 = ((XUnit) ref xunit6).Point / 2.0;
                  XRect xrect367 = new XRect(200.0, rc1_350, point367, num441);
                  XStringFormat topLeft367 = XStringFormat.TopLeft;
                  xgraphics367.DrawString("Fuel : biomethane", xfont375, (XBrush) black358, xrect367, topLeft367);
                }
                else
                {
                  XGraphics xgraphics368 = PDFFunctions.gfx[DeveloperReport.k];
                  // ISSUE: reference to a compiler-generated field
                  string str188 = "Fuel : " + SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.CommunityH.HeatSource3.Fuel;
                  XFont xfont376 = xfont2;
                  XSolidBrush black359 = XBrushes.Black;
                  double rc1_351 = (double) DeveloperReport.RC1;
                  xunit6 = PDFFunctions.pages[DeveloperReport.k].Width;
                  double point368 = ((XUnit) ref xunit6).Point;
                  xunit6 = PDFFunctions.pages[DeveloperReport.k].Height;
                  double num442 = ((XUnit) ref xunit6).Point / 2.0;
                  XRect xrect368 = new XRect(200.0, rc1_351, point368, num442);
                  XStringFormat topLeft368 = XStringFormat.TopLeft;
                  xgraphics368.DrawString(str188, xfont376, (XBrush) black359, xrect368, topLeft368);
                }
              }
              else
              {
                XGraphics xgraphics369 = PDFFunctions.gfx[DeveloperReport.k];
                // ISSUE: reference to a compiler-generated field
                string str189 = "Fuel : " + SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.CommunityH.HeatSource3.Fuel;
                XFont xfont377 = xfont2;
                XSolidBrush black360 = XBrushes.Black;
                double rc1_352 = (double) DeveloperReport.RC1;
                xunit6 = PDFFunctions.pages[DeveloperReport.k].Width;
                double point369 = ((XUnit) ref xunit6).Point;
                xunit6 = PDFFunctions.pages[DeveloperReport.k].Height;
                double num443 = ((XUnit) ref xunit6).Point / 2.0;
                XRect xrect369 = new XRect(200.0, rc1_352, point369, num443);
                XStringFormat topLeft369 = XStringFormat.TopLeft;
                xgraphics369.DrawString(str189, xfont377, (XBrush) black360, xrect369, topLeft369);
              }
              checked { DeveloperReport.RC1 += 12; }
              DeveloperReport.CheckRC1();
              XGraphics xgraphics370 = PDFFunctions.gfx[DeveloperReport.k];
              // ISSUE: reference to a compiler-generated field
              string str190 = "Heat Fraction : " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.CommunityH.HeatSource3.HeatFraction);
              XFont xfont378 = xfont2;
              XSolidBrush black361 = XBrushes.Black;
              double rc1_353 = (double) DeveloperReport.RC1;
              xunit6 = PDFFunctions.pages[DeveloperReport.k].Width;
              double point370 = ((XUnit) ref xunit6).Point;
              xunit6 = PDFFunctions.pages[DeveloperReport.k].Height;
              double num444 = ((XUnit) ref xunit6).Point / 2.0;
              XRect xrect370 = new XRect(200.0, rc1_353, point370, num444);
              XStringFormat topLeft370 = XStringFormat.TopLeft;
              xgraphics370.DrawString(str190, xfont378, (XBrush) black361, xrect370, topLeft370);
              checked { DeveloperReport.RC1 += 12; }
              DeveloperReport.CheckRC1();
              XGraphics xgraphics371 = PDFFunctions.gfx[DeveloperReport.k];
              // ISSUE: reference to a compiler-generated field
              string str191 = "Heat Efficiency : " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.CommunityH.HeatSource3.Efficiency);
              XFont xfont379 = xfont2;
              XSolidBrush black362 = XBrushes.Black;
              double rc1_354 = (double) DeveloperReport.RC1;
              xunit6 = PDFFunctions.pages[DeveloperReport.k].Width;
              double point371 = ((XUnit) ref xunit6).Point;
              xunit6 = PDFFunctions.pages[DeveloperReport.k].Height;
              double num445 = ((XUnit) ref xunit6).Point / 2.0;
              XRect xrect371 = new XRect(200.0, rc1_354, point371, num445);
              XStringFormat topLeft371 = XStringFormat.TopLeft;
              xgraphics371.DrawString(str191, xfont379, (XBrush) black362, xrect371, topLeft371);
              checked { DeveloperReport.RC1 += 12; }
              DeveloperReport.CheckRC1();
            }
            if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.CommunityH.NoOfAdditionalHeatSources > 3)
            {
              // ISSUE: reference to a compiler-generated field
              switch (SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.CommunityH.HeatSource4.Type)
              {
                case 306:
                  XGraphics xgraphics372 = PDFFunctions.gfx[DeveloperReport.k];
                  XFont xfont380 = xfont2;
                  XSolidBrush black363 = XBrushes.Black;
                  double rc1_355 = (double) DeveloperReport.RC1;
                  xunit6 = PDFFunctions.pages[DeveloperReport.k].Width;
                  double point372 = ((XUnit) ref xunit6).Point;
                  xunit6 = PDFFunctions.pages[DeveloperReport.k].Height;
                  double num446 = ((XUnit) ref xunit6).Point / 2.0;
                  XRect xrect372 = new XRect(180.0, rc1_355, point372, num446);
                  XStringFormat topLeft372 = XStringFormat.TopLeft;
                  xgraphics372.DrawString("Heat source : Community boilers ", xfont380, (XBrush) black363, xrect372, topLeft372);
                  break;
                case 307:
                  XGraphics xgraphics373 = PDFFunctions.gfx[DeveloperReport.k];
                  XFont xfont381 = xfont2;
                  XSolidBrush black364 = XBrushes.Black;
                  double rc1_356 = (double) DeveloperReport.RC1;
                  xunit6 = PDFFunctions.pages[DeveloperReport.k].Width;
                  double point373 = ((XUnit) ref xunit6).Point;
                  xunit6 = PDFFunctions.pages[DeveloperReport.k].Height;
                  double num447 = ((XUnit) ref xunit6).Point / 2.0;
                  XRect xrect373 = new XRect(180.0, rc1_356, point373, num447);
                  XStringFormat topLeft373 = XStringFormat.TopLeft;
                  xgraphics373.DrawString("Heat source : Community CHP", xfont381, (XBrush) black364, xrect373, topLeft373);
                  break;
                case 308:
                  XGraphics xgraphics374 = PDFFunctions.gfx[DeveloperReport.k];
                  XFont xfont382 = xfont2;
                  XSolidBrush black365 = XBrushes.Black;
                  double rc1_357 = (double) DeveloperReport.RC1;
                  xunit6 = PDFFunctions.pages[DeveloperReport.k].Width;
                  double point374 = ((XUnit) ref xunit6).Point;
                  xunit6 = PDFFunctions.pages[DeveloperReport.k].Height;
                  double num448 = ((XUnit) ref xunit6).Point / 2.0;
                  XRect xrect374 = new XRect(180.0, rc1_357, point374, num448);
                  XStringFormat topLeft374 = XStringFormat.TopLeft;
                  xgraphics374.DrawString("Heat source : Community heat pump", xfont382, (XBrush) black365, xrect374, topLeft374);
                  break;
                case 309:
                  XGraphics xgraphics375 = PDFFunctions.gfx[DeveloperReport.k];
                  XFont xfont383 = xfont2;
                  XSolidBrush black366 = XBrushes.Black;
                  double rc1_358 = (double) DeveloperReport.RC1;
                  xunit6 = PDFFunctions.pages[DeveloperReport.k].Width;
                  double point375 = ((XUnit) ref xunit6).Point;
                  xunit6 = PDFFunctions.pages[DeveloperReport.k].Height;
                  double num449 = ((XUnit) ref xunit6).Point / 2.0;
                  XRect xrect375 = new XRect(180.0, rc1_358, point375, num449);
                  XStringFormat topLeft375 = XStringFormat.TopLeft;
                  xgraphics375.DrawString("Heat source : Community waste heat from power station", xfont383, (XBrush) black366, xrect375, topLeft375);
                  break;
                case 310:
                  XGraphics xgraphics376 = PDFFunctions.gfx[DeveloperReport.k];
                  XFont xfont384 = xfont2;
                  XSolidBrush black367 = XBrushes.Black;
                  double rc1_359 = (double) DeveloperReport.RC1;
                  xunit6 = PDFFunctions.pages[DeveloperReport.k].Width;
                  double point376 = ((XUnit) ref xunit6).Point;
                  xunit6 = PDFFunctions.pages[DeveloperReport.k].Height;
                  double num450 = ((XUnit) ref xunit6).Point / 2.0;
                  XRect xrect376 = new XRect(180.0, rc1_359, point376, num450);
                  XStringFormat topLeft376 = XStringFormat.TopLeft;
                  xgraphics376.DrawString("Heat source : Community geothermal heat", xfont384, (XBrush) black367, xrect376, topLeft376);
                  break;
              }
              checked { DeveloperReport.RC1 += 20; }
              DeveloperReport.CheckRC1();
              if (communitySchemeSubList.Count > 0)
              {
                if (communitySchemeSubList[4].CommunityFuel.Equals("99"))
                {
                  XGraphics xgraphics377 = PDFFunctions.gfx[DeveloperReport.k];
                  XFont xfont385 = xfont2;
                  XSolidBrush black368 = XBrushes.Black;
                  double rc1_360 = (double) DeveloperReport.RC1;
                  xunit6 = PDFFunctions.pages[DeveloperReport.k].Width;
                  double point377 = ((XUnit) ref xunit6).Point;
                  xunit6 = PDFFunctions.pages[DeveloperReport.k].Height;
                  double num451 = ((XUnit) ref xunit6).Point / 2.0;
                  XRect xrect377 = new XRect(200.0, rc1_360, point377, num451);
                  XStringFormat topLeft377 = XStringFormat.TopLeft;
                  xgraphics377.DrawString("Fuel : biomethane", xfont385, (XBrush) black368, xrect377, topLeft377);
                }
                else
                {
                  XGraphics xgraphics378 = PDFFunctions.gfx[DeveloperReport.k];
                  // ISSUE: reference to a compiler-generated field
                  string str192 = "Fuel : " + SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.CommunityH.HeatSource4.Fuel;
                  XFont xfont386 = xfont2;
                  XSolidBrush black369 = XBrushes.Black;
                  double rc1_361 = (double) DeveloperReport.RC1;
                  xunit6 = PDFFunctions.pages[DeveloperReport.k].Width;
                  double point378 = ((XUnit) ref xunit6).Point;
                  xunit6 = PDFFunctions.pages[DeveloperReport.k].Height;
                  double num452 = ((XUnit) ref xunit6).Point / 2.0;
                  XRect xrect378 = new XRect(200.0, rc1_361, point378, num452);
                  XStringFormat topLeft378 = XStringFormat.TopLeft;
                  xgraphics378.DrawString(str192, xfont386, (XBrush) black369, xrect378, topLeft378);
                }
              }
              else
              {
                XGraphics xgraphics379 = PDFFunctions.gfx[DeveloperReport.k];
                // ISSUE: reference to a compiler-generated field
                string str193 = "Fuel : " + SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.CommunityH.HeatSource4.Fuel;
                XFont xfont387 = xfont2;
                XSolidBrush black370 = XBrushes.Black;
                double rc1_362 = (double) DeveloperReport.RC1;
                xunit6 = PDFFunctions.pages[DeveloperReport.k].Width;
                double point379 = ((XUnit) ref xunit6).Point;
                xunit6 = PDFFunctions.pages[DeveloperReport.k].Height;
                double num453 = ((XUnit) ref xunit6).Point / 2.0;
                XRect xrect379 = new XRect(200.0, rc1_362, point379, num453);
                XStringFormat topLeft379 = XStringFormat.TopLeft;
                xgraphics379.DrawString(str193, xfont387, (XBrush) black370, xrect379, topLeft379);
              }
              checked { DeveloperReport.RC1 += 12; }
              DeveloperReport.CheckRC1();
              XGraphics xgraphics380 = PDFFunctions.gfx[DeveloperReport.k];
              // ISSUE: reference to a compiler-generated field
              string str194 = "Heat Fraction : " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.CommunityH.HeatSource4.HeatFraction);
              XFont xfont388 = xfont2;
              XSolidBrush black371 = XBrushes.Black;
              double rc1_363 = (double) DeveloperReport.RC1;
              xunit6 = PDFFunctions.pages[DeveloperReport.k].Width;
              double point380 = ((XUnit) ref xunit6).Point;
              xunit6 = PDFFunctions.pages[DeveloperReport.k].Height;
              double num454 = ((XUnit) ref xunit6).Point / 2.0;
              XRect xrect380 = new XRect(200.0, rc1_363, point380, num454);
              XStringFormat topLeft380 = XStringFormat.TopLeft;
              xgraphics380.DrawString(str194, xfont388, (XBrush) black371, xrect380, topLeft380);
              checked { DeveloperReport.RC1 += 12; }
              DeveloperReport.CheckRC1();
              XGraphics xgraphics381 = PDFFunctions.gfx[DeveloperReport.k];
              // ISSUE: reference to a compiler-generated field
              string str195 = "Heat Efficiency : " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.CommunityH.HeatSource4.Efficiency);
              XFont xfont389 = xfont2;
              XSolidBrush black372 = XBrushes.Black;
              double rc1_364 = (double) DeveloperReport.RC1;
              xunit6 = PDFFunctions.pages[DeveloperReport.k].Width;
              double point381 = ((XUnit) ref xunit6).Point;
              xunit6 = PDFFunctions.pages[DeveloperReport.k].Height;
              double num455 = ((XUnit) ref xunit6).Point / 2.0;
              XRect xrect381 = new XRect(200.0, rc1_364, point381, num455);
              XStringFormat topLeft381 = XStringFormat.TopLeft;
              xgraphics381.DrawString(str195, xfont389, (XBrush) black372, xrect381, topLeft381);
              checked { DeveloperReport.RC1 += 12; }
              DeveloperReport.CheckRC1();
            }
          }
          else
          {
            XGraphics xgraphics382 = PDFFunctions.gfx[DeveloperReport.k];
            // ISSUE: reference to a compiler-generated field
            string str196 = "Heat source: " + SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.MHType;
            XFont xfont390 = xfont2;
            XSolidBrush black373 = XBrushes.Black;
            double rc1_365 = (double) DeveloperReport.RC1;
            xunit6 = PDFFunctions.pages[DeveloperReport.k].Width;
            double point382 = ((XUnit) ref xunit6).Point;
            xunit6 = PDFFunctions.pages[DeveloperReport.k].Height;
            double num456 = ((XUnit) ref xunit6).Point / 2.0;
            XRect xrect382 = new XRect(200.0, rc1_365, point382, num456);
            XStringFormat topLeft382 = XStringFormat.TopLeft;
            xgraphics382.DrawString(str196, xfont390, (XBrush) black373, xrect382, topLeft382);
            checked { DeveloperReport.RC1 += 12; }
            DeveloperReport.CheckRC1();
            XGraphics xgraphics383 = PDFFunctions.gfx[DeveloperReport.k];
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            string str197 = SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.Fuel + ", heat fraction " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.CommunityH.Boiler1HeatFraction) + ", efficiency " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.CommunityH.Boiler1Efficiency);
            XFont xfont391 = xfont2;
            XSolidBrush black374 = XBrushes.Black;
            double rc1_366 = (double) DeveloperReport.RC1;
            xunit6 = PDFFunctions.pages[DeveloperReport.k].Width;
            double point383 = ((XUnit) ref xunit6).Point;
            xunit6 = PDFFunctions.pages[DeveloperReport.k].Height;
            double num457 = ((XUnit) ref xunit6).Point / 2.0;
            XRect xrect383 = new XRect(205.0, rc1_366, point383, num457);
            XStringFormat topLeft383 = XStringFormat.TopLeft;
            xgraphics383.DrawString(str197, xfont391, (XBrush) black374, xrect383, topLeft383);
            // ISSUE: reference to a compiler-generated field
            if (SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.CommunityH.NoOfAdditionalHeatSources > 0)
            {
              // ISSUE: reference to a compiler-generated method
              PCDF.Table4a_B table4aB = SAP_Module.PCDFData.Table4a_bs.Where<PCDF.Table4a_B>(new Func<PCDF.Table4a_B, bool>(closure140_2._Lambda\u0024__20)).SingleOrDefault<PCDF.Table4a_B>();
              checked { DeveloperReport.RC1 += 12; }
              DeveloperReport.CheckRC1();
              XGraphics xgraphics384 = PDFFunctions.gfx[DeveloperReport.k];
              string str198 = "Heat source: " + table4aB.Description;
              XFont xfont392 = xfont2;
              XSolidBrush black375 = XBrushes.Black;
              double rc1_367 = (double) DeveloperReport.RC1;
              xunit6 = PDFFunctions.pages[DeveloperReport.k].Width;
              double point384 = ((XUnit) ref xunit6).Point;
              xunit6 = PDFFunctions.pages[DeveloperReport.k].Height;
              double num458 = ((XUnit) ref xunit6).Point / 2.0;
              XRect xrect384 = new XRect(200.0, rc1_367, point384, num458);
              XStringFormat topLeft384 = XStringFormat.TopLeft;
              xgraphics384.DrawString(str198, xfont392, (XBrush) black375, xrect384, topLeft384);
              checked { DeveloperReport.RC1 += 12; }
              DeveloperReport.CheckRC1();
              XGraphics xgraphics385 = PDFFunctions.gfx[DeveloperReport.k];
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              string str199 = SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.CommunityH.HeatSource1.Fuel + ", heat fraction " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.CommunityH.HeatSource1.HeatFraction) + ", efficiency " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.CommunityH.HeatSource1.Efficiency);
              XFont xfont393 = xfont2;
              XSolidBrush black376 = XBrushes.Black;
              double rc1_368 = (double) DeveloperReport.RC1;
              xunit6 = PDFFunctions.pages[DeveloperReport.k].Width;
              double point385 = ((XUnit) ref xunit6).Point;
              xunit6 = PDFFunctions.pages[DeveloperReport.k].Height;
              double num459 = ((XUnit) ref xunit6).Point / 2.0;
              XRect xrect385 = new XRect(205.0, rc1_368, point385, num459);
              XStringFormat topLeft385 = XStringFormat.TopLeft;
              xgraphics385.DrawString(str199, xfont393, (XBrush) black376, xrect385, topLeft385);
            }
            // ISSUE: reference to a compiler-generated field
            if (SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.CommunityH.NoOfAdditionalHeatSources > 1)
            {
              // ISSUE: reference to a compiler-generated method
              PCDF.Table4a_B table4aB = SAP_Module.PCDFData.Table4a_bs.Where<PCDF.Table4a_B>(new Func<PCDF.Table4a_B, bool>(closure140_2._Lambda\u0024__21)).SingleOrDefault<PCDF.Table4a_B>();
              checked { DeveloperReport.RC1 += 12; }
              DeveloperReport.CheckRC1();
              XGraphics xgraphics386 = PDFFunctions.gfx[DeveloperReport.k];
              string str200 = "Heat source: " + table4aB.Description;
              XFont xfont394 = xfont2;
              XSolidBrush black377 = XBrushes.Black;
              double rc1_369 = (double) DeveloperReport.RC1;
              xunit6 = PDFFunctions.pages[DeveloperReport.k].Width;
              double point386 = ((XUnit) ref xunit6).Point;
              xunit6 = PDFFunctions.pages[DeveloperReport.k].Height;
              double num460 = ((XUnit) ref xunit6).Point / 2.0;
              XRect xrect386 = new XRect(200.0, rc1_369, point386, num460);
              XStringFormat topLeft386 = XStringFormat.TopLeft;
              xgraphics386.DrawString(str200, xfont394, (XBrush) black377, xrect386, topLeft386);
              checked { DeveloperReport.RC1 += 12; }
              DeveloperReport.CheckRC1();
              XGraphics xgraphics387 = PDFFunctions.gfx[DeveloperReport.k];
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              string str201 = SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.CommunityH.HeatSource2.Fuel + ", heat fraction " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.CommunityH.HeatSource2.HeatFraction) + ", efficiency " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.CommunityH.HeatSource2.Efficiency);
              XFont xfont395 = xfont2;
              XSolidBrush black378 = XBrushes.Black;
              double rc1_370 = (double) DeveloperReport.RC1;
              xunit6 = PDFFunctions.pages[DeveloperReport.k].Width;
              double point387 = ((XUnit) ref xunit6).Point;
              xunit6 = PDFFunctions.pages[DeveloperReport.k].Height;
              double num461 = ((XUnit) ref xunit6).Point / 2.0;
              XRect xrect387 = new XRect(205.0, rc1_370, point387, num461);
              XStringFormat topLeft387 = XStringFormat.TopLeft;
              xgraphics387.DrawString(str201, xfont395, (XBrush) black378, xrect387, topLeft387);
            }
            // ISSUE: reference to a compiler-generated field
            if (SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.CommunityH.NoOfAdditionalHeatSources > 2)
            {
              // ISSUE: reference to a compiler-generated method
              PCDF.Table4a_B table4aB = SAP_Module.PCDFData.Table4a_bs.Where<PCDF.Table4a_B>(new Func<PCDF.Table4a_B, bool>(closure140_2._Lambda\u0024__22)).SingleOrDefault<PCDF.Table4a_B>();
              checked { DeveloperReport.RC1 += 12; }
              DeveloperReport.CheckRC1();
              XGraphics xgraphics388 = PDFFunctions.gfx[DeveloperReport.k];
              string str202 = "Heat source: " + table4aB.Description;
              XFont xfont396 = xfont2;
              XSolidBrush black379 = XBrushes.Black;
              double rc1_371 = (double) DeveloperReport.RC1;
              xunit6 = PDFFunctions.pages[DeveloperReport.k].Width;
              double point388 = ((XUnit) ref xunit6).Point;
              xunit6 = PDFFunctions.pages[DeveloperReport.k].Height;
              double num462 = ((XUnit) ref xunit6).Point / 2.0;
              XRect xrect388 = new XRect(200.0, rc1_371, point388, num462);
              XStringFormat topLeft388 = XStringFormat.TopLeft;
              xgraphics388.DrawString(str202, xfont396, (XBrush) black379, xrect388, topLeft388);
              checked { DeveloperReport.RC1 += 12; }
              DeveloperReport.CheckRC1();
              XGraphics xgraphics389 = PDFFunctions.gfx[DeveloperReport.k];
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              string str203 = SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.CommunityH.HeatSource3.Fuel + ", heat fraction " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.CommunityH.HeatSource3.HeatFraction) + ", efficiency " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.CommunityH.HeatSource3.Efficiency);
              XFont xfont397 = xfont2;
              XSolidBrush black380 = XBrushes.Black;
              double rc1_372 = (double) DeveloperReport.RC1;
              xunit6 = PDFFunctions.pages[DeveloperReport.k].Width;
              double point389 = ((XUnit) ref xunit6).Point;
              xunit6 = PDFFunctions.pages[DeveloperReport.k].Height;
              double num463 = ((XUnit) ref xunit6).Point / 2.0;
              XRect xrect389 = new XRect(205.0, rc1_372, point389, num463);
              XStringFormat topLeft389 = XStringFormat.TopLeft;
              xgraphics389.DrawString(str203, xfont397, (XBrush) black380, xrect389, topLeft389);
            }
            // ISSUE: reference to a compiler-generated field
            if (SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.CommunityH.NoOfAdditionalHeatSources > 3)
            {
              // ISSUE: reference to a compiler-generated method
              PCDF.Table4a_B table4aB = SAP_Module.PCDFData.Table4a_bs.Where<PCDF.Table4a_B>(new Func<PCDF.Table4a_B, bool>(closure140_2._Lambda\u0024__23)).SingleOrDefault<PCDF.Table4a_B>();
              checked { DeveloperReport.RC1 += 12; }
              DeveloperReport.CheckRC1();
              XGraphics xgraphics390 = PDFFunctions.gfx[DeveloperReport.k];
              string str204 = "Heat source: " + table4aB.Description;
              XFont xfont398 = xfont2;
              XSolidBrush black381 = XBrushes.Black;
              double rc1_373 = (double) DeveloperReport.RC1;
              xunit6 = PDFFunctions.pages[DeveloperReport.k].Width;
              double point390 = ((XUnit) ref xunit6).Point;
              xunit6 = PDFFunctions.pages[DeveloperReport.k].Height;
              double num464 = ((XUnit) ref xunit6).Point / 2.0;
              XRect xrect390 = new XRect(200.0, rc1_373, point390, num464);
              XStringFormat topLeft390 = XStringFormat.TopLeft;
              xgraphics390.DrawString(str204, xfont398, (XBrush) black381, xrect390, topLeft390);
              checked { DeveloperReport.RC1 += 12; }
              DeveloperReport.CheckRC1();
              XGraphics xgraphics391 = PDFFunctions.gfx[DeveloperReport.k];
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              string str205 = SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.CommunityH.HeatSource4.Fuel + ", heat fraction " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.CommunityH.HeatSource4.HeatFraction) + ", efficiency " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.CommunityH.HeatSource4.Efficiency);
              XFont xfont399 = xfont2;
              XSolidBrush black382 = XBrushes.Black;
              double rc1_374 = (double) DeveloperReport.RC1;
              xunit6 = PDFFunctions.pages[DeveloperReport.k].Width;
              double point391 = ((XUnit) ref xunit6).Point;
              xunit6 = PDFFunctions.pages[DeveloperReport.k].Height;
              double num465 = ((XUnit) ref xunit6).Point / 2.0;
              XRect xrect391 = new XRect(205.0, rc1_374, point391, num465);
              XStringFormat topLeft391 = XStringFormat.TopLeft;
              xgraphics391.DrawString(str205, xfont399, (XBrush) black382, xrect391, topLeft391);
            }
            checked { DeveloperReport.RC1 += 12; }
            DeveloperReport.CheckRC1();
            XGraphics xgraphics392 = PDFFunctions.gfx[DeveloperReport.k];
            // ISSUE: reference to a compiler-generated field
            string heatDsystem = SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.CommunityH.HeatDSystem;
            XFont xfont400 = xfont2;
            XSolidBrush black383 = XBrushes.Black;
            double rc1_375 = (double) DeveloperReport.RC1;
            xunit6 = PDFFunctions.pages[DeveloperReport.k].Width;
            double point392 = ((XUnit) ref xunit6).Point;
            xunit6 = PDFFunctions.pages[DeveloperReport.k].Height;
            double num466 = ((XUnit) ref xunit6).Point / 2.0;
            XRect xrect392 = new XRect(200.0, rc1_375, point392, num466);
            XStringFormat topLeft392 = XStringFormat.TopLeft;
            xgraphics392.DrawString(heatDsystem, xfont400, (XBrush) black383, xrect392, topLeft392);
          }
        }
        checked { DeveloperReport.RC1 += 14; }
        DeveloperReport.CheckRC1();
        // ISSUE: reference to a compiler-generated field
        if (!string.IsNullOrEmpty(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.Boiler.PumpType))
        {
          XGraphics xgraphics393 = PDFFunctions.gfx[DeveloperReport.k];
          // ISSUE: reference to a compiler-generated field
          string str206 = "Central heating pump : " + SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.Boiler.PumpType;
          XFont xfont401 = xfont2;
          XSolidBrush black384 = XBrushes.Black;
          double rc1_376 = (double) DeveloperReport.RC1;
          xunit6 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point393 = ((XUnit) ref xunit6).Point;
          xunit6 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num467 = ((XUnit) ref xunit6).Point / 2.0;
          XRect xrect393 = new XRect(200.0, rc1_376, point393, num467);
          XStringFormat topLeft393 = XStringFormat.TopLeft;
          xgraphics393.DrawString(str206, xfont401, (XBrush) black384, xrect393, topLeft393);
          checked { DeveloperReport.RC1 += 12; }
          DeveloperReport.CheckRC1();
        }
        // ISSUE: reference to a compiler-generated field
        if (!string.IsNullOrEmpty(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.Boiler.FlowTemp))
        {
          XGraphics xgraphics394 = PDFFunctions.gfx[DeveloperReport.k];
          // ISSUE: reference to a compiler-generated field
          string str207 = "Central heating pump : " + SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.Boiler.FlowTemp;
          XFont xfont402 = xfont2;
          XSolidBrush black385 = XBrushes.Black;
          double rc1_377 = (double) DeveloperReport.RC1;
          xunit6 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point394 = ((XUnit) ref xunit6).Point;
          xunit6 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num468 = ((XUnit) ref xunit6).Point / 2.0;
          XRect xrect394 = new XRect(200.0, rc1_377, point394, num468);
          XStringFormat topLeft394 = XStringFormat.TopLeft;
          xgraphics394.DrawString(str207, xfont402, (XBrush) black385, xrect394, topLeft394);
          checked { DeveloperReport.RC1 += 12; }
          DeveloperReport.CheckRC1();
        }
        // ISSUE: reference to a compiler-generated field
        if (!string.IsNullOrEmpty(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.Boiler.FlueType))
        {
          XGraphics xgraphics395 = PDFFunctions.gfx[DeveloperReport.k];
          // ISSUE: reference to a compiler-generated field
          string flueType = SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.Boiler.FlueType;
          XFont xfont403 = xfont2;
          XSolidBrush black386 = XBrushes.Black;
          double rc1_378 = (double) DeveloperReport.RC1;
          xunit6 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point395 = ((XUnit) ref xunit6).Point;
          xunit6 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num469 = ((XUnit) ref xunit6).Point / 2.0;
          XRect xrect395 = new XRect(200.0, rc1_378, point395, num469);
          XStringFormat topLeft395 = XStringFormat.TopLeft;
          xgraphics395.DrawString(flueType, xfont403, (XBrush) black386, xrect395, topLeft395);
          checked { DeveloperReport.RC1 += 12; }
          DeveloperReport.CheckRC1();
        }
        // ISSUE: reference to a compiler-generated field
        if (!string.IsNullOrEmpty(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.Boiler.BILock))
        {
          XGraphics xgraphics396 = PDFFunctions.gfx[DeveloperReport.k];
          // ISSUE: reference to a compiler-generated field
          string str208 = "Boiler interlock: " + SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.Boiler.BILock;
          XFont xfont404 = xfont2;
          XSolidBrush black387 = XBrushes.Black;
          double rc1_379 = (double) DeveloperReport.RC1;
          xunit6 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point396 = ((XUnit) ref xunit6).Point;
          xunit6 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num470 = ((XUnit) ref xunit6).Point / 2.0;
          XRect xrect396 = new XRect(200.0, rc1_379, point396, num470);
          XStringFormat topLeft396 = XStringFormat.TopLeft;
          xgraphics396.DrawString(str208, xfont404, (XBrush) black387, xrect396, topLeft396);
          checked { DeveloperReport.RC1 += 12; }
          DeveloperReport.CheckRC1();
        }
        try
        {
          // ISSUE: reference to a compiler-generated field
          if ((uint) Operators.CompareString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.Boiler.LoadWeatherType, "", false) > 0U)
          {
            XGraphics xgraphics397 = PDFFunctions.gfx[DeveloperReport.k];
            // ISSUE: reference to a compiler-generated field
            string loadWeatherType = SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.Boiler.LoadWeatherType;
            XFont xfont405 = xfont2;
            XSolidBrush black388 = XBrushes.Black;
            double rc1_380 = (double) DeveloperReport.RC1;
            xunit6 = PDFFunctions.pages[DeveloperReport.k].Width;
            double point397 = ((XUnit) ref xunit6).Point;
            xunit6 = PDFFunctions.pages[DeveloperReport.k].Height;
            double num471 = ((XUnit) ref xunit6).Point / 2.0;
            XRect xrect397 = new XRect(200.0, rc1_380, point397, num471);
            XStringFormat topLeft397 = XStringFormat.TopLeft;
            xgraphics397.DrawString(loadWeatherType, xfont405, (XBrush) black388, xrect397, topLeft397);
            checked { DeveloperReport.RC1 += 14; }
          }
          else
          {
            // ISSUE: reference to a compiler-generated field
            if ((uint) Operators.CompareString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.Compensator, "", false) > 0U)
            {
              XGraphics xgraphics398 = PDFFunctions.gfx[DeveloperReport.k];
              // ISSUE: reference to a compiler-generated field
              string compensator = SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.Compensator;
              XFont xfont406 = xfont2;
              XSolidBrush black389 = XBrushes.Black;
              double rc1_381 = (double) DeveloperReport.RC1;
              xunit6 = PDFFunctions.pages[DeveloperReport.k].Width;
              double point398 = ((XUnit) ref xunit6).Point;
              xunit6 = PDFFunctions.pages[DeveloperReport.k].Height;
              double num472 = ((XUnit) ref xunit6).Point / 2.0;
              XRect xrect398 = new XRect(200.0, rc1_381, point398, num472);
              XStringFormat topLeft398 = XStringFormat.TopLeft;
              xgraphics398.DrawString(compensator, xfont406, (XBrush) black389, xrect398, topLeft398);
              checked { DeveloperReport.RC1 += 14; }
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
          // ISSUE: reference to a compiler-generated field
          if (SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.Boiler.IncludeKeepHot)
          {
            XGraphics xgraphics399 = PDFFunctions.gfx[DeveloperReport.k];
            // ISSUE: reference to a compiler-generated field
            string str209 = "Keep hot Facility " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.Boiler.KeepHotTimed);
            XFont xfont407 = xfont2;
            XSolidBrush black390 = XBrushes.Black;
            double rc1_382 = (double) DeveloperReport.RC1;
            XUnit width17 = PDFFunctions.pages[DeveloperReport.k].Width;
            double point399 = ((XUnit) ref width17).Point;
            XUnit height13 = PDFFunctions.pages[DeveloperReport.k].Height;
            double num473 = ((XUnit) ref height13).Point / 2.0;
            XRect xrect399 = new XRect(200.0, rc1_382, point399, num473);
            XStringFormat topLeft399 = XStringFormat.TopLeft;
            xgraphics399.DrawString(str209, xfont407, (XBrush) black390, xrect399, topLeft399);
            checked { DeveloperReport.RC1 += 12; }
            XGraphics xgraphics400 = PDFFunctions.gfx[DeveloperReport.k];
            // ISSUE: reference to a compiler-generated field
            string str210 = "Keep hot Facility (Fuel used) " + SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.Boiler.KeepHotFuel;
            XFont xfont408 = xfont2;
            XSolidBrush black391 = XBrushes.Black;
            double rc1_383 = (double) DeveloperReport.RC1;
            XUnit width18 = PDFFunctions.pages[DeveloperReport.k].Width;
            double point400 = ((XUnit) ref width18).Point;
            XUnit height14 = PDFFunctions.pages[DeveloperReport.k].Height;
            double num474 = ((XUnit) ref height14).Point / 2.0;
            XRect xrect400 = new XRect(200.0, rc1_383, point400, num474);
            XStringFormat topLeft400 = XStringFormat.TopLeft;
            xgraphics400.DrawString(str210, xfont408, (XBrush) black391, xrect400, topLeft400);
            checked { DeveloperReport.RC1 += 14; }
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        try
        {
          // ISSUE: reference to a compiler-generated field
          if (SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.DelayedStart)
          {
            XGraphics xgraphics401 = PDFFunctions.gfx[DeveloperReport.k];
            XFont xfont409 = xfont2;
            XSolidBrush black392 = XBrushes.Black;
            double rc1_384 = (double) DeveloperReport.RC1;
            XUnit width19 = PDFFunctions.pages[DeveloperReport.k].Width;
            double point401 = ((XUnit) ref width19).Point;
            XUnit height15 = PDFFunctions.pages[DeveloperReport.k].Height;
            double num475 = ((XUnit) ref height15).Point / 2.0;
            XRect xrect401 = new XRect(200.0, rc1_384, point401, num475);
            XStringFormat topLeft401 = XStringFormat.TopLeft;
            xgraphics401.DrawString("Delayed start ", xfont409, (XBrush) black392, xrect401, topLeft401);
            checked { DeveloperReport.RC1 += 14; }
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        // ISSUE: reference to a compiler-generated field
        if (SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.MCSCert)
        {
          XGraphics xgraphics402 = PDFFunctions.gfx[DeveloperReport.k];
          XFont xfont410 = xfont2;
          XSolidBrush black393 = XBrushes.Black;
          double rc1_385 = (double) DeveloperReport.RC1;
          XUnit width20 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point402 = ((XUnit) ref width20).Point;
          XUnit height16 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num476 = ((XUnit) ref height16).Point / 2.0;
          XRect xrect402 = new XRect(200.0, rc1_385, point402, num476);
          XStringFormat topLeft402 = XStringFormat.TopLeft;
          xgraphics402.DrawString("MCS Installation Certificate", xfont410, (XBrush) black393, xrect402, topLeft402);
          checked { DeveloperReport.RC1 += 14; }
          DeveloperReport.CheckRC1();
        }
        DeveloperReport.CheckRC1();
        DeveloperReport.CreateBox();
        DeveloperReport.CheckRC1();
        PDFFunctions.xBrush1 = XBrush.op_Implicit((Brush) new SolidBrush(Color.FromArgb(159, 172, 62)));
        PDFFunctions.Points[0].X = 20f;
        PDFFunctions.Points[0].Y = (float) DeveloperReport.RC1;
        ref PointF local19 = ref PDFFunctions.Points[1];
        XUnit width21 = PDFFunctions.pages[DeveloperReport.k].Width;
        double num477 = ((XUnit) ref width21).Point - 20.0;
        local19.X = (float) num477;
        PDFFunctions.Points[1].Y = (float) DeveloperReport.RC1;
        ref PointF local20 = ref PDFFunctions.Points[2];
        XUnit width22 = PDFFunctions.pages[DeveloperReport.k].Width;
        double num478 = ((XUnit) ref width22).Point - 20.0;
        local20.X = (float) num478;
        PDFFunctions.Points[2].Y = (float) checked (DeveloperReport.RC1 + 16);
        PDFFunctions.Points[3].X = 20f;
        PDFFunctions.Points[3].Y = (float) checked (DeveloperReport.RC1 + 16);
        PDFFunctions.gfx[DeveloperReport.k].DrawPolygon(PDFFunctions.polyGreen2, PDFFunctions.xBrush1, PDFFunctions.Points, xfillMode);
        XGraphics xgraphics403 = PDFFunctions.gfx[DeveloperReport.k];
        XFont xfont411 = xfont3;
        XSolidBrush white10 = XBrushes.White;
        double num479 = (double) checked (DeveloperReport.RC1 + 1);
        XUnit width23 = PDFFunctions.pages[DeveloperReport.k].Width;
        double point403 = ((XUnit) ref width23).Point;
        XUnit height17 = PDFFunctions.pages[DeveloperReport.k].Height;
        double num480 = ((XUnit) ref height17).Point / 2.0;
        XRect xrect403 = new XRect(25.0, num479, point403, num480);
        XStringFormat topLeft403 = XStringFormat.TopLeft;
        xgraphics403.DrawString("Secondary Main heating Control:", xfont411, (XBrush) white10, xrect403, topLeft403);
        DeveloperReport.RC1 = checked ((int) Math.Round(unchecked ((double) PDFFunctions.Points[3].Y + 6.0)));
        DeveloperReport.CheckRC1();
        XGraphics xgraphics404 = PDFFunctions.gfx[DeveloperReport.k];
        XFont xfont412 = xfont2;
        XSolidBrush black394 = XBrushes.Black;
        double rc1_386 = (double) DeveloperReport.RC1;
        XUnit width24 = PDFFunctions.pages[DeveloperReport.k].Width;
        double point404 = ((XUnit) ref width24).Point;
        XUnit height18 = PDFFunctions.pages[DeveloperReport.k].Height;
        double num481 = ((XUnit) ref height18).Point / 2.0;
        XRect xrect404 = new XRect(20.0, rc1_386, point404, num481);
        XStringFormat topLeft404 = XStringFormat.TopLeft;
        xgraphics404.DrawString("Secondary Main heating Control: ", xfont412, (XBrush) black394, xrect404, topLeft404);
        try
        {
          // ISSUE: reference to a compiler-generated field
          string[] strArray = DeveloperReport.CheckTextWidth2(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.Controls, 230);
          if (strArray != null)
          {
            if (strArray[0].Length == 0)
            {
              // ISSUE: reference to a compiler-generated field
              strArray[0] = SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.Controls;
            }
            int num482 = checked (strArray.Length - 1);
            int index29 = 0;
            while (index29 <= num482)
            {
              if ((uint) Operators.CompareString(strArray[index29], "", false) > 0U)
              {
                XGraphics xgraphics405 = PDFFunctions.gfx[DeveloperReport.k];
                string str211 = strArray[index29];
                XFont xfont413 = xfont2;
                XSolidBrush black395 = XBrushes.Black;
                double rc1_387 = (double) DeveloperReport.RC1;
                XUnit width25 = PDFFunctions.pages[DeveloperReport.k].Width;
                double point405 = ((XUnit) ref width25).Point;
                XUnit height19 = PDFFunctions.pages[DeveloperReport.k].Height;
                double num483 = ((XUnit) ref height19).Point / 2.0;
                XRect xrect405 = new XRect(200.0, rc1_387, point405, num483);
                XStringFormat topLeft405 = XStringFormat.TopLeft;
                xgraphics405.DrawString(str211, xfont413, (XBrush) black395, xrect405, topLeft405);
                checked { DeveloperReport.RC1 += 12; }
                DeveloperReport.CheckRC1();
              }
              checked { ++index29; }
            }
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        XGraphics xgraphics406 = PDFFunctions.gfx[DeveloperReport.k];
        // ISSUE: reference to a compiler-generated field
        string str212 = "Control code: " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.ControlCode);
        XFont xfont414 = xfont2;
        XSolidBrush black396 = XBrushes.Black;
        double rc1_388 = (double) DeveloperReport.RC1;
        XUnit width26 = PDFFunctions.pages[DeveloperReport.k].Width;
        double point406 = ((XUnit) ref width26).Point;
        XUnit height20 = PDFFunctions.pages[DeveloperReport.k].Height;
        double num484 = ((XUnit) ref height20).Point / 2.0;
        XRect xrect406 = new XRect(200.0, rc1_388, point406, num484);
        XStringFormat topLeft406 = XStringFormat.TopLeft;
        xgraphics406.DrawString(str212, xfont414, (XBrush) black396, xrect406, topLeft406);
        checked { DeveloperReport.RC1 += 14; }
        DeveloperReport.CheckRC1();
        // ISSUE: reference to a compiler-generated field
        if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.HGroup, "Central heating systems with radiators or underfloor heating", false) == 0)
        {
          XGraphics xgraphics407 = PDFFunctions.gfx[DeveloperReport.k];
          // ISSUE: reference to a compiler-generated field
          string str213 = "Boiler interlock: " + SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating2.Boiler.BILock;
          XFont xfont415 = xfont2;
          XSolidBrush black397 = XBrushes.Black;
          double rc1_389 = (double) DeveloperReport.RC1;
          xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point407 = ((XUnit) ref xunit5).Point;
          xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num485 = ((XUnit) ref xunit5).Point / 2.0;
          XRect xrect407 = new XRect(200.0, rc1_389, point407, num485);
          XStringFormat topLeft407 = XStringFormat.TopLeft;
          xgraphics407.DrawString(str213, xfont415, (XBrush) black397, xrect407, topLeft407);
          checked { DeveloperReport.RC1 += 14; }
          DeveloperReport.CheckRC1();
        }
        DeveloperReport.CheckRC1();
        DeveloperReport.CreateBox();
        DeveloperReport.CheckRC1();
      }
      PDFFunctions.xBrush1 = XBrush.op_Implicit((Brush) new SolidBrush(Color.FromArgb(159, 172, 62)));
      PDFFunctions.Points[0].X = 20f;
      PDFFunctions.Points[0].Y = (float) DeveloperReport.RC1;
      ref PointF local21 = ref PDFFunctions.Points[1];
      xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
      double num486 = ((XUnit) ref xunit5).Point - 20.0;
      local21.X = (float) num486;
      PDFFunctions.Points[1].Y = (float) DeveloperReport.RC1;
      ref PointF local22 = ref PDFFunctions.Points[2];
      xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
      double num487 = ((XUnit) ref xunit5).Point - 20.0;
      local22.X = (float) num487;
      PDFFunctions.Points[2].Y = (float) checked (DeveloperReport.RC1 + 16);
      PDFFunctions.Points[3].X = 20f;
      PDFFunctions.Points[3].Y = (float) checked (DeveloperReport.RC1 + 16);
      PDFFunctions.gfx[DeveloperReport.k].DrawPolygon(PDFFunctions.polyGreen2, PDFFunctions.xBrush1, PDFFunctions.Points, xfillMode);
      XGraphics xgraphics408 = PDFFunctions.gfx[DeveloperReport.k];
      XFont xfont416 = xfont3;
      XSolidBrush white11 = XBrushes.White;
      double num488 = (double) checked (DeveloperReport.RC1 + 1);
      xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
      double point408 = ((XUnit) ref xunit5).Point;
      xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
      double num489 = ((XUnit) ref xunit5).Point / 2.0;
      XRect xrect408 = new XRect(25.0, num488, point408, num489);
      XStringFormat topLeft408 = XStringFormat.TopLeft;
      xgraphics408.DrawString("Secondary heating system:", xfont416, (XBrush) white11, xrect408, topLeft408);
      DeveloperReport.RC1 = checked ((int) Math.Round(unchecked ((double) PDFFunctions.Points[3].Y + 6.0)));
      XGraphics xgraphics409 = PDFFunctions.gfx[DeveloperReport.k];
      XFont xfont417 = xfont2;
      XSolidBrush black398 = XBrushes.Black;
      double rc1_390 = (double) DeveloperReport.RC1;
      xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
      double point409 = ((XUnit) ref xunit5).Point;
      xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
      double num490 = ((XUnit) ref xunit5).Point / 2.0;
      XRect xrect409 = new XRect(20.0, rc1_390, point409, num490);
      XStringFormat topLeft409 = XStringFormat.TopLeft;
      xgraphics409.DrawString("Secondary heating system:", xfont417, (XBrush) black398, xrect409, topLeft409);
      // ISSUE: reference to a compiler-generated field
      if (SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].SecHeating.SAPTableCode == 0)
      {
        XGraphics xgraphics410 = PDFFunctions.gfx[DeveloperReport.k];
        XFont xfont418 = xfont2;
        XSolidBrush black399 = XBrushes.Black;
        double num491 = (double) checked (DeveloperReport.RC1 + 1);
        xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
        double point410 = ((XUnit) ref xunit5).Point;
        xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
        double num492 = ((XUnit) ref xunit5).Point / 2.0;
        XRect xrect410 = new XRect(200.0, num491, point410, num492);
        XStringFormat topLeft410 = XStringFormat.TopLeft;
        xgraphics410.DrawString("None", xfont418, (XBrush) black399, xrect410, topLeft410);
      }
      else
      {
        XGraphics xgraphics411 = PDFFunctions.gfx[DeveloperReport.k];
        // ISSUE: reference to a compiler-generated field
        string hgroup3 = SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].SecHeating.HGroup;
        XFont xfont419 = xfont2;
        XSolidBrush black400 = XBrushes.Black;
        double rc1_391 = (double) DeveloperReport.RC1;
        xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
        double point411 = ((XUnit) ref xunit5).Point;
        xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
        double num493 = ((XUnit) ref xunit5).Point / 2.0;
        XRect xrect411 = new XRect(200.0, rc1_391, point411, num493);
        XStringFormat topLeft411 = XStringFormat.TopLeft;
        xgraphics411.DrawString(hgroup3, xfont419, (XBrush) black400, xrect411, topLeft411);
        checked { DeveloperReport.RC1 += 12; }
        XGraphics xgraphics412 = PDFFunctions.gfx[DeveloperReport.k];
        // ISSUE: reference to a compiler-generated field
        string sgroup = SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].SecHeating.SGroup;
        XFont xfont420 = xfont2;
        XSolidBrush black401 = XBrushes.Black;
        double rc1_392 = (double) DeveloperReport.RC1;
        xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
        double point412 = ((XUnit) ref xunit5).Point;
        xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
        double num494 = ((XUnit) ref xunit5).Point / 2.0;
        XRect xrect412 = new XRect(200.0, rc1_392, point412, num494);
        XStringFormat topLeft412 = XStringFormat.TopLeft;
        xgraphics412.DrawString(sgroup, xfont420, (XBrush) black401, xrect412, topLeft412);
        checked { DeveloperReport.RC1 += 12; }
        XGraphics xgraphics413 = PDFFunctions.gfx[DeveloperReport.k];
        // ISSUE: reference to a compiler-generated field
        string str214 = "Fuel :" + SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].SecHeating.Fuel;
        XFont xfont421 = xfont2;
        XSolidBrush black402 = XBrushes.Black;
        double rc1_393 = (double) DeveloperReport.RC1;
        xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
        double point413 = ((XUnit) ref xunit5).Point;
        xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
        double num495 = ((XUnit) ref xunit5).Point / 2.0;
        XRect xrect413 = new XRect(200.0, rc1_393, point413, num495);
        XStringFormat topLeft413 = XStringFormat.TopLeft;
        xgraphics413.DrawString(str214, xfont421, (XBrush) black402, xrect413, topLeft413);
        checked { DeveloperReport.RC1 += 12; }
        XGraphics xgraphics414 = PDFFunctions.gfx[DeveloperReport.k];
        // ISSUE: reference to a compiler-generated field
        string str215 = "Info Source: " + SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].SecHeating.InforSource;
        XFont xfont422 = xfont2;
        XSolidBrush black403 = XBrushes.Black;
        double rc1_394 = (double) DeveloperReport.RC1;
        xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
        double point414 = ((XUnit) ref xunit5).Point;
        xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
        double num496 = ((XUnit) ref xunit5).Point / 2.0;
        XRect xrect414 = new XRect(200.0, rc1_394, point414, num496);
        XStringFormat topLeft414 = XStringFormat.TopLeft;
        xgraphics414.DrawString(str215, xfont422, (XBrush) black403, xrect414, topLeft414);
        checked { DeveloperReport.RC1 += 12; }
        XGraphics xgraphics415 = PDFFunctions.gfx[DeveloperReport.k];
        // ISSUE: reference to a compiler-generated field
        string mhType = SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].SecHeating.MHType;
        XFont xfont423 = xfont2;
        XSolidBrush black404 = XBrushes.Black;
        double rc1_395 = (double) DeveloperReport.RC1;
        xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
        double point415 = ((XUnit) ref xunit5).Point;
        xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
        double num497 = ((XUnit) ref xunit5).Point / 2.0;
        XRect xrect415 = new XRect(200.0, rc1_395, point415, num497);
        XStringFormat topLeft415 = XStringFormat.TopLeft;
        xgraphics415.DrawString(mhType, xfont423, (XBrush) black404, xrect415, topLeft415);
        checked { DeveloperReport.RC1 += 12; }
        try
        {
          // ISSUE: reference to a compiler-generated field
          if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].SecHeating.HETAS, "Yes", false) == 0)
          {
            XGraphics xgraphics416 = PDFFunctions.gfx[DeveloperReport.k];
            XFont xfont424 = xfont2;
            XSolidBrush black405 = XBrushes.Black;
            double rc1_396 = (double) DeveloperReport.RC1;
            xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
            double point416 = ((XUnit) ref xunit5).Point;
            xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
            double num498 = ((XUnit) ref xunit5).Point / 2.0;
            XRect xrect416 = new XRect(200.0, rc1_396, point416, num498);
            XStringFormat topLeft416 = XStringFormat.TopLeft;
            xgraphics416.DrawString("HETAS Approved", xfont424, (XBrush) black405, xrect416, topLeft416);
            checked { DeveloperReport.RC1 += 12; }
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
      }
      checked { DeveloperReport.RC1 += 14; }
      DeveloperReport.CheckRC1();
      DeveloperReport.CreateBox();
      DeveloperReport.CheckRC1();
      // ISSUE: reference to a compiler-generated field
      if (SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Cooling.Include)
      {
        PDFFunctions.xBrush1 = XBrush.op_Implicit((Brush) new SolidBrush(Color.FromArgb(159, 172, 62)));
        PDFFunctions.Points[0].X = 20f;
        PDFFunctions.Points[0].Y = (float) DeveloperReport.RC1;
        ref PointF local23 = ref PDFFunctions.Points[1];
        xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
        double num499 = ((XUnit) ref xunit5).Point - 20.0;
        local23.X = (float) num499;
        PDFFunctions.Points[1].Y = (float) DeveloperReport.RC1;
        ref PointF local24 = ref PDFFunctions.Points[2];
        xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
        double num500 = ((XUnit) ref xunit5).Point - 20.0;
        local24.X = (float) num500;
        PDFFunctions.Points[2].Y = (float) checked (DeveloperReport.RC1 + 16);
        PDFFunctions.Points[3].X = 20f;
        PDFFunctions.Points[3].Y = (float) checked (DeveloperReport.RC1 + 16);
        PDFFunctions.gfx[DeveloperReport.k].DrawPolygon(PDFFunctions.polyGreen2, PDFFunctions.xBrush1, PDFFunctions.Points, xfillMode);
        XGraphics xgraphics417 = PDFFunctions.gfx[DeveloperReport.k];
        XFont xfont425 = xfont2;
        XSolidBrush white12 = XBrushes.White;
        double num501 = (double) checked (DeveloperReport.RC1 + 1);
        xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
        double point417 = ((XUnit) ref xunit5).Point;
        xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
        double num502 = ((XUnit) ref xunit5).Point / 2.0;
        XRect xrect417 = new XRect(25.0, num501, point417, num502);
        XStringFormat topLeft417 = XStringFormat.TopLeft;
        xgraphics417.DrawString("Space cooling system:", xfont425, (XBrush) white12, xrect417, topLeft417);
        DeveloperReport.RC1 = checked ((int) Math.Round(unchecked ((double) PDFFunctions.Points[3].Y + 6.0)));
        DeveloperReport.CheckRC1();
        XGraphics xgraphics418 = PDFFunctions.gfx[DeveloperReport.k];
        XFont xfont426 = xfont2;
        XSolidBrush black406 = XBrushes.Black;
        double rc1_397 = (double) DeveloperReport.RC1;
        xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
        double point418 = ((XUnit) ref xunit5).Point;
        xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
        double num503 = ((XUnit) ref xunit5).Point / 2.0;
        XRect xrect418 = new XRect(20.0, rc1_397, point418, num503);
        XStringFormat topLeft418 = XStringFormat.TopLeft;
        xgraphics418.DrawString("Space cooling system:", xfont426, (XBrush) black406, xrect418, topLeft418);
        XGraphics xgraphics419 = PDFFunctions.gfx[DeveloperReport.k];
        // ISSUE: reference to a compiler-generated field
        string systemType = SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Cooling.SystemType;
        XFont xfont427 = xfont2;
        XSolidBrush black407 = XBrushes.Black;
        double rc1_398 = (double) DeveloperReport.RC1;
        xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
        double point419 = ((XUnit) ref xunit5).Point;
        xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
        double num504 = ((XUnit) ref xunit5).Point / 2.0;
        XRect xrect419 = new XRect(200.0, rc1_398, point419, num504);
        XStringFormat topLeft419 = XStringFormat.TopLeft;
        xgraphics419.DrawString(systemType, xfont427, (XBrush) black407, xrect419, topLeft419);
        checked { DeveloperReport.RC1 += 12; }
        DeveloperReport.CheckRC1();
        // ISSUE: reference to a compiler-generated field
        if (SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Cooling.ERRMeasuredInclude)
        {
          XGraphics xgraphics420 = PDFFunctions.gfx[DeveloperReport.k];
          XFont xfont428 = xfont2;
          XSolidBrush black408 = XBrushes.Black;
          double rc1_399 = (double) DeveloperReport.RC1;
          xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point420 = ((XUnit) ref xunit5).Point;
          xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num505 = ((XUnit) ref xunit5).Point / 2.0;
          XRect xrect420 = new XRect(200.0, rc1_399, point420, num505);
          XStringFormat topLeft420 = XStringFormat.TopLeft;
          xgraphics420.DrawString("Tested data to EN 14511: ", xfont428, (XBrush) black408, xrect420, topLeft420);
          checked { DeveloperReport.RC1 += 12; }
          DeveloperReport.CheckRC1();
          XGraphics xgraphics421 = PDFFunctions.gfx[DeveloperReport.k];
          // ISSUE: reference to a compiler-generated field
          string str216 = "Brand/Model: " + SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Cooling.Description;
          XFont xfont429 = xfont2;
          XSolidBrush black409 = XBrushes.Black;
          double rc1_400 = (double) DeveloperReport.RC1;
          xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point421 = ((XUnit) ref xunit5).Point;
          xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num506 = ((XUnit) ref xunit5).Point / 2.0;
          XRect xrect421 = new XRect(205.0, rc1_400, point421, num506);
          XStringFormat topLeft421 = XStringFormat.TopLeft;
          xgraphics421.DrawString(str216, xfont429, (XBrush) black409, xrect421, topLeft421);
          checked { DeveloperReport.RC1 += 12; }
          DeveloperReport.CheckRC1();
          XGraphics xgraphics422 = PDFFunctions.gfx[DeveloperReport.k];
          // ISSUE: reference to a compiler-generated field
          string str217 = "EER: " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Cooling.ERR);
          XFont xfont430 = xfont2;
          XSolidBrush black410 = XBrushes.Black;
          double rc1_401 = (double) DeveloperReport.RC1;
          xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point422 = ((XUnit) ref xunit5).Point;
          xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num507 = ((XUnit) ref xunit5).Point / 2.0;
          XRect xrect422 = new XRect(205.0, rc1_401, point422, num507);
          XStringFormat topLeft422 = XStringFormat.TopLeft;
          xgraphics422.DrawString(str217, xfont430, (XBrush) black410, xrect422, topLeft422);
          checked { DeveloperReport.RC1 += 12; }
          DeveloperReport.CheckRC1();
        }
        else
        {
          XGraphics xgraphics423 = PDFFunctions.gfx[DeveloperReport.k];
          // ISSUE: reference to a compiler-generated field
          string str218 = "Energy label class: " + SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Cooling.Energylabel;
          XFont xfont431 = xfont2;
          XSolidBrush black411 = XBrushes.Black;
          double rc1_402 = (double) DeveloperReport.RC1;
          xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point423 = ((XUnit) ref xunit5).Point;
          xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num508 = ((XUnit) ref xunit5).Point / 2.0;
          XRect xrect423 = new XRect(200.0, rc1_402, point423, num508);
          XStringFormat topLeft423 = XStringFormat.TopLeft;
          xgraphics423.DrawString(str218, xfont431, (XBrush) black411, xrect423, topLeft423);
          checked { DeveloperReport.RC1 += 12; }
          DeveloperReport.CheckRC1();
        }
        XGraphics xgraphics424 = PDFFunctions.gfx[DeveloperReport.k];
        // ISSUE: reference to a compiler-generated field
        string str219 = "Compressor control: " + SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Cooling.Compressorcontrol;
        XFont xfont432 = xfont2;
        XSolidBrush black412 = XBrushes.Black;
        double rc1_403 = (double) DeveloperReport.RC1;
        xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
        double point424 = ((XUnit) ref xunit5).Point;
        xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
        double num509 = ((XUnit) ref xunit5).Point / 2.0;
        XRect xrect424 = new XRect(200.0, rc1_403, point424, num509);
        XStringFormat topLeft424 = XStringFormat.TopLeft;
        xgraphics424.DrawString(str219, xfont432, (XBrush) black412, xrect424, topLeft424);
        checked { DeveloperReport.RC1 += 12; }
        DeveloperReport.CheckRC1();
        XGraphics xgraphics425 = PDFFunctions.gfx[DeveloperReport.k];
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        string str220 = "Cooled area: " + SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Cooling.Cooled_Area + " (fraction " + Microsoft.VisualBasic.Strings.Format((object) (Conversions.ToDouble(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Cooling.Cooled_Area) / SAP_Module.Calculation2012.Calculation.Dimensions.Box4), "#0.000") + ")";
        XFont xfont433 = xfont2;
        XSolidBrush black413 = XBrushes.Black;
        double rc1_404 = (double) DeveloperReport.RC1;
        xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
        double point425 = ((XUnit) ref xunit5).Point;
        xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
        double num510 = ((XUnit) ref xunit5).Point / 2.0;
        XRect xrect425 = new XRect(200.0, rc1_404, point425, num510);
        XStringFormat topLeft425 = XStringFormat.TopLeft;
        xgraphics425.DrawString(str220, xfont433, (XBrush) black413, xrect425, topLeft425);
        checked { DeveloperReport.RC1 += 12; }
        DeveloperReport.CheckRC1();
      }
      PDFFunctions.xBrush1 = XBrush.op_Implicit((Brush) new SolidBrush(Color.FromArgb(159, 172, 62)));
      PDFFunctions.Points[0].X = 20f;
      PDFFunctions.Points[0].Y = (float) DeveloperReport.RC1;
      ref PointF local25 = ref PDFFunctions.Points[1];
      xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
      double num511 = ((XUnit) ref xunit5).Point - 20.0;
      local25.X = (float) num511;
      PDFFunctions.Points[1].Y = (float) DeveloperReport.RC1;
      ref PointF local26 = ref PDFFunctions.Points[2];
      xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
      double num512 = ((XUnit) ref xunit5).Point - 20.0;
      local26.X = (float) num512;
      PDFFunctions.Points[2].Y = (float) checked (DeveloperReport.RC1 + 16);
      PDFFunctions.Points[3].X = 20f;
      PDFFunctions.Points[3].Y = (float) checked (DeveloperReport.RC1 + 16);
      PDFFunctions.gfx[DeveloperReport.k].DrawPolygon(PDFFunctions.polyGreen2, PDFFunctions.xBrush1, PDFFunctions.Points, xfillMode);
      XGraphics xgraphics426 = PDFFunctions.gfx[DeveloperReport.k];
      XFont xfont434 = xfont3;
      XSolidBrush white13 = XBrushes.White;
      double num513 = (double) checked (DeveloperReport.RC1 + 1);
      xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
      double point426 = ((XUnit) ref xunit5).Point;
      xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
      double num514 = ((XUnit) ref xunit5).Point / 2.0;
      XRect xrect426 = new XRect(25.0, num513, point426, num514);
      XStringFormat topLeft426 = XStringFormat.TopLeft;
      xgraphics426.DrawString("Water heating:", xfont434, (XBrush) white13, xrect426, topLeft426);
      DeveloperReport.RC1 = checked ((int) Math.Round(unchecked ((double) PDFFunctions.Points[3].Y + 6.0)));
      XGraphics xgraphics427 = PDFFunctions.gfx[DeveloperReport.k];
      XFont xfont435 = xfont2;
      XSolidBrush black414 = XBrushes.Black;
      double rc1_405 = (double) DeveloperReport.RC1;
      xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
      double point427 = ((XUnit) ref xunit5).Point;
      xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
      double num515 = ((XUnit) ref xunit5).Point / 2.0;
      XRect xrect427 = new XRect(20.0, rc1_405, point427, num515);
      XStringFormat topLeft427 = XStringFormat.TopLeft;
      xgraphics427.DrawString("Water heating:", xfont435, (XBrush) black414, xrect427, topLeft427);
      DeveloperReport.CheckRC1();
      // ISSUE: reference to a compiler-generated field
      if ((double) SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Water.Cylinder.Volume != 0.0)
      {
        XGraphics xgraphics428 = PDFFunctions.gfx[DeveloperReport.k];
        XFont xfont436 = xfont2;
        XSolidBrush black415 = XBrushes.Black;
        double rc1_406 = (double) DeveloperReport.RC1;
        xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
        double point428 = ((XUnit) ref xunit5).Point;
        xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
        double num516 = ((XUnit) ref xunit5).Point / 2.0;
        XRect xrect428 = new XRect(200.0, rc1_406, point428, num516);
        XStringFormat topLeft428 = XStringFormat.TopLeft;
        xgraphics428.DrawString("Hot water cylinder", xfont436, (XBrush) black415, xrect428, topLeft428);
        checked { DeveloperReport.RC1 += 12; }
        DeveloperReport.CheckRC1();
        XGraphics xgraphics429 = PDFFunctions.gfx[DeveloperReport.k];
        // ISSUE: reference to a compiler-generated field
        string str221 = "Cylinder volume: " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Water.Cylinder.Volume) + " litres";
        XFont xfont437 = xfont2;
        XSolidBrush black416 = XBrushes.Black;
        double rc1_407 = (double) DeveloperReport.RC1;
        xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
        double point429 = ((XUnit) ref xunit5).Point;
        xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
        double num517 = ((XUnit) ref xunit5).Point / 2.0;
        XRect xrect429 = new XRect(200.0, rc1_407, point429, num517);
        XStringFormat topLeft429 = XStringFormat.TopLeft;
        xgraphics429.DrawString(str221, xfont437, (XBrush) black416, xrect429, topLeft429);
        checked { DeveloperReport.RC1 += 12; }
        DeveloperReport.CheckRC1();
        // ISSUE: reference to a compiler-generated field
        if (SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Water.Cylinder.ManuSpecified)
        {
          XGraphics xgraphics430 = PDFFunctions.gfx[DeveloperReport.k];
          // ISSUE: reference to a compiler-generated field
          string str222 = "Cylinder insulation: Measured loss, " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Water.Cylinder.DeclaredLoss) + "kWh/day";
          XFont xfont438 = xfont2;
          XSolidBrush black417 = XBrushes.Black;
          double rc1_408 = (double) DeveloperReport.RC1;
          xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point430 = ((XUnit) ref xunit5).Point;
          xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num518 = ((XUnit) ref xunit5).Point / 2.0;
          XRect xrect430 = new XRect(200.0, rc1_408, point430, num518);
          XStringFormat topLeft430 = XStringFormat.TopLeft;
          xgraphics430.DrawString(str222, xfont438, (XBrush) black417, xrect430, topLeft430);
          checked { DeveloperReport.RC1 += 12; }
          DeveloperReport.CheckRC1();
        }
        else
        {
          XGraphics xgraphics431 = PDFFunctions.gfx[DeveloperReport.k];
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          string str223 = "Cylinder insulation: " + SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Water.Cylinder.Insulation + " " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Water.Cylinder.InsThick) + " mm";
          XFont xfont439 = xfont2;
          XSolidBrush black418 = XBrushes.Black;
          double rc1_409 = (double) DeveloperReport.RC1;
          xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point431 = ((XUnit) ref xunit5).Point;
          xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num519 = ((XUnit) ref xunit5).Point / 2.0;
          XRect xrect431 = new XRect(200.0, rc1_409, point431, num519);
          XStringFormat topLeft431 = XStringFormat.TopLeft;
          xgraphics431.DrawString(str223, xfont439, (XBrush) black418, xrect431, topLeft431);
          checked { DeveloperReport.RC1 += 12; }
          DeveloperReport.CheckRC1();
        }
        XGraphics xgraphics432 = PDFFunctions.gfx[DeveloperReport.k];
        // ISSUE: reference to a compiler-generated field
        string str224 = "Primary pipework insulation: " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Water.Cylinder.PipeWorkInsulated);
        XFont xfont440 = xfont2;
        XSolidBrush black419 = XBrushes.Black;
        double rc1_410 = (double) DeveloperReport.RC1;
        xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
        double point432 = ((XUnit) ref xunit5).Point;
        xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
        double num520 = ((XUnit) ref xunit5).Point / 2.0;
        XRect xrect432 = new XRect(200.0, rc1_410, point432, num520);
        XStringFormat topLeft432 = XStringFormat.TopLeft;
        xgraphics432.DrawString(str224, xfont440, (XBrush) black419, xrect432, topLeft432);
        checked { DeveloperReport.RC1 += 12; }
        DeveloperReport.CheckRC1();
        XGraphics xgraphics433 = PDFFunctions.gfx[DeveloperReport.k];
        // ISSUE: reference to a compiler-generated field
        string str225 = "Cylinderstat: " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Water.Cylinder.Thermostat);
        XFont xfont441 = xfont2;
        XSolidBrush black420 = XBrushes.Black;
        double rc1_411 = (double) DeveloperReport.RC1;
        xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
        double point433 = ((XUnit) ref xunit5).Point;
        xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
        double num521 = ((XUnit) ref xunit5).Point / 2.0;
        XRect xrect433 = new XRect(200.0, rc1_411, point433, num521);
        XStringFormat topLeft433 = XStringFormat.TopLeft;
        xgraphics433.DrawString(str225, xfont441, (XBrush) black420, xrect433, topLeft433);
        checked { DeveloperReport.RC1 += 12; }
        DeveloperReport.CheckRC1();
        XGraphics xgraphics434 = PDFFunctions.gfx[DeveloperReport.k];
        // ISSUE: reference to a compiler-generated field
        string str226 = "Cylinder in heated space: " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Water.Cylinder.InHeatedSpace);
        XFont xfont442 = xfont2;
        XSolidBrush black421 = XBrushes.Black;
        double rc1_412 = (double) DeveloperReport.RC1;
        xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
        double point434 = ((XUnit) ref xunit5).Point;
        xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
        double num522 = ((XUnit) ref xunit5).Point / 2.0;
        XRect xrect434 = new XRect(200.0, rc1_412, point434, num522);
        XStringFormat topLeft434 = XStringFormat.TopLeft;
        xgraphics434.DrawString(str226, xfont442, (XBrush) black421, xrect434, topLeft434);
        checked { DeveloperReport.RC1 += 12; }
        DeveloperReport.CheckRC1();
        // ISSUE: reference to a compiler-generated field
        if ((uint) Operators.CompareString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Water.Cylinder.Immersion, "", false) > 0U)
        {
          XGraphics xgraphics435 = PDFFunctions.gfx[DeveloperReport.k];
          string str227 = "Immersion: " + SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.Immersion;
          XFont xfont443 = xfont2;
          XSolidBrush black422 = XBrushes.Black;
          double rc1_413 = (double) DeveloperReport.RC1;
          xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point435 = ((XUnit) ref xunit5).Point;
          xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num523 = ((XUnit) ref xunit5).Point / 2.0;
          XRect xrect435 = new XRect(200.0, rc1_413, point435, num523);
          XStringFormat topLeft435 = XStringFormat.TopLeft;
          xgraphics435.DrawString(str227, xfont443, (XBrush) black422, xrect435, topLeft435);
          checked { DeveloperReport.RC1 += 12; }
          DeveloperReport.CheckRC1();
        }
      }
      else
      {
        XGraphics xgraphics436 = PDFFunctions.gfx[DeveloperReport.k];
        XFont xfont444 = xfont2;
        XSolidBrush black423 = XBrushes.Black;
        double rc1_414 = (double) DeveloperReport.RC1;
        xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
        double point436 = ((XUnit) ref xunit5).Point;
        xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
        double num524 = ((XUnit) ref xunit5).Point / 2.0;
        XRect xrect436 = new XRect(200.0, rc1_414, point436, num524);
        XStringFormat topLeft436 = XStringFormat.TopLeft;
        xgraphics436.DrawString("No hot water cylinder", xfont444, (XBrush) black423, xrect436, topLeft436);
        checked { DeveloperReport.RC1 += 12; }
        DeveloperReport.CheckRC1();
      }
      DeveloperReport.CheckRC1();
      DeveloperReport.CreateBox();
      DeveloperReport.CheckRC1();
      // ISSUE: reference to a compiler-generated field
      if (SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Water.FGHRS.Include)
      {
        XGraphics xgraphics437 = PDFFunctions.gfx[DeveloperReport.k];
        XFont xfont445 = xfont2;
        XSolidBrush black424 = XBrushes.Black;
        double rc1_415 = (double) DeveloperReport.RC1;
        xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
        double point437 = ((XUnit) ref xunit5).Point;
        xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
        double num525 = ((XUnit) ref xunit5).Point / 2.0;
        XRect xrect437 = new XRect(200.0, rc1_415, point437, num525);
        XStringFormat topLeft437 = XStringFormat.TopLeft;
        xgraphics437.DrawString("Flue Gas Heat Recovery System:", xfont445, (XBrush) black424, xrect437, topLeft437);
        checked { DeveloperReport.RC1 += 12; }
        DeveloperReport.CheckRC1();
        try
        {
          // ISSUE: reference to a compiler-generated method
          PCDF.FGHRS fghrs = SAP_Module.PCDFData.FGHRSs.Where<PCDF.FGHRS>(new Func<PCDF.FGHRS, bool>(closure140_2._Lambda\u0024__24)).SingleOrDefault<PCDF.FGHRS>();
          XGraphics xgraphics438 = PDFFunctions.gfx[DeveloperReport.k];
          // ISSUE: reference to a compiler-generated field
          string str228 = "Database (rev " + Conversions.ToString(SAP_Module.DataBVersion) + ", product index " + SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Water.FGHRS.IndexNo + ")";
          XFont xfont446 = xfont2;
          XSolidBrush black425 = XBrushes.Black;
          double rc1_416 = (double) DeveloperReport.RC1;
          xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point438 = ((XUnit) ref xunit5).Point;
          xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num526 = ((XUnit) ref xunit5).Point / 2.0;
          XRect xrect438 = new XRect(205.0, rc1_416, point438, num526);
          XStringFormat topLeft438 = XStringFormat.TopLeft;
          xgraphics438.DrawString(str228, xfont446, (XBrush) black425, xrect438, topLeft438);
          checked { DeveloperReport.RC1 += 12; }
          DeveloperReport.CheckRC1();
          XGraphics xgraphics439 = PDFFunctions.gfx[DeveloperReport.k];
          string str229 = "Brand name: " + fghrs.Brand;
          XFont xfont447 = xfont2;
          XSolidBrush black426 = XBrushes.Black;
          double rc1_417 = (double) DeveloperReport.RC1;
          xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point439 = ((XUnit) ref xunit5).Point;
          xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num527 = ((XUnit) ref xunit5).Point / 2.0;
          XRect xrect439 = new XRect(205.0, rc1_417, point439, num527);
          XStringFormat topLeft439 = XStringFormat.TopLeft;
          xgraphics439.DrawString(str229, xfont447, (XBrush) black426, xrect439, topLeft439);
          checked { DeveloperReport.RC1 += 12; }
          DeveloperReport.CheckRC1();
          XGraphics xgraphics440 = PDFFunctions.gfx[DeveloperReport.k];
          string str230 = "Model: " + fghrs.Model;
          XFont xfont448 = xfont2;
          XSolidBrush black427 = XBrushes.Black;
          double rc1_418 = (double) DeveloperReport.RC1;
          xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point440 = ((XUnit) ref xunit5).Point;
          xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num528 = ((XUnit) ref xunit5).Point / 2.0;
          XRect xrect440 = new XRect(205.0, rc1_418, point440, num528);
          XStringFormat topLeft440 = XStringFormat.TopLeft;
          xgraphics440.DrawString(str230, xfont448, (XBrush) black427, xrect440, topLeft440);
          checked { DeveloperReport.RC1 += 12; }
          DeveloperReport.CheckRC1();
          XGraphics xgraphics441 = PDFFunctions.gfx[DeveloperReport.k];
          string str231 = "Model qualifier: " + fghrs.Model_Qualifier;
          XFont xfont449 = xfont2;
          XSolidBrush black428 = XBrushes.Black;
          double rc1_419 = (double) DeveloperReport.RC1;
          xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point441 = ((XUnit) ref xunit5).Point;
          xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num529 = ((XUnit) ref xunit5).Point / 2.0;
          XRect xrect441 = new XRect(205.0, rc1_419, point441, num529);
          XStringFormat topLeft441 = XStringFormat.TopLeft;
          xgraphics441.DrawString(str231, xfont449, (XBrush) black428, xrect441, topLeft441);
          checked { DeveloperReport.RC1 += 13; }
          DeveloperReport.CheckRC1();
          DeveloperReport.CreateBox();
          DeveloperReport.CheckRC1();
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        DeveloperReport.CheckRC1();
      }
      // ISSUE: reference to a compiler-generated field
      if (SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Water.WWHRS.Include)
      {
        XGraphics xgraphics442 = PDFFunctions.gfx[DeveloperReport.k];
        XFont xfont450 = xfont2;
        XSolidBrush black429 = XBrushes.Black;
        double rc1_420 = (double) DeveloperReport.RC1;
        xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
        double point442 = ((XUnit) ref xunit5).Point;
        xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
        double num530 = ((XUnit) ref xunit5).Point / 2.0;
        XRect xrect442 = new XRect(200.0, rc1_420, point442, num530);
        XStringFormat topLeft442 = XStringFormat.TopLeft;
        xgraphics442.DrawString("Waste Water Heat Recovery System:", xfont450, (XBrush) black429, xrect442, topLeft442);
        checked { DeveloperReport.RC1 += 12; }
        DeveloperReport.CheckRC1();
        XGraphics xgraphics443 = PDFFunctions.gfx[DeveloperReport.k];
        // ISSUE: reference to a compiler-generated field
        string str232 = "Total rooms with shower and/or bath: " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Water.WWHRS.TotalRooms);
        XFont xfont451 = xfont2;
        XSolidBrush black430 = XBrushes.Black;
        double rc1_421 = (double) DeveloperReport.RC1;
        xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
        double point443 = ((XUnit) ref xunit5).Point;
        xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
        double num531 = ((XUnit) ref xunit5).Point / 2.0;
        XRect xrect443 = new XRect(205.0, rc1_421, point443, num531);
        XStringFormat topLeft443 = XStringFormat.TopLeft;
        xgraphics443.DrawString(str232, xfont451, (XBrush) black430, xrect443, topLeft443);
        checked { DeveloperReport.RC1 += 12; }
        DeveloperReport.CheckRC1();
        // ISSUE: reference to a compiler-generated method
        PCDF.WWHRS wwhrs1 = SAP_Module.PCDFData.WWHRSs.Where<PCDF.WWHRS>(new Func<PCDF.WWHRS, bool>(closure140_2._Lambda\u0024__25)).SingleOrDefault<PCDF.WWHRS>();
        XGraphics xgraphics444 = PDFFunctions.gfx[DeveloperReport.k];
        // ISSUE: reference to a compiler-generated field
        string str233 = "Product index: " + SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Water.WWHRS.Systems[0].SystemsRef + ", " + wwhrs1.Brand + " " + wwhrs1.Model + " " + wwhrs1.Model_Qualifier;
        XFont xfont452 = xfont2;
        XSolidBrush black431 = XBrushes.Black;
        double rc1_422 = (double) DeveloperReport.RC1;
        xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
        double point444 = ((XUnit) ref xunit5).Point;
        xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
        double num532 = ((XUnit) ref xunit5).Point / 2.0;
        XRect xrect444 = new XRect(205.0, rc1_422, point444, num532);
        XStringFormat topLeft444 = XStringFormat.TopLeft;
        xgraphics444.DrawString(str233, xfont452, (XBrush) black431, xrect444, topLeft444);
        checked { DeveloperReport.RC1 += 12; }
        DeveloperReport.CheckRC1();
        XGraphics xgraphics445 = PDFFunctions.gfx[DeveloperReport.k];
        // ISSUE: reference to a compiler-generated field
        string str234 = "Number of mixer showers in rooms with a bath: " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Water.WWHRS.Systems[0].WithBath);
        XFont xfont453 = xfont2;
        XSolidBrush black432 = XBrushes.Black;
        double rc1_423 = (double) DeveloperReport.RC1;
        xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
        double point445 = ((XUnit) ref xunit5).Point;
        xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
        double num533 = ((XUnit) ref xunit5).Point / 2.0;
        XRect xrect445 = new XRect(210.0, rc1_423, point445, num533);
        XStringFormat topLeft445 = XStringFormat.TopLeft;
        xgraphics445.DrawString(str234, xfont453, (XBrush) black432, xrect445, topLeft445);
        checked { DeveloperReport.RC1 += 12; }
        DeveloperReport.CheckRC1();
        XGraphics xgraphics446 = PDFFunctions.gfx[DeveloperReport.k];
        // ISSUE: reference to a compiler-generated field
        string str235 = "Number of mixer showers in rooms without a bath: " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Water.WWHRS.Systems[0].WithNoBath);
        XFont xfont454 = xfont2;
        XSolidBrush black433 = XBrushes.Black;
        double rc1_424 = (double) DeveloperReport.RC1;
        xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
        double point446 = ((XUnit) ref xunit5).Point;
        xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
        double num534 = ((XUnit) ref xunit5).Point / 2.0;
        XRect xrect446 = new XRect(210.0, rc1_424, point446, num534);
        XStringFormat topLeft446 = XStringFormat.TopLeft;
        xgraphics446.DrawString(str235, xfont454, (XBrush) black433, xrect446, topLeft446);
        checked { DeveloperReport.RC1 += 12; }
        DeveloperReport.CheckRC1();
        // ISSUE: reference to a compiler-generated field
        if ((uint) Operators.CompareString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Water.WWHRS.Systems[1].SystemsRef, "", false) > 0U)
        {
          // ISSUE: reference to a compiler-generated method
          PCDF.WWHRS wwhrs2 = SAP_Module.PCDFData.WWHRSs.Where<PCDF.WWHRS>(new Func<PCDF.WWHRS, bool>(closure140_2._Lambda\u0024__26)).SingleOrDefault<PCDF.WWHRS>();
          XGraphics xgraphics447 = PDFFunctions.gfx[DeveloperReport.k];
          // ISSUE: reference to a compiler-generated field
          string str236 = "Product index: " + SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Water.WWHRS.Systems[1].SystemsRef + ", " + wwhrs2.Brand + " " + wwhrs2.Model + " " + wwhrs2.Model_Qualifier;
          XFont xfont455 = xfont2;
          XSolidBrush black434 = XBrushes.Black;
          double rc1_425 = (double) DeveloperReport.RC1;
          xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point447 = ((XUnit) ref xunit5).Point;
          xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num535 = ((XUnit) ref xunit5).Point / 2.0;
          XRect xrect447 = new XRect(205.0, rc1_425, point447, num535);
          XStringFormat topLeft447 = XStringFormat.TopLeft;
          xgraphics447.DrawString(str236, xfont455, (XBrush) black434, xrect447, topLeft447);
          checked { DeveloperReport.RC1 += 12; }
          DeveloperReport.CheckRC1();
          XGraphics xgraphics448 = PDFFunctions.gfx[DeveloperReport.k];
          // ISSUE: reference to a compiler-generated field
          string str237 = "Number of mixer showers in rooms with a bath: " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Water.WWHRS.Systems[1].WithBath);
          XFont xfont456 = xfont2;
          XSolidBrush black435 = XBrushes.Black;
          double rc1_426 = (double) DeveloperReport.RC1;
          xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point448 = ((XUnit) ref xunit5).Point;
          xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num536 = ((XUnit) ref xunit5).Point / 2.0;
          XRect xrect448 = new XRect(210.0, rc1_426, point448, num536);
          XStringFormat topLeft448 = XStringFormat.TopLeft;
          xgraphics448.DrawString(str237, xfont456, (XBrush) black435, xrect448, topLeft448);
          checked { DeveloperReport.RC1 += 12; }
          DeveloperReport.CheckRC1();
          XGraphics xgraphics449 = PDFFunctions.gfx[DeveloperReport.k];
          // ISSUE: reference to a compiler-generated field
          string str238 = "Number of mixer showers in rooms without a bath: " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Water.WWHRS.Systems[1].WithNoBath);
          XFont xfont457 = xfont2;
          XSolidBrush black436 = XBrushes.Black;
          double rc1_427 = (double) DeveloperReport.RC1;
          xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point449 = ((XUnit) ref xunit5).Point;
          xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num537 = ((XUnit) ref xunit5).Point / 2.0;
          XRect xrect449 = new XRect(210.0, rc1_427, point449, num537);
          XStringFormat topLeft449 = XStringFormat.TopLeft;
          xgraphics449.DrawString(str238, xfont457, (XBrush) black436, xrect449, topLeft449);
          checked { DeveloperReport.RC1 += 12; }
          DeveloperReport.CheckRC1();
          DeveloperReport.CreateBox();
          DeveloperReport.CheckRC1();
        }
      }
      XGraphics xgraphics450 = PDFFunctions.gfx[DeveloperReport.k];
      // ISSUE: reference to a compiler-generated field
      string str239 = "Solar panel: " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Water.Solar.Inlcude);
      XFont xfont458 = xfont2;
      XSolidBrush black437 = XBrushes.Black;
      double rc1_428 = (double) DeveloperReport.RC1;
      xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
      double point450 = ((XUnit) ref xunit5).Point;
      xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
      double num538 = ((XUnit) ref xunit5).Point / 2.0;
      XRect xrect450 = new XRect(200.0, rc1_428, point450, num538);
      XStringFormat topLeft450 = XStringFormat.TopLeft;
      xgraphics450.DrawString(str239, xfont458, (XBrush) black437, xrect450, topLeft450);
      // ISSUE: reference to a compiler-generated field
      if (SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Water.Solar.Inlcude)
      {
        checked { DeveloperReport.RC1 += 12; }
        DeveloperReport.CheckRC1();
        XGraphics xgraphics451 = PDFFunctions.gfx[DeveloperReport.k];
        // ISSUE: reference to a compiler-generated field
        string str240 = "aperture area: " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Water.Solar.SolarArea);
        XFont xfont459 = xfont2;
        XSolidBrush black438 = XBrushes.Black;
        double rc1_429 = (double) DeveloperReport.RC1;
        xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
        double point451 = ((XUnit) ref xunit5).Point;
        xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
        double num539 = ((XUnit) ref xunit5).Point / 2.0;
        XRect xrect451 = new XRect(205.0, rc1_429, point451, num539);
        XStringFormat topLeft451 = XStringFormat.TopLeft;
        xgraphics451.DrawString(str240, xfont459, (XBrush) black438, xrect451, topLeft451);
        checked { DeveloperReport.RC1 += 12; }
        DeveloperReport.CheckRC1();
        XGraphics xgraphics452 = PDFFunctions.gfx[DeveloperReport.k];
        // ISSUE: reference to a compiler-generated field
        string solarType = SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Water.Solar.SolarType;
        XFont xfont460 = xfont2;
        XSolidBrush black439 = XBrushes.Black;
        double rc1_430 = (double) DeveloperReport.RC1;
        xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
        double point452 = ((XUnit) ref xunit5).Point;
        xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
        double num540 = ((XUnit) ref xunit5).Point / 2.0;
        XRect xrect452 = new XRect(205.0, rc1_430, point452, num540);
        XStringFormat topLeft452 = XStringFormat.TopLeft;
        xgraphics452.DrawString(solarType, xfont460, (XBrush) black439, xrect452, topLeft452);
        checked { DeveloperReport.RC1 += 12; }
        DeveloperReport.CheckRC1();
        XGraphics xgraphics453 = PDFFunctions.gfx[DeveloperReport.k];
        // ISSUE: reference to a compiler-generated field
        string str241 = "default values: " + Conversions.ToString(!SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Water.Solar.Overide);
        XFont xfont461 = xfont2;
        XSolidBrush black440 = XBrushes.Black;
        double rc1_431 = (double) DeveloperReport.RC1;
        xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
        double point453 = ((XUnit) ref xunit5).Point;
        xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
        double num541 = ((XUnit) ref xunit5).Point / 2.0;
        XRect xrect453 = new XRect(205.0, rc1_431, point453, num541);
        XStringFormat topLeft453 = XStringFormat.TopLeft;
        xgraphics453.DrawString(str241, xfont461, (XBrush) black440, xrect453, topLeft453);
        checked { DeveloperReport.RC1 += 12; }
        DeveloperReport.CheckRC1();
        XGraphics xgraphics454 = PDFFunctions.gfx[DeveloperReport.k];
        // ISSUE: reference to a compiler-generated field
        string str242 = "collector zero-loss efficiency: " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Water.Solar.SolarZero);
        XFont xfont462 = xfont2;
        XSolidBrush black441 = XBrushes.Black;
        double rc1_432 = (double) DeveloperReport.RC1;
        xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
        double point454 = ((XUnit) ref xunit5).Point;
        xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
        double num542 = ((XUnit) ref xunit5).Point / 2.0;
        XRect xrect454 = new XRect(205.0, rc1_432, point454, num542);
        XStringFormat topLeft454 = XStringFormat.TopLeft;
        xgraphics454.DrawString(str242, xfont462, (XBrush) black441, xrect454, topLeft454);
        checked { DeveloperReport.RC1 += 12; }
        DeveloperReport.CheckRC1();
        XGraphics xgraphics455 = PDFFunctions.gfx[DeveloperReport.k];
        // ISSUE: reference to a compiler-generated field
        string str243 = "collector heat loss coefficient: " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Water.Solar.SolarHLoss);
        XFont xfont463 = xfont2;
        XSolidBrush black442 = XBrushes.Black;
        double rc1_433 = (double) DeveloperReport.RC1;
        xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
        double point455 = ((XUnit) ref xunit5).Point;
        xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
        double num543 = ((XUnit) ref xunit5).Point / 2.0;
        XRect xrect455 = new XRect(205.0, rc1_433, point455, num543);
        XStringFormat topLeft455 = XStringFormat.TopLeft;
        xgraphics455.DrawString(str243, xfont463, (XBrush) black442, xrect455, topLeft455);
        checked { DeveloperReport.RC1 += 12; }
        DeveloperReport.CheckRC1();
        XGraphics xgraphics456 = PDFFunctions.gfx[DeveloperReport.k];
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        string str244 = "orientation: " + SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Water.Solar.SolarOrientation + ", " + SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Water.Solar.SolarTilt + " pitch";
        XFont xfont464 = xfont2;
        XSolidBrush black443 = XBrushes.Black;
        double rc1_434 = (double) DeveloperReport.RC1;
        xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
        double point456 = ((XUnit) ref xunit5).Point;
        xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
        double num544 = ((XUnit) ref xunit5).Point / 2.0;
        XRect xrect456 = new XRect(205.0, rc1_434, point456, num544);
        XStringFormat topLeft456 = XStringFormat.TopLeft;
        xgraphics456.DrawString(str244, xfont464, (XBrush) black443, xrect456, topLeft456);
        checked { DeveloperReport.RC1 += 12; }
        DeveloperReport.CheckRC1();
        XGraphics xgraphics457 = PDFFunctions.gfx[DeveloperReport.k];
        // ISSUE: reference to a compiler-generated field
        string str245 = "overshading: " + SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Water.Solar.SolarOvershading;
        XFont xfont465 = xfont2;
        XSolidBrush black444 = XBrushes.Black;
        double rc1_435 = (double) DeveloperReport.RC1;
        xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
        double point457 = ((XUnit) ref xunit5).Point;
        xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
        double num545 = ((XUnit) ref xunit5).Point / 2.0;
        XRect xrect457 = new XRect(205.0, rc1_435, point457, num545);
        XStringFormat topLeft457 = XStringFormat.TopLeft;
        xgraphics457.DrawString(str245, xfont465, (XBrush) black444, xrect457, topLeft457);
        checked { DeveloperReport.RC1 += 12; }
        DeveloperReport.CheckRC1();
        // ISSUE: reference to a compiler-generated field
        if (!SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Water.Solar.SolarSeperate)
        {
          XGraphics xgraphics458 = PDFFunctions.gfx[DeveloperReport.k];
          // ISSUE: reference to a compiler-generated field
          string str246 = "dedicated solar store volume: " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Water.Solar.SolarVolume) + " litres (combined store)";
          XFont xfont466 = xfont2;
          XSolidBrush black445 = XBrushes.Black;
          double rc1_436 = (double) DeveloperReport.RC1;
          xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point458 = ((XUnit) ref xunit5).Point;
          xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num546 = ((XUnit) ref xunit5).Point / 2.0;
          XRect xrect458 = new XRect(205.0, rc1_436, point458, num546);
          XStringFormat topLeft458 = XStringFormat.TopLeft;
          xgraphics458.DrawString(str246, xfont466, (XBrush) black445, xrect458, topLeft458);
        }
        else
        {
          XGraphics xgraphics459 = PDFFunctions.gfx[DeveloperReport.k];
          // ISSUE: reference to a compiler-generated field
          string str247 = "dedicated solar store volume: " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Water.Solar.SolarVolume) + " litres (seperate store)";
          XFont xfont467 = xfont2;
          XSolidBrush black446 = XBrushes.Black;
          double rc1_437 = (double) DeveloperReport.RC1;
          xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point459 = ((XUnit) ref xunit5).Point;
          xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num547 = ((XUnit) ref xunit5).Point / 2.0;
          XRect xrect459 = new XRect(205.0, rc1_437, point459, num547);
          XStringFormat topLeft459 = XStringFormat.TopLeft;
          xgraphics459.DrawString(str247, xfont467, (XBrush) black446, xrect459, topLeft459);
        }
        checked { DeveloperReport.RC1 += 12; }
        DeveloperReport.CheckRC1();
        XGraphics xgraphics460 = PDFFunctions.gfx[DeveloperReport.k];
        // ISSUE: reference to a compiler-generated field
        string str248 = "solar powered pump: " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Water.Solar.Pumped);
        XFont xfont468 = xfont2;
        XSolidBrush black447 = XBrushes.Black;
        double rc1_438 = (double) DeveloperReport.RC1;
        xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
        double point460 = ((XUnit) ref xunit5).Point;
        xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
        double num548 = ((XUnit) ref xunit5).Point / 2.0;
        XRect xrect460 = new XRect(205.0, rc1_438, point460, num548);
        XStringFormat topLeft460 = XStringFormat.TopLeft;
        xgraphics460.DrawString(str248, xfont468, (XBrush) black447, xrect460, topLeft460);
        DeveloperReport.CheckRC1();
        DeveloperReport.CreateBox();
        DeveloperReport.CheckRC1();
      }
      checked { DeveloperReport.RC1 += 12; }
      DeveloperReport.CheckRC1();
      PDFFunctions.xBrush1 = XBrush.op_Implicit((Brush) new SolidBrush(Color.FromArgb(159, 172, 62)));
      PDFFunctions.Points[0].X = 20f;
      PDFFunctions.Points[0].Y = (float) DeveloperReport.RC1;
      ref PointF local27 = ref PDFFunctions.Points[1];
      xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
      double num549 = ((XUnit) ref xunit5).Point - 20.0;
      local27.X = (float) num549;
      PDFFunctions.Points[1].Y = (float) DeveloperReport.RC1;
      ref PointF local28 = ref PDFFunctions.Points[2];
      xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
      double num550 = ((XUnit) ref xunit5).Point - 20.0;
      local28.X = (float) num550;
      PDFFunctions.Points[2].Y = (float) checked (DeveloperReport.RC1 + 16);
      PDFFunctions.Points[3].X = 20f;
      PDFFunctions.Points[3].Y = (float) checked (DeveloperReport.RC1 + 16);
      PDFFunctions.gfx[DeveloperReport.k].DrawPolygon(PDFFunctions.polyGreen2, PDFFunctions.xBrush1, PDFFunctions.Points, xfillMode);
      XGraphics xgraphics461 = PDFFunctions.gfx[DeveloperReport.k];
      XFont xfont469 = xfont3;
      XSolidBrush white14 = XBrushes.White;
      double num551 = (double) checked (DeveloperReport.RC1 + 1);
      xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
      double point461 = ((XUnit) ref xunit5).Point;
      xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
      double num552 = ((XUnit) ref xunit5).Point / 2.0;
      XRect xrect461 = new XRect(25.0, num551, point461, num552);
      XStringFormat topLeft461 = XStringFormat.TopLeft;
      xgraphics461.DrawString("Others:", xfont469, (XBrush) white14, xrect461, topLeft461);
      DeveloperReport.RC1 = checked ((int) Math.Round(unchecked ((double) PDFFunctions.Points[3].Y + 6.0)));
      XGraphics xgraphics462 = PDFFunctions.gfx[DeveloperReport.k];
      XFont xfont470 = xfont2;
      XSolidBrush black448 = XBrushes.Black;
      double rc1_439 = (double) DeveloperReport.RC1;
      xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
      double point462 = ((XUnit) ref xunit5).Point;
      xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
      double num553 = ((XUnit) ref xunit5).Point / 2.0;
      XRect xrect462 = new XRect(20.0, rc1_439, point462, num553);
      XStringFormat topLeft462 = XStringFormat.TopLeft;
      xgraphics462.DrawString("Electricity tariff:", xfont470, (XBrush) black448, xrect462, topLeft462);
      XGraphics xgraphics463 = PDFFunctions.gfx[DeveloperReport.k];
      // ISSUE: reference to a compiler-generated field
      string str249 = Microsoft.VisualBasic.Strings.StrConv(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].MainHeating.ElectricityTariff, VbStrConv.ProperCase);
      XFont xfont471 = xfont2;
      XSolidBrush black449 = XBrushes.Black;
      double rc1_440 = (double) DeveloperReport.RC1;
      xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
      double point463 = ((XUnit) ref xunit5).Point;
      xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
      double num554 = ((XUnit) ref xunit5).Point / 2.0;
      XRect xrect463 = new XRect(200.0, rc1_440, point463, num554);
      XStringFormat topLeft463 = XStringFormat.TopLeft;
      xgraphics463.DrawString(str249, xfont471, (XBrush) black449, xrect463, topLeft463);
      checked { DeveloperReport.RC1 += 12; }
      XGraphics xgraphics464 = PDFFunctions.gfx[DeveloperReport.k];
      XFont xfont472 = xfont2;
      XSolidBrush black450 = XBrushes.Black;
      double rc1_441 = (double) DeveloperReport.RC1;
      xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
      double point464 = ((XUnit) ref xunit5).Point;
      xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
      double num555 = ((XUnit) ref xunit5).Point / 2.0;
      XRect xrect464 = new XRect(20.0, rc1_441, point464, num555);
      XStringFormat topLeft464 = XStringFormat.TopLeft;
      xgraphics464.DrawString("Low energy lights:", xfont472, (XBrush) black450, xrect464, topLeft464);
      XGraphics xgraphics465 = PDFFunctions.gfx[DeveloperReport.k];
      // ISSUE: reference to a compiler-generated field
      string str250 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].LowEnergyLight) + "%";
      XFont xfont473 = xfont2;
      XSolidBrush black451 = XBrushes.Black;
      double rc1_442 = (double) DeveloperReport.RC1;
      xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
      double point465 = ((XUnit) ref xunit5).Point;
      xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
      double num556 = ((XUnit) ref xunit5).Point / 2.0;
      XRect xrect465 = new XRect(200.0, rc1_442, point465, num556);
      XStringFormat topLeft465 = XStringFormat.TopLeft;
      xgraphics465.DrawString(str250, xfont473, (XBrush) black451, xrect465, topLeft465);
      checked { DeveloperReport.RC1 += 12; }
      DeveloperReport.CheckRC1();
      XGraphics xgraphics466 = PDFFunctions.gfx[DeveloperReport.k];
      XFont xfont474 = xfont2;
      XSolidBrush black452 = XBrushes.Black;
      double rc1_443 = (double) DeveloperReport.RC1;
      xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
      double point466 = ((XUnit) ref xunit5).Point;
      xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
      double num557 = ((XUnit) ref xunit5).Point / 2.0;
      XRect xrect466 = new XRect(20.0, rc1_443, point466, num557);
      XStringFormat topLeft466 = XStringFormat.TopLeft;
      xgraphics466.DrawString("Terrain type:", xfont474, (XBrush) black452, xrect466, topLeft466);
      XGraphics xgraphics467 = PDFFunctions.gfx[DeveloperReport.k];
      // ISSUE: reference to a compiler-generated field
      string terrain = SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Terrain;
      XFont xfont475 = xfont2;
      XSolidBrush black453 = XBrushes.Black;
      double rc1_444 = (double) DeveloperReport.RC1;
      xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
      double point467 = ((XUnit) ref xunit5).Point;
      xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
      double num558 = ((XUnit) ref xunit5).Point / 2.0;
      XRect xrect467 = new XRect(200.0, rc1_444, point467, num558);
      XStringFormat topLeft467 = XStringFormat.TopLeft;
      xgraphics467.DrawString(terrain, xfont475, (XBrush) black453, xrect467, topLeft467);
      checked { DeveloperReport.RC1 += 12; }
      XGraphics xgraphics468 = PDFFunctions.gfx[DeveloperReport.k];
      XFont xfont476 = xfont2;
      XSolidBrush black454 = XBrushes.Black;
      double rc1_445 = (double) DeveloperReport.RC1;
      xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
      double point468 = ((XUnit) ref xunit5).Point;
      xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
      double num559 = ((XUnit) ref xunit5).Point / 2.0;
      XRect xrect468 = new XRect(20.0, rc1_445, point468, num559);
      XStringFormat topLeft468 = XStringFormat.TopLeft;
      xgraphics468.DrawString("Wind turbine:", xfont476, (XBrush) black454, xrect468, topLeft468);
      // ISSUE: reference to a compiler-generated field
      if (SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Renewable.WindTurbine.Inlcude)
      {
        XGraphics xgraphics469 = PDFFunctions.gfx[DeveloperReport.k];
        // ISSUE: reference to a compiler-generated field
        string str251 = "Number of turbines: " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Renewable.WindTurbine.WNumber);
        XFont xfont477 = xfont2;
        XSolidBrush black455 = XBrushes.Black;
        double rc1_446 = (double) DeveloperReport.RC1;
        xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
        double point469 = ((XUnit) ref xunit5).Point;
        xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
        double num560 = ((XUnit) ref xunit5).Point / 2.0;
        XRect xrect469 = new XRect(200.0, rc1_446, point469, num560);
        XStringFormat topLeft469 = XStringFormat.TopLeft;
        xgraphics469.DrawString(str251, xfont477, (XBrush) black455, xrect469, topLeft469);
        checked { DeveloperReport.RC1 += 12; }
        XGraphics xgraphics470 = PDFFunctions.gfx[DeveloperReport.k];
        // ISSUE: reference to a compiler-generated field
        string str252 = "hub height above building: " + SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Renewable.WindTurbine.WHeight;
        XFont xfont478 = xfont2;
        XSolidBrush black456 = XBrushes.Black;
        double rc1_447 = (double) DeveloperReport.RC1;
        xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
        double point470 = ((XUnit) ref xunit5).Point;
        xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
        double num561 = ((XUnit) ref xunit5).Point / 2.0;
        XRect xrect470 = new XRect(200.0, rc1_447, point470, num561);
        XStringFormat topLeft470 = XStringFormat.TopLeft;
        xgraphics470.DrawString(str252, xfont478, (XBrush) black456, xrect470, topLeft470);
        checked { DeveloperReport.RC1 += 12; }
        XGraphics xgraphics471 = PDFFunctions.gfx[DeveloperReport.k];
        // ISSUE: reference to a compiler-generated field
        string str253 = "Rotor diameter: " + SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Renewable.WindTurbine.WRDiameter;
        XFont xfont479 = xfont2;
        XSolidBrush black457 = XBrushes.Black;
        double rc1_448 = (double) DeveloperReport.RC1;
        xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
        double point471 = ((XUnit) ref xunit5).Point;
        xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
        double num562 = ((XUnit) ref xunit5).Point / 2.0;
        XRect xrect471 = new XRect(200.0, rc1_448, point471, num562);
        XStringFormat topLeft471 = XStringFormat.TopLeft;
        xgraphics471.DrawString(str253, xfont479, (XBrush) black457, xrect471, topLeft471);
        checked { DeveloperReport.RC1 += 14; }
      }
      else
      {
        XGraphics xgraphics472 = PDFFunctions.gfx[DeveloperReport.k];
        XFont xfont480 = xfont2;
        XSolidBrush black458 = XBrushes.Black;
        double rc1_449 = (double) DeveloperReport.RC1;
        xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
        double point472 = ((XUnit) ref xunit5).Point;
        xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
        double num563 = ((XUnit) ref xunit5).Point / 2.0;
        XRect xrect472 = new XRect(200.0, rc1_449, point472, num563);
        XStringFormat topLeft472 = XStringFormat.TopLeft;
        xgraphics472.DrawString("No", xfont480, (XBrush) black458, xrect472, topLeft472);
        checked { DeveloperReport.RC1 += 14; }
      }
      DeveloperReport.CheckRC1();
      XGraphics xgraphics473 = PDFFunctions.gfx[DeveloperReport.k];
      XFont xfont481 = xfont2;
      XSolidBrush black459 = XBrushes.Black;
      double rc1_450 = (double) DeveloperReport.RC1;
      xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
      double point473 = ((XUnit) ref xunit5).Point;
      xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
      double num564 = ((XUnit) ref xunit5).Point / 2.0;
      XRect xrect473 = new XRect(20.0, rc1_450, point473, num564);
      XStringFormat topLeft473 = XStringFormat.TopLeft;
      xgraphics473.DrawString("Photovoltaics:", xfont481, (XBrush) black459, xrect473, topLeft473);
      // ISSUE: reference to a compiler-generated field
      if (SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Renewable.Photovoltaic.Inlcude)
      {
        // ISSUE: reference to a compiler-generated field
        int num565 = checked (SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Renewable.Photovoltaic.Photovoltaics.Length - 1);
        int index30 = 0;
        while (index30 <= num565)
        {
          XGraphics xgraphics474 = PDFFunctions.gfx[DeveloperReport.k];
          string str254 = "Photovoltaic " + Conversions.ToString(checked (index30 + 1));
          XFont xfont482 = xfont4;
          XSolidBrush black460 = XBrushes.Black;
          double rc1_451 = (double) DeveloperReport.RC1;
          xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point474 = ((XUnit) ref xunit5).Point;
          xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num566 = ((XUnit) ref xunit5).Point / 2.0;
          XRect xrect474 = new XRect(200.0, rc1_451, point474, num566);
          XStringFormat topLeft474 = XStringFormat.TopLeft;
          xgraphics474.DrawString(str254, xfont482, (XBrush) black460, xrect474, topLeft474);
          checked { DeveloperReport.RC1 += 12; }
          DeveloperReport.CheckRC1();
          XGraphics xgraphics475 = PDFFunctions.gfx[DeveloperReport.k];
          // ISSUE: reference to a compiler-generated field
          string str255 = "Installed Peak power: " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Renewable.Photovoltaic.Photovoltaics[index30].PPower);
          XFont xfont483 = xfont2;
          XSolidBrush black461 = XBrushes.Black;
          double rc1_452 = (double) DeveloperReport.RC1;
          xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point475 = ((XUnit) ref xunit5).Point;
          xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num567 = ((XUnit) ref xunit5).Point / 2.0;
          XRect xrect475 = new XRect(200.0, rc1_452, point475, num567);
          XStringFormat topLeft475 = XStringFormat.TopLeft;
          xgraphics475.DrawString(str255, xfont483, (XBrush) black461, xrect475, topLeft475);
          checked { DeveloperReport.RC1 += 12; }
          DeveloperReport.CheckRC1();
          XGraphics xgraphics476 = PDFFunctions.gfx[DeveloperReport.k];
          // ISSUE: reference to a compiler-generated field
          string str256 = "Tilt of collector: " + SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Renewable.Photovoltaic.Photovoltaics[index30].PTilt;
          XFont xfont484 = xfont2;
          XSolidBrush black462 = XBrushes.Black;
          double rc1_453 = (double) DeveloperReport.RC1;
          xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point476 = ((XUnit) ref xunit5).Point;
          xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num568 = ((XUnit) ref xunit5).Point / 2.0;
          XRect xrect476 = new XRect(200.0, rc1_453, point476, num568);
          XStringFormat topLeft476 = XStringFormat.TopLeft;
          xgraphics476.DrawString(str256, xfont484, (XBrush) black462, xrect476, topLeft476);
          checked { DeveloperReport.RC1 += 12; }
          DeveloperReport.CheckRC1();
          XGraphics xgraphics477 = PDFFunctions.gfx[DeveloperReport.k];
          // ISSUE: reference to a compiler-generated field
          string str257 = "Overshading: " + SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Renewable.Photovoltaic.Photovoltaics[index30].POvershading;
          XFont xfont485 = xfont2;
          XSolidBrush black463 = XBrushes.Black;
          double rc1_454 = (double) DeveloperReport.RC1;
          xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point477 = ((XUnit) ref xunit5).Point;
          xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num569 = ((XUnit) ref xunit5).Point / 2.0;
          XRect xrect477 = new XRect(200.0, rc1_454, point477, num569);
          XStringFormat topLeft477 = XStringFormat.TopLeft;
          xgraphics477.DrawString(str257, xfont485, (XBrush) black463, xrect477, topLeft477);
          checked { DeveloperReport.RC1 += 12; }
          DeveloperReport.CheckRC1();
          XGraphics xgraphics478 = PDFFunctions.gfx[DeveloperReport.k];
          // ISSUE: reference to a compiler-generated field
          string str258 = "Collector Orientation: " + SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Renewable.Photovoltaic.Photovoltaics[index30].PCOrientation;
          XFont xfont486 = xfont2;
          XSolidBrush black464 = XBrushes.Black;
          double rc1_455 = (double) DeveloperReport.RC1;
          xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point478 = ((XUnit) ref xunit5).Point;
          xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num570 = ((XUnit) ref xunit5).Point / 2.0;
          XRect xrect478 = new XRect(200.0, rc1_455, point478, num570);
          XStringFormat topLeft478 = XStringFormat.TopLeft;
          xgraphics478.DrawString(str258, xfont486, (XBrush) black464, xrect478, topLeft478);
          checked { DeveloperReport.RC1 += 14; }
          DeveloperReport.CheckRC1();
          checked { ++index30; }
        }
      }
      else
      {
        XGraphics xgraphics479 = PDFFunctions.gfx[DeveloperReport.k];
        XFont xfont487 = xfont2;
        XSolidBrush black465 = XBrushes.Black;
        double rc1_456 = (double) DeveloperReport.RC1;
        xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
        double point479 = ((XUnit) ref xunit5).Point;
        xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
        double num571 = ((XUnit) ref xunit5).Point / 2.0;
        XRect xrect479 = new XRect(200.0, rc1_456, point479, num571);
        XStringFormat topLeft479 = XStringFormat.TopLeft;
        xgraphics479.DrawString("None", xfont487, (XBrush) black465, xrect479, topLeft479);
        checked { DeveloperReport.RC1 += 14; }
      }
      DeveloperReport.CheckRC1();
      DeveloperReport.CreateBox();
      XGraphics xgraphics480 = PDFFunctions.gfx[DeveloperReport.k];
      XFont xfont488 = xfont2;
      XSolidBrush black466 = XBrushes.Black;
      double num572 = (double) checked (DeveloperReport.RC1 - 73);
      xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
      double point480 = ((XUnit) ref xunit5).Point;
      xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
      double num573 = ((XUnit) ref xunit5).Point / 2.0;
      XRect xrect480 = new XRect(30.0, num572, point480, num573);
      XStringFormat topLeft480 = XStringFormat.TopLeft;
      xgraphics480.DrawString("Please provide the MCS certificate or data sheet equivalent confirming the size of the array on the roof. This should ", xfont488, (XBrush) black466, xrect480, topLeft480);
      XGraphics xgraphics481 = PDFFunctions.gfx[DeveloperReport.k];
      XFont xfont489 = xfont2;
      XSolidBrush black467 = XBrushes.Black;
      double num574 = (double) checked (DeveloperReport.RC1 - 63);
      xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
      double point481 = ((XUnit) ref xunit5).Point;
      xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
      double num575 = ((XUnit) ref xunit5).Point / 2.0;
      XRect xrect481 = new XRect(30.0, num574, point481, num575);
      XStringFormat topLeft481 = XStringFormat.TopLeft;
      xgraphics481.DrawString("include any calculations to support a proportioned amount included in the assessment.", xfont489, (XBrush) black467, xrect481, topLeft481);
      DeveloperReport.CheckRC1();
      // ISSUE: reference to a compiler-generated field
      if (SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Renewable.Special.Include)
      {
        // ISSUE: reference to a compiler-generated field
        int num576 = checked (SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Renewable.Special.Special.Length - 1);
        int index31 = 0;
        while (index31 <= num576)
        {
          XGraphics xgraphics482 = PDFFunctions.gfx[DeveloperReport.k];
          // ISSUE: reference to a compiler-generated field
          string str259 = "Special feature (App. Q): " + SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Renewable.Special.Special[index31].Description;
          XFont xfont490 = xfont4;
          XSolidBrush black468 = XBrushes.Black;
          double rc1_457 = (double) DeveloperReport.RC1;
          xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point482 = ((XUnit) ref xunit5).Point;
          xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num577 = ((XUnit) ref xunit5).Point / 2.0;
          XRect xrect482 = new XRect(20.0, rc1_457, point482, num577);
          XStringFormat topLeft482 = XStringFormat.TopLeft;
          xgraphics482.DrawString(str259, xfont490, (XBrush) black468, xrect482, topLeft482);
          checked { DeveloperReport.RC1 += 12; }
          DeveloperReport.CheckRC1();
          XGraphics xgraphics483 = PDFFunctions.gfx[DeveloperReport.k];
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          string str260 = "Energy saved: " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Renewable.Special.Special[index31].EnergySaved) + " kWh (" + SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Renewable.Special.Special[index31].FuelSaved + ")";
          XFont xfont491 = xfont2;
          XSolidBrush black469 = XBrushes.Black;
          double rc1_458 = (double) DeveloperReport.RC1;
          xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point483 = ((XUnit) ref xunit5).Point;
          xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num578 = ((XUnit) ref xunit5).Point / 2.0;
          XRect xrect483 = new XRect(200.0, rc1_458, point483, num578);
          XStringFormat topLeft483 = XStringFormat.TopLeft;
          xgraphics483.DrawString(str260, xfont491, (XBrush) black469, xrect483, topLeft483);
          checked { DeveloperReport.RC1 += 12; }
          DeveloperReport.CheckRC1();
          XGraphics xgraphics484 = PDFFunctions.gfx[DeveloperReport.k];
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          string str261 = "Energy used: " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Renewable.Special.Special[index31].EnergyUsed) + " kWh (" + SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Renewable.Special.Special[index31].FuelUsed + ")";
          XFont xfont492 = xfont2;
          XSolidBrush black470 = XBrushes.Black;
          double rc1_459 = (double) DeveloperReport.RC1;
          xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point484 = ((XUnit) ref xunit5).Point;
          xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
          double num579 = ((XUnit) ref xunit5).Point / 2.0;
          XRect xrect484 = new XRect(200.0, rc1_459, point484, num579);
          XStringFormat topLeft484 = XStringFormat.TopLeft;
          xgraphics484.DrawString(str261, xfont492, (XBrush) black470, xrect484, topLeft484);
          // ISSUE: reference to a compiler-generated field
          if (SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Renewable.Special.Special[index31].IncludeMonthly)
          {
            XSize pageSize = PDFFunctions.gfx[DeveloperReport.k].PageSize;
            float num580 = (float) ((((XSize) ref pageSize).Width - 40.0) / 12.0);
            checked { DeveloperReport.RC1 += 12; }
            DeveloperReport.CheckRC1();
            XGraphics xgraphics485 = PDFFunctions.gfx[DeveloperReport.k];
            // ISSUE: reference to a compiler-generated field
            string str262 = "Air change rates (January to December): " + SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Renewable.Special.Special[index31].Description;
            XFont xfont493 = xfont4;
            XSolidBrush black471 = XBrushes.Black;
            double rc1_460 = (double) DeveloperReport.RC1;
            xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
            double point485 = ((XUnit) ref xunit5).Point;
            xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
            double num581 = ((XUnit) ref xunit5).Point / 2.0;
            XRect xrect485 = new XRect(20.0, rc1_460, point485, num581);
            XStringFormat topLeft485 = XStringFormat.TopLeft;
            xgraphics485.DrawString(str262, xfont493, (XBrush) black471, xrect485, topLeft485);
            checked { DeveloperReport.RC1 += 12; }
            DeveloperReport.CheckRC1();
            XGraphics xgraphics486 = PDFFunctions.gfx[DeveloperReport.k];
            XFont xfont494 = xfont2;
            XSolidBrush black472 = XBrushes.Black;
            double rc1_461 = (double) DeveloperReport.RC1;
            xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
            double point486 = ((XUnit) ref xunit5).Point;
            xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
            double num582 = ((XUnit) ref xunit5).Point / 2.0;
            XRect xrect486 = new XRect(20.0, rc1_461, point486, num582);
            XStringFormat topLeft486 = XStringFormat.TopLeft;
            xgraphics486.DrawString("Jan", xfont494, (XBrush) black472, xrect486, topLeft486);
            XGraphics xgraphics487 = PDFFunctions.gfx[DeveloperReport.k];
            XFont xfont495 = xfont2;
            XSolidBrush black473 = XBrushes.Black;
            double num583 = 20.0 + 1.0 * (double) num580;
            double rc1_462 = (double) DeveloperReport.RC1;
            xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
            double point487 = ((XUnit) ref xunit5).Point;
            xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
            double num584 = ((XUnit) ref xunit5).Point / 2.0;
            XRect xrect487 = new XRect(num583, rc1_462, point487, num584);
            XStringFormat topLeft487 = XStringFormat.TopLeft;
            xgraphics487.DrawString("Feb", xfont495, (XBrush) black473, xrect487, topLeft487);
            XGraphics xgraphics488 = PDFFunctions.gfx[DeveloperReport.k];
            XFont xfont496 = xfont2;
            XSolidBrush black474 = XBrushes.Black;
            double num585 = 20.0 + 2.0 * (double) num580;
            double rc1_463 = (double) DeveloperReport.RC1;
            xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
            double point488 = ((XUnit) ref xunit5).Point;
            xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
            double num586 = ((XUnit) ref xunit5).Point / 2.0;
            XRect xrect488 = new XRect(num585, rc1_463, point488, num586);
            XStringFormat topLeft488 = XStringFormat.TopLeft;
            xgraphics488.DrawString("March", xfont496, (XBrush) black474, xrect488, topLeft488);
            XGraphics xgraphics489 = PDFFunctions.gfx[DeveloperReport.k];
            XFont xfont497 = xfont2;
            XSolidBrush black475 = XBrushes.Black;
            double num587 = 20.0 + 3.0 * (double) num580;
            double rc1_464 = (double) DeveloperReport.RC1;
            xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
            double point489 = ((XUnit) ref xunit5).Point;
            xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
            double num588 = ((XUnit) ref xunit5).Point / 2.0;
            XRect xrect489 = new XRect(num587, rc1_464, point489, num588);
            XStringFormat topLeft489 = XStringFormat.TopLeft;
            xgraphics489.DrawString("April", xfont497, (XBrush) black475, xrect489, topLeft489);
            XGraphics xgraphics490 = PDFFunctions.gfx[DeveloperReport.k];
            XFont xfont498 = xfont2;
            XSolidBrush black476 = XBrushes.Black;
            double num589 = 20.0 + 4.0 * (double) num580;
            double rc1_465 = (double) DeveloperReport.RC1;
            xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
            double point490 = ((XUnit) ref xunit5).Point;
            xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
            double num590 = ((XUnit) ref xunit5).Point / 2.0;
            XRect xrect490 = new XRect(num589, rc1_465, point490, num590);
            XStringFormat topLeft490 = XStringFormat.TopLeft;
            xgraphics490.DrawString("May", xfont498, (XBrush) black476, xrect490, topLeft490);
            XGraphics xgraphics491 = PDFFunctions.gfx[DeveloperReport.k];
            XFont xfont499 = xfont2;
            XSolidBrush black477 = XBrushes.Black;
            double num591 = 20.0 + 5.0 * (double) num580;
            double rc1_466 = (double) DeveloperReport.RC1;
            xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
            double point491 = ((XUnit) ref xunit5).Point;
            xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
            double num592 = ((XUnit) ref xunit5).Point / 2.0;
            XRect xrect491 = new XRect(num591, rc1_466, point491, num592);
            XStringFormat topLeft491 = XStringFormat.TopLeft;
            xgraphics491.DrawString("June", xfont499, (XBrush) black477, xrect491, topLeft491);
            XGraphics xgraphics492 = PDFFunctions.gfx[DeveloperReport.k];
            XFont xfont500 = xfont2;
            XSolidBrush black478 = XBrushes.Black;
            double num593 = 20.0 + 6.0 * (double) num580;
            double rc1_467 = (double) DeveloperReport.RC1;
            xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
            double point492 = ((XUnit) ref xunit5).Point;
            xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
            double num594 = ((XUnit) ref xunit5).Point / 2.0;
            XRect xrect492 = new XRect(num593, rc1_467, point492, num594);
            XStringFormat topLeft492 = XStringFormat.TopLeft;
            xgraphics492.DrawString("July", xfont500, (XBrush) black478, xrect492, topLeft492);
            XGraphics xgraphics493 = PDFFunctions.gfx[DeveloperReport.k];
            XFont xfont501 = xfont2;
            XSolidBrush black479 = XBrushes.Black;
            double num595 = 20.0 + 7.0 * (double) num580;
            double rc1_468 = (double) DeveloperReport.RC1;
            xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
            double point493 = ((XUnit) ref xunit5).Point;
            xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
            double num596 = ((XUnit) ref xunit5).Point / 2.0;
            XRect xrect493 = new XRect(num595, rc1_468, point493, num596);
            XStringFormat topLeft493 = XStringFormat.TopLeft;
            xgraphics493.DrawString("Aug", xfont501, (XBrush) black479, xrect493, topLeft493);
            XGraphics xgraphics494 = PDFFunctions.gfx[DeveloperReport.k];
            XFont xfont502 = xfont2;
            XSolidBrush black480 = XBrushes.Black;
            double num597 = 20.0 + 8.0 * (double) num580;
            double rc1_469 = (double) DeveloperReport.RC1;
            xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
            double point494 = ((XUnit) ref xunit5).Point;
            xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
            double num598 = ((XUnit) ref xunit5).Point / 2.0;
            XRect xrect494 = new XRect(num597, rc1_469, point494, num598);
            XStringFormat topLeft494 = XStringFormat.TopLeft;
            xgraphics494.DrawString("Sept", xfont502, (XBrush) black480, xrect494, topLeft494);
            XGraphics xgraphics495 = PDFFunctions.gfx[DeveloperReport.k];
            XFont xfont503 = xfont2;
            XSolidBrush black481 = XBrushes.Black;
            double num599 = 20.0 + 9.0 * (double) num580;
            double rc1_470 = (double) DeveloperReport.RC1;
            xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
            double point495 = ((XUnit) ref xunit5).Point;
            xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
            double num600 = ((XUnit) ref xunit5).Point / 2.0;
            XRect xrect495 = new XRect(num599, rc1_470, point495, num600);
            XStringFormat topLeft495 = XStringFormat.TopLeft;
            xgraphics495.DrawString("Oct", xfont503, (XBrush) black481, xrect495, topLeft495);
            XGraphics xgraphics496 = PDFFunctions.gfx[DeveloperReport.k];
            XFont xfont504 = xfont2;
            XSolidBrush black482 = XBrushes.Black;
            double num601 = 20.0 + 10.0 * (double) num580;
            double rc1_471 = (double) DeveloperReport.RC1;
            xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
            double point496 = ((XUnit) ref xunit5).Point;
            xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
            double num602 = ((XUnit) ref xunit5).Point / 2.0;
            XRect xrect496 = new XRect(num601, rc1_471, point496, num602);
            XStringFormat topLeft496 = XStringFormat.TopLeft;
            xgraphics496.DrawString("Nov", xfont504, (XBrush) black482, xrect496, topLeft496);
            XGraphics xgraphics497 = PDFFunctions.gfx[DeveloperReport.k];
            XFont xfont505 = xfont2;
            XSolidBrush black483 = XBrushes.Black;
            double num603 = 20.0 + 11.0 * (double) num580;
            double rc1_472 = (double) DeveloperReport.RC1;
            xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
            double point497 = ((XUnit) ref xunit5).Point;
            xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
            double num604 = ((XUnit) ref xunit5).Point / 2.0;
            XRect xrect497 = new XRect(num603, rc1_472, point497, num604);
            XStringFormat topLeft497 = XStringFormat.TopLeft;
            xgraphics497.DrawString("Dec", xfont505, (XBrush) black483, xrect497, topLeft497);
            checked { DeveloperReport.RC1 += 12; }
            DeveloperReport.CheckRC1();
            XGraphics xgraphics498 = PDFFunctions.gfx[DeveloperReport.k];
            // ISSUE: reference to a compiler-generated field
            string str263 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Renewable.Special.Special[index31].M1);
            XFont xfont506 = xfont2;
            XSolidBrush black484 = XBrushes.Black;
            double rc1_473 = (double) DeveloperReport.RC1;
            xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
            double point498 = ((XUnit) ref xunit5).Point;
            xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
            double num605 = ((XUnit) ref xunit5).Point / 2.0;
            XRect xrect498 = new XRect(20.0, rc1_473, point498, num605);
            XStringFormat topLeft498 = XStringFormat.TopLeft;
            xgraphics498.DrawString(str263, xfont506, (XBrush) black484, xrect498, topLeft498);
            XGraphics xgraphics499 = PDFFunctions.gfx[DeveloperReport.k];
            // ISSUE: reference to a compiler-generated field
            string str264 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Renewable.Special.Special[index31].M2);
            XFont xfont507 = xfont2;
            XSolidBrush black485 = XBrushes.Black;
            double num606 = 20.0 + 1.0 * (double) num580;
            double rc1_474 = (double) DeveloperReport.RC1;
            xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
            double point499 = ((XUnit) ref xunit5).Point;
            xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
            double num607 = ((XUnit) ref xunit5).Point / 2.0;
            XRect xrect499 = new XRect(num606, rc1_474, point499, num607);
            XStringFormat topLeft499 = XStringFormat.TopLeft;
            xgraphics499.DrawString(str264, xfont507, (XBrush) black485, xrect499, topLeft499);
            XGraphics xgraphics500 = PDFFunctions.gfx[DeveloperReport.k];
            // ISSUE: reference to a compiler-generated field
            string str265 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Renewable.Special.Special[index31].M3);
            XFont xfont508 = xfont2;
            XSolidBrush black486 = XBrushes.Black;
            double num608 = 20.0 + 2.0 * (double) num580;
            double rc1_475 = (double) DeveloperReport.RC1;
            xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
            double point500 = ((XUnit) ref xunit5).Point;
            xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
            double num609 = ((XUnit) ref xunit5).Point / 2.0;
            XRect xrect500 = new XRect(num608, rc1_475, point500, num609);
            XStringFormat topLeft500 = XStringFormat.TopLeft;
            xgraphics500.DrawString(str265, xfont508, (XBrush) black486, xrect500, topLeft500);
            XGraphics xgraphics501 = PDFFunctions.gfx[DeveloperReport.k];
            // ISSUE: reference to a compiler-generated field
            string str266 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Renewable.Special.Special[index31].M4);
            XFont xfont509 = xfont2;
            XSolidBrush black487 = XBrushes.Black;
            double num610 = 20.0 + 3.0 * (double) num580;
            double rc1_476 = (double) DeveloperReport.RC1;
            xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
            double point501 = ((XUnit) ref xunit5).Point;
            xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
            double num611 = ((XUnit) ref xunit5).Point / 2.0;
            XRect xrect501 = new XRect(num610, rc1_476, point501, num611);
            XStringFormat topLeft501 = XStringFormat.TopLeft;
            xgraphics501.DrawString(str266, xfont509, (XBrush) black487, xrect501, topLeft501);
            XGraphics xgraphics502 = PDFFunctions.gfx[DeveloperReport.k];
            // ISSUE: reference to a compiler-generated field
            string str267 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Renewable.Special.Special[index31].M5);
            XFont xfont510 = xfont2;
            XSolidBrush black488 = XBrushes.Black;
            double num612 = 20.0 + 4.0 * (double) num580;
            double rc1_477 = (double) DeveloperReport.RC1;
            xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
            double point502 = ((XUnit) ref xunit5).Point;
            xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
            double num613 = ((XUnit) ref xunit5).Point / 2.0;
            XRect xrect502 = new XRect(num612, rc1_477, point502, num613);
            XStringFormat topLeft502 = XStringFormat.TopLeft;
            xgraphics502.DrawString(str267, xfont510, (XBrush) black488, xrect502, topLeft502);
            XGraphics xgraphics503 = PDFFunctions.gfx[DeveloperReport.k];
            // ISSUE: reference to a compiler-generated field
            string str268 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Renewable.Special.Special[index31].M6);
            XFont xfont511 = xfont2;
            XSolidBrush black489 = XBrushes.Black;
            double num614 = 20.0 + 5.0 * (double) num580;
            double rc1_478 = (double) DeveloperReport.RC1;
            xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
            double point503 = ((XUnit) ref xunit5).Point;
            xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
            double num615 = ((XUnit) ref xunit5).Point / 2.0;
            XRect xrect503 = new XRect(num614, rc1_478, point503, num615);
            XStringFormat topLeft503 = XStringFormat.TopLeft;
            xgraphics503.DrawString(str268, xfont511, (XBrush) black489, xrect503, topLeft503);
            XGraphics xgraphics504 = PDFFunctions.gfx[DeveloperReport.k];
            // ISSUE: reference to a compiler-generated field
            string str269 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Renewable.Special.Special[index31].M7);
            XFont xfont512 = xfont2;
            XSolidBrush black490 = XBrushes.Black;
            double num616 = 20.0 + 6.0 * (double) num580;
            double rc1_479 = (double) DeveloperReport.RC1;
            xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
            double point504 = ((XUnit) ref xunit5).Point;
            xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
            double num617 = ((XUnit) ref xunit5).Point / 2.0;
            XRect xrect504 = new XRect(num616, rc1_479, point504, num617);
            XStringFormat topLeft504 = XStringFormat.TopLeft;
            xgraphics504.DrawString(str269, xfont512, (XBrush) black490, xrect504, topLeft504);
            XGraphics xgraphics505 = PDFFunctions.gfx[DeveloperReport.k];
            // ISSUE: reference to a compiler-generated field
            string str270 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Renewable.Special.Special[index31].M8);
            XFont xfont513 = xfont2;
            XSolidBrush black491 = XBrushes.Black;
            double num618 = 20.0 + 7.0 * (double) num580;
            double rc1_480 = (double) DeveloperReport.RC1;
            xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
            double point505 = ((XUnit) ref xunit5).Point;
            xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
            double num619 = ((XUnit) ref xunit5).Point / 2.0;
            XRect xrect505 = new XRect(num618, rc1_480, point505, num619);
            XStringFormat topLeft505 = XStringFormat.TopLeft;
            xgraphics505.DrawString(str270, xfont513, (XBrush) black491, xrect505, topLeft505);
            XGraphics xgraphics506 = PDFFunctions.gfx[DeveloperReport.k];
            // ISSUE: reference to a compiler-generated field
            string str271 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Renewable.Special.Special[index31].M9);
            XFont xfont514 = xfont2;
            XSolidBrush black492 = XBrushes.Black;
            double num620 = 20.0 + 8.0 * (double) num580;
            double rc1_481 = (double) DeveloperReport.RC1;
            xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
            double point506 = ((XUnit) ref xunit5).Point;
            xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
            double num621 = ((XUnit) ref xunit5).Point / 2.0;
            XRect xrect506 = new XRect(num620, rc1_481, point506, num621);
            XStringFormat topLeft506 = XStringFormat.TopLeft;
            xgraphics506.DrawString(str271, xfont514, (XBrush) black492, xrect506, topLeft506);
            XGraphics xgraphics507 = PDFFunctions.gfx[DeveloperReport.k];
            // ISSUE: reference to a compiler-generated field
            string str272 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Renewable.Special.Special[index31].M10);
            XFont xfont515 = xfont2;
            XSolidBrush black493 = XBrushes.Black;
            double num622 = 20.0 + 9.0 * (double) num580;
            double rc1_482 = (double) DeveloperReport.RC1;
            xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
            double point507 = ((XUnit) ref xunit5).Point;
            xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
            double num623 = ((XUnit) ref xunit5).Point / 2.0;
            XRect xrect507 = new XRect(num622, rc1_482, point507, num623);
            XStringFormat topLeft507 = XStringFormat.TopLeft;
            xgraphics507.DrawString(str272, xfont515, (XBrush) black493, xrect507, topLeft507);
            XGraphics xgraphics508 = PDFFunctions.gfx[DeveloperReport.k];
            // ISSUE: reference to a compiler-generated field
            string str273 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Renewable.Special.Special[index31].M11);
            XFont xfont516 = xfont2;
            XSolidBrush black494 = XBrushes.Black;
            double num624 = 20.0 + 10.0 * (double) num580;
            double rc1_483 = (double) DeveloperReport.RC1;
            xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
            double point508 = ((XUnit) ref xunit5).Point;
            xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
            double num625 = ((XUnit) ref xunit5).Point / 2.0;
            XRect xrect508 = new XRect(num624, rc1_483, point508, num625);
            XStringFormat topLeft508 = XStringFormat.TopLeft;
            xgraphics508.DrawString(str273, xfont516, (XBrush) black494, xrect508, topLeft508);
            XGraphics xgraphics509 = PDFFunctions.gfx[DeveloperReport.k];
            // ISSUE: reference to a compiler-generated field
            string str274 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Renewable.Special.Special[index31].M12);
            XFont xfont517 = xfont2;
            XSolidBrush black495 = XBrushes.Black;
            double num626 = 20.0 + 11.0 * (double) num580;
            double rc1_484 = (double) DeveloperReport.RC1;
            xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
            double point509 = ((XUnit) ref xunit5).Point;
            xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
            double num627 = ((XUnit) ref xunit5).Point / 2.0;
            XRect xrect509 = new XRect(num626, rc1_484, point509, num627);
            XStringFormat topLeft509 = XStringFormat.TopLeft;
            xgraphics509.DrawString(str274, xfont517, (XBrush) black495, xrect509, topLeft509);
          }
          checked { DeveloperReport.RC1 += 14; }
          DeveloperReport.CheckRC1();
          DeveloperReport.CreateBox();
          DeveloperReport.CheckRC1();
          checked { ++index31; }
        }
      }
      DeveloperReport.CheckRC1();
      // ISSUE: reference to a compiler-generated field
      if (SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Renewable.AAEGeneration.Inlcude)
      {
        XGraphics xgraphics510 = PDFFunctions.gfx[DeveloperReport.k];
        XFont xfont518 = xfont2;
        XSolidBrush black496 = XBrushes.Black;
        double rc1_485 = (double) DeveloperReport.RC1;
        xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
        double point510 = ((XUnit) ref xunit5).Point;
        xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
        double num628 = ((XUnit) ref xunit5).Point / 2.0;
        XRect xrect510 = new XRect(20.0, rc1_485, point510, num628);
        XStringFormat topLeft510 = XStringFormat.TopLeft;
        xgraphics510.DrawString("Additional Allowable Electricity: ", xfont518, (XBrush) black496, xrect510, topLeft510);
        checked { DeveloperReport.RC1 += 12; }
        XGraphics xgraphics511 = PDFFunctions.gfx[DeveloperReport.k];
        // ISSUE: reference to a compiler-generated field
        string str275 = "Energy generated: " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Renewable.AAEGeneration.EGenerated) + " kWh/year ";
        XFont xfont519 = xfont2;
        XSolidBrush black497 = XBrushes.Black;
        double rc1_486 = (double) DeveloperReport.RC1;
        xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
        double point511 = ((XUnit) ref xunit5).Point;
        xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
        double num629 = ((XUnit) ref xunit5).Point / 2.0;
        XRect xrect511 = new XRect(200.0, rc1_486, point511, num629);
        XStringFormat topLeft511 = XStringFormat.TopLeft;
        xgraphics511.DrawString(str275, xfont519, (XBrush) black497, xrect511, topLeft511);
        checked { DeveloperReport.RC1 += 12; }
        XGraphics xgraphics512 = PDFFunctions.gfx[DeveloperReport.k];
        // ISSUE: reference to a compiler-generated field
        string str276 = "Total Area: " + SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Renewable.AAEGeneration.TotalArea + " m\u00B2";
        XFont xfont520 = xfont2;
        XSolidBrush black498 = XBrushes.Black;
        double rc1_487 = (double) DeveloperReport.RC1;
        xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
        double point512 = ((XUnit) ref xunit5).Point;
        xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
        double num630 = ((XUnit) ref xunit5).Point / 2.0;
        XRect xrect512 = new XRect(200.0, rc1_487, point512, num630);
        XStringFormat topLeft512 = XStringFormat.TopLeft;
        xgraphics512.DrawString(str276, xfont520, (XBrush) black498, xrect512, topLeft512);
        checked { DeveloperReport.RC1 += 12; }
      }
      // ISSUE: reference to a compiler-generated field
      if (SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Renewable.HydroGeneration.Inlcude)
      {
        XGraphics xgraphics513 = PDFFunctions.gfx[DeveloperReport.k];
        XFont xfont521 = xfont2;
        XSolidBrush black499 = XBrushes.Black;
        double rc1_488 = (double) DeveloperReport.RC1;
        xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
        double point513 = ((XUnit) ref xunit5).Point;
        xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
        double num631 = ((XUnit) ref xunit5).Point / 2.0;
        XRect xrect513 = new XRect(20.0, rc1_488, point513, num631);
        XStringFormat topLeft513 = XStringFormat.TopLeft;
        xgraphics513.DrawString("Small scale hydro-electic generation: ", xfont521, (XBrush) black499, xrect513, topLeft513);
        XGraphics xgraphics514 = PDFFunctions.gfx[DeveloperReport.k];
        // ISSUE: reference to a compiler-generated field
        string str277 = "Energy generated: " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Renewable.HydroGeneration.HydroGenerated) + " kWh/year ";
        XFont xfont522 = xfont2;
        XSolidBrush black500 = XBrushes.Black;
        double rc1_489 = (double) DeveloperReport.RC1;
        xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
        double point514 = ((XUnit) ref xunit5).Point;
        xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
        double num632 = ((XUnit) ref xunit5).Point / 2.0;
        XRect xrect514 = new XRect(200.0, rc1_489, point514, num632);
        XStringFormat topLeft514 = XStringFormat.TopLeft;
        xgraphics514.DrawString(str277, xfont522, (XBrush) black500, xrect514, topLeft514);
        checked { DeveloperReport.RC1 += 12; }
        XGraphics xgraphics515 = PDFFunctions.gfx[DeveloperReport.k];
        // ISSUE: reference to a compiler-generated field
        string str278 = "Total Area: " + SAP_Module.Proj.Dwellings[closure140_2.\u0024VB\u0024Local_House].Renewable.HydroGeneration.TotalArea + " m\u00B2";
        XFont xfont523 = xfont2;
        XSolidBrush black501 = XBrushes.Black;
        double rc1_490 = (double) DeveloperReport.RC1;
        xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
        double point515 = ((XUnit) ref xunit5).Point;
        xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
        double num633 = ((XUnit) ref xunit5).Point / 2.0;
        XRect xrect515 = new XRect(200.0, rc1_490, point515, num633);
        XStringFormat topLeft515 = XStringFormat.TopLeft;
        xgraphics515.DrawString(str278, xfont523, (XBrush) black501, xrect515, topLeft515);
        checked { DeveloperReport.RC1 += 12; }
      }
      DeveloperReport.CheckRC1();
      string str279 = Conversions.ToString(checked (DeveloperReport.k + 1));
      DeveloperReport.CheckRC1();
      PDFFunctions.xBrush1 = XBrush.op_Implicit((Brush) new SolidBrush(Color.FromArgb(159, 172, 62)));
      PDFFunctions.Points[0].X = 20f;
      PDFFunctions.Points[0].Y = (float) DeveloperReport.RC1;
      ref PointF local29 = ref PDFFunctions.Points[1];
      xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
      double num634 = ((XUnit) ref xunit5).Point - 20.0;
      local29.X = (float) num634;
      PDFFunctions.Points[1].Y = (float) DeveloperReport.RC1;
      ref PointF local30 = ref PDFFunctions.Points[2];
      xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
      double num635 = ((XUnit) ref xunit5).Point - 20.0;
      local30.X = (float) num635;
      PDFFunctions.Points[2].Y = (float) checked (DeveloperReport.RC1 + 16);
      PDFFunctions.Points[3].X = 20f;
      PDFFunctions.Points[3].Y = (float) checked (DeveloperReport.RC1 + 16);
      PDFFunctions.gfx[DeveloperReport.k].DrawPolygon(PDFFunctions.polyGreen2, PDFFunctions.xBrush1, PDFFunctions.Points, xfillMode);
      XGraphics xgraphics516 = PDFFunctions.gfx[DeveloperReport.k];
      XFont xfont524 = xfont3;
      XSolidBrush white15 = XBrushes.White;
      double num636 = (double) checked (DeveloperReport.RC1 + 1);
      xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
      double point516 = ((XUnit) ref xunit5).Point;
      xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
      double num637 = ((XUnit) ref xunit5).Point / 2.0;
      XRect xrect516 = new XRect(25.0, num636, point516, num637);
      XStringFormat topLeft516 = XStringFormat.TopLeft;
      xgraphics516.DrawString("Declaration :", xfont524, (XBrush) white15, xrect516, topLeft516);
      DeveloperReport.RC1 = checked ((int) Math.Round(unchecked ((double) PDFFunctions.Points[3].Y + 6.0)));
      XGraphics xgraphics517 = PDFFunctions.gfx[DeveloperReport.k];
      XFont xfont525 = xfont2;
      XSolidBrush black502 = XBrushes.Black;
      double rc1_491 = (double) DeveloperReport.RC1;
      xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
      double point517 = ((XUnit) ref xunit5).Point;
      xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
      double num638 = ((XUnit) ref xunit5).Point / 2.0;
      XRect xrect517 = new XRect(20.0, rc1_491, point517, num638);
      XStringFormat topLeft517 = XStringFormat.TopLeft;
      xgraphics517.DrawString("I confirm that the property has been built to the above specification.", xfont525, (XBrush) black502, xrect517, topLeft517);
      checked { DeveloperReport.RC1 += 16; }
      DeveloperReport.CheckRC1();
      XGraphics xgraphics518 = PDFFunctions.gfx[DeveloperReport.k];
      XFont xfont526 = xfont2;
      XSolidBrush black503 = XBrushes.Black;
      double rc1_492 = (double) DeveloperReport.RC1;
      xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
      double point518 = ((XUnit) ref xunit5).Point;
      xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
      double num639 = ((XUnit) ref xunit5).Point / 2.0;
      XRect xrect518 = new XRect(20.0, rc1_492, point518, num639);
      XStringFormat topLeft518 = XStringFormat.TopLeft;
      xgraphics518.DrawString("Signed:", xfont526, (XBrush) black503, xrect518, topLeft518);
      checked { DeveloperReport.RC1 += 16; }
      DeveloperReport.CheckRC1();
      XGraphics xgraphics519 = PDFFunctions.gfx[DeveloperReport.k];
      XFont xfont527 = xfont2;
      XSolidBrush black504 = XBrushes.Black;
      double rc1_493 = (double) DeveloperReport.RC1;
      xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
      double point519 = ((XUnit) ref xunit5).Point;
      xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
      double num640 = ((XUnit) ref xunit5).Point / 2.0;
      XRect xrect519 = new XRect(100.0, rc1_493, point519, num640);
      XStringFormat topLeft519 = XStringFormat.TopLeft;
      xgraphics519.DrawString("............................................................................................................", xfont527, (XBrush) black504, xrect519, topLeft519);
      checked { DeveloperReport.RC1 += 16; }
      DeveloperReport.CheckRC1();
      XGraphics xgraphics520 = PDFFunctions.gfx[DeveloperReport.k];
      XFont xfont528 = xfont2;
      XSolidBrush black505 = XBrushes.Black;
      double rc1_494 = (double) DeveloperReport.RC1;
      xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
      double point520 = ((XUnit) ref xunit5).Point;
      xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
      double num641 = ((XUnit) ref xunit5).Point / 2.0;
      XRect xrect520 = new XRect(20.0, rc1_494, point520, num641);
      XStringFormat topLeft520 = XStringFormat.TopLeft;
      xgraphics520.DrawString("Date:", xfont528, (XBrush) black505, xrect520, topLeft520);
      checked { DeveloperReport.RC1 += 16; }
      DeveloperReport.CheckRC1();
      XGraphics xgraphics521 = PDFFunctions.gfx[DeveloperReport.k];
      XFont xfont529 = xfont2;
      XSolidBrush black506 = XBrushes.Black;
      double rc1_495 = (double) DeveloperReport.RC1;
      xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
      double point521 = ((XUnit) ref xunit5).Point;
      xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
      double num642 = ((XUnit) ref xunit5).Point / 2.0;
      XRect xrect521 = new XRect(100.0, rc1_495, point521, num642);
      XStringFormat topLeft521 = XStringFormat.TopLeft;
      xgraphics521.DrawString("............................................................................................................", xfont529, (XBrush) black506, xrect521, topLeft521);
      XFont xfont530 = new XFont("Arial", 160.0, (XFontStyle) 1);
      PDFFunctions.transbrush = XBrush.op_Implicit((Brush) new SolidBrush(Color.FromArgb(128, Color.Olive)));
      int k = DeveloperReport.k;
      int index32 = 0;
      while (index32 <= k)
      {
        if (!SAP_Module.Proj.OverRide)
        {
          XGraphics xgraphics522 = PDFFunctions.gfx[index32];
          string str280 = "Stroma FSAP 2012 " + SAP_Module.CurrVersion + " (SAP 9.92) - http://www.stroma.com";
          XFont xfont531 = xfont8;
          XSolidBrush black507 = XBrushes.Black;
          xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point522 = ((XUnit) ref xunit5).Point;
          xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
          double point523 = ((XUnit) ref xunit5).Point;
          XRect xrect522 = new XRect(20.0, 820.0, point522, point523);
          XStringFormat topLeft522 = XStringFormat.TopLeft;
          xgraphics522.DrawString(str280, xfont531, (XBrush) black507, xrect522, topLeft522);
        }
        else
        {
          XGraphics xgraphics523 = PDFFunctions.gfx[index32];
          string str281 = "Stroma FSAP 2012 " + SAP_Module.Proj.CalcVersion + " (SAP 9.92) - http://www.stroma.com";
          XFont xfont532 = xfont8;
          XSolidBrush black508 = XBrushes.Black;
          xunit5 = PDFFunctions.pages[DeveloperReport.k].Width;
          double point524 = ((XUnit) ref xunit5).Point;
          xunit5 = PDFFunctions.pages[DeveloperReport.k].Height;
          double point525 = ((XUnit) ref xunit5).Point;
          XRect xrect523 = new XRect(20.0, 820.0, point524, point525);
          XStringFormat topLeft523 = XStringFormat.TopLeft;
          xgraphics523.DrawString(str281, xfont532, (XBrush) black508, xrect523, topLeft523);
        }
        XGraphics xgraphics524 = PDFFunctions.gfx[index32];
        string str282 = "Page " + Conversions.ToString(checked (index32 + 1)) + " of " + str279;
        XFont xfont533 = xfont8;
        XSolidBrush black509 = XBrushes.Black;
        xunit5 = PDFFunctions.pages[index32].Width;
        double point526 = ((XUnit) ref xunit5).Point;
        xunit5 = PDFFunctions.pages[index32].Height;
        double point527 = ((XUnit) ref xunit5).Point;
        XRect xrect524 = new XRect(520.0, 820.0, point526, point527);
        XStringFormat topLeft524 = XStringFormat.TopLeft;
        xgraphics524.DrawString(str282, xfont533, (XBrush) black509, xrect524, topLeft524);
        checked { ++index32; }
      }
      SAP_Module.PDFFileName = "";
      object folderPath = (object) Environment.GetFolderPath(Environment.SpecialFolder.Personal);
      DirectoryInfo directoryInfo1 = new DirectoryInfo(Conversions.ToString(Operators.ConcatenateObject(folderPath, (object) "\\Stroma SAP 2012")));
      DirectoryInfo directoryInfo2 = new DirectoryInfo(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(folderPath, (object) "\\Stroma SAP 2012\\"), (object) SAP_Module.Proj.Name)));
      DirectoryInfo directoryInfo3 = new DirectoryInfo(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(folderPath, (object) "\\Stroma SAP 2012\\"), (object) SAP_Module.Proj.Name), (object) "\\"), (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Name)));
      if (!PDFFunctions.Draft_PDF)
      {
        developerReport = (Stream) new MemoryStream();
        PDFFunctions.document.Save(developerReport, false);
      }
      else
      {
        SAP_Module.PDFFileName = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(folderPath, (object) "\\Stroma SAP 2012\\"), (object) SAP_Module.Proj.Name), (object) "\\"), (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Name), (object) "\\"), (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Name), (object) "-Developer-Confirmation-Report"), (object) ".pdf"));
        PDFFunctions.document.Save(SAP_Module.PDFFileName);
      }
      return developerReport;
    }

    private static void CheckRC1()
    {
      if (DeveloperReport.RC1 < 750)
        return;
      DeveloperReport.CreateNewPage();
    }

    public static string[] CheckTextWidth2(string Desc, int value)
    {
      XPdfFontOptions xpdfFontOptions = new XPdfFontOptions((PdfFontEncoding) 1, (PdfFontEmbedding) 2);
      XFont xfont = new XFont("Arial", 10.0, (XFontStyle) 0);
      Desc = Desc.Replace("\r", "").Replace("\n", "");
      string str1 = "";
      string str2 = "";
      str1 = "";
      object Right = (object) 0;
      string[] strArray = new string[2];
      int index1 = 0;
      do
      {
        strArray[index1] = "";
        checked { ++index1; }
      }
      while (index1 <= 1);
      int index2 = 0;
      string Expression = Desc;
label_3:
      int num1 = Microsoft.VisualBasic.Strings.Len(Expression);
      int length = 0;
      while (length <= num1)
      {
        string str3 = Expression.Substring(0, length);
        if (str3.EndsWith(" ") | str3.EndsWith("\r\n"))
        {
          XSize xsize = PDFFunctions.gfx[0].MeasureString(str3, xfont);
          double width = ((XSize) ref xsize).Width;
          XSize pageSize = PDFFunctions.gfx[0].PageSize;
          double num2 = ((XSize) ref pageSize).Width - (double) value;
          if (width > num2)
          {
            strArray[index2] = str2;
            checked { ++index2; }
            Expression = Expression.Substring(Conversions.ToInteger(Right), Conversions.ToInteger(Operators.SubtractObject((object) Microsoft.VisualBasic.Strings.Len(Expression), Right)));
            goto label_3;
          }
          else
          {
            str2 = str3;
            Right = (object) length;
          }
        }
        if (length == Microsoft.VisualBasic.Strings.Len(Desc))
        {
          XSize xsize = PDFFunctions.gfx[0].MeasureString(str3, xfont);
          double width = ((XSize) ref xsize).Width;
          XSize pageSize = PDFFunctions.gfx[0].PageSize;
          double num3 = ((XSize) ref pageSize).Width - (double) value;
          if (width > num3)
          {
            strArray[index2] = str2;
            checked { ++index2; }
            Expression = Expression.Substring(Conversions.ToInteger(Right), Conversions.ToInteger(Operators.SubtractObject((object) Microsoft.VisualBasic.Strings.Len(Expression), Right)));
            goto label_3;
          }
          else
          {
            str2 = str3;
            Right = (object) length;
          }
        }
        if (length == Microsoft.VisualBasic.Strings.Len(Expression))
          strArray[index2] = Expression;
        checked { ++length; }
      }
      return strArray;
    }

    private static void CreateNewPage()
    {
      checked { ++DeveloperReport.k; }
      PDFFunctions.pages[DeveloperReport.k] = PDFFunctions.document.AddPage();
      PDFFunctions.gfx[DeveloperReport.k] = XGraphics.FromPdfPage(PDFFunctions.pages[DeveloperReport.k]);
      XSize xsize = PDFFunctions.gfx[DeveloperReport.k].PageSize;
      double num1 = ((XSize) ref xsize).Width / 2.0;
      xsize = PDFFunctions.gfx[DeveloperReport.k].MeasureString("Developer Confirmation Report", PDFFunctions.ArialFont16Bold);
      double num2 = ((XSize) ref xsize).Width / 2.0;
      int num3 = checked ((int) Math.Round(unchecked (num1 - num2)));
      XGraphics xgraphics = PDFFunctions.gfx[DeveloperReport.k];
      XFont arialFont16Bold = PDFFunctions.ArialFont16Bold;
      XSolidBrush black = XBrushes.Black;
      double num4 = (double) num3;
      XUnit xunit = PDFFunctions.pages[DeveloperReport.k].Width;
      double point = ((XUnit) ref xunit).Point;
      xunit = PDFFunctions.pages[DeveloperReport.k].Height;
      double num5 = ((XUnit) ref xunit).Point / 2.0;
      XRect xrect = new XRect(num4, 30.0, point, num5);
      XStringFormat topLeft = XStringFormat.TopLeft;
      xgraphics.DrawString("Developer Confirmation Report", arialFont16Bold, (XBrush) black, xrect, topLeft);
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
          num8 = checked ((int) Math.Round((double) DeveloperReport.ImageY));
          num9 = checked ((int) Math.Round(unchecked ((double) checked (image.Height * 100) / (double) image.Width)));
        }
        else
        {
          num8 = checked ((int) Math.Round((double) DeveloperReport.ImageY));
          num9 = 60;
          num6 = checked ((int) Math.Round(unchecked (575.0 - (double) image.Width / (double) image.Height * 60.0)));
          num7 = checked ((int) Math.Round(unchecked ((double) image.Width / (double) image.Height * 60.0)));
        }
        PDFFunctions.gfx[DeveloperReport.k].DrawImage(XImage.op_Implicit(image), num6, num8, num7, num9);
        image.Dispose();
      }
      if (UserSettings.USettings.PrintUserSettings.Print)
        PDFFunctions.PrintUserDetails(PDFFunctions.gfx[DeveloperReport.k]);
      DeveloperReport.RC1 = 70;
    }

    private static object CheckDoubleGlazed(string value)
    {
      string str = value;
      object obj;
      // ISSUE: reference to a compiler-generated method
      switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(str))
      {
        case 68605829:
          if (Operators.CompareString(str, "triple-glazed, argon filled (low-E, En = 0.2, hard coat)", false) == 0)
            goto label_31;
          else
            goto default;
        case 763250309:
          if (Operators.CompareString(str, "double-glazed, air filled (low-E, En = 0.2, hard coat)", false) == 0)
            goto label_26;
          else
            goto default;
        case 1070237142:
          if (Operators.CompareString(str, "triple-glazed, argon filled", false) == 0)
            goto label_30;
          else
            goto default;
        case 1119002789:
          if (Operators.CompareString(str, "double-glazed, argon filled", false) == 0)
            break;
          goto default;
        case 1129292894:
          if (Operators.CompareString(str, "triple-glazed, air filled (low-E, En = 0.15, hard coat)", false) == 0)
            goto label_32;
          else
            goto default;
        case 1508940614:
          if (Operators.CompareString(str, "double-glazed, argon filled (low-E, En = 0.15, hard coat)", false) == 0)
            goto label_27;
          else
            goto default;
        case 1617436365:
          if (Operators.CompareString(str, "triple-glazed, argon filled (low-E, En = 0.1, soft coat)", false) == 0)
            goto label_33;
          else
            goto default;
        case 1917834200:
          if (Operators.CompareString(str, "double-glazed, argon filled (low-E, En = 0.1, soft coat)", false) == 0)
            goto label_28;
          else
            goto default;
        case 2282570948:
          if (Operators.CompareString(str, "triple-glazed, air filled (low-E, En = 0.2, hard coat)", false) == 0)
            goto label_31;
          else
            goto default;
        case 2312080845:
          if (Operators.CompareString(str, "double-glazed, air filled (low-E, En = 0.1, soft coat)", false) == 0)
            goto label_28;
          else
            goto default;
        case 2413948722:
          if (Operators.CompareString(str, "double-glazed, argon filled (low-E, En = 0.05, soft coat)", false) == 0)
            goto label_29;
          else
            goto default;
        case 2482092156:
          if (Operators.CompareString(str, "double-glazed, argon filled (low-E, En = 0.2, hard coat)", false) == 0)
            goto label_26;
          else
            goto default;
        case 2498216925:
          if (Operators.CompareString(str, "triple-glazed, air filled", false) == 0)
            goto label_30;
          else
            goto default;
        case 2915735968:
          if (Operators.CompareString(str, "triple-glazed, air filled (low-E, En = 0.1, soft coat)", false) == 0)
            goto label_33;
          else
            goto default;
        case 3074690985:
          if (Operators.CompareString(str, "triple-glazed, argon filled (low-E, En = 0.05, soft coat)", false) == 0)
            goto label_34;
          else
            goto default;
        case 3361248225:
          if (Operators.CompareString(str, "triple-glazed, argon filled (low-E, En = 0.15, hard coat)", false) == 0)
            goto label_32;
          else
            goto default;
        case 3689514233:
          if (Operators.CompareString(str, "Single-glazed", false) == 0)
          {
            obj = (object) "Single-glazed";
            goto label_36;
          }
          else
            goto default;
        case 3843542185:
          if (Operators.CompareString(str, "double-glazed, air filled (low-E, En = 0.05, soft coat)", false) == 0)
            goto label_29;
          else
            goto default;
        case 4014901974:
          if (Operators.CompareString(str, "double-glazed, air filled", false) == 0)
            break;
          goto default;
        case 4130099425:
          if (Operators.CompareString(str, "double-glazed, air filled (low-E, En = 0.15, hard coat)", false) == 0)
            goto label_27;
          else
            goto default;
        case 4251481834:
          if (Operators.CompareString(str, "triple-glazed, air filled (low-E, En = 0.05, soft coat)", false) == 0)
            goto label_34;
          else
            goto default;
        case 4255679661:
          if (Operators.CompareString(str, "Secondary glazing", false) == 0)
          {
            obj = (object) "Secondary glazing";
            goto label_36;
          }
          else
            goto default;
        default:
          obj = (object) "";
          goto label_36;
      }
      obj = (object) "double-glazed";
      goto label_36;
label_26:
      obj = (object) "low-E, En = 0.2, hard coat";
      goto label_36;
label_27:
      obj = (object) "low-E, En = 0.15, hard coat";
      goto label_36;
label_28:
      obj = (object) "low-E, En = 0.1, soft coat";
      goto label_36;
label_29:
      obj = (object) "low-E, En = 0.05, soft coat";
      goto label_36;
label_30:
      obj = (object) "triple-glazed";
      goto label_36;
label_31:
      obj = (object) "low-E, En = 0.2, hard coat";
      goto label_36;
label_32:
      obj = (object) "low-E, En = 0.15, hard coat";
      goto label_36;
label_33:
      obj = (object) "low-E, En = 0.1, soft coat";
      goto label_36;
label_34:
      obj = (object) "low-E, En = 0.05, soft coat";
label_36:
      return obj;
    }

    private static double ShowY()
    {
      double num1;
      try
      {
        int num2 = checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofDoors - 1);
        int index1 = 0;
        while (index1 <= num2)
        {
          num1 += (double) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors[index1].Area * (double) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors[index1].Count;
          checked { ++index1; }
        }
        int num3 = checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofWindows - 1);
        int index2 = 0;
        while (index2 <= num3)
        {
          num1 += (double) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows[index2].Area * (double) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows[index2].Count;
          checked { ++index2; }
        }
        int num4 = checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofRoofLights - 1);
        int index3 = 0;
        while (index3 <= num4)
        {
          num1 += (double) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[index3].Area * (double) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[index3].Count;
          checked { ++index3; }
        }
        int num5 = checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofFloors - 1);
        int index4 = 0;
        while (index4 <= num5)
        {
          num1 += (double) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Floors[index4].Area;
          checked { ++index4; }
        }
        int num6 = checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofWalls - 1);
        int index5 = 0;
        while (index5 <= num6)
        {
          double area = (double) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Walls[index5].Area;
          if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].GrossAreas)
          {
            int num7 = checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofDoors - 1);
            int index6 = 0;
            while (index6 <= num7)
            {
              if (Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors[index6].Location, SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Walls[index5].Name, false) == 0)
                area -= (double) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors[index6].Area * (double) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors[index6].Count;
              checked { ++index6; }
            }
            int num8 = checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofWindows - 1);
            int index7 = 0;
            while (index7 <= num8)
            {
              if (Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows[index7].Location, SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Walls[index5].Name, false) == 0)
                area -= (double) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows[index7].Area * (double) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows[index7].Count;
              checked { ++index7; }
            }
          }
          num1 += area;
          checked { ++index5; }
        }
        int num9 = checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofRoofs - 1);
        int index8 = 0;
        while (index8 <= num9)
        {
          double area = (double) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Roofs[index8].Area;
          if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].GrossAreas)
          {
            int num10 = checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofRoofLights - 1);
            int index9 = 0;
            while (index9 <= num10)
            {
              if (Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[index9].Location, SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Roofs[index8].Name, false) == 0)
                area -= (double) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[index9].Area * (double) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[index9].Count;
              checked { ++index9; }
            }
          }
          num1 += area;
          checked { ++index8; }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      return Math.Round((double) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.HtbValue / num1, 4);
    }

    private static void CreateBox()
    {
      XPen xpen = new XPen(XColor.FromArgb(211, 211, 211));
      DeveloperReport.CheckRC1();
      XGraphics xgraphics = PDFFunctions.gfx[DeveloperReport.k];
      XFont arialFont10 = PDFFunctions.ArialFont10;
      XSolidBrush black = XBrushes.Black;
      double rc1 = (double) DeveloperReport.RC1;
      XUnit xunit = PDFFunctions.pages[DeveloperReport.k].Width;
      double point = ((XUnit) ref xunit).Point;
      xunit = PDFFunctions.pages[DeveloperReport.k].Height;
      double num1 = ((XUnit) ref xunit).Point / 2.0;
      XRect xrect = new XRect(20.0, rc1, point, num1);
      XStringFormat topLeft = XStringFormat.TopLeft;
      xgraphics.DrawString("Comments: ", arialFont10, (XBrush) black, xrect, topLeft);
      checked { DeveloperReport.RC1 += 14; }
      XBrush xbrush = XBrush.op_Implicit((Brush) new SolidBrush(Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue)));
      PDFFunctions.Points[0].X = 20f;
      PDFFunctions.Points[0].Y = (float) DeveloperReport.RC1;
      ref PointF local1 = ref PDFFunctions.Points[1];
      XUnit width1 = PDFFunctions.pages[DeveloperReport.k].Width;
      double num2 = ((XUnit) ref width1).Point - 20.0;
      local1.X = (float) num2;
      PDFFunctions.Points[1].Y = (float) DeveloperReport.RC1;
      ref PointF local2 = ref PDFFunctions.Points[2];
      XUnit width2 = PDFFunctions.pages[DeveloperReport.k].Width;
      double num3 = ((XUnit) ref width2).Point - 20.0;
      local2.X = (float) num3;
      PDFFunctions.Points[2].Y = (float) checked (DeveloperReport.RC1 + 60);
      PDFFunctions.Points[3].X = 20f;
      PDFFunctions.Points[3].Y = (float) checked (DeveloperReport.RC1 + 60);
      PDFFunctions.gfx[DeveloperReport.k].DrawPolygon(xpen, xbrush, PDFFunctions.Points, PDFFunctions.Fill);
      checked { DeveloperReport.RC1 += 75; }
    }
  }
}
