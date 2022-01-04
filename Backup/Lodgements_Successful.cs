
// Type: SAP2012.Lodgements_Successful




using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using SAP2012.SAPRef;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SAP2012
{
  [DesignerGenerated]
  public class Lodgements_Successful : Form
  {
    private IContainer components;
    private DataTable SLodgements;
    private DataView SLodgeView;

    public Lodgements_Successful()
    {
      this.Load += new EventHandler(this.Lodgements_Successful_Load);
      this.SLodgements = new DataTable();
      this.SLodgeView = new DataView();
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
      DataGridViewCellStyle gridViewCellStyle = new DataGridViewCellStyle();
      this.SplitContainer1 = new SplitContainer();
      this.Button6 = new Button();
      this.chkOpenDIR = new CheckBox();
      this.grpError = new GroupBox();
      this.txtError = new TextBox();
      this.GroupBox1 = new GroupBox();
      this.txtFilter = new TextBox();
      this.Label2 = new Label();
      this.PB1 = new ProgressBar();
      this.Button5 = new Button();
      this.Button4 = new Button();
      this.txtLocation = new TextBox();
      this.Label1 = new Label();
      this.Button3 = new Button();
      this.Button1 = new Button();
      this.Button2 = new Button();
      this.dgvLodgements = new BetterDataGrid();
      this.FBD1 = new FolderBrowserDialog();
      this.FolderBrowserDialog1 = new FolderBrowserDialog();
      this.SplitContainer1.Panel1.SuspendLayout();
      this.SplitContainer1.Panel2.SuspendLayout();
      this.SplitContainer1.SuspendLayout();
      this.grpError.SuspendLayout();
      this.GroupBox1.SuspendLayout();
      ((ISupportInitialize) this.dgvLodgements).BeginInit();
      this.SuspendLayout();
      this.SplitContainer1.Dock = DockStyle.Fill;
      this.SplitContainer1.FixedPanel = FixedPanel.Panel1;
      this.SplitContainer1.Location = new Point(0, 0);
      this.SplitContainer1.Name = "SplitContainer1";
      this.SplitContainer1.Panel1.Controls.Add((Control) this.Button6);
      this.SplitContainer1.Panel1.Controls.Add((Control) this.chkOpenDIR);
      this.SplitContainer1.Panel1.Controls.Add((Control) this.grpError);
      this.SplitContainer1.Panel1.Controls.Add((Control) this.GroupBox1);
      this.SplitContainer1.Panel1.Controls.Add((Control) this.PB1);
      this.SplitContainer1.Panel1.Controls.Add((Control) this.Button5);
      this.SplitContainer1.Panel1.Controls.Add((Control) this.Button4);
      this.SplitContainer1.Panel1.Controls.Add((Control) this.txtLocation);
      this.SplitContainer1.Panel1.Controls.Add((Control) this.Label1);
      this.SplitContainer1.Panel1.Controls.Add((Control) this.Button3);
      this.SplitContainer1.Panel1.Controls.Add((Control) this.Button1);
      this.SplitContainer1.Panel1.Controls.Add((Control) this.Button2);
      this.SplitContainer1.Panel2.Controls.Add((Control) this.dgvLodgements);
      this.SplitContainer1.Size = new Size(840, 674);
      this.SplitContainer1.SplitterDistance = 230;
      this.SplitContainer1.TabIndex = 1;
      this.Button6.BackColor = Color.LightSlateGray;
      this.Button6.Cursor = Cursors.Hand;
      this.Button6.FlatStyle = FlatStyle.Popup;
      this.Button6.Font = new Font("Tahoma", 8f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button6.ForeColor = Color.White;
      this.Button6.Location = new Point(5, 617);
      this.Button6.Name = "Button6";
      this.Button6.Size = new Size(104, 34);
      this.Button6.TabIndex = 33;
      this.Button6.Text = "Download All selected XML";
      this.Button6.UseVisualStyleBackColor = false;
      this.Button6.Visible = false;
      this.chkOpenDIR.AutoSize = true;
      this.chkOpenDIR.Checked = true;
      this.chkOpenDIR.CheckState = CheckState.Checked;
      this.chkOpenDIR.Location = new Point(15, 135);
      this.chkOpenDIR.Name = "chkOpenDIR";
      this.chkOpenDIR.Size = new Size(173, 17);
      this.chkOpenDIR.TabIndex = 32;
      this.chkOpenDIR.Text = "Open directory when complete";
      this.chkOpenDIR.UseVisualStyleBackColor = true;
      this.grpError.Controls.Add((Control) this.txtError);
      this.grpError.Location = new Point(14, 264);
      this.grpError.Name = "grpError";
      this.grpError.Size = new Size(207, 347);
      this.grpError.TabIndex = 31;
      this.grpError.TabStop = false;
      this.grpError.Text = "Errors";
      this.grpError.Visible = false;
      this.txtError.Dock = DockStyle.Fill;
      this.txtError.Location = new Point(3, 17);
      this.txtError.Multiline = true;
      this.txtError.Name = "txtError";
      this.txtError.ScrollBars = ScrollBars.Vertical;
      this.txtError.Size = new Size(201, 327);
      this.txtError.TabIndex = 28;
      this.GroupBox1.Controls.Add((Control) this.txtFilter);
      this.GroupBox1.Controls.Add((Control) this.Label2);
      this.GroupBox1.Location = new Point(14, 187);
      this.GroupBox1.Name = "GroupBox1";
      this.GroupBox1.Size = new Size(207, 71);
      this.GroupBox1.TabIndex = 30;
      this.GroupBox1.TabStop = false;
      this.GroupBox1.Text = "Filter";
      this.txtFilter.Location = new Point(5, 33);
      this.txtFilter.Name = "txtFilter";
      this.txtFilter.Size = new Size(196, 21);
      this.txtFilter.TabIndex = 28;
      this.Label2.AutoSize = true;
      this.Label2.Location = new Point(6, 17);
      this.Label2.Name = "Label2";
      this.Label2.Size = new Size(108, 13);
      this.Label2.TabIndex = 27;
      this.Label2.Text = "Enter Dwelling Name ";
      this.PB1.Location = new Point(14, 158);
      this.PB1.Name = "PB1";
      this.PB1.Size = new Size(207, 23);
      this.PB1.TabIndex = 29;
      this.PB1.Visible = false;
      this.Button5.BackColor = Color.LightSlateGray;
      this.Button5.Cursor = Cursors.Hand;
      this.Button5.FlatStyle = FlatStyle.Popup;
      this.Button5.Font = new Font("Tahoma", 8f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button5.ForeColor = Color.White;
      this.Button5.Location = new Point(15, 90);
      this.Button5.Name = "Button5";
      this.Button5.Size = new Size(206, 28);
      this.Button5.TabIndex = 28;
      this.Button5.Text = "Download All selected EPCs";
      this.Button5.UseVisualStyleBackColor = false;
      this.Button4.BackColor = Color.LightSlateGray;
      this.Button4.Cursor = Cursors.Hand;
      this.Button4.FlatStyle = FlatStyle.Popup;
      this.Button4.Font = new Font("Tahoma", 8f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button4.ForeColor = Color.White;
      this.Button4.Location = new Point(194, 60);
      this.Button4.Name = "Button4";
      this.Button4.Size = new Size(27, 21);
      this.Button4.TabIndex = 27;
      this.Button4.Text = "...";
      this.Button4.UseVisualStyleBackColor = false;
      this.txtLocation.Location = new Point(15, 60);
      this.txtLocation.Name = "txtLocation";
      this.txtLocation.ReadOnly = true;
      this.txtLocation.Size = new Size(173, 21);
      this.txtLocation.TabIndex = 26;
      this.Label1.AutoSize = true;
      this.Label1.Location = new Point(16, 44);
      this.Label1.Name = "Label1";
      this.Label1.Size = new Size(74, 13);
      this.Label1.TabIndex = 25;
      this.Label1.Text = "Save Location";
      this.Button3.BackColor = Color.LightSlateGray;
      this.Button3.Cursor = Cursors.Hand;
      this.Button3.FlatStyle = FlatStyle.Popup;
      this.Button3.Font = new Font("Tahoma", 8f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button3.ForeColor = Color.White;
      this.Button3.Location = new Point(102, 12);
      this.Button3.Name = "Button3";
      this.Button3.Size = new Size(86, 26);
      this.Button3.TabIndex = 24;
      this.Button3.Text = "Select None";
      this.Button3.UseVisualStyleBackColor = false;
      this.Button1.BackColor = Color.LightSlateGray;
      this.Button1.Cursor = Cursors.Hand;
      this.Button1.FlatStyle = FlatStyle.Popup;
      this.Button1.Font = new Font("Tahoma", 8f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button1.ForeColor = Color.White;
      this.Button1.Location = new Point(15, 12);
      this.Button1.Name = "Button1";
      this.Button1.Size = new Size(81, 26);
      this.Button1.TabIndex = 23;
      this.Button1.Text = "Select All";
      this.Button1.UseVisualStyleBackColor = false;
      this.Button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      this.Button2.BackColor = Color.LightSlateGray;
      this.Button2.Cursor = Cursors.Hand;
      this.Button2.DialogResult = DialogResult.Cancel;
      this.Button2.FlatStyle = FlatStyle.Popup;
      this.Button2.Font = new Font("Tahoma", 8f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button2.ForeColor = Color.White;
      this.Button2.Location = new Point(111, 619);
      this.Button2.Name = "Button2";
      this.Button2.Size = new Size(104, 32);
      this.Button2.TabIndex = 22;
      this.Button2.Text = "Close";
      this.Button2.UseVisualStyleBackColor = false;
      this.dgvLodgements.AllowUserToAddRows = false;
      this.dgvLodgements.AllowUserToDeleteRows = false;
      this.dgvLodgements.AllowUserToResizeRows = false;
      gridViewCellStyle.BackColor = Color.Honeydew;
      this.dgvLodgements.AlternatingRowsDefaultCellStyle = gridViewCellStyle;
      this.dgvLodgements.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvLodgements.Cursor = Cursors.Hand;
      this.dgvLodgements.Dock = DockStyle.Fill;
      this.dgvLodgements.Location = new Point(0, 0);
      this.dgvLodgements.Name = "dgvLodgements";
      this.dgvLodgements.ReadOnly = true;
      this.dgvLodgements.RowHeadersWidth = 15;
      this.dgvLodgements.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dgvLodgements.Size = new Size(606, 674);
      this.dgvLodgements.TabIndex = 0;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.White;
      this.ClientSize = new Size(840, 674);
      this.Controls.Add((Control) this.SplitContainer1);
      this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.Name = nameof (Lodgements_Successful);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Successful Lodgements";
      this.SplitContainer1.Panel1.ResumeLayout(false);
      this.SplitContainer1.Panel1.PerformLayout();
      this.SplitContainer1.Panel2.ResumeLayout(false);
      this.SplitContainer1.ResumeLayout(false);
      this.grpError.ResumeLayout(false);
      this.grpError.PerformLayout();
      this.GroupBox1.ResumeLayout(false);
      this.GroupBox1.PerformLayout();
      ((ISupportInitialize) this.dgvLodgements).EndInit();
      this.ResumeLayout(false);
    }

    [field: AccessedThroughProperty("SplitContainer1")]
    internal virtual SplitContainer SplitContainer1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

    [field: AccessedThroughProperty("Button2")]
    internal virtual Button Button2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("dgvLodgements")]
    internal virtual BetterDataGrid dgvLodgements { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button3
    {
      get => this._Button3;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button3_Click);
        Button button3_1 = this._Button3;
        if (button3_1 != null)
          button3_1.Click -= eventHandler;
        this._Button3 = value;
        Button button3_2 = this._Button3;
        if (button3_2 == null)
          return;
        button3_2.Click += eventHandler;
      }
    }

    internal virtual Button Button5
    {
      get => this._Button5;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button5_Click);
        Button button5_1 = this._Button5;
        if (button5_1 != null)
          button5_1.Click -= eventHandler;
        this._Button5 = value;
        Button button5_2 = this._Button5;
        if (button5_2 == null)
          return;
        button5_2.Click += eventHandler;
      }
    }

    internal virtual Button Button4
    {
      get => this._Button4;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button4_Click);
        Button button4_1 = this._Button4;
        if (button4_1 != null)
          button4_1.Click -= eventHandler;
        this._Button4 = value;
        Button button4_2 = this._Button4;
        if (button4_2 == null)
          return;
        button4_2.Click += eventHandler;
      }
    }

    internal virtual TextBox txtLocation
    {
      get => this._txtLocation;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtLocation_TextChanged);
        TextBox txtLocation1 = this._txtLocation;
        if (txtLocation1 != null)
          txtLocation1.TextChanged -= eventHandler;
        this._txtLocation = value;
        TextBox txtLocation2 = this._txtLocation;
        if (txtLocation2 == null)
          return;
        txtLocation2.TextChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Label1")]
    internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("FBD1")]
    internal virtual FolderBrowserDialog FBD1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("PB1")]
    internal virtual ProgressBar PB1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox1")]
    internal virtual GroupBox GroupBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox txtFilter
    {
      get => this._txtFilter;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtFilter_TextChanged);
        TextBox txtFilter1 = this._txtFilter;
        if (txtFilter1 != null)
          txtFilter1.TextChanged -= eventHandler;
        this._txtFilter = value;
        TextBox txtFilter2 = this._txtFilter;
        if (txtFilter2 == null)
          return;
        txtFilter2.TextChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Label2")]
    internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("grpError")]
    internal virtual GroupBox grpError { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtError")]
    internal virtual TextBox txtError { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chkOpenDIR")]
    internal virtual CheckBox chkOpenDIR { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button6
    {
      get => this._Button6;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button6_Click);
        Button button6_1 = this._Button6;
        if (button6_1 != null)
          button6_1.Click -= eventHandler;
        this._Button6 = value;
        Button button6_2 = this._Button6;
        if (button6_2 == null)
          return;
        button6_2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("FolderBrowserDialog1")]
    internal virtual FolderBrowserDialog FolderBrowserDialog1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private void Lodgements_Successful_Load(object sender, EventArgs e)
    {
      this.SLodgements.Columns.Add("Include", typeof (bool));
      this.SLodgements.Columns.Add("Dwelling");
      this.SLodgements.Columns.Add("Date Lodged", typeof (DateTime));
      this.SLodgements.Columns.Add("RRN");
      this.SLodgements.Columns.Add("SAP");
      this.SLodgements.Columns.Add("EI");
      this.SLodgements.Columns.Add("Country");
      this.SLodgements.TableName = "Lodgements";
      int num1 = checked (SAP_Module.Proj.NoOfDwells - 1);
      int index1 = 0;
      while (index1 <= num1)
      {
        int num2 = checked (SAP_Module.Proj.Dwellings[index1].LodgementAttempts - 1);
        int index2 = 0;
        while (index2 <= num2)
        {
          try
          {
            if (SAP_Module.Proj.Dwellings[index1].Lodgement[index2].Success)
            {
              DataRow row = this.SLodgements.NewRow();
              DataRow dataRow = row;
              dataRow["Include"] = (object) false;
              dataRow["Dwelling"] = (object) SAP_Module.Proj.Dwellings[index1].Name;
              dataRow["Date Lodged"] = (object) SAP_Module.Proj.Dwellings[index1].Lodgement[index2].DateLodged;
              dataRow["RRN"] = (object) SAP_Module.Proj.Dwellings[index1].Lodgement[index2].RRN;
              dataRow["SAP"] = (object) (SAP_Module.Proj.Dwellings[index1].Lodgement[index2].SAP.SAPBand + Conversions.ToString(SAP_Module.Proj.Dwellings[index1].Lodgement[index2].SAP.SAPRating));
              dataRow["EI"] = (object) (SAP_Module.Proj.Dwellings[index1].Lodgement[index2].SAP.EIBand + Conversions.ToString(SAP_Module.Proj.Dwellings[index1].Lodgement[index2].SAP.EIRating));
              dataRow["Country"] = (object) SAP_Module.Proj.Dwellings[index1].Address.Country;
              this.SLodgements.Rows.Add(row);
            }
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
          checked { ++index2; }
        }
        checked { ++index1; }
      }
      int num3 = checked (this.SLodgements.Rows.Count - 1);
      int index3 = 0;
      while (index3 <= num3)
      {
        this.SLodgements.Rows[index3]["Include"] = (object) true;
        checked { ++index3; }
      }
      this.SLodgeView.Table = this.SLodgements;
      this.dgvLodgements.DataSource = (object) this.SLodgeView;
      this.dgvLodgements.ReadOnly = false;
      this.dgvLodgements.Columns[1].ReadOnly = true;
      this.dgvLodgements.Columns[2].ReadOnly = true;
      this.dgvLodgements.Columns[3].ReadOnly = true;
      this.dgvLodgements.Columns[4].ReadOnly = true;
      this.dgvLodgements.Columns[5].ReadOnly = true;
      this.dgvLodgements.Columns[6].Visible = false;
    }

    private void Button4_Click(object sender, EventArgs e)
    {
      this.FBD1.ShowNewFolderButton = true;
      try
      {
        if (this.FBD1.ShowDialog() == DialogResult.Cancel)
          return;
        this.txtLocation.Text = this.FBD1.SelectedPath;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void Button5_Click(object sender, EventArgs e)
    {
      if (!Validation.UserLogged)
      {
        int num1 = (int) Interaction.MsgBox((object) "User not logged in. Please log in first in order to download EPC", MsgBoxStyle.Critical);
      }
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtLocation.Text, "", false) == 0)
      {
        int num2 = (int) Interaction.MsgBox((object) "Please select download location!", MsgBoxStyle.Information, (object) "Download location");
      }
      else
      {
        string Left = "";
        SAPSoapClient sapSoapClient = new SAPSoapClient();
        string srcFile = "";
        int num3 = checked (this.dgvLodgements.RowCount - 1);
        int rowIndex1 = 0;
        int num4;
        while (rowIndex1 <= num3)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.dgvLodgements[0, rowIndex1].Value, (object) true, false))
            checked { ++num4; }
          checked { ++rowIndex1; }
        }
        this.PB1.Maximum = num4;
        this.PB1.Visible = true;
        this.PB1.Value = 0;
        int num5 = checked (this.dgvLodgements.RowCount - 1);
        int rowIndex2 = 0;
        while (rowIndex2 <= num5)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.dgvLodgements[0, rowIndex2].Value, (object) true, false))
          {
            ProgressBar pb1;
            int num6 = checked ((pb1 = this.PB1).Value + 1);
            pb1.Value = num6;
            Application.DoEvents();
            string destFile = this.txtLocation.Text.EndsWith("\\") ? Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) this.txtLocation.Text, this.dgvLodgements[1, rowIndex2].Value), (object) " "), this.dgvLodgements[3, rowIndex2].Value), (object) ".pdf")) : Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) (this.txtLocation.Text + "\\"), this.dgvLodgements[1, rowIndex2].Value), (object) " "), this.dgvLodgements[3, rowIndex2].Value), (object) ".pdf"));
            try
            {
              Functions.Access_Details();
              CreatePDF createPdf = new CreatePDF();
              LodgedEPCtDetails lodgedEpCtDetails1 = new LodgedEPCtDetails();
              if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.dgvLodgements[6, rowIndex2].Value, (object) "Scotland", false))
              {
                try
                {
                  srcFile = sapSoapClient.DownLoad_lodgedEPC_In_Scotland(Validation.AssessorNO, Conversions.ToString(this.dgvLodgements[3, rowIndex2].Value), Functions.TransactionID, Functions.Encrypt);
                }
                catch (Exception ex)
                {
                  ProjectData.SetProjectError(ex);
                  ProjectData.ClearProjectError();
                }
                try
                {
                  PDFFunctions.DecodeFile(srcFile, destFile);
                }
                catch (Exception ex)
                {
                  ProjectData.SetProjectError(ex);
                  ProjectData.ClearProjectError();
                }
              }
              else
              {
                LodgedEPCtDetails lodgedEpCtDetails2 = sapSoapClient.DownLoadEngland_WalesEPC_byRRN(Conversions.ToString(this.dgvLodgements[3, rowIndex2].Value), Functions.TransactionID, Functions.Encrypt);
                if (lodgedEpCtDetails2.Downloaded)
                  lodgedEpCtDetails2.Filename = lodgedEpCtDetails2.Filename.Replace("E:\\live\\webservices\\www.stromamembers.co.uk\\", "https://www.stromamembers.co.uk/");
                if (lodgedEpCtDetails2.Downloaded)
                {
                  try
                  {
                    PDFFunctions.DecodeFile(PDFFunctions.EncodeByte(lodgedEpCtDetails2.EPCData), destFile);
                  }
                  catch (Exception ex)
                  {
                    ProjectData.SetProjectError(ex);
                    ProjectData.ClearProjectError();
                  }
                }
                else
                {
                  int num7 = (int) Interaction.MsgBox((object) "Error Downloading lodged EPC.", MsgBoxStyle.Critical, (object) "Stroma FSAP 2012 Lodged EPC Download");
                  return;
                }
              }
            }
            catch (Exception ex)
            {
              ProjectData.SetProjectError(ex);
              Left = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "", false) != 0 ? Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left, Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "\r\n", this.dgvLodgements[1, rowIndex2].Value), (object) ":"), (object) "\r\n"), this.dgvLodgements[3, rowIndex2].Value), (object) "\r\n"), (object) Information.Err().Description), (object) "\r\n"))) : Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(this.dgvLodgements[1, rowIndex2].Value, (object) ":"), (object) "\r\n"), this.dgvLodgements[3, rowIndex2].Value), (object) "\r\n"), (object) Information.Err().Description), (object) "\r\n"));
              ProjectData.ClearProjectError();
            }
          }
          checked { ++rowIndex2; }
        }
        if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "", false) > 0U)
        {
          this.grpError.Visible = true;
          this.txtError.Text = Left;
        }
        else
        {
          this.grpError.Visible = false;
          this.txtError.Text = "";
        }
        this.PB1.Visible = false;
        if (!this.chkOpenDIR.Checked)
          return;
        Process.Start("explorer.exe", this.txtLocation.Text);
      }
    }

    private void Button1_Click(object sender, EventArgs e)
    {
      int num = checked (this.dgvLodgements.Rows.Count - 1);
      int rowIndex = 0;
      while (rowIndex <= num)
      {
        this.dgvLodgements[0, rowIndex].Value = (object) true;
        checked { ++rowIndex; }
      }
    }

    private void Button3_Click(object sender, EventArgs e)
    {
      int num = checked (this.dgvLodgements.RowCount - 1);
      int rowIndex = 0;
      while (rowIndex <= num)
      {
        this.dgvLodgements[0, rowIndex].Value = (object) false;
        checked { ++rowIndex; }
      }
    }

    private void txtFilter_TextChanged(object sender, EventArgs e)
    {
      try
      {
        this.SLodgeView.RowFilter = "Dwelling like '%" + this.txtFilter.Text + "%'";
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void Button6_Click(object sender, EventArgs e)
    {
      if (!Validation.UserLogged)
      {
        int num1 = (int) Interaction.MsgBox((object) "User not logged in. Please log in first in order to download XML", MsgBoxStyle.Critical);
      }
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtLocation.Text, "", false) == 0)
      {
        int num2 = (int) Interaction.MsgBox((object) "Please select download location!", MsgBoxStyle.Information, (object) "Download location");
      }
      else
      {
        string Left = "";
        int num3 = checked (this.dgvLodgements.RowCount - 1);
        int rowIndex1 = 0;
        int num4;
        while (rowIndex1 <= num3)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.dgvLodgements[0, rowIndex1].Value, (object) true, false))
            checked { ++num4; }
          checked { ++rowIndex1; }
        }
        this.PB1.Maximum = num4;
        this.PB1.Visible = true;
        this.PB1.Value = 0;
        int num5 = checked (this.dgvLodgements.RowCount - 1);
        int rowIndex2 = 0;
        while (rowIndex2 <= num5)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.dgvLodgements[0, rowIndex2].Value, (object) true, false))
          {
            ProgressBar pb1;
            int num6 = checked ((pb1 = this.PB1).Value + 1);
            pb1.Value = num6;
            Application.DoEvents();
            string destFile = this.txtLocation.Text.EndsWith("\\") ? Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) this.txtLocation.Text, this.dgvLodgements[1, rowIndex2].Value), (object) " "), this.dgvLodgements[3, rowIndex2].Value), (object) ".xml")) : Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) (this.txtLocation.Text + "\\"), this.dgvLodgements[1, rowIndex2].Value), (object) " "), this.dgvLodgements[3, rowIndex2].Value), (object) ".xml"));
            Functions.Access_Details();
            CreatePDF createPdf = new CreatePDF();
            LodgedEPCtDetails lodgedEpCtDetails = new LodgedEPCtDetails();
            Calc2012 calc2012 = new Calc2012();
            calc2012.SETPCDF(SAP_Module.PCDFData);
            calc2012.Dwelling = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling];
            XML2012 xmL2012 = new XML2012();
            SAP_Module.Calculation2012 = calc2012;
            SAP_Module.Proj.NoOfDwells = SAP_Module.Proj.NoOfDwells;
            Functions.CalculateNow();
            int country = 1;
            try
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Address.Country, "Wales", false) == 0)
                country = 2;
              string sapxml = xmL2012.CreateSAPXML(SAP_Module.CurrDwelling, country);
              try
              {
                if (sapxml != null)
                  lodgedEpCtDetails.Downloaded = true;
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
              }
              if (lodgedEpCtDetails.Downloaded)
              {
                try
                {
                  PDFFunctions.DecodeFile(PDFFunctions.EncodeByte(lodgedEpCtDetails.EPCData), destFile);
                }
                catch (Exception ex)
                {
                  ProjectData.SetProjectError(ex);
                  ProjectData.ClearProjectError();
                }
              }
              else
              {
                int num7 = (int) Interaction.MsgBox((object) "Error Downloading lodged XML.", MsgBoxStyle.Critical, (object) "Stroma FSAP 2012 Lodged XML Download");
                return;
              }
            }
            catch (Exception ex)
            {
              ProjectData.SetProjectError(ex);
              Left = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "", false) != 0 ? Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left, Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "\r\n", this.dgvLodgements[1, rowIndex2].Value), (object) ":"), (object) "\r\n"), this.dgvLodgements[3, rowIndex2].Value), (object) "\r\n"), (object) Information.Err().Description), (object) "\r\n"))) : Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(this.dgvLodgements[1, rowIndex2].Value, (object) ":"), (object) "\r\n"), this.dgvLodgements[3, rowIndex2].Value), (object) "\r\n"), (object) Information.Err().Description), (object) "\r\n"));
              ProjectData.ClearProjectError();
            }
          }
          checked { ++rowIndex2; }
        }
        if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "", false) > 0U)
        {
          this.grpError.Visible = true;
          this.txtError.Text = Left;
        }
        else
        {
          this.grpError.Visible = false;
          this.txtError.Text = "";
        }
        this.PB1.Visible = false;
        if (!this.chkOpenDIR.Checked)
          return;
        Process.Start("explorer.exe", this.txtLocation.Text);
      }
    }

    private void txtLocation_TextChanged(object sender, EventArgs e)
    {
    }
  }
}
