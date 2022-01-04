
// Type: SAP2012.PDFFunctions




using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace SAP2012
{
  [StandardModule]
  internal sealed class PDFFunctions
  {
    public static PdfDocument document = new PdfDocument();
    public static PdfPage[] pages = new PdfPage[21];
    public static XGraphics[] gfx = new XGraphics[21];
    public static XBrush xBrush1;
    public static PointF[] Points = new PointF[4];
    public static string PDFData;
    public static string PDFInputvalues;
    public static XPen poly = new XPen(XColor.FromArgb(179, 3, 55));
    public static XPen polyGreen = new XPen(XColor.FromArgb(115, 162, 214));
    public static XPen polyGreen2 = new XPen(XColor.FromArgb(159, 172, 62));
    public static XPen BlackPen = new XPen(XColor.FromArgb(0, 0, 0));
    public static XFillMode Fill;
    public static XFont ArialFont12Bold = new XFont("Arial", 12.0, (XFontStyle) 1);
    public static XFont ArialFont11 = new XFont("Arial", 11.0, (XFontStyle) 0);
    public static XFont ArialFont10Italic = new XFont("Arial", 10.0, (XFontStyle) 2);
    public static XFont ArialFont10 = new XFont("Arial", 10.0, (XFontStyle) 0);
    public static XFont ArialFont10Bold = new XFont("Arial", 10.0, (XFontStyle) 1);
    public static XFont ArialFont8Italic = new XFont("Arial", 8.0, (XFontStyle) 2);
    public static XFont Arialfont = new XFont("Arial", 16.0, (XFontStyle) 1);
    public static XFont ArialFont11Bold = new XFont("Arial", 11.0, (XFontStyle) 1);
    public static XFont ArialFont8Bold = new XFont("Arial", 8.0, (XFontStyle) 1);
    public static XFont ArialFont8 = new XFont("Arial", 8.0, (XFontStyle) 0);
    public static XFont ArialFont4 = new XFont("Arial", 4.0, (XFontStyle) 0);
    public static XFont ArialFont9 = new XFont("Arial", 9.0, (XFontStyle) 0);
    public static XFont ArialFont16Bold = new XFont("Arial", 16.0, (XFontStyle) 1);
    public static XFont ArialFont14Bold = new XFont("Arial", 14.0, (XFontStyle) 1);
    public static XFont ArialFont6 = new XFont("Arial", 6.0, (XFontStyle) 0);
    public static XPen polygraphics = new XPen(XColor.FromArgb(0, 115, 187));
    public static XPen polyWhite = new XPen(XColor.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue));
    public static XPen BluePen = new XPen(XColor.FromArgb(0, 0, (int) byte.MaxValue));
    public static Image myImage;
    public static Image myImage2;
    public static Image myImage3;
    public static Image myImage4;
    public static XBrush transbrush;
    public static XFont DraftArialFont200 = new XFont("Arial", 160.0, (XFontStyle) 1);
    public static int CountLen;
    public static string[] PrintTextC = new string[23];
    public static int Current_View;
    public static bool Draft_PDF;
    public static bool MainHeating2Search;
    public static string[] PrintNotes = new string[1001];
    public static XPdfFontOptions options = new XPdfFontOptions((PdfFontEncoding) 1, (PdfFontEmbedding) 2);
    public static XFont DilleniaUPC11Bold = new XFont("DilleniaUPC", 20.0, (XFontStyle) 1);
    public static XFont DilleniaUPCBold8 = new XFont("DilleniaUPC", 10.0, (XFontStyle) 1);
    public static XFont DilleniaUPCFont8 = new XFont("DilleniaUPC", 10.0, (XFontStyle) 0);
    public static XFont DilleniaUPC10 = new XFont("DilleniaUPC", 16.0, (XFontStyle) 0);
    public static XFont DilleniaUPC16 = new XFont("DilleniaUPC", 32.0, (XFontStyle) 0);

    public static void PrintUserDetails(XGraphics gfx)
    {
      int num1 = 15;
      if (!string.IsNullOrEmpty(UserSettings.USettings.PrintUserSettings.CompanyName))
      {
        gfx.DrawString(UserSettings.USettings.PrintUserSettings.CompanyName, PDFFunctions.ArialFont10Italic, (XBrush) XBrushes.DarkGray, new XRect(20.0, (double) num1, 500.0, 200.0), XStringFormat.TopLeft);
        checked { num1 += 11; }
      }
      if (!string.IsNullOrEmpty(UserSettings.USettings.PrintUserSettings.ContactName))
      {
        gfx.DrawString(UserSettings.USettings.PrintUserSettings.ContactName, PDFFunctions.ArialFont10Italic, (XBrush) XBrushes.DarkGray, new XRect(20.0, (double) num1, 500.0, 200.0), XStringFormat.TopLeft);
        checked { num1 += 11; }
      }
      if (!string.IsNullOrEmpty(UserSettings.USettings.PrintUserSettings.PhoneNo))
      {
        gfx.DrawString(UserSettings.USettings.PrintUserSettings.PhoneNo, PDFFunctions.ArialFont10Italic, (XBrush) XBrushes.DarkGray, new XRect(20.0, (double) num1, 500.0, 200.0), XStringFormat.TopLeft);
        checked { num1 += 11; }
      }
      if (string.IsNullOrEmpty(UserSettings.USettings.PrintUserSettings.ContactEmail))
        return;
      gfx.DrawString(UserSettings.USettings.PrintUserSettings.ContactEmail, PDFFunctions.ArialFont10Italic, (XBrush) XBrushes.DarkGray, new XRect(20.0, (double) num1, 50.0, 200.0), XStringFormat.TopLeft);
      int num2 = checked (num1 + 11);
    }

    public static Image DrawEnvironGraph(int Country, int House)
    {
      int num1;
      Image image1;
      int num2;
      try
      {
label_2:
        ProjectData.ClearProjectError();
        num1 = -2;
label_3:
        int num3 = 2;
        int width1 = 1344;
label_4:
        num3 = 3;
        int num4 = 1088;
label_5:
        num3 = 4;
        image1 = (Image) new Bitmap(width1, num4);
label_6:
        num3 = 5;
        Graphics graphics1 = Graphics.FromImage(image1);
label_7:
        num3 = 6;
        Font font1 = new Font("Arial", 64f, FontStyle.Bold);
label_8:
        num3 = 7;
        Font font2 = new Font("Arial", 56f, FontStyle.Bold);
label_9:
        num3 = 8;
        Font font3 = new Font("Arial", 36f, FontStyle.Regular);
label_10:
        num3 = 9;
        Font font4 = new Font("Arial", 32f, FontStyle.Bold);
label_11:
        num3 = 10;
        Font font5 = new Font("Arial", 28f, FontStyle.Italic);
label_12:
        num3 = 11;
        Font font6 = new Font("Arial", 28f, FontStyle.Bold);
label_13:
        num3 = 12;
        Font font7 = new Font("Arial", 24f, FontStyle.Regular);
label_14:
        num3 = 13;
        Pen pen1 = (Pen) Pens.Black.Clone();
label_15:
        num3 = 14;
        pen1.Width = 5f;
label_16:
        num3 = 15;
        Pen pen2 = (Pen) Pens.Black.Clone();
label_17:
        num3 = 16;
        pen2.Width = 3f;
label_18:
        num3 = 17;
        Pen pen3 = new Pen(Color.Black, 2f);
label_19:
        num3 = 18;
        Graphics graphics2 = graphics1;
label_20:
        num3 = 19;
        graphics2.TextRenderingHint = TextRenderingHint.AntiAlias;
label_21:
        num3 = 20;
        graphics2.SmoothingMode = SmoothingMode.AntiAlias;
label_22:
        num3 = 21;
        graphics1.FillRectangle(Brushes.White, 0, 0, width1, num4);
label_23:
        num3 = 22;
        graphics2.DrawLine(pen1, 1, 1, checked (width1 - 1), 1);
label_24:
        num3 = 23;
        graphics2.DrawLine(pen1, checked (width1 - 1), 1, checked (width1 - 1), checked (num4 - 1));
label_25:
        num3 = 24;
        graphics2.DrawLine(pen1, checked (width1 - 1), checked (num4 - 1), 1, checked (num4 - 1));
label_26:
        num3 = 25;
        graphics2.DrawLine(pen1, 1, checked (num4 - 1), 1, 1);
label_27:
        num3 = 26;
        int num5 = checked ((int) Math.Round(unchecked (0.688 * (double) width1)));
label_28:
        num3 = 27;
        int num6 = checked ((int) Math.Round(unchecked (0.885 * (double) num4)));
label_29:
        num3 = 28;
        graphics2.DrawLine(pen1, num5, num6, num5, 1);
label_30:
        num3 = 29;
        num5 = checked ((int) Math.Round(unchecked (0.845 * (double) width1)));
label_31:
        num3 = 30;
        graphics2.DrawLine(pen1, num5, num6, num5, 1);
label_32:
        num3 = 31;
        if (!(Country == 2 & Operators.CompareString(SAP_Module.Proj.Dwellings[House].EPCLanguage, "Welsh", false) == 0))
          goto label_42;
label_33:
        num3 = 32;
        num5 = checked ((int) Math.Round(unchecked (0.766 * (double) width1 - (double) graphics2.MeasureString("Cyfredol", font4, 500).Width / 2.0)));
label_34:
        num3 = 33;
        num6 = checked ((int) Math.Round(unchecked (0.2 * (double) font4.GetHeight())));
label_35:
        num3 = 34;
        graphics2.DrawString("Cyfredol", font4, Brushes.Black, (float) num5, (float) num6);
label_36:
        num3 = 35;
        num5 = checked ((int) Math.Round(unchecked (0.921 * (double) width1 - (double) graphics2.MeasureString("Potensial", font4, 500).Width / 2.0)));
label_37:
        num3 = 36;
        num6 = checked ((int) Math.Round(unchecked (0.2 * (double) font4.GetHeight())));
label_38:
        num3 = 37;
        graphics2.DrawString("Potensial", font4, Brushes.Black, (float) num5, (float) num6);
label_39:
        num3 = 38;
        num5 = checked ((int) Math.Round(unchecked (0.02 * (double) width1)));
label_40:
        num3 = 39;
        num6 = checked ((int) Math.Round(unchecked (1.6 * (double) font4.GetHeight())));
label_41:
        num3 = 40;
        graphics2.DrawString("Amgylcheddol gyfeillgar iawn – allyriadau CO2 is", font5, Brushes.Black, (float) num5, (float) num6);
        goto label_52;
label_42:
        num3 = 42;
        num5 = checked ((int) Math.Round(unchecked (0.766 * (double) width1 - (double) graphics2.MeasureString("Current", font4, 500).Width / 2.0)));
label_43:
        num3 = 43;
        num6 = checked ((int) Math.Round(unchecked (0.2 * (double) font4.GetHeight())));
label_44:
        num3 = 44;
        graphics2.DrawString("Current", font4, Brushes.Black, (float) num5, (float) num6);
label_45:
        num3 = 45;
        num5 = checked ((int) Math.Round(unchecked (0.921 * (double) width1 - (double) graphics2.MeasureString("Potential", font4, 500).Width / 2.0)));
label_46:
        num3 = 46;
        num6 = checked ((int) Math.Round(unchecked (0.2 * (double) font4.GetHeight())));
label_47:
        num3 = 47;
        graphics2.DrawString("Potential", font4, Brushes.Black, (float) num5, (float) num6);
label_48:
        num3 = 48;
        num5 = checked ((int) Math.Round(unchecked (0.02 * (double) width1)));
label_49:
        num3 = 49;
        num6 = checked ((int) Math.Round(unchecked (1.6 * (double) font4.GetHeight())));
label_50:
        num3 = 50;
        graphics2.DrawString("Very environmentally friendly - lower CO2 emissions", font5, Brushes.Black, (float) num5, (float) num6);
label_51:
label_52:
        num3 = 52;
        num6 = checked ((int) Math.Round(unchecked (0.063 * (double) num4)));
label_53:
        num3 = 53;
        graphics2.DrawLine(pen1, 1, num6, checked (width1 - 1), num6);
label_54:
        num3 = 54;
        Brush brush = (Brush) new SolidBrush(Color.FromArgb(205, 226, 245));
label_55:
        num3 = 55;
        num5 = checked ((int) Math.Round(unchecked (0.01 * (double) width1)));
label_56:
        num3 = 56;
        num6 = checked ((int) Math.Round(unchecked (0.127 * (double) num4)));
label_57:
        num3 = 57;
        int width2 = checked ((int) Math.Round(unchecked (0.221 * (double) width1)));
label_58:
        num3 = 58;
        int height = checked ((int) Math.Round(unchecked (0.086585 * (double) num4)));
label_59:
        num3 = 59;
        graphics2.FillRectangle(brush, num5, num6, width2, height);
label_60:
        num3 = 60;
        num6 = checked ((int) Math.Round(unchecked ((double) num6 + (double) height / 2.0 - (double) graphics2.MeasureString("()", font6, 500).Height / 2.0)));
label_61:
        num3 = 61;
        num5 = checked ((int) Math.Round(unchecked (0.025 * (double) width1)));
label_62:
        num3 = 62;
        graphics2.DrawString("(92 plus)", font6, Brushes.Black, (float) num5, (float) num6);
label_63:
        num3 = 63;
        num5 = checked ((int) Math.Round(unchecked (0.158 * (double) width1)));
label_64:
        num3 = 64;
        num6 = checked ((int) Math.Round(unchecked (0.127 * (double) num4 + (double) height / 2.0 - (double) graphics2.MeasureString("A", font1, 900).Height / 2.1)));
label_65:
        num3 = 65;
        GraphicsPath path = new GraphicsPath();
label_66:
        num3 = 66;
        path.AddString("A", font1.FontFamily, 1, 84f, new Point(num5, num6), StringFormat.GenericTypographic);
label_67:
        num3 = 67;
        graphics2.FillPath(Brushes.White, path);
label_68:
        num3 = 68;
        graphics2.DrawPath(pen2, path);
label_69:
        num3 = 69;
        num5 = checked ((int) Math.Round(unchecked (0.01 * (double) width1)));
label_70:
        num3 = 70;
        brush = (Brush) new SolidBrush(Color.FromArgb(151, 192, 239));
label_71:
        num3 = 71;
        num6 = checked ((int) Math.Round(unchecked (0.227 * (double) num4)));
label_72:
        num3 = 72;
        width2 = checked ((int) Math.Round(unchecked (0.295 * (double) width1)));
label_73:
        num3 = 73;
        graphics2.FillRectangle(brush, num5, num6, width2, height);
label_74:
        num3 = 74;
        num6 = checked ((int) Math.Round(unchecked ((double) num6 + (double) height / 2.0 - (double) graphics2.MeasureString("()", font6, 900).Height / 2.0)));
label_75:
        num3 = 75;
        num5 = checked ((int) Math.Round(unchecked (0.025 * (double) width1)));
label_76:
        num3 = 76;
        graphics2.DrawString("(81-91)", font6, Brushes.Black, (float) num5, (float) num6);
label_77:
        num3 = 77;
        num5 = checked ((int) Math.Round(unchecked (0.239 * (double) width1)));
label_78:
        num3 = 78;
        num6 = checked ((int) Math.Round(unchecked (0.227 * (double) num4 + (double) height / 2.0 - (double) graphics2.MeasureString("B", font1, 500).Height / 2.1)));
label_79:
        num3 = 79;
        path.AddString("B", font1.FontFamily, 1, 84f, new Point(num5, num6), StringFormat.GenericTypographic);
label_80:
        num3 = 80;
        graphics2.FillPath(Brushes.White, path);
label_81:
        num3 = 81;
        graphics2.DrawPath(pen2, path);
label_82:
        num3 = 82;
        num5 = checked ((int) Math.Round(unchecked (0.01 * (double) width1)));
label_83:
        num3 = 83;
        brush = (Brush) new SolidBrush(Color.FromArgb(115, 162, 214));
label_84:
        num3 = 84;
        num6 = checked ((int) Math.Round(unchecked (0.327 * (double) num4)));
label_85:
        num3 = 85;
        width2 = checked ((int) Math.Round(unchecked (0.37 * (double) width1)));
label_86:
        num3 = 86;
        graphics2.FillRectangle(brush, num5, num6, width2, height);
label_87:
        num3 = 87;
        num6 = checked ((int) Math.Round(unchecked ((double) num6 + (double) height / 2.0 - (double) graphics2.MeasureString("()", font6, 900).Height / 2.0)));
label_88:
        num3 = 88;
        num5 = checked ((int) Math.Round(unchecked (0.025 * (double) width1)));
label_89:
        num3 = 89;
        graphics2.DrawString("(69-80)", font6, Brushes.Black, (float) num5, (float) num6);
label_90:
        num3 = 90;
        num5 = checked ((int) Math.Round(unchecked (0.307 * (double) width1)));
label_91:
        num3 = 91;
        num6 = checked ((int) Math.Round(unchecked (0.327 * (double) num4 + (double) height / 2.0 - (double) graphics2.MeasureString("C", font1, 500).Height / 2.1)));
label_92:
        num3 = 92;
        path.AddString("C", font1.FontFamily, 1, 84f, new Point(num5, num6), StringFormat.GenericTypographic);
label_93:
        num3 = 93;
        graphics2.FillPath(Brushes.White, path);
label_94:
        num3 = 94;
        graphics2.DrawPath(pen2, path);
label_95:
        num3 = 95;
        num5 = checked ((int) Math.Round(unchecked (0.01 * (double) width1)));
label_96:
        num3 = 96;
        brush = (Brush) new SolidBrush(Color.FromArgb(78, 132, 196));
label_97:
        num3 = 97;
        num6 = checked ((int) Math.Round(unchecked (0.427 * (double) num4)));
label_98:
        num3 = 98;
        width2 = checked ((int) Math.Round(unchecked (0.445 * (double) width1)));
label_99:
        num3 = 99;
        graphics2.FillRectangle(brush, num5, num6, width2, height);
label_100:
        num3 = 100;
        num6 = checked ((int) Math.Round(unchecked ((double) num6 + (double) height / 2.0 - (double) graphics2.MeasureString("()", font6, 900).Height / 2.0)));
label_101:
        num3 = 101;
        num5 = checked ((int) Math.Round(unchecked (0.025 * (double) width1)));
label_102:
        num3 = 102;
        graphics2.DrawString("(55-68)", font6, Brushes.Black, (float) num5, (float) num6);
label_103:
        num3 = 103;
        num5 = checked ((int) Math.Round(unchecked (0.387 * (double) width1)));
label_104:
        num3 = 104;
        num6 = checked ((int) Math.Round(unchecked (0.427 * (double) num4 + (double) height / 2.0 - (double) graphics2.MeasureString("D", font1, 500).Height / 2.1)));
label_105:
        num3 = 105;
        path.AddString("D", font1.FontFamily, 1, 84f, new Point(num5, num6), StringFormat.GenericTypographic);
label_106:
        num3 = 106;
        graphics2.FillPath(Brushes.White, path);
label_107:
        num3 = 107;
        graphics2.DrawPath(pen2, path);
label_108:
        num3 = 108;
        num5 = checked ((int) Math.Round(unchecked (0.01 * (double) width1)));
label_109:
        num3 = 109;
        brush = (Brush) new SolidBrush(Color.FromArgb(168, 168, 168));
label_110:
        num3 = 110;
        num6 = checked ((int) Math.Round(unchecked (0.527 * (double) num4)));
label_111:
        num3 = 111;
        width2 = checked ((int) Math.Round(unchecked (0.518 * (double) width1)));
label_112:
        num3 = 112;
        graphics2.FillRectangle(brush, num5, num6, width2, height);
label_113:
        num3 = 113;
        num6 = checked ((int) Math.Round(unchecked ((double) num6 + (double) height / 2.0 - (double) graphics2.MeasureString("()", font6, 900).Height / 2.0)));
label_114:
        num3 = 114;
        num5 = checked ((int) Math.Round(unchecked (0.025 * (double) width1)));
label_115:
        num3 = 115;
        graphics2.DrawString("(39-54)", font6, Brushes.Black, (float) num5, (float) num6);
label_116:
        num3 = 116;
        num5 = checked ((int) Math.Round(unchecked (0.459 * (double) width1)));
label_117:
        num3 = 117;
        num6 = checked ((int) Math.Round(unchecked (0.527 * (double) num4 + (double) height / 2.0 - (double) graphics2.MeasureString("E", font1, 500).Height / 2.1)));
label_118:
        num3 = 118;
        path.AddString("E", font1.FontFamily, 1, 84f, new Point(num5, num6), StringFormat.GenericTypographic);
label_119:
        num3 = 119;
        graphics2.FillPath(Brushes.White, path);
label_120:
        num3 = 120;
        graphics2.DrawPath(pen2, path);
label_121:
        num3 = 121;
        num5 = checked ((int) Math.Round(unchecked (0.01 * (double) width1)));
label_122:
        num3 = 122;
        brush = (Brush) new SolidBrush(Color.FromArgb(134, 134, 134));
label_123:
        num3 = 123;
        num6 = checked ((int) Math.Round(unchecked (0.627 * (double) num4)));
label_124:
        num3 = 124;
        width2 = checked ((int) Math.Round(unchecked (0.592 * (double) width1)));
label_125:
        num3 = 125;
        graphics2.FillRectangle(brush, num5, num6, width2, height);
label_126:
        num3 = 126;
        num6 = checked ((int) Math.Round(unchecked ((double) num6 + (double) height / 2.0 - (double) graphics2.MeasureString("()", font6, 900).Height / 2.0)));
label_127:
        num3 = (int) sbyte.MaxValue;
        num5 = checked ((int) Math.Round(unchecked (0.025 * (double) width1)));
label_128:
        num3 = 128;
        graphics2.DrawString("(21-38)", font6, Brushes.White, (float) num5, (float) num6);
label_129:
        num3 = 129;
        num5 = checked ((int) Math.Round(unchecked (0.536 * (double) width1)));
label_130:
        num3 = 130;
        num6 = checked ((int) Math.Round(unchecked (0.627 * (double) num4 + (double) height / 2.0 - (double) graphics2.MeasureString("F", font1, 500).Height / 2.1)));
label_131:
        num3 = 131;
        path.AddString("F", font1.FontFamily, 1, 84f, new Point(num5, num6), StringFormat.GenericTypographic);
label_132:
        num3 = 132;
        graphics2.FillPath(Brushes.White, path);
label_133:
        num3 = 133;
        graphics2.DrawPath(pen2, path);
label_134:
        num3 = 134;
        num5 = checked ((int) Math.Round(unchecked (0.01 * (double) width1)));
label_135:
        num3 = 135;
        brush = (Brush) new SolidBrush(Color.FromArgb(104, 104, 104));
label_136:
        num3 = 136;
        num6 = checked ((int) Math.Round(unchecked (0.727 * (double) num4)));
label_137:
        num3 = 137;
        width2 = checked ((int) Math.Round(unchecked (0.668 * (double) width1)));
label_138:
        num3 = 138;
        graphics2.FillRectangle(brush, num5, num6, width2, height);
label_139:
        num3 = 139;
        num6 = checked ((int) Math.Round(unchecked ((double) num6 + (double) height / 2.0 - (double) graphics2.MeasureString("()", font6, 900).Height / 2.0)));
label_140:
        num3 = 140;
        num5 = checked ((int) Math.Round(unchecked (0.025 * (double) width1)));
label_141:
        num3 = 141;
        graphics2.DrawString("(1-20)", font6, Brushes.White, (float) num5, (float) num6);
label_142:
        num3 = 142;
        num5 = checked ((int) Math.Round(unchecked (0.607 * (double) width1)));
label_143:
        num3 = 143;
        num6 = checked ((int) Math.Round(unchecked (0.727 * (double) num4 + (double) height / 2.0 - (double) graphics2.MeasureString("G", font1, 500).Height / 2.1)));
label_144:
        num3 = 144;
        path.AddString("G", font1.FontFamily, 1, 84f, new Point(num5, num6), StringFormat.GenericTypographic);
label_145:
        num3 = 145;
        graphics2.FillPath(Brushes.White, path);
label_146:
        num3 = 146;
        graphics2.DrawPath(pen2, path);
label_147:
        num3 = 147;
        num5 = checked ((int) Math.Round(unchecked (0.01 * (double) width1)));
label_148:
        num3 = 148;
        num6 = checked ((int) Math.Round(unchecked (0.885 * (double) num4)));
label_149:
        num3 = 149;
        graphics2.DrawLine(pen1, 1, num6, checked (width1 - 1), num6);
label_150:
        num3 = 150;
        num6 = checked ((int) Math.Round(unchecked ((0.885 * (double) num4 - (0.727 * (double) num4 + 0.086585 * (double) num4)) / 2.0 + (0.727 * (double) num4 + 0.086585 * (double) num4) - (double) graphics2.MeasureString("Potential", font5, 500).Height / 2.0)));
label_151:
        num3 = 151;
        num5 = checked ((int) Math.Round(unchecked (0.02 * (double) width1)));
label_152:
        num3 = 152;
        if (!(Country == 2 & Operators.CompareString(SAP_Module.Proj.Dwellings[House].EPCLanguage, "Welsh", false) == 0))
          goto label_164;
label_153:
        num3 = 153;
        graphics2.DrawString("Ddim yn amgylcheddol gyfeillgar - allyriadau CO2 uwch", font5, Brushes.Black, (float) num5, (float) num6);
label_154:
        num3 = 154;
        num6 = checked ((int) Math.Round(unchecked (23.0 / 400.0 * (double) num4 + 0.885 * (double) num4 - 0.5 * (double) graphics2.MeasureString("Cymru a Lloegr", font2, 900).Height)));
label_155:
        num3 = 155;
        num5 = checked ((int) Math.Round(unchecked (0.025 * (double) width1)));
label_156:
        num3 = 156;
        graphics2.DrawString("Cymru a Lloegr", font2, Brushes.Black, (float) num5, (float) num6);
label_157:
        num3 = 157;
        num6 = checked ((int) Math.Round(unchecked (23.0 / 400.0 * (double) num4 + 0.885 * (double) num4 - (double) graphics2.MeasureString("Cyfarwyddeb 2002/91/EC", font7, 500).Height)));
label_158:
        num3 = 158;
        num5 = checked ((int) Math.Round(unchecked (0.59 * (double) width1)));
label_159:
        num3 = 159;
        graphics2.DrawString("Cyfarwyddeb 2002/91/EC", font7, Brushes.Black, (float) num5, (float) num6);
label_160:
        num3 = 160;
        num6 = checked ((int) Math.Round(unchecked (23.0 / 400.0 * (double) num4 + 0.885 * (double) num4)));
label_161:
        num3 = 161;
        num5 = checked ((int) Math.Round(unchecked (0.63 * (double) width1)));
label_162:
        num3 = 162;
        graphics2.DrawString("yr Undeb Ewropeaidd", font7, Brushes.Black, (float) num5, (float) num6);
label_163:
        num3 = 163;
        num6 = checked ((int) Math.Round(unchecked (23.0 / 400.0 * (double) num4 + 0.885 * (double) num4 - 0.52 * (double) graphics2.MeasureString("Cymru a Lloegr", font2, 900).Height)));
        goto label_189;
label_164:
        num3 = 165;
        if (Country != 4)
          goto label_176;
label_165:
        num3 = 166;
        graphics2.DrawString("Not environmentally friendly - higher CO2 emissions", font5, Brushes.Black, (float) num5, (float) num6);
label_166:
        num3 = 167;
        num6 = checked ((int) Math.Round(unchecked (23.0 / 400.0 * (double) num4 + 0.885 * (double) num4 - 0.5 * (double) graphics2.MeasureString("Scotland", font2, 900).Height)));
label_167:
        num3 = 168;
        num5 = checked ((int) Math.Round(unchecked (0.025 * (double) width1)));
label_168:
        num3 = 169;
        graphics2.DrawString("Scotland", font2, Brushes.Black, (float) num5, (float) num6);
label_169:
        num3 = 170;
        num6 = checked ((int) Math.Round(unchecked (23.0 / 400.0 * (double) num4 + 0.885 * (double) num4 - (double) graphics2.MeasureString("EU Directive", font3, 500).Height)));
label_170:
        num3 = 171;
        num5 = checked ((int) Math.Round(unchecked (0.66 * (double) width1)));
label_171:
        num3 = 172;
        graphics2.DrawString("EU Directive", font3, Brushes.Black, (float) num5, (float) num6);
label_172:
        num3 = 173;
        num6 = checked ((int) Math.Round(unchecked (23.0 / 400.0 * (double) num4 + 0.885 * (double) num4)));
label_173:
        num3 = 174;
        num5 = checked ((int) Math.Round(unchecked (0.66 * (double) width1)));
label_174:
        num3 = 175;
        graphics2.DrawString("2002/91/EC", font3, Brushes.Black, (float) num5, (float) num6);
label_175:
        num3 = 176;
        num6 = checked ((int) Math.Round(unchecked (23.0 / 400.0 * (double) num4 + 0.885 * (double) num4 - 0.52 * (double) graphics2.MeasureString("Scotland", font2, 900).Height)));
        goto label_188;
label_176:
        num3 = 178;
        graphics2.DrawString("Not environmentally friendly - higher CO2 emissions", font5, Brushes.Black, (float) num5, (float) num6);
label_177:
        num3 = 179;
        num6 = checked ((int) Math.Round(unchecked (23.0 / 400.0 * (double) num4 + 0.885 * (double) num4 - 0.5 * (double) graphics2.MeasureString("England & Wales", font2, 900).Height)));
label_178:
        num3 = 180;
        num5 = checked ((int) Math.Round(unchecked (0.025 * (double) width1)));
label_179:
        num3 = 181;
        graphics2.DrawString("England & Wales", font2, Brushes.Black, (float) num5, (float) num6);
label_180:
        num3 = 182;
        num6 = checked ((int) Math.Round(unchecked (23.0 / 400.0 * (double) num4 + 0.885 * (double) num4 - (double) graphics2.MeasureString("EU Directive", font3, 500).Height)));
label_181:
        num3 = 183;
        num5 = checked ((int) Math.Round(unchecked (0.66 * (double) width1)));
label_182:
        num3 = 184;
        graphics2.DrawString("EU Directive", font3, Brushes.Black, (float) num5, (float) num6);
label_183:
        num3 = 185;
        num6 = checked ((int) Math.Round(unchecked (23.0 / 400.0 * (double) num4 + 0.885 * (double) num4)));
label_184:
        num3 = 186;
        num5 = checked ((int) Math.Round(unchecked (0.66 * (double) width1)));
label_185:
        num3 = 187;
        graphics2.DrawString("2002/91/EC", font3, Brushes.Black, (float) num5, (float) num6);
label_186:
        num3 = 188;
        num6 = checked ((int) Math.Round(unchecked (23.0 / 400.0 * (double) num4 + 0.885 * (double) num4 - 0.52 * (double) graphics2.MeasureString("England & Wales", font2, 900).Height)));
label_187:
label_188:
label_189:
        num3 = 191;
        num5 = checked ((int) Math.Round(unchecked (0.88 * (double) width1)));
label_190:
        num3 = 192;
        Image image2 = Image.FromFile(Application.StartupPath + "\\Resources\\EU.bmp");
label_191:
        num3 = 193;
        width2 = checked ((int) Math.Round(unchecked ((double) image2.Width / 2.75)));
label_192:
        num3 = 194;
        height = checked ((int) Math.Round(unchecked ((double) image2.Height / 2.75)));
label_193:
        num3 = 195;
        graphics2.DrawImage(image2, num5, num6, width2, height);
label_194:
        num3 = 196;
        Point[] points = new Point[5];
label_195:
        num3 = 197;
label_196:
        num3 = 198;
        if (SAP_Module.Calculation2012.Calculation.CO2_Emissions_12a.EIValue != 0.0)
          goto label_198;
label_197:
        num3 = 199;
        object obj1 = (object) Math.Round(SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.EIRating, 0);
        goto label_200;
label_198:
        num3 = 201;
        obj1 = (object) Math.Round(SAP_Module.Calculation2012.Calculation.CO2_Emissions_12a.EIValue, 0);
label_199:
label_200:
label_201:
        num3 = 203;
        object Left1 = obj1;
label_202:
        num3 = 205;
        if (!Conversions.ToBoolean((object) (bool) (!Conversions.ToBoolean(Operators.CompareObjectGreaterEqual(Left1, (object) 1, false)) ? 0 : (Conversions.ToBoolean(Operators.CompareObjectLessEqual(Left1, (object) 20, false)) ? 1 : 0))))
          goto label_207;
label_203:
        num3 = 206;
        float Left2 = 0.727f;
label_204:
        num3 = 207;
        float Left3 = 20f;
label_205:
        num3 = 208;
        float num7 = 1f;
label_206:
        num3 = 209;
        brush = (Brush) new SolidBrush(Color.FromArgb(104, 104, 104));
        goto label_237;
label_207:
        num3 = 211;
        if (!Conversions.ToBoolean((object) (bool) (!Conversions.ToBoolean(Operators.CompareObjectGreaterEqual(Left1, (object) 21, false)) ? 0 : (Conversions.ToBoolean(Operators.CompareObjectLessEqual(Left1, (object) 38, false)) ? 1 : 0))))
          goto label_212;
label_208:
        num3 = 212;
        Left2 = 0.627f;
label_209:
        num3 = 213;
        Left3 = 38f;
label_210:
        num3 = 214;
        num7 = 21f;
label_211:
        num3 = 215;
        brush = (Brush) new SolidBrush(Color.FromArgb(134, 134, 134));
        goto label_237;
label_212:
        num3 = 217;
        if (!Conversions.ToBoolean((object) (bool) (!Conversions.ToBoolean(Operators.CompareObjectGreaterEqual(Left1, (object) 39, false)) ? 0 : (Conversions.ToBoolean(Operators.CompareObjectLessEqual(Left1, (object) 54, false)) ? 1 : 0))))
          goto label_217;
label_213:
        num3 = 218;
        Left2 = 0.527f;
label_214:
        num3 = 219;
        Left3 = 54f;
label_215:
        num3 = 220;
        num7 = 39f;
label_216:
        num3 = 221;
        brush = (Brush) new SolidBrush(Color.FromArgb(168, 168, 168));
        goto label_237;
label_217:
        num3 = 223;
        if (!Conversions.ToBoolean((object) (bool) (!Conversions.ToBoolean(Operators.CompareObjectGreaterEqual(Left1, (object) 55, false)) ? 0 : (Conversions.ToBoolean(Operators.CompareObjectLessEqual(Left1, (object) 68, false)) ? 1 : 0))))
          goto label_222;
label_218:
        num3 = 224;
        Left2 = 0.427f;
label_219:
        num3 = 225;
        Left3 = 68f;
label_220:
        num3 = 226;
        num7 = 55f;
label_221:
        num3 = 227;
        brush = (Brush) new SolidBrush(Color.FromArgb(78, 132, 196));
        goto label_237;
label_222:
        num3 = 229;
        if (!Conversions.ToBoolean((object) (bool) (!Conversions.ToBoolean(Operators.CompareObjectGreaterEqual(Left1, (object) 69, false)) ? 0 : (Conversions.ToBoolean(Operators.CompareObjectLessEqual(Left1, (object) 80, false)) ? 1 : 0))))
          goto label_227;
label_223:
        num3 = 230;
        Left2 = 0.327f;
label_224:
        num3 = 231;
        Left3 = 80f;
label_225:
        num3 = 232;
        num7 = 69f;
label_226:
        num3 = 233;
        brush = (Brush) new SolidBrush(Color.FromArgb(115, 162, 214));
        goto label_237;
label_227:
        num3 = 235;
        if (!Conversions.ToBoolean((object) (bool) (!Conversions.ToBoolean(Operators.CompareObjectGreaterEqual(Left1, (object) 81, false)) ? 0 : (Conversions.ToBoolean(Operators.CompareObjectLessEqual(Left1, (object) 91, false)) ? 1 : 0))))
          goto label_232;
label_228:
        num3 = 236;
        Left2 = 0.227f;
label_229:
        num3 = 237;
        Left3 = 91f;
label_230:
        num3 = 238;
        num7 = 81f;
label_231:
        num3 = 239;
        brush = (Brush) new SolidBrush(Color.FromArgb(151, 192, 239));
        goto label_237;
label_232:
        num3 = 241;
        if (!Operators.ConditionalCompareObjectGreaterEqual(Left1, (object) 92, false))
          goto label_237;
label_233:
        num3 = 242;
        Left2 = 0.127f;
label_234:
        num3 = 243;
        Left3 = 100f;
label_235:
        num3 = 244;
        num7 = 92f;
label_236:
        num3 = 245;
        brush = (Brush) new SolidBrush(Color.FromArgb(205, 226, 245));
label_237:
label_238:
        num3 = 246;
        if (!Operators.ConditionalCompareObjectGreater(obj1, (object) 99, false))
          goto label_240;
label_239:
        num3 = 247;
        float a = (Left2 + (float) (0.086585 * ((double) Left3 - 98.0) / ((double) Left3 - (double) num7))) * (float) num4;
        goto label_242;
label_240:
        num3 = 249;
        a = Conversions.ToSingle(Operators.MultiplyObject(Operators.AddObject((object) Left2, Operators.DivideObject(Operators.MultiplyObject((object) 0.086585, Operators.SubtractObject((object) Left3, obj1)), (object) (float) ((double) Left3 - (double) num7))), (object) num4));
label_241:
label_242:
        num3 = 251;
        points[0].X = checked ((int) Math.Round(unchecked (0.693 * (double) width1)));
label_243:
        num3 = 252;
        points[0].Y = checked ((int) Math.Round((double) a));
label_244:
        num3 = 253;
        points[1].X = checked ((int) Math.Round(unchecked (0.729 * (double) width1)));
label_245:
        num3 = 254;
        points[1].Y = checked ((int) Math.Round(unchecked ((double) a - 0.0477 * (double) num4)));
label_246:
        num3 = (int) byte.MaxValue;
        points[2].X = checked ((int) Math.Round(unchecked (0.839 * (double) width1)));
label_247:
        num3 = 256;
        points[2].Y = checked ((int) Math.Round(unchecked ((double) a - 0.0477 * (double) num4)));
label_248:
        num3 = 257;
        points[3].X = checked ((int) Math.Round(unchecked (0.839 * (double) width1)));
label_249:
        num3 = 258;
        points[3].Y = checked ((int) Math.Round(unchecked ((double) a + 0.0477 * (double) num4)));
label_250:
        num3 = 259;
        points[4].X = checked ((int) Math.Round(unchecked (0.729 * (double) width1)));
label_251:
        num3 = 260;
        points[4].Y = checked ((int) Math.Round(unchecked ((double) a + 0.0477 * (double) num4)));
label_252:
        num3 = 261;
        graphics2.FillPolygon(brush, points);
label_253:
        num3 = 262;
        num5 = checked ((int) Math.Round(unchecked (0.738 * (double) width1)));
label_254:
        num3 = 263;
        num6 = checked ((int) Math.Round(unchecked ((double) a - (double) graphics2.MeasureString("G", font1, 500).Height / 2.1)));
label_255:
        num3 = 264;
        if (!Operators.ConditionalCompareObjectGreater(obj1, (object) 99, false))
          goto label_258;
label_256:
        num3 = 265;
        num5 = 900;
label_257:
        num3 = 266;
        num6 = 102;
        goto label_261;
label_258:
        num3 = 268;
        num5 = checked ((int) Math.Round(unchecked (0.738 * (double) width1)));
label_259:
        num3 = 269;
        num6 = checked ((int) Math.Round(unchecked ((double) a - (double) graphics2.MeasureString("G", font1, 500).Height / 2.1)));
label_260:
label_261:
        num3 = 271;
        path.AddString(Conversion.Str(RuntimeHelpers.GetObjectValue(obj1)), font1.FontFamily, 1, 84f, new Point(num5, num6), StringFormat.GenericTypographic);
label_262:
        num3 = 272;
        graphics2.FillPath(Brushes.White, path);
label_263:
        num3 = 273;
        graphics2.DrawPath(pen2, path);
label_264:
        num3 = 274;
        object obj2 = (object) "";
label_265:
        num3 = 275;
        if (SAP_Module.CalculationImprove2012.Calculation.CO2_Emissions_12a.EIValue != 0.0)
          goto label_267;
label_266:
        num3 = 276;
        obj2 = (object) Math.Round(SAP_Module.CalculationImprove2012.Calculation.CO2_Emissions_12b.EIRating, 0);
        goto label_269;
label_267:
        num3 = 278;
        obj2 = (object) Math.Round(SAP_Module.CalculationImprove2012.Calculation.CO2_Emissions_12a.EIValue, 0);
label_268:
label_269:
label_270:
        num3 = 280;
        object Left4 = obj2;
label_271:
        num3 = 282;
        if (!Conversions.ToBoolean((object) (bool) (!Conversions.ToBoolean(Operators.CompareObjectGreaterEqual(Left4, (object) 1, false)) ? 0 : (Conversions.ToBoolean(Operators.CompareObjectLessEqual(Left4, (object) 20, false)) ? 1 : 0))))
          goto label_276;
label_272:
        num3 = 283;
        Left2 = 0.727f;
label_273:
        num3 = 284;
        Left3 = 20f;
label_274:
        num3 = 285;
        num7 = 1f;
label_275:
        num3 = 286;
        brush = (Brush) new SolidBrush(Color.FromArgb(104, 104, 104));
        goto label_306;
label_276:
        num3 = 288;
        if (!Conversions.ToBoolean((object) (bool) (!Conversions.ToBoolean(Operators.CompareObjectGreaterEqual(Left4, (object) 21, false)) ? 0 : (Conversions.ToBoolean(Operators.CompareObjectLessEqual(Left4, (object) 38, false)) ? 1 : 0))))
          goto label_281;
label_277:
        num3 = 289;
        Left2 = 0.627f;
label_278:
        num3 = 290;
        Left3 = 38f;
label_279:
        num3 = 291;
        num7 = 21f;
label_280:
        num3 = 292;
        brush = (Brush) new SolidBrush(Color.FromArgb(134, 134, 134));
        goto label_306;
label_281:
        num3 = 294;
        if (!Conversions.ToBoolean((object) (bool) (!Conversions.ToBoolean(Operators.CompareObjectGreaterEqual(Left4, (object) 39, false)) ? 0 : (Conversions.ToBoolean(Operators.CompareObjectLessEqual(Left4, (object) 54, false)) ? 1 : 0))))
          goto label_286;
label_282:
        num3 = 295;
        Left2 = 0.527f;
label_283:
        num3 = 296;
        Left3 = 54f;
label_284:
        num3 = 297;
        num7 = 39f;
label_285:
        num3 = 298;
        brush = (Brush) new SolidBrush(Color.FromArgb(168, 168, 168));
        goto label_306;
label_286:
        num3 = 300;
        if (!Conversions.ToBoolean((object) (bool) (!Conversions.ToBoolean(Operators.CompareObjectGreaterEqual(Left4, (object) 55, false)) ? 0 : (Conversions.ToBoolean(Operators.CompareObjectLessEqual(Left4, (object) 68, false)) ? 1 : 0))))
          goto label_291;
label_287:
        num3 = 301;
        Left2 = 0.427f;
label_288:
        num3 = 302;
        Left3 = 68f;
label_289:
        num3 = 303;
        num7 = 55f;
label_290:
        num3 = 304;
        brush = (Brush) new SolidBrush(Color.FromArgb(78, 132, 196));
        goto label_306;
label_291:
        num3 = 306;
        if (!Conversions.ToBoolean((object) (bool) (!Conversions.ToBoolean(Operators.CompareObjectGreaterEqual(Left4, (object) 69, false)) ? 0 : (Conversions.ToBoolean(Operators.CompareObjectLessEqual(Left4, (object) 80, false)) ? 1 : 0))))
          goto label_296;
label_292:
        num3 = 307;
        Left2 = 0.327f;
label_293:
        num3 = 308;
        Left3 = 80f;
label_294:
        num3 = 309;
        num7 = 69f;
label_295:
        num3 = 310;
        brush = (Brush) new SolidBrush(Color.FromArgb(115, 162, 214));
        goto label_306;
label_296:
        num3 = 312;
        if (!Conversions.ToBoolean((object) (bool) (!Conversions.ToBoolean(Operators.CompareObjectGreaterEqual(Left4, (object) 81, false)) ? 0 : (Conversions.ToBoolean(Operators.CompareObjectLessEqual(Left4, (object) 91, false)) ? 1 : 0))))
          goto label_301;
label_297:
        num3 = 313;
        Left2 = 0.227f;
label_298:
        num3 = 314;
        Left3 = 91f;
label_299:
        num3 = 315;
        num7 = 81f;
label_300:
        num3 = 316;
        brush = (Brush) new SolidBrush(Color.FromArgb(151, 192, 239));
        goto label_306;
label_301:
        num3 = 318;
        if (!Operators.ConditionalCompareObjectGreaterEqual(Left4, (object) 92, false))
          goto label_306;
label_302:
        num3 = 319;
        Left2 = 0.127f;
label_303:
        num3 = 320;
        Left3 = 100f;
label_304:
        num3 = 321;
        num7 = 92f;
label_305:
        num3 = 322;
        brush = (Brush) new SolidBrush(Color.FromArgb(205, 226, 245));
label_306:
label_307:
        num3 = 323;
        if (!Operators.ConditionalCompareObjectGreater(obj2, (object) 99, false))
          goto label_309;
label_308:
        num3 = 324;
        a = (Left2 + (float) (0.086585 * ((double) Left3 - 98.0) / ((double) Left3 - (double) num7))) * (float) num4;
        goto label_311;
label_309:
        num3 = 326;
        a = Conversions.ToSingle(Operators.MultiplyObject(Operators.AddObject((object) Left2, Operators.DivideObject(Operators.MultiplyObject((object) 0.086585, Operators.SubtractObject((object) Left3, obj2)), (object) (float) ((double) Left3 - (double) num7))), (object) num4));
label_310:
label_311:
        num3 = 328;
        points[0].X = checked ((int) Math.Round(unchecked (0.853 * (double) width1)));
label_312:
        num3 = 329;
        points[0].Y = checked ((int) Math.Round((double) a));
label_313:
        num3 = 330;
        points[1].X = checked ((int) Math.Round(unchecked (0.887 * (double) width1)));
label_314:
        num3 = 331;
        points[1].Y = checked ((int) Math.Round(unchecked ((double) a - 0.0477 * (double) num4)));
label_315:
        num3 = 332;
        points[2].X = checked ((int) Math.Round(unchecked (0.992 * (double) width1)));
label_316:
        num3 = 333;
        points[2].Y = checked ((int) Math.Round(unchecked ((double) a - 0.0477 * (double) num4)));
label_317:
        num3 = 334;
        points[3].X = checked ((int) Math.Round(unchecked (0.992 * (double) width1)));
label_318:
        num3 = 335;
        points[3].Y = checked ((int) Math.Round(unchecked ((double) a + 0.0477 * (double) num4)));
label_319:
        num3 = 336;
        points[4].X = checked ((int) Math.Round(unchecked (0.887 * (double) width1)));
label_320:
        num3 = 337;
        points[4].Y = checked ((int) Math.Round(unchecked ((double) a + 0.0477 * (double) num4)));
label_321:
        num3 = 338;
        graphics2.FillPolygon(brush, points);
label_322:
        num3 = 339;
        num5 = checked ((int) Math.Round(unchecked (0.894 * (double) width1)));
label_323:
        num3 = 340;
        num6 = checked ((int) Math.Round(unchecked ((double) a - (double) graphics2.MeasureString("G", font1, 500).Height / 2.1)));
label_324:
        num3 = 341;
        if (!Operators.ConditionalCompareObjectGreater(obj2, (object) 99, false))
          goto label_327;
label_325:
        num3 = 342;
        num5 = 1150;
label_326:
        num3 = 343;
        num6 = 105;
        goto label_330;
label_327:
        num3 = 345;
        num5 = checked ((int) Math.Round(unchecked (0.894 * (double) width1)));
label_328:
        num3 = 346;
        num6 = checked ((int) Math.Round(unchecked ((double) a - (double) graphics2.MeasureString("G", font1, 500).Height / 2.1)));
label_329:
label_330:
        num3 = 348;
        path.AddString(Conversion.Str(RuntimeHelpers.GetObjectValue(obj2)), font1.FontFamily, 1, 84f, new Point(num5, num6), StringFormat.GenericTypographic);
label_331:
        num3 = 349;
        graphics2.FillPath(Brushes.White, path);
label_332:
        num3 = 350;
        graphics2.DrawPath(pen2, path);
label_333:
        graphics2 = (Graphics) null;
label_334:
        image1 = image1;
        goto label_340;
label_336:
        num2 = num3;
        switch (num1 > -2 ? num1 : 1)
        {
          case 1:
            int num8 = num2 + 1;
            num2 = 0;
            switch (num8)
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
                goto label_10;
              case 10:
                goto label_11;
              case 11:
                goto label_12;
              case 12:
                goto label_13;
              case 13:
                goto label_14;
              case 14:
                goto label_15;
              case 15:
                goto label_16;
              case 16:
                goto label_17;
              case 17:
                goto label_18;
              case 18:
                goto label_19;
              case 19:
                goto label_20;
              case 20:
                goto label_21;
              case 21:
                goto label_22;
              case 22:
                goto label_23;
              case 23:
                goto label_24;
              case 24:
                goto label_25;
              case 25:
                goto label_26;
              case 26:
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
                goto label_32;
              case 32:
                goto label_33;
              case 33:
                goto label_34;
              case 34:
                goto label_35;
              case 35:
                goto label_36;
              case 36:
                goto label_37;
              case 37:
                goto label_38;
              case 38:
                goto label_39;
              case 39:
                goto label_40;
              case 40:
                goto label_41;
              case 41:
              case 52:
                goto label_52;
              case 42:
                goto label_42;
              case 43:
                goto label_43;
              case 44:
                goto label_44;
              case 45:
                goto label_45;
              case 46:
                goto label_46;
              case 47:
                goto label_47;
              case 48:
                goto label_48;
              case 49:
                goto label_49;
              case 50:
                goto label_50;
              case 51:
                goto label_51;
              case 53:
                goto label_53;
              case 54:
                goto label_54;
              case 55:
                goto label_55;
              case 56:
                goto label_56;
              case 57:
                goto label_57;
              case 58:
                goto label_58;
              case 59:
                goto label_59;
              case 60:
                goto label_60;
              case 61:
                goto label_61;
              case 62:
                goto label_62;
              case 63:
                goto label_63;
              case 64:
                goto label_64;
              case 65:
                goto label_65;
              case 66:
                goto label_66;
              case 67:
                goto label_67;
              case 68:
                goto label_68;
              case 69:
                goto label_69;
              case 70:
                goto label_70;
              case 71:
                goto label_71;
              case 72:
                goto label_72;
              case 73:
                goto label_73;
              case 74:
                goto label_74;
              case 75:
                goto label_75;
              case 76:
                goto label_76;
              case 77:
                goto label_77;
              case 78:
                goto label_78;
              case 79:
                goto label_79;
              case 80:
                goto label_80;
              case 81:
                goto label_81;
              case 82:
                goto label_82;
              case 83:
                goto label_83;
              case 84:
                goto label_84;
              case 85:
                goto label_85;
              case 86:
                goto label_86;
              case 87:
                goto label_87;
              case 88:
                goto label_88;
              case 89:
                goto label_89;
              case 90:
                goto label_90;
              case 91:
                goto label_91;
              case 92:
                goto label_92;
              case 93:
                goto label_93;
              case 94:
                goto label_94;
              case 95:
                goto label_95;
              case 96:
                goto label_96;
              case 97:
                goto label_97;
              case 98:
                goto label_98;
              case 99:
                goto label_99;
              case 100:
                goto label_100;
              case 101:
                goto label_101;
              case 102:
                goto label_102;
              case 103:
                goto label_103;
              case 104:
                goto label_104;
              case 105:
                goto label_105;
              case 106:
                goto label_106;
              case 107:
                goto label_107;
              case 108:
                goto label_108;
              case 109:
                goto label_109;
              case 110:
                goto label_110;
              case 111:
                goto label_111;
              case 112:
                goto label_112;
              case 113:
                goto label_113;
              case 114:
                goto label_114;
              case 115:
                goto label_115;
              case 116:
                goto label_116;
              case 117:
                goto label_117;
              case 118:
                goto label_118;
              case 119:
                goto label_119;
              case 120:
                goto label_120;
              case 121:
                goto label_121;
              case 122:
                goto label_122;
              case 123:
                goto label_123;
              case 124:
                goto label_124;
              case 125:
                goto label_125;
              case 126:
                goto label_126;
              case (int) sbyte.MaxValue:
                goto label_127;
              case 128:
                goto label_128;
              case 129:
                goto label_129;
              case 130:
                goto label_130;
              case 131:
                goto label_131;
              case 132:
                goto label_132;
              case 133:
                goto label_133;
              case 134:
                goto label_134;
              case 135:
                goto label_135;
              case 136:
                goto label_136;
              case 137:
                goto label_137;
              case 138:
                goto label_138;
              case 139:
                goto label_139;
              case 140:
                goto label_140;
              case 141:
                goto label_141;
              case 142:
                goto label_142;
              case 143:
                goto label_143;
              case 144:
                goto label_144;
              case 145:
                goto label_145;
              case 146:
                goto label_146;
              case 147:
                goto label_147;
              case 148:
                goto label_148;
              case 149:
                goto label_149;
              case 150:
                goto label_150;
              case 151:
                goto label_151;
              case 152:
                goto label_152;
              case 153:
                goto label_153;
              case 154:
                goto label_154;
              case 155:
                goto label_155;
              case 156:
                goto label_156;
              case 157:
                goto label_157;
              case 158:
                goto label_158;
              case 159:
                goto label_159;
              case 160:
                goto label_160;
              case 161:
                goto label_161;
              case 162:
                goto label_162;
              case 163:
                goto label_163;
              case 164:
              case 191:
                goto label_189;
              case 165:
                goto label_164;
              case 166:
                goto label_165;
              case 167:
                goto label_166;
              case 168:
                goto label_167;
              case 169:
                goto label_168;
              case 170:
                goto label_169;
              case 171:
                goto label_170;
              case 172:
                goto label_171;
              case 173:
                goto label_172;
              case 174:
                goto label_173;
              case 175:
                goto label_174;
              case 176:
                goto label_175;
              case 177:
              case 190:
                goto label_188;
              case 178:
                goto label_176;
              case 179:
                goto label_177;
              case 180:
                goto label_178;
              case 181:
                goto label_179;
              case 182:
                goto label_180;
              case 183:
                goto label_181;
              case 184:
                goto label_182;
              case 185:
                goto label_183;
              case 186:
                goto label_184;
              case 187:
                goto label_185;
              case 188:
                goto label_186;
              case 189:
                goto label_187;
              case 192:
                goto label_190;
              case 193:
                goto label_191;
              case 194:
                goto label_192;
              case 195:
                goto label_193;
              case 196:
                goto label_194;
              case 197:
                goto label_195;
              case 198:
                goto label_196;
              case 199:
                goto label_197;
              case 200:
                goto label_200;
              case 201:
                goto label_198;
              case 202:
                goto label_199;
              case 203:
                goto label_201;
              case 204:
              case 210:
              case 216:
              case 222:
              case 228:
              case 234:
              case 240:
                goto label_237;
              case 205:
                goto label_202;
              case 206:
                goto label_203;
              case 207:
                goto label_204;
              case 208:
                goto label_205;
              case 209:
                goto label_206;
              case 211:
                goto label_207;
              case 212:
                goto label_208;
              case 213:
                goto label_209;
              case 214:
                goto label_210;
              case 215:
                goto label_211;
              case 217:
                goto label_212;
              case 218:
                goto label_213;
              case 219:
                goto label_214;
              case 220:
                goto label_215;
              case 221:
                goto label_216;
              case 223:
                goto label_217;
              case 224:
                goto label_218;
              case 225:
                goto label_219;
              case 226:
                goto label_220;
              case 227:
                goto label_221;
              case 229:
                goto label_222;
              case 230:
                goto label_223;
              case 231:
                goto label_224;
              case 232:
                goto label_225;
              case 233:
                goto label_226;
              case 235:
                goto label_227;
              case 236:
                goto label_228;
              case 237:
                goto label_229;
              case 238:
                goto label_230;
              case 239:
                goto label_231;
              case 241:
                goto label_232;
              case 242:
                goto label_233;
              case 243:
                goto label_234;
              case 244:
                goto label_235;
              case 245:
                goto label_236;
              case 246:
                goto label_238;
              case 247:
                goto label_239;
              case 248:
              case 251:
                goto label_242;
              case 249:
                goto label_240;
              case 250:
                goto label_241;
              case 252:
                goto label_243;
              case 253:
                goto label_244;
              case 254:
                goto label_245;
              case (int) byte.MaxValue:
                goto label_246;
              case 256:
                goto label_247;
              case 257:
                goto label_248;
              case 258:
                goto label_249;
              case 259:
                goto label_250;
              case 260:
                goto label_251;
              case 261:
                goto label_252;
              case 262:
                goto label_253;
              case 263:
                goto label_254;
              case 264:
                goto label_255;
              case 265:
                goto label_256;
              case 266:
                goto label_257;
              case 267:
              case 271:
                goto label_261;
              case 268:
                goto label_258;
              case 269:
                goto label_259;
              case 270:
                goto label_260;
              case 272:
                goto label_262;
              case 273:
                goto label_263;
              case 274:
                goto label_264;
              case 275:
                goto label_265;
              case 276:
                goto label_266;
              case 277:
                goto label_269;
              case 278:
                goto label_267;
              case 279:
                goto label_268;
              case 280:
                goto label_270;
              case 281:
              case 287:
              case 293:
              case 299:
              case 305:
              case 311:
              case 317:
                goto label_306;
              case 282:
                goto label_271;
              case 283:
                goto label_272;
              case 284:
                goto label_273;
              case 285:
                goto label_274;
              case 286:
                goto label_275;
              case 288:
                goto label_276;
              case 289:
                goto label_277;
              case 290:
                goto label_278;
              case 291:
                goto label_279;
              case 292:
                goto label_280;
              case 294:
                goto label_281;
              case 295:
                goto label_282;
              case 296:
                goto label_283;
              case 297:
                goto label_284;
              case 298:
                goto label_285;
              case 300:
                goto label_286;
              case 301:
                goto label_287;
              case 302:
                goto label_288;
              case 303:
                goto label_289;
              case 304:
                goto label_290;
              case 306:
                goto label_291;
              case 307:
                goto label_292;
              case 308:
                goto label_293;
              case 309:
                goto label_294;
              case 310:
                goto label_295;
              case 312:
                goto label_296;
              case 313:
                goto label_297;
              case 314:
                goto label_298;
              case 315:
                goto label_299;
              case 316:
                goto label_300;
              case 318:
                goto label_301;
              case 319:
                goto label_302;
              case 320:
                goto label_303;
              case 321:
                goto label_304;
              case 322:
                goto label_305;
              case 323:
                goto label_307;
              case 324:
                goto label_308;
              case 325:
              case 328:
                goto label_311;
              case 326:
                goto label_309;
              case 327:
                goto label_310;
              case 329:
                goto label_312;
              case 330:
                goto label_313;
              case 331:
                goto label_314;
              case 332:
                goto label_315;
              case 333:
                goto label_316;
              case 334:
                goto label_317;
              case 335:
                goto label_318;
              case 336:
                goto label_319;
              case 337:
                goto label_320;
              case 338:
                goto label_321;
              case 339:
                goto label_322;
              case 340:
                goto label_323;
              case 341:
                goto label_324;
              case 342:
                goto label_325;
              case 343:
                goto label_326;
              case 344:
              case 348:
                goto label_330;
              case 345:
                goto label_327;
              case 346:
                goto label_328;
              case 347:
                goto label_329;
              case 349:
                goto label_331;
              case 350:
                goto label_332;
              case 351:
                goto label_333;
              case 352:
                goto label_334;
              case 353:
                goto label_340;
            }
            break;
        }
      }
      catch (Exception ex) when (ex is Exception & (uint) num1 > 0U & num2 == 0)
      {
        ProjectData.SetProjectError(ex);
        goto label_336;
      }
      throw ProjectData.CreateProjectError(-2146828237);
label_340:
      if (num2 != 0)
        ProjectData.ClearProjectError();
      return image1;
    }

    public static Image DrawEnergyGraph(int Country, int House)
    {
      int num1;
      Image image1;
      int num2;
      try
      {
label_2:
        ProjectData.ClearProjectError();
        num1 = -2;
label_3:
        int num3 = 2;
        int width1 = 1344;
label_4:
        num3 = 3;
        int num4 = 1088;
label_5:
        num3 = 4;
        Font font1 = new Font("Arial", 24f, FontStyle.Regular);
label_6:
        num3 = 5;
        image1 = (Image) new Bitmap(width1, num4);
label_7:
        num3 = 6;
        Graphics graphics1 = Graphics.FromImage(image1);
label_8:
        num3 = 7;
        Font font2 = new Font("Arial", 64f, FontStyle.Bold);
label_9:
        num3 = 8;
        Font font3 = new Font("Arial", 56f, FontStyle.Bold);
label_10:
        num3 = 9;
        Font font4 = new Font("Arial", 36f, FontStyle.Regular);
label_11:
        num3 = 10;
        Font font5 = new Font("Arial", 32f, FontStyle.Bold);
label_12:
        num3 = 11;
        Font font6 = new Font("Arial", 28f, FontStyle.Italic);
label_13:
        num3 = 12;
        Font font7 = new Font("Arial", 28f, FontStyle.Bold);
label_14:
        num3 = 13;
        Pen pen1 = (Pen) Pens.Black.Clone();
label_15:
        num3 = 14;
        pen1.Width = 5f;
label_16:
        num3 = 15;
        Pen pen2 = (Pen) Pens.Black.Clone();
label_17:
        num3 = 16;
        pen2.Width = 3f;
label_18:
        num3 = 17;
        Pen pen3 = new Pen(Color.Black, 2f);
label_19:
        num3 = 18;
        Graphics graphics2 = graphics1;
label_20:
        num3 = 19;
        graphics2.TextRenderingHint = TextRenderingHint.AntiAlias;
label_21:
        num3 = 20;
        graphics2.SmoothingMode = SmoothingMode.AntiAlias;
label_22:
        num3 = 21;
        graphics1.FillRectangle(Brushes.White, 0, 0, width1, num4);
label_23:
        num3 = 22;
        graphics2.DrawLine(pen1, 1, 1, checked (width1 - 1), 1);
label_24:
        num3 = 23;
        graphics2.DrawLine(pen1, checked (width1 - 1), 1, checked (width1 - 1), checked (num4 - 1));
label_25:
        num3 = 24;
        graphics2.DrawLine(pen1, checked (width1 - 1), checked (num4 - 1), 1, checked (num4 - 1));
label_26:
        num3 = 25;
        graphics2.DrawLine(pen1, 1, checked (num4 - 1), 1, 1);
label_27:
        num3 = 26;
        int num5 = checked ((int) Math.Round(unchecked (0.688 * (double) width1)));
label_28:
        num3 = 27;
        int num6 = checked ((int) Math.Round(unchecked (0.885 * (double) num4)));
label_29:
        num3 = 28;
        graphics2.DrawLine(pen1, num5, num6, num5, 1);
label_30:
        num3 = 29;
        num5 = checked ((int) Math.Round(unchecked (0.845 * (double) width1)));
label_31:
        num3 = 30;
        graphics2.DrawLine(pen1, num5, num6, num5, 1);
label_32:
        num3 = 31;
        if (!(Country == 2 & Operators.CompareString(SAP_Module.Proj.Dwellings[House].EPCLanguage, "Welsh", false) == 0))
          goto label_42;
label_33:
        num3 = 32;
        num5 = checked ((int) Math.Round(unchecked (0.766 * (double) width1 - (double) graphics2.MeasureString("Cyfredol", font5, 500).Width / 2.0)));
label_34:
        num3 = 33;
        num6 = checked ((int) Math.Round(unchecked (0.2 * (double) font5.GetHeight())));
label_35:
        num3 = 34;
        graphics2.DrawString("Cyfredol", font5, Brushes.Black, (float) num5, (float) num6);
label_36:
        num3 = 35;
        num5 = checked ((int) Math.Round(unchecked (0.921 * (double) width1 - (double) graphics2.MeasureString("Potensial", font5, 500).Width / 2.0)));
label_37:
        num3 = 36;
        num6 = checked ((int) Math.Round(unchecked (0.2 * (double) font5.GetHeight())));
label_38:
        num3 = 37;
        graphics2.DrawString("Potensial", font5, Brushes.Black, (float) num5, (float) num6);
label_39:
        num3 = 38;
        num5 = checked ((int) Math.Round(unchecked (0.02 * (double) width1)));
label_40:
        num3 = 39;
        num6 = checked ((int) Math.Round(unchecked (1.6 * (double) font5.GetHeight())));
label_41:
        num3 = 40;
        graphics2.DrawString("Effeithlon iawn o ran ynni – costau rhedeg is", font6, Brushes.Black, (float) num5, (float) num6);
        goto label_52;
label_42:
        num3 = 42;
        num5 = checked ((int) Math.Round(unchecked (0.766 * (double) width1 - (double) graphics2.MeasureString("Current", font5, 500).Width / 2.0)));
label_43:
        num3 = 43;
        num6 = checked ((int) Math.Round(unchecked (0.2 * (double) font5.GetHeight())));
label_44:
        num3 = 44;
        graphics2.DrawString("Current", font5, Brushes.Black, (float) num5, (float) num6);
label_45:
        num3 = 45;
        num5 = checked ((int) Math.Round(unchecked (0.921 * (double) width1 - (double) graphics2.MeasureString("Potential", font5, 500).Width / 2.0)));
label_46:
        num3 = 46;
        num6 = checked ((int) Math.Round(unchecked (0.2 * (double) font5.GetHeight())));
label_47:
        num3 = 47;
        graphics2.DrawString("Potential", font5, Brushes.Black, (float) num5, (float) num6);
label_48:
        num3 = 48;
        num5 = checked ((int) Math.Round(unchecked (0.02 * (double) width1)));
label_49:
        num3 = 49;
        num6 = checked ((int) Math.Round(unchecked (1.6 * (double) font5.GetHeight())));
label_50:
        num3 = 50;
        graphics2.DrawString("Very energy efficient - lower running costs", font6, Brushes.Black, (float) num5, (float) num6);
label_51:
label_52:
        num3 = 52;
        num6 = checked ((int) Math.Round(unchecked (0.063 * (double) num4)));
label_53:
        num3 = 53;
        graphics2.DrawLine(pen1, 1, num6, checked (width1 - 1), num6);
label_54:
        num3 = 54;
        Brush brush = (Brush) new SolidBrush(Color.FromArgb(0, (int) sbyte.MaxValue, 61));
label_55:
        num3 = 55;
        num5 = checked ((int) Math.Round(unchecked (0.01 * (double) width1)));
label_56:
        num3 = 56;
        num6 = checked ((int) Math.Round(unchecked (0.127 * (double) num4)));
label_57:
        num3 = 57;
        int width2 = checked ((int) Math.Round(unchecked (0.221 * (double) width1)));
label_58:
        num3 = 58;
        int height = checked ((int) Math.Round(unchecked (0.086585 * (double) num4)));
label_59:
        num3 = 59;
        graphics2.FillRectangle(brush, num5, num6, width2, height);
label_60:
        num3 = 60;
        num6 = checked ((int) Math.Round(unchecked ((double) num6 + (double) height / 2.0 - (double) graphics2.MeasureString("()", font7, 500).Height / 2.0)));
label_61:
        num3 = 61;
        num5 = checked ((int) Math.Round(unchecked (0.025 * (double) width1)));
label_62:
        num3 = 62;
        graphics2.DrawString("(92 plus)", font7, Brushes.White, (float) num5, (float) num6);
label_63:
        num3 = 63;
        num5 = checked ((int) Math.Round(unchecked (0.158 * (double) width1)));
label_64:
        num3 = 64;
        num6 = checked ((int) Math.Round(unchecked (0.127 * (double) num4 + (double) height / 2.0 - (double) graphics2.MeasureString("A", font2, 900).Height / 2.1)));
label_65:
        num3 = 65;
        GraphicsPath path = new GraphicsPath();
label_66:
        num3 = 66;
        path.AddString("A", font2.FontFamily, 1, 84f, new Point(num5, num6), StringFormat.GenericTypographic);
label_67:
        num3 = 67;
        graphics2.FillPath(Brushes.White, path);
label_68:
        num3 = 68;
        graphics2.DrawPath(pen2, path);
label_69:
        num3 = 69;
        num5 = checked ((int) Math.Round(unchecked (0.01 * (double) width1)));
label_70:
        num3 = 70;
        brush = (Brush) new SolidBrush(Color.FromArgb(44, 159, 41));
label_71:
        num3 = 71;
        num6 = checked ((int) Math.Round(unchecked (0.227 * (double) num4)));
label_72:
        num3 = 72;
        width2 = checked ((int) Math.Round(unchecked (0.295 * (double) width1)));
label_73:
        num3 = 73;
        graphics2.FillRectangle(brush, num5, num6, width2, height);
label_74:
        num3 = 74;
        num6 = checked ((int) Math.Round(unchecked ((double) num6 + (double) height / 2.0 - (double) graphics2.MeasureString("()", font7, 900).Height / 2.0)));
label_75:
        num3 = 75;
        num5 = checked ((int) Math.Round(unchecked (0.025 * (double) width1)));
label_76:
        num3 = 76;
        graphics2.DrawString("(81-91)", font7, Brushes.White, (float) num5, (float) num6);
label_77:
        num3 = 77;
        num5 = checked ((int) Math.Round(unchecked (0.239 * (double) width1)));
label_78:
        num3 = 78;
        num6 = checked ((int) Math.Round(unchecked (0.227 * (double) num4 + (double) height / 2.0 - (double) graphics2.MeasureString("B", font2, 500).Height / 2.1)));
label_79:
        num3 = 79;
        path.AddString("B", font2.FontFamily, 1, 84f, new Point(num5, num6), StringFormat.GenericTypographic);
label_80:
        num3 = 80;
        graphics2.FillPath(Brushes.White, path);
label_81:
        num3 = 81;
        graphics2.DrawPath(pen2, path);
label_82:
        num3 = 82;
        num5 = checked ((int) Math.Round(unchecked (0.01 * (double) width1)));
label_83:
        num3 = 83;
        brush = (Brush) new SolidBrush(Color.FromArgb(157, 203, 60));
label_84:
        num3 = 84;
        num6 = checked ((int) Math.Round(unchecked (0.327 * (double) num4)));
label_85:
        num3 = 85;
        width2 = checked ((int) Math.Round(unchecked (0.37 * (double) width1)));
label_86:
        num3 = 86;
        graphics2.FillRectangle(brush, num5, num6, width2, height);
label_87:
        num3 = 87;
        num6 = checked ((int) Math.Round(unchecked ((double) num6 + (double) height / 2.0 - (double) graphics2.MeasureString("()", font7, 900).Height / 2.0)));
label_88:
        num3 = 88;
        num5 = checked ((int) Math.Round(unchecked (0.025 * (double) width1)));
label_89:
        num3 = 89;
        graphics2.DrawString("(69-80)", font7, Brushes.Black, (float) num5, (float) num6);
label_90:
        num3 = 90;
        num5 = checked ((int) Math.Round(unchecked (0.307 * (double) width1)));
label_91:
        num3 = 91;
        num6 = checked ((int) Math.Round(unchecked (0.327 * (double) num4 + (double) height / 2.0 - (double) graphics2.MeasureString("C", font2, 500).Height / 2.1)));
label_92:
        num3 = 92;
        path.AddString("C", font2.FontFamily, 1, 84f, new Point(num5, num6), StringFormat.GenericTypographic);
label_93:
        num3 = 93;
        graphics2.FillPath(Brushes.White, path);
label_94:
        num3 = 94;
        graphics2.DrawPath(pen2, path);
label_95:
        num3 = 95;
        num5 = checked ((int) Math.Round(unchecked (0.01 * (double) width1)));
label_96:
        num3 = 96;
        brush = (Brush) new SolidBrush(Color.FromArgb((int) byte.MaxValue, 242, 0));
label_97:
        num3 = 97;
        num6 = checked ((int) Math.Round(unchecked (0.427 * (double) num4)));
label_98:
        num3 = 98;
        width2 = checked ((int) Math.Round(unchecked (0.445 * (double) width1)));
label_99:
        num3 = 99;
        graphics2.FillRectangle(brush, num5, num6, width2, height);
label_100:
        num3 = 100;
        num6 = checked ((int) Math.Round(unchecked ((double) num6 + (double) height / 2.0 - (double) graphics2.MeasureString("()", font7, 900).Height / 2.0)));
label_101:
        num3 = 101;
        num5 = checked ((int) Math.Round(unchecked (0.025 * (double) width1)));
label_102:
        num3 = 102;
        graphics2.DrawString("(55-68)", font7, Brushes.Black, (float) num5, (float) num6);
label_103:
        num3 = 103;
        num5 = checked ((int) Math.Round(unchecked (0.387 * (double) width1)));
label_104:
        num3 = 104;
        num6 = checked ((int) Math.Round(unchecked (0.427 * (double) num4 + (double) height / 2.0 - (double) graphics2.MeasureString("D", font2, 500).Height / 2.1)));
label_105:
        num3 = 105;
        path.AddString("D", font2.FontFamily, 1, 84f, new Point(num5, num6), StringFormat.GenericTypographic);
label_106:
        num3 = 106;
        graphics2.FillPath(Brushes.White, path);
label_107:
        num3 = 107;
        graphics2.DrawPath(pen2, path);
label_108:
        num3 = 108;
        num5 = checked ((int) Math.Round(unchecked (0.01 * (double) width1)));
label_109:
        num3 = 109;
        brush = (Brush) new SolidBrush(Color.FromArgb(247, 175, 29));
label_110:
        num3 = 110;
        num6 = checked ((int) Math.Round(unchecked (0.527 * (double) num4)));
label_111:
        num3 = 111;
        width2 = checked ((int) Math.Round(unchecked (0.518 * (double) width1)));
label_112:
        num3 = 112;
        graphics2.FillRectangle(brush, num5, num6, width2, height);
label_113:
        num3 = 113;
        num6 = checked ((int) Math.Round(unchecked ((double) num6 + (double) height / 2.0 - (double) graphics2.MeasureString("()", font7, 900).Height / 2.0)));
label_114:
        num3 = 114;
        num5 = checked ((int) Math.Round(unchecked (0.025 * (double) width1)));
label_115:
        num3 = 115;
        graphics2.DrawString("(39-54)", font7, Brushes.Black, (float) num5, (float) num6);
label_116:
        num3 = 116;
        num5 = checked ((int) Math.Round(unchecked (0.459 * (double) width1)));
label_117:
        num3 = 117;
        num6 = checked ((int) Math.Round(unchecked (0.527 * (double) num4 + (double) height / 2.0 - (double) graphics2.MeasureString("E", font2, 500).Height / 2.1)));
label_118:
        num3 = 118;
        path.AddString("E", font2.FontFamily, 1, 84f, new Point(num5, num6), StringFormat.GenericTypographic);
label_119:
        num3 = 119;
        graphics2.FillPath(Brushes.White, path);
label_120:
        num3 = 120;
        graphics2.DrawPath(pen2, path);
label_121:
        num3 = 121;
        num5 = checked ((int) Math.Round(unchecked (0.01 * (double) width1)));
label_122:
        num3 = 122;
        brush = (Brush) new SolidBrush(Color.FromArgb(237, 104, 35));
label_123:
        num3 = 123;
        num6 = checked ((int) Math.Round(unchecked (0.627 * (double) num4)));
label_124:
        num3 = 124;
        width2 = checked ((int) Math.Round(unchecked (0.592 * (double) width1)));
label_125:
        num3 = 125;
        graphics2.FillRectangle(brush, num5, num6, width2, height);
label_126:
        num3 = 126;
        num6 = checked ((int) Math.Round(unchecked ((double) num6 + (double) height / 2.0 - (double) graphics2.MeasureString("()", font7, 900).Height / 2.0)));
label_127:
        num3 = (int) sbyte.MaxValue;
        num5 = checked ((int) Math.Round(unchecked (0.025 * (double) width1)));
label_128:
        num3 = 128;
        graphics2.DrawString("(21-38)", font7, Brushes.Black, (float) num5, (float) num6);
label_129:
        num3 = 129;
        num5 = checked ((int) Math.Round(unchecked (0.536 * (double) width1)));
label_130:
        num3 = 130;
        num6 = checked ((int) Math.Round(unchecked (0.627 * (double) num4 + (double) height / 2.0 - (double) graphics2.MeasureString("F", font2, 500).Height / 2.1)));
label_131:
        num3 = 131;
        path.AddString("F", font2.FontFamily, 1, 84f, new Point(num5, num6), StringFormat.GenericTypographic);
label_132:
        num3 = 132;
        graphics2.FillPath(Brushes.White, path);
label_133:
        num3 = 133;
        graphics2.DrawPath(pen2, path);
label_134:
        num3 = 134;
        num5 = checked ((int) Math.Round(unchecked (0.01 * (double) width1)));
label_135:
        num3 = 135;
        brush = (Brush) new SolidBrush(Color.FromArgb(227, 29, 35));
label_136:
        num3 = 136;
        num6 = checked ((int) Math.Round(unchecked (0.727 * (double) num4)));
label_137:
        num3 = 137;
        width2 = checked ((int) Math.Round(unchecked (0.668 * (double) width1)));
label_138:
        num3 = 138;
        graphics2.FillRectangle(brush, num5, num6, width2, height);
label_139:
        num3 = 139;
        num6 = checked ((int) Math.Round(unchecked ((double) num6 + (double) height / 2.0 - (double) graphics2.MeasureString("()", font7, 900).Height / 2.0)));
label_140:
        num3 = 140;
        num5 = checked ((int) Math.Round(unchecked (0.025 * (double) width1)));
label_141:
        num3 = 141;
        graphics2.DrawString("(1-20)", font7, Brushes.Black, (float) num5, (float) num6);
label_142:
        num3 = 142;
        num5 = checked ((int) Math.Round(unchecked (0.607 * (double) width1)));
label_143:
        num3 = 143;
        num6 = checked ((int) Math.Round(unchecked (0.727 * (double) num4 + (double) height / 2.0 - (double) graphics2.MeasureString("G", font2, 500).Height / 2.1)));
label_144:
        num3 = 144;
        path.AddString("G", font2.FontFamily, 1, 84f, new Point(num5, num6), StringFormat.GenericTypographic);
label_145:
        num3 = 145;
        graphics2.FillPath(Brushes.White, path);
label_146:
        num3 = 146;
        graphics2.DrawPath(pen2, path);
label_147:
        num3 = 147;
        num5 = checked ((int) Math.Round(unchecked (0.01 * (double) width1)));
label_148:
        num3 = 148;
        num6 = checked ((int) Math.Round(unchecked (0.885 * (double) num4)));
label_149:
        num3 = 149;
        graphics2.DrawLine(pen1, 1, num6, checked (width1 - 1), num6);
label_150:
        num3 = 150;
        num6 = checked ((int) Math.Round(unchecked ((0.885 * (double) num4 - (0.727 * (double) num4 + 0.086585 * (double) num4)) / 2.0 + (0.727 * (double) num4 + 0.086585 * (double) num4) - (double) graphics2.MeasureString("Potential", font6, 500).Height / 2.0)));
label_151:
        num3 = 151;
        num5 = checked ((int) Math.Round(unchecked (0.02 * (double) width1)));
label_152:
        num3 = 152;
        if (!(Country == 2 & Operators.CompareString(SAP_Module.Proj.Dwellings[House].EPCLanguage, "Welsh", false) == 0))
          goto label_164;
label_153:
        num3 = 153;
        graphics2.DrawString("Ddim yn effeithlon o ran ynni – costau rhedeg uwch", font6, Brushes.Black, (float) num5, (float) num6);
label_154:
        num3 = 154;
        num6 = checked ((int) Math.Round(unchecked (23.0 / 400.0 * (double) num4 + 0.885 * (double) num4 - 0.5 * (double) graphics2.MeasureString("Cymru a Lloegr", font3, 900).Height)));
label_155:
        num3 = 155;
        num5 = checked ((int) Math.Round(unchecked (0.025 * (double) width1)));
label_156:
        num3 = 156;
        graphics2.DrawString("Cymru a Lloegr", font3, Brushes.Black, (float) num5, (float) num6);
label_157:
        num3 = 157;
        num6 = checked ((int) Math.Round(unchecked (23.0 / 400.0 * (double) num4 + 0.885 * (double) num4 - (double) graphics2.MeasureString("Cyfarwyddeb 2002/91/EC", font1, 500).Height)));
label_158:
        num3 = 158;
        num5 = checked ((int) Math.Round(unchecked (0.59 * (double) width1)));
label_159:
        num3 = 159;
        graphics2.DrawString("Cyfarwyddeb 2002/91/EC", font1, Brushes.Black, (float) num5, (float) num6);
label_160:
        num3 = 160;
        num6 = checked ((int) Math.Round(unchecked (23.0 / 400.0 * (double) num4 + 0.885 * (double) num4)));
label_161:
        num3 = 161;
        num5 = checked ((int) Math.Round(unchecked (0.63 * (double) width1)));
label_162:
        num3 = 162;
        graphics2.DrawString("yr Undeb Ewropeaidd", font1, Brushes.Black, (float) num5, (float) num6);
label_163:
        num3 = 163;
        num6 = checked ((int) Math.Round(unchecked (23.0 / 400.0 * (double) num4 + 0.885 * (double) num4 - 0.52 * (double) graphics2.MeasureString("Cymru a Lloegr", font3, 900).Height)));
        goto label_189;
label_164:
        num3 = 165;
        if (Country != 4)
          goto label_176;
label_165:
        num3 = 166;
        graphics2.DrawString("Not energy efficient - higher running costs", font6, Brushes.Black, (float) num5, (float) num6);
label_166:
        num3 = 167;
        num6 = checked ((int) Math.Round(unchecked (23.0 / 400.0 * (double) num4 + 0.885 * (double) num4 - 0.5 * (double) graphics2.MeasureString("Scotland", font3, 900).Height)));
label_167:
        num3 = 168;
        num5 = checked ((int) Math.Round(unchecked (0.025 * (double) width1)));
label_168:
        num3 = 169;
        graphics2.DrawString("Scotland", font3, Brushes.Black, (float) num5, (float) num6);
label_169:
        num3 = 170;
        num6 = checked ((int) Math.Round(unchecked (23.0 / 400.0 * (double) num4 + 0.885 * (double) num4 - (double) graphics2.MeasureString("EU Directive", font4, 500).Height)));
label_170:
        num3 = 171;
        num5 = checked ((int) Math.Round(unchecked (0.66 * (double) width1)));
label_171:
        num3 = 172;
        graphics2.DrawString("EU Directive", font4, Brushes.Black, (float) num5, (float) num6);
label_172:
        num3 = 173;
        num6 = checked ((int) Math.Round(unchecked (23.0 / 400.0 * (double) num4 + 0.885 * (double) num4)));
label_173:
        num3 = 174;
        num5 = checked ((int) Math.Round(unchecked (0.66 * (double) width1)));
label_174:
        num3 = 175;
        graphics2.DrawString("2002/91/EC", font4, Brushes.Black, (float) num5, (float) num6);
label_175:
        num3 = 176;
        num6 = checked ((int) Math.Round(unchecked (23.0 / 400.0 * (double) num4 + 0.885 * (double) num4 - 0.52 * (double) graphics2.MeasureString("Scotland", font3, 900).Height)));
        goto label_188;
label_176:
        num3 = 178;
        graphics2.DrawString("Not energy efficient - higher running costs", font6, Brushes.Black, (float) num5, (float) num6);
label_177:
        num3 = 179;
        num6 = checked ((int) Math.Round(unchecked (23.0 / 400.0 * (double) num4 + 0.885 * (double) num4 - 0.5 * (double) graphics2.MeasureString("England & Wales", font3, 900).Height)));
label_178:
        num3 = 180;
        num5 = checked ((int) Math.Round(unchecked (0.025 * (double) width1)));
label_179:
        num3 = 181;
        graphics2.DrawString("England & Wales", font3, Brushes.Black, (float) num5, (float) num6);
label_180:
        num3 = 182;
        num6 = checked ((int) Math.Round(unchecked (23.0 / 400.0 * (double) num4 + 0.885 * (double) num4 - (double) graphics2.MeasureString("EU Directive", font4, 500).Height)));
label_181:
        num3 = 183;
        num5 = checked ((int) Math.Round(unchecked (0.66 * (double) width1)));
label_182:
        num3 = 184;
        graphics2.DrawString("EU Directive", font4, Brushes.Black, (float) num5, (float) num6);
label_183:
        num3 = 185;
        num6 = checked ((int) Math.Round(unchecked (23.0 / 400.0 * (double) num4 + 0.885 * (double) num4)));
label_184:
        num3 = 186;
        num5 = checked ((int) Math.Round(unchecked (0.66 * (double) width1)));
label_185:
        num3 = 187;
        graphics2.DrawString("2002/91/EC", font4, Brushes.Black, (float) num5, (float) num6);
label_186:
        num3 = 188;
        num6 = checked ((int) Math.Round(unchecked (23.0 / 400.0 * (double) num4 + 0.885 * (double) num4 - 0.52 * (double) graphics2.MeasureString("England & Wales", font3, 900).Height)));
label_187:
label_188:
label_189:
        num3 = 191;
        num5 = checked ((int) Math.Round(unchecked (0.88 * (double) width1)));
label_190:
        num3 = 192;
        Image image2 = Image.FromFile(Application.StartupPath + "\\Resources\\EU.bmp");
label_191:
        num3 = 193;
        width2 = checked ((int) Math.Round(unchecked ((double) image2.Width / 2.75)));
label_192:
        num3 = 194;
        height = checked ((int) Math.Round(unchecked ((double) image2.Height / 2.75)));
label_193:
        num3 = 195;
        graphics2.DrawImage(image2, num5, num6, width2, height);
label_194:
        num3 = 196;
        Point[] points = new Point[5];
label_195:
        num3 = 197;
label_196:
        num3 = 198;
        if (SAP_Module.Calculation2012.Calculation.SAP_rating_11a.SAPRating != 0.0)
          goto label_198;
label_197:
        num3 = 199;
        object sapRating1 = (object) SAP_Module.Calculation2012.Calculation.SAP_rating_11b.SAPRating;
        goto label_200;
label_198:
        num3 = 201;
        sapRating1 = (object) SAP_Module.Calculation2012.Calculation.SAP_rating_11a.SAPRating;
label_199:
label_200:
label_201:
        num3 = 203;
        object Left1 = sapRating1;
label_202:
        num3 = 205;
        if (!Conversions.ToBoolean((object) (bool) (!Conversions.ToBoolean(Operators.CompareObjectGreaterEqual(Left1, (object) 1, false)) ? 0 : (Conversions.ToBoolean(Operators.CompareObjectLessEqual(Left1, (object) 20, false)) ? 1 : 0))))
          goto label_207;
label_203:
        num3 = 206;
        float Left2 = 0.727f;
label_204:
        num3 = 207;
        float Left3 = 20f;
label_205:
        num3 = 208;
        float num7 = 1f;
label_206:
        num3 = 209;
        brush = (Brush) new SolidBrush(Color.FromArgb(227, 29, 35));
        goto label_237;
label_207:
        num3 = 211;
        if (!Conversions.ToBoolean((object) (bool) (!Conversions.ToBoolean(Operators.CompareObjectGreaterEqual(Left1, (object) 21, false)) ? 0 : (Conversions.ToBoolean(Operators.CompareObjectLessEqual(Left1, (object) 38, false)) ? 1 : 0))))
          goto label_212;
label_208:
        num3 = 212;
        Left2 = 0.627f;
label_209:
        num3 = 213;
        Left3 = 38f;
label_210:
        num3 = 214;
        num7 = 21f;
label_211:
        num3 = 215;
        brush = (Brush) new SolidBrush(Color.FromArgb(237, 104, 35));
        goto label_237;
label_212:
        num3 = 217;
        if (!Conversions.ToBoolean((object) (bool) (!Conversions.ToBoolean(Operators.CompareObjectGreaterEqual(Left1, (object) 39, false)) ? 0 : (Conversions.ToBoolean(Operators.CompareObjectLessEqual(Left1, (object) 54, false)) ? 1 : 0))))
          goto label_217;
label_213:
        num3 = 218;
        Left2 = 0.527f;
label_214:
        num3 = 219;
        Left3 = 54f;
label_215:
        num3 = 220;
        num7 = 39f;
label_216:
        num3 = 221;
        brush = (Brush) new SolidBrush(Color.FromArgb(247, 175, 29));
        goto label_237;
label_217:
        num3 = 223;
        if (!Conversions.ToBoolean((object) (bool) (!Conversions.ToBoolean(Operators.CompareObjectGreaterEqual(Left1, (object) 55, false)) ? 0 : (Conversions.ToBoolean(Operators.CompareObjectLessEqual(Left1, (object) 68, false)) ? 1 : 0))))
          goto label_222;
label_218:
        num3 = 224;
        Left2 = 0.427f;
label_219:
        num3 = 225;
        Left3 = 68f;
label_220:
        num3 = 226;
        num7 = 55f;
label_221:
        num3 = 227;
        brush = (Brush) new SolidBrush(Color.FromArgb((int) byte.MaxValue, 242, 0));
        goto label_237;
label_222:
        num3 = 229;
        if (!Conversions.ToBoolean((object) (bool) (!Conversions.ToBoolean(Operators.CompareObjectGreaterEqual(Left1, (object) 69, false)) ? 0 : (Conversions.ToBoolean(Operators.CompareObjectLessEqual(Left1, (object) 80, false)) ? 1 : 0))))
          goto label_227;
label_223:
        num3 = 230;
        Left2 = 0.327f;
label_224:
        num3 = 231;
        Left3 = 80f;
label_225:
        num3 = 232;
        num7 = 69f;
label_226:
        num3 = 233;
        brush = (Brush) new SolidBrush(Color.FromArgb(157, 203, 60));
        goto label_237;
label_227:
        num3 = 235;
        if (!Conversions.ToBoolean((object) (bool) (!Conversions.ToBoolean(Operators.CompareObjectGreaterEqual(Left1, (object) 81, false)) ? 0 : (Conversions.ToBoolean(Operators.CompareObjectLessEqual(Left1, (object) 91, false)) ? 1 : 0))))
          goto label_232;
label_228:
        num3 = 236;
        Left2 = 0.227f;
label_229:
        num3 = 237;
        Left3 = 91f;
label_230:
        num3 = 238;
        num7 = 81f;
label_231:
        num3 = 239;
        brush = (Brush) new SolidBrush(Color.FromArgb(44, 159, 41));
        goto label_237;
label_232:
        num3 = 241;
        if (!Operators.ConditionalCompareObjectGreaterEqual(Left1, (object) 92, false))
          goto label_237;
label_233:
        num3 = 242;
        Left2 = 0.127f;
label_234:
        num3 = 243;
        Left3 = 100f;
label_235:
        num3 = 244;
        num7 = 92f;
label_236:
        num3 = 245;
        brush = (Brush) new SolidBrush(Color.FromArgb(0, (int) sbyte.MaxValue, 61));
label_237:
label_238:
        num3 = 246;
        if (!Operators.ConditionalCompareObjectGreater(sapRating1, (object) 99, false))
          goto label_240;
label_239:
        num3 = 247;
        float a = (Left2 + (float) (0.086585 * ((double) Left3 - 98.0) / ((double) Left3 - (double) num7))) * (float) num4;
        goto label_242;
label_240:
        num3 = 249;
        a = Conversions.ToSingle(Operators.MultiplyObject(Operators.AddObject((object) Left2, Operators.DivideObject(Operators.MultiplyObject((object) 0.086585, Operators.SubtractObject((object) Left3, sapRating1)), (object) (float) ((double) Left3 - (double) num7))), (object) num4));
label_241:
label_242:
        num3 = 251;
        points[0].X = checked ((int) Math.Round(unchecked (0.693 * (double) width1)));
label_243:
        num3 = 252;
        points[0].Y = checked ((int) Math.Round((double) a));
label_244:
        num3 = 253;
        points[1].X = checked ((int) Math.Round(unchecked (0.729 * (double) width1)));
label_245:
        num3 = 254;
        points[1].Y = checked ((int) Math.Round(unchecked ((double) a - 0.0477 * (double) num4)));
label_246:
        num3 = (int) byte.MaxValue;
        points[2].X = checked ((int) Math.Round(unchecked (0.839 * (double) width1)));
label_247:
        num3 = 256;
        points[2].Y = checked ((int) Math.Round(unchecked ((double) a - 0.0477 * (double) num4)));
label_248:
        num3 = 257;
        points[3].X = checked ((int) Math.Round(unchecked (0.839 * (double) width1)));
label_249:
        num3 = 258;
        points[3].Y = checked ((int) Math.Round(unchecked ((double) a + 0.0477 * (double) num4)));
label_250:
        num3 = 259;
        points[4].X = checked ((int) Math.Round(unchecked (0.729 * (double) width1)));
label_251:
        num3 = 260;
        points[4].Y = checked ((int) Math.Round(unchecked ((double) a + 0.0477 * (double) num4)));
label_252:
        num3 = 261;
        graphics2.FillPolygon(brush, points);
label_253:
        num3 = 262;
        num5 = checked ((int) Math.Round(unchecked (0.738 * (double) width1)));
label_254:
        num3 = 263;
        num6 = checked ((int) Math.Round(unchecked ((double) a - (double) graphics2.MeasureString("G", font2, 500).Height / 2.1)));
label_255:
        num3 = 264;
        if (!Operators.ConditionalCompareObjectGreater(sapRating1, (object) 99, false))
          goto label_258;
label_256:
        num3 = 265;
        num5 = 900;
label_257:
        num3 = 266;
        num6 = 102;
        goto label_261;
label_258:
        num3 = 268;
        num5 = checked ((int) Math.Round(unchecked (0.738 * (double) width1)));
label_259:
        num3 = 269;
        num6 = checked ((int) Math.Round(unchecked ((double) a - (double) graphics2.MeasureString("G", font2, 500).Height / 2.1)));
label_260:
label_261:
        num3 = 271;
        path.AddString(Conversion.Str(RuntimeHelpers.GetObjectValue(sapRating1)), font2.FontFamily, 1, 84f, new Point(num5, num6), StringFormat.GenericTypographic);
label_262:
        num3 = 272;
        graphics2.FillPath(Brushes.White, path);
label_263:
        num3 = 273;
        graphics2.DrawPath(pen2, path);
label_264:
        num3 = 274;
        if (SAP_Module.CalculationImprove2012.Calculation.SAP_rating_11a.SAPRating != 0.0)
          goto label_266;
label_265:
        num3 = 275;
        object sapRating2 = (object) SAP_Module.CalculationImprove2012.Calculation.SAP_rating_11b.SAPRating;
        goto label_268;
label_266:
        num3 = 277;
        sapRating2 = (object) SAP_Module.CalculationImprove2012.Calculation.SAP_rating_11a.SAPRating;
label_267:
label_268:
label_269:
        num3 = 279;
        object Left4 = sapRating2;
label_270:
        num3 = 281;
        if (!Conversions.ToBoolean((object) (bool) (!Conversions.ToBoolean(Operators.CompareObjectGreaterEqual(Left4, (object) 1, false)) ? 0 : (Conversions.ToBoolean(Operators.CompareObjectLessEqual(Left4, (object) 20, false)) ? 1 : 0))))
          goto label_275;
label_271:
        num3 = 282;
        Left2 = 0.727f;
label_272:
        num3 = 283;
        Left3 = 20f;
label_273:
        num3 = 284;
        num7 = 1f;
label_274:
        num3 = 285;
        brush = (Brush) new SolidBrush(Color.FromArgb(227, 29, 35));
        goto label_305;
label_275:
        num3 = 287;
        if (!Conversions.ToBoolean((object) (bool) (!Conversions.ToBoolean(Operators.CompareObjectGreaterEqual(Left4, (object) 21, false)) ? 0 : (Conversions.ToBoolean(Operators.CompareObjectLessEqual(Left4, (object) 38, false)) ? 1 : 0))))
          goto label_280;
label_276:
        num3 = 288;
        Left2 = 0.627f;
label_277:
        num3 = 289;
        Left3 = 38f;
label_278:
        num3 = 290;
        num7 = 21f;
label_279:
        num3 = 291;
        brush = (Brush) new SolidBrush(Color.FromArgb(237, 104, 35));
        goto label_305;
label_280:
        num3 = 293;
        if (!Conversions.ToBoolean((object) (bool) (!Conversions.ToBoolean(Operators.CompareObjectGreaterEqual(Left4, (object) 39, false)) ? 0 : (Conversions.ToBoolean(Operators.CompareObjectLessEqual(Left4, (object) 54, false)) ? 1 : 0))))
          goto label_285;
label_281:
        num3 = 294;
        Left2 = 0.527f;
label_282:
        num3 = 295;
        Left3 = 54f;
label_283:
        num3 = 296;
        num7 = 39f;
label_284:
        num3 = 297;
        brush = (Brush) new SolidBrush(Color.FromArgb(247, 175, 29));
        goto label_305;
label_285:
        num3 = 299;
        if (!Conversions.ToBoolean((object) (bool) (!Conversions.ToBoolean(Operators.CompareObjectGreaterEqual(Left4, (object) 55, false)) ? 0 : (Conversions.ToBoolean(Operators.CompareObjectLessEqual(Left4, (object) 68, false)) ? 1 : 0))))
          goto label_290;
label_286:
        num3 = 300;
        Left2 = 0.427f;
label_287:
        num3 = 301;
        Left3 = 68f;
label_288:
        num3 = 302;
        num7 = 55f;
label_289:
        num3 = 303;
        brush = (Brush) new SolidBrush(Color.FromArgb((int) byte.MaxValue, 242, 0));
        goto label_305;
label_290:
        num3 = 305;
        if (!Conversions.ToBoolean((object) (bool) (!Conversions.ToBoolean(Operators.CompareObjectGreaterEqual(Left4, (object) 69, false)) ? 0 : (Conversions.ToBoolean(Operators.CompareObjectLessEqual(Left4, (object) 80, false)) ? 1 : 0))))
          goto label_295;
label_291:
        num3 = 306;
        Left2 = 0.327f;
label_292:
        num3 = 307;
        Left3 = 80f;
label_293:
        num3 = 308;
        num7 = 69f;
label_294:
        num3 = 309;
        brush = (Brush) new SolidBrush(Color.FromArgb(157, 203, 60));
        goto label_305;
label_295:
        num3 = 311;
        if (!Conversions.ToBoolean((object) (bool) (!Conversions.ToBoolean(Operators.CompareObjectGreaterEqual(Left4, (object) 81, false)) ? 0 : (Conversions.ToBoolean(Operators.CompareObjectLessEqual(Left4, (object) 91, false)) ? 1 : 0))))
          goto label_300;
label_296:
        num3 = 312;
        Left2 = 0.227f;
label_297:
        num3 = 313;
        Left3 = 91f;
label_298:
        num3 = 314;
        num7 = 81f;
label_299:
        num3 = 315;
        brush = (Brush) new SolidBrush(Color.FromArgb(44, 159, 41));
        goto label_305;
label_300:
        num3 = 317;
        if (!Operators.ConditionalCompareObjectGreaterEqual(Left4, (object) 92, false))
          goto label_305;
label_301:
        num3 = 318;
        Left2 = 0.127f;
label_302:
        num3 = 319;
        Left3 = 100f;
label_303:
        num3 = 320;
        num7 = 92f;
label_304:
        num3 = 321;
        brush = (Brush) new SolidBrush(Color.FromArgb(0, (int) sbyte.MaxValue, 61));
label_305:
label_306:
        num3 = 322;
        if (!Operators.ConditionalCompareObjectGreater(sapRating2, (object) 99, false))
          goto label_308;
label_307:
        num3 = 323;
        a = (Left2 + (float) (0.086585 * ((double) Left3 - 98.0) / ((double) Left3 - (double) num7))) * (float) num4;
        goto label_310;
label_308:
        num3 = 325;
        a = Conversions.ToSingle(Operators.MultiplyObject(Operators.AddObject((object) Left2, Operators.DivideObject(Operators.MultiplyObject((object) 0.086585, Operators.SubtractObject((object) Left3, sapRating2)), (object) (float) ((double) Left3 - (double) num7))), (object) num4));
label_309:
label_310:
        num3 = 327;
        points[0].X = checked ((int) Math.Round(unchecked (0.853 * (double) width1)));
label_311:
        num3 = 328;
        points[0].Y = checked ((int) Math.Round((double) a));
label_312:
        num3 = 329;
        points[1].X = checked ((int) Math.Round(unchecked (0.887 * (double) width1)));
label_313:
        num3 = 330;
        points[1].Y = checked ((int) Math.Round(unchecked ((double) a - 0.0477 * (double) num4)));
label_314:
        num3 = 331;
        points[2].X = checked ((int) Math.Round(unchecked (0.992 * (double) width1)));
label_315:
        num3 = 332;
        points[2].Y = checked ((int) Math.Round(unchecked ((double) a - 0.0477 * (double) num4)));
label_316:
        num3 = 333;
        points[3].X = checked ((int) Math.Round(unchecked (0.992 * (double) width1)));
label_317:
        num3 = 334;
        points[3].Y = checked ((int) Math.Round(unchecked ((double) a + 0.0477 * (double) num4)));
label_318:
        num3 = 335;
        points[4].X = checked ((int) Math.Round(unchecked (0.887 * (double) width1)));
label_319:
        num3 = 336;
        points[4].Y = checked ((int) Math.Round(unchecked ((double) a + 0.0477 * (double) num4)));
label_320:
        num3 = 337;
        graphics2.FillPolygon(brush, points);
label_321:
        num3 = 338;
        num5 = checked ((int) Math.Round(unchecked (0.894 * (double) width1)));
label_322:
        num3 = 339;
        num6 = checked ((int) Math.Round(unchecked ((double) a - (double) graphics2.MeasureString("G", font2, 500).Height / 2.1)));
label_323:
        num3 = 340;
        if (!Operators.ConditionalCompareObjectGreater(sapRating2, (object) 99, false))
          goto label_326;
label_324:
        num3 = 341;
        num5 = 1150;
label_325:
        num3 = 342;
        num6 = 105;
        goto label_329;
label_326:
        num3 = 344;
        num5 = checked ((int) Math.Round(unchecked (0.894 * (double) width1)));
label_327:
        num3 = 345;
        num6 = checked ((int) Math.Round(unchecked ((double) a - (double) graphics2.MeasureString("G", font2, 500).Height / 2.1)));
label_328:
label_329:
        num3 = 347;
        path.AddString(Conversion.Str(RuntimeHelpers.GetObjectValue(sapRating2)), font2.FontFamily, 1, 84f, new Point(num5, num6), StringFormat.GenericTypographic);
label_330:
        num3 = 348;
        graphics2.FillPath(Brushes.White, path);
label_331:
        num3 = 349;
        graphics2.DrawPath(pen2, path);
label_332:
        graphics2 = (Graphics) null;
label_333:
        image1 = image1;
        goto label_339;
label_335:
        num2 = num3;
        switch (num1 > -2 ? num1 : 1)
        {
          case 1:
            int num8 = num2 + 1;
            num2 = 0;
            switch (num8)
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
                goto label_10;
              case 10:
                goto label_11;
              case 11:
                goto label_12;
              case 12:
                goto label_13;
              case 13:
                goto label_14;
              case 14:
                goto label_15;
              case 15:
                goto label_16;
              case 16:
                goto label_17;
              case 17:
                goto label_18;
              case 18:
                goto label_19;
              case 19:
                goto label_20;
              case 20:
                goto label_21;
              case 21:
                goto label_22;
              case 22:
                goto label_23;
              case 23:
                goto label_24;
              case 24:
                goto label_25;
              case 25:
                goto label_26;
              case 26:
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
                goto label_32;
              case 32:
                goto label_33;
              case 33:
                goto label_34;
              case 34:
                goto label_35;
              case 35:
                goto label_36;
              case 36:
                goto label_37;
              case 37:
                goto label_38;
              case 38:
                goto label_39;
              case 39:
                goto label_40;
              case 40:
                goto label_41;
              case 41:
              case 52:
                goto label_52;
              case 42:
                goto label_42;
              case 43:
                goto label_43;
              case 44:
                goto label_44;
              case 45:
                goto label_45;
              case 46:
                goto label_46;
              case 47:
                goto label_47;
              case 48:
                goto label_48;
              case 49:
                goto label_49;
              case 50:
                goto label_50;
              case 51:
                goto label_51;
              case 53:
                goto label_53;
              case 54:
                goto label_54;
              case 55:
                goto label_55;
              case 56:
                goto label_56;
              case 57:
                goto label_57;
              case 58:
                goto label_58;
              case 59:
                goto label_59;
              case 60:
                goto label_60;
              case 61:
                goto label_61;
              case 62:
                goto label_62;
              case 63:
                goto label_63;
              case 64:
                goto label_64;
              case 65:
                goto label_65;
              case 66:
                goto label_66;
              case 67:
                goto label_67;
              case 68:
                goto label_68;
              case 69:
                goto label_69;
              case 70:
                goto label_70;
              case 71:
                goto label_71;
              case 72:
                goto label_72;
              case 73:
                goto label_73;
              case 74:
                goto label_74;
              case 75:
                goto label_75;
              case 76:
                goto label_76;
              case 77:
                goto label_77;
              case 78:
                goto label_78;
              case 79:
                goto label_79;
              case 80:
                goto label_80;
              case 81:
                goto label_81;
              case 82:
                goto label_82;
              case 83:
                goto label_83;
              case 84:
                goto label_84;
              case 85:
                goto label_85;
              case 86:
                goto label_86;
              case 87:
                goto label_87;
              case 88:
                goto label_88;
              case 89:
                goto label_89;
              case 90:
                goto label_90;
              case 91:
                goto label_91;
              case 92:
                goto label_92;
              case 93:
                goto label_93;
              case 94:
                goto label_94;
              case 95:
                goto label_95;
              case 96:
                goto label_96;
              case 97:
                goto label_97;
              case 98:
                goto label_98;
              case 99:
                goto label_99;
              case 100:
                goto label_100;
              case 101:
                goto label_101;
              case 102:
                goto label_102;
              case 103:
                goto label_103;
              case 104:
                goto label_104;
              case 105:
                goto label_105;
              case 106:
                goto label_106;
              case 107:
                goto label_107;
              case 108:
                goto label_108;
              case 109:
                goto label_109;
              case 110:
                goto label_110;
              case 111:
                goto label_111;
              case 112:
                goto label_112;
              case 113:
                goto label_113;
              case 114:
                goto label_114;
              case 115:
                goto label_115;
              case 116:
                goto label_116;
              case 117:
                goto label_117;
              case 118:
                goto label_118;
              case 119:
                goto label_119;
              case 120:
                goto label_120;
              case 121:
                goto label_121;
              case 122:
                goto label_122;
              case 123:
                goto label_123;
              case 124:
                goto label_124;
              case 125:
                goto label_125;
              case 126:
                goto label_126;
              case (int) sbyte.MaxValue:
                goto label_127;
              case 128:
                goto label_128;
              case 129:
                goto label_129;
              case 130:
                goto label_130;
              case 131:
                goto label_131;
              case 132:
                goto label_132;
              case 133:
                goto label_133;
              case 134:
                goto label_134;
              case 135:
                goto label_135;
              case 136:
                goto label_136;
              case 137:
                goto label_137;
              case 138:
                goto label_138;
              case 139:
                goto label_139;
              case 140:
                goto label_140;
              case 141:
                goto label_141;
              case 142:
                goto label_142;
              case 143:
                goto label_143;
              case 144:
                goto label_144;
              case 145:
                goto label_145;
              case 146:
                goto label_146;
              case 147:
                goto label_147;
              case 148:
                goto label_148;
              case 149:
                goto label_149;
              case 150:
                goto label_150;
              case 151:
                goto label_151;
              case 152:
                goto label_152;
              case 153:
                goto label_153;
              case 154:
                goto label_154;
              case 155:
                goto label_155;
              case 156:
                goto label_156;
              case 157:
                goto label_157;
              case 158:
                goto label_158;
              case 159:
                goto label_159;
              case 160:
                goto label_160;
              case 161:
                goto label_161;
              case 162:
                goto label_162;
              case 163:
                goto label_163;
              case 164:
              case 191:
                goto label_189;
              case 165:
                goto label_164;
              case 166:
                goto label_165;
              case 167:
                goto label_166;
              case 168:
                goto label_167;
              case 169:
                goto label_168;
              case 170:
                goto label_169;
              case 171:
                goto label_170;
              case 172:
                goto label_171;
              case 173:
                goto label_172;
              case 174:
                goto label_173;
              case 175:
                goto label_174;
              case 176:
                goto label_175;
              case 177:
              case 190:
                goto label_188;
              case 178:
                goto label_176;
              case 179:
                goto label_177;
              case 180:
                goto label_178;
              case 181:
                goto label_179;
              case 182:
                goto label_180;
              case 183:
                goto label_181;
              case 184:
                goto label_182;
              case 185:
                goto label_183;
              case 186:
                goto label_184;
              case 187:
                goto label_185;
              case 188:
                goto label_186;
              case 189:
                goto label_187;
              case 192:
                goto label_190;
              case 193:
                goto label_191;
              case 194:
                goto label_192;
              case 195:
                goto label_193;
              case 196:
                goto label_194;
              case 197:
                goto label_195;
              case 198:
                goto label_196;
              case 199:
                goto label_197;
              case 200:
                goto label_200;
              case 201:
                goto label_198;
              case 202:
                goto label_199;
              case 203:
                goto label_201;
              case 204:
              case 210:
              case 216:
              case 222:
              case 228:
              case 234:
              case 240:
                goto label_237;
              case 205:
                goto label_202;
              case 206:
                goto label_203;
              case 207:
                goto label_204;
              case 208:
                goto label_205;
              case 209:
                goto label_206;
              case 211:
                goto label_207;
              case 212:
                goto label_208;
              case 213:
                goto label_209;
              case 214:
                goto label_210;
              case 215:
                goto label_211;
              case 217:
                goto label_212;
              case 218:
                goto label_213;
              case 219:
                goto label_214;
              case 220:
                goto label_215;
              case 221:
                goto label_216;
              case 223:
                goto label_217;
              case 224:
                goto label_218;
              case 225:
                goto label_219;
              case 226:
                goto label_220;
              case 227:
                goto label_221;
              case 229:
                goto label_222;
              case 230:
                goto label_223;
              case 231:
                goto label_224;
              case 232:
                goto label_225;
              case 233:
                goto label_226;
              case 235:
                goto label_227;
              case 236:
                goto label_228;
              case 237:
                goto label_229;
              case 238:
                goto label_230;
              case 239:
                goto label_231;
              case 241:
                goto label_232;
              case 242:
                goto label_233;
              case 243:
                goto label_234;
              case 244:
                goto label_235;
              case 245:
                goto label_236;
              case 246:
                goto label_238;
              case 247:
                goto label_239;
              case 248:
              case 251:
                goto label_242;
              case 249:
                goto label_240;
              case 250:
                goto label_241;
              case 252:
                goto label_243;
              case 253:
                goto label_244;
              case 254:
                goto label_245;
              case (int) byte.MaxValue:
                goto label_246;
              case 256:
                goto label_247;
              case 257:
                goto label_248;
              case 258:
                goto label_249;
              case 259:
                goto label_250;
              case 260:
                goto label_251;
              case 261:
                goto label_252;
              case 262:
                goto label_253;
              case 263:
                goto label_254;
              case 264:
                goto label_255;
              case 265:
                goto label_256;
              case 266:
                goto label_257;
              case 267:
              case 271:
                goto label_261;
              case 268:
                goto label_258;
              case 269:
                goto label_259;
              case 270:
                goto label_260;
              case 272:
                goto label_262;
              case 273:
                goto label_263;
              case 274:
                goto label_264;
              case 275:
                goto label_265;
              case 276:
                goto label_268;
              case 277:
                goto label_266;
              case 278:
                goto label_267;
              case 279:
                goto label_269;
              case 280:
              case 286:
              case 292:
              case 298:
              case 304:
              case 310:
              case 316:
                goto label_305;
              case 281:
                goto label_270;
              case 282:
                goto label_271;
              case 283:
                goto label_272;
              case 284:
                goto label_273;
              case 285:
                goto label_274;
              case 287:
                goto label_275;
              case 288:
                goto label_276;
              case 289:
                goto label_277;
              case 290:
                goto label_278;
              case 291:
                goto label_279;
              case 293:
                goto label_280;
              case 294:
                goto label_281;
              case 295:
                goto label_282;
              case 296:
                goto label_283;
              case 297:
                goto label_284;
              case 299:
                goto label_285;
              case 300:
                goto label_286;
              case 301:
                goto label_287;
              case 302:
                goto label_288;
              case 303:
                goto label_289;
              case 305:
                goto label_290;
              case 306:
                goto label_291;
              case 307:
                goto label_292;
              case 308:
                goto label_293;
              case 309:
                goto label_294;
              case 311:
                goto label_295;
              case 312:
                goto label_296;
              case 313:
                goto label_297;
              case 314:
                goto label_298;
              case 315:
                goto label_299;
              case 317:
                goto label_300;
              case 318:
                goto label_301;
              case 319:
                goto label_302;
              case 320:
                goto label_303;
              case 321:
                goto label_304;
              case 322:
                goto label_306;
              case 323:
                goto label_307;
              case 324:
              case 327:
                goto label_310;
              case 325:
                goto label_308;
              case 326:
                goto label_309;
              case 328:
                goto label_311;
              case 329:
                goto label_312;
              case 330:
                goto label_313;
              case 331:
                goto label_314;
              case 332:
                goto label_315;
              case 333:
                goto label_316;
              case 334:
                goto label_317;
              case 335:
                goto label_318;
              case 336:
                goto label_319;
              case 337:
                goto label_320;
              case 338:
                goto label_321;
              case 339:
                goto label_322;
              case 340:
                goto label_323;
              case 341:
                goto label_324;
              case 342:
                goto label_325;
              case 343:
              case 347:
                goto label_329;
              case 344:
                goto label_326;
              case 345:
                goto label_327;
              case 346:
                goto label_328;
              case 348:
                goto label_330;
              case 349:
                goto label_331;
              case 350:
                goto label_332;
              case 351:
                goto label_333;
              case 352:
                goto label_339;
            }
            break;
        }
      }
      catch (Exception ex) when (ex is Exception & (uint) num1 > 0U & num2 == 0)
      {
        ProjectData.SetProjectError(ex);
        goto label_335;
      }
      throw ProjectData.CreateProjectError(-2146828237);
