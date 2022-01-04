
// Type: SAP2012.Save




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
  public class Save : Form
  {
    private IContainer components;

    public Save() => this.InitializeComponent();

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
      this.OK_Button = new Button();
      this.Cancel_Button = new Button();
      this.cmdSave = new Button();
      this.Label1 = new Label();
      this.SaveFileDialog1 = new SaveFileDialog();
      this.PictureBox1 = new PictureBox();
      ((ISupportInitialize) this.PictureBox1).BeginInit();
      this.SuspendLayout();
      this.OK_Button.Cursor = Cursors.Hand;
      this.OK_Button.Location = new Point(125, 58);
      this.OK_Button.Name = "OK_Button";
      this.OK_Button.Size = new Size(100, 23);
      this.OK_Button.TabIndex = 0;
      this.OK_Button.Text = "Don't Save";
      this.Cancel_Button.Cursor = Cursors.Hand;
      this.Cancel_Button.DialogResult = DialogResult.Cancel;
      this.Cancel_Button.Location = new Point(231, 58);
      this.Cancel_Button.Name = "Cancel_Button";
      this.Cancel_Button.Size = new Size(100, 23);
      this.Cancel_Button.TabIndex = 1;
      this.Cancel_Button.Text = "Cancel";
      this.cmdSave.Cursor = Cursors.Hand;
      this.cmdSave.Location = new Point(21, 58);
      this.cmdSave.Name = "cmdSave";
      this.cmdSave.Size = new Size(100, 23);
      this.cmdSave.TabIndex = 0;
      this.cmdSave.Text = nameof (Save);
      this.Label1.AutoSize = true;
      this.Label1.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label1.Location = new Point(18, 26);
      this.Label1.Name = "Label1";
      this.Label1.Size = new Size(320, 14);
      this.Label1.TabIndex = 2;
      this.Label1.Text = "Do you want to save the changes you made before exit ? ";
      this.PictureBox1.Image = (Image) SAP2012.My.Resources.Resources.info_icon;
      this.PictureBox1.Location = new Point(337, 43);
      this.PictureBox1.Name = "PictureBox1";
      this.PictureBox1.Size = new Size(38, 38);
      this.PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
      this.PictureBox1.TabIndex = 4;
      this.PictureBox1.TabStop = false;
      this.AcceptButton = (IButtonControl) this.OK_Button;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.CancelButton = (IButtonControl) this.Cancel_Button;
      this.ClientSize = new Size(387, 104);
      this.Controls.Add((Control) this.PictureBox1);
      this.Controls.Add((Control) this.cmdSave);
      this.Controls.Add((Control) this.OK_Button);
      this.Controls.Add((Control) this.Label1);
      this.Controls.Add((Control) this.Cancel_Button);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (Save);
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Stroma FSAP 2012";
      ((ISupportInitialize) this.PictureBox1).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    internal virtual Button OK_Button
    {
      get => this._OK_Button;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.OK_Button_Click);
        Button okButton1 = this._OK_Button;
        if (okButton1 != null)
          okButton1.Click -= eventHandler;
        this._OK_Button = value;
        Button okButton2 = this._OK_Button;
        if (okButton2 == null)
          return;
        okButton2.Click += eventHandler;
      }
    }

    internal virtual Button Cancel_Button
    {
      get => this._Cancel_Button;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Cancel_Button_Click);
        Button cancelButton1 = this._Cancel_Button;
        if (cancelButton1 != null)
          cancelButton1.Click -= eventHandler;
        this._Cancel_Button = value;
        Button cancelButton2 = this._Cancel_Button;
        if (cancelButton2 == null)
          return;
        cancelButton2.Click += eventHandler;
      }
    }

    internal virtual Button cmdSave
    {
      get => this._cmdSave;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdSave_Click);
        Button cmdSave1 = this._cmdSave;
        if (cmdSave1 != null)
          cmdSave1.Click -= eventHandler;
        this._cmdSave = value;
        Button cmdSave2 = this._cmdSave;
        if (cmdSave2 == null)
          return;
        cmdSave2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Label1")]
    internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("SaveFileDialog1")]
    internal virtual SaveFileDialog SaveFileDialog1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("PictureBox1")]
    internal virtual PictureBox PictureBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private void OK_Button_Click(object sender, EventArgs e) => this.DialogResult = DialogResult.OK;

    private void Cancel_Button_Click(object sender, EventArgs e) => this.DialogResult = DialogResult.Cancel;

    private void cmdSave_Click(object sender, EventArgs e)
    {
      SAP_Write.SaveDetails();
      string str;
      if (SAP_Module.Proj.SaveFileName != null)
      {
        str = SAP_Module.Proj.SaveFileName;
      }
      else
      {
        this.SaveFileDialog1.Filter = "Stroma SAPs (*.sts2012)|*.sts2012";
        int num = (int) this.SaveFileDialog1.ShowDialog();
        str = this.SaveFileDialog1.FileName;
      }
      if (Operators.CompareString(str, "", false) == 0)
        return;
      SAP_Module.Proj.SaveFileName = str;
      Functions.SaveFile(SAP_Module.Proj, str);
      Functions.AddFile(str);
      this.DialogResult = DialogResult.OK;
    }
  }
}
