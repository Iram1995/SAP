
// Type: SAP2012.Updates




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
  public class Updates : Form
  {
    private IContainer components;

    public Updates()
    {
      this.Load += new EventHandler(this.Updates_Load);
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
      this.txtNew = new RichTextBox();
      this.cmdOK = new Button();
      this.SuspendLayout();
      this.txtNew.BackColor = Color.White;
      this.txtNew.BorderStyle = BorderStyle.None;
      this.txtNew.Dock = DockStyle.Fill;
      this.txtNew.Location = new Point(5, 5);
      this.txtNew.Name = "txtNew";
      this.txtNew.ReadOnly = true;
      this.txtNew.Size = new Size(696, 569);
      this.txtNew.TabIndex = 0;
      this.txtNew.Text = "";
      this.cmdOK.BackColor = Color.LightSlateGray;
      this.cmdOK.Cursor = Cursors.Hand;
      this.cmdOK.DialogResult = DialogResult.OK;
      this.cmdOK.FlatStyle = FlatStyle.Popup;
      this.cmdOK.ForeColor = Color.White;
      this.cmdOK.Location = new Point(566, 548);
      this.cmdOK.Name = "cmdOK";
      this.cmdOK.Size = new Size(112, 23);
      this.cmdOK.TabIndex = 19;
      this.cmdOK.Text = "OK";
      this.cmdOK.UseVisualStyleBackColor = false;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.LightSlateGray;
      this.ClientSize = new Size(706, 579);
      this.Controls.Add((Control) this.cmdOK);
      this.Controls.Add((Control) this.txtNew);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Name = nameof (Updates);
      this.Padding = new Padding(5);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = nameof (Updates);
      this.ResumeLayout(false);
    }

    [field: AccessedThroughProperty("txtNew")]
    internal virtual RichTextBox txtNew { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("cmdOK")]
    internal virtual Button cmdOK { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private void Updates_Load(object sender, EventArgs e) => this.txtNew.LoadFile(Application.StartupPath + "\\Resources\\Updates.rtf");
  }
}