label_339:
      if (num2 != 0)
        ProjectData.ClearProjectError();
      return image1;
    }

    public static Image DrawEnvironGraphPredicted(int Country, int House)
    {
      int num1;
      Image image1;
      int num2;
      try
      {
label_2:
        ProjectData.ClearProjectError();
        num1 = -2;
label_3:
        int num3 = 2;
        int width1 = 1344;
label_4:
        num3 = 3;
        int num4 = 1088;
label_5:
        num3 = 4;
        image1 = (Image) new Bitmap(width1, num4);
label_6:
        num3 = 5;
        Graphics graphics1 = Graphics.FromImage(image1);
label_7:
        num3 = 6;
        Font font1 = new Font("Arial", 64f, FontStyle.Bold);
label_8:
        num3 = 7;
        Font font2 = new Font("Arial", 56f, FontStyle.Bold);
label_9:
        num3 = 8;
        Font font3 = new Font("Arial", 36f, FontStyle.Regular);
label_10:
        num3 = 9;
        Font font4 = new Font("Arial", 32f, FontStyle.Bold);
label_11:
        num3 = 10;
        Font font5 = new Font("Arial", 28f, FontStyle.Italic);
label_12:
        num3 = 11;
        Font font6 = new Font("Arial", 28f, FontStyle.Bold);
label_13:
        num3 = 12;
        Font font7 = new Font("Arial", 24f, FontStyle.Regular);
label_14:
        num3 = 13;
        Pen pen1 = (Pen) Pens.Black.Clone();
label_15:
        num3 = 14;
        pen1.Width = 5f;
label_16:
        num3 = 15;
        Pen pen2 = (Pen) Pens.Black.Clone();
label_17:
        num3 = 16;
        pen2.Width = 3f;
label_18:
        num3 = 17;
        Pen pen3 = new Pen(Color.Black, 2f);
label_19:
        num3 = 18;
        Graphics graphics2 = graphics1;
label_20:
        num3 = 19;
        graphics2.TextRenderingHint = TextRenderingHint.AntiAlias;
label_21:
        num3 = 20;
        graphics2.SmoothingMode = SmoothingMode.AntiAlias;
label_22:
        num3 = 21;
        graphics1.FillRectangle(Brushes.White, 0, 0, width1, num4);
label_23:
        num3 = 22;
        graphics2.DrawLine(pen1, 1, 1, checked (width1 - 1), 1);
label_24:
        num3 = 23;
        graphics2.DrawLine(pen1, checked (width1 - 1), 1, checked (width1 - 1), checked (num4 - 1));
label_25:
        num3 = 24;
        graphics2.DrawLine(pen1, checked (width1 - 1), checked (num4 - 1), 1, checked (num4 - 1));
label_26:
        num3 = 25;
        graphics2.DrawLine(pen1, 1, checked (num4 - 1), 1, 1);
label_27:
        num3 = 26;
        int num5 = checked ((int) Math.Round(unchecked (0.688 * (double) width1)));
label_28:
        num3 = 27;
        int num6 = checked ((int) Math.Round(unchecked (0.885 * (double) num4)));
label_29:
        num3 = 28;
        num5 = checked ((int) Math.Round(unchecked (0.845 * (double) width1)));
label_30:
        num3 = 29;
        graphics2.DrawLine(pen1, num5, num6, num5, 1);
label_31:
        num3 = 30;
        if (!(Country == 2 & Operators.CompareString(SAP_Module.Proj.Dwellings[House].EPCLanguage, "Welsh", false) == 0))
          goto label_41;
label_32:
        num3 = 31;
        num5 = checked ((int) Math.Round(unchecked (0.766 * (double) width1 - (double) graphics2.MeasureString("", font4, 500).Width / 2.0)));
label_33:
        num3 = 32;
        num6 = checked ((int) Math.Round(unchecked (0.2 * (double) font4.GetHeight())));
label_34:
        num3 = 33;
        graphics2.DrawString("", font4, Brushes.Black, (float) num5, (float) num6);
label_35:
        num3 = 34;
        num5 = checked ((int) Math.Round(unchecked (0.921 * (double) width1 - (double) graphics2.MeasureString("", font4, 500).Width / 2.0)));
label_36:
        num3 = 35;
        num6 = checked ((int) Math.Round(unchecked (0.2 * (double) font4.GetHeight())));
label_37:
        num3 = 36;
        graphics2.DrawString("", font4, Brushes.Black, (float) num5, (float) num6);
label_38:
        num3 = 37;
        num5 = checked ((int) Math.Round(unchecked (0.02 * (double) width1)));
label_39:
        num3 = 38;
        num6 = checked ((int) Math.Round(unchecked (1.6 * (double) font4.GetHeight())));
label_40:
        num3 = 39;
        graphics2.DrawString("Amgylcheddol gyfeillgar iawn – allyriadau CO2 is", font5, Brushes.Black, (float) num5, (float) num6);
        goto label_51;
label_41:
        num3 = 41;
        num5 = checked ((int) Math.Round(unchecked (0.766 * (double) width1 - (double) graphics2.MeasureString("", font4, 500).Width / 2.0)));
label_42:
        num3 = 42;
        num6 = checked ((int) Math.Round(unchecked (0.2 * (double) font4.GetHeight())));
label_43:
        num3 = 43;
        graphics2.DrawString("", font4, Brushes.Black, (float) num5, (float) num6);
label_44:
        num3 = 44;
        num5 = checked ((int) Math.Round(unchecked (0.921 * (double) width1 - (double) graphics2.MeasureString("", font4, 500).Width / 2.0)));
label_45:
        num3 = 45;
        num6 = checked ((int) Math.Round(unchecked (0.2 * (double) font4.GetHeight())));
label_46:
        num3 = 46;
        graphics2.DrawString("", font4, Brushes.Black, (float) num5, (float) num6);
label_47:
        num3 = 47;
        num5 = checked ((int) Math.Round(unchecked (0.02 * (double) width1)));
label_48:
        num3 = 48;
        num6 = checked ((int) Math.Round(unchecked (1.6 * (double) font4.GetHeight())));
label_49:
        num3 = 49;
        graphics2.DrawString("Very environmentally friendly - lower CO2 emissions", font5, Brushes.Black, (float) num5, (float) num6);
label_50:
label_51:
        num3 = 51;
        num6 = checked ((int) Math.Round(unchecked (0.063 * (double) num4)));
label_52:
        num3 = 52;
        graphics2.DrawLine(pen1, 1, num6, checked (width1 - 1), num6);
label_53:
        num3 = 53;
        Brush brush = (Brush) new SolidBrush(Color.FromArgb(205, 226, 245));
label_54:
        num3 = 54;
        num5 = checked ((int) Math.Round(unchecked (0.01 * (double) width1)));
label_55:
        num3 = 55;
        num6 = checked ((int) Math.Round(unchecked (0.127 * (double) num4)));
label_56:
        num3 = 56;
        int width2 = checked ((int) Math.Round(unchecked (0.221 * (double) width1)));
label_57:
        num3 = 57;
        int height = checked ((int) Math.Round(unchecked (0.086585 * (double) num4)));
label_58:
        num3 = 58;
        graphics2.FillRectangle(brush, num5, num6, width2, height);
label_59:
        num3 = 59;
        num6 = checked ((int) Math.Round(unchecked ((double) num6 + (double) height / 2.0 - (double) graphics2.MeasureString("()", font6, 500).Height / 2.0)));
label_60:
        num3 = 60;
        num5 = checked ((int) Math.Round(unchecked (0.025 * (double) width1)));
label_61:
        num3 = 61;
        graphics2.DrawString("(92 plus)", font6, Brushes.Black, (float) num5, (float) num6);
label_62:
        num3 = 62;
        num5 = checked ((int) Math.Round(unchecked (0.158 * (double) width1)));
label_63:
        num3 = 63;
        num6 = checked ((int) Math.Round(unchecked (0.127 * (double) num4 + (double) height / 2.0 - (double) graphics2.MeasureString("A", font1, 900).Height / 2.1)));
label_64:
        num3 = 64;
        GraphicsPath path = new GraphicsPath();
label_65:
        num3 = 65;
        path.AddString("A", font1.FontFamily, 1, 84f, new Point(num5, num6), StringFormat.GenericTypographic);
label_66:
        num3 = 66;
        graphics2.FillPath(Brushes.White, path);
label_67:
        num3 = 67;
        graphics2.DrawPath(pen2, path);
label_68:
        num3 = 68;
        num5 = checked ((int) Math.Round(unchecked (0.01 * (double) width1)));
label_69:
        num3 = 69;
        brush = (Brush) new SolidBrush(Color.FromArgb(151, 192, 239));
label_70:
        num3 = 70;
        num6 = checked ((int) Math.Round(unchecked (0.227 * (double) num4)));
label_71:
        num3 = 71;
        width2 = checked ((int) Math.Round(unchecked (0.295 * (double) width1)));
label_72:
        num3 = 72;
        graphics2.FillRectangle(brush, num5, num6, width2, height);
label_73:
        num3 = 73;
        num6 = checked ((int) Math.Round(unchecked ((double) num6 + (double) height / 2.0 - (double) graphics2.MeasureString("()", font6, 900).Height / 2.0)));
label_74:
        num3 = 74;
        num5 = checked ((int) Math.Round(unchecked (0.025 * (double) width1)));
label_75:
        num3 = 75;
        graphics2.DrawString("(81-91)", font6, Brushes.Black, (float) num5, (float) num6);
label_76:
        num3 = 76;
        num5 = checked ((int) Math.Round(unchecked (0.239 * (double) width1)));
label_77:
        num3 = 77;
        num6 = checked ((int) Math.Round(unchecked (0.227 * (double) num4 + (double) height / 2.0 - (double) graphics2.MeasureString("B", font1, 500).Height / 2.1)));
label_78:
        num3 = 78;
        path.AddString("B", font1.FontFamily, 1, 84f, new Point(num5, num6), StringFormat.GenericTypographic);
label_79:
        num3 = 79;
        graphics2.FillPath(Brushes.White, path);
label_80:
        num3 = 80;
        graphics2.DrawPath(pen2, path);
label_81:
        num3 = 81;
        num5 = checked ((int) Math.Round(unchecked (0.01 * (double) width1)));
label_82:
        num3 = 82;
        brush = (Brush) new SolidBrush(Color.FromArgb(115, 162, 214));
label_83:
        num3 = 83;
        num6 = checked ((int) Math.Round(unchecked (0.327 * (double) num4)));
label_84:
        num3 = 84;
        width2 = checked ((int) Math.Round(unchecked (0.37 * (double) width1)));
label_85:
        num3 = 85;
        graphics2.FillRectangle(brush, num5, num6, width2, height);
label_86:
        num3 = 86;
        num6 = checked ((int) Math.Round(unchecked ((double) num6 + (double) height / 2.0 - (double) graphics2.MeasureString("()", font6, 900).Height / 2.0)));
label_87:
        num3 = 87;
        num5 = checked ((int) Math.Round(unchecked (0.025 * (double) width1)));
label_88:
        num3 = 88;
        graphics2.DrawString("(69-80)", font6, Brushes.Black, (float) num5, (float) num6);
label_89:
        num3 = 89;
        num5 = checked ((int) Math.Round(unchecked (0.307 * (double) width1)));
label_90:
        num3 = 90;
        num6 = checked ((int) Math.Round(unchecked (0.327 * (double) num4 + (double) height / 2.0 - (double) graphics2.MeasureString("C", font1, 500).Height / 2.1)));
label_91:
        num3 = 91;
        path.AddString("C", font1.FontFamily, 1, 84f, new Point(num5, num6), StringFormat.GenericTypographic);
label_92:
        num3 = 92;
        graphics2.FillPath(Brushes.White, path);
label_93:
        num3 = 93;
        graphics2.DrawPath(pen2, path);
label_94:
        num3 = 94;
        num5 = checked ((int) Math.Round(unchecked (0.01 * (double) width1)));
label_95:
        num3 = 95;
        brush = (Brush) new SolidBrush(Color.FromArgb(78, 132, 196));
label_96:
        num3 = 96;
        num6 = checked ((int) Math.Round(unchecked (0.427 * (double) num4)));
label_97:
        num3 = 97;
        width2 = checked ((int) Math.Round(unchecked (0.445 * (double) width1)));
label_98:
        num3 = 98;
        graphics2.FillRectangle(brush, num5, num6, width2, height);
label_99:
        num3 = 99;
        num6 = checked ((int) Math.Round(unchecked ((double) num6 + (double) height / 2.0 - (double) graphics2.MeasureString("()", font6, 900).Height / 2.0)));
label_100:
        num3 = 100;
        num5 = checked ((int) Math.Round(unchecked (0.025 * (double) width1)));
label_101:
        num3 = 101;
        graphics2.DrawString("(55-68)", font6, Brushes.Black, (float) num5, (float) num6);
label_102:
        num3 = 102;
        num5 = checked ((int) Math.Round(unchecked (0.387 * (double) width1)));
label_103:
        num3 = 103;
        num6 = checked ((int) Math.Round(unchecked (0.427 * (double) num4 + (double) height / 2.0 - (double) graphics2.MeasureString("D", font1, 500).Height / 2.1)));
label_104:
        num3 = 104;
        path.AddString("D", font1.FontFamily, 1, 84f, new Point(num5, num6), StringFormat.GenericTypographic);
label_105:
        num3 = 105;
        graphics2.FillPath(Brushes.White, path);
label_106:
        num3 = 106;
        graphics2.DrawPath(pen2, path);
label_107:
        num3 = 107;
        num5 = checked ((int) Math.Round(unchecked (0.01 * (double) width1)));
label_108:
        num3 = 108;
        brush = (Brush) new SolidBrush(Color.FromArgb(168, 168, 168));
label_109:
        num3 = 109;
        num6 = checked ((int) Math.Round(unchecked (0.527 * (double) num4)));
label_110:
        num3 = 110;
        width2 = checked ((int) Math.Round(unchecked (0.518 * (double) width1)));
label_111:
        num3 = 111;
        graphics2.FillRectangle(brush, num5, num6, width2, height);
label_112:
        num3 = 112;
        num6 = checked ((int) Math.Round(unchecked ((double) num6 + (double) height / 2.0 - (double) graphics2.MeasureString("()", font6, 900).Height / 2.0)));
label_113:
        num3 = 113;
        num5 = checked ((int) Math.Round(unchecked (0.025 * (double) width1)));
label_114:
        num3 = 114;
        graphics2.DrawString("(39-54)", font6, Brushes.Black, (float) num5, (float) num6);
label_115:
        num3 = 115;
        num5 = checked ((int) Math.Round(unchecked (0.459 * (double) width1)));
label_116:
        num3 = 116;
        num6 = checked ((int) Math.Round(unchecked (0.527 * (double) num4 + (double) height / 2.0 - (double) graphics2.MeasureString("E", font1, 500).Height / 2.1)));
label_117:
        num3 = 117;
        path.AddString("E", font1.FontFamily, 1, 84f, new Point(num5, num6), StringFormat.GenericTypographic);
label_118:
        num3 = 118;
        graphics2.FillPath(Brushes.White, path);
label_119:
        num3 = 119;
        graphics2.DrawPath(pen2, path);
label_120:
        num3 = 120;
        num5 = checked ((int) Math.Round(unchecked (0.01 * (double) width1)));
label_121:
        num3 = 121;
        brush = (Brush) new SolidBrush(Color.FromArgb(134, 134, 134));
label_122:
        num3 = 122;
        num6 = checked ((int) Math.Round(unchecked (0.627 * (double) num4)));
label_123:
        num3 = 123;
        width2 = checked ((int) Math.Round(unchecked (0.592 * (double) width1)));
label_124:
        num3 = 124;
        graphics2.FillRectangle(brush, num5, num6, width2, height);
label_125:
        num3 = 125;
        num6 = checked ((int) Math.Round(unchecked ((double) num6 + (double) height / 2.0 - (double) graphics2.MeasureString("()", font6, 900).Height / 2.0)));
label_126:
        num3 = 126;
        num5 = checked ((int) Math.Round(unchecked (0.025 * (double) width1)));
label_127:
        num3 = (int) sbyte.MaxValue;
        graphics2.DrawString("(21-38)", font6, Brushes.White, (float) num5, (float) num6);
label_128:
        num3 = 128;
        num5 = checked ((int) Math.Round(unchecked (0.536 * (double) width1)));
label_129:
        num3 = 129;
        num6 = checked ((int) Math.Round(unchecked (0.627 * (double) num4 + (double) height / 2.0 - (double) graphics2.MeasureString("F", font1, 500).Height / 2.1)));
label_130:
        num3 = 130;
        path.AddString("F", font1.FontFamily, 1, 84f, new Point(num5, num6), StringFormat.GenericTypographic);
label_131:
        num3 = 131;
        graphics2.FillPath(Brushes.White, path);
label_132:
        num3 = 132;
        graphics2.DrawPath(pen2, path);
label_133:
        num3 = 133;
        num5 = checked ((int) Math.Round(unchecked (0.01 * (double) width1)));
label_134:
        num3 = 134;
        brush = (Brush) new SolidBrush(Color.FromArgb(104, 104, 104));
label_135:
        num3 = 135;
        num6 = checked ((int) Math.Round(unchecked (0.727 * (double) num4)));
label_136:
        num3 = 136;
        width2 = checked ((int) Math.Round(unchecked (0.668 * (double) width1)));
label_137:
        num3 = 137;
        graphics2.FillRectangle(brush, num5, num6, width2, height);
label_138:
        num3 = 138;
        num6 = checked ((int) Math.Round(unchecked ((double) num6 + (double) height / 2.0 - (double) graphics2.MeasureString("()", font6, 900).Height / 2.0)));
label_139:
        num3 = 139;
        num5 = checked ((int) Math.Round(unchecked (0.025 * (double) width1)));
label_140:
        num3 = 140;
        graphics2.DrawString("(1-20)", font6, Brushes.White, (float) num5, (float) num6);
label_141:
        num3 = 141;
        num5 = checked ((int) Math.Round(unchecked (0.607 * (double) width1)));
label_142:
        num3 = 142;
        num6 = checked ((int) Math.Round(unchecked (0.727 * (double) num4 + (double) height / 2.0 - (double) graphics2.MeasureString("G", font1, 500).Height / 2.1)));
label_143:
        num3 = 143;
        path.AddString("G", font1.FontFamily, 1, 84f, new Point(num5, num6), StringFormat.GenericTypographic);
label_144:
        num3 = 144;
        graphics2.FillPath(Brushes.White, path);
label_145:
        num3 = 145;
        graphics2.DrawPath(pen2, path);
label_146:
        num3 = 146;
        num5 = checked ((int) Math.Round(unchecked (0.01 * (double) width1)));
label_147:
        num3 = 147;
        num6 = checked ((int) Math.Round(unchecked (0.885 * (double) num4)));
label_148:
        num3 = 148;
        graphics2.DrawLine(pen1, 1, num6, checked (width1 - 1), num6);
label_149:
        num3 = 149;
        num6 = checked ((int) Math.Round(unchecked ((0.885 * (double) num4 - (0.727 * (double) num4 + 0.086585 * (double) num4)) / 2.0 + (0.727 * (double) num4 + 0.086585 * (double) num4) - (double) graphics2.MeasureString("Potential", font5, 500).Height / 2.0)));
label_150:
        num3 = 150;
        num5 = checked ((int) Math.Round(unchecked (0.02 * (double) width1)));
label_151:
        num3 = 151;
        if (!(Country == 2 & Operators.CompareString(SAP_Module.Proj.Dwellings[House].EPCLanguage, "Welsh", false) == 0))
          goto label_163;
label_152:
        num3 = 152;
        graphics2.DrawString("Ddim yn amgylcheddol gyfeillgar - allyriadau CO2 uwch", font5, Brushes.Black, (float) num5, (float) num6);
label_153:
        num3 = 153;
        num6 = checked ((int) Math.Round(unchecked (23.0 / 400.0 * (double) num4 + 0.885 * (double) num4 - 0.5 * (double) graphics2.MeasureString("Cymru a Lloegr", font2, 900).Height)));
label_154:
        num3 = 154;
        num5 = checked ((int) Math.Round(unchecked (0.025 * (double) width1)));
label_155:
        num3 = 155;
        graphics2.DrawString("Cymru a Lloegr", font2, Brushes.Black, (float) num5, (float) num6);
label_156:
        num3 = 156;
        num6 = checked ((int) Math.Round(unchecked (23.0 / 400.0 * (double) num4 + 0.885 * (double) num4 - (double) graphics2.MeasureString("Cyfarwyddeb 2002/91/EC", font7, 500).Height)));
label_157:
        num3 = 157;
        num5 = checked ((int) Math.Round(unchecked (0.59 * (double) width1)));
label_158:
        num3 = 158;
        graphics2.DrawString("Cyfarwyddeb 2002/91/EC", font7, Brushes.Black, (float) num5, (float) num6);
label_159:
        num3 = 159;
        num6 = checked ((int) Math.Round(unchecked (23.0 / 400.0 * (double) num4 + 0.885 * (double) num4)));
label_160:
        num3 = 160;
        num5 = checked ((int) Math.Round(unchecked (0.63 * (double) width1)));
label_161:
        num3 = 161;
        graphics2.DrawString("yr Undeb Ewropeaidd", font7, Brushes.Black, (float) num5, (float) num6);
label_162:
        num3 = 162;
        num6 = checked ((int) Math.Round(unchecked (23.0 / 400.0 * (double) num4 + 0.885 * (double) num4 - 0.52 * (double) graphics2.MeasureString("Cymru a Lloegr", font2, 900).Height)));
        goto label_183;
label_163:
        num3 = 164;
        graphics2.DrawString("Not environmentally friendly - higher CO2 emissions", font5, Brushes.Black, (float) num5, (float) num6);
label_164:
        num3 = 165;
        if (Operators.CompareString(SAP_Module.Proj.Dwellings[House].Address.Country, "Scotland", false) != 0)
          goto label_168;
label_165:
        num3 = 166;
        num6 = checked ((int) Math.Round(unchecked (23.0 / 400.0 * (double) num4 + 0.885 * (double) num4 - 0.5 * (double) graphics2.MeasureString("Scotland", font2, 900).Height)));
label_166:
        num3 = 167;
        num5 = checked ((int) Math.Round(unchecked (0.025 * (double) width1)));
label_167:
        num3 = 168;
        graphics2.DrawString("Scotland", font2, Brushes.Black, (float) num5, (float) num6);
        goto label_172;
label_168:
        num3 = 170;
        num6 = checked ((int) Math.Round(unchecked (23.0 / 400.0 * (double) num4 + 0.885 * (double) num4 - 0.5 * (double) graphics2.MeasureString("England & Wales", font2, 900).Height)));
label_169:
        num3 = 171;
        num5 = checked ((int) Math.Round(unchecked (0.025 * (double) width1)));
label_170:
        num3 = 172;
        graphics2.DrawString("England & Wales", font2, Brushes.Black, (float) num5, (float) num6);
label_171:
label_172:
        num3 = 174;
        num6 = checked ((int) Math.Round(unchecked (23.0 / 400.0 * (double) num4 + 0.885 * (double) num4 - (double) graphics2.MeasureString("EU Directive", font3, 500).Height)));
label_173:
        num3 = 175;
        num5 = checked ((int) Math.Round(unchecked (0.66 * (double) width1)));
label_174:
        num3 = 176;
        graphics2.DrawString("EU Directive", font3, Brushes.Black, (float) num5, (float) num6);
label_175:
        num3 = 177;
        num6 = checked ((int) Math.Round(unchecked (23.0 / 400.0 * (double) num4 + 0.885 * (double) num4)));
label_176:
        num3 = 178;
        num5 = checked ((int) Math.Round(unchecked (0.66 * (double) width1)));
label_177:
        num3 = 179;
        graphics2.DrawString("2002/91/EC", font3, Brushes.Black, (float) num5, (float) num6);
label_178:
        num3 = 180;
        if (Operators.CompareString(SAP_Module.Proj.Dwellings[House].Address.Country, "Scotland", false) != 0)
          goto label_180;
label_179:
        num3 = 181;
        num6 = checked ((int) Math.Round(unchecked (23.0 / 400.0 * (double) num4 + 0.885 * (double) num4 - 0.52 * (double) graphics2.MeasureString("Scotland", font2, 900).Height)));
        goto label_182;
label_180:
        num3 = 183;
        num6 = checked ((int) Math.Round(unchecked (23.0 / 400.0 * (double) num4 + 0.885 * (double) num4 - 0.52 * (double) graphics2.MeasureString("England & Wales", font2, 900).Height)));
label_181:
label_182:
label_183:
        num3 = 186;
        num5 = checked ((int) Math.Round(unchecked (0.88 * (double) width1)));
label_184:
        num3 = 187;
        Image image2 = Image.FromFile(Application.StartupPath + "\\Resources\\EU.bmp");
label_185:
        num3 = 188;
        width2 = checked ((int) Math.Round(unchecked ((double) image2.Width / 2.75)));
label_186:
        num3 = 189;
        height = checked ((int) Math.Round(unchecked ((double) image2.Height / 2.75)));
label_187:
        num3 = 190;
        graphics2.DrawImage(image2, num5, num6, width2, height);
label_188:
        num3 = 191;
        Point[] points = new Point[5];
label_189:
        num3 = 192;
label_190:
        num3 = 193;
        if (SAP_Module.Calculation2012.Calculation.CO2_Emissions_12a.Box274 != 0.0)
          goto label_192;
label_191:
        num3 = 194;
        object obj = (object) SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.EIRating;
        goto label_194;
label_192:
        num3 = 196;
        obj = (object) SAP_Module.Calculation2012.Calculation.CO2_Emissions_12a.Box274;
label_193:
label_194:
label_195:
        num3 = 198;
        object Left1 = obj;
label_196:
        num3 = 200;
        if (!Conversions.ToBoolean((object) (bool) (!Conversions.ToBoolean(Operators.CompareObjectGreaterEqual(Left1, (object) 1, false)) ? 0 : (Conversions.ToBoolean(Operators.CompareObjectLessEqual(Left1, (object) 20, false)) ? 1 : 0))))
          goto label_201;
label_197:
        num3 = 201;
        float Left2 = 0.727f;
label_198:
        num3 = 202;
        float Left3 = 20f;
label_199:
        num3 = 203;
        float num7 = 1f;
label_200:
        num3 = 204;
        brush = (Brush) new SolidBrush(Color.FromArgb(104, 104, 104));
        goto label_231;
label_201:
        num3 = 206;
        if (!Conversions.ToBoolean((object) (bool) (!Conversions.ToBoolean(Operators.CompareObjectGreaterEqual(Left1, (object) 21, false)) ? 0 : (Conversions.ToBoolean(Operators.CompareObjectLessEqual(Left1, (object) 38, false)) ? 1 : 0))))
          goto label_206;
label_202:
        num3 = 207;
        Left2 = 0.627f;
label_203:
        num3 = 208;
        Left3 = 38f;
label_204:
        num3 = 209;
        num7 = 21f;
label_205:
        num3 = 210;
        brush = (Brush) new SolidBrush(Color.FromArgb(134, 134, 134));
        goto label_231;
label_206:
        num3 = 212;
        if (!Conversions.ToBoolean((object) (bool) (!Conversions.ToBoolean(Operators.CompareObjectGreaterEqual(Left1, (object) 39, false)) ? 0 : (Conversions.ToBoolean(Operators.CompareObjectLessEqual(Left1, (object) 54, false)) ? 1 : 0))))
          goto label_211;
label_207:
        num3 = 213;
        Left2 = 0.527f;
label_208:
        num3 = 214;
        Left3 = 54f;
label_209:
        num3 = 215;
        num7 = 39f;
label_210:
        num3 = 216;
        brush = (Brush) new SolidBrush(Color.FromArgb(168, 168, 168));
        goto label_231;
label_211:
        num3 = 218;
        if (!Conversions.ToBoolean((object) (bool) (!Conversions.ToBoolean(Operators.CompareObjectGreaterEqual(Left1, (object) 55, false)) ? 0 : (Conversions.ToBoolean(Operators.CompareObjectLessEqual(Left1, (object) 68, false)) ? 1 : 0))))
          goto label_216;
label_212:
        num3 = 219;
        Left2 = 0.427f;
label_213:
        num3 = 220;
        Left3 = 68f;
label_214:
        num3 = 221;
        num7 = 55f;
label_215:
        num3 = 222;
        brush = (Brush) new SolidBrush(Color.FromArgb(78, 132, 196));
        goto label_231;
label_216:
        num3 = 224;
        if (!Conversions.ToBoolean((object) (bool) (!Conversions.ToBoolean(Operators.CompareObjectGreaterEqual(Left1, (object) 69, false)) ? 0 : (Conversions.ToBoolean(Operators.CompareObjectLessEqual(Left1, (object) 80, false)) ? 1 : 0))))
          goto label_221;
label_217:
        num3 = 225;
        Left2 = 0.327f;
label_218:
        num3 = 226;
        Left3 = 80f;
label_219:
        num3 = 227;
        num7 = 69f;
label_220:
        num3 = 228;
        brush = (Brush) new SolidBrush(Color.FromArgb(115, 162, 214));
        goto label_231;
label_221:
        num3 = 230;
        if (!Conversions.ToBoolean((object) (bool) (!Conversions.ToBoolean(Operators.CompareObjectGreaterEqual(Left1, (object) 81, false)) ? 0 : (Conversions.ToBoolean(Operators.CompareObjectLessEqual(Left1, (object) 91, false)) ? 1 : 0))))
          goto label_226;
label_222:
        num3 = 231;
        Left2 = 0.227f;
label_223:
        num3 = 232;
        Left3 = 91f;
label_224:
        num3 = 233;
        num7 = 81f;
label_225:
        num3 = 234;
        brush = (Brush) new SolidBrush(Color.FromArgb(151, 192, 239));
        goto label_231;
label_226:
        num3 = 236;
        if (!Operators.ConditionalCompareObjectGreaterEqual(Left1, (object) 92, false))
          goto label_231;
label_227:
        num3 = 237;
        Left2 = 0.127f;
label_228:
        num3 = 238;
        Left3 = 100f;
label_229:
        num3 = 239;
        num7 = 92f;
label_230:
        num3 = 240;
        brush = (Brush) new SolidBrush(Color.FromArgb(205, 226, 245));
label_231:
label_232:
        num3 = 241;
        if (!Operators.ConditionalCompareObjectGreater(obj, (object) 99, false))
          goto label_234;
label_233:
        num3 = 242;
        float a = (Left2 + (float) (0.086585 * ((double) Left3 - 98.0) / ((double) Left3 - (double) num7))) * (float) num4;
        goto label_236;
label_234:
        num3 = 244;
        a = Conversions.ToSingle(Operators.MultiplyObject(Operators.AddObject((object) Left2, Operators.DivideObject(Operators.MultiplyObject((object) 0.086585, Operators.SubtractObject((object) Left3, obj)), (object) (float) ((double) Left3 - (double) num7))), (object) num4));
label_235:
label_236:
        num3 = 246;
        points[0].X = checked ((int) Math.Round(unchecked (0.853 * (double) width1)));
label_237:
        num3 = 247;
        points[0].Y = checked ((int) Math.Round((double) a));
label_238:
        num3 = 248;
        points[1].X = checked ((int) Math.Round(unchecked (0.887 * (double) width1)));
label_239:
        num3 = 249;
        points[1].Y = checked ((int) Math.Round(unchecked ((double) a - 0.0477 * (double) num4)));
label_240:
        num3 = 250;
        points[2].X = checked ((int) Math.Round(unchecked (0.992 * (double) width1)));
label_241:
        num3 = 251;
        points[2].Y = checked ((int) Math.Round(unchecked ((double) a - 0.0477 * (double) num4)));
label_242:
        num3 = 252;
        points[3].X = checked ((int) Math.Round(unchecked (0.992 * (double) width1)));
label_243:
        num3 = 253;
        points[3].Y = checked ((int) Math.Round(unchecked ((double) a + 0.0477 * (double) num4)));
label_244:
        num3 = 254;
        points[4].X = checked ((int) Math.Round(unchecked (0.887 * (double) width1)));
label_245:
        num3 = (int) byte.MaxValue;
        points[4].Y = checked ((int) Math.Round(unchecked ((double) a + 0.0477 * (double) num4)));
label_246:
        num3 = 256;
        graphics2.FillPolygon(brush, points);
label_247:
        num3 = 257;
        if (!Operators.ConditionalCompareObjectGreater(obj, (object) 99, false))
          goto label_250;
label_248:
        num3 = 258;
        num5 = 1150;
label_249:
        num3 = 259;
        num6 = 105;
        goto label_253;
label_250:
        num3 = 261;
        num5 = checked ((int) Math.Round(unchecked (0.894 * (double) width1)));
label_251:
        num3 = 262;
        num6 = checked ((int) Math.Round(unchecked ((double) a - (double) graphics2.MeasureString("G", font1, 500).Height / 2.1)));
label_252:
label_253:
        num3 = 264;
        path.AddString(Conversion.Str(RuntimeHelpers.GetObjectValue(obj)), font1.FontFamily, 1, 84f, new Point(num5, num6), StringFormat.GenericTypographic);
label_254:
        num3 = 265;
        graphics2.FillPath(Brushes.White, path);
label_255:
        num3 = 266;
        graphics2.DrawPath(pen2, path);
label_256:
        num3 = 267;
label_257:
        graphics2 = (Graphics) null;
label_258:
        image1 = image1;
        goto label_264;
label_260:
        num2 = num3;
        switch (num1 > -2 ? num1 : 1)
        {
          case 1:
            int num8 = num2 + 1;
            num2 = 0;
            switch (num8)
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
                goto label_10;
              case 10:
                goto label_11;
              case 11:
                goto label_12;
              case 12:
                goto label_13;
              case 13:
                goto label_14;
              case 14:
                goto label_15;
              case 15:
                goto label_16;
              case 16:
                goto label_17;
              case 17:
                goto label_18;
              case 18:
                goto label_19;
              case 19:
                goto label_20;
              case 20:
                goto label_21;
              case 21:
                goto label_22;
              case 22:
                goto label_23;
              case 23:
                goto label_24;
              case 24:
                goto label_25;
              case 25:
                goto label_26;
              case 26:
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
                goto label_32;
              case 32:
                goto label_33;
              case 33:
                goto label_34;
              case 34:
                goto label_35;
              case 35:
                goto label_36;
              case 36:
                goto label_37;
              case 37:
                goto label_38;
              case 38:
                goto label_39;
              case 39:
                goto label_40;
              case 40:
              case 51:
                goto label_51;
              case 41:
                goto label_41;
              case 42:
                goto label_42;
              case 43:
                goto label_43;
              case 44:
                goto label_44;
              case 45:
                goto label_45;
              case 46:
                goto label_46;
              case 47:
                goto label_47;
              case 48:
                goto label_48;
              case 49:
                goto label_49;
              case 50:
                goto label_50;
              case 52:
                goto label_52;
              case 53:
                goto label_53;
              case 54:
                goto label_54;
              case 55:
                goto label_55;
              case 56:
                goto label_56;
              case 57:
                goto label_57;
              case 58:
                goto label_58;
              case 59:
                goto label_59;
              case 60:
                goto label_60;
              case 61:
                goto label_61;
              case 62:
                goto label_62;
              case 63:
                goto label_63;
              case 64:
                goto label_64;
              case 65:
                goto label_65;
              case 66:
                goto label_66;
              case 67:
                goto label_67;
              case 68:
                goto label_68;
              case 69:
                goto label_69;
              case 70:
                goto label_70;
              case 71:
                goto label_71;
              case 72:
                goto label_72;
              case 73:
                goto label_73;
              case 74:
                goto label_74;
              case 75:
                goto label_75;
              case 76:
                goto label_76;
              case 77:
                goto label_77;
              case 78:
                goto label_78;
              case 79:
                goto label_79;
              case 80:
                goto label_80;
              case 81:
                goto label_81;
              case 82:
                goto label_82;
              case 83:
                goto label_83;
              case 84:
                goto label_84;
              case 85:
                goto label_85;
              case 86:
                goto label_86;
              case 87:
                goto label_87;
              case 88:
                goto label_88;
              case 89:
                goto label_89;
              case 90:
                goto label_90;
              case 91:
                goto label_91;
              case 92:
                goto label_92;
              case 93:
                goto label_93;
              case 94:
                goto label_94;
              case 95:
                goto label_95;
              case 96:
                goto label_96;
              case 97:
                goto label_97;
              case 98:
                goto label_98;
              case 99:
                goto label_99;
              case 100:
                goto label_100;
              case 101:
                goto label_101;
              case 102:
                goto label_102;
              case 103:
                goto label_103;
              case 104:
                goto label_104;
              case 105:
                goto label_105;
              case 106:
                goto label_106;
              case 107:
                goto label_107;
              case 108:
                goto label_108;
              case 109:
                goto label_109;
              case 110:
                goto label_110;
              case 111:
                goto label_111;
              case 112:
                goto label_112;
              case 113:
                goto label_113;
              case 114:
                goto label_114;
              case 115:
                goto label_115;
              case 116:
                goto label_116;
              case 117:
                goto label_117;
              case 118:
                goto label_118;
              case 119:
                goto label_119;
              case 120:
                goto label_120;
              case 121:
                goto label_121;
              case 122:
                goto label_122;
              case 123:
                goto label_123;
              case 124:
                goto label_124;
              case 125:
                goto label_125;
              case 126:
                goto label_126;
              case (int) sbyte.MaxValue:
                goto label_127;
              case 128:
                goto label_128;
              case 129:
                goto label_129;
              case 130:
                goto label_130;
              case 131:
                goto label_131;
              case 132:
                goto label_132;
              case 133:
                goto label_133;
              case 134:
                goto label_134;
              case 135:
                goto label_135;
              case 136:
                goto label_136;
              case 137:
                goto label_137;
              case 138:
                goto label_138;
              case 139:
                goto label_139;
              case 140:
                goto label_140;
              case 141:
                goto label_141;
              case 142:
                goto label_142;
              case 143:
                goto label_143;
              case 144:
                goto label_144;
              case 145:
                goto label_145;
              case 146:
                goto label_146;
              case 147:
                goto label_147;
              case 148:
                goto label_148;
              case 149:
                goto label_149;
              case 150:
                goto label_150;
              case 151:
                goto label_151;
              case 152:
                goto label_152;
              case 153:
                goto label_153;
              case 154:
                goto label_154;
              case 155:
                goto label_155;
              case 156:
                goto label_156;
              case 157:
                goto label_157;
              case 158:
                goto label_158;
              case 159:
                goto label_159;
              case 160:
                goto label_160;
              case 161:
                goto label_161;
              case 162:
                goto label_162;
              case 163:
              case 186:
                goto label_183;
              case 164:
                goto label_163;
              case 165:
                goto label_164;
              case 166:
                goto label_165;
              case 167:
                goto label_166;
              case 168:
                goto label_167;
              case 169:
              case 174:
                goto label_172;
              case 170:
                goto label_168;
              case 171:
                goto label_169;
              case 172:
                goto label_170;
              case 173:
                goto label_171;
              case 175:
                goto label_173;
              case 176:
                goto label_174;
              case 177:
                goto label_175;
              case 178:
                goto label_176;
              case 179:
                goto label_177;
              case 180:
                goto label_178;
              case 181:
                goto label_179;
              case 182:
              case 185:
                goto label_182;
              case 183:
                goto label_180;
              case 184:
                goto label_181;
              case 187:
                goto label_184;
              case 188:
                goto label_185;
              case 189:
                goto label_186;
              case 190:
                goto label_187;
              case 191:
                goto label_188;
              case 192:
                goto label_189;
              case 193:
                goto label_190;
              case 194:
                goto label_191;
              case 195:
                goto label_194;
              case 196:
                goto label_192;
              case 197:
                goto label_193;
              case 198:
                goto label_195;
              case 199:
              case 205:
              case 211:
              case 217:
              case 223:
              case 229:
              case 235:
                goto label_231;
              case 200:
                goto label_196;
              case 201:
                goto label_197;
              case 202:
                goto label_198;
              case 203:
                goto label_199;
              case 204:
                goto label_200;
              case 206:
                goto label_201;
              case 207:
                goto label_202;
              case 208:
                goto label_203;
              case 209:
                goto label_204;
              case 210:
                goto label_205;
              case 212:
                goto label_206;
              case 213:
                goto label_207;
              case 214:
                goto label_208;
              case 215:
                goto label_209;
              case 216:
                goto label_210;
              case 218:
                goto label_211;
              case 219:
                goto label_212;
              case 220:
                goto label_213;
              case 221:
                goto label_214;
              case 222:
                goto label_215;
              case 224:
                goto label_216;
              case 225:
                goto label_217;
              case 226:
                goto label_218;
              case 227:
                goto label_219;
              case 228:
                goto label_220;
              case 230:
                goto label_221;
              case 231:
                goto label_222;
              case 232:
                goto label_223;
              case 233:
                goto label_224;
              case 234:
                goto label_225;
              case 236:
                goto label_226;
              case 237:
                goto label_227;
              case 238:
                goto label_228;
              case 239:
                goto label_229;
              case 240:
                goto label_230;
              case 241:
                goto label_232;
              case 242:
                goto label_233;
              case 243:
              case 246:
                goto label_236;
              case 244:
                goto label_234;
              case 245:
                goto label_235;
              case 247:
                goto label_237;
              case 248:
                goto label_238;
              case 249:
                goto label_239;
              case 250:
                goto label_240;
              case 251:
                goto label_241;
              case 252:
                goto label_242;
              case 253:
                goto label_243;
              case 254:
                goto label_244;
              case (int) byte.MaxValue:
                goto label_245;
              case 256:
                goto label_246;
              case 257:
                goto label_247;
              case 258:
                goto label_248;
              case 259:
                goto label_249;
              case 260:
              case 264:
                goto label_253;
              case 261:
                goto label_250;
              case 262:
                goto label_251;
              case 263:
                goto label_252;
              case 265:
                goto label_254;
              case 266:
                goto label_255;
              case 267:
                goto label_256;
              case 268:
                goto label_257;
              case 269:
                goto label_258;
              case 270:
                goto label_264;
            }
            break;
        }
      }
      catch (Exception ex) when (ex is Exception & (uint) num1 > 0U & num2 == 0)
      {
        ProjectData.SetProjectError(ex);
        goto label_260;
      }
      throw ProjectData.CreateProjectError(-2146828237);
