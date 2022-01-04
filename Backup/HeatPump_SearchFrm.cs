
// Type: SAP2012.HeatPump_SearchFrm




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
  public class HeatPump_SearchFrm : Form
  {
    private IContainer components;
    public string HeatPumpSystem;
    private DataTable NewTable;

    public HeatPump_SearchFrm()
    {
      this.Load += new EventHandler(this.HeatPump_SearchFrm_Load);
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
      this.Button1 = new Button();
      this.Panel1 = new Panel();
      this.lblTotals = new Label();
      this.txtModel = new TextBox();
      this.Label2 = new Label();
      this.cmdHPSystem1Selection = new Button();
      this.txtBrandName = new TextBox();
      this.Label1 = new Label();
      this.DGHP = new DataGridView();
      this.Panel1.SuspendLayout();
      ((ISupportInitialize) this.DGHP).BeginInit();
      this.SuspendLayout();
      this.Button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.Button1.BackColor = Color.LightSlateGray;
      this.Button1.Cursor = Cursors.Hand;
      this.Button1.DialogResult = DialogResult.Cancel;
      this.Button1.FlatStyle = FlatStyle.Popup;
      this.Button1.ForeColor = Color.White;
      this.Button1.Location = new Point(782, 16);
      this.Button1.Name = "Button1";
      this.Button1.Size = new Size(90, 22);
      this.Button1.TabIndex = 23;
      this.Button1.Text = "Cancel";
      this.Button1.UseVisualStyleBackColor = false;
      this.Panel1.Controls.Add((Control) this.Button1);
      this.Panel1.Controls.Add((Control) this.lblTotals);
      this.Panel1.Controls.Add((Control) this.txtModel);
      this.Panel1.Controls.Add((Control) this.Label2);
      this.Panel1.Controls.Add((Control) this.cmdHPSystem1Selection);
      this.Panel1.Controls.Add((Control) this.txtBrandName);
      this.Panel1.Controls.Add((Control) this.Label1);
      this.Panel1.Dock = DockStyle.Top;
      this.Panel1.Location = new Point(0, 0);
      this.Panel1.Name = "Panel1";
      this.Panel1.Size = new Size(884, 75);
      this.Panel1.TabIndex = 2;
      this.lblTotals.AutoSize = true;
      this.lblTotals.Location = new Point(236, 56);
      this.lblTotals.Name = "lblTotals";
      this.lblTotals.Size = new Size(39, 13);
      this.lblTotals.TabIndex = 22;
      this.lblTotals.Text = "Label3";
      this.txtModel.Location = new Point(107, 39);
      this.txtModel.Name = "txtModel";
      this.txtModel.Size = new Size(100, 20);
      this.txtModel.TabIndex = 21;
      this.Label2.AutoSize = true;
      this.Label2.Location = new Point(12, 42);
      this.Label2.Name = "Label2";
      this.Label2.Size = new Size(36, 13);
      this.Label2.TabIndex = 20;
      this.Label2.Text = "Model";
      this.cmdHPSystem1Selection.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.cmdHPSystem1Selection.BackColor = Color.LightSlateGray;
      this.cmdHPSystem1Selection.Cursor = Cursors.Hand;
      this.cmdHPSystem1Selection.DialogResult = DialogResult.OK;
      this.cmdHPSystem1Selection.Enabled = false;
      this.cmdHPSystem1Selection.FlatStyle = FlatStyle.Popup;
      this.cmdHPSystem1Selection.ForeColor = Color.White;
      this.cmdHPSystem1Selection.Location = new Point(782, 44);
      this.cmdHPSystem1Selection.Name = "cmdHPSystem1Selection";
      this.cmdHPSystem1Selection.Size = new Size(90, 22);
      this.cmdHPSystem1Selection.TabIndex = 19;
      this.cmdHPSystem1Selection.Text = "Select";
      this.cmdHPSystem1Selection.UseVisualStyleBackColor = false;
      this.txtBrandName.Location = new Point(107, 13);
      this.txtBrandName.Name = "txtBrandName";
      this.txtBrandName.Size = new Size(100, 20);
      this.txtBrandName.TabIndex = 1;
      this.Label1.AutoSize = true;
      this.Label1.Location = new Point(12, 16);
      this.Label1.Name = "Label1";
      this.Label1.Size = new Size(66, 13);
      this.Label1.TabIndex = 0;
      this.Label1.Text = "Brand Name";
      this.DGHP.AllowUserToAddRows = false;
      this.DGHP.AllowUserToDeleteRows = false;
      this.DGHP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.DGHP.Cursor = Cursors.Hand;
      this.DGHP.Dock = DockStyle.Fill;
      this.DGHP.Location = new Point(0, 75);
      this.DGHP.Name = "DGHP";
      this.DGHP.ReadOnly = true;
      this.DGHP.RowHeadersVisible = false;
      this.DGHP.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.DGHP.Size = new Size(884, 487);
      this.DGHP.TabIndex = 3;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(884, 562);
      this.Controls.Add((Control) this.DGHP);
      this.Controls.Add((Control) this.Panel1);
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.Name = nameof (HeatPump_SearchFrm);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Heat Pump Search";
      this.Panel1.ResumeLayout(false);
      this.Panel1.PerformLayout();
      ((ISupportInitialize) this.DGHP).EndInit();
      this.ResumeLayout(false);
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

    [field: AccessedThroughProperty("Panel1")]
    internal virtual Panel Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("lblTotals")]
    internal virtual Label lblTotals { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox txtModel
    {
      get => this._txtModel;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtModel_TextChanged);
        TextBox txtModel1 = this._txtModel;
        if (txtModel1 != null)
          txtModel1.TextChanged -= eventHandler;
        this._txtModel = value;
        TextBox txtModel2 = this._txtModel;
        if (txtModel2 == null)
          return;
        txtModel2.TextChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Label2")]
    internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button cmdHPSystem1Selection
    {
      get => this._cmdHPSystem1Selection;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdWWHRSSystem1Selection_Click);
        Button system1Selection1 = this._cmdHPSystem1Selection;
        if (system1Selection1 != null)
          system1Selection1.Click -= eventHandler;
        this._cmdHPSystem1Selection = value;
        Button system1Selection2 = this._cmdHPSystem1Selection;
        if (system1Selection2 == null)
          return;
        system1Selection2.Click += eventHandler;
      }
    }

    internal virtual TextBox txtBrandName
    {
      get => this._txtBrandName;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtBrandName_TextChanged);
        TextBox txtBrandName1 = this._txtBrandName;
        if (txtBrandName1 != null)
          txtBrandName1.TextChanged -= eventHandler;
        this._txtBrandName = value;
        TextBox txtBrandName2 = this._txtBrandName;
        if (txtBrandName2 == null)
          return;
        txtBrandName2.TextChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Label1")]
    internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DataGridView DGHP
    {
      get => this._DGHP;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DataGridViewCellEventHandler cellEventHandler = new DataGridViewCellEventHandler(this.DGVWWHRS_CellClick);
        DataGridView dghp1 = this._DGHP;
        if (dghp1 != null)
          dghp1.CellClick -= cellEventHandler;
        this._DGHP = value;
        DataGridView dghp2 = this._DGHP;
        if (dghp2 == null)
          return;
        dghp2.CellClick += cellEventHandler;
      }
    }

    private void cmdWWHRSSystem1Selection_Click(object sender, EventArgs e)
    {
      if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].WaterOnlyHeatPump)
      {
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SEDBUK = Conversions.ToString(this.DGHP[0, this.DGHP.CurrentRow.Index].Value);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.HPOnly.HotWaterOnlyHP = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].WaterOnlyHeatPump;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.HPOnly.DeclaredValue = Conversions.ToSingle(this.DGHP[19, this.DGHP.CurrentRow.Index].Value);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.HPOnly.Vol = Conversions.ToInteger(this.DGHP[18, this.DGHP.CurrentRow.Index].Value);
        if (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DGHP[22, this.DGHP.CurrentRow.Index].Value)) > 0.0)
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.HPOnly.SummaerEff = Conversions.ToDouble(this.DGHP[22, this.DGHP.CurrentRow.Index].Value);
        if (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DGHP[24, this.DGHP.CurrentRow.Index].Value)) > 0.0)
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.HPOnly.WinterEff = Conversions.ToDouble(this.DGHP[24, this.DGHP.CurrentRow.Index].Value);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.HPOnly.ManuSpecified = true;
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DGHP[17, this.DGHP.CurrentRow.Index].Value, (object) "integral", false))
        {
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.HPOnly.HotWaterHP_Integral = true;
          try
          {
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.DeclaredLoss = Conversions.ToSingle(this.DGHP[19, this.DGHP.CurrentRow.Index].Value);
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.Volume = Conversions.ToSingle(this.DGHP[18, this.DGHP.CurrentRow.Index].Value);
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.ManuSpecified = true;
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
        }
        SAP_Read.CheckSEDBUK2();
        if (!SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].WaterOnlyHeatPump)
          return;
        MyProject.Forms.SAPForm.txtSecHeatingControls.Enabled = false;
        MyProject.Forms.SAPForm.txtSecHeatingControls.Items.Add((object) "Not applicable (boiler provides DHW only");
        MyProject.Forms.SAPForm.txtSecHeatingControls.Text = "Not applicable (boiler provides DHW only)";
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.TableGroup = 1;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.ControlCode = 2100;
      }
      else
      {
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SEDBUK = Conversions.ToString(this.DGHP[0, this.DGHP.CurrentRow.Index].Value);
        SAP_Read.CheckSEDBUK();
        try
        {
          if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(MyProject.Forms.SAPForm.txtMainFuel.Text, "", false) > 0U)
            WaterHeating.PaniCheck(1, MyProject.Forms.SAPForm.txtMainFuel.Text, SAP_Module.CurrDwelling);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
      }
    }

    public void Filter()
    {
      List<PCDF.HeatPump> heatPumpList = new List<PCDF.HeatPump>();
      int count = SAP_Module.PCDFData.FGHRSs.Count;
      if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].WaterOnlyHeatPump)
      {
        if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtBrandName.Text, "", false) > 0U)
          this.NewTable = Validation.ListToDataTable<PCDF.HeatPump>((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtModel.Text, "", false) <= 0U ? SAP_Module.PCDFData.HeatPumps.Where<PCDF.HeatPump>((Func<PCDF.HeatPump, bool>) (b => b.Brand.Contains(this.txtBrandName.Text) & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(b.ServiceProvision, "4", false) == 0)).ToList<PCDF.HeatPump>() : SAP_Module.PCDFData.HeatPumps.Where<PCDF.HeatPump>((Func<PCDF.HeatPump, bool>) (b => b.Brand.Contains(this.txtBrandName.Text) & b.Model.Contains(this.txtModel.Text) & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(b.ServiceProvision, "water heating only", false) == 0)).ToList<PCDF.HeatPump>());
        else if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtModel.Text, "", false) > 0U)
          this.NewTable = Validation.ListToDataTable<PCDF.HeatPump>(SAP_Module.PCDFData.HeatPumps.Where<PCDF.HeatPump>((Func<PCDF.HeatPump, bool>) (b => b.Model.Contains(this.txtModel.Text) & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(b.ServiceProvision, "4", false) == 0)).ToList<PCDF.HeatPump>());
        else if (PDFFunctions.MainHeating2Search)
        {
          List<PCDF.HeatPump> heatPumps = SAP_Module.PCDFData.HeatPumps;
          Func<PCDF.HeatPump, bool> predicate;
          // ISSUE: reference to a compiler-generated field
          if (HeatPump_SearchFrm._Closure\u0024__.\u0024I43\u002D3 != null)
          {
            // ISSUE: reference to a compiler-generated field
            predicate = HeatPump_SearchFrm._Closure\u0024__.\u0024I43\u002D3;
          }
          else
          {
            // ISSUE: reference to a compiler-generated field
            HeatPump_SearchFrm._Closure\u0024__.\u0024I43\u002D3 = predicate = (Func<PCDF.HeatPump, bool>) (b => Microsoft.VisualBasic.CompilerServices.Operators.CompareString(b.ServiceProvision, "4", false) == 0);
          }
          this.NewTable = Validation.ListToDataTable<PCDF.HeatPump>(heatPumps.Where<PCDF.HeatPump>(predicate).ToList<PCDF.HeatPump>());
        }
        else
          this.NewTable = Validation.ListToDataTable<PCDF.HeatPump>(SAP_Module.PCDFData.HeatPumps);
      }
      else
        this.NewTable = (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtBrandName.Text, "", false) <= 0U ? ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtModel.Text, "", false) <= 0U ? Validation.ListToDataTable<PCDF.HeatPump>(SAP_Module.PCDFData.HeatPumps) : Validation.ListToDataTable<PCDF.HeatPump>(SAP_Module.PCDFData.HeatPumps.Where<PCDF.HeatPump>((Func<PCDF.HeatPump, bool>) (b => b.Model.Contains(this.txtModel.Text))).ToList<PCDF.HeatPump>())) : Validation.ListToDataTable<PCDF.HeatPump>((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtModel.Text, "", false) <= 0U ? SAP_Module.PCDFData.HeatPumps.Where<PCDF.HeatPump>((Func<PCDF.HeatPump, bool>) (b => b.Brand.Contains(this.txtBrandName.Text))).ToList<PCDF.HeatPump>() : SAP_Module.PCDFData.HeatPumps.Where<PCDF.HeatPump>((Func<PCDF.HeatPump, bool>) (b => b.Brand.Contains(this.txtBrandName.Text) & b.Model.Contains(this.txtModel.Text))).ToList<PCDF.HeatPump>());
      this.DGHP.DataSource = (object) this.NewTable;
      int num = checked (this.DGHP.Rows.Count - 1);
      int index = 0;
      while (index <= num)
      {
        try
        {
          object Left = this.DGHP.Rows[index].Cells["PropertyType"].Value;
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) 0, false))
            this.DGHP.Rows[index].Cells["PropertyType"].Value = (object) "normal";
          else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) 1, false))
            this.DGHP.Rows[index].Cells["PropertyType"].Value = (object) "illustrative";
          else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) 2, false))
            this.DGHP.Rows[index].Cells["PropertyType"].Value = (object) "under investigation";
          else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) 3, false))
            this.DGHP.Rows[index].Cells["PropertyType"].Value = (object) "not valid";
          else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) 4, false))
            this.DGHP.Rows[index].Cells["PropertyType"].Value = (object) "The Heat Pump FGHRS methodology is currently being reviewed. This entry may change.";
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        try
        {
          object Left = this.DGHP.Rows[index].Cells["Fuel"].Value;
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) 1, false))
            this.DGHP.Rows[index].Cells["Fuel"].Value = (object) "Gas";
          else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) 2, false))
            this.DGHP.Rows[index].Cells["Fuel"].Value = (object) "LPG";
          else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) 4, false))
            this.DGHP.Rows[index].Cells["Fuel"].Value = (object) "Oil";
          else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) 10, false))
            this.DGHP.Rows[index].Cells["Fuel"].Value = (object) "dual fuel appliance (mineral and wood)";
          else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) 11, false))
            this.DGHP.Rows[index].Cells["Fuel"].Value = (object) "house coal";
          else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) 45, false))
            this.DGHP.Rows[index].Cells["Fuel"].Value = (object) "waste heat from power stations";
          else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) 49, false))
            this.DGHP.Rows[index].Cells["Fuel"].Value = (object) "electricity generated by CHP";
          else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) 50, false))
            this.DGHP.Rows[index].Cells["Fuel"].Value = (object) "heat from boilers – B30D1";
          else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) 52, false))
            this.DGHP.Rows[index].Cells["Fuel"].Value = (object) "heat from boilers – LPG";
          else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) 53, false))
            this.DGHP.Rows[index].Cells["Fuel"].Value = (object) "heat from boilers – oil";
          else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) 39, false))
            this.DGHP.Rows[index].Cells["Fuel"].Value = (object) "Electricity";
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        try
        {
          object Left = this.DGHP.Rows[index].Cells["Emitter_Type"].Value;
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) 1, false))
            this.DGHP.Rows[index].Cells["Emitter_Type"].Value = (object) "wet system, flow temperature 55°C";
          else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) 2, false))
            this.DGHP.Rows[index].Cells["Emitter_Type"].Value = (object) "wet system, flow temperature 45°C";
          else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) 3, false))
            this.DGHP.Rows[index].Cells["Emitter_Type"].Value = (object) "wet system, flow temperature 35°C";
          else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) 4, false))
            this.DGHP.Rows[index].Cells["Emitter_Type"].Value = (object) "not applicable";
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        try
        {
          object Left = this.DGHP.Rows[index].Cells["Flue_Type"].Value;
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) 0, false))
            this.DGHP.Rows[index].Cells["Flue_Type"].Value = (object) "unknown";
          else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) 1, false))
            this.DGHP.Rows[index].Cells["Flue_Type"].Value = (object) "open";
          else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) 2, false))
            this.DGHP.Rows[index].Cells["Flue_Type"].Value = (object) "room-sealed";
          else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) 3, false))
            this.DGHP.Rows[index].Cells["Flue_Type"].Value = (object) "open or room-sealed";
          else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) 4, false))
            this.DGHP.Rows[index].Cells["Flue_Type"].Value = (object) "none";
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        try
        {
          object Left = this.DGHP.Rows[index].Cells["Heat_source"].Value;
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) 1, false))
            this.DGHP.Rows[index].Cells["Heat_source"].Value = (object) "ground";
          else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) 2, false))
            this.DGHP.Rows[index].Cells["Heat_source"].Value = (object) "None";
          else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) 3, false))
            this.DGHP.Rows[index].Cells["Heat_source"].Value = (object) "air";
          else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) 4, false))
            this.DGHP.Rows[index].Cells["Heat_source"].Value = (object) "exhaust air MEV,";
          else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) 5, false))
            this.DGHP.Rows[index].Cells["Heat_source"].Value = (object) "exhaust air MVHR";
          else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) 6, false))
            this.DGHP.Rows[index].Cells["Heat_source"].Value = (object) "mixed exhaust air MEV and outside air";
          else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) 7, false))
            this.DGHP.Rows[index].Cells["Heat_source"].Value = (object) "ground water";
          else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) 8, false))
            this.DGHP.Rows[index].Cells["Heat_source"].Value = (object) "surface water";
          else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) 9, false))
            this.DGHP.Rows[index].Cells["Heat_source"].Value = (object) "solar assisted";
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        try
        {
          object Left = this.DGHP.Rows[index].Cells["Serviceprovision"].Value;
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) 0, false))
            this.DGHP.Rows[index].Cells["Serviceprovision"].Value = (object) "unknown";
          else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) 1, false))
            this.DGHP.Rows[index].Cells["Serviceprovision"].Value = (object) "space and water heating all year";
          else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) 2, false))
            this.DGHP.Rows[index].Cells["Serviceprovision"].Value = (object) "space and water heating during heating season only";
          else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) 3, false))
            this.DGHP.Rows[index].Cells["Serviceprovision"].Value = (object) "space heating only";
          else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) 4, false))
            this.DGHP.Rows[index].Cells["Serviceprovision"].Value = (object) "water heating only";
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        try
        {
          object Left = this.DGHP.Rows[index].Cells["HWVessel"].Value;
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) 4, false))
            this.DGHP.Rows[index].Cells["HWVessel"].Value = (object) "none";
          else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) 1, false))
            this.DGHP.Rows[index].Cells["HWVessel"].Value = (object) "integral";
          else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) 2, false))
            this.DGHP.Rows[index].Cells["HWVessel"].Value = (object) "separate and specified vessel";
          else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) 3, false))
            this.DGHP.Rows[index].Cells["HWVessel"].Value = (object) "separate but unspecified vessel";
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        try
        {
          object Left = this.DGHP.Rows[index].Cells["Reversible"].Value;
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) 0, false))
            this.DGHP.Rows[index].Cells["Reversible"].Value = (object) "Unknown";
          else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) 1, false))
            this.DGHP.Rows[index].Cells["Reversible"].Value = (object) "No";
          else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) 2, false))
            this.DGHP.Rows[index].Cells["Reversible"].Value = (object) "Yes";
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        try
        {
          object Left = this.DGHP.Rows[index].Cells["Compen_Effect"].Value;
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) 0, false))
            this.DGHP.Rows[index].Cells["Compen_Effect"].Value = (object) "Unknown";
          else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) 1, false))
            this.DGHP.Rows[index].Cells["Compen_Effect"].Value = (object) "No";
          else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) 2, false))
            this.DGHP.Rows[index].Cells["Compen_Effect"].Value = (object) "Yes";
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        try
        {
          object Left = this.DGHP.Rows[index].Cells["SepCirculator"].Value;
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) 0, false))
            this.DGHP.Rows[index].Cells["SepCirculator"].Value = (object) "Unknown";
          else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) 1, false))
            this.DGHP.Rows[index].Cells["SepCirculator"].Value = (object) "Within";
          else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) 2, false))
            this.DGHP.Rows[index].Cells["SepCirculator"].Value = (object) "Separate";
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        checked { ++index; }
      }
      this.lblTotals.Text = Conversions.ToString(this.DGHP.RowCount) + "/" + Conversions.ToString(count);
    }

    private void Button1_Click(object sender, EventArgs e)
    {
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].WaterOnlyHeatPump = false;
      this.Close();
    }

    private void txtBrandName_TextChanged(object sender, EventArgs e) => this.Filter();

    private void txtModel_TextChanged(object sender, EventArgs e) => this.Filter();

    private void DGVWWHRS_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex == -1)
        return;
      this.HeatPumpSystem = Conversions.ToString(this.DGHP[0, e.RowIndex].Value);
      this.cmdHPSystem1Selection.Enabled = true;
    }

    private void HeatPump_SearchFrm_Load(object sender, EventArgs e) => this.Filter();
  }
}
