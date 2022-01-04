
// Type: SAP2012.Block_Name




using Microsoft.VisualBasic.CompilerServices;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SAP2012
{
  [DesignerGenerated]
  public class Block_Name : Form
  {
    private IContainer components;

    public Block_Name() => this.InitializeComponent();

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
      this.txtBlockName = new TextBox();
      this.Label1 = new Label();
      this.cmdBiolerData = new Button();
      this.SuspendLayout();
      this.txtBlockName.Location = new Point(16, 29);
      this.txtBlockName.Name = "txtBlockName";
      this.txtBlockName.Size = new Size(188, 21);
      this.txtBlockName.TabIndex = 0;
      this.Label1.AutoSize = true;
      this.Label1.Location = new Point(13, 13);
      this.Label1.Name = "Label1";
      this.Label1.Size = new Size(90, 13);
      this.Label1.TabIndex = 1;
      this.Label1.Text = "Enter Block Name";
      this.cmdBiolerData.BackColor = Color.LightSlateGray;
      this.cmdBiolerData.Cursor = Cursors.Hand;
      this.cmdBiolerData.DialogResult = DialogResult.OK;
      this.cmdBiolerData.FlatStyle = FlatStyle.Popup;
      this.cmdBiolerData.ForeColor = Color.White;
      this.cmdBiolerData.Location = new Point(16, 56);
      this.cmdBiolerData.Name = "cmdBiolerData";
      this.cmdBiolerData.Size = new Size(188, 29);
      this.cmdBiolerData.TabIndex = 18;
      this.cmdBiolerData.Text = "New Block";
      this.cmdBiolerData.UseVisualStyleBackColor = false;
      this.AcceptButton = (IButtonControl) this.cmdBiolerData;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(213, 97);
      this.Controls.Add((Control) this.cmdBiolerData);
      this.Controls.Add((Control) this.Label1);
      this.Controls.Add((Control) this.txtBlockName);
      this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.Name = nameof (Block_Name);
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Block Name";
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    [field: AccessedThroughProperty("txtBlockName")]
    internal virtual TextBox txtBlockName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label1")]
    internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("cmdBiolerData")]
    internal virtual Button cmdBiolerData { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }
  }
}