label_264:
      if (num2 != 0)
        ProjectData.ClearProjectError();
      return image1;
    }

    public static Image DrawEnergyGraphPredicated(int Country, int House)
    {
      int num1;
      Image image1;
      int num2;
      try
      {
label_2:
        ProjectData.ClearProjectError();
        num1 = -2;
label_3:
        int num3 = 2;
        int width1 = 1344;
label_4:
        num3 = 3;
        int num4 = 1088;
label_5:
        num3 = 4;
        Font font1 = new Font("Arial", 24f, FontStyle.Regular);
label_6:
        num3 = 5;
        image1 = (Image) new Bitmap(width1, num4);
label_7:
        num3 = 6;
        Graphics graphics1 = Graphics.FromImage(image1);
label_8:
        num3 = 7;
        Font font2 = new Font("Arial", 64f, FontStyle.Bold);
label_9:
        num3 = 8;
        Font font3 = new Font("Arial", 56f, FontStyle.Bold);
label_10:
        num3 = 9;
        Font font4 = new Font("Arial", 36f, FontStyle.Regular);
label_11:
        num3 = 10;
        Font font5 = new Font("Arial", 32f, FontStyle.Bold);
label_12:
        num3 = 11;
        Font font6 = new Font("Arial", 28f, FontStyle.Italic);
label_13:
        num3 = 12;
        Font font7 = new Font("Arial", 28f, FontStyle.Bold);
label_14:
        num3 = 13;
        Pen pen1 = (Pen) Pens.Black.Clone();
label_15:
        num3 = 14;
        pen1.Width = 5f;
label_16:
        num3 = 15;
        Pen pen2 = (Pen) Pens.Black.Clone();
label_17:
        num3 = 16;
        pen2.Width = 3f;
label_18:
        num3 = 17;
        Pen pen3 = new Pen(Color.Black, 2f);
label_19:
        num3 = 18;
        Graphics graphics2 = graphics1;
label_20:
        num3 = 19;
        graphics2.TextRenderingHint = TextRenderingHint.AntiAlias;
label_21:
        num3 = 20;
        graphics2.SmoothingMode = SmoothingMode.AntiAlias;
label_22:
        num3 = 21;
        graphics1.FillRectangle(Brushes.White, 0, 0, width1, num4);
label_23:
        num3 = 22;
        graphics2.DrawLine(pen1, 1, 1, checked (width1 - 1), 1);
label_24:
        num3 = 23;
        graphics2.DrawLine(pen1, checked (width1 - 1), 1, checked (width1 - 1), checked (num4 - 1));
label_25:
        num3 = 24;
        graphics2.DrawLine(pen1, checked (width1 - 1), checked (num4 - 1), 1, checked (num4 - 1));
label_26:
        num3 = 25;
        graphics2.DrawLine(pen1, 1, checked (num4 - 1), 1, 1);
label_27:
        num3 = 26;
        int num5 = checked ((int) Math.Round(unchecked (0.688 * (double) width1)));
label_28:
        num3 = 27;
        int num6 = checked ((int) Math.Round(unchecked (0.885 * (double) num4)));
label_29:
        num3 = 28;
        num5 = checked ((int) Math.Round(unchecked (0.845 * (double) width1)));
label_30:
        num3 = 29;
        graphics2.DrawLine(pen1, num5, num6, num5, 1);
label_31:
        num3 = 30;
        if (!(Country == 2 & Operators.CompareString(SAP_Module.Proj.Dwellings[House].EPCLanguage, "Welsh", false) == 0))
          goto label_41;
label_32:
        num3 = 31;
        num5 = checked ((int) Math.Round(unchecked (0.766 * (double) width1 - (double) graphics2.MeasureString("Cyfredol", font5, 500).Width / 2.0)));
label_33:
        num3 = 32;
        num6 = checked ((int) Math.Round(unchecked (0.2 * (double) font5.GetHeight())));
label_34:
        num3 = 33;
        graphics2.DrawString("", font5, Brushes.Black, (float) num5, (float) num6);
label_35:
        num3 = 34;
        num5 = checked ((int) Math.Round(unchecked (0.921 * (double) width1 - (double) graphics2.MeasureString("Potensial", font5, 500).Width / 2.0)));
label_36:
        num3 = 35;
        num6 = checked ((int) Math.Round(unchecked (0.2 * (double) font5.GetHeight())));
label_37:
        num3 = 36;
        graphics2.DrawString("", font5, Brushes.Black, (float) num5, (float) num6);
label_38:
        num3 = 37;
        num5 = checked ((int) Math.Round(unchecked (0.02 * (double) width1)));
label_39:
        num3 = 38;
        num6 = checked ((int) Math.Round(unchecked (1.6 * (double) font5.GetHeight())));
label_40:
        num3 = 39;
        graphics2.DrawString("Effeithlon iawn o ran ynni – costau rhedeg is", font6, Brushes.Black, (float) num5, (float) num6);
        goto label_51;
label_41:
        num3 = 41;
        num5 = checked ((int) Math.Round(unchecked (0.766 * (double) width1 - (double) graphics2.MeasureString("Current", font5, 500).Width / 2.0)));
label_42:
        num3 = 42;
        num6 = checked ((int) Math.Round(unchecked (0.2 * (double) font5.GetHeight())));
label_43:
        num3 = 43;
        graphics2.DrawString("", font5, Brushes.Black, (float) num5, (float) num6);
label_44:
        num3 = 44;
        num5 = checked ((int) Math.Round(unchecked (0.921 * (double) width1 - (double) graphics2.MeasureString("Potential", font5, 500).Width / 2.0)));
label_45:
        num3 = 45;
        num6 = checked ((int) Math.Round(unchecked (0.2 * (double) font5.GetHeight())));
label_46:
        num3 = 46;
        graphics2.DrawString("", font5, Brushes.Black, (float) num5, (float) num6);
label_47:
        num3 = 47;
        num5 = checked ((int) Math.Round(unchecked (0.02 * (double) width1)));
label_48:
        num3 = 48;
        num6 = checked ((int) Math.Round(unchecked (1.6 * (double) font5.GetHeight())));
label_49:
        num3 = 49;
        graphics2.DrawString("Very energy efficient - lower running costs", font6, Brushes.Black, (float) num5, (float) num6);
label_50:
label_51:
        num3 = 51;
        num6 = checked ((int) Math.Round(unchecked (0.063 * (double) num4)));
label_52:
        num3 = 52;
        graphics2.DrawLine(pen1, 1, num6, checked (width1 - 1), num6);
label_53:
        num3 = 53;
        Brush brush = (Brush) new SolidBrush(Color.FromArgb(0, (int) sbyte.MaxValue, 61));
label_54:
        num3 = 54;
        num5 = checked ((int) Math.Round(unchecked (0.01 * (double) width1)));
label_55:
        num3 = 55;
        num6 = checked ((int) Math.Round(unchecked (0.127 * (double) num4)));
label_56:
        num3 = 56;
        int width2 = checked ((int) Math.Round(unchecked (0.221 * (double) width1)));
label_57:
        num3 = 57;
        int height = checked ((int) Math.Round(unchecked (0.086585 * (double) num4)));
label_58:
        num3 = 58;
        graphics2.FillRectangle(brush, num5, num6, width2, height);
label_59:
        num3 = 59;
        num6 = checked ((int) Math.Round(unchecked ((double) num6 + (double) height / 2.0 - (double) graphics2.MeasureString("()", font7, 500).Height / 2.0)));
label_60:
        num3 = 60;
        num5 = checked ((int) Math.Round(unchecked (0.025 * (double) width1)));
label_61:
        num3 = 61;
        graphics2.DrawString("(92 plus)", font7, Brushes.White, (float) num5, (float) num6);
label_62:
        num3 = 62;
        num5 = checked ((int) Math.Round(unchecked (0.158 * (double) width1)));
label_63:
        num3 = 63;
        num6 = checked ((int) Math.Round(unchecked (0.127 * (double) num4 + (double) height / 2.0 - (double) graphics2.MeasureString("A", font2, 900).Height / 2.1)));
label_64:
        num3 = 64;
        GraphicsPath path = new GraphicsPath();
label_65:
        num3 = 65;
        path.AddString("A", font2.FontFamily, 1, 84f, new Point(num5, num6), StringFormat.GenericTypographic);
label_66:
        num3 = 66;
        graphics2.FillPath(Brushes.White, path);
label_67:
        num3 = 67;
        graphics2.DrawPath(pen2, path);
label_68:
        num3 = 68;
        num5 = checked ((int) Math.Round(unchecked (0.01 * (double) width1)));
label_69:
        num3 = 69;
        brush = (Brush) new SolidBrush(Color.FromArgb(44, 159, 41));
label_70:
        num3 = 70;
        num6 = checked ((int) Math.Round(unchecked (0.227 * (double) num4)));
label_71:
        num3 = 71;
        width2 = checked ((int) Math.Round(unchecked (0.295 * (double) width1)));
label_72:
        num3 = 72;
        graphics2.FillRectangle(brush, num5, num6, width2, height);
label_73:
        num3 = 73;
        num6 = checked ((int) Math.Round(unchecked ((double) num6 + (double) height / 2.0 - (double) graphics2.MeasureString("()", font7, 900).Height / 2.0)));
label_74:
        num3 = 74;
        num5 = checked ((int) Math.Round(unchecked (0.025 * (double) width1)));
label_75:
        num3 = 75;
        graphics2.DrawString("(81-91)", font7, Brushes.White, (float) num5, (float) num6);
label_76:
        num3 = 76;
        num5 = checked ((int) Math.Round(unchecked (0.239 * (double) width1)));
label_77:
        num3 = 77;
        num6 = checked ((int) Math.Round(unchecked (0.227 * (double) num4 + (double) height / 2.0 - (double) graphics2.MeasureString("B", font2, 500).Height / 2.1)));
label_78:
        num3 = 78;
        path.AddString("B", font2.FontFamily, 1, 84f, new Point(num5, num6), StringFormat.GenericTypographic);
label_79:
        num3 = 79;
        graphics2.FillPath(Brushes.White, path);
label_80:
        num3 = 80;
        graphics2.DrawPath(pen2, path);
label_81:
        num3 = 81;
        num5 = checked ((int) Math.Round(unchecked (0.01 * (double) width1)));
label_82:
        num3 = 82;
        brush = (Brush) new SolidBrush(Color.FromArgb(157, 203, 60));
label_83:
        num3 = 83;
        num6 = checked ((int) Math.Round(unchecked (0.327 * (double) num4)));
label_84:
        num3 = 84;
        width2 = checked ((int) Math.Round(unchecked (0.37 * (double) width1)));
label_85:
        num3 = 85;
        graphics2.FillRectangle(brush, num5, num6, width2, height);
label_86:
        num3 = 86;
        num6 = checked ((int) Math.Round(unchecked ((double) num6 + (double) height / 2.0 - (double) graphics2.MeasureString("()", font7, 900).Height / 2.0)));
label_87:
        num3 = 87;
        num5 = checked ((int) Math.Round(unchecked (0.025 * (double) width1)));
label_88:
        num3 = 88;
        graphics2.DrawString("(69-80)", font7, Brushes.Black, (float) num5, (float) num6);
label_89:
        num3 = 89;
        num5 = checked ((int) Math.Round(unchecked (0.307 * (double) width1)));
label_90:
        num3 = 90;
        num6 = checked ((int) Math.Round(unchecked (0.327 * (double) num4 + (double) height / 2.0 - (double) graphics2.MeasureString("C", font2, 500).Height / 2.1)));
label_91:
        num3 = 91;
        path.AddString("C", font2.FontFamily, 1, 84f, new Point(num5, num6), StringFormat.GenericTypographic);
label_92:
        num3 = 92;
        graphics2.FillPath(Brushes.White, path);
label_93:
        num3 = 93;
        graphics2.DrawPath(pen2, path);
label_94:
        num3 = 94;
        num5 = checked ((int) Math.Round(unchecked (0.01 * (double) width1)));
label_95:
        num3 = 95;
        brush = (Brush) new SolidBrush(Color.FromArgb((int) byte.MaxValue, 242, 0));
label_96:
        num3 = 96;
        num6 = checked ((int) Math.Round(unchecked (0.427 * (double) num4)));
label_97:
        num3 = 97;
        width2 = checked ((int) Math.Round(unchecked (0.445 * (double) width1)));
label_98:
        num3 = 98;
        graphics2.FillRectangle(brush, num5, num6, width2, height);
label_99:
        num3 = 99;
        num6 = checked ((int) Math.Round(unchecked ((double) num6 + (double) height / 2.0 - (double) graphics2.MeasureString("()", font7, 900).Height / 2.0)));
label_100:
        num3 = 100;
        num5 = checked ((int) Math.Round(unchecked (0.025 * (double) width1)));
label_101:
        num3 = 101;
        graphics2.DrawString("(55-68)", font7, Brushes.Black, (float) num5, (float) num6);
label_102:
        num3 = 102;
        num5 = checked ((int) Math.Round(unchecked (0.387 * (double) width1)));
label_103:
        num3 = 103;
        num6 = checked ((int) Math.Round(unchecked (0.427 * (double) num4 + (double) height / 2.0 - (double) graphics2.MeasureString("D", font2, 500).Height / 2.1)));
label_104:
        num3 = 104;
        path.AddString("D", font2.FontFamily, 1, 84f, new Point(num5, num6), StringFormat.GenericTypographic);
label_105:
        num3 = 105;
        graphics2.FillPath(Brushes.White, path);
label_106:
        num3 = 106;
        graphics2.DrawPath(pen2, path);
label_107:
        num3 = 107;
        num5 = checked ((int) Math.Round(unchecked (0.01 * (double) width1)));
label_108:
        num3 = 108;
        brush = (Brush) new SolidBrush(Color.FromArgb(247, 175, 29));
label_109:
        num3 = 109;
        num6 = checked ((int) Math.Round(unchecked (0.527 * (double) num4)));
label_110:
        num3 = 110;
        width2 = checked ((int) Math.Round(unchecked (0.518 * (double) width1)));
label_111:
        num3 = 111;
        graphics2.FillRectangle(brush, num5, num6, width2, height);
label_112:
        num3 = 112;
        num6 = checked ((int) Math.Round(unchecked ((double) num6 + (double) height / 2.0 - (double) graphics2.MeasureString("()", font7, 900).Height / 2.0)));
label_113:
        num3 = 113;
        num5 = checked ((int) Math.Round(unchecked (0.025 * (double) width1)));
label_114:
        num3 = 114;
        graphics2.DrawString("(39-54)", font7, Brushes.Black, (float) num5, (float) num6);
label_115:
        num3 = 115;
        num5 = checked ((int) Math.Round(unchecked (0.459 * (double) width1)));
label_116:
        num3 = 116;
        num6 = checked ((int) Math.Round(unchecked (0.527 * (double) num4 + (double) height / 2.0 - (double) graphics2.MeasureString("E", font2, 500).Height / 2.1)));
label_117:
        num3 = 117;
        path.AddString("E", font2.FontFamily, 1, 84f, new Point(num5, num6), StringFormat.GenericTypographic);
label_118:
        num3 = 118;
        graphics2.FillPath(Brushes.White, path);
label_119:
        num3 = 119;
        graphics2.DrawPath(pen2, path);
label_120:
        num3 = 120;
        num5 = checked ((int) Math.Round(unchecked (0.01 * (double) width1)));
label_121:
        num3 = 121;
        brush = (Brush) new SolidBrush(Color.FromArgb(237, 104, 35));
label_122:
        num3 = 122;
        num6 = checked ((int) Math.Round(unchecked (0.627 * (double) num4)));
label_123:
        num3 = 123;
        width2 = checked ((int) Math.Round(unchecked (0.592 * (double) width1)));
label_124:
        num3 = 124;
        graphics2.FillRectangle(brush, num5, num6, width2, height);
label_125:
        num3 = 125;
        num6 = checked ((int) Math.Round(unchecked ((double) num6 + (double) height / 2.0 - (double) graphics2.MeasureString("()", font7, 900).Height / 2.0)));
label_126:
        num3 = 126;
        num5 = checked ((int) Math.Round(unchecked (0.025 * (double) width1)));
label_127:
        num3 = (int) sbyte.MaxValue;
        graphics2.DrawString("(21-38)", font7, Brushes.Black, (float) num5, (float) num6);
label_128:
        num3 = 128;
        num5 = checked ((int) Math.Round(unchecked (0.536 * (double) width1)));
label_129:
        num3 = 129;
        num6 = checked ((int) Math.Round(unchecked (0.627 * (double) num4 + (double) height / 2.0 - (double) graphics2.MeasureString("F", font2, 500).Height / 2.1)));
label_130:
        num3 = 130;
        path.AddString("F", font2.FontFamily, 1, 84f, new Point(num5, num6), StringFormat.GenericTypographic);
label_131:
        num3 = 131;
        graphics2.FillPath(Brushes.White, path);
label_132:
        num3 = 132;
        graphics2.DrawPath(pen2, path);
label_133:
        num3 = 133;
        num5 = checked ((int) Math.Round(unchecked (0.01 * (double) width1)));
label_134:
        num3 = 134;
        brush = (Brush) new SolidBrush(Color.FromArgb(227, 29, 35));
label_135:
        num3 = 135;
        num6 = checked ((int) Math.Round(unchecked (0.727 * (double) num4)));
label_136:
        num3 = 136;
        width2 = checked ((int) Math.Round(unchecked (0.668 * (double) width1)));
label_137:
        num3 = 137;
        graphics2.FillRectangle(brush, num5, num6, width2, height);
label_138:
        num3 = 138;
        num6 = checked ((int) Math.Round(unchecked ((double) num6 + (double) height / 2.0 - (double) graphics2.MeasureString("()", font7, 900).Height / 2.0)));
label_139:
        num3 = 139;
        num5 = checked ((int) Math.Round(unchecked (0.025 * (double) width1)));
label_140:
        num3 = 140;
        graphics2.DrawString("(1-20)", font7, Brushes.Black, (float) num5, (float) num6);
label_141:
        num3 = 141;
        num5 = checked ((int) Math.Round(unchecked (0.607 * (double) width1)));
label_142:
        num3 = 142;
        num6 = checked ((int) Math.Round(unchecked (0.727 * (double) num4 + (double) height / 2.0 - (double) graphics2.MeasureString("G", font2, 500).Height / 2.1)));
label_143:
        num3 = 143;
        path.AddString("G", font2.FontFamily, 1, 84f, new Point(num5, num6), StringFormat.GenericTypographic);
label_144:
        num3 = 144;
        graphics2.FillPath(Brushes.White, path);
label_145:
        num3 = 145;
        graphics2.DrawPath(pen2, path);
label_146:
        num3 = 146;
        num5 = checked ((int) Math.Round(unchecked (0.01 * (double) width1)));
label_147:
        num3 = 147;
        num6 = checked ((int) Math.Round(unchecked (0.885 * (double) num4)));
label_148:
        num3 = 148;
        graphics2.DrawLine(pen1, 1, num6, checked (width1 - 1), num6);
label_149:
        num3 = 149;
        num6 = checked ((int) Math.Round(unchecked ((0.885 * (double) num4 - (0.727 * (double) num4 + 0.086585 * (double) num4)) / 2.0 + (0.727 * (double) num4 + 0.086585 * (double) num4) - (double) graphics2.MeasureString("Potential", font6, 500).Height / 2.0)));
label_150:
        num3 = 150;
        num5 = checked ((int) Math.Round(unchecked (0.02 * (double) width1)));
label_151:
        num3 = 151;
        if (!(Country == 2 & Operators.CompareString(SAP_Module.Proj.Dwellings[House].EPCLanguage, "Welsh", false) == 0))
          goto label_163;
label_152:
        num3 = 152;
        graphics2.DrawString("Ddim yn effeithlon o ran ynni – costau rhedeg uwch", font6, Brushes.Black, (float) num5, (float) num6);
label_153:
        num3 = 153;
        num6 = checked ((int) Math.Round(unchecked (23.0 / 400.0 * (double) num4 + 0.885 * (double) num4 - 0.5 * (double) graphics2.MeasureString("Cymru a Lloegr", font3, 900).Height)));
label_154:
        num3 = 154;
        num5 = checked ((int) Math.Round(unchecked (0.025 * (double) width1)));
label_155:
        num3 = 155;
        graphics2.DrawString("Cymru a Lloegr", font3, Brushes.Black, (float) num5, (float) num6);
label_156:
        num3 = 156;
        num6 = checked ((int) Math.Round(unchecked (23.0 / 400.0 * (double) num4 + 0.885 * (double) num4 - (double) graphics2.MeasureString("Cyfarwyddeb 2002/91/EC", font1, 500).Height)));
label_157:
        num3 = 157;
        num5 = checked ((int) Math.Round(unchecked (0.59 * (double) width1)));
label_158:
        num3 = 158;
        graphics2.DrawString("Cyfarwyddeb 2002/91/EC", font1, Brushes.Black, (float) num5, (float) num6);
label_159:
        num3 = 159;
        num6 = checked ((int) Math.Round(unchecked (23.0 / 400.0 * (double) num4 + 0.885 * (double) num4)));
label_160:
        num3 = 160;
        num5 = checked ((int) Math.Round(unchecked (0.63 * (double) width1)));
label_161:
        num3 = 161;
        graphics2.DrawString("yr Undeb Ewropeaidd", font1, Brushes.Black, (float) num5, (float) num6);
label_162:
        num3 = 162;
        num6 = checked ((int) Math.Round(unchecked (23.0 / 400.0 * (double) num4 + 0.885 * (double) num4 - 0.52 * (double) graphics2.MeasureString("Cymru a Lloegr", font3, 900).Height)));
        goto label_183;
label_163:
        num3 = 164;
        graphics2.DrawString("Not energy efficient - higher running costs", font6, Brushes.Black, (float) num5, (float) num6);
label_164:
        num3 = 165;
        if (Operators.CompareString(SAP_Module.Proj.Dwellings[House].Address.Country, "Scotland", false) != 0)
          goto label_168;
label_165:
        num3 = 166;
        num6 = checked ((int) Math.Round(unchecked (23.0 / 400.0 * (double) num4 + 0.885 * (double) num4 - 0.5 * (double) graphics2.MeasureString("Scotland", font3, 900).Height)));
label_166:
        num3 = 167;
        num5 = checked ((int) Math.Round(unchecked (0.025 * (double) width1)));
label_167:
        num3 = 168;
        graphics2.DrawString("Scotland", font3, Brushes.Black, (float) num5, (float) num6);
        goto label_172;
label_168:
        num3 = 170;
        num6 = checked ((int) Math.Round(unchecked (23.0 / 400.0 * (double) num4 + 0.885 * (double) num4 - 0.5 * (double) graphics2.MeasureString("England & Wales", font3, 900).Height)));
label_169:
        num3 = 171;
        num5 = checked ((int) Math.Round(unchecked (0.025 * (double) width1)));
label_170:
        num3 = 172;
        graphics2.DrawString("England & Wales", font3, Brushes.Black, (float) num5, (float) num6);
label_171:
label_172:
        num3 = 174;
        num6 = checked ((int) Math.Round(unchecked (23.0 / 400.0 * (double) num4 + 0.885 * (double) num4 - (double) graphics2.MeasureString("EU Directive", font4, 500).Height)));
label_173:
        num3 = 175;
        num5 = checked ((int) Math.Round(unchecked (0.66 * (double) width1)));
label_174:
        num3 = 176;
        graphics2.DrawString("EU Directive", font4, Brushes.Black, (float) num5, (float) num6);
label_175:
        num3 = 177;
        num6 = checked ((int) Math.Round(unchecked (23.0 / 400.0 * (double) num4 + 0.885 * (double) num4)));
label_176:
        num3 = 178;
        num5 = checked ((int) Math.Round(unchecked (0.66 * (double) width1)));
label_177:
        num3 = 179;
        graphics2.DrawString("2002/91/EC", font4, Brushes.Black, (float) num5, (float) num6);
label_178:
        num3 = 180;
        if (Operators.CompareString(SAP_Module.Proj.Dwellings[House].Address.Country, "Scotland", false) != 0)
          goto label_180;
label_179:
        num3 = 181;
        num6 = checked ((int) Math.Round(unchecked (23.0 / 400.0 * (double) num4 + 0.885 * (double) num4 - 0.52 * (double) graphics2.MeasureString("Scotland", font3, 900).Height)));
        goto label_182;
label_180:
        num3 = 183;
        num6 = checked ((int) Math.Round(unchecked (23.0 / 400.0 * (double) num4 + 0.885 * (double) num4 - 0.52 * (double) graphics2.MeasureString("England & Wales", font3, 900).Height)));
label_181:
label_182:
label_183:
        num3 = 186;
        num5 = checked ((int) Math.Round(unchecked (0.88 * (double) width1)));
label_184:
        num3 = 187;
        Image image2 = Image.FromFile(Application.StartupPath + "\\Resources\\EU.bmp");
label_185:
        num3 = 188;
        width2 = checked ((int) Math.Round(unchecked ((double) image2.Width / 2.75)));
label_186:
        num3 = 189;
        height = checked ((int) Math.Round(unchecked ((double) image2.Height / 2.75)));
label_187:
        num3 = 190;
        graphics2.DrawImage(image2, num5, num6, width2, height);
label_188:
        num3 = 191;
        Point[] points = new Point[5];
label_189:
        num3 = 192;
label_190:
        num3 = 193;
        if (SAP_Module.Calculation2012.Calculation.SAP_rating_11a.SAPRating != 0.0)
          goto label_192;
label_191:
        num3 = 194;
        object sapRating = (object) SAP_Module.Calculation2012.Calculation.SAP_rating_11b.SAPRating;
        goto label_194;
label_192:
        num3 = 196;
        sapRating = (object) SAP_Module.Calculation2012.Calculation.SAP_rating_11a.SAPRating;
label_193:
label_194:
label_195:
        num3 = 198;
        object Left1 = sapRating;
label_196:
        num3 = 200;
        if (!Conversions.ToBoolean((object) (bool) (!Conversions.ToBoolean(Operators.CompareObjectGreaterEqual(Left1, (object) 1, false)) ? 0 : (Conversions.ToBoolean(Operators.CompareObjectLessEqual(Left1, (object) 20, false)) ? 1 : 0))))
          goto label_201;
label_197:
        num3 = 201;
        float Left2 = 0.727f;
label_198:
        num3 = 202;
        float Left3 = 20f;
label_199:
        num3 = 203;
        float num7 = 1f;
label_200:
        num3 = 204;
        brush = (Brush) new SolidBrush(Color.FromArgb(227, 29, 35));
        goto label_231;
label_201:
        num3 = 206;
        if (!Conversions.ToBoolean((object) (bool) (!Conversions.ToBoolean(Operators.CompareObjectGreaterEqual(Left1, (object) 21, false)) ? 0 : (Conversions.ToBoolean(Operators.CompareObjectLessEqual(Left1, (object) 38, false)) ? 1 : 0))))
          goto label_206;
label_202:
        num3 = 207;
        Left2 = 0.627f;
label_203:
        num3 = 208;
        Left3 = 38f;
label_204:
        num3 = 209;
        num7 = 21f;
label_205:
        num3 = 210;
        brush = (Brush) new SolidBrush(Color.FromArgb(237, 104, 35));
        goto label_231;
label_206:
        num3 = 212;
        if (!Conversions.ToBoolean((object) (bool) (!Conversions.ToBoolean(Operators.CompareObjectGreaterEqual(Left1, (object) 39, false)) ? 0 : (Conversions.ToBoolean(Operators.CompareObjectLessEqual(Left1, (object) 54, false)) ? 1 : 0))))
          goto label_211;
label_207:
        num3 = 213;
        Left2 = 0.527f;
label_208:
        num3 = 214;
        Left3 = 54f;
label_209:
        num3 = 215;
        num7 = 39f;
label_210:
        num3 = 216;
        brush = (Brush) new SolidBrush(Color.FromArgb(247, 175, 29));
        goto label_231;
label_211:
        num3 = 218;
        if (!Conversions.ToBoolean((object) (bool) (!Conversions.ToBoolean(Operators.CompareObjectGreaterEqual(Left1, (object) 55, false)) ? 0 : (Conversions.ToBoolean(Operators.CompareObjectLessEqual(Left1, (object) 68, false)) ? 1 : 0))))
          goto label_216;
label_212:
        num3 = 219;
        Left2 = 0.427f;
label_213:
        num3 = 220;
        Left3 = 68f;
label_214:
        num3 = 221;
        num7 = 55f;
label_215:
        num3 = 222;
        brush = (Brush) new SolidBrush(Color.FromArgb((int) byte.MaxValue, 242, 0));
        goto label_231;
label_216:
        num3 = 224;
        if (!Conversions.ToBoolean((object) (bool) (!Conversions.ToBoolean(Operators.CompareObjectGreaterEqual(Left1, (object) 69, false)) ? 0 : (Conversions.ToBoolean(Operators.CompareObjectLessEqual(Left1, (object) 80, false)) ? 1 : 0))))
          goto label_221;
label_217:
        num3 = 225;
        Left2 = 0.327f;
label_218:
        num3 = 226;
        Left3 = 80f;
label_219:
        num3 = 227;
        num7 = 69f;
label_220:
        num3 = 228;
        brush = (Brush) new SolidBrush(Color.FromArgb(157, 203, 60));
        goto label_231;
label_221:
        num3 = 230;
        if (!Conversions.ToBoolean((object) (bool) (!Conversions.ToBoolean(Operators.CompareObjectGreaterEqual(Left1, (object) 81, false)) ? 0 : (Conversions.ToBoolean(Operators.CompareObjectLessEqual(Left1, (object) 91, false)) ? 1 : 0))))
          goto label_226;
label_222:
        num3 = 231;
        Left2 = 0.227f;
label_223:
        num3 = 232;
        Left3 = 91f;
label_224:
        num3 = 233;
        num7 = 81f;
label_225:
        num3 = 234;
        brush = (Brush) new SolidBrush(Color.FromArgb(44, 159, 41));
        goto label_231;
label_226:
        num3 = 236;
        if (!Operators.ConditionalCompareObjectGreaterEqual(Left1, (object) 92, false))
          goto label_231;
label_227:
        num3 = 237;
        Left2 = 0.127f;
label_228:
        num3 = 238;
        Left3 = 100f;
label_229:
        num3 = 239;
        num7 = 92f;
label_230:
        num3 = 240;
        brush = (Brush) new SolidBrush(Color.FromArgb(0, (int) sbyte.MaxValue, 61));
label_231:
label_232:
        num3 = 241;
        if (!Operators.ConditionalCompareObjectGreater(sapRating, (object) 99, false))
          goto label_234;
label_233:
        num3 = 242;
        float a = (Left2 + (float) (0.086585 * ((double) Left3 - 98.0) / ((double) Left3 - (double) num7))) * (float) num4;
        goto label_236;
label_234:
        num3 = 244;
        a = Conversions.ToSingle(Operators.MultiplyObject(Operators.AddObject((object) Left2, Operators.DivideObject(Operators.MultiplyObject((object) 0.086585, Operators.SubtractObject((object) Left3, sapRating)), (object) (float) ((double) Left3 - (double) num7))), (object) num4));
label_235:
label_236:
        num3 = 246;
        points[0].X = checked ((int) Math.Round(unchecked (0.853 * (double) width1)));
label_237:
        num3 = 247;
        points[0].Y = checked ((int) Math.Round((double) a));
label_238:
        num3 = 248;
        points[1].X = checked ((int) Math.Round(unchecked (0.887 * (double) width1)));
label_239:
        num3 = 249;
        points[1].Y = checked ((int) Math.Round(unchecked ((double) a - 0.0477 * (double) num4)));
label_240:
        num3 = 250;
        points[2].X = checked ((int) Math.Round(unchecked (0.992 * (double) width1)));
label_241:
        num3 = 251;
        points[2].Y = checked ((int) Math.Round(unchecked ((double) a - 0.0477 * (double) num4)));
label_242:
        num3 = 252;
        points[3].X = checked ((int) Math.Round(unchecked (0.992 * (double) width1)));
label_243:
        num3 = 253;
        points[3].Y = checked ((int) Math.Round(unchecked ((double) a + 0.0477 * (double) num4)));
label_244:
        num3 = 254;
        points[4].X = checked ((int) Math.Round(unchecked (0.887 * (double) width1)));
label_245:
        num3 = (int) byte.MaxValue;
        points[4].Y = checked ((int) Math.Round(unchecked ((double) a + 0.0477 * (double) num4)));
label_246:
        num3 = 256;
        graphics2.FillPolygon(brush, points);
label_247:
        num3 = 257;
        if (!Operators.ConditionalCompareObjectGreater(sapRating, (object) 99, false))
          goto label_250;
label_248:
        num3 = 258;
        num5 = 1150;
label_249:
        num3 = 259;
        num6 = 105;
        goto label_253;
label_250:
        num3 = 261;
        num5 = checked ((int) Math.Round(unchecked (0.894 * (double) width1)));
label_251:
        num3 = 262;
        num6 = checked ((int) Math.Round(unchecked ((double) a - (double) graphics2.MeasureString("G", font2, 500).Height / 2.1)));
label_252:
label_253:
        num3 = 264;
        path.AddString(Conversion.Str(RuntimeHelpers.GetObjectValue(sapRating)), font2.FontFamily, 1, 84f, new Point(num5, num6), StringFormat.GenericTypographic);
label_254:
        num3 = 265;
        graphics2.FillPath(Brushes.White, path);
label_255:
        num3 = 266;
        graphics2.DrawPath(pen2, path);
label_256:
        graphics2 = (Graphics) null;
label_257:
        image1 = image1;
        goto label_263;
label_259:
        num2 = num3;
        switch (num1 > -2 ? num1 : 1)
        {
          case 1:
            int num8 = num2 + 1;
            num2 = 0;
            switch (num8)
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
                goto label_10;
              case 10:
                goto label_11;
              case 11:
                goto label_12;
              case 12:
                goto label_13;
              case 13:
                goto label_14;
              case 14:
                goto label_15;
              case 15:
                goto label_16;
              case 16:
                goto label_17;
              case 17:
                goto label_18;
              case 18:
                goto label_19;
              case 19:
                goto label_20;
              case 20:
                goto label_21;
              case 21:
                goto label_22;
              case 22:
                goto label_23;
              case 23:
                goto label_24;
              case 24:
                goto label_25;
              case 25:
                goto label_26;
              case 26:
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
                goto label_32;
              case 32:
                goto label_33;
              case 33:
                goto label_34;
              case 34:
                goto label_35;
              case 35:
                goto label_36;
              case 36:
                goto label_37;
              case 37:
                goto label_38;
              case 38:
                goto label_39;
              case 39:
                goto label_40;
              case 40:
              case 51:
                goto label_51;
              case 41:
                goto label_41;
              case 42:
                goto label_42;
              case 43:
                goto label_43;
              case 44:
                goto label_44;
              case 45:
                goto label_45;
              case 46:
                goto label_46;
              case 47:
                goto label_47;
              case 48:
                goto label_48;
              case 49:
                goto label_49;
              case 50:
                goto label_50;
              case 52:
                goto label_52;
              case 53:
                goto label_53;
              case 54:
                goto label_54;
              case 55:
                goto label_55;
              case 56:
                goto label_56;
              case 57:
                goto label_57;
              case 58:
                goto label_58;
              case 59:
                goto label_59;
              case 60:
                goto label_60;
              case 61:
                goto label_61;
              case 62:
                goto label_62;
              case 63:
                goto label_63;
              case 64:
                goto label_64;
              case 65:
                goto label_65;
              case 66:
                goto label_66;
              case 67:
                goto label_67;
              case 68:
                goto label_68;
              case 69:
                goto label_69;
              case 70:
                goto label_70;
              case 71:
                goto label_71;
              case 72:
                goto label_72;
              case 73:
                goto label_73;
              case 74:
                goto label_74;
              case 75:
                goto label_75;
              case 76:
                goto label_76;
              case 77:
                goto label_77;
              case 78:
                goto label_78;
              case 79:
                goto label_79;
              case 80:
                goto label_80;
              case 81:
                goto label_81;
              case 82:
                goto label_82;
              case 83:
                goto label_83;
              case 84:
                goto label_84;
              case 85:
                goto label_85;
              case 86:
                goto label_86;
              case 87:
                goto label_87;
              case 88:
                goto label_88;
              case 89:
                goto label_89;
              case 90:
                goto label_90;
              case 91:
                goto label_91;
              case 92:
                goto label_92;
              case 93:
                goto label_93;
              case 94:
                goto label_94;
              case 95:
                goto label_95;
              case 96:
                goto label_96;
              case 97:
                goto label_97;
              case 98:
                goto label_98;
              case 99:
                goto label_99;
              case 100:
                goto label_100;
              case 101:
                goto label_101;
              case 102:
                goto label_102;
              case 103:
                goto label_103;
              case 104:
                goto label_104;
              case 105:
                goto label_105;
              case 106:
                goto label_106;
              case 107:
                goto label_107;
              case 108:
                goto label_108;
              case 109:
                goto label_109;
              case 110:
                goto label_110;
              case 111:
                goto label_111;
              case 112:
                goto label_112;
              case 113:
                goto label_113;
              case 114:
                goto label_114;
              case 115:
                goto label_115;
              case 116:
                goto label_116;
              case 117:
                goto label_117;
              case 118:
                goto label_118;
              case 119:
                goto label_119;
              case 120:
                goto label_120;
              case 121:
                goto label_121;
              case 122:
                goto label_122;
              case 123:
                goto label_123;
              case 124:
                goto label_124;
              case 125:
                goto label_125;
              case 126:
                goto label_126;
              case (int) sbyte.MaxValue:
                goto label_127;
              case 128:
                goto label_128;
              case 129:
                goto label_129;
              case 130:
                goto label_130;
              case 131:
                goto label_131;
              case 132:
                goto label_132;
              case 133:
                goto label_133;
              case 134:
                goto label_134;
              case 135:
                goto label_135;
              case 136:
                goto label_136;
              case 137:
                goto label_137;
              case 138:
                goto label_138;
              case 139:
                goto label_139;
              case 140:
                goto label_140;
              case 141:
                goto label_141;
              case 142:
                goto label_142;
              case 143:
                goto label_143;
              case 144:
                goto label_144;
              case 145:
                goto label_145;
              case 146:
                goto label_146;
              case 147:
                goto label_147;
              case 148:
                goto label_148;
              case 149:
                goto label_149;
              case 150:
                goto label_150;
              case 151:
                goto label_151;
              case 152:
                goto label_152;
              case 153:
                goto label_153;
              case 154:
                goto label_154;
              case 155:
                goto label_155;
              case 156:
                goto label_156;
              case 157:
                goto label_157;
              case 158:
                goto label_158;
              case 159:
                goto label_159;
              case 160:
                goto label_160;
              case 161:
                goto label_161;
              case 162:
                goto label_162;
              case 163:
              case 186:
                goto label_183;
              case 164:
                goto label_163;
              case 165:
                goto label_164;
              case 166:
                goto label_165;
              case 167:
                goto label_166;
              case 168:
                goto label_167;
              case 169:
              case 174:
                goto label_172;
              case 170:
                goto label_168;
              case 171:
                goto label_169;
              case 172:
                goto label_170;
              case 173:
                goto label_171;
              case 175:
                goto label_173;
              case 176:
                goto label_174;
              case 177:
                goto label_175;
              case 178:
                goto label_176;
              case 179:
                goto label_177;
              case 180:
                goto label_178;
              case 181:
                goto label_179;
              case 182:
              case 185:
                goto label_182;
              case 183:
                goto label_180;
              case 184:
                goto label_181;
              case 187:
                goto label_184;
              case 188:
                goto label_185;
              case 189:
                goto label_186;
              case 190:
                goto label_187;
              case 191:
                goto label_188;
              case 192:
                goto label_189;
              case 193:
                goto label_190;
              case 194:
                goto label_191;
              case 195:
                goto label_194;
              case 196:
                goto label_192;
              case 197:
                goto label_193;
              case 198:
                goto label_195;
              case 199:
              case 205:
              case 211:
              case 217:
              case 223:
              case 229:
              case 235:
                goto label_231;
              case 200:
                goto label_196;
              case 201:
                goto label_197;
              case 202:
                goto label_198;
              case 203:
                goto label_199;
              case 204:
                goto label_200;
              case 206:
                goto label_201;
              case 207:
                goto label_202;
              case 208:
                goto label_203;
              case 209:
                goto label_204;
              case 210:
                goto label_205;
              case 212:
                goto label_206;
              case 213:
                goto label_207;
              case 214:
                goto label_208;
              case 215:
                goto label_209;
              case 216:
                goto label_210;
              case 218:
                goto label_211;
              case 219:
                goto label_212;
              case 220:
                goto label_213;
              case 221:
                goto label_214;
              case 222:
                goto label_215;
              case 224:
                goto label_216;
              case 225:
                goto label_217;
              case 226:
                goto label_218;
              case 227:
                goto label_219;
              case 228:
                goto label_220;
              case 230:
                goto label_221;
              case 231:
                goto label_222;
              case 232:
                goto label_223;
              case 233:
                goto label_224;
              case 234:
                goto label_225;
              case 236:
                goto label_226;
              case 237:
                goto label_227;
              case 238:
                goto label_228;
              case 239:
                goto label_229;
              case 240:
                goto label_230;
              case 241:
                goto label_232;
              case 242:
                goto label_233;
              case 243:
              case 246:
                goto label_236;
              case 244:
                goto label_234;
              case 245:
                goto label_235;
              case 247:
                goto label_237;
              case 248:
                goto label_238;
              case 249:
                goto label_239;
              case 250:
                goto label_240;
              case 251:
                goto label_241;
              case 252:
                goto label_242;
              case 253:
                goto label_243;
              case 254:
                goto label_244;
              case (int) byte.MaxValue:
                goto label_245;
              case 256:
                goto label_246;
              case 257:
                goto label_247;
              case 258:
                goto label_248;
              case 259:
                goto label_249;
              case 260:
              case 264:
                goto label_253;
              case 261:
                goto label_250;
              case 262:
                goto label_251;
              case 263:
                goto label_252;
              case 265:
                goto label_254;
              case 266:
                goto label_255;
              case 267:
                goto label_256;
              case 268:
                goto label_257;
              case 269:
                goto label_263;
            }
            break;
        }
      }
      catch (Exception ex) when (ex is Exception & (uint) num1 > 0U & num2 == 0)
      {
        ProjectData.SetProjectError(ex);
        goto label_259;
      }
      throw ProjectData.CreateProjectError(-2146828237);
