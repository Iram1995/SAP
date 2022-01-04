
// Type: SAP2012.Solid_Search




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
  public class Solid_Search : Form
  {
    private IContainer components;
    private DataTable NewTable;

    public Solid_Search()
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Solid_Search));
      DataGridViewCellStyle gridViewCellStyle1 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle2 = new DataGridViewCellStyle();
      this.Label3 = new Label();
      this.txtSearch = new TextBox();
      this.Label2 = new Label();
      this.cmdSimpleSearch = new Button();
      this.cmdCancel = new Button();
      this.CmdNext1 = new Button();
      this.cmdShow = new Button();
      this.SplitContainer1 = new SplitContainer();
      this.SearchResults = new DataGridView();
      this.DataInfo = new DataGridView();
      this.Label1 = new Label();
      this.SplitContainer1.Panel1.SuspendLayout();
      this.SplitContainer1.Panel2.SuspendLayout();
      this.SplitContainer1.SuspendLayout();
      ((ISupportInitialize) this.SearchResults).BeginInit();
      ((ISupportInitialize) this.DataInfo).BeginInit();
      this.SuspendLayout();
      this.Label3.AutoSize = true;
      this.Label3.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label3.ForeColor = Color.DarkOliveGreen;
      this.Label3.Location = new Point(12, 30);
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
      this.cmdSimpleSearch.Location = new Point(486, 132);
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
      this.cmdCancel.Location = new Point(486, 167);
      this.cmdCancel.Name = "cmdCancel";
      this.cmdCancel.Size = new Size(92, 29);
      this.cmdCancel.TabIndex = 23;
      this.cmdCancel.Text = "Cancel";
      this.cmdCancel.UseVisualStyleBackColor = false;
      this.CmdNext1.BackColor = Color.LightSlateGray;
      this.CmdNext1.Cursor = Cursors.Hand;
      this.CmdNext1.DialogResult = DialogResult.OK;
      this.CmdNext1.FlatStyle = FlatStyle.Popup;
      this.CmdNext1.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.CmdNext1.ForeColor = Color.White;
      this.CmdNext1.Location = new Point(584, 167);
      this.CmdNext1.Name = "CmdNext1";
      this.CmdNext1.Size = new Size(92, 29);
      this.CmdNext1.TabIndex = 22;
      this.CmdNext1.Text = "Confirm";
      this.CmdNext1.UseVisualStyleBackColor = false;
      this.cmdShow.BackColor = Color.LightSlateGray;
      this.cmdShow.Cursor = Cursors.Hand;
      this.cmdShow.FlatStyle = FlatStyle.Popup;
      this.cmdShow.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.cmdShow.ForeColor = Color.White;
      this.cmdShow.Location = new Point(682, 167);
      this.cmdShow.Name = "cmdShow";
      this.cmdShow.Size = new Size(124, 29);
      this.cmdShow.TabIndex = 24;
      this.cmdShow.Tag = (object) "Clear";
      this.cmdShow.Text = "Show Details";
      this.cmdShow.UseVisualStyleBackColor = false;
      this.SplitContainer1.Dock = DockStyle.Bottom;
      this.SplitContainer1.Location = new Point(0, 202);
      this.SplitContainer1.Name = "SplitContainer1";
      this.SplitContainer1.Panel1.Controls.Add((Control) this.SearchResults);
      this.SplitContainer1.Panel2.Controls.Add((Control) this.DataInfo);
      this.SplitContainer1.Size = new Size(806, 486);
      this.SplitContainer1.SplitterDistance = 533;
      this.SplitContainer1.TabIndex = 25;
      this.SearchResults.AllowUserToAddRows = false;
      this.SearchResults.AllowUserToDeleteRows = false;
      this.SearchResults.AllowUserToResizeRows = false;
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
      this.SearchResults.Size = new Size(533, 486);
      this.SearchResults.TabIndex = 4;
      gridViewCellStyle2.BackColor = Color.Lavender;
      this.DataInfo.AlternatingRowsDefaultCellStyle = gridViewCellStyle2;
      this.DataInfo.BackgroundColor = Color.White;
      this.DataInfo.BorderStyle = BorderStyle.Fixed3D;
      this.DataInfo.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
      this.DataInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.DataInfo.ColumnHeadersVisible = false;
      this.DataInfo.Dock = DockStyle.Fill;
      this.DataInfo.Location = new Point(0, 0);
      this.DataInfo.Name = "DataInfo";
      this.DataInfo.ReadOnly = true;
      this.DataInfo.RowHeadersVisible = false;
      this.DataInfo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.DataInfo.Size = new Size(269, 486);
      this.DataInfo.TabIndex = 5;
      this.DataInfo.TabStop = false;
      this.Label1.AutoSize = true;
      this.Label1.Location = new Point(12, 167);
      this.Label1.Name = "Label1";
      this.Label1.Size = new Size(45, 15);
      this.Label1.TabIndex = 26;
      this.Label1.Text = "Label1";
      this.AcceptButton = (IButtonControl) this.CmdNext1;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.White;
      this.CancelButton = (IButtonControl) this.cmdCancel;
      this.ClientSize = new Size(806, 688);
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
      this.Name = nameof (Solid_Search);
      this.Text = "Solid Boiler Search";
      this.SplitContainer1.Panel1.ResumeLayout(false);
      this.SplitContainer1.Panel2.ResumeLayout(false);
      this.SplitContainer1.ResumeLayout(false);
      ((ISupportInitialize) this.SearchResults).EndInit();
      ((ISupportInitialize) this.DataInfo).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    [field: AccessedThroughProperty("Label3")]
    internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox txtSearch
    {
      get => this._txtSearch;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtSearch_TextChanged);
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
      this.NewTable = new DataTable();
      PCDF pcdfData;
      List<PCDF.SEDBUK_Solid> solidBoilers = (pcdfData = SAP_Module.PCDFData).Solid_Boilers;
      List<PCDF.SEDBUK_Solid> items = Functions.DeepClone<List<PCDF.SEDBUK_Solid>>(ref solidBoilers);
      pcdfData.Solid_Boilers = solidBoilers;
      this.NewTable = Validation.ListToDataTable<PCDF.SEDBUK_Solid>(items);
      int num = checked (this.NewTable.Rows.Count - 1);
      int index = 0;
      while (index <= num)
      {
        object Left1 = this.NewTable.Rows[index]["ProductType"];
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left1, (object) "0", false))
          this.NewTable.Rows[index]["ProductType"] = (object) "normal";
        else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left1, (object) "1", false))
          this.NewTable.Rows[index]["ProductType"] = (object) "illustrative";
        else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left1, (object) "2", false))
          this.NewTable.Rows[index]["ProductType"] = (object) "under investigation";
        else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left1, (object) "3", false))
          this.NewTable.Rows[index]["ProductType"] = (object) "not valid";
        else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left1, (object) "4", false))
          this.NewTable.Rows[index]["ProductType"] = (object) "The SAP Solid Fuel Boiler methodology is currently being reviewed. This entry may change.";
        object Left2 = this.NewTable.Rows[index]["Fuel"];
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left2, (object) 11, false))
          this.NewTable.Rows[index]["Fuel"] = (object) "house coal";
        else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left2, (object) 12, false))
          this.NewTable.Rows[index]["Fuel"] = (object) "smokeless fuel";
        else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left2, (object) 13, false))
          this.NewTable.Rows[index]["Fuel"] = (object) "anthracite";
        else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left2, (object) 20, false))
          this.NewTable.Rows[index]["Fuel"] = (object) "wood logs";
        else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left2, (object) 21, false))
          this.NewTable.Rows[index]["Fuel"] = (object) "wood chips";
        else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left2, (object) 23, false))
          this.NewTable.Rows[index]["Fuel"] = (object) "wood pellets";
        object Left3 = this.NewTable.Rows[index]["MainType"];
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left3, (object) 1, false))
          this.NewTable.Rows[index]["MainType"] = (object) "open fire with boiler";
        else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left3, (object) 2, false))
          this.NewTable.Rows[index]["MainType"] = (object) "closed room heater with boiler";
        else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left3, (object) 3, false))
          this.NewTable.Rows[index]["MainType"] = (object) "independent boiler";
        object Left4 = this.NewTable.Rows[index]["Flue"];
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left4, (object) 0, false))
          this.NewTable.Rows[index]["Flue"] = (object) "unknown";
        else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left4, (object) 1, false))
          this.NewTable.Rows[index]["Flue"] = (object) "open";
        else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left4, (object) 2, false))
          this.NewTable.Rows[index]["Flue"] = (object) "room-sealed";
        else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left4, (object) 3, false))
          this.NewTable.Rows[index]["Flue"] = (object) "open or room-sealed";
        object Left5 = this.NewTable.Rows[index]["FanAssist"];
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left5, (object) 0, false))
          this.NewTable.Rows[index]["FanAssist"] = (object) "unknown";
        else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left5, (object) 1, false))
          this.NewTable.Rows[index]["FanAssist"] = (object) "no fan";
        else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left5, (object) 2, false))
          this.NewTable.Rows[index]["FanAssist"] = (object) "fan";
        object Left6 = this.NewTable.Rows[index]["Fuelfeed"];
        this.NewTable.Rows[index]["Fuelfeed"] = !Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left6, (object) 0, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left6, (object) 1, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left6, (object) 2, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left6, (object) 3, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left6, (object) 4, false) ? (object) "not applicable" : (object) "Other") : (object) "screw feed") : (object) "gravity feed") : (object) "manual feed") : (object) "unknown";
        object Left7 = this.NewTable.Rows[index]["Effcat"];
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left7, (object) 1, false))
          this.NewTable.Rows[index]["Effcat"] = (object) "HETAS approved";
        else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left7, (object) 2, false))
          this.NewTable.Rows[index]["Effcat"] = (object) "certified measurement to BS EN standard";
        else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left7, (object) 3, false))
          this.NewTable.Rows[index]["Effcat"] = (object) "estimated as SAP default value";
        object Left8 = this.NewTable.Rows[index]["Burner"];
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left8, (object) 0, false))
          this.NewTable.Rows[index]["Burner"] = (object) "unknown";
        else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left8, (object) 1, false))
          this.NewTable.Rows[index]["Burner"] = (object) "manual";
        else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left8, (object) 2, false))
          this.NewTable.Rows[index]["Burner"] = (object) "electrical";
        checked { ++index; }
      }
      this.SearchResults.DataSource = (object) this.NewTable;
      this.Label1.Text = "Currently Showing " + Conversions.ToString(this.SearchResults.RowCount) + " out of " + Conversions.ToString(SAP_Module.PCDFData.Solid_Boilers.Count);
      if (this.DataInfo.ColumnCount == 0)
      {
        this.DataInfo.Columns.Add("C1", "C1");
        this.DataInfo.Columns.Add("C2", "C2");
        this.DataInfo.Rows.Add(33);
      }
      this.DataInfo.Columns[0].Width = 120;
      this.DataInfo.Columns[1].Width = 250;
      this.DataInfo.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
      this.DataInfo[0, 0].Value = (object) "ID";
      this.DataInfo[0, 1].Value = (object) "RefNo";
      this.DataInfo[0, 2].Value = (object) "Product Type";
      this.DataInfo[0, 3].Value = (object) "Entry Update";
      this.DataInfo[0, 4].Value = (object) "Manufacturer";
      this.DataInfo[0, 5].Value = (object) "Brand Name";
      this.DataInfo[0, 6].Value = (object) "Model Name";
      this.DataInfo[0, 7].Value = (object) "Model Qualifier";
      this.DataInfo[0, 8].Value = (object) "Product ID";
      this.DataInfo[0, 9].Value = (object) "First Manu";
      this.DataInfo[0, 10].Value = (object) "Final Manu";
      this.DataInfo[0, 11].Value = (object) "Fuel";
      this.DataInfo[0, 12].Value = (object) "Main Type";
      this.DataInfo[0, 13].Value = (object) "Flue";
      this.DataInfo[0, 14].Value = (object) "Fan Assististed";
      this.DataInfo[0, 15].Value = (object) "Fuel Feed";
      this.DataInfo[0, 16].Value = (object) "Boiler Power (bottom of range)";
      this.DataInfo[0, 17].Value = (object) "Boiler Power (top of range)";
      this.DataInfo[0, 18].Value = (object) "Boiler Power at minimum burn rate";
      this.DataInfo[0, 19].Value = (object) "Energy efficiency class";
      this.DataInfo[0, 20].Value = (object) "SAP Efficiency efficiency of boiler";
      this.DataInfo[0, 21].Value = (object) "Efficiency Catagory";
      this.DataInfo[0, 22].Value = (object) "Measured fuel input at nominal output power";
      this.DataInfo[0, 23].Value = (object) "Measured heat to water at nominal output";
      this.DataInfo[0, 24].Value = (object) "Measured heat to room at nominal output power";
      this.DataInfo[0, 25].Value = (object) "Measured fuel input at part output power";
      this.DataInfo[0, 26].Value = (object) "Measured heat to water at part output power";
      this.DataInfo[0, 27].Value = (object) "Measured heat to room at part output power";
      this.DataInfo[0, 28].Value = (object) "Ple test method";
      this.DataInfo[0, 29].Value = (object) "Burner control boiler is firing";
      this.DataInfo[0, 30].Value = (object) "Electrical power while boiler is firing";
      this.DataInfo[0, 31].Value = (object) "Electrical power while boiler is not firing";
      this.DataInfo[0, 32].Value = (object) "Additional ventilation rate";
    }

    private void cmdSimpleSearch_Click(object sender, EventArgs e)
    {
      List<PCDF.SEDBUK_Solid> sedbukSolidList = SAP_Module.PCDFData.Solid_Boilers;
      string[] strArray = this.txtSearch.Text.Split(' ');
      int num1 = Information.UBound((Array) strArray);
      int index1 = 0;
      while (index1 <= num1)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        Solid_Search._Closure\u0024__51\u002D0 closure510 = new Solid_Search._Closure\u0024__51\u002D0(closure510);
        // ISSUE: reference to a compiler-generated field
        closure510.\u0024VB\u0024Local_searchString = strArray[index1];
        // ISSUE: reference to a compiler-generated method
        sedbukSolidList = sedbukSolidList.Where<PCDF.SEDBUK_Solid>(new Func<PCDF.SEDBUK_Solid, bool>(closure510._Lambda\u0024__0)).ToList<PCDF.SEDBUK_Solid>();
        checked { ++index1; }
      }
      try
      {
        int num2 = checked (sedbukSolidList.Count - 1);
        int index2 = 0;
        while (index2 <= num2)
        {
          string productType = sedbukSolidList[index2].ProductType;
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(productType, "0", false) != 0)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(productType, "1", false) != 0)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(productType, "2", false) != 0)
              {
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(productType, "3", false) != 0)
                {
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(productType, "4", false) == 0)
                    sedbukSolidList[index2].ProductType = "The SAP Solid Fuel Boiler methodology is currently being reviewed. This entry may change.";
                }
                else
                  sedbukSolidList[index2].ProductType = "not valid";
              }
              else
                sedbukSolidList[index2].ProductType = "under investigation";
            }
            else
              sedbukSolidList[index2].ProductType = "illustrative";
          }
          else
            sedbukSolidList[index2].ProductType = "normal";
          checked { ++index2; }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      this.NewTable = Validation.ListToDataTable<PCDF.SEDBUK_Solid>(sedbukSolidList);
      this.SearchResults.DataSource = (object) this.NewTable;
      this.Label1.Text = "Currently Showing " + Conversions.ToString(this.SearchResults.RowCount) + " out of " + Conversions.ToString(SAP_Module.PCDFData.Solid_Boilers.Count);
    }

    private void SearchResults_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
    {
      if (e.RowIndex <= -1)
        return;
      try
      {
        int num1 = checked (this.SearchResults.Columns.Count - 1);
        int num2 = 0;
        while (num2 <= num1)
        {
          this.DataInfo[1, num2].Value = RuntimeHelpers.GetObjectValue(this.SearchResults[num2, e.RowIndex].Value);
          checked { ++num2; }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      object Left = this.SearchResults["ProductType", e.RowIndex].Value;
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) "0", false))
        this.DataInfo[1, 2].Value = (object) "normal";
      else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) "1", false))
        this.DataInfo[1, 2].Value = (object) "illustrative";
      else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) "2", false))
        this.DataInfo[1, 2].Value = (object) "under investigation";
      else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) "3", false))
        this.DataInfo[1, 2].Value = (object) "not valid";
      else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) "4", false))
        this.DataInfo[1, 2].Value = (object) "The SAP Solid Fuel Boiler methodology is currently being reviewed. This entry may change.";
      double num3 = Conversion.Val(RuntimeHelpers.GetObjectValue(this.SearchResults["Fuel", e.RowIndex].Value));
      if (num3 == 11.0)
        this.DataInfo[1, 11].Value = (object) "house coal";
      else if (num3 == 12.0)
        this.DataInfo[1, 11].Value = (object) "smokeless fuel";
      else if (num3 == 13.0)
        this.DataInfo[1, 11].Value = (object) "anthracite";
      else if (num3 == 20.0)
        this.DataInfo[1, 11].Value = (object) "wood logs";
      else if (num3 == 21.0)
        this.DataInfo[1, 11].Value = (object) "wood chips";
      else if (num3 == 23.0)
        this.DataInfo[1, 11].Value = (object) "wood pellets";
      double num4 = Conversion.Val(RuntimeHelpers.GetObjectValue(this.SearchResults["MainType", e.RowIndex].Value));
      if (num4 == 1.0)
        this.DataInfo[1, 12].Value = (object) "open fire with boiler";
      else if (num4 == 2.0)
        this.DataInfo[1, 12].Value = (object) "closed room heater with boiler";
      else if (num4 == 3.0)
        this.DataInfo[1, 12].Value = (object) "independent boiler";
      double num5 = Conversion.Val(RuntimeHelpers.GetObjectValue(this.SearchResults["Flue", e.RowIndex].Value));
      if (num5 == 0.0)
        this.DataInfo[1, 13].Value = (object) "unknown";
      else if (num5 == 1.0)
        this.DataInfo[1, 13].Value = (object) "open";
      else if (num5 == 2.0)
        this.DataInfo[1, 13].Value = (object) "room-sealed";
      else if (num5 == 3.0)
        this.DataInfo[1, 13].Value = (object) "open or room-sealed";
      double num6 = Conversion.Val(RuntimeHelpers.GetObjectValue(this.SearchResults["FanAssist", e.RowIndex].Value));
      if (num6 == 0.0)
        this.DataInfo[1, 14].Value = (object) "unknown";
      else if (num6 == 1.0)
        this.DataInfo[1, 14].Value = (object) "no fan";
      else if (num6 == 2.0)
        this.DataInfo[1, 14].Value = (object) "fan";
      double num7 = Conversion.Val(RuntimeHelpers.GetObjectValue(this.SearchResults["Fuelfeed", e.RowIndex].Value));
      this.DataInfo[1, 15].Value = num7 != 0.0 ? (num7 != 1.0 ? (num7 != 2.0 ? (num7 != 3.0 ? (num7 != 4.0 ? (object) "not applicable" : (object) "Other") : (object) "screw feed") : (object) "gravity feed") : (object) "manual feed") : (object) "unknown";
      double num8 = Conversion.Val(RuntimeHelpers.GetObjectValue(this.SearchResults["Effcat", e.RowIndex].Value));
      if (num8 == 1.0)
        this.DataInfo[1, 21].Value = (object) "HETAS approved";
      else if (num8 == 2.0)
        this.DataInfo[1, 21].Value = (object) "certified measurement to BS EN standard";
      else if (num8 == 3.0)
        this.DataInfo[1, 21].Value = (object) "estimated as SAP default value";
      double num9 = Conversion.Val(RuntimeHelpers.GetObjectValue(this.SearchResults["Burner", e.RowIndex].Value));
      if (num9 == 0.0)
        this.DataInfo[1, 29].Value = (object) "unknown";
      else if (num9 == 1.0)
        this.DataInfo[1, 29].Value = (object) "manual";
      else if (num9 == 2.0)
        this.DataInfo[1, 29].Value = (object) "electrical";
    }

    private void CmdNext1_Click(object sender, EventArgs e)
    {
      if (!PDFFunctions.MainHeating2Search)
      {
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SEDBUK = Conversions.ToString(this.SearchResults[0, this.SearchResults.CurrentRow.Index].Value);
        SAP_Read.CheckSEDBUK();
      }
      else
      {
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SEDBUK = Conversions.ToString(this.SearchResults[0, this.SearchResults.CurrentRow.Index].Value);
        SAP_Read.CheckSEDBUK2();
      }
      try
      {
        if (PDFFunctions.MainHeating2Search)
        {
          if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(MyProject.Forms.SAPForm.txtSecMainFuel.Text, "", false) <= 0U)
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

    private void txtSearch_TextChanged(object sender, EventArgs e) => this.cmdSimpleSearch_Click(RuntimeHelpers.GetObjectValue(sender), e);
  }
}
