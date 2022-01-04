
// Type: SAP2012.StorageSelectionVessel




using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SAP2012
{
  [DesignerGenerated]
  public class StorageSelectionVessel : Form
  {
    private IContainer components;

    public StorageSelectionVessel()
    {
      this.Load += new EventHandler(this.StorageSelection_Load);
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
      this.Panel1 = new Panel();
      this.Label1 = new Label();
      this.Panel2 = new Panel();
      this.dtaPCDF = new DataGridView();
      this.Panel3 = new Panel();
      this.dtaSurvey = new DataGridView();
      this.Panel4 = new Panel();
      this.Label2 = new Label();
      this.Button1 = new Button();
      this.Panel5 = new Panel();
      this.cmdAdd = new Button();
      this.cmdRemove = new Button();
      this.Panel1.SuspendLayout();
      this.Panel2.SuspendLayout();
      ((ISupportInitialize) this.dtaPCDF).BeginInit();
      this.Panel3.SuspendLayout();
      ((ISupportInitialize) this.dtaSurvey).BeginInit();
      this.Panel4.SuspendLayout();
      this.Panel5.SuspendLayout();
      this.SuspendLayout();
      this.Panel1.BackColor = Color.Gray;
      this.Panel1.Controls.Add((Control) this.Label1);
      this.Panel1.Dock = DockStyle.Top;
      this.Panel1.Location = new Point(0, 0);
      this.Panel1.Margin = new Padding(4, 4, 4, 4);
      this.Panel1.Name = "Panel1";
      this.Panel1.Size = new Size(1203, 47);
      this.Panel1.TabIndex = 0;
      this.Label1.AutoSize = true;
      this.Label1.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label1.ForeColor = Color.White;
      this.Label1.Location = new Point(336, 11);
      this.Label1.Margin = new Padding(4, 0, 4, 0);
      this.Label1.Name = "Label1";
      this.Label1.Size = new Size(418, 25);
      this.Label1.TabIndex = 0;
      this.Label1.Text = "Select a storage heater from the PCDF file";
      this.Panel2.Controls.Add((Control) this.dtaPCDF);
      this.Panel2.Dock = DockStyle.Top;
      this.Panel2.Location = new Point(0, 47);
      this.Panel2.Margin = new Padding(4, 4, 4, 4);
      this.Panel2.Name = "Panel2";
      this.Panel2.Size = new Size(1203, 220);
      this.Panel2.TabIndex = 1;
      this.dtaPCDF.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dtaPCDF.Dock = DockStyle.Fill;
      this.dtaPCDF.Location = new Point(0, 0);
      this.dtaPCDF.Margin = new Padding(4, 4, 4, 4);
      this.dtaPCDF.Name = "dtaPCDF";
      this.dtaPCDF.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dtaPCDF.Size = new Size(1203, 220);
      this.dtaPCDF.TabIndex = 0;
      this.Panel3.Controls.Add((Control) this.dtaSurvey);
      this.Panel3.Dock = DockStyle.Top;
      this.Panel3.Location = new Point(0, 361);
      this.Panel3.Margin = new Padding(4, 4, 4, 4);
      this.Panel3.Name = "Panel3";
      this.Panel3.Size = new Size(1203, 262);
      this.Panel3.TabIndex = 3;
      this.dtaSurvey.AllowUserToAddRows = false;
      this.dtaSurvey.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
      this.dtaSurvey.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dtaSurvey.Cursor = Cursors.Hand;
      this.dtaSurvey.Dock = DockStyle.Fill;
      this.dtaSurvey.Location = new Point(0, 0);
      this.dtaSurvey.Margin = new Padding(4, 4, 4, 4);
      this.dtaSurvey.Name = "dtaSurvey";
      this.dtaSurvey.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dtaSurvey.Size = new Size(1203, 262);
      this.dtaSurvey.TabIndex = 1;
      this.Panel4.BackColor = Color.Gray;
      this.Panel4.Controls.Add((Control) this.Label2);
      this.Panel4.Dock = DockStyle.Top;
      this.Panel4.Location = new Point(0, 314);
      this.Panel4.Margin = new Padding(4, 4, 4, 4);
      this.Panel4.Name = "Panel4";
      this.Panel4.Size = new Size(1203, 47);
      this.Panel4.TabIndex = 2;
      this.Label2.AutoSize = true;
      this.Label2.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label2.ForeColor = Color.White;
      this.Label2.Location = new Point(368, 11);
      this.Label2.Margin = new Padding(4, 0, 4, 0);
      this.Label2.Name = "Label2";
      this.Label2.Size = new Size(420, 25);
      this.Label2.TabIndex = 1;
      this.Label2.Text = "Select heaters selected within the property";
      this.Button1.Cursor = Cursors.Hand;
      this.Button1.Location = new Point(1052, 638);
      this.Button1.Margin = new Padding(4, 4, 4, 4);
      this.Button1.Name = "Button1";
      this.Button1.Size = new Size(135, 28);
      this.Button1.TabIndex = 4;
      this.Button1.Text = "Close";
      this.Button1.UseVisualStyleBackColor = true;
      this.Panel5.Controls.Add((Control) this.cmdAdd);
      this.Panel5.Controls.Add((Control) this.cmdRemove);
      this.Panel5.Dock = DockStyle.Top;
      this.Panel5.Location = new Point(0, 267);
      this.Panel5.Margin = new Padding(4, 4, 4, 4);
      this.Panel5.Name = "Panel5";
      this.Panel5.Size = new Size(1203, 47);
      this.Panel5.TabIndex = 5;
      this.cmdAdd.Cursor = Cursors.Hand;
      this.cmdAdd.Location = new Point(1052, 7);
      this.cmdAdd.Margin = new Padding(4, 4, 4, 4);
      this.cmdAdd.Name = "cmdAdd";
      this.cmdAdd.Size = new Size(135, 28);
      this.cmdAdd.TabIndex = 6;
      this.cmdAdd.Text = "Add";
      this.cmdAdd.UseVisualStyleBackColor = true;
      this.cmdRemove.Cursor = Cursors.Hand;
      this.cmdRemove.Location = new Point(16, 7);
      this.cmdRemove.Margin = new Padding(4, 4, 4, 4);
      this.cmdRemove.Name = "cmdRemove";
      this.cmdRemove.Size = new Size(135, 28);
      this.cmdRemove.TabIndex = 5;
      this.cmdRemove.Text = "Remove";
      this.cmdRemove.UseVisualStyleBackColor = true;
      this.AutoScaleDimensions = new SizeF(8f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1203, 672);
      this.Controls.Add((Control) this.Button1);
      this.Controls.Add((Control) this.Panel3);
      this.Controls.Add((Control) this.Panel4);
      this.Controls.Add((Control) this.Panel5);
      this.Controls.Add((Control) this.Panel2);
      this.Controls.Add((Control) this.Panel1);
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.Margin = new Padding(4, 4, 4, 4);
      this.Name = "StorageSelection";
      this.Text = "Storage Selection";
      this.Panel1.ResumeLayout(false);
      this.Panel1.PerformLayout();
      this.Panel2.ResumeLayout(false);
      ((ISupportInitialize) this.dtaPCDF).EndInit();
      this.Panel3.ResumeLayout(false);
      ((ISupportInitialize) this.dtaSurvey).EndInit();
      this.Panel4.ResumeLayout(false);
      this.Panel4.PerformLayout();
      this.Panel5.ResumeLayout(false);
      this.ResumeLayout(false);
    }

    [field: AccessedThroughProperty("Panel1")]
    internal virtual Panel Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label1")]
    internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Panel2")]
    internal virtual Panel Panel2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("dtaPCDF")]
    internal virtual DataGridView dtaPCDF { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Panel3")]
    internal virtual Panel Panel3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Panel4")]
    internal virtual Panel Panel4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label2")]
    internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

    [field: AccessedThroughProperty("Panel5")]
    internal virtual Panel Panel5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("dtaSurvey")]
    internal virtual DataGridView dtaSurvey { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

    internal virtual Button cmdRemove
    {
      get => this._cmdRemove;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdRemove_Click);
        Button cmdRemove1 = this._cmdRemove;
        if (cmdRemove1 != null)
          cmdRemove1.Click -= eventHandler;
        this._cmdRemove = value;
        Button cmdRemove2 = this._cmdRemove;
        if (cmdRemove2 == null)
          return;
        cmdRemove2.Click += eventHandler;
      }
    }

    private void cmdAdd_Click(object sender, EventArgs e)
    {
      try
      {
        if ((uint) this.dtaPCDF.SelectedRows.Count <= 0U)
          return;
        BindingSource bindingSource = new BindingSource();
        PCDF.Storage_Heater dataBoundItem = (PCDF.Storage_Heater) this.dtaPCDF.SelectedRows[0].DataBoundItem;
        if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.StorageHeaters == null)
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.StorageHeaters = new List<SAP_Module.StorageHeater>();
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.StorageHeaters.Add(new SAP_Module.StorageHeater()
        {
          Index_Number = dataBoundItem.ID,
          BrandName = dataBoundItem.BrandName,
          ManuName = dataBoundItem.ManuName,
          ModelName = dataBoundItem.ModelName
        });
        bindingSource.DataSource = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.StorageHeaters;
        this.dtaSurvey.DataSource = (object) bindingSource;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) Information.Err().Description, MsgBoxStyle.Critical, (object) "Stroma FSAP 2012");
        ProjectData.ClearProjectError();
      }
    }

    private void StorageSelection_Load(object sender, EventArgs e)
    {
      this.dtaPCDF.DataSource = (object) SAP_Module.PCDFData.Storage_Heaters;
      this.dtaSurvey.DataSource = (object) new BindingSource()
      {
        DataSource = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.StorageHeaters
      };
    }

    private void Button1_Click(object sender, EventArgs e) => this.Close();

    private void cmdRemove_Click(object sender, EventArgs e)
    {
      BindingSource bindingSource = new BindingSource();
      try
      {
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.StorageHeaters = (List<SAP_Module.StorageHeater>) null;
        bindingSource.DataSource = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.StorageHeaters;
        this.dtaSurvey.DataSource = (object) bindingSource;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) Information.Err().Description, MsgBoxStyle.Critical, (object) "Stroma FSAP 2012");
        ProjectData.ClearProjectError();
      }
    }
  }
}
