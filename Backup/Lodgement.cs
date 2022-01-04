
// Type: SAP2012.Lodgement




using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using SAP2012.My;
using SAP2012.NISAP;
using SAP2012.SAPRef;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SAP2012
{
  [DesignerGenerated]
  public class Lodgement : Form
  {
    private IContainer components;
    private bool Clicked;

    public Lodgement()
    {
      this.Load += new EventHandler(this.Lodgement_Load);
      this.MouseMove += new MouseEventHandler(this.Lodgement_MouseMove);
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
      this.WebBrowser1 = new WebBrowser();
      this.Panel1 = new Panel();
      this.PictureBox1 = new PictureBox();
      this.cmdLodgeAll = new Button();
      this.Single_Lodge_Btn = new Button();
      this.ChkAllow = new CheckBox();
      this.lblMessage = new Label();
      this.cmdDraft = new Button();
      this.Panel1.SuspendLayout();
      ((ISupportInitialize) this.PictureBox1).BeginInit();
      this.SuspendLayout();
      this.WebBrowser1.Location = new Point(0, 0);
      this.WebBrowser1.MinimumSize = new Size(20, 20);
      this.WebBrowser1.Name = "WebBrowser1";
      this.WebBrowser1.Size = new Size(800, 676);
      this.WebBrowser1.TabIndex = 0;
      this.Panel1.Controls.Add((Control) this.WebBrowser1);
      this.Panel1.Controls.Add((Control) this.PictureBox1);
      this.Panel1.Dock = DockStyle.Left;
      this.Panel1.Location = new Point(0, 0);
      this.Panel1.Name = "Panel1";
      this.Panel1.Size = new Size(800, 676);
      this.Panel1.TabIndex = 1;
      this.PictureBox1.BackColor = Color.White;
      this.PictureBox1.Location = new Point(0, 0);
      this.PictureBox1.Name = "PictureBox1";
      this.PictureBox1.Size = new Size(800, 675);
      this.PictureBox1.TabIndex = 1;
      this.PictureBox1.TabStop = false;
      this.PictureBox1.Visible = false;
      this.cmdLodgeAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.cmdLodgeAll.BackColor = Color.LightSlateGray;
      this.cmdLodgeAll.Cursor = Cursors.Hand;
      this.cmdLodgeAll.FlatStyle = FlatStyle.Popup;
      this.cmdLodgeAll.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.cmdLodgeAll.ForeColor = Color.White;
      this.cmdLodgeAll.ImageAlign = ContentAlignment.MiddleLeft;
      this.cmdLodgeAll.Location = new Point(806, 641);
      this.cmdLodgeAll.Name = "cmdLodgeAll";
      this.cmdLodgeAll.Size = new Size(184, 23);
      this.cmdLodgeAll.TabIndex = 136;
      this.cmdLodgeAll.Tag = (object) "0";
      this.cmdLodgeAll.Text = "Cancel";
      this.cmdLodgeAll.UseVisualStyleBackColor = false;
      this.Single_Lodge_Btn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.Single_Lodge_Btn.BackColor = Color.LightSlateGray;
      this.Single_Lodge_Btn.Cursor = Cursors.Hand;
      this.Single_Lodge_Btn.DialogResult = DialogResult.OK;
      this.Single_Lodge_Btn.Enabled = false;
      this.Single_Lodge_Btn.FlatStyle = FlatStyle.Popup;
      this.Single_Lodge_Btn.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Single_Lodge_Btn.ForeColor = Color.White;
      this.Single_Lodge_Btn.ImageAlign = ContentAlignment.MiddleLeft;
      this.Single_Lodge_Btn.Location = new Point(806, 49);
      this.Single_Lodge_Btn.Name = "Single_Lodge_Btn";
      this.Single_Lodge_Btn.Size = new Size(184, 23);
      this.Single_Lodge_Btn.TabIndex = 137;
      this.Single_Lodge_Btn.Tag = (object) "0";
      this.Single_Lodge_Btn.Text = "Lodge EPC";
      this.Single_Lodge_Btn.UseVisualStyleBackColor = false;
      this.ChkAllow.AutoSize = true;
      this.ChkAllow.Cursor = Cursors.Hand;
      this.ChkAllow.ForeColor = Color.Maroon;
      this.ChkAllow.Location = new Point(806, 0);
      this.ChkAllow.Name = "ChkAllow";
      this.ChkAllow.Size = new Size(180, 43);
      this.ChkAllow.TabIndex = 139;
      this.ChkAllow.Text = "I confirm that the EPC is \r\n correct and can now be lodged \r\nonto the Government Database";
      this.ChkAllow.UseVisualStyleBackColor = true;
      this.lblMessage.AutoSize = true;
      this.lblMessage.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblMessage.ForeColor = Color.Black;
      this.lblMessage.Location = new Point(806, 87);
      this.lblMessage.Name = "lblMessage";
      this.lblMessage.Size = new Size(135, 16);
      this.lblMessage.TabIndex = 143;
      this.lblMessage.Text = "Lodgements Complete";
      this.lblMessage.Visible = false;
      this.cmdDraft.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.cmdDraft.BackColor = Color.LightSlateGray;
      this.cmdDraft.Cursor = Cursors.Hand;
      this.cmdDraft.DialogResult = DialogResult.OK;
      this.cmdDraft.FlatStyle = FlatStyle.Popup;
      this.cmdDraft.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.cmdDraft.ForeColor = Color.White;
      this.cmdDraft.ImageAlign = ContentAlignment.MiddleLeft;
      this.cmdDraft.Location = new Point(806, 612);
      this.cmdDraft.Name = "cmdDraft";
      this.cmdDraft.Size = new Size(184, 23);
      this.cmdDraft.TabIndex = 144;
      this.cmdDraft.Tag = (object) "0";
      this.cmdDraft.Text = "View Draft";
      this.cmdDraft.UseVisualStyleBackColor = false;
      this.cmdDraft.Visible = false;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(994, 676);
      this.Controls.Add((Control) this.cmdDraft);
      this.Controls.Add((Control) this.lblMessage);
      this.Controls.Add((Control) this.ChkAllow);
      this.Controls.Add((Control) this.Single_Lodge_Btn);
      this.Controls.Add((Control) this.cmdLodgeAll);
      this.Controls.Add((Control) this.Panel1);
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.Name = nameof (Lodgement);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = nameof (Lodgement);
      this.Panel1.ResumeLayout(false);
      ((ISupportInitialize) this.PictureBox1).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    [field: AccessedThroughProperty("WebBrowser1")]
    internal virtual WebBrowser WebBrowser1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Panel1")]
    internal virtual Panel Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

    private virtual Button Single_Lodge_Btn
    {
      get => this._Single_Lodge_Btn;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Single_Lodge_Btn_Click);
        Button singleLodgeBtn1 = this._Single_Lodge_Btn;
        if (singleLodgeBtn1 != null)
          singleLodgeBtn1.Click -= eventHandler;
        this._Single_Lodge_Btn = value;
        Button singleLodgeBtn2 = this._Single_Lodge_Btn;
        if (singleLodgeBtn2 == null)
          return;
        singleLodgeBtn2.Click += eventHandler;
      }
    }

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

    [field: AccessedThroughProperty("lblMessage")]
    internal virtual Label lblMessage { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private virtual Button cmdDraft
    {
      get => this._cmdDraft;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdDraft_Click);
        Button cmdDraft1 = this._cmdDraft;
        if (cmdDraft1 != null)
          cmdDraft1.Click -= eventHandler;
        this._cmdDraft = value;
        Button cmdDraft2 = this._cmdDraft;
        if (cmdDraft2 == null)
          return;
        cmdDraft2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("PictureBox1")]
    internal virtual PictureBox PictureBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private void ChkAllow_CheckedChanged(object sender, EventArgs e)
    {
      PDFFunctions.document.Dispose();
      if (Validation.UserLogged)
      {
        if (this.ChkAllow.Checked)
        {
          this.Single_Lodge_Btn.Enabled = true;
          if (!Functions.LodgementLock(SAP_Module.CurrDwelling))
            return;
          this.lblMessage.Visible = true;
          this.lblMessage.Text = "This EPC has been lodged \r\n";
          Label lblMessage1;
          string str1 = (lblMessage1 = this.lblMessage).Text + "previuosly.In order to relodge  \r\n";
          lblMessage1.Text = str1;
          Label lblMessage2;
          string str2 = (lblMessage2 = this.lblMessage).Text + "please copy the dwelling  \r\n";
          lblMessage2.Text = str2;
          Label lblMessage3;
          string str3 = (lblMessage3 = this.lblMessage).Text + "And lodge again.";
          lblMessage3.Text = str3;
          this.Single_Lodge_Btn.Enabled = false;
        }
        else
          this.Single_Lodge_Btn.Enabled = false;
      }
      else
      {
        this.lblMessage.Visible = true;
        this.lblMessage.Text = "You are not logged in.";
      }
    }

    private bool CheckFont()
    {
      FontFamily[] families = new InstalledFontCollection().Families;
      int index = 0;
      while (index < families.Length)
      {
        if (Operators.CompareString(families[index].Name, "DejaVu Sans", false) == 0)
          return true;
        checked { ++index; }
      }
      int num = (int) Interaction.MsgBox((object) "Please note that to enable the production of EPCs\r\nYou need to install a required font.\r\nThe installation of the font will start\r\nfolling this message being closed.\r\n\r\nIMPORTANT:\r\nYou will also need to save your work and restart the application", MsgBoxStyle.Critical, (object) "Font Installation");
      Process.Start(Application.StartupPath + "\\Fonts\\DejaVuSans_0.ttf");
      return false;
    }

    private void Lodgement_Load(object sender, EventArgs e)
    {
      if (!Validation.UserLogged)
      {
        int num = (int) Interaction.MsgBox((object) "Lodgement Error. You are not authorized to do the SAP lodgement.", MsgBoxStyle.Critical, (object) "EPC Lodgement");
        this.Close();
      }
      else
      {
        this.Single_Lodge_Btn.Visible = true;
        this.PictureBox1.Visible = false;
        this.WebBrowser1.Visible = false;
        this.Clicked = false;
        PDFFunctions.document.Dispose();
        this.DraftEPC();
      }
    }

    private void Lodgement_MouseMove(object sender, MouseEventArgs e) => this.lblMessage.Visible = false;

    private void Single_Lodge_Btn_Click(object sender, EventArgs e)
    {
      if (SAPInput.TraineeUser)
      {
        int num1 = (int) Interaction.MsgBox((object) "Lodgement Error. You are not authorized to do the SAP lodgement.", MsgBoxStyle.Critical, (object) "EPC Lodgement");
      }
      else
      {
        this.Single_Lodge_Btn.Enabled = false;
        if (this.Clicked)
          return;
        if (!Validation.Insurance.Include)
        {
          int num2 = (int) Interaction.MsgBox((object) "Insurance details are missssing please contact Stroma certification.", MsgBoxStyle.Critical, (object) "EPC Lodgement");
        }
        else
        {
          string str1 = "";
          if (Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Status, "New dwelling design stage", false) == 0)
          {
            int num3 = (int) Interaction.MsgBox((object) "Assessment is at design stage, Lodgement unavailable", MsgBoxStyle.Critical, (object) nameof (Lodgement));
          }
          else if (Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Status, "Existing dwelling (SAP)", false) == 0 & Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Transaction, "New dwelling", false) == 0)
          {
            int num4 = (int) Interaction.MsgBox((object) "Incorrect combination for Transaction Type and Assessment Type.", MsgBoxStyle.Critical, (object) nameof (Lodgement));
          }
          else
          {
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
              int num8 = (int) Interaction.MsgBox((object) "Opening section contains Orientation type Worst case which cannot be used for the lodgements", MsgBoxStyle.Critical, (object) nameof (Lodgement));
            }
            else
            {
              PDFFunctions.Draft_PDF = false;
              if (SAP_Module.Proj.SaveFileName == null)
              {
                int num9 = (int) Interaction.MsgBox((object) "Please save the project before lodging the EPC", MsgBoxStyle.Critical, (object) nameof (Lodgement));
              }
              else
              {
                Functions.SaveFile(SAP_Module.Proj, SAP_Module.Proj.SaveFileName);
                this.Clicked = true;
                SAPSoapClient sapSoapClient = new SAPSoapClient();
                NISAPSoapClient nisapSoapClient = new NISAPSoapClient();
                PDFFunctions.Draft_PDF = false;
                // ISSUE: variable of a reference type
                int& local1;
                // ISSUE: explicit reference operation
                int num10 = checked (^(local1 = ref SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].LodgementAttempts) + 1);
                local1 = num10;
                // ISSUE: variable of a reference type
                SAP_Module.Lodgement[]& local2;
                // ISSUE: explicit reference operation
                SAP_Module.Lodgement[] lodgementArray = (SAP_Module.Lodgement[]) Utils.CopyArray((Array) ^(local2 = ref SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Lodgement), (Array) new SAP_Module.Lodgement[checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].LodgementAttempts - 1 + 1)]);
                local2 = lodgementArray;
                int index4 = checked (((IEnumerable<SAP_Module.Lodgement>) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Lodgement).Count<SAP_Module.Lodgement>() - 1);
                Functions.Access_Details();
                try
                {
                  Calc2012 calc2012 = new Calc2012();
                  calc2012.SETPCDF(SAP_Module.PCDFData);
                  calc2012.Dwelling = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling];
                  XML2012 xmL2012 = new XML2012();
                  SAP_Module.Calculation2012 = calc2012;
                  SAP_Module.Proj.NoOfDwells = SAP_Module.Proj.NoOfDwells;
                  int num11 = 1;
                  if (Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Address.Country, "Wales", false) == 0)
                    num11 = 2;
                  if (Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Address.Country, "Scotland", false) == 0)
                    num11 = 4;
                  string sapxml = xmL2012.CreateSAPXML(SAP_Module.CurrDwelling, num11);
                  string str2;
                  bool flag2;
                  if (num11 == 4)
                  {
                    str2 = sapSoapClient.LodgeScotlandXML(sapxml, Validation.UserName, Functions.MD5_Hash(Validation.Password), Validation.AssessorNO, Validation.RefNum, Functions.TransactionID, Functions.Encrypt);
                    if (!str2.Contains("EPC lodged successfully"))
                      flag2 = true;
                  }
                  else
                  {
                    str2 = sapSoapClient.LodgeXML(sapxml, Validation.RefNum, Validation.UserName, Functions.MD5_Hash(Validation.Password), Validation.AssessorNO, Functions.TransactionID, Functions.Encrypt, (CountryType) num11);
                    if (str2.Contains("error"))
                      flag2 = true;
                  }
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Lodgement[index4].RRN = Validation.RefNum;
                  if (!flag2)
                  {
                    MyProject.Forms.Lodgement_Result.grpFail.Visible = false;
                    MyProject.Forms.Lodgement_Result.grpSuccess.Visible = true;
                    MyProject.Forms.Lodgement_Result.txtResult.Visible = false;
                    TextBox txtResult;
                    string str3 = (txtResult = MyProject.Forms.Lodgement_Result.txtResult).Text + "Successfully Lodged\r\n";
                    txtResult.Text = str3;
                    MyProject.Forms.Lodgement_Result.lblSuccess.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Lodgement[index4].RRN + " Successfully Lodged";
                    SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Lodgement[index4].Result = "Successful";
                    SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Lodgement[index4].DateLodged = DateAndTime.Now;
                    SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Lodgement[index4].Success = true;
                    if (calc2012.Calculation.SAP_rating_11a.SAPRating == 0.0)
                    {
                      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Lodgement[index4].SAP.SAPBand = calc2012.Calculation.SAP_rating_11b.SAPBand;
                      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Lodgement[index4].SAP.SAPRating = checked ((int) Math.Round(calc2012.Calculation.SAP_rating_11b.SAPRating));
                      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Lodgement[index4].PSAP.SAPRating = checked ((int) Math.Round(SAP_Module.CalculationImprove2012.Calculation.SAP_rating_11b.SAPRating));
                      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Lodgement[index4].PSAP.SAPBand = SAP_Module.CalculationImprove2012.Calculation.SAP_rating_11b.SAPBand;
                    }
                    else
                    {
                      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Lodgement[index4].SAP.SAPBand = calc2012.Calculation.SAP_rating_11a.SAPBand;
                      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Lodgement[index4].SAP.SAPRating = checked ((int) Math.Round(calc2012.Calculation.SAP_rating_11a.SAPRating));
                      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Lodgement[index4].PSAP.SAPRating = checked ((int) Math.Round(SAP_Module.CalculationImprove2012.Calculation.SAP_rating_11a.SAPRating));
                      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Lodgement[index4].PSAP.SAPBand = SAP_Module.CalculationImprove2012.Calculation.SAP_rating_11a.SAPBand;
                    }
                    if (calc2012.Calculation.CO2_Emissions_12a.Box274 == 0.0)
                    {
                      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Lodgement[index4].SAP.EIBand = calc2012.Calculation.CO2_Emissions_12b.EIBand;
                      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Lodgement[index4].SAP.EIRating = checked ((int) Math.Round(calc2012.Calculation.CO2_Emissions_12b.EIRating));
                      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Lodgement[index4].PSAP.EIBand = SAP_Module.CalculationImprove2012.Calculation.CO2_Emissions_12b.EIBand;
                      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Lodgement[index4].PSAP.EIRating = checked ((int) Math.Round(SAP_Module.CalculationImprove2012.Calculation.CO2_Emissions_12b.EIRating));
                    }
                    else
                    {
                      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Lodgement[index4].SAP.EIBand = calc2012.Calculation.CO2_Emissions_12a.EIBand;
                      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Lodgement[index4].SAP.EIRating = checked ((int) Math.Round(calc2012.Calculation.CO2_Emissions_12a.Box274));
                      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Lodgement[index4].PSAP.EIBand = SAP_Module.CalculationImprove2012.Calculation.CO2_Emissions_12a.EIBand;
                      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Lodgement[index4].PSAP.EIRating = checked ((int) Math.Round(SAP_Module.CalculationImprove2012.Calculation.CO2_Emissions_12a.Box274));
                    }
                  }
                  else
                    str1 = str1 + str2 + "\r\n";
                  if (flag2)
                  {
                    MyProject.Forms.Lodgement_Result.lblSuccess.Text = "Lodgement Failed. Please view history to see error message(s).";
                    MyProject.Forms.Lodgement_Result.grpFail.Visible = true;
                    MyProject.Forms.Lodgement_Result.grpSuccess.Visible = false;
                    MyProject.Forms.Lodgement_Result.txtResult.Visible = true;
                    SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Lodgement[index4].Result = "Failed  " + str1;
                    TextBox txtResult;
                    string str4 = (txtResult = MyProject.Forms.Lodgement_Result.txtResult).Text + "Please see history for more details. \r\n";
                    txtResult.Text = str4;
                    SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Lodgement[index4].DateLodged = DateAndTime.Now;
                    SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Lodgement[index4].Success = false;
                    MyProject.Forms.Lodgement_Result.cmdOnlineSM.Visible = true;
                    if (calc2012.Calculation.SAP_rating_11a.SAPRating == 0.0)
                    {
                      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Lodgement[index4].SAP.SAPBand = calc2012.Calculation.SAP_rating_11b.SAPBand;
                      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Lodgement[index4].SAP.SAPRating = checked ((int) Math.Round(calc2012.Calculation.SAP_rating_11b.SAPRating));
                      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Lodgement[index4].PSAP.SAPRating = checked ((int) Math.Round(SAP_Module.CalculationImprove2012.Calculation.SAP_rating_11b.SAPRating));
                      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Lodgement[index4].PSAP.SAPBand = SAP_Module.CalculationImprove2012.Calculation.SAP_rating_11b.SAPBand;
                    }
                    else
                    {
                      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Lodgement[index4].SAP.SAPBand = calc2012.Calculation.SAP_rating_11a.SAPBand;
                      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Lodgement[index4].SAP.SAPRating = checked ((int) Math.Round(calc2012.Calculation.SAP_rating_11a.SAPRating));
                      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Lodgement[index4].PSAP.SAPRating = checked ((int) Math.Round(SAP_Module.CalculationImprove2012.Calculation.SAP_rating_11a.SAPRating));
                      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Lodgement[index4].PSAP.SAPBand = SAP_Module.CalculationImprove2012.Calculation.SAP_rating_11a.SAPBand;
                    }
                    if (calc2012.Calculation.CO2_Emissions_12a.EIValue == 0.0)
                    {
                      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Lodgement[index4].SAP.EIBand = calc2012.Calculation.CO2_Emissions_12b.EIBand;
                      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Lodgement[index4].SAP.EIRating = checked ((int) Math.Round(calc2012.Calculation.CO2_Emissions_12b.EIRating));
                      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Lodgement[index4].PSAP.EIBand = SAP_Module.CalculationImprove2012.Calculation.CO2_Emissions_12b.EIBand;
                      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Lodgement[index4].PSAP.EIRating = checked ((int) Math.Round(SAP_Module.CalculationImprove2012.Calculation.CO2_Emissions_12b.EIRating));
                    }
                    else
                    {
                      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Lodgement[index4].SAP.EIBand = calc2012.Calculation.CO2_Emissions_12a.EIBand;
                      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Lodgement[index4].SAP.EIRating = checked ((int) Math.Round(calc2012.Calculation.CO2_Emissions_12a.Box274));
                      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Lodgement[index4].PSAP.EIBand = SAP_Module.CalculationImprove2012.Calculation.CO2_Emissions_12a.EIBand;
                      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Lodgement[index4].PSAP.EIRating = checked ((int) Math.Round(SAP_Module.CalculationImprove2012.Calculation.CO2_Emissions_12a.Box274));
                    }
                  }
                }
                catch (Exception ex)
                {
                  ProjectData.SetProjectError(ex);
                  Exception exception = ex;
                  MyProject.Forms.Lodgement_Result.txtResult.Visible = true;
                  MyProject.Forms.Lodgement_Result.lblSuccess.Text = "Lodgement Failed. Please view history to see error message(s).";
                  MyProject.Forms.Lodgement_Result.ImgSuccess.Visible = false;
                  MyProject.Forms.Lodgement_Result.grpFail.Visible = true;
                  MyProject.Forms.Lodgement_Result.grpSuccess.Visible = false;
                  MyProject.Forms.Lodgement_Result.cmdOnlineSM.Visible = true;
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Lodgement[index4].Result = "Failed  " + exception.Message;
                  MyProject.Forms.Lodgement_Result.txtResult.Text = Information.Err().Description + " " + exception.Message + "\r\n" + exception.Message;
                  this.Close();
                  ProjectData.ClearProjectError();
                }
                Functions.SaveFile(SAP_Module.Proj, SAP_Module.Proj.SaveFileName);
                this.Single_Lodge_Btn.Enabled = true;
                PDFFunctions.Draft_PDF = true;
                MyProject.Forms.Lodgement_Result.Show();
              }
            }
          }
        }
      }
    }

    private void cmdLodgeAll_Click(object sender, EventArgs e)
    {
      PDFFunctions.Draft_PDF = true;
      this.Close();
    }

    private void DraftEPC()
    {
      this.Single_Lodge_Btn.Visible = true;
      this.ChkAllow.Visible = true;
      this.Cursor = Cursors.WaitCursor;
      Application.DoEvents();
      this.WebBrowser1.Navigate("");
      this.WebBrowser1.Visible = false;
      if (File.Exists(SAP_Module.SAPEPCName))
        File.Delete(SAP_Module.SAPEPCName);
      this.lblMessage.Visible = false;
      CreatePDF createPdf = new CreatePDF();
      CreatePDF.DraftDetails draftDetails = new CreatePDF.DraftDetails();
      int num1 = 1;
      if (Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Address.Country, "Wales", false) == 0)
        num1 = 2;
      if (Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Address.Country, "Scotland", false) == 0)
        num1 = 4;
      if (Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Address.Country, "Scotland", false) == 0)
      {
        this.WebBrowser1.Visible = true;
        this.PictureBox1.Visible = false;
        CreatePDF.DraftDetails draft = createPdf.CreateDraft(num1);
        if (draft.DraftCrated)
        {
          if (Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Address.Country, "Scotland", false) == 0)
          {
            if (draft.DraftCrated)
            {
              PDFFunctions.DecodeFile(draft.DraftEPC, SAP_Module.ScottishFileName);
              this.WebBrowser1.Navigate(SAP_Module.ScottishFileName);
            }
            else
            {
              if (draft.DraftEPC.Contains("<ErrorCode>ER009</ErrorCode>"))
              {
                int num2 = (int) Interaction.MsgBox((object) ("Invalid EPC Format\r\n\r\n" + draft.DraftEPC), MsgBoxStyle.Critical, (object) "Stroma FSAP 2009 Draft Creation");
              }
              else if (draft.DraftEPC.Contains("<ErrorCode>ER011</ErrorCode>"))
              {
                int num3 = (int) Interaction.MsgBox((object) "Invalid UPRN in EPC", MsgBoxStyle.Critical, (object) "Stroma FSAP 2012 Draft Creation");
              }
              else
              {
                int num4 = (int) Interaction.MsgBox((object) draft.DraftEPC, MsgBoxStyle.Critical, (object) "Stroma FSAP 2012 Draft Creation");
              }
              this.Close();
            }
          }
          else
            this.WebBrowser1.Navigate(draft.Filename);
        }
        else
        {
          int num5 = (int) Interaction.MsgBox((object) "Error Creating draft EPC.", MsgBoxStyle.Critical, (object) "Stroma FSAP 2012 Draft Creation");
        }
      }
      else
      {
        Calc2012 calc2012 = new Calc2012();
        calc2012.SETPCDF(SAP_Module.PCDFData);
        calc2012.Dwelling = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling];
        string sapxml = new XML2012().CreateSAPXML(SAP_Module.CurrDwelling, num1);
        this.WebBrowser1.Visible = true;
        this.PictureBox1.Visible = true;
        DraftRatingProce draftRatingProce = new DraftRatingProce();
        int PotentialRating = 1;
        int CurrRating = SAP_Module.Calculation2012.Calculation.SAP_rating_11a.SAPRating != 0.0 ? checked ((int) Math.Round(SAP_Module.Calculation2012.Calculation.SAP_rating_11a.SAPRating)) : checked ((int) Math.Round(SAP_Module.Calculation2012.Calculation.SAP_rating_11b.SAPRating));
        if (CurrRating < 1)
          CurrRating = 1;
        try
        {
          PotentialRating = SAP_Module.CalculationImprove2012.Calculation.SAP_rating_11a.SAPRating != 0.0 ? checked ((int) Math.Round(SAP_Module.CalculationImprove2012.Calculation.SAP_rating_11a.SAPRating)) : checked ((int) Math.Round(SAP_Module.CalculationImprove2012.Calculation.SAP_rating_11b.SAPRating));
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        if (PotentialRating < 1)
          PotentialRating = 1;
        using (MemoryStream memoryStream = new MemoryStream())
        {
          draftRatingProce.DrawGraph(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Address.Country, CurrRating, PotentialRating).Save((Stream) memoryStream, ImageFormat.Png);
          string base64String = Convert.ToBase64String(memoryStream.ToArray());
          string draftEpc = DraftEpc.GetDraftEpc(sapxml, base64String);
          this.WebBrowser1.Navigate("about:blank");
          this.WebBrowser1.Document.Write(string.Empty);
          this.WebBrowser1.DocumentText = draftEpc;
        }
      }
      this.Cursor = Cursors.Default;
    }

    private byte[] ImagetoBytes(Image image)
    {
      MemoryStream memoryStream = new MemoryStream();
      image.Save((Stream) memoryStream, ImageFormat.Png);
      return memoryStream.ToArray();
    }

    private void cmdDraft_Click(object sender, EventArgs e)
    {
      PDFFunctions.document.Dispose();
      this.DraftEPC();
    }
  }
}
