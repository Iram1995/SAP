
// Type: SAP2012.SAPInput




using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;

namespace SAP2012
{
  [StandardModule]
  internal sealed class SAPInput
  {
    public static bool TraineeUser;
    public static AssessmentLZC_2012 CodeAssessmentLZC2012 = new AssessmentLZC_2012();
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

    public static Stream CreateSAPInput(int House, int Country)
    {
      // ISSUE: variable of a compiler-generated type
      SAPInput._Closure\u0024__16\u002D0 closure160_1;
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      SAPInput._Closure\u0024__16\u002D0 closure160_2 = new SAPInput._Closure\u0024__16\u002D0(closure160_1);
      // ISSUE: reference to a compiler-generated field
      closure160_2.\u0024VB\u0024Local_House = House;
      Stream sapInput = (Stream) new MemoryStream();
      XFont xfont1 = new XFont("Tahoma", 11.0, (XFontStyle) 1);
      XFont xfont2 = new XFont("Tahoma", 10.0, (XFontStyle) 0);
      XFont xfont3 = new XFont("Tahoma", 9.0, (XFontStyle) 0);
      XFont xfont4 = new XFont("Tahoma", 10.0, (XFontStyle) 4);
      XFont xfont5 = new XFont("Tahoma", 16.0, (XFontStyle) 1);
      XFont xfont6 = new XFont("Tahoma", 10.0, (XFontStyle) 2);
      XFont xfont7 = new XFont("Tahoma", 10.0, (XFontStyle) 1);
      XFont xfont8 = new XFont("Tahoma", 8.0, (XFontStyle) 1);
      XFont xfont9 = new XFont("Tahoma", 8.0, (XFontStyle) 0);
      XFont xfont10 = new XFont("Tahoma", 6.0, (XFontStyle) 0);
      XPen xpen1 = new XPen(XColor.FromArgb(0, 115, 187));
      XPen xpen2 = new XPen(XColor.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue));
      XPen xpen3 = new XPen(XColor.FromArgb(0, 0, (int) byte.MaxValue));
      SAPInput.k = 0;
      PDFFunctions.document = new PdfDocument();
      PDFFunctions.pages[SAPInput.k] = PDFFunctions.document.AddPage();
      PDFFunctions.gfx[SAPInput.k] = XGraphics.FromPdfPage(PDFFunctions.pages[SAPInput.k]);
      XSize xsize = PDFFunctions.gfx[SAPInput.k].PageSize;
      double num1 = ((XSize) ref xsize).Width / 2.0;
      xsize = PDFFunctions.gfx[SAPInput.k].MeasureString("SAP Input", PDFFunctions.ArialFont16Bold);
      double num2 = ((XSize) ref xsize).Width / 2.0;
      int num3 = checked ((int) Math.Round(unchecked (num1 - num2)));
      XGraphics xgraphics1 = PDFFunctions.gfx[SAPInput.k];
      XFont arialFont16Bold = PDFFunctions.ArialFont16Bold;
      XSolidBrush black1 = XBrushes.Black;
      double num4 = (double) num3;
      XUnit xunit1 = PDFFunctions.pages[SAPInput.k].Width;
      double point1 = ((XUnit) ref xunit1).Point;
      xunit1 = PDFFunctions.pages[SAPInput.k].Height;
      double num5 = ((XUnit) ref xunit1).Point / 2.0;
      XRect xrect1 = new XRect(num4, 30.0, point1, num5);
      XStringFormat topLeft1 = XStringFormat.TopLeft;
      xgraphics1.DrawString("SAP Input", arialFont16Bold, (XBrush) black1, xrect1, topLeft1);
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
          num8 = checked ((int) Math.Round((double) SAPInput.ImageY));
          num9 = checked ((int) Math.Round(unchecked ((double) checked (image.Height * 100) / (double) image.Width)));
        }
        else
        {
          num8 = checked ((int) Math.Round((double) SAPInput.ImageY));
          num9 = 60;
          num6 = checked ((int) Math.Round(unchecked (575.0 - (double) image.Width / (double) image.Height * 60.0)));
          num7 = checked ((int) Math.Round(unchecked ((double) image.Width / (double) image.Height * 60.0)));
        }
        PDFFunctions.gfx[SAPInput.k].DrawImage(XImage.op_Implicit(image), num6, num8, num7, num9);
        image.Dispose();
      }
      if (UserSettings.USettings.PrintUserSettings.Print)
        PDFFunctions.PrintUserDetails(PDFFunctions.gfx[SAPInput.k]);
      SAPInput.RC1 = 70;
      PDFFunctions.xBrush1 = XBrush.op_Implicit((Brush) new SolidBrush(Color.FromArgb(159, 172, 62)));
      PDFFunctions.Points[0].X = 20f;
      PDFFunctions.Points[0].Y = (float) SAPInput.RC1;
      ref PointF local1 = ref PDFFunctions.Points[1];
      XUnit width1 = PDFFunctions.pages[SAPInput.k].Width;
      double num10 = ((XUnit) ref width1).Point - 20.0;
      local1.X = (float) num10;
      PDFFunctions.Points[1].Y = (float) SAPInput.RC1;
      ref PointF local2 = ref PDFFunctions.Points[2];
      XUnit width2 = PDFFunctions.pages[SAPInput.k].Width;
      double num11 = ((XUnit) ref width2).Point - 20.0;
      local2.X = (float) num11;
      PDFFunctions.Points[2].Y = (float) checked (SAPInput.RC1 + 14);
      PDFFunctions.Points[3].X = 20f;
      PDFFunctions.Points[3].Y = (float) checked (SAPInput.RC1 + 14);
      XFillMode xfillMode;
      PDFFunctions.gfx[SAPInput.k].DrawPolygon(PDFFunctions.polyGreen2, PDFFunctions.xBrush1, PDFFunctions.Points, xfillMode);
      XGraphics xgraphics2 = PDFFunctions.gfx[SAPInput.k];
      // ISSUE: reference to a compiler-generated field
      string str1 = "Property Details: " + SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Name;
      XFont xfont11 = xfont3;
      XSolidBrush white1 = XBrushes.White;
      double num12 = (double) checked (SAPInput.RC1 + 1);
      XUnit width3 = PDFFunctions.pages[SAPInput.k].Width;
      double point2 = ((XUnit) ref width3).Point;
      XUnit height1 = PDFFunctions.pages[SAPInput.k].Height;
      double num13 = ((XUnit) ref height1).Point / 2.0;
      XRect xrect2 = new XRect(25.0, num12, point2, num13);
      XStringFormat topLeft2 = XStringFormat.TopLeft;
      xgraphics2.DrawString(str1, xfont11, (XBrush) white1, xrect2, topLeft2);
      SAPInput.RC1 = checked ((int) Math.Round(unchecked ((double) PDFFunctions.Points[3].Y + 4.0)));
      string str2 = "";
      // ISSUE: reference to a compiler-generated field
      if (!string.IsNullOrEmpty(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Address.Line1))
      {
        // ISSUE: reference to a compiler-generated field
        str2 += SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Address.Line1;
      }
      // ISSUE: reference to a compiler-generated field
      if (!string.IsNullOrEmpty(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Address.Line2))
      {
        // ISSUE: reference to a compiler-generated field
        str2 = str2 + ", " + SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Address.Line2;
      }
      // ISSUE: reference to a compiler-generated field
      if (!string.IsNullOrEmpty(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Address.Line3))
      {
        // ISSUE: reference to a compiler-generated field
        str2 = str2 + ", " + SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Address.Line3;
      }
      // ISSUE: reference to a compiler-generated field
      if (!string.IsNullOrEmpty(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Address.City))
      {
        // ISSUE: reference to a compiler-generated field
        str2 = str2 + ", " + SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Address.City;
      }
      // ISSUE: reference to a compiler-generated field
      if (!string.IsNullOrEmpty(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Address.PostCost))
      {
        // ISSUE: reference to a compiler-generated field
        str2 = str2 + ", " + SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Address.PostCost;
      }
      XGraphics xgraphics3 = PDFFunctions.gfx[SAPInput.k];
      XFont xfont12 = xfont7;
      XSolidBrush black2 = XBrushes.Black;
      double rc1_1 = (double) SAPInput.RC1;
      XUnit xunit2 = PDFFunctions.pages[SAPInput.k].Width;
      double point3 = ((XUnit) ref xunit2).Point;
      xunit2 = PDFFunctions.pages[SAPInput.k].Height;
      double num14 = ((XUnit) ref xunit2).Point / 2.0;
      XRect xrect3 = new XRect(20.0, rc1_1, point3, num14);
      XStringFormat topLeft3 = XStringFormat.TopLeft;
      xgraphics3.DrawString("Address:", xfont12, (XBrush) black2, xrect3, topLeft3);
      XGraphics xgraphics4 = PDFFunctions.gfx[SAPInput.k];
      string str3 = str2;
      XFont xfont13 = xfont3;
      XSolidBrush black3 = XBrushes.Black;
      double rc1_2 = (double) SAPInput.RC1;
      xunit2 = PDFFunctions.pages[SAPInput.k].Width;
      double point4 = ((XUnit) ref xunit2).Point;
      xunit2 = PDFFunctions.pages[SAPInput.k].Height;
      double num15 = ((XUnit) ref xunit2).Point / 2.0;
      XRect xrect4 = new XRect(200.0, rc1_2, point4, num15);
      XStringFormat topLeft4 = XStringFormat.TopLeft;
      xgraphics4.DrawString(str3, xfont13, (XBrush) black3, xrect4, topLeft4);
      checked { SAPInput.RC1 += 12; }
      XGraphics xgraphics5 = PDFFunctions.gfx[SAPInput.k];
      XFont xfont14 = xfont7;
      XSolidBrush black4 = XBrushes.Black;
      double rc1_3 = (double) SAPInput.RC1;
      xunit2 = PDFFunctions.pages[SAPInput.k].Width;
      double point5 = ((XUnit) ref xunit2).Point;
      xunit2 = PDFFunctions.pages[SAPInput.k].Height;
      double num16 = ((XUnit) ref xunit2).Point / 2.0;
      XRect xrect5 = new XRect(20.0, rc1_3, point5, num16);
      XStringFormat topLeft5 = XStringFormat.TopLeft;
      xgraphics5.DrawString("Located in:", xfont14, (XBrush) black4, xrect5, topLeft5);
      XGraphics xgraphics6 = PDFFunctions.gfx[SAPInput.k];
      // ISSUE: reference to a compiler-generated field
      string country = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Address.Country;
      XFont xfont15 = xfont3;
      XSolidBrush black5 = XBrushes.Black;
      double rc1_4 = (double) SAPInput.RC1;
      xunit2 = PDFFunctions.pages[SAPInput.k].Width;
      double point6 = ((XUnit) ref xunit2).Point;
      xunit2 = PDFFunctions.pages[SAPInput.k].Height;
      double num17 = ((XUnit) ref xunit2).Point / 2.0;
      XRect xrect6 = new XRect(200.0, rc1_4, point6, num17);
      XStringFormat topLeft6 = XStringFormat.TopLeft;
      xgraphics6.DrawString(country, xfont15, (XBrush) black5, xrect6, topLeft6);
      checked { SAPInput.RC1 += 12; }
      XGraphics xgraphics7 = PDFFunctions.gfx[SAPInput.k];
      XFont xfont16 = xfont7;
      XSolidBrush black6 = XBrushes.Black;
      double rc1_5 = (double) SAPInput.RC1;
      xunit2 = PDFFunctions.pages[SAPInput.k].Width;
      double point7 = ((XUnit) ref xunit2).Point;
      xunit2 = PDFFunctions.pages[SAPInput.k].Height;
      double num18 = ((XUnit) ref xunit2).Point / 2.0;
      XRect xrect7 = new XRect(20.0, rc1_5, point7, num18);
      XStringFormat topLeft7 = XStringFormat.TopLeft;
      xgraphics7.DrawString("Region:", xfont16, (XBrush) black6, xrect7, topLeft7);
      XGraphics xgraphics8 = PDFFunctions.gfx[SAPInput.k];
      // ISSUE: reference to a compiler-generated field
      string location1 = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Location;
      XFont xfont17 = xfont3;
      XSolidBrush black7 = XBrushes.Black;
      double rc1_6 = (double) SAPInput.RC1;
      xunit2 = PDFFunctions.pages[SAPInput.k].Width;
      double point8 = ((XUnit) ref xunit2).Point;
      xunit2 = PDFFunctions.pages[SAPInput.k].Height;
      double num19 = ((XUnit) ref xunit2).Point / 2.0;
      XRect xrect8 = new XRect(200.0, rc1_6, point8, num19);
      XStringFormat topLeft8 = XStringFormat.TopLeft;
      xgraphics8.DrawString(location1, xfont17, (XBrush) black7, xrect8, topLeft8);
      checked { SAPInput.RC1 += 12; }
      XGraphics xgraphics9 = PDFFunctions.gfx[SAPInput.k];
      XFont xfont18 = xfont7;
      XSolidBrush black8 = XBrushes.Black;
      double rc1_7 = (double) SAPInput.RC1;
      xunit2 = PDFFunctions.pages[SAPInput.k].Width;
      double point9 = ((XUnit) ref xunit2).Point;
      xunit2 = PDFFunctions.pages[SAPInput.k].Height;
      double num20 = ((XUnit) ref xunit2).Point / 2.0;
      XRect xrect9 = new XRect(20.0, rc1_7, point9, num20);
      XStringFormat topLeft9 = XStringFormat.TopLeft;
      xgraphics9.DrawString("UPRN:", xfont18, (XBrush) black8, xrect9, topLeft9);
      XGraphics xgraphics10 = PDFFunctions.gfx[SAPInput.k];
      // ISSUE: reference to a compiler-generated field
      string uprn = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].UPRN;
      XFont xfont19 = xfont3;
      XSolidBrush black9 = XBrushes.Black;
      double rc1_8 = (double) SAPInput.RC1;
      xunit2 = PDFFunctions.pages[SAPInput.k].Width;
      double point10 = ((XUnit) ref xunit2).Point;
      xunit2 = PDFFunctions.pages[SAPInput.k].Height;
      double num21 = ((XUnit) ref xunit2).Point / 2.0;
      XRect xrect10 = new XRect(200.0, rc1_8, point10, num21);
      XStringFormat topLeft10 = XStringFormat.TopLeft;
      xgraphics10.DrawString(uprn, xfont19, (XBrush) black9, xrect10, topLeft10);
      checked { SAPInput.RC1 += 12; }
      XGraphics xgraphics11 = PDFFunctions.gfx[SAPInput.k];
      XFont xfont20 = xfont7;
      XSolidBrush black10 = XBrushes.Black;
      double rc1_9 = (double) SAPInput.RC1;
      xunit2 = PDFFunctions.pages[SAPInput.k].Width;
      double point11 = ((XUnit) ref xunit2).Point;
      xunit2 = PDFFunctions.pages[SAPInput.k].Height;
      double num22 = ((XUnit) ref xunit2).Point / 2.0;
      XRect xrect11 = new XRect(20.0, rc1_9, point11, num22);
      XStringFormat topLeft11 = XStringFormat.TopLeft;
      xgraphics11.DrawString("Date of assessment:", xfont20, (XBrush) black10, xrect11, topLeft11);
      XGraphics xgraphics12 = PDFFunctions.gfx[SAPInput.k];
      // ISSUE: reference to a compiler-generated field
      string longDateString1 = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].DateAssessment.ToLongDateString();
      XFont xfont21 = xfont3;
      XSolidBrush black11 = XBrushes.Black;
      double rc1_10 = (double) SAPInput.RC1;
      xunit2 = PDFFunctions.pages[SAPInput.k].Width;
      double point12 = ((XUnit) ref xunit2).Point;
      xunit2 = PDFFunctions.pages[SAPInput.k].Height;
      double num23 = ((XUnit) ref xunit2).Point / 2.0;
      XRect xrect12 = new XRect(200.0, rc1_10, point12, num23);
      XStringFormat topLeft12 = XStringFormat.TopLeft;
      xgraphics12.DrawString(longDateString1, xfont21, (XBrush) black11, xrect12, topLeft12);
      checked { SAPInput.RC1 += 12; }
      XGraphics xgraphics13 = PDFFunctions.gfx[SAPInput.k];
      XFont xfont22 = xfont7;
      XSolidBrush black12 = XBrushes.Black;
      double rc1_11 = (double) SAPInput.RC1;
      xunit2 = PDFFunctions.pages[SAPInput.k].Width;
      double point13 = ((XUnit) ref xunit2).Point;
      xunit2 = PDFFunctions.pages[SAPInput.k].Height;
      double num24 = ((XUnit) ref xunit2).Point / 2.0;
      XRect xrect13 = new XRect(20.0, rc1_11, point13, num24);
      XStringFormat topLeft13 = XStringFormat.TopLeft;
      xgraphics13.DrawString("Date of certificate:", xfont22, (XBrush) black12, xrect13, topLeft13);
      XGraphics xgraphics14 = PDFFunctions.gfx[SAPInput.k];
      string longDateString2 = DateAndTime.Now.ToLongDateString();
      XFont xfont23 = xfont3;
      XSolidBrush black13 = XBrushes.Black;
      double rc1_12 = (double) SAPInput.RC1;
      xunit2 = PDFFunctions.pages[SAPInput.k].Width;
      double point14 = ((XUnit) ref xunit2).Point;
      xunit2 = PDFFunctions.pages[SAPInput.k].Height;
      double num25 = ((XUnit) ref xunit2).Point / 2.0;
      XRect xrect14 = new XRect(200.0, rc1_12, point14, num25);
      XStringFormat topLeft14 = XStringFormat.TopLeft;
      xgraphics14.DrawString(longDateString2, xfont23, (XBrush) black13, xrect14, topLeft14);
      checked { SAPInput.RC1 += 12; }
      XGraphics xgraphics15 = PDFFunctions.gfx[SAPInput.k];
      XFont xfont24 = xfont7;
      XSolidBrush black14 = XBrushes.Black;
      double rc1_13 = (double) SAPInput.RC1;
      xunit2 = PDFFunctions.pages[SAPInput.k].Width;
      double point15 = ((XUnit) ref xunit2).Point;
      xunit2 = PDFFunctions.pages[SAPInput.k].Height;
      double num26 = ((XUnit) ref xunit2).Point / 2.0;
      XRect xrect15 = new XRect(20.0, rc1_13, point15, num26);
      XStringFormat topLeft15 = XStringFormat.TopLeft;
      xgraphics15.DrawString("Assessment type:", xfont24, (XBrush) black14, xrect15, topLeft15);
      XGraphics xgraphics16 = PDFFunctions.gfx[SAPInput.k];
      // ISSUE: reference to a compiler-generated field
      string status = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Status;
      XFont xfont25 = xfont3;
      XSolidBrush black15 = XBrushes.Black;
      double rc1_14 = (double) SAPInput.RC1;
      xunit2 = PDFFunctions.pages[SAPInput.k].Width;
      double point16 = ((XUnit) ref xunit2).Point;
      xunit2 = PDFFunctions.pages[SAPInput.k].Height;
      double num27 = ((XUnit) ref xunit2).Point / 2.0;
      XRect xrect16 = new XRect(200.0, rc1_14, point16, num27);
      XStringFormat topLeft16 = XStringFormat.TopLeft;
      xgraphics16.DrawString(status, xfont25, (XBrush) black15, xrect16, topLeft16);
      checked { SAPInput.RC1 += 12; }
      XGraphics xgraphics17 = PDFFunctions.gfx[SAPInput.k];
      XFont xfont26 = xfont7;
      XSolidBrush black16 = XBrushes.Black;
      double rc1_15 = (double) SAPInput.RC1;
      xunit2 = PDFFunctions.pages[SAPInput.k].Width;
      double point17 = ((XUnit) ref xunit2).Point;
      xunit2 = PDFFunctions.pages[SAPInput.k].Height;
      double num28 = ((XUnit) ref xunit2).Point / 2.0;
      XRect xrect17 = new XRect(20.0, rc1_15, point17, num28);
      XStringFormat topLeft17 = XStringFormat.TopLeft;
      xgraphics17.DrawString("Transaction type:", xfont26, (XBrush) black16, xrect17, topLeft17);
      XGraphics xgraphics18 = PDFFunctions.gfx[SAPInput.k];
      // ISSUE: reference to a compiler-generated field
      string transaction = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Transaction;
      XFont xfont27 = xfont3;
      XSolidBrush black17 = XBrushes.Black;
      double rc1_16 = (double) SAPInput.RC1;
      xunit2 = PDFFunctions.pages[SAPInput.k].Width;
      double point18 = ((XUnit) ref xunit2).Point;
      xunit2 = PDFFunctions.pages[SAPInput.k].Height;
      double num29 = ((XUnit) ref xunit2).Point / 2.0;
      XRect xrect18 = new XRect(200.0, rc1_16, point18, num29);
      XStringFormat topLeft18 = XStringFormat.TopLeft;
      xgraphics18.DrawString(transaction, xfont27, (XBrush) black17, xrect18, topLeft18);
      checked { SAPInput.RC1 += 12; }
      int num30;
      try
      {
        XGraphics xgraphics19 = PDFFunctions.gfx[SAPInput.k];
        XFont xfont28 = xfont7;
        XSolidBrush black18 = XBrushes.Black;
        double rc1_17 = (double) SAPInput.RC1;
        xunit2 = PDFFunctions.pages[SAPInput.k].Width;
        double point19 = ((XUnit) ref xunit2).Point;
        xunit2 = PDFFunctions.pages[SAPInput.k].Height;
        double num31 = ((XUnit) ref xunit2).Point / 2.0;
        XRect xrect19 = new XRect(20.0, rc1_17, point19, num31);
        XStringFormat topLeft19 = XStringFormat.TopLeft;
        xgraphics19.DrawString("Tenure type:", xfont28, (XBrush) black18, xrect19, topLeft19);
        XGraphics xgraphics20 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string tenure = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Tenure;
        XFont xfont29 = xfont3;
        XSolidBrush black19 = XBrushes.Black;
        double rc1_18 = (double) SAPInput.RC1;
        xunit2 = PDFFunctions.pages[SAPInput.k].Width;
        double point20 = ((XUnit) ref xunit2).Point;
        xunit2 = PDFFunctions.pages[SAPInput.k].Height;
        double num32 = ((XUnit) ref xunit2).Point / 2.0;
        XRect xrect20 = new XRect(200.0, rc1_18, point20, num32);
        XStringFormat topLeft20 = XStringFormat.TopLeft;
        xgraphics20.DrawString(tenure, xfont29, (XBrush) black19, xrect20, topLeft20);
        checked { SAPInput.RC1 += 12; }
      }
      catch (Exception ex)
      {
        int lErl = num30;
        ProjectData.SetProjectError(ex, lErl);
        ProjectData.ClearProjectError();
      }
      XGraphics xgraphics21 = PDFFunctions.gfx[SAPInput.k];
      XFont xfont30 = xfont7;
      XSolidBrush black20 = XBrushes.Black;
      double rc1_19 = (double) SAPInput.RC1;
      XUnit width4 = PDFFunctions.pages[SAPInput.k].Width;
      double point21 = ((XUnit) ref width4).Point;
      XUnit height2 = PDFFunctions.pages[SAPInput.k].Height;
      double num33 = ((XUnit) ref height2).Point / 2.0;
      XRect xrect21 = new XRect(20.0, rc1_19, point21, num33);
      XStringFormat topLeft21 = XStringFormat.TopLeft;
      xgraphics21.DrawString("Related party disclosure:", xfont30, (XBrush) black20, xrect21, topLeft21);
      XGraphics xgraphics22 = PDFFunctions.gfx[SAPInput.k];
      // ISSUE: reference to a compiler-generated field
      string rpd = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].RPD;
      XFont xfont31 = xfont3;
      XSolidBrush black21 = XBrushes.Black;
      double rc1_20 = (double) SAPInput.RC1;
      XUnit xunit3 = PDFFunctions.pages[SAPInput.k].Width;
      double point22 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[SAPInput.k].Height;
      double num34 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect22 = new XRect(200.0, rc1_20, point22, num34);
      XStringFormat topLeft22 = XStringFormat.TopLeft;
      xgraphics22.DrawString(rpd, xfont31, (XBrush) black21, xrect22, topLeft22);
      checked { SAPInput.RC1 += 12; }
      // ISSUE: reference to a compiler-generated field
      if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].TMP.Type, "User Value", false) == 0)
      {
        XGraphics xgraphics23 = PDFFunctions.gfx[SAPInput.k];
        XFont xfont32 = xfont7;
        XSolidBrush black22 = XBrushes.Black;
        double rc1_21 = (double) SAPInput.RC1;
        xunit3 = PDFFunctions.pages[SAPInput.k].Width;
        double point23 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[SAPInput.k].Height;
        double num35 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect23 = new XRect(20.0, rc1_21, point23, num35);
        XStringFormat topLeft23 = XStringFormat.TopLeft;
        xgraphics23.DrawString("User Value:", xfont32, (XBrush) black22, xrect23, topLeft23);
        XGraphics xgraphics24 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string str4 = "TMP = " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].TMP.UserDefined) + "kJ/m\u00B2K";
        XFont xfont33 = xfont3;
        XSolidBrush black23 = XBrushes.Black;
        double rc1_22 = (double) SAPInput.RC1;
        xunit3 = PDFFunctions.pages[SAPInput.k].Width;
        double point24 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[SAPInput.k].Height;
        double num36 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect24 = new XRect(200.0, rc1_22, point24, num36);
        XStringFormat topLeft24 = XStringFormat.TopLeft;
        xgraphics24.DrawString(str4, xfont33, (XBrush) black23, xrect24, topLeft24);
        checked { SAPInput.RC1 += 12; }
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].TMP.Type, "Indicative Value", false) == 0)
        {
          XGraphics xgraphics25 = PDFFunctions.gfx[SAPInput.k];
          XFont xfont34 = xfont7;
          XSolidBrush black24 = XBrushes.Black;
          double rc1_23 = (double) SAPInput.RC1;
          xunit3 = PDFFunctions.pages[SAPInput.k].Width;
          double point25 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[SAPInput.k].Height;
          double num37 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect25 = new XRect(20.0, rc1_23, point25, num37);
          XStringFormat topLeft25 = XStringFormat.TopLeft;
          xgraphics25.DrawString("Thermal Mass Parameter:", xfont34, (XBrush) black24, xrect25, topLeft25);
          XGraphics xgraphics26 = PDFFunctions.gfx[SAPInput.k];
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          string str5 = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].TMP.Type + " " + SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].TMP.Indicative;
          XFont xfont35 = xfont3;
          XSolidBrush black25 = XBrushes.Black;
          double rc1_24 = (double) SAPInput.RC1;
          xunit3 = PDFFunctions.pages[SAPInput.k].Width;
          double point26 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[SAPInput.k].Height;
          double num38 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect26 = new XRect(200.0, rc1_24, point26, num38);
          XStringFormat topLeft26 = XStringFormat.TopLeft;
          xgraphics26.DrawString(str5, xfont35, (XBrush) black25, xrect26, topLeft26);
          checked { SAPInput.RC1 += 12; }
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].TMP.Type, "Calculated", false) == 0)
          {
            XGraphics xgraphics27 = PDFFunctions.gfx[SAPInput.k];
            XFont xfont36 = xfont7;
            XSolidBrush black26 = XBrushes.Black;
            double rc1_25 = (double) SAPInput.RC1;
            xunit3 = PDFFunctions.pages[SAPInput.k].Width;
            double point27 = ((XUnit) ref xunit3).Point;
            xunit3 = PDFFunctions.pages[SAPInput.k].Height;
            double num39 = ((XUnit) ref xunit3).Point / 2.0;
            XRect xrect27 = new XRect(20.0, rc1_25, point27, num39);
            XStringFormat topLeft27 = XStringFormat.TopLeft;
            xgraphics27.DrawString("Thermal Mass Parameter:", xfont36, (XBrush) black26, xrect27, topLeft27);
            XGraphics xgraphics28 = PDFFunctions.gfx[SAPInput.k];
            string str6 = "Calculated " + Conversions.ToString(Math.Round(SAP_Module.Calculation2012.Calculation.HeatLoss.Box35, 2));
            XFont xfont37 = xfont3;
            XSolidBrush black27 = XBrushes.Black;
            double rc1_26 = (double) SAPInput.RC1;
            xunit3 = PDFFunctions.pages[SAPInput.k].Width;
            double point28 = ((XUnit) ref xunit3).Point;
            xunit3 = PDFFunctions.pages[SAPInput.k].Height;
            double num40 = ((XUnit) ref xunit3).Point / 2.0;
            XRect xrect28 = new XRect(200.0, rc1_26, point28, num40);
            XStringFormat topLeft28 = XStringFormat.TopLeft;
            xgraphics28.DrawString(str6, xfont37, (XBrush) black27, xrect28, topLeft28);
            checked { SAPInput.RC1 += 12; }
          }
        }
      }
      if ((uint) Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Address.Country, "Scotland", false) > 0U)
      {
        XGraphics xgraphics29 = PDFFunctions.gfx[SAPInput.k];
        XFont xfont38 = xfont7;
        XSolidBrush black28 = XBrushes.Black;
        double rc1_27 = (double) SAPInput.RC1;
        xunit3 = PDFFunctions.pages[SAPInput.k].Width;
        double point29 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[SAPInput.k].Height;
        double num41 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect29 = new XRect(20.0, rc1_27, point29, num41);
        XStringFormat topLeft29 = XStringFormat.TopLeft;
        xgraphics29.DrawString("Water use <= 125 litres/person/day:", xfont38, (XBrush) black28, xrect29, topLeft29);
        XGraphics xgraphics30 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string str7 = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].LessThan125Litre.ToString();
        XFont xfont39 = xfont3;
        XSolidBrush black29 = XBrushes.Black;
        double rc1_28 = (double) SAPInput.RC1;
        xunit3 = PDFFunctions.pages[SAPInput.k].Width;
        double point30 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[SAPInput.k].Height;
        double num42 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect30 = new XRect(230.0, rc1_28, point30, num42);
        XStringFormat topLeft30 = XStringFormat.TopLeft;
        xgraphics30.DrawString(str7, xfont39, (XBrush) black29, xrect30, topLeft30);
        checked { SAPInput.RC1 += 12; }
      }
      XGraphics xgraphics31 = PDFFunctions.gfx[SAPInput.k];
      XFont xfont40 = xfont7;
      XSolidBrush black30 = XBrushes.Black;
      double rc1_29 = (double) SAPInput.RC1;
      xunit3 = PDFFunctions.pages[SAPInput.k].Width;
      double point31 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[SAPInput.k].Height;
      double num43 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect31 = new XRect(20.0, rc1_29, point31, num43);
      XStringFormat topLeft31 = XStringFormat.TopLeft;
      xgraphics31.DrawString("PCDF Version: ", xfont40, (XBrush) black30, xrect31, topLeft31);
      XGraphics xgraphics32 = PDFFunctions.gfx[SAPInput.k];
      string version = SAP_Module.PCDFData.Version;
      XFont xfont41 = xfont3;
      XSolidBrush black31 = XBrushes.Black;
      double rc1_30 = (double) SAPInput.RC1;
      xunit3 = PDFFunctions.pages[SAPInput.k].Width;
      double point32 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[SAPInput.k].Height;
      double num44 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect32 = new XRect(200.0, rc1_30, point32, num44);
      XStringFormat topLeft32 = XStringFormat.TopLeft;
      xgraphics32.DrawString(version, xfont41, (XBrush) black31, xrect32, topLeft32);
      checked { SAPInput.RC1 += 12; }
      checked { SAPInput.RC1 += 18; }
      PDFFunctions.xBrush1 = XBrush.op_Implicit((Brush) new SolidBrush(Color.FromArgb(159, 172, 62)));
      PDFFunctions.Points[0].X = 20f;
      PDFFunctions.Points[0].Y = (float) SAPInput.RC1;
      ref PointF local3 = ref PDFFunctions.Points[1];
      xunit3 = PDFFunctions.pages[SAPInput.k].Width;
      double num45 = ((XUnit) ref xunit3).Point - 20.0;
      local3.X = (float) num45;
      PDFFunctions.Points[1].Y = (float) SAPInput.RC1;
      ref PointF local4 = ref PDFFunctions.Points[2];
      xunit3 = PDFFunctions.pages[SAPInput.k].Width;
      double num46 = ((XUnit) ref xunit3).Point - 20.0;
      local4.X = (float) num46;
      PDFFunctions.Points[2].Y = (float) checked (SAPInput.RC1 + 14);
      PDFFunctions.Points[3].X = 20f;
      PDFFunctions.Points[3].Y = (float) checked (SAPInput.RC1 + 14);
      PDFFunctions.gfx[SAPInput.k].DrawPolygon(PDFFunctions.polyGreen2, PDFFunctions.xBrush1, PDFFunctions.Points, xfillMode);
      XGraphics xgraphics33 = PDFFunctions.gfx[SAPInput.k];
      XFont xfont42 = xfont3;
      XSolidBrush white2 = XBrushes.White;
      double num47 = (double) checked (SAPInput.RC1 + 1);
      xunit3 = PDFFunctions.pages[SAPInput.k].Width;
      double point33 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[SAPInput.k].Height;
      double num48 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect33 = new XRect(25.0, num47, point33, num48);
      XStringFormat topLeft33 = XStringFormat.TopLeft;
      xgraphics33.DrawString("Property description:", xfont42, (XBrush) white2, xrect33, topLeft33);
      SAPInput.RC1 = checked ((int) Math.Round(unchecked ((double) PDFFunctions.Points[3].Y + 4.0)));
      XGraphics xgraphics34 = PDFFunctions.gfx[SAPInput.k];
      XFont xfont43 = xfont2;
      XSolidBrush black32 = XBrushes.Black;
      double rc1_31 = (double) SAPInput.RC1;
      xunit3 = PDFFunctions.pages[SAPInput.k].Width;
      double point34 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[SAPInput.k].Height;
      double num49 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect34 = new XRect(20.0, rc1_31, point34, num49);
      XStringFormat topLeft34 = XStringFormat.TopLeft;
      xgraphics34.DrawString("Dwelling type:", xfont43, (XBrush) black32, xrect34, topLeft34);
      XGraphics xgraphics35 = PDFFunctions.gfx[SAPInput.k];
      // ISSUE: reference to a compiler-generated field
      string propertyType = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].PropertyType;
      XFont xfont44 = xfont3;
      XSolidBrush black33 = XBrushes.Black;
      double rc1_32 = (double) SAPInput.RC1;
      xunit3 = PDFFunctions.pages[SAPInput.k].Width;
      double point35 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[SAPInput.k].Height;
      double num50 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect35 = new XRect(200.0, rc1_32, point35, num50);
      XStringFormat topLeft35 = XStringFormat.TopLeft;
      xgraphics35.DrawString(propertyType, xfont44, (XBrush) black33, xrect35, topLeft35);
      checked { SAPInput.RC1 += 12; }
      XGraphics xgraphics36 = PDFFunctions.gfx[SAPInput.k];
      XFont xfont45 = xfont2;
      XSolidBrush black34 = XBrushes.Black;
      double rc1_33 = (double) SAPInput.RC1;
      xunit3 = PDFFunctions.pages[SAPInput.k].Width;
      double point36 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[SAPInput.k].Height;
      double num51 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect36 = new XRect(20.0, rc1_33, point36, num51);
      XStringFormat topLeft36 = XStringFormat.TopLeft;
      xgraphics36.DrawString("Detachment:", xfont45, (XBrush) black34, xrect36, topLeft36);
      XGraphics xgraphics37 = PDFFunctions.gfx[SAPInput.k];
      // ISSUE: reference to a compiler-generated field
      string buildForm = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].BuildForm;
      XFont xfont46 = xfont3;
      XSolidBrush black35 = XBrushes.Black;
      double rc1_34 = (double) SAPInput.RC1;
      xunit3 = PDFFunctions.pages[SAPInput.k].Width;
      double point37 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[SAPInput.k].Height;
      double num52 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect37 = new XRect(200.0, rc1_34, point37, num52);
      XStringFormat topLeft37 = XStringFormat.TopLeft;
      xgraphics37.DrawString(buildForm, xfont46, (XBrush) black35, xrect37, topLeft37);
      checked { SAPInput.RC1 += 12; }
      XGraphics xgraphics38 = PDFFunctions.gfx[SAPInput.k];
      XFont xfont47 = xfont2;
      XSolidBrush black36 = XBrushes.Black;
      double rc1_35 = (double) SAPInput.RC1;
      xunit3 = PDFFunctions.pages[SAPInput.k].Width;
      double point38 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[SAPInput.k].Height;
      double num53 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect38 = new XRect(20.0, rc1_35, point38, num53);
      XStringFormat topLeft38 = XStringFormat.TopLeft;
      xgraphics38.DrawString("Year Completed:", xfont47, (XBrush) black36, xrect38, topLeft38);
      XGraphics xgraphics39 = PDFFunctions.gfx[SAPInput.k];
      // ISSUE: reference to a compiler-generated field
      string str8 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].YearBuilt);
      XFont xfont48 = xfont3;
      XSolidBrush black37 = XBrushes.Black;
      double rc1_36 = (double) SAPInput.RC1;
      xunit3 = PDFFunctions.pages[SAPInput.k].Width;
      double point39 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[SAPInput.k].Height;
      double num54 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect39 = new XRect(200.0, rc1_36, point39, num54);
      XStringFormat topLeft39 = XStringFormat.TopLeft;
      xgraphics39.DrawString(str8, xfont48, (XBrush) black37, xrect39, topLeft39);
      checked { SAPInput.RC1 += 16; }
      XGraphics xgraphics40 = PDFFunctions.gfx[SAPInput.k];
      XFont xfont49 = xfont7;
      XSolidBrush black38 = XBrushes.Black;
      double rc1_37 = (double) SAPInput.RC1;
      xunit3 = PDFFunctions.pages[SAPInput.k].Width;
      double point40 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[SAPInput.k].Height;
      double num55 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect40 = new XRect(20.0, rc1_37, point40, num55);
      XStringFormat topLeft40 = XStringFormat.TopLeft;
      xgraphics40.DrawString("Floor Location:", xfont49, (XBrush) black38, xrect40, topLeft40);
      XGraphics xgraphics41 = PDFFunctions.gfx[SAPInput.k];
      XFont xfont50 = xfont7;
      XSolidBrush black39 = XBrushes.Black;
      double rc1_38 = (double) SAPInput.RC1;
      xunit3 = PDFFunctions.pages[SAPInput.k].Width;
      double point41 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[SAPInput.k].Height;
      double num56 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect41 = new XRect(200.0, rc1_38, point41, num56);
      XStringFormat topLeft41 = XStringFormat.TopLeft;
      xgraphics41.DrawString("Floor area:", xfont50, (XBrush) black39, xrect41, topLeft41);
      checked { SAPInput.RC1 += 12; }
      if (Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Address.Country, "Scotland", false) == 0)
      {
        XGraphics xgraphics42 = PDFFunctions.gfx[SAPInput.k];
        XFont xfont51 = xfont7;
        XSolidBrush black40 = XBrushes.Black;
        double rc1_39 = (double) SAPInput.RC1;
        xunit3 = PDFFunctions.pages[SAPInput.k].Width;
        double point42 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[SAPInput.k].Height;
        double num57 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect42 = new XRect(20.0, rc1_39, point42, num57);
        XStringFormat topLeft42 = XStringFormat.TopLeft;
        xgraphics42.DrawString("Number of dwellings above:", xfont51, (XBrush) black40, xrect42, topLeft42);
        XGraphics xgraphics43 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string str9 = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].NoOFDwellingsAbove.ToString();
        XFont xfont52 = xfont3;
        XSolidBrush black41 = XBrushes.Black;
        double rc1_40 = (double) SAPInput.RC1;
        xunit3 = PDFFunctions.pages[SAPInput.k].Width;
        double point43 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[SAPInput.k].Height;
        double num58 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect43 = new XRect(230.0, rc1_40, point43, num58);
        XStringFormat topLeft43 = XStringFormat.TopLeft;
        xgraphics43.DrawString(str9, xfont52, (XBrush) black41, xrect43, topLeft43);
        checked { SAPInput.RC1 += 12; }
      }
      if (Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Address.Country, "Scotland", false) == 0)
      {
        XGraphics xgraphics44 = PDFFunctions.gfx[SAPInput.k];
        XFont xfont53 = xfont7;
        XSolidBrush black42 = XBrushes.Black;
        double rc1_41 = (double) SAPInput.RC1;
        xunit3 = PDFFunctions.pages[SAPInput.k].Width;
        double point44 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[SAPInput.k].Height;
        double num59 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect44 = new XRect(20.0, rc1_41, point44, num59);
        XStringFormat topLeft44 = XStringFormat.TopLeft;
        xgraphics44.DrawString("Number of dwellings below:", xfont53, (XBrush) black42, xrect44, topLeft44);
        XGraphics xgraphics45 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string str10 = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].NoOFDwellingsBelow.ToString();
        XFont xfont54 = xfont3;
        XSolidBrush black43 = XBrushes.Black;
        double rc1_42 = (double) SAPInput.RC1;
        xunit3 = PDFFunctions.pages[SAPInput.k].Width;
        double point45 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[SAPInput.k].Height;
        double num60 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect45 = new XRect(230.0, rc1_42, point45, num60);
        XStringFormat topLeft45 = XStringFormat.TopLeft;
        xgraphics45.DrawString(str10, xfont54, (XBrush) black43, xrect45, topLeft45);
        checked { SAPInput.RC1 += 12; }
      }
      XGraphics xgraphics46 = PDFFunctions.gfx[SAPInput.k];
      XFont xfont55 = xfont7;
      XSolidBrush black44 = XBrushes.Black;
      double rc1_43 = (double) SAPInput.RC1;
      xunit3 = PDFFunctions.pages[SAPInput.k].Width;
      double point46 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[SAPInput.k].Height;
      double num61 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect46 = new XRect(365.0, rc1_43, point46, num61);
      XStringFormat topLeft46 = XStringFormat.TopLeft;
      xgraphics46.DrawString("Storey height:", xfont55, (XBrush) black44, xrect46, topLeft46);
      checked { SAPInput.RC1 += 15; }
      // ISSUE: reference to a compiler-generated field
      int num62 = checked (SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Storeys - 1);
      int index1 = 0;
      while (index1 <= num62)
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        string str11 = Operators.CompareString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Dims[index1].Basement, (string) null, false) != 0 ? (Operators.CompareString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Dims[index1].Basement, "Yes", false) != 0 ? "Floor " + Conversions.ToString(index1) : "Basement floor") : "Floor " + Conversions.ToString(index1);
        XGraphics xgraphics47 = PDFFunctions.gfx[SAPInput.k];
        string str12 = str11;
        XFont xfont56 = xfont2;
        XSolidBrush black45 = XBrushes.Black;
        double rc1_44 = (double) SAPInput.RC1;
        xunit3 = PDFFunctions.pages[SAPInput.k].Width;
        double point47 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[SAPInput.k].Height;
        double num63 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect47 = new XRect(20.0, rc1_44, point47, num63);
        XStringFormat topLeft47 = XStringFormat.TopLeft;
        xgraphics47.DrawString(str12, xfont56, (XBrush) black45, xrect47, topLeft47);
        XGraphics xgraphics48 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string str13 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Dims[index1].Area) + " m\u00B2";
        XFont xfont57 = xfont3;
        XSolidBrush black46 = XBrushes.Black;
        double rc1_45 = (double) SAPInput.RC1;
        xunit3 = PDFFunctions.pages[SAPInput.k].Width;
        double point48 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[SAPInput.k].Height;
        double num64 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect48 = new XRect(200.0, rc1_45, point48, num64);
        XStringFormat topLeft48 = XStringFormat.TopLeft;
        xgraphics48.DrawString(str13, xfont57, (XBrush) black46, xrect48, topLeft48);
        XGraphics xgraphics49 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string str14 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Dims[index1].Height) + " m";
        XFont xfont58 = xfont3;
        XSolidBrush black47 = XBrushes.Black;
        double rc1_46 = (double) SAPInput.RC1;
        xunit3 = PDFFunctions.pages[SAPInput.k].Width;
        double point49 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[SAPInput.k].Height;
        double num65 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect49 = new XRect(375.0, rc1_46, point49, num65);
        XStringFormat topLeft49 = XStringFormat.TopLeft;
        xgraphics49.DrawString(str14, xfont58, (XBrush) black47, xrect49, topLeft49);
        checked { SAPInput.RC1 += 12; }
        checked { ++index1; }
      }
      checked { SAPInput.RC1 += 4; }
      XGraphics xgraphics50 = PDFFunctions.gfx[SAPInput.k];
      XFont xfont59 = xfont2;
      XSolidBrush black48 = XBrushes.Black;
      double rc1_47 = (double) SAPInput.RC1;
      xunit3 = PDFFunctions.pages[SAPInput.k].Width;
      double point50 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[SAPInput.k].Height;
      double num66 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect50 = new XRect(20.0, rc1_47, point50, num66);
      XStringFormat topLeft50 = XStringFormat.TopLeft;
      xgraphics50.DrawString("Living area:", xfont59, (XBrush) black48, xrect50, topLeft50);
      XGraphics xgraphics51 = PDFFunctions.gfx[SAPInput.k];
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      string str15 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].LivingArea) + " m\u00B2  (fraction " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].LivingFraction) + ")";
      XFont xfont60 = xfont3;
      XSolidBrush black49 = XBrushes.Black;
      double rc1_48 = (double) SAPInput.RC1;
      xunit3 = PDFFunctions.pages[SAPInput.k].Width;
      double point51 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[SAPInput.k].Height;
      double num67 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect51 = new XRect(200.0, rc1_48, point51, num67);
      XStringFormat topLeft51 = XStringFormat.TopLeft;
      xgraphics51.DrawString(str15, xfont60, (XBrush) black49, xrect51, topLeft51);
      checked { SAPInput.RC1 += 12; }
      XGraphics xgraphics52 = PDFFunctions.gfx[SAPInput.k];
      XFont xfont61 = xfont2;
      XSolidBrush black50 = XBrushes.Black;
      double rc1_49 = (double) SAPInput.RC1;
      xunit3 = PDFFunctions.pages[SAPInput.k].Width;
      double point52 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[SAPInput.k].Height;
      double num68 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect52 = new XRect(20.0, rc1_49, point52, num68);
      XStringFormat topLeft52 = XStringFormat.TopLeft;
      xgraphics52.DrawString("Front of dwelling faces:", xfont61, (XBrush) black50, xrect52, topLeft52);
      XGraphics xgraphics53 = PDFFunctions.gfx[SAPInput.k];
      // ISSUE: reference to a compiler-generated field
      string orientation1 = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Orientation;
      XFont xfont62 = xfont3;
      XSolidBrush black51 = XBrushes.Black;
      double rc1_50 = (double) SAPInput.RC1;
      xunit3 = PDFFunctions.pages[SAPInput.k].Width;
      double point53 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[SAPInput.k].Height;
      double num69 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect53 = new XRect(200.0, rc1_50, point53, num69);
      XStringFormat topLeft53 = XStringFormat.TopLeft;
      xgraphics53.DrawString(orientation1, xfont62, (XBrush) black51, xrect53, topLeft53);
      checked { SAPInput.RC1 += 16; }
      PDFFunctions.xBrush1 = XBrush.op_Implicit((Brush) new SolidBrush(Color.FromArgb(159, 172, 62)));
      PDFFunctions.Points[0].X = 20f;
      PDFFunctions.Points[0].Y = (float) SAPInput.RC1;
      ref PointF local5 = ref PDFFunctions.Points[1];
      xunit3 = PDFFunctions.pages[SAPInput.k].Width;
      double num70 = ((XUnit) ref xunit3).Point - 20.0;
      local5.X = (float) num70;
      PDFFunctions.Points[1].Y = (float) SAPInput.RC1;
      ref PointF local6 = ref PDFFunctions.Points[2];
      xunit3 = PDFFunctions.pages[SAPInput.k].Width;
      double num71 = ((XUnit) ref xunit3).Point - 20.0;
      local6.X = (float) num71;
      PDFFunctions.Points[2].Y = (float) checked (SAPInput.RC1 + 14);
      PDFFunctions.Points[3].X = 20f;
      PDFFunctions.Points[3].Y = (float) checked (SAPInput.RC1 + 14);
      PDFFunctions.gfx[SAPInput.k].DrawPolygon(PDFFunctions.polyGreen2, PDFFunctions.xBrush1, PDFFunctions.Points, xfillMode);
      XGraphics xgraphics54 = PDFFunctions.gfx[SAPInput.k];
      XFont xfont63 = xfont3;
      XSolidBrush white3 = XBrushes.White;
      double num72 = (double) checked (SAPInput.RC1 + 1);
      xunit3 = PDFFunctions.pages[SAPInput.k].Width;
      double point54 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[SAPInput.k].Height;
      double num73 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect54 = new XRect(25.0, num72, point54, num73);
      XStringFormat topLeft54 = XStringFormat.TopLeft;
      xgraphics54.DrawString("Opening types:", xfont63, (XBrush) white3, xrect54, topLeft54);
      SAPInput.RC1 = checked ((int) Math.Round(unchecked ((double) PDFFunctions.Points[3].Y + 4.0)));
      XGraphics xgraphics55 = PDFFunctions.gfx[SAPInput.k];
      XFont xfont64 = xfont7;
      XSolidBrush black52 = XBrushes.Black;
      double rc1_51 = (double) SAPInput.RC1;
      xunit3 = PDFFunctions.pages[SAPInput.k].Width;
      double point55 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[SAPInput.k].Height;
      double num74 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect55 = new XRect(20.0, rc1_51, point55, num74);
      XStringFormat topLeft55 = XStringFormat.TopLeft;
      xgraphics55.DrawString("Name:", xfont64, (XBrush) black52, xrect55, topLeft55);
      XGraphics xgraphics56 = PDFFunctions.gfx[SAPInput.k];
      XFont xfont65 = xfont7;
      XSolidBrush black53 = XBrushes.Black;
      double rc1_52 = (double) SAPInput.RC1;
      xunit3 = PDFFunctions.pages[SAPInput.k].Width;
      double point56 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[SAPInput.k].Height;
      double num75 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect56 = new XRect(110.0, rc1_52, point56, num75);
      XStringFormat topLeft56 = XStringFormat.TopLeft;
      xgraphics56.DrawString("Source:", xfont65, (XBrush) black53, xrect56, topLeft56);
      XGraphics xgraphics57 = PDFFunctions.gfx[SAPInput.k];
      XFont xfont66 = xfont7;
      XSolidBrush black54 = XBrushes.Black;
      double rc1_53 = (double) SAPInput.RC1;
      xunit3 = PDFFunctions.pages[SAPInput.k].Width;
      double point57 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[SAPInput.k].Height;
      double num76 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect57 = new XRect(220.0, rc1_53, point57, num76);
      XStringFormat topLeft57 = XStringFormat.TopLeft;
      xgraphics57.DrawString("Type:", xfont66, (XBrush) black54, xrect57, topLeft57);
      XGraphics xgraphics58 = PDFFunctions.gfx[SAPInput.k];
      XFont xfont67 = xfont7;
      XSolidBrush black55 = XBrushes.Black;
      double rc1_54 = (double) SAPInput.RC1;
      xunit3 = PDFFunctions.pages[SAPInput.k].Width;
      double point58 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[SAPInput.k].Height;
      double num77 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect58 = new XRect(320.0, rc1_54, point58, num77);
      XStringFormat topLeft58 = XStringFormat.TopLeft;
      xgraphics58.DrawString("Glazing:", xfont67, (XBrush) black55, xrect58, topLeft58);
      XGraphics xgraphics59 = PDFFunctions.gfx[SAPInput.k];
      XFont xfont68 = xfont7;
      XSolidBrush black56 = XBrushes.Black;
      double rc1_55 = (double) SAPInput.RC1;
      xunit3 = PDFFunctions.pages[SAPInput.k].Width;
      double point59 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[SAPInput.k].Height;
      double num78 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect59 = new XRect(440.0, rc1_55, point59, num78);
      XStringFormat topLeft59 = XStringFormat.TopLeft;
      xgraphics59.DrawString("Argon:", xfont68, (XBrush) black56, xrect59, topLeft59);
      XGraphics xgraphics60 = PDFFunctions.gfx[SAPInput.k];
      XFont xfont69 = xfont7;
      XSolidBrush black57 = XBrushes.Black;
      double rc1_56 = (double) SAPInput.RC1;
      xunit3 = PDFFunctions.pages[SAPInput.k].Width;
      double point60 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[SAPInput.k].Height;
      double num79 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect60 = new XRect(500.0, rc1_56, point60, num79);
      XStringFormat topLeft60 = XStringFormat.TopLeft;
      xgraphics60.DrawString("Frame:", xfont69, (XBrush) black57, xrect60, topLeft60);
      checked { SAPInput.RC1 += 14; }
      // ISSUE: reference to a compiler-generated field
      int num80 = checked (SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].NoofDoors - 1);
      int index2 = 0;
      while (index2 <= num80)
      {
        XGraphics xgraphics61 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string name = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Doors[index2].Name;
        XFont xfont70 = xfont3;
        XSolidBrush black58 = XBrushes.Black;
        double rc1_57 = (double) SAPInput.RC1;
        xunit3 = PDFFunctions.pages[SAPInput.k].Width;
        double point61 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[SAPInput.k].Height;
        double num81 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect61 = new XRect(20.0, rc1_57, point61, num81);
        XStringFormat topLeft61 = XStringFormat.TopLeft;
        xgraphics61.DrawString(name, xfont70, (XBrush) black58, xrect61, topLeft61);
        XGraphics xgraphics62 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string uvalueSource = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Doors[index2].UValueSource;
        XFont xfont71 = xfont3;
        XSolidBrush black59 = XBrushes.Black;
        double rc1_58 = (double) SAPInput.RC1;
        xunit3 = PDFFunctions.pages[SAPInput.k].Width;
        double point62 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[SAPInput.k].Height;
        double num82 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect62 = new XRect(110.0, rc1_58, point62, num82);
        XStringFormat topLeft62 = XStringFormat.TopLeft;
        xgraphics62.DrawString(uvalueSource, xfont71, (XBrush) black59, xrect62, topLeft62);
        XGraphics xgraphics63 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string doorType = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Doors[index2].DoorType;
        XFont xfont72 = xfont3;
        XSolidBrush black60 = XBrushes.Black;
        double rc1_59 = (double) SAPInput.RC1;
        xunit3 = PDFFunctions.pages[SAPInput.k].Width;
        double point63 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[SAPInput.k].Height;
        double num83 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect63 = new XRect(220.0, rc1_59, point63, num83);
        XStringFormat topLeft63 = XStringFormat.TopLeft;
        xgraphics63.DrawString(doorType, xfont72, (XBrush) black60, xrect63, topLeft63);
        XGraphics xgraphics64 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string str16 = Conversions.ToString(SAPInput.CheckDoubleGlazed(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Doors[index2].GlazingType));
        XFont xfont73 = xfont3;
        XSolidBrush black61 = XBrushes.Black;
        double rc1_60 = (double) SAPInput.RC1;
        xunit3 = PDFFunctions.pages[SAPInput.k].Width;
        double point64 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[SAPInput.k].Height;
        double num84 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect64 = new XRect(320.0, rc1_60, point64, num84);
        XStringFormat topLeft64 = XStringFormat.TopLeft;
        xgraphics64.DrawString(str16, xfont73, (XBrush) black61, xrect64, topLeft64);
        // ISSUE: reference to a compiler-generated field
        if ((uint) Operators.CompareString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Doors[index2].GlazingType, (string) null, false) > 0U)
        {
          // ISSUE: reference to a compiler-generated field
          if (SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Doors[index2].GlazingType.Contains("argon"))
          {
            XGraphics xgraphics65 = PDFFunctions.gfx[SAPInput.k];
            XFont xfont74 = xfont3;
            XSolidBrush black62 = XBrushes.Black;
            double rc1_61 = (double) SAPInput.RC1;
            xunit3 = PDFFunctions.pages[SAPInput.k].Width;
            double point65 = ((XUnit) ref xunit3).Point;
            xunit3 = PDFFunctions.pages[SAPInput.k].Height;
            double num85 = ((XUnit) ref xunit3).Point / 2.0;
            XRect xrect65 = new XRect(440.0, rc1_61, point65, num85);
            XStringFormat topLeft65 = XStringFormat.TopLeft;
            xgraphics65.DrawString("Yes", xfont74, (XBrush) black62, xrect65, topLeft65);
          }
          else
          {
            XGraphics xgraphics66 = PDFFunctions.gfx[SAPInput.k];
            XFont xfont75 = xfont3;
            XSolidBrush black63 = XBrushes.Black;
            double rc1_62 = (double) SAPInput.RC1;
            xunit3 = PDFFunctions.pages[SAPInput.k].Width;
            double point66 = ((XUnit) ref xunit3).Point;
            xunit3 = PDFFunctions.pages[SAPInput.k].Height;
            double num86 = ((XUnit) ref xunit3).Point / 2.0;
            XRect xrect66 = new XRect(440.0, rc1_62, point66, num86);
            XStringFormat topLeft66 = XStringFormat.TopLeft;
            xgraphics66.DrawString("No", xfont75, (XBrush) black63, xrect66, topLeft66);
          }
        }
        // ISSUE: reference to a compiler-generated field
        if ((uint) Operators.CompareString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Doors[index2].FrameType, (string) null, false) > 0U)
        {
          XGraphics xgraphics67 = PDFFunctions.gfx[SAPInput.k];
          // ISSUE: reference to a compiler-generated field
          string frameType = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Doors[index2].FrameType;
          XFont xfont76 = xfont3;
          XSolidBrush black64 = XBrushes.Black;
          double rc1_63 = (double) SAPInput.RC1;
          xunit3 = PDFFunctions.pages[SAPInput.k].Width;
          double point67 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[SAPInput.k].Height;
          double num87 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect67 = new XRect(500.0, rc1_63, point67, num87);
          XStringFormat topLeft67 = XStringFormat.TopLeft;
          xgraphics67.DrawString(frameType, xfont76, (XBrush) black64, xrect67, topLeft67);
        }
        checked { SAPInput.RC1 += 12; }
        SAPInput.CheckRC1();
        checked { ++index2; }
      }
      // ISSUE: reference to a compiler-generated field
      int num88 = checked (SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].NoofWindows - 1);
      int index3 = 0;
      while (index3 <= num88)
      {
        XGraphics xgraphics68 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string name = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Windows[index3].Name;
        XFont xfont77 = xfont3;
        XSolidBrush black65 = XBrushes.Black;
        double rc1_64 = (double) SAPInput.RC1;
        xunit3 = PDFFunctions.pages[SAPInput.k].Width;
        double point68 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[SAPInput.k].Height;
        double num89 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect68 = new XRect(20.0, rc1_64, point68, num89);
        XStringFormat topLeft68 = XStringFormat.TopLeft;
        xgraphics68.DrawString(name, xfont77, (XBrush) black65, xrect68, topLeft68);
        // ISSUE: reference to a compiler-generated field
        if ((uint) Operators.CompareString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Windows[index3].UValueSource, (string) null, false) > 0U)
        {
          XGraphics xgraphics69 = PDFFunctions.gfx[SAPInput.k];
          // ISSUE: reference to a compiler-generated field
          string uvalueSource = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Windows[index3].UValueSource;
          XFont xfont78 = xfont3;
          XSolidBrush black66 = XBrushes.Black;
          double rc1_65 = (double) SAPInput.RC1;
          xunit3 = PDFFunctions.pages[SAPInput.k].Width;
          double point69 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[SAPInput.k].Height;
          double num90 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect69 = new XRect(110.0, rc1_65, point69, num90);
          XStringFormat topLeft69 = XStringFormat.TopLeft;
          xgraphics69.DrawString(uvalueSource, xfont78, (XBrush) black66, xrect69, topLeft69);
        }
        XGraphics xgraphics70 = PDFFunctions.gfx[SAPInput.k];
        XFont xfont79 = xfont3;
        XSolidBrush black67 = XBrushes.Black;
        double rc1_66 = (double) SAPInput.RC1;
        xunit3 = PDFFunctions.pages[SAPInput.k].Width;
        double point70 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[SAPInput.k].Height;
        double num91 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect70 = new XRect(220.0, rc1_66, point70, num91);
        XStringFormat topLeft70 = XStringFormat.TopLeft;
        xgraphics70.DrawString("Windows", xfont79, (XBrush) black67, xrect70, topLeft70);
        XGraphics xgraphics71 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string str17 = Conversions.ToString(SAPInput.CheckDoubleGlazed(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Windows[index3].GlazingType));
        XFont xfont80 = xfont3;
        XSolidBrush black68 = XBrushes.Black;
        double rc1_67 = (double) SAPInput.RC1;
        xunit3 = PDFFunctions.pages[SAPInput.k].Width;
        double point71 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[SAPInput.k].Height;
        double num92 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect71 = new XRect(320.0, rc1_67, point71, num92);
        XStringFormat topLeft71 = XStringFormat.TopLeft;
        xgraphics71.DrawString(str17, xfont80, (XBrush) black68, xrect71, topLeft71);
        // ISSUE: reference to a compiler-generated field
        if ((uint) Operators.CompareString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Windows[index3].GlazingType, (string) null, false) > 0U)
        {
          // ISSUE: reference to a compiler-generated field
          if (SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Windows[index3].GlazingType.Contains("argon"))
          {
            XGraphics xgraphics72 = PDFFunctions.gfx[SAPInput.k];
            XFont xfont81 = xfont3;
            XSolidBrush black69 = XBrushes.Black;
            double rc1_68 = (double) SAPInput.RC1;
            xunit3 = PDFFunctions.pages[SAPInput.k].Width;
            double point72 = ((XUnit) ref xunit3).Point;
            xunit3 = PDFFunctions.pages[SAPInput.k].Height;
            double num93 = ((XUnit) ref xunit3).Point / 2.0;
            XRect xrect72 = new XRect(440.0, rc1_68, point72, num93);
            XStringFormat topLeft72 = XStringFormat.TopLeft;
            xgraphics72.DrawString("Yes", xfont81, (XBrush) black69, xrect72, topLeft72);
          }
          else
          {
            XGraphics xgraphics73 = PDFFunctions.gfx[SAPInput.k];
            XFont xfont82 = xfont3;
            XSolidBrush black70 = XBrushes.Black;
            double rc1_69 = (double) SAPInput.RC1;
            xunit3 = PDFFunctions.pages[SAPInput.k].Width;
            double point73 = ((XUnit) ref xunit3).Point;
            xunit3 = PDFFunctions.pages[SAPInput.k].Height;
            double num94 = ((XUnit) ref xunit3).Point / 2.0;
            XRect xrect73 = new XRect(440.0, rc1_69, point73, num94);
            XStringFormat topLeft73 = XStringFormat.TopLeft;
            xgraphics73.DrawString("No", xfont82, (XBrush) black70, xrect73, topLeft73);
          }
        }
        // ISSUE: reference to a compiler-generated field
        if (SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Windows[index3].FrameType != null)
        {
          XGraphics xgraphics74 = PDFFunctions.gfx[SAPInput.k];
          // ISSUE: reference to a compiler-generated field
          string frameType = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Windows[index3].FrameType;
          XFont xfont83 = xfont3;
          XSolidBrush black71 = XBrushes.Black;
          double rc1_70 = (double) SAPInput.RC1;
          xunit3 = PDFFunctions.pages[SAPInput.k].Width;
          double point74 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[SAPInput.k].Height;
          double num95 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect74 = new XRect(500.0, rc1_70, point74, num95);
          XStringFormat topLeft74 = XStringFormat.TopLeft;
          xgraphics74.DrawString(frameType, xfont83, (XBrush) black71, xrect74, topLeft74);
          checked { SAPInput.RC1 += 12; }
          SAPInput.CheckRC1();
        }
        checked { ++index3; }
      }
      SAPInput.CheckRC1();
      // ISSUE: reference to a compiler-generated field
      int num96 = checked (SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].NoofRoofLights - 1);
      int index4 = 0;
      while (index4 <= num96)
      {
        XGraphics xgraphics75 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string name = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].RoofLights[index4].Name;
        XFont xfont84 = xfont3;
        XSolidBrush black72 = XBrushes.Black;
        double rc1_71 = (double) SAPInput.RC1;
        xunit3 = PDFFunctions.pages[SAPInput.k].Width;
        double point75 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[SAPInput.k].Height;
        double num97 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect75 = new XRect(20.0, rc1_71, point75, num97);
        XStringFormat topLeft75 = XStringFormat.TopLeft;
        xgraphics75.DrawString(name, xfont84, (XBrush) black72, xrect75, topLeft75);
        XGraphics xgraphics76 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string uvalueSource = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].RoofLights[index4].UValueSource;
        XFont xfont85 = xfont3;
        XSolidBrush black73 = XBrushes.Black;
        double rc1_72 = (double) SAPInput.RC1;
        xunit3 = PDFFunctions.pages[SAPInput.k].Width;
        double point76 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[SAPInput.k].Height;
        double num98 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect76 = new XRect(110.0, rc1_72, point76, num98);
        XStringFormat topLeft76 = XStringFormat.TopLeft;
        xgraphics76.DrawString(uvalueSource, xfont85, (XBrush) black73, xrect76, topLeft76);
        XGraphics xgraphics77 = PDFFunctions.gfx[SAPInput.k];
        XFont xfont86 = xfont3;
        XSolidBrush black74 = XBrushes.Black;
        double rc1_73 = (double) SAPInput.RC1;
        xunit3 = PDFFunctions.pages[SAPInput.k].Width;
        double point77 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[SAPInput.k].Height;
        double num99 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect77 = new XRect(220.0, rc1_73, point77, num99);
        XStringFormat topLeft77 = XStringFormat.TopLeft;
        xgraphics77.DrawString("Roof Windows", xfont86, (XBrush) black74, xrect77, topLeft77);
        XGraphics xgraphics78 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string str18 = Conversions.ToString(SAPInput.CheckDoubleGlazed(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].RoofLights[index4].GlazingType));
        XFont xfont87 = xfont3;
        XSolidBrush black75 = XBrushes.Black;
        double rc1_74 = (double) SAPInput.RC1;
        xunit3 = PDFFunctions.pages[SAPInput.k].Width;
        double point78 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[SAPInput.k].Height;
        double num100 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect78 = new XRect(320.0, rc1_74, point78, num100);
        XStringFormat topLeft78 = XStringFormat.TopLeft;
        xgraphics78.DrawString(str18, xfont87, (XBrush) black75, xrect78, topLeft78);
        // ISSUE: reference to a compiler-generated field
        if ((uint) Operators.CompareString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].RoofLights[index4].GlazingType, (string) null, false) > 0U)
        {
          // ISSUE: reference to a compiler-generated field
          if (SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].RoofLights[index4].GlazingType.Contains("argon"))
          {
            XGraphics xgraphics79 = PDFFunctions.gfx[SAPInput.k];
            XFont xfont88 = xfont3;
            XSolidBrush black76 = XBrushes.Black;
            double rc1_75 = (double) SAPInput.RC1;
            xunit3 = PDFFunctions.pages[SAPInput.k].Width;
            double point79 = ((XUnit) ref xunit3).Point;
            xunit3 = PDFFunctions.pages[SAPInput.k].Height;
            double num101 = ((XUnit) ref xunit3).Point / 2.0;
            XRect xrect79 = new XRect(440.0, rc1_75, point79, num101);
            XStringFormat topLeft79 = XStringFormat.TopLeft;
            xgraphics79.DrawString("Yes", xfont88, (XBrush) black76, xrect79, topLeft79);
          }
          else
          {
            XGraphics xgraphics80 = PDFFunctions.gfx[SAPInput.k];
            XFont xfont89 = xfont3;
            XSolidBrush black77 = XBrushes.Black;
            double rc1_76 = (double) SAPInput.RC1;
            xunit3 = PDFFunctions.pages[SAPInput.k].Width;
            double point80 = ((XUnit) ref xunit3).Point;
            xunit3 = PDFFunctions.pages[SAPInput.k].Height;
            double num102 = ((XUnit) ref xunit3).Point / 2.0;
            XRect xrect80 = new XRect(440.0, rc1_76, point80, num102);
            XStringFormat topLeft80 = XStringFormat.TopLeft;
            xgraphics80.DrawString("No", xfont89, (XBrush) black77, xrect80, topLeft80);
          }
        }
        XGraphics xgraphics81 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string frameType = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].RoofLights[index4].FrameType;
        XFont xfont90 = xfont3;
        XSolidBrush black78 = XBrushes.Black;
        double rc1_77 = (double) SAPInput.RC1;
        xunit3 = PDFFunctions.pages[SAPInput.k].Width;
        double point81 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[SAPInput.k].Height;
        double num103 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect81 = new XRect(500.0, rc1_77, point81, num103);
        XStringFormat topLeft81 = XStringFormat.TopLeft;
        xgraphics81.DrawString(frameType, xfont90, (XBrush) black78, xrect81, topLeft81);
        checked { SAPInput.RC1 += 12; }
        SAPInput.CheckRC1();
        checked { ++index4; }
      }
      SAPInput.CheckRC1();
      checked { SAPInput.RC1 += 12; }
      XGraphics xgraphics82 = PDFFunctions.gfx[SAPInput.k];
      XFont arialFont10Bold1 = PDFFunctions.ArialFont10Bold;
      XSolidBrush black79 = XBrushes.Black;
      double rc1_78 = (double) SAPInput.RC1;
      xunit3 = PDFFunctions.pages[SAPInput.k].Width;
      double point82 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[SAPInput.k].Height;
      double num104 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect82 = new XRect(20.0, rc1_78, point82, num104);
      XStringFormat topLeft82 = XStringFormat.TopLeft;
      xgraphics82.DrawString("Name:", arialFont10Bold1, (XBrush) black79, xrect82, topLeft82);
      XGraphics xgraphics83 = PDFFunctions.gfx[SAPInput.k];
      XFont arialFont10Bold2 = PDFFunctions.ArialFont10Bold;
      XSolidBrush black80 = XBrushes.Black;
      double rc1_79 = (double) SAPInput.RC1;
      xunit3 = PDFFunctions.pages[SAPInput.k].Width;
      double point83 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[SAPInput.k].Height;
      double num105 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect83 = new XRect(130.0, rc1_79, point83, num105);
      XStringFormat topLeft83 = XStringFormat.TopLeft;
      xgraphics83.DrawString("Gap:", arialFont10Bold2, (XBrush) black80, xrect83, topLeft83);
      XGraphics xgraphics84 = PDFFunctions.gfx[SAPInput.k];
      XFont arialFont10Bold3 = PDFFunctions.ArialFont10Bold;
      XSolidBrush black81 = XBrushes.Black;
      double rc1_80 = (double) SAPInput.RC1;
      xunit3 = PDFFunctions.pages[SAPInput.k].Width;
      double point84 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[SAPInput.k].Height;
      double num106 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect84 = new XRect(240.0, rc1_80, point84, num106);
      XStringFormat topLeft84 = XStringFormat.TopLeft;
      xgraphics84.DrawString("Frame Factor:", arialFont10Bold3, (XBrush) black81, xrect84, topLeft84);
      XGraphics xgraphics85 = PDFFunctions.gfx[SAPInput.k];
      XFont arialFont10Bold4 = PDFFunctions.ArialFont10Bold;
      XSolidBrush black82 = XBrushes.Black;
      double rc1_81 = (double) SAPInput.RC1;
      xunit3 = PDFFunctions.pages[SAPInput.k].Width;
      double point85 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[SAPInput.k].Height;
      double num107 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect85 = new XRect(310.0, rc1_81, point85, num107);
      XStringFormat topLeft85 = XStringFormat.TopLeft;
      xgraphics85.DrawString("g-value:", arialFont10Bold4, (XBrush) black82, xrect85, topLeft85);
      XGraphics xgraphics86 = PDFFunctions.gfx[SAPInput.k];
      XFont arialFont10Bold5 = PDFFunctions.ArialFont10Bold;
      XSolidBrush black83 = XBrushes.Black;
      double rc1_82 = (double) SAPInput.RC1;
      xunit3 = PDFFunctions.pages[SAPInput.k].Width;
      double point86 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[SAPInput.k].Height;
      double num108 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect86 = new XRect(390.0, rc1_82, point86, num108);
      XStringFormat topLeft86 = XStringFormat.TopLeft;
      xgraphics86.DrawString("U-value:", arialFont10Bold5, (XBrush) black83, xrect86, topLeft86);
      XGraphics xgraphics87 = PDFFunctions.gfx[SAPInput.k];
      XFont arialFont10Bold6 = PDFFunctions.ArialFont10Bold;
      XSolidBrush black84 = XBrushes.Black;
      double rc1_83 = (double) SAPInput.RC1;
      xunit3 = PDFFunctions.pages[SAPInput.k].Width;
      double point87 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[SAPInput.k].Height;
      double num109 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect87 = new XRect(450.0, rc1_83, point87, num109);
      XStringFormat topLeft87 = XStringFormat.TopLeft;
      xgraphics87.DrawString("Area:", arialFont10Bold6, (XBrush) black84, xrect87, topLeft87);
      XGraphics xgraphics88 = PDFFunctions.gfx[SAPInput.k];
      XFont arialFont10Bold7 = PDFFunctions.ArialFont10Bold;
      XSolidBrush black85 = XBrushes.Black;
      double rc1_84 = (double) SAPInput.RC1;
      xunit3 = PDFFunctions.pages[SAPInput.k].Width;
      double point88 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[SAPInput.k].Height;
      double num110 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect88 = new XRect(500.0, rc1_84, point88, num110);
      XStringFormat topLeft88 = XStringFormat.TopLeft;
      xgraphics88.DrawString("No. of Openings:", arialFont10Bold7, (XBrush) black85, xrect88, topLeft88);
      checked { SAPInput.RC1 += 12; }
      // ISSUE: reference to a compiler-generated field
      int num111 = checked (SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].NoofDoors - 1);
      int index5 = 0;
      while (index5 <= num111)
      {
        XGraphics xgraphics89 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string name = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Doors[index5].Name;
        XFont xfont91 = xfont3;
        XSolidBrush black86 = XBrushes.Black;
        double rc1_85 = (double) SAPInput.RC1;
        xunit3 = PDFFunctions.pages[SAPInput.k].Width;
        double point89 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[SAPInput.k].Height;
        double num112 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect89 = new XRect(20.0, rc1_85, point89, num112);
        XStringFormat topLeft89 = XStringFormat.TopLeft;
        xgraphics89.DrawString(name, xfont91, (XBrush) black86, xrect89, topLeft89);
        XGraphics xgraphics90 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string str19 = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Doors[index5].AirGap + " mm";
        XFont xfont92 = xfont3;
        XSolidBrush black87 = XBrushes.Black;
        double rc1_86 = (double) SAPInput.RC1;
        xunit3 = PDFFunctions.pages[SAPInput.k].Width;
        double point90 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[SAPInput.k].Height;
        double num113 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect90 = new XRect(130.0, rc1_86, point90, num113);
        XStringFormat topLeft90 = XStringFormat.TopLeft;
        xgraphics90.DrawString(str19, xfont92, (XBrush) black87, xrect90, topLeft90);
        XGraphics xgraphics91 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string str20 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Doors[index5].FF);
        XFont xfont93 = xfont3;
        XSolidBrush black88 = XBrushes.Black;
        double rc1_87 = (double) SAPInput.RC1;
        xunit3 = PDFFunctions.pages[SAPInput.k].Width;
        double point91 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[SAPInput.k].Height;
        double num114 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect91 = new XRect(240.0, rc1_87, point91, num114);
        XStringFormat topLeft91 = XStringFormat.TopLeft;
        xgraphics91.DrawString(str20, xfont93, (XBrush) black88, xrect91, topLeft91);
        XGraphics xgraphics92 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string str21 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Doors[index5].g);
        XFont xfont94 = xfont3;
        XSolidBrush black89 = XBrushes.Black;
        double rc1_88 = (double) SAPInput.RC1;
        xunit3 = PDFFunctions.pages[SAPInput.k].Width;
        double point92 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[SAPInput.k].Height;
        double num115 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect92 = new XRect(310.0, rc1_88, point92, num115);
        XStringFormat topLeft92 = XStringFormat.TopLeft;
        xgraphics92.DrawString(str21, xfont94, (XBrush) black89, xrect92, topLeft92);
        XGraphics xgraphics93 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string str22 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Doors[index5].U);
        XFont xfont95 = xfont3;
        XSolidBrush black90 = XBrushes.Black;
        double rc1_89 = (double) SAPInput.RC1;
        xunit3 = PDFFunctions.pages[SAPInput.k].Width;
        double point93 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[SAPInput.k].Height;
        double num116 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect93 = new XRect(390.0, rc1_89, point93, num116);
        XStringFormat topLeft93 = XStringFormat.TopLeft;
        xgraphics93.DrawString(str22, xfont95, (XBrush) black90, xrect93, topLeft93);
        XGraphics xgraphics94 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string str23 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Doors[index5].Area);
        XFont xfont96 = xfont3;
        XSolidBrush black91 = XBrushes.Black;
        double rc1_90 = (double) SAPInput.RC1;
        xunit3 = PDFFunctions.pages[SAPInput.k].Width;
        double point94 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[SAPInput.k].Height;
        double num117 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect94 = new XRect(450.0, rc1_90, point94, num117);
        XStringFormat topLeft94 = XStringFormat.TopLeft;
        xgraphics94.DrawString(str23, xfont96, (XBrush) black91, xrect94, topLeft94);
        XGraphics xgraphics95 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string str24 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Doors[index5].Count);
        XFont xfont97 = xfont3;
        XSolidBrush black92 = XBrushes.Black;
        double rc1_91 = (double) SAPInput.RC1;
        xunit3 = PDFFunctions.pages[SAPInput.k].Width;
        double point95 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[SAPInput.k].Height;
        double num118 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect95 = new XRect(500.0, rc1_91, point95, num118);
        XStringFormat topLeft95 = XStringFormat.TopLeft;
        xgraphics95.DrawString(str24, xfont97, (XBrush) black92, xrect95, topLeft95);
        checked { SAPInput.RC1 += 12; }
        SAPInput.CheckRC1();
        checked { ++index5; }
      }
      // ISSUE: reference to a compiler-generated field
      int num119 = checked (SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].NoofWindows - 1);
      int index6 = 0;
      while (index6 <= num119)
      {
        XGraphics xgraphics96 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string name = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Windows[index6].Name;
        XFont xfont98 = xfont3;
        XSolidBrush black93 = XBrushes.Black;
        double rc1_92 = (double) SAPInput.RC1;
        xunit3 = PDFFunctions.pages[SAPInput.k].Width;
        double point96 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[SAPInput.k].Height;
        double num120 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect96 = new XRect(20.0, rc1_92, point96, num120);
        XStringFormat topLeft96 = XStringFormat.TopLeft;
        xgraphics96.DrawString(name, xfont98, (XBrush) black93, xrect96, topLeft96);
        // ISSUE: reference to a compiler-generated field
        if ((uint) Operators.CompareString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Windows[index6].AirGap, (string) null, false) > 0U)
        {
          XGraphics xgraphics97 = PDFFunctions.gfx[SAPInput.k];
          // ISSUE: reference to a compiler-generated field
          string airGap = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Windows[index6].AirGap;
          XFont xfont99 = xfont3;
          XSolidBrush black94 = XBrushes.Black;
          double rc1_93 = (double) SAPInput.RC1;
          xunit3 = PDFFunctions.pages[SAPInput.k].Width;
          double point97 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[SAPInput.k].Height;
          double num121 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect97 = new XRect(130.0, rc1_93, point97, num121);
          XStringFormat topLeft97 = XStringFormat.TopLeft;
          xgraphics97.DrawString(airGap, xfont99, (XBrush) black94, xrect97, topLeft97);
        }
        // ISSUE: reference to a compiler-generated field
        if ((uint) Operators.CompareString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Windows[index6].UValueSource, "BFRC", false) > 0U)
        {
          XGraphics xgraphics98 = PDFFunctions.gfx[SAPInput.k];
          // ISSUE: reference to a compiler-generated field
          string str25 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Windows[index6].FF);
          XFont xfont100 = xfont3;
          XSolidBrush black95 = XBrushes.Black;
          double rc1_94 = (double) SAPInput.RC1;
          xunit3 = PDFFunctions.pages[SAPInput.k].Width;
          double point98 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[SAPInput.k].Height;
          double num122 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect98 = new XRect(240.0, rc1_94, point98, num122);
          XStringFormat topLeft98 = XStringFormat.TopLeft;
          xgraphics98.DrawString(str25, xfont100, (XBrush) black95, xrect98, topLeft98);
        }
        else
        {
          XGraphics xgraphics99 = PDFFunctions.gfx[SAPInput.k];
          string str26 = Conversions.ToString(0);
          XFont xfont101 = xfont3;
          XSolidBrush black96 = XBrushes.Black;
          double rc1_95 = (double) SAPInput.RC1;
          xunit3 = PDFFunctions.pages[SAPInput.k].Width;
          double point99 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[SAPInput.k].Height;
          double num123 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect99 = new XRect(240.0, rc1_95, point99, num123);
          XStringFormat topLeft99 = XStringFormat.TopLeft;
          xgraphics99.DrawString(str26, xfont101, (XBrush) black96, xrect99, topLeft99);
        }
        XGraphics xgraphics100 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string str27 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Windows[index6].g);
        XFont xfont102 = xfont3;
        XSolidBrush black97 = XBrushes.Black;
        double rc1_96 = (double) SAPInput.RC1;
        xunit3 = PDFFunctions.pages[SAPInput.k].Width;
        double point100 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[SAPInput.k].Height;
        double num124 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect100 = new XRect(310.0, rc1_96, point100, num124);
        XStringFormat topLeft100 = XStringFormat.TopLeft;
        xgraphics100.DrawString(str27, xfont102, (XBrush) black97, xrect100, topLeft100);
        XGraphics xgraphics101 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string str28 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Windows[index6].U);
        XFont xfont103 = xfont3;
        XSolidBrush black98 = XBrushes.Black;
        double rc1_97 = (double) SAPInput.RC1;
        xunit3 = PDFFunctions.pages[SAPInput.k].Width;
        double point101 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[SAPInput.k].Height;
        double num125 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect101 = new XRect(390.0, rc1_97, point101, num125);
        XStringFormat topLeft101 = XStringFormat.TopLeft;
        xgraphics101.DrawString(str28, xfont103, (XBrush) black98, xrect101, topLeft101);
        XGraphics xgraphics102 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string str29 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Windows[index6].Area);
        XFont xfont104 = xfont3;
        XSolidBrush black99 = XBrushes.Black;
        double rc1_98 = (double) SAPInput.RC1;
        xunit3 = PDFFunctions.pages[SAPInput.k].Width;
        double point102 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[SAPInput.k].Height;
        double num126 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect102 = new XRect(450.0, rc1_98, point102, num126);
        XStringFormat topLeft102 = XStringFormat.TopLeft;
        xgraphics102.DrawString(str29, xfont104, (XBrush) black99, xrect102, topLeft102);
        XGraphics xgraphics103 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string str30 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Windows[index6].Count);
        XFont xfont105 = xfont3;
        XSolidBrush black100 = XBrushes.Black;
        double rc1_99 = (double) SAPInput.RC1;
        xunit3 = PDFFunctions.pages[SAPInput.k].Width;
        double point103 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[SAPInput.k].Height;
        double num127 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect103 = new XRect(500.0, rc1_99, point103, num127);
        XStringFormat topLeft103 = XStringFormat.TopLeft;
        xgraphics103.DrawString(str30, xfont105, (XBrush) black100, xrect103, topLeft103);
        checked { SAPInput.RC1 += 12; }
        SAPInput.CheckRC1();
        checked { ++index6; }
      }
      // ISSUE: reference to a compiler-generated field
      int num128 = checked (SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].NoofRoofLights - 1);
      int index7 = 0;
      while (index7 <= num128)
      {
        XGraphics xgraphics104 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string name = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].RoofLights[index7].Name;
        XFont xfont106 = xfont3;
        XSolidBrush black101 = XBrushes.Black;
        double rc1_100 = (double) SAPInput.RC1;
        xunit3 = PDFFunctions.pages[SAPInput.k].Width;
        double point104 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[SAPInput.k].Height;
        double num129 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect104 = new XRect(20.0, rc1_100, point104, num129);
        XStringFormat topLeft104 = XStringFormat.TopLeft;
        xgraphics104.DrawString(name, xfont106, (XBrush) black101, xrect104, topLeft104);
        XGraphics xgraphics105 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string airGap = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].RoofLights[index7].AirGap;
        XFont xfont107 = xfont3;
        XSolidBrush black102 = XBrushes.Black;
        double rc1_101 = (double) SAPInput.RC1;
        xunit3 = PDFFunctions.pages[SAPInput.k].Width;
        double point105 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[SAPInput.k].Height;
        double num130 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect105 = new XRect(130.0, rc1_101, point105, num130);
        XStringFormat topLeft105 = XStringFormat.TopLeft;
        xgraphics105.DrawString(airGap, xfont107, (XBrush) black102, xrect105, topLeft105);
        // ISSUE: reference to a compiler-generated field
        if ((uint) Operators.CompareString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].RoofLights[index7].UValueSource, "BFRC", false) > 0U)
        {
          XGraphics xgraphics106 = PDFFunctions.gfx[SAPInput.k];
          // ISSUE: reference to a compiler-generated field
          string str31 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].RoofLights[index7].FF);
          XFont xfont108 = xfont3;
          XSolidBrush black103 = XBrushes.Black;
          double rc1_102 = (double) SAPInput.RC1;
          xunit3 = PDFFunctions.pages[SAPInput.k].Width;
          double point106 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[SAPInput.k].Height;
          double num131 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect106 = new XRect(240.0, rc1_102, point106, num131);
          XStringFormat topLeft106 = XStringFormat.TopLeft;
          xgraphics106.DrawString(str31, xfont108, (XBrush) black103, xrect106, topLeft106);
        }
        else
        {
          XGraphics xgraphics107 = PDFFunctions.gfx[SAPInput.k];
          string str32 = Conversions.ToString(0);
          XFont xfont109 = xfont3;
          XSolidBrush black104 = XBrushes.Black;
          double rc1_103 = (double) SAPInput.RC1;
          xunit3 = PDFFunctions.pages[SAPInput.k].Width;
          double point107 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[SAPInput.k].Height;
          double num132 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect107 = new XRect(240.0, rc1_103, point107, num132);
          XStringFormat topLeft107 = XStringFormat.TopLeft;
          xgraphics107.DrawString(str32, xfont109, (XBrush) black104, xrect107, topLeft107);
        }
        XGraphics xgraphics108 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string str33 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].RoofLights[index7].g);
        XFont xfont110 = xfont3;
        XSolidBrush black105 = XBrushes.Black;
        double rc1_104 = (double) SAPInput.RC1;
        xunit3 = PDFFunctions.pages[SAPInput.k].Width;
        double point108 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[SAPInput.k].Height;
        double num133 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect108 = new XRect(310.0, rc1_104, point108, num133);
        XStringFormat topLeft108 = XStringFormat.TopLeft;
        xgraphics108.DrawString(str33, xfont110, (XBrush) black105, xrect108, topLeft108);
        XGraphics xgraphics109 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string str34 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].RoofLights[index7].U);
        XFont xfont111 = xfont3;
        XSolidBrush black106 = XBrushes.Black;
        double rc1_105 = (double) SAPInput.RC1;
        xunit3 = PDFFunctions.pages[SAPInput.k].Width;
        double point109 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[SAPInput.k].Height;
        double num134 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect109 = new XRect(390.0, rc1_105, point109, num134);
        XStringFormat topLeft109 = XStringFormat.TopLeft;
        xgraphics109.DrawString(str34, xfont111, (XBrush) black106, xrect109, topLeft109);
        XGraphics xgraphics110 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string str35 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].RoofLights[index7].Area);
        XFont xfont112 = xfont3;
        XSolidBrush black107 = XBrushes.Black;
        double rc1_106 = (double) SAPInput.RC1;
        xunit3 = PDFFunctions.pages[SAPInput.k].Width;
        double point110 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[SAPInput.k].Height;
        double num135 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect110 = new XRect(450.0, rc1_106, point110, num135);
        XStringFormat topLeft110 = XStringFormat.TopLeft;
        xgraphics110.DrawString(str35, xfont112, (XBrush) black107, xrect110, topLeft110);
        XGraphics xgraphics111 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string str36 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].RoofLights[index7].Count);
        XFont xfont113 = xfont3;
        XSolidBrush black108 = XBrushes.Black;
        double rc1_107 = (double) SAPInput.RC1;
        xunit3 = PDFFunctions.pages[SAPInput.k].Width;
        double point111 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[SAPInput.k].Height;
        double num136 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect111 = new XRect(500.0, rc1_107, point111, num136);
        XStringFormat topLeft111 = XStringFormat.TopLeft;
        xgraphics111.DrawString(str36, xfont113, (XBrush) black108, xrect111, topLeft111);
        checked { SAPInput.RC1 += 12; }
        SAPInput.CheckRC1();
        checked { ++index7; }
      }
      checked { SAPInput.RC1 += 12; }
      SAPInput.CheckRC1();
      XGraphics xgraphics112 = PDFFunctions.gfx[SAPInput.k];
      XFont xfont114 = xfont7;
      XSolidBrush black109 = XBrushes.Black;
      double rc1_108 = (double) SAPInput.RC1;
      xunit3 = PDFFunctions.pages[SAPInput.k].Width;
      double point112 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[SAPInput.k].Height;
      double num137 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect112 = new XRect(20.0, rc1_108, point112, num137);
      XStringFormat topLeft112 = XStringFormat.TopLeft;
      xgraphics112.DrawString("Name:", xfont114, (XBrush) black109, xrect112, topLeft112);
      XGraphics xgraphics113 = PDFFunctions.gfx[SAPInput.k];
      XFont xfont115 = xfont7;
      XSolidBrush black110 = XBrushes.Black;
      double rc1_109 = (double) SAPInput.RC1;
      xunit3 = PDFFunctions.pages[SAPInput.k].Width;
      double point113 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[SAPInput.k].Height;
      double num138 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect113 = new XRect(110.0, rc1_109, point113, num138);
      XStringFormat topLeft113 = XStringFormat.TopLeft;
      xgraphics113.DrawString("Type-Name:", xfont115, (XBrush) black110, xrect113, topLeft113);
      XGraphics xgraphics114 = PDFFunctions.gfx[SAPInput.k];
      XFont xfont116 = xfont7;
      XSolidBrush black111 = XBrushes.Black;
      double rc1_110 = (double) SAPInput.RC1;
      xunit3 = PDFFunctions.pages[SAPInput.k].Width;
      double point114 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[SAPInput.k].Height;
      double num139 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect114 = new XRect(220.0, rc1_110, point114, num139);
      XStringFormat topLeft114 = XStringFormat.TopLeft;
      xgraphics114.DrawString("Location:", xfont116, (XBrush) black111, xrect114, topLeft114);
      XGraphics xgraphics115 = PDFFunctions.gfx[SAPInput.k];
      XFont xfont117 = xfont7;
      XSolidBrush black112 = XBrushes.Black;
      double rc1_111 = (double) SAPInput.RC1;
      xunit3 = PDFFunctions.pages[SAPInput.k].Width;
      double point115 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[SAPInput.k].Height;
      double num140 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect115 = new XRect(320.0, rc1_111, point115, num140);
      XStringFormat topLeft115 = XStringFormat.TopLeft;
      xgraphics115.DrawString("Orient:", xfont117, (XBrush) black112, xrect115, topLeft115);
      XGraphics xgraphics116 = PDFFunctions.gfx[SAPInput.k];
      XFont xfont118 = xfont7;
      XSolidBrush black113 = XBrushes.Black;
      double rc1_112 = (double) SAPInput.RC1;
      xunit3 = PDFFunctions.pages[SAPInput.k].Width;
      double point116 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[SAPInput.k].Height;
      double num141 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect116 = new XRect(440.0, rc1_112, point116, num141);
      XStringFormat topLeft116 = XStringFormat.TopLeft;
      xgraphics116.DrawString("Width:", xfont118, (XBrush) black113, xrect116, topLeft116);
      XGraphics xgraphics117 = PDFFunctions.gfx[SAPInput.k];
      XFont xfont119 = xfont7;
      XSolidBrush black114 = XBrushes.Black;
      double rc1_113 = (double) SAPInput.RC1;
      xunit3 = PDFFunctions.pages[SAPInput.k].Width;
      double point117 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[SAPInput.k].Height;
      double num142 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect117 = new XRect(500.0, rc1_113, point117, num142);
      XStringFormat topLeft117 = XStringFormat.TopLeft;
      xgraphics117.DrawString("Height:", xfont119, (XBrush) black114, xrect117, topLeft117);
      checked { SAPInput.RC1 += 12; }
      SAPInput.CheckRC1();
      // ISSUE: reference to a compiler-generated field
      int num143 = checked (SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].NoofDoors - 1);
      int index8 = 0;
      while (index8 <= num143)
      {
        XGraphics xgraphics118 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string name = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Doors[index8].Name;
        XFont xfont120 = xfont3;
        XSolidBrush black115 = XBrushes.Black;
        double rc1_114 = (double) SAPInput.RC1;
        xunit3 = PDFFunctions.pages[SAPInput.k].Width;
        double point118 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[SAPInput.k].Height;
        double num144 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect118 = new XRect(20.0, rc1_114, point118, num144);
        XStringFormat topLeft118 = XStringFormat.TopLeft;
        xgraphics118.DrawString(name, xfont120, (XBrush) black115, xrect118, topLeft118);
        // ISSUE: reference to a compiler-generated field
        if (SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Doors[index8].OpeningType != null)
        {
          XGraphics xgraphics119 = PDFFunctions.gfx[SAPInput.k];
          // ISSUE: reference to a compiler-generated field
          string openingType = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Doors[index8].OpeningType;
          XFont xfont121 = xfont3;
          XSolidBrush black116 = XBrushes.Black;
          double rc1_115 = (double) SAPInput.RC1;
          xunit3 = PDFFunctions.pages[SAPInput.k].Width;
          double point119 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[SAPInput.k].Height;
          double num145 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect119 = new XRect(110.0, rc1_115, point119, num145);
          XStringFormat topLeft119 = XStringFormat.TopLeft;
          xgraphics119.DrawString(openingType, xfont121, (XBrush) black116, xrect119, topLeft119);
        }
        XGraphics xgraphics120 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string location2 = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Doors[index8].Location;
        XFont xfont122 = xfont3;
        XSolidBrush black117 = XBrushes.Black;
        double rc1_116 = (double) SAPInput.RC1;
        xunit3 = PDFFunctions.pages[SAPInput.k].Width;
        double point120 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[SAPInput.k].Height;
        double num146 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect120 = new XRect(220.0, rc1_116, point120, num146);
        XStringFormat topLeft120 = XStringFormat.TopLeft;
        xgraphics120.DrawString(location2, xfont122, (XBrush) black117, xrect120, topLeft120);
        // ISSUE: reference to a compiler-generated field
        if (SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Doors[index8].Orientation != null)
        {
          XGraphics xgraphics121 = PDFFunctions.gfx[SAPInput.k];
          // ISSUE: reference to a compiler-generated field
          string orientation2 = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Doors[index8].Orientation;
          XFont xfont123 = xfont3;
          XSolidBrush black118 = XBrushes.Black;
          double rc1_117 = (double) SAPInput.RC1;
          xunit3 = PDFFunctions.pages[SAPInput.k].Width;
          double point121 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[SAPInput.k].Height;
          double num147 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect121 = new XRect(320.0, rc1_117, point121, num147);
          XStringFormat topLeft121 = XStringFormat.TopLeft;
          xgraphics121.DrawString(orientation2, xfont123, (XBrush) black118, xrect121, topLeft121);
        }
        XGraphics xgraphics122 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string str37 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Doors[index8].Width / 1000f);
        XFont xfont124 = xfont3;
        XSolidBrush black119 = XBrushes.Black;
        double rc1_118 = (double) SAPInput.RC1;
        xunit3 = PDFFunctions.pages[SAPInput.k].Width;
        double point122 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[SAPInput.k].Height;
        double num148 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect122 = new XRect(440.0, rc1_118, point122, num148);
        XStringFormat topLeft122 = XStringFormat.TopLeft;
        xgraphics122.DrawString(str37, xfont124, (XBrush) black119, xrect122, topLeft122);
        XGraphics xgraphics123 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string str38 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Doors[index8].Height / 1000f);
        XFont xfont125 = xfont3;
        XSolidBrush black120 = XBrushes.Black;
        double rc1_119 = (double) SAPInput.RC1;
        xunit3 = PDFFunctions.pages[SAPInput.k].Width;
        double point123 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[SAPInput.k].Height;
        double num149 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect123 = new XRect(500.0, rc1_119, point123, num149);
        XStringFormat topLeft123 = XStringFormat.TopLeft;
        xgraphics123.DrawString(str38, xfont125, (XBrush) black120, xrect123, topLeft123);
        SAPInput.CheckRC1();
        checked { SAPInput.RC1 += 12; }
        checked { ++index8; }
      }
      SAPInput.CheckRC1();
      // ISSUE: reference to a compiler-generated field
      int num150 = checked (SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].NoofWindows - 1);
      int index9 = 0;
      while (index9 <= num150)
      {
        // ISSUE: reference to a compiler-generated field
        if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Windows[index9].Orientation, (string) null, false) == 0)
        {
          // ISSUE: reference to a compiler-generated field
          SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Windows[index9].Orientation = "Unspecified";
        }
        XGraphics xgraphics124 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string name = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Windows[index9].Name;
        XFont xfont126 = xfont3;
        XSolidBrush black121 = XBrushes.Black;
        double rc1_120 = (double) SAPInput.RC1;
        xunit3 = PDFFunctions.pages[SAPInput.k].Width;
        double point124 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[SAPInput.k].Height;
        double num151 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect124 = new XRect(20.0, rc1_120, point124, num151);
        XStringFormat topLeft124 = XStringFormat.TopLeft;
        xgraphics124.DrawString(name, xfont126, (XBrush) black121, xrect124, topLeft124);
        // ISSUE: reference to a compiler-generated field
        if (SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Windows[index9].OpeningType != null)
        {
          XGraphics xgraphics125 = PDFFunctions.gfx[SAPInput.k];
          // ISSUE: reference to a compiler-generated field
          string openingType = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Windows[index9].OpeningType;
          XFont xfont127 = xfont3;
          XSolidBrush black122 = XBrushes.Black;
          double rc1_121 = (double) SAPInput.RC1;
          xunit3 = PDFFunctions.pages[SAPInput.k].Width;
          double point125 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[SAPInput.k].Height;
          double num152 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect125 = new XRect(110.0, rc1_121, point125, num152);
          XStringFormat topLeft125 = XStringFormat.TopLeft;
          xgraphics125.DrawString(openingType, xfont127, (XBrush) black122, xrect125, topLeft125);
        }
        XGraphics xgraphics126 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string location3 = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Windows[index9].Location;
        XFont xfont128 = xfont3;
        XSolidBrush black123 = XBrushes.Black;
        double rc1_122 = (double) SAPInput.RC1;
        xunit3 = PDFFunctions.pages[SAPInput.k].Width;
        double point126 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[SAPInput.k].Height;
        double num153 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect126 = new XRect(220.0, rc1_122, point126, num153);
        XStringFormat topLeft126 = XStringFormat.TopLeft;
        xgraphics126.DrawString(location3, xfont128, (XBrush) black123, xrect126, topLeft126);
        XGraphics xgraphics127 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string orientation3 = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Windows[index9].Orientation;
        XFont xfont129 = xfont3;
        XSolidBrush black124 = XBrushes.Black;
        double rc1_123 = (double) SAPInput.RC1;
        xunit3 = PDFFunctions.pages[SAPInput.k].Width;
        double point127 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[SAPInput.k].Height;
        double num154 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect127 = new XRect(320.0, rc1_123, point127, num154);
        XStringFormat topLeft127 = XStringFormat.TopLeft;
        xgraphics127.DrawString(orientation3, xfont129, (XBrush) black124, xrect127, topLeft127);
        XGraphics xgraphics128 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string str39 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Windows[index9].Width / 1000f);
        XFont xfont130 = xfont3;
        XSolidBrush black125 = XBrushes.Black;
        double rc1_124 = (double) SAPInput.RC1;
        xunit3 = PDFFunctions.pages[SAPInput.k].Width;
        double point128 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[SAPInput.k].Height;
        double num155 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect128 = new XRect(440.0, rc1_124, point128, num155);
        XStringFormat topLeft128 = XStringFormat.TopLeft;
        xgraphics128.DrawString(str39, xfont130, (XBrush) black125, xrect128, topLeft128);
        XGraphics xgraphics129 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string str40 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Windows[index9].Height / 1000f);
        XFont xfont131 = xfont3;
        XSolidBrush black126 = XBrushes.Black;
        double rc1_125 = (double) SAPInput.RC1;
        xunit3 = PDFFunctions.pages[SAPInput.k].Width;
        double point129 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[SAPInput.k].Height;
        double num156 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect129 = new XRect(500.0, rc1_125, point129, num156);
        XStringFormat topLeft129 = XStringFormat.TopLeft;
        xgraphics129.DrawString(str40, xfont131, (XBrush) black126, xrect129, topLeft129);
        SAPInput.CheckRC1();
        checked { SAPInput.RC1 += 12; }
        checked { ++index9; }
      }
      SAPInput.CheckRC1();
      // ISSUE: reference to a compiler-generated field
      int num157 = checked (SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].NoofRoofLights - 1);
      int index10 = 0;
      while (index10 <= num157)
      {
        XGraphics xgraphics130 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string name = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].RoofLights[index10].Name;
        XFont xfont132 = xfont3;
        XSolidBrush black127 = XBrushes.Black;
        double rc1_126 = (double) SAPInput.RC1;
        xunit3 = PDFFunctions.pages[SAPInput.k].Width;
        double point130 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[SAPInput.k].Height;
        double num158 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect130 = new XRect(20.0, rc1_126, point130, num158);
        XStringFormat topLeft130 = XStringFormat.TopLeft;
        xgraphics130.DrawString(name, xfont132, (XBrush) black127, xrect130, topLeft130);
        // ISSUE: reference to a compiler-generated field
        if (SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].RoofLights[index10].OpeningType != null)
        {
          XGraphics xgraphics131 = PDFFunctions.gfx[SAPInput.k];
          // ISSUE: reference to a compiler-generated field
          string openingType = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].RoofLights[index10].OpeningType;
          XFont xfont133 = xfont3;
          XSolidBrush black128 = XBrushes.Black;
          double rc1_127 = (double) SAPInput.RC1;
          xunit3 = PDFFunctions.pages[SAPInput.k].Width;
          double point131 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[SAPInput.k].Height;
          double num159 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect131 = new XRect(110.0, rc1_127, point131, num159);
          XStringFormat topLeft131 = XStringFormat.TopLeft;
          xgraphics131.DrawString(openingType, xfont133, (XBrush) black128, xrect131, topLeft131);
        }
        XGraphics xgraphics132 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string location4 = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].RoofLights[index10].Location;
        XFont xfont134 = xfont3;
        XSolidBrush black129 = XBrushes.Black;
        double rc1_128 = (double) SAPInput.RC1;
        xunit3 = PDFFunctions.pages[SAPInput.k].Width;
        double point132 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[SAPInput.k].Height;
        double num160 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect132 = new XRect(220.0, rc1_128, point132, num160);
        XStringFormat topLeft132 = XStringFormat.TopLeft;
        xgraphics132.DrawString(location4, xfont134, (XBrush) black129, xrect132, topLeft132);
        XGraphics xgraphics133 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string orientation4 = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].RoofLights[index10].Orientation;
        XFont xfont135 = xfont3;
        XSolidBrush black130 = XBrushes.Black;
        double rc1_129 = (double) SAPInput.RC1;
        xunit3 = PDFFunctions.pages[SAPInput.k].Width;
        double point133 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[SAPInput.k].Height;
        double num161 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect133 = new XRect(320.0, rc1_129, point133, num161);
        XStringFormat topLeft133 = XStringFormat.TopLeft;
        xgraphics133.DrawString(orientation4, xfont135, (XBrush) black130, xrect133, topLeft133);
        XGraphics xgraphics134 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string str41 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].RoofLights[index10].Width / 1000f);
        XFont xfont136 = xfont3;
        XSolidBrush black131 = XBrushes.Black;
        double rc1_130 = (double) SAPInput.RC1;
        xunit3 = PDFFunctions.pages[SAPInput.k].Width;
        double point134 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[SAPInput.k].Height;
        double num162 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect134 = new XRect(440.0, rc1_130, point134, num162);
        XStringFormat topLeft134 = XStringFormat.TopLeft;
        xgraphics134.DrawString(str41, xfont136, (XBrush) black131, xrect134, topLeft134);
        XGraphics xgraphics135 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string str42 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].RoofLights[index10].Height / 1000f);
        XFont xfont137 = xfont3;
        XSolidBrush black132 = XBrushes.Black;
        double rc1_131 = (double) SAPInput.RC1;
        xunit3 = PDFFunctions.pages[SAPInput.k].Width;
        double point135 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[SAPInput.k].Height;
        double num163 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect135 = new XRect(500.0, rc1_131, point135, num163);
        XStringFormat topLeft135 = XStringFormat.TopLeft;
        xgraphics135.DrawString(str42, xfont137, (XBrush) black132, xrect135, topLeft135);
        checked { SAPInput.RC1 += 12; }
        SAPInput.CheckRC1();
        checked { ++index10; }
      }
      checked { SAPInput.RC1 += 16; }
      SAPInput.CheckRC1();
      XGraphics xgraphics136 = PDFFunctions.gfx[SAPInput.k];
      XFont xfont138 = xfont2;
      XSolidBrush black133 = XBrushes.Black;
      double rc1_132 = (double) SAPInput.RC1;
      xunit3 = PDFFunctions.pages[SAPInput.k].Width;
      double point136 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[SAPInput.k].Height;
      double num164 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect136 = new XRect(20.0, rc1_132, point136, num164);
      XStringFormat topLeft136 = XStringFormat.TopLeft;
      xgraphics136.DrawString("Overshading:", xfont138, (XBrush) black133, xrect136, topLeft136);
      XGraphics xgraphics137 = PDFFunctions.gfx[SAPInput.k];
      // ISSUE: reference to a compiler-generated field
      string overshading = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Overshading;
      XFont xfont139 = xfont3;
      XSolidBrush black134 = XBrushes.Black;
      double rc1_133 = (double) SAPInput.RC1;
      xunit3 = PDFFunctions.pages[SAPInput.k].Width;
      double point137 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[SAPInput.k].Height;
      double num165 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect137 = new XRect(200.0, rc1_133, point137, num165);
      XStringFormat topLeft137 = XStringFormat.TopLeft;
      xgraphics137.DrawString(overshading, xfont139, (XBrush) black134, xrect137, topLeft137);
      checked { SAPInput.RC1 += 14; }
      PDFFunctions.xBrush1 = XBrush.op_Implicit((Brush) new SolidBrush(Color.FromArgb(159, 172, 62)));
      PDFFunctions.Points[0].X = 20f;
      PDFFunctions.Points[0].Y = (float) SAPInput.RC1;
      ref PointF local7 = ref PDFFunctions.Points[1];
      xunit3 = PDFFunctions.pages[SAPInput.k].Width;
      double num166 = ((XUnit) ref xunit3).Point - 20.0;
      local7.X = (float) num166;
      PDFFunctions.Points[1].Y = (float) SAPInput.RC1;
      ref PointF local8 = ref PDFFunctions.Points[2];
      xunit3 = PDFFunctions.pages[SAPInput.k].Width;
      double num167 = ((XUnit) ref xunit3).Point - 20.0;
      local8.X = (float) num167;
      PDFFunctions.Points[2].Y = (float) checked (SAPInput.RC1 + 14);
      PDFFunctions.Points[3].X = 20f;
      PDFFunctions.Points[3].Y = (float) checked (SAPInput.RC1 + 14);
      PDFFunctions.gfx[SAPInput.k].DrawPolygon(PDFFunctions.polyGreen2, PDFFunctions.xBrush1, PDFFunctions.Points, xfillMode);
      XGraphics xgraphics138 = PDFFunctions.gfx[SAPInput.k];
      XFont xfont140 = xfont3;
      XSolidBrush white4 = XBrushes.White;
      double num168 = (double) checked (SAPInput.RC1 + 1);
      xunit3 = PDFFunctions.pages[SAPInput.k].Width;
      double point138 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[SAPInput.k].Height;
      double num169 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect138 = new XRect(25.0, num168, point138, num169);
      XStringFormat topLeft138 = XStringFormat.TopLeft;
      xgraphics138.DrawString("Opaque Elements:", xfont140, (XBrush) white4, xrect138, topLeft138);
      SAPInput.RC1 = checked ((int) Math.Round(unchecked ((double) PDFFunctions.Points[3].Y + 12.0)));
      XGraphics xgraphics139 = PDFFunctions.gfx[SAPInput.k];
      XFont xfont141 = xfont7;
      XSolidBrush black135 = XBrushes.Black;
      double rc1_134 = (double) SAPInput.RC1;
      xunit3 = PDFFunctions.pages[SAPInput.k].Width;
      double point139 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[SAPInput.k].Height;
      double num170 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect139 = new XRect(20.0, rc1_134, point139, num170);
      XStringFormat topLeft139 = XStringFormat.TopLeft;
      xgraphics139.DrawString("Type:", xfont141, (XBrush) black135, xrect139, topLeft139);
      XGraphics xgraphics140 = PDFFunctions.gfx[SAPInput.k];
      XFont xfont142 = xfont7;
      XSolidBrush black136 = XBrushes.Black;
      double rc1_135 = (double) SAPInput.RC1;
      xunit3 = PDFFunctions.pages[SAPInput.k].Width;
      double point140 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[SAPInput.k].Height;
      double num171 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect140 = new XRect(100.0, rc1_135, point140, num171);
      XStringFormat topLeft140 = XStringFormat.TopLeft;
      xgraphics140.DrawString("Gross area:", xfont142, (XBrush) black136, xrect140, topLeft140);
      XGraphics xgraphics141 = PDFFunctions.gfx[SAPInput.k];
      XFont xfont143 = xfont7;
      XSolidBrush black137 = XBrushes.Black;
      double rc1_136 = (double) SAPInput.RC1;
      xunit3 = PDFFunctions.pages[SAPInput.k].Width;
      double point141 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[SAPInput.k].Height;
      double num172 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect141 = new XRect(170.0, rc1_136, point141, num172);
      XStringFormat topLeft141 = XStringFormat.TopLeft;
      xgraphics141.DrawString("Openings:", xfont143, (XBrush) black137, xrect141, topLeft141);
      XGraphics xgraphics142 = PDFFunctions.gfx[SAPInput.k];
      XFont xfont144 = xfont7;
      XSolidBrush black138 = XBrushes.Black;
      double rc1_137 = (double) SAPInput.RC1;
      xunit3 = PDFFunctions.pages[SAPInput.k].Width;
      double point142 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[SAPInput.k].Height;
      double num173 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect142 = new XRect(240.0, rc1_137, point142, num173);
      XStringFormat topLeft142 = XStringFormat.TopLeft;
      xgraphics142.DrawString("Net area:", xfont144, (XBrush) black138, xrect142, topLeft142);
      XGraphics xgraphics143 = PDFFunctions.gfx[SAPInput.k];
      XFont xfont145 = xfont7;
      XSolidBrush black139 = XBrushes.Black;
      double rc1_138 = (double) SAPInput.RC1;
      xunit3 = PDFFunctions.pages[SAPInput.k].Width;
      double point143 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[SAPInput.k].Height;
      double num174 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect143 = new XRect(310.0, rc1_138, point143, num174);
      XStringFormat topLeft143 = XStringFormat.TopLeft;
      xgraphics143.DrawString("U-value:", xfont145, (XBrush) black139, xrect143, topLeft143);
      XGraphics xgraphics144 = PDFFunctions.gfx[SAPInput.k];
      XFont xfont146 = xfont7;
      XSolidBrush black140 = XBrushes.Black;
      double rc1_139 = (double) SAPInput.RC1;
      xunit3 = PDFFunctions.pages[SAPInput.k].Width;
      double point144 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[SAPInput.k].Height;
      double num175 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect144 = new XRect(380.0, rc1_139, point144, num175);
      XStringFormat topLeft144 = XStringFormat.TopLeft;
      xgraphics144.DrawString("Ru value:", xfont146, (XBrush) black140, xrect144, topLeft144);
      XGraphics xgraphics145 = PDFFunctions.gfx[SAPInput.k];
      XFont xfont147 = xfont7;
      XSolidBrush black141 = XBrushes.Black;
      double rc1_140 = (double) SAPInput.RC1;
      xunit3 = PDFFunctions.pages[SAPInput.k].Width;
      double point145 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[SAPInput.k].Height;
      double num176 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect145 = new XRect(450.0, rc1_140, point145, num176);
      XStringFormat topLeft145 = XStringFormat.TopLeft;
      xgraphics145.DrawString("Curtain wall:", xfont147, (XBrush) black141, xrect145, topLeft145);
      XGraphics xgraphics146 = PDFFunctions.gfx[SAPInput.k];
      XFont xfont148 = xfont7;
      XSolidBrush black142 = XBrushes.Black;
      double rc1_141 = (double) SAPInput.RC1;
      xunit3 = PDFFunctions.pages[SAPInput.k].Width;
      double point146 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[SAPInput.k].Height;
      double num177 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect146 = new XRect(532.0, rc1_141, point146, num177);
      XStringFormat topLeft146 = XStringFormat.TopLeft;
      xgraphics146.DrawString("Kappa:", xfont148, (XBrush) black142, xrect146, topLeft146);
      checked { SAPInput.RC1 += 12; }
      SAPInput.CheckRC1();
      XGraphics xgraphics147 = PDFFunctions.gfx[SAPInput.k];
      XFont xfont149 = xfont4;
      XSolidBrush black143 = XBrushes.Black;
      double rc1_142 = (double) SAPInput.RC1;
      xunit3 = PDFFunctions.pages[SAPInput.k].Width;
      double point147 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[SAPInput.k].Height;
      double num178 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect147 = new XRect(20.0, rc1_142, point147, num178);
      XStringFormat topLeft147 = XStringFormat.TopLeft;
      xgraphics147.DrawString("External Elements", xfont149, (XBrush) black143, xrect147, topLeft147);
      checked { SAPInput.RC1 += 12; }
      // ISSUE: reference to a compiler-generated field
      int num179 = checked (SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].NoofWalls - 1);
      int index11 = 0;
      while (index11 <= num179)
      {
        // ISSUE: reference to a compiler-generated field
        if (SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Walls[index11].Name != null)
        {
          XGraphics xgraphics148 = PDFFunctions.gfx[SAPInput.k];
          // ISSUE: reference to a compiler-generated field
          string name = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Walls[index11].Name;
          XFont xfont150 = xfont3;
          XSolidBrush black144 = XBrushes.Black;
          double rc1_143 = (double) SAPInput.RC1;
          xunit3 = PDFFunctions.pages[SAPInput.k].Width;
          double point148 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[SAPInput.k].Height;
          double num180 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect148 = new XRect(20.0, rc1_143, point148, num180);
          XStringFormat topLeft148 = XStringFormat.TopLeft;
          xgraphics148.DrawString(name, xfont150, (XBrush) black144, xrect148, topLeft148);
        }
        XGraphics xgraphics149 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string str43 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Walls[index11].Area);
        XFont xfont151 = xfont3;
        XSolidBrush black145 = XBrushes.Black;
        double rc1_144 = (double) SAPInput.RC1;
        xunit3 = PDFFunctions.pages[SAPInput.k].Width;
        double point149 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[SAPInput.k].Height;
        double num181 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect149 = new XRect(120.0, rc1_144, point149, num181);
        XStringFormat topLeft149 = XStringFormat.TopLeft;
        xgraphics149.DrawString(str43, xfont151, (XBrush) black145, xrect149, topLeft149);
        XGraphics xgraphics150 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string str44 = Conversions.ToString(Math.Round((double) SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Walls[index11].Area - SAP_Module.Calculation2012._Add_Variable._3._WallAreas[index11], 2));
        XFont xfont152 = xfont3;
        XSolidBrush black146 = XBrushes.Black;
        double rc1_145 = (double) SAPInput.RC1;
        xunit3 = PDFFunctions.pages[SAPInput.k].Width;
        double point150 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[SAPInput.k].Height;
        double num182 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect150 = new XRect(180.0, rc1_145, point150, num182);
        XStringFormat topLeft150 = XStringFormat.TopLeft;
        xgraphics150.DrawString(str44, xfont152, (XBrush) black146, xrect150, topLeft150);
        XGraphics xgraphics151 = PDFFunctions.gfx[SAPInput.k];
        string str45 = Conversions.ToString(Math.Round(SAP_Module.Calculation2012._Add_Variable._3._WallAreas[index11], 2));
        XFont xfont153 = xfont3;
        XSolidBrush black147 = XBrushes.Black;
        double rc1_146 = (double) SAPInput.RC1;
        xunit3 = PDFFunctions.pages[SAPInput.k].Width;
        double point151 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[SAPInput.k].Height;
        double num183 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect151 = new XRect(250.0, rc1_146, point151, num183);
        XStringFormat topLeft151 = XStringFormat.TopLeft;
        xgraphics151.DrawString(str45, xfont153, (XBrush) black147, xrect151, topLeft151);
        XGraphics xgraphics152 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string str46 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Walls[index11].U_Value);
        XFont xfont154 = xfont3;
        XSolidBrush black148 = XBrushes.Black;
        double rc1_147 = (double) SAPInput.RC1;
        xunit3 = PDFFunctions.pages[SAPInput.k].Width;
        double point152 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[SAPInput.k].Height;
        double num184 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect152 = new XRect(320.0, rc1_147, point152, num184);
        XStringFormat topLeft152 = XStringFormat.TopLeft;
        xgraphics152.DrawString(str46, xfont154, (XBrush) black148, xrect152, topLeft152);
        XGraphics xgraphics153 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string str47 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Walls[index11].Ru);
        XFont xfont155 = xfont3;
        XSolidBrush black149 = XBrushes.Black;
        double rc1_148 = (double) SAPInput.RC1;
        xunit3 = PDFFunctions.pages[SAPInput.k].Width;
        double point153 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[SAPInput.k].Height;
        double num185 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect153 = new XRect(390.0, rc1_148, point153, num185);
        XStringFormat topLeft153 = XStringFormat.TopLeft;
        xgraphics153.DrawString(str47, xfont155, (XBrush) black149, xrect153, topLeft153);
        XGraphics xgraphics154 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string str48 = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Walls[index11].Curtain.ToString();
        XFont xfont156 = xfont3;
        XSolidBrush black150 = XBrushes.Black;
        double rc1_149 = (double) SAPInput.RC1;
        xunit3 = PDFFunctions.pages[SAPInput.k].Width;
        double point154 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[SAPInput.k].Height;
        double num186 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect154 = new XRect(450.0, rc1_149, point154, num186);
        XStringFormat topLeft154 = XStringFormat.TopLeft;
        xgraphics154.DrawString(str48, xfont156, (XBrush) black150, xrect154, topLeft154);
        // ISSUE: reference to a compiler-generated field
        if ((uint) Operators.CompareString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].TMP.Type, "Calculated", false) > 0U)
        {
          XGraphics xgraphics155 = PDFFunctions.gfx[SAPInput.k];
          XFont xfont157 = xfont3;
          XSolidBrush black151 = XBrushes.Black;
          double rc1_150 = (double) SAPInput.RC1;
          xunit3 = PDFFunctions.pages[SAPInput.k].Width;
          double point155 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[SAPInput.k].Height;
          double num187 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect155 = new XRect(542.0, rc1_150, point155, num187);
          XStringFormat topLeft155 = XStringFormat.TopLeft;
          xgraphics155.DrawString("N/A", xfont157, (XBrush) black151, xrect155, topLeft155);
        }
        else
        {
          XGraphics xgraphics156 = PDFFunctions.gfx[SAPInput.k];
          // ISSUE: reference to a compiler-generated field
          string str49 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Walls[index11].K);
          XFont xfont158 = xfont3;
          XSolidBrush black152 = XBrushes.Black;
          double rc1_151 = (double) SAPInput.RC1;
          xunit3 = PDFFunctions.pages[SAPInput.k].Width;
          double point156 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[SAPInput.k].Height;
          double num188 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect156 = new XRect(542.0, rc1_151, point156, num188);
          XStringFormat topLeft156 = XStringFormat.TopLeft;
          xgraphics156.DrawString(str49, xfont158, (XBrush) black152, xrect156, topLeft156);
        }
        checked { SAPInput.RC1 += 12; }
        checked { ++index11; }
      }
      SAPInput.CheckRC1();
      // ISSUE: reference to a compiler-generated field
      int num189 = checked (SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].NoofRoofs - 1);
      int index12 = 0;
      while (index12 <= num189)
      {
        // ISSUE: reference to a compiler-generated field
        if (SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Roofs[index12].Name != null)
        {
          XGraphics xgraphics157 = PDFFunctions.gfx[SAPInput.k];
          // ISSUE: reference to a compiler-generated field
          string name = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Roofs[index12].Name;
          XFont xfont159 = xfont3;
          XSolidBrush black153 = XBrushes.Black;
          double rc1_152 = (double) SAPInput.RC1;
          xunit3 = PDFFunctions.pages[SAPInput.k].Width;
          double point157 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[SAPInput.k].Height;
          double num190 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect157 = new XRect(20.0, rc1_152, point157, num190);
          XStringFormat topLeft157 = XStringFormat.TopLeft;
          xgraphics157.DrawString(name, xfont159, (XBrush) black153, xrect157, topLeft157);
        }
        XGraphics xgraphics158 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string str50 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Roofs[index12].Area);
        XFont xfont160 = xfont3;
        XSolidBrush black154 = XBrushes.Black;
        double rc1_153 = (double) SAPInput.RC1;
        xunit3 = PDFFunctions.pages[SAPInput.k].Width;
        double point158 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[SAPInput.k].Height;
        double num191 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect158 = new XRect(120.0, rc1_153, point158, num191);
        XStringFormat topLeft158 = XStringFormat.TopLeft;
        xgraphics158.DrawString(str50, xfont160, (XBrush) black154, xrect158, topLeft158);
        XGraphics xgraphics159 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string str51 = Conversions.ToString(Math.Round((double) SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Roofs[index12].Area - SAP_Module.Calculation2012._Add_Variable._3._RoofAreas[index12], 2));
        XFont xfont161 = xfont3;
        XSolidBrush black155 = XBrushes.Black;
        double rc1_154 = (double) SAPInput.RC1;
        xunit3 = PDFFunctions.pages[SAPInput.k].Width;
        double point159 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[SAPInput.k].Height;
        double num192 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect159 = new XRect(180.0, rc1_154, point159, num192);
        XStringFormat topLeft159 = XStringFormat.TopLeft;
        xgraphics159.DrawString(str51, xfont161, (XBrush) black155, xrect159, topLeft159);
        XGraphics xgraphics160 = PDFFunctions.gfx[SAPInput.k];
        string str52 = Conversions.ToString(Math.Round(SAP_Module.Calculation2012._Add_Variable._3._RoofAreas[index12], 2));
        XFont xfont162 = xfont3;
        XSolidBrush black156 = XBrushes.Black;
        double rc1_155 = (double) SAPInput.RC1;
        xunit3 = PDFFunctions.pages[SAPInput.k].Width;
        double point160 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[SAPInput.k].Height;
        double num193 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect160 = new XRect(250.0, rc1_155, point160, num193);
        XStringFormat topLeft160 = XStringFormat.TopLeft;
        xgraphics160.DrawString(str52, xfont162, (XBrush) black156, xrect160, topLeft160);
        XGraphics xgraphics161 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string str53 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Roofs[index12].U_Value);
        XFont xfont163 = xfont3;
        XSolidBrush black157 = XBrushes.Black;
        double rc1_156 = (double) SAPInput.RC1;
        xunit3 = PDFFunctions.pages[SAPInput.k].Width;
        double point161 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[SAPInput.k].Height;
        double num194 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect161 = new XRect(320.0, rc1_156, point161, num194);
        XStringFormat topLeft161 = XStringFormat.TopLeft;
        xgraphics161.DrawString(str53, xfont163, (XBrush) black157, xrect161, topLeft161);
        XGraphics xgraphics162 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string str54 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Roofs[index12].Ru);
        XFont xfont164 = xfont3;
        XSolidBrush black158 = XBrushes.Black;
        double rc1_157 = (double) SAPInput.RC1;
        xunit3 = PDFFunctions.pages[SAPInput.k].Width;
        double point162 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[SAPInput.k].Height;
        double num195 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect162 = new XRect(390.0, rc1_157, point162, num195);
        XStringFormat topLeft162 = XStringFormat.TopLeft;
        xgraphics162.DrawString(str54, xfont164, (XBrush) black158, xrect162, topLeft162);
        // ISSUE: reference to a compiler-generated field
        if ((uint) Operators.CompareString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].TMP.Type, "Calculated", false) > 0U)
        {
          XGraphics xgraphics163 = PDFFunctions.gfx[SAPInput.k];
          XFont xfont165 = xfont3;
          XSolidBrush black159 = XBrushes.Black;
          double rc1_158 = (double) SAPInput.RC1;
          xunit3 = PDFFunctions.pages[SAPInput.k].Width;
          double point163 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[SAPInput.k].Height;
          double num196 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect163 = new XRect(542.0, rc1_158, point163, num196);
          XStringFormat topLeft163 = XStringFormat.TopLeft;
          xgraphics163.DrawString("N/A", xfont165, (XBrush) black159, xrect163, topLeft163);
        }
        else
        {
          XGraphics xgraphics164 = PDFFunctions.gfx[SAPInput.k];
          // ISSUE: reference to a compiler-generated field
          string str55 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Roofs[index12].K);
          XFont xfont166 = xfont3;
          XSolidBrush black160 = XBrushes.Black;
          double rc1_159 = (double) SAPInput.RC1;
          xunit3 = PDFFunctions.pages[SAPInput.k].Width;
          double point164 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[SAPInput.k].Height;
          double num197 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect164 = new XRect(542.0, rc1_159, point164, num197);
          XStringFormat topLeft164 = XStringFormat.TopLeft;
          xgraphics164.DrawString(str55, xfont166, (XBrush) black160, xrect164, topLeft164);
        }
        checked { SAPInput.RC1 += 12; }
        checked { ++index12; }
      }
      SAPInput.CheckRC1();
      // ISSUE: reference to a compiler-generated field
      int num198 = checked (SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].NoofFloors - 1);
      int index13 = 0;
      while (index13 <= num198)
      {
        // ISSUE: reference to a compiler-generated field
        if (SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Floors[index13].Name != null)
        {
          XGraphics xgraphics165 = PDFFunctions.gfx[SAPInput.k];
          // ISSUE: reference to a compiler-generated field
          string name = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Floors[index13].Name;
          XFont xfont167 = xfont3;
          XSolidBrush black161 = XBrushes.Black;
          double rc1_160 = (double) SAPInput.RC1;
          xunit3 = PDFFunctions.pages[SAPInput.k].Width;
          double point165 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[SAPInput.k].Height;
          double num199 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect165 = new XRect(20.0, rc1_160, point165, num199);
          XStringFormat topLeft165 = XStringFormat.TopLeft;
          xgraphics165.DrawString(name, xfont167, (XBrush) black161, xrect165, topLeft165);
        }
        XGraphics xgraphics166 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string str56 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Floors[index13].Area);
        XFont xfont168 = xfont3;
        XSolidBrush black162 = XBrushes.Black;
        double rc1_161 = (double) SAPInput.RC1;
        xunit3 = PDFFunctions.pages[SAPInput.k].Width;
        double point166 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[SAPInput.k].Height;
        double num200 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect166 = new XRect(120.0, rc1_161, point166, num200);
        XStringFormat topLeft166 = XStringFormat.TopLeft;
        xgraphics166.DrawString(str56, xfont168, (XBrush) black162, xrect166, topLeft166);
        XGraphics xgraphics167 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string str57 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Floors[index13].U_Value);
        XFont xfont169 = xfont3;
        XSolidBrush black163 = XBrushes.Black;
        double rc1_162 = (double) SAPInput.RC1;
        xunit3 = PDFFunctions.pages[SAPInput.k].Width;
        double point167 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[SAPInput.k].Height;
        double num201 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect167 = new XRect(320.0, rc1_162, point167, num201);
        XStringFormat topLeft167 = XStringFormat.TopLeft;
        xgraphics167.DrawString(str57, xfont169, (XBrush) black163, xrect167, topLeft167);
        // ISSUE: reference to a compiler-generated field
        if ((uint) Operators.CompareString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].TMP.Type, "Calculated", false) > 0U)
        {
          XGraphics xgraphics168 = PDFFunctions.gfx[SAPInput.k];
          XFont xfont170 = xfont3;
          XSolidBrush black164 = XBrushes.Black;
          double rc1_163 = (double) SAPInput.RC1;
          xunit3 = PDFFunctions.pages[SAPInput.k].Width;
          double point168 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[SAPInput.k].Height;
          double num202 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect168 = new XRect(542.0, rc1_163, point168, num202);
          XStringFormat topLeft168 = XStringFormat.TopLeft;
          xgraphics168.DrawString("N/A", xfont170, (XBrush) black164, xrect168, topLeft168);
        }
        else
        {
          XGraphics xgraphics169 = PDFFunctions.gfx[SAPInput.k];
          // ISSUE: reference to a compiler-generated field
          string str58 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Floors[index13].K);
          XFont xfont171 = xfont3;
          XSolidBrush black165 = XBrushes.Black;
          double rc1_164 = (double) SAPInput.RC1;
          xunit3 = PDFFunctions.pages[SAPInput.k].Width;
          double point169 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[SAPInput.k].Height;
          double num203 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect169 = new XRect(542.0, rc1_164, point169, num203);
          XStringFormat topLeft169 = XStringFormat.TopLeft;
          xgraphics169.DrawString(str58, xfont171, (XBrush) black165, xrect169, topLeft169);
        }
        checked { SAPInput.RC1 += 12; }
        checked { ++index13; }
      }
      SAPInput.CheckRC1();
      XGraphics xgraphics170 = PDFFunctions.gfx[SAPInput.k];
      XFont xfont172 = xfont4;
      XSolidBrush black166 = XBrushes.Black;
      double rc1_165 = (double) SAPInput.RC1;
      xunit3 = PDFFunctions.pages[SAPInput.k].Width;
      double point170 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[SAPInput.k].Height;
      double num204 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect170 = new XRect(20.0, rc1_165, point170, num204);
      XStringFormat topLeft170 = XStringFormat.TopLeft;
      xgraphics170.DrawString("Internal Elements", xfont172, (XBrush) black166, xrect170, topLeft170);
      checked { SAPInput.RC1 += 12; }
      // ISSUE: reference to a compiler-generated field
      int num205 = checked (SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].NoofIWalls - 1);
      int index14 = 0;
      while (index14 <= num205)
      {
        // ISSUE: reference to a compiler-generated field
        if (SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].IWalls[index14].Name != null)
        {
          XGraphics xgraphics171 = PDFFunctions.gfx[SAPInput.k];
          // ISSUE: reference to a compiler-generated field
          string name = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].IWalls[index14].Name;
          XFont xfont173 = xfont3;
          XSolidBrush black167 = XBrushes.Black;
          double rc1_166 = (double) SAPInput.RC1;
          xunit3 = PDFFunctions.pages[SAPInput.k].Width;
          double point171 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[SAPInput.k].Height;
          double num206 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect171 = new XRect(20.0, rc1_166, point171, num206);
          XStringFormat topLeft171 = XStringFormat.TopLeft;
          xgraphics171.DrawString(name, xfont173, (XBrush) black167, xrect171, topLeft171);
        }
        XGraphics xgraphics172 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string str59 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].IWalls[index14].Area);
        XFont xfont174 = xfont3;
        XSolidBrush black168 = XBrushes.Black;
        double rc1_167 = (double) SAPInput.RC1;
        xunit3 = PDFFunctions.pages[SAPInput.k].Width;
        double point172 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[SAPInput.k].Height;
        double num207 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect172 = new XRect(120.0, rc1_167, point172, num207);
        XStringFormat topLeft172 = XStringFormat.TopLeft;
        xgraphics172.DrawString(str59, xfont174, (XBrush) black168, xrect172, topLeft172);
        // ISSUE: reference to a compiler-generated field
        if ((uint) Operators.CompareString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].TMP.Type, "Calculated", false) > 0U)
        {
          XGraphics xgraphics173 = PDFFunctions.gfx[SAPInput.k];
          XFont xfont175 = xfont3;
          XSolidBrush black169 = XBrushes.Black;
          double rc1_168 = (double) SAPInput.RC1;
          xunit3 = PDFFunctions.pages[SAPInput.k].Width;
          double point173 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[SAPInput.k].Height;
          double num208 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect173 = new XRect(542.0, rc1_168, point173, num208);
          XStringFormat topLeft173 = XStringFormat.TopLeft;
          xgraphics173.DrawString("N/A", xfont175, (XBrush) black169, xrect173, topLeft173);
        }
        else
        {
          XGraphics xgraphics174 = PDFFunctions.gfx[SAPInput.k];
          // ISSUE: reference to a compiler-generated field
          string str60 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].IWalls[index14].K);
          XFont xfont176 = xfont3;
          XSolidBrush black170 = XBrushes.Black;
          double rc1_169 = (double) SAPInput.RC1;
          xunit3 = PDFFunctions.pages[SAPInput.k].Width;
          double point174 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[SAPInput.k].Height;
          double num209 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect174 = new XRect(542.0, rc1_169, point174, num209);
          XStringFormat topLeft174 = XStringFormat.TopLeft;
          xgraphics174.DrawString(str60, xfont176, (XBrush) black170, xrect174, topLeft174);
        }
        checked { SAPInput.RC1 += 12; }
        checked { ++index14; }
      }
      SAPInput.CheckRC1();
      // ISSUE: reference to a compiler-generated field
      int num210 = checked (SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].NoofICeilings - 1);
      int index15 = 0;
      while (index15 <= num210)
      {
        // ISSUE: reference to a compiler-generated field
        if (SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].ICeilings[index15].Name != null)
        {
          XGraphics xgraphics175 = PDFFunctions.gfx[SAPInput.k];
          // ISSUE: reference to a compiler-generated field
          string name = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].ICeilings[index15].Name;
          XFont xfont177 = xfont3;
          XSolidBrush black171 = XBrushes.Black;
          double rc1_170 = (double) SAPInput.RC1;
          xunit3 = PDFFunctions.pages[SAPInput.k].Width;
          double point175 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[SAPInput.k].Height;
          double num211 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect175 = new XRect(20.0, rc1_170, point175, num211);
          XStringFormat topLeft175 = XStringFormat.TopLeft;
          xgraphics175.DrawString(name, xfont177, (XBrush) black171, xrect175, topLeft175);
        }
        XGraphics xgraphics176 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string str61 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].ICeilings[index15].Area);
        XFont xfont178 = xfont3;
        XSolidBrush black172 = XBrushes.Black;
        double rc1_171 = (double) SAPInput.RC1;
        xunit3 = PDFFunctions.pages[SAPInput.k].Width;
        double point176 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[SAPInput.k].Height;
        double num212 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect176 = new XRect(120.0, rc1_171, point176, num212);
        XStringFormat topLeft176 = XStringFormat.TopLeft;
        xgraphics176.DrawString(str61, xfont178, (XBrush) black172, xrect176, topLeft176);
        // ISSUE: reference to a compiler-generated field
        if ((uint) Operators.CompareString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].TMP.Type, "Calculated", false) > 0U)
        {
          XGraphics xgraphics177 = PDFFunctions.gfx[SAPInput.k];
          XFont xfont179 = xfont3;
          XSolidBrush black173 = XBrushes.Black;
          double rc1_172 = (double) SAPInput.RC1;
          xunit3 = PDFFunctions.pages[SAPInput.k].Width;
          double point177 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[SAPInput.k].Height;
          double num213 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect177 = new XRect(542.0, rc1_172, point177, num213);
          XStringFormat topLeft177 = XStringFormat.TopLeft;
          xgraphics177.DrawString("N/A", xfont179, (XBrush) black173, xrect177, topLeft177);
        }
        else
        {
          XGraphics xgraphics178 = PDFFunctions.gfx[SAPInput.k];
          // ISSUE: reference to a compiler-generated field
          string str62 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].ICeilings[index15].K);
          XFont xfont180 = xfont3;
          XSolidBrush black174 = XBrushes.Black;
          double rc1_173 = (double) SAPInput.RC1;
          xunit3 = PDFFunctions.pages[SAPInput.k].Width;
          double point178 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[SAPInput.k].Height;
          double num214 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect178 = new XRect(542.0, rc1_173, point178, num214);
          XStringFormat topLeft178 = XStringFormat.TopLeft;
          xgraphics178.DrawString(str62, xfont180, (XBrush) black174, xrect178, topLeft178);
        }
        checked { SAPInput.RC1 += 12; }
        checked { ++index15; }
      }
      SAPInput.CheckRC1();
      // ISSUE: reference to a compiler-generated field
      int num215 = checked (SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].NoofIFloors - 1);
      int index16 = 0;
      while (index16 <= num215)
      {
        // ISSUE: reference to a compiler-generated field
        if (SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].IFloors[index16].Name != null)
        {
          XGraphics xgraphics179 = PDFFunctions.gfx[SAPInput.k];
          // ISSUE: reference to a compiler-generated field
          string name = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].IFloors[index16].Name;
          XFont xfont181 = xfont3;
          XSolidBrush black175 = XBrushes.Black;
          double rc1_174 = (double) SAPInput.RC1;
          xunit3 = PDFFunctions.pages[SAPInput.k].Width;
          double point179 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[SAPInput.k].Height;
          double num216 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect179 = new XRect(20.0, rc1_174, point179, num216);
          XStringFormat topLeft179 = XStringFormat.TopLeft;
          xgraphics179.DrawString(name, xfont181, (XBrush) black175, xrect179, topLeft179);
        }
        XGraphics xgraphics180 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string str63 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].IFloors[index16].Area);
        XFont xfont182 = xfont3;
        XSolidBrush black176 = XBrushes.Black;
        double rc1_175 = (double) SAPInput.RC1;
        xunit3 = PDFFunctions.pages[SAPInput.k].Width;
        double point180 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[SAPInput.k].Height;
        double num217 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect180 = new XRect(120.0, rc1_175, point180, num217);
        XStringFormat topLeft180 = XStringFormat.TopLeft;
        xgraphics180.DrawString(str63, xfont182, (XBrush) black176, xrect180, topLeft180);
        // ISSUE: reference to a compiler-generated field
        if ((uint) Operators.CompareString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].TMP.Type, "Calculated", false) > 0U)
        {
          XGraphics xgraphics181 = PDFFunctions.gfx[SAPInput.k];
          XFont xfont183 = xfont3;
          XSolidBrush black177 = XBrushes.Black;
          double rc1_176 = (double) SAPInput.RC1;
          xunit3 = PDFFunctions.pages[SAPInput.k].Width;
          double point181 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[SAPInput.k].Height;
          double num218 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect181 = new XRect(542.0, rc1_176, point181, num218);
          XStringFormat topLeft181 = XStringFormat.TopLeft;
          xgraphics181.DrawString("N/A", xfont183, (XBrush) black177, xrect181, topLeft181);
        }
        else
        {
          XGraphics xgraphics182 = PDFFunctions.gfx[SAPInput.k];
          // ISSUE: reference to a compiler-generated field
          string str64 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].IFloors[index16].K);
          XFont xfont184 = xfont3;
          XSolidBrush black178 = XBrushes.Black;
          double rc1_177 = (double) SAPInput.RC1;
          xunit3 = PDFFunctions.pages[SAPInput.k].Width;
          double point182 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[SAPInput.k].Height;
          double num219 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect182 = new XRect(542.0, rc1_177, point182, num219);
          XStringFormat topLeft182 = XStringFormat.TopLeft;
          xgraphics182.DrawString(str64, xfont184, (XBrush) black178, xrect182, topLeft182);
        }
        checked { SAPInput.RC1 += 12; }
        checked { ++index16; }
      }
      SAPInput.CheckRC1();
      XGraphics xgraphics183 = PDFFunctions.gfx[SAPInput.k];
      XFont xfont185 = xfont4;
      XSolidBrush black179 = XBrushes.Black;
      double rc1_178 = (double) SAPInput.RC1;
      xunit3 = PDFFunctions.pages[SAPInput.k].Width;
      double point183 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[SAPInput.k].Height;
      double num220 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect183 = new XRect(20.0, rc1_178, point183, num220);
      XStringFormat topLeft183 = XStringFormat.TopLeft;
      xgraphics183.DrawString("Party Elements", xfont185, (XBrush) black179, xrect183, topLeft183);
      checked { SAPInput.RC1 += 12; }
      // ISSUE: reference to a compiler-generated field
      int num221 = checked (SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].NoofPWalls - 1);
      int index17 = 0;
      while (index17 <= num221)
      {
        // ISSUE: reference to a compiler-generated field
        if (SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].PWalls[index17].Name != null)
        {
          XGraphics xgraphics184 = PDFFunctions.gfx[SAPInput.k];
          // ISSUE: reference to a compiler-generated field
          string name = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].PWalls[index17].Name;
          XFont xfont186 = xfont3;
          XSolidBrush black180 = XBrushes.Black;
          double rc1_179 = (double) SAPInput.RC1;
          xunit3 = PDFFunctions.pages[SAPInput.k].Width;
          double point184 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[SAPInput.k].Height;
          double num222 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect184 = new XRect(20.0, rc1_179, point184, num222);
          XStringFormat topLeft184 = XStringFormat.TopLeft;
          xgraphics184.DrawString(name, xfont186, (XBrush) black180, xrect184, topLeft184);
        }
        XGraphics xgraphics185 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string str65 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].PWalls[index17].Area);
        XFont xfont187 = xfont3;
        XSolidBrush black181 = XBrushes.Black;
        double rc1_180 = (double) SAPInput.RC1;
        xunit3 = PDFFunctions.pages[SAPInput.k].Width;
        double point185 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[SAPInput.k].Height;
        double num223 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect185 = new XRect(120.0, rc1_180, point185, num223);
        XStringFormat topLeft185 = XStringFormat.TopLeft;
        xgraphics185.DrawString(str65, xfont187, (XBrush) black181, xrect185, topLeft185);
        // ISSUE: reference to a compiler-generated field
        if ((uint) Operators.CompareString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].TMP.Type, "Calculated", false) > 0U)
        {
          XGraphics xgraphics186 = PDFFunctions.gfx[SAPInput.k];
          XFont xfont188 = xfont3;
          XSolidBrush black182 = XBrushes.Black;
          double rc1_181 = (double) SAPInput.RC1;
          xunit3 = PDFFunctions.pages[SAPInput.k].Width;
          double point186 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[SAPInput.k].Height;
          double num224 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect186 = new XRect(542.0, rc1_181, point186, num224);
          XStringFormat topLeft186 = XStringFormat.TopLeft;
          xgraphics186.DrawString("N/A", xfont188, (XBrush) black182, xrect186, topLeft186);
        }
        else
        {
          XGraphics xgraphics187 = PDFFunctions.gfx[SAPInput.k];
          // ISSUE: reference to a compiler-generated field
          string str66 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].PWalls[index17].K);
          XFont xfont189 = xfont3;
          XSolidBrush black183 = XBrushes.Black;
          double rc1_182 = (double) SAPInput.RC1;
          xunit3 = PDFFunctions.pages[SAPInput.k].Width;
          double point187 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[SAPInput.k].Height;
          double num225 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect187 = new XRect(542.0, rc1_182, point187, num225);
          XStringFormat topLeft187 = XStringFormat.TopLeft;
          xgraphics187.DrawString(str66, xfont189, (XBrush) black183, xrect187, topLeft187);
        }
        checked { SAPInput.RC1 += 12; }
        checked { ++index17; }
      }
      SAPInput.CheckRC1();
      // ISSUE: reference to a compiler-generated field
      if (SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].NoofPCeilings > 0)
      {
        // ISSUE: reference to a compiler-generated field
        int num226 = checked (SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].NoofPCeilings - 1);
        int index18 = 0;
        while (index18 <= num226)
        {
          XGraphics xgraphics188 = PDFFunctions.gfx[SAPInput.k];
          // ISSUE: reference to a compiler-generated field
          string name = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].PCeilings[index18].Name;
          XFont xfont190 = xfont3;
          XSolidBrush black184 = XBrushes.Black;
          double rc1_183 = (double) SAPInput.RC1;
          xunit3 = PDFFunctions.pages[SAPInput.k].Width;
          double point188 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[SAPInput.k].Height;
          double num227 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect188 = new XRect(20.0, rc1_183, point188, num227);
          XStringFormat topLeft188 = XStringFormat.TopLeft;
          xgraphics188.DrawString(name, xfont190, (XBrush) black184, xrect188, topLeft188);
          XGraphics xgraphics189 = PDFFunctions.gfx[SAPInput.k];
          // ISSUE: reference to a compiler-generated field
          string str67 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].PCeilings[index18].Area);
          XFont xfont191 = xfont3;
          XSolidBrush black185 = XBrushes.Black;
          double rc1_184 = (double) SAPInput.RC1;
          xunit3 = PDFFunctions.pages[SAPInput.k].Width;
          double point189 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[SAPInput.k].Height;
          double num228 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect189 = new XRect(120.0, rc1_184, point189, num228);
          XStringFormat topLeft189 = XStringFormat.TopLeft;
          xgraphics189.DrawString(str67, xfont191, (XBrush) black185, xrect189, topLeft189);
          // ISSUE: reference to a compiler-generated field
          if ((uint) Operators.CompareString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].TMP.Type, "Calculated", false) > 0U)
          {
            XGraphics xgraphics190 = PDFFunctions.gfx[SAPInput.k];
            XFont xfont192 = xfont3;
            XSolidBrush black186 = XBrushes.Black;
            double rc1_185 = (double) SAPInput.RC1;
            xunit3 = PDFFunctions.pages[SAPInput.k].Width;
            double point190 = ((XUnit) ref xunit3).Point;
            xunit3 = PDFFunctions.pages[SAPInput.k].Height;
            double num229 = ((XUnit) ref xunit3).Point / 2.0;
            XRect xrect190 = new XRect(542.0, rc1_185, point190, num229);
            XStringFormat topLeft190 = XStringFormat.TopLeft;
            xgraphics190.DrawString("N/A", xfont192, (XBrush) black186, xrect190, topLeft190);
          }
          else
          {
            XGraphics xgraphics191 = PDFFunctions.gfx[SAPInput.k];
            // ISSUE: reference to a compiler-generated field
            string str68 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].PCeilings[index18].K);
            XFont xfont193 = xfont3;
            XSolidBrush black187 = XBrushes.Black;
            double rc1_186 = (double) SAPInput.RC1;
            xunit3 = PDFFunctions.pages[SAPInput.k].Width;
            double point191 = ((XUnit) ref xunit3).Point;
            xunit3 = PDFFunctions.pages[SAPInput.k].Height;
            double num230 = ((XUnit) ref xunit3).Point / 2.0;
            XRect xrect191 = new XRect(542.0, rc1_186, point191, num230);
            XStringFormat topLeft191 = XStringFormat.TopLeft;
            xgraphics191.DrawString(str68, xfont193, (XBrush) black187, xrect191, topLeft191);
          }
          checked { SAPInput.RC1 += 12; }
          checked { ++index18; }
        }
      }
      SAPInput.CheckRC1();
      // ISSUE: reference to a compiler-generated field
      if (SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].NoofpFloors > 0)
      {
        try
        {
          // ISSUE: reference to a compiler-generated field
          int num231 = checked (SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].NoofpFloors - 1);
          int index19 = 0;
          while (index19 <= num231)
          {
            XGraphics xgraphics192 = PDFFunctions.gfx[SAPInput.k];
            // ISSUE: reference to a compiler-generated field
            string name = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].PFloors[index19].Name;
            XFont xfont194 = xfont3;
            XSolidBrush black188 = XBrushes.Black;
            double rc1_187 = (double) SAPInput.RC1;
            xunit3 = PDFFunctions.pages[SAPInput.k].Width;
            double point192 = ((XUnit) ref xunit3).Point;
            xunit3 = PDFFunctions.pages[SAPInput.k].Height;
            double num232 = ((XUnit) ref xunit3).Point / 2.0;
            XRect xrect192 = new XRect(20.0, rc1_187, point192, num232);
            XStringFormat topLeft192 = XStringFormat.TopLeft;
            xgraphics192.DrawString(name, xfont194, (XBrush) black188, xrect192, topLeft192);
            XGraphics xgraphics193 = PDFFunctions.gfx[SAPInput.k];
            // ISSUE: reference to a compiler-generated field
            string str69 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].PFloors[index19].Area);
            XFont xfont195 = xfont3;
            XSolidBrush black189 = XBrushes.Black;
            double rc1_188 = (double) SAPInput.RC1;
            xunit3 = PDFFunctions.pages[SAPInput.k].Width;
            double point193 = ((XUnit) ref xunit3).Point;
            xunit3 = PDFFunctions.pages[SAPInput.k].Height;
            double num233 = ((XUnit) ref xunit3).Point / 2.0;
            XRect xrect193 = new XRect(120.0, rc1_188, point193, num233);
            XStringFormat topLeft193 = XStringFormat.TopLeft;
            xgraphics193.DrawString(str69, xfont195, (XBrush) black189, xrect193, topLeft193);
            // ISSUE: reference to a compiler-generated field
            if ((uint) Operators.CompareString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].TMP.Type, "Calculated", false) > 0U)
            {
              XGraphics xgraphics194 = PDFFunctions.gfx[SAPInput.k];
              XFont xfont196 = xfont3;
              XSolidBrush black190 = XBrushes.Black;
              double rc1_189 = (double) SAPInput.RC1;
              xunit3 = PDFFunctions.pages[SAPInput.k].Width;
              double point194 = ((XUnit) ref xunit3).Point;
              xunit3 = PDFFunctions.pages[SAPInput.k].Height;
              double num234 = ((XUnit) ref xunit3).Point / 2.0;
              XRect xrect194 = new XRect(542.0, rc1_189, point194, num234);
              XStringFormat topLeft194 = XStringFormat.TopLeft;
              xgraphics194.DrawString("N/A", xfont196, (XBrush) black190, xrect194, topLeft194);
            }
            else
            {
              XGraphics xgraphics195 = PDFFunctions.gfx[SAPInput.k];
              // ISSUE: reference to a compiler-generated field
              string str70 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].PFloors[index19].K);
              XFont xfont197 = xfont3;
              XSolidBrush black191 = XBrushes.Black;
              double rc1_190 = (double) SAPInput.RC1;
              xunit3 = PDFFunctions.pages[SAPInput.k].Width;
              double point195 = ((XUnit) ref xunit3).Point;
              xunit3 = PDFFunctions.pages[SAPInput.k].Height;
              double num235 = ((XUnit) ref xunit3).Point / 2.0;
              XRect xrect195 = new XRect(542.0, rc1_190, point195, num235);
              XStringFormat topLeft195 = XStringFormat.TopLeft;
              xgraphics195.DrawString(str70, xfont197, (XBrush) black191, xrect195, topLeft195);
            }
            checked { SAPInput.RC1 += 12; }
            checked { ++index19; }
          }
        }
        catch (Exception ex)
        {
          int lErl = num30;
          ProjectData.SetProjectError(ex, lErl);
          ProjectData.ClearProjectError();
        }
      }
      SAPInput.CheckRC1();
      checked { SAPInput.RC1 += 16; }
      PDFFunctions.xBrush1 = XBrush.op_Implicit((Brush) new SolidBrush(Color.FromArgb(159, 172, 62)));
      PDFFunctions.Points[0].X = 20f;
      PDFFunctions.Points[0].Y = (float) SAPInput.RC1;
      ref PointF local9 = ref PDFFunctions.Points[1];
      xunit3 = PDFFunctions.pages[SAPInput.k].Width;
      double num236 = ((XUnit) ref xunit3).Point - 20.0;
      local9.X = (float) num236;
      PDFFunctions.Points[1].Y = (float) SAPInput.RC1;
      ref PointF local10 = ref PDFFunctions.Points[2];
      xunit3 = PDFFunctions.pages[SAPInput.k].Width;
      double num237 = ((XUnit) ref xunit3).Point - 20.0;
      local10.X = (float) num237;
      PDFFunctions.Points[2].Y = (float) checked (SAPInput.RC1 + 14);
      PDFFunctions.Points[3].X = 20f;
      PDFFunctions.Points[3].Y = (float) checked (SAPInput.RC1 + 14);
      PDFFunctions.gfx[SAPInput.k].DrawPolygon(PDFFunctions.polyGreen2, PDFFunctions.xBrush1, PDFFunctions.Points, xfillMode);
      XGraphics xgraphics196 = PDFFunctions.gfx[SAPInput.k];
      XFont xfont198 = xfont3;
      XSolidBrush white5 = XBrushes.White;
      double num238 = (double) checked (SAPInput.RC1 + 1);
      xunit3 = PDFFunctions.pages[SAPInput.k].Width;
      double point196 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[SAPInput.k].Height;
      double num239 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect196 = new XRect(25.0, num238, point196, num239);
      XStringFormat topLeft196 = XStringFormat.TopLeft;
      xgraphics196.DrawString("Thermal bridges:", xfont198, (XBrush) white5, xrect196, topLeft196);
      SAPInput.RC1 = checked ((int) Math.Round(unchecked ((double) PDFFunctions.Points[3].Y + 4.0)));
      SAPInput.CheckRC1();
      // ISSUE: reference to a compiler-generated field
      if (SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Thermal.ManualHtb)
      {
        XGraphics xgraphics197 = PDFFunctions.gfx[SAPInput.k];
        XFont xfont199 = xfont2;
        XSolidBrush black192 = XBrushes.Black;
        double rc1_191 = (double) SAPInput.RC1;
        xunit3 = PDFFunctions.pages[SAPInput.k].Width;
        double point197 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[SAPInput.k].Height;
        double num240 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect197 = new XRect(20.0, rc1_191, point197, num240);
        XStringFormat topLeft197 = XStringFormat.TopLeft;
        xgraphics197.DrawString("Thermal bridges:", xfont199, (XBrush) black192, xrect197, topLeft197);
        try
        {
          XGraphics xgraphics198 = PDFFunctions.gfx[SAPInput.k];
          string str71 = "User-defined (individual PSI-values) Y-Value =  " + Conversions.ToString(SAPInput.ShowY());
          XFont xfont200 = xfont3;
          XSolidBrush black193 = XBrushes.Black;
          double rc1_192 = (double) SAPInput.RC1;
          xunit3 = PDFFunctions.pages[SAPInput.k].Width;
          double point198 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[SAPInput.k].Height;
          double num241 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect198 = new XRect(200.0, rc1_192, point198, num241);
          XStringFormat topLeft198 = XStringFormat.TopLeft;
          xgraphics198.DrawString(str71, xfont200, (XBrush) black193, xrect198, topLeft198);
        }
        catch (Exception ex)
        {
          int lErl = num30;
          ProjectData.SetProjectError(ex, lErl);
          ProjectData.ClearProjectError();
        }
        checked { SAPInput.RC1 += 12; }
        XGraphics xgraphics199 = PDFFunctions.gfx[SAPInput.k];
        XFont arialFont10Bold8 = PDFFunctions.ArialFont10Bold;
        XSolidBrush black194 = XBrushes.Black;
        double rc1_193 = (double) SAPInput.RC1;
        XUnit xunit4 = PDFFunctions.pages[SAPInput.k].Width;
        double point199 = ((XUnit) ref xunit4).Point;
        xunit4 = PDFFunctions.pages[SAPInput.k].Height;
        double num242 = ((XUnit) ref xunit4).Point / 2.0;
        XRect xrect199 = new XRect(200.0, rc1_193, point199, num242);
        XStringFormat topLeft199 = XStringFormat.TopLeft;
        xgraphics199.DrawString("Length", arialFont10Bold8, (XBrush) black194, xrect199, topLeft199);
        XGraphics xgraphics200 = PDFFunctions.gfx[SAPInput.k];
        XFont arialFont10Bold9 = PDFFunctions.ArialFont10Bold;
        XSolidBrush black195 = XBrushes.Black;
        double rc1_194 = (double) SAPInput.RC1;
        xunit4 = PDFFunctions.pages[SAPInput.k].Width;
        double point200 = ((XUnit) ref xunit4).Point;
        xunit4 = PDFFunctions.pages[SAPInput.k].Height;
        double num243 = ((XUnit) ref xunit4).Point / 2.0;
        XRect xrect200 = new XRect(260.0, rc1_194, point200, num243);
        XStringFormat topLeft200 = XStringFormat.TopLeft;
        xgraphics200.DrawString("Psi-value", arialFont10Bold9, (XBrush) black195, xrect200, topLeft200);
        checked { SAPInput.RC1 += 12; }
        try
        {
          // ISSUE: reference to a compiler-generated field
          int num244 = checked (SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Thermal.ExternalJunctions.Count - 1);
          int index20 = 0;
          while (index20 <= num244)
          {
            XGraphics xgraphics201 = PDFFunctions.gfx[SAPInput.k];
            // ISSUE: reference to a compiler-generated field
            string str72 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Thermal.ExternalJunctions[index20].Length);
            XFont xfont201 = xfont3;
            XSolidBrush black196 = XBrushes.Black;
            double rc1_195 = (double) SAPInput.RC1;
            xunit4 = PDFFunctions.pages[SAPInput.k].Width;
            double point201 = ((XUnit) ref xunit4).Point;
            xunit4 = PDFFunctions.pages[SAPInput.k].Height;
            double num245 = ((XUnit) ref xunit4).Point / 2.0;
            XRect xrect201 = new XRect(200.0, rc1_195, point201, num245);
            XStringFormat topLeft201 = XStringFormat.TopLeft;
            xgraphics201.DrawString(str72, xfont201, (XBrush) black196, xrect201, topLeft201);
            XGraphics xgraphics202 = PDFFunctions.gfx[SAPInput.k];
            // ISSUE: reference to a compiler-generated field
            string str73 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Thermal.ExternalJunctions[index20].ThermalTransmittance);
            XFont xfont202 = xfont3;
            XSolidBrush black197 = XBrushes.Black;
            double rc1_196 = (double) SAPInput.RC1;
            xunit4 = PDFFunctions.pages[SAPInput.k].Width;
            double point202 = ((XUnit) ref xunit4).Point;
            xunit4 = PDFFunctions.pages[SAPInput.k].Height;
            double num246 = ((XUnit) ref xunit4).Point / 2.0;
            XRect xrect202 = new XRect(260.0, rc1_196, point202, num246);
            XStringFormat topLeft202 = XStringFormat.TopLeft;
            xgraphics202.DrawString(str73, xfont202, (XBrush) black197, xrect202, topLeft202);
            XGraphics xgraphics203 = PDFFunctions.gfx[SAPInput.k];
            // ISSUE: reference to a compiler-generated field
            string str74 = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Thermal.ExternalJunctions[index20].Ref;
            XFont xfont203 = xfont3;
            XSolidBrush black198 = XBrushes.Black;
            double rc1_197 = (double) SAPInput.RC1;
            xunit4 = PDFFunctions.pages[SAPInput.k].Width;
            double point203 = ((XUnit) ref xunit4).Point;
            xunit4 = PDFFunctions.pages[SAPInput.k].Height;
            double num247 = ((XUnit) ref xunit4).Point / 2.0;
            XRect xrect203 = new XRect(320.0, rc1_197, point203, num247);
            XStringFormat topLeft203 = XStringFormat.TopLeft;
            xgraphics203.DrawString(str74, xfont203, (XBrush) black198, xrect203, topLeft203);
            try
            {
              XGraphics xgraphics204 = PDFFunctions.gfx[SAPInput.k];
              // ISSUE: reference to a compiler-generated field
              string junctionDetail = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Thermal.ExternalJunctions[index20].JunctionDetail;
              XFont xfont204 = xfont9;
              XSolidBrush black199 = XBrushes.Black;
              double rc1_198 = (double) SAPInput.RC1;
              xunit4 = PDFFunctions.pages[SAPInput.k].Width;
              double point204 = ((XUnit) ref xunit4).Point;
              xunit4 = PDFFunctions.pages[SAPInput.k].Height;
              double num248 = ((XUnit) ref xunit4).Point / 2.0;
              XRect xrect204 = new XRect(350.0, rc1_198, point204, num248);
              XStringFormat topLeft204 = XStringFormat.TopLeft;
              xgraphics204.DrawString(junctionDetail, xfont204, (XBrush) black199, xrect204, topLeft204);
            }
            catch (Exception ex)
            {
              int lErl = num30;
              ProjectData.SetProjectError(ex, lErl);
              ProjectData.ClearProjectError();
            }
            // ISSUE: reference to a compiler-generated field
            if (SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Thermal.ExternalJunctions[index20].IsAccredited)
            {
              XGraphics xgraphics205 = PDFFunctions.gfx[SAPInput.k];
              XFont xfont205 = xfont3;
              XSolidBrush black200 = XBrushes.Black;
              double rc1_199 = (double) SAPInput.RC1;
              xunit4 = PDFFunctions.pages[SAPInput.k].Width;
              double point205 = ((XUnit) ref xunit4).Point;
              xunit4 = PDFFunctions.pages[SAPInput.k].Height;
              double num249 = ((XUnit) ref xunit4).Point / 2.0;
              XRect xrect205 = new XRect(100.0, rc1_199, point205, num249);
              XStringFormat topLeft205 = XStringFormat.TopLeft;
              xgraphics205.DrawString("[Approved]", xfont205, (XBrush) black200, xrect205, topLeft205);
            }
            checked { SAPInput.RC1 += 12; }
            SAPInput.CheckRC1();
            checked { ++index20; }
          }
          // ISSUE: reference to a compiler-generated field
          int num250 = checked (SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Thermal.PartyJunctions.Count - 1);
          int index21 = 0;
          while (index21 <= num250)
          {
            XGraphics xgraphics206 = PDFFunctions.gfx[SAPInput.k];
            // ISSUE: reference to a compiler-generated field
            string str75 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Thermal.PartyJunctions[index21].Length);
            XFont xfont206 = xfont3;
            XSolidBrush black201 = XBrushes.Black;
            double rc1_200 = (double) SAPInput.RC1;
            xunit4 = PDFFunctions.pages[SAPInput.k].Width;
            double point206 = ((XUnit) ref xunit4).Point;
            xunit4 = PDFFunctions.pages[SAPInput.k].Height;
            double num251 = ((XUnit) ref xunit4).Point / 2.0;
            XRect xrect206 = new XRect(200.0, rc1_200, point206, num251);
            XStringFormat topLeft206 = XStringFormat.TopLeft;
            xgraphics206.DrawString(str75, xfont206, (XBrush) black201, xrect206, topLeft206);
            XGraphics xgraphics207 = PDFFunctions.gfx[SAPInput.k];
            // ISSUE: reference to a compiler-generated field
            string str76 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Thermal.PartyJunctions[index21].ThermalTransmittance);
            XFont xfont207 = xfont3;
            XSolidBrush black202 = XBrushes.Black;
            double rc1_201 = (double) SAPInput.RC1;
            xunit4 = PDFFunctions.pages[SAPInput.k].Width;
            double point207 = ((XUnit) ref xunit4).Point;
            xunit4 = PDFFunctions.pages[SAPInput.k].Height;
            double num252 = ((XUnit) ref xunit4).Point / 2.0;
            XRect xrect207 = new XRect(260.0, rc1_201, point207, num252);
            XStringFormat topLeft207 = XStringFormat.TopLeft;
            xgraphics207.DrawString(str76, xfont207, (XBrush) black202, xrect207, topLeft207);
            XGraphics xgraphics208 = PDFFunctions.gfx[SAPInput.k];
            // ISSUE: reference to a compiler-generated field
            string str77 = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Thermal.PartyJunctions[index21].Ref;
            XFont xfont208 = xfont3;
            XSolidBrush black203 = XBrushes.Black;
            double rc1_202 = (double) SAPInput.RC1;
            xunit4 = PDFFunctions.pages[SAPInput.k].Width;
            double point208 = ((XUnit) ref xunit4).Point;
            xunit4 = PDFFunctions.pages[SAPInput.k].Height;
            double num253 = ((XUnit) ref xunit4).Point / 2.0;
            XRect xrect208 = new XRect(320.0, rc1_202, point208, num253);
            XStringFormat topLeft208 = XStringFormat.TopLeft;
            xgraphics208.DrawString(str77, xfont208, (XBrush) black203, xrect208, topLeft208);
            try
            {
              XGraphics xgraphics209 = PDFFunctions.gfx[SAPInput.k];
              // ISSUE: reference to a compiler-generated field
              string junctionDetail = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Thermal.PartyJunctions[index21].JunctionDetail;
              XFont xfont209 = xfont9;
              XSolidBrush black204 = XBrushes.Black;
              double rc1_203 = (double) SAPInput.RC1;
              xunit4 = PDFFunctions.pages[SAPInput.k].Width;
              double point209 = ((XUnit) ref xunit4).Point;
              xunit4 = PDFFunctions.pages[SAPInput.k].Height;
              double num254 = ((XUnit) ref xunit4).Point / 2.0;
              XRect xrect209 = new XRect(350.0, rc1_203, point209, num254);
              XStringFormat topLeft209 = XStringFormat.TopLeft;
              xgraphics209.DrawString(junctionDetail, xfont209, (XBrush) black204, xrect209, topLeft209);
            }
            catch (Exception ex)
            {
              int lErl = num30;
              ProjectData.SetProjectError(ex, lErl);
              ProjectData.ClearProjectError();
            }
            // ISSUE: reference to a compiler-generated field
            if (SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Thermal.PartyJunctions[index21].Accredited != 0.0)
            {
              XGraphics xgraphics210 = PDFFunctions.gfx[SAPInput.k];
              XFont xfont210 = xfont3;
              XSolidBrush black205 = XBrushes.Black;
              double rc1_204 = (double) SAPInput.RC1;
              xunit4 = PDFFunctions.pages[SAPInput.k].Width;
              double point210 = ((XUnit) ref xunit4).Point;
              xunit4 = PDFFunctions.pages[SAPInput.k].Height;
              double num255 = ((XUnit) ref xunit4).Point / 2.0;
              XRect xrect210 = new XRect(100.0, rc1_204, point210, num255);
              XStringFormat topLeft210 = XStringFormat.TopLeft;
              xgraphics210.DrawString("Approved source", xfont210, (XBrush) black205, xrect210, topLeft210);
            }
            checked { SAPInput.RC1 += 12; }
            SAPInput.CheckRC1();
            checked { ++index21; }
          }
          // ISSUE: reference to a compiler-generated field
          int num256 = checked (SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Thermal.RoofJunctions.Count - 1);
          int index22 = 0;
          while (index22 <= num256)
          {
            XGraphics xgraphics211 = PDFFunctions.gfx[SAPInput.k];
            // ISSUE: reference to a compiler-generated field
            string str78 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Thermal.RoofJunctions[index22].Length);
            XFont xfont211 = xfont3;
            XSolidBrush black206 = XBrushes.Black;
            double rc1_205 = (double) SAPInput.RC1;
            xunit4 = PDFFunctions.pages[SAPInput.k].Width;
            double point211 = ((XUnit) ref xunit4).Point;
            xunit4 = PDFFunctions.pages[SAPInput.k].Height;
            double num257 = ((XUnit) ref xunit4).Point / 2.0;
            XRect xrect211 = new XRect(200.0, rc1_205, point211, num257);
            XStringFormat topLeft211 = XStringFormat.TopLeft;
            xgraphics211.DrawString(str78, xfont211, (XBrush) black206, xrect211, topLeft211);
            XGraphics xgraphics212 = PDFFunctions.gfx[SAPInput.k];
            // ISSUE: reference to a compiler-generated field
            string str79 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Thermal.RoofJunctions[index22].ThermalTransmittance);
            XFont xfont212 = xfont3;
            XSolidBrush black207 = XBrushes.Black;
            double rc1_206 = (double) SAPInput.RC1;
            xunit4 = PDFFunctions.pages[SAPInput.k].Width;
            double point212 = ((XUnit) ref xunit4).Point;
            xunit4 = PDFFunctions.pages[SAPInput.k].Height;
            double num258 = ((XUnit) ref xunit4).Point / 2.0;
            XRect xrect212 = new XRect(260.0, rc1_206, point212, num258);
            XStringFormat topLeft212 = XStringFormat.TopLeft;
            xgraphics212.DrawString(str79, xfont212, (XBrush) black207, xrect212, topLeft212);
            XGraphics xgraphics213 = PDFFunctions.gfx[SAPInput.k];
            // ISSUE: reference to a compiler-generated field
            string str80 = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Thermal.RoofJunctions[index22].Ref;
            XFont xfont213 = xfont3;
            XSolidBrush black208 = XBrushes.Black;
            double rc1_207 = (double) SAPInput.RC1;
            xunit4 = PDFFunctions.pages[SAPInput.k].Width;
            double point213 = ((XUnit) ref xunit4).Point;
            xunit4 = PDFFunctions.pages[SAPInput.k].Height;
            double num259 = ((XUnit) ref xunit4).Point / 2.0;
            XRect xrect213 = new XRect(320.0, rc1_207, point213, num259);
            XStringFormat topLeft213 = XStringFormat.TopLeft;
            xgraphics213.DrawString(str80, xfont213, (XBrush) black208, xrect213, topLeft213);
            try
            {
              XGraphics xgraphics214 = PDFFunctions.gfx[SAPInput.k];
              // ISSUE: reference to a compiler-generated field
              string junctionDetail = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Thermal.RoofJunctions[index22].JunctionDetail;
              XFont xfont214 = xfont9;
              XSolidBrush black209 = XBrushes.Black;
              double rc1_208 = (double) SAPInput.RC1;
              xunit4 = PDFFunctions.pages[SAPInput.k].Width;
              double point214 = ((XUnit) ref xunit4).Point;
              xunit4 = PDFFunctions.pages[SAPInput.k].Height;
              double num260 = ((XUnit) ref xunit4).Point / 2.0;
              XRect xrect214 = new XRect(350.0, rc1_208, point214, num260);
              XStringFormat topLeft214 = XStringFormat.TopLeft;
              xgraphics214.DrawString(junctionDetail, xfont214, (XBrush) black209, xrect214, topLeft214);
            }
            catch (Exception ex)
            {
              int lErl = num30;
              ProjectData.SetProjectError(ex, lErl);
              ProjectData.ClearProjectError();
            }
            // ISSUE: reference to a compiler-generated field
            if (SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Thermal.RoofJunctions[index22].Accredited != 0.0)
            {
              XGraphics xgraphics215 = PDFFunctions.gfx[SAPInput.k];
              XFont xfont215 = xfont3;
              XSolidBrush black210 = XBrushes.Black;
              double rc1_209 = (double) SAPInput.RC1;
              xunit4 = PDFFunctions.pages[SAPInput.k].Width;
              double point215 = ((XUnit) ref xunit4).Point;
              xunit4 = PDFFunctions.pages[SAPInput.k].Height;
              double num261 = ((XUnit) ref xunit4).Point / 2.0;
              XRect xrect215 = new XRect(100.0, rc1_209, point215, num261);
              XStringFormat topLeft215 = XStringFormat.TopLeft;
              xgraphics215.DrawString("Approved source", xfont215, (XBrush) black210, xrect215, topLeft215);
            }
            checked { SAPInput.RC1 += 12; }
            SAPInput.CheckRC1();
            checked { ++index22; }
          }
        }
        catch (Exception ex)
        {
          int lErl = num30;
          ProjectData.SetProjectError(ex, lErl);
          ProjectData.ClearProjectError();
        }
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        if (SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Thermal.ManualY)
        {
          XGraphics xgraphics216 = PDFFunctions.gfx[SAPInput.k];
          XFont xfont216 = xfont2;
          XSolidBrush black211 = XBrushes.Black;
          double rc1_210 = (double) SAPInput.RC1;
          xunit3 = PDFFunctions.pages[SAPInput.k].Width;
          double point216 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[SAPInput.k].Height;
          double num262 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect216 = new XRect(20.0, rc1_210, point216, num262);
          XStringFormat topLeft216 = XStringFormat.TopLeft;
          xgraphics216.DrawString("Thermal bridges:", xfont216, (XBrush) black211, xrect216, topLeft216);
          XGraphics xgraphics217 = PDFFunctions.gfx[SAPInput.k];
          XFont xfont217 = xfont3;
          XSolidBrush black212 = XBrushes.Black;
          double rc1_211 = (double) SAPInput.RC1;
          xunit3 = PDFFunctions.pages[SAPInput.k].Width;
          double point217 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[SAPInput.k].Height;
          double num263 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect217 = new XRect(200.0, rc1_211, point217, num263);
          XStringFormat topLeft217 = XStringFormat.TopLeft;
          xgraphics217.DrawString("User-defined y-value", xfont217, (XBrush) black212, xrect217, topLeft217);
          checked { SAPInput.RC1 += 12; }
          XGraphics xgraphics218 = PDFFunctions.gfx[SAPInput.k];
          // ISSUE: reference to a compiler-generated field
          string str81 = "y =" + Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Thermal.YValue);
          XFont xfont218 = xfont3;
          XSolidBrush black213 = XBrushes.Black;
          double rc1_212 = (double) SAPInput.RC1;
          xunit3 = PDFFunctions.pages[SAPInput.k].Width;
          double point218 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[SAPInput.k].Height;
          double num264 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect218 = new XRect(200.0, rc1_212, point218, num264);
          XStringFormat topLeft218 = XStringFormat.TopLeft;
          xgraphics218.DrawString(str81, xfont218, (XBrush) black213, xrect218, topLeft218);
          checked { SAPInput.RC1 += 12; }
          XGraphics xgraphics219 = PDFFunctions.gfx[SAPInput.k];
          // ISSUE: reference to a compiler-generated field
          string str82 = "Reference: " + SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Thermal.Reference;
          XFont xfont219 = xfont3;
          XSolidBrush black214 = XBrushes.Black;
          double rc1_213 = (double) SAPInput.RC1;
          xunit3 = PDFFunctions.pages[SAPInput.k].Width;
          double point219 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[SAPInput.k].Height;
          double num265 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect219 = new XRect(200.0, rc1_213, point219, num265);
          XStringFormat topLeft219 = XStringFormat.TopLeft;
          xgraphics219.DrawString(str82, xfont219, (XBrush) black214, xrect219, topLeft219);
          checked { SAPInput.RC1 += 12; }
        }
        else
        {
          SAPInput.CheckRC1();
          // ISSUE: reference to a compiler-generated field
          string str83 = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Thermal.ConstDetails;
          // ISSUE: reference to a compiler-generated field
          if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Thermal.ConstDetails, "All detailing conforms with Accredited Construction Details", false) == 0)
            str83 = "Accredited Construction Details";
          XGraphics xgraphics220 = PDFFunctions.gfx[SAPInput.k];
          XFont xfont220 = xfont2;
          XSolidBrush black215 = XBrushes.Black;
          double rc1_214 = (double) SAPInput.RC1;
          xunit3 = PDFFunctions.pages[SAPInput.k].Width;
          double point220 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[SAPInput.k].Height;
          double num266 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect220 = new XRect(20.0, rc1_214, point220, num266);
          XStringFormat topLeft220 = XStringFormat.TopLeft;
          xgraphics220.DrawString("Thermal bridges:", xfont220, (XBrush) black215, xrect220, topLeft220);
          XGraphics xgraphics221 = PDFFunctions.gfx[SAPInput.k];
          // ISSUE: reference to a compiler-generated field
          string str84 = str83 + " (y =" + Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Thermal.YValue) + ")";
          XFont xfont221 = xfont3;
          XSolidBrush black216 = XBrushes.Black;
          double rc1_215 = (double) SAPInput.RC1;
          xunit3 = PDFFunctions.pages[SAPInput.k].Width;
          double point221 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[SAPInput.k].Height;
          double num267 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect221 = new XRect(200.0, rc1_215, point221, num267);
          XStringFormat topLeft221 = XStringFormat.TopLeft;
          xgraphics221.DrawString(str84, xfont221, (XBrush) black216, xrect221, topLeft221);
        }
      }
      checked { SAPInput.RC1 += 14; }
      SAPInput.CheckRC1();
      PDFFunctions.xBrush1 = XBrush.op_Implicit((Brush) new SolidBrush(Color.FromArgb(159, 172, 62)));
      PDFFunctions.Points[0].X = 20f;
      PDFFunctions.Points[0].Y = (float) SAPInput.RC1;
      ref PointF local11 = ref PDFFunctions.Points[1];
      xunit3 = PDFFunctions.pages[SAPInput.k].Width;
      double num268 = ((XUnit) ref xunit3).Point - 20.0;
      local11.X = (float) num268;
      PDFFunctions.Points[1].Y = (float) SAPInput.RC1;
      ref PointF local12 = ref PDFFunctions.Points[2];
      xunit3 = PDFFunctions.pages[SAPInput.k].Width;
      double num269 = ((XUnit) ref xunit3).Point - 20.0;
      local12.X = (float) num269;
      PDFFunctions.Points[2].Y = (float) checked (SAPInput.RC1 + 14);
      PDFFunctions.Points[3].X = 20f;
      PDFFunctions.Points[3].Y = (float) checked (SAPInput.RC1 + 14);
      PDFFunctions.gfx[SAPInput.k].DrawPolygon(PDFFunctions.polyGreen2, PDFFunctions.xBrush1, PDFFunctions.Points, xfillMode);
      XGraphics xgraphics222 = PDFFunctions.gfx[SAPInput.k];
      XFont xfont222 = xfont2;
      XSolidBrush white6 = XBrushes.White;
      double rc1_216 = (double) SAPInput.RC1;
      xunit3 = PDFFunctions.pages[SAPInput.k].Width;
      double point222 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[SAPInput.k].Height;
      double num270 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect222 = new XRect(25.0, rc1_216, point222, num270);
      XStringFormat topLeft222 = XStringFormat.TopLeft;
      xgraphics222.DrawString("Ventilation:", xfont222, (XBrush) white6, xrect222, topLeft222);
      checked { SAPInput.RC1 += 15; }
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      string str85 = !(Operators.CompareString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Ventilation.Pressure, "As built", false) == 0 | Operators.CompareString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Ventilation.Pressure, "As designed", false) == 0) ? "No (" + SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Ventilation.Pressure + ")" : "Yes (" + SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Ventilation.Pressure + ")";
      XGraphics xgraphics223 = PDFFunctions.gfx[SAPInput.k];
      XFont xfont223 = xfont2;
      XSolidBrush black217 = XBrushes.Black;
      double rc1_217 = (double) SAPInput.RC1;
      xunit3 = PDFFunctions.pages[SAPInput.k].Width;
      double point223 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[SAPInput.k].Height;
      double num271 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect223 = new XRect(20.0, rc1_217, point223, num271);
      XStringFormat topLeft223 = XStringFormat.TopLeft;
      xgraphics223.DrawString("Pressure test:", xfont223, (XBrush) black217, xrect223, topLeft223);
      XGraphics xgraphics224 = PDFFunctions.gfx[SAPInput.k];
      string str86 = str85;
      XFont xfont224 = xfont3;
      XSolidBrush black218 = XBrushes.Black;
      double rc1_218 = (double) SAPInput.RC1;
      xunit3 = PDFFunctions.pages[SAPInput.k].Width;
      double point224 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[SAPInput.k].Height;
      double num272 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect224 = new XRect(200.0, rc1_218, point224, num272);
      XStringFormat topLeft224 = XStringFormat.TopLeft;
      xgraphics224.DrawString(str86, xfont224, (XBrush) black218, xrect224, topLeft224);
      checked { SAPInput.RC1 += 12; }
      SAPInput.CheckRC1();
      XGraphics xgraphics225 = PDFFunctions.gfx[SAPInput.k];
      XFont xfont225 = xfont2;
      XSolidBrush black219 = XBrushes.Black;
      double rc1_219 = (double) SAPInput.RC1;
      xunit3 = PDFFunctions.pages[SAPInput.k].Width;
      double point225 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[SAPInput.k].Height;
      double num273 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect225 = new XRect(20.0, rc1_219, point225, num273);
      XStringFormat topLeft225 = XStringFormat.TopLeft;
      xgraphics225.DrawString("Ventilation:", xfont225, (XBrush) black219, xrect225, topLeft225);
      // ISSUE: reference to a compiler-generated field
      string str87 = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Ventilation.MechVent;
      // ISSUE: reference to a compiler-generated field
      if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Ventilation.MechVent, "Natural ventilation", false) == 0)
        str87 = "Natural ventilation (extract fans)";
      XGraphics xgraphics226 = PDFFunctions.gfx[SAPInput.k];
      string str88 = str87;
      XFont xfont226 = xfont3;
      XSolidBrush black220 = XBrushes.Black;
      double rc1_220 = (double) SAPInput.RC1;
      xunit3 = PDFFunctions.pages[SAPInput.k].Width;
      double point226 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[SAPInput.k].Height;
      double num274 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect226 = new XRect(200.0, rc1_220, point226, num274);
      XStringFormat topLeft226 = XStringFormat.TopLeft;
      xgraphics226.DrawString(str88, xfont226, (XBrush) black220, xrect226, topLeft226);
      checked { SAPInput.RC1 += 12; }
      SAPInput.CheckRC1();
      string str89 = "";
      // ISSUE: reference to a compiler-generated field
      if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Ventilation.Parameters, "Database", false) == 0)
      {
        // ISSUE: reference to a compiler-generated field
        string mechVent1 = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Ventilation.MechVent;
        object Instance;
        List<PCDF.Products321_Sub> list;
        if (Operators.CompareString(mechVent1, "Balanced with heat recovery", false) != 0 && Operators.CompareString(mechVent1, "Centralised whole house extract", false) != 0)
        {
          if (Operators.CompareString(mechVent1, "Decentralised whole house extract", false) == 0)
          {
            // ISSUE: reference to a compiler-generated method
            Instance = (object) SAP_Module.PCDFData.Products322s.Where<PCDF.Products322>(new Func<PCDF.Products322, bool>(closure160_2._Lambda\u0024__2)).SingleOrDefault<PCDF.Products322>();
          }
        }
        else
        {
          // ISSUE: reference to a compiler-generated method
          Instance = (object) SAP_Module.PCDFData.Products321s.Where<PCDF.Products321>(new Func<PCDF.Products321, bool>(closure160_2._Lambda\u0024__0)).SingleOrDefault<PCDF.Products321>();
          // ISSUE: reference to a compiler-generated method
          list = SAP_Module.PCDFData.Products321s_Sub.Where<PCDF.Products321_Sub>(new Func<PCDF.Products321_Sub, bool>(closure160_2._Lambda\u0024__1)).ToList<PCDF.Products321_Sub>();
          object Left = NewLateBinding.LateGet(Instance, (System.Type) null, "DuctingType", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null);
          if (Operators.ConditionalCompareObjectEqual(Left, (object) "1", false))
            str89 = "flexible";
          else if (Operators.ConditionalCompareObjectEqual(Left, (object) "2", false))
            str89 = "rigid";
        }
        try
        {
          if (Operators.ConditionalCompareObjectNotEqual(NewLateBinding.LateGet(Instance, (System.Type) null, "Length", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) 0, false))
          {
            XGraphics xgraphics227 = PDFFunctions.gfx[SAPInput.k];
            string str90 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object) "Brand/Model: ", NewLateBinding.LateGet(Instance, (System.Type) null, "Brand", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)), (object) " "), NewLateBinding.LateGet(Instance, (System.Type) null, "Model", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)));
            XFont xfont227 = xfont3;
            XSolidBrush black221 = XBrushes.Black;
            double rc1_221 = (double) SAPInput.RC1;
            xunit3 = PDFFunctions.pages[SAPInput.k].Width;
            double point227 = ((XUnit) ref xunit3).Point;
            xunit3 = PDFFunctions.pages[SAPInput.k].Height;
            double num275 = ((XUnit) ref xunit3).Point / 2.0;
            XRect xrect227 = new XRect(210.0, rc1_221, point227, num275);
            XStringFormat topLeft227 = XStringFormat.TopLeft;
            xgraphics227.DrawString(str90, xfont227, (XBrush) black221, xrect227, topLeft227);
            checked { SAPInput.RC1 += 12; }
            // ISSUE: reference to a compiler-generated field
            string mechVent2 = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Ventilation.MechVent;
            if (Operators.CompareString(mechVent2, "Balanced with heat recovery", false) == 0 || Operators.CompareString(mechVent2, "Centralised whole house extract", false) == 0)
            {
              XGraphics xgraphics228 = PDFFunctions.gfx[SAPInput.k];
              string str91 = "Test efficiency: " + list[0].HeatExchangerEfficiency + "%, SFP: " + list[0].SFP;
              XFont xfont228 = xfont3;
              XSolidBrush black222 = XBrushes.Black;
              double rc1_222 = (double) SAPInput.RC1;
              xunit3 = PDFFunctions.pages[SAPInput.k].Width;
              double point228 = ((XUnit) ref xunit3).Point;
              xunit3 = PDFFunctions.pages[SAPInput.k].Height;
              double num276 = ((XUnit) ref xunit3).Point / 2.0;
              XRect xrect228 = new XRect(210.0, rc1_222, point228, num276);
              XStringFormat topLeft228 = XStringFormat.TopLeft;
              xgraphics228.DrawString(str91, xfont228, (XBrush) black222, xrect228, topLeft228);
              checked { SAPInput.RC1 += 12; }
            }
          }
        }
        catch (Exception ex)
        {
          int lErl = num30;
          ProjectData.SetProjectError(ex, lErl);
          ProjectData.ClearProjectError();
        }
      }
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      if ((uint) Operators.CompareString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Ventilation.MechVent, "Natural ventilation", false) > 0U & !SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Ventilation.MechVent.Contains("Positive"))
      {
        // ISSUE: reference to a compiler-generated field
        if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Ventilation.MechVent, "Decentralised whole house extract", false) == 0)
        {
          // ISSUE: reference to a compiler-generated field
          string parameters = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Ventilation.Parameters;
          if (Operators.CompareString(parameters, "Database", false) == 0 || Operators.CompareString(parameters, "User defined", false) == 0)
          {
            XGraphics xgraphics229 = PDFFunctions.gfx[SAPInput.k];
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            string str92 = "Number of fans in Wetroom: Kitchen " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Ventilation.Decentralised.KTP1 + SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Ventilation.Decentralised.KTP2 + SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Ventilation.Decentralised.KTP3) + " Other " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Ventilation.Decentralised.OTP1 + SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Ventilation.Decentralised.OTP2 + SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Ventilation.Decentralised.OTP3);
            XFont xfont229 = xfont3;
            XSolidBrush black223 = XBrushes.Black;
            double rc1_223 = (double) SAPInput.RC1;
            xunit3 = PDFFunctions.pages[SAPInput.k].Width;
            double point229 = ((XUnit) ref xunit3).Point;
            xunit3 = PDFFunctions.pages[SAPInput.k].Height;
            double num277 = ((XUnit) ref xunit3).Point / 2.0;
            XRect xrect229 = new XRect(200.0, rc1_223, point229, num277);
            XStringFormat topLeft229 = XStringFormat.TopLeft;
            xgraphics229.DrawString(str92, xfont229, (XBrush) black223, xrect229, topLeft229);
            checked { SAPInput.RC1 += 12; }
          }
          else
          {
            XGraphics xgraphics230 = PDFFunctions.gfx[SAPInput.k];
            // ISSUE: reference to a compiler-generated field
            string str93 = "Number of wet rooms: Kitchen + " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Ventilation.WetRooms);
            XFont xfont230 = xfont3;
            XSolidBrush black224 = XBrushes.Black;
            double rc1_224 = (double) SAPInput.RC1;
            xunit3 = PDFFunctions.pages[SAPInput.k].Width;
            double point230 = ((XUnit) ref xunit3).Point;
            xunit3 = PDFFunctions.pages[SAPInput.k].Height;
            double num278 = ((XUnit) ref xunit3).Point / 2.0;
            XRect xrect230 = new XRect(200.0, rc1_224, point230, num278);
            XStringFormat topLeft230 = XStringFormat.TopLeft;
            xgraphics230.DrawString(str93, xfont230, (XBrush) black224, xrect230, topLeft230);
            checked { SAPInput.RC1 += 12; }
          }
        }
        else
        {
          XGraphics xgraphics231 = PDFFunctions.gfx[SAPInput.k];
          // ISSUE: reference to a compiler-generated field
          string str94 = "Number of wet rooms: Kitchen + " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Ventilation.WetRooms);
          XFont xfont231 = xfont3;
          XSolidBrush black225 = XBrushes.Black;
          double rc1_225 = (double) SAPInput.RC1;
          xunit3 = PDFFunctions.pages[SAPInput.k].Width;
          double point231 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[SAPInput.k].Height;
          double num279 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect231 = new XRect(200.0, rc1_225, point231, num279);
          XStringFormat topLeft231 = XStringFormat.TopLeft;
          xgraphics231.DrawString(str94, xfont231, (XBrush) black225, xrect231, topLeft231);
          checked { SAPInput.RC1 += 12; }
        }
        // ISSUE: reference to a compiler-generated field
        if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Ventilation.Parameters, "Database", false) == 0)
        {
          XGraphics xgraphics232 = PDFFunctions.gfx[SAPInput.k];
          // ISSUE: reference to a compiler-generated field
          string str95 = "Ductwork: " + SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Ventilation.DuctType + ", " + str89;
          XFont xfont232 = xfont3;
          XSolidBrush black226 = XBrushes.Black;
          double rc1_226 = (double) SAPInput.RC1;
          xunit3 = PDFFunctions.pages[SAPInput.k].Width;
          double point232 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[SAPInput.k].Height;
          double num280 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect232 = new XRect(200.0, rc1_226, point232, num280);
          XStringFormat topLeft232 = XStringFormat.TopLeft;
          xgraphics232.DrawString(str95, xfont232, (XBrush) black226, xrect232, topLeft232);
        }
        else
        {
          XGraphics xgraphics233 = PDFFunctions.gfx[SAPInput.k];
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          string str96 = "Ductwork: " + SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Ventilation.DuctType + ", " + SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Ventilation.MVDetails.DuctingType;
          XFont xfont233 = xfont3;
          XSolidBrush black227 = XBrushes.Black;
          double rc1_227 = (double) SAPInput.RC1;
          xunit3 = PDFFunctions.pages[SAPInput.k].Width;
          double point233 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[SAPInput.k].Height;
          double num281 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect233 = new XRect(200.0, rc1_227, point233, num281);
          XStringFormat topLeft233 = XStringFormat.TopLeft;
          xgraphics233.DrawString(str96, xfont233, (XBrush) black227, xrect233, topLeft233);
        }
        checked { SAPInput.RC1 += 12; }
        XGraphics xgraphics234 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string str97 = "Approved Installation Scheme: " + SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Ventilation.ApprovedScheme.ToString();
        XFont xfont234 = xfont3;
        XSolidBrush black228 = XBrushes.Black;
        double rc1_228 = (double) SAPInput.RC1;
        xunit3 = PDFFunctions.pages[SAPInput.k].Width;
        double point234 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[SAPInput.k].Height;
        double num282 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect234 = new XRect(200.0, rc1_228, point234, num282);
        XStringFormat topLeft234 = XStringFormat.TopLeft;
        xgraphics234.DrawString(str97, xfont234, (XBrush) black228, xrect234, topLeft234);
        checked { SAPInput.RC1 += 12; }
      }
      XGraphics xgraphics235 = PDFFunctions.gfx[SAPInput.k];
      XFont xfont235 = xfont2;
      XSolidBrush black229 = XBrushes.Black;
      double rc1_229 = (double) SAPInput.RC1;
      xunit3 = PDFFunctions.pages[SAPInput.k].Width;
      double point235 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[SAPInput.k].Height;
      double num283 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect235 = new XRect(20.0, rc1_229, point235, num283);
      XStringFormat topLeft235 = XStringFormat.TopLeft;
      xgraphics235.DrawString("Number of chimneys:", xfont235, (XBrush) black229, xrect235, topLeft235);
      // ISSUE: reference to a compiler-generated field
      if ((uint) SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Ventilation.Chimneys > 0U)
      {
        XGraphics xgraphics236 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        string str98 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Ventilation.Chimneys) + " (main: " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Ventilation.ChimneysMain) + ", secondary: " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Ventilation.ChimneysSec) + ", other: " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Ventilation.ChimneysOther) + ")";
        XFont xfont236 = xfont3;
        XSolidBrush black230 = XBrushes.Black;
        double rc1_230 = (double) SAPInput.RC1;
        xunit3 = PDFFunctions.pages[SAPInput.k].Width;
        double point236 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[SAPInput.k].Height;
        double num284 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect236 = new XRect(200.0, rc1_230, point236, num284);
        XStringFormat topLeft236 = XStringFormat.TopLeft;
        xgraphics236.DrawString(str98, xfont236, (XBrush) black230, xrect236, topLeft236);
      }
      else
      {
        XGraphics xgraphics237 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string str99 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Ventilation.Chimneys);
        XFont xfont237 = xfont3;
        XSolidBrush black231 = XBrushes.Black;
        double rc1_231 = (double) SAPInput.RC1;
        xunit3 = PDFFunctions.pages[SAPInput.k].Width;
        double point237 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[SAPInput.k].Height;
        double num285 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect237 = new XRect(200.0, rc1_231, point237, num285);
        XStringFormat topLeft237 = XStringFormat.TopLeft;
        xgraphics237.DrawString(str99, xfont237, (XBrush) black231, xrect237, topLeft237);
      }
      checked { SAPInput.RC1 += 12; }
      SAPInput.CheckRC1();
      XGraphics xgraphics238 = PDFFunctions.gfx[SAPInput.k];
      XFont xfont238 = xfont2;
      XSolidBrush black232 = XBrushes.Black;
      double rc1_232 = (double) SAPInput.RC1;
      xunit3 = PDFFunctions.pages[SAPInput.k].Width;
      double point238 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[SAPInput.k].Height;
      double num286 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect238 = new XRect(20.0, rc1_232, point238, num286);
      XStringFormat topLeft238 = XStringFormat.TopLeft;
      xgraphics238.DrawString("Number of open flues:", xfont238, (XBrush) black232, xrect238, topLeft238);
      XGraphics xgraphics239 = PDFFunctions.gfx[SAPInput.k];
      // ISSUE: reference to a compiler-generated field
      string str100 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Ventilation.Flues);
      XFont xfont239 = xfont3;
      XSolidBrush black233 = XBrushes.Black;
      double rc1_233 = (double) SAPInput.RC1;
      xunit3 = PDFFunctions.pages[SAPInput.k].Width;
      double point239 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[SAPInput.k].Height;
      double num287 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect239 = new XRect(200.0, rc1_233, point239, num287);
      XStringFormat topLeft239 = XStringFormat.TopLeft;
      xgraphics239.DrawString(str100, xfont239, (XBrush) black233, xrect239, topLeft239);
      // ISSUE: reference to a compiler-generated field
      if ((uint) SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Ventilation.Flues > 0U)
      {
        XGraphics xgraphics240 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        string str101 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Ventilation.Flues) + " (main: " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Ventilation.FluesMain) + ", secondary: " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Ventilation.FluesSec) + ", other: " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Ventilation.FluesOther) + ")";
        XFont xfont240 = xfont3;
        XSolidBrush black234 = XBrushes.Black;
        double rc1_234 = (double) SAPInput.RC1;
        xunit3 = PDFFunctions.pages[SAPInput.k].Width;
        double point240 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[SAPInput.k].Height;
        double num288 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect240 = new XRect(200.0, rc1_234, point240, num288);
        XStringFormat topLeft240 = XStringFormat.TopLeft;
        xgraphics240.DrawString(str101, xfont240, (XBrush) black234, xrect240, topLeft240);
      }
      else
      {
        XGraphics xgraphics241 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string str102 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Ventilation.Flues);
        XFont xfont241 = xfont3;
        XSolidBrush black235 = XBrushes.Black;
        double rc1_235 = (double) SAPInput.RC1;
        xunit3 = PDFFunctions.pages[SAPInput.k].Width;
        double point241 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[SAPInput.k].Height;
        double num289 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect241 = new XRect(200.0, rc1_235, point241, num289);
        XStringFormat topLeft241 = XStringFormat.TopLeft;
        xgraphics241.DrawString(str102, xfont241, (XBrush) black235, xrect241, topLeft241);
      }
      checked { SAPInput.RC1 += 12; }
      SAPInput.CheckRC1();
      XGraphics xgraphics242 = PDFFunctions.gfx[SAPInput.k];
      XFont xfont242 = xfont2;
      XSolidBrush black236 = XBrushes.Black;
      double rc1_236 = (double) SAPInput.RC1;
      xunit3 = PDFFunctions.pages[SAPInput.k].Width;
      double point242 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[SAPInput.k].Height;
      double num290 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect242 = new XRect(20.0, rc1_236, point242, num290);
      XStringFormat topLeft242 = XStringFormat.TopLeft;
      xgraphics242.DrawString("Number of fans:", xfont242, (XBrush) black236, xrect242, topLeft242);
      XGraphics xgraphics243 = PDFFunctions.gfx[SAPInput.k];
      // ISSUE: reference to a compiler-generated field
      string str103 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Ventilation.Fans);
      XFont xfont243 = xfont3;
      XSolidBrush black237 = XBrushes.Black;
      double rc1_237 = (double) SAPInput.RC1;
      xunit3 = PDFFunctions.pages[SAPInput.k].Width;
      double point243 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[SAPInput.k].Height;
      double num291 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect243 = new XRect(200.0, rc1_237, point243, num291);
      XStringFormat topLeft243 = XStringFormat.TopLeft;
      xgraphics243.DrawString(str103, xfont243, (XBrush) black237, xrect243, topLeft243);
      checked { SAPInput.RC1 += 12; }
      SAPInput.CheckRC1();
      XGraphics xgraphics244 = PDFFunctions.gfx[SAPInput.k];
      XFont xfont244 = xfont2;
      XSolidBrush black238 = XBrushes.Black;
      double rc1_238 = (double) SAPInput.RC1;
      xunit3 = PDFFunctions.pages[SAPInput.k].Width;
      double point244 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[SAPInput.k].Height;
      double num292 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect244 = new XRect(20.0, rc1_238, point244, num292);
      XStringFormat topLeft244 = XStringFormat.TopLeft;
      xgraphics244.DrawString("Number of passive stacks:", xfont244, (XBrush) black238, xrect244, topLeft244);
      XGraphics xgraphics245 = PDFFunctions.gfx[SAPInput.k];
      // ISSUE: reference to a compiler-generated field
      string str104 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Ventilation.Vents);
      XFont xfont245 = xfont3;
      XSolidBrush black239 = XBrushes.Black;
      double rc1_239 = (double) SAPInput.RC1;
      xunit3 = PDFFunctions.pages[SAPInput.k].Width;
      double point245 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[SAPInput.k].Height;
      double num293 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect245 = new XRect(200.0, rc1_239, point245, num293);
      XStringFormat topLeft245 = XStringFormat.TopLeft;
      xgraphics245.DrawString(str104, xfont245, (XBrush) black239, xrect245, topLeft245);
      checked { SAPInput.RC1 += 12; }
      SAPInput.CheckRC1();
      XGraphics xgraphics246 = PDFFunctions.gfx[SAPInput.k];
      XFont xfont246 = xfont2;
      XSolidBrush black240 = XBrushes.Black;
      double rc1_240 = (double) SAPInput.RC1;
      xunit3 = PDFFunctions.pages[SAPInput.k].Width;
      double point246 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[SAPInput.k].Height;
      double num294 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect246 = new XRect(20.0, rc1_240, point246, num294);
      XStringFormat topLeft246 = XStringFormat.TopLeft;
      xgraphics246.DrawString("Number of sides sheltered:", xfont246, (XBrush) black240, xrect246, topLeft246);
      XGraphics xgraphics247 = PDFFunctions.gfx[SAPInput.k];
      // ISSUE: reference to a compiler-generated field
      string str105 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Ventilation.Shelter);
      XFont xfont247 = xfont3;
      XSolidBrush black241 = XBrushes.Black;
      double rc1_241 = (double) SAPInput.RC1;
      xunit3 = PDFFunctions.pages[SAPInput.k].Width;
      double point247 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[SAPInput.k].Height;
      double num295 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect247 = new XRect(200.0, rc1_241, point247, num295);
      XStringFormat topLeft247 = XStringFormat.TopLeft;
      xgraphics247.DrawString(str105, xfont247, (XBrush) black241, xrect247, topLeft247);
      checked { SAPInput.RC1 += 12; }
      SAPInput.CheckRC1();
      XGraphics xgraphics248 = PDFFunctions.gfx[SAPInput.k];
      XFont xfont248 = xfont2;
      XSolidBrush black242 = XBrushes.Black;
      double rc1_242 = (double) SAPInput.RC1;
      xunit3 = PDFFunctions.pages[SAPInput.k].Width;
      double point248 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[SAPInput.k].Height;
      double num296 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect248 = new XRect(20.0, rc1_242, point248, num296);
      XStringFormat topLeft248 = XStringFormat.TopLeft;
      xgraphics248.DrawString("Pressure test:", xfont248, (XBrush) black242, xrect248, topLeft248);
      // ISSUE: reference to a compiler-generated field
      if ((double) SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Ventilation.AssumedAir != 0.0)
      {
        XGraphics xgraphics249 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string str106 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Ventilation.AssumedAir);
        XFont xfont249 = xfont3;
        XSolidBrush black243 = XBrushes.Black;
        double rc1_243 = (double) SAPInput.RC1;
        xunit3 = PDFFunctions.pages[SAPInput.k].Width;
        double point249 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[SAPInput.k].Height;
        double num297 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect249 = new XRect(200.0, rc1_243, point249, num297);
        XStringFormat topLeft249 = XStringFormat.TopLeft;
        xgraphics249.DrawString(str106, xfont249, (XBrush) black243, xrect249, topLeft249);
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        if ((double) SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Ventilation.DesignAir != 0.0 & (double) SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Ventilation.MeasuredAir == 0.0)
        {
          XGraphics xgraphics250 = PDFFunctions.gfx[SAPInput.k];
          // ISSUE: reference to a compiler-generated field
          string str107 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Ventilation.DesignAir);
          XFont xfont250 = xfont3;
          XSolidBrush black244 = XBrushes.Black;
          double rc1_244 = (double) SAPInput.RC1;
          xunit3 = PDFFunctions.pages[SAPInput.k].Width;
          double point250 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[SAPInput.k].Height;
          double num298 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect250 = new XRect(200.0, rc1_244, point250, num298);
          XStringFormat topLeft250 = XStringFormat.TopLeft;
          xgraphics250.DrawString(str107, xfont250, (XBrush) black244, xrect250, topLeft250);
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          if ((double) SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Ventilation.MeasuredAir != 0.0)
          {
            // ISSUE: reference to a compiler-generated field
            if (SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Ventilation.AveragePerm)
            {
              XGraphics xgraphics251 = PDFFunctions.gfx[SAPInput.k];
              // ISSUE: reference to a compiler-generated field
              string str108 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Ventilation.MeasuredAir) + " (Average permeability of dwellings of that type was used)";
              XFont xfont251 = xfont3;
              XSolidBrush black245 = XBrushes.Black;
              double rc1_245 = (double) SAPInput.RC1;
              xunit3 = PDFFunctions.pages[SAPInput.k].Width;
              double point251 = ((XUnit) ref xunit3).Point;
              xunit3 = PDFFunctions.pages[SAPInput.k].Height;
              double num299 = ((XUnit) ref xunit3).Point / 2.0;
              XRect xrect251 = new XRect(200.0, rc1_245, point251, num299);
              XStringFormat topLeft251 = XStringFormat.TopLeft;
              xgraphics251.DrawString(str108, xfont251, (XBrush) black245, xrect251, topLeft251);
            }
            else
            {
              XGraphics xgraphics252 = PDFFunctions.gfx[SAPInput.k];
              // ISSUE: reference to a compiler-generated field
              string str109 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Ventilation.MeasuredAir) + " (Assessed dwelling is tested)";
              XFont xfont252 = xfont3;
              XSolidBrush black246 = XBrushes.Black;
              double rc1_246 = (double) SAPInput.RC1;
              xunit3 = PDFFunctions.pages[SAPInput.k].Width;
              double point252 = ((XUnit) ref xunit3).Point;
              xunit3 = PDFFunctions.pages[SAPInput.k].Height;
              double num300 = ((XUnit) ref xunit3).Point / 2.0;
              XRect xrect252 = new XRect(200.0, rc1_246, point252, num300);
              XStringFormat topLeft252 = XStringFormat.TopLeft;
              xgraphics252.DrawString(str109, xfont252, (XBrush) black246, xrect252, topLeft252);
            }
          }
        }
      }
      checked { SAPInput.RC1 += 14; }
      SAPInput.CheckRC1();
      PDFFunctions.xBrush1 = XBrush.op_Implicit((Brush) new SolidBrush(Color.FromArgb(159, 172, 62)));
      PDFFunctions.Points[0].X = 20f;
      PDFFunctions.Points[0].Y = (float) SAPInput.RC1;
      ref PointF local13 = ref PDFFunctions.Points[1];
      xunit3 = PDFFunctions.pages[SAPInput.k].Width;
      double num301 = ((XUnit) ref xunit3).Point - 20.0;
      local13.X = (float) num301;
      PDFFunctions.Points[1].Y = (float) SAPInput.RC1;
      ref PointF local14 = ref PDFFunctions.Points[2];
      xunit3 = PDFFunctions.pages[SAPInput.k].Width;
      double num302 = ((XUnit) ref xunit3).Point - 20.0;
      local14.X = (float) num302;
      PDFFunctions.Points[2].Y = (float) checked (SAPInput.RC1 + 14);
      PDFFunctions.Points[3].X = 20f;
      PDFFunctions.Points[3].Y = (float) checked (SAPInput.RC1 + 14);
      PDFFunctions.gfx[SAPInput.k].DrawPolygon(PDFFunctions.polyGreen2, PDFFunctions.xBrush1, PDFFunctions.Points, xfillMode);
      XGraphics xgraphics253 = PDFFunctions.gfx[SAPInput.k];
      XFont xfont253 = xfont3;
      XSolidBrush white7 = XBrushes.White;
      double num303 = (double) checked (SAPInput.RC1 + 1);
      xunit3 = PDFFunctions.pages[SAPInput.k].Width;
      double point253 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[SAPInput.k].Height;
      double num304 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect253 = new XRect(25.0, num303, point253, num304);
      XStringFormat topLeft253 = XStringFormat.TopLeft;
      xgraphics253.DrawString("Main heating system:", xfont253, (XBrush) white7, xrect253, topLeft253);
      SAPInput.RC1 = checked ((int) Math.Round(unchecked ((double) PDFFunctions.Points[3].Y + 4.0)));
      SAPInput.CheckRC1();
      XGraphics xgraphics254 = PDFFunctions.gfx[SAPInput.k];
      XFont xfont254 = xfont2;
      XSolidBrush black247 = XBrushes.Black;
      double rc1_247 = (double) SAPInput.RC1;
      xunit3 = PDFFunctions.pages[SAPInput.k].Width;
      double point254 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[SAPInput.k].Height;
      double num305 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect254 = new XRect(20.0, rc1_247, point254, num305);
      XStringFormat topLeft254 = XStringFormat.TopLeft;
      xgraphics254.DrawString("Main heating system: ", xfont254, (XBrush) black247, xrect254, topLeft254);
      XGraphics xgraphics255 = PDFFunctions.gfx[SAPInput.k];
      // ISSUE: reference to a compiler-generated field
      string hgroup1 = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.HGroup;
      XFont xfont255 = xfont3;
      XSolidBrush black248 = XBrushes.Black;
      double rc1_248 = (double) SAPInput.RC1;
      xunit3 = PDFFunctions.pages[SAPInput.k].Width;
      double point255 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[SAPInput.k].Height;
      double num306 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect255 = new XRect(200.0, rc1_248, point255, num306);
      XStringFormat topLeft255 = XStringFormat.TopLeft;
      xgraphics255.DrawString(hgroup1, xfont255, (XBrush) black248, xrect255, topLeft255);
      checked { SAPInput.RC1 += 12; }
      // ISSUE: reference to a compiler-generated field
      if ((uint) Operators.CompareString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.HGroup, "Community heating schemes", false) > 0U)
      {
        XGraphics xgraphics256 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string sgroup = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.SGroup;
        XFont xfont256 = xfont3;
        XSolidBrush black249 = XBrushes.Black;
        double rc1_249 = (double) SAPInput.RC1;
        xunit3 = PDFFunctions.pages[SAPInput.k].Width;
        double point256 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[SAPInput.k].Height;
        double num307 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect256 = new XRect(200.0, rc1_249, point256, num307);
        XStringFormat topLeft256 = XStringFormat.TopLeft;
        xgraphics256.DrawString(sgroup, xfont256, (XBrush) black249, xrect256, topLeft256);
        checked { SAPInput.RC1 += 12; }
        XGraphics xgraphics257 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string str110 = "Fuel: " + SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.Fuel;
        XFont xfont257 = xfont3;
        XSolidBrush black250 = XBrushes.Black;
        double rc1_250 = (double) SAPInput.RC1;
        xunit3 = PDFFunctions.pages[SAPInput.k].Width;
        double point257 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[SAPInput.k].Height;
        double num308 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect257 = new XRect(200.0, rc1_250, point257, num308);
        XStringFormat topLeft257 = XStringFormat.TopLeft;
        xgraphics257.DrawString(str110, xfont257, (XBrush) black250, xrect257, topLeft257);
        checked { SAPInput.RC1 += 12; }
        XGraphics xgraphics258 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string str111 = "Info Source: " + SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.InforSource;
        XFont xfont258 = xfont3;
        XSolidBrush black251 = XBrushes.Black;
        double rc1_251 = (double) SAPInput.RC1;
        xunit3 = PDFFunctions.pages[SAPInput.k].Width;
        double point258 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[SAPInput.k].Height;
        double num309 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect258 = new XRect(200.0, rc1_251, point258, num309);
        XStringFormat topLeft258 = XStringFormat.TopLeft;
        xgraphics258.DrawString(str111, xfont258, (XBrush) black251, xrect258, topLeft258);
        checked { SAPInput.RC1 += 12; }
        SAPInput.CheckRC1();
        // ISSUE: reference to a compiler-generated field
        if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.InforSource, "Boiler Database", false) == 0)
        {
          string str112 = "";
          string str113 = "";
          string str114 = "";
          string Left1 = "";
          string Left2 = "";
          string Left3 = "";
          string summerEff;
          string winterEff;
          string Left4;
          // ISSUE: reference to a compiler-generated field
          if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.SGroup, "Gas boilers and oil boilers", false) == 0)
          {
            // ISSUE: reference to a compiler-generated method
            PCDF.SEDBUK sedbuk = SAP_Module.PCDFData.Boilers.Where<PCDF.SEDBUK>(new Func<PCDF.SEDBUK, bool>(closure160_2._Lambda\u0024__3)).SingleOrDefault<PCDF.SEDBUK>();
            if (sedbuk != null)
            {
              str112 = sedbuk.BrandName;
              str114 = sedbuk.ModelName;
              str113 = sedbuk.ModelQualifier;
              summerEff = sedbuk.SummerEff;
              winterEff = sedbuk.WinterEff;
              Left2 = sedbuk.ProductType;
              double num310 = Conversion.Val(sedbuk.MainType);
              if (num310 == 0.0)
                Left1 = "Unknown";
              else if (num310 == 1.0)
                Left1 = "Regular";
              else if (num310 == 2.0)
                Left1 = "Combi";
              else if (num310 == 3.0)
                Left1 = "CPSU";
              try
              {
                if (Operators.CompareString(sedbuk.SubType, "1", false) == 0)
                  Left3 = "Has integral PFGHRD  " + sedbuk.SubTypeIndex;
              }
              catch (Exception ex)
              {
                int lErl = num30;
                ProjectData.SetProjectError(ex, lErl);
                ProjectData.ClearProjectError();
              }
            }
          }
          else
          {
            // ISSUE: reference to a compiler-generated field
            if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.SGroup, "Micro-cogeneration (micro-CHP)", false) == 0)
            {
              // ISSUE: reference to a compiler-generated method
              PCDF.CHP chp = SAP_Module.PCDFData.CHPs.Where<PCDF.CHP>(new Func<PCDF.CHP, bool>(closure160_2._Lambda\u0024__4)).SingleOrDefault<PCDF.CHP>();
              if (chp != null)
              {
                str112 = chp.Brand;
                str114 = chp.Model;
                str113 = chp.Qualifier;
                Left2 = chp.ProductType;
              }
            }
            else
            {
              // ISSUE: reference to a compiler-generated field
              if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.SGroup, "Solid fuel boilers", false) == 0)
              {
                // ISSUE: reference to a compiler-generated method
                PCDF.SEDBUK_Solid sedbukSolid = SAP_Module.PCDFData.Solid_Boilers.Where<PCDF.SEDBUK_Solid>(new Func<PCDF.SEDBUK_Solid, bool>(closure160_2._Lambda\u0024__5)).SingleOrDefault<PCDF.SEDBUK_Solid>();
                if (sedbukSolid != null)
                {
                  str112 = sedbukSolid.BrandName;
                  str114 = sedbukSolid.ModelName;
                  str113 = sedbukSolid.ModelQualifier;
                  Left2 = sedbukSolid.ProductType;
                  double num311 = Conversion.Val(sedbukSolid.MainType);
                  if (num311 == 0.0)
                    Left1 = "Unknown";
                  else if (num311 == 1.0)
                    Left1 = "Regular";
                  else if (num311 == 2.0)
                    Left1 = "Combi";
                  else if (num311 == 3.0)
                    Left1 = "CPSU";
                  Left4 = Conversions.ToString(Math.Round(SAP_Module.Calculation2012.Calculation.Energy_Requirements_9a.Box206));
                }
              }
              else
              {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.SGroup, "Gas-fired heat pumps", false) == 0 | Operators.CompareString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.SGroup, "Electric heat pumps", false) == 0)
                {
                  // ISSUE: reference to a compiler-generated method
                  PCDF.HeatPump heatPump = SAP_Module.PCDFData.HeatPumps.Where<PCDF.HeatPump>(new Func<PCDF.HeatPump, bool>(closure160_2._Lambda\u0024__6)).SingleOrDefault<PCDF.HeatPump>();
                  if (heatPump != null)
                  {
                    str112 = heatPump.Brand;
                    str114 = heatPump.Model;
                    str113 = heatPump.Qualifier;
                    Left2 = heatPump.PropertyType;
                    Left4 = Conversions.ToString(Math.Round(SAP_Module.Calculation2012.Calculation.Energy_Requirements_9a.Box206));
                  }
                }
              }
            }
          }
          // ISSUE: reference to a compiler-generated field
          if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.SGroup, "Micro-cogeneration (micro-CHP)", false) == 0)
          {
            XGraphics xgraphics259 = PDFFunctions.gfx[SAPInput.k];
            // ISSUE: reference to a compiler-generated field
            string str115 = "Database: (rev " + Conversions.ToString(SAP_Module.DataBVersion) + ", product index " + SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.SEDBUK + "):";
            XFont xfont259 = xfont3;
            XSolidBrush black252 = XBrushes.Black;
            double rc1_252 = (double) SAPInput.RC1;
            xunit3 = PDFFunctions.pages[SAPInput.k].Width;
            double point259 = ((XUnit) ref xunit3).Point;
            xunit3 = PDFFunctions.pages[SAPInput.k].Height;
            double num312 = ((XUnit) ref xunit3).Point / 2.0;
            XRect xrect259 = new XRect(200.0, rc1_252, point259, num312);
            XStringFormat topLeft259 = XStringFormat.TopLeft;
            xgraphics259.DrawString(str115, xfont259, (XBrush) black252, xrect259, topLeft259);
          }
          else
          {
            if (Operators.CompareString(Left4, (string) null, false) == 0)
              Left4 = "";
            // ISSUE: reference to a compiler-generated field
            if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.SGroup, "Gas boilers and oil boilers", false) == 0)
            {
              XGraphics xgraphics260 = PDFFunctions.gfx[SAPInput.k];
              // ISSUE: reference to a compiler-generated field
              string str116 = "Database: (rev " + Conversions.ToString(SAP_Module.DataBVersion) + ", product index " + SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.SEDBUK + ") Efficiency: Winter  " + summerEff + " %  Summer: " + winterEff;
              XFont xfont260 = xfont3;
              XSolidBrush black253 = XBrushes.Black;
              double rc1_253 = (double) SAPInput.RC1;
              xunit3 = PDFFunctions.pages[SAPInput.k].Width;
              double point260 = ((XUnit) ref xunit3).Point;
              xunit3 = PDFFunctions.pages[SAPInput.k].Height;
              double num313 = ((XUnit) ref xunit3).Point / 2.0;
              XRect xrect260 = new XRect(200.0, rc1_253, point260, num313);
              XStringFormat topLeft260 = XStringFormat.TopLeft;
              xgraphics260.DrawString(str116, xfont260, (XBrush) black253, xrect260, topLeft260);
              if ((uint) Operators.CompareString(Left3, "", false) > 0U)
              {
                checked { SAPInput.RC1 += 12; }
                XGraphics xgraphics261 = PDFFunctions.gfx[SAPInput.k];
                string str117 = Left3;
                XFont xfont261 = xfont3;
                XSolidBrush black254 = XBrushes.Black;
                double rc1_254 = (double) SAPInput.RC1;
                xunit3 = PDFFunctions.pages[SAPInput.k].Width;
                double point261 = ((XUnit) ref xunit3).Point;
                xunit3 = PDFFunctions.pages[SAPInput.k].Height;
                double num314 = ((XUnit) ref xunit3).Point / 2.0;
                XRect xrect261 = new XRect(200.0, rc1_254, point261, num314);
                XStringFormat topLeft261 = XStringFormat.TopLeft;
                xgraphics261.DrawString(str117, xfont261, (XBrush) black254, xrect261, topLeft261);
              }
            }
            else
            {
              XGraphics xgraphics262 = PDFFunctions.gfx[SAPInput.k];
              // ISSUE: reference to a compiler-generated field
              string str118 = "Database: (rev " + Conversions.ToString(SAP_Module.DataBVersion) + ", product index " + SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.SEDBUK + ", SEDBUK " + Left4 + "%):";
              XFont xfont262 = xfont3;
              XSolidBrush black255 = XBrushes.Black;
              double rc1_255 = (double) SAPInput.RC1;
              xunit3 = PDFFunctions.pages[SAPInput.k].Width;
              double point262 = ((XUnit) ref xunit3).Point;
              xunit3 = PDFFunctions.pages[SAPInput.k].Height;
              double num315 = ((XUnit) ref xunit3).Point / 2.0;
              XRect xrect262 = new XRect(200.0, rc1_255, point262, num315);
              XStringFormat topLeft262 = XStringFormat.TopLeft;
              xgraphics262.DrawString(str118, xfont262, (XBrush) black255, xrect262, topLeft262);
            }
          }
          checked { SAPInput.RC1 += 12; }
          XGraphics xgraphics263 = PDFFunctions.gfx[SAPInput.k];
          string str119 = "Brand name: " + str112;
          XFont xfont263 = xfont3;
          XSolidBrush black256 = XBrushes.Black;
          double rc1_256 = (double) SAPInput.RC1;
          xunit3 = PDFFunctions.pages[SAPInput.k].Width;
          double point263 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[SAPInput.k].Height;
          double num316 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect263 = new XRect(200.0, rc1_256, point263, num316);
          XStringFormat topLeft263 = XStringFormat.TopLeft;
          xgraphics263.DrawString(str119, xfont263, (XBrush) black256, xrect263, topLeft263);
          checked { SAPInput.RC1 += 12; }
          if (Operators.CompareString(Left2, "2", false) == 0)
          {
            XGraphics xgraphics264 = PDFFunctions.gfx[SAPInput.k];
            string str120 = "Model: " + str114 + " (Under Investigation)";
            XFont xfont264 = xfont3;
            XSolidBrush black257 = XBrushes.Black;
            double rc1_257 = (double) SAPInput.RC1;
            xunit3 = PDFFunctions.pages[SAPInput.k].Width;
            double point264 = ((XUnit) ref xunit3).Point;
            xunit3 = PDFFunctions.pages[SAPInput.k].Height;
            double num317 = ((XUnit) ref xunit3).Point / 2.0;
            XRect xrect264 = new XRect(200.0, rc1_257, point264, num317);
            XStringFormat topLeft264 = XStringFormat.TopLeft;
            xgraphics264.DrawString(str120, xfont264, (XBrush) black257, xrect264, topLeft264);
          }
          else if (Operators.CompareString(Left2, "4", false) == 0)
          {
            XGraphics xgraphics265 = PDFFunctions.gfx[SAPInput.k];
            string str121 = "Model: " + str114 + " (Methodology under review)";
            XFont xfont265 = xfont3;
            XSolidBrush black258 = XBrushes.Black;
            double rc1_258 = (double) SAPInput.RC1;
            xunit3 = PDFFunctions.pages[SAPInput.k].Width;
            double point265 = ((XUnit) ref xunit3).Point;
            xunit3 = PDFFunctions.pages[SAPInput.k].Height;
            double num318 = ((XUnit) ref xunit3).Point / 2.0;
            XRect xrect265 = new XRect(200.0, rc1_258, point265, num318);
            XStringFormat topLeft265 = XStringFormat.TopLeft;
            xgraphics265.DrawString(str121, xfont265, (XBrush) black258, xrect265, topLeft265);
          }
          else
          {
            XGraphics xgraphics266 = PDFFunctions.gfx[SAPInput.k];
            string str122 = "Model: " + str114;
            XFont xfont266 = xfont3;
            XSolidBrush black259 = XBrushes.Black;
            double rc1_259 = (double) SAPInput.RC1;
            xunit3 = PDFFunctions.pages[SAPInput.k].Width;
            double point266 = ((XUnit) ref xunit3).Point;
            xunit3 = PDFFunctions.pages[SAPInput.k].Height;
            double num319 = ((XUnit) ref xunit3).Point / 2.0;
            XRect xrect266 = new XRect(200.0, rc1_259, point266, num319);
            XStringFormat topLeft266 = XStringFormat.TopLeft;
            xgraphics266.DrawString(str122, xfont266, (XBrush) black259, xrect266, topLeft266);
          }
          checked { SAPInput.RC1 += 12; }
          XGraphics xgraphics267 = PDFFunctions.gfx[SAPInput.k];
          string str123 = "Model qualifier: " + str113;
          XFont xfont267 = xfont3;
          XSolidBrush black260 = XBrushes.Black;
          double rc1_260 = (double) SAPInput.RC1;
          xunit3 = PDFFunctions.pages[SAPInput.k].Width;
          double point267 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[SAPInput.k].Height;
          double num320 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect267 = new XRect(200.0, rc1_260, point267, num320);
          XStringFormat topLeft267 = XStringFormat.TopLeft;
          xgraphics267.DrawString(str123, xfont267, (XBrush) black260, xrect267, topLeft267);
          checked { SAPInput.RC1 += 12; }
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.SGroup, "Micro-cogeneration (micro-CHP)", false) == 0 | Operators.CompareString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.SGroup, "Gas-fired heat pumps", false) == 0 | Operators.CompareString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.SGroup, "Electric heat pumps", false) == 0)
          {
            XGraphics xgraphics268 = PDFFunctions.gfx[SAPInput.k];
            XFont xfont268 = xfont3;
            XSolidBrush black261 = XBrushes.Black;
            double rc1_261 = (double) SAPInput.RC1;
            xunit3 = PDFFunctions.pages[SAPInput.k].Width;
            double point268 = ((XUnit) ref xunit3).Point;
            xunit3 = PDFFunctions.pages[SAPInput.k].Height;
            double num321 = ((XUnit) ref xunit3).Point / 2.0;
            XRect xrect268 = new XRect(200.0, rc1_261, point268, num321);
            XStringFormat topLeft268 = XStringFormat.TopLeft;
            xgraphics268.DrawString("(provides DHW all year)", xfont268, (XBrush) black261, xrect268, topLeft268);
          }
          else
          {
            // ISSUE: reference to a compiler-generated field
            if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.SGroup, "Gas boilers and oil boilers", false) == 0 & Operators.CompareString(Left1, "Combi", false) == 0)
            {
              // ISSUE: reference to a compiler-generated method
              string strType = SAP_Module.PCDFData.Boilers.Where<PCDF.SEDBUK>(new Func<PCDF.SEDBUK, bool>(closure160_2._Lambda\u0024__7)).SingleOrDefault<PCDF.SEDBUK>().StrType;
              if (Operators.CompareString(strType, "0", false) != 0 && Operators.CompareString(strType, "", false) != 0 && Operators.CompareString(strType, "3", false) != 0)
              {
                if (Operators.CompareString(strType, "1", false) != 0)
                {
                  if (Operators.CompareString(strType, "2", false) == 0)
                  {
                    XGraphics xgraphics269 = PDFFunctions.gfx[SAPInput.k];
                    string str124 = "(" + Left1 + " boiler with secondary store)";
                    XFont xfont269 = xfont3;
                    XSolidBrush black262 = XBrushes.Black;
                    double rc1_262 = (double) SAPInput.RC1;
                    xunit3 = PDFFunctions.pages[SAPInput.k].Width;
                    double point269 = ((XUnit) ref xunit3).Point;
                    xunit3 = PDFFunctions.pages[SAPInput.k].Height;
                    double num322 = ((XUnit) ref xunit3).Point / 2.0;
                    XRect xrect269 = new XRect(200.0, rc1_262, point269, num322);
                    XStringFormat topLeft269 = XStringFormat.TopLeft;
                    xgraphics269.DrawString(str124, xfont269, (XBrush) black262, xrect269, topLeft269);
                  }
                }
                else
                {
                  XGraphics xgraphics270 = PDFFunctions.gfx[SAPInput.k];
                  string str125 = "(" + Left1 + " boiler with primary store)";
                  XFont xfont270 = xfont3;
                  XSolidBrush black263 = XBrushes.Black;
                  double rc1_263 = (double) SAPInput.RC1;
                  xunit3 = PDFFunctions.pages[SAPInput.k].Width;
                  double point270 = ((XUnit) ref xunit3).Point;
                  xunit3 = PDFFunctions.pages[SAPInput.k].Height;
                  double num323 = ((XUnit) ref xunit3).Point / 2.0;
                  XRect xrect270 = new XRect(200.0, rc1_263, point270, num323);
                  XStringFormat topLeft270 = XStringFormat.TopLeft;
                  xgraphics270.DrawString(str125, xfont270, (XBrush) black263, xrect270, topLeft270);
                }
              }
              else
              {
                XGraphics xgraphics271 = PDFFunctions.gfx[SAPInput.k];
                string str126 = "(" + Left1 + " boiler)";
                XFont xfont271 = xfont3;
                XSolidBrush black264 = XBrushes.Black;
                double rc1_264 = (double) SAPInput.RC1;
                xunit3 = PDFFunctions.pages[SAPInput.k].Width;
                double point271 = ((XUnit) ref xunit3).Point;
                xunit3 = PDFFunctions.pages[SAPInput.k].Height;
                double num324 = ((XUnit) ref xunit3).Point / 2.0;
                XRect xrect271 = new XRect(200.0, rc1_264, point271, num324);
                XStringFormat topLeft271 = XStringFormat.TopLeft;
                xgraphics271.DrawString(str126, xfont271, (XBrush) black264, xrect271, topLeft271);
              }
            }
            else
            {
              XGraphics xgraphics272 = PDFFunctions.gfx[SAPInput.k];
              string str127 = "(" + Left1 + " boiler)";
              XFont xfont272 = xfont3;
              XSolidBrush black265 = XBrushes.Black;
              double rc1_265 = (double) SAPInput.RC1;
              xunit3 = PDFFunctions.pages[SAPInput.k].Width;
              double point272 = ((XUnit) ref xunit3).Point;
              xunit3 = PDFFunctions.pages[SAPInput.k].Height;
              double num325 = ((XUnit) ref xunit3).Point / 2.0;
              XRect xrect272 = new XRect(200.0, rc1_265, point272, num325);
              XStringFormat topLeft272 = XStringFormat.TopLeft;
              xgraphics272.DrawString(str127, xfont272, (XBrush) black265, xrect272, topLeft272);
            }
          }
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.InforSource, "Manufacturer Declaration", false) == 0)
          {
            XGraphics xgraphics273 = PDFFunctions.gfx[SAPInput.k];
            XFont xfont273 = xfont3;
            XSolidBrush black266 = XBrushes.Black;
            double rc1_266 = (double) SAPInput.RC1;
            xunit3 = PDFFunctions.pages[SAPInput.k].Width;
            double point273 = ((XUnit) ref xunit3).Point;
            xunit3 = PDFFunctions.pages[SAPInput.k].Height;
            double num326 = ((XUnit) ref xunit3).Point / 2.0;
            XRect xrect273 = new XRect(200.0, rc1_266, point273, num326);
            XStringFormat topLeft273 = XStringFormat.TopLeft;
            xgraphics273.DrawString("Manufacturer's data", xfont273, (XBrush) black266, xrect273, topLeft273);
            checked { SAPInput.RC1 += 12; }
            // ISSUE: reference to a compiler-generated field
            if (SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.SAPTableCode < 142)
            {
              // ISSUE: reference to a compiler-generated field
              if (SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.SEDBUK2005)
              {
                XGraphics xgraphics274 = PDFFunctions.gfx[SAPInput.k];
                // ISSUE: reference to a compiler-generated field
                string str128 = "Efficiency: " + Microsoft.VisualBasic.Strings.Format((object) SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.MainEff, "#0.0") + "% (SEDBUK2005)";
                XFont xfont274 = xfont3;
                XSolidBrush black267 = XBrushes.Black;
                double rc1_267 = (double) SAPInput.RC1;
                xunit3 = PDFFunctions.pages[SAPInput.k].Width;
                double point274 = ((XUnit) ref xunit3).Point;
                xunit3 = PDFFunctions.pages[SAPInput.k].Height;
                double num327 = ((XUnit) ref xunit3).Point / 2.0;
                XRect xrect274 = new XRect(200.0, rc1_267, point274, num327);
                XStringFormat topLeft274 = XStringFormat.TopLeft;
                xgraphics274.DrawString(str128, xfont274, (XBrush) black267, xrect274, topLeft274);
              }
              else
              {
                XGraphics xgraphics275 = PDFFunctions.gfx[SAPInput.k];
                // ISSUE: reference to a compiler-generated field
                string str129 = "Efficiency: " + Microsoft.VisualBasic.Strings.Format((object) SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.MainEff, "#0.0") + "% (SEDBUK2009)";
                XFont xfont275 = xfont3;
                XSolidBrush black268 = XBrushes.Black;
                double rc1_268 = (double) SAPInput.RC1;
                xunit3 = PDFFunctions.pages[SAPInput.k].Width;
                double point275 = ((XUnit) ref xunit3).Point;
                xunit3 = PDFFunctions.pages[SAPInput.k].Height;
                double num328 = ((XUnit) ref xunit3).Point / 2.0;
                XRect xrect275 = new XRect(200.0, rc1_268, point275, num328);
                XStringFormat topLeft275 = XStringFormat.TopLeft;
                xgraphics275.DrawString(str129, xfont275, (XBrush) black268, xrect275, topLeft275);
              }
            }
            else
            {
              XGraphics xgraphics276 = PDFFunctions.gfx[SAPInput.k];
              // ISSUE: reference to a compiler-generated field
              string str130 = "Efficiency: " + Microsoft.VisualBasic.Strings.Format((object) SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.MainEff, "#0.0") + "%";
              XFont xfont276 = xfont3;
              XSolidBrush black269 = XBrushes.Black;
              double rc1_269 = (double) SAPInput.RC1;
              xunit3 = PDFFunctions.pages[SAPInput.k].Width;
              double point276 = ((XUnit) ref xunit3).Point;
              xunit3 = PDFFunctions.pages[SAPInput.k].Height;
              double num329 = ((XUnit) ref xunit3).Point / 2.0;
              XRect xrect276 = new XRect(200.0, rc1_269, point276, num329);
              XStringFormat topLeft276 = XStringFormat.TopLeft;
              xgraphics276.DrawString(str130, xfont276, (XBrush) black269, xrect276, topLeft276);
            }
            checked { SAPInput.RC1 += 12; }
            XGraphics xgraphics277 = PDFFunctions.gfx[SAPInput.k];
            // ISSUE: reference to a compiler-generated field
            string mhType = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.MHType;
            XFont xfont277 = xfont3;
            XSolidBrush black270 = XBrushes.Black;
            double rc1_270 = (double) SAPInput.RC1;
            xunit3 = PDFFunctions.pages[SAPInput.k].Width;
            double point277 = ((XUnit) ref xunit3).Point;
            xunit3 = PDFFunctions.pages[SAPInput.k].Height;
            double num330 = ((XUnit) ref xunit3).Point / 2.0;
            XRect xrect277 = new XRect(200.0, rc1_270, point277, num330);
            XStringFormat topLeft277 = XStringFormat.TopLeft;
            xgraphics277.DrawString(mhType, xfont277, (XBrush) black270, xrect277, topLeft277);
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.Fuel, "mains gas", false) == 0 | SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.Fuel.Contains("LPG") && Operators.CompareString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.SGroup, "Gas boilers and oil boilers", false) == 0)
            {
              checked { SAPInput.RC1 += 12; }
              XGraphics xgraphics278 = PDFFunctions.gfx[SAPInput.k];
              // ISSUE: reference to a compiler-generated field
              string str131 = "Fuel Burning Type: " + SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.FuelBurningType;
              XFont xfont278 = xfont3;
              XSolidBrush black271 = XBrushes.Black;
              double rc1_271 = (double) SAPInput.RC1;
              xunit3 = PDFFunctions.pages[SAPInput.k].Width;
              double point278 = ((XUnit) ref xunit3).Point;
              xunit3 = PDFFunctions.pages[SAPInput.k].Height;
              double num331 = ((XUnit) ref xunit3).Point / 2.0;
              XRect xrect278 = new XRect(200.0, rc1_271, point278, num331);
              XStringFormat topLeft278 = XStringFormat.TopLeft;
              xgraphics278.DrawString(str131, xfont278, (XBrush) black271, xrect278, topLeft278);
            }
          }
          else
          {
            XGraphics xgraphics279 = PDFFunctions.gfx[SAPInput.k];
            // ISSUE: reference to a compiler-generated field
            string str132 = "SAP Table: " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.SAPTableCode);
            XFont xfont279 = xfont3;
            XSolidBrush black272 = XBrushes.Black;
            double rc1_272 = (double) SAPInput.RC1;
            xunit3 = PDFFunctions.pages[SAPInput.k].Width;
            double point279 = ((XUnit) ref xunit3).Point;
            xunit3 = PDFFunctions.pages[SAPInput.k].Height;
            double num332 = ((XUnit) ref xunit3).Point / 2.0;
            XRect xrect279 = new XRect(200.0, rc1_272, point279, num332);
            XStringFormat topLeft279 = XStringFormat.TopLeft;
            xgraphics279.DrawString(str132, xfont279, (XBrush) black272, xrect279, topLeft279);
            checked { SAPInput.RC1 += 12; }
            XGraphics xgraphics280 = PDFFunctions.gfx[SAPInput.k];
            // ISSUE: reference to a compiler-generated field
            string mhType = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.MHType;
            XFont xfont280 = xfont3;
            XSolidBrush black273 = XBrushes.Black;
            double rc1_273 = (double) SAPInput.RC1;
            xunit3 = PDFFunctions.pages[SAPInput.k].Width;
            double point280 = ((XUnit) ref xunit3).Point;
            xunit3 = PDFFunctions.pages[SAPInput.k].Height;
            double num333 = ((XUnit) ref xunit3).Point / 2.0;
            XRect xrect280 = new XRect(200.0, rc1_273, point280, num333);
            XStringFormat topLeft280 = XStringFormat.TopLeft;
            xgraphics280.DrawString(mhType, xfont280, (XBrush) black273, xrect280, topLeft280);
          }
        }
        checked { SAPInput.RC1 += 12; }
        XGraphics xgraphics281 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string emitter = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.Emitter;
        XFont xfont281 = xfont3;
        XSolidBrush black274 = XBrushes.Black;
        double rc1_274 = (double) SAPInput.RC1;
        xunit3 = PDFFunctions.pages[SAPInput.k].Width;
        double point281 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[SAPInput.k].Height;
        double num334 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect281 = new XRect(200.0, rc1_274, point281, num334);
        XStringFormat topLeft281 = XStringFormat.TopLeft;
        xgraphics281.DrawString(emitter, xfont281, (XBrush) black274, xrect281, topLeft281);
        SAPInput.CheckRC1();
        // ISSUE: reference to a compiler-generated field
        if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.HGroup, "Central heating systems with radiators or underfloor heating", false) == 0)
        {
          checked { SAPInput.RC1 += 12; }
          XGraphics xgraphics282 = PDFFunctions.gfx[SAPInput.k];
          // ISSUE: reference to a compiler-generated field
          string str133 = "Pump in heat space: " + SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.Boiler.PumpHP;
          XFont xfont282 = xfont3;
          XSolidBrush black275 = XBrushes.Black;
          double rc1_275 = (double) SAPInput.RC1;
          xunit3 = PDFFunctions.pages[SAPInput.k].Width;
          double point282 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[SAPInput.k].Height;
          double num335 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect282 = new XRect(200.0, rc1_275, point282, num335);
          XStringFormat topLeft282 = XStringFormat.TopLeft;
          xgraphics282.DrawString(str133, xfont282, (XBrush) black275, xrect282, topLeft282);
        }
      }
      else
      {
        List<PCDF.CommunityScheme_Sub> communitySchemeSubList = new List<PCDF.CommunityScheme_Sub>();
        // ISSUE: reference to a compiler-generated field
        if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.InforSource, "Boiler Database", false) == 0)
        {
          // ISSUE: reference to a compiler-generated field
          if ((uint) Operators.CompareString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.SEDBUK, "", false) > 0U)
          {
            // ISSUE: reference to a compiler-generated method
            communitySchemeSubList = SAP_Module.PCDFData.CommunitySchemes_Sub.Where<PCDF.CommunityScheme_Sub>(new Func<PCDF.CommunityScheme_Sub, bool>(closure160_2._Lambda\u0024__8)).ToList<PCDF.CommunityScheme_Sub>();
          }
          if (communitySchemeSubList.Count > 0)
          {
            XGraphics xgraphics283 = PDFFunctions.gfx[SAPInput.k];
            // ISSUE: reference to a compiler-generated field
            string str134 = "Database ( community network index " + SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.SEDBUK + "):";
            XFont xfont283 = xfont3;
            XSolidBrush black276 = XBrushes.Black;
            double rc1_276 = (double) SAPInput.RC1;
            xunit3 = PDFFunctions.pages[SAPInput.k].Width;
            double point283 = ((XUnit) ref xunit3).Point;
            xunit3 = PDFFunctions.pages[SAPInput.k].Height;
            double num336 = ((XUnit) ref xunit3).Point / 2.0;
            XRect xrect283 = new XRect(200.0, rc1_276, point283, num336);
            XStringFormat topLeft283 = XStringFormat.TopLeft;
            xgraphics283.DrawString(str134, xfont283, (XBrush) black276, xrect283, topLeft283);
            checked { SAPInput.RC1 += 12; }
            SAPInput.CheckRC1();
            // ISSUE: reference to a compiler-generated method
            PCDF.CommunityScheme communityScheme = SAP_Module.PCDFData.CommunitySchemes.Where<PCDF.CommunityScheme>(new Func<PCDF.CommunityScheme, bool>(closure160_2._Lambda\u0024__9)).SingleOrDefault<PCDF.CommunityScheme>();
            if (communityScheme != null)
            {
              XGraphics xgraphics284 = PDFFunctions.gfx[SAPInput.k];
              string str135 = "Brand name: " + communityScheme.CommunityHeatNetwork;
              XFont xfont284 = xfont3;
              XSolidBrush black277 = XBrushes.Black;
              double rc1_277 = (double) SAPInput.RC1;
              xunit3 = PDFFunctions.pages[SAPInput.k].Width;
              double point284 = ((XUnit) ref xunit3).Point;
              xunit3 = PDFFunctions.pages[SAPInput.k].Height;
              double num337 = ((XUnit) ref xunit3).Point / 2.0;
              XRect xrect284 = new XRect(200.0, rc1_277, point284, num337);
              XStringFormat topLeft284 = XStringFormat.TopLeft;
              xgraphics284.DrawString(str135, xfont284, (XBrush) black277, xrect284, topLeft284);
              checked { SAPInput.RC1 += 12; }
              XGraphics xgraphics285 = PDFFunctions.gfx[SAPInput.k];
              string str136 = "Postcode: " + communityScheme.PostcodeEnergyCentre;
              XFont xfont285 = xfont3;
              XSolidBrush black278 = XBrushes.Black;
              double rc1_278 = (double) SAPInput.RC1;
              xunit3 = PDFFunctions.pages[SAPInput.k].Width;
              double point285 = ((XUnit) ref xunit3).Point;
              xunit3 = PDFFunctions.pages[SAPInput.k].Height;
              double num338 = ((XUnit) ref xunit3).Point / 2.0;
              XRect xrect285 = new XRect(200.0, rc1_278, point285, num338);
              XStringFormat topLeft285 = XStringFormat.TopLeft;
              xgraphics285.DrawString(str136, xfont285, (XBrush) black278, xrect285, topLeft285);
              checked { SAPInput.RC1 += 12; }
              XGraphics xgraphics286 = PDFFunctions.gfx[SAPInput.k];
              string str137 = "Network Version: " + communityScheme.HeatNetworkVersion;
              XFont xfont286 = xfont3;
              XSolidBrush black279 = XBrushes.Black;
              double rc1_279 = (double) SAPInput.RC1;
              xunit3 = PDFFunctions.pages[SAPInput.k].Width;
              double point286 = ((XUnit) ref xunit3).Point;
              xunit3 = PDFFunctions.pages[SAPInput.k].Height;
              double num339 = ((XUnit) ref xunit3).Point / 2.0;
              XRect xrect286 = new XRect(200.0, rc1_279, point286, num339);
              XStringFormat topLeft286 = XStringFormat.TopLeft;
              xgraphics286.DrawString(str137, xfont286, (XBrush) black279, xrect286, topLeft286);
              checked { SAPInput.RC1 += 12; }
              string serviceProvision = communityScheme.ServiceProvision;
              string str138 = Operators.CompareString(serviceProvision, Conversions.ToString(3), false) != 0 ? (Operators.CompareString(serviceProvision, Conversions.ToString(1), false) != 0 ? (Operators.CompareString(serviceProvision, Conversions.ToString(4), false) != 0 ? communityScheme.ServiceProvision : "water heating only") : "space and water heating") : "space only";
              XGraphics xgraphics287 = PDFFunctions.gfx[SAPInput.k];
              string str139 = "Service provision: " + str138;
              XFont xfont287 = xfont3;
              XSolidBrush black280 = XBrushes.Black;
              double rc1_280 = (double) SAPInput.RC1;
              xunit3 = PDFFunctions.pages[SAPInput.k].Width;
              double point287 = ((XUnit) ref xunit3).Point;
              xunit3 = PDFFunctions.pages[SAPInput.k].Height;
              double num340 = ((XUnit) ref xunit3).Point / 2.0;
              XRect xrect287 = new XRect(200.0, rc1_280, point287, num340);
              XStringFormat topLeft287 = XStringFormat.TopLeft;
              xgraphics287.DrawString(str139, xfont287, (XBrush) black280, xrect287, topLeft287);
              checked { SAPInput.RC1 += 12; }
              if (Operators.CompareString(communityScheme.DataType, Conversions.ToString(1), false) == 0)
              {
                XGraphics xgraphics288 = PDFFunctions.gfx[SAPInput.k];
                string str140 = "Provisional (estimated) data: " + str138;
                XFont xfont288 = xfont3;
                XSolidBrush black281 = XBrushes.Black;
                double rc1_281 = (double) SAPInput.RC1;
                xunit3 = PDFFunctions.pages[SAPInput.k].Width;
                double point288 = ((XUnit) ref xunit3).Point;
                xunit3 = PDFFunctions.pages[SAPInput.k].Height;
                double num341 = ((XUnit) ref xunit3).Point / 2.0;
                XRect xrect288 = new XRect(200.0, rc1_281, point288, num341);
                XStringFormat topLeft288 = XStringFormat.TopLeft;
                xgraphics288.DrawString(str140, xfont288, (XBrush) black281, xrect288, topLeft288);
              }
              else
              {
                XGraphics xgraphics289 = PDFFunctions.gfx[SAPInput.k];
                XFont xfont289 = xfont3;
                XSolidBrush black282 = XBrushes.Black;
                double rc1_282 = (double) SAPInput.RC1;
                xunit3 = PDFFunctions.pages[SAPInput.k].Width;
                double point289 = ((XUnit) ref xunit3).Point;
                xunit3 = PDFFunctions.pages[SAPInput.k].Height;
                double num342 = ((XUnit) ref xunit3).Point / 2.0;
                XRect xrect289 = new XRect(200.0, rc1_282, point289, num342);
                XStringFormat topLeft289 = XStringFormat.TopLeft;
                xgraphics289.DrawString("Actual data", xfont289, (XBrush) black282, xrect289, topLeft289);
              }
              checked { SAPInput.RC1 += 12; }
            }
            // ISSUE: reference to a compiler-generated field
            switch (SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatSource1.Type)
            {
              case 306:
                XGraphics xgraphics290 = PDFFunctions.gfx[SAPInput.k];
                // ISSUE: reference to a compiler-generated field
                string str141 = "Heat source : Community boilers " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatSource1.Type);
                XFont xfont290 = xfont3;
                XSolidBrush black283 = XBrushes.Black;
                double rc1_283 = (double) SAPInput.RC1;
                xunit3 = PDFFunctions.pages[SAPInput.k].Width;
                double point290 = ((XUnit) ref xunit3).Point;
                xunit3 = PDFFunctions.pages[SAPInput.k].Height;
                double num343 = ((XUnit) ref xunit3).Point / 2.0;
                XRect xrect290 = new XRect(180.0, rc1_283, point290, num343);
                XStringFormat topLeft290 = XStringFormat.TopLeft;
                xgraphics290.DrawString(str141, xfont290, (XBrush) black283, xrect290, topLeft290);
                break;
              case 307:
                XGraphics xgraphics291 = PDFFunctions.gfx[SAPInput.k];
                XFont xfont291 = xfont3;
                XSolidBrush black284 = XBrushes.Black;
                double rc1_284 = (double) SAPInput.RC1;
                xunit3 = PDFFunctions.pages[SAPInput.k].Width;
                double point291 = ((XUnit) ref xunit3).Point;
                xunit3 = PDFFunctions.pages[SAPInput.k].Height;
                double num344 = ((XUnit) ref xunit3).Point / 2.0;
                XRect xrect291 = new XRect(180.0, rc1_284, point291, num344);
                XStringFormat topLeft291 = XStringFormat.TopLeft;
                xgraphics291.DrawString("Heat source : Community CHP", xfont291, (XBrush) black284, xrect291, topLeft291);
                break;
              case 308:
                XGraphics xgraphics292 = PDFFunctions.gfx[SAPInput.k];
                XFont xfont292 = xfont3;
                XSolidBrush black285 = XBrushes.Black;
                double rc1_285 = (double) SAPInput.RC1;
                xunit3 = PDFFunctions.pages[SAPInput.k].Width;
                double point292 = ((XUnit) ref xunit3).Point;
                xunit3 = PDFFunctions.pages[SAPInput.k].Height;
                double num345 = ((XUnit) ref xunit3).Point / 2.0;
                XRect xrect292 = new XRect(180.0, rc1_285, point292, num345);
                XStringFormat topLeft292 = XStringFormat.TopLeft;
                xgraphics292.DrawString("Heat source : Community heat pump", xfont292, (XBrush) black285, xrect292, topLeft292);
                break;
              case 309:
                XGraphics xgraphics293 = PDFFunctions.gfx[SAPInput.k];
                XFont xfont293 = xfont3;
                XSolidBrush black286 = XBrushes.Black;
                double rc1_286 = (double) SAPInput.RC1;
                xunit3 = PDFFunctions.pages[SAPInput.k].Width;
                double point293 = ((XUnit) ref xunit3).Point;
                xunit3 = PDFFunctions.pages[SAPInput.k].Height;
                double num346 = ((XUnit) ref xunit3).Point / 2.0;
                XRect xrect293 = new XRect(180.0, rc1_286, point293, num346);
                XStringFormat topLeft293 = XStringFormat.TopLeft;
                xgraphics293.DrawString("Heat source : Community waste heat from power station", xfont293, (XBrush) black286, xrect293, topLeft293);
                break;
              case 310:
                XGraphics xgraphics294 = PDFFunctions.gfx[SAPInput.k];
                XFont xfont294 = xfont3;
                XSolidBrush black287 = XBrushes.Black;
                double rc1_287 = (double) SAPInput.RC1;
                xunit3 = PDFFunctions.pages[SAPInput.k].Width;
                double point294 = ((XUnit) ref xunit3).Point;
                xunit3 = PDFFunctions.pages[SAPInput.k].Height;
                double num347 = ((XUnit) ref xunit3).Point / 2.0;
                XRect xrect294 = new XRect(180.0, rc1_287, point294, num347);
                XStringFormat topLeft294 = XStringFormat.TopLeft;
                xgraphics294.DrawString("Heat source : Community geothermal heat", xfont294, (XBrush) black287, xrect294, topLeft294);
                break;
            }
            checked { SAPInput.RC1 += 20; }
            if (communitySchemeSubList[0].CommunityFuel.Equals("99"))
            {
              XGraphics xgraphics295 = PDFFunctions.gfx[SAPInput.k];
              XFont xfont295 = xfont3;
              XSolidBrush black288 = XBrushes.Black;
              double rc1_288 = (double) SAPInput.RC1;
              xunit3 = PDFFunctions.pages[SAPInput.k].Width;
              double point295 = ((XUnit) ref xunit3).Point;
              xunit3 = PDFFunctions.pages[SAPInput.k].Height;
              double num348 = ((XUnit) ref xunit3).Point / 2.0;
              XRect xrect295 = new XRect(200.0, rc1_288, point295, num348);
              XStringFormat topLeft295 = XStringFormat.TopLeft;
              xgraphics295.DrawString("Fuel : biomethane", xfont295, (XBrush) black288, xrect295, topLeft295);
            }
            else
            {
              XGraphics xgraphics296 = PDFFunctions.gfx[SAPInput.k];
              // ISSUE: reference to a compiler-generated field
              string str142 = "Fuel : " + SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.Fuel;
              XFont xfont296 = xfont3;
              XSolidBrush black289 = XBrushes.Black;
              double rc1_289 = (double) SAPInput.RC1;
              xunit3 = PDFFunctions.pages[SAPInput.k].Width;
              double point296 = ((XUnit) ref xunit3).Point;
              xunit3 = PDFFunctions.pages[SAPInput.k].Height;
              double num349 = ((XUnit) ref xunit3).Point / 2.0;
              XRect xrect296 = new XRect(200.0, rc1_289, point296, num349);
              XStringFormat topLeft296 = XStringFormat.TopLeft;
              xgraphics296.DrawString(str142, xfont296, (XBrush) black289, xrect296, topLeft296);
            }
          }
          else
          {
            XGraphics xgraphics297 = PDFFunctions.gfx[SAPInput.k];
            // ISSUE: reference to a compiler-generated field
            string str143 = "Fuel : " + SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.Fuel;
            XFont xfont297 = xfont3;
            XSolidBrush black290 = XBrushes.Black;
            double rc1_290 = (double) SAPInput.RC1;
            xunit3 = PDFFunctions.pages[SAPInput.k].Width;
            double point297 = ((XUnit) ref xunit3).Point;
            xunit3 = PDFFunctions.pages[SAPInput.k].Height;
            double num350 = ((XUnit) ref xunit3).Point / 2.0;
            XRect xrect297 = new XRect(200.0, rc1_290, point297, num350);
            XStringFormat topLeft297 = XStringFormat.TopLeft;
            xgraphics297.DrawString(str143, xfont297, (XBrush) black290, xrect297, topLeft297);
          }
          checked { SAPInput.RC1 += 12; }
          SAPInput.CheckRC1();
          XGraphics xgraphics298 = PDFFunctions.gfx[SAPInput.k];
          // ISSUE: reference to a compiler-generated field
          string str144 = "Heat Fraction : " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.Boiler1HeatFraction);
          XFont xfont298 = xfont3;
          XSolidBrush black291 = XBrushes.Black;
          double rc1_291 = (double) SAPInput.RC1;
          xunit3 = PDFFunctions.pages[SAPInput.k].Width;
          double point298 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[SAPInput.k].Height;
          double num351 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect298 = new XRect(200.0, rc1_291, point298, num351);
          XStringFormat topLeft298 = XStringFormat.TopLeft;
          xgraphics298.DrawString(str144, xfont298, (XBrush) black291, xrect298, topLeft298);
          checked { SAPInput.RC1 += 12; }
          SAPInput.CheckRC1();
          XGraphics xgraphics299 = PDFFunctions.gfx[SAPInput.k];
          // ISSUE: reference to a compiler-generated field
          string str145 = "Heat Efficiency : " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.Boiler1Efficiency);
          XFont xfont299 = xfont3;
          XSolidBrush black292 = XBrushes.Black;
          double rc1_292 = (double) SAPInput.RC1;
          xunit3 = PDFFunctions.pages[SAPInput.k].Width;
          double point299 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[SAPInput.k].Height;
          double num352 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect299 = new XRect(200.0, rc1_292, point299, num352);
          XStringFormat topLeft299 = XStringFormat.TopLeft;
          xgraphics299.DrawString(str145, xfont299, (XBrush) black292, xrect299, topLeft299);
          checked { SAPInput.RC1 += 12; }
          SAPInput.CheckRC1();
          // ISSUE: reference to a compiler-generated field
          if ((double) SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatToPowerRatio > 0.0)
          {
            XGraphics xgraphics300 = PDFFunctions.gfx[SAPInput.k];
            // ISSUE: reference to a compiler-generated field
            string str146 = "Power-Efficiency : " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatToPowerRatio);
            XFont xfont300 = xfont3;
            XSolidBrush black293 = XBrushes.Black;
            double rc1_293 = (double) SAPInput.RC1;
            xunit3 = PDFFunctions.pages[SAPInput.k].Width;
            double point300 = ((XUnit) ref xunit3).Point;
            xunit3 = PDFFunctions.pages[SAPInput.k].Height;
            double num353 = ((XUnit) ref xunit3).Point / 2.0;
            XRect xrect300 = new XRect(200.0, rc1_293, point300, num353);
            XStringFormat topLeft300 = XStringFormat.TopLeft;
            xgraphics300.DrawString(str146, xfont300, (XBrush) black293, xrect300, topLeft300);
          }
          checked { SAPInput.RC1 += 12; }
          SAPInput.CheckRC1();
          if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.NoOfAdditionalHeatSources > 0)
          {
            // ISSUE: reference to a compiler-generated field
            switch (SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatSource1.Type)
            {
              case 306:
                XGraphics xgraphics301 = PDFFunctions.gfx[SAPInput.k];
                XFont xfont301 = xfont3;
                XSolidBrush black294 = XBrushes.Black;
                double rc1_294 = (double) SAPInput.RC1;
                xunit3 = PDFFunctions.pages[SAPInput.k].Width;
                double point301 = ((XUnit) ref xunit3).Point;
                xunit3 = PDFFunctions.pages[SAPInput.k].Height;
                double num354 = ((XUnit) ref xunit3).Point / 2.0;
                XRect xrect301 = new XRect(180.0, rc1_294, point301, num354);
                XStringFormat topLeft301 = XStringFormat.TopLeft;
                xgraphics301.DrawString("Heat source : Community boilers ", xfont301, (XBrush) black294, xrect301, topLeft301);
                break;
              case 307:
                XGraphics xgraphics302 = PDFFunctions.gfx[SAPInput.k];
                XFont xfont302 = xfont3;
                XSolidBrush black295 = XBrushes.Black;
                double rc1_295 = (double) SAPInput.RC1;
                xunit3 = PDFFunctions.pages[SAPInput.k].Width;
                double point302 = ((XUnit) ref xunit3).Point;
                xunit3 = PDFFunctions.pages[SAPInput.k].Height;
                double num355 = ((XUnit) ref xunit3).Point / 2.0;
                XRect xrect302 = new XRect(180.0, rc1_295, point302, num355);
                XStringFormat topLeft302 = XStringFormat.TopLeft;
                xgraphics302.DrawString("Heat source : Community CHP", xfont302, (XBrush) black295, xrect302, topLeft302);
                break;
              case 308:
                XGraphics xgraphics303 = PDFFunctions.gfx[SAPInput.k];
                XFont xfont303 = xfont3;
                XSolidBrush black296 = XBrushes.Black;
                double rc1_296 = (double) SAPInput.RC1;
                xunit3 = PDFFunctions.pages[SAPInput.k].Width;
                double point303 = ((XUnit) ref xunit3).Point;
                xunit3 = PDFFunctions.pages[SAPInput.k].Height;
                double num356 = ((XUnit) ref xunit3).Point / 2.0;
                XRect xrect303 = new XRect(180.0, rc1_296, point303, num356);
                XStringFormat topLeft303 = XStringFormat.TopLeft;
                xgraphics303.DrawString("Heat source : Community heat pump", xfont303, (XBrush) black296, xrect303, topLeft303);
                break;
              case 309:
                XGraphics xgraphics304 = PDFFunctions.gfx[SAPInput.k];
                XFont xfont304 = xfont3;
                XSolidBrush black297 = XBrushes.Black;
                double rc1_297 = (double) SAPInput.RC1;
                xunit3 = PDFFunctions.pages[SAPInput.k].Width;
                double point304 = ((XUnit) ref xunit3).Point;
                xunit3 = PDFFunctions.pages[SAPInput.k].Height;
                double num357 = ((XUnit) ref xunit3).Point / 2.0;
                XRect xrect304 = new XRect(180.0, rc1_297, point304, num357);
                XStringFormat topLeft304 = XStringFormat.TopLeft;
                xgraphics304.DrawString("Heat source : Community waste heat from power station", xfont304, (XBrush) black297, xrect304, topLeft304);
                break;
              case 310:
                XGraphics xgraphics305 = PDFFunctions.gfx[SAPInput.k];
                XFont xfont305 = xfont3;
                XSolidBrush black298 = XBrushes.Black;
                double rc1_298 = (double) SAPInput.RC1;
                xunit3 = PDFFunctions.pages[SAPInput.k].Width;
                double point305 = ((XUnit) ref xunit3).Point;
                xunit3 = PDFFunctions.pages[SAPInput.k].Height;
                double num358 = ((XUnit) ref xunit3).Point / 2.0;
                XRect xrect305 = new XRect(180.0, rc1_298, point305, num358);
                XStringFormat topLeft305 = XStringFormat.TopLeft;
                xgraphics305.DrawString("Heat source : Community geothermal heat", xfont305, (XBrush) black298, xrect305, topLeft305);
                break;
            }
            checked { SAPInput.RC1 += 20; }
            SAPInput.CheckRC1();
            if (communitySchemeSubList.Count > 0)
            {
              if (communitySchemeSubList[1].CommunityFuel.Equals("99"))
              {
                XGraphics xgraphics306 = PDFFunctions.gfx[SAPInput.k];
                XFont xfont306 = xfont3;
                XSolidBrush black299 = XBrushes.Black;
                double rc1_299 = (double) SAPInput.RC1;
                xunit3 = PDFFunctions.pages[SAPInput.k].Width;
                double point306 = ((XUnit) ref xunit3).Point;
                xunit3 = PDFFunctions.pages[SAPInput.k].Height;
                double num359 = ((XUnit) ref xunit3).Point / 2.0;
                XRect xrect306 = new XRect(200.0, rc1_299, point306, num359);
                XStringFormat topLeft306 = XStringFormat.TopLeft;
                xgraphics306.DrawString("Fuel : biomethane", xfont306, (XBrush) black299, xrect306, topLeft306);
              }
              else
              {
                XGraphics xgraphics307 = PDFFunctions.gfx[SAPInput.k];
                // ISSUE: reference to a compiler-generated field
                string str147 = "Fuel : " + SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatSource1.Fuel;
                XFont xfont307 = xfont3;
                XSolidBrush black300 = XBrushes.Black;
                double rc1_300 = (double) SAPInput.RC1;
                xunit3 = PDFFunctions.pages[SAPInput.k].Width;
                double point307 = ((XUnit) ref xunit3).Point;
                xunit3 = PDFFunctions.pages[SAPInput.k].Height;
                double num360 = ((XUnit) ref xunit3).Point / 2.0;
                XRect xrect307 = new XRect(200.0, rc1_300, point307, num360);
                XStringFormat topLeft307 = XStringFormat.TopLeft;
                xgraphics307.DrawString(str147, xfont307, (XBrush) black300, xrect307, topLeft307);
              }
            }
            else
            {
              XGraphics xgraphics308 = PDFFunctions.gfx[SAPInput.k];
              // ISSUE: reference to a compiler-generated field
              string str148 = "Fuel : " + SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatSource1.Fuel;
              XFont xfont308 = xfont3;
              XSolidBrush black301 = XBrushes.Black;
              double rc1_301 = (double) SAPInput.RC1;
              xunit3 = PDFFunctions.pages[SAPInput.k].Width;
              double point308 = ((XUnit) ref xunit3).Point;
              xunit3 = PDFFunctions.pages[SAPInput.k].Height;
              double num361 = ((XUnit) ref xunit3).Point / 2.0;
              XRect xrect308 = new XRect(200.0, rc1_301, point308, num361);
              XStringFormat topLeft308 = XStringFormat.TopLeft;
              xgraphics308.DrawString(str148, xfont308, (XBrush) black301, xrect308, topLeft308);
            }
            checked { SAPInput.RC1 += 12; }
            SAPInput.CheckRC1();
            XGraphics xgraphics309 = PDFFunctions.gfx[SAPInput.k];
            // ISSUE: reference to a compiler-generated field
            string str149 = "Heat Fraction : " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatSource1.HeatFraction);
            XFont xfont309 = xfont3;
            XSolidBrush black302 = XBrushes.Black;
            double rc1_302 = (double) SAPInput.RC1;
            xunit3 = PDFFunctions.pages[SAPInput.k].Width;
            double point309 = ((XUnit) ref xunit3).Point;
            xunit3 = PDFFunctions.pages[SAPInput.k].Height;
            double num362 = ((XUnit) ref xunit3).Point / 2.0;
            XRect xrect309 = new XRect(200.0, rc1_302, point309, num362);
            XStringFormat topLeft309 = XStringFormat.TopLeft;
            xgraphics309.DrawString(str149, xfont309, (XBrush) black302, xrect309, topLeft309);
            checked { SAPInput.RC1 += 12; }
            SAPInput.CheckRC1();
            XGraphics xgraphics310 = PDFFunctions.gfx[SAPInput.k];
            // ISSUE: reference to a compiler-generated field
            string str150 = "Heat Efficiency : " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatSource1.Efficiency);
            XFont xfont310 = xfont3;
            XSolidBrush black303 = XBrushes.Black;
            double rc1_303 = (double) SAPInput.RC1;
            xunit3 = PDFFunctions.pages[SAPInput.k].Width;
            double point310 = ((XUnit) ref xunit3).Point;
            xunit3 = PDFFunctions.pages[SAPInput.k].Height;
            double num363 = ((XUnit) ref xunit3).Point / 2.0;
            XRect xrect310 = new XRect(200.0, rc1_303, point310, num363);
            XStringFormat topLeft310 = XStringFormat.TopLeft;
            xgraphics310.DrawString(str150, xfont310, (XBrush) black303, xrect310, topLeft310);
            checked { SAPInput.RC1 += 12; }
            SAPInput.CheckRC1();
          }
          if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.NoOfAdditionalHeatSources > 1)
          {
            // ISSUE: reference to a compiler-generated field
            switch (SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatSource2.Type)
            {
              case 306:
                XGraphics xgraphics311 = PDFFunctions.gfx[SAPInput.k];
                XFont xfont311 = xfont3;
                XSolidBrush black304 = XBrushes.Black;
                double rc1_304 = (double) SAPInput.RC1;
                xunit3 = PDFFunctions.pages[SAPInput.k].Width;
                double point311 = ((XUnit) ref xunit3).Point;
                xunit3 = PDFFunctions.pages[SAPInput.k].Height;
                double num364 = ((XUnit) ref xunit3).Point / 2.0;
                XRect xrect311 = new XRect(180.0, rc1_304, point311, num364);
                XStringFormat topLeft311 = XStringFormat.TopLeft;
                xgraphics311.DrawString("Heat source : Community boilers ", xfont311, (XBrush) black304, xrect311, topLeft311);
                break;
              case 307:
                XGraphics xgraphics312 = PDFFunctions.gfx[SAPInput.k];
                XFont xfont312 = xfont3;
                XSolidBrush black305 = XBrushes.Black;
                double rc1_305 = (double) SAPInput.RC1;
                xunit3 = PDFFunctions.pages[SAPInput.k].Width;
                double point312 = ((XUnit) ref xunit3).Point;
                xunit3 = PDFFunctions.pages[SAPInput.k].Height;
                double num365 = ((XUnit) ref xunit3).Point / 2.0;
                XRect xrect312 = new XRect(180.0, rc1_305, point312, num365);
                XStringFormat topLeft312 = XStringFormat.TopLeft;
                xgraphics312.DrawString("Heat source : Community CHP", xfont312, (XBrush) black305, xrect312, topLeft312);
                break;
              case 308:
                XGraphics xgraphics313 = PDFFunctions.gfx[SAPInput.k];
                XFont xfont313 = xfont3;
                XSolidBrush black306 = XBrushes.Black;
                double rc1_306 = (double) SAPInput.RC1;
                xunit3 = PDFFunctions.pages[SAPInput.k].Width;
                double point313 = ((XUnit) ref xunit3).Point;
                xunit3 = PDFFunctions.pages[SAPInput.k].Height;
                double num366 = ((XUnit) ref xunit3).Point / 2.0;
                XRect xrect313 = new XRect(180.0, rc1_306, point313, num366);
                XStringFormat topLeft313 = XStringFormat.TopLeft;
                xgraphics313.DrawString("Heat source : Community heat pump", xfont313, (XBrush) black306, xrect313, topLeft313);
                break;
              case 309:
                XGraphics xgraphics314 = PDFFunctions.gfx[SAPInput.k];
                XFont xfont314 = xfont3;
                XSolidBrush black307 = XBrushes.Black;
                double rc1_307 = (double) SAPInput.RC1;
                xunit3 = PDFFunctions.pages[SAPInput.k].Width;
                double point314 = ((XUnit) ref xunit3).Point;
                xunit3 = PDFFunctions.pages[SAPInput.k].Height;
                double num367 = ((XUnit) ref xunit3).Point / 2.0;
                XRect xrect314 = new XRect(180.0, rc1_307, point314, num367);
                XStringFormat topLeft314 = XStringFormat.TopLeft;
                xgraphics314.DrawString("Heat source : Community waste heat from power station", xfont314, (XBrush) black307, xrect314, topLeft314);
                break;
              case 310:
                XGraphics xgraphics315 = PDFFunctions.gfx[SAPInput.k];
                XFont xfont315 = xfont3;
                XSolidBrush black308 = XBrushes.Black;
                double rc1_308 = (double) SAPInput.RC1;
                xunit3 = PDFFunctions.pages[SAPInput.k].Width;
                double point315 = ((XUnit) ref xunit3).Point;
                xunit3 = PDFFunctions.pages[SAPInput.k].Height;
                double num368 = ((XUnit) ref xunit3).Point / 2.0;
                XRect xrect315 = new XRect(180.0, rc1_308, point315, num368);
                XStringFormat topLeft315 = XStringFormat.TopLeft;
                xgraphics315.DrawString("Heat source : Community geothermal heat", xfont315, (XBrush) black308, xrect315, topLeft315);
                break;
            }
            checked { SAPInput.RC1 += 20; }
            SAPInput.CheckRC1();
            if (communitySchemeSubList.Count > 0)
            {
              if (communitySchemeSubList[2].CommunityFuel.Equals("99"))
              {
                XGraphics xgraphics316 = PDFFunctions.gfx[SAPInput.k];
                XFont xfont316 = xfont3;
                XSolidBrush black309 = XBrushes.Black;
                double rc1_309 = (double) SAPInput.RC1;
                xunit3 = PDFFunctions.pages[SAPInput.k].Width;
                double point316 = ((XUnit) ref xunit3).Point;
                xunit3 = PDFFunctions.pages[SAPInput.k].Height;
                double num369 = ((XUnit) ref xunit3).Point / 2.0;
                XRect xrect316 = new XRect(200.0, rc1_309, point316, num369);
                XStringFormat topLeft316 = XStringFormat.TopLeft;
                xgraphics316.DrawString("Fuel : biomethane", xfont316, (XBrush) black309, xrect316, topLeft316);
              }
              else
              {
                XGraphics xgraphics317 = PDFFunctions.gfx[SAPInput.k];
                // ISSUE: reference to a compiler-generated field
                string str151 = "Fuel : " + SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatSource2.Fuel;
                XFont xfont317 = xfont3;
                XSolidBrush black310 = XBrushes.Black;
                double rc1_310 = (double) SAPInput.RC1;
                xunit3 = PDFFunctions.pages[SAPInput.k].Width;
                double point317 = ((XUnit) ref xunit3).Point;
                xunit3 = PDFFunctions.pages[SAPInput.k].Height;
                double num370 = ((XUnit) ref xunit3).Point / 2.0;
                XRect xrect317 = new XRect(200.0, rc1_310, point317, num370);
                XStringFormat topLeft317 = XStringFormat.TopLeft;
                xgraphics317.DrawString(str151, xfont317, (XBrush) black310, xrect317, topLeft317);
              }
            }
            else
            {
              XGraphics xgraphics318 = PDFFunctions.gfx[SAPInput.k];
              // ISSUE: reference to a compiler-generated field
              string str152 = "Fuel : " + SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatSource2.Fuel;
              XFont xfont318 = xfont3;
              XSolidBrush black311 = XBrushes.Black;
              double rc1_311 = (double) SAPInput.RC1;
              xunit3 = PDFFunctions.pages[SAPInput.k].Width;
              double point318 = ((XUnit) ref xunit3).Point;
              xunit3 = PDFFunctions.pages[SAPInput.k].Height;
              double num371 = ((XUnit) ref xunit3).Point / 2.0;
              XRect xrect318 = new XRect(200.0, rc1_311, point318, num371);
              XStringFormat topLeft318 = XStringFormat.TopLeft;
              xgraphics318.DrawString(str152, xfont318, (XBrush) black311, xrect318, topLeft318);
            }
            checked { SAPInput.RC1 += 12; }
            SAPInput.CheckRC1();
            XGraphics xgraphics319 = PDFFunctions.gfx[SAPInput.k];
            // ISSUE: reference to a compiler-generated field
            string str153 = "Heat Fraction : " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatSource2.HeatFraction);
            XFont xfont319 = xfont3;
            XSolidBrush black312 = XBrushes.Black;
            double rc1_312 = (double) SAPInput.RC1;
            xunit3 = PDFFunctions.pages[SAPInput.k].Width;
            double point319 = ((XUnit) ref xunit3).Point;
            xunit3 = PDFFunctions.pages[SAPInput.k].Height;
            double num372 = ((XUnit) ref xunit3).Point / 2.0;
            XRect xrect319 = new XRect(200.0, rc1_312, point319, num372);
            XStringFormat topLeft319 = XStringFormat.TopLeft;
            xgraphics319.DrawString(str153, xfont319, (XBrush) black312, xrect319, topLeft319);
            checked { SAPInput.RC1 += 12; }
            SAPInput.CheckRC1();
            XGraphics xgraphics320 = PDFFunctions.gfx[SAPInput.k];
            // ISSUE: reference to a compiler-generated field
            string str154 = "Heat Efficiency : " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatSource2.Efficiency);
            XFont xfont320 = xfont3;
            XSolidBrush black313 = XBrushes.Black;
            double rc1_313 = (double) SAPInput.RC1;
            xunit3 = PDFFunctions.pages[SAPInput.k].Width;
            double point320 = ((XUnit) ref xunit3).Point;
            xunit3 = PDFFunctions.pages[SAPInput.k].Height;
            double num373 = ((XUnit) ref xunit3).Point / 2.0;
            XRect xrect320 = new XRect(200.0, rc1_313, point320, num373);
            XStringFormat topLeft320 = XStringFormat.TopLeft;
            xgraphics320.DrawString(str154, xfont320, (XBrush) black313, xrect320, topLeft320);
            checked { SAPInput.RC1 += 12; }
            SAPInput.CheckRC1();
          }
          // ISSUE: reference to a compiler-generated field
          if (SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.NoOfAdditionalHeatSources > 2)
          {
            // ISSUE: reference to a compiler-generated field
            switch (SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatSource3.Type)
            {
              case 306:
                XGraphics xgraphics321 = PDFFunctions.gfx[SAPInput.k];
                XFont xfont321 = xfont3;
                XSolidBrush black314 = XBrushes.Black;
                double rc1_314 = (double) SAPInput.RC1;
                xunit3 = PDFFunctions.pages[SAPInput.k].Width;
                double point321 = ((XUnit) ref xunit3).Point;
                xunit3 = PDFFunctions.pages[SAPInput.k].Height;
                double num374 = ((XUnit) ref xunit3).Point / 2.0;
                XRect xrect321 = new XRect(180.0, rc1_314, point321, num374);
                XStringFormat topLeft321 = XStringFormat.TopLeft;
                xgraphics321.DrawString("Heat source : Community boilers ", xfont321, (XBrush) black314, xrect321, topLeft321);
                break;
              case 307:
                XGraphics xgraphics322 = PDFFunctions.gfx[SAPInput.k];
                XFont xfont322 = xfont3;
                XSolidBrush black315 = XBrushes.Black;
                double rc1_315 = (double) SAPInput.RC1;
                xunit3 = PDFFunctions.pages[SAPInput.k].Width;
                double point322 = ((XUnit) ref xunit3).Point;
                xunit3 = PDFFunctions.pages[SAPInput.k].Height;
                double num375 = ((XUnit) ref xunit3).Point / 2.0;
                XRect xrect322 = new XRect(180.0, rc1_315, point322, num375);
                XStringFormat topLeft322 = XStringFormat.TopLeft;
                xgraphics322.DrawString("Heat source : Community CHP", xfont322, (XBrush) black315, xrect322, topLeft322);
                break;
              case 308:
                XGraphics xgraphics323 = PDFFunctions.gfx[SAPInput.k];
                XFont xfont323 = xfont3;
                XSolidBrush black316 = XBrushes.Black;
                double rc1_316 = (double) SAPInput.RC1;
                xunit3 = PDFFunctions.pages[SAPInput.k].Width;
                double point323 = ((XUnit) ref xunit3).Point;
                xunit3 = PDFFunctions.pages[SAPInput.k].Height;
                double num376 = ((XUnit) ref xunit3).Point / 2.0;
                XRect xrect323 = new XRect(180.0, rc1_316, point323, num376);
                XStringFormat topLeft323 = XStringFormat.TopLeft;
                xgraphics323.DrawString("Heat source : Community heat pump", xfont323, (XBrush) black316, xrect323, topLeft323);
                break;
              case 309:
                XGraphics xgraphics324 = PDFFunctions.gfx[SAPInput.k];
                XFont xfont324 = xfont3;
                XSolidBrush black317 = XBrushes.Black;
                double rc1_317 = (double) SAPInput.RC1;
                xunit3 = PDFFunctions.pages[SAPInput.k].Width;
                double point324 = ((XUnit) ref xunit3).Point;
                xunit3 = PDFFunctions.pages[SAPInput.k].Height;
                double num377 = ((XUnit) ref xunit3).Point / 2.0;
                XRect xrect324 = new XRect(180.0, rc1_317, point324, num377);
                XStringFormat topLeft324 = XStringFormat.TopLeft;
                xgraphics324.DrawString("Heat source : Community waste heat from power station", xfont324, (XBrush) black317, xrect324, topLeft324);
                break;
              case 310:
                XGraphics xgraphics325 = PDFFunctions.gfx[SAPInput.k];
                XFont xfont325 = xfont3;
                XSolidBrush black318 = XBrushes.Black;
                double rc1_318 = (double) SAPInput.RC1;
                xunit3 = PDFFunctions.pages[SAPInput.k].Width;
                double point325 = ((XUnit) ref xunit3).Point;
                xunit3 = PDFFunctions.pages[SAPInput.k].Height;
                double num378 = ((XUnit) ref xunit3).Point / 2.0;
                XRect xrect325 = new XRect(180.0, rc1_318, point325, num378);
                XStringFormat topLeft325 = XStringFormat.TopLeft;
                xgraphics325.DrawString("Heat source : Community geothermal heat", xfont325, (XBrush) black318, xrect325, topLeft325);
                break;
            }
            checked { SAPInput.RC1 += 20; }
            SAPInput.CheckRC1();
            SAPInput.CheckRC1();
            if (communitySchemeSubList.Count > 0)
            {
              if (communitySchemeSubList[3].CommunityFuel.Equals("99"))
              {
                XGraphics xgraphics326 = PDFFunctions.gfx[SAPInput.k];
                XFont xfont326 = xfont3;
                XSolidBrush black319 = XBrushes.Black;
                double rc1_319 = (double) SAPInput.RC1;
                xunit3 = PDFFunctions.pages[SAPInput.k].Width;
                double point326 = ((XUnit) ref xunit3).Point;
                xunit3 = PDFFunctions.pages[SAPInput.k].Height;
                double num379 = ((XUnit) ref xunit3).Point / 2.0;
                XRect xrect326 = new XRect(200.0, rc1_319, point326, num379);
                XStringFormat topLeft326 = XStringFormat.TopLeft;
                xgraphics326.DrawString("Fuel : biomethane", xfont326, (XBrush) black319, xrect326, topLeft326);
              }
              else
              {
                XGraphics xgraphics327 = PDFFunctions.gfx[SAPInput.k];
                // ISSUE: reference to a compiler-generated field
                string str155 = "Fuel : " + SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatSource3.Fuel;
                XFont xfont327 = xfont3;
                XSolidBrush black320 = XBrushes.Black;
                double rc1_320 = (double) SAPInput.RC1;
                xunit3 = PDFFunctions.pages[SAPInput.k].Width;
                double point327 = ((XUnit) ref xunit3).Point;
                xunit3 = PDFFunctions.pages[SAPInput.k].Height;
                double num380 = ((XUnit) ref xunit3).Point / 2.0;
                XRect xrect327 = new XRect(200.0, rc1_320, point327, num380);
                XStringFormat topLeft327 = XStringFormat.TopLeft;
                xgraphics327.DrawString(str155, xfont327, (XBrush) black320, xrect327, topLeft327);
              }
            }
            else
            {
              XGraphics xgraphics328 = PDFFunctions.gfx[SAPInput.k];
              // ISSUE: reference to a compiler-generated field
              string str156 = "Fuel : " + SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatSource3.Fuel;
              XFont xfont328 = xfont3;
              XSolidBrush black321 = XBrushes.Black;
              double rc1_321 = (double) SAPInput.RC1;
              xunit3 = PDFFunctions.pages[SAPInput.k].Width;
              double point328 = ((XUnit) ref xunit3).Point;
              xunit3 = PDFFunctions.pages[SAPInput.k].Height;
              double num381 = ((XUnit) ref xunit3).Point / 2.0;
              XRect xrect328 = new XRect(200.0, rc1_321, point328, num381);
              XStringFormat topLeft328 = XStringFormat.TopLeft;
              xgraphics328.DrawString(str156, xfont328, (XBrush) black321, xrect328, topLeft328);
            }
            checked { SAPInput.RC1 += 12; }
            SAPInput.CheckRC1();
            XGraphics xgraphics329 = PDFFunctions.gfx[SAPInput.k];
            // ISSUE: reference to a compiler-generated field
            string str157 = "Heat Fraction : " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatSource3.HeatFraction);
            XFont xfont329 = xfont3;
            XSolidBrush black322 = XBrushes.Black;
            double rc1_322 = (double) SAPInput.RC1;
            xunit3 = PDFFunctions.pages[SAPInput.k].Width;
            double point329 = ((XUnit) ref xunit3).Point;
            xunit3 = PDFFunctions.pages[SAPInput.k].Height;
            double num382 = ((XUnit) ref xunit3).Point / 2.0;
            XRect xrect329 = new XRect(200.0, rc1_322, point329, num382);
            XStringFormat topLeft329 = XStringFormat.TopLeft;
            xgraphics329.DrawString(str157, xfont329, (XBrush) black322, xrect329, topLeft329);
            checked { SAPInput.RC1 += 12; }
            SAPInput.CheckRC1();
            XGraphics xgraphics330 = PDFFunctions.gfx[SAPInput.k];
            // ISSUE: reference to a compiler-generated field
            string str158 = "Heat Efficiency : " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatSource3.Efficiency);
            XFont xfont330 = xfont3;
            XSolidBrush black323 = XBrushes.Black;
            double rc1_323 = (double) SAPInput.RC1;
            xunit3 = PDFFunctions.pages[SAPInput.k].Width;
            double point330 = ((XUnit) ref xunit3).Point;
            xunit3 = PDFFunctions.pages[SAPInput.k].Height;
            double num383 = ((XUnit) ref xunit3).Point / 2.0;
            XRect xrect330 = new XRect(200.0, rc1_323, point330, num383);
            XStringFormat topLeft330 = XStringFormat.TopLeft;
            xgraphics330.DrawString(str158, xfont330, (XBrush) black323, xrect330, topLeft330);
            checked { SAPInput.RC1 += 12; }
            SAPInput.CheckRC1();
          }
          if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.NoOfAdditionalHeatSources > 3)
          {
            // ISSUE: reference to a compiler-generated field
            switch (SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatSource4.Type)
            {
              case 306:
                XGraphics xgraphics331 = PDFFunctions.gfx[SAPInput.k];
                XFont xfont331 = xfont3;
                XSolidBrush black324 = XBrushes.Black;
                double rc1_324 = (double) SAPInput.RC1;
                xunit3 = PDFFunctions.pages[SAPInput.k].Width;
                double point331 = ((XUnit) ref xunit3).Point;
                xunit3 = PDFFunctions.pages[SAPInput.k].Height;
                double num384 = ((XUnit) ref xunit3).Point / 2.0;
                XRect xrect331 = new XRect(180.0, rc1_324, point331, num384);
                XStringFormat topLeft331 = XStringFormat.TopLeft;
                xgraphics331.DrawString("Heat source : Community boilers ", xfont331, (XBrush) black324, xrect331, topLeft331);
                break;
              case 307:
                XGraphics xgraphics332 = PDFFunctions.gfx[SAPInput.k];
                XFont xfont332 = xfont3;
                XSolidBrush black325 = XBrushes.Black;
                double rc1_325 = (double) SAPInput.RC1;
                xunit3 = PDFFunctions.pages[SAPInput.k].Width;
                double point332 = ((XUnit) ref xunit3).Point;
                xunit3 = PDFFunctions.pages[SAPInput.k].Height;
                double num385 = ((XUnit) ref xunit3).Point / 2.0;
                XRect xrect332 = new XRect(180.0, rc1_325, point332, num385);
                XStringFormat topLeft332 = XStringFormat.TopLeft;
                xgraphics332.DrawString("Heat source : Community CHP", xfont332, (XBrush) black325, xrect332, topLeft332);
                break;
              case 308:
                XGraphics xgraphics333 = PDFFunctions.gfx[SAPInput.k];
                XFont xfont333 = xfont3;
                XSolidBrush black326 = XBrushes.Black;
                double rc1_326 = (double) SAPInput.RC1;
                xunit3 = PDFFunctions.pages[SAPInput.k].Width;
                double point333 = ((XUnit) ref xunit3).Point;
                xunit3 = PDFFunctions.pages[SAPInput.k].Height;
                double num386 = ((XUnit) ref xunit3).Point / 2.0;
                XRect xrect333 = new XRect(180.0, rc1_326, point333, num386);
                XStringFormat topLeft333 = XStringFormat.TopLeft;
                xgraphics333.DrawString("Heat source : Community heat pump", xfont333, (XBrush) black326, xrect333, topLeft333);
                break;
              case 309:
                XGraphics xgraphics334 = PDFFunctions.gfx[SAPInput.k];
                XFont xfont334 = xfont3;
                XSolidBrush black327 = XBrushes.Black;
                double rc1_327 = (double) SAPInput.RC1;
                xunit3 = PDFFunctions.pages[SAPInput.k].Width;
                double point334 = ((XUnit) ref xunit3).Point;
                xunit3 = PDFFunctions.pages[SAPInput.k].Height;
                double num387 = ((XUnit) ref xunit3).Point / 2.0;
                XRect xrect334 = new XRect(180.0, rc1_327, point334, num387);
                XStringFormat topLeft334 = XStringFormat.TopLeft;
                xgraphics334.DrawString("Heat source : Community waste heat from power station", xfont334, (XBrush) black327, xrect334, topLeft334);
                break;
              case 310:
                XGraphics xgraphics335 = PDFFunctions.gfx[SAPInput.k];
                XFont xfont335 = xfont3;
                XSolidBrush black328 = XBrushes.Black;
                double rc1_328 = (double) SAPInput.RC1;
                xunit3 = PDFFunctions.pages[SAPInput.k].Width;
                double point335 = ((XUnit) ref xunit3).Point;
                xunit3 = PDFFunctions.pages[SAPInput.k].Height;
                double num388 = ((XUnit) ref xunit3).Point / 2.0;
                XRect xrect335 = new XRect(180.0, rc1_328, point335, num388);
                XStringFormat topLeft335 = XStringFormat.TopLeft;
                xgraphics335.DrawString("Heat source : Community geothermal heat", xfont335, (XBrush) black328, xrect335, topLeft335);
                break;
            }
            checked { SAPInput.RC1 += 20; }
            SAPInput.CheckRC1();
            if (communitySchemeSubList.Count > 0)
            {
              if (communitySchemeSubList[4].CommunityFuel.Equals("99"))
              {
                XGraphics xgraphics336 = PDFFunctions.gfx[SAPInput.k];
                XFont xfont336 = xfont3;
                XSolidBrush black329 = XBrushes.Black;
                double rc1_329 = (double) SAPInput.RC1;
                xunit3 = PDFFunctions.pages[SAPInput.k].Width;
                double point336 = ((XUnit) ref xunit3).Point;
                xunit3 = PDFFunctions.pages[SAPInput.k].Height;
                double num389 = ((XUnit) ref xunit3).Point / 2.0;
                XRect xrect336 = new XRect(200.0, rc1_329, point336, num389);
                XStringFormat topLeft336 = XStringFormat.TopLeft;
                xgraphics336.DrawString("Fuel : biomethane", xfont336, (XBrush) black329, xrect336, topLeft336);
              }
              else
              {
                XGraphics xgraphics337 = PDFFunctions.gfx[SAPInput.k];
                // ISSUE: reference to a compiler-generated field
                string str159 = "Fuel : " + SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatSource4.Fuel;
                XFont xfont337 = xfont3;
                XSolidBrush black330 = XBrushes.Black;
                double rc1_330 = (double) SAPInput.RC1;
                xunit3 = PDFFunctions.pages[SAPInput.k].Width;
                double point337 = ((XUnit) ref xunit3).Point;
                xunit3 = PDFFunctions.pages[SAPInput.k].Height;
                double num390 = ((XUnit) ref xunit3).Point / 2.0;
                XRect xrect337 = new XRect(200.0, rc1_330, point337, num390);
                XStringFormat topLeft337 = XStringFormat.TopLeft;
                xgraphics337.DrawString(str159, xfont337, (XBrush) black330, xrect337, topLeft337);
              }
            }
            else
            {
              XGraphics xgraphics338 = PDFFunctions.gfx[SAPInput.k];
              // ISSUE: reference to a compiler-generated field
              string str160 = "Fuel : " + SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatSource4.Fuel;
              XFont xfont338 = xfont3;
              XSolidBrush black331 = XBrushes.Black;
              double rc1_331 = (double) SAPInput.RC1;
              xunit3 = PDFFunctions.pages[SAPInput.k].Width;
              double point338 = ((XUnit) ref xunit3).Point;
              xunit3 = PDFFunctions.pages[SAPInput.k].Height;
              double num391 = ((XUnit) ref xunit3).Point / 2.0;
              XRect xrect338 = new XRect(200.0, rc1_331, point338, num391);
              XStringFormat topLeft338 = XStringFormat.TopLeft;
              xgraphics338.DrawString(str160, xfont338, (XBrush) black331, xrect338, topLeft338);
            }
            checked { SAPInput.RC1 += 12; }
            SAPInput.CheckRC1();
            XGraphics xgraphics339 = PDFFunctions.gfx[SAPInput.k];
            // ISSUE: reference to a compiler-generated field
            string str161 = "Heat Fraction : " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatSource4.HeatFraction);
            XFont xfont339 = xfont3;
            XSolidBrush black332 = XBrushes.Black;
            double rc1_332 = (double) SAPInput.RC1;
            xunit3 = PDFFunctions.pages[SAPInput.k].Width;
            double point339 = ((XUnit) ref xunit3).Point;
            xunit3 = PDFFunctions.pages[SAPInput.k].Height;
            double num392 = ((XUnit) ref xunit3).Point / 2.0;
            XRect xrect339 = new XRect(200.0, rc1_332, point339, num392);
            XStringFormat topLeft339 = XStringFormat.TopLeft;
            xgraphics339.DrawString(str161, xfont339, (XBrush) black332, xrect339, topLeft339);
            checked { SAPInput.RC1 += 12; }
            SAPInput.CheckRC1();
            XGraphics xgraphics340 = PDFFunctions.gfx[SAPInput.k];
            // ISSUE: reference to a compiler-generated field
            string str162 = "Heat Efficiency : " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatSource4.Efficiency);
            XFont xfont340 = xfont3;
            XSolidBrush black333 = XBrushes.Black;
            double rc1_333 = (double) SAPInput.RC1;
            xunit3 = PDFFunctions.pages[SAPInput.k].Width;
            double point340 = ((XUnit) ref xunit3).Point;
            xunit3 = PDFFunctions.pages[SAPInput.k].Height;
            double num393 = ((XUnit) ref xunit3).Point / 2.0;
            XRect xrect340 = new XRect(200.0, rc1_333, point340, num393);
            XStringFormat topLeft340 = XStringFormat.TopLeft;
            xgraphics340.DrawString(str162, xfont340, (XBrush) black333, xrect340, topLeft340);
            checked { SAPInput.RC1 += 12; }
            SAPInput.CheckRC1();
          }
        }
        else
        {
          XGraphics xgraphics341 = PDFFunctions.gfx[SAPInput.k];
          // ISSUE: reference to a compiler-generated field
          string str163 = "Heat source: " + SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.MHType;
          XFont xfont341 = xfont3;
          XSolidBrush black334 = XBrushes.Black;
          double rc1_334 = (double) SAPInput.RC1;
          xunit3 = PDFFunctions.pages[SAPInput.k].Width;
          double point341 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[SAPInput.k].Height;
          double num394 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect341 = new XRect(200.0, rc1_334, point341, num394);
          XStringFormat topLeft341 = XStringFormat.TopLeft;
          xgraphics341.DrawString(str163, xfont341, (XBrush) black334, xrect341, topLeft341);
          checked { SAPInput.RC1 += 12; }
          SAPInput.CheckRC1();
          XGraphics xgraphics342 = PDFFunctions.gfx[SAPInput.k];
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          string str164 = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.Fuel + ", heat fraction " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.Boiler1HeatFraction) + ", efficiency " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.Boiler1Efficiency);
          XFont xfont342 = xfont3;
          XSolidBrush black335 = XBrushes.Black;
          double rc1_335 = (double) SAPInput.RC1;
          xunit3 = PDFFunctions.pages[SAPInput.k].Width;
          double point342 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[SAPInput.k].Height;
          double num395 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect342 = new XRect(205.0, rc1_335, point342, num395);
          XStringFormat topLeft342 = XStringFormat.TopLeft;
          xgraphics342.DrawString(str164, xfont342, (XBrush) black335, xrect342, topLeft342);
          // ISSUE: reference to a compiler-generated field
          if (SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.NoOfAdditionalHeatSources > 0)
          {
            // ISSUE: reference to a compiler-generated method
            PCDF.Table4a_B table4aB = SAP_Module.PCDFData.Table4a_bs.Where<PCDF.Table4a_B>(new Func<PCDF.Table4a_B, bool>(closure160_2._Lambda\u0024__10)).SingleOrDefault<PCDF.Table4a_B>();
            checked { SAPInput.RC1 += 12; }
            SAPInput.CheckRC1();
            XGraphics xgraphics343 = PDFFunctions.gfx[SAPInput.k];
            string str165 = "Heat source: " + table4aB.Description;
            XFont xfont343 = xfont3;
            XSolidBrush black336 = XBrushes.Black;
            double rc1_336 = (double) SAPInput.RC1;
            xunit3 = PDFFunctions.pages[SAPInput.k].Width;
            double point343 = ((XUnit) ref xunit3).Point;
            xunit3 = PDFFunctions.pages[SAPInput.k].Height;
            double num396 = ((XUnit) ref xunit3).Point / 2.0;
            XRect xrect343 = new XRect(200.0, rc1_336, point343, num396);
            XStringFormat topLeft343 = XStringFormat.TopLeft;
            xgraphics343.DrawString(str165, xfont343, (XBrush) black336, xrect343, topLeft343);
            checked { SAPInput.RC1 += 12; }
            SAPInput.CheckRC1();
            XGraphics xgraphics344 = PDFFunctions.gfx[SAPInput.k];
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            string str166 = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatSource1.Fuel + ", heat fraction " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatSource1.HeatFraction) + ", efficiency " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatSource1.Efficiency);
            XFont xfont344 = xfont3;
            XSolidBrush black337 = XBrushes.Black;
            double rc1_337 = (double) SAPInput.RC1;
            xunit3 = PDFFunctions.pages[SAPInput.k].Width;
            double point344 = ((XUnit) ref xunit3).Point;
            xunit3 = PDFFunctions.pages[SAPInput.k].Height;
            double num397 = ((XUnit) ref xunit3).Point / 2.0;
            XRect xrect344 = new XRect(205.0, rc1_337, point344, num397);
            XStringFormat topLeft344 = XStringFormat.TopLeft;
            xgraphics344.DrawString(str166, xfont344, (XBrush) black337, xrect344, topLeft344);
          }
          // ISSUE: reference to a compiler-generated field
          if (SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.NoOfAdditionalHeatSources > 1)
          {
            // ISSUE: reference to a compiler-generated method
            PCDF.Table4a_B table4aB = SAP_Module.PCDFData.Table4a_bs.Where<PCDF.Table4a_B>(new Func<PCDF.Table4a_B, bool>(closure160_2._Lambda\u0024__11)).SingleOrDefault<PCDF.Table4a_B>();
            checked { SAPInput.RC1 += 12; }
            SAPInput.CheckRC1();
            XGraphics xgraphics345 = PDFFunctions.gfx[SAPInput.k];
            string str167 = "Heat source: " + table4aB.Description;
            XFont xfont345 = xfont3;
            XSolidBrush black338 = XBrushes.Black;
            double rc1_338 = (double) SAPInput.RC1;
            xunit3 = PDFFunctions.pages[SAPInput.k].Width;
            double point345 = ((XUnit) ref xunit3).Point;
            xunit3 = PDFFunctions.pages[SAPInput.k].Height;
            double num398 = ((XUnit) ref xunit3).Point / 2.0;
            XRect xrect345 = new XRect(200.0, rc1_338, point345, num398);
            XStringFormat topLeft345 = XStringFormat.TopLeft;
            xgraphics345.DrawString(str167, xfont345, (XBrush) black338, xrect345, topLeft345);
            checked { SAPInput.RC1 += 12; }
            SAPInput.CheckRC1();
            XGraphics xgraphics346 = PDFFunctions.gfx[SAPInput.k];
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            string str168 = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatSource2.Fuel + ", heat fraction " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatSource2.HeatFraction) + ", efficiency " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatSource2.Efficiency);
            XFont xfont346 = xfont3;
            XSolidBrush black339 = XBrushes.Black;
            double rc1_339 = (double) SAPInput.RC1;
            xunit3 = PDFFunctions.pages[SAPInput.k].Width;
            double point346 = ((XUnit) ref xunit3).Point;
            xunit3 = PDFFunctions.pages[SAPInput.k].Height;
            double num399 = ((XUnit) ref xunit3).Point / 2.0;
            XRect xrect346 = new XRect(205.0, rc1_339, point346, num399);
            XStringFormat topLeft346 = XStringFormat.TopLeft;
            xgraphics346.DrawString(str168, xfont346, (XBrush) black339, xrect346, topLeft346);
          }
          // ISSUE: reference to a compiler-generated field
          if (SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.NoOfAdditionalHeatSources > 2)
          {
            // ISSUE: reference to a compiler-generated method
            PCDF.Table4a_B table4aB = SAP_Module.PCDFData.Table4a_bs.Where<PCDF.Table4a_B>(new Func<PCDF.Table4a_B, bool>(closure160_2._Lambda\u0024__12)).SingleOrDefault<PCDF.Table4a_B>();
            checked { SAPInput.RC1 += 12; }
            SAPInput.CheckRC1();
            XGraphics xgraphics347 = PDFFunctions.gfx[SAPInput.k];
            string str169 = "Heat source: " + table4aB.Description;
            XFont xfont347 = xfont3;
            XSolidBrush black340 = XBrushes.Black;
            double rc1_340 = (double) SAPInput.RC1;
            xunit3 = PDFFunctions.pages[SAPInput.k].Width;
            double point347 = ((XUnit) ref xunit3).Point;
            xunit3 = PDFFunctions.pages[SAPInput.k].Height;
            double num400 = ((XUnit) ref xunit3).Point / 2.0;
            XRect xrect347 = new XRect(200.0, rc1_340, point347, num400);
            XStringFormat topLeft347 = XStringFormat.TopLeft;
            xgraphics347.DrawString(str169, xfont347, (XBrush) black340, xrect347, topLeft347);
            checked { SAPInput.RC1 += 12; }
            SAPInput.CheckRC1();
            XGraphics xgraphics348 = PDFFunctions.gfx[SAPInput.k];
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            string str170 = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatSource3.Fuel + ", heat fraction " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatSource3.HeatFraction) + ", efficiency " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatSource3.Efficiency);
            XFont xfont348 = xfont3;
            XSolidBrush black341 = XBrushes.Black;
            double rc1_341 = (double) SAPInput.RC1;
            xunit3 = PDFFunctions.pages[SAPInput.k].Width;
            double point348 = ((XUnit) ref xunit3).Point;
            xunit3 = PDFFunctions.pages[SAPInput.k].Height;
            double num401 = ((XUnit) ref xunit3).Point / 2.0;
            XRect xrect348 = new XRect(205.0, rc1_341, point348, num401);
            XStringFormat topLeft348 = XStringFormat.TopLeft;
            xgraphics348.DrawString(str170, xfont348, (XBrush) black341, xrect348, topLeft348);
          }
          // ISSUE: reference to a compiler-generated field
          if (SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.NoOfAdditionalHeatSources > 3)
          {
            // ISSUE: reference to a compiler-generated method
            PCDF.Table4a_B table4aB = SAP_Module.PCDFData.Table4a_bs.Where<PCDF.Table4a_B>(new Func<PCDF.Table4a_B, bool>(closure160_2._Lambda\u0024__13)).SingleOrDefault<PCDF.Table4a_B>();
            checked { SAPInput.RC1 += 12; }
            SAPInput.CheckRC1();
            XGraphics xgraphics349 = PDFFunctions.gfx[SAPInput.k];
            string str171 = "Heat source: " + table4aB.Description;
            XFont xfont349 = xfont3;
            XSolidBrush black342 = XBrushes.Black;
            double rc1_342 = (double) SAPInput.RC1;
            xunit3 = PDFFunctions.pages[SAPInput.k].Width;
            double point349 = ((XUnit) ref xunit3).Point;
            xunit3 = PDFFunctions.pages[SAPInput.k].Height;
            double num402 = ((XUnit) ref xunit3).Point / 2.0;
            XRect xrect349 = new XRect(200.0, rc1_342, point349, num402);
            XStringFormat topLeft349 = XStringFormat.TopLeft;
            xgraphics349.DrawString(str171, xfont349, (XBrush) black342, xrect349, topLeft349);
            checked { SAPInput.RC1 += 12; }
            SAPInput.CheckRC1();
            XGraphics xgraphics350 = PDFFunctions.gfx[SAPInput.k];
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            string str172 = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatSource4.Fuel + ", heat fraction " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatSource4.HeatFraction) + ", efficiency " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatSource4.Efficiency);
            XFont xfont350 = xfont3;
            XSolidBrush black343 = XBrushes.Black;
            double rc1_343 = (double) SAPInput.RC1;
            xunit3 = PDFFunctions.pages[SAPInput.k].Width;
            double point350 = ((XUnit) ref xunit3).Point;
            xunit3 = PDFFunctions.pages[SAPInput.k].Height;
            double num403 = ((XUnit) ref xunit3).Point / 2.0;
            XRect xrect350 = new XRect(205.0, rc1_343, point350, num403);
            XStringFormat topLeft350 = XStringFormat.TopLeft;
            xgraphics350.DrawString(str172, xfont350, (XBrush) black343, xrect350, topLeft350);
          }
          checked { SAPInput.RC1 += 12; }
          SAPInput.CheckRC1();
          XGraphics xgraphics351 = PDFFunctions.gfx[SAPInput.k];
          // ISSUE: reference to a compiler-generated field
          string heatDsystem = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.CommunityH.HeatDSystem;
          XFont xfont351 = xfont3;
          XSolidBrush black344 = XBrushes.Black;
          double rc1_344 = (double) SAPInput.RC1;
          xunit3 = PDFFunctions.pages[SAPInput.k].Width;
          double point351 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[SAPInput.k].Height;
          double num404 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect351 = new XRect(200.0, rc1_344, point351, num404);
          XStringFormat topLeft351 = XStringFormat.TopLeft;
          xgraphics351.DrawString(heatDsystem, xfont351, (XBrush) black344, xrect351, topLeft351);
        }
      }
      checked { SAPInput.RC1 += 14; }
      SAPInput.CheckRC1();
      // ISSUE: reference to a compiler-generated field
      if (SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].IncludeMainHeating2)
      {
        XGraphics xgraphics352 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string str173 = "Fraction of main heat: " + Conversions.ToString(Math.Round(1.0 - (double) SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].HeatFractionSec, 2));
        XFont xfont352 = xfont3;
        XSolidBrush black345 = XBrushes.Black;
        double rc1_345 = (double) SAPInput.RC1;
        xunit3 = PDFFunctions.pages[SAPInput.k].Width;
        double point352 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[SAPInput.k].Height;
        double num405 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect352 = new XRect(200.0, rc1_345, point352, num405);
        XStringFormat topLeft352 = XStringFormat.TopLeft;
        xgraphics352.DrawString(str173, xfont352, (XBrush) black345, xrect352, topLeft352);
        checked { SAPInput.RC1 += 12; }
        SAPInput.CheckRC1();
      }
      SAPInput.CheckRC1();
      // ISSUE: reference to a compiler-generated field
      if (!string.IsNullOrEmpty(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.Boiler.PumpType))
      {
        XGraphics xgraphics353 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string str174 = "Central heating pump : " + SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.Boiler.PumpType;
        XFont xfont353 = xfont3;
        XSolidBrush black346 = XBrushes.Black;
        double rc1_346 = (double) SAPInput.RC1;
        xunit3 = PDFFunctions.pages[SAPInput.k].Width;
        double point353 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[SAPInput.k].Height;
        double num406 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect353 = new XRect(200.0, rc1_346, point353, num406);
        XStringFormat topLeft353 = XStringFormat.TopLeft;
        xgraphics353.DrawString(str174, xfont353, (XBrush) black346, xrect353, topLeft353);
        checked { SAPInput.RC1 += 12; }
        SAPInput.CheckRC1();
      }
      // ISSUE: reference to a compiler-generated field
      if (!string.IsNullOrEmpty(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.Boiler.FlowTemp))
      {
        XGraphics xgraphics354 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string str175 = "Design flow temperature: " + SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.Boiler.FlowTemp;
        XFont xfont354 = xfont3;
        XSolidBrush black347 = XBrushes.Black;
        double rc1_347 = (double) SAPInput.RC1;
        xunit3 = PDFFunctions.pages[SAPInput.k].Width;
        double point354 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[SAPInput.k].Height;
        double num407 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect354 = new XRect(200.0, rc1_347, point354, num407);
        XStringFormat topLeft354 = XStringFormat.TopLeft;
        xgraphics354.DrawString(str175, xfont354, (XBrush) black347, xrect354, topLeft354);
        checked { SAPInput.RC1 += 12; }
        SAPInput.CheckRC1();
      }
      // ISSUE: reference to a compiler-generated field
      if (!string.IsNullOrEmpty(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.Boiler.FlueType))
      {
        XGraphics xgraphics355 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string flueType = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.Boiler.FlueType;
        XFont xfont355 = xfont3;
        XSolidBrush black348 = XBrushes.Black;
        double rc1_348 = (double) SAPInput.RC1;
        xunit3 = PDFFunctions.pages[SAPInput.k].Width;
        double point355 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[SAPInput.k].Height;
        double num408 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect355 = new XRect(200.0, rc1_348, point355, num408);
        XStringFormat topLeft355 = XStringFormat.TopLeft;
        xgraphics355.DrawString(flueType, xfont355, (XBrush) black348, xrect355, topLeft355);
        checked { SAPInput.RC1 += 12; }
        SAPInput.CheckRC1();
      }
      // ISSUE: reference to a compiler-generated field
      if (!string.IsNullOrEmpty(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.Boiler.BILock))
      {
        XGraphics xgraphics356 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string str176 = "Boiler interlock: " + SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.Boiler.BILock;
        XFont xfont356 = xfont3;
        XSolidBrush black349 = XBrushes.Black;
        double rc1_349 = (double) SAPInput.RC1;
        xunit3 = PDFFunctions.pages[SAPInput.k].Width;
        double point356 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[SAPInput.k].Height;
        double num409 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect356 = new XRect(200.0, rc1_349, point356, num409);
        XStringFormat topLeft356 = XStringFormat.TopLeft;
        xgraphics356.DrawString(str176, xfont356, (XBrush) black349, xrect356, topLeft356);
        checked { SAPInput.RC1 += 12; }
        SAPInput.CheckRC1();
      }
      try
      {
        // ISSUE: reference to a compiler-generated field
        if ((uint) Operators.CompareString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.Boiler.LoadWeatherType, "", false) > 0U)
        {
          XGraphics xgraphics357 = PDFFunctions.gfx[SAPInput.k];
          // ISSUE: reference to a compiler-generated field
          string loadWeatherType = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.Boiler.LoadWeatherType;
          XFont xfont357 = xfont3;
          XSolidBrush black350 = XBrushes.Black;
          double rc1_350 = (double) SAPInput.RC1;
          xunit3 = PDFFunctions.pages[SAPInput.k].Width;
          double point357 = ((XUnit) ref xunit3).Point;
          xunit3 = PDFFunctions.pages[SAPInput.k].Height;
          double num410 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect357 = new XRect(200.0, rc1_350, point357, num410);
          XStringFormat topLeft357 = XStringFormat.TopLeft;
          xgraphics357.DrawString(loadWeatherType, xfont357, (XBrush) black350, xrect357, topLeft357);
          checked { SAPInput.RC1 += 14; }
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          if ((uint) Operators.CompareString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.Compensator, "", false) > 0U)
          {
            XGraphics xgraphics358 = PDFFunctions.gfx[SAPInput.k];
            // ISSUE: reference to a compiler-generated field
            string compensator = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.Compensator;
            XFont xfont358 = xfont3;
            XSolidBrush black351 = XBrushes.Black;
            double rc1_351 = (double) SAPInput.RC1;
            xunit3 = PDFFunctions.pages[SAPInput.k].Width;
            double point358 = ((XUnit) ref xunit3).Point;
            xunit3 = PDFFunctions.pages[SAPInput.k].Height;
            double num411 = ((XUnit) ref xunit3).Point / 2.0;
            XRect xrect358 = new XRect(200.0, rc1_351, point358, num411);
            XStringFormat topLeft358 = XStringFormat.TopLeft;
            xgraphics358.DrawString(compensator, xfont358, (XBrush) black351, xrect358, topLeft358);
            checked { SAPInput.RC1 += 14; }
            SAPInput.CheckRC1();
          }
          else
          {
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            if (!string.IsNullOrEmpty(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.ControlCodePCDFWeather) & SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.Boiler.LoadWeather)
            {
              XGraphics xgraphics359 = PDFFunctions.gfx[SAPInput.k];
              XFont xfont359 = xfont3;
              XSolidBrush black352 = XBrushes.Black;
              double rc1_352 = (double) SAPInput.RC1;
              xunit3 = PDFFunctions.pages[SAPInput.k].Width;
              double point359 = ((XUnit) ref xunit3).Point;
              xunit3 = PDFFunctions.pages[SAPInput.k].Height;
              double num412 = ((XUnit) ref xunit3).Point / 2.0;
              XRect xrect359 = new XRect(200.0, rc1_352, point359, num412);
              XStringFormat topLeft359 = XStringFormat.TopLeft;
              xgraphics359.DrawString("Weather Compensator", xfont359, (XBrush) black352, xrect359, topLeft359);
              checked { SAPInput.RC1 += 14; }
              SAPInput.CheckRC1();
            }
          }
        }
      }
      catch (Exception ex)
      {
        int lErl = num30;
        ProjectData.SetProjectError(ex, lErl);
        ProjectData.ClearProjectError();
      }
      try
      {
        // ISSUE: reference to a compiler-generated field
        if (SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.Boiler.IncludeKeepHot)
        {
          XGraphics xgraphics360 = PDFFunctions.gfx[SAPInput.k];
          // ISSUE: reference to a compiler-generated field
          string str177 = "Keep hot Facility " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.Boiler.KeepHotTimed);
          XFont xfont360 = xfont3;
          XSolidBrush black353 = XBrushes.Black;
          double rc1_353 = (double) SAPInput.RC1;
          XUnit xunit5 = PDFFunctions.pages[SAPInput.k].Width;
          double point360 = ((XUnit) ref xunit5).Point;
          xunit5 = PDFFunctions.pages[SAPInput.k].Height;
          double num413 = ((XUnit) ref xunit5).Point / 2.0;
          XRect xrect360 = new XRect(200.0, rc1_353, point360, num413);
          XStringFormat topLeft360 = XStringFormat.TopLeft;
          xgraphics360.DrawString(str177, xfont360, (XBrush) black353, xrect360, topLeft360);
          checked { SAPInput.RC1 += 12; }
          XGraphics xgraphics361 = PDFFunctions.gfx[SAPInput.k];
          // ISSUE: reference to a compiler-generated field
          string str178 = "Keep hot Facility (Fuel used) " + SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.Boiler.KeepHotFuel;
          XFont xfont361 = xfont3;
          XSolidBrush black354 = XBrushes.Black;
          double rc1_354 = (double) SAPInput.RC1;
          xunit5 = PDFFunctions.pages[SAPInput.k].Width;
          double point361 = ((XUnit) ref xunit5).Point;
          xunit5 = PDFFunctions.pages[SAPInput.k].Height;
          double num414 = ((XUnit) ref xunit5).Point / 2.0;
          XRect xrect361 = new XRect(200.0, rc1_354, point361, num414);
          XStringFormat topLeft361 = XStringFormat.TopLeft;
          xgraphics361.DrawString(str178, xfont361, (XBrush) black354, xrect361, topLeft361);
          checked { SAPInput.RC1 += 14; }
          SAPInput.CheckRC1();
        }
      }
      catch (Exception ex)
      {
        int lErl = num30;
        ProjectData.SetProjectError(ex, lErl);
        ProjectData.ClearProjectError();
      }
      try
      {
        // ISSUE: reference to a compiler-generated field
        if (SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.DelayedStart)
        {
          XGraphics xgraphics362 = PDFFunctions.gfx[SAPInput.k];
          XFont xfont362 = xfont3;
          XSolidBrush black355 = XBrushes.Black;
          double rc1_355 = (double) SAPInput.RC1;
          XUnit xunit6 = PDFFunctions.pages[SAPInput.k].Width;
          double point362 = ((XUnit) ref xunit6).Point;
          xunit6 = PDFFunctions.pages[SAPInput.k].Height;
          double num415 = ((XUnit) ref xunit6).Point / 2.0;
          XRect xrect362 = new XRect(200.0, rc1_355, point362, num415);
          XStringFormat topLeft362 = XStringFormat.TopLeft;
          xgraphics362.DrawString("Delayed start ", xfont362, (XBrush) black355, xrect362, topLeft362);
          checked { SAPInput.RC1 += 14; }
          SAPInput.CheckRC1();
        }
      }
      catch (Exception ex)
      {
        int lErl = num30;
        ProjectData.SetProjectError(ex, lErl);
        ProjectData.ClearProjectError();
      }
      XUnit xunit7;
      // ISSUE: reference to a compiler-generated field
      if (SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.MCSCert)
      {
        XGraphics xgraphics363 = PDFFunctions.gfx[SAPInput.k];
        XFont xfont363 = xfont3;
        XSolidBrush black356 = XBrushes.Black;
        double rc1_356 = (double) SAPInput.RC1;
        xunit7 = PDFFunctions.pages[SAPInput.k].Width;
        double point363 = ((XUnit) ref xunit7).Point;
        xunit7 = PDFFunctions.pages[SAPInput.k].Height;
        double num416 = ((XUnit) ref xunit7).Point / 2.0;
        XRect xrect363 = new XRect(200.0, rc1_356, point363, num416);
        XStringFormat topLeft363 = XStringFormat.TopLeft;
        xgraphics363.DrawString("MCS Installation Certificate", xfont363, (XBrush) black356, xrect363, topLeft363);
        checked { SAPInput.RC1 += 14; }
        SAPInput.CheckRC1();
      }
      PDFFunctions.xBrush1 = XBrush.op_Implicit((Brush) new SolidBrush(Color.FromArgb(159, 172, 62)));
      PDFFunctions.Points[0].X = 20f;
      PDFFunctions.Points[0].Y = (float) SAPInput.RC1;
      ref PointF local15 = ref PDFFunctions.Points[1];
      xunit7 = PDFFunctions.pages[SAPInput.k].Width;
      double num417 = ((XUnit) ref xunit7).Point - 20.0;
      local15.X = (float) num417;
      PDFFunctions.Points[1].Y = (float) SAPInput.RC1;
      ref PointF local16 = ref PDFFunctions.Points[2];
      xunit7 = PDFFunctions.pages[SAPInput.k].Width;
      double num418 = ((XUnit) ref xunit7).Point - 20.0;
      local16.X = (float) num418;
      PDFFunctions.Points[2].Y = (float) checked (SAPInput.RC1 + 14);
      PDFFunctions.Points[3].X = 20f;
      PDFFunctions.Points[3].Y = (float) checked (SAPInput.RC1 + 14);
      PDFFunctions.gfx[SAPInput.k].DrawPolygon(PDFFunctions.polyGreen2, PDFFunctions.xBrush1, PDFFunctions.Points, xfillMode);
      XGraphics xgraphics364 = PDFFunctions.gfx[SAPInput.k];
      XFont xfont364 = xfont3;
      XSolidBrush white8 = XBrushes.White;
      double num419 = (double) checked (SAPInput.RC1 + 1);
      xunit7 = PDFFunctions.pages[SAPInput.k].Width;
      double point364 = ((XUnit) ref xunit7).Point;
      xunit7 = PDFFunctions.pages[SAPInput.k].Height;
      double num420 = ((XUnit) ref xunit7).Point / 2.0;
      XRect xrect364 = new XRect(25.0, num419, point364, num420);
      XStringFormat topLeft364 = XStringFormat.TopLeft;
      xgraphics364.DrawString("Main heating Control:", xfont364, (XBrush) white8, xrect364, topLeft364);
      SAPInput.RC1 = checked ((int) Math.Round(unchecked ((double) PDFFunctions.Points[3].Y + 4.0)));
      SAPInput.CheckRC1();
      XGraphics xgraphics365 = PDFFunctions.gfx[SAPInput.k];
      XFont xfont365 = xfont2;
      XSolidBrush black357 = XBrushes.Black;
      double rc1_357 = (double) SAPInput.RC1;
      xunit7 = PDFFunctions.pages[SAPInput.k].Width;
      double point365 = ((XUnit) ref xunit7).Point;
      xunit7 = PDFFunctions.pages[SAPInput.k].Height;
      double num421 = ((XUnit) ref xunit7).Point / 2.0;
      XRect xrect365 = new XRect(20.0, rc1_357, point365, num421);
      XStringFormat topLeft365 = XStringFormat.TopLeft;
      xgraphics365.DrawString("Main heating Control: ", xfont365, (XBrush) black357, xrect365, topLeft365);
      try
      {
        // ISSUE: reference to a compiler-generated field
        string[] strArray = SAPInput.CheckTextWidth2(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.Controls, 200);
        if (strArray != null)
        {
          if (strArray[0].Length == 0)
          {
            // ISSUE: reference to a compiler-generated field
            strArray[0] = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.Controls;
          }
          int num422 = checked (strArray.Length - 1);
          int index23 = 0;
          while (index23 <= num422)
          {
            if ((uint) Operators.CompareString(strArray[index23], "", false) > 0U)
            {
              XGraphics xgraphics366 = PDFFunctions.gfx[SAPInput.k];
              string str179 = strArray[index23];
              XFont xfont366 = xfont3;
              XSolidBrush black358 = XBrushes.Black;
              double rc1_358 = (double) SAPInput.RC1;
              xunit7 = PDFFunctions.pages[SAPInput.k].Width;
              double point366 = ((XUnit) ref xunit7).Point;
              xunit7 = PDFFunctions.pages[SAPInput.k].Height;
              double num423 = ((XUnit) ref xunit7).Point / 2.0;
              XRect xrect366 = new XRect(200.0, rc1_358, point366, num423);
              XStringFormat topLeft366 = XStringFormat.TopLeft;
              xgraphics366.DrawString(str179, xfont366, (XBrush) black358, xrect366, topLeft366);
              checked { SAPInput.RC1 += 12; }
              SAPInput.CheckRC1();
            }
            checked { ++index23; }
          }
        }
      }
      catch (Exception ex)
      {
        int lErl = num30;
        ProjectData.SetProjectError(ex, lErl);
        ProjectData.ClearProjectError();
      }
      XGraphics xgraphics367 = PDFFunctions.gfx[SAPInput.k];
      // ISSUE: reference to a compiler-generated field
      string str180 = "Control code: " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.ControlCode);
      XFont xfont367 = xfont3;
      XSolidBrush black359 = XBrushes.Black;
      double rc1_359 = (double) SAPInput.RC1;
      XUnit xunit8 = PDFFunctions.pages[SAPInput.k].Width;
      double point367 = ((XUnit) ref xunit8).Point;
      xunit8 = PDFFunctions.pages[SAPInput.k].Height;
      double num424 = ((XUnit) ref xunit8).Point / 2.0;
      XRect xrect367 = new XRect(200.0, rc1_359, point367, num424);
      XStringFormat topLeft367 = XStringFormat.TopLeft;
      xgraphics367.DrawString(str180, xfont367, (XBrush) black359, xrect367, topLeft367);
      checked { SAPInput.RC1 += 14; }
      SAPInput.CheckRC1();
      // ISSUE: reference to a compiler-generated field
      if (SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].IncludeMainHeating2)
      {
        PDFFunctions.xBrush1 = XBrush.op_Implicit((Brush) new SolidBrush(Color.FromArgb(159, 172, 62)));
        PDFFunctions.Points[0].X = 20f;
        PDFFunctions.Points[0].Y = (float) SAPInput.RC1;
        ref PointF local17 = ref PDFFunctions.Points[1];
        xunit8 = PDFFunctions.pages[SAPInput.k].Width;
        double num425 = ((XUnit) ref xunit8).Point - 20.0;
        local17.X = (float) num425;
        PDFFunctions.Points[1].Y = (float) SAPInput.RC1;
        ref PointF local18 = ref PDFFunctions.Points[2];
        xunit8 = PDFFunctions.pages[SAPInput.k].Width;
        double num426 = ((XUnit) ref xunit8).Point - 20.0;
        local18.X = (float) num426;
        PDFFunctions.Points[2].Y = (float) checked (SAPInput.RC1 + 14);
        PDFFunctions.Points[3].X = 20f;
        PDFFunctions.Points[3].Y = (float) checked (SAPInput.RC1 + 14);
        PDFFunctions.gfx[SAPInput.k].DrawPolygon(PDFFunctions.polyGreen2, PDFFunctions.xBrush1, PDFFunctions.Points, xfillMode);
        XGraphics xgraphics368 = PDFFunctions.gfx[SAPInput.k];
        XFont xfont368 = xfont3;
        XSolidBrush white9 = XBrushes.White;
        double num427 = (double) checked (SAPInput.RC1 + 1);
        xunit8 = PDFFunctions.pages[SAPInput.k].Width;
        double point368 = ((XUnit) ref xunit8).Point;
        xunit8 = PDFFunctions.pages[SAPInput.k].Height;
        double num428 = ((XUnit) ref xunit8).Point / 2.0;
        XRect xrect368 = new XRect(25.0, num427, point368, num428);
        XStringFormat topLeft368 = XStringFormat.TopLeft;
        xgraphics368.DrawString("Secondary Main heating system:", xfont368, (XBrush) white9, xrect368, topLeft368);
        SAPInput.RC1 = checked ((int) Math.Round(unchecked ((double) PDFFunctions.Points[3].Y + 4.0)));
        SAPInput.CheckRC1();
        XGraphics xgraphics369 = PDFFunctions.gfx[SAPInput.k];
        XFont xfont369 = xfont2;
        XSolidBrush black360 = XBrushes.Black;
        double rc1_360 = (double) SAPInput.RC1;
        xunit8 = PDFFunctions.pages[SAPInput.k].Width;
        double point369 = ((XUnit) ref xunit8).Point;
        xunit8 = PDFFunctions.pages[SAPInput.k].Height;
        double num429 = ((XUnit) ref xunit8).Point / 2.0;
        XRect xrect369 = new XRect(20.0, rc1_360, point369, num429);
        XStringFormat topLeft369 = XStringFormat.TopLeft;
        xgraphics369.DrawString("Secondary Main heating system: ", xfont369, (XBrush) black360, xrect369, topLeft369);
        XGraphics xgraphics370 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string hgroup2 = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.HGroup;
        XFont xfont370 = xfont3;
        XSolidBrush black361 = XBrushes.Black;
        double rc1_361 = (double) SAPInput.RC1;
        xunit8 = PDFFunctions.pages[SAPInput.k].Width;
        double point370 = ((XUnit) ref xunit8).Point;
        xunit8 = PDFFunctions.pages[SAPInput.k].Height;
        double num430 = ((XUnit) ref xunit8).Point / 2.0;
        XRect xrect370 = new XRect(200.0, rc1_361, point370, num430);
        XStringFormat topLeft370 = XStringFormat.TopLeft;
        xgraphics370.DrawString(hgroup2, xfont370, (XBrush) black361, xrect370, topLeft370);
        checked { SAPInput.RC1 += 12; }
        // ISSUE: reference to a compiler-generated field
        if ((uint) Operators.CompareString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.HGroup, "Community heating schemes", false) > 0U)
        {
          XGraphics xgraphics371 = PDFFunctions.gfx[SAPInput.k];
          // ISSUE: reference to a compiler-generated field
          string sgroup = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.SGroup;
          XFont xfont371 = xfont3;
          XSolidBrush black362 = XBrushes.Black;
          double rc1_362 = (double) SAPInput.RC1;
          xunit8 = PDFFunctions.pages[SAPInput.k].Width;
          double point371 = ((XUnit) ref xunit8).Point;
          xunit8 = PDFFunctions.pages[SAPInput.k].Height;
          double num431 = ((XUnit) ref xunit8).Point / 2.0;
          XRect xrect371 = new XRect(200.0, rc1_362, point371, num431);
          XStringFormat topLeft371 = XStringFormat.TopLeft;
          xgraphics371.DrawString(sgroup, xfont371, (XBrush) black362, xrect371, topLeft371);
          checked { SAPInput.RC1 += 12; }
          XGraphics xgraphics372 = PDFFunctions.gfx[SAPInput.k];
          // ISSUE: reference to a compiler-generated field
          string str181 = "Fuel: " + SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.Fuel;
          XFont xfont372 = xfont3;
          XSolidBrush black363 = XBrushes.Black;
          double rc1_363 = (double) SAPInput.RC1;
          xunit8 = PDFFunctions.pages[SAPInput.k].Width;
          double point372 = ((XUnit) ref xunit8).Point;
          xunit8 = PDFFunctions.pages[SAPInput.k].Height;
          double num432 = ((XUnit) ref xunit8).Point / 2.0;
          XRect xrect372 = new XRect(200.0, rc1_363, point372, num432);
          XStringFormat topLeft372 = XStringFormat.TopLeft;
          xgraphics372.DrawString(str181, xfont372, (XBrush) black363, xrect372, topLeft372);
          checked { SAPInput.RC1 += 12; }
          XGraphics xgraphics373 = PDFFunctions.gfx[SAPInput.k];
          // ISSUE: reference to a compiler-generated field
          string str182 = "Info Source: " + SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.InforSource;
          XFont xfont373 = xfont3;
          XSolidBrush black364 = XBrushes.Black;
          double rc1_364 = (double) SAPInput.RC1;
          xunit8 = PDFFunctions.pages[SAPInput.k].Width;
          double point373 = ((XUnit) ref xunit8).Point;
          xunit8 = PDFFunctions.pages[SAPInput.k].Height;
          double num433 = ((XUnit) ref xunit8).Point / 2.0;
          XRect xrect373 = new XRect(200.0, rc1_364, point373, num433);
          XStringFormat topLeft373 = XStringFormat.TopLeft;
          xgraphics373.DrawString(str182, xfont373, (XBrush) black364, xrect373, topLeft373);
          checked { SAPInput.RC1 += 12; }
          SAPInput.CheckRC1();
          // ISSUE: reference to a compiler-generated field
          if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.InforSource, "Boiler Database", false) == 0)
          {
            string str183 = "";
            string str184 = "";
            string str185 = "";
            string str186 = "";
            string Left = "";
            string sapEff;
            string summerEff;
            string winterEff;
            // ISSUE: reference to a compiler-generated field
            if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.SGroup, "Gas boilers and oil boilers", false) == 0)
            {
              // ISSUE: reference to a compiler-generated method
              PCDF.SEDBUK sedbuk = SAP_Module.PCDFData.Boilers.Where<PCDF.SEDBUK>(new Func<PCDF.SEDBUK, bool>(closure160_2._Lambda\u0024__14)).SingleOrDefault<PCDF.SEDBUK>();
              if (sedbuk != null)
              {
                str183 = sedbuk.BrandName;
                str185 = sedbuk.ModelName;
                str184 = sedbuk.ModelQualifier;
                sapEff = sedbuk.SAPEff;
                summerEff = sedbuk.SummerEff;
                winterEff = sedbuk.WinterEff;
                Left = sedbuk.ProductType;
                double num434 = Conversion.Val(sedbuk.MainType);
                if (num434 == 0.0)
                  str186 = "Unknown";
                else if (num434 == 1.0)
                  str186 = "Regular";
                else if (num434 == 2.0)
                  str186 = "Combi";
                else if (num434 == 3.0)
                  str186 = "CPSU";
              }
            }
            else
            {
              // ISSUE: reference to a compiler-generated field
              if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.SGroup, "Micro-cogeneration (micro-CHP)", false) == 0)
              {
                // ISSUE: reference to a compiler-generated method
                PCDF.CHP chp = SAP_Module.PCDFData.CHPs.Where<PCDF.CHP>(new Func<PCDF.CHP, bool>(closure160_2._Lambda\u0024__15)).SingleOrDefault<PCDF.CHP>();
                if (chp != null)
                {
                  str183 = chp.Brand;
                  str185 = chp.Model;
                  str184 = chp.Qualifier;
                  Left = chp.ProductType;
                }
              }
              else
              {
                // ISSUE: reference to a compiler-generated field
                if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.SGroup, "Solid fuel boilers", false) == 0)
                {
                  // ISSUE: reference to a compiler-generated method
                  PCDF.SEDBUK_Solid sedbukSolid = SAP_Module.PCDFData.Solid_Boilers.Where<PCDF.SEDBUK_Solid>(new Func<PCDF.SEDBUK_Solid, bool>(closure160_2._Lambda\u0024__16)).SingleOrDefault<PCDF.SEDBUK_Solid>();
                  if (sedbukSolid != null)
                  {
                    str183 = sedbukSolid.BrandName;
                    str185 = sedbukSolid.ModelName;
                    str184 = sedbukSolid.ModelQualifier;
                    Left = sedbukSolid.ProductType;
                    double num435 = Conversion.Val(sedbukSolid.MainType);
                    if (num435 == 0.0)
                      str186 = "Unknown";
                    else if (num435 == 1.0)
                      str186 = "Regular";
                    else if (num435 == 2.0)
                      str186 = "Combi";
                    else if (num435 == 3.0)
                      str186 = "CPSU";
                    sapEff = Conversions.ToString(Math.Round(SAP_Module.Calculation2012.Calculation.Energy_Requirements_9a.Box206));
                  }
                }
                else
                {
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.SGroup, "Gas-fired heat pumps", false) == 0 | Operators.CompareString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.SGroup, "Electric heat pumps", false) == 0)
                  {
                    // ISSUE: reference to a compiler-generated method
                    PCDF.HeatPump heatPump = SAP_Module.PCDFData.HeatPumps.Where<PCDF.HeatPump>(new Func<PCDF.HeatPump, bool>(closure160_2._Lambda\u0024__17)).SingleOrDefault<PCDF.HeatPump>();
                    if (heatPump != null)
                    {
                      str183 = heatPump.Brand;
                      str185 = heatPump.Model;
                      str184 = heatPump.Qualifier;
                      Left = heatPump.PropertyType;
                      sapEff = Conversions.ToString(Math.Round(SAP_Module.Calculation2012.Calculation.Energy_Requirements_9a.Box206));
                    }
                  }
                }
              }
            }
            // ISSUE: reference to a compiler-generated field
            if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.SGroup, "Micro-cogeneration (micro-CHP)", false) == 0)
            {
              XGraphics xgraphics374 = PDFFunctions.gfx[SAPInput.k];
              // ISSUE: reference to a compiler-generated field
              string str187 = "Database: (rev " + Conversions.ToString(SAP_Module.DataBVersion) + ", product index " + SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.SEDBUK + "):";
              XFont xfont374 = xfont3;
              XSolidBrush black365 = XBrushes.Black;
              double rc1_365 = (double) SAPInput.RC1;
              xunit8 = PDFFunctions.pages[SAPInput.k].Width;
              double point374 = ((XUnit) ref xunit8).Point;
              xunit8 = PDFFunctions.pages[SAPInput.k].Height;
              double num436 = ((XUnit) ref xunit8).Point / 2.0;
              XRect xrect374 = new XRect(200.0, rc1_365, point374, num436);
              XStringFormat topLeft374 = XStringFormat.TopLeft;
              xgraphics374.DrawString(str187, xfont374, (XBrush) black365, xrect374, topLeft374);
            }
            else
            {
              // ISSUE: reference to a compiler-generated field
              if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.SGroup, "Gas boilers and oil boilers", false) == 0)
              {
                XGraphics xgraphics375 = PDFFunctions.gfx[SAPInput.k];
                // ISSUE: reference to a compiler-generated field
                string str188 = "Database: (rev " + Conversions.ToString(SAP_Module.DataBVersion) + ", product index " + SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.SEDBUK + ") Efficiency: Winter  " + summerEff + " %  Summer: " + winterEff;
                XFont xfont375 = xfont3;
                XSolidBrush black366 = XBrushes.Black;
                double rc1_366 = (double) SAPInput.RC1;
                xunit8 = PDFFunctions.pages[SAPInput.k].Width;
                double point375 = ((XUnit) ref xunit8).Point;
                xunit8 = PDFFunctions.pages[SAPInput.k].Height;
                double num437 = ((XUnit) ref xunit8).Point / 2.0;
                XRect xrect375 = new XRect(200.0, rc1_366, point375, num437);
                XStringFormat topLeft375 = XStringFormat.TopLeft;
                xgraphics375.DrawString(str188, xfont375, (XBrush) black366, xrect375, topLeft375);
              }
              else
              {
                XGraphics xgraphics376 = PDFFunctions.gfx[SAPInput.k];
                // ISSUE: reference to a compiler-generated field
                string str189 = "Database: (rev " + Conversions.ToString(SAP_Module.DataBVersion) + ", product index " + SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.SEDBUK + ", SEDBUK " + sapEff + "%):";
                XFont xfont376 = xfont3;
                XSolidBrush black367 = XBrushes.Black;
                double rc1_367 = (double) SAPInput.RC1;
                xunit8 = PDFFunctions.pages[SAPInput.k].Width;
                double point376 = ((XUnit) ref xunit8).Point;
                xunit8 = PDFFunctions.pages[SAPInput.k].Height;
                double num438 = ((XUnit) ref xunit8).Point / 2.0;
                XRect xrect376 = new XRect(200.0, rc1_367, point376, num438);
                XStringFormat topLeft376 = XStringFormat.TopLeft;
                xgraphics376.DrawString(str189, xfont376, (XBrush) black367, xrect376, topLeft376);
              }
            }
            checked { SAPInput.RC1 += 12; }
            XGraphics xgraphics377 = PDFFunctions.gfx[SAPInput.k];
            string str190 = "Band name: " + str183;
            XFont xfont377 = xfont3;
            XSolidBrush black368 = XBrushes.Black;
            double rc1_368 = (double) SAPInput.RC1;
            xunit8 = PDFFunctions.pages[SAPInput.k].Width;
            double point377 = ((XUnit) ref xunit8).Point;
            xunit8 = PDFFunctions.pages[SAPInput.k].Height;
            double num439 = ((XUnit) ref xunit8).Point / 2.0;
            XRect xrect377 = new XRect(200.0, rc1_368, point377, num439);
            XStringFormat topLeft377 = XStringFormat.TopLeft;
            xgraphics377.DrawString(str190, xfont377, (XBrush) black368, xrect377, topLeft377);
            checked { SAPInput.RC1 += 12; }
            if (Operators.CompareString(Left, "2", false) == 0)
            {
              XGraphics xgraphics378 = PDFFunctions.gfx[SAPInput.k];
              string str191 = "Model: " + str185 + " (Under Investigation)";
              XFont xfont378 = xfont3;
              XSolidBrush black369 = XBrushes.Black;
              double rc1_369 = (double) SAPInput.RC1;
              xunit8 = PDFFunctions.pages[SAPInput.k].Width;
              double point378 = ((XUnit) ref xunit8).Point;
              xunit8 = PDFFunctions.pages[SAPInput.k].Height;
              double num440 = ((XUnit) ref xunit8).Point / 2.0;
              XRect xrect378 = new XRect(200.0, rc1_369, point378, num440);
              XStringFormat topLeft378 = XStringFormat.TopLeft;
              xgraphics378.DrawString(str191, xfont378, (XBrush) black369, xrect378, topLeft378);
            }
            else if (Operators.CompareString(Left, "4", false) == 0)
            {
              XGraphics xgraphics379 = PDFFunctions.gfx[SAPInput.k];
              string str192 = "Model: " + str185 + " (Methodology under review)";
              XFont xfont379 = xfont3;
              XSolidBrush black370 = XBrushes.Black;
              double rc1_370 = (double) SAPInput.RC1;
              xunit8 = PDFFunctions.pages[SAPInput.k].Width;
              double point379 = ((XUnit) ref xunit8).Point;
              xunit8 = PDFFunctions.pages[SAPInput.k].Height;
              double num441 = ((XUnit) ref xunit8).Point / 2.0;
              XRect xrect379 = new XRect(200.0, rc1_370, point379, num441);
              XStringFormat topLeft379 = XStringFormat.TopLeft;
              xgraphics379.DrawString(str192, xfont379, (XBrush) black370, xrect379, topLeft379);
            }
            else
            {
              XGraphics xgraphics380 = PDFFunctions.gfx[SAPInput.k];
              string str193 = "Model: " + str185;
              XFont xfont380 = xfont3;
              XSolidBrush black371 = XBrushes.Black;
              double rc1_371 = (double) SAPInput.RC1;
              xunit8 = PDFFunctions.pages[SAPInput.k].Width;
              double point380 = ((XUnit) ref xunit8).Point;
              xunit8 = PDFFunctions.pages[SAPInput.k].Height;
              double num442 = ((XUnit) ref xunit8).Point / 2.0;
              XRect xrect380 = new XRect(200.0, rc1_371, point380, num442);
              XStringFormat topLeft380 = XStringFormat.TopLeft;
              xgraphics380.DrawString(str193, xfont380, (XBrush) black371, xrect380, topLeft380);
            }
            checked { SAPInput.RC1 += 12; }
            XGraphics xgraphics381 = PDFFunctions.gfx[SAPInput.k];
            string str194 = "Model qualifier: " + str184;
            XFont xfont381 = xfont3;
            XSolidBrush black372 = XBrushes.Black;
            double rc1_372 = (double) SAPInput.RC1;
            xunit8 = PDFFunctions.pages[SAPInput.k].Width;
            double point381 = ((XUnit) ref xunit8).Point;
            xunit8 = PDFFunctions.pages[SAPInput.k].Height;
            double num443 = ((XUnit) ref xunit8).Point / 2.0;
            XRect xrect381 = new XRect(200.0, rc1_372, point381, num443);
            XStringFormat topLeft381 = XStringFormat.TopLeft;
            xgraphics381.DrawString(str194, xfont381, (XBrush) black372, xrect381, topLeft381);
            checked { SAPInput.RC1 += 12; }
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.SGroup, "Micro-cogeneration (micro-CHP)", false) == 0 | Operators.CompareString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.SGroup, "Gas-fired heat pumps", false) == 0 | Operators.CompareString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.SGroup, "Electric heat pumps", false) == 0)
            {
              XGraphics xgraphics382 = PDFFunctions.gfx[SAPInput.k];
              XFont xfont382 = xfont3;
              XSolidBrush black373 = XBrushes.Black;
              double rc1_373 = (double) SAPInput.RC1;
              xunit8 = PDFFunctions.pages[SAPInput.k].Width;
              double point382 = ((XUnit) ref xunit8).Point;
              xunit8 = PDFFunctions.pages[SAPInput.k].Height;
              double num444 = ((XUnit) ref xunit8).Point / 2.0;
              XRect xrect382 = new XRect(200.0, rc1_373, point382, num444);
              XStringFormat topLeft382 = XStringFormat.TopLeft;
              xgraphics382.DrawString("(provides DHW all year)", xfont382, (XBrush) black373, xrect382, topLeft382);
            }
            else
            {
              XGraphics xgraphics383 = PDFFunctions.gfx[SAPInput.k];
              string str195 = "(" + str186 + " boiler)";
              XFont xfont383 = xfont3;
              XSolidBrush black374 = XBrushes.Black;
              double rc1_374 = (double) SAPInput.RC1;
              xunit8 = PDFFunctions.pages[SAPInput.k].Width;
              double point383 = ((XUnit) ref xunit8).Point;
              xunit8 = PDFFunctions.pages[SAPInput.k].Height;
              double num445 = ((XUnit) ref xunit8).Point / 2.0;
              XRect xrect383 = new XRect(200.0, rc1_374, point383, num445);
              XStringFormat topLeft383 = XStringFormat.TopLeft;
              xgraphics383.DrawString(str195, xfont383, (XBrush) black374, xrect383, topLeft383);
            }
          }
          else
          {
            // ISSUE: reference to a compiler-generated field
            if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.InforSource, "Manufacturer Declaration", false) == 0)
            {
              XGraphics xgraphics384 = PDFFunctions.gfx[SAPInput.k];
              XFont xfont384 = xfont3;
              XSolidBrush black375 = XBrushes.Black;
              double rc1_375 = (double) SAPInput.RC1;
              xunit8 = PDFFunctions.pages[SAPInput.k].Width;
              double point384 = ((XUnit) ref xunit8).Point;
              xunit8 = PDFFunctions.pages[SAPInput.k].Height;
              double num446 = ((XUnit) ref xunit8).Point / 2.0;
              XRect xrect384 = new XRect(200.0, rc1_375, point384, num446);
              XStringFormat topLeft384 = XStringFormat.TopLeft;
              xgraphics384.DrawString("Manufacturer's data", xfont384, (XBrush) black375, xrect384, topLeft384);
              checked { SAPInput.RC1 += 12; }
              // ISSUE: reference to a compiler-generated field
              if (SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.SAPTableCode < 142)
              {
                // ISSUE: reference to a compiler-generated field
                if (SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.SEDBUK2005)
                {
                  XGraphics xgraphics385 = PDFFunctions.gfx[SAPInput.k];
                  // ISSUE: reference to a compiler-generated field
                  string str196 = "Efficiency: " + Microsoft.VisualBasic.Strings.Format((object) SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.MainEff, "#0.0") + "% (SEDBUK2005)";
                  XFont xfont385 = xfont3;
                  XSolidBrush black376 = XBrushes.Black;
                  double rc1_376 = (double) SAPInput.RC1;
                  xunit8 = PDFFunctions.pages[SAPInput.k].Width;
                  double point385 = ((XUnit) ref xunit8).Point;
                  xunit8 = PDFFunctions.pages[SAPInput.k].Height;
                  double num447 = ((XUnit) ref xunit8).Point / 2.0;
                  XRect xrect385 = new XRect(200.0, rc1_376, point385, num447);
                  XStringFormat topLeft385 = XStringFormat.TopLeft;
                  xgraphics385.DrawString(str196, xfont385, (XBrush) black376, xrect385, topLeft385);
                }
                else
                {
                  XGraphics xgraphics386 = PDFFunctions.gfx[SAPInput.k];
                  // ISSUE: reference to a compiler-generated field
                  string str197 = "Efficiency: " + Microsoft.VisualBasic.Strings.Format((object) SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.MainEff, "#0.0") + "% (SEDBUK2009)";
                  XFont xfont386 = xfont3;
                  XSolidBrush black377 = XBrushes.Black;
                  double rc1_377 = (double) SAPInput.RC1;
                  xunit8 = PDFFunctions.pages[SAPInput.k].Width;
                  double point386 = ((XUnit) ref xunit8).Point;
                  xunit8 = PDFFunctions.pages[SAPInput.k].Height;
                  double num448 = ((XUnit) ref xunit8).Point / 2.0;
                  XRect xrect386 = new XRect(200.0, rc1_377, point386, num448);
                  XStringFormat topLeft386 = XStringFormat.TopLeft;
                  xgraphics386.DrawString(str197, xfont386, (XBrush) black377, xrect386, topLeft386);
                }
              }
              else
              {
                XGraphics xgraphics387 = PDFFunctions.gfx[SAPInput.k];
                // ISSUE: reference to a compiler-generated field
                string str198 = "Efficiency: " + Microsoft.VisualBasic.Strings.Format((object) SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.MainEff, "#0.0") + "%";
                XFont xfont387 = xfont3;
                XSolidBrush black378 = XBrushes.Black;
                double rc1_378 = (double) SAPInput.RC1;
                xunit8 = PDFFunctions.pages[SAPInput.k].Width;
                double point387 = ((XUnit) ref xunit8).Point;
                xunit8 = PDFFunctions.pages[SAPInput.k].Height;
                double num449 = ((XUnit) ref xunit8).Point / 2.0;
                XRect xrect387 = new XRect(200.0, rc1_378, point387, num449);
                XStringFormat topLeft387 = XStringFormat.TopLeft;
                xgraphics387.DrawString(str198, xfont387, (XBrush) black378, xrect387, topLeft387);
              }
              checked { SAPInput.RC1 += 12; }
              XGraphics xgraphics388 = PDFFunctions.gfx[SAPInput.k];
              // ISSUE: reference to a compiler-generated field
              string mhType = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.MHType;
              XFont xfont388 = xfont3;
              XSolidBrush black379 = XBrushes.Black;
              double rc1_379 = (double) SAPInput.RC1;
              xunit8 = PDFFunctions.pages[SAPInput.k].Width;
              double point388 = ((XUnit) ref xunit8).Point;
              xunit8 = PDFFunctions.pages[SAPInput.k].Height;
              double num450 = ((XUnit) ref xunit8).Point / 2.0;
              XRect xrect388 = new XRect(200.0, rc1_379, point388, num450);
              XStringFormat topLeft388 = XStringFormat.TopLeft;
              xgraphics388.DrawString(mhType, xfont388, (XBrush) black379, xrect388, topLeft388);
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.Fuel, "mains gas", false) == 0 | SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.Fuel.Contains("LPG") && Operators.CompareString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.SGroup, "Gas boilers and oil boilers", false) == 0)
              {
                checked { SAPInput.RC1 += 12; }
                XGraphics xgraphics389 = PDFFunctions.gfx[SAPInput.k];
                // ISSUE: reference to a compiler-generated field
                string str199 = "Fuel Burning Type: " + SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.FuelBurningType;
                XFont xfont389 = xfont3;
                XSolidBrush black380 = XBrushes.Black;
                double rc1_380 = (double) SAPInput.RC1;
                xunit8 = PDFFunctions.pages[SAPInput.k].Width;
                double point389 = ((XUnit) ref xunit8).Point;
                xunit8 = PDFFunctions.pages[SAPInput.k].Height;
                double num451 = ((XUnit) ref xunit8).Point / 2.0;
                XRect xrect389 = new XRect(200.0, rc1_380, point389, num451);
                XStringFormat topLeft389 = XStringFormat.TopLeft;
                xgraphics389.DrawString(str199, xfont389, (XBrush) black380, xrect389, topLeft389);
              }
            }
            else
            {
              XGraphics xgraphics390 = PDFFunctions.gfx[SAPInput.k];
              // ISSUE: reference to a compiler-generated field
              string str200 = "SAP Table: " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.SAPTableCode);
              XFont xfont390 = xfont3;
              XSolidBrush black381 = XBrushes.Black;
              double rc1_381 = (double) SAPInput.RC1;
              xunit8 = PDFFunctions.pages[SAPInput.k].Width;
              double point390 = ((XUnit) ref xunit8).Point;
              xunit8 = PDFFunctions.pages[SAPInput.k].Height;
              double num452 = ((XUnit) ref xunit8).Point / 2.0;
              XRect xrect390 = new XRect(200.0, rc1_381, point390, num452);
              XStringFormat topLeft390 = XStringFormat.TopLeft;
              xgraphics390.DrawString(str200, xfont390, (XBrush) black381, xrect390, topLeft390);
              checked { SAPInput.RC1 += 12; }
              XGraphics xgraphics391 = PDFFunctions.gfx[SAPInput.k];
              // ISSUE: reference to a compiler-generated field
              string mhType = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.MHType;
              XFont xfont391 = xfont3;
              XSolidBrush black382 = XBrushes.Black;
              double rc1_382 = (double) SAPInput.RC1;
              xunit8 = PDFFunctions.pages[SAPInput.k].Width;
              double point391 = ((XUnit) ref xunit8).Point;
              xunit8 = PDFFunctions.pages[SAPInput.k].Height;
              double num453 = ((XUnit) ref xunit8).Point / 2.0;
              XRect xrect391 = new XRect(200.0, rc1_382, point391, num453);
              XStringFormat topLeft391 = XStringFormat.TopLeft;
              xgraphics391.DrawString(mhType, xfont391, (XBrush) black382, xrect391, topLeft391);
            }
          }
          checked { SAPInput.RC1 += 12; }
          XGraphics xgraphics392 = PDFFunctions.gfx[SAPInput.k];
          // ISSUE: reference to a compiler-generated field
          string emitter = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.Emitter;
          XFont xfont392 = xfont3;
          XSolidBrush black383 = XBrushes.Black;
          double rc1_383 = (double) SAPInput.RC1;
          xunit8 = PDFFunctions.pages[SAPInput.k].Width;
          double point392 = ((XUnit) ref xunit8).Point;
          xunit8 = PDFFunctions.pages[SAPInput.k].Height;
          double num454 = ((XUnit) ref xunit8).Point / 2.0;
          XRect xrect392 = new XRect(200.0, rc1_383, point392, num454);
          XStringFormat topLeft392 = XStringFormat.TopLeft;
          xgraphics392.DrawString(emitter, xfont392, (XBrush) black383, xrect392, topLeft392);
          SAPInput.CheckRC1();
          // ISSUE: reference to a compiler-generated field
          if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.HGroup, "Central heating systems with radiators or underfloor heating", false) == 0)
          {
            checked { SAPInput.RC1 += 12; }
            XGraphics xgraphics393 = PDFFunctions.gfx[SAPInput.k];
            // ISSUE: reference to a compiler-generated field
            string str201 = "Pump in heat space: " + SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.Boiler.PumpHP;
            XFont xfont393 = xfont3;
            XSolidBrush black384 = XBrushes.Black;
            double rc1_384 = (double) SAPInput.RC1;
            xunit8 = PDFFunctions.pages[SAPInput.k].Width;
            double point393 = ((XUnit) ref xunit8).Point;
            xunit8 = PDFFunctions.pages[SAPInput.k].Height;
            double num455 = ((XUnit) ref xunit8).Point / 2.0;
            XRect xrect393 = new XRect(200.0, rc1_384, point393, num455);
            XStringFormat topLeft393 = XStringFormat.TopLeft;
            xgraphics393.DrawString(str201, xfont393, (XBrush) black384, xrect393, topLeft393);
          }
        }
        else
        {
          List<PCDF.CommunityScheme_Sub> communitySchemeSubList = new List<PCDF.CommunityScheme_Sub>();
          // ISSUE: reference to a compiler-generated field
          if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.InforSource, "Boiler Database", false) == 0)
          {
            // ISSUE: reference to a compiler-generated field
            if ((uint) Operators.CompareString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.SEDBUK, "", false) > 0U)
            {
              // ISSUE: reference to a compiler-generated method
              communitySchemeSubList = SAP_Module.PCDFData.CommunitySchemes_Sub.Where<PCDF.CommunityScheme_Sub>(new Func<PCDF.CommunityScheme_Sub, bool>(closure160_2._Lambda\u0024__18)).ToList<PCDF.CommunityScheme_Sub>();
            }
            if (communitySchemeSubList.Count > 0)
            {
              XGraphics xgraphics394 = PDFFunctions.gfx[SAPInput.k];
              // ISSUE: reference to a compiler-generated field
              string str202 = "Database ( community network index " + SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.SEDBUK + "):";
              XFont xfont394 = xfont3;
              XSolidBrush black385 = XBrushes.Black;
              double rc1_385 = (double) SAPInput.RC1;
              xunit8 = PDFFunctions.pages[SAPInput.k].Width;
              double point394 = ((XUnit) ref xunit8).Point;
              xunit8 = PDFFunctions.pages[SAPInput.k].Height;
              double num456 = ((XUnit) ref xunit8).Point / 2.0;
              XRect xrect394 = new XRect(200.0, rc1_385, point394, num456);
              XStringFormat topLeft394 = XStringFormat.TopLeft;
              xgraphics394.DrawString(str202, xfont394, (XBrush) black385, xrect394, topLeft394);
              checked { SAPInput.RC1 += 12; }
              SAPInput.CheckRC1();
              // ISSUE: reference to a compiler-generated method
              PCDF.CommunityScheme communityScheme = SAP_Module.PCDFData.CommunitySchemes.Where<PCDF.CommunityScheme>(new Func<PCDF.CommunityScheme, bool>(closure160_2._Lambda\u0024__19)).SingleOrDefault<PCDF.CommunityScheme>();
              if (communityScheme != null)
              {
                XGraphics xgraphics395 = PDFFunctions.gfx[SAPInput.k];
                string str203 = "Brand name: " + communityScheme.CommunityHeatNetwork;
                XFont xfont395 = xfont3;
                XSolidBrush black386 = XBrushes.Black;
                double rc1_386 = (double) SAPInput.RC1;
                xunit8 = PDFFunctions.pages[SAPInput.k].Width;
                double point395 = ((XUnit) ref xunit8).Point;
                xunit8 = PDFFunctions.pages[SAPInput.k].Height;
                double num457 = ((XUnit) ref xunit8).Point / 2.0;
                XRect xrect395 = new XRect(200.0, rc1_386, point395, num457);
                XStringFormat topLeft395 = XStringFormat.TopLeft;
                xgraphics395.DrawString(str203, xfont395, (XBrush) black386, xrect395, topLeft395);
                checked { SAPInput.RC1 += 12; }
                XGraphics xgraphics396 = PDFFunctions.gfx[SAPInput.k];
                string str204 = "Postcode: " + communityScheme.PostcodeEnergyCentre;
                XFont xfont396 = xfont3;
                XSolidBrush black387 = XBrushes.Black;
                double rc1_387 = (double) SAPInput.RC1;
                xunit8 = PDFFunctions.pages[SAPInput.k].Width;
                double point396 = ((XUnit) ref xunit8).Point;
                xunit8 = PDFFunctions.pages[SAPInput.k].Height;
                double num458 = ((XUnit) ref xunit8).Point / 2.0;
                XRect xrect396 = new XRect(200.0, rc1_387, point396, num458);
                XStringFormat topLeft396 = XStringFormat.TopLeft;
                xgraphics396.DrawString(str204, xfont396, (XBrush) black387, xrect396, topLeft396);
                checked { SAPInput.RC1 += 12; }
                XGraphics xgraphics397 = PDFFunctions.gfx[SAPInput.k];
                string str205 = "Network Version: " + communityScheme.HeatNetworkVersion;
                XFont xfont397 = xfont3;
                XSolidBrush black388 = XBrushes.Black;
                double rc1_388 = (double) SAPInput.RC1;
                xunit8 = PDFFunctions.pages[SAPInput.k].Width;
                double point397 = ((XUnit) ref xunit8).Point;
                xunit8 = PDFFunctions.pages[SAPInput.k].Height;
                double num459 = ((XUnit) ref xunit8).Point / 2.0;
                XRect xrect397 = new XRect(200.0, rc1_388, point397, num459);
                XStringFormat topLeft397 = XStringFormat.TopLeft;
                xgraphics397.DrawString(str205, xfont397, (XBrush) black388, xrect397, topLeft397);
                checked { SAPInput.RC1 += 12; }
                string serviceProvision = communityScheme.ServiceProvision;
                string str206 = Operators.CompareString(serviceProvision, Conversions.ToString(3), false) != 0 ? (Operators.CompareString(serviceProvision, Conversions.ToString(1), false) != 0 ? (Operators.CompareString(serviceProvision, Conversions.ToString(4), false) != 0 ? communityScheme.ServiceProvision : "water heating only") : "space and water heating") : "space only";
                XGraphics xgraphics398 = PDFFunctions.gfx[SAPInput.k];
                string str207 = "Service provision: " + str206;
                XFont xfont398 = xfont3;
                XSolidBrush black389 = XBrushes.Black;
                double rc1_389 = (double) SAPInput.RC1;
                xunit8 = PDFFunctions.pages[SAPInput.k].Width;
                double point398 = ((XUnit) ref xunit8).Point;
                xunit8 = PDFFunctions.pages[SAPInput.k].Height;
                double num460 = ((XUnit) ref xunit8).Point / 2.0;
                XRect xrect398 = new XRect(200.0, rc1_389, point398, num460);
                XStringFormat topLeft398 = XStringFormat.TopLeft;
                xgraphics398.DrawString(str207, xfont398, (XBrush) black389, xrect398, topLeft398);
                checked { SAPInput.RC1 += 12; }
                if (Operators.CompareString(communityScheme.DataType, Conversions.ToString(1), false) == 0)
                {
                  XGraphics xgraphics399 = PDFFunctions.gfx[SAPInput.k];
                  string str208 = "Provisional (estimated) data: " + str206;
                  XFont xfont399 = xfont3;
                  XSolidBrush black390 = XBrushes.Black;
                  double rc1_390 = (double) SAPInput.RC1;
                  xunit8 = PDFFunctions.pages[SAPInput.k].Width;
                  double point399 = ((XUnit) ref xunit8).Point;
                  xunit8 = PDFFunctions.pages[SAPInput.k].Height;
                  double num461 = ((XUnit) ref xunit8).Point / 2.0;
                  XRect xrect399 = new XRect(200.0, rc1_390, point399, num461);
                  XStringFormat topLeft399 = XStringFormat.TopLeft;
                  xgraphics399.DrawString(str208, xfont399, (XBrush) black390, xrect399, topLeft399);
                }
                else
                {
                  XGraphics xgraphics400 = PDFFunctions.gfx[SAPInput.k];
                  XFont xfont400 = xfont3;
                  XSolidBrush black391 = XBrushes.Black;
                  double rc1_391 = (double) SAPInput.RC1;
                  xunit8 = PDFFunctions.pages[SAPInput.k].Width;
                  double point400 = ((XUnit) ref xunit8).Point;
                  xunit8 = PDFFunctions.pages[SAPInput.k].Height;
                  double num462 = ((XUnit) ref xunit8).Point / 2.0;
                  XRect xrect400 = new XRect(200.0, rc1_391, point400, num462);
                  XStringFormat topLeft400 = XStringFormat.TopLeft;
                  xgraphics400.DrawString("Actual data", xfont400, (XBrush) black391, xrect400, topLeft400);
                }
                checked { SAPInput.RC1 += 12; }
              }
              // ISSUE: reference to a compiler-generated field
              switch (SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.CommunityH.HeatSource1.Type)
              {
                case 306:
                  XGraphics xgraphics401 = PDFFunctions.gfx[SAPInput.k];
                  // ISSUE: reference to a compiler-generated field
                  string str209 = "Heat source : Community boilers " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.CommunityH.HeatSource1.Type);
                  XFont xfont401 = xfont3;
                  XSolidBrush black392 = XBrushes.Black;
                  double rc1_392 = (double) SAPInput.RC1;
                  xunit8 = PDFFunctions.pages[SAPInput.k].Width;
                  double point401 = ((XUnit) ref xunit8).Point;
                  xunit8 = PDFFunctions.pages[SAPInput.k].Height;
                  double num463 = ((XUnit) ref xunit8).Point / 2.0;
                  XRect xrect401 = new XRect(180.0, rc1_392, point401, num463);
                  XStringFormat topLeft401 = XStringFormat.TopLeft;
                  xgraphics401.DrawString(str209, xfont401, (XBrush) black392, xrect401, topLeft401);
                  break;
                case 307:
                  XGraphics xgraphics402 = PDFFunctions.gfx[SAPInput.k];
                  XFont xfont402 = xfont3;
                  XSolidBrush black393 = XBrushes.Black;
                  double rc1_393 = (double) SAPInput.RC1;
                  xunit8 = PDFFunctions.pages[SAPInput.k].Width;
                  double point402 = ((XUnit) ref xunit8).Point;
                  xunit8 = PDFFunctions.pages[SAPInput.k].Height;
                  double num464 = ((XUnit) ref xunit8).Point / 2.0;
                  XRect xrect402 = new XRect(180.0, rc1_393, point402, num464);
                  XStringFormat topLeft402 = XStringFormat.TopLeft;
                  xgraphics402.DrawString("Heat source : Community CHP", xfont402, (XBrush) black393, xrect402, topLeft402);
                  break;
                case 308:
                  XGraphics xgraphics403 = PDFFunctions.gfx[SAPInput.k];
                  XFont xfont403 = xfont3;
                  XSolidBrush black394 = XBrushes.Black;
                  double rc1_394 = (double) SAPInput.RC1;
                  xunit8 = PDFFunctions.pages[SAPInput.k].Width;
                  double point403 = ((XUnit) ref xunit8).Point;
                  xunit8 = PDFFunctions.pages[SAPInput.k].Height;
                  double num465 = ((XUnit) ref xunit8).Point / 2.0;
                  XRect xrect403 = new XRect(180.0, rc1_394, point403, num465);
                  XStringFormat topLeft403 = XStringFormat.TopLeft;
                  xgraphics403.DrawString("Heat source : Community heat pump", xfont403, (XBrush) black394, xrect403, topLeft403);
                  break;
                case 309:
                  XGraphics xgraphics404 = PDFFunctions.gfx[SAPInput.k];
                  XFont xfont404 = xfont3;
                  XSolidBrush black395 = XBrushes.Black;
                  double rc1_395 = (double) SAPInput.RC1;
                  xunit8 = PDFFunctions.pages[SAPInput.k].Width;
                  double point404 = ((XUnit) ref xunit8).Point;
                  xunit8 = PDFFunctions.pages[SAPInput.k].Height;
                  double num466 = ((XUnit) ref xunit8).Point / 2.0;
                  XRect xrect404 = new XRect(180.0, rc1_395, point404, num466);
                  XStringFormat topLeft404 = XStringFormat.TopLeft;
                  xgraphics404.DrawString("Heat source : Community waste heat from power station", xfont404, (XBrush) black395, xrect404, topLeft404);
                  break;
                case 310:
                  XGraphics xgraphics405 = PDFFunctions.gfx[SAPInput.k];
                  XFont xfont405 = xfont3;
                  XSolidBrush black396 = XBrushes.Black;
                  double rc1_396 = (double) SAPInput.RC1;
                  xunit8 = PDFFunctions.pages[SAPInput.k].Width;
                  double point405 = ((XUnit) ref xunit8).Point;
                  xunit8 = PDFFunctions.pages[SAPInput.k].Height;
                  double num467 = ((XUnit) ref xunit8).Point / 2.0;
                  XRect xrect405 = new XRect(180.0, rc1_396, point405, num467);
                  XStringFormat topLeft405 = XStringFormat.TopLeft;
                  xgraphics405.DrawString("Heat source : Community geothermal heat", xfont405, (XBrush) black396, xrect405, topLeft405);
                  break;
              }
              checked { SAPInput.RC1 += 20; }
              if (communitySchemeSubList[0].CommunityFuel.Equals("99"))
              {
                XGraphics xgraphics406 = PDFFunctions.gfx[SAPInput.k];
                XFont xfont406 = xfont3;
                XSolidBrush black397 = XBrushes.Black;
                double rc1_397 = (double) SAPInput.RC1;
                xunit8 = PDFFunctions.pages[SAPInput.k].Width;
                double point406 = ((XUnit) ref xunit8).Point;
                xunit8 = PDFFunctions.pages[SAPInput.k].Height;
                double num468 = ((XUnit) ref xunit8).Point / 2.0;
                XRect xrect406 = new XRect(200.0, rc1_397, point406, num468);
                XStringFormat topLeft406 = XStringFormat.TopLeft;
                xgraphics406.DrawString("Fuel : biomethane", xfont406, (XBrush) black397, xrect406, topLeft406);
              }
              else
              {
                XGraphics xgraphics407 = PDFFunctions.gfx[SAPInput.k];
                // ISSUE: reference to a compiler-generated field
                string str210 = "Fuel : " + SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.Fuel;
                XFont xfont407 = xfont3;
                XSolidBrush black398 = XBrushes.Black;
                double rc1_398 = (double) SAPInput.RC1;
                xunit8 = PDFFunctions.pages[SAPInput.k].Width;
                double point407 = ((XUnit) ref xunit8).Point;
                xunit8 = PDFFunctions.pages[SAPInput.k].Height;
                double num469 = ((XUnit) ref xunit8).Point / 2.0;
                XRect xrect407 = new XRect(200.0, rc1_398, point407, num469);
                XStringFormat topLeft407 = XStringFormat.TopLeft;
                xgraphics407.DrawString(str210, xfont407, (XBrush) black398, xrect407, topLeft407);
              }
            }
            else
            {
              XGraphics xgraphics408 = PDFFunctions.gfx[SAPInput.k];
              // ISSUE: reference to a compiler-generated field
              string str211 = "Fuel : " + SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.Fuel;
              XFont xfont408 = xfont3;
              XSolidBrush black399 = XBrushes.Black;
              double rc1_399 = (double) SAPInput.RC1;
              xunit8 = PDFFunctions.pages[SAPInput.k].Width;
              double point408 = ((XUnit) ref xunit8).Point;
              xunit8 = PDFFunctions.pages[SAPInput.k].Height;
              double num470 = ((XUnit) ref xunit8).Point / 2.0;
              XRect xrect408 = new XRect(200.0, rc1_399, point408, num470);
              XStringFormat topLeft408 = XStringFormat.TopLeft;
              xgraphics408.DrawString(str211, xfont408, (XBrush) black399, xrect408, topLeft408);
            }
            checked { SAPInput.RC1 += 12; }
            SAPInput.CheckRC1();
            XGraphics xgraphics409 = PDFFunctions.gfx[SAPInput.k];
            // ISSUE: reference to a compiler-generated field
            string str212 = "Heat Fraction : " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.CommunityH.Boiler1HeatFraction);
            XFont xfont409 = xfont3;
            XSolidBrush black400 = XBrushes.Black;
            double rc1_400 = (double) SAPInput.RC1;
            xunit8 = PDFFunctions.pages[SAPInput.k].Width;
            double point409 = ((XUnit) ref xunit8).Point;
            xunit8 = PDFFunctions.pages[SAPInput.k].Height;
            double num471 = ((XUnit) ref xunit8).Point / 2.0;
            XRect xrect409 = new XRect(200.0, rc1_400, point409, num471);
            XStringFormat topLeft409 = XStringFormat.TopLeft;
            xgraphics409.DrawString(str212, xfont409, (XBrush) black400, xrect409, topLeft409);
            checked { SAPInput.RC1 += 12; }
            SAPInput.CheckRC1();
            XGraphics xgraphics410 = PDFFunctions.gfx[SAPInput.k];
            // ISSUE: reference to a compiler-generated field
            string str213 = "Heat Efficiency : " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.CommunityH.Boiler1Efficiency);
            XFont xfont410 = xfont3;
            XSolidBrush black401 = XBrushes.Black;
            double rc1_401 = (double) SAPInput.RC1;
            xunit8 = PDFFunctions.pages[SAPInput.k].Width;
            double point410 = ((XUnit) ref xunit8).Point;
            xunit8 = PDFFunctions.pages[SAPInput.k].Height;
            double num472 = ((XUnit) ref xunit8).Point / 2.0;
            XRect xrect410 = new XRect(200.0, rc1_401, point410, num472);
            XStringFormat topLeft410 = XStringFormat.TopLeft;
            xgraphics410.DrawString(str213, xfont410, (XBrush) black401, xrect410, topLeft410);
            checked { SAPInput.RC1 += 12; }
            SAPInput.CheckRC1();
            // ISSUE: reference to a compiler-generated field
            if ((double) SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.CommunityH.HeatToPowerRatio > 0.0)
            {
              XGraphics xgraphics411 = PDFFunctions.gfx[SAPInput.k];
              // ISSUE: reference to a compiler-generated field
              string str214 = "Power-Efficiency : " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.CommunityH.HeatToPowerRatio);
              XFont xfont411 = xfont3;
              XSolidBrush black402 = XBrushes.Black;
              double rc1_402 = (double) SAPInput.RC1;
              xunit8 = PDFFunctions.pages[SAPInput.k].Width;
              double point411 = ((XUnit) ref xunit8).Point;
              xunit8 = PDFFunctions.pages[SAPInput.k].Height;
              double num473 = ((XUnit) ref xunit8).Point / 2.0;
              XRect xrect411 = new XRect(200.0, rc1_402, point411, num473);
              XStringFormat topLeft411 = XStringFormat.TopLeft;
              xgraphics411.DrawString(str214, xfont411, (XBrush) black402, xrect411, topLeft411);
            }
            checked { SAPInput.RC1 += 12; }
            SAPInput.CheckRC1();
            if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.CommunityH.NoOfAdditionalHeatSources > 0)
            {
              // ISSUE: reference to a compiler-generated field
              switch (SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.CommunityH.HeatSource1.Type)
              {
                case 306:
                  XGraphics xgraphics412 = PDFFunctions.gfx[SAPInput.k];
                  XFont xfont412 = xfont3;
                  XSolidBrush black403 = XBrushes.Black;
                  double rc1_403 = (double) SAPInput.RC1;
                  xunit8 = PDFFunctions.pages[SAPInput.k].Width;
                  double point412 = ((XUnit) ref xunit8).Point;
                  xunit8 = PDFFunctions.pages[SAPInput.k].Height;
                  double num474 = ((XUnit) ref xunit8).Point / 2.0;
                  XRect xrect412 = new XRect(180.0, rc1_403, point412, num474);
                  XStringFormat topLeft412 = XStringFormat.TopLeft;
                  xgraphics412.DrawString("Heat source : Community boilers ", xfont412, (XBrush) black403, xrect412, topLeft412);
                  break;
                case 307:
                  XGraphics xgraphics413 = PDFFunctions.gfx[SAPInput.k];
                  XFont xfont413 = xfont3;
                  XSolidBrush black404 = XBrushes.Black;
                  double rc1_404 = (double) SAPInput.RC1;
                  xunit8 = PDFFunctions.pages[SAPInput.k].Width;
                  double point413 = ((XUnit) ref xunit8).Point;
                  xunit8 = PDFFunctions.pages[SAPInput.k].Height;
                  double num475 = ((XUnit) ref xunit8).Point / 2.0;
                  XRect xrect413 = new XRect(180.0, rc1_404, point413, num475);
                  XStringFormat topLeft413 = XStringFormat.TopLeft;
                  xgraphics413.DrawString("Heat source : Community CHP", xfont413, (XBrush) black404, xrect413, topLeft413);
                  break;
                case 308:
                  XGraphics xgraphics414 = PDFFunctions.gfx[SAPInput.k];
                  XFont xfont414 = xfont3;
                  XSolidBrush black405 = XBrushes.Black;
                  double rc1_405 = (double) SAPInput.RC1;
                  xunit8 = PDFFunctions.pages[SAPInput.k].Width;
                  double point414 = ((XUnit) ref xunit8).Point;
                  xunit8 = PDFFunctions.pages[SAPInput.k].Height;
                  double num476 = ((XUnit) ref xunit8).Point / 2.0;
                  XRect xrect414 = new XRect(180.0, rc1_405, point414, num476);
                  XStringFormat topLeft414 = XStringFormat.TopLeft;
                  xgraphics414.DrawString("Heat source : Community heat pump", xfont414, (XBrush) black405, xrect414, topLeft414);
                  break;
                case 309:
                  XGraphics xgraphics415 = PDFFunctions.gfx[SAPInput.k];
                  XFont xfont415 = xfont3;
                  XSolidBrush black406 = XBrushes.Black;
                  double rc1_406 = (double) SAPInput.RC1;
                  xunit8 = PDFFunctions.pages[SAPInput.k].Width;
                  double point415 = ((XUnit) ref xunit8).Point;
                  xunit8 = PDFFunctions.pages[SAPInput.k].Height;
                  double num477 = ((XUnit) ref xunit8).Point / 2.0;
                  XRect xrect415 = new XRect(180.0, rc1_406, point415, num477);
                  XStringFormat topLeft415 = XStringFormat.TopLeft;
                  xgraphics415.DrawString("Heat source : Community waste heat from power station", xfont415, (XBrush) black406, xrect415, topLeft415);
                  break;
                case 310:
                  XGraphics xgraphics416 = PDFFunctions.gfx[SAPInput.k];
                  XFont xfont416 = xfont3;
                  XSolidBrush black407 = XBrushes.Black;
                  double rc1_407 = (double) SAPInput.RC1;
                  xunit8 = PDFFunctions.pages[SAPInput.k].Width;
                  double point416 = ((XUnit) ref xunit8).Point;
                  xunit8 = PDFFunctions.pages[SAPInput.k].Height;
                  double num478 = ((XUnit) ref xunit8).Point / 2.0;
                  XRect xrect416 = new XRect(180.0, rc1_407, point416, num478);
                  XStringFormat topLeft416 = XStringFormat.TopLeft;
                  xgraphics416.DrawString("Heat source : Community geothermal heat", xfont416, (XBrush) black407, xrect416, topLeft416);
                  break;
              }
              checked { SAPInput.RC1 += 20; }
              SAPInput.CheckRC1();
              if (communitySchemeSubList.Count > 0)
              {
                if (communitySchemeSubList[1].CommunityFuel.Equals("99"))
                {
                  XGraphics xgraphics417 = PDFFunctions.gfx[SAPInput.k];
                  XFont xfont417 = xfont3;
                  XSolidBrush black408 = XBrushes.Black;
                  double rc1_408 = (double) SAPInput.RC1;
                  xunit8 = PDFFunctions.pages[SAPInput.k].Width;
                  double point417 = ((XUnit) ref xunit8).Point;
                  xunit8 = PDFFunctions.pages[SAPInput.k].Height;
                  double num479 = ((XUnit) ref xunit8).Point / 2.0;
                  XRect xrect417 = new XRect(200.0, rc1_408, point417, num479);
                  XStringFormat topLeft417 = XStringFormat.TopLeft;
                  xgraphics417.DrawString("Fuel : biomethane", xfont417, (XBrush) black408, xrect417, topLeft417);
                }
                else
                {
                  XGraphics xgraphics418 = PDFFunctions.gfx[SAPInput.k];
                  // ISSUE: reference to a compiler-generated field
                  string str215 = "Fuel : " + SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.CommunityH.HeatSource1.Fuel;
                  XFont xfont418 = xfont3;
                  XSolidBrush black409 = XBrushes.Black;
                  double rc1_409 = (double) SAPInput.RC1;
                  xunit8 = PDFFunctions.pages[SAPInput.k].Width;
                  double point418 = ((XUnit) ref xunit8).Point;
                  xunit8 = PDFFunctions.pages[SAPInput.k].Height;
                  double num480 = ((XUnit) ref xunit8).Point / 2.0;
                  XRect xrect418 = new XRect(200.0, rc1_409, point418, num480);
                  XStringFormat topLeft418 = XStringFormat.TopLeft;
                  xgraphics418.DrawString(str215, xfont418, (XBrush) black409, xrect418, topLeft418);
                }
              }
              else
              {
                XGraphics xgraphics419 = PDFFunctions.gfx[SAPInput.k];
                // ISSUE: reference to a compiler-generated field
                string str216 = "Fuel : " + SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.CommunityH.HeatSource1.Fuel;
                XFont xfont419 = xfont3;
                XSolidBrush black410 = XBrushes.Black;
                double rc1_410 = (double) SAPInput.RC1;
                xunit8 = PDFFunctions.pages[SAPInput.k].Width;
                double point419 = ((XUnit) ref xunit8).Point;
                xunit8 = PDFFunctions.pages[SAPInput.k].Height;
                double num481 = ((XUnit) ref xunit8).Point / 2.0;
                XRect xrect419 = new XRect(200.0, rc1_410, point419, num481);
                XStringFormat topLeft419 = XStringFormat.TopLeft;
                xgraphics419.DrawString(str216, xfont419, (XBrush) black410, xrect419, topLeft419);
              }
              checked { SAPInput.RC1 += 12; }
              SAPInput.CheckRC1();
              XGraphics xgraphics420 = PDFFunctions.gfx[SAPInput.k];
              // ISSUE: reference to a compiler-generated field
              string str217 = "Heat Fraction : " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.CommunityH.HeatSource1.HeatFraction);
              XFont xfont420 = xfont3;
              XSolidBrush black411 = XBrushes.Black;
              double rc1_411 = (double) SAPInput.RC1;
              xunit8 = PDFFunctions.pages[SAPInput.k].Width;
              double point420 = ((XUnit) ref xunit8).Point;
              xunit8 = PDFFunctions.pages[SAPInput.k].Height;
              double num482 = ((XUnit) ref xunit8).Point / 2.0;
              XRect xrect420 = new XRect(200.0, rc1_411, point420, num482);
              XStringFormat topLeft420 = XStringFormat.TopLeft;
              xgraphics420.DrawString(str217, xfont420, (XBrush) black411, xrect420, topLeft420);
              checked { SAPInput.RC1 += 12; }
              SAPInput.CheckRC1();
              XGraphics xgraphics421 = PDFFunctions.gfx[SAPInput.k];
              // ISSUE: reference to a compiler-generated field
              string str218 = "Heat Efficiency : " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.CommunityH.HeatSource1.Efficiency);
              XFont xfont421 = xfont3;
              XSolidBrush black412 = XBrushes.Black;
              double rc1_412 = (double) SAPInput.RC1;
              xunit8 = PDFFunctions.pages[SAPInput.k].Width;
              double point421 = ((XUnit) ref xunit8).Point;
              xunit8 = PDFFunctions.pages[SAPInput.k].Height;
              double num483 = ((XUnit) ref xunit8).Point / 2.0;
              XRect xrect421 = new XRect(200.0, rc1_412, point421, num483);
              XStringFormat topLeft421 = XStringFormat.TopLeft;
              xgraphics421.DrawString(str218, xfont421, (XBrush) black412, xrect421, topLeft421);
              checked { SAPInput.RC1 += 12; }
              SAPInput.CheckRC1();
            }
            if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.CommunityH.NoOfAdditionalHeatSources > 1)
            {
              // ISSUE: reference to a compiler-generated field
              switch (SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.CommunityH.HeatSource2.Type)
              {
                case 306:
                  XGraphics xgraphics422 = PDFFunctions.gfx[SAPInput.k];
                  XFont xfont422 = xfont3;
                  XSolidBrush black413 = XBrushes.Black;
                  double rc1_413 = (double) SAPInput.RC1;
                  xunit8 = PDFFunctions.pages[SAPInput.k].Width;
                  double point422 = ((XUnit) ref xunit8).Point;
                  xunit8 = PDFFunctions.pages[SAPInput.k].Height;
                  double num484 = ((XUnit) ref xunit8).Point / 2.0;
                  XRect xrect422 = new XRect(180.0, rc1_413, point422, num484);
                  XStringFormat topLeft422 = XStringFormat.TopLeft;
                  xgraphics422.DrawString("Heat source : Community boilers ", xfont422, (XBrush) black413, xrect422, topLeft422);
                  break;
                case 307:
                  XGraphics xgraphics423 = PDFFunctions.gfx[SAPInput.k];
                  XFont xfont423 = xfont3;
                  XSolidBrush black414 = XBrushes.Black;
                  double rc1_414 = (double) SAPInput.RC1;
                  xunit8 = PDFFunctions.pages[SAPInput.k].Width;
                  double point423 = ((XUnit) ref xunit8).Point;
                  xunit8 = PDFFunctions.pages[SAPInput.k].Height;
                  double num485 = ((XUnit) ref xunit8).Point / 2.0;
                  XRect xrect423 = new XRect(180.0, rc1_414, point423, num485);
                  XStringFormat topLeft423 = XStringFormat.TopLeft;
                  xgraphics423.DrawString("Heat source : Community CHP", xfont423, (XBrush) black414, xrect423, topLeft423);
                  break;
                case 308:
                  XGraphics xgraphics424 = PDFFunctions.gfx[SAPInput.k];
                  XFont xfont424 = xfont3;
                  XSolidBrush black415 = XBrushes.Black;
                  double rc1_415 = (double) SAPInput.RC1;
                  xunit8 = PDFFunctions.pages[SAPInput.k].Width;
                  double point424 = ((XUnit) ref xunit8).Point;
                  xunit8 = PDFFunctions.pages[SAPInput.k].Height;
                  double num486 = ((XUnit) ref xunit8).Point / 2.0;
                  XRect xrect424 = new XRect(180.0, rc1_415, point424, num486);
                  XStringFormat topLeft424 = XStringFormat.TopLeft;
                  xgraphics424.DrawString("Heat source : Community heat pump", xfont424, (XBrush) black415, xrect424, topLeft424);
                  break;
                case 309:
                  XGraphics xgraphics425 = PDFFunctions.gfx[SAPInput.k];
                  XFont xfont425 = xfont3;
                  XSolidBrush black416 = XBrushes.Black;
                  double rc1_416 = (double) SAPInput.RC1;
                  xunit8 = PDFFunctions.pages[SAPInput.k].Width;
                  double point425 = ((XUnit) ref xunit8).Point;
                  xunit8 = PDFFunctions.pages[SAPInput.k].Height;
                  double num487 = ((XUnit) ref xunit8).Point / 2.0;
                  XRect xrect425 = new XRect(180.0, rc1_416, point425, num487);
                  XStringFormat topLeft425 = XStringFormat.TopLeft;
                  xgraphics425.DrawString("Heat source : Community waste heat from power station", xfont425, (XBrush) black416, xrect425, topLeft425);
                  break;
                case 310:
                  XGraphics xgraphics426 = PDFFunctions.gfx[SAPInput.k];
                  XFont xfont426 = xfont3;
                  XSolidBrush black417 = XBrushes.Black;
                  double rc1_417 = (double) SAPInput.RC1;
                  xunit8 = PDFFunctions.pages[SAPInput.k].Width;
                  double point426 = ((XUnit) ref xunit8).Point;
                  xunit8 = PDFFunctions.pages[SAPInput.k].Height;
                  double num488 = ((XUnit) ref xunit8).Point / 2.0;
                  XRect xrect426 = new XRect(180.0, rc1_417, point426, num488);
                  XStringFormat topLeft426 = XStringFormat.TopLeft;
                  xgraphics426.DrawString("Heat source : Community geothermal heat", xfont426, (XBrush) black417, xrect426, topLeft426);
                  break;
              }
              checked { SAPInput.RC1 += 20; }
              SAPInput.CheckRC1();
              if (communitySchemeSubList.Count > 0)
              {
                if (communitySchemeSubList[2].CommunityFuel.Equals("99"))
                {
                  XGraphics xgraphics427 = PDFFunctions.gfx[SAPInput.k];
                  XFont xfont427 = xfont3;
                  XSolidBrush black418 = XBrushes.Black;
                  double rc1_418 = (double) SAPInput.RC1;
                  xunit8 = PDFFunctions.pages[SAPInput.k].Width;
                  double point427 = ((XUnit) ref xunit8).Point;
                  xunit8 = PDFFunctions.pages[SAPInput.k].Height;
                  double num489 = ((XUnit) ref xunit8).Point / 2.0;
                  XRect xrect427 = new XRect(200.0, rc1_418, point427, num489);
                  XStringFormat topLeft427 = XStringFormat.TopLeft;
                  xgraphics427.DrawString("Fuel : biomethane", xfont427, (XBrush) black418, xrect427, topLeft427);
                }
                else
                {
                  XGraphics xgraphics428 = PDFFunctions.gfx[SAPInput.k];
                  // ISSUE: reference to a compiler-generated field
                  string str219 = "Fuel : " + SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.CommunityH.HeatSource2.Fuel;
                  XFont xfont428 = xfont3;
                  XSolidBrush black419 = XBrushes.Black;
                  double rc1_419 = (double) SAPInput.RC1;
                  xunit8 = PDFFunctions.pages[SAPInput.k].Width;
                  double point428 = ((XUnit) ref xunit8).Point;
                  xunit8 = PDFFunctions.pages[SAPInput.k].Height;
                  double num490 = ((XUnit) ref xunit8).Point / 2.0;
                  XRect xrect428 = new XRect(200.0, rc1_419, point428, num490);
                  XStringFormat topLeft428 = XStringFormat.TopLeft;
                  xgraphics428.DrawString(str219, xfont428, (XBrush) black419, xrect428, topLeft428);
                }
              }
              else
              {
                XGraphics xgraphics429 = PDFFunctions.gfx[SAPInput.k];
                // ISSUE: reference to a compiler-generated field
                string str220 = "Fuel : " + SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.CommunityH.HeatSource2.Fuel;
                XFont xfont429 = xfont3;
                XSolidBrush black420 = XBrushes.Black;
                double rc1_420 = (double) SAPInput.RC1;
                xunit8 = PDFFunctions.pages[SAPInput.k].Width;
                double point429 = ((XUnit) ref xunit8).Point;
                xunit8 = PDFFunctions.pages[SAPInput.k].Height;
                double num491 = ((XUnit) ref xunit8).Point / 2.0;
                XRect xrect429 = new XRect(200.0, rc1_420, point429, num491);
                XStringFormat topLeft429 = XStringFormat.TopLeft;
                xgraphics429.DrawString(str220, xfont429, (XBrush) black420, xrect429, topLeft429);
              }
              checked { SAPInput.RC1 += 12; }
              SAPInput.CheckRC1();
              XGraphics xgraphics430 = PDFFunctions.gfx[SAPInput.k];
              // ISSUE: reference to a compiler-generated field
              string str221 = "Heat Fraction : " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.CommunityH.HeatSource2.HeatFraction);
              XFont xfont430 = xfont3;
              XSolidBrush black421 = XBrushes.Black;
              double rc1_421 = (double) SAPInput.RC1;
              xunit8 = PDFFunctions.pages[SAPInput.k].Width;
              double point430 = ((XUnit) ref xunit8).Point;
              xunit8 = PDFFunctions.pages[SAPInput.k].Height;
              double num492 = ((XUnit) ref xunit8).Point / 2.0;
              XRect xrect430 = new XRect(200.0, rc1_421, point430, num492);
              XStringFormat topLeft430 = XStringFormat.TopLeft;
              xgraphics430.DrawString(str221, xfont430, (XBrush) black421, xrect430, topLeft430);
              checked { SAPInput.RC1 += 12; }
              SAPInput.CheckRC1();
              XGraphics xgraphics431 = PDFFunctions.gfx[SAPInput.k];
              // ISSUE: reference to a compiler-generated field
              string str222 = "Heat Efficiency : " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.CommunityH.HeatSource2.Efficiency);
              XFont xfont431 = xfont3;
              XSolidBrush black422 = XBrushes.Black;
              double rc1_422 = (double) SAPInput.RC1;
              xunit8 = PDFFunctions.pages[SAPInput.k].Width;
              double point431 = ((XUnit) ref xunit8).Point;
              xunit8 = PDFFunctions.pages[SAPInput.k].Height;
              double num493 = ((XUnit) ref xunit8).Point / 2.0;
              XRect xrect431 = new XRect(200.0, rc1_422, point431, num493);
              XStringFormat topLeft431 = XStringFormat.TopLeft;
              xgraphics431.DrawString(str222, xfont431, (XBrush) black422, xrect431, topLeft431);
              checked { SAPInput.RC1 += 12; }
              SAPInput.CheckRC1();
            }
            // ISSUE: reference to a compiler-generated field
            if (SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.CommunityH.NoOfAdditionalHeatSources > 2)
            {
              // ISSUE: reference to a compiler-generated field
              switch (SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.CommunityH.HeatSource3.Type)
              {
                case 306:
                  XGraphics xgraphics432 = PDFFunctions.gfx[SAPInput.k];
                  XFont xfont432 = xfont3;
                  XSolidBrush black423 = XBrushes.Black;
                  double rc1_423 = (double) SAPInput.RC1;
                  xunit8 = PDFFunctions.pages[SAPInput.k].Width;
                  double point432 = ((XUnit) ref xunit8).Point;
                  xunit8 = PDFFunctions.pages[SAPInput.k].Height;
                  double num494 = ((XUnit) ref xunit8).Point / 2.0;
                  XRect xrect432 = new XRect(180.0, rc1_423, point432, num494);
                  XStringFormat topLeft432 = XStringFormat.TopLeft;
                  xgraphics432.DrawString("Heat source : Community boilers ", xfont432, (XBrush) black423, xrect432, topLeft432);
                  break;
                case 307:
                  XGraphics xgraphics433 = PDFFunctions.gfx[SAPInput.k];
                  XFont xfont433 = xfont3;
                  XSolidBrush black424 = XBrushes.Black;
                  double rc1_424 = (double) SAPInput.RC1;
                  xunit8 = PDFFunctions.pages[SAPInput.k].Width;
                  double point433 = ((XUnit) ref xunit8).Point;
                  xunit8 = PDFFunctions.pages[SAPInput.k].Height;
                  double num495 = ((XUnit) ref xunit8).Point / 2.0;
                  XRect xrect433 = new XRect(180.0, rc1_424, point433, num495);
                  XStringFormat topLeft433 = XStringFormat.TopLeft;
                  xgraphics433.DrawString("Heat source : Community CHP", xfont433, (XBrush) black424, xrect433, topLeft433);
                  break;
                case 308:
                  XGraphics xgraphics434 = PDFFunctions.gfx[SAPInput.k];
                  XFont xfont434 = xfont3;
                  XSolidBrush black425 = XBrushes.Black;
                  double rc1_425 = (double) SAPInput.RC1;
                  xunit8 = PDFFunctions.pages[SAPInput.k].Width;
                  double point434 = ((XUnit) ref xunit8).Point;
                  xunit8 = PDFFunctions.pages[SAPInput.k].Height;
                  double num496 = ((XUnit) ref xunit8).Point / 2.0;
                  XRect xrect434 = new XRect(180.0, rc1_425, point434, num496);
                  XStringFormat topLeft434 = XStringFormat.TopLeft;
                  xgraphics434.DrawString("Heat source : Community heat pump", xfont434, (XBrush) black425, xrect434, topLeft434);
                  break;
                case 309:
                  XGraphics xgraphics435 = PDFFunctions.gfx[SAPInput.k];
                  XFont xfont435 = xfont3;
                  XSolidBrush black426 = XBrushes.Black;
                  double rc1_426 = (double) SAPInput.RC1;
                  xunit8 = PDFFunctions.pages[SAPInput.k].Width;
                  double point435 = ((XUnit) ref xunit8).Point;
                  xunit8 = PDFFunctions.pages[SAPInput.k].Height;
                  double num497 = ((XUnit) ref xunit8).Point / 2.0;
                  XRect xrect435 = new XRect(180.0, rc1_426, point435, num497);
                  XStringFormat topLeft435 = XStringFormat.TopLeft;
                  xgraphics435.DrawString("Heat source : Community waste heat from power station", xfont435, (XBrush) black426, xrect435, topLeft435);
                  break;
                case 310:
                  XGraphics xgraphics436 = PDFFunctions.gfx[SAPInput.k];
                  XFont xfont436 = xfont3;
                  XSolidBrush black427 = XBrushes.Black;
                  double rc1_427 = (double) SAPInput.RC1;
                  xunit8 = PDFFunctions.pages[SAPInput.k].Width;
                  double point436 = ((XUnit) ref xunit8).Point;
                  xunit8 = PDFFunctions.pages[SAPInput.k].Height;
                  double num498 = ((XUnit) ref xunit8).Point / 2.0;
                  XRect xrect436 = new XRect(180.0, rc1_427, point436, num498);
                  XStringFormat topLeft436 = XStringFormat.TopLeft;
                  xgraphics436.DrawString("Heat source : Community geothermal heat", xfont436, (XBrush) black427, xrect436, topLeft436);
                  break;
              }
              checked { SAPInput.RC1 += 20; }
              SAPInput.CheckRC1();
              SAPInput.CheckRC1();
              if (communitySchemeSubList.Count > 0)
              {
                if (communitySchemeSubList[3].CommunityFuel.Equals("99"))
                {
                  XGraphics xgraphics437 = PDFFunctions.gfx[SAPInput.k];
                  XFont xfont437 = xfont3;
                  XSolidBrush black428 = XBrushes.Black;
                  double rc1_428 = (double) SAPInput.RC1;
                  xunit8 = PDFFunctions.pages[SAPInput.k].Width;
                  double point437 = ((XUnit) ref xunit8).Point;
                  xunit8 = PDFFunctions.pages[SAPInput.k].Height;
                  double num499 = ((XUnit) ref xunit8).Point / 2.0;
                  XRect xrect437 = new XRect(200.0, rc1_428, point437, num499);
                  XStringFormat topLeft437 = XStringFormat.TopLeft;
                  xgraphics437.DrawString("Fuel : biomethane", xfont437, (XBrush) black428, xrect437, topLeft437);
                }
                else
                {
                  XGraphics xgraphics438 = PDFFunctions.gfx[SAPInput.k];
                  // ISSUE: reference to a compiler-generated field
                  string str223 = "Fuel : " + SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.CommunityH.HeatSource3.Fuel;
                  XFont xfont438 = xfont3;
                  XSolidBrush black429 = XBrushes.Black;
                  double rc1_429 = (double) SAPInput.RC1;
                  xunit8 = PDFFunctions.pages[SAPInput.k].Width;
                  double point438 = ((XUnit) ref xunit8).Point;
                  xunit8 = PDFFunctions.pages[SAPInput.k].Height;
                  double num500 = ((XUnit) ref xunit8).Point / 2.0;
                  XRect xrect438 = new XRect(200.0, rc1_429, point438, num500);
                  XStringFormat topLeft438 = XStringFormat.TopLeft;
                  xgraphics438.DrawString(str223, xfont438, (XBrush) black429, xrect438, topLeft438);
                }
              }
              else
              {
                XGraphics xgraphics439 = PDFFunctions.gfx[SAPInput.k];
                // ISSUE: reference to a compiler-generated field
                string str224 = "Fuel : " + SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.CommunityH.HeatSource3.Fuel;
                XFont xfont439 = xfont3;
                XSolidBrush black430 = XBrushes.Black;
                double rc1_430 = (double) SAPInput.RC1;
                xunit8 = PDFFunctions.pages[SAPInput.k].Width;
                double point439 = ((XUnit) ref xunit8).Point;
                xunit8 = PDFFunctions.pages[SAPInput.k].Height;
                double num501 = ((XUnit) ref xunit8).Point / 2.0;
                XRect xrect439 = new XRect(200.0, rc1_430, point439, num501);
                XStringFormat topLeft439 = XStringFormat.TopLeft;
                xgraphics439.DrawString(str224, xfont439, (XBrush) black430, xrect439, topLeft439);
              }
              checked { SAPInput.RC1 += 12; }
              SAPInput.CheckRC1();
              XGraphics xgraphics440 = PDFFunctions.gfx[SAPInput.k];
              // ISSUE: reference to a compiler-generated field
              string str225 = "Heat Fraction : " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.CommunityH.HeatSource3.HeatFraction);
              XFont xfont440 = xfont3;
              XSolidBrush black431 = XBrushes.Black;
              double rc1_431 = (double) SAPInput.RC1;
              xunit8 = PDFFunctions.pages[SAPInput.k].Width;
              double point440 = ((XUnit) ref xunit8).Point;
              xunit8 = PDFFunctions.pages[SAPInput.k].Height;
              double num502 = ((XUnit) ref xunit8).Point / 2.0;
              XRect xrect440 = new XRect(200.0, rc1_431, point440, num502);
              XStringFormat topLeft440 = XStringFormat.TopLeft;
              xgraphics440.DrawString(str225, xfont440, (XBrush) black431, xrect440, topLeft440);
              checked { SAPInput.RC1 += 12; }
              SAPInput.CheckRC1();
              XGraphics xgraphics441 = PDFFunctions.gfx[SAPInput.k];
              // ISSUE: reference to a compiler-generated field
              string str226 = "Heat Efficiency : " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.CommunityH.HeatSource3.Efficiency);
              XFont xfont441 = xfont3;
              XSolidBrush black432 = XBrushes.Black;
              double rc1_432 = (double) SAPInput.RC1;
              xunit8 = PDFFunctions.pages[SAPInput.k].Width;
              double point441 = ((XUnit) ref xunit8).Point;
              xunit8 = PDFFunctions.pages[SAPInput.k].Height;
              double num503 = ((XUnit) ref xunit8).Point / 2.0;
              XRect xrect441 = new XRect(200.0, rc1_432, point441, num503);
              XStringFormat topLeft441 = XStringFormat.TopLeft;
              xgraphics441.DrawString(str226, xfont441, (XBrush) black432, xrect441, topLeft441);
              checked { SAPInput.RC1 += 12; }
              SAPInput.CheckRC1();
            }
            if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.CommunityH.NoOfAdditionalHeatSources > 3)
            {
              // ISSUE: reference to a compiler-generated field
              switch (SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.CommunityH.HeatSource4.Type)
              {
                case 306:
                  XGraphics xgraphics442 = PDFFunctions.gfx[SAPInput.k];
                  XFont xfont442 = xfont3;
                  XSolidBrush black433 = XBrushes.Black;
                  double rc1_433 = (double) SAPInput.RC1;
                  xunit8 = PDFFunctions.pages[SAPInput.k].Width;
                  double point442 = ((XUnit) ref xunit8).Point;
                  xunit8 = PDFFunctions.pages[SAPInput.k].Height;
                  double num504 = ((XUnit) ref xunit8).Point / 2.0;
                  XRect xrect442 = new XRect(180.0, rc1_433, point442, num504);
                  XStringFormat topLeft442 = XStringFormat.TopLeft;
                  xgraphics442.DrawString("Heat source : Community boilers ", xfont442, (XBrush) black433, xrect442, topLeft442);
                  break;
                case 307:
                  XGraphics xgraphics443 = PDFFunctions.gfx[SAPInput.k];
                  XFont xfont443 = xfont3;
                  XSolidBrush black434 = XBrushes.Black;
                  double rc1_434 = (double) SAPInput.RC1;
                  xunit8 = PDFFunctions.pages[SAPInput.k].Width;
                  double point443 = ((XUnit) ref xunit8).Point;
                  xunit8 = PDFFunctions.pages[SAPInput.k].Height;
                  double num505 = ((XUnit) ref xunit8).Point / 2.0;
                  XRect xrect443 = new XRect(180.0, rc1_434, point443, num505);
                  XStringFormat topLeft443 = XStringFormat.TopLeft;
                  xgraphics443.DrawString("Heat source : Community CHP", xfont443, (XBrush) black434, xrect443, topLeft443);
                  break;
                case 308:
                  XGraphics xgraphics444 = PDFFunctions.gfx[SAPInput.k];
                  XFont xfont444 = xfont3;
                  XSolidBrush black435 = XBrushes.Black;
                  double rc1_435 = (double) SAPInput.RC1;
                  xunit8 = PDFFunctions.pages[SAPInput.k].Width;
                  double point444 = ((XUnit) ref xunit8).Point;
                  xunit8 = PDFFunctions.pages[SAPInput.k].Height;
                  double num506 = ((XUnit) ref xunit8).Point / 2.0;
                  XRect xrect444 = new XRect(180.0, rc1_435, point444, num506);
                  XStringFormat topLeft444 = XStringFormat.TopLeft;
                  xgraphics444.DrawString("Heat source : Community heat pump", xfont444, (XBrush) black435, xrect444, topLeft444);
                  break;
                case 309:
                  XGraphics xgraphics445 = PDFFunctions.gfx[SAPInput.k];
                  XFont xfont445 = xfont3;
                  XSolidBrush black436 = XBrushes.Black;
                  double rc1_436 = (double) SAPInput.RC1;
                  xunit8 = PDFFunctions.pages[SAPInput.k].Width;
                  double point445 = ((XUnit) ref xunit8).Point;
                  xunit8 = PDFFunctions.pages[SAPInput.k].Height;
                  double num507 = ((XUnit) ref xunit8).Point / 2.0;
                  XRect xrect445 = new XRect(180.0, rc1_436, point445, num507);
                  XStringFormat topLeft445 = XStringFormat.TopLeft;
                  xgraphics445.DrawString("Heat source : Community waste heat from power station", xfont445, (XBrush) black436, xrect445, topLeft445);
                  break;
                case 310:
                  XGraphics xgraphics446 = PDFFunctions.gfx[SAPInput.k];
                  XFont xfont446 = xfont3;
                  XSolidBrush black437 = XBrushes.Black;
                  double rc1_437 = (double) SAPInput.RC1;
                  xunit8 = PDFFunctions.pages[SAPInput.k].Width;
                  double point446 = ((XUnit) ref xunit8).Point;
                  xunit8 = PDFFunctions.pages[SAPInput.k].Height;
                  double num508 = ((XUnit) ref xunit8).Point / 2.0;
                  XRect xrect446 = new XRect(180.0, rc1_437, point446, num508);
                  XStringFormat topLeft446 = XStringFormat.TopLeft;
                  xgraphics446.DrawString("Heat source : Community geothermal heat", xfont446, (XBrush) black437, xrect446, topLeft446);
                  break;
              }
              checked { SAPInput.RC1 += 20; }
              SAPInput.CheckRC1();
              if (communitySchemeSubList.Count > 0)
              {
                if (communitySchemeSubList[4].CommunityFuel.Equals("99"))
                {
                  XGraphics xgraphics447 = PDFFunctions.gfx[SAPInput.k];
                  XFont xfont447 = xfont3;
                  XSolidBrush black438 = XBrushes.Black;
                  double rc1_438 = (double) SAPInput.RC1;
                  xunit8 = PDFFunctions.pages[SAPInput.k].Width;
                  double point447 = ((XUnit) ref xunit8).Point;
                  xunit8 = PDFFunctions.pages[SAPInput.k].Height;
                  double num509 = ((XUnit) ref xunit8).Point / 2.0;
                  XRect xrect447 = new XRect(200.0, rc1_438, point447, num509);
                  XStringFormat topLeft447 = XStringFormat.TopLeft;
                  xgraphics447.DrawString("Fuel : biomethane", xfont447, (XBrush) black438, xrect447, topLeft447);
                }
                else
                {
                  XGraphics xgraphics448 = PDFFunctions.gfx[SAPInput.k];
                  // ISSUE: reference to a compiler-generated field
                  string str227 = "Fuel : " + SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.CommunityH.HeatSource4.Fuel;
                  XFont xfont448 = xfont3;
                  XSolidBrush black439 = XBrushes.Black;
                  double rc1_439 = (double) SAPInput.RC1;
                  xunit8 = PDFFunctions.pages[SAPInput.k].Width;
                  double point448 = ((XUnit) ref xunit8).Point;
                  xunit8 = PDFFunctions.pages[SAPInput.k].Height;
                  double num510 = ((XUnit) ref xunit8).Point / 2.0;
                  XRect xrect448 = new XRect(200.0, rc1_439, point448, num510);
                  XStringFormat topLeft448 = XStringFormat.TopLeft;
                  xgraphics448.DrawString(str227, xfont448, (XBrush) black439, xrect448, topLeft448);
                }
              }
              else
              {
                XGraphics xgraphics449 = PDFFunctions.gfx[SAPInput.k];
                // ISSUE: reference to a compiler-generated field
                string str228 = "Fuel : " + SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.CommunityH.HeatSource4.Fuel;
                XFont xfont449 = xfont3;
                XSolidBrush black440 = XBrushes.Black;
                double rc1_440 = (double) SAPInput.RC1;
                xunit8 = PDFFunctions.pages[SAPInput.k].Width;
                double point449 = ((XUnit) ref xunit8).Point;
                xunit8 = PDFFunctions.pages[SAPInput.k].Height;
                double num511 = ((XUnit) ref xunit8).Point / 2.0;
                XRect xrect449 = new XRect(200.0, rc1_440, point449, num511);
                XStringFormat topLeft449 = XStringFormat.TopLeft;
                xgraphics449.DrawString(str228, xfont449, (XBrush) black440, xrect449, topLeft449);
              }
              checked { SAPInput.RC1 += 12; }
              SAPInput.CheckRC1();
              XGraphics xgraphics450 = PDFFunctions.gfx[SAPInput.k];
              // ISSUE: reference to a compiler-generated field
              string str229 = "Heat Fraction : " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.CommunityH.HeatSource4.HeatFraction);
              XFont xfont450 = xfont3;
              XSolidBrush black441 = XBrushes.Black;
              double rc1_441 = (double) SAPInput.RC1;
              xunit8 = PDFFunctions.pages[SAPInput.k].Width;
              double point450 = ((XUnit) ref xunit8).Point;
              xunit8 = PDFFunctions.pages[SAPInput.k].Height;
              double num512 = ((XUnit) ref xunit8).Point / 2.0;
              XRect xrect450 = new XRect(200.0, rc1_441, point450, num512);
              XStringFormat topLeft450 = XStringFormat.TopLeft;
              xgraphics450.DrawString(str229, xfont450, (XBrush) black441, xrect450, topLeft450);
              checked { SAPInput.RC1 += 12; }
              SAPInput.CheckRC1();
              XGraphics xgraphics451 = PDFFunctions.gfx[SAPInput.k];
              // ISSUE: reference to a compiler-generated field
              string str230 = "Heat Efficiency : " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.CommunityH.HeatSource4.Efficiency);
              XFont xfont451 = xfont3;
              XSolidBrush black442 = XBrushes.Black;
              double rc1_442 = (double) SAPInput.RC1;
              xunit8 = PDFFunctions.pages[SAPInput.k].Width;
              double point451 = ((XUnit) ref xunit8).Point;
              xunit8 = PDFFunctions.pages[SAPInput.k].Height;
              double num513 = ((XUnit) ref xunit8).Point / 2.0;
              XRect xrect451 = new XRect(200.0, rc1_442, point451, num513);
              XStringFormat topLeft451 = XStringFormat.TopLeft;
              xgraphics451.DrawString(str230, xfont451, (XBrush) black442, xrect451, topLeft451);
              checked { SAPInput.RC1 += 12; }
              SAPInput.CheckRC1();
            }
          }
          else
          {
            XGraphics xgraphics452 = PDFFunctions.gfx[SAPInput.k];
            // ISSUE: reference to a compiler-generated field
            string str231 = "Heat source: " + SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.MHType;
            XFont xfont452 = xfont3;
            XSolidBrush black443 = XBrushes.Black;
            double rc1_443 = (double) SAPInput.RC1;
            xunit8 = PDFFunctions.pages[SAPInput.k].Width;
            double point452 = ((XUnit) ref xunit8).Point;
            xunit8 = PDFFunctions.pages[SAPInput.k].Height;
            double num514 = ((XUnit) ref xunit8).Point / 2.0;
            XRect xrect452 = new XRect(200.0, rc1_443, point452, num514);
            XStringFormat topLeft452 = XStringFormat.TopLeft;
            xgraphics452.DrawString(str231, xfont452, (XBrush) black443, xrect452, topLeft452);
            checked { SAPInput.RC1 += 12; }
            SAPInput.CheckRC1();
            XGraphics xgraphics453 = PDFFunctions.gfx[SAPInput.k];
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            string str232 = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.Fuel + ", heat fraction " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.CommunityH.Boiler1HeatFraction) + ", efficiency " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.CommunityH.Boiler1Efficiency);
            XFont xfont453 = xfont3;
            XSolidBrush black444 = XBrushes.Black;
            double rc1_444 = (double) SAPInput.RC1;
            xunit8 = PDFFunctions.pages[SAPInput.k].Width;
            double point453 = ((XUnit) ref xunit8).Point;
            xunit8 = PDFFunctions.pages[SAPInput.k].Height;
            double num515 = ((XUnit) ref xunit8).Point / 2.0;
            XRect xrect453 = new XRect(205.0, rc1_444, point453, num515);
            XStringFormat topLeft453 = XStringFormat.TopLeft;
            xgraphics453.DrawString(str232, xfont453, (XBrush) black444, xrect453, topLeft453);
            // ISSUE: reference to a compiler-generated field
            if (SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.CommunityH.NoOfAdditionalHeatSources > 0)
            {
              // ISSUE: reference to a compiler-generated method
              PCDF.Table4a_B table4aB = SAP_Module.PCDFData.Table4a_bs.Where<PCDF.Table4a_B>(new Func<PCDF.Table4a_B, bool>(closure160_2._Lambda\u0024__20)).SingleOrDefault<PCDF.Table4a_B>();
              checked { SAPInput.RC1 += 12; }
              SAPInput.CheckRC1();
              XGraphics xgraphics454 = PDFFunctions.gfx[SAPInput.k];
              string str233 = "Heat source: " + table4aB.Description;
              XFont xfont454 = xfont3;
              XSolidBrush black445 = XBrushes.Black;
              double rc1_445 = (double) SAPInput.RC1;
              xunit8 = PDFFunctions.pages[SAPInput.k].Width;
              double point454 = ((XUnit) ref xunit8).Point;
              xunit8 = PDFFunctions.pages[SAPInput.k].Height;
              double num516 = ((XUnit) ref xunit8).Point / 2.0;
              XRect xrect454 = new XRect(200.0, rc1_445, point454, num516);
              XStringFormat topLeft454 = XStringFormat.TopLeft;
              xgraphics454.DrawString(str233, xfont454, (XBrush) black445, xrect454, topLeft454);
              checked { SAPInput.RC1 += 12; }
              SAPInput.CheckRC1();
              XGraphics xgraphics455 = PDFFunctions.gfx[SAPInput.k];
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              string str234 = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.CommunityH.HeatSource1.Fuel + ", heat fraction " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.CommunityH.HeatSource1.HeatFraction) + ", efficiency " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.CommunityH.HeatSource1.Efficiency);
              XFont xfont455 = xfont3;
              XSolidBrush black446 = XBrushes.Black;
              double rc1_446 = (double) SAPInput.RC1;
              xunit8 = PDFFunctions.pages[SAPInput.k].Width;
              double point455 = ((XUnit) ref xunit8).Point;
              xunit8 = PDFFunctions.pages[SAPInput.k].Height;
              double num517 = ((XUnit) ref xunit8).Point / 2.0;
              XRect xrect455 = new XRect(205.0, rc1_446, point455, num517);
              XStringFormat topLeft455 = XStringFormat.TopLeft;
              xgraphics455.DrawString(str234, xfont455, (XBrush) black446, xrect455, topLeft455);
            }
            // ISSUE: reference to a compiler-generated field
            if (SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.CommunityH.NoOfAdditionalHeatSources > 1)
            {
              // ISSUE: reference to a compiler-generated method
              PCDF.Table4a_B table4aB = SAP_Module.PCDFData.Table4a_bs.Where<PCDF.Table4a_B>(new Func<PCDF.Table4a_B, bool>(closure160_2._Lambda\u0024__21)).SingleOrDefault<PCDF.Table4a_B>();
              checked { SAPInput.RC1 += 12; }
              SAPInput.CheckRC1();
              XGraphics xgraphics456 = PDFFunctions.gfx[SAPInput.k];
              string str235 = "Heat source: " + table4aB.Description;
              XFont xfont456 = xfont3;
              XSolidBrush black447 = XBrushes.Black;
              double rc1_447 = (double) SAPInput.RC1;
              xunit8 = PDFFunctions.pages[SAPInput.k].Width;
              double point456 = ((XUnit) ref xunit8).Point;
              xunit8 = PDFFunctions.pages[SAPInput.k].Height;
              double num518 = ((XUnit) ref xunit8).Point / 2.0;
              XRect xrect456 = new XRect(200.0, rc1_447, point456, num518);
              XStringFormat topLeft456 = XStringFormat.TopLeft;
              xgraphics456.DrawString(str235, xfont456, (XBrush) black447, xrect456, topLeft456);
              checked { SAPInput.RC1 += 12; }
              SAPInput.CheckRC1();
              XGraphics xgraphics457 = PDFFunctions.gfx[SAPInput.k];
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              string str236 = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.CommunityH.HeatSource2.Fuel + ", heat fraction " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.CommunityH.HeatSource2.HeatFraction) + ", efficiency " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.CommunityH.HeatSource2.Efficiency);
              XFont xfont457 = xfont3;
              XSolidBrush black448 = XBrushes.Black;
              double rc1_448 = (double) SAPInput.RC1;
              xunit8 = PDFFunctions.pages[SAPInput.k].Width;
              double point457 = ((XUnit) ref xunit8).Point;
              xunit8 = PDFFunctions.pages[SAPInput.k].Height;
              double num519 = ((XUnit) ref xunit8).Point / 2.0;
              XRect xrect457 = new XRect(205.0, rc1_448, point457, num519);
              XStringFormat topLeft457 = XStringFormat.TopLeft;
              xgraphics457.DrawString(str236, xfont457, (XBrush) black448, xrect457, topLeft457);
            }
            // ISSUE: reference to a compiler-generated field
            if (SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.CommunityH.NoOfAdditionalHeatSources > 2)
            {
              // ISSUE: reference to a compiler-generated method
              PCDF.Table4a_B table4aB = SAP_Module.PCDFData.Table4a_bs.Where<PCDF.Table4a_B>(new Func<PCDF.Table4a_B, bool>(closure160_2._Lambda\u0024__22)).SingleOrDefault<PCDF.Table4a_B>();
              checked { SAPInput.RC1 += 12; }
              SAPInput.CheckRC1();
              XGraphics xgraphics458 = PDFFunctions.gfx[SAPInput.k];
              string str237 = "Heat source: " + table4aB.Description;
              XFont xfont458 = xfont3;
              XSolidBrush black449 = XBrushes.Black;
              double rc1_449 = (double) SAPInput.RC1;
              xunit8 = PDFFunctions.pages[SAPInput.k].Width;
              double point458 = ((XUnit) ref xunit8).Point;
              xunit8 = PDFFunctions.pages[SAPInput.k].Height;
              double num520 = ((XUnit) ref xunit8).Point / 2.0;
              XRect xrect458 = new XRect(200.0, rc1_449, point458, num520);
              XStringFormat topLeft458 = XStringFormat.TopLeft;
              xgraphics458.DrawString(str237, xfont458, (XBrush) black449, xrect458, topLeft458);
              checked { SAPInput.RC1 += 12; }
              SAPInput.CheckRC1();
              XGraphics xgraphics459 = PDFFunctions.gfx[SAPInput.k];
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              string str238 = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.CommunityH.HeatSource3.Fuel + ", heat fraction " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.CommunityH.HeatSource3.HeatFraction) + ", efficiency " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.CommunityH.HeatSource3.Efficiency);
              XFont xfont459 = xfont3;
              XSolidBrush black450 = XBrushes.Black;
              double rc1_450 = (double) SAPInput.RC1;
              xunit8 = PDFFunctions.pages[SAPInput.k].Width;
              double point459 = ((XUnit) ref xunit8).Point;
              xunit8 = PDFFunctions.pages[SAPInput.k].Height;
              double num521 = ((XUnit) ref xunit8).Point / 2.0;
              XRect xrect459 = new XRect(205.0, rc1_450, point459, num521);
              XStringFormat topLeft459 = XStringFormat.TopLeft;
              xgraphics459.DrawString(str238, xfont459, (XBrush) black450, xrect459, topLeft459);
            }
            // ISSUE: reference to a compiler-generated field
            if (SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.CommunityH.NoOfAdditionalHeatSources > 3)
            {
              // ISSUE: reference to a compiler-generated method
              PCDF.Table4a_B table4aB = SAP_Module.PCDFData.Table4a_bs.Where<PCDF.Table4a_B>(new Func<PCDF.Table4a_B, bool>(closure160_2._Lambda\u0024__23)).SingleOrDefault<PCDF.Table4a_B>();
              checked { SAPInput.RC1 += 12; }
              SAPInput.CheckRC1();
              XGraphics xgraphics460 = PDFFunctions.gfx[SAPInput.k];
              string str239 = "Heat source: " + table4aB.Description;
              XFont xfont460 = xfont3;
              XSolidBrush black451 = XBrushes.Black;
              double rc1_451 = (double) SAPInput.RC1;
              xunit8 = PDFFunctions.pages[SAPInput.k].Width;
              double point460 = ((XUnit) ref xunit8).Point;
              xunit8 = PDFFunctions.pages[SAPInput.k].Height;
              double num522 = ((XUnit) ref xunit8).Point / 2.0;
              XRect xrect460 = new XRect(200.0, rc1_451, point460, num522);
              XStringFormat topLeft460 = XStringFormat.TopLeft;
              xgraphics460.DrawString(str239, xfont460, (XBrush) black451, xrect460, topLeft460);
              checked { SAPInput.RC1 += 12; }
              SAPInput.CheckRC1();
              XGraphics xgraphics461 = PDFFunctions.gfx[SAPInput.k];
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              string str240 = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.CommunityH.HeatSource4.Fuel + ", heat fraction " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.CommunityH.HeatSource4.HeatFraction) + ", efficiency " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.CommunityH.HeatSource4.Efficiency);
              XFont xfont461 = xfont3;
              XSolidBrush black452 = XBrushes.Black;
              double rc1_452 = (double) SAPInput.RC1;
              xunit8 = PDFFunctions.pages[SAPInput.k].Width;
              double point461 = ((XUnit) ref xunit8).Point;
              xunit8 = PDFFunctions.pages[SAPInput.k].Height;
              double num523 = ((XUnit) ref xunit8).Point / 2.0;
              XRect xrect461 = new XRect(205.0, rc1_452, point461, num523);
              XStringFormat topLeft461 = XStringFormat.TopLeft;
              xgraphics461.DrawString(str240, xfont461, (XBrush) black452, xrect461, topLeft461);
            }
            checked { SAPInput.RC1 += 12; }
            SAPInput.CheckRC1();
            XGraphics xgraphics462 = PDFFunctions.gfx[SAPInput.k];
            // ISSUE: reference to a compiler-generated field
            string heatDsystem = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.CommunityH.HeatDSystem;
            XFont xfont462 = xfont3;
            XSolidBrush black453 = XBrushes.Black;
            double rc1_453 = (double) SAPInput.RC1;
            xunit8 = PDFFunctions.pages[SAPInput.k].Width;
            double point462 = ((XUnit) ref xunit8).Point;
            xunit8 = PDFFunctions.pages[SAPInput.k].Height;
            double num524 = ((XUnit) ref xunit8).Point / 2.0;
            XRect xrect462 = new XRect(200.0, rc1_453, point462, num524);
            XStringFormat topLeft462 = XStringFormat.TopLeft;
            xgraphics462.DrawString(heatDsystem, xfont462, (XBrush) black453, xrect462, topLeft462);
          }
        }
        checked { SAPInput.RC1 += 14; }
        SAPInput.CheckRC1();
        // ISSUE: reference to a compiler-generated field
        if (!string.IsNullOrEmpty(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.Boiler.PumpType))
        {
          XGraphics xgraphics463 = PDFFunctions.gfx[SAPInput.k];
          // ISSUE: reference to a compiler-generated field
          string str241 = "Central heating pump : " + SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.Boiler.PumpType;
          XFont xfont463 = xfont3;
          XSolidBrush black454 = XBrushes.Black;
          double rc1_454 = (double) SAPInput.RC1;
          xunit8 = PDFFunctions.pages[SAPInput.k].Width;
          double point463 = ((XUnit) ref xunit8).Point;
          xunit8 = PDFFunctions.pages[SAPInput.k].Height;
          double num525 = ((XUnit) ref xunit8).Point / 2.0;
          XRect xrect463 = new XRect(200.0, rc1_454, point463, num525);
          XStringFormat topLeft463 = XStringFormat.TopLeft;
          xgraphics463.DrawString(str241, xfont463, (XBrush) black454, xrect463, topLeft463);
          checked { SAPInput.RC1 += 12; }
          SAPInput.CheckRC1();
        }
        // ISSUE: reference to a compiler-generated field
        if (!string.IsNullOrEmpty(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.Boiler.FlowTemp))
        {
          XGraphics xgraphics464 = PDFFunctions.gfx[SAPInput.k];
          // ISSUE: reference to a compiler-generated field
          string str242 = "Central heating pump : " + SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.Boiler.FlowTemp;
          XFont xfont464 = xfont3;
          XSolidBrush black455 = XBrushes.Black;
          double rc1_455 = (double) SAPInput.RC1;
          xunit8 = PDFFunctions.pages[SAPInput.k].Width;
          double point464 = ((XUnit) ref xunit8).Point;
          xunit8 = PDFFunctions.pages[SAPInput.k].Height;
          double num526 = ((XUnit) ref xunit8).Point / 2.0;
          XRect xrect464 = new XRect(200.0, rc1_455, point464, num526);
          XStringFormat topLeft464 = XStringFormat.TopLeft;
          xgraphics464.DrawString(str242, xfont464, (XBrush) black455, xrect464, topLeft464);
          checked { SAPInput.RC1 += 12; }
          SAPInput.CheckRC1();
        }
        // ISSUE: reference to a compiler-generated field
        if (!string.IsNullOrEmpty(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.Boiler.FlueType))
        {
          XGraphics xgraphics465 = PDFFunctions.gfx[SAPInput.k];
          // ISSUE: reference to a compiler-generated field
          string flueType = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.Boiler.FlueType;
          XFont xfont465 = xfont3;
          XSolidBrush black456 = XBrushes.Black;
          double rc1_456 = (double) SAPInput.RC1;
          xunit8 = PDFFunctions.pages[SAPInput.k].Width;
          double point465 = ((XUnit) ref xunit8).Point;
          xunit8 = PDFFunctions.pages[SAPInput.k].Height;
          double num527 = ((XUnit) ref xunit8).Point / 2.0;
          XRect xrect465 = new XRect(200.0, rc1_456, point465, num527);
          XStringFormat topLeft465 = XStringFormat.TopLeft;
          xgraphics465.DrawString(flueType, xfont465, (XBrush) black456, xrect465, topLeft465);
          checked { SAPInput.RC1 += 12; }
          SAPInput.CheckRC1();
        }
        // ISSUE: reference to a compiler-generated field
        if (!string.IsNullOrEmpty(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.Boiler.BILock))
        {
          XGraphics xgraphics466 = PDFFunctions.gfx[SAPInput.k];
          // ISSUE: reference to a compiler-generated field
          string str243 = "Boiler interlock: " + SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.Boiler.BILock;
          XFont xfont466 = xfont3;
          XSolidBrush black457 = XBrushes.Black;
          double rc1_457 = (double) SAPInput.RC1;
          xunit8 = PDFFunctions.pages[SAPInput.k].Width;
          double point466 = ((XUnit) ref xunit8).Point;
          xunit8 = PDFFunctions.pages[SAPInput.k].Height;
          double num528 = ((XUnit) ref xunit8).Point / 2.0;
          XRect xrect466 = new XRect(200.0, rc1_457, point466, num528);
          XStringFormat topLeft466 = XStringFormat.TopLeft;
          xgraphics466.DrawString(str243, xfont466, (XBrush) black457, xrect466, topLeft466);
          checked { SAPInput.RC1 += 12; }
          SAPInput.CheckRC1();
        }
        try
        {
          // ISSUE: reference to a compiler-generated field
          if ((uint) Operators.CompareString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.Boiler.LoadWeatherType, "", false) > 0U)
          {
            XGraphics xgraphics467 = PDFFunctions.gfx[SAPInput.k];
            // ISSUE: reference to a compiler-generated field
            string loadWeatherType = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.Boiler.LoadWeatherType;
            XFont xfont467 = xfont3;
            XSolidBrush black458 = XBrushes.Black;
            double rc1_458 = (double) SAPInput.RC1;
            xunit8 = PDFFunctions.pages[SAPInput.k].Width;
            double point467 = ((XUnit) ref xunit8).Point;
            xunit8 = PDFFunctions.pages[SAPInput.k].Height;
            double num529 = ((XUnit) ref xunit8).Point / 2.0;
            XRect xrect467 = new XRect(200.0, rc1_458, point467, num529);
            XStringFormat topLeft467 = XStringFormat.TopLeft;
            xgraphics467.DrawString(loadWeatherType, xfont467, (XBrush) black458, xrect467, topLeft467);
            checked { SAPInput.RC1 += 14; }
          }
          else
          {
            // ISSUE: reference to a compiler-generated field
            if ((uint) Operators.CompareString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.Compensator, "", false) > 0U)
            {
              XGraphics xgraphics468 = PDFFunctions.gfx[SAPInput.k];
              // ISSUE: reference to a compiler-generated field
              string compensator = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.Compensator;
              XFont xfont468 = xfont3;
              XSolidBrush black459 = XBrushes.Black;
              double rc1_459 = (double) SAPInput.RC1;
              xunit8 = PDFFunctions.pages[SAPInput.k].Width;
              double point468 = ((XUnit) ref xunit8).Point;
              xunit8 = PDFFunctions.pages[SAPInput.k].Height;
              double num530 = ((XUnit) ref xunit8).Point / 2.0;
              XRect xrect468 = new XRect(200.0, rc1_459, point468, num530);
              XStringFormat topLeft468 = XStringFormat.TopLeft;
              xgraphics468.DrawString(compensator, xfont468, (XBrush) black459, xrect468, topLeft468);
              checked { SAPInput.RC1 += 14; }
            }
          }
        }
        catch (Exception ex)
        {
          int lErl = num30;
          ProjectData.SetProjectError(ex, lErl);
          ProjectData.ClearProjectError();
        }
        try
        {
          // ISSUE: reference to a compiler-generated field
          if (SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.Boiler.IncludeKeepHot)
          {
            XGraphics xgraphics469 = PDFFunctions.gfx[SAPInput.k];
            // ISSUE: reference to a compiler-generated field
            string str244 = "Keep hot Facility " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.Boiler.KeepHotTimed);
            XFont xfont469 = xfont3;
            XSolidBrush black460 = XBrushes.Black;
            double rc1_460 = (double) SAPInput.RC1;
            XUnit xunit9 = PDFFunctions.pages[SAPInput.k].Width;
            double point469 = ((XUnit) ref xunit9).Point;
            xunit9 = PDFFunctions.pages[SAPInput.k].Height;
            double num531 = ((XUnit) ref xunit9).Point / 2.0;
            XRect xrect469 = new XRect(200.0, rc1_460, point469, num531);
            XStringFormat topLeft469 = XStringFormat.TopLeft;
            xgraphics469.DrawString(str244, xfont469, (XBrush) black460, xrect469, topLeft469);
            checked { SAPInput.RC1 += 12; }
            XGraphics xgraphics470 = PDFFunctions.gfx[SAPInput.k];
            // ISSUE: reference to a compiler-generated field
            string str245 = "Keep hot Facility (Fuel used) " + SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.Boiler.KeepHotFuel;
            XFont xfont470 = xfont3;
            XSolidBrush black461 = XBrushes.Black;
            double rc1_461 = (double) SAPInput.RC1;
            xunit9 = PDFFunctions.pages[SAPInput.k].Width;
            double point470 = ((XUnit) ref xunit9).Point;
            xunit9 = PDFFunctions.pages[SAPInput.k].Height;
            double num532 = ((XUnit) ref xunit9).Point / 2.0;
            XRect xrect470 = new XRect(200.0, rc1_461, point470, num532);
            XStringFormat topLeft470 = XStringFormat.TopLeft;
            xgraphics470.DrawString(str245, xfont470, (XBrush) black461, xrect470, topLeft470);
            checked { SAPInput.RC1 += 14; }
          }
        }
        catch (Exception ex)
        {
          int lErl = num30;
          ProjectData.SetProjectError(ex, lErl);
          ProjectData.ClearProjectError();
        }
        try
        {
          // ISSUE: reference to a compiler-generated field
          if (SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.DelayedStart)
          {
            XGraphics xgraphics471 = PDFFunctions.gfx[SAPInput.k];
            XFont xfont471 = xfont3;
            XSolidBrush black462 = XBrushes.Black;
            double rc1_462 = (double) SAPInput.RC1;
            XUnit xunit10 = PDFFunctions.pages[SAPInput.k].Width;
            double point471 = ((XUnit) ref xunit10).Point;
            xunit10 = PDFFunctions.pages[SAPInput.k].Height;
            double num533 = ((XUnit) ref xunit10).Point / 2.0;
            XRect xrect471 = new XRect(200.0, rc1_462, point471, num533);
            XStringFormat topLeft471 = XStringFormat.TopLeft;
            xgraphics471.DrawString("Delayed start ", xfont471, (XBrush) black462, xrect471, topLeft471);
            checked { SAPInput.RC1 += 14; }
          }
        }
        catch (Exception ex)
        {
          int lErl = num30;
          ProjectData.SetProjectError(ex, lErl);
          ProjectData.ClearProjectError();
        }
        XUnit xunit11;
        // ISSUE: reference to a compiler-generated field
        if (SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.MCSCert)
        {
          XGraphics xgraphics472 = PDFFunctions.gfx[SAPInput.k];
          XFont xfont472 = xfont3;
          XSolidBrush black463 = XBrushes.Black;
          double rc1_463 = (double) SAPInput.RC1;
          xunit11 = PDFFunctions.pages[SAPInput.k].Width;
          double point472 = ((XUnit) ref xunit11).Point;
          xunit11 = PDFFunctions.pages[SAPInput.k].Height;
          double num534 = ((XUnit) ref xunit11).Point / 2.0;
          XRect xrect472 = new XRect(200.0, rc1_463, point472, num534);
          XStringFormat topLeft472 = XStringFormat.TopLeft;
          xgraphics472.DrawString("MCS Installation Certificate", xfont472, (XBrush) black463, xrect472, topLeft472);
          checked { SAPInput.RC1 += 14; }
          SAPInput.CheckRC1();
        }
        PDFFunctions.xBrush1 = XBrush.op_Implicit((Brush) new SolidBrush(Color.FromArgb(159, 172, 62)));
        PDFFunctions.Points[0].X = 20f;
        PDFFunctions.Points[0].Y = (float) SAPInput.RC1;
        ref PointF local19 = ref PDFFunctions.Points[1];
        xunit11 = PDFFunctions.pages[SAPInput.k].Width;
        double num535 = ((XUnit) ref xunit11).Point - 20.0;
        local19.X = (float) num535;
        PDFFunctions.Points[1].Y = (float) SAPInput.RC1;
        ref PointF local20 = ref PDFFunctions.Points[2];
        xunit11 = PDFFunctions.pages[SAPInput.k].Width;
        double num536 = ((XUnit) ref xunit11).Point - 20.0;
        local20.X = (float) num536;
        PDFFunctions.Points[2].Y = (float) checked (SAPInput.RC1 + 14);
        PDFFunctions.Points[3].X = 20f;
        PDFFunctions.Points[3].Y = (float) checked (SAPInput.RC1 + 14);
        PDFFunctions.gfx[SAPInput.k].DrawPolygon(PDFFunctions.polyGreen2, PDFFunctions.xBrush1, PDFFunctions.Points, xfillMode);
        XGraphics xgraphics473 = PDFFunctions.gfx[SAPInput.k];
        XFont xfont473 = xfont3;
        XSolidBrush white10 = XBrushes.White;
        double num537 = (double) checked (SAPInput.RC1 + 1);
        xunit11 = PDFFunctions.pages[SAPInput.k].Width;
        double point473 = ((XUnit) ref xunit11).Point;
        xunit11 = PDFFunctions.pages[SAPInput.k].Height;
        double num538 = ((XUnit) ref xunit11).Point / 2.0;
        XRect xrect473 = new XRect(25.0, num537, point473, num538);
        XStringFormat topLeft473 = XStringFormat.TopLeft;
        xgraphics473.DrawString("Secondary Main heating Control:", xfont473, (XBrush) white10, xrect473, topLeft473);
        SAPInput.RC1 = checked ((int) Math.Round(unchecked ((double) PDFFunctions.Points[3].Y + 4.0)));
        SAPInput.CheckRC1();
        XGraphics xgraphics474 = PDFFunctions.gfx[SAPInput.k];
        XFont xfont474 = xfont2;
        XSolidBrush black464 = XBrushes.Black;
        double rc1_464 = (double) SAPInput.RC1;
        xunit11 = PDFFunctions.pages[SAPInput.k].Width;
        double point474 = ((XUnit) ref xunit11).Point;
        xunit11 = PDFFunctions.pages[SAPInput.k].Height;
        double num539 = ((XUnit) ref xunit11).Point / 2.0;
        XRect xrect474 = new XRect(20.0, rc1_464, point474, num539);
        XStringFormat topLeft474 = XStringFormat.TopLeft;
        xgraphics474.DrawString("Secondary Main heating Control: ", xfont474, (XBrush) black464, xrect474, topLeft474);
        try
        {
          // ISSUE: reference to a compiler-generated field
          string[] strArray = SAPInput.CheckTextWidth2(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.Controls, 200);
          if (strArray != null)
          {
            if (strArray[0].Length == 0)
            {
              // ISSUE: reference to a compiler-generated field
              strArray[0] = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.Controls;
            }
            int num540 = checked (strArray.Length - 1);
            int index24 = 0;
            while (index24 <= num540)
            {
              if ((uint) Operators.CompareString(strArray[index24], "", false) > 0U)
              {
                XGraphics xgraphics475 = PDFFunctions.gfx[SAPInput.k];
                string str246 = strArray[index24];
                XFont xfont475 = xfont3;
                XSolidBrush black465 = XBrushes.Black;
                double rc1_465 = (double) SAPInput.RC1;
                xunit11 = PDFFunctions.pages[SAPInput.k].Width;
                double point475 = ((XUnit) ref xunit11).Point;
                xunit11 = PDFFunctions.pages[SAPInput.k].Height;
                double num541 = ((XUnit) ref xunit11).Point / 2.0;
                XRect xrect475 = new XRect(200.0, rc1_465, point475, num541);
                XStringFormat topLeft475 = XStringFormat.TopLeft;
                xgraphics475.DrawString(str246, xfont475, (XBrush) black465, xrect475, topLeft475);
                checked { SAPInput.RC1 += 12; }
                SAPInput.CheckRC1();
              }
              checked { ++index24; }
            }
          }
        }
        catch (Exception ex)
        {
          int lErl = num30;
          ProjectData.SetProjectError(ex, lErl);
          ProjectData.ClearProjectError();
        }
        XGraphics xgraphics476 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string str247 = "Control code: " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.ControlCode);
        XFont xfont476 = xfont3;
        XSolidBrush black466 = XBrushes.Black;
        double rc1_466 = (double) SAPInput.RC1;
        xunit8 = PDFFunctions.pages[SAPInput.k].Width;
        double point476 = ((XUnit) ref xunit8).Point;
        xunit8 = PDFFunctions.pages[SAPInput.k].Height;
        double num542 = ((XUnit) ref xunit8).Point / 2.0;
        XRect xrect476 = new XRect(200.0, rc1_466, point476, num542);
        XStringFormat topLeft476 = XStringFormat.TopLeft;
        xgraphics476.DrawString(str247, xfont476, (XBrush) black466, xrect476, topLeft476);
        checked { SAPInput.RC1 += 14; }
        SAPInput.CheckRC1();
        // ISSUE: reference to a compiler-generated field
        if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.HGroup, "Central heating systems with radiators or underfloor heating", false) == 0)
        {
          XGraphics xgraphics477 = PDFFunctions.gfx[SAPInput.k];
          // ISSUE: reference to a compiler-generated field
          string str248 = "Boiler interlock: " + SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating2.Boiler.BILock;
          XFont xfont477 = xfont3;
          XSolidBrush black467 = XBrushes.Black;
          double rc1_467 = (double) SAPInput.RC1;
          xunit8 = PDFFunctions.pages[SAPInput.k].Width;
          double point477 = ((XUnit) ref xunit8).Point;
          xunit8 = PDFFunctions.pages[SAPInput.k].Height;
          double num543 = ((XUnit) ref xunit8).Point / 2.0;
          XRect xrect477 = new XRect(200.0, rc1_467, point477, num543);
          XStringFormat topLeft477 = XStringFormat.TopLeft;
          xgraphics477.DrawString(str248, xfont477, (XBrush) black467, xrect477, topLeft477);
          checked { SAPInput.RC1 += 14; }
          SAPInput.CheckRC1();
        }
      }
      PDFFunctions.xBrush1 = XBrush.op_Implicit((Brush) new SolidBrush(Color.FromArgb(159, 172, 62)));
      PDFFunctions.Points[0].X = 20f;
      PDFFunctions.Points[0].Y = (float) SAPInput.RC1;
      ref PointF local21 = ref PDFFunctions.Points[1];
      xunit8 = PDFFunctions.pages[SAPInput.k].Width;
      double num544 = ((XUnit) ref xunit8).Point - 20.0;
      local21.X = (float) num544;
      PDFFunctions.Points[1].Y = (float) SAPInput.RC1;
      ref PointF local22 = ref PDFFunctions.Points[2];
      xunit8 = PDFFunctions.pages[SAPInput.k].Width;
      double num545 = ((XUnit) ref xunit8).Point - 20.0;
      local22.X = (float) num545;
      PDFFunctions.Points[2].Y = (float) checked (SAPInput.RC1 + 14);
      PDFFunctions.Points[3].X = 20f;
      PDFFunctions.Points[3].Y = (float) checked (SAPInput.RC1 + 14);
      PDFFunctions.gfx[SAPInput.k].DrawPolygon(PDFFunctions.polyGreen2, PDFFunctions.xBrush1, PDFFunctions.Points, xfillMode);
      XGraphics xgraphics478 = PDFFunctions.gfx[SAPInput.k];
      XFont xfont478 = xfont3;
      XSolidBrush white11 = XBrushes.White;
      double num546 = (double) checked (SAPInput.RC1 + 1);
      xunit8 = PDFFunctions.pages[SAPInput.k].Width;
      double point478 = ((XUnit) ref xunit8).Point;
      xunit8 = PDFFunctions.pages[SAPInput.k].Height;
      double num547 = ((XUnit) ref xunit8).Point / 2.0;
      XRect xrect478 = new XRect(25.0, num546, point478, num547);
      XStringFormat topLeft478 = XStringFormat.TopLeft;
      xgraphics478.DrawString("Secondary heating system:", xfont478, (XBrush) white11, xrect478, topLeft478);
      SAPInput.RC1 = checked ((int) Math.Round(unchecked ((double) PDFFunctions.Points[3].Y + 4.0)));
      XGraphics xgraphics479 = PDFFunctions.gfx[SAPInput.k];
      XFont xfont479 = xfont2;
      XSolidBrush black468 = XBrushes.Black;
      double rc1_468 = (double) SAPInput.RC1;
      xunit8 = PDFFunctions.pages[SAPInput.k].Width;
      double point479 = ((XUnit) ref xunit8).Point;
      xunit8 = PDFFunctions.pages[SAPInput.k].Height;
      double num548 = ((XUnit) ref xunit8).Point / 2.0;
      XRect xrect479 = new XRect(20.0, rc1_468, point479, num548);
      XStringFormat topLeft479 = XStringFormat.TopLeft;
      xgraphics479.DrawString("Secondary heating system:", xfont479, (XBrush) black468, xrect479, topLeft479);
      // ISSUE: reference to a compiler-generated field
      if (SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].SecHeating.SAPTableCode == 0)
      {
        XGraphics xgraphics480 = PDFFunctions.gfx[SAPInput.k];
        XFont xfont480 = xfont3;
        XSolidBrush black469 = XBrushes.Black;
        double num549 = (double) checked (SAPInput.RC1 + 1);
        xunit8 = PDFFunctions.pages[SAPInput.k].Width;
        double point480 = ((XUnit) ref xunit8).Point;
        xunit8 = PDFFunctions.pages[SAPInput.k].Height;
        double num550 = ((XUnit) ref xunit8).Point / 2.0;
        XRect xrect480 = new XRect(200.0, num549, point480, num550);
        XStringFormat topLeft480 = XStringFormat.TopLeft;
        xgraphics480.DrawString("None", xfont480, (XBrush) black469, xrect480, topLeft480);
      }
      else
      {
        XGraphics xgraphics481 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string hgroup3 = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].SecHeating.HGroup;
        XFont xfont481 = xfont3;
        XSolidBrush black470 = XBrushes.Black;
        double rc1_469 = (double) SAPInput.RC1;
        xunit8 = PDFFunctions.pages[SAPInput.k].Width;
        double point481 = ((XUnit) ref xunit8).Point;
        xunit8 = PDFFunctions.pages[SAPInput.k].Height;
        double num551 = ((XUnit) ref xunit8).Point / 2.0;
        XRect xrect481 = new XRect(200.0, rc1_469, point481, num551);
        XStringFormat topLeft481 = XStringFormat.TopLeft;
        xgraphics481.DrawString(hgroup3, xfont481, (XBrush) black470, xrect481, topLeft481);
        checked { SAPInput.RC1 += 12; }
        XGraphics xgraphics482 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string sgroup = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].SecHeating.SGroup;
        XFont xfont482 = xfont3;
        XSolidBrush black471 = XBrushes.Black;
        double rc1_470 = (double) SAPInput.RC1;
        xunit8 = PDFFunctions.pages[SAPInput.k].Width;
        double point482 = ((XUnit) ref xunit8).Point;
        xunit8 = PDFFunctions.pages[SAPInput.k].Height;
        double num552 = ((XUnit) ref xunit8).Point / 2.0;
        XRect xrect482 = new XRect(200.0, rc1_470, point482, num552);
        XStringFormat topLeft482 = XStringFormat.TopLeft;
        xgraphics482.DrawString(sgroup, xfont482, (XBrush) black471, xrect482, topLeft482);
        checked { SAPInput.RC1 += 12; }
        XGraphics xgraphics483 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string str249 = "Fuel :" + SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].SecHeating.Fuel;
        XFont xfont483 = xfont3;
        XSolidBrush black472 = XBrushes.Black;
        double rc1_471 = (double) SAPInput.RC1;
        xunit8 = PDFFunctions.pages[SAPInput.k].Width;
        double point483 = ((XUnit) ref xunit8).Point;
        xunit8 = PDFFunctions.pages[SAPInput.k].Height;
        double num553 = ((XUnit) ref xunit8).Point / 2.0;
        XRect xrect483 = new XRect(200.0, rc1_471, point483, num553);
        XStringFormat topLeft483 = XStringFormat.TopLeft;
        xgraphics483.DrawString(str249, xfont483, (XBrush) black472, xrect483, topLeft483);
        checked { SAPInput.RC1 += 12; }
        XGraphics xgraphics484 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string str250 = "Info Source: " + SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].SecHeating.InforSource;
        XFont xfont484 = xfont3;
        XSolidBrush black473 = XBrushes.Black;
        double rc1_472 = (double) SAPInput.RC1;
        xunit8 = PDFFunctions.pages[SAPInput.k].Width;
        double point484 = ((XUnit) ref xunit8).Point;
        xunit8 = PDFFunctions.pages[SAPInput.k].Height;
        double num554 = ((XUnit) ref xunit8).Point / 2.0;
        XRect xrect484 = new XRect(200.0, rc1_472, point484, num554);
        XStringFormat topLeft484 = XStringFormat.TopLeft;
        xgraphics484.DrawString(str250, xfont484, (XBrush) black473, xrect484, topLeft484);
        checked { SAPInput.RC1 += 12; }
        XGraphics xgraphics485 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string mhType = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].SecHeating.MHType;
        XFont xfont485 = xfont3;
        XSolidBrush black474 = XBrushes.Black;
        double rc1_473 = (double) SAPInput.RC1;
        xunit8 = PDFFunctions.pages[SAPInput.k].Width;
        double point485 = ((XUnit) ref xunit8).Point;
        xunit8 = PDFFunctions.pages[SAPInput.k].Height;
        double num555 = ((XUnit) ref xunit8).Point / 2.0;
        XRect xrect485 = new XRect(200.0, rc1_473, point485, num555);
        XStringFormat topLeft485 = XStringFormat.TopLeft;
        xgraphics485.DrawString(mhType, xfont485, (XBrush) black474, xrect485, topLeft485);
        checked { SAPInput.RC1 += 12; }
        try
        {
          // ISSUE: reference to a compiler-generated field
          if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].SecHeating.HETAS, "Yes", false) == 0)
          {
            XGraphics xgraphics486 = PDFFunctions.gfx[SAPInput.k];
            XFont xfont486 = xfont3;
            XSolidBrush black475 = XBrushes.Black;
            double rc1_474 = (double) SAPInput.RC1;
            xunit8 = PDFFunctions.pages[SAPInput.k].Width;
            double point486 = ((XUnit) ref xunit8).Point;
            xunit8 = PDFFunctions.pages[SAPInput.k].Height;
            double num556 = ((XUnit) ref xunit8).Point / 2.0;
            XRect xrect486 = new XRect(200.0, rc1_474, point486, num556);
            XStringFormat topLeft486 = XStringFormat.TopLeft;
            xgraphics486.DrawString("HETAS Approved", xfont486, (XBrush) black475, xrect486, topLeft486);
            checked { SAPInput.RC1 += 12; }
          }
        }
        catch (Exception ex)
        {
          int lErl = num30;
          ProjectData.SetProjectError(ex, lErl);
          ProjectData.ClearProjectError();
        }
      }
      checked { SAPInput.RC1 += 14; }
      SAPInput.CheckRC1();
      XUnit xunit12;
      // ISSUE: reference to a compiler-generated field
      if (SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Cooling.Include)
      {
        PDFFunctions.xBrush1 = XBrush.op_Implicit((Brush) new SolidBrush(Color.FromArgb(159, 172, 62)));
        PDFFunctions.Points[0].X = 20f;
        PDFFunctions.Points[0].Y = (float) SAPInput.RC1;
        ref PointF local23 = ref PDFFunctions.Points[1];
        XUnit width5 = PDFFunctions.pages[SAPInput.k].Width;
        double num557 = ((XUnit) ref width5).Point - 20.0;
        local23.X = (float) num557;
        PDFFunctions.Points[1].Y = (float) SAPInput.RC1;
        ref PointF local24 = ref PDFFunctions.Points[2];
        XUnit width6 = PDFFunctions.pages[SAPInput.k].Width;
        double num558 = ((XUnit) ref width6).Point - 20.0;
        local24.X = (float) num558;
        PDFFunctions.Points[2].Y = (float) checked (SAPInput.RC1 + 14);
        PDFFunctions.Points[3].X = 20f;
        PDFFunctions.Points[3].Y = (float) checked (SAPInput.RC1 + 14);
        PDFFunctions.gfx[SAPInput.k].DrawPolygon(PDFFunctions.polyGreen2, PDFFunctions.xBrush1, PDFFunctions.Points, xfillMode);
        XGraphics xgraphics487 = PDFFunctions.gfx[SAPInput.k];
        XFont xfont487 = xfont3;
        XSolidBrush white12 = XBrushes.White;
        double num559 = (double) checked (SAPInput.RC1 + 1);
        XUnit width7 = PDFFunctions.pages[SAPInput.k].Width;
        double point487 = ((XUnit) ref width7).Point;
        XUnit height3 = PDFFunctions.pages[SAPInput.k].Height;
        double num560 = ((XUnit) ref height3).Point / 2.0;
        XRect xrect487 = new XRect(25.0, num559, point487, num560);
        XStringFormat topLeft487 = XStringFormat.TopLeft;
        xgraphics487.DrawString("Space cooling system:", xfont487, (XBrush) white12, xrect487, topLeft487);
        SAPInput.RC1 = checked ((int) Math.Round(unchecked ((double) PDFFunctions.Points[3].Y + 4.0)));
        SAPInput.CheckRC1();
        XGraphics xgraphics488 = PDFFunctions.gfx[SAPInput.k];
        XFont xfont488 = xfont2;
        XSolidBrush black476 = XBrushes.Black;
        double rc1_475 = (double) SAPInput.RC1;
        XUnit width8 = PDFFunctions.pages[SAPInput.k].Width;
        double point488 = ((XUnit) ref width8).Point;
        XUnit height4 = PDFFunctions.pages[SAPInput.k].Height;
        double num561 = ((XUnit) ref height4).Point / 2.0;
        XRect xrect488 = new XRect(20.0, rc1_475, point488, num561);
        XStringFormat topLeft488 = XStringFormat.TopLeft;
        xgraphics488.DrawString("Space cooling system:", xfont488, (XBrush) black476, xrect488, topLeft488);
        XGraphics xgraphics489 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string systemType = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Cooling.SystemType;
        XFont xfont489 = xfont3;
        XSolidBrush black477 = XBrushes.Black;
        double rc1_476 = (double) SAPInput.RC1;
        XUnit width9 = PDFFunctions.pages[SAPInput.k].Width;
        double point489 = ((XUnit) ref width9).Point;
        xunit12 = PDFFunctions.pages[SAPInput.k].Height;
        double num562 = ((XUnit) ref xunit12).Point / 2.0;
        XRect xrect489 = new XRect(200.0, rc1_476, point489, num562);
        XStringFormat topLeft489 = XStringFormat.TopLeft;
        xgraphics489.DrawString(systemType, xfont489, (XBrush) black477, xrect489, topLeft489);
        checked { SAPInput.RC1 += 12; }
        SAPInput.CheckRC1();
        // ISSUE: reference to a compiler-generated field
        if (SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Cooling.ERRMeasuredInclude)
        {
          XGraphics xgraphics490 = PDFFunctions.gfx[SAPInput.k];
          XFont xfont490 = xfont3;
          XSolidBrush black478 = XBrushes.Black;
          double rc1_477 = (double) SAPInput.RC1;
          xunit12 = PDFFunctions.pages[SAPInput.k].Width;
          double point490 = ((XUnit) ref xunit12).Point;
          xunit12 = PDFFunctions.pages[SAPInput.k].Height;
          double num563 = ((XUnit) ref xunit12).Point / 2.0;
          XRect xrect490 = new XRect(200.0, rc1_477, point490, num563);
          XStringFormat topLeft490 = XStringFormat.TopLeft;
          xgraphics490.DrawString("Tested data to EN 14511: ", xfont490, (XBrush) black478, xrect490, topLeft490);
          checked { SAPInput.RC1 += 12; }
          SAPInput.CheckRC1();
          XGraphics xgraphics491 = PDFFunctions.gfx[SAPInput.k];
          // ISSUE: reference to a compiler-generated field
          string str251 = "Brand/Model: " + SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Cooling.Description;
          XFont xfont491 = xfont3;
          XSolidBrush black479 = XBrushes.Black;
          double rc1_478 = (double) SAPInput.RC1;
          xunit12 = PDFFunctions.pages[SAPInput.k].Width;
          double point491 = ((XUnit) ref xunit12).Point;
          xunit12 = PDFFunctions.pages[SAPInput.k].Height;
          double num564 = ((XUnit) ref xunit12).Point / 2.0;
          XRect xrect491 = new XRect(205.0, rc1_478, point491, num564);
          XStringFormat topLeft491 = XStringFormat.TopLeft;
          xgraphics491.DrawString(str251, xfont491, (XBrush) black479, xrect491, topLeft491);
          checked { SAPInput.RC1 += 12; }
          SAPInput.CheckRC1();
          XGraphics xgraphics492 = PDFFunctions.gfx[SAPInput.k];
          // ISSUE: reference to a compiler-generated field
          string str252 = "EER: " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Cooling.ERR);
          XFont xfont492 = xfont3;
          XSolidBrush black480 = XBrushes.Black;
          double rc1_479 = (double) SAPInput.RC1;
          xunit12 = PDFFunctions.pages[SAPInput.k].Width;
          double point492 = ((XUnit) ref xunit12).Point;
          xunit12 = PDFFunctions.pages[SAPInput.k].Height;
          double num565 = ((XUnit) ref xunit12).Point / 2.0;
          XRect xrect492 = new XRect(205.0, rc1_479, point492, num565);
          XStringFormat topLeft492 = XStringFormat.TopLeft;
          xgraphics492.DrawString(str252, xfont492, (XBrush) black480, xrect492, topLeft492);
          checked { SAPInput.RC1 += 12; }
          SAPInput.CheckRC1();
        }
        else
        {
          XGraphics xgraphics493 = PDFFunctions.gfx[SAPInput.k];
          // ISSUE: reference to a compiler-generated field
          string str253 = "Energy label class: " + SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Cooling.Energylabel;
          XFont xfont493 = xfont3;
          XSolidBrush black481 = XBrushes.Black;
          double rc1_480 = (double) SAPInput.RC1;
          xunit12 = PDFFunctions.pages[SAPInput.k].Width;
          double point493 = ((XUnit) ref xunit12).Point;
          xunit12 = PDFFunctions.pages[SAPInput.k].Height;
          double num566 = ((XUnit) ref xunit12).Point / 2.0;
          XRect xrect493 = new XRect(200.0, rc1_480, point493, num566);
          XStringFormat topLeft493 = XStringFormat.TopLeft;
          xgraphics493.DrawString(str253, xfont493, (XBrush) black481, xrect493, topLeft493);
          checked { SAPInput.RC1 += 12; }
          SAPInput.CheckRC1();
        }
        XGraphics xgraphics494 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string str254 = "Compressor control: " + SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Cooling.Compressorcontrol;
        XFont xfont494 = xfont3;
        XSolidBrush black482 = XBrushes.Black;
        double rc1_481 = (double) SAPInput.RC1;
        xunit12 = PDFFunctions.pages[SAPInput.k].Width;
        double point494 = ((XUnit) ref xunit12).Point;
        xunit12 = PDFFunctions.pages[SAPInput.k].Height;
        double num567 = ((XUnit) ref xunit12).Point / 2.0;
        XRect xrect494 = new XRect(200.0, rc1_481, point494, num567);
        XStringFormat topLeft494 = XStringFormat.TopLeft;
        xgraphics494.DrawString(str254, xfont494, (XBrush) black482, xrect494, topLeft494);
        checked { SAPInput.RC1 += 12; }
        SAPInput.CheckRC1();
        XGraphics xgraphics495 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        string str255 = "Cooled area: " + SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Cooling.Cooled_Area + " (fraction " + Microsoft.VisualBasic.Strings.Format((object) (Conversions.ToDouble(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Cooling.Cooled_Area) / SAP_Module.Calculation2012.Calculation.Dimensions.Box4), "#0.000") + ")";
        XFont xfont495 = xfont3;
        XSolidBrush black483 = XBrushes.Black;
        double rc1_482 = (double) SAPInput.RC1;
        xunit12 = PDFFunctions.pages[SAPInput.k].Width;
        double point495 = ((XUnit) ref xunit12).Point;
        xunit12 = PDFFunctions.pages[SAPInput.k].Height;
        double num568 = ((XUnit) ref xunit12).Point / 2.0;
        XRect xrect495 = new XRect(200.0, rc1_482, point495, num568);
        XStringFormat topLeft495 = XStringFormat.TopLeft;
        xgraphics495.DrawString(str255, xfont495, (XBrush) black483, xrect495, topLeft495);
        checked { SAPInput.RC1 += 12; }
        SAPInput.CheckRC1();
      }
      PDFFunctions.xBrush1 = XBrush.op_Implicit((Brush) new SolidBrush(Color.FromArgb(159, 172, 62)));
      PDFFunctions.Points[0].X = 20f;
      PDFFunctions.Points[0].Y = (float) SAPInput.RC1;
      ref PointF local25 = ref PDFFunctions.Points[1];
      xunit12 = PDFFunctions.pages[SAPInput.k].Width;
      double num569 = ((XUnit) ref xunit12).Point - 20.0;
      local25.X = (float) num569;
      PDFFunctions.Points[1].Y = (float) SAPInput.RC1;
      ref PointF local26 = ref PDFFunctions.Points[2];
      xunit12 = PDFFunctions.pages[SAPInput.k].Width;
      double num570 = ((XUnit) ref xunit12).Point - 20.0;
      local26.X = (float) num570;
      PDFFunctions.Points[2].Y = (float) checked (SAPInput.RC1 + 14);
      PDFFunctions.Points[3].X = 20f;
      PDFFunctions.Points[3].Y = (float) checked (SAPInput.RC1 + 14);
      PDFFunctions.gfx[SAPInput.k].DrawPolygon(PDFFunctions.polyGreen2, PDFFunctions.xBrush1, PDFFunctions.Points, xfillMode);
      XGraphics xgraphics496 = PDFFunctions.gfx[SAPInput.k];
      XFont xfont496 = xfont3;
      XSolidBrush white13 = XBrushes.White;
      double num571 = (double) checked (SAPInput.RC1 + 1);
      xunit12 = PDFFunctions.pages[SAPInput.k].Width;
      double point496 = ((XUnit) ref xunit12).Point;
      xunit12 = PDFFunctions.pages[SAPInput.k].Height;
      double num572 = ((XUnit) ref xunit12).Point / 2.0;
      XRect xrect496 = new XRect(25.0, num571, point496, num572);
      XStringFormat topLeft496 = XStringFormat.TopLeft;
      xgraphics496.DrawString("Water heating:", xfont496, (XBrush) white13, xrect496, topLeft496);
      SAPInput.RC1 = checked ((int) Math.Round(unchecked ((double) PDFFunctions.Points[3].Y + 4.0)));
      XGraphics xgraphics497 = PDFFunctions.gfx[SAPInput.k];
      XFont xfont497 = xfont2;
      XSolidBrush black484 = XBrushes.Black;
      double rc1_483 = (double) SAPInput.RC1;
      xunit12 = PDFFunctions.pages[SAPInput.k].Width;
      double point497 = ((XUnit) ref xunit12).Point;
      xunit12 = PDFFunctions.pages[SAPInput.k].Height;
      double num573 = ((XUnit) ref xunit12).Point / 2.0;
      XRect xrect497 = new XRect(20.0, rc1_483, point497, num573);
      XStringFormat topLeft497 = XStringFormat.TopLeft;
      xgraphics497.DrawString("Water heating:", xfont497, (XBrush) black484, xrect497, topLeft497);
      // ISSUE: reference to a compiler-generated field
      if (SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Water.SystemRef < 940)
      {
        XGraphics xgraphics498 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string system = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Water.System;
        XFont xfont498 = xfont3;
        XSolidBrush black485 = XBrushes.Black;
        double rc1_484 = (double) SAPInput.RC1;
        xunit12 = PDFFunctions.pages[SAPInput.k].Width;
        double point498 = ((XUnit) ref xunit12).Point;
        xunit12 = PDFFunctions.pages[SAPInput.k].Height;
        double num574 = ((XUnit) ref xunit12).Point / 2.0;
        XRect xrect498 = new XRect(200.0, rc1_484, point498, num574);
        XStringFormat topLeft498 = XStringFormat.TopLeft;
        xgraphics498.DrawString(system, xfont498, (XBrush) black485, xrect498, topLeft498);
        checked { SAPInput.RC1 += 12; }
        SAPInput.CheckRC1();
        XGraphics xgraphics499 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string str256 = "Water code: " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Water.SystemRef);
        XFont xfont499 = xfont3;
        XSolidBrush black486 = XBrushes.Black;
        double rc1_485 = (double) SAPInput.RC1;
        xunit12 = PDFFunctions.pages[SAPInput.k].Width;
        double point499 = ((XUnit) ref xunit12).Point;
        xunit12 = PDFFunctions.pages[SAPInput.k].Height;
        double num575 = ((XUnit) ref xunit12).Point / 2.0;
        XRect xrect499 = new XRect(200.0, rc1_485, point499, num575);
        XStringFormat topLeft499 = XStringFormat.TopLeft;
        xgraphics499.DrawString(str256, xfont499, (XBrush) black486, xrect499, topLeft499);
        checked { SAPInput.RC1 += 12; }
        SAPInput.CheckRC1();
        XGraphics xgraphics500 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string str257 = "Fuel :" + SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Water.Fuel;
        XFont xfont500 = xfont3;
        XSolidBrush black487 = XBrushes.Black;
        double rc1_486 = (double) SAPInput.RC1;
        xunit12 = PDFFunctions.pages[SAPInput.k].Width;
        double point500 = ((XUnit) ref xunit12).Point;
        xunit12 = PDFFunctions.pages[SAPInput.k].Height;
        double num576 = ((XUnit) ref xunit12).Point / 2.0;
        XRect xrect500 = new XRect(200.0, rc1_486, point500, num576);
        XStringFormat topLeft500 = XStringFormat.TopLeft;
        xgraphics500.DrawString(str257, xfont500, (XBrush) black487, xrect500, topLeft500);
        checked { SAPInput.RC1 += 12; }
      }
      else
      {
        XGraphics xgraphics501 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string str258 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Water.SystemRef) + " From DHW-only community scheme";
        XFont xfont501 = xfont3;
        XSolidBrush black488 = XBrushes.Black;
        double rc1_487 = (double) SAPInput.RC1;
        xunit12 = PDFFunctions.pages[SAPInput.k].Width;
        double point501 = ((XUnit) ref xunit12).Point;
        xunit12 = PDFFunctions.pages[SAPInput.k].Height;
        double num577 = ((XUnit) ref xunit12).Point / 2.0;
        XRect xrect501 = new XRect(200.0, rc1_487, point501, num577);
        XStringFormat topLeft501 = XStringFormat.TopLeft;
        xgraphics501.DrawString(str258, xfont501, (XBrush) black488, xrect501, topLeft501);
        checked { SAPInput.RC1 += 12; }
        SAPInput.CheckRC1();
        XGraphics xgraphics502 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string str259 = "Heat source: " + SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Water.System;
        XFont xfont502 = xfont3;
        XSolidBrush black489 = XBrushes.Black;
        double rc1_488 = (double) SAPInput.RC1;
        xunit12 = PDFFunctions.pages[SAPInput.k].Width;
        double point502 = ((XUnit) ref xunit12).Point;
        xunit12 = PDFFunctions.pages[SAPInput.k].Height;
        double num578 = ((XUnit) ref xunit12).Point / 2.0;
        XRect xrect502 = new XRect(200.0, rc1_488, point502, num578);
        XStringFormat topLeft502 = XStringFormat.TopLeft;
        xgraphics502.DrawString(str259, xfont502, (XBrush) black489, xrect502, topLeft502);
        checked { SAPInput.RC1 += 12; }
        SAPInput.CheckRC1();
        XGraphics xgraphics503 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        string str260 = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Water.Fuel + ", heat fraction " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Water.HWSComm.Boiler1Fraction) + ", efficiency " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Water.HWSComm.Efficiency);
        XFont xfont503 = xfont3;
        XSolidBrush black490 = XBrushes.Black;
        double rc1_489 = (double) SAPInput.RC1;
        xunit12 = PDFFunctions.pages[SAPInput.k].Width;
        double point503 = ((XUnit) ref xunit12).Point;
        xunit12 = PDFFunctions.pages[SAPInput.k].Height;
        double num579 = ((XUnit) ref xunit12).Point / 2.0;
        XRect xrect503 = new XRect(205.0, rc1_489, point503, num579);
        XStringFormat topLeft503 = XStringFormat.TopLeft;
        xgraphics503.DrawString(str260, xfont503, (XBrush) black490, xrect503, topLeft503);
        // ISSUE: reference to a compiler-generated field
        if (SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Water.HWSComm.NoOfAdditionalHeatSources > 0)
        {
          // ISSUE: reference to a compiler-generated method
          PCDF.Table4aWater table4aWater = SAP_Module.PCDFData.Table4aWaters.Where<PCDF.Table4aWater>(new Func<PCDF.Table4aWater, bool>(closure160_2._Lambda\u0024__24)).SingleOrDefault<PCDF.Table4aWater>();
          checked { SAPInput.RC1 += 12; }
          SAPInput.CheckRC1();
          XGraphics xgraphics504 = PDFFunctions.gfx[SAPInput.k];
          string str261 = "Heat source: " + table4aWater.Description;
          XFont xfont504 = xfont3;
          XSolidBrush black491 = XBrushes.Black;
          double rc1_490 = (double) SAPInput.RC1;
          xunit12 = PDFFunctions.pages[SAPInput.k].Width;
          double point504 = ((XUnit) ref xunit12).Point;
          xunit12 = PDFFunctions.pages[SAPInput.k].Height;
          double num580 = ((XUnit) ref xunit12).Point / 2.0;
          XRect xrect504 = new XRect(200.0, rc1_490, point504, num580);
          XStringFormat topLeft504 = XStringFormat.TopLeft;
          xgraphics504.DrawString(str261, xfont504, (XBrush) black491, xrect504, topLeft504);
          checked { SAPInput.RC1 += 12; }
          SAPInput.CheckRC1();
          XGraphics xgraphics505 = PDFFunctions.gfx[SAPInput.k];
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          string str262 = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Water.HWSComm.HeatSource1.Fuel + ", heat fraction " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Water.HWSComm.HeatSource1.HeatFraction) + ", efficiency " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Water.HWSComm.HeatSource1.Efficiency);
          XFont xfont505 = xfont3;
          XSolidBrush black492 = XBrushes.Black;
          double rc1_491 = (double) SAPInput.RC1;
          xunit12 = PDFFunctions.pages[SAPInput.k].Width;
          double point505 = ((XUnit) ref xunit12).Point;
          xunit12 = PDFFunctions.pages[SAPInput.k].Height;
          double num581 = ((XUnit) ref xunit12).Point / 2.0;
          XRect xrect505 = new XRect(205.0, rc1_491, point505, num581);
          XStringFormat topLeft505 = XStringFormat.TopLeft;
          xgraphics505.DrawString(str262, xfont505, (XBrush) black492, xrect505, topLeft505);
        }
        // ISSUE: reference to a compiler-generated field
        if (SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Water.HWSComm.NoOfAdditionalHeatSources > 1)
        {
          // ISSUE: reference to a compiler-generated method
          PCDF.Table4aWater table4aWater = SAP_Module.PCDFData.Table4aWaters.Where<PCDF.Table4aWater>(new Func<PCDF.Table4aWater, bool>(closure160_2._Lambda\u0024__25)).SingleOrDefault<PCDF.Table4aWater>();
          checked { SAPInput.RC1 += 12; }
          SAPInput.CheckRC1();
          XGraphics xgraphics506 = PDFFunctions.gfx[SAPInput.k];
          string str263 = "Heat source: " + table4aWater.Description;
          XFont xfont506 = xfont3;
          XSolidBrush black493 = XBrushes.Black;
          double rc1_492 = (double) SAPInput.RC1;
          xunit12 = PDFFunctions.pages[SAPInput.k].Width;
          double point506 = ((XUnit) ref xunit12).Point;
          xunit12 = PDFFunctions.pages[SAPInput.k].Height;
          double num582 = ((XUnit) ref xunit12).Point / 2.0;
          XRect xrect506 = new XRect(200.0, rc1_492, point506, num582);
          XStringFormat topLeft506 = XStringFormat.TopLeft;
          xgraphics506.DrawString(str263, xfont506, (XBrush) black493, xrect506, topLeft506);
          checked { SAPInput.RC1 += 12; }
          SAPInput.CheckRC1();
          XGraphics xgraphics507 = PDFFunctions.gfx[SAPInput.k];
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          string str264 = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Water.HWSComm.HeatSource2.Fuel + ", heat fraction " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Water.HWSComm.HeatSource2.HeatFraction) + ", efficiency " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Water.HWSComm.HeatSource2.Efficiency);
          XFont xfont507 = xfont3;
          XSolidBrush black494 = XBrushes.Black;
          double rc1_493 = (double) SAPInput.RC1;
          xunit12 = PDFFunctions.pages[SAPInput.k].Width;
          double point507 = ((XUnit) ref xunit12).Point;
          xunit12 = PDFFunctions.pages[SAPInput.k].Height;
          double num583 = ((XUnit) ref xunit12).Point / 2.0;
          XRect xrect507 = new XRect(205.0, rc1_493, point507, num583);
          XStringFormat topLeft507 = XStringFormat.TopLeft;
          xgraphics507.DrawString(str264, xfont507, (XBrush) black494, xrect507, topLeft507);
        }
        // ISSUE: reference to a compiler-generated field
        if (SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Water.HWSComm.NoOfAdditionalHeatSources > 2)
        {
          // ISSUE: reference to a compiler-generated method
          PCDF.Table4aWater table4aWater = SAP_Module.PCDFData.Table4aWaters.Where<PCDF.Table4aWater>(new Func<PCDF.Table4aWater, bool>(closure160_2._Lambda\u0024__26)).SingleOrDefault<PCDF.Table4aWater>();
          checked { SAPInput.RC1 += 12; }
          SAPInput.CheckRC1();
          XGraphics xgraphics508 = PDFFunctions.gfx[SAPInput.k];
          string str265 = "Heat source: " + table4aWater.Description;
          XFont xfont508 = xfont3;
          XSolidBrush black495 = XBrushes.Black;
          double rc1_494 = (double) SAPInput.RC1;
          xunit12 = PDFFunctions.pages[SAPInput.k].Width;
          double point508 = ((XUnit) ref xunit12).Point;
          xunit12 = PDFFunctions.pages[SAPInput.k].Height;
          double num584 = ((XUnit) ref xunit12).Point / 2.0;
          XRect xrect508 = new XRect(200.0, rc1_494, point508, num584);
          XStringFormat topLeft508 = XStringFormat.TopLeft;
          xgraphics508.DrawString(str265, xfont508, (XBrush) black495, xrect508, topLeft508);
          checked { SAPInput.RC1 += 12; }
          SAPInput.CheckRC1();
          XGraphics xgraphics509 = PDFFunctions.gfx[SAPInput.k];
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          string str266 = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Water.HWSComm.HeatSource3.Fuel + ", heat fraction " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Water.HWSComm.HeatSource3.HeatFraction) + ", efficiency " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Water.HWSComm.HeatSource3.Efficiency);
          XFont xfont509 = xfont3;
          XSolidBrush black496 = XBrushes.Black;
          double rc1_495 = (double) SAPInput.RC1;
          xunit12 = PDFFunctions.pages[SAPInput.k].Width;
          double point509 = ((XUnit) ref xunit12).Point;
          xunit12 = PDFFunctions.pages[SAPInput.k].Height;
          double num585 = ((XUnit) ref xunit12).Point / 2.0;
          XRect xrect509 = new XRect(205.0, rc1_495, point509, num585);
          XStringFormat topLeft509 = XStringFormat.TopLeft;
          xgraphics509.DrawString(str266, xfont509, (XBrush) black496, xrect509, topLeft509);
        }
        // ISSUE: reference to a compiler-generated field
        if (SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Water.HWSComm.NoOfAdditionalHeatSources > 3)
        {
          // ISSUE: reference to a compiler-generated method
          PCDF.Table4aWater table4aWater = SAP_Module.PCDFData.Table4aWaters.Where<PCDF.Table4aWater>(new Func<PCDF.Table4aWater, bool>(closure160_2._Lambda\u0024__27)).SingleOrDefault<PCDF.Table4aWater>();
          checked { SAPInput.RC1 += 12; }
          SAPInput.CheckRC1();
          XGraphics xgraphics510 = PDFFunctions.gfx[SAPInput.k];
          string str267 = "Heat source: " + table4aWater.Description;
          XFont xfont510 = xfont3;
          XSolidBrush black497 = XBrushes.Black;
          double rc1_496 = (double) SAPInput.RC1;
          xunit12 = PDFFunctions.pages[SAPInput.k].Width;
          double point510 = ((XUnit) ref xunit12).Point;
          xunit12 = PDFFunctions.pages[SAPInput.k].Height;
          double num586 = ((XUnit) ref xunit12).Point / 2.0;
          XRect xrect510 = new XRect(200.0, rc1_496, point510, num586);
          XStringFormat topLeft510 = XStringFormat.TopLeft;
          xgraphics510.DrawString(str267, xfont510, (XBrush) black497, xrect510, topLeft510);
          checked { SAPInput.RC1 += 12; }
          SAPInput.CheckRC1();
          XGraphics xgraphics511 = PDFFunctions.gfx[SAPInput.k];
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          string str268 = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Water.HWSComm.HeatSource4.Fuel + ", heat fraction " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Water.HWSComm.HeatSource4.HeatFraction) + ", efficiency " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Water.HWSComm.HeatSource4.Efficiency);
          XFont xfont511 = xfont3;
          XSolidBrush black498 = XBrushes.Black;
          double rc1_497 = (double) SAPInput.RC1;
          xunit12 = PDFFunctions.pages[SAPInput.k].Width;
          double point511 = ((XUnit) ref xunit12).Point;
          xunit12 = PDFFunctions.pages[SAPInput.k].Height;
          double num587 = ((XUnit) ref xunit12).Point / 2.0;
          XRect xrect511 = new XRect(205.0, rc1_497, point511, num587);
          XStringFormat topLeft511 = XStringFormat.TopLeft;
          xgraphics511.DrawString(str268, xfont511, (XBrush) black498, xrect511, topLeft511);
        }
        checked { SAPInput.RC1 += 12; }
        SAPInput.CheckRC1();
        XGraphics xgraphics512 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string hds = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Water.HWSComm.HDS;
        XFont xfont512 = xfont3;
        XSolidBrush black499 = XBrushes.Black;
        double rc1_498 = (double) SAPInput.RC1;
        xunit12 = PDFFunctions.pages[SAPInput.k].Width;
        double point512 = ((XUnit) ref xunit12).Point;
        xunit12 = PDFFunctions.pages[SAPInput.k].Height;
        double num588 = ((XUnit) ref xunit12).Point / 2.0;
        XRect xrect512 = new XRect(200.0, rc1_498, point512, num588);
        XStringFormat topLeft512 = XStringFormat.TopLeft;
        xgraphics512.DrawString(hds, xfont512, (XBrush) black499, xrect512, topLeft512);
        checked { SAPInput.RC1 += 12; }
        SAPInput.CheckRC1();
      }
      SAPInput.CheckRC1();
      // ISSUE: reference to a compiler-generated field
      if ((double) SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Water.Cylinder.Volume != 0.0)
      {
        XGraphics xgraphics513 = PDFFunctions.gfx[SAPInput.k];
        XFont xfont513 = xfont3;
        XSolidBrush black500 = XBrushes.Black;
        double rc1_499 = (double) SAPInput.RC1;
        xunit12 = PDFFunctions.pages[SAPInput.k].Width;
        double point513 = ((XUnit) ref xunit12).Point;
        xunit12 = PDFFunctions.pages[SAPInput.k].Height;
        double num589 = ((XUnit) ref xunit12).Point / 2.0;
        XRect xrect513 = new XRect(200.0, rc1_499, point513, num589);
        XStringFormat topLeft513 = XStringFormat.TopLeft;
        xgraphics513.DrawString("Hot water cylinder", xfont513, (XBrush) black500, xrect513, topLeft513);
        checked { SAPInput.RC1 += 12; }
        SAPInput.CheckRC1();
        XGraphics xgraphics514 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string str269 = "Cylinder volume: " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Water.Cylinder.Volume) + " litres";
        XFont xfont514 = xfont3;
        XSolidBrush black501 = XBrushes.Black;
        double rc1_500 = (double) SAPInput.RC1;
        xunit12 = PDFFunctions.pages[SAPInput.k].Width;
        double point514 = ((XUnit) ref xunit12).Point;
        xunit12 = PDFFunctions.pages[SAPInput.k].Height;
        double num590 = ((XUnit) ref xunit12).Point / 2.0;
        XRect xrect514 = new XRect(200.0, rc1_500, point514, num590);
        XStringFormat topLeft514 = XStringFormat.TopLeft;
        xgraphics514.DrawString(str269, xfont514, (XBrush) black501, xrect514, topLeft514);
        checked { SAPInput.RC1 += 12; }
        SAPInput.CheckRC1();
        // ISSUE: reference to a compiler-generated field
        if (SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Water.Cylinder.ManuSpecified)
        {
          XGraphics xgraphics515 = PDFFunctions.gfx[SAPInput.k];
          // ISSUE: reference to a compiler-generated field
          string str270 = "Cylinder insulation: Measured loss, " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Water.Cylinder.DeclaredLoss) + "kWh/day";
          XFont xfont515 = xfont3;
          XSolidBrush black502 = XBrushes.Black;
          double rc1_501 = (double) SAPInput.RC1;
          xunit12 = PDFFunctions.pages[SAPInput.k].Width;
          double point515 = ((XUnit) ref xunit12).Point;
          xunit12 = PDFFunctions.pages[SAPInput.k].Height;
          double num591 = ((XUnit) ref xunit12).Point / 2.0;
          XRect xrect515 = new XRect(200.0, rc1_501, point515, num591);
          XStringFormat topLeft515 = XStringFormat.TopLeft;
          xgraphics515.DrawString(str270, xfont515, (XBrush) black502, xrect515, topLeft515);
          checked { SAPInput.RC1 += 12; }
          SAPInput.CheckRC1();
        }
        else
        {
          XGraphics xgraphics516 = PDFFunctions.gfx[SAPInput.k];
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          string str271 = "Cylinder insulation: " + SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Water.Cylinder.Insulation + " " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Water.Cylinder.InsThick) + " mm";
          XFont xfont516 = xfont3;
          XSolidBrush black503 = XBrushes.Black;
          double rc1_502 = (double) SAPInput.RC1;
          xunit12 = PDFFunctions.pages[SAPInput.k].Width;
          double point516 = ((XUnit) ref xunit12).Point;
          xunit12 = PDFFunctions.pages[SAPInput.k].Height;
          double num592 = ((XUnit) ref xunit12).Point / 2.0;
          XRect xrect516 = new XRect(200.0, rc1_502, point516, num592);
          XStringFormat topLeft516 = XStringFormat.TopLeft;
          xgraphics516.DrawString(str271, xfont516, (XBrush) black503, xrect516, topLeft516);
          checked { SAPInput.RC1 += 12; }
          SAPInput.CheckRC1();
        }
        XGraphics xgraphics517 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string str272 = "Primary pipework insulation: " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Water.Cylinder.PipeWorkInsulated);
        XFont xfont517 = xfont3;
        XSolidBrush black504 = XBrushes.Black;
        double rc1_503 = (double) SAPInput.RC1;
        xunit12 = PDFFunctions.pages[SAPInput.k].Width;
        double point517 = ((XUnit) ref xunit12).Point;
        xunit12 = PDFFunctions.pages[SAPInput.k].Height;
        double num593 = ((XUnit) ref xunit12).Point / 2.0;
        XRect xrect517 = new XRect(200.0, rc1_503, point517, num593);
        XStringFormat topLeft517 = XStringFormat.TopLeft;
        xgraphics517.DrawString(str272, xfont517, (XBrush) black504, xrect517, topLeft517);
        checked { SAPInput.RC1 += 12; }
        SAPInput.CheckRC1();
        XGraphics xgraphics518 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string str273 = "Cylinderstat: " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Water.Cylinder.Thermostat);
        XFont xfont518 = xfont3;
        XSolidBrush black505 = XBrushes.Black;
        double rc1_504 = (double) SAPInput.RC1;
        xunit12 = PDFFunctions.pages[SAPInput.k].Width;
        double point518 = ((XUnit) ref xunit12).Point;
        xunit12 = PDFFunctions.pages[SAPInput.k].Height;
        double num594 = ((XUnit) ref xunit12).Point / 2.0;
        XRect xrect518 = new XRect(200.0, rc1_504, point518, num594);
        XStringFormat topLeft518 = XStringFormat.TopLeft;
        xgraphics518.DrawString(str273, xfont518, (XBrush) black505, xrect518, topLeft518);
        checked { SAPInput.RC1 += 12; }
        SAPInput.CheckRC1();
        XGraphics xgraphics519 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string str274 = "Cylinder in heated space: " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Water.Cylinder.InHeatedSpace);
        XFont xfont519 = xfont3;
        XSolidBrush black506 = XBrushes.Black;
        double rc1_505 = (double) SAPInput.RC1;
        xunit12 = PDFFunctions.pages[SAPInput.k].Width;
        double point519 = ((XUnit) ref xunit12).Point;
        xunit12 = PDFFunctions.pages[SAPInput.k].Height;
        double num595 = ((XUnit) ref xunit12).Point / 2.0;
        XRect xrect519 = new XRect(200.0, rc1_505, point519, num595);
        XStringFormat topLeft519 = XStringFormat.TopLeft;
        xgraphics519.DrawString(str274, xfont519, (XBrush) black506, xrect519, topLeft519);
        checked { SAPInput.RC1 += 12; }
        SAPInput.CheckRC1();
        // ISSUE: reference to a compiler-generated field
        if ((uint) Operators.CompareString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Water.Cylinder.Immersion, "", false) > 0U)
        {
          XGraphics xgraphics520 = PDFFunctions.gfx[SAPInput.k];
          string str275 = "Immersion: " + SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.Immersion;
          XFont xfont520 = xfont3;
          XSolidBrush black507 = XBrushes.Black;
          double rc1_506 = (double) SAPInput.RC1;
          xunit12 = PDFFunctions.pages[SAPInput.k].Width;
          double point520 = ((XUnit) ref xunit12).Point;
          xunit12 = PDFFunctions.pages[SAPInput.k].Height;
          double num596 = ((XUnit) ref xunit12).Point / 2.0;
          XRect xrect520 = new XRect(200.0, rc1_506, point520, num596);
          XStringFormat topLeft520 = XStringFormat.TopLeft;
          xgraphics520.DrawString(str275, xfont520, (XBrush) black507, xrect520, topLeft520);
          checked { SAPInput.RC1 += 12; }
          SAPInput.CheckRC1();
        }
      }
      else
      {
        XGraphics xgraphics521 = PDFFunctions.gfx[SAPInput.k];
        XFont xfont521 = xfont3;
        XSolidBrush black508 = XBrushes.Black;
        double rc1_507 = (double) SAPInput.RC1;
        xunit12 = PDFFunctions.pages[SAPInput.k].Width;
        double point521 = ((XUnit) ref xunit12).Point;
        xunit12 = PDFFunctions.pages[SAPInput.k].Height;
        double num597 = ((XUnit) ref xunit12).Point / 2.0;
        XRect xrect521 = new XRect(200.0, rc1_507, point521, num597);
        XStringFormat topLeft521 = XStringFormat.TopLeft;
        xgraphics521.DrawString("No hot water cylinder", xfont521, (XBrush) black508, xrect521, topLeft521);
        checked { SAPInput.RC1 += 12; }
        SAPInput.CheckRC1();
      }
      // ISSUE: reference to a compiler-generated field
      if (SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Water.FGHRS.Include)
      {
        XGraphics xgraphics522 = PDFFunctions.gfx[SAPInput.k];
        XFont xfont522 = xfont3;
        XSolidBrush black509 = XBrushes.Black;
        double rc1_508 = (double) SAPInput.RC1;
        xunit12 = PDFFunctions.pages[SAPInput.k].Width;
        double point522 = ((XUnit) ref xunit12).Point;
        xunit12 = PDFFunctions.pages[SAPInput.k].Height;
        double num598 = ((XUnit) ref xunit12).Point / 2.0;
        XRect xrect522 = new XRect(200.0, rc1_508, point522, num598);
        XStringFormat topLeft522 = XStringFormat.TopLeft;
        xgraphics522.DrawString("Flue Gas Heat Recovery System:", xfont522, (XBrush) black509, xrect522, topLeft522);
        checked { SAPInput.RC1 += 12; }
        SAPInput.CheckRC1();
        try
        {
          // ISSUE: reference to a compiler-generated method
          PCDF.FGHRS fghrs = SAP_Module.PCDFData.FGHRSs.Where<PCDF.FGHRS>(new Func<PCDF.FGHRS, bool>(closure160_2._Lambda\u0024__28)).SingleOrDefault<PCDF.FGHRS>();
          XGraphics xgraphics523 = PDFFunctions.gfx[SAPInput.k];
          // ISSUE: reference to a compiler-generated field
          string str276 = "Database (rev " + Conversions.ToString(SAP_Module.DataBVersion) + ", product index " + SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Water.FGHRS.IndexNo + ")";
          XFont xfont523 = xfont3;
          XSolidBrush black510 = XBrushes.Black;
          double rc1_509 = (double) SAPInput.RC1;
          xunit12 = PDFFunctions.pages[SAPInput.k].Width;
          double point523 = ((XUnit) ref xunit12).Point;
          xunit12 = PDFFunctions.pages[SAPInput.k].Height;
          double num599 = ((XUnit) ref xunit12).Point / 2.0;
          XRect xrect523 = new XRect(205.0, rc1_509, point523, num599);
          XStringFormat topLeft523 = XStringFormat.TopLeft;
          xgraphics523.DrawString(str276, xfont523, (XBrush) black510, xrect523, topLeft523);
          checked { SAPInput.RC1 += 12; }
          SAPInput.CheckRC1();
          XGraphics xgraphics524 = PDFFunctions.gfx[SAPInput.k];
          string str277 = "Brand name: " + fghrs.Brand;
          XFont xfont524 = xfont3;
          XSolidBrush black511 = XBrushes.Black;
          double rc1_510 = (double) SAPInput.RC1;
          xunit12 = PDFFunctions.pages[SAPInput.k].Width;
          double point524 = ((XUnit) ref xunit12).Point;
          xunit12 = PDFFunctions.pages[SAPInput.k].Height;
          double num600 = ((XUnit) ref xunit12).Point / 2.0;
          XRect xrect524 = new XRect(205.0, rc1_510, point524, num600);
          XStringFormat topLeft524 = XStringFormat.TopLeft;
          xgraphics524.DrawString(str277, xfont524, (XBrush) black511, xrect524, topLeft524);
          checked { SAPInput.RC1 += 12; }
          SAPInput.CheckRC1();
          XGraphics xgraphics525 = PDFFunctions.gfx[SAPInput.k];
          string str278 = "Model: " + fghrs.Model;
          XFont xfont525 = xfont3;
          XSolidBrush black512 = XBrushes.Black;
          double rc1_511 = (double) SAPInput.RC1;
          xunit12 = PDFFunctions.pages[SAPInput.k].Width;
          double point525 = ((XUnit) ref xunit12).Point;
          xunit12 = PDFFunctions.pages[SAPInput.k].Height;
          double num601 = ((XUnit) ref xunit12).Point / 2.0;
          XRect xrect525 = new XRect(205.0, rc1_511, point525, num601);
          XStringFormat topLeft525 = XStringFormat.TopLeft;
          xgraphics525.DrawString(str278, xfont525, (XBrush) black512, xrect525, topLeft525);
          checked { SAPInput.RC1 += 12; }
          SAPInput.CheckRC1();
          XGraphics xgraphics526 = PDFFunctions.gfx[SAPInput.k];
          string str279 = "Model qualifier: " + fghrs.Model_Qualifier;
          XFont xfont526 = xfont3;
          XSolidBrush black513 = XBrushes.Black;
          double rc1_512 = (double) SAPInput.RC1;
          xunit12 = PDFFunctions.pages[SAPInput.k].Width;
          double point526 = ((XUnit) ref xunit12).Point;
          xunit12 = PDFFunctions.pages[SAPInput.k].Height;
          double num602 = ((XUnit) ref xunit12).Point / 2.0;
          XRect xrect526 = new XRect(205.0, rc1_512, point526, num602);
          XStringFormat topLeft526 = XStringFormat.TopLeft;
          xgraphics526.DrawString(str279, xfont526, (XBrush) black513, xrect526, topLeft526);
          checked { SAPInput.RC1 += 12; }
          checked { ++SAPInput.RC1; }
        }
        catch (Exception ex)
        {
          int lErl = num30;
          ProjectData.SetProjectError(ex, lErl);
          ProjectData.ClearProjectError();
        }
        num30 = 2;
        SAPInput.CheckRC1();
      }
      // ISSUE: reference to a compiler-generated field
      if (SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Water.WWHRS.Include)
      {
        XGraphics xgraphics527 = PDFFunctions.gfx[SAPInput.k];
        XFont xfont527 = xfont3;
        XSolidBrush black514 = XBrushes.Black;
        double rc1_513 = (double) SAPInput.RC1;
        xunit12 = PDFFunctions.pages[SAPInput.k].Width;
        double point527 = ((XUnit) ref xunit12).Point;
        xunit12 = PDFFunctions.pages[SAPInput.k].Height;
        double num603 = ((XUnit) ref xunit12).Point / 2.0;
        XRect xrect527 = new XRect(200.0, rc1_513, point527, num603);
        XStringFormat topLeft527 = XStringFormat.TopLeft;
        xgraphics527.DrawString("Waste Water Heat Recovery System:", xfont527, (XBrush) black514, xrect527, topLeft527);
        checked { SAPInput.RC1 += 12; }
        SAPInput.CheckRC1();
        XGraphics xgraphics528 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string str280 = "Total rooms with shower and/or bath: " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Water.WWHRS.TotalRooms);
        XFont xfont528 = xfont3;
        XSolidBrush black515 = XBrushes.Black;
        double rc1_514 = (double) SAPInput.RC1;
        xunit12 = PDFFunctions.pages[SAPInput.k].Width;
        double point528 = ((XUnit) ref xunit12).Point;
        xunit12 = PDFFunctions.pages[SAPInput.k].Height;
        double num604 = ((XUnit) ref xunit12).Point / 2.0;
        XRect xrect528 = new XRect(205.0, rc1_514, point528, num604);
        XStringFormat topLeft528 = XStringFormat.TopLeft;
        xgraphics528.DrawString(str280, xfont528, (XBrush) black515, xrect528, topLeft528);
        checked { SAPInput.RC1 += 12; }
        SAPInput.CheckRC1();
        // ISSUE: reference to a compiler-generated method
        PCDF.WWHRS wwhrs1 = SAP_Module.PCDFData.WWHRSs.Where<PCDF.WWHRS>(new Func<PCDF.WWHRS, bool>(closure160_2._Lambda\u0024__29)).SingleOrDefault<PCDF.WWHRS>();
        XGraphics xgraphics529 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string str281 = "Product index: " + SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Water.WWHRS.Systems[0].SystemsRef + ", " + wwhrs1.Brand + " " + wwhrs1.Model + " " + wwhrs1.Model_Qualifier;
        XFont xfont529 = xfont3;
        XSolidBrush black516 = XBrushes.Black;
        double rc1_515 = (double) SAPInput.RC1;
        xunit12 = PDFFunctions.pages[SAPInput.k].Width;
        double point529 = ((XUnit) ref xunit12).Point;
        xunit12 = PDFFunctions.pages[SAPInput.k].Height;
        double num605 = ((XUnit) ref xunit12).Point / 2.0;
        XRect xrect529 = new XRect(205.0, rc1_515, point529, num605);
        XStringFormat topLeft529 = XStringFormat.TopLeft;
        xgraphics529.DrawString(str281, xfont529, (XBrush) black516, xrect529, topLeft529);
        checked { SAPInput.RC1 += 12; }
        SAPInput.CheckRC1();
        XGraphics xgraphics530 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string str282 = "Number of mixer showers in rooms with a bath: " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Water.WWHRS.Systems[0].WithBath);
        XFont xfont530 = xfont3;
        XSolidBrush black517 = XBrushes.Black;
        double rc1_516 = (double) SAPInput.RC1;
        xunit12 = PDFFunctions.pages[SAPInput.k].Width;
        double point530 = ((XUnit) ref xunit12).Point;
        xunit12 = PDFFunctions.pages[SAPInput.k].Height;
        double num606 = ((XUnit) ref xunit12).Point / 2.0;
        XRect xrect530 = new XRect(210.0, rc1_516, point530, num606);
        XStringFormat topLeft530 = XStringFormat.TopLeft;
        xgraphics530.DrawString(str282, xfont530, (XBrush) black517, xrect530, topLeft530);
        checked { SAPInput.RC1 += 12; }
        SAPInput.CheckRC1();
        XGraphics xgraphics531 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string str283 = "Number of mixer showers in rooms without a bath: " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Water.WWHRS.Systems[0].WithNoBath);
        XFont xfont531 = xfont3;
        XSolidBrush black518 = XBrushes.Black;
        double rc1_517 = (double) SAPInput.RC1;
        xunit12 = PDFFunctions.pages[SAPInput.k].Width;
        double point531 = ((XUnit) ref xunit12).Point;
        xunit12 = PDFFunctions.pages[SAPInput.k].Height;
        double num607 = ((XUnit) ref xunit12).Point / 2.0;
        XRect xrect531 = new XRect(210.0, rc1_517, point531, num607);
        XStringFormat topLeft531 = XStringFormat.TopLeft;
        xgraphics531.DrawString(str283, xfont531, (XBrush) black518, xrect531, topLeft531);
        checked { SAPInput.RC1 += 12; }
        SAPInput.CheckRC1();
        // ISSUE: reference to a compiler-generated field
        if ((uint) Operators.CompareString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Water.WWHRS.Systems[1].SystemsRef, "", false) > 0U)
        {
          // ISSUE: reference to a compiler-generated method
          PCDF.WWHRS wwhrs2 = SAP_Module.PCDFData.WWHRSs.Where<PCDF.WWHRS>(new Func<PCDF.WWHRS, bool>(closure160_2._Lambda\u0024__30)).SingleOrDefault<PCDF.WWHRS>();
          XGraphics xgraphics532 = PDFFunctions.gfx[SAPInput.k];
          // ISSUE: reference to a compiler-generated field
          string str284 = "Product index: " + SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Water.WWHRS.Systems[1].SystemsRef + ", " + wwhrs2.Brand + " " + wwhrs2.Model + " " + wwhrs2.Model_Qualifier;
          XFont xfont532 = xfont3;
          XSolidBrush black519 = XBrushes.Black;
          double rc1_518 = (double) SAPInput.RC1;
          xunit12 = PDFFunctions.pages[SAPInput.k].Width;
          double point532 = ((XUnit) ref xunit12).Point;
          xunit12 = PDFFunctions.pages[SAPInput.k].Height;
          double num608 = ((XUnit) ref xunit12).Point / 2.0;
          XRect xrect532 = new XRect(205.0, rc1_518, point532, num608);
          XStringFormat topLeft532 = XStringFormat.TopLeft;
          xgraphics532.DrawString(str284, xfont532, (XBrush) black519, xrect532, topLeft532);
          checked { SAPInput.RC1 += 12; }
          SAPInput.CheckRC1();
          XGraphics xgraphics533 = PDFFunctions.gfx[SAPInput.k];
          // ISSUE: reference to a compiler-generated field
          string str285 = "Number of mixer showers in rooms with a bath: " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Water.WWHRS.Systems[1].WithBath);
          XFont xfont533 = xfont3;
          XSolidBrush black520 = XBrushes.Black;
          double rc1_519 = (double) SAPInput.RC1;
          xunit12 = PDFFunctions.pages[SAPInput.k].Width;
          double point533 = ((XUnit) ref xunit12).Point;
          xunit12 = PDFFunctions.pages[SAPInput.k].Height;
          double num609 = ((XUnit) ref xunit12).Point / 2.0;
          XRect xrect533 = new XRect(210.0, rc1_519, point533, num609);
          XStringFormat topLeft533 = XStringFormat.TopLeft;
          xgraphics533.DrawString(str285, xfont533, (XBrush) black520, xrect533, topLeft533);
          checked { SAPInput.RC1 += 12; }
          SAPInput.CheckRC1();
          XGraphics xgraphics534 = PDFFunctions.gfx[SAPInput.k];
          // ISSUE: reference to a compiler-generated field
          string str286 = "Number of mixer showers in rooms without a bath: " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Water.WWHRS.Systems[1].WithNoBath);
          XFont xfont534 = xfont3;
          XSolidBrush black521 = XBrushes.Black;
          double rc1_520 = (double) SAPInput.RC1;
          xunit12 = PDFFunctions.pages[SAPInput.k].Width;
          double point534 = ((XUnit) ref xunit12).Point;
          xunit12 = PDFFunctions.pages[SAPInput.k].Height;
          double num610 = ((XUnit) ref xunit12).Point / 2.0;
          XRect xrect534 = new XRect(210.0, rc1_520, point534, num610);
          XStringFormat topLeft534 = XStringFormat.TopLeft;
          xgraphics534.DrawString(str286, xfont534, (XBrush) black521, xrect534, topLeft534);
          checked { SAPInput.RC1 += 12; }
          SAPInput.CheckRC1();
        }
      }
      XGraphics xgraphics535 = PDFFunctions.gfx[SAPInput.k];
      // ISSUE: reference to a compiler-generated field
      string str287 = "Solar panel: " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Water.Solar.Inlcude);
      XFont xfont535 = xfont3;
      XSolidBrush black522 = XBrushes.Black;
      double rc1_521 = (double) SAPInput.RC1;
      xunit12 = PDFFunctions.pages[SAPInput.k].Width;
      double point535 = ((XUnit) ref xunit12).Point;
      xunit12 = PDFFunctions.pages[SAPInput.k].Height;
      double num611 = ((XUnit) ref xunit12).Point / 2.0;
      XRect xrect535 = new XRect(200.0, rc1_521, point535, num611);
      XStringFormat topLeft535 = XStringFormat.TopLeft;
      xgraphics535.DrawString(str287, xfont535, (XBrush) black522, xrect535, topLeft535);
      // ISSUE: reference to a compiler-generated field
      if (SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Water.Solar.Inlcude)
      {
        checked { SAPInput.RC1 += 12; }
        SAPInput.CheckRC1();
        XGraphics xgraphics536 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string str288 = "aperture area: " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Water.Solar.SolarArea);
        XFont xfont536 = xfont3;
        XSolidBrush black523 = XBrushes.Black;
        double rc1_522 = (double) SAPInput.RC1;
        xunit12 = PDFFunctions.pages[SAPInput.k].Width;
        double point536 = ((XUnit) ref xunit12).Point;
        xunit12 = PDFFunctions.pages[SAPInput.k].Height;
        double num612 = ((XUnit) ref xunit12).Point / 2.0;
        XRect xrect536 = new XRect(205.0, rc1_522, point536, num612);
        XStringFormat topLeft536 = XStringFormat.TopLeft;
        xgraphics536.DrawString(str288, xfont536, (XBrush) black523, xrect536, topLeft536);
        checked { SAPInput.RC1 += 12; }
        SAPInput.CheckRC1();
        XGraphics xgraphics537 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string solarType = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Water.Solar.SolarType;
        XFont xfont537 = xfont3;
        XSolidBrush black524 = XBrushes.Black;
        double rc1_523 = (double) SAPInput.RC1;
        xunit12 = PDFFunctions.pages[SAPInput.k].Width;
        double point537 = ((XUnit) ref xunit12).Point;
        xunit12 = PDFFunctions.pages[SAPInput.k].Height;
        double num613 = ((XUnit) ref xunit12).Point / 2.0;
        XRect xrect537 = new XRect(205.0, rc1_523, point537, num613);
        XStringFormat topLeft537 = XStringFormat.TopLeft;
        xgraphics537.DrawString(solarType, xfont537, (XBrush) black524, xrect537, topLeft537);
        checked { SAPInput.RC1 += 12; }
        SAPInput.CheckRC1();
        XGraphics xgraphics538 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string str289 = "default values: " + Conversions.ToString(!SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Water.Solar.Overide);
        XFont xfont538 = xfont3;
        XSolidBrush black525 = XBrushes.Black;
        double rc1_524 = (double) SAPInput.RC1;
        xunit12 = PDFFunctions.pages[SAPInput.k].Width;
        double point538 = ((XUnit) ref xunit12).Point;
        xunit12 = PDFFunctions.pages[SAPInput.k].Height;
        double num614 = ((XUnit) ref xunit12).Point / 2.0;
        XRect xrect538 = new XRect(205.0, rc1_524, point538, num614);
        XStringFormat topLeft538 = XStringFormat.TopLeft;
        xgraphics538.DrawString(str289, xfont538, (XBrush) black525, xrect538, topLeft538);
        checked { SAPInput.RC1 += 12; }
        SAPInput.CheckRC1();
        XGraphics xgraphics539 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string str290 = "collector zero-loss efficiency: " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Water.Solar.SolarZero);
        XFont xfont539 = xfont3;
        XSolidBrush black526 = XBrushes.Black;
        double rc1_525 = (double) SAPInput.RC1;
        xunit12 = PDFFunctions.pages[SAPInput.k].Width;
        double point539 = ((XUnit) ref xunit12).Point;
        xunit12 = PDFFunctions.pages[SAPInput.k].Height;
        double num615 = ((XUnit) ref xunit12).Point / 2.0;
        XRect xrect539 = new XRect(205.0, rc1_525, point539, num615);
        XStringFormat topLeft539 = XStringFormat.TopLeft;
        xgraphics539.DrawString(str290, xfont539, (XBrush) black526, xrect539, topLeft539);
        checked { SAPInput.RC1 += 12; }
        SAPInput.CheckRC1();
        XGraphics xgraphics540 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string str291 = "collector heat loss coefficient: " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Water.Solar.SolarHLoss);
        XFont xfont540 = xfont3;
        XSolidBrush black527 = XBrushes.Black;
        double rc1_526 = (double) SAPInput.RC1;
        xunit12 = PDFFunctions.pages[SAPInput.k].Width;
        double point540 = ((XUnit) ref xunit12).Point;
        xunit12 = PDFFunctions.pages[SAPInput.k].Height;
        double num616 = ((XUnit) ref xunit12).Point / 2.0;
        XRect xrect540 = new XRect(205.0, rc1_526, point540, num616);
        XStringFormat topLeft540 = XStringFormat.TopLeft;
        xgraphics540.DrawString(str291, xfont540, (XBrush) black527, xrect540, topLeft540);
        checked { SAPInput.RC1 += 12; }
        SAPInput.CheckRC1();
        XGraphics xgraphics541 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        string str292 = "orientation: " + SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Water.Solar.SolarOrientation + ", " + SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Water.Solar.SolarTilt + " pitch";
        XFont xfont541 = xfont3;
        XSolidBrush black528 = XBrushes.Black;
        double rc1_527 = (double) SAPInput.RC1;
        xunit12 = PDFFunctions.pages[SAPInput.k].Width;
        double point541 = ((XUnit) ref xunit12).Point;
        xunit12 = PDFFunctions.pages[SAPInput.k].Height;
        double num617 = ((XUnit) ref xunit12).Point / 2.0;
        XRect xrect541 = new XRect(205.0, rc1_527, point541, num617);
        XStringFormat topLeft541 = XStringFormat.TopLeft;
        xgraphics541.DrawString(str292, xfont541, (XBrush) black528, xrect541, topLeft541);
        checked { SAPInput.RC1 += 12; }
        SAPInput.CheckRC1();
        XGraphics xgraphics542 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string str293 = "overshading: " + SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Water.Solar.SolarOvershading;
        XFont xfont542 = xfont3;
        XSolidBrush black529 = XBrushes.Black;
        double rc1_528 = (double) SAPInput.RC1;
        xunit12 = PDFFunctions.pages[SAPInput.k].Width;
        double point542 = ((XUnit) ref xunit12).Point;
        xunit12 = PDFFunctions.pages[SAPInput.k].Height;
        double num618 = ((XUnit) ref xunit12).Point / 2.0;
        XRect xrect542 = new XRect(205.0, rc1_528, point542, num618);
        XStringFormat topLeft542 = XStringFormat.TopLeft;
        xgraphics542.DrawString(str293, xfont542, (XBrush) black529, xrect542, topLeft542);
        checked { SAPInput.RC1 += 12; }
        SAPInput.CheckRC1();
        // ISSUE: reference to a compiler-generated field
        if (!SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Water.Solar.SolarSeperate)
        {
          XGraphics xgraphics543 = PDFFunctions.gfx[SAPInput.k];
          // ISSUE: reference to a compiler-generated field
          string str294 = "dedicated solar store volume: " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Water.Solar.SolarVolume) + " litres (combined store)";
          XFont xfont543 = xfont3;
          XSolidBrush black530 = XBrushes.Black;
          double rc1_529 = (double) SAPInput.RC1;
          xunit12 = PDFFunctions.pages[SAPInput.k].Width;
          double point543 = ((XUnit) ref xunit12).Point;
          xunit12 = PDFFunctions.pages[SAPInput.k].Height;
          double num619 = ((XUnit) ref xunit12).Point / 2.0;
          XRect xrect543 = new XRect(205.0, rc1_529, point543, num619);
          XStringFormat topLeft543 = XStringFormat.TopLeft;
          xgraphics543.DrawString(str294, xfont543, (XBrush) black530, xrect543, topLeft543);
        }
        else
        {
          XGraphics xgraphics544 = PDFFunctions.gfx[SAPInput.k];
          // ISSUE: reference to a compiler-generated field
          string str295 = "dedicated solar store volume: " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Water.Solar.SolarVolume) + " litres (seperate store)";
          XFont xfont544 = xfont3;
          XSolidBrush black531 = XBrushes.Black;
          double rc1_530 = (double) SAPInput.RC1;
          xunit12 = PDFFunctions.pages[SAPInput.k].Width;
          double point544 = ((XUnit) ref xunit12).Point;
          xunit12 = PDFFunctions.pages[SAPInput.k].Height;
          double num620 = ((XUnit) ref xunit12).Point / 2.0;
          XRect xrect544 = new XRect(205.0, rc1_530, point544, num620);
          XStringFormat topLeft544 = XStringFormat.TopLeft;
          xgraphics544.DrawString(str295, xfont544, (XBrush) black531, xrect544, topLeft544);
        }
        checked { SAPInput.RC1 += 12; }
        SAPInput.CheckRC1();
        XGraphics xgraphics545 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string str296 = "solar powered pump: " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Water.Solar.Pumped);
        XFont xfont545 = xfont3;
        XSolidBrush black532 = XBrushes.Black;
        double rc1_531 = (double) SAPInput.RC1;
        xunit12 = PDFFunctions.pages[SAPInput.k].Width;
        double point545 = ((XUnit) ref xunit12).Point;
        xunit12 = PDFFunctions.pages[SAPInput.k].Height;
        double num621 = ((XUnit) ref xunit12).Point / 2.0;
        XRect xrect545 = new XRect(205.0, rc1_531, point545, num621);
        XStringFormat topLeft545 = XStringFormat.TopLeft;
        xgraphics545.DrawString(str296, xfont545, (XBrush) black532, xrect545, topLeft545);
      }
      checked { SAPInput.RC1 += 12; }
      SAPInput.CheckRC1();
      PDFFunctions.xBrush1 = XBrush.op_Implicit((Brush) new SolidBrush(Color.FromArgb(159, 172, 62)));
      PDFFunctions.Points[0].X = 20f;
      PDFFunctions.Points[0].Y = (float) SAPInput.RC1;
      ref PointF local27 = ref PDFFunctions.Points[1];
      xunit12 = PDFFunctions.pages[SAPInput.k].Width;
      double num622 = ((XUnit) ref xunit12).Point - 20.0;
      local27.X = (float) num622;
      PDFFunctions.Points[1].Y = (float) SAPInput.RC1;
      ref PointF local28 = ref PDFFunctions.Points[2];
      xunit12 = PDFFunctions.pages[SAPInput.k].Width;
      double num623 = ((XUnit) ref xunit12).Point - 20.0;
      local28.X = (float) num623;
      PDFFunctions.Points[2].Y = (float) checked (SAPInput.RC1 + 14);
      PDFFunctions.Points[3].X = 20f;
      PDFFunctions.Points[3].Y = (float) checked (SAPInput.RC1 + 14);
      PDFFunctions.gfx[SAPInput.k].DrawPolygon(PDFFunctions.polyGreen2, PDFFunctions.xBrush1, PDFFunctions.Points, xfillMode);
      XGraphics xgraphics546 = PDFFunctions.gfx[SAPInput.k];
      XFont xfont546 = xfont3;
      XSolidBrush white14 = XBrushes.White;
      double num624 = (double) checked (SAPInput.RC1 + 1);
      xunit12 = PDFFunctions.pages[SAPInput.k].Width;
      double point546 = ((XUnit) ref xunit12).Point;
      xunit12 = PDFFunctions.pages[SAPInput.k].Height;
      double num625 = ((XUnit) ref xunit12).Point / 2.0;
      XRect xrect546 = new XRect(25.0, num624, point546, num625);
      XStringFormat topLeft546 = XStringFormat.TopLeft;
      xgraphics546.DrawString("Others:", xfont546, (XBrush) white14, xrect546, topLeft546);
      SAPInput.RC1 = checked ((int) Math.Round(unchecked ((double) PDFFunctions.Points[3].Y + 4.0)));
      XGraphics xgraphics547 = PDFFunctions.gfx[SAPInput.k];
      XFont xfont547 = xfont2;
      XSolidBrush black533 = XBrushes.Black;
      double rc1_532 = (double) SAPInput.RC1;
      xunit12 = PDFFunctions.pages[SAPInput.k].Width;
      double point547 = ((XUnit) ref xunit12).Point;
      xunit12 = PDFFunctions.pages[SAPInput.k].Height;
      double num626 = ((XUnit) ref xunit12).Point / 2.0;
      XRect xrect547 = new XRect(20.0, rc1_532, point547, num626);
      XStringFormat topLeft547 = XStringFormat.TopLeft;
      xgraphics547.DrawString("Electricity tariff:", xfont547, (XBrush) black533, xrect547, topLeft547);
      XGraphics xgraphics548 = PDFFunctions.gfx[SAPInput.k];
      // ISSUE: reference to a compiler-generated field
      string str297 = Microsoft.VisualBasic.Strings.StrConv(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].MainHeating.ElectricityTariff, VbStrConv.ProperCase);
      XFont xfont548 = xfont3;
      XSolidBrush black534 = XBrushes.Black;
      double rc1_533 = (double) SAPInput.RC1;
      xunit12 = PDFFunctions.pages[SAPInput.k].Width;
      double point548 = ((XUnit) ref xunit12).Point;
      xunit12 = PDFFunctions.pages[SAPInput.k].Height;
      double num627 = ((XUnit) ref xunit12).Point / 2.0;
      XRect xrect548 = new XRect(200.0, rc1_533, point548, num627);
      XStringFormat topLeft548 = XStringFormat.TopLeft;
      xgraphics548.DrawString(str297, xfont548, (XBrush) black534, xrect548, topLeft548);
      checked { SAPInput.RC1 += 12; }
      XGraphics xgraphics549 = PDFFunctions.gfx[SAPInput.k];
      XFont xfont549 = xfont2;
      XSolidBrush black535 = XBrushes.Black;
      double rc1_534 = (double) SAPInput.RC1;
      xunit12 = PDFFunctions.pages[SAPInput.k].Width;
      double point549 = ((XUnit) ref xunit12).Point;
      xunit12 = PDFFunctions.pages[SAPInput.k].Height;
      double num628 = ((XUnit) ref xunit12).Point / 2.0;
      XRect xrect549 = new XRect(20.0, rc1_534, point549, num628);
      XStringFormat topLeft549 = XStringFormat.TopLeft;
      xgraphics549.DrawString("In Smoke Control Area:", xfont549, (XBrush) black535, xrect549, topLeft549);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      string str298 = Operators.CompareString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].SmokeArea, "", false) != 0 ? SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].SmokeArea : "Unknown";
      XGraphics xgraphics550 = PDFFunctions.gfx[SAPInput.k];
      string str299 = str298;
      XFont xfont550 = xfont3;
      XSolidBrush black536 = XBrushes.Black;
      double rc1_535 = (double) SAPInput.RC1;
      xunit12 = PDFFunctions.pages[SAPInput.k].Width;
      double point550 = ((XUnit) ref xunit12).Point;
      xunit12 = PDFFunctions.pages[SAPInput.k].Height;
      double num629 = ((XUnit) ref xunit12).Point / 2.0;
      XRect xrect550 = new XRect(200.0, rc1_535, point550, num629);
      XStringFormat topLeft550 = XStringFormat.TopLeft;
      xgraphics550.DrawString(str299, xfont550, (XBrush) black536, xrect550, topLeft550);
      checked { SAPInput.RC1 += 12; }
      SAPInput.CheckRC1();
      XGraphics xgraphics551 = PDFFunctions.gfx[SAPInput.k];
      XFont xfont551 = xfont2;
      XSolidBrush black537 = XBrushes.Black;
      double rc1_536 = (double) SAPInput.RC1;
      xunit12 = PDFFunctions.pages[SAPInput.k].Width;
      double point551 = ((XUnit) ref xunit12).Point;
      xunit12 = PDFFunctions.pages[SAPInput.k].Height;
      double num630 = ((XUnit) ref xunit12).Point / 2.0;
      XRect xrect551 = new XRect(20.0, rc1_536, point551, num630);
      XStringFormat topLeft551 = XStringFormat.TopLeft;
      xgraphics551.DrawString("Conservatory:", xfont551, (XBrush) black537, xrect551, topLeft551);
      XGraphics xgraphics552 = PDFFunctions.gfx[SAPInput.k];
      // ISSUE: reference to a compiler-generated field
      string conservatory = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Conservatory;
      XFont xfont552 = xfont3;
      XSolidBrush black538 = XBrushes.Black;
      double rc1_537 = (double) SAPInput.RC1;
      xunit12 = PDFFunctions.pages[SAPInput.k].Width;
      double point552 = ((XUnit) ref xunit12).Point;
      xunit12 = PDFFunctions.pages[SAPInput.k].Height;
      double num631 = ((XUnit) ref xunit12).Point / 2.0;
      XRect xrect552 = new XRect(200.0, rc1_537, point552, num631);
      XStringFormat topLeft552 = XStringFormat.TopLeft;
      xgraphics552.DrawString(conservatory, xfont552, (XBrush) black538, xrect552, topLeft552);
      checked { SAPInput.RC1 += 12; }
      SAPInput.CheckRC1();
      XGraphics xgraphics553 = PDFFunctions.gfx[SAPInput.k];
      XFont xfont553 = xfont2;
      XSolidBrush black539 = XBrushes.Black;
      double rc1_538 = (double) SAPInput.RC1;
      xunit12 = PDFFunctions.pages[SAPInput.k].Width;
      double point553 = ((XUnit) ref xunit12).Point;
      xunit12 = PDFFunctions.pages[SAPInput.k].Height;
      double num632 = ((XUnit) ref xunit12).Point / 2.0;
      XRect xrect553 = new XRect(20.0, rc1_538, point553, num632);
      XStringFormat topLeft553 = XStringFormat.TopLeft;
      xgraphics553.DrawString("Low energy lights:", xfont553, (XBrush) black539, xrect553, topLeft553);
      XGraphics xgraphics554 = PDFFunctions.gfx[SAPInput.k];
      // ISSUE: reference to a compiler-generated field
      string str300 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].LowEnergyLight) + "%";
      XFont xfont554 = xfont3;
      XSolidBrush black540 = XBrushes.Black;
      double rc1_539 = (double) SAPInput.RC1;
      xunit12 = PDFFunctions.pages[SAPInput.k].Width;
      double point554 = ((XUnit) ref xunit12).Point;
      xunit12 = PDFFunctions.pages[SAPInput.k].Height;
      double num633 = ((XUnit) ref xunit12).Point / 2.0;
      XRect xrect554 = new XRect(200.0, rc1_539, point554, num633);
      XStringFormat topLeft554 = XStringFormat.TopLeft;
      xgraphics554.DrawString(str300, xfont554, (XBrush) black540, xrect554, topLeft554);
      checked { SAPInput.RC1 += 12; }
      SAPInput.CheckRC1();
      XGraphics xgraphics555 = PDFFunctions.gfx[SAPInput.k];
      XFont xfont555 = xfont2;
      XSolidBrush black541 = XBrushes.Black;
      double rc1_540 = (double) SAPInput.RC1;
      xunit12 = PDFFunctions.pages[SAPInput.k].Width;
      double point555 = ((XUnit) ref xunit12).Point;
      xunit12 = PDFFunctions.pages[SAPInput.k].Height;
      double num634 = ((XUnit) ref xunit12).Point / 2.0;
      XRect xrect555 = new XRect(20.0, rc1_540, point555, num634);
      XStringFormat topLeft555 = XStringFormat.TopLeft;
      xgraphics555.DrawString("Terrain type:", xfont555, (XBrush) black541, xrect555, topLeft555);
      XGraphics xgraphics556 = PDFFunctions.gfx[SAPInput.k];
      // ISSUE: reference to a compiler-generated field
      string terrain = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Terrain;
      XFont xfont556 = xfont3;
      XSolidBrush black542 = XBrushes.Black;
      double rc1_541 = (double) SAPInput.RC1;
      xunit12 = PDFFunctions.pages[SAPInput.k].Width;
      double point556 = ((XUnit) ref xunit12).Point;
      xunit12 = PDFFunctions.pages[SAPInput.k].Height;
      double num635 = ((XUnit) ref xunit12).Point / 2.0;
      XRect xrect556 = new XRect(200.0, rc1_541, point556, num635);
      XStringFormat topLeft556 = XStringFormat.TopLeft;
      xgraphics556.DrawString(terrain, xfont556, (XBrush) black542, xrect556, topLeft556);
      checked { SAPInput.RC1 += 12; }
      XGraphics xgraphics557 = PDFFunctions.gfx[SAPInput.k];
      XFont xfont557 = xfont2;
      XSolidBrush black543 = XBrushes.Black;
      double rc1_542 = (double) SAPInput.RC1;
      xunit12 = PDFFunctions.pages[SAPInput.k].Width;
      double point557 = ((XUnit) ref xunit12).Point;
      xunit12 = PDFFunctions.pages[SAPInput.k].Height;
      double num636 = ((XUnit) ref xunit12).Point / 2.0;
      XRect xrect557 = new XRect(20.0, rc1_542, point557, num636);
      XStringFormat topLeft557 = XStringFormat.TopLeft;
      xgraphics557.DrawString("EPC language:", xfont557, (XBrush) black543, xrect557, topLeft557);
      XGraphics xgraphics558 = PDFFunctions.gfx[SAPInput.k];
      // ISSUE: reference to a compiler-generated field
      string epcLanguage = SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].EPCLanguage;
      XFont xfont558 = xfont3;
      XSolidBrush black544 = XBrushes.Black;
      double rc1_543 = (double) SAPInput.RC1;
      xunit12 = PDFFunctions.pages[SAPInput.k].Width;
      double point558 = ((XUnit) ref xunit12).Point;
      xunit12 = PDFFunctions.pages[SAPInput.k].Height;
      double num637 = ((XUnit) ref xunit12).Point / 2.0;
      XRect xrect558 = new XRect(200.0, rc1_543, point558, num637);
      XStringFormat topLeft558 = XStringFormat.TopLeft;
      xgraphics558.DrawString(epcLanguage, xfont558, (XBrush) black544, xrect558, topLeft558);
      checked { SAPInput.RC1 += 12; }
      SAPInput.CheckRC1();
      XGraphics xgraphics559 = PDFFunctions.gfx[SAPInput.k];
      XFont xfont559 = xfont2;
      XSolidBrush black545 = XBrushes.Black;
      double rc1_544 = (double) SAPInput.RC1;
      xunit12 = PDFFunctions.pages[SAPInput.k].Width;
      double point559 = ((XUnit) ref xunit12).Point;
      xunit12 = PDFFunctions.pages[SAPInput.k].Height;
      double num638 = ((XUnit) ref xunit12).Point / 2.0;
      XRect xrect559 = new XRect(20.0, rc1_544, point559, num638);
      XStringFormat topLeft559 = XStringFormat.TopLeft;
      xgraphics559.DrawString("Wind turbine:", xfont559, (XBrush) black545, xrect559, topLeft559);
      // ISSUE: reference to a compiler-generated field
      if (SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Renewable.WindTurbine.Inlcude)
      {
        XGraphics xgraphics560 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string str301 = "Number of turbines: " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Renewable.WindTurbine.WNumber);
        XFont xfont560 = xfont3;
        XSolidBrush black546 = XBrushes.Black;
        double rc1_545 = (double) SAPInput.RC1;
        xunit12 = PDFFunctions.pages[SAPInput.k].Width;
        double point560 = ((XUnit) ref xunit12).Point;
        xunit12 = PDFFunctions.pages[SAPInput.k].Height;
        double num639 = ((XUnit) ref xunit12).Point / 2.0;
        XRect xrect560 = new XRect(200.0, rc1_545, point560, num639);
        XStringFormat topLeft560 = XStringFormat.TopLeft;
        xgraphics560.DrawString(str301, xfont560, (XBrush) black546, xrect560, topLeft560);
        checked { SAPInput.RC1 += 12; }
        XGraphics xgraphics561 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string str302 = "hub height above building: " + SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Renewable.WindTurbine.WHeight;
        XFont xfont561 = xfont3;
        XSolidBrush black547 = XBrushes.Black;
        double rc1_546 = (double) SAPInput.RC1;
        xunit12 = PDFFunctions.pages[SAPInput.k].Width;
        double point561 = ((XUnit) ref xunit12).Point;
        xunit12 = PDFFunctions.pages[SAPInput.k].Height;
        double num640 = ((XUnit) ref xunit12).Point / 2.0;
        XRect xrect561 = new XRect(200.0, rc1_546, point561, num640);
        XStringFormat topLeft561 = XStringFormat.TopLeft;
        xgraphics561.DrawString(str302, xfont561, (XBrush) black547, xrect561, topLeft561);
        checked { SAPInput.RC1 += 12; }
        XGraphics xgraphics562 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string str303 = "Rotor diameter: " + SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Renewable.WindTurbine.WRDiameter;
        XFont xfont562 = xfont3;
        XSolidBrush black548 = XBrushes.Black;
        double rc1_547 = (double) SAPInput.RC1;
        xunit12 = PDFFunctions.pages[SAPInput.k].Width;
        double point562 = ((XUnit) ref xunit12).Point;
        xunit12 = PDFFunctions.pages[SAPInput.k].Height;
        double num641 = ((XUnit) ref xunit12).Point / 2.0;
        XRect xrect562 = new XRect(200.0, rc1_547, point562, num641);
        XStringFormat topLeft562 = XStringFormat.TopLeft;
        xgraphics562.DrawString(str303, xfont562, (XBrush) black548, xrect562, topLeft562);
        checked { SAPInput.RC1 += 14; }
      }
      else
      {
        XGraphics xgraphics563 = PDFFunctions.gfx[SAPInput.k];
        XFont xfont563 = xfont3;
        XSolidBrush black549 = XBrushes.Black;
        double rc1_548 = (double) SAPInput.RC1;
        xunit12 = PDFFunctions.pages[SAPInput.k].Width;
        double point563 = ((XUnit) ref xunit12).Point;
        xunit12 = PDFFunctions.pages[SAPInput.k].Height;
        double num642 = ((XUnit) ref xunit12).Point / 2.0;
        XRect xrect563 = new XRect(200.0, rc1_548, point563, num642);
        XStringFormat topLeft563 = XStringFormat.TopLeft;
        xgraphics563.DrawString("No", xfont563, (XBrush) black549, xrect563, topLeft563);
        checked { SAPInput.RC1 += 14; }
      }
      SAPInput.CheckRC1();
      XGraphics xgraphics564 = PDFFunctions.gfx[SAPInput.k];
      XFont xfont564 = xfont2;
      XSolidBrush black550 = XBrushes.Black;
      double rc1_549 = (double) SAPInput.RC1;
      xunit12 = PDFFunctions.pages[SAPInput.k].Width;
      double point564 = ((XUnit) ref xunit12).Point;
      xunit12 = PDFFunctions.pages[SAPInput.k].Height;
      double num643 = ((XUnit) ref xunit12).Point / 2.0;
      XRect xrect564 = new XRect(20.0, rc1_549, point564, num643);
      XStringFormat topLeft564 = XStringFormat.TopLeft;
      xgraphics564.DrawString("Photovoltaics:", xfont564, (XBrush) black550, xrect564, topLeft564);
      // ISSUE: reference to a compiler-generated field
      if (SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Renewable.Photovoltaic.Inlcude)
      {
        // ISSUE: reference to a compiler-generated field
        int num644 = checked (SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Renewable.Photovoltaic.Photovoltaics.Length - 1);
        int index25 = 0;
        while (index25 <= num644)
        {
          XGraphics xgraphics565 = PDFFunctions.gfx[SAPInput.k];
          string str304 = "Photovoltaic " + Conversions.ToString(checked (index25 + 1));
          XFont xfont565 = xfont4;
          XSolidBrush black551 = XBrushes.Black;
          double rc1_550 = (double) SAPInput.RC1;
          xunit12 = PDFFunctions.pages[SAPInput.k].Width;
          double point565 = ((XUnit) ref xunit12).Point;
          xunit12 = PDFFunctions.pages[SAPInput.k].Height;
          double num645 = ((XUnit) ref xunit12).Point / 2.0;
          XRect xrect565 = new XRect(200.0, rc1_550, point565, num645);
          XStringFormat topLeft565 = XStringFormat.TopLeft;
          xgraphics565.DrawString(str304, xfont565, (XBrush) black551, xrect565, topLeft565);
          checked { SAPInput.RC1 += 12; }
          SAPInput.CheckRC1();
          XGraphics xgraphics566 = PDFFunctions.gfx[SAPInput.k];
          // ISSUE: reference to a compiler-generated field
          string str305 = "Installed Peak power: " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Renewable.Photovoltaic.Photovoltaics[index25].PPower);
          XFont xfont566 = xfont3;
          XSolidBrush black552 = XBrushes.Black;
          double rc1_551 = (double) SAPInput.RC1;
          xunit12 = PDFFunctions.pages[SAPInput.k].Width;
          double point566 = ((XUnit) ref xunit12).Point;
          xunit12 = PDFFunctions.pages[SAPInput.k].Height;
          double num646 = ((XUnit) ref xunit12).Point / 2.0;
          XRect xrect566 = new XRect(200.0, rc1_551, point566, num646);
          XStringFormat topLeft566 = XStringFormat.TopLeft;
          xgraphics566.DrawString(str305, xfont566, (XBrush) black552, xrect566, topLeft566);
          checked { SAPInput.RC1 += 12; }
          SAPInput.CheckRC1();
          XGraphics xgraphics567 = PDFFunctions.gfx[SAPInput.k];
          // ISSUE: reference to a compiler-generated field
          string str306 = "Tilt of collector: " + SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Renewable.Photovoltaic.Photovoltaics[index25].PTilt;
          XFont xfont567 = xfont3;
          XSolidBrush black553 = XBrushes.Black;
          double rc1_552 = (double) SAPInput.RC1;
          xunit12 = PDFFunctions.pages[SAPInput.k].Width;
          double point567 = ((XUnit) ref xunit12).Point;
          xunit12 = PDFFunctions.pages[SAPInput.k].Height;
          double num647 = ((XUnit) ref xunit12).Point / 2.0;
          XRect xrect567 = new XRect(200.0, rc1_552, point567, num647);
          XStringFormat topLeft567 = XStringFormat.TopLeft;
          xgraphics567.DrawString(str306, xfont567, (XBrush) black553, xrect567, topLeft567);
          checked { SAPInput.RC1 += 12; }
          SAPInput.CheckRC1();
          XGraphics xgraphics568 = PDFFunctions.gfx[SAPInput.k];
          // ISSUE: reference to a compiler-generated field
          string str307 = "Overshading: " + SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Renewable.Photovoltaic.Photovoltaics[index25].POvershading;
          XFont xfont568 = xfont3;
          XSolidBrush black554 = XBrushes.Black;
          double rc1_553 = (double) SAPInput.RC1;
          xunit12 = PDFFunctions.pages[SAPInput.k].Width;
          double point568 = ((XUnit) ref xunit12).Point;
          xunit12 = PDFFunctions.pages[SAPInput.k].Height;
          double num648 = ((XUnit) ref xunit12).Point / 2.0;
          XRect xrect568 = new XRect(200.0, rc1_553, point568, num648);
          XStringFormat topLeft568 = XStringFormat.TopLeft;
          xgraphics568.DrawString(str307, xfont568, (XBrush) black554, xrect568, topLeft568);
          checked { SAPInput.RC1 += 12; }
          SAPInput.CheckRC1();
          XGraphics xgraphics569 = PDFFunctions.gfx[SAPInput.k];
          // ISSUE: reference to a compiler-generated field
          string str308 = "Collector Orientation: " + SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Renewable.Photovoltaic.Photovoltaics[index25].PCOrientation;
          XFont xfont569 = xfont3;
          XSolidBrush black555 = XBrushes.Black;
          double rc1_554 = (double) SAPInput.RC1;
          xunit12 = PDFFunctions.pages[SAPInput.k].Width;
          double point569 = ((XUnit) ref xunit12).Point;
          xunit12 = PDFFunctions.pages[SAPInput.k].Height;
          double num649 = ((XUnit) ref xunit12).Point / 2.0;
          XRect xrect569 = new XRect(200.0, rc1_554, point569, num649);
          XStringFormat topLeft569 = XStringFormat.TopLeft;
          xgraphics569.DrawString(str308, xfont569, (XBrush) black555, xrect569, topLeft569);
          checked { SAPInput.RC1 += 14; }
          SAPInput.CheckRC1();
          checked { ++index25; }
        }
      }
      else
      {
        XGraphics xgraphics570 = PDFFunctions.gfx[SAPInput.k];
        XFont xfont570 = xfont3;
        XSolidBrush black556 = XBrushes.Black;
        double rc1_555 = (double) SAPInput.RC1;
        xunit12 = PDFFunctions.pages[SAPInput.k].Width;
        double point570 = ((XUnit) ref xunit12).Point;
        xunit12 = PDFFunctions.pages[SAPInput.k].Height;
        double num650 = ((XUnit) ref xunit12).Point / 2.0;
        XRect xrect570 = new XRect(200.0, rc1_555, point570, num650);
        XStringFormat topLeft570 = XStringFormat.TopLeft;
        xgraphics570.DrawString("None", xfont570, (XBrush) black556, xrect570, topLeft570);
        checked { SAPInput.RC1 += 14; }
      }
      SAPInput.CheckRC1();
      // ISSUE: reference to a compiler-generated field
      if (SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Renewable.Special.Include)
      {
        // ISSUE: reference to a compiler-generated field
        int num651 = checked (SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Renewable.Special.Special.Length - 1);
        int index26 = 0;
        while (index26 <= num651)
        {
          XGraphics xgraphics571 = PDFFunctions.gfx[SAPInput.k];
          // ISSUE: reference to a compiler-generated field
          string str309 = "Special feature (App. Q): " + SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Renewable.Special.Special[index26].Description;
          XFont xfont571 = xfont4;
          XSolidBrush black557 = XBrushes.Black;
          double rc1_556 = (double) SAPInput.RC1;
          xunit12 = PDFFunctions.pages[SAPInput.k].Width;
          double point571 = ((XUnit) ref xunit12).Point;
          xunit12 = PDFFunctions.pages[SAPInput.k].Height;
          double num652 = ((XUnit) ref xunit12).Point / 2.0;
          XRect xrect571 = new XRect(20.0, rc1_556, point571, num652);
          XStringFormat topLeft571 = XStringFormat.TopLeft;
          xgraphics571.DrawString(str309, xfont571, (XBrush) black557, xrect571, topLeft571);
          checked { SAPInput.RC1 += 12; }
          SAPInput.CheckRC1();
          XGraphics xgraphics572 = PDFFunctions.gfx[SAPInput.k];
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          string str310 = "Energy saved: " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Renewable.Special.Special[index26].EnergySaved) + " kWh (" + SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Renewable.Special.Special[index26].FuelSaved + ")";
          XFont xfont572 = xfont3;
          XSolidBrush black558 = XBrushes.Black;
          double rc1_557 = (double) SAPInput.RC1;
          xunit12 = PDFFunctions.pages[SAPInput.k].Width;
          double point572 = ((XUnit) ref xunit12).Point;
          xunit12 = PDFFunctions.pages[SAPInput.k].Height;
          double num653 = ((XUnit) ref xunit12).Point / 2.0;
          XRect xrect572 = new XRect(200.0, rc1_557, point572, num653);
          XStringFormat topLeft572 = XStringFormat.TopLeft;
          xgraphics572.DrawString(str310, xfont572, (XBrush) black558, xrect572, topLeft572);
          checked { SAPInput.RC1 += 12; }
          SAPInput.CheckRC1();
          XGraphics xgraphics573 = PDFFunctions.gfx[SAPInput.k];
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          string str311 = "Energy used: " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Renewable.Special.Special[index26].EnergyUsed) + " kWh (" + SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Renewable.Special.Special[index26].FuelUsed + ")";
          XFont xfont573 = xfont3;
          XSolidBrush black559 = XBrushes.Black;
          double rc1_558 = (double) SAPInput.RC1;
          xunit12 = PDFFunctions.pages[SAPInput.k].Width;
          double point573 = ((XUnit) ref xunit12).Point;
          xunit12 = PDFFunctions.pages[SAPInput.k].Height;
          double num654 = ((XUnit) ref xunit12).Point / 2.0;
          XRect xrect573 = new XRect(200.0, rc1_558, point573, num654);
          XStringFormat topLeft573 = XStringFormat.TopLeft;
          xgraphics573.DrawString(str311, xfont573, (XBrush) black559, xrect573, topLeft573);
          // ISSUE: reference to a compiler-generated field
          if (SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Renewable.Special.Special[index26].IncludeMonthly)
          {
            XSize pageSize = PDFFunctions.gfx[SAPInput.k].PageSize;
            float num655 = (float) ((((XSize) ref pageSize).Width - 40.0) / 12.0);
            checked { SAPInput.RC1 += 12; }
            SAPInput.CheckRC1();
            XGraphics xgraphics574 = PDFFunctions.gfx[SAPInput.k];
            // ISSUE: reference to a compiler-generated field
            string str312 = "Air change rates (January to December): " + SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Renewable.Special.Special[index26].Description;
            XFont xfont574 = xfont4;
            XSolidBrush black560 = XBrushes.Black;
            double rc1_559 = (double) SAPInput.RC1;
            xunit12 = PDFFunctions.pages[SAPInput.k].Width;
            double point574 = ((XUnit) ref xunit12).Point;
            xunit12 = PDFFunctions.pages[SAPInput.k].Height;
            double num656 = ((XUnit) ref xunit12).Point / 2.0;
            XRect xrect574 = new XRect(20.0, rc1_559, point574, num656);
            XStringFormat topLeft574 = XStringFormat.TopLeft;
            xgraphics574.DrawString(str312, xfont574, (XBrush) black560, xrect574, topLeft574);
            checked { SAPInput.RC1 += 12; }
            SAPInput.CheckRC1();
            XGraphics xgraphics575 = PDFFunctions.gfx[SAPInput.k];
            XFont xfont575 = xfont3;
            XSolidBrush black561 = XBrushes.Black;
            double rc1_560 = (double) SAPInput.RC1;
            xunit12 = PDFFunctions.pages[SAPInput.k].Width;
            double point575 = ((XUnit) ref xunit12).Point;
            xunit12 = PDFFunctions.pages[SAPInput.k].Height;
            double num657 = ((XUnit) ref xunit12).Point / 2.0;
            XRect xrect575 = new XRect(20.0, rc1_560, point575, num657);
            XStringFormat topLeft575 = XStringFormat.TopLeft;
            xgraphics575.DrawString("Jan", xfont575, (XBrush) black561, xrect575, topLeft575);
            XGraphics xgraphics576 = PDFFunctions.gfx[SAPInput.k];
            XFont xfont576 = xfont3;
            XSolidBrush black562 = XBrushes.Black;
            double num658 = 20.0 + 1.0 * (double) num655;
            double rc1_561 = (double) SAPInput.RC1;
            xunit12 = PDFFunctions.pages[SAPInput.k].Width;
            double point576 = ((XUnit) ref xunit12).Point;
            xunit12 = PDFFunctions.pages[SAPInput.k].Height;
            double num659 = ((XUnit) ref xunit12).Point / 2.0;
            XRect xrect576 = new XRect(num658, rc1_561, point576, num659);
            XStringFormat topLeft576 = XStringFormat.TopLeft;
            xgraphics576.DrawString("Feb", xfont576, (XBrush) black562, xrect576, topLeft576);
            XGraphics xgraphics577 = PDFFunctions.gfx[SAPInput.k];
            XFont xfont577 = xfont3;
            XSolidBrush black563 = XBrushes.Black;
            double num660 = 20.0 + 2.0 * (double) num655;
            double rc1_562 = (double) SAPInput.RC1;
            xunit12 = PDFFunctions.pages[SAPInput.k].Width;
            double point577 = ((XUnit) ref xunit12).Point;
            xunit12 = PDFFunctions.pages[SAPInput.k].Height;
            double num661 = ((XUnit) ref xunit12).Point / 2.0;
            XRect xrect577 = new XRect(num660, rc1_562, point577, num661);
            XStringFormat topLeft577 = XStringFormat.TopLeft;
            xgraphics577.DrawString("March", xfont577, (XBrush) black563, xrect577, topLeft577);
            XGraphics xgraphics578 = PDFFunctions.gfx[SAPInput.k];
            XFont xfont578 = xfont3;
            XSolidBrush black564 = XBrushes.Black;
            double num662 = 20.0 + 3.0 * (double) num655;
            double rc1_563 = (double) SAPInput.RC1;
            xunit12 = PDFFunctions.pages[SAPInput.k].Width;
            double point578 = ((XUnit) ref xunit12).Point;
            xunit12 = PDFFunctions.pages[SAPInput.k].Height;
            double num663 = ((XUnit) ref xunit12).Point / 2.0;
            XRect xrect578 = new XRect(num662, rc1_563, point578, num663);
            XStringFormat topLeft578 = XStringFormat.TopLeft;
            xgraphics578.DrawString("April", xfont578, (XBrush) black564, xrect578, topLeft578);
            XGraphics xgraphics579 = PDFFunctions.gfx[SAPInput.k];
            XFont xfont579 = xfont3;
            XSolidBrush black565 = XBrushes.Black;
            double num664 = 20.0 + 4.0 * (double) num655;
            double rc1_564 = (double) SAPInput.RC1;
            xunit12 = PDFFunctions.pages[SAPInput.k].Width;
            double point579 = ((XUnit) ref xunit12).Point;
            xunit12 = PDFFunctions.pages[SAPInput.k].Height;
            double num665 = ((XUnit) ref xunit12).Point / 2.0;
            XRect xrect579 = new XRect(num664, rc1_564, point579, num665);
            XStringFormat topLeft579 = XStringFormat.TopLeft;
            xgraphics579.DrawString("May", xfont579, (XBrush) black565, xrect579, topLeft579);
            XGraphics xgraphics580 = PDFFunctions.gfx[SAPInput.k];
            XFont xfont580 = xfont3;
            XSolidBrush black566 = XBrushes.Black;
            double num666 = 20.0 + 5.0 * (double) num655;
            double rc1_565 = (double) SAPInput.RC1;
            xunit12 = PDFFunctions.pages[SAPInput.k].Width;
            double point580 = ((XUnit) ref xunit12).Point;
            xunit12 = PDFFunctions.pages[SAPInput.k].Height;
            double num667 = ((XUnit) ref xunit12).Point / 2.0;
            XRect xrect580 = new XRect(num666, rc1_565, point580, num667);
            XStringFormat topLeft580 = XStringFormat.TopLeft;
            xgraphics580.DrawString("June", xfont580, (XBrush) black566, xrect580, topLeft580);
            XGraphics xgraphics581 = PDFFunctions.gfx[SAPInput.k];
            XFont xfont581 = xfont3;
            XSolidBrush black567 = XBrushes.Black;
            double num668 = 20.0 + 6.0 * (double) num655;
            double rc1_566 = (double) SAPInput.RC1;
            xunit12 = PDFFunctions.pages[SAPInput.k].Width;
            double point581 = ((XUnit) ref xunit12).Point;
            xunit12 = PDFFunctions.pages[SAPInput.k].Height;
            double num669 = ((XUnit) ref xunit12).Point / 2.0;
            XRect xrect581 = new XRect(num668, rc1_566, point581, num669);
            XStringFormat topLeft581 = XStringFormat.TopLeft;
            xgraphics581.DrawString("July", xfont581, (XBrush) black567, xrect581, topLeft581);
            XGraphics xgraphics582 = PDFFunctions.gfx[SAPInput.k];
            XFont xfont582 = xfont3;
            XSolidBrush black568 = XBrushes.Black;
            double num670 = 20.0 + 7.0 * (double) num655;
            double rc1_567 = (double) SAPInput.RC1;
            xunit12 = PDFFunctions.pages[SAPInput.k].Width;
            double point582 = ((XUnit) ref xunit12).Point;
            xunit12 = PDFFunctions.pages[SAPInput.k].Height;
            double num671 = ((XUnit) ref xunit12).Point / 2.0;
            XRect xrect582 = new XRect(num670, rc1_567, point582, num671);
            XStringFormat topLeft582 = XStringFormat.TopLeft;
            xgraphics582.DrawString("Aug", xfont582, (XBrush) black568, xrect582, topLeft582);
            XGraphics xgraphics583 = PDFFunctions.gfx[SAPInput.k];
            XFont xfont583 = xfont3;
            XSolidBrush black569 = XBrushes.Black;
            double num672 = 20.0 + 8.0 * (double) num655;
            double rc1_568 = (double) SAPInput.RC1;
            xunit12 = PDFFunctions.pages[SAPInput.k].Width;
            double point583 = ((XUnit) ref xunit12).Point;
            xunit12 = PDFFunctions.pages[SAPInput.k].Height;
            double num673 = ((XUnit) ref xunit12).Point / 2.0;
            XRect xrect583 = new XRect(num672, rc1_568, point583, num673);
            XStringFormat topLeft583 = XStringFormat.TopLeft;
            xgraphics583.DrawString("Sept", xfont583, (XBrush) black569, xrect583, topLeft583);
            XGraphics xgraphics584 = PDFFunctions.gfx[SAPInput.k];
            XFont xfont584 = xfont3;
            XSolidBrush black570 = XBrushes.Black;
            double num674 = 20.0 + 9.0 * (double) num655;
            double rc1_569 = (double) SAPInput.RC1;
            xunit12 = PDFFunctions.pages[SAPInput.k].Width;
            double point584 = ((XUnit) ref xunit12).Point;
            xunit12 = PDFFunctions.pages[SAPInput.k].Height;
            double num675 = ((XUnit) ref xunit12).Point / 2.0;
            XRect xrect584 = new XRect(num674, rc1_569, point584, num675);
            XStringFormat topLeft584 = XStringFormat.TopLeft;
            xgraphics584.DrawString("Oct", xfont584, (XBrush) black570, xrect584, topLeft584);
            XGraphics xgraphics585 = PDFFunctions.gfx[SAPInput.k];
            XFont xfont585 = xfont3;
            XSolidBrush black571 = XBrushes.Black;
            double num676 = 20.0 + 10.0 * (double) num655;
            double rc1_570 = (double) SAPInput.RC1;
            xunit12 = PDFFunctions.pages[SAPInput.k].Width;
            double point585 = ((XUnit) ref xunit12).Point;
            xunit12 = PDFFunctions.pages[SAPInput.k].Height;
            double num677 = ((XUnit) ref xunit12).Point / 2.0;
            XRect xrect585 = new XRect(num676, rc1_570, point585, num677);
            XStringFormat topLeft585 = XStringFormat.TopLeft;
            xgraphics585.DrawString("Nov", xfont585, (XBrush) black571, xrect585, topLeft585);
            XGraphics xgraphics586 = PDFFunctions.gfx[SAPInput.k];
            XFont xfont586 = xfont3;
            XSolidBrush black572 = XBrushes.Black;
            double num678 = 20.0 + 11.0 * (double) num655;
            double rc1_571 = (double) SAPInput.RC1;
            xunit12 = PDFFunctions.pages[SAPInput.k].Width;
            double point586 = ((XUnit) ref xunit12).Point;
            xunit12 = PDFFunctions.pages[SAPInput.k].Height;
            double num679 = ((XUnit) ref xunit12).Point / 2.0;
            XRect xrect586 = new XRect(num678, rc1_571, point586, num679);
            XStringFormat topLeft586 = XStringFormat.TopLeft;
            xgraphics586.DrawString("Dec", xfont586, (XBrush) black572, xrect586, topLeft586);
            checked { SAPInput.RC1 += 12; }
            SAPInput.CheckRC1();
            XGraphics xgraphics587 = PDFFunctions.gfx[SAPInput.k];
            // ISSUE: reference to a compiler-generated field
            string str313 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Renewable.Special.Special[index26].M1);
            XFont xfont587 = xfont3;
            XSolidBrush black573 = XBrushes.Black;
            double rc1_572 = (double) SAPInput.RC1;
            xunit12 = PDFFunctions.pages[SAPInput.k].Width;
            double point587 = ((XUnit) ref xunit12).Point;
            xunit12 = PDFFunctions.pages[SAPInput.k].Height;
            double num680 = ((XUnit) ref xunit12).Point / 2.0;
            XRect xrect587 = new XRect(20.0, rc1_572, point587, num680);
            XStringFormat topLeft587 = XStringFormat.TopLeft;
            xgraphics587.DrawString(str313, xfont587, (XBrush) black573, xrect587, topLeft587);
            XGraphics xgraphics588 = PDFFunctions.gfx[SAPInput.k];
            // ISSUE: reference to a compiler-generated field
            string str314 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Renewable.Special.Special[index26].M2);
            XFont xfont588 = xfont3;
            XSolidBrush black574 = XBrushes.Black;
            double num681 = 20.0 + 1.0 * (double) num655;
            double rc1_573 = (double) SAPInput.RC1;
            xunit12 = PDFFunctions.pages[SAPInput.k].Width;
            double point588 = ((XUnit) ref xunit12).Point;
            xunit12 = PDFFunctions.pages[SAPInput.k].Height;
            double num682 = ((XUnit) ref xunit12).Point / 2.0;
            XRect xrect588 = new XRect(num681, rc1_573, point588, num682);
            XStringFormat topLeft588 = XStringFormat.TopLeft;
            xgraphics588.DrawString(str314, xfont588, (XBrush) black574, xrect588, topLeft588);
            XGraphics xgraphics589 = PDFFunctions.gfx[SAPInput.k];
            // ISSUE: reference to a compiler-generated field
            string str315 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Renewable.Special.Special[index26].M3);
            XFont xfont589 = xfont3;
            XSolidBrush black575 = XBrushes.Black;
            double num683 = 20.0 + 2.0 * (double) num655;
            double rc1_574 = (double) SAPInput.RC1;
            xunit12 = PDFFunctions.pages[SAPInput.k].Width;
            double point589 = ((XUnit) ref xunit12).Point;
            xunit12 = PDFFunctions.pages[SAPInput.k].Height;
            double num684 = ((XUnit) ref xunit12).Point / 2.0;
            XRect xrect589 = new XRect(num683, rc1_574, point589, num684);
            XStringFormat topLeft589 = XStringFormat.TopLeft;
            xgraphics589.DrawString(str315, xfont589, (XBrush) black575, xrect589, topLeft589);
            XGraphics xgraphics590 = PDFFunctions.gfx[SAPInput.k];
            // ISSUE: reference to a compiler-generated field
            string str316 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Renewable.Special.Special[index26].M4);
            XFont xfont590 = xfont3;
            XSolidBrush black576 = XBrushes.Black;
            double num685 = 20.0 + 3.0 * (double) num655;
            double rc1_575 = (double) SAPInput.RC1;
            xunit12 = PDFFunctions.pages[SAPInput.k].Width;
            double point590 = ((XUnit) ref xunit12).Point;
            xunit12 = PDFFunctions.pages[SAPInput.k].Height;
            double num686 = ((XUnit) ref xunit12).Point / 2.0;
            XRect xrect590 = new XRect(num685, rc1_575, point590, num686);
            XStringFormat topLeft590 = XStringFormat.TopLeft;
            xgraphics590.DrawString(str316, xfont590, (XBrush) black576, xrect590, topLeft590);
            XGraphics xgraphics591 = PDFFunctions.gfx[SAPInput.k];
            // ISSUE: reference to a compiler-generated field
            string str317 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Renewable.Special.Special[index26].M5);
            XFont xfont591 = xfont3;
            XSolidBrush black577 = XBrushes.Black;
            double num687 = 20.0 + 4.0 * (double) num655;
            double rc1_576 = (double) SAPInput.RC1;
            xunit12 = PDFFunctions.pages[SAPInput.k].Width;
            double point591 = ((XUnit) ref xunit12).Point;
            xunit12 = PDFFunctions.pages[SAPInput.k].Height;
            double num688 = ((XUnit) ref xunit12).Point / 2.0;
            XRect xrect591 = new XRect(num687, rc1_576, point591, num688);
            XStringFormat topLeft591 = XStringFormat.TopLeft;
            xgraphics591.DrawString(str317, xfont591, (XBrush) black577, xrect591, topLeft591);
            XGraphics xgraphics592 = PDFFunctions.gfx[SAPInput.k];
            // ISSUE: reference to a compiler-generated field
            string str318 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Renewable.Special.Special[index26].M6);
            XFont xfont592 = xfont3;
            XSolidBrush black578 = XBrushes.Black;
            double num689 = 20.0 + 5.0 * (double) num655;
            double rc1_577 = (double) SAPInput.RC1;
            xunit12 = PDFFunctions.pages[SAPInput.k].Width;
            double point592 = ((XUnit) ref xunit12).Point;
            xunit12 = PDFFunctions.pages[SAPInput.k].Height;
            double num690 = ((XUnit) ref xunit12).Point / 2.0;
            XRect xrect592 = new XRect(num689, rc1_577, point592, num690);
            XStringFormat topLeft592 = XStringFormat.TopLeft;
            xgraphics592.DrawString(str318, xfont592, (XBrush) black578, xrect592, topLeft592);
            XGraphics xgraphics593 = PDFFunctions.gfx[SAPInput.k];
            // ISSUE: reference to a compiler-generated field
            string str319 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Renewable.Special.Special[index26].M7);
            XFont xfont593 = xfont3;
            XSolidBrush black579 = XBrushes.Black;
            double num691 = 20.0 + 6.0 * (double) num655;
            double rc1_578 = (double) SAPInput.RC1;
            xunit12 = PDFFunctions.pages[SAPInput.k].Width;
            double point593 = ((XUnit) ref xunit12).Point;
            xunit12 = PDFFunctions.pages[SAPInput.k].Height;
            double num692 = ((XUnit) ref xunit12).Point / 2.0;
            XRect xrect593 = new XRect(num691, rc1_578, point593, num692);
            XStringFormat topLeft593 = XStringFormat.TopLeft;
            xgraphics593.DrawString(str319, xfont593, (XBrush) black579, xrect593, topLeft593);
            XGraphics xgraphics594 = PDFFunctions.gfx[SAPInput.k];
            // ISSUE: reference to a compiler-generated field
            string str320 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Renewable.Special.Special[index26].M8);
            XFont xfont594 = xfont3;
            XSolidBrush black580 = XBrushes.Black;
            double num693 = 20.0 + 7.0 * (double) num655;
            double rc1_579 = (double) SAPInput.RC1;
            xunit12 = PDFFunctions.pages[SAPInput.k].Width;
            double point594 = ((XUnit) ref xunit12).Point;
            xunit12 = PDFFunctions.pages[SAPInput.k].Height;
            double num694 = ((XUnit) ref xunit12).Point / 2.0;
            XRect xrect594 = new XRect(num693, rc1_579, point594, num694);
            XStringFormat topLeft594 = XStringFormat.TopLeft;
            xgraphics594.DrawString(str320, xfont594, (XBrush) black580, xrect594, topLeft594);
            XGraphics xgraphics595 = PDFFunctions.gfx[SAPInput.k];
            // ISSUE: reference to a compiler-generated field
            string str321 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Renewable.Special.Special[index26].M9);
            XFont xfont595 = xfont3;
            XSolidBrush black581 = XBrushes.Black;
            double num695 = 20.0 + 8.0 * (double) num655;
            double rc1_580 = (double) SAPInput.RC1;
            xunit12 = PDFFunctions.pages[SAPInput.k].Width;
            double point595 = ((XUnit) ref xunit12).Point;
            xunit12 = PDFFunctions.pages[SAPInput.k].Height;
            double num696 = ((XUnit) ref xunit12).Point / 2.0;
            XRect xrect595 = new XRect(num695, rc1_580, point595, num696);
            XStringFormat topLeft595 = XStringFormat.TopLeft;
            xgraphics595.DrawString(str321, xfont595, (XBrush) black581, xrect595, topLeft595);
            XGraphics xgraphics596 = PDFFunctions.gfx[SAPInput.k];
            // ISSUE: reference to a compiler-generated field
            string str322 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Renewable.Special.Special[index26].M10);
            XFont xfont596 = xfont3;
            XSolidBrush black582 = XBrushes.Black;
            double num697 = 20.0 + 9.0 * (double) num655;
            double rc1_581 = (double) SAPInput.RC1;
            xunit12 = PDFFunctions.pages[SAPInput.k].Width;
            double point596 = ((XUnit) ref xunit12).Point;
            xunit12 = PDFFunctions.pages[SAPInput.k].Height;
            double num698 = ((XUnit) ref xunit12).Point / 2.0;
            XRect xrect596 = new XRect(num697, rc1_581, point596, num698);
            XStringFormat topLeft596 = XStringFormat.TopLeft;
            xgraphics596.DrawString(str322, xfont596, (XBrush) black582, xrect596, topLeft596);
            XGraphics xgraphics597 = PDFFunctions.gfx[SAPInput.k];
            // ISSUE: reference to a compiler-generated field
            string str323 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Renewable.Special.Special[index26].M11);
            XFont xfont597 = xfont3;
            XSolidBrush black583 = XBrushes.Black;
            double num699 = 20.0 + 10.0 * (double) num655;
            double rc1_582 = (double) SAPInput.RC1;
            xunit12 = PDFFunctions.pages[SAPInput.k].Width;
            double point597 = ((XUnit) ref xunit12).Point;
            xunit12 = PDFFunctions.pages[SAPInput.k].Height;
            double num700 = ((XUnit) ref xunit12).Point / 2.0;
            XRect xrect597 = new XRect(num699, rc1_582, point597, num700);
            XStringFormat topLeft597 = XStringFormat.TopLeft;
            xgraphics597.DrawString(str323, xfont597, (XBrush) black583, xrect597, topLeft597);
            XGraphics xgraphics598 = PDFFunctions.gfx[SAPInput.k];
            // ISSUE: reference to a compiler-generated field
            string str324 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Renewable.Special.Special[index26].M12);
            XFont xfont598 = xfont3;
            XSolidBrush black584 = XBrushes.Black;
            double num701 = 20.0 + 11.0 * (double) num655;
            double rc1_583 = (double) SAPInput.RC1;
            xunit12 = PDFFunctions.pages[SAPInput.k].Width;
            double point598 = ((XUnit) ref xunit12).Point;
            xunit12 = PDFFunctions.pages[SAPInput.k].Height;
            double num702 = ((XUnit) ref xunit12).Point / 2.0;
            XRect xrect598 = new XRect(num701, rc1_583, point598, num702);
            XStringFormat topLeft598 = XStringFormat.TopLeft;
            xgraphics598.DrawString(str324, xfont598, (XBrush) black584, xrect598, topLeft598);
          }
          checked { SAPInput.RC1 += 14; }
          SAPInput.CheckRC1();
          checked { ++index26; }
        }
      }
      SAPInput.CheckRC1();
      // ISSUE: reference to a compiler-generated field
      if (SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Renewable.AAEGeneration.Inlcude)
      {
        XGraphics xgraphics599 = PDFFunctions.gfx[SAPInput.k];
        XFont xfont599 = xfont2;
        XSolidBrush black585 = XBrushes.Black;
        double rc1_584 = (double) SAPInput.RC1;
        xunit12 = PDFFunctions.pages[SAPInput.k].Width;
        double point599 = ((XUnit) ref xunit12).Point;
        xunit12 = PDFFunctions.pages[SAPInput.k].Height;
        double num703 = ((XUnit) ref xunit12).Point / 2.0;
        XRect xrect599 = new XRect(20.0, rc1_584, point599, num703);
        XStringFormat topLeft599 = XStringFormat.TopLeft;
        xgraphics599.DrawString("Additional Allowable Electricity: ", xfont599, (XBrush) black585, xrect599, topLeft599);
        checked { SAPInput.RC1 += 12; }
        XGraphics xgraphics600 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string str325 = "Energy generated: " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Renewable.AAEGeneration.EGenerated) + " kWh/year ";
        XFont xfont600 = xfont3;
        XSolidBrush black586 = XBrushes.Black;
        double rc1_585 = (double) SAPInput.RC1;
        xunit12 = PDFFunctions.pages[SAPInput.k].Width;
        double point600 = ((XUnit) ref xunit12).Point;
        xunit12 = PDFFunctions.pages[SAPInput.k].Height;
        double num704 = ((XUnit) ref xunit12).Point / 2.0;
        XRect xrect600 = new XRect(200.0, rc1_585, point600, num704);
        XStringFormat topLeft600 = XStringFormat.TopLeft;
        xgraphics600.DrawString(str325, xfont600, (XBrush) black586, xrect600, topLeft600);
        checked { SAPInput.RC1 += 12; }
        XGraphics xgraphics601 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string str326 = "Total Area: " + SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Renewable.AAEGeneration.TotalArea + " m\u00B2";
        XFont xfont601 = xfont3;
        XSolidBrush black587 = XBrushes.Black;
        double rc1_586 = (double) SAPInput.RC1;
        xunit12 = PDFFunctions.pages[SAPInput.k].Width;
        double point601 = ((XUnit) ref xunit12).Point;
        xunit12 = PDFFunctions.pages[SAPInput.k].Height;
        double num705 = ((XUnit) ref xunit12).Point / 2.0;
        XRect xrect601 = new XRect(200.0, rc1_586, point601, num705);
        XStringFormat topLeft601 = XStringFormat.TopLeft;
        xgraphics601.DrawString(str326, xfont601, (XBrush) black587, xrect601, topLeft601);
        checked { SAPInput.RC1 += 12; }
      }
      // ISSUE: reference to a compiler-generated field
      if (SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Renewable.HydroGeneration.Inlcude)
      {
        XGraphics xgraphics602 = PDFFunctions.gfx[SAPInput.k];
        XFont xfont602 = xfont2;
        XSolidBrush black588 = XBrushes.Black;
        double rc1_587 = (double) SAPInput.RC1;
        xunit12 = PDFFunctions.pages[SAPInput.k].Width;
        double point602 = ((XUnit) ref xunit12).Point;
        xunit12 = PDFFunctions.pages[SAPInput.k].Height;
        double num706 = ((XUnit) ref xunit12).Point / 2.0;
        XRect xrect602 = new XRect(20.0, rc1_587, point602, num706);
        XStringFormat topLeft602 = XStringFormat.TopLeft;
        xgraphics602.DrawString("Small scale hydro-electic generation: ", xfont602, (XBrush) black588, xrect602, topLeft602);
        XGraphics xgraphics603 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string str327 = "Energy generated: " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Renewable.HydroGeneration.HydroGenerated) + " kWh/year ";
        XFont xfont603 = xfont3;
        XSolidBrush black589 = XBrushes.Black;
        double rc1_588 = (double) SAPInput.RC1;
        xunit12 = PDFFunctions.pages[SAPInput.k].Width;
        double point603 = ((XUnit) ref xunit12).Point;
        xunit12 = PDFFunctions.pages[SAPInput.k].Height;
        double num707 = ((XUnit) ref xunit12).Point / 2.0;
        XRect xrect603 = new XRect(200.0, rc1_588, point603, num707);
        XStringFormat topLeft603 = XStringFormat.TopLeft;
        xgraphics603.DrawString(str327, xfont603, (XBrush) black589, xrect603, topLeft603);
        checked { SAPInput.RC1 += 12; }
        XGraphics xgraphics604 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string str328 = "Total Area: " + SAP_Module.Proj.Dwellings[closure160_2.\u0024VB\u0024Local_House].Renewable.HydroGeneration.TotalArea + " m\u00B2";
        XFont xfont604 = xfont3;
        XSolidBrush black590 = XBrushes.Black;
        double rc1_589 = (double) SAPInput.RC1;
        xunit12 = PDFFunctions.pages[SAPInput.k].Width;
        double point604 = ((XUnit) ref xunit12).Point;
        xunit12 = PDFFunctions.pages[SAPInput.k].Height;
        double num708 = ((XUnit) ref xunit12).Point / 2.0;
        XRect xrect604 = new XRect(200.0, rc1_589, point604, num708);
        XStringFormat topLeft604 = XStringFormat.TopLeft;
        xgraphics604.DrawString(str328, xfont604, (XBrush) black590, xrect604, topLeft604);
        checked { SAPInput.RC1 += 12; }
      }
      SAPInput.CheckRC1();
      double num709 = SAP_Module.Calculation2012.Calculation.SAP_rating_11a.SAPRating == 0.0 ? SAP_Module.Calculation2012.Calculation.SAP_rating_11b.SAPRating : SAP_Module.Calculation2012.Calculation.SAP_rating_11a.SAPRating;
      XGraphics xgraphics605 = PDFFunctions.gfx[SAPInput.k];
      XFont xfont605 = xfont2;
      XSolidBrush black591 = XBrushes.Black;
      double rc1_590 = (double) SAPInput.RC1;
      xunit12 = PDFFunctions.pages[SAPInput.k].Width;
      double point605 = ((XUnit) ref xunit12).Point;
      xunit12 = PDFFunctions.pages[SAPInput.k].Height;
      double num710 = ((XUnit) ref xunit12).Point / 2.0;
      XRect xrect605 = new XRect(20.0, rc1_590, point605, num710);
      XStringFormat topLeft605 = XStringFormat.TopLeft;
      xgraphics605.DrawString("Assess Zero Carbon Home:", xfont605, (XBrush) black591, xrect605, topLeft605);
      if (num709 >= 100.0)
      {
        XGraphics xgraphics606 = PDFFunctions.gfx[SAPInput.k];
        XFont xfont606 = xfont3;
        XSolidBrush black592 = XBrushes.Black;
        double rc1_591 = (double) SAPInput.RC1;
        xunit12 = PDFFunctions.pages[SAPInput.k].Width;
        double point606 = ((XUnit) ref xunit12).Point;
        xunit12 = PDFFunctions.pages[SAPInput.k].Height;
        double num711 = ((XUnit) ref xunit12).Point / 2.0;
        XRect xrect606 = new XRect(200.0, rc1_591, point606, num711);
        XStringFormat topLeft606 = XStringFormat.TopLeft;
        xgraphics606.DrawString("Yes", xfont606, (XBrush) black592, xrect606, topLeft606);
      }
      else
      {
        XGraphics xgraphics607 = PDFFunctions.gfx[SAPInput.k];
        XFont xfont607 = xfont3;
        XSolidBrush black593 = XBrushes.Black;
        double rc1_592 = (double) SAPInput.RC1;
        xunit12 = PDFFunctions.pages[SAPInput.k].Width;
        double point607 = ((XUnit) ref xunit12).Point;
        xunit12 = PDFFunctions.pages[SAPInput.k].Height;
        double num712 = ((XUnit) ref xunit12).Point / 2.0;
        XRect xrect607 = new XRect(200.0, rc1_592, point607, num712);
        XStringFormat topLeft607 = XStringFormat.TopLeft;
        xgraphics607.DrawString("No", xfont607, (XBrush) black593, xrect607, topLeft607);
      }
      checked { SAPInput.RC1 += 12; }
      string str329 = Conversions.ToString(checked (SAPInput.k + 1));
      SAPInput.CheckRC1();
      XFont xfont608 = new XFont("Arial", 160.0, (XFontStyle) 1);
      PDFFunctions.transbrush = XBrush.op_Implicit((Brush) new SolidBrush(Color.FromArgb(128, Color.Olive)));
      int k = SAPInput.k;
      int index27 = 0;
      while (index27 <= k)
      {
        if (!Validation.UserLogged)
        {
          XGraphics xgraphics608 = PDFFunctions.gfx[index27];
          XFont xfont609 = xfont608;
          XBrush transbrush = PDFFunctions.transbrush;
          xunit12 = PDFFunctions.pages[SAPInput.k].Width;
          double point608 = ((XUnit) ref xunit12).Point;
          xunit12 = PDFFunctions.pages[SAPInput.k].Height;
          double point609 = ((XUnit) ref xunit12).Point;
          XRect xrect608 = new XRect(0.0, 0.0, point608, point609);
          XStringFormat center = XStringFormat.Center;
          xgraphics608.DrawString("DRAFT", xfont609, transbrush, xrect608, center);
        }
        if (!SAP_Module.Proj.OverRide)
        {
          XGraphics xgraphics609 = PDFFunctions.gfx[index27];
          string str330 = "Stroma FSAP 2012 " + SAP_Module.CurrVersion + " (SAP 9.92) - http://www.stroma.com";
          XFont xfont610 = xfont9;
          XSolidBrush black594 = XBrushes.Black;
          xunit12 = PDFFunctions.pages[SAPInput.k].Width;
          double point610 = ((XUnit) ref xunit12).Point;
          xunit12 = PDFFunctions.pages[SAPInput.k].Height;
          double point611 = ((XUnit) ref xunit12).Point;
          XRect xrect609 = new XRect(20.0, 820.0, point610, point611);
          XStringFormat topLeft608 = XStringFormat.TopLeft;
          xgraphics609.DrawString(str330, xfont610, (XBrush) black594, xrect609, topLeft608);
        }
        else
        {
          XGraphics xgraphics610 = PDFFunctions.gfx[index27];
          string str331 = "Stroma FSAP 2012 " + SAP_Module.Proj.CalcVersion + " (SAP 9.92) - http://www.stroma.com";
          XFont xfont611 = xfont9;
          XSolidBrush black595 = XBrushes.Black;
          xunit12 = PDFFunctions.pages[SAPInput.k].Width;
          double point612 = ((XUnit) ref xunit12).Point;
          xunit12 = PDFFunctions.pages[SAPInput.k].Height;
          double point613 = ((XUnit) ref xunit12).Point;
          XRect xrect610 = new XRect(20.0, 820.0, point612, point613);
          XStringFormat topLeft609 = XStringFormat.TopLeft;
          xgraphics610.DrawString(str331, xfont611, (XBrush) black595, xrect610, topLeft609);
        }
        XGraphics xgraphics611 = PDFFunctions.gfx[index27];
        string str332 = "Page " + Conversions.ToString(checked (index27 + 1)) + " of " + str329;
        XFont xfont612 = xfont9;
        XSolidBrush black596 = XBrushes.Black;
        xunit12 = PDFFunctions.pages[index27].Width;
        double point614 = ((XUnit) ref xunit12).Point;
        xunit12 = PDFFunctions.pages[index27].Height;
        double point615 = ((XUnit) ref xunit12).Point;
        XRect xrect611 = new XRect(520.0, 820.0, point614, point615);
        XStringFormat topLeft610 = XStringFormat.TopLeft;
        xgraphics611.DrawString(str332, xfont612, (XBrush) black596, xrect611, topLeft610);
        checked { ++index27; }
      }
      SAP_Module.PDFFileName = "";
      object folderPath = (object) Environment.GetFolderPath(Environment.SpecialFolder.Personal);
      DirectoryInfo directoryInfo1 = new DirectoryInfo(Conversions.ToString(Operators.ConcatenateObject(folderPath, (object) "\\Stroma SAP 2012")));
      DirectoryInfo directoryInfo2 = new DirectoryInfo(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(folderPath, (object) "\\Stroma SAP 2012\\"), (object) SAP_Module.Proj.Name)));
      DirectoryInfo directoryInfo3 = new DirectoryInfo(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(folderPath, (object) "\\Stroma SAP 2012\\"), (object) SAP_Module.Proj.Name), (object) "\\"), (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Name)));
      if (!PDFFunctions.Draft_PDF)
      {
        sapInput = (Stream) new MemoryStream();
        PDFFunctions.document.Save(sapInput, false);
      }
      else
      {
        SAP_Module.PDFFileName = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(folderPath, (object) "\\Stroma SAP 2012\\"), (object) SAP_Module.Proj.Name), (object) "\\"), (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Name), (object) "\\"), (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Name), (object) "-SAP Input"), (object) ".pdf"));
        PDFFunctions.document.Save(SAP_Module.PDFFileName);
      }
      return sapInput;
    }

    public static Stream ThermalBridgeReport(int House, int Country)
    {
      Stream stream = (Stream) new MemoryStream();
      XFont xfont1 = new XFont("Tahoma", 11.0, (XFontStyle) 1);
      XFont xfont2 = new XFont("Tahoma", 10.0, (XFontStyle) 0);
      XFont xfont3 = new XFont("Tahoma", 9.0, (XFontStyle) 0);
      XFont xfont4 = new XFont("Tahoma", 10.0, (XFontStyle) 4);
      XFont xfont5 = new XFont("Tahoma", 16.0, (XFontStyle) 1);
      XFont xfont6 = new XFont("Tahoma", 10.0, (XFontStyle) 2);
      XFont xfont7 = new XFont("Tahoma", 10.0, (XFontStyle) 1);
      XFont xfont8 = new XFont("Tahoma", 8.0, (XFontStyle) 1);
      XFont xfont9 = new XFont("Tahoma", 8.0, (XFontStyle) 0);
      XFont xfont10 = new XFont("Tahoma", 6.0, (XFontStyle) 0);
      XPen xpen1 = new XPen(XColor.FromArgb(0, 115, 187));
      XPen xpen2 = new XPen(XColor.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue));
      XPen xpen3 = new XPen(XColor.FromArgb(0, 0, (int) byte.MaxValue));
      SAPInput.k = 0;
      PDFFunctions.document = new PdfDocument();
      PDFFunctions.pages[SAPInput.k] = PDFFunctions.document.AddPage();
      PDFFunctions.gfx[SAPInput.k] = XGraphics.FromPdfPage(PDFFunctions.pages[SAPInput.k]);
      XSize xsize = PDFFunctions.gfx[SAPInput.k].PageSize;
      double num1 = ((XSize) ref xsize).Width / 2.0;
      xsize = PDFFunctions.gfx[SAPInput.k].MeasureString("SAP Input", PDFFunctions.ArialFont16Bold);
      double num2 = ((XSize) ref xsize).Width / 2.0;
      int num3 = checked ((int) Math.Round(unchecked (num1 - num2)));
      XGraphics xgraphics1 = PDFFunctions.gfx[SAPInput.k];
      XFont arialFont16Bold = PDFFunctions.ArialFont16Bold;
      XSolidBrush black1 = XBrushes.Black;
      double num4 = (double) num3;
      XUnit xunit1 = PDFFunctions.pages[SAPInput.k].Width;
      double point1 = ((XUnit) ref xunit1).Point;
      xunit1 = PDFFunctions.pages[SAPInput.k].Height;
      double num5 = ((XUnit) ref xunit1).Point / 2.0;
      XRect xrect1 = new XRect(num4, 30.0, point1, num5);
      XStringFormat topLeft1 = XStringFormat.TopLeft;
      xgraphics1.DrawString("Thermal Bridge Report", arialFont16Bold, (XBrush) black1, xrect1, topLeft1);
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
          num8 = checked ((int) Math.Round((double) SAPInput.ImageY));
          num9 = checked ((int) Math.Round(unchecked ((double) checked (image.Height * 100) / (double) image.Width)));
        }
        else
        {
          num8 = checked ((int) Math.Round((double) SAPInput.ImageY));
          num9 = 60;
          num6 = checked ((int) Math.Round(unchecked (575.0 - (double) image.Width / (double) image.Height * 60.0)));
          num7 = checked ((int) Math.Round(unchecked ((double) image.Width / (double) image.Height * 60.0)));
        }
        PDFFunctions.gfx[SAPInput.k].DrawImage(XImage.op_Implicit(image), num6, num8, num7, num9);
        image.Dispose();
      }
      if (UserSettings.USettings.PrintUserSettings.Print)
        PDFFunctions.PrintUserDetails(PDFFunctions.gfx[SAPInput.k]);
      SAPInput.RC1 = 70;
      PDFFunctions.xBrush1 = XBrush.op_Implicit((Brush) new SolidBrush(Color.FromArgb(159, 172, 62)));
      PDFFunctions.Points[0].X = 20f;
      PDFFunctions.Points[0].Y = (float) SAPInput.RC1;
      ref PointF local1 = ref PDFFunctions.Points[1];
      XUnit width1 = PDFFunctions.pages[SAPInput.k].Width;
      double num10 = ((XUnit) ref width1).Point - 20.0;
      local1.X = (float) num10;
      PDFFunctions.Points[1].Y = (float) SAPInput.RC1;
      ref PointF local2 = ref PDFFunctions.Points[2];
      XUnit xunit2 = PDFFunctions.pages[SAPInput.k].Width;
      double num11 = ((XUnit) ref xunit2).Point - 20.0;
      local2.X = (float) num11;
      PDFFunctions.Points[2].Y = (float) checked (SAPInput.RC1 + 14);
      PDFFunctions.Points[3].X = 20f;
      PDFFunctions.Points[3].Y = (float) checked (SAPInput.RC1 + 14);
      XFillMode xfillMode;
      PDFFunctions.gfx[SAPInput.k].DrawPolygon(PDFFunctions.polyGreen2, PDFFunctions.xBrush1, PDFFunctions.Points, xfillMode);
      XGraphics xgraphics2 = PDFFunctions.gfx[SAPInput.k];
      string str1 = "Property Details: " + SAP_Module.Proj.Dwellings[House].Name;
      XFont xfont11 = xfont3;
      XSolidBrush white1 = XBrushes.White;
      double num12 = (double) checked (SAPInput.RC1 + 1);
      xunit2 = PDFFunctions.pages[SAPInput.k].Width;
      double point2 = ((XUnit) ref xunit2).Point;
      xunit2 = PDFFunctions.pages[SAPInput.k].Height;
      double num13 = ((XUnit) ref xunit2).Point / 2.0;
      XRect xrect2 = new XRect(25.0, num12, point2, num13);
      XStringFormat topLeft2 = XStringFormat.TopLeft;
      xgraphics2.DrawString(str1, xfont11, (XBrush) white1, xrect2, topLeft2);
      SAPInput.RC1 = checked ((int) Math.Round(unchecked ((double) PDFFunctions.Points[3].Y + 4.0)));
      string str2 = "";
      if (!string.IsNullOrEmpty(SAP_Module.Proj.Dwellings[House].Address.Line1))
        str2 += SAP_Module.Proj.Dwellings[House].Address.Line1;
      if (!string.IsNullOrEmpty(SAP_Module.Proj.Dwellings[House].Address.Line2))
        str2 = str2 + ", " + SAP_Module.Proj.Dwellings[House].Address.Line2;
      if (!string.IsNullOrEmpty(SAP_Module.Proj.Dwellings[House].Address.Line3))
        str2 = str2 + ", " + SAP_Module.Proj.Dwellings[House].Address.Line3;
      if (!string.IsNullOrEmpty(SAP_Module.Proj.Dwellings[House].Address.City))
        str2 = str2 + ", " + SAP_Module.Proj.Dwellings[House].Address.City;
      if (!string.IsNullOrEmpty(SAP_Module.Proj.Dwellings[House].Address.PostCost))
        str2 = str2 + ", " + SAP_Module.Proj.Dwellings[House].Address.PostCost;
      XGraphics xgraphics3 = PDFFunctions.gfx[SAPInput.k];
      XFont xfont12 = xfont7;
      XSolidBrush black2 = XBrushes.Black;
      double rc1_1 = (double) SAPInput.RC1;
      xunit2 = PDFFunctions.pages[SAPInput.k].Width;
      double point3 = ((XUnit) ref xunit2).Point;
      xunit2 = PDFFunctions.pages[SAPInput.k].Height;
      double num14 = ((XUnit) ref xunit2).Point / 2.0;
      XRect xrect3 = new XRect(20.0, rc1_1, point3, num14);
      XStringFormat topLeft3 = XStringFormat.TopLeft;
      xgraphics3.DrawString("Address:", xfont12, (XBrush) black2, xrect3, topLeft3);
      XGraphics xgraphics4 = PDFFunctions.gfx[SAPInput.k];
      string str3 = str2;
      XFont xfont13 = xfont3;
      XSolidBrush black3 = XBrushes.Black;
      double rc1_2 = (double) SAPInput.RC1;
      xunit2 = PDFFunctions.pages[SAPInput.k].Width;
      double point4 = ((XUnit) ref xunit2).Point;
      xunit2 = PDFFunctions.pages[SAPInput.k].Height;
      double num15 = ((XUnit) ref xunit2).Point / 2.0;
      XRect xrect4 = new XRect(200.0, rc1_2, point4, num15);
      XStringFormat topLeft4 = XStringFormat.TopLeft;
      xgraphics4.DrawString(str3, xfont13, (XBrush) black3, xrect4, topLeft4);
      checked { SAPInput.RC1 += 12; }
      XGraphics xgraphics5 = PDFFunctions.gfx[SAPInput.k];
      XFont xfont14 = xfont7;
      XSolidBrush black4 = XBrushes.Black;
      double rc1_3 = (double) SAPInput.RC1;
      xunit2 = PDFFunctions.pages[SAPInput.k].Width;
      double point5 = ((XUnit) ref xunit2).Point;
      xunit2 = PDFFunctions.pages[SAPInput.k].Height;
      double num16 = ((XUnit) ref xunit2).Point / 2.0;
      XRect xrect5 = new XRect(20.0, rc1_3, point5, num16);
      XStringFormat topLeft5 = XStringFormat.TopLeft;
      xgraphics5.DrawString("Located in:", xfont14, (XBrush) black4, xrect5, topLeft5);
      XGraphics xgraphics6 = PDFFunctions.gfx[SAPInput.k];
      string country = SAP_Module.Proj.Dwellings[House].Address.Country;
      XFont xfont15 = xfont3;
      XSolidBrush black5 = XBrushes.Black;
      double rc1_4 = (double) SAPInput.RC1;
      xunit2 = PDFFunctions.pages[SAPInput.k].Width;
      double point6 = ((XUnit) ref xunit2).Point;
      xunit2 = PDFFunctions.pages[SAPInput.k].Height;
      double num17 = ((XUnit) ref xunit2).Point / 2.0;
      XRect xrect6 = new XRect(200.0, rc1_4, point6, num17);
      XStringFormat topLeft6 = XStringFormat.TopLeft;
      xgraphics6.DrawString(country, xfont15, (XBrush) black5, xrect6, topLeft6);
      checked { SAPInput.RC1 += 12; }
      XGraphics xgraphics7 = PDFFunctions.gfx[SAPInput.k];
      XFont xfont16 = xfont7;
      XSolidBrush black6 = XBrushes.Black;
      double rc1_5 = (double) SAPInput.RC1;
      xunit2 = PDFFunctions.pages[SAPInput.k].Width;
      double point7 = ((XUnit) ref xunit2).Point;
      xunit2 = PDFFunctions.pages[SAPInput.k].Height;
      double num18 = ((XUnit) ref xunit2).Point / 2.0;
      XRect xrect7 = new XRect(20.0, rc1_5, point7, num18);
      XStringFormat topLeft7 = XStringFormat.TopLeft;
      xgraphics7.DrawString("Region:", xfont16, (XBrush) black6, xrect7, topLeft7);
      XGraphics xgraphics8 = PDFFunctions.gfx[SAPInput.k];
      string location = SAP_Module.Proj.Dwellings[House].Location;
      XFont xfont17 = xfont3;
      XSolidBrush black7 = XBrushes.Black;
      double rc1_6 = (double) SAPInput.RC1;
      xunit2 = PDFFunctions.pages[SAPInput.k].Width;
      double point8 = ((XUnit) ref xunit2).Point;
      xunit2 = PDFFunctions.pages[SAPInput.k].Height;
      double num19 = ((XUnit) ref xunit2).Point / 2.0;
      XRect xrect8 = new XRect(200.0, rc1_6, point8, num19);
      XStringFormat topLeft8 = XStringFormat.TopLeft;
      xgraphics8.DrawString(location, xfont17, (XBrush) black7, xrect8, topLeft8);
      checked { SAPInput.RC1 += 12; }
      PDFFunctions.xBrush1 = XBrush.op_Implicit((Brush) new SolidBrush(Color.FromArgb(159, 172, 62)));
      PDFFunctions.Points[0].X = 20f;
      PDFFunctions.Points[0].Y = (float) SAPInput.RC1;
      ref PointF local3 = ref PDFFunctions.Points[1];
      xunit2 = PDFFunctions.pages[SAPInput.k].Width;
      double num20 = ((XUnit) ref xunit2).Point - 20.0;
      local3.X = (float) num20;
      PDFFunctions.Points[1].Y = (float) SAPInput.RC1;
      ref PointF local4 = ref PDFFunctions.Points[2];
      xunit2 = PDFFunctions.pages[SAPInput.k].Width;
      double num21 = ((XUnit) ref xunit2).Point - 20.0;
      local4.X = (float) num21;
      PDFFunctions.Points[2].Y = (float) checked (SAPInput.RC1 + 14);
      PDFFunctions.Points[3].X = 20f;
      PDFFunctions.Points[3].Y = (float) checked (SAPInput.RC1 + 14);
      PDFFunctions.gfx[SAPInput.k].DrawPolygon(PDFFunctions.polyGreen2, PDFFunctions.xBrush1, PDFFunctions.Points, xfillMode);
      PDFFunctions.Points[3].Y = (float) checked (SAPInput.RC1 + 14);
      PDFFunctions.gfx[SAPInput.k].DrawPolygon(PDFFunctions.polyGreen2, PDFFunctions.xBrush1, PDFFunctions.Points, xfillMode);
      XGraphics xgraphics9 = PDFFunctions.gfx[SAPInput.k];
      XFont xfont18 = xfont3;
      XSolidBrush white2 = XBrushes.White;
      double num22 = (double) checked (SAPInput.RC1 + 1);
      xunit2 = PDFFunctions.pages[SAPInput.k].Width;
      double point9 = ((XUnit) ref xunit2).Point;
      xunit2 = PDFFunctions.pages[SAPInput.k].Height;
      double num23 = ((XUnit) ref xunit2).Point / 2.0;
      XRect xrect9 = new XRect(25.0, num22, point9, num23);
      XStringFormat topLeft9 = XStringFormat.TopLeft;
      xgraphics9.DrawString("Thermal bridges:", xfont18, (XBrush) white2, xrect9, topLeft9);
      SAPInput.RC1 = checked ((int) Math.Round(unchecked ((double) PDFFunctions.Points[3].Y + 4.0)));
      SAPInput.CheckRC1();
      if (SAP_Module.Proj.Dwellings[House].Thermal.ManualHtb)
      {
        XGraphics xgraphics10 = PDFFunctions.gfx[SAPInput.k];
        XFont xfont19 = xfont2;
        XSolidBrush black8 = XBrushes.Black;
        double rc1_7 = (double) SAPInput.RC1;
        xunit2 = PDFFunctions.pages[SAPInput.k].Width;
        double point10 = ((XUnit) ref xunit2).Point;
        xunit2 = PDFFunctions.pages[SAPInput.k].Height;
        double num24 = ((XUnit) ref xunit2).Point / 2.0;
        XRect xrect10 = new XRect(20.0, rc1_7, point10, num24);
        XStringFormat topLeft10 = XStringFormat.TopLeft;
        xgraphics10.DrawString("Thermal bridges:", xfont19, (XBrush) black8, xrect10, topLeft10);
        XGraphics xgraphics11 = PDFFunctions.gfx[SAPInput.k];
        XFont xfont20 = xfont3;
        XSolidBrush black9 = XBrushes.Black;
        double rc1_8 = (double) SAPInput.RC1;
        xunit2 = PDFFunctions.pages[SAPInput.k].Width;
        double point11 = ((XUnit) ref xunit2).Point;
        xunit2 = PDFFunctions.pages[SAPInput.k].Height;
        double num25 = ((XUnit) ref xunit2).Point / 2.0;
        XRect xrect11 = new XRect(260.0, rc1_8, point11, num25);
        XStringFormat topLeft11 = XStringFormat.TopLeft;
        xgraphics11.DrawString("User-defined = UD", xfont20, (XBrush) black9, xrect11, topLeft11);
        checked { SAPInput.RC1 += 12; }
        XGraphics xgraphics12 = PDFFunctions.gfx[SAPInput.k];
        XFont xfont21 = xfont3;
        XSolidBrush black10 = XBrushes.Black;
        double rc1_9 = (double) SAPInput.RC1;
        xunit2 = PDFFunctions.pages[SAPInput.k].Width;
        double point12 = ((XUnit) ref xunit2).Point;
        xunit2 = PDFFunctions.pages[SAPInput.k].Height;
        double num26 = ((XUnit) ref xunit2).Point / 2.0;
        XRect xrect12 = new XRect(260.0, rc1_9, point12, num26);
        XStringFormat topLeft12 = XStringFormat.TopLeft;
        xgraphics12.DrawString("Default  = D  ", xfont21, (XBrush) black10, xrect12, topLeft12);
        checked { SAPInput.RC1 += 12; }
        XGraphics xgraphics13 = PDFFunctions.gfx[SAPInput.k];
        XFont xfont22 = xfont3;
        XSolidBrush black11 = XBrushes.Black;
        double rc1_10 = (double) SAPInput.RC1;
        xunit2 = PDFFunctions.pages[SAPInput.k].Width;
        double point13 = ((XUnit) ref xunit2).Point;
        xunit2 = PDFFunctions.pages[SAPInput.k].Height;
        double num27 = ((XUnit) ref xunit2).Point / 2.0;
        XRect xrect13 = new XRect(260.0, rc1_10, point13, num27);
        XStringFormat topLeft13 = XStringFormat.TopLeft;
        xgraphics13.DrawString("Approved = A ", xfont22, (XBrush) black11, xrect13, topLeft13);
        checked { SAPInput.RC1 += 12; }
        try
        {
          XGraphics xgraphics14 = PDFFunctions.gfx[SAPInput.k];
          string str4 = "User-defined (individual PSI-values) Y-Value =  " + Conversions.ToString(SAPInput.ShowY());
          XFont xfont23 = xfont3;
          XSolidBrush black12 = XBrushes.Black;
          double rc1_11 = (double) SAPInput.RC1;
          xunit2 = PDFFunctions.pages[SAPInput.k].Width;
          double point14 = ((XUnit) ref xunit2).Point;
          xunit2 = PDFFunctions.pages[SAPInput.k].Height;
          double num28 = ((XUnit) ref xunit2).Point / 2.0;
          XRect xrect14 = new XRect(260.0, rc1_11, point14, num28);
          XStringFormat topLeft14 = XStringFormat.TopLeft;
          xgraphics14.DrawString(str4, xfont23, (XBrush) black12, xrect14, topLeft14);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        checked { SAPInput.RC1 += 20; }
        PDFFunctions.xBrush1 = XBrush.op_Implicit((Brush) new SolidBrush(Color.FromArgb(159, 172, 62)));
        PDFFunctions.Points[0].X = 20f;
        PDFFunctions.Points[0].Y = (float) SAPInput.RC1;
        ref PointF local5 = ref PDFFunctions.Points[1];
        XUnit width2 = PDFFunctions.pages[SAPInput.k].Width;
        double num29 = ((XUnit) ref width2).Point - 20.0;
        local5.X = (float) num29;
        PDFFunctions.Points[1].Y = (float) SAPInput.RC1;
        ref PointF local6 = ref PDFFunctions.Points[2];
        XUnit width3 = PDFFunctions.pages[SAPInput.k].Width;
        double num30 = ((XUnit) ref width3).Point - 20.0;
        local6.X = (float) num30;
        PDFFunctions.Points[2].Y = (float) checked (SAPInput.RC1 + 14);
        PDFFunctions.Points[3].X = 20f;
        PDFFunctions.Points[3].Y = (float) checked (SAPInput.RC1 + 14);
        PDFFunctions.gfx[SAPInput.k].DrawPolygon(PDFFunctions.polyGreen2, PDFFunctions.xBrush1, PDFFunctions.Points, xfillMode);
        PDFFunctions.Points[3].Y = (float) checked (SAPInput.RC1 + 14);
        PDFFunctions.gfx[SAPInput.k].DrawPolygon(PDFFunctions.polyGreen2, PDFFunctions.xBrush1, PDFFunctions.Points, xfillMode);
        XGraphics xgraphics15 = PDFFunctions.gfx[SAPInput.k];
        XFont xfont24 = xfont2;
        XSolidBrush white3 = XBrushes.White;
        double rc1_12 = (double) SAPInput.RC1;
        XUnit width4 = PDFFunctions.pages[SAPInput.k].Width;
        double point15 = ((XUnit) ref width4).Point;
        XUnit height1 = PDFFunctions.pages[SAPInput.k].Height;
        double num31 = ((XUnit) ref height1).Point / 2.0;
        XRect xrect15 = new XRect(20.0, rc1_12, point15, num31);
        XStringFormat topLeft15 = XStringFormat.TopLeft;
        xgraphics15.DrawString("External Junctions Details:", xfont24, (XBrush) white3, xrect15, topLeft15);
        SAPInput.RC1 = checked ((int) Math.Round(unchecked ((double) PDFFunctions.Points[3].Y + 4.0)));
        checked { SAPInput.RC1 += 16; }
        XGraphics xgraphics16 = PDFFunctions.gfx[SAPInput.k];
        XFont arialFont10Bold1 = PDFFunctions.ArialFont10Bold;
        XSolidBrush black13 = XBrushes.Black;
        double rc1_13 = (double) SAPInput.RC1;
        XUnit width5 = PDFFunctions.pages[SAPInput.k].Width;
        double point16 = ((XUnit) ref width5).Point;
        XUnit height2 = PDFFunctions.pages[SAPInput.k].Height;
        double num32 = ((XUnit) ref height2).Point / 2.0;
        XRect xrect16 = new XRect(20.0, rc1_13, point16, num32);
        XStringFormat topLeft16 = XStringFormat.TopLeft;
        xgraphics16.DrawString("Junction Type", arialFont10Bold1, (XBrush) black13, xrect16, topLeft16);
        XGraphics xgraphics17 = PDFFunctions.gfx[SAPInput.k];
        XFont arialFont10Bold2 = PDFFunctions.ArialFont10Bold;
        XSolidBrush black14 = XBrushes.Black;
        double rc1_14 = (double) SAPInput.RC1;
        xunit2 = PDFFunctions.pages[SAPInput.k].Width;
        double point17 = ((XUnit) ref xunit2).Point;
        xunit2 = PDFFunctions.pages[SAPInput.k].Height;
        double num33 = ((XUnit) ref xunit2).Point / 2.0;
        XRect xrect17 = new XRect(280.0, rc1_14, point17, num33);
        XStringFormat topLeft17 = XStringFormat.TopLeft;
        xgraphics17.DrawString("PSI-Value", arialFont10Bold2, (XBrush) black14, xrect17, topLeft17);
        XGraphics xgraphics18 = PDFFunctions.gfx[SAPInput.k];
        XFont arialFont10Bold3 = PDFFunctions.ArialFont10Bold;
        XSolidBrush black15 = XBrushes.Black;
        double rc1_15 = (double) SAPInput.RC1;
        xunit2 = PDFFunctions.pages[SAPInput.k].Width;
        double point18 = ((XUnit) ref xunit2).Point;
        xunit2 = PDFFunctions.pages[SAPInput.k].Height;
        double num34 = ((XUnit) ref xunit2).Point / 2.0;
        XRect xrect18 = new XRect(360.0, rc1_15, point18, num34);
        XStringFormat topLeft18 = XStringFormat.TopLeft;
        xgraphics18.DrawString("Length", arialFont10Bold3, (XBrush) black15, xrect18, topLeft18);
        XGraphics xgraphics19 = PDFFunctions.gfx[SAPInput.k];
        XFont arialFont10Bold4 = PDFFunctions.ArialFont10Bold;
        XSolidBrush black16 = XBrushes.Black;
        double rc1_16 = (double) SAPInput.RC1;
        xunit2 = PDFFunctions.pages[SAPInput.k].Width;
        double point19 = ((XUnit) ref xunit2).Point;
        xunit2 = PDFFunctions.pages[SAPInput.k].Height;
        double num35 = ((XUnit) ref xunit2).Point / 2.0;
        XRect xrect19 = new XRect(420.0, rc1_16, point19, num35);
        XStringFormat topLeft19 = XStringFormat.TopLeft;
        xgraphics19.DrawString("Reference", arialFont10Bold4, (XBrush) black16, xrect19, topLeft19);
        XGraphics xgraphics20 = PDFFunctions.gfx[SAPInput.k];
        XFont arialFont10Bold5 = PDFFunctions.ArialFont10Bold;
        XSolidBrush black17 = XBrushes.Black;
        double rc1_17 = (double) SAPInput.RC1;
        xunit2 = PDFFunctions.pages[SAPInput.k].Width;
        double point20 = ((XUnit) ref xunit2).Point;
        xunit2 = PDFFunctions.pages[SAPInput.k].Height;
        double num36 = ((XUnit) ref xunit2).Point / 2.0;
        XRect xrect20 = new XRect(500.0, rc1_17, point20, num36);
        XStringFormat topLeft20 = XStringFormat.TopLeft;
        xgraphics20.DrawString("Type", arialFont10Bold5, (XBrush) black17, xrect20, topLeft20);
        checked { SAPInput.RC1 += 12; }
        if (SAP_Module.Proj.Dwellings[House].Thermal.ExternalJunctions != null)
        {
          if (SAP_Module.Proj.Dwellings[House].Thermal.ExternalJunctions.Count > 0)
          {
            try
            {
              int num37 = checked (SAP_Module.Proj.Dwellings[House].Thermal.ExternalJunctions.Count - 1);
              int index1 = 0;
              while (index1 <= num37)
              {
                XGraphics xgraphics21 = PDFFunctions.gfx[SAPInput.k];
                string str5 = Conversions.ToString(SAP_Module.Proj.Dwellings[House].Thermal.ExternalJunctions[index1].ThermalTransmittance);
                XFont xfont25 = xfont3;
                XSolidBrush black18 = XBrushes.Black;
                double rc1_18 = (double) SAPInput.RC1;
                xunit2 = PDFFunctions.pages[SAPInput.k].Width;
                double point21 = ((XUnit) ref xunit2).Point;
                xunit2 = PDFFunctions.pages[SAPInput.k].Height;
                double num38 = ((XUnit) ref xunit2).Point / 2.0;
                XRect xrect21 = new XRect(280.0, rc1_18, point21, num38);
                XStringFormat topLeft21 = XStringFormat.TopLeft;
                xgraphics21.DrawString(str5, xfont25, (XBrush) black18, xrect21, topLeft21);
                XGraphics xgraphics22 = PDFFunctions.gfx[SAPInput.k];
                string str6 = Conversions.ToString(SAP_Module.Proj.Dwellings[House].Thermal.ExternalJunctions[index1].Length);
                XFont xfont26 = xfont3;
                XSolidBrush black19 = XBrushes.Black;
                double rc1_19 = (double) SAPInput.RC1;
                xunit2 = PDFFunctions.pages[SAPInput.k].Width;
                double point22 = ((XUnit) ref xunit2).Point;
                xunit2 = PDFFunctions.pages[SAPInput.k].Height;
                double num39 = ((XUnit) ref xunit2).Point / 2.0;
                XRect xrect22 = new XRect(370.0, rc1_19, point22, num39);
                XStringFormat topLeft22 = XStringFormat.TopLeft;
                xgraphics22.DrawString(str6, xfont26, (XBrush) black19, xrect22, topLeft22);
                XGraphics xgraphics23 = PDFFunctions.gfx[SAPInput.k];
                string str7 = SAP_Module.Proj.Dwellings[House].Thermal.ExternalJunctions[index1].Ref;
                XFont xfont27 = xfont3;
                XSolidBrush black20 = XBrushes.Black;
                double rc1_20 = (double) SAPInput.RC1;
                xunit2 = PDFFunctions.pages[SAPInput.k].Width;
                double point23 = ((XUnit) ref xunit2).Point;
                xunit2 = PDFFunctions.pages[SAPInput.k].Height;
                double num40 = ((XUnit) ref xunit2).Point / 2.0;
                XRect xrect23 = new XRect(430.0, rc1_20, point23, num40);
                XStringFormat topLeft23 = XStringFormat.TopLeft;
                xgraphics23.DrawString(str7, xfont27, (XBrush) black20, xrect23, topLeft23);
                if (SAP_Module.Proj.Dwellings[House].Thermal.ExternalJunctions[index1].IsDefault)
                {
                  XGraphics xgraphics24 = PDFFunctions.gfx[SAPInput.k];
                  XFont xfont28 = xfont3;
                  XSolidBrush black21 = XBrushes.Black;
                  double rc1_21 = (double) SAPInput.RC1;
                  xunit2 = PDFFunctions.pages[SAPInput.k].Width;
                  double point24 = ((XUnit) ref xunit2).Point;
                  xunit2 = PDFFunctions.pages[SAPInput.k].Height;
                  double num41 = ((XUnit) ref xunit2).Point / 2.0;
                  XRect xrect24 = new XRect(510.0, rc1_21, point24, num41);
                  XStringFormat topLeft24 = XStringFormat.TopLeft;
                  xgraphics24.DrawString("[D]", xfont28, (XBrush) black21, xrect24, topLeft24);
                }
                if (SAP_Module.Proj.Dwellings[House].Thermal.ExternalJunctions[index1].IsAccredited)
                {
                  XGraphics xgraphics25 = PDFFunctions.gfx[SAPInput.k];
                  XFont xfont29 = xfont3;
                  XSolidBrush black22 = XBrushes.Black;
                  double rc1_22 = (double) SAPInput.RC1;
                  xunit2 = PDFFunctions.pages[SAPInput.k].Width;
                  double point25 = ((XUnit) ref xunit2).Point;
                  xunit2 = PDFFunctions.pages[SAPInput.k].Height;
                  double num42 = ((XUnit) ref xunit2).Point / 2.0;
                  XRect xrect25 = new XRect(510.0, rc1_22, point25, num42);
                  XStringFormat topLeft25 = XStringFormat.TopLeft;
                  xgraphics25.DrawString("[A]", xfont29, (XBrush) black22, xrect25, topLeft25);
                }
                if (!SAP_Module.Proj.Dwellings[House].Thermal.ExternalJunctions[index1].IsDefault & !SAP_Module.Proj.Dwellings[House].Thermal.ExternalJunctions[index1].IsAccredited)
                {
                  XGraphics xgraphics26 = PDFFunctions.gfx[SAPInput.k];
                  XFont xfont30 = xfont3;
                  XSolidBrush black23 = XBrushes.Black;
                  double rc1_23 = (double) SAPInput.RC1;
                  xunit2 = PDFFunctions.pages[SAPInput.k].Width;
                  double point26 = ((XUnit) ref xunit2).Point;
                  xunit2 = PDFFunctions.pages[SAPInput.k].Height;
                  double num43 = ((XUnit) ref xunit2).Point / 2.0;
                  XRect xrect26 = new XRect(510.0, rc1_23, point26, num43);
                  XStringFormat topLeft26 = XStringFormat.TopLeft;
                  xgraphics26.DrawString("[UD]", xfont30, (XBrush) black23, xrect26, topLeft26);
                }
                try
                {
                  string[] strArray = SAPInput.CheckTextWidth2(SAP_Module.Proj.Dwellings[House].Thermal.ExternalJunctions[index1].JunctionDetail, 400);
                  if (strArray != null)
                  {
                    if (strArray[0].Length == 0)
                      strArray[0] = SAP_Module.Proj.Dwellings[House].Thermal.ExternalJunctions[index1].Ref;
                    int num44 = checked (strArray.Length - 1);
                    int index2 = 0;
                    while (index2 <= num44)
                    {
                      if ((uint) Operators.CompareString(strArray[index2], "", false) > 0U)
                      {
                        XGraphics xgraphics27 = PDFFunctions.gfx[SAPInput.k];
                        string str8 = strArray[index2];
                        XFont xfont31 = xfont3;
                        XSolidBrush black24 = XBrushes.Black;
                        double rc1_24 = (double) SAPInput.RC1;
                        xunit2 = PDFFunctions.pages[SAPInput.k].Width;
                        double point27 = ((XUnit) ref xunit2).Point;
                        xunit2 = PDFFunctions.pages[SAPInput.k].Height;
                        double num45 = ((XUnit) ref xunit2).Point / 2.0;
                        XRect xrect27 = new XRect(20.0, rc1_24, point27, num45);
                        XStringFormat topLeft27 = XStringFormat.TopLeft;
                        xgraphics27.DrawString(str8, xfont31, (XBrush) black24, xrect27, topLeft27);
                        checked { SAPInput.RC1 += 12; }
                        SAPInput.CheckRC1();
                      }
                      checked { ++index2; }
                    }
                  }
                }
                catch (Exception ex)
                {
                  ProjectData.SetProjectError(ex);
                  ProjectData.ClearProjectError();
                }
                checked { ++index1; }
              }
            }
            catch (Exception ex)
            {
              ProjectData.SetProjectError(ex);
              ProjectData.ClearProjectError();
            }
          }
        }
        checked { SAPInput.RC1 += 20; }
        if (SAP_Module.Proj.Dwellings[House].Thermal.PartyJunctions != null && SAP_Module.Proj.Dwellings[House].Thermal.PartyJunctions.Count > 0)
        {
          PDFFunctions.xBrush1 = XBrush.op_Implicit((Brush) new SolidBrush(Color.FromArgb(159, 172, 62)));
          PDFFunctions.Points[0].X = 20f;
          PDFFunctions.Points[0].Y = (float) SAPInput.RC1;
          ref PointF local7 = ref PDFFunctions.Points[1];
          xunit2 = PDFFunctions.pages[SAPInput.k].Width;
          double num46 = ((XUnit) ref xunit2).Point - 20.0;
          local7.X = (float) num46;
          PDFFunctions.Points[1].Y = (float) SAPInput.RC1;
          ref PointF local8 = ref PDFFunctions.Points[2];
          xunit2 = PDFFunctions.pages[SAPInput.k].Width;
          double num47 = ((XUnit) ref xunit2).Point - 20.0;
          local8.X = (float) num47;
          PDFFunctions.Points[2].Y = (float) checked (SAPInput.RC1 + 14);
          PDFFunctions.Points[3].X = 20f;
          PDFFunctions.Points[3].Y = (float) checked (SAPInput.RC1 + 14);
          PDFFunctions.gfx[SAPInput.k].DrawPolygon(PDFFunctions.polyGreen2, PDFFunctions.xBrush1, PDFFunctions.Points, xfillMode);
          PDFFunctions.Points[3].Y = (float) checked (SAPInput.RC1 + 14);
          PDFFunctions.gfx[SAPInput.k].DrawPolygon(PDFFunctions.polyGreen2, PDFFunctions.xBrush1, PDFFunctions.Points, xfillMode);
          XGraphics xgraphics28 = PDFFunctions.gfx[SAPInput.k];
          XFont xfont32 = xfont2;
          XSolidBrush white4 = XBrushes.White;
          double rc1_25 = (double) SAPInput.RC1;
          xunit2 = PDFFunctions.pages[SAPInput.k].Width;
          double point28 = ((XUnit) ref xunit2).Point;
          xunit2 = PDFFunctions.pages[SAPInput.k].Height;
          double num48 = ((XUnit) ref xunit2).Point / 2.0;
          XRect xrect28 = new XRect(20.0, rc1_25, point28, num48);
          XStringFormat topLeft28 = XStringFormat.TopLeft;
          xgraphics28.DrawString("Party Junctions Details:", xfont32, (XBrush) white4, xrect28, topLeft28);
          SAPInput.RC1 = checked ((int) Math.Round(unchecked ((double) PDFFunctions.Points[3].Y + 4.0)));
          if (SAP_Module.Proj.Dwellings[House].Thermal.PartyJunctions.Count > 0)
          {
            try
            {
              int num49 = checked (SAP_Module.Proj.Dwellings[House].Thermal.PartyJunctions.Count - 1);
              int index3 = 0;
              while (index3 <= num49)
              {
                XGraphics xgraphics29 = PDFFunctions.gfx[SAPInput.k];
                string str9 = Conversions.ToString(SAP_Module.Proj.Dwellings[House].Thermal.PartyJunctions[index3].ThermalTransmittance);
                XFont xfont33 = xfont3;
                XSolidBrush black25 = XBrushes.Black;
                double rc1_26 = (double) SAPInput.RC1;
                xunit2 = PDFFunctions.pages[SAPInput.k].Width;
                double point29 = ((XUnit) ref xunit2).Point;
                xunit2 = PDFFunctions.pages[SAPInput.k].Height;
                double num50 = ((XUnit) ref xunit2).Point / 2.0;
                XRect xrect29 = new XRect(280.0, rc1_26, point29, num50);
                XStringFormat topLeft29 = XStringFormat.TopLeft;
                xgraphics29.DrawString(str9, xfont33, (XBrush) black25, xrect29, topLeft29);
                XGraphics xgraphics30 = PDFFunctions.gfx[SAPInput.k];
                string str10 = Conversions.ToString(SAP_Module.Proj.Dwellings[House].Thermal.PartyJunctions[index3].Length);
                XFont xfont34 = xfont3;
                XSolidBrush black26 = XBrushes.Black;
                double rc1_27 = (double) SAPInput.RC1;
                xunit2 = PDFFunctions.pages[SAPInput.k].Width;
                double point30 = ((XUnit) ref xunit2).Point;
                xunit2 = PDFFunctions.pages[SAPInput.k].Height;
                double num51 = ((XUnit) ref xunit2).Point / 2.0;
                XRect xrect30 = new XRect(370.0, rc1_27, point30, num51);
                XStringFormat topLeft30 = XStringFormat.TopLeft;
                xgraphics30.DrawString(str10, xfont34, (XBrush) black26, xrect30, topLeft30);
                XGraphics xgraphics31 = PDFFunctions.gfx[SAPInput.k];
                string str11 = SAP_Module.Proj.Dwellings[House].Thermal.PartyJunctions[index3].Ref;
                XFont xfont35 = xfont3;
                XSolidBrush black27 = XBrushes.Black;
                double rc1_28 = (double) SAPInput.RC1;
                xunit2 = PDFFunctions.pages[SAPInput.k].Width;
                double point31 = ((XUnit) ref xunit2).Point;
                xunit2 = PDFFunctions.pages[SAPInput.k].Height;
                double num52 = ((XUnit) ref xunit2).Point / 2.0;
                XRect xrect31 = new XRect(430.0, rc1_28, point31, num52);
                XStringFormat topLeft31 = XStringFormat.TopLeft;
                xgraphics31.DrawString(str11, xfont35, (XBrush) black27, xrect31, topLeft31);
                if (SAP_Module.Proj.Dwellings[House].Thermal.PartyJunctions[index3].IsDefault)
                {
                  XGraphics xgraphics32 = PDFFunctions.gfx[SAPInput.k];
                  XFont xfont36 = xfont3;
                  XSolidBrush black28 = XBrushes.Black;
                  double rc1_29 = (double) SAPInput.RC1;
                  xunit2 = PDFFunctions.pages[SAPInput.k].Width;
                  double point32 = ((XUnit) ref xunit2).Point;
                  xunit2 = PDFFunctions.pages[SAPInput.k].Height;
                  double num53 = ((XUnit) ref xunit2).Point / 2.0;
                  XRect xrect32 = new XRect(510.0, rc1_29, point32, num53);
                  XStringFormat topLeft32 = XStringFormat.TopLeft;
                  xgraphics32.DrawString("[D]", xfont36, (XBrush) black28, xrect32, topLeft32);
                }
                if (SAP_Module.Proj.Dwellings[House].Thermal.PartyJunctions[index3].IsAccredited)
                {
                  XGraphics xgraphics33 = PDFFunctions.gfx[SAPInput.k];
                  XFont xfont37 = xfont3;
                  XSolidBrush black29 = XBrushes.Black;
                  double rc1_30 = (double) SAPInput.RC1;
                  xunit2 = PDFFunctions.pages[SAPInput.k].Width;
                  double point33 = ((XUnit) ref xunit2).Point;
                  xunit2 = PDFFunctions.pages[SAPInput.k].Height;
                  double num54 = ((XUnit) ref xunit2).Point / 2.0;
                  XRect xrect33 = new XRect(510.0, rc1_30, point33, num54);
                  XStringFormat topLeft33 = XStringFormat.TopLeft;
                  xgraphics33.DrawString("[A]", xfont37, (XBrush) black29, xrect33, topLeft33);
                }
                if (!SAP_Module.Proj.Dwellings[House].Thermal.PartyJunctions[index3].IsDefault & !SAP_Module.Proj.Dwellings[House].Thermal.PartyJunctions[index3].IsAccredited)
                {
                  XGraphics xgraphics34 = PDFFunctions.gfx[SAPInput.k];
                  XFont xfont38 = xfont3;
                  XSolidBrush black30 = XBrushes.Black;
                  double rc1_31 = (double) SAPInput.RC1;
                  xunit2 = PDFFunctions.pages[SAPInput.k].Width;
                  double point34 = ((XUnit) ref xunit2).Point;
                  xunit2 = PDFFunctions.pages[SAPInput.k].Height;
                  double num55 = ((XUnit) ref xunit2).Point / 2.0;
                  XRect xrect34 = new XRect(510.0, rc1_31, point34, num55);
                  XStringFormat topLeft34 = XStringFormat.TopLeft;
                  xgraphics34.DrawString("[UD]", xfont38, (XBrush) black30, xrect34, topLeft34);
                }
                try
                {
                  string[] strArray = SAPInput.CheckTextWidth2(SAP_Module.Proj.Dwellings[House].Thermal.PartyJunctions[index3].JunctionDetail, 400);
                  if (strArray != null)
                  {
                    if (strArray[0].Length == 0)
                      strArray[0] = SAP_Module.Proj.Dwellings[House].Thermal.PartyJunctions[index3].Ref;
                    int num56 = checked (strArray.Length - 1);
                    int index4 = 0;
                    while (index4 <= num56)
                    {
                      if ((uint) Operators.CompareString(strArray[index4], "", false) > 0U)
                      {
                        XGraphics xgraphics35 = PDFFunctions.gfx[SAPInput.k];
                        string str12 = strArray[index4];
                        XFont xfont39 = xfont3;
                        XSolidBrush black31 = XBrushes.Black;
                        double rc1_32 = (double) SAPInput.RC1;
                        xunit2 = PDFFunctions.pages[SAPInput.k].Width;
                        double point35 = ((XUnit) ref xunit2).Point;
                        xunit2 = PDFFunctions.pages[SAPInput.k].Height;
                        double num57 = ((XUnit) ref xunit2).Point / 2.0;
                        XRect xrect35 = new XRect(20.0, rc1_32, point35, num57);
                        XStringFormat topLeft35 = XStringFormat.TopLeft;
                        xgraphics35.DrawString(str12, xfont39, (XBrush) black31, xrect35, topLeft35);
                        checked { SAPInput.RC1 += 12; }
                        SAPInput.CheckRC1();
                      }
                      checked { ++index4; }
                    }
                  }
                }
                catch (Exception ex)
                {
                  ProjectData.SetProjectError(ex);
                  ProjectData.ClearProjectError();
                }
                checked { ++index3; }
              }
            }
            catch (Exception ex)
            {
              ProjectData.SetProjectError(ex);
              ProjectData.ClearProjectError();
            }
          }
        }
        checked { SAPInput.RC1 += 20; }
        if (SAP_Module.Proj.Dwellings[House].Thermal.RoofJunctions != null && SAP_Module.Proj.Dwellings[House].Thermal.RoofJunctions.Count > 0)
        {
          PDFFunctions.xBrush1 = XBrush.op_Implicit((Brush) new SolidBrush(Color.FromArgb(159, 172, 62)));
          PDFFunctions.Points[0].X = 20f;
          PDFFunctions.Points[0].Y = (float) SAPInput.RC1;
          ref PointF local9 = ref PDFFunctions.Points[1];
          xunit2 = PDFFunctions.pages[SAPInput.k].Width;
          double num58 = ((XUnit) ref xunit2).Point - 20.0;
          local9.X = (float) num58;
          PDFFunctions.Points[1].Y = (float) SAPInput.RC1;
          ref PointF local10 = ref PDFFunctions.Points[2];
          xunit2 = PDFFunctions.pages[SAPInput.k].Width;
          double num59 = ((XUnit) ref xunit2).Point - 20.0;
          local10.X = (float) num59;
          PDFFunctions.Points[2].Y = (float) checked (SAPInput.RC1 + 14);
          PDFFunctions.Points[3].X = 20f;
          PDFFunctions.Points[3].Y = (float) checked (SAPInput.RC1 + 14);
          PDFFunctions.gfx[SAPInput.k].DrawPolygon(PDFFunctions.polyGreen2, PDFFunctions.xBrush1, PDFFunctions.Points, xfillMode);
          PDFFunctions.Points[3].Y = (float) checked (SAPInput.RC1 + 14);
          PDFFunctions.gfx[SAPInput.k].DrawPolygon(PDFFunctions.polyGreen2, PDFFunctions.xBrush1, PDFFunctions.Points, xfillMode);
          XGraphics xgraphics36 = PDFFunctions.gfx[SAPInput.k];
          XFont xfont40 = xfont2;
          XSolidBrush white5 = XBrushes.White;
          double rc1_33 = (double) SAPInput.RC1;
          xunit2 = PDFFunctions.pages[SAPInput.k].Width;
          double point36 = ((XUnit) ref xunit2).Point;
          xunit2 = PDFFunctions.pages[SAPInput.k].Height;
          double num60 = ((XUnit) ref xunit2).Point / 2.0;
          XRect xrect36 = new XRect(20.0, rc1_33, point36, num60);
          XStringFormat topLeft36 = XStringFormat.TopLeft;
          xgraphics36.DrawString("Roof Junctions Details:", xfont40, (XBrush) white5, xrect36, topLeft36);
          SAPInput.RC1 = checked ((int) Math.Round(unchecked ((double) PDFFunctions.Points[3].Y + 4.0)));
          try
          {
            int num61 = checked (SAP_Module.Proj.Dwellings[House].Thermal.RoofJunctions.Count - 1);
            int index5 = 0;
            while (index5 <= num61)
            {
              XGraphics xgraphics37 = PDFFunctions.gfx[SAPInput.k];
              string str13 = Conversions.ToString(SAP_Module.Proj.Dwellings[House].Thermal.RoofJunctions[index5].ThermalTransmittance);
              XFont xfont41 = xfont3;
              XSolidBrush black32 = XBrushes.Black;
              double rc1_34 = (double) SAPInput.RC1;
              xunit2 = PDFFunctions.pages[SAPInput.k].Width;
              double point37 = ((XUnit) ref xunit2).Point;
              xunit2 = PDFFunctions.pages[SAPInput.k].Height;
              double num62 = ((XUnit) ref xunit2).Point / 2.0;
              XRect xrect37 = new XRect(280.0, rc1_34, point37, num62);
              XStringFormat topLeft37 = XStringFormat.TopLeft;
              xgraphics37.DrawString(str13, xfont41, (XBrush) black32, xrect37, topLeft37);
              XGraphics xgraphics38 = PDFFunctions.gfx[SAPInput.k];
              string str14 = Conversions.ToString(SAP_Module.Proj.Dwellings[House].Thermal.RoofJunctions[index5].Length);
              XFont xfont42 = xfont3;
              XSolidBrush black33 = XBrushes.Black;
              double rc1_35 = (double) SAPInput.RC1;
              xunit2 = PDFFunctions.pages[SAPInput.k].Width;
              double point38 = ((XUnit) ref xunit2).Point;
              xunit2 = PDFFunctions.pages[SAPInput.k].Height;
              double num63 = ((XUnit) ref xunit2).Point / 2.0;
              XRect xrect38 = new XRect(370.0, rc1_35, point38, num63);
              XStringFormat topLeft38 = XStringFormat.TopLeft;
              xgraphics38.DrawString(str14, xfont42, (XBrush) black33, xrect38, topLeft38);
              XGraphics xgraphics39 = PDFFunctions.gfx[SAPInput.k];
              string str15 = SAP_Module.Proj.Dwellings[House].Thermal.RoofJunctions[index5].Ref;
              XFont xfont43 = xfont3;
              XSolidBrush black34 = XBrushes.Black;
              double rc1_36 = (double) SAPInput.RC1;
              xunit2 = PDFFunctions.pages[SAPInput.k].Width;
              double point39 = ((XUnit) ref xunit2).Point;
              xunit2 = PDFFunctions.pages[SAPInput.k].Height;
              double num64 = ((XUnit) ref xunit2).Point / 2.0;
              XRect xrect39 = new XRect(430.0, rc1_36, point39, num64);
              XStringFormat topLeft39 = XStringFormat.TopLeft;
              xgraphics39.DrawString(str15, xfont43, (XBrush) black34, xrect39, topLeft39);
              if (SAP_Module.Proj.Dwellings[House].Thermal.RoofJunctions[index5].IsDefault)
              {
                XGraphics xgraphics40 = PDFFunctions.gfx[SAPInput.k];
                XFont xfont44 = xfont3;
                XSolidBrush black35 = XBrushes.Black;
                double rc1_37 = (double) SAPInput.RC1;
                xunit2 = PDFFunctions.pages[SAPInput.k].Width;
                double point40 = ((XUnit) ref xunit2).Point;
                xunit2 = PDFFunctions.pages[SAPInput.k].Height;
                double num65 = ((XUnit) ref xunit2).Point / 2.0;
                XRect xrect40 = new XRect(510.0, rc1_37, point40, num65);
                XStringFormat topLeft40 = XStringFormat.TopLeft;
                xgraphics40.DrawString("[D]", xfont44, (XBrush) black35, xrect40, topLeft40);
              }
              if (SAP_Module.Proj.Dwellings[House].Thermal.RoofJunctions[index5].IsAccredited)
              {
                XGraphics xgraphics41 = PDFFunctions.gfx[SAPInput.k];
                XFont xfont45 = xfont3;
                XSolidBrush black36 = XBrushes.Black;
                double rc1_38 = (double) SAPInput.RC1;
                xunit2 = PDFFunctions.pages[SAPInput.k].Width;
                double point41 = ((XUnit) ref xunit2).Point;
                xunit2 = PDFFunctions.pages[SAPInput.k].Height;
                double num66 = ((XUnit) ref xunit2).Point / 2.0;
                XRect xrect41 = new XRect(510.0, rc1_38, point41, num66);
                XStringFormat topLeft41 = XStringFormat.TopLeft;
                xgraphics41.DrawString("[A]", xfont45, (XBrush) black36, xrect41, topLeft41);
              }
              if (!SAP_Module.Proj.Dwellings[House].Thermal.RoofJunctions[index5].IsDefault & !SAP_Module.Proj.Dwellings[House].Thermal.RoofJunctions[index5].IsAccredited)
              {
                XGraphics xgraphics42 = PDFFunctions.gfx[SAPInput.k];
                XFont xfont46 = xfont3;
                XSolidBrush black37 = XBrushes.Black;
                double rc1_39 = (double) SAPInput.RC1;
                xunit2 = PDFFunctions.pages[SAPInput.k].Width;
                double point42 = ((XUnit) ref xunit2).Point;
                xunit2 = PDFFunctions.pages[SAPInput.k].Height;
                double num67 = ((XUnit) ref xunit2).Point / 2.0;
                XRect xrect42 = new XRect(510.0, rc1_39, point42, num67);
                XStringFormat topLeft42 = XStringFormat.TopLeft;
                xgraphics42.DrawString("[UD]", xfont46, (XBrush) black37, xrect42, topLeft42);
              }
              try
              {
                string[] strArray = SAPInput.CheckTextWidth2(SAP_Module.Proj.Dwellings[House].Thermal.RoofJunctions[index5].JunctionDetail, 400);
                if (strArray != null)
                {
                  if (strArray[0].Length == 0)
                    strArray[0] = SAP_Module.Proj.Dwellings[House].Thermal.RoofJunctions[index5].Ref;
                  int num68 = checked (strArray.Length - 1);
                  int index6 = 0;
                  while (index6 <= num68)
                  {
                    if ((uint) Operators.CompareString(strArray[index6], "", false) > 0U)
                    {
                      XGraphics xgraphics43 = PDFFunctions.gfx[SAPInput.k];
                      string str16 = strArray[index6];
                      XFont xfont47 = xfont3;
                      XSolidBrush black38 = XBrushes.Black;
                      double rc1_40 = (double) SAPInput.RC1;
                      xunit2 = PDFFunctions.pages[SAPInput.k].Width;
                      double point43 = ((XUnit) ref xunit2).Point;
                      xunit2 = PDFFunctions.pages[SAPInput.k].Height;
                      double num69 = ((XUnit) ref xunit2).Point / 2.0;
                      XRect xrect43 = new XRect(20.0, rc1_40, point43, num69);
                      XStringFormat topLeft43 = XStringFormat.TopLeft;
                      xgraphics43.DrawString(str16, xfont47, (XBrush) black38, xrect43, topLeft43);
                      checked { SAPInput.RC1 += 12; }
                      SAPInput.CheckRC1();
                    }
                    checked { ++index6; }
                  }
                }
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
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
      }
      else if (SAP_Module.Proj.Dwellings[House].Thermal.ManualY)
      {
        XGraphics xgraphics44 = PDFFunctions.gfx[SAPInput.k];
        XFont xfont48 = xfont2;
        XSolidBrush black39 = XBrushes.Black;
        double rc1_41 = (double) SAPInput.RC1;
        xunit2 = PDFFunctions.pages[SAPInput.k].Width;
        double point44 = ((XUnit) ref xunit2).Point;
        xunit2 = PDFFunctions.pages[SAPInput.k].Height;
        double num70 = ((XUnit) ref xunit2).Point / 2.0;
        XRect xrect44 = new XRect(20.0, rc1_41, point44, num70);
        XStringFormat topLeft44 = XStringFormat.TopLeft;
        xgraphics44.DrawString("Thermal bridges:", xfont48, (XBrush) black39, xrect44, topLeft44);
        XGraphics xgraphics45 = PDFFunctions.gfx[SAPInput.k];
        XFont xfont49 = xfont3;
        XSolidBrush black40 = XBrushes.Black;
        double rc1_42 = (double) SAPInput.RC1;
        xunit2 = PDFFunctions.pages[SAPInput.k].Width;
        double point45 = ((XUnit) ref xunit2).Point;
        xunit2 = PDFFunctions.pages[SAPInput.k].Height;
        double num71 = ((XUnit) ref xunit2).Point / 2.0;
        XRect xrect45 = new XRect(200.0, rc1_42, point45, num71);
        XStringFormat topLeft45 = XStringFormat.TopLeft;
        xgraphics45.DrawString("User-defined y-value", xfont49, (XBrush) black40, xrect45, topLeft45);
        checked { SAPInput.RC1 += 12; }
        XGraphics xgraphics46 = PDFFunctions.gfx[SAPInput.k];
        string str17 = "y =" + Conversions.ToString(SAP_Module.Proj.Dwellings[House].Thermal.YValue);
        XFont xfont50 = xfont3;
        XSolidBrush black41 = XBrushes.Black;
        double rc1_43 = (double) SAPInput.RC1;
        xunit2 = PDFFunctions.pages[SAPInput.k].Width;
        double point46 = ((XUnit) ref xunit2).Point;
        xunit2 = PDFFunctions.pages[SAPInput.k].Height;
        double num72 = ((XUnit) ref xunit2).Point / 2.0;
        XRect xrect46 = new XRect(200.0, rc1_43, point46, num72);
        XStringFormat topLeft46 = XStringFormat.TopLeft;
        xgraphics46.DrawString(str17, xfont50, (XBrush) black41, xrect46, topLeft46);
        checked { SAPInput.RC1 += 12; }
        XGraphics xgraphics47 = PDFFunctions.gfx[SAPInput.k];
        string str18 = "Reference: " + SAP_Module.Proj.Dwellings[House].Thermal.Reference;
        XFont xfont51 = xfont3;
        XSolidBrush black42 = XBrushes.Black;
        double rc1_44 = (double) SAPInput.RC1;
        xunit2 = PDFFunctions.pages[SAPInput.k].Width;
        double point47 = ((XUnit) ref xunit2).Point;
        xunit2 = PDFFunctions.pages[SAPInput.k].Height;
        double num73 = ((XUnit) ref xunit2).Point / 2.0;
        XRect xrect47 = new XRect(200.0, rc1_44, point47, num73);
        XStringFormat topLeft47 = XStringFormat.TopLeft;
        xgraphics47.DrawString(str18, xfont51, (XBrush) black42, xrect47, topLeft47);
        checked { SAPInput.RC1 += 12; }
      }
      else
      {
        SAPInput.CheckRC1();
        string str19 = SAP_Module.Proj.Dwellings[House].Thermal.ConstDetails;
        if (Operators.CompareString(SAP_Module.Proj.Dwellings[House].Thermal.ConstDetails, "All detailing conforms with Accredited Construction Details", false) == 0)
          str19 = "Accredited Construction Details";
        XGraphics xgraphics48 = PDFFunctions.gfx[SAPInput.k];
        XFont xfont52 = xfont2;
        XSolidBrush black43 = XBrushes.Black;
        double rc1_45 = (double) SAPInput.RC1;
        xunit2 = PDFFunctions.pages[SAPInput.k].Width;
        double point48 = ((XUnit) ref xunit2).Point;
        xunit2 = PDFFunctions.pages[SAPInput.k].Height;
        double num74 = ((XUnit) ref xunit2).Point / 2.0;
        XRect xrect48 = new XRect(20.0, rc1_45, point48, num74);
        XStringFormat topLeft48 = XStringFormat.TopLeft;
        xgraphics48.DrawString("Thermal bridges:", xfont52, (XBrush) black43, xrect48, topLeft48);
        XGraphics xgraphics49 = PDFFunctions.gfx[SAPInput.k];
        string str20 = str19 + " (y =" + Conversions.ToString(SAP_Module.Proj.Dwellings[House].Thermal.YValue) + ")";
        XFont xfont53 = xfont3;
        XSolidBrush black44 = XBrushes.Black;
        double rc1_46 = (double) SAPInput.RC1;
        xunit2 = PDFFunctions.pages[SAPInput.k].Width;
        double point49 = ((XUnit) ref xunit2).Point;
        xunit2 = PDFFunctions.pages[SAPInput.k].Height;
        double num75 = ((XUnit) ref xunit2).Point / 2.0;
        XRect xrect49 = new XRect(200.0, rc1_46, point49, num75);
        XStringFormat topLeft49 = XStringFormat.TopLeft;
        xgraphics49.DrawString(str20, xfont53, (XBrush) black44, xrect49, topLeft49);
      }
      checked { SAPInput.RC1 += 14; }
      SAPInput.CheckRC1();
      string str21 = Conversions.ToString(checked (SAPInput.k + 1));
      SAPInput.CheckRC1();
      XFont xfont54 = new XFont("Arial", 160.0, (XFontStyle) 1);
      PDFFunctions.transbrush = XBrush.op_Implicit((Brush) new SolidBrush(Color.FromArgb(128, Color.Olive)));
      int k = SAPInput.k;
      int index = 0;
      while (index <= k)
      {
        if (!Validation.UserLogged)
        {
          XGraphics xgraphics50 = PDFFunctions.gfx[index];
          XFont xfont55 = xfont54;
          XBrush transbrush = PDFFunctions.transbrush;
          xunit2 = PDFFunctions.pages[SAPInput.k].Width;
          double point50 = ((XUnit) ref xunit2).Point;
          xunit2 = PDFFunctions.pages[SAPInput.k].Height;
          double point51 = ((XUnit) ref xunit2).Point;
          XRect xrect50 = new XRect(0.0, 0.0, point50, point51);
          XStringFormat center = XStringFormat.Center;
          xgraphics50.DrawString("DRAFT", xfont55, transbrush, xrect50, center);
        }
        if (!SAP_Module.Proj.OverRide)
        {
          XGraphics xgraphics51 = PDFFunctions.gfx[index];
          string str22 = "Stroma FSAP 2012 " + SAP_Module.CurrVersion + " (SAP 9.92) - http://www.stroma.com";
          XFont xfont56 = xfont9;
          XSolidBrush black45 = XBrushes.Black;
          xunit2 = PDFFunctions.pages[SAPInput.k].Width;
          double point52 = ((XUnit) ref xunit2).Point;
          xunit2 = PDFFunctions.pages[SAPInput.k].Height;
          double point53 = ((XUnit) ref xunit2).Point;
          XRect xrect51 = new XRect(20.0, 820.0, point52, point53);
          XStringFormat topLeft50 = XStringFormat.TopLeft;
          xgraphics51.DrawString(str22, xfont56, (XBrush) black45, xrect51, topLeft50);
        }
        else
        {
          XGraphics xgraphics52 = PDFFunctions.gfx[index];
          string str23 = "Stroma FSAP 2012 " + SAP_Module.Proj.CalcVersion + " (SAP 9.92) - http://www.stroma.com";
          XFont xfont57 = xfont9;
          XSolidBrush black46 = XBrushes.Black;
          xunit2 = PDFFunctions.pages[SAPInput.k].Width;
          double point54 = ((XUnit) ref xunit2).Point;
          xunit2 = PDFFunctions.pages[SAPInput.k].Height;
          double point55 = ((XUnit) ref xunit2).Point;
          XRect xrect52 = new XRect(20.0, 820.0, point54, point55);
          XStringFormat topLeft51 = XStringFormat.TopLeft;
          xgraphics52.DrawString(str23, xfont57, (XBrush) black46, xrect52, topLeft51);
        }
        XGraphics xgraphics53 = PDFFunctions.gfx[index];
        string str24 = "Page " + Conversions.ToString(checked (index + 1)) + " of " + str21;
        XFont xfont58 = xfont9;
        XSolidBrush black47 = XBrushes.Black;
        xunit2 = PDFFunctions.pages[index].Width;
        double point56 = ((XUnit) ref xunit2).Point;
        xunit2 = PDFFunctions.pages[index].Height;
        double point57 = ((XUnit) ref xunit2).Point;
        XRect xrect53 = new XRect(520.0, 820.0, point56, point57);
        XStringFormat topLeft52 = XStringFormat.TopLeft;
        xgraphics53.DrawString(str24, xfont58, (XBrush) black47, xrect53, topLeft52);
        checked { ++index; }
      }
      SAP_Module.PDFFileName = "";
      object folderPath = (object) Environment.GetFolderPath(Environment.SpecialFolder.Personal);
      DirectoryInfo directoryInfo1 = new DirectoryInfo(Conversions.ToString(Operators.ConcatenateObject(folderPath, (object) "\\Stroma SAP 2012")));
      DirectoryInfo directoryInfo2 = new DirectoryInfo(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(folderPath, (object) "\\Stroma SAP 2012\\"), (object) SAP_Module.Proj.Name)));
      DirectoryInfo directoryInfo3 = new DirectoryInfo(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(folderPath, (object) "\\Stroma SAP 2012\\"), (object) SAP_Module.Proj.Name), (object) "\\"), (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Name)));
      if (!PDFFunctions.Draft_PDF)
      {
        stream = (Stream) new MemoryStream();
        PDFFunctions.document.Save(stream, false);
      }
      else
      {
        SAP_Module.ThermalBridge = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(folderPath, (object) "\\Stroma SAP 2012\\"), (object) SAP_Module.Proj.Name), (object) "\\"), (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Name), (object) "\\"), (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Name), (object) "-ThermalBridge"), (object) ".pdf"));
        PDFFunctions.document.Save(SAP_Module.ThermalBridge);
      }
      return stream;
    }

    private static void CheckRC1()
    {
      if (SAPInput.RC1 < 770)
        return;
      SAPInput.CreateNewPage();
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
      checked { ++SAPInput.k; }
      PDFFunctions.pages[SAPInput.k] = PDFFunctions.document.AddPage();
      PDFFunctions.gfx[SAPInput.k] = XGraphics.FromPdfPage(PDFFunctions.pages[SAPInput.k]);
      XSize xsize = PDFFunctions.gfx[SAPInput.k].PageSize;
      double num1 = ((XSize) ref xsize).Width / 2.0;
      xsize = PDFFunctions.gfx[SAPInput.k].MeasureString("SAP Input", PDFFunctions.ArialFont16Bold);
      double num2 = ((XSize) ref xsize).Width / 2.0;
      int num3 = checked ((int) Math.Round(unchecked (num1 - num2)));
      XGraphics xgraphics = PDFFunctions.gfx[SAPInput.k];
      XFont arialFont16Bold = PDFFunctions.ArialFont16Bold;
      XSolidBrush black = XBrushes.Black;
      double num4 = (double) num3;
      XUnit xunit = PDFFunctions.pages[SAPInput.k].Width;
      double point = ((XUnit) ref xunit).Point;
      xunit = PDFFunctions.pages[SAPInput.k].Height;
      double num5 = ((XUnit) ref xunit).Point / 2.0;
      XRect xrect = new XRect(num4, 30.0, point, num5);
      XStringFormat topLeft = XStringFormat.TopLeft;
      xgraphics.DrawString("SAP Input", arialFont16Bold, (XBrush) black, xrect, topLeft);
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
          num8 = checked ((int) Math.Round((double) SAPInput.ImageY));
          num9 = checked ((int) Math.Round(unchecked ((double) checked (image.Height * 100) / (double) image.Width)));
        }
        else
        {
          num8 = checked ((int) Math.Round((double) SAPInput.ImageY));
          num9 = 60;
          num6 = checked ((int) Math.Round(unchecked (575.0 - (double) image.Width / (double) image.Height * 60.0)));
          num7 = checked ((int) Math.Round(unchecked ((double) image.Width / (double) image.Height * 60.0)));
        }
        PDFFunctions.gfx[SAPInput.k].DrawImage(XImage.op_Implicit(image), num6, num8, num7, num9);
        image.Dispose();
      }
      if (UserSettings.USettings.PrintUserSettings.Print)
        PDFFunctions.PrintUserDetails(PDFFunctions.gfx[SAPInput.k]);
      SAPInput.RC1 = 70;
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

    public static void CreateOverHeatingDoc(int House, int Country)
    {
      // ISSUE: variable of a compiler-generated type
      SAPInput._Closure\u0024__22\u002D0 closure220_1;
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      SAPInput._Closure\u0024__22\u002D0 closure220_2 = new SAPInput._Closure\u0024__22\u002D0(closure220_1);
      // ISSUE: reference to a compiler-generated field
      closure220_2.\u0024VB\u0024Local_House = House;
      XFont xfont1 = new XFont("Tahoma", 11.0, (XFontStyle) 4);
      XFont xfont2 = new XFont("Tahoma", 12.0, (XFontStyle) 1);
      XFont xfont3 = new XFont("Tahoma", 11.0, (XFontStyle) 0);
      XFont xfont4 = new XFont("Tahoma", 10.0, (XFontStyle) 0);
      XFont xfont5 = new XFont("Tahoma", 16.0, (XFontStyle) 1);
      XFont xfont6 = new XFont("Tahoma", 11.0, (XFontStyle) 1);
      XFont xfont7 = new XFont("Tahoma", 8.0, (XFontStyle) 1);
      XFont xfont8 = new XFont("Tahoma", 8.0, (XFontStyle) 2);
      XFont xfont9 = new XFont("Tahoma", 6.0, (XFontStyle) 0);
      XPen xpen1 = new XPen(XColor.FromArgb(0, 115, 187));
      XPen xpen2 = new XPen(XColor.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue));
      XPen xpen3 = new XPen(XColor.FromArgb(0, 0, (int) byte.MaxValue));
      SAPInput.k = 0;
      PDFFunctions.document = new PdfDocument();
      PDFFunctions.pages[SAPInput.k] = PDFFunctions.document.AddPage();
      PDFFunctions.gfx[SAPInput.k] = XGraphics.FromPdfPage(PDFFunctions.pages[SAPInput.k]);
      XSize xsize1 = PDFFunctions.gfx[SAPInput.k].PageSize;
      double num1 = ((XSize) ref xsize1).Width / 2.0;
      xsize1 = PDFFunctions.gfx[SAPInput.k].MeasureString("SAP 2012 Overheating Assessment", PDFFunctions.ArialFont16Bold);
      double num2 = ((XSize) ref xsize1).Width / 2.0;
      int num3 = checked ((int) Math.Round(unchecked (num1 - num2)));
      XGraphics xgraphics1 = PDFFunctions.gfx[SAPInput.k];
      XFont arialFont16Bold = PDFFunctions.ArialFont16Bold;
      XSolidBrush black1 = XBrushes.Black;
      double num4 = (double) num3;
      XUnit xunit1 = PDFFunctions.pages[SAPInput.k].Width;
      double point1 = ((XUnit) ref xunit1).Point;
      xunit1 = PDFFunctions.pages[SAPInput.k].Height;
      double num5 = ((XUnit) ref xunit1).Point / 2.0;
      XRect xrect1 = new XRect(num4, 30.0, point1, num5);
      XStringFormat topLeft1 = XStringFormat.TopLeft;
      xgraphics1.DrawString("SAP 2012 Overheating Assessment", arialFont16Bold, (XBrush) black1, xrect1, topLeft1);
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
          num8 = checked ((int) Math.Round((double) SAPInput.ImageY));
          num9 = checked ((int) Math.Round(unchecked ((double) checked (image.Height * 100) / (double) image.Width)));
        }
        else
        {
          num8 = checked ((int) Math.Round((double) SAPInput.ImageY));
          num9 = 60;
          num6 = checked ((int) Math.Round(unchecked (575.0 - (double) image.Width / (double) image.Height * 60.0)));
          num7 = checked ((int) Math.Round(unchecked ((double) image.Width / (double) image.Height * 60.0)));
        }
        PDFFunctions.gfx[SAPInput.k].DrawImage(XImage.op_Implicit(image), num6, num8, num7, num9);
        image.Dispose();
      }
      if (UserSettings.USettings.PrintUserSettings.Print)
        PDFFunctions.PrintUserDetails(PDFFunctions.gfx[SAPInput.k]);
      XSize pageSize = PDFFunctions.gfx[SAPInput.k].PageSize;
      double num10 = ((XSize) ref pageSize).Width / 2.0;
      XSize xsize2 = PDFFunctions.gfx[SAPInput.k].MeasureString("Calculated by Stroma FSAP 2012 program, produced and printed on " + DateAndTime.Now.ToLongDateString(), xfont8);
      double num11 = ((XSize) ref xsize2).Width / 2.0;
      int num12 = checked ((int) Math.Round(unchecked (num10 - num11)));
      XGraphics xgraphics2 = PDFFunctions.gfx[SAPInput.k];
      string str1 = "Calculated by Stroma FSAP 2012 program, produced and printed on " + DateAndTime.Now.ToLongDateString();
      XFont xfont10 = xfont8;
      XSolidBrush black2 = XBrushes.Black;
      double num13 = (double) num12;
      XUnit width1 = PDFFunctions.pages[SAPInput.k].Width;
      double point2 = ((XUnit) ref width1).Point;
      XUnit height1 = PDFFunctions.pages[SAPInput.k].Height;
      double num14 = ((XUnit) ref height1).Point / 2.0;
      XRect xrect2 = new XRect(num13, 50.0, point2, num14);
      XStringFormat topLeft2 = XStringFormat.TopLeft;
      xgraphics2.DrawString(str1, xfont10, (XBrush) black2, xrect2, topLeft2);
      SAPInput.RC1 = 70;
      PDFFunctions.xBrush1 = XBrush.op_Implicit((Brush) new SolidBrush(Color.FromArgb(159, 172, 62)));
      PDFFunctions.Points[0].X = 20f;
      PDFFunctions.Points[0].Y = (float) SAPInput.RC1;
      ref PointF local1 = ref PDFFunctions.Points[1];
      XUnit width2 = PDFFunctions.pages[SAPInput.k].Width;
      double num15 = ((XUnit) ref width2).Point - 20.0;
      local1.X = (float) num15;
      PDFFunctions.Points[1].Y = (float) SAPInput.RC1;
      ref PointF local2 = ref PDFFunctions.Points[2];
      XUnit width3 = PDFFunctions.pages[SAPInput.k].Width;
      double num16 = ((XUnit) ref width3).Point - 20.0;
      local2.X = (float) num16;
      PDFFunctions.Points[2].Y = (float) checked (SAPInput.RC1 + 14);
      PDFFunctions.Points[3].X = 20f;
      PDFFunctions.Points[3].Y = (float) checked (SAPInput.RC1 + 14);
      XFillMode xfillMode;
      PDFFunctions.gfx[SAPInput.k].DrawPolygon(PDFFunctions.polyGreen2, PDFFunctions.xBrush1, PDFFunctions.Points, xfillMode);
      XGraphics xgraphics3 = PDFFunctions.gfx[SAPInput.k];
      // ISSUE: reference to a compiler-generated field
      string str2 = "Property Details: " + SAP_Module.Proj.Dwellings[closure220_2.\u0024VB\u0024Local_House].Name;
      XFont xfont11 = xfont4;
      XSolidBrush white1 = XBrushes.White;
      double num17 = (double) checked (SAPInput.RC1 + 1);
      XUnit width4 = PDFFunctions.pages[SAPInput.k].Width;
      double point3 = ((XUnit) ref width4).Point;
      XUnit height2 = PDFFunctions.pages[SAPInput.k].Height;
      double num18 = ((XUnit) ref height2).Point / 2.0;
      XRect xrect3 = new XRect(25.0, num17, point3, num18);
      XStringFormat topLeft3 = XStringFormat.TopLeft;
      xgraphics3.DrawString(str2, xfont11, (XBrush) white1, xrect3, topLeft3);
      SAPInput.RC1 = checked ((int) Math.Round(unchecked ((double) PDFFunctions.Points[3].Y + 14.0)));
      XGraphics xgraphics4 = PDFFunctions.gfx[SAPInput.k];
      XFont arialFont10Bold1 = PDFFunctions.ArialFont10Bold;
      XSolidBrush black3 = XBrushes.Black;
      double rc1_1 = (double) SAPInput.RC1;
      XUnit width5 = PDFFunctions.pages[SAPInput.k].Width;
      double point4 = ((XUnit) ref width5).Point;
      XUnit xunit2 = PDFFunctions.pages[SAPInput.k].Height;
      double num19 = ((XUnit) ref xunit2).Point / 2.0;
      XRect xrect4 = new XRect(20.0, rc1_1, point4, num19);
      XStringFormat topLeft4 = XStringFormat.TopLeft;
      xgraphics4.DrawString("Dwelling type:", arialFont10Bold1, (XBrush) black3, xrect4, topLeft4);
      XGraphics xgraphics5 = PDFFunctions.gfx[SAPInput.k];
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      string str3 = SAP_Module.Proj.Dwellings[closure220_2.\u0024VB\u0024Local_House].BuildForm + " " + SAP_Module.Proj.Dwellings[closure220_2.\u0024VB\u0024Local_House].PropertyType;
      XFont xfont12 = xfont4;
      XSolidBrush black4 = XBrushes.Black;
      double rc1_2 = (double) SAPInput.RC1;
      xunit2 = PDFFunctions.pages[SAPInput.k].Width;
      double point5 = ((XUnit) ref xunit2).Point;
      xunit2 = PDFFunctions.pages[SAPInput.k].Height;
      double num20 = ((XUnit) ref xunit2).Point / 2.0;
      XRect xrect5 = new XRect(275.0, rc1_2, point5, num20);
      XStringFormat topLeft5 = XStringFormat.TopLeft;
      xgraphics5.DrawString(str3, xfont12, (XBrush) black4, xrect5, topLeft5);
      checked { SAPInput.RC1 += 12; }
      XGraphics xgraphics6 = PDFFunctions.gfx[SAPInput.k];
      XFont arialFont10Bold2 = PDFFunctions.ArialFont10Bold;
      XSolidBrush black5 = XBrushes.Black;
      double rc1_3 = (double) SAPInput.RC1;
      xunit2 = PDFFunctions.pages[SAPInput.k].Width;
      double point6 = ((XUnit) ref xunit2).Point;
      xunit2 = PDFFunctions.pages[SAPInput.k].Height;
      double num21 = ((XUnit) ref xunit2).Point / 2.0;
      XRect xrect6 = new XRect(20.0, rc1_3, point6, num21);
      XStringFormat topLeft6 = XStringFormat.TopLeft;
      xgraphics6.DrawString("Located in:", arialFont10Bold2, (XBrush) black5, xrect6, topLeft6);
      XGraphics xgraphics7 = PDFFunctions.gfx[SAPInput.k];
      // ISSUE: reference to a compiler-generated field
      string country = SAP_Module.Proj.Dwellings[closure220_2.\u0024VB\u0024Local_House].Address.Country;
      XFont xfont13 = xfont4;
      XSolidBrush black6 = XBrushes.Black;
      double rc1_4 = (double) SAPInput.RC1;
      xunit2 = PDFFunctions.pages[SAPInput.k].Width;
      double point7 = ((XUnit) ref xunit2).Point;
      xunit2 = PDFFunctions.pages[SAPInput.k].Height;
      double num22 = ((XUnit) ref xunit2).Point / 2.0;
      XRect xrect7 = new XRect(275.0, rc1_4, point7, num22);
      XStringFormat topLeft7 = XStringFormat.TopLeft;
      xgraphics7.DrawString(country, xfont13, (XBrush) black6, xrect7, topLeft7);
      checked { SAPInput.RC1 += 12; }
      XGraphics xgraphics8 = PDFFunctions.gfx[SAPInput.k];
      XFont arialFont10Bold3 = PDFFunctions.ArialFont10Bold;
      XSolidBrush black7 = XBrushes.Black;
      double rc1_5 = (double) SAPInput.RC1;
      xunit2 = PDFFunctions.pages[SAPInput.k].Width;
      double point8 = ((XUnit) ref xunit2).Point;
      xunit2 = PDFFunctions.pages[SAPInput.k].Height;
      double num23 = ((XUnit) ref xunit2).Point / 2.0;
      XRect xrect8 = new XRect(20.0, rc1_5, point8, num23);
      XStringFormat topLeft8 = XStringFormat.TopLeft;
      xgraphics8.DrawString("Region:", arialFont10Bold3, (XBrush) black7, xrect8, topLeft8);
      XGraphics xgraphics9 = PDFFunctions.gfx[SAPInput.k];
      // ISSUE: reference to a compiler-generated field
      string location = SAP_Module.Proj.Dwellings[closure220_2.\u0024VB\u0024Local_House].Location;
      XFont xfont14 = xfont4;
      XSolidBrush black8 = XBrushes.Black;
      double rc1_6 = (double) SAPInput.RC1;
      xunit2 = PDFFunctions.pages[SAPInput.k].Width;
      double point9 = ((XUnit) ref xunit2).Point;
      xunit2 = PDFFunctions.pages[SAPInput.k].Height;
      double num24 = ((XUnit) ref xunit2).Point / 2.0;
      XRect xrect9 = new XRect(275.0, rc1_6, point9, num24);
      XStringFormat topLeft9 = XStringFormat.TopLeft;
      xgraphics9.DrawString(location, xfont14, (XBrush) black8, xrect9, topLeft9);
      checked { SAPInput.RC1 += 12; }
      string eacBuildType = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].OverHeating.EACBuildType;
      if (Operators.CompareString(eacBuildType, "Single storey dwelling (bungalow, flat) Cross ventilation possible", false) == 0 || Operators.CompareString(eacBuildType, "Dwelling of two or more storeys windows open upstairs and downstairs Cross ventilation possible", false) == 0)
      {
        XGraphics xgraphics10 = PDFFunctions.gfx[SAPInput.k];
        XFont arialFont10Bold4 = PDFFunctions.ArialFont10Bold;
        XSolidBrush black9 = XBrushes.Black;
        double rc1_7 = (double) SAPInput.RC1;
        xunit2 = PDFFunctions.pages[SAPInput.k].Width;
        double point10 = ((XUnit) ref xunit2).Point;
        xunit2 = PDFFunctions.pages[SAPInput.k].Height;
        double num25 = ((XUnit) ref xunit2).Point / 2.0;
        XRect xrect10 = new XRect(20.0, rc1_7, point10, num25);
        XStringFormat topLeft10 = XStringFormat.TopLeft;
        xgraphics10.DrawString("Cross ventilation possible:", arialFont10Bold4, (XBrush) black9, xrect10, topLeft10);
        XGraphics xgraphics11 = PDFFunctions.gfx[SAPInput.k];
        XFont xfont15 = xfont4;
        XSolidBrush black10 = XBrushes.Black;
        double rc1_8 = (double) SAPInput.RC1;
        xunit2 = PDFFunctions.pages[SAPInput.k].Width;
        double point11 = ((XUnit) ref xunit2).Point;
        xunit2 = PDFFunctions.pages[SAPInput.k].Height;
        double num26 = ((XUnit) ref xunit2).Point / 2.0;
        XRect xrect11 = new XRect(275.0, rc1_8, point11, num26);
        XStringFormat topLeft11 = XStringFormat.TopLeft;
        xgraphics11.DrawString("Yes", xfont15, (XBrush) black10, xrect11, topLeft11);
        checked { SAPInput.RC1 += 12; }
      }
      else
      {
        XGraphics xgraphics12 = PDFFunctions.gfx[SAPInput.k];
        XFont arialFont10Bold5 = PDFFunctions.ArialFont10Bold;
        XSolidBrush black11 = XBrushes.Black;
        double rc1_9 = (double) SAPInput.RC1;
        xunit2 = PDFFunctions.pages[SAPInput.k].Width;
        double point12 = ((XUnit) ref xunit2).Point;
        xunit2 = PDFFunctions.pages[SAPInput.k].Height;
        double num27 = ((XUnit) ref xunit2).Point / 2.0;
        XRect xrect12 = new XRect(20.0, rc1_9, point12, num27);
        XStringFormat topLeft12 = XStringFormat.TopLeft;
        xgraphics12.DrawString("Cross ventilation possible:", arialFont10Bold5, (XBrush) black11, xrect12, topLeft12);
        XGraphics xgraphics13 = PDFFunctions.gfx[SAPInput.k];
        XFont xfont16 = xfont4;
        XSolidBrush black12 = XBrushes.Black;
        double rc1_10 = (double) SAPInput.RC1;
        xunit2 = PDFFunctions.pages[SAPInput.k].Width;
        double point13 = ((XUnit) ref xunit2).Point;
        xunit2 = PDFFunctions.pages[SAPInput.k].Height;
        double num28 = ((XUnit) ref xunit2).Point / 2.0;
        XRect xrect13 = new XRect(275.0, rc1_10, point13, num28);
        XStringFormat topLeft13 = XStringFormat.TopLeft;
        xgraphics13.DrawString("No", xfont16, (XBrush) black12, xrect13, topLeft13);
        checked { SAPInput.RC1 += 12; }
      }
      XGraphics xgraphics14 = PDFFunctions.gfx[SAPInput.k];
      XFont arialFont10Bold6 = PDFFunctions.ArialFont10Bold;
      XSolidBrush black13 = XBrushes.Black;
      double rc1_11 = (double) SAPInput.RC1;
      xunit2 = PDFFunctions.pages[SAPInput.k].Width;
      double point14 = ((XUnit) ref xunit2).Point;
      xunit2 = PDFFunctions.pages[SAPInput.k].Height;
      double num29 = ((XUnit) ref xunit2).Point / 2.0;
      XRect xrect14 = new XRect(20.0, rc1_11, point14, num29);
      XStringFormat topLeft14 = XStringFormat.TopLeft;
      xgraphics14.DrawString("Number of storeys:", arialFont10Bold6, (XBrush) black13, xrect14, topLeft14);
      XGraphics xgraphics15 = PDFFunctions.gfx[SAPInput.k];
      // ISSUE: reference to a compiler-generated field
      string str4 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure220_2.\u0024VB\u0024Local_House].Storeys);
      XFont xfont17 = xfont4;
      XSolidBrush black14 = XBrushes.Black;
      double rc1_12 = (double) SAPInput.RC1;
      xunit2 = PDFFunctions.pages[SAPInput.k].Width;
      double point15 = ((XUnit) ref xunit2).Point;
      xunit2 = PDFFunctions.pages[SAPInput.k].Height;
      double num30 = ((XUnit) ref xunit2).Point / 2.0;
      XRect xrect15 = new XRect(275.0, rc1_12, point15, num30);
      XStringFormat topLeft15 = XStringFormat.TopLeft;
      xgraphics15.DrawString(str4, xfont17, (XBrush) black14, xrect15, topLeft15);
      checked { SAPInput.RC1 += 12; }
      XGraphics xgraphics16 = PDFFunctions.gfx[SAPInput.k];
      XFont arialFont10Bold7 = PDFFunctions.ArialFont10Bold;
      XSolidBrush black15 = XBrushes.Black;
      double rc1_13 = (double) SAPInput.RC1;
      xunit2 = PDFFunctions.pages[SAPInput.k].Width;
      double point16 = ((XUnit) ref xunit2).Point;
      xunit2 = PDFFunctions.pages[SAPInput.k].Height;
      double num31 = ((XUnit) ref xunit2).Point / 2.0;
      XRect xrect16 = new XRect(20.0, rc1_13, point16, num31);
      XStringFormat topLeft16 = XStringFormat.TopLeft;
      xgraphics16.DrawString("Front of dwelling faces:", arialFont10Bold7, (XBrush) black15, xrect16, topLeft16);
      XGraphics xgraphics17 = PDFFunctions.gfx[SAPInput.k];
      // ISSUE: reference to a compiler-generated field
      string orientation = SAP_Module.Proj.Dwellings[closure220_2.\u0024VB\u0024Local_House].Orientation;
      XFont xfont18 = xfont4;
      XSolidBrush black16 = XBrushes.Black;
      double rc1_14 = (double) SAPInput.RC1;
      xunit2 = PDFFunctions.pages[SAPInput.k].Width;
      double point17 = ((XUnit) ref xunit2).Point;
      xunit2 = PDFFunctions.pages[SAPInput.k].Height;
      double num32 = ((XUnit) ref xunit2).Point / 2.0;
      XRect xrect17 = new XRect(275.0, rc1_14, point17, num32);
      XStringFormat topLeft17 = XStringFormat.TopLeft;
      xgraphics17.DrawString(orientation, xfont18, (XBrush) black16, xrect17, topLeft17);
      checked { SAPInput.RC1 += 12; }
      XGraphics xgraphics18 = PDFFunctions.gfx[SAPInput.k];
      XFont arialFont10Bold8 = PDFFunctions.ArialFont10Bold;
      XSolidBrush black17 = XBrushes.Black;
      double rc1_15 = (double) SAPInput.RC1;
      xunit2 = PDFFunctions.pages[SAPInput.k].Width;
      double point18 = ((XUnit) ref xunit2).Point;
      xunit2 = PDFFunctions.pages[SAPInput.k].Height;
      double num33 = ((XUnit) ref xunit2).Point / 2.0;
      XRect xrect18 = new XRect(20.0, rc1_15, point18, num33);
      XStringFormat topLeft18 = XStringFormat.TopLeft;
      xgraphics18.DrawString("Overshading:", arialFont10Bold8, (XBrush) black17, xrect18, topLeft18);
      XGraphics xgraphics19 = PDFFunctions.gfx[SAPInput.k];
      // ISSUE: reference to a compiler-generated field
      string overshading = SAP_Module.Proj.Dwellings[closure220_2.\u0024VB\u0024Local_House].Overshading;
      XFont xfont19 = xfont4;
      XSolidBrush black18 = XBrushes.Black;
      double rc1_16 = (double) SAPInput.RC1;
      xunit2 = PDFFunctions.pages[SAPInput.k].Width;
      double point19 = ((XUnit) ref xunit2).Point;
      xunit2 = PDFFunctions.pages[SAPInput.k].Height;
      double num34 = ((XUnit) ref xunit2).Point / 2.0;
      XRect xrect19 = new XRect(275.0, rc1_16, point19, num34);
      XStringFormat topLeft19 = XStringFormat.TopLeft;
      xgraphics19.DrawString(overshading, xfont19, (XBrush) black18, xrect19, topLeft19);
      checked { SAPInput.RC1 += 12; }
      XGraphics xgraphics20 = PDFFunctions.gfx[SAPInput.k];
      XFont arialFont10Bold9 = PDFFunctions.ArialFont10Bold;
      XSolidBrush black19 = XBrushes.Black;
      double rc1_17 = (double) SAPInput.RC1;
      xunit2 = PDFFunctions.pages[SAPInput.k].Width;
      double point20 = ((XUnit) ref xunit2).Point;
      xunit2 = PDFFunctions.pages[SAPInput.k].Height;
      double num35 = ((XUnit) ref xunit2).Point / 2.0;
      XRect xrect20 = new XRect(20.0, rc1_17, point20, num35);
      XStringFormat topLeft20 = XStringFormat.TopLeft;
      xgraphics20.DrawString("Overhangs:", arialFont10Bold9, (XBrush) black19, xrect20, topLeft20);
      try
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        if ((double) SAP_Module.Proj.Dwellings[closure220_2.\u0024VB\u0024Local_House].Windows[0].OverhangDepth == 0.0 & (double) SAP_Module.Proj.Dwellings[closure220_2.\u0024VB\u0024Local_House].Windows[0].OverhangDepth == 0.0)
        {
          XGraphics xgraphics21 = PDFFunctions.gfx[SAPInput.k];
          XFont xfont20 = xfont4;
          XSolidBrush black20 = XBrushes.Black;
          double rc1_18 = (double) SAPInput.RC1;
          xunit2 = PDFFunctions.pages[SAPInput.k].Width;
          double point21 = ((XUnit) ref xunit2).Point;
          xunit2 = PDFFunctions.pages[SAPInput.k].Height;
          double num36 = ((XUnit) ref xunit2).Point / 2.0;
          XRect xrect21 = new XRect(275.0, rc1_18, point21, num36);
          XStringFormat topLeft21 = XStringFormat.TopLeft;
          xgraphics21.DrawString("None", xfont20, (XBrush) black20, xrect21, topLeft21);
          checked { SAPInput.RC1 += 12; }
        }
        else
        {
          XGraphics xgraphics22 = PDFFunctions.gfx[SAPInput.k];
          XFont xfont21 = xfont4;
          XSolidBrush black21 = XBrushes.Black;
          double rc1_19 = (double) SAPInput.RC1;
          xunit2 = PDFFunctions.pages[SAPInput.k].Width;
          double point22 = ((XUnit) ref xunit2).Point;
          xunit2 = PDFFunctions.pages[SAPInput.k].Height;
          double num37 = ((XUnit) ref xunit2).Point / 2.0;
          XRect xrect22 = new XRect(275.0, rc1_19, point22, num37);
          XStringFormat topLeft22 = XStringFormat.TopLeft;
          xgraphics22.DrawString("as detailed below", xfont21, (XBrush) black21, xrect22, topLeft22);
          checked { SAPInput.RC1 += 12; }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      XGraphics xgraphics23 = PDFFunctions.gfx[SAPInput.k];
      XFont arialFont10Bold10 = PDFFunctions.ArialFont10Bold;
      XSolidBrush black22 = XBrushes.Black;
      double rc1_20 = (double) SAPInput.RC1;
      XUnit width6 = PDFFunctions.pages[SAPInput.k].Width;
      double point23 = ((XUnit) ref width6).Point;
      XUnit height3 = PDFFunctions.pages[SAPInput.k].Height;
      double num38 = ((XUnit) ref height3).Point / 2.0;
      XRect xrect23 = new XRect(20.0, rc1_20, point23, num38);
      XStringFormat topLeft23 = XStringFormat.TopLeft;
      xgraphics23.DrawString("Thermal mass parameter:", arialFont10Bold10, (XBrush) black22, xrect23, topLeft23);
      XUnit xunit3;
      // ISSUE: reference to a compiler-generated field
      if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure220_2.\u0024VB\u0024Local_House].TMP.Type, "User Value", false) == 0)
      {
        XGraphics xgraphics24 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string str5 = "User Value: " + Conversions.ToString(SAP_Module.Proj.Dwellings[closure220_2.\u0024VB\u0024Local_House].TMP.UserDefined) + "kJ/m\u00B2K";
        XFont xfont22 = xfont6;
        XSolidBrush black23 = XBrushes.Black;
        double rc1_21 = (double) SAPInput.RC1;
        XUnit width7 = PDFFunctions.pages[SAPInput.k].Width;
        double point24 = ((XUnit) ref width7).Point;
        xunit3 = PDFFunctions.pages[SAPInput.k].Height;
        double num39 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect24 = new XRect(275.0, rc1_21, point24, num39);
        XStringFormat topLeft24 = XStringFormat.TopLeft;
        xgraphics24.DrawString(str5, xfont22, (XBrush) black23, xrect24, topLeft24);
        checked { SAPInput.RC1 += 12; }
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure220_2.\u0024VB\u0024Local_House].TMP.Type, "Indicative Value", false) == 0)
        {
          XGraphics xgraphics25 = PDFFunctions.gfx[SAPInput.k];
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          string str6 = SAP_Module.Proj.Dwellings[closure220_2.\u0024VB\u0024Local_House].TMP.Type + " " + SAP_Module.Proj.Dwellings[closure220_2.\u0024VB\u0024Local_House].TMP.Indicative;
          XFont xfont23 = xfont4;
          XSolidBrush black24 = XBrushes.Black;
          double rc1_22 = (double) SAPInput.RC1;
          XUnit width8 = PDFFunctions.pages[SAPInput.k].Width;
          double point25 = ((XUnit) ref width8).Point;
          xunit3 = PDFFunctions.pages[SAPInput.k].Height;
          double num40 = ((XUnit) ref xunit3).Point / 2.0;
          XRect xrect25 = new XRect(275.0, rc1_22, point25, num40);
          XStringFormat topLeft25 = XStringFormat.TopLeft;
          xgraphics25.DrawString(str6, xfont23, (XBrush) black24, xrect25, topLeft25);
          checked { SAPInput.RC1 += 12; }
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          if (Operators.CompareString(SAP_Module.Proj.Dwellings[closure220_2.\u0024VB\u0024Local_House].TMP.Type, "Calculated", false) == 0)
          {
            XGraphics xgraphics26 = PDFFunctions.gfx[SAPInput.k];
            string str7 = "Calculated " + Conversions.ToString(Math.Round(SAP_Module.Calculation2012.Calculation.HeatLoss.Box35, 2));
            XFont xfont24 = xfont4;
            XSolidBrush black25 = XBrushes.Black;
            double rc1_23 = (double) SAPInput.RC1;
            XUnit width9 = PDFFunctions.pages[SAPInput.k].Width;
            double point26 = ((XUnit) ref width9).Point;
            XUnit height4 = PDFFunctions.pages[SAPInput.k].Height;
            double num41 = ((XUnit) ref height4).Point / 2.0;
            XRect xrect26 = new XRect(275.0, rc1_23, point26, num41);
            XStringFormat topLeft26 = XStringFormat.TopLeft;
            xgraphics26.DrawString(str7, xfont24, (XBrush) black25, xrect26, topLeft26);
            checked { SAPInput.RC1 += 12; }
          }
        }
      }
      XGraphics xgraphics27 = PDFFunctions.gfx[SAPInput.k];
      XFont arialFont10Bold11 = PDFFunctions.ArialFont10Bold;
      XSolidBrush black26 = XBrushes.Black;
      double rc1_24 = (double) SAPInput.RC1;
      xunit3 = PDFFunctions.pages[SAPInput.k].Width;
      double point27 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[SAPInput.k].Height;
      double num42 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect27 = new XRect(20.0, rc1_24, point27, num42);
      XStringFormat topLeft27 = XStringFormat.TopLeft;
      xgraphics27.DrawString("Night ventilation:", arialFont10Bold11, (XBrush) black26, xrect27, topLeft27);
      XGraphics xgraphics28 = PDFFunctions.gfx[SAPInput.k];
      // ISSUE: reference to a compiler-generated field
      string str8 = SAP_Module.Proj.Dwellings[closure220_2.\u0024VB\u0024Local_House].OverHeating.Night.ToString();
      XFont xfont25 = xfont4;
      XSolidBrush black27 = XBrushes.Black;
      double rc1_25 = (double) SAPInput.RC1;
      xunit3 = PDFFunctions.pages[SAPInput.k].Width;
      double point28 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[SAPInput.k].Height;
      double num43 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect28 = new XRect(275.0, rc1_25, point28, num43);
      XStringFormat topLeft28 = XStringFormat.TopLeft;
      xgraphics28.DrawString(str8, xfont25, (XBrush) black27, xrect28, topLeft28);
      checked { SAPInput.RC1 += 12; }
      XGraphics xgraphics29 = PDFFunctions.gfx[SAPInput.k];
      XFont arialFont10Bold12 = PDFFunctions.ArialFont10Bold;
      XSolidBrush black28 = XBrushes.Black;
      double rc1_26 = (double) SAPInput.RC1;
      xunit3 = PDFFunctions.pages[SAPInput.k].Width;
      double point29 = ((XUnit) ref xunit3).Point;
      xunit3 = PDFFunctions.pages[SAPInput.k].Height;
      double num44 = ((XUnit) ref xunit3).Point / 2.0;
      XRect xrect29 = new XRect(20.0, rc1_26, point29, num44);
      XStringFormat topLeft29 = XStringFormat.TopLeft;
      xgraphics29.DrawString("Blinds, curtains, shutters:", arialFont10Bold12, (XBrush) black28, xrect29, topLeft29);
      try
      {
        XGraphics xgraphics30 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        string curtainType = SAP_Module.Proj.Dwellings[closure220_2.\u0024VB\u0024Local_House].Windows[0].CurtainType;
        XFont xfont26 = xfont4;
        XSolidBrush black29 = XBrushes.Black;
        double rc1_27 = (double) SAPInput.RC1;
        xunit3 = PDFFunctions.pages[SAPInput.k].Width;
        double point30 = ((XUnit) ref xunit3).Point;
        xunit3 = PDFFunctions.pages[SAPInput.k].Height;
        double num45 = ((XUnit) ref xunit3).Point / 2.0;
        XRect xrect30 = new XRect(275.0, rc1_27, point30, num45);
        XStringFormat topLeft30 = XStringFormat.TopLeft;
        xgraphics30.DrawString(curtainType, xfont26, (XBrush) black29, xrect30, topLeft30);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      checked { SAPInput.RC1 += 12; }
      XGraphics xgraphics31 = PDFFunctions.gfx[SAPInput.k];
      XFont arialFont10Bold13 = PDFFunctions.ArialFont10Bold;
      XSolidBrush black30 = XBrushes.Black;
      double rc1_28 = (double) SAPInput.RC1;
      XUnit width10 = PDFFunctions.pages[SAPInput.k].Width;
      double point31 = ((XUnit) ref width10).Point;
      XUnit xunit4 = PDFFunctions.pages[SAPInput.k].Height;
      double num46 = ((XUnit) ref xunit4).Point / 2.0;
      XRect xrect31 = new XRect(20.0, rc1_28, point31, num46);
      XStringFormat topLeft31 = XStringFormat.TopLeft;
      xgraphics31.DrawString("Ventilation rate during hot weather (ach):", arialFont10Bold13, (XBrush) black30, xrect31, topLeft31);
      XGraphics xgraphics32 = PDFFunctions.gfx[SAPInput.k];
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      string str9 = Conversions.ToString(SAP_Module.Proj.Dwellings[closure220_2.\u0024VB\u0024Local_House].OverHeating.EACAirChange) + " ( " + SAP_Module.Proj.Dwellings[closure220_2.\u0024VB\u0024Local_House].OverHeating.EACWindow + ")";
      XFont xfont27 = xfont4;
      XSolidBrush black31 = XBrushes.Black;
      double rc1_29 = (double) SAPInput.RC1;
      xunit4 = PDFFunctions.pages[SAPInput.k].Width;
      double point32 = ((XUnit) ref xunit4).Point;
      xunit4 = PDFFunctions.pages[SAPInput.k].Height;
      double num47 = ((XUnit) ref xunit4).Point / 2.0;
      XRect xrect32 = new XRect(275.0, rc1_29, point32, num47);
      XStringFormat topLeft32 = XStringFormat.TopLeft;
      xgraphics32.DrawString(str9, xfont27, (XBrush) black31, xrect32, topLeft32);
      checked { SAPInput.RC1 += 15; }
      PDFFunctions.xBrush1 = XBrush.op_Implicit((Brush) new SolidBrush(Color.FromArgb(159, 172, 62)));
      PDFFunctions.Points[0].X = 20f;
      PDFFunctions.Points[0].Y = (float) SAPInput.RC1;
      ref PointF local3 = ref PDFFunctions.Points[1];
      xunit4 = PDFFunctions.pages[SAPInput.k].Width;
      double num48 = ((XUnit) ref xunit4).Point - 20.0;
      local3.X = (float) num48;
      PDFFunctions.Points[1].Y = (float) SAPInput.RC1;
      ref PointF local4 = ref PDFFunctions.Points[2];
      xunit4 = PDFFunctions.pages[SAPInput.k].Width;
      double num49 = ((XUnit) ref xunit4).Point - 20.0;
      local4.X = (float) num49;
      PDFFunctions.Points[2].Y = (float) checked (SAPInput.RC1 + 14);
      PDFFunctions.Points[3].X = 20f;
      PDFFunctions.Points[3].Y = (float) checked (SAPInput.RC1 + 14);
      PDFFunctions.gfx[SAPInput.k].DrawPolygon(PDFFunctions.polyGreen2, PDFFunctions.xBrush1, PDFFunctions.Points, xfillMode);
      XGraphics xgraphics33 = PDFFunctions.gfx[SAPInput.k];
      XFont xfont28 = xfont4;
      XSolidBrush white2 = XBrushes.White;
      double num50 = (double) checked (SAPInput.RC1 + 1);
      xunit4 = PDFFunctions.pages[SAPInput.k].Width;
      double point33 = ((XUnit) ref xunit4).Point;
      xunit4 = PDFFunctions.pages[SAPInput.k].Height;
      double num51 = ((XUnit) ref xunit4).Point / 2.0;
      XRect xrect33 = new XRect(25.0, num50, point33, num51);
      XStringFormat topLeft33 = XStringFormat.TopLeft;
      xgraphics33.DrawString("Overheating  Details:", xfont28, (XBrush) white2, xrect33, topLeft33);
      SAPInput.RC1 = checked ((int) Math.Round(unchecked ((double) PDFFunctions.Points[3].Y + 15.0)));
      XGraphics xgraphics34 = PDFFunctions.gfx[SAPInput.k];
      XFont arialFont10Bold14 = PDFFunctions.ArialFont10Bold;
      XSolidBrush black32 = XBrushes.Black;
      double rc1_30 = (double) SAPInput.RC1;
      xunit4 = PDFFunctions.pages[SAPInput.k].Width;
      double point34 = ((XUnit) ref xunit4).Point;
      xunit4 = PDFFunctions.pages[SAPInput.k].Height;
      double num52 = ((XUnit) ref xunit4).Point / 2.0;
      XRect xrect34 = new XRect(20.0, rc1_30, point34, num52);
      XStringFormat topLeft34 = XStringFormat.TopLeft;
      xgraphics34.DrawString("Summer ventilation heat loss coefficient:", arialFont10Bold14, (XBrush) black32, xrect34, topLeft34);
      XGraphics xgraphics35 = PDFFunctions.gfx[SAPInput.k];
      string str10 = Conversions.ToString(Math.Round(SAP_Module.OverHeat.AppendixP.P1, 2));
      XFont xfont29 = xfont4;
      XSolidBrush black33 = XBrushes.Black;
      double rc1_31 = (double) SAPInput.RC1;
      xunit4 = PDFFunctions.pages[SAPInput.k].Width;
      double point35 = ((XUnit) ref xunit4).Point;
      xunit4 = PDFFunctions.pages[SAPInput.k].Height;
      double num53 = ((XUnit) ref xunit4).Point / 2.0;
      XRect xrect35 = new XRect(275.0, rc1_31, point35, num53);
      XStringFormat topLeft35 = XStringFormat.TopLeft;
      xgraphics35.DrawString(str10, xfont29, (XBrush) black33, xrect35, topLeft35);
      XGraphics xgraphics36 = PDFFunctions.gfx[SAPInput.k];
      XFont arialFont10Bold15 = PDFFunctions.ArialFont10Bold;
      XSolidBrush black34 = XBrushes.Black;
      double rc1_32 = (double) SAPInput.RC1;
      xunit4 = PDFFunctions.pages[SAPInput.k].Width;
      double point36 = ((XUnit) ref xunit4).Point;
      xunit4 = PDFFunctions.pages[SAPInput.k].Height;
      double num54 = ((XUnit) ref xunit4).Point / 2.0;
      XRect xrect36 = new XRect(550.0, rc1_32, point36, num54);
      XStringFormat topLeft36 = XStringFormat.TopLeft;
      xgraphics36.DrawString("(P1)", arialFont10Bold15, (XBrush) black34, xrect36, topLeft36);
      checked { SAPInput.RC1 += 12; }
      XGraphics xgraphics37 = PDFFunctions.gfx[SAPInput.k];
      XFont arialFont10Bold16 = PDFFunctions.ArialFont10Bold;
      XSolidBrush black35 = XBrushes.Black;
      double rc1_33 = (double) SAPInput.RC1;
      xunit4 = PDFFunctions.pages[SAPInput.k].Width;
      double point37 = ((XUnit) ref xunit4).Point;
      xunit4 = PDFFunctions.pages[SAPInput.k].Height;
      double num55 = ((XUnit) ref xunit4).Point / 2.0;
      XRect xrect37 = new XRect(20.0, rc1_33, point37, num55);
      XStringFormat topLeft37 = XStringFormat.TopLeft;
      xgraphics37.DrawString("Transmission heat loss coefficient:", arialFont10Bold16, (XBrush) black35, xrect37, topLeft37);
      XGraphics xgraphics38 = PDFFunctions.gfx[SAPInput.k];
      string str11 = Conversions.ToString(Math.Round(SAP_Module.Calculation2012.Calculation.HeatLoss.Box37, 1));
      XFont xfont30 = xfont4;
      XSolidBrush black36 = XBrushes.Black;
      double rc1_34 = (double) SAPInput.RC1;
      xunit4 = PDFFunctions.pages[SAPInput.k].Width;
      double point38 = ((XUnit) ref xunit4).Point;
      xunit4 = PDFFunctions.pages[SAPInput.k].Height;
      double num56 = ((XUnit) ref xunit4).Point / 2.0;
      XRect xrect38 = new XRect(275.0, rc1_34, point38, num56);
      XStringFormat topLeft38 = XStringFormat.TopLeft;
      xgraphics38.DrawString(str11, xfont30, (XBrush) black36, xrect38, topLeft38);
      checked { SAPInput.RC1 += 12; }
      XGraphics xgraphics39 = PDFFunctions.gfx[SAPInput.k];
      XFont arialFont10Bold17 = PDFFunctions.ArialFont10Bold;
      XSolidBrush black37 = XBrushes.Black;
      double rc1_35 = (double) SAPInput.RC1;
      xunit4 = PDFFunctions.pages[SAPInput.k].Width;
      double point39 = ((XUnit) ref xunit4).Point;
      xunit4 = PDFFunctions.pages[SAPInput.k].Height;
      double num57 = ((XUnit) ref xunit4).Point / 2.0;
      XRect xrect39 = new XRect(20.0, rc1_35, point39, num57);
      XStringFormat topLeft39 = XStringFormat.TopLeft;
      xgraphics39.DrawString("Summer heat loss coefficient:", arialFont10Bold17, (XBrush) black37, xrect39, topLeft39);
      XGraphics xgraphics40 = PDFFunctions.gfx[SAPInput.k];
      string str12 = Conversions.ToString(Math.Round(SAP_Module.OverHeat.AppendixP.P2, 2));
      XFont xfont31 = xfont4;
      XSolidBrush black38 = XBrushes.Black;
      double rc1_36 = (double) SAPInput.RC1;
      xunit4 = PDFFunctions.pages[SAPInput.k].Width;
      double point40 = ((XUnit) ref xunit4).Point;
      xunit4 = PDFFunctions.pages[SAPInput.k].Height;
      double num58 = ((XUnit) ref xunit4).Point / 2.0;
      XRect xrect40 = new XRect(275.0, rc1_36, point40, num58);
      XStringFormat topLeft40 = XStringFormat.TopLeft;
      xgraphics40.DrawString(str12, xfont31, (XBrush) black38, xrect40, topLeft40);
      XGraphics xgraphics41 = PDFFunctions.gfx[SAPInput.k];
      XFont arialFont10Bold18 = PDFFunctions.ArialFont10Bold;
      XSolidBrush black39 = XBrushes.Black;
      double rc1_37 = (double) SAPInput.RC1;
      xunit4 = PDFFunctions.pages[SAPInput.k].Width;
      double point41 = ((XUnit) ref xunit4).Point;
      xunit4 = PDFFunctions.pages[SAPInput.k].Height;
      double num59 = ((XUnit) ref xunit4).Point / 2.0;
      XRect xrect41 = new XRect(550.0, rc1_37, point41, num59);
      XStringFormat topLeft41 = XStringFormat.TopLeft;
      xgraphics41.DrawString("(P2)", arialFont10Bold18, (XBrush) black39, xrect41, topLeft41);
      checked { SAPInput.RC1 += 16; }
      PDFFunctions.xBrush1 = XBrush.op_Implicit((Brush) new SolidBrush(Color.FromArgb(159, 172, 62)));
      PDFFunctions.Points[0].X = 20f;
      PDFFunctions.Points[0].Y = (float) SAPInput.RC1;
      ref PointF local5 = ref PDFFunctions.Points[1];
      xunit4 = PDFFunctions.pages[SAPInput.k].Width;
      double num60 = ((XUnit) ref xunit4).Point - 20.0;
      local5.X = (float) num60;
      PDFFunctions.Points[1].Y = (float) SAPInput.RC1;
      ref PointF local6 = ref PDFFunctions.Points[2];
      xunit4 = PDFFunctions.pages[SAPInput.k].Width;
      double num61 = ((XUnit) ref xunit4).Point - 20.0;
      local6.X = (float) num61;
      PDFFunctions.Points[2].Y = (float) checked (SAPInput.RC1 + 14);
      PDFFunctions.Points[3].X = 20f;
      PDFFunctions.Points[3].Y = (float) checked (SAPInput.RC1 + 14);
      PDFFunctions.gfx[SAPInput.k].DrawPolygon(PDFFunctions.polyGreen2, PDFFunctions.xBrush1, PDFFunctions.Points, xfillMode);
      XGraphics xgraphics42 = PDFFunctions.gfx[SAPInput.k];
      XFont xfont32 = xfont3;
      XSolidBrush white3 = XBrushes.White;
      double num62 = (double) checked (SAPInput.RC1 + 1);
      xunit4 = PDFFunctions.pages[SAPInput.k].Width;
      double point42 = ((XUnit) ref xunit4).Point;
      xunit4 = PDFFunctions.pages[SAPInput.k].Height;
      double num63 = ((XUnit) ref xunit4).Point / 2.0;
      XRect xrect42 = new XRect(25.0, num62, point42, num63);
      XStringFormat topLeft42 = XStringFormat.TopLeft;
      xgraphics42.DrawString("Overhangs:", xfont32, (XBrush) white3, xrect42, topLeft42);
      SAPInput.RC1 = checked ((int) Math.Round(unchecked ((double) PDFFunctions.Points[3].Y + 15.0)));
      XGraphics xgraphics43 = PDFFunctions.gfx[SAPInput.k];
      XFont arialFont10Bold19 = PDFFunctions.ArialFont10Bold;
      XSolidBrush black40 = XBrushes.Black;
      double rc1_38 = (double) SAPInput.RC1;
      xunit4 = PDFFunctions.pages[SAPInput.k].Width;
      double point43 = ((XUnit) ref xunit4).Point;
      xunit4 = PDFFunctions.pages[SAPInput.k].Height;
      double num64 = ((XUnit) ref xunit4).Point / 2.0;
      XRect xrect43 = new XRect(20.0, rc1_38, point43, num64);
      XStringFormat topLeft43 = XStringFormat.TopLeft;
      xgraphics43.DrawString("Orientation:", arialFont10Bold19, (XBrush) black40, xrect43, topLeft43);
      XGraphics xgraphics44 = PDFFunctions.gfx[SAPInput.k];
      XFont arialFont10Bold20 = PDFFunctions.ArialFont10Bold;
      XSolidBrush black41 = XBrushes.Black;
      double rc1_39 = (double) SAPInput.RC1;
      xunit4 = PDFFunctions.pages[SAPInput.k].Width;
      double point44 = ((XUnit) ref xunit4).Point;
      xunit4 = PDFFunctions.pages[SAPInput.k].Height;
      double num65 = ((XUnit) ref xunit4).Point / 2.0;
      XRect xrect44 = new XRect(130.0, rc1_39, point44, num65);
      XStringFormat topLeft44 = XStringFormat.TopLeft;
      xgraphics44.DrawString("Ratio:", arialFont10Bold20, (XBrush) black41, xrect44, topLeft44);
      XGraphics xgraphics45 = PDFFunctions.gfx[SAPInput.k];
      XFont arialFont10Bold21 = PDFFunctions.ArialFont10Bold;
      XSolidBrush black42 = XBrushes.Black;
      double rc1_40 = (double) SAPInput.RC1;
      xunit4 = PDFFunctions.pages[SAPInput.k].Width;
      double point45 = ((XUnit) ref xunit4).Point;
      xunit4 = PDFFunctions.pages[SAPInput.k].Height;
      double num66 = ((XUnit) ref xunit4).Point / 2.0;
      XRect xrect45 = new XRect(200.0, rc1_40, point45, num66);
      XStringFormat topLeft45 = XStringFormat.TopLeft;
      xgraphics45.DrawString("Z_overhangs:", arialFont10Bold21, (XBrush) black42, xrect45, topLeft45);
      checked { SAPInput.RC1 += 15; }
      // ISSUE: reference to a compiler-generated field
      int num67 = checked (SAP_Module.Proj.Dwellings[closure220_2.\u0024VB\u0024Local_House].NoofWindows - 1);
      int index1 = 0;
      while (index1 <= num67)
      {
        XGraphics xgraphics46 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        string str13 = SAP_Module.Proj.Dwellings[closure220_2.\u0024VB\u0024Local_House].Windows[index1].Orientation + " (" + SAP_Module.Proj.Dwellings[closure220_2.\u0024VB\u0024Local_House].Windows[index1].Name + ")";
        XFont xfont33 = xfont4;
        XSolidBrush black43 = XBrushes.Black;
        double rc1_41 = (double) SAPInput.RC1;
        xunit4 = PDFFunctions.pages[SAPInput.k].Width;
        double point46 = ((XUnit) ref xunit4).Point;
        xunit4 = PDFFunctions.pages[SAPInput.k].Height;
        double num68 = ((XUnit) ref xunit4).Point / 2.0;
        XRect xrect46 = new XRect(20.0, rc1_41, point46, num68);
        XStringFormat topLeft46 = XStringFormat.TopLeft;
        xgraphics46.DrawString(str13, xfont33, (XBrush) black43, xrect46, topLeft46);
        // ISSUE: reference to a compiler-generated field
        if ((double) SAP_Module.Proj.Dwellings[closure220_2.\u0024VB\u0024Local_House].Windows[index1].Height != 0.0)
        {
          XGraphics xgraphics47 = PDFFunctions.gfx[SAPInput.k];
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          string str14 = Conversions.ToString(Math.Round((double) SAP_Module.Proj.Dwellings[closure220_2.\u0024VB\u0024Local_House].Windows[index1].OverhangDepth / (double) SAP_Module.Proj.Dwellings[closure220_2.\u0024VB\u0024Local_House].Windows[index1].Height, 2));
          XFont xfont34 = xfont4;
          XSolidBrush black44 = XBrushes.Black;
          double rc1_42 = (double) SAPInput.RC1;
          xunit4 = PDFFunctions.pages[SAPInput.k].Width;
          double point47 = ((XUnit) ref xunit4).Point;
          xunit4 = PDFFunctions.pages[SAPInput.k].Height;
          double num69 = ((XUnit) ref xunit4).Point / 2.0;
          XRect xrect47 = new XRect(130.0, rc1_42, point47, num69);
          XStringFormat topLeft47 = XStringFormat.TopLeft;
          xgraphics47.DrawString(str14, xfont34, (XBrush) black44, xrect47, topLeft47);
        }
        else
        {
          XGraphics xgraphics48 = PDFFunctions.gfx[SAPInput.k];
          XFont xfont35 = xfont4;
          XSolidBrush black45 = XBrushes.Black;
          double rc1_43 = (double) SAPInput.RC1;
          xunit4 = PDFFunctions.pages[SAPInput.k].Width;
          double point48 = ((XUnit) ref xunit4).Point;
          xunit4 = PDFFunctions.pages[SAPInput.k].Height;
          double num70 = ((XUnit) ref xunit4).Point / 2.0;
          XRect xrect48 = new XRect(130.0, rc1_43, point48, num70);
          XStringFormat topLeft48 = XStringFormat.TopLeft;
          xgraphics48.DrawString("0", xfont35, (XBrush) black45, xrect48, topLeft48);
        }
        try
        {
          XGraphics xgraphics49 = PDFFunctions.gfx[SAPInput.k];
          string str15 = Conversions.ToString(Math.Round(SAP_Module.OverHeat.OpeningsJune[index1].Zo, 2));
          XFont xfont36 = xfont4;
          XSolidBrush black46 = XBrushes.Black;
          double rc1_44 = (double) SAPInput.RC1;
          xunit4 = PDFFunctions.pages[SAPInput.k].Width;
          double point49 = ((XUnit) ref xunit4).Point;
          xunit4 = PDFFunctions.pages[SAPInput.k].Height;
          double num71 = ((XUnit) ref xunit4).Point / 2.0;
          XRect xrect49 = new XRect(200.0, rc1_44, point49, num71);
          XStringFormat topLeft49 = XStringFormat.TopLeft;
          xgraphics49.DrawString(str15, xfont36, (XBrush) black46, xrect49, topLeft49);
          XGraphics xgraphics50 = PDFFunctions.gfx[SAPInput.k];
          XFont xfont37 = xfont4;
          XSolidBrush black47 = XBrushes.Black;
          double rc1_45 = (double) SAPInput.RC1;
          xunit4 = PDFFunctions.pages[SAPInput.k].Width;
          double point50 = ((XUnit) ref xunit4).Point;
          xunit4 = PDFFunctions.pages[SAPInput.k].Height;
          double num72 = ((XUnit) ref xunit4).Point / 2.0;
          XRect xrect50 = new XRect(300.0, rc1_45, point50, num72);
          XStringFormat topLeft50 = XStringFormat.TopLeft;
          xgraphics50.DrawString("", xfont37, (XBrush) black47, xrect50, topLeft50);
          checked { SAPInput.RC1 += 13; }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        checked { ++index1; }
      }
      SAPInput.Check2RC1();
      // ISSUE: reference to a compiler-generated field
      if ((uint) SAP_Module.Proj.Dwellings[closure220_2.\u0024VB\u0024Local_House].NoofRoofLights > 0U)
      {
        // ISSUE: reference to a compiler-generated field
        int noofWindows = SAP_Module.Proj.Dwellings[closure220_2.\u0024VB\u0024Local_House].NoofWindows;
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        int num73 = checked (SAP_Module.Proj.Dwellings[closure220_2.\u0024VB\u0024Local_House].NoofWindows + SAP_Module.Proj.Dwellings[closure220_2.\u0024VB\u0024Local_House].NoofRoofLights - 1);
        int index2 = noofWindows;
        while (index2 <= num73)
        {
          XGraphics xgraphics51 = PDFFunctions.gfx[SAPInput.k];
          int index3;
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          string str16 = SAP_Module.Proj.Dwellings[closure220_2.\u0024VB\u0024Local_House].RoofLights[index3].Orientation + " (" + SAP_Module.Proj.Dwellings[closure220_2.\u0024VB\u0024Local_House].RoofLights[index3].Name + ")";
          XFont xfont38 = xfont4;
          XSolidBrush black48 = XBrushes.Black;
          double rc1_46 = (double) SAPInput.RC1;
          xunit4 = PDFFunctions.pages[SAPInput.k].Width;
          double point51 = ((XUnit) ref xunit4).Point;
          xunit4 = PDFFunctions.pages[SAPInput.k].Height;
          double num74 = ((XUnit) ref xunit4).Point / 2.0;
          XRect xrect51 = new XRect(20.0, rc1_46, point51, num74);
          XStringFormat topLeft51 = XStringFormat.TopLeft;
          xgraphics51.DrawString(str16, xfont38, (XBrush) black48, xrect51, topLeft51);
          // ISSUE: reference to a compiler-generated field
          if ((double) SAP_Module.Proj.Dwellings[closure220_2.\u0024VB\u0024Local_House].RoofLights[index3].Height != 0.0)
          {
            XGraphics xgraphics52 = PDFFunctions.gfx[SAPInput.k];
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            string str17 = Conversions.ToString(Math.Round((double) SAP_Module.Proj.Dwellings[closure220_2.\u0024VB\u0024Local_House].RoofLights[index3].OverhangDepth / (double) SAP_Module.Proj.Dwellings[closure220_2.\u0024VB\u0024Local_House].RoofLights[index3].Height, 2));
            XFont xfont39 = xfont4;
            XSolidBrush black49 = XBrushes.Black;
            double rc1_47 = (double) SAPInput.RC1;
            xunit4 = PDFFunctions.pages[SAPInput.k].Width;
            double point52 = ((XUnit) ref xunit4).Point;
            xunit4 = PDFFunctions.pages[SAPInput.k].Height;
            double num75 = ((XUnit) ref xunit4).Point / 2.0;
            XRect xrect52 = new XRect(130.0, rc1_47, point52, num75);
            XStringFormat topLeft52 = XStringFormat.TopLeft;
            xgraphics52.DrawString(str17, xfont39, (XBrush) black49, xrect52, topLeft52);
          }
          else
          {
            XGraphics xgraphics53 = PDFFunctions.gfx[SAPInput.k];
            XFont xfont40 = xfont4;
            XSolidBrush black50 = XBrushes.Black;
            double rc1_48 = (double) SAPInput.RC1;
            xunit4 = PDFFunctions.pages[SAPInput.k].Width;
            double point53 = ((XUnit) ref xunit4).Point;
            xunit4 = PDFFunctions.pages[SAPInput.k].Height;
            double num76 = ((XUnit) ref xunit4).Point / 2.0;
            XRect xrect53 = new XRect(130.0, rc1_48, point53, num76);
            XStringFormat topLeft53 = XStringFormat.TopLeft;
            xgraphics53.DrawString("0", xfont40, (XBrush) black50, xrect53, topLeft53);
          }
          try
          {
            XGraphics xgraphics54 = PDFFunctions.gfx[SAPInput.k];
            string str18 = Conversions.ToString(Math.Round(SAP_Module.OverHeat.OpeningsJune[index2].Zo, 2));
            XFont xfont41 = xfont4;
            XSolidBrush black51 = XBrushes.Black;
            double rc1_49 = (double) SAPInput.RC1;
            xunit4 = PDFFunctions.pages[SAPInput.k].Width;
            double point54 = ((XUnit) ref xunit4).Point;
            xunit4 = PDFFunctions.pages[SAPInput.k].Height;
            double num77 = ((XUnit) ref xunit4).Point / 2.0;
            XRect xrect54 = new XRect(200.0, rc1_49, point54, num77);
            XStringFormat topLeft54 = XStringFormat.TopLeft;
            xgraphics54.DrawString(str18, xfont41, (XBrush) black51, xrect54, topLeft54);
            checked { SAPInput.RC1 += 13; }
            checked { ++index3; }
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
          checked { ++index2; }
        }
      }
      checked { SAPInput.RC1 += 3; }
      SAPInput.Check2RC1();
      PDFFunctions.xBrush1 = XBrush.op_Implicit((Brush) new SolidBrush(Color.FromArgb(159, 172, 62)));
      PDFFunctions.Points[0].X = 20f;
      PDFFunctions.Points[0].Y = (float) SAPInput.RC1;
      ref PointF local7 = ref PDFFunctions.Points[1];
      xunit4 = PDFFunctions.pages[SAPInput.k].Width;
      double num78 = ((XUnit) ref xunit4).Point - 20.0;
      local7.X = (float) num78;
      PDFFunctions.Points[1].Y = (float) SAPInput.RC1;
      ref PointF local8 = ref PDFFunctions.Points[2];
      xunit4 = PDFFunctions.pages[SAPInput.k].Width;
      double num79 = ((XUnit) ref xunit4).Point - 20.0;
      local8.X = (float) num79;
      PDFFunctions.Points[2].Y = (float) checked (SAPInput.RC1 + 14);
      PDFFunctions.Points[3].X = 20f;
      PDFFunctions.Points[3].Y = (float) checked (SAPInput.RC1 + 14);
      PDFFunctions.gfx[SAPInput.k].DrawPolygon(PDFFunctions.polyGreen2, PDFFunctions.xBrush1, PDFFunctions.Points, xfillMode);
      XGraphics xgraphics55 = PDFFunctions.gfx[SAPInput.k];
      XFont xfont42 = xfont3;
      XSolidBrush white4 = XBrushes.White;
      double num80 = (double) checked (SAPInput.RC1 + 1);
      xunit4 = PDFFunctions.pages[SAPInput.k].Width;
      double point55 = ((XUnit) ref xunit4).Point;
      xunit4 = PDFFunctions.pages[SAPInput.k].Height;
      double num81 = ((XUnit) ref xunit4).Point / 2.0;
      XRect xrect55 = new XRect(25.0, num80, point55, num81);
      XStringFormat topLeft55 = XStringFormat.TopLeft;
      xgraphics55.DrawString("Solar shading:", xfont42, (XBrush) white4, xrect55, topLeft55);
      SAPInput.RC1 = checked ((int) Math.Round(unchecked ((double) PDFFunctions.Points[3].Y + 15.0)));
      XGraphics xgraphics56 = PDFFunctions.gfx[SAPInput.k];
      XFont arialFont10Bold22 = PDFFunctions.ArialFont10Bold;
      XSolidBrush black52 = XBrushes.Black;
      double rc1_50 = (double) SAPInput.RC1;
      xunit4 = PDFFunctions.pages[SAPInput.k].Width;
      double point56 = ((XUnit) ref xunit4).Point;
      xunit4 = PDFFunctions.pages[SAPInput.k].Height;
      double num82 = ((XUnit) ref xunit4).Point / 2.0;
      XRect xrect56 = new XRect(20.0, rc1_50, point56, num82);
      XStringFormat topLeft56 = XStringFormat.TopLeft;
      xgraphics56.DrawString("Orientation:", arialFont10Bold22, (XBrush) black52, xrect56, topLeft56);
      XGraphics xgraphics57 = PDFFunctions.gfx[SAPInput.k];
      XFont arialFont10Bold23 = PDFFunctions.ArialFont10Bold;
      XSolidBrush black53 = XBrushes.Black;
      double rc1_51 = (double) SAPInput.RC1;
      xunit4 = PDFFunctions.pages[SAPInput.k].Width;
      double point57 = ((XUnit) ref xunit4).Point;
      xunit4 = PDFFunctions.pages[SAPInput.k].Height;
      double num83 = ((XUnit) ref xunit4).Point / 2.0;
      XRect xrect57 = new XRect(130.0, rc1_51, point57, num83);
      XStringFormat topLeft57 = XStringFormat.TopLeft;
      xgraphics57.DrawString("Z blinds:", arialFont10Bold23, (XBrush) black53, xrect57, topLeft57);
      XGraphics xgraphics58 = PDFFunctions.gfx[SAPInput.k];
      XFont arialFont10Bold24 = PDFFunctions.ArialFont10Bold;
      XSolidBrush black54 = XBrushes.Black;
      double rc1_52 = (double) SAPInput.RC1;
      xunit4 = PDFFunctions.pages[SAPInput.k].Width;
      double point58 = ((XUnit) ref xunit4).Point;
      xunit4 = PDFFunctions.pages[SAPInput.k].Height;
      double num84 = ((XUnit) ref xunit4).Point / 2.0;
      XRect xrect58 = new XRect(200.0, rc1_52, point58, num84);
      XStringFormat topLeft58 = XStringFormat.TopLeft;
      xgraphics58.DrawString("Solar access:", arialFont10Bold24, (XBrush) black54, xrect58, topLeft58);
      XGraphics xgraphics59 = PDFFunctions.gfx[SAPInput.k];
      XFont arialFont10Bold25 = PDFFunctions.ArialFont10Bold;
      XSolidBrush black55 = XBrushes.Black;
      double rc1_53 = (double) SAPInput.RC1;
      xunit4 = PDFFunctions.pages[SAPInput.k].Width;
      double point59 = ((XUnit) ref xunit4).Point;
      xunit4 = PDFFunctions.pages[SAPInput.k].Height;
      double num85 = ((XUnit) ref xunit4).Point / 2.0;
      XRect xrect59 = new XRect(300.0, rc1_53, point59, num85);
      XStringFormat topLeft59 = XStringFormat.TopLeft;
      xgraphics59.DrawString("Overhangs:", arialFont10Bold25, (XBrush) black55, xrect59, topLeft59);
      XGraphics xgraphics60 = PDFFunctions.gfx[SAPInput.k];
      XFont arialFont10Bold26 = PDFFunctions.ArialFont10Bold;
      XSolidBrush black56 = XBrushes.Black;
      double rc1_54 = (double) SAPInput.RC1;
      xunit4 = PDFFunctions.pages[SAPInput.k].Width;
      double point60 = ((XUnit) ref xunit4).Point;
      xunit4 = PDFFunctions.pages[SAPInput.k].Height;
      double num86 = ((XUnit) ref xunit4).Point / 2.0;
      XRect xrect60 = new XRect(400.0, rc1_54, point60, num86);
      XStringFormat topLeft60 = XStringFormat.TopLeft;
      xgraphics60.DrawString("Z summer:", arialFont10Bold26, (XBrush) black56, xrect60, topLeft60);
      checked { SAPInput.RC1 += 15; }
      // ISSUE: reference to a compiler-generated field
      int num87 = checked (SAP_Module.Proj.Dwellings[closure220_2.\u0024VB\u0024Local_House].NoofWindows - 1);
      int index4 = 0;
      while (index4 <= num87)
      {
        XGraphics xgraphics61 = PDFFunctions.gfx[SAPInput.k];
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        string str19 = SAP_Module.Proj.Dwellings[closure220_2.\u0024VB\u0024Local_House].Windows[index4].Orientation + " (" + SAP_Module.Proj.Dwellings[closure220_2.\u0024VB\u0024Local_House].Windows[index4].Name + ")";
        XFont xfont43 = xfont4;
        XSolidBrush black57 = XBrushes.Black;
        double rc1_55 = (double) SAPInput.RC1;
        xunit4 = PDFFunctions.pages[SAPInput.k].Width;
        double point61 = ((XUnit) ref xunit4).Point;
        xunit4 = PDFFunctions.pages[SAPInput.k].Height;
        double num88 = ((XUnit) ref xunit4).Point / 2.0;
        XRect xrect61 = new XRect(20.0, rc1_55, point61, num88);
        XStringFormat topLeft61 = XStringFormat.TopLeft;
        xgraphics61.DrawString(str19, xfont43, (XBrush) black57, xrect61, topLeft61);
        XGraphics xgraphics62 = PDFFunctions.gfx[SAPInput.k];
        string str20 = Conversions.ToString(Math.Round(SAP_Module.OverHeat.OpeningsJune[index4].Zb, 2));
        XFont xfont44 = xfont4;
        XSolidBrush black58 = XBrushes.Black;
        double rc1_56 = (double) SAPInput.RC1;
        xunit4 = PDFFunctions.pages[SAPInput.k].Width;
        double point62 = ((XUnit) ref xunit4).Point;
        xunit4 = PDFFunctions.pages[SAPInput.k].Height;
        double num89 = ((XUnit) ref xunit4).Point / 2.0;
        XRect xrect62 = new XRect(130.0, rc1_56, point62, num89);
        XStringFormat topLeft62 = XStringFormat.TopLeft;
        xgraphics62.DrawString(str20, xfont44, (XBrush) black58, xrect62, topLeft62);
        XGraphics xgraphics63 = PDFFunctions.gfx[SAPInput.k];
        string str21 = Conversions.ToString(Math.Round(SAP_Module.OverHeat.OpeningsJune[index4].Z, 2));
        XFont xfont45 = xfont4;
        XSolidBrush black59 = XBrushes.Black;
        double rc1_57 = (double) SAPInput.RC1;
        xunit4 = PDFFunctions.pages[SAPInput.k].Width;
        double point63 = ((XUnit) ref xunit4).Point;
        xunit4 = PDFFunctions.pages[SAPInput.k].Height;
        double num90 = ((XUnit) ref xunit4).Point / 2.0;
        XRect xrect63 = new XRect(200.0, rc1_57, point63, num90);
        XStringFormat topLeft63 = XStringFormat.TopLeft;
        xgraphics63.DrawString(str21, xfont45, (XBrush) black59, xrect63, topLeft63);
        XGraphics xgraphics64 = PDFFunctions.gfx[SAPInput.k];
        string str22 = Conversions.ToString(Math.Round(SAP_Module.OverHeat.OpeningsJune[index4].Zo, 2));
        XFont xfont46 = xfont4;
        XSolidBrush black60 = XBrushes.Black;
        double rc1_58 = (double) SAPInput.RC1;
        xunit4 = PDFFunctions.pages[SAPInput.k].Width;
        double point64 = ((XUnit) ref xunit4).Point;
        xunit4 = PDFFunctions.pages[SAPInput.k].Height;
        double num91 = ((XUnit) ref xunit4).Point / 2.0;
        XRect xrect64 = new XRect(300.0, rc1_58, point64, num91);
        XStringFormat topLeft64 = XStringFormat.TopLeft;
        xgraphics64.DrawString(str22, xfont46, (XBrush) black60, xrect64, topLeft64);
        XGraphics xgraphics65 = PDFFunctions.gfx[SAPInput.k];
        string str23 = Conversions.ToString(Math.Round(SAP_Module.OverHeat.OpeningsJune[index4].Zs, 2));
        XFont xfont47 = xfont4;
        XSolidBrush black61 = XBrushes.Black;
        double rc1_59 = (double) SAPInput.RC1;
        xunit4 = PDFFunctions.pages[SAPInput.k].Width;
        double point65 = ((XUnit) ref xunit4).Point;
        xunit4 = PDFFunctions.pages[SAPInput.k].Height;
        double num92 = ((XUnit) ref xunit4).Point / 2.0;
        XRect xrect65 = new XRect(400.0, rc1_59, point65, num92);
        XStringFormat topLeft65 = XStringFormat.TopLeft;
        xgraphics65.DrawString(str23, xfont47, (XBrush) black61, xrect65, topLeft65);
        XGraphics xgraphics66 = PDFFunctions.gfx[SAPInput.k];
        XFont arialFont10Bold27 = PDFFunctions.ArialFont10Bold;
        XSolidBrush black62 = XBrushes.Black;
        double rc1_60 = (double) SAPInput.RC1;
        xunit4 = PDFFunctions.pages[SAPInput.k].Width;
        double point66 = ((XUnit) ref xunit4).Point;
        xunit4 = PDFFunctions.pages[SAPInput.k].Height;
        double num93 = ((XUnit) ref xunit4).Point / 2.0;
        XRect xrect66 = new XRect(550.0, rc1_60, point66, num93);
        XStringFormat topLeft66 = XStringFormat.TopLeft;
        xgraphics66.DrawString("(P8)", arialFont10Bold27, (XBrush) black62, xrect66, topLeft66);
        checked { SAPInput.RC1 += 13; }
        SAPInput.Check2RC1();
        checked { ++index4; }
      }
      SAPInput.Check2RC1();
      try
      {
        // ISSUE: reference to a compiler-generated field
        int noofWindows = SAP_Module.Proj.Dwellings[closure220_2.\u0024VB\u0024Local_House].NoofWindows;
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        int num94 = checked (SAP_Module.Proj.Dwellings[closure220_2.\u0024VB\u0024Local_House].NoofWindows + SAP_Module.Proj.Dwellings[closure220_2.\u0024VB\u0024Local_House].NoofRoofLights - 1);
        int index5 = noofWindows;
        while (index5 <= num94)
        {
          XGraphics xgraphics67 = PDFFunctions.gfx[SAPInput.k];
          int index6;
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          string str24 = SAP_Module.Proj.Dwellings[closure220_2.\u0024VB\u0024Local_House].RoofLights[index6].Orientation + " (" + SAP_Module.Proj.Dwellings[closure220_2.\u0024VB\u0024Local_House].RoofLights[index6].Name + ")";
          XFont xfont48 = xfont4;
          XSolidBrush black63 = XBrushes.Black;
          double rc1_61 = (double) SAPInput.RC1;
          xunit4 = PDFFunctions.pages[SAPInput.k].Width;
          double point67 = ((XUnit) ref xunit4).Point;
          xunit4 = PDFFunctions.pages[SAPInput.k].Height;
          double num95 = ((XUnit) ref xunit4).Point / 2.0;
          XRect xrect67 = new XRect(20.0, rc1_61, point67, num95);
          XStringFormat topLeft67 = XStringFormat.TopLeft;
          xgraphics67.DrawString(str24, xfont48, (XBrush) black63, xrect67, topLeft67);
          XGraphics xgraphics68 = PDFFunctions.gfx[SAPInput.k];
          string str25 = Conversions.ToString(Math.Round(SAP_Module.OverHeat.OpeningsJune[index5].Zb, 2));
          XFont xfont49 = xfont4;
          XSolidBrush black64 = XBrushes.Black;
          double rc1_62 = (double) SAPInput.RC1;
          xunit4 = PDFFunctions.pages[SAPInput.k].Width;
          double point68 = ((XUnit) ref xunit4).Point;
          xunit4 = PDFFunctions.pages[SAPInput.k].Height;
          double num96 = ((XUnit) ref xunit4).Point / 2.0;
          XRect xrect68 = new XRect(130.0, rc1_62, point68, num96);
          XStringFormat topLeft68 = XStringFormat.TopLeft;
          xgraphics68.DrawString(str25, xfont49, (XBrush) black64, xrect68, topLeft68);
          XGraphics xgraphics69 = PDFFunctions.gfx[SAPInput.k];
          string str26 = Conversions.ToString(Math.Round(SAP_Module.OverHeat.OpeningsJune[index5].Z, 2));
          XFont xfont50 = xfont4;
          XSolidBrush black65 = XBrushes.Black;
          double rc1_63 = (double) SAPInput.RC1;
          xunit4 = PDFFunctions.pages[SAPInput.k].Width;
          double point69 = ((XUnit) ref xunit4).Point;
          xunit4 = PDFFunctions.pages[SAPInput.k].Height;
          double num97 = ((XUnit) ref xunit4).Point / 2.0;
          XRect xrect69 = new XRect(200.0, rc1_63, point69, num97);
          XStringFormat topLeft69 = XStringFormat.TopLeft;
          xgraphics69.DrawString(str26, xfont50, (XBrush) black65, xrect69, topLeft69);
          XGraphics xgraphics70 = PDFFunctions.gfx[SAPInput.k];
          string str27 = Conversions.ToString(Math.Round(SAP_Module.OverHeat.OpeningsJune[index5].Zo, 2));
          XFont xfont51 = xfont4;
          XSolidBrush black66 = XBrushes.Black;
          double rc1_64 = (double) SAPInput.RC1;
          xunit4 = PDFFunctions.pages[SAPInput.k].Width;
          double point70 = ((XUnit) ref xunit4).Point;
          xunit4 = PDFFunctions.pages[SAPInput.k].Height;
          double num98 = ((XUnit) ref xunit4).Point / 2.0;
          XRect xrect70 = new XRect(300.0, rc1_64, point70, num98);
          XStringFormat topLeft70 = XStringFormat.TopLeft;
          xgraphics70.DrawString(str27, xfont51, (XBrush) black66, xrect70, topLeft70);
          XGraphics xgraphics71 = PDFFunctions.gfx[SAPInput.k];
          string str28 = Conversions.ToString(Math.Round(SAP_Module.OverHeat.OpeningsJune[index5].Zs, 2));
          XFont xfont52 = xfont4;
          XSolidBrush black67 = XBrushes.Black;
          double rc1_65 = (double) SAPInput.RC1;
          xunit4 = PDFFunctions.pages[SAPInput.k].Width;
          double point71 = ((XUnit) ref xunit4).Point;
          xunit4 = PDFFunctions.pages[SAPInput.k].Height;
          double num99 = ((XUnit) ref xunit4).Point / 2.0;
          XRect xrect71 = new XRect(400.0, rc1_65, point71, num99);
          XStringFormat topLeft71 = XStringFormat.TopLeft;
          xgraphics71.DrawString(str28, xfont52, (XBrush) black67, xrect71, topLeft71);
          XGraphics xgraphics72 = PDFFunctions.gfx[SAPInput.k];
          XFont arialFont10Bold28 = PDFFunctions.ArialFont10Bold;
          XSolidBrush black68 = XBrushes.Black;
          double rc1_66 = (double) SAPInput.RC1;
          xunit4 = PDFFunctions.pages[SAPInput.k].Width;
          double point72 = ((XUnit) ref xunit4).Point;
          xunit4 = PDFFunctions.pages[SAPInput.k].Height;
          double num100 = ((XUnit) ref xunit4).Point / 2.0;
          XRect xrect72 = new XRect(550.0, rc1_66, point72, num100);
          XStringFormat topLeft72 = XStringFormat.TopLeft;
          xgraphics72.DrawString("(P8)", arialFont10Bold28, (XBrush) black68, xrect72, topLeft72);
          checked { ++index6; }
          checked { SAPInput.RC1 += 13; }
          SAPInput.Check2RC1();
          checked { ++index5; }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      checked { SAPInput.RC1 += 3; }
      SAPInput.Check2RC1();
      PDFFunctions.xBrush1 = XBrush.op_Implicit((Brush) new SolidBrush(Color.FromArgb(159, 172, 62)));
      PDFFunctions.Points[0].X = 20f;
      PDFFunctions.Points[0].Y = (float) SAPInput.RC1;
      ref PointF local9 = ref PDFFunctions.Points[1];
      XUnit width11 = PDFFunctions.pages[SAPInput.k].Width;
      double num101 = ((XUnit) ref width11).Point - 20.0;
      local9.X = (float) num101;
      PDFFunctions.Points[1].Y = (float) SAPInput.RC1;
      ref PointF local10 = ref PDFFunctions.Points[2];
      XUnit xunit5 = PDFFunctions.pages[SAPInput.k].Width;
      double num102 = ((XUnit) ref xunit5).Point - 20.0;
      local10.X = (float) num102;
      PDFFunctions.Points[2].Y = (float) checked (SAPInput.RC1 + 14);
      PDFFunctions.Points[3].X = 20f;
      PDFFunctions.Points[3].Y = (float) checked (SAPInput.RC1 + 14);
      PDFFunctions.gfx[SAPInput.k].DrawPolygon(PDFFunctions.polyGreen2, PDFFunctions.xBrush1, PDFFunctions.Points, xfillMode);
      XGraphics xgraphics73 = PDFFunctions.gfx[SAPInput.k];
      XFont xfont53 = xfont3;
      XSolidBrush white5 = XBrushes.White;
      double num103 = (double) checked (SAPInput.RC1 + 1);
      xunit5 = PDFFunctions.pages[SAPInput.k].Width;
      double point73 = ((XUnit) ref xunit5).Point;
      xunit5 = PDFFunctions.pages[SAPInput.k].Height;
      double num104 = ((XUnit) ref xunit5).Point / 2.0;
      XRect xrect73 = new XRect(25.0, num103, point73, num104);
      XStringFormat topLeft73 = XStringFormat.TopLeft;
      xgraphics73.DrawString("Solar gains:", xfont53, (XBrush) white5, xrect73, topLeft73);
      SAPInput.RC1 = checked ((int) Math.Round(unchecked ((double) PDFFunctions.Points[3].Y + 13.0)));
      XGraphics xgraphics74 = PDFFunctions.gfx[SAPInput.k];
      XFont xfont54 = xfont3;
      XSolidBrush white6 = XBrushes.White;
      double num105 = (double) checked (SAPInput.RC1 + 1);
      xunit5 = PDFFunctions.pages[SAPInput.k].Width;
      double point74 = ((XUnit) ref xunit5).Point;
      xunit5 = PDFFunctions.pages[SAPInput.k].Height;
      double num106 = ((XUnit) ref xunit5).Point / 2.0;
      XRect xrect74 = new XRect(25.0, num105, point74, num106);
      XStringFormat topLeft74 = XStringFormat.TopLeft;
      xgraphics74.DrawString("(calculation for July)", xfont54, (XBrush) white6, xrect74, topLeft74);
      SAPInput.RC1 = checked ((int) Math.Round(unchecked ((double) PDFFunctions.Points[3].Y + 13.0)));
      XGraphics xgraphics75 = PDFFunctions.gfx[SAPInput.k];
      XFont arialFont10Bold29 = PDFFunctions.ArialFont10Bold;
      XSolidBrush black69 = XBrushes.Black;
      double rc1_67 = (double) SAPInput.RC1;
      xunit5 = PDFFunctions.pages[SAPInput.k].Width;
      double point75 = ((XUnit) ref xunit5).Point;
      xunit5 = PDFFunctions.pages[SAPInput.k].Height;
      double num107 = ((XUnit) ref xunit5).Point / 2.0;
      XRect xrect75 = new XRect(20.0, rc1_67, point75, num107);
      XStringFormat topLeft75 = XStringFormat.TopLeft;
      xgraphics75.DrawString("Orientation", arialFont10Bold29, (XBrush) black69, xrect75, topLeft75);
      XGraphics xgraphics76 = PDFFunctions.gfx[SAPInput.k];
      XFont arialFont10Bold30 = PDFFunctions.ArialFont10Bold;
      XSolidBrush black70 = XBrushes.Black;
      double rc1_68 = (double) SAPInput.RC1;
      xunit5 = PDFFunctions.pages[SAPInput.k].Width;
      double point76 = ((XUnit) ref xunit5).Point;
      xunit5 = PDFFunctions.pages[SAPInput.k].Height;
      double num108 = ((XUnit) ref xunit5).Point / 2.0;
      XRect xrect76 = new XRect(170.0, rc1_68, point76, num108);
      XStringFormat topLeft76 = XStringFormat.TopLeft;
      xgraphics76.DrawString("Area", arialFont10Bold30, (XBrush) black70, xrect76, topLeft76);
      XGraphics xgraphics77 = PDFFunctions.gfx[SAPInput.k];
      XFont arialFont10Bold31 = PDFFunctions.ArialFont10Bold;
      XSolidBrush black71 = XBrushes.Black;
      double rc1_69 = (double) SAPInput.RC1;
      xunit5 = PDFFunctions.pages[SAPInput.k].Width;
      double point77 = ((XUnit) ref xunit5).Point;
      xunit5 = PDFFunctions.pages[SAPInput.k].Height;
      double num109 = ((XUnit) ref xunit5).Point / 2.0;
      XRect xrect77 = new XRect(220.0, rc1_69, point77, num109);
      XStringFormat topLeft77 = XStringFormat.TopLeft;
      xgraphics77.DrawString("Flux", arialFont10Bold31, (XBrush) black71, xrect77, topLeft77);
      XGraphics xgraphics78 = PDFFunctions.gfx[SAPInput.k];
      XFont arialFont10Bold32 = PDFFunctions.ArialFont10Bold;
      XSolidBrush black72 = XBrushes.Black;
      double rc1_70 = (double) SAPInput.RC1;
      xunit5 = PDFFunctions.pages[SAPInput.k].Width;
      double point78 = ((XUnit) ref xunit5).Point;
      xunit5 = PDFFunctions.pages[SAPInput.k].Height;
      double num110 = ((XUnit) ref xunit5).Point / 2.0;
      XRect xrect78 = new XRect(280.0, rc1_70, point78, num110);
      XStringFormat topLeft78 = XStringFormat.TopLeft;
      xgraphics78.DrawString("g_", arialFont10Bold32, (XBrush) black72, xrect78, topLeft78);
      XGraphics xgraphics79 = PDFFunctions.gfx[SAPInput.k];
      XFont arialFont10Bold33 = PDFFunctions.ArialFont10Bold;
      XSolidBrush black73 = XBrushes.Black;
      double rc1_71 = (double) SAPInput.RC1;
      xunit5 = PDFFunctions.pages[SAPInput.k].Width;
      double point79 = ((XUnit) ref xunit5).Point;
      xunit5 = PDFFunctions.pages[SAPInput.k].Height;
      double num111 = ((XUnit) ref xunit5).Point / 2.0;
      XRect xrect79 = new XRect(350.0, rc1_71, point79, num111);
      XStringFormat topLeft79 = XStringFormat.TopLeft;
      xgraphics79.DrawString("FF", arialFont10Bold33, (XBrush) black73, xrect79, topLeft79);
      XGraphics xgraphics80 = PDFFunctions.gfx[SAPInput.k];
      XFont arialFont10Bold34 = PDFFunctions.ArialFont10Bold;
      XSolidBrush black74 = XBrushes.Black;
      double rc1_72 = (double) SAPInput.RC1;
      xunit5 = PDFFunctions.pages[SAPInput.k].Width;
      double point80 = ((XUnit) ref xunit5).Point;
      xunit5 = PDFFunctions.pages[SAPInput.k].Height;
      double num112 = ((XUnit) ref xunit5).Point / 2.0;
      XRect xrect80 = new XRect(420.0, rc1_72, point80, num112);
      XStringFormat topLeft80 = XStringFormat.TopLeft;
      xgraphics80.DrawString("Shading", arialFont10Bold34, (XBrush) black74, xrect80, topLeft80);
      XGraphics xgraphics81 = PDFFunctions.gfx[SAPInput.k];
      XFont arialFont10Bold35 = PDFFunctions.ArialFont10Bold;
      XSolidBrush black75 = XBrushes.Black;
      double rc1_73 = (double) SAPInput.RC1;
      xunit5 = PDFFunctions.pages[SAPInput.k].Width;
      double point81 = ((XUnit) ref xunit5).Point;
      xunit5 = PDFFunctions.pages[SAPInput.k].Height;
      double num113 = ((XUnit) ref xunit5).Point / 2.0;
      XRect xrect81 = new XRect(510.0, rc1_73, point81, num113);
      XStringFormat topLeft81 = XStringFormat.TopLeft;
      xgraphics81.DrawString("Gains", arialFont10Bold35, (XBrush) black75, xrect81, topLeft81);
      checked { SAPInput.RC1 += 14; }
      double num114 = 0.0;
      SAPInput.Check2RC1();
      int num115 = checked (SAP_Module.OverHeat.OpeningsJuly.Length - 1);
      int index7 = 0;
      while (index7 <= num115)
      {
        XGraphics xgraphics82 = PDFFunctions.gfx[SAPInput.k];
        string str29 = Conversions.ToString(Math.Round(SAP_Module.OverHeat.OpeningsJuly[index7].Z, 2)) + " x";
        XFont xfont55 = xfont4;
        XSolidBrush black76 = XBrushes.Black;
        double rc1_74 = (double) SAPInput.RC1;
        xunit5 = PDFFunctions.pages[SAPInput.k].Width;
        double point82 = ((XUnit) ref xunit5).Point;
        xunit5 = PDFFunctions.pages[SAPInput.k].Height;
        double num116 = ((XUnit) ref xunit5).Point / 2.0;
        XRect xrect82 = new XRect(130.0, rc1_74, point82, num116);
        XStringFormat topLeft82 = XStringFormat.TopLeft;
        xgraphics82.DrawString(str29, xfont55, (XBrush) black76, xrect82, topLeft82);
        try
        {
          XGraphics xgraphics83 = PDFFunctions.gfx[SAPInput.k];
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          string str30 = SAP_Module.Proj.Dwellings[closure220_2.\u0024VB\u0024Local_House].Windows[index7].Orientation + " (" + SAP_Module.Proj.Dwellings[closure220_2.\u0024VB\u0024Local_House].Windows[index7].Name + ")";
          XFont xfont56 = xfont4;
          XSolidBrush black77 = XBrushes.Black;
          double rc1_75 = (double) SAPInput.RC1;
          xunit5 = PDFFunctions.pages[SAPInput.k].Width;
          double point83 = ((XUnit) ref xunit5).Point;
          xunit5 = PDFFunctions.pages[SAPInput.k].Height;
          double num117 = ((XUnit) ref xunit5).Point / 2.0;
          XRect xrect83 = new XRect(20.0, rc1_75, point83, num117);
          XStringFormat topLeft83 = XStringFormat.TopLeft;
          xgraphics83.DrawString(str30, xfont56, (XBrush) black77, xrect83, topLeft83);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        XGraphics xgraphics84 = PDFFunctions.gfx[SAPInput.k];
        string str31 = Conversions.ToString(Math.Round(SAP_Module.OverHeat.OpeningsJuly[index7].Aw, 2));
        XFont xfont57 = xfont4;
        XSolidBrush black78 = XBrushes.Black;
        double rc1_76 = (double) SAPInput.RC1;
        XUnit width12 = PDFFunctions.pages[SAPInput.k].Width;
        double point84 = ((XUnit) ref width12).Point;
        XUnit height5 = PDFFunctions.pages[SAPInput.k].Height;
        double num118 = ((XUnit) ref height5).Point / 2.0;
        XRect xrect84 = new XRect(170.0, rc1_76, point84, num118);
        XStringFormat topLeft84 = XStringFormat.TopLeft;
        xgraphics84.DrawString(str31, xfont57, (XBrush) black78, xrect84, topLeft84);
        XGraphics xgraphics85 = PDFFunctions.gfx[SAPInput.k];
        string str32 = Conversions.ToString(Math.Round(SAP_Module.OverHeat.OpeningsJuly[index7].S, 2));
        XFont xfont58 = xfont4;
        XSolidBrush black79 = XBrushes.Black;
        double rc1_77 = (double) SAPInput.RC1;
        XUnit width13 = PDFFunctions.pages[SAPInput.k].Width;
        double point85 = ((XUnit) ref width13).Point;
        XUnit height6 = PDFFunctions.pages[SAPInput.k].Height;
        double num119 = ((XUnit) ref height6).Point / 2.0;
        XRect xrect85 = new XRect(220.0, rc1_77, point85, num119);
        XStringFormat topLeft85 = XStringFormat.TopLeft;
        xgraphics85.DrawString(str32, xfont58, (XBrush) black79, xrect85, topLeft85);
        XGraphics xgraphics86 = PDFFunctions.gfx[SAPInput.k];
        string str33 = Conversions.ToString(Math.Round(SAP_Module.OverHeat.OpeningsJuly[index7].gt, 2));
        XFont xfont59 = xfont4;
        XSolidBrush black80 = XBrushes.Black;
        double rc1_78 = (double) SAPInput.RC1;
        XUnit xunit6 = PDFFunctions.pages[SAPInput.k].Width;
        double point86 = ((XUnit) ref xunit6).Point;
        xunit6 = PDFFunctions.pages[SAPInput.k].Height;
        double num120 = ((XUnit) ref xunit6).Point / 2.0;
        XRect xrect86 = new XRect(280.0, rc1_78, point86, num120);
        XStringFormat topLeft86 = XStringFormat.TopLeft;
        xgraphics86.DrawString(str33, xfont59, (XBrush) black80, xrect86, topLeft86);
        XGraphics xgraphics87 = PDFFunctions.gfx[SAPInput.k];
        string str34 = Conversions.ToString(Math.Round(SAP_Module.OverHeat.OpeningsJuly[index7].FF, 2));
        XFont xfont60 = xfont4;
        XSolidBrush black81 = XBrushes.Black;
        double rc1_79 = (double) SAPInput.RC1;
        XUnit width14 = PDFFunctions.pages[SAPInput.k].Width;
        double point87 = ((XUnit) ref width14).Point;
        xunit5 = PDFFunctions.pages[SAPInput.k].Height;
        double num121 = ((XUnit) ref xunit5).Point / 2.0;
        XRect xrect87 = new XRect(350.0, rc1_79, point87, num121);
        XStringFormat topLeft87 = XStringFormat.TopLeft;
        xgraphics87.DrawString(str34, xfont60, (XBrush) black81, xrect87, topLeft87);
        XGraphics xgraphics88 = PDFFunctions.gfx[SAPInput.k];
        string str35 = Conversions.ToString(Math.Round(SAP_Module.OverHeat.OpeningsJuly[index7].Zs, 2));
        XFont xfont61 = xfont4;
        XSolidBrush black82 = XBrushes.Black;
        double rc1_80 = (double) SAPInput.RC1;
        xunit5 = PDFFunctions.pages[SAPInput.k].Width;
        double point88 = ((XUnit) ref xunit5).Point;
        xunit5 = PDFFunctions.pages[SAPInput.k].Height;
        double num122 = ((XUnit) ref xunit5).Point / 2.0;
        XRect xrect88 = new XRect(420.0, rc1_80, point88, num122);
        XStringFormat topLeft88 = XStringFormat.TopLeft;
        xgraphics88.DrawString(str35, xfont61, (XBrush) black82, xrect88, topLeft88);
        XGraphics xgraphics89 = PDFFunctions.gfx[SAPInput.k];
        string str36 = Conversions.ToString(Math.Round(SAP_Module.OverHeat.OpeningsJuly[index7].Gs, 2));
        XFont xfont62 = xfont4;
        XSolidBrush black83 = XBrushes.Black;
        double rc1_81 = (double) SAPInput.RC1;
        xunit5 = PDFFunctions.pages[SAPInput.k].Width;
        double point89 = ((XUnit) ref xunit5).Point;
        xunit5 = PDFFunctions.pages[SAPInput.k].Height;
        double num123 = ((XUnit) ref xunit5).Point / 2.0;
        XRect xrect89 = new XRect(510.0, rc1_81, point89, num123);
        XStringFormat topLeft89 = XStringFormat.TopLeft;
        xgraphics89.DrawString(str36, xfont62, (XBrush) black83, xrect89, topLeft89);
        checked { SAPInput.RC1 += 13; }
        num114 += Math.Round(SAP_Module.OverHeat.OpeningsJuly[index7].Gs, 2);
        SAPInput.Check2RC1();
        checked { ++index7; }
      }
      SAPInput.Check2RC1();
      XGraphics xgraphics90 = PDFFunctions.gfx[SAPInput.k];
      XFont arialFont10Bold36 = PDFFunctions.ArialFont10Bold;
      XSolidBrush black84 = XBrushes.Black;
      double rc1_82 = (double) SAPInput.RC1;
      xunit5 = PDFFunctions.pages[SAPInput.k].Width;
      double point90 = ((XUnit) ref xunit5).Point;
      xunit5 = PDFFunctions.pages[SAPInput.k].Height;
      double num124 = ((XUnit) ref xunit5).Point / 2.0;
      XRect xrect90 = new XRect(410.0, rc1_82, point90, num124);
      XStringFormat topLeft90 = XStringFormat.TopLeft;
      xgraphics90.DrawString("Total", arialFont10Bold36, (XBrush) black84, xrect90, topLeft90);
      XGraphics xgraphics91 = PDFFunctions.gfx[SAPInput.k];
      string str37 = Conversions.ToString(Math.Round(SAP_Module.OverHeat.AppendixP.P3.M7, 2));
      XFont xfont63 = xfont4;
      XSolidBrush black85 = XBrushes.Black;
      double rc1_83 = (double) SAPInput.RC1;
      xunit5 = PDFFunctions.pages[SAPInput.k].Width;
      double point91 = ((XUnit) ref xunit5).Point;
      xunit5 = PDFFunctions.pages[SAPInput.k].Height;
      double num125 = ((XUnit) ref xunit5).Point / 2.0;
      XRect xrect91 = new XRect(510.0, rc1_83, point91, num125);
      XStringFormat topLeft91 = XStringFormat.TopLeft;
      xgraphics91.DrawString(str37, xfont63, (XBrush) black85, xrect91, topLeft91);
      XGraphics xgraphics92 = PDFFunctions.gfx[SAPInput.k];
      XFont arialFont10Bold37 = PDFFunctions.ArialFont10Bold;
      XSolidBrush black86 = XBrushes.Black;
      double rc1_84 = (double) SAPInput.RC1;
      xunit5 = PDFFunctions.pages[SAPInput.k].Width;
      double point92 = ((XUnit) ref xunit5).Point;
      xunit5 = PDFFunctions.pages[SAPInput.k].Height;
      double num126 = ((XUnit) ref xunit5).Point / 2.0;
      XRect xrect92 = new XRect(550.0, rc1_84, point92, num126);
      XStringFormat topLeft92 = XStringFormat.TopLeft;
      xgraphics92.DrawString("(P3/P4)", arialFont10Bold37, (XBrush) black86, xrect92, topLeft92);
      checked { SAPInput.RC1 += 13; }
      checked { SAPInput.RC1 += 3; }
      PDFFunctions.xBrush1 = XBrush.op_Implicit((Brush) new SolidBrush(Color.FromArgb(159, 172, 62)));
      PDFFunctions.Points[0].X = 20f;
      PDFFunctions.Points[0].Y = (float) SAPInput.RC1;
      ref PointF local11 = ref PDFFunctions.Points[1];
      xunit5 = PDFFunctions.pages[SAPInput.k].Width;
      double num127 = ((XUnit) ref xunit5).Point - 20.0;
      local11.X = (float) num127;
      PDFFunctions.Points[1].Y = (float) SAPInput.RC1;
      ref PointF local12 = ref PDFFunctions.Points[2];
      xunit5 = PDFFunctions.pages[SAPInput.k].Width;
      double num128 = ((XUnit) ref xunit5).Point - 20.0;
      local12.X = (float) num128;
      PDFFunctions.Points[2].Y = (float) checked (SAPInput.RC1 + 14);
      PDFFunctions.Points[3].X = 20f;
      PDFFunctions.Points[3].Y = (float) checked (SAPInput.RC1 + 14);
      PDFFunctions.gfx[SAPInput.k].DrawPolygon(PDFFunctions.polyGreen2, PDFFunctions.xBrush1, PDFFunctions.Points, xfillMode);
      XGraphics xgraphics93 = PDFFunctions.gfx[SAPInput.k];
      XFont xfont64 = xfont3;
      XSolidBrush white7 = XBrushes.White;
      double num129 = (double) checked (SAPInput.RC1 + 1);
      xunit5 = PDFFunctions.pages[SAPInput.k].Width;
      double point93 = ((XUnit) ref xunit5).Point;
      xunit5 = PDFFunctions.pages[SAPInput.k].Height;
      double num130 = ((XUnit) ref xunit5).Point / 2.0;
      XRect xrect93 = new XRect(25.0, num129, point93, num130);
      XStringFormat topLeft93 = XStringFormat.TopLeft;
      xgraphics93.DrawString("Internal gains:", xfont64, (XBrush) white7, xrect93, topLeft93);
      SAPInput.RC1 = checked ((int) Math.Round(unchecked ((double) PDFFunctions.Points[3].Y + 15.0)));
      XGraphics xgraphics94 = PDFFunctions.gfx[SAPInput.k];
      XFont arialFont10Bold38 = PDFFunctions.ArialFont10Bold;
      XSolidBrush black87 = XBrushes.Black;
      double rc1_85 = (double) SAPInput.RC1;
      xunit5 = PDFFunctions.pages[SAPInput.k].Width;
      double point94 = ((XUnit) ref xunit5).Point;
      xunit5 = PDFFunctions.pages[SAPInput.k].Height;
      double num131 = ((XUnit) ref xunit5).Point / 2.0;
      XRect xrect94 = new XRect(310.0, rc1_85, point94, num131);
      XStringFormat topLeft94 = XStringFormat.TopLeft;
      xgraphics94.DrawString("June", arialFont10Bold38, (XBrush) black87, xrect94, topLeft94);
      XGraphics xgraphics95 = PDFFunctions.gfx[SAPInput.k];
      XFont arialFont10Bold39 = PDFFunctions.ArialFont10Bold;
      XSolidBrush black88 = XBrushes.Black;
      double rc1_86 = (double) SAPInput.RC1;
      xunit5 = PDFFunctions.pages[SAPInput.k].Width;
      double point95 = ((XUnit) ref xunit5).Point;
      xunit5 = PDFFunctions.pages[SAPInput.k].Height;
      double num132 = ((XUnit) ref xunit5).Point / 2.0;
      XRect xrect95 = new XRect(410.0, rc1_86, point95, num132);
      XStringFormat topLeft95 = XStringFormat.TopLeft;
      xgraphics95.DrawString("July", arialFont10Bold39, (XBrush) black88, xrect95, topLeft95);
      XGraphics xgraphics96 = PDFFunctions.gfx[SAPInput.k];
      XFont arialFont10Bold40 = PDFFunctions.ArialFont10Bold;
      XSolidBrush black89 = XBrushes.Black;
      double rc1_87 = (double) SAPInput.RC1;
      xunit5 = PDFFunctions.pages[SAPInput.k].Width;
      double point96 = ((XUnit) ref xunit5).Point;
      xunit5 = PDFFunctions.pages[SAPInput.k].Height;
      double num133 = ((XUnit) ref xunit5).Point / 2.0;
      XRect xrect96 = new XRect(510.0, rc1_87, point96, num133);
      XStringFormat topLeft96 = XStringFormat.TopLeft;
      xgraphics96.DrawString("August", arialFont10Bold40, (XBrush) black89, xrect96, topLeft96);
      checked { SAPInput.RC1 += 13; }
      XGraphics xgraphics97 = PDFFunctions.gfx[SAPInput.k];
      XFont xfont65 = xfont4;
      XSolidBrush black90 = XBrushes.Black;
      double rc1_88 = (double) SAPInput.RC1;
      xunit5 = PDFFunctions.pages[SAPInput.k].Width;
      double point97 = ((XUnit) ref xunit5).Point;
      xunit5 = PDFFunctions.pages[SAPInput.k].Height;
      double num134 = ((XUnit) ref xunit5).Point / 2.0;
      XRect xrect97 = new XRect(20.0, rc1_88, point97, num134);
      XStringFormat topLeft97 = XStringFormat.TopLeft;
      xgraphics97.DrawString("Internal gains", xfont65, (XBrush) black90, xrect97, topLeft97);
      XGraphics xgraphics98 = PDFFunctions.gfx[SAPInput.k];
      string str38 = Conversions.ToString(Math.Round(SAP_Module.OverHeat.AppendixP.P5.M6 - SAP_Module.OverHeat.AppendixP.P3.M6, 2));
      XFont xfont66 = xfont4;
      XSolidBrush black91 = XBrushes.Black;
      double rc1_89 = (double) SAPInput.RC1;
      xunit5 = PDFFunctions.pages[SAPInput.k].Width;
      double point98 = ((XUnit) ref xunit5).Point;
      xunit5 = PDFFunctions.pages[SAPInput.k].Height;
      double num135 = ((XUnit) ref xunit5).Point / 2.0;
      XRect xrect98 = new XRect(310.0, rc1_89, point98, num135);
      XStringFormat topLeft98 = XStringFormat.TopLeft;
      xgraphics98.DrawString(str38, xfont66, (XBrush) black91, xrect98, topLeft98);
      XGraphics xgraphics99 = PDFFunctions.gfx[SAPInput.k];
      string str39 = Conversions.ToString(Math.Round(SAP_Module.OverHeat.AppendixP.P5.M7 - SAP_Module.OverHeat.AppendixP.P3.M7, 2));
      XFont xfont67 = xfont4;
      XSolidBrush black92 = XBrushes.Black;
      double rc1_90 = (double) SAPInput.RC1;
      xunit5 = PDFFunctions.pages[SAPInput.k].Width;
      double point99 = ((XUnit) ref xunit5).Point;
      xunit5 = PDFFunctions.pages[SAPInput.k].Height;
      double num136 = ((XUnit) ref xunit5).Point / 2.0;
      XRect xrect99 = new XRect(410.0, rc1_90, point99, num136);
      XStringFormat topLeft99 = XStringFormat.TopLeft;
      xgraphics99.DrawString(str39, xfont67, (XBrush) black92, xrect99, topLeft99);
      XGraphics xgraphics100 = PDFFunctions.gfx[SAPInput.k];
      string str40 = Conversions.ToString(Math.Round(SAP_Module.OverHeat.AppendixP.P5.M8 - SAP_Module.OverHeat.AppendixP.P3.M8, 2));
      XFont xfont68 = xfont4;
      XSolidBrush black93 = XBrushes.Black;
      double rc1_91 = (double) SAPInput.RC1;
      xunit5 = PDFFunctions.pages[SAPInput.k].Width;
      double point100 = ((XUnit) ref xunit5).Point;
      xunit5 = PDFFunctions.pages[SAPInput.k].Height;
      double num137 = ((XUnit) ref xunit5).Point / 2.0;
      XRect xrect100 = new XRect(510.0, rc1_91, point100, num137);
      XStringFormat topLeft100 = XStringFormat.TopLeft;
      xgraphics100.DrawString(str40, xfont68, (XBrush) black93, xrect100, topLeft100);
      checked { SAPInput.RC1 += 13; }
      XGraphics xgraphics101 = PDFFunctions.gfx[SAPInput.k];
      XFont xfont69 = xfont4;
      XSolidBrush black94 = XBrushes.Black;
      double rc1_92 = (double) SAPInput.RC1;
      xunit5 = PDFFunctions.pages[SAPInput.k].Width;
      double point101 = ((XUnit) ref xunit5).Point;
      xunit5 = PDFFunctions.pages[SAPInput.k].Height;
      double num138 = ((XUnit) ref xunit5).Point / 2.0;
      XRect xrect101 = new XRect(20.0, rc1_92, point101, num138);
      XStringFormat topLeft101 = XStringFormat.TopLeft;
      xgraphics101.DrawString("Total summer gains", xfont69, (XBrush) black94, xrect101, topLeft101);
      XGraphics xgraphics102 = PDFFunctions.gfx[SAPInput.k];
      string str41 = Conversions.ToString(Math.Round(SAP_Module.OverHeat.AppendixP.P5.M6, 2));
      XFont xfont70 = xfont4;
      XSolidBrush black95 = XBrushes.Black;
      double rc1_93 = (double) SAPInput.RC1;
      xunit5 = PDFFunctions.pages[SAPInput.k].Width;
      double point102 = ((XUnit) ref xunit5).Point;
      xunit5 = PDFFunctions.pages[SAPInput.k].Height;
      double num139 = ((XUnit) ref xunit5).Point / 2.0;
      XRect xrect102 = new XRect(310.0, rc1_93, point102, num139);
      XStringFormat topLeft102 = XStringFormat.TopLeft;
      xgraphics102.DrawString(str41, xfont70, (XBrush) black95, xrect102, topLeft102);
      XGraphics xgraphics103 = PDFFunctions.gfx[SAPInput.k];
      string str42 = Conversions.ToString(Math.Round(SAP_Module.OverHeat.AppendixP.P5.M7, 2));
      XFont xfont71 = xfont4;
      XSolidBrush black96 = XBrushes.Black;
      double rc1_94 = (double) SAPInput.RC1;
      xunit5 = PDFFunctions.pages[SAPInput.k].Width;
      double point103 = ((XUnit) ref xunit5).Point;
      xunit5 = PDFFunctions.pages[SAPInput.k].Height;
      double num140 = ((XUnit) ref xunit5).Point / 2.0;
      XRect xrect103 = new XRect(410.0, rc1_94, point103, num140);
      XStringFormat topLeft103 = XStringFormat.TopLeft;
      xgraphics103.DrawString(str42, xfont71, (XBrush) black96, xrect103, topLeft103);
      XGraphics xgraphics104 = PDFFunctions.gfx[SAPInput.k];
      string str43 = Conversions.ToString(Math.Round(SAP_Module.OverHeat.AppendixP.P5.M8, 2));
      XFont xfont72 = xfont4;
      XSolidBrush black97 = XBrushes.Black;
      double rc1_95 = (double) SAPInput.RC1;
      xunit5 = PDFFunctions.pages[SAPInput.k].Width;
      double point104 = ((XUnit) ref xunit5).Point;
      xunit5 = PDFFunctions.pages[SAPInput.k].Height;
      double num141 = ((XUnit) ref xunit5).Point / 2.0;
      XRect xrect104 = new XRect(510.0, rc1_95, point104, num141);
      XStringFormat topLeft104 = XStringFormat.TopLeft;
      xgraphics104.DrawString(str43, xfont72, (XBrush) black97, xrect104, topLeft104);
      XGraphics xgraphics105 = PDFFunctions.gfx[SAPInput.k];
      XFont arialFont10Bold41 = PDFFunctions.ArialFont10Bold;
      XSolidBrush black98 = XBrushes.Black;
      double rc1_96 = (double) SAPInput.RC1;
      xunit5 = PDFFunctions.pages[SAPInput.k].Width;
      double point105 = ((XUnit) ref xunit5).Point;
      xunit5 = PDFFunctions.pages[SAPInput.k].Height;
      double num142 = ((XUnit) ref xunit5).Point / 2.0;
      XRect xrect105 = new XRect(550.0, rc1_96, point105, num142);
      XStringFormat topLeft105 = XStringFormat.TopLeft;
      xgraphics105.DrawString("(P5)", arialFont10Bold41, (XBrush) black98, xrect105, topLeft105);
      checked { SAPInput.RC1 += 13; }
      SAPInput.Check2RC1();
      XGraphics xgraphics106 = PDFFunctions.gfx[SAPInput.k];
      XFont xfont73 = xfont4;
      XSolidBrush black99 = XBrushes.Black;
      double rc1_97 = (double) SAPInput.RC1;
      xunit5 = PDFFunctions.pages[SAPInput.k].Width;
      double point106 = ((XUnit) ref xunit5).Point;
      xunit5 = PDFFunctions.pages[SAPInput.k].Height;
      double num143 = ((XUnit) ref xunit5).Point / 2.0;
      XRect xrect106 = new XRect(20.0, rc1_97, point106, num143);
      XStringFormat topLeft106 = XStringFormat.TopLeft;
      xgraphics106.DrawString("Summer gain/loss ratio", xfont73, (XBrush) black99, xrect106, topLeft106);
      XGraphics xgraphics107 = PDFFunctions.gfx[SAPInput.k];
      string str44 = Conversions.ToString(Math.Round(SAP_Module.OverHeat.AppendixP.P6.M6, 2));
      XFont xfont74 = xfont4;
      XSolidBrush black100 = XBrushes.Black;
      double rc1_98 = (double) SAPInput.RC1;
      xunit5 = PDFFunctions.pages[SAPInput.k].Width;
      double point107 = ((XUnit) ref xunit5).Point;
      xunit5 = PDFFunctions.pages[SAPInput.k].Height;
      double num144 = ((XUnit) ref xunit5).Point / 2.0;
      XRect xrect107 = new XRect(310.0, rc1_98, point107, num144);
      XStringFormat topLeft107 = XStringFormat.TopLeft;
      xgraphics107.DrawString(str44, xfont74, (XBrush) black100, xrect107, topLeft107);
      XGraphics xgraphics108 = PDFFunctions.gfx[SAPInput.k];
      string str45 = Conversions.ToString(Math.Round(SAP_Module.OverHeat.AppendixP.P6.M7, 2));
      XFont xfont75 = xfont4;
      XSolidBrush black101 = XBrushes.Black;
      double rc1_99 = (double) SAPInput.RC1;
      xunit5 = PDFFunctions.pages[SAPInput.k].Width;
      double point108 = ((XUnit) ref xunit5).Point;
      xunit5 = PDFFunctions.pages[SAPInput.k].Height;
      double num145 = ((XUnit) ref xunit5).Point / 2.0;
      XRect xrect108 = new XRect(410.0, rc1_99, point108, num145);
      XStringFormat topLeft108 = XStringFormat.TopLeft;
      xgraphics108.DrawString(str45, xfont75, (XBrush) black101, xrect108, topLeft108);
      XGraphics xgraphics109 = PDFFunctions.gfx[SAPInput.k];
      string str46 = Conversions.ToString(Math.Round(SAP_Module.OverHeat.AppendixP.P6.M8, 2));
      XFont xfont76 = xfont4;
      XSolidBrush black102 = XBrushes.Black;
      double rc1_100 = (double) SAPInput.RC1;
      xunit5 = PDFFunctions.pages[SAPInput.k].Width;
      double point109 = ((XUnit) ref xunit5).Point;
      xunit5 = PDFFunctions.pages[SAPInput.k].Height;
      double num146 = ((XUnit) ref xunit5).Point / 2.0;
      XRect xrect109 = new XRect(510.0, rc1_100, point109, num146);
      XStringFormat topLeft109 = XStringFormat.TopLeft;
      xgraphics109.DrawString(str46, xfont76, (XBrush) black102, xrect109, topLeft109);
      XGraphics xgraphics110 = PDFFunctions.gfx[SAPInput.k];
      XFont arialFont10Bold42 = PDFFunctions.ArialFont10Bold;
      XSolidBrush black103 = XBrushes.Black;
      double rc1_101 = (double) SAPInput.RC1;
      xunit5 = PDFFunctions.pages[SAPInput.k].Width;
      double point110 = ((XUnit) ref xunit5).Point;
      xunit5 = PDFFunctions.pages[SAPInput.k].Height;
      double num147 = ((XUnit) ref xunit5).Point / 2.0;
      XRect xrect110 = new XRect(550.0, rc1_101, point110, num147);
      XStringFormat topLeft110 = XStringFormat.TopLeft;
      xgraphics110.DrawString("(P6)", arialFont10Bold42, (XBrush) black103, xrect110, topLeft110);
      checked { SAPInput.RC1 += 13; }
      // ISSUE: reference to a compiler-generated method
      PCDF.RegionalData regionalData = SAP_Module.PCDFData.AppendixU.Where<PCDF.RegionalData>(new Func<PCDF.RegionalData, bool>(closure220_2._Lambda\u0024__0)).SingleOrDefault<PCDF.RegionalData>();
      XGraphics xgraphics111 = PDFFunctions.gfx[SAPInput.k];
      // ISSUE: reference to a compiler-generated field
      string str47 = "Mean summer external temperature  (" + SAP_Module.Proj.Dwellings[closure220_2.\u0024VB\u0024Local_House].Location + ")";
      XFont xfont77 = xfont4;
      XSolidBrush black104 = XBrushes.Black;
      double rc1_102 = (double) SAPInput.RC1;
      xunit5 = PDFFunctions.pages[SAPInput.k].Width;
      double point111 = ((XUnit) ref xunit5).Point;
      xunit5 = PDFFunctions.pages[SAPInput.k].Height;
      double num148 = ((XUnit) ref xunit5).Point / 2.0;
      XRect xrect111 = new XRect(20.0, rc1_102, point111, num148);
      XStringFormat topLeft111 = XStringFormat.TopLeft;
      xgraphics111.DrawString(str47, xfont77, (XBrush) black104, xrect111, topLeft111);
      XGraphics xgraphics112 = PDFFunctions.gfx[SAPInput.k];
      string str48 = Conversions.ToString(regionalData.TableU1.M6);
      XFont xfont78 = xfont4;
      XSolidBrush black105 = XBrushes.Black;
      double rc1_103 = (double) SAPInput.RC1;
      xunit5 = PDFFunctions.pages[SAPInput.k].Width;
      double point112 = ((XUnit) ref xunit5).Point;
      xunit5 = PDFFunctions.pages[SAPInput.k].Height;
      double num149 = ((XUnit) ref xunit5).Point / 2.0;
      XRect xrect112 = new XRect(310.0, rc1_103, point112, num149);
      XStringFormat topLeft112 = XStringFormat.TopLeft;
      xgraphics112.DrawString(str48, xfont78, (XBrush) black105, xrect112, topLeft112);
      XGraphics xgraphics113 = PDFFunctions.gfx[SAPInput.k];
      string str49 = Conversions.ToString(regionalData.TableU1.M7);
      XFont xfont79 = xfont4;
      XSolidBrush black106 = XBrushes.Black;
      double rc1_104 = (double) SAPInput.RC1;
      xunit5 = PDFFunctions.pages[SAPInput.k].Width;
      double point113 = ((XUnit) ref xunit5).Point;
      xunit5 = PDFFunctions.pages[SAPInput.k].Height;
      double num150 = ((XUnit) ref xunit5).Point / 2.0;
      XRect xrect113 = new XRect(410.0, rc1_104, point113, num150);
      XStringFormat topLeft113 = XStringFormat.TopLeft;
      xgraphics113.DrawString(str49, xfont79, (XBrush) black106, xrect113, topLeft113);
      XGraphics xgraphics114 = PDFFunctions.gfx[SAPInput.k];
      string str50 = Conversions.ToString(regionalData.TableU1.M8);
      XFont xfont80 = xfont4;
      XSolidBrush black107 = XBrushes.Black;
      double rc1_105 = (double) SAPInput.RC1;
      xunit5 = PDFFunctions.pages[SAPInput.k].Width;
      double point114 = ((XUnit) ref xunit5).Point;
      xunit5 = PDFFunctions.pages[SAPInput.k].Height;
      double num151 = ((XUnit) ref xunit5).Point / 2.0;
      XRect xrect114 = new XRect(510.0, rc1_105, point114, num151);
      XStringFormat topLeft114 = XStringFormat.TopLeft;
      xgraphics114.DrawString(str50, xfont80, (XBrush) black107, xrect114, topLeft114);
      checked { SAPInput.RC1 += 13; }
      SAPInput.Check2RC1();
      XGraphics xgraphics115 = PDFFunctions.gfx[SAPInput.k];
      XFont xfont81 = xfont4;
      XSolidBrush black108 = XBrushes.Black;
      double rc1_106 = (double) SAPInput.RC1;
      xunit5 = PDFFunctions.pages[SAPInput.k].Width;
      double point115 = ((XUnit) ref xunit5).Point;
      xunit5 = PDFFunctions.pages[SAPInput.k].Height;
      double num152 = ((XUnit) ref xunit5).Point / 2.0;
      XRect xrect115 = new XRect(20.0, rc1_106, point115, num152);
      XStringFormat topLeft115 = XStringFormat.TopLeft;
      xgraphics115.DrawString("Thermal mass temperature increment", xfont81, (XBrush) black108, xrect115, topLeft115);
      XGraphics xgraphics116 = PDFFunctions.gfx[SAPInput.k];
      string str51 = Conversions.ToString(Math.Round(SAP_Module.OverHeat.Tmass, 2));
      XFont xfont82 = xfont4;
      XSolidBrush black109 = XBrushes.Black;
      double rc1_107 = (double) SAPInput.RC1;
      xunit5 = PDFFunctions.pages[SAPInput.k].Width;
      double point116 = ((XUnit) ref xunit5).Point;
      xunit5 = PDFFunctions.pages[SAPInput.k].Height;
      double num153 = ((XUnit) ref xunit5).Point / 2.0;
      XRect xrect116 = new XRect(310.0, rc1_107, point116, num153);
      XStringFormat topLeft116 = XStringFormat.TopLeft;
      xgraphics116.DrawString(str51, xfont82, (XBrush) black109, xrect116, topLeft116);
      XGraphics xgraphics117 = PDFFunctions.gfx[SAPInput.k];
      string str52 = Conversions.ToString(Math.Round(SAP_Module.OverHeat.Tmass, 2));
      XFont xfont83 = xfont4;
      XSolidBrush black110 = XBrushes.Black;
      double rc1_108 = (double) SAPInput.RC1;
      xunit5 = PDFFunctions.pages[SAPInput.k].Width;
      double point117 = ((XUnit) ref xunit5).Point;
      xunit5 = PDFFunctions.pages[SAPInput.k].Height;
      double num154 = ((XUnit) ref xunit5).Point / 2.0;
      XRect xrect117 = new XRect(410.0, rc1_108, point117, num154);
      XStringFormat topLeft117 = XStringFormat.TopLeft;
      xgraphics117.DrawString(str52, xfont83, (XBrush) black110, xrect117, topLeft117);
      XGraphics xgraphics118 = PDFFunctions.gfx[SAPInput.k];
      string str53 = Conversions.ToString(Math.Round(SAP_Module.OverHeat.Tmass, 2));
      XFont xfont84 = xfont4;
      XSolidBrush black111 = XBrushes.Black;
      double rc1_109 = (double) SAPInput.RC1;
      xunit5 = PDFFunctions.pages[SAPInput.k].Width;
      double point118 = ((XUnit) ref xunit5).Point;
      xunit5 = PDFFunctions.pages[SAPInput.k].Height;
      double num155 = ((XUnit) ref xunit5).Point / 2.0;
      XRect xrect118 = new XRect(510.0, rc1_109, point118, num155);
      XStringFormat topLeft118 = XStringFormat.TopLeft;
      xgraphics118.DrawString(str53, xfont84, (XBrush) black111, xrect118, topLeft118);
      checked { SAPInput.RC1 += 13; }
      SAPInput.Check2RC1();
      XGraphics xgraphics119 = PDFFunctions.gfx[SAPInput.k];
      XFont xfont85 = xfont4;
      XSolidBrush black112 = XBrushes.Black;
      double rc1_110 = (double) SAPInput.RC1;
      xunit5 = PDFFunctions.pages[SAPInput.k].Width;
      double point119 = ((XUnit) ref xunit5).Point;
      xunit5 = PDFFunctions.pages[SAPInput.k].Height;
      double num156 = ((XUnit) ref xunit5).Point / 2.0;
      XRect xrect119 = new XRect(20.0, rc1_110, point119, num156);
      XStringFormat topLeft119 = XStringFormat.TopLeft;
      xgraphics119.DrawString("Threshold temperature", xfont85, (XBrush) black112, xrect119, topLeft119);
      XGraphics xgraphics120 = PDFFunctions.gfx[SAPInput.k];
      string str54 = Conversions.ToString(Math.Round(SAP_Module.OverHeat.AppendixP.P7.M6, 2));
      XFont xfont86 = xfont4;
      XSolidBrush black113 = XBrushes.Black;
      double rc1_111 = (double) SAPInput.RC1;
      xunit5 = PDFFunctions.pages[SAPInput.k].Width;
      double point120 = ((XUnit) ref xunit5).Point;
      xunit5 = PDFFunctions.pages[SAPInput.k].Height;
      double num157 = ((XUnit) ref xunit5).Point / 2.0;
      XRect xrect120 = new XRect(310.0, rc1_111, point120, num157);
      XStringFormat topLeft120 = XStringFormat.TopLeft;
      xgraphics120.DrawString(str54, xfont86, (XBrush) black113, xrect120, topLeft120);
      XGraphics xgraphics121 = PDFFunctions.gfx[SAPInput.k];
      string str55 = Conversions.ToString(Math.Round(SAP_Module.OverHeat.AppendixP.P7.M7, 2));
      XFont xfont87 = xfont4;
      XSolidBrush black114 = XBrushes.Black;
      double rc1_112 = (double) SAPInput.RC1;
      xunit5 = PDFFunctions.pages[SAPInput.k].Width;
      double point121 = ((XUnit) ref xunit5).Point;
      xunit5 = PDFFunctions.pages[SAPInput.k].Height;
      double num158 = ((XUnit) ref xunit5).Point / 2.0;
      XRect xrect121 = new XRect(410.0, rc1_112, point121, num158);
      XStringFormat topLeft121 = XStringFormat.TopLeft;
      xgraphics121.DrawString(str55, xfont87, (XBrush) black114, xrect121, topLeft121);
      XGraphics xgraphics122 = PDFFunctions.gfx[SAPInput.k];
      string str56 = Conversions.ToString(Math.Round(SAP_Module.OverHeat.AppendixP.P7.M8, 2));
      XFont xfont88 = xfont4;
      XSolidBrush black115 = XBrushes.Black;
      double rc1_113 = (double) SAPInput.RC1;
      xunit5 = PDFFunctions.pages[SAPInput.k].Width;
      double point122 = ((XUnit) ref xunit5).Point;
      xunit5 = PDFFunctions.pages[SAPInput.k].Height;
      double num159 = ((XUnit) ref xunit5).Point / 2.0;
      XRect xrect122 = new XRect(510.0, rc1_113, point122, num159);
      XStringFormat topLeft122 = XStringFormat.TopLeft;
      xgraphics122.DrawString(str56, xfont88, (XBrush) black115, xrect122, topLeft122);
      XGraphics xgraphics123 = PDFFunctions.gfx[SAPInput.k];
      XFont arialFont10Bold43 = PDFFunctions.ArialFont10Bold;
      XSolidBrush black116 = XBrushes.Black;
      double rc1_114 = (double) SAPInput.RC1;
      xunit5 = PDFFunctions.pages[SAPInput.k].Width;
      double point123 = ((XUnit) ref xunit5).Point;
      xunit5 = PDFFunctions.pages[SAPInput.k].Height;
      double num160 = ((XUnit) ref xunit5).Point / 2.0;
      XRect xrect123 = new XRect(550.0, rc1_114, point123, num160);
      XStringFormat topLeft123 = XStringFormat.TopLeft;
      xgraphics123.DrawString("(P7)", arialFont10Bold43, (XBrush) black116, xrect123, topLeft123);
      checked { SAPInput.RC1 += 13; }
      SAPInput.Check2RC1();
      XGraphics xgraphics124 = PDFFunctions.gfx[SAPInput.k];
      XFont arialFont10Bold44 = PDFFunctions.ArialFont10Bold;
      XSolidBrush black117 = XBrushes.Black;
      double rc1_115 = (double) SAPInput.RC1;
      xunit5 = PDFFunctions.pages[SAPInput.k].Width;
      double point124 = ((XUnit) ref xunit5).Point;
      xunit5 = PDFFunctions.pages[SAPInput.k].Height;
      double num161 = ((XUnit) ref xunit5).Point / 2.0;
      XRect xrect124 = new XRect(20.0, rc1_115, point124, num161);
      XStringFormat topLeft124 = XStringFormat.TopLeft;
      xgraphics124.DrawString("Likelihood of high internal temperature", arialFont10Bold44, (XBrush) black117, xrect124, topLeft124);
      try
      {
        XGraphics xgraphics125 = PDFFunctions.gfx[SAPInput.k];
        string likelihoodJune = SAP_Module.OverHeat.AppendixP.Likelihood_June;
        XFont arialFont10Bold45 = PDFFunctions.ArialFont10Bold;
        XSolidBrush black118 = XBrushes.Black;
        double rc1_116 = (double) SAPInput.RC1;
        xunit5 = PDFFunctions.pages[SAPInput.k].Width;
        double point125 = ((XUnit) ref xunit5).Point;
        xunit5 = PDFFunctions.pages[SAPInput.k].Height;
        double num162 = ((XUnit) ref xunit5).Point / 2.0;
        XRect xrect125 = new XRect(310.0, rc1_116, point125, num162);
        XStringFormat topLeft125 = XStringFormat.TopLeft;
        xgraphics125.DrawString(likelihoodJune, arialFont10Bold45, (XBrush) black118, xrect125, topLeft125);
        XGraphics xgraphics126 = PDFFunctions.gfx[SAPInput.k];
        string likelihoodJuly = SAP_Module.OverHeat.AppendixP.Likelihood_July;
        XFont arialFont10Bold46 = PDFFunctions.ArialFont10Bold;
        XSolidBrush black119 = XBrushes.Black;
        double rc1_117 = (double) SAPInput.RC1;
        xunit5 = PDFFunctions.pages[SAPInput.k].Width;
        double point126 = ((XUnit) ref xunit5).Point;
        xunit5 = PDFFunctions.pages[SAPInput.k].Height;
        double num163 = ((XUnit) ref xunit5).Point / 2.0;
        XRect xrect126 = new XRect(410.0, rc1_117, point126, num163);
        XStringFormat topLeft126 = XStringFormat.TopLeft;
        xgraphics126.DrawString(likelihoodJuly, arialFont10Bold46, (XBrush) black119, xrect126, topLeft126);
        XGraphics xgraphics127 = PDFFunctions.gfx[SAPInput.k];
        string likelihoodAug = SAP_Module.OverHeat.AppendixP.Likelihood_Aug;
        XFont arialFont10Bold47 = PDFFunctions.ArialFont10Bold;
        XSolidBrush black120 = XBrushes.Black;
        double rc1_118 = (double) SAPInput.RC1;
        xunit5 = PDFFunctions.pages[SAPInput.k].Width;
        double point127 = ((XUnit) ref xunit5).Point;
        xunit5 = PDFFunctions.pages[SAPInput.k].Height;
        double num164 = ((XUnit) ref xunit5).Point / 2.0;
        XRect xrect127 = new XRect(510.0, rc1_118, point127, num164);
        XStringFormat topLeft127 = XStringFormat.TopLeft;
        xgraphics127.DrawString(likelihoodAug, arialFont10Bold47, (XBrush) black120, xrect127, topLeft127);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      checked { SAPInput.RC1 += 26; }
      SAPInput.Check2RC1();
      XGraphics xgraphics128 = PDFFunctions.gfx[SAPInput.k];
      XFont arialFont10Bold48 = PDFFunctions.ArialFont10Bold;
      XSolidBrush black121 = XBrushes.Black;
      double rc1_119 = (double) SAPInput.RC1;
      XUnit xunit7 = PDFFunctions.pages[SAPInput.k].Width;
      double point128 = ((XUnit) ref xunit7).Point;
      xunit7 = PDFFunctions.pages[SAPInput.k].Height;
      double num165 = ((XUnit) ref xunit7).Point / 2.0;
      XRect xrect128 = new XRect(20.0, rc1_119, point128, num165);
      XStringFormat topLeft128 = XStringFormat.TopLeft;
      xgraphics128.DrawString("Assessment of likelihood of high internal temperature: ", arialFont10Bold48, (XBrush) black121, xrect128, topLeft128);
      XGraphics xgraphics129 = PDFFunctions.gfx[SAPInput.k];
      string likelihood = SAP_Module.OverHeat.AppendixP.Likelihood;
      XFont xfont89 = xfont1;
      XSolidBrush black122 = XBrushes.Black;
      double rc1_120 = (double) SAPInput.RC1;
      xunit7 = PDFFunctions.pages[SAPInput.k].Width;
      double point129 = ((XUnit) ref xunit7).Point;
      xunit7 = PDFFunctions.pages[SAPInput.k].Height;
      double num166 = ((XUnit) ref xunit7).Point / 2.0;
      XRect xrect129 = new XRect(310.0, rc1_120, point129, num166);
      XStringFormat topLeft129 = XStringFormat.TopLeft;
      xgraphics129.DrawString(likelihood, xfont89, (XBrush) black122, xrect129, topLeft129);
      int num167 = checked (SAPInput.k + 1);
      XFont xfont90 = new XFont("Arial", 160.0, (XFontStyle) 1);
      PDFFunctions.transbrush = XBrush.op_Implicit((Brush) new SolidBrush(Color.FromArgb(128, Color.Olive)));
      int k = SAPInput.k;
      int index8 = 0;
      while (index8 <= k)
      {
        if (!Validation.UserLogged)
        {
          XGraphics xgraphics130 = PDFFunctions.gfx[index8];
          XFont xfont91 = xfont90;
          XBrush transbrush = PDFFunctions.transbrush;
          xunit7 = PDFFunctions.pages[SAPInput.k].Width;
          double point130 = ((XUnit) ref xunit7).Point;
          xunit7 = PDFFunctions.pages[SAPInput.k].Height;
          double point131 = ((XUnit) ref xunit7).Point;
          XRect xrect130 = new XRect(0.0, 0.0, point130, point131);
          XStringFormat center = XStringFormat.Center;
          xgraphics130.DrawString("DRAFT", xfont91, transbrush, xrect130, center);
        }
        if (!SAP_Module.Proj.OverRide)
        {
          XGraphics xgraphics131 = PDFFunctions.gfx[index8];
          string str57 = "Stroma FSAP 2012 " + SAP_Module.CurrVersion + " (SAP 9.92) - http://www.stroma.com";
          XFont xfont92 = xfont8;
          XSolidBrush black123 = XBrushes.Black;
          xunit7 = PDFFunctions.pages[SAPInput.k].Width;
          double point132 = ((XUnit) ref xunit7).Point;
          xunit7 = PDFFunctions.pages[SAPInput.k].Height;
          double point133 = ((XUnit) ref xunit7).Point;
          XRect xrect131 = new XRect(20.0, 820.0, point132, point133);
          XStringFormat topLeft130 = XStringFormat.TopLeft;
          xgraphics131.DrawString(str57, xfont92, (XBrush) black123, xrect131, topLeft130);
        }
        else
        {
          XGraphics xgraphics132 = PDFFunctions.gfx[index8];
          string str58 = "Stroma FSAP 2012 " + SAP_Module.Proj.CalcVersion + " (SAP 9.92) - http://www.stroma.com";
          XFont xfont93 = xfont8;
          XSolidBrush black124 = XBrushes.Black;
          xunit7 = PDFFunctions.pages[SAPInput.k].Width;
          double point134 = ((XUnit) ref xunit7).Point;
          xunit7 = PDFFunctions.pages[SAPInput.k].Height;
          double point135 = ((XUnit) ref xunit7).Point;
          XRect xrect132 = new XRect(20.0, 820.0, point134, point135);
          XStringFormat topLeft131 = XStringFormat.TopLeft;
          xgraphics132.DrawString(str58, xfont93, (XBrush) black124, xrect132, topLeft131);
        }
        XGraphics xgraphics133 = PDFFunctions.gfx[index8];
        string str59 = "Page  " + Conversions.ToString(checked (index8 + 1)) + " of " + Conversions.ToString(num167);
        XFont xfont94 = xfont8;
        XSolidBrush black125 = XBrushes.Black;
        xunit7 = PDFFunctions.pages[index8].Width;
        double point136 = ((XUnit) ref xunit7).Point;
        xunit7 = PDFFunctions.pages[index8].Height;
        double point137 = ((XUnit) ref xunit7).Point;
        XRect xrect133 = new XRect(520.0, 820.0, point136, point137);
        XStringFormat topLeft132 = XStringFormat.TopLeft;
        xgraphics133.DrawString(str59, xfont94, (XBrush) black125, xrect133, topLeft132);
        checked { ++index8; }
      }
      SAP_Module.SAPOverHeatingName = "";
      object folderPath = (object) Environment.GetFolderPath(Environment.SpecialFolder.Personal);
      DirectoryInfo directoryInfo1 = new DirectoryInfo(Conversions.ToString(Operators.ConcatenateObject(folderPath, (object) "\\Stroma SAP 2012")));
      DirectoryInfo directoryInfo2 = new DirectoryInfo(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(folderPath, (object) "\\Stroma SAP 2012\\"), (object) SAP_Module.Proj.Name)));
      DirectoryInfo directoryInfo3 = new DirectoryInfo(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(folderPath, (object) "\\Stroma SAP 2012\\"), (object) SAP_Module.Proj.Name), (object) "\\"), (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Name)));
      SAP_Module.SAPOverHeatingName = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(folderPath, (object) "\\Stroma SAP 2012\\"), (object) SAP_Module.Proj.Name), (object) "\\"), (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Name), (object) "\\"), (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Name), (object) "-SAP Overheating"), (object) ".pdf"));
      PDFFunctions.document.Save(SAP_Module.SAPOverHeatingName);
    }

    private static void Check2RC1()
    {
      if (SAPInput.RC1 < 750)
        return;
      SAPInput.CreateNewPage2();
    }

    private static void CreateNewPage2()
    {
      checked { ++SAPInput.k; }
      PDFFunctions.pages[SAPInput.k] = PDFFunctions.document.AddPage();
      PDFFunctions.gfx[SAPInput.k] = XGraphics.FromPdfPage(PDFFunctions.pages[SAPInput.k]);
      XSize xsize = PDFFunctions.gfx[SAPInput.k].PageSize;
      double num1 = ((XSize) ref xsize).Width / 2.0;
      xsize = PDFFunctions.gfx[SAPInput.k].MeasureString("SAP 2012 Overheating Assessment", PDFFunctions.ArialFont16Bold);
      double num2 = ((XSize) ref xsize).Width / 2.0;
      int num3 = checked ((int) Math.Round(unchecked (num1 - num2)));
      XGraphics xgraphics = PDFFunctions.gfx[SAPInput.k];
      XFont arialFont16Bold = PDFFunctions.ArialFont16Bold;
      XSolidBrush black = XBrushes.Black;
      XUnit xunit = PDFFunctions.pages[SAPInput.k].Width;
      double point = ((XUnit) ref xunit).Point;
      xunit = PDFFunctions.pages[SAPInput.k].Height;
      double num4 = ((XUnit) ref xunit).Point / 2.0;
      XRect xrect = new XRect(120.0, 30.0, point, num4);
      XStringFormat topLeft = XStringFormat.TopLeft;
      xgraphics.DrawString("SAP 2012 Overheating Assessment", arialFont16Bold, (XBrush) black, xrect, topLeft);
      string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\Stroma SAP 2012\\";
      if (!Directory.Exists(path))
        Directory.CreateDirectory(path);
      if (File.Exists(path + "Logo.jpg"))
      {
        Image image = Image.FromFile(path + "Logo.jpg");
        int num5;
        int num6;
        int num7;
        int num8;
        if ((double) image.Width / (double) image.Height > 5.0 / 3.0)
        {
          num5 = 475;
          num6 = 100;
          num7 = checked ((int) Math.Round((double) SAPInput.ImageY));
          num8 = checked ((int) Math.Round(unchecked ((double) checked (image.Height * 100) / (double) image.Width)));
        }
        else
        {
          num7 = checked ((int) Math.Round((double) SAPInput.ImageY));
          num8 = 60;
          num5 = checked ((int) Math.Round(unchecked (575.0 - (double) image.Width / (double) image.Height * 60.0)));
          num6 = checked ((int) Math.Round(unchecked ((double) image.Width / (double) image.Height * 60.0)));
        }
        PDFFunctions.gfx[SAPInput.k].DrawImage(XImage.op_Implicit(image), num5, num7, num6, num8);
        image.Dispose();
      }
      if (UserSettings.USettings.PrintUserSettings.Print)
        PDFFunctions.PrintUserDetails(PDFFunctions.gfx[SAPInput.k]);
      SAPInput.RC1 = 70;
    }

    public static void CreateZeroCarbon(int House)
    {
    }

    public static string CodeReport(int House)
    {
      XFont xfont1 = new XFont("Tahoma", 12.0, (XFontStyle) 1);
      XFont xfont2 = new XFont("Tahoma", 11.0, (XFontStyle) 0);
      XFont xfont3 = new XFont("Tahoma", 10.0, (XFontStyle) 0);
      XFont xfont4 = new XFont("Tahoma", 16.0, (XFontStyle) 1);
      XFont xfont5 = new XFont("Tahoma", 11.0, (XFontStyle) 1);
      XFont xfont6 = new XFont("Tahoma", 8.0, (XFontStyle) 1);
      XFont xfont7 = new XFont("Tahoma", 8.0, (XFontStyle) 0);
      XFont xfont8 = new XFont("Tahoma", 6.0, (XFontStyle) 0);
      XPen xpen1 = new XPen(XColor.FromArgb(0, 115, 187));
      XPen xpen2 = new XPen(XColor.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue));
      XPen xpen3 = new XPen(XColor.FromArgb(0, 0, (int) byte.MaxValue));
      SAP_Module.DoCodereport = true;
      SAPInput.k = 0;
      SAP_Module.CalcualtionDER_CSH.DTER = true;
      Functions.GetDERDwelling_CSH("Standard");
      SAP_Module.CalcualtionDER_CSH.Dwelling = SAP_Module.DERDwelling_CSH;
      double num1 = SAP_Module.CalcualtionDER_CSH.Calculation.CO2_Emissions_12a.Box273 != 0.0 ? SAP_Module.CalcualtionDER_CSH.Calculation.CO2_Emissions_12a.Box273 : SAP_Module.CalcualtionDER_CSH.Calculation.CO2_Emissions_12b.Box384;
      SAP_Module.CalcualtionDER_CSH.DTER = true;
      Functions.GetDERDwelling_CSH("Actual");
      SAP_Module.CalcualtionDER_CSH.Dwelling = SAP_Module.DERDwelling_CSH;
      double num2 = SAP_Module.CalcualtionDER_CSH.Calculation.CO2_Emissions_12a.Box273 != 0.0 ? SAP_Module.CalcualtionDER_CSH.Calculation.CO2_Emissions_12a.Box273 : SAP_Module.CalcualtionDER_CSH.Calculation.CO2_Emissions_12b.Box384;
      string zerocarbonEpc;
      try
      {
        double num3 = Functions.TER();
        double num4 = SAP_Module.CalcualtionDER2012.Calculation.CO2_Emissions_12a.Box273 != 0.0 ? SAP_Module.CalcualtionDER2012.Calculation.CO2_Emissions_12a.Box273 : SAP_Module.CalcualtionDER2012.Calculation.CO2_Emissions_12b.Box384;
        SAPInput.Address[0] = SAP_Module.Proj.Dwellings[House].Address.Line1;
        SAPInput.Address[1] = SAP_Module.Proj.Dwellings[House].Address.Line2;
        SAPInput.Address[2] = SAP_Module.Proj.Dwellings[House].Address.Line3;
        SAPInput.Address[3] = SAP_Module.Proj.Dwellings[House].Address.City;
        SAPInput.Address[4] = SAP_Module.Proj.Dwellings[House].Address.PostCost;
        PDFFunctions.document = new PdfDocument();
        PDFFunctions.pages[SAPInput.k] = PDFFunctions.document.AddPage();
        PDFFunctions.gfx[SAPInput.k] = XGraphics.FromPdfPage(PDFFunctions.pages[SAPInput.k]);
        XSize pageSize1 = PDFFunctions.gfx[SAPInput.k].PageSize;
        double num5 = ((XSize) ref pageSize1).Width / 2.0;
        XSize xsize1 = PDFFunctions.gfx[SAPInput.k].MeasureString("Code for Sustainable Homes Report", PDFFunctions.ArialFont16Bold);
        double num6 = ((XSize) ref xsize1).Width / 2.0;
        int num7 = checked ((int) Math.Round(unchecked (num5 - num6)));
        XGraphics xgraphics1 = PDFFunctions.gfx[SAPInput.k];
        XFont arialFont16Bold = PDFFunctions.ArialFont16Bold;
        XSolidBrush black1 = XBrushes.Black;
        double num8 = (double) num7;
        XUnit width1 = PDFFunctions.pages[SAPInput.k].Width;
        double point1 = ((XUnit) ref width1).Point;
        XUnit xunit = PDFFunctions.pages[SAPInput.k].Height;
        double num9 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect1 = new XRect(num8, 20.0, point1, num9);
        XStringFormat topLeft1 = XStringFormat.TopLeft;
        xgraphics1.DrawString("Code for Sustainable Homes Report", arialFont16Bold, (XBrush) black1, xrect1, topLeft1);
        XGraphics xgraphics2 = PDFFunctions.gfx[SAPInput.k];
        string str1 = "For use with Nov 2010 addendum 2014 " + SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Address.Country;
        XFont xfont9 = xfont1;
        XSolidBrush black2 = XBrushes.Black;
        double num10 = (double) num7;
        xunit = PDFFunctions.pages[SAPInput.k].Width;
        double point2 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[SAPInput.k].Height;
        double num11 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect2 = new XRect(num10, 35.0, point2, num11);
        XStringFormat topLeft2 = XStringFormat.TopLeft;
        xgraphics2.DrawString(str1, xfont9, (XBrush) black2, xrect2, topLeft2);
        string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\Stroma SAP 2012\\";
        if (!Directory.Exists(path))
          Directory.CreateDirectory(path);
        if (File.Exists(path + "Logo.jpg"))
        {
          Image image = Image.FromFile(path + "Logo.jpg");
          int num12;
          int num13;
          int num14;
          int num15;
          if ((double) image.Width / (double) image.Height > 5.0 / 3.0)
          {
            num12 = 475;
            num13 = 100;
            num14 = checked ((int) Math.Round((double) SAPInput.ImageY));
            num15 = checked ((int) Math.Round(unchecked ((double) checked (image.Height * 100) / (double) image.Width)));
          }
          else
          {
            num14 = checked ((int) Math.Round((double) SAPInput.ImageY));
            num15 = 60;
            num12 = checked ((int) Math.Round(unchecked (575.0 - (double) image.Width / (double) image.Height * 60.0)));
            num13 = checked ((int) Math.Round(unchecked ((double) image.Width / (double) image.Height * 60.0)));
          }
          PDFFunctions.gfx[SAPInput.k].DrawImage(XImage.op_Implicit(image), num12, num14, num13, num15);
          image.Dispose();
        }
        if (UserSettings.USettings.PrintUserSettings.Print)
          PDFFunctions.PrintUserDetails(PDFFunctions.gfx[SAPInput.k]);
        SAPInput.RC1 = 65;
        PDFFunctions.xBrush1 = XBrush.op_Implicit((Brush) new SolidBrush(Color.FromArgb(159, 172, 62)));
        PDFFunctions.Points[0].X = 20f;
        PDFFunctions.Points[0].Y = (float) SAPInput.RC1;
        ref PointF local1 = ref PDFFunctions.Points[1];
        xunit = PDFFunctions.pages[SAPInput.k].Width;
        double num16 = ((XUnit) ref xunit).Point - 20.0;
        local1.X = (float) num16;
        PDFFunctions.Points[1].Y = (float) SAPInput.RC1;
        ref PointF local2 = ref PDFFunctions.Points[2];
        xunit = PDFFunctions.pages[SAPInput.k].Width;
        double num17 = ((XUnit) ref xunit).Point - 20.0;
        local2.X = (float) num17;
        PDFFunctions.Points[2].Y = (float) checked (SAPInput.RC1 + 15);
        PDFFunctions.Points[3].X = 20f;
        PDFFunctions.Points[3].Y = (float) checked (SAPInput.RC1 + 15);
        XFillMode xfillMode;
        PDFFunctions.gfx[SAPInput.k].DrawPolygon(PDFFunctions.polyGreen2, PDFFunctions.xBrush1, PDFFunctions.Points, xfillMode);
        XGraphics xgraphics3 = PDFFunctions.gfx[SAPInput.k];
        XFont arialFont10Bold1 = PDFFunctions.ArialFont10Bold;
        XSolidBrush white1 = XBrushes.White;
        double num18 = (double) checked (SAPInput.RC1 + 1);
        xunit = PDFFunctions.pages[SAPInput.k].Width;
        double point3 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[SAPInput.k].Height;
        double num19 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect3 = new XRect(25.0, num18, point3, num19);
        XStringFormat topLeft3 = XStringFormat.TopLeft;
        xgraphics3.DrawString("Assessor and House Details", arialFont10Bold1, (XBrush) white1, xrect3, topLeft3);
        SAPInput.RC1 = checked ((int) Math.Round(unchecked ((double) PDFFunctions.Points[3].Y + 5.0)));
        XGraphics xgraphics4 = PDFFunctions.gfx[SAPInput.k];
        XFont arialFont10Bold2 = PDFFunctions.ArialFont10Bold;
        XSolidBrush black3 = XBrushes.Black;
        double num20 = (double) checked (SAPInput.RC1 + 1);
        xunit = PDFFunctions.pages[SAPInput.k].Width;
        double point4 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[SAPInput.k].Height;
        double num21 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect4 = new XRect(20.0, num20, point4, num21);
        XStringFormat topLeft4 = XStringFormat.TopLeft;
        xgraphics4.DrawString("Assessor Name:", arialFont10Bold2, (XBrush) black3, xrect4, topLeft4);
        XGraphics xgraphics5 = PDFFunctions.gfx[SAPInput.k];
        XFont arialFont10Bold3 = PDFFunctions.ArialFont10Bold;
        XSolidBrush black4 = XBrushes.Black;
        XSize pageSize2 = PDFFunctions.gfx[SAPInput.k].PageSize;
        double num22 = ((XSize) ref pageSize2).Width / 2.0;
        double num23 = (double) checked (SAPInput.RC1 + 1);
        xunit = PDFFunctions.pages[SAPInput.k].Width;
        double point5 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[SAPInput.k].Height;
        double num24 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect5 = new XRect(num22, num23, point5, num24);
        XStringFormat topLeft5 = XStringFormat.TopLeft;
        xgraphics5.DrawString("Assessor Number:", arialFont10Bold3, (XBrush) black4, xrect5, topLeft5);
        if (Validation.AssessorFN != null)
        {
          XGraphics xgraphics6 = PDFFunctions.gfx[SAPInput.k];
          string str2 = Validation.AssessorFN + " " + Validation.AssessorLN;
          XFont xfont10 = xfont3;
          XSolidBrush black5 = XBrushes.Black;
          XSize pageSize3 = PDFFunctions.gfx[SAPInput.k].PageSize;
          double num25 = ((XSize) ref pageSize3).Width / 4.0;
          double num26 = (double) checked (SAPInput.RC1 + 1);
          xunit = PDFFunctions.pages[SAPInput.k].Width;
          double point6 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[SAPInput.k].Height;
          double num27 = ((XUnit) ref xunit).Point / 2.0;
          XRect xrect6 = new XRect(num25, num26, point6, num27);
          XStringFormat topLeft6 = XStringFormat.TopLeft;
          xgraphics6.DrawString(str2, xfont10, (XBrush) black5, xrect6, topLeft6);
        }
        if (Validation.AssessorNO != null)
        {
          XGraphics xgraphics7 = PDFFunctions.gfx[SAPInput.k];
          string assessorNo = Validation.AssessorNO;
          XFont xfont11 = xfont3;
          XSolidBrush black6 = XBrushes.Black;
          XSize pageSize4 = PDFFunctions.gfx[SAPInput.k].PageSize;
          double num28 = 3.0 * ((XSize) ref pageSize4).Width / 4.0;
          double num29 = (double) checked (SAPInput.RC1 + 1);
          xunit = PDFFunctions.pages[SAPInput.k].Width;
          double point7 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[SAPInput.k].Height;
          double num30 = ((XUnit) ref xunit).Point / 2.0;
          XRect xrect7 = new XRect(num28, num29, point7, num30);
          XStringFormat topLeft7 = XStringFormat.TopLeft;
          xgraphics7.DrawString(assessorNo, xfont11, (XBrush) black6, xrect7, topLeft7);
        }
        checked { SAPInput.RC1 += 12; }
        XGraphics xgraphics8 = PDFFunctions.gfx[SAPInput.k];
        XFont arialFont10Bold4 = PDFFunctions.ArialFont10Bold;
        XSolidBrush black7 = XBrushes.Black;
        double num31 = (double) checked (SAPInput.RC1 + 1);
        xunit = PDFFunctions.pages[SAPInput.k].Width;
        double point8 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[SAPInput.k].Height;
        double num32 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect8 = new XRect(20.0, num31, point8, num32);
        XStringFormat topLeft8 = XStringFormat.TopLeft;
        xgraphics8.DrawString("Property Address:", arialFont10Bold4, (XBrush) black7, xrect8, topLeft8);
        int index1 = 0;
        do
        {
          if ((uint) Operators.CompareString(SAPInput.Address[index1], "", false) > 0U)
          {
            XGraphics xgraphics9 = PDFFunctions.gfx[SAPInput.k];
            string str3 = SAPInput.Address[index1];
            XFont xfont12 = xfont2;
            XSolidBrush black8 = XBrushes.Black;
            XSize pageSize5 = PDFFunctions.gfx[SAPInput.k].PageSize;
            double num33 = ((XSize) ref pageSize5).Width / 4.0;
            double rc1 = (double) SAPInput.RC1;
            xunit = PDFFunctions.pages[SAPInput.k].Width;
            double num34 = ((XUnit) ref xunit).Point / 4.0;
            xunit = PDFFunctions.pages[SAPInput.k].Height;
            double num35 = ((XUnit) ref xunit).Point / 4.0;
            XRect xrect9 = new XRect(num33, rc1, num34, num35);
            XStringFormat topLeft9 = XStringFormat.TopLeft;
            xgraphics9.DrawString(str3, xfont12, (XBrush) black8, xrect9, topLeft9);
            checked { SAPInput.RC1 += 12; }
          }
          checked { ++index1; }
        }
        while (index1 <= 4);
        checked { SAPInput.RC1 += 12; }
        PDFFunctions.xBrush1 = XBrush.op_Implicit((Brush) new SolidBrush(Color.FromArgb(159, 172, 62)));
        PDFFunctions.Points[0].X = 20f;
        PDFFunctions.Points[0].Y = (float) SAPInput.RC1;
        ref PointF local3 = ref PDFFunctions.Points[1];
        xunit = PDFFunctions.pages[SAPInput.k].Width;
        double num36 = ((XUnit) ref xunit).Point - 20.0;
        local3.X = (float) num36;
        PDFFunctions.Points[1].Y = (float) SAPInput.RC1;
        ref PointF local4 = ref PDFFunctions.Points[2];
        xunit = PDFFunctions.pages[SAPInput.k].Width;
        double num37 = ((XUnit) ref xunit).Point - 20.0;
        local4.X = (float) num37;
        PDFFunctions.Points[2].Y = (float) checked (SAPInput.RC1 + 15);
        PDFFunctions.Points[3].X = 20f;
        PDFFunctions.Points[3].Y = (float) checked (SAPInput.RC1 + 15);
        PDFFunctions.gfx[SAPInput.k].DrawPolygon(PDFFunctions.polyGreen2, PDFFunctions.xBrush1, PDFFunctions.Points, xfillMode);
        XGraphics xgraphics10 = PDFFunctions.gfx[SAPInput.k];
        XFont arialFont10Bold5 = PDFFunctions.ArialFont10Bold;
        XSolidBrush white2 = XBrushes.White;
        double num38 = (double) checked (SAPInput.RC1 + 1);
        xunit = PDFFunctions.pages[SAPInput.k].Width;
        double point9 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[SAPInput.k].Height;
        double num39 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect10 = new XRect(25.0, num38, point9, num39);
        XStringFormat topLeft10 = XStringFormat.TopLeft;
        xgraphics10.DrawString("Buiding regulation assessment", arialFont10Bold5, (XBrush) white2, xrect10, topLeft10);
        SAPInput.RC1 = checked ((int) Math.Round(unchecked ((double) PDFFunctions.Points[3].Y + 5.0)));
        XGraphics xgraphics11 = PDFFunctions.gfx[SAPInput.k];
        XFont arialFont10Bold6 = PDFFunctions.ArialFont10Bold;
        XSolidBrush black9 = XBrushes.Black;
        double rc1_1 = (double) SAPInput.RC1;
        xunit = PDFFunctions.pages[SAPInput.k].Width;
        double point10 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[SAPInput.k].Height;
        double num40 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect11 = new XRect(450.0, rc1_1, point10, num40);
        XStringFormat topLeft11 = XStringFormat.TopLeft;
        xgraphics11.DrawString("kg/m\u00B2/year", arialFont10Bold6, (XBrush) black9, xrect11, topLeft11);
        checked { SAPInput.RC1 += 12; }
        XGraphics xgraphics12 = PDFFunctions.gfx[SAPInput.k];
        string str4 = Conversions.ToString(Math.Round(num3, 2));
        XFont xfont13 = xfont3;
        XSolidBrush black10 = XBrushes.Black;
        double rc1_2 = (double) SAPInput.RC1;
        xunit = PDFFunctions.pages[SAPInput.k].Width;
        double point11 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[SAPInput.k].Height;
        double num41 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect12 = new XRect(450.0, rc1_2, point11, num41);
        XStringFormat topLeft12 = XStringFormat.TopLeft;
        xgraphics12.DrawString(str4, xfont13, (XBrush) black10, xrect12, topLeft12);
        XGraphics xgraphics13 = PDFFunctions.gfx[SAPInput.k];
        XFont xfont14 = xfont3;
        XSolidBrush black11 = XBrushes.Black;
        double rc1_3 = (double) SAPInput.RC1;
        xunit = PDFFunctions.pages[SAPInput.k].Width;
        double point12 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[SAPInput.k].Height;
        double num42 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect13 = new XRect(20.0, rc1_3, point12, num42);
        XStringFormat topLeft13 = XStringFormat.TopLeft;
        xgraphics13.DrawString("TER", xfont14, (XBrush) black11, xrect13, topLeft13);
        checked { SAPInput.RC1 += 12; }
        XGraphics xgraphics14 = PDFFunctions.gfx[SAPInput.k];
        XFont xfont15 = xfont3;
        XSolidBrush black12 = XBrushes.Black;
        double rc1_4 = (double) SAPInput.RC1;
        xunit = PDFFunctions.pages[SAPInput.k].Width;
        double point13 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[SAPInput.k].Height;
        double num43 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect14 = new XRect(20.0, rc1_4, point13, num43);
        XStringFormat topLeft14 = XStringFormat.TopLeft;
        xgraphics14.DrawString("DER", xfont15, (XBrush) black12, xrect14, topLeft14);
        XGraphics xgraphics15 = PDFFunctions.gfx[SAPInput.k];
        string str5 = Conversions.ToString(Math.Round(num4, 2));
        XFont xfont16 = xfont3;
        XSolidBrush black13 = XBrushes.Black;
        double rc1_5 = (double) SAPInput.RC1;
        xunit = PDFFunctions.pages[SAPInput.k].Width;
        double point14 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[SAPInput.k].Height;
        double num44 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect15 = new XRect(450.0, rc1_5, point14, num44);
        XStringFormat topLeft15 = XStringFormat.TopLeft;
        xgraphics15.DrawString(str5, xfont16, (XBrush) black13, xrect15, topLeft15);
        checked { SAPInput.RC1 += 12; }
        int y1 = checked (SAPInput.RC1 + 47);
        XSize pageSize6 = PDFFunctions.gfx[SAPInput.k].PageSize;
        int width2 = checked ((int) Math.Round(unchecked (((XSize) ref pageSize6).Width / 2.0 + 100.0)));
        Rectangle rectangle1 = new Rectangle(20, y1, width2, 112);
        XLinearGradientBrush xlinearGradientBrush1 = new XLinearGradientBrush(rectangle1, XColor.op_Implicit(Color.FromArgb(215, 217, 182)), XColor.op_Implicit(Color.White), (XLinearGradientMode) 0);
        PDFFunctions.gfx[SAPInput.k].DrawRectangle(XPen.op_Implicit(new Pen(Color.White, 0.0f)), (XBrush) xlinearGradientBrush1, rectangle1);
        int y2 = checked (SAPInput.RC1 + 59 + 144);
        XSize pageSize7 = PDFFunctions.gfx[SAPInput.k].PageSize;
        int width3 = checked ((int) Math.Round(unchecked (((XSize) ref pageSize7).Width / 2.0 + 160.0)));
        Rectangle rectangle2 = new Rectangle(20, y2, width3, 64);
        XLinearGradientBrush xlinearGradientBrush2 = new XLinearGradientBrush(rectangle2, XColor.op_Implicit(Color.FromArgb(215, 217, 182)), XColor.op_Implicit(Color.White), (XLinearGradientMode) 0);
        PDFFunctions.gfx[SAPInput.k].DrawRectangle(XPen.op_Implicit(new Pen(Color.White, 0.0f)), (XBrush) xlinearGradientBrush2, rectangle2);
        PDFFunctions.xBrush1 = XBrush.op_Implicit((Brush) new SolidBrush(Color.FromArgb(159, 172, 62)));
        PDFFunctions.Points[0].X = 20f;
        PDFFunctions.Points[0].Y = (float) SAPInput.RC1;
        ref PointF local5 = ref PDFFunctions.Points[1];
        xunit = PDFFunctions.pages[SAPInput.k].Width;
        double num45 = ((XUnit) ref xunit).Point - 20.0;
        local5.X = (float) num45;
        PDFFunctions.Points[1].Y = (float) SAPInput.RC1;
        ref PointF local6 = ref PDFFunctions.Points[2];
        xunit = PDFFunctions.pages[SAPInput.k].Width;
        double num46 = ((XUnit) ref xunit).Point - 20.0;
        local6.X = (float) num46;
        PDFFunctions.Points[2].Y = (float) checked (SAPInput.RC1 + 15);
        PDFFunctions.Points[3].X = 20f;
        PDFFunctions.Points[3].Y = (float) checked (SAPInput.RC1 + 15);
        PDFFunctions.gfx[SAPInput.k].DrawPolygon(PDFFunctions.polyGreen2, PDFFunctions.xBrush1, PDFFunctions.Points, xfillMode);
        XGraphics xgraphics16 = PDFFunctions.gfx[SAPInput.k];
        XFont arialFont10Bold7 = PDFFunctions.ArialFont10Bold;
        XSolidBrush white3 = XBrushes.White;
        double num47 = (double) checked (SAPInput.RC1 + 1);
        xunit = PDFFunctions.pages[SAPInput.k].Width;
        double point15 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[SAPInput.k].Height;
        double num48 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect16 = new XRect(25.0, num47, point15, num48);
        XStringFormat topLeft16 = XStringFormat.TopLeft;
        xgraphics16.DrawString("ENE 1 Assessment - Dwelling Emission Rate", arialFont10Bold7, (XBrush) white3, xrect16, topLeft16);
        SAPInput.RC1 = checked ((int) Math.Round(unchecked ((double) PDFFunctions.Points[3].Y + 5.0)));
        XGraphics xgraphics17 = PDFFunctions.gfx[SAPInput.k];
        XFont arialFont10Bold8 = PDFFunctions.ArialFont10Bold;
        XSolidBrush black14 = XBrushes.Black;
        double num49 = (double) checked (SAPInput.RC1 + 1);
        xunit = PDFFunctions.pages[SAPInput.k].Width;
        double point16 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[SAPInput.k].Height;
        double num50 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect17 = new XRect(20.0, num49, point16, num50);
        XStringFormat topLeft17 = XStringFormat.TopLeft;
        xgraphics17.DrawString("Total Energy Type CO  Emissions for Codes Levels 1 - 5", arialFont10Bold8, (XBrush) black14, xrect17, topLeft17);
        XGraphics xgraphics18 = PDFFunctions.gfx[SAPInput.k];
        string str6 = Conversions.ToString(2);
        XFont xfont17 = xfont8;
        XSolidBrush black15 = XBrushes.Black;
        double num51 = (double) checked (SAPInput.RC1 + 6);
        xunit = PDFFunctions.pages[SAPInput.k].Width;
        double point17 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[SAPInput.k].Height;
        double num52 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect18 = new XRect(124.0, num51, point17, num52);
        XStringFormat topLeft18 = XStringFormat.TopLeft;
        xgraphics18.DrawString(str6, xfont17, (XBrush) black15, xrect18, topLeft18);
        checked { SAPInput.RC1 += 12; }
        XGraphics xgraphics19 = PDFFunctions.gfx[SAPInput.k];
        XPen blackPen1 = PDFFunctions.BlackPen;
        XSize pageSize8 = PDFFunctions.gfx[SAPInput.k].PageSize;
        double num53 = ((XSize) ref pageSize8).Width / 2.0 + 120.0;
        double rc1_6 = (double) SAPInput.RC1;
        XSize pageSize9 = PDFFunctions.gfx[SAPInput.k].PageSize;
        double num54 = ((XSize) ref pageSize9).Width / 2.0 + 120.0;
        double num55 = (double) checked (SAPInput.RC1 + 128);
        xgraphics19.DrawLine(blackPen1, num53, rc1_6, num54, num55);
        XGraphics xgraphics20 = PDFFunctions.gfx[SAPInput.k];
        XPen blackPen2 = PDFFunctions.BlackPen;
        pageSize9 = PDFFunctions.gfx[SAPInput.k].PageSize;
        double num56 = ((XSize) ref pageSize9).Width / 2.0 + 180.0;
        double rc1_7 = (double) SAPInput.RC1;
        XSize xsize2 = PDFFunctions.gfx[SAPInput.k].PageSize;
        double num57 = ((XSize) ref xsize2).Width / 2.0 + 180.0;
        double num58 = (double) checked (SAPInput.RC1 + 128);
        xgraphics20.DrawLine(blackPen2, num56, rc1_7, num57, num58);
        XGraphics xgraphics21 = PDFFunctions.gfx[SAPInput.k];
        XPen blackPen3 = PDFFunctions.BlackPen;
        xsize2 = PDFFunctions.gfx[SAPInput.k].PageSize;
        double num59 = ((XSize) ref xsize2).Width / 2.0 + 240.0;
        double rc1_8 = (double) SAPInput.RC1;
        xsize2 = PDFFunctions.gfx[SAPInput.k].PageSize;
        double num60 = ((XSize) ref xsize2).Width / 2.0 + 240.0;
        double num61 = (double) checked (SAPInput.RC1 + 128);
        xgraphics21.DrawLine(blackPen3, num59, rc1_8, num60, num61);
        xsize2 = PDFFunctions.gfx[SAPInput.k].PageSize;
        double num62 = ((XSize) ref xsize2).Width / 2.0 + 150.0;
        xsize2 = PDFFunctions.gfx[SAPInput.k].MeasureString("%", PDFFunctions.ArialFont10Bold);
        double num63 = ((XSize) ref xsize2).Width / 2.0;
        int num64 = checked ((int) Math.Round(unchecked (num62 - num63)));
        XGraphics xgraphics22 = PDFFunctions.gfx[SAPInput.k];
        XFont arialFont10Bold9 = PDFFunctions.ArialFont10Bold;
        XSolidBrush black16 = XBrushes.Black;
        double num65 = (double) num64;
        double num66 = (double) checked (SAPInput.RC1 + 1);
        xunit = PDFFunctions.pages[SAPInput.k].Width;
        double point18 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[SAPInput.k].Height;
        double num67 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect19 = new XRect(num65, num66, point18, num67);
        XStringFormat topLeft19 = XStringFormat.TopLeft;
        xgraphics22.DrawString("%", arialFont10Bold9, (XBrush) black16, xrect19, topLeft19);
        xsize2 = PDFFunctions.gfx[SAPInput.k].PageSize;
        double num68 = ((XSize) ref xsize2).Width / 2.0 + 210.0;
        xsize2 = PDFFunctions.gfx[SAPInput.k].MeasureString("kg/m\u00B2/year", PDFFunctions.ArialFont10Bold);
        double num69 = ((XSize) ref xsize2).Width / 2.0;
        int num70 = checked ((int) Math.Round(unchecked (num68 - num69)));
        XGraphics xgraphics23 = PDFFunctions.gfx[SAPInput.k];
        XFont arialFont10Bold10 = PDFFunctions.ArialFont10Bold;
        XSolidBrush black17 = XBrushes.Black;
        double num71 = (double) num70;
        double num72 = (double) checked (SAPInput.RC1 + 1);
        xunit = PDFFunctions.pages[SAPInput.k].Width;
        double point19 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[SAPInput.k].Height;
        double num73 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect20 = new XRect(num71, num72, point19, num73);
        XStringFormat topLeft20 = XStringFormat.TopLeft;
        xgraphics23.DrawString("kg/m\u00B2/year", arialFont10Bold10, (XBrush) black17, xrect20, topLeft20);
        Ene1 ene1 = new Ene1();
        ene1.Calc();
        XGraphics xgraphics24 = PDFFunctions.gfx[SAPInput.k];
        XPen blackPen4 = PDFFunctions.BlackPen;
        double num74 = (double) checked (SAPInput.RC1 + 15);
        xsize2 = PDFFunctions.gfx[SAPInput.k].PageSize;
        double num75 = ((XSize) ref xsize2).Width - 40.0;
        double num76 = (double) checked (SAPInput.RC1 + 15);
        xgraphics24.DrawLine(blackPen4, 20.0, num74, num75, num76);
        checked { SAPInput.RC1 += 16; }
        XGraphics xgraphics25 = PDFFunctions.gfx[SAPInput.k];
        XFont xfont18 = xfont3;
        XSolidBrush black18 = XBrushes.Black;
        double num77 = (double) checked (SAPInput.RC1 + 1);
        xunit = PDFFunctions.pages[SAPInput.k].Width;
        double point20 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[SAPInput.k].Height;
        double num78 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect21 = new XRect(22.0, num77, point20, num78);
        XStringFormat topLeft21 = XStringFormat.TopLeft;
        xgraphics25.DrawString("DER from SAP 2012 DER Worksheet", xfont18, (XBrush) black18, xrect21, topLeft21);
        xsize2 = PDFFunctions.gfx[SAPInput.k].PageSize;
        double num79 = ((XSize) ref xsize2).Width / 2.0 + 210.0;
        xsize2 = PDFFunctions.gfx[SAPInput.k].MeasureString(Conversions.ToString(Math.Round(ene1.Ene1_.Part1.P1, 2)), xfont3);
        double num80 = ((XSize) ref xsize2).Width / 2.0;
        int num81 = checked ((int) Math.Round(unchecked (num79 - num80)));
        XGraphics xgraphics26 = PDFFunctions.gfx[SAPInput.k];
        string str7 = Conversions.ToString(Math.Round(ene1.Ene1_.Part1.P1, 2));
        XFont xfont19 = xfont3;
        XSolidBrush black19 = XBrushes.Black;
        double num82 = (double) num81;
        double num83 = (double) checked (SAPInput.RC1 + 1);
        xunit = PDFFunctions.pages[SAPInput.k].Width;
        double point21 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[SAPInput.k].Height;
        double num84 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect22 = new XRect(num82, num83, point21, num84);
        XStringFormat topLeft22 = XStringFormat.TopLeft;
        xgraphics26.DrawString(str7, xfont19, (XBrush) black19, xrect22, topLeft22);
        XGraphics xgraphics27 = PDFFunctions.gfx[SAPInput.k];
        XFont arialFont10Italic1 = PDFFunctions.ArialFont10Italic;
        XSolidBrush black20 = XBrushes.Black;
        double rc1_9 = (double) SAPInput.RC1;
        xunit = PDFFunctions.pages[SAPInput.k].Width;
        double point22 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[SAPInput.k].Height;
        double num85 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect23 = new XRect(550.0, rc1_9, point22, num85);
        XStringFormat topLeft23 = XStringFormat.TopLeft;
        xgraphics27.DrawString("(ZC1)", arialFont10Italic1, (XBrush) black20, xrect23, topLeft23);
        XGraphics xgraphics28 = PDFFunctions.gfx[SAPInput.k];
        XPen blackPen5 = PDFFunctions.BlackPen;
        double num86 = (double) checked (SAPInput.RC1 + 15);
        xsize2 = PDFFunctions.gfx[SAPInput.k].PageSize;
        double num87 = ((XSize) ref xsize2).Width - 40.0;
        double num88 = (double) checked (SAPInput.RC1 + 15);
        xgraphics28.DrawLine(blackPen5, 20.0, num86, num87, num88);
        checked { SAPInput.RC1 += 16; }
        XGraphics xgraphics29 = PDFFunctions.gfx[SAPInput.k];
        XFont xfont20 = xfont3;
        XSolidBrush black21 = XBrushes.Black;
        double num89 = (double) checked (SAPInput.RC1 + 1);
        xunit = PDFFunctions.pages[SAPInput.k].Width;
        double point23 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[SAPInput.k].Height;
        double num90 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect24 = new XRect(22.0, num89, point23, num90);
        XStringFormat topLeft24 = XStringFormat.TopLeft;
        xgraphics29.DrawString("TER", xfont20, (XBrush) black21, xrect24, topLeft24);
        xsize2 = PDFFunctions.gfx[SAPInput.k].PageSize;
        double num91 = ((XSize) ref xsize2).Width / 2.0 + 210.0;
        xsize2 = PDFFunctions.gfx[SAPInput.k].MeasureString(Conversions.ToString(Math.Round(ene1.Ene1_.Part1.P2, 2)), xfont3);
        double num92 = ((XSize) ref xsize2).Width / 2.0;
        int num93 = checked ((int) Math.Round(unchecked (num91 - num92)));
        XGraphics xgraphics30 = PDFFunctions.gfx[SAPInput.k];
        string str8 = Conversions.ToString(Math.Round(ene1.Ene1_.Part1.P2, 2));
        XFont xfont21 = xfont3;
        XSolidBrush black22 = XBrushes.Black;
        double num94 = (double) num93;
        double num95 = (double) checked (SAPInput.RC1 + 1);
        xunit = PDFFunctions.pages[SAPInput.k].Width;
        double point24 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[SAPInput.k].Height;
        double num96 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect25 = new XRect(num94, num95, point24, num96);
        XStringFormat topLeft25 = XStringFormat.TopLeft;
        xgraphics30.DrawString(str8, xfont21, (XBrush) black22, xrect25, topLeft25);
        XGraphics xgraphics31 = PDFFunctions.gfx[SAPInput.k];
        XPen blackPen6 = PDFFunctions.BlackPen;
        double num97 = (double) checked (SAPInput.RC1 + 15);
        xsize2 = PDFFunctions.gfx[SAPInput.k].PageSize;
        double num98 = ((XSize) ref xsize2).Width - 40.0;
        double num99 = (double) checked (SAPInput.RC1 + 15);
        xgraphics31.DrawLine(blackPen6, 20.0, num97, num98, num99);
        checked { SAPInput.RC1 += 16; }
        XGraphics xgraphics32 = PDFFunctions.gfx[SAPInput.k];
        XFont xfont22 = xfont3;
        XSolidBrush black23 = XBrushes.Black;
        double num100 = (double) checked (SAPInput.RC1 + 1);
        xunit = PDFFunctions.pages[SAPInput.k].Width;
        double point25 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[SAPInput.k].Height;
        double num101 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect26 = new XRect(22.0, num100, point25, num101);
        XStringFormat topLeft26 = XStringFormat.TopLeft;
        xgraphics32.DrawString("Residual CO2 emissions offset from biofuel CHP", xfont22, (XBrush) black23, xrect26, topLeft26);
        xsize2 = PDFFunctions.gfx[SAPInput.k].PageSize;
        double num102 = ((XSize) ref xsize2).Width / 2.0 + 210.0;
        xsize2 = PDFFunctions.gfx[SAPInput.k].MeasureString(Conversions.ToString(Math.Round(ene1.Ene1_.Part1.P4, 2)), xfont3);
        double num103 = ((XSize) ref xsize2).Width / 2.0;
        int num104 = checked ((int) Math.Round(unchecked (num102 - num103)));
        XGraphics xgraphics33 = PDFFunctions.gfx[SAPInput.k];
        string str9 = Conversions.ToString(Math.Round(ene1.Ene1_.Part1.P4, 2));
        XFont xfont23 = xfont3;
        XSolidBrush black24 = XBrushes.Black;
        double num105 = (double) num104;
        double num106 = (double) checked (SAPInput.RC1 + 1);
        xunit = PDFFunctions.pages[SAPInput.k].Width;
        double point26 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[SAPInput.k].Height;
        double num107 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect27 = new XRect(num105, num106, point26, num107);
        XStringFormat topLeft27 = XStringFormat.TopLeft;
        xgraphics33.DrawString(str9, xfont23, (XBrush) black24, xrect27, topLeft27);
        XGraphics xgraphics34 = PDFFunctions.gfx[SAPInput.k];
        XFont arialFont10Italic2 = PDFFunctions.ArialFont10Italic;
        XSolidBrush black25 = XBrushes.Black;
        double rc1_10 = (double) SAPInput.RC1;
        xunit = PDFFunctions.pages[SAPInput.k].Width;
        double point27 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[SAPInput.k].Height;
        double num108 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect28 = new XRect(550.0, rc1_10, point27, num108);
        XStringFormat topLeft28 = XStringFormat.TopLeft;
        xgraphics34.DrawString("(ZC5)", arialFont10Italic2, (XBrush) black25, xrect28, topLeft28);
        XGraphics xgraphics35 = PDFFunctions.gfx[SAPInput.k];
        XPen blackPen7 = PDFFunctions.BlackPen;
        double num109 = (double) checked (SAPInput.RC1 + 15);
        xsize2 = PDFFunctions.gfx[SAPInput.k].PageSize;
        double num110 = ((XSize) ref xsize2).Width - 40.0;
        double num111 = (double) checked (SAPInput.RC1 + 15);
        xgraphics35.DrawLine(blackPen7, 20.0, num109, num110, num111);
        checked { SAPInput.RC1 += 16; }
        XGraphics xgraphics36 = PDFFunctions.gfx[SAPInput.k];
        XFont xfont24 = xfont3;
        XSolidBrush black26 = XBrushes.Black;
        double num112 = (double) checked (SAPInput.RC1 + 1);
        xunit = PDFFunctions.pages[SAPInput.k].Width;
        double point28 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[SAPInput.k].Height;
        double num113 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect29 = new XRect(22.0, num112, point28, num113);
        XStringFormat topLeft29 = XStringFormat.TopLeft;
        xgraphics36.DrawString("CO2 emissions offset from additional allowable electricty generation", xfont24, (XBrush) black26, xrect29, topLeft29);
        xsize2 = PDFFunctions.gfx[SAPInput.k].PageSize;
        double num114 = ((XSize) ref xsize2).Width / 2.0 + 210.0;
        xsize2 = PDFFunctions.gfx[SAPInput.k].MeasureString(Conversions.ToString(Math.Round(ene1.Ene1_.Part1.P3, 2)), xfont3);
        double num115 = ((XSize) ref xsize2).Width / 2.0;
        int num116 = checked ((int) Math.Round(unchecked (num114 - num115)));
        XGraphics xgraphics37 = PDFFunctions.gfx[SAPInput.k];
        string str10 = Conversions.ToString(Math.Round(ene1.Ene1_.Part1.P3, 2));
        XFont xfont25 = xfont3;
        XSolidBrush black27 = XBrushes.Black;
        double num117 = (double) num116;
        double num118 = (double) checked (SAPInput.RC1 + 1);
        xunit = PDFFunctions.pages[SAPInput.k].Width;
        double point29 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[SAPInput.k].Height;
        double num119 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect30 = new XRect(num117, num118, point29, num119);
        XStringFormat topLeft30 = XStringFormat.TopLeft;
        xgraphics37.DrawString(str10, xfont25, (XBrush) black27, xrect30, topLeft30);
        XGraphics xgraphics38 = PDFFunctions.gfx[SAPInput.k];
        XFont arialFont10Italic3 = PDFFunctions.ArialFont10Italic;
        XSolidBrush black28 = XBrushes.Black;
        double rc1_11 = (double) SAPInput.RC1;
        xunit = PDFFunctions.pages[SAPInput.k].Width;
        double point30 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[SAPInput.k].Height;
        double num120 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect31 = new XRect(550.0, rc1_11, point30, num120);
        XStringFormat topLeft31 = XStringFormat.TopLeft;
        xgraphics38.DrawString("(ZC7)", arialFont10Italic3, (XBrush) black28, xrect31, topLeft31);
        XGraphics xgraphics39 = PDFFunctions.gfx[SAPInput.k];
        XPen blackPen8 = PDFFunctions.BlackPen;
        double num121 = (double) checked (SAPInput.RC1 + 15);
        xsize2 = PDFFunctions.gfx[SAPInput.k].PageSize;
        double num122 = ((XSize) ref xsize2).Width - 40.0;
        double num123 = (double) checked (SAPInput.RC1 + 15);
        xgraphics39.DrawLine(blackPen8, 20.0, num121, num122, num123);
        checked { SAPInput.RC1 += 16; }
        XGraphics xgraphics40 = PDFFunctions.gfx[SAPInput.k];
        XFont xfont26 = xfont3;
        XSolidBrush black29 = XBrushes.Black;
        double num124 = (double) checked (SAPInput.RC1 + 1);
        xunit = PDFFunctions.pages[SAPInput.k].Width;
        double point31 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[SAPInput.k].Height;
        double num125 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect32 = new XRect(22.0, num124, point31, num125);
        XStringFormat topLeft32 = XStringFormat.TopLeft;
        xgraphics40.DrawString("Total CO2 emissions offset from SAP Section 16 allowances", xfont26, (XBrush) black29, xrect32, topLeft32);
        xsize2 = PDFFunctions.gfx[SAPInput.k].PageSize;
        double num126 = ((XSize) ref xsize2).Width / 2.0 + 210.0;
        xsize2 = PDFFunctions.gfx[SAPInput.k].MeasureString(Conversions.ToString(Math.Round(ene1.Ene1_.Part1.P5, 2)), xfont3);
        double num127 = ((XSize) ref xsize2).Width / 2.0;
        int num128 = checked ((int) Math.Round(unchecked (num126 - num127)));
        XGraphics xgraphics41 = PDFFunctions.gfx[SAPInput.k];
        string str11 = Conversions.ToString(Math.Round(ene1.Ene1_.Part1.P5, 2));
        XFont xfont27 = xfont3;
        XSolidBrush black30 = XBrushes.Black;
        double num129 = (double) num128;
        double num130 = (double) checked (SAPInput.RC1 + 1);
        xunit = PDFFunctions.pages[SAPInput.k].Width;
        double point32 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[SAPInput.k].Height;
        double num131 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect33 = new XRect(num129, num130, point32, num131);
        XStringFormat topLeft33 = XStringFormat.TopLeft;
        xgraphics41.DrawString(str11, xfont27, (XBrush) black30, xrect33, topLeft33);
        XGraphics xgraphics42 = PDFFunctions.gfx[SAPInput.k];
        XPen blackPen9 = PDFFunctions.BlackPen;
        double num132 = (double) checked (SAPInput.RC1 + 15);
        xsize2 = PDFFunctions.gfx[SAPInput.k].PageSize;
        double num133 = ((XSize) ref xsize2).Width - 40.0;
        double num134 = (double) checked (SAPInput.RC1 + 15);
        xgraphics42.DrawLine(blackPen9, 20.0, num132, num133, num134);
        checked { SAPInput.RC1 += 16; }
        XGraphics xgraphics43 = PDFFunctions.gfx[SAPInput.k];
        XFont xfont28 = xfont3;
        XSolidBrush black31 = XBrushes.Black;
        double num135 = (double) checked (SAPInput.RC1 + 1);
        xunit = PDFFunctions.pages[SAPInput.k].Width;
        double point33 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[SAPInput.k].Height;
        double num136 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect34 = new XRect(22.0, num135, point33, num136);
        XStringFormat topLeft34 = XStringFormat.TopLeft;
        xgraphics43.DrawString("DER accounting for SAP Section 16 allowances", xfont28, (XBrush) black31, xrect34, topLeft34);
        xsize2 = PDFFunctions.gfx[SAPInput.k].PageSize;
        double num137 = ((XSize) ref xsize2).Width / 2.0 + 210.0;
        xsize2 = PDFFunctions.gfx[SAPInput.k].MeasureString(Conversions.ToString(Math.Round(ene1.Ene1_.Part1.P6, 2)), xfont3);
        double num138 = ((XSize) ref xsize2).Width / 2.0;
        int num139 = checked ((int) Math.Round(unchecked (num137 - num138)));
        XGraphics xgraphics44 = PDFFunctions.gfx[SAPInput.k];
        string str12 = Conversions.ToString(Math.Round(ene1.Ene1_.Part1.P6, 2));
        XFont xfont29 = xfont3;
        XSolidBrush black32 = XBrushes.Black;
        double num140 = (double) num139;
        double num141 = (double) checked (SAPInput.RC1 + 1);
        xunit = PDFFunctions.pages[SAPInput.k].Width;
        double point34 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[SAPInput.k].Height;
        double num142 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect35 = new XRect(num140, num141, point34, num142);
        XStringFormat topLeft35 = XStringFormat.TopLeft;
        xgraphics44.DrawString(str12, xfont29, (XBrush) black32, xrect35, topLeft35);
        XGraphics xgraphics45 = PDFFunctions.gfx[SAPInput.k];
        XPen blackPen10 = PDFFunctions.BlackPen;
        double num143 = (double) checked (SAPInput.RC1 + 15);
        xsize2 = PDFFunctions.gfx[SAPInput.k].PageSize;
        double num144 = ((XSize) ref xsize2).Width - 40.0;
        double num145 = (double) checked (SAPInput.RC1 + 15);
        xgraphics45.DrawLine(blackPen10, 20.0, num143, num144, num145);
        checked { SAPInput.RC1 += 16; }
        XGraphics xgraphics46 = PDFFunctions.gfx[SAPInput.k];
        XFont xfont30 = xfont3;
        XSolidBrush black33 = XBrushes.Black;
        double num146 = (double) checked (SAPInput.RC1 + 1);
        xunit = PDFFunctions.pages[SAPInput.k].Width;
        double point35 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[SAPInput.k].Height;
        double num147 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect36 = new XRect(22.0, num146, point35, num147);
        XStringFormat topLeft36 = XStringFormat.TopLeft;
        xgraphics46.DrawString("% improvement DER/TER", xfont30, (XBrush) black33, xrect36, topLeft36);
        if (ene1.Ene1_.Part1.P7 < 0.0)
        {
          xsize2 = PDFFunctions.gfx[SAPInput.k].PageSize;
          double num148 = ((XSize) ref xsize2).Width / 2.0 + 150.0;
          xsize2 = PDFFunctions.gfx[SAPInput.k].MeasureString("0", xfont3);
          double num149 = ((XSize) ref xsize2).Width / 2.0;
          int num150 = checked ((int) Math.Round(unchecked (num148 - num149)));
          XGraphics xgraphics47 = PDFFunctions.gfx[SAPInput.k];
          XFont xfont31 = xfont3;
          XSolidBrush black34 = XBrushes.Black;
          double num151 = (double) num150;
          double num152 = (double) checked (SAPInput.RC1 + 1);
          xunit = PDFFunctions.pages[SAPInput.k].Width;
          double point36 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[SAPInput.k].Height;
          double num153 = ((XUnit) ref xunit).Point / 2.0;
          XRect xrect37 = new XRect(num151, num152, point36, num153);
          XStringFormat topLeft37 = XStringFormat.TopLeft;
          xgraphics47.DrawString("0", xfont31, (XBrush) black34, xrect37, topLeft37);
        }
        else if (ene1.Ene1_.Part1.P7 > 100.0)
        {
          xsize2 = PDFFunctions.gfx[SAPInput.k].PageSize;
          double num154 = ((XSize) ref xsize2).Width / 2.0 + 150.0;
          xsize2 = PDFFunctions.gfx[SAPInput.k].MeasureString("100", xfont3);
          double num155 = ((XSize) ref xsize2).Width / 2.0;
          int num156 = checked ((int) Math.Round(unchecked (num154 - num155)));
          XGraphics xgraphics48 = PDFFunctions.gfx[SAPInput.k];
          XFont xfont32 = xfont3;
          XSolidBrush black35 = XBrushes.Black;
          double num157 = (double) num156;
          double num158 = (double) checked (SAPInput.RC1 + 1);
          xunit = PDFFunctions.pages[SAPInput.k].Width;
          double point37 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[SAPInput.k].Height;
          double num159 = ((XUnit) ref xunit).Point / 2.0;
          XRect xrect38 = new XRect(num157, num158, point37, num159);
          XStringFormat topLeft38 = XStringFormat.TopLeft;
          xgraphics48.DrawString("100", xfont32, (XBrush) black35, xrect38, topLeft38);
        }
        else
        {
          xsize2 = PDFFunctions.gfx[SAPInput.k].PageSize;
          double num160 = ((XSize) ref xsize2).Width / 2.0 + 150.0;
          xsize2 = PDFFunctions.gfx[SAPInput.k].MeasureString(Conversions.ToString(Math.Round(ene1.Ene1_.Part1.P7, 2)), xfont3);
          double num161 = ((XSize) ref xsize2).Width / 2.0;
          int num162 = checked ((int) Math.Round(unchecked (num160 - num161)));
          XGraphics xgraphics49 = PDFFunctions.gfx[SAPInput.k];
          string str13 = Conversions.ToString(Math.Round(ene1.Ene1_.Part1.P7, 2));
          XFont xfont33 = xfont3;
          XSolidBrush black36 = XBrushes.Black;
          double num163 = (double) num162;
          double num164 = (double) checked (SAPInput.RC1 + 1);
          xunit = PDFFunctions.pages[SAPInput.k].Width;
          double point38 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[SAPInput.k].Height;
          double num165 = ((XUnit) ref xunit).Point / 2.0;
          XRect xrect39 = new XRect(num163, num164, point38, num165);
          XStringFormat topLeft39 = XStringFormat.TopLeft;
          xgraphics49.DrawString(str13, xfont33, (XBrush) black36, xrect39, topLeft39);
        }
        Math.Round(ene1.Ene1_.Part1.P7, 2);
        XGraphics xgraphics50 = PDFFunctions.gfx[SAPInput.k];
        XPen blackPen11 = PDFFunctions.BlackPen;
        double num166 = (double) checked (SAPInput.RC1 + 15);
        xsize2 = PDFFunctions.gfx[SAPInput.k].PageSize;
        double num167 = ((XSize) ref xsize2).Width - 40.0;
        double num168 = (double) checked (SAPInput.RC1 + 15);
        xgraphics50.DrawLine(blackPen11, 20.0, num166, num167, num168);
        checked { SAPInput.RC1 += 16; }
        checked { SAPInput.RC1 += 14; }
        XGraphics xgraphics51 = PDFFunctions.gfx[SAPInput.k];
        XFont arialFont10Bold11 = PDFFunctions.ArialFont10Bold;
        XSolidBrush black37 = XBrushes.Black;
        double num169 = (double) checked (SAPInput.RC1 + 1);
        xunit = PDFFunctions.pages[SAPInput.k].Width;
        double point39 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[SAPInput.k].Height;
        double num170 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect40 = new XRect(20.0, num169, point39, num170);
        XStringFormat topLeft40 = XStringFormat.TopLeft;
        xgraphics51.DrawString("Total Energy Type CO2 Emissions for Codes Levels 6", arialFont10Bold11, (XBrush) black37, xrect40, topLeft40);
        checked { SAPInput.RC1 += 12; }
        XGraphics xgraphics52 = PDFFunctions.gfx[SAPInput.k];
        XPen blackPen12 = PDFFunctions.BlackPen;
        xsize2 = PDFFunctions.gfx[SAPInput.k].PageSize;
        double num171 = ((XSize) ref xsize2).Width / 2.0 + 180.0;
        double rc1_12 = (double) SAPInput.RC1;
        xsize2 = PDFFunctions.gfx[SAPInput.k].PageSize;
        double num172 = ((XSize) ref xsize2).Width / 2.0 + 180.0;
        double num173 = (double) checked (SAPInput.RC1 + 64);
        xgraphics52.DrawLine(blackPen12, num171, rc1_12, num172, num173);
        XGraphics xgraphics53 = PDFFunctions.gfx[SAPInput.k];
        XPen blackPen13 = PDFFunctions.BlackPen;
        xsize2 = PDFFunctions.gfx[SAPInput.k].PageSize;
        double num174 = ((XSize) ref xsize2).Width / 2.0 + 240.0;
        double rc1_13 = (double) SAPInput.RC1;
        xsize2 = PDFFunctions.gfx[SAPInput.k].PageSize;
        double num175 = ((XSize) ref xsize2).Width / 2.0 + 240.0;
        double num176 = (double) checked (SAPInput.RC1 + 64);
        xgraphics53.DrawLine(blackPen13, num174, rc1_13, num175, num176);
        XGraphics xgraphics54 = PDFFunctions.gfx[SAPInput.k];
        XPen blackPen14 = PDFFunctions.BlackPen;
        double num177 = (double) checked (SAPInput.RC1 + 15);
        xsize2 = PDFFunctions.gfx[SAPInput.k].PageSize;
        double num178 = ((XSize) ref xsize2).Width - 40.0;
        double num179 = (double) checked (SAPInput.RC1 + 15);
        xgraphics54.DrawLine(blackPen14, 20.0, num177, num178, num179);
        xsize2 = PDFFunctions.gfx[SAPInput.k].PageSize;
        double num180 = ((XSize) ref xsize2).Width / 2.0 + 210.0;
        xsize2 = PDFFunctions.gfx[SAPInput.k].MeasureString("kg/m\u00B2/year", PDFFunctions.ArialFont10Bold);
        double num181 = ((XSize) ref xsize2).Width / 2.0;
        int num182 = checked ((int) Math.Round(unchecked (num180 - num181)));
        XGraphics xgraphics55 = PDFFunctions.gfx[SAPInput.k];
        XFont arialFont10Bold12 = PDFFunctions.ArialFont10Bold;
        XSolidBrush black38 = XBrushes.Black;
        double num183 = (double) num182;
        double num184 = (double) checked (SAPInput.RC1 + 1);
        xunit = PDFFunctions.pages[SAPInput.k].Width;
        double point40 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[SAPInput.k].Height;
        double num185 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect41 = new XRect(num183, num184, point40, num185);
        XStringFormat topLeft41 = XStringFormat.TopLeft;
        xgraphics55.DrawString("kg/m\u00B2/year", arialFont10Bold12, (XBrush) black38, xrect41, topLeft41);
        XGraphics xgraphics56 = PDFFunctions.gfx[SAPInput.k];
        XPen blackPen15 = PDFFunctions.BlackPen;
        double num186 = (double) checked (SAPInput.RC1 + 15);
        xsize2 = PDFFunctions.gfx[SAPInput.k].PageSize;
        double num187 = ((XSize) ref xsize2).Width - 40.0;
        double num188 = (double) checked (SAPInput.RC1 + 15);
        xgraphics56.DrawLine(blackPen15, 20.0, num186, num187, num188);
        checked { SAPInput.RC1 += 14; }
        XGraphics xgraphics57 = PDFFunctions.gfx[SAPInput.k];
        XFont xfont34 = xfont3;
        XSolidBrush black39 = XBrushes.Black;
        double num189 = (double) checked (SAPInput.RC1 + 1);
        xunit = PDFFunctions.pages[SAPInput.k].Width;
        double point41 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[SAPInput.k].Height;
        double num190 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect42 = new XRect(22.0, num189, point41, num190);
        XStringFormat topLeft42 = XStringFormat.TopLeft;
        xgraphics57.DrawString("DER accounting for SAP Section 16 allowances", xfont34, (XBrush) black39, xrect42, topLeft42);
        xsize2 = PDFFunctions.gfx[SAPInput.k].PageSize;
        double num191 = ((XSize) ref xsize2).Width / 2.0 + 210.0;
        xsize2 = PDFFunctions.gfx[SAPInput.k].MeasureString(Conversions.ToString(Math.Round(ene1.Ene1_.Part1.P6, 2)), xfont3);
        double num192 = ((XSize) ref xsize2).Width / 2.0;
        int num193 = checked ((int) Math.Round(unchecked (num191 - num192)));
        XGraphics xgraphics58 = PDFFunctions.gfx[SAPInput.k];
        string str14 = Conversions.ToString(Math.Round(ene1.Ene1_.Part1.P6, 2));
        XFont xfont35 = xfont3;
        XSolidBrush black40 = XBrushes.Black;
        double num194 = (double) num193;
        double num195 = (double) checked (SAPInput.RC1 + 1);
        xunit = PDFFunctions.pages[SAPInput.k].Width;
        double point42 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[SAPInput.k].Height;
        double num196 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect43 = new XRect(num194, num195, point42, num196);
        XStringFormat topLeft43 = XStringFormat.TopLeft;
        xgraphics58.DrawString(str14, xfont35, (XBrush) black40, xrect43, topLeft43);
        XGraphics xgraphics59 = PDFFunctions.gfx[SAPInput.k];
        XFont arialFont10Italic4 = PDFFunctions.ArialFont10Italic;
        XSolidBrush black41 = XBrushes.Black;
        double rc1_14 = (double) SAPInput.RC1;
        xunit = PDFFunctions.pages[SAPInput.k].Width;
        double point43 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[SAPInput.k].Height;
        double num197 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect44 = new XRect(550.0, rc1_14, point43, num197);
        XStringFormat topLeft44 = XStringFormat.TopLeft;
        xgraphics59.DrawString("(ZC1)", arialFont10Italic4, (XBrush) black41, xrect44, topLeft44);
        XGraphics xgraphics60 = PDFFunctions.gfx[SAPInput.k];
        XPen blackPen16 = PDFFunctions.BlackPen;
        double num198 = (double) checked (SAPInput.RC1 + 15);
        xsize2 = PDFFunctions.gfx[SAPInput.k].PageSize;
        double num199 = ((XSize) ref xsize2).Width - 40.0;
        double num200 = (double) checked (SAPInput.RC1 + 15);
        xgraphics60.DrawLine(blackPen16, 20.0, num198, num199, num200);
        checked { SAPInput.RC1 += 14; }
        XGraphics xgraphics61 = PDFFunctions.gfx[SAPInput.k];
        XFont xfont36 = xfont3;
        XSolidBrush black42 = XBrushes.Black;
        double num201 = (double) checked (SAPInput.RC1 + 1);
        xunit = PDFFunctions.pages[SAPInput.k].Width;
        double point44 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[SAPInput.k].Height;
        double num202 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect45 = new XRect(22.0, num201, point44, num202);
        XStringFormat topLeft45 = XStringFormat.TopLeft;
        xgraphics61.DrawString("CO2 emissions from appliances, equation (L14)", xfont36, (XBrush) black42, xrect45, topLeft45);
        xsize2 = PDFFunctions.gfx[SAPInput.k].PageSize;
        double num203 = ((XSize) ref xsize2).Width / 2.0 + 210.0;
        xsize2 = PDFFunctions.gfx[SAPInput.k].MeasureString(Conversions.ToString(Math.Round(SAP_Module.CalcualtionDER_CSH.Calculation.AssessmentLZC2012.ZC2, 2)), xfont3);
        double num204 = ((XSize) ref xsize2).Width / 2.0;
        int num205 = checked ((int) Math.Round(unchecked (num203 - num204)));
        XGraphics xgraphics62 = PDFFunctions.gfx[SAPInput.k];
        string str15 = Conversions.ToString(Math.Round(SAP_Module.CalcualtionDER_CSH.Calculation.AssessmentLZC2012.ZC2, 2));
        XFont xfont37 = xfont3;
        XSolidBrush black43 = XBrushes.Black;
        double num206 = (double) num205;
        double num207 = (double) checked (SAPInput.RC1 + 1);
        xunit = PDFFunctions.pages[SAPInput.k].Width;
        double point45 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[SAPInput.k].Height;
        double num208 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect46 = new XRect(num206, num207, point45, num208);
        XStringFormat topLeft46 = XStringFormat.TopLeft;
        xgraphics62.DrawString(str15, xfont37, (XBrush) black43, xrect46, topLeft46);
        XGraphics xgraphics63 = PDFFunctions.gfx[SAPInput.k];
        XFont arialFont10Italic5 = PDFFunctions.ArialFont10Italic;
        XSolidBrush black44 = XBrushes.Black;
        double rc1_15 = (double) SAPInput.RC1;
        xunit = PDFFunctions.pages[SAPInput.k].Width;
        double point46 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[SAPInput.k].Height;
        double num209 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect47 = new XRect(550.0, rc1_15, point46, num209);
        XStringFormat topLeft47 = XStringFormat.TopLeft;
        xgraphics63.DrawString("(ZC2)", arialFont10Italic5, (XBrush) black44, xrect47, topLeft47);
        XGraphics xgraphics64 = PDFFunctions.gfx[SAPInput.k];
        XPen blackPen17 = PDFFunctions.BlackPen;
        double num210 = (double) checked (SAPInput.RC1 + 15);
        xsize2 = PDFFunctions.gfx[SAPInput.k].PageSize;
        double num211 = ((XSize) ref xsize2).Width - 40.0;
        double num212 = (double) checked (SAPInput.RC1 + 15);
        xgraphics64.DrawLine(blackPen17, 20.0, num210, num211, num212);
        checked { SAPInput.RC1 += 16; }
        XGraphics xgraphics65 = PDFFunctions.gfx[SAPInput.k];
        XFont xfont38 = xfont3;
        XSolidBrush black45 = XBrushes.Black;
        double num213 = (double) checked (SAPInput.RC1 + 1);
        xunit = PDFFunctions.pages[SAPInput.k].Width;
        double point47 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[SAPInput.k].Height;
        double num214 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect48 = new XRect(22.0, num213, point47, num214);
        XStringFormat topLeft48 = XStringFormat.TopLeft;
        xgraphics65.DrawString("CO2 emissions from cooking, equation (L16)", xfont38, (XBrush) black45, xrect48, topLeft48);
        xsize2 = PDFFunctions.gfx[SAPInput.k].PageSize;
        double num215 = ((XSize) ref xsize2).Width / 2.0 + 210.0;
        xsize2 = PDFFunctions.gfx[SAPInput.k].MeasureString(Conversions.ToString(Math.Round(SAP_Module.CalcualtionDER_CSH.Calculation.AssessmentLZC2012.ZC3, 2)), xfont3);
        double num216 = ((XSize) ref xsize2).Width / 2.0;
        int num217 = checked ((int) Math.Round(unchecked (num215 - num216)));
        XGraphics xgraphics66 = PDFFunctions.gfx[SAPInput.k];
        string str16 = Conversions.ToString(Math.Round(SAP_Module.CalcualtionDER_CSH.Calculation.AssessmentLZC2012.ZC3, 2));
        XFont xfont39 = xfont3;
        XSolidBrush black46 = XBrushes.Black;
        double num218 = (double) num217;
        double num219 = (double) checked (SAPInput.RC1 + 1);
        xunit = PDFFunctions.pages[SAPInput.k].Width;
        double point48 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[SAPInput.k].Height;
        double num220 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect49 = new XRect(num218, num219, point48, num220);
        XStringFormat topLeft49 = XStringFormat.TopLeft;
        xgraphics66.DrawString(str16, xfont39, (XBrush) black46, xrect49, topLeft49);
        XGraphics xgraphics67 = PDFFunctions.gfx[SAPInput.k];
        XFont arialFont10Italic6 = PDFFunctions.ArialFont10Italic;
        XSolidBrush black47 = XBrushes.Black;
        double rc1_16 = (double) SAPInput.RC1;
        xunit = PDFFunctions.pages[SAPInput.k].Width;
        double point49 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[SAPInput.k].Height;
        double num221 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect50 = new XRect(550.0, rc1_16, point49, num221);
        XStringFormat topLeft50 = XStringFormat.TopLeft;
        xgraphics67.DrawString("(ZC3)", arialFont10Italic6, (XBrush) black47, xrect50, topLeft50);
        XGraphics xgraphics68 = PDFFunctions.gfx[SAPInput.k];
        XPen blackPen18 = PDFFunctions.BlackPen;
        double num222 = (double) checked (SAPInput.RC1 + 15);
        xsize2 = PDFFunctions.gfx[SAPInput.k].PageSize;
        double num223 = ((XSize) ref xsize2).Width - 40.0;
        double num224 = (double) checked (SAPInput.RC1 + 15);
        xgraphics68.DrawLine(blackPen18, 20.0, num222, num223, num224);
        checked { SAPInput.RC1 += 16; }
        XGraphics xgraphics69 = PDFFunctions.gfx[SAPInput.k];
        XFont xfont40 = xfont3;
        XSolidBrush black48 = XBrushes.Black;
        double rc1_17 = (double) SAPInput.RC1;
        xunit = PDFFunctions.pages[SAPInput.k].Width;
        double point50 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[SAPInput.k].Height;
        double num225 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect51 = new XRect(22.0, rc1_17, point50, num225);
        XStringFormat topLeft51 = XStringFormat.TopLeft;
        xgraphics69.DrawString("Net CO2 emissions", xfont40, (XBrush) black48, xrect51, topLeft51);
        xsize2 = PDFFunctions.gfx[SAPInput.k].PageSize;
        double num226 = ((XSize) ref xsize2).Width / 2.0 + 210.0;
        xsize2 = PDFFunctions.gfx[SAPInput.k].MeasureString(Conversions.ToString(Math.Round(SAP_Module.CalcualtionDER2012.Calculation.AssessmentLZC2012.ZC8, 2)), xfont3);
        double num227 = ((XSize) ref xsize2).Width / 2.0;
        int num228 = checked ((int) Math.Round(unchecked (num226 - num227)));
        XGraphics xgraphics70 = PDFFunctions.gfx[SAPInput.k];
        string str17 = Conversions.ToString(Math.Round(SAP_Module.CalcualtionDER_CSH.Calculation.AssessmentLZC2012.ZC8, 2));
        XFont xfont41 = xfont3;
        XSolidBrush black49 = XBrushes.Black;
        double num229 = (double) num228;
        double rc1_18 = (double) SAPInput.RC1;
        xunit = PDFFunctions.pages[SAPInput.k].Width;
        double point51 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[SAPInput.k].Height;
        double num230 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect52 = new XRect(num229, rc1_18, point51, num230);
        XStringFormat topLeft52 = XStringFormat.TopLeft;
        xgraphics70.DrawString(str17, xfont41, (XBrush) black49, xrect52, topLeft52);
        XGraphics xgraphics71 = PDFFunctions.gfx[SAPInput.k];
        XFont arialFont10Italic7 = PDFFunctions.ArialFont10Italic;
        XSolidBrush black50 = XBrushes.Black;
        double rc1_19 = (double) SAPInput.RC1;
        xunit = PDFFunctions.pages[SAPInput.k].Width;
        double point52 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[SAPInput.k].Height;
        double num231 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect53 = new XRect(550.0, rc1_19, point52, num231);
        XStringFormat topLeft53 = XStringFormat.TopLeft;
        xgraphics71.DrawString("(ZC8)", arialFont10Italic7, (XBrush) black50, xrect53, topLeft53);
        XGraphics xgraphics72 = PDFFunctions.gfx[SAPInput.k];
        XPen blackPen19 = PDFFunctions.BlackPen;
        double num232 = (double) checked (SAPInput.RC1 + 15);
        xsize2 = PDFFunctions.gfx[SAPInput.k].PageSize;
        double num233 = ((XSize) ref xsize2).Width - 40.0;
        double num234 = (double) checked (SAPInput.RC1 + 15);
        xgraphics72.DrawLine(blackPen19, 20.0, num232, num233, num234);
        checked { SAPInput.RC1 += 16; }
        XGraphics xgraphics73 = PDFFunctions.gfx[SAPInput.k];
        XFont arialFont10Bold13 = PDFFunctions.ArialFont10Bold;
        XSolidBrush black51 = XBrushes.Black;
        double rc1_20 = (double) SAPInput.RC1;
        xunit = PDFFunctions.pages[SAPInput.k].Width;
        double point53 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[SAPInput.k].Height;
        double num235 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect54 = new XRect(20.0, rc1_20, point53, num235);
        XStringFormat topLeft54 = XStringFormat.TopLeft;
        xgraphics73.DrawString("Result:", arialFont10Bold13, (XBrush) black51, xrect54, topLeft54);
        checked { SAPInput.RC1 += 16; }
        int num236;
        float num237;
        if (ene1.Ene1_.Part1.P6 > Functions.TER())
        {
          num236 = 0;
          num237 = 0.0f;
        }
        else if (Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Address.Country, "Wales", false) == 0)
        {
          if (ene1.Ene1_.Part1.P6 <= 0.0)
          {
            if (ene1.Ene1_.Part2.P1 <= 0.0 & Functions.Ene2Rating(SAP_Module.CalculationFabric.Calculation.Fabric_Energy_Efficiency.Box109, House) >= 7.0)
            {
              num236 = 6;
              num237 = 10f;
            }
            else
            {
              num236 = 5;
              num237 = 9f;
            }
          }
          else
          {
            double p7 = ene1.Ene1_.Part1.P7;
            if (p7 >= 0.0 && p7 <= 16.999999)
              num236 = 3;
            else if (p7 >= 17.0 && p7 <= 99.999999)
              num236 = 4;
            num237 = (float) Functions.Ene1Rating(ene1.Ene1_.Part1.P7);
          }
        }
        else if (ene1.Ene1_.Part1.P6 <= 0.0)
        {
          if (ene1.Ene1_.Part2.P1 <= 0.0 & Functions.Ene2Rating(SAP_Module.CalculationFabric.Calculation.Fabric_Energy_Efficiency.Box109, House) >= 7.0)
          {
            num236 = 6;
            num237 = 10f;
          }
          else
          {
            num236 = 5;
            num237 = 9f;
          }
        }
        else
        {
          double p7 = ene1.Ene1_.Part1.P7;
          if (p7 >= 0.0 && p7 <= 18.999999)
            num236 = 3;
          else if (p7 >= 19.0 && p7 <= 99.999999)
            num236 = 4;
          num237 = (float) Functions.Ene1Rating(ene1.Ene1_.Part1.P7);
        }
        XGraphics xgraphics74 = PDFFunctions.gfx[SAPInput.k];
        string str18 = "Credits awarded for ENE 1 = " + Conversions.ToString(num237);
        XFont arialFont10Bold14 = PDFFunctions.ArialFont10Bold;
        XSolidBrush black52 = XBrushes.Black;
        double rc1_21 = (double) SAPInput.RC1;
        xunit = PDFFunctions.pages[SAPInput.k].Width;
        double point54 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[SAPInput.k].Height;
        double num238 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect55 = new XRect(20.0, rc1_21, point54, num238);
        XStringFormat topLeft55 = XStringFormat.TopLeft;
        xgraphics74.DrawString(str18, arialFont10Bold14, (XBrush) black52, xrect55, topLeft55);
        checked { SAPInput.RC1 += 16; }
        XGraphics xgraphics75 = PDFFunctions.gfx[SAPInput.k];
        string str19 = "Code Level = " + Conversions.ToString(num236);
        XFont arialFont10Bold15 = PDFFunctions.ArialFont10Bold;
        XSolidBrush black53 = XBrushes.Black;
        double rc1_22 = (double) SAPInput.RC1;
        xunit = PDFFunctions.pages[SAPInput.k].Width;
        double point55 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[SAPInput.k].Height;
        double num239 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect56 = new XRect(20.0, rc1_22, point55, num239);
        XStringFormat topLeft56 = XStringFormat.TopLeft;
        xgraphics75.DrawString(str19, arialFont10Bold15, (XBrush) black53, xrect56, topLeft56);
        checked { SAPInput.RC1 += 16; }
        PDFFunctions.xBrush1 = XBrush.op_Implicit((Brush) new SolidBrush(Color.FromArgb(159, 172, 62)));
        PDFFunctions.Points[0].X = 20f;
        PDFFunctions.Points[0].Y = (float) SAPInput.RC1;
        ref PointF local7 = ref PDFFunctions.Points[1];
        xunit = PDFFunctions.pages[SAPInput.k].Width;
        double num240 = ((XUnit) ref xunit).Point - 20.0;
        local7.X = (float) num240;
        PDFFunctions.Points[1].Y = (float) SAPInput.RC1;
        ref PointF local8 = ref PDFFunctions.Points[2];
        xunit = PDFFunctions.pages[SAPInput.k].Width;
        double num241 = ((XUnit) ref xunit).Point - 20.0;
        local8.X = (float) num241;
        PDFFunctions.Points[2].Y = (float) checked (SAPInput.RC1 + 15);
        PDFFunctions.Points[3].X = 20f;
        PDFFunctions.Points[3].Y = (float) checked (SAPInput.RC1 + 15);
        PDFFunctions.gfx[SAPInput.k].DrawPolygon(PDFFunctions.polyGreen2, PDFFunctions.xBrush1, PDFFunctions.Points, xfillMode);
        XGraphics xgraphics76 = PDFFunctions.gfx[SAPInput.k];
        XFont arialFont10Bold16 = PDFFunctions.ArialFont10Bold;
        XSolidBrush white4 = XBrushes.White;
        double num242 = (double) checked (SAPInput.RC1 + 1);
        xunit = PDFFunctions.pages[SAPInput.k].Width;
        double point56 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[SAPInput.k].Height;
        double num243 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect57 = new XRect(25.0, num242, point56, num243);
        XStringFormat topLeft57 = XStringFormat.TopLeft;
        xgraphics76.DrawString("ENE 2 - Fabric energy Efficiency", arialFont10Bold16, (XBrush) white4, xrect57, topLeft57);
        SAPInput.RC1 = checked ((int) Math.Round(unchecked ((double) PDFFunctions.Points[3].Y + 5.0)));
        XGraphics xgraphics77 = PDFFunctions.gfx[SAPInput.k];
        string str20 = "Fabric energy Efficiency: " + Conversions.ToString(Math.Round(SAP_Module.CalculationFabric.Calculation.Fabric_Energy_Efficiency.Box109, 2));
        XFont arialFont10Bold17 = PDFFunctions.ArialFont10Bold;
        XSolidBrush black54 = XBrushes.Black;
        double num244 = (double) checked (SAPInput.RC1 + 1);
        xunit = PDFFunctions.pages[SAPInput.k].Width;
        double point57 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[SAPInput.k].Height;
        double num245 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect58 = new XRect(20.0, num244, point57, num245);
        XStringFormat topLeft58 = XStringFormat.TopLeft;
        xgraphics77.DrawString(str20, arialFont10Bold17, (XBrush) black54, xrect58, topLeft58);
        checked { SAPInput.RC1 += 14; }
        XGraphics xgraphics78 = PDFFunctions.gfx[SAPInput.k];
        string str21 = "Credits awarded for ENE 2 = " + Conversions.ToString(Functions.Ene2Rating(SAP_Module.CalculationFabric.Calculation.Fabric_Energy_Efficiency.Box109, House));
        XFont arialFont10Bold18 = PDFFunctions.ArialFont10Bold;
        XSolidBrush black55 = XBrushes.Black;
        double rc1_23 = (double) SAPInput.RC1;
        xunit = PDFFunctions.pages[SAPInput.k].Width;
        double point58 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[SAPInput.k].Height;
        double num246 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect59 = new XRect(20.0, rc1_23, point58, num246);
        XStringFormat topLeft59 = XStringFormat.TopLeft;
        xgraphics78.DrawString(str21, arialFont10Bold18, (XBrush) black55, xrect59, topLeft59);
        checked { SAPInput.RC1 += 14; }
        Ene7 ene7 = new Ene7();
        ene7.Dwelling = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling];
        int y3 = checked (SAPInput.RC1 + 47);
        xsize2 = PDFFunctions.gfx[SAPInput.k].PageSize;
        int width4 = checked ((int) Math.Round(unchecked (((XSize) ref xsize2).Width / 2.0 + 155.0)));
        Rectangle rectangle3 = new Rectangle(20, y3, width4, 80);
        XLinearGradientBrush xlinearGradientBrush3 = new XLinearGradientBrush(rectangle3, XColor.op_Implicit(Color.FromArgb(215, 217, 182)), XColor.op_Implicit(Color.White), (XLinearGradientMode) 0);
        PDFFunctions.gfx[SAPInput.k].DrawRectangle(XPen.op_Implicit(new Pen(Color.White, 0.0f)), (XBrush) xlinearGradientBrush3, rectangle3);
        PDFFunctions.xBrush1 = XBrush.op_Implicit((Brush) new SolidBrush(Color.FromArgb(159, 172, 62)));
        PDFFunctions.Points[0].X = 20f;
        PDFFunctions.Points[0].Y = (float) SAPInput.RC1;
        ref PointF local9 = ref PDFFunctions.Points[1];
        xunit = PDFFunctions.pages[SAPInput.k].Width;
        double num247 = ((XUnit) ref xunit).Point - 20.0;
        local9.X = (float) num247;
        PDFFunctions.Points[1].Y = (float) SAPInput.RC1;
        ref PointF local10 = ref PDFFunctions.Points[2];
        xunit = PDFFunctions.pages[SAPInput.k].Width;
        double num248 = ((XUnit) ref xunit).Point - 20.0;
        local10.X = (float) num248;
        PDFFunctions.Points[2].Y = (float) checked (SAPInput.RC1 + 15);
        PDFFunctions.Points[3].X = 20f;
        PDFFunctions.Points[3].Y = (float) checked (SAPInput.RC1 + 15);
        PDFFunctions.gfx[SAPInput.k].DrawPolygon(PDFFunctions.polyGreen2, PDFFunctions.xBrush1, PDFFunctions.Points, xfillMode);
        XGraphics xgraphics79 = PDFFunctions.gfx[SAPInput.k];
        XFont arialFont10Bold19 = PDFFunctions.ArialFont10Bold;
        XSolidBrush white5 = XBrushes.White;
        double num249 = (double) checked (SAPInput.RC1 + 1);
        xunit = PDFFunctions.pages[SAPInput.k].Width;
        double point59 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[SAPInput.k].Height;
        double num250 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect60 = new XRect(25.0, num249, point59, num250);
        XStringFormat topLeft60 = XStringFormat.TopLeft;
        xgraphics79.DrawString("ENE 7 - Low or Zero Carbon (LZC) Technologies", arialFont10Bold19, (XBrush) white5, xrect60, topLeft60);
        SAPInput.RC1 = checked ((int) Math.Round(unchecked ((double) PDFFunctions.Points[3].Y + 5.0)));
        XGraphics xgraphics80 = PDFFunctions.gfx[SAPInput.k];
        XFont arialFont10Bold20 = PDFFunctions.ArialFont10Bold;
        XSolidBrush black56 = XBrushes.Black;
        double num251 = (double) checked (SAPInput.RC1 + 1);
        xunit = PDFFunctions.pages[SAPInput.k].Width;
        double point60 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[SAPInput.k].Height;
        double num252 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect61 = new XRect(20.0, num251, point60, num252);
        XStringFormat topLeft61 = XStringFormat.TopLeft;
        xgraphics80.DrawString("Reduction in CO2 Emissions", arialFont10Bold20, (XBrush) black56, xrect61, topLeft61);
        checked { SAPInput.RC1 += 12; }
        XGraphics xgraphics81 = PDFFunctions.gfx[SAPInput.k];
        XPen blackPen20 = PDFFunctions.BlackPen;
        xsize2 = PDFFunctions.gfx[SAPInput.k].PageSize;
        double num253 = ((XSize) ref xsize2).Width / 2.0 + 120.0;
        double rc1_24 = (double) SAPInput.RC1;
        xsize2 = PDFFunctions.gfx[SAPInput.k].PageSize;
        double num254 = ((XSize) ref xsize2).Width / 2.0 + 120.0;
        double num255 = (double) checked (SAPInput.RC1 + 80);
        xgraphics81.DrawLine(blackPen20, num253, rc1_24, num254, num255);
        XGraphics xgraphics82 = PDFFunctions.gfx[SAPInput.k];
        XPen blackPen21 = PDFFunctions.BlackPen;
        xsize2 = PDFFunctions.gfx[SAPInput.k].PageSize;
        double num256 = ((XSize) ref xsize2).Width / 2.0 + 180.0;
        double rc1_25 = (double) SAPInput.RC1;
        xsize2 = PDFFunctions.gfx[SAPInput.k].PageSize;
        double num257 = ((XSize) ref xsize2).Width / 2.0 + 180.0;
        double num258 = (double) checked (SAPInput.RC1 + 80);
        xgraphics82.DrawLine(blackPen21, num256, rc1_25, num257, num258);
        XGraphics xgraphics83 = PDFFunctions.gfx[SAPInput.k];
        XPen blackPen22 = PDFFunctions.BlackPen;
        xsize2 = PDFFunctions.gfx[SAPInput.k].PageSize;
        double num259 = ((XSize) ref xsize2).Width / 2.0 + 240.0;
        double rc1_26 = (double) SAPInput.RC1;
        xsize2 = PDFFunctions.gfx[SAPInput.k].PageSize;
        double num260 = ((XSize) ref xsize2).Width / 2.0 + 240.0;
        double num261 = (double) checked (SAPInput.RC1 + 80);
        xgraphics83.DrawLine(blackPen22, num259, rc1_26, num260, num261);
        xsize2 = PDFFunctions.gfx[SAPInput.k].PageSize;
        double num262 = ((XSize) ref xsize2).Width / 2.0 + 150.0;
        xsize2 = PDFFunctions.gfx[SAPInput.k].MeasureString("%", PDFFunctions.ArialFont10Bold);
        double num263 = ((XSize) ref xsize2).Width / 2.0;
        int num264 = checked ((int) Math.Round(unchecked (num262 - num263)));
        XGraphics xgraphics84 = PDFFunctions.gfx[SAPInput.k];
        XFont arialFont10Bold21 = PDFFunctions.ArialFont10Bold;
        XSolidBrush black57 = XBrushes.Black;
        double num265 = (double) num264;
        double num266 = (double) checked (SAPInput.RC1 + 1);
        xunit = PDFFunctions.pages[SAPInput.k].Width;
        double point61 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[SAPInput.k].Height;
        double num267 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect62 = new XRect(num265, num266, point61, num267);
        XStringFormat topLeft62 = XStringFormat.TopLeft;
        xgraphics84.DrawString("%", arialFont10Bold21, (XBrush) black57, xrect62, topLeft62);
        xsize2 = PDFFunctions.gfx[SAPInput.k].PageSize;
        double num268 = ((XSize) ref xsize2).Width / 2.0 + 210.0;
        xsize2 = PDFFunctions.gfx[SAPInput.k].MeasureString("kg/m\u00B2/year", PDFFunctions.ArialFont10Bold);
        double num269 = ((XSize) ref xsize2).Width / 2.0;
        int num270 = checked ((int) Math.Round(unchecked (num268 - num269)));
        XGraphics xgraphics85 = PDFFunctions.gfx[SAPInput.k];
        XFont arialFont10Bold22 = PDFFunctions.ArialFont10Bold;
        XSolidBrush black58 = XBrushes.Black;
        double num271 = (double) num270;
        double num272 = (double) checked (SAPInput.RC1 + 1);
        xunit = PDFFunctions.pages[SAPInput.k].Width;
        double point62 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[SAPInput.k].Height;
        double num273 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect63 = new XRect(num271, num272, point62, num273);
        XStringFormat topLeft63 = XStringFormat.TopLeft;
        xgraphics85.DrawString("kg/m\u00B2/year", arialFont10Bold22, (XBrush) black58, xrect63, topLeft63);
        XGraphics xgraphics86 = PDFFunctions.gfx[SAPInput.k];
        XPen blackPen23 = PDFFunctions.BlackPen;
        double num274 = (double) checked (SAPInput.RC1 + 15);
        xsize2 = PDFFunctions.gfx[SAPInput.k].PageSize;
        double num275 = ((XSize) ref xsize2).Width - 40.0;
        double num276 = (double) checked (SAPInput.RC1 + 15);
        xgraphics86.DrawLine(blackPen23, 20.0, num274, num275, num276);
        checked { SAPInput.RC1 += 16; }
        XGraphics xgraphics87 = PDFFunctions.gfx[SAPInput.k];
        XFont xfont42 = xfont3;
        XSolidBrush black59 = XBrushes.Black;
        double num277 = (double) checked (SAPInput.RC1 + 1);
        xunit = PDFFunctions.pages[SAPInput.k].Width;
        double point63 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[SAPInput.k].Height;
        double num278 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect64 = new XRect(22.0, num277, point63, num278);
        XStringFormat topLeft64 = XStringFormat.TopLeft;
        xgraphics87.DrawString("Standard Case CO2 emissions", xfont42, (XBrush) black59, xrect64, topLeft64);
        xsize2 = PDFFunctions.gfx[SAPInput.k].PageSize;
        double num279 = ((XSize) ref xsize2).Width / 2.0 + 210.0;
        xsize2 = PDFFunctions.gfx[SAPInput.k].MeasureString(Conversions.ToString(Math.Round(ene7.Ene7_.Part1.P1, 2)), xfont3);
        double num280 = ((XSize) ref xsize2).Width / 2.0;
        int num281 = checked ((int) Math.Round(unchecked (num279 - num280)));
        double num282 = SAPInput.CodeAssessmentLZC2012.ZC2 + SAPInput.CodeAssessmentLZC2012.ZC3 + Math.Round(num1, 2);
        AssessmentLZC_2012 assessmentLzC2012 = SAP_Module.CalcualtionDER2012.Calculation.AssessmentLZC2012;
        XGraphics xgraphics88 = PDFFunctions.gfx[SAPInput.k];
        string str22 = Conversions.ToString(Math.Round(SAPInput.CodeAssessmentLZC2012.ZC2 + SAPInput.CodeAssessmentLZC2012.ZC3 + Math.Round(num1, 2), 2));
        XFont xfont43 = xfont3;
        XSolidBrush black60 = XBrushes.Black;
        double num283 = (double) num281;
        double num284 = (double) checked (SAPInput.RC1 + 1);
        xunit = PDFFunctions.pages[SAPInput.k].Width;
        double point64 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[SAPInput.k].Height;
        double num285 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect65 = new XRect(num283, num284, point64, num285);
        XStringFormat topLeft65 = XStringFormat.TopLeft;
        xgraphics88.DrawString(str22, xfont43, (XBrush) black60, xrect65, topLeft65);
        XGraphics xgraphics89 = PDFFunctions.gfx[SAPInput.k];
        XPen blackPen24 = PDFFunctions.BlackPen;
        double num286 = (double) checked (SAPInput.RC1 + 15);
        xsize2 = PDFFunctions.gfx[SAPInput.k].PageSize;
        double num287 = ((XSize) ref xsize2).Width - 40.0;
        double num288 = (double) checked (SAPInput.RC1 + 15);
        xgraphics89.DrawLine(blackPen24, 20.0, num286, num287, num288);
        checked { SAPInput.RC1 += 16; }
        XGraphics xgraphics90 = PDFFunctions.gfx[SAPInput.k];
        XFont xfont44 = xfont3;
        XSolidBrush black61 = XBrushes.Black;
        double num289 = (double) checked (SAPInput.RC1 + 1);
        xunit = PDFFunctions.pages[SAPInput.k].Width;
        double point65 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[SAPInput.k].Height;
        double num290 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect66 = new XRect(22.0, num289, point65, num290);
        XStringFormat topLeft66 = XStringFormat.TopLeft;
        xgraphics90.DrawString("Standard DER", xfont44, (XBrush) black61, xrect66, topLeft66);
        xsize2 = PDFFunctions.gfx[SAPInput.k].PageSize;
        double num291 = ((XSize) ref xsize2).Width / 2.0 + 210.0;
        xsize2 = PDFFunctions.gfx[SAPInput.k].MeasureString(Conversions.ToString(Math.Round(ene7.Ene7_.Part1.P1, 2)), xfont3);
        double num292 = ((XSize) ref xsize2).Width / 2.0;
        int num293 = checked ((int) Math.Round(unchecked (num291 - num292)));
        XGraphics xgraphics91 = PDFFunctions.gfx[SAPInput.k];
        string str23 = Conversions.ToString(Math.Round(num1, 2));
        XFont xfont45 = xfont3;
        XSolidBrush black62 = XBrushes.Black;
        double num294 = (double) num293;
        double num295 = (double) checked (SAPInput.RC1 + 1);
        xunit = PDFFunctions.pages[SAPInput.k].Width;
        double point66 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[SAPInput.k].Height;
        double num296 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect67 = new XRect(num294, num295, point66, num296);
        XStringFormat topLeft67 = XStringFormat.TopLeft;
        xgraphics91.DrawString(str23, xfont45, (XBrush) black62, xrect67, topLeft67);
        XGraphics xgraphics92 = PDFFunctions.gfx[SAPInput.k];
        XPen blackPen25 = PDFFunctions.BlackPen;
        double num297 = (double) checked (SAPInput.RC1 + 15);
        xsize2 = PDFFunctions.gfx[SAPInput.k].PageSize;
        double num298 = ((XSize) ref xsize2).Width - 40.0;
        double num299 = (double) checked (SAPInput.RC1 + 15);
        xgraphics92.DrawLine(blackPen25, 20.0, num297, num298, num299);
        checked { SAPInput.RC1 += 16; }
        if (SAP_Module.Proj.Dwellings[House].OverrideEne7)
        {
          XGraphics xgraphics93 = PDFFunctions.gfx[SAPInput.k];
          XFont xfont46 = xfont3;
          XSolidBrush black63 = XBrushes.Black;
          double num300 = (double) checked (SAPInput.RC1 + 1);
          xunit = PDFFunctions.pages[SAPInput.k].Width;
          double point67 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[SAPInput.k].Height;
          double num301 = ((XUnit) ref xunit).Point / 2.0;
          XRect xrect68 = new XRect(22.0, num300, point67, num301);
          XStringFormat topLeft68 = XStringFormat.TopLeft;
          xgraphics93.DrawString("Actual Case CO2 emissions", xfont46, (XBrush) black63, xrect68, topLeft68);
        }
        else
        {
          XGraphics xgraphics94 = PDFFunctions.gfx[SAPInput.k];
          XFont xfont47 = xfont3;
          XSolidBrush black64 = XBrushes.Black;
          double num302 = (double) checked (SAPInput.RC1 + 1);
          xunit = PDFFunctions.pages[SAPInput.k].Width;
          double point68 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[SAPInput.k].Height;
          double num303 = ((XUnit) ref xunit).Point / 2.0;
          XRect xrect69 = new XRect(22.0, num302, point68, num303);
          XStringFormat topLeft69 = XStringFormat.TopLeft;
          xgraphics94.DrawString("Actual Case CO2 emissions", xfont47, (XBrush) black64, xrect69, topLeft69);
        }
        xsize2 = PDFFunctions.gfx[SAPInput.k].PageSize;
        double num304 = ((XSize) ref xsize2).Width / 2.0 + 210.0;
        xsize2 = PDFFunctions.gfx[SAPInput.k].MeasureString(Conversions.ToString(Math.Round(ene7.Ene7_.Part2.P2, 2)), xfont3);
        double num305 = ((XSize) ref xsize2).Width / 2.0;
        int num306 = checked ((int) Math.Round(unchecked (num304 - num305)));
        XGraphics xgraphics95 = PDFFunctions.gfx[SAPInput.k];
        string str24 = Conversions.ToString(Math.Round(SAPInput.CodeAssessmentLZC2012.ZC2 + SAPInput.CodeAssessmentLZC2012.ZC3 + Math.Round(num2, 2), 2));
        XFont xfont48 = xfont3;
        XSolidBrush black65 = XBrushes.Black;
        double num307 = (double) num306;
        double num308 = (double) checked (SAPInput.RC1 + 1);
        xunit = PDFFunctions.pages[SAPInput.k].Width;
        double point69 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[SAPInput.k].Height;
        double num309 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect70 = new XRect(num307, num308, point69, num309);
        XStringFormat topLeft70 = XStringFormat.TopLeft;
        xgraphics95.DrawString(str24, xfont48, (XBrush) black65, xrect70, topLeft70);
        XGraphics xgraphics96 = PDFFunctions.gfx[SAPInput.k];
        XPen blackPen26 = PDFFunctions.BlackPen;
        double num310 = (double) checked (SAPInput.RC1 + 15);
        xsize2 = PDFFunctions.gfx[SAPInput.k].PageSize;
        double num311 = ((XSize) ref xsize2).Width - 40.0;
        double num312 = (double) checked (SAPInput.RC1 + 15);
        xgraphics96.DrawLine(blackPen26, 20.0, num310, num311, num312);
        checked { SAPInput.RC1 += 16; }
        double num313 = Math.Round(SAPInput.CodeAssessmentLZC2012.ZC2 + SAPInput.CodeAssessmentLZC2012.ZC3 + Math.Round(num1, 2), 2);
        double num314 = Math.Round(SAPInput.CodeAssessmentLZC2012.ZC2 + SAPInput.CodeAssessmentLZC2012.ZC3 + Math.Round(num2, 2), 2);
        double num315 = num313 != 0.0 ? (num313 - num314) / num313 * 100.0 : 0.0;
        XGraphics xgraphics97 = PDFFunctions.gfx[SAPInput.k];
        XFont xfont49 = xfont3;
        XSolidBrush black66 = XBrushes.Black;
        double num316 = (double) checked (SAPInput.RC1 + 1);
        xunit = PDFFunctions.pages[SAPInput.k].Width;
        double point70 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[SAPInput.k].Height;
        double num317 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect71 = new XRect(22.0, num316, point70, num317);
        XStringFormat topLeft71 = XStringFormat.TopLeft;
        xgraphics97.DrawString("Actual DER", xfont49, (XBrush) black66, xrect71, topLeft71);
        xsize2 = PDFFunctions.gfx[SAPInput.k].PageSize;
        double num318 = ((XSize) ref xsize2).Width / 2.0 + 210.0;
        xsize2 = PDFFunctions.gfx[SAPInput.k].MeasureString(Conversions.ToString(Math.Round(ene7.Ene7_.Part2.P2, 2)), xfont3);
        double num319 = ((XSize) ref xsize2).Width / 2.0;
        int num320 = checked ((int) Math.Round(unchecked (num318 - num319)));
        XGraphics xgraphics98 = PDFFunctions.gfx[SAPInput.k];
        string str25 = Conversions.ToString(Math.Round(num2, 2));
        XFont xfont50 = xfont3;
        XSolidBrush black67 = XBrushes.Black;
        double num321 = (double) num320;
        double num322 = (double) checked (SAPInput.RC1 + 1);
        xunit = PDFFunctions.pages[SAPInput.k].Width;
        double point71 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[SAPInput.k].Height;
        double num323 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect72 = new XRect(num321, num322, point71, num323);
        XStringFormat topLeft72 = XStringFormat.TopLeft;
        xgraphics98.DrawString(str25, xfont50, (XBrush) black67, xrect72, topLeft72);
        XGraphics xgraphics99 = PDFFunctions.gfx[SAPInput.k];
        XPen blackPen27 = PDFFunctions.BlackPen;
        double num324 = (double) checked (SAPInput.RC1 + 15);
        xsize2 = PDFFunctions.gfx[SAPInput.k].PageSize;
        double num325 = ((XSize) ref xsize2).Width - 40.0;
        double num326 = (double) checked (SAPInput.RC1 + 15);
        xgraphics99.DrawLine(blackPen27, 20.0, num324, num325, num326);
        checked { SAPInput.RC1 += 16; }
        XGraphics xgraphics100 = PDFFunctions.gfx[SAPInput.k];
        XFont xfont51 = xfont3;
        XSolidBrush black68 = XBrushes.Black;
        double num327 = (double) checked (SAPInput.RC1 + 1);
        xunit = PDFFunctions.pages[SAPInput.k].Width;
        double point72 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[SAPInput.k].Height;
        double num328 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect73 = new XRect(22.0, num327, point72, num328);
        XStringFormat topLeft73 = XStringFormat.TopLeft;
        xgraphics100.DrawString("Reduction in CO2 emissions", xfont51, (XBrush) black68, xrect73, topLeft73);
        xsize2 = PDFFunctions.gfx[SAPInput.k].PageSize;
        double num329 = ((XSize) ref xsize2).Width / 2.0 + 150.0;
        xsize2 = PDFFunctions.gfx[SAPInput.k].MeasureString(Conversions.ToString(Math.Round(ene7.Ene7_.P3, 2)), xfont3);
        double num330 = ((XSize) ref xsize2).Width / 2.0;
        int num331 = checked ((int) Math.Round(unchecked (num329 - num330)));
        XGraphics xgraphics101 = PDFFunctions.gfx[SAPInput.k];
        string str26 = Conversions.ToString(Math.Round(num315, 2));
        XFont xfont52 = xfont3;
        XSolidBrush black69 = XBrushes.Black;
        double num332 = (double) num331;
        double num333 = (double) checked (SAPInput.RC1 + 1);
        xunit = PDFFunctions.pages[SAPInput.k].Width;
        double point73 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[SAPInput.k].Height;
        double num334 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect74 = new XRect(num332, num333, point73, num334);
        XStringFormat topLeft74 = XStringFormat.TopLeft;
        xgraphics101.DrawString(str26, xfont52, (XBrush) black69, xrect74, topLeft74);
        XGraphics xgraphics102 = PDFFunctions.gfx[SAPInput.k];
        XPen blackPen28 = PDFFunctions.BlackPen;
        double rc1_27 = (double) SAPInput.RC1;
        xsize2 = PDFFunctions.gfx[SAPInput.k].PageSize;
        double num335 = ((XSize) ref xsize2).Width - 40.0;
        double rc1_28 = (double) SAPInput.RC1;
        xgraphics102.DrawLine(blackPen28, 20.0, rc1_27, num335, rc1_28);
        checked { SAPInput.RC1 += 14; }
        double num336 = num315;
        if (num336 >= 15.0)
        {
          XGraphics xgraphics103 = PDFFunctions.gfx[SAPInput.k];
          XFont arialFont10Bold23 = PDFFunctions.ArialFont10Bold;
          XSolidBrush black70 = XBrushes.Black;
          double num337 = (double) checked (SAPInput.RC1 + 1);
          xunit = PDFFunctions.pages[SAPInput.k].Width;
          double point74 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[SAPInput.k].Height;
          double num338 = ((XUnit) ref xunit).Point / 2.0;
          XRect xrect75 = new XRect(20.0, num337, point74, num338);
          XStringFormat topLeft75 = XStringFormat.TopLeft;
          xgraphics103.DrawString("Credits awarded for ENE 7 = 2", arialFont10Bold23, (XBrush) black70, xrect75, topLeft75);
        }
        else if (num336 >= 10.0)
        {
          XGraphics xgraphics104 = PDFFunctions.gfx[SAPInput.k];
          XFont arialFont10Bold24 = PDFFunctions.ArialFont10Bold;
          XSolidBrush black71 = XBrushes.Black;
          double num339 = (double) checked (SAPInput.RC1 + 1);
          xunit = PDFFunctions.pages[SAPInput.k].Width;
          double point75 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[SAPInput.k].Height;
          double num340 = ((XUnit) ref xunit).Point / 2.0;
          XRect xrect76 = new XRect(20.0, num339, point75, num340);
          XStringFormat topLeft76 = XStringFormat.TopLeft;
          xgraphics104.DrawString("Credits awarded for ENE 7 = 1", arialFont10Bold24, (XBrush) black71, xrect76, topLeft76);
        }
        else
        {
          XGraphics xgraphics105 = PDFFunctions.gfx[SAPInput.k];
          XFont arialFont10Bold25 = PDFFunctions.ArialFont10Bold;
          XSolidBrush black72 = XBrushes.Black;
          double num341 = (double) checked (SAPInput.RC1 + 1);
          xunit = PDFFunctions.pages[SAPInput.k].Width;
          double point76 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[SAPInput.k].Height;
          double num342 = ((XUnit) ref xunit).Point / 2.0;
          XRect xrect77 = new XRect(20.0, num341, point76, num342);
          XStringFormat topLeft77 = XStringFormat.TopLeft;
          xgraphics105.DrawString("Credits awarded for ENE 7 = 0", arialFont10Bold25, (XBrush) black72, xrect77, topLeft77);
        }
        checked { SAPInput.RC1 += 12; }
        XGraphics xgraphics106 = PDFFunctions.gfx[SAPInput.k];
        XFont xfont53 = xfont8;
        XSolidBrush black73 = XBrushes.Black;
        double num343 = (double) checked (SAPInput.RC1 + 1);
        xunit = PDFFunctions.pages[SAPInput.k].Width;
        double point77 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[SAPInput.k].Height;
        double num344 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect78 = new XRect(20.0, num343, point77, num344);
        XStringFormat topLeft78 = XStringFormat.TopLeft;
        xgraphics106.DrawString("Technologies eligible to contribute to achieving the requirements of this issue must produce energy from renewable sources and meet all other ancillary requirements as defined by Directive 2009/28/EC of the ", xfont53, (XBrush) black73, xrect78, topLeft78);
        checked { SAPInput.RC1 += 10; }
        XGraphics xgraphics107 = PDFFunctions.gfx[SAPInput.k];
        XFont xfont54 = xfont8;
        XSolidBrush black74 = XBrushes.Black;
        double num345 = (double) checked (SAPInput.RC1 + 1);
        xunit = PDFFunctions.pages[SAPInput.k].Width;
        double point78 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[SAPInput.k].Height;
        double num346 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect79 = new XRect(20.0, num345, point78, num346);
        XStringFormat topLeft79 = XStringFormat.TopLeft;
        xgraphics107.DrawString(" European Parliament and of the Council of 23 April 2009 on the promotion of the use of energy from renewable sources and amending and subsequently repealing Directives  2001/77/EC and 2003/30/EC.", xfont54, (XBrush) black74, xrect79, topLeft79);
        checked { SAPInput.RC1 += 14; }
        XGraphics xgraphics108 = PDFFunctions.gfx[SAPInput.k];
        XFont xfont55 = xfont8;
        XSolidBrush black75 = XBrushes.Black;
        double num347 = (double) checked (SAPInput.RC1 + 1);
        xunit = PDFFunctions.pages[SAPInput.k].Width;
        double point79 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[SAPInput.k].Height;
        double num348 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect80 = new XRect(20.0, num347, point79, num348);
        XStringFormat topLeft80 = XStringFormat.TopLeft;
        xgraphics108.DrawString("The following requirements must also be met: ", xfont55, (XBrush) black75, xrect80, topLeft80);
        checked { SAPInput.RC1 += 10; }
        XGraphics xgraphics109 = PDFFunctions.gfx[SAPInput.k];
        XFont xfont56 = xfont8;
        XSolidBrush black76 = XBrushes.Black;
        double num349 = (double) checked (SAPInput.RC1 + 1);
        xunit = PDFFunctions.pages[SAPInput.k].Width;
        double point80 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[SAPInput.k].Height;
        double num350 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect81 = new XRect(20.0, num349, point80, num350);
        XStringFormat topLeft81 = XStringFormat.TopLeft;
        xgraphics109.DrawString("•\tWhere not provided by accredited external renewables there must be a direct supply of energy produced to the dwelling under assessment. ", xfont56, (XBrush) black76, xrect81, topLeft81);
        checked { SAPInput.RC1 += 10; }
        XGraphics xgraphics110 = PDFFunctions.gfx[SAPInput.k];
        XFont xfont57 = xfont8;
        XSolidBrush black77 = XBrushes.Black;
        double num351 = (double) checked (SAPInput.RC1 + 1);
        xunit = PDFFunctions.pages[SAPInput.k].Width;
        double point81 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[SAPInput.k].Height;
        double num352 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect82 = new XRect(20.0, num351, point81, num352);
        XStringFormat topLeft82 = XStringFormat.TopLeft;
        xgraphics110.DrawString("•\tWhere covered by the Microgeneration Certification Scheme (MCS), technologies under 50kWe or 300kWth must be certified.", xfont57, (XBrush) black77, xrect82, topLeft82);
        checked { SAPInput.RC1 += 10; }
        XGraphics xgraphics111 = PDFFunctions.gfx[SAPInput.k];
        XFont xfont58 = xfont8;
        XSolidBrush black78 = XBrushes.Black;
        double num353 = (double) checked (SAPInput.RC1 + 1);
        xunit = PDFFunctions.pages[SAPInput.k].Width;
        double point82 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[SAPInput.k].Height;
        double num354 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect83 = new XRect(20.0, num353, point82, num354);
        XStringFormat topLeft83 = XStringFormat.TopLeft;
        xgraphics111.DrawString("•\tCombined Heat and Power (CHP) schemes above 50kWe must be certified under the CHPQA standard.", xfont58, (XBrush) black78, xrect83, topLeft83);
        checked { SAPInput.RC1 += 10; }
        XGraphics xgraphics112 = PDFFunctions.gfx[SAPInput.k];
        XFont xfont59 = xfont8;
        XSolidBrush black79 = XBrushes.Black;
        double num355 = (double) checked (SAPInput.RC1 + 1);
        xunit = PDFFunctions.pages[SAPInput.k].Width;
        double point83 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[SAPInput.k].Height;
        double num356 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect84 = new XRect(20.0, num355, point83, num356);
        XStringFormat topLeft84 = XStringFormat.TopLeft;
        xgraphics112.DrawString("•\tAll technologies must be accounted for by SAP.", xfont59, (XBrush) black79, xrect84, topLeft84);
        checked { SAPInput.RC1 += 10; }
        XGraphics xgraphics113 = PDFFunctions.gfx[SAPInput.k];
        XFont xfont60 = xfont8;
        XSolidBrush black80 = XBrushes.Black;
        double num357 = (double) checked (SAPInput.RC1 + 1);
        xunit = PDFFunctions.pages[SAPInput.k].Width;
        double point84 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[SAPInput.k].Height;
        double num358 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect85 = new XRect(20.0, num357, point84, num358);
        XStringFormat topLeft85 = XStringFormat.TopLeft;
        xgraphics113.DrawString("CHP schemes fuelled by mains gas are eligible to contribute to performance against this issue. Where these schemes are above 50kWe they must be certified under the CHPQA.", xfont60, (XBrush) black80, xrect85, topLeft85);
        checked { SAPInput.RC1 += 10; }
        XGraphics xgraphics114 = PDFFunctions.gfx[SAPInput.k];
        XFont xfont61 = xfont8;
        XSolidBrush black81 = XBrushes.Black;
        double num359 = (double) checked (SAPInput.RC1 + 1);
        xunit = PDFFunctions.pages[SAPInput.k].Width;
        double point85 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[SAPInput.k].Height;
        double num360 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect86 = new XRect(20.0, num359, point85, num360);
        XStringFormat topLeft86 = XStringFormat.TopLeft;
        xgraphics114.DrawString("It is the responsibly of the Accredited OCDEA and Code Assessor to ensure all technologies use in the calculation are appropriate before awarding credits. ", xfont61, (XBrush) black81, xrect86, topLeft86);
        checked { SAPInput.RC1 += 10; }
        int num361 = checked (SAPInput.k + 1);
        XFont xfont62 = new XFont("Arial", 160.0, (XFontStyle) 1);
        PDFFunctions.transbrush = XBrush.op_Implicit((Brush) new SolidBrush(Color.FromArgb(128, Color.Olive)));
        int index2 = 0;
        do
        {
          if (!Validation.UserLogged)
          {
            XGraphics xgraphics115 = PDFFunctions.gfx[index2];
            XFont xfont63 = xfont62;
            XBrush transbrush = PDFFunctions.transbrush;
            xunit = PDFFunctions.pages[SAPInput.k].Width;
            double point86 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[SAPInput.k].Height;
            double point87 = ((XUnit) ref xunit).Point;
            XRect xrect87 = new XRect(0.0, 0.0, point86, point87);
            XStringFormat center = XStringFormat.Center;
            xgraphics115.DrawString("DRAFT", xfont63, transbrush, xrect87, center);
          }
          if (!SAP_Module.Proj.OverRide)
          {
            XGraphics xgraphics116 = PDFFunctions.gfx[index2];
            string str27 = "Stroma FSAP 2012 " + SAP_Module.CurrVersion + " (SAP 9.92) - http://www.stroma.com";
            XFont xfont64 = xfont8;
            XSolidBrush black82 = XBrushes.Black;
            xunit = PDFFunctions.pages[index2].Width;
            double point88 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[index2].Height;
            double point89 = ((XUnit) ref xunit).Point;
            XRect xrect88 = new XRect(20.0, 830.0, point88, point89);
            XStringFormat topLeft87 = XStringFormat.TopLeft;
            xgraphics116.DrawString(str27, xfont64, (XBrush) black82, xrect88, topLeft87);
          }
          else
          {
            XGraphics xgraphics117 = PDFFunctions.gfx[index2];
            string str28 = "Stroma FSAP 2012 " + SAP_Module.Proj.CalcVersion + " (SAP 9.92) - http://www.stroma.com";
            XFont xfont65 = xfont8;
            XSolidBrush black83 = XBrushes.Black;
            xunit = PDFFunctions.pages[index2].Width;
            double point90 = ((XUnit) ref xunit).Point;
            xunit = PDFFunctions.pages[index2].Height;
            double point91 = ((XUnit) ref xunit).Point;
            XRect xrect89 = new XRect(20.0, 830.0, point90, point91);
            XStringFormat topLeft88 = XStringFormat.TopLeft;
            xgraphics117.DrawString(str28, xfont65, (XBrush) black83, xrect89, topLeft88);
          }
          XGraphics xgraphics118 = PDFFunctions.gfx[index2];
          string str29 = "Page " + Conversions.ToString(checked (index2 + 1)) + " of " + Conversions.ToString(num361);
          XFont xfont66 = xfont8;
          XSolidBrush black84 = XBrushes.Black;
          xunit = PDFFunctions.pages[index2].Width;
          double point92 = ((XUnit) ref xunit).Point;
          xunit = PDFFunctions.pages[index2].Height;
          double point93 = ((XUnit) ref xunit).Point;
          XRect xrect90 = new XRect(520.0, 830.0, point92, point93);
          XStringFormat topLeft89 = XStringFormat.TopLeft;
          xgraphics118.DrawString(str29, xfont66, (XBrush) black84, xrect90, topLeft89);
          checked { ++index2; }
        }
        while (index2 <= 0);
        SAP_Module.SAPOverHeatingName = "";
        object folderPath = (object) Environment.GetFolderPath(Environment.SpecialFolder.Personal);
        DirectoryInfo directoryInfo1 = new DirectoryInfo(Conversions.ToString(Operators.ConcatenateObject(folderPath, (object) "\\Stroma SAP 2012")));
        DirectoryInfo directoryInfo2 = new DirectoryInfo(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(folderPath, (object) "\\Stroma SAP 2012\\"), (object) SAP_Module.Proj.Name)));
        if (!directoryInfo2.Exists)
          directoryInfo2.Create();
        DirectoryInfo directoryInfo3 = new DirectoryInfo(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(folderPath, (object) "\\Stroma SAP 2012\\"), (object) SAP_Module.Proj.Name), (object) "\\"), (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Name)));
        if (!directoryInfo3.Exists)
          directoryInfo3.Create();
        SAP_Module.ZerocarbonEPC = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(folderPath, (object) "\\Stroma SAP 2012\\"), (object) SAP_Module.Proj.Name), (object) "\\"), (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Name), (object) "\\"), (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Name), (object) "-CSH Report.pdf"));
        PDFFunctions.document.Save(SAP_Module.ZerocarbonEPC);
        SAP_Module.DoCodereport = false;
        zerocarbonEpc = SAP_Module.ZerocarbonEPC;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num362 = (int) Interaction.MsgBox((object) ex.Message);
        ProjectData.ClearProjectError();
      }
      return zerocarbonEpc;
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
  }
}
