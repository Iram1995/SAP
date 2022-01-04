
// Type: SAP2012.RoofWindows




using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using SAP2012.My;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SAP2012
{
  [DesignerGenerated]
  public class RoofWindows : Form
  {
    private IContainer components;

    public RoofWindows()
    {
      this.FormClosing += new FormClosingEventHandler(this.RoofWindows_FormClosing);
      this.Load += new EventHandler(this.Windows_Load);
      this.InitializeComponent();
    }

    [DebuggerNonUserCode]
    protected override void Dispose(bool disposing)
    {
      try
      {
        if (!disposing || this.components == null)
          return;
        this.components.Dispose();
      }
      finally
      {
        base.Dispose(disposing);
      }
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.components = (IContainer) new System.ComponentModel.Container();
      this.GroupBox5 = new GroupBox();
      this.txtU = new TextBox();
      this.txtFF = new TextBox();
      this.txtg = new TextBox();
      this.Label19 = new Label();
      this.Label18 = new Label();
      this.Label16 = new Label();
      this.Label17 = new Label();
      this.GroupBox4 = new GroupBox();
      this.txtFractionC = new NumericUpDown();
      this.txtCurtainType = new ComboBox();
      this.Label15 = new Label();
      this.Label7 = new Label();
      this.GroupBox3 = new GroupBox();
      this.Label22 = new Label();
      this.Label4 = new Label();
      this.txtHeight = new ComboBox();
      this.txtWidth = new ComboBox();
      this.Label24 = new Label();
      this.Label23 = new Label();
      this.Label25 = new Label();
      this.txtOverDepth = new TextBox();
      this.txtOverWidth = new TextBox();
      this.txtCount = new NumericUpDown();
      this.txtArea = new TextBox();
      this.Label13 = new Label();
      this.Label14 = new Label();
      this.Label12 = new Label();
      this.Label8 = new Label();
      this.Label9 = new Label();
      this.Label10 = new Label();
      this.GroupBox2 = new GroupBox();
      this.txtFrameType = new ComboBox();
      this.txtThermalBreak = new ComboBox();
      this.Label5 = new Label();
      this.Label6 = new Label();
      this.GroupBox1 = new GroupBox();
      this.txtLocation = new ComboBox();
      this.txtUSource = new ComboBox();
      this.txtName = new TextBox();
      this.txtOvershading = new ComboBox();
      this.txtOrientation = new ComboBox();
      this.txtPitch = new TextBox();
      this.Label21 = new Label();
      this.Label20 = new Label();
      this.Label11 = new Label();
      this.Label1 = new Label();
      this.Label2 = new Label();
      this.Label3 = new Label();
      this.GroupBox15 = new GroupBox();
      this.txtAirGap = new ComboBox();
      this.txtGlazingType = new ComboBox();
      this.Label50 = new Label();
      this.Label52 = new Label();
      this.cmdCancel = new Button();
      this.cmdOK = new Button();
      this.GroupBox6 = new GroupBox();
      this.cboWindowSelect = new ComboBox();
      this.Label26 = new Label();
      this.cmdPrevious = new Button();
      this.cmdNext = new Button();
      this.cmdNew = new Button();
      this.Button1 = new Button();
      this.ErrorPChecker = new ErrorProvider(this.components);
      this.GroupBox5.SuspendLayout();
      this.GroupBox4.SuspendLayout();
      this.txtFractionC.BeginInit();
      this.GroupBox3.SuspendLayout();
      this.txtCount.BeginInit();
      this.GroupBox2.SuspendLayout();
      this.GroupBox1.SuspendLayout();
      this.GroupBox15.SuspendLayout();
      this.GroupBox6.SuspendLayout();
      ((ISupportInitialize) this.ErrorPChecker).BeginInit();
      this.SuspendLayout();
      this.GroupBox5.Controls.Add((Control) this.txtU);
      this.GroupBox5.Controls.Add((Control) this.txtFF);
      this.GroupBox5.Controls.Add((Control) this.txtg);
      this.GroupBox5.Controls.Add((Control) this.Label19);
      this.GroupBox5.Controls.Add((Control) this.Label18);
      this.GroupBox5.Controls.Add((Control) this.Label16);
      this.GroupBox5.Controls.Add((Control) this.Label17);
      this.GroupBox5.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.GroupBox5.Location = new Point(276, 334);
      this.GroupBox5.Name = "GroupBox5";
      this.GroupBox5.Size = new Size(297, 113);
      this.GroupBox5.TabIndex = 5;
      this.GroupBox5.TabStop = false;
      this.GroupBox5.Text = "Roof Light Properties";
      this.txtU.Location = new Point(172, 76);
      this.txtU.Name = "txtU";
      this.txtU.Size = new Size(67, 22);
      this.txtU.TabIndex = 2;
      this.txtU.TextAlign = HorizontalAlignment.Right;
      this.txtFF.Location = new Point(172, 48);
      this.txtFF.Name = "txtFF";
      this.txtFF.Size = new Size(67, 22);
      this.txtFF.TabIndex = 1;
      this.txtFF.TextAlign = HorizontalAlignment.Right;
      this.txtg.Location = new Point(172, 20);
      this.txtg.Name = "txtg";
      this.txtg.Size = new Size(67, 22);
      this.txtg.TabIndex = 0;
      this.txtg.TextAlign = HorizontalAlignment.Right;
      this.Label19.AutoSize = true;
      this.Label19.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label19.Location = new Point(245, 80);
      this.Label19.Name = "Label19";
      this.Label19.Size = new Size(47, 14);
      this.Label19.TabIndex = 27;
      this.Label19.Text = "W/m\u00B2K";
      this.Label18.AutoSize = true;
      this.Label18.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label18.Location = new Point(12, 80);
      this.Label18.Name = "Label18";
      this.Label18.Size = new Size(49, 14);
      this.Label18.TabIndex = 23;
      this.Label18.Text = "U-Value";
      this.Label16.AutoSize = true;
      this.Label16.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label16.Location = new Point(10, 52);
      this.Label16.Name = "Label16";
      this.Label16.Size = new Size(98, 14);
      this.Label16.TabIndex = 22;
      this.Label16.Text = "Frame factor 'FF'";
      this.Label17.AutoSize = true;
      this.Label17.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label17.Location = new Point(10, 24);
      this.Label17.Name = "Label17";
      this.Label17.Size = new Size(138, 14);
      this.Label17.TabIndex = 20;
      this.Label17.Text = "Transmittance factor 'g'";
      this.GroupBox4.Controls.Add((Control) this.txtFractionC);
      this.GroupBox4.Controls.Add((Control) this.txtCurtainType);
      this.GroupBox4.Controls.Add((Control) this.Label15);
      this.GroupBox4.Controls.Add((Control) this.Label7);
      this.GroupBox4.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.GroupBox4.Location = new Point(276, 214);
      this.GroupBox4.Name = "GroupBox4";
      this.GroupBox4.Size = new Size(297, 114);
      this.GroupBox4.TabIndex = 4;
      this.GroupBox4.TabStop = false;
      this.GroupBox4.Text = "Curtain Details";
      this.txtFractionC.DecimalPlaces = 2;
      this.txtFractionC.Increment = new Decimal(new int[4]
      {
        5,
        0,
        0,
        131072
      });
      this.txtFractionC.Location = new Point(113, 52);
      this.txtFractionC.Maximum = new Decimal(new int[4]
      {
        1,
        0,
        0,
        0
      });
      this.txtFractionC.Name = "txtFractionC";
      this.txtFractionC.Size = new Size(57, 22);
      this.txtFractionC.TabIndex = 1;
      this.txtFractionC.Value = new Decimal(new int[4]
      {
        1,
        0,
        0,
        0
      });
      this.txtCurtainType.Cursor = Cursors.Hand;
      this.txtCurtainType.DropDownWidth = 300;
      this.txtCurtainType.FormattingEnabled = true;
      this.txtCurtainType.Items.AddRange(new object[7]
      {
        (object) "None",
        (object) "Net curtain (covering whole window)",
        (object) "Net curtain (covering half window)",
        (object) "Dark-coloured curtain or roller blind",
        (object) "Light-coloured curtain or roller blind",
        (object) "Dark-coloured venetian blind",
        (object) "Light-coloured venetian blind"
      });
      this.txtCurtainType.Location = new Point(113, 22);
      this.txtCurtainType.Name = "txtCurtainType";
      this.txtCurtainType.Size = new Size(126, 22);
      this.txtCurtainType.TabIndex = 0;
      this.Label15.AutoSize = true;
      this.Label15.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label15.Location = new Point(10, 54);
      this.Label15.Name = "Label15";
      this.Label15.Size = new Size(100, 28);
      this.Label15.TabIndex = 22;
      this.Label15.Text = "Fraction curtains \r\nclosed";
      this.Label7.AutoSize = true;
      this.Label7.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label7.Location = new Point(10, 25);
      this.Label7.Name = "Label7";
      this.Label7.Size = new Size(77, 14);
      this.Label7.TabIndex = 20;
      this.Label7.Text = "Curtain Type";
      this.GroupBox3.Controls.Add((Control) this.Label22);
      this.GroupBox3.Controls.Add((Control) this.Label4);
      this.GroupBox3.Controls.Add((Control) this.txtHeight);
      this.GroupBox3.Controls.Add((Control) this.txtWidth);
      this.GroupBox3.Controls.Add((Control) this.Label24);
      this.GroupBox3.Controls.Add((Control) this.Label23);
      this.GroupBox3.Controls.Add((Control) this.Label25);
      this.GroupBox3.Controls.Add((Control) this.txtOverDepth);
      this.GroupBox3.Controls.Add((Control) this.txtOverWidth);
      this.GroupBox3.Controls.Add((Control) this.txtCount);
      this.GroupBox3.Controls.Add((Control) this.txtArea);
      this.GroupBox3.Controls.Add((Control) this.Label13);
      this.GroupBox3.Controls.Add((Control) this.Label14);
      this.GroupBox3.Controls.Add((Control) this.Label12);
      this.GroupBox3.Controls.Add((Control) this.Label8);
      this.GroupBox3.Controls.Add((Control) this.Label9);
      this.GroupBox3.Controls.Add((Control) this.Label10);
      this.GroupBox3.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.GroupBox3.Location = new Point(276, 12);
      this.GroupBox3.Name = "GroupBox3";
      this.GroupBox3.Size = new Size(297, 196);
      this.GroupBox3.TabIndex = 3;
      this.GroupBox3.TabStop = false;
      this.GroupBox3.Text = "Size";
      this.Label22.AutoSize = true;
      this.Label22.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label22.Location = new Point(245, 85);
      this.Label22.Name = "Label22";
      this.Label22.Size = new Size(27, 14);
      this.Label22.TabIndex = 42;
      this.Label22.Text = "mm";
      this.Label4.AutoSize = true;
      this.Label4.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label4.Location = new Point(245, 57);
      this.Label4.Name = "Label4";
      this.Label4.Size = new Size(27, 14);
      this.Label4.TabIndex = 41;
      this.Label4.Text = "mm";
      this.txtHeight.Cursor = Cursors.Hand;
      this.txtHeight.FormattingEnabled = true;
      this.txtHeight.Items.AddRange(new object[5]
      {
        (object) "750",
        (object) "900",
        (object) "1050",
        (object) "1200",
        (object) "1350"
      });
      this.txtHeight.Location = new Point(109, 77);
      this.txtHeight.Name = "txtHeight";
      this.txtHeight.Size = new Size(130, 22);
      this.txtHeight.TabIndex = 40;
      this.txtWidth.Cursor = Cursors.Hand;
      this.txtWidth.FormattingEnabled = true;
      this.txtWidth.Items.AddRange(new object[4]
      {
        (object) "488",
        (object) "915",
        (object) "1342",
        (object) "1770"
      });
      this.txtWidth.Location = new Point(109, 49);
      this.txtWidth.Name = "txtWidth";
      this.txtWidth.Size = new Size(130, 22);
      this.txtWidth.TabIndex = 39;
      this.Label24.AutoSize = true;
      this.Label24.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label24.Location = new Point(245, 169);
      this.Label24.Name = "Label24";
      this.Label24.Size = new Size(27, 14);
      this.Label24.TabIndex = 38;
      this.Label24.Text = "mm";
      this.Label23.AutoSize = true;
      this.Label23.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label23.Location = new Point(245, 141);
      this.Label23.Name = "Label23";
      this.Label23.Size = new Size(27, 14);
      this.Label23.TabIndex = 37;
      this.Label23.Text = "mm";
      this.Label25.AutoSize = true;
      this.Label25.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label25.Location = new Point(245, 29);
      this.Label25.Name = "Label25";
      this.Label25.Size = new Size(23, 14);
      this.Label25.TabIndex = 34;
      this.Label25.Text = "m\u00B2";
      this.txtOverDepth.Location = new Point(109, 161);
      this.txtOverDepth.Name = "txtOverDepth";
      this.txtOverDepth.Size = new Size(130, 22);
      this.txtOverDepth.TabIndex = 5;
      this.txtOverWidth.Location = new Point(109, 133);
      this.txtOverWidth.Name = "txtOverWidth";
      this.txtOverWidth.Size = new Size(130, 22);
      this.txtOverWidth.TabIndex = 4;
      this.txtCount.Location = new Point(109, 105);
      this.txtCount.Minimum = new Decimal(new int[4]
      {
        1,
        0,
        0,
        0
      });
      this.txtCount.Name = "txtCount";
      this.txtCount.Size = new Size(57, 22);
      this.txtCount.TabIndex = 3;
      this.txtCount.Value = new Decimal(new int[4]
      {
        1,
        0,
        0,
        0
      });
      this.txtArea.Location = new Point(109, 21);
      this.txtArea.Name = "txtArea";
      this.txtArea.Size = new Size(130, 22);
      this.txtArea.TabIndex = 0;
      this.Label13.AutoSize = true;
      this.Label13.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label13.Location = new Point(6, 164);
      this.Label13.Name = "Label13";
      this.Label13.Size = new Size(98, 14);
      this.Label13.TabIndex = 23;
      this.Label13.Text = "Overhang Depth";
      this.Label14.AutoSize = true;
      this.Label14.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label14.Location = new Point(6, 136);
      this.Label14.Name = "Label14";
      this.Label14.Size = new Size(97, 14);
      this.Label14.TabIndex = 21;
      this.Label14.Text = "Overhang Width";
      this.Label12.AutoSize = true;
      this.Label12.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label12.Location = new Point(6, 107);
      this.Label12.Name = "Label12";
      this.Label12.Size = new Size(40, 14);
      this.Label12.TabIndex = 19;
      this.Label12.Text = "Count";
      this.Label8.AutoSize = true;
      this.Label8.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label8.Location = new Point(6, 80);
      this.Label8.Name = "Label8";
      this.Label8.Size = new Size(43, 14);
      this.Label8.TabIndex = 13;
      this.Label8.Text = "Height";
      this.Label9.AutoSize = true;
      this.Label9.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label9.Location = new Point(6, 52);
      this.Label9.Name = "Label9";
      this.Label9.Size = new Size(40, 14);
      this.Label9.TabIndex = 4;
      this.Label9.Text = "Width";
      this.Label10.AutoSize = true;
      this.Label10.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label10.Location = new Point(6, 25);
      this.Label10.Name = "Label10";
      this.Label10.Size = new Size(32, 14);
      this.Label10.TabIndex = 2;
      this.Label10.Text = "Area";
      this.GroupBox2.Controls.Add((Control) this.txtFrameType);
      this.GroupBox2.Controls.Add((Control) this.txtThermalBreak);
      this.GroupBox2.Controls.Add((Control) this.Label5);
      this.GroupBox2.Controls.Add((Control) this.Label6);
      this.GroupBox2.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.GroupBox2.Location = new Point(12, 305);
      this.GroupBox2.Name = "GroupBox2";
      this.GroupBox2.Size = new Size(258, 82);
      this.GroupBox2.TabIndex = 2;
      this.GroupBox2.TabStop = false;
      this.GroupBox2.Text = "Frame";
      this.txtFrameType.Cursor = Cursors.Hand;
      this.txtFrameType.FormattingEnabled = true;
      this.txtFrameType.Items.AddRange(new object[4]
      {
        (object) "Wood",
        (object) "Metal",
        (object) "Metal, thermal break",
        (object) "PVC-U"
      });
      this.txtFrameType.Location = new Point(109, 21);
      this.txtFrameType.Name = "txtFrameType";
      this.txtFrameType.Size = new Size(130, 22);
      this.txtFrameType.TabIndex = 0;
      this.txtThermalBreak.Cursor = Cursors.Hand;
      this.txtThermalBreak.FormattingEnabled = true;
      this.txtThermalBreak.Items.AddRange(new object[5]
      {
        (object) "4mm",
        (object) "8mm",
        (object) "12mm",
        (object) "20mm",
        (object) "32mm"
      });
      this.txtThermalBreak.Location = new Point(109, 49);
      this.txtThermalBreak.Name = "txtThermalBreak";
      this.txtThermalBreak.Size = new Size(130, 22);
      this.txtThermalBreak.TabIndex = 1;
      this.Label5.AutoSize = true;
      this.Label5.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label5.Location = new Point(6, 52);
      this.Label5.Name = "Label5";
      this.Label5.Size = new Size(85, 14);
      this.Label5.TabIndex = 4;
      this.Label5.Text = "Thermal break";
      this.Label6.AutoSize = true;
      this.Label6.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label6.Location = new Point(6, 25);
      this.Label6.Name = "Label6";
      this.Label6.Size = new Size(35, 14);
      this.Label6.TabIndex = 2;
      this.Label6.Text = "Type";
      this.GroupBox1.Controls.Add((Control) this.txtLocation);
      this.GroupBox1.Controls.Add((Control) this.txtUSource);
      this.GroupBox1.Controls.Add((Control) this.txtName);
      this.GroupBox1.Controls.Add((Control) this.txtOvershading);
      this.GroupBox1.Controls.Add((Control) this.txtOrientation);
      this.GroupBox1.Controls.Add((Control) this.txtPitch);
      this.GroupBox1.Controls.Add((Control) this.Label21);
      this.GroupBox1.Controls.Add((Control) this.Label20);
      this.GroupBox1.Controls.Add((Control) this.Label11);
      this.GroupBox1.Controls.Add((Control) this.Label1);
      this.GroupBox1.Controls.Add((Control) this.Label2);
      this.GroupBox1.Controls.Add((Control) this.Label3);
      this.GroupBox1.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.GroupBox1.Location = new Point(12, 12);
      this.GroupBox1.Name = "GroupBox1";
      this.GroupBox1.Size = new Size(258, 196);
      this.GroupBox1.TabIndex = 0;
      this.GroupBox1.TabStop = false;
      this.GroupBox1.Text = "General";
      this.txtLocation.Cursor = Cursors.Hand;
      this.txtLocation.DropDownWidth = 250;
      this.txtLocation.FormattingEnabled = true;
      this.txtLocation.Items.AddRange(new object[3]
      {
        (object) "SAP 2005",
        (object) "Manufacturer",
        (object) "BFRC"
      });
      this.txtLocation.Location = new Point(109, 49);
      this.txtLocation.Name = "txtLocation";
      this.txtLocation.Size = new Size(130, 22);
      this.txtLocation.TabIndex = 1;
      this.txtUSource.Cursor = Cursors.Hand;
      this.txtUSource.FormattingEnabled = true;
      this.txtUSource.Items.AddRange(new object[3]
      {
        (object) "SAP 2012",
        (object) "Manufacturer",
        (object) "BFRC"
      });
      this.txtUSource.Location = new Point(109, 77);
      this.txtUSource.Name = "txtUSource";
      this.txtUSource.Size = new Size(130, 22);
      this.txtUSource.TabIndex = 2;
      this.txtName.Location = new Point(109, 21);
      this.txtName.Name = "txtName";
      this.txtName.Size = new Size(130, 22);
      this.txtName.TabIndex = 0;
      this.txtOvershading.Cursor = Cursors.Hand;
      this.txtOvershading.FormattingEnabled = true;
      this.txtOvershading.Items.AddRange(new object[4]
      {
        (object) "Heavy",
        (object) "More than average",
        (object) "Average or unknown",
        (object) "Very Little"
      });
      this.txtOvershading.Location = new Point(109, 161);
      this.txtOvershading.Name = "txtOvershading";
      this.txtOvershading.Size = new Size(130, 22);
      this.txtOvershading.TabIndex = 5;
      this.txtOrientation.Cursor = Cursors.Hand;
      this.txtOrientation.FormattingEnabled = true;
      this.txtOrientation.Items.AddRange(new object[12]
      {
        (object) "",
        (object) "Unspecified",
        (object) "North",
        (object) "North East",
        (object) "East",
        (object) "South East",
        (object) "South",
        (object) "South West",
        (object) "West",
        (object) "North West",
        (object) "Horizontal",
        (object) "Worst case"
      });
      this.txtOrientation.Location = new Point(109, 133);
      this.txtOrientation.Name = "txtOrientation";
      this.txtOrientation.Size = new Size(130, 22);
      this.txtOrientation.TabIndex = 4;
      this.txtPitch.Location = new Point(109, 105);
      this.txtPitch.Name = "txtPitch";
      this.txtPitch.Size = new Size(130, 22);
      this.txtPitch.TabIndex = 3;
      this.Label21.AutoSize = true;
      this.Label21.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label21.Location = new Point(6, 108);
      this.Label21.Name = "Label21";
      this.Label21.Size = new Size(34, 14);
      this.Label21.TabIndex = 24;
      this.Label21.Text = "Pitch";
      this.Label20.AutoSize = true;
      this.Label20.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label20.Location = new Point(6, 52);
      this.Label20.Name = "Label20";
      this.Label20.Size = new Size(106, 14);
      this.Label20.TabIndex = 22;
      this.Label20.Text = "Window Location ";
      this.Label11.AutoSize = true;
      this.Label11.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label11.Location = new Point(6, 80);
      this.Label11.Name = "Label11";
      this.Label11.Size = new Size(91, 14);
      this.Label11.TabIndex = 20;
      this.Label11.Text = "U-Value Source";
      this.Label1.AutoSize = true;
      this.Label1.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label1.Location = new Point(6, 164);
      this.Label1.Name = "Label1";
      this.Label1.Size = new Size(74, 14);
      this.Label1.TabIndex = 13;
      this.Label1.Text = "Overshading";
      this.Label2.AutoSize = true;
      this.Label2.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label2.Location = new Point(6, 136);
      this.Label2.Name = "Label2";
      this.Label2.Size = new Size(68, 14);
      this.Label2.TabIndex = 4;
      this.Label2.Text = "Orientation";
      this.Label3.AutoSize = true;
      this.Label3.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label3.Location = new Point(6, 25);
      this.Label3.Name = "Label3";
      this.Label3.Size = new Size(38, 14);
      this.Label3.TabIndex = 2;
      this.Label3.Text = "Name";
      this.GroupBox15.Controls.Add((Control) this.txtAirGap);
      this.GroupBox15.Controls.Add((Control) this.txtGlazingType);
      this.GroupBox15.Controls.Add((Control) this.Label50);
      this.GroupBox15.Controls.Add((Control) this.Label52);
      this.GroupBox15.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.GroupBox15.Location = new Point(12, 214);
      this.GroupBox15.Name = "GroupBox15";
      this.GroupBox15.Size = new Size(258, 85);
      this.GroupBox15.TabIndex = 1;
      this.GroupBox15.TabStop = false;
      this.GroupBox15.Text = "Glazing Style";
      this.txtAirGap.Cursor = Cursors.Hand;
      this.txtAirGap.FormattingEnabled = true;
      this.txtAirGap.Items.AddRange(new object[3]
      {
        (object) "6mm",
        (object) "12mm",
        (object) "16mm or more "
      });
      this.txtAirGap.Location = new Point(109, 49);
      this.txtAirGap.Name = "txtAirGap";
      this.txtAirGap.Size = new Size(130, 22);
      this.txtAirGap.TabIndex = 1;
      this.txtGlazingType.Cursor = Cursors.Hand;
      this.txtGlazingType.DropDownWidth = 350;
      this.txtGlazingType.FormattingEnabled = true;
      this.txtGlazingType.Items.AddRange(new object[22]
      {
        (object) "Single-glazed",
        (object) "Secondary glazing",
        (object) "double-glazed, air filled",
        (object) "double-glazed, air filled (low-E, En = 0.2, hard coat)",
        (object) "double-glazed, air filled (low-E, En = 0.15, hard coat)",
        (object) "double-glazed, air filled (low-E, En = 0.1, soft coat)",
        (object) "double-glazed, air filled (low-E, En = 0.05, soft coat)",
        (object) "double-glazed, argon filled",
        (object) "double-glazed, argon filled (low-E, En = 0.2, hard coat)",
        (object) "double-glazed, argon filled (low-E, En = 0.15, hard coat)",
        (object) "double-glazed, argon filled (low-E, En = 0.1, soft coat)",
        (object) "double-glazed, argon filled (low-E, En = 0.05, soft coat)",
        (object) "triple-glazed, air filled",
        (object) "triple-glazed, air filled (low-E, En = 0.2, hard coat)",
        (object) "triple-glazed, air filled (low-E, En = 0.15, hard coat)",
        (object) "triple-glazed, air filled (low-E, En = 0.1, soft coat)",
        (object) "triple-glazed, air filled (low-E, En = 0.05, soft coat)",
        (object) "triple-glazed, argon filled",
        (object) "triple-glazed, argon filled (low-E, En = 0.2, hard coat)",
        (object) "triple-glazed, argon filled (low-E, En = 0.15, hard coat)",
        (object) "triple-glazed, argon filled (low-E, En = 0.1, soft coat)",
        (object) "triple-glazed, argon filled (low-E, En = 0.05, soft coat)"
      });
      this.txtGlazingType.Location = new Point(109, 21);
      this.txtGlazingType.Name = "txtGlazingType";
      this.txtGlazingType.Size = new Size(130, 22);
      this.txtGlazingType.TabIndex = 0;
      this.Label50.AutoSize = true;
      this.Label50.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label50.Location = new Point(6, 46);
      this.Label50.Name = "Label50";
      this.Label50.Size = new Size(46, 14);
      this.Label50.TabIndex = 13;
      this.Label50.Text = "Air Gap";
      this.Label52.AutoSize = true;
      this.Label52.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label52.Location = new Point(6, 24);
      this.Label52.Name = "Label52";
      this.Label52.Size = new Size(76, 14);
      this.Label52.TabIndex = 4;
      this.Label52.Text = "Glazing Type";
      this.cmdCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.cmdCancel.BackColor = Color.LightSlateGray;
      this.cmdCancel.Cursor = Cursors.Hand;
      this.cmdCancel.DialogResult = DialogResult.Cancel;
      this.cmdCancel.FlatStyle = FlatStyle.Popup;
      this.cmdCancel.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.cmdCancel.ForeColor = Color.White;
      this.cmdCancel.Location = new Point(469, 482);
      this.cmdCancel.Name = "cmdCancel";
      this.cmdCancel.Size = new Size(104, 23);
      this.cmdCancel.TabIndex = 1;
      this.cmdCancel.Text = "Cancel";
      this.cmdCancel.UseVisualStyleBackColor = false;
      this.cmdOK.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.cmdOK.BackColor = Color.LightSlateGray;
      this.cmdOK.Cursor = Cursors.Hand;
      this.cmdOK.FlatStyle = FlatStyle.Popup;
      this.cmdOK.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.cmdOK.ForeColor = Color.White;
      this.cmdOK.Location = new Point(469, 453);
      this.cmdOK.Name = "cmdOK";
      this.cmdOK.Size = new Size(104, 23);
      this.cmdOK.TabIndex = 0;
      this.cmdOK.Text = "OK";
      this.cmdOK.UseVisualStyleBackColor = false;
      this.GroupBox6.Controls.Add((Control) this.cboWindowSelect);
      this.GroupBox6.Controls.Add((Control) this.Label26);
      this.GroupBox6.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.GroupBox6.Location = new Point(12, 393);
      this.GroupBox6.Name = "GroupBox6";
      this.GroupBox6.Size = new Size(254, 57);
      this.GroupBox6.TabIndex = 7;
      this.GroupBox6.TabStop = false;
      this.GroupBox6.Text = "Copy Details From Another Roof Window";
      this.cboWindowSelect.Cursor = Cursors.Hand;
      this.cboWindowSelect.DropDownHeight = 100;
      this.cboWindowSelect.DropDownWidth = 250;
      this.cboWindowSelect.FormattingEnabled = true;
      this.cboWindowSelect.IntegralHeight = false;
      this.cboWindowSelect.Items.AddRange(new object[22]
      {
        (object) "Single-glazed",
        (object) "Secondary glazing",
        (object) "double-glazed, air filled",
        (object) "double-glazed, air filled (low-E, En = 0.2, hard coat)",
        (object) "double-glazed, air filled (low-E, En = 0.15, hard coat)",
        (object) "double-glazed, air filled (low-E, En = 0.1, soft coat)",
        (object) "double-glazed, air filled (low-E, En = 0.05, soft coat)",
        (object) "double-glazed, argon filled",
        (object) "double-glazed, argon filled (low-E, En = 0.2, hard coat)",
        (object) "double-glazed, argon filled (low-E, En = 0.15, hard coat)",
        (object) "double-glazed, argon filled (low-E, En = 0.1, soft coat)",
        (object) "double-glazed, argon filled (low-E, En = 0.05, soft coat)",
        (object) "triple-glazed, air filled",
        (object) "triple-glazed, air filled (low-E, En = 0.2, hard coat)",
        (object) "triple-glazed, air filled (low-E, En = 0.15, hard coat)",
        (object) "triple-glazed, air filled (low-E, En = 0.1, soft coat)",
        (object) "triple-glazed, air filled (low-E, En = 0.05, soft coat)",
        (object) "triple-glazed, argon filled",
        (object) "triple-glazed, argon filled (low-E, En = 0.2, hard coat)",
        (object) "triple-glazed, argon filled (low-E, En = 0.15, hard coat)",
        (object) "triple-glazed, argon filled (low-E, En = 0.1, soft coat)",
        (object) "triple-glazed, argon filled (low-E, En = 0.05, soft coat)"
      });
      this.cboWindowSelect.Location = new Point(109, 21);
      this.cboWindowSelect.Name = "cboWindowSelect";
      this.cboWindowSelect.Size = new Size(130, 22);
      this.cboWindowSelect.TabIndex = 0;
      this.Label26.AutoSize = true;
      this.Label26.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label26.Location = new Point(6, 24);
      this.Label26.Name = "Label26";
      this.Label26.Size = new Size(90, 14);
      this.Label26.TabIndex = 4;
      this.Label26.Text = "Select Window";
      this.cmdPrevious.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.cmdPrevious.BackColor = Color.LightSlateGray;
      this.cmdPrevious.Cursor = Cursors.Hand;
      this.cmdPrevious.FlatStyle = FlatStyle.Popup;
      this.cmdPrevious.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.cmdPrevious.ForeColor = Color.White;
      this.cmdPrevious.Location = new Point(12, 453);
      this.cmdPrevious.Name = "cmdPrevious";
      this.cmdPrevious.Size = new Size(104, 23);
      this.cmdPrevious.TabIndex = 10;
      this.cmdPrevious.Text = "Previous";
      this.cmdPrevious.UseVisualStyleBackColor = false;
      this.cmdNext.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.cmdNext.BackColor = Color.LightSlateGray;
      this.cmdNext.Cursor = Cursors.Hand;
      this.cmdNext.FlatStyle = FlatStyle.Popup;
      this.cmdNext.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.cmdNext.ForeColor = Color.White;
      this.cmdNext.Location = new Point(12, 482);
      this.cmdNext.Name = "cmdNext";
      this.cmdNext.Size = new Size(104, 23);
      this.cmdNext.TabIndex = 9;
      this.cmdNext.Text = "Next";
      this.cmdNext.UseVisualStyleBackColor = false;
      this.cmdNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.cmdNew.BackColor = Color.LightSlateGray;
      this.cmdNew.Cursor = Cursors.Hand;
      this.cmdNew.FlatStyle = FlatStyle.Popup;
      this.cmdNew.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.cmdNew.ForeColor = Color.White;
      this.cmdNew.Location = new Point(249, 453);
      this.cmdNew.Name = "cmdNew";
      this.cmdNew.Size = new Size(104, 23);
      this.cmdNew.TabIndex = 11;
      this.cmdNew.Text = "New";
      this.cmdNew.UseVisualStyleBackColor = false;
      this.Button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.Button1.BackColor = Color.LightSlateGray;
      this.Button1.Cursor = Cursors.Hand;
      this.Button1.FlatStyle = FlatStyle.Popup;
      this.Button1.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button1.ForeColor = Color.White;
      this.Button1.Location = new Point(244, 482);
      this.Button1.Name = "Button1";
      this.Button1.Size = new Size(114, 23);
      this.Button1.TabIndex = 12;
      this.Button1.Text = "Copy This Roof Light";
      this.Button1.UseVisualStyleBackColor = false;
      this.ErrorPChecker.BlinkStyle = ErrorBlinkStyle.NeverBlink;
      this.ErrorPChecker.ContainerControl = (ContainerControl) this;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.White;
      this.ClientSize = new Size(584, 512);
      this.Controls.Add((Control) this.Button1);
      this.Controls.Add((Control) this.cmdNew);
      this.Controls.Add((Control) this.cmdPrevious);
      this.Controls.Add((Control) this.cmdNext);
      this.Controls.Add((Control) this.GroupBox6);
      this.Controls.Add((Control) this.GroupBox5);
      this.Controls.Add((Control) this.GroupBox4);
      this.Controls.Add((Control) this.GroupBox3);
      this.Controls.Add((Control) this.GroupBox2);
      this.Controls.Add((Control) this.GroupBox1);
      this.Controls.Add((Control) this.GroupBox15);
      this.Controls.Add((Control) this.cmdCancel);
      this.Controls.Add((Control) this.cmdOK);
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.Name = nameof (RoofWindows);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Roof Lights";
      this.GroupBox5.ResumeLayout(false);
      this.GroupBox5.PerformLayout();
      this.GroupBox4.ResumeLayout(false);
      this.GroupBox4.PerformLayout();
      this.txtFractionC.EndInit();
      this.GroupBox3.ResumeLayout(false);
      this.GroupBox3.PerformLayout();
      this.txtCount.EndInit();
      this.GroupBox2.ResumeLayout(false);
      this.GroupBox2.PerformLayout();
      this.GroupBox1.ResumeLayout(false);
      this.GroupBox1.PerformLayout();
      this.GroupBox15.ResumeLayout(false);
      this.GroupBox15.PerformLayout();
      this.GroupBox6.ResumeLayout(false);
      this.GroupBox6.PerformLayout();
      ((ISupportInitialize) this.ErrorPChecker).EndInit();
      this.ResumeLayout(false);
    }

    [field: AccessedThroughProperty("GroupBox5")]
    internal virtual GroupBox GroupBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label19")]
    internal virtual Label Label19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label18")]
    internal virtual Label Label18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label16")]
    internal virtual Label Label16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label17")]
    internal virtual Label Label17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox4")]
    internal virtual GroupBox GroupBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label15")]
    internal virtual Label Label15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label7")]
    internal virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox3")]
    internal virtual GroupBox GroupBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label13")]
    internal virtual Label Label13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label14")]
    internal virtual Label Label14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label12")]
    internal virtual Label Label12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label8")]
    internal virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label9")]
    internal virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label10")]
    internal virtual Label Label10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox2")]
    internal virtual GroupBox GroupBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label5")]
    internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label6")]
    internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox1")]
    internal virtual GroupBox GroupBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label20")]
    internal virtual Label Label20 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label11")]
    internal virtual Label Label11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label1")]
    internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label2")]
    internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label3")]
    internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox15")]
    internal virtual GroupBox GroupBox15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label50")]
    internal virtual Label Label50 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label52")]
    internal virtual Label Label52 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button cmdCancel
    {
      get => this._cmdCancel;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdCancel_Click);
        Button cmdCancel1 = this._cmdCancel;
        if (cmdCancel1 != null)
          cmdCancel1.Click -= eventHandler;
        this._cmdCancel = value;
        Button cmdCancel2 = this._cmdCancel;
        if (cmdCancel2 == null)
          return;
        cmdCancel2.Click += eventHandler;
      }
    }

    internal virtual Button cmdOK
    {
      get => this._cmdOK;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdOK_Click);
        Button cmdOk1 = this._cmdOK;
        if (cmdOk1 != null)
          cmdOk1.Click -= eventHandler;
        this._cmdOK = value;
        Button cmdOk2 = this._cmdOK;
        if (cmdOk2 == null)
          return;
        cmdOk2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Label21")]
    internal virtual Label Label21 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox txtPitch
    {
      get => this._txtPitch;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtPitch_TextChanged);
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.txtPitch_KeyPress);
        TextBox txtPitch1 = this._txtPitch;
        if (txtPitch1 != null)
        {
          txtPitch1.TextChanged -= eventHandler;
          txtPitch1.KeyPress -= pressEventHandler;
        }
        this._txtPitch = value;
        TextBox txtPitch2 = this._txtPitch;
        if (txtPitch2 == null)
          return;
        txtPitch2.TextChanged += eventHandler;
        txtPitch2.KeyPress += pressEventHandler;
      }
    }

    [field: AccessedThroughProperty("txtU")]
    internal virtual TextBox txtU { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox txtFF
    {
      get => this._txtFF;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtFF_TextChanged);
        TextBox txtFf1 = this._txtFF;
        if (txtFf1 != null)
          txtFf1.TextChanged -= eventHandler;
        this._txtFF = value;
        TextBox txtFf2 = this._txtFF;
        if (txtFf2 == null)
          return;
        txtFf2.TextChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("txtg")]
    internal virtual TextBox txtg { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtFractionC")]
    internal virtual NumericUpDown txtFractionC { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ComboBox txtCurtainType
    {
      get => this._txtCurtainType;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtLocation_Click);
        ComboBox txtCurtainType1 = this._txtCurtainType;
        if (txtCurtainType1 != null)
          txtCurtainType1.Click -= eventHandler;
        this._txtCurtainType = value;
        ComboBox txtCurtainType2 = this._txtCurtainType;
        if (txtCurtainType2 == null)
          return;
        txtCurtainType2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("txtCount")]
    internal virtual NumericUpDown txtCount { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtArea")]
    internal virtual TextBox txtArea { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ComboBox txtFrameType
    {
      get => this._txtFrameType;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.txtFrameType_SelectedIndexChanged);
        EventHandler eventHandler2 = new EventHandler(this.txtFrameType_TextChanged);
        EventHandler eventHandler3 = new EventHandler(this.txtLocation_Click);
        ComboBox txtFrameType1 = this._txtFrameType;
        if (txtFrameType1 != null)
        {
          txtFrameType1.SelectedIndexChanged -= eventHandler1;
          txtFrameType1.TextChanged -= eventHandler2;
          txtFrameType1.Click -= eventHandler3;
        }
        this._txtFrameType = value;
        ComboBox txtFrameType2 = this._txtFrameType;
        if (txtFrameType2 == null)
          return;
        txtFrameType2.SelectedIndexChanged += eventHandler1;
        txtFrameType2.TextChanged += eventHandler2;
        txtFrameType2.Click += eventHandler3;
      }
    }

    internal virtual ComboBox txtThermalBreak
    {
      get => this._txtThermalBreak;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.txtThermalBreak_SelectedIndexChanged);
        EventHandler eventHandler2 = new EventHandler(this.txtLocation_Click);
        ComboBox txtThermalBreak1 = this._txtThermalBreak;
        if (txtThermalBreak1 != null)
        {
          txtThermalBreak1.SelectedIndexChanged -= eventHandler1;
          txtThermalBreak1.Click -= eventHandler2;
        }
        this._txtThermalBreak = value;
        ComboBox txtThermalBreak2 = this._txtThermalBreak;
        if (txtThermalBreak2 == null)
          return;
        txtThermalBreak2.SelectedIndexChanged += eventHandler1;
        txtThermalBreak2.Click += eventHandler2;
      }
    }

    internal virtual ComboBox txtAirGap
    {
      get => this._txtAirGap;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.txtAirGap_SelectedIndexChanged);
        EventHandler eventHandler2 = new EventHandler(this.txtLocation_Click);
        ComboBox txtAirGap1 = this._txtAirGap;
        if (txtAirGap1 != null)
        {
          txtAirGap1.SelectedIndexChanged -= eventHandler1;
          txtAirGap1.Click -= eventHandler2;
        }
        this._txtAirGap = value;
        ComboBox txtAirGap2 = this._txtAirGap;
        if (txtAirGap2 == null)
          return;
        txtAirGap2.SelectedIndexChanged += eventHandler1;
        txtAirGap2.Click += eventHandler2;
      }
    }

    internal virtual ComboBox txtGlazingType
    {
      get => this._txtGlazingType;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.txtGlazingType_SelectedIndexChanged);
        EventHandler eventHandler2 = new EventHandler(this.txtLocation_Click);
        ComboBox txtGlazingType1 = this._txtGlazingType;
        if (txtGlazingType1 != null)
        {
          txtGlazingType1.SelectedIndexChanged -= eventHandler1;
          txtGlazingType1.Click -= eventHandler2;
        }
        this._txtGlazingType = value;
        ComboBox txtGlazingType2 = this._txtGlazingType;
        if (txtGlazingType2 == null)
          return;
        txtGlazingType2.SelectedIndexChanged += eventHandler1;
        txtGlazingType2.Click += eventHandler2;
      }
    }

    internal virtual ComboBox txtOvershading
    {
      get => this._txtOvershading;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtLocation_Click);
        ComboBox txtOvershading1 = this._txtOvershading;
        if (txtOvershading1 != null)
          txtOvershading1.Click -= eventHandler;
        this._txtOvershading = value;
        ComboBox txtOvershading2 = this._txtOvershading;
        if (txtOvershading2 == null)
          return;
        txtOvershading2.Click += eventHandler;
      }
    }

    internal virtual ComboBox txtOrientation
    {
      get => this._txtOrientation;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtLocation_Click);
        ComboBox txtOrientation1 = this._txtOrientation;
        if (txtOrientation1 != null)
          txtOrientation1.Click -= eventHandler;
        this._txtOrientation = value;
        ComboBox txtOrientation2 = this._txtOrientation;
        if (txtOrientation2 == null)
          return;
        txtOrientation2.Click += eventHandler;
      }
    }

    internal virtual ComboBox txtLocation
    {
      get => this._txtLocation;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtLocation_Click);
        ComboBox txtLocation1 = this._txtLocation;
        if (txtLocation1 != null)
          txtLocation1.Click -= eventHandler;
        this._txtLocation = value;
        ComboBox txtLocation2 = this._txtLocation;
        if (txtLocation2 == null)
          return;
        txtLocation2.Click += eventHandler;
      }
    }

    internal virtual ComboBox txtUSource
    {
      get => this._txtUSource;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.txtUSource_SelectedIndexChanged);
        EventHandler eventHandler2 = new EventHandler(this.txtLocation_Click);
        ComboBox txtUsource1 = this._txtUSource;
        if (txtUsource1 != null)
        {
          txtUsource1.SelectedIndexChanged -= eventHandler1;
          txtUsource1.Click -= eventHandler2;
        }
        this._txtUSource = value;
        ComboBox txtUsource2 = this._txtUSource;
        if (txtUsource2 == null)
          return;
        txtUsource2.SelectedIndexChanged += eventHandler1;
        txtUsource2.Click += eventHandler2;
      }
    }

    [field: AccessedThroughProperty("txtName")]
    internal virtual TextBox txtName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtOverDepth")]
    internal virtual TextBox txtOverDepth { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtOverWidth")]
    internal virtual TextBox txtOverWidth { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label24")]
    internal virtual Label Label24 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label23")]
    internal virtual Label Label23 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label25")]
    internal virtual Label Label25 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox6")]
    internal virtual GroupBox GroupBox6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ComboBox cboWindowSelect
    {
      get => this._cboWindowSelect;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.cboWindowSelect_SelectedIndexChanged);
        EventHandler eventHandler2 = new EventHandler(this.txtLocation_Click);
        ComboBox cboWindowSelect1 = this._cboWindowSelect;
        if (cboWindowSelect1 != null)
        {
          cboWindowSelect1.SelectedIndexChanged -= eventHandler1;
          cboWindowSelect1.Click -= eventHandler2;
        }
        this._cboWindowSelect = value;
        ComboBox cboWindowSelect2 = this._cboWindowSelect;
        if (cboWindowSelect2 == null)
          return;
        cboWindowSelect2.SelectedIndexChanged += eventHandler1;
        cboWindowSelect2.Click += eventHandler2;
      }
    }

    [field: AccessedThroughProperty("Label26")]
    internal virtual Label Label26 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label22")]
    internal virtual Label Label22 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label4")]
    internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ComboBox txtHeight
    {
      get => this._txtHeight;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.txtHeight_SelectedIndexChanged);
        EventHandler eventHandler2 = new EventHandler(this.txtHeight_TextChanged);
        ComboBox txtHeight1 = this._txtHeight;
        if (txtHeight1 != null)
        {
          txtHeight1.SelectedIndexChanged -= eventHandler1;
          txtHeight1.TextChanged -= eventHandler2;
        }
        this._txtHeight = value;
        ComboBox txtHeight2 = this._txtHeight;
        if (txtHeight2 == null)
          return;
        txtHeight2.SelectedIndexChanged += eventHandler1;
        txtHeight2.TextChanged += eventHandler2;
      }
    }

    internal virtual ComboBox txtWidth
    {
      get => this._txtWidth;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.txtWidth_SelectedIndexChanged);
        EventHandler eventHandler2 = new EventHandler(this.txtWidth_TextChanged);
        ComboBox txtWidth1 = this._txtWidth;
        if (txtWidth1 != null)
        {
          txtWidth1.SelectedIndexChanged -= eventHandler1;
          txtWidth1.TextChanged -= eventHandler2;
        }
        this._txtWidth = value;
        ComboBox txtWidth2 = this._txtWidth;
        if (txtWidth2 == null)
          return;
        txtWidth2.SelectedIndexChanged += eventHandler1;
        txtWidth2.TextChanged += eventHandler2;
      }
    }

    internal virtual Button cmdPrevious
    {
      get => this._cmdPrevious;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdPrevious_Click);
        Button cmdPrevious1 = this._cmdPrevious;
        if (cmdPrevious1 != null)
          cmdPrevious1.Click -= eventHandler;
        this._cmdPrevious = value;
        Button cmdPrevious2 = this._cmdPrevious;
        if (cmdPrevious2 == null)
          return;
        cmdPrevious2.Click += eventHandler;
      }
    }

    internal virtual Button cmdNext
    {
      get => this._cmdNext;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdNext_Click);
        Button cmdNext1 = this._cmdNext;
        if (cmdNext1 != null)
          cmdNext1.Click -= eventHandler;
        this._cmdNext = value;
        Button cmdNext2 = this._cmdNext;
        if (cmdNext2 == null)
          return;
        cmdNext2.Click += eventHandler;
      }
    }

    internal virtual Button cmdNew
    {
      get => this._cmdNew;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdNew_Click);
        Button cmdNew1 = this._cmdNew;
        if (cmdNew1 != null)
          cmdNew1.Click -= eventHandler;
        this._cmdNew = value;
        Button cmdNew2 = this._cmdNew;
        if (cmdNew2 == null)
          return;
        cmdNew2.Click += eventHandler;
      }
    }

    internal virtual Button Button1
    {
      get => this._Button1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button1_Click);
        Button button1_1 = this._Button1;
        if (button1_1 != null)
          button1_1.Click -= eventHandler;
        this._Button1 = value;
        Button button1_2 = this._Button1;
        if (button1_2 == null)
          return;
        button1_2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("ErrorPChecker")]
    internal virtual ErrorProvider ErrorPChecker { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private void cmdCancel_Click(object sender, EventArgs e) => this.Close();

    private void RoofWindows_FormClosing(object sender, FormClosingEventArgs e) => MyProject.Forms.SAPForm.Enabled = true;

    private void cmdOK_Click(object sender, EventArgs e)
    {
      if (!int.TryParse(this.txtPitch.Text, out int _))
      {
        int num1 = (int) Interaction.MsgBox((object) "Please enter correct pitch details", MsgBoxStyle.Information, (object) "Roof Definition");
      }
      else if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtFF.Text, "", false) > 0U && Conversions.ToDouble(this.txtFF.Text) > 1.0)
      {
        int num2 = (int) Interaction.MsgBox((object) "Please enter correct frame factor details. Value cannot be greater than 1.", MsgBoxStyle.Information, (object) "Frame factor");
      }
      else if (!this.CheckArea())
      {
        int num3 = (int) Interaction.MsgBox((object) "Incorrect width or height added.", MsgBoxStyle.Information, (object) "Area");
      }
      else
      {
        this.SaveDetails();
        SAP_Write.WriteRoofLights();
        this.Close();
      }
    }

    private void Windows_Load(object sender, EventArgs e)
    {
      int num1;
      int num2;
      try
      {
        ProjectData.ClearProjectError();
        num1 = 2;
        this.txtLocation.Items.Clear();
        int num3 = checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofRoofs - 1);
        int index = 0;
        while (index <= num3)
        {
          this.txtLocation.Items.Add((object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Roofs[index].Name);
          checked { ++index; }
        }
        this.LoadAlready();
        goto label_11;
label_6:
        num2 = -1;
        switch (num1)
        {
          case 2:
            int num4 = (int) Interaction.MsgBox((object) "Please complete to name of all roofs prior to adding a roof window", MsgBoxStyle.Information, (object) "Roof Definition");
            this.Close();
            goto label_11;
        }
      }
      catch (Exception ex) when (ex is Exception & (uint) num1 > 0U & num2 == 0)
      {
        ProjectData.SetProjectError(ex);
        goto label_6;
      }
      throw ProjectData.CreateProjectError(-2146828237);
label_11:
      if (num2 == 0)
        return;
      ProjectData.ClearProjectError();
    }

    private void txtUSource_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.Check_UValue();
      this.txtg.Enabled = true;
      this.txtFF.Enabled = true;
      this.txtU.Enabled = true;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtUSource.Text, "SAP 2012", false) != 0)
        return;
      this.txtg.Enabled = false;
      this.txtFF.Enabled = false;
      this.txtU.Enabled = false;
    }

    private void txtFrameType_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.Check_UValue();
      this.txtFF.Text = this.txtFrameType.Text.Contains("Metal") ? Conversions.ToString(0.8) : Conversions.ToString(0.7);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtFrameType.Text, "Metal, thermal break", false) == 0)
      {
        this.txtThermalBreak.Enabled = true;
      }
      else
      {
        this.txtThermalBreak.Text = "";
        this.txtThermalBreak.Enabled = false;
      }
    }

    private void txtFrameType_TextChanged(object sender, EventArgs e)
    {
      if (!this.txtFrameType.Text.Contains("Metal"))
      {
        this.txtThermalBreak.Text = "";
        this.txtThermalBreak.Enabled = false;
      }
      else
        this.txtThermalBreak.Enabled = true;
    }

    private void txtGlazingType_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.Check_UValue();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtUSource.Text, "SAP 2012", false) != 0)
        return;
      this.txtg.Text = Conversions.ToString(Functions.Check_GValue(this.txtGlazingType.Text));
    }

    private void txtAirGap_SelectedIndexChanged(object sender, EventArgs e) => this.Check_UValue();

    private void txtThermalBreak_SelectedIndexChanged(object sender, EventArgs e) => this.Check_UValue();

    private void Check_UValue()
    {
      try
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtUSource.Text, "SAP 2012", false) != 0)
          return;
        this.txtU.Text = Conversions.ToString(Functions.Get_Table6e_UValue(this.txtGlazingType.Text, this.txtFrameType.Text, this.txtAirGap.Text, "Roof Window", this.txtThermalBreak.Text));
        TextBox txtU;
        string str = Conversions.ToString(Conversions.ToDouble((txtU = this.txtU).Text) + this.PitchCalc());
        txtU.Text = str;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void txtWidth_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (Conversion.Val(this.txtWidth.Text) * Conversion.Val(this.txtHeight.Text) == 0.0)
        return;
      this.txtArea.Text = Strings.Format((object) (Conversion.Val(this.txtWidth.Text) * Conversion.Val(this.txtHeight.Text) / 1000000.0), "0.00");
    }

    private void txtHeight_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (Conversion.Val(this.txtWidth.Text) * Conversion.Val(this.txtHeight.Text) == 0.0)
        return;
      this.txtArea.Text = Strings.Format((object) (Conversion.Val(this.txtWidth.Text) * Conversion.Val(this.txtHeight.Text) / 1000000.0), "0.00");
    }

    private void txtWidth_TextChanged(object sender, EventArgs e)
    {
      if (Conversion.Val(this.txtWidth.Text) * Conversion.Val(this.txtHeight.Text) == 0.0)
        return;
      this.txtArea.Text = Strings.Format((object) (Conversion.Val(this.txtWidth.Text) * Conversion.Val(this.txtHeight.Text) / 1000000.0), "0.00");
    }

    private void txtHeight_TextChanged(object sender, EventArgs e)
    {
      if (Conversion.Val(this.txtWidth.Text) * Conversion.Val(this.txtHeight.Text) == 0.0)
        return;
      this.txtArea.Text = Strings.Format((object) (Conversion.Val(this.txtWidth.Text) * Conversion.Val(this.txtHeight.Text) / 1000000.0), "0.00");
    }

    private void cboWindowSelect_SelectedIndexChanged(object sender, EventArgs e)
    {
      if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cboWindowSelect.Text, "", false) <= 0U)
        return;
      int num = checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofRoofLights - 1);
      int index = 0;
      while (index <= num)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[index].Name, this.cboWindowSelect.Text, false) == 0)
        {
          this.txtLocation.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[index].Location;
          this.txtUSource.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[index].UValueSource;
          this.txtOrientation.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[index].Orientation;
          this.txtOvershading.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[index].Overshading;
          this.txtGlazingType.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[index].GlazingType;
          this.txtAirGap.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[index].AirGap;
          this.txtFrameType.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[index].FrameType;
          this.txtThermalBreak.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[index].ThermalBreak;
          this.txtArea.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[index].Area);
          this.txtWidth.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[index].Width);
          this.txtHeight.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[index].Height);
          this.txtCount.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[index].Count);
          this.txtOverWidth.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[index].OverhangWidth);
          this.txtOverDepth.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[index].OverhangDepth);
          this.txtCurtainType.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[index].CurtainType;
          this.txtFractionC.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[index].FractionClosed);
          this.txtg.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[index].g);
          this.txtFF.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[index].FF);
          this.txtU.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[index].U);
        }
        checked { ++index; }
      }
    }

    private void txtPitch_TextChanged(object sender, EventArgs e)
    {
      this.txtPitch.Text = Functions.RestrictValue(this.txtPitch, 90);
      this.Check_UValue();
    }

    private double PitchCalc()
    {
      double num1 = 0.0;
      if (this.txtGlazingType.Text.Contains("double"))
      {
        double num2 = Conversion.Val(this.txtPitch.Text);
        if (num2 >= 70.0)
          num1 = 0.0;
        else if (num2 >= 60.0 && num2 <= 70.0)
          num1 = 0.2;
        else if (num2 >= 40.0 && num2 <= 60.0)
          num1 = 0.3;
        else if (num2 >= 21.0 && num2 <= 40.0)
          num1 = 0.4;
        else if (num2 <= 20.0)
          num1 = 0.5;
      }
      else if (this.txtGlazingType.Text.Contains("triple"))
      {
        double num3 = Conversion.Val(this.txtPitch.Text);
        if (num3 >= 70.0)
          num1 = 0.0;
        else if (num3 >= 60.0 && num3 <= 70.0)
          num1 = 0.1;
        else if (num3 >= 40.0 && num3 <= 60.0)
          num1 = 0.2;
        else if (num3 >= 20.0 && num3 <= 40.0)
          num1 = 0.3;
        else if (num3 <= 20.0)
          num1 = 0.4;
      }
      return num1;
    }

    private void SaveDetails()
    {
      if (!SAP_Module.EditRow)
      {
        MyProject.Forms.SAPForm.DataRoofLights.Rows.Add();
        DataGridView dataRoofLights = MyProject.Forms.SAPForm.DataRoofLights;
        dataRoofLights[0, checked (dataRoofLights.RowCount - 1)].Value = (object) this.txtName.Text;
        dataRoofLights[1, checked (dataRoofLights.RowCount - 1)].Value = (object) this.txtLocation.Text;
        dataRoofLights[2, checked (dataRoofLights.RowCount - 1)].Value = (object) this.txtUSource.Text;
        dataRoofLights[3, checked (dataRoofLights.RowCount - 1)].Value = (object) this.txtPitch.Text;
        dataRoofLights[4, checked (dataRoofLights.RowCount - 1)].Value = (object) this.txtOrientation.Text;
        dataRoofLights[5, checked (dataRoofLights.RowCount - 1)].Value = (object) this.txtOvershading.Text;
        dataRoofLights[6, checked (dataRoofLights.RowCount - 1)].Value = (object) this.txtGlazingType.Text;
        dataRoofLights[7, checked (dataRoofLights.RowCount - 1)].Value = (object) this.txtAirGap.Text;
        dataRoofLights[8, checked (dataRoofLights.RowCount - 1)].Value = (object) this.txtFrameType.Text;
        dataRoofLights[9, checked (dataRoofLights.RowCount - 1)].Value = (object) this.txtThermalBreak.Text;
        dataRoofLights[10, checked (dataRoofLights.RowCount - 1)].Value = (object) this.txtArea.Text;
        dataRoofLights[11, checked (dataRoofLights.RowCount - 1)].Value = (object) this.txtWidth.Text;
        dataRoofLights[12, checked (dataRoofLights.RowCount - 1)].Value = (object) this.txtHeight.Text;
        dataRoofLights[13, checked (dataRoofLights.RowCount - 1)].Value = (object) this.txtCount.Text;
        dataRoofLights[14, checked (dataRoofLights.RowCount - 1)].Value = (object) this.txtOverWidth.Text;
        dataRoofLights[15, checked (dataRoofLights.RowCount - 1)].Value = (object) this.txtOverDepth.Text;
        dataRoofLights[16, checked (dataRoofLights.RowCount - 1)].Value = (object) this.txtCurtainType.Text;
        dataRoofLights[17, checked (dataRoofLights.RowCount - 1)].Value = (object) this.txtFractionC.Text;
        dataRoofLights[18, checked (dataRoofLights.RowCount - 1)].Value = (object) this.txtg.Text;
        dataRoofLights[19, checked (dataRoofLights.RowCount - 1)].Value = (object) this.txtFF.Text;
        dataRoofLights[20, checked (dataRoofLights.RowCount - 1)].Value = (object) this.txtU.Text;
      }
      else
      {
        DataGridView dataRoofLights = MyProject.Forms.SAPForm.DataRoofLights;
        dataRoofLights[0, SAP_Module.RowEdit].Value = (object) this.txtName.Text;
        dataRoofLights[1, SAP_Module.RowEdit].Value = (object) this.txtLocation.Text;
        dataRoofLights[2, SAP_Module.RowEdit].Value = (object) this.txtUSource.Text;
        dataRoofLights[3, SAP_Module.RowEdit].Value = (object) this.txtPitch.Text;
        dataRoofLights[4, SAP_Module.RowEdit].Value = (object) this.txtOrientation.Text;
        dataRoofLights[5, SAP_Module.RowEdit].Value = (object) this.txtOvershading.Text;
        dataRoofLights[6, SAP_Module.RowEdit].Value = (object) this.txtGlazingType.Text;
        dataRoofLights[7, SAP_Module.RowEdit].Value = (object) this.txtAirGap.Text;
        dataRoofLights[8, SAP_Module.RowEdit].Value = (object) this.txtFrameType.Text;
        dataRoofLights[9, SAP_Module.RowEdit].Value = (object) this.txtThermalBreak.Text;
        dataRoofLights[10, SAP_Module.RowEdit].Value = (object) this.txtArea.Text;
        dataRoofLights[11, SAP_Module.RowEdit].Value = (object) this.txtWidth.Text;
        dataRoofLights[12, SAP_Module.RowEdit].Value = (object) this.txtHeight.Text;
        dataRoofLights[13, SAP_Module.RowEdit].Value = (object) this.txtCount.Text;
        dataRoofLights[14, SAP_Module.RowEdit].Value = (object) this.txtOverWidth.Text;
        dataRoofLights[15, SAP_Module.RowEdit].Value = (object) this.txtOverDepth.Text;
        dataRoofLights[16, SAP_Module.RowEdit].Value = (object) this.txtCurtainType.Text;
        dataRoofLights[17, SAP_Module.RowEdit].Value = (object) this.txtFractionC.Text;
        dataRoofLights[18, SAP_Module.RowEdit].Value = (object) this.txtg.Text;
        dataRoofLights[19, SAP_Module.RowEdit].Value = (object) this.txtFF.Text;
        dataRoofLights[20, SAP_Module.RowEdit].Value = (object) this.txtU.Text;
      }
    }

    private void ReadIn()
    {
      DataGridView dataRoofLights = MyProject.Forms.SAPForm.DataRoofLights;
      this.txtName.Text = Conversions.ToString(dataRoofLights[0, SAP_Module.RowEdit].Value);
      this.txtLocation.Text = Conversions.ToString(dataRoofLights[1, SAP_Module.RowEdit].Value);
      this.txtUSource.Text = Conversions.ToString(dataRoofLights[2, SAP_Module.RowEdit].Value);
      this.txtPitch.Text = Conversions.ToString(dataRoofLights[3, SAP_Module.RowEdit].Value);
      this.txtOrientation.Text = Conversions.ToString(dataRoofLights[4, SAP_Module.RowEdit].Value);
      this.txtOvershading.Text = Conversions.ToString(dataRoofLights[5, SAP_Module.RowEdit].Value);
      this.txtGlazingType.Text = Conversions.ToString(dataRoofLights[6, SAP_Module.RowEdit].Value);
      this.txtAirGap.Text = Conversions.ToString(dataRoofLights[7, SAP_Module.RowEdit].Value);
      this.txtFrameType.Text = Conversions.ToString(dataRoofLights[8, SAP_Module.RowEdit].Value);
      this.txtThermalBreak.Text = Conversions.ToString(dataRoofLights[9, SAP_Module.RowEdit].Value);
      this.txtArea.Text = Conversions.ToString(dataRoofLights[10, SAP_Module.RowEdit].Value);
      this.txtWidth.Text = Conversions.ToString(dataRoofLights[11, SAP_Module.RowEdit].Value);
      this.txtHeight.Text = Conversions.ToString(dataRoofLights[12, SAP_Module.RowEdit].Value);
      this.txtCount.Text = Conversions.ToString(dataRoofLights[13, SAP_Module.RowEdit].Value);
      this.txtOverWidth.Text = Conversions.ToString(dataRoofLights[14, SAP_Module.RowEdit].Value);
      this.txtOverDepth.Text = Conversions.ToString(dataRoofLights[15, SAP_Module.RowEdit].Value);
      this.txtCurtainType.Text = Conversions.ToString(dataRoofLights[16, SAP_Module.RowEdit].Value);
      this.txtFractionC.Text = Conversions.ToString(dataRoofLights[17, SAP_Module.RowEdit].Value);
      this.txtg.Text = Conversions.ToString(dataRoofLights[18, SAP_Module.RowEdit].Value);
      this.txtFF.Text = Conversions.ToString(dataRoofLights[19, SAP_Module.RowEdit].Value);
      this.txtU.Text = Conversions.ToString(dataRoofLights[20, SAP_Module.RowEdit].Value);
      SAP_Module.EditRow = true;
    }

    private void CheckButtons()
    {
      if (SAP_Module.RowEdit == 0)
        this.cmdPrevious.Enabled = false;
      else
        this.cmdPrevious.Enabled = true;
      if (SAP_Module.RowEdit == checked (MyProject.Forms.SAPForm.DataRoofLights.RowCount - 1))
        this.cmdNext.Enabled = false;
      else
        this.cmdNext.Enabled = true;
    }

    private void cmdNext_Click(object sender, EventArgs e)
    {
      this.SaveDetails();
      SAP_Write.WriteRoofLights();
      checked { ++SAP_Module.RowEdit; }
      this.ReadIn();
      this.CheckButtons();
    }

    private void cmdPrevious_Click(object sender, EventArgs e)
    {
      this.SaveDetails();
      SAP_Write.WriteRoofLights();
      checked { --SAP_Module.RowEdit; }
      this.ReadIn();
      this.CheckButtons();
    }

    private void LoadAlready()
    {
      this.cboWindowSelect.Items.Clear();
      int num = checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofRoofLights - 1);
      int index = 0;
      while (index <= num)
      {
        if (SAP_Module.EditRow)
        {
          if (SAP_Module.RowEdit != index)
            this.cboWindowSelect.Items.Add((object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[index].Name);
        }
        else
          this.cboWindowSelect.Items.Add((object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[index].Name);
        checked { ++index; }
      }
    }

    private void cmdNew_Click(object sender, EventArgs e)
    {
      this.SaveDetails();
      SAP_Write.WriteRoofLights();
      SAP_Module.RowEdit = MyProject.Forms.SAPForm.DataRoofLights.RowCount;
      this.txtName.Text = "";
      this.txtLocation.Text = "";
      this.txtUSource.Text = "";
      this.txtPitch.Text = "";
      this.txtOrientation.Text = "";
      this.txtOvershading.Text = "";
      this.txtGlazingType.Text = "";
      this.txtAirGap.Text = "";
      this.txtFrameType.Text = "";
      this.txtThermalBreak.Text = "";
      this.txtArea.Text = "";
      this.txtWidth.Text = "";
      this.txtHeight.Text = "";
      this.txtCount.Text = "";
      this.txtOverWidth.Text = "";
      this.txtOverDepth.Text = "";
      this.txtCurtainType.Text = "";
      this.txtFractionC.Text = "";
      this.txtg.Text = "";
      this.txtFF.Text = "";
      this.txtU.Text = "";
      this.cmdPrevious.Enabled = true;
      this.cmdNext.Enabled = false;
      this.LoadAlready();
      SAP_Module.EditRow = false;
    }

    private void txtLocation_Click(object sender, EventArgs e) => ((ComboBox) sender).DroppedDown = true;

    private void Button1_Click(object sender, EventArgs e)
    {
      DataTable dataTable = new DataTable();
      MyProject.Forms.Copy_Opening.Type = "Roof";
      MyProject.Forms.Copy_Opening.pnlDoor.Visible = false;
      MyProject.Forms.Copy_Opening.pnlRWindow.Visible = true;
      MyProject.Forms.Copy_Opening.pnlWindow.Visible = false;
      dataTable.Columns.Add("Dwelling", typeof (short));
      dataTable.Columns.Add("RoofLight", typeof (short));
      dataTable.Columns.Add("Dwelling Name", typeof (string));
      dataTable.Columns.Add("RoofLight Name", typeof (string));
      dataTable.Columns.Add("Select", typeof (bool));
      int num1 = checked (SAP_Module.Proj.NoOfDwells - 1);
      int index1 = 0;
      while (index1 <= num1)
      {
        int num2 = checked (SAP_Module.Proj.Dwellings[index1].NoofRoofLights - 1);
        int index2 = 0;
        while (index2 <= num2)
        {
          if (!(index1 == SAP_Module.CurrDwelling & SAP_Module.RowEdit == index2))
          {
            DataRow row = dataTable.NewRow();
            DataRow dataRow = row;
            dataRow["Dwelling"] = (object) index1;
            dataRow["RoofLight"] = (object) index2;
            dataRow["Dwelling Name"] = (object) SAP_Module.Proj.Dwellings[index1].Name;
            dataRow["RoofLight Name"] = (object) SAP_Module.Proj.Dwellings[index1].RoofLights[index2].Name;
            dataTable.Rows.Add(row);
          }
          checked { ++index2; }
        }
        checked { ++index1; }
      }
      MyProject.Forms.Copy_Opening.DG1.DataSource = (object) dataTable;
      MyProject.Forms.Copy_Opening.DG1.Columns[0].Visible = false;
      MyProject.Forms.Copy_Opening.DG1.Columns[1].Visible = false;
      MyProject.Forms.Copy_Opening.DG1.Columns[2].ReadOnly = true;
      MyProject.Forms.Copy_Opening.DG1.Columns[3].ReadOnly = true;
      this.SaveDetails();
      SAP_Write.WriteRoofLights();
      MyProject.Forms.Copy_Opening.RoofLight = Functions.CopyRoofLight(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[SAP_Module.RowEdit]);
      int num3 = (int) MyProject.Forms.Copy_Opening.ShowDialog();
    }

    private void txtPitch_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (Strings.Asc(e.KeyChar) == 13 || Strings.Asc(e.KeyChar) == 8 || Versioned.IsNumeric((object) e.KeyChar))
        return;
      int num = (int) MessageBox.Show("Please enter numbers only");
      e.Handled = true;
    }

    private void txtFF_TextChanged(object sender, EventArgs e)
    {
      if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtFF.Text, "", false) > 0U)
      {
        try
        {
          if (Conversions.ToDouble(this.txtFF.Text) > 1.0)
          {
            int num = (int) Interaction.MsgBox((object) "Please enter correct frame factor details. Value cannot be greater than 1.", MsgBoxStyle.Information, (object) "Frame factor");
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
      }
    }

    private bool CheckArea()
    {
      bool flag = true;
      if (Conversion.Val(this.txtWidth.Text) != 0.0 & Conversion.Val(this.txtWidth.Text) != 0.0)
        flag = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Strings.Format((object) Conversion.Val(this.txtArea.Text), "0.00"), Strings.Format((object) (Conversion.Val(this.txtWidth.Text) * Conversion.Val(this.txtHeight.Text) / 1000000.0), "0.00"), false) == 0;
      return flag;
    }
  }
}
