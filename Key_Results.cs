
// Type: SAP2012.Key_Results




using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
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
  public class Key_Results : Form
  {
    private IContainer components;
    private DataTable dtResults;
    private DataTable dtResultsFinal;
    private DataTable dtResultsSAP;
    private DataTable dtResultsFinalSAP;
    private DataTable dtResultsDER;
    private DataTable dtResultsFinalDER;
    private DataTable dtResultsTER;
    private DataTable dtResultsFinalTER;
    private DataTable dtResultscost;
    private DataTable dtResultsFinalCost;

    public Key_Results()
    {
      this.Load += new EventHandler(this.Key_Results_Load);
      this.dtResults = new DataTable();
      this.dtResultsFinal = new DataTable();
      this.dtResultsSAP = new DataTable();
      this.dtResultsFinalSAP = new DataTable();
      this.dtResultsDER = new DataTable();
      this.dtResultsFinalDER = new DataTable();
      this.dtResultsTER = new DataTable();
      this.dtResultsFinalTER = new DataTable();
      this.dtResultscost = new DataTable();
      this.dtResultsFinalCost = new DataTable();
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
      DataGridViewCellStyle gridViewCellStyle1 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle2 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle3 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle4 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle5 = new DataGridViewCellStyle();
      this.Panel1 = new Panel();
      this.Panel5 = new Panel();
      this.lstItems = new CheckedListBox();
      this.Label1 = new Label();
      this.Panel4 = new Panel();
      this.cmdexcel = new Button();
      this.CmExport = new ContextMenuStrip(this.components);
      this.SAPExcelExportToolStripMenuItem = new ToolStripMenuItem();
      this.DERExcelExportToolStripMenuItem = new ToolStripMenuItem();
      this.TERExcelExportToolStripMenuItem = new ToolStripMenuItem();
      this.EPCCostExcelExportToolStripMenuItem = new ToolStripMenuItem();
      this.Button2 = new Button();
      this.TabControl1 = new TabControl();
      this.TabPage1 = new TabPage();
      this.dgvResults = new DataGridView();
      this.TabPage2 = new TabPage();
      this.dgvResultsSAP = new DataGridView();
      this.TabPage3 = new TabPage();
      this.dgvResultsDER = new DataGridView();
      this.TabPage4 = new TabPage();
      this.dgvResultsTER = new DataGridView();
      this.TabPage5 = new TabPage();
      this.dgvResultsCost = new DataGridView();
      this.ToolTip1 = new ToolTip(this.components);
      this.Panel1.SuspendLayout();
      this.Panel5.SuspendLayout();
      this.Panel4.SuspendLayout();
      this.CmExport.SuspendLayout();
      this.TabControl1.SuspendLayout();
      this.TabPage1.SuspendLayout();
      ((ISupportInitialize) this.dgvResults).BeginInit();
      this.TabPage2.SuspendLayout();
      ((ISupportInitialize) this.dgvResultsSAP).BeginInit();
      this.TabPage3.SuspendLayout();
      ((ISupportInitialize) this.dgvResultsDER).BeginInit();
      this.TabPage4.SuspendLayout();
      ((ISupportInitialize) this.dgvResultsTER).BeginInit();
      this.TabPage5.SuspendLayout();
      ((ISupportInitialize) this.dgvResultsCost).BeginInit();
      this.SuspendLayout();
      this.Panel1.BackColor = Color.White;
      this.Panel1.Controls.Add((Control) this.Panel5);
      this.Panel1.Controls.Add((Control) this.Panel4);
      this.Panel1.Dock = DockStyle.Left;
      this.Panel1.Location = new Point(0, 0);
      this.Panel1.Name = "Panel1";
      this.Panel1.Size = new Size(208, 684);
      this.Panel1.TabIndex = 0;
      this.Panel5.BackColor = Color.LightSlateGray;
      this.Panel5.Controls.Add((Control) this.lstItems);
      this.Panel5.Controls.Add((Control) this.Label1);
      this.Panel5.Dock = DockStyle.Fill;
      this.Panel5.Location = new Point(0, 0);
      this.Panel5.Name = "Panel5";
      this.Panel5.Padding = new Padding(10, 0, 10, 10);
      this.Panel5.Size = new Size(208, 616);
      this.Panel5.TabIndex = 9;
      this.lstItems.CheckOnClick = true;
      this.lstItems.Cursor = Cursors.Hand;
      this.lstItems.Dock = DockStyle.Fill;
      this.lstItems.FormattingEnabled = true;
      this.lstItems.Location = new Point(10, 29);
      this.lstItems.Name = "lstItems";
      this.lstItems.Size = new Size(188, 577);
      this.lstItems.TabIndex = 0;
      this.Label1.BackColor = Color.LightSlateGray;
      this.Label1.Dock = DockStyle.Top;
      this.Label1.ForeColor = Color.White;
      this.Label1.Location = new Point(10, 0);
      this.Label1.Name = "Label1";
      this.Label1.Padding = new Padding(0, 7, 0, 0);
      this.Label1.Size = new Size(188, 29);
      this.Label1.TabIndex = 1;
      this.Label1.Text = "Select Columns to Display";
      this.Label1.TextAlign = ContentAlignment.TopCenter;
      this.Panel4.Controls.Add((Control) this.cmdexcel);
      this.Panel4.Controls.Add((Control) this.Button2);
      this.Panel4.Dock = DockStyle.Bottom;
      this.Panel4.Location = new Point(0, 616);
      this.Panel4.Name = "Panel4";
      this.Panel4.Size = new Size(208, 68);
      this.Panel4.TabIndex = 8;
      this.cmdexcel.BackColor = Color.LightSlateGray;
      this.cmdexcel.ContextMenuStrip = this.CmExport;
      this.cmdexcel.Cursor = Cursors.Hand;
      this.cmdexcel.FlatStyle = FlatStyle.Popup;
      this.cmdexcel.ForeColor = Color.White;
      this.cmdexcel.Location = new Point(12, 6);
      this.cmdexcel.Name = "cmdexcel";
      this.cmdexcel.Size = new Size(190, 23);
      this.cmdexcel.TabIndex = 4;
      this.cmdexcel.Tag = (object) "";
      this.cmdexcel.Text = "Export to Excel";
      this.ToolTip1.SetToolTip((Control) this.cmdexcel, "Right click to see more options to create different reports.");
      this.cmdexcel.UseVisualStyleBackColor = false;
      this.CmExport.Items.AddRange(new ToolStripItem[4]
      {
        (ToolStripItem) this.SAPExcelExportToolStripMenuItem,
        (ToolStripItem) this.DERExcelExportToolStripMenuItem,
        (ToolStripItem) this.TERExcelExportToolStripMenuItem,
        (ToolStripItem) this.EPCCostExcelExportToolStripMenuItem
      });
      this.CmExport.Name = "CmExport";
      this.CmExport.Size = new Size(188, 92);
      this.CmExport.Text = "Export Options";
      this.SAPExcelExportToolStripMenuItem.Image = (Image) SAP2012.My.Resources.Resources.xls_open_file_format;
      this.SAPExcelExportToolStripMenuItem.Name = "SAPExcelExportToolStripMenuItem";
      this.SAPExcelExportToolStripMenuItem.Size = new Size(187, 22);
      this.SAPExcelExportToolStripMenuItem.Text = "SAP Excel Export";
      this.DERExcelExportToolStripMenuItem.Image = (Image) SAP2012.My.Resources.Resources.xls_open_file_format;
      this.DERExcelExportToolStripMenuItem.Name = "DERExcelExportToolStripMenuItem";
      this.DERExcelExportToolStripMenuItem.Size = new Size(187, 22);
      this.DERExcelExportToolStripMenuItem.Text = "DER Excel Export";
      this.TERExcelExportToolStripMenuItem.Image = (Image) SAP2012.My.Resources.Resources.xls_open_file_format;
      this.TERExcelExportToolStripMenuItem.Name = "TERExcelExportToolStripMenuItem";
      this.TERExcelExportToolStripMenuItem.Size = new Size(187, 22);
      this.TERExcelExportToolStripMenuItem.Text = "TER Excel Export";
      this.EPCCostExcelExportToolStripMenuItem.Image = (Image) SAP2012.My.Resources.Resources.xls_open_file_format;
      this.EPCCostExcelExportToolStripMenuItem.Name = "EPCCostExcelExportToolStripMenuItem";
      this.EPCCostExcelExportToolStripMenuItem.Size = new Size(187, 22);
      this.EPCCostExcelExportToolStripMenuItem.Text = "EPC Cost Excel Export";
      this.Button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      this.Button2.BackColor = Color.LightSlateGray;
      this.Button2.Cursor = Cursors.Hand;
      this.Button2.DialogResult = DialogResult.OK;
      this.Button2.FlatStyle = FlatStyle.Popup;
      this.Button2.ForeColor = Color.White;
      this.Button2.Location = new Point(12, 34);
      this.Button2.Name = "Button2";
      this.Button2.Size = new Size(190, 23);
      this.Button2.TabIndex = 6;
      this.Button2.Text = "Exit";
      this.Button2.UseVisualStyleBackColor = false;
      this.TabControl1.Controls.Add((Control) this.TabPage1);
      this.TabControl1.Controls.Add((Control) this.TabPage2);
      this.TabControl1.Controls.Add((Control) this.TabPage3);
      this.TabControl1.Controls.Add((Control) this.TabPage4);
      this.TabControl1.Controls.Add((Control) this.TabPage5);
      this.TabControl1.Dock = DockStyle.Fill;
      this.TabControl1.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.TabControl1.Location = new Point(208, 0);
      this.TabControl1.Name = "TabControl1";
      this.TabControl1.SelectedIndex = 0;
      this.TabControl1.Size = new Size(762, 684);
      this.TabControl1.TabIndex = 3;
      this.TabPage1.Controls.Add((Control) this.dgvResults);
      this.TabPage1.Location = new Point(4, 23);
      this.TabPage1.Name = "TabPage1";
      this.TabPage1.Padding = new Padding(3);
      this.TabPage1.Size = new Size(754, 657);
      this.TabPage1.TabIndex = 0;
      this.TabPage1.Text = "All";
      this.TabPage1.UseVisualStyleBackColor = true;
      gridViewCellStyle1.BackColor = Color.LightGreen;
      this.dgvResults.AlternatingRowsDefaultCellStyle = gridViewCellStyle1;
      this.dgvResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvResults.Cursor = Cursors.Hand;
      this.dgvResults.Dock = DockStyle.Fill;
      this.dgvResults.Location = new Point(3, 3);
      this.dgvResults.Name = "dgvResults";
      this.dgvResults.Size = new Size(748, 651);
      this.dgvResults.TabIndex = 4;
      this.TabPage2.Controls.Add((Control) this.dgvResultsSAP);
      this.TabPage2.Location = new Point(4, 23);
      this.TabPage2.Name = "TabPage2";
      this.TabPage2.Padding = new Padding(3);
      this.TabPage2.Size = new Size(754, 657);
      this.TabPage2.TabIndex = 1;
      this.TabPage2.Text = "SAP";
      this.TabPage2.UseVisualStyleBackColor = true;
      gridViewCellStyle2.BackColor = Color.LightGreen;
      this.dgvResultsSAP.AlternatingRowsDefaultCellStyle = gridViewCellStyle2;
      this.dgvResultsSAP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvResultsSAP.Dock = DockStyle.Fill;
      this.dgvResultsSAP.Location = new Point(3, 3);
      this.dgvResultsSAP.Name = "dgvResultsSAP";
      this.dgvResultsSAP.Size = new Size(748, 651);
      this.dgvResultsSAP.TabIndex = 3;
      this.TabPage3.Controls.Add((Control) this.dgvResultsDER);
      this.TabPage3.Location = new Point(4, 23);
      this.TabPage3.Name = "TabPage3";
      this.TabPage3.Size = new Size(754, 657);
      this.TabPage3.TabIndex = 2;
      this.TabPage3.Text = "DER";
      this.TabPage3.UseVisualStyleBackColor = true;
      gridViewCellStyle3.BackColor = Color.LightGreen;
      this.dgvResultsDER.AlternatingRowsDefaultCellStyle = gridViewCellStyle3;
      this.dgvResultsDER.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvResultsDER.Dock = DockStyle.Fill;
      this.dgvResultsDER.Location = new Point(0, 0);
      this.dgvResultsDER.Name = "dgvResultsDER";
      this.dgvResultsDER.Size = new Size(754, 657);
      this.dgvResultsDER.TabIndex = 4;
      this.TabPage4.Controls.Add((Control) this.dgvResultsTER);
      this.TabPage4.Location = new Point(4, 23);
      this.TabPage4.Name = "TabPage4";
      this.TabPage4.Size = new Size(754, 657);
      this.TabPage4.TabIndex = 3;
      this.TabPage4.Text = "TER";
      this.TabPage4.UseVisualStyleBackColor = true;
      gridViewCellStyle4.BackColor = Color.LightGreen;
      this.dgvResultsTER.AlternatingRowsDefaultCellStyle = gridViewCellStyle4;
      this.dgvResultsTER.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvResultsTER.Dock = DockStyle.Fill;
      this.dgvResultsTER.Location = new Point(0, 0);
      this.dgvResultsTER.Name = "dgvResultsTER";
      this.dgvResultsTER.Size = new Size(754, 657);
      this.dgvResultsTER.TabIndex = 4;
      this.TabPage5.Controls.Add((Control) this.dgvResultsCost);
      this.TabPage5.Location = new Point(4, 23);
      this.TabPage5.Name = "TabPage5";
      this.TabPage5.Padding = new Padding(3);
      this.TabPage5.Size = new Size(754, 657);
      this.TabPage5.TabIndex = 4;
      this.TabPage5.Text = "EPC Cost";
      this.TabPage5.UseVisualStyleBackColor = true;
      gridViewCellStyle5.BackColor = Color.LightGreen;
      this.dgvResultsCost.AlternatingRowsDefaultCellStyle = gridViewCellStyle5;
      this.dgvResultsCost.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvResultsCost.Dock = DockStyle.Fill;
      this.dgvResultsCost.Location = new Point(3, 3);
      this.dgvResultsCost.Name = "dgvResultsCost";
      this.dgvResultsCost.Size = new Size(748, 651);
      this.dgvResultsCost.TabIndex = 5;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(970, 684);
      this.Controls.Add((Control) this.TabControl1);
      this.Controls.Add((Control) this.Panel1);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.Name = nameof (Key_Results);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Key Results";
      this.Panel1.ResumeLayout(false);
      this.Panel5.ResumeLayout(false);
      this.Panel4.ResumeLayout(false);
      this.CmExport.ResumeLayout(false);
      this.TabControl1.ResumeLayout(false);
      this.TabPage1.ResumeLayout(false);
      ((ISupportInitialize) this.dgvResults).EndInit();
      this.TabPage2.ResumeLayout(false);
      ((ISupportInitialize) this.dgvResultsSAP).EndInit();
      this.TabPage3.ResumeLayout(false);
      ((ISupportInitialize) this.dgvResultsDER).EndInit();
      this.TabPage4.ResumeLayout(false);
      ((ISupportInitialize) this.dgvResultsTER).EndInit();
      this.TabPage5.ResumeLayout(false);
      ((ISupportInitialize) this.dgvResultsCost).EndInit();
      this.ResumeLayout(false);
    }

    [field: AccessedThroughProperty("Panel1")]
    internal virtual Panel Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button cmdexcel
    {
      get => this._cmdexcel;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdexcel_Click);
        Button cmdexcel1 = this._cmdexcel;
        if (cmdexcel1 != null)
          cmdexcel1.Click -= eventHandler;
        this._cmdexcel = value;
        Button cmdexcel2 = this._cmdexcel;
        if (cmdexcel2 == null)
          return;
        cmdexcel2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Button2")]
    internal virtual Button Button2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Panel5")]
    internal virtual Panel Panel5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckedListBox lstItems
    {
      get => this._lstItems;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.lstItems_SelectedValueChanged);
        CheckedListBox lstItems1 = this._lstItems;
        if (lstItems1 != null)
          lstItems1.SelectedValueChanged -= eventHandler;
        this._lstItems = value;
        CheckedListBox lstItems2 = this._lstItems;
        if (lstItems2 == null)
          return;
        lstItems2.SelectedValueChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Panel4")]
    internal virtual Panel Panel4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label1")]
    internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("TabControl1")]
    internal virtual TabControl TabControl1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("TabPage1")]
    internal virtual TabPage TabPage1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("TabPage2")]
    internal virtual TabPage TabPage2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("dgvResultsSAP")]
    internal virtual DataGridView dgvResultsSAP { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("TabPage3")]
    internal virtual TabPage TabPage3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("dgvResultsDER")]
    internal virtual DataGridView dgvResultsDER { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("TabPage4")]
    internal virtual TabPage TabPage4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("dgvResultsTER")]
    internal virtual DataGridView dgvResultsTER { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("dgvResults")]
    internal virtual DataGridView dgvResults { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("CmExport")]
    internal virtual ContextMenuStrip CmExport { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripMenuItem SAPExcelExportToolStripMenuItem
    {
      get => this._SAPExcelExportToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.SAPExcelExportToolStripMenuItem_Click);
        ToolStripMenuItem toolStripMenuItem1 = this._SAPExcelExportToolStripMenuItem;
        if (toolStripMenuItem1 != null)
          toolStripMenuItem1.Click -= eventHandler;
        this._SAPExcelExportToolStripMenuItem = value;
        ToolStripMenuItem toolStripMenuItem2 = this._SAPExcelExportToolStripMenuItem;
        if (toolStripMenuItem2 == null)
          return;
        toolStripMenuItem2.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem DERExcelExportToolStripMenuItem
    {
      get => this._DERExcelExportToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DERExcelExportToolStripMenuItem_Click);
        ToolStripMenuItem toolStripMenuItem1 = this._DERExcelExportToolStripMenuItem;
        if (toolStripMenuItem1 != null)
          toolStripMenuItem1.Click -= eventHandler;
        this._DERExcelExportToolStripMenuItem = value;
        ToolStripMenuItem toolStripMenuItem2 = this._DERExcelExportToolStripMenuItem;
        if (toolStripMenuItem2 == null)
          return;
        toolStripMenuItem2.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem TERExcelExportToolStripMenuItem
    {
      get => this._TERExcelExportToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.TERExcelExportToolStripMenuItem_Click);
        ToolStripMenuItem toolStripMenuItem1 = this._TERExcelExportToolStripMenuItem;
        if (toolStripMenuItem1 != null)
          toolStripMenuItem1.Click -= eventHandler;
        this._TERExcelExportToolStripMenuItem = value;
        ToolStripMenuItem toolStripMenuItem2 = this._TERExcelExportToolStripMenuItem;
        if (toolStripMenuItem2 == null)
          return;
        toolStripMenuItem2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("TabPage5")]
    internal virtual TabPage TabPage5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("dgvResultsCost")]
    internal virtual DataGridView dgvResultsCost { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripMenuItem EPCCostExcelExportToolStripMenuItem
    {
      get => this._EPCCostExcelExportToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.EPCCostExcelExportToolStripMenuItem_Click);
        ToolStripMenuItem toolStripMenuItem1 = this._EPCCostExcelExportToolStripMenuItem;
        if (toolStripMenuItem1 != null)
          toolStripMenuItem1.Click -= eventHandler;
        this._EPCCostExcelExportToolStripMenuItem = value;
        ToolStripMenuItem toolStripMenuItem2 = this._EPCCostExcelExportToolStripMenuItem;
        if (toolStripMenuItem2 == null)
          return;
        toolStripMenuItem2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("ToolTip1")]
    internal virtual ToolTip ToolTip1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private void Key_Results_Load(object sender, EventArgs e)
    {
      this.LoadColumns();
      this.FillCheckBoxes();
      this.FillResults();
      this.CheckColumns();
      this.LoadColumnsSAP();
      this.FillResultsSAP();
      this.CheckColumnsSAP();
      this.LoadColumnsTER();
      this.FillResultsTER();
      this.CheckColumnsTER();
      this.LoadColumnsDER();
      this.FillResultsDER();
      this.CheckColumnsDER();
      this.LoadColumnsCost();
      this.FillResultsEPC_Cost();
      this.CheckColumnsCost();
    }

    private void CheckColumns()
    {
      this.dtResultsFinal = new DataTable();
      int num1 = checked (this.lstItems.CheckedItems.Count - 1);
      int num2 = 0;
      while (num2 <= num1)
      {
        CheckedListBox.CheckedItemCollection checkedItems;
        int index;
        object[] objArray;
        bool[] flagArray;
        NewLateBinding.LateCall((object) this.dtResultsFinal.Columns, (System.Type) null, "Add", objArray = new object[1]
        {
          (checkedItems = this.lstItems.CheckedItems)[index = num2]
        }, (string[]) null, (System.Type[]) null, flagArray = new bool[1]
        {
          true
        }, true);
        if (flagArray[0])
          checkedItems[index] = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(objArray[0]));
        checked { ++num2; }
      }
      int num3 = checked (this.dtResults.Rows.Count - 1);
      int index1 = 0;
      while (index1 <= num3)
      {
        DataRow row = this.dtResultsFinal.NewRow();
        int num4 = checked (this.dtResultsFinal.Columns.Count - 1);
        int index2 = 0;
        while (index2 <= num4)
        {
          row[this.dtResultsFinal.Columns[index2].ColumnName] = RuntimeHelpers.GetObjectValue(this.dtResults.Rows[index1][this.dtResultsFinal.Columns[index2].ColumnName]);
          checked { ++index2; }
        }
        this.dtResultsFinal.Rows.Add(row);
        checked { ++index1; }
      }
      this.dgvResults.DataSource = (object) null;
      this.dgvResults.DataSource = (object) this.dtResultsFinal;
      try
      {
        foreach (DataGridViewColumn column in (BaseCollection) this.dgvResults.Columns)
          column.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }

    private void CheckColumnsSAP()
    {
      this.dtResultsFinalSAP = new DataTable();
      int num1 = checked (this.lstItems.CheckedItems.Count - 1);
      int index1 = 0;
      while (index1 <= num1)
      {
        int num2 = checked (this.dtResultsSAP.Columns.Count - 1);
        int index2 = 0;
        while (index2 <= num2)
        {
          if (this.dtResultsSAP.Columns[index2].ColumnName.Contains(Conversions.ToString(this.lstItems.CheckedItems[index1])) && !this.dtResultsFinalSAP.Columns.Contains(Conversions.ToString(this.lstItems.CheckedItems[index1])))
          {
            CheckedListBox.CheckedItemCollection checkedItems;
            int index3;
            object[] objArray;
            bool[] flagArray;
            NewLateBinding.LateCall((object) this.dtResultsFinalSAP.Columns, (System.Type) null, "Add", objArray = new object[1]
            {
              (checkedItems = this.lstItems.CheckedItems)[index3 = index1]
            }, (string[]) null, (System.Type[]) null, flagArray = new bool[1]
            {
              true
            }, true);
            if (flagArray[0])
              checkedItems[index3] = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(objArray[0]));
          }
          checked { ++index2; }
        }
        checked { ++index1; }
      }
      int num3 = checked (this.dtResultsSAP.Rows.Count - 1);
      int index4 = 0;
      while (index4 <= num3)
      {
        DataRow row = this.dtResultsFinalSAP.NewRow();
        int num4 = checked (this.dtResultsFinalSAP.Columns.Count - 1);
        int index5 = 0;
        while (index5 <= num4)
        {
          row[this.dtResultsFinalSAP.Columns[index5].ColumnName] = RuntimeHelpers.GetObjectValue(this.dtResultsSAP.Rows[index4][this.dtResultsFinalSAP.Columns[index5].ColumnName]);
          checked { ++index5; }
        }
        this.dtResultsFinalSAP.Rows.Add(row);
        checked { ++index4; }
      }
      this.dgvResultsSAP.DataSource = (object) null;
      this.dgvResultsSAP.DataSource = (object) this.dtResultsFinalSAP;
      try
      {
        foreach (DataGridViewColumn column in (BaseCollection) this.dgvResultsSAP.Columns)
          column.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }

    private void CheckColumnsDER()
    {
      this.dtResultsFinalDER = new DataTable();
      int num1 = checked (this.lstItems.CheckedItems.Count - 1);
      int index1 = 0;
      while (index1 <= num1)
      {
        int num2 = checked (this.dtResultsDER.Columns.Count - 1);
        int index2 = 0;
        while (index2 <= num2)
        {
          if (this.dtResultsDER.Columns[index2].ColumnName.Contains(Conversions.ToString(this.lstItems.CheckedItems[index1])) && !this.dtResultsFinalDER.Columns.Contains(Conversions.ToString(this.lstItems.CheckedItems[index1])))
          {
            CheckedListBox.CheckedItemCollection checkedItems;
            int index3;
            object[] objArray;
            bool[] flagArray;
            NewLateBinding.LateCall((object) this.dtResultsFinalDER.Columns, (System.Type) null, "Add", objArray = new object[1]
            {
              (checkedItems = this.lstItems.CheckedItems)[index3 = index1]
            }, (string[]) null, (System.Type[]) null, flagArray = new bool[1]
            {
              true
            }, true);
            if (flagArray[0])
              checkedItems[index3] = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(objArray[0]));
          }
          checked { ++index2; }
        }
        checked { ++index1; }
      }
      int num3 = checked (this.dtResultsDER.Rows.Count - 1);
      int index4 = 0;
      while (index4 <= num3)
      {
        DataRow row = this.dtResultsFinalDER.NewRow();
        int num4 = checked (this.dtResultsFinalDER.Columns.Count - 1);
        int index5 = 0;
        while (index5 <= num4)
        {
          row[this.dtResultsFinalDER.Columns[index5].ColumnName] = RuntimeHelpers.GetObjectValue(this.dtResultsDER.Rows[index4][this.dtResultsFinalDER.Columns[index5].ColumnName]);
          checked { ++index5; }
        }
        this.dtResultsFinalDER.Rows.Add(row);
        checked { ++index4; }
      }
      this.dgvResultsDER.DataSource = (object) null;
      this.dgvResultsDER.DataSource = (object) this.dtResultsFinalDER;
      try
      {
        foreach (DataGridViewColumn column in (BaseCollection) this.dgvResultsDER.Columns)
          column.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }

    private void CheckColumnsTER()
    {
      this.dtResultsFinalTER = new DataTable();
      int num1 = checked (this.lstItems.CheckedItems.Count - 1);
      int index1 = 0;
      while (index1 <= num1)
      {
        int num2 = checked (this.dtResultsTER.Columns.Count - 1);
        int index2 = 0;
        while (index2 <= num2)
        {
          if (this.dtResultsTER.Columns[index2].ColumnName.Contains(Conversions.ToString(this.lstItems.CheckedItems[index1])) && !this.dtResultsFinalTER.Columns.Contains(Conversions.ToString(this.lstItems.CheckedItems[index1])))
          {
            CheckedListBox.CheckedItemCollection checkedItems;
            int index3;
            object[] objArray;
            bool[] flagArray;
            NewLateBinding.LateCall((object) this.dtResultsFinalTER.Columns, (System.Type) null, "Add", objArray = new object[1]
            {
              (checkedItems = this.lstItems.CheckedItems)[index3 = index1]
            }, (string[]) null, (System.Type[]) null, flagArray = new bool[1]
            {
              true
            }, true);
            if (flagArray[0])
              checkedItems[index3] = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(objArray[0]));
          }
          checked { ++index2; }
        }
        checked { ++index1; }
      }
      int num3 = checked (this.dtResultsTER.Rows.Count - 1);
      int index4 = 0;
      while (index4 <= num3)
      {
        DataRow row = this.dtResultsFinalTER.NewRow();
        int num4 = checked (this.dtResultsFinalTER.Columns.Count - 1);
        int index5 = 0;
        while (index5 <= num4)
        {
          row[this.dtResultsFinalTER.Columns[index5].ColumnName] = RuntimeHelpers.GetObjectValue(this.dtResultsTER.Rows[index4][this.dtResultsFinalTER.Columns[index5].ColumnName]);
          checked { ++index5; }
        }
        this.dtResultsFinalTER.Rows.Add(row);
        checked { ++index4; }
      }
      this.dgvResultsTER.DataSource = (object) null;
      this.dgvResultsTER.DataSource = (object) this.dtResultsFinalTER;
      try
      {
        foreach (DataGridViewColumn column in (BaseCollection) this.dgvResultsTER.Columns)
          column.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }

    private void CheckColumnsCost()
    {
      this.dtResultsFinalCost = new DataTable();
      int num1 = checked (this.lstItems.CheckedItems.Count - 1);
      int index1 = 0;
      while (index1 <= num1)
      {
        int num2 = checked (this.dtResultscost.Columns.Count - 1);
        int index2 = 0;
        while (index2 <= num2)
        {
          if (this.dtResultscost.Columns[index2].ColumnName.Contains(Conversions.ToString(this.lstItems.CheckedItems[index1])) && !this.dtResultsFinalCost.Columns.Contains(Conversions.ToString(this.lstItems.CheckedItems[index1])))
          {
            CheckedListBox.CheckedItemCollection checkedItems;
            int index3;
            object[] objArray;
            bool[] flagArray;
            NewLateBinding.LateCall((object) this.dtResultsFinalCost.Columns, (System.Type) null, "Add", objArray = new object[1]
            {
              (checkedItems = this.lstItems.CheckedItems)[index3 = index1]
            }, (string[]) null, (System.Type[]) null, flagArray = new bool[1]
            {
              true
            }, true);
            if (flagArray[0])
              checkedItems[index3] = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(objArray[0]));
          }
          checked { ++index2; }
        }
        checked { ++index1; }
      }
      int num3 = checked (this.dtResultscost.Rows.Count - 1);
      int index4 = 0;
      while (index4 <= num3)
      {
        DataRow row = this.dtResultsFinalCost.NewRow();
        int num4 = checked (this.dtResultsFinalCost.Columns.Count - 1);
        int index5 = 0;
        while (index5 <= num4)
        {
          row[this.dtResultsFinalCost.Columns[index5].ColumnName] = RuntimeHelpers.GetObjectValue(this.dtResultscost.Rows[index4][this.dtResultsFinalCost.Columns[index5].ColumnName]);
          checked { ++index5; }
        }
        this.dtResultsFinalCost.Rows.Add(row);
        checked { ++index4; }
      }
      this.dgvResultsCost.DataSource = (object) null;
      this.dgvResultsCost.DataSource = (object) this.dtResultsFinalCost;
      try
      {
        foreach (DataGridViewColumn column in (BaseCollection) this.dgvResultsCost.Columns)
          column.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }

    private void FillCheckBoxes()
    {
      this.lstItems.Items.Clear();
      int num = checked (this.dtResults.Columns.Count - 1);
      int index = 0;
      while (index <= num)
      {
        this.lstItems.Items.Add((object) this.dtResults.Columns[index].ColumnName, true);
        checked { ++index; }
      }
    }

    private void FillCheckBoxesSAP()
    {
      this.lstItems.Items.Clear();
      int num = checked (this.dtResultsSAP.Columns.Count - 1);
      int index = 0;
      while (index <= num)
      {
        this.lstItems.Items.Add((object) this.dtResultsSAP.Columns[index].ColumnName, true);
        checked { ++index; }
      }
    }

    private void FillCheckBoxesDER()
    {
      this.lstItems.Items.Clear();
      int num = checked (this.dtResultsDER.Columns.Count - 1);
      int index = 0;
      while (index <= num)
      {
        this.lstItems.Items.Add((object) this.dtResultsDER.Columns[index].ColumnName, true);
        checked { ++index; }
      }
    }

    private void FillCheckBoxesTER()
    {
      this.lstItems.Items.Clear();
      int num = checked (this.dtResultsTER.Columns.Count - 1);
      int index = 0;
      while (index <= num)
      {
        this.lstItems.Items.Add((object) this.dtResultsTER.Columns[index].ColumnName, true);
        checked { ++index; }
      }
    }

    private void LoadColumns()
    {
      this.dtResults.Columns.Add("Dwelling");
      this.dtResults.Columns.Add("Reference");
      this.dtResults.Columns.Add("Status");
      this.dtResults.Columns.Add("Property Type");
      this.dtResults.Columns.Add("Built Form");
      this.dtResults.Columns.Add("Address1");
      this.dtResults.Columns.Add("Address2");
      this.dtResults.Columns.Add("Address3");
      this.dtResults.Columns.Add("City");
      this.dtResults.Columns.Add("Postcode");
      this.dtResults.Columns.Add("UPRN");
      this.dtResults.Columns.Add("Country");
      this.dtResults.Columns.Add("SAP");
      this.dtResults.Columns.Add("EI");
      this.dtResults.Columns.Add("DER");
      this.dtResults.Columns.Add("TER");
      this.dtResults.Columns.Add("DFEE");
      this.dtResults.Columns.Add("TFEE");
      this.dtResults.Columns.Add("Percent Improvement");
      this.dtResults.Columns.Add("Total Floor Area");
      this.dtResults.Columns.Add("FEE");
      this.dtResults.Columns.Add("Air permeability");
      this.dtResults.Columns.Add("Main Heating Fuel Requirement (SAP)");
      this.dtResults.Columns.Add("Secondary Main Heating Fuel Requirement (SAP)");
      this.dtResults.Columns.Add("Secondary Heating Fuel Requirement (SAP)");
      this.dtResults.Columns.Add("Water Fuel Requirement (SAP)");
      this.dtResults.Columns.Add("Electricity Pumps Fans Requirement (SAP)");
      this.dtResults.Columns.Add("Electricity Lighting Requirement (SAP)");
      this.dtResults.Columns.Add("PV Energy Produced (SAP)");
      this.dtResults.Columns.Add("Wind Energy Produced (SAP)");
      this.dtResults.Columns.Add("Total CO2 (SAP)");
      this.dtResults.Columns.Add("Main Heating Fuel Requirement (DER)");
      this.dtResults.Columns.Add("Secondary Main Heating Fuel Requirement (DER)");
      this.dtResults.Columns.Add("Secondary Heating Fuel Requirement (DER)");
      this.dtResults.Columns.Add("Water Fuel Requirement (DER)");
      this.dtResults.Columns.Add("Electricity Pumps Fans Requirement (DER)");
      this.dtResults.Columns.Add("Electricity Lighting Requirement (DER)");
      this.dtResults.Columns.Add("PV Energy Produced (DER)");
      this.dtResults.Columns.Add("Wind Energy Produced (DER)");
      this.dtResults.Columns.Add("Total CO2 (DER)");
      this.dtResults.Columns.Add("Main Heating Fuel Requirement (TER)");
      this.dtResults.Columns.Add("Secondary Main Heating Fuel Requirement (TER)");
      this.dtResults.Columns.Add("Secondary Heating Fuel Requirement (TER)");
      this.dtResults.Columns.Add("Water Fuel Requirement (TER)");
      this.dtResults.Columns.Add("Electricity Pumps Fans Requirement (TER)");
      this.dtResults.Columns.Add("Electricity Lighting Requirement (TER)");
      this.dtResults.Columns.Add("PV Energy Produced (TER)");
      this.dtResults.Columns.Add("Wind Energy Produced (TER)");
      this.dtResults.Columns.Add("Total CO2 (TER)");
      this.dtResults.Columns.Add("Main Heating Fuel Requirement (EPC_cost)");
      this.dtResults.Columns.Add("Secondary Main Heating Fuel Requirement (EPC_cost)");
      this.dtResults.Columns.Add("Secondary Heating Fuel Requirement (EPC_cost)");
      this.dtResults.Columns.Add("Water Fuel Requirement (EPC_cost)");
      this.dtResults.Columns.Add("Electricity Pumps Fans Requirement (EPC_cost)");
      this.dtResults.Columns.Add("Electricity Lighting Requirement (EPC_cost)");
      this.dtResults.Columns.Add("PV Energy Produced (EPC_cost)");
      this.dtResults.Columns.Add("Wind Energy Produced (EPC_cost)");
      this.dtResults.Columns.Add("Total CO2 (EPC_cost)");
      this.dtResults.Columns.Add("Building Regulations Results");
      this.dtResults.Columns.Add("Space Cooling");
      this.dtResults.Columns.Add("HLP");
      this.dtResults.Columns.Add("Boiler Make");
      this.dtResults.Columns.Add("Boiler Model");
      this.dtResults.Columns.Add("Model Qual");
      this.dtResults.Columns.Add("Boiler Index");
      this.dtResults.Columns.Add("Cylinder Size ");
      this.dtResults.Columns.Add("WWHR");
      this.dtResults.Columns.Add("FGHR");
      this.dtResults.Columns.Add("Secondary Heating");
      this.dtResults.Columns.Add("Calculated y-value");
      this.dtResults.Columns.Add("Orientation");
      this.dtResults.Columns.Add("PV Kwp");
      this.dtResults.Columns.Add("box64");
      this.dtResults.Columns.Add("box98");
      this.dtResults.Columns.Add("Ventilation Type");
      this.dtResults.Columns.Add("Product Name");
      this.dtResults.Columns.Add("Vent System");
      this.dtResults.Columns.Add("overheating June");
      this.dtResults.Columns.Add("overheating July");
      this.dtResults.Columns.Add("overheating August");
      this.dtResults.Columns.Add("Cooking");
      this.dtResults.Columns.Add("Appliance");
      this.dtResults.Columns.Add("Total Energy Cost");
    }

    private void LoadColumnsSAP()
    {
      this.dtResultsSAP.Columns.Add("Dwelling");
      this.dtResultsSAP.Columns.Add("Reference");
      this.dtResultsSAP.Columns.Add("Status");
      this.dtResultsSAP.Columns.Add("Property Type");
      this.dtResultsSAP.Columns.Add("Built Form");
      this.dtResultsSAP.Columns.Add("Address1");
      this.dtResultsSAP.Columns.Add("Address2");
      this.dtResultsSAP.Columns.Add("Address3");
      this.dtResultsSAP.Columns.Add("City");
      this.dtResultsSAP.Columns.Add("Postcode");
      this.dtResultsSAP.Columns.Add("UPRN");
      this.dtResultsSAP.Columns.Add("Country");
      this.dtResultsSAP.Columns.Add("SAP");
      this.dtResultsSAP.Columns.Add("EI");
      this.dtResultsSAP.Columns.Add("DER");
      this.dtResultsSAP.Columns.Add("TER");
      this.dtResultsSAP.Columns.Add("DFEE");
      this.dtResultsSAP.Columns.Add("TFEE");
      this.dtResultsSAP.Columns.Add("Percent Improvement");
      this.dtResultsSAP.Columns.Add("Total Floor Area");
      this.dtResultsSAP.Columns.Add("FEE");
      this.dtResultsSAP.Columns.Add("Air permeability");
      this.dtResultsSAP.Columns.Add("Main Heating Fuel Requirement (SAP)");
      this.dtResultsSAP.Columns.Add("Secondary Main Heating Fuel Requirement (SAP)");
      this.dtResultsSAP.Columns.Add("Secondary Heating Fuel Requirement (SAP)");
      this.dtResultsSAP.Columns.Add("Water Fuel Requirement (SAP)");
      this.dtResultsSAP.Columns.Add("Electricity Pumps Fans Requirement (SAP)");
      this.dtResultsSAP.Columns.Add("Electricity Lighting Requirement (SAP)");
      this.dtResultsSAP.Columns.Add("PV Energy Produced (SAP)");
      this.dtResultsSAP.Columns.Add("Wind Energy Produced (SAP)");
      this.dtResultsSAP.Columns.Add("Total CO2 (SAP)");
      this.dtResultsSAP.Columns.Add("Building Regulations Results");
      this.dtResultsSAP.Columns.Add("Space Cooling");
      this.dtResultsSAP.Columns.Add("HLP");
      this.dtResultsSAP.Columns.Add("Boiler Make");
      this.dtResultsSAP.Columns.Add("Boiler Model");
      this.dtResultsSAP.Columns.Add("Model Qual");
      this.dtResultsSAP.Columns.Add("Boiler Index");
      this.dtResultsSAP.Columns.Add("Cylinder Size ");
      this.dtResultsSAP.Columns.Add("WWHR");
      this.dtResultsSAP.Columns.Add("FGHR");
      this.dtResultsSAP.Columns.Add("Secondary Heating");
      this.dtResultsSAP.Columns.Add("Calculated y-value");
      this.dtResultsSAP.Columns.Add("Orientation");
      this.dtResultsSAP.Columns.Add("PV Kwp");
      this.dtResultsSAP.Columns.Add("box64");
      this.dtResultsSAP.Columns.Add("box98");
      this.dtResultsSAP.Columns.Add("Ventilation Type");
      this.dtResultsSAP.Columns.Add("Product Name");
      this.dtResultsSAP.Columns.Add("Vent System");
      this.dtResultsSAP.Columns.Add("overheating June");
      this.dtResultsSAP.Columns.Add("overheating July");
      this.dtResultsSAP.Columns.Add("overheating August");
      this.dtResultsSAP.Columns.Add("Cooking");
      this.dtResultsSAP.Columns.Add("Appliance");
      this.dtResultsSAP.Columns.Add("Total Energy Cost");
    }

    private void LoadColumnsDER()
    {
      this.dtResultsDER.Columns.Add("Dwelling");
      this.dtResultsDER.Columns.Add("Reference");
      this.dtResultsDER.Columns.Add("Status");
      this.dtResultsDER.Columns.Add("Property Type");
      this.dtResultsDER.Columns.Add("Built Form");
      this.dtResultsDER.Columns.Add("Address1");
      this.dtResultsDER.Columns.Add("Address2");
      this.dtResultsDER.Columns.Add("Address3");
      this.dtResultsDER.Columns.Add("City");
      this.dtResultsDER.Columns.Add("Postcode");
      this.dtResultsDER.Columns.Add("UPRN");
      this.dtResultsDER.Columns.Add("Country");
      this.dtResultsDER.Columns.Add("SAP");
      this.dtResultsDER.Columns.Add("EI");
      this.dtResultsDER.Columns.Add("DER");
      this.dtResultsDER.Columns.Add("TER");
      this.dtResultsDER.Columns.Add("DFEE");
      this.dtResultsDER.Columns.Add("TFEE");
      this.dtResultsDER.Columns.Add("Percent Improvement");
      this.dtResultsDER.Columns.Add("Total Floor Area");
      this.dtResultsDER.Columns.Add("FEE");
      this.dtResultsDER.Columns.Add("Air permeability");
      this.dtResultsDER.Columns.Add("Main Heating Fuel Requirement (DER)");
      this.dtResultsDER.Columns.Add("Secondary Main Heating Fuel Requirement (DER)");
      this.dtResultsDER.Columns.Add("Secondary Heating Fuel Requirement (DER)");
      this.dtResultsDER.Columns.Add("Water Fuel Requirement (DER)");
      this.dtResultsDER.Columns.Add("Electricity Pumps Fans Requirement (DER)");
      this.dtResultsDER.Columns.Add("Electricity Lighting Requirement (DER)");
      this.dtResultsDER.Columns.Add("PV Energy Produced (DER)");
      this.dtResultsDER.Columns.Add("Wind Energy Produced (DER)");
      this.dtResultsDER.Columns.Add("Total CO2 (DER)");
      this.dtResultsDER.Columns.Add("Building Regulations Results");
      this.dtResultsDER.Columns.Add("Space Cooling");
      this.dtResultsDER.Columns.Add("HLP");
      this.dtResultsDER.Columns.Add("Boiler Make");
      this.dtResultsDER.Columns.Add("Boiler Model");
      this.dtResultsDER.Columns.Add("Model Qual");
      this.dtResultsDER.Columns.Add("Boiler Index");
      this.dtResultsDER.Columns.Add("Cylinder Size ");
      this.dtResultsDER.Columns.Add("WWHR");
      this.dtResultsDER.Columns.Add("FGHR");
      this.dtResultsDER.Columns.Add("Secondary Heating");
      this.dtResultsDER.Columns.Add("Calculated y-value");
      this.dtResultsDER.Columns.Add("Orientation");
      this.dtResultsDER.Columns.Add("PV Kwp");
      this.dtResultsDER.Columns.Add("box64");
      this.dtResultsDER.Columns.Add("box98");
      this.dtResultsDER.Columns.Add("Ventilation Type");
      this.dtResultsDER.Columns.Add("Product Name");
      this.dtResultsDER.Columns.Add("Vent System");
      this.dtResultsDER.Columns.Add("overheating June");
      this.dtResultsDER.Columns.Add("overheating July");
      this.dtResultsDER.Columns.Add("overheating August");
      this.dtResultsDER.Columns.Add("Cooking");
      this.dtResultsDER.Columns.Add("Appliance");
      this.dtResultsDER.Columns.Add("Total Energy Cost");
    }

    private void LoadColumnsTER()
    {
      this.dtResultsTER.Columns.Add("Dwelling");
      this.dtResultsTER.Columns.Add("Reference");
      this.dtResultsTER.Columns.Add("Status");
      this.dtResultsTER.Columns.Add("Property Type");
      this.dtResultsTER.Columns.Add("Built Form");
      this.dtResultsTER.Columns.Add("Address1");
      this.dtResultsTER.Columns.Add("Address2");
      this.dtResultsTER.Columns.Add("Address3");
      this.dtResultsTER.Columns.Add("City");
      this.dtResultsTER.Columns.Add("Postcode");
      this.dtResultsTER.Columns.Add("UPRN");
      this.dtResultsTER.Columns.Add("Country");
      this.dtResultsTER.Columns.Add("SAP");
      this.dtResultsTER.Columns.Add("EI");
      this.dtResultsTER.Columns.Add("DER");
      this.dtResultsTER.Columns.Add("TER");
      this.dtResultsTER.Columns.Add("DFEE");
      this.dtResultsTER.Columns.Add("TFEE");
      this.dtResultsTER.Columns.Add("Percent Improvement");
      this.dtResultsTER.Columns.Add("Total Floor Area");
      this.dtResultsTER.Columns.Add("FEE");
      this.dtResultsTER.Columns.Add("Air permeability");
      this.dtResultsTER.Columns.Add("Main Heating Fuel Requirement (TER)");
      this.dtResultsTER.Columns.Add("Secondary Main Heating Fuel Requirement (TER)");
      this.dtResultsTER.Columns.Add("Secondary Heating Fuel Requirement (TER)");
      this.dtResultsTER.Columns.Add("Water Fuel Requirement (TER)");
      this.dtResultsTER.Columns.Add("Electricity Pumps Fans Requirement (TER)");
      this.dtResultsTER.Columns.Add("Electricity Lighting Requirement (TER)");
      this.dtResultsTER.Columns.Add("PV Energy Produced (TER)");
      this.dtResultsTER.Columns.Add("Wind Energy Produced (TER)");
      this.dtResultsTER.Columns.Add("Total CO2 (TER)");
      this.dtResultsTER.Columns.Add("Building Regulations Results");
      this.dtResultsTER.Columns.Add("Space Cooling");
      this.dtResultsTER.Columns.Add("HLP");
      this.dtResultsTER.Columns.Add("Boiler Make");
      this.dtResultsTER.Columns.Add("Boiler Model");
      this.dtResultsTER.Columns.Add("Model Qual");
      this.dtResultsTER.Columns.Add("Boiler Index");
      this.dtResultsTER.Columns.Add("Cylinder Size ");
      this.dtResultsTER.Columns.Add("WWHR");
      this.dtResultsTER.Columns.Add("FGHR");
      this.dtResultsTER.Columns.Add("Secondary Heating");
      this.dtResultsTER.Columns.Add("Calculated y-value");
      this.dtResultsTER.Columns.Add("Orientation");
      this.dtResultsTER.Columns.Add("PV Kwp");
      this.dtResultsTER.Columns.Add("box64");
      this.dtResultsTER.Columns.Add("box98");
      this.dtResultsTER.Columns.Add("Ventilation Type");
      this.dtResultsTER.Columns.Add("Product Name");
      this.dtResultsTER.Columns.Add("Vent System");
      this.dtResultsTER.Columns.Add("overheating June");
      this.dtResultsTER.Columns.Add("overheating July");
      this.dtResultsTER.Columns.Add("overheating August");
      this.dtResultsTER.Columns.Add("Cooking");
      this.dtResultsTER.Columns.Add("Appliance");
      this.dtResultsTER.Columns.Add("Total Energy Cost");
    }

    private void LoadColumnsCost()
    {
      this.dtResultscost.Columns.Add("Dwelling");
      this.dtResultscost.Columns.Add("Reference");
      this.dtResultscost.Columns.Add("Status");
      this.dtResultscost.Columns.Add("Property Type");
      this.dtResultscost.Columns.Add("Built Form");
      this.dtResultscost.Columns.Add("Address1");
      this.dtResultscost.Columns.Add("Address2");
      this.dtResultscost.Columns.Add("Address3");
      this.dtResultscost.Columns.Add("City");
      this.dtResultscost.Columns.Add("Postcode");
      this.dtResultscost.Columns.Add("UPRN");
      this.dtResultscost.Columns.Add("Country");
      this.dtResultscost.Columns.Add("SAP");
      this.dtResultscost.Columns.Add("EI");
      this.dtResultscost.Columns.Add("DER");
      this.dtResultscost.Columns.Add("TER");
      this.dtResultscost.Columns.Add("DFEE");
      this.dtResultscost.Columns.Add("TFEE");
      this.dtResultscost.Columns.Add("Percent Improvement");
      this.dtResultscost.Columns.Add("Total Floor Area");
      this.dtResultscost.Columns.Add("FEE");
      this.dtResultscost.Columns.Add("Air permeability");
      this.dtResultscost.Columns.Add("Main Heating Fuel Requirement (EPC_cost)");
      this.dtResultscost.Columns.Add("Secondary Main Heating Fuel Requirement (EPC_cost)");
      this.dtResultscost.Columns.Add("Secondary Heating Fuel Requirement (EPC_cost)");
      this.dtResultscost.Columns.Add("Water Fuel Requirement (EPC_cost)");
      this.dtResultscost.Columns.Add("Electricity Pumps Fans Requirement (EPC_cost)");
      this.dtResultscost.Columns.Add("Electricity Lighting Requirement (EPC_cost)");
      this.dtResultscost.Columns.Add("PV Energy Produced (EPC_cost)");
      this.dtResultscost.Columns.Add("Wind Energy Produced (EPC_cost)");
      this.dtResultscost.Columns.Add("Total CO2 (EPC_cost)");
      this.dtResultscost.Columns.Add("Building Regulations Results");
      this.dtResultscost.Columns.Add("Space Cooling");
      this.dtResultscost.Columns.Add("HLP");
      this.dtResultscost.Columns.Add("Boiler Make");
      this.dtResultscost.Columns.Add("Boiler Model");
      this.dtResultscost.Columns.Add("Model Qual");
      this.dtResultscost.Columns.Add("Boiler Index");
      this.dtResultscost.Columns.Add("Cylinder Size ");
      this.dtResultscost.Columns.Add("WWHR");
      this.dtResultscost.Columns.Add("FGHR");
      this.dtResultscost.Columns.Add("Secondary Heating");
      this.dtResultscost.Columns.Add("Calculated y-value");
      this.dtResultscost.Columns.Add("Orientation");
      this.dtResultscost.Columns.Add("PV Kwp");
      this.dtResultscost.Columns.Add("box64");
      this.dtResultscost.Columns.Add("box98");
      this.dtResultscost.Columns.Add("Ventilation Type");
      this.dtResultscost.Columns.Add("Product Name");
      this.dtResultscost.Columns.Add("Vent System");
      this.dtResultscost.Columns.Add("overheating June");
      this.dtResultscost.Columns.Add("overheating July");
      this.dtResultscost.Columns.Add("overheating August");
      this.dtResultscost.Columns.Add("Cooking");
      this.dtResultscost.Columns.Add("Appliance");
      this.dtResultscost.Columns.Add("Total Energy Cost");
    }

    private void FillResults()
    {
      int roundFigure = SAP_Module.RoundFigure;
      SAP_Module.RoundFigure = 2;
      int num1 = checked (SAP_Module.Proj.NoOfDwells - 1);
      int House = 0;
      while (House <= num1)
      {
        SAP_Module.CurrDwelling = House;
        if (Validation.LodgementStatusCheck(House))
        {
          DataRow row = this.dtResults.NewRow();
          DataRow dataRow = row;
          dataRow["Dwelling"] = (object) SAP_Module.Proj.Dwellings[House].Name;
          dataRow["Reference"] = (object) SAP_Module.Proj.Dwellings[House].Reference;
          dataRow["Status"] = (object) SAP_Module.Proj.Dwellings[House].Status;
          dataRow["Property Type"] = (object) SAP_Module.Proj.Dwellings[House].PropertyType;
          dataRow["Built Form"] = (object) SAP_Module.Proj.Dwellings[House].BuildForm;
          dataRow["Address1"] = (object) SAP_Module.Proj.Dwellings[House].Address.Line1;
          dataRow["Address2"] = (object) SAP_Module.Proj.Dwellings[House].Address.Line2;
          dataRow["Address3"] = (object) SAP_Module.Proj.Dwellings[House].Address.Line3;
          dataRow["City"] = (object) SAP_Module.Proj.Dwellings[House].Address.City;
          dataRow["Postcode"] = (object) SAP_Module.Proj.Dwellings[House].Address.PostCost;
          dataRow["UPRN"] = (object) SAP_Module.Proj.Dwellings[House].UPRN;
          dataRow["Country"] = (object) SAP_Module.Proj.Dwellings[House].Address.Country;
          Functions.CalculateNow();
          if (SAP_Module.Calculation2012.Calculation.SAP_rating_11a.Box258 == 0.0)
            dataRow["SAP"] = (object) (SAP_Module.Calculation2012.Calculation.SAP_rating_11b.SAPBand + " " + Conversions.ToString(SAP_Module.Calculation2012.Calculation.SAP_rating_11b.SAPRating) + " (" + Conversions.ToString(SAP_Module.Calculation2012.Calculation.SAP_rating_11b.Box358) + ")");
          else
            dataRow["SAP"] = (object) (SAP_Module.Calculation2012.Calculation.SAP_rating_11a.SAPBand + " " + Conversions.ToString(SAP_Module.Calculation2012.Calculation.SAP_rating_11a.SAPRating) + " (" + Conversions.ToString(SAP_Module.Calculation2012.Calculation.SAP_rating_11a.Box258) + ")");
          if (SAP_Module.CalcualtionDER2012.Calculation.CO2_Emissions_12a.Box273 == 0.0)
          {
            dataRow["DER"] = (object) SAP_Module.CalcualtionDER2012.Calculation.CO2_Emissions_12b.Box384;
            dataRow["EI"] = (object) SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box385;
          }
          else
          {
            dataRow["DER"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.CO2_Emissions_12a.Box273, 2);
            dataRow["EI"] = (object) SAP_Module.Calculation2012.Calculation.CO2_Emissions_12a.EIValue;
          }
          dataRow["TER"] = (object) Functions.TER();
          Calc2012 calc2012_1 = new Calc2012();
          SAP_Module.Dwelling feeDwelling1 = Functions.GetFEEDwelling(ref SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling]);
          calc2012_1.SETPCDF(SAP_Module.PCDFData);
          calc2012_1.IsFabricEfficiency = true;
          calc2012_1.Dwelling = feeDwelling1;
          Calc2012 calc2012_2 = new Calc2012();
          SAP_Module.Dwelling feeDwelling2 = Functions.GetFEEDwelling(ref SAP_Module.TERDwelling);
          calc2012_2.SETPCDF(SAP_Module.PCDFData);
          calc2012_2.IsFabricEfficiency = true;
          calc2012_2.Dwelling = feeDwelling2;
          SAP_Module.CalcRound = true;
          SAP_Module.RoundFigure = 2;
          Calc2012 calc2012_3 = new Calc2012();
          dataRow["DFEE"] = (object) Math.Round(SAP_Module.CalculationFabric.Calculation.Fabric_Energy_Efficiency.Box109, 1);
          Calc2012 calc2012_4 = new Calc2012();
          calc2012_4.SETPCDF(SAP_Module.PCDFData);
          calc2012_4.IsFabricEfficiency = true;
          SAP_Module.CalcRound = false;
          calc2012_4.Dwelling = Functions.GetFEEDwelling(ref SAP_Module.TERDwelling);
          SAP_Module.CalcRound = true;
          dataRow["TFEE"] = (object) Math.Round(1.15 * calc2012_4.Calculation.Fabric_Energy_Efficiency.Box109, 1);
          dataRow["Percent Improvement"] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet((object) null, typeof (Math), "Round", new object[2]
          {
            Microsoft.VisualBasic.CompilerServices.Operators.MultiplyObject((object) 100, Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject((object) 1, Microsoft.VisualBasic.CompilerServices.Operators.DivideObject(dataRow["DER"], (object) Functions.TER()))),
            (object) 2
          }, (string[]) null, (System.Type[]) null, (bool[]) null));
          dataRow["Total Floor Area"] = (object) SAP_Module.CalcualtionDER2012.Calculation.Dimensions.Box4;
          dataRow["FEE"] = (object) Math.Round(SAP_Module.CalculationFabric.Calculation.Fabric_Energy_Efficiency.Box109, 2);
          dataRow["Air permeability"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Ventilation.Box17, 2);
          if (SAP_Module.Calculation2012.Calculation.Energy_Requirements_9a.Box211 == 0.0)
          {
            dataRow["Main Heating Fuel Requirement (SAP)"] = (object) Math.Round(SAP_Module.Calculation2012.Calculation.Energy_Requirements_9b.Box307a + SAP_Module.Calculation2012.Calculation.Energy_Requirements_9b.Box307b + SAP_Module.Calculation2012.Calculation.Energy_Requirements_9b.Box307c + SAP_Module.Calculation2012.Calculation.Energy_Requirements_9b.Box307d + SAP_Module.Calculation2012.Calculation.Energy_Requirements_9b.Box307e, 2);
            dataRow["Secondary Heating Fuel Requirement (SAP)"] = (object) SAP_Module.Calculation2012.Calculation.Energy_Requirements_9b.Box309;
            dataRow["Secondary Main Heating Fuel Requirement (SAP)"] = (object) 0;
            dataRow["Electricity Pumps Fans Requirement (SAP)"] = (object) Math.Round(SAP_Module.Calculation2012.Calculation.Energy_Requirements_9b.Box331, 2);
            dataRow["Electricity Lighting Requirement (SAP)"] = (object) Math.Round(SAP_Module.Calculation2012.Calculation.Energy_Requirements_9b.Box332, 2);
            dataRow["PV Energy Produced (SAP)"] = (object) SAP_Module.Calculation2012.Calculation.Energy_Requirements_9b.Box333;
            dataRow["Wind Energy Produced (SAP)"] = (object) SAP_Module.Calculation2012.Calculation.Energy_Requirements_9b.Box334;
          }
          else
          {
            dataRow["Main Heating Fuel Requirement (SAP)"] = (object) Math.Round(SAP_Module.Calculation2012.Calculation.Energy_Requirements_9a.Box211, 2);
            dataRow["Secondary Main Heating Fuel Requirement (SAP)"] = (object) Math.Round(SAP_Module.Calculation2012.Calculation.Energy_Requirements_9a.Box213, 2);
            dataRow["Secondary Heating Fuel Requirement (SAP)"] = (object) Math.Round(SAP_Module.Calculation2012.Calculation.Energy_Requirements_9a.Box215, 2);
            dataRow["Electricity Pumps Fans Requirement (SAP)"] = (object) Math.Round(SAP_Module.Calculation2012.Calculation.Energy_Requirements_9a.Box231, 2);
            dataRow["Electricity Lighting Requirement (SAP)"] = (object) SAP_Module.Calculation2012.Calculation.Energy_Requirements_9a.Box232;
            dataRow["PV Energy Produced (SAP)"] = (object) SAP_Module.Calculation2012.Calculation.Energy_Requirements_9a.Box233;
            dataRow["Wind Energy Produced (SAP)"] = (object) SAP_Module.Calculation2012.Calculation.Energy_Requirements_9a.Box234;
          }
          dataRow["Water Fuel Requirement (SAP)"] = SAP_Module.Calculation2012.Calculation.Energy_Requirements_9a.Box219 != 0.0 ? (object) Math.Round(SAP_Module.Calculation2012.Calculation.Energy_Requirements_9a.Box219, 2) : (object) Math.Round(SAP_Module.Calculation2012.Calculation.Energy_Requirements_9b.Box312 + SAP_Module.Calculation2012.Calculation.Energy_Requirements_9b.Box310a + SAP_Module.Calculation2012.Calculation.Energy_Requirements_9b.Box310b + SAP_Module.Calculation2012.Calculation.Energy_Requirements_9b.Box310c + SAP_Module.Calculation2012.Calculation.Energy_Requirements_9b.Box310d + SAP_Module.Calculation2012.Calculation.Energy_Requirements_9b.Box310aW + SAP_Module.Calculation2012.Calculation.Energy_Requirements_9b.Box310bW + SAP_Module.Calculation2012.Calculation.Energy_Requirements_9b.Box310cW + SAP_Module.Calculation2012.Calculation.Energy_Requirements_9b.Box310dW + SAP_Module.Calculation2012.Calculation.Energy_Requirements_9b.Box310eW + SAP_Module.Calculation2012.Calculation.Energy_Requirements_9b.Box310e, 2);
          dataRow["Total CO2 (SAP)"] = SAP_Module.Calculation2012.Calculation.CO2_Emissions_12a.Box273 != 0.0 ? (object) SAP_Module.Calculation2012.Calculation.CO2_Emissions_12a.Box272 : (object) SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box383;
          dataRow["Water Fuel Requirement (DER)"] = SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9a.Box219 != 0.0 ? (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9a.Box219, 2) : (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9b.Box312 + SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9b.Box310a + SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9b.Box310b + SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9b.Box310c + SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9b.Box310d + SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9b.Box310aW + SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9b.Box310bW + SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9b.Box310cW + SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9b.Box310dW + SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9b.Box310eW + SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9b.Box310e, 2);
          if (SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9a.Box211 == 0.0)
          {
            dataRow["Main Heating Fuel Requirement (DER)"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9b.Box307a + SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9b.Box307b + SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9b.Box307c + SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9b.Box307d + SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9b.Box307e, 2);
            dataRow["Secondary Heating Fuel Requirement (DER)"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9b.Box309, 2);
            dataRow["Secondary Main Heating Fuel Requirement (DER)"] = (object) 0;
            dataRow["Electricity Pumps Fans Requirement (DER)"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9b.Box331, 2);
            dataRow["Electricity Lighting Requirement (DER)"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9b.Box332, 2);
            dataRow["PV Energy Produced (DER)"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9b.Box333, 2);
            dataRow["Wind Energy Produced (DER)"] = (object) SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9b.Box334;
          }
          else
          {
            dataRow["Main Heating Fuel Requirement (DER)"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9a.Box211, 2);
            dataRow["Secondary Main Heating Fuel Requirement (DER)"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9a.Box213, 2);
            dataRow["Secondary Heating Fuel Requirement (DER)"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9a.Box215, 2);
            dataRow["Electricity Pumps Fans Requirement (DER)"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9a.Box231, 2);
            dataRow["Electricity Lighting Requirement (DER)"] = (object) SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9a.Box232;
            dataRow["PV Energy Produced (DER)"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9a.Box233, 2);
            dataRow["Wind Energy Produced (DER)"] = (object) SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9a.Box234;
          }
          dataRow["Total CO2 (DER)"] = SAP_Module.CalcualtionDER2012.Calculation.CO2_Emissions_12a.Box273 != 0.0 ? (object) SAP_Module.CalcualtionDER2012.Calculation.CO2_Emissions_12a.Box272 : (object) SAP_Module.CalcualtionDER2012.Calculation.CO2_Emissions_12b.Box383;
          dataRow["Water Fuel Requirement (TER)"] = SAP_Module.CalcualtionTER2012.Calculation.Energy_Requirements_9a.Box219 != 0.0 ? (object) Math.Round(SAP_Module.CalcualtionTER2012.Calculation.Energy_Requirements_9a.Box219, 2) : (object) Math.Round(SAP_Module.CalcualtionTER2012.Calculation.Energy_Requirements_9b.Box312 + SAP_Module.CalcualtionTER2012.Calculation.Energy_Requirements_9b.Box310a + SAP_Module.CalcualtionTER2012.Calculation.Energy_Requirements_9b.Box310b + SAP_Module.CalcualtionTER2012.Calculation.Energy_Requirements_9b.Box310c + SAP_Module.CalcualtionTER2012.Calculation.Energy_Requirements_9b.Box310d + SAP_Module.CalcualtionTER2012.Calculation.Energy_Requirements_9b.Box310e, 2);
          if (SAP_Module.CalcualtionTER2012.Calculation.Energy_Requirements_9a.Box211 == 0.0)
          {
            dataRow["Main Heating Fuel Requirement (TER)"] = (object) Math.Round(SAP_Module.CalcualtionTER2012.Calculation.Energy_Requirements_9b.Box307a + SAP_Module.CalcualtionTER2012.Calculation.Energy_Requirements_9b.Box307b + SAP_Module.CalcualtionTER2012.Calculation.Energy_Requirements_9b.Box307c + SAP_Module.CalcualtionTER2012.Calculation.Energy_Requirements_9b.Box307d + SAP_Module.CalcualtionTER2012.Calculation.Energy_Requirements_9b.Box307e, 2);
            dataRow["Secondary Heating Fuel Requirement (TER)"] = (object) Math.Round(SAP_Module.CalcualtionTER2012.Calculation.Energy_Requirements_9b.Box309, 2);
            dataRow["Secondary Main Heating Fuel Requirement (TER)"] = (object) 0;
            dataRow["Electricity Pumps Fans Requirement (TER)"] = (object) Math.Round(SAP_Module.CalcualtionTER2012.Calculation.Energy_Requirements_9b.Box331, 2);
            dataRow["Electricity Lighting Requirement (TER)"] = (object) Math.Round(SAP_Module.CalcualtionTER2012.Calculation.Energy_Requirements_9b.Box332, 2);
            dataRow["PV Energy Produced (TER)"] = (object) Math.Round(SAP_Module.CalcualtionTER2012.Calculation.Energy_Requirements_9b.Box333, 2);
            dataRow["Wind Energy Produced (TER)"] = (object) SAP_Module.CalcualtionTER2012.Calculation.Energy_Requirements_9b.Box334;
          }
          else
          {
            dataRow["Main Heating Fuel Requirement (TER)"] = (object) Math.Round(SAP_Module.CalcualtionTER2012.Calculation.Energy_Requirements_9a.Box211, 2);
            dataRow["Secondary Main Heating Fuel Requirement (TER)"] = (object) Math.Round(SAP_Module.CalcualtionTER2012.Calculation.Energy_Requirements_9a.Box213, 2);
            dataRow["Secondary Heating Fuel Requirement (TER)"] = (object) Math.Round(SAP_Module.CalcualtionTER2012.Calculation.Energy_Requirements_9a.Box215, 2);
            dataRow["Electricity Pumps Fans Requirement (TER)"] = (object) Math.Round(SAP_Module.CalcualtionTER2012.Calculation.Energy_Requirements_9a.Box231, 2);
            dataRow["Electricity Lighting Requirement (TER)"] = (object) SAP_Module.CalcualtionTER2012.Calculation.Energy_Requirements_9a.Box232;
            dataRow["PV Energy Produced (TER)"] = (object) Math.Round(SAP_Module.CalcualtionTER2012.Calculation.Energy_Requirements_9a.Box233, 2);
            dataRow["Wind Energy Produced (TER)"] = (object) Math.Round(SAP_Module.CalcualtionTER2012.Calculation.Energy_Requirements_9a.Box234, 2);
          }
          if (SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9a.Box211 == 0.0)
          {
            dataRow["Main Heating Fuel Requirement (EPC_cost)"] = (object) Math.Round(SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9b.Box307a + SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9b.Box307b + SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9b.Box307c + SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9b.Box307d + SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9b.Box307e, 2);
            dataRow["Secondary Heating Fuel Requirement (EPC_cost)"] = (object) Math.Round(SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9b.Box309, 2);
            dataRow["Secondary Main Heating Fuel Requirement (EPC_cost)"] = (object) 0;
            dataRow["Electricity Pumps Fans Requirement (EPC_cost)"] = (object) Math.Round(SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9b.Box331, 2);
            dataRow["Electricity Lighting Requirement (EPC_cost)"] = (object) Math.Round(SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9b.Box332, 2);
            dataRow["PV Energy Produced (EPC_cost)"] = (object) Math.Round(SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9b.Box333, 2);
            dataRow["Wind Energy Produced (EPC_cost)"] = (object) SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9b.Box334;
          }
          else
          {
            dataRow["Main Heating Fuel Requirement (EPC_cost)"] = (object) Math.Round(SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9a.Box211, 2);
            dataRow["Secondary Main Heating Fuel Requirement (EPC_cost)"] = (object) Math.Round(SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9a.Box213, 2);
            dataRow["Secondary Heating Fuel Requirement (EPC_cost)"] = (object) Math.Round(SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9a.Box215, 2);
            dataRow["Electricity Pumps Fans Requirement (EPC_cost)"] = (object) Math.Round(SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9a.Box231, 2);
            dataRow["Electricity Lighting Requirement (EPC_cost)"] = (object) SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9a.Box232;
            dataRow["PV Energy Produced (EPC_cost)"] = (object) Math.Round(SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9a.Box233, 2);
            dataRow["Wind Energy Produced (EPC_cost)"] = (object) Math.Round(SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9a.Box234, 2);
          }
          dataRow["Water Fuel Requirement (EPC_cost)"] = SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9a.Box219 != 0.0 ? (object) Math.Round(SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9a.Box219, 2) : (object) Math.Round(SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9b.Box312 + SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9b.Box310a + SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9b.Box310b + SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9b.Box310c + SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9b.Box310d + SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9b.Box310e, 2);
          dataRow["Total CO2 (TER)"] = SAP_Module.CalcualtionTER2012.Calculation.CO2_Emissions_12a.Box273 != 0.0 ? (object) Math.Round(SAP_Module.CalcualtionTER2012.Calculation.CO2_Emissions_12a.Box272, 2) : (object) Math.Round(SAP_Module.CalcualtionTER2012.Calculation.CO2_Emissions_12b.Box383, 2);
          dataRow["Building Regulations Results"] = Compliance.CheckCompliance(House) ? (object) "Yes" : (object) "No";
          if (SAP_Module.Proj.Dwellings[House].Cooling.Include)
            dataRow["Space Cooling"] = (object) SAP_Module.CalcualtionDER2012.Calculation.Space_cooling_requirement.Box108;
          try
          {
            dataRow["HLP"] = (object) SAP_Module.CalcualtionDER2012.Calculation.HeatLoss.Box40;
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
          string str1 = "";
          string str2 = "";
          string str3 = "";
          string str4 = "";
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.InforSource, "Boiler Database", false) == 0)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SGroup, "Gas boilers and oil boilers", false) == 0)
            {
              List<PCDF.SEDBUK> boilers = SAP_Module.PCDFData.Boilers;
              Func<PCDF.SEDBUK, bool> predicate;
              // ISSUE: reference to a compiler-generated field
              if (Key_Results._Closure\u0024__.\u0024I125\u002D0 != null)
              {
                // ISSUE: reference to a compiler-generated field
                predicate = Key_Results._Closure\u0024__.\u0024I125\u002D0;
              }
              else
              {
                // ISSUE: reference to a compiler-generated field
                Key_Results._Closure\u0024__.\u0024I125\u002D0 = predicate = (Func<PCDF.SEDBUK, bool>) (b => b.ID.Equals(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SEDBUK));
              }
              PCDF.SEDBUK sedbuk = boilers.Where<PCDF.SEDBUK>(predicate).SingleOrDefault<PCDF.SEDBUK>();
              if (sedbuk != null)
              {
                str1 = sedbuk.BrandName;
                str3 = sedbuk.ModelName;
                str2 = sedbuk.ModelQualifier;
                str4 = sedbuk.ID;
              }
            }
            else if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SGroup.Contains("pumps"))
            {
              List<PCDF.HeatPump> heatPumps = SAP_Module.PCDFData.HeatPumps;
              Func<PCDF.HeatPump, bool> predicate;
              // ISSUE: reference to a compiler-generated field
              if (Key_Results._Closure\u0024__.\u0024I125\u002D1 != null)
              {
                // ISSUE: reference to a compiler-generated field
                predicate = Key_Results._Closure\u0024__.\u0024I125\u002D1;
              }
              else
              {
                // ISSUE: reference to a compiler-generated field
                Key_Results._Closure\u0024__.\u0024I125\u002D1 = predicate = (Func<PCDF.HeatPump, bool>) (b => b.ID.Equals(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SEDBUK));
              }
              PCDF.HeatPump heatPump = heatPumps.Where<PCDF.HeatPump>(predicate).SingleOrDefault<PCDF.HeatPump>();
              if (heatPump != null)
              {
                str1 = heatPump.Brand;
                str3 = heatPump.Model;
                str2 = heatPump.Qualifier;
                str4 = heatPump.ID;
              }
            }
            else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SGroup, "Micro-cogeneration (micro-CHP)", false) == 0)
            {
              List<PCDF.CHP> chPs = SAP_Module.PCDFData.CHPs;
              Func<PCDF.CHP, bool> predicate;
              // ISSUE: reference to a compiler-generated field
              if (Key_Results._Closure\u0024__.\u0024I125\u002D2 != null)
              {
                // ISSUE: reference to a compiler-generated field
                predicate = Key_Results._Closure\u0024__.\u0024I125\u002D2;
              }
              else
              {
                // ISSUE: reference to a compiler-generated field
                Key_Results._Closure\u0024__.\u0024I125\u002D2 = predicate = (Func<PCDF.CHP, bool>) (b => b.ID.Equals(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SEDBUK));
              }
              PCDF.CHP chp = chPs.Where<PCDF.CHP>(predicate).SingleOrDefault<PCDF.CHP>();
              if (chp != null)
              {
                str1 = chp.Brand;
                str3 = chp.Model;
                str2 = chp.Qualifier;
                str4 = chp.ID;
              }
            }
            else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SGroup, "Solid fuel boilers", false) == 0)
            {
              List<PCDF.SEDBUK_Solid> solidBoilers = SAP_Module.PCDFData.Solid_Boilers;
              Func<PCDF.SEDBUK_Solid, bool> predicate;
              // ISSUE: reference to a compiler-generated field
              if (Key_Results._Closure\u0024__.\u0024I125\u002D3 != null)
              {
                // ISSUE: reference to a compiler-generated field
                predicate = Key_Results._Closure\u0024__.\u0024I125\u002D3;
              }
              else
              {
                // ISSUE: reference to a compiler-generated field
                Key_Results._Closure\u0024__.\u0024I125\u002D3 = predicate = (Func<PCDF.SEDBUK_Solid, bool>) (b => b.ID.Equals(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SEDBUK));
              }
              PCDF.SEDBUK_Solid sedbukSolid = solidBoilers.Where<PCDF.SEDBUK_Solid>(predicate).SingleOrDefault<PCDF.SEDBUK_Solid>();
              if (sedbukSolid != null)
              {
                str1 = sedbukSolid.BrandName;
                str3 = sedbukSolid.ModelName;
                str2 = sedbukSolid.ModelQualifier;
                str4 = sedbukSolid.ID;
              }
            }
          }
          dataRow["Boiler Make"] = (object) str1;
          dataRow["Boiler Model"] = (object) str3;
          dataRow["Model Qual"] = (object) str2;
          dataRow["Boiler Index"] = (object) str4;
          dataRow["Cylinder Size "] = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.Volume;
          if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.WWHRS.Include)
            dataRow["WWHR"] = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.WWHRS.Systems[0].SystemsRef;
          if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.FGHRS.Include)
            dataRow["FGHR"] = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.FGHRS.IndexNo;
          if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].IncludeMainHeating2)
            dataRow["Secondary Heating"] = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SAPTableCode <= 0 ? (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SEDBUK : (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SAPTableCode;
          dataRow["Calculated y-value"] = (object) Math.Round(SAP_Module.Calculation2012.Calculation.HeatLoss.Box36 / SAP_Module.Calculation2012.Calculation.HeatLoss.Box31, 3);
          dataRow["Orientation"] = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Orientation;
          double num2 = 0.0;
          if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Photovoltaic.Inlcude)
          {
            int num3 = checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Photovoltaic.Photovoltaics.Length - 1);
            int index = 0;
            while (index <= num3)
            {
              num2 += (double) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Photovoltaic.Photovoltaics[index].PPower;
              checked { ++index; }
            }
          }
          dataRow["PV Kwp"] = (object) num2;
          dataRow["box64"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Water_heating.Box64, 1);
          dataRow["box98"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Space_heating_requirement.Box98, 1);
          dataRow["Ventilation Type"] = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.MechVent;
          dataRow["Product Name"] = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.ProductID <= 0 ? (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.MVDetails.ProductName : (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Parameters;
          dataRow["Vent System"] = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.ProductID;
          dataRow["overheating June"] = (object) SAP_Module.OverHeat.AppendixP.Likelihood_June;
          dataRow["overheating July"] = (object) SAP_Module.OverHeat.AppendixP.Likelihood_July;
          dataRow["overheating August"] = (object) SAP_Module.OverHeat.AppendixP.Likelihood_Aug;
          SAP_Module.DoCodereport = true;
          SAP_Module.CalcualtionDER_CSH.DTER = true;
          Functions.GetDERDwelling_CSH("Standard");
          SAP_Module.CalcualtionDER_CSH.Dwelling = SAP_Module.DERDwelling_CSH;
          new Ene1().Calc();
          dataRow["Cooking"] = (object) Math.Round(SAP_Module.CalcualtionDER_CSH.Calculation.AssessmentLZC2012.ZC2, 2);
          dataRow["Appliance"] = (object) Math.Round(SAP_Module.CalcualtionDER_CSH.Calculation.AssessmentLZC2012.ZC3, 2);
          dataRow["Total Energy cost"] = SAP_Module.Calculation2012.Calculation.Actual_costs_10a.Box255 <= 0.0 ? (object) Math.Round(SAP_Module.Calculation2012.Calculation.Actual_costs_10b.Box355, 1) : (object) Math.Round(SAP_Module.Calculation2012.Calculation.Actual_costs_10a.Box255, 1);
          this.dtResults.Rows.Add(row);
        }
        checked { ++House; }
      }
      SAP_Module.CurrDwelling = -1;
      SAP_Module.RoundFigure = roundFigure;
    }

    private void FillResultsSAP()
    {
      int roundFigure = SAP_Module.RoundFigure;
      SAP_Module.RoundFigure = 2;
      int num1 = checked (SAP_Module.Proj.NoOfDwells - 1);
      int House = 0;
      while (House <= num1)
      {
        SAP_Module.CurrDwelling = House;
        if (Validation.LodgementStatusCheck(House))
        {
          DataRow row = this.dtResultsSAP.NewRow();
          DataRow dataRow = row;
          dataRow["Dwelling"] = (object) SAP_Module.Proj.Dwellings[House].Name;
          dataRow["Reference"] = (object) SAP_Module.Proj.Dwellings[House].Reference;
          dataRow["Status"] = (object) SAP_Module.Proj.Dwellings[House].Status;
          dataRow["Property Type"] = (object) SAP_Module.Proj.Dwellings[House].PropertyType;
          dataRow["Built Form"] = (object) SAP_Module.Proj.Dwellings[House].BuildForm;
          dataRow["Address1"] = (object) SAP_Module.Proj.Dwellings[House].Address.Line1;
          dataRow["Address2"] = (object) SAP_Module.Proj.Dwellings[House].Address.Line2;
          dataRow["Address3"] = (object) SAP_Module.Proj.Dwellings[House].Address.Line3;
          dataRow["City"] = (object) SAP_Module.Proj.Dwellings[House].Address.City;
          dataRow["Postcode"] = (object) SAP_Module.Proj.Dwellings[House].Address.PostCost;
          dataRow["UPRN"] = (object) SAP_Module.Proj.Dwellings[House].UPRN;
          dataRow["Country"] = (object) SAP_Module.Proj.Dwellings[House].Address.Country;
          Functions.CalculateNow();
          if (SAP_Module.Calculation2012.Calculation.SAP_rating_11a.Box258 == 0.0)
            dataRow["SAP"] = (object) (SAP_Module.Calculation2012.Calculation.SAP_rating_11b.SAPBand + " " + Conversions.ToString(SAP_Module.Calculation2012.Calculation.SAP_rating_11b.SAPRating) + " (" + Conversions.ToString(SAP_Module.Calculation2012.Calculation.SAP_rating_11b.Box358) + ")");
          else
            dataRow["SAP"] = (object) (SAP_Module.Calculation2012.Calculation.SAP_rating_11a.SAPBand + " " + Conversions.ToString(SAP_Module.Calculation2012.Calculation.SAP_rating_11a.SAPRating) + " (" + Conversions.ToString(SAP_Module.Calculation2012.Calculation.SAP_rating_11a.Box258) + ")");
          Calc2012 calc2012_1 = new Calc2012()
          {
            DTER = true
          };
          calc2012_1.SETPCDF(SAP_Module.PCDFData);
          calc2012_1.Dwelling = SAP_Module.DERDwelling;
          if (calc2012_1.Calculation.CO2_Emissions_12a.Box273 == 0.0)
          {
            dataRow["DER"] = (object) calc2012_1.Calculation.CO2_Emissions_12b.Box384;
            dataRow["EI"] = (object) SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box385;
          }
          else
          {
            dataRow["DER"] = (object) Math.Round(calc2012_1.Calculation.CO2_Emissions_12a.Box273, 2);
            dataRow["EI"] = (object) SAP_Module.Calculation2012.Calculation.CO2_Emissions_12a.EIValue;
          }
          dataRow["TER"] = (object) Functions.TER();
          Calc2012 calc2012_2 = new Calc2012();
          SAP_Module.Dwelling feeDwelling1 = Functions.GetFEEDwelling(ref SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling]);
          calc2012_2.SETPCDF(SAP_Module.PCDFData);
          calc2012_2.IsFabricEfficiency = true;
          calc2012_2.Dwelling = feeDwelling1;
          Calc2012 calc2012_3 = new Calc2012();
          SAP_Module.Dwelling feeDwelling2 = Functions.GetFEEDwelling(ref SAP_Module.TERDwelling);
          calc2012_3.SETPCDF(SAP_Module.PCDFData);
          calc2012_3.IsFabricEfficiency = true;
          calc2012_3.Dwelling = feeDwelling2;
          SAP_Module.CalcRound = true;
          SAP_Module.RoundFigure = 2;
          Calc2012 calc2012_4 = new Calc2012();
          dataRow["DFEE"] = (object) Math.Round(SAP_Module.CalculationFabric.Calculation.Fabric_Energy_Efficiency.Box109, 1);
          Calc2012 calc2012_5 = new Calc2012();
          calc2012_5.SETPCDF(SAP_Module.PCDFData);
          calc2012_5.IsFabricEfficiency = true;
          SAP_Module.CalcRound = false;
          calc2012_5.Dwelling = Functions.GetFEEDwelling(ref SAP_Module.TERDwelling);
          SAP_Module.CalcRound = true;
          dataRow["TFEE"] = (object) Math.Round(1.15 * calc2012_5.Calculation.Fabric_Energy_Efficiency.Box109, 1);
          dataRow["Percent Improvement"] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet((object) null, typeof (Math), "Round", new object[2]
          {
            Microsoft.VisualBasic.CompilerServices.Operators.MultiplyObject((object) 100, Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject((object) 1, Microsoft.VisualBasic.CompilerServices.Operators.DivideObject(dataRow["DER"], (object) Functions.TER()))),
            (object) 2
          }, (string[]) null, (System.Type[]) null, (bool[]) null));
          dataRow["Total Floor Area"] = (object) calc2012_1.Calculation.Dimensions.Box4;
          dataRow["FEE"] = (object) Math.Round(SAP_Module.CalculationFabric.Calculation.Fabric_Energy_Efficiency.Box109, 2);
          dataRow["Air permeability"] = (object) Math.Round(calc2012_1.Calculation.Ventilation.Box17, 2);
          if (SAP_Module.Calculation2012.Calculation.Energy_Requirements_9a.Box211 == 0.0)
          {
            dataRow["Main Heating Fuel Requirement (SAP)"] = (object) Math.Round(SAP_Module.Calculation2012.Calculation.Energy_Requirements_9b.Box307a + SAP_Module.Calculation2012.Calculation.Energy_Requirements_9b.Box307b + SAP_Module.Calculation2012.Calculation.Energy_Requirements_9b.Box307c + SAP_Module.Calculation2012.Calculation.Energy_Requirements_9b.Box307d + SAP_Module.Calculation2012.Calculation.Energy_Requirements_9b.Box307e, 2);
            dataRow["Secondary Heating Fuel Requirement (SAP)"] = (object) Math.Round(SAP_Module.Calculation2012.Calculation.Energy_Requirements_9b.Box309, 2);
            dataRow["Secondary Main Heating Fuel Requirement (SAP)"] = (object) 0;
            dataRow["Electricity Pumps Fans Requirement (SAP)"] = (object) Math.Round(SAP_Module.Calculation2012.Calculation.Energy_Requirements_9b.Box331, 2);
            dataRow["Electricity Lighting Requirement (SAP)"] = (object) Math.Round(SAP_Module.Calculation2012.Calculation.Energy_Requirements_9b.Box332, 2);
            dataRow["PV Energy Produced (SAP)"] = (object) Math.Round(SAP_Module.Calculation2012.Calculation.Energy_Requirements_9b.Box333, 2);
            dataRow["Wind Energy Produced (SAP)"] = (object) SAP_Module.Calculation2012.Calculation.Energy_Requirements_9b.Box334;
          }
          else
          {
            dataRow["Main Heating Fuel Requirement (SAP)"] = (object) Math.Round(SAP_Module.Calculation2012.Calculation.Energy_Requirements_9a.Box211, 2);
            dataRow["Secondary Main Heating Fuel Requirement (SAP)"] = (object) Math.Round(SAP_Module.Calculation2012.Calculation.Energy_Requirements_9a.Box213, 2);
            dataRow["Secondary Heating Fuel Requirement (SAP)"] = (object) Math.Round(SAP_Module.Calculation2012.Calculation.Energy_Requirements_9a.Box215, 2);
            dataRow["Electricity Pumps Fans Requirement (SAP)"] = (object) Math.Round(SAP_Module.Calculation2012.Calculation.Energy_Requirements_9a.Box231, 2);
            dataRow["Electricity Lighting Requirement (SAP)"] = (object) Math.Round(SAP_Module.Calculation2012.Calculation.Energy_Requirements_9a.Box232, 2);
            dataRow["PV Energy Produced (SAP)"] = (object) Math.Round(SAP_Module.Calculation2012.Calculation.Energy_Requirements_9a.Box233, 2);
            dataRow["Wind Energy Produced (SAP)"] = (object) SAP_Module.Calculation2012.Calculation.Energy_Requirements_9a.Box234;
          }
          dataRow["Water Fuel Requirement (SAP)"] = SAP_Module.Calculation2012.Calculation.Energy_Requirements_9a.Box219 != 0.0 ? (object) Math.Round(SAP_Module.Calculation2012.Calculation.Energy_Requirements_9a.Box219, 2) : (object) Math.Round(SAP_Module.Calculation2012.Calculation.Energy_Requirements_9b.Box312 + SAP_Module.Calculation2012.Calculation.Energy_Requirements_9b.Box310a + SAP_Module.Calculation2012.Calculation.Energy_Requirements_9b.Box310b + SAP_Module.Calculation2012.Calculation.Energy_Requirements_9b.Box310c + SAP_Module.Calculation2012.Calculation.Energy_Requirements_9b.Box310d + SAP_Module.Calculation2012.Calculation.Energy_Requirements_9b.Box310aW + SAP_Module.Calculation2012.Calculation.Energy_Requirements_9b.Box310bW + SAP_Module.Calculation2012.Calculation.Energy_Requirements_9b.Box310cW + SAP_Module.Calculation2012.Calculation.Energy_Requirements_9b.Box310dW + SAP_Module.Calculation2012.Calculation.Energy_Requirements_9b.Box310eW + SAP_Module.Calculation2012.Calculation.Energy_Requirements_9b.Box310e, 2);
          dataRow["Total CO2 (SAP)"] = SAP_Module.Calculation2012.Calculation.CO2_Emissions_12a.Box273 != 0.0 ? (object) SAP_Module.Calculation2012.Calculation.CO2_Emissions_12a.Box272 : (object) SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box383;
          dataRow["Building Regulations Results"] = Compliance.CheckCompliance(House) ? (object) "Yes" : (object) "No";
          if (SAP_Module.Proj.Dwellings[House].Cooling.Include)
            dataRow["Space Cooling"] = (object) calc2012_1.Calculation.Space_cooling_requirement.Box108;
          try
          {
            dataRow["HLP"] = (object) calc2012_1.Calculation.HeatLoss.Box40;
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
          string str1 = "";
          string str2 = "";
          string str3 = "";
          string str4 = "";
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.InforSource, "Boiler Database", false) == 0)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SGroup, "Gas boilers and oil boilers", false) == 0)
            {
              List<PCDF.SEDBUK> boilers = SAP_Module.PCDFData.Boilers;
              Func<PCDF.SEDBUK, bool> predicate;
              // ISSUE: reference to a compiler-generated field
              if (Key_Results._Closure\u0024__.\u0024I126\u002D0 != null)
              {
                // ISSUE: reference to a compiler-generated field
                predicate = Key_Results._Closure\u0024__.\u0024I126\u002D0;
              }
              else
              {
                // ISSUE: reference to a compiler-generated field
                Key_Results._Closure\u0024__.\u0024I126\u002D0 = predicate = (Func<PCDF.SEDBUK, bool>) (b => b.ID.Equals(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SEDBUK));
              }
              PCDF.SEDBUK sedbuk = boilers.Where<PCDF.SEDBUK>(predicate).SingleOrDefault<PCDF.SEDBUK>();
              if (sedbuk != null)
              {
                str1 = sedbuk.BrandName;
                str3 = sedbuk.ModelName;
                str2 = sedbuk.ModelQualifier;
                str4 = sedbuk.ID;
              }
            }
            else if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SGroup.Contains("pumps"))
            {
              List<PCDF.HeatPump> heatPumps = SAP_Module.PCDFData.HeatPumps;
              Func<PCDF.HeatPump, bool> predicate;
              // ISSUE: reference to a compiler-generated field
              if (Key_Results._Closure\u0024__.\u0024I126\u002D1 != null)
              {
                // ISSUE: reference to a compiler-generated field
                predicate = Key_Results._Closure\u0024__.\u0024I126\u002D1;
              }
              else
              {
                // ISSUE: reference to a compiler-generated field
                Key_Results._Closure\u0024__.\u0024I126\u002D1 = predicate = (Func<PCDF.HeatPump, bool>) (b => b.ID.Equals(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SEDBUK));
              }
              PCDF.HeatPump heatPump = heatPumps.Where<PCDF.HeatPump>(predicate).SingleOrDefault<PCDF.HeatPump>();
              if (heatPump != null)
              {
                str1 = heatPump.Brand;
                str3 = heatPump.Model;
                str2 = heatPump.Qualifier;
                str4 = heatPump.ID;
              }
            }
            else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SGroup, "Micro-cogeneration (micro-CHP)", false) == 0)
            {
              List<PCDF.CHP> chPs = SAP_Module.PCDFData.CHPs;
              Func<PCDF.CHP, bool> predicate;
              // ISSUE: reference to a compiler-generated field
              if (Key_Results._Closure\u0024__.\u0024I126\u002D2 != null)
              {
                // ISSUE: reference to a compiler-generated field
                predicate = Key_Results._Closure\u0024__.\u0024I126\u002D2;
              }
              else
              {
                // ISSUE: reference to a compiler-generated field
                Key_Results._Closure\u0024__.\u0024I126\u002D2 = predicate = (Func<PCDF.CHP, bool>) (b => b.ID.Equals(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SEDBUK));
              }
              PCDF.CHP chp = chPs.Where<PCDF.CHP>(predicate).SingleOrDefault<PCDF.CHP>();
              if (chp != null)
              {
                str1 = chp.Brand;
                str3 = chp.Model;
                str2 = chp.Qualifier;
                str4 = chp.ID;
              }
            }
            else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SGroup, "Solid fuel boilers", false) == 0)
            {
              List<PCDF.SEDBUK_Solid> solidBoilers = SAP_Module.PCDFData.Solid_Boilers;
              Func<PCDF.SEDBUK_Solid, bool> predicate;
              // ISSUE: reference to a compiler-generated field
              if (Key_Results._Closure\u0024__.\u0024I126\u002D3 != null)
              {
                // ISSUE: reference to a compiler-generated field
                predicate = Key_Results._Closure\u0024__.\u0024I126\u002D3;
              }
              else
              {
                // ISSUE: reference to a compiler-generated field
                Key_Results._Closure\u0024__.\u0024I126\u002D3 = predicate = (Func<PCDF.SEDBUK_Solid, bool>) (b => b.ID.Equals(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SEDBUK));
              }
              PCDF.SEDBUK_Solid sedbukSolid = solidBoilers.Where<PCDF.SEDBUK_Solid>(predicate).SingleOrDefault<PCDF.SEDBUK_Solid>();
              if (sedbukSolid != null)
              {
                str1 = sedbukSolid.BrandName;
                str3 = sedbukSolid.ModelName;
                str2 = sedbukSolid.ModelQualifier;
                str4 = sedbukSolid.ID;
              }
            }
          }
          dataRow["Boiler Make"] = (object) str1;
          dataRow["Boiler Model"] = (object) str3;
          dataRow["Model Qual"] = (object) str2;
          dataRow["Boiler Index"] = (object) str4;
          dataRow["Cylinder Size "] = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.Volume;
          if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.WWHRS.Include)
            dataRow["WWHR"] = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.WWHRS.Systems[0].SystemsRef;
          if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.FGHRS.Include)
            dataRow["FGHR"] = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.FGHRS.IndexNo;
          if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].IncludeMainHeating2)
            dataRow["Secondary Heating"] = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SAPTableCode <= 0 ? (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SEDBUK : (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SAPTableCode;
          dataRow["Calculated y-value"] = (object) Math.Round(SAP_Module.Calculation2012.Calculation.HeatLoss.Box36 / SAP_Module.Calculation2012.Calculation.HeatLoss.Box31, 3);
          dataRow["Orientation"] = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Orientation;
          double num2 = 0.0;
          if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Photovoltaic.Inlcude)
          {
            int num3 = checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Photovoltaic.Photovoltaics.Length - 1);
            int index = 0;
            while (index <= num3)
            {
              num2 += (double) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Photovoltaic.Photovoltaics[index].PPower;
              checked { ++index; }
            }
          }
          dataRow["PV Kwp"] = (object) num2;
          dataRow["box64"] = (object) Math.Round(SAP_Module.Calculation2012.Calculation.Water_heating.Box64, 1);
          dataRow["box98"] = (object) Math.Round(SAP_Module.Calculation2012.Calculation.Space_heating_requirement.Box98, 1);
          dataRow["Ventilation Type"] = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.MechVent;
          dataRow["Product Name"] = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.ProductID <= 0 ? (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.MVDetails.ProductName : (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Parameters;
          dataRow["Vent System"] = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.ProductID;
          dataRow["overheating June"] = (object) SAP_Module.OverHeat.AppendixP.Likelihood_June;
          dataRow["overheating July"] = (object) SAP_Module.OverHeat.AppendixP.Likelihood_July;
          dataRow["overheating August"] = (object) SAP_Module.OverHeat.AppendixP.Likelihood_Aug;
          new Ene1().Calc();
          dataRow["Cooking"] = (object) Math.Round(SAP_Module.CalcualtionDER_CSH.Calculation.AssessmentLZC2012.ZC2, 2);
          dataRow["Appliance"] = (object) Math.Round(SAP_Module.CalcualtionDER_CSH.Calculation.AssessmentLZC2012.ZC3, 2);
          dataRow["Total Energy cost"] = SAP_Module.Calculation2012.Calculation.Actual_costs_10a.Box255 <= 0.0 ? (object) Math.Round(SAP_Module.Calculation2012.Calculation.Actual_costs_10b.Box355, 1) : (object) Math.Round(SAP_Module.Calculation2012.Calculation.Actual_costs_10a.Box255, 1);
          try
          {
            this.dtResultsSAP.Rows.Add(row);
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
        }
        checked { ++House; }
      }
      SAP_Module.CurrDwelling = -1;
      SAP_Module.RoundFigure = roundFigure;
    }

    private void FillResultsDER()
    {
      int roundFigure = SAP_Module.RoundFigure;
      SAP_Module.RoundFigure = 2;
      int num1 = checked (SAP_Module.Proj.NoOfDwells - 1);
      int House = 0;
      while (House <= num1)
      {
        SAP_Module.CurrDwelling = House;
        if (Validation.LodgementStatusCheck(House))
        {
          DataRow row = this.dtResultsDER.NewRow();
          DataRow dataRow = row;
          dataRow["Dwelling"] = (object) SAP_Module.Proj.Dwellings[House].Name;
          dataRow["Reference"] = (object) SAP_Module.Proj.Dwellings[House].Reference;
          dataRow["Status"] = (object) SAP_Module.Proj.Dwellings[House].Status;
          dataRow["Property Type"] = (object) SAP_Module.Proj.Dwellings[House].PropertyType;
          dataRow["Built Form"] = (object) SAP_Module.Proj.Dwellings[House].BuildForm;
          dataRow["Address1"] = (object) SAP_Module.Proj.Dwellings[House].Address.Line1;
          dataRow["Address2"] = (object) SAP_Module.Proj.Dwellings[House].Address.Line2;
          dataRow["Address3"] = (object) SAP_Module.Proj.Dwellings[House].Address.Line3;
          dataRow["City"] = (object) SAP_Module.Proj.Dwellings[House].Address.City;
          dataRow["Postcode"] = (object) SAP_Module.Proj.Dwellings[House].Address.PostCost;
          dataRow["UPRN"] = (object) SAP_Module.Proj.Dwellings[House].UPRN;
          dataRow["Country"] = (object) SAP_Module.Proj.Dwellings[House].Address.Country;
          Functions.CalculateNow();
          if (SAP_Module.Calculation2012.Calculation.SAP_rating_11a.Box258 == 0.0)
            dataRow["SAP"] = (object) (SAP_Module.Calculation2012.Calculation.SAP_rating_11b.SAPBand + " " + Conversions.ToString(SAP_Module.Calculation2012.Calculation.SAP_rating_11b.SAPRating) + " (" + Conversions.ToString(SAP_Module.Calculation2012.Calculation.SAP_rating_11b.Box358) + ")");
          else
            dataRow["SAP"] = (object) (SAP_Module.Calculation2012.Calculation.SAP_rating_11a.SAPBand + " " + Conversions.ToString(SAP_Module.Calculation2012.Calculation.SAP_rating_11a.SAPRating) + " (" + Conversions.ToString(SAP_Module.Calculation2012.Calculation.SAP_rating_11a.Box258) + ")");
          if (SAP_Module.CalcualtionDER2012.Calculation.CO2_Emissions_12a.Box273 == 0.0)
          {
            dataRow["DER"] = (object) SAP_Module.CalcualtionDER2012.Calculation.CO2_Emissions_12b.Box384;
            dataRow["EI"] = (object) SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box385;
          }
          else
          {
            dataRow["DER"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.CO2_Emissions_12a.Box273, 2);
            dataRow["EI"] = (object) SAP_Module.Calculation2012.Calculation.CO2_Emissions_12a.EIValue;
          }
          dataRow["TER"] = (object) Functions.TER();
          Calc2012 calc2012_1 = new Calc2012();
          SAP_Module.Dwelling feeDwelling1 = Functions.GetFEEDwelling(ref SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling]);
          calc2012_1.SETPCDF(SAP_Module.PCDFData);
          calc2012_1.IsFabricEfficiency = true;
          calc2012_1.Dwelling = feeDwelling1;
          Calc2012 calc2012_2 = new Calc2012();
          SAP_Module.Dwelling feeDwelling2 = Functions.GetFEEDwelling(ref SAP_Module.TERDwelling);
          calc2012_2.SETPCDF(SAP_Module.PCDFData);
          calc2012_2.IsFabricEfficiency = true;
          calc2012_2.Dwelling = feeDwelling2;
          SAP_Module.CalcRound = true;
          SAP_Module.RoundFigure = 2;
          Calc2012 calc2012_3 = new Calc2012();
          dataRow["DFEE"] = (object) Math.Round(SAP_Module.CalculationFabric.Calculation.Fabric_Energy_Efficiency.Box109, 1);
          Calc2012 calc2012_4 = new Calc2012();
          calc2012_4.SETPCDF(SAP_Module.PCDFData);
          calc2012_4.IsFabricEfficiency = true;
          SAP_Module.CalcRound = false;
          calc2012_4.Dwelling = Functions.GetFEEDwelling(ref SAP_Module.TERDwelling);
          SAP_Module.CalcRound = true;
          dataRow["TFEE"] = (object) Math.Round(1.15 * calc2012_4.Calculation.Fabric_Energy_Efficiency.Box109, 1);
          dataRow["Percent Improvement"] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet((object) null, typeof (Math), "Round", new object[2]
          {
            Microsoft.VisualBasic.CompilerServices.Operators.MultiplyObject((object) 100, Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject((object) 1, Microsoft.VisualBasic.CompilerServices.Operators.DivideObject(dataRow["DER"], (object) Functions.TER()))),
            (object) 2
          }, (string[]) null, (System.Type[]) null, (bool[]) null));
          dataRow["Total Floor Area"] = (object) SAP_Module.CalcualtionDER2012.Calculation.Dimensions.Box4;
          dataRow["FEE"] = (object) Math.Round(SAP_Module.CalculationFabric.Calculation.Fabric_Energy_Efficiency.Box109, 2);
          dataRow["Air permeability"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Ventilation.Box17, 2);
          if (SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9a.Box211 == 0.0)
          {
            dataRow["Main Heating Fuel Requirement (DER)"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9b.Box307a + SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9b.Box307b + SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9b.Box307c + SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9b.Box307d + SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9b.Box307e, 2);
            dataRow["Secondary Heating Fuel Requirement (DER)"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9b.Box309, 2);
            dataRow["Secondary Main Heating Fuel Requirement (DER)"] = (object) 0;
            dataRow["Electricity Pumps Fans Requirement (DER)"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9b.Box331, 2);
            dataRow["Electricity Lighting Requirement (DER)"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9b.Box332, 2);
            dataRow["PV Energy Produced (DER)"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9b.Box333, 2);
            dataRow["Wind Energy Produced (DER)"] = (object) SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9b.Box334;
          }
          else
          {
            dataRow["Main Heating Fuel Requirement (DER)"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9a.Box211, 2);
            dataRow["Secondary Main Heating Fuel Requirement (DER)"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9a.Box213, 2);
            dataRow["Secondary Heating Fuel Requirement (DER)"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9a.Box215, 2);
            dataRow["Electricity Pumps Fans Requirement (DER)"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9a.Box231, 2);
            dataRow["Electricity Lighting Requirement (DER)"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9a.Box232, 2);
            dataRow["PV Energy Produced (DER)"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9a.Box233, 2);
            dataRow["Wind Energy Produced (DER)"] = (object) SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9a.Box234;
          }
          dataRow["Water Fuel Requirement (DER)"] = SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9a.Box219 != 0.0 ? (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9a.Box219, 2) : (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9b.Box312 + SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9b.Box310a + SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9b.Box310b + SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9b.Box310c + SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9b.Box310d + SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9b.Box310aW + SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9b.Box310bW + SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9b.Box310cW + SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9b.Box310dW + SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9b.Box310eW + SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9b.Box310e, 2);
          dataRow["Total CO2 (DER)"] = SAP_Module.CalcualtionDER2012.Calculation.CO2_Emissions_12a.Box273 != 0.0 ? (object) SAP_Module.CalcualtionDER2012.Calculation.CO2_Emissions_12a.Box272 : (object) SAP_Module.CalcualtionDER2012.Calculation.CO2_Emissions_12b.Box383;
          dataRow["Building Regulations Results"] = Compliance.CheckCompliance(House) ? (object) "Yes" : (object) "No";
          if (SAP_Module.Proj.Dwellings[House].Cooling.Include)
            dataRow["Space Cooling"] = (object) SAP_Module.CalcualtionDER2012.Calculation.Space_cooling_requirement.Box108;
          try
          {
            dataRow["HLP"] = (object) SAP_Module.CalcualtionDER2012.Calculation.HeatLoss.Box40;
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
          string str1 = "";
          string str2 = "";
          string str3 = "";
          string str4 = "";
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.InforSource, "Boiler Database", false) == 0)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SGroup, "Gas boilers And oil boilers", false) == 0)
            {
              List<PCDF.SEDBUK> boilers = SAP_Module.PCDFData.Boilers;
              Func<PCDF.SEDBUK, bool> predicate;
              // ISSUE: reference to a compiler-generated field
              if (Key_Results._Closure\u0024__.\u0024I127\u002D0 != null)
              {
                // ISSUE: reference to a compiler-generated field
                predicate = Key_Results._Closure\u0024__.\u0024I127\u002D0;
              }
              else
              {
                // ISSUE: reference to a compiler-generated field
                Key_Results._Closure\u0024__.\u0024I127\u002D0 = predicate = (Func<PCDF.SEDBUK, bool>) (b => b.ID.Equals(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SEDBUK));
              }
              PCDF.SEDBUK sedbuk = boilers.Where<PCDF.SEDBUK>(predicate).SingleOrDefault<PCDF.SEDBUK>();
              if (sedbuk != null)
              {
                str1 = sedbuk.BrandName;
                str3 = sedbuk.ModelName;
                str2 = sedbuk.ModelQualifier;
                str4 = sedbuk.ID;
              }
            }
            else if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SGroup.Contains("pumps"))
            {
              List<PCDF.HeatPump> heatPumps = SAP_Module.PCDFData.HeatPumps;
              Func<PCDF.HeatPump, bool> predicate;
              // ISSUE: reference to a compiler-generated field
              if (Key_Results._Closure\u0024__.\u0024I127\u002D1 != null)
              {
                // ISSUE: reference to a compiler-generated field
                predicate = Key_Results._Closure\u0024__.\u0024I127\u002D1;
              }
              else
              {
                // ISSUE: reference to a compiler-generated field
                Key_Results._Closure\u0024__.\u0024I127\u002D1 = predicate = (Func<PCDF.HeatPump, bool>) (b => b.ID.Equals(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SEDBUK));
              }
              PCDF.HeatPump heatPump = heatPumps.Where<PCDF.HeatPump>(predicate).SingleOrDefault<PCDF.HeatPump>();
              if (heatPump != null)
              {
                str1 = heatPump.Brand;
                str3 = heatPump.Model;
                str2 = heatPump.Qualifier;
                str4 = heatPump.ID;
              }
            }
            else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SGroup, "Micro-cogeneration (micro-CHP)", false) == 0)
            {
              List<PCDF.CHP> chPs = SAP_Module.PCDFData.CHPs;
              Func<PCDF.CHP, bool> predicate;
              // ISSUE: reference to a compiler-generated field
              if (Key_Results._Closure\u0024__.\u0024I127\u002D2 != null)
              {
                // ISSUE: reference to a compiler-generated field
                predicate = Key_Results._Closure\u0024__.\u0024I127\u002D2;
              }
              else
              {
                // ISSUE: reference to a compiler-generated field
                Key_Results._Closure\u0024__.\u0024I127\u002D2 = predicate = (Func<PCDF.CHP, bool>) (b => b.ID.Equals(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SEDBUK));
              }
              PCDF.CHP chp = chPs.Where<PCDF.CHP>(predicate).SingleOrDefault<PCDF.CHP>();
              if (chp != null)
              {
                str1 = chp.Brand;
                str3 = chp.Model;
                str2 = chp.Qualifier;
                str4 = chp.ID;
              }
            }
            else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SGroup, "Solid fuel boilers", false) == 0)
            {
              List<PCDF.SEDBUK_Solid> solidBoilers = SAP_Module.PCDFData.Solid_Boilers;
              Func<PCDF.SEDBUK_Solid, bool> predicate;
              // ISSUE: reference to a compiler-generated field
              if (Key_Results._Closure\u0024__.\u0024I127\u002D3 != null)
              {
                // ISSUE: reference to a compiler-generated field
                predicate = Key_Results._Closure\u0024__.\u0024I127\u002D3;
              }
              else
              {
                // ISSUE: reference to a compiler-generated field
                Key_Results._Closure\u0024__.\u0024I127\u002D3 = predicate = (Func<PCDF.SEDBUK_Solid, bool>) (b => b.ID.Equals(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SEDBUK));
              }
              PCDF.SEDBUK_Solid sedbukSolid = solidBoilers.Where<PCDF.SEDBUK_Solid>(predicate).SingleOrDefault<PCDF.SEDBUK_Solid>();
              if (sedbukSolid != null)
              {
                str1 = sedbukSolid.BrandName;
                str3 = sedbukSolid.ModelName;
                str2 = sedbukSolid.ModelQualifier;
                str4 = sedbukSolid.ID;
              }
            }
          }
          dataRow["Boiler Make"] = (object) str1;
          dataRow["Boiler Model"] = (object) str3;
          dataRow["Model Qual"] = (object) str2;
          dataRow["Boiler Index"] = (object) str4;
          dataRow["Cylinder Size "] = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.Volume;
          if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.WWHRS.Include)
            dataRow["WWHR"] = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.WWHRS.Systems[0].SystemsRef;
          if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.FGHRS.Include)
            dataRow["FGHR"] = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.FGHRS.IndexNo;
          if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].IncludeMainHeating2)
            dataRow["Secondary Heating"] = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SAPTableCode <= 0 ? (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SEDBUK : (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SAPTableCode;
          dataRow["Calculated y-value"] = (object) Math.Round(SAP_Module.Calculation2012.Calculation.HeatLoss.Box36 / SAP_Module.Calculation2012.Calculation.HeatLoss.Box31, 3);
          dataRow["Orientation"] = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Orientation;
          double num2 = 0.0;
          if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Photovoltaic.Inlcude)
          {
            int num3 = checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Photovoltaic.Photovoltaics.Length - 1);
            int index = 0;
            while (index <= num3)
            {
              num2 += (double) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Photovoltaic.Photovoltaics[index].PPower;
              checked { ++index; }
            }
          }
          dataRow["PV Kwp"] = (object) num2;
          dataRow["box64"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Water_heating.Box64, 1);
          dataRow["box98"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Space_heating_requirement.Box98, 1);
          dataRow["Ventilation Type"] = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.MechVent;
          dataRow["Product Name"] = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.ProductID <= 0 ? (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.MVDetails.ProductName : (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Parameters;
          dataRow["Vent System"] = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.ProductID;
          dataRow["overheating June"] = (object) SAP_Module.OverHeat.AppendixP.Likelihood_June;
          dataRow["overheating July"] = (object) SAP_Module.OverHeat.AppendixP.Likelihood_July;
          dataRow["overheating August"] = (object) SAP_Module.OverHeat.AppendixP.Likelihood_Aug;
          new Ene1().Calc();
          dataRow["Cooking"] = (object) Math.Round(SAP_Module.CalcualtionDER_CSH.Calculation.AssessmentLZC2012.ZC2, 2);
          dataRow["Appliance"] = (object) Math.Round(SAP_Module.CalcualtionDER_CSH.Calculation.AssessmentLZC2012.ZC3, 2);
          dataRow["Total Energy cost"] = SAP_Module.CalcualtionDER2012.Calculation.Actual_costs_10a.Box255 <= 0.0 ? (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Actual_costs_10b.Box355, 1) : (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Actual_costs_10a.Box255, 1);
          try
          {
            this.dtResultsDER.Rows.Add(row);
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
        }
        checked { ++House; }
      }
      SAP_Module.CurrDwelling = -1;
      SAP_Module.RoundFigure = roundFigure;
    }

    private void FillResultsTER()
    {
      int roundFigure = SAP_Module.RoundFigure;
      SAP_Module.RoundFigure = 2;
      int num1 = checked (SAP_Module.Proj.NoOfDwells - 1);
      int House = 0;
      while (House <= num1)
      {
        SAP_Module.CurrDwelling = House;
        if (Validation.LodgementStatusCheck(House))
        {
          DataRow row = this.dtResultsTER.NewRow();
          DataRow dataRow = row;
          dataRow["Dwelling"] = (object) SAP_Module.Proj.Dwellings[House].Name;
          dataRow["Reference"] = (object) SAP_Module.Proj.Dwellings[House].Reference;
          dataRow["Status"] = (object) SAP_Module.Proj.Dwellings[House].Status;
          dataRow["Property Type"] = (object) SAP_Module.Proj.Dwellings[House].PropertyType;
          dataRow["Built Form"] = (object) SAP_Module.Proj.Dwellings[House].BuildForm;
          dataRow["Address1"] = (object) SAP_Module.Proj.Dwellings[House].Address.Line1;
          dataRow["Address2"] = (object) SAP_Module.Proj.Dwellings[House].Address.Line2;
          dataRow["Address3"] = (object) SAP_Module.Proj.Dwellings[House].Address.Line3;
          dataRow["City"] = (object) SAP_Module.Proj.Dwellings[House].Address.City;
          dataRow["Postcode"] = (object) SAP_Module.Proj.Dwellings[House].Address.PostCost;
          dataRow["UPRN"] = (object) SAP_Module.Proj.Dwellings[House].UPRN;
          dataRow["Country"] = (object) SAP_Module.Proj.Dwellings[House].Address.Country;
          Functions.CalculateNow();
          if (SAP_Module.Calculation2012.Calculation.SAP_rating_11a.Box258 == 0.0)
            dataRow["SAP"] = (object) (SAP_Module.Calculation2012.Calculation.SAP_rating_11b.SAPBand + " " + Conversions.ToString(SAP_Module.Calculation2012.Calculation.SAP_rating_11b.SAPRating) + " (" + Conversions.ToString(SAP_Module.Calculation2012.Calculation.SAP_rating_11b.Box358) + ")");
          else
            dataRow["SAP"] = (object) (SAP_Module.Calculation2012.Calculation.SAP_rating_11a.SAPBand + " " + Conversions.ToString(SAP_Module.Calculation2012.Calculation.SAP_rating_11a.SAPRating) + " (" + Conversions.ToString(SAP_Module.Calculation2012.Calculation.SAP_rating_11a.Box258) + ")");
          if (SAP_Module.CalcualtionDER2012.Calculation.CO2_Emissions_12a.Box273 == 0.0)
          {
            dataRow["DER"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.CO2_Emissions_12b.Box384, 2);
            dataRow["EI"] = (object) SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box385;
          }
          else
          {
            dataRow["DER"] = (object) SAP_Module.CalcualtionDER2012.Calculation.CO2_Emissions_12a.Box273;
            dataRow["EI"] = (object) SAP_Module.Calculation2012.Calculation.CO2_Emissions_12a.EIValue;
          }
          dataRow["TER"] = (object) Functions.TER();
          SAP_Module.CalcRound = true;
          SAP_Module.RoundFigure = 2;
          Calc2012 calc2012_1 = new Calc2012();
          Calc2012 calc2012_2 = new Calc2012();
          dataRow["DFEE"] = (object) Math.Round(calc2012_2.Calculation.Fabric_Energy_Efficiency.Box109, 1);
          Calc2012 calc2012_3 = new Calc2012();
          calc2012_3.SETPCDF(SAP_Module.PCDFData);
          calc2012_3.IsFabricEfficiency = true;
          SAP_Module.CalcRound = false;
          calc2012_3.Dwelling = Functions.GetFEEDwelling(ref SAP_Module.TERDwelling);
          SAP_Module.CalcRound = true;
          dataRow["TFEE"] = (object) Math.Round(1.15 * calc2012_3.Calculation.Fabric_Energy_Efficiency.Box109, 1);
          dataRow["Percent Improvement"] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet((object) null, typeof (Math), "Round", new object[2]
          {
            Microsoft.VisualBasic.CompilerServices.Operators.MultiplyObject((object) 100, Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject((object) 1, Microsoft.VisualBasic.CompilerServices.Operators.DivideObject(dataRow["DER"], (object) Functions.TER()))),
            (object) 2
          }, (string[]) null, (System.Type[]) null, (bool[]) null));
          dataRow["Total Floor Area"] = (object) SAP_Module.CalcualtionDER2012.Calculation.Dimensions.Box4;
          dataRow["FEE"] = (object) Math.Round(calc2012_2.Calculation.Fabric_Energy_Efficiency.Box109, 2);
          dataRow["Air permeability"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Ventilation.Box17, 2);
          if (SAP_Module.CalcualtionTER2012.Calculation.Energy_Requirements_9a.Box211 == 0.0)
          {
            dataRow["Main Heating Fuel Requirement (TER)"] = (object) Math.Round(SAP_Module.CalcualtionTER2012.Calculation.Energy_Requirements_9b.Box307a + SAP_Module.CalcualtionTER2012.Calculation.Energy_Requirements_9b.Box307b + SAP_Module.CalcualtionTER2012.Calculation.Energy_Requirements_9b.Box307c + SAP_Module.CalcualtionTER2012.Calculation.Energy_Requirements_9b.Box307d + SAP_Module.CalcualtionTER2012.Calculation.Energy_Requirements_9b.Box307e, 2);
            dataRow["Secondary Heating Fuel Requirement (TER)"] = (object) Math.Round(SAP_Module.CalcualtionTER2012.Calculation.Energy_Requirements_9b.Box309, 2);
            dataRow["Secondary Main Heating Fuel Requirement (TER)"] = (object) 0;
            dataRow["Electricity Pumps Fans Requirement (TER)"] = (object) Math.Round(SAP_Module.CalcualtionTER2012.Calculation.Energy_Requirements_9b.Box331, 2);
            dataRow["Electricity Lighting Requirement (TER)"] = (object) Math.Round(SAP_Module.CalcualtionTER2012.Calculation.Energy_Requirements_9b.Box332, 2);
            dataRow["PV Energy Produced (TER)"] = (object) Math.Round(SAP_Module.CalcualtionTER2012.Calculation.Energy_Requirements_9b.Box333, 2);
            dataRow["Wind Energy Produced (TER)"] = (object) SAP_Module.CalcualtionTER2012.Calculation.Energy_Requirements_9b.Box334;
          }
          else
          {
            dataRow["Main Heating Fuel Requirement (TER)"] = (object) Math.Round(SAP_Module.CalcualtionTER2012.Calculation.Energy_Requirements_9a.Box211, 2);
            dataRow["Secondary Main Heating Fuel Requirement (TER)"] = (object) Math.Round(SAP_Module.CalcualtionTER2012.Calculation.Energy_Requirements_9a.Box213, 2);
            dataRow["Secondary Heating Fuel Requirement (TER)"] = (object) Math.Round(SAP_Module.CalcualtionTER2012.Calculation.Energy_Requirements_9a.Box215, 2);
            dataRow["Electricity Pumps Fans Requirement (TER)"] = (object) Math.Round(SAP_Module.CalcualtionTER2012.Calculation.Energy_Requirements_9a.Box231, 2);
            dataRow["Electricity Lighting Requirement (TER)"] = (object) Math.Round(SAP_Module.CalcualtionTER2012.Calculation.Energy_Requirements_9a.Box232, 2);
            dataRow["PV Energy Produced (TER)"] = (object) Math.Round(SAP_Module.CalcualtionTER2012.Calculation.Energy_Requirements_9a.Box233, 2);
            dataRow["Wind Energy Produced (TER)"] = (object) SAP_Module.CalcualtionTER2012.Calculation.Energy_Requirements_9a.Box234;
          }
          dataRow["Water Fuel Requirement (TER)"] = SAP_Module.CalcualtionTER2012.Calculation.Energy_Requirements_9a.Box219 != 0.0 ? (object) Math.Round(SAP_Module.CalcualtionTER2012.Calculation.Energy_Requirements_9a.Box219, 2) : (object) Math.Round(SAP_Module.CalcualtionTER2012.Calculation.Energy_Requirements_9b.Box312 + SAP_Module.CalcualtionTER2012.Calculation.Energy_Requirements_9b.Box310a + SAP_Module.CalcualtionTER2012.Calculation.Energy_Requirements_9b.Box310b + SAP_Module.CalcualtionTER2012.Calculation.Energy_Requirements_9b.Box310c + SAP_Module.CalcualtionTER2012.Calculation.Energy_Requirements_9b.Box310d + SAP_Module.CalcualtionTER2012.Calculation.Energy_Requirements_9b.Box310e, 2);
          dataRow["Total CO2 (TER)"] = SAP_Module.CalcualtionTER2012.Calculation.CO2_Emissions_12a.Box273 != 0.0 ? (object) SAP_Module.CalcualtionTER2012.Calculation.CO2_Emissions_12a.Box272 : (object) SAP_Module.CalcualtionTER2012.Calculation.CO2_Emissions_12b.Box383;
          dataRow["Building Regulations Results"] = Compliance.CheckCompliance(House) ? (object) "Yes" : (object) "No";
          if (SAP_Module.Proj.Dwellings[House].Cooling.Include)
            dataRow["Space Cooling"] = (object) SAP_Module.CalcualtionTER2012.Calculation.Space_cooling_requirement.Box108;
          try
          {
            dataRow["HLP"] = (object) SAP_Module.CalcualtionTER2012.Calculation.HeatLoss.Box40;
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
          string str1 = "";
          string str2 = "";
          string str3 = "";
          string str4 = "";
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.InforSource, "Boiler Database", false) == 0)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SGroup, "Gas boilers and oil boilers", false) == 0)
            {
              List<PCDF.SEDBUK> boilers = SAP_Module.PCDFData.Boilers;
              Func<PCDF.SEDBUK, bool> predicate;
              // ISSUE: reference to a compiler-generated field
              if (Key_Results._Closure\u0024__.\u0024I128\u002D0 != null)
              {
                // ISSUE: reference to a compiler-generated field
                predicate = Key_Results._Closure\u0024__.\u0024I128\u002D0;
              }
              else
              {
                // ISSUE: reference to a compiler-generated field
                Key_Results._Closure\u0024__.\u0024I128\u002D0 = predicate = (Func<PCDF.SEDBUK, bool>) (b => b.ID.Equals(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SEDBUK));
              }
              PCDF.SEDBUK sedbuk = boilers.Where<PCDF.SEDBUK>(predicate).SingleOrDefault<PCDF.SEDBUK>();
              if (sedbuk != null)
              {
                str1 = sedbuk.BrandName;
                str3 = sedbuk.ModelName;
                str2 = sedbuk.ModelQualifier;
                str4 = sedbuk.ID;
              }
            }
            else if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SGroup.Contains("pumps"))
            {
              List<PCDF.HeatPump> heatPumps = SAP_Module.PCDFData.HeatPumps;
              Func<PCDF.HeatPump, bool> predicate;
              // ISSUE: reference to a compiler-generated field
              if (Key_Results._Closure\u0024__.\u0024I128\u002D1 != null)
              {
                // ISSUE: reference to a compiler-generated field
                predicate = Key_Results._Closure\u0024__.\u0024I128\u002D1;
              }
              else
              {
                // ISSUE: reference to a compiler-generated field
                Key_Results._Closure\u0024__.\u0024I128\u002D1 = predicate = (Func<PCDF.HeatPump, bool>) (b => b.ID.Equals(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SEDBUK));
              }
              PCDF.HeatPump heatPump = heatPumps.Where<PCDF.HeatPump>(predicate).SingleOrDefault<PCDF.HeatPump>();
              if (heatPump != null)
              {
                str1 = heatPump.Brand;
                str3 = heatPump.Model;
                str2 = heatPump.Qualifier;
                str4 = heatPump.ID;
              }
            }
            else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SGroup, "Micro-cogeneration (micro-CHP)", false) == 0)
            {
              List<PCDF.CHP> chPs = SAP_Module.PCDFData.CHPs;
              Func<PCDF.CHP, bool> predicate;
              // ISSUE: reference to a compiler-generated field
              if (Key_Results._Closure\u0024__.\u0024I128\u002D2 != null)
              {
                // ISSUE: reference to a compiler-generated field
                predicate = Key_Results._Closure\u0024__.\u0024I128\u002D2;
              }
              else
              {
                // ISSUE: reference to a compiler-generated field
                Key_Results._Closure\u0024__.\u0024I128\u002D2 = predicate = (Func<PCDF.CHP, bool>) (b => b.ID.Equals(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SEDBUK));
              }
              PCDF.CHP chp = chPs.Where<PCDF.CHP>(predicate).SingleOrDefault<PCDF.CHP>();
              if (chp != null)
              {
                str1 = chp.Brand;
                str3 = chp.Model;
                str4 = chp.ID;
              }
            }
            else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SGroup, "Solid fuel boilers", false) == 0)
            {
              List<PCDF.SEDBUK_Solid> solidBoilers = SAP_Module.PCDFData.Solid_Boilers;
              Func<PCDF.SEDBUK_Solid, bool> predicate;
              // ISSUE: reference to a compiler-generated field
              if (Key_Results._Closure\u0024__.\u0024I128\u002D3 != null)
              {
                // ISSUE: reference to a compiler-generated field
                predicate = Key_Results._Closure\u0024__.\u0024I128\u002D3;
              }
              else
              {
                // ISSUE: reference to a compiler-generated field
                Key_Results._Closure\u0024__.\u0024I128\u002D3 = predicate = (Func<PCDF.SEDBUK_Solid, bool>) (b => b.ID.Equals(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SEDBUK));
              }
              PCDF.SEDBUK_Solid sedbukSolid = solidBoilers.Where<PCDF.SEDBUK_Solid>(predicate).SingleOrDefault<PCDF.SEDBUK_Solid>();
              if (sedbukSolid != null)
              {
                str1 = sedbukSolid.BrandName;
                str3 = sedbukSolid.ModelName;
                str2 = sedbukSolid.ModelQualifier;
                str4 = sedbukSolid.ID;
              }
            }
          }
          dataRow["Boiler Make"] = (object) str1;
          dataRow["Boiler Model"] = (object) str3;
          dataRow["Model Qual"] = (object) str2;
          dataRow["Boiler Index"] = (object) str4;
          dataRow["Cylinder Size "] = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.Volume;
          if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.WWHRS.Include)
            dataRow["WWHR"] = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.WWHRS.Systems[0].SystemsRef;
          if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.FGHRS.Include)
            dataRow["FGHR"] = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.FGHRS.IndexNo;
          if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].IncludeMainHeating2)
            dataRow["Secondary Heating"] = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SAPTableCode <= 0 ? (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SEDBUK : (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SAPTableCode;
          dataRow["Calculated y-value"] = (object) Math.Round(SAP_Module.Calculation2012.Calculation.HeatLoss.Box36 / SAP_Module.Calculation2012.Calculation.HeatLoss.Box31, 3);
          dataRow["Orientation"] = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Orientation;
          double num2 = 0.0;
          if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Photovoltaic.Inlcude)
          {
            int num3 = checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Photovoltaic.Photovoltaics.Length - 1);
            int index = 0;
            while (index <= num3)
            {
              num2 += (double) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Photovoltaic.Photovoltaics[index].PPower;
              checked { ++index; }
            }
          }
          dataRow["PV Kwp"] = (object) num2;
          dataRow["box64"] = (object) Math.Round(SAP_Module.CalcualtionTER2012.Calculation.Water_heating.Box64, 1);
          dataRow["box98"] = (object) Math.Round(SAP_Module.CalcualtionTER2012.Calculation.Space_heating_requirement.Box98, 1);
          dataRow["Ventilation Type"] = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.MechVent;
          dataRow["Product Name"] = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.ProductID <= 0 ? (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.MVDetails.ProductName : (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Parameters;
          dataRow["Vent System"] = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.ProductID;
          dataRow["overheating June"] = (object) SAP_Module.OverHeat.AppendixP.Likelihood_June;
          dataRow["overheating July"] = (object) SAP_Module.OverHeat.AppendixP.Likelihood_July;
          dataRow["overheating August"] = (object) SAP_Module.OverHeat.AppendixP.Likelihood_Aug;
          new Ene1().Calc();
          dataRow["Cooking"] = (object) Math.Round(SAP_Module.CalcualtionDER_CSH.Calculation.AssessmentLZC2012.ZC2, 2);
          dataRow["Appliance"] = (object) Math.Round(SAP_Module.CalcualtionDER_CSH.Calculation.AssessmentLZC2012.ZC3, 2);
          dataRow["Total Energy cost"] = SAP_Module.CalcualtionTER2012.Calculation.Actual_costs_10a.Box255 <= 0.0 ? (object) Math.Round(SAP_Module.CalcualtionTER2012.Calculation.Actual_costs_10b.Box355, 1) : (object) Math.Round(SAP_Module.CalcualtionTER2012.Calculation.Actual_costs_10a.Box255, 1);
          try
          {
            this.dtResultsTER.Rows.Add(row);
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
        }
        checked { ++House; }
      }
      SAP_Module.CurrDwelling = -1;
      SAP_Module.RoundFigure = roundFigure;
    }

    private void FillResultsEPC_Cost()
    {
      int roundFigure = SAP_Module.RoundFigure;
      SAP_Module.RoundFigure = 2;
      int num1 = checked (SAP_Module.Proj.NoOfDwells - 1);
      int House = 0;
      while (House <= num1)
      {
        SAP_Module.CurrDwelling = House;
        if (Validation.LodgementStatusCheck(House))
        {
          DataRow row = this.dtResultscost.NewRow();
          DataRow dataRow = row;
          dataRow["Dwelling"] = (object) SAP_Module.Proj.Dwellings[House].Name;
          dataRow["Reference"] = (object) SAP_Module.Proj.Dwellings[House].Reference;
          dataRow["Status"] = (object) SAP_Module.Proj.Dwellings[House].Status;
          dataRow["Property Type"] = (object) SAP_Module.Proj.Dwellings[House].PropertyType;
          dataRow["Built Form"] = (object) SAP_Module.Proj.Dwellings[House].BuildForm;
          dataRow["Address1"] = (object) SAP_Module.Proj.Dwellings[House].Address.Line1;
          dataRow["Address2"] = (object) SAP_Module.Proj.Dwellings[House].Address.Line2;
          dataRow["Address3"] = (object) SAP_Module.Proj.Dwellings[House].Address.Line3;
          dataRow["City"] = (object) SAP_Module.Proj.Dwellings[House].Address.City;
          dataRow["Postcode"] = (object) SAP_Module.Proj.Dwellings[House].Address.PostCost;
          dataRow["UPRN"] = (object) SAP_Module.Proj.Dwellings[House].UPRN;
          dataRow["Country"] = (object) SAP_Module.Proj.Dwellings[House].Address.Country;
          Functions.CalculateNow();
          if (SAP_Module.Calculation2012.Calculation.SAP_rating_11a.Box258 == 0.0)
            dataRow["SAP"] = (object) (SAP_Module.Calculation2012.Calculation.SAP_rating_11b.SAPBand + " " + Conversions.ToString(SAP_Module.Calculation2012.Calculation.SAP_rating_11b.SAPRating) + " (" + Conversions.ToString(SAP_Module.Calculation2012.Calculation.SAP_rating_11b.Box358) + ")");
          else
            dataRow["SAP"] = (object) (SAP_Module.Calculation2012.Calculation.SAP_rating_11a.SAPBand + " " + Conversions.ToString(SAP_Module.Calculation2012.Calculation.SAP_rating_11a.SAPRating) + " (" + Conversions.ToString(SAP_Module.Calculation2012.Calculation.SAP_rating_11a.Box258) + ")");
          if (SAP_Module.CalcualtionDER2012.Calculation.CO2_Emissions_12a.Box273 == 0.0)
          {
            dataRow["DER"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.CO2_Emissions_12b.Box384, 2);
            dataRow["EI"] = (object) SAP_Module.Calculation2012.Calculation.CO2_Emissions_12b.Box385;
          }
          else
          {
            dataRow["DER"] = (object) SAP_Module.CalcualtionDER2012.Calculation.CO2_Emissions_12a.Box273;
            dataRow["EI"] = (object) SAP_Module.Calculation2012.Calculation.CO2_Emissions_12a.EIValue;
          }
          dataRow["TER"] = (object) Functions.TER();
          SAP_Module.CalcRound = true;
          SAP_Module.RoundFigure = 2;
          Calc2012 calc2012_1 = new Calc2012();
          Calc2012 calc2012_2 = new Calc2012();
          dataRow["DFEE"] = (object) Math.Round(calc2012_2.Calculation.Fabric_Energy_Efficiency.Box109, 1);
          Calc2012 calc2012_3 = new Calc2012();
          calc2012_3.SETPCDF(SAP_Module.PCDFData);
          calc2012_3.IsFabricEfficiency = true;
          SAP_Module.CalcRound = false;
          calc2012_3.Dwelling = Functions.GetFEEDwelling(ref SAP_Module.TERDwelling);
          SAP_Module.CalcRound = true;
          dataRow["TFEE"] = (object) Math.Round(1.15 * calc2012_3.Calculation.Fabric_Energy_Efficiency.Box109, 1);
          dataRow["Percent Improvement"] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet((object) null, typeof (Math), "Round", new object[2]
          {
            Microsoft.VisualBasic.CompilerServices.Operators.MultiplyObject((object) 100, Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject((object) 1, Microsoft.VisualBasic.CompilerServices.Operators.DivideObject(dataRow["DER"], (object) Functions.TER()))),
            (object) 2
          }, (string[]) null, (System.Type[]) null, (bool[]) null));
          dataRow["Total Floor Area"] = (object) SAP_Module.CalcualtionDER2012.Calculation.Dimensions.Box4;
          dataRow["FEE"] = (object) Math.Round(calc2012_2.Calculation.Fabric_Energy_Efficiency.Box109, 2);
          dataRow["Air permeability"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Ventilation.Box17, 2);
          if (SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9a.Box211 == 0.0)
          {
            dataRow["Main Heating Fuel Requirement (EPC_cost)"] = (object) Math.Round(SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9b.Box307a + SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9b.Box307b + SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9b.Box307c + SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9b.Box307d + SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9b.Box307e, 2);
            dataRow["Secondary Heating Fuel Requirement (EPC_cost)"] = (object) Math.Round(SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9b.Box309, 2);
            dataRow["Secondary Main Heating Fuel Requirement (EPC_cost)"] = (object) 0;
            dataRow["Electricity Pumps Fans Requirement (EPC_cost)"] = (object) Math.Round(SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9b.Box331, 2);
            dataRow["Electricity Lighting Requirement (EPC_cost)"] = (object) Math.Round(SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9b.Box332, 2);
            dataRow["PV Energy Produced (EPC_cost)"] = (object) Math.Round(SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9b.Box333, 2);
            dataRow["Wind Energy Produced (EPC_cost)"] = (object) SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9b.Box334;
          }
          else
          {
            dataRow["Main Heating Fuel Requirement (EPC_cost)"] = (object) Math.Round(SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9a.Box211, 2);
            dataRow["Secondary Main Heating Fuel Requirement (EPC_cost)"] = (object) Math.Round(SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9a.Box213, 2);
            dataRow["Secondary Heating Fuel Requirement (EPC_cost)"] = (object) Math.Round(SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9a.Box215, 2);
            dataRow["Electricity Pumps Fans Requirement (EPC_cost)"] = (object) Math.Round(SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9a.Box231, 2);
            dataRow["Electricity Lighting Requirement (EPC_cost)"] = (object) Math.Round(SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9a.Box232, 2);
            dataRow["PV Energy Produced (EPC_cost)"] = (object) Math.Round(SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9a.Box233, 2);
            dataRow["Wind Energy Produced (EPC_cost)"] = (object) SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9a.Box234;
          }
          dataRow["Water Fuel Requirement (EPC_cost)"] = SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9a.Box219 != 0.0 ? (object) Math.Round(SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9a.Box219, 2) : (object) Math.Round(SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9b.Box312 + SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9b.Box310a + SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9b.Box310b + SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9b.Box310c + SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9b.Box310d + SAP_Module.Calculation2012Regional.Calculation.Energy_Requirements_9b.Box310e, 2);
          dataRow["Total CO2 (EPC_cost)"] = SAP_Module.Calculation2012Regional.Calculation.CO2_Emissions_12a.Box273 != 0.0 ? (object) SAP_Module.Calculation2012Regional.Calculation.CO2_Emissions_12a.Box272 : (object) SAP_Module.Calculation2012Regional.Calculation.CO2_Emissions_12b.Box383;
          dataRow["Building Regulations Results"] = Compliance.CheckCompliance(House) ? (object) "Yes" : (object) "No";
          if (SAP_Module.Proj.Dwellings[House].Cooling.Include)
            dataRow["Space Cooling"] = (object) SAP_Module.Calculation2012Regional.Calculation.Space_cooling_requirement.Box108;
          try
          {
            dataRow["HLP"] = (object) SAP_Module.Calculation2012Regional.Calculation.HeatLoss.Box40;
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
          string str1 = "";
          string str2 = "";
          string str3 = "";
          string str4 = "";
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.InforSource, "Boiler Database", false) == 0)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SGroup, "Gas boilers and oil boilers", false) == 0)
            {
              List<PCDF.SEDBUK> boilers = SAP_Module.PCDFData.Boilers;
              Func<PCDF.SEDBUK, bool> predicate;
              // ISSUE: reference to a compiler-generated field
              if (Key_Results._Closure\u0024__.\u0024I129\u002D0 != null)
              {
                // ISSUE: reference to a compiler-generated field
                predicate = Key_Results._Closure\u0024__.\u0024I129\u002D0;
              }
              else
              {
                // ISSUE: reference to a compiler-generated field
                Key_Results._Closure\u0024__.\u0024I129\u002D0 = predicate = (Func<PCDF.SEDBUK, bool>) (b => b.ID.Equals(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SEDBUK));
              }
              PCDF.SEDBUK sedbuk = boilers.Where<PCDF.SEDBUK>(predicate).SingleOrDefault<PCDF.SEDBUK>();
              if (sedbuk != null)
              {
                str1 = sedbuk.BrandName;
                str3 = sedbuk.ModelName;
                str2 = sedbuk.ModelQualifier;
                str4 = sedbuk.ID;
              }
            }
            else if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SGroup.Contains("pumps"))
            {
              List<PCDF.HeatPump> heatPumps = SAP_Module.PCDFData.HeatPumps;
              Func<PCDF.HeatPump, bool> predicate;
              // ISSUE: reference to a compiler-generated field
              if (Key_Results._Closure\u0024__.\u0024I129\u002D1 != null)
              {
                // ISSUE: reference to a compiler-generated field
                predicate = Key_Results._Closure\u0024__.\u0024I129\u002D1;
              }
              else
              {
                // ISSUE: reference to a compiler-generated field
                Key_Results._Closure\u0024__.\u0024I129\u002D1 = predicate = (Func<PCDF.HeatPump, bool>) (b => b.ID.Equals(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SEDBUK));
              }
              PCDF.HeatPump heatPump = heatPumps.Where<PCDF.HeatPump>(predicate).SingleOrDefault<PCDF.HeatPump>();
              if (heatPump != null)
              {
                str1 = heatPump.Brand;
                str3 = heatPump.Model;
                str2 = heatPump.Qualifier;
                str4 = heatPump.ID;
              }
            }
            else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SGroup, "Micro-cogeneration (micro-CHP)", false) == 0)
            {
              List<PCDF.CHP> chPs = SAP_Module.PCDFData.CHPs;
              Func<PCDF.CHP, bool> predicate;
              // ISSUE: reference to a compiler-generated field
              if (Key_Results._Closure\u0024__.\u0024I129\u002D2 != null)
              {
                // ISSUE: reference to a compiler-generated field
                predicate = Key_Results._Closure\u0024__.\u0024I129\u002D2;
              }
              else
              {
                // ISSUE: reference to a compiler-generated field
                Key_Results._Closure\u0024__.\u0024I129\u002D2 = predicate = (Func<PCDF.CHP, bool>) (b => b.ID.Equals(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SEDBUK));
              }
              PCDF.CHP chp = chPs.Where<PCDF.CHP>(predicate).SingleOrDefault<PCDF.CHP>();
              if (chp != null)
              {
                str1 = chp.Brand;
                str3 = chp.Model;
                str4 = chp.ID;
              }
            }
            else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SGroup, "Solid fuel boilers", false) == 0)
            {
              List<PCDF.SEDBUK_Solid> solidBoilers = SAP_Module.PCDFData.Solid_Boilers;
              Func<PCDF.SEDBUK_Solid, bool> predicate;
              // ISSUE: reference to a compiler-generated field
              if (Key_Results._Closure\u0024__.\u0024I129\u002D3 != null)
              {
                // ISSUE: reference to a compiler-generated field
                predicate = Key_Results._Closure\u0024__.\u0024I129\u002D3;
              }
              else
              {
                // ISSUE: reference to a compiler-generated field
                Key_Results._Closure\u0024__.\u0024I129\u002D3 = predicate = (Func<PCDF.SEDBUK_Solid, bool>) (b => b.ID.Equals(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SEDBUK));
              }
              PCDF.SEDBUK_Solid sedbukSolid = solidBoilers.Where<PCDF.SEDBUK_Solid>(predicate).SingleOrDefault<PCDF.SEDBUK_Solid>();
              if (sedbukSolid != null)
              {
                str1 = sedbukSolid.BrandName;
                str3 = sedbukSolid.ModelName;
                str2 = sedbukSolid.ModelQualifier;
                str4 = sedbukSolid.ID;
              }
            }
          }
          dataRow["Boiler Make"] = (object) str1;
          dataRow["Boiler Model"] = (object) str3;
          dataRow["Model Qual"] = (object) str2;
          dataRow["Boiler Index"] = (object) str4;
          dataRow["Cylinder Size "] = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.Volume;
          if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.WWHRS.Include)
            dataRow["WWHR"] = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.WWHRS.Systems[0].SystemsRef;
          if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.FGHRS.Include)
            dataRow["FGHR"] = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.FGHRS.IndexNo;
          if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].IncludeMainHeating2)
            dataRow["Secondary Heating"] = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SAPTableCode <= 0 ? (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SEDBUK : (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SAPTableCode;
          dataRow["Calculated y-value"] = (object) Math.Round(SAP_Module.Calculation2012.Calculation.HeatLoss.Box36 / SAP_Module.Calculation2012.Calculation.HeatLoss.Box31, 3);
          dataRow["Orientation"] = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Orientation;
          double num2 = 0.0;
          if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Photovoltaic.Inlcude)
          {
            int num3 = checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Photovoltaic.Photovoltaics.Length - 1);
            int index = 0;
            while (index <= num3)
            {
              num2 += (double) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Photovoltaic.Photovoltaics[index].PPower;
              checked { ++index; }
            }
          }
          dataRow["PV Kwp"] = (object) num2;
          dataRow["box64"] = (object) Math.Round(SAP_Module.Calculation2012Regional.Calculation.Water_heating.Box64, 1);
          dataRow["box98"] = (object) Math.Round(SAP_Module.Calculation2012Regional.Calculation.Space_heating_requirement.Box98, 1);
          dataRow["Ventilation Type"] = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.MechVent;
          dataRow["Product Name"] = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.ProductID <= 0 ? (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.MVDetails.ProductName : (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Parameters;
          dataRow["Vent System"] = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.ProductID;
          dataRow["overheating June"] = (object) SAP_Module.OverHeat.AppendixP.Likelihood_June;
          dataRow["overheating July"] = (object) SAP_Module.OverHeat.AppendixP.Likelihood_July;
          dataRow["overheating August"] = (object) SAP_Module.OverHeat.AppendixP.Likelihood_Aug;
          new Ene1().Calc();
          dataRow["Cooking"] = (object) SAP_Module.CalcualtionDER_CSH.Calculation.AssessmentLZC2012.ZC2;
          dataRow["Appliance"] = (object) SAP_Module.CalcualtionDER_CSH.Calculation.AssessmentLZC2012.ZC3;
          dataRow["Total Energy cost"] = SAP_Module.Calculation2012Regional.Calculation.Actual_costs_10a.Box255 <= 0.0 ? (object) Math.Round(SAP_Module.Calculation2012Regional.Calculation.Actual_costs_10b.Box355, 1) : (object) Math.Round(SAP_Module.Calculation2012Regional.Calculation.Actual_costs_10a.Box255, 1);
          try
          {
            this.dtResultscost.Rows.Add(row);
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
        }
        checked { ++House; }
      }
      SAP_Module.CurrDwelling = -1;
      SAP_Module.RoundFigure = roundFigure;
    }

    public void CreateCSVFile(StreamWriter sw, DataTable dt, string strFilePath)
    {
      int count = dt.Columns.Count;
      int num1 = checked (count - 1);
      int index = 0;
      while (index <= num1)
      {
        sw.Write((object) dt.Columns[index]);
        if (index < checked (count - 1))
          sw.Write(",");
        checked { ++index; }
      }
      sw.Write(sw.NewLine);
      try
      {
        foreach (DataRow row in dt.Rows)
        {
          int num2 = checked (count - 1);
          int columnIndex = 0;
          while (columnIndex <= num2)
          {
            if (!Convert.IsDBNull(RuntimeHelpers.GetObjectValue(row[columnIndex])))
            {
              string str = row[columnIndex].ToString().Replace(",", "").Replace("\n", " ").Replace("\r", " ");
              sw.Write(str);
            }
            else
              sw.Write("");
            if (columnIndex < checked (count - 1))
              sw.Write(",");
            checked { ++columnIndex; }
          }
          sw.Write(sw.NewLine);
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }

    private void cmdexcel_Click(object sender, EventArgs e) => this.ExportData(this.dtResultsFinal);

    private void lstItems_SelectedValueChanged(object sender, EventArgs e)
    {
      this.CheckColumns();
      this.CheckColumnsSAP();
      this.CheckColumnsDER();
      this.CheckColumnsTER();
    }

    private void ExportData(DataTable Type)
    {
      try
      {
        object folderPath = (object) Environment.GetFolderPath(Environment.SpecialFolder.Personal);
        if (!Directory.Exists(Conversions.ToString(folderPath)))
          Directory.CreateDirectory(Conversions.ToString(folderPath));
        DirectoryInfo directoryInfo1 = new DirectoryInfo(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(folderPath, (object) "\\Stroma SAP")));
        if (!directoryInfo1.Exists)
          directoryInfo1.Create();
        DirectoryInfo directoryInfo2 = new DirectoryInfo(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(folderPath, (object) "\\Stroma SAP\\"), (object) SAP_Module.Proj.Name)));
        if (!directoryInfo2.Exists)
          directoryInfo2.Create();
        object Left1 = Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(folderPath, (object) "\\Stroma SAP\\"), (object) SAP_Module.Proj.Name), (object) "\\Key Results-");
        DateTime now = DateAndTime.Now;
        string Right1 = now.Year.ToString();
        object Left2 = Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Left1, (object) Right1);
        now = DateAndTime.Now;
        string Right2 = now.Month.ToString();
        object Left3 = Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Left2, (object) Right2);
        now = DateAndTime.Now;
        int num = now.Day;
        string Right3 = num.ToString();
        object Left4 = Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Left3, (object) Right3);
        now = DateAndTime.Now;
        num = now.Hour;
        string Right4 = num.ToString();
        object Left5 = Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Left4, (object) Right4);
        now = DateAndTime.Now;
        num = now.Minute;
        string Right5 = num.ToString();
        object Left6 = Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Left5, (object) Right5);
        now = DateAndTime.Now;
        num = now.Second;
        string Right6 = num.ToString();
        string str = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Left6, (object) Right6), (object) ".csv"));
        StreamWriter sw = new StreamWriter(str, false);
        this.CreateCSVFile(sw, Type, str);
        sw.Close();
        Process.Start(str);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) ex.Message);
        ProjectData.ClearProjectError();
      }
    }

    private void SAPExcelExportToolStripMenuItem_Click(object sender, EventArgs e) => this.ExportData(this.dtResultsFinalSAP);

    private void DERExcelExportToolStripMenuItem_Click(object sender, EventArgs e) => this.ExportData(this.dtResultsFinalDER);

    private void TERExcelExportToolStripMenuItem_Click(object sender, EventArgs e) => this.ExportData(this.dtResultsFinalTER);

    private void EPCCostExcelExportToolStripMenuItem_Click(object sender, EventArgs e) => this.ExportData(this.dtResultsFinalCost);
  }
}
