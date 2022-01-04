
// Type: SAP2012.About




using Microsoft.VisualBasic.CompilerServices;
using SAP2012.My;
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
  public sealed class About : Form
  {
    private IContainer components;

    public About()
    {
      this.Load += new EventHandler(this.About_Load);
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (About));
      this.OKButton = new Button();
      this.Label1 = new Label();
      this.Label2 = new Label();
      this.Label3 = new Label();
      this.Label4 = new Label();
      this.PictureBox1 = new PictureBox();
      ((ISupportInitialize) this.PictureBox1).BeginInit();
      this.SuspendLayout();
      this.OKButton.BackColor = Color.LightSlateGray;
      this.OKButton.Cursor = Cursors.Hand;
      this.OKButton.DialogResult = DialogResult.Cancel;
      this.OKButton.FlatStyle = FlatStyle.Popup;
      this.OKButton.ForeColor = Color.White;
      this.OKButton.Location = new Point(216, 160);
      this.OKButton.Name = "OKButton";
      this.OKButton.Size = new Size(279, 26);
      this.OKButton.TabIndex = 54;
      this.OKButton.Text = "&OK";
      this.OKButton.UseVisualStyleBackColor = false;
      this.Label1.AutoSize = true;
      this.Label1.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label1.Location = new Point(216, 6);
      this.Label1.Name = "Label1";
      this.Label1.Size = new Size(42, 14);
      this.Label1.TabIndex = 55;
      this.Label1.Text = "Label1";
      this.Label2.AutoSize = true;
      this.Label2.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label2.Location = new Point(216, 36);
      this.Label2.Name = "Label2";
      this.Label2.Size = new Size(42, 14);
      this.Label2.TabIndex = 56;
      this.Label2.Text = "Label2";
      this.Label3.AutoSize = true;
      this.Label3.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label3.Location = new Point(216, 66);
      this.Label3.Name = "Label3";
      this.Label3.Size = new Size(42, 14);
      this.Label3.TabIndex = 57;
      this.Label3.Text = "Label3";
      this.Label4.AutoSize = true;
      this.Label4.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label4.Location = new Point(216, 96);
      this.Label4.Name = "Label4";
      this.Label4.Size = new Size(42, 14);
      this.Label4.TabIndex = 58;
      this.Label4.Text = "Label4";
      this.PictureBox1.BackColor = Color.White;
      this.PictureBox1.Dock = DockStyle.Left;
      this.PictureBox1.Image = (Image) componentResourceManager.GetObject("PictureBox1.Image");
      this.PictureBox1.Location = new Point(2, 2);
      this.PictureBox1.Name = "PictureBox1";
      this.PictureBox1.Size = new Size(208, 200);
      this.PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
      this.PictureBox1.TabIndex = 49;
      this.PictureBox1.TabStop = false;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.White;
      this.ClientSize = new Size(500, 204);
      this.Controls.Add((Control) this.Label4);
      this.Controls.Add((Control) this.Label3);
      this.Controls.Add((Control) this.Label2);
      this.Controls.Add((Control) this.Label1);
      this.Controls.Add((Control) this.OKButton);
      this.Controls.Add((Control) this.PictureBox1);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (About);
      this.Padding = new Padding(2);
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = nameof (About);
      ((ISupportInitialize) this.PictureBox1).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    [field: AccessedThroughProperty("PictureBox1")]
    internal virtual PictureBox PictureBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button OKButton
    {
      get => this._OKButton;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.OKButton_Click_1);
        Button okButton1 = this._OKButton;
        if (okButton1 != null)
          okButton1.Click -= eventHandler;
        this._OKButton = value;
        Button okButton2 = this._OKButton;
        if (okButton2 == null)
          return;
        okButton2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Label1")]
    internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label2")]
    internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label3")]
    internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label4")]
    internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private void About_Load(object sender, EventArgs e)
    {
      this.Text = string.Format("About {0}", (uint) Operators.CompareString(MyProject.Application.Info.Title, "", false) <= 0U ? (object) Path.GetFileNameWithoutExtension(MyProject.Application.Info.AssemblyName) : (object) MyProject.Application.Info.Title);
      this.Label1.Text = "Software Name: " + MyProject.Application.Info.ProductName;
      this.Label2.Text = Debugger.IsAttached ? "Version: Debug Mode" : "Version: " + MyProject.Application.Deployment.CurrentVersion.ToString();
      this.Label3.Text = MyProject.Application.Info.Copyright;
      this.Label4.Text = MyProject.Application.Info.CompanyName;
    }

    private void OKButton_Click_1(object sender, EventArgs e) => this.Close();
  }
}
