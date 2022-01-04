
// Type: SAP2012.Logo




using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SAP2012
{
  [DesignerGenerated]
  public class Logo : Form
  {
    private IContainer components;

    public Logo()
    {
      this.Load += new EventHandler(this.Logo_Load);
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
      this.PictureBox1 = new PictureBox();
      this.Button4 = new Button();
      this.Button1 = new Button();
      this.Button2 = new Button();
      this.OpenD1 = new OpenFileDialog();
      this.GroupBox2 = new GroupBox();
      this.txtEmail = new TextBox();
      this.Label4 = new Label();
      this.txtPhone = new TextBox();
      this.Label3 = new Label();
      this.txtContactName = new TextBox();
      this.Label2 = new Label();
      this.txtCompanyName = new TextBox();
      this.Label1 = new Label();
      this.chkInclude = new CheckBox();
      this.GroupBox1 = new GroupBox();
      this.Cmdremove = new Button();
      ((ISupportInitialize) this.PictureBox1).BeginInit();
      this.GroupBox2.SuspendLayout();
      this.GroupBox1.SuspendLayout();
      this.SuspendLayout();
      this.PictureBox1.Location = new Point(136, 19);
      this.PictureBox1.Name = "PictureBox1";
      this.PictureBox1.Size = new Size(295, 246);
      this.PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
      this.PictureBox1.TabIndex = 0;
      this.PictureBox1.TabStop = false;
      this.Button4.BackColor = Color.LightSlateGray;
      this.Button4.Cursor = Cursors.Hand;
      this.Button4.FlatStyle = FlatStyle.Popup;
      this.Button4.ForeColor = Color.White;
      this.Button4.Location = new Point(6, 19);
      this.Button4.Name = "Button4";
      this.Button4.Size = new Size(113, 30);
      this.Button4.TabIndex = 22;
      this.Button4.Text = "Browse";
      this.Button4.UseVisualStyleBackColor = false;
      this.Button1.BackColor = Color.LightSlateGray;
      this.Button1.Cursor = Cursors.Hand;
      this.Button1.FlatStyle = FlatStyle.Popup;
      this.Button1.ForeColor = Color.White;
      this.Button1.Location = new Point(6, 55);
      this.Button1.Name = "Button1";
      this.Button1.Size = new Size(113, 24);
      this.Button1.TabIndex = 23;
      this.Button1.Text = "Use Selected Image";
      this.Button1.UseVisualStyleBackColor = false;
      this.Button2.BackColor = Color.LightSlateGray;
      this.Button2.Cursor = Cursors.Hand;
      this.Button2.DialogResult = DialogResult.OK;
      this.Button2.FlatStyle = FlatStyle.Popup;
      this.Button2.ForeColor = Color.White;
      this.Button2.Location = new Point(318, 438);
      this.Button2.Name = "Button2";
      this.Button2.Size = new Size(113, 32);
      this.Button2.TabIndex = 24;
      this.Button2.Text = "Close";
      this.Button2.UseVisualStyleBackColor = false;
      this.OpenD1.FileName = "OpenFileDialog1";
      this.GroupBox2.Controls.Add((Control) this.txtEmail);
      this.GroupBox2.Controls.Add((Control) this.Label4);
      this.GroupBox2.Controls.Add((Control) this.txtPhone);
      this.GroupBox2.Controls.Add((Control) this.Label3);
      this.GroupBox2.Controls.Add((Control) this.txtContactName);
      this.GroupBox2.Controls.Add((Control) this.Label2);
      this.GroupBox2.Controls.Add((Control) this.txtCompanyName);
      this.GroupBox2.Controls.Add((Control) this.Label1);
      this.GroupBox2.Controls.Add((Control) this.chkInclude);
      this.GroupBox2.Dock = DockStyle.Top;
      this.GroupBox2.Location = new Point(0, 281);
      this.GroupBox2.Name = "GroupBox2";
      this.GroupBox2.Size = new Size(444, 155);
      this.GroupBox2.TabIndex = 27;
      this.GroupBox2.TabStop = false;
      this.GroupBox2.Text = "Personal Details";
      this.txtEmail.Location = new Point(154, 121);
      this.txtEmail.Name = "txtEmail";
      this.txtEmail.Size = new Size(277, 21);
      this.txtEmail.TabIndex = 8;
      this.Label4.AutoSize = true;
      this.Label4.Location = new Point(13, 129);
      this.Label4.Name = "Label4";
      this.Label4.Size = new Size(114, 13);
      this.Label4.TabIndex = 7;
      this.Label4.Text = "Contact Email Address";
      this.txtPhone.Location = new Point(154, 94);
      this.txtPhone.Name = "txtPhone";
      this.txtPhone.Size = new Size(277, 21);
      this.txtPhone.TabIndex = 6;
      this.Label3.AutoSize = true;
      this.Label3.Location = new Point(13, 102);
      this.Label3.Name = "Label3";
      this.Label3.Size = new Size(118, 13);
      this.Label3.TabIndex = 5;
      this.Label3.Text = "Contact Phone Number";
      this.txtContactName.Location = new Point(154, 67);
      this.txtContactName.Name = "txtContactName";
      this.txtContactName.Size = new Size(277, 21);
      this.txtContactName.TabIndex = 4;
      this.Label2.AutoSize = true;
      this.Label2.Location = new Point(13, 75);
      this.Label2.Name = "Label2";
      this.Label2.Size = new Size(75, 13);
      this.Label2.TabIndex = 3;
      this.Label2.Text = "Contact Name";
      this.txtCompanyName.Location = new Point(154, 40);
      this.txtCompanyName.Name = "txtCompanyName";
      this.txtCompanyName.Size = new Size(277, 21);
      this.txtCompanyName.TabIndex = 2;
      this.Label1.AutoSize = true;
      this.Label1.Location = new Point(13, 48);
      this.Label1.Name = "Label1";
      this.Label1.Size = new Size(82, 13);
      this.Label1.TabIndex = 1;
      this.Label1.Text = "Company Name";
      this.chkInclude.AutoSize = true;
      this.chkInclude.Cursor = Cursors.Hand;
      this.chkInclude.Location = new Point(13, 21);
      this.chkInclude.Name = "chkInclude";
      this.chkInclude.Size = new Size(207, 17);
      this.chkInclude.TabIndex = 0;
      this.chkInclude.Text = "Include these details on each printout";
      this.chkInclude.UseVisualStyleBackColor = true;
      this.GroupBox1.Controls.Add((Control) this.Button4);
      this.GroupBox1.Controls.Add((Control) this.PictureBox1);
      this.GroupBox1.Controls.Add((Control) this.Button1);
      this.GroupBox1.Dock = DockStyle.Top;
      this.GroupBox1.Location = new Point(0, 0);
      this.GroupBox1.Name = "GroupBox1";
      this.GroupBox1.Size = new Size(444, 281);
      this.GroupBox1.TabIndex = 28;
      this.GroupBox1.TabStop = false;
      this.GroupBox1.Text = nameof (Logo);
      this.Cmdremove.BackColor = Color.LightSlateGray;
      this.Cmdremove.Cursor = Cursors.Hand;
      this.Cmdremove.DialogResult = DialogResult.OK;
      this.Cmdremove.FlatStyle = FlatStyle.Popup;
      this.Cmdremove.ForeColor = Color.White;
      this.Cmdremove.Location = new Point(12, 442);
      this.Cmdremove.Name = "Cmdremove";
      this.Cmdremove.Size = new Size(113, 32);
      this.Cmdremove.TabIndex = 30;
      this.Cmdremove.Text = "Remove Details";
      this.Cmdremove.UseVisualStyleBackColor = false;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.White;
      this.ClientSize = new Size(444, 472);
      this.Controls.Add((Control) this.Cmdremove);
      this.Controls.Add((Control) this.GroupBox2);
      this.Controls.Add((Control) this.GroupBox1);
      this.Controls.Add((Control) this.Button2);
      this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.Name = nameof (Logo);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = nameof (Logo);
      ((ISupportInitialize) this.PictureBox1).EndInit();
      this.GroupBox2.ResumeLayout(false);
      this.GroupBox2.PerformLayout();
      this.GroupBox1.ResumeLayout(false);
      this.ResumeLayout(false);
    }

    [field: AccessedThroughProperty("PictureBox1")]
    internal virtual PictureBox PictureBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

    [field: AccessedThroughProperty("OpenD1")]
    internal virtual OpenFileDialog OpenD1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox2")]
    internal virtual GroupBox GroupBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtEmail")]
    internal virtual TextBox txtEmail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label4")]
    internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtPhone")]
    internal virtual TextBox txtPhone { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label3")]
    internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtContactName")]
    internal virtual TextBox txtContactName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label2")]
    internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtCompanyName")]
    internal virtual TextBox txtCompanyName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label1")]
    internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chkInclude")]
    internal virtual CheckBox chkInclude { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox1")]
    internal virtual GroupBox GroupBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Cmdremove
    {
      get => this._Cmdremove;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Cmdremove_Click);
        Button cmdremove1 = this._Cmdremove;
        if (cmdremove1 != null)
          cmdremove1.Click -= eventHandler;
        this._Cmdremove = value;
        Button cmdremove2 = this._Cmdremove;
        if (cmdremove2 == null)
          return;
        cmdremove2.Click += eventHandler;
      }
    }

    private void Button4_Click(object sender, EventArgs e)
    {
      this.OpenD1.FileName = "";
      this.OpenD1.Filter = "Image Files (*.jpg)|*.jpg|(*.png)|*.png|(*.bmp)|*.bmp";
      int num = (int) this.OpenD1.ShowDialog();
      string fileName = this.OpenD1.FileName;
      if (string.IsNullOrEmpty(fileName))
        return;
      if (this.PictureBox1.Image != null)
        this.PictureBox1.Image.Dispose();
      this.PictureBox1.Image = Image.FromFile(fileName);
    }

    private void Logo_Load(object sender, EventArgs e)
    {
      string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\Stroma SAP 2012\\";
      if (!Directory.Exists(path))
        Directory.CreateDirectory(path);
      if (File.Exists(path + "Logo.jpg"))
      {
        object Instance = (object) new FileStream(path + "Logo.jpg", FileMode.Open, FileAccess.Read);
        this.PictureBox1.Image = (Image) Image.FromStream((Stream) Instance).Clone();
        NewLateBinding.LateCall(Instance, (System.Type) null, "Flush", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(Instance, (System.Type) null, "Dispose", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null, true);
        NewLateBinding.LateCall(Instance, (System.Type) null, "Close", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null, true);
      }
      if (!string.IsNullOrEmpty(UserSettings.USettings.PrintUserSettings.CompanyName))
        this.txtCompanyName.Text = UserSettings.USettings.PrintUserSettings.CompanyName;
      if (!string.IsNullOrEmpty(UserSettings.USettings.PrintUserSettings.ContactName))
        this.txtContactName.Text = UserSettings.USettings.PrintUserSettings.ContactName;
      if (!string.IsNullOrEmpty(UserSettings.USettings.PrintUserSettings.PhoneNo))
        this.txtPhone.Text = UserSettings.USettings.PrintUserSettings.PhoneNo;
      if (!string.IsNullOrEmpty(UserSettings.USettings.PrintUserSettings.ContactEmail))
        this.txtEmail.Text = UserSettings.USettings.PrintUserSettings.ContactEmail;
      this.chkInclude.Checked = UserSettings.USettings.PrintUserSettings.Print;
    }

    private void Button1_Click(object sender, EventArgs e)
    {
      try
      {
        string str = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\Stroma SAP 2012\\";
        if (File.Exists(str + "Logo.jpg"))
          File.Delete(str + "Logo.jpg");
        try
        {
          object Instance = (object) new FileStream(str + "Logo.jpg", FileMode.Open, FileAccess.Read);
          this.PictureBox1.Image = Image.FromStream((Stream) Instance);
          NewLateBinding.LateCall(Instance, (System.Type) null, "Close", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null, true);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        this.PictureBox1.Image.Save(str + "Logo.jpg");
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      finally
      {
      }
    }

    private void Button2_Click(object sender, EventArgs e)
    {
      UserSettings.USettings.PrintUserSettings.CompanyName = this.txtCompanyName.Text;
      UserSettings.USettings.PrintUserSettings.ContactName = this.txtContactName.Text;
      UserSettings.USettings.PrintUserSettings.PhoneNo = this.txtPhone.Text;
      UserSettings.USettings.PrintUserSettings.ContactEmail = this.txtEmail.Text;
      UserSettings.USettings.PrintUserSettings.Print = this.chkInclude.Checked;
      FileInfo fileInfo = new FileInfo(Conversions.ToString(Operators.ConcatenateObject((object) Environment.GetFolderPath(Environment.SpecialFolder.Personal), (object) "\\Stroma SAP 2012\\Settings.set")));
      UserSettings.SaveSettings(UserSettings.USettings, fileInfo.FullName);
    }

    private void Cmdremove_Click(object sender, EventArgs e)
    {
      try
      {
        UserSettings.USettings.PrintUserSettings.CompanyName = "";
        UserSettings.USettings.PrintUserSettings.ContactName = "";
        UserSettings.USettings.PrintUserSettings.PhoneNo = "";
        UserSettings.USettings.PrintUserSettings.ContactEmail = "";
        UserSettings.USettings.PrintUserSettings.Print = false;
        string str = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\Stroma SAP 2012\\";
        if (!File.Exists(str + "Logo.jpg"))
          return;
        this.PictureBox1.Image = (Image) null;
        try
        {
          object Instance = (object) new FileStream(str + "Logo.jpg", FileMode.Open, FileAccess.Read);
          this.PictureBox1.Image = (Image) Image.FromStream((Stream) Instance).Clone();
          NewLateBinding.LateCall(Instance, (System.Type) null, "Flush", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null, true);
          NewLateBinding.LateCall(Instance, (System.Type) null, "Dispose", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null, true);
          NewLateBinding.LateCall(Instance, (System.Type) null, "Close", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null, true);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        File.Delete(str + "Logo.jpg");
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      finally
      {
      }
    }
  }
}
