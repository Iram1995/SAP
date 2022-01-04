
// Type: SAP2012.AddNewAddress




using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using SAP2012.My;
using SAP2012.SAPRef;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SAP2012
{
  [DesignerGenerated]
  public class AddNewAddress : Form
  {
    private IContainer components;

    public AddNewAddress()
    {
      this.Load += new EventHandler(this.AddNewAddress_Load);
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (AddNewAddress));
      this.PAddAddressEW = new Panel();
      this.Button1 = new Button();
      this.Button2 = new Button();
      this.CmdCancel1 = new Button();
      this.TxtAddNotes = new TextBox();
      this.Label20 = new Label();
      this.Label19 = new Label();
      this.txtAddEA = new TextBox();
      this.Label18 = new Label();
      this.txtAddPcode = new TextBox();
      this.Label17 = new Label();
      this.txtAddStreet = new TextBox();
      this.Label16 = new Label();
      this.txtAddLoc = new TextBox();
      this.Label15 = new Label();
      this.txtAddCity = new TextBox();
      this.Label13 = new Label();
      this.txtAddNum = new TextBox();
      this.ErrorProvider1 = new ErrorProvider(this.components);
      this.PAddAddressEW.SuspendLayout();
      ((ISupportInitialize) this.ErrorProvider1).BeginInit();
      this.SuspendLayout();
      this.PAddAddressEW.BackColor = Color.White;
      this.PAddAddressEW.Controls.Add((Control) this.Button1);
      this.PAddAddressEW.Controls.Add((Control) this.Button2);
      this.PAddAddressEW.Controls.Add((Control) this.CmdCancel1);
      this.PAddAddressEW.Controls.Add((Control) this.TxtAddNotes);
      this.PAddAddressEW.Controls.Add((Control) this.Label20);
      this.PAddAddressEW.Controls.Add((Control) this.Label19);
      this.PAddAddressEW.Controls.Add((Control) this.txtAddEA);
      this.PAddAddressEW.Controls.Add((Control) this.Label18);
      this.PAddAddressEW.Controls.Add((Control) this.txtAddPcode);
      this.PAddAddressEW.Controls.Add((Control) this.Label17);
      this.PAddAddressEW.Controls.Add((Control) this.txtAddStreet);
      this.PAddAddressEW.Controls.Add((Control) this.Label16);
      this.PAddAddressEW.Controls.Add((Control) this.txtAddLoc);
      this.PAddAddressEW.Controls.Add((Control) this.Label15);
      this.PAddAddressEW.Controls.Add((Control) this.txtAddCity);
      this.PAddAddressEW.Controls.Add((Control) this.Label13);
      this.PAddAddressEW.Controls.Add((Control) this.txtAddNum);
      this.PAddAddressEW.Dock = DockStyle.Fill;
      this.PAddAddressEW.Location = new Point(0, 0);
      this.PAddAddressEW.Name = "PAddAddressEW";
      this.PAddAddressEW.Size = new Size(450, 300);
      this.PAddAddressEW.TabIndex = 37;
      this.Button1.BackColor = Color.LightSlateGray;
      this.Button1.Cursor = Cursors.Hand;
      this.Button1.DialogResult = DialogResult.OK;
      this.Button1.FlatStyle = FlatStyle.Popup;
      this.Button1.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button1.ForeColor = Color.White;
      this.Button1.ImageAlign = ContentAlignment.MiddleLeft;
      this.Button1.Location = new Point(12, 261);
      this.Button1.Name = "Button1";
      this.Button1.Size = new Size(152, 27);
      this.Button1.TabIndex = 47;
      this.Button1.Tag = (object) "Click here to add a new address on landmark";
      this.Button1.Text = "Add Multiple Addresses";
      this.Button1.UseVisualStyleBackColor = false;
      this.Button1.Visible = false;
      this.Button2.BackColor = Color.LightSlateGray;
      this.Button2.Cursor = Cursors.Hand;
      this.Button2.DialogResult = DialogResult.OK;
      this.Button2.FlatStyle = FlatStyle.Popup;
      this.Button2.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button2.ForeColor = Color.White;
      this.Button2.ImageAlign = ContentAlignment.MiddleLeft;
      this.Button2.Location = new Point(346, 261);
      this.Button2.Name = "Button2";
      this.Button2.Size = new Size(92, 27);
      this.Button2.TabIndex = 7;
      this.Button2.Tag = (object) "Click here to add a new address on landmark";
      this.Button2.Text = "OK";
      this.Button2.UseVisualStyleBackColor = false;
      this.CmdCancel1.BackColor = Color.LightSlateGray;
      this.CmdCancel1.Cursor = Cursors.Hand;
      this.CmdCancel1.DialogResult = DialogResult.Cancel;
      this.CmdCancel1.FlatStyle = FlatStyle.Popup;
      this.CmdCancel1.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.CmdCancel1.ForeColor = Color.White;
      this.CmdCancel1.ImageAlign = ContentAlignment.MiddleLeft;
      this.CmdCancel1.Location = new Point(248, 261);
      this.CmdCancel1.Name = "CmdCancel1";
      this.CmdCancel1.Size = new Size(92, 27);
      this.CmdCancel1.TabIndex = 8;
      this.CmdCancel1.Text = "Cancel";
      this.CmdCancel1.UseVisualStyleBackColor = false;
      this.TxtAddNotes.Font = new Font("Tahoma", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.TxtAddNotes.Location = new Point(177, 186);
      this.TxtAddNotes.Multiline = true;
      this.TxtAddNotes.Name = "TxtAddNotes";
      this.TxtAddNotes.Size = new Size(260, 58);
      this.TxtAddNotes.TabIndex = 6;
      this.TxtAddNotes.Visible = false;
      this.Label20.AutoSize = true;
      this.Label20.Font = new Font("Tahoma", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label20.Location = new Point(12, 189);
      this.Label20.Name = "Label20";
      this.Label20.Size = new Size(43, 17);
      this.Label20.TabIndex = 46;
      this.Label20.Text = "Notes";
      this.Label20.Visible = false;
      this.Label19.AutoSize = true;
      this.Label19.Font = new Font("Tahoma", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label19.Location = new Point(12, 159);
      this.Label19.Name = "Label19";
      this.Label19.Size = new Size(74, 17);
      this.Label19.TabIndex = 45;
      this.Label19.Text = "AssessorID";
      this.Label19.Visible = false;
      this.txtAddEA.Font = new Font("Tahoma", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtAddEA.Location = new Point(177, 156);
      this.txtAddEA.MaxLength = 10;
      this.txtAddEA.Name = "txtAddEA";
      this.txtAddEA.ReadOnly = true;
      this.txtAddEA.Size = new Size(260, 24);
      this.txtAddEA.TabIndex = 5;
      this.txtAddEA.Visible = false;
      this.Label18.AutoSize = true;
      this.Label18.Font = new Font("Tahoma", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label18.Location = new Point(12, 129);
      this.Label18.Name = "Label18";
      this.Label18.Size = new Size(65, 17);
      this.Label18.TabIndex = 43;
      this.Label18.Text = "Postcode";
      this.txtAddPcode.Font = new Font("Tahoma", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtAddPcode.Location = new Point(177, 126);
      this.txtAddPcode.Name = "txtAddPcode";
      this.txtAddPcode.Size = new Size(260, 24);
      this.txtAddPcode.TabIndex = 4;
      this.Label17.AutoSize = true;
      this.Label17.Font = new Font("Tahoma", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label17.Location = new Point(12, 39);
      this.Label17.Name = "Label17";
      this.Label17.Size = new Size(129, 17);
      this.Label17.TabIndex = 41;
      this.Label17.Text = "Street / Road Name";
      this.txtAddStreet.Font = new Font("Tahoma", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtAddStreet.Location = new Point(177, 36);
      this.txtAddStreet.Name = "txtAddStreet";
      this.txtAddStreet.Size = new Size(260, 24);
      this.txtAddStreet.TabIndex = 1;
      this.Label16.AutoSize = true;
      this.Label16.Font = new Font("Tahoma", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label16.Location = new Point(12, 69);
      this.Label16.Name = "Label16";
      this.Label16.Size = new Size(54, 17);
      this.Label16.TabIndex = 39;
      this.Label16.Text = "Locality";
      this.txtAddLoc.Font = new Font("Tahoma", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtAddLoc.Location = new Point(177, 66);
      this.txtAddLoc.Name = "txtAddLoc";
      this.txtAddLoc.Size = new Size(260, 24);
      this.txtAddLoc.TabIndex = 2;
      this.Label15.AutoSize = true;
      this.Label15.Font = new Font("Tahoma", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label15.Location = new Point(12, 99);
      this.Label15.Name = "Label15";
      this.Label15.Size = new Size(79, 17);
      this.Label15.TabIndex = 37;
      this.Label15.Text = "Town / City";
      this.txtAddCity.Font = new Font("Tahoma", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtAddCity.Location = new Point(177, 96);
      this.txtAddCity.Name = "txtAddCity";
      this.txtAddCity.Size = new Size(260, 24);
      this.txtAddCity.TabIndex = 3;
      this.Label13.AutoSize = true;
      this.Label13.Font = new Font("Tahoma", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label13.Location = new Point(12, 9);
      this.Label13.Name = "Label13";
      this.Label13.Size = new Size(113, 17);
      this.Label13.TabIndex = 32;
      this.Label13.Text = "Number or Name";
      this.txtAddNum.Font = new Font("Tahoma", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtAddNum.Location = new Point(177, 6);
      this.txtAddNum.Name = "txtAddNum";
      this.txtAddNum.Size = new Size(260, 24);
      this.txtAddNum.TabIndex = 0;
      this.ErrorProvider1.ContainerControl = (ContainerControl) this;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(450, 300);
      this.Controls.Add((Control) this.PAddAddressEW);
      this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (AddNewAddress);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Manual Address Entry";
      this.TopMost = true;
      this.PAddAddressEW.ResumeLayout(false);
      this.PAddAddressEW.PerformLayout();
      ((ISupportInitialize) this.ErrorProvider1).EndInit();
      this.ResumeLayout(false);
    }

    [field: AccessedThroughProperty("PAddAddressEW")]
    internal virtual Panel PAddAddressEW { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("TxtAddNotes")]
    internal virtual TextBox TxtAddNotes { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label20")]
    internal virtual Label Label20 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label19")]
    internal virtual Label Label19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox txtAddEA
    {
      get => this._txtAddEA;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtAddEA_TextChanged);
        TextBox txtAddEa1 = this._txtAddEA;
        if (txtAddEa1 != null)
          txtAddEa1.TextChanged -= eventHandler;
        this._txtAddEA = value;
        TextBox txtAddEa2 = this._txtAddEA;
        if (txtAddEa2 == null)
          return;
        txtAddEa2.TextChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Label18")]
    internal virtual Label Label18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox txtAddPcode
    {
      get => this._txtAddPcode;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtAddPcode_TextChanged);
        TextBox txtAddPcode1 = this._txtAddPcode;
        if (txtAddPcode1 != null)
          txtAddPcode1.TextChanged -= eventHandler;
        this._txtAddPcode = value;
        TextBox txtAddPcode2 = this._txtAddPcode;
        if (txtAddPcode2 == null)
          return;
        txtAddPcode2.TextChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Label17")]
    internal virtual Label Label17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtAddStreet")]
    internal virtual TextBox txtAddStreet { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label16")]
    internal virtual Label Label16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtAddLoc")]
    internal virtual TextBox txtAddLoc { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label15")]
    internal virtual Label Label15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox txtAddCity
    {
      get => this._txtAddCity;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtAddCity_TextChanged);
        TextBox txtAddCity1 = this._txtAddCity;
        if (txtAddCity1 != null)
          txtAddCity1.TextChanged -= eventHandler;
        this._txtAddCity = value;
        TextBox txtAddCity2 = this._txtAddCity;
        if (txtAddCity2 == null)
          return;
        txtAddCity2.TextChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Label13")]
    internal virtual Label Label13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtAddNum")]
    internal virtual TextBox txtAddNum { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("ErrorProvider1")]
    internal virtual ErrorProvider ErrorProvider1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private virtual Button CmdCancel1
    {
      get => this._CmdCancel1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CmdCancel1_Click);
        Button cmdCancel1_1 = this._CmdCancel1;
        if (cmdCancel1_1 != null)
          cmdCancel1_1.Click -= eventHandler;
        this._CmdCancel1 = value;
        Button cmdCancel1_2 = this._CmdCancel1;
        if (cmdCancel1_2 == null)
          return;
        cmdCancel1_2.Click += eventHandler;
      }
    }

    private virtual Button Button2
    {
      get => this._Button2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button2_Click_1);
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

    public string UPRN { get; set; }

    private void Button4_Click(object sender, EventArgs e) => this.Close();

    private void Button2_Click(object sender, EventArgs e) => this.Close();

    private void txtAddPcode_TextChanged(object sender, EventArgs e)
    {
      if ((uint) Operators.CompareString(this.txtAddPcode.Text, "", false) > 0U)
        this.ErrorProvider1.SetError((Control) this.txtAddEA, "");
      if (new Regex("[A-Z]{1,2}[0-9][0-9A-Za-z]? [0-9][A-Z]{2}").IsMatch(this.txtAddPcode.Text))
        this.txtAddPcode.BackColor = Color.White;
      else
        this.txtAddPcode.BackColor = Color.Red;
    }

    private void AddNewAddress_Load(object sender, EventArgs e) => this.txtAddEA.Text = Validation.AssessorNO;

    private void Button2_Click_1(object sender, EventArgs e)
    {
      int num1 = 0;
      if (!Validation.UserLogged)
      {
        this.ErrorProvider1.SetError((Control) this.txtAddEA, "Please login in order to add new address");
        checked { ++num1; }
      }
      if (Operators.CompareString(this.txtAddEA.Text, "", false) == 0 | Strings.Len(this.txtAddEA.Text) != 10)
      {
        this.ErrorProvider1.SetError((Control) this.txtAddEA, "Please Enter valid Assessor No");
        checked { ++num1; }
      }
      else
      {
        this.txtAddEA.Text = Strings.UCase(this.txtAddEA.Text);
        this.ErrorProvider1.SetError((Control) this.txtAddEA, "");
      }
      if (Operators.CompareString(this.txtAddCity.Text, "", false) == 0)
      {
        this.ErrorProvider1.SetError((Control) this.txtAddCity, "Please Enter valid City (Upper case)");
        checked { ++num1; }
      }
      else
      {
        this.txtAddCity.Text = Strings.UCase(this.txtAddCity.Text);
        this.ErrorProvider1.SetError((Control) this.txtAddCity, "");
      }
      if (Operators.CompareString(this.txtAddPcode.Text, "", false) == 0)
      {
        this.ErrorProvider1.SetError((Control) this.txtAddPcode, "Please Enter valid Postcode");
        checked { ++num1; }
      }
      else
      {
        this.txtAddPcode.Text = Strings.UCase(this.txtAddPcode.Text);
        this.ErrorProvider1.SetError((Control) this.txtAddPcode, "");
      }
      if (num1 > 0)
        return;
      try
      {
        this.UPRN = "UPRN-" + new SAPSoapClient().AddressNewAddressID(new AddressRequest()
        {
          Security = new SecurityClass()
          {
            Encryption = Functions.Encrypt,
            Transaction = Functions.TransactionID
          },
          Selection = new SelectionClass()
          {
            Country = CountryType.England,
            Environment = EnviornmentType.LIVE,
            Assessment = AssessmentType.SAP
          }
        }).ToString("500000000000");
        this.DialogResult = DialogResult.OK;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        int num2 = (int) Interaction.MsgBox((object) (Information.Err().Description + " " + exception.Message));
        ProjectData.ClearProjectError();
      }
    }

    private void txtAddEA_TextChanged(object sender, EventArgs e)
    {
      if ((uint) Operators.CompareString(this.txtAddEA.Text, "", false) <= 0U)
        return;
      this.ErrorProvider1.SetError((Control) this.txtAddEA, "");
    }

    private void txtAddCity_TextChanged(object sender, EventArgs e)
    {
      if ((uint) Operators.CompareString(this.txtAddCity.Text, "", false) <= 0U)
        return;
      this.ErrorProvider1.SetError((Control) this.txtAddCity, "");
    }

    private string MD5_Hash(string SourceText)
    {
      string str;
      try
      {
        byte[] hash = new MD5CryptoServiceProvider().ComputeHash(Encoding.ASCII.GetBytes(SourceText));
        StringBuilder stringBuilder = new StringBuilder(checked ((int) Math.Round(unchecked ((double) checked (hash.Length * 2) + (double) hash.Length / 8.0))));
        int num = checked (hash.Length - 1);
        int startIndex = 0;
        while (startIndex <= num)
        {
          stringBuilder.Append(BitConverter.ToString(hash, startIndex, 1));
          checked { ++startIndex; }
        }
        str = stringBuilder.ToString().TrimEnd(' ').ToLower();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        str = "0";
        ProjectData.ClearProjectError();
      }
      return str;
    }

    private void Button1_Click(object sender, EventArgs e)
    {
      this.DialogResult = DialogResult.Cancel;
      MyProject.Forms.AddAddressForm.Show();
    }

    private void CmdCancel1_Click(object sender, EventArgs e) => this.DialogResult = DialogResult.Cancel;
  }
}
