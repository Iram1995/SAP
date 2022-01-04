
// Type: SAP2012.CalculationType_ScotlandOnly




using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using SAP2012.My;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SAP2012
{
  [DesignerGenerated]
  public class CalculationType_ScotlandOnly : Form
  {
    private IContainer components;
    private bool DontAdd;
    private bool DontSave;

    public CalculationType_ScotlandOnly()
    {
      this.Load += new EventHandler(this.CalculationType_ScotlandOnly_Load);
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
      this.Button1 = new Button();
      this.RadioButton5 = new RadioButton();
      this.RadioButton4 = new RadioButton();
      this.RadioButton3 = new RadioButton();
      this.RadioButton2 = new RadioButton();
      this.RadioButton1 = new RadioButton();
      this.cmdClose = new Button();
      this.Button2 = new Button();
      this.GroupBox13 = new GroupBox();
      this.cmdArea = new Button();
      this.Dims = new DataGridView();
      this.Storey = new DataGridViewTextBoxColumn();
      this.Basement = new DataGridViewComboBoxColumn();
      this.Area = new DataGridViewTextBoxColumn();
      this.Height = new DataGridViewTextBoxColumn();
      this.Volume = new DataGridViewTextBoxColumn();
      this.txtLivingArea = new TextBox();
      this.Label80 = new Label();
      this.txtLivingFraction = new TextBox();
      this.Label79 = new Label();
      this.Label78 = new Label();
      this.GroupBox10 = new GroupBox();
      this.txtWallArea = new TextBox();
      this.Label8 = new Label();
      this.txtRoofArea = new TextBox();
      this.Label7 = new Label();
      this.Label5 = new Label();
      this.txtDimsArea = new TextBox();
      this.Label2 = new Label();
      this.Label1 = new Label();
      this.GroupBox1 = new GroupBox();
      this.Label6 = new Label();
      this.Label3 = new Label();
      this.Label4 = new Label();
      this.txtPwall = new TextBox();
      this.ErrorPChecker = new ErrorProvider(this.components);
      this.GroupBox13.SuspendLayout();
      ((ISupportInitialize) this.Dims).BeginInit();
      this.GroupBox10.SuspendLayout();
      this.GroupBox1.SuspendLayout();
      ((ISupportInitialize) this.ErrorPChecker).BeginInit();
      this.SuspendLayout();
      this.Button1.BackColor = Color.LightSlateGray;
      this.Button1.Cursor = Cursors.Hand;
      this.Button1.DialogResult = DialogResult.Abort;
      this.Button1.FlatStyle = FlatStyle.Popup;
      this.Button1.Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button1.ForeColor = Color.White;
      this.Button1.Location = new Point(887, 458);
      this.Button1.Name = "Button1";
      this.Button1.Size = new Size(95, 26);
      this.Button1.TabIndex = 33;
      this.Button1.Text = "Cancel";
      this.Button1.UseVisualStyleBackColor = false;
      this.RadioButton5.AutoSize = true;
      this.RadioButton5.FlatStyle = FlatStyle.Popup;
      this.RadioButton5.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.RadioButton5.Location = new Point(15, 462);
      this.RadioButton5.Name = "RadioButton5";
      this.RadioButton5.Size = new Size(154, 22);
      this.RadioButton5.TabIndex = 31;
      this.RadioButton5.Text = "Biomass Package 5";
      this.RadioButton5.UseVisualStyleBackColor = true;
      this.RadioButton4.AutoSize = true;
      this.RadioButton4.FlatStyle = FlatStyle.Popup;
      this.RadioButton4.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.RadioButton4.Location = new Point(15, 437);
      this.RadioButton4.Name = "RadioButton4";
      this.RadioButton4.Size = new Size(159, 22);
      this.RadioButton4.TabIndex = 30;
      this.RadioButton4.Text = "Electricity Package 4";
      this.RadioButton4.UseVisualStyleBackColor = true;
      this.RadioButton3.AutoSize = true;
      this.RadioButton3.FlatStyle = FlatStyle.Popup;
      this.RadioButton3.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.RadioButton3.Location = new Point(15, 412);
      this.RadioButton3.Name = "RadioButton3";
      this.RadioButton3.Size = new Size(115, 22);
      this.RadioButton3.TabIndex = 29;
      this.RadioButton3.Text = "Oil Package 3";
      this.RadioButton3.UseVisualStyleBackColor = true;
      this.RadioButton2.AutoSize = true;
      this.RadioButton2.FlatStyle = FlatStyle.Popup;
      this.RadioButton2.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.RadioButton2.Location = new Point(15, 387);
      this.RadioButton2.Name = "RadioButton2";
      this.RadioButton2.Size = new Size(125, 22);
      this.RadioButton2.TabIndex = 28;
      this.RadioButton2.Text = "LPG Package 2";
      this.RadioButton2.UseVisualStyleBackColor = true;
      this.RadioButton1.AutoSize = true;
      this.RadioButton1.Checked = true;
      this.RadioButton1.FlatStyle = FlatStyle.Popup;
      this.RadioButton1.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.RadioButton1.Location = new Point(15, 362);
      this.RadioButton1.Name = "RadioButton1";
      this.RadioButton1.Size = new Size(125, 22);
      this.RadioButton1.TabIndex = 27;
      this.RadioButton1.TabStop = true;
      this.RadioButton1.Text = "Gas package 1";
      this.RadioButton1.UseVisualStyleBackColor = true;
      this.cmdClose.BackColor = Color.LightSlateGray;
      this.cmdClose.Cursor = Cursors.Hand;
      this.cmdClose.DialogResult = DialogResult.OK;
      this.cmdClose.FlatStyle = FlatStyle.Popup;
      this.cmdClose.Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.cmdClose.ForeColor = Color.White;
      this.cmdClose.Location = new Point(887, 487);
      this.cmdClose.Name = "cmdClose";
      this.cmdClose.Size = new Size(95, 26);
      this.cmdClose.TabIndex = 26;
      this.cmdClose.Text = "OK/Apply";
      this.cmdClose.UseVisualStyleBackColor = false;
      this.Button2.BackColor = Color.LightSlateGray;
      this.Button2.Cursor = Cursors.Hand;
      this.Button2.FlatStyle = FlatStyle.Popup;
      this.Button2.ForeColor = Color.White;
      this.Button2.Location = new Point(568, 313);
      this.Button2.Name = "Button2";
      this.Button2.Size = new Size(92, 25);
      this.Button2.TabIndex = 36;
      this.Button2.Text = "Remove Row";
      this.Button2.UseVisualStyleBackColor = false;
      this.GroupBox13.Controls.Add((Control) this.Button2);
      this.GroupBox13.Controls.Add((Control) this.cmdArea);
      this.GroupBox13.Controls.Add((Control) this.Dims);
      this.GroupBox13.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.GroupBox13.Location = new Point(12, 12);
      this.GroupBox13.Name = "GroupBox13";
      this.GroupBox13.Size = new Size(666, 344);
      this.GroupBox13.TabIndex = 34;
      this.GroupBox13.TabStop = false;
      this.GroupBox13.Text = "Dwelling Dimensions";
      this.cmdArea.BackColor = Color.LightSlateGray;
      this.cmdArea.Cursor = Cursors.Hand;
      this.cmdArea.FlatStyle = FlatStyle.Popup;
      this.cmdArea.ForeColor = Color.White;
      this.cmdArea.Location = new Point(330, 49);
      this.cmdArea.Name = "cmdArea";
      this.cmdArea.Size = new Size(29, 22);
      this.cmdArea.TabIndex = 17;
      this.cmdArea.Text = "...";
      this.cmdArea.UseVisualStyleBackColor = false;
      this.cmdArea.Visible = false;
      this.Dims.AllowUserToResizeColumns = false;
      this.Dims.AllowUserToResizeRows = false;
      this.Dims.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.Dims.Columns.AddRange((DataGridViewColumn) this.Storey, (DataGridViewColumn) this.Basement, (DataGridViewColumn) this.Area, (DataGridViewColumn) this.Height, (DataGridViewColumn) this.Volume);
      this.Dims.Dock = DockStyle.Fill;
      this.Dims.EditMode = DataGridViewEditMode.EditOnEnter;
      this.Dims.Location = new Point(3, 22);
      this.Dims.Name = "Dims";
      this.Dims.RowHeadersWidth = 24;
      this.Dims.RowTemplate.Resizable = DataGridViewTriState.False;
      this.Dims.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.Dims.Size = new Size(660, 319);
      this.Dims.TabIndex = 0;
      gridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
      this.Storey.DefaultCellStyle = gridViewCellStyle1;
      this.Storey.HeaderText = "Storey";
      this.Storey.Name = "Storey";
      this.Storey.ReadOnly = true;
      this.Storey.SortMode = DataGridViewColumnSortMode.NotSortable;
      this.Basement.FlatStyle = FlatStyle.Popup;
      this.Basement.HeaderText = "Basement";
      this.Basement.Items.AddRange((object) "Yes", (object) "No");
      this.Basement.Name = "Basement";
      this.Basement.Resizable = DataGridViewTriState.True;
      gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.Area.DefaultCellStyle = gridViewCellStyle2;
      this.Area.HeaderText = "Floor Area";
      this.Area.Name = "Area";
      this.Area.Resizable = DataGridViewTriState.True;
      this.Area.SortMode = DataGridViewColumnSortMode.NotSortable;
      gridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.Height.DefaultCellStyle = gridViewCellStyle3;
      this.Height.HeaderText = "Height";
      this.Height.Name = "Height";
      this.Height.SortMode = DataGridViewColumnSortMode.NotSortable;
      gridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
      gridViewCellStyle4.BackColor = Color.FromArgb(224, 224, 224);
      this.Volume.DefaultCellStyle = gridViewCellStyle4;
      this.Volume.HeaderText = "Volume";
      this.Volume.Name = "Volume";
      this.Volume.ReadOnly = true;
      this.Volume.SortMode = DataGridViewColumnSortMode.NotSortable;
      this.txtLivingArea.Location = new Point(159, 26);
      this.txtLivingArea.Name = "txtLivingArea";
      this.txtLivingArea.Size = new Size(91, 26);
      this.txtLivingArea.TabIndex = 15;
      this.txtLivingArea.TextAlign = HorizontalAlignment.Right;
      this.Label80.AutoSize = true;
      this.Label80.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label80.Location = new Point(13, 29);
      this.Label80.Name = "Label80";
      this.Label80.Size = new Size(116, 18);
      this.Label80.TabIndex = 14;
      this.Label80.Text = "Total Living Area";
      this.txtLivingFraction.Location = new Point(159, 54);
      this.txtLivingFraction.Name = "txtLivingFraction";
      this.txtLivingFraction.Size = new Size(91, 26);
      this.txtLivingFraction.TabIndex = 17;
      this.txtLivingFraction.TextAlign = HorizontalAlignment.Right;
      this.Label79.AutoSize = true;
      this.Label79.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label79.Location = new Point(13, 57);
      this.Label79.Name = "Label79";
      this.Label79.Size = new Size(134, 18);
      this.Label79.TabIndex = 16;
      this.Label79.Text = "Living Area Fraction";
      this.Label78.AutoSize = true;
      this.Label78.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label78.Location = new Point(256, 29);
      this.Label78.Name = "Label78";
      this.Label78.Size = new Size(28, 18);
      this.Label78.TabIndex = 18;
      this.Label78.Text = "m\u00B2";
      this.GroupBox10.Controls.Add((Control) this.Label78);
      this.GroupBox10.Controls.Add((Control) this.Label79);
      this.GroupBox10.Controls.Add((Control) this.txtLivingFraction);
      this.GroupBox10.Controls.Add((Control) this.Label80);
      this.GroupBox10.Controls.Add((Control) this.txtLivingArea);
      this.GroupBox10.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.GroupBox10.Location = new Point(684, 161);
      this.GroupBox10.Name = "GroupBox10";
      this.GroupBox10.Size = new Size(298, 89);
      this.GroupBox10.TabIndex = 10;
      this.GroupBox10.TabStop = false;
      this.GroupBox10.Text = "Summary";
      this.txtWallArea.Location = new Point(159, 21);
      this.txtWallArea.Name = "txtWallArea";
      this.txtWallArea.Size = new Size(91, 26);
      this.txtWallArea.TabIndex = 5;
      this.txtWallArea.TextAlign = HorizontalAlignment.Right;
      this.Label8.AutoSize = true;
      this.Label8.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label8.Location = new Point(10, 24);
      this.Label8.Name = "Label8";
      this.Label8.Size = new Size(69, 18);
      this.Label8.TabIndex = 4;
      this.Label8.Text = "Wall Area";
      this.txtRoofArea.Location = new Point(159, 49);
      this.txtRoofArea.Name = "txtRoofArea";
      this.txtRoofArea.Size = new Size(91, 26);
      this.txtRoofArea.TabIndex = 7;
      this.txtRoofArea.TextAlign = HorizontalAlignment.Right;
      this.Label7.AutoSize = true;
      this.Label7.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label7.Location = new Point(10, 53);
      this.Label7.Name = "Label7";
      this.Label7.Size = new Size(111, 18);
      this.Label7.TabIndex = 6;
      this.Label7.Text = "Total Roof Area";
      this.Label5.AutoSize = true;
      this.Label5.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label5.Location = new Point(256, 53);
      this.Label5.Name = "Label5";
      this.Label5.Size = new Size(28, 18);
      this.Label5.TabIndex = 10;
      this.Label5.Text = "m\u00B2";
      this.txtDimsArea.Location = new Point(159, 77);
      this.txtDimsArea.Name = "txtDimsArea";
      this.txtDimsArea.Size = new Size(91, 26);
      this.txtDimsArea.TabIndex = 21;
      this.txtDimsArea.TextAlign = HorizontalAlignment.Right;
      this.Label2.AutoSize = true;
      this.Label2.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label2.Location = new Point(10, 81);
      this.Label2.Name = "Label2";
      this.Label2.Size = new Size(112, 18);
      this.Label2.TabIndex = 20;
      this.Label2.Text = "Total Floor Area";
      this.Label1.AutoSize = true;
      this.Label1.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label1.Location = new Point(256, 81);
      this.Label1.Name = "Label1";
      this.Label1.Size = new Size(28, 18);
      this.Label1.TabIndex = 22;
      this.Label1.Text = "m\u00B2";
      this.GroupBox1.Controls.Add((Control) this.Label6);
      this.GroupBox1.Controls.Add((Control) this.Label3);
      this.GroupBox1.Controls.Add((Control) this.Label4);
      this.GroupBox1.Controls.Add((Control) this.txtPwall);
      this.GroupBox1.Controls.Add((Control) this.Label1);
      this.GroupBox1.Controls.Add((Control) this.Label2);
      this.GroupBox1.Controls.Add((Control) this.txtDimsArea);
      this.GroupBox1.Controls.Add((Control) this.Label5);
      this.GroupBox1.Controls.Add((Control) this.Label7);
      this.GroupBox1.Controls.Add((Control) this.txtRoofArea);
      this.GroupBox1.Controls.Add((Control) this.Label8);
      this.GroupBox1.Controls.Add((Control) this.txtWallArea);
      this.GroupBox1.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.GroupBox1.Location = new Point(684, 12);
      this.GroupBox1.Name = "GroupBox1";
      this.GroupBox1.Size = new Size(298, 143);
      this.GroupBox1.TabIndex = 11;
      this.GroupBox1.TabStop = false;
      this.GroupBox1.Text = "Areas";
      this.Label6.AutoSize = true;
      this.Label6.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label6.Location = new Point(256, 24);
      this.Label6.Name = "Label6";
      this.Label6.Size = new Size(28, 18);
      this.Label6.TabIndex = 26;
      this.Label6.Text = "m\u00B2";
      this.Label3.AutoSize = true;
      this.Label3.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label3.Location = new Point(256, 109);
      this.Label3.Name = "Label3";
      this.Label3.Size = new Size(28, 18);
      this.Label3.TabIndex = 25;
      this.Label3.Text = "m\u00B2";
      this.Label4.AutoSize = true;
      this.Label4.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label4.Location = new Point(10, 109);
      this.Label4.Name = "Label4";
      this.Label4.Size = new Size(108, 18);
      this.Label4.TabIndex = 23;
      this.Label4.Text = "Party Wall Area";
      this.txtPwall.Location = new Point(159, 105);
      this.txtPwall.Name = "txtPwall";
      this.txtPwall.Size = new Size(91, 26);
      this.txtPwall.TabIndex = 24;
      this.txtPwall.TextAlign = HorizontalAlignment.Right;
      this.ErrorPChecker.BlinkStyle = ErrorBlinkStyle.NeverBlink;
      this.ErrorPChecker.ContainerControl = (ContainerControl) this;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.White;
      this.ClientSize = new Size(994, 522);
      this.Controls.Add((Control) this.GroupBox13);
      this.Controls.Add((Control) this.GroupBox1);
      this.Controls.Add((Control) this.GroupBox10);
      this.Controls.Add((Control) this.Button1);
      this.Controls.Add((Control) this.RadioButton5);
      this.Controls.Add((Control) this.RadioButton4);
      this.Controls.Add((Control) this.RadioButton3);
      this.Controls.Add((Control) this.RadioButton2);
      this.Controls.Add((Control) this.RadioButton1);
      this.Controls.Add((Control) this.cmdClose);
      this.Cursor = Cursors.Hand;
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (CalculationType_ScotlandOnly);
      this.Padding = new Padding(9);
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Simplified Approach";
      this.TopMost = true;
      this.GroupBox13.ResumeLayout(false);
      ((ISupportInitialize) this.Dims).EndInit();
      this.GroupBox10.ResumeLayout(false);
      this.GroupBox10.PerformLayout();
      this.GroupBox1.ResumeLayout(false);
      this.GroupBox1.PerformLayout();
      ((ISupportInitialize) this.ErrorPChecker).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
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

    [field: AccessedThroughProperty("RadioButton5")]
    internal virtual RadioButton RadioButton5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("RadioButton4")]
    internal virtual RadioButton RadioButton4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("RadioButton3")]
    internal virtual RadioButton RadioButton3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("RadioButton2")]
    internal virtual RadioButton RadioButton2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("RadioButton1")]
    internal virtual RadioButton RadioButton1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

    [field: AccessedThroughProperty("GroupBox13")]
    internal virtual GroupBox GroupBox13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button cmdArea
    {
      get => this._cmdArea;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdArea_Click);
        Button cmdArea1 = this._cmdArea;
        if (cmdArea1 != null)
          cmdArea1.Click -= eventHandler;
        this._cmdArea = value;
        Button cmdArea2 = this._cmdArea;
        if (cmdArea2 == null)
          return;
        cmdArea2.Click += eventHandler;
      }
    }

    internal virtual DataGridView Dims
    {
      get => this._Dims;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DataGridViewCellEventHandler cellEventHandler1 = new DataGridViewCellEventHandler(this.Dims_CellEnter);
        DataGridViewCellEventHandler cellEventHandler2 = new DataGridViewCellEventHandler(this.DataGridView1_CellValueChanged);
        DataGridView dims1 = this._Dims;
        if (dims1 != null)
        {
          dims1.CellEnter -= cellEventHandler1;
          dims1.CellValueChanged -= cellEventHandler2;
        }
        this._Dims = value;
        DataGridView dims2 = this._Dims;
        if (dims2 == null)
          return;
        dims2.CellEnter += cellEventHandler1;
        dims2.CellValueChanged += cellEventHandler2;
      }
    }

    internal virtual TextBox txtLivingArea
    {
      get => this._txtLivingArea;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtLivingArea_TextChanged);
        TextBox txtLivingArea1 = this._txtLivingArea;
        if (txtLivingArea1 != null)
          txtLivingArea1.TextChanged -= eventHandler;
        this._txtLivingArea = value;
        TextBox txtLivingArea2 = this._txtLivingArea;
        if (txtLivingArea2 == null)
          return;
        txtLivingArea2.TextChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Label80")]
    internal virtual Label Label80 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox txtLivingFraction
    {
      get => this._txtLivingFraction;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtLivingFraction_TextChanged);
        TextBox txtLivingFraction1 = this._txtLivingFraction;
        if (txtLivingFraction1 != null)
          txtLivingFraction1.TextChanged -= eventHandler;
        this._txtLivingFraction = value;
        TextBox txtLivingFraction2 = this._txtLivingFraction;
        if (txtLivingFraction2 == null)
          return;
        txtLivingFraction2.TextChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Label79")]
    internal virtual Label Label79 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label78")]
    internal virtual Label Label78 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox10")]
    internal virtual GroupBox GroupBox10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtWallArea")]
    internal virtual TextBox txtWallArea { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label8")]
    internal virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtRoofArea")]
    internal virtual TextBox txtRoofArea { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label7")]
    internal virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label5")]
    internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtDimsArea")]
    internal virtual TextBox txtDimsArea { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label2")]
    internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label1")]
    internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox1")]
    internal virtual GroupBox GroupBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label3")]
    internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label4")]
    internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtPwall")]
    internal virtual TextBox txtPwall { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("ErrorPChecker")]
    internal virtual ErrorProvider ErrorPChecker { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label6")]
    internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Storey")]
    internal virtual DataGridViewTextBoxColumn Storey { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Basement")]
    internal virtual DataGridViewComboBoxColumn Basement { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Area")]
    internal virtual DataGridViewTextBoxColumn Area { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Height")]
    internal virtual DataGridViewTextBoxColumn Height { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Volume")]
    internal virtual DataGridViewTextBoxColumn Volume { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private void cmdClose_Click(object sender, EventArgs e)
    {
      try
      {
        this.WriteDimensions_Simplified_Approach();
        if (this.Check_SimplicyApproach_Errors() > 0)
          return;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling] = new SAP_Module.Dwelling();
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Dims = new SAP_Module.Dimensions[1];
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Walls = new SAP_Module.Opaques[1];
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Roofs = new SAP_Module.Opaques[1];
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Floors = new SAP_Module.Opaques[1];
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofWalls = 1;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofRoofs = 1;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofFloors = 1;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Storeys = 1;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Dims[0].Area = Conversions.ToSingle(this.txtDimsArea.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Dims[0].Height = 1f;
        if (Conversion.Val(this.txtPwall.Text) > 0.0)
        {
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PWalls = new SAP_Module.PartyWall[1];
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofPWalls = 1;
        }
        else
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofPWalls = 0;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Walls[0].Area = Conversions.ToSingle(this.txtWallArea.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Roofs[0].Area = Conversions.ToSingle(this.txtRoofArea.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Floors[0].Area = Conversions.ToSingle(this.txtDimsArea.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].LivingFraction = Conversions.ToSingle(this.txtLivingFraction.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].LivingArea = Conversions.ToSingle(this.txtLivingArea.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Address.Country = "Scotland";
        if (this.RadioButton1.Checked)
        {
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Fuel = "mains gas";
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].SimplifiedApproach = true;
        }
        else if (this.RadioButton2.Checked)
        {
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Fuel = "bulk LPG";
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].SimplifiedApproach = true;
        }
        else if (this.RadioButton3.Checked)
        {
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Fuel = "heating oil";
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].SimplifiedApproach = true;
        }
        else if (this.RadioButton4.Checked)
        {
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Fuel = "Electricity";
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].SimplifiedApproach = true;
        }
        else if (this.RadioButton5.Checked)
        {
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Fuel = "wood pellets (bulk supply in bags, for main heating)";
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].SimplifiedApproach = true;
        }
        this.FillSimpliedApproach_ScotlandOnly();
        this.Close();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) ex.InnerException, MsgBoxStyle.Critical, (object) "Stroma FSAP2012");
        ProjectData.ClearProjectError();
      }
    }

    public void FillSimpliedApproach_ScotlandOnly()
    {
      try
      {
        if (!(Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Address.Country, "Scotland", false) == 0 & SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].SimplifiedApproach))
          return;
        int scotlandPackage = Functions.GetScotland_Package(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Fuel);
        ref SAP_Module.Dwelling local = ref SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling];
        local.Ventilation.Fans = 0;
        local.Ventilation.Vents = 0;
        local.MainHeating.FuelBurningType = "";
        local.Ventilation.FluesSec = 0;
        local.Ventilation.FluesMain = 0;
        local.Ventilation.FluesOther = 0;
        local.Ventilation.Fires = 0;
        local.Ventilation.Chimneys = 0;
        local.LessThan125Litre = false;
        local.Cooling.Include = false;
        local.Doors = new SAP_Module.Door[1];
        local.NoofDoors = 1;
        local.Windows = new SAP_Module.Window[1];
        local.NoofWindows = 1;
        local.NoofRoofLights = 0;
        local.RoofLights = new SAP_Module.RoofLight[0];
        local.Walls = new SAP_Module.Opaques[1];
        local.NoofWalls = 1;
        local.Doors[0].Name = "Door 1";
        local.Doors[0].Location = "Wall 1";
        local.Doors[0].Area = 1.85f;
        local.Doors[0].U = 1.4f;
        local.Doors[0].DoorType = "Solid";
        local.Doors[0].GlazingType = "double-glazed, air filled";
        local.Doors[0].Overshading = "Average or unknown";
        local.Doors[0].UValueSource = "Manufacturer";
        local.Doors[0].Count = 1;
        local.Doors[0].Orientation = "East";
        int num1 = checked (local.NoofWalls - 1);
        int num2 = 0;
        double num3;
        while (num2 <= num1)
        {
          num3 += Conversions.ToDouble(this.txtWallArea.Text);
          checked { ++num2; }
        }
        int num4 = checked (local.Storeys - 1);
        int index1 = 0;
        double num5;
        while (index1 <= num4)
        {
          num5 += (double) local.Dims[index1].Area;
          checked { ++index1; }
        }
        double num6 = Conversions.ToDouble(this.txtDimsArea.Text) * 0.25 - 1.85;
        if (num3 < Conversions.ToDouble(this.txtDimsArea.Text) * 0.25)
          num6 = Conversions.ToDouble(this.txtWallArea.Text);
        local.Windows[0].Name = "Window 1";
        local.Windows[0].Location = "Wall 1";
        local.Windows[0].Overshading = "Average or unknown";
        local.Windows[0].GlazingType = "double-glazed, air filled";
        local.Windows[0].Orientation = "East";
        local.Windows[0].Area = (float) num6;
        local.Windows[0].FF = 0.7f;
        local.Windows[0].g = 0.63f;
        local.Windows[0].U = 1.4f;
        local.Windows[0].Count = 1;
        local.Thermal.ManualHtb = false;
        local.Thermal.YValue = 0.08f;
        local.Thermal.ManualY = true;
        local.Thermal.Reference = "No Information";
        double num7 = 0.0;
        int num8 = checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofWalls - 1);
        int index2 = 0;
        while (index2 <= num8)
        {
          num7 += Conversions.ToDouble(this.txtWallArea.Text) * (double) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Walls[index2].K;
          checked { ++index2; }
        }
        local.Walls[0].Area = Conversions.ToSingle(this.txtWallArea.Text);
        local.Walls[0].Name = "Wall 1";
        local.Walls[0].Type = "Exposed wall";
        local.Walls[0].U_Value = 0.17f;
        local.Walls[0].K = (float) (num7 / num3);
        try
        {
          if (local.PWalls.Length > 0)
          {
            int num9 = checked (local.PWalls.Length - 1);
            int index3 = 0;
            while (index3 <= num9)
            {
              local.PWalls[index3].U_Value = 0.0f;
              local.PWalls[0].Name = "Party Wall";
              local.PWalls[0].K = 0.0f;
              local.PWalls[0].Type = "Solid";
              checked { ++index3; }
            }
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        local.Roofs[0].Area = Conversions.ToSingle(this.txtRoofArea.Text);
        int num10 = checked (local.NoofRoofs - 1);
        int index4 = 0;
        while (index4 <= num10)
        {
          local.Roofs[index4].U_Value = 0.11f;
          local.Roofs[index4].Name = "Roof " + Conversions.ToString(checked (index4 + 1));
          local.Roofs[index4].Type = "Pitched - insulated joists";
          local.Roofs[index4].Construction = "Plasterboard, insulated at ceiling level";
          checked { ++index4; }
        }
        local.Floors[0].Area = Conversions.ToSingle(this.txtDimsArea.Text);
        int num11 = checked (local.NoofFloors - 1);
        int index5 = 0;
        while (index5 <= num11)
        {
          local.Floors[index5].U_Value = 0.15f;
          local.Floors[index5].Name = "Floor " + Conversions.ToString(checked (index5 + 1));
          local.Floors[index5].Type = "Ground floor";
          local.Floors[index5].Construction = "Slab on ground, screed over insulation";
          checked { ++index5; }
        }
        local.LivingFraction = Conversions.ToSingle(this.txtLivingFraction.Text);
        local.LivingArea = Conversions.ToSingle(this.txtLivingArea.Text);
        local.Address.Country = "Scotland";
        local.TMP.Type = "Indicative Value";
        local.TMP.Indicative = "Medium";
        local.TMP.UserDefined = 250f;
        local.Name = "D1";
        local.Reference = "Property referenec";
        local.RPD = "No related party";
        local.Transaction = "New dwelling";
        local.Tenure = "Unknown";
        local.Status = "New dwelling design stage";
        local.Overheat = "No";
        local.EPCLanguage = "English";
        local.SmokeArea = "Unknown";
        local.YearBuilt = DateAndTime.Now.Year;
        local.Conservatory = "No conservatory";
        local.Ventilation.MechVent = "Natural ventilation";
        local.Ventilation.Pressure = "As designed";
        local.Ventilation.DesignAir = 7f;
        local.Ventilation.MeasuredAir = 0.0f;
        local.Ventilation.AssumedAir = 0.0f;
        local.Ventilation.Chimneys = 0;
        local.Ventilation.Shelter = 2f;
        local.Ventilation.Flues = 0;
        local.Ventilation.Fires = 0;
        switch (scotlandPackage)
        {
          case 2:
          case 3:
          case 5:
            local.Ventilation.Flues = 1;
            break;
          default:
            local.Ventilation.Flues = 0;
            break;
        }
        local.Ventilation.Fans = num5 <= 80.0 ? 3 : 4;
        local.Orientation = "East";
        local.Overshading = "Average or unknown";
        local.MainHeating = new SAP_Module.MainHeating();
        local.MainHeating = local.MainHeating2;
        string str = "standard tariff";
        local.MainHeating.Emitter = "Systems with radiators";
        local.IncludeMainHeating2 = false;
        local.MainHeating.ElectricityTariff = str;
        switch (scotlandPackage)
        {
          case 1:
          case 2:
          case 3:
            local.MainHeating.Fuel = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Fuel;
            local.MainHeating.HGroup = "Boiler systems with radiators or underfloor heating";
            local.MainHeating.SGroup = "Gas boilers and oil boilers";
            local.MainHeating.BSubGroup = "Gas boilers (including LPG) 1998 or later";
            local.MainHeating.MHType = "Regular non-condensing with automatic ignition";
            local.MainHeating.InforSource = "Boiler Database";
            local.MainHeating.FuelBurningType = "Modulation";
            local.MainHeating.MainEff = 89f;
            if (scotlandPackage == 1)
            {
              local.MainHeating.Fuel = "mains gas";
              local.MainHeating.SEDBUK = "690103";
            }
            else if (scotlandPackage == 2)
            {
              local.MainHeating.Fuel = "bulk LPG";
              local.MainHeating.SEDBUK = "690104";
              local.MainHeating.Boiler.FlueType = "Room-sealed";
            }
            else if (scotlandPackage == 3)
            {
              local.MainHeating.Fuel = "heating oil";
              local.MainHeating.BSubGroup = "Oil boilers";
              local.MainHeating.SEDBUK = "690105";
              local.MainHeating.MainEff = 90f;
              local.MainHeating.OilPump = true;
            }
            local.MainHeating.Boiler.PumpType = "2013 or later";
            local.MainHeating.Boiler.PumpHP = "Yes";
            break;
          case 4:
            local.MainHeating.Fuel = "Electricity";
            local.MainHeating.MCSCert = true;
            local.MainHeating.HGroup = "Heat pumps with radiators or underfloor heating";
            local.MainHeating.SGroup = "Electric heat pumps";
            local.MainHeating.MHType = "Air source heat pump in other cases";
            local.MainHeating.SAPTableCode = 224;
            local.MainHeating.MainEff = 175.1f;
            local.MainHeating.Boiler.FlowTemp = "Design flow temperature >45°C";
            local.MainHeating.Boiler.PumpHP = "Yes";
            break;
          case 5:
            local.MainHeating.HGroup = "Boiler systems with radiators or underfloor heating";
            local.MainHeating.SGroup = "Solid fuel boilers";
            local.MainHeating.InforSource = "Boiler Database";
            local.MainHeating.MainEff = 86f;
            local.MainHeating.HETAS = "Yes";
            local.MainHeating.Boiler.PumpHP = "Yes";
            local.MainHeating.Fuel = "wood pellets (bulk supply in bags, for main heating)";
            local.MainHeating.SEDBUK = "691101";
            break;
        }
        local.MainHeating.Boiler.PumpType = "2013 or later";
        if ((uint) (scotlandPackage - 1) <= 2U)
        {
          local.MainHeating.Boiler.FlueType = "Room-sealed";
          local.MainHeating.Boiler.FanFlued = "Yes";
        }
        switch (scotlandPackage - 1)
        {
          case 0:
            local.MainHeating.ControlCodePCDFWeather = "696302";
            break;
          case 1:
            local.MainHeating.ControlCodePCDFWeather = "696303";
            break;
          case 2:
            local.MainHeating.ControlCodePCDFWeather = "696304";
            break;
        }
        switch (scotlandPackage - 1)
        {
          case 0:
          case 1:
          case 2:
            local.MainHeating.ControlCode = 2110;
            local.MainHeating.Boiler.BILock = "Yes";
            local.MainHeating.Boiler.LoadWeatherType = "Weather Compensator";
            local.MainHeating.Boiler.LoadWeather = true;
            local.MainHeating.DelayedStart = true;
            break;
          case 3:
            local.MainHeating.ControlCode = 2207;
            break;
          case 4:
            local.MainHeating.ControlCode = 2110;
            local.MainHeating.DelayedStart = true;
            break;
        }
        local.MainHeating.Controls = "Time and temperature zone control by suitable arrangement of plumbing and electrical services";
        local.SecHeating.Fuel = "";
        local.SecHeating.SAPTableCode = 0;
        local.SecHeating.SecEff = 0.0f;
        if ((uint) (scotlandPackage - 2) > 1U)
        {
          if (scotlandPackage == 4)
          {
            local.SecHeating.HGroup = "Room heater";
            local.SecHeating.Fuel = "Electricity";
            local.SecHeating.SAPTableCode = 692;
            local.SecHeating.SecEff = 100f;
          }
        }
        else
        {
          local.SecHeating.HGroup = "Room heater";
          local.SecHeating.SGroup = "Solid fuel room heaters";
          local.SecHeating.Fuel = "wood logs";
          local.SecHeating.MHType = "Closed room heater";
          local.SecHeating.InforSource = "SAP Tables";
          local.SecHeating.SAPTableCode = 633;
          local.SecHeating.HETAS = "No";
          local.SecHeating.SecEff = 60f;
        }
        local.IncludeMainHeating2 = false;
        local.Water = new SAP_Module.Water();
        local.Water.Fuel = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Fuel;
        int num12 = scotlandPackage;
        if (num12 >= 1 && num12 <= 3 || num12 == 5)
        {
          local.Water.System = "From main heating system";
          local.Water.SystemRef = 901;
          local.Water.Fuel = local.MainHeating.Fuel;
        }
        else if (num12 == 4)
        {
          local.Water.System = "Electric immersion (on-peak or off-peak)";
          local.Water.SystemRef = 903;
          local.Water.Fuel = "Electricity";
        }
        local.Water.Cylinder.Timed = true;
        local.Water.Cylinder.Volume = 150f;
        local.Water.Cylinder.ManuSpecified = true;
        local.Water.Cylinder.DeclaredLoss = 1.89f;
        local.Water.Cylinder.PipeWorkInsulated = true;
        local.Water.Cylinder.Thermostat = true;
        local.Water.Cylinder.InHeatedSpace = true;
        local.Water.Cylinder.PipeWorkInsulationType = "Fully insulated primary pipework";
        switch (scotlandPackage)
        {
          case 1:
          case 2:
          case 3:
            local.Renewable.Photovoltaic = new SAP_Module.Photovoltaic();
            local.Renewable.Photovoltaic.Photovoltaics = new SAP_Module.PhotoVoltaics[1];
            local.Renewable.Photovoltaic.Inlcude = false;
            local.Renewable.Photovoltaic.Photovoltaics[0].DirectlyConnected = true;
            local.Renewable.Photovoltaic.Photovoltaics[0].ID = 0;
            local.Renewable.Photovoltaic.Photovoltaics[0].PCOrientation = "South West";
            local.Renewable.Photovoltaic.Photovoltaics[0].POvershading = "None or very little";
            local.Renewable.Photovoltaic.Photovoltaics[0].PPower = (float) (num5 * 0.01);
            local.Renewable.Photovoltaic.Photovoltaics[0].PTilt = "30°";
            if (Operators.CompareString(local.PropertyType, "Flat", false) == 0 | Operators.CompareString(local.PropertyType, "Maisonette", false) == 0)
            {
              double num13 = num5 / (double) checked (local.NoOFDwellingsBelow + local.NoOFDwellingsAbove + 1);
              double num14 = num5 * 0.01;
              local.Renewable.Photovoltaic.Photovoltaics[0].PPower = 0.0414 * num13 >= num14 ? (float) Math.Round(num14, 2) : (float) Math.Round(0.0414 * num13, 2);
            }
            else
              local.Renewable.Photovoltaic.Photovoltaics[0].PPower = (float) Math.Round(num5 * 0.01, 2);
            local.Renewable.Photovoltaic.Photovoltaics[0].PTilt = "30°";
            break;
          default:
            local.Renewable.Photovoltaic.Inlcude = false;
            break;
        }
        local.Water.WWHRS = new SAP_Module.WWHRSSystem();
        local.Water.WWHRS.Include = false;
        local.Water.WWHRS.Systems = new SAP_Module.WWHRS_Systems[2];
        local.Water.WWHRS.Systems[0] = new SAP_Module.WWHRS_Systems();
        local.Water.WWHRS.Systems[1] = new SAP_Module.WWHRS_Systems();
        local.Water.WWHRS.Systems[0].SystemsRef = local.Water.WWHRS.Systems[0].SystemsRef;
        local.Water.WWHRS.Systems[1].SystemsRef = local.Water.WWHRS.Systems[1].SystemsRef;
        local.Water.WWHRS.TotalRooms = 1f;
        if (num5 <= 100.0)
        {
          local.Water.WWHRS.Systems[0].WithBath = 0;
          local.Water.WWHRS.Systems[0].WithNoBath = 1;
          local.Water.WWHRS.Systems[0].SystemsRef = "695101";
        }
        if (num5 >= 100.0)
        {
          local.Water.WWHRS.TotalRooms = 2f;
          local.Water.WWHRS.Systems[0].WithBath = 0;
          local.Water.WWHRS.Systems[0].WithNoBath = 1;
          local.Water.WWHRS.Systems[0].SystemsRef = "695101";
          local.Water.WWHRS.Systems[1].WithBath = 0;
          local.Water.WWHRS.Systems[1].WithNoBath = 1;
          local.Water.WWHRS.Systems[1].SystemsRef = "695102";
        }
        local.LowEnergyLight = 100f;
        local.LowEnergyLight = 100f;
        local.LELLights = 6;
        local.LELOutlets = 6;
        local.Renewable.AAEGeneration.Inlcude = false;
        local.Renewable.HydroGeneration.Inlcude = false;
        local.Renewable.Special.Include = false;
        local.Renewable.WindTurbine.Inlcude = false;
        local.Renewable.Photovoltaic.Inlcude = true;
        local.LessThan125Litre = false;
        local.Cooling.Include = false;
        local.Terrain = "Dense urban";
        SAP_Read.ReadDwellingDetails();
        SAP_Read.ReadMainHeating();
        Functions.CalculateNow();
        Validation.Checkerrors_All(SAP_Module.CurrDwelling);
        SAP_Write.SaveDetails_Validation(SAP_Module.CurrDwelling);
        MyProject.Forms.SAPForm.TreeSAP.Nodes[0].Nodes[SAP_Module.CurrDwelling].Nodes[0].ImageIndex = !SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Validation.Dims_Check ? 7 : 6;
        MyProject.Forms.SAPForm.TreeSAP.Nodes[0].Nodes[SAP_Module.CurrDwelling].Nodes[1].ImageIndex = !SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Validation.Opaque_Check ? 7 : 6;
        MyProject.Forms.SAPForm.TreeSAP.Nodes[0].Nodes[SAP_Module.CurrDwelling].Nodes[2].ImageIndex = !SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Validation.Openings_Check ? 7 : 6;
        MyProject.Forms.SAPForm.TreeSAP.Nodes[0].Nodes[SAP_Module.CurrDwelling].Nodes[3].ImageIndex = !SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Validation.Ventilation_Check ? 7 : 6;
        MyProject.Forms.SAPForm.TreeSAP.Nodes[0].Nodes[SAP_Module.CurrDwelling].Nodes[4].ImageIndex = !SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Validation.Heating_Check ? 7 : 6;
        MyProject.Forms.SAPForm.TreeSAP.Nodes[0].Nodes[SAP_Module.CurrDwelling].Nodes[5].ImageIndex = !SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Validation.WaterHeating_Check ? 7 : 6;
        MyProject.Forms.SAPForm.TreeSAP.Nodes[0].Nodes[SAP_Module.CurrDwelling].Nodes[6].ImageIndex = !SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Validation.RenewablesTech_Check ? 7 : 6;
        MyProject.Forms.SAPForm.TreeSAP.Nodes[0].Nodes[SAP_Module.CurrDwelling].Nodes[7].ImageIndex = !SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Validation.OverHeating_Check ? 7 : 6;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void Button2_Click(object sender, EventArgs e)
    {
      if (this.Dims.SelectedRows.Count > 0)
      {
        try
        {
          this.Dims.Rows.RemoveAt(this.Dims.SelectedRows[0].Index);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
      }
      else
      {
        try
        {
          this.Dims.Rows.RemoveAt(this.Dims.CurrentRow.Index);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
      }
    }

    private void txtLivingArea_TextChanged(object sender, EventArgs e)
    {
      try
      {
        if (!Versioned.IsNumeric((object) this.txtLivingArea.Text) || SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].LivingFractionSpecified)
          return;
        this.txtLivingFraction.Text = Strings.Format((object) Conversion.Val((object) (Conversions.ToDouble(this.txtLivingArea.Text) / Conversions.ToDouble(this.txtDimsArea.Text))), "#0.000");
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void txtLivingFraction_TextChanged(object sender, EventArgs e)
    {
      if (!Versioned.IsNumeric((object) this.txtLivingFraction.Text) || !SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].LivingFractionSpecified)
        return;
      this.txtLivingArea.Text = Strings.Format((object) Conversion.Val((object) (Conversions.ToDouble(this.txtLivingFraction.Text) * Conversions.ToDouble(this.txtDimsArea.Text))), "#0.00");
    }

    private void cmdArea_Click(object sender, EventArgs e)
    {
      SAP_Module.ControlNow = this.Dims;
      if (this.Dims.Rows[SAP_Module.RowNow].IsNewRow)
      {
        this.DontAdd = true;
        this.Dims.Rows.Add();
        SAP_Module.ControlNow.CurrentCell = SAP_Module.ControlNow[SAP_Module.ColNow, SAP_Module.RowNow];
        this.DontAdd = false;
      }
      if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Dims.Length >= checked (SAP_Module.RowNow + 1))
      {
        MyProject.Forms.AreaCalc.txtL1.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Dims[SAP_Module.RowNow].Dims.L1);
        MyProject.Forms.AreaCalc.txtW1.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Dims[SAP_Module.RowNow].Dims.W1);
        MyProject.Forms.AreaCalc.txtL2.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Dims[SAP_Module.RowNow].Dims.L2);
        MyProject.Forms.AreaCalc.txtW2.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Dims[SAP_Module.RowNow].Dims.W2);
        MyProject.Forms.AreaCalc.txtL3.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Dims[SAP_Module.RowNow].Dims.L3);
        MyProject.Forms.AreaCalc.txtW3.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Dims[SAP_Module.RowNow].Dims.W3);
        MyProject.Forms.AreaCalc.txtL4.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Dims[SAP_Module.RowNow].Dims.L4);
        MyProject.Forms.AreaCalc.txtW4.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Dims[SAP_Module.RowNow].Dims.W4);
        MyProject.Forms.AreaCalc.txtL5.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Dims[SAP_Module.RowNow].Dims.L5);
        MyProject.Forms.AreaCalc.txtW5.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Dims[SAP_Module.RowNow].Dims.W5);
        MyProject.Forms.AreaCalc.txtL6.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Dims[SAP_Module.RowNow].Dims.L6);
        MyProject.Forms.AreaCalc.txtW6.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Dims[SAP_Module.RowNow].Dims.W6);
      }
      else
      {
        MyProject.Forms.AreaCalc.txtL1.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtW1.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtL2.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtW2.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtL3.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtW3.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtL4.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtW4.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtL5.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtW5.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtL6.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtW6.Text = Conversions.ToString(0);
      }
      if (MyProject.Forms.AreaCalc.ShowDialog() != DialogResult.OK)
        return;
      SAP_Module.ControlNow[SAP_Module.ColNow, SAP_Module.RowNow].Value = (object) MyProject.Forms.AreaCalc.txtArea.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Dims[SAP_Module.RowNow].Dims.L1 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtL1.Text);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Dims[SAP_Module.RowNow].Dims.W1 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtW1.Text);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Dims[SAP_Module.RowNow].Dims.L2 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtL2.Text);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Dims[SAP_Module.RowNow].Dims.W2 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtW2.Text);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Dims[SAP_Module.RowNow].Dims.L3 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtL3.Text);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Dims[SAP_Module.RowNow].Dims.W3 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtW3.Text);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Dims[SAP_Module.RowNow].Dims.L4 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtL4.Text);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Dims[SAP_Module.RowNow].Dims.W4 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtW4.Text);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Dims[SAP_Module.RowNow].Dims.L5 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtL5.Text);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Dims[SAP_Module.RowNow].Dims.W5 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtW5.Text);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Dims[SAP_Module.RowNow].Dims.L6 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtL6.Text);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Dims[SAP_Module.RowNow].Dims.W6 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtW6.Text);
      SendKeys.SendWait("\t");
    }

    private void Dims_CellEnter(object sender, DataGridViewCellEventArgs e)
    {
      if (this.DontAdd)
        return;
      if (e.ColumnIndex == 2)
      {
        SAP_Module.RowNow = e.RowIndex;
        SAP_Module.ColNow = e.ColumnIndex;
        this.cmdArea.Top = checked (41 + e.RowIndex * 22);
        this.cmdArea.Visible = true;
        this.cmdArea.Left = checked (this.Dims.RowHeadersWidth + this.Dims.Columns[0].Width + this.Dims.Columns[1].Width + this.Dims.Columns[2].Width + 5);
      }
      else
        this.cmdArea.Visible = false;
      if (e.ColumnIndex == 0 | e.ColumnIndex == 4)
      {
        SendKeys.Send("{TAB}");
      }
      else
      {
        if (e.ColumnIndex != 1 || (uint) e.RowIndex <= 0U)
          return;
        SendKeys.Send("{TAB}");
      }
    }

    private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
    {
      if (SAP_Module.ChangeNow)
        return;
      this.RedoDims();
      if (this.Visible)
        this.AddCalcHandle();
    }

    public void AddCalcHandle()
    {
      if (SAP_Module.NoCalc)
        return;
      if (!this.DontSave & SAP_Module.CurrDwelling != -1)
        SAP_Write.SaveDetails();
      if (SAP_Module.CurrDwelling != -1)
        Functions.CalculateNow();
    }

    public void RedoDims()
    {
      SAP_Module.ChangeNow = true;
      int num1 = checked (this.Dims.RowCount - 1);
      int rowIndex = 0;
      float Expression;
      while (rowIndex <= num1)
      {
        if (rowIndex != checked (this.Dims.RowCount - 1))
        {
          if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.Dims[2, rowIndex].Value)) & !Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.Dims[3, rowIndex].Value)))
          {
            this.Dims[4, rowIndex].Value = (object) Strings.Format((object) (Conversion.Val(RuntimeHelpers.GetObjectValue(this.Dims[2, rowIndex].Value)) * Conversion.Val(RuntimeHelpers.GetObjectValue(this.Dims[3, rowIndex].Value))), "#0.00");
            Expression += (float) Conversion.Val(RuntimeHelpers.GetObjectValue(this.Dims[2, rowIndex].Value));
            float num2;
            num2 += (float) Conversion.Val(RuntimeHelpers.GetObjectValue(this.Dims[4, rowIndex].Value));
          }
          this.Dims[0, rowIndex].Value = rowIndex != 0 ? (object) ("+" + Conversions.ToString(rowIndex)) : (object) "Lowest Floor";
          if (this.Dims.RowCount > 2 & rowIndex == checked (this.Dims.RowCount - 2))
            this.Dims[0, rowIndex].Value = (object) "Roof room";
        }
        if ((uint) rowIndex > 0U)
        {
          this.Dims[1, rowIndex].ReadOnly = true;
          this.Dims[1, rowIndex].Style.BackColor = Color.LightGray;
        }
        else
        {
          this.Dims[1, rowIndex].ReadOnly = false;
          this.Dims[1, rowIndex].Style.BackColor = Color.White;
        }
        checked { ++rowIndex; }
      }
      this.txtDimsArea.Text = Strings.Format((object) Expression, "#0.00");
      SAP_Write.WriteDimensions(false);
      SAP_Module.ChangeNow = false;
    }

    public int Check_SimplicyApproach_Errors()
    {
      int num1 = 0;
      if (Operators.CompareString(this.txtWallArea.Text, "", false) == 0)
      {
        this.ErrorPChecker.SetError((Control) this.txtWallArea, "Please enter the Wall Area");
        checked { ++num1; }
      }
      else
        this.ErrorPChecker.SetError((Control) this.txtWallArea, "");
      if (Operators.CompareString(this.txtRoofArea.Text, "", false) == 0)
      {
        this.ErrorPChecker.SetError((Control) this.txtRoofArea, "Please enter the roof Area");
        checked { ++num1; }
      }
      else
        this.ErrorPChecker.SetError((Control) this.txtRoofArea, "");
      if (Operators.CompareString(this.txtDimsArea.Text, "", false) == 0)
      {
        this.ErrorPChecker.SetError((Control) this.txtDimsArea, "Please enter the Dimenion Area");
        checked { ++num1; }
      }
      else
        this.ErrorPChecker.SetError((Control) this.txtDimsArea, "");
      if (Operators.CompareString(this.txtLivingArea.Text, "", false) == 0)
      {
        this.ErrorPChecker.SetError((Control) this.txtLivingArea, "Please enter the living area Area");
        checked { ++num1; }
      }
      else
        this.ErrorPChecker.SetError((Control) this.txtLivingArea, "");
      if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Storeys == 0)
      {
        this.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.GroupBox13, "Please fill the information.");
      }
      else
      {
        int num2 = checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Storeys - 1);
        int index = 0;
        while (index <= num2)
        {
          if (Conversion.Val((object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Dims[index].Area) == 0.0 | Conversion.Val((object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Dims[index].Height) == 0.0)
          {
            this.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.GroupBox13, "Please fill the information.");
            checked { ++num1; }
          }
          else
            this.ErrorPChecker.SetError((Control) MyProject.Forms.SAPForm.GroupBox13, "");
          checked { ++index; }
        }
      }
      return num1;
    }

    public void WriteDimensions_Simplified_Approach()
    {
      if (SAP_Module.CurrDwelling == -1)
        return;
      try
      {
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Storeys = checked (MyProject.Forms.SAPForm.Dims.RowCount - 1);
        // ISSUE: variable of a reference type
        SAP_Module.Dimensions[]& local;
        // ISSUE: explicit reference operation
        SAP_Module.Dimensions[] dimensionsArray = (SAP_Module.Dimensions[]) Utils.CopyArray((Array) ^(local = ref SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Dims), (Array) new SAP_Module.Dimensions[checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Storeys - 1 + 1)]);
        local = dimensionsArray;
        int num = checked (this.Dims.RowCount - 1);
        int rowIndex = 0;
        while (rowIndex <= num)
        {
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Dims[rowIndex].Basement = Conversions.ToString(this.Dims[1, rowIndex].Value);
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Dims[rowIndex].Area = (float) Conversion.Val(RuntimeHelpers.GetObjectValue(this.Dims[2, rowIndex].Value));
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Dims[rowIndex].Height = (float) Conversion.Val(RuntimeHelpers.GetObjectValue(this.Dims[3, rowIndex].Value));
          checked { ++rowIndex; }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void CalculationType_ScotlandOnly_Load(object sender, EventArgs e)
    {
    }

    private void Button1_Click(object sender, EventArgs e) => this.Close();
  }
}
