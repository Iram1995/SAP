
// Type: SAP2012.Batch_Lodgement




using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using SAP2012.My;
using SAP2012.SAPRef;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SAP2012
{
  [DesignerGenerated]
  public class Batch_Lodgement : Form
  {
    private IContainer components;

    public Batch_Lodgement()
    {
      this.Load += new EventHandler(this.Batch_Lodgement_Load_1);
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
      DataGridViewCellStyle gridViewCellStyle1 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle2 = new DataGridViewCellStyle();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Batch_Lodgement));
      this.dataGLodgements = new DataGridView();
      this.ID = new DataGridViewTextBoxColumn();
      this.Address = new DataGridViewTextBoxColumn();
      this.UPRN = new DataGridViewTextBoxColumn();
      this.ViewEPC = new DataGridViewButtonColumn();
      this.Status = new DataGridViewImageColumn();
      this.Include = new DataGridViewCheckBoxColumn();
      this.cmdLodgeAll = new Button();
      this.cmdOnlineSurveyManagement = new Button();
      this.StatusList = new ImageList(this.components);
      this.ChkAllow = new CheckBox();
      this.Panel1 = new Panel();
      this.lblMessage = new Label();
      this.Label1 = new Label();
      this.Button2 = new Button();
      this.Button1 = new Button();
      ((ISupportInitialize) this.dataGLodgements).BeginInit();
      this.Panel1.SuspendLayout();
      this.SuspendLayout();
      this.dataGLodgements.AllowUserToAddRows = false;
      this.dataGLodgements.AllowUserToDeleteRows = false;
      gridViewCellStyle1.BackColor = Color.Honeydew;
      this.dataGLodgements.AlternatingRowsDefaultCellStyle = gridViewCellStyle1;
      this.dataGLodgements.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGLodgements.Columns.AddRange((DataGridViewColumn) this.ID, (DataGridViewColumn) this.Address, (DataGridViewColumn) this.UPRN, (DataGridViewColumn) this.ViewEPC, (DataGridViewColumn) this.Status, (DataGridViewColumn) this.Include);
      this.dataGLodgements.Cursor = Cursors.Hand;
      this.dataGLodgements.Dock = DockStyle.Fill;
      this.dataGLodgements.Location = new Point(0, 0);
      this.dataGLodgements.MultiSelect = false;
      this.dataGLodgements.Name = "dataGLodgements";
      this.dataGLodgements.RowHeadersWidth = 18;
      this.dataGLodgements.RowTemplate.Height = 50;
      this.dataGLodgements.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dataGLodgements.Size = new Size(1006, 629);
      this.dataGLodgements.TabIndex = 0;
      this.ID.HeaderText = "ID";
      this.ID.Name = "ID";
      this.ID.ReadOnly = true;
      this.ID.Visible = false;
      this.ID.Width = 5;
      this.Address.HeaderText = "Address";
      this.Address.Name = "Address";
      this.Address.Width = 500;
      gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
      this.UPRN.DefaultCellStyle = gridViewCellStyle2;
      this.UPRN.HeaderText = "UPRN";
      this.UPRN.Name = "UPRN";
      this.UPRN.Width = 150;
      this.ViewEPC.HeaderText = "View Draft EPC";
      this.ViewEPC.Name = "ViewEPC";
      this.ViewEPC.Resizable = DataGridViewTriState.True;
      this.ViewEPC.Text = "Draft EPC";
      this.Status.HeaderText = "Status";
      this.Status.Name = "Status";
      this.Include.HeaderText = "Include";
      this.Include.Name = "Include";
      this.Include.Width = 60;
      this.cmdLodgeAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.cmdLodgeAll.BackColor = Color.LightSlateGray;
      this.cmdLodgeAll.Cursor = Cursors.Hand;
      this.cmdLodgeAll.Enabled = false;
      this.cmdLodgeAll.FlatStyle = FlatStyle.Popup;
      this.cmdLodgeAll.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.cmdLodgeAll.ForeColor = Color.White;
      this.cmdLodgeAll.ImageAlign = ContentAlignment.MiddleLeft;
      this.cmdLodgeAll.Location = new Point(784, 57);
      this.cmdLodgeAll.Name = "cmdLodgeAll";
      this.cmdLodgeAll.Size = new Size(210, 32);
      this.cmdLodgeAll.TabIndex = 135;
      this.cmdLodgeAll.Tag = (object) "0";
      this.cmdLodgeAll.Text = "Lodge Selected";
      this.cmdLodgeAll.UseVisualStyleBackColor = false;
      this.cmdOnlineSurveyManagement.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      this.cmdOnlineSurveyManagement.BackColor = Color.LightSlateGray;
      this.cmdOnlineSurveyManagement.Cursor = Cursors.Hand;
      this.cmdOnlineSurveyManagement.FlatStyle = FlatStyle.Popup;
      this.cmdOnlineSurveyManagement.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.cmdOnlineSurveyManagement.ForeColor = Color.White;
      this.cmdOnlineSurveyManagement.ImageAlign = ContentAlignment.MiddleLeft;
      this.cmdOnlineSurveyManagement.Location = new Point(8, 64);
      this.cmdOnlineSurveyManagement.Name = "cmdOnlineSurveyManagement";
      this.cmdOnlineSurveyManagement.Size = new Size(206, 29);
      this.cmdOnlineSurveyManagement.TabIndex = 136;
      this.cmdOnlineSurveyManagement.Tag = (object) "0";
      this.cmdOnlineSurveyManagement.Text = "Online Survey Management";
      this.cmdOnlineSurveyManagement.UseVisualStyleBackColor = false;
      this.StatusList.ImageStream = (ImageListStreamer) componentResourceManager.GetObject("StatusList.ImageStream");
      this.StatusList.TransparentColor = Color.Transparent;
      this.StatusList.Images.SetKeyName(0, "Padlock_d.png");
      this.StatusList.Images.SetKeyName(1, "Padlock.png");
      this.StatusList.Images.SetKeyName(2, "Check.png");
      this.StatusList.Images.SetKeyName(3, "Warning.png");
      this.ChkAllow.AutoSize = true;
      this.ChkAllow.Cursor = Cursors.Hand;
      this.ChkAllow.ForeColor = Color.Maroon;
      this.ChkAllow.Location = new Point(761, 0);
      this.ChkAllow.Name = "ChkAllow";
      this.ChkAllow.Size = new Size(207, 46);
      this.ChkAllow.TabIndex = 138;
      this.ChkAllow.Text = "I confirm that those selected are\r\n correct and can now be lodged \r\nonto the Government Database";
      this.ChkAllow.UseVisualStyleBackColor = true;
      this.Panel1.Controls.Add((Control) this.lblMessage);
      this.Panel1.Controls.Add((Control) this.Label1);
      this.Panel1.Controls.Add((Control) this.Button2);
      this.Panel1.Controls.Add((Control) this.Button1);
      this.Panel1.Controls.Add((Control) this.cmdOnlineSurveyManagement);
      this.Panel1.Controls.Add((Control) this.ChkAllow);
      this.Panel1.Controls.Add((Control) this.cmdLodgeAll);
      this.Panel1.Dock = DockStyle.Bottom;
      this.Panel1.Location = new Point(0, 629);
      this.Panel1.Name = "Panel1";
      this.Panel1.Size = new Size(1006, 92);
      this.Panel1.TabIndex = 139;
      this.lblMessage.AutoSize = true;
      this.lblMessage.ForeColor = Color.Red;
      this.lblMessage.Location = new Point(496, 55);
      this.lblMessage.Name = "lblMessage";
      this.lblMessage.Size = new Size(0, 14);
      this.lblMessage.TabIndex = 143;
      this.lblMessage.Visible = false;
      this.Label1.AutoSize = true;
      this.Label1.BackColor = Color.Green;
      this.Label1.BorderStyle = BorderStyle.Fixed3D;
      this.Label1.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label1.ForeColor = Color.White;
      this.Label1.Location = new Point(320, 3);
      this.Label1.Name = "Label1";
      this.Label1.Padding = new Padding(10);
      this.Label1.Size = new Size(334, 36);
      this.Label1.TabIndex = 141;
      this.Label1.Text = "Dwellings with 1 or More Successful Lodgements ";
      this.Label1.Visible = false;
      this.Button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      this.Button2.BackColor = Color.LightSlateGray;
      this.Button2.Cursor = Cursors.Hand;
      this.Button2.FlatStyle = FlatStyle.Popup;
      this.Button2.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button2.ForeColor = Color.White;
      this.Button2.ImageAlign = ContentAlignment.MiddleLeft;
      this.Button2.Location = new Point(114, 33);
      this.Button2.Name = "Button2";
      this.Button2.Size = new Size(100, 25);
      this.Button2.TabIndex = 140;
      this.Button2.Tag = (object) "0";
      this.Button2.Text = "Select None";
      this.Button2.UseVisualStyleBackColor = false;
      this.Button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      this.Button1.BackColor = Color.LightSlateGray;
      this.Button1.Cursor = Cursors.Hand;
      this.Button1.FlatStyle = FlatStyle.Popup;
      this.Button1.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button1.ForeColor = Color.White;
      this.Button1.ImageAlign = ContentAlignment.MiddleLeft;
      this.Button1.Location = new Point(8, 33);
      this.Button1.Name = "Button1";
      this.Button1.Size = new Size(100, 25);
      this.Button1.TabIndex = 139;
      this.Button1.Tag = (object) "0";
      this.Button1.Text = "Select All";
      this.Button1.UseVisualStyleBackColor = false;
      this.AutoScaleDimensions = new SizeF(7f, 14f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1006, 721);
      this.Controls.Add((Control) this.dataGLodgements);
      this.Controls.Add((Control) this.Panel1);
      this.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MaximumSize = new Size(1024, 768);
      this.Name = nameof (Batch_Lodgement);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Batch SAP Lodgements";
      ((ISupportInitialize) this.dataGLodgements).EndInit();
      this.Panel1.ResumeLayout(false);
      this.Panel1.PerformLayout();
      this.ResumeLayout(false);
    }

    internal virtual DataGridView dataGLodgements
    {
      get => this._dataGLodgements;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DataGridViewCellEventHandler cellEventHandler = new DataGridViewCellEventHandler(this.dataGLodgements_CellContentClick);
        DataGridView dataGlodgements1 = this._dataGLodgements;
        if (dataGlodgements1 != null)
          dataGlodgements1.CellContentClick -= cellEventHandler;
        this._dataGLodgements = value;
        DataGridView dataGlodgements2 = this._dataGLodgements;
        if (dataGlodgements2 == null)
          return;
        dataGlodgements2.CellContentClick += cellEventHandler;
      }
    }

    private virtual Button cmdLodgeAll
    {
      get => this._cmdLodgeAll;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdLodgeAll_Click);
        Button cmdLodgeAll1 = this._cmdLodgeAll;
        if (cmdLodgeAll1 != null)
          cmdLodgeAll1.Click -= eventHandler;
        this._cmdLodgeAll = value;
        Button cmdLodgeAll2 = this._cmdLodgeAll;
        if (cmdLodgeAll2 == null)
          return;
        cmdLodgeAll2.Click += eventHandler;
      }
    }

    private virtual Button cmdOnlineSurveyManagement
    {
      get => this._cmdOnlineSurveyManagement;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdOnlineSurveyManagement_Click);
        Button surveyManagement1 = this._cmdOnlineSurveyManagement;
        if (surveyManagement1 != null)
          surveyManagement1.Click -= eventHandler;
        this._cmdOnlineSurveyManagement = value;
        Button surveyManagement2 = this._cmdOnlineSurveyManagement;
        if (surveyManagement2 == null)
          return;
        surveyManagement2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("StatusList")]
    internal virtual ImageList StatusList { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox ChkAllow
    {
      get => this._ChkAllow;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ChkAllow_CheckedChanged);
        CheckBox chkAllow1 = this._ChkAllow;
        if (chkAllow1 != null)
          chkAllow1.CheckedChanged -= eventHandler;
        this._ChkAllow = value;
        CheckBox chkAllow2 = this._ChkAllow;
        if (chkAllow2 == null)
          return;
        chkAllow2.CheckedChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Panel1")]
    internal virtual Panel Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private virtual Button Button2
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

    private virtual Button Button1
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

    [field: AccessedThroughProperty("ID")]
    internal virtual DataGridViewTextBoxColumn ID { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Address")]
    internal virtual DataGridViewTextBoxColumn Address { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("UPRN")]
    internal virtual DataGridViewTextBoxColumn UPRN { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("ViewEPC")]
    internal virtual DataGridViewButtonColumn ViewEPC { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Status")]
    internal virtual DataGridViewImageColumn Status { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Include")]
    internal virtual DataGridViewCheckBoxColumn Include { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label1")]
    internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("lblMessage")]
    internal virtual Label lblMessage { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    public void ReadInSurvey()
    {
      this.ChkAllow.Enabled = true;
      this.ChkAllow.Checked = false;
      this.dataGLodgements.Rows.Clear();
      try
      {
        int num1 = checked (SAP_Module.Proj.NoOfDwells - 1);
        int House = 0;
        while (House <= num1)
        {
          if (Validation.LodgementStatusCheck(House))
          {
            this.dataGLodgements.Rows.Add();
            int num2;
            this.dataGLodgements[0, num2].Value = (object) House;
            this.dataGLodgements[1, num2].Value = (object) SAP_Module.Proj.Dwellings[House].Address.Line1;
            if ((uint) Operators.CompareString(SAP_Module.Proj.Dwellings[House].Address.Line2, "", false) > 0U)
            {
              DataGridViewCell dataGlodgement;
              object obj = Operators.AddObject((dataGlodgement = this.dataGLodgements[1, num2]).Value, (object) (", " + SAP_Module.Proj.Dwellings[House].Address.Line2));
              dataGlodgement.Value = obj;
            }
            if ((uint) Operators.CompareString(SAP_Module.Proj.Dwellings[House].Address.Line3, "", false) > 0U)
            {
              DataGridViewCell dataGlodgement;
              object obj = Operators.AddObject((dataGlodgement = this.dataGLodgements[1, num2]).Value, (object) (", " + SAP_Module.Proj.Dwellings[House].Address.Line3));
              dataGlodgement.Value = obj;
            }
            if ((uint) Operators.CompareString(SAP_Module.Proj.Dwellings[House].Address.City, "", false) > 0U)
            {
              DataGridViewCell dataGlodgement;
              object obj = Operators.AddObject((dataGlodgement = this.dataGLodgements[1, num2]).Value, (object) (", " + SAP_Module.Proj.Dwellings[House].Address.City));
              dataGlodgement.Value = obj;
            }
            if ((uint) Operators.CompareString(SAP_Module.Proj.Dwellings[House].Address.Country, "", false) > 0U)
            {
              DataGridViewCell dataGlodgement;
              object obj = Operators.AddObject((dataGlodgement = this.dataGLodgements[1, num2]).Value, (object) (", " + SAP_Module.Proj.Dwellings[House].Address.Country));
              dataGlodgement.Value = obj;
            }
            if ((uint) Operators.CompareString(SAP_Module.Proj.Dwellings[House].Address.PostCost, "", false) > 0U)
            {
              DataGridViewCell dataGlodgement;
              object obj = Operators.AddObject((dataGlodgement = this.dataGLodgements[1, num2]).Value, (object) (", " + SAP_Module.Proj.Dwellings[House].Address.PostCost));
              dataGlodgement.Value = obj;
            }
            this.dataGLodgements[2, num2].Value = (object) SAP_Module.Proj.Dwellings[House].UPRN;
            this.dataGLodgements[3, num2].Value = (object) "Show Draft PDF";
            this.dataGLodgements[4, num2].Value = (object) this.StatusList.Images[0];
            int num3 = checked (SAP_Module.Proj.Dwellings[House].LodgementAttempts - 1);
            int index = 0;
            bool flag;
            while (index <= num3)
            {
              if (SAP_Module.Proj.Dwellings[House].Lodgement[index].Success)
              {
                flag = true;
                break;
              }
              checked { ++index; }
            }
            if (flag)
            {
              this.dataGLodgements[5, num2].Value = (object) false;
              this.dataGLodgements.Rows[num2].DefaultCellStyle.BackColor = Color.Green;
              this.dataGLodgements.Rows[num2].DefaultCellStyle.ForeColor = Color.White;
              this.dataGLodgements.Rows[num2].DefaultCellStyle.SelectionBackColor = Color.Green;
              this.Label1.Visible = true;
            }
            else
              this.dataGLodgements[5, num2].Value = (object) true;
            flag = false;
            checked { ++num2; }
          }
          checked { ++House; }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void cmdLodgeAll_Click(object sender, EventArgs e)
    {
      if (!Validation.Insurance.Include)
      {
        int num1 = (int) Interaction.MsgBox((object) "Insurance details are missssing please contact Stroma certification.", MsgBoxStyle.Critical, (object) "EPC Lodgement");
      }
      else if (SAP_Module.Proj.SaveFileName == null)
      {
        int num2 = (int) Interaction.MsgBox((object) "Please save the project before lodging the EPC", MsgBoxStyle.Critical, (object) "Lodgement");
      }
      else
      {
        this.cmdLodgeAll.Enabled = false;
        this.ChkAllow.Enabled = false;
        PDFFunctions.Draft_PDF = false;
        this.lblMessage.Visible = false;
        if (!Validation.UserLogged)
        {
          this.lblMessage.Visible = true;
        }
        else
        {
          try
          {
            int num3 = checked (this.dataGLodgements.RowCount - 1);
            int rowIndex1 = 0;
            while (rowIndex1 <= num3)
            {
              if (Operators.ConditionalCompareObjectEqual(this.dataGLodgements[5, rowIndex1].Value, (object) true, false))
                this.dataGLodgements[4, rowIndex1].Value = (object) this.StatusList.Images[1];
              checked { ++rowIndex1; }
            }
            SAPSoapClient sapSoapClient = new SAPSoapClient();
            MyProject.Forms.Batch_Results.Show();
            Application.DoEvents();
            int num4 = checked (this.dataGLodgements.RowCount - 1);
            int rowIndex2 = 0;
            while (rowIndex2 <= num4)
            {
              PDFFunctions.Draft_PDF = false;
              if (Operators.ConditionalCompareObjectEqual(this.dataGLodgements[5, rowIndex2].Value, (object) true, false))
              {
                TextBox txtResults1;
                string str1 = Conversions.ToString(Operators.AddObject((object) (txtResults1 = MyProject.Forms.Batch_Results.txtResults).Text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(this.dataGLodgements[1, rowIndex2].Value, (object) "\r\n"), this.dataGLodgements[2, rowIndex2].Value), (object) "\r\n"), (object) "Result......"), (object) "\r\n")));
                txtResults1.Text = str1;
                string str2 = "";
                Application.DoEvents();
                SAP_Module.CurrDwelling = Conversions.ToInteger(this.dataGLodgements[0, rowIndex2].Value);
                if (Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Status, "New dwelling design stage", false) == 0)
                {
                  TextBox txtResults2;
                  string str3 = (txtResults2 = MyProject.Forms.Batch_Results.txtResults).Text + "Assessment is at design stage, Lodgement unavailable\r\n";
                  txtResults2.Text = str3;
                  goto label_58;
                }
                else if (Functions.LodgementLock(SAP_Module.CurrDwelling))
                {
                  TextBox txtResults3;
                  string str4 = (txtResults3 = MyProject.Forms.Batch_Results.txtResults).Text + "This EPC has been lodged previuosly. In order to relodge please copy the dwelling and lodge again.";
                  txtResults3.Text = str4;
                  goto label_58;
                }
                else
                {
                  if (Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Status, "Existing dwelling (SAP)", false) == 0 & Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Transaction, "New dwelling", false) == 0)
                  {
                    TextBox txtResults4;
                    string str5 = (txtResults4 = MyProject.Forms.Batch_Results.txtResults).Text + "Assessment is at design stage, Lodgement unavailable.\r\n";
                    txtResults4.Text = str5;
                    return;
                  }
                  int num5 = checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofWindows - 1);
                  int index1 = 0;
                  bool flag1;
                  while (index1 <= num5)
                  {
                    if (Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows[index1].Orientation, "Worst case", false) == 0)
                      flag1 = true;
                    checked { ++index1; }
                  }
                  int num6 = checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofDoors - 1);
                  int index2 = 0;
                  while (index2 <= num6)
                  {
                    if (Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors[index2].Orientation, "Worst case", false) == 0)
                      flag1 = true;
                    checked { ++index2; }
                  }
                  int num7 = checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofRoofLights - 1);
                  int index3 = 0;
                  while (index3 <= num7)
                  {
                    if (Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[index3].Orientation, "Worst case", false) == 0)
                      flag1 = true;
                    checked { ++index3; }
                  }
                  if (flag1)
                  {
                    TextBox txtResults5;
                    string str6 = (txtResults5 = MyProject.Forms.Batch_Results.txtResults).Text + "Opening section contains  Orientation type Worst case which cannot be used for the lodgements\r\n";
                    txtResults5.Text = str6;
                    goto label_58;
                  }
                  else
                  {
                    // ISSUE: variable of a reference type
                    int& local1;
                    // ISSUE: explicit reference operation
                    int num8 = checked (^(local1 = ref SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].LodgementAttempts) + 1);
                    local1 = num8;
                    // ISSUE: variable of a reference type
                    SAP_Module.Lodgement[]& local2;
                    // ISSUE: explicit reference operation
                    SAP_Module.Lodgement[] lodgementArray = (SAP_Module.Lodgement[]) Utils.CopyArray((Array) ^(local2 = ref SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Lodgement), (Array) new SAP_Module.Lodgement[checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].LodgementAttempts - 1 + 1)]);
                    local2 = lodgementArray;
                    int index4 = checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].LodgementAttempts - 1);
                    Functions.Access_Details();
                    Calc2012 calc2012 = new Calc2012();
                    calc2012.SETPCDF(SAP_Module.PCDFData);
                    calc2012.Dwelling = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling];
                    SAP_Module.Proj.NoOfDwells = SAP_Module.Proj.NoOfDwells;
                    XML2012 xmL2012 = new XML2012();
                    SAP_Module.Calculation2012 = calc2012;
                    Functions.CalculateNow();
                    int num9 = 1;
                    string str7;
                    bool flag2;
                    try
                    {
                      string country = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Address.Country;
                      if (Operators.CompareString(country, "Wales", false) != 0)
                      {
                        if (Operators.CompareString(country, "Scotland", false) == 0)
                          num9 = 4;
                      }
                      else
                        num9 = 2;
                      string sapxml = xmL2012.CreateSAPXML(SAP_Module.CurrDwelling, num9);
                      if (num9 == 4)
                      {
                        str7 = sapSoapClient.LodgeScotlandXML(sapxml, Validation.UserName, Functions.MD5_Hash(Validation.Password), Validation.AssessorNO, Validation.RefNum, Functions.TransactionID, Functions.Encrypt);
                        flag2 = !str7.Contains("EPC lodged successfully");
                      }
                      else
                      {
                        str7 = sapSoapClient.LodgeXML(sapxml, Validation.RefNum, Validation.UserName, Functions.MD5_Hash(Validation.Password), Validation.AssessorNO, Functions.TransactionID, Functions.Encrypt, (CountryType) num9);
                        flag2 = str7.Contains("error");
                      }
                      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Lodgement[index4].RRN = Validation.RefNum;
                    }
                    catch (Exception ex)
                    {
                      ProjectData.SetProjectError(ex);
                      Exception exception = ex;
                      this.dataGLodgements[4, rowIndex2].Value = (object) this.StatusList.Images[3];
                      TextBox txtResults6;
                      string str8 = (txtResults6 = MyProject.Forms.Batch_Results.txtResults).Text + "Failed\r\n" + exception.Message + "\r\n\r\n";
                      txtResults6.Text = str8;
                      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Lodgement[index4].RRN = Validation.RefNum;
                      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Lodgement[index4].Result = exception.Message + " " + str7;
                      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Lodgement[index4].DateLodged = DateTime.Now;
                      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Lodgement[index4].Success = false;
                      ProjectData.ClearProjectError();
                      goto label_58;
                    }
                    int num10 = 1;
                    if (flag2)
                    {
                      int num11 = checked (num10 + 1);
                    }
                    ref SAP_Module.Dwelling local3 = ref SAP_Module.Proj.Dwellings[Conversions.ToInteger(this.dataGLodgements[0, rowIndex2].Value)];
                    if (!flag2)
                    {
                      TextBox txtResults7;
                      string str9 = (txtResults7 = MyProject.Forms.Batch_Results.txtResults).Text + "Successfully Lodged\r\n";
                      txtResults7.Text = str9;
                      this.dataGLodgements[4, rowIndex2].Value = (object) this.StatusList.Images[2];
                      local3.Lodgement[checked (local3.LodgementAttempts - 1)].DateLodged = DateTime.Now;
                      local3.Lodgement[checked (local3.LodgementAttempts - 1)].Result = "Successfully Lodged";
                      local3.Lodgement[checked (local3.LodgementAttempts - 1)].RRN = Validation.RefNum;
                      local3.Lodgement[checked (local3.LodgementAttempts - 1)].Success = true;
                      if (calc2012.Calculation.SAP_rating_11a.SAPRating == 0.0)
                      {
                        local3.Lodgement[checked (local3.LodgementAttempts - 1)].SAP.SAPBand = calc2012.Calculation.SAP_rating_11b.SAPBand;
                        local3.Lodgement[checked (local3.LodgementAttempts - 1)].SAP.SAPRating = checked ((int) Math.Round(calc2012.Calculation.SAP_rating_11b.SAPRating));
                        local3.Lodgement[checked (local3.LodgementAttempts - 1)].PSAP.SAPRating = checked ((int) Math.Round(SAP_Module.CalculationImprove2012.Calculation.SAP_rating_11b.SAPRating));
                        local3.Lodgement[checked (local3.LodgementAttempts - 1)].PSAP.SAPBand = SAP_Module.CalculationImprove2012.Calculation.SAP_rating_11b.SAPBand;
                      }
                      else
                      {
                        local3.Lodgement[checked (local3.LodgementAttempts - 1)].SAP.SAPBand = calc2012.Calculation.SAP_rating_11a.SAPBand;
                        local3.Lodgement[checked (local3.LodgementAttempts - 1)].SAP.SAPRating = checked ((int) Math.Round(calc2012.Calculation.SAP_rating_11a.SAPRating));
                        local3.Lodgement[checked (local3.LodgementAttempts - 1)].PSAP.SAPRating = checked ((int) Math.Round(SAP_Module.CalculationImprove2012.Calculation.SAP_rating_11a.SAPRating));
                        local3.Lodgement[checked (local3.LodgementAttempts - 1)].PSAP.SAPBand = SAP_Module.CalculationImprove2012.Calculation.SAP_rating_11a.SAPBand;
                      }
                      if (calc2012.Calculation.CO2_Emissions_12a.EIValue == 0.0)
                      {
                        local3.Lodgement[checked (local3.LodgementAttempts - 1)].SAP.EIBand = calc2012.Calculation.CO2_Emissions_12b.EIBand;
                        local3.Lodgement[checked (local3.LodgementAttempts - 1)].SAP.EIRating = checked ((int) Math.Round(calc2012.Calculation.CO2_Emissions_12b.EIRating));
                        local3.Lodgement[checked (local3.LodgementAttempts - 1)].PSAP.EIBand = SAP_Module.CalculationImprove2012.Calculation.CO2_Emissions_12b.EIBand;
                        local3.Lodgement[checked (local3.LodgementAttempts - 1)].PSAP.EIRating = checked ((int) Math.Round(SAP_Module.CalculationImprove2012.Calculation.CO2_Emissions_12b.EIRating));
                      }
                      else
                      {
                        local3.Lodgement[checked (local3.LodgementAttempts - 1)].SAP.EIBand = calc2012.Calculation.CO2_Emissions_12a.EIBand;
                        local3.Lodgement[checked (local3.LodgementAttempts - 1)].SAP.EIRating = checked ((int) Math.Round(calc2012.Calculation.CO2_Emissions_12a.Box274));
                        local3.Lodgement[checked (local3.LodgementAttempts - 1)].PSAP.EIBand = SAP_Module.CalculationImprove2012.Calculation.CO2_Emissions_12a.EIBand;
                        local3.Lodgement[checked (local3.LodgementAttempts - 1)].PSAP.EIRating = checked ((int) Math.Round(SAP_Module.CalculationImprove2012.Calculation.CO2_Emissions_12a.Box274));
                      }
                    }
                    else
                    {
                      TextBox txtResults8;
                      string str10 = (txtResults8 = MyProject.Forms.Batch_Results.txtResults).Text + str2 + "\r\n";
                      txtResults8.Text = str10;
                      this.dataGLodgements[4, rowIndex2].Value = (object) this.StatusList.Images[3];
                      local3.Lodgement[checked (local3.LodgementAttempts - 1)].DateLodged = DateTime.Now;
                      local3.Lodgement[checked (local3.LodgementAttempts - 1)].Result = str7;
                      local3.Lodgement[checked (local3.LodgementAttempts - 1)].RRN = Validation.RefNum;
                      local3.Lodgement[checked (local3.LodgementAttempts - 1)].Success = false;
                    }
                    local3.Lodgement[checked (local3.LodgementAttempts - 1)].Method = "Batch";
                    TextBox txtResults9;
                    string str11 = (txtResults9 = MyProject.Forms.Batch_Results.txtResults).Text + "\r\n";
                    txtResults9.Text = str11;
                  }
                }
              }
