
// Type: SAP2012.Boiler_Database




using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using SAP2012.My;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SAP2012
{
  [DesignerGenerated]
  public class Boiler_Database : Form
  {
    private IContainer components;
    public int Type;
    private DataTable NewTable;

    public Boiler_Database()
    {
      this.Load += new EventHandler(this.Boiler_Database_Load);
      this.NewTable = new DataTable();
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Boiler_Database));
      this.GroupBox1 = new GroupBox();
      this.SearchCriteria = new DataGridView();
      this.ColSearch = new DataGridViewTextBoxColumn();
      this.ColText = new DataGridViewTextBoxColumn();
      this.GroupBox15 = new GroupBox();
      this.cmdadd = new Button();
      this.txtCriteria = new TextBox();
      this.Label50 = new Label();
      this.cboCriteria = new ComboBox();
      this.txtPrimary = new ComboBox();
      this.Label52 = new Label();
      this.Label53 = new Label();
      this.cmdClear = new Button();
      this.cmdCancel = new Button();
      this.Label1 = new Label();
      this.DataInfo = new DataGridView();
      this.cmdSearch = new Button();
      this.CmdNext1 = new Button();
      this.SplitContainer1 = new SplitContainer();
      this.SearchResults = new DataGridView();
      this.cmdShow = new Button();
      this.TabControl1 = new TabControl();
      this.TabPage1 = new TabPage();
      this.Label3 = new Label();
      this.txtSearch = new TextBox();
      this.Label2 = new Label();
      this.cmdSimpleSearch = new Button();
      this.TabPage2 = new TabPage();
      this.lblDataBVersion = new Label();
      this.GroupBox1.SuspendLayout();
      ((ISupportInitialize) this.SearchCriteria).BeginInit();
      this.GroupBox15.SuspendLayout();
      ((ISupportInitialize) this.DataInfo).BeginInit();
      this.SplitContainer1.Panel1.SuspendLayout();
      this.SplitContainer1.Panel2.SuspendLayout();
      this.SplitContainer1.SuspendLayout();
      ((ISupportInitialize) this.SearchResults).BeginInit();
      this.TabControl1.SuspendLayout();
      this.TabPage1.SuspendLayout();
      this.TabPage2.SuspendLayout();
      this.SuspendLayout();
      this.GroupBox1.Controls.Add((Control) this.SearchCriteria);
      this.GroupBox1.Location = new Point(8, 6);
      this.GroupBox1.Name = "GroupBox1";
      this.GroupBox1.Size = new Size(477, 183);
      this.GroupBox1.TabIndex = 2;
      this.GroupBox1.TabStop = false;
      this.GroupBox1.Text = "Search Critera";
      this.SearchCriteria.AllowUserToAddRows = false;
      this.SearchCriteria.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      this.SearchCriteria.CausesValidation = false;
      this.SearchCriteria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.SearchCriteria.Columns.AddRange((DataGridViewColumn) this.ColSearch, (DataGridViewColumn) this.ColText);
      this.SearchCriteria.EditMode = DataGridViewEditMode.EditOnEnter;
      this.SearchCriteria.Location = new Point(6, 19);
      this.SearchCriteria.Name = "SearchCriteria";
      this.SearchCriteria.RowHeadersWidth = 25;
      this.SearchCriteria.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.SearchCriteria.Size = new Size(465, 158);
      this.SearchCriteria.TabIndex = 0;
      this.ColSearch.HeaderText = "Search By";
      this.ColSearch.Name = "ColSearch";
      this.ColSearch.ReadOnly = true;
      this.ColSearch.Resizable = DataGridViewTriState.True;
      this.ColSearch.Width = 165;
      this.ColText.HeaderText = "Criteria";
      this.ColText.Name = "ColText";
      this.ColText.Width = 245;
      this.GroupBox15.Controls.Add((Control) this.cmdadd);
      this.GroupBox15.Controls.Add((Control) this.txtCriteria);
      this.GroupBox15.Controls.Add((Control) this.Label50);
      this.GroupBox15.Controls.Add((Control) this.cboCriteria);
      this.GroupBox15.Controls.Add((Control) this.txtPrimary);
      this.GroupBox15.Controls.Add((Control) this.Label52);
      this.GroupBox15.Controls.Add((Control) this.Label53);
      this.GroupBox15.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.GroupBox15.Location = new Point(491, 6);
      this.GroupBox15.Name = "GroupBox15";
      this.GroupBox15.Size = new Size(285, 138);
      this.GroupBox15.TabIndex = 21;
      this.GroupBox15.TabStop = false;
      this.GroupBox15.Text = "Search Items";
      this.cmdadd.BackColor = Color.LightSlateGray;
      this.cmdadd.Cursor = Cursors.Hand;
      this.cmdadd.FlatStyle = FlatStyle.Popup;
      this.cmdadd.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.cmdadd.ForeColor = Color.White;
      this.cmdadd.Location = new Point(188, 102);
      this.cmdadd.Name = "cmdadd";
      this.cmdadd.Size = new Size(92, 26);
      this.cmdadd.TabIndex = 3;
      this.cmdadd.Tag = (object) "Add to boiler search";
      this.cmdadd.Text = "Add";
      this.cmdadd.UseVisualStyleBackColor = false;
      this.txtCriteria.Location = new Point((int) sbyte.MaxValue, 74);
      this.txtCriteria.Name = "txtCriteria";
      this.txtCriteria.Size = new Size(151, 22);
      this.txtCriteria.TabIndex = 2;
      this.Label50.AutoSize = true;
      this.Label50.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label50.Location = new Point(6, 77);
      this.Label50.Name = "Label50";
      this.Label50.Size = new Size(44, 14);
      this.Label50.TabIndex = 13;
      this.Label50.Text = "Criteria";
      this.cboCriteria.Cursor = Cursors.Hand;
      this.cboCriteria.FormattingEnabled = true;
      this.cboCriteria.Location = new Point((int) sbyte.MaxValue, 46);
      this.cboCriteria.Name = "cboCriteria";
      this.cboCriteria.Size = new Size(151, 22);
      this.cboCriteria.TabIndex = 1;
      this.txtPrimary.Cursor = Cursors.Hand;
      this.txtPrimary.FormattingEnabled = true;
      this.txtPrimary.Items.AddRange(new object[9]
      {
        (object) "Brand Name",
        (object) "Model Name",
        (object) "Model Qualifier",
        (object) "Index",
        (object) "Boiler ID",
        (object) "Manufacturer",
        (object) "Condensing",
        (object) "Flue",
        (object) "Mounting"
      });
      this.txtPrimary.Location = new Point((int) sbyte.MaxValue, 18);
      this.txtPrimary.Name = "txtPrimary";
      this.txtPrimary.Size = new Size(151, 22);
      this.txtPrimary.TabIndex = 0;
      this.Label52.AutoSize = true;
      this.Label52.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label52.Location = new Point(6, 49);
      this.Label52.Name = "Label52";
      this.Label52.Size = new Size(44, 14);
      this.Label52.TabIndex = 4;
      this.Label52.Text = "Criteria";
      this.Label53.AutoSize = true;
      this.Label53.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label53.Location = new Point(6, 22);
      this.Label53.Name = "Label53";
      this.Label53.Size = new Size(61, 14);
      this.Label53.TabIndex = 2;
      this.Label53.Text = "Search By";
      this.cmdClear.BackColor = Color.LightSlateGray;
      this.cmdClear.Cursor = Cursors.Hand;
      this.cmdClear.FlatStyle = FlatStyle.Popup;
      this.cmdClear.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.cmdClear.ForeColor = Color.White;
      this.cmdClear.Location = new Point(500, 150);
      this.cmdClear.Name = "cmdClear";
      this.cmdClear.Size = new Size(92, 26);
      this.cmdClear.TabIndex = 3;
      this.cmdClear.Tag = (object) "Clear";
      this.cmdClear.Text = "Clear";
      this.cmdClear.UseVisualStyleBackColor = false;
      this.cmdCancel.BackColor = Color.LightSlateGray;
      this.cmdCancel.Cursor = Cursors.Hand;
      this.cmdCancel.DialogResult = DialogResult.Cancel;
      this.cmdCancel.FlatStyle = FlatStyle.Popup;
      this.cmdCancel.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.cmdCancel.ForeColor = Color.White;
      this.cmdCancel.Location = new Point(455, 228);
      this.cmdCancel.Name = "cmdCancel";
      this.cmdCancel.Size = new Size(92, 26);
      this.cmdCancel.TabIndex = 1;
      this.cmdCancel.Text = "Cancel";
      this.cmdCancel.UseVisualStyleBackColor = false;
      this.Label1.AutoSize = true;
      this.Label1.Location = new Point(15, 234);
      this.Label1.Name = "Label1";
      this.Label1.Size = new Size(38, 13);
      this.Label1.TabIndex = 22;
      this.Label1.Text = "Label1";
      gridViewCellStyle1.BackColor = Color.Lavender;
      this.DataInfo.AlternatingRowsDefaultCellStyle = gridViewCellStyle1;
      this.DataInfo.BackgroundColor = Color.White;
      this.DataInfo.BorderStyle = BorderStyle.Fixed3D;
      this.DataInfo.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
      this.DataInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.DataInfo.ColumnHeadersVisible = false;
      this.DataInfo.Dock = DockStyle.Fill;
      this.DataInfo.Location = new Point(0, 0);
      this.DataInfo.Name = "DataInfo";
      this.DataInfo.ReadOnly = true;
      this.DataInfo.RowHeadersVisible = false;
      this.DataInfo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.DataInfo.Size = new Size(96, 100);
      this.DataInfo.TabIndex = 5;
      this.DataInfo.TabStop = false;
      this.cmdSearch.BackColor = Color.LightSlateGray;
      this.cmdSearch.Cursor = Cursors.Hand;
      this.cmdSearch.FlatStyle = FlatStyle.Popup;
      this.cmdSearch.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.cmdSearch.ForeColor = Color.White;
      this.cmdSearch.Location = new Point(679, 150);
      this.cmdSearch.Name = "cmdSearch";
      this.cmdSearch.Size = new Size(92, 26);
      this.cmdSearch.TabIndex = 0;
      this.cmdSearch.Text = "Search";
      this.cmdSearch.UseVisualStyleBackColor = false;
      this.CmdNext1.BackColor = Color.LightSlateGray;
      this.CmdNext1.Cursor = Cursors.Hand;
      this.CmdNext1.DialogResult = DialogResult.OK;
      this.CmdNext1.FlatStyle = FlatStyle.Popup;
      this.CmdNext1.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.CmdNext1.ForeColor = Color.White;
      this.CmdNext1.Location = new Point(553, 228);
      this.CmdNext1.Name = "CmdNext1";
      this.CmdNext1.Size = new Size(92, 26);
      this.CmdNext1.TabIndex = 0;
      this.CmdNext1.Text = "Confirm";
      this.CmdNext1.UseVisualStyleBackColor = false;
      this.SplitContainer1.Dock = DockStyle.Bottom;
      this.SplitContainer1.Location = new Point(0, 274);
      this.SplitContainer1.Name = "SplitContainer1";
      this.SplitContainer1.Panel1.Controls.Add((Control) this.SearchResults);
      this.SplitContainer1.Panel2.Controls.Add((Control) this.DataInfo);
      this.SplitContainer1.Panel2Collapsed = true;
      this.SplitContainer1.Size = new Size(808, 321);
      this.SplitContainer1.SplitterDistance = 400;
      this.SplitContainer1.TabIndex = 23;
      this.SearchResults.AllowUserToAddRows = false;
      this.SearchResults.AllowUserToDeleteRows = false;
      this.SearchResults.AllowUserToOrderColumns = true;
      gridViewCellStyle2.BackColor = Color.Lavender;
      this.SearchResults.AlternatingRowsDefaultCellStyle = gridViewCellStyle2;
      this.SearchResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.SearchResults.Cursor = Cursors.Hand;
      this.SearchResults.Dock = DockStyle.Fill;
      this.SearchResults.Location = new Point(0, 0);
      this.SearchResults.Name = "SearchResults";
      this.SearchResults.ReadOnly = true;
      this.SearchResults.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.SearchResults.Size = new Size(808, 321);
      this.SearchResults.TabIndex = 4;
      this.cmdShow.BackColor = Color.LightSlateGray;
      this.cmdShow.Cursor = Cursors.Hand;
      this.cmdShow.FlatStyle = FlatStyle.Popup;
      this.cmdShow.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.cmdShow.ForeColor = Color.White;
      this.cmdShow.Location = new Point(651, 228);
      this.cmdShow.Name = "cmdShow";
      this.cmdShow.Size = new Size(124, 26);
      this.cmdShow.TabIndex = 6;
      this.cmdShow.Tag = (object) "Clear";
      this.cmdShow.Text = "<< Show Details";
      this.cmdShow.UseVisualStyleBackColor = false;
      this.TabControl1.Controls.Add((Control) this.TabPage1);
      this.TabControl1.Controls.Add((Control) this.TabPage2);
      this.TabControl1.Dock = DockStyle.Top;
      this.TabControl1.Location = new Point(0, 0);
      this.TabControl1.Name = "TabControl1";
      this.TabControl1.SelectedIndex = 0;
      this.TabControl1.Size = new Size(808, 223);
      this.TabControl1.TabIndex = 1;
      this.TabPage1.Controls.Add((Control) this.Label3);
      this.TabPage1.Controls.Add((Control) this.txtSearch);
      this.TabPage1.Controls.Add((Control) this.Label2);
      this.TabPage1.Controls.Add((Control) this.cmdSimpleSearch);
      this.TabPage1.Location = new Point(4, 22);
      this.TabPage1.Name = "TabPage1";
      this.TabPage1.Padding = new Padding(3);
      this.TabPage1.Size = new Size(800, 197);
      this.TabPage1.TabIndex = 0;
      this.TabPage1.Text = "Simple Search";
      this.TabPage1.UseVisualStyleBackColor = true;
      this.Label3.AutoSize = true;
      this.Label3.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label3.ForeColor = Color.DarkOliveGreen;
      this.Label3.Location = new Point(23, 42);
      this.Label3.Name = "Label3";
      this.Label3.Size = new Size(642, 84);
      this.Label3.TabIndex = 17;
      this.Label3.Text = componentResourceManager.GetString("Label3.Text");
      this.txtSearch.Location = new Point(130, 15);
      this.txtSearch.Name = "txtSearch";
      this.txtSearch.Size = new Size(657, 21);
      this.txtSearch.TabIndex = 0;
      this.Label2.AutoSize = true;
      this.Label2.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label2.Location = new Point(23, 20);
      this.Label2.Name = "Label2";
      this.Label2.Size = new Size(85, 14);
      this.Label2.TabIndex = 16;
      this.Label2.Text = "Search Criteria";
      this.cmdSimpleSearch.BackColor = Color.LightSlateGray;
      this.cmdSimpleSearch.Cursor = Cursors.Hand;
      this.cmdSimpleSearch.FlatStyle = FlatStyle.Popup;
      this.cmdSimpleSearch.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.cmdSimpleSearch.ForeColor = Color.White;
      this.cmdSimpleSearch.Location = new Point(679, 153);
      this.cmdSimpleSearch.Name = "cmdSimpleSearch";
      this.cmdSimpleSearch.Size = new Size(92, 26);
      this.cmdSimpleSearch.TabIndex = 1;
      this.cmdSimpleSearch.Text = "Search";
      this.cmdSimpleSearch.UseVisualStyleBackColor = false;
      this.TabPage2.Controls.Add((Control) this.GroupBox1);
      this.TabPage2.Controls.Add((Control) this.GroupBox15);
      this.TabPage2.Controls.Add((Control) this.cmdSearch);
      this.TabPage2.Controls.Add((Control) this.cmdClear);
      this.TabPage2.Location = new Point(4, 22);
      this.TabPage2.Name = "TabPage2";
      this.TabPage2.Padding = new Padding(3);
      this.TabPage2.Size = new Size(800, 197);
      this.TabPage2.TabIndex = 1;
      this.TabPage2.Text = "Detailed Search";
      this.TabPage2.UseVisualStyleBackColor = true;
      this.lblDataBVersion.AutoSize = true;
      this.lblDataBVersion.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblDataBVersion.ForeColor = Color.Maroon;
      this.lblDataBVersion.Location = new Point(452, 5);
      this.lblDataBVersion.Name = "lblDataBVersion";
      this.lblDataBVersion.Size = new Size(332, 14);
      this.lblDataBVersion.TabIndex = 24;
      this.lblDataBVersion.Text = "Boiler Database Version = 250 : Dated : 21/04/2010";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.White;
      this.CancelButton = (IButtonControl) this.cmdCancel;
      this.ClientSize = new Size(808, 595);
      this.Controls.Add((Control) this.lblDataBVersion);
      this.Controls.Add((Control) this.TabControl1);
      this.Controls.Add((Control) this.SplitContainer1);
      this.Controls.Add((Control) this.cmdCancel);
      this.Controls.Add((Control) this.CmdNext1);
      this.Controls.Add((Control) this.cmdShow);
      this.Controls.Add((Control) this.Label1);
      this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.Name = nameof (Boiler_Database);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Boiler Database.";
      this.GroupBox1.ResumeLayout(false);
      ((ISupportInitialize) this.SearchCriteria).EndInit();
      this.GroupBox15.ResumeLayout(false);
      this.GroupBox15.PerformLayout();
      ((ISupportInitialize) this.DataInfo).EndInit();
      this.SplitContainer1.Panel1.ResumeLayout(false);
      this.SplitContainer1.Panel2.ResumeLayout(false);
      this.SplitContainer1.ResumeLayout(false);
      ((ISupportInitialize) this.SearchResults).EndInit();
      this.TabControl1.ResumeLayout(false);
      this.TabPage1.ResumeLayout(false);
      this.TabPage1.PerformLayout();
      this.TabPage2.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    [field: AccessedThroughProperty("GroupBox1")]
    internal virtual GroupBox GroupBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("SearchCriteria")]
    internal virtual DataGridView SearchCriteria { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox15")]
    internal virtual GroupBox GroupBox15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label50")]
    internal virtual Label Label50 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ComboBox cboCriteria
    {
      get => this._cboCriteria;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtLocation_Click);
        ComboBox cboCriteria1 = this._cboCriteria;
        if (cboCriteria1 != null)
          cboCriteria1.Click -= eventHandler;
        this._cboCriteria = value;
        ComboBox cboCriteria2 = this._cboCriteria;
        if (cboCriteria2 == null)
          return;
        cboCriteria2.Click += eventHandler;
      }
    }

    internal virtual ComboBox txtPrimary
    {
      get => this._txtPrimary;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.txtLocation_Click);
        EventHandler eventHandler2 = new EventHandler(this.txtPrimary_SelectedIndexChanged);
        ComboBox txtPrimary1 = this._txtPrimary;
        if (txtPrimary1 != null)
        {
          txtPrimary1.Click -= eventHandler1;
          txtPrimary1.SelectedIndexChanged -= eventHandler2;
        }
        this._txtPrimary = value;
        ComboBox txtPrimary2 = this._txtPrimary;
        if (txtPrimary2 == null)
          return;
        txtPrimary2.Click += eventHandler1;
        txtPrimary2.SelectedIndexChanged += eventHandler2;
      }
    }

    [field: AccessedThroughProperty("Label52")]
    internal virtual Label Label52 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label53")]
    internal virtual Label Label53 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtCriteria")]
    internal virtual TextBox txtCriteria { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label1")]
    internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("ColSearch")]
    internal virtual DataGridViewTextBoxColumn ColSearch { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("ColText")]
    internal virtual DataGridViewTextBoxColumn ColText { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DataInfo")]
    internal virtual DataGridView DataInfo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button cmdSearch
    {
      get => this._cmdSearch;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdSearch_Click_1);
        Button cmdSearch1 = this._cmdSearch;
        if (cmdSearch1 != null)
          cmdSearch1.Click -= eventHandler;
        this._cmdSearch = value;
        Button cmdSearch2 = this._cmdSearch;
        if (cmdSearch2 == null)
          return;
        cmdSearch2.Click += eventHandler;
      }
    }

    private virtual Button CmdNext1
    {
      get => this._CmdNext1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CmdNext1_Click);
        Button cmdNext1_1 = this._CmdNext1;
        if (cmdNext1_1 != null)
          cmdNext1_1.Click -= eventHandler;
        this._CmdNext1 = value;
        Button cmdNext1_2 = this._CmdNext1;
        if (cmdNext1_2 == null)
          return;
        cmdNext1_2.Click += eventHandler;
      }
    }

    private virtual Button cmdadd
    {
      get => this._cmdadd;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdadd_Click);
        Button cmdadd1 = this._cmdadd;
        if (cmdadd1 != null)
          cmdadd1.Click -= eventHandler;
        this._cmdadd = value;
        Button cmdadd2 = this._cmdadd;
        if (cmdadd2 == null)
          return;
        cmdadd2.Click += eventHandler;
      }
    }

    private virtual Button cmdCancel
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

    private virtual Button cmdClear
    {
      get => this._cmdClear;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdClear_Click_1);
        Button cmdClear1 = this._cmdClear;
        if (cmdClear1 != null)
          cmdClear1.Click -= eventHandler;
        this._cmdClear = value;
        Button cmdClear2 = this._cmdClear;
        if (cmdClear2 == null)
          return;
        cmdClear2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("SplitContainer1")]
    internal virtual SplitContainer SplitContainer1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private virtual Button cmdShow
    {
      get => this._cmdShow;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdShow_Click);
        Button cmdShow1 = this._cmdShow;
        if (cmdShow1 != null)
          cmdShow1.Click -= eventHandler;
        this._cmdShow = value;
        Button cmdShow2 = this._cmdShow;
        if (cmdShow2 == null)
          return;
        cmdShow2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("TabControl1")]
    internal virtual TabControl TabControl1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("TabPage1")]
    internal virtual TabPage TabPage1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("TabPage2")]
    internal virtual TabPage TabPage2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox txtSearch
    {
      get => this._txtSearch;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtSearch_KeyDown);
        EventHandler eventHandler = new EventHandler(this.txtSearch_TextChanged);
        TextBox txtSearch1 = this._txtSearch;
        if (txtSearch1 != null)
        {
          txtSearch1.KeyDown -= keyEventHandler;
          txtSearch1.TextChanged -= eventHandler;
        }
        this._txtSearch = value;
        TextBox txtSearch2 = this._txtSearch;
        if (txtSearch2 == null)
          return;
        txtSearch2.KeyDown += keyEventHandler;
        txtSearch2.TextChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Label2")]
    internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button cmdSimpleSearch
    {
      get => this._cmdSimpleSearch;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdSimpleSearch_Click);
        Button cmdSimpleSearch1 = this._cmdSimpleSearch;
        if (cmdSimpleSearch1 != null)
          cmdSimpleSearch1.Click -= eventHandler;
        this._cmdSimpleSearch = value;
        Button cmdSimpleSearch2 = this._cmdSimpleSearch;
        if (cmdSimpleSearch2 == null)
          return;
        cmdSimpleSearch2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Label3")]
    internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("lblDataBVersion")]
    internal virtual Label lblDataBVersion { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DataGridView SearchResults
    {
      get => this._SearchResults;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DataGridViewCellEventHandler cellEventHandler = new DataGridViewCellEventHandler(this.SearchResults_CellEnter);
        DataGridViewCellMouseEventHandler mouseEventHandler = new DataGridViewCellMouseEventHandler(this.SearchResults_CellMouseDoubleClick);
        DataGridView searchResults1 = this._SearchResults;
        if (searchResults1 != null)
        {
          searchResults1.CellEnter -= cellEventHandler;
          searchResults1.CellMouseDoubleClick -= mouseEventHandler;
        }
        this._SearchResults = value;
        DataGridView searchResults2 = this._SearchResults;
        if (searchResults2 == null)
          return;
        searchResults2.CellEnter += cellEventHandler;
        searchResults2.CellMouseDoubleClick += mouseEventHandler;
      }
    }

    private void Boiler_Database_Load(object sender, EventArgs e)
    {
      this.NewTable = new DataTable();
      this.txtSearch.Text = "";
      this.SearchResults.DataSource = (object) null;
      this.lblDataBVersion.Text = "Boiler Database Version = " + Conversions.ToString(SAP_Module.DataBVersion) + ", Dated : " + SAP_Module.DataBDate;
      this.NewTable = new DataTable();
      PCDF pcdfData;
      List<PCDF.SEDBUK> boilers = (pcdfData = SAP_Module.PCDFData).Boilers;
      List<PCDF.SEDBUK> items = Functions.DeepClone<List<PCDF.SEDBUK>>(ref boilers);
      pcdfData.Boilers = boilers;
      this.NewTable = Validation.ListToDataTable<PCDF.SEDBUK>(items);
      int num1 = checked (this.NewTable.Rows.Count - 1);
      int index = 0;
      while (index <= num1)
      {
        double num2 = Conversion.Val(RuntimeHelpers.GetObjectValue(this.NewTable.Rows[index]["producttype"]));
        if (num2 == 0.0)
          this.NewTable.Rows[index]["producttype"] = (object) "normal";
        else if (num2 == 1.0)
          this.NewTable.Rows[index]["producttype"] = (object) "illustrative";
        else if (num2 == 2.0)
          this.NewTable.Rows[index]["producttype"] = (object) "under investigation";
        else if (num2 == 3.0)
          this.NewTable.Rows[index]["producttype"] = (object) "not valid";
        else if (num2 == 4.0)
          this.NewTable.Rows[index]["producttype"] = (object) "The SAP Gas and Oil Boiler methodology is currently being reviewed. This entry may change.";
        checked { ++index; }
      }
      this.SearchResults.DataSource = (object) this.NewTable;
      this.Label1.Text = "Currently Showing " + Conversions.ToString(this.SearchResults.RowCount) + " out of " + Conversions.ToString(SAP_Module.PCDFData.Boilers.Count);
      this.DataInfo.Rows.Clear();
      this.DataInfo.Columns.Add("C1", "C1");
      this.DataInfo.Columns.Add("C2", "C2");
      this.DataInfo.Rows.Add(58);
      this.DataInfo.Columns[0].Width = 120;
      this.DataInfo.Columns[1].Width = 250;
      this.DataInfo.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
      this.DataInfo[0, 0].Value = (object) "Index";
      this.DataInfo[0, 1].Value = (object) "Manufacturer Reference";
      this.DataInfo[0, 2].Value = (object) "DB Entry Updated";
      this.DataInfo[0, 3].Value = (object) "Manufacturer Name";
      this.DataInfo[0, 4].Value = (object) "Brand Name";
      this.DataInfo[0, 5].Value = (object) "Model Name";
      this.DataInfo[0, 6].Value = (object) "ModelQualifier";
      this.DataInfo[0, 7].Value = (object) "Boiler ID";
      this.DataInfo[0, 8].Value = (object) "First Year of Manufacture";
      this.DataInfo[0, 9].Value = (object) "Final Year of Manufacture";
      this.DataInfo[0, 10].Value = (object) "Fuel";
      this.DataInfo[0, 11].Value = (object) "Mount Position";
      this.DataInfo[0, 12].Value = (object) "Exposure Rating";
      this.DataInfo[0, 13].Value = (object) "Main Type";
      this.DataInfo[0, 14].Value = (object) "Subsidiary Type";
      this.DataInfo[0, 15].Value = (object) "Subsidiary Type  Table";
      this.DataInfo[0, 16].Value = (object) "Subsidiary Type Index";
      this.DataInfo[0, 17].Value = (object) "Condensing";
      this.DataInfo[0, 18].Value = (object) "Flue Type";
      this.DataInfo[0, 19].Value = (object) "Fan Assistance";
      this.DataInfo[0, 20].Value = (object) "Boiler Power (bottom of range)";
      this.DataInfo[0, 21].Value = (object) "Boiler Power (top of range)";
      this.DataInfo[0, 22].Value = (object) "Energy Efficiency Class";
      this.DataInfo[0, 23].Value = (object) "Annual Seasonal Efficiency";
      this.DataInfo[0, 24].Value = (object) "SAP Winter Seasonal Efficiency";
      this.DataInfo[0, 25].Value = (object) "SAP Summer Seasonal Efficiency";
      this.DataInfo[0, 26].Value = (object) "Hot Water Efficiency";
      this.DataInfo[0, 27].Value = (object) "SAP 2005 Efficiency";
      this.DataInfo[0, 28].Value = (object) "Efficiency Category";
      this.DataInfo[0, 29].Value = (object) "Test gas for LPG";
      this.DataInfo[0, 30].Value = (object) "Test Correction for LPG";
      this.DataInfo[0, 31].Value = (object) "SAP Equation Used";
      this.DataInfo[0, 32].Value = (object) "Ignition";
      this.DataInfo[0, 33].Value = (object) "Burner Control";
      this.DataInfo[0, 34].Value = (object) "Electrical power while boiler is firing";
      this.DataInfo[0, 35].Value = (object) "Electrical power while boiler is not firing";
      this.DataInfo[0, 36].Value = (object) "Store Type";
      this.DataInfo[0, 37].Value = (object) "Store loss in test";
      this.DataInfo[0, 38].Value = (object) "Separate store";
      this.DataInfo[0, 39].Value = (object) "Store boiler volume";
      this.DataInfo[0, 40].Value = (object) "Store solar volume";
      this.DataInfo[0, 41].Value = (object) "Store insulation thickness";
      this.DataInfo[0, 42].Value = (object) "Store insulation type";
      this.DataInfo[0, 43].Value = (object) "Store temperature";
      this.DataInfo[0, 44].Value = (object) "Store heat loss rate";
      this.DataInfo[0, 45].Value = (object) "Separate DHW tests";
      this.DataInfo[0, 46].Value = (object) "Fuel energy for HW test 1";
      this.DataInfo[0, 47].Value = (object) "Electrical energy for HW test 1";
      this.DataInfo[0, 48].Value = (object) "Rejected energy r1 in HW test 1";
      this.DataInfo[0, 49].Value = (object) "Storage loss factor F1";
      this.DataInfo[0, 50].Value = (object) "Fuel energy for HW test 2";
      this.DataInfo[0, 51].Value = (object) "Electrical energy for HW test 2";
      this.DataInfo[0, 52].Value = (object) "Rejected energy r2 in HW test 2";
      this.DataInfo[0, 53].Value = (object) "Storage loss factor F2";
      this.DataInfo[0, 54].Value = (object) "Storage loss factor F3";
      this.DataInfo[0, 55].Value = (object) "'Keep-hot' facility";
      this.DataInfo[0, 56].Value = (object) "'Keep-hot' timer";
      this.DataInfo[0, 57].Value = (object) "'Keep-hot' electric heater";
      this.DataInfo[0, 58].Value = (object) "Control capabilities";
    }

    private void txtLocation_Click(object sender, EventArgs e) => ((ComboBox) sender).DroppedDown = true;

    private void txtPrimary_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.cboCriteria.Items.Clear();
      this.cboCriteria.Text = "";
      this.txtCriteria.Text = "";
      string text1 = this.txtPrimary.Text;
      // ISSUE: reference to a compiler-generated method
      switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(text1))
      {
        case 486069869:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text1, "Model Name", false) != 0)
            return;
          break;
        case 931944998:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text1, "Mounting", false) != 0)
            return;
          goto label_25;
        case 1077218609:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text1, "Flue", false) != 0)
            return;
          goto label_25;
        case 2023210704:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text1, "Manufacturer", false) != 0)
            return;
          break;
        case 2241118125:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text1, "Fuel", false) != 0)
            return;
          goto label_25;
        case 2541007974:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text1, "Band", false) != 0)
            return;
          goto label_25;
        case 2833738345:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text1, "Brand Name", false) != 0)
            return;
          break;
        case 2932321867:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text1, "Index", false) != 0)
            return;
          break;
        case 3554027374:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text1, "Model Qualifier", false) != 0)
            return;
          break;
        case 3885520069:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text1, "Condensing", false) != 0)
            return;
          goto label_25;
        case 4145117973:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text1, "Boiler ID", false) != 0)
            return;
          break;
        default:
          return;
      }
      this.txtCriteria.ReadOnly = false;
      this.txtCriteria.BackColor = Color.White;
      this.txtCriteria.Text = "";
      this.txtCriteria.Focus();
      this.cboCriteria.Enabled = false;
      this.cboCriteria.BackColor = Color.LightGray;
      return;
