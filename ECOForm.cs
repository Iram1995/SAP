
// Type: SAP2012.ECOForm




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
  public class ECOForm : Form
  {
    private IContainer components;
    public bool PleaseClose;

    public ECOForm()
    {
      this.FormClosing += new FormClosingEventHandler(this.ECOForm_FormClosing);
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
      this.lblCO2 = new Label();
      this.Label3 = new Label();
      this.lblCosts = new Label();
      this.DataGridView1 = new DataGridView();
      this.HouseName = new DataGridViewTextBoxColumn();
      this.Note = new DataGridViewTextBoxColumn();
      this.CO2Value = new DataGridViewTextBoxColumn();
      this.Cost = new DataGridViewTextBoxColumn();
      this.Button1 = new Button();
      this.Label2 = new Label();
      this.txtNote = new TextBox();
      this.Button2 = new Button();
      ((ISupportInitialize) this.DataGridView1).BeginInit();
      this.SuspendLayout();
      this.Label1.AutoSize = true;
      this.Label1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label1.Location = new Point(13, 13);
      this.Label1.Name = "Label1";
      this.Label1.Size = new Size(116, 13);
      this.Label1.TabIndex = 0;
      this.Label1.Text = "Total CO2, kg/year";
      this.lblCO2.AutoSize = true;
      this.lblCO2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblCO2.Location = new Point(149, 13);
      this.lblCO2.Name = "lblCO2";
      this.lblCO2.Size = new Size(44, 13);
      this.lblCO2.TabIndex = 1;
      this.lblCO2.Text = "lblCO2";
      this.Label3.AutoSize = true;
      this.Label3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label3.Location = new Point(13, 39);
      this.Label3.Name = "Label3";
      this.Label3.Size = new Size(121, 13);
      this.Label3.TabIndex = 2;
      this.Label3.Text = "Total energy cost, £";
      this.lblCosts.AutoSize = true;
      this.lblCosts.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblCosts.Location = new Point(149, 38);
      this.lblCosts.Name = "lblCosts";
      this.lblCosts.Size = new Size(51, 13);
      this.lblCosts.TabIndex = 3;
      this.lblCosts.Text = "lblCosts";
      this.DataGridView1.AllowUserToAddRows = false;
      this.DataGridView1.AllowUserToDeleteRows = false;
      this.DataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.DataGridView1.Columns.AddRange((DataGridViewColumn) this.HouseName, (DataGridViewColumn) this.Note, (DataGridViewColumn) this.CO2Value, (DataGridViewColumn) this.Cost);
      this.DataGridView1.Location = new Point(13, 62);
      this.DataGridView1.Name = "DataGridView1";
      this.DataGridView1.ReadOnly = true;
      this.DataGridView1.Size = new Size(670, 430);
      this.DataGridView1.TabIndex = 4;
      this.HouseName.HeaderText = "House Name";
      this.HouseName.Name = "HouseName";
      this.HouseName.ReadOnly = true;
      this.HouseName.Width = 200;
      this.Note.HeaderText = "Note";
      this.Note.Name = "Note";
      this.Note.ReadOnly = true;
      this.Note.Width = 200;
      this.CO2Value.HeaderText = "CO2 Value";
      this.CO2Value.Name = "CO2Value";
      this.CO2Value.ReadOnly = true;
      this.Cost.HeaderText = "Running Cost";
      this.Cost.Name = "Cost";
      this.Cost.ReadOnly = true;
      this.Button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.Button1.Cursor = Cursors.Hand;
      this.Button1.Location = new Point(552, 33);
      this.Button1.Name = "Button1";
      this.Button1.Size = new Size(130, 23);
      this.Button1.TabIndex = 5;
      this.Button1.Text = "Save Current Score";
      this.Button1.UseVisualStyleBackColor = true;
      this.Label2.AutoSize = true;
      this.Label2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label2.Location = new Point(297, 13);
      this.Label2.Name = "Label2";
      this.Label2.Size = new Size(34, 13);
      this.Label2.TabIndex = 6;
      this.Label2.Text = "Note";
      this.txtNote.Location = new Point(333, 10);
      this.txtNote.Name = "txtNote";
      this.txtNote.Size = new Size(348, 20);
      this.txtNote.TabIndex = 7;
      this.Button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.Button2.Cursor = Cursors.Hand;
      this.Button2.Location = new Point(552, 498);
      this.Button2.Name = "Button2";
      this.Button2.Size = new Size(130, 23);
      this.Button2.TabIndex = 8;
      this.Button2.Text = "Hide Me ";
      this.Button2.UseVisualStyleBackColor = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(695, 533);
      this.Controls.Add((Control) this.Button2);
      this.Controls.Add((Control) this.txtNote);
      this.Controls.Add((Control) this.Label2);
      this.Controls.Add((Control) this.Button1);
      this.Controls.Add((Control) this.DataGridView1);
      this.Controls.Add((Control) this.lblCosts);
      this.Controls.Add((Control) this.Label3);
      this.Controls.Add((Control) this.lblCO2);
      this.Controls.Add((Control) this.Label1);
      this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
      this.Name = nameof (ECOForm);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = nameof (ECOForm);
      ((ISupportInitialize) this.DataGridView1).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    [field: AccessedThroughProperty("Label1")]
    internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("lblCO2")]
    internal virtual Label lblCO2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label3")]
    internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("lblCosts")]
    internal virtual Label lblCosts { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DataGridView1")]
    internal virtual DataGridView DataGridView1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

    [field: AccessedThroughProperty("HouseName")]
    internal virtual DataGridViewTextBoxColumn HouseName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Note")]
    internal virtual DataGridViewTextBoxColumn Note { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("CO2Value")]
    internal virtual DataGridViewTextBoxColumn CO2Value { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Cost")]
    internal virtual DataGridViewTextBoxColumn Cost { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label2")]
    internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtNote")]
    internal virtual TextBox txtNote { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

    private void Button1_Click(object sender, EventArgs e)
    {
      this.DataGridView1.Rows.Add();
      this.DataGridView1[0, checked (this.DataGridView1.RowCount - 1)].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Name;
      this.DataGridView1[1, checked (this.DataGridView1.RowCount - 1)].Value = (object) this.txtNote.Text;
      this.DataGridView1[2, checked (this.DataGridView1.RowCount - 1)].Value = (object) this.lblCO2.Text;
      this.DataGridView1[3, checked (this.DataGridView1.RowCount - 1)].Value = (object) this.lblCosts.Text;
    }

    private void ECOForm_FormClosing(object sender, FormClosingEventArgs e) => e.Cancel = !this.PleaseClose;

    private void Button2_Click(object sender, EventArgs e) => this.Hide();
  }
}
