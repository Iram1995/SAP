
// Type: SAP2012.AreaCalc




using Microsoft.VisualBasic;
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
  public class AreaCalc : Form
  {
    private IContainer components;

    public AreaCalc()
    {
      this.FormClosing += new FormClosingEventHandler(this.AreaCalc_FormClosing);
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
      this.txtL1 = new TextBox();
      this.Label1 = new Label();
      this.txtW1 = new TextBox();
      this.Label2 = new Label();
      this.txtA1 = new TextBox();
      this.txtA2 = new TextBox();
      this.Label3 = new Label();
      this.txtW2 = new TextBox();
      this.Label4 = new Label();
      this.txtL2 = new TextBox();
      this.txtA3 = new TextBox();
      this.Label5 = new Label();
      this.txtW3 = new TextBox();
      this.Label6 = new Label();
      this.txtL3 = new TextBox();
      this.txtA4 = new TextBox();
      this.Label7 = new Label();
      this.txtW4 = new TextBox();
      this.Label8 = new Label();
      this.txtL4 = new TextBox();
      this.txtA5 = new TextBox();
      this.Label9 = new Label();
      this.txtW5 = new TextBox();
      this.Label10 = new Label();
      this.txtL5 = new TextBox();
      this.txtA6 = new TextBox();
      this.Label11 = new Label();
      this.txtW6 = new TextBox();
      this.Label12 = new Label();
      this.txtL6 = new TextBox();
      this.Label13 = new Label();
      this.Label14 = new Label();
      this.Label15 = new Label();
      this.Label16 = new Label();
      this.Label17 = new Label();
      this.Label18 = new Label();
      this.Label19 = new Label();
      this.Label20 = new Label();
      this.txtArea = new TextBox();
      this.Label21 = new Label();
      this.cmdLongAddress = new Button();
      this.Button1 = new Button();
      this.SuspendLayout();
      this.txtL1.Location = new Point(13, 13);
      this.txtL1.Name = "txtL1";
      this.txtL1.Size = new Size(67, 21);
      this.txtL1.TabIndex = 0;
      this.txtL1.TextAlign = HorizontalAlignment.Right;
      this.Label1.AutoSize = true;
      this.Label1.Location = new Point(87, 19);
      this.Label1.Name = "Label1";
      this.Label1.Size = new Size(13, 13);
      this.Label1.TabIndex = 1;
      this.Label1.Text = "x";
      this.txtW1.Location = new Point(105, 13);
      this.txtW1.Name = "txtW1";
      this.txtW1.Size = new Size(67, 21);
      this.txtW1.TabIndex = 1;
      this.txtW1.TextAlign = HorizontalAlignment.Right;
      this.Label2.AutoSize = true;
      this.Label2.Location = new Point(178, 19);
      this.Label2.Name = "Label2";
      this.Label2.Size = new Size(15, 13);
      this.Label2.TabIndex = 3;
      this.Label2.Text = "=";
      this.txtA1.Location = new Point(197, 13);
      this.txtA1.Name = "txtA1";
      this.txtA1.ReadOnly = true;
      this.txtA1.Size = new Size(67, 21);
      this.txtA1.TabIndex = 4;
      this.txtA1.TabStop = false;
      this.txtA1.Text = "0";
      this.txtA1.TextAlign = HorizontalAlignment.Right;
      this.txtA2.Location = new Point(197, 39);
      this.txtA2.Name = "txtA2";
      this.txtA2.ReadOnly = true;
      this.txtA2.Size = new Size(67, 21);
      this.txtA2.TabIndex = 9;
      this.txtA2.TabStop = false;
      this.txtA2.Text = "0";
      this.txtA2.TextAlign = HorizontalAlignment.Right;
      this.Label3.AutoSize = true;
      this.Label3.Location = new Point(178, 45);
      this.Label3.Name = "Label3";
      this.Label3.Size = new Size(15, 13);
      this.Label3.TabIndex = 8;
      this.Label3.Text = "=";
      this.txtW2.Location = new Point(105, 39);
      this.txtW2.Name = "txtW2";
      this.txtW2.Size = new Size(67, 21);
      this.txtW2.TabIndex = 3;
      this.txtW2.TextAlign = HorizontalAlignment.Right;
      this.Label4.AutoSize = true;
      this.Label4.Location = new Point(87, 45);
      this.Label4.Name = "Label4";
      this.Label4.Size = new Size(13, 13);
      this.Label4.TabIndex = 6;
      this.Label4.Text = "x";
      this.txtL2.Location = new Point(13, 39);
      this.txtL2.Name = "txtL2";
      this.txtL2.Size = new Size(67, 21);
      this.txtL2.TabIndex = 2;
      this.txtL2.TextAlign = HorizontalAlignment.Right;
      this.txtA3.Location = new Point(197, 65);
      this.txtA3.Name = "txtA3";
      this.txtA3.ReadOnly = true;
      this.txtA3.Size = new Size(67, 21);
      this.txtA3.TabIndex = 14;
      this.txtA3.TabStop = false;
      this.txtA3.Text = "0";
      this.txtA3.TextAlign = HorizontalAlignment.Right;
      this.Label5.AutoSize = true;
      this.Label5.Location = new Point(178, 71);
      this.Label5.Name = "Label5";
      this.Label5.Size = new Size(15, 13);
      this.Label5.TabIndex = 13;
      this.Label5.Text = "=";
      this.txtW3.Location = new Point(105, 65);
      this.txtW3.Name = "txtW3";
      this.txtW3.Size = new Size(67, 21);
      this.txtW3.TabIndex = 5;
      this.txtW3.TextAlign = HorizontalAlignment.Right;
      this.Label6.AutoSize = true;
      this.Label6.Location = new Point(87, 71);
      this.Label6.Name = "Label6";
      this.Label6.Size = new Size(13, 13);
      this.Label6.TabIndex = 11;
      this.Label6.Text = "x";
      this.txtL3.Location = new Point(13, 65);
      this.txtL3.Name = "txtL3";
      this.txtL3.Size = new Size(67, 21);
      this.txtL3.TabIndex = 4;
      this.txtL3.TextAlign = HorizontalAlignment.Right;
      this.txtA4.Location = new Point(197, 91);
      this.txtA4.Name = "txtA4";
      this.txtA4.ReadOnly = true;
      this.txtA4.Size = new Size(67, 21);
      this.txtA4.TabIndex = 19;
      this.txtA4.TabStop = false;
      this.txtA4.Text = "0";
      this.txtA4.TextAlign = HorizontalAlignment.Right;
      this.Label7.AutoSize = true;
      this.Label7.Location = new Point(178, 97);
      this.Label7.Name = "Label7";
      this.Label7.Size = new Size(15, 13);
      this.Label7.TabIndex = 18;
      this.Label7.Text = "=";
      this.txtW4.Location = new Point(105, 91);
      this.txtW4.Name = "txtW4";
      this.txtW4.Size = new Size(67, 21);
      this.txtW4.TabIndex = 7;
      this.txtW4.TextAlign = HorizontalAlignment.Right;
      this.Label8.AutoSize = true;
      this.Label8.Location = new Point(87, 97);
      this.Label8.Name = "Label8";
      this.Label8.Size = new Size(13, 13);
      this.Label8.TabIndex = 16;
      this.Label8.Text = "x";
      this.txtL4.Location = new Point(13, 91);
      this.txtL4.Name = "txtL4";
      this.txtL4.Size = new Size(67, 21);
      this.txtL4.TabIndex = 6;
      this.txtL4.TextAlign = HorizontalAlignment.Right;
      this.txtA5.Location = new Point(197, 117);
      this.txtA5.Name = "txtA5";
      this.txtA5.ReadOnly = true;
      this.txtA5.Size = new Size(67, 21);
      this.txtA5.TabIndex = 24;
      this.txtA5.TabStop = false;
      this.txtA5.Text = "0";
      this.txtA5.TextAlign = HorizontalAlignment.Right;
      this.Label9.AutoSize = true;
      this.Label9.Location = new Point(178, 123);
      this.Label9.Name = "Label9";
      this.Label9.Size = new Size(15, 13);
      this.Label9.TabIndex = 23;
      this.Label9.Text = "=";
      this.txtW5.Location = new Point(105, 117);
      this.txtW5.Name = "txtW5";
      this.txtW5.Size = new Size(67, 21);
      this.txtW5.TabIndex = 9;
      this.txtW5.TextAlign = HorizontalAlignment.Right;
      this.Label10.AutoSize = true;
      this.Label10.Location = new Point(87, 123);
      this.Label10.Name = "Label10";
      this.Label10.Size = new Size(13, 13);
      this.Label10.TabIndex = 21;
      this.Label10.Text = "x";
      this.txtL5.Location = new Point(13, 117);
      this.txtL5.Name = "txtL5";
      this.txtL5.Size = new Size(67, 21);
      this.txtL5.TabIndex = 8;
      this.txtL5.TextAlign = HorizontalAlignment.Right;
      this.txtA6.Location = new Point(197, 143);
      this.txtA6.Name = "txtA6";
      this.txtA6.ReadOnly = true;
      this.txtA6.Size = new Size(67, 21);
      this.txtA6.TabIndex = 29;
      this.txtA6.TabStop = false;
      this.txtA6.Text = "0";
      this.txtA6.TextAlign = HorizontalAlignment.Right;
      this.Label11.AutoSize = true;
      this.Label11.Location = new Point(178, 149);
      this.Label11.Name = "Label11";
      this.Label11.Size = new Size(15, 13);
      this.Label11.TabIndex = 28;
      this.Label11.Text = "=";
      this.txtW6.Location = new Point(105, 143);
      this.txtW6.Name = "txtW6";
      this.txtW6.Size = new Size(67, 21);
      this.txtW6.TabIndex = 11;
      this.txtW6.TextAlign = HorizontalAlignment.Right;
      this.Label12.AutoSize = true;
      this.Label12.Location = new Point(87, 149);
      this.Label12.Name = "Label12";
      this.Label12.Size = new Size(13, 13);
      this.Label12.TabIndex = 26;
      this.Label12.Text = "x";
      this.txtL6.Location = new Point(13, 143);
      this.txtL6.Name = "txtL6";
      this.txtL6.Size = new Size(67, 21);
      this.txtL6.TabIndex = 10;
      this.txtL6.TextAlign = HorizontalAlignment.Right;
      this.Label13.AutoSize = true;
      this.Label13.Location = new Point(270, 19);
      this.Label13.Name = "Label13";
      this.Label13.Size = new Size(20, 13);
      this.Label13.TabIndex = 30;
      this.Label13.Text = "m\u00B2";
      this.Label14.AutoSize = true;
      this.Label14.Location = new Point(270, 45);
      this.Label14.Name = "Label14";
      this.Label14.Size = new Size(20, 13);
      this.Label14.TabIndex = 31;
      this.Label14.Text = "m\u00B2";
      this.Label15.AutoSize = true;
      this.Label15.Location = new Point(270, 72);
      this.Label15.Name = "Label15";
      this.Label15.Size = new Size(20, 13);
      this.Label15.TabIndex = 32;
      this.Label15.Text = "m\u00B2";
      this.Label16.AutoSize = true;
      this.Label16.Location = new Point(270, 98);
      this.Label16.Name = "Label16";
      this.Label16.Size = new Size(20, 13);
      this.Label16.TabIndex = 33;
      this.Label16.Text = "m\u00B2";
      this.Label17.AutoSize = true;
      this.Label17.Location = new Point(270, 123);
      this.Label17.Name = "Label17";
      this.Label17.Size = new Size(20, 13);
      this.Label17.TabIndex = 34;
      this.Label17.Text = "m\u00B2";
      this.Label18.AutoSize = true;
      this.Label18.Location = new Point(270, 150);
      this.Label18.Name = "Label18";
      this.Label18.Size = new Size(20, 13);
      this.Label18.TabIndex = 35;
      this.Label18.Text = "m\u00B2";
      this.Label19.AutoSize = true;
      this.Label19.Location = new Point(116, 176);
      this.Label19.Name = "Label19";
      this.Label19.Size = new Size(57, 13);
      this.Label19.TabIndex = 36;
      this.Label19.Text = "Total Area";
      this.Label20.AutoSize = true;
      this.Label20.Location = new Point(270, 176);
      this.Label20.Name = "Label20";
      this.Label20.Size = new Size(20, 13);
      this.Label20.TabIndex = 39;
      this.Label20.Text = "m\u00B2";
      this.txtArea.Location = new Point(197, 169);
      this.txtArea.Name = "txtArea";
      this.txtArea.ReadOnly = true;
      this.txtArea.Size = new Size(67, 21);
      this.txtArea.TabIndex = 38;
      this.txtArea.TabStop = false;
      this.txtArea.Text = "0";
      this.txtArea.TextAlign = HorizontalAlignment.Right;
      this.Label21.AutoSize = true;
      this.Label21.Location = new Point(178, 175);
      this.Label21.Name = "Label21";
      this.Label21.Size = new Size(15, 13);
      this.Label21.TabIndex = 37;
      this.Label21.Text = "=";
      this.cmdLongAddress.BackColor = Color.LightSlateGray;
      this.cmdLongAddress.Cursor = Cursors.Hand;
      this.cmdLongAddress.FlatStyle = FlatStyle.Popup;
      this.cmdLongAddress.ForeColor = Color.White;
      this.cmdLongAddress.Location = new Point(181, 195);
      this.cmdLongAddress.Name = "cmdLongAddress";
      this.cmdLongAddress.Size = new Size(107, 23);
      this.cmdLongAddress.TabIndex = 12;
      this.cmdLongAddress.Text = "OK";
      this.cmdLongAddress.UseVisualStyleBackColor = false;
      this.Button1.BackColor = Color.LightSlateGray;
      this.Button1.Cursor = Cursors.Hand;
      this.Button1.DialogResult = DialogResult.Cancel;
      this.Button1.FlatStyle = FlatStyle.Popup;
      this.Button1.ForeColor = Color.White;
      this.Button1.Location = new Point(181, 224);
      this.Button1.Name = "Button1";
      this.Button1.Size = new Size(107, 23);
      this.Button1.TabIndex = 13;
      this.Button1.Text = "Cancel";
      this.Button1.UseVisualStyleBackColor = false;
      this.AcceptButton = (IButtonControl) this.cmdLongAddress;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.White;
      this.CancelButton = (IButtonControl) this.Button1;
      this.ClientSize = new Size(292, 252);
      this.Controls.Add((Control) this.Button1);
      this.Controls.Add((Control) this.cmdLongAddress);
      this.Controls.Add((Control) this.Label20);
      this.Controls.Add((Control) this.txtArea);
      this.Controls.Add((Control) this.Label21);
      this.Controls.Add((Control) this.Label19);
      this.Controls.Add((Control) this.Label18);
      this.Controls.Add((Control) this.Label17);
      this.Controls.Add((Control) this.Label16);
      this.Controls.Add((Control) this.Label15);
      this.Controls.Add((Control) this.Label14);
      this.Controls.Add((Control) this.Label13);
      this.Controls.Add((Control) this.txtA6);
      this.Controls.Add((Control) this.Label11);
      this.Controls.Add((Control) this.txtW6);
      this.Controls.Add((Control) this.Label12);
      this.Controls.Add((Control) this.txtL6);
      this.Controls.Add((Control) this.txtA5);
      this.Controls.Add((Control) this.Label9);
      this.Controls.Add((Control) this.txtW5);
      this.Controls.Add((Control) this.Label10);
      this.Controls.Add((Control) this.txtL5);
      this.Controls.Add((Control) this.txtA4);
      this.Controls.Add((Control) this.Label7);
      this.Controls.Add((Control) this.txtW4);
      this.Controls.Add((Control) this.Label8);
      this.Controls.Add((Control) this.txtL4);
      this.Controls.Add((Control) this.txtA3);
      this.Controls.Add((Control) this.Label5);
      this.Controls.Add((Control) this.txtW3);
      this.Controls.Add((Control) this.Label6);
      this.Controls.Add((Control) this.txtL3);
      this.Controls.Add((Control) this.txtA2);
      this.Controls.Add((Control) this.Label3);
      this.Controls.Add((Control) this.txtW2);
      this.Controls.Add((Control) this.Label4);
      this.Controls.Add((Control) this.txtL2);
      this.Controls.Add((Control) this.txtA1);
      this.Controls.Add((Control) this.Label2);
      this.Controls.Add((Control) this.txtW1);
      this.Controls.Add((Control) this.Label1);
      this.Controls.Add((Control) this.txtL1);
      this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.HelpButton = true;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (AreaCalc);
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Area Calculation";
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    internal virtual TextBox txtL1
    {
      get => this._txtL1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtL1_TextChanged);
        TextBox txtL1_1 = this._txtL1;
        if (txtL1_1 != null)
          txtL1_1.TextChanged -= eventHandler;
        this._txtL1 = value;
        TextBox txtL1_2 = this._txtL1;
        if (txtL1_2 == null)
          return;
        txtL1_2.TextChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Label1")]
    internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox txtW1
    {
      get => this._txtW1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtW1_TextChanged);
        TextBox txtW1_1 = this._txtW1;
        if (txtW1_1 != null)
          txtW1_1.TextChanged -= eventHandler;
        this._txtW1 = value;
        TextBox txtW1_2 = this._txtW1;
        if (txtW1_2 == null)
          return;
        txtW1_2.TextChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Label2")]
    internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtA1")]
    internal virtual TextBox txtA1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtA2")]
    internal virtual TextBox txtA2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label3")]
    internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox txtW2
    {
      get => this._txtW2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtW2_TextChanged);
        TextBox txtW2_1 = this._txtW2;
        if (txtW2_1 != null)
          txtW2_1.TextChanged -= eventHandler;
        this._txtW2 = value;
        TextBox txtW2_2 = this._txtW2;
        if (txtW2_2 == null)
          return;
        txtW2_2.TextChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Label4")]
    internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox txtL2
    {
      get => this._txtL2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtL2_TextChanged);
        TextBox txtL2_1 = this._txtL2;
        if (txtL2_1 != null)
          txtL2_1.TextChanged -= eventHandler;
        this._txtL2 = value;
        TextBox txtL2_2 = this._txtL2;
        if (txtL2_2 == null)
          return;
        txtL2_2.TextChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("txtA3")]
    internal virtual TextBox txtA3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label5")]
    internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox txtW3
    {
      get => this._txtW3;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtW3_TextChanged);
        TextBox txtW3_1 = this._txtW3;
        if (txtW3_1 != null)
          txtW3_1.TextChanged -= eventHandler;
        this._txtW3 = value;
        TextBox txtW3_2 = this._txtW3;
        if (txtW3_2 == null)
          return;
        txtW3_2.TextChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Label6")]
    internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox txtL3
    {
      get => this._txtL3;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtL3_TextChanged);
        TextBox txtL3_1 = this._txtL3;
        if (txtL3_1 != null)
          txtL3_1.TextChanged -= eventHandler;
        this._txtL3 = value;
        TextBox txtL3_2 = this._txtL3;
        if (txtL3_2 == null)
          return;
        txtL3_2.TextChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("txtA4")]
    internal virtual TextBox txtA4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label7")]
    internal virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox txtW4
    {
      get => this._txtW4;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtW4_TextChanged);
        TextBox txtW4_1 = this._txtW4;
        if (txtW4_1 != null)
          txtW4_1.TextChanged -= eventHandler;
        this._txtW4 = value;
        TextBox txtW4_2 = this._txtW4;
        if (txtW4_2 == null)
          return;
        txtW4_2.TextChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Label8")]
    internal virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox txtL4
    {
      get => this._txtL4;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtL4_TextChanged);
        TextBox txtL4_1 = this._txtL4;
        if (txtL4_1 != null)
          txtL4_1.TextChanged -= eventHandler;
        this._txtL4 = value;
        TextBox txtL4_2 = this._txtL4;
        if (txtL4_2 == null)
          return;
        txtL4_2.TextChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("txtA5")]
    internal virtual TextBox txtA5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label9")]
    internal virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox txtW5
    {
      get => this._txtW5;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtW5_TextChanged);
        TextBox txtW5_1 = this._txtW5;
        if (txtW5_1 != null)
          txtW5_1.TextChanged -= eventHandler;
        this._txtW5 = value;
        TextBox txtW5_2 = this._txtW5;
        if (txtW5_2 == null)
          return;
        txtW5_2.TextChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Label10")]
    internal virtual Label Label10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox txtL5
    {
      get => this._txtL5;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtL5_TextChanged);
        TextBox txtL5_1 = this._txtL5;
        if (txtL5_1 != null)
          txtL5_1.TextChanged -= eventHandler;
        this._txtL5 = value;
        TextBox txtL5_2 = this._txtL5;
        if (txtL5_2 == null)
          return;
        txtL5_2.TextChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("txtA6")]
    internal virtual TextBox txtA6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label11")]
    internal virtual Label Label11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox txtW6
    {
      get => this._txtW6;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtW6_TextChanged);
        TextBox txtW6_1 = this._txtW6;
        if (txtW6_1 != null)
          txtW6_1.TextChanged -= eventHandler;
        this._txtW6 = value;
        TextBox txtW6_2 = this._txtW6;
        if (txtW6_2 == null)
          return;
        txtW6_2.TextChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Label12")]
    internal virtual Label Label12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox txtL6
    {
      get => this._txtL6;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtL6_TextChanged);
        TextBox txtL6_1 = this._txtL6;
        if (txtL6_1 != null)
          txtL6_1.TextChanged -= eventHandler;
        this._txtL6 = value;
        TextBox txtL6_2 = this._txtL6;
        if (txtL6_2 == null)
          return;
        txtL6_2.TextChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Label13")]
    internal virtual Label Label13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label14")]
    internal virtual Label Label14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label15")]
    internal virtual Label Label15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label16")]
    internal virtual Label Label16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label17")]
    internal virtual Label Label17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label18")]
    internal virtual Label Label18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label19")]
    internal virtual Label Label19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label20")]
    internal virtual Label Label20 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtArea")]
    internal virtual TextBox txtArea { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label21")]
    internal virtual Label Label21 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button cmdLongAddress
    {
      get => this._cmdLongAddress;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdLongAddress_Click);
        Button cmdLongAddress1 = this._cmdLongAddress;
        if (cmdLongAddress1 != null)
          cmdLongAddress1.Click -= eventHandler;
        this._cmdLongAddress = value;
        Button cmdLongAddress2 = this._cmdLongAddress;
        if (cmdLongAddress2 == null)
          return;
        cmdLongAddress2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Button1")]
    internal virtual Button Button1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    public void AreaCalc()
    {
      this.txtArea.Text = Conversions.ToString(0);
      int num = 1;
      do
      {
        this.Controls["txtA" + Conversions.ToString(num)].Text = Strings.Format((object) (Conversion.Val(this.Controls["txtL" + Conversions.ToString(num)].Text) * Conversion.Val(this.Controls["txtW" + Conversions.ToString(num)].Text)), "#0.000");
        this.txtArea.Text = Conversions.ToString(Conversion.Val(this.txtArea.Text) + Conversion.Val(this.Controls["txtA" + Conversions.ToString(num)].Text));
        checked { ++num; }
      }
      while (num <= 6);
    }

    private void txtL1_TextChanged(object sender, EventArgs e) => this.AreaCalc();

    private void txtW1_TextChanged(object sender, EventArgs e) => this.AreaCalc();

    private void txtL2_TextChanged(object sender, EventArgs e) => this.AreaCalc();

    private void txtW2_TextChanged(object sender, EventArgs e) => this.AreaCalc();

    private void txtL3_TextChanged(object sender, EventArgs e) => this.AreaCalc();

    private void txtW3_TextChanged(object sender, EventArgs e) => this.AreaCalc();

    private void txtL4_TextChanged(object sender, EventArgs e) => this.AreaCalc();

    private void txtW4_TextChanged(object sender, EventArgs e) => this.AreaCalc();

    private void txtL5_TextChanged(object sender, EventArgs e) => this.AreaCalc();

    private void txtW5_TextChanged(object sender, EventArgs e) => this.AreaCalc();

    private void txtL6_TextChanged(object sender, EventArgs e) => this.AreaCalc();

    private void txtW6_TextChanged(object sender, EventArgs e) => this.AreaCalc();

    private void AreaCalc_FormClosing(object sender, FormClosingEventArgs e) => MyProject.Forms.SAPForm.Enabled = true;

    private void cmdLongAddress_Click(object sender, EventArgs e) => this.DialogResult = DialogResult.OK;
  }
}
