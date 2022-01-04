
// Type: SAP2012.Batch_Report




using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SAP2012
{
  [DesignerGenerated]
  public class Batch_Report : Form
  {
    private IContainer components;
    private string NewCopy;

    public Batch_Report()
    {
      this.Load += new EventHandler(this.Batch_Report_Load);
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
      this.GroupBox2 = new GroupBox();
      this.cmdAddDwelling = new Button();
      this.lstAllDwellings = new ListBox();
      this.cmdRemoveDwelling = new Button();
      this.lstBlockDwellings = new ListBox();
      this.GroupBox3 = new GroupBox();
      this.GroupBox1 = new GroupBox();
      this.ChkCost = new CheckBox();
      this.ChkThermalBridge = new CheckBox();
      this.ChkTFEE = new CheckBox();
      this.chkFEE = new CheckBox();
      this.Button3 = new Button();
      this.ChkComplinaceSave = new CheckBox();
      this.chkCode = new CheckBox();
      this.Button4 = new Button();
      this.chk10 = new CheckBox();
      this.chk5 = new CheckBox();
      this.chkPredicated = new CheckBox();
      this.chk8 = new CheckBox();
      this.chkOverHeating = new CheckBox();
      this.chkCompliance = new CheckBox();
      this.chkTER = new CheckBox();
      this.chkDER = new CheckBox();
      this.chkSAPWorksheet = new CheckBox();
      this.chkInput = new CheckBox();
      this.Button1 = new Button();
      this.FD1 = new FolderBrowserDialog();
      this.txtLocation = new TextBox();
      this.Label1 = new Label();
      this.cmdLocation = new Button();
      this.GroupBox4 = new GroupBox();
      this.GroupBox5 = new GroupBox();
      this.opt3 = new RadioButton();
      this.opt2 = new RadioButton();
      this.opt1 = new RadioButton();
      this.Button2 = new Button();
      this.PB1 = new ProgressBar();
      this.chkDeveloperrpt = new CheckBox();
      this.GroupBox2.SuspendLayout();
      this.GroupBox3.SuspendLayout();
      this.GroupBox1.SuspendLayout();
      this.GroupBox4.SuspendLayout();
      this.GroupBox5.SuspendLayout();
      this.SuspendLayout();
      this.GroupBox2.Controls.Add((Control) this.cmdAddDwelling);
      this.GroupBox2.Controls.Add((Control) this.lstAllDwellings);
      this.GroupBox2.Location = new Point(12, 12);
      this.GroupBox2.Name = "GroupBox2";
      this.GroupBox2.Size = new Size(290, 267);
      this.GroupBox2.TabIndex = 22;
      this.GroupBox2.TabStop = false;
      this.GroupBox2.Text = "Current Dwellings in Project";
      this.cmdAddDwelling.BackColor = Color.LightSlateGray;
      this.cmdAddDwelling.Cursor = Cursors.Hand;
      this.cmdAddDwelling.Dock = DockStyle.Bottom;
      this.cmdAddDwelling.FlatStyle = FlatStyle.Popup;
      this.cmdAddDwelling.ForeColor = Color.White;
      this.cmdAddDwelling.Location = new Point(3, 241);
      this.cmdAddDwelling.Name = "cmdAddDwelling";
      this.cmdAddDwelling.Size = new Size(284, 23);
      this.cmdAddDwelling.TabIndex = 18;
      this.cmdAddDwelling.Text = "Add ->";
      this.cmdAddDwelling.UseVisualStyleBackColor = false;
      this.lstAllDwellings.Cursor = Cursors.Hand;
      this.lstAllDwellings.Dock = DockStyle.Top;
      this.lstAllDwellings.FormattingEnabled = true;
      this.lstAllDwellings.Location = new Point(3, 17);
      this.lstAllDwellings.Name = "lstAllDwellings";
      this.lstAllDwellings.SelectionMode = SelectionMode.MultiExtended;
      this.lstAllDwellings.Size = new Size(284, 225);
      this.lstAllDwellings.TabIndex = 0;
      this.cmdRemoveDwelling.BackColor = Color.LightSlateGray;
      this.cmdRemoveDwelling.Cursor = Cursors.Hand;
      this.cmdRemoveDwelling.Dock = DockStyle.Bottom;
      this.cmdRemoveDwelling.FlatStyle = FlatStyle.Popup;
      this.cmdRemoveDwelling.ForeColor = Color.White;
      this.cmdRemoveDwelling.Location = new Point(3, 241);
      this.cmdRemoveDwelling.Name = "cmdRemoveDwelling";
      this.cmdRemoveDwelling.Size = new Size(284, 23);
      this.cmdRemoveDwelling.TabIndex = 20;
      this.cmdRemoveDwelling.Text = "<- Remove";
      this.cmdRemoveDwelling.UseVisualStyleBackColor = false;
      this.lstBlockDwellings.Cursor = Cursors.Hand;
      this.lstBlockDwellings.Dock = DockStyle.Top;
      this.lstBlockDwellings.FormattingEnabled = true;
      this.lstBlockDwellings.Location = new Point(3, 17);
      this.lstBlockDwellings.Name = "lstBlockDwellings";
      this.lstBlockDwellings.SelectionMode = SelectionMode.MultiExtended;
      this.lstBlockDwellings.Size = new Size(284, 225);
      this.lstBlockDwellings.TabIndex = 19;
      this.GroupBox3.Controls.Add((Control) this.cmdRemoveDwelling);
      this.GroupBox3.Controls.Add((Control) this.lstBlockDwellings);
      this.GroupBox3.Location = new Point(308, 12);
      this.GroupBox3.Name = "GroupBox3";
      this.GroupBox3.Size = new Size(290, 267);
      this.GroupBox3.TabIndex = 23;
      this.GroupBox3.TabStop = false;
      this.GroupBox3.Text = "Included Dwellings";
      this.GroupBox1.Controls.Add((Control) this.chkDeveloperrpt);
      this.GroupBox1.Controls.Add((Control) this.ChkCost);
      this.GroupBox1.Controls.Add((Control) this.ChkThermalBridge);
      this.GroupBox1.Controls.Add((Control) this.ChkTFEE);
      this.GroupBox1.Controls.Add((Control) this.chkFEE);
      this.GroupBox1.Controls.Add((Control) this.Button3);
      this.GroupBox1.Controls.Add((Control) this.ChkComplinaceSave);
      this.GroupBox1.Controls.Add((Control) this.chkCode);
      this.GroupBox1.Controls.Add((Control) this.Button4);
      this.GroupBox1.Controls.Add((Control) this.chk10);
      this.GroupBox1.Controls.Add((Control) this.chk5);
      this.GroupBox1.Controls.Add((Control) this.chkPredicated);
      this.GroupBox1.Controls.Add((Control) this.chk8);
      this.GroupBox1.Controls.Add((Control) this.chkOverHeating);
      this.GroupBox1.Controls.Add((Control) this.chkCompliance);
      this.GroupBox1.Controls.Add((Control) this.chkTER);
      this.GroupBox1.Controls.Add((Control) this.chkDER);
      this.GroupBox1.Controls.Add((Control) this.chkSAPWorksheet);
      this.GroupBox1.Controls.Add((Control) this.chkInput);
      this.GroupBox1.Location = new Point(12, 286);
      this.GroupBox1.Name = "GroupBox1";
      this.GroupBox1.Size = new Size(290, 339);
      this.GroupBox1.TabIndex = 24;
      this.GroupBox1.TabStop = false;
      this.GroupBox1.Text = "Items to Generate";
      this.ChkCost.AutoSize = true;
      this.ChkCost.Cursor = Cursors.Hand;
      this.ChkCost.Location = new Point(20, 292);
      this.ChkCost.Name = "ChkCost";
      this.ChkCost.Size = new Size(103, 17);
      this.ChkCost.TabIndex = 36;
      this.ChkCost.Text = "Cost Worksheet";
      this.ChkCost.UseVisualStyleBackColor = true;
      this.ChkThermalBridge.AutoSize = true;
      this.ChkThermalBridge.Cursor = Cursors.Hand;
      this.ChkThermalBridge.Location = new Point(20, 216);
      this.ChkThermalBridge.Name = "ChkThermalBridge";
      this.ChkThermalBridge.Size = new Size(97, 17);
      this.ChkThermalBridge.TabIndex = 35;
      this.ChkThermalBridge.Text = "Thermal Bridge";
      this.ChkThermalBridge.UseVisualStyleBackColor = true;
      this.ChkTFEE.AutoSize = true;
      this.ChkTFEE.Cursor = Cursors.Hand;
      this.ChkTFEE.Location = new Point(20, 270);
      this.ChkTFEE.Name = "ChkTFEE";
      this.ChkTFEE.Size = new Size(105, 17);
      this.ChkTFEE.TabIndex = 34;
      this.ChkTFEE.Text = "TFEE Worksheet";
      this.ChkTFEE.UseVisualStyleBackColor = true;
      this.chkFEE.AutoSize = true;
      this.chkFEE.Cursor = Cursors.Hand;
      this.chkFEE.Location = new Point(21, 243);
      this.chkFEE.Name = "chkFEE";
      this.chkFEE.Size = new Size(106, 17);
      this.chkFEE.TabIndex = 31;
      this.chkFEE.Text = "DFEE Worksheet";
      this.chkFEE.UseVisualStyleBackColor = true;
      this.Button3.BackColor = Color.LightSlateGray;
      this.Button3.Cursor = Cursors.Hand;
      this.Button3.FlatStyle = FlatStyle.Popup;
      this.Button3.ForeColor = Color.White;
      this.Button3.Location = new Point(182, 56);
      this.Button3.Name = "Button3";
      this.Button3.Size = new Size(99, 23);
      this.Button3.TabIndex = 29;
      this.Button3.Text = "Select All";
      this.Button3.UseVisualStyleBackColor = false;
      this.ChkComplinaceSave.AutoSize = true;
      this.ChkComplinaceSave.Location = new Point(93, 12);
      this.ChkComplinaceSave.Name = "ChkComplinaceSave";
      this.ChkComplinaceSave.Size = new Size(189, 43);
      this.ChkComplinaceSave.TabIndex = 32;
      this.ChkComplinaceSave.Text = "Remove Watermark by Submitting\r\nReport(s) through to Stroma\r\n(CheckList Only)";
      this.ChkComplinaceSave.UseVisualStyleBackColor = true;
      this.ChkComplinaceSave.Visible = false;
      this.chkCode.AutoSize = true;
      this.chkCode.Cursor = Cursors.Hand;
      this.chkCode.Location = new Point(20, 189);
      this.chkCode.Name = "chkCode";
      this.chkCode.Size = new Size(197, 17);
      this.chkCode.TabIndex = 10;
      this.chkCode.Text = "Code for Sustainable Homes Report";
      this.chkCode.UseVisualStyleBackColor = true;
      this.Button4.BackColor = Color.LightSlateGray;
      this.Button4.Cursor = Cursors.Hand;
      this.Button4.FlatStyle = FlatStyle.Popup;
      this.Button4.ForeColor = Color.White;
      this.Button4.Location = new Point(182, 85);
      this.Button4.Name = "Button4";
      this.Button4.Size = new Size(99, 23);
      this.Button4.TabIndex = 30;
      this.Button4.Text = "Select None";
      this.Button4.UseVisualStyleBackColor = false;
      this.chk10.AutoSize = true;
      this.chk10.Cursor = Cursors.Hand;
      this.chk10.Location = new Point(6, 292);
      this.chk10.Name = "chk10";
      this.chk10.Size = new Size(260, 17);
      this.chk10.TabIndex = 9;
      this.chk10.Text = "Low Carbon Home Certificate (Where Applicable)";
      this.chk10.UseVisualStyleBackColor = true;
      this.chk10.Visible = false;
      this.chk5.AutoSize = true;
      this.chk5.Cursor = Cursors.Hand;
      this.chk5.Location = new Point(147, 220);
      this.chk5.Name = "chk5";
      this.chk5.Size = new Size(169, 17);
      this.chk5.TabIndex = 5;
      this.chk5.Text = "Improved Dwelling Worksheet";
      this.chk5.UseVisualStyleBackColor = true;
      this.chk5.Visible = false;
      this.chkPredicated.AutoSize = true;
      this.chkPredicated.Cursor = Cursors.Hand;
      this.chkPredicated.Location = new Point(20, 162);
      this.chkPredicated.Name = "chkPredicated";
      this.chkPredicated.Size = new Size(168, 17);
      this.chkPredicated.TabIndex = 8;
      this.chkPredicated.Text = "Predicted Energy Assessment";
      this.chkPredicated.UseVisualStyleBackColor = true;
      this.chk8.AutoSize = true;
      this.chk8.Cursor = Cursors.Hand;
      this.chk8.Location = new Point(182, 117);
      this.chk8.Name = "chk8";
      this.chk8.Size = new Size(73, 17);
      this.chk8.TabIndex = 7;
      this.chk8.Text = "Draft EPC";
      this.chk8.UseVisualStyleBackColor = true;
      this.chk8.Visible = false;
      this.chkOverHeating.AutoSize = true;
      this.chkOverHeating.Cursor = Cursors.Hand;
      this.chkOverHeating.Location = new Point(20, 140);
      this.chkOverHeating.Name = "chkOverHeating";
      this.chkOverHeating.Size = new Size(141, 17);
      this.chkOverHeating.TabIndex = 6;
      this.chkOverHeating.Text = "Overheating Calculation";
      this.chkOverHeating.UseVisualStyleBackColor = true;
      this.chkCompliance.AutoSize = true;
      this.chkCompliance.Cursor = Cursors.Hand;
      this.chkCompliance.Location = new Point(21, 25);
      this.chkCompliance.Name = "chkCompliance";
      this.chkCompliance.Size = new Size(71, 17);
      this.chkCompliance.TabIndex = 0;
      this.chkCompliance.Text = "CheckList";
      this.chkCompliance.UseVisualStyleBackColor = true;
      this.chkTER.AutoSize = true;
      this.chkTER.Cursor = Cursors.Hand;
      this.chkTER.Location = new Point(20, 117);
      this.chkTER.Name = "chkTER";
      this.chkTER.Size = new Size(100, 17);
      this.chkTER.TabIndex = 4;
      this.chkTER.Text = "TER Worksheet";
      this.chkTER.UseVisualStyleBackColor = true;
      this.chkDER.AutoSize = true;
      this.chkDER.Cursor = Cursors.Hand;
      this.chkDER.Location = new Point(20, 94);
      this.chkDER.Name = "chkDER";
      this.chkDER.Size = new Size(101, 17);
      this.chkDER.TabIndex = 3;
      this.chkDER.Text = "DER Worksheet";
      this.chkDER.UseVisualStyleBackColor = true;
      this.chkSAPWorksheet.AutoSize = true;
      this.chkSAPWorksheet.Cursor = Cursors.Hand;
      this.chkSAPWorksheet.Location = new Point(21, 71);
      this.chkSAPWorksheet.Name = "chkSAPWorksheet";
      this.chkSAPWorksheet.Size = new Size(100, 17);
      this.chkSAPWorksheet.TabIndex = 2;
      this.chkSAPWorksheet.Text = "SAP Worksheet";
      this.chkSAPWorksheet.UseVisualStyleBackColor = true;
      this.chkInput.AutoSize = true;
      this.chkInput.Cursor = Cursors.Hand;
      this.chkInput.Location = new Point(21, 48);
      this.chkInput.Name = "chkInput";
      this.chkInput.Size = new Size(74, 17);
      this.chkInput.TabIndex = 1;
      this.chkInput.Text = "SAP Input";
      this.chkInput.UseVisualStyleBackColor = true;
      this.Button1.BackColor = Color.LightSlateGray;
      this.Button1.Cursor = Cursors.Hand;
      this.Button1.FlatStyle = FlatStyle.Popup;
      this.Button1.ForeColor = Color.White;
      this.Button1.Location = new Point(317, 521);
      this.Button1.Name = "Button1";
      this.Button1.Size = new Size(284, 23);
      this.Button1.TabIndex = 25;
      this.Button1.Text = "Generate";
      this.Button1.UseVisualStyleBackColor = false;
      this.txtLocation.Location = new Point(6, 37);
      this.txtLocation.Name = "txtLocation";
      this.txtLocation.ReadOnly = true;
      this.txtLocation.Size = new Size(242, 21);
      this.txtLocation.TabIndex = 26;
      this.Label1.AutoSize = true;
      this.Label1.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label1.Location = new Point(6, 18);
      this.Label1.Name = "Label1";
      this.Label1.Size = new Size(203, 13);
      this.Label1.TabIndex = 27;
      this.Label1.Text = "Select Location for Generated Files";
      this.cmdLocation.BackColor = Color.LightSlateGray;
      this.cmdLocation.Cursor = Cursors.Hand;
      this.cmdLocation.FlatStyle = FlatStyle.Popup;
      this.cmdLocation.ForeColor = Color.White;
      this.cmdLocation.Location = new Point(254, 35);
      this.cmdLocation.Name = "cmdLocation";
      this.cmdLocation.Size = new Size(29, 23);
      this.cmdLocation.TabIndex = 28;
      this.cmdLocation.Text = "...";
      this.cmdLocation.UseVisualStyleBackColor = false;
      this.GroupBox4.Controls.Add((Control) this.txtLocation);
      this.GroupBox4.Controls.Add((Control) this.cmdLocation);
      this.GroupBox4.Controls.Add((Control) this.Label1);
      this.GroupBox4.Location = new Point(308, 286);
      this.GroupBox4.Name = "GroupBox4";
      this.GroupBox4.Size = new Size(290, 79);
      this.GroupBox4.TabIndex = 29;
      this.GroupBox4.TabStop = false;
      this.GroupBox4.Text = "File Location";
      this.GroupBox5.Controls.Add((Control) this.opt3);
      this.GroupBox5.Controls.Add((Control) this.opt2);
      this.GroupBox5.Controls.Add((Control) this.opt1);
      this.GroupBox5.Location = new Point(308, 371);
      this.GroupBox5.Name = "GroupBox5";
      this.GroupBox5.Size = new Size(304, 106);
      this.GroupBox5.TabIndex = 30;
      this.GroupBox5.TabStop = false;
      this.GroupBox5.Text = "File Options";
      this.opt3.AutoSize = true;
      this.opt3.Checked = true;
      this.opt3.Cursor = Cursors.Hand;
      this.opt3.Location = new Point(20, 69);
      this.opt3.Name = "opt3";
      this.opt3.Size = new Size(155, 17);
      this.opt3.TabIndex = 2;
      this.opt3.TabStop = true;
      this.opt3.Text = "All reports remain seperate";
      this.opt3.UseVisualStyleBackColor = true;
      this.opt2.AutoSize = true;
      this.opt2.Cursor = Cursors.Hand;
      this.opt2.Location = new Point(20, 46);
      this.opt2.Name = "opt2";
      this.opt2.Size = new Size(258, 17);
      this.opt2.TabIndex = 1;
      this.opt2.Text = "Combine ALL Dwelling reports into one document";
      this.opt2.UseVisualStyleBackColor = true;
      this.opt1.AutoSize = true;
      this.opt1.Cursor = Cursors.Hand;
      this.opt1.Location = new Point(20, 23);
      this.opt1.Name = "opt1";
      this.opt1.Size = new Size(216, 17);
      this.opt1.TabIndex = 0;
      this.opt1.Text = "Combine ALL reports into one document";
      this.opt1.UseVisualStyleBackColor = true;
      this.Button2.BackColor = Color.LightSlateGray;
      this.Button2.Cursor = Cursors.Hand;
      this.Button2.DialogResult = DialogResult.Cancel;
      this.Button2.FlatStyle = FlatStyle.Popup;
      this.Button2.ForeColor = Color.White;
      this.Button2.Location = new Point(314, 550);
      this.Button2.Name = "Button2";
      this.Button2.Size = new Size(284, 23);
      this.Button2.TabIndex = 31;
      this.Button2.Text = "Close";
      this.Button2.UseVisualStyleBackColor = false;
      this.PB1.Location = new Point(313, 588);
      this.PB1.MarqueeAnimationSpeed = 5;
      this.PB1.Maximum = 9;
      this.PB1.Name = "PB1";
      this.PB1.Size = new Size(287, 23);
      this.PB1.Step = 2;
      this.PB1.TabIndex = 32;
      this.chkDeveloperrpt.AutoSize = true;
      this.chkDeveloperrpt.Cursor = Cursors.Hand;
      this.chkDeveloperrpt.Location = new Point(20, 315);
      this.chkDeveloperrpt.Name = "chkDeveloperrpt";
      this.chkDeveloperrpt.Size = new Size(115, 17);
      this.chkDeveloperrpt.TabIndex = 37;
      this.chkDeveloperrpt.Text = "Developer Sign off";
      this.chkDeveloperrpt.UseVisualStyleBackColor = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.White;
      this.ClientSize = new Size(605, 637);
      this.Controls.Add((Control) this.PB1);
      this.Controls.Add((Control) this.Button2);
      this.Controls.Add((Control) this.GroupBox5);
      this.Controls.Add((Control) this.GroupBox4);
      this.Controls.Add((Control) this.Button1);
      this.Controls.Add((Control) this.GroupBox1);
      this.Controls.Add((Control) this.GroupBox2);
      this.Controls.Add((Control) this.GroupBox3);
      this.Cursor = Cursors.Hand;
      this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.Name = nameof (Batch_Report);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Batch Report";
      this.GroupBox2.ResumeLayout(false);
      this.GroupBox3.ResumeLayout(false);
      this.GroupBox1.ResumeLayout(false);
      this.GroupBox1.PerformLayout();
      this.GroupBox4.ResumeLayout(false);
      this.GroupBox4.PerformLayout();
      this.GroupBox5.ResumeLayout(false);
      this.GroupBox5.PerformLayout();
      this.ResumeLayout(false);
    }

    [field: AccessedThroughProperty("GroupBox2")]
    internal virtual GroupBox GroupBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button cmdAddDwelling
    {
      get => this._cmdAddDwelling;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdAddDwelling_Click);
        Button cmdAddDwelling1 = this._cmdAddDwelling;
        if (cmdAddDwelling1 != null)
          cmdAddDwelling1.Click -= eventHandler;
        this._cmdAddDwelling = value;
        Button cmdAddDwelling2 = this._cmdAddDwelling;
        if (cmdAddDwelling2 == null)
          return;
        cmdAddDwelling2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("lstAllDwellings")]
    internal virtual ListBox lstAllDwellings { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button cmdRemoveDwelling
    {
      get => this._cmdRemoveDwelling;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdRemoveDwelling_Click);
        Button cmdRemoveDwelling1 = this._cmdRemoveDwelling;
        if (cmdRemoveDwelling1 != null)
          cmdRemoveDwelling1.Click -= eventHandler;
        this._cmdRemoveDwelling = value;
        Button cmdRemoveDwelling2 = this._cmdRemoveDwelling;
        if (cmdRemoveDwelling2 == null)
          return;
        cmdRemoveDwelling2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("lstBlockDwellings")]
    internal virtual ListBox lstBlockDwellings { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox3")]
    internal virtual GroupBox GroupBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox1")]
    internal virtual GroupBox GroupBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

    [field: AccessedThroughProperty("FD1")]
    internal virtual FolderBrowserDialog FD1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtLocation")]
    internal virtual TextBox txtLocation { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label1")]
    internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button cmdLocation
    {
      get => this._cmdLocation;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdLocation_Click);
        Button cmdLocation1 = this._cmdLocation;
        if (cmdLocation1 != null)
          cmdLocation1.Click -= eventHandler;
        this._cmdLocation = value;
        Button cmdLocation2 = this._cmdLocation;
        if (cmdLocation2 == null)
          return;
        cmdLocation2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("GroupBox4")]
    internal virtual GroupBox GroupBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox5")]
    internal virtual GroupBox GroupBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("opt3")]
    internal virtual RadioButton opt3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("opt2")]
    internal virtual RadioButton opt2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("opt1")]
    internal virtual RadioButton opt1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button4
    {
      get => this._Button4;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button4_Click);
        Button button4_1 = this._Button4;
        if (button4_1 != null)
          button4_1.Click -= eventHandler;
        this._Button4 = value;
        Button button4_2 = this._Button4;
        if (button4_2 == null)
          return;
        button4_2.Click += eventHandler;
      }
    }

    internal virtual Button Button3
    {
      get => this._Button3;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button3_Click);
        Button button3_1 = this._Button3;
        if (button3_1 != null)
          button3_1.Click -= eventHandler;
        this._Button3 = value;
        Button button3_2 = this._Button3;
        if (button3_2 == null)
          return;
        button3_2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("chk10")]
    internal virtual CheckBox chk10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chkPredicated")]
    internal virtual CheckBox chkPredicated { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chk8")]
    internal virtual CheckBox chk8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chkOverHeating")]
    internal virtual CheckBox chkOverHeating { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox chkCompliance
    {
      get => this._chkCompliance;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chk6_CheckedChanged);
        CheckBox chkCompliance1 = this._chkCompliance;
        if (chkCompliance1 != null)
          chkCompliance1.CheckedChanged -= eventHandler;
        this._chkCompliance = value;
        CheckBox chkCompliance2 = this._chkCompliance;
        if (chkCompliance2 == null)
          return;
        chkCompliance2.CheckedChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("chk5")]
    internal virtual CheckBox chk5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chkTER")]
    internal virtual CheckBox chkTER { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chkDER")]
    internal virtual CheckBox chkDER { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chkSAPWorksheet")]
    internal virtual CheckBox chkSAPWorksheet { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chkInput")]
    internal virtual CheckBox chkInput { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Button2")]
    internal virtual Button Button2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("PB1")]
    internal virtual ProgressBar PB1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chkCode")]
    internal virtual CheckBox chkCode { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chkFEE")]
    internal virtual CheckBox chkFEE { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox ChkComplinaceSave
    {
      get => this._ChkComplinaceSave;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ChkComplinaceSave_CheckedChanged);
        CheckBox chkComplinaceSave1 = this._ChkComplinaceSave;
        if (chkComplinaceSave1 != null)
          chkComplinaceSave1.CheckedChanged -= eventHandler;
        this._ChkComplinaceSave = value;
        CheckBox chkComplinaceSave2 = this._ChkComplinaceSave;
        if (chkComplinaceSave2 == null)
          return;
        chkComplinaceSave2.CheckedChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("ChkTFEE")]
    internal virtual CheckBox ChkTFEE { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("ChkThermalBridge")]
    internal virtual CheckBox ChkThermalBridge { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("ChkCost")]
    internal virtual CheckBox ChkCost { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chkDeveloperrpt")]
    internal virtual CheckBox chkDeveloperrpt { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private void Batch_Report_Load(object sender, EventArgs e) => this.FillAllDwellings();

    private void FillAllDwellings()
    {
      DataTable dataTable = new DataTable();
      dataTable.Columns.Add("ID");
      dataTable.Columns.Add("Name");
      dataTable.Columns.Add("Reference");
      int num = checked (SAP_Module.Proj.NoOfDwells - 1);
      int House = 0;
      while (House <= num)
      {
        if (Validation.LodgementStatusCheck(House))
        {
          DataRow row = dataTable.NewRow();
          row["ID"] = (object) House;
          row["Name"] = (object) SAP_Module.Proj.Dwellings[House].Name;
          row["Reference"] = (object) SAP_Module.Proj.Dwellings[House].Reference;
          dataTable.Rows.Add(row);
        }
        try
        {
          string country = SAP_Module.Proj.Dwellings[House].Address.Country;
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(country, "Wales", false) == 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(country, "Scotland", false) == 0)
          {
            this.chkFEE.Visible = false;
            this.ChkTFEE.Visible = false;
          }
          else
          {
            this.chkFEE.Visible = true;
            this.ChkTFEE.Visible = true;
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        checked { ++House; }
      }
      this.lstAllDwellings.DataSource = (object) dataTable;
      this.lstAllDwellings.DisplayMember = "Name";
    }

    private void cmdAddDwelling_Click(object sender, EventArgs e)
    {
      DataTable dataTable = new DataTable();
      if (this.lstBlockDwellings.DataSource != null)
      {
        dataTable = (DataTable) this.lstBlockDwellings.DataSource;
      }
      else
      {
        dataTable.Columns.Add("ID");
        dataTable.Columns.Add("Name");
        dataTable.Columns.Add("Reference");
      }
      int num1 = checked (this.lstAllDwellings.SelectedItems.Count - 1);
      int index1 = 0;
      while (index1 <= num1)
      {
        DataRowView selectedItem = (DataRowView) this.lstAllDwellings.SelectedItems[index1];
        bool flag = false;
        if (this.lstBlockDwellings.DataSource != null)
        {
          int num2 = checked (dataTable.Rows.Count - 1);
          int index2 = 0;
          while (index2 <= num2)
          {
            if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(dataTable.Rows[index2]["ID"], selectedItem["ID"], false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(dataTable.Rows[index2]["Name"], selectedItem["Name"], false)), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(dataTable.Rows[index2]["Reference"], selectedItem["Reference"], false))))
            {
              flag = true;
              break;
            }
            checked { ++index2; }
          }
        }
        if (!flag)
        {
          DataRow row = dataTable.NewRow();
          row["ID"] = RuntimeHelpers.GetObjectValue(selectedItem["ID"]);
          row["Name"] = RuntimeHelpers.GetObjectValue(selectedItem["Name"]);
          row["Reference"] = RuntimeHelpers.GetObjectValue(selectedItem["Reference"]);
          dataTable.Rows.Add(row);
        }
        checked { ++index1; }
      }
      if ((uint) dataTable.Rows.Count <= 0U)
        return;
      this.lstBlockDwellings.DataSource = (object) dataTable;
      this.lstBlockDwellings.DisplayMember = "Name";
    }

    private void cmdRemoveDwelling_Click(object sender, EventArgs e)
    {
      if ((uint) this.lstBlockDwellings.SelectedItems.Count <= 0U)
        return;
      DataTable dataTable = new DataTable();
      int[] source = new int[checked (this.lstBlockDwellings.SelectedItems.Count - 1 + 1)];
      int num = checked (this.lstBlockDwellings.SelectedItems.Count - 1);
      int index1 = 0;
      while (index1 <= num)
      {
        source[index1] = this.lstBlockDwellings.SelectedIndices[index1];
        checked { ++index1; }
      }
      DataTable dataSource = (DataTable) this.lstBlockDwellings.DataSource;
      int index2 = checked (((IEnumerable<int>) source).Count<int>() - 1);
      while (index2 >= 0)
      {
        dataSource.Rows[source[index2]].Delete();
        checked { index2 += -1; }
      }
    }

    private void cmdLocation_Click(object sender, EventArgs e)
    {
      int num = (int) this.FD1.ShowDialog();
      this.txtLocation.Text = this.FD1.SelectedPath;
    }

    private void Button3_Click(object sender, EventArgs e)
    {
      this.ChkTFEE.Checked = true;
      this.chkInput.Checked = true;
      this.chkSAPWorksheet.Checked = true;
      this.chkDER.Checked = true;
      this.chkTER.Checked = true;
      this.chk5.Checked = true;
      this.chkCompliance.Checked = true;
      this.chkOverHeating.Checked = true;
      this.chk8.Checked = true;
      this.chkPredicated.Checked = true;
      this.chk10.Checked = true;
      this.chkCode.Checked = true;
      this.chkFEE.Checked = true;
      this.ChkThermalBridge.Checked = true;
      this.chkDeveloperrpt.Checked = true;
      this.ChkCost.Checked = true;
    }

    private void Button4_Click(object sender, EventArgs e)
    {
      this.chkInput.Checked = false;
      this.chkSAPWorksheet.Checked = false;
      this.chkDER.Checked = false;
      this.chkTER.Checked = false;
      this.chk5.Checked = false;
      this.chkCompliance.Checked = false;
      this.chkOverHeating.Checked = false;
      this.chk8.Checked = false;
      this.chkPredicated.Checked = false;
      this.chk10.Checked = false;
      this.chkCode.Checked = false;
      this.chkFEE.Checked = false;
      this.ChkTFEE.Checked = false;
      this.ChkThermalBridge.Checked = false;
      this.ChkCost.Checked = false;
      this.chkDeveloperrpt.Checked = false;
    }

    private void Button1_Click(object sender, EventArgs e)
    {
      PDFFunctions.Draft_PDF = true;
      this.PB1.Visible = true;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtLocation.Text, "", false) == 0)
      {
        int num1 = (int) Interaction.MsgBox((object) "Please select the location to save files.");
      }
      else
      {
        string Left1 = "";
        int num2;
        if (this.chkInput.Checked)
        {
          int num3;
          num2 = checked (num3 + 1);
        }
        if (this.chkSAPWorksheet.Checked)
          checked { ++num2; }
        if (this.chkDER.Checked)
          checked { ++num2; }
        if (this.chkTER.Checked)
          checked { ++num2; }
        if (this.ChkTFEE.Checked)
          checked { ++num2; }
        if (this.chk5.Checked)
          checked { ++num2; }
        if (this.chkCompliance.Checked)
          checked { ++num2; }
        if (this.chkOverHeating.Checked)
          checked { ++num2; }
        if (this.chk8.Checked)
          checked { ++num2; }
        if (this.chkPredicated.Checked)
          checked { ++num2; }
        if (this.chk10.Checked)
          checked { ++num2; }
        if (this.chkCode.Checked)
          checked { ++num2; }
        if (this.chkFEE.Checked)
          checked { ++num2; }
        if (this.ChkThermalBridge.Checked)
          checked { ++num2; }
        if (this.ChkCost.Checked)
          checked { ++num2; }
        if (this.chkDeveloperrpt.Checked)
          checked { ++num2; }
        if (num2 == 0)
        {
          int num4 = (int) Interaction.MsgBox((object) "No reports to create.");
        }
        else
        {
          try
          {
            if (this.lstBlockDwellings.DataSource != null)
            {
              DataTable dataSource = (DataTable) this.lstBlockDwellings.DataSource;
              this.PB1.Maximum = dataSource.Rows.Count;
              Application.DoEvents();
              Validation.FirstFile = true;
              int num5 = checked (dataSource.Rows.Count - 1);
              while (num5 >= 0)
              {
                this.PB1.Value = checked (dataSource.Rows.Count - num5);
                Application.DoEvents();
                SAP_Module.CurrDwelling = Conversions.ToInteger(dataSource.Rows[num5][0]);
                Functions.CalculateNow();
                int Country;
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[Conversions.ToInteger(dataSource.Rows[num5][0])].Address.Country, "Northern Ireland", false) == 0)
                  Country = 3;
                else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[Conversions.ToInteger(dataSource.Rows[num5][0])].Address.Country, "Wales", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[Conversions.ToInteger(dataSource.Rows[num5][0])].Address.Country, "Scotland", false) == 0)
                {
                  this.chkFEE.Checked = false;
                  this.ChkTFEE.Checked = false;
                  Country = 2;
                }
                else
                  Country = 1;
                object folderPath = (object) Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                DirectoryInfo directoryInfo1 = new DirectoryInfo(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(folderPath, (object) "\\Stroma SAP 2012")));
                DirectoryInfo directoryInfo2 = new DirectoryInfo(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(folderPath, (object) "\\Stroma SAP 2012\\"), (object) SAP_Module.Proj.Name)));
                DirectoryInfo directoryInfo3 = new DirectoryInfo(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(folderPath, (object) "\\Stroma SAP 2012\\"), (object) SAP_Module.Proj.Name), (object) "\\"), (object) SAP_Module.Proj.Dwellings[Conversions.ToInteger(dataSource.Rows[num5][0])].Name)));
                if (!directoryInfo1.Exists)
                  directoryInfo1.Create();
                if (!directoryInfo2.Exists)
                  directoryInfo2.Create();
                if (!directoryInfo3.Exists)
                  directoryInfo3.Create();
                if (this.opt1.Checked)
                {
                  if (this.chkOverHeating.Checked & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Overheat, "Yes", false) == 0)
                  {
                    Calc2012 calc2012 = new Calc2012();
                    calc2012.SETPCDF(SAP_Module.PCDFData);
                    calc2012.Dwelling = SAP_Module.Proj.Dwellings[Conversions.ToInteger(dataSource.Rows[num5][0])];
                    SAPInput.CreateOverHeatingDoc(Conversions.ToInteger(dataSource.Rows[num5][0]), Country);
                    this.CombinePages(SAP_Module.SAPOverHeatingName, num5, SAP_Module.Proj.Name);
                  }
                  if (this.chkTER.Checked & (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Status, "Existing dwelling (SAP)", false) > 0U)
                  {
                    Calc2012 MyCal = new Calc2012()
                    {
                      DTER = true
                    };
                    MyCal.SETPCDF(SAP_Module.PCDFData);
                    MyCal.Dwelling = SAP_Module.TERDwelling;
                    SAP2009_WorkSheet.Stroma_Sap2009Worksheet(Conversions.ToInteger(dataSource.Rows[num5][0]), MyCal, 3, SAP_Module.TERDwelling);
                    this.CombinePages(SAP_Module.PDFFileName, num5, SAP_Module.Proj.Name);
                  }
                  if (this.chkDER.Checked & (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Status, "Existing dwelling (SAP)", false) > 0U)
                  {
                    Calc2012 MyCal = new Calc2012()
                    {
                      DTER = true
                    };
                    MyCal.SETPCDF(SAP_Module.PCDFData);
                    MyCal.Dwelling = SAP_Module.DERDwelling;
                    SAP2009_WorkSheet.Stroma_Sap2009Worksheet(Conversions.ToInteger(dataSource.Rows[num5][0]), MyCal, 2, SAP_Module.DERDwelling);
                    this.CombinePages(SAP_Module.PDFFileName, num5, SAP_Module.Proj.Name);
                  }
                  if (this.chkFEE.Checked)
                  {
                    Calc2012 calc2012 = new Calc2012();
                    SAP_Module.Dwelling feeDwelling = Functions.GetFEEDwelling(ref SAP_Module.Proj.Dwellings[Conversions.ToInteger(dataSource.Rows[num5][0])]);
                    calc2012.SETPCDF(SAP_Module.PCDFData);
                    calc2012.IsFabricEfficiency = true;
                    calc2012.Dwelling = feeDwelling;
                    SAP2009_WorkSheet.Stroma_Sap2009Worksheet(Conversions.ToInteger(dataSource.Rows[num5][0]), SAP_Module.CalculationFabric, 5, feeDwelling);
                    this.CombinePages(SAP_Module.PDFFileName, num5, SAP_Module.Proj.Name);
                  }
                  if (this.ChkTFEE.Checked)
                  {
                    Calc2012 MyCal = new Calc2012();
                    SAP_Module.Dwelling feeDwelling = Functions.GetFEEDwelling(ref SAP_Module.TERDwelling);
                    MyCal.SETPCDF(SAP_Module.PCDFData);
                    MyCal.IsFabricEfficiency = true;
                    MyCal.Dwelling = feeDwelling;
                    SAP2009_WorkSheet.Stroma_Sap2009Worksheet(Conversions.ToInteger(dataSource.Rows[num5][0]), MyCal, 6, feeDwelling);
                    this.CombinePages(SAP_Module.PDFFileName, num5, SAP_Module.Proj.Name);
                  }
                  if (this.ChkCost.Checked)
                  {
                    Calc2012 calc2012 = new Calc2012();
                    calc2012.SETPCDF(SAP_Module.PCDFData);
                    calc2012.Dwelling = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling];
                    SAP2009_WorkSheet.Stroma_Sap2009Worksheet(Conversions.ToInteger(dataSource.Rows[num5][0]), SAP_Module.Calculation2012Regional, 7, SAP_Module.Proj.Dwellings[Conversions.ToInteger(dataSource.Rows[num5][0])]);
                    this.CombinePages(SAP_Module.PDFFileName, num5, SAP_Module.Proj.Name);
                  }
                  if (this.chkSAPWorksheet.Checked)
                  {
                    Calc2012 MyCal = new Calc2012();
                    MyCal.SETPCDF(SAP_Module.PCDFData);
                    MyCal.Dwelling = SAP_Module.Proj.Dwellings[Conversions.ToInteger(dataSource.Rows[num5][0])];
                    SAP2009_WorkSheet.Stroma_Sap2009Worksheet(Conversions.ToInteger(dataSource.Rows[num5][0]), MyCal, 1, SAP_Module.Proj.Dwellings[Conversions.ToInteger(dataSource.Rows[num5][0])]);
                    this.CombinePages(SAP_Module.PDFFileName, num5, SAP_Module.Proj.Name);
                  }
                  if (this.chkPredicated.Checked)
                  {
                    new CreatePDF().GeneratePredictedPDF(Country, Conversions.ToInteger(dataSource.Rows[num5][0]));
                    this.CombinePages(SAP_Module.PredicatedEPC, num5, SAP_Module.Proj.Name);
                  }
                  if (this.chkInput.Checked)
                  {
                    Calc2012 calc2012 = new Calc2012();
                    calc2012.SETPCDF(SAP_Module.PCDFData);
                    calc2012.Dwelling = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling];
                    SAP_Module.Calculation2012 = calc2012;
                    SAPInput.CreateSAPInput(Conversions.ToInteger(dataSource.Rows[num5][0]), Country);
                    this.CombinePages(SAP_Module.PDFFileName, num5, SAP_Module.Proj.Name);
                  }
                  if (this.chkDeveloperrpt.Checked)
                  {
                    Calc2012 calc2012 = new Calc2012();
                    calc2012.SETPCDF(SAP_Module.PCDFData);
                    calc2012.Dwelling = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling];
                    SAP_Module.Calculation2012 = calc2012;
                    DeveloperReport.CreateDeveloperReport(Conversions.ToInteger(dataSource.Rows[num5][0]), Country);
                    this.CombinePages(SAP_Module.PDFFileName, num5, SAP_Module.Proj.Name);
                  }
                  if (this.chkCode.Checked)
                  {
                    SAPInput.CodeReport(Conversions.ToInteger(dataSource.Rows[num5][0]));
                    this.CombinePages(SAP_Module.ZerocarbonEPC, num5, SAP_Module.Proj.Name);
                  }
                  if (this.ChkThermalBridge.Checked)
                  {
                    SAPInput.ThermalBridgeReport(Conversions.ToInteger(dataSource.Rows[num5][0]), Country);
                    this.CombinePages(SAP_Module.ThermalBridge, num5, SAP_Module.Proj.Name);
                  }
                  if (this.chkCompliance.Checked & (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Status, "Existing dwelling (SAP)", false) > 0U)
                  {
                    Calc2012 MyCal = new Calc2012();
                    MyCal.SETPCDF(SAP_Module.PCDFData);
                    MyCal.Dwelling = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling];
                    if (this.ChkComplinaceSave.Checked & Validation.UserLogged)
                    {
                      try
                      {
                        if (this.ChkComplinaceSave.Checked)
                          L1ACheckList.SAP09DataOperation = true;
                        string str = "";
                        string Left2 = L1ACheckList.SaveInput_AND_ComplinaceDetails(SAP_Module.CurrDwelling);
                        if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left2, "", false) > 0U)
                        {
                          Left1 = Left1 + "Error Message for: " + SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Name + "\r\n" + Left2;
                          str = "";
                        }
                      }
                      catch (Exception ex)
                      {
                        ProjectData.SetProjectError(ex);
                        ProjectData.ClearProjectError();
                      }
                    }
                    else
                      L1ACheckList.SAP09DataOperation = false;
                    L1ACheckList.L1ACheckListCreate(Conversions.ToInteger(dataSource.Rows[num5][0]), MyCal);
                    this.CombinePages(SAP_Module.SAPCheckListName, num5, SAP_Module.Proj.Name);
                  }
                }
                else if (this.opt2.Checked)
                {
                  Validation.FirstFile = true;
                  if (this.chkOverHeating.Checked & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Overheat, "Yes", false) == 0)
                  {
                    Calc2012 calc2012 = new Calc2012();
                    calc2012.SETPCDF(SAP_Module.PCDFData);
                    calc2012.Dwelling = SAP_Module.Proj.Dwellings[Conversions.ToInteger(dataSource.Rows[num5][0])];
                    SAPInput.CreateOverHeatingDoc(Conversions.ToInteger(dataSource.Rows[num5][0]), Country);
                    this.CombinePages(SAP_Module.SAPOverHeatingName, num5, SAP_Module.Proj.Dwellings[Conversions.ToInteger(dataSource.Rows[num5][0])].Name);
                  }
                  if (this.chkTER.Checked & (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Status, "Existing dwelling (SAP)", false) > 0U)
                  {
                    Calc2012 MyCal = new Calc2012()
                    {
                      DTER = true
                    };
                    MyCal.SETPCDF(SAP_Module.PCDFData);
                    MyCal.Dwelling = SAP_Module.TERDwelling;
                    SAP2009_WorkSheet.Stroma_Sap2009Worksheet(Conversions.ToInteger(dataSource.Rows[num5][0]), MyCal, 3, SAP_Module.TERDwelling);
                    this.CombinePages(SAP_Module.PDFFileName, 0, SAP_Module.Proj.Dwellings[Conversions.ToInteger(dataSource.Rows[num5][0])].Name);
                  }
                  if (this.chkDER.Checked & (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Status, "Existing dwelling (SAP)", false) > 0U)
                  {
                    Calc2012 MyCal = new Calc2012()
                    {
                      DTER = true
                    };
                    MyCal.SETPCDF(SAP_Module.PCDFData);
                    MyCal.Dwelling = SAP_Module.DERDwelling;
                    SAP2009_WorkSheet.Stroma_Sap2009Worksheet(Conversions.ToInteger(dataSource.Rows[num5][0]), MyCal, 2, SAP_Module.DERDwelling);
                    this.CombinePages(SAP_Module.PDFFileName, 0, SAP_Module.Proj.Dwellings[Conversions.ToInteger(dataSource.Rows[num5][0])].Name);
                  }
                  if (this.chkFEE.Checked)
                  {
                    Calc2012 calc2012 = new Calc2012();
                    SAP_Module.Dwelling feeDwelling = Functions.GetFEEDwelling(ref SAP_Module.Proj.Dwellings[Conversions.ToInteger(dataSource.Rows[num5][0])]);
                    calc2012.SETPCDF(SAP_Module.PCDFData);
                    calc2012.IsFabricEfficiency = true;
                    calc2012.Dwelling = feeDwelling;
                    Conversions.ToInteger(dataSource.Rows[num5][0]);
                    SAP2009_WorkSheet.Stroma_Sap2009Worksheet(Conversions.ToInteger(dataSource.Rows[num5][0]), SAP_Module.CalculationFabric, 5, feeDwelling);
                    this.CombinePages(SAP_Module.PDFFileName, 0, SAP_Module.Proj.Dwellings[Conversions.ToInteger(dataSource.Rows[num5][0])].Name);
                  }
                  if (this.ChkTFEE.Checked)
                  {
                    Calc2012 MyCal = new Calc2012();
                    SAP_Module.Dwelling feeDwelling = Functions.GetFEEDwelling(ref SAP_Module.TERDwelling);
                    MyCal.SETPCDF(SAP_Module.PCDFData);
                    MyCal.IsFabricEfficiency = true;
                    MyCal.Dwelling = feeDwelling;
                    SAP2009_WorkSheet.Stroma_Sap2009Worksheet(Conversions.ToInteger(dataSource.Rows[num5][0]), MyCal, 6, feeDwelling);
                    this.CombinePages(SAP_Module.PDFFileName, 0, SAP_Module.Proj.Dwellings[Conversions.ToInteger(dataSource.Rows[num5][0])].Name);
                  }
                  if (this.ChkCost.Checked)
                  {
                    Calc2012 calc2012 = new Calc2012();
                    calc2012.SETPCDF(SAP_Module.PCDFData);
                    calc2012.Dwelling = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling];
                    SAP2009_WorkSheet.Stroma_Sap2009Worksheet(Conversions.ToInteger(dataSource.Rows[num5][0]), SAP_Module.Calculation2012Regional, 7, SAP_Module.Proj.Dwellings[Conversions.ToInteger(dataSource.Rows[num5][0])]);
                    this.CombinePages(SAP_Module.PDFFileName, 0, SAP_Module.Proj.Dwellings[Conversions.ToInteger(dataSource.Rows[num5][0])].Name);
                  }
                  if (this.chkSAPWorksheet.Checked)
                  {
                    Calc2012 MyCal = new Calc2012();
                    MyCal.SETPCDF(SAP_Module.PCDFData);
                    MyCal.Dwelling = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling];
                    SAP2009_WorkSheet.Stroma_Sap2009Worksheet(Conversions.ToInteger(dataSource.Rows[num5][0]), MyCal, 1, SAP_Module.Proj.Dwellings[Conversions.ToInteger(dataSource.Rows[num5][0])]);
                    this.CombinePages(SAP_Module.PDFFileName, 0, SAP_Module.Proj.Dwellings[Conversions.ToInteger(dataSource.Rows[num5][0])].Name);
                  }
                  if (this.chkInput.Checked)
                  {
                    Calc2012 calc2012 = new Calc2012();
                    calc2012.SETPCDF(SAP_Module.PCDFData);
                    calc2012.Dwelling = SAP_Module.Proj.Dwellings[Conversions.ToInteger(dataSource.Rows[num5][0])];
                    SAP_Module.Calculation2012 = calc2012;
                    SAPInput.CreateSAPInput(Conversions.ToInteger(dataSource.Rows[num5][0]), Country);
                    this.CombinePages(SAP_Module.PDFFileName, 0, SAP_Module.Proj.Dwellings[Conversions.ToInteger(dataSource.Rows[num5][0])].Name);
                  }
                  if (this.chkDeveloperrpt.Checked)
                  {
                    Calc2012 calc2012 = new Calc2012();
                    calc2012.SETPCDF(SAP_Module.PCDFData);
                    calc2012.Dwelling = SAP_Module.Proj.Dwellings[Conversions.ToInteger(dataSource.Rows[num5][0])];
                    SAP_Module.Calculation2012 = calc2012;
                    DeveloperReport.CreateDeveloperReport(Conversions.ToInteger(dataSource.Rows[num5][0]), Country);
                    this.CombinePages(SAP_Module.PDFFileName, 0, SAP_Module.Proj.Dwellings[Conversions.ToInteger(dataSource.Rows[num5][0])].Name);
                  }
                  if (this.chkPredicated.Checked)
                  {
                    new CreatePDF().GeneratePredictedPDF(Country, Conversions.ToInteger(dataSource.Rows[num5][0]));
                    this.CombinePages(SAP_Module.PredicatedEPC, 0, SAP_Module.Proj.Dwellings[Conversions.ToInteger(dataSource.Rows[num5][0])].Name);
                  }
                  if (this.chkCode.Checked)
                  {
                    SAPInput.CodeReport(Conversions.ToInteger(dataSource.Rows[num5][0]));
                    this.CombinePages(SAP_Module.ZerocarbonEPC, 0, SAP_Module.Proj.Dwellings[Conversions.ToInteger(dataSource.Rows[num5][0])].Name);
                  }
                  if (this.ChkThermalBridge.Checked)
                  {
                    SAPInput.ThermalBridgeReport(Conversions.ToInteger(dataSource.Rows[num5][0]), Country);
                    this.CombinePages(SAP_Module.ThermalBridge, 0, SAP_Module.Proj.Dwellings[Conversions.ToInteger(dataSource.Rows[num5][0])].Name);
                  }
                  if (this.chkCompliance.Checked & (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Status, "Existing dwelling (SAP)", false) > 0U)
                  {
                    Calc2012 MyCal = new Calc2012();
                    MyCal.SETPCDF(SAP_Module.PCDFData);
                    MyCal.Dwelling = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling];
                    if (this.ChkComplinaceSave.Checked & Validation.UserLogged)
                    {
                      try
                      {
                        if (this.ChkComplinaceSave.Checked)
                          L1ACheckList.SAP09DataOperation = true;
                        string str = "";
                        string Left3 = L1ACheckList.SaveInput_AND_ComplinaceDetails(SAP_Module.CurrDwelling);
                        if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left3, "", false) > 0U)
                        {
                          Left1 = Left1 + "Error Message for: " + SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Name + "\r\n" + Left3;
                          str = "";
                        }
                      }
                      catch (Exception ex)
                      {
                        ProjectData.SetProjectError(ex);
                        ProjectData.ClearProjectError();
                      }
                    }
                    else
                      L1ACheckList.SAP09DataOperation = false;
                    L1ACheckList.L1ACheckListCreate(Conversions.ToInteger(dataSource.Rows[num5][0]), MyCal);
                    this.CombinePages(SAP_Module.SAPCheckListName, 0, SAP_Module.Proj.Dwellings[Conversions.ToInteger(dataSource.Rows[num5][0])].Name);
                  }
                }
                else if (this.opt3.Checked)
                {
                  if (this.chkOverHeating.Checked & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Overheat, "Yes", false) == 0)
                  {
                    Calc2012 calc2012 = new Calc2012();
                    calc2012.SETPCDF(SAP_Module.PCDFData);
                    calc2012.Dwelling = SAP_Module.Proj.Dwellings[Conversions.ToInteger(dataSource.Rows[num5][0])];
                    SAPInput.CreateOverHeatingDoc(Conversions.ToInteger(dataSource.Rows[num5][0]), Country);
                    this.CopyFile(SAP_Module.SAPOverHeatingName, this.txtLocation.Text, Conversions.ToString(dataSource.Rows[num5][0]), "Overheating");
                  }
                  if (this.chkTER.Checked & (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Status, "Existing dwelling (SAP)", false) > 0U)
                  {
                    Calc2012 MyCal = new Calc2012()
                    {
                      DTER = true
                    };
                    MyCal.SETPCDF(SAP_Module.PCDFData);
                    MyCal.Dwelling = SAP_Module.TERDwelling;
                    SAP2009_WorkSheet.Stroma_Sap2009Worksheet(Conversions.ToInteger(dataSource.Rows[num5][0]), MyCal, 3, SAP_Module.TERDwelling);
                    this.CopyFile(SAP_Module.PDFFileName, this.txtLocation.Text, Conversions.ToString(dataSource.Rows[num5][0]), "TER");
                  }
                  if (this.chkDER.Checked & (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Status, "Existing dwelling (SAP)", false) > 0U)
                  {
                    Calc2012 MyCal = new Calc2012()
                    {
                      DTER = true
                    };
                    MyCal.SETPCDF(SAP_Module.PCDFData);
                    MyCal.Dwelling = SAP_Module.DERDwelling;
                    SAP2009_WorkSheet.Stroma_Sap2009Worksheet(Conversions.ToInteger(dataSource.Rows[num5][0]), MyCal, 2, SAP_Module.DERDwelling);
                    this.CopyFile(SAP_Module.PDFFileName, this.txtLocation.Text, Conversions.ToString(dataSource.Rows[num5][0]), "DER");
                  }
                  if (this.chkFEE.Checked)
                  {
                    Calc2012 calc2012 = new Calc2012();
                    SAP_Module.Dwelling feeDwelling = Functions.GetFEEDwelling(ref SAP_Module.Proj.Dwellings[Conversions.ToInteger(dataSource.Rows[num5][0])]);
                    calc2012.SETPCDF(SAP_Module.PCDFData);
                    calc2012.IsFabricEfficiency = true;
                    calc2012.Dwelling = feeDwelling;
                    SAP2009_WorkSheet.Stroma_Sap2009Worksheet(Conversions.ToInteger(dataSource.Rows[num5][0]), SAP_Module.CalculationFabric, 5, feeDwelling);
                    double box109 = SAP_Module.CalculationFabric.Calculation.Fabric_Energy_Efficiency.Box109;
                    this.CopyFile(SAP_Module.PDFFileName, this.txtLocation.Text, Conversions.ToString(dataSource.Rows[num5][0]), "SAP DFEE Worksheet");
                  }
                  if (this.ChkTFEE.Checked)
                  {
                    Calc2012 MyCal = new Calc2012();
                    SAP_Module.Dwelling feeDwelling = Functions.GetFEEDwelling(ref SAP_Module.TERDwelling);
                    MyCal.SETPCDF(SAP_Module.PCDFData);
                    MyCal.IsFabricEfficiency = true;
                    MyCal.Dwelling = feeDwelling;
                    SAP2009_WorkSheet.Stroma_Sap2009Worksheet(Conversions.ToInteger(dataSource.Rows[num5][0]), MyCal, 6, feeDwelling);
                    this.CopyFile(SAP_Module.PDFFileName, this.txtLocation.Text, Conversions.ToString(dataSource.Rows[num5][0]), "SAP TFEE Worksheet");
                  }
                  if (this.ChkCost.Checked)
                  {
                    Calc2012 calc2012 = new Calc2012();
                    calc2012.SETPCDF(SAP_Module.PCDFData);
                    calc2012.Dwelling = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling];
                    SAP2009_WorkSheet.Stroma_Sap2009Worksheet(Conversions.ToInteger(dataSource.Rows[num5][0]), SAP_Module.Calculation2012Regional, 7, SAP_Module.Proj.Dwellings[Conversions.ToInteger(dataSource.Rows[num5][0])]);
                    this.CopyFile(SAP_Module.PDFFileName, this.txtLocation.Text, Conversions.ToString(dataSource.Rows[num5][0]), "Cost Fees Worksheet");
                  }
                  if (this.chkPredicated.Checked)
                  {
                    new CreatePDF().GeneratePredictedPDF(Country, Conversions.ToInteger(dataSource.Rows[num5][0]));
                    this.CopyFile(SAP_Module.PredicatedEPC, this.txtLocation.Text, Conversions.ToString(dataSource.Rows[num5][0]), "PredictedEPC");
                  }
                  if (this.chkSAPWorksheet.Checked)
                  {
                    Calc2012 MyCal = new Calc2012();
                    MyCal.SETPCDF(SAP_Module.PCDFData);
                    MyCal.Dwelling = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling];
                    SAP2009_WorkSheet.Stroma_Sap2009Worksheet(Conversions.ToInteger(dataSource.Rows[num5][0]), MyCal, 1, SAP_Module.Proj.Dwellings[Conversions.ToInteger(dataSource.Rows[num5][0])]);
                    this.CopyFile(SAP_Module.PDFFileName, this.txtLocation.Text, Conversions.ToString(dataSource.Rows[num5][0]), "SAP Worksheet");
                  }
                  if (this.chkInput.Checked)
                  {
                    Calc2012 calc2012 = new Calc2012();
                    calc2012.SETPCDF(SAP_Module.PCDFData);
                    calc2012.Dwelling = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling];
                    SAP_Module.Calculation2012 = calc2012;
                    SAPInput.CreateSAPInput(Conversions.ToInteger(dataSource.Rows[num5][0]), Country);
                    this.CopyFile(SAP_Module.PDFFileName, this.txtLocation.Text, Conversions.ToString(dataSource.Rows[num5][0]), "SAP Input");
                  }
                  if (this.chkDeveloperrpt.Checked)
                  {
                    Calc2012 calc2012 = new Calc2012();
                    calc2012.SETPCDF(SAP_Module.PCDFData);
                    calc2012.Dwelling = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling];
                    SAP_Module.Calculation2012 = calc2012;
                    DeveloperReport.CreateDeveloperReport(Conversions.ToInteger(dataSource.Rows[num5][0]), Country);
                    this.CopyFile(SAP_Module.PDFFileName, this.txtLocation.Text, Conversions.ToString(dataSource.Rows[num5][0]), "Developer Confirmation");
                  }
                  if (this.chkCode.Checked)
                  {
                    SAPInput.CodeReport(Conversions.ToInteger(dataSource.Rows[num5][0]));
                    this.CopyFile(SAP_Module.ZerocarbonEPC, this.txtLocation.Text, Conversions.ToString(dataSource.Rows[num5][0]), "CSH");
                  }
                  if (this.ChkThermalBridge.Checked)
                  {
                    SAPInput.ThermalBridgeReport(Conversions.ToInteger(dataSource.Rows[num5][0]), Country);
                    this.CopyFile(SAP_Module.ThermalBridge, this.txtLocation.Text, Conversions.ToString(dataSource.Rows[num5][0]), "ThermalBridge");
                  }
                  if (this.chkCompliance.Checked & (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Status, "Existing dwelling (SAP)", false) > 0U)
                  {
                    Calc2012 MyCal = new Calc2012();
                    MyCal.SETPCDF(SAP_Module.PCDFData);
                    MyCal.Dwelling = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling];
                    if (this.ChkComplinaceSave.Checked & Validation.UserLogged)
                    {
                      try
                      {
                        if (this.ChkComplinaceSave.Checked)
                          L1ACheckList.SAP09DataOperation = true;
                        string str = "";
                        string Left4 = L1ACheckList.SaveInput_AND_ComplinaceDetails(SAP_Module.CurrDwelling);
                        if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left4, "", false) > 0U)
                        {
                          Left1 = Left1 + "Error Message for: " + SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Name + "\r\n" + Left4;
                          str = "";
                        }
                      }
                      catch (Exception ex)
                      {
                        ProjectData.SetProjectError(ex);
                        ProjectData.ClearProjectError();
                      }
                    }
                    else
                      L1ACheckList.SAP09DataOperation = false;
                    L1ACheckList.L1ACheckListCreate(Conversions.ToInteger(dataSource.Rows[num5][0]), MyCal);
                    this.CopyFile(SAP_Module.SAPCheckListName, this.txtLocation.Text, Conversions.ToString(dataSource.Rows[num5][0]), "CheckList");
                  }
                }
                checked { num5 += -1; }
              }
            }
            if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left1, "", false) > 0U)
            {
              int num6 = (int) new Error_Message()
              {
                txtError = {
                  Text = Left1
                }
              }.ShowDialog();
            }
            int num7 = (int) Interaction.MsgBox((object) "Reports are created.", MsgBoxStyle.Information);
            return;
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            int num8 = (int) Interaction.MsgBox((object) ("There is an error creating Reports " + Information.Err().Description));
            this.PB1.Visible = false;
            ProjectData.ClearProjectError();
          }
          L1ACheckList.SAP09DataOperation = false;
        }
      }
    }

    public void CopyFile(string Source, string Destination, string House, string Type)
    {
      VBMath.Randomize();
      int num = checked ((int) Math.Round(unchecked (5000.0 * (double) VBMath.Rnd() + 1.0)));
      string str = this.txtLocation.Text + "\\" + SAP_Module.Proj.Name + "-" + SAP_Module.Proj.Dwellings[Conversions.ToInteger(House)].Name + "-" + Type + ".pdf";
      if (!File.Exists(Source))
        return;
      if (File.Exists(str))
        File.Delete(str);
      File.Copy(Source, str);
    }

    public void CombinePages(string filename1, int FileNumber, string ProjectName)
    {
      VBMath.Randomize();
      Conversions.ToString(Math.Round(5000.0 * (double) VBMath.Rnd() + 1.0));
      string text = this.txtLocation.Text;
      if (!File.Exists(filename1))
        return;
      try
      {
        PdfDocument pdfDocument1 = new PdfDocument();
        PdfDocument pdfDocument2 = new PdfDocument();
        PdfDocument pdfDocument3 = PdfReader.Open(filename1, (PdfDocumentOpenMode) 1);
        if (Validation.FirstFile)
        {
          string str = filename1;
          this.NewCopy = text + "\\" + ProjectName + ".pdf";
          if (File.Exists(str))
          {
            if (File.Exists(this.NewCopy))
              File.Delete(this.NewCopy);
            File.Copy(str, this.NewCopy);
            Validation.FirstFile = false;
          }
        }
        else
        {
          PdfDocument pdfDocument4 = PdfReader.Open(this.NewCopy, (PdfDocumentOpenMode) 1);
          PdfDocument pdfDocument5 = new PdfDocument();
          int num1 = checked (pdfDocument3.PageCount - 1);
          int num2 = 0;
          XGraphics xgraphics;
          while (num2 <= num1)
          {
            PdfPage pdfPage1 = pdfDocument3.PageCount > num2 ? pdfDocument3.Pages[num2] : new PdfPage();
            PdfPage pdfPage2 = pdfDocument5.AddPage(pdfPage1);
            xgraphics = XGraphics.FromPdfPage(pdfPage2);
            XRect xrect = pdfPage2.MediaBox.ToXRect();
            ((XRect) ref xrect).Inflate(0.0, -10.0);
            checked { ++num2; }
          }
          int num3 = checked (pdfDocument4.PageCount - 1);
          int num4 = 0;
          while (num4 <= num3)
          {
            PdfPage pdfPage3 = pdfDocument4.PageCount > num4 ? pdfDocument4.Pages[num4] : new PdfPage();
            PdfPage pdfPage4 = pdfDocument5.AddPage(pdfPage3);
            xgraphics = XGraphics.FromPdfPage(pdfPage4);
            XRect xrect = pdfPage4.MediaBox.ToXRect();
            ((XRect) ref xrect).Inflate(0.0, -10.0);
            checked { ++num4; }
          }
          pdfDocument5.Save(this.NewCopy);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) Information.Err().Description);
        ProjectData.ClearProjectError();
      }
    }

    public void CheckFileExists(string FileName)
    {
      if (!File.Exists(FileName))
        return;
      File.Delete(FileName);
    }

    private void chk6_CheckedChanged(object sender, EventArgs e)
    {
      if (this.chkCompliance.Checked)
      {
        if (!Validation.UserLogged)
          return;
        this.ChkComplinaceSave.Visible = true;
      }
      else
      {
        this.ChkComplinaceSave.Visible = false;
        this.ChkComplinaceSave.Checked = false;
      }
    }

    private void ChkComplinaceSave_CheckedChanged(object sender, EventArgs e)
    {
      if (this.ChkComplinaceSave.Checked)
        L1ACheckList.SAP09DataOperation = false;
      else
        L1ACheckList.SAP09DataOperation = true;
    }
  }
}
