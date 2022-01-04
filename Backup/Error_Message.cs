
// Type: SAP2012.Error_Message




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
  public class Error_Message : Form
  {
    private IContainer components;

    public Error_Message() => this.InitializeComponent();

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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Error_Message));
      this.Label1 = new Label();
      this.Label2 = new Label();
      this.txtError = new TextBox();
      this.Button1 = new Button();
      this.Button2 = new Button();
      this.SuspendLayout();
      this.Label1.AutoSize = true;
      this.Label1.Location = new Point(13, 13);
      this.Label1.Name = "Label1";
      this.Label1.Size = new Size(379, 91);
      this.Label1.TabIndex = 0;
      this.Label1.Text = componentResourceManager.GetString("Label1.Text");
      this.Label2.AutoSize = true;
      this.Label2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label2.Location = new Point(13, 115);
      this.Label2.Name = "Label2";
      this.Label2.Size = new Size(88, 13);
      this.Label2.TabIndex = 1;
      this.Label2.Text = "Error Message";
      this.txtError.BackColor = Color.White;
      this.txtError.Location = new Point(16, 132);
      this.txtError.Multiline = true;
      this.txtError.Name = "txtError";
      this.txtError.ReadOnly = true;
      this.txtError.ScrollBars = ScrollBars.Vertical;
      this.txtError.Size = new Size(388, 123);
      this.txtError.TabIndex = 2;
      this.Button1.BackColor = Color.LightSlateGray;
      this.Button1.Cursor = Cursors.Hand;
      this.Button1.DialogResult = DialogResult.OK;
      this.Button1.FlatStyle = FlatStyle.Popup;
      this.Button1.ForeColor = Color.White;
      this.Button1.Location = new Point(329, 261);
      this.Button1.Name = "Button1";
      this.Button1.Size = new Size(75, 23);
      this.Button1.TabIndex = 3;
      this.Button1.Text = "Close";
      this.Button1.UseVisualStyleBackColor = false;
      this.Button2.BackColor = Color.LightSlateGray;
      this.Button2.Cursor = Cursors.Hand;
      this.Button2.FlatStyle = FlatStyle.Popup;
      this.Button2.ForeColor = Color.White;
      this.Button2.Location = new Point(16, 261);
      this.Button2.Name = "Button2";
      this.Button2.Size = new Size(75, 23);
      this.Button2.TabIndex = 4;
      this.Button2.Text = "Copy Text";
      this.Button2.UseVisualStyleBackColor = false;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.White;
      this.ClientSize = new Size(412, 289);
      this.Controls.Add((Control) this.Button2);
      this.Controls.Add((Control) this.Button1);
      this.Controls.Add((Control) this.txtError);
      this.Controls.Add((Control) this.Label2);
      this.Controls.Add((Control) this.Label1);
      this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.Name = nameof (Error_Message);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Error Message";
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    [field: AccessedThroughProperty("Label1")]
    internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label2")]
    internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtError")]
    internal virtual TextBox txtError { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Button1")]
    internal virtual Button Button1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button2
    {
      get => this._Button2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button2_Click);
        Button button2_1 = this._Button2;
        if (button2_1 != null)
          button2_1.Click -= eventHandler;
        this._Button2 = value;
        Button button2_2 = this._Button2;
        if (button2_2 == null)
          return;
        button2_2.Click += eventHandler;
      }
    }

    private void Button2_Click(object sender, EventArgs e)
    {
      try
      {
        this.txtError.SelectAll();
        this.txtError.Copy();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }
  }
}
