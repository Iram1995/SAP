
// Type: SAP2012.Products




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
  public class Products : Form
  {
    private IContainer components;
    public DataView dgvProducts;
    public int Rows;
    public int Type;
    public DataTable Products322Sub;
    public DataTable Products321Sub;

    public Products()
    {
      this.FormClosing += new FormClosingEventHandler(this.Products_FormClosing);
      this.Load += new EventHandler(this.Products_Load);
      this.dgvProducts = new DataView();
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
      this.Label1 = new Label();
      this.GroupBox15 = new GroupBox();
      this.txtCriteria = new TextBox();
      this.cmdAdd = new Button();
      this.Label50 = new Label();
      this.txtPrimary = new ComboBox();
      this.Label53 = new Label();
      this.cmdCancel = new Button();
      this.ColSearch = new DataGridViewTextBoxColumn();
      this.SearchResults = new DataGridView();
      this.cmdClear = new Button();
      this.SearchCriteria = new DataGridView();
      this.ColText = new DataGridViewTextBoxColumn();
      this.GroupBox1 = new GroupBox();
      this.cmdSearch = new Button();
      this.cmdBiolerData = new Button();
      this.DataInfo = new DataGridView();
      this.DataAdditional = new DataGridView();
      this.GroupBox15.SuspendLayout();
      ((ISupportInitialize) this.SearchResults).BeginInit();
      ((ISupportInitialize) this.SearchCriteria).BeginInit();
      this.GroupBox1.SuspendLayout();
      ((ISupportInitialize) this.DataInfo).BeginInit();
      ((ISupportInitialize) this.DataAdditional).BeginInit();
      this.SuspendLayout();
      this.Label1.AutoSize = true;
      this.Label1.Location = new Point(15, 198);
      this.Label1.Name = "Label1";
      this.Label1.Size = new Size(39, 13);
      this.Label1.TabIndex = 30;
      this.Label1.Text = "Label1";
      this.GroupBox15.Controls.Add((Control) this.txtCriteria);
      this.GroupBox15.Controls.Add((Control) this.cmdAdd);
      this.GroupBox15.Controls.Add((Control) this.Label50);
      this.GroupBox15.Controls.Add((Control) this.txtPrimary);
      this.GroupBox15.Controls.Add((Control) this.Label53);
      this.GroupBox15.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.GroupBox15.Location = new Point(504, 12);
      this.GroupBox15.Name = "GroupBox15";
      this.GroupBox15.Size = new Size(285, 110);
      this.GroupBox15.TabIndex = 29;
      this.GroupBox15.TabStop = false;
      this.GroupBox15.Text = "Search Items";
      this.txtCriteria.Location = new Point(130, 48);
      this.txtCriteria.Name = "txtCriteria";
      this.txtCriteria.Size = new Size(151, 22);
      this.txtCriteria.TabIndex = 17;
      this.cmdAdd.BackColor = Color.LightSlateGray;
      this.cmdAdd.Cursor = Cursors.Hand;
      this.cmdAdd.FlatStyle = FlatStyle.Popup;
      this.cmdAdd.ForeColor = Color.White;
      this.cmdAdd.Location = new Point(189, 76);
      this.cmdAdd.Name = "cmdAdd";
      this.cmdAdd.Size = new Size(92, 23);
      this.cmdAdd.TabIndex = 16;
      this.cmdAdd.Text = "Add";
      this.cmdAdd.UseVisualStyleBackColor = false;
      this.Label50.AutoSize = true;
      this.Label50.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label50.Location = new Point(9, 56);
      this.Label50.Name = "Label50";
      this.Label50.Size = new Size(44, 14);
      this.Label50.TabIndex = 13;
      this.Label50.Text = "Criteria";
      this.txtPrimary.Cursor = Cursors.Hand;
      this.txtPrimary.FormattingEnabled = true;
      this.txtPrimary.Items.AddRange(new object[5]
      {
        (object) "Index",
        (object) "Manufacturer",
        (object) "Brand",
        (object) "Model Name",
        (object) "Model Qualifier"
      });
      this.txtPrimary.Location = new Point(130, 20);
      this.txtPrimary.Name = "txtPrimary";
      this.txtPrimary.Size = new Size(151, 22);
      this.txtPrimary.TabIndex = 11;
      this.Label53.AutoSize = true;
      this.Label53.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label53.Location = new Point(9, 24);
      this.Label53.Name = "Label53";
      this.Label53.Size = new Size(61, 14);
      this.Label53.TabIndex = 2;
      this.Label53.Text = "Search By";
      this.cmdCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.cmdCancel.BackColor = Color.LightSlateGray;
      this.cmdCancel.Cursor = Cursors.Hand;
      this.cmdCancel.FlatStyle = FlatStyle.Popup;
      this.cmdCancel.ForeColor = Color.White;
      this.cmdCancel.Location = new Point(693, 139);
      this.cmdCancel.Name = "cmdCancel";
      this.cmdCancel.Size = new Size(92, 23);
      this.cmdCancel.TabIndex = 28;
      this.cmdCancel.Text = "Cancel";
      this.cmdCancel.UseVisualStyleBackColor = false;
      this.ColSearch.HeaderText = "Search By";
      this.ColSearch.Name = "ColSearch";
      this.ColSearch.ReadOnly = true;
      this.ColSearch.Resizable = DataGridViewTriState.True;
      this.ColSearch.Width = 165;
      this.SearchResults.AllowUserToAddRows = false;
      this.SearchResults.AllowUserToDeleteRows = false;
      this.SearchResults.AllowUserToResizeRows = false;
      this.SearchResults.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.SearchResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.SearchResults.Cursor = Cursors.Hand;
      this.SearchResults.Location = new Point(12, 218);
      this.SearchResults.Name = "SearchResults";
      this.SearchResults.ReadOnly = true;
      this.SearchResults.RowHeadersVisible = false;
      this.SearchResults.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.SearchResults.Size = new Size(390, 426);
      this.SearchResults.TabIndex = 23;
      this.cmdClear.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.cmdClear.BackColor = Color.LightSlateGray;
      this.cmdClear.Cursor = Cursors.Hand;
      this.cmdClear.FlatStyle = FlatStyle.Popup;
      this.cmdClear.ForeColor = Color.White;
      this.cmdClear.Location = new Point(504, 139);
      this.cmdClear.Name = "cmdClear";
      this.cmdClear.Size = new Size(92, 23);
      this.cmdClear.TabIndex = 27;
      this.cmdClear.Text = "Clear";
      this.cmdClear.UseVisualStyleBackColor = false;
      this.SearchCriteria.AllowUserToAddRows = false;
      this.SearchCriteria.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      this.SearchCriteria.CausesValidation = false;
      this.SearchCriteria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.SearchCriteria.Columns.AddRange((DataGridViewColumn) this.ColSearch, (DataGridViewColumn) this.ColText);
      this.SearchCriteria.EditMode = DataGridViewEditMode.EditOnEnter;
      this.SearchCriteria.Location = new Point(9, 21);
      this.SearchCriteria.Name = "SearchCriteria";
      this.SearchCriteria.RowHeadersWidth = 25;
      this.SearchCriteria.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.SearchCriteria.Size = new Size(474, 158);
      this.SearchCriteria.TabIndex = 3;
      this.ColText.HeaderText = "Criteria";
      this.ColText.Name = "ColText";
      this.ColText.Width = 245;
      this.GroupBox1.Controls.Add((Control) this.SearchCriteria);
      this.GroupBox1.Location = new Point(12, 12);
      this.GroupBox1.Name = "GroupBox1";
      this.GroupBox1.Size = new Size(486, 183);
      this.GroupBox1.TabIndex = 24;
      this.GroupBox1.TabStop = false;
      this.GroupBox1.Text = "Search Critera";
      this.cmdSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.cmdSearch.BackColor = Color.LightSlateGray;
      this.cmdSearch.Cursor = Cursors.Hand;
      this.cmdSearch.FlatStyle = FlatStyle.Popup;
      this.cmdSearch.ForeColor = Color.White;
      this.cmdSearch.Location = new Point(504, 168);
      this.cmdSearch.Name = "cmdSearch";
      this.cmdSearch.Size = new Size(92, 23);
      this.cmdSearch.TabIndex = 26;
      this.cmdSearch.Text = "Search";
      this.cmdSearch.UseVisualStyleBackColor = false;
      this.cmdBiolerData.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.cmdBiolerData.BackColor = Color.LightSlateGray;
      this.cmdBiolerData.Cursor = Cursors.Hand;
      this.cmdBiolerData.FlatStyle = FlatStyle.Popup;
      this.cmdBiolerData.ForeColor = Color.White;
      this.cmdBiolerData.Location = new Point(693, 169);
      this.cmdBiolerData.Name = "cmdBiolerData";
      this.cmdBiolerData.Size = new Size(92, 23);
      this.cmdBiolerData.TabIndex = 25;
      this.cmdBiolerData.Text = "Select";
      this.cmdBiolerData.UseVisualStyleBackColor = false;
      this.DataInfo.BackgroundColor = Color.White;
      this.DataInfo.BorderStyle = BorderStyle.Fixed3D;
      this.DataInfo.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
      this.DataInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.DataInfo.ColumnHeadersVisible = false;
      this.DataInfo.Location = new Point(409, 218);
      this.DataInfo.Name = "DataInfo";
      this.DataInfo.ReadOnly = true;
      this.DataInfo.RowHeadersVisible = false;
      this.DataInfo.Size = new Size(376, 238);
      this.DataInfo.TabIndex = 32;
      this.DataInfo.TabStop = false;
      this.DataAdditional.BackgroundColor = Color.White;
      this.DataAdditional.BorderStyle = BorderStyle.Fixed3D;
      this.DataAdditional.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.DataAdditional.Cursor = Cursors.Hand;
      this.DataAdditional.Location = new Point(409, 462);
      this.DataAdditional.Name = "DataAdditional";
      this.DataAdditional.ReadOnly = true;
      this.DataAdditional.RowHeadersVisible = false;
      this.DataAdditional.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.DataAdditional.Size = new Size(376, 182);
      this.DataAdditional.TabIndex = 33;
      this.DataAdditional.TabStop = false;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.White;
      this.ClientSize = new Size(793, 653);
      this.Controls.Add((Control) this.DataAdditional);
      this.Controls.Add((Control) this.DataInfo);
      this.Controls.Add((Control) this.Label1);
      this.Controls.Add((Control) this.GroupBox15);
      this.Controls.Add((Control) this.cmdCancel);
      this.Controls.Add((Control) this.SearchResults);
      this.Controls.Add((Control) this.cmdClear);
      this.Controls.Add((Control) this.GroupBox1);
      this.Controls.Add((Control) this.cmdSearch);
      this.Controls.Add((Control) this.cmdBiolerData);
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.Name = nameof (Products);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = nameof (Products);
      this.GroupBox15.ResumeLayout(false);
      this.GroupBox15.PerformLayout();
      ((ISupportInitialize) this.SearchResults).EndInit();
      ((ISupportInitialize) this.SearchCriteria).EndInit();
      this.GroupBox1.ResumeLayout(false);
      ((ISupportInitialize) this.DataInfo).EndInit();
      ((ISupportInitialize) this.DataAdditional).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    [field: AccessedThroughProperty("Label1")]
    internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox15")]
    internal virtual GroupBox GroupBox15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtCriteria")]
    internal virtual TextBox txtCriteria { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button cmdAdd
    {
      get => this._cmdAdd;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdAdd_Click);
        Button cmdAdd1 = this._cmdAdd;
        if (cmdAdd1 != null)
          cmdAdd1.Click -= eventHandler;
        this._cmdAdd = value;
        Button cmdAdd2 = this._cmdAdd;
        if (cmdAdd2 == null)
          return;
        cmdAdd2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Label50")]
    internal virtual Label Label50 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ComboBox txtPrimary
    {
      get => this._txtPrimary;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.txtPrimary_Click);
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

    [field: AccessedThroughProperty("Label53")]
    internal virtual Label Label53 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

    [field: AccessedThroughProperty("ColSearch")]
    internal virtual DataGridViewTextBoxColumn ColSearch { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DataGridView SearchResults
    {
      get => this._SearchResults;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DataGridViewCellMouseEventHandler mouseEventHandler = new DataGridViewCellMouseEventHandler(this.SearchResults_CellMouseClick);
        DataGridView searchResults1 = this._SearchResults;
        if (searchResults1 != null)
          searchResults1.CellMouseClick -= mouseEventHandler;
        this._SearchResults = value;
        DataGridView searchResults2 = this._SearchResults;
        if (searchResults2 == null)
          return;
        searchResults2.CellMouseClick += mouseEventHandler;
      }
    }

    internal virtual Button cmdClear
    {
      get => this._cmdClear;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdClear_Click);
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

    [field: AccessedThroughProperty("SearchCriteria")]
    internal virtual DataGridView SearchCriteria { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("ColText")]
    internal virtual DataGridViewTextBoxColumn ColText { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox1")]
    internal virtual GroupBox GroupBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button cmdSearch
    {
      get => this._cmdSearch;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdSearch_Click);
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

    [field: AccessedThroughProperty("DataInfo")]
    internal virtual DataGridView DataInfo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DataAdditional")]
    internal virtual DataGridView DataAdditional { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private void cmdCancel_Click(object sender, EventArgs e) => this.Close();

    private void Products_FormClosing(object sender, FormClosingEventArgs e) => MyProject.Forms.SAPForm.Enabled = true;

    private void SearchResults_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
    {
      if (e.RowIndex <= -1)
        return;
      this.DataInfo[1, 0].Value = RuntimeHelpers.GetObjectValue(this.SearchResults[2, e.RowIndex].Value);
      this.DataInfo[1, 1].Value = RuntimeHelpers.GetObjectValue(this.SearchResults[3, e.RowIndex].Value);
      this.DataInfo[1, 2].Value = RuntimeHelpers.GetObjectValue(this.SearchResults[4, e.RowIndex].Value);
      this.DataInfo[1, 3].Value = RuntimeHelpers.GetObjectValue(this.SearchResults[5, e.RowIndex].Value);
      this.DataInfo[1, 5].Value = RuntimeHelpers.GetObjectValue(this.SearchResults[7, e.RowIndex].Value);
      this.DataInfo[1, 6].Value = RuntimeHelpers.GetObjectValue(this.SearchResults[8, e.RowIndex].Value);
      object Left1 = this.SearchResults[9, e.RowIndex].Value;
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left1, (object) 1, false))
        this.DataInfo[1, 7].Value = (object) "centralised mechanical extract ventilation";
      else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left1, (object) 2, false))
        this.DataInfo[1, 7].Value = (object) "decentralised mechanical extract ventilation";
      else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left1, (object) 3, false))
        this.DataInfo[1, 7].Value = (object) "balanced whole-house mechanical ventilation with heat recovery";
      else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left1, (object) 4, false))
        this.DataInfo[1, 7].Value = (object) "balanced whole-house mechanical ventilation without heat recovery";
      switch (this.Type)
      {
        case 1:
          object Left2 = this.SearchResults[11, e.RowIndex].Value;
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left2, (object) 1, false))
          {
            this.DataInfo[1, 9].Value = (object) "flexible ducting";
            break;
          }
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left2, (object) 2, false))
          {
            this.DataInfo[1, 9].Value = (object) "rigid ducting,";
            break;
          }
          break;
        case 2:
          object Left3 = this.SearchResults[10, e.RowIndex].Value;
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left3, (object) 1, false))
          {
            this.DataInfo[1, 8].Value = (object) "flexible ducting";
            break;
          }
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left3, (object) 2, false))
          {
            this.DataInfo[1, 8].Value = (object) "rigid ducting,";
            break;
          }
          break;
      }
      this.DataAdditional.Rows.Clear();
      switch (this.Type)
      {
        case 1:
          DataRow[] source1 = this.Products321Sub.Select(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "Ref = ", this.SearchResults[0, e.RowIndex].Value)));
          this.DataAdditional.Rows.Add(((IEnumerable<DataRow>) source1).Count<DataRow>());
          int num1 = Information.UBound((Array) source1);
          int rowIndex1 = 0;
          while (rowIndex1 <= num1)
          {
            int columnIndex = 0;
            do
            {
              this.DataAdditional[columnIndex, rowIndex1].Value = RuntimeHelpers.GetObjectValue(source1[rowIndex1][columnIndex]);
              checked { ++columnIndex; }
            }
            while (columnIndex <= 4);
            checked { ++rowIndex1; }
          }
          break;
        case 2:
          DataRow[] source2 = this.Products322Sub.Select(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "Ref = ", this.SearchResults[0, e.RowIndex].Value)));
          this.DataAdditional.Rows.Add(((IEnumerable<DataRow>) source2).Count<DataRow>());
          int num2 = Information.UBound((Array) source2);
          int rowIndex2 = 0;
          while (rowIndex2 <= num2)
          {
            int num3 = checked (this.Products322Sub.Columns.Count - 1);
            int columnIndex = 0;
            while (columnIndex <= num3)
            {
              this.DataAdditional[columnIndex, rowIndex2].Value = RuntimeHelpers.GetObjectValue(source2[rowIndex2][columnIndex]);
              checked { ++columnIndex; }
            }
            checked { ++rowIndex2; }
          }
          break;
      }
    }

    private void Products_Load(object sender, EventArgs e)
    {
      this.DataInfo.Columns.Clear();
      this.DataInfo.Rows.Clear();
      this.DataAdditional.Columns.Clear();
      this.DataAdditional.Rows.Clear();
      this.DataInfo.Columns.Add("C1", "C1");
      this.DataInfo.Columns.Add("C2", "C2");
      this.HideColumns();
      switch (this.Type)
      {
        case 1:
          int index1 = 0;
          do
          {
            this.DataAdditional.Columns.Add(this.Products321Sub.Columns[index1].ColumnName, this.Products321Sub.Columns[index1].ColumnName);
            checked { ++index1; }
          }
          while (index1 <= 4);
          this.DataAdditional.Columns[0].Visible = false;
          this.DataAdditional.Columns[1].Width = 115;
          this.DataAdditional.Columns[2].Width = 70;
          this.DataAdditional.Columns[3].Width = 35;
          this.DataAdditional.Columns[4].Width = 130;
          this.DataInfo.Rows.Add(12);
          this.DataInfo[0, 0].Value = (object) "Date Entry Updated";
          this.DataInfo[0, 1].Value = (object) "Manufacturer";
          this.DataInfo[0, 2].Value = (object) "Brand";
          this.DataInfo[0, 3].Value = (object) "Model Name";
          this.DataInfo[0, 4].Value = (object) "Model Qualifier";
          this.DataInfo[0, 5].Value = (object) "First Manufactored";
          this.DataInfo[0, 6].Value = (object) "Last Manufactored";
          this.DataInfo[0, 7].Value = (object) "Main Type";
          this.DataInfo[0, 8].Value = (object) "Integral Only";
          this.DataInfo[0, 9].Value = (object) "Ducting Type";
          this.DataInfo[0, 10].Value = (object) "Test Duct Size";
          this.DataInfo[0, 11].Value = (object) "Summer By Pass";
          this.DataInfo.Rows[6].Height = checked ((int) Math.Round(unchecked ((double) this.DataInfo.Rows[6].Height * 1.5)));
          break;
        case 2:
          int num = checked (this.Products321Sub.Columns.Count - 1);
          int index2 = 0;
          while (index2 <= num)
          {
            this.DataAdditional.Columns.Add(this.Products321Sub.Columns[index2].ColumnName, this.Products321Sub.Columns[index2].ColumnName);
            checked { ++index2; }
          }
          this.DataAdditional.Columns[0].Visible = false;
          this.DataAdditional.Columns[1].Width = 115;
          this.DataAdditional.Columns[2].Width = 70;
          this.DataAdditional.Columns[3].Width = 35;
          this.DataInfo.Rows.Add(8);
          this.DataInfo[0, 0].Value = (object) "Date Entry Updated";
          this.DataInfo[0, 1].Value = (object) "Manufacturer";
          this.DataInfo[0, 2].Value = (object) "Brand";
          this.DataInfo[0, 3].Value = (object) "Model Name";
          this.DataInfo[0, 4].Value = (object) "Model Qualifier";
          this.DataInfo[0, 5].Value = (object) "First Manufactored";
          this.DataInfo[0, 6].Value = (object) "Last Manufactored";
          this.DataInfo[0, 7].Value = (object) "Main Type";
          this.DataInfo[0, 8].Value = (object) "Ducting Type";
          break;
      }
      this.DataInfo.Columns[1].Width = 230;
      this.DataInfo.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
    }

    public void HideColumns()
    {
      this.Label1.Text = "Currently Showing " + Conversions.ToString(this.SearchResults.RowCount) + " out of " + Conversions.ToString(this.Rows);
      object objectValue1 = RuntimeHelpers.GetObjectValue(this.SearchResults.DataSource);
      if (objectValue1 is DataView)
      {
        object Counter;
        object LoopForResult;
        object objectValue2;
        if (!ObjectFlowControl.ForLoopControl.ForLoopInitObj(Counter, (object) 0, Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue1, (System.Type) null, "table", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Columns", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Count", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) 1), (object) 1, ref LoopForResult, ref objectValue2))
          return;
        do
        {
          object Left = objectValue2;
          if (!Conversions.ToBoolean((object) (bool) (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(Left, (object) 3, false)) || Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(Left, (object) 4, false)) || Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(Left, (object) 5, false)) ? 1 : (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(Left, (object) 6, false)) ? 1 : 0))))
          {
            object[] objArray;
            bool[] flagArray;
            object Instance = NewLateBinding.LateGet((object) this.SearchResults.Columns, (System.Type) null, "Item", objArray = new object[1]
            {
              objectValue2
            }, (string[]) null, (System.Type[]) null, flagArray = new bool[1]
            {
              true
            });
            if (flagArray[0])
              objectValue2 = RuntimeHelpers.GetObjectValue(objArray[0]);
            object[] Arguments = new object[1]
            {
              (object) false
            };
            NewLateBinding.LateSetComplex(Instance, (System.Type) null, "Visible", Arguments, (string[]) null, (System.Type[]) null, false, true);
          }
        }
        while (ObjectFlowControl.ForLoopControl.ForNextCheckObj(objectValue2, LoopForResult, ref objectValue2));
      }
      else
      {
        object Counter;
        object LoopForResult;
        object objectValue3;
        if (ObjectFlowControl.ForLoopControl.ForLoopInitObj(Counter, (object) 0, Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue1, (System.Type) null, "Columns", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Count", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) 1), (object) 1, ref LoopForResult, ref objectValue3))
        {
          do
          {
            object Left = objectValue3;
            if (!Conversions.ToBoolean((object) (bool) (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(Left, (object) 3, false)) || Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(Left, (object) 4, false)) || Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(Left, (object) 5, false)) ? 1 : (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(Left, (object) 6, false)) ? 1 : 0))))
            {
              object[] objArray;
              bool[] flagArray;
              object Instance = NewLateBinding.LateGet((object) this.SearchResults.Columns, (System.Type) null, "Item", objArray = new object[1]
              {
                objectValue3
              }, (string[]) null, (System.Type[]) null, flagArray = new bool[1]
              {
                true
              });
              if (flagArray[0])
                objectValue3 = RuntimeHelpers.GetObjectValue(objArray[0]);
              object[] Arguments = new object[1]
              {
                (object) false
              };
              NewLateBinding.LateSetComplex(Instance, (System.Type) null, "Visible", Arguments, (string[]) null, (System.Type[]) null, false, true);
            }
          }
          while (ObjectFlowControl.ForLoopControl.ForNextCheckObj(objectValue3, LoopForResult, ref objectValue3));
        }
      }
    }

    private void cmdAdd_Click(object sender, EventArgs e)
    {
      this.SearchCriteria.Rows.Add();
      this.SearchCriteria[0, checked (this.SearchCriteria.RowCount - 1)].Value = (object) this.txtPrimary.Text;
      this.SearchCriteria[1, checked (this.SearchCriteria.RowCount - 1)].Value = (object) this.txtCriteria.Text;
    }

    private void cmdClear_Click(object sender, EventArgs e)
    {
      string text = MyProject.Forms.SAPForm.txtMechVentilation.Text;
      this.dgvProducts.RowFilter = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "Balanced with heat recovery", false) == 0 ? " MainType='3' " : (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "Centralised whole house extract", false) == 0 ? " MainType='1' " : "");
      this.HideColumns();
    }

    private void cmdSearch_Click(object sender, EventArgs e)
    {
      string Left1 = "";
      DataTable dataTable = new DataTable();
      int num = checked (this.SearchCriteria.RowCount - 1);
      int rowIndex = 0;
      bool flag1;
      while (rowIndex <= num)
      {
        object Left2 = this.SearchCriteria[0, rowIndex].Value;
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left2, (object) "Index", false))
        {
          if (flag1)
          {
            Left1 = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left1, Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) " AND ID like '%", this.SearchCriteria[1, rowIndex].Value), (object) "%' ")));
          }
          else
          {
            Left1 = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left1, Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) " ID ID '%", this.SearchCriteria[1, rowIndex].Value), (object) "' ")));
            flag1 = true;
          }
        }
        else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left2, (object) "Manufacturer", false))
        {
          if (flag1)
          {
            Left1 = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left1, Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) " AND Manufacturer like '%", this.SearchCriteria[1, rowIndex].Value), (object) "%' ")));
          }
          else
          {
            Left1 = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left1, Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "  Manufacturer like '%", this.SearchCriteria[1, rowIndex].Value), (object) "%' ")));
            flag1 = true;
          }
        }
        else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left2, (object) "Brand", false))
        {
          if (flag1)
          {
            Left1 = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left1, Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) " AND Brand like '%", this.SearchCriteria[1, rowIndex].Value), (object) "%' ")));
          }
          else
          {
            Left1 = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left1, Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) " Brand like '%", this.SearchCriteria[1, rowIndex].Value), (object) "%' ")));
            flag1 = true;
          }
        }
        else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left2, (object) "Model Name", false))
        {
          if (flag1)
          {
            Left1 = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left1, Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) " AND Model like '%", this.SearchCriteria[1, rowIndex].Value), (object) "%' ")));
          }
          else
          {
            Left1 = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left1, Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) " Model like '%", this.SearchCriteria[1, rowIndex].Value), (object) "%' ")));
            flag1 = true;
          }
        }
        else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left2, (object) "Model Qualifier", false))
        {
          if (flag1)
          {
            Left1 = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left1, Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) " AND ModelQualifier like '%", this.SearchCriteria[1, rowIndex].Value), (object) "%' ")));
          }
          else
          {
            Left1 = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left1, Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) " ModelQualifier like '%", this.SearchCriteria[1, rowIndex].Value), (object) "%' ")));
            flag1 = true;
          }
        }
        checked { ++rowIndex; }
      }
      string text = MyProject.Forms.SAPForm.txtMechVentilation.Text;
      bool flag2;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "Balanced with heat recovery", false) != 0)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "Centralised whole house extract", false) == 0)
        {
          if (flag1)
          {
            Left1 += " AND MainType='1' ";
          }
          else
          {
            Left1 += " MainType='1' ";
            flag2 = true;
          }
        }
      }
      else if (flag1)
      {
        Left1 += " AND MainType='3' ";
      }
      else
      {
        Left1 += " MainType='3' ";
        flag2 = true;
      }
      this.dgvProducts.RowFilter = Left1;
      this.Label1.Text = "Currently Showing " + Conversions.ToString(this.SearchResults.RowCount) + " out of " + Conversions.ToString(this.Rows);
    }

    private void cmdBiolerData_Click(object sender, EventArgs e)
    {
      if (this.SearchResults.SelectedRows.Count == 1)
      {
        if (this.SearchResults.CurrentRow.Index > -1)
        {
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.ProductID = Conversions.ToInteger(this.SearchResults[0, this.SearchResults.CurrentRow.Index].Value);
          if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(MyProject.Forms.SAPForm.txtMechVentilation.Text, "Decentralised whole house extract", false) > 0U && this.DataAdditional.SelectedRows.Count > 0)
            MyProject.Forms.SAPForm.txtWetRooms.Value = Conversions.ToDecimal(this.DataAdditional[1, this.DataAdditional.SelectedRows[0].Index].Value);
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.ProductName = Conversions.ToString(this.SearchResults[2, this.SearchResults.CurrentRow.Index].Value);
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(MyProject.Forms.SAPForm.txtMechVentilation.Text, "Decentralised whole house extract", false) == 0)
          {
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Decentralised.KSPF1 = (float) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataAdditional[4, 0].Value));
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Decentralised.KSPF2 = (float) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataAdditional[4, 2].Value));
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Decentralised.KSPF3 = (float) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataAdditional[4, 4].Value));
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Decentralised.OSPF1 = (float) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataAdditional[4, 1].Value));
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Decentralised.OSPF2 = (float) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataAdditional[4, 3].Value));
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Decentralised.OSPF3 = (float) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataAdditional[4, 5].Value));
          }
          SAP_Read.ReadVentilation();
          this.Close();
        }
        else
        {
          int num1 = (int) Interaction.MsgBox((object) "Please select a product first.", MsgBoxStyle.OkCancel | MsgBoxStyle.Critical, (object) "Missing Selection");
        }
      }
      else
      {
        int num2 = (int) Interaction.MsgBox((object) "Please select a product first.", MsgBoxStyle.OkCancel | MsgBoxStyle.Critical, (object) "Missing Selection");
      }
    }

    private void txtPrimary_Click(object sender, EventArgs e) => this.txtPrimary.DroppedDown = true;

    private void txtPrimary_SelectedIndexChanged(object sender, EventArgs e)
    {
    }
  }
}
