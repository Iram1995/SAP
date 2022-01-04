
// Type: SAP2012.Reports




using Microsoft.VisualBasic.CompilerServices;
using SAP2012.My;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SAP2012
{
  [DesignerGenerated]
  public class Reports : Form
  {
    private IContainer components;
    private bool SAPWorksheet;
    private bool TERWorksheet;
    private bool DERWorksheet;
    private bool ImproveWorksheet;
    private bool CheckList;
    private bool Overheat;
    private bool EPC;
    private bool XML;

    public Reports()
    {
      this.Load += new EventHandler(this.Reports_Load);
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Reports));
      this.TabControl1 = new TabControl();
      this.TabPage1 = new TabPage();
      this.brwSAPInput = new WebBrowser();
      this.TabPage2 = new TabPage();
      this.brwSAPWork = new WebBrowser();
      this.TabPage4 = new TabPage();
      this.brwDERWork = new WebBrowser();
      this.TabPage5 = new TabPage();
      this.brwFabric = new WebBrowser();
      this.TabPage3 = new TabPage();
      this.brwTERWork = new WebBrowser();
      this.TabPage9 = new TabPage();
      this.brwTFEE = new WebBrowser();
      this.Tabpage8 = new TabPage();
      this.brwOverHeating = new WebBrowser();
      this.TabPage7 = new TabPage();
      this.ChkComplinaceSave = new CheckBox();
      this.brwComplience = new WebBrowser();
      this.cmdComplinaceSave = new Button();
      this.TabPage6 = new TabPage();
      this.brwImproved = new WebBrowser();
      this.TabPage10 = new TabPage();
      this.brwSAPEPC = new WebBrowser();
      this.TabPage11 = new TabPage();
      this.brwCarbonZero = new WebBrowser();
      this.TabPage12 = new TabPage();
      this.brwCosts = new WebBrowser();
      this.ToolStrip1 = new ToolStrip();
      this.ToolStripButton1 = new ToolStripButton();
      this.ToolStripButton3 = new ToolStripButton();
      this.ToolStripButton2 = new ToolStripButton();
      this.BW1 = new BackgroundWorker();
      this.PB1 = new ProgressBar();
      this.BW2 = new BackgroundWorker();
      this.BW3 = new BackgroundWorker();
      this.BW4 = new BackgroundWorker();
      this.BW0 = new BackgroundWorker();
      this.BW5 = new BackgroundWorker();
      this.BW6 = new BackgroundWorker();
      this.BW7 = new BackgroundWorker();
      this.BW8 = new BackgroundWorker();
      this.BW9 = new BackgroundWorker();
      this.BW10 = new BackgroundWorker();
      this.FBD1 = new FolderBrowserDialog();
      this.BW11 = new BackgroundWorker();
      this.BW12 = new BackgroundWorker();
      this.TabPage13 = new TabPage();
      this.BW13 = new BackgroundWorker();
      this.BrWDeveloper = new WebBrowser();
      this.TabControl1.SuspendLayout();
      this.TabPage1.SuspendLayout();
      this.TabPage2.SuspendLayout();
      this.TabPage4.SuspendLayout();
      this.TabPage5.SuspendLayout();
      this.TabPage3.SuspendLayout();
      this.TabPage9.SuspendLayout();
      this.Tabpage8.SuspendLayout();
      this.TabPage7.SuspendLayout();
      this.TabPage6.SuspendLayout();
      this.TabPage10.SuspendLayout();
      this.TabPage11.SuspendLayout();
      this.TabPage12.SuspendLayout();
      this.ToolStrip1.SuspendLayout();
      this.TabPage13.SuspendLayout();
      this.SuspendLayout();
      this.TabControl1.Controls.Add((Control) this.TabPage1);
      this.TabControl1.Controls.Add((Control) this.TabPage2);
      this.TabControl1.Controls.Add((Control) this.TabPage4);
      this.TabControl1.Controls.Add((Control) this.TabPage5);
      this.TabControl1.Controls.Add((Control) this.TabPage3);
      this.TabControl1.Controls.Add((Control) this.TabPage9);
      this.TabControl1.Controls.Add((Control) this.Tabpage8);
      this.TabControl1.Controls.Add((Control) this.TabPage7);
      this.TabControl1.Controls.Add((Control) this.TabPage6);
      this.TabControl1.Controls.Add((Control) this.TabPage10);
      this.TabControl1.Controls.Add((Control) this.TabPage11);
      this.TabControl1.Controls.Add((Control) this.TabPage12);
      this.TabControl1.Controls.Add((Control) this.TabPage13);
      this.TabControl1.Cursor = Cursors.Hand;
      this.TabControl1.Dock = DockStyle.Fill;
      this.TabControl1.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.TabControl1.HotTrack = true;
      this.TabControl1.ItemSize = new Size(111, 30);
      this.TabControl1.Location = new Point(0, 25);
      this.TabControl1.Multiline = true;
      this.TabControl1.Name = "TabControl1";
      this.TabControl1.SelectedIndex = 0;
      this.TabControl1.Size = new Size(1149, 705);
      this.TabControl1.SizeMode = TabSizeMode.Fixed;
      this.TabControl1.TabIndex = 0;
      this.TabPage1.Controls.Add((Control) this.brwSAPInput);
      this.TabPage1.Location = new Point(4, 64);
      this.TabPage1.Name = "TabPage1";
      this.TabPage1.Padding = new Padding(3);
      this.TabPage1.Size = new Size(1141, 637);
      this.TabPage1.TabIndex = 5;
      this.TabPage1.Text = "SAP Inputs";
      this.TabPage1.UseVisualStyleBackColor = true;
      this.brwSAPInput.Dock = DockStyle.Fill;
      this.brwSAPInput.Location = new Point(3, 3);
      this.brwSAPInput.MinimumSize = new Size(20, 20);
      this.brwSAPInput.Name = "brwSAPInput";
      this.brwSAPInput.Size = new Size(1135, 631);
      this.brwSAPInput.TabIndex = 0;
      this.TabPage2.Controls.Add((Control) this.brwSAPWork);
      this.TabPage2.Location = new Point(4, 34);
      this.TabPage2.Name = "TabPage2";
      this.TabPage2.Padding = new Padding(3);
      this.TabPage2.Size = new Size(1141, 667);
      this.TabPage2.TabIndex = 0;
      this.TabPage2.Text = "SAP Worksheet";
      this.TabPage2.UseVisualStyleBackColor = true;
      this.brwSAPWork.Dock = DockStyle.Fill;
      this.brwSAPWork.Location = new Point(3, 3);
      this.brwSAPWork.MinimumSize = new Size(20, 20);
      this.brwSAPWork.Name = "brwSAPWork";
      this.brwSAPWork.Size = new Size(1135, 661);
      this.brwSAPWork.TabIndex = 0;
      this.TabPage4.Controls.Add((Control) this.brwDERWork);
      this.TabPage4.Location = new Point(4, 34);
      this.TabPage4.Name = "TabPage4";
      this.TabPage4.Padding = new Padding(3);
      this.TabPage4.Size = new Size(1141, 667);
      this.TabPage4.TabIndex = 2;
      this.TabPage4.Text = "DER Worksheet";
      this.TabPage4.UseVisualStyleBackColor = true;
      this.brwDERWork.Dock = DockStyle.Fill;
      this.brwDERWork.Location = new Point(3, 3);
      this.brwDERWork.MinimumSize = new Size(20, 20);
      this.brwDERWork.Name = "brwDERWork";
      this.brwDERWork.Size = new Size(1135, 661);
      this.brwDERWork.TabIndex = 0;
      this.TabPage5.Controls.Add((Control) this.brwFabric);
      this.TabPage5.Location = new Point(4, 34);
      this.TabPage5.Name = "TabPage5";
      this.TabPage5.Padding = new Padding(3);
      this.TabPage5.Size = new Size(1141, 667);
      this.TabPage5.TabIndex = 10;
      this.TabPage5.Text = "DFEE Worksheet";
      this.TabPage5.UseVisualStyleBackColor = true;
      this.brwFabric.Dock = DockStyle.Fill;
      this.brwFabric.Location = new Point(3, 3);
      this.brwFabric.MinimumSize = new Size(20, 20);
      this.brwFabric.Name = "brwFabric";
      this.brwFabric.Size = new Size(1135, 661);
      this.brwFabric.TabIndex = 3;
      this.TabPage3.Controls.Add((Control) this.brwTERWork);
      this.TabPage3.Location = new Point(4, 34);
      this.TabPage3.Name = "TabPage3";
      this.TabPage3.Padding = new Padding(3);
      this.TabPage3.Size = new Size(1141, 667);
      this.TabPage3.TabIndex = 1;
      this.TabPage3.Text = "TER Worksheet";
      this.TabPage3.UseVisualStyleBackColor = true;
      this.brwTERWork.Dock = DockStyle.Fill;
      this.brwTERWork.Location = new Point(3, 3);
      this.brwTERWork.MinimumSize = new Size(20, 20);
      this.brwTERWork.Name = "brwTERWork";
      this.brwTERWork.Size = new Size(1135, 661);
      this.brwTERWork.TabIndex = 0;
      this.TabPage9.Controls.Add((Control) this.brwTFEE);
      this.TabPage9.Location = new Point(4, 34);
      this.TabPage9.Name = "TabPage9";
      this.TabPage9.Padding = new Padding(3);
      this.TabPage9.Size = new Size(1141, 667);
      this.TabPage9.TabIndex = 8;
      this.TabPage9.Text = "TFEE Worksheet";
      this.TabPage9.UseVisualStyleBackColor = true;
      this.brwTFEE.Dock = DockStyle.Fill;
      this.brwTFEE.Location = new Point(3, 3);
      this.brwTFEE.MinimumSize = new Size(20, 20);
      this.brwTFEE.Name = "brwTFEE";
      this.brwTFEE.Size = new Size(1135, 661);
      this.brwTFEE.TabIndex = 1;
      this.Tabpage8.Controls.Add((Control) this.brwOverHeating);
      this.Tabpage8.Location = new Point(4, 34);
      this.Tabpage8.Name = "Tabpage8";
      this.Tabpage8.Padding = new Padding(3);
      this.Tabpage8.Size = new Size(1141, 667);
      this.Tabpage8.TabIndex = 6;
      this.Tabpage8.Text = "OverHeating";
      this.Tabpage8.UseVisualStyleBackColor = true;
      this.brwOverHeating.Dock = DockStyle.Fill;
      this.brwOverHeating.Location = new Point(3, 3);
      this.brwOverHeating.MinimumSize = new Size(20, 20);
      this.brwOverHeating.Name = "brwOverHeating";
      this.brwOverHeating.Size = new Size(1135, 661);
      this.brwOverHeating.TabIndex = 1;
      this.TabPage7.Controls.Add((Control) this.ChkComplinaceSave);
      this.TabPage7.Controls.Add((Control) this.brwComplience);
      this.TabPage7.Controls.Add((Control) this.cmdComplinaceSave);
      this.TabPage7.Location = new Point(4, 34);
      this.TabPage7.Name = "TabPage7";
      this.TabPage7.Padding = new Padding(3);
      this.TabPage7.Size = new Size(1141, 667);
      this.TabPage7.TabIndex = 4;
      this.TabPage7.Text = "Compliance Sheet";
      this.TabPage7.UseVisualStyleBackColor = true;
      this.ChkComplinaceSave.AutoSize = true;
      this.ChkComplinaceSave.Location = new Point(78, 69);
      this.ChkComplinaceSave.Name = "ChkComplinaceSave";
      this.ChkComplinaceSave.Size = new Size(131, 18);
      this.ChkComplinaceSave.TabIndex = 1;
      this.ChkComplinaceSave.Text = "remove Watermark";
      this.ChkComplinaceSave.UseVisualStyleBackColor = true;
      this.ChkComplinaceSave.Visible = false;
      this.brwComplience.Dock = DockStyle.Fill;
      this.brwComplience.Location = new Point(3, 37);
      this.brwComplience.MinimumSize = new Size(20, 20);
      this.brwComplience.Name = "brwComplience";
      this.brwComplience.Size = new Size(1135, 627);
      this.brwComplience.TabIndex = 0;
      this.cmdComplinaceSave.BackColor = Color.LightSlateGray;
      this.cmdComplinaceSave.Dock = DockStyle.Top;
      this.cmdComplinaceSave.FlatStyle = FlatStyle.Popup;
      this.cmdComplinaceSave.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdComplinaceSave.ForeColor = Color.White;
      this.cmdComplinaceSave.Location = new Point(3, 3);
      this.cmdComplinaceSave.Name = "cmdComplinaceSave";
      this.cmdComplinaceSave.Size = new Size(1135, 34);
      this.cmdComplinaceSave.TabIndex = 2;
      this.cmdComplinaceSave.Text = "Remove Watermark by Submitting Report Through to Stroma";
      this.cmdComplinaceSave.UseVisualStyleBackColor = false;
      this.TabPage6.Controls.Add((Control) this.brwImproved);
      this.TabPage6.Location = new Point(4, 34);
      this.TabPage6.Name = "TabPage6";
      this.TabPage6.Padding = new Padding(3);
      this.TabPage6.Size = new Size(1141, 667);
      this.TabPage6.TabIndex = 3;
      this.TabPage6.Text = "Improved Dwelling";
      this.TabPage6.UseVisualStyleBackColor = true;
      this.brwImproved.Dock = DockStyle.Fill;
      this.brwImproved.Location = new Point(3, 3);
      this.brwImproved.MinimumSize = new Size(20, 20);
      this.brwImproved.Name = "brwImproved";
      this.brwImproved.Size = new Size(1135, 661);
      this.brwImproved.TabIndex = 0;
      this.TabPage10.Controls.Add((Control) this.brwSAPEPC);
      this.TabPage10.Location = new Point(4, 34);
      this.TabPage10.Name = "TabPage10";
      this.TabPage10.Padding = new Padding(3);
      this.TabPage10.Size = new Size(1141, 667);
      this.TabPage10.TabIndex = 7;
      this.TabPage10.Text = "SAP EPC";
      this.TabPage10.UseVisualStyleBackColor = true;
      this.brwSAPEPC.Dock = DockStyle.Fill;
      this.brwSAPEPC.Location = new Point(3, 3);
      this.brwSAPEPC.MinimumSize = new Size(20, 20);
      this.brwSAPEPC.Name = "brwSAPEPC";
      this.brwSAPEPC.Size = new Size(1135, 661);
      this.brwSAPEPC.TabIndex = 0;
      this.TabPage11.Controls.Add((Control) this.brwCarbonZero);
      this.TabPage11.Location = new Point(4, 64);
      this.TabPage11.Name = "TabPage11";
      this.TabPage11.Size = new Size(1141, 637);
      this.TabPage11.TabIndex = 9;
      this.TabPage11.Text = "Zero Carbon";
      this.TabPage11.UseVisualStyleBackColor = true;
      this.brwCarbonZero.Dock = DockStyle.Fill;
      this.brwCarbonZero.Location = new Point(0, 0);
      this.brwCarbonZero.MinimumSize = new Size(20, 20);
      this.brwCarbonZero.Name = "brwCarbonZero";
      this.brwCarbonZero.Size = new Size(1141, 637);
      this.brwCarbonZero.TabIndex = 2;
      this.TabPage12.Controls.Add((Control) this.brwCosts);
      this.TabPage12.Location = new Point(4, 64);
      this.TabPage12.Name = "TabPage12";
      this.TabPage12.Padding = new Padding(3);
      this.TabPage12.Size = new Size(1141, 637);
      this.TabPage12.TabIndex = 11;
      this.TabPage12.Text = "EPC Costs";
      this.TabPage12.UseVisualStyleBackColor = true;
      this.brwCosts.Dock = DockStyle.Fill;
      this.brwCosts.Location = new Point(3, 3);
      this.brwCosts.MinimumSize = new Size(20, 20);
      this.brwCosts.Name = "brwCosts";
      this.brwCosts.Size = new Size(1135, 631);
      this.brwCosts.TabIndex = 0;
      this.ToolStrip1.Items.AddRange(new ToolStripItem[3]
      {
        (ToolStripItem) this.ToolStripButton1,
        (ToolStripItem) this.ToolStripButton3,
        (ToolStripItem) this.ToolStripButton2
      });
      this.ToolStrip1.Location = new Point(0, 0);
      this.ToolStrip1.Name = "ToolStrip1";
      this.ToolStrip1.Size = new Size(1149, 25);
      this.ToolStrip1.TabIndex = 1;
      this.ToolStrip1.Text = "ToolStrip1";
      this.ToolStripButton1.Font = new Font("Tahoma", 9f);
      this.ToolStripButton1.Image = (Image) componentResourceManager.GetObject("ToolStripButton1.Image");
      this.ToolStripButton1.ImageTransparentColor = Color.Black;
      this.ToolStripButton1.Name = "ToolStripButton1";
      this.ToolStripButton1.Size = new Size(93, 22);
      this.ToolStripButton1.Text = "Exit Reports";
      this.ToolStripButton3.Font = new Font("Tahoma", 9f);
      this.ToolStripButton3.Image = (Image) componentResourceManager.GetObject("ToolStripButton3.Image");
      this.ToolStripButton3.ImageTransparentColor = Color.Magenta;
      this.ToolStripButton3.Name = "ToolStripButton3";
      this.ToolStripButton3.Size = new Size(166, 22);
      this.ToolStripButton3.Text = "Browse Reports Directory";
      this.ToolStripButton2.Font = new Font("Tahoma", 9f);
      this.ToolStripButton2.Image = (Image) componentResourceManager.GetObject("ToolStripButton2.Image");
      this.ToolStripButton2.ImageTransparentColor = Color.Magenta;
      this.ToolStripButton2.Name = "ToolStripButton2";
      this.ToolStripButton2.Size = new Size(221, 22);
      this.ToolStripButton2.Text = "Save Reports to a specific Directory";
      this.PB1.Location = new Point(490, 2);
      this.PB1.Maximum = 10;
      this.PB1.Name = "PB1";
      this.PB1.Size = new Size(209, 23);
      this.PB1.TabIndex = 2;
      this.TabPage13.Controls.Add((Control) this.BrWDeveloper);
      this.TabPage13.Location = new Point(4, 64);
      this.TabPage13.Name = "TabPage13";
      this.TabPage13.Padding = new Padding(3);
      this.TabPage13.Size = new Size(1141, 637);
      this.TabPage13.TabIndex = 12;
      this.TabPage13.Text = "Developer Confirmation";
      this.TabPage13.UseVisualStyleBackColor = true;
      this.BrWDeveloper.Dock = DockStyle.Fill;
      this.BrWDeveloper.Location = new Point(3, 3);
      this.BrWDeveloper.MinimumSize = new Size(20, 20);
      this.BrWDeveloper.Name = "BrWDeveloper";
      this.BrWDeveloper.Size = new Size(1135, 631);
      this.BrWDeveloper.TabIndex = 1;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1149, 730);
      this.Controls.Add((Control) this.PB1);
      this.Controls.Add((Control) this.TabControl1);
      this.Controls.Add((Control) this.ToolStrip1);
      this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (Reports);
      this.Text = nameof (Reports);
      this.TabControl1.ResumeLayout(false);
      this.TabPage1.ResumeLayout(false);
      this.TabPage2.ResumeLayout(false);
      this.TabPage4.ResumeLayout(false);
      this.TabPage5.ResumeLayout(false);
      this.TabPage3.ResumeLayout(false);
      this.TabPage9.ResumeLayout(false);
      this.Tabpage8.ResumeLayout(false);
      this.TabPage7.ResumeLayout(false);
      this.TabPage7.PerformLayout();
      this.TabPage6.ResumeLayout(false);
      this.TabPage10.ResumeLayout(false);
      this.TabPage11.ResumeLayout(false);
      this.TabPage12.ResumeLayout(false);
      this.ToolStrip1.ResumeLayout(false);
      this.ToolStrip1.PerformLayout();
      this.TabPage13.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    [field: AccessedThroughProperty("TabControl1")]
    internal virtual TabControl TabControl1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("TabPage2")]
    internal virtual TabPage TabPage2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("brwSAPWork")]
    internal virtual WebBrowser brwSAPWork { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("TabPage3")]
    internal virtual TabPage TabPage3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("brwTERWork")]
    internal virtual WebBrowser brwTERWork { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("TabPage4")]
    internal virtual TabPage TabPage4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("brwDERWork")]
    internal virtual WebBrowser brwDERWork { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("TabPage7")]
    internal virtual TabPage TabPage7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("brwComplience")]
    internal virtual WebBrowser brwComplience { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("TabPage1")]
    internal virtual TabPage TabPage1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("brwSAPInput")]
    internal virtual WebBrowser brwSAPInput { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Tabpage8")]
    internal virtual TabPage Tabpage8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("brwSAPEPC")]
    internal virtual WebBrowser brwSAPEPC { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("TabPage10")]
    internal virtual TabPage TabPage10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("ToolStrip1")]
    internal virtual ToolStrip ToolStrip1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripButton ToolStripButton1
    {
      get => this._ToolStripButton1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ToolStripButton1_Click);
        ToolStripButton toolStripButton1_1 = this._ToolStripButton1;
        if (toolStripButton1_1 != null)
          toolStripButton1_1.Click -= eventHandler;
        this._ToolStripButton1 = value;
        ToolStripButton toolStripButton1_2 = this._ToolStripButton1;
        if (toolStripButton1_2 == null)
          return;
        toolStripButton1_2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("TabPage6")]
    internal virtual TabPage TabPage6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("brwImproved")]
    internal virtual WebBrowser brwImproved { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("TabPage9")]
    internal virtual TabPage TabPage9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual BackgroundWorker BW1
    {
      get => this._BW1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DoWorkEventHandler workEventHandler = new DoWorkEventHandler(this.BW1_DoWork);
        RunWorkerCompletedEventHandler completedEventHandler = new RunWorkerCompletedEventHandler(this.BW1_RunWorkerCompleted);
        BackgroundWorker bw1_1 = this._BW1;
        if (bw1_1 != null)
        {
          bw1_1.DoWork -= workEventHandler;
          bw1_1.RunWorkerCompleted -= completedEventHandler;
        }
        this._BW1 = value;
        BackgroundWorker bw1_2 = this._BW1;
        if (bw1_2 == null)
          return;
        bw1_2.DoWork += workEventHandler;
        bw1_2.RunWorkerCompleted += completedEventHandler;
      }
    }

    [field: AccessedThroughProperty("PB1")]
    internal virtual ProgressBar PB1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual BackgroundWorker BW2
    {
      get => this._BW2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DoWorkEventHandler workEventHandler = new DoWorkEventHandler(this.BW2_DoWork);
        RunWorkerCompletedEventHandler completedEventHandler = new RunWorkerCompletedEventHandler(this.BW2_RunWorkerCompleted);
        BackgroundWorker bw2_1 = this._BW2;
        if (bw2_1 != null)
        {
          bw2_1.DoWork -= workEventHandler;
          bw2_1.RunWorkerCompleted -= completedEventHandler;
        }
        this._BW2 = value;
        BackgroundWorker bw2_2 = this._BW2;
        if (bw2_2 == null)
          return;
        bw2_2.DoWork += workEventHandler;
        bw2_2.RunWorkerCompleted += completedEventHandler;
      }
    }

    internal virtual BackgroundWorker BW3
    {
      get => this._BW3;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DoWorkEventHandler workEventHandler = new DoWorkEventHandler(this.BW3_DoWork);
        RunWorkerCompletedEventHandler completedEventHandler = new RunWorkerCompletedEventHandler(this.BW3_RunWorkerCompleted);
        BackgroundWorker bw3_1 = this._BW3;
        if (bw3_1 != null)
        {
          bw3_1.DoWork -= workEventHandler;
          bw3_1.RunWorkerCompleted -= completedEventHandler;
        }
        this._BW3 = value;
        BackgroundWorker bw3_2 = this._BW3;
        if (bw3_2 == null)
          return;
        bw3_2.DoWork += workEventHandler;
        bw3_2.RunWorkerCompleted += completedEventHandler;
      }
    }

    internal virtual BackgroundWorker BW4
    {
      get => this._BW4;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DoWorkEventHandler workEventHandler = new DoWorkEventHandler(this.BW4_DoWork);
        RunWorkerCompletedEventHandler completedEventHandler = new RunWorkerCompletedEventHandler(this.BW4_RunWorkerCompleted);
        BackgroundWorker bw4_1 = this._BW4;
        if (bw4_1 != null)
        {
          bw4_1.DoWork -= workEventHandler;
          bw4_1.RunWorkerCompleted -= completedEventHandler;
        }
        this._BW4 = value;
        BackgroundWorker bw4_2 = this._BW4;
        if (bw4_2 == null)
          return;
        bw4_2.DoWork += workEventHandler;
        bw4_2.RunWorkerCompleted += completedEventHandler;
      }
    }

    internal virtual BackgroundWorker BW0
    {
      get => this._BW0;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DoWorkEventHandler workEventHandler = new DoWorkEventHandler(this.BW0_DoWork);
        RunWorkerCompletedEventHandler completedEventHandler = new RunWorkerCompletedEventHandler(this.BW0_RunWorkerCompleted);
        BackgroundWorker bw0_1 = this._BW0;
        if (bw0_1 != null)
        {
          bw0_1.DoWork -= workEventHandler;
          bw0_1.RunWorkerCompleted -= completedEventHandler;
        }
        this._BW0 = value;
        BackgroundWorker bw0_2 = this._BW0;
        if (bw0_2 == null)
          return;
        bw0_2.DoWork += workEventHandler;
        bw0_2.RunWorkerCompleted += completedEventHandler;
      }
    }

    internal virtual BackgroundWorker BW5
    {
      get => this._BW5;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DoWorkEventHandler workEventHandler = new DoWorkEventHandler(this.BW5_DoWork);
        RunWorkerCompletedEventHandler completedEventHandler = new RunWorkerCompletedEventHandler(this.BW5_RunWorkerCompleted);
        BackgroundWorker bw5_1 = this._BW5;
        if (bw5_1 != null)
        {
          bw5_1.DoWork -= workEventHandler;
          bw5_1.RunWorkerCompleted -= completedEventHandler;
        }
        this._BW5 = value;
        BackgroundWorker bw5_2 = this._BW5;
        if (bw5_2 == null)
          return;
        bw5_2.DoWork += workEventHandler;
        bw5_2.RunWorkerCompleted += completedEventHandler;
      }
    }

    internal virtual BackgroundWorker BW6
    {
      get => this._BW6;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DoWorkEventHandler workEventHandler = new DoWorkEventHandler(this.BW6_DoWork);
        RunWorkerCompletedEventHandler completedEventHandler = new RunWorkerCompletedEventHandler(this.BW6_RunWorkerCompleted);
        BackgroundWorker bw6_1 = this._BW6;
        if (bw6_1 != null)
        {
          bw6_1.DoWork -= workEventHandler;
          bw6_1.RunWorkerCompleted -= completedEventHandler;
        }
        this._BW6 = value;
        BackgroundWorker bw6_2 = this._BW6;
        if (bw6_2 == null)
          return;
        bw6_2.DoWork += workEventHandler;
        bw6_2.RunWorkerCompleted += completedEventHandler;
      }
    }

    internal virtual BackgroundWorker BW7
    {
      get => this._BW7;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DoWorkEventHandler workEventHandler = new DoWorkEventHandler(this.BW7_DoWork);
        RunWorkerCompletedEventHandler completedEventHandler = new RunWorkerCompletedEventHandler(this.BW7_RunWorkerCompleted);
        BackgroundWorker bw7_1 = this._BW7;
        if (bw7_1 != null)
        {
          bw7_1.DoWork -= workEventHandler;
          bw7_1.RunWorkerCompleted -= completedEventHandler;
        }
        this._BW7 = value;
        BackgroundWorker bw7_2 = this._BW7;
        if (bw7_2 == null)
          return;
        bw7_2.DoWork += workEventHandler;
        bw7_2.RunWorkerCompleted += completedEventHandler;
      }
    }

    internal virtual BackgroundWorker BW8
    {
      get => this._BW8;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        RunWorkerCompletedEventHandler completedEventHandler = new RunWorkerCompletedEventHandler(this.BW8_RunWorkerCompleted);
        BackgroundWorker bw8_1 = this._BW8;
        if (bw8_1 != null)
          bw8_1.RunWorkerCompleted -= completedEventHandler;
        this._BW8 = value;
        BackgroundWorker bw8_2 = this._BW8;
        if (bw8_2 == null)
          return;
        bw8_2.RunWorkerCompleted += completedEventHandler;
      }
    }

    [field: AccessedThroughProperty("brwOverHeating")]
    internal virtual WebBrowser brwOverHeating { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("brwTFEE")]
    internal virtual WebBrowser brwTFEE { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("TabPage11")]
    internal virtual TabPage TabPage11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual BackgroundWorker BW9
    {
      get => this._BW9;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DoWorkEventHandler workEventHandler = new DoWorkEventHandler(this.BW9_DoWork);
        RunWorkerCompletedEventHandler completedEventHandler = new RunWorkerCompletedEventHandler(this.BW9_RunWorkerCompleted);
        BackgroundWorker bw9_1 = this._BW9;
        if (bw9_1 != null)
        {
          bw9_1.DoWork -= workEventHandler;
          bw9_1.RunWorkerCompleted -= completedEventHandler;
        }
        this._BW9 = value;
        BackgroundWorker bw9_2 = this._BW9;
        if (bw9_2 == null)
          return;
        bw9_2.DoWork += workEventHandler;
        bw9_2.RunWorkerCompleted += completedEventHandler;
      }
    }

    [field: AccessedThroughProperty("brwCarbonZero")]
    internal virtual WebBrowser brwCarbonZero { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("TabPage5")]
    internal virtual TabPage TabPage5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("brwFabric")]
    internal virtual WebBrowser brwFabric { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual BackgroundWorker BW10
    {
      get => this._BW10;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DoWorkEventHandler workEventHandler = new DoWorkEventHandler(this.BW10_DoWork);
        RunWorkerCompletedEventHandler completedEventHandler = new RunWorkerCompletedEventHandler(this.BW10_RunWorkerCompleted);
        BackgroundWorker bw10_1 = this._BW10;
        if (bw10_1 != null)
        {
          bw10_1.DoWork -= workEventHandler;
          bw10_1.RunWorkerCompleted -= completedEventHandler;
        }
        this._BW10 = value;
        BackgroundWorker bw10_2 = this._BW10;
        if (bw10_2 == null)
          return;
        bw10_2.DoWork += workEventHandler;
        bw10_2.RunWorkerCompleted += completedEventHandler;
      }
    }

    internal virtual CheckBox ChkComplinaceSave
    {
      get => this._ChkComplinaceSave;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ChkComplinaceSave_CheckedChanged);
        CheckBox chkComplinaceSave1 = this._ChkComplinaceSave;
        if (chkComplinaceSave1 != null)
          chkComplinaceSave1.CheckedChanged -= eventHandler;
        this._ChkComplinaceSave = value;
        CheckBox chkComplinaceSave2 = this._ChkComplinaceSave;
        if (chkComplinaceSave2 == null)
          return;
        chkComplinaceSave2.CheckedChanged += eventHandler;
      }
    }

    internal virtual Button cmdComplinaceSave
    {
      get => this._cmdComplinaceSave;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdComplinaceSave_Click);
        Button cmdComplinaceSave1 = this._cmdComplinaceSave;
        if (cmdComplinaceSave1 != null)
          cmdComplinaceSave1.Click -= eventHandler;
        this._cmdComplinaceSave = value;
        Button cmdComplinaceSave2 = this._cmdComplinaceSave;
        if (cmdComplinaceSave2 == null)
          return;
        cmdComplinaceSave2.Click += eventHandler;
      }
    }

    internal virtual ToolStripButton ToolStripButton3
    {
      get => this._ToolStripButton3;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ToolStripButton3_Click);
        ToolStripButton toolStripButton3_1 = this._ToolStripButton3;
        if (toolStripButton3_1 != null)
          toolStripButton3_1.Click -= eventHandler;
        this._ToolStripButton3 = value;
        ToolStripButton toolStripButton3_2 = this._ToolStripButton3;
        if (toolStripButton3_2 == null)
          return;
        toolStripButton3_2.Click += eventHandler;
      }
    }

    internal virtual ToolStripButton ToolStripButton2
    {
      get => this._ToolStripButton2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ToolStripButton2_Click);
        ToolStripButton toolStripButton2_1 = this._ToolStripButton2;
        if (toolStripButton2_1 != null)
          toolStripButton2_1.Click -= eventHandler;
        this._ToolStripButton2 = value;
        ToolStripButton toolStripButton2_2 = this._ToolStripButton2;
        if (toolStripButton2_2 == null)
          return;
        toolStripButton2_2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("FBD1")]
    internal virtual FolderBrowserDialog FBD1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual BackgroundWorker BW11
    {
      get => this._BW11;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DoWorkEventHandler workEventHandler = new DoWorkEventHandler(this.BW11_DoWork);
        RunWorkerCompletedEventHandler completedEventHandler = new RunWorkerCompletedEventHandler(this.BW11_RunWorkerCompleted);
        BackgroundWorker bw11_1 = this._BW11;
        if (bw11_1 != null)
        {
          bw11_1.DoWork -= workEventHandler;
          bw11_1.RunWorkerCompleted -= completedEventHandler;
        }
        this._BW11 = value;
        BackgroundWorker bw11_2 = this._BW11;
        if (bw11_2 == null)
          return;
        bw11_2.DoWork += workEventHandler;
        bw11_2.RunWorkerCompleted += completedEventHandler;
      }
    }

    internal virtual BackgroundWorker BW12
    {
      get => this._BW12;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        RunWorkerCompletedEventHandler completedEventHandler = new RunWorkerCompletedEventHandler(this.BW12_RunWorkerCompleted);
        DoWorkEventHandler workEventHandler = new DoWorkEventHandler(this.BW12_DoWork);
        BackgroundWorker bw12_1 = this._BW12;
        if (bw12_1 != null)
        {
          bw12_1.RunWorkerCompleted -= completedEventHandler;
          bw12_1.DoWork -= workEventHandler;
        }
        this._BW12 = value;
        BackgroundWorker bw12_2 = this._BW12;
        if (bw12_2 == null)
          return;
        bw12_2.RunWorkerCompleted += completedEventHandler;
        bw12_2.DoWork += workEventHandler;
      }
    }

    [field: AccessedThroughProperty("TabPage12")]
    internal virtual TabPage TabPage12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("brwCosts")]
    internal virtual WebBrowser brwCosts { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("TabPage13")]
    internal virtual TabPage TabPage13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual BackgroundWorker BW13
    {
      get => this._BW13;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        RunWorkerCompletedEventHandler completedEventHandler = new RunWorkerCompletedEventHandler(this.BW13_RunWorkerCompleted);
        DoWorkEventHandler workEventHandler = new DoWorkEventHandler(this.BW13_DoWork);
        BackgroundWorker bw13_1 = this._BW13;
        if (bw13_1 != null)
        {
          bw13_1.RunWorkerCompleted -= completedEventHandler;
          bw13_1.DoWork -= workEventHandler;
        }
        this._BW13 = value;
        BackgroundWorker bw13_2 = this._BW13;
        if (bw13_2 == null)
          return;
        bw13_2.RunWorkerCompleted += completedEventHandler;
        bw13_2.DoWork += workEventHandler;
      }
    }

    [field: AccessedThroughProperty("BrWDeveloper")]
    internal virtual WebBrowser BrWDeveloper { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private void ToolStripButton1_Click(object sender, EventArgs e) => this.Close();

    public bool FileExists(string FileFullPath) => new FileInfo(FileFullPath).Exists;

    private void Reports_Load(object sender, EventArgs e)
    {
      PDFFunctions.document.Dispose();
      L1ACheckList.SAP09DataOperation = false;
      this.cmdComplinaceSave.Visible = Validation.UserLogged;
      this.Location = MyProject.Forms.SAPForm.Location;
      this.Size = MyProject.Forms.SAPForm.Size;
      PDFFunctions.Draft_PDF = true;
      object folderPath = (object) Environment.GetFolderPath(Environment.SpecialFolder.Personal);
      DirectoryInfo directoryInfo1 = new DirectoryInfo(Conversions.ToString(Operators.ConcatenateObject(folderPath, (object) "\\Stroma SAP 2012")));
      DirectoryInfo directoryInfo2 = new DirectoryInfo(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(folderPath, (object) "\\Stroma SAP 2012\\"), (object) SAP_Module.Proj.Name)));
      DirectoryInfo directoryInfo3 = new DirectoryInfo(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(folderPath, (object) "\\Stroma SAP 2012\\"), (object) SAP_Module.Proj.Name), (object) "\\"), (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Name)));
      if (!directoryInfo1.Exists)
        directoryInfo1.Create();
      if (!directoryInfo2.Exists)
        directoryInfo2.Create();
      if (!directoryInfo3.Exists)
        directoryInfo3.Create();
      SAP_Module.PDFFileName = "";
      this.PB1.Visible = true;
      this.BW0.RunWorkerAsync();
      this.TabControl1.Controls.Remove((Control) this.TabPage11);
      this.TabControl1.Controls.Remove((Control) this.TabPage10);
      this.TabControl1.Controls.Remove((Control) this.TabPage6);
    }

    private void BW0_DoWork(object sender, DoWorkEventArgs e)
    {
      int Country = Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Address.Country, "Northern Ireland", false) != 0 ? (!(Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Address.Country, "Wales", false) == 0 & Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].EPCLanguage, "Welsh", false) == 0) ? 1 : 2) : 3;
      Calc2012 calc2012 = new Calc2012();
      calc2012.SETPCDF(SAP_Module.PCDFData);
      calc2012.Dwelling = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling];
      SAP_Module.Calculation2012 = calc2012;
      SAPInput.CreateSAPInput(SAP_Module.CurrDwelling, Country);
    }

    private void BW0_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      this.brwSAPInput.Navigate(SAP_Module.PDFFileName);
      this.BW1.RunWorkerAsync();
      this.PB1.Value = 1;
    }

    private void BW1_DoWork(object sender, DoWorkEventArgs e)
    {
      Calc2012 MyCal = new Calc2012();
      MyCal.SETPCDF(SAP_Module.PCDFData);
      MyCal.Dwelling = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling];
      SAP2009_WorkSheet.Stroma_Sap2009Worksheet(SAP_Module.CurrDwelling, MyCal, 1, SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling]);
    }

    private void BW1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      this.brwSAPWork.Navigate(SAP_Module.PDFFileName);
      this.BW2.RunWorkerAsync();
      this.PB1.Value = 2;
    }

    private void BW2_DoWork(object sender, DoWorkEventArgs e)
    {
      Calc2012 MyCal = new Calc2012()
      {
        DTER = true
      };
      MyCal.SETPCDF(SAP_Module.PCDFData);
      MyCal.Dwelling = SAP_Module.TERDwelling;
      SAP2009_WorkSheet.Stroma_Sap2009Worksheet(SAP_Module.CurrDwelling, MyCal, 3, SAP_Module.TERDwelling);
    }

    private void BW2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      this.brwTERWork.Navigate(SAP_Module.PDFFileName);
      this.BW3.RunWorkerAsync();
      this.PB1.Value = 3;
    }

    private void BW3_DoWork(object sender, DoWorkEventArgs e)
    {
      Calc2012 MyCal = new Calc2012()
      {
        DTER = true
      };
      MyCal.SETPCDF(SAP_Module.PCDFData);
      MyCal.Dwelling = SAP_Module.DERDwelling;
      SAP2009_WorkSheet.Stroma_Sap2009Worksheet(SAP_Module.CurrDwelling, MyCal, 2, SAP_Module.DERDwelling);
    }

    private void BW3_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      this.brwDERWork.Navigate(SAP_Module.PDFFileName);
      this.BW10.RunWorkerAsync();
      this.PB1.Value = 4;
    }

    private void BW10_DoWork(object sender, DoWorkEventArgs e)
    {
      Calc2012 calc2012 = new Calc2012();
      SAP_Module.Dwelling feeDwelling = Functions.GetFEEDwelling(ref SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling]);
      calc2012.SETPCDF(SAP_Module.PCDFData);
      calc2012.IsFabricEfficiency = true;
      calc2012.Dwelling = feeDwelling;
      double box109 = SAP_Module.CalculationFabric.Calculation.Fabric_Energy_Efficiency.Box109;
      SAP2009_WorkSheet.Stroma_Sap2009Worksheet(SAP_Module.CurrDwelling, SAP_Module.CalculationFabric, 5, feeDwelling);
    }

    private void BW10_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      this.brwFabric.Navigate(SAP_Module.PDFFileName);
      this.BW11.RunWorkerAsync();
      this.PB1.Value = 5;
    }

    private void BW11_DoWork(object sender, DoWorkEventArgs e)
    {
      Calc2012 MyCal = new Calc2012();
      SAP_Module.Dwelling feeDwelling = Functions.GetFEEDwelling(ref SAP_Module.TERDwelling);
      MyCal.SETPCDF(SAP_Module.PCDFData);
      MyCal.IsFabricEfficiency = true;
      MyCal.Dwelling = feeDwelling;
      SAP2009_WorkSheet.Stroma_Sap2009Worksheet(SAP_Module.CurrDwelling, MyCal, 6, feeDwelling);
    }

    private void BW11_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      this.brwTFEE.Navigate(SAP_Module.PDFFileName);
      this.BW5.RunWorkerAsync();
      this.PB1.Value = 7;
    }

    private void BW5_DoWork(object sender, DoWorkEventArgs e)
    {
      Calc2012 MyCal = new Calc2012();
      MyCal.SETPCDF(SAP_Module.PCDFData);
      MyCal.Dwelling = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling];
      L1ACheckList.L1ACheckListCreate(SAP_Module.CurrDwelling, MyCal);
    }

    private void BW5_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      this.brwComplience.Navigate(SAP_Module.SAPCheckListName);
      this.PB1.Value = 8;
      if (Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Overheat, "Yes", false) == 0)
      {
        this.BW6.RunWorkerAsync();
      }
      else
      {
        this.BW12.RunWorkerAsync();
        this.TabControl1.Controls.Remove((Control) this.Tabpage8);
        this.PB1.Visible = false;
      }
    }

    private void BW12_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      this.brwCosts.Navigate(SAP_Module.PDFFileName);
      this.BW13.RunWorkerAsync();
    }

    private void BW4_DoWork(object sender, DoWorkEventArgs e)
    {
      Functions.CalculateNow();
      SAP2009_WorkSheet.Stroma_Sap2009Worksheet(SAP_Module.CurrDwelling, SAP_Module.CalculationImprove2012, 4, SAP_Module.ImproveDwelling);
    }

    private void BW4_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      Functions.CalculateNow();
      this.brwImproved.Navigate(SAP_Module.PDFFileName);
      this.PB1.Value = 5;
    }

    private void BW6_DoWork(object sender, DoWorkEventArgs e)
    {
      Calc2012 calc2012 = new Calc2012();
      calc2012.SETPCDF(SAP_Module.PCDFData);
      calc2012.Dwelling = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling];
      SAPInput.CreateOverHeatingDoc(SAP_Module.CurrDwelling, 1);
    }

    private void BW6_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      this.brwOverHeating.Navigate(SAP_Module.SAPOverHeatingName);
      this.PB1.Value = 7;
      this.PB1.Visible = false;
      this.BW12.RunWorkerAsync();
    }

    private void BW7_DoWork(object sender, DoWorkEventArgs e)
    {
      CreatePDF createPdf = new CreatePDF();
      int num = Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Address.Country, "Scotland", false) != 0 ? 1 : 4;
      PDFFunctions.Draft_PDF = true;
      createPdf.CreateSAPXML(SAP_Module.CurrDwelling, 1);
    }

    private void BW7_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      this.brwSAPEPC.Navigate(SAP_Module.SAPEPCName);
      this.BW8.RunWorkerAsync();
      this.PB1.Value = 8;
    }

    private void BW9_DoWork(object sender, DoWorkEventArgs e) => SAPInput.CreateZeroCarbon(SAP_Module.CurrDwelling);

    private void BW9_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      this.brwCarbonZero.Navigate(SAP_Module.ZerocarbonEPC);
      this.PB1.Value = 9;
      this.PB1.Visible = false;
    }

    private void BW8_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      this.brwTFEE.Navigate(SAP_Module.SAPXMLName);
      if ((SAP_Module.CalcualtionDER2012.Calculation.CO2_Emissions_12a.Box273 != 0.0 ? SAP_Module.CalcualtionDER2012.Calculation.CO2_Emissions_12a.Box273 : SAP_Module.CalcualtionDER2012.Calculation.CO2_Emissions_12b.Box384) < 0.0)
      {
        this.BW9.RunWorkerAsync();
        this.PB1.Value = 8;
      }
      else
        this.PB1.Value = 9;
      if (Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Overheat, "Yes", false) != 0)
        return;
      this.BW6.RunWorkerAsync();
    }

    private void ChkComplinaceSave_CheckedChanged(object sender, EventArgs e)
    {
    }

    private void cmdComplinaceSave_Click(object sender, EventArgs e)
    {
      try
      {
        L1ACheckList.SAP09DataOperation = true;
        this.brwComplience.Navigate("");
        Application.DoEvents();
        Calc2012 MyCal = new Calc2012();
        MyCal.SETPCDF(SAP_Module.PCDFData);
        MyCal.Dwelling = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling];
        L1ACheckList.L1ACheckListCreate(SAP_Module.CurrDwelling, MyCal);
        Application.DoEvents();
        string Left = L1ACheckList.SaveInput_AND_ComplinaceDetails(SAP_Module.CurrDwelling);
        if ((uint) Operators.CompareString(Left, "", false) > 0U)
        {
          int num = (int) new Error_Message()
          {
            txtError = {
              Text = Left
            }
          }.ShowDialog();
        }
        else
        {
          this.brwComplience.Navigate(SAP_Module.SAPCheckListName);
          L1ACheckList.SAP09DataOperation = false;
          this.cmdComplinaceSave.Enabled = false;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        L1ACheckList.SAP09DataOperation = false;
        ProjectData.ClearProjectError();
      }
    }

    private void ToolStripButton3_Click(object sender, EventArgs e)
    {
      try
      {
        NewLateBinding.LateCall((object) null, typeof (Process), "Start", new object[1]
        {
          Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object) Environment.GetFolderPath(Environment.SpecialFolder.Personal), (object) "\\Stroma SAP 2012\\"), (object) SAP_Module.Proj.Name), (object) "\\"), (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Name)
        }, (string[]) null, (System.Type[]) null, (bool[]) null, true);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void ToolStripButton2_Click(object sender, EventArgs e)
    {
      this.FBD1.ShowNewFolderButton = true;
      object folderPath = (object) Environment.GetFolderPath(Environment.SpecialFolder.Personal);
      try
      {
        if (this.FBD1.ShowDialog() != DialogResult.Cancel && Operators.CompareString(this.FBD1.SelectedPath, "", false) != 0)
        {
          MyProject.Computer.FileSystem.CopyDirectory(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(folderPath, (object) "\\Stroma SAP 2012\\"), (object) SAP_Module.Proj.Name), (object) "\\"), (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Name)), this.FBD1.SelectedPath, true);
          Process.Start("explorer.exe", this.FBD1.SelectedPath);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void BW12_DoWork(object sender, DoWorkEventArgs e)
    {
      Calc2012 calc2012 = new Calc2012();
      calc2012.SETPCDF(SAP_Module.PCDFData);
      calc2012.Dwelling = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling];
      SAP2009_WorkSheet.Stroma_Sap2009Worksheet(SAP_Module.CurrDwelling, SAP_Module.Calculation2012Regional, 7, SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling]);
    }

    private void BW13_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      this.BrWDeveloper.Navigate(SAP_Module.PDFFileName);
      string country = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Address.Country;
      if (Operators.CompareString(country, "Scotland", false) != 0 && Operators.CompareString(country, "Wales", false) != 0)
        return;
      this.TabControl1.Controls.Remove((Control) this.TabPage5);
      this.TabControl1.Controls.Remove((Control) this.TabPage9);
    }

    private void BW13_DoWork(object sender, DoWorkEventArgs e)
    {
      int Country = Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Address.Country, "Northern Ireland", false) != 0 ? (!(Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Address.Country, "Wales", false) == 0 & Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].EPCLanguage, "Welsh", false) == 0) ? 1 : 2) : 3;
      Calc2012 calc2012 = new Calc2012();
      calc2012.SETPCDF(SAP_Module.PCDFData);
      calc2012.Dwelling = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling];
      SAP_Module.Calculation2012 = calc2012;
      DeveloperReport.CreateDeveloperReport(SAP_Module.CurrDwelling, Country);
    }
  }
}
