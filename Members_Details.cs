
// Type: SAP2012.Members_Details




using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using SAP2012.My;
using SAP2012.SAPRef;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Xml;

namespace SAP2012
{
  [DesignerGenerated]
  public class Members_Details : Form
  {
    private IContainer components;

    public Members_Details()
    {
      this.Load += new EventHandler(this.Members_Details_Load);
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Members_Details));
      this.Label1 = new Label();
      this.txtUser = new TextBox();
      this.txtPassword = new TextBox();
      this.Label2 = new Label();
      this.txtAccNumber = new TextBox();
      this.Label3 = new Label();
      this.txtCompany = new TextBox();
      this.Label4 = new Label();
      this.txtAddress1 = new TextBox();
      this.Label6 = new Label();
      this.txtAddress2 = new TextBox();
      this.Label7 = new Label();
      this.txtAddress3 = new TextBox();
      this.Label8 = new Label();
      this.txtEmail = new TextBox();
      this.Label9 = new Label();
      this.txtFax = new TextBox();
      this.Label10 = new Label();
      this.txtPhone = new TextBox();
      this.Label11 = new Label();
      this.txtPostCode = new TextBox();
      this.Label12 = new Label();
      this.txtTown = new TextBox();
      this.Label13 = new Label();
      this.txtWeb = new TextBox();
      this.Label14 = new Label();
      this.cmdAddressConfirm = new Button();
      this.cmdClose = new Button();
      this.txtSuffix = new TextBox();
      this.Label15 = new Label();
      this.txtSurname = new TextBox();
      this.Label16 = new Label();
      this.txtFirstName = new TextBox();
      this.Label17 = new Label();
      this.txtPrefix = new TextBox();
      this.Label18 = new Label();
      this.PictureBox1 = new PictureBox();
      this.chkSave = new CheckBox();
      this.Panel1 = new Panel();
      this.InsuranceMsg = new Label();
      this.PolicyNio = new TextBox();
      this.Label22 = new Label();
      this.PlLimit = new TextBox();
      this.Label20 = new Label();
      this.eDate = new TextBox();
      this.Label21 = new Label();
      this.Insurer = new TextBox();
      this.Label5 = new Label();
      this.Sdate = new TextBox();
      this.Label19 = new Label();
      this.chkInsurance = new CheckBox();
      ((ISupportInitialize) this.PictureBox1).BeginInit();
      this.Panel1.SuspendLayout();
      this.SuspendLayout();
      this.Label1.AutoSize = true;
      this.Label1.Location = new Point(12, 16);
      this.Label1.Name = "Label1";
      this.Label1.Size = new Size(74, 17);
      this.Label1.TabIndex = 0;
      this.Label1.Text = "User Name";
      this.txtUser.Location = new Point(132, 13);
      this.txtUser.Name = "txtUser";
      this.txtUser.Size = new Size(159, 24);
      this.txtUser.TabIndex = 0;
      this.txtPassword.Location = new Point(132, 40);
      this.txtPassword.Name = "txtPassword";
      this.txtPassword.PasswordChar = '*';
      this.txtPassword.Size = new Size(159, 24);
      this.txtPassword.TabIndex = 1;
      this.Label2.AutoSize = true;
      this.Label2.Location = new Point(12, 43);
      this.Label2.Name = "Label2";
      this.Label2.Size = new Size(66, 17);
      this.Label2.TabIndex = 2;
      this.Label2.Text = "Password";
      this.txtAccNumber.Location = new Point(132, 204);
      this.txtAccNumber.Name = "txtAccNumber";
      this.txtAccNumber.ReadOnly = true;
      this.txtAccNumber.Size = new Size(159, 24);
      this.txtAccNumber.TabIndex = 7;
      this.Label3.AutoSize = true;
      this.Label3.Location = new Point(12, 207);
      this.Label3.Name = "Label3";
      this.Label3.Size = new Size(140, 17);
      this.Label3.TabIndex = 4;
      this.Label3.Text = "Accreditation Number";
      this.txtCompany.Location = new Point(132, 231);
      this.txtCompany.Name = "txtCompany";
      this.txtCompany.ReadOnly = true;
      this.txtCompany.Size = new Size(159, 24);
      this.txtCompany.TabIndex = 8;
      this.Label4.AutoSize = true;
      this.Label4.Location = new Point(12, 234);
      this.Label4.Name = "Label4";
      this.Label4.Size = new Size(68, 17);
      this.Label4.TabIndex = 6;
      this.Label4.Text = "Company";
      this.txtAddress1.Location = new Point(417, 96);
      this.txtAddress1.Name = "txtAddress1";
      this.txtAddress1.ReadOnly = true;
      this.txtAddress1.Size = new Size(159, 24);
      this.txtAddress1.TabIndex = 11;
      this.Label6.AutoSize = true;
      this.Label6.Location = new Point(297, 99);
      this.Label6.Name = "Label6";
      this.Label6.Size = new Size(68, 17);
      this.Label6.TabIndex = 10;
      this.Label6.Text = "Address 1";
      this.txtAddress2.Location = new Point(417, 123);
      this.txtAddress2.Name = "txtAddress2";
      this.txtAddress2.ReadOnly = true;
      this.txtAddress2.Size = new Size(159, 24);
      this.txtAddress2.TabIndex = 12;
      this.Label7.AutoSize = true;
      this.Label7.Location = new Point(297, 126);
      this.Label7.Name = "Label7";
      this.Label7.Size = new Size(68, 17);
      this.Label7.TabIndex = 12;
      this.Label7.Text = "Address 2";
      this.txtAddress3.Location = new Point(417, 150);
      this.txtAddress3.Name = "txtAddress3";
      this.txtAddress3.ReadOnly = true;
      this.txtAddress3.Size = new Size(159, 24);
      this.txtAddress3.TabIndex = 13;
      this.Label8.AutoSize = true;
      this.Label8.Location = new Point(297, 153);
      this.Label8.Name = "Label8";
      this.Label8.Size = new Size(68, 17);
      this.Label8.TabIndex = 14;
      this.Label8.Text = "Address 3";
      this.txtEmail.Location = new Point(417, 231);
      this.txtEmail.Name = "txtEmail";
      this.txtEmail.ReadOnly = true;
      this.txtEmail.Size = new Size(159, 24);
      this.txtEmail.TabIndex = 16;
      this.Label9.AutoSize = true;
      this.Label9.Location = new Point(297, 234);
      this.Label9.Name = "Label9";
      this.Label9.Size = new Size(91, 17);
      this.Label9.TabIndex = 16;
      this.Label9.Text = "Email Address";
      this.txtFax.Location = new Point(132, 285);
      this.txtFax.Name = "txtFax";
      this.txtFax.ReadOnly = true;
      this.txtFax.Size = new Size(159, 24);
      this.txtFax.TabIndex = 10;
      this.Label10.AutoSize = true;
      this.Label10.Location = new Point(12, 288);
      this.Label10.Name = "Label10";
      this.Label10.Size = new Size(30, 17);
      this.Label10.TabIndex = 18;
      this.Label10.Text = "Fax";
      this.txtPhone.Location = new Point(132, 258);
      this.txtPhone.Name = "txtPhone";
      this.txtPhone.ReadOnly = true;
      this.txtPhone.Size = new Size(159, 24);
      this.txtPhone.TabIndex = 9;
      this.Label11.AutoSize = true;
      this.Label11.Location = new Point(12, 261);
      this.Label11.Name = "Label11";
      this.Label11.Size = new Size(47, 17);
      this.Label11.TabIndex = 20;
      this.Label11.Text = "Phone";
      this.txtPostCode.Location = new Point(417, 204);
      this.txtPostCode.Name = "txtPostCode";
      this.txtPostCode.ReadOnly = true;
      this.txtPostCode.Size = new Size(159, 24);
      this.txtPostCode.TabIndex = 15;
      this.Label12.AutoSize = true;
      this.Label12.Location = new Point(297, 207);
      this.Label12.Name = "Label12";
      this.Label12.Size = new Size(71, 17);
      this.Label12.TabIndex = 22;
      this.Label12.Text = "Post Code";
      this.txtTown.Location = new Point(417, 177);
      this.txtTown.Name = "txtTown";
      this.txtTown.ReadOnly = true;
      this.txtTown.Size = new Size(159, 24);
      this.txtTown.TabIndex = 14;
      this.Label13.AutoSize = true;
      this.Label13.Location = new Point(297, 180);
      this.Label13.Name = "Label13";
      this.Label13.Size = new Size(42, 17);
      this.Label13.TabIndex = 24;
      this.Label13.Text = "Town";
      this.txtWeb.Location = new Point(417, 258);
      this.txtWeb.Name = "txtWeb";
      this.txtWeb.ReadOnly = true;
      this.txtWeb.Size = new Size(159, 24);
      this.txtWeb.TabIndex = 17;
      this.Label14.AutoSize = true;
      this.Label14.Location = new Point(297, 261);
      this.Label14.Name = "Label14";
      this.Label14.Size = new Size(89, 17);
      this.Label14.TabIndex = 26;
      this.Label14.Text = "Web Address";
      this.cmdAddressConfirm.BackColor = Color.LightSlateGray;
      this.cmdAddressConfirm.Cursor = Cursors.Hand;
      this.cmdAddressConfirm.FlatStyle = FlatStyle.Popup;
      this.cmdAddressConfirm.ForeColor = Color.White;
      this.cmdAddressConfirm.Location = new Point(132, 67);
      this.cmdAddressConfirm.Name = "cmdAddressConfirm";
      this.cmdAddressConfirm.Size = new Size(159, 23);
      this.cmdAddressConfirm.TabIndex = 2;
      this.cmdAddressConfirm.Text = "Login";
      this.cmdAddressConfirm.UseVisualStyleBackColor = false;
      this.cmdClose.BackColor = Color.LightSlateGray;
      this.cmdClose.Cursor = Cursors.Hand;
      this.cmdClose.DialogResult = DialogResult.OK;
      this.cmdClose.FlatStyle = FlatStyle.Popup;
      this.cmdClose.ForeColor = Color.White;
      this.cmdClose.Location = new Point(417, 285);
      this.cmdClose.Name = "cmdClose";
      this.cmdClose.Size = new Size(159, 23);
      this.cmdClose.TabIndex = 18;
      this.cmdClose.Text = "Close";
      this.cmdClose.UseVisualStyleBackColor = false;
      this.txtSuffix.Location = new Point(132, 177);
      this.txtSuffix.Name = "txtSuffix";
      this.txtSuffix.ReadOnly = true;
      this.txtSuffix.Size = new Size(159, 24);
      this.txtSuffix.TabIndex = 6;
      this.Label15.AutoSize = true;
      this.Label15.Location = new Point(12, 180);
      this.Label15.Name = "Label15";
      this.Label15.Size = new Size(42, 17);
      this.Label15.TabIndex = 30;
      this.Label15.Text = "Suffix";
      this.txtSurname.Location = new Point(132, 150);
      this.txtSurname.Name = "txtSurname";
      this.txtSurname.ReadOnly = true;
      this.txtSurname.Size = new Size(159, 24);
      this.txtSurname.TabIndex = 5;
      this.Label16.AutoSize = true;
      this.Label16.Location = new Point(12, 153);
      this.Label16.Name = "Label16";
      this.Label16.Size = new Size(64, 17);
      this.Label16.TabIndex = 28;
      this.Label16.Text = "SurName";
      this.txtFirstName.Location = new Point(132, 123);
      this.txtFirstName.Name = "txtFirstName";
      this.txtFirstName.ReadOnly = true;
      this.txtFirstName.Size = new Size(159, 24);
      this.txtFirstName.TabIndex = 4;
      this.Label17.AutoSize = true;
      this.Label17.Location = new Point(12, 126);
      this.Label17.Name = "Label17";
      this.Label17.Size = new Size(72, 17);
      this.Label17.TabIndex = 34;
      this.Label17.Text = "First Name";
      this.txtPrefix.Location = new Point(132, 96);
      this.txtPrefix.Name = "txtPrefix";
      this.txtPrefix.ReadOnly = true;
      this.txtPrefix.Size = new Size(159, 24);
      this.txtPrefix.TabIndex = 3;
      this.Label18.AutoSize = true;
      this.Label18.Location = new Point(12, 99);
      this.Label18.Name = "Label18";
      this.Label18.Size = new Size(42, 17);
      this.Label18.TabIndex = 32;
      this.Label18.Text = "Prefix";
      this.PictureBox1.Image = (Image) componentResourceManager.GetObject("PictureBox1.Image");
      this.PictureBox1.Location = new Point(427, 3);
      this.PictureBox1.Name = "PictureBox1";
      this.PictureBox1.Size = new Size(149, 87);
      this.PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
      this.PictureBox1.TabIndex = 35;
      this.PictureBox1.TabStop = false;
      this.chkSave.AutoSize = true;
      this.chkSave.Location = new Point(297, 15);
      this.chkSave.Name = "chkSave";
      this.chkSave.Size = new Size(140, 21);
      this.chkSave.TabIndex = 37;
      this.chkSave.Text = "Save Login Details";
      this.chkSave.UseVisualStyleBackColor = true;
      this.Panel1.Controls.Add((Control) this.InsuranceMsg);
      this.Panel1.Controls.Add((Control) this.PolicyNio);
      this.Panel1.Controls.Add((Control) this.Label22);
      this.Panel1.Controls.Add((Control) this.PlLimit);
      this.Panel1.Controls.Add((Control) this.Label20);
      this.Panel1.Controls.Add((Control) this.eDate);
      this.Panel1.Controls.Add((Control) this.Label21);
      this.Panel1.Controls.Add((Control) this.Insurer);
      this.Panel1.Controls.Add((Control) this.Label5);
      this.Panel1.Controls.Add((Control) this.Sdate);
      this.Panel1.Controls.Add((Control) this.Label19);
      this.Panel1.Controls.Add((Control) this.chkInsurance);
      this.Panel1.Dock = DockStyle.Bottom;
      this.Panel1.Location = new Point(0, 314);
      this.Panel1.Name = "Panel1";
      this.Panel1.Size = new Size(586, 116);
      this.Panel1.TabIndex = 38;
      this.InsuranceMsg.AutoSize = true;
      this.InsuranceMsg.ForeColor = Color.Red;
      this.InsuranceMsg.Location = new Point(12, 10);
      this.InsuranceMsg.Name = "InsuranceMsg";
      this.InsuranceMsg.Size = new Size(0, 17);
      this.InsuranceMsg.TabIndex = 49;
      this.PolicyNio.Location = new Point(415, 19);
      this.PolicyNio.Name = "PolicyNio";
      this.PolicyNio.ReadOnly = true;
      this.PolicyNio.Size = new Size(159, 24);
      this.PolicyNio.TabIndex = 47;
      this.Label22.AutoSize = true;
      this.Label22.Location = new Point(295, 22);
      this.Label22.Name = "Label22";
      this.Label22.Size = new Size(69, 17);
      this.Label22.TabIndex = 48;
      this.Label22.Text = "Policy No:";
      this.PlLimit.Location = new Point(415, 73);
      this.PlLimit.Name = "PlLimit";
      this.PlLimit.ReadOnly = true;
      this.PlLimit.Size = new Size(159, 24);
      this.PlLimit.TabIndex = 44;
      this.Label20.AutoSize = true;
      this.Label20.Location = new Point(297, 73);
      this.Label20.Name = "Label20";
      this.Label20.Size = new Size(55, 17);
      this.Label20.TabIndex = 46;
      this.Label20.Text = "Pl Limit:";
      this.eDate.Location = new Point(415, 46);
      this.eDate.Name = "eDate";
      this.eDate.ReadOnly = true;
      this.eDate.Size = new Size(159, 24);
      this.eDate.TabIndex = 43;
      this.Label21.AutoSize = true;
      this.Label21.Location = new Point(297, 46);
      this.Label21.Name = "Label21";
      this.Label21.Size = new Size(70, 17);
      this.Label21.TabIndex = 45;
      this.Label21.Text = "End Date:";
      this.Insurer.Location = new Point(132, 73);
      this.Insurer.Name = "Insurer";
      this.Insurer.ReadOnly = true;
      this.Insurer.Size = new Size(159, 24);
      this.Insurer.TabIndex = 40;
      this.Label5.AutoSize = true;
      this.Label5.Location = new Point(12, 76);
      this.Label5.Name = "Label5";
      this.Label5.Size = new Size(56, 17);
      this.Label5.TabIndex = 42;
      this.Label5.Text = "Insurer:";
      this.Sdate.Location = new Point(132, 46);
      this.Sdate.Name = "Sdate";
      this.Sdate.ReadOnly = true;
      this.Sdate.Size = new Size(159, 24);
      this.Sdate.TabIndex = 39;
      this.Label19.AutoSize = true;
      this.Label19.Location = new Point(12, 49);
      this.Label19.Name = "Label19";
      this.Label19.Size = new Size(76, 17);
      this.Label19.TabIndex = 41;
      this.Label19.Text = "Start Date:";
      this.chkInsurance.AutoSize = true;
      this.chkInsurance.Location = new Point(15, 92);
      this.chkInsurance.Name = "chkInsurance";
      this.chkInsurance.Size = new Size(90, 21);
      this.chkInsurance.TabIndex = 38;
      this.chkInsurance.Text = "Insurance";
      this.chkInsurance.UseVisualStyleBackColor = true;
      this.chkInsurance.Visible = false;
      this.AutoScaleDimensions = new SizeF(8f, 17f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.White;
      this.ClientSize = new Size(586, 430);
      this.Controls.Add((Control) this.chkSave);
      this.Controls.Add((Control) this.PictureBox1);
      this.Controls.Add((Control) this.Panel1);
      this.Controls.Add((Control) this.txtFirstName);
      this.Controls.Add((Control) this.Label17);
      this.Controls.Add((Control) this.txtPrefix);
      this.Controls.Add((Control) this.Label18);
      this.Controls.Add((Control) this.txtSuffix);
      this.Controls.Add((Control) this.Label15);
      this.Controls.Add((Control) this.txtSurname);
      this.Controls.Add((Control) this.Label16);
      this.Controls.Add((Control) this.cmdClose);
      this.Controls.Add((Control) this.cmdAddressConfirm);
      this.Controls.Add((Control) this.txtWeb);
      this.Controls.Add((Control) this.Label14);
      this.Controls.Add((Control) this.txtTown);
      this.Controls.Add((Control) this.Label13);
      this.Controls.Add((Control) this.txtPostCode);
      this.Controls.Add((Control) this.Label12);
      this.Controls.Add((Control) this.txtPhone);
      this.Controls.Add((Control) this.Label11);
      this.Controls.Add((Control) this.txtFax);
      this.Controls.Add((Control) this.Label10);
      this.Controls.Add((Control) this.txtEmail);
      this.Controls.Add((Control) this.Label9);
      this.Controls.Add((Control) this.txtAddress3);
      this.Controls.Add((Control) this.Label8);
      this.Controls.Add((Control) this.txtAddress2);
      this.Controls.Add((Control) this.Label7);
      this.Controls.Add((Control) this.txtAddress1);
      this.Controls.Add((Control) this.Label6);
      this.Controls.Add((Control) this.txtCompany);
      this.Controls.Add((Control) this.Label4);
      this.Controls.Add((Control) this.txtAccNumber);
      this.Controls.Add((Control) this.Label3);
      this.Controls.Add((Control) this.txtPassword);
      this.Controls.Add((Control) this.Label2);
      this.Controls.Add((Control) this.txtUser);
      this.Controls.Add((Control) this.Label1);
      this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.Name = nameof (Members_Details);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Members Details";
      ((ISupportInitialize) this.PictureBox1).EndInit();
      this.Panel1.ResumeLayout(false);
      this.Panel1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    [field: AccessedThroughProperty("Label1")]
    internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtUser")]
    internal virtual TextBox txtUser { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox txtPassword
    {
      get => this._txtPassword;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtPassword_KeyDown);
        TextBox txtPassword1 = this._txtPassword;
        if (txtPassword1 != null)
          txtPassword1.KeyDown -= keyEventHandler;
        this._txtPassword = value;
        TextBox txtPassword2 = this._txtPassword;
        if (txtPassword2 == null)
          return;
        txtPassword2.KeyDown += keyEventHandler;
      }
    }

