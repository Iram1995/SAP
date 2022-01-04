
// Type: SAP2012.Lodgement_Result




using Microsoft.VisualBasic.CompilerServices;
using SAP2012.My;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SAP2012
{
  [DesignerGenerated]
  public class Lodgement_Result : Form
  {
    private IContainer components;

    public Lodgement_Result() => this.InitializeComponent();

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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Lodgement_Result));
      this.Button8 = new Button();
      this.cmdOnlineSM = new Button();
      this.grpFail = new GroupBox();
      this.Label1 = new Label();
      this.btnCopy = new Button();
      this.imgCancel = new PictureBox();
      this.txtResult = new TextBox();
      this.LogoPictureBox = new PictureBox();
      this.grpSuccess = new GroupBox();
      this.PictureBox1 = new PictureBox();
      this.ImgSuccess = new PictureBox();
      this.lblSuccess = new Label();
      this.grpFail.SuspendLayout();
      ((ISupportInitialize) this.imgCancel).BeginInit();
      ((ISupportInitialize) this.LogoPictureBox).BeginInit();
      this.grpSuccess.SuspendLayout();
      ((ISupportInitialize) this.PictureBox1).BeginInit();
      ((ISupportInitialize) this.ImgSuccess).BeginInit();
      this.SuspendLayout();
      this.Button8.BackColor = Color.LightSlateGray;
      this.Button8.Cursor = Cursors.Hand;
      this.Button8.DialogResult = DialogResult.OK;
      this.Button8.FlatStyle = FlatStyle.Popup;
      this.Button8.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button8.ForeColor = Color.White;
      this.Button8.ImageAlign = ContentAlignment.MiddleLeft;
      this.Button8.Location = new Point(451, 249);
      this.Button8.Name = "Button8";
      this.Button8.Size = new Size(172, 33);
      this.Button8.TabIndex = 2;
      this.Button8.Text = "Close";
      this.Button8.UseVisualStyleBackColor = false;
      this.cmdOnlineSM.BackColor = Color.LightSlateGray;
      this.cmdOnlineSM.Cursor = Cursors.Hand;
      this.cmdOnlineSM.DialogResult = DialogResult.OK;
      this.cmdOnlineSM.FlatStyle = FlatStyle.Popup;
      this.cmdOnlineSM.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.cmdOnlineSM.ForeColor = Color.White;
      this.cmdOnlineSM.ImageAlign = ContentAlignment.MiddleLeft;
      this.cmdOnlineSM.Location = new Point(9, 249);
      this.cmdOnlineSM.Name = "cmdOnlineSM";
      this.cmdOnlineSM.Size = new Size(172, 33);
      this.cmdOnlineSM.TabIndex = 5;
      this.cmdOnlineSM.Text = "Lodgement History";
      this.cmdOnlineSM.UseVisualStyleBackColor = false;
      this.grpFail.Controls.Add((Control) this.Label1);
      this.grpFail.Controls.Add((Control) this.btnCopy);
      this.grpFail.Controls.Add((Control) this.imgCancel);
      this.grpFail.Controls.Add((Control) this.txtResult);
      this.grpFail.Controls.Add((Control) this.LogoPictureBox);
      this.grpFail.Location = new Point(3, 12);
      this.grpFail.Name = "grpFail";
      this.grpFail.Size = new Size(620, 213);
      this.grpFail.TabIndex = 6;
      this.grpFail.TabStop = false;
      this.grpFail.Text = "Lodgement Error";
      this.Label1.AutoSize = true;
      this.Label1.Font = new Font("Tahoma", 20.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label1.ForeColor = Color.Red;
      this.Label1.Location = new Point(297, 35);
      this.Label1.Name = "Label1";
      this.Label1.Size = new Size(300, 41);
      this.Label1.TabIndex = 12;
      this.Label1.Text = " Lodgement failed.";
      this.btnCopy.BackColor = Color.LightSlateGray;
      this.btnCopy.Cursor = Cursors.Hand;
      this.btnCopy.DialogResult = DialogResult.OK;
      this.btnCopy.FlatStyle = FlatStyle.Popup;
      this.btnCopy.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnCopy.ForeColor = Color.White;
      this.btnCopy.ImageAlign = ContentAlignment.MiddleLeft;
      this.btnCopy.Location = new Point(539, 182);
      this.btnCopy.Name = "btnCopy";
      this.btnCopy.Size = new Size(72, 23);
      this.btnCopy.TabIndex = 3;
      this.btnCopy.Text = "Copy Text";
      this.btnCopy.UseVisualStyleBackColor = false;
      this.btnCopy.Visible = false;
      this.imgCancel.Image = (Image) componentResourceManager.GetObject("imgCancel.Image");
      this.imgCancel.Location = new Point(234, 88);
      this.imgCancel.Name = "imgCancel";
      this.imgCancel.Size = new Size(56, 56);
      this.imgCancel.SizeMode = PictureBoxSizeMode.AutoSize;
      this.imgCancel.TabIndex = 11;
      this.imgCancel.TabStop = false;
      this.txtResult.BorderStyle = BorderStyle.None;
      this.txtResult.Location = new Point(6, 154);
      this.txtResult.Multiline = true;
      this.txtResult.Name = "txtResult";
      this.txtResult.Size = new Size(605, 51);
      this.txtResult.TabIndex = 0;
      this.LogoPictureBox.ErrorImage = (Image) componentResourceManager.GetObject("LogoPictureBox.ErrorImage");
      this.LogoPictureBox.Image = (Image) componentResourceManager.GetObject("LogoPictureBox.Image");
      this.LogoPictureBox.Location = new Point(6, 14);
      this.LogoPictureBox.Name = "LogoPictureBox";
      this.LogoPictureBox.Size = new Size(218, 134);
      this.LogoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
      this.LogoPictureBox.TabIndex = 8;
      this.LogoPictureBox.TabStop = false;
      this.grpSuccess.Controls.Add((Control) this.PictureBox1);
      this.grpSuccess.Controls.Add((Control) this.ImgSuccess);
      this.grpSuccess.Controls.Add((Control) this.lblSuccess);
      this.grpSuccess.Location = new Point(3, 12);
      this.grpSuccess.Name = "grpSuccess";
      this.grpSuccess.Size = new Size(632, 231);
      this.grpSuccess.TabIndex = 13;
      this.grpSuccess.TabStop = false;
      this.PictureBox1.ErrorImage = (Image) componentResourceManager.GetObject("PictureBox1.ErrorImage");
      this.PictureBox1.Image = (Image) componentResourceManager.GetObject("PictureBox1.Image");
      this.PictureBox1.Location = new Point(9, 19);
      this.PictureBox1.Name = "PictureBox1";
      this.PictureBox1.Size = new Size(218, 134);
      this.PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
      this.PictureBox1.TabIndex = 11;
      this.PictureBox1.TabStop = false;
      this.ImgSuccess.Image = (Image) componentResourceManager.GetObject("ImgSuccess.Image");
      this.ImgSuccess.Location = new Point(238, 105);
      this.ImgSuccess.Name = "ImgSuccess";
      this.ImgSuccess.Size = new Size(48, 48);
      this.ImgSuccess.SizeMode = PictureBoxSizeMode.AutoSize;
      this.ImgSuccess.TabIndex = 10;
      this.ImgSuccess.TabStop = false;
      this.lblSuccess.AutoSize = true;
      this.lblSuccess.Font = new Font("Tahoma", 20.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblSuccess.ForeColor = Color.DarkOliveGreen;
      this.lblSuccess.Location = new Point(0, 156);
      this.lblSuccess.Name = "lblSuccess";
      this.lblSuccess.Size = new Size(759, 41);
      this.lblSuccess.TabIndex = 9;
      this.lblSuccess.Text = "0000-0000-0000-0000-0000 Successfully Lodged";
      this.AutoScaleDimensions = new SizeF(8f, 17f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.White;
      this.ClientSize = new Size(632, 283);
      this.Controls.Add((Control) this.grpSuccess);
      this.Controls.Add((Control) this.grpFail);
      this.Controls.Add((Control) this.cmdOnlineSM);
      this.Controls.Add((Control) this.Button8);
      this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.Name = nameof (Lodgement_Result);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Lodgement Result";
      this.TopMost = true;
      this.grpFail.ResumeLayout(false);
      this.grpFail.PerformLayout();
      ((ISupportInitialize) this.imgCancel).EndInit();
      ((ISupportInitialize) this.LogoPictureBox).EndInit();
      this.grpSuccess.ResumeLayout(false);
      this.grpSuccess.PerformLayout();
      ((ISupportInitialize) this.PictureBox1).EndInit();
      ((ISupportInitialize) this.ImgSuccess).EndInit();
      this.ResumeLayout(false);
    }

    private virtual Button Button8
    {
      get => this._Button8;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button8_Click);
        Button button8_1 = this._Button8;
        if (button8_1 != null)
          button8_1.Click -= eventHandler;
        this._Button8 = value;
        Button button8_2 = this._Button8;
        if (button8_2 == null)
          return;
        button8_2.Click += eventHandler;
      }
    }

    internal virtual Button cmdOnlineSM
    {
      get => this._cmdOnlineSM;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdOnlineSM_Click);
        Button cmdOnlineSm1 = this._cmdOnlineSM;
        if (cmdOnlineSm1 != null)
          cmdOnlineSm1.Click -= eventHandler;
        this._cmdOnlineSM = value;
        Button cmdOnlineSm2 = this._cmdOnlineSM;
        if (cmdOnlineSm2 == null)
          return;
        cmdOnlineSm2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("grpFail")]
    internal virtual GroupBox grpFail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label1")]
    internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private virtual Button btnCopy
    {
      get => this._btnCopy;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnCopy_Click_1);
        Button btnCopy1 = this._btnCopy;
        if (btnCopy1 != null)
          btnCopy1.Click -= eventHandler;
        this._btnCopy = value;
        Button btnCopy2 = this._btnCopy;
        if (btnCopy2 == null)
          return;
        btnCopy2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("imgCancel")]
    internal virtual PictureBox imgCancel { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtResult")]
    internal virtual TextBox txtResult { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("LogoPictureBox")]
    internal virtual PictureBox LogoPictureBox { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("grpSuccess")]
    internal virtual GroupBox grpSuccess { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("PictureBox1")]
    internal virtual PictureBox PictureBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("ImgSuccess")]
    internal virtual PictureBox ImgSuccess { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("lblSuccess")]
    internal virtual Label lblSuccess { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private void Button8_Click(object sender, EventArgs e) => this.Close();

    private void Button1_Click(object sender, EventArgs e) => Clipboard.SetText(this.txtResult.Text);

    private void cmdOnlineSM_Click(object sender, EventArgs e)
    {
      this.Close();
      MyProject.Forms.Lodgement_History.FillHistory();
      int num = (int) MyProject.Forms.Lodgement_History.ShowDialog();
    }

    private void btnCopy_Click(object sender, EventArgs e) => Clipboard.SetText(this.txtResult.Text);

    private void btnCopy_Click_1(object sender, EventArgs e) => Clipboard.SetText(this.txtResult.Text);
  }
}
