
// Type: SAP2012.Shelter




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
  public class Shelter : Form
  {
    private IContainer components;

    public Shelter()
    {
      this.FormClosing += new FormClosingEventHandler(this.Shelter_FormClosing);
      this.Load += new EventHandler(this.Shelter_Load);
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
      DataGridViewCellStyle gridViewCellStyle1 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle2 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle3 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle4 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle5 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle6 = new DataGridViewCellStyle();
      this.Panel1 = new Panel();
      this.txtTabNotes = new TextBox();
      this.Label6 = new Label();
      this.Label5 = new Label();
      this.txtSelected = new TextBox();
      this.Button1 = new Button();
      this.cmdLongAddress = new Button();
      this.Label2 = new Label();
      this.Label1 = new Label();
      this.txtRu = new TextBox();
      this.GarageData = new DataGridView();
      this.GarageType = new DataGridViewTextBoxColumn();
      this.Column1 = new DataGridViewImageColumn();
      this.Elements = new DataGridViewTextBoxColumn();
      this.Inside = new DataGridViewButtonColumn();
      this.Outside = new DataGridViewButtonColumn();
      this.TabPage2 = new TabPage();
      this.Flats = new DataGridView();
      this.Element = new DataGridViewTextBoxColumn();
      this.Heat_Loss = new DataGridViewTextBoxColumn();
      this.Ru2 = new DataGridViewButtonColumn();
      this.TabPage1 = new TabPage();
      this.TabControl1 = new TabControl();
      this.TabPage4 = new TabPage();
      this.Roofs = new DataGridView();
      this.DataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
      this.DataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
      this.DataGridViewButtonColumn1 = new DataGridViewButtonColumn();
      this.PicFlat = new PictureBox();
      this.PicRoomInRoof = new PictureBox();
      this.Panel1.SuspendLayout();
      ((ISupportInitialize) this.GarageData).BeginInit();
      this.TabPage2.SuspendLayout();
      ((ISupportInitialize) this.Flats).BeginInit();
      this.TabPage1.SuspendLayout();
      this.TabControl1.SuspendLayout();
      this.TabPage4.SuspendLayout();
      ((ISupportInitialize) this.Roofs).BeginInit();
      ((ISupportInitialize) this.PicFlat).BeginInit();
      ((ISupportInitialize) this.PicRoomInRoof).BeginInit();
      this.SuspendLayout();
      this.Panel1.BackColor = Color.White;
      this.Panel1.Controls.Add((Control) this.txtTabNotes);
      this.Panel1.Controls.Add((Control) this.Label6);
      this.Panel1.Controls.Add((Control) this.Label5);
      this.Panel1.Controls.Add((Control) this.txtSelected);
      this.Panel1.Controls.Add((Control) this.Button1);
      this.Panel1.Controls.Add((Control) this.cmdLongAddress);
      this.Panel1.Controls.Add((Control) this.Label2);
      this.Panel1.Controls.Add((Control) this.Label1);
      this.Panel1.Controls.Add((Control) this.txtRu);
      this.Panel1.Dock = DockStyle.Left;
      this.Panel1.Location = new Point(0, 0);
      this.Panel1.Name = "Panel1";
      this.Panel1.Size = new Size(159, 586);
      this.Panel1.TabIndex = 2;
      this.txtTabNotes.BackColor = Color.White;
      this.txtTabNotes.Location = new Point(12, 326);
      this.txtTabNotes.Multiline = true;
      this.txtTabNotes.Name = "txtTabNotes";
      this.txtTabNotes.ReadOnly = true;
      this.txtTabNotes.ScrollBars = ScrollBars.Vertical;
      this.txtTabNotes.Size = new Size(141, 190);
      this.txtTabNotes.TabIndex = 46;
      this.Label6.AutoSize = true;
      this.Label6.Location = new Point(9, 310);
      this.Label6.Name = "Label6";
      this.Label6.Size = new Size(57, 13);
      this.Label6.TabIndex = 47;
      this.Label6.Text = "Tab Notes";
      this.Label5.AutoSize = true;
      this.Label5.Location = new Point(9, 105);
      this.Label5.Name = "Label5";
      this.Label5.Size = new Size(49, 13);
      this.Label5.TabIndex = 45;
      this.Label5.Text = "Selected";
      this.txtSelected.BackColor = Color.White;
      this.txtSelected.Location = new Point(12, 125);
      this.txtSelected.Multiline = true;
      this.txtSelected.Name = "txtSelected";
      this.txtSelected.ReadOnly = true;
      this.txtSelected.Size = new Size(141, 179);
      this.txtSelected.TabIndex = 44;
      this.Button1.BackColor = Color.LightSlateGray;
      this.Button1.Cursor = Cursors.Hand;
      this.Button1.DialogResult = DialogResult.Cancel;
      this.Button1.FlatStyle = FlatStyle.Popup;
      this.Button1.ForeColor = Color.White;
      this.Button1.Location = new Point(12, 551);
      this.Button1.Name = "Button1";
      this.Button1.Size = new Size(141, 23);
      this.Button1.TabIndex = 43;
      this.Button1.Text = "Cancel";
      this.Button1.UseVisualStyleBackColor = false;
      this.cmdLongAddress.BackColor = Color.LightSlateGray;
      this.cmdLongAddress.Cursor = Cursors.Hand;
      this.cmdLongAddress.FlatStyle = FlatStyle.Popup;
      this.cmdLongAddress.ForeColor = Color.White;
      this.cmdLongAddress.Location = new Point(12, 522);
      this.cmdLongAddress.Name = "cmdLongAddress";
      this.cmdLongAddress.Size = new Size(141, 23);
      this.cmdLongAddress.TabIndex = 42;
      this.cmdLongAddress.Text = "OK";
      this.cmdLongAddress.UseVisualStyleBackColor = false;
      this.Label2.AutoSize = true;
      this.Label2.Location = new Point(31, 79);
      this.Label2.Name = "Label2";
      this.Label2.Size = new Size(33, 26);
      this.Label2.TabIndex = 2;
      this.Label2.Text = "Ru = \r\n\r\n";
      this.Label1.AutoSize = true;
      this.Label1.Location = new Point(9, 9);
      this.Label1.Name = "Label1";
      this.Label1.Size = new Size(123, 52);
      this.Label1.TabIndex = 1;
      this.Label1.Text = "Ru = Effective Thermal \r\nResistance of unheated \r\nspace from the \r\nappropriate table below.";
      this.txtRu.BackColor = Color.White;
      this.txtRu.BorderStyle = BorderStyle.None;
      this.txtRu.Location = new Point(61, 80);
      this.txtRu.Name = "txtRu";
      this.txtRu.ReadOnly = true;
      this.txtRu.Size = new Size(30, 13);
      this.txtRu.TabIndex = 0;
      this.txtRu.TabStop = false;
      this.txtRu.TextAlign = HorizontalAlignment.Right;
      this.GarageData.AllowUserToAddRows = false;
      this.GarageData.AllowUserToDeleteRows = false;
      this.GarageData.AllowUserToResizeColumns = false;
      this.GarageData.AllowUserToResizeRows = false;
      this.GarageData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.GarageData.Columns.AddRange((DataGridViewColumn) this.GarageType, (DataGridViewColumn) this.Column1, (DataGridViewColumn) this.Elements, (DataGridViewColumn) this.Inside, (DataGridViewColumn) this.Outside);
      this.GarageData.Cursor = Cursors.Hand;
      this.GarageData.Dock = DockStyle.Fill;
      this.GarageData.Location = new Point(3, 3);
      this.GarageData.Name = "GarageData";
      this.GarageData.ReadOnly = true;
      this.GarageData.RowHeadersVisible = false;
      this.GarageData.RowTemplate.Resizable = DataGridViewTriState.False;
      this.GarageData.Size = new Size(621, 554);
      this.GarageData.TabIndex = 0;
      gridViewCellStyle1.WrapMode = DataGridViewTriState.True;
      this.GarageType.DefaultCellStyle = gridViewCellStyle1;
      this.GarageType.HeaderText = "GarageType";
      this.GarageType.Name = "GarageType";
      this.GarageType.ReadOnly = true;
      this.GarageType.Width = 150;
      this.Column1.HeaderText = "Representation";
      this.Column1.Name = "Column1";
      this.Column1.ReadOnly = true;
      gridViewCellStyle2.WrapMode = DataGridViewTriState.True;
      this.Elements.DefaultCellStyle = gridViewCellStyle2;
      this.Elements.HeaderText = "Elements between garage and dwelling";
      this.Elements.Name = "Elements";
      this.Elements.ReadOnly = true;
      this.Elements.Width = 150;
      this.Inside.HeaderText = "Inside";
      this.Inside.Name = "Inside";
      this.Inside.ReadOnly = true;
      this.Inside.Resizable = DataGridViewTriState.True;
      this.Inside.SortMode = DataGridViewColumnSortMode.Automatic;
      this.Outside.HeaderText = "Outside";
      this.Outside.Name = "Outside";
      this.Outside.ReadOnly = true;
      this.Outside.Resizable = DataGridViewTriState.True;
      this.Outside.SortMode = DataGridViewColumnSortMode.Automatic;
      this.TabPage2.Controls.Add((Control) this.Flats);
      this.TabPage2.Controls.Add((Control) this.PicFlat);
      this.TabPage2.Location = new Point(4, 22);
      this.TabPage2.Name = "TabPage2";
      this.TabPage2.Padding = new Padding(3);
      this.TabPage2.Size = new Size(627, 560);
      this.TabPage2.TabIndex = 1;
      this.TabPage2.Text = "Stairwells and access corridors in flats";
      this.TabPage2.UseVisualStyleBackColor = true;
      this.Flats.AllowUserToAddRows = false;
      this.Flats.AllowUserToDeleteRows = false;
      this.Flats.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.Flats.Columns.AddRange((DataGridViewColumn) this.Element, (DataGridViewColumn) this.Heat_Loss, (DataGridViewColumn) this.Ru2);
      this.Flats.Cursor = Cursors.Hand;
      this.Flats.Location = new Point(0, 301);
      this.Flats.Name = "Flats";
      this.Flats.ReadOnly = true;
      this.Flats.RowHeadersVisible = false;
      this.Flats.RowTemplate.Resizable = DataGridViewTriState.False;
      this.Flats.Size = new Size(627, 256);
      this.Flats.TabIndex = 1;
      gridViewCellStyle3.WrapMode = DataGridViewTriState.True;
      this.Element.DefaultCellStyle = gridViewCellStyle3;
      this.Element.HeaderText = "Elements between stairwell/corridor and dwelling";
      this.Element.Name = "Element";
      this.Element.ReadOnly = true;
      this.Element.Width = 250;
      gridViewCellStyle4.WrapMode = DataGridViewTriState.True;
      this.Heat_Loss.DefaultCellStyle = gridViewCellStyle4;
      this.Heat_Loss.HeaderText = "Heat loss from corridor";
      this.Heat_Loss.Name = "Heat_Loss";
      this.Heat_Loss.ReadOnly = true;
      this.Heat_Loss.Width = 250;
      this.Ru2.HeaderText = "Ru";
      this.Ru2.Name = "Ru2";
      this.Ru2.ReadOnly = true;
      this.Ru2.Resizable = DataGridViewTriState.True;
      this.Ru2.SortMode = DataGridViewColumnSortMode.Automatic;
      this.TabPage1.Controls.Add((Control) this.GarageData);
      this.TabPage1.Location = new Point(4, 22);
      this.TabPage1.Name = "TabPage1";
      this.TabPage1.Padding = new Padding(3);
      this.TabPage1.Size = new Size(627, 560);
      this.TabPage1.TabIndex = 0;
      this.TabPage1.Text = "Garage";
      this.TabPage1.UseVisualStyleBackColor = true;
      this.TabControl1.Controls.Add((Control) this.TabPage1);
      this.TabControl1.Controls.Add((Control) this.TabPage2);
      this.TabControl1.Controls.Add((Control) this.TabPage4);
      this.TabControl1.Dock = DockStyle.Fill;
      this.TabControl1.Location = new Point(159, 0);
      this.TabControl1.Name = "TabControl1";
      this.TabControl1.SelectedIndex = 0;
      this.TabControl1.Size = new Size(635, 586);
      this.TabControl1.TabIndex = 3;
      this.TabPage4.Controls.Add((Control) this.Roofs);
      this.TabPage4.Controls.Add((Control) this.PicRoomInRoof);
      this.TabPage4.Location = new Point(4, 22);
      this.TabPage4.Name = "TabPage4";
      this.TabPage4.Padding = new Padding(3);
      this.TabPage4.Size = new Size(627, 560);
      this.TabPage4.TabIndex = 3;
      this.TabPage4.Text = "Room in roof";
      this.TabPage4.UseVisualStyleBackColor = true;
      this.Roofs.AllowUserToAddRows = false;
      this.Roofs.AllowUserToDeleteRows = false;
      this.Roofs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.Roofs.Columns.AddRange((DataGridViewColumn) this.DataGridViewTextBoxColumn1, (DataGridViewColumn) this.DataGridViewTextBoxColumn2, (DataGridViewColumn) this.DataGridViewButtonColumn1);
      this.Roofs.Cursor = Cursors.Hand;
      this.Roofs.Location = new Point(0, 301);
      this.Roofs.Name = "Roofs";
      this.Roofs.ReadOnly = true;
      this.Roofs.RowHeadersVisible = false;
      this.Roofs.RowTemplate.Resizable = DataGridViewTriState.False;
      this.Roofs.Size = new Size(627, 256);
      this.Roofs.TabIndex = 2;
      gridViewCellStyle5.WrapMode = DataGridViewTriState.True;
      this.DataGridViewTextBoxColumn1.DefaultCellStyle = gridViewCellStyle5;
      this.DataGridViewTextBoxColumn1.HeaderText = "Area";
      this.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1";
      this.DataGridViewTextBoxColumn1.ReadOnly = true;
      this.DataGridViewTextBoxColumn1.Width = 250;
      gridViewCellStyle6.WrapMode = DataGridViewTriState.True;
      this.DataGridViewTextBoxColumn2.DefaultCellStyle = gridViewCellStyle6;
      this.DataGridViewTextBoxColumn2.HeaderText = "Element between dwelling and unheated loft space";
      this.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2";
      this.DataGridViewTextBoxColumn2.ReadOnly = true;
      this.DataGridViewTextBoxColumn2.Width = 250;
      this.DataGridViewButtonColumn1.HeaderText = "Ru";
      this.DataGridViewButtonColumn1.Name = "DataGridViewButtonColumn1";
      this.DataGridViewButtonColumn1.ReadOnly = true;
      this.DataGridViewButtonColumn1.Resizable = DataGridViewTriState.True;
      this.DataGridViewButtonColumn1.SortMode = DataGridViewColumnSortMode.Automatic;
      this.PicFlat.Location = new Point(0, 0);
      this.PicFlat.Name = "PicFlat";
      this.PicFlat.Size = new Size(620, 300);
      this.PicFlat.SizeMode = PictureBoxSizeMode.AutoSize;
      this.PicFlat.TabIndex = 0;
      this.PicFlat.TabStop = false;
      this.PicRoomInRoof.Image = (Image) SAP2012.My.Resources.Resources.RoomInRoof;
      this.PicRoomInRoof.Location = new Point(6, 20);
      this.PicRoomInRoof.Name = "PicRoomInRoof";
      this.PicRoomInRoof.Size = new Size(618, 262);
      this.PicRoomInRoof.TabIndex = 0;
      this.PicRoomInRoof.TabStop = false;
      this.AcceptButton = (IButtonControl) this.cmdLongAddress;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.White;
      this.CancelButton = (IButtonControl) this.Button1;
      this.ClientSize = new Size(794, 586);
      this.Controls.Add((Control) this.TabControl1);
      this.Controls.Add((Control) this.Panel1);
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.Name = nameof (Shelter);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Effective Thermal Risistance";
      this.Panel1.ResumeLayout(false);
      this.Panel1.PerformLayout();
      ((ISupportInitialize) this.GarageData).EndInit();
      this.TabPage2.ResumeLayout(false);
      this.TabPage2.PerformLayout();
      ((ISupportInitialize) this.Flats).EndInit();
      this.TabPage1.ResumeLayout(false);
      this.TabControl1.ResumeLayout(false);
      this.TabPage4.ResumeLayout(false);
      ((ISupportInitialize) this.Roofs).EndInit();
      ((ISupportInitialize) this.PicFlat).EndInit();
      ((ISupportInitialize) this.PicRoomInRoof).EndInit();
      this.ResumeLayout(false);
    }

    [field: AccessedThroughProperty("Panel1")]
    internal virtual Panel Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DataGridView GarageData
    {
      get => this._GarageData;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DataGridViewCellEventHandler cellEventHandler = new DataGridViewCellEventHandler(this.GarageData_CellContentClick);
        DataGridView garageData1 = this._GarageData;
        if (garageData1 != null)
          garageData1.CellContentClick -= cellEventHandler;
        this._GarageData = value;
        DataGridView garageData2 = this._GarageData;
        if (garageData2 == null)
          return;
        garageData2.CellContentClick += cellEventHandler;
      }
    }

    [field: AccessedThroughProperty("TabPage2")]
    internal virtual TabPage TabPage2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("TabPage1")]
    internal virtual TabPage TabPage1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TabControl TabControl1
    {
      get => this._TabControl1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.TabControl1_Click);
        TabControl tabControl1_1 = this._TabControl1;
        if (tabControl1_1 != null)
          tabControl1_1.Click -= eventHandler;
        this._TabControl1 = value;
        TabControl tabControl1_2 = this._TabControl1;
        if (tabControl1_2 == null)
          return;
        tabControl1_2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Label1")]
    internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtRu")]
    internal virtual TextBox txtRu { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GarageType")]
    internal virtual DataGridViewTextBoxColumn GarageType { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Column1")]
    internal virtual DataGridViewImageColumn Column1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Elements")]
    internal virtual DataGridViewTextBoxColumn Elements { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Inside")]
    internal virtual DataGridViewButtonColumn Inside { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Outside")]
    internal virtual DataGridViewButtonColumn Outside { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label2")]
    internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("TabPage4")]
    internal virtual TabPage TabPage4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

    [field: AccessedThroughProperty("PicFlat")]
    internal virtual PictureBox PicFlat { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DataGridView Flats
    {
      get => this._Flats;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DataGridViewCellEventHandler cellEventHandler = new DataGridViewCellEventHandler(this.Flats_CellContentClick);
        DataGridView flats1 = this._Flats;
        if (flats1 != null)
          flats1.CellContentClick -= cellEventHandler;
        this._Flats = value;
        DataGridView flats2 = this._Flats;
        if (flats2 == null)
          return;
        flats2.CellContentClick += cellEventHandler;
      }
    }

    [field: AccessedThroughProperty("Element")]
    internal virtual DataGridViewTextBoxColumn Element { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Heat_Loss")]
    internal virtual DataGridViewTextBoxColumn Heat_Loss { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Ru2")]
    internal virtual DataGridViewButtonColumn Ru2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("PicRoomInRoof")]
    internal virtual PictureBox PicRoomInRoof { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DataGridView Roofs
    {
      get => this._Roofs;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DataGridViewCellEventHandler cellEventHandler = new DataGridViewCellEventHandler(this.Roofs_CellContentClick);
        DataGridView roofs1 = this._Roofs;
        if (roofs1 != null)
          roofs1.CellContentClick -= cellEventHandler;
        this._Roofs = value;
        DataGridView roofs2 = this._Roofs;
        if (roofs2 == null)
          return;
        roofs2.CellContentClick += cellEventHandler;
      }
    }

    [field: AccessedThroughProperty("DataGridViewTextBoxColumn1")]
    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DataGridViewTextBoxColumn2")]
    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DataGridViewButtonColumn1")]
    internal virtual DataGridViewButtonColumn DataGridViewButtonColumn1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label6")]
    internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox txtTabNotes
    {
      get => this._txtTabNotes;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtTabNotes_TextChanged);
        TextBox txtTabNotes1 = this._txtTabNotes;
        if (txtTabNotes1 != null)
          txtTabNotes1.TextChanged -= eventHandler;
        this._txtTabNotes = value;
        TextBox txtTabNotes2 = this._txtTabNotes;
        if (txtTabNotes2 == null)
          return;
        txtTabNotes2.TextChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Label5")]
    internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtSelected")]
    internal virtual TextBox txtSelected { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private void Shelter_FormClosing(object sender, FormClosingEventArgs e) => MyProject.Forms.SAPForm.Enabled = true;

    private void Shelter_Load(object sender, EventArgs e)
    {
      if (this.GarageData.RowCount == 0)
        this.GarageData.Rows.Add(6);
      DataGridView garageData = this.GarageData;
      garageData[0, 0].Value = (object) "Single fully integral";
      Image image1 = Image.FromFile(Application.StartupPath + "\\Resources\\1.jpg");
      garageData[1, 0].Value = (object) image1;
      garageData[2, 0].Value = (object) "Side wall, end wall and floor";
      garageData[3, 0].Value = (object) "0.68";
      garageData[4, 0].Value = (object) "0.33";
      garageData.Rows[0].Height = 80;
      garageData[0, 1].Value = (object) "Single fully integral";
      Image image2 = Image.FromFile(Application.StartupPath + "\\Resources\\2.jpg");
      garageData[1, 1].Value = (object) image2;
      garageData[2, 1].Value = (object) "One wall and floor";
      garageData[3, 1].Value = (object) "0.54";
      garageData[4, 1].Value = (object) "0.25";
      garageData.Rows[1].Height = 80;
      garageData[0, 2].Value = (object) "Single, partially integral displaced forward";
      Image image3 = Image.FromFile(Application.StartupPath + "\\Resources\\3.jpg");
      garageData[1, 2].Value = (object) image3;
      garageData[2, 2].Value = (object) "Side wall, end wall and floor";
      garageData[3, 2].Value = (object) "0.56";
      garageData[4, 2].Value = (object) "0.26";
      garageData.Rows[2].Height = 80;
      garageData[0, 3].Value = (object) "Double garage fully integral";
      Image image4 = Image.FromFile(Application.StartupPath + "\\Resources\\4.jpg");
      garageData[1, 3].Value = (object) image4;
      garageData[2, 3].Value = (object) "Side wall, end wall and floor";
      garageData[3, 3].Value = (object) "0.59";
      garageData[4, 3].Value = (object) "0.28";
      garageData.Rows[3].Height = 80;
      garageData[0, 4].Value = (object) "Double, half integral";
      Image image5 = Image.FromFile(Application.StartupPath + "\\Resources\\5.jpg");
      garageData[1, 4].Value = (object) image5;
      garageData[2, 4].Value = (object) "Side wall, halves of the garage end wall and floor";
      garageData[3, 4].Value = (object) "0.34";
      garageData[4, 4].Value = (object) "";
      garageData[4, 4].ReadOnly = true;
      garageData.Rows[4].Height = 80;
      garageData[0, 5].Value = (object) "Double, partially integral displaced forward";
      Image image6 = Image.FromFile(Application.StartupPath + "\\Resources\\6.jpg");
      garageData[1, 5].Value = (object) image6;
      garageData[2, 5].Value = (object) "Part of the garage side wall, end wall and some floor";
      garageData[3, 5].Value = (object) "0.28";
      garageData[4, 5].Value = (object) "";
      garageData[4, 5].ReadOnly = true;
      garageData.Rows[5].Height = 80;
      this.PicFlat.Image = Image.FromFile(Application.StartupPath + "\\Resources\\Flats.jpg");
      if (this.Flats.RowCount == 0)
        this.Flats.Rows.Add(6);
      DataGridView flats = this.Flats;
      flats[0, 0].Value = (object) "Stairwells: Facing wall exposed";
      flats[1, 0].Value = (object) "";
      flats[2, 0].Value = (object) "0.82";
      flats.Rows[0].Height = 70;
      flats[0, 1].Value = (object) "Stairwells: Facing wall not exposed";
      flats[1, 1].Value = (object) "";
      flats[2, 1].Value = (object) "0.90";
      flats.Rows[1].Height = 70;
      flats[0, 2].Value = (object) "Access corridors: Facing wall exposed, corridors above and below";
      flats[1, 2].Value = (object) "facing wall, floor and ceiling";
      flats[2, 2].Value = (object) "0.28";
      flats.Rows[2].Height = 70;
      flats[0, 3].Value = (object) "Access corridors: Facing wall exposed, corridor above or below";
      flats[1, 3].Value = (object) "facing wall, floor or ceiling";
      flats[2, 3].Value = (object) "0.31";
      flats.Rows[3].Height = 70;
      flats[0, 4].Value = (object) "Access corridors: Facing wall not exposed, corridor above and below";
      flats[1, 4].Value = (object) "floor and ceiling";
      flats[2, 4].Value = (object) "0.40";
      flats.Rows[4].Height = 70;
      flats[0, 5].Value = (object) "Access corridors: Facing wall not exposed, corridor above or below";
      flats[1, 5].Value = (object) "floor or ceiling";
      flats[2, 5].Value = (object) "0.43";
      flats.Rows[5].Height = 70;
      this.PicRoomInRoof.Image = Image.FromFile(Application.StartupPath + "\\Resources\\RoomInRoof.jpg");
      if (this.Roofs.RowCount == 0)
        this.Roofs.Rows.Add(2);
      DataGridView roofs = this.Roofs;
      roofs[0, 0].Value = (object) "Room in roof built into a pitched roof insulated at ceiling level";
      roofs[1, 0].Value = (object) "insulated wall of room in roof";
      roofs[2, 0].Value = (object) "0.5";
      roofs.Rows[0].Height = 70;
      roofs[0, 1].Value = (object) "Room in roof built into a pitched roof insulated at ceiling level";
      roofs[1, 1].Value = (object) "or insulated ceiling of room below";
      roofs[2, 1].Value = (object) "0.50";
      roofs.Rows[1].Height = 70;
      this.txtTabNotes.Text = "Inside Garage:\r\n\r\nWhen the insulated envelope of the dwelling goes round the outside of the garage\r\n\r\n";
      TextBox txtTabNotes;
      string str = (txtTabNotes = this.txtTabNotes).Text + "Outside Garage:\r\n\r\nWhen the walls separating the garage from the dwelling are the external walls";
      txtTabNotes.Text = str;
    }

    private void GarageData_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      if (!(e.ColumnIndex == 3 | e.ColumnIndex == 4))
        return;
      this.txtRu.Text = Conversions.ToString(this.GarageData[e.ColumnIndex, e.RowIndex].Value);
      this.txtSelected.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.GarageData[0, e.RowIndex].Value, (object) "\r\n"), (object) "\r\n"));
      TextBox txtSelected;
      string str = Conversions.ToString(Operators.AddObject((object) (txtSelected = this.txtSelected).Text, Operators.ConcatenateObject(Operators.ConcatenateObject(this.GarageData[2, e.RowIndex].Value, (object) "\r\n"), (object) "\r\n")));
      txtSelected.Text = str;
    }

    private void Flats_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.ColumnIndex != 2)
        return;
      this.txtRu.Text = Conversions.ToString(this.Flats[e.ColumnIndex, e.RowIndex].Value);
      this.txtSelected.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.Flats[0, e.RowIndex].Value, (object) "\r\n"), (object) "\r\n"));
      TextBox txtSelected;
      string str = Conversions.ToString(Operators.AddObject((object) (txtSelected = this.txtSelected).Text, Operators.ConcatenateObject(Operators.ConcatenateObject(this.Flats[1, e.RowIndex].Value, (object) "\r\n"), (object) "\r\n")));
      txtSelected.Text = str;
    }

    private void Button1_Click(object sender, EventArgs e) => this.Close();

    private void Button2_Click(object sender, EventArgs e)
    {
    }

    private void Button3_Click(object sender, EventArgs e)
    {
    }

    private void Roofs_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.ColumnIndex != 2)
        return;
      this.txtRu.Text = Conversions.ToString(this.Roofs[e.ColumnIndex, e.RowIndex].Value);
      this.txtSelected.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.Roofs[0, e.RowIndex].Value, (object) "\r\n"), (object) "\r\n"));
      TextBox txtSelected;
      string str = Conversions.ToString(Operators.AddObject((object) (txtSelected = this.txtSelected).Text, Operators.ConcatenateObject(Operators.ConcatenateObject(this.Roofs[1, e.RowIndex].Value, (object) "\r\n"), (object) "\r\n")));
      txtSelected.Text = str;
    }

    private void TabControl1_Click(object sender, EventArgs e)
    {
      switch (this.TabControl1.SelectedIndex)
      {
        case 0:
          this.txtTabNotes.Text = "Inside Garage:\r\nWhen the insulated envelope of the dwelling goes round the outside of the garage\r\n";
          TextBox txtTabNotes1;
          string str1 = (txtTabNotes1 = this.txtTabNotes).Text + "Outside Garage:\r\nWhen the walls separating the garage from the dwelling are the external walls";
          txtTabNotes1.Text = str1;
          break;
        case 1:
          this.txtTabNotes.Text = "Stairwells and access corridors are not regarded as parts of the dwelling. If they are heated they are not ";
          TextBox txtTabNotes2;
          string str2 = (txtTabNotes2 = this.txtTabNotes).Text + "included in the calculation. If unheated, the U-value of walls between the dwelling and the unheated space ";
          txtTabNotes2.Text = str2;
          TextBox txtTabNotes3;
          string str3 = (txtTabNotes3 = this.txtTabNotes).Text + "should be modified using the following data for Ru.\r\n";
          txtTabNotes3.Text = str3;
          TextBox txtTabNotes4;
          string str4 = (txtTabNotes4 = this.txtTabNotes).Text + "The table shown gives recommended values of Ru for common configurations of access corridors and stairwells";
          txtTabNotes4.Text = str4;
          break;
        case 2:
          this.txtTabNotes.Text = "In the case of room-in-roof construction where the insulation follows the shape of the room, the U-value of ";
          TextBox txtTabNotes5;
          string str5 = (txtTabNotes5 = this.txtTabNotes).Text + "roof of the room-in-roof construction is calculated using the procedure described in paragraph 3.3 (SAP 2005) using ";
          txtTabNotes5.Text = str5;
          TextBox txtTabNotes6;
          string str6 = (txtTabNotes6 = this.txtTabNotes).Text + "thermal resistance Ru from Table shown. The same applies to the ceiling of the room below. \r\n";
          txtTabNotes6.Text = str6;
          TextBox txtTabNotes7;
          string str7 = (txtTabNotes7 = this.txtTabNotes).Text + "If the insulation follows the slope of the roof, the U-value should be calculated in the plane of the slope.";
          txtTabNotes7.Text = str7;
          break;
      }
    }

    private void cmdLongAddress_Click(object sender, EventArgs e)
    {
      SAP_Module.ControlNow[SAP_Module.ColNow, SAP_Module.RowNow].Value = (object) this.txtRu.Text;
      MyProject.Forms.SAPForm.Enabled = true;
      this.Close();
    }

    private void txtTabNotes_TextChanged(object sender, EventArgs e)
    {
    }

    private void TabPage3_Click(object sender, EventArgs e)
    {
    }
  }
}
