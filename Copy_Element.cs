
// Type: SAP2012.Copy_Element




using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SAP2012
{
  [DesignerGenerated]
  public class Copy_Element : Form
  {
    private IContainer components;

    public Copy_Element()
    {
      this.Load += new EventHandler(this.Copy_Element_Load);
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
      DataGridViewCellStyle gridViewCellStyle1 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle2 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle3 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle4 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle5 = new DataGridViewCellStyle();
      this.DG1 = new DataGridView();
      this.GroupBox7 = new GroupBox();
      this.chkHydro = new CheckBox();
      this.chk_Renew_Wind = new CheckBox();
      this.chk_Renew_Photo = new CheckBox();
      this.chk_Renew_AppQ = new CheckBox();
      this.chk_Renew_AAEG = new CheckBox();
      this.cmdSNone = new Button();
      this.cmdSAll = new Button();
      this.Button1 = new Button();
      this.pnlRWindow = new Panel();
      this.GroupBox24 = new GroupBox();
      this.Chkoverheat = new CheckBox();
      this.txtBuildetails = new CheckBox();
      this.GroupBox23 = new GroupBox();
      this.txtRPD = new CheckBox();
      this.txtLanguage = new CheckBox();
      this.txtTenure = new CheckBox();
      this.txtTranstype = new CheckBox();
      this.ChkDe = new GroupBox();
      this.ChkDwelling = new CheckBox();
      this.chkBuild = new GroupBox();
      this.ChkBuildingDetails = new CheckBox();
      this.GroupBox21 = new GroupBox();
      this.ChkLocationDetails = new CheckBox();
      this.GroupBox19 = new GroupBox();
      this.chkcounty = new CheckBox();
      this.chkAddress = new CheckBox();
      this.GroupBox18 = new GroupBox();
      this.ChkCooling = new CheckBox();
      this.Button11 = new Button();
      this.GroupBox17 = new GroupBox();
      this.ChkAssessmentType = new CheckBox();
      this.GroupBox16 = new GroupBox();
      this.chk_Thermal = new CheckBox();
      this.GroupBox5 = new GroupBox();
      this.chk_Heating_SecMain = new CheckBox();
      this.chk_Heating_Secondary = new CheckBox();
      this.chk_Heating_Tarrif = new CheckBox();
      this.chk_Heating_Fuel = new CheckBox();
      this.chk_Heating_Controls = new CheckBox();
      this.chk_Heating_Full = new CheckBox();
      this.GroupBox4 = new GroupBox();
      this.chkapprovedInstaller = new CheckBox();
      this.chk_Vent_AirPerm = new CheckBox();
      this.chk_Vent_Mechanical = new CheckBox();
      this.chk_Vent_ShelteredSides = new CheckBox();
      this.chk_Vent_GasFires = new CheckBox();
      this.chk_Vent_OpenFlues = new CheckBox();
      this.chk_Vent_Chimneys = new CheckBox();
      this.chk_Vent_PassiveVents = new CheckBox();
      this.chk_Vent_Fans = new CheckBox();
      this.GroupBox3 = new GroupBox();
      this.chk_FGHRS = new CheckBox();
      this.chk_WWHR = new CheckBox();
      this.chk_Water_SolarPanel = new CheckBox();
      this.chk_Water_Heating = new CheckBox();
      this.GroupBox2 = new GroupBox();
      this.GroupBox22 = new GroupBox();
      this.chkbuilt = new CheckBox();
      this.chk_Other_LEL = new CheckBox();
      this.chk_Other_FixedAir = new CheckBox();
      this.chk_Other_Conserv = new CheckBox();
      this.GroupBox1 = new GroupBox();
      this.chk_Vent_ThermalMass = new CheckBox();
      this.chk_OverH_AirChangeRate = new CheckBox();
      this.Label2 = new Label();
      this.cmd_RW_Copy = new Button();
      this.TabControl1 = new TabControl();
      this.TabPage1 = new TabPage();
      this.TabPage2 = new TabPage();
      this.GroupBox6 = new GroupBox();
      this.chk_Floors_Construction = new CheckBox();
      this.chk_Floors_Kappa = new CheckBox();
      this.chk_Floors_U = new CheckBox();
      this.chk_Floors_Area = new CheckBox();
      this.chk_Floors_Type = new CheckBox();
      this.Label3 = new Label();
      this.DGSFloor = new DataGridView();
      this.Label1 = new Label();
      this.Button2 = new Button();
      this.Button3 = new Button();
      this.Button4 = new Button();
      this.DGFloors = new DataGridView();
      this.TabPage3 = new TabPage();
      this.GroupBox8 = new GroupBox();
      this.chk_Walls_Construction = new CheckBox();
      this.chk_Walls_Kappa = new CheckBox();
      this.chk_Walls_Curtain = new CheckBox();
      this.chk_Walls_Ru = new CheckBox();
      this.chk_Walls_UValue = new CheckBox();
      this.chk_Walls_Area = new CheckBox();
      this.chk_Walls_Type = new CheckBox();
      this.Label4 = new Label();
      this.DGSWall = new DataGridView();
      this.Label5 = new Label();
      this.Button5 = new Button();
      this.Button6 = new Button();
      this.Button7 = new Button();
      this.DGWalls = new DataGridView();
      this.TabPage4 = new TabPage();
      this.GroupBox9 = new GroupBox();
      this.chk_Roofs_Construction = new CheckBox();
      this.chk_Roofs_Kappa = new CheckBox();
      this.chk_Roofs_Ru = new CheckBox();
      this.chk_Roofs_UValue = new CheckBox();
      this.chk_Roofs_Area = new CheckBox();
      this.chk_Roofs_Type = new CheckBox();
      this.Label6 = new Label();
      this.DGSRoof = new DataGridView();
      this.Label7 = new Label();
      this.Button8 = new Button();
      this.Button9 = new Button();
      this.Button10 = new Button();
      this.DGRoofs = new DataGridView();
      this.TabPage5 = new TabPage();
      this.GroupBox10 = new GroupBox();
      this.chk_IFloors_Construction = new CheckBox();
      this.chk_IFloors_Kappa = new CheckBox();
      this.chk_IFloors_Area = new CheckBox();
      this.Label8 = new Label();
      this.DGSFloorI = new DataGridView();
      this.Label9 = new Label();
      this.Button12 = new Button();
      this.Button13 = new Button();
      this.Button14 = new Button();
      this.DGFloorsI = new DataGridView();
      this.TabPage6 = new TabPage();
      this.GroupBox12 = new GroupBox();
      this.chk_IWalls_Construction = new CheckBox();
      this.chk_IWalls_Kappa = new CheckBox();
      this.chk_IWalls_Area = new CheckBox();
      this.Label12 = new Label();
      this.DGSWallI = new DataGridView();
      this.Label13 = new Label();
      this.Button18 = new Button();
      this.Button19 = new Button();
      this.Button20 = new Button();
      this.DGWallsI = new DataGridView();
      this.TabPage7 = new TabPage();
      this.GroupBox14 = new GroupBox();
      this.chk_IRoofs_Construction = new CheckBox();
      this.chk_IRoofs_Kappa = new CheckBox();
      this.chk_IRoofs_Area = new CheckBox();
      this.Label16 = new Label();
      this.DGSRoofI = new DataGridView();
      this.Label17 = new Label();
      this.Button24 = new Button();
      this.Button25 = new Button();
      this.Button26 = new Button();
      this.DGRoofsI = new DataGridView();
      this.TabPage8 = new TabPage();
      this.GroupBox11 = new GroupBox();
      this.chk_PFloors_Construction = new CheckBox();
      this.chk_PFloors_Kappa = new CheckBox();
      this.chk_PFloors_Area = new CheckBox();
      this.Label10 = new Label();
      this.DGSFloorP = new DataGridView();
      this.Label11 = new Label();
      this.Button15 = new Button();
      this.Button16 = new Button();
      this.Button17 = new Button();
      this.DGFloorsP = new DataGridView();
      this.TabPage9 = new TabPage();
      this.GroupBox13 = new GroupBox();
      this.chk_PWalls_Type = new CheckBox();
      this.chk_PWalls_UValue = new CheckBox();
      this.chk_PWalls_Construction = new CheckBox();
      this.chk_PWalls_Kappa = new CheckBox();
      this.chk_PWalls_Area = new CheckBox();
      this.Label14 = new Label();
      this.DGSWallP = new DataGridView();
      this.Label15 = new Label();
      this.Button21 = new Button();
      this.Button22 = new Button();
      this.Button23 = new Button();
      this.DGWallsP = new DataGridView();
      this.TabPage10 = new TabPage();
      this.GroupBox15 = new GroupBox();
      this.chk_PRoofs_Construction = new CheckBox();
      this.chk_PRoofs_Kappa = new CheckBox();
      this.chk_PRoofs_Area = new CheckBox();
      this.Label18 = new Label();
      this.DGSRoofP = new DataGridView();
      this.Label19 = new Label();
      this.Button27 = new Button();
      this.Button28 = new Button();
      this.Button29 = new Button();
      this.DGRoofsP = new DataGridView();
      this.TabPage11 = new TabPage();
      this.Button34 = new Button();
      this.Button33 = new Button();
      this.chkD = new CheckBox();
      this.cmdSelectAllHtb = new Button();
      this.cmdDeSelectAllHtb = new Button();
      this.chkSource = new CheckBox();
      this.chkL = new CheckBox();
      this.chkY = new CheckBox();
      this.Button30 = new Button();
      this.Button31 = new Button();
      this.Button32 = new Button();
      this.dtaCalc = new DataGridView();
      this.JunctionType = new DataGridViewTextBoxColumn();
      this.LTTUsed = new DataGridViewTextBoxColumn();
      this.LJT = new DataGridViewTextBoxColumn();
      this.ApprovedSource = new DataGridViewCheckBoxColumn();
      this.Def = new DataGridViewCheckBoxColumn();
      this.SelectCheck = new DataGridViewCheckBoxColumn();
      this.ID = new DataGridViewTextBoxColumn();
      this.DGHtbDwellings = new DataGridView();
      this.TabPage12 = new TabPage();
      this.GroupBox20 = new GroupBox();
      this.ChkCoolingArea = new CheckBox();
      this.ChkCompressorcontrol = new CheckBox();
      this.Chk_CoolingsystType = new CheckBox();
      this.ChkCoolingEER = new CheckBox();
      this.ChkCoolingEnergyLabel = new CheckBox();
      this.Label20 = new Label();
      this.DGSCooling = new DataGridView();
      this.Label21 = new Label();
      this.Button35 = new Button();
      this.Button36 = new Button();
      this.Button37 = new Button();
      this.DGCooling = new DataGridView();
      ((ISupportInitialize) this.DG1).BeginInit();
      this.GroupBox7.SuspendLayout();
      this.pnlRWindow.SuspendLayout();
      this.GroupBox24.SuspendLayout();
      this.GroupBox23.SuspendLayout();
      this.ChkDe.SuspendLayout();
      this.chkBuild.SuspendLayout();
      this.GroupBox21.SuspendLayout();
      this.GroupBox19.SuspendLayout();
      this.GroupBox18.SuspendLayout();
      this.GroupBox17.SuspendLayout();
      this.GroupBox16.SuspendLayout();
      this.GroupBox5.SuspendLayout();
      this.GroupBox4.SuspendLayout();
      this.GroupBox3.SuspendLayout();
      this.GroupBox2.SuspendLayout();
      this.GroupBox22.SuspendLayout();
      this.GroupBox1.SuspendLayout();
      this.TabControl1.SuspendLayout();
      this.TabPage1.SuspendLayout();
      this.TabPage2.SuspendLayout();
      this.GroupBox6.SuspendLayout();
      ((ISupportInitialize) this.DGSFloor).BeginInit();
      ((ISupportInitialize) this.DGFloors).BeginInit();
      this.TabPage3.SuspendLayout();
      this.GroupBox8.SuspendLayout();
      ((ISupportInitialize) this.DGSWall).BeginInit();
      ((ISupportInitialize) this.DGWalls).BeginInit();
      this.TabPage4.SuspendLayout();
      this.GroupBox9.SuspendLayout();
      ((ISupportInitialize) this.DGSRoof).BeginInit();
      ((ISupportInitialize) this.DGRoofs).BeginInit();
      this.TabPage5.SuspendLayout();
      this.GroupBox10.SuspendLayout();
      ((ISupportInitialize) this.DGSFloorI).BeginInit();
      ((ISupportInitialize) this.DGFloorsI).BeginInit();
      this.TabPage6.SuspendLayout();
      this.GroupBox12.SuspendLayout();
      ((ISupportInitialize) this.DGSWallI).BeginInit();
      ((ISupportInitialize) this.DGWallsI).BeginInit();
      this.TabPage7.SuspendLayout();
      this.GroupBox14.SuspendLayout();
      ((ISupportInitialize) this.DGSRoofI).BeginInit();
      ((ISupportInitialize) this.DGRoofsI).BeginInit();
      this.TabPage8.SuspendLayout();
      this.GroupBox11.SuspendLayout();
      ((ISupportInitialize) this.DGSFloorP).BeginInit();
      ((ISupportInitialize) this.DGFloorsP).BeginInit();
      this.TabPage9.SuspendLayout();
      this.GroupBox13.SuspendLayout();
      ((ISupportInitialize) this.DGSWallP).BeginInit();
      ((ISupportInitialize) this.DGWallsP).BeginInit();
      this.TabPage10.SuspendLayout();
      this.GroupBox15.SuspendLayout();
      ((ISupportInitialize) this.DGSRoofP).BeginInit();
      ((ISupportInitialize) this.DGRoofsP).BeginInit();
      this.TabPage11.SuspendLayout();
      ((ISupportInitialize) this.dtaCalc).BeginInit();
      ((ISupportInitialize) this.DGHtbDwellings).BeginInit();
      this.TabPage12.SuspendLayout();
      this.GroupBox20.SuspendLayout();
      ((ISupportInitialize) this.DGSCooling).BeginInit();
      ((ISupportInitialize) this.DGCooling).BeginInit();
      this.SuspendLayout();
      this.DG1.AllowUserToAddRows = false;
      this.DG1.AllowUserToDeleteRows = false;
      this.DG1.AllowUserToResizeRows = false;
      this.DG1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.DG1.Cursor = Cursors.Hand;
      this.DG1.Dock = DockStyle.Fill;
      this.DG1.Location = new Point(481, 3);
      this.DG1.Name = "DG1";
      this.DG1.RowHeadersVisible = false;
      this.DG1.Size = new Size(408, 688);
      this.DG1.TabIndex = 43;
      this.GroupBox7.Controls.Add((Control) this.chkHydro);
      this.GroupBox7.Controls.Add((Control) this.chk_Renew_Wind);
      this.GroupBox7.Controls.Add((Control) this.chk_Renew_Photo);
      this.GroupBox7.Controls.Add((Control) this.chk_Renew_AppQ);
      this.GroupBox7.Controls.Add((Control) this.chk_Renew_AAEG);
      this.GroupBox7.Cursor = Cursors.Default;
      this.GroupBox7.Location = new Point(5, 323);
      this.GroupBox7.Name = "GroupBox7";
      this.GroupBox7.Size = new Size(234, 133);
      this.GroupBox7.TabIndex = 37;
      this.GroupBox7.TabStop = false;
      this.GroupBox7.Text = "Renewables";
      this.chkHydro.AutoSize = true;
      this.chkHydro.Cursor = Cursors.Hand;
      this.chkHydro.Location = new Point(6, 112);
      this.chkHydro.Name = "chkHydro";
      this.chkHydro.Size = new Size(160, 17);
      this.chkHydro.TabIndex = 17;
      this.chkHydro.Text = "Hydro Electricity Generation";
      this.chkHydro.UseVisualStyleBackColor = true;
      this.chk_Renew_Wind.AutoSize = true;
      this.chk_Renew_Wind.Cursor = Cursors.Hand;
      this.chk_Renew_Wind.Location = new Point(6, 43);
      this.chk_Renew_Wind.Name = "chk_Renew_Wind";
      this.chk_Renew_Wind.Size = new Size(117, 17);
      this.chk_Renew_Wind.TabIndex = 16;
      this.chk_Renew_Wind.Text = "Micro Wind Turbine";
      this.chk_Renew_Wind.UseVisualStyleBackColor = true;
      this.chk_Renew_Photo.AutoSize = true;
      this.chk_Renew_Photo.Cursor = Cursors.Hand;
      this.chk_Renew_Photo.Location = new Point(6, 20);
      this.chk_Renew_Photo.Name = "chk_Renew_Photo";
      this.chk_Renew_Photo.Size = new Size(90, 17);
      this.chk_Renew_Photo.TabIndex = 12;
      this.chk_Renew_Photo.Text = "Photovoltaics";
      this.chk_Renew_Photo.UseVisualStyleBackColor = true;
      this.chk_Renew_AppQ.AutoSize = true;
      this.chk_Renew_AppQ.Cursor = Cursors.Hand;
      this.chk_Renew_AppQ.Location = new Point(6, 89);
      this.chk_Renew_AppQ.Name = "chk_Renew_AppQ";
      this.chk_Renew_AppQ.Size = new Size(171, 17);
      this.chk_Renew_AppQ.TabIndex = 15;
      this.chk_Renew_AppQ.Text = "Special Features / Appendix Q";
      this.chk_Renew_AppQ.UseVisualStyleBackColor = true;
      this.chk_Renew_AAEG.AutoSize = true;
      this.chk_Renew_AAEG.Cursor = Cursors.Hand;
      this.chk_Renew_AAEG.Location = new Point(6, 66);
      this.chk_Renew_AAEG.Name = "chk_Renew_AAEG";
      this.chk_Renew_AAEG.Size = new Size(226, 17);
      this.chk_Renew_AAEG.TabIndex = 14;
      this.chk_Renew_AAEG.Text = "Additional Allowable Electricity Generation";
      this.chk_Renew_AAEG.UseVisualStyleBackColor = true;
      this.cmdSNone.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.cmdSNone.BackColor = Color.LightSlateGray;
      this.cmdSNone.Cursor = Cursors.Hand;
      this.cmdSNone.FlatStyle = FlatStyle.Popup;
      this.cmdSNone.ForeColor = Color.White;
      this.cmdSNone.Location = new Point(367, 632);
      this.cmdSNone.Name = "cmdSNone";
      this.cmdSNone.Size = new Size(90, 23);
      this.cmdSNone.TabIndex = 47;
      this.cmdSNone.Text = "Select None";
      this.cmdSNone.UseVisualStyleBackColor = false;
      this.cmdSAll.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.cmdSAll.BackColor = Color.LightSlateGray;
      this.cmdSAll.Cursor = Cursors.Hand;
      this.cmdSAll.FlatStyle = FlatStyle.Popup;
      this.cmdSAll.ForeColor = Color.White;
      this.cmdSAll.Location = new Point(271, 632);
      this.cmdSAll.Name = "cmdSAll";
      this.cmdSAll.Size = new Size(90, 23);
      this.cmdSAll.TabIndex = 46;
      this.cmdSAll.Text = "Select All";
      this.cmdSAll.UseVisualStyleBackColor = false;
      this.Button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.Button1.BackColor = Color.LightSlateGray;
      this.Button1.Cursor = Cursors.Hand;
      this.Button1.FlatStyle = FlatStyle.Popup;
      this.Button1.ForeColor = Color.White;
      this.Button1.Location = new Point(741, 654);
      this.Button1.Name = "Button1";
      this.Button1.Size = new Size(90, 23);
      this.Button1.TabIndex = 48;
      this.Button1.Text = "Cancel";
      this.Button1.UseVisualStyleBackColor = false;
      this.pnlRWindow.BackColor = Color.White;
      this.pnlRWindow.Controls.Add((Control) this.GroupBox24);
      this.pnlRWindow.Controls.Add((Control) this.GroupBox23);
      this.pnlRWindow.Controls.Add((Control) this.ChkDe);
      this.pnlRWindow.Controls.Add((Control) this.chkBuild);
      this.pnlRWindow.Controls.Add((Control) this.GroupBox21);
      this.pnlRWindow.Controls.Add((Control) this.GroupBox19);
      this.pnlRWindow.Controls.Add((Control) this.GroupBox18);
      this.pnlRWindow.Controls.Add((Control) this.Button11);
      this.pnlRWindow.Controls.Add((Control) this.GroupBox17);
      this.pnlRWindow.Controls.Add((Control) this.GroupBox16);
      this.pnlRWindow.Controls.Add((Control) this.GroupBox5);
      this.pnlRWindow.Controls.Add((Control) this.GroupBox4);
      this.pnlRWindow.Controls.Add((Control) this.GroupBox3);
      this.pnlRWindow.Controls.Add((Control) this.GroupBox2);
      this.pnlRWindow.Controls.Add((Control) this.GroupBox1);
      this.pnlRWindow.Controls.Add((Control) this.cmdSAll);
      this.pnlRWindow.Controls.Add((Control) this.cmdSNone);
      this.pnlRWindow.Controls.Add((Control) this.GroupBox7);
      this.pnlRWindow.Controls.Add((Control) this.Label2);
      this.pnlRWindow.Controls.Add((Control) this.cmd_RW_Copy);
      this.pnlRWindow.Cursor = Cursors.Default;
      this.pnlRWindow.Dock = DockStyle.Left;
      this.pnlRWindow.Location = new Point(3, 3);
      this.pnlRWindow.Name = "pnlRWindow";
      this.pnlRWindow.Size = new Size(478, 688);
      this.pnlRWindow.TabIndex = 44;
      this.GroupBox24.Controls.Add((Control) this.Chkoverheat);
      this.GroupBox24.Controls.Add((Control) this.txtBuildetails);
      this.GroupBox24.Cursor = Cursors.Default;
      this.GroupBox24.Location = new Point(248, 579);
      this.GroupBox24.Name = "GroupBox24";
      this.GroupBox24.Size = new Size(221, 36);
      this.GroupBox24.TabIndex = 60;
      this.GroupBox24.TabStop = false;
      this.GroupBox24.Text = "Build Form";
      this.Chkoverheat.AutoSize = true;
      this.Chkoverheat.Cursor = Cursors.Hand;
      this.Chkoverheat.Location = new Point(97, 17);
      this.Chkoverheat.Name = "Chkoverheat";
      this.Chkoverheat.Size = new Size(72, 17);
      this.Chkoverheat.TabIndex = 13;
      this.Chkoverheat.Text = "Overheat";
      this.Chkoverheat.UseVisualStyleBackColor = true;
      this.txtBuildetails.AutoSize = true;
      this.txtBuildetails.Cursor = Cursors.Hand;
      this.txtBuildetails.Location = new Point(8, 17);
      this.txtBuildetails.Name = "txtBuildetails";
      this.txtBuildetails.Size = new Size(83, 17);
      this.txtBuildetails.TabIndex = 12;
      this.txtBuildetails.Text = "Build Details";
      this.txtBuildetails.UseVisualStyleBackColor = true;
      this.GroupBox23.Controls.Add((Control) this.txtRPD);
      this.GroupBox23.Controls.Add((Control) this.txtLanguage);
      this.GroupBox23.Controls.Add((Control) this.txtTenure);
      this.GroupBox23.Controls.Add((Control) this.txtTranstype);
      this.GroupBox23.Cursor = Cursors.Default;
      this.GroupBox23.Location = new Point(248, 491);
      this.GroupBox23.Name = "GroupBox23";
      this.GroupBox23.Size = new Size(221, 72);
      this.GroupBox23.TabIndex = 60;
      this.GroupBox23.TabStop = false;
      this.GroupBox23.Text = "Other";
      this.txtRPD.AutoSize = true;
      this.txtRPD.Cursor = Cursors.Hand;
      this.txtRPD.Location = new Point(119, 36);
      this.txtRPD.Name = "txtRPD";
      this.txtRPD.Size = new Size(46, 17);
      this.txtRPD.TabIndex = 18;
      this.txtRPD.Text = "RPD";
      this.txtRPD.UseVisualStyleBackColor = true;
      this.txtLanguage.AutoSize = true;
      this.txtLanguage.Cursor = Cursors.Hand;
      this.txtLanguage.Location = new Point(119, 17);
      this.txtLanguage.Name = "txtLanguage";
      this.txtLanguage.Size = new Size(95, 17);
      this.txtLanguage.TabIndex = 17;
      this.txtLanguage.Text = "EPC Language";
      this.txtLanguage.UseVisualStyleBackColor = true;
      this.txtTenure.AutoSize = true;
      this.txtTenure.Cursor = Cursors.Hand;
      this.txtTenure.Location = new Point(10, 36);
      this.txtTenure.Name = "txtTenure";
      this.txtTenure.Size = new Size(87, 17);
      this.txtTenure.TabIndex = 16;
      this.txtTenure.Text = "Tenure Type";
      this.txtTenure.UseVisualStyleBackColor = true;
      this.txtTranstype.Cursor = Cursors.Hand;
      this.txtTranstype.Location = new Point(10, 13);
      this.txtTranstype.Name = "txtTranstype";
      this.txtTranstype.Size = new Size(199, 23);
      this.txtTranstype.TabIndex = 12;
      this.txtTranstype.Text = "Transaction Type";
      this.txtTranstype.UseVisualStyleBackColor = true;
      this.ChkDe.Controls.Add((Control) this.ChkDwelling);
      this.ChkDe.Cursor = Cursors.Default;
      this.ChkDe.Location = new Point(248, 434);
      this.ChkDe.Name = "ChkDe";
      this.ChkDe.Size = new Size(224, 47);
      this.ChkDe.TabIndex = 59;
      this.ChkDe.TabStop = false;
      this.ChkDe.Text = "Dwelling Details";
      this.ChkDwelling.AutoSize = true;
      this.ChkDwelling.Cursor = Cursors.Hand;
      this.ChkDwelling.Location = new Point(10, 20);
      this.ChkDwelling.Name = "ChkDwelling";
      this.ChkDwelling.Size = new Size(118, 17);
      this.ChkDwelling.TabIndex = 12;
      this.ChkDwelling.Text = "Dwelling Reference";
      this.ChkDwelling.UseVisualStyleBackColor = true;
      this.chkBuild.Controls.Add((Control) this.ChkBuildingDetails);
      this.chkBuild.Cursor = Cursors.Default;
      this.chkBuild.Location = new Point(8, 526);
      this.chkBuild.Name = "chkBuild";
      this.chkBuild.Size = new Size(234, 47);
      this.chkBuild.TabIndex = 59;
      this.chkBuild.TabStop = false;
      this.chkBuild.Text = "Build Year";
      this.ChkBuildingDetails.AutoSize = true;
      this.ChkBuildingDetails.Cursor = Cursors.Hand;
      this.ChkBuildingDetails.Location = new Point(10, 20);
      this.ChkBuildingDetails.Name = "ChkBuildingDetails";
      this.ChkBuildingDetails.Size = new Size(73, 17);
      this.ChkBuildingDetails.TabIndex = 12;
      this.ChkBuildingDetails.Text = "Build Year";
      this.ChkBuildingDetails.UseVisualStyleBackColor = true;
      this.GroupBox21.Controls.Add((Control) this.ChkLocationDetails);
      this.GroupBox21.Cursor = Cursors.Default;
      this.GroupBox21.Location = new Point(248, 381);
      this.GroupBox21.Name = "GroupBox21";
      this.GroupBox21.Size = new Size(224, 47);
      this.GroupBox21.TabIndex = 58;
      this.GroupBox21.TabStop = false;
      this.GroupBox21.Text = "Location";
      this.ChkLocationDetails.AutoSize = true;
      this.ChkLocationDetails.Cursor = Cursors.Hand;
      this.ChkLocationDetails.Location = new Point(10, 20);
      this.ChkLocationDetails.Name = "ChkLocationDetails";
      this.ChkLocationDetails.Size = new Size(101, 17);
      this.ChkLocationDetails.TabIndex = 12;
      this.ChkLocationDetails.Text = "Location Details";
      this.ChkLocationDetails.UseVisualStyleBackColor = true;
      this.GroupBox19.Controls.Add((Control) this.chkcounty);
      this.GroupBox19.Controls.Add((Control) this.chkAddress);
      this.GroupBox19.Cursor = Cursors.Default;
      this.GroupBox19.Location = new Point(248, 333);
      this.GroupBox19.Name = "GroupBox19";
      this.GroupBox19.Size = new Size(224, 47);
      this.GroupBox19.TabIndex = 57;
      this.GroupBox19.TabStop = false;
      this.GroupBox19.Text = "Dwelling Address";
      this.chkcounty.AutoSize = true;
      this.chkcounty.Cursor = Cursors.Hand;
      this.chkcounty.Location = new Point(81, 20);
      this.chkcounty.Name = "chkcounty";
      this.chkcounty.Size = new Size(65, 17);
      this.chkcounty.TabIndex = 13;
      this.chkcounty.Text = "Country";
      this.chkcounty.UseVisualStyleBackColor = true;
      this.chkAddress.AutoSize = true;
      this.chkAddress.Cursor = Cursors.Hand;
      this.chkAddress.Location = new Point(10, 20);
      this.chkAddress.Name = "chkAddress";
      this.chkAddress.Size = new Size(65, 17);
      this.chkAddress.TabIndex = 12;
      this.chkAddress.Text = "Address";
      this.chkAddress.UseVisualStyleBackColor = true;
      this.GroupBox18.Controls.Add((Control) this.ChkCooling);
      this.GroupBox18.Cursor = Cursors.Default;
      this.GroupBox18.Location = new Point(245, 174);
      this.GroupBox18.Name = "GroupBox18";
      this.GroupBox18.Size = new Size(224, 47);
      this.GroupBox18.TabIndex = 56;
      this.GroupBox18.TabStop = false;
      this.GroupBox18.Text = "Cooling System";
      this.ChkCooling.AutoSize = true;
      this.ChkCooling.Cursor = Cursors.Hand;
      this.ChkCooling.Location = new Point(10, 20);
      this.ChkCooling.Name = "ChkCooling";
      this.ChkCooling.Size = new Size(61, 17);
      this.ChkCooling.TabIndex = 12;
      this.ChkCooling.Text = "Cooling";
      this.ChkCooling.UseVisualStyleBackColor = true;
      this.Button11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.Button11.BackColor = Color.LightSlateGray;
      this.Button11.Cursor = Cursors.Hand;
      this.Button11.DialogResult = DialogResult.OK;
      this.Button11.FlatStyle = FlatStyle.Popup;
      this.Button11.ForeColor = Color.White;
      this.Button11.Location = new Point(11, 662);
      this.Button11.Name = "Button11";
      this.Button11.Size = new Size(186, 23);
      this.Button11.TabIndex = 53;
      this.Button11.Text = "Close";
      this.Button11.UseVisualStyleBackColor = false;
      this.GroupBox17.Controls.Add((Control) this.ChkAssessmentType);
      this.GroupBox17.Cursor = Cursors.Default;
      this.GroupBox17.Location = new Point(248, 280);
      this.GroupBox17.Name = "GroupBox17";
      this.GroupBox17.Size = new Size(224, 47);
      this.GroupBox17.TabIndex = 55;
      this.GroupBox17.TabStop = false;
      this.GroupBox17.Text = "Assessment Type";
      this.ChkAssessmentType.AutoSize = true;
      this.ChkAssessmentType.Cursor = Cursors.Hand;
      this.ChkAssessmentType.Location = new Point(10, 20);
      this.ChkAssessmentType.Name = "ChkAssessmentType";
      this.ChkAssessmentType.Size = new Size(110, 17);
      this.ChkAssessmentType.TabIndex = 12;
      this.ChkAssessmentType.Text = "Assessment Type";
      this.ChkAssessmentType.UseVisualStyleBackColor = true;
      this.GroupBox16.Controls.Add((Control) this.chk_Thermal);
      this.GroupBox16.Cursor = Cursors.Default;
      this.GroupBox16.Location = new Point(245, 227);
      this.GroupBox16.Name = "GroupBox16";
      this.GroupBox16.Size = new Size(224, 47);
      this.GroupBox16.TabIndex = 53;
      this.GroupBox16.TabStop = false;
      this.GroupBox16.Text = "Thermal Bridging";
      this.chk_Thermal.AutoSize = true;
      this.chk_Thermal.Cursor = Cursors.Hand;
      this.chk_Thermal.Location = new Point(10, 20);
      this.chk_Thermal.Name = "chk_Thermal";
      this.chk_Thermal.Size = new Size(154, 17);
      this.chk_Thermal.TabIndex = 12;
      this.chk_Thermal.Text = "All Thermal Bridging Details";
      this.chk_Thermal.UseVisualStyleBackColor = true;
      this.GroupBox5.Controls.Add((Control) this.chk_Heating_SecMain);
      this.GroupBox5.Controls.Add((Control) this.chk_Heating_Secondary);
      this.GroupBox5.Controls.Add((Control) this.chk_Heating_Tarrif);
      this.GroupBox5.Controls.Add((Control) this.chk_Heating_Fuel);
      this.GroupBox5.Controls.Add((Control) this.chk_Heating_Controls);
      this.GroupBox5.Controls.Add((Control) this.chk_Heating_Full);
      this.GroupBox5.Cursor = Cursors.Default;
      this.GroupBox5.Location = new Point(245, 16);
      this.GroupBox5.Name = "GroupBox5";
      this.GroupBox5.Size = new Size(224, 156);
      this.GroupBox5.TabIndex = 56;
      this.GroupBox5.TabStop = false;
      this.GroupBox5.Text = "Heating Systems";
      this.chk_Heating_SecMain.AutoSize = true;
      this.chk_Heating_SecMain.Cursor = Cursors.Hand;
      this.chk_Heating_SecMain.Location = new Point(10, 43);
      this.chk_Heating_SecMain.Name = "chk_Heating_SecMain";
      this.chk_Heating_SecMain.Size = new Size(146, 17);
      this.chk_Heating_SecMain.TabIndex = 18;
      this.chk_Heating_SecMain.Text = "Sec Main Heating System";
      this.chk_Heating_SecMain.UseVisualStyleBackColor = true;
      this.chk_Heating_Secondary.AutoSize = true;
      this.chk_Heating_Secondary.Cursor = Cursors.Hand;
      this.chk_Heating_Secondary.Location = new Point(10, 135);
      this.chk_Heating_Secondary.Name = "chk_Heating_Secondary";
      this.chk_Heating_Secondary.Size = new Size(117, 17);
      this.chk_Heating_Secondary.TabIndex = 16;
      this.chk_Heating_Secondary.Text = "Secondary Heating";
      this.chk_Heating_Secondary.UseVisualStyleBackColor = true;
      this.chk_Heating_Tarrif.AutoSize = true;
      this.chk_Heating_Tarrif.Cursor = Cursors.Hand;
      this.chk_Heating_Tarrif.Location = new Point(10, 112);
      this.chk_Heating_Tarrif.Name = "chk_Heating_Tarrif";
      this.chk_Heating_Tarrif.Size = new Size(101, 17);
      this.chk_Heating_Tarrif.TabIndex = 15;
      this.chk_Heating_Tarrif.Text = "Electricity Tarrif";
      this.chk_Heating_Tarrif.UseVisualStyleBackColor = true;
      this.chk_Heating_Fuel.AutoSize = true;
      this.chk_Heating_Fuel.Cursor = Cursors.Hand;
      this.chk_Heating_Fuel.Location = new Point(10, 89);
      this.chk_Heating_Fuel.Name = "chk_Heating_Fuel";
      this.chk_Heating_Fuel.Size = new Size(86, 17);
      this.chk_Heating_Fuel.TabIndex = 14;
      this.chk_Heating_Fuel.Text = "Heating Fuel";
      this.chk_Heating_Fuel.UseVisualStyleBackColor = true;
      this.chk_Heating_Controls.AutoSize = true;
      this.chk_Heating_Controls.Cursor = Cursors.Hand;
      this.chk_Heating_Controls.Location = new Point(10, 66);
      this.chk_Heating_Controls.Name = "chk_Heating_Controls";
      this.chk_Heating_Controls.Size = new Size(106, 17);
      this.chk_Heating_Controls.TabIndex = 13;
      this.chk_Heating_Controls.Text = "Heating Controls";
      this.chk_Heating_Controls.UseVisualStyleBackColor = true;
      this.chk_Heating_Full.AutoSize = true;
      this.chk_Heating_Full.Cursor = Cursors.Hand;
      this.chk_Heating_Full.Location = new Point(10, 20);
      this.chk_Heating_Full.Name = "chk_Heating_Full";
      this.chk_Heating_Full.Size = new Size(145, 17);
      this.chk_Heating_Full.TabIndex = 12;
      this.chk_Heating_Full.Text = "Full Main Heating System";
      this.chk_Heating_Full.UseVisualStyleBackColor = true;
      this.GroupBox4.Controls.Add((Control) this.chkapprovedInstaller);
      this.GroupBox4.Controls.Add((Control) this.chk_Vent_AirPerm);
      this.GroupBox4.Controls.Add((Control) this.chk_Vent_Mechanical);
      this.GroupBox4.Controls.Add((Control) this.chk_Vent_ShelteredSides);
      this.GroupBox4.Controls.Add((Control) this.chk_Vent_GasFires);
      this.GroupBox4.Controls.Add((Control) this.chk_Vent_OpenFlues);
      this.GroupBox4.Controls.Add((Control) this.chk_Vent_Chimneys);
      this.GroupBox4.Controls.Add((Control) this.chk_Vent_PassiveVents);
      this.GroupBox4.Controls.Add((Control) this.chk_Vent_Fans);
      this.GroupBox4.Cursor = Cursors.Default;
      this.GroupBox4.Location = new Point(5, 16);
      this.GroupBox4.Name = "GroupBox4";
      this.GroupBox4.Size = new Size(234, 225);
      this.GroupBox4.TabIndex = 51;
      this.GroupBox4.TabStop = false;
      this.GroupBox4.Text = "Ventilation";
      this.chkapprovedInstaller.AutoSize = true;
      this.chkapprovedInstaller.Cursor = Cursors.Hand;
      this.chkapprovedInstaller.Location = new Point(6, 204);
      this.chkapprovedInstaller.Name = "chkapprovedInstaller";
      this.chkapprovedInstaller.Size = new Size(115, 17);
      this.chkapprovedInstaller.TabIndex = 21;
      this.chkapprovedInstaller.Text = "Approved Installer";
      this.chkapprovedInstaller.UseVisualStyleBackColor = true;
      this.chk_Vent_AirPerm.AutoSize = true;
      this.chk_Vent_AirPerm.Cursor = Cursors.Hand;
      this.chk_Vent_AirPerm.Location = new Point(6, 181);
      this.chk_Vent_AirPerm.Name = "chk_Vent_AirPerm";
      this.chk_Vent_AirPerm.Size = new Size(135, 17);
      this.chk_Vent_AirPerm.TabIndex = 20;
      this.chk_Vent_AirPerm.Text = "Air Permeability Details";
      this.chk_Vent_AirPerm.UseVisualStyleBackColor = true;
      this.chk_Vent_Mechanical.AutoSize = true;
      this.chk_Vent_Mechanical.Cursor = Cursors.Hand;
      this.chk_Vent_Mechanical.Location = new Point(6, 158);
      this.chk_Vent_Mechanical.Name = "chk_Vent_Mechanical";
      this.chk_Vent_Mechanical.Size = new Size(160, 17);
      this.chk_Vent_Mechanical.TabIndex = 19;
      this.chk_Vent_Mechanical.Text = "Mechnical Ventilation Details";
      this.chk_Vent_Mechanical.UseVisualStyleBackColor = true;
      this.chk_Vent_ShelteredSides.AutoSize = true;
      this.chk_Vent_ShelteredSides.Cursor = Cursors.Hand;
      this.chk_Vent_ShelteredSides.Location = new Point(6, 135);
      this.chk_Vent_ShelteredSides.Name = "chk_Vent_ShelteredSides";
      this.chk_Vent_ShelteredSides.Size = new Size(153, 17);
      this.chk_Vent_ShelteredSides.TabIndex = 18;
      this.chk_Vent_ShelteredSides.Text = "Number of Sheltered Sides";
      this.chk_Vent_ShelteredSides.UseVisualStyleBackColor = true;
      this.chk_Vent_GasFires.AutoSize = true;
      this.chk_Vent_GasFires.Cursor = Cursors.Hand;
      this.chk_Vent_GasFires.Location = new Point(6, 112);
      this.chk_Vent_GasFires.Name = "chk_Vent_GasFires";
      this.chk_Vent_GasFires.Size = new Size(163, 17);
      this.chk_Vent_GasFires.TabIndex = 17;
      this.chk_Vent_GasFires.Text = "Number of flue-less gas fires";
      this.chk_Vent_GasFires.UseVisualStyleBackColor = true;
      this.chk_Vent_OpenFlues.AutoSize = true;
      this.chk_Vent_OpenFlues.Cursor = Cursors.Hand;
      this.chk_Vent_OpenFlues.Location = new Point(6, 43);
      this.chk_Vent_OpenFlues.Name = "chk_Vent_OpenFlues";
      this.chk_Vent_OpenFlues.Size = new Size(133, 17);
      this.chk_Vent_OpenFlues.TabIndex = 16;
      this.chk_Vent_OpenFlues.Text = "Number of Open Flues";
      this.chk_Vent_OpenFlues.UseVisualStyleBackColor = true;
      this.chk_Vent_Chimneys.AutoSize = true;
      this.chk_Vent_Chimneys.Cursor = Cursors.Hand;
      this.chk_Vent_Chimneys.Location = new Point(6, 20);
      this.chk_Vent_Chimneys.Name = "chk_Vent_Chimneys";
      this.chk_Vent_Chimneys.Size = new Size(125, 17);
      this.chk_Vent_Chimneys.TabIndex = 12;
      this.chk_Vent_Chimneys.Text = "Number of Chimneys";
      this.chk_Vent_Chimneys.UseVisualStyleBackColor = true;
      this.chk_Vent_PassiveVents.AutoSize = true;
      this.chk_Vent_PassiveVents.Cursor = Cursors.Hand;
      this.chk_Vent_PassiveVents.Location = new Point(6, 89);
      this.chk_Vent_PassiveVents.Name = "chk_Vent_PassiveVents";
      this.chk_Vent_PassiveVents.Size = new Size(145, 17);
      this.chk_Vent_PassiveVents.TabIndex = 15;
      this.chk_Vent_PassiveVents.Text = "Number of Passive Vents";
      this.chk_Vent_PassiveVents.UseVisualStyleBackColor = true;
      this.chk_Vent_Fans.AutoSize = true;
      this.chk_Vent_Fans.Cursor = Cursors.Hand;
      this.chk_Vent_Fans.Location = new Point(6, 66);
      this.chk_Vent_Fans.Name = "chk_Vent_Fans";
      this.chk_Vent_Fans.Size = new Size(102, 17);
      this.chk_Vent_Fans.TabIndex = 14;
      this.chk_Vent_Fans.Text = "Number of Fans";
      this.chk_Vent_Fans.UseVisualStyleBackColor = true;
      this.GroupBox3.Controls.Add((Control) this.chk_FGHRS);
      this.GroupBox3.Controls.Add((Control) this.chk_WWHR);
      this.GroupBox3.Controls.Add((Control) this.chk_Water_SolarPanel);
      this.GroupBox3.Controls.Add((Control) this.chk_Water_Heating);
      this.GroupBox3.Cursor = Cursors.Default;
      this.GroupBox3.Location = new Point(5, 247);
      this.GroupBox3.Name = "GroupBox3";
      this.GroupBox3.Size = new Size(234, 74);
      this.GroupBox3.TabIndex = 50;
      this.GroupBox3.TabStop = false;
      this.GroupBox3.Text = "Water Heating";
      this.chk_FGHRS.AutoSize = true;
      this.chk_FGHRS.Cursor = Cursors.Hand;
      this.chk_FGHRS.Location = new Point(126, 44);
      this.chk_FGHRS.Name = "chk_FGHRS";
      this.chk_FGHRS.Size = new Size(59, 17);
      this.chk_FGHRS.TabIndex = 18;
      this.chk_FGHRS.Text = "FGHRS";
      this.chk_FGHRS.UseVisualStyleBackColor = true;
      this.chk_WWHR.AutoSize = true;
      this.chk_WWHR.Cursor = Cursors.Hand;
      this.chk_WWHR.Location = new Point(126, 20);
      this.chk_WWHR.Name = "chk_WWHR";
      this.chk_WWHR.Size = new Size(60, 17);
      this.chk_WWHR.TabIndex = 17;
      this.chk_WWHR.Text = "WWHR";
      this.chk_WWHR.UseVisualStyleBackColor = true;
      this.chk_Water_SolarPanel.AutoSize = true;
      this.chk_Water_SolarPanel.Cursor = Cursors.Hand;
      this.chk_Water_SolarPanel.Location = new Point(6, 43);
      this.chk_Water_SolarPanel.Name = "chk_Water_SolarPanel";
      this.chk_Water_SolarPanel.Size = new Size(114, 17);
      this.chk_Water_SolarPanel.TabIndex = 16;
      this.chk_Water_SolarPanel.Text = "Solar Panel Details";
      this.chk_Water_SolarPanel.UseVisualStyleBackColor = true;
      this.chk_Water_Heating.AutoSize = true;
      this.chk_Water_Heating.Cursor = Cursors.Hand;
      this.chk_Water_Heating.Location = new Point(6, 20);
      this.chk_Water_Heating.Name = "chk_Water_Heating";
      this.chk_Water_Heating.Size = new Size(96, 17);
      this.chk_Water_Heating.TabIndex = 12;
      this.chk_Water_Heating.Text = "Water Heating";
      this.chk_Water_Heating.UseVisualStyleBackColor = true;
      this.GroupBox2.Controls.Add((Control) this.GroupBox22);
      this.GroupBox2.Controls.Add((Control) this.chk_Other_LEL);
      this.GroupBox2.Controls.Add((Control) this.chk_Other_FixedAir);
      this.GroupBox2.Controls.Add((Control) this.chk_Other_Conserv);
      this.GroupBox2.Cursor = Cursors.Default;
      this.GroupBox2.Location = new Point(8, 579);
      this.GroupBox2.Name = "GroupBox2";
      this.GroupBox2.Size = new Size(234, 77);
      this.GroupBox2.TabIndex = 49;
      this.GroupBox2.TabStop = false;
      this.GroupBox2.Text = "Other";
      this.GroupBox22.Controls.Add((Control) this.chkbuilt);
      this.GroupBox22.Cursor = Cursors.Default;
      this.GroupBox22.Location = new Point(6, 82);
      this.GroupBox22.Name = "GroupBox22";
      this.GroupBox22.Size = new Size(234, 36);
      this.GroupBox22.TabIndex = 60;
      this.GroupBox22.TabStop = false;
      this.GroupBox22.Text = "Build Form";
      this.chkbuilt.AutoSize = true;
      this.chkbuilt.Cursor = Cursors.Hand;
      this.chkbuilt.Location = new Point(8, 17);
      this.chkbuilt.Name = "chkbuilt";
      this.chkbuilt.Size = new Size(83, 17);
      this.chkbuilt.TabIndex = 12;
      this.chkbuilt.Text = "Build Details";
      this.chkbuilt.UseVisualStyleBackColor = true;
      this.chk_Other_LEL.AutoSize = true;
      this.chk_Other_LEL.Cursor = Cursors.Hand;
      this.chk_Other_LEL.Location = new Point(10, 59);
      this.chk_Other_LEL.Name = "chk_Other_LEL";
      this.chk_Other_LEL.Size = new Size(108, 17);
      this.chk_Other_LEL.TabIndex = 17;
      this.chk_Other_LEL.Text = "Low Energy Light";
      this.chk_Other_LEL.UseVisualStyleBackColor = true;
      this.chk_Other_FixedAir.AutoSize = true;
      this.chk_Other_FixedAir.Cursor = Cursors.Hand;
      this.chk_Other_FixedAir.Location = new Point(10, 36);
      this.chk_Other_FixedAir.Name = "chk_Other_FixedAir";
      this.chk_Other_FixedAir.Size = new Size(170, 17);
      this.chk_Other_FixedAir.TabIndex = 16;
      this.chk_Other_FixedAir.Text = "Fixed Air Conditioning Present";
      this.chk_Other_FixedAir.UseVisualStyleBackColor = true;
      this.chk_Other_Conserv.Cursor = Cursors.Hand;
      this.chk_Other_Conserv.Location = new Point(10, 13);
      this.chk_Other_Conserv.Name = "chk_Other_Conserv";
      this.chk_Other_Conserv.Size = new Size(199, 23);
      this.chk_Other_Conserv.TabIndex = 12;
      this.chk_Other_Conserv.Text = "Separate Heated Conservatory";
      this.chk_Other_Conserv.UseVisualStyleBackColor = true;
      this.GroupBox1.Controls.Add((Control) this.chk_Vent_ThermalMass);
      this.GroupBox1.Controls.Add((Control) this.chk_OverH_AirChangeRate);
      this.GroupBox1.Cursor = Cursors.Default;
      this.GroupBox1.Location = new Point(8, 458);
      this.GroupBox1.Name = "GroupBox1";
      this.GroupBox1.Size = new Size(234, 67);
      this.GroupBox1.TabIndex = 48;
      this.GroupBox1.TabStop = false;
      this.GroupBox1.Text = "Overheating Parameters";
      this.chk_Vent_ThermalMass.AutoSize = true;
      this.chk_Vent_ThermalMass.Cursor = Cursors.Hand;
      this.chk_Vent_ThermalMass.Location = new Point(6, 43);
      this.chk_Vent_ThermalMass.Name = "chk_Vent_ThermalMass";
      this.chk_Vent_ThermalMass.Size = new Size(91, 17);
      this.chk_Vent_ThermalMass.TabIndex = 16;
      this.chk_Vent_ThermalMass.Text = "Thermal Mass";
      this.chk_Vent_ThermalMass.UseVisualStyleBackColor = true;
      this.chk_OverH_AirChangeRate.AutoSize = true;
      this.chk_OverH_AirChangeRate.Cursor = Cursors.Hand;
      this.chk_OverH_AirChangeRate.Location = new Point(6, 20);
      this.chk_OverH_AirChangeRate.Name = "chk_OverH_AirChangeRate";
      this.chk_OverH_AirChangeRate.Size = new Size(151, 17);
      this.chk_OverH_AirChangeRate.TabIndex = 12;
      this.chk_OverH_AirChangeRate.Text = "Effective Air Change Rate";
      this.chk_OverH_AirChangeRate.UseVisualStyleBackColor = true;
      this.Label2.AutoSize = true;
      this.Label2.Font = new Font("Tahoma", 8.25f, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, (byte) 0);
      this.Label2.Location = new Point(0, 0);
      this.Label2.Name = "Label2";
      this.Label2.Size = new Size(125, 13);
      this.Label2.TabIndex = 13;
      this.Label2.Text = "Select Items to Copy";
      this.cmd_RW_Copy.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.cmd_RW_Copy.BackColor = Color.LightSlateGray;
      this.cmd_RW_Copy.Cursor = Cursors.Hand;
      this.cmd_RW_Copy.FlatStyle = FlatStyle.Popup;
      this.cmd_RW_Copy.ForeColor = Color.White;
      this.cmd_RW_Copy.Location = new Point(271, 661);
      this.cmd_RW_Copy.Name = "cmd_RW_Copy";
      this.cmd_RW_Copy.Size = new Size(186, 23);
      this.cmd_RW_Copy.TabIndex = 11;
      this.cmd_RW_Copy.Text = "Copy to Selected Dwellings";
      this.cmd_RW_Copy.UseVisualStyleBackColor = false;
      this.TabControl1.Controls.Add((Control) this.TabPage1);
      this.TabControl1.Controls.Add((Control) this.TabPage2);
      this.TabControl1.Controls.Add((Control) this.TabPage3);
      this.TabControl1.Controls.Add((Control) this.TabPage4);
      this.TabControl1.Controls.Add((Control) this.TabPage5);
      this.TabControl1.Controls.Add((Control) this.TabPage6);
      this.TabControl1.Controls.Add((Control) this.TabPage7);
      this.TabControl1.Controls.Add((Control) this.TabPage8);
      this.TabControl1.Controls.Add((Control) this.TabPage9);
      this.TabControl1.Controls.Add((Control) this.TabPage10);
      this.TabControl1.Controls.Add((Control) this.TabPage11);
      this.TabControl1.Controls.Add((Control) this.TabPage12);
      this.TabControl1.Cursor = Cursors.Hand;
      this.TabControl1.Dock = DockStyle.Fill;
      this.TabControl1.Location = new Point(0, 0);
      this.TabControl1.Multiline = true;
      this.TabControl1.Name = "TabControl1";
      this.TabControl1.SelectedIndex = 0;
      this.TabControl1.Size = new Size(900, 738);
      this.TabControl1.SizeMode = TabSizeMode.Fixed;
      this.TabControl1.TabIndex = 38;
      this.TabPage1.Controls.Add((Control) this.DG1);
      this.TabPage1.Controls.Add((Control) this.pnlRWindow);
      this.TabPage1.Location = new Point(4, 40);
      this.TabPage1.Name = "TabPage1";
      this.TabPage1.Padding = new Padding(3);
      this.TabPage1.Size = new Size(892, 694);
      this.TabPage1.TabIndex = 0;
      this.TabPage1.Text = "Dwelling Elements";
      this.TabPage1.UseVisualStyleBackColor = true;
      this.TabPage2.Controls.Add((Control) this.GroupBox6);
      this.TabPage2.Controls.Add((Control) this.Label3);
      this.TabPage2.Controls.Add((Control) this.DGSFloor);
      this.TabPage2.Controls.Add((Control) this.Label1);
      this.TabPage2.Controls.Add((Control) this.Button2);
      this.TabPage2.Controls.Add((Control) this.Button3);
      this.TabPage2.Controls.Add((Control) this.Button4);
      this.TabPage2.Controls.Add((Control) this.DGFloors);
      this.TabPage2.Cursor = Cursors.Default;
      this.TabPage2.Location = new Point(4, 40);
      this.TabPage2.Name = "TabPage2";
      this.TabPage2.Padding = new Padding(3);
      this.TabPage2.Size = new Size(892, 694);
      this.TabPage2.TabIndex = 1;
      this.TabPage2.Text = "Floors";
      this.TabPage2.UseVisualStyleBackColor = true;
      this.GroupBox6.Controls.Add((Control) this.chk_Floors_Construction);
      this.GroupBox6.Controls.Add((Control) this.chk_Floors_Kappa);
      this.GroupBox6.Controls.Add((Control) this.chk_Floors_U);
      this.GroupBox6.Controls.Add((Control) this.chk_Floors_Area);
      this.GroupBox6.Controls.Add((Control) this.chk_Floors_Type);
      this.GroupBox6.Cursor = Cursors.Default;
      this.GroupBox6.Location = new Point(6, 181);
      this.GroupBox6.Name = "GroupBox6";
      this.GroupBox6.Size = new Size(380, 141);
      this.GroupBox6.TabIndex = 54;
      this.GroupBox6.TabStop = false;
      this.GroupBox6.Text = "Select Details";
      this.chk_Floors_Construction.AutoSize = true;
      this.chk_Floors_Construction.Cursor = Cursors.Hand;
      this.chk_Floors_Construction.Location = new Point(6, 43);
      this.chk_Floors_Construction.Name = "chk_Floors_Construction";
      this.chk_Floors_Construction.Size = new Size(87, 17);
      this.chk_Floors_Construction.TabIndex = 19;
      this.chk_Floors_Construction.Text = "Construction";
      this.chk_Floors_Construction.UseVisualStyleBackColor = true;
      this.chk_Floors_Kappa.AutoSize = true;
      this.chk_Floors_Kappa.Cursor = Cursors.Hand;
      this.chk_Floors_Kappa.Location = new Point(6, 112);
      this.chk_Floors_Kappa.Name = "chk_Floors_Kappa";
      this.chk_Floors_Kappa.Size = new Size(56, 17);
      this.chk_Floors_Kappa.TabIndex = 18;
      this.chk_Floors_Kappa.Text = "Kappa";
      this.chk_Floors_Kappa.UseVisualStyleBackColor = true;
      this.chk_Floors_U.AutoSize = true;
      this.chk_Floors_U.Cursor = Cursors.Hand;
      this.chk_Floors_U.Location = new Point(6, 89);
      this.chk_Floors_U.Name = "chk_Floors_U";
      this.chk_Floors_U.Size = new Size(62, 17);
      this.chk_Floors_U.TabIndex = 17;
      this.chk_Floors_U.Text = "U Value";
      this.chk_Floors_U.UseVisualStyleBackColor = true;
      this.chk_Floors_Area.AutoSize = true;
      this.chk_Floors_Area.Cursor = Cursors.Hand;
      this.chk_Floors_Area.Location = new Point(6, 66);
      this.chk_Floors_Area.Name = "chk_Floors_Area";
      this.chk_Floors_Area.Size = new Size(49, 17);
      this.chk_Floors_Area.TabIndex = 16;
      this.chk_Floors_Area.Text = "Area";
      this.chk_Floors_Area.UseVisualStyleBackColor = true;
      this.chk_Floors_Type.AutoSize = true;
      this.chk_Floors_Type.Cursor = Cursors.Hand;
      this.chk_Floors_Type.Location = new Point(6, 20);
      this.chk_Floors_Type.Name = "chk_Floors_Type";
      this.chk_Floors_Type.Size = new Size(50, 17);
      this.chk_Floors_Type.TabIndex = 12;
      this.chk_Floors_Type.Text = "Type";
      this.chk_Floors_Type.UseVisualStyleBackColor = true;
      this.Label3.AutoSize = true;
      this.Label3.Font = new Font("Tahoma", 8.25f, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, (byte) 0);
      this.Label3.Location = new Point(3, 165);
      this.Label3.Name = "Label3";
      this.Label3.Size = new Size(161, 13);
      this.Label3.TabIndex = 53;
      this.Label3.Text = "Select Floor Details to Copy";
      this.DGSFloor.AllowUserToAddRows = false;
      this.DGSFloor.AllowUserToDeleteRows = false;
      this.DGSFloor.AllowUserToResizeRows = false;
      this.DGSFloor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.DGSFloor.Cursor = Cursors.Hand;
      this.DGSFloor.Location = new Point(6, 19);
      this.DGSFloor.MultiSelect = false;
      this.DGSFloor.Name = "DGSFloor";
      this.DGSFloor.RowHeadersVisible = false;
      this.DGSFloor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.DGSFloor.Size = new Size(380, 143);
      this.DGSFloor.TabIndex = 52;
      this.Label1.AutoSize = true;
      this.Label1.Font = new Font("Tahoma", 8.25f, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, (byte) 0);
      this.Label1.Location = new Point(3, 3);
      this.Label1.Name = "Label1";
      this.Label1.Size = new Size(119, 13);
      this.Label1.TabIndex = 51;
      this.Label1.Text = "Select Floor to Copy";
      this.Button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.Button2.BackColor = Color.LightSlateGray;
      this.Button2.Cursor = Cursors.Hand;
      this.Button2.FlatStyle = FlatStyle.Popup;
      this.Button2.ForeColor = Color.White;
      this.Button2.Location = new Point(205, 568);
      this.Button2.Name = "Button2";
      this.Button2.Size = new Size(90, 23);
      this.Button2.TabIndex = 49;
      this.Button2.Text = "Select All";
      this.Button2.UseVisualStyleBackColor = false;
      this.Button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.Button3.BackColor = Color.LightSlateGray;
      this.Button3.Cursor = Cursors.Hand;
      this.Button3.FlatStyle = FlatStyle.Popup;
      this.Button3.ForeColor = Color.White;
      this.Button3.Location = new Point(301, 568);
      this.Button3.Name = "Button3";
      this.Button3.Size = new Size(90, 23);
      this.Button3.TabIndex = 50;
      this.Button3.Text = "Select None";
      this.Button3.UseVisualStyleBackColor = false;
      this.Button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.Button4.BackColor = Color.LightSlateGray;
      this.Button4.Cursor = Cursors.Hand;
      this.Button4.FlatStyle = FlatStyle.Popup;
      this.Button4.ForeColor = Color.White;
      this.Button4.Location = new Point(205, 597);
      this.Button4.Name = "Button4";
      this.Button4.Size = new Size(186, 23);
      this.Button4.TabIndex = 48;
      this.Button4.Text = "Copy to Selected Dwellings";
      this.Button4.UseVisualStyleBackColor = false;
      this.DGFloors.AllowUserToAddRows = false;
      this.DGFloors.AllowUserToDeleteRows = false;
      this.DGFloors.AllowUserToResizeRows = false;
      this.DGFloors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.DGFloors.Cursor = Cursors.Hand;
      this.DGFloors.Dock = DockStyle.Right;
      this.DGFloors.Location = new Point(559, 3);
      this.DGFloors.Name = "DGFloors";
      this.DGFloors.RowHeadersVisible = false;
      this.DGFloors.Size = new Size(330, 688);
      this.DGFloors.TabIndex = 44;
      this.TabPage3.Controls.Add((Control) this.GroupBox8);
      this.TabPage3.Controls.Add((Control) this.Label4);
      this.TabPage3.Controls.Add((Control) this.DGSWall);
      this.TabPage3.Controls.Add((Control) this.Label5);
      this.TabPage3.Controls.Add((Control) this.Button5);
      this.TabPage3.Controls.Add((Control) this.Button6);
      this.TabPage3.Controls.Add((Control) this.Button7);
      this.TabPage3.Controls.Add((Control) this.DGWalls);
      this.TabPage3.Cursor = Cursors.Default;
      this.TabPage3.Location = new Point(4, 40);
      this.TabPage3.Name = "TabPage3";
      this.TabPage3.Padding = new Padding(3);
      this.TabPage3.Size = new Size(892, 694);
      this.TabPage3.TabIndex = 2;
      this.TabPage3.Text = "Walls";
      this.TabPage3.UseVisualStyleBackColor = true;
      this.GroupBox8.Controls.Add((Control) this.chk_Walls_Construction);
      this.GroupBox8.Controls.Add((Control) this.chk_Walls_Kappa);
      this.GroupBox8.Controls.Add((Control) this.chk_Walls_Curtain);
      this.GroupBox8.Controls.Add((Control) this.chk_Walls_Ru);
      this.GroupBox8.Controls.Add((Control) this.chk_Walls_UValue);
      this.GroupBox8.Controls.Add((Control) this.chk_Walls_Area);
      this.GroupBox8.Controls.Add((Control) this.chk_Walls_Type);
      this.GroupBox8.Cursor = Cursors.Default;
      this.GroupBox8.Location = new Point(6, 181);
      this.GroupBox8.Name = "GroupBox8";
      this.GroupBox8.Size = new Size(380, 194);
      this.GroupBox8.TabIndex = 61;
      this.GroupBox8.TabStop = false;
      this.GroupBox8.Text = "Select Details";
      this.chk_Walls_Construction.AutoSize = true;
      this.chk_Walls_Construction.Cursor = Cursors.Hand;
      this.chk_Walls_Construction.Location = new Point(6, 43);
      this.chk_Walls_Construction.Name = "chk_Walls_Construction";
      this.chk_Walls_Construction.Size = new Size(87, 17);
      this.chk_Walls_Construction.TabIndex = 21;
      this.chk_Walls_Construction.Text = "Construction";
      this.chk_Walls_Construction.UseVisualStyleBackColor = true;
      this.chk_Walls_Kappa.AutoSize = true;
      this.chk_Walls_Kappa.Cursor = Cursors.Hand;
      this.chk_Walls_Kappa.Location = new Point(6, 135);
      this.chk_Walls_Kappa.Name = "chk_Walls_Kappa";
      this.chk_Walls_Kappa.Size = new Size(56, 17);
      this.chk_Walls_Kappa.TabIndex = 20;
      this.chk_Walls_Kappa.Text = "Kappa";
      this.chk_Walls_Kappa.UseVisualStyleBackColor = true;
      this.chk_Walls_Curtain.AutoSize = true;
      this.chk_Walls_Curtain.Cursor = Cursors.Hand;
      this.chk_Walls_Curtain.Location = new Point(6, 158);
      this.chk_Walls_Curtain.Name = "chk_Walls_Curtain";
      this.chk_Walls_Curtain.Size = new Size(84, 17);
      this.chk_Walls_Curtain.TabIndex = 19;
      this.chk_Walls_Curtain.Text = "Curtain Wall";
      this.chk_Walls_Curtain.UseVisualStyleBackColor = true;
      this.chk_Walls_Ru.AutoSize = true;
      this.chk_Walls_Ru.Cursor = Cursors.Hand;
      this.chk_Walls_Ru.Location = new Point(6, 112);
      this.chk_Walls_Ru.Name = "chk_Walls_Ru";
      this.chk_Walls_Ru.Size = new Size(68, 17);
      this.chk_Walls_Ru.TabIndex = 18;
      this.chk_Walls_Ru.Text = "Ru Value";
      this.chk_Walls_Ru.UseVisualStyleBackColor = true;
      this.chk_Walls_UValue.AutoSize = true;
      this.chk_Walls_UValue.Cursor = Cursors.Hand;
      this.chk_Walls_UValue.Location = new Point(6, 89);
      this.chk_Walls_UValue.Name = "chk_Walls_UValue";
      this.chk_Walls_UValue.Size = new Size(62, 17);
      this.chk_Walls_UValue.TabIndex = 17;
      this.chk_Walls_UValue.Text = "U Value";
      this.chk_Walls_UValue.UseVisualStyleBackColor = true;
      this.chk_Walls_Area.AutoSize = true;
      this.chk_Walls_Area.Cursor = Cursors.Hand;
      this.chk_Walls_Area.Location = new Point(6, 66);
      this.chk_Walls_Area.Name = "chk_Walls_Area";
      this.chk_Walls_Area.Size = new Size(49, 17);
      this.chk_Walls_Area.TabIndex = 16;
      this.chk_Walls_Area.Text = "Area";
      this.chk_Walls_Area.UseVisualStyleBackColor = true;
      this.chk_Walls_Type.AutoSize = true;
      this.chk_Walls_Type.Cursor = Cursors.Hand;
      this.chk_Walls_Type.Location = new Point(6, 20);
      this.chk_Walls_Type.Name = "chk_Walls_Type";
      this.chk_Walls_Type.Size = new Size(50, 17);
      this.chk_Walls_Type.TabIndex = 12;
      this.chk_Walls_Type.Text = "Type";
      this.chk_Walls_Type.UseVisualStyleBackColor = true;
      this.Label4.AutoSize = true;
      this.Label4.Font = new Font("Tahoma", 8.25f, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, (byte) 0);
      this.Label4.Location = new Point(3, 165);
      this.Label4.Name = "Label4";
      this.Label4.Size = new Size(157, 13);
      this.Label4.TabIndex = 60;
      this.Label4.Text = "Select Wall Details to Copy";
      this.DGSWall.AllowUserToAddRows = false;
      this.DGSWall.AllowUserToDeleteRows = false;
      this.DGSWall.AllowUserToResizeRows = false;
      this.DGSWall.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.DGSWall.Cursor = Cursors.Hand;
      this.DGSWall.Location = new Point(6, 19);
      this.DGSWall.MultiSelect = false;
      this.DGSWall.Name = "DGSWall";
      this.DGSWall.RowHeadersVisible = false;
      this.DGSWall.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.DGSWall.Size = new Size(380, 143);
      this.DGSWall.TabIndex = 59;
      this.Label5.AutoSize = true;
      this.Label5.Font = new Font("Tahoma", 8.25f, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, (byte) 0);
      this.Label5.Location = new Point(3, 3);
      this.Label5.Name = "Label5";
      this.Label5.Size = new Size(115, 13);
      this.Label5.TabIndex = 58;
      this.Label5.Text = "Select Wall to Copy";
      this.Button5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.Button5.BackColor = Color.LightSlateGray;
      this.Button5.Cursor = Cursors.Hand;
      this.Button5.FlatStyle = FlatStyle.Popup;
      this.Button5.ForeColor = Color.White;
      this.Button5.Location = new Point(205, 568);
      this.Button5.Name = "Button5";
      this.Button5.Size = new Size(90, 23);
      this.Button5.TabIndex = 56;
      this.Button5.Text = "Select All";
      this.Button5.UseVisualStyleBackColor = false;
      this.Button6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.Button6.BackColor = Color.LightSlateGray;
      this.Button6.Cursor = Cursors.Hand;
      this.Button6.FlatStyle = FlatStyle.Popup;
      this.Button6.ForeColor = Color.White;
      this.Button6.Location = new Point(301, 568);
      this.Button6.Name = "Button6";
      this.Button6.Size = new Size(90, 23);
      this.Button6.TabIndex = 57;
      this.Button6.Text = "Select None";
      this.Button6.UseVisualStyleBackColor = false;
      this.Button7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.Button7.BackColor = Color.LightSlateGray;
      this.Button7.Cursor = Cursors.Hand;
      this.Button7.FlatStyle = FlatStyle.Popup;
      this.Button7.ForeColor = Color.White;
      this.Button7.Location = new Point(205, 597);
      this.Button7.Name = "Button7";
      this.Button7.Size = new Size(186, 23);
      this.Button7.TabIndex = 55;
      this.Button7.Text = "Copy to Selected Dwellings";
      this.Button7.UseVisualStyleBackColor = false;
      this.DGWalls.AllowUserToAddRows = false;
      this.DGWalls.AllowUserToDeleteRows = false;
      this.DGWalls.AllowUserToResizeRows = false;
      this.DGWalls.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.DGWalls.Cursor = Cursors.Hand;
      this.DGWalls.Dock = DockStyle.Right;
      this.DGWalls.Location = new Point(559, 3);
      this.DGWalls.Name = "DGWalls";
      this.DGWalls.RowHeadersVisible = false;
      this.DGWalls.Size = new Size(330, 688);
      this.DGWalls.TabIndex = 45;
      this.TabPage4.Controls.Add((Control) this.GroupBox9);
      this.TabPage4.Controls.Add((Control) this.Label6);
      this.TabPage4.Controls.Add((Control) this.DGSRoof);
      this.TabPage4.Controls.Add((Control) this.Label7);
      this.TabPage4.Controls.Add((Control) this.Button8);
      this.TabPage4.Controls.Add((Control) this.Button9);
      this.TabPage4.Controls.Add((Control) this.Button10);
      this.TabPage4.Controls.Add((Control) this.DGRoofs);
      this.TabPage4.Cursor = Cursors.Default;
      this.TabPage4.Location = new Point(4, 40);
      this.TabPage4.Name = "TabPage4";
      this.TabPage4.Padding = new Padding(3);
      this.TabPage4.Size = new Size(892, 694);
      this.TabPage4.TabIndex = 3;
      this.TabPage4.Text = "Roofs";
      this.TabPage4.UseVisualStyleBackColor = true;
      this.GroupBox9.Controls.Add((Control) this.chk_Roofs_Construction);
      this.GroupBox9.Controls.Add((Control) this.chk_Roofs_Kappa);
      this.GroupBox9.Controls.Add((Control) this.chk_Roofs_Ru);
      this.GroupBox9.Controls.Add((Control) this.chk_Roofs_UValue);
      this.GroupBox9.Controls.Add((Control) this.chk_Roofs_Area);
      this.GroupBox9.Controls.Add((Control) this.chk_Roofs_Type);
      this.GroupBox9.Cursor = Cursors.Default;
      this.GroupBox9.Location = new Point(6, 181);
      this.GroupBox9.Name = "GroupBox9";
      this.GroupBox9.Size = new Size(380, 161);
      this.GroupBox9.TabIndex = 68;
      this.GroupBox9.TabStop = false;
      this.GroupBox9.Text = "Select Details";
      this.chk_Roofs_Construction.AutoSize = true;
      this.chk_Roofs_Construction.Cursor = Cursors.Hand;
      this.chk_Roofs_Construction.Location = new Point(6, 43);
      this.chk_Roofs_Construction.Name = "chk_Roofs_Construction";
      this.chk_Roofs_Construction.Size = new Size(87, 17);
      this.chk_Roofs_Construction.TabIndex = 23;
      this.chk_Roofs_Construction.Text = "Construction";
      this.chk_Roofs_Construction.UseVisualStyleBackColor = true;
      this.chk_Roofs_Kappa.AutoSize = true;
      this.chk_Roofs_Kappa.Cursor = Cursors.Hand;
      this.chk_Roofs_Kappa.Location = new Point(6, 135);
      this.chk_Roofs_Kappa.Name = "chk_Roofs_Kappa";
      this.chk_Roofs_Kappa.Size = new Size(56, 17);
      this.chk_Roofs_Kappa.TabIndex = 22;
      this.chk_Roofs_Kappa.Text = "Kappa";
      this.chk_Roofs_Kappa.UseVisualStyleBackColor = true;
      this.chk_Roofs_Ru.AutoSize = true;
      this.chk_Roofs_Ru.Cursor = Cursors.Hand;
      this.chk_Roofs_Ru.Location = new Point(6, 112);
      this.chk_Roofs_Ru.Name = "chk_Roofs_Ru";
      this.chk_Roofs_Ru.Size = new Size(68, 17);
      this.chk_Roofs_Ru.TabIndex = 18;
      this.chk_Roofs_Ru.Text = "Ru Value";
      this.chk_Roofs_Ru.UseVisualStyleBackColor = true;
      this.chk_Roofs_UValue.AutoSize = true;
      this.chk_Roofs_UValue.Cursor = Cursors.Hand;
      this.chk_Roofs_UValue.Location = new Point(6, 89);
      this.chk_Roofs_UValue.Name = "chk_Roofs_UValue";
      this.chk_Roofs_UValue.Size = new Size(62, 17);
      this.chk_Roofs_UValue.TabIndex = 17;
      this.chk_Roofs_UValue.Text = "U Value";
      this.chk_Roofs_UValue.UseVisualStyleBackColor = true;
      this.chk_Roofs_Area.AutoSize = true;
      this.chk_Roofs_Area.Cursor = Cursors.Hand;
      this.chk_Roofs_Area.Location = new Point(6, 66);
      this.chk_Roofs_Area.Name = "chk_Roofs_Area";
      this.chk_Roofs_Area.Size = new Size(49, 17);
      this.chk_Roofs_Area.TabIndex = 16;
      this.chk_Roofs_Area.Text = "Area";
      this.chk_Roofs_Area.UseVisualStyleBackColor = true;
      this.chk_Roofs_Type.AutoSize = true;
      this.chk_Roofs_Type.Cursor = Cursors.Hand;
      this.chk_Roofs_Type.Location = new Point(6, 20);
      this.chk_Roofs_Type.Name = "chk_Roofs_Type";
      this.chk_Roofs_Type.Size = new Size(50, 17);
      this.chk_Roofs_Type.TabIndex = 12;
      this.chk_Roofs_Type.Text = "Type";
      this.chk_Roofs_Type.UseVisualStyleBackColor = true;
      this.Label6.AutoSize = true;
      this.Label6.Font = new Font("Tahoma", 8.25f, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, (byte) 0);
      this.Label6.Location = new Point(3, 165);
      this.Label6.Name = "Label6";
      this.Label6.Size = new Size(159, 13);
      this.Label6.TabIndex = 67;
      this.Label6.Text = "Select Roof Details to Copy";
      this.DGSRoof.AllowUserToAddRows = false;
      this.DGSRoof.AllowUserToDeleteRows = false;
      this.DGSRoof.AllowUserToResizeRows = false;
      this.DGSRoof.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.DGSRoof.Cursor = Cursors.Hand;
      this.DGSRoof.Location = new Point(6, 19);
      this.DGSRoof.MultiSelect = false;
      this.DGSRoof.Name = "DGSRoof";
      this.DGSRoof.RowHeadersVisible = false;
      this.DGSRoof.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.DGSRoof.Size = new Size(380, 143);
      this.DGSRoof.TabIndex = 66;
      this.Label7.AutoSize = true;
      this.Label7.Font = new Font("Tahoma", 8.25f, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, (byte) 0);
      this.Label7.Location = new Point(3, 3);
      this.Label7.Name = "Label7";
      this.Label7.Size = new Size(117, 13);
      this.Label7.TabIndex = 65;
      this.Label7.Text = "Select Roof to Copy";
      this.Button8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.Button8.BackColor = Color.LightSlateGray;
      this.Button8.Cursor = Cursors.Hand;
      this.Button8.FlatStyle = FlatStyle.Popup;
      this.Button8.ForeColor = Color.White;
      this.Button8.Location = new Point(205, 568);
      this.Button8.Name = "Button8";
      this.Button8.Size = new Size(90, 23);
      this.Button8.TabIndex = 63;
      this.Button8.Text = "Select All";
      this.Button8.UseVisualStyleBackColor = false;
      this.Button9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.Button9.BackColor = Color.LightSlateGray;
      this.Button9.Cursor = Cursors.Hand;
      this.Button9.FlatStyle = FlatStyle.Popup;
      this.Button9.ForeColor = Color.White;
      this.Button9.Location = new Point(301, 568);
      this.Button9.Name = "Button9";
      this.Button9.Size = new Size(90, 23);
      this.Button9.TabIndex = 64;
      this.Button9.Text = "Select None";
      this.Button9.UseVisualStyleBackColor = false;
      this.Button10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.Button10.BackColor = Color.LightSlateGray;
      this.Button10.Cursor = Cursors.Hand;
      this.Button10.FlatStyle = FlatStyle.Popup;
      this.Button10.ForeColor = Color.White;
      this.Button10.Location = new Point(205, 597);
      this.Button10.Name = "Button10";
      this.Button10.Size = new Size(186, 23);
      this.Button10.TabIndex = 62;
      this.Button10.Text = "Copy to Selected Dwellings";
      this.Button10.UseVisualStyleBackColor = false;
      this.DGRoofs.AllowUserToAddRows = false;
      this.DGRoofs.AllowUserToDeleteRows = false;
      this.DGRoofs.AllowUserToResizeRows = false;
      this.DGRoofs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.DGRoofs.Cursor = Cursors.Hand;
      this.DGRoofs.Dock = DockStyle.Right;
      this.DGRoofs.Location = new Point(559, 3);
      this.DGRoofs.Name = "DGRoofs";
      this.DGRoofs.RowHeadersVisible = false;
      this.DGRoofs.Size = new Size(330, 688);
      this.DGRoofs.TabIndex = 45;
      this.TabPage5.Controls.Add((Control) this.GroupBox10);
      this.TabPage5.Controls.Add((Control) this.Label8);
      this.TabPage5.Controls.Add((Control) this.DGSFloorI);
      this.TabPage5.Controls.Add((Control) this.Label9);
      this.TabPage5.Controls.Add((Control) this.Button12);
      this.TabPage5.Controls.Add((Control) this.Button13);
      this.TabPage5.Controls.Add((Control) this.Button14);
      this.TabPage5.Controls.Add((Control) this.DGFloorsI);
      this.TabPage5.Location = new Point(4, 40);
      this.TabPage5.Name = "TabPage5";
      this.TabPage5.Padding = new Padding(3);
      this.TabPage5.Size = new Size(892, 694);
      this.TabPage5.TabIndex = 4;
      this.TabPage5.Text = "Internal Floors";
      this.TabPage5.UseVisualStyleBackColor = true;
      this.GroupBox10.Controls.Add((Control) this.chk_IFloors_Construction);
      this.GroupBox10.Controls.Add((Control) this.chk_IFloors_Kappa);
      this.GroupBox10.Controls.Add((Control) this.chk_IFloors_Area);
      this.GroupBox10.Cursor = Cursors.Default;
      this.GroupBox10.Location = new Point(6, 181);
      this.GroupBox10.Name = "GroupBox10";
      this.GroupBox10.Size = new Size(380, 97);
      this.GroupBox10.TabIndex = 62;
      this.GroupBox10.TabStop = false;
      this.GroupBox10.Text = "Select Details";
      this.chk_IFloors_Construction.AutoSize = true;
      this.chk_IFloors_Construction.Cursor = Cursors.Hand;
      this.chk_IFloors_Construction.Location = new Point(6, 20);
      this.chk_IFloors_Construction.Name = "chk_IFloors_Construction";
      this.chk_IFloors_Construction.Size = new Size(87, 17);
      this.chk_IFloors_Construction.TabIndex = 19;
      this.chk_IFloors_Construction.Text = "Construction";
      this.chk_IFloors_Construction.UseVisualStyleBackColor = true;
      this.chk_IFloors_Kappa.AutoSize = true;
      this.chk_IFloors_Kappa.Cursor = Cursors.Hand;
      this.chk_IFloors_Kappa.Location = new Point(6, 66);
      this.chk_IFloors_Kappa.Name = "chk_IFloors_Kappa";
      this.chk_IFloors_Kappa.Size = new Size(56, 17);
      this.chk_IFloors_Kappa.TabIndex = 18;
      this.chk_IFloors_Kappa.Text = "Kappa";
      this.chk_IFloors_Kappa.UseVisualStyleBackColor = true;
      this.chk_IFloors_Area.AutoSize = true;
      this.chk_IFloors_Area.Cursor = Cursors.Hand;
      this.chk_IFloors_Area.Location = new Point(6, 43);
      this.chk_IFloors_Area.Name = "chk_IFloors_Area";
      this.chk_IFloors_Area.Size = new Size(49, 17);
      this.chk_IFloors_Area.TabIndex = 16;
      this.chk_IFloors_Area.Text = "Area";
      this.chk_IFloors_Area.UseVisualStyleBackColor = true;
      this.Label8.AutoSize = true;
      this.Label8.Font = new Font("Tahoma", 8.25f, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, (byte) 0);
      this.Label8.Location = new Point(3, 165);
      this.Label8.Name = "Label8";
      this.Label8.Size = new Size(161, 13);
      this.Label8.TabIndex = 61;
      this.Label8.Text = "Select Floor Details to Copy";
      this.DGSFloorI.AllowUserToAddRows = false;
      this.DGSFloorI.AllowUserToDeleteRows = false;
      this.DGSFloorI.AllowUserToResizeRows = false;
      this.DGSFloorI.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.DGSFloorI.Cursor = Cursors.Hand;
      this.DGSFloorI.Location = new Point(6, 19);
      this.DGSFloorI.MultiSelect = false;
      this.DGSFloorI.Name = "DGSFloorI";
      this.DGSFloorI.RowHeadersVisible = false;
      this.DGSFloorI.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.DGSFloorI.Size = new Size(380, 143);
      this.DGSFloorI.TabIndex = 60;
      this.Label9.AutoSize = true;
      this.Label9.Font = new Font("Tahoma", 8.25f, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, (byte) 0);
      this.Label9.Location = new Point(3, 3);
      this.Label9.Name = "Label9";
      this.Label9.Size = new Size(119, 13);
      this.Label9.TabIndex = 59;
      this.Label9.Text = "Select Floor to Copy";
      this.Button12.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.Button12.BackColor = Color.LightSlateGray;
      this.Button12.Cursor = Cursors.Hand;
      this.Button12.FlatStyle = FlatStyle.Popup;
      this.Button12.ForeColor = Color.White;
      this.Button12.Location = new Point(205, 568);
      this.Button12.Name = "Button12";
      this.Button12.Size = new Size(90, 23);
      this.Button12.TabIndex = 57;
      this.Button12.Text = "Select All";
      this.Button12.UseVisualStyleBackColor = false;
      this.Button13.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.Button13.BackColor = Color.LightSlateGray;
      this.Button13.Cursor = Cursors.Hand;
      this.Button13.FlatStyle = FlatStyle.Popup;
      this.Button13.ForeColor = Color.White;
      this.Button13.Location = new Point(301, 568);
      this.Button13.Name = "Button13";
      this.Button13.Size = new Size(90, 23);
      this.Button13.TabIndex = 58;
      this.Button13.Text = "Select None";
      this.Button13.UseVisualStyleBackColor = false;
      this.Button14.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.Button14.BackColor = Color.LightSlateGray;
      this.Button14.Cursor = Cursors.Hand;
      this.Button14.FlatStyle = FlatStyle.Popup;
      this.Button14.ForeColor = Color.White;
      this.Button14.Location = new Point(205, 597);
      this.Button14.Name = "Button14";
      this.Button14.Size = new Size(186, 23);
      this.Button14.TabIndex = 56;
      this.Button14.Text = "Copy to Selected Dwellings";
      this.Button14.UseVisualStyleBackColor = false;
      this.DGFloorsI.AllowUserToAddRows = false;
      this.DGFloorsI.AllowUserToDeleteRows = false;
      this.DGFloorsI.AllowUserToResizeRows = false;
      this.DGFloorsI.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.DGFloorsI.Cursor = Cursors.Hand;
      this.DGFloorsI.Dock = DockStyle.Right;
      this.DGFloorsI.Location = new Point(559, 3);
      this.DGFloorsI.Name = "DGFloorsI";
      this.DGFloorsI.RowHeadersVisible = false;
      this.DGFloorsI.Size = new Size(330, 688);
      this.DGFloorsI.TabIndex = 55;
      this.TabPage6.Controls.Add((Control) this.GroupBox12);
      this.TabPage6.Controls.Add((Control) this.Label12);
      this.TabPage6.Controls.Add((Control) this.DGSWallI);
      this.TabPage6.Controls.Add((Control) this.Label13);
      this.TabPage6.Controls.Add((Control) this.Button18);
      this.TabPage6.Controls.Add((Control) this.Button19);
      this.TabPage6.Controls.Add((Control) this.Button20);
      this.TabPage6.Controls.Add((Control) this.DGWallsI);
      this.TabPage6.Location = new Point(4, 40);
      this.TabPage6.Name = "TabPage6";
      this.TabPage6.Padding = new Padding(3);
      this.TabPage6.Size = new Size(892, 694);
      this.TabPage6.TabIndex = 5;
      this.TabPage6.Text = "Internal Walls";
      this.TabPage6.UseVisualStyleBackColor = true;
      this.GroupBox12.Controls.Add((Control) this.chk_IWalls_Construction);
      this.GroupBox12.Controls.Add((Control) this.chk_IWalls_Kappa);
      this.GroupBox12.Controls.Add((Control) this.chk_IWalls_Area);
      this.GroupBox12.Cursor = Cursors.Default;
      this.GroupBox12.Location = new Point(6, 181);
      this.GroupBox12.Name = "GroupBox12";
      this.GroupBox12.Size = new Size(380, 96);
      this.GroupBox12.TabIndex = 69;
      this.GroupBox12.TabStop = false;
      this.GroupBox12.Text = "Select Details";
      this.chk_IWalls_Construction.AutoSize = true;
      this.chk_IWalls_Construction.Cursor = Cursors.Hand;
      this.chk_IWalls_Construction.Location = new Point(6, 20);
      this.chk_IWalls_Construction.Name = "chk_IWalls_Construction";
      this.chk_IWalls_Construction.Size = new Size(87, 17);
      this.chk_IWalls_Construction.TabIndex = 21;
      this.chk_IWalls_Construction.Text = "Construction";
      this.chk_IWalls_Construction.UseVisualStyleBackColor = true;
      this.chk_IWalls_Kappa.AutoSize = true;
      this.chk_IWalls_Kappa.Cursor = Cursors.Hand;
      this.chk_IWalls_Kappa.Location = new Point(6, 66);
      this.chk_IWalls_Kappa.Name = "chk_IWalls_Kappa";
      this.chk_IWalls_Kappa.Size = new Size(56, 17);
      this.chk_IWalls_Kappa.TabIndex = 20;
      this.chk_IWalls_Kappa.Text = "Kappa";
      this.chk_IWalls_Kappa.UseVisualStyleBackColor = true;
      this.chk_IWalls_Area.AutoSize = true;
      this.chk_IWalls_Area.Cursor = Cursors.Hand;
      this.chk_IWalls_Area.Location = new Point(6, 43);
      this.chk_IWalls_Area.Name = "chk_IWalls_Area";
      this.chk_IWalls_Area.Size = new Size(49, 17);
      this.chk_IWalls_Area.TabIndex = 16;
      this.chk_IWalls_Area.Text = "Area";
      this.chk_IWalls_Area.UseVisualStyleBackColor = true;
      this.Label12.AutoSize = true;
      this.Label12.Font = new Font("Tahoma", 8.25f, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, (byte) 0);
      this.Label12.Location = new Point(3, 165);
      this.Label12.Name = "Label12";
      this.Label12.Size = new Size(157, 13);
      this.Label12.TabIndex = 68;
      this.Label12.Text = "Select Wall Details to Copy";
      this.DGSWallI.AllowUserToAddRows = false;
      this.DGSWallI.AllowUserToDeleteRows = false;
      this.DGSWallI.AllowUserToResizeRows = false;
      this.DGSWallI.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.DGSWallI.Cursor = Cursors.Hand;
      this.DGSWallI.Location = new Point(6, 19);
      this.DGSWallI.MultiSelect = false;
      this.DGSWallI.Name = "DGSWallI";
      this.DGSWallI.RowHeadersVisible = false;
      this.DGSWallI.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.DGSWallI.Size = new Size(380, 143);
      this.DGSWallI.TabIndex = 67;
      this.Label13.AutoSize = true;
      this.Label13.Font = new Font("Tahoma", 8.25f, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, (byte) 0);
      this.Label13.Location = new Point(3, 3);
      this.Label13.Name = "Label13";
      this.Label13.Size = new Size(115, 13);
      this.Label13.TabIndex = 66;
      this.Label13.Text = "Select Wall to Copy";
      this.Button18.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.Button18.BackColor = Color.LightSlateGray;
      this.Button18.Cursor = Cursors.Hand;
      this.Button18.FlatStyle = FlatStyle.Popup;
      this.Button18.ForeColor = Color.White;
      this.Button18.Location = new Point(205, 568);
      this.Button18.Name = "Button18";
      this.Button18.Size = new Size(90, 23);
      this.Button18.TabIndex = 64;
      this.Button18.Text = "Select All";
      this.Button18.UseVisualStyleBackColor = false;
      this.Button19.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.Button19.BackColor = Color.LightSlateGray;
      this.Button19.Cursor = Cursors.Hand;
      this.Button19.FlatStyle = FlatStyle.Popup;
      this.Button19.ForeColor = Color.White;
      this.Button19.Location = new Point(301, 568);
      this.Button19.Name = "Button19";
      this.Button19.Size = new Size(90, 23);
      this.Button19.TabIndex = 65;
      this.Button19.Text = "Select None";
      this.Button19.UseVisualStyleBackColor = false;
      this.Button20.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.Button20.BackColor = Color.LightSlateGray;
      this.Button20.Cursor = Cursors.Hand;
      this.Button20.FlatStyle = FlatStyle.Popup;
      this.Button20.ForeColor = Color.White;
      this.Button20.Location = new Point(205, 597);
      this.Button20.Name = "Button20";
      this.Button20.Size = new Size(186, 23);
      this.Button20.TabIndex = 63;
      this.Button20.Text = "Copy to Selected Dwellings";
      this.Button20.UseVisualStyleBackColor = false;
      this.DGWallsI.AllowUserToAddRows = false;
      this.DGWallsI.AllowUserToDeleteRows = false;
      this.DGWallsI.AllowUserToResizeRows = false;
      this.DGWallsI.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.DGWallsI.Cursor = Cursors.Hand;
      this.DGWallsI.Dock = DockStyle.Right;
      this.DGWallsI.Location = new Point(559, 3);
      this.DGWallsI.Name = "DGWallsI";
      this.DGWallsI.RowHeadersVisible = false;
      this.DGWallsI.Size = new Size(330, 688);
      this.DGWallsI.TabIndex = 62;
      this.TabPage7.Controls.Add((Control) this.GroupBox14);
      this.TabPage7.Controls.Add((Control) this.Label16);
      this.TabPage7.Controls.Add((Control) this.DGSRoofI);
      this.TabPage7.Controls.Add((Control) this.Label17);
      this.TabPage7.Controls.Add((Control) this.Button24);
      this.TabPage7.Controls.Add((Control) this.Button25);
      this.TabPage7.Controls.Add((Control) this.Button26);
      this.TabPage7.Controls.Add((Control) this.DGRoofsI);
      this.TabPage7.Location = new Point(4, 40);
      this.TabPage7.Name = "TabPage7";
      this.TabPage7.Padding = new Padding(3);
      this.TabPage7.Size = new Size(892, 694);
      this.TabPage7.TabIndex = 6;
      this.TabPage7.Text = "Internal Ceilings";
      this.TabPage7.UseVisualStyleBackColor = true;
      this.GroupBox14.Controls.Add((Control) this.chk_IRoofs_Construction);
      this.GroupBox14.Controls.Add((Control) this.chk_IRoofs_Kappa);
      this.GroupBox14.Controls.Add((Control) this.chk_IRoofs_Area);
      this.GroupBox14.Cursor = Cursors.Default;
      this.GroupBox14.Location = new Point(6, 181);
      this.GroupBox14.Name = "GroupBox14";
      this.GroupBox14.Size = new Size(380, 98);
      this.GroupBox14.TabIndex = 76;
      this.GroupBox14.TabStop = false;
      this.GroupBox14.Text = "Select Details";
      this.chk_IRoofs_Construction.AutoSize = true;
      this.chk_IRoofs_Construction.Cursor = Cursors.Hand;
      this.chk_IRoofs_Construction.Location = new Point(6, 20);
      this.chk_IRoofs_Construction.Name = "chk_IRoofs_Construction";
      this.chk_IRoofs_Construction.Size = new Size(87, 17);
      this.chk_IRoofs_Construction.TabIndex = 23;
      this.chk_IRoofs_Construction.Text = "Construction";
      this.chk_IRoofs_Construction.UseVisualStyleBackColor = true;
      this.chk_IRoofs_Kappa.AutoSize = true;
      this.chk_IRoofs_Kappa.Cursor = Cursors.Hand;
      this.chk_IRoofs_Kappa.Location = new Point(6, 66);
      this.chk_IRoofs_Kappa.Name = "chk_IRoofs_Kappa";
      this.chk_IRoofs_Kappa.Size = new Size(56, 17);
      this.chk_IRoofs_Kappa.TabIndex = 22;
      this.chk_IRoofs_Kappa.Text = "Kappa";
      this.chk_IRoofs_Kappa.UseVisualStyleBackColor = true;
      this.chk_IRoofs_Area.AutoSize = true;
      this.chk_IRoofs_Area.Cursor = Cursors.Hand;
      this.chk_IRoofs_Area.Location = new Point(6, 43);
      this.chk_IRoofs_Area.Name = "chk_IRoofs_Area";
      this.chk_IRoofs_Area.Size = new Size(49, 17);
      this.chk_IRoofs_Area.TabIndex = 16;
      this.chk_IRoofs_Area.Text = "Area";
      this.chk_IRoofs_Area.UseVisualStyleBackColor = true;
      this.Label16.AutoSize = true;
      this.Label16.Font = new Font("Tahoma", 8.25f, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, (byte) 0);
      this.Label16.Location = new Point(3, 165);
      this.Label16.Name = "Label16";
      this.Label16.Size = new Size(170, 13);
      this.Label16.TabIndex = 75;
      this.Label16.Text = "Select Ceiling Details to Copy";
      this.DGSRoofI.AllowUserToAddRows = false;
      this.DGSRoofI.AllowUserToDeleteRows = false;
      this.DGSRoofI.AllowUserToResizeRows = false;
      this.DGSRoofI.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.DGSRoofI.Cursor = Cursors.Hand;
      this.DGSRoofI.Location = new Point(6, 19);
      this.DGSRoofI.MultiSelect = false;
      this.DGSRoofI.Name = "DGSRoofI";
      this.DGSRoofI.RowHeadersVisible = false;
      this.DGSRoofI.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.DGSRoofI.Size = new Size(380, 143);
      this.DGSRoofI.TabIndex = 74;
      this.Label17.AutoSize = true;
      this.Label17.Font = new Font("Tahoma", 8.25f, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, (byte) 0);
      this.Label17.Location = new Point(3, 3);
      this.Label17.Name = "Label17";
      this.Label17.Size = new Size(128, 13);
      this.Label17.TabIndex = 73;
      this.Label17.Text = "Select Ceiling to Copy";
      this.Button24.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.Button24.BackColor = Color.LightSlateGray;
      this.Button24.Cursor = Cursors.Hand;
      this.Button24.FlatStyle = FlatStyle.Popup;
      this.Button24.ForeColor = Color.White;
      this.Button24.Location = new Point(205, 568);
      this.Button24.Name = "Button24";
      this.Button24.Size = new Size(90, 23);
      this.Button24.TabIndex = 71;
      this.Button24.Text = "Select All";
      this.Button24.UseVisualStyleBackColor = false;
      this.Button25.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.Button25.BackColor = Color.LightSlateGray;
      this.Button25.Cursor = Cursors.Hand;
      this.Button25.FlatStyle = FlatStyle.Popup;
      this.Button25.ForeColor = Color.White;
      this.Button25.Location = new Point(301, 568);
      this.Button25.Name = "Button25";
      this.Button25.Size = new Size(90, 23);
      this.Button25.TabIndex = 72;
      this.Button25.Text = "Select None";
      this.Button25.UseVisualStyleBackColor = false;
      this.Button26.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.Button26.BackColor = Color.LightSlateGray;
      this.Button26.Cursor = Cursors.Hand;
      this.Button26.FlatStyle = FlatStyle.Popup;
      this.Button26.ForeColor = Color.White;
      this.Button26.Location = new Point(205, 597);
      this.Button26.Name = "Button26";
      this.Button26.Size = new Size(186, 23);
      this.Button26.TabIndex = 70;
      this.Button26.Text = "Copy to Selected Dwellings";
      this.Button26.UseVisualStyleBackColor = false;
      this.DGRoofsI.AllowUserToAddRows = false;
      this.DGRoofsI.AllowUserToDeleteRows = false;
      this.DGRoofsI.AllowUserToResizeRows = false;
      this.DGRoofsI.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.DGRoofsI.Cursor = Cursors.Hand;
      this.DGRoofsI.Dock = DockStyle.Right;
      this.DGRoofsI.Location = new Point(559, 3);
      this.DGRoofsI.Name = "DGRoofsI";
      this.DGRoofsI.RowHeadersVisible = false;
      this.DGRoofsI.Size = new Size(330, 688);
      this.DGRoofsI.TabIndex = 69;
      this.TabPage8.Controls.Add((Control) this.GroupBox11);
      this.TabPage8.Controls.Add((Control) this.Label10);
      this.TabPage8.Controls.Add((Control) this.DGSFloorP);
      this.TabPage8.Controls.Add((Control) this.Label11);
      this.TabPage8.Controls.Add((Control) this.Button15);
      this.TabPage8.Controls.Add((Control) this.Button16);
      this.TabPage8.Controls.Add((Control) this.Button17);
      this.TabPage8.Controls.Add((Control) this.DGFloorsP);
      this.TabPage8.Location = new Point(4, 40);
      this.TabPage8.Name = "TabPage8";
      this.TabPage8.Padding = new Padding(3);
      this.TabPage8.Size = new Size(892, 694);
      this.TabPage8.TabIndex = 7;
      this.TabPage8.Text = "Party Floors";
      this.TabPage8.UseVisualStyleBackColor = true;
      this.GroupBox11.Controls.Add((Control) this.chk_PFloors_Construction);
      this.GroupBox11.Controls.Add((Control) this.chk_PFloors_Kappa);
      this.GroupBox11.Controls.Add((Control) this.chk_PFloors_Area);
      this.GroupBox11.Cursor = Cursors.Default;
      this.GroupBox11.Location = new Point(6, 181);
      this.GroupBox11.Name = "GroupBox11";
      this.GroupBox11.Size = new Size(380, 97);
      this.GroupBox11.TabIndex = 70;
      this.GroupBox11.TabStop = false;
      this.GroupBox11.Text = "Select Details";
      this.chk_PFloors_Construction.AutoSize = true;
      this.chk_PFloors_Construction.Cursor = Cursors.Hand;
      this.chk_PFloors_Construction.Location = new Point(6, 20);
      this.chk_PFloors_Construction.Name = "chk_PFloors_Construction";
      this.chk_PFloors_Construction.Size = new Size(87, 17);
      this.chk_PFloors_Construction.TabIndex = 19;
      this.chk_PFloors_Construction.Text = "Construction";
      this.chk_PFloors_Construction.UseVisualStyleBackColor = true;
      this.chk_PFloors_Kappa.AutoSize = true;
      this.chk_PFloors_Kappa.Cursor = Cursors.Hand;
      this.chk_PFloors_Kappa.Location = new Point(6, 66);
      this.chk_PFloors_Kappa.Name = "chk_PFloors_Kappa";
      this.chk_PFloors_Kappa.Size = new Size(56, 17);
      this.chk_PFloors_Kappa.TabIndex = 18;
      this.chk_PFloors_Kappa.Text = "Kappa";
      this.chk_PFloors_Kappa.UseVisualStyleBackColor = true;
      this.chk_PFloors_Area.AutoSize = true;
      this.chk_PFloors_Area.Cursor = Cursors.Hand;
      this.chk_PFloors_Area.Location = new Point(6, 43);
      this.chk_PFloors_Area.Name = "chk_PFloors_Area";
      this.chk_PFloors_Area.Size = new Size(49, 17);
      this.chk_PFloors_Area.TabIndex = 16;
      this.chk_PFloors_Area.Text = "Area";
      this.chk_PFloors_Area.UseVisualStyleBackColor = true;
      this.Label10.AutoSize = true;
      this.Label10.Font = new Font("Tahoma", 8.25f, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, (byte) 0);
      this.Label10.Location = new Point(3, 165);
      this.Label10.Name = "Label10";
      this.Label10.Size = new Size(161, 13);
      this.Label10.TabIndex = 69;
      this.Label10.Text = "Select Floor Details to Copy";
      this.DGSFloorP.AllowUserToAddRows = false;
      this.DGSFloorP.AllowUserToDeleteRows = false;
      this.DGSFloorP.AllowUserToResizeRows = false;
      this.DGSFloorP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.DGSFloorP.Cursor = Cursors.Hand;
      this.DGSFloorP.Location = new Point(6, 19);
      this.DGSFloorP.MultiSelect = false;
      this.DGSFloorP.Name = "DGSFloorP";
      this.DGSFloorP.RowHeadersVisible = false;
      this.DGSFloorP.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.DGSFloorP.Size = new Size(380, 143);
      this.DGSFloorP.TabIndex = 68;
      this.Label11.AutoSize = true;
      this.Label11.Font = new Font("Tahoma", 8.25f, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, (byte) 0);
      this.Label11.Location = new Point(3, 3);
      this.Label11.Name = "Label11";
      this.Label11.Size = new Size(119, 13);
      this.Label11.TabIndex = 67;
      this.Label11.Text = "Select Floor to Copy";
      this.Button15.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.Button15.BackColor = Color.LightSlateGray;
      this.Button15.Cursor = Cursors.Hand;
      this.Button15.FlatStyle = FlatStyle.Popup;
      this.Button15.ForeColor = Color.White;
      this.Button15.Location = new Point(205, 568);
      this.Button15.Name = "Button15";
      this.Button15.Size = new Size(90, 23);
      this.Button15.TabIndex = 65;
      this.Button15.Text = "Select All";
      this.Button15.UseVisualStyleBackColor = false;
      this.Button16.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.Button16.BackColor = Color.LightSlateGray;
      this.Button16.Cursor = Cursors.Hand;
      this.Button16.FlatStyle = FlatStyle.Popup;
      this.Button16.ForeColor = Color.White;
      this.Button16.Location = new Point(301, 568);
      this.Button16.Name = "Button16";
      this.Button16.Size = new Size(90, 23);
      this.Button16.TabIndex = 66;
      this.Button16.Text = "Select None";
      this.Button16.UseVisualStyleBackColor = false;
      this.Button17.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.Button17.BackColor = Color.LightSlateGray;
      this.Button17.Cursor = Cursors.Hand;
      this.Button17.FlatStyle = FlatStyle.Popup;
      this.Button17.ForeColor = Color.White;
      this.Button17.Location = new Point(205, 597);
      this.Button17.Name = "Button17";
      this.Button17.Size = new Size(186, 23);
      this.Button17.TabIndex = 64;
      this.Button17.Text = "Copy to Selected Dwellings";
      this.Button17.UseVisualStyleBackColor = false;
      this.DGFloorsP.AllowUserToAddRows = false;
      this.DGFloorsP.AllowUserToDeleteRows = false;
      this.DGFloorsP.AllowUserToResizeRows = false;
      this.DGFloorsP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.DGFloorsP.Cursor = Cursors.Hand;
      this.DGFloorsP.Dock = DockStyle.Right;
      this.DGFloorsP.Location = new Point(559, 3);
      this.DGFloorsP.Name = "DGFloorsP";
      this.DGFloorsP.RowHeadersVisible = false;
      this.DGFloorsP.Size = new Size(330, 688);
      this.DGFloorsP.TabIndex = 63;
      this.TabPage9.Controls.Add((Control) this.GroupBox13);
      this.TabPage9.Controls.Add((Control) this.Label14);
      this.TabPage9.Controls.Add((Control) this.DGSWallP);
      this.TabPage9.Controls.Add((Control) this.Label15);
      this.TabPage9.Controls.Add((Control) this.Button21);
      this.TabPage9.Controls.Add((Control) this.Button22);
      this.TabPage9.Controls.Add((Control) this.Button23);
      this.TabPage9.Controls.Add((Control) this.DGWallsP);
      this.TabPage9.Location = new Point(4, 40);
      this.TabPage9.Name = "TabPage9";
      this.TabPage9.Padding = new Padding(3);
      this.TabPage9.Size = new Size(892, 694);
      this.TabPage9.TabIndex = 8;
      this.TabPage9.Text = "Party Wall";
      this.TabPage9.UseVisualStyleBackColor = true;
      this.GroupBox13.Controls.Add((Control) this.chk_PWalls_Type);
      this.GroupBox13.Controls.Add((Control) this.chk_PWalls_UValue);
      this.GroupBox13.Controls.Add((Control) this.chk_PWalls_Construction);
      this.GroupBox13.Controls.Add((Control) this.chk_PWalls_Kappa);
      this.GroupBox13.Controls.Add((Control) this.chk_PWalls_Area);
      this.GroupBox13.Cursor = Cursors.Default;
      this.GroupBox13.Location = new Point(6, 181);
      this.GroupBox13.Name = "GroupBox13";
      this.GroupBox13.Size = new Size(380, 142);
      this.GroupBox13.TabIndex = 77;
      this.GroupBox13.TabStop = false;
      this.GroupBox13.Text = "Select Details";
      this.chk_PWalls_Type.AutoSize = true;
      this.chk_PWalls_Type.Cursor = Cursors.Hand;
      this.chk_PWalls_Type.Location = new Point(6, 20);
      this.chk_PWalls_Type.Name = "chk_PWalls_Type";
      this.chk_PWalls_Type.Size = new Size(50, 17);
      this.chk_PWalls_Type.TabIndex = 23;
      this.chk_PWalls_Type.Text = "Type";
      this.chk_PWalls_Type.UseVisualStyleBackColor = true;
      this.chk_PWalls_UValue.AutoSize = true;
      this.chk_PWalls_UValue.Cursor = Cursors.Hand;
      this.chk_PWalls_UValue.Location = new Point(6, 89);
      this.chk_PWalls_UValue.Name = "chk_PWalls_UValue";
      this.chk_PWalls_UValue.Size = new Size(62, 17);
      this.chk_PWalls_UValue.TabIndex = 22;
      this.chk_PWalls_UValue.Text = "U value";
      this.chk_PWalls_UValue.UseVisualStyleBackColor = true;
      this.chk_PWalls_Construction.AutoSize = true;
      this.chk_PWalls_Construction.Cursor = Cursors.Hand;
      this.chk_PWalls_Construction.Location = new Point(6, 43);
      this.chk_PWalls_Construction.Name = "chk_PWalls_Construction";
      this.chk_PWalls_Construction.Size = new Size(87, 17);
      this.chk_PWalls_Construction.TabIndex = 21;
      this.chk_PWalls_Construction.Text = "Construction";
      this.chk_PWalls_Construction.UseVisualStyleBackColor = true;
      this.chk_PWalls_Kappa.AutoSize = true;
      this.chk_PWalls_Kappa.Cursor = Cursors.Hand;
      this.chk_PWalls_Kappa.Location = new Point(6, 112);
      this.chk_PWalls_Kappa.Name = "chk_PWalls_Kappa";
      this.chk_PWalls_Kappa.Size = new Size(56, 17);
      this.chk_PWalls_Kappa.TabIndex = 20;
      this.chk_PWalls_Kappa.Text = "Kappa";
      this.chk_PWalls_Kappa.UseVisualStyleBackColor = true;
      this.chk_PWalls_Area.AutoSize = true;
      this.chk_PWalls_Area.Cursor = Cursors.Hand;
      this.chk_PWalls_Area.Location = new Point(6, 66);
      this.chk_PWalls_Area.Name = "chk_PWalls_Area";
      this.chk_PWalls_Area.Size = new Size(49, 17);
      this.chk_PWalls_Area.TabIndex = 16;
      this.chk_PWalls_Area.Text = "Area";
      this.chk_PWalls_Area.UseVisualStyleBackColor = true;
      this.Label14.AutoSize = true;
      this.Label14.Font = new Font("Tahoma", 8.25f, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, (byte) 0);
      this.Label14.Location = new Point(3, 165);
      this.Label14.Name = "Label14";
      this.Label14.Size = new Size(157, 13);
      this.Label14.TabIndex = 76;
      this.Label14.Text = "Select Wall Details to Copy";
      this.DGSWallP.AllowUserToAddRows = false;
      this.DGSWallP.AllowUserToDeleteRows = false;
      this.DGSWallP.AllowUserToResizeRows = false;
      this.DGSWallP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.DGSWallP.Cursor = Cursors.Hand;
      this.DGSWallP.Location = new Point(6, 19);
      this.DGSWallP.MultiSelect = false;
      this.DGSWallP.Name = "DGSWallP";
      this.DGSWallP.RowHeadersVisible = false;
      this.DGSWallP.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.DGSWallP.Size = new Size(380, 143);
      this.DGSWallP.TabIndex = 75;
      this.Label15.AutoSize = true;
      this.Label15.Font = new Font("Tahoma", 8.25f, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, (byte) 0);
      this.Label15.Location = new Point(3, 3);
      this.Label15.Name = "Label15";
      this.Label15.Size = new Size(115, 13);
      this.Label15.TabIndex = 74;
      this.Label15.Text = "Select Wall to Copy";
      this.Button21.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.Button21.BackColor = Color.LightSlateGray;
      this.Button21.Cursor = Cursors.Hand;
      this.Button21.FlatStyle = FlatStyle.Popup;
      this.Button21.ForeColor = Color.White;
      this.Button21.Location = new Point(205, 568);
      this.Button21.Name = "Button21";
      this.Button21.Size = new Size(90, 23);
      this.Button21.TabIndex = 72;
      this.Button21.Text = "Select All";
      this.Button21.UseVisualStyleBackColor = false;
      this.Button22.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.Button22.BackColor = Color.LightSlateGray;
      this.Button22.Cursor = Cursors.Hand;
      this.Button22.FlatStyle = FlatStyle.Popup;
      this.Button22.ForeColor = Color.White;
      this.Button22.Location = new Point(301, 568);
      this.Button22.Name = "Button22";
      this.Button22.Size = new Size(90, 23);
      this.Button22.TabIndex = 73;
      this.Button22.Text = "Select None";
      this.Button22.UseVisualStyleBackColor = false;
      this.Button23.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.Button23.BackColor = Color.LightSlateGray;
      this.Button23.Cursor = Cursors.Hand;
      this.Button23.FlatStyle = FlatStyle.Popup;
      this.Button23.ForeColor = Color.White;
      this.Button23.Location = new Point(205, 597);
      this.Button23.Name = "Button23";
      this.Button23.Size = new Size(186, 23);
      this.Button23.TabIndex = 71;
      this.Button23.Text = "Copy to Selected Dwellings";
      this.Button23.UseVisualStyleBackColor = false;
      this.DGWallsP.AllowUserToAddRows = false;
      this.DGWallsP.AllowUserToDeleteRows = false;
      this.DGWallsP.AllowUserToResizeRows = false;
      this.DGWallsP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.DGWallsP.Cursor = Cursors.Hand;
      this.DGWallsP.Dock = DockStyle.Right;
      this.DGWallsP.Location = new Point(559, 3);
      this.DGWallsP.Name = "DGWallsP";
      this.DGWallsP.RowHeadersVisible = false;
      this.DGWallsP.Size = new Size(330, 688);
      this.DGWallsP.TabIndex = 70;
      this.TabPage10.Controls.Add((Control) this.GroupBox15);
      this.TabPage10.Controls.Add((Control) this.Label18);
      this.TabPage10.Controls.Add((Control) this.DGSRoofP);
      this.TabPage10.Controls.Add((Control) this.Label19);
      this.TabPage10.Controls.Add((Control) this.Button27);
      this.TabPage10.Controls.Add((Control) this.Button28);
      this.TabPage10.Controls.Add((Control) this.Button29);
      this.TabPage10.Controls.Add((Control) this.DGRoofsP);
      this.TabPage10.Location = new Point(4, 40);
      this.TabPage10.Name = "TabPage10";
      this.TabPage10.Padding = new Padding(3);
      this.TabPage10.Size = new Size(892, 694);
      this.TabPage10.TabIndex = 9;
      this.TabPage10.Text = "Party Ceilings";
      this.TabPage10.UseVisualStyleBackColor = true;
      this.GroupBox15.Controls.Add((Control) this.chk_PRoofs_Construction);
      this.GroupBox15.Controls.Add((Control) this.chk_PRoofs_Kappa);
      this.GroupBox15.Controls.Add((Control) this.chk_PRoofs_Area);
      this.GroupBox15.Cursor = Cursors.Default;
      this.GroupBox15.Location = new Point(6, 181);
      this.GroupBox15.Name = "GroupBox15";
      this.GroupBox15.Size = new Size(380, 98);
      this.GroupBox15.TabIndex = 84;
      this.GroupBox15.TabStop = false;
      this.GroupBox15.Text = "Select Details";
      this.chk_PRoofs_Construction.AutoSize = true;
      this.chk_PRoofs_Construction.Cursor = Cursors.Hand;
      this.chk_PRoofs_Construction.Location = new Point(6, 20);
      this.chk_PRoofs_Construction.Name = "chk_PRoofs_Construction";
      this.chk_PRoofs_Construction.Size = new Size(87, 17);
      this.chk_PRoofs_Construction.TabIndex = 23;
      this.chk_PRoofs_Construction.Text = "Construction";
      this.chk_PRoofs_Construction.UseVisualStyleBackColor = true;
      this.chk_PRoofs_Kappa.AutoSize = true;
      this.chk_PRoofs_Kappa.Cursor = Cursors.Hand;
      this.chk_PRoofs_Kappa.Location = new Point(6, 66);
      this.chk_PRoofs_Kappa.Name = "chk_PRoofs_Kappa";
      this.chk_PRoofs_Kappa.Size = new Size(56, 17);
      this.chk_PRoofs_Kappa.TabIndex = 22;
      this.chk_PRoofs_Kappa.Text = "Kappa";
      this.chk_PRoofs_Kappa.UseVisualStyleBackColor = true;
      this.chk_PRoofs_Area.AutoSize = true;
      this.chk_PRoofs_Area.Cursor = Cursors.Hand;
      this.chk_PRoofs_Area.Location = new Point(6, 43);
      this.chk_PRoofs_Area.Name = "chk_PRoofs_Area";
      this.chk_PRoofs_Area.Size = new Size(49, 17);
      this.chk_PRoofs_Area.TabIndex = 16;
      this.chk_PRoofs_Area.Text = "Area";
      this.chk_PRoofs_Area.UseVisualStyleBackColor = true;
      this.Label18.AutoSize = true;
      this.Label18.Font = new Font("Tahoma", 8.25f, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, (byte) 0);
      this.Label18.Location = new Point(3, 165);
      this.Label18.Name = "Label18";
      this.Label18.Size = new Size(170, 13);
      this.Label18.TabIndex = 83;
      this.Label18.Text = "Select Ceiling Details to Copy";
      this.DGSRoofP.AllowUserToAddRows = false;
      this.DGSRoofP.AllowUserToDeleteRows = false;
      this.DGSRoofP.AllowUserToResizeRows = false;
      this.DGSRoofP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.DGSRoofP.Cursor = Cursors.Hand;
      this.DGSRoofP.Location = new Point(6, 19);
      this.DGSRoofP.MultiSelect = false;
      this.DGSRoofP.Name = "DGSRoofP";
      this.DGSRoofP.RowHeadersVisible = false;
      this.DGSRoofP.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.DGSRoofP.Size = new Size(380, 143);
      this.DGSRoofP.TabIndex = 82;
      this.Label19.AutoSize = true;
      this.Label19.Font = new Font("Tahoma", 8.25f, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, (byte) 0);
      this.Label19.Location = new Point(3, 3);
      this.Label19.Name = "Label19";
      this.Label19.Size = new Size(128, 13);
      this.Label19.TabIndex = 81;
      this.Label19.Text = "Select Ceiling to Copy";
      this.Button27.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.Button27.BackColor = Color.LightSlateGray;
      this.Button27.Cursor = Cursors.Hand;
      this.Button27.FlatStyle = FlatStyle.Popup;
      this.Button27.ForeColor = Color.White;
      this.Button27.Location = new Point(205, 568);
      this.Button27.Name = "Button27";
      this.Button27.Size = new Size(90, 23);
      this.Button27.TabIndex = 79;
      this.Button27.Text = "Select All";
      this.Button27.UseVisualStyleBackColor = false;
      this.Button28.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.Button28.BackColor = Color.LightSlateGray;
      this.Button28.Cursor = Cursors.Hand;
      this.Button28.FlatStyle = FlatStyle.Popup;
      this.Button28.ForeColor = Color.White;
      this.Button28.Location = new Point(301, 568);
      this.Button28.Name = "Button28";
      this.Button28.Size = new Size(90, 23);
      this.Button28.TabIndex = 80;
      this.Button28.Text = "Select None";
      this.Button28.UseVisualStyleBackColor = false;
      this.Button29.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.Button29.BackColor = Color.LightSlateGray;
      this.Button29.Cursor = Cursors.Hand;
      this.Button29.FlatStyle = FlatStyle.Popup;
      this.Button29.ForeColor = Color.White;
      this.Button29.Location = new Point(205, 597);
      this.Button29.Name = "Button29";
      this.Button29.Size = new Size(186, 23);
      this.Button29.TabIndex = 78;
      this.Button29.Text = "Copy to Selected Dwellings";
      this.Button29.UseVisualStyleBackColor = false;
      this.DGRoofsP.AllowUserToAddRows = false;
      this.DGRoofsP.AllowUserToDeleteRows = false;
      this.DGRoofsP.AllowUserToResizeRows = false;
      this.DGRoofsP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.DGRoofsP.Cursor = Cursors.Hand;
      this.DGRoofsP.Dock = DockStyle.Right;
      this.DGRoofsP.Location = new Point(559, 3);
      this.DGRoofsP.Name = "DGRoofsP";
      this.DGRoofsP.RowHeadersVisible = false;
      this.DGRoofsP.Size = new Size(330, 688);
      this.DGRoofsP.TabIndex = 77;
      this.TabPage11.Controls.Add((Control) this.Button34);
      this.TabPage11.Controls.Add((Control) this.Button33);
      this.TabPage11.Controls.Add((Control) this.chkD);
      this.TabPage11.Controls.Add((Control) this.cmdSelectAllHtb);
      this.TabPage11.Controls.Add((Control) this.cmdDeSelectAllHtb);
      this.TabPage11.Controls.Add((Control) this.chkSource);
      this.TabPage11.Controls.Add((Control) this.chkL);
      this.TabPage11.Controls.Add((Control) this.chkY);
      this.TabPage11.Controls.Add((Control) this.Button30);
      this.TabPage11.Controls.Add((Control) this.Button31);
      this.TabPage11.Controls.Add((Control) this.Button32);
      this.TabPage11.Controls.Add((Control) this.dtaCalc);
      this.TabPage11.Controls.Add((Control) this.DGHtbDwellings);
      this.TabPage11.Cursor = Cursors.Default;
      this.TabPage11.Location = new Point(4, 40);
      this.TabPage11.Name = "TabPage11";
      this.TabPage11.Padding = new Padding(3);
      this.TabPage11.Size = new Size(892, 694);
      this.TabPage11.TabIndex = 10;
      this.TabPage11.Text = "Htb Values";
      this.TabPage11.UseVisualStyleBackColor = true;
      this.Button34.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.Button34.BackColor = Color.LightSlateGray;
      this.Button34.Cursor = Cursors.Hand;
      this.Button34.FlatStyle = FlatStyle.Popup;
      this.Button34.ForeColor = Color.White;
      this.Button34.Location = new Point(254, 597);
      this.Button34.Name = "Button34";
      this.Button34.Size = new Size(186, 23);
      this.Button34.TabIndex = 91;
      this.Button34.Text = "Adjust Data to Selected Dwellings";
      this.Button34.UseVisualStyleBackColor = false;
      this.Button33.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.Button33.BackColor = Color.LightSlateGray;
      this.Button33.Cursor = Cursors.Hand;
      this.Button33.FlatStyle = FlatStyle.Popup;
      this.Button33.ForeColor = Color.White;
      this.Button33.Location = new Point(254, 621);
      this.Button33.Name = "Button33";
      this.Button33.Size = new Size(186, 23);
      this.Button33.TabIndex = 90;
      this.Button33.Text = "Replace to Selected Dwellings";
      this.Button33.UseVisualStyleBackColor = false;
      this.chkD.AutoSize = true;
      this.chkD.Checked = true;
      this.chkD.CheckState = CheckState.Checked;
      this.chkD.Cursor = Cursors.Hand;
      this.chkD.Location = new Point(8, 597);
      this.chkD.Name = "chkD";
      this.chkD.Size = new Size(97, 17);
      this.chkD.TabIndex = 89;
      this.chkD.Text = "Copy (Default)";
      this.chkD.UseVisualStyleBackColor = true;
      this.cmdSelectAllHtb.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.cmdSelectAllHtb.BackColor = Color.LightSlateGray;
      this.cmdSelectAllHtb.Cursor = Cursors.Hand;
      this.cmdSelectAllHtb.FlatStyle = FlatStyle.Popup;
      this.cmdSelectAllHtb.ForeColor = Color.White;
      this.cmdSelectAllHtb.Location = new Point(446, 554);
      this.cmdSelectAllHtb.Name = "cmdSelectAllHtb";
      this.cmdSelectAllHtb.Size = new Size(90, 23);
      this.cmdSelectAllHtb.TabIndex = 87;
      this.cmdSelectAllHtb.Text = "Select All";
      this.cmdSelectAllHtb.UseVisualStyleBackColor = false;
      this.cmdDeSelectAllHtb.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.cmdDeSelectAllHtb.BackColor = Color.LightSlateGray;
      this.cmdDeSelectAllHtb.Cursor = Cursors.Hand;
      this.cmdDeSelectAllHtb.FlatStyle = FlatStyle.Popup;
      this.cmdDeSelectAllHtb.ForeColor = Color.White;
      this.cmdDeSelectAllHtb.Location = new Point(542, 554);
      this.cmdDeSelectAllHtb.Name = "cmdDeSelectAllHtb";
      this.cmdDeSelectAllHtb.Size = new Size(90, 23);
      this.cmdDeSelectAllHtb.TabIndex = 88;
      this.cmdDeSelectAllHtb.Text = "Select None";
      this.cmdDeSelectAllHtb.UseVisualStyleBackColor = false;
      this.chkSource.AutoSize = true;
      this.chkSource.Checked = true;
      this.chkSource.CheckState = CheckState.Checked;
      this.chkSource.Cursor = Cursors.Hand;
      this.chkSource.Location = new Point(8, 578);
      this.chkSource.Name = "chkSource";
      this.chkSource.Size = new Size(137, 17);
      this.chkSource.TabIndex = 86;
      this.chkSource.Text = "Copy Approved Source";
      this.chkSource.UseVisualStyleBackColor = true;
      this.chkL.AutoSize = true;
      this.chkL.Checked = true;
      this.chkL.CheckState = CheckState.Checked;
      this.chkL.Cursor = Cursors.Hand;
      this.chkL.Location = new Point(78, 558);
      this.chkL.Name = "chkL";
      this.chkL.Size = new Size(67, 17);
      this.chkL.TabIndex = 85;
      this.chkL.Text = "Copy (L)";
      this.chkL.UseVisualStyleBackColor = true;
      this.chkY.AutoSize = true;
      this.chkY.Checked = true;
      this.chkY.CheckState = CheckState.Checked;
      this.chkY.Cursor = Cursors.Hand;
      this.chkY.Location = new Point(8, 558);
      this.chkY.Name = "chkY";
      this.chkY.Size = new Size(70, 17);
      this.chkY.TabIndex = 84;
      this.chkY.Text = "Copy (Ψ)";
      this.chkY.UseVisualStyleBackColor = true;
      this.Button30.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.Button30.BackColor = Color.LightSlateGray;
      this.Button30.Cursor = Cursors.Hand;
      this.Button30.FlatStyle = FlatStyle.Popup;
      this.Button30.ForeColor = Color.White;
      this.Button30.Location = new Point(446, 597);
      this.Button30.Name = "Button30";
      this.Button30.Size = new Size(90, 23);
      this.Button30.TabIndex = 82;
      this.Button30.Text = "Select All";
      this.Button30.UseVisualStyleBackColor = false;
      this.Button31.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.Button31.BackColor = Color.LightSlateGray;
      this.Button31.Cursor = Cursors.Hand;
      this.Button31.FlatStyle = FlatStyle.Popup;
      this.Button31.ForeColor = Color.White;
      this.Button31.Location = new Point(542, 597);
      this.Button31.Name = "Button31";
      this.Button31.Size = new Size(90, 23);
      this.Button31.TabIndex = 83;
      this.Button31.Text = "Select None";
      this.Button31.UseVisualStyleBackColor = false;
      this.Button32.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.Button32.BackColor = Color.LightSlateGray;
      this.Button32.Cursor = Cursors.Hand;
      this.Button32.FlatStyle = FlatStyle.Popup;
      this.Button32.ForeColor = Color.White;
      this.Button32.Location = new Point(446, 621);
      this.Button32.Name = "Button32";
      this.Button32.Size = new Size(186, 23);
      this.Button32.TabIndex = 81;
      this.Button32.Text = "Add to Selected Dwellings";
      this.Button32.UseVisualStyleBackColor = false;
      this.dtaCalc.AllowUserToAddRows = false;
      this.dtaCalc.AllowUserToDeleteRows = false;
      this.dtaCalc.AllowUserToResizeColumns = false;
      this.dtaCalc.AllowUserToResizeRows = false;
      gridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
      gridViewCellStyle1.BackColor = SystemColors.Control;
      gridViewCellStyle1.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      gridViewCellStyle1.ForeColor = SystemColors.WindowText;
      gridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
      gridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
      gridViewCellStyle1.WrapMode = DataGridViewTriState.True;
      this.dtaCalc.ColumnHeadersDefaultCellStyle = gridViewCellStyle1;
      this.dtaCalc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dtaCalc.Columns.AddRange((DataGridViewColumn) this.JunctionType, (DataGridViewColumn) this.LTTUsed, (DataGridViewColumn) this.LJT, (DataGridViewColumn) this.ApprovedSource, (DataGridViewColumn) this.Def, (DataGridViewColumn) this.SelectCheck, (DataGridViewColumn) this.ID);
      this.dtaCalc.Cursor = Cursors.Hand;
      this.dtaCalc.EditMode = DataGridViewEditMode.EditOnEnter;
      this.dtaCalc.GridColor = Color.Silver;
      this.dtaCalc.Location = new Point(6, 3);
      this.dtaCalc.MultiSelect = false;
      this.dtaCalc.Name = "dtaCalc";
      this.dtaCalc.RowHeadersVisible = false;
      this.dtaCalc.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
      this.dtaCalc.SelectionMode = DataGridViewSelectionMode.CellSelect;
      this.dtaCalc.Size = new Size(640, 545);
      this.dtaCalc.TabIndex = 79;
      gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
      gridViewCellStyle2.BackColor = Color.Gray;
      gridViewCellStyle2.ForeColor = Color.White;
      gridViewCellStyle2.SelectionBackColor = Color.Gray;
      this.JunctionType.DefaultCellStyle = gridViewCellStyle2;
      this.JunctionType.HeaderText = "Junction Type";
      this.JunctionType.Name = "JunctionType";
      this.JunctionType.ReadOnly = true;
      this.JunctionType.SortMode = DataGridViewColumnSortMode.NotSortable;
      this.JunctionType.Width = 250;
      gridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.LTTUsed.DefaultCellStyle = gridViewCellStyle3;
      this.LTTUsed.HeaderText = "(Ψ)";
      this.LTTUsed.Name = "LTTUsed";
      this.LTTUsed.ReadOnly = true;
      this.LTTUsed.SortMode = DataGridViewColumnSortMode.NotSortable;
      this.LTTUsed.Width = 50;
      gridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.LJT.DefaultCellStyle = gridViewCellStyle4;
      this.LJT.HeaderText = "(L)";
      this.LJT.Name = "LJT";
      this.LJT.ReadOnly = true;
      this.LJT.SortMode = DataGridViewColumnSortMode.NotSortable;
      this.LJT.Width = 50;
      gridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
      gridViewCellStyle5.NullValue = (object) false;
      gridViewCellStyle5.WrapMode = DataGridViewTriState.True;
      this.ApprovedSource.DefaultCellStyle = gridViewCellStyle5;
      this.ApprovedSource.HeaderText = "Approved Source";
      this.ApprovedSource.Name = "ApprovedSource";
      this.ApprovedSource.ReadOnly = true;
      this.ApprovedSource.Width = 60;
      this.Def.HeaderText = "Default Value";
      this.Def.Name = "Def";
      this.SelectCheck.HeaderText = "Select";
      this.SelectCheck.Name = "SelectCheck";
      this.SelectCheck.Width = 50;
      this.ID.HeaderText = "ID";
      this.ID.Name = "ID";
      this.DGHtbDwellings.AllowUserToAddRows = false;
      this.DGHtbDwellings.AllowUserToDeleteRows = false;
      this.DGHtbDwellings.AllowUserToResizeRows = false;
      this.DGHtbDwellings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.DGHtbDwellings.Cursor = Cursors.Hand;
      this.DGHtbDwellings.Dock = DockStyle.Right;
      this.DGHtbDwellings.Location = new Point(651, 3);
      this.DGHtbDwellings.Name = "DGHtbDwellings";
      this.DGHtbDwellings.RowHeadersVisible = false;
      this.DGHtbDwellings.Size = new Size(238, 688);
      this.DGHtbDwellings.TabIndex = 78;
      this.TabPage12.Controls.Add((Control) this.GroupBox20);
      this.TabPage12.Controls.Add((Control) this.Label20);
      this.TabPage12.Controls.Add((Control) this.DGSCooling);
      this.TabPage12.Controls.Add((Control) this.Label21);
      this.TabPage12.Controls.Add((Control) this.Button35);
      this.TabPage12.Controls.Add((Control) this.Button36);
      this.TabPage12.Controls.Add((Control) this.Button37);
      this.TabPage12.Controls.Add((Control) this.DGCooling);
      this.TabPage12.Location = new Point(4, 40);
      this.TabPage12.Name = "TabPage12";
      this.TabPage12.Padding = new Padding(3);
      this.TabPage12.Size = new Size(892, 694);
      this.TabPage12.TabIndex = 11;
      this.TabPage12.Text = "Cooling";
      this.TabPage12.UseVisualStyleBackColor = true;
      this.GroupBox20.Controls.Add((Control) this.ChkCoolingArea);
      this.GroupBox20.Controls.Add((Control) this.ChkCompressorcontrol);
      this.GroupBox20.Controls.Add((Control) this.Chk_CoolingsystType);
      this.GroupBox20.Controls.Add((Control) this.ChkCoolingEER);
      this.GroupBox20.Controls.Add((Control) this.ChkCoolingEnergyLabel);
      this.GroupBox20.Cursor = Cursors.Default;
      this.GroupBox20.Location = new Point(6, 181);
      this.GroupBox20.Name = "GroupBox20";
      this.GroupBox20.Size = new Size(380, 137);
      this.GroupBox20.TabIndex = 78;
      this.GroupBox20.TabStop = false;
      this.GroupBox20.Text = "Select Details";
      this.ChkCoolingArea.AutoSize = true;
      this.ChkCoolingArea.Cursor = Cursors.Hand;
      this.ChkCoolingArea.Location = new Point(6, 112);
      this.ChkCoolingArea.Name = "ChkCoolingArea";
      this.ChkCoolingArea.Size = new Size(85, 17);
      this.ChkCoolingArea.TabIndex = 22;
      this.ChkCoolingArea.Text = "Cooled Area";
      this.ChkCoolingArea.UseVisualStyleBackColor = true;
      this.ChkCompressorcontrol.AutoSize = true;
      this.ChkCompressorcontrol.Cursor = Cursors.Hand;
      this.ChkCompressorcontrol.Location = new Point(6, 89);
      this.ChkCompressorcontrol.Name = "ChkCompressorcontrol";
      this.ChkCompressorcontrol.Size = new Size(119, 17);
      this.ChkCompressorcontrol.TabIndex = 20;
      this.ChkCompressorcontrol.Text = "Compressor control";
      this.ChkCompressorcontrol.UseVisualStyleBackColor = true;
      this.Chk_CoolingsystType.AutoSize = true;
      this.Chk_CoolingsystType.Cursor = Cursors.Hand;
      this.Chk_CoolingsystType.Location = new Point(6, 20);
      this.Chk_CoolingsystType.Name = "Chk_CoolingsystType";
      this.Chk_CoolingsystType.Size = new Size(88, 17);
      this.Chk_CoolingsystType.TabIndex = 19;
      this.Chk_CoolingsystType.Text = "System Type";
      this.Chk_CoolingsystType.UseVisualStyleBackColor = true;
      this.ChkCoolingEER.AutoSize = true;
      this.ChkCoolingEER.Cursor = Cursors.Hand;
      this.ChkCoolingEER.Location = new Point(6, 66);
      this.ChkCoolingEER.Name = "ChkCoolingEER";
      this.ChkCoolingEER.Size = new Size(45, 17);
      this.ChkCoolingEER.TabIndex = 18;
      this.ChkCoolingEER.Text = "EER";
      this.ChkCoolingEER.UseVisualStyleBackColor = true;
      this.ChkCoolingEnergyLabel.AutoSize = true;
      this.ChkCoolingEnergyLabel.Cursor = Cursors.Hand;
      this.ChkCoolingEnergyLabel.Location = new Point(6, 43);
      this.ChkCoolingEnergyLabel.Name = "ChkCoolingEnergyLabel";
      this.ChkCoolingEnergyLabel.Size = new Size(85, 17);
      this.ChkCoolingEnergyLabel.TabIndex = 16;
      this.ChkCoolingEnergyLabel.Text = "Energy label";
      this.ChkCoolingEnergyLabel.UseVisualStyleBackColor = true;
      this.Label20.AutoSize = true;
      this.Label20.Font = new Font("Tahoma", 8.25f, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, (byte) 0);
      this.Label20.Location = new Point(3, 165);
      this.Label20.Name = "Label20";
      this.Label20.Size = new Size(173, 13);
      this.Label20.TabIndex = 77;
      this.Label20.Text = "Select cooling Details to Copy";
      this.DGSCooling.AllowUserToAddRows = false;
      this.DGSCooling.AllowUserToDeleteRows = false;
      this.DGSCooling.AllowUserToResizeRows = false;
      this.DGSCooling.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.DGSCooling.Cursor = Cursors.Hand;
      this.DGSCooling.Location = new Point(6, 19);
      this.DGSCooling.MultiSelect = false;
      this.DGSCooling.Name = "DGSCooling";
      this.DGSCooling.RowHeadersVisible = false;
      this.DGSCooling.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.DGSCooling.Size = new Size(380, 143);
      this.DGSCooling.TabIndex = 76;
      this.Label21.AutoSize = true;
      this.Label21.Font = new Font("Tahoma", 8.25f, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, (byte) 0);
      this.Label21.Location = new Point(3, 3);
      this.Label21.Name = "Label21";
      this.Label21.Size = new Size(176, 13);
      this.Label21.TabIndex = 75;
      this.Label21.Text = "Select cooling system to Copy";
      this.Button35.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.Button35.BackColor = Color.LightSlateGray;
      this.Button35.Cursor = Cursors.Hand;
      this.Button35.FlatStyle = FlatStyle.Popup;
      this.Button35.ForeColor = Color.White;
      this.Button35.Location = new Point(205, 568);
      this.Button35.Name = "Button35";
      this.Button35.Size = new Size(90, 23);
      this.Button35.TabIndex = 73;
      this.Button35.Text = "Select All";
      this.Button35.UseVisualStyleBackColor = false;
      this.Button36.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.Button36.BackColor = Color.LightSlateGray;
      this.Button36.Cursor = Cursors.Hand;
      this.Button36.FlatStyle = FlatStyle.Popup;
      this.Button36.ForeColor = Color.White;
      this.Button36.Location = new Point(301, 568);
      this.Button36.Name = "Button36";
      this.Button36.Size = new Size(90, 23);
      this.Button36.TabIndex = 74;
      this.Button36.Text = "Select None";
      this.Button36.UseVisualStyleBackColor = false;
      this.Button37.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.Button37.BackColor = Color.LightSlateGray;
      this.Button37.Cursor = Cursors.Hand;
      this.Button37.FlatStyle = FlatStyle.Popup;
      this.Button37.ForeColor = Color.White;
      this.Button37.Location = new Point(205, 597);
      this.Button37.Name = "Button37";
      this.Button37.Size = new Size(186, 23);
      this.Button37.TabIndex = 72;
      this.Button37.Text = "Copy to Selected Dwellings";
      this.Button37.UseVisualStyleBackColor = false;
      this.DGCooling.AllowUserToAddRows = false;
      this.DGCooling.AllowUserToDeleteRows = false;
      this.DGCooling.AllowUserToResizeRows = false;
      this.DGCooling.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.DGCooling.Cursor = Cursors.Hand;
      this.DGCooling.Dock = DockStyle.Right;
      this.DGCooling.Location = new Point(559, 3);
      this.DGCooling.Name = "DGCooling";
      this.DGCooling.RowHeadersVisible = false;
      this.DGCooling.Size = new Size(330, 688);
      this.DGCooling.TabIndex = 71;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(900, 738);
      this.Controls.Add((Control) this.TabControl1);
      this.Controls.Add((Control) this.Button1);
      this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.Name = nameof (Copy_Element);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "FSAP Elemental Copy Function";
      ((ISupportInitialize) this.DG1).EndInit();
      this.GroupBox7.ResumeLayout(false);
      this.GroupBox7.PerformLayout();
      this.pnlRWindow.ResumeLayout(false);
      this.pnlRWindow.PerformLayout();
      this.GroupBox24.ResumeLayout(false);
      this.GroupBox24.PerformLayout();
      this.GroupBox23.ResumeLayout(false);
      this.GroupBox23.PerformLayout();
      this.ChkDe.ResumeLayout(false);
      this.ChkDe.PerformLayout();
      this.chkBuild.ResumeLayout(false);
      this.chkBuild.PerformLayout();
      this.GroupBox21.ResumeLayout(false);
      this.GroupBox21.PerformLayout();
      this.GroupBox19.ResumeLayout(false);
      this.GroupBox19.PerformLayout();
      this.GroupBox18.ResumeLayout(false);
      this.GroupBox18.PerformLayout();
      this.GroupBox17.ResumeLayout(false);
      this.GroupBox17.PerformLayout();
      this.GroupBox16.ResumeLayout(false);
      this.GroupBox16.PerformLayout();
      this.GroupBox5.ResumeLayout(false);
      this.GroupBox5.PerformLayout();
      this.GroupBox4.ResumeLayout(false);
      this.GroupBox4.PerformLayout();
      this.GroupBox3.ResumeLayout(false);
      this.GroupBox3.PerformLayout();
      this.GroupBox2.ResumeLayout(false);
      this.GroupBox2.PerformLayout();
      this.GroupBox22.ResumeLayout(false);
      this.GroupBox22.PerformLayout();
      this.GroupBox1.ResumeLayout(false);
      this.GroupBox1.PerformLayout();
      this.TabControl1.ResumeLayout(false);
      this.TabPage1.ResumeLayout(false);
      this.TabPage2.ResumeLayout(false);
      this.TabPage2.PerformLayout();
      this.GroupBox6.ResumeLayout(false);
      this.GroupBox6.PerformLayout();
      ((ISupportInitialize) this.DGSFloor).EndInit();
      ((ISupportInitialize) this.DGFloors).EndInit();
      this.TabPage3.ResumeLayout(false);
      this.TabPage3.PerformLayout();
      this.GroupBox8.ResumeLayout(false);
      this.GroupBox8.PerformLayout();
      ((ISupportInitialize) this.DGSWall).EndInit();
      ((ISupportInitialize) this.DGWalls).EndInit();
      this.TabPage4.ResumeLayout(false);
      this.TabPage4.PerformLayout();
      this.GroupBox9.ResumeLayout(false);
      this.GroupBox9.PerformLayout();
      ((ISupportInitialize) this.DGSRoof).EndInit();
      ((ISupportInitialize) this.DGRoofs).EndInit();
      this.TabPage5.ResumeLayout(false);
      this.TabPage5.PerformLayout();
      this.GroupBox10.ResumeLayout(false);
      this.GroupBox10.PerformLayout();
      ((ISupportInitialize) this.DGSFloorI).EndInit();
      ((ISupportInitialize) this.DGFloorsI).EndInit();
      this.TabPage6.ResumeLayout(false);
      this.TabPage6.PerformLayout();
      this.GroupBox12.ResumeLayout(false);
      this.GroupBox12.PerformLayout();
      ((ISupportInitialize) this.DGSWallI).EndInit();
      ((ISupportInitialize) this.DGWallsI).EndInit();
      this.TabPage7.ResumeLayout(false);
      this.TabPage7.PerformLayout();
      this.GroupBox14.ResumeLayout(false);
      this.GroupBox14.PerformLayout();
      ((ISupportInitialize) this.DGSRoofI).EndInit();
      ((ISupportInitialize) this.DGRoofsI).EndInit();
      this.TabPage8.ResumeLayout(false);
      this.TabPage8.PerformLayout();
      this.GroupBox11.ResumeLayout(false);
      this.GroupBox11.PerformLayout();
      ((ISupportInitialize) this.DGSFloorP).EndInit();
      ((ISupportInitialize) this.DGFloorsP).EndInit();
      this.TabPage9.ResumeLayout(false);
      this.TabPage9.PerformLayout();
      this.GroupBox13.ResumeLayout(false);
      this.GroupBox13.PerformLayout();
      ((ISupportInitialize) this.DGSWallP).EndInit();
      ((ISupportInitialize) this.DGWallsP).EndInit();
      this.TabPage10.ResumeLayout(false);
      this.TabPage10.PerformLayout();
      this.GroupBox15.ResumeLayout(false);
      this.GroupBox15.PerformLayout();
      ((ISupportInitialize) this.DGSRoofP).EndInit();
      ((ISupportInitialize) this.DGRoofsP).EndInit();
      this.TabPage11.ResumeLayout(false);
      this.TabPage11.PerformLayout();
      ((ISupportInitialize) this.dtaCalc).EndInit();
      ((ISupportInitialize) this.DGHtbDwellings).EndInit();
      this.TabPage12.ResumeLayout(false);
      this.TabPage12.PerformLayout();
      this.GroupBox20.ResumeLayout(false);
      this.GroupBox20.PerformLayout();
      ((ISupportInitialize) this.DGSCooling).EndInit();
      ((ISupportInitialize) this.DGCooling).EndInit();
      this.ResumeLayout(false);
    }

    [field: AccessedThroughProperty("DG1")]
    internal virtual DataGridView DG1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox7")]
    internal virtual GroupBox GroupBox7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_Renew_Wind")]
    internal virtual CheckBox chk_Renew_Wind { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_Renew_Photo")]
    internal virtual CheckBox chk_Renew_Photo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_Renew_AAEG")]
    internal virtual CheckBox chk_Renew_AAEG { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_Renew_AppQ")]
    internal virtual CheckBox chk_Renew_AppQ { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

    [field: AccessedThroughProperty("Button1")]
    internal virtual Button Button1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("pnlRWindow")]
    internal virtual Panel pnlRWindow { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

    [field: AccessedThroughProperty("TabControl1")]
    internal virtual TabControl TabControl1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("TabPage1")]
    internal virtual TabPage TabPage1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("TabPage2")]
    internal virtual TabPage TabPage2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("TabPage3")]
    internal virtual TabPage TabPage3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("TabPage4")]
    internal virtual TabPage TabPage4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox4")]
    internal virtual GroupBox GroupBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_Vent_OpenFlues")]
    internal virtual CheckBox chk_Vent_OpenFlues { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_Vent_Chimneys")]
    internal virtual CheckBox chk_Vent_Chimneys { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_Vent_PassiveVents")]
    internal virtual CheckBox chk_Vent_PassiveVents { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_Vent_Fans")]
    internal virtual CheckBox chk_Vent_Fans { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox3")]
    internal virtual GroupBox GroupBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox chk_Water_SolarPanel
    {
      get => this._chk_Water_SolarPanel;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chk_Water_SolarPanel_CheckedChanged);
        CheckBox chkWaterSolarPanel1 = this._chk_Water_SolarPanel;
        if (chkWaterSolarPanel1 != null)
          chkWaterSolarPanel1.CheckedChanged -= eventHandler;
        this._chk_Water_SolarPanel = value;
        CheckBox chkWaterSolarPanel2 = this._chk_Water_SolarPanel;
        if (chkWaterSolarPanel2 == null)
          return;
        chkWaterSolarPanel2.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox chk_Water_Heating
    {
      get => this._chk_Water_Heating;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chk_Water_Heating_CheckedChanged);
        CheckBox chkWaterHeating1 = this._chk_Water_Heating;
        if (chkWaterHeating1 != null)
          chkWaterHeating1.CheckedChanged -= eventHandler;
        this._chk_Water_Heating = value;
        CheckBox chkWaterHeating2 = this._chk_Water_Heating;
        if (chkWaterHeating2 == null)
          return;
        chkWaterHeating2.CheckedChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("GroupBox2")]
    internal virtual GroupBox GroupBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_Other_LEL")]
    internal virtual CheckBox chk_Other_LEL { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_Other_FixedAir")]
    internal virtual CheckBox chk_Other_FixedAir { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_Other_Conserv")]
    internal virtual CheckBox chk_Other_Conserv { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox1")]
    internal virtual GroupBox GroupBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_Vent_ThermalMass")]
    internal virtual CheckBox chk_Vent_ThermalMass { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_OverH_AirChangeRate")]
    internal virtual CheckBox chk_OverH_AirChangeRate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox5")]
    internal virtual GroupBox GroupBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_Heating_Secondary")]
    internal virtual CheckBox chk_Heating_Secondary { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_Heating_Tarrif")]
    internal virtual CheckBox chk_Heating_Tarrif { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox chk_Heating_Fuel
    {
      get => this._chk_Heating_Fuel;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chk_Heating_Fuel_CheckedChanged);
        CheckBox chkHeatingFuel1 = this._chk_Heating_Fuel;
        if (chkHeatingFuel1 != null)
          chkHeatingFuel1.CheckedChanged -= eventHandler;
        this._chk_Heating_Fuel = value;
        CheckBox chkHeatingFuel2 = this._chk_Heating_Fuel;
        if (chkHeatingFuel2 == null)
          return;
        chkHeatingFuel2.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox chk_Heating_Controls
    {
      get => this._chk_Heating_Controls;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chk_Heating_Controls_CheckedChanged);
        CheckBox chkHeatingControls1 = this._chk_Heating_Controls;
        if (chkHeatingControls1 != null)
          chkHeatingControls1.CheckedChanged -= eventHandler;
        this._chk_Heating_Controls = value;
        CheckBox chkHeatingControls2 = this._chk_Heating_Controls;
        if (chkHeatingControls2 == null)
          return;
        chkHeatingControls2.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox chk_Heating_Full
    {
      get => this._chk_Heating_Full;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chk_Heating_Full_CheckedChanged);
        CheckBox chkHeatingFull1 = this._chk_Heating_Full;
        if (chkHeatingFull1 != null)
          chkHeatingFull1.CheckedChanged -= eventHandler;
        this._chk_Heating_Full = value;
        CheckBox chkHeatingFull2 = this._chk_Heating_Full;
        if (chkHeatingFull2 == null)
          return;
        chkHeatingFull2.CheckedChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("chk_Vent_AirPerm")]
    internal virtual CheckBox chk_Vent_AirPerm { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_Vent_Mechanical")]
    internal virtual CheckBox chk_Vent_Mechanical { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_Vent_ShelteredSides")]
    internal virtual CheckBox chk_Vent_ShelteredSides { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_Vent_GasFires")]
    internal virtual CheckBox chk_Vent_GasFires { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DGFloors")]
    internal virtual DataGridView DGFloors { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DGWalls")]
    internal virtual DataGridView DGWalls { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DGRoofs")]
    internal virtual DataGridView DGRoofs { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label1")]
    internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button2
    {
      get => this._Button2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button2_Click);
        Button button2_1 = this._Button2;
        if (button2_1 != null)
          button2_1.Click -= eventHandler;
        this._Button2 = value;
        Button button2_2 = this._Button2;
        if (button2_2 == null)
          return;
        button2_2.Click += eventHandler;
      }
    }

    internal virtual Button Button3
    {
      get => this._Button3;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button3_Click);
        Button button3_1 = this._Button3;
        if (button3_1 != null)
          button3_1.Click -= eventHandler;
        this._Button3 = value;
        Button button3_2 = this._Button3;
        if (button3_2 == null)
          return;
        button3_2.Click += eventHandler;
      }
    }

    internal virtual Button Button4
    {
      get => this._Button4;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button4_Click);
        Button button4_1 = this._Button4;
        if (button4_1 != null)
          button4_1.Click -= eventHandler;
        this._Button4 = value;
        Button button4_2 = this._Button4;
        if (button4_2 == null)
          return;
        button4_2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("GroupBox6")]
    internal virtual GroupBox GroupBox6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_Floors_U")]
    internal virtual CheckBox chk_Floors_U { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_Floors_Area")]
    internal virtual CheckBox chk_Floors_Area { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_Floors_Type")]
    internal virtual CheckBox chk_Floors_Type { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label3")]
    internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DGSFloor")]
    internal virtual DataGridView DGSFloor { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox8")]
    internal virtual GroupBox GroupBox8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_Walls_Curtain")]
    internal virtual CheckBox chk_Walls_Curtain { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_Walls_Ru")]
    internal virtual CheckBox chk_Walls_Ru { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_Walls_UValue")]
    internal virtual CheckBox chk_Walls_UValue { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_Walls_Area")]
    internal virtual CheckBox chk_Walls_Area { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_Walls_Type")]
    internal virtual CheckBox chk_Walls_Type { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label4")]
    internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DGSWall")]
    internal virtual DataGridView DGSWall { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label5")]
    internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button5
    {
      get => this._Button5;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button5_Click);
        Button button5_1 = this._Button5;
        if (button5_1 != null)
          button5_1.Click -= eventHandler;
        this._Button5 = value;
        Button button5_2 = this._Button5;
        if (button5_2 == null)
          return;
        button5_2.Click += eventHandler;
      }
    }

    internal virtual Button Button6
    {
      get => this._Button6;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button6_Click);
        Button button6_1 = this._Button6;
        if (button6_1 != null)
          button6_1.Click -= eventHandler;
        this._Button6 = value;
        Button button6_2 = this._Button6;
        if (button6_2 == null)
          return;
        button6_2.Click += eventHandler;
      }
    }

    internal virtual Button Button7
    {
      get => this._Button7;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button7_Click);
        Button button7_1 = this._Button7;
        if (button7_1 != null)
          button7_1.Click -= eventHandler;
        this._Button7 = value;
        Button button7_2 = this._Button7;
        if (button7_2 == null)
          return;
        button7_2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("GroupBox9")]
    internal virtual GroupBox GroupBox9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_Roofs_Ru")]
    internal virtual CheckBox chk_Roofs_Ru { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_Roofs_UValue")]
    internal virtual CheckBox chk_Roofs_UValue { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_Roofs_Area")]
    internal virtual CheckBox chk_Roofs_Area { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_Roofs_Type")]
    internal virtual CheckBox chk_Roofs_Type { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label6")]
    internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DGSRoof")]
    internal virtual DataGridView DGSRoof { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label7")]
    internal virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button8
    {
      get => this._Button8;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button8_Click);
        Button button8_1 = this._Button8;
        if (button8_1 != null)
          button8_1.Click -= eventHandler;
        this._Button8 = value;
        Button button8_2 = this._Button8;
        if (button8_2 == null)
          return;
        button8_2.Click += eventHandler;
      }
    }

    internal virtual Button Button9
    {
      get => this._Button9;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button9_Click);
        Button button9_1 = this._Button9;
        if (button9_1 != null)
          button9_1.Click -= eventHandler;
        this._Button9 = value;
        Button button9_2 = this._Button9;
        if (button9_2 == null)
          return;
        button9_2.Click += eventHandler;
      }
    }

    internal virtual Button Button10
    {
      get => this._Button10;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button10_Click);
        Button button10_1 = this._Button10;
        if (button10_1 != null)
          button10_1.Click -= eventHandler;
        this._Button10 = value;
        Button button10_2 = this._Button10;
        if (button10_2 == null)
          return;
        button10_2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Button11")]
    internal virtual Button Button11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("TabPage5")]
    internal virtual TabPage TabPage5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("TabPage6")]
    internal virtual TabPage TabPage6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("TabPage7")]
    internal virtual TabPage TabPage7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("TabPage8")]
    internal virtual TabPage TabPage8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("TabPage9")]
    internal virtual TabPage TabPage9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("TabPage10")]
    internal virtual TabPage TabPage10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_Floors_Construction")]
    internal virtual CheckBox chk_Floors_Construction { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_Floors_Kappa")]
    internal virtual CheckBox chk_Floors_Kappa { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_Walls_Construction")]
    internal virtual CheckBox chk_Walls_Construction { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_Walls_Kappa")]
    internal virtual CheckBox chk_Walls_Kappa { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_Roofs_Construction")]
    internal virtual CheckBox chk_Roofs_Construction { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_Roofs_Kappa")]
    internal virtual CheckBox chk_Roofs_Kappa { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox10")]
    internal virtual GroupBox GroupBox10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_IFloors_Construction")]
    internal virtual CheckBox chk_IFloors_Construction { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_IFloors_Kappa")]
    internal virtual CheckBox chk_IFloors_Kappa { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_IFloors_Area")]
    internal virtual CheckBox chk_IFloors_Area { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label8")]
    internal virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DGSFloorI")]
    internal virtual DataGridView DGSFloorI { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label9")]
    internal virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button12
    {
      get => this._Button12;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button12_Click);
        Button button12_1 = this._Button12;
        if (button12_1 != null)
          button12_1.Click -= eventHandler;
        this._Button12 = value;
        Button button12_2 = this._Button12;
        if (button12_2 == null)
          return;
        button12_2.Click += eventHandler;
      }
    }

    internal virtual Button Button13
    {
      get => this._Button13;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button13_Click);
        Button button13_1 = this._Button13;
        if (button13_1 != null)
          button13_1.Click -= eventHandler;
        this._Button13 = value;
        Button button13_2 = this._Button13;
        if (button13_2 == null)
          return;
        button13_2.Click += eventHandler;
      }
    }

    internal virtual Button Button14
    {
      get => this._Button14;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button14_Click);
        Button button14_1 = this._Button14;
        if (button14_1 != null)
          button14_1.Click -= eventHandler;
        this._Button14 = value;
        Button button14_2 = this._Button14;
        if (button14_2 == null)
          return;
        button14_2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("DGFloorsI")]
    internal virtual DataGridView DGFloorsI { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox11")]
    internal virtual GroupBox GroupBox11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_PFloors_Construction")]
    internal virtual CheckBox chk_PFloors_Construction { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_PFloors_Kappa")]
    internal virtual CheckBox chk_PFloors_Kappa { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_PFloors_Area")]
    internal virtual CheckBox chk_PFloors_Area { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label10")]
    internal virtual Label Label10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DGSFloorP")]
    internal virtual DataGridView DGSFloorP { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label11")]
    internal virtual Label Label11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button15
    {
      get => this._Button15;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button15_Click);
        Button button15_1 = this._Button15;
        if (button15_1 != null)
          button15_1.Click -= eventHandler;
        this._Button15 = value;
        Button button15_2 = this._Button15;
        if (button15_2 == null)
          return;
        button15_2.Click += eventHandler;
      }
    }

    internal virtual Button Button16
    {
      get => this._Button16;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button16_Click);
        Button button16_1 = this._Button16;
        if (button16_1 != null)
          button16_1.Click -= eventHandler;
        this._Button16 = value;
        Button button16_2 = this._Button16;
        if (button16_2 == null)
          return;
        button16_2.Click += eventHandler;
      }
    }

    internal virtual Button Button17
    {
      get => this._Button17;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button17_Click);
        Button button17_1 = this._Button17;
        if (button17_1 != null)
          button17_1.Click -= eventHandler;
        this._Button17 = value;
        Button button17_2 = this._Button17;
        if (button17_2 == null)
          return;
        button17_2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("DGFloorsP")]
    internal virtual DataGridView DGFloorsP { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox12")]
    internal virtual GroupBox GroupBox12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_IWalls_Construction")]
    internal virtual CheckBox chk_IWalls_Construction { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_IWalls_Kappa")]
    internal virtual CheckBox chk_IWalls_Kappa { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_IWalls_Area")]
    internal virtual CheckBox chk_IWalls_Area { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label12")]
    internal virtual Label Label12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DGSWallI")]
    internal virtual DataGridView DGSWallI { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label13")]
    internal virtual Label Label13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button18
    {
      get => this._Button18;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button18_Click);
        Button button18_1 = this._Button18;
        if (button18_1 != null)
          button18_1.Click -= eventHandler;
        this._Button18 = value;
        Button button18_2 = this._Button18;
        if (button18_2 == null)
          return;
        button18_2.Click += eventHandler;
      }
    }

    internal virtual Button Button19
    {
      get => this._Button19;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button19_Click);
        Button button19_1 = this._Button19;
        if (button19_1 != null)
          button19_1.Click -= eventHandler;
        this._Button19 = value;
        Button button19_2 = this._Button19;
        if (button19_2 == null)
          return;
        button19_2.Click += eventHandler;
      }
    }

    internal virtual Button Button20
    {
      get => this._Button20;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button20_Click);
        Button button20_1 = this._Button20;
        if (button20_1 != null)
          button20_1.Click -= eventHandler;
        this._Button20 = value;
        Button button20_2 = this._Button20;
        if (button20_2 == null)
          return;
        button20_2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("DGWallsI")]
    internal virtual DataGridView DGWallsI { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox14")]
    internal virtual GroupBox GroupBox14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_IRoofs_Construction")]
    internal virtual CheckBox chk_IRoofs_Construction { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_IRoofs_Kappa")]
    internal virtual CheckBox chk_IRoofs_Kappa { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_IRoofs_Area")]
    internal virtual CheckBox chk_IRoofs_Area { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label16")]
    internal virtual Label Label16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DGSRoofI")]
    internal virtual DataGridView DGSRoofI { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label17")]
    internal virtual Label Label17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button24
    {
      get => this._Button24;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button24_Click);
        Button button24_1 = this._Button24;
        if (button24_1 != null)
          button24_1.Click -= eventHandler;
        this._Button24 = value;
        Button button24_2 = this._Button24;
        if (button24_2 == null)
          return;
        button24_2.Click += eventHandler;
      }
    }

    internal virtual Button Button25
    {
      get => this._Button25;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button25_Click);
        Button button25_1 = this._Button25;
        if (button25_1 != null)
          button25_1.Click -= eventHandler;
        this._Button25 = value;
        Button button25_2 = this._Button25;
        if (button25_2 == null)
          return;
        button25_2.Click += eventHandler;
      }
    }

    internal virtual Button Button26
    {
      get => this._Button26;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button26_Click);
        Button button26_1 = this._Button26;
        if (button26_1 != null)
          button26_1.Click -= eventHandler;
        this._Button26 = value;
        Button button26_2 = this._Button26;
        if (button26_2 == null)
          return;
        button26_2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("DGRoofsI")]
    internal virtual DataGridView DGRoofsI { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox13")]
    internal virtual GroupBox GroupBox13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_PWalls_Construction")]
    internal virtual CheckBox chk_PWalls_Construction { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_PWalls_Kappa")]
    internal virtual CheckBox chk_PWalls_Kappa { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_PWalls_Area")]
    internal virtual CheckBox chk_PWalls_Area { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label14")]
    internal virtual Label Label14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DGSWallP")]
    internal virtual DataGridView DGSWallP { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label15")]
    internal virtual Label Label15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button21
    {
      get => this._Button21;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button21_Click);
        Button button21_1 = this._Button21;
        if (button21_1 != null)
          button21_1.Click -= eventHandler;
        this._Button21 = value;
        Button button21_2 = this._Button21;
        if (button21_2 == null)
          return;
        button21_2.Click += eventHandler;
      }
    }

    internal virtual Button Button22
    {
      get => this._Button22;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button22_Click);
        Button button22_1 = this._Button22;
        if (button22_1 != null)
          button22_1.Click -= eventHandler;
        this._Button22 = value;
        Button button22_2 = this._Button22;
        if (button22_2 == null)
          return;
        button22_2.Click += eventHandler;
      }
    }

    internal virtual Button Button23
    {
      get => this._Button23;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button23_Click);
        Button button23_1 = this._Button23;
        if (button23_1 != null)
          button23_1.Click -= eventHandler;
        this._Button23 = value;
        Button button23_2 = this._Button23;
        if (button23_2 == null)
          return;
        button23_2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("DGWallsP")]
    internal virtual DataGridView DGWallsP { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox15")]
    internal virtual GroupBox GroupBox15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_PRoofs_Construction")]
    internal virtual CheckBox chk_PRoofs_Construction { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_PRoofs_Kappa")]
    internal virtual CheckBox chk_PRoofs_Kappa { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_PRoofs_Area")]
    internal virtual CheckBox chk_PRoofs_Area { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label18")]
    internal virtual Label Label18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DGSRoofP")]
    internal virtual DataGridView DGSRoofP { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label19")]
    internal virtual Label Label19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button27
    {
      get => this._Button27;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button27_Click);
        Button button27_1 = this._Button27;
        if (button27_1 != null)
          button27_1.Click -= eventHandler;
        this._Button27 = value;
        Button button27_2 = this._Button27;
        if (button27_2 == null)
          return;
        button27_2.Click += eventHandler;
      }
    }

    internal virtual Button Button28
    {
      get => this._Button28;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button28_Click);
        Button button28_1 = this._Button28;
        if (button28_1 != null)
          button28_1.Click -= eventHandler;
        this._Button28 = value;
        Button button28_2 = this._Button28;
        if (button28_2 == null)
          return;
        button28_2.Click += eventHandler;
      }
    }

    internal virtual Button Button29
    {
      get => this._Button29;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button29_Click);
        Button button29_1 = this._Button29;
        if (button29_1 != null)
          button29_1.Click -= eventHandler;
        this._Button29 = value;
        Button button29_2 = this._Button29;
        if (button29_2 == null)
          return;
        button29_2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("DGRoofsP")]
    internal virtual DataGridView DGRoofsP { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_PWalls_Type")]
    internal virtual CheckBox chk_PWalls_Type { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_PWalls_UValue")]
    internal virtual CheckBox chk_PWalls_UValue { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("TabPage11")]
    internal virtual TabPage TabPage11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DGHtbDwellings")]
    internal virtual DataGridView DGHtbDwellings { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("dtaCalc")]
    internal virtual DataGridView dtaCalc { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button30
    {
      get => this._Button30;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button30_Click);
        Button button30_1 = this._Button30;
        if (button30_1 != null)
          button30_1.Click -= eventHandler;
        this._Button30 = value;
        Button button30_2 = this._Button30;
        if (button30_2 == null)
          return;
        button30_2.Click += eventHandler;
      }
    }

    internal virtual Button Button31
    {
      get => this._Button31;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button31_Click);
        Button button31_1 = this._Button31;
        if (button31_1 != null)
          button31_1.Click -= eventHandler;
        this._Button31 = value;
        Button button31_2 = this._Button31;
        if (button31_2 == null)
          return;
        button31_2.Click += eventHandler;
      }
    }

    internal virtual Button Button32
    {
      get => this._Button32;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button32_Click);
        Button button32_1 = this._Button32;
        if (button32_1 != null)
          button32_1.Click -= eventHandler;
        this._Button32 = value;
        Button button32_2 = this._Button32;
        if (button32_2 == null)
          return;
        button32_2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("chkSource")]
    internal virtual CheckBox chkSource { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chkL")]
    internal virtual CheckBox chkL { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chkY")]
    internal virtual CheckBox chkY { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox16")]
    internal virtual GroupBox GroupBox16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_Thermal")]
    internal virtual CheckBox chk_Thermal { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button cmdSelectAllHtb
    {
      get => this._cmdSelectAllHtb;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdSelectAllHtb_Click);
        Button cmdSelectAllHtb1 = this._cmdSelectAllHtb;
        if (cmdSelectAllHtb1 != null)
          cmdSelectAllHtb1.Click -= eventHandler;
        this._cmdSelectAllHtb = value;
        Button cmdSelectAllHtb2 = this._cmdSelectAllHtb;
        if (cmdSelectAllHtb2 == null)
          return;
        cmdSelectAllHtb2.Click += eventHandler;
      }
    }

    internal virtual Button cmdDeSelectAllHtb
    {
      get => this._cmdDeSelectAllHtb;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdDeSelectAllHtb_Click);
        Button cmdDeSelectAllHtb1 = this._cmdDeSelectAllHtb;
        if (cmdDeSelectAllHtb1 != null)
          cmdDeSelectAllHtb1.Click -= eventHandler;
        this._cmdDeSelectAllHtb = value;
        Button cmdDeSelectAllHtb2 = this._cmdDeSelectAllHtb;
        if (cmdDeSelectAllHtb2 == null)
          return;
        cmdDeSelectAllHtb2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("GroupBox17")]
    internal virtual GroupBox GroupBox17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("ChkAssessmentType")]
    internal virtual CheckBox ChkAssessmentType { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_Heating_SecMain")]
    internal virtual CheckBox chk_Heating_SecMain { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("JunctionType")]
    internal virtual DataGridViewTextBoxColumn JunctionType { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("LTTUsed")]
    internal virtual DataGridViewTextBoxColumn LTTUsed { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("LJT")]
    internal virtual DataGridViewTextBoxColumn LJT { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("ApprovedSource")]
    internal virtual DataGridViewCheckBoxColumn ApprovedSource { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Def")]
    internal virtual DataGridViewCheckBoxColumn Def { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("SelectCheck")]
    internal virtual DataGridViewCheckBoxColumn SelectCheck { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("ID")]
    internal virtual DataGridViewTextBoxColumn ID { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chkD")]
    internal virtual CheckBox chkD { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_FGHRS")]
    internal virtual CheckBox chk_FGHRS { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk_WWHR")]
    internal virtual CheckBox chk_WWHR { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox18")]
    internal virtual GroupBox GroupBox18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("ChkCooling")]
    internal virtual CheckBox ChkCooling { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chkHydro")]
    internal virtual CheckBox chkHydro { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox19")]
    internal virtual GroupBox GroupBox19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chkAddress")]
    internal virtual CheckBox chkAddress { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chkapprovedInstaller")]
    internal virtual CheckBox chkapprovedInstaller { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button33
    {
      get => this._Button33;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button33_Click);
        Button button33_1 = this._Button33;
        if (button33_1 != null)
          button33_1.Click -= eventHandler;
        this._Button33 = value;
        Button button33_2 = this._Button33;
        if (button33_2 == null)
          return;
        button33_2.Click += eventHandler;
      }
    }

    internal virtual Button Button34
    {
      get => this._Button34;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button34_Click);
        Button button34_1 = this._Button34;
        if (button34_1 != null)
          button34_1.Click -= eventHandler;
        this._Button34 = value;
        Button button34_2 = this._Button34;
        if (button34_2 == null)
          return;
        button34_2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("TabPage12")]
    internal virtual TabPage TabPage12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox20")]
    internal virtual GroupBox GroupBox20 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Chk_CoolingsystType")]
    internal virtual CheckBox Chk_CoolingsystType { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("ChkCoolingEER")]
    internal virtual CheckBox ChkCoolingEER { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("ChkCoolingEnergyLabel")]
    internal virtual CheckBox ChkCoolingEnergyLabel { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label20")]
    internal virtual Label Label20 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DGSCooling")]
    internal virtual DataGridView DGSCooling { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label21")]
    internal virtual Label Label21 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button35
    {
      get => this._Button35;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button35_Click);
        Button button35_1 = this._Button35;
        if (button35_1 != null)
          button35_1.Click -= eventHandler;
        this._Button35 = value;
        Button button35_2 = this._Button35;
        if (button35_2 == null)
          return;
        button35_2.Click += eventHandler;
      }
    }

    internal virtual Button Button36
    {
      get => this._Button36;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button36_Click);
        Button button36_1 = this._Button36;
        if (button36_1 != null)
          button36_1.Click -= eventHandler;
        this._Button36 = value;
        Button button36_2 = this._Button36;
        if (button36_2 == null)
          return;
        button36_2.Click += eventHandler;
      }
    }

    internal virtual Button Button37
    {
      get => this._Button37;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button37_Click);
        Button button37_1 = this._Button37;
        if (button37_1 != null)
          button37_1.Click -= eventHandler;
        this._Button37 = value;
        Button button37_2 = this._Button37;
        if (button37_2 == null)
          return;
        button37_2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("DGCooling")]
    internal virtual DataGridView DGCooling { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("ChkCompressorcontrol")]
    internal virtual CheckBox ChkCompressorcontrol { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("ChkCoolingArea")]
    internal virtual CheckBox ChkCoolingArea { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("ChkDe")]
    internal virtual GroupBox ChkDe { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("ChkDwelling")]
    internal virtual CheckBox ChkDwelling { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chkBuild")]
    internal virtual GroupBox chkBuild { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("ChkBuildingDetails")]
    internal virtual CheckBox ChkBuildingDetails { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox21")]
    internal virtual GroupBox GroupBox21 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("ChkLocationDetails")]
    internal virtual CheckBox ChkLocationDetails { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox22")]
    internal virtual GroupBox GroupBox22 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chkbuilt")]
    internal virtual CheckBox chkbuilt { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox24")]
    internal virtual GroupBox GroupBox24 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtBuildetails")]
    internal virtual CheckBox txtBuildetails { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox23")]
    internal virtual GroupBox GroupBox23 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtRPD")]
    internal virtual CheckBox txtRPD { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtLanguage")]
    internal virtual CheckBox txtLanguage { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtTenure")]
    internal virtual CheckBox txtTenure { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtTranstype")]
    internal virtual CheckBox txtTranstype { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chkcounty")]
    internal virtual CheckBox chkcounty { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Chkoverheat")]
    internal virtual CheckBox Chkoverheat { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private void Copy_Element_Load(object sender, EventArgs e)
    {
      DataTable dataTable1 = new DataTable();
      dataTable1.Columns.Add("Dwelling", typeof (short));
      dataTable1.Columns.Add("Coolings", typeof (short));
      dataTable1.Columns.Add("Dwelling Name", typeof (string));
      dataTable1.Columns.Add("Cooling Name", typeof (string));
      dataTable1.Columns.Add("Select", typeof (bool));
      DataTable dataTable2 = new DataTable();
      dataTable2.Columns.Add("Dwelling", typeof (string));
      dataTable2.Columns.Add("Class", typeof (string));
      dataTable2.Columns.Add("Area", typeof (float));
      dataTable2.Columns.Add("System", typeof (string));
      DataTable dataTable3 = new DataTable();
      dataTable3.Columns.Add("Dwelling", typeof (short));
      dataTable3.Columns.Add("Floor", typeof (short));
      dataTable3.Columns.Add("Dwelling Name", typeof (string));
      dataTable3.Columns.Add("Floor Name", typeof (string));
      dataTable3.Columns.Add("Select", typeof (bool));
      DataTable dataTable4 = new DataTable();
      dataTable4.Columns.Add("Floor", typeof (string));
      dataTable4.Columns.Add("Type", typeof (string));
      dataTable4.Columns.Add("Area", typeof (float));
      dataTable4.Columns.Add("UValue", typeof (float));
      DataTable dataTable5 = new DataTable();
      dataTable5.Columns.Add("Dwelling", typeof (short));
      dataTable5.Columns.Add("Floor", typeof (short));
      dataTable5.Columns.Add("Dwelling Name", typeof (string));
      dataTable5.Columns.Add("Floor Name", typeof (string));
      dataTable5.Columns.Add("Select", typeof (bool));
      DataTable dataTable6 = new DataTable();
      dataTable6.Columns.Add("Floor", typeof (string));
      dataTable6.Columns.Add("Construction", typeof (string));
      dataTable6.Columns.Add("Area", typeof (float));
      dataTable6.Columns.Add("Kappa", typeof (float));
      DataTable dataTable7 = new DataTable();
      dataTable7.Columns.Add("Dwelling", typeof (short));
      dataTable7.Columns.Add("Floor", typeof (short));
      dataTable7.Columns.Add("Dwelling Name", typeof (string));
      dataTable7.Columns.Add("Floor Name", typeof (string));
      dataTable7.Columns.Add("Select", typeof (bool));
      DataTable dataTable8 = new DataTable();
      dataTable8.Columns.Add("Floor", typeof (string));
      dataTable8.Columns.Add("Construction", typeof (string));
      dataTable8.Columns.Add("Area", typeof (float));
      dataTable8.Columns.Add("Kappa", typeof (float));
      DataTable dataTable9 = new DataTable();
      dataTable9.Columns.Add("Dwelling", typeof (short));
      dataTable9.Columns.Add("Walls", typeof (short));
      dataTable9.Columns.Add("Dwelling Name", typeof (string));
      dataTable9.Columns.Add("Wall Name", typeof (string));
      dataTable9.Columns.Add("Select", typeof (bool));
      DataTable dataTable10 = new DataTable();
      dataTable10.Columns.Add("Wall", typeof (string));
      dataTable10.Columns.Add("Type", typeof (string));
      dataTable10.Columns.Add("Area", typeof (float));
      dataTable10.Columns.Add("UValue", typeof (float));
      dataTable10.Columns.Add("Ru", typeof (float));
      dataTable10.Columns.Add("Curtain", typeof (bool));
      DataTable dataTable11 = new DataTable();
      dataTable11.Columns.Add("Dwelling", typeof (short));
      dataTable11.Columns.Add("Walls", typeof (short));
      dataTable11.Columns.Add("Dwelling Name", typeof (string));
      dataTable11.Columns.Add("Wall Name", typeof (string));
      dataTable11.Columns.Add("Select", typeof (bool));
      DataTable dataTable12 = new DataTable();
      dataTable12.Columns.Add("Wall", typeof (string));
      dataTable12.Columns.Add("Construction", typeof (string));
      dataTable12.Columns.Add("Area", typeof (float));
      dataTable12.Columns.Add("Kappa", typeof (float));
      DataTable dataTable13 = new DataTable();
      dataTable13.Columns.Add("Dwelling", typeof (short));
      dataTable13.Columns.Add("Walls", typeof (short));
      dataTable13.Columns.Add("Dwelling Name", typeof (string));
      dataTable13.Columns.Add("Wall Name", typeof (string));
      dataTable13.Columns.Add("Select", typeof (bool));
      DataTable dataTable14 = new DataTable();
      dataTable14.Columns.Add("Wall", typeof (string));
      dataTable14.Columns.Add("Type", typeof (string));
      dataTable14.Columns.Add("Construction", typeof (string));
      dataTable14.Columns.Add("Area", typeof (float));
      dataTable14.Columns.Add("UValue", typeof (float));
      dataTable14.Columns.Add("Kappa", typeof (float));
      DataTable dataTable15 = new DataTable();
      dataTable15.Columns.Add("Dwelling", typeof (short));
      dataTable15.Columns.Add("Roof", typeof (short));
      dataTable15.Columns.Add("Dwelling Name", typeof (string));
      dataTable15.Columns.Add("Roof Name", typeof (string));
      dataTable15.Columns.Add("Select", typeof (bool));
      DataTable dataTable16 = new DataTable();
      dataTable16.Columns.Add("Roof", typeof (string));
      dataTable16.Columns.Add("Type", typeof (string));
      dataTable16.Columns.Add("Area", typeof (float));
      dataTable16.Columns.Add("UValue", typeof (float));
      dataTable16.Columns.Add("Ru", typeof (float));
      DataTable dataTable17 = new DataTable();
      dataTable17.Columns.Add("Dwelling", typeof (short));
      dataTable17.Columns.Add("Ceiling", typeof (short));
      dataTable17.Columns.Add("Dwelling Name", typeof (string));
      dataTable17.Columns.Add("Roof Name", typeof (string));
      dataTable17.Columns.Add("Select", typeof (bool));
      DataTable dataTable18 = new DataTable();
      dataTable18.Columns.Add("Ceiling", typeof (string));
      dataTable18.Columns.Add("Construction", typeof (string));
      dataTable18.Columns.Add("Area", typeof (float));
      dataTable18.Columns.Add("Kappa", typeof (float));
      DataTable dataTable19 = new DataTable();
      dataTable19.Columns.Add("Dwelling", typeof (short));
      dataTable19.Columns.Add("Ceiling", typeof (short));
      dataTable19.Columns.Add("Dwelling Name", typeof (string));
      dataTable19.Columns.Add("Roof Name", typeof (string));
      dataTable19.Columns.Add("Select", typeof (bool));
      DataTable dataTable20 = new DataTable();
      dataTable20.Columns.Add("Ceiling", typeof (string));
      dataTable20.Columns.Add("Construction", typeof (string));
      dataTable20.Columns.Add("Area", typeof (float));
      dataTable20.Columns.Add("Kappa", typeof (float));
      DataTable dataTable21 = new DataTable();
      dataTable21.Columns.Add("Dwelling", typeof (short));
      dataTable21.Columns.Add("Dwelling Name", typeof (string));
      dataTable21.Columns.Add("Select", typeof (bool));
      DataTable dataTable22 = new DataTable();
      dataTable22.Columns.Add("Dwelling", typeof (short));
      dataTable22.Columns.Add("Dwelling Name", typeof (string));
      dataTable22.Columns.Add("Select", typeof (bool));
      try
      {
        int num1 = checked (SAP_Module.Proj.NoOfDwells - 1);
        int House = 0;
        while (House <= num1)
        {
          if (!Functions.LodgementLock(House))
          {
            if (House != SAP_Module.CurrDwelling)
            {
              DataRow row1 = dataTable21.NewRow();
              DataRow dataRow1 = row1;
              dataRow1["Dwelling"] = (object) House;
              dataRow1["Dwelling Name"] = (object) SAP_Module.Proj.Dwellings[House].Name;
              dataTable21.Rows.Add(row1);
              try
              {
                DataRow row2 = dataTable1.NewRow();
                DataRow dataRow2 = row2;
                dataRow2["Dwelling"] = (object) House;
                dataRow2["Coolings"] = (object) House;
                dataRow2["Dwelling Name"] = (object) SAP_Module.Proj.Dwellings[House].Name;
                dataRow2["Cooling Name"] = (object) SAP_Module.Proj.Dwellings[House].Cooling.Compressorcontrol;
                dataTable1.Rows.Add(row2);
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                Console.Write("");
                ProjectData.ClearProjectError();
              }
              int num2 = checked (SAP_Module.Proj.Dwellings[House].NoofFloors - 1);
              int index1 = 0;
              while (index1 <= num2)
              {
                DataRow row3 = dataTable3.NewRow();
                DataRow dataRow3 = row3;
                dataRow3["Dwelling"] = (object) House;
                dataRow3["Floor"] = (object) index1;
                dataRow3["Dwelling Name"] = (object) SAP_Module.Proj.Dwellings[House].Name;
                dataRow3["Floor Name"] = (object) SAP_Module.Proj.Dwellings[House].Floors[index1].Name;
                dataTable3.Rows.Add(row3);
                checked { ++index1; }
              }
              int num3 = checked (SAP_Module.Proj.Dwellings[House].NoofIFloors - 1);
              int index2 = 0;
              while (index2 <= num3)
              {
                DataRow row4 = dataTable5.NewRow();
                DataRow dataRow4 = row4;
                dataRow4["Dwelling"] = (object) House;
                dataRow4["Floor"] = (object) index2;
                dataRow4["Dwelling Name"] = (object) SAP_Module.Proj.Dwellings[House].Name;
                dataRow4["Floor Name"] = (object) SAP_Module.Proj.Dwellings[House].IFloors[index2].Name;
                dataTable5.Rows.Add(row4);
                checked { ++index2; }
              }
              int num4 = checked (SAP_Module.Proj.Dwellings[House].NoofpFloors - 1);
              int index3 = 0;
              while (index3 <= num4)
              {
                DataRow row5 = dataTable7.NewRow();
                DataRow dataRow5 = row5;
                dataRow5["Dwelling"] = (object) House;
                dataRow5["Floor"] = (object) index3;
                dataRow5["Dwelling Name"] = (object) SAP_Module.Proj.Dwellings[House].Name;
                dataRow5["Floor Name"] = (object) SAP_Module.Proj.Dwellings[House].PFloors[index3].Name;
                dataTable7.Rows.Add(row5);
                checked { ++index3; }
              }
              int num5 = checked (SAP_Module.Proj.Dwellings[House].NoofWalls - 1);
              int index4 = 0;
              while (index4 <= num5)
              {
                DataRow row6 = dataTable9.NewRow();
                DataRow dataRow6 = row6;
                dataRow6["Dwelling"] = (object) House;
                dataRow6["Walls"] = (object) index4;
                dataRow6["Dwelling Name"] = (object) SAP_Module.Proj.Dwellings[House].Name;
                dataRow6["Wall Name"] = (object) SAP_Module.Proj.Dwellings[House].Walls[index4].Name;
                dataTable9.Rows.Add(row6);
                checked { ++index4; }
              }
              int num6 = checked (SAP_Module.Proj.Dwellings[House].NoofIWalls - 1);
              int index5 = 0;
              while (index5 <= num6)
              {
                DataRow row7 = dataTable11.NewRow();
                DataRow dataRow7 = row7;
                dataRow7["Dwelling"] = (object) House;
                dataRow7["Walls"] = (object) index5;
                dataRow7["Dwelling Name"] = (object) SAP_Module.Proj.Dwellings[House].Name;
                dataRow7["Wall Name"] = (object) SAP_Module.Proj.Dwellings[House].IWalls[index5].Name;
                dataTable11.Rows.Add(row7);
                checked { ++index5; }
              }
              int num7 = checked (SAP_Module.Proj.Dwellings[House].NoofPWalls - 1);
              int index6 = 0;
              while (index6 <= num7)
              {
                DataRow row8 = dataTable13.NewRow();
                DataRow dataRow8 = row8;
                dataRow8["Dwelling"] = (object) House;
                dataRow8["Walls"] = (object) index6;
                dataRow8["Dwelling Name"] = (object) SAP_Module.Proj.Dwellings[House].Name;
                dataRow8["Wall Name"] = (object) SAP_Module.Proj.Dwellings[House].PWalls[index6].Name;
                dataTable13.Rows.Add(row8);
                checked { ++index6; }
              }
              int num8 = checked (SAP_Module.Proj.Dwellings[House].NoofRoofs - 1);
              int index7 = 0;
              while (index7 <= num8)
              {
                DataRow row9 = dataTable15.NewRow();
                DataRow dataRow9 = row9;
                dataRow9["Dwelling"] = (object) House;
                dataRow9["Roof"] = (object) index7;
                dataRow9["Dwelling Name"] = (object) SAP_Module.Proj.Dwellings[House].Name;
                dataRow9["Roof Name"] = (object) SAP_Module.Proj.Dwellings[House].Roofs[index7].Name;
                dataTable15.Rows.Add(row9);
                checked { ++index7; }
              }
              int num9 = checked (SAP_Module.Proj.Dwellings[House].NoofICeilings - 1);
              int index8 = 0;
              while (index8 <= num9)
              {
                DataRow row10 = dataTable17.NewRow();
                DataRow dataRow10 = row10;
                dataRow10["Dwelling"] = (object) House;
                dataRow10["Ceiling"] = (object) index8;
                dataRow10["Dwelling Name"] = (object) SAP_Module.Proj.Dwellings[House].Name;
                dataRow10["Roof Name"] = (object) SAP_Module.Proj.Dwellings[House].ICeilings[index8].Name;
                dataTable17.Rows.Add(row10);
                checked { ++index8; }
              }
              int num10 = checked (SAP_Module.Proj.Dwellings[House].NoofPCeilings - 1);
              int index9 = 0;
              while (index9 <= num10)
              {
                DataRow row11 = dataTable19.NewRow();
                DataRow dataRow11 = row11;
                dataRow11["Dwelling"] = (object) House;
                dataRow11["Ceiling"] = (object) index9;
                dataRow11["Dwelling Name"] = (object) SAP_Module.Proj.Dwellings[House].Name;
                dataRow11["Roof Name"] = (object) SAP_Module.Proj.Dwellings[House].PCeilings[index9].Name;
                dataTable19.Rows.Add(row11);
                checked { ++index9; }
              }
              DataRow row12 = dataTable22.NewRow();
              DataRow dataRow12 = row12;
              dataRow12["Dwelling"] = (object) House;
              dataRow12["Dwelling Name"] = (object) SAP_Module.Proj.Dwellings[House].Name;
              dataTable22.Rows.Add(row12);
            }
            else
            {
              try
              {
                if (SAP_Module.Proj.Dwellings[House].Cooling.Include)
                {
                  DataRow row = dataTable2.NewRow();
                  DataRow dataRow = row;
                  dataRow["Dwelling"] = (object) SAP_Module.Proj.Dwellings[House].Reference;
                  dataRow["Class"] = (object) SAP_Module.Proj.Dwellings[House].Cooling.Energylabel;
                  dataRow["Area"] = (object) SAP_Module.Proj.Dwellings[House].Cooling.Cooled_Area;
                  dataRow["System"] = (object) SAP_Module.Proj.Dwellings[House].Cooling.SystemType;
                  dataTable2.Rows.Add(row);
                }
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                Console.Write("");
                ProjectData.ClearProjectError();
              }
              int num11 = checked (SAP_Module.Proj.Dwellings[House].NoofFloors - 1);
              int index10 = 0;
              while (index10 <= num11)
              {
                DataRow row = dataTable4.NewRow();
                DataRow dataRow = row;
                dataRow["Floor"] = (object) SAP_Module.Proj.Dwellings[House].Floors[index10].Name;
                dataRow["Type"] = (object) SAP_Module.Proj.Dwellings[House].Floors[index10].Type;
                dataRow["Area"] = (object) SAP_Module.Proj.Dwellings[House].Floors[index10].Area;
                dataRow["UValue"] = (object) SAP_Module.Proj.Dwellings[House].Floors[index10].U_Value;
                dataTable4.Rows.Add(row);
                checked { ++index10; }
              }
              int num12 = checked (SAP_Module.Proj.Dwellings[House].NoofIFloors - 1);
              int index11 = 0;
              while (index11 <= num12)
              {
                DataRow row = dataTable6.NewRow();
                DataRow dataRow = row;
                dataRow["Floor"] = (object) SAP_Module.Proj.Dwellings[House].IFloors[index11].Name;
                dataRow["Construction"] = (object) SAP_Module.Proj.Dwellings[House].IFloors[index11].Construction;
                dataRow["Area"] = (object) SAP_Module.Proj.Dwellings[House].IFloors[index11].Area;
                dataRow["Kappa"] = (object) SAP_Module.Proj.Dwellings[House].IFloors[index11].K;
                dataTable6.Rows.Add(row);
                checked { ++index11; }
              }
              int num13 = checked (SAP_Module.Proj.Dwellings[House].NoofpFloors - 1);
              int index12 = 0;
              while (index12 <= num13)
              {
                DataRow row = dataTable8.NewRow();
                DataRow dataRow = row;
                dataRow["Floor"] = (object) SAP_Module.Proj.Dwellings[House].PFloors[index12].Name;
                dataRow["Construction"] = (object) SAP_Module.Proj.Dwellings[House].PFloors[index12].Construction;
                dataRow["Area"] = (object) SAP_Module.Proj.Dwellings[House].PFloors[index12].Area;
                dataRow["Kappa"] = (object) SAP_Module.Proj.Dwellings[House].PFloors[index12].K;
                dataTable8.Rows.Add(row);
                checked { ++index12; }
              }
              int num14 = checked (SAP_Module.Proj.Dwellings[House].NoofWalls - 1);
              int index13 = 0;
              while (index13 <= num14)
              {
                DataRow row = dataTable10.NewRow();
                DataRow dataRow = row;
                dataRow["Wall"] = (object) SAP_Module.Proj.Dwellings[House].Walls[index13].Name;
                dataRow["Type"] = (object) SAP_Module.Proj.Dwellings[House].Walls[index13].Type;
                dataRow["Area"] = (object) SAP_Module.Proj.Dwellings[House].Walls[index13].Area;
                dataRow["UValue"] = (object) SAP_Module.Proj.Dwellings[House].Walls[index13].U_Value;
                dataRow["Ru"] = (object) SAP_Module.Proj.Dwellings[House].Walls[index13].Ru;
                dataRow["Curtain"] = (object) SAP_Module.Proj.Dwellings[House].Walls[index13].Curtain;
                dataTable10.Rows.Add(row);
                checked { ++index13; }
              }
              int num15 = checked (SAP_Module.Proj.Dwellings[House].NoofIWalls - 1);
              int index14 = 0;
              while (index14 <= num15)
              {
                DataRow row = dataTable12.NewRow();
                DataRow dataRow = row;
                dataRow["Wall"] = (object) SAP_Module.Proj.Dwellings[House].IWalls[index14].Name;
                dataRow["Construction"] = (object) SAP_Module.Proj.Dwellings[House].IWalls[index14].Construction;
                dataRow["Area"] = (object) SAP_Module.Proj.Dwellings[House].IWalls[index14].Area;
                dataRow["Kappa"] = (object) SAP_Module.Proj.Dwellings[House].IWalls[index14].K;
                dataTable12.Rows.Add(row);
                checked { ++index14; }
              }
              int num16 = checked (SAP_Module.Proj.Dwellings[House].NoofPWalls - 1);
              int index15 = 0;
              while (index15 <= num16)
              {
                DataRow row = dataTable14.NewRow();
                DataRow dataRow = row;
                dataRow["Wall"] = (object) SAP_Module.Proj.Dwellings[House].PWalls[index15].Name;
                dataRow["Type"] = (object) SAP_Module.Proj.Dwellings[House].PWalls[index15].Construction;
                dataRow["Construction"] = (object) SAP_Module.Proj.Dwellings[House].PWalls[index15].Construction;
                dataRow["Area"] = (object) SAP_Module.Proj.Dwellings[House].PWalls[index15].Area;
                dataRow["Uvalue"] = (object) SAP_Module.Proj.Dwellings[House].PWalls[index15].U_Value;
                dataRow["Kappa"] = (object) SAP_Module.Proj.Dwellings[House].PWalls[index15].K;
                dataTable14.Rows.Add(row);
                checked { ++index15; }
              }
              int num17 = checked (SAP_Module.Proj.Dwellings[House].NoofRoofs - 1);
              int index16 = 0;
              while (index16 <= num17)
              {
                DataRow row = dataTable16.NewRow();
                DataRow dataRow = row;
                dataRow["Roof"] = (object) SAP_Module.Proj.Dwellings[House].Roofs[index16].Name;
                dataRow["Type"] = (object) SAP_Module.Proj.Dwellings[House].Roofs[index16].Type;
                dataRow["Area"] = (object) SAP_Module.Proj.Dwellings[House].Roofs[index16].Area;
                dataRow["UValue"] = (object) SAP_Module.Proj.Dwellings[House].Roofs[index16].U_Value;
                dataRow["Ru"] = (object) SAP_Module.Proj.Dwellings[House].Roofs[index16].Ru;
                dataTable16.Rows.Add(row);
                checked { ++index16; }
              }
              int num18 = checked (SAP_Module.Proj.Dwellings[House].NoofICeilings - 1);
              int index17 = 0;
              while (index17 <= num18)
              {
                DataRow row = dataTable18.NewRow();
                DataRow dataRow = row;
                dataRow["Ceiling"] = (object) SAP_Module.Proj.Dwellings[House].ICeilings[index17].Name;
                dataRow["Construction"] = (object) SAP_Module.Proj.Dwellings[House].ICeilings[index17].Construction;
                dataRow["Area"] = (object) SAP_Module.Proj.Dwellings[House].ICeilings[index17].Area;
                dataRow["Kappa"] = (object) SAP_Module.Proj.Dwellings[House].ICeilings[index17].K;
                dataTable18.Rows.Add(row);
                checked { ++index17; }
              }
              int num19 = checked (SAP_Module.Proj.Dwellings[House].NoofPCeilings - 1);
              int index18 = 0;
              while (index18 <= num19)
              {
                DataRow row = dataTable20.NewRow();
                DataRow dataRow = row;
                dataRow["Ceiling"] = (object) SAP_Module.Proj.Dwellings[House].PCeilings[index18].Name;
                dataRow["Construction"] = (object) SAP_Module.Proj.Dwellings[House].PCeilings[index18].Construction;
                dataRow["Area"] = (object) SAP_Module.Proj.Dwellings[House].PCeilings[index18].Area;
                dataRow["Kappa"] = (object) SAP_Module.Proj.Dwellings[House].PCeilings[index18].K;
                dataTable20.Rows.Add(row);
                checked { ++index18; }
              }
            }
          }
          checked { ++House; }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) ex.Message);
        ProjectData.ClearProjectError();
      }
      this.DGCooling.DataSource = (object) dataTable1;
      this.DGCooling.Columns[0].Visible = false;
      this.DGCooling.Columns[1].Visible = false;
      this.DGCooling.Columns[2].ReadOnly = true;
      this.DGCooling.Columns[3].ReadOnly = true;
      this.DGSCooling.DataSource = (object) dataTable2;
      this.DGSCooling.Columns[0].ReadOnly = true;
      this.DGSCooling.Columns[1].ReadOnly = true;
      this.DGSCooling.Columns[2].ReadOnly = true;
      this.DGSCooling.Columns[3].ReadOnly = true;
      this.DG1.DataSource = (object) dataTable21;
      this.DG1.Columns[0].Visible = false;
      this.DG1.Columns[1].ReadOnly = true;
      this.DGFloors.DataSource = (object) dataTable3;
      this.DGFloors.Columns[0].Visible = false;
      this.DGFloors.Columns[1].Visible = false;
      this.DGFloors.Columns[2].ReadOnly = true;
      this.DGFloors.Columns[3].ReadOnly = true;
      this.DGSFloor.DataSource = (object) dataTable4;
      this.DGFloors.Columns[0].ReadOnly = true;
      this.DGFloors.Columns[1].ReadOnly = true;
      this.DGFloors.Columns[2].ReadOnly = true;
      this.DGFloors.Columns[3].ReadOnly = true;
      this.DGFloorsI.DataSource = (object) dataTable5;
      this.DGFloorsI.Columns[0].Visible = false;
      this.DGFloorsI.Columns[1].Visible = false;
      this.DGFloorsI.Columns[2].ReadOnly = true;
      this.DGFloorsI.Columns[3].ReadOnly = true;
      this.DGSFloorI.DataSource = (object) dataTable6;
      this.DGSFloorI.Columns[0].ReadOnly = true;
      this.DGSFloorI.Columns[1].ReadOnly = true;
      this.DGSFloorI.Columns[2].ReadOnly = true;
      this.DGSFloorI.Columns[3].ReadOnly = true;
      this.DGFloorsP.DataSource = (object) dataTable7;
      this.DGFloorsP.Columns[0].Visible = false;
      this.DGFloorsP.Columns[1].Visible = false;
      this.DGFloorsP.Columns[2].ReadOnly = true;
      this.DGFloorsP.Columns[3].ReadOnly = true;
      this.DGSFloorP.DataSource = (object) dataTable8;
      this.DGSFloorP.Columns[0].ReadOnly = true;
      this.DGSFloorP.Columns[1].ReadOnly = true;
      this.DGSFloorP.Columns[2].ReadOnly = true;
      this.DGSFloorP.Columns[3].ReadOnly = true;
      this.DGWalls.DataSource = (object) dataTable9;
      this.DGWalls.Columns[0].Visible = false;
      this.DGWalls.Columns[1].Visible = false;
      this.DGWalls.Columns[2].ReadOnly = true;
      this.DGWalls.Columns[3].ReadOnly = true;
      this.DGSWall.DataSource = (object) dataTable10;
      this.DGSWall.Columns[0].ReadOnly = true;
      this.DGSWall.Columns[1].ReadOnly = true;
      this.DGSWall.Columns[2].ReadOnly = true;
      this.DGSWall.Columns[3].ReadOnly = true;
      this.DGSWall.Columns[4].ReadOnly = true;
      this.DGSWall.Columns[5].ReadOnly = true;
      this.DGWallsI.DataSource = (object) dataTable11;
      this.DGWallsI.Columns[0].Visible = false;
      this.DGWallsI.Columns[1].Visible = false;
      this.DGWallsI.Columns[2].ReadOnly = true;
      this.DGWallsI.Columns[3].ReadOnly = true;
      this.DGSWallI.DataSource = (object) dataTable12;
      this.DGSWallI.Columns[0].ReadOnly = true;
      this.DGSWallI.Columns[1].ReadOnly = true;
      this.DGSWallI.Columns[2].ReadOnly = true;
      this.DGSWallI.Columns[3].ReadOnly = true;
      this.DGWallsP.DataSource = (object) dataTable13;
      this.DGWallsP.Columns[0].Visible = false;
      this.DGWallsP.Columns[1].Visible = false;
      this.DGWallsP.Columns[2].ReadOnly = true;
      this.DGWallsP.Columns[3].ReadOnly = true;
      this.DGSWallP.DataSource = (object) dataTable14;
      this.DGSWallP.Columns[0].ReadOnly = true;
      this.DGSWallP.Columns[1].ReadOnly = true;
      this.DGSWallP.Columns[2].ReadOnly = true;
      this.DGSWallP.Columns[3].ReadOnly = true;
      this.DGSWallP.Columns[4].ReadOnly = true;
      this.DGSWallP.Columns[5].ReadOnly = true;
      this.DGRoofs.DataSource = (object) dataTable15;
      this.DGRoofs.Columns[0].Visible = false;
      this.DGRoofs.Columns[1].Visible = false;
      this.DGRoofs.Columns[2].ReadOnly = true;
      this.DGRoofs.Columns[3].ReadOnly = true;
      this.DGSRoof.DataSource = (object) dataTable16;
      this.DGSRoof.Columns[0].ReadOnly = true;
      this.DGSRoof.Columns[1].ReadOnly = true;
      this.DGSRoof.Columns[2].ReadOnly = true;
      this.DGSRoof.Columns[3].ReadOnly = true;
      this.DGSRoof.Columns[4].ReadOnly = true;
      this.DGRoofsI.DataSource = (object) dataTable17;
      this.DGRoofsI.Columns[0].Visible = false;
      this.DGRoofsI.Columns[1].Visible = false;
      this.DGRoofsI.Columns[2].ReadOnly = true;
      this.DGRoofsI.Columns[3].ReadOnly = true;
      this.DGSRoofI.DataSource = (object) dataTable18;
      this.DGSRoofI.Columns[0].ReadOnly = true;
      this.DGSRoofI.Columns[1].ReadOnly = true;
      this.DGSRoofI.Columns[2].ReadOnly = true;
      this.DGSRoofI.Columns[2].ReadOnly = true;
      this.DGRoofsP.DataSource = (object) dataTable19;
      this.DGRoofsP.Columns[0].Visible = false;
      this.DGRoofsP.Columns[1].Visible = false;
      this.DGRoofsP.Columns[2].ReadOnly = true;
      this.DGRoofsP.Columns[3].ReadOnly = true;
      this.DGSRoofP.DataSource = (object) dataTable20;
      this.DGSRoofP.Columns[0].ReadOnly = true;
      this.DGSRoofP.Columns[1].ReadOnly = true;
      this.DGSRoofP.Columns[2].ReadOnly = true;
      this.DGSRoofP.Columns[2].ReadOnly = true;
      this.DGSFloor.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
      this.DGSFloor.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
      this.DGSFloor.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
      this.DGSFloor.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
      this.DGSFloorI.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
      this.DGSFloorI.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
      this.DGSFloorI.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
      this.DGSFloorI.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
      this.DGSFloorP.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
      this.DGSFloorP.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
      this.DGSFloorP.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
      this.DGSFloorP.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
      this.DGSRoof.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
      this.DGSRoof.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
      this.DGSRoof.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
      this.DGSRoof.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
      this.DGSRoof.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
      this.DGSRoofI.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
      this.DGSRoofI.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
      this.DGSRoofI.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
      this.DGSRoofI.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
      this.DGSRoofP.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
      this.DGSRoofP.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
      this.DGSRoofP.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
      this.DGSRoofP.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
      this.DGSWall.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
      this.DGSWall.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
      this.DGSWall.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
      this.DGSWall.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
      this.DGSWall.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
      this.DGSWall.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;
      int num20 = checked (this.DGWallsI.ColumnCount - 1);
      int index19 = 0;
      while (index19 <= num20)
      {
        this.DGWallsI.Columns[index19].SortMode = DataGridViewColumnSortMode.NotSortable;
        checked { ++index19; }
      }
      int num21 = checked (this.DGWallsP.ColumnCount - 1);
      int index20 = 0;
      while (index20 <= num21)
      {
        this.DGWallsP.Columns[index20].SortMode = DataGridViewColumnSortMode.NotSortable;
        checked { ++index20; }
      }
      this.DGHtbDwellings.DataSource = (object) dataTable22;
      this.DGHtbDwellings.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
      this.DGHtbDwellings.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
      this.DGHtbDwellings.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
      this.DGHtbDwellings.Columns[0].Visible = false;
      this.DGHtbDwellings.Columns[1].ReadOnly = true;
      this.DGHtbDwellings.Columns[1].Width = 180;
      this.DGHtbDwellings.Columns[2].Width = 50;
      this.FillHtb();
    }

    private void FillHtb()
    {
      this.Load_HTBs();
      if (!(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.ManualY & !SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.ManualHtb))
        return;
      this.TabControl1.TabPages.Remove(this.TabPage11);
    }

    private void Load_HTBs()
    {
      this.dtaCalc.Rows.Clear();
      if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.ExternalJunctions == null)
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.ExternalJunctions = new List<SAP_Module.Junction>();
      if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.PartyJunctions == null)
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.PartyJunctions = new List<SAP_Module.Junction>();
      if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.RoofJunctions == null)
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.RoofJunctions = new List<SAP_Module.Junction>();
      try
      {
        this.dtaCalc.Rows.Add(checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.ExternalJunctions.Count + SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.PartyJunctions.Count + SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.RoofJunctions.Count));
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      int num1 = checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.ExternalJunctions.Count - 1);
      int num2 = 0;
      while (num2 <= num1)
      {
        this.dtaCalc[0, num2].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.ExternalJunctions[num2].JunctionDetail;
        this.dtaCalc[6, num2].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.ExternalJunctions[num2].Ref;
        this.dtaCalc[1, num2].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.ExternalJunctions[num2].ThermalTransmittance;
        this.dtaCalc[2, num2].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.ExternalJunctions[num2].Length;
        this.dtaCalc[3, num2].Value = (object) Conversion.Val((object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.ExternalJunctions[num2].IsAccredited);
        this.dtaCalc[4, num2].Value = (object) Conversion.Val((object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.ExternalJunctions[num2].IsDefault);
        this.dtaCalc[5, num2].Value = (object) true;
        checked { ++num2; }
      }
      int rowIndex1 = num2;
      int num3 = checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.PartyJunctions.Count - 1);
      int index1 = 0;
      while (index1 <= num3)
      {
        this.dtaCalc[0, rowIndex1].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.PartyJunctions[index1].JunctionDetail;
        this.dtaCalc[6, rowIndex1].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.PartyJunctions[index1].Ref;
        this.dtaCalc[1, rowIndex1].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.PartyJunctions[index1].ThermalTransmittance;
        this.dtaCalc[2, rowIndex1].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.PartyJunctions[index1].Length;
        this.dtaCalc[3, rowIndex1].Value = (object) Conversion.Val((object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.PartyJunctions[index1].IsAccredited);
        this.dtaCalc[4, rowIndex1].Value = (object) Conversion.Val((object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.PartyJunctions[index1].IsDefault);
        this.dtaCalc[5, rowIndex1].Value = (object) true;
        checked { ++rowIndex1; }
        checked { ++index1; }
      }
      int rowIndex2 = rowIndex1;
      int num4 = checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.RoofJunctions.Count - 1);
      int index2 = 0;
      while (index2 <= num4)
      {
        this.dtaCalc[0, rowIndex2].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.RoofJunctions[index2].JunctionDetail;
        this.dtaCalc[6, rowIndex2].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.RoofJunctions[index2].Ref;
        this.dtaCalc[1, rowIndex2].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.RoofJunctions[index2].ThermalTransmittance;
        this.dtaCalc[2, rowIndex2].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.RoofJunctions[index2].Length;
        this.dtaCalc[3, rowIndex2].Value = (object) Conversion.Val((object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.RoofJunctions[index2].IsAccredited);
        this.dtaCalc[4, rowIndex2].Value = (object) Conversion.Val((object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.RoofJunctions[index2].IsDefault);
        this.dtaCalc[5, rowIndex2].Value = (object) true;
        checked { ++rowIndex2; }
        checked { ++index2; }
      }
    }

    private void chk_Heating_Full_CheckedChanged(object sender, EventArgs e)
    {
      if (!this.chk_Heating_Full.Checked)
        return;
      this.chk_Heating_Controls.Checked = true;
      this.chk_Heating_Fuel.Checked = true;
    }

    private void chk_Heating_Controls_CheckedChanged(object sender, EventArgs e)
    {
      if (this.chk_Heating_Controls.Checked)
        return;
      this.chk_Heating_Full.Checked = false;
    }

    private void chk_Heating_Fuel_CheckedChanged(object sender, EventArgs e)
    {
      if (this.chk_Heating_Fuel.Checked)
        return;
      this.chk_Heating_Full.Checked = false;
    }

    private void cmdSAll_Click(object sender, EventArgs e)
    {
      int num = checked (this.DG1.RowCount - 1);
      int rowIndex = 0;
      while (rowIndex <= num)
      {
        this.DG1[2, rowIndex].Value = (object) true;
        checked { ++rowIndex; }
      }
    }

    private void Button2_Click(object sender, EventArgs e)
    {
      int num = checked (this.DGFloors.RowCount - 1);
      int rowIndex = 0;
      while (rowIndex <= num)
      {
        this.DGFloors[4, rowIndex].Value = (object) true;
        checked { ++rowIndex; }
      }
    }

    private void cmdSNone_Click(object sender, EventArgs e)
    {
      int num = checked (this.DG1.RowCount - 1);
      int rowIndex = 0;
      while (rowIndex <= num)
      {
        this.DG1[2, rowIndex].Value = (object) false;
        checked { ++rowIndex; }
      }
    }

    private void Button3_Click(object sender, EventArgs e)
    {
      int num = checked (this.DGFloors.RowCount - 1);
      int rowIndex = 0;
      while (rowIndex <= num)
      {
        this.DGFloors[4, rowIndex].Value = (object) false;
        checked { ++rowIndex; }
      }
    }

    private void Button5_Click(object sender, EventArgs e)
    {
      int num = checked (this.DGWalls.RowCount - 1);
      int rowIndex = 0;
      while (rowIndex <= num)
      {
        this.DGWalls[4, rowIndex].Value = (object) true;
        checked { ++rowIndex; }
      }
    }

    private void Button6_Click(object sender, EventArgs e)
    {
      int num = checked (this.DGWalls.RowCount - 1);
      int rowIndex = 0;
      while (rowIndex <= num)
      {
        this.DGWalls[4, rowIndex].Value = (object) false;
        checked { ++rowIndex; }
      }
    }

    private void Button8_Click(object sender, EventArgs e)
    {
      int num = checked (this.DGRoofs.RowCount - 1);
      int rowIndex = 0;
      while (rowIndex <= num)
      {
        this.DGRoofs[4, rowIndex].Value = (object) true;
        checked { ++rowIndex; }
      }
    }

    private void Button9_Click(object sender, EventArgs e)
    {
      int num = checked (this.DGRoofs.RowCount - 1);
      int rowIndex = 0;
      while (rowIndex <= num)
      {
        this.DGRoofs[4, rowIndex].Value = (object) false;
        checked { ++rowIndex; }
      }
    }

    private void cmd_RW_Copy_Click(object sender, EventArgs e)
    {
      SAP_Module.Dwelling dwelling1 = new SAP_Module.Dwelling();
      SAP_Module.Dwelling dwelling2 = Functions.CopyDwelling(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling]);
      int num1 = checked (this.DG1.RowCount - 1);
      int rowIndex = 0;
      int num2;
      while (rowIndex <= num1)
      {
        if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DG1[2, rowIndex].Value)) && Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DG1[2, rowIndex].Value, (object) true, false))
        {
          int integer = Conversions.ToInteger(this.DG1[0, rowIndex].Value);
          checked { ++num2; }
          if (this.chk_Vent_Chimneys.Checked)
          {
            SAP_Module.Proj.Dwellings[integer].Ventilation.Chimneys = dwelling2.Ventilation.Chimneys;
            SAP_Module.Proj.Dwellings[integer].Ventilation.ChimneysMain = dwelling2.Ventilation.ChimneysMain;
            SAP_Module.Proj.Dwellings[integer].Ventilation.ChimneysSec = dwelling2.Ventilation.ChimneysSec;
            SAP_Module.Proj.Dwellings[integer].Ventilation.ChimneysOther = dwelling2.Ventilation.ChimneysOther;
          }
          if (this.chk_Vent_OpenFlues.Checked)
          {
            SAP_Module.Proj.Dwellings[integer].Ventilation.Flues = dwelling2.Ventilation.Flues;
            SAP_Module.Proj.Dwellings[integer].Ventilation.FluesMain = dwelling2.Ventilation.FluesMain;
            SAP_Module.Proj.Dwellings[integer].Ventilation.FluesSec = dwelling2.Ventilation.FluesSec;
            SAP_Module.Proj.Dwellings[integer].Ventilation.FluesOther = dwelling2.Ventilation.FluesOther;
          }
          if (this.txtBuildetails.Checked)
          {
            SAP_Module.Proj.Dwellings[integer].BuildForm = dwelling2.BuildForm;
            SAP_Module.Proj.Dwellings[integer].FlatType = dwelling2.FlatType;
            SAP_Module.Proj.Dwellings[integer].PropertyType = dwelling2.PropertyType;
          }
          if (this.chk_Vent_Fans.Checked)
            SAP_Module.Proj.Dwellings[integer].Ventilation.Fans = dwelling2.Ventilation.Fans;
          if (this.chkapprovedInstaller.Checked)
            SAP_Module.Proj.Dwellings[integer].Ventilation.ApprovedScheme = dwelling2.Ventilation.ApprovedScheme;
          if (this.chk_Vent_PassiveVents.Checked)
            SAP_Module.Proj.Dwellings[integer].Ventilation.Vents = dwelling2.Ventilation.Vents;
          if (this.chk_Vent_GasFires.Checked)
            SAP_Module.Proj.Dwellings[integer].Ventilation.Fires = dwelling2.Ventilation.Fires;
          if (this.chk_Vent_ShelteredSides.Checked)
            SAP_Module.Proj.Dwellings[integer].Ventilation.Shelter = dwelling2.Ventilation.Shelter;
          if (this.chk_Vent_Mechanical.Checked)
          {
            SAP_Module.Proj.Dwellings[integer].Ventilation.Decentralised = dwelling2.Ventilation.Decentralised;
            SAP_Module.Proj.Dwellings[integer].Ventilation.ProductID = dwelling2.Ventilation.ProductID;
            SAP_Module.Proj.Dwellings[integer].Ventilation.WetRooms = dwelling2.Ventilation.WetRooms;
            SAP_Module.Proj.Dwellings[integer].Ventilation.DuctType = dwelling2.Ventilation.DuctType;
            SAP_Module.Proj.Dwellings[integer].Ventilation.ProductName = dwelling2.Ventilation.ProductName;
            SAP_Module.Proj.Dwellings[integer].Ventilation.MechVent = dwelling2.Ventilation.MechVent;
            SAP_Module.Proj.Dwellings[integer].Ventilation.Parameters = dwelling2.Ventilation.Parameters;
            SAP_Module.Proj.Dwellings[integer].Ventilation.MVDetails = dwelling2.Ventilation.MVDetails;
            string mechVent = SAP_Module.Proj.Dwellings[integer].Ventilation.MechVent;
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(mechVent, "Balanced with heat recovery", false) == 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(mechVent, "Centralised whole house extract", false) == 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(mechVent, "Decentralised whole house extract", false) == 0)
              SAP_Module.Proj.Dwellings[integer].Ventilation.Fans = 0;
          }
          if (this.chk_Vent_AirPerm.Checked)
          {
            SAP_Module.Proj.Dwellings[integer].Ventilation.Pressure = dwelling2.Ventilation.Pressure;
            SAP_Module.Proj.Dwellings[integer].Ventilation.DesignAir = dwelling2.Ventilation.DesignAir;
            SAP_Module.Proj.Dwellings[integer].Ventilation.MeasuredAir = dwelling2.Ventilation.MeasuredAir;
            SAP_Module.Proj.Dwellings[integer].Ventilation.DateAir = dwelling2.Ventilation.DateAir;
            SAP_Module.Proj.Dwellings[integer].Ventilation.AssumedAir = dwelling2.Ventilation.AssumedAir;
            SAP_Module.Proj.Dwellings[integer].Ventilation.Infiltration.Construction = dwelling2.Ventilation.Infiltration.Construction;
            SAP_Module.Proj.Dwellings[integer].Ventilation.Infiltration.Lobby = dwelling2.Ventilation.Infiltration.Lobby;
            SAP_Module.Proj.Dwellings[integer].Ventilation.Infiltration.Floor = dwelling2.Ventilation.Infiltration.Floor;
            SAP_Module.Proj.Dwellings[integer].Ventilation.Infiltration.DraguthP = dwelling2.Ventilation.Infiltration.DraguthP;
            SAP_Module.Proj.Dwellings[integer].Ventilation.Draught = dwelling2.Ventilation.Draught;
            SAP_Module.Proj.Dwellings[integer].Ventilation.AveragePerm = dwelling2.Ventilation.AveragePerm;
            SAP_Module.Proj.Dwellings[integer].Status = dwelling2.Status;
          }
          if (this.ChkAssessmentType.Checked)
          {
            SAP_Module.Proj.Dwellings[integer].Status = dwelling2.Status;
            SAP_Module.Proj.Dwellings[integer].DateAssessment = dwelling2.DateAssessment;
            SAP_Module.Proj.Dwellings[integer].DateCertificate = dwelling2.DateCertificate;
          }
          if (this.chkbuilt.Checked)
          {
            SAP_Module.Proj.Dwellings[integer].BuildForm = dwelling2.BuildForm;
            SAP_Module.Proj.Dwellings[integer].FlatType = dwelling2.FlatType;
            SAP_Module.Proj.Dwellings[integer].PropertyType = dwelling2.PropertyType;
          }
          if (this.chk_Water_Heating.Checked)
            SAP_Module.Proj.Dwellings[integer].Water = dwelling2.Water;
          if (this.chk_Water_SolarPanel.Checked)
            SAP_Module.Proj.Dwellings[integer].Water.Solar = dwelling2.Water.Solar;
          if (this.chkAddress.Checked)
            SAP_Module.Proj.Dwellings[integer].Address = dwelling2.Address;
          if (this.ChkBuildingDetails.Checked)
            SAP_Module.Proj.Dwellings[integer].YearBuilt = dwelling2.YearBuilt;
          if (this.ChkLocationDetails.Checked)
          {
            SAP_Module.Proj.Dwellings[integer].Location = dwelling2.Location;
            SAP_Module.Proj.Dwellings[integer].Terrain = dwelling2.Terrain;
            SAP_Module.Proj.Dwellings[integer].Orientation = dwelling2.Orientation;
            SAP_Module.Proj.Dwellings[integer].SmokeArea = dwelling2.SmokeArea;
            SAP_Module.Proj.Dwellings[integer].Overshading = dwelling2.Overshading;
            SAP_Module.Proj.Dwellings[integer].LessThan125Litre = dwelling2.LessThan125Litre;
          }
          if (this.ChkDwelling.Checked)
          {
            SAP_Module.Proj.Dwellings[integer].EPCLanguage = dwelling2.EPCLanguage;
            SAP_Module.Proj.Dwellings[integer].DateAssessment = dwelling2.DateAssessment;
            SAP_Module.Proj.Dwellings[integer].DateCertificate = dwelling2.DateCertificate;
            SAP_Module.Proj.Dwellings[integer].TMP = dwelling2.TMP;
            SAP_Module.Proj.Dwellings[integer].Transaction = dwelling2.Transaction;
            SAP_Module.Proj.Dwellings[integer].Tenure = dwelling2.Tenure;
            SAP_Module.Proj.Dwellings[integer].RPD = dwelling2.RPD;
            SAP_Module.Proj.Dwellings[integer].Status = dwelling2.Status;
            SAP_Module.Proj.Dwellings[integer].Overheat = dwelling2.Overheat;
            SAP_Module.Proj.Dwellings[integer].Reference = dwelling2.Reference;
            SAP_Module.Proj.Dwellings[integer].YearBuilt = dwelling2.YearBuilt;
          }
          if (this.chk_WWHR.Checked)
            SAP_Module.Proj.Dwellings[integer].Water.WWHRS = dwelling2.Water.WWHRS;
          if (this.chk_FGHRS.Checked)
            SAP_Module.Proj.Dwellings[integer].Water.FGHRS = dwelling2.Water.FGHRS;
          if (this.ChkCooling.Checked)
            SAP_Module.Proj.Dwellings[integer].Cooling = dwelling2.Cooling;
          if (this.chk_Renew_AAEG.Checked)
            SAP_Module.Proj.Dwellings[integer].Renewable.AAEGeneration = dwelling2.Renewable.AAEGeneration;
          if (this.chkHydro.Checked)
            SAP_Module.Proj.Dwellings[integer].Renewable.HydroGeneration = dwelling2.Renewable.HydroGeneration;
          if (this.chk_Renew_AppQ.Checked)
            SAP_Module.Proj.Dwellings[integer].Renewable.Special = dwelling2.Renewable.Special;
          if (this.chk_Renew_Photo.Checked)
          {
            SAP_Module.Proj.Dwellings[integer].Renewable.Photovoltaic.Inlcude = dwelling2.Renewable.Photovoltaic.Inlcude;
            try
            {
              int num3 = checked (dwelling2.Renewable.Photovoltaic.Photovoltaics.Length - 1);
              int index = 0;
              while (index <= num3)
              {
                if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Photovoltaic.Photovoltaics == null)
                {
                  // ISSUE: variable of a reference type
                  SAP_Module.PhotoVoltaics[]& local;
                  // ISSUE: explicit reference operation
                  SAP_Module.PhotoVoltaics[] photoVoltaicsArray = (SAP_Module.PhotoVoltaics[]) Utils.CopyArray((Array) ^(local = ref SAP_Module.Proj.Dwellings[integer].Renewable.Photovoltaic.Photovoltaics), (Array) new SAP_Module.PhotoVoltaics[1]);
                  local = photoVoltaicsArray;
                }
                else
                {
                  // ISSUE: variable of a reference type
                  SAP_Module.PhotoVoltaics[]& local;
                  // ISSUE: explicit reference operation
                  SAP_Module.PhotoVoltaics[] photoVoltaicsArray = (SAP_Module.PhotoVoltaics[]) Utils.CopyArray((Array) ^(local = ref SAP_Module.Proj.Dwellings[integer].Renewable.Photovoltaic.Photovoltaics), (Array) new SAP_Module.PhotoVoltaics[checked (dwelling2.Renewable.Photovoltaic.Photovoltaics.Length - 1 + 1)]);
                  local = photoVoltaicsArray;
                }
                SAP_Module.Proj.Dwellings[integer].Renewable.Photovoltaic.Photovoltaics[index].PCOrientation = dwelling2.Renewable.Photovoltaic.Photovoltaics[index].PCOrientation;
                SAP_Module.Proj.Dwellings[integer].Renewable.Photovoltaic.Photovoltaics[index].POvershading = dwelling2.Renewable.Photovoltaic.Photovoltaics[index].POvershading;
                SAP_Module.Proj.Dwellings[integer].Renewable.Photovoltaic.Photovoltaics[index].PPower = dwelling2.Renewable.Photovoltaic.Photovoltaics[index].PPower;
                SAP_Module.Proj.Dwellings[integer].Renewable.Photovoltaic.Photovoltaics[index].PTilt = dwelling2.Renewable.Photovoltaic.Photovoltaics[index].PTilt;
                SAP_Module.Proj.Dwellings[integer].Renewable.Photovoltaic.Photovoltaics[index].DirectlyConnected = dwelling2.Renewable.Photovoltaic.Photovoltaics[index].DirectlyConnected;
                SAP_Module.Proj.Dwellings[integer].Renewable.Photovoltaic.Photovoltaics[index].FlatConnection = dwelling2.Renewable.Photovoltaic.Photovoltaics[index].FlatConnection;
                SAP_Module.Proj.Dwellings[integer].Renewable.Photovoltaic.Photovoltaics[index].ID = dwelling2.Renewable.Photovoltaic.Photovoltaics[index].ID;
                checked { ++index; }
              }
            }
            catch (Exception ex)
            {
              ProjectData.SetProjectError(ex);
              ProjectData.ClearProjectError();
            }
          }
          if (this.chk_Renew_Wind.Checked)
            SAP_Module.Proj.Dwellings[integer].Renewable.WindTurbine = dwelling2.Renewable.WindTurbine;
          if (this.chk_OverH_AirChangeRate.Checked)
          {
            SAP_Module.Proj.Dwellings[integer].OverHeating.EACBuildType = dwelling2.OverHeating.EACBuildType;
            SAP_Module.Proj.Dwellings[integer].OverHeating.EACWindow = dwelling2.OverHeating.EACWindow;
            SAP_Module.Proj.Dwellings[integer].OverHeating.EACOveride = dwelling2.OverHeating.EACOveride;
            SAP_Module.Proj.Dwellings[integer].OverHeating.EACAirChange = dwelling2.OverHeating.EACAirChange;
          }
          if (this.chk_Vent_ThermalMass.Checked)
          {
            SAP_Module.Proj.Dwellings[integer].OverHeating.TMIllustrative = dwelling2.OverHeating.TMIllustrative;
            SAP_Module.Proj.Dwellings[integer].OverHeating.TMOveride = dwelling2.OverHeating.TMOveride;
            SAP_Module.Proj.Dwellings[integer].OverHeating.TMTMP = dwelling2.OverHeating.TMTMP;
            SAP_Module.Proj.Dwellings[integer].TMP.Type = dwelling2.TMP.Type;
            SAP_Module.Proj.Dwellings[integer].TMP.Indicative = dwelling2.TMP.Indicative;
            SAP_Module.Proj.Dwellings[integer].TMP.UserDefined = dwelling2.TMP.UserDefined;
          }
          if (this.txtTranstype.Checked)
            SAP_Module.Proj.Dwellings[integer].Transaction = dwelling2.Transaction;
          if (this.txtTenure.Checked)
            SAP_Module.Proj.Dwellings[integer].Tenure = dwelling2.Tenure;
          if (this.txtRPD.Checked)
            SAP_Module.Proj.Dwellings[integer].RPD = dwelling2.RPD;
          if (this.chkcounty.Checked)
            SAP_Module.Proj.Dwellings[integer].Address.Country = dwelling2.Address.Country;
          if (this.txtLanguage.Checked)
            SAP_Module.Proj.Dwellings[integer].EPCLanguage = dwelling2.EPCLanguage;
          if (this.Chkoverheat.Checked)
            SAP_Module.Proj.Dwellings[integer].Overheat = dwelling2.Overheat;
          if (this.chk_Other_Conserv.Checked)
            SAP_Module.Proj.Dwellings[integer].Conservatory = dwelling2.Conservatory;
          if (this.chk_Other_FixedAir.Checked)
            SAP_Module.Proj.Dwellings[integer].AirCon = dwelling2.AirCon;
          if (this.chk_Other_LEL.Checked)
          {
            SAP_Module.Proj.Dwellings[integer].LowEnergyLight = dwelling2.LowEnergyLight;
            SAP_Module.Proj.Dwellings[integer].LELOutlets = dwelling2.LELOutlets;
            SAP_Module.Proj.Dwellings[integer].LELLights = dwelling2.LELLights;
          }
          if (this.chk_Heating_Full.Checked)
            SAP_Module.Proj.Dwellings[integer].MainHeating = dwelling2.MainHeating;
          if (this.chk_Heating_SecMain.Checked)
          {
            SAP_Module.Proj.Dwellings[integer].MainHeating2 = dwelling2.MainHeating2;
            SAP_Module.Proj.Dwellings[integer].IncludeMainHeating2 = true;
            if (!dwelling2.IncludeMainHeating2)
              SAP_Module.Proj.Dwellings[integer].IncludeMainHeating2 = false;
            if (SAP_Module.Proj.Dwellings[integer].IncludeMainHeating2)
              SAP_Module.Proj.Dwellings[integer].HeatFractionSec = dwelling2.HeatFractionSec;
          }
          if (this.chk_Heating_Controls.Checked)
          {
            SAP_Module.Proj.Dwellings[integer].MainHeating.ControlCode = dwelling2.MainHeating.ControlCode;
            SAP_Module.Proj.Dwellings[integer].MainHeating.Controls = dwelling2.MainHeating.Controls;
          }
          if (this.chk_Heating_Fuel.Checked)
            SAP_Module.Proj.Dwellings[integer].MainHeating.Fuel = dwelling2.MainHeating.Fuel;
          if (this.chk_Heating_Tarrif.Checked)
            SAP_Module.Proj.Dwellings[integer].MainHeating.ElectricityTariff = dwelling2.MainHeating.ElectricityTariff;
          if (this.chk_Heating_Secondary.Checked)
            SAP_Module.Proj.Dwellings[integer].SecHeating = dwelling2.SecHeating;
          if (this.chk_Thermal.Checked)
            SAP_Module.Proj.Dwellings[integer].Thermal = dwelling2.Thermal;
        }
        checked { ++rowIndex; }
      }
      int num4 = (int) Interaction.MsgBox((object) ("Items Copied to " + Conversions.ToString(num2) + " dwellings"), MsgBoxStyle.Information);
    }

    private void chk_Water_Heating_CheckedChanged(object sender, EventArgs e)
    {
      if (!this.chk_Water_Heating.Checked)
        ;
    }

    private void chk_Water_SolarPanel_CheckedChanged(object sender, EventArgs e)
    {
      if (this.chk_Water_SolarPanel.Checked)
        ;
    }

    private void Button4_Click(object sender, EventArgs e)
    {
      if (this.DGSFloor.SelectedRows[0].Index == -1)
      {
        int num1 = (int) Interaction.MsgBox((object) "Please select a floor to copy details from!");
      }
      else
      {
        SAP_Module.Dwelling dwelling1 = new SAP_Module.Dwelling();
        SAP_Module.Dwelling dwelling2 = Functions.CopyDwelling(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling]);
        int index = this.DGSFloor.SelectedRows[0].Index;
        int num2 = checked (this.DGFloors.RowCount - 1);
        int rowIndex = 0;
        int num3;
        while (rowIndex <= num2)
        {
          if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DGFloors[4, rowIndex].Value)) && Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DGFloors[4, rowIndex].Value, (object) true, false))
          {
            int integer1 = Conversions.ToInteger(this.DGFloors[0, rowIndex].Value);
            int integer2 = Conversions.ToInteger(this.DGFloors[1, rowIndex].Value);
            checked { ++num3; }
            if (this.chk_Floors_Type.Checked)
              SAP_Module.Proj.Dwellings[integer1].Floors[integer2].Type = dwelling2.Floors[index].Type;
            if (this.chk_Floors_Construction.Checked)
              SAP_Module.Proj.Dwellings[integer1].Floors[integer2].Construction = dwelling2.Floors[index].Construction;
            if (this.chk_Floors_Area.Checked)
              SAP_Module.Proj.Dwellings[integer1].Floors[integer2].Area = dwelling2.Floors[index].Area;
            if (this.chk_Floors_U.Checked)
              SAP_Module.Proj.Dwellings[integer1].Floors[integer2].U_Value = dwelling2.Floors[index].U_Value;
            if (this.chk_Floors_Kappa.Checked)
              SAP_Module.Proj.Dwellings[integer1].Floors[integer2].K = dwelling2.Floors[index].K;
          }
          checked { ++rowIndex; }
        }
        int num4 = (int) Interaction.MsgBox((object) ("Floor properties Copied to " + Conversions.ToString(num3) + " floors"), MsgBoxStyle.Information);
      }
    }

    private void Button7_Click(object sender, EventArgs e)
    {
      if (this.DGSWall.SelectedRows[0].Index == -1)
      {
        int num1 = (int) Interaction.MsgBox((object) "Please select a wall to copy details from!");
      }
      else
      {
        SAP_Module.Dwelling dwelling1 = new SAP_Module.Dwelling();
        SAP_Module.Dwelling dwelling2 = Functions.CopyDwelling(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling]);
        int index = this.DGSWall.SelectedRows[0].Index;
        int num2 = checked (this.DGWalls.RowCount - 1);
        int rowIndex = 0;
        int num3;
        while (rowIndex <= num2)
        {
          if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DGWalls[4, rowIndex].Value)) && Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DGWalls[4, rowIndex].Value, (object) true, false))
          {
            int integer1 = Conversions.ToInteger(this.DGWalls[0, rowIndex].Value);
            int integer2 = Conversions.ToInteger(this.DGWalls[1, rowIndex].Value);
            checked { ++num3; }
            if (this.chk_Walls_Type.Checked)
              SAP_Module.Proj.Dwellings[integer1].Walls[integer2].Type = dwelling2.Walls[index].Type;
            if (this.chk_Walls_Construction.Checked)
              SAP_Module.Proj.Dwellings[integer1].Walls[integer2].Construction = dwelling2.Walls[index].Construction;
            if (this.chk_Walls_Area.Checked)
              SAP_Module.Proj.Dwellings[integer1].Walls[integer2].Area = dwelling2.Walls[index].Area;
            if (this.chk_Walls_UValue.Checked)
              SAP_Module.Proj.Dwellings[integer1].Walls[integer2].U_Value = dwelling2.Walls[index].U_Value;
            if (this.chk_Walls_Ru.Checked)
              SAP_Module.Proj.Dwellings[integer1].Walls[integer2].Ru = dwelling2.Walls[index].Ru;
            if (this.chk_Walls_Kappa.Checked)
              SAP_Module.Proj.Dwellings[integer1].Walls[integer2].K = dwelling2.Walls[index].K;
            if (this.chk_Walls_Curtain.Checked)
              SAP_Module.Proj.Dwellings[integer1].Walls[integer2].Curtain = dwelling2.Walls[index].Curtain;
          }
          checked { ++rowIndex; }
        }
        int num4 = (int) Interaction.MsgBox((object) ("Wall properties Copied to " + Conversions.ToString(num3) + " walls"), MsgBoxStyle.Information);
      }
    }

    private void Button10_Click(object sender, EventArgs e)
    {
      if (this.DGSRoof.SelectedRows[0].Index == -1)
      {
        int num1 = (int) Interaction.MsgBox((object) "Please select a roof to copy details from!");
      }
      else
      {
        SAP_Module.Dwelling dwelling1 = new SAP_Module.Dwelling();
        SAP_Module.Dwelling dwelling2 = Functions.CopyDwelling(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling]);
        int index = this.DGSRoof.SelectedRows[0].Index;
        int num2 = checked (this.DGRoofs.RowCount - 1);
        int rowIndex = 0;
        int num3;
        while (rowIndex <= num2)
        {
          if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DGRoofs[4, rowIndex].Value)) && Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DGRoofs[4, rowIndex].Value, (object) true, false))
          {
            int integer1 = Conversions.ToInteger(this.DGRoofs[0, rowIndex].Value);
            int integer2 = Conversions.ToInteger(this.DGRoofs[1, rowIndex].Value);
            checked { ++num3; }
            if (this.chk_Roofs_Type.Checked)
              SAP_Module.Proj.Dwellings[integer1].Roofs[integer2].Type = dwelling2.Roofs[index].Type;
            if (this.chk_Roofs_Construction.Checked)
              SAP_Module.Proj.Dwellings[integer1].Roofs[integer2].Construction = dwelling2.Roofs[index].Construction;
            if (this.chk_Roofs_Area.Checked)
              SAP_Module.Proj.Dwellings[integer1].Roofs[integer2].Area = dwelling2.Roofs[index].Area;
            if (this.chk_Roofs_UValue.Checked)
              SAP_Module.Proj.Dwellings[integer1].Roofs[integer2].U_Value = dwelling2.Roofs[index].U_Value;
            if (this.chk_Roofs_Ru.Checked)
              SAP_Module.Proj.Dwellings[integer1].Roofs[integer2].Ru = dwelling2.Roofs[index].Ru;
            if (this.chk_Roofs_Kappa.Checked)
              SAP_Module.Proj.Dwellings[integer1].Roofs[integer2].K = dwelling2.Roofs[index].K;
          }
          checked { ++rowIndex; }
        }
        int num4 = (int) Interaction.MsgBox((object) ("Roof properties Copied to " + Conversions.ToString(num3) + " roofs"), MsgBoxStyle.Information);
      }
    }

    private void Button12_Click(object sender, EventArgs e)
    {
      int num = checked (this.DGFloorsI.RowCount - 1);
      int rowIndex = 0;
      while (rowIndex <= num)
      {
        this.DGFloorsI[4, rowIndex].Value = (object) true;
        checked { ++rowIndex; }
      }
    }

    private void Button13_Click(object sender, EventArgs e)
    {
      int num = checked (this.DGFloorsI.RowCount - 1);
      int rowIndex = 0;
      while (rowIndex <= num)
      {
        this.DGFloorsI[4, rowIndex].Value = (object) false;
        checked { ++rowIndex; }
      }
    }

    private void Button15_Click(object sender, EventArgs e)
    {
      int num = checked (this.DGFloorsP.RowCount - 1);
      int rowIndex = 0;
      while (rowIndex <= num)
      {
        this.DGFloorsP[4, rowIndex].Value = (object) true;
        checked { ++rowIndex; }
      }
    }

    private void Button16_Click(object sender, EventArgs e)
    {
      int num = checked (this.DGFloorsP.RowCount - 1);
      int rowIndex = 0;
      while (rowIndex <= num)
      {
        this.DGFloorsP[4, rowIndex].Value = (object) false;
        checked { ++rowIndex; }
      }
    }

    private void Button18_Click(object sender, EventArgs e)
    {
      int num = checked (this.DGWallsI.RowCount - 1);
      int rowIndex = 0;
      while (rowIndex <= num)
      {
        this.DGWallsI[4, rowIndex].Value = (object) true;
        checked { ++rowIndex; }
      }
    }

    private void Button19_Click(object sender, EventArgs e)
    {
      int num = checked (this.DGWallsI.RowCount - 1);
      int rowIndex = 0;
      while (rowIndex <= num)
      {
        this.DGWallsI[4, rowIndex].Value = (object) false;
        checked { ++rowIndex; }
      }
    }

    private void Button21_Click(object sender, EventArgs e)
    {
      int num = checked (this.DGWallsP.RowCount - 1);
      int rowIndex = 0;
      while (rowIndex <= num)
      {
        this.DGWallsP[4, rowIndex].Value = (object) true;
        checked { ++rowIndex; }
      }
    }

    private void Button22_Click(object sender, EventArgs e)
    {
      int num = checked (this.DGWallsP.RowCount - 1);
      int rowIndex = 0;
      while (rowIndex <= num)
      {
        this.DGWallsP[4, rowIndex].Value = (object) false;
        checked { ++rowIndex; }
      }
    }

    private void Button24_Click(object sender, EventArgs e)
    {
      int num = checked (this.DGRoofsI.RowCount - 1);
      int rowIndex = 0;
      while (rowIndex <= num)
      {
        this.DGRoofsI[4, rowIndex].Value = (object) true;
        checked { ++rowIndex; }
      }
    }

    private void Button25_Click(object sender, EventArgs e)
    {
      int num = checked (this.DGRoofsI.RowCount - 1);
      int rowIndex = 0;
      while (rowIndex <= num)
      {
        this.DGRoofsI[4, rowIndex].Value = (object) false;
        checked { ++rowIndex; }
      }
    }

    private void Button27_Click(object sender, EventArgs e)
    {
      int num = checked (this.DGRoofsP.RowCount - 1);
      int rowIndex = 0;
      while (rowIndex <= num)
      {
        this.DGRoofsP[4, rowIndex].Value = (object) true;
        checked { ++rowIndex; }
      }
    }

    private void Button28_Click(object sender, EventArgs e)
    {
      int num = checked (this.DGRoofsP.RowCount - 1);
      int rowIndex = 0;
      while (rowIndex <= num)
      {
        this.DGRoofsP[4, rowIndex].Value = (object) false;
        checked { ++rowIndex; }
      }
    }

    private void Button14_Click(object sender, EventArgs e)
    {
      if (this.DGSFloorI.SelectedRows[0].Index == -1)
      {
        int num1 = (int) Interaction.MsgBox((object) "Please select a floor to copy details from!");
      }
      else
      {
        SAP_Module.Dwelling dwelling1 = new SAP_Module.Dwelling();
        SAP_Module.Dwelling dwelling2 = Functions.CopyDwelling(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling]);
        int index = this.DGSFloorI.SelectedRows[0].Index;
        int num2 = checked (this.DGFloorsI.RowCount - 1);
        int rowIndex = 0;
        int num3;
        while (rowIndex <= num2)
        {
          if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DGFloorsI[4, rowIndex].Value)) && Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DGFloorsI[4, rowIndex].Value, (object) true, false))
          {
            int integer1 = Conversions.ToInteger(this.DGFloorsI[0, rowIndex].Value);
            int integer2 = Conversions.ToInteger(this.DGFloorsI[1, rowIndex].Value);
            checked { ++num3; }
            if (this.chk_IFloors_Construction.Checked)
              SAP_Module.Proj.Dwellings[integer1].IFloors[integer2].Construction = dwelling2.IFloors[index].Construction;
            if (this.chk_IFloors_Area.Checked)
              SAP_Module.Proj.Dwellings[integer1].IFloors[integer2].Area = dwelling2.IFloors[index].Area;
            if (this.chk_IFloors_Kappa.Checked)
              SAP_Module.Proj.Dwellings[integer1].IFloors[integer2].K = dwelling2.IFloors[index].K;
          }
          checked { ++rowIndex; }
        }
        int num4 = (int) Interaction.MsgBox((object) ("Floor properties Copied to " + Conversions.ToString(num3) + " floors"), MsgBoxStyle.Information);
      }
    }

    private void Button17_Click(object sender, EventArgs e)
    {
      if (this.DGSFloorP.SelectedRows[0].Index == -1)
      {
        int num1 = (int) Interaction.MsgBox((object) "Please select a floor to copy details from!");
      }
      else
      {
        SAP_Module.Dwelling dwelling1 = new SAP_Module.Dwelling();
        SAP_Module.Dwelling dwelling2 = Functions.CopyDwelling(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling]);
        int index = this.DGSFloorP.SelectedRows[0].Index;
        int num2 = checked (this.DGFloorsP.RowCount - 1);
        int rowIndex = 0;
        int num3;
        while (rowIndex <= num2)
        {
          if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DGFloorsP[4, rowIndex].Value)) && Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DGFloorsP[4, rowIndex].Value, (object) true, false))
          {
            int integer1 = Conversions.ToInteger(this.DGFloorsP[0, rowIndex].Value);
            int integer2 = Conversions.ToInteger(this.DGFloorsP[1, rowIndex].Value);
            checked { ++num3; }
            if (this.chk_PFloors_Construction.Checked)
              SAP_Module.Proj.Dwellings[integer1].PFloors[integer2].Construction = dwelling2.PFloors[index].Construction;
            if (this.chk_PFloors_Area.Checked)
              SAP_Module.Proj.Dwellings[integer1].PFloors[integer2].Area = dwelling2.PFloors[index].Area;
            if (this.chk_PFloors_Kappa.Checked)
              SAP_Module.Proj.Dwellings[integer1].PFloors[integer2].K = dwelling2.PFloors[index].K;
          }
          checked { ++rowIndex; }
        }
        int num4 = (int) Interaction.MsgBox((object) ("Floor properties Copied to " + Conversions.ToString(num3) + " floors"), MsgBoxStyle.Information);
      }
    }

    private void Button20_Click(object sender, EventArgs e)
    {
      if (this.DGSWallI.SelectedRows[0].Index == -1)
      {
        int num1 = (int) Interaction.MsgBox((object) "Please select a wall to copy details from!");
      }
      else
      {
        SAP_Module.Dwelling dwelling1 = new SAP_Module.Dwelling();
        SAP_Module.Dwelling dwelling2 = Functions.CopyDwelling(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling]);
        int index = this.DGSWallI.SelectedRows[0].Index;
        int num2 = checked (this.DGWallsI.RowCount - 1);
        int rowIndex = 0;
        int num3;
        while (rowIndex <= num2)
        {
          if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DGWallsI[4, rowIndex].Value)) && Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DGWallsI[4, rowIndex].Value, (object) true, false))
          {
            int integer1 = Conversions.ToInteger(this.DGWallsI[0, rowIndex].Value);
            int integer2 = Conversions.ToInteger(this.DGWallsI[1, rowIndex].Value);
            checked { ++num3; }
            if (this.chk_IWalls_Construction.Checked)
              SAP_Module.Proj.Dwellings[integer1].IWalls[integer2].Construction = dwelling2.IWalls[index].Construction;
            if (this.chk_IWalls_Area.Checked)
              SAP_Module.Proj.Dwellings[integer1].IWalls[integer2].Area = dwelling2.IWalls[index].Area;
            if (this.chk_IWalls_Kappa.Checked)
              SAP_Module.Proj.Dwellings[integer1].IWalls[integer2].K = dwelling2.IWalls[index].K;
          }
          checked { ++rowIndex; }
        }
        int num4 = (int) Interaction.MsgBox((object) ("Wall properties Copied to " + Conversions.ToString(num3) + " walls"), MsgBoxStyle.Information);
      }
    }

    private void Button23_Click(object sender, EventArgs e)
    {
      if (this.DGSWallP.SelectedRows[0].Index == -1)
      {
        int num1 = (int) Interaction.MsgBox((object) "Please select a wall to copy details from!");
      }
      else
      {
        SAP_Module.Dwelling dwelling1 = new SAP_Module.Dwelling();
        SAP_Module.Dwelling dwelling2 = Functions.CopyDwelling(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling]);
        int index = this.DGSWallP.SelectedRows[0].Index;
        int num2 = checked (this.DGWallsP.RowCount - 1);
        int rowIndex = 0;
        int num3;
        while (rowIndex <= num2)
        {
          if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DGWallsP[4, rowIndex].Value)) && Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DGWallsP[4, rowIndex].Value, (object) true, false))
          {
            int integer1 = Conversions.ToInteger(this.DGWallsP[0, rowIndex].Value);
            int integer2 = Conversions.ToInteger(this.DGWallsP[1, rowIndex].Value);
            checked { ++num3; }
            if (this.chk_PWalls_Type.Checked)
              SAP_Module.Proj.Dwellings[integer1].PWalls[integer2].Type = dwelling2.PWalls[index].Type;
            if (this.chk_PWalls_Construction.Checked)
              SAP_Module.Proj.Dwellings[integer1].PWalls[integer2].Construction = dwelling2.PWalls[index].Construction;
            if (this.chk_PWalls_Area.Checked)
              SAP_Module.Proj.Dwellings[integer1].PWalls[integer2].Area = dwelling2.PWalls[index].Area;
            if (this.chk_PWalls_UValue.Checked)
              SAP_Module.Proj.Dwellings[integer1].PWalls[integer2].U_Value = dwelling2.PWalls[index].U_Value;
            if (this.chk_PWalls_Kappa.Checked)
              SAP_Module.Proj.Dwellings[integer1].PWalls[integer2].K = dwelling2.PWalls[index].K;
          }
          checked { ++rowIndex; }
        }
        int num4 = (int) Interaction.MsgBox((object) ("Wall properties Copied to " + Conversions.ToString(num3) + " walls"), MsgBoxStyle.Information);
      }
    }

    private void Button26_Click(object sender, EventArgs e)
    {
      if (this.DGSRoofI.SelectedRows[0].Index == -1)
      {
        int num1 = (int) Interaction.MsgBox((object) "Please select a ceiling to copy details from!");
      }
      else
      {
        SAP_Module.Dwelling dwelling1 = new SAP_Module.Dwelling();
        SAP_Module.Dwelling dwelling2 = Functions.CopyDwelling(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling]);
        int index = this.DGSRoofI.SelectedRows[0].Index;
        int num2 = checked (this.DGRoofsI.RowCount - 1);
        int rowIndex = 0;
        int num3;
        while (rowIndex <= num2)
        {
          if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DGRoofsI[4, rowIndex].Value)) && Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DGRoofsI[4, rowIndex].Value, (object) true, false))
          {
            int integer1 = Conversions.ToInteger(this.DGRoofsI[0, rowIndex].Value);
            int integer2 = Conversions.ToInteger(this.DGRoofsI[1, rowIndex].Value);
            checked { ++num3; }
            if (this.chk_IRoofs_Construction.Checked)
              SAP_Module.Proj.Dwellings[integer1].ICeilings[integer2].Construction = dwelling2.ICeilings[index].Construction;
            if (this.chk_IRoofs_Area.Checked)
              SAP_Module.Proj.Dwellings[integer1].ICeilings[integer2].Area = dwelling2.ICeilings[index].Area;
            if (this.chk_IRoofs_Kappa.Checked)
              SAP_Module.Proj.Dwellings[integer1].ICeilings[integer2].K = dwelling2.ICeilings[index].K;
          }
          checked { ++rowIndex; }
        }
        int num4 = (int) Interaction.MsgBox((object) ("Ceiling properties Copied to " + Conversions.ToString(num3) + " ceilings"), MsgBoxStyle.Information);
      }
    }

    private void Button29_Click(object sender, EventArgs e)
    {
      if (this.DGSRoofP.SelectedRows[0].Index == -1)
      {
        int num1 = (int) Interaction.MsgBox((object) "Please select a ceiling to copy details from!");
      }
      else
      {
        SAP_Module.Dwelling dwelling1 = new SAP_Module.Dwelling();
        SAP_Module.Dwelling dwelling2 = Functions.CopyDwelling(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling]);
        int index = this.DGSRoofP.SelectedRows[0].Index;
        int num2 = checked (this.DGRoofsP.RowCount - 1);
        int rowIndex = 0;
        int num3;
        while (rowIndex <= num2)
        {
          if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DGRoofsP[4, rowIndex].Value)) && Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DGRoofsP[4, rowIndex].Value, (object) true, false))
          {
            int integer1 = Conversions.ToInteger(this.DGRoofsP[0, rowIndex].Value);
            int integer2 = Conversions.ToInteger(this.DGRoofsP[1, rowIndex].Value);
            checked { ++num3; }
            if (this.chk_PRoofs_Construction.Checked)
              SAP_Module.Proj.Dwellings[integer1].PCeilings[integer2].Construction = dwelling2.PCeilings[index].Construction;
            if (this.chk_PRoofs_Area.Checked)
              SAP_Module.Proj.Dwellings[integer1].PCeilings[integer2].Area = dwelling2.PCeilings[index].Area;
            if (this.chk_PRoofs_Kappa.Checked)
              SAP_Module.Proj.Dwellings[integer1].PCeilings[integer2].K = dwelling2.PCeilings[index].K;
          }
          checked { ++rowIndex; }
        }
        int num4 = (int) Interaction.MsgBox((object) ("Ceiling properties Copied to " + Conversions.ToString(num3) + " ceilings"), MsgBoxStyle.Information);
      }
    }

    private void Button30_Click(object sender, EventArgs e)
    {
      int num = checked (this.DGHtbDwellings.RowCount - 1);
      int rowIndex = 0;
      while (rowIndex <= num)
      {
        this.DGHtbDwellings[2, rowIndex].Value = (object) true;
        checked { ++rowIndex; }
      }
    }

    private void Button31_Click(object sender, EventArgs e)
    {
      int num = checked (this.DGHtbDwellings.RowCount - 1);
      int rowIndex = 0;
      while (rowIndex <= num)
      {
        this.DGHtbDwellings[2, rowIndex].Value = (object) false;
        checked { ++rowIndex; }
      }
    }

    private void Button32_Click(object sender, EventArgs e)
    {
      SAP_Module.Junction junction1 = new SAP_Module.Junction();
      SAP_Module.Junction junction2 = new SAP_Module.Junction();
      SAP_Module.Junction junction3 = new SAP_Module.Junction();
      int num1 = checked (this.DGHtbDwellings.RowCount - 1);
      int rowIndex1 = 0;
      while (rowIndex1 <= num1)
      {
        float num2 = 0.0f;
        if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DGHtbDwellings[2, rowIndex1].Value)))
        {
          int integer;
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DGHtbDwellings[2, rowIndex1].Value, (object) true, false))
          {
            integer = Conversions.ToInteger(this.DGHtbDwellings[0, rowIndex1].Value);
            try
            {
              if (SAP_Module.Proj.Dwellings[integer].Thermal.ExternalJunctions == null)
                SAP_Module.Proj.Dwellings[integer].Thermal.ExternalJunctions = new List<SAP_Module.Junction>();
              if (SAP_Module.Proj.Dwellings[integer].Thermal.PartyJunctions == null)
                SAP_Module.Proj.Dwellings[integer].Thermal.PartyJunctions = new List<SAP_Module.Junction>();
              if (SAP_Module.Proj.Dwellings[integer].Thermal.RoofJunctions == null)
                SAP_Module.Proj.Dwellings[integer].Thermal.RoofJunctions = new List<SAP_Module.Junction>();
              List<SAP_Module.Junction> junctionList1 = new List<SAP_Module.Junction>();
              List<SAP_Module.Junction> junctionList2 = new List<SAP_Module.Junction>();
              List<SAP_Module.Junction> junctionList3 = new List<SAP_Module.Junction>();
              int num3 = checked (this.dtaCalc.Rows.Count - 1);
              int rowIndex2 = 0;
              while (rowIndex2 <= num3)
              {
                if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.dtaCalc[5, rowIndex2].Value, (object) true, false))
                {
                  if (Conversions.ToBoolean(NewLateBinding.LateGet(this.dtaCalc[6, rowIndex2].Value, (System.Type) null, "Contains", new object[1]
                  {
                    (object) "E"
                  }, (string[]) null, (System.Type[]) null, (bool[]) null)))
                  {
                    SAP_Module.Junction junction4 = new SAP_Module.Junction();
                    junction4.Ref = Conversions.ToString(this.dtaCalc[6, rowIndex2].Value);
                    if (this.chkSource.Checked)
                      junction4.IsAccredited = Conversions.ToBoolean(this.dtaCalc[3, rowIndex2].Value);
                    if (this.chkD.Checked)
                      junction4.IsDefault = Conversions.ToBoolean(this.dtaCalc[4, rowIndex2].Value);
                    if (this.chkY.Checked)
                      junction4.ThermalTransmittance = Conversions.ToSingle(this.dtaCalc[1, rowIndex2].Value);
                    if (this.chkL.Checked)
                      junction4.Length = Conversions.ToSingle(this.dtaCalc[2, rowIndex2].Value);
                    junctionList1.Add(junction4);
                    SAP_Module.Proj.Dwellings[integer].Thermal.ExternalJunctions.Add(junction4);
                  }
                }
                if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.dtaCalc[5, rowIndex2].Value, (object) true, false))
                {
                  if (Conversions.ToBoolean(NewLateBinding.LateGet(this.dtaCalc[6, rowIndex2].Value, (System.Type) null, "Contains", new object[1]
                  {
                    (object) "P"
                  }, (string[]) null, (System.Type[]) null, (bool[]) null)))
                  {
                    SAP_Module.Junction junction5 = new SAP_Module.Junction();
                    junction5.Ref = Conversions.ToString(this.dtaCalc[6, rowIndex2].Value);
                    if (this.chkSource.Checked)
                      junction5.IsAccredited = Conversions.ToBoolean(this.dtaCalc[3, rowIndex2].Value);
                    if (this.chkD.Checked)
                      junction5.IsDefault = Conversions.ToBoolean(this.dtaCalc[4, rowIndex2].Value);
                    if (this.chkY.Checked)
                      junction5.ThermalTransmittance = Conversions.ToSingle(this.dtaCalc[1, rowIndex2].Value);
                    if (this.chkL.Checked)
                      junction5.Length = Conversions.ToSingle(this.dtaCalc[2, rowIndex2].Value);
                    junctionList2.Add(junction5);
                    SAP_Module.Proj.Dwellings[integer].Thermal.PartyJunctions.Add(junction5);
                  }
                }
                if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.dtaCalc[5, rowIndex2].Value, (object) true, false))
                {
                  if (Conversions.ToBoolean(NewLateBinding.LateGet(this.dtaCalc[6, rowIndex2].Value, (System.Type) null, "Contains", new object[1]
                  {
                    (object) "R"
                  }, (string[]) null, (System.Type[]) null, (bool[]) null)))
                  {
                    SAP_Module.Junction junction6 = new SAP_Module.Junction();
                    junction6.Ref = Conversions.ToString(this.dtaCalc[6, rowIndex2].Value);
                    if (this.chkSource.Checked)
                      junction6.IsAccredited = Conversions.ToBoolean(this.dtaCalc[3, rowIndex2].Value);
                    if (this.chkD.Checked)
                      junction6.IsDefault = Conversions.ToBoolean(this.dtaCalc[4, rowIndex2].Value);
                    if (this.chkY.Checked)
                      junction6.ThermalTransmittance = Conversions.ToSingle(this.dtaCalc[1, rowIndex2].Value);
                    if (this.chkL.Checked)
                      junction6.Length = Conversions.ToSingle(this.dtaCalc[2, rowIndex2].Value);
                    junctionList3.Add(junction6);
                    SAP_Module.Proj.Dwellings[integer].Thermal.RoofJunctions.Add(junction6);
                  }
                }
                checked { ++rowIndex2; }
              }
            }
            catch (Exception ex)
            {
              ProjectData.SetProjectError(ex);
              ProjectData.ClearProjectError();
            }
          }
          try
          {
            foreach (SAP_Module.Junction externalJunction in SAP_Module.Proj.Dwellings[integer].Thermal.ExternalJunctions)
              num2 += externalJunction.ThermalTransmittance * externalJunction.Length;
          }
          finally
          {
            List<SAP_Module.Junction>.Enumerator enumerator;
            enumerator.Dispose();
          }
          try
          {
            foreach (SAP_Module.Junction partyJunction in SAP_Module.Proj.Dwellings[integer].Thermal.PartyJunctions)
              num2 += partyJunction.ThermalTransmittance * partyJunction.Length;
          }
          finally
          {
            List<SAP_Module.Junction>.Enumerator enumerator;
            enumerator.Dispose();
          }
          try
          {
            foreach (SAP_Module.Junction roofJunction in SAP_Module.Proj.Dwellings[integer].Thermal.RoofJunctions)
              num2 += roofJunction.ThermalTransmittance * roofJunction.Length;
          }
          finally
          {
            List<SAP_Module.Junction>.Enumerator enumerator;
            enumerator.Dispose();
          }
          SAP_Module.Proj.Dwellings[integer].Thermal.HtbValue = num2;
          SAP_Module.Proj.Dwellings[integer].Thermal.ManualHtb = true;
        }
        checked { ++rowIndex1; }
      }
      bool flag;
      if (flag)
      {
        int num4 = (int) Interaction.MsgBox((object) "Junction does not exist in destination dwelling", MsgBoxStyle.Critical, (object) "Stroma FSAP 2012");
      }
      this.Close();
    }

    private void cmdSelectAllHtb_Click(object sender, EventArgs e)
    {
      try
      {
        int num = checked (this.dtaCalc.RowCount - 1);
        int rowIndex = 0;
        while (rowIndex <= num)
        {
          this.dtaCalc[5, rowIndex].Value = (object) true;
          checked { ++rowIndex; }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void cmdDeSelectAllHtb_Click(object sender, EventArgs e)
    {
      try
      {
        int num = checked (this.dtaCalc.RowCount - 1);
        int rowIndex = 0;
        while (rowIndex <= num)
        {
          this.dtaCalc[5, rowIndex].Value = (object) false;
          checked { ++rowIndex; }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void Button33_Click(object sender, EventArgs e)
    {
      SAP_Module.Junction junction1 = new SAP_Module.Junction();
      SAP_Module.Junction junction2 = new SAP_Module.Junction();
      SAP_Module.Junction junction3 = new SAP_Module.Junction();
      switch (Interaction.MsgBox((object) "PLEASE NOTE: Data in the selected dwellings will be lost and replaced if this approach is used. Do you want to proceed?", MsgBoxStyle.YesNoCancel | MsgBoxStyle.Question, (object) "Replace HTB Values?"))
      {
        case MsgBoxResult.Cancel:
          break;
        case MsgBoxResult.No:
          break;
        default:
          int num1 = checked (this.DGHtbDwellings.RowCount - 1);
          int rowIndex1 = 0;
          while (rowIndex1 <= num1)
          {
            float num2 = 0.0f;
            if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DGHtbDwellings[2, rowIndex1].Value)))
            {
              int integer;
              if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DGHtbDwellings[2, rowIndex1].Value, (object) true, false))
              {
                integer = Conversions.ToInteger(this.DGHtbDwellings[0, rowIndex1].Value);
                try
                {
                  if (SAP_Module.Proj.Dwellings[integer].Thermal.ExternalJunctions == null)
                    SAP_Module.Proj.Dwellings[integer].Thermal.ExternalJunctions = new List<SAP_Module.Junction>();
                  if (SAP_Module.Proj.Dwellings[integer].Thermal.PartyJunctions == null)
                    SAP_Module.Proj.Dwellings[integer].Thermal.PartyJunctions = new List<SAP_Module.Junction>();
                  if (SAP_Module.Proj.Dwellings[integer].Thermal.RoofJunctions == null)
                    SAP_Module.Proj.Dwellings[integer].Thermal.RoofJunctions = new List<SAP_Module.Junction>();
                  List<SAP_Module.Junction> junctionList1 = new List<SAP_Module.Junction>();
                  List<SAP_Module.Junction> junctionList2 = new List<SAP_Module.Junction>();
                  List<SAP_Module.Junction> junctionList3 = new List<SAP_Module.Junction>();
                  int num3 = checked (this.dtaCalc.Rows.Count - 1);
                  int rowIndex2 = 0;
                  while (rowIndex2 <= num3)
                  {
                    if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.dtaCalc[5, rowIndex2].Value, (object) true, false))
                    {
                      if (Conversions.ToBoolean(NewLateBinding.LateGet(this.dtaCalc[6, rowIndex2].Value, (System.Type) null, "Contains", new object[1]
                      {
                        (object) "E"
                      }, (string[]) null, (System.Type[]) null, (bool[]) null)))
                      {
                        SAP_Module.Junction junction4 = new SAP_Module.Junction();
                        junction4.Ref = Conversions.ToString(this.dtaCalc[6, rowIndex2].Value);
                        if (this.chkSource.Checked)
                          junction4.IsAccredited = Conversions.ToBoolean(this.dtaCalc[3, rowIndex2].Value);
                        if (this.chkD.Checked)
                          junction4.IsDefault = Conversions.ToBoolean(this.dtaCalc[4, rowIndex2].Value);
                        if (this.chkY.Checked)
                          junction4.ThermalTransmittance = Conversions.ToSingle(this.dtaCalc[1, rowIndex2].Value);
                        if (this.chkL.Checked)
                          junction4.Length = Conversions.ToSingle(this.dtaCalc[2, rowIndex2].Value);
                        junctionList1.Add(junction4);
                      }
                    }
                    SAP_Module.Proj.Dwellings[integer].Thermal.ExternalJunctions = junctionList1;
                    if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.dtaCalc[5, rowIndex2].Value, (object) true, false))
                    {
                      if (Conversions.ToBoolean(NewLateBinding.LateGet(this.dtaCalc[6, rowIndex2].Value, (System.Type) null, "Contains", new object[1]
                      {
                        (object) "P"
                      }, (string[]) null, (System.Type[]) null, (bool[]) null)))
                      {
                        SAP_Module.Junction junction5 = new SAP_Module.Junction();
                        junction5.Ref = Conversions.ToString(this.dtaCalc[6, rowIndex2].Value);
                        if (this.chkSource.Checked)
                          junction5.IsAccredited = Conversions.ToBoolean(this.dtaCalc[3, rowIndex2].Value);
                        if (this.chkD.Checked)
                          junction5.IsDefault = Conversions.ToBoolean(this.dtaCalc[4, rowIndex2].Value);
                        if (this.chkY.Checked)
                          junction5.ThermalTransmittance = Conversions.ToSingle(this.dtaCalc[1, rowIndex2].Value);
                        if (this.chkL.Checked)
                          junction5.Length = Conversions.ToSingle(this.dtaCalc[2, rowIndex2].Value);
                        junctionList2.Add(junction5);
                      }
                    }
                    SAP_Module.Proj.Dwellings[integer].Thermal.PartyJunctions = junctionList2;
                    if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.dtaCalc[5, rowIndex2].Value, (object) true, false))
                    {
                      if (Conversions.ToBoolean(NewLateBinding.LateGet(this.dtaCalc[6, rowIndex2].Value, (System.Type) null, "Contains", new object[1]
                      {
                        (object) "R"
                      }, (string[]) null, (System.Type[]) null, (bool[]) null)))
                      {
                        SAP_Module.Junction junction6 = new SAP_Module.Junction();
                        junction6.Ref = Conversions.ToString(this.dtaCalc[6, rowIndex2].Value);
                        if (this.chkSource.Checked)
                          junction6.IsAccredited = Conversions.ToBoolean(this.dtaCalc[3, rowIndex2].Value);
                        if (this.chkD.Checked)
                          junction6.IsDefault = Conversions.ToBoolean(this.dtaCalc[4, rowIndex2].Value);
                        if (this.chkY.Checked)
                          junction6.ThermalTransmittance = Conversions.ToSingle(this.dtaCalc[1, rowIndex2].Value);
                        if (this.chkL.Checked)
                          junction6.Length = Conversions.ToSingle(this.dtaCalc[2, rowIndex2].Value);
                        junctionList3.Add(junction6);
                      }
                    }
                    SAP_Module.Proj.Dwellings[integer].Thermal.RoofJunctions = junctionList3;
                    checked { ++rowIndex2; }
                  }
                }
                catch (Exception ex)
                {
                  ProjectData.SetProjectError(ex);
                  ProjectData.ClearProjectError();
                }
              }
              try
              {
                foreach (SAP_Module.Junction externalJunction in SAP_Module.Proj.Dwellings[integer].Thermal.ExternalJunctions)
                  num2 += externalJunction.ThermalTransmittance * externalJunction.Length;
              }
              finally
              {
                List<SAP_Module.Junction>.Enumerator enumerator;
                enumerator.Dispose();
              }
              try
              {
                foreach (SAP_Module.Junction partyJunction in SAP_Module.Proj.Dwellings[integer].Thermal.PartyJunctions)
                  num2 += partyJunction.ThermalTransmittance * partyJunction.Length;
              }
              finally
              {
                List<SAP_Module.Junction>.Enumerator enumerator;
                enumerator.Dispose();
              }
              try
              {
                foreach (SAP_Module.Junction roofJunction in SAP_Module.Proj.Dwellings[integer].Thermal.RoofJunctions)
                  num2 += roofJunction.ThermalTransmittance * roofJunction.Length;
              }
              finally
              {
                List<SAP_Module.Junction>.Enumerator enumerator;
                enumerator.Dispose();
              }
              SAP_Module.Proj.Dwellings[integer].Thermal.HtbValue = num2;
              SAP_Module.Proj.Dwellings[integer].Thermal.ManualHtb = true;
            }
            checked { ++rowIndex1; }
          }
          bool flag;
          if (flag)
          {
            int num4 = (int) Interaction.MsgBox((object) "Junction does not exist in destination dwelling", MsgBoxStyle.Critical, (object) "Stroma FSAP 2012");
          }
          this.Close();
          break;
      }
    }

    private void Button34_Click(object sender, EventArgs e)
    {
      SAP_Module.Junction junction1 = new SAP_Module.Junction();
      SAP_Module.Junction junction2 = new SAP_Module.Junction();
      SAP_Module.Junction junction3 = new SAP_Module.Junction();
      switch (Interaction.MsgBox((object) "PLEASE NOTE: If you have more than one junction of the same type in a dwelling then the psi-value and length will be applied to each of those junctions. Do you want to proceed?", MsgBoxStyle.YesNoCancel | MsgBoxStyle.Question, (object) "Replace HTB Values?"))
      {
        case MsgBoxResult.Cancel:
          break;
        case MsgBoxResult.No:
          break;
        default:
          int num1 = checked (this.DGHtbDwellings.RowCount - 1);
          int rowIndex1 = 0;
          while (rowIndex1 <= num1)
          {
            float num2 = 0.0f;
            if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DGHtbDwellings[2, rowIndex1].Value)))
            {
              int integer;
              if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DGHtbDwellings[2, rowIndex1].Value, (object) true, false))
              {
                integer = Conversions.ToInteger(this.DGHtbDwellings[0, rowIndex1].Value);
                try
                {
                  if (SAP_Module.Proj.Dwellings[integer].Thermal.ExternalJunctions == null)
                    SAP_Module.Proj.Dwellings[integer].Thermal.ExternalJunctions = new List<SAP_Module.Junction>();
                  if (SAP_Module.Proj.Dwellings[integer].Thermal.PartyJunctions == null)
                    SAP_Module.Proj.Dwellings[integer].Thermal.PartyJunctions = new List<SAP_Module.Junction>();
                  if (SAP_Module.Proj.Dwellings[integer].Thermal.RoofJunctions == null)
                    SAP_Module.Proj.Dwellings[integer].Thermal.RoofJunctions = new List<SAP_Module.Junction>();
                  List<SAP_Module.Junction> junctionList1 = new List<SAP_Module.Junction>();
                  List<SAP_Module.Junction> junctionList2 = new List<SAP_Module.Junction>();
                  List<SAP_Module.Junction> junctionList3 = new List<SAP_Module.Junction>();
                  int num3 = checked (this.dtaCalc.Rows.Count - 1);
                  int rowIndex2 = 0;
                  while (rowIndex2 <= num3)
                  {
                    List<SAP_Module.Junction> externalJunctions = SAP_Module.Proj.Dwellings[integer].Thermal.ExternalJunctions;
                    if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.dtaCalc[5, rowIndex2].Value, (object) true, false))
                    {
                      if (Conversions.ToBoolean(NewLateBinding.LateGet(this.dtaCalc[6, rowIndex2].Value, (System.Type) null, "Contains", new object[1]
                      {
                        (object) "E"
                      }, (string[]) null, (System.Type[]) null, (bool[]) null)))
                      {
                        bool flag = false;
                        int num4 = checked (externalJunctions.Count - 1);
                        int index = 0;
                        while (index <= num4)
                        {
                          if (externalJunctions[index].Ref.Equals(RuntimeHelpers.GetObjectValue(this.dtaCalc[6, rowIndex2].Value)))
                          {
                            flag = true;
                            SAP_Module.Junction junction4 = externalJunctions[index] with
                            {
                              Ref = Conversions.ToString(this.dtaCalc[6, rowIndex2].Value)
                            };
                            if (this.chkSource.Checked)
                              junction4.IsAccredited = Conversions.ToBoolean(this.dtaCalc[3, rowIndex2].Value);
                            if (this.chkD.Checked)
                              junction4.IsDefault = Conversions.ToBoolean(this.dtaCalc[4, rowIndex2].Value);
                            if (this.chkY.Checked)
                              junction4.ThermalTransmittance = Conversions.ToSingle(this.dtaCalc[1, rowIndex2].Value);
                            if (this.chkL.Checked)
                              junction4.Length = Conversions.ToSingle(this.dtaCalc[2, rowIndex2].Value);
                            externalJunctions[index] = junction4;
                          }
                          checked { ++index; }
                        }
                        if (!flag)
                        {
                          SAP_Module.Junction junction5 = new SAP_Module.Junction();
                          junction5.Ref = Conversions.ToString(this.dtaCalc[6, rowIndex2].Value);
                          if (this.chkSource.Checked)
                            junction5.IsAccredited = Conversions.ToBoolean(this.dtaCalc[3, rowIndex2].Value);
                          if (this.chkD.Checked)
                            junction5.IsDefault = Conversions.ToBoolean(this.dtaCalc[4, rowIndex2].Value);
                          if (this.chkY.Checked)
                            junction5.ThermalTransmittance = Conversions.ToSingle(this.dtaCalc[1, rowIndex2].Value);
                          if (this.chkL.Checked)
                            junction5.Length = Conversions.ToSingle(this.dtaCalc[2, rowIndex2].Value);
                          externalJunctions.Add(junction5);
                        }
                      }
                    }
                    SAP_Module.Proj.Dwellings[integer].Thermal.ExternalJunctions = externalJunctions;
                    List<SAP_Module.Junction> partyJunctions = SAP_Module.Proj.Dwellings[integer].Thermal.PartyJunctions;
                    if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.dtaCalc[5, rowIndex2].Value, (object) true, false))
                    {
                      if (Conversions.ToBoolean(NewLateBinding.LateGet(this.dtaCalc[6, rowIndex2].Value, (System.Type) null, "Contains", new object[1]
                      {
                        (object) "P"
                      }, (string[]) null, (System.Type[]) null, (bool[]) null)))
                      {
                        bool flag = false;
                        int num5 = checked (partyJunctions.Count - 1);
                        int index = 0;
                        while (index <= num5)
                        {
                          if (partyJunctions[index].Ref.Equals(RuntimeHelpers.GetObjectValue(this.dtaCalc[6, rowIndex2].Value)))
                          {
                            flag = true;
                            SAP_Module.Junction junction6 = partyJunctions[index] with
                            {
                              Ref = Conversions.ToString(this.dtaCalc[6, rowIndex2].Value)
                            };
                            if (this.chkSource.Checked)
                              junction6.IsAccredited = Conversions.ToBoolean(this.dtaCalc[3, rowIndex2].Value);
                            if (this.chkD.Checked)
                              junction6.IsDefault = Conversions.ToBoolean(this.dtaCalc[4, rowIndex2].Value);
                            if (this.chkY.Checked)
                              junction6.ThermalTransmittance = Conversions.ToSingle(this.dtaCalc[1, rowIndex2].Value);
                            if (this.chkL.Checked)
                              junction6.Length = Conversions.ToSingle(this.dtaCalc[2, rowIndex2].Value);
                            partyJunctions[index] = junction6;
                          }
                          checked { ++index; }
                        }
                        if (!flag)
                        {
                          SAP_Module.Junction junction7 = new SAP_Module.Junction();
                          junction7.Ref = Conversions.ToString(this.dtaCalc[6, rowIndex2].Value);
                          if (this.chkSource.Checked)
                            junction7.IsAccredited = Conversions.ToBoolean(this.dtaCalc[3, rowIndex2].Value);
                          if (this.chkD.Checked)
                            junction7.IsDefault = Conversions.ToBoolean(this.dtaCalc[4, rowIndex2].Value);
                          if (this.chkY.Checked)
                            junction7.ThermalTransmittance = Conversions.ToSingle(this.dtaCalc[1, rowIndex2].Value);
                          if (this.chkL.Checked)
                            junction7.Length = Conversions.ToSingle(this.dtaCalc[2, rowIndex2].Value);
                          partyJunctions.Add(junction7);
                        }
                      }
                    }
                    SAP_Module.Proj.Dwellings[integer].Thermal.PartyJunctions = partyJunctions;
                    List<SAP_Module.Junction> roofJunctions = SAP_Module.Proj.Dwellings[integer].Thermal.RoofJunctions;
                    if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.dtaCalc[5, rowIndex2].Value, (object) true, false))
                    {
                      if (Conversions.ToBoolean(NewLateBinding.LateGet(this.dtaCalc[6, rowIndex2].Value, (System.Type) null, "Contains", new object[1]
                      {
                        (object) "R"
                      }, (string[]) null, (System.Type[]) null, (bool[]) null)))
                      {
                        bool flag = false;
                        int num6 = checked (roofJunctions.Count - 1);
                        int index = 0;
                        while (index <= num6)
                        {
                          if (roofJunctions[index].Ref.Equals(RuntimeHelpers.GetObjectValue(this.dtaCalc[6, rowIndex2].Value)))
                          {
                            flag = true;
                            SAP_Module.Junction junction8 = roofJunctions[index] with
                            {
                              Ref = Conversions.ToString(this.dtaCalc[6, rowIndex2].Value)
                            };
                            if (this.chkSource.Checked)
                              junction8.IsAccredited = Conversions.ToBoolean(this.dtaCalc[3, rowIndex2].Value);
                            if (this.chkD.Checked)
                              junction8.IsDefault = Conversions.ToBoolean(this.dtaCalc[4, rowIndex2].Value);
                            if (this.chkY.Checked)
                              junction8.ThermalTransmittance = Conversions.ToSingle(this.dtaCalc[1, rowIndex2].Value);
                            if (this.chkL.Checked)
                              junction8.Length = Conversions.ToSingle(this.dtaCalc[2, rowIndex2].Value);
                            roofJunctions[index] = junction8;
                          }
                          checked { ++index; }
                        }
                        if (!flag)
                        {
                          SAP_Module.Junction junction9 = new SAP_Module.Junction();
                          junction9.Ref = Conversions.ToString(this.dtaCalc[6, rowIndex2].Value);
                          if (this.chkSource.Checked)
                            junction9.IsAccredited = Conversions.ToBoolean(this.dtaCalc[3, rowIndex2].Value);
                          if (this.chkD.Checked)
                            junction9.IsDefault = Conversions.ToBoolean(this.dtaCalc[4, rowIndex2].Value);
                          if (this.chkY.Checked)
                            junction9.ThermalTransmittance = Conversions.ToSingle(this.dtaCalc[1, rowIndex2].Value);
                          if (this.chkL.Checked)
                            junction9.Length = Conversions.ToSingle(this.dtaCalc[2, rowIndex2].Value);
                          roofJunctions.Add(junction9);
                        }
                      }
                    }
                    SAP_Module.Proj.Dwellings[integer].Thermal.RoofJunctions = roofJunctions;
                    checked { ++rowIndex2; }
                  }
                }
                catch (Exception ex)
                {
                  ProjectData.SetProjectError(ex);
                  ProjectData.ClearProjectError();
                }
              }
              try
              {
                foreach (SAP_Module.Junction externalJunction in SAP_Module.Proj.Dwellings[integer].Thermal.ExternalJunctions)
                  num2 += externalJunction.ThermalTransmittance * externalJunction.Length;
              }
              finally
              {
                List<SAP_Module.Junction>.Enumerator enumerator;
                enumerator.Dispose();
              }
              try
              {
                foreach (SAP_Module.Junction partyJunction in SAP_Module.Proj.Dwellings[integer].Thermal.PartyJunctions)
                  num2 += partyJunction.ThermalTransmittance * partyJunction.Length;
              }
              finally
              {
                List<SAP_Module.Junction>.Enumerator enumerator;
                enumerator.Dispose();
              }
              try
              {
                foreach (SAP_Module.Junction roofJunction in SAP_Module.Proj.Dwellings[integer].Thermal.RoofJunctions)
                  num2 += roofJunction.ThermalTransmittance * roofJunction.Length;
              }
              finally
              {
                List<SAP_Module.Junction>.Enumerator enumerator;
                enumerator.Dispose();
              }
              SAP_Module.Proj.Dwellings[integer].Thermal.HtbValue = num2;
              SAP_Module.Proj.Dwellings[integer].Thermal.ManualHtb = true;
            }
            checked { ++rowIndex1; }
          }
          bool flag1;
          if (flag1)
          {
            int num7 = (int) Interaction.MsgBox((object) "Junction does not exist in destination dwelling", MsgBoxStyle.Critical, (object) "Stroma FSAP 2012");
          }
          this.Close();
          break;
      }
    }

    private void Button35_Click(object sender, EventArgs e)
    {
      int num = checked (this.DGCooling.RowCount - 1);
      int rowIndex = 0;
      while (rowIndex <= num)
      {
        this.DGCooling[2, rowIndex].Value = (object) true;
        checked { ++rowIndex; }
      }
    }

    private void Button36_Click(object sender, EventArgs e)
    {
      int num = checked (this.DGCooling.RowCount - 1);
      int rowIndex = 0;
      while (rowIndex <= num)
      {
        this.DGCooling[2, rowIndex].Value = (object) false;
        checked { ++rowIndex; }
      }
    }

    private void Button37_Click(object sender, EventArgs e)
    {
      if (this.DGSCooling.SelectedRows[0].Index == -1)
      {
        int num1 = (int) Interaction.MsgBox((object) "Please select a Cooling to copy details from!");
      }
      else
      {
        SAP_Module.Dwelling dwelling1 = new SAP_Module.Dwelling();
        SAP_Module.Dwelling dwelling2 = Functions.CopyDwelling(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling]);
        int index = this.DGSCooling.SelectedRows[0].Index;
        int num2 = checked (this.DGCooling.RowCount - 1);
        int rowIndex = 0;
        int num3;
        while (rowIndex <= num2)
        {
          if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DGCooling[4, rowIndex].Value)) && Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DGCooling[4, rowIndex].Value, (object) true, false))
          {
            int integer = Conversions.ToInteger(this.DGCooling[0, rowIndex].Value);
            Conversions.ToInteger(this.DGCooling[1, rowIndex].Value);
            checked { ++num3; }
            if (this.Chk_CoolingsystType.Checked)
              SAP_Module.Proj.Dwellings[integer].Cooling.SystemType = dwelling2.Cooling.SystemType;
            if (this.ChkCoolingEnergyLabel.Checked)
              SAP_Module.Proj.Dwellings[integer].Cooling.Energylabel = dwelling2.Cooling.Energylabel;
            SAP_Module.Proj.Dwellings[integer].Cooling.Include = true;
            if (this.ChkCoolingEER.Checked)
            {
              SAP_Module.Proj.Dwellings[integer].Cooling.ERR = dwelling2.Cooling.ERR;
              SAP_Module.Proj.Dwellings[integer].Cooling.ERRMeasuredInclude = true;
              SAP_Module.Proj.Dwellings[integer].Cooling.Description = dwelling2.Cooling.Description;
            }
            if (this.ChkCompressorcontrol.Checked)
              SAP_Module.Proj.Dwellings[integer].Cooling.Compressorcontrol = dwelling2.Cooling.Compressorcontrol;
            if (this.ChkCoolingArea.Checked)
              SAP_Module.Proj.Dwellings[integer].Cooling.Cooled_Area = dwelling2.Cooling.Cooled_Area;
          }
          checked { ++rowIndex; }
        }
        int num4 = (int) Interaction.MsgBox((object) ("Cooling properties Copied to " + Conversions.ToString(num3) + " Coolings"), MsgBoxStyle.Information);
      }
    }
  }
}