label_58:
              Application.DoEvents();
              checked { ++rowIndex2; }
            }
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            Exception exception = ex;
            TextBox txtResults10;
            string str12 = (txtResults10 = MyProject.Forms.Batch_Results.txtResults).Text + exception.Message + "\r\n";
            txtResults10.Text = str12;
            TextBox txtResults11;
            string str13 = (txtResults11 = MyProject.Forms.Batch_Results.txtResults).Text + "Lodgement Failed. Please view history to see error message(s).\r\n";
            txtResults11.Text = str13;
            ProjectData.ClearProjectError();
          }
          Functions.SaveFile(SAP_Module.Proj, SAP_Module.Proj.SaveFileName);
          SAP_Module.CurrDwelling = -1;
          MyProject.Forms.Batch_Results.cmdClose.Enabled = true;
          MyProject.Forms.Batch_Results.lblComplete.Visible = true;
        }
      }
    }

    private void ChkAllow_CheckedChanged(object sender, EventArgs e)
    {
      if (!Validation.UserLogged)
      {
        this.lblMessage.Visible = true;
        this.lblMessage.Text = "You are not logged in.";
      }
      else
      {
        this.lblMessage.Visible = false;
        if (this.ChkAllow.Checked)
          this.cmdLodgeAll.Enabled = true;
        else
          this.cmdLodgeAll.Enabled = false;
      }
    }

    private void cmdOnlineSurveyManagement_Click(object sender, EventArgs e)
    {
      MyProject.Forms.Lodgement_History.FillHistory();
      int num = (int) MyProject.Forms.Lodgement_History.ShowDialog();
    }

    private void Button1_Click(object sender, EventArgs e)
    {
      int num = checked (this.dataGLodgements.RowCount - 1);
      int rowIndex = 0;
      while (rowIndex <= num)
      {
        this.dataGLodgements[5, rowIndex].Value = (object) true;
        checked { ++rowIndex; }
      }
    }

    private void Button2_Click(object sender, EventArgs e)
    {
      int num = checked (this.dataGLodgements.RowCount - 1);
      int rowIndex = 0;
      while (rowIndex <= num)
      {
        this.dataGLodgements[5, rowIndex].Value = (object) false;
        checked { ++rowIndex; }
      }
    }

    private void dataGLodgements_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.ColumnIndex == 3)
      {
        SAP_Module.CurrDwelling = Conversions.ToInteger(this.dataGLodgements[0, this.dataGLodgements.SelectedRows[0].Index].Value);
        Functions.CalculateNow();
        object folderPath = (object) Environment.GetFolderPath(Environment.SpecialFolder.Personal);
        DirectoryInfo directoryInfo1 = new DirectoryInfo(Conversions.ToString(Operators.ConcatenateObject(folderPath, (object) "\\Stroma SAP 2012")));
        DirectoryInfo directoryInfo2 = new DirectoryInfo(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(folderPath, (object) "\\Stroma SAP 2012\\"), (object) SAP_Module.Proj.Name)));
        DirectoryInfo directoryInfo3 = new DirectoryInfo(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(folderPath, (object) "\\Stroma SAP 2012\\"), (object) SAP_Module.Proj.Name), (object) "\\"), (object) SAP_Module.Proj.Dwellings[Conversions.ToInteger(this.dataGLodgements[0, this.dataGLodgements.SelectedRows[0].Index].Value)].Name)));
        if (!directoryInfo1.Exists)
          directoryInfo1.Create();
        if (!directoryInfo2.Exists)
          directoryInfo2.Create();
        if (!directoryInfo3.Exists)
          directoryInfo3.Create();
        CreatePDF createPdf = new CreatePDF();
        CreatePDF.DraftDetails draftDetails = new CreatePDF.DraftDetails();
        if (Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Address.Country, "Scotland", false) == 0)
        {
          MyProject.Forms.EPC_Viewer.EPCViewer.Visible = true;
          MyProject.Forms.EPC_Viewer.PictureBox1.Visible = false;
          CreatePDF.DraftDetails draft = createPdf.CreateDraft(4);
          if (draft.DraftCrated)
          {
            PDFFunctions.DecodeFile(draft.DraftEPC, SAP_Module.ScottishFileName);
            MyProject.Forms.EPC_Viewer.EPCViewer.Navigate(SAP_Module.ScottishFileName);
          }
          else
          {
            int num = (int) Interaction.MsgBox((object) "Error Creating draft EPC.", MsgBoxStyle.Critical, (object) "Stroma FSAP 2012 Draft Creation");
            return;
          }
        }
        else
        {
          int country1 = 1;
          string country2 = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Address.Country;
          if (Operators.CompareString(country2, "Scotland", false) != 0)
          {
            if (Operators.CompareString(country2, "Wales", false) != 0)
            {
              if (Operators.CompareString(country2, "Northern Ireland", false) == 0)
                country1 = 3;
            }
            else
              country1 = Conversions.ToInteger("2");
          }
          else
            country1 = 4;
          Calc2012 calc2012 = new Calc2012();
          calc2012.SETPCDF(SAP_Module.PCDFData);
          calc2012.Dwelling = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling];
          string sapxml = new XML2012().CreateSAPXML(SAP_Module.CurrDwelling, country1);
          DraftRatingProce draftRatingProce = new DraftRatingProce();
          int CurrRating = SAP_Module.Calculation2012.Calculation.SAP_rating_11a.SAPRating != 0.0 ? checked ((int) Math.Round(SAP_Module.Calculation2012.Calculation.SAP_rating_11a.SAPRating)) : checked ((int) Math.Round(SAP_Module.Calculation2012.Calculation.SAP_rating_11b.SAPRating));
          if (CurrRating < 1)
            CurrRating = 1;
          int PotentialRating = SAP_Module.Calculation2012.Calculation.SAP_rating_11a.SAPRating != 0.0 ? checked ((int) Math.Round(SAP_Module.Calculation2012.Calculation.SAP_rating_11a.SAPRating)) : checked ((int) Math.Round(SAP_Module.Calculation2012.Calculation.SAP_rating_11b.SAPRating));
          if (PotentialRating < 1)
            PotentialRating = 1;
          using (MemoryStream memoryStream = new MemoryStream())
          {
            draftRatingProce.DrawGraph(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Address.Country, CurrRating, PotentialRating).Save((Stream) memoryStream, ImageFormat.Png);
            string base64String = Convert.ToBase64String(memoryStream.ToArray());
            string draftEpc = DraftEpc.GetDraftEpc(sapxml, base64String);
            MyProject.Forms.EPC_Viewer.EPCViewer.Navigate("about:blank");
            MyProject.Forms.EPC_Viewer.EPCViewer.Document.Write(string.Empty);
            MyProject.Forms.EPC_Viewer.EPCViewer.DocumentText = draftEpc;
          }
        }
      }
      int num1 = (int) MyProject.Forms.EPC_Viewer.ShowDialog();
    }

    private void Batch_Lodgement_Load(object sender, EventArgs e)
    {
    }

    private void Batch_Lodgement_Load_1(object sender, EventArgs e) => this.lblMessage.Visible = false;
  }
}
