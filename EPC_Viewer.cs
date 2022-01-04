
// Type: SAP2012.EPC_Viewer




using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SAP2012
{
  [DesignerGenerated]
  public class EPC_Viewer : Form
  {
    private IContainer components;

    public EPC_Viewer()
    {
      this.Load += new EventHandler(this.EPC_Viewer_Load);
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (EPC_Viewer));
      this.EPCViewer = new WebBrowser();
      this.PictureBox1 = new PictureBox();
      ((ISupportInitialize) this.PictureBox1).BeginInit();
      this.SuspendLayout();
      this.EPCViewer.Dock = DockStyle.Fill;
      this.EPCViewer.Location = new Point(0, 0);
      this.EPCViewer.MinimumSize = new Size(20, 20);
      this.EPCViewer.Name = "EPCViewer";
      this.EPCViewer.Size = new Size(756, 658);
      this.EPCViewer.TabIndex = 0;
      this.PictureBox1.BackColor = Color.White;
      this.PictureBox1.Dock = DockStyle.Fill;
      this.PictureBox1.Location = new Point(0, 0);
      this.PictureBox1.Name = "PictureBox1";
      this.PictureBox1.Size = new Size(756, 658);
      this.PictureBox1.TabIndex = 146;
      this.PictureBox1.TabStop = false;
      this.PictureBox1.Visible = false;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(756, 658);
      this.Controls.Add((Control) this.EPCViewer);
      this.Controls.Add((Control) this.PictureBox1);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (EPC_Viewer);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "EPC Viewer";
      ((ISupportInitialize) this.PictureBox1).EndInit();
      this.ResumeLayout(false);
    }

    [field: AccessedThroughProperty("EPCViewer")]
    internal virtual WebBrowser EPCViewer { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("PictureBox1")]
    internal virtual PictureBox PictureBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private void EPC_Viewer_Load(object sender, EventArgs e)
    {
    }
  }
}
