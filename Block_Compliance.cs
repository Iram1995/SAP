
// Type: SAP2012.Block_Compliance




using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using SAP2012.My;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SAP2012
{
  [DesignerGenerated]
  public class Block_Compliance : Form
  {
    private IContainer components;
    private int CurrBlock;
    private int k;
    private int RC1;
    private float ImageHeight;
    private float ImageWidth;
    private float ImageX;
    private float ImageY;
    private float Con;
    private bool FinishedTable;

    public Block_Compliance()
    {
      this.Load += new EventHandler(this.Block_Compliance_Load);
      this.Con = 2.833f;
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Block_Compliance));
      this.TreeSAP = new TreeView();
      this.TreeImages = new ImageList(this.components);
      this.cmdBiolerData = new Button();
      this.Panel1 = new Panel();
      this.cmdReport = new Button();
      this.Button1 = new Button();
      this.GroupBox1 = new GroupBox();
      this.DGSummary = new DataGridView();
      this.GroupBox2 = new GroupBox();
      this.cmdAddDwelling = new Button();
      this.lstAllDwellings = new ListBox();
      this.GroupBox3 = new GroupBox();
      this.cmdRemoveDwelling = new Button();
      this.lstBlockDwellings = new ListBox();
      this.GroupBox4 = new GroupBox();
      this.txtCompliance = new TextBox();
      this.Label4 = new Label();
      this.txtTER = new TextBox();
      this.Label3 = new Label();
      this.txtDER = new TextBox();
      this.Label2 = new Label();
      this.txtAREA = new TextBox();
      this.Label1 = new Label();
      this.EditMenu = new ContextMenuStrip(this.components);
      this.DeleteToolStripMenuItem = new ToolStripMenuItem();
      this.ToolStripMenuItem14 = new ToolStripSeparator();
      this.Label5 = new Label();
      this.Label6 = new Label();
      this.txtDFEE = new TextBox();
      this.txtTFEE = new TextBox();
      this.Panel1.SuspendLayout();
      this.GroupBox1.SuspendLayout();
      ((ISupportInitialize) this.DGSummary).BeginInit();
      this.GroupBox2.SuspendLayout();
      this.GroupBox3.SuspendLayout();
      this.GroupBox4.SuspendLayout();
      this.EditMenu.SuspendLayout();
      this.SuspendLayout();
      this.TreeSAP.Cursor = Cursors.Hand;
      this.TreeSAP.Dock = DockStyle.Left;
      this.TreeSAP.ImageIndex = 0;
      this.TreeSAP.ImageList = this.TreeImages;
      this.TreeSAP.Location = new Point(0, 0);
      this.TreeSAP.Name = "TreeSAP";
      this.TreeSAP.SelectedImageIndex = 0;
      this.TreeSAP.Size = new Size(192, 500);
      this.TreeSAP.TabIndex = 0;
      this.TreeImages.ImageStream = (ImageListStreamer) componentResourceManager.GetObject("TreeImages.ImageStream");
      this.TreeImages.TransparentColor = Color.Transparent;
      this.TreeImages.Images.SetKeyName(0, "1.gif");
      this.TreeImages.Images.SetKeyName(1, "autoList.ico");
      this.TreeImages.Images.SetKeyName(2, "ARW02RT.ICO");
      this.cmdBiolerData.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.cmdBiolerData.BackColor = Color.LightSlateGray;
      this.cmdBiolerData.Cursor = Cursors.Hand;
      this.cmdBiolerData.FlatStyle = FlatStyle.Popup;
      this.cmdBiolerData.ForeColor = Color.White;
      this.cmdBiolerData.Location = new Point(599, 6);
      this.cmdBiolerData.Name = "cmdBiolerData";
      this.cmdBiolerData.Size = new Size(180, 23);
      this.cmdBiolerData.TabIndex = 17;
      this.cmdBiolerData.Text = "New Block";
      this.cmdBiolerData.UseVisualStyleBackColor = false;
      this.Panel1.Controls.Add((Control) this.cmdReport);
      this.Panel1.Controls.Add((Control) this.Button1);
      this.Panel1.Controls.Add((Control) this.cmdBiolerData);
      this.Panel1.Dock = DockStyle.Bottom;
      this.Panel1.Location = new Point(0, 500);
      this.Panel1.Name = "Panel1";
      this.Panel1.Size = new Size(784, 62);
      this.Panel1.TabIndex = 18;
      this.cmdReport.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.cmdReport.BackColor = Color.LightSlateGray;
      this.cmdReport.Cursor = Cursors.Hand;
      this.cmdReport.FlatStyle = FlatStyle.Popup;
      this.cmdReport.ForeColor = Color.White;
      this.cmdReport.Location = new Point(12, 6);
      this.cmdReport.Name = "cmdReport";
      this.cmdReport.Size = new Size(180, 23);
      this.cmdReport.TabIndex = 19;
      this.cmdReport.Text = "Create Report";
      this.cmdReport.UseVisualStyleBackColor = false;
      this.Button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.Button1.BackColor = Color.LightSlateGray;
      this.Button1.Cursor = Cursors.Hand;
      this.Button1.DialogResult = DialogResult.OK;
      this.Button1.FlatStyle = FlatStyle.Popup;
      this.Button1.ForeColor = Color.White;
      this.Button1.Location = new Point(599, 35);
      this.Button1.Name = "Button1";
      this.Button1.Size = new Size(180, 23);
      this.Button1.TabIndex = 18;
      this.Button1.Text = "Close";
      this.Button1.UseVisualStyleBackColor = false;
      this.GroupBox1.Controls.Add((Control) this.DGSummary);
      this.GroupBox1.Location = new Point(193, 273);
      this.GroupBox1.Name = "GroupBox1";
      this.GroupBox1.Size = new Size(290, 221);
      this.GroupBox1.TabIndex = 19;
      this.GroupBox1.TabStop = false;
      this.GroupBox1.Text = "Analysis";
      this.DGSummary.AllowUserToAddRows = false;
      this.DGSummary.AllowUserToDeleteRows = false;
      this.DGSummary.AllowUserToResizeColumns = false;
      this.DGSummary.AllowUserToResizeRows = false;
      this.DGSummary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.DGSummary.Dock = DockStyle.Fill;
      this.DGSummary.Location = new Point(3, 17);
      this.DGSummary.Name = "DGSummary";
      this.DGSummary.ReadOnly = true;
      this.DGSummary.RowHeadersVisible = false;
      this.DGSummary.Size = new Size(284, 201);
      this.DGSummary.TabIndex = 0;
      this.GroupBox2.Controls.Add((Control) this.cmdAddDwelling);
      this.GroupBox2.Controls.Add((Control) this.lstAllDwellings);
      this.GroupBox2.Location = new Point(193, 0);
      this.GroupBox2.Name = "GroupBox2";
      this.GroupBox2.Size = new Size(290, 267);
      this.GroupBox2.TabIndex = 20;
      this.GroupBox2.TabStop = false;
      this.GroupBox2.Text = "Current Dwellings in Project";
      this.cmdAddDwelling.BackColor = Color.LightSlateGray;
      this.cmdAddDwelling.Cursor = Cursors.Hand;
      this.cmdAddDwelling.Dock = DockStyle.Bottom;
      this.cmdAddDwelling.FlatStyle = FlatStyle.Popup;
      this.cmdAddDwelling.ForeColor = Color.White;
      this.cmdAddDwelling.Location = new Point(3, 241);
      this.cmdAddDwelling.Name = "cmdAddDwelling";
      this.cmdAddDwelling.Size = new Size(284, 23);
      this.cmdAddDwelling.TabIndex = 18;
      this.cmdAddDwelling.Text = "Add ->";
      this.cmdAddDwelling.UseVisualStyleBackColor = false;
      this.lstAllDwellings.Cursor = Cursors.Hand;
      this.lstAllDwellings.Dock = DockStyle.Top;
      this.lstAllDwellings.FormattingEnabled = true;
      this.lstAllDwellings.Location = new Point(3, 17);
      this.lstAllDwellings.Name = "lstAllDwellings";
      this.lstAllDwellings.SelectionMode = SelectionMode.MultiExtended;
      this.lstAllDwellings.Size = new Size(284, 225);
      this.lstAllDwellings.TabIndex = 0;
      this.GroupBox3.Controls.Add((Control) this.cmdRemoveDwelling);
      this.GroupBox3.Controls.Add((Control) this.lstBlockDwellings);
      this.GroupBox3.Location = new Point(489, 0);
      this.GroupBox3.Name = "GroupBox3";
      this.GroupBox3.Size = new Size(290, 267);
      this.GroupBox3.TabIndex = 21;
      this.GroupBox3.TabStop = false;
      this.GroupBox3.Text = "Dwellings in the Group";
      this.cmdRemoveDwelling.BackColor = Color.LightSlateGray;
      this.cmdRemoveDwelling.Cursor = Cursors.Hand;
      this.cmdRemoveDwelling.Dock = DockStyle.Bottom;
      this.cmdRemoveDwelling.FlatStyle = FlatStyle.Popup;
      this.cmdRemoveDwelling.ForeColor = Color.White;
      this.cmdRemoveDwelling.Location = new Point(3, 241);
      this.cmdRemoveDwelling.Name = "cmdRemoveDwelling";
      this.cmdRemoveDwelling.Size = new Size(284, 23);
      this.cmdRemoveDwelling.TabIndex = 20;
      this.cmdRemoveDwelling.Text = "<- Remove";
      this.cmdRemoveDwelling.UseVisualStyleBackColor = false;
      this.lstBlockDwellings.Cursor = Cursors.Hand;
      this.lstBlockDwellings.Dock = DockStyle.Top;
      this.lstBlockDwellings.FormattingEnabled = true;
      this.lstBlockDwellings.Location = new Point(3, 17);
      this.lstBlockDwellings.Name = "lstBlockDwellings";
      this.lstBlockDwellings.SelectionMode = SelectionMode.MultiExtended;
      this.lstBlockDwellings.Size = new Size(284, 225);
      this.lstBlockDwellings.TabIndex = 19;
      this.GroupBox4.Controls.Add((Control) this.txtTFEE);
      this.GroupBox4.Controls.Add((Control) this.txtDFEE);
      this.GroupBox4.Controls.Add((Control) this.Label5);
      this.GroupBox4.Controls.Add((Control) this.Label6);
      this.GroupBox4.Controls.Add((Control) this.txtCompliance);
      this.GroupBox4.Controls.Add((Control) this.Label4);
      this.GroupBox4.Controls.Add((Control) this.txtTER);
      this.GroupBox4.Controls.Add((Control) this.Label3);
      this.GroupBox4.Controls.Add((Control) this.txtDER);
      this.GroupBox4.Controls.Add((Control) this.Label2);
      this.GroupBox4.Controls.Add((Control) this.txtAREA);
      this.GroupBox4.Controls.Add((Control) this.Label1);
      this.GroupBox4.Location = new Point(489, 273);
      this.GroupBox4.Name = "GroupBox4";
      this.GroupBox4.Size = new Size(290, 221);
      this.GroupBox4.TabIndex = 22;
      this.GroupBox4.TabStop = false;
      this.GroupBox4.Text = "Results";
      this.txtCompliance.BackColor = Color.White;
      this.txtCompliance.BorderStyle = BorderStyle.None;
      this.txtCompliance.Location = new Point(130, 165);
      this.txtCompliance.Name = "txtCompliance";
      this.txtCompliance.ReadOnly = true;
      this.txtCompliance.Size = new Size(100, 14);
      this.txtCompliance.TabIndex = 7;
      this.Label4.AutoSize = true;
      this.Label4.Location = new Point(40, 165);
      this.Label4.Name = "Label4";
      this.Label4.Size = new Size(61, 13);
      this.Label4.TabIndex = 6;
      this.Label4.Text = "Compliance";
      this.txtTER.BackColor = Color.White;
      this.txtTER.BorderStyle = BorderStyle.None;
      this.txtTER.Location = new Point(130, 90);
      this.txtTER.Name = "txtTER";
      this.txtTER.ReadOnly = true;
      this.txtTER.Size = new Size(100, 14);
      this.txtTER.TabIndex = 5;
      this.Label3.AutoSize = true;
      this.Label3.Location = new Point(40, 90);
      this.Label3.Name = "Label3";
      this.Label3.Size = new Size(70, 13);
      this.Label3.TabIndex = 4;
      this.Label3.Text = "Average TER";
      this.txtDER.BackColor = Color.White;
      this.txtDER.BorderStyle = BorderStyle.None;
      this.txtDER.Location = new Point(130, 65);
      this.txtDER.Name = "txtDER";
      this.txtDER.ReadOnly = true;
      this.txtDER.Size = new Size(100, 14);
      this.txtDER.TabIndex = 3;
      this.Label2.AutoSize = true;
      this.Label2.Location = new Point(40, 65);
      this.Label2.Name = "Label2";
      this.Label2.Size = new Size(71, 13);
      this.Label2.TabIndex = 2;
      this.Label2.Text = "Average DER";
      this.txtAREA.BackColor = Color.White;
      this.txtAREA.BorderStyle = BorderStyle.None;
      this.txtAREA.Location = new Point(130, 40);
      this.txtAREA.Name = "txtAREA";
      this.txtAREA.ReadOnly = true;
      this.txtAREA.Size = new Size(100, 14);
      this.txtAREA.TabIndex = 1;
      this.Label1.AutoSize = true;
      this.Label1.Location = new Point(40, 40);
      this.Label1.Name = "Label1";
      this.Label1.Size = new Size(84, 13);
      this.Label1.TabIndex = 0;
      this.Label1.Text = "Total Floor Area";
      this.EditMenu.Items.AddRange(new ToolStripItem[2]
      {
        (ToolStripItem) this.DeleteToolStripMenuItem,
        (ToolStripItem) this.ToolStripMenuItem14
      });
      this.EditMenu.Name = "EditMenu";
      this.EditMenu.Size = new Size(108, 32);
      this.DeleteToolStripMenuItem.Image = (Image) componentResourceManager.GetObject("DeleteToolStripMenuItem.Image");
      this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
      this.DeleteToolStripMenuItem.Size = new Size(107, 22);
      this.DeleteToolStripMenuItem.Text = "Delete";
      this.ToolStripMenuItem14.Name = "ToolStripMenuItem14";
      this.ToolStripMenuItem14.Size = new Size(104, 6);
      this.Label5.AutoSize = true;
      this.Label5.Location = new Point(40, 140);
      this.Label5.Name = "Label5";
      this.Label5.Size = new Size(75, 13);
      this.Label5.TabIndex = 9;
      this.Label5.Text = "Average TFEE";
      this.Label6.AutoSize = true;
      this.Label6.Location = new Point(40, 115);
      this.Label6.Name = "Label6";
      this.Label6.Size = new Size(76, 13);
      this.Label6.TabIndex = 8;
      this.Label6.Text = "Average DFEE";
      this.txtDFEE.BackColor = Color.White;
      this.txtDFEE.BorderStyle = BorderStyle.None;
      this.txtDFEE.Location = new Point(130, 115);
      this.txtDFEE.Name = "txtDFEE";
      this.txtDFEE.ReadOnly = true;
      this.txtDFEE.Size = new Size(100, 14);
      this.txtDFEE.TabIndex = 10;
      this.txtTFEE.BackColor = Color.White;
      this.txtTFEE.BorderStyle = BorderStyle.None;
      this.txtTFEE.Location = new Point(130, 140);
      this.txtTFEE.Name = "txtTFEE";
      this.txtTFEE.ReadOnly = true;
      this.txtTFEE.Size = new Size(100, 14);
      this.txtTFEE.TabIndex = 11;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.White;
      this.ClientSize = new Size(784, 562);
      this.Controls.Add((Control) this.GroupBox4);
      this.Controls.Add((Control) this.GroupBox3);
      this.Controls.Add((Control) this.GroupBox2);
      this.Controls.Add((Control) this.GroupBox1);
      this.Controls.Add((Control) this.TreeSAP);
      this.Controls.Add((Control) this.Panel1);
      this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (Block_Compliance);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Block Compliance";
      this.Panel1.ResumeLayout(false);
      this.GroupBox1.ResumeLayout(false);
      ((ISupportInitialize) this.DGSummary).EndInit();
      this.GroupBox2.ResumeLayout(false);
      this.GroupBox3.ResumeLayout(false);
      this.GroupBox4.ResumeLayout(false);
      this.GroupBox4.PerformLayout();
      this.EditMenu.ResumeLayout(false);
      this.ResumeLayout(false);
    }

    internal virtual TreeView TreeSAP
    {
      get => this._TreeSAP;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        TreeViewEventHandler viewEventHandler = new TreeViewEventHandler(this.TreeSAP_AfterSelect);
        TreeView treeSap1 = this._TreeSAP;
        if (treeSap1 != null)
          treeSap1.AfterSelect -= viewEventHandler;
        this._TreeSAP = value;
        TreeView treeSap2 = this._TreeSAP;
        if (treeSap2 == null)
          return;
        treeSap2.AfterSelect += viewEventHandler;
      }
    }

    internal virtual Button cmdBiolerData
    {
      get => this._cmdBiolerData;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdBiolerData_Click);
        Button cmdBiolerData1 = this._cmdBiolerData;
        if (cmdBiolerData1 != null)
          cmdBiolerData1.Click -= eventHandler;
        this._cmdBiolerData = value;
        Button cmdBiolerData2 = this._cmdBiolerData;
        if (cmdBiolerData2 == null)
          return;
        cmdBiolerData2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Panel1")]
    internal virtual Panel Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Button1")]
    internal virtual Button Button1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox1")]
    internal virtual GroupBox GroupBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DGSummary")]
    internal virtual DataGridView DGSummary { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox2")]
    internal virtual GroupBox GroupBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button cmdAddDwelling
    {
      get => this._cmdAddDwelling;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdAddDwelling_Click);
        Button cmdAddDwelling1 = this._cmdAddDwelling;
        if (cmdAddDwelling1 != null)
          cmdAddDwelling1.Click -= eventHandler;
        this._cmdAddDwelling = value;
        Button cmdAddDwelling2 = this._cmdAddDwelling;
        if (cmdAddDwelling2 == null)
          return;
        cmdAddDwelling2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("lstAllDwellings")]
    internal virtual ListBox lstAllDwellings { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox3")]
    internal virtual GroupBox GroupBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button cmdRemoveDwelling
    {
      get => this._cmdRemoveDwelling;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdRemoveDwelling_Click);
        Button cmdRemoveDwelling1 = this._cmdRemoveDwelling;
        if (cmdRemoveDwelling1 != null)
          cmdRemoveDwelling1.Click -= eventHandler;
        this._cmdRemoveDwelling = value;
        Button cmdRemoveDwelling2 = this._cmdRemoveDwelling;
        if (cmdRemoveDwelling2 == null)
          return;
        cmdRemoveDwelling2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("lstBlockDwellings")]
    internal virtual ListBox lstBlockDwellings { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox4")]
    internal virtual GroupBox GroupBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtCompliance")]
    internal virtual TextBox txtCompliance { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label4")]
    internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtTER")]
    internal virtual TextBox txtTER { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label3")]
    internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtDER")]
    internal virtual TextBox txtDER { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label2")]
    internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtAREA")]
    internal virtual TextBox txtAREA { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label1")]
    internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("TreeImages")]
    internal virtual ImageList TreeImages { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button cmdReport
    {
      get => this._cmdReport;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdReport_Click);
        Button cmdReport1 = this._cmdReport;
        if (cmdReport1 != null)
          cmdReport1.Click -= eventHandler;
        this._cmdReport = value;
        Button cmdReport2 = this._cmdReport;
        if (cmdReport2 == null)
          return;
        cmdReport2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("EditMenu")]
    internal virtual ContextMenuStrip EditMenu { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripMenuItem DeleteToolStripMenuItem
    {
      get => this._DeleteToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DeleteToolStripMenuItem_Click);
        ToolStripMenuItem toolStripMenuItem1 = this._DeleteToolStripMenuItem;
        if (toolStripMenuItem1 != null)
          toolStripMenuItem1.Click -= eventHandler;
        this._DeleteToolStripMenuItem = value;
        ToolStripMenuItem toolStripMenuItem2 = this._DeleteToolStripMenuItem;
        if (toolStripMenuItem2 == null)
          return;
        toolStripMenuItem2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("ToolStripMenuItem14")]
    internal virtual ToolStripSeparator ToolStripMenuItem14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtTFEE")]
    internal virtual TextBox txtTFEE { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtDFEE")]
    internal virtual TextBox txtDFEE { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label5")]
    internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label6")]
    internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private void Block_Compliance_Load(object sender, EventArgs e)
    {
      this.FillBlocks();
      this.FillAllDwellings();
    }

    private void FillBlockDwellings()
    {
      if (SAP_Module.Proj.Blocks[this.CurrBlock].Dwellings == null)
      {
        this.lstBlockDwellings.DataSource = (object) null;
      }
      else
      {
        DataTable dataTable1 = new DataTable();
        dataTable1.Columns.Add("ID");
        dataTable1.Columns.Add("Name");
        dataTable1.Columns.Add("Reference");
        int num1 = checked (((IEnumerable<SAP_Module.Block_Dwellings>) SAP_Module.Proj.Blocks[this.CurrBlock].Dwellings).Count<SAP_Module.Block_Dwellings>() - 1);
        int index1 = 0;
        while (index1 <= num1)
        {
          DataRow row = dataTable1.NewRow();
          row["ID"] = (object) SAP_Module.Proj.Blocks[this.CurrBlock].Dwellings[index1].ID;
          row["Name"] = (object) SAP_Module.Proj.Blocks[this.CurrBlock].Dwellings[index1].Name;
          row["Reference"] = (object) SAP_Module.Proj.Blocks[this.CurrBlock].Dwellings[index1].Reference;
          dataTable1.Rows.Add(row);
          checked { ++index1; }
        }
        string str = "";
        DataTable dataTable2 = new DataTable();
        dataTable2.Columns.Add("ID");
        dataTable2.Columns.Add("Name");
        dataTable2.Columns.Add("Reference");
        int num2 = checked (SAP_Module.Proj.NoOfDwells - 1);
        int index2 = 0;
        while (index2 <= num2)
        {
          DataRow row = dataTable2.NewRow();
          row["ID"] = (object) SAP_Module.Proj.Dwellings[index2].ID;
          row["Name"] = (object) SAP_Module.Proj.Dwellings[index2].Name;
          row["Reference"] = (object) SAP_Module.Proj.Dwellings[index2].Reference;
          dataTable2.Rows.Add(row);
          checked { ++index2; }
        }
        int num3 = checked (dataTable1.Rows.Count - 1);
        int index3 = 0;
        while (index3 <= num3)
        {
          try
          {
            if (dataTable2.Select(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "Name='", dataTable1.Rows[index3]["Name"]), (object) "'"))).Length == 0)
            {
              if (dataTable2.Select(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "Reference= '", dataTable1.Rows[index3]["Reference"]), (object) "'"))).Length == 0)
              {
                str = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) str, Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "Dwelling ", dataTable1.Rows[index3]["Name"]), (object) " removed from Block as dwelling reference no longer matches!"), (object) "\r\n")));
                dataTable1.Rows[index3].Delete();
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
        if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "", false) > 0U)
        {
          int num4 = (int) Interaction.MsgBox((object) str, Title: ((object) "Dwellings removed from Block!"));
        }
        SAP_Module.Proj.Blocks[this.CurrBlock].Dwellings = new SAP_Module.Block_Dwellings[checked (dataTable1.Rows.Count - 1 + 1)];
        int num5 = checked (dataTable1.Rows.Count - 1);
        int index4 = 0;
        while (index4 <= num5)
        {
          SAP_Module.Proj.Blocks[this.CurrBlock].Dwellings[index4].ID = Conversions.ToInteger(dataTable1.Rows[index4]["ID"]);
          SAP_Module.Proj.Blocks[this.CurrBlock].Dwellings[index4].Name = Conversions.ToString(dataTable1.Rows[index4]["Name"]);
          SAP_Module.Proj.Blocks[this.CurrBlock].Dwellings[index4].Reference = Conversions.ToString(dataTable1.Rows[index4]["Reference"]);
          checked { ++index4; }
        }
        this.lstBlockDwellings.DataSource = (object) dataTable1;
        this.lstBlockDwellings.DisplayMember = "Name";
      }
      this.CalcAverages();
    }

    private void CalcAverages()
    {
      DataTable dataTable = new DataTable();
      dataTable.Columns.Add("Dwelling", typeof (string));
      dataTable.Columns.Add("DER", typeof (float));
      dataTable.Columns.Add("TER", typeof (float));
      try
      {
        string country = SAP_Module.Proj.Dwellings[this.CurrBlock].Address.Country;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(country, "Wales", false) != 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(country, "Scotland", false) != 0)
          {
            dataTable.Columns.Add("DFEE", typeof (float));
            dataTable.Columns.Add("TFEE", typeof (float));
          }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      dataTable.Columns.Add("TFA", typeof (float));
      this.txtAREA.Text = "";
      this.txtDER.Text = "";
      this.txtTER.Text = "";
      this.txtCompliance.Text = "";
      if (SAP_Module.Proj.Blocks[this.CurrBlock].Dwellings != null)
      {
        SAP_Module.Proj.Blocks[this.CurrBlock].AveDER = 0.0f;
        SAP_Module.Proj.Blocks[this.CurrBlock].AveTER = 0.0f;
        SAP_Module.Proj.Blocks[this.CurrBlock].AveDFEE = 0.0f;
        SAP_Module.Proj.Blocks[this.CurrBlock].AveTFEE = 0.0f;
        SAP_Module.Proj.Blocks[this.CurrBlock].TFA = 0.0f;
        int num1 = checked (((IEnumerable<SAP_Module.Block_Dwellings>) SAP_Module.Proj.Blocks[this.CurrBlock].Dwellings).Count<SAP_Module.Block_Dwellings>() - 1);
        int index = 0;
        while (index <= num1)
        {
          SAP_Module.CurrDwelling = SAP_Module.Proj.Blocks[this.CurrBlock].Dwellings[index].ID;
          Functions.CalculateNow();
          Functions.CalculateNowDERTER();
          DataRow row = dataTable.NewRow();
          row["Dwelling"] = (object) SAP_Module.Proj.Blocks[this.CurrBlock].Dwellings[index].Name;
          row["DER"] = (object) Conversion.Val(MyProject.Forms.SAPForm.txtDwellingDER.Text);
          row["TER"] = (object) Conversion.Val(MyProject.Forms.SAPForm.txtDwellingTER.Text);
          try
          {
            string country = SAP_Module.Proj.Dwellings[this.CurrBlock].Address.Country;
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(country, "Wales", false) != 0)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(country, "Scotland", false) != 0)
              {
                row["DFEE"] = (object) Conversion.Val(MyProject.Forms.SAPForm.txtDwellingFEE.Text);
                row["TFEE"] = (object) Conversion.Val(MyProject.Forms.SAPForm.txtTFEE.Text);
              }
            }
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
          row["TFA"] = (object) SAP_Module.CalcualtionDER2012.Calculation.Dimensions.Box4;
          dataTable.Rows.Add(row);
          Conversion.Val(MyProject.Forms.SAPForm.txtTFEE.Text);
          Conversion.Val(MyProject.Forms.SAPForm.txtDwellingFEE.Text);
          // ISSUE: variable of a reference type
          float& local1;
          // ISSUE: explicit reference operation
          double num2 = (double) (^(local1 = ref SAP_Module.Proj.Blocks[this.CurrBlock].AveDER) + (float) (SAP_Module.CalcualtionDER2012.Calculation.Dimensions.Box4 * Conversion.Val(MyProject.Forms.SAPForm.txtDwellingDER.Text)));
          local1 = (float) num2;
          // ISSUE: variable of a reference type
          float& local2;
          // ISSUE: explicit reference operation
          double num3 = (double) (^(local2 = ref SAP_Module.Proj.Blocks[this.CurrBlock].AveTER) + (float) (SAP_Module.CalcualtionDER2012.Calculation.Dimensions.Box4 * Conversion.Val(MyProject.Forms.SAPForm.txtDwellingTER.Text)));
          local2 = (float) num3;
          // ISSUE: variable of a reference type
          float& local3;
          // ISSUE: explicit reference operation
          double num4 = (double) (^(local3 = ref SAP_Module.Proj.Blocks[this.CurrBlock].AveDFEE) + (float) (SAP_Module.CalcualtionDER2012.Calculation.Dimensions.Box4 * Conversion.Val(MyProject.Forms.SAPForm.txtDwellingFEE.Text)));
          local3 = (float) num4;
          // ISSUE: variable of a reference type
          float& local4;
          // ISSUE: explicit reference operation
          double num5 = (double) (^(local4 = ref SAP_Module.Proj.Blocks[this.CurrBlock].AveTFEE) + (float) (SAP_Module.CalcualtionDER2012.Calculation.Dimensions.Box4 * Conversion.Val(MyProject.Forms.SAPForm.txtTFEE.Text)));
          local4 = (float) num5;
          // ISSUE: variable of a reference type
          float& local5;
          // ISSUE: explicit reference operation
          double num6 = (double) (^(local5 = ref SAP_Module.Proj.Blocks[this.CurrBlock].TFA) + (float) SAP_Module.CalcualtionDER2012.Calculation.Dimensions.Box4);
          local5 = (float) num6;
          checked { ++index; }
        }
        SAP_Module.Proj.Blocks[this.CurrBlock].AveDER /= SAP_Module.Proj.Blocks[this.CurrBlock].TFA;
        SAP_Module.Proj.Blocks[this.CurrBlock].AveTER /= SAP_Module.Proj.Blocks[this.CurrBlock].TFA;
        SAP_Module.Proj.Blocks[this.CurrBlock].AveDFEE /= SAP_Module.Proj.Blocks[this.CurrBlock].TFA;
        SAP_Module.Proj.Blocks[this.CurrBlock].AveTFEE /= SAP_Module.Proj.Blocks[this.CurrBlock].TFA;
        this.txtAREA.Text = Microsoft.VisualBasic.Strings.Format((object) SAP_Module.Proj.Blocks[this.CurrBlock].TFA, "0.00");
        this.txtDER.Text = Microsoft.VisualBasic.Strings.Format((object) SAP_Module.Proj.Blocks[this.CurrBlock].AveDER, "0.00");
        this.txtTER.Text = Microsoft.VisualBasic.Strings.Format((object) SAP_Module.Proj.Blocks[this.CurrBlock].AveTER, "0.00");
        try
        {
          string country = SAP_Module.Proj.Dwellings[this.CurrBlock].Address.Country;
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(country, "Wales", false) == 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(country, "Scotland", false) == 0)
          {
            SAP_Module.Proj.Blocks[this.CurrBlock].Compliance = (double) SAP_Module.Proj.Blocks[this.CurrBlock].AveTER <= (double) SAP_Module.Proj.Blocks[this.CurrBlock].AveDER ? "Fail" : "Pass";
          }
          else
          {
            this.txtDFEE.Text = Microsoft.VisualBasic.Strings.Format((object) SAP_Module.Proj.Blocks[this.CurrBlock].AveDFEE, "0.00");
            this.txtTFEE.Text = Microsoft.VisualBasic.Strings.Format((object) SAP_Module.Proj.Blocks[this.CurrBlock].AveTFEE, "0.00");
            SAP_Module.Proj.Blocks[this.CurrBlock].Compliance = !((double) SAP_Module.Proj.Blocks[this.CurrBlock].AveTER > (double) SAP_Module.Proj.Blocks[this.CurrBlock].AveDER & (double) SAP_Module.Proj.Blocks[this.CurrBlock].AveTFEE >= (double) SAP_Module.Proj.Blocks[this.CurrBlock].AveDFEE) ? "Fail" : "Pass";
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        this.txtCompliance.Text = SAP_Module.Proj.Blocks[this.CurrBlock].Compliance;
      }
      this.DGSummary.DataSource = (object) dataTable;
      if (this.CurrBlock < SAP_Module.Proj.NoOfDwells)
      {
        string country = SAP_Module.Proj.Dwellings[this.CurrBlock].Address.Country;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(country, "Wales", false) == 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(country, "Scotland", false) == 0)
        {
          this.DGSummary.Columns[0].Width = 100;
          this.DGSummary.Columns[1].Width = 50;
          this.DGSummary.Columns[2].Width = 50;
          this.DGSummary.Columns[3].Width = 50;
        }
        else
        {
          this.DGSummary.Columns[0].Width = 100;
          this.DGSummary.Columns[1].Width = 50;
          this.DGSummary.Columns[2].Width = 50;
          this.DGSummary.Columns[3].Width = 50;
          this.DGSummary.Columns[4].Width = 50;
          this.DGSummary.Columns[5].Width = 50;
        }
      }
      SAP_Module.CurrDwelling = -1;
    }

    private void FillAllDwellings()
    {
      DataTable dataTable = new DataTable();
      dataTable.Columns.Add("ID");
      dataTable.Columns.Add("Name");
      dataTable.Columns.Add("Reference");
      int num = checked (SAP_Module.Proj.NoOfDwells - 1);
      int House = 0;
      while (House <= num)
      {
        if (Validation.LodgementStatusCheck(House))
        {
          DataRow row = dataTable.NewRow();
          row["ID"] = (object) House;
          row["Name"] = (object) SAP_Module.Proj.Dwellings[House].Name;
          row["Reference"] = (object) SAP_Module.Proj.Dwellings[House].Reference;
          dataTable.Rows.Add(row);
        }
        checked { ++House; }
      }
      this.lstAllDwellings.DataSource = (object) dataTable;
      this.lstAllDwellings.DisplayMember = "Name";
      this.lstAllDwellings.Refresh();
    }

    private void FillBlocks()
    {
      this.TreeSAP.Nodes.Clear();
      this.TreeSAP.Nodes.Add("Project", SAP_Module.Proj.Name, 0, 0);
      int num = checked (SAP_Module.Proj.NoofBlocks - 1);
      int Number = 0;
      while (Number <= num)
      {
        this.TreeSAP.Nodes[0].Nodes.Add(Conversion.Str((object) Number), SAP_Module.Proj.Blocks[Number].Name, 1, 2);
        checked { ++Number; }
      }
      this.TreeSAP.Nodes[0].Expand();
    }

    private void cmdBiolerData_Click(object sender, EventArgs e)
    {
      Block_Name blockName = new Block_Name();
label_1:
      if (blockName.ShowDialog() != DialogResult.OK || (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(blockName.txtBlockName.Text, "", false) <= 0U)
        return;
      int num1 = checked (SAP_Module.Proj.NoofBlocks - 1);
      int index = 0;
      while (index <= num1)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(blockName.txtBlockName.Text, SAP_Module.Proj.Blocks[index].Name, false) == 0)
        {
          int num2 = (int) Interaction.MsgBox((object) "A Block by that name already exists, please try again", MsgBoxStyle.Information, (object) "Block Name");
          goto label_1;
        }
        else
          checked { ++index; }
      }
      // ISSUE: variable of a reference type
      int& local1;
      // ISSUE: explicit reference operation
      int num3 = checked (^(local1 = ref SAP_Module.Proj.NoofBlocks) + 1);
      local1 = num3;
      // ISSUE: variable of a reference type
      SAP_Module.Block[]& local2;
      // ISSUE: explicit reference operation
      SAP_Module.Block[] blockArray = (SAP_Module.Block[]) Utils.CopyArray((Array) ^(local2 = ref SAP_Module.Proj.Blocks), (Array) new SAP_Module.Block[checked (SAP_Module.Proj.NoofBlocks - 1 + 1)]);
      local2 = blockArray;
      SAP_Module.Proj.Blocks[checked (SAP_Module.Proj.NoofBlocks - 1)].Name = blockName.txtBlockName.Text;
      this.FillBlocks();
    }

    private void TreeSAP_AfterSelect(object sender, TreeViewEventArgs e)
    {
      if (e.Node.Level == 1)
      {
        this.cmdAddDwelling.Enabled = true;
        this.cmdRemoveDwelling.Enabled = true;
        this.CurrBlock = e.Node.Index;
        this.FillBlockDwellings();
      }
      else
      {
        this.cmdAddDwelling.Enabled = false;
        this.cmdRemoveDwelling.Enabled = false;
      }
    }

    private void cmdAddDwelling_Click(object sender, EventArgs e)
    {
      int num1 = checked (this.lstAllDwellings.SelectedItems.Count - 1);
      int index1 = 0;
      while (index1 <= num1)
      {
        DataRowView selectedItem = (DataRowView) this.lstAllDwellings.SelectedItems[index1];
        bool flag = false;
        if (SAP_Module.Proj.Blocks[this.CurrBlock].Dwellings != null)
        {
          int num2 = checked (((IEnumerable<SAP_Module.Block_Dwellings>) SAP_Module.Proj.Blocks[this.CurrBlock].Dwellings).Count<SAP_Module.Block_Dwellings>() - 1);
          int index2 = 0;
          while (index2 <= num2)
          {
            if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual((object) SAP_Module.Proj.Blocks[this.CurrBlock].Dwellings[index2].Name, selectedItem["Name"], false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual((object) SAP_Module.Proj.Blocks[this.CurrBlock].Dwellings[index2].Reference, selectedItem["Reference"], false))))
            {
              flag = true;
              break;
            }
            checked { ++index2; }
          }
        }
        if (!flag)
        {
          if (SAP_Module.Proj.Blocks[this.CurrBlock].Dwellings == null)
          {
            // ISSUE: variable of a reference type
            SAP_Module.Block_Dwellings[]& local;
            // ISSUE: explicit reference operation
            SAP_Module.Block_Dwellings[] blockDwellingsArray = (SAP_Module.Block_Dwellings[]) Utils.CopyArray((Array) ^(local = ref SAP_Module.Proj.Blocks[this.CurrBlock].Dwellings), (Array) new SAP_Module.Block_Dwellings[1]);
            local = blockDwellingsArray;
          }
          else
          {
            // ISSUE: variable of a reference type
            SAP_Module.Block_Dwellings[]& local;
            // ISSUE: explicit reference operation
            SAP_Module.Block_Dwellings[] blockDwellingsArray = (SAP_Module.Block_Dwellings[]) Utils.CopyArray((Array) ^(local = ref SAP_Module.Proj.Blocks[this.CurrBlock].Dwellings), (Array) new SAP_Module.Block_Dwellings[checked (((IEnumerable<SAP_Module.Block_Dwellings>) SAP_Module.Proj.Blocks[this.CurrBlock].Dwellings).Count<SAP_Module.Block_Dwellings>() + 1)]);
            local = blockDwellingsArray;
          }
          SAP_Module.Proj.Blocks[this.CurrBlock].Dwellings[checked (((IEnumerable<SAP_Module.Block_Dwellings>) SAP_Module.Proj.Blocks[this.CurrBlock].Dwellings).Count<SAP_Module.Block_Dwellings>() - 1)].ID = Conversions.ToInteger(selectedItem["ID"]);
          SAP_Module.Proj.Blocks[this.CurrBlock].Dwellings[checked (((IEnumerable<SAP_Module.Block_Dwellings>) SAP_Module.Proj.Blocks[this.CurrBlock].Dwellings).Count<SAP_Module.Block_Dwellings>() - 1)].Name = Conversions.ToString(selectedItem["Name"]);
          SAP_Module.Proj.Blocks[this.CurrBlock].Dwellings[checked (((IEnumerable<SAP_Module.Block_Dwellings>) SAP_Module.Proj.Blocks[this.CurrBlock].Dwellings).Count<SAP_Module.Block_Dwellings>() - 1)].Reference = Conversions.ToString(selectedItem["Reference"]);
        }
        checked { ++index1; }
      }
      this.FillBlockDwellings();
    }

    private void cmdRemoveDwelling_Click(object sender, EventArgs e)
    {
      if ((uint) this.lstBlockDwellings.SelectedItems.Count <= 0U)
        return;
      DataTable dataTable = new DataTable();
      int[] source = new int[checked (this.lstBlockDwellings.SelectedItems.Count - 1 + 1)];
      int num1 = checked (this.lstBlockDwellings.SelectedItems.Count - 1);
      int index1 = 0;
      while (index1 <= num1)
      {
        source[index1] = this.lstBlockDwellings.SelectedIndices[index1];
        checked { ++index1; }
      }
      DataTable dataSource = (DataTable) this.lstBlockDwellings.DataSource;
      int index2 = checked (((IEnumerable<int>) source).Count<int>() - 1);
      while (index2 >= 0)
      {
        dataSource.Rows[source[index2]].Delete();
        checked { index2 += -1; }
      }
      SAP_Module.Proj.Blocks[this.CurrBlock].Dwellings = new SAP_Module.Block_Dwellings[checked (dataSource.Rows.Count - 1 + 1)];
      int num2 = checked (dataSource.Rows.Count - 1);
      int index3 = 0;
      while (index3 <= num2)
      {
        SAP_Module.Proj.Blocks[this.CurrBlock].Dwellings[index3].ID = Conversions.ToInteger(dataSource.Rows[index3]["ID"]);
        SAP_Module.Proj.Blocks[this.CurrBlock].Dwellings[index3].Name = Conversions.ToString(dataSource.Rows[index3]["Name"]);
        SAP_Module.Proj.Blocks[this.CurrBlock].Dwellings[index3].Reference = Conversions.ToString(dataSource.Rows[index3]["Reference"]);
        checked { ++index3; }
      }
      this.FillBlockDwellings();
    }

    private void cmdReport_Click(object sender, EventArgs e)
    {
      this.k = 0;
      if (SAP_Module.Proj.Blocks == null)
      {
        int num1 = (int) Interaction.MsgBox((object) "Please select a block ", MsgBoxStyle.Information, (object) "Block Report Error!");
      }
      else
      {
        this.FinishedTable = false;
        string str1 = "Block Compliance WorkSheet: " + SAP_Module.Proj.Blocks[this.CurrBlock].Name;
        PDFFunctions.document = new PdfDocument();
        PDFFunctions.pages[this.k] = PDFFunctions.document.AddPage();
        PDFFunctions.gfx[this.k] = XGraphics.FromPdfPage(PDFFunctions.pages[this.k]);
        XSize pageSize = PDFFunctions.gfx[this.k].PageSize;
        double num2 = ((XSize) ref pageSize).Width / 2.0;
        XSize xsize1 = PDFFunctions.gfx[this.k].MeasureString(str1, PDFFunctions.ArialFont16Bold);
        double num3 = ((XSize) ref xsize1).Width / 2.0;
        int num4 = checked ((int) Math.Round(unchecked (num2 - num3)));
        XGraphics xgraphics1 = PDFFunctions.gfx[this.k];
        string str2 = str1;
        XFont arialFont16Bold = PDFFunctions.ArialFont16Bold;
        XSolidBrush black1 = XBrushes.Black;
        double num5 = (double) num4;
        XUnit xunit1 = PDFFunctions.pages[this.k].Width;
        double point1 = ((XUnit) ref xunit1).Point;
        xunit1 = PDFFunctions.pages[this.k].Height;
        double num6 = ((XUnit) ref xunit1).Point / 2.0;
        XRect xrect1 = new XRect(num5, 30.0, point1, num6);
        XStringFormat topLeft1 = XStringFormat.TopLeft;
        xgraphics1.DrawString(str2, arialFont16Bold, (XBrush) black1, xrect1, topLeft1);
        string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\Stroma SAP 2012\\";
        if (!Directory.Exists(path))
          Directory.CreateDirectory(path);
        if (File.Exists(path + "Logo.jpg"))
        {
          Image image = Image.FromFile(path + "Logo.jpg");
          int num7;
          int num8;
          int num9;
          int num10;
          if ((double) image.Width / (double) image.Height > 5.0 / 3.0)
          {
            num7 = 475;
            num8 = 100;
            num9 = checked ((int) Math.Round((double) this.ImageY));
            num10 = checked ((int) Math.Round(unchecked ((double) checked (image.Height * 100) / (double) image.Width)));
          }
          else
          {
            num9 = checked ((int) Math.Round((double) this.ImageY));
            num10 = 60;
            num7 = checked ((int) Math.Round(unchecked (575.0 - (double) image.Width / (double) image.Height * 60.0)));
            num8 = checked ((int) Math.Round(unchecked ((double) image.Width / (double) image.Height * 60.0)));
          }
          PDFFunctions.gfx[this.k].DrawImage(XImage.op_Implicit(image), num7, num9, num8, num10);
          image.Dispose();
        }
        if (UserSettings.USettings.PrintUserSettings.Print)
          PDFFunctions.PrintUserDetails(PDFFunctions.gfx[this.k]);
        this.RC1 = 70;
        PDFFunctions.xBrush1 = XBrush.op_Implicit((Brush) new SolidBrush(Color.FromArgb(159, 172, 62)));
        PDFFunctions.Points[0].X = 20f;
        PDFFunctions.Points[0].Y = (float) this.RC1;
        ref PointF local1 = ref PDFFunctions.Points[1];
        xunit1 = PDFFunctions.pages[this.k].Width;
        double num11 = ((XUnit) ref xunit1).Point - 20.0;
        local1.X = (float) num11;
        PDFFunctions.Points[1].Y = (float) this.RC1;
        ref PointF local2 = ref PDFFunctions.Points[2];
        xunit1 = PDFFunctions.pages[this.k].Width;
        double num12 = ((XUnit) ref xunit1).Point - 20.0;
        local2.X = (float) num12;
        PDFFunctions.Points[2].Y = (float) checked (this.RC1 + 12);
        PDFFunctions.Points[3].X = 20f;
        PDFFunctions.Points[3].Y = (float) checked (this.RC1 + 12);
        PDFFunctions.gfx[this.k].DrawPolygon(PDFFunctions.polyGreen2, PDFFunctions.xBrush1, PDFFunctions.Points, PDFFunctions.Fill);
        XGraphics xgraphics2 = PDFFunctions.gfx[this.k];
        XFont arialFont10_1 = PDFFunctions.ArialFont10;
        XSolidBrush white1 = XBrushes.White;
        xunit1 = PDFFunctions.pages[this.k].Width;
        double num13 = ((XUnit) ref xunit1).Point / 2.0;
        XSize xsize2 = PDFFunctions.gfx[this.k].MeasureString("User Details", PDFFunctions.ArialFont10);
        double num14 = ((XSize) ref xsize2).Width / 2.0;
        double num15 = num13 - num14;
        double num16 = (double) checked (this.RC1 + 1);
        xunit1 = PDFFunctions.pages[this.k].Width;
        double point2 = ((XUnit) ref xunit1).Point;
        xunit1 = PDFFunctions.pages[this.k].Height;
        double num17 = ((XUnit) ref xunit1).Point / 2.0;
        XRect xrect2 = new XRect(num15, num16, point2, num17);
        XStringFormat topLeft2 = XStringFormat.TopLeft;
        xgraphics2.DrawString("User Details", arialFont10_1, (XBrush) white1, xrect2, topLeft2);
        this.RC1 = checked ((int) Math.Round(unchecked ((double) PDFFunctions.Points[3].Y + 10.0)));
        XGraphics xgraphics3 = PDFFunctions.gfx[this.k];
        XFont arialFont12Bold1 = PDFFunctions.ArialFont12Bold;
        XSolidBrush black2 = XBrushes.Black;
        double rc1_1 = (double) this.RC1;
        xunit1 = PDFFunctions.pages[this.k].Width;
        double point3 = ((XUnit) ref xunit1).Point;
        xunit1 = PDFFunctions.pages[this.k].Height;
        double num18 = ((XUnit) ref xunit1).Point / 2.0;
        XRect xrect3 = new XRect(20.0, rc1_1, point3, num18);
        XStringFormat topLeft3 = XStringFormat.TopLeft;
        xgraphics3.DrawString("Assessor Name:", arialFont12Bold1, (XBrush) black2, xrect3, topLeft3);
        XGraphics xgraphics4 = PDFFunctions.gfx[this.k];
        string str3 = Validation.AssessorFN + " " + Validation.AssessorLN;
        XFont arialFont11_1 = PDFFunctions.ArialFont11;
        XSolidBrush black3 = XBrushes.Black;
        double rc1_2 = (double) this.RC1;
        xunit1 = PDFFunctions.pages[this.k].Width;
        double point4 = ((XUnit) ref xunit1).Point;
        xunit1 = PDFFunctions.pages[this.k].Height;
        double num19 = ((XUnit) ref xunit1).Point / 2.0;
        XRect xrect4 = new XRect(140.0, rc1_2, point4, num19);
        XStringFormat topLeft4 = XStringFormat.TopLeft;
        xgraphics4.DrawString(str3, arialFont11_1, (XBrush) black3, xrect4, topLeft4);
        XGraphics xgraphics5 = PDFFunctions.gfx[this.k];
        XFont arialFont12Bold2 = PDFFunctions.ArialFont12Bold;
        XSolidBrush black4 = XBrushes.Black;
        double rc1_3 = (double) this.RC1;
        xunit1 = PDFFunctions.pages[this.k].Width;
        double point5 = ((XUnit) ref xunit1).Point;
        xunit1 = PDFFunctions.pages[this.k].Height;
        double num20 = ((XUnit) ref xunit1).Point / 2.0;
        XRect xrect5 = new XRect(300.0, rc1_3, point5, num20);
        XStringFormat topLeft5 = XStringFormat.TopLeft;
        xgraphics5.DrawString("Stroma Number:", arialFont12Bold2, (XBrush) black4, xrect5, topLeft5);
        if (Validation.AssessorNO != null)
        {
          XGraphics xgraphics6 = PDFFunctions.gfx[this.k];
          string assessorNo = Validation.AssessorNO;
          XFont arialFont11_2 = PDFFunctions.ArialFont11;
          XSolidBrush black5 = XBrushes.Black;
          double rc1_4 = (double) this.RC1;
          xunit1 = PDFFunctions.pages[this.k].Width;
          double point6 = ((XUnit) ref xunit1).Point;
          xunit1 = PDFFunctions.pages[this.k].Height;
          double num21 = ((XUnit) ref xunit1).Point / 2.0;
          XRect xrect6 = new XRect(450.0, rc1_4, point6, num21);
          XStringFormat topLeft6 = XStringFormat.TopLeft;
          xgraphics6.DrawString(assessorNo, arialFont11_2, (XBrush) black5, xrect6, topLeft6);
        }
        checked { this.RC1 += 16; }
        XGraphics xgraphics7 = PDFFunctions.gfx[this.k];
        XFont arialFont12Bold3 = PDFFunctions.ArialFont12Bold;
        XSolidBrush black6 = XBrushes.Black;
        double rc1_5 = (double) this.RC1;
        xunit1 = PDFFunctions.pages[this.k].Width;
        double point7 = ((XUnit) ref xunit1).Point;
        xunit1 = PDFFunctions.pages[this.k].Height;
        double point8 = ((XUnit) ref xunit1).Point;
        XRect xrect7 = new XRect(20.0, rc1_5, point7, point8);
        XStringFormat topLeft7 = XStringFormat.TopLeft;
        xgraphics7.DrawString("Software Name:", arialFont12Bold3, (XBrush) black6, xrect7, topLeft7);
        XGraphics xgraphics8 = PDFFunctions.gfx[this.k];
        XFont arialFont11_3 = PDFFunctions.ArialFont11;
        XSolidBrush black7 = XBrushes.Black;
        double rc1_6 = (double) this.RC1;
        xunit1 = PDFFunctions.pages[this.k].Width;
        double point9 = ((XUnit) ref xunit1).Point;
        xunit1 = PDFFunctions.pages[this.k].Height;
        double num22 = ((XUnit) ref xunit1).Point / 2.0;
        XRect xrect8 = new XRect(140.0, rc1_6, point9, num22);
        XStringFormat topLeft8 = XStringFormat.TopLeft;
        xgraphics8.DrawString("Stroma FSAP", arialFont11_3, (XBrush) black7, xrect8, topLeft8);
        XGraphics xgraphics9 = PDFFunctions.gfx[this.k];
        XFont arialFont12Bold4 = PDFFunctions.ArialFont12Bold;
        XSolidBrush black8 = XBrushes.Black;
        double rc1_7 = (double) this.RC1;
        xunit1 = PDFFunctions.pages[this.k].Width;
        double point10 = ((XUnit) ref xunit1).Point;
        xunit1 = PDFFunctions.pages[this.k].Height;
        double point11 = ((XUnit) ref xunit1).Point;
        XRect xrect9 = new XRect(300.0, rc1_7, point10, point11);
        XStringFormat topLeft9 = XStringFormat.TopLeft;
        xgraphics9.DrawString("Software Version:", arialFont12Bold4, (XBrush) black8, xrect9, topLeft9);
        XGraphics xgraphics10 = PDFFunctions.gfx[this.k];
        string currVersion = SAP_Module.CurrVersion;
        XFont arialFont11_4 = PDFFunctions.ArialFont11;
        XSolidBrush black9 = XBrushes.Black;
        double rc1_8 = (double) this.RC1;
        xunit1 = PDFFunctions.pages[this.k].Width;
        double point12 = ((XUnit) ref xunit1).Point;
        xunit1 = PDFFunctions.pages[this.k].Height;
        double num23 = ((XUnit) ref xunit1).Point / 2.0;
        XRect xrect10 = new XRect(450.0, rc1_8, point12, num23);
        XStringFormat topLeft10 = XStringFormat.TopLeft;
        xgraphics10.DrawString(currVersion, arialFont11_4, (XBrush) black9, xrect10, topLeft10);
        checked { this.RC1 += 18; }
        PDFFunctions.Points[0].X = 20f;
        PDFFunctions.Points[0].Y = (float) this.RC1;
        ref PointF local3 = ref PDFFunctions.Points[1];
        xunit1 = PDFFunctions.pages[this.k].Width;
        double num24 = ((XUnit) ref xunit1).Point - 20.0;
        local3.X = (float) num24;
        PDFFunctions.Points[1].Y = (float) this.RC1;
        ref PointF local4 = ref PDFFunctions.Points[2];
        xunit1 = PDFFunctions.pages[this.k].Width;
        double num25 = ((XUnit) ref xunit1).Point - 20.0;
        local4.X = (float) num25;
        PDFFunctions.Points[2].Y = (float) checked (this.RC1 + 12);
        PDFFunctions.Points[3].X = 20f;
        PDFFunctions.Points[3].Y = (float) checked (this.RC1 + 12);
        PDFFunctions.gfx[this.k].DrawPolygon(PDFFunctions.polyGreen2, PDFFunctions.xBrush1, PDFFunctions.Points, PDFFunctions.Fill);
        XGraphics xgraphics11 = PDFFunctions.gfx[this.k];
        XFont arialFont10_2 = PDFFunctions.ArialFont10;
        XSolidBrush white2 = XBrushes.White;
        xunit1 = PDFFunctions.pages[this.k].Width;
        double num26 = ((XUnit) ref xunit1).Point / 2.0;
        XSize xsize3 = PDFFunctions.gfx[this.k].MeasureString("Calculation Details", PDFFunctions.ArialFont10);
        double num27 = ((XSize) ref xsize3).Width / 2.0;
        double num28 = num26 - num27;
        double num29 = (double) checked (this.RC1 + 1);
        xunit1 = PDFFunctions.pages[this.k].Width;
        double point13 = ((XUnit) ref xunit1).Point;
        xunit1 = PDFFunctions.pages[this.k].Height;
        double num30 = ((XUnit) ref xunit1).Point / 2.0;
        XRect xrect11 = new XRect(num28, num29, point13, num30);
        XStringFormat topLeft11 = XStringFormat.TopLeft;
        xgraphics11.DrawString("Calculation Details", arialFont10_2, (XBrush) white2, xrect11, topLeft11);
        checked { this.RC1 += 30; }
        this.Headings();
        string country1 = SAP_Module.Proj.Dwellings[this.CurrBlock].Address.Country;
        XSize xsize4;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(country1, "Scotland", false) == 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(country1, "Wales", false) == 0)
        {
          int num31 = checked (this.DGSummary.RowCount - 1);
          int rowIndex = 0;
          while (rowIndex <= num31)
          {
            XGraphics xgraphics12 = PDFFunctions.gfx[this.k];
            string str4 = Conversions.ToString(this.DGSummary[0, rowIndex].Value);
            XFont arialFont10_3 = PDFFunctions.ArialFont10;
            XSolidBrush black10 = XBrushes.Black;
            double num32 = (double) checked (this.RC1 + 1);
            xunit1 = PDFFunctions.pages[this.k].Width;
            double point14 = ((XUnit) ref xunit1).Point;
            xunit1 = PDFFunctions.pages[this.k].Height;
            double num33 = ((XUnit) ref xunit1).Point / 2.0;
            XRect xrect12 = new XRect(22.0, num32, point14, num33);
            XStringFormat topLeft12 = XStringFormat.TopLeft;
            xgraphics12.DrawString(str4, arialFont10_3, (XBrush) black10, xrect12, topLeft12);
            XGraphics xgraphics13 = PDFFunctions.gfx[this.k];
            string str5 = Conversions.ToString(this.DGSummary[1, rowIndex].Value);
            XFont arialFont10_4 = PDFFunctions.ArialFont10;
            XSolidBrush black11 = XBrushes.Black;
            XSize xsize5 = PDFFunctions.gfx[this.k].MeasureString(Conversions.ToString(this.DGSummary[1, rowIndex].Value), PDFFunctions.ArialFont10);
            double num34 = 305.0 - ((XSize) ref xsize5).Width / 2.0;
            double num35 = (double) checked (this.RC1 + 1);
            xunit1 = PDFFunctions.pages[this.k].Width;
            double point15 = ((XUnit) ref xunit1).Point;
            xunit1 = PDFFunctions.pages[this.k].Height;
            double num36 = ((XUnit) ref xunit1).Point / 2.0;
            XRect xrect13 = new XRect(num34, num35, point15, num36);
            XStringFormat topLeft13 = XStringFormat.TopLeft;
            xgraphics13.DrawString(str5, arialFont10_4, (XBrush) black11, xrect13, topLeft13);
            XGraphics xgraphics14 = PDFFunctions.gfx[this.k];
            string str6 = Conversions.ToString(this.DGSummary[2, rowIndex].Value);
            XFont arialFont10_5 = PDFFunctions.ArialFont10;
            XSolidBrush black12 = XBrushes.Black;
            XSize xsize6 = PDFFunctions.gfx[this.k].MeasureString(Conversions.ToString(this.DGSummary[2, rowIndex].Value), PDFFunctions.ArialFont10);
            double num37 = 365.0 - ((XSize) ref xsize6).Width / 2.0;
            double num38 = (double) checked (this.RC1 + 1);
            xunit1 = PDFFunctions.pages[this.k].Width;
            double point16 = ((XUnit) ref xunit1).Point;
            xunit1 = PDFFunctions.pages[this.k].Height;
            double num39 = ((XUnit) ref xunit1).Point / 2.0;
            XRect xrect14 = new XRect(num37, num38, point16, num39);
            XStringFormat topLeft14 = XStringFormat.TopLeft;
            xgraphics14.DrawString(str6, arialFont10_5, (XBrush) black12, xrect14, topLeft14);
            XGraphics xgraphics15 = PDFFunctions.gfx[this.k];
            string str7 = Conversions.ToString(this.DGSummary[3, rowIndex].Value);
            XFont arialFont10_6 = PDFFunctions.ArialFont10;
            XSolidBrush black13 = XBrushes.Black;
            XSize xsize7 = PDFFunctions.gfx[this.k].MeasureString(Conversions.ToString(this.DGSummary[3, rowIndex].Value), PDFFunctions.ArialFont10);
            double num40 = 425.0 - ((XSize) ref xsize7).Width / 2.0;
            double num41 = (double) checked (this.RC1 + 1);
            xunit1 = PDFFunctions.pages[this.k].Width;
            double point17 = ((XUnit) ref xunit1).Point;
            xunit1 = PDFFunctions.pages[this.k].Height;
            double num42 = ((XUnit) ref xunit1).Point / 2.0;
            XRect xrect15 = new XRect(num40, num41, point17, num42);
            XStringFormat topLeft15 = XStringFormat.TopLeft;
            xgraphics15.DrawString(str7, arialFont10_6, (XBrush) black13, xrect15, topLeft15);
            checked { this.RC1 += 18; }
            XGraphics xgraphics16 = PDFFunctions.gfx[this.k];
            XPen black14 = XPens.Black;
            double rc1_9 = (double) this.RC1;
            xunit1 = PDFFunctions.pages[this.k].Width;
            double num43 = ((XUnit) ref xunit1).Point - 20.0;
            double rc1_10 = (double) this.RC1;
            xgraphics16.DrawLine(black14, 20.0, rc1_9, num43, rc1_10);
            PDFFunctions.gfx[this.k].DrawLine(XPens.Black, 20, checked (this.RC1 - 24), 20, this.RC1);
            PDFFunctions.gfx[this.k].DrawLine(XPens.Black, 275, checked (this.RC1 - 24), 275, this.RC1);
            PDFFunctions.gfx[this.k].DrawLine(XPens.Black, 335, checked (this.RC1 - 24), 335, this.RC1);
            PDFFunctions.gfx[this.k].DrawLine(XPens.Black, 395, checked (this.RC1 - 24), 395, this.RC1);
            PDFFunctions.gfx[this.k].DrawLine(XPens.Black, 455, checked (this.RC1 - 24), 455, this.RC1);
            if (rowIndex != checked (this.DGSummary.RowCount - 1))
              checked { this.RC1 += 6; }
            else
              this.FinishedTable = true;
            this.CheckCheckListRC1();
            checked { ++rowIndex; }
          }
        }
        else
        {
          int num44 = checked (this.DGSummary.RowCount - 1);
          int rowIndex = 0;
          while (rowIndex <= num44)
          {
            XGraphics xgraphics17 = PDFFunctions.gfx[this.k];
            string str8 = Conversions.ToString(this.DGSummary[0, rowIndex].Value);
            XFont arialFont10_7 = PDFFunctions.ArialFont10;
            XSolidBrush black15 = XBrushes.Black;
            double num45 = (double) checked (this.RC1 + 1);
            xunit1 = PDFFunctions.pages[this.k].Width;
            double point18 = ((XUnit) ref xunit1).Point;
            xunit1 = PDFFunctions.pages[this.k].Height;
            double num46 = ((XUnit) ref xunit1).Point / 2.0;
            XRect xrect16 = new XRect(22.0, num45, point18, num46);
            XStringFormat topLeft16 = XStringFormat.TopLeft;
            xgraphics17.DrawString(str8, arialFont10_7, (XBrush) black15, xrect16, topLeft16);
            XGraphics xgraphics18 = PDFFunctions.gfx[this.k];
            string str9 = Conversions.ToString(this.DGSummary[1, rowIndex].Value);
            XFont arialFont10_8 = PDFFunctions.ArialFont10;
            XSolidBrush black16 = XBrushes.Black;
            xsize4 = PDFFunctions.gfx[this.k].MeasureString(Conversions.ToString(this.DGSummary[1, rowIndex].Value), PDFFunctions.ArialFont10);
            double num47 = 305.0 - ((XSize) ref xsize4).Width / 2.0;
            double num48 = (double) checked (this.RC1 + 1);
            xunit1 = PDFFunctions.pages[this.k].Width;
            double point19 = ((XUnit) ref xunit1).Point;
            xunit1 = PDFFunctions.pages[this.k].Height;
            double num49 = ((XUnit) ref xunit1).Point / 2.0;
            XRect xrect17 = new XRect(num47, num48, point19, num49);
            XStringFormat topLeft17 = XStringFormat.TopLeft;
            xgraphics18.DrawString(str9, arialFont10_8, (XBrush) black16, xrect17, topLeft17);
            XGraphics xgraphics19 = PDFFunctions.gfx[this.k];
            string str10 = Conversions.ToString(this.DGSummary[2, rowIndex].Value);
            XFont arialFont10_9 = PDFFunctions.ArialFont10;
            XSolidBrush black17 = XBrushes.Black;
            xsize4 = PDFFunctions.gfx[this.k].MeasureString(Conversions.ToString(this.DGSummary[2, rowIndex].Value), PDFFunctions.ArialFont10);
            double num50 = 365.0 - ((XSize) ref xsize4).Width / 2.0;
            double num51 = (double) checked (this.RC1 + 1);
            xunit1 = PDFFunctions.pages[this.k].Width;
            double point20 = ((XUnit) ref xunit1).Point;
            xunit1 = PDFFunctions.pages[this.k].Height;
            double num52 = ((XUnit) ref xunit1).Point / 2.0;
            XRect xrect18 = new XRect(num50, num51, point20, num52);
            XStringFormat topLeft18 = XStringFormat.TopLeft;
            xgraphics19.DrawString(str10, arialFont10_9, (XBrush) black17, xrect18, topLeft18);
            XGraphics xgraphics20 = PDFFunctions.gfx[this.k];
            string str11 = Conversions.ToString(this.DGSummary[3, rowIndex].Value);
            XFont arialFont10_10 = PDFFunctions.ArialFont10;
            XSolidBrush black18 = XBrushes.Black;
            xsize4 = PDFFunctions.gfx[this.k].MeasureString(Conversions.ToString(this.DGSummary[3, rowIndex].Value), PDFFunctions.ArialFont10);
            double num53 = 425.0 - ((XSize) ref xsize4).Width / 2.0;
            double num54 = (double) checked (this.RC1 + 1);
            xunit1 = PDFFunctions.pages[this.k].Width;
            double point21 = ((XUnit) ref xunit1).Point;
            xunit1 = PDFFunctions.pages[this.k].Height;
            double num55 = ((XUnit) ref xunit1).Point / 2.0;
            XRect xrect19 = new XRect(num53, num54, point21, num55);
            XStringFormat topLeft19 = XStringFormat.TopLeft;
            xgraphics20.DrawString(str11, arialFont10_10, (XBrush) black18, xrect19, topLeft19);
            XGraphics xgraphics21 = PDFFunctions.gfx[this.k];
            string str12 = Conversions.ToString(this.DGSummary[4, rowIndex].Value);
            XFont arialFont10_11 = PDFFunctions.ArialFont10;
            XSolidBrush black19 = XBrushes.Black;
            xsize4 = PDFFunctions.gfx[this.k].MeasureString(Conversions.ToString(this.DGSummary[4, rowIndex].Value), PDFFunctions.ArialFont10);
            double num56 = 485.0 - ((XSize) ref xsize4).Width / 2.0;
            double num57 = (double) checked (this.RC1 + 1);
            xunit1 = PDFFunctions.pages[this.k].Width;
            double point22 = ((XUnit) ref xunit1).Point;
            xunit1 = PDFFunctions.pages[this.k].Height;
            double num58 = ((XUnit) ref xunit1).Point / 2.0;
            XRect xrect20 = new XRect(num56, num57, point22, num58);
            XStringFormat topLeft20 = XStringFormat.TopLeft;
            xgraphics21.DrawString(str12, arialFont10_11, (XBrush) black19, xrect20, topLeft20);
            XGraphics xgraphics22 = PDFFunctions.gfx[this.k];
            string str13 = Conversions.ToString(this.DGSummary[5, rowIndex].Value);
            XFont arialFont10_12 = PDFFunctions.ArialFont10;
            XSolidBrush black20 = XBrushes.Black;
            xsize4 = PDFFunctions.gfx[this.k].MeasureString(Conversions.ToString(this.DGSummary[5, rowIndex].Value), PDFFunctions.ArialFont10);
            double num59 = 545.0 - ((XSize) ref xsize4).Width / 2.0;
            double num60 = (double) checked (this.RC1 + 1);
            xunit1 = PDFFunctions.pages[this.k].Width;
            double point23 = ((XUnit) ref xunit1).Point;
            xunit1 = PDFFunctions.pages[this.k].Height;
            double num61 = ((XUnit) ref xunit1).Point / 2.0;
            XRect xrect21 = new XRect(num59, num60, point23, num61);
            XStringFormat topLeft21 = XStringFormat.TopLeft;
            xgraphics22.DrawString(str13, arialFont10_12, (XBrush) black20, xrect21, topLeft21);
            checked { this.RC1 += 18; }
            XGraphics xgraphics23 = PDFFunctions.gfx[this.k];
            XPen black21 = XPens.Black;
            double rc1_11 = (double) this.RC1;
            xunit1 = PDFFunctions.pages[this.k].Width;
            double num62 = ((XUnit) ref xunit1).Point - 20.0;
            double rc1_12 = (double) this.RC1;
            xgraphics23.DrawLine(black21, 20.0, rc1_11, num62, rc1_12);
            PDFFunctions.gfx[this.k].DrawLine(XPens.Black, 20, checked (this.RC1 - 24), 20, this.RC1);
            PDFFunctions.gfx[this.k].DrawLine(XPens.Black, 275, checked (this.RC1 - 24), 275, this.RC1);
            PDFFunctions.gfx[this.k].DrawLine(XPens.Black, 335, checked (this.RC1 - 24), 335, this.RC1);
            PDFFunctions.gfx[this.k].DrawLine(XPens.Black, 395, checked (this.RC1 - 24), 395, this.RC1);
            PDFFunctions.gfx[this.k].DrawLine(XPens.Black, 455, checked (this.RC1 - 24), 455, this.RC1);
            PDFFunctions.gfx[this.k].DrawLine(XPens.Black, 515, checked (this.RC1 - 24), 515, this.RC1);
            PDFFunctions.gfx[this.k].DrawLine(XPens.Black, 575, checked (this.RC1 - 24), 575, this.RC1);
            if (rowIndex != checked (this.DGSummary.RowCount - 1))
              checked { this.RC1 += 6; }
            else
              this.FinishedTable = true;
            this.CheckCheckListRC1();
            checked { ++rowIndex; }
          }
        }
        checked { this.RC1 += 12; }
        PDFFunctions.Points[0].X = 20f;
        PDFFunctions.Points[0].Y = (float) this.RC1;
        ref PointF local5 = ref PDFFunctions.Points[1];
        xunit1 = PDFFunctions.pages[this.k].Width;
        double num63 = ((XUnit) ref xunit1).Point - 20.0;
        local5.X = (float) num63;
        PDFFunctions.Points[1].Y = (float) this.RC1;
        ref PointF local6 = ref PDFFunctions.Points[2];
        xunit1 = PDFFunctions.pages[this.k].Width;
        double num64 = ((XUnit) ref xunit1).Point - 20.0;
        local6.X = (float) num64;
        PDFFunctions.Points[2].Y = (float) checked (this.RC1 + 12);
        PDFFunctions.Points[3].X = 20f;
        PDFFunctions.Points[3].Y = (float) checked (this.RC1 + 12);
        PDFFunctions.gfx[this.k].DrawPolygon(PDFFunctions.polyGreen2, PDFFunctions.xBrush1, PDFFunctions.Points, PDFFunctions.Fill);
        XGraphics xgraphics24 = PDFFunctions.gfx[this.k];
        XFont arialFont10_13 = PDFFunctions.ArialFont10;
        XSolidBrush white3 = XBrushes.White;
        xunit1 = PDFFunctions.pages[this.k].Width;
        double num65 = ((XUnit) ref xunit1).Point / 2.0;
        xsize4 = PDFFunctions.gfx[this.k].MeasureString("Calculation Details", PDFFunctions.ArialFont10);
        double num66 = ((XSize) ref xsize4).Width / 2.0;
        double num67 = num65 - num66;
        double num68 = (double) checked (this.RC1 + 1);
        xunit1 = PDFFunctions.pages[this.k].Width;
        double point24 = ((XUnit) ref xunit1).Point;
        xunit1 = PDFFunctions.pages[this.k].Height;
        double num69 = ((XUnit) ref xunit1).Point / 2.0;
        XRect xrect22 = new XRect(num67, num68, point24, num69);
        XStringFormat topLeft22 = XStringFormat.TopLeft;
        xgraphics24.DrawString("Calculation Summary", arialFont10_13, (XBrush) white3, xrect22, topLeft22);
        checked { this.RC1 += 30; }
        this.CheckCheckListRC1();
        int rc1_13 = this.RC1;
        PDFFunctions.gfx[this.k].DrawLine(XPens.Black, 139, this.RC1, 437, this.RC1);
        checked { this.RC1 += 6; }
        XGraphics xgraphics25 = PDFFunctions.gfx[this.k];
        XFont arialFont10_14 = PDFFunctions.ArialFont10;
        XSolidBrush black22 = XBrushes.Black;
        double num70 = (double) checked (this.RC1 + 1);
        xunit1 = PDFFunctions.pages[this.k].Width;
        double point25 = ((XUnit) ref xunit1).Point;
        xunit1 = PDFFunctions.pages[this.k].Height;
        double num71 = ((XUnit) ref xunit1).Point / 2.0;
        XRect xrect23 = new XRect(141.0, num70, point25, num71);
        XStringFormat topLeft23 = XStringFormat.TopLeft;
        xgraphics25.DrawString("Total Floor Area", arialFont10_14, (XBrush) black22, xrect23, topLeft23);
        XGraphics xgraphics26 = PDFFunctions.gfx[this.k];
        string text1 = this.txtAREA.Text;
        XFont arialFont10_15 = PDFFunctions.ArialFont10;
        XSolidBrush black23 = XBrushes.Black;
        xsize4 = PDFFunctions.gfx[this.k].MeasureString(this.txtAREA.Text, PDFFunctions.ArialFont10);
        double num72 = 367.0 - ((XSize) ref xsize4).Width / 2.0;
        double num73 = (double) checked (this.RC1 + 1);
        xunit1 = PDFFunctions.pages[this.k].Width;
        double point26 = ((XUnit) ref xunit1).Point;
        xunit1 = PDFFunctions.pages[this.k].Height;
        double num74 = ((XUnit) ref xunit1).Point / 2.0;
        XRect xrect24 = new XRect(num72, num73, point26, num74);
        XStringFormat topLeft24 = XStringFormat.TopLeft;
        xgraphics26.DrawString(text1, arialFont10_15, (XBrush) black23, xrect24, topLeft24);
        checked { this.RC1 += 18; }
        PDFFunctions.gfx[this.k].DrawLine(XPens.Black, 139, this.RC1, 437, this.RC1);
        checked { this.RC1 += 6; }
        this.CheckCheckListRC1();
        XGraphics xgraphics27 = PDFFunctions.gfx[this.k];
        XFont arialFont10_16 = PDFFunctions.ArialFont10;
        XSolidBrush black24 = XBrushes.Black;
        double num75 = (double) checked (this.RC1 + 1);
        xunit1 = PDFFunctions.pages[this.k].Width;
        double point27 = ((XUnit) ref xunit1).Point;
        xunit1 = PDFFunctions.pages[this.k].Height;
        double num76 = ((XUnit) ref xunit1).Point / 2.0;
        XRect xrect25 = new XRect(141.0, num75, point27, num76);
        XStringFormat topLeft25 = XStringFormat.TopLeft;
        xgraphics27.DrawString("Average TER", arialFont10_16, (XBrush) black24, xrect25, topLeft25);
        XGraphics xgraphics28 = PDFFunctions.gfx[this.k];
        string text2 = this.txtTER.Text;
        XFont arialFont10_17 = PDFFunctions.ArialFont10;
        XSolidBrush black25 = XBrushes.Black;
        xsize4 = PDFFunctions.gfx[this.k].MeasureString(this.txtTER.Text, PDFFunctions.ArialFont10);
        double num77 = 367.0 - ((XSize) ref xsize4).Width / 2.0;
        double num78 = (double) checked (this.RC1 + 1);
        xunit1 = PDFFunctions.pages[this.k].Width;
        double point28 = ((XUnit) ref xunit1).Point;
        xunit1 = PDFFunctions.pages[this.k].Height;
        double num79 = ((XUnit) ref xunit1).Point / 2.0;
        XRect xrect26 = new XRect(num77, num78, point28, num79);
        XStringFormat topLeft26 = XStringFormat.TopLeft;
        xgraphics28.DrawString(text2, arialFont10_17, (XBrush) black25, xrect26, topLeft26);
        checked { this.RC1 += 18; }
        PDFFunctions.gfx[this.k].DrawLine(XPens.Black, 139, this.RC1, 437, this.RC1);
        checked { this.RC1 += 6; }
        this.CheckCheckListRC1();
        XGraphics xgraphics29 = PDFFunctions.gfx[this.k];
        XFont arialFont10_18 = PDFFunctions.ArialFont10;
        XSolidBrush black26 = XBrushes.Black;
        double num80 = (double) checked (this.RC1 + 1);
        xunit1 = PDFFunctions.pages[this.k].Width;
        double point29 = ((XUnit) ref xunit1).Point;
        xunit1 = PDFFunctions.pages[this.k].Height;
        double num81 = ((XUnit) ref xunit1).Point / 2.0;
        XRect xrect27 = new XRect(141.0, num80, point29, num81);
        XStringFormat topLeft27 = XStringFormat.TopLeft;
        xgraphics29.DrawString("Average DER", arialFont10_18, (XBrush) black26, xrect27, topLeft27);
        XGraphics xgraphics30 = PDFFunctions.gfx[this.k];
        string text3 = this.txtDER.Text;
        XFont arialFont10_19 = PDFFunctions.ArialFont10;
        XSolidBrush black27 = XBrushes.Black;
        xsize4 = PDFFunctions.gfx[this.k].MeasureString(this.txtDER.Text, PDFFunctions.ArialFont10);
        double num82 = 367.0 - ((XSize) ref xsize4).Width / 2.0;
        double num83 = (double) checked (this.RC1 + 1);
        xunit1 = PDFFunctions.pages[this.k].Width;
        double point30 = ((XUnit) ref xunit1).Point;
        xunit1 = PDFFunctions.pages[this.k].Height;
        double num84 = ((XUnit) ref xunit1).Point / 2.0;
        XRect xrect28 = new XRect(num82, num83, point30, num84);
        XStringFormat topLeft28 = XStringFormat.TopLeft;
        xgraphics30.DrawString(text3, arialFont10_19, (XBrush) black27, xrect28, topLeft28);
        checked { this.RC1 += 18; }
        PDFFunctions.gfx[this.k].DrawLine(XPens.Black, 139, this.RC1, 437, this.RC1);
        checked { this.RC1 += 6; }
        string country2 = SAP_Module.Proj.Dwellings[this.CurrBlock].Address.Country;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(country2, "Scotland", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(country2, "Wales", false) != 0)
        {
          XGraphics xgraphics31 = PDFFunctions.gfx[this.k];
          XFont arialFont10_20 = PDFFunctions.ArialFont10;
          XSolidBrush black28 = XBrushes.Black;
          double num85 = (double) checked (this.RC1 + 1);
          xunit1 = PDFFunctions.pages[this.k].Width;
          double point31 = ((XUnit) ref xunit1).Point;
          xunit1 = PDFFunctions.pages[this.k].Height;
          double num86 = ((XUnit) ref xunit1).Point / 2.0;
          XRect xrect29 = new XRect(141.0, num85, point31, num86);
          XStringFormat topLeft29 = XStringFormat.TopLeft;
          xgraphics31.DrawString("Average DFEE", arialFont10_20, (XBrush) black28, xrect29, topLeft29);
          XGraphics xgraphics32 = PDFFunctions.gfx[this.k];
          string text4 = this.txtDFEE.Text;
          XFont arialFont10_21 = PDFFunctions.ArialFont10;
          XSolidBrush black29 = XBrushes.Black;
          xsize4 = PDFFunctions.gfx[this.k].MeasureString(this.txtDFEE.Text, PDFFunctions.ArialFont10);
          double num87 = 367.0 - ((XSize) ref xsize4).Width / 2.0;
          double num88 = (double) checked (this.RC1 + 1);
          xunit1 = PDFFunctions.pages[this.k].Width;
          double point32 = ((XUnit) ref xunit1).Point;
          xunit1 = PDFFunctions.pages[this.k].Height;
          double num89 = ((XUnit) ref xunit1).Point / 2.0;
          XRect xrect30 = new XRect(num87, num88, point32, num89);
          XStringFormat topLeft30 = XStringFormat.TopLeft;
          xgraphics32.DrawString(text4, arialFont10_21, (XBrush) black29, xrect30, topLeft30);
          checked { this.RC1 += 18; }
          PDFFunctions.gfx[this.k].DrawLine(XPens.Black, 139, this.RC1, 437, this.RC1);
          checked { this.RC1 += 6; }
          this.CheckCheckListRC1();
          XGraphics xgraphics33 = PDFFunctions.gfx[this.k];
          XFont arialFont10_22 = PDFFunctions.ArialFont10;
          XSolidBrush black30 = XBrushes.Black;
          double num90 = (double) checked (this.RC1 + 1);
          xunit1 = PDFFunctions.pages[this.k].Width;
          double point33 = ((XUnit) ref xunit1).Point;
          xunit1 = PDFFunctions.pages[this.k].Height;
          double num91 = ((XUnit) ref xunit1).Point / 2.0;
          XRect xrect31 = new XRect(141.0, num90, point33, num91);
          XStringFormat topLeft31 = XStringFormat.TopLeft;
          xgraphics33.DrawString("Average TFEE", arialFont10_22, (XBrush) black30, xrect31, topLeft31);
          XGraphics xgraphics34 = PDFFunctions.gfx[this.k];
          string text5 = this.txtTFEE.Text;
          XFont arialFont10_23 = PDFFunctions.ArialFont10;
          XSolidBrush black31 = XBrushes.Black;
          xsize4 = PDFFunctions.gfx[this.k].MeasureString(this.txtTFEE.Text, PDFFunctions.ArialFont10);
          double num92 = 367.0 - ((XSize) ref xsize4).Width / 2.0;
          double num93 = (double) checked (this.RC1 + 1);
          xunit1 = PDFFunctions.pages[this.k].Width;
          double point34 = ((XUnit) ref xunit1).Point;
          xunit1 = PDFFunctions.pages[this.k].Height;
          double num94 = ((XUnit) ref xunit1).Point / 2.0;
          XRect xrect32 = new XRect(num92, num93, point34, num94);
          XStringFormat topLeft32 = XStringFormat.TopLeft;
          xgraphics34.DrawString(text5, arialFont10_23, (XBrush) black31, xrect32, topLeft32);
          checked { this.RC1 += 18; }
          PDFFunctions.gfx[this.k].DrawLine(XPens.Black, 139, this.RC1, 437, this.RC1);
          checked { this.RC1 += 6; }
          this.CheckCheckListRC1();
        }
        XGraphics xgraphics35 = PDFFunctions.gfx[this.k];
        XFont arialFont10_24 = PDFFunctions.ArialFont10;
        XSolidBrush black32 = XBrushes.Black;
        double num95 = (double) checked (this.RC1 + 1);
        xunit1 = PDFFunctions.pages[this.k].Width;
        double point35 = ((XUnit) ref xunit1).Point;
        xunit1 = PDFFunctions.pages[this.k].Height;
        double num96 = ((XUnit) ref xunit1).Point / 2.0;
        XRect xrect33 = new XRect(141.0, num95, point35, num96);
        XStringFormat topLeft33 = XStringFormat.TopLeft;
        xgraphics35.DrawString("Compliance", arialFont10_24, (XBrush) black32, xrect33, topLeft33);
        XGraphics xgraphics36 = PDFFunctions.gfx[this.k];
        string text6 = this.txtCompliance.Text;
        XFont arialFont10_25 = PDFFunctions.ArialFont10;
        XSolidBrush black33 = XBrushes.Black;
        xsize4 = PDFFunctions.gfx[this.k].MeasureString(this.txtCompliance.Text, PDFFunctions.ArialFont10);
        double num97 = 367.0 - ((XSize) ref xsize4).Width / 2.0;
        double num98 = (double) checked (this.RC1 + 1);
        xunit1 = PDFFunctions.pages[this.k].Width;
        double point36 = ((XUnit) ref xunit1).Point;
        xunit1 = PDFFunctions.pages[this.k].Height;
        double num99 = ((XUnit) ref xunit1).Point / 2.0;
        XRect xrect34 = new XRect(num97, num98, point36, num99);
        XStringFormat topLeft34 = XStringFormat.TopLeft;
        xgraphics36.DrawString(text6, arialFont10_25, (XBrush) black33, xrect34, topLeft34);
        checked { this.RC1 += 20; }
        this.CheckCheckListRC1();
        try
        {
          if (Conversion.Val(this.txtDER.Text) > 0.0)
          {
            XGraphics xgraphics37 = PDFFunctions.gfx[this.k];
            XFont arialFont10_26 = PDFFunctions.ArialFont10;
            XSolidBrush black34 = XBrushes.Black;
            double num100 = (double) checked (this.RC1 + 1);
            xunit1 = PDFFunctions.pages[this.k].Width;
            double point37 = ((XUnit) ref xunit1).Point;
            xunit1 = PDFFunctions.pages[this.k].Height;
            double num101 = ((XUnit) ref xunit1).Point / 2.0;
            XRect xrect35 = new XRect(141.0, num100, point37, num101);
            XStringFormat topLeft35 = XStringFormat.TopLeft;
            xgraphics37.DrawString("% Improvement DER|TER ", arialFont10_26, (XBrush) black34, xrect35, topLeft35);
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtCompliance.Text, "Fail", false) == 0)
            {
              XGraphics xgraphics38 = PDFFunctions.gfx[this.k];
              XFont arialFont10_27 = PDFFunctions.ArialFont10;
              XSolidBrush black35 = XBrushes.Black;
              xsize4 = PDFFunctions.gfx[this.k].MeasureString(this.txtTER.Text, PDFFunctions.ArialFont10);
              double num102 = 367.0 - ((XSize) ref xsize4).Width / 2.0;
              double num103 = (double) checked (this.RC1 + 1);
              xunit1 = PDFFunctions.pages[this.k].Width;
              double point38 = ((XUnit) ref xunit1).Point;
              xunit1 = PDFFunctions.pages[this.k].Height;
              double num104 = ((XUnit) ref xunit1).Point / 2.0;
              XRect xrect36 = new XRect(num102, num103, point38, num104);
              XStringFormat topLeft36 = XStringFormat.TopLeft;
              xgraphics38.DrawString("N/A", arialFont10_27, (XBrush) black35, xrect36, topLeft36);
            }
            else
            {
              XGraphics xgraphics39 = PDFFunctions.gfx[this.k];
              string str14 = Conversions.ToString(Math.Round(Math.Abs(100.0 - Conversions.ToDouble(this.txtDER.Text) * 100.0 / Conversions.ToDouble(this.txtTER.Text)), 2));
              XFont arialFont10_28 = PDFFunctions.ArialFont10;
              XSolidBrush black36 = XBrushes.Black;
              xsize4 = PDFFunctions.gfx[this.k].MeasureString(this.txtTER.Text, PDFFunctions.ArialFont10);
              double num105 = 367.0 - ((XSize) ref xsize4).Width / 2.0;
              double num106 = (double) checked (this.RC1 + 1);
              xunit1 = PDFFunctions.pages[this.k].Width;
              double point39 = ((XUnit) ref xunit1).Point;
              xunit1 = PDFFunctions.pages[this.k].Height;
              double num107 = ((XUnit) ref xunit1).Point / 2.0;
              XRect xrect37 = new XRect(num105, num106, point39, num107);
              XStringFormat topLeft37 = XStringFormat.TopLeft;
              xgraphics39.DrawString(str14, arialFont10_28, (XBrush) black36, xrect37, topLeft37);
            }
            checked { this.RC1 += 18; }
            this.CheckCheckListRC1();
          }
          string country3 = SAP_Module.Proj.Dwellings[this.CurrBlock].Address.Country;
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(country3, "Scotland", false) != 0)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(country3, "Wales", false) != 0)
            {
              if (Conversion.Val(this.txtDFEE.Text) > 0.0)
              {
                XGraphics xgraphics40 = PDFFunctions.gfx[this.k];
                XFont arialFont10_29 = PDFFunctions.ArialFont10;
                XSolidBrush black37 = XBrushes.Black;
                double num108 = (double) checked (this.RC1 + 1);
                xunit1 = PDFFunctions.pages[this.k].Width;
                double point40 = ((XUnit) ref xunit1).Point;
                xunit1 = PDFFunctions.pages[this.k].Height;
                double num109 = ((XUnit) ref xunit1).Point / 2.0;
                XRect xrect38 = new XRect(141.0, num108, point40, num109);
                XStringFormat topLeft38 = XStringFormat.TopLeft;
                xgraphics40.DrawString("% Improvement DFEE|TFEE ", arialFont10_29, (XBrush) black37, xrect38, topLeft38);
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtCompliance.Text, "Fail", false) == 0)
                {
                  XGraphics xgraphics41 = PDFFunctions.gfx[this.k];
                  XFont arialFont10_30 = PDFFunctions.ArialFont10;
                  XSolidBrush black38 = XBrushes.Black;
                  xsize4 = PDFFunctions.gfx[this.k].MeasureString(this.txtTER.Text, PDFFunctions.ArialFont10);
                  double num110 = 367.0 - ((XSize) ref xsize4).Width / 2.0;
                  double num111 = (double) checked (this.RC1 + 1);
                  xunit1 = PDFFunctions.pages[this.k].Width;
                  double point41 = ((XUnit) ref xunit1).Point;
                  xunit1 = PDFFunctions.pages[this.k].Height;
                  double num112 = ((XUnit) ref xunit1).Point / 2.0;
                  XRect xrect39 = new XRect(num110, num111, point41, num112);
                  XStringFormat topLeft39 = XStringFormat.TopLeft;
                  xgraphics41.DrawString("N/A", arialFont10_30, (XBrush) black38, xrect39, topLeft39);
                }
                else
                {
                  XGraphics xgraphics42 = PDFFunctions.gfx[this.k];
                  string str15 = Conversions.ToString(Math.Round(Math.Abs(100.0 - Conversions.ToDouble(this.txtDFEE.Text) * 100.0 / Conversions.ToDouble(this.txtTFEE.Text)), 2));
                  XFont arialFont10_31 = PDFFunctions.ArialFont10;
                  XSolidBrush black39 = XBrushes.Black;
                  xsize4 = PDFFunctions.gfx[this.k].MeasureString(this.txtTFEE.Text, PDFFunctions.ArialFont10);
                  double num113 = 367.0 - ((XSize) ref xsize4).Width / 2.0;
                  double num114 = (double) checked (this.RC1 + 1);
                  xunit1 = PDFFunctions.pages[this.k].Width;
                  double point42 = ((XUnit) ref xunit1).Point;
                  xunit1 = PDFFunctions.pages[this.k].Height;
                  double num115 = ((XUnit) ref xunit1).Point / 2.0;
                  XRect xrect40 = new XRect(num113, num114, point42, num115);
                  XStringFormat topLeft40 = XStringFormat.TopLeft;
                  xgraphics42.DrawString(str15, arialFont10_31, (XBrush) black39, xrect40, topLeft40);
                }
                checked { this.RC1 += 18; }
                this.CheckCheckListRC1();
              }
            }
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        PDFFunctions.gfx[this.k].DrawLine(XPens.Black, 139, this.RC1, 437, this.RC1);
        PDFFunctions.gfx[this.k].DrawLine(XPens.Black, 139, rc1_13, 139, this.RC1);
        PDFFunctions.gfx[this.k].DrawLine(XPens.Black, 297, rc1_13, 297, this.RC1);
        PDFFunctions.gfx[this.k].DrawLine(XPens.Black, 437, rc1_13, 437, this.RC1);
        int num116 = checked (this.k + 1);
        int num117 = checked (num116 - 1);
        int index = 0;
        while (index <= num117)
        {
          XGraphics xgraphics43 = PDFFunctions.gfx[index];
          string str16 = "Page " + Conversions.ToString(checked (index + 1)) + " of " + Conversions.ToString(num116);
          XFont arialFont8_1 = PDFFunctions.ArialFont8;
          XSolidBrush black40 = XBrushes.Black;
          XUnit xunit2 = PDFFunctions.pages[index].Width;
          double point43 = ((XUnit) ref xunit2).Point;
          xunit2 = PDFFunctions.pages[index].Height;
          double point44 = ((XUnit) ref xunit2).Point;
          XRect xrect41 = new XRect(520.0, 820.0, point43, point44);
          XStringFormat topLeft41 = XStringFormat.TopLeft;
          xgraphics43.DrawString(str16, arialFont8_1, (XBrush) black40, xrect41, topLeft41);
          if (!SAP_Module.Proj.OverRide)
          {
            XGraphics xgraphics44 = PDFFunctions.gfx[index];
            string str17 = "Stroma FSAP 2012 " + SAP_Module.CurrVersion + " (SAP 9.92) - http://www.stroma.com";
            XFont arialFont8_2 = PDFFunctions.ArialFont8;
            XSolidBrush black41 = XBrushes.Black;
            xunit2 = PDFFunctions.pages[index].Width;
            double point45 = ((XUnit) ref xunit2).Point;
            xunit2 = PDFFunctions.pages[index].Height;
            double point46 = ((XUnit) ref xunit2).Point;
            XRect xrect42 = new XRect(20.0, 820.0, point45, point46);
            XStringFormat topLeft42 = XStringFormat.TopLeft;
            xgraphics44.DrawString(str17, arialFont8_2, (XBrush) black41, xrect42, topLeft42);
          }
          else
          {
            XGraphics xgraphics45 = PDFFunctions.gfx[index];
            string str18 = "Stroma FSAP 2012 " + SAP_Module.Proj.CalcVersion + " (SAP 9.92) - http://www.stroma.com";
            XFont arialFont8_3 = PDFFunctions.ArialFont8;
            XSolidBrush black42 = XBrushes.Black;
            xunit2 = PDFFunctions.pages[index].Width;
            double point47 = ((XUnit) ref xunit2).Point;
            xunit2 = PDFFunctions.pages[index].Height;
            double point48 = ((XUnit) ref xunit2).Point;
            XRect xrect43 = new XRect(20.0, 820.0, point47, point48);
            XStringFormat topLeft43 = XStringFormat.TopLeft;
            xgraphics45.DrawString(str18, arialFont8_3, (XBrush) black42, xrect43, topLeft43);
          }
          checked { ++index; }
        }
        SAP_Module.PDFFileName = "";
        object folderPath = (object) Environment.GetFolderPath(Environment.SpecialFolder.Personal);
        DirectoryInfo directoryInfo1 = new DirectoryInfo(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(folderPath, (object) "\\Stroma SAP 2012")));
        DirectoryInfo directoryInfo2 = new DirectoryInfo(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(folderPath, (object) "\\Stroma SAP 2012\\"), (object) SAP_Module.Proj.Name)));
        if (!directoryInfo2.Exists)
          directoryInfo2.Create();
        SAP_Module.PDFFileName = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(folderPath, (object) "\\Stroma SAP 2012\\"), (object) SAP_Module.Proj.Name), (object) "\\"), (object) "-Block Compliance - "), (object) SAP_Module.Proj.Blocks[this.CurrBlock].Name), (object) ".pdf"));
        PDFFunctions.document.Save(SAP_Module.PDFFileName);
        MyProject.Forms.EPC_Viewer.EPCViewer.Navigate(SAP_Module.PDFFileName);
        int num118 = (int) MyProject.Forms.EPC_Viewer.ShowDialog();
      }
    }

    private void Headings()
    {
      XGraphics xgraphics1 = PDFFunctions.gfx[this.k];
      XPen black1 = XPens.Black;
      double rc1_1 = (double) this.RC1;
      XUnit width1 = PDFFunctions.pages[this.k].Width;
      double num1 = ((XUnit) ref width1).Point - 20.0;
      double rc1_2 = (double) this.RC1;
      xgraphics1.DrawLine(black1, 20.0, rc1_1, num1, rc1_2);
      checked { this.RC1 += 6; }
      string country = SAP_Module.Proj.Dwellings[this.CurrBlock].Address.Country;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(country, "Scotland", false) == 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(country, "Wales", false) == 0)
      {
        XGraphics xgraphics2 = PDFFunctions.gfx[this.k];
        XFont arialFont10Bold1 = PDFFunctions.ArialFont10Bold;
        XSolidBrush black2 = XBrushes.Black;
        double num2 = (double) checked (this.RC1 + 1);
        XUnit width2 = PDFFunctions.pages[this.k].Width;
        double point1 = ((XUnit) ref width2).Point;
        XUnit height1 = PDFFunctions.pages[this.k].Height;
        double num3 = ((XUnit) ref height1).Point / 2.0;
        XRect xrect1 = new XRect(22.0, num2, point1, num3);
        XStringFormat topLeft1 = XStringFormat.TopLeft;
        xgraphics2.DrawString("Dwelling", arialFont10Bold1, (XBrush) black2, xrect1, topLeft1);
        XGraphics xgraphics3 = PDFFunctions.gfx[this.k];
        XFont arialFont10Bold2 = PDFFunctions.ArialFont10Bold;
        XSolidBrush black3 = XBrushes.Black;
        XSize xsize1 = PDFFunctions.gfx[this.k].MeasureString("DER", PDFFunctions.ArialFont10Bold);
        double num4 = 305.0 - ((XSize) ref xsize1).Width / 2.0;
        double num5 = (double) checked (this.RC1 + 1);
        XUnit width3 = PDFFunctions.pages[this.k].Width;
        double point2 = ((XUnit) ref width3).Point;
        XUnit height2 = PDFFunctions.pages[this.k].Height;
        double num6 = ((XUnit) ref height2).Point / 2.0;
        XRect xrect2 = new XRect(num4, num5, point2, num6);
        XStringFormat topLeft2 = XStringFormat.TopLeft;
        xgraphics3.DrawString("DER", arialFont10Bold2, (XBrush) black3, xrect2, topLeft2);
        XGraphics xgraphics4 = PDFFunctions.gfx[this.k];
        XFont arialFont10Bold3 = PDFFunctions.ArialFont10Bold;
        XSolidBrush black4 = XBrushes.Black;
        XSize xsize2 = PDFFunctions.gfx[this.k].MeasureString("TER", PDFFunctions.ArialFont10Bold);
        double num7 = 365.0 - ((XSize) ref xsize2).Width / 2.0;
        double num8 = (double) checked (this.RC1 + 1);
        XUnit width4 = PDFFunctions.pages[this.k].Width;
        double point3 = ((XUnit) ref width4).Point;
        XUnit height3 = PDFFunctions.pages[this.k].Height;
        double num9 = ((XUnit) ref height3).Point / 2.0;
        XRect xrect3 = new XRect(num7, num8, point3, num9);
        XStringFormat topLeft3 = XStringFormat.TopLeft;
        xgraphics4.DrawString("TER", arialFont10Bold3, (XBrush) black4, xrect3, topLeft3);
        XGraphics xgraphics5 = PDFFunctions.gfx[this.k];
        XFont arialFont10Bold4 = PDFFunctions.ArialFont10Bold;
        XSolidBrush black5 = XBrushes.Black;
        XSize xsize3 = PDFFunctions.gfx[this.k].MeasureString("DFEE", PDFFunctions.ArialFont10Bold);
        double num10 = 425.0 - ((XSize) ref xsize3).Width / 2.0;
        double num11 = (double) checked (this.RC1 + 1);
        XUnit width5 = PDFFunctions.pages[this.k].Width;
        double point4 = ((XUnit) ref width5).Point;
        XUnit height4 = PDFFunctions.pages[this.k].Height;
        double num12 = ((XUnit) ref height4).Point / 2.0;
        XRect xrect4 = new XRect(num10, num11, point4, num12);
        XStringFormat topLeft4 = XStringFormat.TopLeft;
        xgraphics5.DrawString("TFA", arialFont10Bold4, (XBrush) black5, xrect4, topLeft4);
        checked { this.RC1 += 18; }
        XGraphics xgraphics6 = PDFFunctions.gfx[this.k];
        XPen black6 = XPens.Black;
        double rc1_3 = (double) this.RC1;
        XUnit width6 = PDFFunctions.pages[this.k].Width;
        double num13 = ((XUnit) ref width6).Point - 20.0;
        double rc1_4 = (double) this.RC1;
        xgraphics6.DrawLine(black6, 20.0, rc1_3, num13, rc1_4);
        XGraphics xgraphics7 = PDFFunctions.gfx[this.k];
        XPen black7 = XPens.Black;
        double num14 = (double) checked (this.RC1 + 1);
        XUnit width7 = PDFFunctions.pages[this.k].Width;
        double num15 = ((XUnit) ref width7).Point - 20.0;
        double num16 = (double) checked (this.RC1 + 1);
        xgraphics7.DrawLine(black7, 20.0, num14, num15, num16);
        PDFFunctions.gfx[this.k].DrawLine(XPens.Black, 20, checked (this.RC1 - 24), 20, this.RC1);
        PDFFunctions.gfx[this.k].DrawLine(XPens.Black, 275, checked (this.RC1 - 24), 275, this.RC1);
        PDFFunctions.gfx[this.k].DrawLine(XPens.Black, 335, checked (this.RC1 - 24), 335, this.RC1);
        PDFFunctions.gfx[this.k].DrawLine(XPens.Black, 395, checked (this.RC1 - 24), 395, this.RC1);
        PDFFunctions.gfx[this.k].DrawLine(XPens.Black, 455, checked (this.RC1 - 24), 455, this.RC1);
      }
      else
      {
        XGraphics xgraphics8 = PDFFunctions.gfx[this.k];
        XFont arialFont10Bold5 = PDFFunctions.ArialFont10Bold;
        XSolidBrush black8 = XBrushes.Black;
        double num17 = (double) checked (this.RC1 + 1);
        XUnit width8 = PDFFunctions.pages[this.k].Width;
        double point5 = ((XUnit) ref width8).Point;
        XUnit height5 = PDFFunctions.pages[this.k].Height;
        double num18 = ((XUnit) ref height5).Point / 2.0;
        XRect xrect5 = new XRect(22.0, num17, point5, num18);
        XStringFormat topLeft5 = XStringFormat.TopLeft;
        xgraphics8.DrawString("Dwelling", arialFont10Bold5, (XBrush) black8, xrect5, topLeft5);
        XGraphics xgraphics9 = PDFFunctions.gfx[this.k];
        XFont arialFont10Bold6 = PDFFunctions.ArialFont10Bold;
        XSolidBrush black9 = XBrushes.Black;
        XSize xsize4 = PDFFunctions.gfx[this.k].MeasureString("DER", PDFFunctions.ArialFont10Bold);
        double num19 = 305.0 - ((XSize) ref xsize4).Width / 2.0;
        double num20 = (double) checked (this.RC1 + 1);
        XUnit width9 = PDFFunctions.pages[this.k].Width;
        double point6 = ((XUnit) ref width9).Point;
        XUnit height6 = PDFFunctions.pages[this.k].Height;
        double num21 = ((XUnit) ref height6).Point / 2.0;
        XRect xrect6 = new XRect(num19, num20, point6, num21);
        XStringFormat topLeft6 = XStringFormat.TopLeft;
        xgraphics9.DrawString("DER", arialFont10Bold6, (XBrush) black9, xrect6, topLeft6);
        XGraphics xgraphics10 = PDFFunctions.gfx[this.k];
        XFont arialFont10Bold7 = PDFFunctions.ArialFont10Bold;
        XSolidBrush black10 = XBrushes.Black;
        XSize xsize5 = PDFFunctions.gfx[this.k].MeasureString("TER", PDFFunctions.ArialFont10Bold);
        double num22 = 365.0 - ((XSize) ref xsize5).Width / 2.0;
        double num23 = (double) checked (this.RC1 + 1);
        XUnit width10 = PDFFunctions.pages[this.k].Width;
        double point7 = ((XUnit) ref width10).Point;
        XUnit height7 = PDFFunctions.pages[this.k].Height;
        double num24 = ((XUnit) ref height7).Point / 2.0;
        XRect xrect7 = new XRect(num22, num23, point7, num24);
        XStringFormat topLeft7 = XStringFormat.TopLeft;
        xgraphics10.DrawString("TER", arialFont10Bold7, (XBrush) black10, xrect7, topLeft7);
        XGraphics xgraphics11 = PDFFunctions.gfx[this.k];
        XFont arialFont10Bold8 = PDFFunctions.ArialFont10Bold;
        XSolidBrush black11 = XBrushes.Black;
        XSize xsize6 = PDFFunctions.gfx[this.k].MeasureString("DFEE", PDFFunctions.ArialFont10Bold);
        double num25 = 425.0 - ((XSize) ref xsize6).Width / 2.0;
        double num26 = (double) checked (this.RC1 + 1);
        XUnit width11 = PDFFunctions.pages[this.k].Width;
        double point8 = ((XUnit) ref width11).Point;
        XUnit height8 = PDFFunctions.pages[this.k].Height;
        double num27 = ((XUnit) ref height8).Point / 2.0;
        XRect xrect8 = new XRect(num25, num26, point8, num27);
        XStringFormat topLeft8 = XStringFormat.TopLeft;
        xgraphics11.DrawString("DFEE", arialFont10Bold8, (XBrush) black11, xrect8, topLeft8);
        XGraphics xgraphics12 = PDFFunctions.gfx[this.k];
        XFont arialFont10Bold9 = PDFFunctions.ArialFont10Bold;
        XSolidBrush black12 = XBrushes.Black;
        XSize xsize7 = PDFFunctions.gfx[this.k].MeasureString("TFEE", PDFFunctions.ArialFont10Bold);
        double num28 = 485.0 - ((XSize) ref xsize7).Width / 2.0;
        double num29 = (double) checked (this.RC1 + 1);
        XUnit width12 = PDFFunctions.pages[this.k].Width;
        double point9 = ((XUnit) ref width12).Point;
        XUnit height9 = PDFFunctions.pages[this.k].Height;
        double num30 = ((XUnit) ref height9).Point / 2.0;
        XRect xrect9 = new XRect(num28, num29, point9, num30);
        XStringFormat topLeft9 = XStringFormat.TopLeft;
        xgraphics12.DrawString("TFEE", arialFont10Bold9, (XBrush) black12, xrect9, topLeft9);
        XGraphics xgraphics13 = PDFFunctions.gfx[this.k];
        XFont arialFont10Bold10 = PDFFunctions.ArialFont10Bold;
        XSolidBrush black13 = XBrushes.Black;
        XSize xsize8 = PDFFunctions.gfx[this.k].MeasureString("TFA", PDFFunctions.ArialFont10Bold);
        double num31 = 545.0 - ((XSize) ref xsize8).Width / 2.0;
        double num32 = (double) checked (this.RC1 + 1);
        XUnit xunit = PDFFunctions.pages[this.k].Width;
        double point10 = ((XUnit) ref xunit).Point;
        xunit = PDFFunctions.pages[this.k].Height;
        double num33 = ((XUnit) ref xunit).Point / 2.0;
        XRect xrect10 = new XRect(num31, num32, point10, num33);
        XStringFormat topLeft10 = XStringFormat.TopLeft;
        xgraphics13.DrawString("TFA", arialFont10Bold10, (XBrush) black13, xrect10, topLeft10);
        checked { this.RC1 += 18; }
        XGraphics xgraphics14 = PDFFunctions.gfx[this.k];
        XPen black14 = XPens.Black;
        double rc1_5 = (double) this.RC1;
        xunit = PDFFunctions.pages[this.k].Width;
        double num34 = ((XUnit) ref xunit).Point - 20.0;
        double rc1_6 = (double) this.RC1;
        xgraphics14.DrawLine(black14, 20.0, rc1_5, num34, rc1_6);
        XGraphics xgraphics15 = PDFFunctions.gfx[this.k];
        XPen black15 = XPens.Black;
        double num35 = (double) checked (this.RC1 + 1);
        xunit = PDFFunctions.pages[this.k].Width;
        double num36 = ((XUnit) ref xunit).Point - 20.0;
        double num37 = (double) checked (this.RC1 + 1);
        xgraphics15.DrawLine(black15, 20.0, num35, num36, num37);
        PDFFunctions.gfx[this.k].DrawLine(XPens.Black, 20, checked (this.RC1 - 24), 20, this.RC1);
        PDFFunctions.gfx[this.k].DrawLine(XPens.Black, 275, checked (this.RC1 - 24), 275, this.RC1);
        PDFFunctions.gfx[this.k].DrawLine(XPens.Black, 335, checked (this.RC1 - 24), 335, this.RC1);
        PDFFunctions.gfx[this.k].DrawLine(XPens.Black, 395, checked (this.RC1 - 24), 395, this.RC1);
        PDFFunctions.gfx[this.k].DrawLine(XPens.Black, 455, checked (this.RC1 - 24), 455, this.RC1);
        PDFFunctions.gfx[this.k].DrawLine(XPens.Black, 515, checked (this.RC1 - 24), 515, this.RC1);
        PDFFunctions.gfx[this.k].DrawLine(XPens.Black, 575, checked (this.RC1 - 24), 575, this.RC1);
      }
      checked { this.RC1 += 6; }
    }

    private void CheckCheckListRC1()
    {
      if (this.FinishedTable)
      {
        if (this.RC1 < 700)
          return;
        this.CreateCheckListNewPage();
      }
      else if (this.RC1 >= 800)
        this.CreateCheckListNewPage();
    }

    private void CreateCheckListNewPage()
    {
      checked { ++this.k; }
      PDFFunctions.pages[this.k] = PDFFunctions.document.AddPage();
      PDFFunctions.gfx[this.k] = XGraphics.FromPdfPage(PDFFunctions.pages[this.k]);
      XSize xsize = PDFFunctions.gfx[this.k].PageSize;
      double num1 = ((XSize) ref xsize).Width / 2.0;
      xsize = PDFFunctions.gfx[this.k].MeasureString("Block Compliance WorkSheet: " + SAP_Module.Proj.Blocks[this.CurrBlock].Name + "Cont...", PDFFunctions.ArialFont16Bold);
      double num2 = ((XSize) ref xsize).Width / 2.0;
      int num3 = checked ((int) Math.Round(unchecked (num1 - num2)));
      XGraphics xgraphics = PDFFunctions.gfx[this.k];
      string str = "Block Compliance WorkSheet: " + SAP_Module.Proj.Blocks[this.CurrBlock].Name + "Cont...";
      XFont arialFont16Bold = PDFFunctions.ArialFont16Bold;
      XSolidBrush black = XBrushes.Black;
      XUnit xunit = PDFFunctions.pages[this.k].Width;
      double point = ((XUnit) ref xunit).Point;
      xunit = PDFFunctions.pages[this.k].Height;
      double num4 = ((XUnit) ref xunit).Point / 2.0;
      XRect xrect = new XRect(120.0, 30.0, point, num4);
      XStringFormat topLeft = XStringFormat.TopLeft;
      xgraphics.DrawString(str, arialFont16Bold, (XBrush) black, xrect, topLeft);
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
          num7 = checked ((int) Math.Round((double) this.ImageY));
          num8 = checked ((int) Math.Round(unchecked ((double) checked (image.Height * 100) / (double) image.Width)));
        }
        else
        {
          num7 = checked ((int) Math.Round((double) this.ImageY));
          num8 = 60;
          num5 = checked ((int) Math.Round(unchecked (575.0 - (double) image.Width / (double) image.Height * 60.0)));
          num6 = checked ((int) Math.Round(unchecked ((double) image.Width / (double) image.Height * 60.0)));
        }
        PDFFunctions.gfx[this.k].DrawImage(XImage.op_Implicit(image), num5, num7, num6, num8);
        image.Dispose();
      }
      if (UserSettings.USettings.PrintUserSettings.Print)
        PDFFunctions.PrintUserDetails(PDFFunctions.gfx[this.k]);
      this.RC1 = 70;
      if (this.FinishedTable)
        return;
      this.Headings();
    }

    private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
    {
      try
      {
        if (this.CurrBlock <= -1 || Interaction.MsgBox((object) ("Delete " + SAP_Module.Proj.Blocks[this.CurrBlock].Name + "?"), MsgBoxStyle.YesNo | MsgBoxStyle.Question, (object) "Delete Block?") != MsgBoxResult.Yes)
          return;
        SAP_Module.Block[] source = new SAP_Module.Block[checked (((IEnumerable<SAP_Module.Block>) SAP_Module.Proj.Blocks).Count<SAP_Module.Block>() - 2 + 1)];
        int index1 = 0;
        string text = this.TreeSAP.SelectedNode.Text;
        int num = checked (SAP_Module.Proj.NoofBlocks - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, SAP_Module.Proj.Blocks[index2].Name, false) == 0)
          {
            this.TreeSAP.SelectedNode.Remove();
          }
          else
          {
            source[index1] = SAP_Module.Proj.Blocks[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        SAP_Module.Proj.Blocks = source;
        SAP_Module.Proj.NoofBlocks = ((IEnumerable<SAP_Module.Block>) source).Count<SAP_Module.Block>();
        this.TreeSAP.CollapseAll();
        this.TreeSAP.Nodes[0].Expand();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }
  }
}
