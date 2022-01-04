
// Type: SAP2012.Controls




using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
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
  public class Controls : Form
  {
    private IContainer components;

    public Controls()
    {
      this.Load += new EventHandler(this.Controls_Load);
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
      this.dtgControls = new DataGridView();
      this.Label1 = new Label();
      this.txtSearch = new TextBox();
      this.cmdOK = new Button();
      this.cmdCancel = new Button();
      ((ISupportInitialize) this.dtgControls).BeginInit();
      this.SuspendLayout();
      this.dtgControls.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.dtgControls.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dtgControls.Location = new Point(12, 55);
      this.dtgControls.MultiSelect = false;
      this.dtgControls.Name = "dtgControls";
      this.dtgControls.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dtgControls.Size = new Size(799, 366);
      this.dtgControls.TabIndex = 0;
      this.Label1.AutoSize = true;
      this.Label1.Location = new Point(9, 13);
      this.Label1.Name = "Label1";
      this.Label1.Size = new Size(41, 13);
      this.Label1.TabIndex = 1;
      this.Label1.Text = "Search";
      this.txtSearch.Location = new Point(12, 29);
      this.txtSearch.Name = "txtSearch";
      this.txtSearch.Size = new Size(799, 20);
      this.txtSearch.TabIndex = 2;
      this.cmdOK.Cursor = Cursors.Hand;
      this.cmdOK.Location = new Point(736, 429);
      this.cmdOK.Name = "cmdOK";
      this.cmdOK.Size = new Size(75, 23);
      this.cmdOK.TabIndex = 3;
      this.cmdOK.Text = "OK";
      this.cmdOK.UseVisualStyleBackColor = true;
      this.cmdCancel.Cursor = Cursors.Hand;
      this.cmdCancel.Location = new Point(12, 429);
      this.cmdCancel.Name = "cmdCancel";
      this.cmdCancel.Size = new Size(75, 23);
      this.cmdCancel.TabIndex = 4;
      this.cmdCancel.Text = "Cancel";
      this.cmdCancel.UseVisualStyleBackColor = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(823, 464);
      this.Controls.Add((Control) this.cmdCancel);
      this.Controls.Add((Control) this.cmdOK);
      this.Controls.Add((Control) this.txtSearch);
      this.Controls.Add((Control) this.Label1);
      this.Controls.Add((Control) this.dtgControls);
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.Name = nameof (Controls);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = nameof (Controls);
      ((ISupportInitialize) this.dtgControls).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    [field: AccessedThroughProperty("dtgControls")]
    internal virtual DataGridView dtgControls { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label1")]
    internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox txtSearch
    {
      get => this._txtSearch;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.TextBox1_TextChanged);
        TextBox txtSearch1 = this._txtSearch;
        if (txtSearch1 != null)
          txtSearch1.TextChanged -= eventHandler;
        this._txtSearch = value;
        TextBox txtSearch2 = this._txtSearch;
        if (txtSearch2 == null)
          return;
        txtSearch2.TextChanged += eventHandler;
      }
    }

    internal virtual Button cmdOK
    {
      get => this._cmdOK;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdOK_Click);
        Button cmdOk1 = this._cmdOK;
        if (cmdOk1 != null)
          cmdOk1.Click -= eventHandler;
        this._cmdOK = value;
        Button cmdOk2 = this._cmdOK;
        if (cmdOk2 == null)
          return;
        cmdOk2.Click += eventHandler;
      }
    }

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

    public Controls.HeatingSystem AppliedSystem { get; set; }

    public Controls.ControlType AppliedType { get; set; }

    private void Controls_Load(object sender, EventArgs e)
    {
      this.dtgControls.Rows.Clear();
      List<PCDF.HeatingControl> heatingControls = SAP_Module.PCDFData.HeatingControls;
      Func<PCDF.HeatingControl, bool> predicate1;
      // ISSUE: reference to a compiler-generated field
      if (Controls._Closure\u0024__.\u0024I34\u002D0 != null)
      {
        // ISSUE: reference to a compiler-generated field
        predicate1 = Controls._Closure\u0024__.\u0024I34\u002D0;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        Controls._Closure\u0024__.\u0024I34\u002D0 = predicate1 = (Func<PCDF.HeatingControl, bool>) (b => b.ProductType.Equals("0"));
      }
      List<PCDF.HeatingControl> list = heatingControls.Where<PCDF.HeatingControl>(predicate1).ToList<PCDF.HeatingControl>();
      List<PCDF.HeatingControl> heatingControlList = new List<PCDF.HeatingControl>();
      List<PCDF.SEDBUK> boilers = SAP_Module.PCDFData.Boilers;
      Func<PCDF.SEDBUK, bool> predicate2;
      // ISSUE: reference to a compiler-generated field
      if (Controls._Closure\u0024__.\u0024I34\u002D1 != null)
      {
        // ISSUE: reference to a compiler-generated field
        predicate2 = Controls._Closure\u0024__.\u0024I34\u002D1;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        Controls._Closure\u0024__.\u0024I34\u002D1 = predicate2 = (Func<PCDF.SEDBUK, bool>) (b => b.ID.Equals(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SEDBUK));
      }
      PCDF.SEDBUK sedbuk = boilers.Where<PCDF.SEDBUK>(predicate2).SingleOrDefault<PCDF.SEDBUK>();
      try
      {
        foreach (PCDF.HeatingControl heatingControl in list)
        {
          string fuel = heatingControl.Fuel;
          if (Operators.CompareString(fuel, Conversions.ToString(1), false) == 0)
            heatingControl.Fuel = "mains gas";
          else if (Operators.CompareString(fuel, Conversions.ToString(2), false) == 0)
            heatingControl.Fuel = "bulk LPG";
          else if (Operators.CompareString(fuel, Conversions.ToString(3), false) == 0)
            heatingControl.Fuel = "bottled LPG";
          else if (Operators.CompareString(fuel, Conversions.ToString(4), false) == 0)
            heatingControl.Fuel = "heating oil";
          else if (Operators.CompareString(fuel, Conversions.ToString(11), false) == 0)
            heatingControl.Fuel = "house coal";
          else if (Operators.CompareString(fuel, Conversions.ToString(12), false) == 0)
            heatingControl.Fuel = "smokeless fuel";
          else if (Operators.CompareString(fuel, Conversions.ToString(13), false) == 0)
            heatingControl.Fuel = "anthracite";
          else if (Operators.CompareString(fuel, Conversions.ToString(20), false) == 0)
            heatingControl.Fuel = "wood logs";
          else if (Operators.CompareString(fuel, Conversions.ToString(21), false) == 0)
            heatingControl.Fuel = "wood chips";
          else if (Operators.CompareString(fuel, Conversions.ToString(23), false) == 0)
            heatingControl.Fuel = "wood pellets";
          else if (Operators.CompareString(fuel, Conversions.ToString(10), false) == 0)
            heatingControl.Fuel = "dual fuel appliance (mineral and wood)";
          else if (Operators.CompareString(fuel, Conversions.ToString(11), false) == 0)
            heatingControl.Fuel = "house coal";
          else if (Operators.CompareString(fuel, Conversions.ToString(45), false) == 0)
            heatingControl.Fuel = "waste heat from power stations";
          else if (Operators.CompareString(fuel, Conversions.ToString(49), false) == 0)
            heatingControl.Fuel = "electricity generated by CHP";
          else if (Operators.CompareString(fuel, Conversions.ToString(50), false) == 0)
            heatingControl.Fuel = "heat from boilers – B30D1";
          else if (Operators.CompareString(fuel, Conversions.ToString(52), false) == 0)
            heatingControl.Fuel = "heat from boilers – LPG";
          else if (Operators.CompareString(fuel, Conversions.ToString(53), false) == 0)
            heatingControl.Fuel = "heat from boilers – oil";
          else if (Operators.CompareString(fuel, Conversions.ToString(39), false) == 0)
            heatingControl.Fuel = "Electricity";
          if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.ControlCategory == null)
          {
            List<PCDF.Table4e> table4es = SAP_Module.PCDFData.Table4es;
            Func<PCDF.Table4e, bool> predicate3;
            // ISSUE: reference to a compiler-generated field
            if (Controls._Closure\u0024__.\u0024I34\u002D2 != null)
            {
              // ISSUE: reference to a compiler-generated field
              predicate3 = Controls._Closure\u0024__.\u0024I34\u002D2;
            }
            else
            {
              // ISSUE: reference to a compiler-generated field
              Controls._Closure\u0024__.\u0024I34\u002D2 = predicate3 = (Func<PCDF.Table4e, bool>) (b => b.Group.Equals(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.TableGroup.ToString()) & b.Description.ToUpper().Equals(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Controls.ToUpper()));
            }
            PCDF.Table4e table4e = table4es.Where<PCDF.Table4e>(predicate3).SingleOrDefault<PCDF.Table4e>();
            if (table4e != null)
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.ControlCategory = table4e.Control;
          }
          if (Operators.CompareString(heatingControl.Fuel, SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Fuel, false) == 0 && Conversion.Val(sedbuk.ControlCapabilities) >= Conversion.Val(heatingControl.HeatGeneratorControl))
            heatingControlList.Add(heatingControl);
        }
      }
      finally
      {
        List<PCDF.HeatingControl>.Enumerator enumerator;
        enumerator.Dispose();
      }
      this.dtgControls.DataSource = (object) heatingControlList;
    }

    private void cmdCancel_Click(object sender, EventArgs e) => this.Close();

    private void cmdOK_Click(object sender, EventArgs e)
    {
      if ((uint) this.dtgControls.SelectedRows.Count > 0U)
      {
        if (this.AppliedSystem == Controls.HeatingSystem.Main)
        {
          if (this.AppliedType == Controls.ControlType.TimeTemp)
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.ControlCodePCDF = ((PCDF.HeatingControl) this.dtgControls.SelectedRows[0].DataBoundItem).Index;
          else
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.ControlCodePCDFWeather = ((PCDF.HeatingControl) this.dtgControls.SelectedRows[0].DataBoundItem).Index;
          try
          {
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.ControlCategory = ((PCDF.HeatingControl) this.dtgControls.SelectedRows[0].DataBoundItem).HeatingCategory;
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.ControlFuel = ((PCDF.HeatingControl) this.dtgControls.SelectedRows[0].DataBoundItem).Fuel;
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.ControlCapability = ((PCDF.HeatingControl) this.dtgControls.SelectedRows[0].DataBoundItem).HeatGeneratorControl;
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.ControlDelayedStart = ((PCDF.HeatingControl) this.dtgControls.SelectedRows[0].DataBoundItem).DelayedStart;
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
        }
        else
        {
          if (this.AppliedType == Controls.ControlType.TimeTemp)
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.ControlCodePCDF = ((PCDF.HeatingControl) this.dtgControls.SelectedRows[0].DataBoundItem).Index;
          else
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.ControlCodePCDFWeather = ((PCDF.HeatingControl) this.dtgControls.SelectedRows[0].DataBoundItem).Index;
          try
          {
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.ControlCategory = ((PCDF.HeatingControl) this.dtgControls.SelectedRows[0].DataBoundItem).HeatingCategory;
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.ControlFuel = ((PCDF.HeatingControl) this.dtgControls.SelectedRows[0].DataBoundItem).Fuel;
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.ControlCapability = ((PCDF.HeatingControl) this.dtgControls.SelectedRows[0].DataBoundItem).HeatGeneratorControl;
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.ControlDelayedStart = ((PCDF.HeatingControl) this.dtgControls.SelectedRows[0].DataBoundItem).DelayedStart;
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
        }
      }
      else
      {
        int num = (int) Interaction.MsgBox((object) "Please select a product first");
      }
      this.DialogResult = DialogResult.OK;
    }

    private void TextBox1_TextChanged(object sender, EventArgs e)
    {
      if ((uint) Operators.CompareString(this.txtSearch.Text, "", false) > 0U)
      {
        List<PCDF.HeatingControl> heatingControlList = new List<PCDF.HeatingControl>();
        List<string> list1 = ((IEnumerable<string>) this.txtSearch.Text.Split(' ')).ToList<string>();
        try
        {
          foreach (string str in list1)
          {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            Controls._Closure\u0024__37\u002D0 closure370 = new Controls._Closure\u0024__37\u002D0(closure370);
            // ISSUE: reference to a compiler-generated field
            closure370.\u0024VB\u0024Local_part = str;
            // ISSUE: reference to a compiler-generated method
            List<PCDF.HeatingControl> list2 = SAP_Module.PCDFData.HeatingControls.Where<PCDF.HeatingControl>(new Func<PCDF.HeatingControl, bool>(closure370._Lambda\u0024__0)).ToList<PCDF.HeatingControl>();
            heatingControlList.AddRange((IEnumerable<PCDF.HeatingControl>) list2);
          }
        }
        finally
        {
          List<string>.Enumerator enumerator;
          enumerator.Dispose();
        }
        List<PCDF.HeatingControl> source = heatingControlList;
        Func<PCDF.HeatingControl, bool> predicate;
        // ISSUE: reference to a compiler-generated field
        if (Controls._Closure\u0024__.\u0024I37\u002D1 != null)
        {
          // ISSUE: reference to a compiler-generated field
          predicate = Controls._Closure\u0024__.\u0024I37\u002D1;
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          Controls._Closure\u0024__.\u0024I37\u002D1 = predicate = (Func<PCDF.HeatingControl, bool>) (b => b.ProductType.Equals("0"));
        }
        this.dtgControls.DataSource = (object) source.Where<PCDF.HeatingControl>(predicate).ToList<PCDF.HeatingControl>();
      }
      else
      {
        List<PCDF.HeatingControl> heatingControls = SAP_Module.PCDFData.HeatingControls;
        Func<PCDF.HeatingControl, bool> predicate;
        // ISSUE: reference to a compiler-generated field
        if (Controls._Closure\u0024__.\u0024I37\u002D2 != null)
        {
          // ISSUE: reference to a compiler-generated field
          predicate = Controls._Closure\u0024__.\u0024I37\u002D2;
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          Controls._Closure\u0024__.\u0024I37\u002D2 = predicate = (Func<PCDF.HeatingControl, bool>) (b => b.ProductType.Equals("0"));
        }
        this.dtgControls.DataSource = (object) heatingControls.Where<PCDF.HeatingControl>(predicate).ToList<PCDF.HeatingControl>();
      }
    }

    public enum HeatingSystem
    {
      Main,
      SecondaryMain,
    }

    public enum ControlType
    {
      TimeTemp,
      Weather,
    }
  }
}
