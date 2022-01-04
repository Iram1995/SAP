
// Type: SAP2012.Clients




using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SAP2012
{
  [DesignerGenerated]
  public class Clients : Form
  {
    private IContainer components;
    private DataView ClientView;
    private DataRowView ClientRow;

    public Clients()
    {
      this.Load += new EventHandler(this.Clients_Load);
      this.ClientView = new DataView();
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
      this.GroupBox3 = new GroupBox();
      this.Label19 = new Label();
      this.txtPCEmail = new TextBox();
      this.Label18 = new Label();
      this.txtPCFax = new TextBox();
      this.Label17 = new Label();
      this.txtPCPhone = new TextBox();
      this.Label15 = new Label();
      this.txtPCPCode = new TextBox();
      this.Label9 = new Label();
      this.txtPCCountry = new TextBox();
      this.Label10 = new Label();
      this.txtPCCity = new TextBox();
      this.Label11 = new Label();
      this.txtPCAdd3 = new TextBox();
      this.Label12 = new Label();
      this.txtPCAdd2 = new TextBox();
      this.Label13 = new Label();
      this.txtPCAdd1 = new TextBox();
      this.Label14 = new Label();
      this.txtPCNAme = new TextBox();
      this.Panel1 = new Panel();
      this.lstClients = new ListBox();
      this.Panel3 = new Panel();
      this.TextBox1 = new TextBox();
      this.Label1 = new Label();
      this.Panel2 = new Panel();
      this.Button2 = new Button();
      this.Button1 = new Button();
      this.cmdClose = new Button();
      this.GroupBox3.SuspendLayout();
      this.Panel1.SuspendLayout();
      this.Panel3.SuspendLayout();
      this.Panel2.SuspendLayout();
      this.SuspendLayout();
      this.GroupBox3.BackColor = Color.White;
      this.GroupBox3.Controls.Add((Control) this.Label19);
      this.GroupBox3.Controls.Add((Control) this.txtPCEmail);
      this.GroupBox3.Controls.Add((Control) this.Label18);
      this.GroupBox3.Controls.Add((Control) this.txtPCFax);
      this.GroupBox3.Controls.Add((Control) this.Label17);
      this.GroupBox3.Controls.Add((Control) this.txtPCPhone);
      this.GroupBox3.Controls.Add((Control) this.Label15);
      this.GroupBox3.Controls.Add((Control) this.txtPCPCode);
      this.GroupBox3.Controls.Add((Control) this.Label9);
      this.GroupBox3.Controls.Add((Control) this.txtPCCountry);
      this.GroupBox3.Controls.Add((Control) this.Label10);
      this.GroupBox3.Controls.Add((Control) this.txtPCCity);
      this.GroupBox3.Controls.Add((Control) this.Label11);
      this.GroupBox3.Controls.Add((Control) this.txtPCAdd3);
      this.GroupBox3.Controls.Add((Control) this.Label12);
      this.GroupBox3.Controls.Add((Control) this.txtPCAdd2);
      this.GroupBox3.Controls.Add((Control) this.Label13);
      this.GroupBox3.Controls.Add((Control) this.txtPCAdd1);
      this.GroupBox3.Controls.Add((Control) this.Label14);
      this.GroupBox3.Controls.Add((Control) this.txtPCNAme);
      this.GroupBox3.Dock = DockStyle.Fill;
      this.GroupBox3.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.GroupBox3.Location = new Point(201, 0);
      this.GroupBox3.Name = "GroupBox3";
      this.GroupBox3.Size = new Size(324, 292);
      this.GroupBox3.TabIndex = 3;
      this.GroupBox3.TabStop = false;
      this.GroupBox3.Text = "Client Details";
      this.Label19.AutoSize = true;
      this.Label19.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label19.Location = new Point(6, 272);
      this.Label19.Name = "Label19";
      this.Label19.Size = new Size(38, 14);
      this.Label19.TabIndex = 22;
      this.Label19.Text = "E-mail";
      this.txtPCEmail.Location = new Point((int) sbyte.MaxValue, 265);
      this.txtPCEmail.Name = "txtPCEmail";
      this.txtPCEmail.Size = new Size(188, 22);
      this.txtPCEmail.TabIndex = 9;
      this.Label18.AutoSize = true;
      this.Label18.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label18.Location = new Point(6, 244);
      this.Label18.Name = "Label18";
      this.Label18.Size = new Size(72, 14);
      this.Label18.TabIndex = 20;
      this.Label18.Text = "Fax Number";
      this.txtPCFax.Location = new Point((int) sbyte.MaxValue, 237);
      this.txtPCFax.Name = "txtPCFax";
      this.txtPCFax.Size = new Size(188, 22);
      this.txtPCFax.TabIndex = 8;
      this.Label17.AutoSize = true;
      this.Label17.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label17.Location = new Point(6, 216);
      this.Label17.Name = "Label17";
      this.Label17.Size = new Size(89, 14);
      this.Label17.TabIndex = 18;
      this.Label17.Text = "Phone Number";
      this.txtPCPhone.Location = new Point((int) sbyte.MaxValue, 209);
      this.txtPCPhone.Name = "txtPCPhone";
      this.txtPCPhone.Size = new Size(188, 22);
      this.txtPCPhone.TabIndex = 7;
      this.Label15.AutoSize = true;
      this.Label15.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label15.Location = new Point(6, 188);
      this.Label15.Name = "Label15";
      this.Label15.Size = new Size(63, 14);
      this.Label15.TabIndex = 14;
      this.Label15.Text = "Post Code";
      this.txtPCPCode.Location = new Point((int) sbyte.MaxValue, 181);
      this.txtPCPCode.Name = "txtPCPCode";
      this.txtPCPCode.Size = new Size(188, 22);
      this.txtPCPCode.TabIndex = 6;
      this.Label9.AutoSize = true;
      this.Label9.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label9.Location = new Point(6, 161);
      this.Label9.Name = "Label9";
      this.Label9.Size = new Size(50, 14);
      this.Label9.TabIndex = 12;
      this.Label9.Text = "Country";
      this.txtPCCountry.Location = new Point((int) sbyte.MaxValue, 154);
      this.txtPCCountry.Name = "txtPCCountry";
      this.txtPCCountry.Size = new Size(188, 22);
      this.txtPCCountry.TabIndex = 5;
      this.Label10.AutoSize = true;
      this.Label10.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label10.Location = new Point(6, 134);
      this.Label10.Name = "Label10";
      this.Label10.Size = new Size(27, 14);
      this.Label10.TabIndex = 10;
      this.Label10.Text = "City";
      this.txtPCCity.Location = new Point((int) sbyte.MaxValue, (int) sbyte.MaxValue);
      this.txtPCCity.Name = "txtPCCity";
      this.txtPCCity.Size = new Size(188, 22);
      this.txtPCCity.TabIndex = 4;
      this.Label11.AutoSize = true;
      this.Label11.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label11.Location = new Point(6, 107);
      this.Label11.Name = "Label11";
      this.Label11.Size = new Size(61, 14);
      this.Label11.TabIndex = 8;
      this.Label11.Text = "Address 3";
      this.txtPCAdd3.Location = new Point((int) sbyte.MaxValue, 100);
      this.txtPCAdd3.Name = "txtPCAdd3";
      this.txtPCAdd3.Size = new Size(188, 22);
      this.txtPCAdd3.TabIndex = 3;
      this.Label12.AutoSize = true;
      this.Label12.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label12.Location = new Point(6, 80);
      this.Label12.Name = "Label12";
      this.Label12.Size = new Size(61, 14);
      this.Label12.TabIndex = 6;
      this.Label12.Text = "Address 2";
      this.txtPCAdd2.Location = new Point((int) sbyte.MaxValue, 73);
      this.txtPCAdd2.Name = "txtPCAdd2";
      this.txtPCAdd2.Size = new Size(188, 22);
      this.txtPCAdd2.TabIndex = 2;
      this.Label13.AutoSize = true;
      this.Label13.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label13.Location = new Point(6, 53);
      this.Label13.Name = "Label13";
      this.Label13.Size = new Size(61, 14);
      this.Label13.TabIndex = 4;
      this.Label13.Text = "Address 1";
      this.txtPCAdd1.Location = new Point((int) sbyte.MaxValue, 46);
      this.txtPCAdd1.Name = "txtPCAdd1";
      this.txtPCAdd1.Size = new Size(188, 22);
      this.txtPCAdd1.TabIndex = 1;
      this.Label14.AutoSize = true;
      this.Label14.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label14.Location = new Point(6, 26);
      this.Label14.Name = "Label14";
      this.Label14.Size = new Size(38, 14);
      this.Label14.TabIndex = 2;
      this.Label14.Text = "Name";
      this.txtPCNAme.Location = new Point((int) sbyte.MaxValue, 19);
      this.txtPCNAme.Name = "txtPCNAme";
      this.txtPCNAme.Size = new Size(188, 22);
      this.txtPCNAme.TabIndex = 0;
      this.Panel1.Controls.Add((Control) this.lstClients);
      this.Panel1.Controls.Add((Control) this.Panel3);
      this.Panel1.Dock = DockStyle.Left;
      this.Panel1.Location = new Point(0, 0);
      this.Panel1.Name = "Panel1";
      this.Panel1.Size = new Size(201, 355);
      this.Panel1.TabIndex = 4;
      this.lstClients.Cursor = Cursors.Hand;
      this.lstClients.Dock = DockStyle.Fill;
      this.lstClients.FormattingEnabled = true;
      this.lstClients.Location = new Point(0, 51);
      this.lstClients.Name = "lstClients";
      this.lstClients.Size = new Size(201, 303);
      this.lstClients.TabIndex = 0;
      this.Panel3.Controls.Add((Control) this.TextBox1);
      this.Panel3.Controls.Add((Control) this.Label1);
      this.Panel3.Dock = DockStyle.Top;
      this.Panel3.Location = new Point(0, 0);
      this.Panel3.Name = "Panel3";
      this.Panel3.Size = new Size(201, 51);
      this.Panel3.TabIndex = 1;
      this.TextBox1.Location = new Point(7, 19);
      this.TextBox1.Name = "TextBox1";
      this.TextBox1.Size = new Size(181, 21);
      this.TextBox1.TabIndex = 1;
      this.Label1.AutoSize = true;
      this.Label1.Location = new Point(4, 4);
      this.Label1.Name = "Label1";
      this.Label1.Size = new Size(31, 13);
      this.Label1.TabIndex = 0;
      this.Label1.Text = "Filter";
      this.Panel2.BackColor = Color.Silver;
      this.Panel2.Controls.Add((Control) this.Button2);
      this.Panel2.Controls.Add((Control) this.Button1);
      this.Panel2.Controls.Add((Control) this.cmdClose);
      this.Panel2.Dock = DockStyle.Bottom;
      this.Panel2.Location = new Point(201, 292);
      this.Panel2.Name = "Panel2";
      this.Panel2.Size = new Size(324, 63);
      this.Panel2.TabIndex = 5;
      this.Button2.BackColor = Color.LightSlateGray;
      this.Button2.Cursor = Cursors.Hand;
      this.Button2.FlatStyle = FlatStyle.Popup;
      this.Button2.ForeColor = Color.White;
      this.Button2.Location = new Point(9, 35);
      this.Button2.Name = "Button2";
      this.Button2.Size = new Size(123, 23);
      this.Button2.TabIndex = 22;
      this.Button2.Text = "Delete";
      this.Button2.UseVisualStyleBackColor = false;
      this.Button1.BackColor = Color.LightSlateGray;
      this.Button1.Cursor = Cursors.Hand;
      this.Button1.FlatStyle = FlatStyle.Popup;
      this.Button1.ForeColor = Color.White;
      this.Button1.Location = new Point(9, 6);
      this.Button1.Name = "Button1";
      this.Button1.Size = new Size(123, 23);
      this.Button1.TabIndex = 21;
      this.Button1.Text = "Save";
      this.Button1.UseVisualStyleBackColor = false;
      this.cmdClose.BackColor = Color.LightSlateGray;
      this.cmdClose.Cursor = Cursors.Hand;
      this.cmdClose.DialogResult = DialogResult.OK;
      this.cmdClose.FlatStyle = FlatStyle.Popup;
      this.cmdClose.ForeColor = Color.White;
      this.cmdClose.Location = new Point(192, 35);
      this.cmdClose.Name = "cmdClose";
      this.cmdClose.Size = new Size(123, 23);
      this.cmdClose.TabIndex = 20;
      this.cmdClose.Text = "Close";
      this.cmdClose.UseVisualStyleBackColor = false;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.White;
      this.ClientSize = new Size(525, 355);
      this.Controls.Add((Control) this.GroupBox3);
      this.Controls.Add((Control) this.Panel2);
      this.Controls.Add((Control) this.Panel1);
      this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.Name = nameof (Clients);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = nameof (Clients);
      this.GroupBox3.ResumeLayout(false);
      this.GroupBox3.PerformLayout();
      this.Panel1.ResumeLayout(false);
      this.Panel3.ResumeLayout(false);
      this.Panel3.PerformLayout();
      this.Panel2.ResumeLayout(false);
      this.ResumeLayout(false);
    }

    [field: AccessedThroughProperty("GroupBox3")]
    internal virtual GroupBox GroupBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label19")]
    internal virtual Label Label19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtPCEmail")]
    internal virtual TextBox txtPCEmail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label18")]
    internal virtual Label Label18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtPCFax")]
    internal virtual TextBox txtPCFax { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label17")]
    internal virtual Label Label17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtPCPhone")]
    internal virtual TextBox txtPCPhone { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label15")]
    internal virtual Label Label15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtPCPCode")]
    internal virtual TextBox txtPCPCode { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label9")]
    internal virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtPCCountry")]
    internal virtual TextBox txtPCCountry { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label10")]
    internal virtual Label Label10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtPCCity")]
    internal virtual TextBox txtPCCity { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label11")]
    internal virtual Label Label11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtPCAdd3")]
    internal virtual TextBox txtPCAdd3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label12")]
    internal virtual Label Label12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtPCAdd2")]
    internal virtual TextBox txtPCAdd2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label13")]
    internal virtual Label Label13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtPCAdd1")]
    internal virtual TextBox txtPCAdd1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label14")]
    internal virtual Label Label14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtPCNAme")]
    internal virtual TextBox txtPCNAme { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Panel1")]
    internal virtual Panel Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Panel2")]
    internal virtual Panel Panel2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Panel3")]
    internal virtual Panel Panel3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ListBox lstClients
    {
      get => this._lstClients;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.lstClients_SelectedIndexChanged);
        ListBox lstClients1 = this._lstClients;
        if (lstClients1 != null)
          lstClients1.SelectedIndexChanged -= eventHandler;
        this._lstClients = value;
        ListBox lstClients2 = this._lstClients;
        if (lstClients2 == null)
          return;
        lstClients2.SelectedIndexChanged += eventHandler;
      }
    }

    internal virtual TextBox TextBox1
    {
      get => this._TextBox1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.TextBox1_TextChanged);
        TextBox textBox1_1 = this._TextBox1;
        if (textBox1_1 != null)
          textBox1_1.TextChanged -= eventHandler;
        this._TextBox1 = value;
        TextBox textBox1_2 = this._TextBox1;
        if (textBox1_2 == null)
          return;
        textBox1_2.TextChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Label1")]
    internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("cmdClose")]
    internal virtual Button cmdClose { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

    private void Clients_Load(object sender, EventArgs e)
    {
      this.ClientView.Table = SAP_Module.ClientDetails.Tables[nameof (Clients)];
      this.lstClients.DataSource = (object) this.ClientView;
      this.ClientView.Sort = "Name";
      this.lstClients.DisplayMember = "Name";
    }

    private void TextBox1_TextChanged(object sender, EventArgs e) => this.ClientView.RowFilter = "Name like '%" + this.TextBox1.Text + "%'";

    private void lstClients_SelectedIndexChanged(object sender, EventArgs e)
    {
      try
      {
        this.ClientRow = (DataRowView) this.lstClients.SelectedItem;
        this.txtPCNAme.Text = Conversions.ToString(this.ClientRow["Name"]);
        this.txtPCAdd1.Text = Conversions.ToString(this.ClientRow["Address1"]);
        this.txtPCAdd2.Text = Conversions.ToString(this.ClientRow["Address2"]);
        this.txtPCAdd3.Text = Conversions.ToString(this.ClientRow["Address3"]);
        this.txtPCCity.Text = Conversions.ToString(this.ClientRow["City"]);
        this.txtPCCountry.Text = Conversions.ToString(this.ClientRow["Country"]);
        this.txtPCPCode.Text = Conversions.ToString(this.ClientRow["PostCode"]);
        this.txtPCPhone.Text = Conversions.ToString(this.ClientRow["PhoneNumber"]);
        this.txtPCFax.Text = Conversions.ToString(this.ClientRow["FaxNumber"]);
        this.txtPCEmail.Text = Conversions.ToString(this.ClientRow["Email"]);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void Button1_Click(object sender, EventArgs e)
    {
      this.ClientRow["Name"] = (object) this.txtPCNAme.Text;
      this.ClientRow["Address1"] = (object) this.txtPCAdd1.Text;
      this.ClientRow["Address2"] = (object) this.txtPCAdd2.Text;
      this.ClientRow["Address3"] = (object) this.txtPCAdd3.Text;
      this.ClientRow["City"] = (object) this.txtPCCity.Text;
      this.ClientRow["Country"] = (object) this.txtPCCountry.Text;
      this.ClientRow["PostCode"] = (object) this.txtPCPCode.Text;
      this.ClientRow["PhoneNumber"] = (object) this.txtPCPhone.Text;
      this.ClientRow["FaxNumber"] = (object) this.txtPCFax.Text;
      this.ClientRow["Email"] = (object) this.txtPCEmail.Text;
    }

    private void Button2_Click(object sender, EventArgs e) => this.ClientRow.Delete();
  }
}
