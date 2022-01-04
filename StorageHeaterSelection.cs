
// Type: SAP2012.StorageHeaterSelection




using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Forms.Integration;

namespace SAP2012
{
  [DesignerGenerated]
  public class StorageHeaterSelection : Form
  {
    private IContainer components;

    public StorageHeaterSelection()
    {
      this.Load += new EventHandler(this.StorageHeaterSelection_Load);
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
      this.cntMain = new ElementHost();
      this.Button1 = new Button();
      this.SuspendLayout();
      this.cntMain.Dock = DockStyle.Top;
      this.cntMain.Location = new System.Drawing.Point(0, 0);
      this.cntMain.Name = "cntMain";
      this.cntMain.Size = new System.Drawing.Size(869, 613);
      this.cntMain.TabIndex = 0;
      this.cntMain.Text = "ElementHost1";
      this.cntMain.Child = (UIElement) null;
      this.Button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.Button1.Cursor = Cursors.Hand;
      this.Button1.Location = new System.Drawing.Point(782, 619);
      this.Button1.Name = "Button1";
      this.Button1.Size = new System.Drawing.Size(75, 23);
      this.Button1.TabIndex = 1;
      this.Button1.Text = "Close";
      this.Button1.UseVisualStyleBackColor = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(869, 654);
      this.Controls.Add((Control) this.Button1);
      this.Controls.Add((Control) this.cntMain);
      this.Name = nameof (StorageHeaterSelection);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Storage Heater Selection";
      this.ResumeLayout(false);
    }

    [field: AccessedThroughProperty("cntMain")]
    internal virtual ElementHost cntMain { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

    private void StorageHeaterSelection_Load(object sender, EventArgs e)
    {
    }

    private void Button1_Click(object sender, EventArgs e) => this.DialogResult = DialogResult.OK;
  }
}
