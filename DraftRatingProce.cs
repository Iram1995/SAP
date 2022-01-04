
// Type: SAP2012.DraftRatingProce




using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;

namespace SAP2012
{
  public class DraftRatingProce
  {
    public Image DrawGraph(string Country, int CurrRating, int PotentialRating)
    {
      int num1;
      Image image;
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
        int height1 = 1088;
label_5:
        num3 = 4;
        Font font1 = new Font("Arial", 24f, FontStyle.Regular);
label_6:
        num3 = 5;
        image = (Image) new Bitmap(width1, height1);
label_7:
        num3 = 6;
        Graphics graphics1 = Graphics.FromImage(image);
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
        graphics1.FillRectangle(Brushes.White, 0, 0, width1, height1);
label_23:
        num3 = 22;
        graphics2.DrawLine(pen1, 1, 1, checked (width1 - 1), 1);
label_24:
        num3 = 23;
        graphics2.DrawLine(pen1, checked (width1 - 1), 1, checked (width1 - 1), checked (height1 - 1));
label_25:
        num3 = 24;
        graphics2.DrawLine(pen1, checked (width1 - 1), checked (height1 - 1), 1, checked (height1 - 1));
label_26:
        num3 = 25;
        graphics2.DrawLine(pen1, 1, checked (height1 - 1), 1, 1);
label_27:
        num3 = 26;
        int num4 = checked ((int) Math.Round(unchecked (0.688 * (double) width1)));
label_28:
        num3 = 27;
        int num5 = checked ((int) Math.Round(unchecked (0.885 * (double) height1)));
label_29:
        num3 = 28;
        num4 = checked ((int) Math.Round(unchecked (0.845 * (double) width1)));
label_30:
        num3 = 29;
        graphics2.DrawLine(pen1, num4, num5, num4, 1);
label_31:
        num3 = 30;
        num4 = checked ((int) Math.Round(unchecked (0.766 * (double) width1 - (double) graphics2.MeasureString("Current", font5, 500).Width / 2.0)));
label_32:
        num3 = 31;
        num5 = checked ((int) Math.Round(unchecked (0.2 * (double) font5.GetHeight())));
label_33:
        num3 = 32;
        graphics2.DrawString("Current", font5, Brushes.Black, (float) num4, (float) num5);
label_34:
        num3 = 33;
        num4 = checked ((int) Math.Round(unchecked (0.921 * (double) width1 - (double) graphics2.MeasureString("Potential", font5, 500).Width / 2.0)));
label_35:
        num3 = 34;
        num5 = checked ((int) Math.Round(unchecked (0.2 * (double) font5.GetHeight())));
label_36:
        num3 = 35;
        graphics2.DrawString("Potential", font5, Brushes.Black, (float) num4, (float) num5);
label_37:
        num3 = 36;
        num4 = checked ((int) Math.Round(unchecked (0.02 * (double) width1)));
label_38:
        num3 = 37;
        num5 = checked ((int) Math.Round(unchecked (1.6 * (double) font5.GetHeight())));
label_39:
        num3 = 38;
        graphics2.DrawString("Very energy efficient - lower running costs", font6, Brushes.Black, (float) num4, (float) num5);
label_40:
        num3 = 39;
        num5 = checked ((int) Math.Round(unchecked (0.063 * (double) height1)));
label_41:
        num3 = 40;
        graphics2.DrawLine(pen1, 1, num5, checked (width1 - 1), num5);
label_42:
        num3 = 41;
        Brush brush = (Brush) new SolidBrush(Color.FromArgb(0, (int) sbyte.MaxValue, 61));
label_43:
        num3 = 42;
        num4 = checked ((int) Math.Round(unchecked (0.01 * (double) width1)));
label_44:
        num3 = 43;
        num5 = checked ((int) Math.Round(unchecked (0.127 * (double) height1)));
label_45:
        num3 = 44;
        int width2 = checked ((int) Math.Round(unchecked (0.221 * (double) width1)));
label_46:
        num3 = 45;
        int height2 = checked ((int) Math.Round(unchecked (0.086585 * (double) height1)));
label_47:
        num3 = 46;
        graphics2.FillRectangle(brush, num4, num5, width2, height2);
label_48:
        num3 = 47;
        num5 = checked ((int) Math.Round(unchecked ((double) num5 + (double) height2 / 2.0 - (double) graphics2.MeasureString("()", font7, 500).Height / 2.0)));
label_49:
        num3 = 48;
        num4 = checked ((int) Math.Round(unchecked (0.025 * (double) width1)));
label_50:
        num3 = 49;
        graphics2.DrawString("(92 plus)", font7, Brushes.White, (float) num4, (float) num5);
label_51:
        num3 = 50;
        num4 = checked ((int) Math.Round(unchecked (0.158 * (double) width1)));
label_52:
        num3 = 51;
        num5 = checked ((int) Math.Round(unchecked (0.127 * (double) height1 + (double) height2 / 2.0 - (double) graphics2.MeasureString("A", font2, 900).Height / 2.1)));
label_53:
        num3 = 52;
        GraphicsPath path = new GraphicsPath();
label_54:
        num3 = 53;
        path.AddString("A", font2.FontFamily, 1, 84f, new Point(num4, num5), StringFormat.GenericTypographic);
label_55:
        num3 = 54;
        graphics2.FillPath(Brushes.White, path);
label_56:
        num3 = 55;
        graphics2.DrawPath(pen2, path);
label_57:
        num3 = 56;
        num4 = checked ((int) Math.Round(unchecked (0.01 * (double) width1)));
label_58:
        num3 = 57;
        brush = (Brush) new SolidBrush(Color.FromArgb(44, 159, 41));
label_59:
        num3 = 58;
        num5 = checked ((int) Math.Round(unchecked (0.227 * (double) height1)));
label_60:
        num3 = 59;
        width2 = checked ((int) Math.Round(unchecked (0.295 * (double) width1)));
label_61:
        num3 = 60;
        graphics2.FillRectangle(brush, num4, num5, width2, height2);
label_62:
        num3 = 61;
        num5 = checked ((int) Math.Round(unchecked ((double) num5 + (double) height2 / 2.0 - (double) graphics2.MeasureString("()", font7, 900).Height / 2.0)));
label_63:
        num3 = 62;
        num4 = checked ((int) Math.Round(unchecked (0.025 * (double) width1)));
label_64:
        num3 = 63;
        graphics2.DrawString("(81-91)", font7, Brushes.White, (float) num4, (float) num5);
label_65:
        num3 = 64;
        num4 = checked ((int) Math.Round(unchecked (0.239 * (double) width1)));
label_66:
        num3 = 65;
        num5 = checked ((int) Math.Round(unchecked (0.227 * (double) height1 + (double) height2 / 2.0 - (double) graphics2.MeasureString("B", font2, 500).Height / 2.1)));
label_67:
        num3 = 66;
        path.AddString("B", font2.FontFamily, 1, 84f, new Point(num4, num5), StringFormat.GenericTypographic);
label_68:
        num3 = 67;
        graphics2.FillPath(Brushes.White, path);
label_69:
        num3 = 68;
        graphics2.DrawPath(pen2, path);
label_70:
        num3 = 69;
        num4 = checked ((int) Math.Round(unchecked (0.01 * (double) width1)));
label_71:
        num3 = 70;
        brush = (Brush) new SolidBrush(Color.FromArgb(157, 203, 60));
label_72:
        num3 = 71;
        num5 = checked ((int) Math.Round(unchecked (0.327 * (double) height1)));
label_73:
        num3 = 72;
        width2 = checked ((int) Math.Round(unchecked (0.37 * (double) width1)));
label_74:
        num3 = 73;
        graphics2.FillRectangle(brush, num4, num5, width2, height2);
label_75:
        num3 = 74;
        num5 = checked ((int) Math.Round(unchecked ((double) num5 + (double) height2 / 2.0 - (double) graphics2.MeasureString("()", font7, 900).Height / 2.0)));
label_76:
        num3 = 75;
        num4 = checked ((int) Math.Round(unchecked (0.025 * (double) width1)));
label_77:
        num3 = 76;
        graphics2.DrawString("(69-80)", font7, Brushes.Black, (float) num4, (float) num5);
label_78:
        num3 = 77;
        num4 = checked ((int) Math.Round(unchecked (0.307 * (double) width1)));
label_79:
        num3 = 78;
        num5 = checked ((int) Math.Round(unchecked (0.327 * (double) height1 + (double) height2 / 2.0 - (double) graphics2.MeasureString("C", font2, 500).Height / 2.1)));
label_80:
        num3 = 79;
        path.AddString("C", font2.FontFamily, 1, 84f, new Point(num4, num5), StringFormat.GenericTypographic);
label_81:
        num3 = 80;
        graphics2.FillPath(Brushes.White, path);
label_82:
        num3 = 81;
        graphics2.DrawPath(pen2, path);
label_83:
        num3 = 82;
        num4 = checked ((int) Math.Round(unchecked (0.01 * (double) width1)));
label_84:
        num3 = 83;
        brush = (Brush) new SolidBrush(Color.FromArgb((int) byte.MaxValue, 242, 0));
label_85:
        num3 = 84;
        num5 = checked ((int) Math.Round(unchecked (0.427 * (double) height1)));
label_86:
        num3 = 85;
        width2 = checked ((int) Math.Round(unchecked (0.445 * (double) width1)));
label_87:
        num3 = 86;
        graphics2.FillRectangle(brush, num4, num5, width2, height2);
label_88:
        num3 = 87;
        num5 = checked ((int) Math.Round(unchecked ((double) num5 + (double) height2 / 2.0 - (double) graphics2.MeasureString("()", font7, 900).Height / 2.0)));
label_89:
        num3 = 88;
        num4 = checked ((int) Math.Round(unchecked (0.025 * (double) width1)));
label_90:
        num3 = 89;
        graphics2.DrawString("(55-68)", font7, Brushes.Black, (float) num4, (float) num5);
label_91:
        num3 = 90;
        num4 = checked ((int) Math.Round(unchecked (0.387 * (double) width1)));
label_92:
        num3 = 91;
        num5 = checked ((int) Math.Round(unchecked (0.427 * (double) height1 + (double) height2 / 2.0 - (double) graphics2.MeasureString("D", font2, 500).Height / 2.1)));
label_93:
        num3 = 92;
        path.AddString("D", font2.FontFamily, 1, 84f, new Point(num4, num5), StringFormat.GenericTypographic);
label_94:
        num3 = 93;
        graphics2.FillPath(Brushes.White, path);
label_95:
        num3 = 94;
        graphics2.DrawPath(pen2, path);
label_96:
        num3 = 95;
        num4 = checked ((int) Math.Round(unchecked (0.01 * (double) width1)));
label_97:
        num3 = 96;
        brush = (Brush) new SolidBrush(Color.FromArgb(247, 175, 29));
label_98:
        num3 = 97;
        num5 = checked ((int) Math.Round(unchecked (0.527 * (double) height1)));
label_99:
        num3 = 98;
        width2 = checked ((int) Math.Round(unchecked (0.518 * (double) width1)));
label_100:
        num3 = 99;
        graphics2.FillRectangle(brush, num4, num5, width2, height2);
label_101:
        num3 = 100;
        num5 = checked ((int) Math.Round(unchecked ((double) num5 + (double) height2 / 2.0 - (double) graphics2.MeasureString("()", font7, 900).Height / 2.0)));
label_102:
        num3 = 101;
        num4 = checked ((int) Math.Round(unchecked (0.025 * (double) width1)));
label_103:
        num3 = 102;
        graphics2.DrawString("(39-54)", font7, Brushes.Black, (float) num4, (float) num5);
label_104:
        num3 = 103;
        num4 = checked ((int) Math.Round(unchecked (0.459 * (double) width1)));
label_105:
        num3 = 104;
        num5 = checked ((int) Math.Round(unchecked (0.527 * (double) height1 + (double) height2 / 2.0 - (double) graphics2.MeasureString("E", font2, 500).Height / 2.1)));
label_106:
        num3 = 105;
        path.AddString("E", font2.FontFamily, 1, 84f, new Point(num4, num5), StringFormat.GenericTypographic);
label_107:
        num3 = 106;
        graphics2.FillPath(Brushes.White, path);
label_108:
        num3 = 107;
        graphics2.DrawPath(pen2, path);
label_109:
        num3 = 108;
        num4 = checked ((int) Math.Round(unchecked (0.01 * (double) width1)));
label_110:
        num3 = 109;
        brush = (Brush) new SolidBrush(Color.FromArgb(237, 104, 35));
label_111:
        num3 = 110;
        num5 = checked ((int) Math.Round(unchecked (0.627 * (double) height1)));
label_112:
        num3 = 111;
        width2 = checked ((int) Math.Round(unchecked (0.592 * (double) width1)));
label_113:
        num3 = 112;
        graphics2.FillRectangle(brush, num4, num5, width2, height2);
label_114:
        num3 = 113;
        num5 = checked ((int) Math.Round(unchecked ((double) num5 + (double) height2 / 2.0 - (double) graphics2.MeasureString("()", font7, 900).Height / 2.0)));
label_115:
        num3 = 114;
        num4 = checked ((int) Math.Round(unchecked (0.025 * (double) width1)));
label_116:
        num3 = 115;
        graphics2.DrawString("(21-38)", font7, Brushes.Black, (float) num4, (float) num5);
label_117:
        num3 = 116;
        num4 = checked ((int) Math.Round(unchecked (0.536 * (double) width1)));
label_118:
        num3 = 117;
        num5 = checked ((int) Math.Round(unchecked (0.627 * (double) height1 + (double) height2 / 2.0 - (double) graphics2.MeasureString("F", font2, 500).Height / 2.1)));
label_119:
        num3 = 118;
        path.AddString("F", font2.FontFamily, 1, 84f, new Point(num4, num5), StringFormat.GenericTypographic);
label_120:
        num3 = 119;
        graphics2.FillPath(Brushes.White, path);
label_121:
        num3 = 120;
        graphics2.DrawPath(pen2, path);
label_122:
        num3 = 121;
        num4 = checked ((int) Math.Round(unchecked (0.01 * (double) width1)));
label_123:
        num3 = 122;
        brush = (Brush) new SolidBrush(Color.FromArgb(227, 29, 35));
label_124:
        num3 = 123;
        num5 = checked ((int) Math.Round(unchecked (0.727 * (double) height1)));
label_125:
        num3 = 124;
        width2 = checked ((int) Math.Round(unchecked (0.668 * (double) width1)));
label_126:
        num3 = 125;
        graphics2.FillRectangle(brush, num4, num5, width2, height2);
label_127:
        num3 = 126;
        num5 = checked ((int) Math.Round(unchecked ((double) num5 + (double) height2 / 2.0 - (double) graphics2.MeasureString("()", font7, 900).Height / 2.0)));
label_128:
        num3 = (int) sbyte.MaxValue;
        num4 = checked ((int) Math.Round(unchecked (0.025 * (double) width1)));
label_129:
        num3 = 128;
        graphics2.DrawString("(1-20)", font7, Brushes.Black, (float) num4, (float) num5);
label_130:
        num3 = 129;
        num4 = checked ((int) Math.Round(unchecked (0.607 * (double) width1)));
label_131:
        num3 = 130;
        num5 = checked ((int) Math.Round(unchecked (0.727 * (double) height1 + (double) height2 / 2.0 - (double) graphics2.MeasureString("G", font2, 500).Height / 2.1)));
label_132:
        num3 = 131;
        path.AddString("G", font2.FontFamily, 1, 84f, new Point(num4, num5), StringFormat.GenericTypographic);
label_133:
        num3 = 132;
        graphics2.FillPath(Brushes.White, path);
label_134:
        num3 = 133;
        graphics2.DrawPath(pen2, path);
label_135:
        num3 = 134;
        num4 = checked ((int) Math.Round(unchecked (0.01 * (double) width1)));
label_136:
        num3 = 135;
        num5 = checked ((int) Math.Round(unchecked (0.885 * (double) height1)));
label_137:
        num3 = 136;
        graphics2.DrawLine(pen1, 1, num5, checked (width1 - 1), num5);
label_138:
        num3 = 137;
        num5 = checked ((int) Math.Round(unchecked ((0.885 * (double) height1 - (0.727 * (double) height1 + 0.086585 * (double) height1)) / 2.0 + (0.727 * (double) height1 + 0.086585 * (double) height1) - (double) graphics2.MeasureString("Potential", font6, 500).Height / 2.0)));
label_139:
        num3 = 138;
        num4 = checked ((int) Math.Round(unchecked (0.02 * (double) width1)));
label_140:
        num3 = 139;
        graphics2.DrawString("Not energy efficient - higher running costs", font6, Brushes.Black, (float) num4, (float) num5);
label_141:
        num3 = 140;
        num5 = checked ((int) Math.Round(unchecked (23.0 / 400.0 * (double) height1 + 0.885 * (double) height1 - 0.5 * (double) graphics2.MeasureString(Country, font3, 900).Height)));
label_142:
        num3 = 141;
        num4 = checked ((int) Math.Round(unchecked (0.025 * (double) width1)));
label_143:
        num3 = 142;
        graphics2.DrawString(Country, font3, Brushes.Black, (float) num4, (float) num5);
label_144:
        num3 = 143;
        num5 = checked ((int) Math.Round(unchecked (23.0 / 400.0 * (double) height1 + 0.885 * (double) height1 - (double) graphics2.MeasureString("EU Directive", font4, 500).Height)));
label_145:
        num3 = 144;
        num4 = checked ((int) Math.Round(unchecked (0.66 * (double) width1)));
label_146:
        num3 = 145;
        graphics2.DrawString("EU Directive", font4, Brushes.Black, (float) num4, (float) num5);
label_147:
        num3 = 146;
        num5 = checked ((int) Math.Round(unchecked (23.0 / 400.0 * (double) height1 + 0.885 * (double) height1)));
label_148:
        num3 = 147;
        num4 = checked ((int) Math.Round(unchecked (0.66 * (double) width1)));
label_149:
        num3 = 148;
        graphics2.DrawString("2002/91/EC", font4, Brushes.Black, (float) num4, (float) num5);
label_150:
        num3 = 149;
        num5 = checked ((int) Math.Round(unchecked (23.0 / 400.0 * (double) height1 + 0.885 * (double) height1 - 0.52 * (double) graphics2.MeasureString(Country, font3, 900).Height)));
label_151:
        num3 = 150;
        num4 = checked ((int) Math.Round(unchecked (0.88 * (double) width1)));
label_152:
        num3 = 151;
        Point[] points = new Point[5];
label_153:
        num3 = 152;
        int num6 = 10;
label_154:
        num3 = 153;
        num6 = 10;
label_155:
        num3 = 154;
        int num7 = PotentialRating;
label_156:
        num3 = 156;
        if (num7 >= 1)
          goto label_161;
label_157:
        num3 = 157;
        float num8 = 0.727f;
label_158:
        num3 = 158;
        float num9 = 20f;
label_159:
        num3 = 159;
        float num10 = 1f;
label_160:
        num3 = 160;
        brush = (Brush) new SolidBrush(Color.FromArgb(227, 29, 35));
        goto label_196;
label_161:
        num3 = 162;
        if (num7 < 1 || num7 > 20)
          goto label_166;
label_162:
        num3 = 163;
        num8 = 0.727f;
label_163:
        num3 = 164;
        num9 = 20f;
label_164:
        num3 = 165;
        num10 = 1f;
label_165:
        num3 = 166;
        brush = (Brush) new SolidBrush(Color.FromArgb(227, 29, 35));
        goto label_196;
label_166:
        num3 = 168;
        if (num7 < 21 || num7 > 38)
          goto label_171;
label_167:
        num3 = 169;
        num8 = 0.627f;
label_168:
        num3 = 170;
        num9 = 38f;
label_169:
        num3 = 171;
        num10 = 21f;
label_170:
        num3 = 172;
        brush = (Brush) new SolidBrush(Color.FromArgb(237, 104, 35));
        goto label_196;
label_171:
        num3 = 174;
        if (num7 < 39 || num7 > 54)
          goto label_176;
label_172:
        num3 = 175;
        num8 = 0.527f;
label_173:
        num3 = 176;
        num9 = 54f;
label_174:
        num3 = 177;
        num10 = 39f;
label_175:
        num3 = 178;
        brush = (Brush) new SolidBrush(Color.FromArgb(247, 175, 29));
        goto label_196;
label_176:
        num3 = 180;
        if (num7 < 55 || num7 > 68)
          goto label_181;
label_177:
        num3 = 181;
        num8 = 0.427f;
label_178:
        num3 = 182;
        num9 = 68f;
label_179:
        num3 = 183;
        num10 = 55f;
label_180:
        num3 = 184;
        brush = (Brush) new SolidBrush(Color.FromArgb(78, 132, 196));
        goto label_196;
label_181:
        num3 = 186;
        if (num7 < 69 || num7 > 80)
          goto label_186;
label_182:
        num3 = 187;
        num8 = 0.327f;
label_183:
        num3 = 188;
        num9 = 80f;
label_184:
        num3 = 189;
        num10 = 69f;
label_185:
        num3 = 190;
        brush = (Brush) new SolidBrush(Color.FromArgb(157, 203, 60));
        goto label_196;
label_186:
        num3 = 192;
        if (num7 < 81 || num7 > 91)
          goto label_191;
label_187:
        num3 = 193;
        num8 = 0.227f;
label_188:
        num3 = 194;
        num9 = 91f;
label_189:
        num3 = 195;
        num10 = 81f;
label_190:
        num3 = 196;
        brush = (Brush) new SolidBrush(Color.FromArgb(44, 159, 41));
        goto label_196;
label_191:
        num3 = 198;
        if (num7 < 92)
          goto label_196;
label_192:
        num3 = 199;
        num8 = 0.127f;
label_193:
        num3 = 200;
        num9 = 100f;
label_194:
        num3 = 201;
        num10 = 92f;
label_195:
        num3 = 202;
        brush = (Brush) new SolidBrush(Color.FromArgb(0, (int) sbyte.MaxValue, 61));
label_196:
label_197:
        num3 = 203;
        if (PotentialRating <= 99)
          goto label_199;
label_198:
        num3 = 204;
        float a1 = (num8 + (float) (0.086585 * ((double) num9 - 98.0) / ((double) num9 - (double) num10))) * (float) height1;
        goto label_201;
label_199:
        num3 = 206;
        a1 = (num8 + (float) (0.086585 * ((double) num9 - (double) PotentialRating) / ((double) num9 - (double) num10))) * (float) height1;
label_200:
label_201:
        num3 = 208;
        if (PotentialRating <= 99)
          goto label_204;
label_202:
        num3 = 209;
        num4 = 1150;
label_203:
        num3 = 210;
        num5 = 105;
        goto label_207;
label_204:
        num3 = 212;
        num4 = checked ((int) Math.Round(unchecked (0.894 * (double) width1)));
label_205:
        num3 = 213;
        num5 = checked ((int) Math.Round(unchecked ((double) a1 - (double) graphics2.MeasureString("G", font2, 500).Height / 2.1)));
label_206:
label_207:
        num3 = 215;
        path.AddString(Conversion.Str((object) PotentialRating), font2.FontFamily, 1, 84f, new Point(num4, num5), StringFormat.GenericTypographic);
label_208:
        num3 = 216;
        graphics2.FillPath(Brushes.Black, path);
label_209:
        num3 = 217;
        graphics2.DrawPath(pen2, path);
label_210:
        num3 = 218;
        points[0].X = checked ((int) Math.Round(unchecked (0.853 * (double) width1)));
label_211:
        num3 = 219;
        points[0].Y = checked ((int) Math.Round((double) a1));
label_212:
        num3 = 220;
        points[1].X = checked ((int) Math.Round(unchecked (0.887 * (double) width1)));
label_213:
        num3 = 221;
        points[1].Y = checked ((int) Math.Round(unchecked ((double) a1 - 0.0477 * (double) height1)));
label_214:
        num3 = 222;
        points[2].X = checked ((int) Math.Round(unchecked (0.992 * (double) width1)));
label_215:
        num3 = 223;
        points[2].Y = checked ((int) Math.Round(unchecked ((double) a1 - 0.0477 * (double) height1)));
label_216:
        num3 = 224;
        points[3].X = checked ((int) Math.Round(unchecked (0.992 * (double) width1)));
label_217:
        num3 = 225;
        points[3].Y = checked ((int) Math.Round(unchecked ((double) a1 + 0.0477 * (double) height1)));
label_218:
        num3 = 226;
        points[4].X = checked ((int) Math.Round(unchecked (0.887 * (double) width1)));
label_219:
        num3 = 227;
        points[4].Y = checked ((int) Math.Round(unchecked ((double) a1 + 0.0477 * (double) height1)));
label_220:
        num3 = 228;
        graphics2.FillPolygon(brush, points);
label_221:
        num3 = 229;
        int num11 = CurrRating;
label_222:
        num3 = 231;
        if (num11 >= 1)
          goto label_227;
label_223:
        num3 = 232;
        float num12 = 0.727f;
label_224:
        num3 = 233;
        float num13 = 20f;
label_225:
        num3 = 234;
        float num14 = 1f;
label_226:
        num3 = 235;
        brush = (Brush) new SolidBrush(Color.FromArgb(227, 29, 35));
        goto label_262;
label_227:
        num3 = 237;
        if (num11 < 1 || num11 > 20)
          goto label_232;
label_228:
        num3 = 238;
        num12 = 0.727f;
label_229:
        num3 = 239;
        num13 = 20f;
label_230:
        num3 = 240;
        num14 = 1f;
label_231:
        num3 = 241;
        brush = (Brush) new SolidBrush(Color.FromArgb(227, 29, 35));
        goto label_262;
label_232:
        num3 = 243;
        if (num11 < 21 || num11 > 38)
          goto label_237;
label_233:
        num3 = 244;
        num12 = 0.627f;
label_234:
        num3 = 245;
        num13 = 38f;
label_235:
        num3 = 246;
        num14 = 21f;
label_236:
        num3 = 247;
        brush = (Brush) new SolidBrush(Color.FromArgb(237, 104, 35));
        goto label_262;
label_237:
        num3 = 249;
        if (num11 < 39 || num11 > 54)
          goto label_242;
label_238:
        num3 = 250;
        num12 = 0.527f;
label_239:
        num3 = 251;
        num13 = 54f;
label_240:
        num3 = 252;
        num14 = 39f;
label_241:
        num3 = 253;
        brush = (Brush) new SolidBrush(Color.FromArgb(247, 175, 29));
        goto label_262;
label_242:
        num3 = (int) byte.MaxValue;
        if (num11 < 55 || num11 > 68)
          goto label_247;
label_243:
        num3 = 256;
        num12 = 0.427f;
label_244:
        num3 = 257;
        num13 = 68f;
label_245:
        num3 = 258;
        num14 = 55f;
label_246:
        num3 = 259;
        brush = (Brush) new SolidBrush(Color.FromArgb((int) byte.MaxValue, 242, 0));
        goto label_262;
label_247:
        num3 = 261;
        if (num11 < 69 || num11 > 80)
          goto label_252;
label_248:
        num3 = 262;
        num12 = 0.327f;
label_249:
        num3 = 263;
        num13 = 80f;
label_250:
        num3 = 264;
        num14 = 69f;
label_251:
        num3 = 265;
        brush = (Brush) new SolidBrush(Color.FromArgb(157, 203, 60));
        goto label_262;
label_252:
        num3 = 267;
        if (num11 < 81 || num11 > 91)
          goto label_257;
label_253:
        num3 = 268;
        num12 = 0.227f;
label_254:
        num3 = 269;
        num13 = 91f;
label_255:
        num3 = 270;
        num14 = 81f;
label_256:
        num3 = 271;
        brush = (Brush) new SolidBrush(Color.FromArgb(44, 159, 41));
        goto label_262;
label_257:
        num3 = 273;
        if (num11 < 92)
          goto label_262;
label_258:
        num3 = 274;
        num12 = 0.127f;
label_259:
        num3 = 275;
        num13 = 100f;
label_260:
        num3 = 276;
        num14 = 92f;
label_261:
        num3 = 277;
        brush = (Brush) new SolidBrush(Color.FromArgb(0, (int) sbyte.MaxValue, 61));
label_262:
label_263:
        num3 = 278;
        if (CurrRating <= 99)
          goto label_265;
label_264:
        num3 = 279;
        float a2 = (num12 + (float) (0.086585 * ((double) num13 - 98.0) / ((double) num13 - (double) num14))) * (float) height1;
        goto label_267;
label_265:
        num3 = 281;
        a2 = (num12 + (float) (0.086585 * ((double) num13 - (double) CurrRating) / ((double) num13 - (double) num14))) * (float) height1;
label_266:
label_267:
        num3 = 283;
        points[0].X = checked ((int) Math.Round(unchecked (0.853 * (double) width1 - 200.0)));
label_268:
        num3 = 284;
        points[0].Y = checked ((int) Math.Round((double) a2));
label_269:
        num3 = 285;
        points[1].X = checked ((int) Math.Round(unchecked (0.887 * (double) width1 - 200.0)));
label_270:
        num3 = 286;
        points[1].Y = checked ((int) Math.Round(unchecked ((double) a2 - 0.0477 * (double) height1)));
label_271:
        num3 = 287;
        points[2].X = checked ((int) Math.Round(unchecked (0.992 * (double) width1 - 200.0)));
label_272:
        num3 = 288;
        points[2].Y = checked ((int) Math.Round(unchecked ((double) a2 - 0.0477 * (double) height1)));
label_273:
        num3 = 289;
        points[3].X = checked ((int) Math.Round(unchecked (0.992 * (double) width1 - 200.0)));
label_274:
        num3 = 290;
        points[3].Y = checked ((int) Math.Round(unchecked ((double) a2 + 0.0477 * (double) height1)));
label_275:
        num3 = 291;
        points[4].X = checked ((int) Math.Round(unchecked (0.887 * (double) width1 - 200.0)));
label_276:
        num3 = 292;
        points[4].Y = checked ((int) Math.Round(unchecked ((double) a2 + 0.0477 * (double) height1)));
label_277:
        num3 = 293;
        graphics2.FillPolygon(brush, points);
label_278:
        num3 = 294;
        if (CurrRating <= 99)
          goto label_281;
label_279:
        num3 = 295;
        num4 = 945;
label_280:
        num3 = 296;
        num5 = 105;
        goto label_284;
label_281:
        num3 = 298;
        num4 = checked ((int) Math.Round(unchecked (0.894 * (double) width1 - 200.0)));
label_282:
        num3 = 299;
        num5 = checked ((int) Math.Round(unchecked ((double) a2 - (double) graphics2.MeasureString("G", font2, 500).Height / 2.1)));
label_283:
label_284:
        num3 = 301;
        path.AddString(Conversion.Str((object) CurrRating), font2.FontFamily, 1, 84f, new Point(num4, num5), StringFormat.GenericTypographic);
label_285:
        num3 = 302;
        graphics2.FillPath(Brushes.White, path);
label_286:
        num3 = 303;
        graphics2.DrawPath(pen2, path);
label_287:
        graphics2 = (Graphics) null;
label_288:
        image = image;
        goto label_294;
label_290:
        num2 = num3;
        switch (num1 > -2 ? num1 : 1)
        {
          case 1:
            int num15 = num2 + 1;
            num2 = 0;
            switch (num15)
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
                goto label_42;
              case 42:
                goto label_43;
              case 43:
                goto label_44;
              case 44:
                goto label_45;
              case 45:
                goto label_46;
              case 46:
                goto label_47;
              case 47:
                goto label_48;
              case 48:
                goto label_49;
              case 49:
                goto label_50;
              case 50:
                goto label_51;
              case 51:
                goto label_52;
              case 52:
                goto label_53;
              case 53:
                goto label_54;
              case 54:
                goto label_55;
              case 55:
                goto label_56;
              case 56:
                goto label_57;
              case 57:
                goto label_58;
              case 58:
                goto label_59;
              case 59:
                goto label_60;
              case 60:
                goto label_61;
              case 61:
                goto label_62;
              case 62:
                goto label_63;
              case 63:
                goto label_64;
              case 64:
                goto label_65;
              case 65:
                goto label_66;
              case 66:
                goto label_67;
              case 67:
                goto label_68;
              case 68:
                goto label_69;
              case 69:
                goto label_70;
              case 70:
                goto label_71;
              case 71:
                goto label_72;
              case 72:
                goto label_73;
              case 73:
                goto label_74;
              case 74:
                goto label_75;
              case 75:
                goto label_76;
              case 76:
                goto label_77;
              case 77:
                goto label_78;
              case 78:
                goto label_79;
              case 79:
                goto label_80;
              case 80:
                goto label_81;
              case 81:
                goto label_82;
              case 82:
                goto label_83;
              case 83:
                goto label_84;
              case 84:
                goto label_85;
              case 85:
                goto label_86;
              case 86:
                goto label_87;
              case 87:
                goto label_88;
              case 88:
                goto label_89;
              case 89:
                goto label_90;
              case 90:
                goto label_91;
              case 91:
                goto label_92;
              case 92:
                goto label_93;
              case 93:
                goto label_94;
              case 94:
                goto label_95;
              case 95:
                goto label_96;
              case 96:
                goto label_97;
              case 97:
                goto label_98;
              case 98:
                goto label_99;
              case 99:
                goto label_100;
              case 100:
                goto label_101;
              case 101:
                goto label_102;
              case 102:
                goto label_103;
              case 103:
                goto label_104;
              case 104:
                goto label_105;
              case 105:
                goto label_106;
              case 106:
                goto label_107;
              case 107:
                goto label_108;
              case 108:
                goto label_109;
              case 109:
                goto label_110;
              case 110:
                goto label_111;
              case 111:
                goto label_112;
              case 112:
                goto label_113;
              case 113:
                goto label_114;
              case 114:
                goto label_115;
              case 115:
                goto label_116;
              case 116:
                goto label_117;
              case 117:
                goto label_118;
              case 118:
                goto label_119;
              case 119:
                goto label_120;
              case 120:
                goto label_121;
              case 121:
                goto label_122;
              case 122:
                goto label_123;
              case 123:
                goto label_124;
              case 124:
                goto label_125;
              case 125:
                goto label_126;
              case 126:
                goto label_127;
              case (int) sbyte.MaxValue:
                goto label_128;
              case 128:
                goto label_129;
              case 129:
                goto label_130;
              case 130:
                goto label_131;
              case 131:
                goto label_132;
              case 132:
                goto label_133;
              case 133:
                goto label_134;
              case 134:
                goto label_135;
              case 135:
                goto label_136;
              case 136:
                goto label_137;
              case 137:
                goto label_138;
              case 138:
                goto label_139;
              case 139:
                goto label_140;
              case 140:
                goto label_141;
              case 141:
                goto label_142;
              case 142:
                goto label_143;
              case 143:
                goto label_144;
              case 144:
                goto label_145;
              case 145:
                goto label_146;
              case 146:
                goto label_147;
              case 147:
                goto label_148;
              case 148:
                goto label_149;
              case 149:
                goto label_150;
              case 150:
                goto label_151;
              case 151:
                goto label_152;
              case 152:
                goto label_153;
              case 153:
                goto label_154;
              case 154:
                goto label_155;
              case 155:
              case 161:
              case 167:
              case 173:
              case 179:
              case 185:
              case 191:
              case 197:
                goto label_196;
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
              case 162:
                goto label_161;
              case 163:
                goto label_162;
              case 164:
                goto label_163;
              case 165:
                goto label_164;
              case 166:
                goto label_165;
              case 168:
                goto label_166;
              case 169:
                goto label_167;
              case 170:
                goto label_168;
              case 171:
                goto label_169;
              case 172:
                goto label_170;
              case 174:
                goto label_171;
              case 175:
                goto label_172;
              case 176:
                goto label_173;
              case 177:
                goto label_174;
              case 178:
                goto label_175;
              case 180:
                goto label_176;
              case 181:
                goto label_177;
              case 182:
                goto label_178;
              case 183:
                goto label_179;
              case 184:
                goto label_180;
              case 186:
                goto label_181;
              case 187:
                goto label_182;
              case 188:
                goto label_183;
              case 189:
                goto label_184;
              case 190:
                goto label_185;
              case 192:
                goto label_186;
              case 193:
                goto label_187;
              case 194:
                goto label_188;
              case 195:
                goto label_189;
              case 196:
                goto label_190;
              case 198:
                goto label_191;
              case 199:
                goto label_192;
              case 200:
                goto label_193;
              case 201:
                goto label_194;
              case 202:
                goto label_195;
              case 203:
                goto label_197;
              case 204:
                goto label_198;
              case 205:
              case 208:
                goto label_201;
              case 206:
                goto label_199;
              case 207:
                goto label_200;
              case 209:
                goto label_202;
              case 210:
                goto label_203;
              case 211:
              case 215:
                goto label_207;
              case 212:
                goto label_204;
              case 213:
                goto label_205;
              case 214:
                goto label_206;
              case 216:
                goto label_208;
              case 217:
                goto label_209;
              case 218:
                goto label_210;
              case 219:
                goto label_211;
              case 220:
                goto label_212;
              case 221:
                goto label_213;
              case 222:
                goto label_214;
              case 223:
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
              case 229:
                goto label_221;
              case 230:
              case 236:
              case 242:
              case 248:
              case 254:
              case 260:
              case 266:
              case 272:
                goto label_262;
              case 231:
                goto label_222;
              case 232:
                goto label_223;
              case 233:
                goto label_224;
              case 234:
                goto label_225;
              case 235:
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
                goto label_231;
              case 243:
                goto label_232;
              case 244:
                goto label_233;
              case 245:
                goto label_234;
              case 246:
                goto label_235;
              case 247:
                goto label_236;
              case 249:
                goto label_237;
              case 250:
                goto label_238;
              case 251:
                goto label_239;
              case 252:
                goto label_240;
              case 253:
                goto label_241;
              case (int) byte.MaxValue:
                goto label_242;
              case 256:
                goto label_243;
              case 257:
                goto label_244;
              case 258:
                goto label_245;
              case 259:
                goto label_246;
              case 261:
                goto label_247;
              case 262:
                goto label_248;
              case 263:
                goto label_249;
              case 264:
                goto label_250;
              case 265:
                goto label_251;
              case 267:
                goto label_252;
              case 268:
                goto label_253;
              case 269:
                goto label_254;
              case 270:
                goto label_255;
              case 271:
                goto label_256;
              case 273:
                goto label_257;
              case 274:
                goto label_258;
              case 275:
                goto label_259;
              case 276:
                goto label_260;
              case 277:
                goto label_261;
              case 278:
                goto label_263;
              case 279:
                goto label_264;
              case 280:
              case 283:
                goto label_267;
              case 281:
                goto label_265;
              case 282:
                goto label_266;
              case 284:
                goto label_268;
              case 285:
                goto label_269;
              case 286:
                goto label_270;
              case 287:
                goto label_271;
              case 288:
                goto label_272;
              case 289:
                goto label_273;
              case 290:
                goto label_274;
              case 291:
                goto label_275;
              case 292:
                goto label_276;
              case 293:
                goto label_277;
              case 294:
                goto label_278;
              case 295:
                goto label_279;
              case 296:
                goto label_280;
              case 297:
              case 301:
                goto label_284;
              case 298:
                goto label_281;
              case 299:
                goto label_282;
              case 300:
                goto label_283;
              case 302:
                goto label_285;
              case 303:
                goto label_286;
              case 304:
                goto label_287;
              case 305:
                goto label_288;
              case 306:
                goto label_294;
            }
            break;
        }
      }
      catch (Exception ex) when (ex is Exception & (uint) num1 > 0U & num2 == 0)
      {
        ProjectData.SetProjectError(ex);
        goto label_290;
      }
      throw ProjectData.CreateProjectError(-2146828237);
label_294:
      if (num2 != 0)
        ProjectData.ClearProjectError();
      return image;
    }
  }
}
