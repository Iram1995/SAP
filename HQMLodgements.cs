
// Type: SAP2012.HQMLodgements




using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using SAP2012.My;
using SAP2012.SAPRef;
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
  public class HQMLodgements : Form
  {
    private IContainer components;

    public HQMLodgements() => this.InitializeComponent();

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
      DataGridViewCellStyle gridViewCellStyle = new DataGridViewCellStyle();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (HQMLodgements));
      this.TableLayoutPanel1 = new TableLayoutPanel();
      this.dataGLodgements = new DataGridView();
      this.ID = new DataGridViewTextBoxColumn();
      this.Address = new DataGridViewTextBoxColumn();
      this.Status = new DataGridViewImageColumn();
      this.Include = new DataGridViewCheckBoxColumn();
      this.EditMenu = new ContextMenuStrip(this.components);
      this.cmdShow = new ToolStripMenuItem();
      this.ToolStripMenuItem14 = new ToolStripSeparator();
      this.CloseToolStripMenuItem = new ToolStripMenuItem();
      this.Panel1 = new Panel();
      this.GroupBox4 = new GroupBox();
      this.txtLocation = new TextBox();
      this.cmdLocation = new Button();
      this.Label2 = new Label();
      this.Label1 = new Label();
      this.PictureBox1 = new PictureBox();
      this.Panel2 = new Panel();
      this.LKAll = new LinkLabel();
      this.LKNone = new LinkLabel();
      this.cmdClose = new Button();
      this.CmdLodge = new Button();
      this.StatusList = new ImageList(this.components);
      this.FD1 = new FolderBrowserDialog();
      this.TableLayoutPanel1.SuspendLayout();
      ((ISupportInitialize) this.dataGLodgements).BeginInit();
      this.EditMenu.SuspendLayout();
      this.Panel1.SuspendLayout();
      this.GroupBox4.SuspendLayout();
      ((ISupportInitialize) this.PictureBox1).BeginInit();
      this.Panel2.SuspendLayout();
      this.SuspendLayout();
      this.TableLayoutPanel1.ColumnCount = 1;
      this.TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
      this.TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 15f));
      this.TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 15f));
      this.TableLayoutPanel1.Controls.Add((Control) this.dataGLodgements, 0, 1);
      this.TableLayoutPanel1.Controls.Add((Control) this.Panel1, 0, 0);
      this.TableLayoutPanel1.Controls.Add((Control) this.Panel2, 0, 2);
      this.TableLayoutPanel1.Dock = DockStyle.Fill;
      this.TableLayoutPanel1.Location = new Point(0, 0);
      this.TableLayoutPanel1.Margin = new Padding(2, 2, 2, 2);
      this.TableLayoutPanel1.Name = "TableLayoutPanel1";
      this.TableLayoutPanel1.RowCount = 3;
      this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15.24106f));
      this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 78.38258f));
      this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.376361f));
      this.TableLayoutPanel1.Size = new Size(652, 522);
      this.TableLayoutPanel1.TabIndex = 0;
      this.dataGLodgements.AllowUserToAddRows = false;
      this.dataGLodgements.AllowUserToDeleteRows = false;
      gridViewCellStyle.BackColor = Color.Ivory;
      this.dataGLodgements.AlternatingRowsDefaultCellStyle = gridViewCellStyle;
      this.dataGLodgements.BackgroundColor = Color.White;
      this.dataGLodgements.BorderStyle = BorderStyle.None;
      this.dataGLodgements.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGLodgements.Columns.AddRange((DataGridViewColumn) this.ID, (DataGridViewColumn) this.Address, (DataGridViewColumn) this.Status, (DataGridViewColumn) this.Include);
      this.dataGLodgements.ContextMenuStrip = this.EditMenu;
      this.dataGLodgements.Cursor = Cursors.Hand;
      this.dataGLodgements.Dock = DockStyle.Fill;
      this.dataGLodgements.GridColor = Color.RosyBrown;
      this.dataGLodgements.Location = new Point(2, 81);
      this.dataGLodgements.Margin = new Padding(2, 2, 2, 2);
      this.dataGLodgements.MultiSelect = false;
      this.dataGLodgements.Name = "dataGLodgements";
      this.dataGLodgements.RowHeadersWidth = 14;
      this.dataGLodgements.RowTemplate.Height = 30;
      this.dataGLodgements.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dataGLodgements.Size = new Size(648, 405);
      this.dataGLodgements.TabIndex = 1;
      this.ID.HeaderText = "ID";
      this.ID.Name = "ID";
      this.ID.ReadOnly = true;
      this.ID.Visible = false;
      this.ID.Width = 5;
      this.Address.HeaderText = "Address";
      this.Address.Name = "Address";
      this.Address.Width = 500;
      this.Status.HeaderText = "Status";
      this.Status.Name = "Status";
      this.Status.Width = 80;
      this.Include.HeaderText = "Include";
      this.Include.Name = "Include";
      this.Include.Width = 70;
      this.EditMenu.ImageScalingSize = new Size(20, 20);
      this.EditMenu.Items.AddRange(new ToolStripItem[3]
      {
        (ToolStripItem) this.cmdShow,
        (ToolStripItem) this.ToolStripMenuItem14,
        (ToolStripItem) this.CloseToolStripMenuItem
      });
      this.EditMenu.Name = "EditMenu";
      this.EditMenu.Size = new Size(146, 62);
      this.cmdShow.Image = (Image) componentResourceManager.GetObject("cmdShow.Image");
      this.cmdShow.Name = "cmdShow";
      this.cmdShow.Size = new Size(145, 26);
      this.cmdShow.Text = "&Show Details";
      this.ToolStripMenuItem14.Name = "ToolStripMenuItem14";
      this.ToolStripMenuItem14.Size = new Size(142, 6);
      this.CloseToolStripMenuItem.Image = (Image) SAP2012.My.Resources.Resources.close111;
      this.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem";
      this.CloseToolStripMenuItem.Size = new Size(145, 26);
      this.CloseToolStripMenuItem.Text = "&Close";
      this.Panel1.Controls.Add((Control) this.GroupBox4);
      this.Panel1.Controls.Add((Control) this.Label1);
      this.Panel1.Controls.Add((Control) this.PictureBox1);
      this.Panel1.Dock = DockStyle.Fill;
      this.Panel1.Location = new Point(2, 2);
      this.Panel1.Margin = new Padding(2, 2, 2, 2);
      this.Panel1.Name = "Panel1";
      this.Panel1.Size = new Size(648, 75);
      this.Panel1.TabIndex = 4;
      this.GroupBox4.Controls.Add((Control) this.txtLocation);
      this.GroupBox4.Controls.Add((Control) this.cmdLocation);
      this.GroupBox4.Controls.Add((Control) this.Label2);
      this.GroupBox4.Location = new Point(421, 9);
      this.GroupBox4.Margin = new Padding(2, 2, 2, 2);
      this.GroupBox4.Name = "GroupBox4";
      this.GroupBox4.Padding = new Padding(2, 2, 2, 2);
      this.GroupBox4.Size = new Size(218, 64);
      this.GroupBox4.TabIndex = 30;
      this.GroupBox4.TabStop = false;
      this.GroupBox4.Text = "File Location";
      this.txtLocation.Location = new Point(4, 30);
      this.txtLocation.Margin = new Padding(2, 2, 2, 2);
      this.txtLocation.Name = "txtLocation";
      this.txtLocation.ReadOnly = true;
      this.txtLocation.Size = new Size(182, 20);
      this.txtLocation.TabIndex = 26;
      this.cmdLocation.BackColor = Color.LightSlateGray;
      this.cmdLocation.Cursor = Cursors.Hand;
      this.cmdLocation.FlatStyle = FlatStyle.Popup;
      this.cmdLocation.ForeColor = Color.White;
      this.cmdLocation.Location = new Point(190, 28);
      this.cmdLocation.Margin = new Padding(2, 2, 2, 2);
      this.cmdLocation.Name = "cmdLocation";
      this.cmdLocation.Size = new Size(22, 19);
      this.cmdLocation.TabIndex = 28;
      this.cmdLocation.Text = "...";
      this.cmdLocation.UseVisualStyleBackColor = false;
      this.Label2.AutoSize = true;
      this.Label2.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label2.Location = new Point(4, 15);
      this.Label2.Margin = new Padding(2, 0, 2, 0);
      this.Label2.Name = "Label2";
      this.Label2.Size = new Size(203, 13);
      this.Label2.TabIndex = 27;
      this.Label2.Text = "Select Location for Generated Files";
      this.Label1.AutoSize = true;
      this.Label1.Font = new Font("Microsoft Sans Serif", 14f, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, (byte) 0);
      this.Label1.ForeColor = Color.DodgerBlue;
      this.Label1.Location = new Point(190, 34);
      this.Label1.Margin = new Padding(2, 0, 2, 0);
      this.Label1.Name = "Label1";
      this.Label1.Size = new Size(206, 24);
      this.Label1.TabIndex = 4;
      this.Label1.Text = "HQM XML Download";
      this.Label1.TextAlign = ContentAlignment.MiddleCenter;
      this.PictureBox1.Image = (Image) SAP2012.My.Resources.Resources.LOGO_accreditation;
      this.PictureBox1.Location = new Point(2, 2);
      this.PictureBox1.Margin = new Padding(2, 2, 2, 2);
      this.PictureBox1.Name = "PictureBox1";
      this.PictureBox1.Size = new Size(85, 67);
      this.PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
      this.PictureBox1.TabIndex = 3;
      this.PictureBox1.TabStop = false;
      this.Panel2.Controls.Add((Control) this.LKAll);
      this.Panel2.Controls.Add((Control) this.LKNone);
      this.Panel2.Controls.Add((Control) this.cmdClose);
      this.Panel2.Controls.Add((Control) this.CmdLodge);
      this.Panel2.Cursor = Cursors.Hand;
      this.Panel2.Dock = DockStyle.Fill;
      this.Panel2.Location = new Point(2, 490);
      this.Panel2.Margin = new Padding(2, 2, 2, 2);
      this.Panel2.Name = "Panel2";
      this.Panel2.Size = new Size(648, 30);
      this.Panel2.TabIndex = 5;
      this.LKAll.AutoSize = true;
      this.LKAll.Location = new Point(508, 5);
      this.LKAll.Margin = new Padding(2, 0, 2, 0);
      this.LKAll.Name = "LKAll";
      this.LKAll.Size = new Size(51, 13);
      this.LKAll.TabIndex = 24;
      this.LKAll.TabStop = true;
      this.LKAll.Text = "Select All";
      this.LKNone.AutoSize = true;
      this.LKNone.Location = new Point(86, 5);
      this.LKNone.Margin = new Padding(2, 0, 2, 0);
      this.LKNone.Name = "LKNone";
      this.LKNone.Size = new Size(66, 13);
      this.LKNone.TabIndex = 23;
      this.LKNone.TabStop = true;
      this.LKNone.Text = "Select None";
      this.cmdClose.BackColor = Color.LightSlateGray;
      this.cmdClose.Cursor = Cursors.Hand;
      this.cmdClose.DialogResult = DialogResult.Cancel;
      this.cmdClose.FlatStyle = FlatStyle.Popup;
      this.cmdClose.ForeColor = Color.White;
      this.cmdClose.Location = new Point(4, 2);
      this.cmdClose.Margin = new Padding(2, 2, 2, 2);
      this.cmdClose.Name = "cmdClose";
      this.cmdClose.Size = new Size(76, 23);
      this.cmdClose.TabIndex = 22;
      this.cmdClose.Text = "Cancel";
      this.cmdClose.UseVisualStyleBackColor = false;
      this.CmdLodge.BackColor = Color.LightSlateGray;
      this.CmdLodge.Cursor = Cursors.Hand;
      this.CmdLodge.DialogResult = DialogResult.OK;
      this.CmdLodge.FlatStyle = FlatStyle.Popup;
      this.CmdLodge.ForeColor = Color.White;
      this.CmdLodge.Location = new Point(563, 0);
      this.CmdLodge.Margin = new Padding(2, 2, 2, 2);
      this.CmdLodge.Name = "CmdLodge";
      this.CmdLodge.Size = new Size(76, 23);
      this.CmdLodge.TabIndex = 21;
      this.CmdLodge.Text = "Generate XML";
      this.CmdLodge.UseVisualStyleBackColor = false;
      this.StatusList.ImageStream = (ImageListStreamer) componentResourceManager.GetObject("StatusList.ImageStream");
      this.StatusList.TransparentColor = Color.Transparent;
      this.StatusList.Images.SetKeyName(0, "xml-32.png");
      this.StatusList.Images.SetKeyName(1, "cross-30.png");
      this.StatusList.Images.SetKeyName(2, "tick-32.png");
      this.StatusList.Images.SetKeyName(3, "wait.png");
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.White;
      this.ClientSize = new Size(652, 522);
      this.Controls.Add((Control) this.TableLayoutPanel1);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Margin = new Padding(2, 2, 2, 2);
      this.Name = nameof (HQMLodgements);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "HQM Batch XMLs";
      this.TopMost = true;
      this.TableLayoutPanel1.ResumeLayout(false);
      ((ISupportInitialize) this.dataGLodgements).EndInit();
      this.EditMenu.ResumeLayout(false);
      this.Panel1.ResumeLayout(false);
      this.Panel1.PerformLayout();
      this.GroupBox4.ResumeLayout(false);
      this.GroupBox4.PerformLayout();
      ((ISupportInitialize) this.PictureBox1).EndInit();
      this.Panel2.ResumeLayout(false);
      this.Panel2.PerformLayout();
      this.ResumeLayout(false);
    }

    [field: AccessedThroughProperty("TableLayoutPanel1")]
    internal virtual TableLayoutPanel TableLayoutPanel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("dataGLodgements")]
    internal virtual DataGridView dataGLodgements { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("StatusList")]
    internal virtual ImageList StatusList { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Panel1")]
    internal virtual Panel Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("PictureBox1")]
    internal virtual PictureBox PictureBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Panel2")]
    internal virtual Panel Panel2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label1")]
    internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual LinkLabel LKAll
    {
      get => this._LKAll;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.LKAll_LinkClicked);
        LinkLabel lkAll1 = this._LKAll;
        if (lkAll1 != null)
          lkAll1.LinkClicked -= clickedEventHandler;
        this._LKAll = value;
        LinkLabel lkAll2 = this._LKAll;
        if (lkAll2 == null)
          return;
        lkAll2.LinkClicked += clickedEventHandler;
      }
    }

    internal virtual LinkLabel LKNone
    {
      get => this._LKNone;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.LKNone_LinkClicked);
        LinkLabel lkNone1 = this._LKNone;
        if (lkNone1 != null)
          lkNone1.LinkClicked -= clickedEventHandler;
        this._LKNone = value;
        LinkLabel lkNone2 = this._LKNone;
        if (lkNone2 == null)
          return;
        lkNone2.LinkClicked += clickedEventHandler;
      }
    }

    internal virtual Button cmdClose
    {
      get => this._cmdClose;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdClose_Click);
        Button cmdClose1 = this._cmdClose;
        if (cmdClose1 != null)
          cmdClose1.Click -= eventHandler;
        this._cmdClose = value;
        Button cmdClose2 = this._cmdClose;
        if (cmdClose2 == null)
          return;
        cmdClose2.Click += eventHandler;
      }
    }

    internal virtual Button CmdLodge
    {
      get => this._CmdLodge;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CmdLodge_Click);
        Button cmdLodge1 = this._CmdLodge;
        if (cmdLodge1 != null)
          cmdLodge1.Click -= eventHandler;
        this._CmdLodge = value;
        Button cmdLodge2 = this._CmdLodge;
        if (cmdLodge2 == null)
          return;
        cmdLodge2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("ID")]
    internal virtual DataGridViewTextBoxColumn ID { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Address")]
    internal virtual DataGridViewTextBoxColumn Address { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Status")]
    internal virtual DataGridViewImageColumn Status { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Include")]
    internal virtual DataGridViewCheckBoxColumn Include { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox4")]
    internal virtual GroupBox GroupBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtLocation")]
    internal virtual TextBox txtLocation { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button cmdLocation
    {
      get => this._cmdLocation;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdLocation_Click);
        Button cmdLocation1 = this._cmdLocation;
        if (cmdLocation1 != null)
          cmdLocation1.Click -= eventHandler;
        this._cmdLocation = value;
        Button cmdLocation2 = this._cmdLocation;
        if (cmdLocation2 == null)
          return;
        cmdLocation2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Label2")]
    internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("FD1")]
    internal virtual FolderBrowserDialog FD1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("EditMenu")]
    internal virtual ContextMenuStrip EditMenu { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripMenuItem cmdShow
    {
      get => this._cmdShow;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdShow_Click);
        ToolStripMenuItem cmdShow1 = this._cmdShow;
        if (cmdShow1 != null)
          cmdShow1.Click -= eventHandler;
        this._cmdShow = value;
        ToolStripMenuItem cmdShow2 = this._cmdShow;
        if (cmdShow2 == null)
          return;
        cmdShow2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("ToolStripMenuItem14")]
    internal virtual ToolStripSeparator ToolStripMenuItem14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripMenuItem CloseToolStripMenuItem
    {
      get => this._CloseToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CloseToolStripMenuItem_Click);
        ToolStripMenuItem toolStripMenuItem1 = this._CloseToolStripMenuItem;
        if (toolStripMenuItem1 != null)
          toolStripMenuItem1.Click -= eventHandler;
        this._CloseToolStripMenuItem = value;
        ToolStripMenuItem toolStripMenuItem2 = this._CloseToolStripMenuItem;
        if (toolStripMenuItem2 == null)
          return;
        toolStripMenuItem2.Click += eventHandler;
      }
    }

    private void LKAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      int num = checked (this.dataGLodgements.RowCount - 1);
      int rowIndex = 0;
      while (rowIndex <= num)
      {
        this.dataGLodgements[3, rowIndex].Value = (object) true;
        checked { ++rowIndex; }
      }
    }

    private void LKNone_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      int num = checked (this.dataGLodgements.RowCount - 1);
      int rowIndex = 0;
      while (rowIndex <= num)
      {
        this.dataGLodgements[3, rowIndex].Value = (object) false;
        checked { ++rowIndex; }
      }
    }

    private void cmdClose_Click(object sender, EventArgs e) => this.Close();

    public void ReadHQM()
    {
      this.dataGLodgements.Rows.Clear();
      try
      {
        int num1 = checked (SAP_Module.Proj.NoOfDwells - 1);
        int House = 0;
        while (House <= num1)
        {
          if (Validation.LodgementStatusCheck(House))
          {
            this.dataGLodgements.Rows.Add();
            int num2;
            this.dataGLodgements[0, num2].Value = (object) House;
            this.dataGLodgements[1, num2].Value = (object) SAP_Module.Proj.Dwellings[House].Name;
            if ((uint) Operators.CompareString(SAP_Module.Proj.Dwellings[House].Address.Line1, "", false) > 0U)
            {
              DataGridViewCell dataGlodgement;
              object obj = Operators.AddObject((dataGlodgement = this.dataGLodgements[1, num2]).Value, (object) (", " + SAP_Module.Proj.Dwellings[House].Address.Line1));
              dataGlodgement.Value = obj;
            }
            if ((uint) Operators.CompareString(SAP_Module.Proj.Dwellings[House].Address.Line2, "", false) > 0U)
            {
              DataGridViewCell dataGlodgement;
              object obj = Operators.AddObject((dataGlodgement = this.dataGLodgements[1, num2]).Value, (object) (", " + SAP_Module.Proj.Dwellings[House].Address.Line2));
              dataGlodgement.Value = obj;
            }
            if ((uint) Operators.CompareString(SAP_Module.Proj.Dwellings[House].Address.Line3, "", false) > 0U)
            {
              DataGridViewCell dataGlodgement;
              object obj = Operators.AddObject((dataGlodgement = this.dataGLodgements[1, num2]).Value, (object) (", " + SAP_Module.Proj.Dwellings[House].Address.Line3));
              dataGlodgement.Value = obj;
            }
            if ((uint) Operators.CompareString(SAP_Module.Proj.Dwellings[House].Address.City, "", false) > 0U)
            {
              DataGridViewCell dataGlodgement;
              object obj = Operators.AddObject((dataGlodgement = this.dataGLodgements[1, num2]).Value, (object) (", " + SAP_Module.Proj.Dwellings[House].Address.City));
              dataGlodgement.Value = obj;
            }
            if ((uint) Operators.CompareString(SAP_Module.Proj.Dwellings[House].Address.Country, "", false) > 0U)
            {
              DataGridViewCell dataGlodgement;
              object obj = Operators.AddObject((dataGlodgement = this.dataGLodgements[1, num2]).Value, (object) (", " + SAP_Module.Proj.Dwellings[House].Address.Country));
              dataGlodgement.Value = obj;
            }
            if ((uint) Operators.CompareString(SAP_Module.Proj.Dwellings[House].Address.PostCost, "", false) > 0U)
            {
              DataGridViewCell dataGlodgement;
              object obj = Operators.AddObject((dataGlodgement = this.dataGLodgements[1, num2]).Value, (object) (", " + SAP_Module.Proj.Dwellings[House].Address.PostCost));
              dataGlodgement.Value = obj;
            }
            this.dataGLodgements[2, num2].Value = (object) this.StatusList.Images[0];
            int num3 = checked (SAP_Module.Proj.Dwellings[House].HQMLAttempts - 1);
            int index = 0;
            bool flag;
            while (index <= num3)
            {
              if (SAP_Module.Proj.Dwellings[House].HQMLodgemnt[index].Success)
              {
                this.dataGLodgements[2, num2].Value = (object) this.StatusList.Images[2];
                flag = true;
                break;
              }
              checked { ++index; }
            }
            if (flag)
            {
              this.dataGLodgements[3, num2].Value = (object) false;
              this.dataGLodgements.Rows[num2].DefaultCellStyle.BackColor = Color.LightGreen;
              this.dataGLodgements.Rows[num2].DefaultCellStyle.ForeColor = Color.White;
              this.dataGLodgements.Rows[num2].DefaultCellStyle.SelectionBackColor = Color.LightGreen;
              this.Label1.Visible = true;
            }
            else
              this.dataGLodgements[3, num2].Value = (object) true;
            flag = false;
            checked { ++num2; }
          }
          checked { ++House; }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void CmdLodge_Click(object sender, EventArgs e)
    {
      if (Operators.CompareString(this.txtLocation.Text, "", false) == 0)
      {
        int num1 = (int) Interaction.MsgBox((object) "Please select the location to save these files.");
      }
      else
      {
        SAPSoapClient sapSoapClient = new SAPSoapClient();
        string Left = "";
        bool flag = false;
        try
        {
          Application.DoEvents();
          int num2 = checked (this.dataGLodgements.RowCount - 1);
          int rowIndex = 0;
          while (rowIndex <= num2)
          {
            Left = "";
            HQMResult hqmResult = new HQMResult();
            if (Operators.ConditionalCompareObjectEqual(this.dataGLodgements[3, rowIndex].Value, (object) true, false))
            {
              Left = Conversions.ToString(Operators.AddObject((object) Left, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(this.dataGLodgements[1, rowIndex].Value, (object) "\r\n"), (object) "\r\n"), (object) "Result......"), (object) "\r\n")));
              Application.DoEvents();
              SAP_Module.CurrDwelling = Conversions.ToInteger(this.dataGLodgements[0, rowIndex].Value);
              if ((uint) Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Address.Country, "England", false) > 0U)
              {
                Left = "XML is not allowed for " + SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Address.Country;
                Left += " Failed \r\n";
                this.dataGLodgements[2, rowIndex].Value = (object) this.StatusList.Images[1];
                ref SAP_Module.Dwelling local = ref SAP_Module.Proj.Dwellings[Conversions.ToInteger(this.dataGLodgements[0, rowIndex].Value)];
                local.HQMLodgemnt[checked (local.HQMLAttempts - 1)].DateLodged = DateAndTime.Now.Date;
                local.HQMLodgemnt[checked (local.HQMLAttempts - 1)].Result = Left;
                local.HQMLodgemnt[checked (local.HQMLAttempts - 1)].RRN = Validation.RefNum;
                local.HQMLodgemnt[checked (local.HQMLAttempts - 1)].Success = false;
                Application.DoEvents();
                flag = true;
              }
              if (!Validation.LodgementStatusCheck(SAP_Module.CurrDwelling))
              {
                Left = "Dwelling calculation failed for " + SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Reference;
                ref SAP_Module.Dwelling local = ref SAP_Module.Proj.Dwellings[Conversions.ToInteger(this.dataGLodgements[0, rowIndex].Value)];
                local.HQMLodgemnt[checked (local.HQMLAttempts - 1)].DateLodged = DateAndTime.Now;
                local.HQMLodgemnt[checked (local.HQMLAttempts - 1)].Result = Left;
                local.HQMLodgemnt[checked (local.HQMLAttempts - 1)].RRN = Validation.RefNum;
                local.HQMLodgemnt[checked (local.HQMLAttempts - 1)].Success = false;
                Application.DoEvents();
                flag = true;
              }
              try
              {
                if (string.IsNullOrEmpty(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Reference))
                {
                  Left = "Dwelling reference is null for " + SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Address.Country;
                  Left += " Failed \r\n";
                  this.dataGLodgements[2, rowIndex].Value = (object) this.StatusList.Images[1];
                  ref SAP_Module.Dwelling local = ref SAP_Module.Proj.Dwellings[Conversions.ToInteger(this.dataGLodgements[0, rowIndex].Value)];
                  local.HQMLodgemnt[checked (local.HQMLAttempts - 1)].DateLodged = DateAndTime.Now.Date;
                  local.HQMLodgemnt[checked (local.HQMLAttempts - 1)].Result = Left;
                  local.HQMLodgemnt[checked (local.HQMLAttempts - 1)].RRN = Validation.RefNum;
                  local.HQMLodgemnt[checked (local.HQMLAttempts - 1)].Success = false;
                  Application.DoEvents();
                  flag = true;
                }
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
              }
              // ISSUE: variable of a reference type
              int& local1;
              // ISSUE: explicit reference operation
              int num3 = checked (^(local1 = ref SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].HQMLAttempts) + 1);
              local1 = num3;
              // ISSUE: variable of a reference type
              SAP_Module.HQMLLodgement[]& local2;
              // ISSUE: explicit reference operation
              SAP_Module.HQMLLodgement[] hqmlLodgementArray = (SAP_Module.HQMLLodgement[]) Utils.CopyArray((Array) ^(local2 = ref SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].HQMLodgemnt), (Array) new SAP_Module.HQMLLodgement[checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].HQMLAttempts - 1 + 1)]);
              local2 = hqmlLodgementArray;
              int index = checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].HQMLAttempts - 1);
              Functions.Access_Details();
              Calc2012 calc2012 = new Calc2012();
              calc2012.SETPCDF(SAP_Module.PCDFData);
              calc2012.Dwelling = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling];
              HQMXML hqmxml1 = new HQMXML();
              SAP_Module.Calculation2012 = calc2012;
              SAP_Module.Proj.NoOfDwells = SAP_Module.Proj.NoOfDwells;
              Functions.CalculateNow();
              if (!flag)
              {
                try
                {
                  HQMXML.HQMXMLReturn hqmxmlReturn = new HQMXML.HQMXMLReturn();
                  HQMXML.HQMXMLReturn hqmxml2 = hqmxml1.CreateHQMXML(SAP_Module.CurrDwelling, 1);
                  if (!hqmxml2.Validated)
                    flag = true;
                  if (!flag)
                  {
                    HQMRequest Request = new HQMRequest();
                    hqmResult = new HQMResult();
                    Request.AddressLine1 = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Address.Line1;
                    Request.Postcode = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Address.PostCost;
                    Request.EacertificateNo = Validation.AssessorNO;
                    if (Validation.RefNum == null)
                      Validation.RefNum = "";
                    Request.RRN = Validation.RefNum;
                    Request.TransactionID = Functions.TransactionID;
                    Request.Encrypt = Functions.Encrypt;
                    Request.XML = hqmxml2.XML;
                    hqmResult = sapSoapClient.UploadHQMXML(Request);
                    string hqmxmlName = SAP_Module.HQMXMLName;
                    string str = this.txtLocation.Text + "\\" + SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Name + ".xml";
                    if (File.Exists(hqmxmlName))
                    {
                      if (File.Exists(str))
                        File.Delete(str);
                      File.Copy(hqmxmlName, str);
                      Validation.FirstFile = false;
                    }
                    SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].HQMLodgemnt[index].RRN = Validation.RefNum;
                  }
                  else
                  {
                    this.dataGLodgements[2, rowIndex].Value = (object) this.StatusList.Images[1];
                    Left = Left + " Failed\r\nScheme validation failed.." + hqmxml2.Msg + "\r\n";
                    SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].HQMLodgemnt[index].RRN = Validation.RefNum;
                    SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].HQMLodgemnt[index].Result = "Scheme validation failed.. " + hqmxml2.Msg;
                    SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].HQMLodgemnt[index].DateLodged = DateAndTime.Now;
                    SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].HQMLodgemnt[index].Success = false;
                    goto label_38;
                  }
                }
                catch (Exception ex)
                {
                  ProjectData.SetProjectError(ex);
                  Exception exception = ex;
                  this.dataGLodgements[2, rowIndex].Value = (object) this.StatusList.Images[1];
                  Left = Left + " Failed\r\n" + exception.Message + "\r\n\r\n";
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].HQMLodgemnt[index].RRN = Validation.RefNum;
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].HQMLodgemnt[index].Result = exception.Message + " " + hqmResult.ErrMsg;
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].HQMLodgemnt[index].DateLodged = DateAndTime.Now;
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].HQMLodgemnt[index].Success = false;
                  ProjectData.ClearProjectError();
                  goto label_38;
                }
              }
              ref SAP_Module.Dwelling local3 = ref SAP_Module.Proj.Dwellings[Conversions.ToInteger(this.dataGLodgements[0, rowIndex].Value)];
              if (hqmResult != null)
              {
                if (hqmResult.Success)
                {
                  Left += " Successfully created.\r\n";
                  this.dataGLodgements[2, rowIndex].Value = (object) this.StatusList.Images[2];
                  local3.HQMLodgemnt[checked (local3.HQMLAttempts - 1)].DateLodged = DateAndTime.Now;
                  local3.HQMLodgemnt[checked (local3.HQMLAttempts - 1)].Result = "Successfully created.";
                  local3.HQMLodgemnt[checked (local3.HQMLAttempts - 1)].RRN = Validation.RefNum;
                  local3.HQMLodgemnt[checked (local3.HQMLAttempts - 1)].Success = true;
                  if (calc2012.Calculation.SAP_rating_11a.SAPRating == 0.0)
                  {
                    local3.HQMLodgemnt[checked (local3.HQMLAttempts - 1)].SAP.SAPBand = calc2012.Calculation.SAP_rating_11b.SAPBand;
                    local3.HQMLodgemnt[checked (local3.HQMLAttempts - 1)].SAP.SAPRating = checked ((int) Math.Round(calc2012.Calculation.SAP_rating_11b.SAPRating));
                    local3.HQMLodgemnt[checked (local3.HQMLAttempts - 1)].PSAP.SAPRating = checked ((int) Math.Round(SAP_Module.CalculationImprove2012.Calculation.SAP_rating_11b.SAPRating));
                    local3.HQMLodgemnt[checked (local3.HQMLAttempts - 1)].PSAP.SAPBand = SAP_Module.CalculationImprove2012.Calculation.SAP_rating_11b.SAPBand;
                  }
                  else
                  {
                    local3.HQMLodgemnt[checked (local3.HQMLAttempts - 1)].SAP.SAPBand = calc2012.Calculation.SAP_rating_11a.SAPBand;
                    local3.HQMLodgemnt[checked (local3.HQMLAttempts - 1)].SAP.SAPRating = checked ((int) Math.Round(calc2012.Calculation.SAP_rating_11a.SAPRating));
                    local3.HQMLodgemnt[checked (local3.HQMLAttempts - 1)].PSAP.SAPRating = checked ((int) Math.Round(SAP_Module.CalculationImprove2012.Calculation.SAP_rating_11a.SAPRating));
                    local3.HQMLodgemnt[checked (local3.HQMLAttempts - 1)].PSAP.SAPBand = SAP_Module.CalculationImprove2012.Calculation.SAP_rating_11a.SAPBand;
                  }
                  if (calc2012.Calculation.CO2_Emissions_12a.EIValue == 0.0)
                  {
                    local3.HQMLodgemnt[checked (local3.HQMLAttempts - 1)].SAP.EIBand = calc2012.Calculation.CO2_Emissions_12b.EIBand;
                    local3.HQMLodgemnt[checked (local3.HQMLAttempts - 1)].SAP.EIRating = checked ((int) Math.Round(calc2012.Calculation.CO2_Emissions_12b.EIRating));
                    local3.HQMLodgemnt[checked (local3.HQMLAttempts - 1)].PSAP.EIBand = SAP_Module.CalculationImprove2012.Calculation.CO2_Emissions_12b.EIBand;
                    local3.HQMLodgemnt[checked (local3.HQMLAttempts - 1)].PSAP.EIRating = checked ((int) Math.Round(SAP_Module.CalculationImprove2012.Calculation.CO2_Emissions_12b.EIRating));
                  }
                  else
                  {
                    local3.HQMLodgemnt[checked (local3.HQMLAttempts - 1)].SAP.EIBand = calc2012.Calculation.CO2_Emissions_12a.EIBand;
                    local3.HQMLodgemnt[checked (local3.HQMLAttempts - 1)].SAP.EIRating = checked ((int) Math.Round(calc2012.Calculation.CO2_Emissions_12a.Box274));
                    local3.HQMLodgemnt[checked (local3.HQMLAttempts - 1)].PSAP.EIBand = SAP_Module.CalculationImprove2012.Calculation.CO2_Emissions_12a.EIBand;
                    local3.HQMLodgemnt[checked (local3.HQMLAttempts - 1)].PSAP.EIRating = checked ((int) Math.Round(SAP_Module.CalculationImprove2012.Calculation.CO2_Emissions_12a.Box274));
                  }
                }
                else
                {
                  Left += " Failed \r\n";
                  this.dataGLodgements[2, rowIndex].Value = (object) this.StatusList.Images[1];
                  local3.HQMLodgemnt[checked (local3.HQMLAttempts - 1)].DateLodged = DateAndTime.Now;
                  local3.HQMLodgemnt[checked (local3.HQMLAttempts - 1)].Result = Left + " " + hqmResult.ErrMsg;
                  local3.HQMLodgemnt[checked (local3.HQMLAttempts - 1)].RRN = Validation.RefNum;
                  local3.HQMLodgemnt[checked (local3.HQMLAttempts - 1)].Success = false;
                }
                local3.HQMLodgemnt[checked (local3.HQMLAttempts - 1)].Method = "Batch";
              }
            }
label_38:
            Application.DoEvents();
            flag = false;
            checked { ++rowIndex; }
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          Exception exception = ex;
          string str = Left + exception.Message + "\r\n" + " XML Generation Failed. Please view history to see error message(s).\r\n";
          ProjectData.ClearProjectError();
        }
        Functions.SaveFile(SAP_Module.Proj, SAP_Module.Proj.SaveFileName);
        SAP_Module.CurrDwelling = -1;
        Process.Start("explorer.exe", this.txtLocation.Text);
      }
    }

    private void cmdLocation_Click(object sender, EventArgs e)
    {
      int num = (int) this.FD1.ShowDialog();
      this.txtLocation.Text = this.FD1.SelectedPath;
    }

    private void CloseToolStripMenuItem_Click(object sender, EventArgs e) => this.Close();

    private void cmdShow_Click(object sender, EventArgs e)
    {
      MyProject.Forms.HQMHistory.FillHQMHistory();
      MyProject.Forms.HQMHistory.Show();
    }
  }
}
