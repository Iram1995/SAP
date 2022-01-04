
// Type: SAP2012.GenResults




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
  public class GenResults : Form
  {
    private IContainer components;
    private int x;
    private int y;

    public GenResults()
    {
      this.Load += new EventHandler(this.GenResults_Load);
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
      this.Btn254 = new Button();
      this.Button251 = new Button();
      this.Btn2411 = new Button();
      this.Button32Sec = new Button();
      this.Btn45 = new Button();
      this.Btn31 = new Button();
      this.Btn252 = new Button();
      this.Btn251 = new Button();
      this.Btn242 = new Button();
      this.Btn241 = new Button();
      this.Btn231 = new Button();
      this.Btn214 = new Button();
      this.Btn213 = new Button();
      this.Btn212 = new Button();
      this.Btn211 = new Button();
      this.Panel1 = new Panel();
      this.Button1 = new Button();
      this.btn260 = new Button();
      this.Btn253 = new Button();
      this.Button2111 = new Button();
      this.Button231 = new Button();
      this.Btn1 = new Button();
      this.Button2 = new Button();
      this.Panel1.SuspendLayout();
      this.SuspendLayout();
      this.Btn254.BackColor = Color.Green;
      this.Btn254.Cursor = Cursors.Hand;
      this.Btn254.FlatAppearance.BorderColor = Color.Black;
      this.Btn254.FlatStyle = FlatStyle.Flat;
      this.Btn254.Font = new Font("Calibri", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Btn254.ForeColor = Color.White;
      this.Btn254.Location = new Point(10, 524);
      this.Btn254.Name = "Btn254";
      this.Btn254.Size = new Size(336, 26);
      this.Btn254.TabIndex = 16;
      this.Btn254.Text = "6.4 Independent timer for DHW";
      this.Btn254.TextAlign = ContentAlignment.TopLeft;
      this.Btn254.UseVisualStyleBackColor = false;
      this.Button251.BackColor = Color.Green;
      this.Button251.Cursor = Cursors.Hand;
      this.Button251.Enabled = false;
      this.Button251.FlatAppearance.BorderColor = Color.Black;
      this.Button251.FlatStyle = FlatStyle.Flat;
      this.Button251.Font = new Font("Calibri", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button251.ForeColor = Color.White;
      this.Button251.Location = new Point(10, 464);
      this.Button251.Name = "Button251";
      this.Button251.Size = new Size(336, 26);
      this.Button251.TabIndex = 15;
      this.Button251.Text = "6.2 Space Heating Controls 2";
      this.Button251.TextAlign = ContentAlignment.TopLeft;
      this.Button251.UseVisualStyleBackColor = false;
      this.Btn2411.BackColor = Color.Green;
      this.Btn2411.Cursor = Cursors.Hand;
      this.Btn2411.FlatAppearance.BorderColor = Color.Black;
      this.Btn2411.FlatStyle = FlatStyle.Flat;
      this.Btn2411.Font = new Font("Calibri", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Btn2411.ForeColor = Color.White;
      this.Btn2411.Location = new Point(10, 374);
      this.Btn2411.Name = "Btn2411";
      this.Btn2411.Size = new Size(336, 26);
      this.Btn2411.TabIndex = 14;
      this.Btn2411.Text = "5.2 Primary Pipe work";
      this.Btn2411.TextAlign = ContentAlignment.TopLeft;
      this.Btn2411.UseVisualStyleBackColor = false;
      this.Button32Sec.BackColor = Color.Green;
      this.Button32Sec.Cursor = Cursors.Hand;
      this.Button32Sec.FlatAppearance.BorderColor = Color.Black;
      this.Button32Sec.FlatStyle = FlatStyle.Flat;
      this.Button32Sec.Font = new Font("Calibri", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button32Sec.ForeColor = Color.White;
      this.Button32Sec.Location = new Point(11, 313);
      this.Button32Sec.Name = "Button32Sec";
      this.Button32Sec.Size = new Size(336, 26);
      this.Button32Sec.TabIndex = 13;
      this.Button32Sec.Text = "4.3 Secondary Heating";
      this.Button32Sec.TextAlign = ContentAlignment.TopLeft;
      this.Button32Sec.UseVisualStyleBackColor = false;
      this.Btn45.BackColor = Color.Green;
      this.Btn45.Cursor = Cursors.Hand;
      this.Btn45.FlatAppearance.BorderColor = Color.Black;
      this.Btn45.FlatStyle = FlatStyle.Flat;
      this.Btn45.Font = new Font("Calibri", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Btn45.ForeColor = Color.White;
      this.Btn45.Location = new Point(11, 222);
      this.Btn45.Name = "Btn45";
      this.Btn45.Size = new Size(336, 26);
      this.Btn45.TabIndex = 12;
      this.Btn45.Text = " 3 Design Air permeability";
      this.Btn45.TextAlign = ContentAlignment.TopLeft;
      this.Btn45.UseVisualStyleBackColor = false;
      this.Btn31.BackColor = Color.Green;
      this.Btn31.Cursor = Cursors.Hand;
      this.Btn31.FlatAppearance.BorderColor = Color.Black;
      this.Btn31.FlatStyle = FlatStyle.Flat;
      this.Btn31.Font = new Font("Calibri", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Btn31.ForeColor = Color.White;
      this.Btn31.Location = new Point(11, 648);
      this.Btn31.Name = "Btn31";
      this.Btn31.Size = new Size(336, 26);
      this.Btn31.TabIndex = 10;
      this.Btn31.Text = "9 Summertime Temperature";
      this.Btn31.TextAlign = ContentAlignment.TopLeft;
      this.Btn31.UseVisualStyleBackColor = false;
      this.Btn252.BackColor = Color.Green;
      this.Btn252.Cursor = Cursors.Hand;
      this.Btn252.FlatAppearance.BorderColor = Color.Black;
      this.Btn252.FlatStyle = FlatStyle.Flat;
      this.Btn252.Font = new Font("Calibri", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Btn252.ForeColor = Color.White;
      this.Btn252.Location = new Point(10, 554);
      this.Btn252.Name = "Btn252";
      this.Btn252.Size = new Size(336, 26);
      this.Btn252.TabIndex = 9;
      this.Btn252.Text = "6.5 Boiler interlock";
      this.Btn252.TextAlign = ContentAlignment.TopLeft;
      this.Btn252.UseVisualStyleBackColor = false;
      this.Btn251.BackColor = Color.Green;
      this.Btn251.Cursor = Cursors.Hand;
      this.Btn251.FlatAppearance.BorderColor = Color.Black;
      this.Btn251.FlatStyle = FlatStyle.Flat;
      this.Btn251.Font = new Font("Calibri", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Btn251.ForeColor = Color.White;
      this.Btn251.Location = new Point(10, 434);
      this.Btn251.Name = "Btn251";
      this.Btn251.Size = new Size(336, 26);
      this.Btn251.TabIndex = 8;
      this.Btn251.Text = "6.1 Space Heating Controls 1";
      this.Btn251.TextAlign = ContentAlignment.TopLeft;
      this.Btn251.UseVisualStyleBackColor = false;
      this.Btn242.BackColor = Color.Green;
      this.Btn242.Cursor = Cursors.Hand;
      this.Btn242.FlatAppearance.BorderColor = Color.Black;
      this.Btn242.FlatStyle = FlatStyle.Flat;
      this.Btn242.Font = new Font("Calibri", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Btn242.ForeColor = Color.White;
      this.Btn242.Location = new Point(10, 404);
      this.Btn242.Name = "Btn242";
      this.Btn242.Size = new Size(336, 26);
      this.Btn242.TabIndex = 7;
      this.Btn242.Text = "5.3 Solar Storage Volume ";
      this.Btn242.TextAlign = ContentAlignment.TopLeft;
      this.Btn242.UseVisualStyleBackColor = false;
      this.Btn241.BackColor = Color.Green;
      this.Btn241.Cursor = Cursors.Hand;
      this.Btn241.FlatAppearance.BorderColor = Color.Black;
      this.Btn241.FlatStyle = FlatStyle.Flat;
      this.Btn241.Font = new Font("Calibri", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Btn241.ForeColor = Color.White;
      this.Btn241.Location = new Point(10, 344);
      this.Btn241.Name = "Btn241";
      this.Btn241.Size = new Size(336, 26);
      this.Btn241.TabIndex = 6;
      this.Btn241.Text = "5.1 Hot water Storage";
      this.Btn241.TextAlign = ContentAlignment.TopLeft;
      this.Btn241.UseVisualStyleBackColor = false;
      this.Btn231.BackColor = Color.Green;
      this.Btn231.Cursor = Cursors.Hand;
      this.Btn231.FlatAppearance.BorderColor = Color.Black;
      this.Btn231.FlatStyle = FlatStyle.Flat;
      this.Btn231.Font = new Font("Calibri", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Btn231.ForeColor = Color.White;
      this.Btn231.Location = new Point(10, 252);
      this.Btn231.Name = "Btn231";
      this.Btn231.Size = new Size(336, 26);
      this.Btn231.TabIndex = 5;
      this.Btn231.Text = "4.1 Main Heating";
      this.Btn231.TextAlign = ContentAlignment.TopLeft;
      this.Btn231.UseVisualStyleBackColor = false;
      this.Btn214.BackColor = Color.Green;
      this.Btn214.Cursor = Cursors.Hand;
      this.Btn214.FlatAppearance.BorderColor = Color.Black;
      this.Btn214.FlatStyle = FlatStyle.Flat;
      this.Btn214.Font = new Font("Calibri", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Btn214.ForeColor = Color.White;
      this.Btn214.Location = new Point(10, 192);
      this.Btn214.Name = "Btn214";
      this.Btn214.Size = new Size(336, 26);
      this.Btn214.TabIndex = 4;
      this.Btn214.Text = "2.4 Openings";
      this.Btn214.TextAlign = ContentAlignment.TopLeft;
      this.Btn214.UseVisualStyleBackColor = false;
      this.Btn213.BackColor = Color.Green;
      this.Btn213.Cursor = Cursors.Hand;
      this.Btn213.FlatAppearance.BorderColor = Color.Black;
      this.Btn213.FlatStyle = FlatStyle.Flat;
      this.Btn213.Font = new Font("Calibri", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Btn213.ForeColor = Color.White;
      this.Btn213.Location = new Point(10, 162);
      this.Btn213.Name = "Btn213";
      this.Btn213.Size = new Size(336, 26);
      this.Btn213.TabIndex = 3;
      this.Btn213.Text = "2.3 Roof";
      this.Btn213.TextAlign = ContentAlignment.TopLeft;
      this.Btn213.UseVisualStyleBackColor = false;
      this.Btn212.BackColor = Color.Green;
      this.Btn212.Cursor = Cursors.Hand;
      this.Btn212.FlatAppearance.BorderColor = Color.Black;
      this.Btn212.FlatStyle = FlatStyle.Flat;
      this.Btn212.Font = new Font("Calibri", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Btn212.ForeColor = Color.White;
      this.Btn212.Location = new Point(10, 132);
      this.Btn212.Name = "Btn212";
      this.Btn212.Size = new Size(336, 26);
      this.Btn212.TabIndex = 2;
      this.Btn212.Text = "2.2 Floor";
      this.Btn212.TextAlign = ContentAlignment.TopLeft;
      this.Btn212.UseVisualStyleBackColor = false;
      this.Btn211.BackColor = Color.Green;
      this.Btn211.Cursor = Cursors.Hand;
      this.Btn211.FlatAppearance.BorderColor = Color.Black;
      this.Btn211.FlatStyle = FlatStyle.Flat;
      this.Btn211.Font = new Font("Calibri", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Btn211.ForeColor = Color.White;
      this.Btn211.Location = new Point(10, 74);
      this.Btn211.Name = "Btn211";
      this.Btn211.Size = new Size(336, 26);
      this.Btn211.TabIndex = 1;
      this.Btn211.Text = "2.1 Wall";
      this.Btn211.TextAlign = ContentAlignment.TopLeft;
      this.Btn211.UseVisualStyleBackColor = false;
      this.Panel1.AutoScroll = true;
      this.Panel1.BackColor = Color.White;
      this.Panel1.BorderStyle = BorderStyle.Fixed3D;
      this.Panel1.Controls.Add((Control) this.Button2);
      this.Panel1.Controls.Add((Control) this.Button1);
      this.Panel1.Controls.Add((Control) this.btn260);
      this.Panel1.Controls.Add((Control) this.Btn253);
      this.Panel1.Controls.Add((Control) this.Button2111);
      this.Panel1.Controls.Add((Control) this.Button231);
      this.Panel1.Controls.Add((Control) this.Btn254);
      this.Panel1.Controls.Add((Control) this.Button251);
      this.Panel1.Controls.Add((Control) this.Btn2411);
      this.Panel1.Controls.Add((Control) this.Button32Sec);
      this.Panel1.Controls.Add((Control) this.Btn45);
      this.Panel1.Controls.Add((Control) this.Btn31);
      this.Panel1.Controls.Add((Control) this.Btn252);
      this.Panel1.Controls.Add((Control) this.Btn251);
      this.Panel1.Controls.Add((Control) this.Btn242);
      this.Panel1.Controls.Add((Control) this.Btn241);
      this.Panel1.Controls.Add((Control) this.Btn231);
      this.Panel1.Controls.Add((Control) this.Btn214);
      this.Panel1.Controls.Add((Control) this.Btn213);
      this.Panel1.Controls.Add((Control) this.Btn212);
      this.Panel1.Controls.Add((Control) this.Btn211);
      this.Panel1.Controls.Add((Control) this.Btn1);
      this.Panel1.Dock = DockStyle.Fill;
      this.Panel1.Location = new Point(9, 9);
      this.Panel1.Name = "Panel1";
      this.Panel1.Size = new Size(353, 731);
      this.Panel1.TabIndex = 1;
      this.Button1.BackColor = Color.Green;
      this.Button1.Cursor = Cursors.Hand;
      this.Button1.FlatAppearance.BorderColor = Color.Black;
      this.Button1.FlatStyle = FlatStyle.Flat;
      this.Button1.Font = new Font("Calibri", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button1.ForeColor = Color.White;
      this.Button1.Location = new Point(10, 616);
      this.Button1.Name = "Button1";
      this.Button1.Size = new Size(336, 26);
      this.Button1.TabIndex = 21;
      this.Button1.Text = "8 Mechanical ventilation";
      this.Button1.TextAlign = ContentAlignment.TopLeft;
      this.Button1.UseVisualStyleBackColor = false;
      this.btn260.BackColor = Color.Green;
      this.btn260.Cursor = Cursors.Hand;
      this.btn260.FlatAppearance.BorderColor = Color.Black;
      this.btn260.FlatStyle = FlatStyle.Flat;
      this.btn260.Font = new Font("Calibri", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btn260.ForeColor = Color.White;
      this.btn260.Location = new Point(10, 584);
      this.btn260.Name = "btn260";
      this.btn260.Size = new Size(336, 26);
      this.btn260.TabIndex = 20;
      this.btn260.Text = "7 Low energy lights";
      this.btn260.TextAlign = ContentAlignment.TopLeft;
      this.btn260.UseVisualStyleBackColor = false;
      this.Btn253.BackColor = Color.Green;
      this.Btn253.Cursor = Cursors.Hand;
      this.Btn253.Enabled = false;
      this.Btn253.FlatAppearance.BorderColor = Color.Black;
      this.Btn253.FlatStyle = FlatStyle.Flat;
      this.Btn253.Font = new Font("Calibri", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Btn253.ForeColor = Color.White;
      this.Btn253.Location = new Point(9, 494);
      this.Btn253.Name = "Btn253";
      this.Btn253.Size = new Size(336, 26);
      this.Btn253.TabIndex = 19;
      this.Btn253.Text = "6.3 Cylinderstat";
      this.Btn253.TextAlign = ContentAlignment.TopLeft;
      this.Btn253.UseVisualStyleBackColor = false;
      this.Button2111.BackColor = Color.Green;
      this.Button2111.Cursor = Cursors.Hand;
      this.Button2111.FlatAppearance.BorderColor = Color.Black;
      this.Button2111.FlatStyle = FlatStyle.Flat;
      this.Button2111.Font = new Font("Calibri", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button2111.ForeColor = Color.White;
      this.Button2111.Location = new Point(10, 102);
      this.Button2111.Name = "Button2111";
      this.Button2111.Size = new Size(336, 26);
      this.Button2111.TabIndex = 18;
      this.Button2111.Text = "2.1.1 Party Wall";
      this.Button2111.TextAlign = ContentAlignment.TopLeft;
      this.Button2111.UseVisualStyleBackColor = false;
      this.Button231.BackColor = Color.Green;
      this.Button231.Cursor = Cursors.Hand;
      this.Button231.Enabled = false;
      this.Button231.FlatAppearance.BorderColor = Color.Black;
      this.Button231.FlatStyle = FlatStyle.Flat;
      this.Button231.Font = new Font("Calibri", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button231.ForeColor = Color.White;
      this.Button231.Location = new Point(10, 282);
      this.Button231.Name = "Button231";
      this.Button231.Size = new Size(336, 26);
      this.Button231.TabIndex = 17;
      this.Button231.Text = "4.2 Main Heating 2";
      this.Button231.TextAlign = ContentAlignment.TopLeft;
      this.Button231.UseVisualStyleBackColor = false;
      this.Btn1.BackColor = Color.Green;
      this.Btn1.Cursor = Cursors.Hand;
      this.Btn1.FlatAppearance.BorderColor = Color.Black;
      this.Btn1.FlatStyle = FlatStyle.Flat;
      this.Btn1.Font = new Font("Calibri", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Btn1.ForeColor = Color.White;
      this.Btn1.Location = new Point(10, 10);
      this.Btn1.Name = "Btn1";
      this.Btn1.Size = new Size(336, 26);
      this.Btn1.TabIndex = 0;
      this.Btn1.Text = "1 DER TER";
      this.Btn1.TextAlign = ContentAlignment.TopLeft;
      this.Btn1.UseVisualStyleBackColor = false;
      this.Button2.BackColor = Color.Green;
      this.Button2.Cursor = Cursors.Hand;
      this.Button2.FlatAppearance.BorderColor = Color.Black;
      this.Button2.FlatStyle = FlatStyle.Flat;
      this.Button2.Font = new Font("Calibri", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button2.ForeColor = Color.White;
      this.Button2.Location = new Point(9, 42);
      this.Button2.Name = "Button2";
      this.Button2.Size = new Size(336, 26);
      this.Button2.TabIndex = 22;
      this.Button2.Text = "1.1 DFEE TFEE";
      this.Button2.TextAlign = ContentAlignment.TopLeft;
      this.Button2.UseVisualStyleBackColor = false;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(371, 749);
      this.Controls.Add((Control) this.Panel1);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (GenResults);
      this.Padding = new Padding(9);
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = nameof (GenResults);
      this.TopMost = true;
      this.Panel1.ResumeLayout(false);
      this.ResumeLayout(false);
    }

    internal virtual Button Btn254
    {
      get => this._Btn254;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Btn254_Click);
        Button btn254_1 = this._Btn254;
        if (btn254_1 != null)
          btn254_1.Click -= eventHandler;
        this._Btn254 = value;
        Button btn254_2 = this._Btn254;
        if (btn254_2 == null)
          return;
        btn254_2.Click += eventHandler;
      }
    }

    internal virtual Button Button251
    {
      get => this._Button251;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Btn253_Click);
        Button button251_1 = this._Button251;
        if (button251_1 != null)
          button251_1.Click -= eventHandler;
        this._Button251 = value;
        Button button251_2 = this._Button251;
        if (button251_2 == null)
          return;
        button251_2.Click += eventHandler;
      }
    }

    internal virtual Button Btn2411
    {
      get => this._Btn2411;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Btn2411_Click);
        Button btn2411_1 = this._Btn2411;
        if (btn2411_1 != null)
          btn2411_1.Click -= eventHandler;
        this._Btn2411 = value;
        Button btn2411_2 = this._Btn2411;
        if (btn2411_2 == null)
          return;
        btn2411_2.Click += eventHandler;
      }
    }

    internal virtual Button Button32Sec
    {
      get => this._Button32Sec;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button32Sec_Click);
        Button button32Sec1 = this._Button32Sec;
        if (button32Sec1 != null)
          button32Sec1.Click -= eventHandler;
        this._Button32Sec = value;
        Button button32Sec2 = this._Button32Sec;
        if (button32Sec2 == null)
          return;
        button32Sec2.Click += eventHandler;
      }
    }

    internal virtual Button Btn45
    {
      get => this._Btn45;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Btn45_Click);
        Button btn45_1 = this._Btn45;
        if (btn45_1 != null)
          btn45_1.Click -= eventHandler;
        this._Btn45 = value;
        Button btn45_2 = this._Btn45;
        if (btn45_2 == null)
          return;
        btn45_2.Click += eventHandler;
      }
    }

    internal virtual Button Btn31
    {
      get => this._Btn31;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Btn31_Click);
        Button btn31_1 = this._Btn31;
        if (btn31_1 != null)
          btn31_1.Click -= eventHandler;
        this._Btn31 = value;
        Button btn31_2 = this._Btn31;
        if (btn31_2 == null)
          return;
        btn31_2.Click += eventHandler;
      }
    }

    internal virtual Button Btn252
    {
      get => this._Btn252;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Btn252_Click);
        Button btn252_1 = this._Btn252;
        if (btn252_1 != null)
          btn252_1.Click -= eventHandler;
        this._Btn252 = value;
        Button btn252_2 = this._Btn252;
        if (btn252_2 == null)
          return;
        btn252_2.Click += eventHandler;
      }
    }

    internal virtual Button Btn251
    {
      get => this._Btn251;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Btn251_Click);
        Button btn251_1 = this._Btn251;
        if (btn251_1 != null)
          btn251_1.Click -= eventHandler;
        this._Btn251 = value;
        Button btn251_2 = this._Btn251;
        if (btn251_2 == null)
          return;
        btn251_2.Click += eventHandler;
      }
    }

    internal virtual Button Btn242
    {
      get => this._Btn242;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Btn242_Click);
        Button btn242_1 = this._Btn242;
        if (btn242_1 != null)
          btn242_1.Click -= eventHandler;
        this._Btn242 = value;
        Button btn242_2 = this._Btn242;
        if (btn242_2 == null)
          return;
        btn242_2.Click += eventHandler;
      }
    }

    internal virtual Button Btn241
    {
      get => this._Btn241;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Btn241_Click);
        Button btn241_1 = this._Btn241;
        if (btn241_1 != null)
          btn241_1.Click -= eventHandler;
        this._Btn241 = value;
        Button btn241_2 = this._Btn241;
        if (btn241_2 == null)
          return;
        btn241_2.Click += eventHandler;
      }
    }

    internal virtual Button Btn231
    {
      get => this._Btn231;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Btn231_Click);
        Button btn231_1 = this._Btn231;
        if (btn231_1 != null)
          btn231_1.Click -= eventHandler;
        this._Btn231 = value;
        Button btn231_2 = this._Btn231;
        if (btn231_2 == null)
          return;
        btn231_2.Click += eventHandler;
      }
    }

    internal virtual Button Btn214
    {
      get => this._Btn214;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Btn214_Click);
        Button btn214_1 = this._Btn214;
        if (btn214_1 != null)
          btn214_1.Click -= eventHandler;
        this._Btn214 = value;
        Button btn214_2 = this._Btn214;
        if (btn214_2 == null)
          return;
        btn214_2.Click += eventHandler;
      }
    }

    internal virtual Button Btn213
    {
      get => this._Btn213;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Btn213_Click);
        Button btn213_1 = this._Btn213;
        if (btn213_1 != null)
          btn213_1.Click -= eventHandler;
        this._Btn213 = value;
        Button btn213_2 = this._Btn213;
        if (btn213_2 == null)
          return;
        btn213_2.Click += eventHandler;
      }
    }

    internal virtual Button Btn212
    {
      get => this._Btn212;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Btn212_Click);
        Button btn212_1 = this._Btn212;
        if (btn212_1 != null)
          btn212_1.Click -= eventHandler;
        this._Btn212 = value;
        Button btn212_2 = this._Btn212;
        if (btn212_2 == null)
          return;
        btn212_2.Click += eventHandler;
      }
    }

    internal virtual Button Btn211
    {
      get => this._Btn211;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Btn211_Click);
        Button btn211_1 = this._Btn211;
        if (btn211_1 != null)
          btn211_1.Click -= eventHandler;
        this._Btn211 = value;
        Button btn211_2 = this._Btn211;
        if (btn211_2 == null)
          return;
        btn211_2.Click += eventHandler;
      }
    }

    internal virtual Panel Panel1
    {
      get => this._Panel1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        MouseEventHandler mouseEventHandler1 = new MouseEventHandler(this.Panel1_MouseDown);
        MouseEventHandler mouseEventHandler2 = new MouseEventHandler(this.Panel1_MouseMove);
        MouseEventHandler mouseEventHandler3 = new MouseEventHandler(this.Panel1_MouseUp);
        Panel panel1_1 = this._Panel1;
        if (panel1_1 != null)
        {
          panel1_1.MouseDown -= mouseEventHandler1;
          panel1_1.MouseMove -= mouseEventHandler2;
          panel1_1.MouseUp -= mouseEventHandler3;
        }
        this._Panel1 = value;
        Panel panel1_2 = this._Panel1;
        if (panel1_2 == null)
          return;
        panel1_2.MouseDown += mouseEventHandler1;
        panel1_2.MouseMove += mouseEventHandler2;
        panel1_2.MouseUp += mouseEventHandler3;
      }
    }

    internal virtual Button Btn1
    {
      get => this._Btn1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Btn1_Click);
        Button btn1_1 = this._Btn1;
        if (btn1_1 != null)
          btn1_1.Click -= eventHandler;
        this._Btn1 = value;
        Button btn1_2 = this._Btn1;
        if (btn1_2 == null)
          return;
        btn1_2.Click += eventHandler;
      }
    }

    internal virtual Button Button231
    {
      get => this._Button231;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button231_Click);
        Button button231_1 = this._Button231;
        if (button231_1 != null)
          button231_1.Click -= eventHandler;
        this._Button231 = value;
        Button button231_2 = this._Button231;
        if (button231_2 == null)
          return;
        button231_2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Button2111")]
    internal virtual Button Button2111 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Btn253
    {
      get => this._Btn253;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Btn253_Click_1);
        Button btn253_1 = this._Btn253;
        if (btn253_1 != null)
          btn253_1.Click -= eventHandler;
        this._Btn253 = value;
        Button btn253_2 = this._Btn253;
        if (btn253_2 == null)
          return;
        btn253_2.Click += eventHandler;
      }
    }

    internal virtual Button btn260
    {
      get => this._btn260;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btn260_Click);
        Button btn260_1 = this._btn260;
        if (btn260_1 != null)
          btn260_1.Click -= eventHandler;
        this._btn260 = value;
        Button btn260_2 = this._btn260;
        if (btn260_2 == null)
          return;
        btn260_2.Click += eventHandler;
      }
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

    private void Panel1_MouseDown(object sender, MouseEventArgs e)
    {
      this.x = e.X;
      this.y = e.Y;
      this.Cursor = Cursors.SizeAll;
    }

    private void Panel1_MouseMove(object sender, MouseEventArgs e)
    {
      if ((uint) this.x <= 0U)
        return;
      this.Left = checked (Control.MousePosition.X - this.x);
      this.Top = checked (Control.MousePosition.Y - this.y);
    }

    private void Panel1_MouseUp(object sender, MouseEventArgs e)
    {
      this.x = 0;
      this.y = 0;
      this.Cursor = Cursors.Default;
    }

    private void OKButton_Click(object sender, EventArgs e) => this.Close();

    private void Btn1_Click(object sender, EventArgs e) => MyProject.Forms.SAPForm.TreeSAP.SelectedNode = MyProject.Forms.SAPForm.TreeSAP.Nodes[0].Nodes[SAP_Module.CurrDwelling].Nodes[1];

    private void Btn211_Click(object sender, EventArgs e) => MyProject.Forms.SAPForm.TreeSAP.SelectedNode = MyProject.Forms.SAPForm.TreeSAP.Nodes[0].Nodes[SAP_Module.CurrDwelling].Nodes[1];

    private void Btn212_Click(object sender, EventArgs e) => MyProject.Forms.SAPForm.TreeSAP.SelectedNode = MyProject.Forms.SAPForm.TreeSAP.Nodes[0].Nodes[SAP_Module.CurrDwelling].Nodes[1];

    private void Btn213_Click(object sender, EventArgs e) => MyProject.Forms.SAPForm.TreeSAP.SelectedNode = MyProject.Forms.SAPForm.TreeSAP.Nodes[0].Nodes[SAP_Module.CurrDwelling].Nodes[1];

    private void Btn214_Click(object sender, EventArgs e) => MyProject.Forms.SAPForm.TreeSAP.SelectedNode = MyProject.Forms.SAPForm.TreeSAP.Nodes[0].Nodes[SAP_Module.CurrDwelling].Nodes[2];

    private void Btn231_Click(object sender, EventArgs e) => MyProject.Forms.SAPForm.TreeSAP.SelectedNode = MyProject.Forms.SAPForm.TreeSAP.Nodes[0].Nodes[SAP_Module.CurrDwelling].Nodes[4];

    private void Button32Sec_Click(object sender, EventArgs e) => MyProject.Forms.SAPForm.TreeSAP.SelectedNode = MyProject.Forms.SAPForm.TreeSAP.Nodes[0].Nodes[SAP_Module.CurrDwelling].Nodes[4];

    private void Btn241_Click(object sender, EventArgs e) => MyProject.Forms.SAPForm.TreeSAP.SelectedNode = MyProject.Forms.SAPForm.TreeSAP.Nodes[0].Nodes[SAP_Module.CurrDwelling].Nodes[5];

    private void Btn2411_Click(object sender, EventArgs e) => MyProject.Forms.SAPForm.TreeSAP.SelectedNode = MyProject.Forms.SAPForm.TreeSAP.Nodes[0].Nodes[SAP_Module.CurrDwelling].Nodes[5];

    private void Btn242_Click(object sender, EventArgs e) => MyProject.Forms.SAPForm.TreeSAP.SelectedNode = MyProject.Forms.SAPForm.TreeSAP.Nodes[0].Nodes[SAP_Module.CurrDwelling].Nodes[5];

    private void Btn251_Click(object sender, EventArgs e) => MyProject.Forms.SAPForm.TreeSAP.SelectedNode = MyProject.Forms.SAPForm.TreeSAP.Nodes[0].Nodes[SAP_Module.CurrDwelling].Nodes[4];

    private void Btn253_Click(object sender, EventArgs e) => MyProject.Forms.SAPForm.TreeSAP.SelectedNode = MyProject.Forms.SAPForm.TreeSAP.Nodes[0].Nodes[SAP_Module.CurrDwelling].Nodes[4];

    private void Btn254_Click(object sender, EventArgs e) => MyProject.Forms.SAPForm.TreeSAP.SelectedNode = MyProject.Forms.SAPForm.TreeSAP.Nodes[0].Nodes[SAP_Module.CurrDwelling].Nodes[5];

    private void Btn252_Click(object sender, EventArgs e) => MyProject.Forms.SAPForm.TreeSAP.SelectedNode = MyProject.Forms.SAPForm.TreeSAP.Nodes[0].Nodes[SAP_Module.CurrDwelling].Nodes[4];

    private void Btn31_Click(object sender, EventArgs e) => MyProject.Forms.SAPForm.TreeSAP.SelectedNode = MyProject.Forms.SAPForm.TreeSAP.Nodes[0].Nodes[SAP_Module.CurrDwelling].Nodes[7];

    private void Btn45_Click(object sender, EventArgs e) => MyProject.Forms.SAPForm.TreeSAP.SelectedNode = MyProject.Forms.SAPForm.TreeSAP.Nodes[0].Nodes[SAP_Module.CurrDwelling].Nodes[3];

    private void Button231_Click(object sender, EventArgs e) => MyProject.Forms.SAPForm.TreeSAP.SelectedNode = MyProject.Forms.SAPForm.TreeSAP.Nodes[0].Nodes[SAP_Module.CurrDwelling].Nodes[4];

    private void Btn253_Click_1(object sender, EventArgs e) => MyProject.Forms.SAPForm.TreeSAP.SelectedNode = MyProject.Forms.SAPForm.TreeSAP.Nodes[0].Nodes[SAP_Module.CurrDwelling].Nodes[5];

    private void btn260_Click(object sender, EventArgs e) => MyProject.Forms.SAPForm.TreeSAP.SelectedNode = MyProject.Forms.SAPForm.TreeSAP.Nodes[0].Nodes[SAP_Module.CurrDwelling].Nodes[7];

    private void Button1_Click(object sender, EventArgs e) => MyProject.Forms.SAPForm.TreeSAP.SelectedNode = MyProject.Forms.SAPForm.TreeSAP.Nodes[0].Nodes[SAP_Module.CurrDwelling].Nodes[3];

    private void GenResults_Load(object sender, EventArgs e)
    {
    }

    private void Button2_Click(object sender, EventArgs e)
    {
    }
  }
}