label_263:
      if (num2 != 0)
        ProjectData.ClearProjectError();
      return image1;
    }

    public static string CheckWalesDwellingType(string DwelType)
    {
      if ((uint) Operators.CompareString(DwelType, "", false) > 0U)
      {
        string Left = Strings.UCase(DwelType);
        if (Operators.CompareString(Left, Strings.UCase("Detached house"), false) == 0)
          DwelType = "Tŷ ar wahân";
        else if (Operators.CompareString(Left, Strings.UCase("Semi-detached house"), false) == 0)
          DwelType = "Tŷ pâr";
        else if (Operators.CompareString(Left, Strings.UCase("Mid-terrace house"), false) == 0)
          DwelType = "Tŷ canol teras";
        else if (Operators.CompareString(Left, Strings.UCase("End-terrace house"), false) == 0)
          DwelType = "Tŷ pen teras";
        else if (Operators.CompareString(Left, Strings.UCase("Detached bungalow"), false) == 0)
          DwelType = "Byngalo ar wahân";
        else if (Operators.CompareString(Left, Strings.UCase("Semi-detached bumgalow"), false) == 0)
          DwelType = "Byngalo pâr";
        else if (Operators.CompareString(Left, Strings.UCase("Mid-terrace bungalow"), false) == 0)
          DwelType = "Byngalo canol teras";
        else if (Operators.CompareString(Left, Strings.UCase("End-terrace house"), false) == 0)
          DwelType = "Byngalo pen teras";
        else if (Operators.CompareString(Left, Strings.UCase("Top-floor flat"), false) == 0)
          DwelType = "Fflat llawr uchaf";
        else if (Operators.CompareString(Left, Strings.UCase("Mid-floor flat"), false) == 0)
          DwelType = "Fflat llawr canol";
        else if (Operators.CompareString(Left, Strings.UCase("Ground-floor flat"), false) == 0)
          DwelType = "Fflat llawr isaf";
        else if (Operators.CompareString(Left, Strings.UCase("Top-floor maisonette"), false) == 0)
          DwelType = "Fflat deulawr llawr uchaf";
        else if (Operators.CompareString(Left, Strings.UCase("Mid-floor maisonette"), false) == 0)
          DwelType = "Fflat deulawr llawr canol";
        else if (Operators.CompareString(Left, Strings.UCase("Ground-floor maisonette"), false) == 0)
          DwelType = Strings.UCase("Fflat deulawr llawr isaf");
        else if (Operators.CompareString(Left, Strings.UCase("Ground-floor maisonette"), false) == 0)
          DwelType = Strings.UCase("Fflat deulawr llawr isaf");
        else if (Operators.CompareString(Left, Strings.UCase("Park home"), false) == 0)
          DwelType = "Cartref mewn parc";
      }
      return DwelType;
    }

    public static string CheckWalesRPD(string RPD)
    {
      string str1 = "";
      if (Operators.CompareString(RPD, "", false) == 0)
        str1 = "Dim parti perthnasol";
      string str2 = RPD;
      // ISSUE: reference to a compiler-generated method
      switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(str2))
      {
        case 699887717:
          if (Operators.CompareString(str2, "Employed by the professional dealing with the property transaction", false) == 0)
          {
            str1 = "Wedi’i gyflogi gan y person proffesiynol sy’n delio â’r trafodyn eiddo";
            goto default;
          }
          else
            goto default;
        case 906552670:
          if (Operators.CompareString(str2, "Relative of the professional dealing with the property transaction", false) == 0)
          {
            str1 = "Perthynas i’r person proffesiynol sy’n delio â’r trafodyn eiddo";
            goto default;
          }
          else
            goto default;
        case 2325797555:
          if (Operators.CompareString(str2, "Financial interest in the property", false) == 0)
            break;
          goto default;
        case 2392311570:
          if (Operators.CompareString(str2, "Relative of homeowner or occupier of the property", false) == 0)
          {
            str1 = "Perthynas i berchennog y cartref neu ddeiliad yr eiddo";
            goto default;
          }
          else
            goto default;
        case 2457169943:
          if (Operators.CompareString(str2, "Residing at the property", false) == 0)
            break;
          goto default;
        case 3407112949:
          if (Operators.CompareString(str2, "No related party", false) == 0)
          {
            str1 = "Dim parti perthnasol";
            goto default;
          }
          else
            goto default;
        case 3560267305:
          if (Operators.CompareString(str2, "Owner or Director of the organisation dealing with the property transaction", false) == 0)
          {
            str1 = "Perchennog neu Gyfarwyddwr y corff sy’n delio â’r trafodyn eiddo";
            goto default;
          }
          else
            goto default;
        default:
label_16:
          return str1;
      }
      str1 = "Yn byw yn yr eiddo";
      goto label_16;
    }

    public static string BandCheckWall(double Value, string Type)
    {
      string str = "";
      if (Operators.CompareString(Type, "XML", false) == 0)
      {
        if (Value < 0.3)
          str = Conversions.ToString(5);
        else if (Value >= 0.3 & Value <= 0.6)
          str = Conversions.ToString(4);
        else if (Value >= 0.61 & Value <= 1.0)
          str = Conversions.ToString(3);
        else if (Value >= 1.01 & Value < 1.6)
          str = Conversions.ToString(2);
        else if (Value >= 1.6)
          str = Conversions.ToString(1);
      }
      else if (Value < 0.3)
        str = "★★★★★";
      else if (Value >= 0.3 & Value <= 0.6)
        str = "★★★★☆";
      else if (Value >= 0.61 & Value <= 1.0)
        str = "★★★☆☆";
      else if (Value >= 1.01 & Value <= 1.6)
        str = "★★☆☆☆";
      else if (Value >= 1.6)
        str = "★☆☆☆☆";
      return str;
    }

    public static string BandCheckRoof(double Value, string Type)
    {
      string str = "";
      if (Operators.CompareString(Type, "XML", false) == 0)
      {
        if (Value < 0.15)
          str = Conversions.ToString(5);
        else if (Value >= 0.15 & Value <= 0.3)
          str = Conversions.ToString(4);
        else if (Value >= 0.31 & Value <= 0.5)
          str = Conversions.ToString(3);
        else if (Value >= 0.51 & Value <= 1.0)
          str = Conversions.ToString(2);
        else if (Value > 1.0)
          str = Conversions.ToString(1);
      }
      else if (Value < 0.15)
        str = "★★★★★";
      else if (Value >= 0.15 & Value <= 0.3)
        str = "★★★★☆";
      else if (Value >= 0.31 & Value <= 0.5)
        str = "★★★☆☆";
      else if (Value >= 0.51 & Value <= 1.0)
        str = "★★☆☆☆";
      else if (Value > 1.0)
        str = "★☆☆☆☆";
      return str;
    }

    public static string BandCheckFloor(double Value, string Type)
    {
      string str = "";
      if (Operators.CompareString(Type, "XML", false) == 0)
      {
        if (Value <= 0.2)
          str = Conversions.ToString(5);
        else if (Value >= 0.21 & Value <= 0.3)
          str = Conversions.ToString(4);
        else if (Value >= 0.31 & Value <= 0.45)
          str = Conversions.ToString(3);
        else if (Value >= 0.46 & Value <= 0.7)
          str = Conversions.ToString(2);
        else if (Value > 0.7)
          str = Conversions.ToString(1);
      }
      else if (Value <= 0.2)
        str = "★★★★★";
      else if (Value >= 0.21 & Value <= 0.3)
        str = "★★★★☆";
      else if (Value >= 0.31 & Value <= 0.45)
        str = "★★★☆☆";
      else if (Value >= 0.46 & Value <= 0.7)
        str = "★★☆☆☆";
      else if (Value > 0.7)
        str = "★☆☆☆☆";
      return str;
    }

    public static string BandCheckWindows(double Value, string Type)
    {
      string str = "";
      if (Operators.CompareString(Type, "XML", false) == 0)
      {
        if (Value <= 1.7)
          str = Conversions.ToString(5);
        else if (Value > 1.7 & Value < 2.5)
          str = Conversions.ToString(4);
        else if (Value >= 2.5 & Value <= 3.3)
          str = Conversions.ToString(3);
        else if (Value >= 3.3 & Value < 4.4)
          str = Conversions.ToString(2);
        else if (Value >= 4.4)
          str = Conversions.ToString(1);
      }
      else if (Value <= 1.7)
        str = "★★★★★";
      else if (Value > 1.7 & Value < 2.5)
        str = "★★★★☆";
      else if (Value >= 2.5 & Value < 3.3)
        str = "★★★☆☆";
      else if (Value >= 3.3 & Value < 4.4)
        str = "★★☆☆☆";
      else if (Value >= 4.4)
        str = "★☆☆☆☆";
      return str;
    }

    public static string BandCheckLighting(double Value, string Type)
    {
      string str = "";
      if (Operators.CompareString(Type, "XML", false) == 0)
        str = Value <= 69.0 ? (!(Value >= 45.0 & Value <= 69.0) ? (!(Value >= 25.0 & Value <= 44.0) ? (!(Value >= 10.0 & Value < 24.0) ? (Value <= 9.0 ? Conversions.ToString(1) : Conversions.ToString(1)) : Conversions.ToString(2)) : Conversions.ToString(3)) : Conversions.ToString(4)) : Conversions.ToString(5);
      else if (Value > 69.0)
        str = "★★★★★";
      else if (Value >= 45.0 & Value <= 69.0)
        str = "★★★★☆";
      else if (Value >= 25.0 & Value <= 44.0)
        str = "★★★☆☆";
      else if (Value >= 10.0 & Value <= 24.0)
        str = "★★☆☆☆";
      else if (Value > 9.0)
        str = "★☆☆☆☆";
      return str;
    }

    public static string BandCheckAirPressure(double Value, string Type) => Operators.CompareString(Type, "XML", false) == 0 ? (Value >= 3.0 ? (!(Value >= 3.0 & Value < 7.0) ? (!(Value >= 7.0 & Value <= 13.0) ? (!(Value >= 13.0 & Value < 20.0) ? (Value <= 20.0 ? "-" : Conversions.ToString(1)) : Conversions.ToString(2)) : Conversions.ToString(3)) : Conversions.ToString(4)) : Conversions.ToString(5)) : (Value >= 3.0 ? (!(Value >= 3.0 & Value < 7.0) ? (!(Value >= 7.0 & Value < 13.0) ? (!(Value >= 13.0 & Value < 20.0) ? (Value < 20.0 ? "★☆☆☆☆" : "★☆☆☆☆") : "★★☆☆☆") : "★★★☆☆") : "★★★★☆") : "★★★★★");

    public static string CheckFuel(object FuelType)
    {
      object Left = FuelType;
      return !Conversions.ToBoolean((object) (bool) (Conversions.ToBoolean(Operators.CompareObjectEqual(Left, (object) "mains gas", false)) ? 1 : (Conversions.ToBoolean(Operators.CompareObjectEqual(Left, (object) "heat from boilers – mains gas", false)) ? 1 : 0))) ? (!Conversions.ToBoolean((object) (bool) (Conversions.ToBoolean(Operators.CompareObjectEqual(Left, (object) "bulk LPG", false)) ? 1 : (Conversions.ToBoolean(Operators.CompareObjectEqual(Left, (object) "heat from boilers – LPG", false)) ? 1 : 0))) ? (!Operators.ConditionalCompareObjectEqual(Left, (object) "bottled LPG", false) ? (!Conversions.ToBoolean((object) (bool) (Conversions.ToBoolean(Operators.CompareObjectEqual(Left, (object) "heating oil", false)) ? 1 : (Conversions.ToBoolean(Operators.CompareObjectEqual(Left, (object) "heat from boilers – oil", false)) ? 1 : 0))) ? (!Conversions.ToBoolean((object) (bool) (Conversions.ToBoolean(Operators.CompareObjectEqual(Left, (object) "house coal", false)) ? 1 : (Conversions.ToBoolean(Operators.CompareObjectEqual(Left, (object) "heat from boilers – coal", false)) ? 1 : 0))) ? (!Operators.ConditionalCompareObjectEqual(Left, (object) "manufactured smokeless fuel", false) ? (!Operators.ConditionalCompareObjectEqual(Left, (object) "anthracite", false) ? (!Operators.ConditionalCompareObjectEqual(Left, (object) "smokeless fuel", false) ? (!Operators.ConditionalCompareObjectEqual(Left, (object) "wood logs", false) ? (!Operators.ConditionalCompareObjectEqual(Left, (object) "secondary wood pellets", false) ? (!Conversions.ToBoolean((object) (bool) (Conversions.ToBoolean(Operators.CompareObjectEqual(Left, (object) "main wood pellets", false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(Left, (object) "wood pellets (bulk supply in bags, for main heating)", false)) ? 1 : (Conversions.ToBoolean(Operators.CompareObjectEqual(Left, (object) "wood pellets (in bags, for secondary heating)", false)) ? 1 : 0))) ? (!Operators.ConditionalCompareObjectEqual(Left, (object) "wood chips", false) ? (!Conversions.ToBoolean((object) (bool) (Conversions.ToBoolean(Operators.CompareObjectEqual(Left, (object) "dual fuel appliance", false)) ? 1 : (Conversions.ToBoolean(Operators.CompareObjectEqual(Left, (object) "dual fuel appliance (mineral and wood)", false)) ? 1 : 0))) ? (!Operators.ConditionalCompareObjectEqual(Left, (object) "standard tariff", false) ? (!Operators.ConditionalCompareObjectEqual(Left, (object) "7-hour tariff (on-peak)", false) ? (!Operators.ConditionalCompareObjectEqual(Left, (object) "7-hour tariff (off-peak)", false) ? (!Operators.ConditionalCompareObjectEqual(Left, (object) "community heat from boilers", false) ? (!Operators.ConditionalCompareObjectEqual(Left, (object) "10-hour tariff (on-peak)", false) ? (!Operators.ConditionalCompareObjectEqual(Left, (object) "10-hour tariff (off-peak)", false) ? (!Conversions.ToBoolean((object) (bool) (Conversions.ToBoolean(Operators.CompareObjectEqual(Left, (object) "CommCHP", false)) ? 1 : (Conversions.ToBoolean(Operators.CompareObjectEqual(Left, (object) "heat from CHP", false)) ? 1 : 0))) ? (!Operators.ConditionalCompareObjectEqual(Left, (object) "Elec Sold", false) ? (!Operators.ConditionalCompareObjectEqual(Left, (object) "Electricity", false) ? (!Operators.ConditionalCompareObjectEqual(Left, (object) "heat from boilers – B30D", false) ? (!Operators.ConditionalCompareObjectEqual(Left, (object) "heat from electric heat pump", false) ? (!Operators.ConditionalCompareObjectEqual(Left, (object) "heat from boilers - waste combustion", false) ? (!Conversions.ToBoolean((object) (bool) (Conversions.ToBoolean(Operators.CompareObjectEqual(Left, (object) "heat from boilers – biomass", false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(Left, (object) "biomass", false)) ? 1 : (Conversions.ToBoolean(Operators.CompareObjectEqual(Left, (object) "Biomass", false)) ? 1 : 0))) ? (!Conversions.ToBoolean((object) (bool) (Conversions.ToBoolean(Operators.CompareObjectEqual(Left, (object) "heat from boilers – biogas", false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(Left, (object) "Biogas", false)) ? 1 : (Conversions.ToBoolean(Operators.CompareObjectEqual(Left, (object) "biogas", false)) ? 1 : 0))) ? (!Operators.ConditionalCompareObjectEqual(Left, (object) "waste heat from power stations", false) ? (!Conversions.ToBoolean((object) (bool) (Conversions.ToBoolean(Operators.CompareObjectEqual(Left, (object) "geothermal heat source", false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(Left, (object) "geothermal", false)) ? 1 : (Conversions.ToBoolean(Operators.CompareObjectEqual(Left, (object) "Geothermal", false)) ? 1 : 0))) ? (!Operators.ConditionalCompareObjectEqual(Left, (object) "biodiesel from used cooking oil only", false) ? (!Operators.ConditionalCompareObjectEqual(Left, (object) "bioethanol from any biomass source", false) ? Conversions.ToString(FuelType) : "bioethanol") : "liquid biofuel") : "Geothermal") : "Power stations") : "Biogas") : "Biomass") : " Waste combustion") : "Heat pump") : "B30D") : "electric") : "Elec Sold") : "CommCHP") : "10-hour tariff (off-peak)") : "") : "community heat from boilers") : "7-hour tariff (off-peak)") : "7-hour tariff (on-peak)") : "standard tariff") : "dual fuel (mineral and wood)") : "wood chips") : "wood pellets") : "secondary wood pellets") : "wood logs") : "smokeless fuel") : "anthracite") : "smokeless fuel") : "coal") : "oil") : "LPG") : "LPG") : "mains gas";
    }

    public static string CheckSecHeating_Heading(string Value)
    {
      string str = Value;
      string Left;
      // ISSUE: reference to a compiler-generated method
      switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(str))
      {
        case 10240320:
          if (Operators.CompareString(str, "Gas, twin burner with permanent pilot 1998 or later", false) == 0)
          {
            Left = "Gas range cooker";
            break;
          }
          goto default;
        case 639522663:
          if (Operators.CompareString(str, "Electric instantaneous at point of use", false) == 0)
          {
            Left = "Electric instantaneous at point of use";
            break;
          }
          goto default;
        case 721851191:
          if (Operators.CompareString(str, "Multi-point gas water heater (instantaneous serving several taps)", false) == 0)
          {
            Left = "Gas multipoint";
            break;
          }
          goto default;
        case 771469176:
          if (Operators.CompareString(str, "Gas, single burner with permanent pilot", false) == 0)
          {
            Left = "Gas range cooker";
            break;
          }
          goto default;
        case 808210941:
          if (Operators.CompareString(str, "Oil boiler/circulator for water heating only", false) == 0)
          {
            Left = "Oil boiler/circulator";
            break;
          }
          goto default;
        case 1031085205:
          if (Operators.CompareString(str, "From main heating system", false) == 0)
          {
            Left = "From main system";
            break;
          }
          goto default;
        case 1039678467:
          if (Operators.CompareString(str, "Oil, twin burner pre 1998", false) == 0)
          {
            Left = "Oil range cooker";
            break;
          }
          goto default;
        case 1154460860:
          if (Operators.CompareString(str, "Solid fuel boiler/circulator for water heating only", false) == 0)
          {
            Left = "Solid fuel boiler/circulator";
            break;
          }
          goto default;
        case 1188278447:
          if (Operators.CompareString(str, "Oil, single burner", false) == 0)
          {
            Left = "Oil range cooker";
            break;
          }
          goto default;
        case 1296521401:
          if (Operators.CompareString(str, "From hot-water only community scheme - heat pump", false) == 0)
          {
            Left = "Community heat pump";
            break;
          }
          goto default;
        case 1506560706:
          if (Operators.CompareString(str, "Solid fuel, independent oven and boiler", false) == 0)
          {
            Left = "Solid fuel range cooker";
            break;
          }
          goto default;
        case 1778997715:
          if (Operators.CompareString(str, "Electric immersion (on-peak or off-peak)", false) == 0)
          {
            Left = "Electric immersion (on-peak or off-peak)";
            break;
          }
          goto default;
        case 2377616826:
          if (Operators.CompareString(str, "Gas, twin burner with permanent pilot pre 1998", false) == 0)
          {
            Left = "Gas range cooker";
            break;
          }
          goto default;
        case 2510839178:
          if (Operators.CompareString(str, "Gas boiler/circulator for water heating only", false) == 0)
          {
            Left = "Gas boiler/circulator";
            break;
          }
          goto default;
        case 2532913708:
          if (Operators.CompareString(str, "From main heating system, plus solar", false) == 0)
          {
            Left = "From main system, plus solar";
            break;
          }
          goto default;
        case 2897911596:
          if (Operators.CompareString(str, "Gas, twin burner with automatic ignition pre 1998", false) == 0)
          {
            Left = "Gas range cooker";
            break;
          }
          goto default;
        case 2971016520:
          if (Operators.CompareString(str, "From hot-water only community scheme - CHP", false) == 0)
          {
            Left = "Community scheme with CHP";
            break;
          }
          goto default;
        case 3000784926:
          if (Operators.CompareString(str, "Gas, twin burner with automatic ignition 1998 or later", false) == 0)
          {
            Left = "Gas range cooker";
            break;
          }
          goto default;
        case 3001996050:
          if (Operators.CompareString(str, "Range cooker with boiler for water heating only:", false) == 0)
          {
            Left = "Gas range cooker";
            break;
          }
          goto default;
        case 3021515149:
          if (Operators.CompareString(str, "Single-point gas water heater (instantaneous at point of use)", false) == 0)
          {
            Left = "Gas instantaneous at point of use";
            break;
          }
          goto default;
        case 3041984996:
          if (Operators.CompareString(str, "Solid fuel, integral oven and boiler", false) == 0)
          {
            Left = "Solid fuel range cooker";
            break;
          }
          goto default;
        case 3615518320:
          if (Operators.CompareString(str, "From secondary system", false) == 0)
          {
            Left = "From secondary system";
            break;
          }
          goto default;
        case 3778589111:
          if (Operators.CompareString(str, "Oil, twin burner 1998 or later", false) == 0)
          {
            Left = "Oil range cooker";
            break;
          }
          goto default;
        case 3881227630:
          if (Operators.CompareString(str, "Gas, single burner with automatic ignition", false) == 0)
          {
            Left = "Gas range cooker";
            break;
          }
          goto default;
        case 4125689229:
          if (Operators.CompareString(str, "From hot-water only community scheme - CHP, plus solar", false) == 0)
          {
            Left = "Cynllun cymunedol, gydag ynni’r haul";
            break;
          }
          goto default;
        case 4172192267:
          if (Operators.CompareString(str, "From hot-water only community scheme - boilers", false) == 0)
          {
            Left = "Community scheme";
            break;
          }
          goto default;
        default:
          Left = Value;
          break;
      }
      if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].IncludeMainHeating2 && Operators.CompareString(Left, "From second main heating system", false) == 0 && (double) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].HeatFractionSec < 0.5)
        Left = "From main system";
      return Left;
    }

    public static string BandCheckHeating(double Value, string Type)
    {
      string str = "";
      if (Operators.CompareString(Type, "XML", false) == 0)
        str = Value >= 3.82 ? (!(Value >= 3.82 & Value < 5.28) ? (!(Value >= 5.28 & Value < 7.41) ? (!(Value >= 7.41 & Value < 10.66) ? (Value < 10.66 ? Conversions.ToString(0) : Conversions.ToString(1)) : Conversions.ToString(2)) : Conversions.ToString(3)) : Conversions.ToString(4)) : Conversions.ToString(5);
      else if (Value < 3.82)
        str = "★★★★★";
      else if (Value >= 3.82 & Value < 5.28)
        str = "★★★★☆";
      else if (Value >= 5.28 & Value < 7.41)
        str = "★★★☆☆";
      else if (Value >= 7.41 & Value < 10.66)
        str = "★★☆☆☆";
      else if (Value >= 10.66)
        str = "★☆☆☆☆";
      return str;
    }

    public static string BandCheckHeating2(double Value, string Type)
    {
      string str = "";
      if (Operators.CompareString(Type, "XML", false) == 0)
      {
        if (Value < 0.22)
          str = Conversions.ToString(5);
        else if (Value >= 0.22 & Value < 0.33)
          str = Conversions.ToString(4);
        else if (Value >= 0.33 & Value < 0.44)
          str = Conversions.ToString(3);
        else if (Value >= 0.44 & Value < 0.55)
          str = Conversions.ToString(2);
        else if (Value >= 0.55)
          str = Conversions.ToString(1);
      }
      else if (Value < 0.22)
        str = "★★★★★";
      else if (Value >= 0.22 & Value < 0.33)
        str = "★★★★☆";
      else if (Value >= 0.33 & Value < 0.44)
        str = "★★★☆☆";
      else if (Value >= 0.44 & Value < 0.55)
        str = "★★☆☆☆";
      else if (Value >= 0.55)
        str = "★☆☆☆☆";
      return str;
    }

    public static string BandCheckHeatingWater(double Value, string Type)
    {
      string str = "";
      if (Operators.CompareString(Type, "XML", false) == 0)
      {
        if (Value <= 1.8)
          str = Conversions.ToString(5);
        else if (Value >= 1.8 & Value < 2.5)
          str = Conversions.ToString(4);
        else if (Value >= 2.5 & Value < 3.5)
          str = Conversions.ToString(3);
        else if (Value >= 7.0 / 2.0 & Value < 5.0)
          str = Conversions.ToString(2);
        else if (Value >= 5.0)
          str = Conversions.ToString(1);
      }
      else if (Value < 1.8)
        str = "★★★★★";
      else if (Value >= 1.8 & Value < 2.5)
        str = "★★★★☆";
      else if (Value >= 2.5 & Value < 3.5)
        str = "★★★☆☆";
      else if (Value >= 3.5 & Value < 5.0)
        str = "★★☆☆☆";
      else if (Value >= 5.0)
        str = "★☆☆☆☆";
      return str;
    }

    public static string BandCheckHeatingWater2(double Value, string Type)
    {
      string str = "";
      if (Operators.CompareString(Type, "XML", false) == 0)
      {
        if (Value < 0.22)
          str = Conversions.ToString(5);
        else if (Value >= 0.22 & Value < 0.3)
          str = Conversions.ToString(4);
        else if (Value >= 0.3 & Value < 0.4)
          str = Conversions.ToString(3);
        else if (Value >= 0.4 & Value < 0.5)
          str = Conversions.ToString(2);
        else if (Value >= 0.5)
          str = Conversions.ToString(1);
      }
      else if (Value < 0.22)
        str = "★★★★★";
      else if (Value >= 0.22 & Value < 0.3)
        str = "★★★★☆";
      else if (Value >= 0.3 & Value < 0.4)
        str = "★★★☆☆";
      else if (Value >= 0.4 & Value < 0.5)
        str = "★★☆☆☆";
      else if (Value >= 0.5)
        str = "★☆☆☆☆";
      return str;
    }

    public static string CheckFuelCode(string Value)
    {
      string str1 = "";
      string str2 = Value;
      // ISSUE: reference to a compiler-generated method
      switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(str2))
      {
        case 157581269:
          if (Operators.CompareString(str2, "heating oil", false) == 0)
          {
            str1 = "4";
            goto default;
          }
          else
            goto default;
        case 335024745:
          if (Operators.CompareString(str2, "heat from boilers – biogas", false) == 0)
          {
            str1 = Conversions.ToString(44);
            goto default;
          }
          else
            goto default;
        case 575487477:
          if (Operators.CompareString(str2, "wood pellets (bulk supply in bags, for main heating)", false) == 0)
          {
            str1 = Conversions.ToString(23);
            goto default;
          }
          else
            goto default;
        case 604697910:
          if (Operators.CompareString(str2, "manufactured smokeless fuel", false) == 0)
          {
            str1 = Conversions.ToString(12);
            goto default;
          }
          else
            goto default;
        case 664172296:
          if (Operators.CompareString(str2, "heat from CHP", false) == 0)
            goto label_48;
          else
            goto default;
        case 721524493:
          if (Operators.CompareString(str2, "dual fuel appliance (mineral and wood)", false) == 0)
          {
            str1 = Conversions.ToString(10);
            goto default;
          }
          else
            goto default;
        case 842919835:
          if (Operators.CompareString(str2, "heat from boilers – LPG", false) == 0)
          {
            str1 = Conversions.ToString(52);
            goto default;
          }
          else
            goto default;
        case 857289046:
          if (Operators.CompareString(str2, "house coal", false) == 0)
          {
            str1 = Conversions.ToString(11);
            goto default;
          }
          else
            goto default;
        case 975024876:
          if (Operators.CompareString(str2, "bulk LPG", false) == 0)
          {
            str1 = "2";
            goto default;
          }
          else
            goto default;
        case 1424221758:
          if (Operators.CompareString(str2, "geothermal heat source", false) == 0)
          {
            str1 = Conversions.ToString(46);
            goto default;
          }
          else
            goto default;
        case 1441345278:
          if (Operators.CompareString(str2, "Electricity", false) == 0)
          {
            str1 = Conversions.ToString(39);
            goto default;
          }
          else
            goto default;
        case 1522447619:
          if (Operators.CompareString(str2, "wood chips", false) == 0)
          {
            str1 = Conversions.ToString(21);
            goto default;
          }
          else
            goto default;
        case 1538586610:
          if (Operators.CompareString(str2, "heat from boilers – oil", false) == 0)
          {
            str1 = Conversions.ToString(53);
            goto default;
          }
          else
            goto default;
        case 1597764060:
          if (Operators.CompareString(str2, "mains gas", false) == 0)
          {
            str1 = Conversions.ToString(1);
            goto default;
          }
          else
            goto default;
        case 1860525480:
          if (Operators.CompareString(str2, "heat from electric heat pump", false) == 0)
            break;
          goto default;
        case 1880739446:
          if (Operators.CompareString(str2, "24-hour tariff", false) == 0)
            goto default;
          else
            goto default;
        case 1946790875:
          if (Operators.CompareString(str2, "wood logs", false) == 0)
          {
            str1 = Conversions.ToString(20);
            goto default;
          }
          else
            goto default;
        case 2027441019:
          if (Operators.CompareString(str2, "electricity displaced from grid", false) == 0)
          {
            str1 = Conversions.ToString(37);
            goto default;
          }
          else
            goto default;
        case 2251322125:
          if (Operators.CompareString(str2, "wood pellets (in bags, for secondary heating)", false) == 0)
          {
            str1 = Conversions.ToString(22);
            goto default;
          }
          else
            goto default;
        case 2313921600:
          if (Operators.CompareString(str2, "anthracite", false) == 0)
          {
            str1 = Conversions.ToString(15);
            goto default;
          }
          else
            goto default;
        case 2340757125:
          if (Operators.CompareString(str2, "heat from boilers - waste combustion", false) == 0)
          {
            str1 = Conversions.ToString(42);
            goto default;
          }
          else
            goto default;
        case 2343415715:
          if (Operators.CompareString(str2, "waste heat from power stations", false) == 0)
          {
            str1 = Conversions.ToString(45);
            goto default;
          }
          else
            goto default;
        case 2442528761:
          if (Operators.CompareString(str2, "heat from heat pump", false) == 0)
            break;
          goto default;
        case 3048335652:
          if (Operators.CompareString(str2, "heat from boilers – B30D1", false) == 0)
          {
            str1 = Conversions.ToString(50);
            goto default;
          }
          else
            goto default;
        case 3169378617:
          if (Operators.CompareString(str2, "electricity generated by CHP", false) == 0)
          {
            str1 = Conversions.ToString(49);
            goto default;
          }
          else
            goto default;
        case 3216529428:
          if (Operators.CompareString(str2, "heat from boilers – biomass", false) == 0)
          {
            str1 = Conversions.ToString(43);
            goto default;
          }
          else
            goto default;
        case 3398809853:
          if (Operators.CompareString(str2, "heat from boilers – B30D", false) == 0)
          {
            str1 = Conversions.ToString(55);
            goto default;
          }
          else
            goto default;
        case 3722837730:
          if (Operators.CompareString(str2, "bottled LPG", false) == 0)
          {
            str1 = "3";
            goto default;
          }
          else
            goto default;
        case 4105867675:
          if (Operators.CompareString(str2, "electricity sold to grid", false) == 0)
          {
            str1 = Conversions.ToString(36);
            goto default;
          }
          else
            goto default;
        case 4241528165:
          if (Operators.CompareString(str2, "heat from boilers – mains gas", false) == 0)
            goto label_48;
          else
            goto default;
        default:
label_58:
          return str1;
      }
      str1 = Conversions.ToString(41);
      goto label_58;
