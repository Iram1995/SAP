
// Type: SAP2012.Splash




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
  public class Splash : Form
  {
    private IContainer components;

    public Splash()
    {
      this.Paint += new PaintEventHandler(this.Splash_Paint);
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Splash));
      this.Timer1 = new Timer(this.components);
      this.SuspendLayout();
      this.Timer1.Enabled = true;
      this.Timer1.Interval = 7000;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.White;
      this.BackgroundImage = (Image) componentResourceManager.GetObject("$this.BackgroundImage");
      this.BackgroundImageLayout = ImageLayout.Stretch;
      this.ClientSize = new Size(500, 351);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Name = nameof (Splash);
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.ResumeLayout(false);
    }

    internal virtual Timer Timer1
    {
      get => this._Timer1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Timer1_Tick);
        Timer timer1_1 = this._Timer1;
        if (timer1_1 != null)
          timer1_1.Tick -= eventHandler;
        this._Timer1 = value;
        Timer timer1_2 = this._Timer1;
        if (timer1_2 == null)
          return;
        timer1_2.Tick += eventHandler;
      }
    }

    private void Timer1_Tick(object sender, EventArgs e)
    {
      MyProject.Forms.SAPForm.Show();
      this.Timer1.Enabled = false;
      this.Enabled = false;
      this.Hide();
    }

    private void Splash_Paint(object sender, PaintEventArgs e)
    {
    }
  }
}
