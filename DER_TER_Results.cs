
// Type: SAP2012.DER_TER_Results




using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace SAP2012
{
  [DesignerGenerated]
  public class DER_TER_Results : Form
  {
    private IContainer components;
    private DataTable DERDatatable;
    private DataTable TERDatatable;

    public DER_TER_Results()
    {
      this.Load += new EventHandler(this.DER_TER_Results_Load);
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (DER_TER_Results));
      this.CmExport = new ContextMenuStrip(this.components);
      this.DERExcelExportToolStripMenuItem = new ToolStripMenuItem();
      this.TERExcelExportToolStripMenuItem = new ToolStripMenuItem();
      this.ToolTip1 = new ToolTip(this.components);
      this.cmdexcel = new Button();
      this.TabPage4 = new TabPage();
      this.GDTER = new DataGridView();
      this.Button2 = new Button();
      this.TabControl1 = new TabControl();
      this.TabPage3 = new TabPage();
      this.GDDER = new DataGridView();
      this.Button1 = new Button();
      this.CmExport.SuspendLayout();
      this.TabPage4.SuspendLayout();
      ((ISupportInitialize) this.GDTER).BeginInit();
      this.TabControl1.SuspendLayout();
      this.TabPage3.SuspendLayout();
      ((ISupportInitialize) this.GDDER).BeginInit();
      this.SuspendLayout();
      this.CmExport.Items.AddRange(new ToolStripItem[2]
      {
        (ToolStripItem) this.DERExcelExportToolStripMenuItem,
        (ToolStripItem) this.TERExcelExportToolStripMenuItem
      });
      this.CmExport.Name = "CmExport";
      this.CmExport.Size = new Size(161, 48);
      this.CmExport.Text = "Export Options";
      this.DERExcelExportToolStripMenuItem.Image = (Image) SAP2012.My.Resources.Resources.xls_open_file_format;
      this.DERExcelExportToolStripMenuItem.Name = "DERExcelExportToolStripMenuItem";
      this.DERExcelExportToolStripMenuItem.Size = new Size(160, 22);
      this.DERExcelExportToolStripMenuItem.Text = "DER Excel Export";
      this.TERExcelExportToolStripMenuItem.Image = (Image) SAP2012.My.Resources.Resources.xls_open_file_format;
      this.TERExcelExportToolStripMenuItem.Name = "TERExcelExportToolStripMenuItem";
      this.TERExcelExportToolStripMenuItem.Size = new Size(160, 22);
      this.TERExcelExportToolStripMenuItem.Text = "TER Excel Export";
      this.cmdexcel.BackColor = Color.LightSlateGray;
      this.cmdexcel.Cursor = Cursors.Hand;
      this.cmdexcel.FlatStyle = FlatStyle.Popup;
      this.cmdexcel.ForeColor = Color.White;
      this.cmdexcel.Location = new Point(12, 663);
      this.cmdexcel.Name = "cmdexcel";
      this.cmdexcel.Size = new Size(190, 23);
      this.cmdexcel.TabIndex = 9;
      this.cmdexcel.Tag = (object) "";
      this.cmdexcel.Text = "TER Export to Excel";
      this.ToolTip1.SetToolTip((Control) this.cmdexcel, "Right click to see more options to create different reports.");
      this.cmdexcel.UseVisualStyleBackColor = false;
      this.TabPage4.Controls.Add((Control) this.GDTER);
      this.TabPage4.Location = new Point(4, 23);
      this.TabPage4.Name = "TabPage4";
      this.TabPage4.Size = new Size(1234, 619);
      this.TabPage4.TabIndex = 3;
      this.TabPage4.Text = "TER";
      this.TabPage4.UseVisualStyleBackColor = true;
      this.GDTER.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.GDTER.Dock = DockStyle.Fill;
      this.GDTER.Location = new Point(0, 0);
      this.GDTER.Name = "GDTER";
      this.GDTER.Size = new Size(1234, 619);
      this.GDTER.TabIndex = 1;
      this.Button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      this.Button2.BackColor = Color.LightSlateGray;
      this.Button2.Cursor = Cursors.Hand;
      this.Button2.DialogResult = DialogResult.OK;
      this.Button2.FlatStyle = FlatStyle.Popup;
      this.Button2.ForeColor = Color.White;
      this.Button2.Location = new Point(1048, 663);
      this.Button2.Name = "Button2";
      this.Button2.Size = new Size(190, 23);
      this.Button2.TabIndex = 8;
      this.Button2.Text = "Exit";
      this.Button2.UseVisualStyleBackColor = false;
      this.TabControl1.Controls.Add((Control) this.TabPage3);
      this.TabControl1.Controls.Add((Control) this.TabPage4);
      this.TabControl1.Dock = DockStyle.Top;
      this.TabControl1.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.TabControl1.Location = new Point(0, 0);
      this.TabControl1.Name = "TabControl1";
      this.TabControl1.SelectedIndex = 0;
      this.TabControl1.Size = new Size(1242, 646);
      this.TabControl1.TabIndex = 3;
      this.TabPage3.Controls.Add((Control) this.GDDER);
      this.TabPage3.Location = new Point(4, 23);
      this.TabPage3.Name = "TabPage3";
      this.TabPage3.Size = new Size(1234, 619);
      this.TabPage3.TabIndex = 2;
      this.TabPage3.Text = "DER";
      this.TabPage3.UseVisualStyleBackColor = true;
      this.GDDER.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.GDDER.Dock = DockStyle.Fill;
      this.GDDER.Location = new Point(0, 0);
      this.GDDER.Name = "GDDER";
      this.GDDER.Size = new Size(1234, 619);
      this.GDDER.TabIndex = 0;
      this.Button1.BackColor = Color.LightSlateGray;
      this.Button1.ContextMenuStrip = this.CmExport;
      this.Button1.Cursor = Cursors.Hand;
      this.Button1.FlatStyle = FlatStyle.Popup;
      this.Button1.ForeColor = Color.White;
      this.Button1.Location = new Point(222, 663);
      this.Button1.Name = "Button1";
      this.Button1.Size = new Size(190, 23);
      this.Button1.TabIndex = 10;
      this.Button1.Tag = (object) "";
      this.Button1.Text = "DER Export to Excel";
      this.ToolTip1.SetToolTip((Control) this.Button1, "Right click to see more options to create different reports.");
      this.Button1.UseVisualStyleBackColor = false;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1242, 698);
      this.Controls.Add((Control) this.Button1);
      this.Controls.Add((Control) this.cmdexcel);
      this.Controls.Add((Control) this.Button2);
      this.Controls.Add((Control) this.TabControl1);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (DER_TER_Results);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "DER  & TER Key Results";
      this.CmExport.ResumeLayout(false);
      this.TabPage4.ResumeLayout(false);
      ((ISupportInitialize) this.GDTER).EndInit();
      this.TabControl1.ResumeLayout(false);
      this.TabPage3.ResumeLayout(false);
      ((ISupportInitialize) this.GDDER).EndInit();
      this.ResumeLayout(false);
    }

    [field: AccessedThroughProperty("CmExport")]
    internal virtual ContextMenuStrip CmExport { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripMenuItem DERExcelExportToolStripMenuItem
    {
      get => this._DERExcelExportToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DERExcelExportToolStripMenuItem_Click);
        ToolStripMenuItem toolStripMenuItem1 = this._DERExcelExportToolStripMenuItem;
        if (toolStripMenuItem1 != null)
          toolStripMenuItem1.Click -= eventHandler;
        this._DERExcelExportToolStripMenuItem = value;
        ToolStripMenuItem toolStripMenuItem2 = this._DERExcelExportToolStripMenuItem;
        if (toolStripMenuItem2 == null)
          return;
        toolStripMenuItem2.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem TERExcelExportToolStripMenuItem
    {
      get => this._TERExcelExportToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.TERExcelExportToolStripMenuItem_Click);
        ToolStripMenuItem toolStripMenuItem1 = this._TERExcelExportToolStripMenuItem;
        if (toolStripMenuItem1 != null)
          toolStripMenuItem1.Click -= eventHandler;
        this._TERExcelExportToolStripMenuItem = value;
        ToolStripMenuItem toolStripMenuItem2 = this._TERExcelExportToolStripMenuItem;
        if (toolStripMenuItem2 == null)
          return;
        toolStripMenuItem2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("ToolTip1")]
    internal virtual ToolTip ToolTip1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("TabPage4")]
    internal virtual TabPage TabPage4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GDTER")]
    internal virtual DataGridView GDTER { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("TabControl1")]
    internal virtual TabControl TabControl1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("TabPage3")]
    internal virtual TabPage TabPage3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GDDER")]
    internal virtual DataGridView GDDER { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

    internal virtual Button cmdexcel
    {
      get => this._cmdexcel;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdexcel_Click);
        Button cmdexcel1 = this._cmdexcel;
        if (cmdexcel1 != null)
          cmdexcel1.Click -= eventHandler;
        this._cmdexcel = value;
        Button cmdexcel2 = this._cmdexcel;
        if (cmdexcel2 == null)
          return;
        cmdexcel2.Click += eventHandler;
      }
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

    public void CreateCSVFile(StreamWriter sw, DataTable dt, string strFilePath)
    {
      int count = dt.Columns.Count;
      int num1 = checked (count - 1);
      int index = 0;
      while (index <= num1)
      {
        sw.Write((object) dt.Columns[index]);
        if (index < checked (count - 1))
          sw.Write(",");
        checked { ++index; }
      }
      sw.Write(sw.NewLine);
      try
      {
        foreach (DataRow row in dt.Rows)
        {
          int num2 = checked (count - 1);
          int columnIndex = 0;
          while (columnIndex <= num2)
          {
            if (!Convert.IsDBNull(RuntimeHelpers.GetObjectValue(row[columnIndex])))
            {
              string str = row[columnIndex].ToString().Replace(",", "").Replace("\n", " ").Replace("\r", " ");
              sw.Write(str);
            }
            else
              sw.Write("");
            if (columnIndex < checked (count - 1))
              sw.Write(",");
            checked { ++columnIndex; }
          }
          sw.Write(sw.NewLine);
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }

    private void ExportData(DataTable Type)
    {
      try
      {
        object folderPath = (object) Environment.GetFolderPath(Environment.SpecialFolder.Personal);
        if (!Directory.Exists(Conversions.ToString(folderPath)))
          Directory.CreateDirectory(Conversions.ToString(folderPath));
        DirectoryInfo directoryInfo1 = new DirectoryInfo(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(folderPath, (object) "\\Stroma SAP")));
        if (!directoryInfo1.Exists)
          directoryInfo1.Create();
        DirectoryInfo directoryInfo2 = new DirectoryInfo(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(folderPath, (object) "\\Stroma SAP\\"), (object) SAP_Module.Proj.Name)));
        if (!directoryInfo2.Exists)
          directoryInfo2.Create();
        object Left1 = Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(folderPath, (object) "\\Stroma SAP\\"), (object) SAP_Module.Proj.Name), (object) "\\Key Results-");
        DateTime now = DateAndTime.Now;
        string Right1 = now.Year.ToString();
        object Left2 = Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Left1, (object) Right1);
        now = DateAndTime.Now;
        string Right2 = now.Month.ToString();
        object Left3 = Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Left2, (object) Right2);
        now = DateAndTime.Now;
        int num = now.Day;
        string Right3 = num.ToString();
        object Left4 = Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Left3, (object) Right3);
        now = DateAndTime.Now;
        num = now.Hour;
        string Right4 = num.ToString();
        object Left5 = Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Left4, (object) Right4);
        now = DateAndTime.Now;
        num = now.Minute;
        string Right5 = num.ToString();
        object Left6 = Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Left5, (object) Right5);
        now = DateAndTime.Now;
        num = now.Second;
        string Right6 = num.ToString();
        string str = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Left6, (object) Right6), (object) ".csv"));
        StreamWriter sw = new StreamWriter(str, false);
        this.CreateCSVFile(sw, Type, str);
        sw.Close();
        Process.Start(str);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) ex.Message);
        ProjectData.ClearProjectError();
      }
    }

    private void DERExcelExportToolStripMenuItem_Click(object sender, EventArgs e) => this.ExportData(this.DERDatatable);

    private void TERExcelExportToolStripMenuItem_Click(object sender, EventArgs e) => this.ExportData(this.TERDatatable);

    private void DER_TER_Results_Load(object sender, EventArgs e)
    {
      this.DERDatatable = new DataTable();
      this.DERDatatable = this.CreateDERTableColumns();
      this.TERDatatable = new DataTable();
      this.TERDatatable = this.CreateTERTableColumns();
      int num1 = checked (SAP_Module.Proj.NoOfDwells - 1);
      int House1 = 0;
      while (House1 <= num1)
      {
        SAP_Module.CurrDwelling = House1;
        if (Validation.LodgementStatusCheck(House1))
        {
          Calc2012 calc2012 = new Calc2012();
          calc2012.SETPCDF(SAP_Module.PCDFData);
          calc2012.Dwelling = SAP_Module.Proj.Dwellings[House1];
          SAP_Module.Proj.NoOfDwells = SAP_Module.Proj.NoOfDwells;
          XML2012 xmL2012 = new XML2012();
          SAP_Module.Calculation2012 = calc2012;
          Functions.CalculateNow();
          DataRow row = this.DERDatatable.NewRow();
          row["ID"] = (object) House1;
          row["Name"] = (object) SAP_Module.Proj.Dwellings[House1].Name;
          row["Reference"] = (object) SAP_Module.Proj.Dwellings[House1].Reference;
          int num2 = checked (SAP_Module.Proj.Dwellings[House1].Storeys - 1);
          int index = 0;
          while (index <= num2)
          {
            if (index < 7)
            {
              row["Box 1 " + Conversions.ToString(Strings.Chr(checked (97 + index)))] = (object) Math.Round((double) SAP_Module.Proj.Dwellings[House1].Dims[index].Area);
              row["Box 2 " + Conversions.ToString(Strings.Chr(checked (97 + index)))] = (object) Math.Round((double) SAP_Module.Proj.Dwellings[House1].Dims[index].Height, 2);
              row["Box 3 " + Conversions.ToString(Strings.Chr(checked (97 + index)))] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Dimensions.Dims[index].Volume);
            }
            checked { ++index; }
          }
          row["Box 4"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Dimensions.Box4, 2);
          row["Box 5"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Dimensions.Box5, 2);
          row["Box 301"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Dimensions.Box4, 2);
          row["Box 302"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Dimensions.Box5, 2);
          row["Box 301"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9b.Box301, 2);
          row["Box 302"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9b.Box301, 2);
          row["Box 303 a"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9b.Box303a, 2);
          row["Box 303 b"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9b.Box303b, 2);
          row["Box 303 c"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9b.Box303c, 2);
          row["Box 303 d"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9b.Box303d, 2);
          row["Box 303 e"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9b.Box303e, 2);
          row["Box 304 a"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9b.Box304a, 2);
          row["Box 304 b"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9b.Box304b, 2);
          row["Box 304 c"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9b.Box304c, 2);
          row["Box 304 d"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9b.Box304d, 2);
          row["304 304 e"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9b.Box304e, 2);
          row["Box 305"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9b.Box305, 2);
          row["Box 306"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9b.Box306, 2);
          row["Box 307 a"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9b.Box307a, 2);
          row["Box 307 b"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9b.Box307b, 2);
          row["Box 307 c"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9b.Box307c, 2);
          row["Box 307 d"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9b.Box307d, 2);
          row["Box 307 e"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9b.Box307e, 2);
          row["Box 308"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9b.Box308, 2);
          row["Box 309"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9b.Box309, 2);
          row["Box 310 a"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9b.Box310a, 2);
          row["Box 310 b"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9b.Box310b, 2);
          row["Box 310 c"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9b.Box310c, 2);
          row["Box 310 d"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9b.Box310d, 2);
          row["Box 310  e"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9b.Box310e, 2);
          row["Box 313"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9b.Box313, 2);
          row["Box 314"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9b.Box314, 2);
          row["Box 315"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9b.Box315, 2);
          row["Box 330 a"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9b.Box330a, 2);
          row["Box 330 b"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9b.Box330b, 2);
          row["Box 330  g"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9b.Box330g, 2);
          row["Box 331"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9b.Box331, 2);
          row["Box 332"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9b.Box332, 2);
          row["Box 367 a"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.CO2_Emissions_12b.Box367a, 2);
          row["Box 367 b"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.CO2_Emissions_12b.Box367b, 2);
          row["Box 367 c"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.CO2_Emissions_12b.Box367c, 2);
          row["Box 367 d"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.CO2_Emissions_12b.Box367d, 2);
          row["Box 367 e"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.CO2_Emissions_12b.Box367e, 2);
          row["Box 367"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.CO2_Emissions_12b.Box367, 2);
          row["Box 368"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.CO2_Emissions_12b.Box368, 2);
          row["Box 369"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.CO2_Emissions_12b.Box369, 2);
          row["Box 370"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.CO2_Emissions_12b.Box370, 2);
          row["Box 371"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.CO2_Emissions_12b.Box371, 2);
          row["Box 372"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.CO2_Emissions_12b.Box372, 2);
          row["Box 373"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.CO2_Emissions_12b.Box373, 2);
          row["Box 374"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.CO2_Emissions_12b.Box374, 2);
          row["Box 375"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.CO2_Emissions_12b.Box375, 2);
          row["Box 376"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.CO2_Emissions_12b.Box376, 2);
          row["Box 378"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.CO2_Emissions_12b.Box378, 2);
          row["Box 383"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.CO2_Emissions_12b.Box383, 2);
          row["Box 384"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.CO2_Emissions_12b.Box384, 2);
          row["Box 385"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.CO2_Emissions_12b.Box385, 2);
          row["Box 201"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9a.Box201, 2);
          row["Box 202"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9a.Box202, 2);
          row["Box 203"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9a.Box203, 2);
          row["Box 204"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9a.Box204, 2);
          row["Box 205"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9a.Box205, 2);
          row["Box 206"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9a.Box206, 2);
          row["Box 207"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9a.Box207, 2);
          row["Box 208"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9a.Box208, 2);
          row["Box 209"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9a.Box209, 2);
          row["Box 210"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9a.Box210_m.M1, 2);
          row["Box 211"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9a.Box211, 2);
          row["Box 212"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9a.Box212_m.M1, 2);
          row["Box 213"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9a.Box213, 2);
          row["Box 215"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9a.Box215, 2);
          row["Box 216"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9a.Box216, 2);
          row["Box 219"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9a.Box219, 2);
          row["Box 221"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9a.Box221, 2);
          row["Box 230 a"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9a.Box230a, 2);
          row["Box 230 b"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9a.Box230b, 2);
          row["Box 230 c"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9a.Box230c, 2);
          row["Box 230 d"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9a.Box230d, 2);
          row["Box 230 e"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9a.Box230e, 2);
          row["Box 231"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9a.Box231, 2);
          row["Box 232 a"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9a.Box232a, 2);
          row["Box 232 b"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9a.Box232b, 2);
          row["Box 232 c"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9a.Box232c, 2);
          row["Box 232 e"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9a.Box232e, 2);
          row["Box 233"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9a.Box233, 2);
          row["Box 234"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9a.Box234, 2);
          row["Box 235"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.Energy_Requirements_9a.Box235, 2);
          row["Box 261"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.CO2_Emissions_12a.Box261, 2);
          row["Box 262"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.CO2_Emissions_12a.Box262, 2);
          row["Box 263"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.CO2_Emissions_12a.Box263, 2);
          row["Box 264"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.CO2_Emissions_12a.Box264, 2);
          row["Box 265"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.CO2_Emissions_12a.Box265, 2);
          row["Box 265"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.CO2_Emissions_12a.Box265, 2);
          row["Box 267"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.CO2_Emissions_12a.Box267, 2);
          row["Box 268"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.CO2_Emissions_12a.Box268, 2);
          row["Box 269"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.CO2_Emissions_12a.Box269, 2);
          row["Box 272"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.CO2_Emissions_12a.Box272, 2);
          row["Box 273"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.CO2_Emissions_12a.Box273, 2);
          row["Box 274"] = (object) Math.Round(SAP_Module.CalcualtionDER2012.Calculation.CO2_Emissions_12a.Box274, 2);
          this.DERDatatable.Rows.Add(row);
        }
        checked { ++House1; }
      }
      this.GDDER.DataSource = (object) this.DERDatatable;
      int num3 = checked (SAP_Module.Proj.NoOfDwells - 1);
      int House2 = 0;
      while (House2 <= num3)
      {
        SAP_Module.CurrDwelling = House2;
        if (Validation.LodgementStatusCheck(House2))
        {
          Calc2012 calc2012 = new Calc2012();
          calc2012.SETPCDF(SAP_Module.PCDFData);
          calc2012.Dwelling = SAP_Module.Proj.Dwellings[House2];
          SAP_Module.Proj.NoOfDwells = SAP_Module.Proj.NoOfDwells;
          XML2012 xmL2012 = new XML2012();
          SAP_Module.Calculation2012 = calc2012;
          Functions.CalculateNow();
          DataRow row = this.TERDatatable.NewRow();
          row["ID"] = (object) House2;
          row["Name"] = (object) SAP_Module.Proj.Dwellings[House2].Name;
          row["Reference"] = (object) SAP_Module.Proj.Dwellings[House2].Reference;
          int num4 = checked (SAP_Module.Proj.Dwellings[House2].Storeys - 1);
          int index = 0;
          while (index <= num4)
          {
            if (index < 7)
            {
              row["Box 1 " + Conversions.ToString(Strings.Chr(checked (97 + index)))] = (object) Math.Round((double) SAP_Module.Proj.Dwellings[House2].Dims[index].Area);
              row["Box 2 " + Conversions.ToString(Strings.Chr(checked (97 + index)))] = (object) Math.Round((double) SAP_Module.Proj.Dwellings[House2].Dims[index].Height, 2);
              row["Box 3 " + Conversions.ToString(Strings.Chr(checked (97 + index)))] = (object) Math.Round(SAP_Module.CalcualtionTER2012.Calculation.Dimensions.Dims[index].Volume);
            }
            checked { ++index; }
          }
          row["Box 4"] = (object) Math.Round(SAP_Module.CalcualtionTER2012.Calculation.Dimensions.Box4, 2);
          row["Box 5"] = (object) Math.Round(SAP_Module.CalcualtionTER2012.Calculation.Dimensions.Box5, 2);
          row["Box 261"] = (object) Math.Round(SAP_Module.CalcualtionTER2012.Calculation.CO2_Emissions_12a.Box261, 2);
          row["Box 262"] = (object) Math.Round(SAP_Module.CalcualtionTER2012.Calculation.CO2_Emissions_12a.Box262, 2);
          row["Box 263"] = (object) Math.Round(SAP_Module.CalcualtionTER2012.Calculation.CO2_Emissions_12a.Box263, 2);
          row["Box 264"] = (object) Math.Round(SAP_Module.CalcualtionTER2012.Calculation.CO2_Emissions_12a.Box264, 2);
          row["Box 265"] = (object) Math.Round(SAP_Module.CalcualtionTER2012.Calculation.CO2_Emissions_12a.Box265, 2);
          row["Box 267"] = (object) Math.Round(SAP_Module.CalcualtionTER2012.Calculation.CO2_Emissions_12a.Box267, 2);
          row["Box 268"] = (object) Math.Round(SAP_Module.CalcualtionTER2012.Calculation.CO2_Emissions_12a.Box268, 2);
          row["Box 272"] = (object) Math.Round(SAP_Module.CalcualtionTER2012.Calculation.CO2_Emissions_12a.Box272, 2);
          row["Box 273"] = (object) Math.Round(SAP_Module.CalcualtionTER2012.Calculation.CO2_Emissions_12a.Box273, 2);
          this.TERDatatable.Rows.Add(row);
        }
        checked { ++House2; }
      }
      this.GDTER.DataSource = (object) this.TERDatatable;
    }

    public string CreateXML(object YourClassObject)
    {
      Box2012 o = new Box2012();
      StringWriter w = new StringWriter();
      new XmlSerializer(typeof (Box2012)).Serialize((XmlWriter) new XmlTextWriter((TextWriter) w), (object) o);
      Console.WriteLine(w.ToString());
      string xml;
      return xml;
    }

    private DataTable CreateDERTableColumns() => new DataTable()
    {
      Columns = {
        "ID",
        "Name",
        "Reference",
        "Box 1 a",
        "Box 1 b",
        "Box 1 c",
        "Box 1 d",
        "Box 1 e",
        "Box 1 f",
        "Box 1 g",
        "Box 2 a",
        "Box 2 b",
        "Box 2 c",
        "Box 2 d",
        "Box 2 e",
        "Box 2 f",
        "Box 2 g",
        "Box 3 a",
        "Box 3 b",
        "Box 3 c",
        "Box 3 d",
        "Box 3 e",
        "Box 3 f",
        "Box 3 g",
        "Box 4",
        "Box 5",
        "Box 301",
        "Box 302",
        "Box 303 a",
        "Box 303 b",
        "Box 303 c",
        "Box 303 d",
        "Box 303 e",
        "Box 304 a",
        "Box 304 b",
        "Box 304 c",
        "Box 304 d",
        "304 304 e",
        "Box 305",
        "Box 306",
        "Box 307 a",
        "Box 307 b",
        "Box 307 c",
        "Box 307 d",
        "Box 307 e",
        "Box 308",
        "Box 309",
        "Box 310 a",
        "Box 310 b",
        "Box 310 c",
        "Box 310 d",
        "Box 310  e",
        "Box 313",
        "Box 314",
        "Box 315",
        "Box 330 a",
        "Box 330 b",
        "Box 330  g",
        "Box 331",
        "Box 332",
        "Box 367 a",
        "Box 367 b",
        "Box 367 c",
        "Box 367 d",
        "Box 367 e",
        "Box 367",
        "Box 368",
        "Box 369",
        "Box 370",
        "Box 371",
        "Box 372",
        "Box 373",
        "Box 374",
        "Box 375",
        "Box 376",
        "Box 378",
        "Box 383",
        "Box 384",
        "Box 385",
        "Box 201",
        "Box 202",
        "Box 203",
        "Box 204",
        "Box 205",
        "Box 206",
        "Box 207",
        "Box 208",
        "Box 209",
        "Box 210",
        "Box 211",
        "Box 212",
        "Box 213",
        "Box 215",
        "Box 216",
        "Box 219",
        "Box 221",
        "Box 230 a",
        "Box 230 b",
        "Box 230 c",
        "Box 230 d",
        "Box 230 e",
        "Box 231",
        "Box 232 a",
        "Box 232 b",
        "Box 232 c",
        "Box 232 e",
        "Box 233",
        "Box 234",
        "Box 235",
        "Box 261",
        "Box 262",
        "Box 263",
        "Box 264",
        "Box 265",
        "Box 267",
        "Box 268",
        "Box 269",
        "Box 272",
        "Box 273",
        "Box 274"
      }
    };

    private DataTable CreateTERTableColumns() => new DataTable()
    {
      Columns = {
        "ID",
        "Name",
        "Reference",
        "Box 1 a",
        "Box 1 b",
        "Box 1 c",
        "Box 1 d",
        "Box 1 e",
        "Box 1 f",
        "Box 1 g",
        "Box 2 a",
        "Box 2 b",
        "Box 2 c",
        "Box 2 d",
        "Box 2 e",
        "Box 2 f",
        "Box 2 g",
        "Box 3 a",
        "Box 3 b",
        "Box 3 c",
        "Box 3 d",
        "Box 3 e",
        "Box 3 f",
        "Box 3 g",
        "Box 4",
        "Box 5",
        "Box 261",
        "Box 262",
        "Box 263",
        "Box 264",
        "Box 265",
        "Box 267",
        "Box 268",
        "Box 272",
        "Box 273"
      }
    };

    private void Button2_Click(object sender, EventArgs e) => this.Close();

    private void Button1_Click(object sender, EventArgs e) => this.ExportData(this.DERDatatable);

    private void cmdexcel_Click(object sender, EventArgs e) => this.ExportData(this.TERDatatable);
  }
}
