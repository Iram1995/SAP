
// Type: SAP2012.ConnectionCheck




using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SAP2012
{
  [DesignerGenerated]
  public class ConnectionCheck : Form
  {
    private IContainer components;

    public ConnectionCheck()
    {
      this.Load += new EventHandler(this.ConnectionCheck_Load);
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
      this.MenuStrip1 = new MenuStrip();
      this.BeginTestToolStripMenuItem = new ToolStripMenuItem();
      this.StatusStrip1 = new StatusStrip();
      this.CheckingAlert = new ToolStripStatusLabel();
      this.WebServiceCheck = new Label();
      this.GeneralInternetCheck = new Label();
      this.MenuStrip1.SuspendLayout();
      this.StatusStrip1.SuspendLayout();
      this.SuspendLayout();
      this.MenuStrip1.Items.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.BeginTestToolStripMenuItem
      });
      this.MenuStrip1.Location = new Point(0, 0);
      this.MenuStrip1.Name = "MenuStrip1";
      this.MenuStrip1.Size = new Size(682, 24);
      this.MenuStrip1.TabIndex = 0;
      this.MenuStrip1.Text = "MenuStrip1";
      this.BeginTestToolStripMenuItem.Name = "BeginTestToolStripMenuItem";
      this.BeginTestToolStripMenuItem.Size = new Size(74, 20);
      this.BeginTestToolStripMenuItem.Text = "Begin Test";
      this.StatusStrip1.Items.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.CheckingAlert
      });
      this.StatusStrip1.Location = new Point(0, 344);
      this.StatusStrip1.Name = "StatusStrip1";
      this.StatusStrip1.Size = new Size(682, 22);
      this.StatusStrip1.TabIndex = 1;
      this.StatusStrip1.Text = "StatusStrip1";
      this.CheckingAlert.Name = "CheckingAlert";
      this.CheckingAlert.Size = new Size(135, 17);
      this.CheckingAlert.Text = "Waiting for test to begin";
      this.WebServiceCheck.AutoSize = true;
      this.WebServiceCheck.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.WebServiceCheck.Location = new Point(13, 40);
      this.WebServiceCheck.Name = "WebServiceCheck";
      this.WebServiceCheck.Size = new Size(0, 16);
      this.WebServiceCheck.TabIndex = 2;
      this.GeneralInternetCheck.AutoSize = true;
      this.GeneralInternetCheck.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.GeneralInternetCheck.Location = new Point(13, 64);
      this.GeneralInternetCheck.Name = "GeneralInternetCheck";
      this.GeneralInternetCheck.Size = new Size(0, 16);
      this.GeneralInternetCheck.TabIndex = 3;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(682, 366);
      this.Controls.Add((Control) this.GeneralInternetCheck);
      this.Controls.Add((Control) this.WebServiceCheck);
      this.Controls.Add((Control) this.StatusStrip1);
      this.Controls.Add((Control) this.MenuStrip1);
      this.MainMenuStrip = this.MenuStrip1;
      this.Name = nameof (ConnectionCheck);
      this.Text = "Connection Check";
      this.MenuStrip1.ResumeLayout(false);
      this.MenuStrip1.PerformLayout();
      this.StatusStrip1.ResumeLayout(false);
      this.StatusStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    [field: AccessedThroughProperty("MenuStrip1")]
    internal virtual MenuStrip MenuStrip1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripMenuItem BeginTestToolStripMenuItem
    {
      get => this._BeginTestToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.BeginTestToolStripMenuItem_Click);
        ToolStripMenuItem toolStripMenuItem1 = this._BeginTestToolStripMenuItem;
        if (toolStripMenuItem1 != null)
          toolStripMenuItem1.Click -= eventHandler;
        this._BeginTestToolStripMenuItem = value;
        ToolStripMenuItem toolStripMenuItem2 = this._BeginTestToolStripMenuItem;
        if (toolStripMenuItem2 == null)
          return;
        toolStripMenuItem2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("StatusStrip1")]
    internal virtual StatusStrip StatusStrip1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("CheckingAlert")]
    internal virtual ToolStripStatusLabel CheckingAlert { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("WebServiceCheck")]
    internal virtual Label WebServiceCheck { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GeneralInternetCheck")]
    internal virtual Label GeneralInternetCheck { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private void ConnectionCheck_Load(object sender, EventArgs e)
    {
    }

    private void BeginTestToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (Operators.CompareString(this.InternetCheck(), "Fine", false) == 0)
      {
        this.GeneralInternetCheck.Text = "Connected to Internet via Application";
        this.GeneralInternetCheck.ForeColor = Color.Green;
      }
      else
      {
        this.GeneralInternetCheck.Text = "Connection Error to Internet via Application";
        this.GeneralInternetCheck.ForeColor = Color.Firebrick;
      }
      if (Operators.CompareString(this.StromaService(), "Fine", false) == 0)
      {
        this.WebServiceCheck.Text = "Connected to Stroma Web Service via Application";
        this.WebServiceCheck.ForeColor = Color.Green;
      }
      else
      {
        this.WebServiceCheck.Text = "Connection Error to Stroma Web Service via Application";
        this.WebServiceCheck.ForeColor = Color.Firebrick;
      }
      this.CheckingAlert.Text = "Connection Test Complete";
    }

    public string InternetCheck()
    {
      string str;
      try
      {
        WebRequest.Create("http://google.com").GetResponse();
        str = "Fine";
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        str = "Broke";
        ProjectData.ClearProjectError();
      }
      return str;
    }

    public string StromaService()
    {
      string str;
      try
      {
        WebRequest.Create("http://stromamembers.co.uk/SAP.asmx").GetResponse();
        str = "Fine";
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        str = "Broke";
        ProjectData.ClearProjectError();
      }
      return str;
    }
  }
}