    [field: AccessedThroughProperty("Label2")]
    internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtAccNumber")]
    internal virtual TextBox txtAccNumber { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label3")]
    internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtCompany")]
    internal virtual TextBox txtCompany { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label4")]
    internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtAddress1")]
    internal virtual TextBox txtAddress1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label6")]
    internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtAddress2")]
    internal virtual TextBox txtAddress2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label7")]
    internal virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtAddress3")]
    internal virtual TextBox txtAddress3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label8")]
    internal virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtEmail")]
    internal virtual TextBox txtEmail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label9")]
    internal virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtFax")]
    internal virtual TextBox txtFax { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label10")]
    internal virtual Label Label10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtPhone")]
    internal virtual TextBox txtPhone { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label11")]
    internal virtual Label Label11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtPostCode")]
    internal virtual TextBox txtPostCode { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label12")]
    internal virtual Label Label12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtTown")]
    internal virtual TextBox txtTown { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label13")]
    internal virtual Label Label13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtWeb")]
    internal virtual TextBox txtWeb { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label14")]
    internal virtual Label Label14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button cmdAddressConfirm
    {
      get => this._cmdAddressConfirm;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdAddressConfirm_Click);
        Button cmdAddressConfirm1 = this._cmdAddressConfirm;
        if (cmdAddressConfirm1 != null)
          cmdAddressConfirm1.Click -= eventHandler;
        this._cmdAddressConfirm = value;
        Button cmdAddressConfirm2 = this._cmdAddressConfirm;
        if (cmdAddressConfirm2 == null)
          return;
        cmdAddressConfirm2.Click += eventHandler;
      }
    }

    internal virtual Button cmdClose
    {
      get => this._cmdClose;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdClose_Click);
        Button cmdClose1 = this._cmdClose;
        if (cmdClose1 != null)
          cmdClose1.Click -= eventHandler;
        this._cmdClose = value;
        Button cmdClose2 = this._cmdClose;
        if (cmdClose2 == null)
          return;
        cmdClose2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("txtSuffix")]
    internal virtual TextBox txtSuffix { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label15")]
    internal virtual Label Label15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtSurname")]
    internal virtual TextBox txtSurname { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label16")]
    internal virtual Label Label16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtFirstName")]
    internal virtual TextBox txtFirstName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label17")]
    internal virtual Label Label17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtPrefix")]
    internal virtual TextBox txtPrefix { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label18")]
    internal virtual Label Label18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("PictureBox1")]
    internal virtual PictureBox PictureBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chkSave")]
    internal virtual CheckBox chkSave { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Panel1")]
    internal virtual Panel Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("PolicyNio")]
    internal virtual TextBox PolicyNio { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label22")]
    internal virtual Label Label22 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("PlLimit")]
    internal virtual TextBox PlLimit { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label20")]
    internal virtual Label Label20 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("eDate")]
    internal virtual TextBox eDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label21")]
    internal virtual Label Label21 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Insurer")]
    internal virtual TextBox Insurer { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label5")]
    internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Sdate")]
    internal virtual TextBox Sdate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label19")]
    internal virtual Label Label19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chkInsurance")]
    internal virtual CheckBox chkInsurance { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("InsuranceMsg")]
    internal virtual Label InsuranceMsg { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private void cmdAddressConfirm_Click(object sender, EventArgs e)
    {
      XmlDocument xmlDocument = new XmlDocument();
      if (Operators.CompareString(this.txtUser.Text, "", false) == 0 | Operators.CompareString(this.txtPassword.Text, "", false) == 0)
      {
        int num1 = (int) Interaction.MsgBox((object) "Please Complete Username, Password and Accreditation Number", MsgBoxStyle.Information, (object) "Missing Details");
      }
      else
      {
        Functions.Access_Details();
        try
        {
          SAPSoapClient sapSoapClient = new SAPSoapClient();
          if (sapSoapClient.ValidateUser(this.txtUser.Text, Functions.MD5_Hash(this.txtPassword.Text), Functions.TransactionID, Functions.Encrypt))
          {
            xmlDocument.LoadXml(sapSoapClient.HomeInspectorDetailsByUserNamePassword(this.txtUser.Text, MyProject.Forms.SAPForm.MD5_Hash(this.txtPassword.Text), Functions.TransactionID, Functions.Encrypt));
            XmlNode childNode = xmlDocument.DocumentElement.ChildNodes[0];
            this.txtAccNumber.Text = childNode.SelectSingleNode("EACertificateNo").InnerText;
            this.txtPrefix.Text = childNode.SelectSingleNode("Prefix").InnerText;
            this.txtFirstName.Text = childNode.SelectSingleNode("FirstName").InnerText;
            this.txtSurname.Text = childNode.SelectSingleNode("Lastname").InnerText;
            this.txtSuffix.Text = childNode.SelectSingleNode("Suffix").InnerText;
            this.txtCompany.Text = childNode.SelectSingleNode("CompanyName").InnerText;
            this.txtPhone.Text = childNode.SelectSingleNode("Telephone").InnerText;
            this.txtFax.Text = childNode.SelectSingleNode("Fax").InnerText;
            this.txtAddress1.Text = childNode.SelectSingleNode("AddressLine1").InnerText;
            this.txtAddress2.Text = childNode.SelectSingleNode("AddressLine2").InnerText;
            this.txtAddress3.Text = childNode.SelectSingleNode("AddressLine3").InnerText;
            this.txtTown.Text = childNode.SelectSingleNode("postTown").InnerText;
            this.txtPostCode.Text = childNode.SelectSingleNode("Postcode").InnerText;
            this.txtEmail.Text = childNode.SelectSingleNode("Email").InnerText;
            this.txtWeb.Text = childNode.SelectSingleNode("Website").InnerText;
            if (!sapSoapClient.ValidateSAPUser(this.txtUser.Text, Functions.MD5_Hash(this.txtPassword.Text), Functions.TransactionID, Functions.Encrypt))
            {
              int num2 = (int) Interaction.MsgBox((object) "The details are shown below, however you are not registered as a SAP assessor with Stroma", MsgBoxStyle.Critical, (object) "Stroma Certification");
            }
            else
            {
              Validation.UserName = this.txtUser.Text;
              Validation.Password = this.txtPassword.Text;
              Validation.AssessorNO = childNode.SelectSingleNode("EACertificateNo").InnerText;
              Validation.AssessorFN = childNode.SelectSingleNode("FirstName").InnerText;
              Validation.EA_Prefix = childNode.SelectSingleNode("Prefix").InnerText;
              Validation.AssessorLN = childNode.SelectSingleNode("Lastname").InnerText;
              Validation.EA_Suffix = childNode.SelectSingleNode("Suffix").InnerText;
              Validation.AssessorCompany = childNode.SelectSingleNode("CompanyName").InnerText;
              Validation.AssessorPhone = childNode.SelectSingleNode("Telephone").InnerText;
              Validation.AssessorFax = childNode.SelectSingleNode("Fax").InnerText;
              Validation.EA_Address1 = childNode.SelectSingleNode("AddressLine1").InnerText;
              Validation.EA_Address2 = childNode.SelectSingleNode("AddressLine2").InnerText;
              Validation.EA_Address3 = childNode.SelectSingleNode("AddressLine3").InnerText;
              Validation.EA_Town = childNode.SelectSingleNode("postTown").InnerText;
              Validation.EA_Postcode = childNode.SelectSingleNode("Postcode").InnerText;
              Validation.EA_Email = childNode.SelectSingleNode("Email").InnerText;
              Validation.EA_Web = childNode.SelectSingleNode("Website").InnerText;
              Validation.EA_Status = childNode.SelectSingleNode("Status").InnerText;
              Validation.EA_CertificationDate = childNode.SelectSingleNode("CertificationDate").InnerText;
              Validation.UserLogged = true;
              this.InsuranceMsg.Text = "";
              if (Operators.CompareString(Validation.UserName.ToLower(), "saptraining", false) == 0 & Operators.CompareString(Validation.Password, "saptraining", false) == 0)
              {
                SAPInput.TraineeUser = true;
                Validation.Insurance.Include = true;
                Validation.Insurance.PolicyNo = "Stroma";
                Validation.Insurance.Insurer = "Stroma";
                Validation.Insurance.StartDate = "2014-04-06";
                Validation.Insurance.Enddate = "2020-04-06";
                Validation.Insurance.PLLimit = "100000";
              }
              else
                Validation.Insurance = sapSoapClient.CheckInsurance(Validation.AssessorNO, this.txtUser.Text, Functions.MD5_Hash(this.txtPassword.Text), Functions.TransactionID, Functions.Encrypt);
              if (Validation.Insurance.Include)
              {
                this.chkInsurance.Checked = Validation.Insurance.Include;
                this.PolicyNio.Text = Validation.Insurance.PolicyNo;
                this.Insurer.Text = Validation.Insurance.Insurer;
                this.Sdate.Text = Validation.Insurance.StartDate;
                this.eDate.Text = Validation.Insurance.Enddate;
                this.PlLimit.Text = Validation.Insurance.PLLimit;
              }
              else
                this.InsuranceMsg.Text = "Insurance details is missing. You won't be able to do the lodgement.";
              sapImportpermissionclass importpermissionclass1 = new sapImportpermissionclass();
              try
              {
                sapImportpermissionclass importpermissionclass2 = sapSoapClient.Checksapimportpermission(Validation.AssessorNO, this.txtUser.Text, Functions.MD5_Hash(this.txtPassword.Text), Functions.TransactionID, Functions.Encrypt);
                if (importpermissionclass2.Include)
                {
                  if (importpermissionclass2.importtype.Contains("1"))
                    MyProject.Forms.SAPForm.BREXMLImportToolStripMenuItem.Visible = true;
                  if (importpermissionclass2.importtype.Contains("2"))
                    MyProject.Forms.SAPForm.NHERXMLImportToolStripMenuItem.Visible = true;
                  if (importpermissionclass2.importtype.Contains("3"))
                    MyProject.Forms.SAPForm.ExcelImportToolStripMenuItem.Visible = true;
                  if (importpermissionclass2.importtype.Contains("4"))
                    MyProject.Forms.SAPForm.ExcelImportToolStripMenuItem1.Visible = true;
                  if (importpermissionclass2.importtype.Contains("5"))
                    MyProject.Forms.SAPForm.BREXMLImportToolStripMenuItem.Visible = true;
                }
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
            int num3 = (int) Interaction.MsgBox((object) "Details are incorrect, please try again", MsgBoxStyle.Information, (object) "Incorrect Details");
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          Exception exception = ex;
          int num4 = (int) Interaction.MsgBox((object) (exception.InnerException.ToString() + "  " + exception.StackTrace), MsgBoxStyle.Information, (object) "Connection");
          ProjectData.ClearProjectError();
        }
      }
    }

    private void cmdClose_Click(object sender, EventArgs e)
    {
      MySettingsProperty.Settings.AccreditationNo = this.txtAccNumber.Text;
      MySettingsProperty.Settings.Prefix = this.txtPrefix.Text;
      MySettingsProperty.Settings.FirstName = this.txtFirstName.Text;
      MySettingsProperty.Settings.LastName = this.txtSurname.Text;
      MySettingsProperty.Settings.Suffix = this.txtSuffix.Text;
      MySettingsProperty.Settings.Company = this.txtCompany.Text;
      MySettingsProperty.Settings.Phone = this.txtPhone.Text;
      MySettingsProperty.Settings.Fax = this.txtFax.Text;
      Validation.AssessorNO = this.txtAccNumber.Text;
      Validation.AssessorFN = this.txtFirstName.Text;
      Validation.AssessorLN = this.txtSurname.Text;
      Validation.AssessorFax = this.txtFax.Text;
      Validation.AssessorPhone = this.txtPhone.Text;
      Validation.AssessorCompany = this.txtCompany.Text;
      MySettingsProperty.Settings.Address1 = this.txtAddress1.Text;
      MySettingsProperty.Settings.Address2 = this.txtAddress2.Text;
      MySettingsProperty.Settings.Address3 = this.txtAddress3.Text;
      MySettingsProperty.Settings.Town = this.txtTown.Text;
      MySettingsProperty.Settings.PostCode = this.txtPostCode.Text;
      MySettingsProperty.Settings.Email = this.txtEmail.Text;
      MySettingsProperty.Settings.WebAddress = this.txtWeb.Text;
      MySettingsProperty.Settings.Save();
      try
      {
        if (this.chkSave.Checked)
        {
          UserSettings.USettings.Password = this.txtPassword.Text;
          UserSettings.USettings.UserName = this.txtUser.Text;
        }
        else
        {
          UserSettings.USettings.Password = "";
          UserSettings.USettings.UserName = "";
        }
        try
        {
          object folderPath = (object) Environment.GetFolderPath(Environment.SpecialFolder.Personal);
          DirectoryInfo directoryInfo = new DirectoryInfo(Conversions.ToString(Operators.ConcatenateObject(folderPath, (object) "\\Stroma SAP 2012")));
          if (!directoryInfo.Exists)
            directoryInfo.Create();
          FileInfo fileInfo = new FileInfo(Conversions.ToString(Operators.ConcatenateObject(folderPath, (object) "\\Stroma SAP 2012\\Settings.set")));
          UserSettings.SaveSettings(UserSettings.USettings, fileInfo.FullName);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    public void LoadSettings()
    {
      this.txtAccNumber.Text = MySettingsProperty.Settings.AccreditationNo;
      this.txtPrefix.Text = MySettingsProperty.Settings.Prefix;
      this.txtFirstName.Text = MySettingsProperty.Settings.FirstName;
      this.txtSurname.Text = MySettingsProperty.Settings.LastName;
      this.txtSuffix.Text = MySettingsProperty.Settings.Suffix;
      this.txtCompany.Text = MySettingsProperty.Settings.Company;
      this.txtPhone.Text = MySettingsProperty.Settings.Phone;
      this.txtFax.Text = MySettingsProperty.Settings.Fax;
      this.txtAddress1.Text = MySettingsProperty.Settings.Address1;
      this.txtAddress2.Text = MySettingsProperty.Settings.Address2;
      this.txtAddress3.Text = MySettingsProperty.Settings.Address3;
      this.txtTown.Text = MySettingsProperty.Settings.Town;
      this.txtPostCode.Text = MySettingsProperty.Settings.PostCode;
      this.txtEmail.Text = MySettingsProperty.Settings.Email;
      this.txtWeb.Text = MySettingsProperty.Settings.WebAddress;
    }

    private void txtPassword_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return)
        return;
      this.cmdAddressConfirm_Click(RuntimeHelpers.GetObjectValue(sender), (EventArgs) e);
    }

    private void Members_Details_Load(object sender, EventArgs e)
    {
      if (UserSettings.USettings.Password != null)
      {
        if ((uint) Operators.CompareString(UserSettings.USettings.Password, "", false) <= 0U)
          return;
        this.chkSave.Checked = true;
        this.txtPassword.Text = UserSettings.USettings.Password;
        this.txtUser.Text = UserSettings.USettings.UserName;
      }
      else
        this.chkSave.Checked = false;
    }
  }
}