label_48:
      str1 = Conversions.ToString(51);
      goto label_58;
    }

    public static string CheckWalesHeatingHeading(string Value, int country)
    {
      string Left = "";
      if (country == 2 & Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].EPCLanguage, "Welsh", false) == 0)
      {
        string str = Value;
        // ISSUE: reference to a compiler-generated method
        switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(str))
        {
          case 598889865:
            if (Operators.CompareString(str, "Community scheme", false) == 0)
            {
              Left = "Cynllun cymunedol";
              break;
            }
            break;
          case 728998576:
            if (Operators.CompareString(str, "Solar assisted source heat pump, Systems with radiators", false) == 0)
            {
              Left = "Pwmp gwres â chymorth yr haul, rheiddiaduron";
              break;
            }
            break;
          case 747495363:
            if (Operators.CompareString(str, "Ground source heat pump, underfloor", false) == 0)
            {
              Left = "Pwmp gwres sy’n tarddu yn y ddaear, dan y llawr";
              break;
            }
            break;
          case 769439016:
            if (Operators.CompareString(str, "Solar assisted source heat pump, Systems with radiators, trydan", false) == 0)
            {
              Left = "Solar assisted source heat pump, Systems with radiators, trydan";
              break;
            }
            break;
          case 932397623:
            if (Operators.CompareString(str, "Electric heat pumps", false) == 0)
            {
              Left = "dan y llawr";
              break;
            }
            break;
          case 1205250646:
            if (Operators.CompareString(str, "Community scheme with CHP", false) == 0)
            {
              Left = "Cynllun cymunedol";
              break;
            }
            break;
          case 1244195769:
            if (Operators.CompareString(str, "Boiler and underfloor heating", false) == 0)
            {
              Left = "Bwyler a gwres dan y llawr";
              break;
            }
            break;
          case 1278633908:
            if (Operators.CompareString(str, "Room heaters", false) == 0)
            {
              Left = "Gwresogyddion ystafell";
              break;
            }
            break;
          case 1370366079:
            if (Operators.CompareString(str, "Electric storage", false) == 0)
            {
              Left = "Stôr wresogyddion trydan";
              break;
            }
            break;
          case 1525246445:
            if (Operators.CompareString(str, "Community scheme utilising waste geothermal heat", false) == 0)
            {
              Left = "Cynllun cymunedol sy’n defnyddio grwes geothermol";
              break;
            }
            break;
          case 1660783301:
            if (Operators.CompareString(str, "No system present: electric heaters assumed", false) == 0)
            {
              Left = "Dim system ar gael: rhagdybir bod gwresogyddion trydan";
              break;
            }
            break;
          case 2049365597:
            if (Operators.CompareString(str, "From main system, waste water heat recovery", false) == 0)
            {
              Left = "O’r brif system, adfer gwres dŵr gwastraff";
              break;
            }
            break;
          case 2058786912:
            if (Operators.CompareString(str, "Electric underfloor heating", false) == 0)
            {
              Left = "Gwresogi dan y llawr trydan";
              break;
            }
            break;
          case 2072418714:
            if (Operators.CompareString(str, "Boiler and radiators", false) == 0)
            {
              Left = "Bwyler a rheiddiaduron";
              break;
            }
            break;
          case 2225994432:
            if (Operators.CompareString(str, "Air source heat pump", false) == 0)
            {
              Left = "Pwmp gwres sy’n tarddu yn yr awyr";
              break;
            }
            break;
          case 2258081582:
            if (Operators.CompareString(str, "Community heat pump", false) == 0)
            {
              Left = "Pwmp gwres cymunedol";
              break;
            }
            break;
          case 2306801615:
            if (Operators.CompareString(str, "Ground source heat pump", false) == 0)
            {
              Left = "Pwmp gwres sy’n tarddu yn y ddaear";
              break;
            }
            break;
          case 2533559393:
            if (Operators.CompareString(str, "Electric storage heaters", false) == 0)
            {
              Left = "Stôr wresogyddion trydan";
              break;
            }
            break;
          case 2585609250:
            if (Operators.CompareString(str, "Gwresogi dan y llawr trydan, trydan", false) == 0)
            {
              Left = "Gwresogi dan y llawr trydan";
              break;
            }
            break;
          case 2797362741:
            if (Operators.CompareString(str, "Electric storage heaters, underfloor", false) == 0)
            {
              Left = "Stôr wresogyddion";
              break;
            }
            break;
          case 2815324685:
            if (Operators.CompareString(str, "Water source heat pump", false) == 0)
            {
              Left = "Pwmp gwres sy’n tarddu mewn dŵr";
              break;
            }
            break;
          case 2953159940:
            if (Operators.CompareString(str, "Warm air heat pump", false) == 0)
            {
              Left = "Awyr gynnes ";
              break;
            }
            break;
          case 2982516237:
            if (Operators.CompareString(str, "Air source heat pump, Systems with radiators, trydan", false) == 0)
            {
              Left = "Pwmp gwres sy’n tarddu yn yr awyr, rheiddiaduron, trydan";
              break;
            }
            break;
          case 3098642162:
            if (Operators.CompareString(str, "Micro-cogeneration", false) == 0)
            {
              Left = "Meicrogydgynhyrchu";
              break;
            }
            break;
          case 3345952887:
            if (Operators.CompareString(str, "Community scheme utilising waste heat", false) == 0)
            {
              Left = "Cynllun cymunedol sy’n defnyddio grwes gwastraff";
              break;
            }
            break;
          case 3987820668:
            if (Operators.CompareString(str, "Warm air", false) == 0)
            {
              Left = "Awyr gynnes";
              break;
            }
            break;
          case 4043532678:
            if (Operators.CompareString(str, "From main system, plus solar, waste water heat recovery", false) == 0)
            {
              Left = "O’r brif system, gydag ynni’r haul, adfer gwres dŵr gwastraff";
              break;
            }
            break;
          case 4102534233:
            if (Operators.CompareString(str, "Electric ceiling", false) == 0)
            {
              Left = "Gwresogi nenfwd trydan";
              break;
            }
            break;
          case 4264858245:
            if (Operators.CompareString(str, "Air source heat pump, Systems with radiators", false) == 0)
            {
              Left = "Pwmp gwres sy’n tarddu yn yr awyr, rheiddiaduron";
              break;
            }
            break;
        }
      }
      else
        Left = Value;
      if (Operators.CompareString(Left, "", false) == 0)
        Left = Value;
      return Left;
    }

    public static string CheckWalesFuel(string FuelType)
    {
      string str1;
      if (Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].EPCLanguage, "Welsh", false) == 0)
      {
        string str2 = FuelType;
        // ISSUE: reference to a compiler-generated method
        switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(str2))
        {
          case 80347274:
            if (Operators.CompareString(str2, "dual fuel appliance", false) == 0)
              goto label_50;
            else
              goto default;
          case 157581269:
            if (Operators.CompareString(str2, "heating oil", false) == 0)
            {
              str1 = "olew";
              goto label_68;
            }
            else
              goto default;
          case 335024745:
            if (Operators.CompareString(str2, "heat from boilers – biogas", false) == 0)
            {
              str1 = "bionwy";
              goto label_68;
            }
            else
              goto default;
          case 529869997:
            if (Operators.CompareString(str2, "Electricaire", false) == 0)
            {
              str1 = "Electricaire";
              goto label_68;
            }
            else
              goto default;
          case 575487477:
            if (Operators.CompareString(str2, "wood pellets (bulk supply in bags, for main heating)", false) == 0)
              break;
            goto default;
          case 604697910:
            if (Operators.CompareString(str2, "manufactured smokeless fuel", false) == 0)
            {
              str1 = "tanwydd di-fwg";
              goto label_68;
            }
            else
              goto default;
          case 664172296:
            if (Operators.CompareString(str2, "heat from CHP", false) == 0)
            {
              str1 = "gynllun CHP cymunedol";
              goto label_68;
            }
            else
              goto default;
          case 721524493:
            if (Operators.CompareString(str2, "dual fuel appliance (mineral and wood)", false) == 0)
              goto label_50;
            else
              goto default;
          case 820966853:
            if (Operators.CompareString(str2, "biomass", false) == 0)
              goto label_51;
            else
              goto default;
          case 857289046:
            if (Operators.CompareString(str2, "house coal", false) == 0)
            {
              str1 = "glo";
              goto label_68;
            }
            else
              goto default;
          case 975024876:
            if (Operators.CompareString(str2, "bulk LPG", false) == 0)
            {
              str1 = "LPG";
              goto label_68;
            }
            else
              goto default;
          case 1166727269:
            if (Operators.CompareString(str2, "Biomass", false) == 0)
              goto label_51;
            else
              goto default;
          case 1424221758:
            if (Operators.CompareString(str2, "geothermal heat source", false) == 0)
            {
              str1 = "Ffynhonnell wres geothermol";
              goto label_68;
            }
            else
              goto default;
          case 1441345278:
            if (Operators.CompareString(str2, "Electricity", false) == 0)
            {
              str1 = "trydan";
              goto label_68;
            }
            else
              goto default;
          case 1522447619:
            if (Operators.CompareString(str2, "wood chips", false) == 0)
            {
              str1 = "asglodion coed";
              goto label_68;
            }
            else
              goto default;
          case 1597764060:
            if (Operators.CompareString(str2, "mains gas", false) == 0)
            {
              str1 = "nwy prif gyflenwad";
              goto label_68;
            }
            else
              goto default;
          case 1623787443:
            if (Operators.CompareString(str2, "10-hour tariff (on-peak)", false) == 0)
            {
              str1 = "";
              goto label_68;
            }
            else
              goto default;
          case 1635946890:
            if (Operators.CompareString(str2, "Elec Sold", false) == 0)
            {
              str1 = "Elec Sold";
              goto label_68;
            }
            else
              goto default;
          case 1654577706:
            if (Operators.CompareString(str2, "community heat from boilers", false) == 0)
            {
              str1 = "community heat from boilers";
              goto label_68;
            }
            else
              goto default;
          case 1757549622:
            if (Operators.CompareString(str2, "CommCHP", false) == 0)
            {
              str1 = "CommCHP";
              goto label_68;
            }
            else
              goto default;
          case 1946790875:
            if (Operators.CompareString(str2, "wood logs", false) == 0)
            {
              str1 = "logiau coed";
              goto label_68;
            }
            else
              goto default;
          case 1956632141:
            if (Operators.CompareString(str2, "7-hour tariff (on-peak)", false) == 0)
            {
              str1 = "7-hour tariff (on-peak)";
              goto label_68;
            }
            else
              goto default;
          case 2251322125:
            if (Operators.CompareString(str2, "wood pellets (in bags, for secondary heating)", false) == 0)
              break;
            goto default;
          case 2313921600:
            if (Operators.CompareString(str2, "anthracite", false) == 0)
            {
              str1 = "glo carreg";
              goto label_68;
            }
            else
              goto default;
          case 2340757125:
            if (Operators.CompareString(str2, "heat from boilers - waste combustion", false) == 0)
            {
              str1 = "hylosgi gwastraff";
              goto label_68;
            }
            else
              goto default;
          case 2343415715:
            if (Operators.CompareString(str2, "waste heat from power stations", false) == 0)
            {
              str1 = "gynllun CHP cymunedol";
              goto label_68;
            }
            else
              goto default;
          case 2442528761:
            if (Operators.CompareString(str2, "heat from heat pump", false) == 0)
            {
              str1 = "Pwmp gwres cymunedol";
              goto label_68;
            }
            else
              goto default;
          case 2487325169:
            if (Operators.CompareString(str2, "10-hour tariff (off-peak)", false) == 0)
            {
              str1 = "10-hour tariff (off-peak)";
              goto label_68;
            }
            else
              goto default;
          case 2587725710:
            if (Operators.CompareString(str2, "main wood pellets", false) == 0)
              break;
            goto default;
          case 3216529428:
            if (Operators.CompareString(str2, "heat from boilers – biomass", false) == 0)
              goto label_51;
            else
              goto default;
          case 3483432765:
            if (Operators.CompareString(str2, "secondary wood pellets", false) == 0)
            {
              str1 = " eilaidd pelenni coed";
              goto label_68;
            }
            else
              goto default;
          case 3722837730:
            if (Operators.CompareString(str2, "bottled LPG", false) == 0)
            {
              str1 = "nwy potel";
              goto label_68;
            }
            else
              goto default;
          case 3836938347:
            if (Operators.CompareString(str2, "7-hour tariff (off-peak)", false) == 0)
            {
              str1 = "7-hour tariff (off-peak)";
              goto label_68;
            }
            else
              goto default;
          case 4020509270:
            if (Operators.CompareString(str2, "standard tariff", false) == 0)
            {
              str1 = "tarriff safonol";
              goto label_68;
            }
            else
              goto default;
          case 4276122469:
            if (Operators.CompareString(str2, "smokeless fuel", false) == 0)
            {
              str1 = "tanwydd di-fwg";
              goto label_68;
            }
            else
              goto default;
          default:
            str1 = FuelType;
            goto label_68;
        }
        str1 = "pelenni coed";
        goto label_68;
