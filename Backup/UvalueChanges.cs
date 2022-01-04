
// Type: SAP2012.UvalueChanges




using Microsoft.VisualBasic.CompilerServices;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SAP2012
{
  [DesignerGenerated]
  public class UvalueChanges : Form
  {
    private IContainer components;

    public UvalueChanges() => this.InitializeComponent();

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
      this.cmdAddressConfirm = new Button();
      this.TextBox1 = new TextBox();
      this.SuspendLayout();
      this.cmdAddressConfirm.BackColor = Color.LightSlateGray;
      this.cmdAddressConfirm.Cursor = Cursors.Hand;
      this.cmdAddressConfirm.DialogResult = DialogResult.OK;
      this.cmdAddressConfirm.FlatStyle = FlatStyle.Popup;
      this.cmdAddressConfirm.ForeColor = Color.White;
      this.cmdAddressConfirm.Location = new Point(553, 456);
      this.cmdAddressConfirm.Name = "cmdAddressConfirm";
      this.cmdAddressConfirm.Size = new Size(102, 23);
      this.cmdAddressConfirm.TabIndex = 19;
      this.cmdAddressConfirm.Text = "Close";
      this.cmdAddressConfirm.UseVisualStyleBackColor = false;
      this.TextBox1.BorderStyle = BorderStyle.None;
      this.TextBox1.Location = new Point(13, 13);
      this.TextBox1.Multiline = true;
      this.TextBox1.Name = "TextBox1";
      this.TextBox1.ScrollBars = ScrollBars.Vertical;
      this.TextBox1.Size = new Size(642, 437);
      this.TextBox1.TabIndex = 20;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.White;
      this.ClientSize = new Size(667, 491);
      this.Controls.Add((Control) this.TextBox1);
      this.Controls.Add((Control) this.cmdAddressConfirm);
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.Name = nameof (UvalueChanges);
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "U-value Changes";
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    [field: AccessedThroughProperty("cmdAddressConfirm")]
    internal virtual Button cmdAddressConfirm { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("TextBox1")]
    internal virtual TextBox TextBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }
  }
}
