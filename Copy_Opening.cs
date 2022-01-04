
// Type: SAP2012.Copy_Opening




using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SAP2012
{
  [DesignerGenerated]
  public class Copy_Opening : Form
  {
    private IContainer components;
    public string Type;
    public SAP_Module.Door Door;
    public SAP_Module.Window Window;
    public SAP_Module.RoofLight RoofLight;

    public Copy_Opening() => this.InitializeComponent();

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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Copy_Opening));
      this.pnlWindow = new Panel();
      this.cmd_W_SNone = new Button();
      this.cmd_W_SAll = new Button();
      this.GroupBox6 = new GroupBox();
      this.chk_W_G_Uvalue = new CheckBox();
      this.chk_W_G_Orientation = new CheckBox();
      this.chk_W_G_Overshading = new CheckBox();
      this.GroupBox5 = new GroupBox();
      this.chk_W_GS_GlazingType = new CheckBox();
      this.chk_W_GS_AirGap = new CheckBox();
      this.GroupBox4 = new GroupBox();
      this.chk_W_F_Type = new CheckBox();
      this.chk_W_F_Thermal = new CheckBox();
      this.GroupBox3 = new GroupBox();
      this.chk_W_S_Area = new CheckBox();
      this.chk_W_S_Width = new CheckBox();
      this.chk_W_S_Height = new CheckBox();
      this.chk_W_S_OverDepth = new CheckBox();
      this.chk_W_S_Count = new CheckBox();
      this.chk_W_S_OverWidth = new CheckBox();
      this.GroupBox2 = new GroupBox();
      this.chk_W_C_CurtainType = new CheckBox();
      this.chk_W_C_Fraction = new CheckBox();
      this.GroupBox1 = new GroupBox();
      this.chk_W_W_Transmittance = new CheckBox();
      this.chk_W_W_UValue = new CheckBox();
      this.chk_W_W_FF = new CheckBox();
      this.Label1 = new Label();
      this.cmd_W_Copy = new Button();
      this.DG1 = new DataGridView();
      this.pnlRWindow = new Panel();
      this.cmd_RW_SNone = new Button();
      this.cmd_RW_SAll = new Button();
      this.GroupBox7 = new GroupBox();
      this.chk_RW_G_Pitch = new CheckBox();
      this.chk_RW_G_Uvalue = new CheckBox();
      this.chk_RW_G_Orientation = new CheckBox();
      this.chk_RW_G_Overshading = new CheckBox();
      this.GroupBox8 = new GroupBox();
      this.chk_RW_GS_GlazingType = new CheckBox();
      this.chk_RW_GS_AirGap = new CheckBox();
      this.GroupBox9 = new GroupBox();
      this.chk_RW_F_Type = new CheckBox();
      this.chk_RW_F_Thermal = new CheckBox();
      this.GroupBox10 = new GroupBox();
      this.chk_RW_S_Area = new CheckBox();
      this.chk_RW_S_Width = new CheckBox();
      this.chk_RW_S_Height = new CheckBox();
      this.chk_RW_S_OverDepth = new CheckBox();
      this.chk_RW_S_Count = new CheckBox();
      this.chk_RW_S_OverWidth = new CheckBox();
      this.GroupBox11 = new GroupBox();
      this.chk_RW_C_CurtainType = new CheckBox();
      this.chk_RW_C_Fraction = new CheckBox();
      this.GroupBox12 = new GroupBox();
      this.chk_RW_W_Transmittance = new CheckBox();
      this.chk_RW_W_UValue = new CheckBox();
      this.chk_RW_W_FF = new CheckBox();
      this.Label2 = new Label();
      this.cmd_RW_Copy = new Button();
      this.pnlDoor = new Panel();
      this.cmd_D_SNone = new Button();
      this.cmd_D_SAll = new Button();
      this.GroupBox13 = new GroupBox();
      this.chk_D_G_Type = new CheckBox();
      this.chk_D_G_Uvalue = new CheckBox();
      this.chk_D_G_Orientation = new CheckBox();
      this.chk_D_G_Overshading = new CheckBox();
      this.GroupBox14 = new GroupBox();
      this.chk_D_GS_GlazingType = new CheckBox();
      this.chk_D_GS_AirGap = new CheckBox();
      this.GroupBox15 = new GroupBox();
      this.chk_D_F_Type = new CheckBox();
      this.chk_D_F_Thermal = new CheckBox();
      this.GroupBox16 = new GroupBox();
      this.chk_D_S_Area = new CheckBox();
      this.chk_D_S_Width = new CheckBox();
      this.chk_D_S_Height = new CheckBox();
      this.chk_D_S_OverDepth = new CheckBox();
      this.chk_D_S_Count = new CheckBox();
      this.chk_D_S_OverWidth = new CheckBox();
      this.GroupBox18 = new GroupBox();
      this.chk_D_W_Transmittance = new CheckBox();
      this.chk_D_W_UValue = new CheckBox();
      this.chk_D_W_FF = new CheckBox();
      this.Label3 = new Label();
      this.cmd_D_Copy = new Button();
      this.cmdSAll = new Button();
      this.cmdSNone = new Button();
      this.Button1 = new Button();
      this.pnlWindow.SuspendLayout();
      this.GroupBox6.SuspendLayout();
      this.GroupBox5.SuspendLayout();
      this.GroupBox4.SuspendLayout();
      this.GroupBox3.SuspendLayout();
      this.GroupBox2.SuspendLayout();
      this.GroupBox1.SuspendLayout();
      ((ISupportInitialize) this.DG1).BeginInit();
      this.pnlRWindow.SuspendLayout();
      this.GroupBox7.SuspendLayout();
      this.GroupBox8.SuspendLayout();
      this.GroupBox9.SuspendLayout();
      this.GroupBox10.SuspendLayout();
      this.GroupBox11.SuspendLayout();
      this.GroupBox12.SuspendLayout();
      this.pnlDoor.SuspendLayout();
      this.GroupBox13.SuspendLayout();
      this.GroupBox14.SuspendLayout();
      this.GroupBox15.SuspendLayout();
      this.GroupBox16.SuspendLayout();
      this.GroupBox18.SuspendLayout();
      this.SuspendLayout();
      this.pnlWindow.BackColor = Color.White;
      this.pnlWindow.Controls.Add((Control) this.cmd_W_SNone);
      this.pnlWindow.Controls.Add((Control) this.cmd_W_SAll);
      this.pnlWindow.Controls.Add((Control) this.GroupBox6);
      this.pnlWindow.Controls.Add((Control) this.GroupBox5);
      this.pnlWindow.Controls.Add((Control) this.GroupBox4);
      this.pnlWindow.Controls.Add((Control) this.GroupBox3);
      this.pnlWindow.Controls.Add((Control) this.GroupBox2);
      this.pnlWindow.Controls.Add((Control) this.GroupBox1);
      this.pnlWindow.Controls.Add((Control) this.Label1);
      this.pnlWindow.Controls.Add((Control) this.cmd_W_Copy);
      this.pnlWindow.Dock = DockStyle.Left;
      this.pnlWindow.Location = new Point(0, 0);
      this.pnlWindow.Name = "pnlWindow";
      this.pnlWindow.Size = new Size(200, 668);
      this.pnlWindow.TabIndex = 0;
      this.pnlWindow.Visible = false;
      this.cmd_W_SNone.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.cmd_W_SNone.BackColor = Color.LightSlateGray;
      this.cmd_W_SNone.Cursor = Cursors.Hand;
      this.cmd_W_SNone.FlatStyle = FlatStyle.Popup;
      this.cmd_W_SNone.ForeColor = Color.White;
      this.cmd_W_SNone.Location = new Point(103, 617);
      this.cmd_W_SNone.Name = "cmd_W_SNone";
      this.cmd_W_SNone.Size = new Size(90, 23);
      this.cmd_W_SNone.TabIndex = 39;
      this.cmd_W_SNone.Text = "Select None";
      this.cmd_W_SNone.UseVisualStyleBackColor = false;
      this.cmd_W_SAll.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.cmd_W_SAll.BackColor = Color.LightSlateGray;
      this.cmd_W_SAll.Cursor = Cursors.Hand;
      this.cmd_W_SAll.FlatStyle = FlatStyle.Popup;
      this.cmd_W_SAll.ForeColor = Color.White;
      this.cmd_W_SAll.Location = new Point(12, 617);
      this.cmd_W_SAll.Name = "cmd_W_SAll";
      this.cmd_W_SAll.Size = new Size(90, 23);
      this.cmd_W_SAll.TabIndex = 38;
      this.cmd_W_SAll.Text = "Select All";
      this.cmd_W_SAll.UseVisualStyleBackColor = false;
      this.GroupBox6.Controls.Add((Control) this.chk_W_G_Uvalue);
      this.GroupBox6.Controls.Add((Control) this.chk_W_G_Orientation);
      this.GroupBox6.Controls.Add((Control) this.chk_W_G_Overshading);
      this.GroupBox6.Location = new Point(12, 29);
      this.GroupBox6.Name = "GroupBox6";
      this.GroupBox6.Size = new Size(181, 88);
      this.GroupBox6.TabIndex = 37;
      this.GroupBox6.TabStop = false;
      this.GroupBox6.Text = "General";
      this.chk_W_G_Uvalue.AutoSize = true;
      this.chk_W_G_Uvalue.Cursor = Cursors.Hand;
      this.chk_W_G_Uvalue.Location = new Point(6, 20);
      this.chk_W_G_Uvalue.Name = "chk_W_G_Uvalue";
      this.chk_W_G_Uvalue.Size = new Size(99, 17);
      this.chk_W_G_Uvalue.TabIndex = 12;
      this.chk_W_G_Uvalue.Text = "U-Value Source";
      this.chk_W_G_Uvalue.UseVisualStyleBackColor = true;
      this.chk_W_G_Orientation.AutoSize = true;
      this.chk_W_G_Orientation.Cursor = Cursors.Hand;
      this.chk_W_G_Orientation.Location = new Point(6, 43);
      this.chk_W_G_Orientation.Name = "chk_W_G_Orientation";
      this.chk_W_G_Orientation.Size = new Size(80, 17);
      this.chk_W_G_Orientation.TabIndex = 14;
      this.chk_W_G_Orientation.Text = "Orientation";
      this.chk_W_G_Orientation.UseVisualStyleBackColor = true;
      this.chk_W_G_Overshading.AutoSize = true;
      this.chk_W_G_Overshading.Cursor = Cursors.Hand;
      this.chk_W_G_Overshading.Location = new Point(6, 66);
      this.chk_W_G_Overshading.Name = "chk_W_G_Overshading";
      this.chk_W_G_Overshading.Size = new Size(87, 17);
      this.chk_W_G_Overshading.TabIndex = 15;
      this.chk_W_G_Overshading.Text = "Overshading";
      this.chk_W_G_Overshading.UseVisualStyleBackColor = true;
      this.GroupBox5.Controls.Add((Control) this.chk_W_GS_GlazingType);
      this.GroupBox5.Controls.Add((Control) this.chk_W_GS_AirGap);
      this.GroupBox5.Location = new Point(12, 123);
      this.GroupBox5.Name = "GroupBox5";
      this.GroupBox5.Size = new Size(182, 66);
      this.GroupBox5.TabIndex = 36;
      this.GroupBox5.TabStop = false;
      this.GroupBox5.Text = "Glazing Style";
      this.chk_W_GS_GlazingType.AutoSize = true;
      this.chk_W_GS_GlazingType.Cursor = Cursors.Hand;
      this.chk_W_GS_GlazingType.Location = new Point(6, 20);
      this.chk_W_GS_GlazingType.Name = "chk_W_GS_GlazingType";
      this.chk_W_GS_GlazingType.Size = new Size(87, 17);
      this.chk_W_GS_GlazingType.TabIndex = 16;
      this.chk_W_GS_GlazingType.Text = "Glazing Type";
      this.chk_W_GS_GlazingType.UseVisualStyleBackColor = true;
      this.chk_W_GS_AirGap.AutoSize = true;
      this.chk_W_GS_AirGap.Cursor = Cursors.Hand;
      this.chk_W_GS_AirGap.Location = new Point(6, 43);
      this.chk_W_GS_AirGap.Name = "chk_W_GS_AirGap";
      this.chk_W_GS_AirGap.Size = new Size(61, 17);
      this.chk_W_GS_AirGap.TabIndex = 17;
      this.chk_W_GS_AirGap.Text = "Air Gap";
      this.chk_W_GS_AirGap.UseVisualStyleBackColor = true;
      this.GroupBox4.Controls.Add((Control) this.chk_W_F_Type);
      this.GroupBox4.Controls.Add((Control) this.chk_W_F_Thermal);
      this.GroupBox4.Location = new Point(12, 195);
      this.GroupBox4.Name = "GroupBox4";
      this.GroupBox4.Size = new Size(182, 68);
      this.GroupBox4.TabIndex = 35;
      this.GroupBox4.TabStop = false;
      this.GroupBox4.Text = "Frame";
      this.chk_W_F_Type.AutoSize = true;
      this.chk_W_F_Type.Cursor = Cursors.Hand;
      this.chk_W_F_Type.Location = new Point(6, 20);
      this.chk_W_F_Type.Name = "chk_W_F_Type";
      this.chk_W_F_Type.Size = new Size(50, 17);
      this.chk_W_F_Type.TabIndex = 18;
      this.chk_W_F_Type.Text = "Type";
      this.chk_W_F_Type.UseVisualStyleBackColor = true;
      this.chk_W_F_Thermal.AutoSize = true;
      this.chk_W_F_Thermal.Cursor = Cursors.Hand;
      this.chk_W_F_Thermal.Location = new Point(6, 43);
      this.chk_W_F_Thermal.Name = "chk_W_F_Thermal";
      this.chk_W_F_Thermal.Size = new Size(94, 17);
      this.chk_W_F_Thermal.TabIndex = 19;
      this.chk_W_F_Thermal.Text = "Thermal break";
      this.chk_W_F_Thermal.UseVisualStyleBackColor = true;
      this.GroupBox3.Controls.Add((Control) this.chk_W_S_Area);
      this.GroupBox3.Controls.Add((Control) this.chk_W_S_Width);
      this.GroupBox3.Controls.Add((Control) this.chk_W_S_Height);
      this.GroupBox3.Controls.Add((Control) this.chk_W_S_OverDepth);
      this.GroupBox3.Controls.Add((Control) this.chk_W_S_Count);
      this.GroupBox3.Controls.Add((Control) this.chk_W_S_OverWidth);
      this.GroupBox3.Location = new Point(12, 269);
      this.GroupBox3.Name = "GroupBox3";
      this.GroupBox3.Size = new Size(182, 156);
      this.GroupBox3.TabIndex = 34;
      this.GroupBox3.TabStop = false;
      this.GroupBox3.Text = "Size";
      this.chk_W_S_Area.AutoSize = true;
      this.chk_W_S_Area.Cursor = Cursors.Hand;
      this.chk_W_S_Area.Location = new Point(6, 20);
      this.chk_W_S_Area.Name = "chk_W_S_Area";
      this.chk_W_S_Area.Size = new Size(49, 17);
      this.chk_W_S_Area.TabIndex = 21;
      this.chk_W_S_Area.Text = "Area";
      this.chk_W_S_Area.UseVisualStyleBackColor = true;
      this.chk_W_S_Width.AutoSize = true;
      this.chk_W_S_Width.Cursor = Cursors.Hand;
      this.chk_W_S_Width.Enabled = false;
      this.chk_W_S_Width.Location = new Point(6, 43);
      this.chk_W_S_Width.Name = "chk_W_S_Width";
      this.chk_W_S_Width.Size = new Size(54, 17);
      this.chk_W_S_Width.TabIndex = 22;
      this.chk_W_S_Width.Text = "Width";
      this.chk_W_S_Width.UseVisualStyleBackColor = true;
      this.chk_W_S_Height.AutoSize = true;
      this.chk_W_S_Height.Cursor = Cursors.Hand;
      this.chk_W_S_Height.Enabled = false;
      this.chk_W_S_Height.Location = new Point(6, 66);
      this.chk_W_S_Height.Name = "chk_W_S_Height";
      this.chk_W_S_Height.Size = new Size(57, 17);
      this.chk_W_S_Height.TabIndex = 23;
      this.chk_W_S_Height.Text = "Height";
      this.chk_W_S_Height.UseVisualStyleBackColor = true;
      this.chk_W_S_OverDepth.AutoSize = true;
      this.chk_W_S_OverDepth.Cursor = Cursors.Hand;
      this.chk_W_S_OverDepth.Location = new Point(6, 135);
      this.chk_W_S_OverDepth.Name = "chk_W_S_OverDepth";
      this.chk_W_S_OverDepth.Size = new Size(106, 17);
      this.chk_W_S_OverDepth.TabIndex = 26;
      this.chk_W_S_OverDepth.Text = "Overhang Depth";
      this.chk_W_S_OverDepth.UseVisualStyleBackColor = true;
      this.chk_W_S_Count.AutoSize = true;
      this.chk_W_S_Count.Cursor = Cursors.Hand;
      this.chk_W_S_Count.Location = new Point(6, 89);
      this.chk_W_S_Count.Name = "chk_W_S_Count";
      this.chk_W_S_Count.Size = new Size(55, 17);
      this.chk_W_S_Count.TabIndex = 24;
      this.chk_W_S_Count.Text = "Count";
      this.chk_W_S_Count.UseVisualStyleBackColor = true;
      this.chk_W_S_OverWidth.AutoSize = true;
      this.chk_W_S_OverWidth.Cursor = Cursors.Hand;
      this.chk_W_S_OverWidth.Location = new Point(6, 112);
      this.chk_W_S_OverWidth.Name = "chk_W_S_OverWidth";
      this.chk_W_S_OverWidth.Size = new Size(105, 17);
      this.chk_W_S_OverWidth.TabIndex = 25;
      this.chk_W_S_OverWidth.Text = "Overhang Width";
      this.chk_W_S_OverWidth.UseVisualStyleBackColor = true;
      this.GroupBox2.Controls.Add((Control) this.chk_W_C_CurtainType);
      this.GroupBox2.Controls.Add((Control) this.chk_W_C_Fraction);
      this.GroupBox2.Location = new Point(12, 431);
      this.GroupBox2.Name = "GroupBox2";
      this.GroupBox2.Size = new Size(182, 64);
      this.GroupBox2.TabIndex = 33;
      this.GroupBox2.TabStop = false;
      this.GroupBox2.Text = "Curtain Details";
      this.chk_W_C_CurtainType.AutoSize = true;
      this.chk_W_C_CurtainType.Cursor = Cursors.Hand;
      this.chk_W_C_CurtainType.Location = new Point(6, 20);
      this.chk_W_C_CurtainType.Name = "chk_W_C_CurtainType";
      this.chk_W_C_CurtainType.Size = new Size(88, 17);
      this.chk_W_C_CurtainType.TabIndex = 27;
      this.chk_W_C_CurtainType.Text = "Curtain Type";
      this.chk_W_C_CurtainType.UseVisualStyleBackColor = true;
      this.chk_W_C_Fraction.AutoSize = true;
      this.chk_W_C_Fraction.Cursor = Cursors.Hand;
      this.chk_W_C_Fraction.Location = new Point(6, 43);
      this.chk_W_C_Fraction.Name = "chk_W_C_Fraction";
      this.chk_W_C_Fraction.Size = new Size(109, 17);
      this.chk_W_C_Fraction.TabIndex = 28;
      this.chk_W_C_Fraction.Text = "Fraction curtains ";
      this.chk_W_C_Fraction.UseVisualStyleBackColor = true;
      this.GroupBox1.Controls.Add((Control) this.chk_W_W_Transmittance);
      this.GroupBox1.Controls.Add((Control) this.chk_W_W_UValue);
      this.GroupBox1.Controls.Add((Control) this.chk_W_W_FF);
      this.GroupBox1.Location = new Point(12, 501);
      this.GroupBox1.Name = "GroupBox1";
      this.GroupBox1.Size = new Size(182, 88);
      this.GroupBox1.TabIndex = 32;
      this.GroupBox1.TabStop = false;
      this.GroupBox1.Text = "Window Properties";
      this.chk_W_W_Transmittance.AutoSize = true;
      this.chk_W_W_Transmittance.Cursor = Cursors.Hand;
      this.chk_W_W_Transmittance.Location = new Point(6, 20);
      this.chk_W_W_Transmittance.Name = "chk_W_W_Transmittance";
      this.chk_W_W_Transmittance.Size = new Size(139, 17);
      this.chk_W_W_Transmittance.TabIndex = 29;
      this.chk_W_W_Transmittance.Text = "Transmittance factor 'g'";
      this.chk_W_W_Transmittance.UseVisualStyleBackColor = true;
      this.chk_W_W_UValue.AutoSize = true;
      this.chk_W_W_UValue.Cursor = Cursors.Hand;
      this.chk_W_W_UValue.Location = new Point(6, 66);
      this.chk_W_W_UValue.Name = "chk_W_W_UValue";
      this.chk_W_W_UValue.Size = new Size(63, 17);
      this.chk_W_W_UValue.TabIndex = 31;
      this.chk_W_W_UValue.Text = "U-Value";
      this.chk_W_W_UValue.UseVisualStyleBackColor = true;
      this.chk_W_W_FF.AutoSize = true;
      this.chk_W_W_FF.Cursor = Cursors.Hand;
      this.chk_W_W_FF.Location = new Point(6, 43);
      this.chk_W_W_FF.Name = "chk_W_W_FF";
      this.chk_W_W_FF.Size = new Size(107, 17);
      this.chk_W_W_FF.TabIndex = 30;
      this.chk_W_W_FF.Text = "Frame factor 'FF'";
      this.chk_W_W_FF.UseVisualStyleBackColor = true;
      this.Label1.AutoSize = true;
      this.Label1.Font = new Font("Tahoma", 8.25f, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, (byte) 0);
      this.Label1.Location = new Point(13, 13);
      this.Label1.Name = "Label1";
      this.Label1.Size = new Size(125, 13);
      this.Label1.TabIndex = 13;
      this.Label1.Text = "Select Items to Copy";
      this.cmd_W_Copy.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.cmd_W_Copy.BackColor = Color.LightSlateGray;
      this.cmd_W_Copy.Cursor = Cursors.Hand;
      this.cmd_W_Copy.FlatStyle = FlatStyle.Popup;
      this.cmd_W_Copy.ForeColor = Color.White;
      this.cmd_W_Copy.Location = new Point(12, 646);
      this.cmd_W_Copy.Name = "cmd_W_Copy";
      this.cmd_W_Copy.Size = new Size(182, 23);
      this.cmd_W_Copy.TabIndex = 11;
      this.cmd_W_Copy.Text = "Copy to Selected Windows";
      this.cmd_W_Copy.UseVisualStyleBackColor = false;
      this.DG1.AllowUserToAddRows = false;
      this.DG1.AllowUserToDeleteRows = false;
      this.DG1.AllowUserToResizeRows = false;
      this.DG1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.DG1.Dock = DockStyle.Top;
      this.DG1.Location = new Point(600, 0);
      this.DG1.Name = "DG1";
      this.DG1.Size = new Size(151, 611);
      this.DG1.TabIndex = 1;
      this.pnlRWindow.BackColor = Color.White;
      this.pnlRWindow.Controls.Add((Control) this.cmd_RW_SNone);
      this.pnlRWindow.Controls.Add((Control) this.cmd_RW_SAll);
      this.pnlRWindow.Controls.Add((Control) this.GroupBox7);
      this.pnlRWindow.Controls.Add((Control) this.GroupBox8);
      this.pnlRWindow.Controls.Add((Control) this.GroupBox9);
      this.pnlRWindow.Controls.Add((Control) this.GroupBox10);
      this.pnlRWindow.Controls.Add((Control) this.GroupBox11);
      this.pnlRWindow.Controls.Add((Control) this.GroupBox12);
      this.pnlRWindow.Controls.Add((Control) this.Label2);
      this.pnlRWindow.Controls.Add((Control) this.cmd_RW_Copy);
      this.pnlRWindow.Dock = DockStyle.Left;
      this.pnlRWindow.Location = new Point(200, 0);
      this.pnlRWindow.Name = "pnlRWindow";
      this.pnlRWindow.Size = new Size(200, 668);
      this.pnlRWindow.TabIndex = 2;
      this.pnlRWindow.Visible = false;
      this.cmd_RW_SNone.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.cmd_RW_SNone.BackColor = Color.LightSlateGray;
      this.cmd_RW_SNone.Cursor = Cursors.Hand;
      this.cmd_RW_SNone.FlatStyle = FlatStyle.Popup;
      this.cmd_RW_SNone.ForeColor = Color.White;
      this.cmd_RW_SNone.Location = new Point(103, 617);
      this.cmd_RW_SNone.Name = "cmd_RW_SNone";
      this.cmd_RW_SNone.Size = new Size(90, 23);
      this.cmd_RW_SNone.TabIndex = 39;
      this.cmd_RW_SNone.Text = "Select None";
      this.cmd_RW_SNone.UseVisualStyleBackColor = false;
      this.cmd_RW_SAll.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.cmd_RW_SAll.BackColor = Color.LightSlateGray;
      this.cmd_RW_SAll.Cursor = Cursors.Hand;
      this.cmd_RW_SAll.FlatStyle = FlatStyle.Popup;
      this.cmd_RW_SAll.ForeColor = Color.White;
      this.cmd_RW_SAll.Location = new Point(12, 617);
      this.cmd_RW_SAll.Name = "cmd_RW_SAll";
      this.cmd_RW_SAll.Size = new Size(90, 23);
      this.cmd_RW_SAll.TabIndex = 38;
      this.cmd_RW_SAll.Text = "Select All";
      this.cmd_RW_SAll.UseVisualStyleBackColor = false;
      this.GroupBox7.Controls.Add((Control) this.chk_RW_G_Pitch);
      this.GroupBox7.Controls.Add((Control) this.chk_RW_G_Uvalue);
      this.GroupBox7.Controls.Add((Control) this.chk_RW_G_Orientation);
      this.GroupBox7.Controls.Add((Control) this.chk_RW_G_Overshading);
      this.GroupBox7.Location = new Point(12, 29);
      this.GroupBox7.Name = "GroupBox7";
      this.GroupBox7.Size = new Size(181, 110);
      this.GroupBox7.TabIndex = 37;
      this.GroupBox7.TabStop = false;
      this.GroupBox7.Text = "General";
      this.chk_RW_G_Pitch.AutoSize = true;
      this.chk_RW_G_Pitch.Cursor = Cursors.Hand;
      this.chk_RW_G_Pitch.Location = new Point(6, 43);
      this.chk_RW_G_Pitch.Name = "chk_RW_G_Pitch";
      this.chk_RW_G_Pitch.Size = new Size(49, 17);
      this.chk_RW_G_Pitch.TabIndex = 16;
      this.chk_RW_G_Pitch.Text = "Pitch";
      this.chk_RW_G_Pitch.UseVisualStyleBackColor = true;
      this.chk_RW_G_Uvalue.AutoSize = true;
      this.chk_RW_G_Uvalue.Cursor = Cursors.Hand;
      this.chk_RW_G_Uvalue.Location = new Point(6, 20);
      this.chk_RW_G_Uvalue.Name = "chk_RW_G_Uvalue";
      this.chk_RW_G_Uvalue.Size = new Size(99, 17);
      this.chk_RW_G_Uvalue.TabIndex = 12;
      this.chk_RW_G_Uvalue.Text = "U-Value Source";
      this.chk_RW_G_Uvalue.UseVisualStyleBackColor = true;
      this.chk_RW_G_Orientation.AutoSize = true;
      this.chk_RW_G_Orientation.Cursor = Cursors.Hand;
      this.chk_RW_G_Orientation.Location = new Point(6, 66);
      this.chk_RW_G_Orientation.Name = "chk_RW_G_Orientation";
      this.chk_RW_G_Orientation.Size = new Size(80, 17);
      this.chk_RW_G_Orientation.TabIndex = 14;
      this.chk_RW_G_Orientation.Text = "Orientation";
      this.chk_RW_G_Orientation.UseVisualStyleBackColor = true;
      this.chk_RW_G_Overshading.AutoSize = true;
      this.chk_RW_G_Overshading.Cursor = Cursors.Hand;
      this.chk_RW_G_Overshading.Location = new Point(6, 89);
      this.chk_RW_G_Overshading.Name = "chk_RW_G_Overshading";
      this.chk_RW_G_Overshading.Size = new Size(87, 17);
      this.chk_RW_G_Overshading.TabIndex = 15;
      this.chk_RW_G_Overshading.Text = "Overshading";
      this.chk_RW_G_Overshading.UseVisualStyleBackColor = true;
      this.GroupBox8.Controls.Add((Control) this.chk_RW_GS_GlazingType);
      this.GroupBox8.Controls.Add((Control) this.chk_RW_GS_AirGap);
      this.GroupBox8.Location = new Point(12, 145);
      this.GroupBox8.Name = "GroupBox8";
      this.GroupBox8.Size = new Size(182, 66);
      this.GroupBox8.TabIndex = 36;
      this.GroupBox8.TabStop = false;
      this.GroupBox8.Text = "Glazing Style";
      this.chk_RW_GS_GlazingType.AutoSize = true;
      this.chk_RW_GS_GlazingType.Cursor = Cursors.Hand;
      this.chk_RW_GS_GlazingType.Location = new Point(6, 20);
      this.chk_RW_GS_GlazingType.Name = "chk_RW_GS_GlazingType";
      this.chk_RW_GS_GlazingType.Size = new Size(87, 17);
      this.chk_RW_GS_GlazingType.TabIndex = 16;
      this.chk_RW_GS_GlazingType.Text = "Glazing Type";
      this.chk_RW_GS_GlazingType.UseVisualStyleBackColor = true;
      this.chk_RW_GS_AirGap.AutoSize = true;
      this.chk_RW_GS_AirGap.Cursor = Cursors.Hand;
      this.chk_RW_GS_AirGap.Location = new Point(6, 43);
      this.chk_RW_GS_AirGap.Name = "chk_RW_GS_AirGap";
      this.chk_RW_GS_AirGap.Size = new Size(61, 17);
      this.chk_RW_GS_AirGap.TabIndex = 17;
      this.chk_RW_GS_AirGap.Text = "Air Gap";
      this.chk_RW_GS_AirGap.UseVisualStyleBackColor = true;
      this.GroupBox9.Controls.Add((Control) this.chk_RW_F_Type);
      this.GroupBox9.Controls.Add((Control) this.chk_RW_F_Thermal);
      this.GroupBox9.Location = new Point(12, 217);
      this.GroupBox9.Name = "GroupBox9";
      this.GroupBox9.Size = new Size(182, 68);
      this.GroupBox9.TabIndex = 35;
      this.GroupBox9.TabStop = false;
      this.GroupBox9.Text = "Frame";
      this.chk_RW_F_Type.AutoSize = true;
      this.chk_RW_F_Type.Cursor = Cursors.Hand;
      this.chk_RW_F_Type.Location = new Point(6, 20);
      this.chk_RW_F_Type.Name = "chk_RW_F_Type";
      this.chk_RW_F_Type.Size = new Size(50, 17);
      this.chk_RW_F_Type.TabIndex = 18;
      this.chk_RW_F_Type.Text = "Type";
      this.chk_RW_F_Type.UseVisualStyleBackColor = true;
      this.chk_RW_F_Thermal.AutoSize = true;
      this.chk_RW_F_Thermal.Cursor = Cursors.Hand;
      this.chk_RW_F_Thermal.Location = new Point(6, 43);
      this.chk_RW_F_Thermal.Name = "chk_RW_F_Thermal";
      this.chk_RW_F_Thermal.Size = new Size(94, 17);
      this.chk_RW_F_Thermal.TabIndex = 19;
      this.chk_RW_F_Thermal.Text = "Thermal break";
      this.chk_RW_F_Thermal.UseVisualStyleBackColor = true;
      this.GroupBox10.Controls.Add((Control) this.chk_RW_S_Area);
      this.GroupBox10.Controls.Add((Control) this.chk_RW_S_Width);
      this.GroupBox10.Controls.Add((Control) this.chk_RW_S_Height);
      this.GroupBox10.Controls.Add((Control) this.chk_RW_S_OverDepth);
      this.GroupBox10.Controls.Add((Control) this.chk_RW_S_Count);
      this.GroupBox10.Controls.Add((Control) this.chk_RW_S_OverWidth);
      this.GroupBox10.Location = new Point(12, 291);
      this.GroupBox10.Name = "GroupBox10";
      this.GroupBox10.Size = new Size(182, 156);
      this.GroupBox10.TabIndex = 34;
      this.GroupBox10.TabStop = false;
      this.GroupBox10.Text = "Size";
      this.chk_RW_S_Area.AutoSize = true;
      this.chk_RW_S_Area.Cursor = Cursors.Hand;
      this.chk_RW_S_Area.Location = new Point(6, 20);
      this.chk_RW_S_Area.Name = "chk_RW_S_Area";
      this.chk_RW_S_Area.Size = new Size(49, 17);
      this.chk_RW_S_Area.TabIndex = 21;
      this.chk_RW_S_Area.Text = "Area";
      this.chk_RW_S_Area.UseVisualStyleBackColor = true;
      this.chk_RW_S_Width.AutoSize = true;
      this.chk_RW_S_Width.Cursor = Cursors.Hand;
      this.chk_RW_S_Width.Enabled = false;
      this.chk_RW_S_Width.Location = new Point(6, 43);
      this.chk_RW_S_Width.Name = "chk_RW_S_Width";
      this.chk_RW_S_Width.Size = new Size(54, 17);
      this.chk_RW_S_Width.TabIndex = 22;
      this.chk_RW_S_Width.Text = "Width";
      this.chk_RW_S_Width.UseVisualStyleBackColor = true;
      this.chk_RW_S_Height.AutoSize = true;
      this.chk_RW_S_Height.Cursor = Cursors.Hand;
      this.chk_RW_S_Height.Enabled = false;
      this.chk_RW_S_Height.Location = new Point(6, 66);
      this.chk_RW_S_Height.Name = "chk_RW_S_Height";
      this.chk_RW_S_Height.Size = new Size(57, 17);
      this.chk_RW_S_Height.TabIndex = 23;
      this.chk_RW_S_Height.Text = "Height";
      this.chk_RW_S_Height.UseVisualStyleBackColor = true;
      this.chk_RW_S_OverDepth.AutoSize = true;
      this.chk_RW_S_OverDepth.Cursor = Cursors.Hand;
      this.chk_RW_S_OverDepth.Location = new Point(6, 135);
      this.chk_RW_S_OverDepth.Name = "chk_RW_S_OverDepth";
      this.chk_RW_S_OverDepth.Size = new Size(106, 17);
      this.chk_RW_S_OverDepth.TabIndex = 26;
      this.chk_RW_S_OverDepth.Text = "Overhang Depth";
      this.chk_RW_S_OverDepth.UseVisualStyleBackColor = true;
      this.chk_RW_S_Count.AutoSize = true;
      this.chk_RW_S_Count.Cursor = Cursors.Hand;
      this.chk_RW_S_Count.Location = new Point(6, 89);
      this.chk_RW_S_Count.Name = "chk_RW_S_Count";
      this.chk_RW_S_Count.Size = new Size(55, 17);
      this.chk_RW_S_Count.TabIndex = 24;
      this.chk_RW_S_Count.Text = "Count";
      this.chk_RW_S_Count.UseVisualStyleBackColor = true;
      this.chk_RW_S_OverWidth.AutoSize = true;
      this.chk_RW_S_OverWidth.Cursor = Cursors.Hand;
      this.chk_RW_S_OverWidth.Location = new Point(6, 112);
      this.chk_RW_S_OverWidth.Name = "chk_RW_S_OverWidth";
      this.chk_RW_S_OverWidth.Size = new Size(105, 17);
      this.chk_RW_S_OverWidth.TabIndex = 25;
      this.chk_RW_S_OverWidth.Text = "Overhang Width";
      this.chk_RW_S_OverWidth.UseVisualStyleBackColor = true;
      this.GroupBox11.Controls.Add((Control) this.chk_RW_C_CurtainType);
      this.GroupBox11.Controls.Add((Control) this.chk_RW_C_Fraction);
      this.GroupBox11.Location = new Point(12, 453);
      this.GroupBox11.Name = "GroupBox11";
      this.GroupBox11.Size = new Size(182, 64);
      this.GroupBox11.TabIndex = 33;
      this.GroupBox11.TabStop = false;
      this.GroupBox11.Text = "Curtain Details";
      this.chk_RW_C_CurtainType.AutoSize = true;
      this.chk_RW_C_CurtainType.Cursor = Cursors.Hand;
      this.chk_RW_C_CurtainType.Location = new Point(6, 20);
      this.chk_RW_C_CurtainType.Name = "chk_RW_C_CurtainType";
      this.chk_RW_C_CurtainType.Size = new Size(88, 17);
      this.chk_RW_C_CurtainType.TabIndex = 27;
      this.chk_RW_C_CurtainType.Text = "Curtain Type";
      this.chk_RW_C_CurtainType.UseVisualStyleBackColor = true;
      this.chk_RW_C_Fraction.AutoSize = true;
      this.chk_RW_C_Fraction.Cursor = Cursors.Hand;
      this.chk_RW_C_Fraction.Location = new Point(6, 43);
      this.chk_RW_C_Fraction.Name = "chk_RW_C_Fraction";
      this.chk_RW_C_Fraction.Size = new Size(109, 17);
      this.chk_RW_C_Fraction.TabIndex = 28;
      this.chk_RW_C_Fraction.Text = "Fraction curtains ";
      this.chk_RW_C_Fraction.UseVisualStyleBackColor = true;
      this.GroupBox12.Controls.Add((Control) this.chk_RW_W_Transmittance);
      this.GroupBox12.Controls.Add((Control) this.chk_RW_W_UValue);
      this.GroupBox12.Controls.Add((Control) this.chk_RW_W_FF);
      this.GroupBox12.Location = new Point(12, 523);
      this.GroupBox12.Name = "GroupBox12";
      this.GroupBox12.Size = new Size(182, 88);
      this.GroupBox12.TabIndex = 32;
      this.GroupBox12.TabStop = false;
      this.GroupBox12.Text = "Roof Window Properties";
      this.chk_RW_W_Transmittance.AutoSize = true;
      this.chk_RW_W_Transmittance.Cursor = Cursors.Hand;
      this.chk_RW_W_Transmittance.Location = new Point(6, 20);
      this.chk_RW_W_Transmittance.Name = "chk_RW_W_Transmittance";
      this.chk_RW_W_Transmittance.Size = new Size(139, 17);
      this.chk_RW_W_Transmittance.TabIndex = 29;
      this.chk_RW_W_Transmittance.Text = "Transmittance factor 'g'";
      this.chk_RW_W_Transmittance.UseVisualStyleBackColor = true;
      this.chk_RW_W_UValue.AutoSize = true;
      this.chk_RW_W_UValue.Cursor = Cursors.Hand;
      this.chk_RW_W_UValue.Location = new Point(6, 66);
      this.chk_RW_W_UValue.Name = "chk_RW_W_UValue";
      this.chk_RW_W_UValue.Size = new Size(63, 17);
      this.chk_RW_W_UValue.TabIndex = 31;
      this.chk_RW_W_UValue.Text = "U-Value";
      this.chk_RW_W_UValue.UseVisualStyleBackColor = true;
      this.chk_RW_W_FF.AutoSize = true;
      this.chk_RW_W_FF.Cursor = Cursors.Hand;
      this.chk_RW_W_FF.Location = new Point(6, 43);
      this.chk_RW_W_FF.Name = "chk_RW_W_FF";
      this.chk_RW_W_FF.Size = new Size(107, 17);
      this.chk_RW_W_FF.TabIndex = 30;
      this.chk_RW_W_FF.Text = "Frame factor 'FF'";
      this.chk_RW_W_FF.UseVisualStyleBackColor = true;
      this.Label2.AutoSize = true;
      this.Label2.Font = new Font("Tahoma", 8.25f, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, (byte) 0);
      this.Label2.Location = new Point(13, 13);
      this.Label2.Name = "Label2";
      this.Label2.Size = new Size(125, 13);
      this.Label2.TabIndex = 13;
      this.Label2.Text = "Select Items to Copy";
      this.cmd_RW_Copy.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.cmd_RW_Copy.BackColor = Color.LightSlateGray;
      this.cmd_RW_Copy.Cursor = Cursors.Hand;
      this.cmd_RW_Copy.FlatStyle = FlatStyle.Popup;
      this.cmd_RW_Copy.ForeColor = Color.White;
      this.cmd_RW_Copy.Location = new Point(12, 646);
      this.cmd_RW_Copy.Name = "cmd_RW_Copy";
      this.cmd_RW_Copy.Size = new Size(182, 23);
      this.cmd_RW_Copy.TabIndex = 11;
      this.cmd_RW_Copy.Text = "Copy to Selected Roof Windows";
      this.cmd_RW_Copy.UseVisualStyleBackColor = false;
      this.pnlDoor.BackColor = Color.White;
      this.pnlDoor.Controls.Add((Control) this.cmd_D_SNone);
      this.pnlDoor.Controls.Add((Control) this.cmd_D_SAll);
      this.pnlDoor.Controls.Add((Control) this.GroupBox13);
      this.pnlDoor.Controls.Add((Control) this.GroupBox14);
      this.pnlDoor.Controls.Add((Control) this.GroupBox15);
      this.pnlDoor.Controls.Add((Control) this.GroupBox16);
      this.pnlDoor.Controls.Add((Control) this.GroupBox18);
      this.pnlDoor.Controls.Add((Control) this.Label3);
      this.pnlDoor.Controls.Add((Control) this.cmd_D_Copy);
      this.pnlDoor.Dock = DockStyle.Left;
      this.pnlDoor.Location = new Point(400, 0);
      this.pnlDoor.Name = "pnlDoor";
      this.pnlDoor.Size = new Size(200, 668);
      this.pnlDoor.TabIndex = 3;
      this.pnlDoor.Visible = false;
      this.cmd_D_SNone.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.cmd_D_SNone.BackColor = Color.LightSlateGray;
      this.cmd_D_SNone.Cursor = Cursors.Hand;
      this.cmd_D_SNone.FlatStyle = FlatStyle.Popup;
      this.cmd_D_SNone.ForeColor = Color.White;
      this.cmd_D_SNone.Location = new Point(103, 617);
      this.cmd_D_SNone.Name = "cmd_D_SNone";
      this.cmd_D_SNone.Size = new Size(90, 23);
      this.cmd_D_SNone.TabIndex = 39;
      this.cmd_D_SNone.Text = "Select None";
      this.cmd_D_SNone.UseVisualStyleBackColor = false;
      this.cmd_D_SAll.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.cmd_D_SAll.BackColor = Color.LightSlateGray;
      this.cmd_D_SAll.Cursor = Cursors.Hand;
      this.cmd_D_SAll.FlatStyle = FlatStyle.Popup;
      this.cmd_D_SAll.ForeColor = Color.White;
      this.cmd_D_SAll.Location = new Point(12, 617);
      this.cmd_D_SAll.Name = "cmd_D_SAll";
      this.cmd_D_SAll.Size = new Size(90, 23);
      this.cmd_D_SAll.TabIndex = 38;
      this.cmd_D_SAll.Text = "Select All";
      this.cmd_D_SAll.UseVisualStyleBackColor = false;
      this.GroupBox13.Controls.Add((Control) this.chk_D_G_Type);
      this.GroupBox13.Controls.Add((Control) this.chk_D_G_Uvalue);
      this.GroupBox13.Controls.Add((Control) this.chk_D_G_Orientation);
      this.GroupBox13.Controls.Add((Control) this.chk_D_G_Overshading);
      this.GroupBox13.Location = new Point(12, 29);
      this.GroupBox13.Name = "GroupBox13";
      this.GroupBox13.Size = new Size(181, 110);
      this.GroupBox13.TabIndex = 37;
      this.GroupBox13.TabStop = false;
      this.GroupBox13.Text = "General";
      this.chk_D_G_Type.AutoSize = true;
      this.chk_D_G_Type.Cursor = Cursors.Hand;
      this.chk_D_G_Type.Location = new Point(6, 43);
      this.chk_D_G_Type.Name = "chk_D_G_Type";
      this.chk_D_G_Type.Size = new Size(76, 17);
      this.chk_D_G_Type.TabIndex = 16;
      this.chk_D_G_Type.Text = "Door Type";
      this.chk_D_G_Type.UseVisualStyleBackColor = true;
      this.chk_D_G_Uvalue.AutoSize = true;
      this.chk_D_G_Uvalue.Cursor = Cursors.Hand;
      this.chk_D_G_Uvalue.Location = new Point(6, 20);
      this.chk_D_G_Uvalue.Name = "chk_D_G_Uvalue";
      this.chk_D_G_Uvalue.Size = new Size(99, 17);
      this.chk_D_G_Uvalue.TabIndex = 12;
      this.chk_D_G_Uvalue.Text = "U-Value Source";
      this.chk_D_G_Uvalue.UseVisualStyleBackColor = true;
      this.chk_D_G_Orientation.AutoSize = true;
      this.chk_D_G_Orientation.Cursor = Cursors.Hand;
      this.chk_D_G_Orientation.Location = new Point(6, 66);
      this.chk_D_G_Orientation.Name = "chk_D_G_Orientation";
      this.chk_D_G_Orientation.Size = new Size(80, 17);
      this.chk_D_G_Orientation.TabIndex = 14;
      this.chk_D_G_Orientation.Text = "Orientation";
      this.chk_D_G_Orientation.UseVisualStyleBackColor = true;
      this.chk_D_G_Overshading.AutoSize = true;
      this.chk_D_G_Overshading.Cursor = Cursors.Hand;
      this.chk_D_G_Overshading.Location = new Point(6, 89);
      this.chk_D_G_Overshading.Name = "chk_D_G_Overshading";
      this.chk_D_G_Overshading.Size = new Size(87, 17);
      this.chk_D_G_Overshading.TabIndex = 15;
      this.chk_D_G_Overshading.Text = "Overshading";
      this.chk_D_G_Overshading.UseVisualStyleBackColor = true;
      this.GroupBox14.Controls.Add((Control) this.chk_D_GS_GlazingType);
      this.GroupBox14.Controls.Add((Control) this.chk_D_GS_AirGap);
      this.GroupBox14.Location = new Point(11, 145);
      this.GroupBox14.Name = "GroupBox14";
      this.GroupBox14.Size = new Size(182, 66);
      this.GroupBox14.TabIndex = 36;
      this.GroupBox14.TabStop = false;
      this.GroupBox14.Text = "Glazing Style";
      this.chk_D_GS_GlazingType.AutoSize = true;
      this.chk_D_GS_GlazingType.Cursor = Cursors.Hand;
      this.chk_D_GS_GlazingType.Location = new Point(6, 20);
      this.chk_D_GS_GlazingType.Name = "chk_D_GS_GlazingType";
      this.chk_D_GS_GlazingType.Size = new Size(87, 17);
      this.chk_D_GS_GlazingType.TabIndex = 16;
      this.chk_D_GS_GlazingType.Text = "Glazing Type";
      this.chk_D_GS_GlazingType.UseVisualStyleBackColor = true;
      this.chk_D_GS_AirGap.AutoSize = true;
      this.chk_D_GS_AirGap.Cursor = Cursors.Hand;
      this.chk_D_GS_AirGap.Location = new Point(6, 43);
      this.chk_D_GS_AirGap.Name = "chk_D_GS_AirGap";
      this.chk_D_GS_AirGap.Size = new Size(61, 17);
      this.chk_D_GS_AirGap.TabIndex = 17;
      this.chk_D_GS_AirGap.Text = "Air Gap";
      this.chk_D_GS_AirGap.UseVisualStyleBackColor = true;
      this.GroupBox15.Controls.Add((Control) this.chk_D_F_Type);
      this.GroupBox15.Controls.Add((Control) this.chk_D_F_Thermal);
      this.GroupBox15.Location = new Point(11, 217);
      this.GroupBox15.Name = "GroupBox15";
      this.GroupBox15.Size = new Size(182, 68);
      this.GroupBox15.TabIndex = 35;
      this.GroupBox15.TabStop = false;
      this.GroupBox15.Text = "Frame";
      this.chk_D_F_Type.AutoSize = true;
      this.chk_D_F_Type.Cursor = Cursors.Hand;
      this.chk_D_F_Type.Location = new Point(6, 20);
      this.chk_D_F_Type.Name = "chk_D_F_Type";
      this.chk_D_F_Type.Size = new Size(50, 17);
      this.chk_D_F_Type.TabIndex = 18;
      this.chk_D_F_Type.Text = "Type";
      this.chk_D_F_Type.UseVisualStyleBackColor = true;
      this.chk_D_F_Thermal.AutoSize = true;
      this.chk_D_F_Thermal.Cursor = Cursors.Hand;
      this.chk_D_F_Thermal.Location = new Point(6, 43);
      this.chk_D_F_Thermal.Name = "chk_D_F_Thermal";
      this.chk_D_F_Thermal.Size = new Size(94, 17);
      this.chk_D_F_Thermal.TabIndex = 19;
      this.chk_D_F_Thermal.Text = "Thermal break";
      this.chk_D_F_Thermal.UseVisualStyleBackColor = true;
      this.GroupBox16.Controls.Add((Control) this.chk_D_S_Area);
      this.GroupBox16.Controls.Add((Control) this.chk_D_S_Width);
      this.GroupBox16.Controls.Add((Control) this.chk_D_S_Height);
      this.GroupBox16.Controls.Add((Control) this.chk_D_S_OverDepth);
      this.GroupBox16.Controls.Add((Control) this.chk_D_S_Count);
      this.GroupBox16.Controls.Add((Control) this.chk_D_S_OverWidth);
      this.GroupBox16.Location = new Point(11, 291);
      this.GroupBox16.Name = "GroupBox16";
      this.GroupBox16.Size = new Size(182, 156);
      this.GroupBox16.TabIndex = 34;
      this.GroupBox16.TabStop = false;
      this.GroupBox16.Text = "Size";
      this.chk_D_S_Area.AutoSize = true;
      this.chk_D_S_Area.Cursor = Cursors.Hand;
      this.chk_D_S_Area.Location = new Point(6, 20);
      this.chk_D_S_Area.Name = "chk_D_S_Area";
      this.chk_D_S_Area.Size = new Size(49, 17);
      this.chk_D_S_Area.TabIndex = 21;
      this.chk_D_S_Area.Text = "Area";
      this.chk_D_S_Area.UseVisualStyleBackColor = true;
      this.chk_D_S_Width.AutoSize = true;
      this.chk_D_S_Width.Cursor = Cursors.Hand;
      this.chk_D_S_Width.Enabled = false;
      this.chk_D_S_Width.Location = new Point(6, 43);
      this.chk_D_S_Width.Name = "chk_D_S_Width";
      this.chk_D_S_Width.Size = new Size(54, 17);
      this.chk_D_S_Width.TabIndex = 22;
      this.chk_D_S_Width.Text = "Width";
      this.chk_D_S_Width.UseVisualStyleBackColor = true;
      this.chk_D_S_Height.AutoSize = true;
      this.chk_D_S_Height.Cursor = Cursors.Hand;
      this.chk_D_S_Height.Enabled = false;
      this.chk_D_S_Height.Location = new Point(6, 66);
      this.chk_D_S_Height.Name = "chk_D_S_Height";
      this.chk_D_S_Height.Size = new Size(57, 17);
      this.chk_D_S_Height.TabIndex = 23;
      this.chk_D_S_Height.Text = "Height";
      this.chk_D_S_Height.UseVisualStyleBackColor = true;
      this.chk_D_S_OverDepth.AutoSize = true;
      this.chk_D_S_OverDepth.Cursor = Cursors.Hand;
      this.chk_D_S_OverDepth.Location = new Point(6, 135);
      this.chk_D_S_OverDepth.Name = "chk_D_S_OverDepth";
      this.chk_D_S_OverDepth.Size = new Size(106, 17);
      this.chk_D_S_OverDepth.TabIndex = 26;
      this.chk_D_S_OverDepth.Text = "Overhang Depth";
      this.chk_D_S_OverDepth.UseVisualStyleBackColor = true;
      this.chk_D_S_Count.AutoSize = true;
      this.chk_D_S_Count.Cursor = Cursors.Hand;
      this.chk_D_S_Count.Location = new Point(6, 89);
      this.chk_D_S_Count.Name = "chk_D_S_Count";
      this.chk_D_S_Count.Size = new Size(55, 17);
      this.chk_D_S_Count.TabIndex = 24;
      this.chk_D_S_Count.Text = "Count";
      this.chk_D_S_Count.UseVisualStyleBackColor = true;
      this.chk_D_S_OverWidth.AutoSize = true;
      this.chk_D_S_OverWidth.Cursor = Cursors.Hand;
      this.chk_D_S_OverWidth.Location = new Point(6, 112);
      this.chk_D_S_OverWidth.Name = "chk_D_S_OverWidth";
      this.chk_D_S_OverWidth.Size = new Size(105, 17);
      this.chk_D_S_OverWidth.TabIndex = 25;
      this.chk_D_S_OverWidth.Text = "Overhang Width";
      this.chk_D_S_OverWidth.UseVisualStyleBackColor = true;
      this.GroupBox18.Controls.Add((Control) this.chk_D_W_Transmittance);
      this.GroupBox18.Controls.Add((Control) this.chk_D_W_UValue);
      this.GroupBox18.Controls.Add((Control) this.chk_D_W_FF);
      this.GroupBox18.Location = new Point(11, 453);
      this.GroupBox18.Name = "GroupBox18";
      this.GroupBox18.Size = new Size(182, 88);
      this.GroupBox18.TabIndex = 32;
      this.GroupBox18.TabStop = false;
      this.GroupBox18.Text = "Door Properties";
      this.chk_D_W_Transmittance.AutoSize = true;
      this.chk_D_W_Transmittance.Cursor = Cursors.Hand;
      this.chk_D_W_Transmittance.Location = new Point(6, 20);
      this.chk_D_W_Transmittance.Name = "chk_D_W_Transmittance";
      this.chk_D_W_Transmittance.Size = new Size(139, 17);
      this.chk_D_W_Transmittance.TabIndex = 29;
      this.chk_D_W_Transmittance.Text = "Transmittance factor 'g'";
      this.chk_D_W_Transmittance.UseVisualStyleBackColor = true;
      this.chk_D_W_UValue.AutoSize = true;
      this.chk_D_W_UValue.Cursor = Cursors.Hand;
      this.chk_D_W_UValue.Location = new Point(6, 66);
      this.chk_D_W_UValue.Name = "chk_D_W_UValue";
      this.chk_D_W_UValue.Size = new Size(63, 17);
      this.chk_D_W_UValue.TabIndex = 31;
      this.chk_D_W_UValue.Text = "U-Value";
      this.chk_D_W_UValue.UseVisualStyleBackColor = true;
      this.chk_D_W_FF.AutoSize = true;
      this.chk_D_W_FF.Cursor = Cursors.Hand;
      this.chk_D_W_FF.Location = new Point(6, 43);
      this.chk_D_W_FF.Name = "chk_D_W_FF";
      this.chk_D_W_FF.Size = new Size(107, 17);
      this.chk_D_W_FF.TabIndex = 30;
      this.chk_D_W_FF.Text = "Frame factor 'FF'";
      this.chk_D_W_FF.UseVisualStyleBackColor = true;
      this.Label3.AutoSize = true;
      this.Label3.Font = new Font("Tahoma", 8.25f, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, (byte) 0);
      this.Label3.Location = new Point(13, 13);
      this.Label3.Name = "Label3";
      this.Label3.Size = new Size(125, 13);
      this.Label3.TabIndex = 13;
      this.Label3.Text = "Select Items to Copy";
      this.cmd_D_Copy.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.cmd_D_Copy.BackColor = Color.LightSlateGray;
      this.cmd_D_Copy.Cursor = Cursors.Hand;
      this.cmd_D_Copy.FlatStyle = FlatStyle.Popup;
      this.cmd_D_Copy.ForeColor = Color.White;
      this.cmd_D_Copy.Location = new Point(12, 646);
      this.cmd_D_Copy.Name = "cmd_D_Copy";
      this.cmd_D_Copy.Size = new Size(182, 23);
      this.cmd_D_Copy.TabIndex = 11;
      this.cmd_D_Copy.Text = "Copy to Selected Doors";
      this.cmd_D_Copy.UseVisualStyleBackColor = false;
      this.cmdSAll.BackColor = Color.LightSlateGray;
      this.cmdSAll.Cursor = Cursors.Hand;
      this.cmdSAll.FlatStyle = FlatStyle.Popup;
      this.cmdSAll.ForeColor = Color.White;
      this.cmdSAll.Location = new Point(606, 613);
      this.cmdSAll.Name = "cmdSAll";
      this.cmdSAll.Size = new Size(59, 27);
      this.cmdSAll.TabIndex = 39;
      this.cmdSAll.Text = "Select All";
      this.cmdSAll.UseVisualStyleBackColor = false;
      this.cmdSNone.BackColor = Color.LightSlateGray;
      this.cmdSNone.Cursor = Cursors.Hand;
      this.cmdSNone.FlatStyle = FlatStyle.Popup;
      this.cmdSNone.ForeColor = Color.White;
      this.cmdSNone.Location = new Point(671, 613);
      this.cmdSNone.Name = "cmdSNone";
      this.cmdSNone.Size = new Size(74, 27);
      this.cmdSNone.TabIndex = 40;
      this.cmdSNone.Text = "Select None";
      this.cmdSNone.UseVisualStyleBackColor = false;
      this.Button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.Button1.BackColor = Color.LightSlateGray;
      this.Button1.Cursor = Cursors.Hand;
      this.Button1.FlatStyle = FlatStyle.Popup;
      this.Button1.ForeColor = Color.White;
      this.Button1.Location = new Point(606, 642);
      this.Button1.Name = "Button1";
      this.Button1.Size = new Size(139, 27);
      this.Button1.TabIndex = 41;
      this.Button1.Text = "Cancel";
      this.Button1.UseVisualStyleBackColor = false;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(751, 668);
      this.Controls.Add((Control) this.Button1);
      this.Controls.Add((Control) this.cmdSAll);
      this.Controls.Add((Control) this.cmdSNone);
      this.Controls.Add((Control) this.DG1);
      this.Controls.Add((Control) this.pnlDoor);
      this.Controls.Add((Control) this.pnlRWindow);
      this.Controls.Add((Control) this.pnlWindow);
      this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MaximumSize = new Size(768, 715);
      this.Name = nameof (Copy_Opening);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Copy Openings";
      this.pnlWindow.ResumeLayout(false);
      this.pnlWindow.PerformLayout();
      this.GroupBox6.ResumeLayout(false);
      this.GroupBox6.PerformLayout();
      this.GroupBox5.ResumeLayout(false);
      this.GroupBox5.PerformLayout();
      this.GroupBox4.ResumeLayout(false);
      this.GroupBox4.PerformLayout();
      this.GroupBox3.ResumeLayout(false);
      this.GroupBox3.PerformLayout();
      this.GroupBox2.ResumeLayout(false);
      this.GroupBox2.PerformLayout();
      this.GroupBox1.ResumeLayout(false);
      this.GroupBox1.PerformLayout();
      ((ISupportInitialize) this.DG1).EndInit();
      this.pnlRWindow.ResumeLayout(false);
      this.pnlRWindow.PerformLayout();
      this.GroupBox7.ResumeLayout(false);
      this.GroupBox7.PerformLayout();
      this.GroupBox8.ResumeLayout(false);
      this.GroupBox8.PerformLayout();
      this.GroupBox9.ResumeLayout(false);
      this.GroupBox9.PerformLayout();
      this.GroupBox10.ResumeLayout(false);
      this.GroupBox10.PerformLayout();
      this.GroupBox11.ResumeLayout(false);
      this.GroupBox11.PerformLayout();
      this.GroupBox12.ResumeLayout(false);
      this.GroupBox12.PerformLayout();
      this.pnlDoor.ResumeLayout(false);
      this.pnlDoor.PerformLayout();
      this.GroupBox13.ResumeLayout(false);
      this.GroupBox13.PerformLayout();
      this.GroupBox14.ResumeLayout(false);
      this.GroupBox14.PerformLayout();
      this.GroupBox15.ResumeLayout(false);
      this.GroupBox15.PerformLayout();
      this.GroupBox16.ResumeLayout(false);
      this.GroupBox16.PerformLayout();
      this.GroupBox18.ResumeLayout(false);
      this.GroupBox18.PerformLayout();
      this.ResumeLayout(false);
    }

    [field: AccessedThroughProperty("pnlWindow")]
    internal virtual Panel pnlWindow { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DG1")]
    internal virtual DataGridView DG1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button cmd_W_Copy
    {
      get => this._cmd_W_Copy;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmd_W_Copy_Click);
        Button cmdWCopy1 = this._cmd_W_Copy;
        if (cmdWCopy1 != null)
          cmdWCopy1.Click -= eventHandler;
        this._cmd_W_Copy = value;
        Button cmdWCopy2 = this._cmd_W_Copy;
        if (cmdWCopy2 == null)
          return;
        cmdWCopy2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("chk_W_G_Uvalue")]
    internal virtual CheckBox chk_W_G_Uvalue { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_W_C_CurtainType")]
    internal virtual CheckBox chk_W_C_CurtainType { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_W_S_OverDepth")]
    internal virtual CheckBox chk_W_S_OverDepth { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_W_S_OverWidth")]
    internal virtual CheckBox chk_W_S_OverWidth { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_W_S_Count")]
    internal virtual CheckBox chk_W_S_Count { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_W_S_Height")]
    internal virtual CheckBox chk_W_S_Height { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_W_S_Width")]
    internal virtual CheckBox chk_W_S_Width { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox chk_W_S_Area
    {
      get => this._chk_W_S_Area;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chk_W_S_Area_CheckedChanged);
        CheckBox chkWSArea1 = this._chk_W_S_Area;
        if (chkWSArea1 != null)
          chkWSArea1.CheckedChanged -= eventHandler;
        this._chk_W_S_Area = value;
        CheckBox chkWSArea2 = this._chk_W_S_Area;
        if (chkWSArea2 == null)
          return;
        chkWSArea2.CheckedChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("chk_W_F_Thermal")]
    internal virtual CheckBox chk_W_F_Thermal { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_W_F_Type")]
    internal virtual CheckBox chk_W_F_Type { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_W_GS_AirGap")]
    internal virtual CheckBox chk_W_GS_AirGap { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_W_GS_GlazingType")]
    internal virtual CheckBox chk_W_GS_GlazingType { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_W_G_Overshading")]
    internal virtual CheckBox chk_W_G_Overshading { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_W_G_Orientation")]
    internal virtual CheckBox chk_W_G_Orientation { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label1")]
    internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_W_W_UValue")]
    internal virtual CheckBox chk_W_W_UValue { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_W_W_FF")]
    internal virtual CheckBox chk_W_W_FF { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_W_W_Transmittance")]
    internal virtual CheckBox chk_W_W_Transmittance { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_W_C_Fraction")]
    internal virtual CheckBox chk_W_C_Fraction { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox2")]
    internal virtual GroupBox GroupBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox1")]
    internal virtual GroupBox GroupBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox3")]
    internal virtual GroupBox GroupBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox4")]
    internal virtual GroupBox GroupBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button cmd_W_SNone
    {
      get => this._cmd_W_SNone;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmd_W_SNone_Click);
        Button cmdWSnone1 = this._cmd_W_SNone;
        if (cmdWSnone1 != null)
          cmdWSnone1.Click -= eventHandler;
        this._cmd_W_SNone = value;
        Button cmdWSnone2 = this._cmd_W_SNone;
        if (cmdWSnone2 == null)
          return;
        cmdWSnone2.Click += eventHandler;
      }
    }

    internal virtual Button cmd_W_SAll
    {
      get => this._cmd_W_SAll;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmd_W_SAll_Click);
        Button cmdWSall1 = this._cmd_W_SAll;
        if (cmdWSall1 != null)
          cmdWSall1.Click -= eventHandler;
        this._cmd_W_SAll = value;
        Button cmdWSall2 = this._cmd_W_SAll;
        if (cmdWSall2 == null)
          return;
        cmdWSall2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("GroupBox6")]
    internal virtual GroupBox GroupBox6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox5")]
    internal virtual GroupBox GroupBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("pnlRWindow")]
    internal virtual Panel pnlRWindow { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button cmd_RW_SNone
    {
      get => this._cmd_RW_SNone;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmd_RW_SNone_Click);
        Button cmdRwSnone1 = this._cmd_RW_SNone;
        if (cmdRwSnone1 != null)
          cmdRwSnone1.Click -= eventHandler;
        this._cmd_RW_SNone = value;
        Button cmdRwSnone2 = this._cmd_RW_SNone;
        if (cmdRwSnone2 == null)
          return;
        cmdRwSnone2.Click += eventHandler;
      }
    }

    internal virtual Button cmd_RW_SAll
    {
      get => this._cmd_RW_SAll;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmd_RW_SAll_Click);
        Button cmdRwSall1 = this._cmd_RW_SAll;
        if (cmdRwSall1 != null)
          cmdRwSall1.Click -= eventHandler;
        this._cmd_RW_SAll = value;
        Button cmdRwSall2 = this._cmd_RW_SAll;
        if (cmdRwSall2 == null)
          return;
        cmdRwSall2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("GroupBox7")]
    internal virtual GroupBox GroupBox7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_RW_G_Uvalue")]
    internal virtual CheckBox chk_RW_G_Uvalue { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_RW_G_Orientation")]
    internal virtual CheckBox chk_RW_G_Orientation { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_RW_G_Overshading")]
    internal virtual CheckBox chk_RW_G_Overshading { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox8")]
    internal virtual GroupBox GroupBox8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_RW_GS_GlazingType")]
    internal virtual CheckBox chk_RW_GS_GlazingType { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_RW_GS_AirGap")]
    internal virtual CheckBox chk_RW_GS_AirGap { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox9")]
    internal virtual GroupBox GroupBox9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_RW_F_Type")]
    internal virtual CheckBox chk_RW_F_Type { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_RW_F_Thermal")]
    internal virtual CheckBox chk_RW_F_Thermal { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox10")]
    internal virtual GroupBox GroupBox10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox chk_RW_S_Area
    {
      get => this._chk_RW_S_Area;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chk_RW_S_Area_CheckedChanged);
        CheckBox chkRwSArea1 = this._chk_RW_S_Area;
        if (chkRwSArea1 != null)
          chkRwSArea1.CheckedChanged -= eventHandler;
        this._chk_RW_S_Area = value;
        CheckBox chkRwSArea2 = this._chk_RW_S_Area;
        if (chkRwSArea2 == null)
          return;
        chkRwSArea2.CheckedChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("chk_RW_S_Width")]
    internal virtual CheckBox chk_RW_S_Width { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_RW_S_Height")]
    internal virtual CheckBox chk_RW_S_Height { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_RW_S_OverDepth")]
    internal virtual CheckBox chk_RW_S_OverDepth { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_RW_S_Count")]
    internal virtual CheckBox chk_RW_S_Count { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_RW_S_OverWidth")]
    internal virtual CheckBox chk_RW_S_OverWidth { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox11")]
    internal virtual GroupBox GroupBox11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_RW_C_CurtainType")]
    internal virtual CheckBox chk_RW_C_CurtainType { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_RW_C_Fraction")]
    internal virtual CheckBox chk_RW_C_Fraction { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox12")]
    internal virtual GroupBox GroupBox12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_RW_W_Transmittance")]
    internal virtual CheckBox chk_RW_W_Transmittance { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_RW_W_UValue")]
    internal virtual CheckBox chk_RW_W_UValue { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_RW_W_FF")]
    internal virtual CheckBox chk_RW_W_FF { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label2")]
    internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button cmd_RW_Copy
    {
      get => this._cmd_RW_Copy;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmd_RW_Copy_Click);
        Button cmdRwCopy1 = this._cmd_RW_Copy;
        if (cmdRwCopy1 != null)
          cmdRwCopy1.Click -= eventHandler;
        this._cmd_RW_Copy = value;
        Button cmdRwCopy2 = this._cmd_RW_Copy;
        if (cmdRwCopy2 == null)
          return;
        cmdRwCopy2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("pnlDoor")]
    internal virtual Panel pnlDoor { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button cmd_D_SNone
    {
      get => this._cmd_D_SNone;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmd_D_SNone_Click);
        Button cmdDSnone1 = this._cmd_D_SNone;
        if (cmdDSnone1 != null)
          cmdDSnone1.Click -= eventHandler;
        this._cmd_D_SNone = value;
        Button cmdDSnone2 = this._cmd_D_SNone;
        if (cmdDSnone2 == null)
          return;
        cmdDSnone2.Click += eventHandler;
      }
    }

    internal virtual Button cmd_D_SAll
    {
      get => this._cmd_D_SAll;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmd_D_SAll_Click);
        Button cmdDSall1 = this._cmd_D_SAll;
        if (cmdDSall1 != null)
          cmdDSall1.Click -= eventHandler;
        this._cmd_D_SAll = value;
        Button cmdDSall2 = this._cmd_D_SAll;
        if (cmdDSall2 == null)
          return;
        cmdDSall2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("GroupBox13")]
    internal virtual GroupBox GroupBox13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_D_G_Uvalue")]
    internal virtual CheckBox chk_D_G_Uvalue { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_D_G_Orientation")]
    internal virtual CheckBox chk_D_G_Orientation { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_D_G_Overshading")]
    internal virtual CheckBox chk_D_G_Overshading { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox14")]
    internal virtual GroupBox GroupBox14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_D_GS_GlazingType")]
    internal virtual CheckBox chk_D_GS_GlazingType { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_D_GS_AirGap")]
    internal virtual CheckBox chk_D_GS_AirGap { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox15")]
    internal virtual GroupBox GroupBox15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_D_F_Type")]
    internal virtual CheckBox chk_D_F_Type { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_D_F_Thermal")]
    internal virtual CheckBox chk_D_F_Thermal { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox16")]
    internal virtual GroupBox GroupBox16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox chk_D_S_Area
    {
      get => this._chk_D_S_Area;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chk_D_S_Area_CheckedChanged);
        CheckBox chkDSArea1 = this._chk_D_S_Area;
        if (chkDSArea1 != null)
          chkDSArea1.CheckedChanged -= eventHandler;
        this._chk_D_S_Area = value;
        CheckBox chkDSArea2 = this._chk_D_S_Area;
        if (chkDSArea2 == null)
          return;
        chkDSArea2.CheckedChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("chk_D_S_Width")]
    internal virtual CheckBox chk_D_S_Width { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_D_S_Height")]
    internal virtual CheckBox chk_D_S_Height { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_D_S_OverDepth")]
    internal virtual CheckBox chk_D_S_OverDepth { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_D_S_Count")]
    internal virtual CheckBox chk_D_S_Count { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_D_S_OverWidth")]
    internal virtual CheckBox chk_D_S_OverWidth { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox18")]
    internal virtual GroupBox GroupBox18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_D_W_Transmittance")]
    internal virtual CheckBox chk_D_W_Transmittance { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_D_W_UValue")]
    internal virtual CheckBox chk_D_W_UValue { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_D_W_FF")]
    internal virtual CheckBox chk_D_W_FF { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label3")]
    internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button cmd_D_Copy
    {
      get => this._cmd_D_Copy;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmd_D_Copy_Click);
        Button cmdDCopy1 = this._cmd_D_Copy;
        if (cmdDCopy1 != null)
          cmdDCopy1.Click -= eventHandler;
        this._cmd_D_Copy = value;
        Button cmdDCopy2 = this._cmd_D_Copy;
        if (cmdDCopy2 == null)
          return;
        cmdDCopy2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("chk_RW_G_Pitch")]
    internal virtual CheckBox chk_RW_G_Pitch { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_D_G_Type")]
    internal virtual CheckBox chk_D_G_Type { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button cmdSAll
    {
      get => this._cmdSAll;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdSAll_Click);
        Button cmdSall1 = this._cmdSAll;
        if (cmdSall1 != null)
          cmdSall1.Click -= eventHandler;
        this._cmdSAll = value;
        Button cmdSall2 = this._cmdSAll;
        if (cmdSall2 == null)
          return;
        cmdSall2.Click += eventHandler;
      }
    }

    internal virtual Button cmdSNone
    {
      get => this._cmdSNone;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdSNone_Click);
        Button cmdSnone1 = this._cmdSNone;
        if (cmdSnone1 != null)
          cmdSnone1.Click -= eventHandler;
        this._cmdSNone = value;
        Button cmdSnone2 = this._cmdSNone;
        if (cmdSnone2 == null)
          return;
        cmdSnone2.Click += eventHandler;
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

    private void cmd_W_SAll_Click(object sender, EventArgs e)
    {
      this.chk_W_C_CurtainType.Checked = true;
      this.chk_W_C_Fraction.Checked = true;
      this.chk_W_F_Thermal.Checked = true;
      this.chk_W_F_Type.Checked = true;
      this.chk_W_G_Orientation.Checked = true;
      this.chk_W_G_Overshading.Checked = true;
      this.chk_W_G_Uvalue.Checked = true;
      this.chk_W_GS_AirGap.Checked = true;
      this.chk_W_GS_GlazingType.Checked = true;
      this.chk_W_S_Area.Checked = true;
      this.chk_W_S_Count.Checked = true;
      this.chk_W_S_Height.Checked = true;
      this.chk_W_S_OverDepth.Checked = true;
      this.chk_W_S_OverWidth.Checked = true;
      this.chk_W_S_Width.Checked = true;
      this.chk_W_W_FF.Checked = true;
      this.chk_W_W_Transmittance.Checked = true;
      this.chk_W_W_UValue.Checked = true;
    }

    private void cmd_W_SNone_Click(object sender, EventArgs e)
    {
      this.chk_W_C_CurtainType.Checked = false;
      this.chk_W_C_Fraction.Checked = false;
      this.chk_W_F_Thermal.Checked = false;
      this.chk_W_F_Type.Checked = false;
      this.chk_W_G_Orientation.Checked = false;
      this.chk_W_G_Overshading.Checked = false;
      this.chk_W_G_Uvalue.Checked = false;
      this.chk_W_GS_AirGap.Checked = false;
      this.chk_W_GS_GlazingType.Checked = false;
      this.chk_W_S_Area.Checked = false;
      this.chk_W_S_Count.Checked = false;
      this.chk_W_S_Height.Checked = false;
      this.chk_W_S_OverDepth.Checked = false;
      this.chk_W_S_OverWidth.Checked = false;
      this.chk_W_S_Width.Checked = false;
      this.chk_W_W_FF.Checked = false;
      this.chk_W_W_Transmittance.Checked = false;
      this.chk_W_W_UValue.Checked = false;
    }

    private void cmd_RW_SAll_Click(object sender, EventArgs e)
    {
      this.chk_RW_C_CurtainType.Checked = true;
      this.chk_RW_C_Fraction.Checked = true;
      this.chk_RW_F_Thermal.Checked = true;
      this.chk_RW_F_Type.Checked = true;
      this.chk_RW_G_Orientation.Checked = true;
      this.chk_RW_G_Overshading.Checked = true;
      this.chk_RW_G_Uvalue.Checked = true;
      this.chk_RW_GS_AirGap.Checked = true;
      this.chk_RW_GS_GlazingType.Checked = true;
      this.chk_RW_S_Area.Checked = true;
      this.chk_RW_S_Count.Checked = true;
      this.chk_RW_S_Height.Checked = true;
      this.chk_RW_S_OverDepth.Checked = true;
      this.chk_RW_S_OverWidth.Checked = true;
      this.chk_RW_S_Width.Checked = true;
      this.chk_RW_W_FF.Checked = true;
      this.chk_RW_W_Transmittance.Checked = true;
      this.chk_RW_W_UValue.Checked = true;
      this.chk_RW_G_Pitch.Checked = true;
    }

    private void cmd_RW_SNone_Click(object sender, EventArgs e)
    {
      this.chk_RW_C_CurtainType.Checked = false;
      this.chk_RW_C_Fraction.Checked = false;
      this.chk_RW_F_Thermal.Checked = false;
      this.chk_RW_F_Type.Checked = false;
      this.chk_RW_G_Orientation.Checked = false;
      this.chk_RW_G_Overshading.Checked = false;
      this.chk_RW_G_Uvalue.Checked = false;
      this.chk_RW_GS_AirGap.Checked = false;
      this.chk_RW_GS_GlazingType.Checked = false;
      this.chk_RW_S_Area.Checked = false;
      this.chk_RW_S_Count.Checked = false;
      this.chk_RW_S_Height.Checked = false;
      this.chk_RW_S_OverDepth.Checked = false;
      this.chk_RW_S_OverWidth.Checked = false;
      this.chk_RW_S_Width.Checked = false;
      this.chk_RW_W_FF.Checked = false;
      this.chk_RW_W_Transmittance.Checked = false;
      this.chk_RW_W_UValue.Checked = false;
      this.chk_RW_G_Pitch.Checked = false;
    }

    private void cmd_D_SAll_Click(object sender, EventArgs e)
    {
      this.chk_D_F_Thermal.Checked = true;
      this.chk_D_F_Type.Checked = true;
      this.chk_D_G_Orientation.Checked = true;
      this.chk_D_G_Overshading.Checked = true;
      this.chk_D_G_Uvalue.Checked = true;
      this.chk_D_GS_AirGap.Checked = true;
      this.chk_D_GS_GlazingType.Checked = true;
      this.chk_D_S_Area.Checked = true;
      this.chk_D_S_Count.Checked = true;
      this.chk_D_S_Height.Checked = true;
      this.chk_D_S_OverDepth.Checked = true;
      this.chk_D_S_OverWidth.Checked = true;
      this.chk_D_S_Width.Checked = true;
      this.chk_D_W_FF.Checked = true;
      this.chk_D_W_Transmittance.Checked = true;
      this.chk_D_W_UValue.Checked = true;
      this.chk_D_G_Type.Checked = true;
    }

    private void cmd_D_SNone_Click(object sender, EventArgs e)
    {
      this.chk_D_F_Thermal.Checked = false;
      this.chk_D_F_Type.Checked = false;
      this.chk_D_G_Orientation.Checked = false;
      this.chk_D_G_Overshading.Checked = false;
      this.chk_D_G_Uvalue.Checked = false;
      this.chk_D_GS_AirGap.Checked = false;
      this.chk_D_GS_GlazingType.Checked = false;
      this.chk_D_S_Area.Checked = false;
      this.chk_D_S_Count.Checked = false;
      this.chk_D_S_Height.Checked = false;
      this.chk_D_S_OverDepth.Checked = false;
      this.chk_D_S_OverWidth.Checked = false;
      this.chk_D_S_Width.Checked = false;
      this.chk_D_W_FF.Checked = false;
      this.chk_D_W_Transmittance.Checked = false;
      this.chk_D_W_UValue.Checked = false;
      this.chk_D_G_Type.Checked = false;
    }

    private void cmdSAll_Click(object sender, EventArgs e)
    {
      int num = checked (this.DG1.RowCount - 1);
      int index = 0;
      while (index <= num)
      {
        this.DG1.Rows[index].Cells[4].Value = (object) true;
        checked { ++index; }
      }
    }

    private void cmdSNone_Click(object sender, EventArgs e)
    {
      int num = checked (this.DG1.RowCount - 1);
      int index = 0;
      while (index <= num)
      {
        this.DG1.Rows[index].Cells[4].Value = (object) false;
        checked { ++index; }
      }
    }

    private void cmd_W_Copy_Click(object sender, EventArgs e)
    {
      int num1 = checked (this.DG1.RowCount - 1);
      int rowIndex = 0;
      int num2;
      while (rowIndex <= num1)
      {
        if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DG1[4, rowIndex].Value)) && Operators.ConditionalCompareObjectEqual(this.DG1[4, rowIndex].Value, (object) true, false))
        {
          checked { ++num2; }
          ref SAP_Module.Window local = ref SAP_Module.Proj.Dwellings[Conversions.ToInteger(this.DG1[0, rowIndex].Value)].Windows[Conversions.ToInteger(this.DG1[1, rowIndex].Value)];
          if (this.chk_W_C_CurtainType.Checked)
            local.CurtainType = this.Window.CurtainType;
          if (this.chk_W_C_Fraction.Checked)
            local.FractionClosed = this.Window.FractionClosed;
          if (this.chk_W_F_Thermal.Checked)
            local.ThermalBreak = this.Window.ThermalBreak;
          if (this.chk_W_F_Type.Checked)
            local.FrameType = this.Window.FrameType;
          if (this.chk_W_G_Orientation.Checked)
            local.Orientation = this.Window.Orientation;
          if (this.chk_W_G_Overshading.Checked)
            local.Overshading = this.Window.Overshading;
          if (this.chk_W_G_Uvalue.Checked)
            local.UValueSource = this.Window.UValueSource;
          if (this.chk_W_GS_AirGap.Checked)
            local.AirGap = this.Window.AirGap;
          if (this.chk_W_GS_GlazingType.Checked)
            local.GlazingType = this.Window.GlazingType;
          if (this.chk_W_S_Area.Checked)
            local.Area = this.Window.Area;
          if (this.chk_W_S_Count.Checked)
            local.Count = this.Window.Count;
          if (this.chk_W_S_Height.Checked)
            local.Height = this.Window.Height;
          if (this.chk_W_S_OverDepth.Checked)
            local.OverhangDepth = this.Window.OverhangDepth;
          if (this.chk_W_S_OverWidth.Checked)
            local.OverhangWidth = this.Window.OverhangWidth;
          if (this.chk_W_S_Width.Checked)
            local.Width = this.Window.Width;
          if (this.chk_W_W_FF.Checked)
            local.FF = this.Window.FF;
          if (this.chk_W_W_Transmittance.Checked)
            local.g = this.Window.g;
          if (this.chk_W_W_UValue.Checked)
            local.U = this.Window.U;
        }
        checked { ++rowIndex; }
      }
      SAP_Read.ReadWindows();
      this.Window = new SAP_Module.Window();
      int num3 = (int) Interaction.MsgBox((object) ("Changes Made to " + Conversions.ToString(num2) + " Window(s)"), MsgBoxStyle.Information, (object) "Window Copy");
      this.Close();
    }

    private void Button1_Click(object sender, EventArgs e) => this.Close();

    private void cmd_RW_Copy_Click(object sender, EventArgs e)
    {
      int num1 = checked (this.DG1.RowCount - 1);
      int rowIndex = 0;
      int num2;
      while (rowIndex <= num1)
      {
        if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DG1[4, rowIndex].Value)) && Operators.ConditionalCompareObjectEqual(this.DG1[4, rowIndex].Value, (object) true, false))
        {
          checked { ++num2; }
          ref SAP_Module.RoofLight local = ref SAP_Module.Proj.Dwellings[Conversions.ToInteger(this.DG1[0, rowIndex].Value)].RoofLights[Conversions.ToInteger(this.DG1[1, rowIndex].Value)];
          if (this.chk_RW_C_CurtainType.Checked)
            local.CurtainType = this.RoofLight.CurtainType;
          if (this.chk_RW_C_Fraction.Checked)
            local.FractionClosed = this.RoofLight.FractionClosed;
          if (this.chk_RW_F_Thermal.Checked)
            local.ThermalBreak = this.RoofLight.ThermalBreak;
          if (this.chk_RW_F_Type.Checked)
            local.FrameType = this.RoofLight.FrameType;
          if (this.chk_RW_G_Orientation.Checked)
            local.Orientation = this.RoofLight.Orientation;
          if (this.chk_RW_G_Overshading.Checked)
            local.Overshading = this.RoofLight.Overshading;
          if (this.chk_RW_G_Uvalue.Checked)
            local.UValueSource = this.RoofLight.UValueSource;
          if (this.chk_RW_GS_AirGap.Checked)
            local.AirGap = this.RoofLight.AirGap;
          if (this.chk_RW_GS_GlazingType.Checked)
            local.GlazingType = this.RoofLight.GlazingType;
          if (this.chk_RW_S_Area.Checked)
            local.Area = this.RoofLight.Area;
          if (this.chk_RW_S_Count.Checked)
            local.Count = this.RoofLight.Count;
          if (this.chk_RW_S_Height.Checked)
            local.Height = this.RoofLight.Height;
          if (this.chk_RW_S_OverDepth.Checked)
            local.OverhangDepth = this.RoofLight.OverhangDepth;
          if (this.chk_RW_S_OverWidth.Checked)
            local.OverhangWidth = this.RoofLight.OverhangWidth;
          if (this.chk_RW_S_Width.Checked)
            local.Width = this.RoofLight.Width;
          if (this.chk_RW_W_FF.Checked)
            local.FF = this.RoofLight.FF;
          if (this.chk_RW_W_Transmittance.Checked)
            local.g = this.RoofLight.g;
          if (this.chk_RW_W_UValue.Checked)
            local.U = this.RoofLight.U;
          if (this.chk_RW_G_Pitch.Checked)
            local.Pitch = this.RoofLight.Pitch;
        }
        checked { ++rowIndex; }
      }
      SAP_Read.ReadRoofLights();
      this.Window = new SAP_Module.Window();
      int num3 = (int) Interaction.MsgBox((object) ("Changes Made to " + Conversions.ToString(num2) + " RoofLight(s)"), MsgBoxStyle.Information, (object) "RoofLight Copy");
      this.Close();
    }

    private void cmd_D_Copy_Click(object sender, EventArgs e)
    {
      int num1 = checked (this.DG1.RowCount - 1);
      int rowIndex = 0;
      int num2;
      while (rowIndex <= num1)
      {
        if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DG1[4, rowIndex].Value)) && Operators.ConditionalCompareObjectEqual(this.DG1[4, rowIndex].Value, (object) true, false))
        {
          checked { ++num2; }
          ref SAP_Module.Door local = ref SAP_Module.Proj.Dwellings[Conversions.ToInteger(this.DG1[0, rowIndex].Value)].Doors[Conversions.ToInteger(this.DG1[1, rowIndex].Value)];
          if (this.chk_D_F_Thermal.Checked)
            local.ThermalBreak = this.Door.ThermalBreak;
          if (this.chk_D_F_Type.Checked)
            local.FrameType = this.Door.FrameType;
          if (this.chk_D_G_Orientation.Checked)
            local.Orientation = this.Door.Orientation;
          if (this.chk_D_G_Overshading.Checked)
            local.Overshading = this.Door.Overshading;
          if (this.chk_D_G_Uvalue.Checked)
            local.UValueSource = this.Door.UValueSource;
          if (this.chk_D_GS_AirGap.Checked)
            local.AirGap = this.Door.AirGap;
          if (this.chk_D_GS_GlazingType.Checked)
            local.GlazingType = this.Door.GlazingType;
          if (this.chk_D_S_Area.Checked)
            local.Area = this.Door.Area;
          if (this.chk_D_S_Count.Checked)
            local.Count = this.Door.Count;
          if (this.chk_D_S_Height.Checked)
            local.Height = this.Door.Height;
          if (this.chk_D_S_Width.Checked)
            local.Width = this.Door.Width;
          if (this.chk_D_W_FF.Checked)
            local.FF = this.Door.FF;
          if (this.chk_D_W_Transmittance.Checked)
            local.g = this.Door.g;
          if (this.chk_D_W_UValue.Checked)
            local.U = this.Door.U;
          if (this.chk_D_G_Type.Checked)
            local.DoorType = this.Door.DoorType;
        }
        checked { ++rowIndex; }
      }
      SAP_Read.ReadDoors();
      this.Window = new SAP_Module.Window();
      int num3 = (int) Interaction.MsgBox((object) ("Changes Made to " + Conversions.ToString(num2) + " Door(s)"), MsgBoxStyle.Information, (object) "RoofLight Copy");
      this.Close();
    }

    private void chk_W_S_Area_CheckedChanged(object sender, EventArgs e)
    {
      if (this.chk_W_S_Area.Checked)
      {
        this.chk_W_S_Height.Checked = true;
        this.chk_W_S_Width.Checked = true;
      }
      else
      {
        this.chk_W_S_Height.Checked = false;
        this.chk_W_S_Width.Checked = false;
      }
    }

    private void chk_RW_S_Area_CheckedChanged(object sender, EventArgs e)
    {
      if (this.chk_RW_S_Area.Checked)
      {
        this.chk_RW_S_Height.Checked = true;
        this.chk_RW_S_Width.Checked = true;
      }
      else
      {
        this.chk_RW_S_Height.Checked = false;
        this.chk_RW_S_Width.Checked = false;
      }
    }

    private void chk_D_S_Area_CheckedChanged(object sender, EventArgs e)
    {
      if (this.chk_D_S_Area.Checked)
      {
        this.chk_D_S_Height.Checked = true;
        this.chk_D_S_Width.Checked = true;
      }
      else
      {
        this.chk_D_S_Height.Checked = false;
        this.chk_D_S_Width.Checked = false;
      }
    }
  }
}