label_50:
        str1 = "dau danwydd (mwynau a choed)";
        goto label_68;
label_51:
        str1 = "biomas";
label_68:;
      }
      return str1;
    }

    public static string CheckWalesHeatingControl(string ControlTypeDesc, int Country)
    {
      if (Country == 2 & Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].EPCLanguage, "Welsh", false) == 0)
      {
        string str = Strings.LTrim(Strings.RTrim(ControlTypeDesc));
        // ISSUE: reference to a compiler-generated method
        switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(str))
        {
          case 110782171:
            if (Operators.CompareString(str, "Time and temperature zone control by device in database", false) == 0)
            {
              ControlTypeDesc = "Rheolaeth amser a rheolaeth parthau tymheredd";
              goto label_78;
            }
            else
              goto label_78;
          case 159546604:
            if (Operators.CompareString(str, "Flat rate charging, programmer, no room thermostat", false) == 0)
            {
              ControlTypeDesc = "Tâl un gyfradd, rhaglennydd, dim thermostat ystafell";
              goto label_78;
            }
            else
              goto label_78;
          case 410028242:
            if (Operators.CompareString(str, "Flat rate charging, no thermostatic control of room temperature", false) == 0)
            {
              ControlTypeDesc = "Tâl un gyfradd, dim rheolaeth thermostatig ar dymheredd yr ystafell";
              goto label_78;
            }
            else
              goto label_78;
          case 430627436:
            if (Operators.CompareString(str, "Unit charging, programmer and TRVs", false) == 0)
            {
              ControlTypeDesc = "Talu fesul uned, rhaglennydd a TRVs";
              goto label_78;
            }
            else
              goto label_78;
          case 540255825:
            if (Operators.CompareString(str, "Flat rate charging, room thermostat only", false) == 0)
            {
              ControlTypeDesc = "Tâl un gyfradd, thermostat ystafell yn unig";
              goto label_78;
            }
            else
              goto label_78;
          case 572344439:
            if (Operators.CompareString(str, "Programmer, TRVs and bypass", false) == 0)
            {
              ControlTypeDesc = "Rhaglennydd, TRVs a falf osgoi";
              goto label_78;
            }
            else
              goto label_78;
          case 759883493:
            if (Operators.CompareString(str, "Charging system linked to use of community heating, TRVs", false) == 0)
            {
              ControlTypeDesc = "System dalu wedi’i chysylltu â defnyddio gwres cymunedol, TRVs";
              goto label_78;
            }
            else
              goto label_78;
          case 810547195:
            if (Operators.CompareString(str, "None", false) == 0)
            {
              ControlTypeDesc = "Dim";
              goto label_78;
            }
            else
              goto label_78;
          case 812642225:
            if (Operators.CompareString(str, "Programmer, TRVs and boiler energy manager", false) == 0)
            {
              ControlTypeDesc = "Rhaglennydd, TRVs a rheolydd ynni ar y bwyler";
              goto label_78;
            }
            else
              goto label_78;
          case 830612185:
            if (Operators.CompareString(str, "Programmer and room thermostats", false) == 0)
            {
              ControlTypeDesc = "Rhaglennydd a thermostatau ystafell";
              goto label_78;
            }
            else
              goto label_78;
          case 1142152663:
            if (Operators.CompareString(str, "Room thermostat only", false) == 0)
            {
              ControlTypeDesc = "Thermostat ystafell yn unig";
              goto label_78;
            }
            else
              goto label_78;
          case 1393676580:
            if (Operators.CompareString(str, "Time and temperature zone control by suitable arrangement of plumbing and electrical services", false) == 0)
            {
              ControlTypeDesc = "Rheolaeth amser a rheolaeth parthau tymheredd";
              goto label_78;
            }
            else
              goto label_78;
          case 1722785404:
            if (Operators.CompareString(str, "No thermostatic control of room temperature", false) == 0)
            {
              ControlTypeDesc = "Dim rheolaeth thermostatig ar dymheredd yr ystafell";
              goto label_78;
            }
            else
              goto label_78;
          case 1792651018:
            if (Operators.CompareString(str, "Celect-type controls", false) == 0)
              break;
            goto label_78;
          case 1828223264:
            if (Operators.CompareString(str, "Manual charge control", false) == 0)
            {
              ControlTypeDesc = "Rheoli’r tâl â llaw";
              goto label_78;
            }
            else
              goto label_78;
          case 2049647489:
            if (Operators.CompareString(str, "Programmer, TRVs and flow switch", false) == 0)
            {
              ControlTypeDesc = "Rhaglennydd, TRVs a swits llif";
              goto label_78;
            }
            else
              goto label_78;
          case 2182588494:
            if (Operators.CompareString(str, "Room thermostats only", false) == 0)
            {
              ControlTypeDesc = "Thermostatau ystafell yn unig";
              goto label_78;
            }
            else
              goto label_78;
          case 2265258166:
            if (Operators.CompareString(str, "Programmer, no room thermostat", false) == 0)
            {
              ControlTypeDesc = "Rhaglennydd, dim thermostat ystafell";
              goto label_78;
            }
            else
              goto label_78;
          case 2324572899:
            if (Operators.CompareString(str, "TRVs and bypass", false) == 0)
            {
              ControlTypeDesc = "TRVs a falf osgoi";
              goto label_78;
            }
            else
              goto label_78;
          case 2570742376:
            if (Operators.CompareString(str, "Celect control", false) == 0)
              break;
            goto label_78;
          case 2872186946:
            if (Operators.CompareString(str, "Charging system linked to use of community heating, programmer and at least two room thermostats", false) == 0)
            {
              ControlTypeDesc = "System dalu wedi’i chysylltu â defnyddio gwres cymunedol, rhaglennydd ac o leiaf ddau thermostat ystafell";
              goto label_78;
            }
            else
              goto label_78;
          case 2897373165:
            if (Operators.CompareString(str, "Flat rate charging, programmer and at least two room thermostats", false) == 0)
            {
              ControlTypeDesc = "Tâl un gyfradd, rhaglennydd ac o leiaf ddau thermostat ystafell";
              goto label_78;
            }
            else
              goto label_78;
          case 2907887821:
            if (Operators.CompareString(str, "Automatic charge control", false) == 0)
            {
              ControlTypeDesc = "Rheoli gwefr drydanol yn awtomatig";
              goto label_78;
            }
            else
              goto label_78;
          case 2948165638:
            if (Operators.CompareString(str, "Charging system linked to use of community heating, programmer and TRVs", false) == 0)
            {
              ControlTypeDesc = "System dalu wedi’i chysylltu â defnyddio gwres cymunedol, rhaglennydd a TRVs";
              goto label_78;
            }
            else
              goto label_78;
          case 3005790514:
            if (Operators.CompareString(str, "No time or thermostatic control of room temperature", false) == 0)
            {
              ControlTypeDesc = "Dim rheolaeth amser na rheolaeth thermostatig ar dymheredd yr ystafell";
              goto label_78;
            }
            else
              goto label_78;
          case 3024665872:
            if (Operators.CompareString(str, "Programmer and room thermostat", false) == 0)
            {
              ControlTypeDesc = "Rhaglennydd a thermostat ystafell";
              goto label_78;
            }
            else
              goto label_78;
          case 3057123095:
            if (Operators.CompareString(str, "Programmer, room thermostat and TRVs", false) == 0)
            {
              ControlTypeDesc = "Rhaglennydd, thermostat ystafell a TRVs";
              goto label_78;
            }
            else
              goto label_78;
          case 3092489262:
            if (Operators.CompareString(str, "Appliance thermostats", false) == 0)
            {
              ControlTypeDesc = "Thermostatau ar y cyfarpar";
              goto label_78;
            }
            else
              goto label_78;
          case 3136525067:
            if (Operators.CompareString(str, "Programmer and at least two room thermostats", false) == 0)
            {
              ControlTypeDesc = "Rhaglennydd ac o leiaf ddau thermostat ystafell";
              goto label_78;
            }
            else
              goto label_78;
          case 3600157127:
            if (Operators.CompareString(str, "Flat rate charging, programmer and TRVs", false) == 0)
            {
              ControlTypeDesc = "Tâl un gyfradd, rhaglennydd a TRVs";
              goto label_78;
            }
            else
              goto label_78;
          case 3702274074:
            if (Operators.CompareString(str, "Flat rate charging, programmer and room thermostat", false) == 0)
            {
              ControlTypeDesc = "Tâl un gyfradd, rhaglennydd a thermostat ystafell";
              goto label_78;
            }
            else
              goto label_78;
          case 3981754299:
            if (Operators.CompareString(str, "Controls for high heat retention storage heaters", false) == 0)
            {
              ControlTypeDesc = "Rheolyddion i wresogyddion storio sy’n cadw llawer o wres";
              goto label_78;
            }
            else
              goto label_78;
          case 4010298098:
            if (Operators.CompareString(str, "Time and temperature zone control", false) == 0)
            {
              ControlTypeDesc = "Rheolaeth amser a rheolaeth parthau tymheredd";
              goto label_78;
            }
            else
              goto label_78;
          case 4100754581:
            if (Operators.CompareString(str, "Programmer and appliance thermostats", false) == 0)
            {
              ControlTypeDesc = "Rhaglennydd a thermostatau ar y cyfarpar";
              goto label_78;
            }
            else
              goto label_78;
          case 4228687944:
            if (Operators.CompareString(str, "Temperature zone control", false) == 0)
            {
              ControlTypeDesc = "Rheolaeth parthau tymheredd";
              goto label_78;
            }
            else
              goto label_78;
          default:
            goto label_78;
        }
        ControlTypeDesc = "Rheolaeth Celect";
      }
      else
      {
        string Left = Strings.LTrim(Strings.RTrim(ControlTypeDesc));
        if (Operators.CompareString(Left, "Time and temperature zone control by suitable arrangement of plumbing and electrical services", false) != 0)
        {
          if (Operators.CompareString(Left, "Time and temperature zone control by device in database", false) != 0)
          {
            if (Operators.CompareString(Left, "No thermostatic control of room temperature", false) == 0)
              ControlTypeDesc = "No time or thermostatic control of room temperature";
          }
          else
            ControlTypeDesc = "Time and temperature zone control";
        }
        else
          ControlTypeDesc = "Time and temperature zone control";
        ControlTypeDesc = ControlTypeDesc;
      }
