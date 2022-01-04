
// Type: SAP2012.Trial




using Microsoft.VisualBasic.CompilerServices;
using SAP2012.My;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SAP2012
{
  [DesignerGenerated]
  public class Trial : Form
  {
    private IContainer components;

    public Trial()
    {
      this.Paint += new PaintEventHandler(this.Trial_Paint);
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
      this.Button1 = new Button();
      this.SuspendLayout();
      this.Button1.FlatStyle = FlatStyle.Flat;
      this.Button1.Location = new Point(506, 177);
      this.Button1.Name = "Button1";
      this.Button1.Size = new Size(75, 23);
      this.Button1.TabIndex = 0;
      this.Button1.Text = "OK";
      this.Button1.UseVisualStyleBackColor = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(662, 212);
      this.Controls.Add((Control) this.Button1);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Name = nameof (Trial);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = nameof (Trial);
      this.TopMost = true;
      this.ResumeLayout(false);
    }

    internal virtual Button Button1
    {
      get => this._Button1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button1_Click);
        Button button1_1 = this._Button1;
        if (button1_1 != null)
          button1_1.Click -= eventHandler;
        this._Button1 = value;
        Button button1_2 = this._Button1;
        if (button1_2 == null)
          return;
        button1_2.Click += eventHandler;
      }
    }

    protected override void OnPaintBackground(PaintEventArgs e)
    {
    }

    private void Trial_Paint(object sender, PaintEventArgs e)
    {
      e.Graphics.FillPie((Brush) new SolidBrush(Color.FromArgb(70, 0, 0, (int) byte.MaxValue)), 0, 0, 100, 100, 180, 90);
      e.Graphics.FillPie((Brush) new SolidBrush(Color.FromArgb(70, 0, 0, (int) byte.MaxValue)), checked (this.Width - 100), 0, 100, 100, 270, 90);
      e.Graphics.FillPie((Brush) new SolidBrush(Color.FromArgb(70, 0, 0, (int) byte.MaxValue)), 0, checked (this.Height - 100), 100, 100, 90, 90);
      e.Graphics.FillPie((Brush) new SolidBrush(Color.FromArgb(70, 0, 0, (int) byte.MaxValue)), checked (this.Width - 100), checked (this.Height - 100), 100, 100, 0, 90);
      e.Graphics.FillRectangle((Brush) new SolidBrush(Color.FromArgb(70, 0, 0, (int) byte.MaxValue)), 50, 0, checked (this.Width - 100), this.Height);
      e.Graphics.FillRectangle((Brush) new SolidBrush(Color.FromArgb(70, 0, 0, (int) byte.MaxValue)), 0, 50, 50, checked (this.Height - 100));
      e.Graphics.FillRectangle((Brush) new SolidBrush(Color.FromArgb(70, 0, 0, (int) byte.MaxValue)), checked (this.Width - 50), 50, 50, checked (this.Height - 100));
      e.Graphics.DrawString("Hello Khawar", new Font("Arial", 9f, FontStyle.Regular), Brushes.Black, 20f, 20f);
    }

    private void Button1_Click(object sender, EventArgs e)
    {
      MyProject.Forms.SAPForm.Enabled = true;
      this.Close();
    }
  }
}
