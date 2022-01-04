
// Type: SAP2012.XML




using Microsoft.VisualBasic.CompilerServices;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SAP2012
{
  [DesignerGenerated]
  public class XML : Form
  {
    private IContainer components;

    public XML() => this.InitializeComponent();

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
      this.RichTextBox1 = new RichTextBox();
      this.SuspendLayout();
      this.RichTextBox1.Dock = DockStyle.Fill;
      this.RichTextBox1.Location = new Point(0, 0);
      this.RichTextBox1.Name = "RichTextBox1";
      this.RichTextBox1.Size = new Size(717, 645);
      this.RichTextBox1.TabIndex = 0;
      this.RichTextBox1.Text = "";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(717, 645);
      this.Controls.Add((Control) this.RichTextBox1);
      this.Name = nameof (XML);
      this.Text = nameof (XML);
      this.ResumeLayout(false);
    }

    [field: AccessedThroughProperty("RichTextBox1")]
    internal virtual RichTextBox RichTextBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }
  }
}
