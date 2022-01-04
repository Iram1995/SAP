
// Type: SAP2012.CHP_Search




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
  public class CHP_Search : Form
  {
    private IContainer components;
    private DataTable NewTable;

    public CHP_Search()
    {
      this.Load += new EventHandler(this.CHP_Search_Load);
      this.NewTable = new DataTable();
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (CHP_Search));
      DataGridViewCellStyle gridViewCellStyle1 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle2 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle3 = new DataGridViewCellStyle();
      this.Label3 = new Label();
      this.txtSearch = new TextBox();
      this.Label2 = new Label();
      this.cmdSimpleSearch = new Button();
      this.cmdCancel = new Button();
      this.CmdNext1 = new Button();
      this.cmdShow = new Button();
      this.SplitContainer1 = new SplitContainer();
      this.SearchResults = new DataGridView();
      this.DataInfoSub = new DataGridView();
      this.DataInfo = new DataGridView();
      this.Label1 = new Label();
      this.SplitContainer1.Panel1.SuspendLayout();
      this.SplitContainer1.Panel2.SuspendLayout();
      this.SplitContainer1.SuspendLayout();
      ((ISupportInitialize) this.SearchResults).BeginInit();
      ((ISupportInitialize) this.DataInfoSub).BeginInit();
      ((ISupportInitialize) this.DataInfo).BeginInit();
      this.SuspendLayout();
      this.Label3.AutoSize = true;
      this.Label3.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label3.ForeColor = Color.DarkOliveGreen;
      this.Label3.Location = new Point(19, 36);
      this.Label3.Name = "Label3";
      this.Label3.Size = new Size(795, 108);
      this.Label3.TabIndex = 21;
      this.Label3.Text = componentResourceManager.GetString("Label3.Text");
      this.txtSearch.Location = new Point(119, 7);
      this.txtSearch.Name = "txtSearch";
      this.txtSearch.Size = new Size(657, 20);
      this.txtSearch.TabIndex = 18;
      this.Label2.AutoSize = true;
      this.Label2.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label2.Location = new Point(12, 9);
      this.Label2.Name = "Label2";
      this.Label2.Size = new Size(101, 18);
      this.Label2.TabIndex = 20;
      this.Label2.Text = "Search Criteria";
      this.cmdSimpleSearch.BackColor = Color.LightSlateGray;
      this.cmdSimpleSearch.Cursor = Cursors.Hand;
      this.cmdSimpleSearch.FlatStyle = FlatStyle.Popup;
      this.cmdSimpleSearch.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.cmdSimpleSearch.ForeColor = Color.White;
      this.cmdSimpleSearch.Location = new Point(482, 134);
      this.cmdSimpleSearch.Name = "cmdSimpleSearch";
      this.cmdSimpleSearch.Size = new Size(92, 29);
      this.cmdSimpleSearch.TabIndex = 19;
      this.cmdSimpleSearch.Text = "Search";
      this.cmdSimpleSearch.UseVisualStyleBackColor = false;
      this.cmdCancel.BackColor = Color.LightSlateGray;
      this.cmdCancel.Cursor = Cursors.Hand;
      this.cmdCancel.DialogResult = DialogResult.Cancel;
      this.cmdCancel.FlatStyle = FlatStyle.Popup;
      this.cmdCancel.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.cmdCancel.ForeColor = Color.White;
      this.cmdCancel.Location = new Point(482, 169);
      this.cmdCancel.Name = "cmdCancel";
      this.cmdCancel.Size = new Size(92, 25);
      this.cmdCancel.TabIndex = 23;
      this.cmdCancel.Text = "Cancel";
      this.cmdCancel.UseVisualStyleBackColor = false;
      this.CmdNext1.BackColor = Color.LightSlateGray;
      this.CmdNext1.Cursor = Cursors.Hand;
      this.CmdNext1.DialogResult = DialogResult.OK;
      this.CmdNext1.FlatStyle = FlatStyle.Popup;
      this.CmdNext1.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.CmdNext1.ForeColor = Color.White;
      this.CmdNext1.Location = new Point(580, 169);
      this.CmdNext1.Name = "CmdNext1";
      this.CmdNext1.Size = new Size(92, 25);
      this.CmdNext1.TabIndex = 22;
      this.CmdNext1.Text = "Confirm";
      this.CmdNext1.UseVisualStyleBackColor = false;
      this.cmdShow.BackColor = Color.LightSlateGray;
      this.cmdShow.Cursor = Cursors.Hand;
      this.cmdShow.FlatStyle = FlatStyle.Popup;
      this.cmdShow.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.cmdShow.ForeColor = Color.White;
      this.cmdShow.Location = new Point(678, 169);
      this.cmdShow.Name = "cmdShow";
      this.cmdShow.Size = new Size(124, 25);
      this.cmdShow.TabIndex = 24;
      this.cmdShow.Tag = (object) "Clear";
      this.cmdShow.Text = "Show Details";
      this.cmdShow.UseVisualStyleBackColor = false;
      this.SplitContainer1.Dock = DockStyle.Bottom;
      this.SplitContainer1.Location = new Point(0, 200);
      this.SplitContainer1.Name = "SplitContainer1";
      this.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
      this.SplitContainer1.Panel1.Controls.Add((Control) this.SearchResults);
      this.SplitContainer1.Panel2.Controls.Add((Control) this.DataInfoSub);
      this.SplitContainer1.Panel2.Controls.Add((Control) this.DataInfo);
      this.SplitContainer1.Size = new Size(814, 486);
      this.SplitContainer1.SplitterDistance = 210;
      this.SplitContainer1.TabIndex = 25;
      this.SearchResults.AllowUserToAddRows = false;
      this.SearchResults.AllowUserToDeleteRows = false;
      gridViewCellStyle1.BackColor = Color.Lavender;
      this.SearchResults.AlternatingRowsDefaultCellStyle = gridViewCellStyle1;
      this.SearchResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.SearchResults.Cursor = Cursors.Hand;
      this.SearchResults.Dock = DockStyle.Fill;
      this.SearchResults.Location = new Point(0, 0);
      this.SearchResults.Name = "SearchResults";
      this.SearchResults.ReadOnly = true;
      this.SearchResults.RowHeadersVisible = false;
      this.SearchResults.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.SearchResults.Size = new Size(814, 210);
      this.SearchResults.TabIndex = 4;
      gridViewCellStyle2.BackColor = Color.Lavender;
      this.DataInfoSub.AlternatingRowsDefaultCellStyle = gridViewCellStyle2;
      this.DataInfoSub.BackgroundColor = Color.White;
      this.DataInfoSub.BorderStyle = BorderStyle.Fixed3D;
      this.DataInfoSub.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
      this.DataInfoSub.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.DataInfoSub.Dock = DockStyle.Fill;
      this.DataInfoSub.Location = new Point(311, 0);
      this.DataInfoSub.Name = "DataInfoSub";
      this.DataInfoSub.ReadOnly = true;
      this.DataInfoSub.RowHeadersVisible = false;
      this.DataInfoSub.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.DataInfoSub.Size = new Size(503, 272);
      this.DataInfoSub.TabIndex = 6;
      this.DataInfoSub.TabStop = false;
      gridViewCellStyle3.BackColor = Color.Lavender;
      this.DataInfo.AlternatingRowsDefaultCellStyle = gridViewCellStyle3;
      this.DataInfo.BackgroundColor = Color.White;
      this.DataInfo.BorderStyle = BorderStyle.Fixed3D;
      this.DataInfo.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
      this.DataInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.DataInfo.ColumnHeadersVisible = false;
      this.DataInfo.Dock = DockStyle.Left;
      this.DataInfo.Location = new Point(0, 0);
      this.DataInfo.Name = "DataInfo";
      this.DataInfo.ReadOnly = true;
      this.DataInfo.RowHeadersVisible = false;
      this.DataInfo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.DataInfo.Size = new Size(311, 272);
      this.DataInfo.TabIndex = 5;
      this.DataInfo.TabStop = false;
      this.Label1.AutoSize = true;
      this.Label1.Location = new Point(12, 169);
      this.Label1.Name = "Label1";
      this.Label1.Size = new Size(45, 15);
      this.Label1.TabIndex = 26;
      this.Label1.Text = "Label1";
      this.AcceptButton = (IButtonControl) this.CmdNext1;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.White;
      this.CancelButton = (IButtonControl) this.cmdCancel;
      this.ClientSize = new Size(814, 686);
      this.Controls.Add((Control) this.cmdSimpleSearch);
      this.Controls.Add((Control) this.Label1);
      this.Controls.Add((Control) this.SplitContainer1);
      this.Controls.Add((Control) this.cmdCancel);
      this.Controls.Add((Control) this.CmdNext1);
      this.Controls.Add((Control) this.cmdShow);
      this.Controls.Add((Control) this.Label3);
      this.Controls.Add((Control) this.txtSearch);
      this.Controls.Add((Control) this.Label2);
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.Name = nameof (CHP_Search);
      this.Text = "CHP Search";
      this.SplitContainer1.Panel1.ResumeLayout(false);
      this.SplitContainer1.Panel2.ResumeLayout(false);
      this.SplitContainer1.ResumeLayout(false);
      ((ISupportInitialize) this.SearchResults).EndInit();
      ((ISupportInitialize) this.DataInfoSub).EndInit();
      ((ISupportInitialize) this.DataInfo).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    [field: AccessedThroughProperty("Label3")]
    internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtSearch")]
    internal virtual TextBox txtSearch { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label2")]
    internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button cmdSimpleSearch
    {
      get => this._cmdSimpleSearch;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdSimpleSearch_Click);
        Button cmdSimpleSearch1 = this._cmdSimpleSearch;
        if (cmdSimpleSearch1 != null)
          cmdSimpleSearch1.Click -= eventHandler;
        this._cmdSimpleSearch = value;
        Button cmdSimpleSearch2 = this._cmdSimpleSearch;
        if (cmdSimpleSearch2 == null)
          return;
        cmdSimpleSearch2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("cmdCancel")]
    private virtual Button cmdCancel { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private virtual Button CmdNext1
    {
      get => this._CmdNext1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CmdNext1_Click);
        Button cmdNext1_1 = this._CmdNext1;
        if (cmdNext1_1 != null)
          cmdNext1_1.Click -= eventHandler;
        this._CmdNext1 = value;
        Button cmdNext1_2 = this._CmdNext1;
        if (cmdNext1_2 == null)
          return;
        cmdNext1_2.Click += eventHandler;
      }
    }

    private virtual Button cmdShow
    {
      get => this._cmdShow;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdShow_Click);
        Button cmdShow1 = this._cmdShow;
        if (cmdShow1 != null)
          cmdShow1.Click -= eventHandler;
        this._cmdShow = value;
        Button cmdShow2 = this._cmdShow;
        if (cmdShow2 == null)
          return;
        cmdShow2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("SplitContainer1")]
    internal virtual SplitContainer SplitContainer1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

    [field: AccessedThroughProperty("DataInfo")]
    internal virtual DataGridView DataInfo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DataInfoSub")]
    internal virtual DataGridView DataInfoSub { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label1")]
    internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private void cmdShow_Click(object sender, EventArgs e)
    {
      if (this.SplitContainer1.Panel2Collapsed)
      {
        this.SplitContainer1.Panel2Collapsed = false;
        this.cmdShow.Text = "Hide Details";
      }
      else
      {
        this.SplitContainer1.Panel2Collapsed = true;
        this.cmdShow.Text = "Show Details";
      }
    }

    private void CHP_Search_Load(object sender, EventArgs e)
    {
      this.NewTable = Validation.ListToDataTable<PCDF.CHP>(SAP_Module.PCDFData.CHPs);
      this.SearchResults.DataSource = (object) this.NewTable;
      this.Label1.Text = "Currently Showing " + Conversions.ToString(this.SearchResults.RowCount) + " out of " + Conversions.ToString(SAP_Module.PCDFData.CHPs.Count);
      if (this.DataInfo.ColumnCount == 0)
      {
        this.DataInfo.Columns.Add("C1", "C1");
        this.DataInfo.Columns.Add("C2", "C2");
        this.DataInfo.Rows.Add(25);
      }
      this.DataInfo.Columns[0].Width = 120;
      this.DataInfo.Columns[1].Width = 250;
      this.DataInfo.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
      int num = checked (this.SearchResults.Rows.Count - 1);
      int index = 0;
      while (index <= num)
      {
        object Left1 = this.SearchResults.Rows[index].Cells["ProductType"].Value;
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left1, (object) 0, false))
          this.SearchResults.Rows[index].Cells["ProductType"].Value = (object) "normal";
        else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left1, (object) 1, false))
          this.SearchResults.Rows[index].Cells["ProductType"].Value = (object) "illustrative";
        else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left1, (object) 2, false))
          this.SearchResults.Rows[index].Cells["ProductType"].Value = (object) "under investigation";
        else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left1, (object) 3, false))
          this.SearchResults.Rows[index].Cells["ProductType"].Value = (object) "not valid";
        else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left1, (object) 4, false))
          this.SearchResults.Rows[index].Cells["ProductType"].Value = (object) "The SAP CoGen methodology is currently being reviewed. This entry may change.";
        object Left2 = this.SearchResults.Rows[index].Cells["Fuel"].Value;
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left2, (object) 1, false))
          this.SearchResults.Rows[index].Cells["Fuel"].Value = (object) "Gas";
        else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left2, (object) 11, false))
          this.SearchResults.Rows[index].Cells["Fuel"].Value = (object) "house coal";
        else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left2, (object) 12, false))
          this.SearchResults.Rows[index].Cells["Fuel"].Value = (object) "smokeless fuel";
        else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left2, (object) 13, false))
          this.SearchResults.Rows[index].Cells["Fuel"].Value = (object) "anthracite";
        else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left2, (object) 20, false))
          this.SearchResults.Rows[index].Cells["Fuel"].Value = (object) "wood logs";
        else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left2, (object) 21, false))
          this.SearchResults.Rows[index].Cells["Fuel"].Value = (object) "wood chips";
        else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left2, (object) 23, false))
          this.SearchResults.Rows[index].Cells["Fuel"].Value = (object) "wood pellets";
        else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left2, (object) 10, false))
          this.SearchResults.Rows[index].Cells["Fuel"].Value = (object) "dual fuel appliance (mineral and wood)";
        else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left2, (object) 11, false))
          this.SearchResults.Rows[index].Cells["Fuel"].Value = (object) "house coal";
        else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left2, (object) 45, false))
          this.SearchResults.Rows[index].Cells["Fuel"].Value = (object) "waste heat from power stations";
        else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left2, (object) 49, false))
          this.SearchResults.Rows[index].Cells["Fuel"].Value = (object) "electricity generated by CHP";
        else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left2, (object) 50, false))
          this.SearchResults.Rows[index].Cells["Fuel"].Value = (object) "heat from boilers – B30D1";
        else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left2, (object) 52, false))
          this.SearchResults.Rows[index].Cells["Fuel"].Value = (object) "heat from boilers – LPG";
        else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left2, (object) 53, false))
          this.SearchResults.Rows[index].Cells["Fuel"].Value = (object) "heat from boilers – oil";
        else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left2, (object) 39, false))
          this.SearchResults.Rows[index].Cells["Fuel"].Value = (object) "Electricity";
        object Left3 = this.SearchResults.Rows[index].Cells["Condensing"].Value;
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left3, (object) 1, false))
          this.SearchResults.Rows[index].Cells["Condensing"].Value = (object) "Non-condensing";
        else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left3, (object) 2, false))
          this.SearchResults.Rows[index].Cells["Condensing"].Value = (object) "Condensing";
        object Left4 = this.SearchResults.Rows[index].Cells["Flue_Type"].Value;
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left4, (object) 0, false))
          this.SearchResults.Rows[index].Cells["Flue_Type"].Value = (object) "unknown";
        else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left4, (object) 1, false))
          this.SearchResults.Rows[index].Cells["Flue_Type"].Value = (object) "open";
        else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left4, (object) 2, false))
          this.SearchResults.Rows[index].Cells["Flue_Type"].Value = (object) "room-sealed";
        else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left4, (object) 3, false))
          this.SearchResults.Rows[index].Cells["Flue_Type"].Value = (object) "open or room-sealed";
        try
        {
          object Left5 = this.SearchResults.Rows[index].Cells["Serviceprovision"].Value;
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left5, (object) 0, false))
            this.SearchResults.Rows[index].Cells["Serviceprovision"].Value = (object) "unknown";
          else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left5, (object) 1, false))
            this.SearchResults.Rows[index].Cells["Serviceprovision"].Value = (object) "space and water heating all year";
          else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left5, (object) 2, false))
            this.SearchResults.Rows[index].Cells["Serviceprovision"].Value = (object) "space and water heating during heating season only";
          else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left5, (object) 3, false))
            this.SearchResults.Rows[index].Cells["Serviceprovision"].Value = (object) "space heating only; ";
          else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left5, (object) 4, false))
            this.SearchResults.Rows[index].Cells["Serviceprovision"].Value = (object) "water heating only";
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        try
        {
          object Left6 = this.SearchResults.Rows[index].Cells["HWVessel"].Value;
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left6, (object) 4, false))
            this.SearchResults.Rows[index].Cells["HWVessel"].Value = (object) "none";
          else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left6, (object) 1, false))
            this.SearchResults.Rows[index].Cells["HWVessel"].Value = (object) "integral";
          else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left6, (object) 3, false))
            this.SearchResults.Rows[index].Cells["HWVessel"].Value = (object) "none";
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        checked { ++index; }
      }
      this.DataInfo[0, 0].Value = (object) "ID";
      this.DataInfo[0, 1].Value = (object) "ManuRef";
      this.DataInfo[0, 2].Value = (object) "ProductType";
      this.DataInfo[0, 3].Value = (object) "EntryUpdate";
      this.DataInfo[0, 4].Value = (object) "APM";
      this.DataInfo[0, 5].Value = (object) "Manu";
      this.DataInfo[0, 6].Value = (object) "Brand";
      this.DataInfo[0, 7].Value = (object) "Model";
      this.DataInfo[0, 8].Value = (object) "Qualifier";
      this.DataInfo[0, 9].Value = (object) "1st_year";
      this.DataInfo[0, 10].Value = (object) "Last_Year";
      this.DataInfo[0, 11].Value = (object) "Fuel";
      this.DataInfo[0, 12].Value = (object) "Condensing";
      this.DataInfo[0, 13].Value = (object) "Flue_Type";
      this.DataInfo[0, 14].Value = (object) "ServiceProvision";
      this.DataInfo[0, 15].Value = (object) "HWVessel";
      this.DataInfo[0, 16].Value = (object) "Class";
      this.DataInfo[0, 17].Value = (object) "WHEffSch2";
      this.DataInfo[0, 18].Value = (object) "NetElecConsumedSch2";
      this.DataInfo[0, 19].Value = (object) "WHEffSch3";
      this.DataInfo[0, 20].Value = (object) "NetElecConsumedSch3";
      this.DataInfo[0, 21].Value = (object) "CogenPPowerBottom";
      this.DataInfo[0, 22].Value = (object) "CogenPPowerTop";
      this.DataInfo[0, 23].Value = (object) "HeatingDuration";
      this.DataInfo[0, 24].Value = (object) "SepCirculator";
      this.DataInfo[0, 25].Value = (object) "PSR_Numb";
    }

    private void cmdSimpleSearch_Click(object sender, EventArgs e)
    {
      // ISSUE: variable of a compiler-generated type
      CHP_Search._Closure\u0024__55\u002D0 closure550_1;
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      CHP_Search._Closure\u0024__55\u002D0 closure550_2 = new CHP_Search._Closure\u0024__55\u002D0(closure550_1);
      List<PCDF.CHP> chpList = SAP_Module.PCDFData.CHPs;
      // ISSUE: reference to a compiler-generated field
      closure550_2.\u0024VB\u0024Local_SQL = this.txtSearch.Text.Split(' ');
      // ISSUE: variable of a compiler-generated type
      CHP_Search._Closure\u0024__55\u002D1 closure551_1;
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      CHP_Search._Closure\u0024__55\u002D1 closure551_2 = new CHP_Search._Closure\u0024__55\u002D1(closure551_1);
      // ISSUE: reference to a compiler-generated field
      closure551_2.\u0024VB\u0024NonLocal_\u0024VB\u0024Closure_2 = closure550_2;
      // ISSUE: variable of a compiler-generated type
      CHP_Search._Closure\u0024__55\u002D1 closure551_3 = closure551_2;
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      int num = Information.UBound((Array) closure551_2.\u0024VB\u0024NonLocal_\u0024VB\u0024Closure_2.\u0024VB\u0024Local_SQL);
      // ISSUE: reference to a compiler-generated field
      closure551_3.\u0024VB\u0024Local_i = 0;
      // ISSUE: reference to a compiler-generated field
      while (closure551_2.\u0024VB\u0024Local_i <= num)
      {
        // ISSUE: reference to a compiler-generated method
        chpList = chpList.Where<PCDF.CHP>(new Func<PCDF.CHP, bool>(closure551_2._Lambda\u0024__0)).ToList<PCDF.CHP>();
        // ISSUE: reference to a compiler-generated field
        checked { ++closure551_2.\u0024VB\u0024Local_i; }
      }
      this.NewTable = Validation.ListToDataTable<PCDF.CHP>(chpList);
      this.SearchResults.DataSource = (object) this.NewTable;
      this.Label1.Text = "Currently Showing " + Conversions.ToString(this.SearchResults.RowCount) + " out of " + Conversions.ToString(SAP_Module.PCDFData.CHPs.Count);
    }

    private void SearchResults_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
    {
      // ISSUE: variable of a compiler-generated type
      CHP_Search._Closure\u0024__56\u002D0 closure560_1;
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      CHP_Search._Closure\u0024__56\u002D0 closure560_2 = new CHP_Search._Closure\u0024__56\u002D0(closure560_1);
      // ISSUE: reference to a compiler-generated field
      closure560_2.\u0024VB\u0024Me = this;
      // ISSUE: reference to a compiler-generated field
      closure560_2.\u0024VB\u0024Local_e = e;
      // ISSUE: reference to a compiler-generated field
      if (closure560_2.\u0024VB\u0024Local_e.RowIndex <= -1)
        return;
      int num1 = checked (this.DataInfo.Rows.Count - 1);
      int num2 = 0;
      while (num2 <= num1)
      {
        // ISSUE: reference to a compiler-generated field
        this.DataInfo[1, num2].Value = RuntimeHelpers.GetObjectValue(this.SearchResults[num2, closure560_2.\u0024VB\u0024Local_e.RowIndex].Value);
        checked { ++num2; }
      }
      // ISSUE: reference to a compiler-generated method
      List<PCDF.CHP_Sub> list = SAP_Module.PCDFData.CHPs_Sub.Where<PCDF.CHP_Sub>(new Func<PCDF.CHP_Sub, bool>(closure560_2._Lambda\u0024__0)).ToList<PCDF.CHP_Sub>();
      if (this.DataInfoSub.Columns.Count == 0)
      {
        this.DataInfoSub.Columns.Add("ID", "ID");
        this.DataInfoSub.Columns.Add("PSR", "PSR");
        this.DataInfoSub.Columns.Add("Space", "Space");
        this.DataInfoSub.Columns.Add("Water", "Water");
        this.DataInfoSub.Columns.Add("aux", "aux");
        this.DataInfoSub.Columns.Add("eff_season", "eff_season");
        this.DataInfoSub.Columns.Add("eff_summer", "eff_summer");
        this.DataInfoSub.Columns.Add("elec_season", "elec_season");
        this.DataInfoSub.Columns.Add("elec_summer", "elec_summer");
        this.DataInfoSub.Columns.Add("d_16-9", "d_16-9");
        this.DataInfoSub.Columns.Add("d_24-9", "d_24-9");
        this.DataInfoSub.Columns.Add("d_24-16", "d_24-16");
        this.DataInfoSub.Columns.Add("Key", "Key");
      }
      else
        this.DataInfoSub.Rows.Clear();
      int num3 = checked (list.Count - 1);
      int index = 0;
      while (index <= num3)
      {
        this.DataInfoSub.Rows.Add((object) list[index].ID, (object) list[index].PSR);
        checked { ++index; }
      }
    }

    private void CmdNext1_Click(object sender, EventArgs e)
    {
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SEDBUK = Conversions.ToString(this.SearchResults[0, this.SearchResults.CurrentRow.Index].Value);
      if (PDFFunctions.MainHeating2Search)
      {
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SEDBUK = Conversions.ToString(this.SearchResults[0, this.SearchResults.CurrentRow.Index].Value);
        SAP_Read.CheckSEDBUK2();
      }
      else
        SAP_Read.CheckSEDBUK();
      try
      {
        if (PDFFunctions.MainHeating2Search)
        {
          if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(MyProject.Forms.SAPForm.txtMainFuel.Text, "", false) <= 0U)
            return;
          WaterHeating.PaniCheck(1, MyProject.Forms.SAPForm.txtSecMainFuel.Text, SAP_Module.CurrDwelling);
        }
        else if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(MyProject.Forms.SAPForm.txtMainFuel.Text, "", false) > 0U)
          WaterHeating.PaniCheck(1, MyProject.Forms.SAPForm.txtMainFuel.Text, SAP_Module.CurrDwelling);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      finally
      {
        PDFFunctions.MainHeating2Search = false;
      }
    }
  }
}
