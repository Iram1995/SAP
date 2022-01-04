
// Type: SAP2012.Batch_Results




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
  public class Batch_Results : Form
  {
    private IContainer components;

    public Batch_Results() => this.InitializeComponent();

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
      this.txtResults = new TextBox();
      this.cmdClose = new Button();
      this.lblComplete = new Label();
      this.SuspendLayout();
      this.txtResults.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtResults.Location = new Point(13, 13);
      this.txtResults.Multiline = true;
      this.txtResults.Name = "txtResults";
      this.txtResults.ScrollBars = ScrollBars.Vertical;
      this.txtResults.Size = new Size(349, 461);
      this.txtResults.TabIndex = 0;
      this.cmdClose.BackColor = Color.DarkOliveGreen;
      this.cmdClose.Cursor = Cursors.Hand;
      this.cmdClose.DialogResult = DialogResult.OK;
      this.cmdClose.Enabled = false;
      this.cmdClose.FlatStyle = FlatStyle.Popup;
      this.cmdClose.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.cmdClose.ForeColor = Color.White;
      this.cmdClose.ImageAlign = ContentAlignment.MiddleLeft;
      this.cmdClose.Location = new Point(157, 504);
      this.cmdClose.Name = "cmdClose";
      this.cmdClose.Size = new Size(190, 23);
      this.cmdClose.TabIndex = 136;
      this.cmdClose.Tag = (object) "0";
      this.cmdClose.Text = "Close";
      this.cmdClose.UseVisualStyleBackColor = false;
      this.lblComplete.AutoSize = true;
      this.lblComplete.Font = new Font("Tahoma", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblComplete.ForeColor = Color.Maroon;
      this.lblComplete.Location = new Point(89, 477);
      this.lblComplete.Name = "lblComplete";
      this.lblComplete.Size = new Size(234, 24);
      this.lblComplete.TabIndex = 137;
      this.lblComplete.Text = "Lodgements Complete";
      this.lblComplete.Visible = false;
      this.AutoScaleDimensions = new SizeF(8f, 17f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(374, 539);
      this.Controls.Add((Control) this.lblComplete);
      this.Controls.Add((Control) this.cmdClose);
      this.Controls.Add((Control) this.txtResults);
      this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.Name = nameof (Batch_Results);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Batch Results";
      this.TopMost = true;
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    [field: AccessedThroughProperty("txtResults")]
    internal virtual TextBox txtResults { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button cmdClose
    {
      get => this._cmdClose;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdClose_Click);
        Button cmdClose1 = this._cmdClose;
        if (cmdClose1 != null)
          cmdClose1.Click -= eventHandler;
        this._cmdClose = value;
        Button cmdClose2 = this._cmdClose;
        if (cmdClose2 == null)
          return;
        cmdClose2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("lblComplete")]
    internal virtual Label lblComplete { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private void cmdClose_Click(object sender, EventArgs e) => this.Close();
  }
}
