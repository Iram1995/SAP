
// Type: SAP2012.VersionHistroy




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
  public class VersionHistroy : Form
  {
    private IContainer components;

    public VersionHistroy()
    {
      this.Load += new EventHandler(this.VersionHistroy_Load);
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (VersionHistroy));
      this.webhistory = new RichTextBox();
      this.SuspendLayout();
      this.webhistory.Dock = DockStyle.Fill;
      this.webhistory.Location = new Point(0, 0);
      this.webhistory.Name = "webhistory";
      this.webhistory.Size = new Size(785, 558);
      this.webhistory.TabIndex = 0;
      this.webhistory.Text = "";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(785, 558);
      this.Controls.Add((Control) this.webhistory);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (VersionHistroy);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Version Histroy";
      this.TopMost = true;
      this.ResumeLayout(false);
    }

    [field: AccessedThroughProperty("webhistory")]
    internal virtual RichTextBox webhistory { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private void VersionHistroy_Load(object sender, EventArgs e) => this.webhistory.LoadFile(Application.StartupPath + "\\Resources\\Updates.rtf");
  }
}
