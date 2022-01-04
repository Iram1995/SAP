
// Type: SAP2012.CommunitySearch




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
  public class CommunitySearch : Form
  {
    private IContainer components;

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
      this.lblTotals = new Label();
      this.txtModel = new TextBox();
      this.Label2 = new Label();
      this.cmdHPSystem1Selection = new Button();
      this.txtBrandName = new TextBox();
      this.Label1 = new Label();
      this.DGHP = new DataGridView();
      this.Panel1 = new Panel();
      this.DGHP_Subs = new DataGridView();
      this.Panel2 = new Panel();
      this.Label4 = new Label();
      this.Panel3 = new Panel();
      this.Label3 = new Label();
      ((ISupportInitialize) this.DGHP).BeginInit();
      this.Panel1.SuspendLayout();
      ((ISupportInitialize) this.DGHP_Subs).BeginInit();
      this.Panel2.SuspendLayout();
      this.Panel3.SuspendLayout();
      this.SuspendLayout();
      this.Button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.Button1.BackColor = Color.LightSlateGray;
      this.Button1.Cursor = Cursors.Hand;
      this.Button1.DialogResult = DialogResult.Cancel;
      this.Button1.FlatStyle = FlatStyle.Popup;
      this.Button1.ForeColor = Color.White;
      this.Button1.Location = new Point(906, 16);
      this.Button1.Name = "Button1";
      this.Button1.Size = new Size(90, 22);
      this.Button1.TabIndex = 23;
      this.Button1.Text = "Cancel";
      this.Button1.UseVisualStyleBackColor = false;
      this.lblTotals.AutoSize = true;
      this.lblTotals.Location = new Point(834, 53);
      this.lblTotals.Name = "lblTotals";
      this.lblTotals.Size = new Size(39, 13);
      this.lblTotals.TabIndex = 22;
      this.lblTotals.Text = "Label3";
      this.txtModel.Location = new Point(170, 39);
      this.txtModel.Name = "txtModel";
      this.txtModel.Size = new Size(100, 20);
      this.txtModel.TabIndex = 21;
      this.Label2.AutoSize = true;
      this.Label2.Location = new Point(12, 42);
      this.Label2.Name = "Label2";
      this.Label2.Size = new Size(52, 13);
      this.Label2.TabIndex = 20;
      this.Label2.Text = "Postcode";
      this.cmdHPSystem1Selection.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.cmdHPSystem1Selection.BackColor = Color.LightSlateGray;
      this.cmdHPSystem1Selection.Cursor = Cursors.Hand;
      this.cmdHPSystem1Selection.DialogResult = DialogResult.OK;
      this.cmdHPSystem1Selection.Enabled = false;
      this.cmdHPSystem1Selection.FlatStyle = FlatStyle.Popup;
      this.cmdHPSystem1Selection.ForeColor = Color.White;
      this.cmdHPSystem1Selection.Location = new Point(906, 44);
      this.cmdHPSystem1Selection.Name = "cmdHPSystem1Selection";
      this.cmdHPSystem1Selection.Size = new Size(90, 22);
      this.cmdHPSystem1Selection.TabIndex = 19;
      this.cmdHPSystem1Selection.Text = "Select";
      this.cmdHPSystem1Selection.UseVisualStyleBackColor = false;
      this.txtBrandName.Location = new Point(170, 13);
      this.txtBrandName.Name = "txtBrandName";
      this.txtBrandName.Size = new Size(195, 20);
      this.txtBrandName.TabIndex = 1;
      this.Label1.AutoSize = true;
      this.Label1.Location = new Point(12, 16);
      this.Label1.Name = "Label1";
      this.Label1.Size = new Size(152, 13);
      this.Label1.TabIndex = 0;
      this.Label1.Text = "Community heat network name";
      this.DGHP.AllowUserToAddRows = false;
      this.DGHP.AllowUserToDeleteRows = false;
      this.DGHP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.DGHP.Cursor = Cursors.Hand;
      this.DGHP.Dock = DockStyle.Top;
      this.DGHP.Location = new Point(0, 110);
      this.DGHP.Name = "DGHP";
      this.DGHP.ReadOnly = true;
      this.DGHP.RowHeadersVisible = false;
      this.DGHP.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.DGHP.Size = new Size(1008, 173);
      this.DGHP.TabIndex = 5;
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
      this.Panel1.Size = new Size(1008, 75);
      this.Panel1.TabIndex = 4;
      this.DGHP_Subs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.DGHP_Subs.Dock = DockStyle.Fill;
      this.DGHP_Subs.Location = new Point(0, 318);
      this.DGHP_Subs.Name = "DGHP_Subs";
      this.DGHP_Subs.Size = new Size(1008, 243);
      this.DGHP_Subs.TabIndex = 6;
      this.Panel2.BackColor = Color.Gray;
      this.Panel2.Controls.Add((Control) this.Label4);
      this.Panel2.Dock = DockStyle.Top;
      this.Panel2.Location = new Point(0, 283);
      this.Panel2.Name = "Panel2";
      this.Panel2.Size = new Size(1008, 35);
      this.Panel2.TabIndex = 24;
      this.Label4.AutoSize = true;
      this.Label4.Font = new Font("Microsoft Sans Serif", 14f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label4.ForeColor = Color.White;
      this.Label4.Location = new Point(434, 6);
      this.Label4.Name = "Label4";
      this.Label4.Size = new Size(124, 24);
      this.Label4.TabIndex = 1;
      this.Label4.Text = "Heat Sources";
      this.Panel3.BackColor = Color.Gray;
      this.Panel3.Controls.Add((Control) this.Label3);
      this.Panel3.Dock = DockStyle.Top;
      this.Panel3.Location = new Point(0, 75);
      this.Panel3.Name = "Panel3";
      this.Panel3.Size = new Size(1008, 35);
      this.Panel3.TabIndex = 25;
      this.Label3.AutoSize = true;
      this.Label3.Font = new Font("Microsoft Sans Serif", 14f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label3.ForeColor = Color.White;
      this.Label3.Location = new Point(363, 6);
      this.Label3.Name = "Label3";
      this.Label3.Size = new Size(260, 24);
      this.Label3.TabIndex = 0;
      this.Label3.Text = "Community Heating Schemes";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1008, 561);
      this.Controls.Add((Control) this.DGHP_Subs);
      this.Controls.Add((Control) this.Panel2);
      this.Controls.Add((Control) this.DGHP);
      this.Controls.Add((Control) this.Panel3);
      this.Controls.Add((Control) this.Panel1);
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.Name = nameof (CommunitySearch);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Community Heating Scheme Search";
      ((ISupportInitialize) this.DGHP).EndInit();
      this.Panel1.ResumeLayout(false);
      this.Panel1.PerformLayout();
      ((ISupportInitialize) this.DGHP_Subs).EndInit();
      this.Panel2.ResumeLayout(false);
      this.Panel2.PerformLayout();
      this.Panel3.ResumeLayout(false);
      this.Panel3.PerformLayout();
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
        DataGridViewCellEventHandler cellEventHandler1 = new DataGridViewCellEventHandler(this.DGVWWHRS_CellClick);
        DataGridViewCellEventHandler cellEventHandler2 = new DataGridViewCellEventHandler(this.DGHP_CellClick);
        EventHandler eventHandler = new EventHandler(this.DGHP_SelectionChanged);
        DataGridView dghp1 = this._DGHP;
        if (dghp1 != null)
        {
          dghp1.CellClick -= cellEventHandler1;
          dghp1.CellClick -= cellEventHandler2;
          dghp1.SelectionChanged -= eventHandler;
        }
        this._DGHP = value;
        DataGridView dghp2 = this._DGHP;
        if (dghp2 == null)
          return;
        dghp2.CellClick += cellEventHandler1;
        dghp2.CellClick += cellEventHandler2;
        dghp2.SelectionChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Panel1")]
    internal virtual Panel Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DGHP_Subs")]
    internal virtual DataGridView DGHP_Subs { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Panel2")]
    internal virtual Panel Panel2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label4")]
    internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Panel3")]
    internal virtual Panel Panel3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label3")]
    internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    public CommunitySearch(CommunitySearch.Type searchType)
    {
      this.Load += new EventHandler(this.HeatPump_SearchFrm_Load);
      this.InitializeComponent();
      this.SearchType = searchType;
    }

    public CommunitySearch.Type SearchType { get; set; }

    private void cmdWWHRSSystem1Selection_Click(object sender, EventArgs e)
    {
      if (this.SearchType == CommunitySearch.Type.Heating)
      {
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SEDBUK = Conversions.ToString(this.DGHP[0, this.DGHP.CurrentRow.Index].Value);
        SAP_Read.CheckCommunitySEDBUK();
        SAP_Write.WriteCommunityDatabase();
      }
      else
      {
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.SystemRef = Conversions.ToString(this.DGHP[0, this.DGHP.CurrentRow.Index].Value);
        SAP_Read.CheckCommunityWaterSEDBUK();
        SAP_Write.WriteCommunityWaterDatabase();
      }
    }

    public void Filter()
    {
      List<PCDF.CommunityScheme> communitySchemeList1 = new List<PCDF.CommunityScheme>();
      int count = SAP_Module.PCDFData.CommunitySchemes.Count;
      List<PCDF.CommunityScheme> communitySchemeList2;
      if ((uint) Operators.CompareString(this.txtBrandName.Text, "", false) > 0U)
      {
        communitySchemeList2 = (uint) Operators.CompareString(this.txtModel.Text, "", false) <= 0U ? (this.SearchType != CommunitySearch.Type.Heating ? SAP_Module.PCDFData.CommunitySchemes.Where<PCDF.CommunityScheme>((Func<PCDF.CommunityScheme, bool>) (b => b.CommunityHeatNetwork.Contains(this.txtBrandName.Text) & (b.ServiceProvision.Equals("1") | b.ServiceProvision.Equals("4")))).ToList<PCDF.CommunityScheme>() : SAP_Module.PCDFData.CommunitySchemes.Where<PCDF.CommunityScheme>((Func<PCDF.CommunityScheme, bool>) (b => b.CommunityHeatNetwork.Contains(this.txtBrandName.Text) & (b.ServiceProvision.Equals("1") | b.ServiceProvision.Equals("3")))).ToList<PCDF.CommunityScheme>()) : (this.SearchType != CommunitySearch.Type.Heating ? SAP_Module.PCDFData.CommunitySchemes.Where<PCDF.CommunityScheme>((Func<PCDF.CommunityScheme, bool>) (b => b.CommunityHeatNetwork.Contains(this.txtBrandName.Text) & b.PostcodeEnergyCentre.Contains(this.txtModel.Text) & (b.ServiceProvision.Equals("1") | b.ServiceProvision.Equals("4")))).ToList<PCDF.CommunityScheme>() : SAP_Module.PCDFData.CommunitySchemes.Where<PCDF.CommunityScheme>((Func<PCDF.CommunityScheme, bool>) (b => b.CommunityHeatNetwork.Contains(this.txtBrandName.Text) & b.PostcodeEnergyCentre.Contains(this.txtModel.Text) & (b.ServiceProvision.Equals("1") | b.ServiceProvision.Equals("3")))).ToList<PCDF.CommunityScheme>());
        this.DGHP.DataSource = (object) communitySchemeList2;
      }
      else if ((uint) Operators.CompareString(this.txtModel.Text, "", false) > 0U)
        communitySchemeList2 = this.SearchType != CommunitySearch.Type.Heating ? SAP_Module.PCDFData.CommunitySchemes.Where<PCDF.CommunityScheme>((Func<PCDF.CommunityScheme, bool>) (b => b.PostcodeEnergyCentre.Contains(this.txtModel.Text) & (b.ServiceProvision.Equals("1") | b.ServiceProvision.Equals("4")))).ToList<PCDF.CommunityScheme>() : SAP_Module.PCDFData.CommunitySchemes.Where<PCDF.CommunityScheme>((Func<PCDF.CommunityScheme, bool>) (b => b.PostcodeEnergyCentre.Contains(this.txtModel.Text) & (b.ServiceProvision.Equals("1") | b.ServiceProvision.Equals("3")))).ToList<PCDF.CommunityScheme>();
      else if (this.SearchType == CommunitySearch.Type.Heating)
      {
        List<PCDF.CommunityScheme> communitySchemes = SAP_Module.PCDFData.CommunitySchemes;
        Func<PCDF.CommunityScheme, bool> predicate;
        // ISSUE: reference to a compiler-generated field
        if (CommunitySearch._Closure\u0024__.\u0024I66\u002D6 != null)
        {
          // ISSUE: reference to a compiler-generated field
          predicate = CommunitySearch._Closure\u0024__.\u0024I66\u002D6;
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          CommunitySearch._Closure\u0024__.\u0024I66\u002D6 = predicate = (Func<PCDF.CommunityScheme, bool>) (b => b.ServiceProvision.Equals("1") | b.ServiceProvision.Equals("3"));
        }
        communitySchemeList2 = communitySchemes.Where<PCDF.CommunityScheme>(predicate).ToList<PCDF.CommunityScheme>();
      }
      else
      {
        List<PCDF.CommunityScheme> communitySchemes = SAP_Module.PCDFData.CommunitySchemes;
        Func<PCDF.CommunityScheme, bool> predicate;
        // ISSUE: reference to a compiler-generated field
        if (CommunitySearch._Closure\u0024__.\u0024I66\u002D7 != null)
        {
          // ISSUE: reference to a compiler-generated field
          predicate = CommunitySearch._Closure\u0024__.\u0024I66\u002D7;
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          CommunitySearch._Closure\u0024__.\u0024I66\u002D7 = predicate = (Func<PCDF.CommunityScheme, bool>) (b => b.ServiceProvision.Equals("1") | b.ServiceProvision.Equals("4"));
        }
        communitySchemeList2 = communitySchemes.Where<PCDF.CommunityScheme>(predicate).ToList<PCDF.CommunityScheme>();
      }
      this.DGHP.DataSource = (object) communitySchemeList2;
      this.lblTotals.Visible = false;
    }

    private void Button1_Click(object sender, EventArgs e) => this.Close();

    private void txtBrandName_TextChanged(object sender, EventArgs e) => this.Filter();

    private void txtModel_TextChanged(object sender, EventArgs e) => this.Filter();

    private void DGVWWHRS_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex == -1)
        return;
      this.cmdHPSystem1Selection.Enabled = true;
    }

    private void HeatPump_SearchFrm_Load(object sender, EventArgs e) => this.Filter();

    private void DGHP_CellClick(object sender, DataGridViewCellEventArgs e)
    {
    }

    private void DGHP_SelectionChanged(object sender, EventArgs e)
    {
      if (this.DGHP.SelectedRows.Count == -1)
        return;
      this.DGHP_Subs.DataSource = (object) SAP_Module.PCDFData.CommunitySchemes_Sub.Where<PCDF.CommunityScheme_Sub>((Func<PCDF.CommunityScheme_Sub, bool>) (b => b.ID.Equals(RuntimeHelpers.GetObjectValue(this.DGHP[0, this.DGHP.CurrentRow.Index].Value)))).ToList<PCDF.CommunityScheme_Sub>();
    }

    public enum Type
    {
      Heating,
      Water,
    }
  }
}