label_25:
      this.txtCriteria.ReadOnly = true;
      this.txtCriteria.BackColor = Color.LightGray;
      this.cboCriteria.Enabled = true;
      this.cboCriteria.BackColor = Color.White;
      this.cboCriteria.Text = "";
      this.cboCriteria.Focus();
      string text2 = this.txtPrimary.Text;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text2, "Fuel", false) != 0)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text2, "Band", false) != 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text2, "Condensing", false) != 0)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text2, "Flue", false) != 0)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text2, "Mounting", false) != 0)
                return;
              this.cboCriteria.Items.Add((object) "Floor");
              this.cboCriteria.Items.Add((object) "Wall");
              this.cboCriteria.Items.Add((object) "Back boiler");
            }
            else
            {
              this.cboCriteria.Items.Add((object) "Open");
              this.cboCriteria.Items.Add((object) "Room-sealed");
            }
          }
          else
          {
            this.cboCriteria.Items.Add((object) "Non-condensing");
            this.cboCriteria.Items.Add((object) "Condensing");
          }
        }
        else
        {
          this.cboCriteria.Items.Add((object) "A");
          this.cboCriteria.Items.Add((object) "B");
          this.cboCriteria.Items.Add((object) "C");
          this.cboCriteria.Items.Add((object) "D");
          this.cboCriteria.Items.Add((object) "E");
          this.cboCriteria.Items.Add((object) "F");
          this.cboCriteria.Items.Add((object) "G");
        }
      }
      else
      {
        this.cboCriteria.Items.Add((object) "Gas");
        this.cboCriteria.Items.Add((object) "LPG");
        this.cboCriteria.Items.Add((object) "Oil");
      }
    }

    private void SearchResults_CellEnter(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex == -1)
        return;
      try
      {
        this.Fill(Conversions.ToString(this.SearchResults["id", e.RowIndex].Value));
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void Fill(string ID)
    {
      try
      {
        if (Conversion.Val(ID) <= 0.0)
          return;
        this.DataInfo[1, 0].Value = (object) ID;
        PCDF.SEDBUK sedbuk = SAP_Module.PCDFData.Boilers.Where<PCDF.SEDBUK>((Func<PCDF.SEDBUK, bool>) (b => b.ID.Equals(ID))).SingleOrDefault<PCDF.SEDBUK>();
        if (sedbuk != null)
        {
          this.DataInfo[1, 0].Value = (object) sedbuk.ID;
          this.DataInfo[1, 1].Value = (object) sedbuk.RefNo;
          this.DataInfo[1, 2].Value = (object) sedbuk.EntryUpdate;
          this.DataInfo[1, 3].Value = (object) sedbuk.CurrManu;
          this.DataInfo[1, 4].Value = (object) sedbuk.BrandName;
          this.DataInfo[1, 5].Value = (object) sedbuk.ModelName;
          this.DataInfo[1, 6].Value = (object) sedbuk.ModelQualifier;
          this.DataInfo[1, 7].Value = (object) sedbuk.BoilerID;
          this.DataInfo[1, 8].Value = (object) sedbuk.FirstManu;
          this.DataInfo[1, 9].Value = (object) sedbuk.FinManu;
          double num1 = Conversion.Val(sedbuk.Fuel);
          if (num1 == 1.0)
            this.DataInfo[1, 10].Value = (object) "Gas";
          else if (num1 == 2.0)
            this.DataInfo[1, 10].Value = (object) "LPG";
          else if (num1 == 4.0)
            this.DataInfo[1, 10].Value = (object) "Oil";
          double num2 = Conversion.Val(sedbuk.MountPosition);
          if (num2 == 0.0)
            this.DataInfo[1, 11].Value = (object) "Unknown";
          else if (num2 == 1.0)
            this.DataInfo[1, 11].Value = (object) "Floor";
          else if (num2 == 2.0)
            this.DataInfo[1, 11].Value = (object) "Wall";
          else if (num2 == 3.0)
            this.DataInfo[1, 11].Value = (object) "Either floor or wall";
          else if (num2 == 4.0)
            this.DataInfo[1, 11].Value = (object) "Back boiler";
          double num3 = Conversion.Val(sedbuk.ExposureRating);
          if (num3 == 1.0)
            this.DataInfo[1, 12].Value = (object) "Unknown";
          else if (num3 == 2.0)
            this.DataInfo[1, 12].Value = (object) "Indoor only";
          else if (num3 == 4.0)
            this.DataInfo[1, 12].Value = (object) "Outdoor";
          double num4 = Conversion.Val(sedbuk.MainType);
          if (num4 == 0.0)
            this.DataInfo[1, 13].Value = (object) "Unknown";
          else if (num4 == 1.0)
            this.DataInfo[1, 13].Value = (object) "Regular";
          else if (num4 == 2.0)
            this.DataInfo[1, 13].Value = (object) "Combi";
          else if (num4 == 3.0)
            this.DataInfo[1, 13].Value = (object) "CPSU";
          double num5 = Conversion.Val(sedbuk.SubType);
          if (num5 == 0.0)
            this.DataInfo[1, 14].Value = (object) "normal";
          else if (num5 == 1.0)
            this.DataInfo[1, 14].Value = (object) "with integral PFGHRD";
          this.DataInfo[1, 15].Value = (object) sedbuk.SubTypeTable;
          this.DataInfo[1, 16].Value = (object) sedbuk.SubTypeIndex;
          double num6 = Conversion.Val(sedbuk.Condensing);
          if (num6 == 0.0)
            this.DataInfo[1, 17].Value = (object) "Unknown";
          else if (num6 == 1.0)
            this.DataInfo[1, 17].Value = (object) "Non-condensing";
          else if (num6 == 2.0)
            this.DataInfo[1, 17].Value = (object) "Condensing";
          double num7 = Conversion.Val(sedbuk.FlueType);
          if (num7 == 0.0)
            this.DataInfo[1, 18].Value = (object) "Unknown";
          else if (num7 == 1.0)
            this.DataInfo[1, 18].Value = (object) "Open";
          else if (num7 == 2.0)
            this.DataInfo[1, 18].Value = (object) "Room-sealed";
          else if (num7 == 3.0)
            this.DataInfo[1, 18].Value = (object) "Open or room-sealed";
          double num8 = Conversion.Val(sedbuk.FanAssist);
          if (num8 == 0.0)
            this.DataInfo[1, 19].Value = (object) "Unknown";
          else if (num8 == 1.0)
            this.DataInfo[1, 19].Value = (object) "No fan";
          else if (num8 == 2.0)
            this.DataInfo[1, 19].Value = (object) "Fan";
          this.DataInfo[1, 20].Value = (object) sedbuk.BoilPowBot;
          this.DataInfo[1, 21].Value = (object) sedbuk.BoilPowTop;
          this.DataInfo[1, 22].Value = (object) sedbuk.EngEffClss;
          this.DataInfo[1, 23].Value = (object) sedbuk.AnnualEff;
          this.DataInfo[1, 24].Value = (object) sedbuk.WinterEff;
          this.DataInfo[1, 25].Value = (object) sedbuk.SummerEff;
          this.DataInfo[1, 26].Value = (object) sedbuk.HotWaterEff;
          this.DataInfo[1, 27].Value = (object) sedbuk.SAPEff;
          double num9 = Conversion.Val(sedbuk.EffCat);
          if (num9 == 0.0)
            this.DataInfo[1, 28].Value = (object) "Unknown";
          else if (num9 == 1.0)
            this.DataInfo[1, 28].Value = (object) "SEDBUK based on validated and certified data";
          else if (num9 == 2.0)
            this.DataInfo[1, 28].Value = (object) "SEDBUK based on certified data";
          else if (num9 == 3.0)
            this.DataInfo[1, 28].Value = (object) "Estimated (for obsolete boilers only)";
          double num10 = Conversion.Val(sedbuk.LPGTstGas);
          this.DataInfo[1, 29].Value = num10 != 0.0 ? (num10 != 1.0 ? (object) "" : (object) "The tests were carried out using natural gas and the modified calculation procedure") : (object) "The efficiency tests from which SEDBUK was calculated were carried out using LPG";
          double num11 = Conversion.Val(sedbuk.LPGTstCorrection);
          this.DataInfo[1, 30].Value = num11 != 0.0 ? (num11 != 1.0 ? (object) "" : (object) "The correction was not applied") : (object) "The correction was not applied to the results on the test certificate";
          this.DataInfo[1, 31].Value = (object) sedbuk.SAPEqUsed;
          double num12 = Conversion.Val(sedbuk.Ignition);
          if (num12 == 0.0)
            this.DataInfo[1, 32].Value = (object) "Unknown";
          else if (num12 == 1.0)
            this.DataInfo[1, 32].Value = (object) "No";
          else if (num12 == 2.0)
            this.DataInfo[1, 32].Value = (object) "Yes";
          double num13 = Conversion.Val(sedbuk.BurnCont);
          if (num13 == 0.0)
            this.DataInfo[1, 33].Value = (object) "Unknown";
          else if (num13 == 1.0)
            this.DataInfo[1, 33].Value = (object) "On-off";
          else if (num13 == 2.0)
            this.DataInfo[1, 33].Value = (object) "variable (stepped or modulating)";
          this.DataInfo[1, 34].Value = (object) sedbuk.ElPowFire;
          this.DataInfo[1, 35].Value = (object) sedbuk.ElPowNtFire;
          double num14 = Conversion.Val(sedbuk.StrType);
          if (num14 == 0.0)
            this.DataInfo[1, 36].Value = (object) "Unknown";
          else if (num14 == 1.0)
            this.DataInfo[1, 36].Value = (object) "A storage combination boiler with Primary Store";
          else if (num14 == 2.0)
            this.DataInfo[1, 36].Value = (object) "A storage combination boiler with Secondary Store";
          else if (num14 == 3.0)
            this.DataInfo[1, 36].Value = (object) "CPSU";
          double num15 = Conversion.Val(sedbuk.StrLoss);
          this.DataInfo[1, 37].Value = num15 != 0.0 ? (num15 != 1.0 ? (num15 != 2.0 ? (object) "" : (object) "Heat loss from the internal hot water store has been included in the efficiency test values reported") : (object) "Heat loss from the internal hot water store has been excluded in the efficiency test values reported") : (object) "Unknown";
          double num16 = Conversion.Val(sedbuk.StrSep);
          this.DataInfo[1, 38].Value = num16 != 1.0 ? (num16 != 2.0 ? (object) "Unknown/Inapplicable" : (object) "Yes") : (object) "Hot water store is within the boiler casing";
          this.DataInfo[1, 39].Value = (object) sedbuk.StrVol;
          this.DataInfo[1, 40].Value = (object) sedbuk.StrSolarVol;
          this.DataInfo[1, 41].Value = (object) sedbuk.StrInsThk;
          double num17 = Conversion.Val(sedbuk.StrInsType);
          this.DataInfo[1, 42].Value = num17 != 1.0 ? (num17 != 2.0 ? (num17 != 3.0 ? (num17 != 4.0 ? (num17 != 5.0 ? (num17 != 6.0 ? (object) "Unknown/Inapplicable" : (object) "Closest to MW (glass)") : (object) "Closest to PU") : (object) "Closest to MW (rock)") : (object) "Mineral wool (glass)") : (object) "Polyurethane foam") : (object) "Mineral wool (rock)";
          this.DataInfo[1, 43].Value = (object) sedbuk.StrTemp;
          this.DataInfo[1, 44].Value = (object) sedbuk.StrHtLoss;
          double num18 = Conversion.Val(sedbuk.SeperateDHWTests);
          if (num18 == 0.0)
            this.DataInfo[1, 45].Value = (object) "none or not applicable";
          else if (num18 == 1.0)
            this.DataInfo[1, 45].Value = (object) "one test, using schedule 2";
          else if (num18 == 2.0)
            this.DataInfo[1, 45].Value = (object) "two tests, using schedules 2 and 3";
          else if (num18 == 3.0)
            this.DataInfo[1, 45].Value = (object) "two tests, using schedules 2 and 1";
          this.DataInfo[1, 46].Value = (object) sedbuk.FuelEnergyT1;
          this.DataInfo[1, 47].Value = (object) sedbuk.ElecEnergyT1;
          this.DataInfo[1, 48].Value = (object) sedbuk.RejEnergy_r1T1;
          this.DataInfo[1, 49].Value = (object) sedbuk.StoLossF1;
          this.DataInfo[1, 50].Value = (object) sedbuk.FuelEnergyT2;
          this.DataInfo[1, 51].Value = (object) sedbuk.ElecEnergyT2;
          this.DataInfo[1, 52].Value = (object) sedbuk.RejEnergy_r2T2;
          this.DataInfo[1, 53].Value = (object) sedbuk.StoLossF2;
          this.DataInfo[1, 54].Value = (object) sedbuk.StoLossF3;
          if (!Information.IsDBNull((object) sedbuk.KpHtFac))
          {
            double num19 = Conversion.Val(sedbuk.KpHtFac);
            this.DataInfo[1, 55].Value = num19 != 0.0 ? (num19 != 1.0 ? (num19 != 2.0 ? (num19 != 3.0 ? (object) "Unknown/Inapplicable" : (object) "A 'keep-hot' facility both fuelled by gas/oil and powered by electricity") : (object) "A 'keep-hot' facility powered by electricity") : (object) "A 'keep-hot' facility fuelled by gas/oil only") : (object) "No 'keep-hot' facility";
          }
          if (!Information.IsDBNull((object) sedbuk.KpHtTmr))
          {
            double num20 = Conversion.Val(sedbuk.KpHtTmr);
            this.DataInfo[1, 56].Value = num20 != 0.0 ? (num20 != 1.0 ? (object) "Unknown/Inapplicable" : (object) "A time-switch control which turns off the facility overnight") : (object) "No such control";
          }
          this.DataInfo[1, 57].Value = (object) sedbuk.KpHtElcHtr;
          this.DataInfo[1, 58].Value = (object) sedbuk.ControlCapabilities;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void SearchResults_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e) => this.CmdNext1_Click(RuntimeHelpers.GetObjectValue(sender), (EventArgs) e);

    public void HideColumns()
    {
      this.SearchResults.Columns[0].Visible = false;
      this.SearchResults.Columns[1].Visible = false;
      this.SearchResults.Columns[2].Visible = false;
      this.SearchResults.Columns[6].Visible = false;
      this.SearchResults.Columns[7].Visible = false;
      this.SearchResults.Columns[8].Visible = false;
      this.SearchResults.Columns[9].Visible = false;
      this.SearchResults.Columns[10].Visible = false;
      this.SearchResults.Columns[11].Visible = false;
      this.SearchResults.Columns[12].Visible = false;
      this.SearchResults.Columns[13].Visible = false;
      this.SearchResults.Columns[14].Visible = false;
      this.SearchResults.Columns[15].Visible = false;
      this.SearchResults.Columns[16].Visible = false;
      this.SearchResults.Columns[17].Visible = false;
      this.SearchResults.Columns[18].Visible = false;
      this.SearchResults.Columns[19].Visible = false;
      this.SearchResults.Columns[20].Visible = false;
      this.SearchResults.Columns[21].Visible = false;
      this.SearchResults.Columns[22].Visible = false;
      this.SearchResults.Columns[23].Visible = false;
      this.SearchResults.Columns[24].Visible = false;
      this.SearchResults.Columns[25].Visible = false;
      this.SearchResults.Columns[26].Visible = false;
      this.SearchResults.Columns[27].Visible = false;
      this.SearchResults.Columns[28].Visible = false;
      this.SearchResults.Columns[29].Visible = false;
      this.SearchResults.Columns[30].Visible = false;
      this.SearchResults.Columns[31].Visible = false;
      this.SearchResults.Columns[32].Visible = false;
      this.SearchResults.Columns[33].Visible = false;
      this.SearchResults.Columns[34].Visible = false;
      this.SearchResults.Columns[35].Visible = false;
      this.SearchResults.Columns[36].Visible = false;
      this.SearchResults.Columns[37].Visible = false;
      this.SearchResults.Columns[38].Visible = false;
      this.SearchResults.Columns[39].Visible = false;
      int num = checked (this.SearchResults.ColumnCount - 1);
      int index = 40;
      while (index <= num)
      {
        this.SearchResults.Columns[index].SortMode = DataGridViewColumnSortMode.Programmatic;
        checked { ++index; }
      }
    }

    private void cmdSearch_Click_1(object sender, EventArgs e)
    {
      PCDF pcdfData;
      List<PCDF.SEDBUK> boilers = (pcdfData = SAP_Module.PCDFData).Boilers;
      List<PCDF.SEDBUK> sedbukList1 = Functions.DeepClone<List<PCDF.SEDBUK>>(ref boilers);
      pcdfData.Boilers = boilers;
      List<PCDF.SEDBUK> sedbukList2 = sedbukList1;
      // ISSUE: variable of a compiler-generated type
      Boiler_Database._Closure\u0024__129\u002D0 closure1290_1;
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      Boiler_Database._Closure\u0024__129\u002D0 closure1290_2 = new Boiler_Database._Closure\u0024__129\u002D0(closure1290_1);
      // ISSUE: reference to a compiler-generated field
      closure1290_2.\u0024VB\u0024Me = this;
      // ISSUE: variable of a compiler-generated type
      Boiler_Database._Closure\u0024__129\u002D0 closure1290_3 = closure1290_2;
      int num1 = checked (this.SearchCriteria.RowCount - 1);
      // ISSUE: reference to a compiler-generated field
      closure1290_3.\u0024VB\u0024Local_i = 0;
      // ISSUE: reference to a compiler-generated field
      while (closure1290_2.\u0024VB\u0024Local_i <= num1)
      {
        // ISSUE: reference to a compiler-generated field
        object Left1 = this.SearchCriteria[0, closure1290_2.\u0024VB\u0024Local_i].Value;
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left1, (object) "Index", false))
        {
          // ISSUE: reference to a compiler-generated method
          sedbukList2 = sedbukList2.Where<PCDF.SEDBUK>(new Func<PCDF.SEDBUK, bool>(closure1290_2._Lambda\u0024__0)).ToList<PCDF.SEDBUK>();
        }
        else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left1, (object) "Manufacturer", false))
        {
          // ISSUE: reference to a compiler-generated method
          sedbukList2 = sedbukList2.Where<PCDF.SEDBUK>(new Func<PCDF.SEDBUK, bool>(closure1290_2._Lambda\u0024__1)).ToList<PCDF.SEDBUK>();
        }
        else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left1, (object) "Brand Name", false))
        {
          // ISSUE: reference to a compiler-generated method
          sedbukList2 = sedbukList2.Where<PCDF.SEDBUK>(new Func<PCDF.SEDBUK, bool>(closure1290_2._Lambda\u0024__2)).ToList<PCDF.SEDBUK>();
        }
        else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left1, (object) "Model Name", false))
        {
          // ISSUE: reference to a compiler-generated method
          sedbukList2 = sedbukList2.Where<PCDF.SEDBUK>(new Func<PCDF.SEDBUK, bool>(closure1290_2._Lambda\u0024__3)).ToList<PCDF.SEDBUK>();
        }
        else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left1, (object) "Model Qualifier", false))
        {
          // ISSUE: reference to a compiler-generated method
          sedbukList2 = sedbukList2.Where<PCDF.SEDBUK>(new Func<PCDF.SEDBUK, bool>(closure1290_2._Lambda\u0024__4)).ToList<PCDF.SEDBUK>();
        }
        else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left1, (object) "Boiler ID", false))
        {
          // ISSUE: reference to a compiler-generated method
          sedbukList2 = sedbukList2.Where<PCDF.SEDBUK>(new Func<PCDF.SEDBUK, bool>(closure1290_2._Lambda\u0024__5)).ToList<PCDF.SEDBUK>();
        }
        else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left1, (object) "Fuel", false))
        {
          // ISSUE: reference to a compiler-generated field
          object Left2 = this.SearchCriteria[1, closure1290_2.\u0024VB\u0024Local_i].Value;
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left2, (object) "Gas", false))
          {
            List<PCDF.SEDBUK> source = sedbukList2;
            Func<PCDF.SEDBUK, bool> predicate;
            // ISSUE: reference to a compiler-generated field
            if (Boiler_Database._Closure\u0024__.\u0024I129\u002D6 != null)
            {
              // ISSUE: reference to a compiler-generated field
              predicate = Boiler_Database._Closure\u0024__.\u0024I129\u002D6;
            }
            else
            {
              // ISSUE: reference to a compiler-generated field
              Boiler_Database._Closure\u0024__.\u0024I129\u002D6 = predicate = (Func<PCDF.SEDBUK, bool>) (b => b.Fuel.Equals("1"));
            }
            sedbukList2 = source.Where<PCDF.SEDBUK>(predicate).ToList<PCDF.SEDBUK>();
          }
          else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left2, (object) "LPG", false))
          {
            List<PCDF.SEDBUK> source = sedbukList2;
            Func<PCDF.SEDBUK, bool> predicate;
            // ISSUE: reference to a compiler-generated field
            if (Boiler_Database._Closure\u0024__.\u0024I129\u002D7 != null)
            {
              // ISSUE: reference to a compiler-generated field
              predicate = Boiler_Database._Closure\u0024__.\u0024I129\u002D7;
            }
            else
            {
              // ISSUE: reference to a compiler-generated field
              Boiler_Database._Closure\u0024__.\u0024I129\u002D7 = predicate = (Func<PCDF.SEDBUK, bool>) (b => b.Fuel.Equals("2"));
            }
            sedbukList2 = source.Where<PCDF.SEDBUK>(predicate).ToList<PCDF.SEDBUK>();
          }
          else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left2, (object) "Oil", false))
          {
            List<PCDF.SEDBUK> source = sedbukList2;
            Func<PCDF.SEDBUK, bool> predicate;
            // ISSUE: reference to a compiler-generated field
            if (Boiler_Database._Closure\u0024__.\u0024I129\u002D8 != null)
            {
              // ISSUE: reference to a compiler-generated field
              predicate = Boiler_Database._Closure\u0024__.\u0024I129\u002D8;
            }
            else
            {
              // ISSUE: reference to a compiler-generated field
              Boiler_Database._Closure\u0024__.\u0024I129\u002D8 = predicate = (Func<PCDF.SEDBUK, bool>) (b => b.Fuel.Equals("4"));
            }
            sedbukList2 = source.Where<PCDF.SEDBUK>(predicate).ToList<PCDF.SEDBUK>();
          }
        }
        else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left1, (object) "Band", false))
        {
          // ISSUE: reference to a compiler-generated field
          object Left3 = this.SearchCriteria[1, closure1290_2.\u0024VB\u0024Local_i].Value;
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left3, (object) "A", false))
          {
            List<PCDF.SEDBUK> source = sedbukList2;
            Func<PCDF.SEDBUK, bool> predicate;
            // ISSUE: reference to a compiler-generated field
            if (Boiler_Database._Closure\u0024__.\u0024I129\u002D9 != null)
            {
              // ISSUE: reference to a compiler-generated field
              predicate = Boiler_Database._Closure\u0024__.\u0024I129\u002D9;
            }
            else
            {
              // ISSUE: reference to a compiler-generated field
              Boiler_Database._Closure\u0024__.\u0024I129\u002D9 = predicate = (Func<PCDF.SEDBUK, bool>) (b => Conversion.Val(b.SAPEff) >= 92.0);
            }
            sedbukList2 = source.Where<PCDF.SEDBUK>(predicate).ToList<PCDF.SEDBUK>();
          }
          else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left3, (object) "B", false))
          {
            List<PCDF.SEDBUK> source = sedbukList2;
            Func<PCDF.SEDBUK, bool> predicate;
            // ISSUE: reference to a compiler-generated field
            if (Boiler_Database._Closure\u0024__.\u0024I129\u002D10 != null)
            {
              // ISSUE: reference to a compiler-generated field
              predicate = Boiler_Database._Closure\u0024__.\u0024I129\u002D10;
            }
            else
            {
              // ISSUE: reference to a compiler-generated field
              Boiler_Database._Closure\u0024__.\u0024I129\u002D10 = predicate = (Func<PCDF.SEDBUK, bool>) (b => Conversion.Val(b.SAPEff) >= 92.0);
            }
            sedbukList2 = source.Where<PCDF.SEDBUK>(predicate).ToList<PCDF.SEDBUK>();
          }
          else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left3, (object) "C", false))
          {
            List<PCDF.SEDBUK> source = sedbukList2;
            Func<PCDF.SEDBUK, bool> predicate;
            // ISSUE: reference to a compiler-generated field
            if (Boiler_Database._Closure\u0024__.\u0024I129\u002D11 != null)
            {
              // ISSUE: reference to a compiler-generated field
              predicate = Boiler_Database._Closure\u0024__.\u0024I129\u002D11;
            }
            else
            {
              // ISSUE: reference to a compiler-generated field
              Boiler_Database._Closure\u0024__.\u0024I129\u002D11 = predicate = (Func<PCDF.SEDBUK, bool>) (b => Conversion.Val(b.SAPEff) >= 92.0);
            }
            sedbukList2 = source.Where<PCDF.SEDBUK>(predicate).ToList<PCDF.SEDBUK>();
          }
          else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left3, (object) "D", false))
          {
            List<PCDF.SEDBUK> source = sedbukList2;
            Func<PCDF.SEDBUK, bool> predicate;
            // ISSUE: reference to a compiler-generated field
            if (Boiler_Database._Closure\u0024__.\u0024I129\u002D12 != null)
            {
              // ISSUE: reference to a compiler-generated field
              predicate = Boiler_Database._Closure\u0024__.\u0024I129\u002D12;
            }
            else
            {
              // ISSUE: reference to a compiler-generated field
              Boiler_Database._Closure\u0024__.\u0024I129\u002D12 = predicate = (Func<PCDF.SEDBUK, bool>) (b => Conversion.Val(b.SAPEff) >= 92.0);
            }
            sedbukList2 = source.Where<PCDF.SEDBUK>(predicate).ToList<PCDF.SEDBUK>();
          }
          else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left3, (object) "E", false))
          {
            List<PCDF.SEDBUK> source = sedbukList2;
            Func<PCDF.SEDBUK, bool> predicate;
            // ISSUE: reference to a compiler-generated field
            if (Boiler_Database._Closure\u0024__.\u0024I129\u002D13 != null)
            {
              // ISSUE: reference to a compiler-generated field
              predicate = Boiler_Database._Closure\u0024__.\u0024I129\u002D13;
            }
            else
            {
              // ISSUE: reference to a compiler-generated field
              Boiler_Database._Closure\u0024__.\u0024I129\u002D13 = predicate = (Func<PCDF.SEDBUK, bool>) (b => Conversion.Val(b.SAPEff) >= 92.0);
            }
            sedbukList2 = source.Where<PCDF.SEDBUK>(predicate).ToList<PCDF.SEDBUK>();
          }
          else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left3, (object) "F", false))
          {
            List<PCDF.SEDBUK> source = sedbukList2;
            Func<PCDF.SEDBUK, bool> predicate;
            // ISSUE: reference to a compiler-generated field
            if (Boiler_Database._Closure\u0024__.\u0024I129\u002D14 != null)
            {
              // ISSUE: reference to a compiler-generated field
              predicate = Boiler_Database._Closure\u0024__.\u0024I129\u002D14;
            }
            else
            {
              // ISSUE: reference to a compiler-generated field
              Boiler_Database._Closure\u0024__.\u0024I129\u002D14 = predicate = (Func<PCDF.SEDBUK, bool>) (b => Conversion.Val(b.SAPEff) >= 92.0);
            }
            sedbukList2 = source.Where<PCDF.SEDBUK>(predicate).ToList<PCDF.SEDBUK>();
          }
          else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left3, (object) "G", false))
          {
            List<PCDF.SEDBUK> source = sedbukList2;
            Func<PCDF.SEDBUK, bool> predicate;
            // ISSUE: reference to a compiler-generated field
            if (Boiler_Database._Closure\u0024__.\u0024I129\u002D15 != null)
            {
              // ISSUE: reference to a compiler-generated field
              predicate = Boiler_Database._Closure\u0024__.\u0024I129\u002D15;
            }
            else
            {
              // ISSUE: reference to a compiler-generated field
              Boiler_Database._Closure\u0024__.\u0024I129\u002D15 = predicate = (Func<PCDF.SEDBUK, bool>) (b => Conversion.Val(b.SAPEff) >= 92.0);
            }
            sedbukList2 = source.Where<PCDF.SEDBUK>(predicate).ToList<PCDF.SEDBUK>();
          }
        }
        else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left1, (object) "Condensing", false))
        {
          // ISSUE: reference to a compiler-generated field
          object Left4 = this.SearchCriteria[1, closure1290_2.\u0024VB\u0024Local_i].Value;
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left4, (object) "Non-condensing", false))
          {
            List<PCDF.SEDBUK> source = sedbukList2;
            Func<PCDF.SEDBUK, bool> predicate;
            // ISSUE: reference to a compiler-generated field
            if (Boiler_Database._Closure\u0024__.\u0024I129\u002D16 != null)
            {
              // ISSUE: reference to a compiler-generated field
              predicate = Boiler_Database._Closure\u0024__.\u0024I129\u002D16;
            }
            else
            {
              // ISSUE: reference to a compiler-generated field
              Boiler_Database._Closure\u0024__.\u0024I129\u002D16 = predicate = (Func<PCDF.SEDBUK, bool>) (b => b.Condensing.Equals("0"));
            }
            sedbukList2 = source.Where<PCDF.SEDBUK>(predicate).ToList<PCDF.SEDBUK>();
          }
          else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left4, (object) "Condensing", false))
          {
            List<PCDF.SEDBUK> source = sedbukList2;
            Func<PCDF.SEDBUK, bool> predicate;
            // ISSUE: reference to a compiler-generated field
            if (Boiler_Database._Closure\u0024__.\u0024I129\u002D17 != null)
            {
              // ISSUE: reference to a compiler-generated field
              predicate = Boiler_Database._Closure\u0024__.\u0024I129\u002D17;
            }
            else
            {
              // ISSUE: reference to a compiler-generated field
              Boiler_Database._Closure\u0024__.\u0024I129\u002D17 = predicate = (Func<PCDF.SEDBUK, bool>) (b => b.Condensing.Equals("1"));
            }
            sedbukList2 = source.Where<PCDF.SEDBUK>(predicate).ToList<PCDF.SEDBUK>();
          }
        }
        else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left1, (object) "Flue", false))
        {
          // ISSUE: reference to a compiler-generated field
          object Left5 = this.SearchCriteria[1, closure1290_2.\u0024VB\u0024Local_i].Value;
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left5, (object) "Open", false))
          {
            List<PCDF.SEDBUK> source = sedbukList2;
            Func<PCDF.SEDBUK, bool> predicate;
            // ISSUE: reference to a compiler-generated field
            if (Boiler_Database._Closure\u0024__.\u0024I129\u002D18 != null)
            {
              // ISSUE: reference to a compiler-generated field
              predicate = Boiler_Database._Closure\u0024__.\u0024I129\u002D18;
            }
            else
            {
              // ISSUE: reference to a compiler-generated field
              Boiler_Database._Closure\u0024__.\u0024I129\u002D18 = predicate = (Func<PCDF.SEDBUK, bool>) (b => b.FlueType.Equals("1"));
            }
            sedbukList2 = source.Where<PCDF.SEDBUK>(predicate).ToList<PCDF.SEDBUK>();
          }
          else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left5, (object) "Room-sealed", false))
          {
            List<PCDF.SEDBUK> source = sedbukList2;
            Func<PCDF.SEDBUK, bool> predicate;
            // ISSUE: reference to a compiler-generated field
            if (Boiler_Database._Closure\u0024__.\u0024I129\u002D19 != null)
            {
              // ISSUE: reference to a compiler-generated field
              predicate = Boiler_Database._Closure\u0024__.\u0024I129\u002D19;
            }
            else
            {
              // ISSUE: reference to a compiler-generated field
              Boiler_Database._Closure\u0024__.\u0024I129\u002D19 = predicate = (Func<PCDF.SEDBUK, bool>) (b => b.FlueType.Equals("2"));
            }
            sedbukList2 = source.Where<PCDF.SEDBUK>(predicate).ToList<PCDF.SEDBUK>();
          }
        }
        else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left1, (object) "Mounting", false))
        {
          // ISSUE: reference to a compiler-generated field
          object Left6 = this.SearchCriteria[1, closure1290_2.\u0024VB\u0024Local_i].Value;
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left6, (object) "Floor", false))
          {
            List<PCDF.SEDBUK> source = sedbukList2;
            Func<PCDF.SEDBUK, bool> predicate;
            // ISSUE: reference to a compiler-generated field
            if (Boiler_Database._Closure\u0024__.\u0024I129\u002D20 != null)
            {
              // ISSUE: reference to a compiler-generated field
              predicate = Boiler_Database._Closure\u0024__.\u0024I129\u002D20;
            }
            else
            {
              // ISSUE: reference to a compiler-generated field
              Boiler_Database._Closure\u0024__.\u0024I129\u002D20 = predicate = (Func<PCDF.SEDBUK, bool>) (b => b.MountPosition.Equals("1"));
            }
            sedbukList2 = source.Where<PCDF.SEDBUK>(predicate).ToList<PCDF.SEDBUK>();
          }
          else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left6, (object) "Wall", false))
          {
            List<PCDF.SEDBUK> source = sedbukList2;
            Func<PCDF.SEDBUK, bool> predicate;
            // ISSUE: reference to a compiler-generated field
            if (Boiler_Database._Closure\u0024__.\u0024I129\u002D21 != null)
            {
              // ISSUE: reference to a compiler-generated field
              predicate = Boiler_Database._Closure\u0024__.\u0024I129\u002D21;
            }
            else
            {
              // ISSUE: reference to a compiler-generated field
              Boiler_Database._Closure\u0024__.\u0024I129\u002D21 = predicate = (Func<PCDF.SEDBUK, bool>) (b => b.MountPosition.Equals("2"));
            }
            sedbukList2 = source.Where<PCDF.SEDBUK>(predicate).ToList<PCDF.SEDBUK>();
          }
          else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left6, (object) "Back boiler", false))
          {
            List<PCDF.SEDBUK> source = sedbukList2;
            Func<PCDF.SEDBUK, bool> predicate;
            // ISSUE: reference to a compiler-generated field
            if (Boiler_Database._Closure\u0024__.\u0024I129\u002D22 != null)
            {
              // ISSUE: reference to a compiler-generated field
              predicate = Boiler_Database._Closure\u0024__.\u0024I129\u002D22;
            }
            else
            {
              // ISSUE: reference to a compiler-generated field
              Boiler_Database._Closure\u0024__.\u0024I129\u002D22 = predicate = (Func<PCDF.SEDBUK, bool>) (b => b.MountPosition.Equals("4"));
            }
            sedbukList2 = source.Where<PCDF.SEDBUK>(predicate).ToList<PCDF.SEDBUK>();
          }
        }
        // ISSUE: reference to a compiler-generated field
        checked { ++closure1290_2.\u0024VB\u0024Local_i; }
      }
      try
      {
        int num2 = checked (sedbukList2.Count - 1);
        int index = 0;
        while (index <= num2)
        {
          double num3 = Conversion.Val(sedbukList2[index].ProductType);
          if (num3 == 0.0)
            sedbukList2[index].ProductType = "normal";
          else if (num3 == 1.0)
            sedbukList2[index].ProductType = "illustrative";
          else if (num3 == 2.0)
            sedbukList2[index].ProductType = "under investigation";
          else if (num3 == 3.0)
            sedbukList2[index].ProductType = "not valid";
          else if (num3 == 4.0)
            sedbukList2[index].ProductType = "The SAP Gas and Oil Boiler methodology is currently being reviewed. This entry may change.";
          checked { ++index; }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      this.SearchResults.DataSource = (object) Validation.ListToDataTable<PCDF.SEDBUK>(sedbukList2);
      this.Label1.Text = "Currently Showing " + Conversions.ToString(this.SearchResults.RowCount) + " out of " + Conversions.ToString(SAP_Module.PCDFData.Boilers.Count);
    }

    private void CmdNext1_Click(object sender, EventArgs e)
    {
      if (this.Type == 1)
      {
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SEDBUK = Conversions.ToString(this.SearchResults["id", this.SearchResults.CurrentRow.Index].Value);
        SAP_Read.CheckSEDBUK();
      }
      else
      {
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SEDBUK = Conversions.ToString(this.SearchResults["id", this.SearchResults.CurrentRow.Index].Value);
        SAP_Read.CheckSEDBUK2();
      }
      try
      {
        if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(MyProject.Forms.SAPForm.txtMainFuel.Text, "", false) <= 0U)
          return;
        WaterHeating.PaniCheck(1, MyProject.Forms.SAPForm.txtMainFuel.Text, SAP_Module.CurrDwelling);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void cmdadd_Click(object sender, EventArgs e)
    {
      this.SearchCriteria.Rows.Add();
      this.SearchCriteria[0, checked (this.SearchCriteria.RowCount - 1)].Value = (object) this.txtPrimary.Text;
      if (this.cboCriteria.Enabled)
        this.SearchCriteria[1, checked (this.SearchCriteria.RowCount - 1)].Value = (object) this.cboCriteria.Text;
      else
        this.SearchCriteria[1, checked (this.SearchCriteria.RowCount - 1)].Value = (object) this.txtCriteria.Text;
    }

    private void cmdCancel_Click(object sender, EventArgs e)
    {
    }

    private void cmdClear_Click_1(object sender, EventArgs e)
    {
      this.SearchCriteria.Rows.Clear();
      this.NewTable = new DataTable();
      PCDF pcdfData;
      List<PCDF.SEDBUK> boilers = (pcdfData = SAP_Module.PCDFData).Boilers;
      List<PCDF.SEDBUK> items = Functions.DeepClone<List<PCDF.SEDBUK>>(ref boilers);
      pcdfData.Boilers = boilers;
      this.NewTable = Validation.ListToDataTable<PCDF.SEDBUK>(items);
      int num1 = checked (this.NewTable.Rows.Count - 1);
      int index = 0;
      while (index <= num1)
      {
        double num2 = Conversion.Val(RuntimeHelpers.GetObjectValue(this.NewTable.Rows[index]["producttype"]));
        if (num2 == 0.0)
          this.NewTable.Rows[index]["producttype"] = (object) "normal";
        else if (num2 == 1.0)
          this.NewTable.Rows[index]["producttype"] = (object) "illustrative";
        else if (num2 == 2.0)
          this.NewTable.Rows[index]["producttype"] = (object) "under investigation";
        else if (num2 == 3.0)
          this.NewTable.Rows[index]["producttype"] = (object) "not valid";
        else if (num2 == 4.0)
          this.NewTable.Rows[index]["producttype"] = (object) "The SAP Gas and Oil Boiler methodology is currently being reviewed. This entry may change.";
        checked { ++index; }
      }
      this.SearchResults.DataSource = (object) this.NewTable;
      this.SearchResults.Refresh();
      this.Label1.Text = "Currently Showing " + Conversions.ToString(this.SearchResults.RowCount) + " out of " + Conversions.ToString(SAP_Module.PCDFData.Boilers.Count);
    }

    private void cmdShow_Click(object sender, EventArgs e)
    {
      if (this.SplitContainer1.Panel2Collapsed)
      {
        this.SplitContainer1.Panel2Collapsed = false;
        this.cmdShow.Text = "Hide Details >>";
      }
      else
      {
        this.SplitContainer1.Panel2Collapsed = true;
        this.cmdShow.Text = "<< Show Details";
      }
    }

    private void cmdSimpleSearch_Click(object sender, EventArgs e)
    {
      DataTable dataTable = new DataTable();
      PCDF pcdfData;
      List<PCDF.SEDBUK> boilers = (pcdfData = SAP_Module.PCDFData).Boilers;
      List<PCDF.SEDBUK> sedbukList1 = Functions.DeepClone<List<PCDF.SEDBUK>>(ref boilers);
      pcdfData.Boilers = boilers;
      List<PCDF.SEDBUK> sedbukList2 = sedbukList1;
      string[] strArray = this.txtSearch.Text.Split(' ');
      int num1 = Information.UBound((Array) strArray);
      int index1 = 0;
      while (index1 <= num1)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        Boiler_Database._Closure\u0024__135\u002D0 closure1350 = new Boiler_Database._Closure\u0024__135\u002D0(closure1350);
        // ISSUE: reference to a compiler-generated field
        closure1350.\u0024VB\u0024Local_searchString = strArray[index1];
        // ISSUE: reference to a compiler-generated method
        sedbukList2 = sedbukList2.Where<PCDF.SEDBUK>(new Func<PCDF.SEDBUK, bool>(closure1350._Lambda\u0024__0)).ToList<PCDF.SEDBUK>();
        checked { ++index1; }
      }
      try
      {
        int num2 = checked (sedbukList2.Count - 1);
        int index2 = 0;
        while (index2 <= num2)
        {
          string productType = sedbukList2[index2].ProductType;
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(productType, "0", false) == 0)
            sedbukList2[index2].ProductType = "normal";
          else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(productType, "1", false) == 0)
            sedbukList2[index2].ProductType = "illustrative";
          else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(productType, "2", false) == 0)
            sedbukList2[index2].ProductType = "under investigation";
          else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(productType, "3", false) == 0)
            sedbukList2[index2].ProductType = "not valid";
          else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(productType, Conversions.ToString(4), false) == 0)
            sedbukList2[index2].ProductType = "The SAP Gas and Oil Boiler methodology is currently being reviewed. This entry may change.";
          checked { ++index2; }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      this.SearchResults.DataSource = (object) Validation.ListToDataTable<PCDF.SEDBUK>(sedbukList2);
      this.Label1.Text = "Currently Showing " + Conversions.ToString(this.SearchResults.RowCount) + " out of " + Conversions.ToString(SAP_Module.PCDFData.Boilers.Count);
    }

    private void txtSearch_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return)
        return;
      this.cmdSimpleSearch_Click(RuntimeHelpers.GetObjectValue(sender), (EventArgs) e);
    }

    private void txtSearch_TextChanged(object sender, EventArgs e) => this.cmdSimpleSearch_Click(RuntimeHelpers.GetObjectValue(sender), e);
  }
}
