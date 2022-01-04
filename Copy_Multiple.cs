
// Type: SAP2012.Copy_Multiple




using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using SAP2012.My;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SAP2012
{
  [DesignerGenerated]
  public class Copy_Multiple : Form
  {
    private IContainer components;
    private int NoofHouses;
    private Copy_Multiple.Item_s[] Items;

    public Copy_Multiple()
    {
      this.Load += new EventHandler(this.Copy_Multiple_Load);
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
      DataGridViewCellStyle gridViewCellStyle = new DataGridViewCellStyle();
      this.cmdCopy = new Button();
      this.txtItems = new NumericUpDown();
      this.Label1 = new Label();
      this.GroupBox1 = new GroupBox();
      this.Label7 = new Label();
      this.TxtShelteredSide = new TextBox();
      this.Label8 = new Label();
      this.TxtLocation = new TextBox();
      this.Label6 = new Label();
      this.txtAirTestResult = new TextBox();
      this.Label5 = new Label();
      this.txtOvershading = new TextBox();
      this.Label4 = new Label();
      this.txtOrientation = new TextBox();
      this.Label3 = new Label();
      this.txtAddress1 = new TextBox();
      this.Label2 = new Label();
      this.txtName = new TextBox();
      this.Button1 = new Button();
      this.Panel1 = new Panel();
      this.chkShading = new CheckBox();
      this.CheckBox1 = new CheckBox();
      this.dgvCopy = new BetterDataGrid();
      this.Plot_Name = new DataGridViewTextBoxColumn();
      this.AddressL1 = new DataGridViewTextBoxColumn();
      this.Orientation = new DataGridViewComboBoxColumn();
      this.Overshading = new DataGridViewComboBoxColumn();
      this.AirTestResult = new DataGridViewTextBoxColumn();
      this.Location = new DataGridViewComboBoxColumn();
      this.Sheltered_Side = new DataGridViewTextBoxColumn();
      this.txtItems.BeginInit();
      this.GroupBox1.SuspendLayout();
      this.Panel1.SuspendLayout();
      ((ISupportInitialize) this.dgvCopy).BeginInit();
      this.SuspendLayout();
      this.cmdCopy.BackColor = Color.LightSlateGray;
      this.cmdCopy.Cursor = Cursors.Hand;
      this.cmdCopy.DialogResult = DialogResult.OK;
      this.cmdCopy.FlatStyle = FlatStyle.Popup;
      this.cmdCopy.ForeColor = Color.White;
      this.cmdCopy.Location = new Point(13, 448);
      this.cmdCopy.Margin = new Padding(2, 3, 2, 3);
      this.cmdCopy.Name = "cmdCopy";
      this.cmdCopy.Size = new Size(158, 23);
      this.cmdCopy.TabIndex = 23;
      this.cmdCopy.Text = "Copy";
      this.cmdCopy.UseVisualStyleBackColor = false;
      this.txtItems.Cursor = Cursors.Hand;
      this.txtItems.Location = new Point(113, 12);
      this.txtItems.Margin = new Padding(2, 3, 2, 3);
      this.txtItems.Maximum = new Decimal(new int[4]
      {
        1000,
        0,
        0,
        0
      });
      this.txtItems.Name = "txtItems";
      this.txtItems.Size = new Size(58, 21);
      this.txtItems.TabIndex = 24;
      this.Label1.AutoSize = true;
      this.Label1.Location = new Point(9, 14);
      this.Label1.Margin = new Padding(2, 0, 2, 0);
      this.Label1.Name = "Label1";
      this.Label1.Size = new Size(92, 13);
      this.Label1.TabIndex = 25;
      this.Label1.Text = "Number of Copies";
      this.GroupBox1.Controls.Add((Control) this.Label7);
      this.GroupBox1.Controls.Add((Control) this.TxtShelteredSide);
      this.GroupBox1.Controls.Add((Control) this.Label8);
      this.GroupBox1.Controls.Add((Control) this.TxtLocation);
      this.GroupBox1.Controls.Add((Control) this.Label6);
      this.GroupBox1.Controls.Add((Control) this.txtAirTestResult);
      this.GroupBox1.Controls.Add((Control) this.Label5);
      this.GroupBox1.Controls.Add((Control) this.txtOvershading);
      this.GroupBox1.Controls.Add((Control) this.Label4);
      this.GroupBox1.Controls.Add((Control) this.txtOrientation);
      this.GroupBox1.Controls.Add((Control) this.Label3);
      this.GroupBox1.Controls.Add((Control) this.txtAddress1);
      this.GroupBox1.Controls.Add((Control) this.Label2);
      this.GroupBox1.Controls.Add((Control) this.txtName);
      this.GroupBox1.Location = new Point(3, 41);
      this.GroupBox1.Name = "GroupBox1";
      this.GroupBox1.Size = new Size(179, 316);
      this.GroupBox1.TabIndex = 28;
      this.GroupBox1.TabStop = false;
      this.GroupBox1.Text = "Copy Dwelling Details";
      this.Label7.AutoSize = true;
      this.Label7.Location = new Point(10, 263);
      this.Label7.Name = "Label7";
      this.Label7.Size = new Size(76, 13);
      this.Label7.TabIndex = 38;
      this.Label7.Text = "Sheltered Side";
      this.TxtShelteredSide.Location = new Point(10, 279);
      this.TxtShelteredSide.Name = "TxtShelteredSide";
      this.TxtShelteredSide.ReadOnly = true;
      this.TxtShelteredSide.Size = new Size(152, 21);
      this.TxtShelteredSide.TabIndex = 39;
      this.Label8.AutoSize = true;
      this.Label8.Location = new Point(10, 223);
      this.Label8.Name = "Label8";
      this.Label8.Size = new Size(47, 13);
      this.Label8.TabIndex = 36;
      this.Label8.Text = "Location";
      this.TxtLocation.Location = new Point(10, 239);
      this.TxtLocation.Name = "TxtLocation";
      this.TxtLocation.ReadOnly = true;
      this.TxtLocation.Size = new Size(152, 21);
      this.TxtLocation.TabIndex = 37;
      this.Label6.AutoSize = true;
      this.Label6.Location = new Point(10, 182);
      this.Label6.Name = "Label6";
      this.Label6.Size = new Size(77, 13);
      this.Label6.TabIndex = 34;
      this.Label6.Text = "Air Test Result";
      this.txtAirTestResult.Location = new Point(10, 198);
      this.txtAirTestResult.Name = "txtAirTestResult";
      this.txtAirTestResult.ReadOnly = true;
      this.txtAirTestResult.Size = new Size(152, 21);
      this.txtAirTestResult.TabIndex = 35;
      this.Label5.AutoSize = true;
      this.Label5.Location = new Point(10, 142);
      this.Label5.Name = "Label5";
      this.Label5.Size = new Size(68, 13);
      this.Label5.TabIndex = 32;
      this.Label5.Text = "Overshading";
      this.txtOvershading.Location = new Point(10, 158);
      this.txtOvershading.Name = "txtOvershading";
      this.txtOvershading.ReadOnly = true;
      this.txtOvershading.Size = new Size(152, 21);
      this.txtOvershading.TabIndex = 33;
      this.Label4.AutoSize = true;
      this.Label4.Location = new Point(10, 102);
      this.Label4.Name = "Label4";
      this.Label4.Size = new Size(61, 13);
      this.Label4.TabIndex = 30;
      this.Label4.Text = "Orientation";
      this.txtOrientation.Location = new Point(10, 118);
      this.txtOrientation.Name = "txtOrientation";
      this.txtOrientation.ReadOnly = true;
      this.txtOrientation.Size = new Size(152, 21);
      this.txtOrientation.TabIndex = 31;
      this.Label3.AutoSize = true;
      this.Label3.Location = new Point(10, 62);
      this.Label3.Name = "Label3";
      this.Label3.Size = new Size(77, 13);
      this.Label3.TabIndex = 28;
      this.Label3.Text = "Address Line 1";
      this.txtAddress1.Location = new Point(10, 78);
      this.txtAddress1.Name = "txtAddress1";
      this.txtAddress1.ReadOnly = true;
      this.txtAddress1.Size = new Size(152, 21);
      this.txtAddress1.TabIndex = 29;
      this.Label2.AutoSize = true;
      this.Label2.Location = new Point(10, 22);
      this.Label2.Name = "Label2";
      this.Label2.Size = new Size(76, 13);
      this.Label2.TabIndex = 26;
      this.Label2.Text = "Dwelling Name";
      this.txtName.Location = new Point(10, 38);
      this.txtName.Name = "txtName";
      this.txtName.ReadOnly = true;
      this.txtName.Size = new Size(152, 21);
      this.txtName.TabIndex = 27;
      this.Button1.BackColor = Color.LightSlateGray;
      this.Button1.Cursor = Cursors.Hand;
      this.Button1.DialogResult = DialogResult.Cancel;
      this.Button1.FlatStyle = FlatStyle.Popup;
      this.Button1.ForeColor = Color.White;
      this.Button1.Location = new Point(13, 627);
      this.Button1.Margin = new Padding(2, 3, 2, 3);
      this.Button1.Name = "Button1";
      this.Button1.Size = new Size(158, 23);
      this.Button1.TabIndex = 29;
      this.Button1.Text = "Cancel";
      this.Button1.UseVisualStyleBackColor = false;
      this.Panel1.Controls.Add((Control) this.chkShading);
      this.Panel1.Controls.Add((Control) this.CheckBox1);
      this.Panel1.Controls.Add((Control) this.GroupBox1);
      this.Panel1.Controls.Add((Control) this.Label1);
      this.Panel1.Controls.Add((Control) this.txtItems);
      this.Panel1.Controls.Add((Control) this.cmdCopy);
      this.Panel1.Dock = DockStyle.Left;
      this.Panel1.Location = new Point(0, 0);
      this.Panel1.Margin = new Padding(2, 3, 2, 3);
      this.Panel1.Name = "Panel1";
      this.Panel1.Size = new Size(182, 662);
      this.Panel1.TabIndex = 0;
      this.chkShading.AutoSize = true;
      this.chkShading.Checked = true;
      this.chkShading.CheckState = CheckState.Checked;
      this.chkShading.Location = new Point(13, 412);
      this.chkShading.Name = "chkShading";
      this.chkShading.Size = new Size(146, 30);
      this.chkShading.TabIndex = 31;
      this.chkShading.Text = "Make all openings \r\nOvershading as specified";
      this.chkShading.UseVisualStyleBackColor = true;
      this.CheckBox1.AutoSize = true;
      this.CheckBox1.Checked = true;
      this.CheckBox1.CheckState = CheckState.Checked;
      this.CheckBox1.Location = new Point(13, 363);
      this.CheckBox1.Name = "CheckBox1";
      this.CheckBox1.Size = new Size(148, 43);
      this.CheckBox1.TabIndex = 29;
      this.CheckBox1.Text = "Rotate all openings if \r\norientation different from\r\noriginal";
      this.CheckBox1.UseVisualStyleBackColor = true;
      this.dgvCopy.AllowUserToAddRows = false;
      this.dgvCopy.AllowUserToDeleteRows = false;
      this.dgvCopy.AllowUserToResizeRows = false;
      gridViewCellStyle.BackColor = Color.Honeydew;
      this.dgvCopy.AlternatingRowsDefaultCellStyle = gridViewCellStyle;
      this.dgvCopy.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvCopy.Columns.AddRange((DataGridViewColumn) this.Plot_Name, (DataGridViewColumn) this.AddressL1, (DataGridViewColumn) this.Orientation, (DataGridViewColumn) this.Overshading, (DataGridViewColumn) this.AirTestResult, (DataGridViewColumn) this.Location, (DataGridViewColumn) this.Sheltered_Side);
      this.dgvCopy.Cursor = Cursors.Hand;
      this.dgvCopy.Dock = DockStyle.Fill;
      this.dgvCopy.EditMode = DataGridViewEditMode.EditOnEnter;
      this.dgvCopy.Location = new Point(182, 0);
      this.dgvCopy.Margin = new Padding(2, 3, 2, 3);
      this.dgvCopy.Name = "dgvCopy";
      this.dgvCopy.ReadOnly = true;
      this.dgvCopy.RowHeadersWidth = 15;
      this.dgvCopy.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dgvCopy.Size = new Size(973, 662);
      this.dgvCopy.TabIndex = 1;
      this.Plot_Name.HeaderText = "Plot Name";
      this.Plot_Name.Name = "Plot_Name";
      this.Plot_Name.ReadOnly = true;
      this.Plot_Name.Width = 150;
      this.AddressL1.HeaderText = "Address Line 1";
      this.AddressL1.Name = "AddressL1";
      this.AddressL1.ReadOnly = true;
      this.AddressL1.Width = 150;
      this.Orientation.HeaderText = "Orientation";
      this.Orientation.Items.AddRange((object) "Unspecified", (object) "North", (object) "North East", (object) "East", (object) "South East", (object) "South", (object) "South West", (object) "West", (object) "North West");
      this.Orientation.Name = "Orientation";
      this.Orientation.ReadOnly = true;
      this.Orientation.Width = 150;
      this.Overshading.HeaderText = "Overshading";
      this.Overshading.Items.AddRange((object) "Heavy", (object) "More than average", (object) "Average or unknown", (object) "Very Little");
      this.Overshading.Name = "Overshading";
      this.Overshading.ReadOnly = true;
      this.Overshading.Width = 150;
      this.AirTestResult.HeaderText = "Air Test Result";
      this.AirTestResult.Name = "AirTestResult";
      this.AirTestResult.ReadOnly = true;
      this.AirTestResult.Resizable = DataGridViewTriState.True;
      this.AirTestResult.SortMode = DataGridViewColumnSortMode.NotSortable;
      this.AirTestResult.Width = 150;
      this.Location.HeaderText = "Location";
      this.Location.Name = "Location";
      this.Location.ReadOnly = true;
      this.Sheltered_Side.HeaderText = "Sheltered Side";
      this.Sheltered_Side.Name = "Sheltered_Side";
      this.Sheltered_Side.ReadOnly = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.White;
      this.ClientSize = new Size(1155, 662);
      this.Controls.Add((Control) this.Button1);
      this.Controls.Add((Control) this.dgvCopy);
      this.Controls.Add((Control) this.Panel1);
      this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.Margin = new Padding(2, 3, 2, 3);
      this.Name = nameof (Copy_Multiple);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Multiple Copy ";
      this.txtItems.EndInit();
      this.GroupBox1.ResumeLayout(false);
      this.GroupBox1.PerformLayout();
      this.Panel1.ResumeLayout(false);
      this.Panel1.PerformLayout();
      ((ISupportInitialize) this.dgvCopy).EndInit();
      this.ResumeLayout(false);
    }

    [field: AccessedThroughProperty("dgvCopy")]
    internal virtual BetterDataGrid dgvCopy { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button cmdCopy
    {
      get => this._cmdCopy;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdCopy_Click);
        Button cmdCopy1 = this._cmdCopy;
        if (cmdCopy1 != null)
          cmdCopy1.Click -= eventHandler;
        this._cmdCopy = value;
        Button cmdCopy2 = this._cmdCopy;
        if (cmdCopy2 == null)
          return;
        cmdCopy2.Click += eventHandler;
      }
    }

    internal virtual NumericUpDown txtItems
    {
      get => this._txtItems;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.NumericUpDown1_ValueChanged);
        NumericUpDown txtItems1 = this._txtItems;
        if (txtItems1 != null)
          txtItems1.ValueChanged -= eventHandler;
        this._txtItems = value;
        NumericUpDown txtItems2 = this._txtItems;
        if (txtItems2 == null)
          return;
        txtItems2.ValueChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Label1")]
    internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox1")]
    internal virtual GroupBox GroupBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label6")]
    internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtAirTestResult")]
    internal virtual TextBox txtAirTestResult { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label5")]
    internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtOvershading")]
    internal virtual TextBox txtOvershading { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label4")]
    internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtOrientation")]
    internal virtual TextBox txtOrientation { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label3")]
    internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtAddress1")]
    internal virtual TextBox txtAddress1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label2")]
    internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtName")]
    internal virtual TextBox txtName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Button1")]
    internal virtual Button Button1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Panel1")]
    internal virtual Panel Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("CheckBox1")]
    internal virtual CheckBox CheckBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chkShading")]
    internal virtual CheckBox chkShading { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label7")]
    internal virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("TxtShelteredSide")]
    internal virtual TextBox TxtShelteredSide { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label8")]
    internal virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("TxtLocation")]
    internal virtual TextBox TxtLocation { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Plot_Name")]
    internal virtual DataGridViewTextBoxColumn Plot_Name { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("AddressL1")]
    internal virtual DataGridViewTextBoxColumn AddressL1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Orientation")]
    internal virtual DataGridViewComboBoxColumn Orientation { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Overshading")]
    internal virtual DataGridViewComboBoxColumn Overshading { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("AirTestResult")]
    internal virtual DataGridViewTextBoxColumn AirTestResult { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Location")]
    internal virtual DataGridViewComboBoxColumn Location { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Sheltered_Side")]
    internal virtual DataGridViewTextBoxColumn Sheltered_Side { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private void Copy_Multiple_Load(object sender, EventArgs e)
    {
      DataGridViewComboBoxColumn viewComboBoxColumn = new DataGridViewComboBoxColumn();
      if (viewComboBoxColumn.Items.Count > 0)
        viewComboBoxColumn.Items.Clear();
      DataGridViewComboBoxColumn column = (DataGridViewComboBoxColumn) this.dgvCopy.Columns[5];
      string country = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Address.Country;
      if (Operators.CompareString(country, "Wales", false) != 0)
      {
        if (Operators.CompareString(country, "Scotland", false) == 0)
        {
          column.Items.Add((object) "East Scotland");
          column.Items.Add((object) "West Scotland");
          column.Items.Add((object) "North East Scotland");
          column.Items.Add((object) "South West Scotland");
          column.Items.Add((object) "Highland");
          column.Items.Add((object) "East Isles");
          column.Items.Add((object) "Western Isles");
          column.Items.Add((object) "Orkney");
          column.Items.Add((object) "Shetland");
          column.Items.Add((object) "Borders");
        }
        else
        {
          column.Items.Add((object) "Thames valley");
          column.Items.Add((object) "Severn valley");
          column.Items.Add((object) "South England");
          column.Items.Add((object) "South East England");
          column.Items.Add((object) "South West England");
          column.Items.Add((object) "Midlands");
          column.Items.Add((object) "East Anglia");
          column.Items.Add((object) "East Pennines");
          column.Items.Add((object) "West Pennines");
          column.Items.Add((object) "North West England");
          column.Items.Add((object) "North East England");
          column.Items.Add((object) "Borders");
        }
      }
      else
      {
        column.Items.Add((object) "Wales");
        column.Items.Add((object) "West Pennines");
        column.Items.Add((object) "Severn valley");
      }
      this.txtName.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Name;
      this.txtAddress1.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Address.Line1;
      this.txtOrientation.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Orientation;
      this.txtOvershading.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Overshading;
      this.TxtLocation.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Location;
      this.TxtShelteredSide.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Shelter);
      string pressure = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Pressure;
      if (Operators.CompareString(pressure, "Assumed", false) != 0)
      {
        if (Operators.CompareString(pressure, "As built", false) != 0)
        {
          if (Operators.CompareString(pressure, "As designed", false) != 0)
          {
            if (Operators.CompareString(pressure, "Calculated", false) == 0)
              this.txtAirTestResult.Text = "Calculated";
          }
          else
            this.txtAirTestResult.Text = "As built: " + Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.DesignAir);
        }
        else
          this.txtAirTestResult.Text = "As built: " + Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.MeasuredAir);
      }
      else
        this.txtAirTestResult.Text = "Assumed: " + Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.AssumedAir);
      this.dgvCopy.ReadOnly = false;
    }

    private void SaveItems()
    {
      try
      {
        if (this.Items == null || this.Items.Length <= 0)
          return;
        int num = checked (this.Items.Length - 1);
        int rowIndex = 0;
        while (rowIndex <= num)
        {
          this.Items[rowIndex].Name = Conversions.ToString(this.dgvCopy[0, rowIndex].Value);
          this.Items[rowIndex].AddressLine1 = Conversions.ToString(this.dgvCopy[1, rowIndex].Value);
          this.Items[rowIndex].Orientation = Conversions.ToString(this.dgvCopy[2, rowIndex].Value);
          this.Items[rowIndex].Overshading = Conversions.ToString(this.dgvCopy[3, rowIndex].Value);
          this.Items[rowIndex].Pressure = Conversions.ToSingle(this.dgvCopy[4, rowIndex].Value);
          this.Items[rowIndex].Location = Conversions.ToString(this.dgvCopy[5, rowIndex].Value);
          this.Items[rowIndex].Sheltered_Side = Conversions.ToSingle(this.dgvCopy[6, rowIndex].Value);
          checked { ++rowIndex; }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
    {
      this.SaveItems();
      try
      {
        // ISSUE: variable of a reference type
        Copy_Multiple.Item_s[]& local;
        // ISSUE: explicit reference operation
        Copy_Multiple.Item_s[] itemSArray = (Copy_Multiple.Item_s[]) Utils.CopyArray((Array) ^(local = ref this.Items), (Array) new Copy_Multiple.Item_s[checked (Convert.ToInt32(Decimal.Subtract(this.txtItems.Value, 1M)) + 1)]);
        local = itemSArray;
        this.dgvCopy.Rows.Clear();
        int num = checked (((IEnumerable<Copy_Multiple.Item_s>) this.Items).Count<Copy_Multiple.Item_s>() - 1);
        int rowIndex = 0;
        while (rowIndex <= num)
        {
          this.dgvCopy.Rows.Add();
          if (string.IsNullOrEmpty(this.Items[rowIndex].Name) & string.IsNullOrEmpty(this.Items[rowIndex].AddressLine1) & string.IsNullOrEmpty(this.Items[rowIndex].Orientation) & string.IsNullOrEmpty(this.Items[rowIndex].Overshading) & (double) this.Items[rowIndex].Pressure == 0.0)
          {
            this.Items[rowIndex].Name = "Plot " + Conversions.ToString(checked (SAP_Module.Proj.NoOfDwells + 1 + rowIndex));
            this.Items[rowIndex].AddressLine1 = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Address.Line1;
            this.Items[rowIndex].Orientation = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Orientation;
            this.Items[rowIndex].Overshading = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Overshading;
            this.Items[rowIndex].Location = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Location;
            this.Items[rowIndex].Sheltered_Side = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Shelter;
            string pressure = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Pressure;
            if (Operators.CompareString(pressure, "Assumed", false) != 0)
            {
              if (Operators.CompareString(pressure, "As built", false) != 0)
              {
                if (Operators.CompareString(pressure, "As designed", false) == 0)
                  this.Items[rowIndex].Pressure = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.DesignAir;
              }
              else
                this.Items[rowIndex].Pressure = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.MeasuredAir;
            }
            else
              this.Items[rowIndex].Pressure = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.AssumedAir;
          }
          this.dgvCopy[0, rowIndex].Value = (object) this.Items[rowIndex].Name;
          this.dgvCopy[1, rowIndex].Value = (object) this.Items[rowIndex].AddressLine1;
          this.dgvCopy[2, rowIndex].Value = (object) this.Items[rowIndex].Orientation;
          this.dgvCopy[3, rowIndex].Value = (object) this.Items[rowIndex].Overshading;
          this.dgvCopy[4, rowIndex].Value = (object) this.Items[rowIndex].Pressure;
          this.dgvCopy[5, rowIndex].Value = (object) this.Items[rowIndex].Location;
          this.dgvCopy[6, rowIndex].Value = (object) this.Items[rowIndex].Sheltered_Side;
          checked { ++rowIndex; }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Console.Write("");
        ProjectData.ClearProjectError();
      }
    }

    private void cmdCopy_Click(object sender, EventArgs e)
    {
      try
      {
        if (Interaction.MsgBox((object) ("Copy dwelling " + SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Reference + " " + Conversions.ToString(this.txtItems.Value) + " times?"), MsgBoxStyle.YesNo | MsgBoxStyle.Question, (object) "Multiple Copy") != MsgBoxResult.Yes)
          return;
        this.SaveItems();
        Application.DoEvents();
        int currDwelling = SAP_Module.CurrDwelling;
        MyProject.Forms.SAPForm.TreeSAP.SelectedNode = MyProject.Forms.SAPForm.TreeSAP.Nodes[0];
        Decimal d2 = Decimal.Subtract(this.txtItems.Value, 1M);
        for (Decimal d1 = 0M; Decimal.Compare(d1, d2) <= 0; d1 = Decimal.Add(d1, 1M))
        {
          // ISSUE: variable of a reference type
          int& local1;
          // ISSUE: explicit reference operation
          int num1 = checked (^(local1 = ref SAP_Module.Proj.NoOfDwells) + 1);
          local1 = num1;
          // ISSUE: variable of a reference type
          SAP_Module.Dwelling[]& local2;
          // ISSUE: explicit reference operation
          SAP_Module.Dwelling[] dwellingArray = (SAP_Module.Dwelling[]) Utils.CopyArray((Array) ^(local2 = ref SAP_Module.Proj.Dwellings), (Array) new SAP_Module.Dwelling[checked (SAP_Module.Proj.NoOfDwells - 1 + 1)]);
          local2 = dwellingArray;
          SAP_Module.Proj.Dwellings[checked (SAP_Module.Proj.NoOfDwells - 1)] = Functions.CopyDwelling(SAP_Module.Proj.Dwellings[currDwelling]);
          try
          {
            SAP_Module.Proj.Dwellings[checked (SAP_Module.Proj.NoOfDwells - 1)].Lodgement = (SAP_Module.Lodgement[]) null;
            SAP_Module.Proj.Dwellings[checked (SAP_Module.Proj.NoOfDwells - 1)].LodgementAttempts = 0;
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
          SAP_Module.Proj.Dwellings[checked (SAP_Module.Proj.NoOfDwells - 1)].Name = this.Items[Convert.ToInt32(d1)].Name;
          SAP_Module.Proj.Dwellings[checked (SAP_Module.Proj.NoOfDwells - 1)].YearBuilt = DateAndTime.Now.Year;
          SAP_Module.Proj.Dwellings[checked (SAP_Module.Proj.NoOfDwells - 1)].Address.Line1 = this.Items[Convert.ToInt32(d1)].AddressLine1;
          SAP_Module.Proj.Dwellings[checked (SAP_Module.Proj.NoOfDwells - 1)].Orientation = this.Items[Convert.ToInt32(d1)].Orientation;
          SAP_Module.Proj.Dwellings[checked (SAP_Module.Proj.NoOfDwells - 1)].Overshading = this.Items[Convert.ToInt32(d1)].Overshading;
          SAP_Module.Proj.Dwellings[checked (SAP_Module.Proj.NoOfDwells - 1)].Location = this.Items[Convert.ToInt32(d1)].Location;
          SAP_Module.Proj.Dwellings[checked (SAP_Module.Proj.NoOfDwells - 1)].Ventilation.Shelter = this.Items[Convert.ToInt32(d1)].Sheltered_Side;
          if ((uint) Operators.CompareString(SAP_Module.Proj.Dwellings[currDwelling].Orientation, this.Items[Convert.ToInt32(d1)].Orientation, false) > 0U & this.CheckBox1.Checked)
          {
            int orientationChange = this.GetOrientationChange(this.Items[Convert.ToInt32(d1)].Orientation, SAP_Module.Proj.Dwellings[currDwelling].Orientation);
            int num2 = checked (SAP_Module.Proj.Dwellings[SAP_Module.Proj.NoOfDwells - 1].NoofDoors - 1);
            int index1 = 0;
            while (index1 <= num2)
            {
              SAP_Module.Proj.Dwellings[checked (SAP_Module.Proj.NoOfDwells - 1)].Doors[index1].Orientation = this.ChangeOrientation(SAP_Module.Proj.Dwellings[checked (SAP_Module.Proj.NoOfDwells - 1)].Doors[index1].Orientation, orientationChange);
              checked { ++index1; }
            }
            int num3 = checked (SAP_Module.Proj.Dwellings[SAP_Module.Proj.NoOfDwells - 1].NoofWindows - 1);
            int index2 = 0;
            while (index2 <= num3)
            {
              SAP_Module.Proj.Dwellings[checked (SAP_Module.Proj.NoOfDwells - 1)].Windows[index2].Orientation = this.ChangeOrientation(SAP_Module.Proj.Dwellings[checked (SAP_Module.Proj.NoOfDwells - 1)].Windows[index2].Orientation, orientationChange);
              checked { ++index2; }
            }
            int num4 = checked (SAP_Module.Proj.Dwellings[SAP_Module.Proj.NoOfDwells - 1].NoofRoofLights - 1);
            int index3 = 0;
            while (index3 <= num4)
            {
              SAP_Module.Proj.Dwellings[checked (SAP_Module.Proj.NoOfDwells - 1)].RoofLights[index3].Orientation = this.ChangeOrientation(SAP_Module.Proj.Dwellings[checked (SAP_Module.Proj.NoOfDwells - 1)].RoofLights[index3].Orientation, orientationChange);
              checked { ++index3; }
            }
            try
            {
              if (SAP_Module.Proj.Dwellings[checked (SAP_Module.Proj.NoOfDwells - 1)].Renewable.Photovoltaic.Inlcude)
              {
                int num5 = checked (SAP_Module.Proj.Dwellings[SAP_Module.Proj.NoOfDwells - 1].Renewable.Photovoltaic.Photovoltaics.Length - 1);
                int index4 = 0;
                while (index4 <= num5)
                {
                  SAP_Module.Proj.Dwellings[checked (SAP_Module.Proj.NoOfDwells - 1)].Renewable.Photovoltaic.Photovoltaics[index4].PCOrientation = this.ChangeOrientation(SAP_Module.Proj.Dwellings[checked (SAP_Module.Proj.NoOfDwells - 1)].Renewable.Photovoltaic.Photovoltaics[index4].PCOrientation, orientationChange);
                  checked { ++index4; }
                }
              }
            }
            catch (Exception ex)
            {
              ProjectData.SetProjectError(ex);
              ProjectData.ClearProjectError();
            }
          }
          if (this.chkShading.Checked)
          {
            int num6 = checked (SAP_Module.Proj.Dwellings[SAP_Module.Proj.NoOfDwells - 1].NoofDoors - 1);
            int index5 = 0;
            while (index5 <= num6)
            {
              SAP_Module.Proj.Dwellings[checked (SAP_Module.Proj.NoOfDwells - 1)].Doors[index5].Overshading = this.Items[Convert.ToInt32(d1)].Overshading;
              checked { ++index5; }
            }
            int num7 = checked (SAP_Module.Proj.Dwellings[SAP_Module.Proj.NoOfDwells - 1].NoofWindows - 1);
            int index6 = 0;
            while (index6 <= num7)
            {
              SAP_Module.Proj.Dwellings[checked (SAP_Module.Proj.NoOfDwells - 1)].Windows[index6].Overshading = this.Items[Convert.ToInt32(d1)].Overshading;
              checked { ++index6; }
            }
            int num8 = checked (SAP_Module.Proj.Dwellings[SAP_Module.Proj.NoOfDwells - 1].NoofRoofLights - 1);
            int index7 = 0;
            while (index7 <= num8)
            {
              SAP_Module.Proj.Dwellings[checked (SAP_Module.Proj.NoOfDwells - 1)].RoofLights[index7].Overshading = this.Items[Convert.ToInt32(d1)].Overshading;
              checked { ++index7; }
            }
          }
          string pressure = SAP_Module.Proj.Dwellings[checked (SAP_Module.Proj.NoOfDwells - 1)].Ventilation.Pressure;
          if (Operators.CompareString(pressure, "Assumed", false) != 0)
          {
            if (Operators.CompareString(pressure, "As built", false) != 0)
            {
              if (Operators.CompareString(pressure, "As designed", false) == 0)
                SAP_Module.Proj.Dwellings[checked (SAP_Module.Proj.NoOfDwells - 1)].Ventilation.DesignAir = this.Items[Convert.ToInt32(d1)].Pressure;
            }
            else
              SAP_Module.Proj.Dwellings[checked (SAP_Module.Proj.NoOfDwells - 1)].Ventilation.MeasuredAir = this.Items[Convert.ToInt32(d1)].Pressure;
          }
          else
            SAP_Module.Proj.Dwellings[checked (SAP_Module.Proj.NoOfDwells - 1)].Ventilation.AssumedAir = this.Items[Convert.ToInt32(d1)].Pressure;
        }
        SAP_Module.CurrDwelling = checked (SAP_Module.Proj.NoOfDwells - 1);
        Functions.MakeTree();
        MyProject.Forms.SAPForm.TreeSAP.SelectedNode = MyProject.Forms.SAPForm.TreeSAP.Nodes[0].Nodes[SAP_Module.CurrDwelling];
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) ex.Message);
        ProjectData.ClearProjectError();
      }
    }

    private string ChangeOrientation(string Orientation, int Change)
    {
      string str1 = Orientation;
      string str2;
      // ISSUE: reference to a compiler-generated method
      switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(str1))
      {
        case 1128440633:
          if (Operators.CompareString(str1, "North East", false) == 0)
          {
            switch (Change)
            {
              case 0:
                str2 = "North East";
                break;
              case 1:
                str2 = "East";
                break;
              case 2:
                str2 = "South East";
                break;
              case 3:
                str2 = "South";
                break;
              case 4:
                str2 = "South West";
                break;
              case 5:
                str2 = "West";
                break;
              case 6:
                str2 = "North West";
                break;
              case 7:
                str2 = "North";
                break;
              default:
                goto label_83;
            }
          }
          else
            goto default;
          break;
        case 1409318971:
          if (Operators.CompareString(str1, "North West", false) == 0)
          {
            switch (Change)
            {
              case 0:
                str2 = "North West";
                break;
              case 1:
                str2 = "North";
                break;
              case 2:
                str2 = "North East";
                break;
              case 3:
                str2 = "East";
                break;
              case 4:
                str2 = "South East";
                break;
              case 5:
                str2 = "South";
                break;
              case 6:
                str2 = "South West";
                break;
              case 7:
                str2 = "West";
                break;
              default:
                goto label_83;
            }
          }
          else
            goto default;
          break;
        case 1731397980:
          if (Operators.CompareString(str1, "East", false) == 0)
          {
            switch (Change)
            {
              case 0:
                str2 = "East";
                break;
              case 1:
                str2 = "South East";
                break;
              case 2:
                str2 = "South";
                break;
              case 3:
                str2 = "South West";
                break;
              case 4:
                str2 = "West";
                break;
              case 5:
                str2 = "North West";
                break;
              case 6:
                str2 = "North";
                break;
              case 7:
                str2 = "North East";
                break;
              default:
                goto label_83;
            }
          }
          else
            goto default;
          break;
        case 1734234020:
          if (Operators.CompareString(str1, "North", false) == 0)
          {
            switch (Change)
            {
              case 0:
                str2 = "North";
                break;
              case 1:
                str2 = "North East";
                break;
              case 2:
                str2 = "East";
                break;
              case 3:
                str2 = "South East";
                break;
              case 4:
                str2 = "South";
                break;
              case 5:
                str2 = "South West";
                break;
              case 6:
                str2 = "West";
                break;
              case 7:
                str2 = "North West";
                break;
              default:
                goto label_83;
            }
          }
          else
            goto default;
          break;
        case 1796576718:
          if (Operators.CompareString(str1, "West", false) == 0)
          {
            switch (Change)
            {
              case 0:
                str2 = "West";
                break;
              case 1:
                str2 = "North West";
                break;
              case 2:
                str2 = "North";
                break;
              case 3:
                str2 = "North East";
                break;
              case 4:
                str2 = "East";
                break;
              case 5:
                str2 = "South East";
                break;
              case 6:
                str2 = "South";
                break;
              case 7:
                str2 = "South West";
                break;
              default:
                goto label_83;
            }
          }
          else
            goto default;
          break;
        case 1811125385:
          if (Operators.CompareString(str1, "Horizontal", false) == 0)
          {
            str2 = "Horizontal";
            break;
          }
          goto default;
        case 2417407149:
          if (Operators.CompareString(str1, "South West", false) == 0)
          {
            switch (Change)
            {
              case 0:
                str2 = "South West";
                break;
              case 1:
                str2 = "West";
                break;
              case 2:
                str2 = "North West";
                break;
              case 3:
                str2 = "North";
                break;
              case 4:
                str2 = "North East";
                break;
              case 5:
                str2 = "East";
                break;
              case 6:
                str2 = "South East";
                break;
              case 7:
                str2 = "South";
                break;
              default:
                goto label_83;
            }
          }
          else
            goto default;
          break;
        case 2853841879:
          if (Operators.CompareString(str1, "South East", false) == 0)
          {
            switch (Change)
            {
              case 0:
                str2 = "South East";
                break;
              case 1:
                str2 = "South";
                break;
              case 2:
                str2 = "South West";
                break;
              case 3:
                str2 = "West";
                break;
              case 4:
                str2 = "North West";
                break;
              case 5:
                str2 = "North";
                break;
              case 6:
                str2 = "North East";
                break;
              case 7:
                str2 = "East";
                break;
              default:
                goto label_83;
            }
          }
          else
            goto default;
          break;
        case 3017973530:
          if (Operators.CompareString(str1, "South", false) == 0)
          {
            switch (Change)
            {
              case 0:
                str2 = "South";
                break;
              case 1:
                str2 = "South West";
                break;
              case 2:
                str2 = "West";
                break;
              case 3:
                str2 = "North West";
                break;
              case 4:
                str2 = "North";
                break;
              case 5:
                str2 = "North East";
                break;
              case 6:
                str2 = "East";
                break;
              case 7:
                str2 = "South East";
                break;
              default:
                goto label_83;
            }
          }
          else
            goto default;
          break;
        default:
label_83:
          break;
      }
      return str2;
    }

    private int GetOrientationChange(string NewOrientation, string OriginalOrientation)
    {
      string str1 = OriginalOrientation;
      int orientationChange;
      // ISSUE: reference to a compiler-generated method
      switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(str1))
      {
        case 1128440633:
          if (Operators.CompareString(str1, "North East", false) == 0)
          {
            string str2 = NewOrientation;
            // ISSUE: reference to a compiler-generated method
            switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(str2))
            {
              case 1128440633:
                if (Operators.CompareString(str2, "North East", false) == 0)
                  goto label_137;
                else
                  goto label_137;
              case 1409318971:
                if (Operators.CompareString(str2, "North West", false) == 0)
                {
                  orientationChange = 6;
                  break;
                }
                goto label_137;
              case 1731397980:
                if (Operators.CompareString(str2, "East", false) == 0)
                {
                  orientationChange = 1;
                  break;
                }
                goto label_137;
              case 1734234020:
                if (Operators.CompareString(str2, "North", false) == 0)
                {
                  orientationChange = 7;
                  break;
                }
                goto label_137;
              case 1796576718:
                if (Operators.CompareString(str2, "West", false) == 0)
                {
                  orientationChange = 5;
                  break;
                }
                goto label_137;
              case 2417407149:
                if (Operators.CompareString(str2, "South West", false) == 0)
                {
                  orientationChange = 4;
                  break;
                }
                goto label_137;
              case 2853841879:
                if (Operators.CompareString(str2, "South East", false) == 0)
                {
                  orientationChange = 2;
                  break;
                }
                goto label_137;
              case 3017973530:
                if (Operators.CompareString(str2, "South", false) == 0)
                {
                  orientationChange = 3;
                  break;
                }
                goto label_137;
              default:
                goto label_137;
            }
          }
          else
            goto default;
          break;
        case 1409318971:
          if (Operators.CompareString(str1, "North West", false) == 0)
          {
            string str3 = NewOrientation;
            // ISSUE: reference to a compiler-generated method
            switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(str3))
            {
              case 1128440633:
                if (Operators.CompareString(str3, "North East", false) == 0)
                {
                  orientationChange = 2;
                  break;
                }
                goto label_137;
              case 1409318971:
                if (Operators.CompareString(str3, "North West", false) == 0)
                  goto label_137;
                else
                  goto label_137;
              case 1731397980:
                if (Operators.CompareString(str3, "East", false) == 0)
                {
                  orientationChange = 3;
                  break;
                }
                goto label_137;
              case 1734234020:
                if (Operators.CompareString(str3, "North", false) == 0)
                {
                  orientationChange = 1;
                  break;
                }
                goto label_137;
              case 1796576718:
                if (Operators.CompareString(str3, "West", false) == 0)
                {
                  orientationChange = 7;
                  break;
                }
                goto label_137;
              case 2417407149:
                if (Operators.CompareString(str3, "South West", false) == 0)
                {
                  orientationChange = 6;
                  break;
                }
                goto label_137;
              case 2853841879:
                if (Operators.CompareString(str3, "South East", false) == 0)
                {
                  orientationChange = 4;
                  break;
                }
                goto label_137;
              case 3017973530:
                if (Operators.CompareString(str3, "South", false) == 0)
                {
                  orientationChange = 5;
                  break;
                }
                goto label_137;
              default:
                goto label_137;
            }
          }
          else
            goto default;
          break;
        case 1731397980:
          if (Operators.CompareString(str1, "East", false) == 0)
          {
            string str4 = NewOrientation;
            // ISSUE: reference to a compiler-generated method
            switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(str4))
            {
              case 1128440633:
                if (Operators.CompareString(str4, "North East", false) == 0)
                {
                  orientationChange = 7;
                  break;
                }
                goto label_137;
              case 1409318971:
                if (Operators.CompareString(str4, "North West", false) == 0)
                {
                  orientationChange = 5;
                  break;
                }
                goto label_137;
              case 1731397980:
                if (Operators.CompareString(str4, "East", false) == 0)
                  goto label_137;
                else
                  goto label_137;
              case 1734234020:
                if (Operators.CompareString(str4, "North", false) == 0)
                {
                  orientationChange = 6;
                  break;
                }
                goto label_137;
              case 1796576718:
                if (Operators.CompareString(str4, "West", false) == 0)
                {
                  orientationChange = 4;
                  break;
                }
                goto label_137;
              case 2417407149:
                if (Operators.CompareString(str4, "South West", false) == 0)
                {
                  orientationChange = 3;
                  break;
                }
                goto label_137;
              case 2853841879:
                if (Operators.CompareString(str4, "South East", false) == 0)
                {
                  orientationChange = 1;
                  break;
                }
                goto label_137;
              case 3017973530:
                if (Operators.CompareString(str4, "South", false) == 0)
                {
                  orientationChange = 2;
                  break;
                }
                goto label_137;
              default:
                goto label_137;
            }
          }
          else
            goto default;
          break;
        case 1734234020:
          if (Operators.CompareString(str1, "North", false) == 0)
          {
            string str5 = NewOrientation;
            // ISSUE: reference to a compiler-generated method
            switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(str5))
            {
              case 1128440633:
                if (Operators.CompareString(str5, "North East", false) == 0)
                {
                  orientationChange = 1;
                  break;
                }
                goto label_137;
              case 1409318971:
                if (Operators.CompareString(str5, "North West", false) == 0)
                {
                  orientationChange = 7;
                  break;
                }
                goto label_137;
              case 1731397980:
                if (Operators.CompareString(str5, "East", false) == 0)
                {
                  orientationChange = 2;
                  break;
                }
                goto label_137;
              case 1734234020:
                if (Operators.CompareString(str5, "North", false) == 0)
                  goto label_137;
                else
                  goto label_137;
              case 1796576718:
                if (Operators.CompareString(str5, "West", false) == 0)
                {
                  orientationChange = 6;
                  break;
                }
                goto label_137;
              case 2417407149:
                if (Operators.CompareString(str5, "South West", false) == 0)
                {
                  orientationChange = 5;
                  break;
                }
                goto label_137;
              case 2853841879:
                if (Operators.CompareString(str5, "South East", false) == 0)
                {
                  orientationChange = 3;
                  break;
                }
                goto label_137;
              case 3017973530:
                if (Operators.CompareString(str5, "South", false) == 0)
                {
                  orientationChange = 4;
                  break;
                }
                goto label_137;
              default:
                goto label_137;
            }
          }
          else
            goto default;
          break;
        case 1796576718:
          if (Operators.CompareString(str1, "West", false) == 0)
          {
            string str6 = NewOrientation;
            // ISSUE: reference to a compiler-generated method
            switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(str6))
            {
              case 1128440633:
                if (Operators.CompareString(str6, "North East", false) == 0)
                {
                  orientationChange = 3;
                  break;
                }
                goto label_137;
              case 1409318971:
                if (Operators.CompareString(str6, "North West", false) == 0)
                {
                  orientationChange = 1;
                  break;
                }
                goto label_137;
              case 1731397980:
                if (Operators.CompareString(str6, "East", false) == 0)
                {
                  orientationChange = 4;
                  break;
                }
                goto label_137;
              case 1734234020:
                if (Operators.CompareString(str6, "North", false) == 0)
                {
                  orientationChange = 2;
                  break;
                }
                goto label_137;
              case 1796576718:
                if (Operators.CompareString(str6, "West", false) == 0)
                  goto label_137;
                else
                  goto label_137;
              case 2417407149:
                if (Operators.CompareString(str6, "South West", false) == 0)
                {
                  orientationChange = 7;
                  break;
                }
                goto label_137;
              case 2853841879:
                if (Operators.CompareString(str6, "South East", false) == 0)
                {
                  orientationChange = 5;
                  break;
                }
                goto label_137;
              case 3017973530:
                if (Operators.CompareString(str6, "South", false) == 0)
                {
                  orientationChange = 6;
                  break;
                }
                goto label_137;
              default:
                goto label_137;
            }
          }
          else
            goto default;
          break;
        case 2417407149:
          if (Operators.CompareString(str1, "South West", false) == 0)
          {
            string str7 = NewOrientation;
            // ISSUE: reference to a compiler-generated method
            switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(str7))
            {
              case 1128440633:
                if (Operators.CompareString(str7, "North East", false) == 0)
                {
                  orientationChange = 4;
                  break;
                }
                goto label_137;
              case 1409318971:
                if (Operators.CompareString(str7, "North West", false) == 0)
                {
                  orientationChange = 2;
                  break;
                }
                goto label_137;
              case 1731397980:
                if (Operators.CompareString(str7, "East", false) == 0)
                {
                  orientationChange = 5;
                  break;
                }
                goto label_137;
              case 1734234020:
                if (Operators.CompareString(str7, "North", false) == 0)
                {
                  orientationChange = 3;
                  break;
                }
                goto label_137;
              case 1796576718:
                if (Operators.CompareString(str7, "West", false) == 0)
                {
                  orientationChange = 1;
                  break;
                }
                goto label_137;
              case 2417407149:
                if (Operators.CompareString(str7, "South West", false) == 0)
                  goto label_137;
                else
                  goto label_137;
              case 2853841879:
                if (Operators.CompareString(str7, "South East", false) == 0)
                {
                  orientationChange = 6;
                  break;
                }
                goto label_137;
              case 3017973530:
                if (Operators.CompareString(str7, "South", false) == 0)
                {
                  orientationChange = 7;
                  break;
                }
                goto label_137;
              default:
                goto label_137;
            }
          }
          else
            goto default;
          break;
        case 2853841879:
          if (Operators.CompareString(str1, "South East", false) == 0)
          {
            string str8 = NewOrientation;
            // ISSUE: reference to a compiler-generated method
            switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(str8))
            {
              case 1128440633:
                if (Operators.CompareString(str8, "North East", false) == 0)
                {
                  orientationChange = 6;
                  break;
                }
                goto label_137;
              case 1409318971:
                if (Operators.CompareString(str8, "North West", false) == 0)
                {
                  orientationChange = 4;
                  break;
                }
                goto label_137;
              case 1731397980:
                if (Operators.CompareString(str8, "East", false) == 0)
                {
                  orientationChange = 7;
                  break;
                }
                goto label_137;
              case 1734234020:
                if (Operators.CompareString(str8, "North", false) == 0)
                {
                  orientationChange = 5;
                  break;
                }
                goto label_137;
              case 1796576718:
                if (Operators.CompareString(str8, "West", false) == 0)
                {
                  orientationChange = 3;
                  break;
                }
                goto label_137;
              case 2417407149:
                if (Operators.CompareString(str8, "South West", false) == 0)
                {
                  orientationChange = 2;
                  break;
                }
                goto label_137;
              case 2853841879:
                if (Operators.CompareString(str8, "South East", false) == 0)
                  goto label_137;
                else
                  goto label_137;
              case 3017973530:
                if (Operators.CompareString(str8, "South", false) == 0)
                {
                  orientationChange = 1;
                  break;
                }
                goto label_137;
              default:
                goto label_137;
            }
          }
          else
            goto default;
          break;
        case 3017973530:
          if (Operators.CompareString(str1, "South", false) == 0)
          {
            string str9 = NewOrientation;
            // ISSUE: reference to a compiler-generated method
            switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(str9))
            {
              case 1128440633:
                if (Operators.CompareString(str9, "North East", false) == 0)
                {
                  orientationChange = 5;
                  break;
                }
                goto label_137;
              case 1409318971:
                if (Operators.CompareString(str9, "North West", false) == 0)
                {
                  orientationChange = 3;
                  break;
                }
                goto label_137;
              case 1731397980:
                if (Operators.CompareString(str9, "East", false) == 0)
                {
                  orientationChange = 6;
                  break;
                }
                goto label_137;
              case 1734234020:
                if (Operators.CompareString(str9, "North", false) == 0)
                {
                  orientationChange = 4;
                  break;
                }
                goto label_137;
              case 1796576718:
                if (Operators.CompareString(str9, "West", false) == 0)
                {
                  orientationChange = 2;
                  break;
                }
                goto label_137;
              case 2417407149:
                if (Operators.CompareString(str9, "South West", false) == 0)
                {
                  orientationChange = 1;
                  break;
                }
                goto label_137;
              case 2853841879:
                if (Operators.CompareString(str9, "South East", false) == 0)
                {
                  orientationChange = 7;
                  break;
                }
                goto label_137;
              case 3017973530:
                if (Operators.CompareString(str9, "South", false) == 0)
                  goto label_137;
                else
                  goto label_137;
              default:
                goto label_137;
            }
          }
          else
            goto default;
          break;
        default:
label_137:
          break;
      }
      return orientationChange;
    }

    private struct Item_s
    {
      public string Name;
      public string AddressLine1;
      public string Orientation;
      public string Overshading;
      public float Pressure;
      public string Location;
      public float Sheltered_Side;
    }
  }
}