label_78:
      return ControlTypeDesc;
    }

    public static string CheckWalesWindows(string WindowsDesc, int country)
    {
      string Left;
      if (country == 2 & Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].EPCLanguage, "Welsh", false) == 0)
      {
        string str = WindowsDesc;
        // ISSUE: reference to a compiler-generated method
        switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(str))
        {
          case 257199634:
            if (Operators.CompareString(str, "Full secondary glazing", false) == 0)
            {
              Left = "Gwydrau eilaidd llawn";
              break;
            }
            break;
          case 672283634:
            if (Operators.CompareString(str, "Single glazed", false) == 0)
            {
              Left = "Gwydrau sengl";
              break;
            }
            break;
          case 872072672:
            if (Operators.CompareString(str, "Multiple glazing throughout", false) == 0)
            {
              Left = "Gwydrau lluosog ym mhobman";
              break;
            }
            break;
          case 1023935150:
            if (Operators.CompareString(str, "Partial multiple glazing", false) == 0)
            {
              Left = "Gwydrau lluosog rhannol";
              break;
            }
            break;
          case 1498114302:
            if (Operators.CompareString(str, "Partial triple glazing", false) == 0)
            {
              Left = "Gwydrau triphlyg rhannol";
              break;
            }
            break;
          case 1686532130:
            if (Operators.CompareString(str, "Some double glazing", false) == 0)
            {
              Left = "Rhai gwydrau dwbl";
              break;
            }
            break;
          case 1690934827:
            if (Operators.CompareString(str, "Mostly multiple glazing", false) == 0)
            {
              Left = "Gwydrau lluosog gan mwyaf";
              break;
            }
            break;
          case 1767791162:
            if (Operators.CompareString(str, "Mostly double glazing", false) == 0)
            {
              Left = "Gwydrau dwbl gan mwyaf";
              break;
            }
            break;
          case 2160751083:
            if (Operators.CompareString(str, "Mostly triple glazing", false) == 0)
            {
              Left = "Gwydrau triphlyg gan mwyaf";
              break;
            }
            break;
          case 2168390750:
            if (Operators.CompareString(str, "Fully triple glazed", false) == 0)
            {
              Left = "Gwydrau triphlyg llawn";
              break;
            }
            break;
          case 2229288500:
            if (Operators.CompareString(str, "Single and multiple glazing", false) == 0)
            {
              Left = "Gwydrau sengl a lluosog";
              break;
            }
            break;
          case 2374610012:
            if (Operators.CompareString(str, "Partial secondary glazing", false) == 0)
            {
              Left = "Gwydrau eilaidd rhannol";
              break;
            }
            break;
          case 3570881747:
            if (Operators.CompareString(str, "Some triple glazing", false) == 0)
            {
              Left = "Rhai gwydrau triphlyg";
              break;
            }
            break;
          case 3614515807:
            if (Operators.CompareString(str, "High performance glazing", false) == 0)
            {
              Left = "Ffenestri perfformiad uchel";
              break;
            }
            break;
          case 3845204787:
            if (Operators.CompareString(str, "Some multiple glazing", false) == 0)
            {
              Left = "Rhai gwydrau lluosog";
              break;
            }
            break;
          case 3848787767:
            if (Operators.CompareString(str, "Partial double glazing", false) == 0)
            {
              Left = "Gwydrau dwbl rhannol";
              break;
            }
            break;
          case 3860007181:
            if (Operators.CompareString(str, "Fully double glazed", false) == 0)
            {
              Left = "Gwydrau dwbl llawn";
              break;
            }
            break;
          case 4024643459:
            if (Operators.CompareString(str, "Mostly secondary glazing", false) == 0)
            {
              Left = "Gwydrau eilaidd gan mwyaf";
              break;
            }
            break;
          case 4193044971:
            if (Operators.CompareString(str, "Some secondary glazing", false) == 0)
            {
              Left = "Rhai gwydrau eilaidd";
              break;
            }
            break;
        }
      }
      else
        Left = WindowsDesc;
      if (Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Name, "WA-1p", false) == 0 && Operators.CompareString(Left, "Gwydrau lluosog ym mhobman", false) == 0)
        Left = "Ffenestri perfformiad uchel";
      return Left;
    }

    public static string checkWalesWater(string WaterDescription, int Country)
    {
      if (Country == 2 & Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].EPCLanguage, "Welsh", false) == 0)
      {
        string str = WaterDescription;
        // ISSUE: reference to a compiler-generated method
        switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(str))
        {
          case 517664841:
            if (Operators.CompareString(str, "From second main system", false) == 0)
            {
              WaterDescription = "O’r brif system";
              goto label_63;
            }
            else
              goto label_63;
          case 585827434:
            if (Operators.CompareString(str, "no cylinderstat", false) == 0)
            {
              WaterDescription = "dim thermostat ar y silindr";
              goto label_63;
            }
            else
              goto label_63;
          case 596340374:
            if (Operators.CompareString(str, "Gas boiler/circulator", false) == 0)
            {
              WaterDescription = "Bwyler/cylchredydd nwy";
              goto label_63;
            }
            else
              goto label_63;
          case 598889865:
            if (Operators.CompareString(str, "Community scheme", false) == 0)
            {
              WaterDescription = "Cynllun cymunedol";
              goto label_63;
            }
            else
              goto label_63;
          case 639522663:
            if (Operators.CompareString(str, "Electric instantaneous at point of use", false) == 0)
            {
              WaterDescription = "Trydan ar unwaith yn y fan lle mae’n cael ei ddefnyddio";
              goto label_63;
            }
            else
              goto label_63;
          case 730073549:
            if (Operators.CompareString(str, "Single-point gas water heater", false) == 0)
              goto label_42;
            else
              goto label_63;
          case 804163395:
            if (Operators.CompareString(str, "From main system", false) == 0)
              goto label_36;
            else
              goto label_63;
          case 1031085205:
            if (Operators.CompareString(str, "From main heating system", false) == 0)
              goto label_36;
            else
              goto label_63;
          case 1205250646:
            if (Operators.CompareString(str, "Community scheme with CHP", false) == 0)
              goto label_51;
            else
              goto label_63;
          case 1218889104:
            if (Operators.CompareString(str, "No system present : electric immersion assumed", false) == 0)
              break;
            goto label_63;
          case 1348033598:
            if (Operators.CompareString(str, "Electric immersion, standard tariff", false) == 0)
            {
              WaterDescription = "Twymwr tanddwr, tarriff safonol";
              goto label_63;
            }
            else
              goto label_63;
          case 1473398436:
            if (Operators.CompareString(str, "From secondary heater", false) == 0)
            {
              WaterDescription = "O system eilaidd";
              goto label_63;
            }
            else
              goto label_63;
          case 1604474714:
            if (Operators.CompareString(str, "Electric immersion, off-peak", false) == 0)
            {
              WaterDescription = "Twymwr tanddwr, an-frig";
              goto label_63;
            }
            else
              goto label_63;
          case 1668922856:
            if (Operators.CompareString(str, "From main system, no cylinderstat", false) == 0)
            {
              WaterDescription = "O’r brif system, dim thermostat ar y silindr";
              goto label_63;
            }
            else
              goto label_63;
          case 1800791375:
            if (Operators.CompareString(str, "From community scheme", false) == 0)
            {
              WaterDescription = "Cynllun cymunedol";
              goto label_63;
            }
            else
              goto label_63;
          case 1803754728:
            if (Operators.CompareString(str, "No system present: electric immersion assumed", false) == 0)
              break;
            goto label_63;
          case 2034045386:
            if (Operators.CompareString(str, "From main system, plus solar", false) == 0)
            {
              WaterDescription = "O’r brif system, gydag ynni’r haul";
              goto label_63;
            }
            else
              goto label_63;
          case 2049365597:
            if (Operators.CompareString(str, "From main system, waste water heat recovery", false) == 0)
            {
              WaterDescription = "O’r brif system, adfer gwres dŵr gwastraff";
              goto label_63;
            }
            else
              goto label_63;
          case 2129818411:
            if (Operators.CompareString(str, "Gas instantaneous at point of use", false) == 0)
              goto label_42;
            else
              goto label_63;
          case 2160997334:
            if (Operators.CompareString(str, "Electric immersion, off-peak, waste water heat recovery", false) == 0)
            {
              WaterDescription = "Twymwr tanddwr, an-frig, adfer gwres dŵr gwastraff";
              goto label_63;
            }
            else
              goto label_63;
          case 2603465428:
            if (Operators.CompareString(str, "From secondary system,", false) == 0)
              goto label_38;
            else
              goto label_63;
          case 2630425603:
            if (Operators.CompareString(str, "Oil boiler/circulator", false) == 0)
            {
              WaterDescription = "Bwyler/cylchredydd olew ";
              goto label_63;
            }
            else
              goto label_63;
          case 3164776206:
            if (Operators.CompareString(str, "Gas range cooker", false) == 0)
            {
              WaterDescription = "Popty estynedig nwy";
              goto label_63;
            }
            else
              goto label_63;
          case 3313357832:
            if (Operators.CompareString(str, "Solid fuel boiler/circulator", false) == 0)
            {
              WaterDescription = "Bwyler/cylchredydd tanwydd solet";
              goto label_63;
            }
            else
              goto label_63;
          case 3543613712:
            if (Operators.CompareString(str, "From community heat pump", false) == 0)
            {
              WaterDescription = "O bwmp gwres cymunedol";
              goto label_63;
            }
            else
              goto label_63;
          case 3615518320:
            if (Operators.CompareString(str, "From secondary system", false) == 0)
              goto label_38;
            else
              goto label_63;
          case 3684266873:
            if (Operators.CompareString(str, "Electric immersion", false) == 0)
            {
              WaterDescription = "Twymwr tanddwr";
              goto label_63;
            }
            else
              goto label_63;
          case 3789467656:
            if (Operators.CompareString(str, "From community CHP scheme", false) == 0)
              goto label_51;
            else
              goto label_63;
          case 3817589693:
            if (Operators.CompareString(str, "From main system,", false) == 0)
              goto label_36;
            else
              goto label_63;
          case 3917744448:
            if (Operators.CompareString(str, "Solid fuel range cooker", false) == 0)
            {
              WaterDescription = "Popty estynedig tanwydd solet";
              goto label_63;
            }
            else
              goto label_63;
          case 4010035873:
            if (Operators.CompareString(str, "Oil range cooker", false) == 0)
            {
              WaterDescription = "Popty estynedig olew";
              goto label_63;
            }
            else
              goto label_63;
          case 4021806343:
            if (Operators.CompareString(str, "Gas multipoint", false) == 0)
            {
              WaterDescription = "Nwy wrth fwy nag un pwynt";
              goto label_63;
            }
            else
              goto label_63;
          case 4043532678:
            if (Operators.CompareString(str, "From main system, plus solar, waste water heat recovery", false) == 0)
            {
              WaterDescription = "O’r brif system, gydag ynni’r haul, adfer gwres dŵr gwastraff";
              goto label_63;
            }
            else
              goto label_63;
          default:
            goto label_63;
        }
        WaterDescription = "Dim system ar gael: rhagdybir bod twymwr tanddwr trydan";
        goto label_63;
