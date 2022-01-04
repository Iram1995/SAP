
// Type: SAP2012.Htb_Calculator2012




using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
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
  public class Htb_Calculator2012 : Form
  {
    private IContainer components;
    public Htb_Calc Htb_Host;

    public Htb_Calculator2012()
    {
      this.Load += new EventHandler(this.Htb_Calculator2012_Load);
      this.Htb_Host = new Htb_Calc(this);
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
      this.EHost = new ElementHost();
      this.cmdClose = new Button();
      this.Label1 = new Label();
      this.lblTotal = new Label();
      this.SuspendLayout();
      this.EHost.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      this.EHost.Location = new System.Drawing.Point(0, 0);
      this.EHost.Name = "EHost";
      this.EHost.Size = new System.Drawing.Size(784, 660);
      this.EHost.TabIndex = 0;
      this.EHost.Text = "ElementHost1";
      this.EHost.Child = (UIElement) null;
      this.cmdClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.cmdClose.Cursor = Cursors.Hand;
      this.cmdClose.Location = new System.Drawing.Point(709, 664);
      this.cmdClose.Name = "cmdClose";
      this.cmdClose.Size = new System.Drawing.Size(75, 23);
      this.cmdClose.TabIndex = 1;
      this.cmdClose.Text = "Close";
      this.cmdClose.UseVisualStyleBackColor = true;
      this.Label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.Label1.AutoSize = true;
      this.Label1.Font = new Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label1.Location = new System.Drawing.Point(523, 674);
      this.Label1.Name = "Label1";
      this.Label1.Size = new System.Drawing.Size(51, 13);
      this.Label1.TabIndex = 2;
      this.Label1.Text = "Total = ";
      this.lblTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.lblTotal.AutoSize = true;
      this.lblTotal.Font = new Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblTotal.Location = new System.Drawing.Point(574, 679);
      this.lblTotal.Name = "lblTotal";
      this.lblTotal.Size = new System.Drawing.Size(0, 13);
      this.lblTotal.TabIndex = 3;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(784, 723);
      this.Controls.Add((Control) this.lblTotal);
      this.Controls.Add((Control) this.Label1);
      this.Controls.Add((Control) this.cmdClose);
      this.Controls.Add((Control) this.EHost);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (Htb_Calculator2012);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Htb Calculator";
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    [field: AccessedThroughProperty("EHost")]
    internal virtual ElementHost EHost { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

    [field: AccessedThroughProperty("Label1")]
    internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("lblTotal")]
    internal virtual Label lblTotal { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private void Htb_Calculator2012_Load(object sender, EventArgs e)
    {
      this.EHost.Child = (UIElement) this.Htb_Host;
      this.TotalIt();
    }

    public void TotalIt()
    {
      try
      {
        if (this.lblTotal == null)
          return;
        double num = 0.0;
        try
        {
          foreach (SAP_Module.Junction externalJunction in SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.ExternalJunctions)
            num += (double) externalJunction.ThermalTransmittance * (double) externalJunction.Length;
        }
        finally
        {
          List<SAP_Module.Junction>.Enumerator enumerator;
          enumerator.Dispose();
        }
        try
        {
          foreach (SAP_Module.Junction partyJunction in SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.PartyJunctions)
            num += (double) partyJunction.ThermalTransmittance * (double) partyJunction.Length;
        }
        finally
        {
          List<SAP_Module.Junction>.Enumerator enumerator;
          enumerator.Dispose();
        }
        try
        {
          foreach (SAP_Module.Junction roofJunction in SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.RoofJunctions)
            num += (double) roofJunction.ThermalTransmittance * (double) roofJunction.Length;
        }
        finally
        {
          List<SAP_Module.Junction>.Enumerator enumerator;
          enumerator.Dispose();
        }
        this.lblTotal.Text = Conversions.ToString(Math.Round(num, 4)) + " W/m\u00B2K";
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.HtbValue = (float) num;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void cmdClose_Click(object sender, EventArgs e) => this.Close();
  }
}
