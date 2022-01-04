
// Type: SAP2012.WorkSheetView




using Microsoft.VisualBasic.CompilerServices;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SAP2012
{
  [DesignerGenerated]
  public class WorkSheetView : Form
  {
    private IContainer components;

    public WorkSheetView() => this.InitializeComponent();

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
      this.TabControl1 = new TabControl();
      this.TabPage1 = new TabPage();
      this.TabPage2 = new TabPage();
      this.TabControl1.SuspendLayout();
      this.SuspendLayout();
      this.TabControl1.Controls.Add((Control) this.TabPage1);
      this.TabControl1.Controls.Add((Control) this.TabPage2);
      this.TabControl1.Dock = DockStyle.Fill;
      this.TabControl1.Location = new Point(0, 0);
      this.TabControl1.Name = "TabControl1";
      this.TabControl1.SelectedIndex = 0;
      this.TabControl1.Size = new Size(725, 726);
      this.TabControl1.TabIndex = 0;
      this.TabPage1.Location = new Point(4, 22);
      this.TabPage1.Name = "TabPage1";
      this.TabPage1.Padding = new Padding(3);
      this.TabPage1.Size = new Size(717, 700);
      this.TabPage1.TabIndex = 0;
      this.TabPage1.Text = "TabPage1";
      this.TabPage1.UseVisualStyleBackColor = true;
      this.TabPage2.Location = new Point(4, 22);
      this.TabPage2.Name = "TabPage2";
      this.TabPage2.Padding = new Padding(3);
      this.TabPage2.Size = new Size(717, 700);
      this.TabPage2.TabIndex = 1;
      this.TabPage2.Text = "TabPage2";
      this.TabPage2.UseVisualStyleBackColor = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(725, 726);
      this.Controls.Add((Control) this.TabControl1);
      this.Name = nameof (WorkSheetView);
      this.Text = nameof (WorkSheetView);
      this.TabControl1.ResumeLayout(false);
      this.ResumeLayout(false);
    }

    [field: AccessedThroughProperty("TabControl1")]
    internal virtual TabControl TabControl1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("TabPage1")]
    internal virtual TabPage TabPage1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("TabPage2")]
    internal virtual TabPage TabPage2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }
  }
}
