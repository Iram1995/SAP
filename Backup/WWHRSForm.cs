
// Type: SAP2012.WWHRSForm




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
  public class WWHRSForm : Form
  {
    private IContainer components;
    public string SystemRef;

    public WWHRSForm()
    {
      this.Load += new EventHandler(this.WWHRS_Load);
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
      this.Button1 = new Button();
      this.lblTotals = new Label();
      this.txtModel = new TextBox();
      this.Label2 = new Label();
      this.cmdWWHRSSystem1Selection = new Button();
      this.txtBrandName = new TextBox();
      this.Label1 = new Label();
      this.DGVWWHRS = new DataGridView();
      this.Panel1.SuspendLayout();
      ((ISupportInitialize) this.DGVWWHRS).BeginInit();
      this.SuspendLayout();
      this.Panel1.Controls.Add((Control) this.Button1);
      this.Panel1.Controls.Add((Control) this.lblTotals);
      this.Panel1.Controls.Add((Control) this.txtModel);
      this.Panel1.Controls.Add((Control) this.Label2);
      this.Panel1.Controls.Add((Control) this.cmdWWHRSSystem1Selection);
      this.Panel1.Controls.Add((Control) this.txtBrandName);
      this.Panel1.Controls.Add((Control) this.Label1);
      this.Panel1.Dock = DockStyle.Top;
      this.Panel1.Location = new Point(0, 0);
      this.Panel1.Name = "Panel1";
      this.Panel1.Size = new Size(649, 75);
      this.Panel1.TabIndex = 0;
      this.Button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.Button1.BackColor = Color.LightSlateGray;
      this.Button1.Cursor = Cursors.Hand;
      this.Button1.DialogResult = DialogResult.Cancel;
      this.Button1.FlatStyle = FlatStyle.Popup;
      this.Button1.ForeColor = Color.White;
      this.Button1.Location = new Point(547, 16);
      this.Button1.Name = "Button1";
      this.Button1.Size = new Size(90, 22);
      this.Button1.TabIndex = 23;
      this.Button1.Text = "Cancel";
      this.Button1.UseVisualStyleBackColor = false;
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
      this.cmdWWHRSSystem1Selection.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.cmdWWHRSSystem1Selection.BackColor = Color.LightSlateGray;
      this.cmdWWHRSSystem1Selection.Cursor = Cursors.Hand;
      this.cmdWWHRSSystem1Selection.DialogResult = DialogResult.OK;
      this.cmdWWHRSSystem1Selection.Enabled = false;
      this.cmdWWHRSSystem1Selection.FlatStyle = FlatStyle.Popup;
      this.cmdWWHRSSystem1Selection.ForeColor = Color.White;
      this.cmdWWHRSSystem1Selection.Location = new Point(547, 44);
      this.cmdWWHRSSystem1Selection.Name = "cmdWWHRSSystem1Selection";
      this.cmdWWHRSSystem1Selection.Size = new Size(90, 22);
      this.cmdWWHRSSystem1Selection.TabIndex = 19;
      this.cmdWWHRSSystem1Selection.Text = "Select";
      this.cmdWWHRSSystem1Selection.UseVisualStyleBackColor = false;
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
      this.DGVWWHRS.AllowUserToAddRows = false;
      this.DGVWWHRS.AllowUserToDeleteRows = false;
      this.DGVWWHRS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.DGVWWHRS.Cursor = Cursors.Hand;
      this.DGVWWHRS.Dock = DockStyle.Fill;
      this.DGVWWHRS.Location = new Point(0, 75);
      this.DGVWWHRS.Name = "DGVWWHRS";
      this.DGVWWHRS.ReadOnly = true;
      this.DGVWWHRS.RowHeadersVisible = false;
      this.DGVWWHRS.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.DGVWWHRS.Size = new Size(649, 302);
      this.DGVWWHRS.TabIndex = 1;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(649, 377);
      this.Controls.Add((Control) this.DGVWWHRS);
      this.Controls.Add((Control) this.Panel1);
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.Name = nameof (WWHRSForm);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "WWHRS";
      this.Panel1.ResumeLayout(false);
      this.Panel1.PerformLayout();
      ((ISupportInitialize) this.DGVWWHRS).EndInit();
      this.ResumeLayout(false);
    }

    [field: AccessedThroughProperty("Panel1")]
    internal virtual Panel Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DataGridView DGVWWHRS
    {
      get => this._DGVWWHRS;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DataGridViewCellEventHandler cellEventHandler = new DataGridViewCellEventHandler(this.DGVWWHRS_CellClick);
        DataGridView dgvwwhrs1 = this._DGVWWHRS;
        if (dgvwwhrs1 != null)
          dgvwwhrs1.CellClick -= cellEventHandler;
        this._DGVWWHRS = value;
        DataGridView dgvwwhrs2 = this._DGVWWHRS;
        if (dgvwwhrs2 == null)
          return;
        dgvwwhrs2.CellClick += cellEventHandler;
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

    [field: AccessedThroughProperty("cmdWWHRSSystem1Selection")]
    internal virtual Button cmdWWHRSSystem1Selection { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

    [field: AccessedThroughProperty("lblTotals")]
    internal virtual Label lblTotals { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Button1")]
    internal virtual Button Button1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private void WWHRS_Load(object sender, EventArgs e) => this.Filter();

    private void txtBrandName_TextChanged(object sender, EventArgs e) => this.Filter();

    public void Filter()
    {
      List<PCDF.WWHRS> wwhrsList1 = new List<PCDF.WWHRS>();
      bool flag = false;
      int count = SAP_Module.PCDFData.WWHRSs.Count;
      if ((uint) Operators.CompareString(this.txtBrandName.Text, "", false) > 0U)
      {
        if ((uint) Operators.CompareString(this.txtModel.Text, "", false) > 0U)
        {
          wwhrsList1 = SAP_Module.PCDFData.WWHRSs.Where<PCDF.WWHRS>((Func<PCDF.WWHRS, bool>) (b => b.Brand.ToUpper().Contains(this.txtBrandName.Text.ToUpper()) & b.Model.ToUpper().Contains(this.txtModel.Text.ToUpper()))).ToList<PCDF.WWHRS>();
          flag = true;
        }
        else
        {
          wwhrsList1 = SAP_Module.PCDFData.WWHRSs.Where<PCDF.WWHRS>((Func<PCDF.WWHRS, bool>) (b => b.Brand.ToUpper().Contains(this.txtBrandName.Text.ToUpper()))).ToList<PCDF.WWHRS>();
          flag = true;
        }
      }
      else if ((uint) Operators.CompareString(this.txtModel.Text, "", false) > 0U)
      {
        wwhrsList1 = SAP_Module.PCDFData.WWHRSs.Where<PCDF.WWHRS>((Func<PCDF.WWHRS, bool>) (b => b.Model.ToUpper().Contains(this.txtModel.Text.ToUpper()))).ToList<PCDF.WWHRS>();
        flag = true;
      }
      if (flag)
      {
        int num1 = checked (wwhrsList1.Count - 1);
        int index = 0;
        while (index <= num1)
        {
          double num2 = Conversion.Val(wwhrsList1[index].ProductType);
          if (num2 == 0.0)
            wwhrsList1[index].ProductType = "normal";
          else if (num2 == 1.0)
            wwhrsList1[index].ProductType = "illustrative";
          else if (num2 == 2.0)
            wwhrsList1[index].ProductType = "under investigation";
          else if (num2 == 3.0)
            wwhrsList1[index].ProductType = "not valid";
          else if (num2 == 4.0)
            wwhrsList1[index].ProductType = "The SAP FGHRS methodology is currently being reviewed. This entry may change.";
          checked { ++index; }
        }
        this.DGVWWHRS.DataSource = (object) wwhrsList1;
      }
      else
      {
        PCDF pcdfData;
        List<PCDF.WWHRS> wwhrSs = (pcdfData = SAP_Module.PCDFData).WWHRSs;
        List<PCDF.WWHRS> wwhrsList2 = Functions.DeepClone<List<PCDF.WWHRS>>(ref wwhrSs);
        pcdfData.WWHRSs = wwhrSs;
        List<PCDF.WWHRS> wwhrsList3 = wwhrsList2;
        int num3 = checked (SAP_Module.PCDFData.WWHRSs.Count - 1);
        int index = 0;
        while (index <= num3)
        {
          double num4 = Conversion.Val(SAP_Module.PCDFData.WWHRSs[index].ProductType);
          if (num4 == 0.0)
            wwhrsList3[index].ProductType = "normal";
          else if (num4 == 1.0)
            wwhrsList3[index].ProductType = "illustrative";
          else if (num4 == 2.0)
            wwhrsList3[index].ProductType = "under investigation";
          else if (num4 == 3.0)
            wwhrsList3[index].ProductType = "not valid";
          else if (num4 == 4.0)
            wwhrsList3[index].ProductType = "The SAP FGHRS methodology is currently being reviewed. This entry may change.";
          checked { ++index; }
        }
        this.DGVWWHRS.DataSource = (object) wwhrsList3;
      }
      this.lblTotals.Text = Conversions.ToString(this.DGVWWHRS.RowCount) + "/" + Conversions.ToString(count);
    }

    private void txtModel_TextChanged(object sender, EventArgs e) => this.Filter();

    private void DGVWWHRS_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex == -1)
        return;
      this.SystemRef = Conversions.ToString(this.DGVWWHRS[0, e.RowIndex].Value);
      this.cmdWWHRSSystem1Selection.Enabled = true;
    }
  }
}
