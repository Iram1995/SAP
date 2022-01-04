
// Type: SAP2012.Work




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
  public class Work : Form
  {
    private IContainer components;

    public Work()
    {
      this.Load += new EventHandler(this.Work_Load);
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
      this.DG1 = new DataGridView();
      ((ISupportInitialize) this.DG1).BeginInit();
      this.SuspendLayout();
      this.DG1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.DG1.Dock = DockStyle.Fill;
      this.DG1.Location = new Point(0, 0);
      this.DG1.Name = "DG1";
      this.DG1.Size = new Size(727, 669);
      this.DG1.TabIndex = 0;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(727, 669);
      this.Controls.Add((Control) this.DG1);
      this.Name = nameof (Work);
      this.Text = nameof (Work);
      ((ISupportInitialize) this.DG1).EndInit();
      this.ResumeLayout(false);
    }

    [field: AccessedThroughProperty("DG1")]
    internal virtual DataGridView DG1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private void txtCommHB2Fuel_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void txtCommHDS_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void Work_Load(object sender, EventArgs e)
    {
    }
  }
}