label_36:
        WaterDescription = "O’r brif system";
        goto label_63;
label_38:
        WaterDescription = "O system eilaidd";
        goto label_63;
label_42:
        WaterDescription = "Nwy ar unwaith yn y fan lle mae’n cael ei ddefnyddio";
        goto label_63;
label_51:
        WaterDescription = "O gynllun CHP cymunedol";
      }
      else
        WaterDescription = WaterDescription;
label_63:
      return WaterDescription;
    }

    public static string CheckTextWidth(string Desc, int k)
    {
      PDFFunctions.PrintTextC[21] = "";
      string str1 = "";
      string str2 = "";
      string str3;
      try
      {
        str1 = "";
        object Right = (object) 0;
        int index = 0;
        do
        {
          PDFFunctions.PrintTextC[index] = "";
          checked { ++index; }
        }
        while (index <= 21);
        PDFFunctions.CountLen = 0;
        string Expression = Desc;
label_4:
        int num1 = Strings.Len(Expression);
        int length = 0;
        while (length <= num1)
        {
          string str4 = Expression.Substring(0, length);
          if (str4.EndsWith(" "))
          {
            XSize xsize = PDFFunctions.gfx[k].MeasureString(str4, PDFFunctions.ArialFont10);
            double width = ((XSize) ref xsize).Width;
            XSize pageSize = PDFFunctions.gfx[k].PageSize;
            double num2 = ((XSize) ref pageSize).Width - 340.0;
            if (width > num2)
            {
              PDFFunctions.PrintTextC[PDFFunctions.CountLen] = str2;
              checked { ++PDFFunctions.CountLen; }
              Expression = Expression.Substring(Conversions.ToInteger(Right), Conversions.ToInteger(Operators.SubtractObject((object) Strings.Len(Expression), Right)));
              goto label_4;
            }
            else
            {
              str2 = str4;
              Right = (object) length;
            }
          }
          if (length == Strings.Len(Desc))
          {
            XSize xsize = PDFFunctions.gfx[k].MeasureString(str4, PDFFunctions.ArialFont10);
            double width = ((XSize) ref xsize).Width;
            XSize pageSize = PDFFunctions.gfx[k].PageSize;
            double num3 = ((XSize) ref pageSize).Width - 340.0;
            if (width > num3)
            {
              PDFFunctions.PrintTextC[PDFFunctions.CountLen] = str2;
              checked { ++PDFFunctions.CountLen; }
              Expression = Expression.Substring(Conversions.ToInteger(Right), Conversions.ToInteger(Operators.SubtractObject((object) Strings.Len(Expression), Right)));
              goto label_4;
            }
            else
            {
              str2 = str4;
              Right = (object) length;
            }
          }
          if (length == Strings.Len(Expression))
            PDFFunctions.PrintTextC[PDFFunctions.CountLen] = Expression;
          checked { ++length; }
        }
        str3 = PDFFunctions.PrintTextC[length];
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      return str3;
    }

    public static string[] CheckNotesWidth(string Desc, int k)
    {
      string str1 = "";
      string Left = "";
      string[] printNotes;
      try
      {
        str1 = "";
        object Right = (object) 0;
        int index = 0;
        do
        {
          PDFFunctions.PrintNotes[index] = "";
          checked { ++index; }
        }
        while (index <= 1000);
        PDFFunctions.CountLen = 0;
        string Expression = Desc;
label_4:
        int num1 = Strings.Len(Expression);
        int length = 0;
        while (length <= num1)
        {
          string str2 = Expression.Substring(0, length);
          XSize xsize;
          if (str2.EndsWith(" "))
          {
            xsize = PDFFunctions.gfx[0].MeasureString(str2, PDFFunctions.ArialFont10);
            double width = ((XSize) ref xsize).Width;
            xsize = PDFFunctions.gfx[0].PageSize;
            double num2 = ((XSize) ref xsize).Width - 100.0;
            if (width > num2)
            {
              PDFFunctions.PrintNotes[PDFFunctions.CountLen] = str2;
              Expression = Expression.Substring(Conversions.ToInteger(Right), Conversions.ToInteger(Operators.SubtractObject((object) Strings.Len(Expression), Right)));
              checked { ++PDFFunctions.CountLen; }
              goto label_4;
            }
            else
            {
              Left = str2;
              Right = (object) length;
            }
          }
          if (length == Strings.Len(Desc))
          {
            xsize = PDFFunctions.gfx[0].MeasureString(str2, PDFFunctions.ArialFont10);
            double width = ((XSize) ref xsize).Width;
            xsize = PDFFunctions.gfx[0].PageSize;
            double num3 = ((XSize) ref xsize).Width - 100.0;
            if (width > num3 && (uint) Operators.CompareString(Left, "", false) > 0U)
            {
              PDFFunctions.PrintNotes[PDFFunctions.CountLen] = Left;
              Expression = Expression.Substring(Conversions.ToInteger(Right), Conversions.ToInteger(Operators.SubtractObject((object) Strings.Len(Expression), Right)));
              checked { ++PDFFunctions.CountLen; }
              goto label_4;
            }
            else
            {
              Left = str2;
              Right = (object) length;
            }
          }
          if (length == Strings.Len(Expression))
          {
            PDFFunctions.PrintNotes[PDFFunctions.CountLen] = Expression;
            checked { ++PDFFunctions.CountLen; }
          }
          checked { ++length; }
        }
        printNotes = PDFFunctions.PrintNotes;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      return printNotes;
    }

    public static string CheckWalesMonth(string Month)
    {
      string str = Month;
      // ISSUE: reference to a compiler-generated method
      switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(str))
      {
        case 18653215:
          if (Operators.CompareString(str, "July", false) == 0)
          {
            Month = "Gorffennaf";
            break;
          }
          break;
        case 1000858150:
          if (Operators.CompareString(str, "May", false) == 0)
          {
            Month = "Mai";
            break;
          }
          break;
        case 1051015743:
          if (Operators.CompareString(str, "November", false) == 0)
          {
            Month = "Tachwedd";
            break;
          }
          break;
        case 1574658204:
          if (Operators.CompareString(str, "August", false) == 0)
          {
            Month = "Awst";
            break;
          }
          break;
        case 1714277534:
          if (Operators.CompareString(str, "December", false) == 0)
          {
            Month = "Rhagfyr";
            break;
          }
          break;
        case 2564533399:
          if (Operators.CompareString(str, "April", false) == 0)
          {
            Month = "Ebrill";
            break;
          }
          break;
        case 2636970877:
          if (Operators.CompareString(str, "January", false) == 0)
          {
            Month = "Ionawr";
            break;
          }
          break;
        case 3229901712:
          if (Operators.CompareString(str, "March", false) == 0)
          {
            Month = "Mawrth";
            break;
          }
          break;
        case 3256006144:
          if (Operators.CompareString(str, "September", false) == 0)
          {
            Month = "Medi";
            break;
          }
          break;
        case 3911251845:
          if (Operators.CompareString(str, "June", false) == 0)
          {
            Month = "Mehefin";
            break;
          }
          break;
        case 3975288839:
          if (Operators.CompareString(str, "October", false) == 0)
          {
            Month = "Hydref";
            break;
          }
          break;
        case 4238833203:
          if (Operators.CompareString(str, "February", false) == 0)
          {
            Month = "Chwefror";
            break;
          }
          break;
      }
      return Month;
    }

    public static string RequestRRNByUPRN(string UPRN, string InspectionDate)
    {
      string str1 = UPRN.Replace("UPRN-", "");
      string[] strArray1 = new string[20];
      string[] strArray2 = new string[20];
      string[] strArray3 = new string[6];
      if (Strings.Len(InspectionDate) != 6 || !Versioned.IsNumeric((object) InspectionDate))
        return "Incorrect Date Format. Correct Format is YYMMDD";
      int index1 = 0;
      do
      {
        strArray3[index1] = Strings.Right(Strings.Left(InspectionDate, checked (index1 + 1)), 1);
        if (Conversion.Val(strArray3[index1]) % 2.0 != 0.0)
          strArray3[index1] = Conversions.ToString(10.0 - Conversion.Val(strArray3[index1]));
        checked { ++index1; }
      }
      while (index1 <= 5);
      VBMath.Randomize();
      string str2 = Conversions.ToString(Math.Round(9.0 * (double) VBMath.Rnd() + 1.0));
      if (Operators.CompareString(str2, "10", false) == 0)
        str2 = "9";
      VBMath.Randomize();
      string str3 = Conversions.ToString(Math.Round(9.0 * (double) VBMath.Rnd() + 1.0));
      if (Operators.CompareString(str3, "10", false) == 0)
        str3 = "9";
      int index2 = 0;
      do
      {
        strArray1[index2] = Strings.Right(Strings.Left(str1, checked (index2 + 1)), 1);
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
      strArray1[16] = Strings.Right(Strings.Left(str2, 1), 1);
      strArray1[17] = Strings.Right(Strings.Left(str3, 2), 1);
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

    public static void EncodeFile(string srcFile, string destfile)
    {
      FileStream fileStream = new FileStream(srcFile, FileMode.Open);
      byte[] numArray = new byte[checked ((int) fileStream.Length + 1)];
      string str;
      try
      {
        fileStream.Read(numArray, 0, checked ((int) fileStream.Length));
        fileStream.Close();
        str = PDFFunctions.EncodeByte(numArray);
        PDFFunctions.PDFData = str;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      if (File.Exists(destfile))
        File.Delete(destfile);
      StreamWriter streamWriter = new StreamWriter(destfile, false);
      streamWriter.Write(str);
      streamWriter.Close();
    }

    public static string EncodeByte(byte[] bt)
    {
      string base64String;
      try
      {
        base64String = Convert.ToBase64String(bt);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      return base64String;
    }

    public static void EncodeFile2(string srcFile, string destfile)
    {
      FileStream fileStream = new FileStream(srcFile, FileMode.Open);
      byte[] numArray = new byte[checked ((int) fileStream.Length + 1)];
      string str;
      try
      {
        fileStream.Read(numArray, 0, checked ((int) fileStream.Length));
        fileStream.Close();
        str = PDFFunctions.EncodeByte(numArray);
        PDFFunctions.PDFInputvalues = str;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      if (File.Exists(destfile))
        File.Delete(destfile);
      StreamWriter streamWriter = new StreamWriter(destfile, false);
      streamWriter.Write(str);
      streamWriter.Close();
    }

    public static string Encode(string dec)
    {
      byte[] numArray = new byte[checked (dec.Length + 1)];
      return Convert.ToBase64String(Encoding.ASCII.GetBytes(dec));
    }

    public static void DecodeFile(string srcFile, string destFile)
    {
      byte[] array = PDFFunctions.DecodeToByte(srcFile);
      if (File.Exists(destFile))
        File.Delete(destFile);
      FileStream fileStream = new FileStream(destFile, FileMode.CreateNew);
      fileStream.Write(array, 0, array.Length);
      fileStream.Close();
    }

    public static byte[] DecodeToByte(string enc) => Convert.FromBase64String(enc);

    public class NotesResult
    {
      public int Length { get; set; }

      public string PrintNotes { get; set; }
    }
  }
}
