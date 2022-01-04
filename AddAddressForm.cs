
// Type: SAP2012.AddAddressForm




using Microsoft.VisualBasic.CompilerServices;
using SAP2012.NISAP;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SAP2012
{
  [DesignerGenerated]
  public class AddAddressForm : Form
  {
    private IContainer components;
    private bool Removed;
    private AddAddressForm.Item_s[] Items;

    public AddAddressForm()
    {
      this.Load += new EventHandler(this.AddAddressForm_Load);
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
      this.components = (IContainer) new System.ComponentModel.Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (AddAddressForm));
      DataGridViewCellStyle gridViewCellStyle1 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle2 = new DataGridViewCellStyle();
      this.Panel1 = new Panel();
      this.Button2 = new Button();
      this.cmdClose = new Button();
      this.Label1 = new Label();
      this.txtAddress = new NumericUpDown();
      this.cmdadd = new Button();
      this.Button1 = new Button();
      this.StatusList = new ImageList(this.components);
      this.dgvCopy = new BetterDataGrid();
      this.Country = new DataGridViewTextBoxColumn();
      this.txtNameNum = new DataGridViewTextBoxColumn();
      this.txtStreet = new DataGridViewTextBoxColumn();
      this.txtLocality = new DataGridViewTextBoxColumn();
      this.txtTown = new DataGridViewTextBoxColumn();
      this.txtPostcode = new DataGridViewTextBoxColumn();
      this.txtAssessor = new DataGridViewTextBoxColumn();
      this.Notes = new DataGridViewTextBoxColumn();
      this.Status = new DataGridViewImageColumn();
      this.Panel1.SuspendLayout();
      this.txtAddress.BeginInit();
      ((ISupportInitialize) this.dgvCopy).BeginInit();
      this.SuspendLayout();
      this.Panel1.Controls.Add((Control) this.Button2);
      this.Panel1.Controls.Add((Control) this.cmdClose);
      this.Panel1.Controls.Add((Control) this.Label1);
      this.Panel1.Controls.Add((Control) this.txtAddress);
      this.Panel1.Controls.Add((Control) this.cmdadd);
      this.Panel1.Dock = DockStyle.Left;
      this.Panel1.Location = new Point(0, 0);
      this.Panel1.Margin = new Padding(2, 3, 2, 3);
      this.Panel1.Name = "Panel1";
      this.Panel1.Size = new Size(231, 731);
      this.Panel1.TabIndex = 30;
      this.Button2.BackColor = Color.LightSlateGray;
      this.Button2.Cursor = Cursors.Hand;
      this.Button2.DialogResult = DialogResult.OK;
      this.Button2.FlatStyle = FlatStyle.Popup;
      this.Button2.ForeColor = Color.White;
      this.Button2.Location = new Point(103, 114);
      this.Button2.Margin = new Padding(2, 3, 2, 3);
      this.Button2.Name = "Button2";
      this.Button2.Size = new Size(108, 23);
      this.Button2.TabIndex = 27;
      this.Button2.Text = "Remove Address";
      this.Button2.UseVisualStyleBackColor = false;
      this.cmdClose.BackColor = Color.LightSlateGray;
      this.cmdClose.Cursor = Cursors.Hand;
      this.cmdClose.DialogResult = DialogResult.OK;
      this.cmdClose.FlatStyle = FlatStyle.Popup;
      this.cmdClose.ForeColor = Color.White;
      this.cmdClose.Location = new Point(12, 114);
      this.cmdClose.Margin = new Padding(2, 3, 2, 3);
      this.cmdClose.Name = "cmdClose";
      this.cmdClose.Size = new Size(87, 23);
      this.cmdClose.TabIndex = 26;
      this.cmdClose.Text = "Close";
      this.cmdClose.UseVisualStyleBackColor = true;
      this.Label1.AutoSize = true;
      this.Label1.Location = new Point(9, 14);
      this.Label1.Margin = new Padding(2, 0, 2, 0);
      this.Label1.Name = "Label1";
      this.Label1.Size = new Size(140, 13);
      this.Label1.TabIndex = 25;
      this.Label1.Text = "Number of addresses to add";
      this.txtAddress.Cursor = Cursors.Hand;
      this.txtAddress.Location = new Point(151, 12);
      this.txtAddress.Margin = new Padding(2, 3, 2, 3);
      this.txtAddress.Maximum = new Decimal(new int[4]
      {
        1000,
        0,
        0,
        0
      });
      this.txtAddress.Name = "txtAddress";
      this.txtAddress.Size = new Size(58, 20);
      this.txtAddress.TabIndex = 24;
      this.cmdadd.BackColor = Color.LightSlateGray;
      this.cmdadd.Cursor = Cursors.Hand;
      this.cmdadd.DialogResult = DialogResult.OK;
      this.cmdadd.FlatStyle = FlatStyle.Popup;
      this.cmdadd.ForeColor = Color.White;
      this.cmdadd.Location = new Point(13, 85);
      this.cmdadd.Margin = new Padding(2, 3, 2, 3);
      this.cmdadd.Name = "cmdadd";
      this.cmdadd.Size = new Size(198, 23);
      this.cmdadd.TabIndex = 23;
      this.cmdadd.Text = "Add Address";
      this.cmdadd.UseVisualStyleBackColor = false;
      this.Button1.BackColor = Color.LightSlateGray;
      this.Button1.Cursor = Cursors.Hand;
      this.Button1.DialogResult = DialogResult.Cancel;
      this.Button1.FlatStyle = FlatStyle.Popup;
      this.Button1.ForeColor = Color.White;
      this.Button1.Location = new Point(13, 627);
      this.Button1.Margin = new Padding(2, 3, 2, 3);
      this.Button1.Name = "Button1";
      this.Button1.Size = new Size(158, 23);
      this.Button1.TabIndex = 32;
      this.Button1.Text = "Cancel";
      this.Button1.UseVisualStyleBackColor = false;
      this.StatusList.ImageStream = (ImageListStreamer) componentResourceManager.GetObject("StatusList.ImageStream");
      this.StatusList.TransparentColor = Color.Transparent;
      this.StatusList.Images.SetKeyName(0, "house2_24_24.gif");
      this.StatusList.Images.SetKeyName(1, "tick.gif");
      this.StatusList.Images.SetKeyName(2, "cross.gif");
      this.dgvCopy.AllowUserToAddRows = false;
      this.dgvCopy.AllowUserToDeleteRows = false;
      this.dgvCopy.AllowUserToResizeRows = false;
      gridViewCellStyle1.BackColor = Color.SkyBlue;
      this.dgvCopy.AlternatingRowsDefaultCellStyle = gridViewCellStyle1;
      this.dgvCopy.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvCopy.Columns.AddRange((DataGridViewColumn) this.Country, (DataGridViewColumn) this.txtNameNum, (DataGridViewColumn) this.txtStreet, (DataGridViewColumn) this.txtLocality, (DataGridViewColumn) this.txtTown, (DataGridViewColumn) this.txtPostcode, (DataGridViewColumn) this.txtAssessor, (DataGridViewColumn) this.Notes, (DataGridViewColumn) this.Status);
      this.dgvCopy.Cursor = Cursors.Hand;
      gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
      gridViewCellStyle2.BackColor = Color.Azure;
      gridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      gridViewCellStyle2.ForeColor = SystemColors.ControlText;
      gridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
      gridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
      gridViewCellStyle2.WrapMode = DataGridViewTriState.False;
      this.dgvCopy.DefaultCellStyle = gridViewCellStyle2;
      this.dgvCopy.Dock = DockStyle.Fill;
      this.dgvCopy.EditMode = DataGridViewEditMode.EditOnEnter;
      this.dgvCopy.Location = new Point(231, 0);
      this.dgvCopy.Margin = new Padding(2, 3, 2, 3);
      this.dgvCopy.Name = "dgvCopy";
      this.dgvCopy.ReadOnly = true;
      this.dgvCopy.RowHeadersWidth = 15;
      this.dgvCopy.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dgvCopy.Size = new Size(1090, 731);
      this.dgvCopy.TabIndex = 31;
      this.Country.HeaderText = "Country";
      this.Country.Name = "Country";
      this.Country.ReadOnly = true;
      this.Country.Resizable = DataGridViewTriState.True;
      this.Country.SortMode = DataGridViewColumnSortMode.NotSortable;
      this.txtNameNum.HeaderText = "Number or Name";
      this.txtNameNum.MinimumWidth = 10;
      this.txtNameNum.Name = "txtNameNum";
      this.txtNameNum.ReadOnly = true;
      this.txtNameNum.Width = 150;
      this.txtStreet.HeaderText = "Street /Road Name";
      this.txtStreet.Name = "txtStreet";
      this.txtStreet.ReadOnly = true;
      this.txtStreet.Width = 150;
      this.txtLocality.HeaderText = "Locality";
      this.txtLocality.Name = "txtLocality";
      this.txtLocality.ReadOnly = true;
      this.txtTown.HeaderText = "Town / City";
      this.txtTown.Name = "txtTown";
      this.txtTown.ReadOnly = true;
      this.txtTown.Width = 120;
      this.txtPostcode.HeaderText = "Postcode";
      this.txtPostcode.Name = "txtPostcode";
      this.txtPostcode.ReadOnly = true;
      this.txtAssessor.HeaderText = "AssessorID";
      this.txtAssessor.Name = "txtAssessor";
      this.txtAssessor.ReadOnly = true;
      this.Notes.HeaderText = "Notes";
      this.Notes.Name = "Notes";
      this.Notes.ReadOnly = true;
      this.Notes.Width = 150;
      this.Status.HeaderText = "Status";
      this.Status.Name = "Status";
      this.Status.ReadOnly = true;
      this.Status.Width = 50;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1321, 731);
      this.Controls.Add((Control) this.dgvCopy);
      this.Controls.Add((Control) this.Panel1);
      this.Controls.Add((Control) this.Button1);
      this.Name = nameof (AddAddressForm);
      this.Text = nameof (AddAddressForm);
      this.TopMost = true;
      this.Panel1.ResumeLayout(false);
      this.Panel1.PerformLayout();
      this.txtAddress.EndInit();
      ((ISupportInitialize) this.dgvCopy).EndInit();
      this.ResumeLayout(false);
    }

    [field: AccessedThroughProperty("dgvCopy")]
    internal virtual BetterDataGrid dgvCopy { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Panel1")]
    internal virtual Panel Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label1")]
    internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual NumericUpDown txtAddress
    {
      get => this.txtAddress;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtAddress_ValueChanged);
        NumericUpDown txtAddress1 = this.txtAddress;
        if (txtAddress1 != null)
          txtAddress1.ValueChanged -= eventHandler;
        this.txtAddress = value;
        NumericUpDown txtAddress2 = this.txtAddress;
        if (txtAddress2 == null)
          return;
        txtAddress2.ValueChanged += eventHandler;
      }
    }

    internal virtual Button cmdadd
    {
      get => this.cmdadd;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdadd_Click);
        Button cmdadd1 = this.cmdadd;
        if (cmdadd1 != null)
          cmdadd1.Click -= eventHandler;
        this.cmdadd = value;
        Button cmdadd2 = this.cmdadd;
        if (cmdadd2 == null)
          return;
        cmdadd2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Button1")]
    internal virtual Button Button1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button cmdClose
    {
      get => this.cmdClose;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdClose_Click);
        Button cmdClose1 = this.cmdClose;
        if (cmdClose1 != null)
          cmdClose1.Click -= eventHandler;
        this.cmdClose = value;
        Button cmdClose2 = this.cmdClose;
        if (cmdClose2 == null)
          return;
        cmdClose2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("StatusList")]
    internal virtual ImageList StatusList { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button2
    {
      get => this.Button2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button2_Click);
        Button button2_1 = this.Button2;
        if (button2_1 != null)
          button2_1.Click -= eventHandler;
        this.Button2 = value;
        Button button2_2 = this.Button2;
        if (button2_2 == null)
          return;
        button2_2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Country")]
    internal virtual DataGridViewTextBoxColumn Country { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtNameNum")]
    internal virtual DataGridViewTextBoxColumn txtNameNum { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtStreet")]
    internal virtual DataGridViewTextBoxColumn txtStreet { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtLocality")]
    internal virtual DataGridViewTextBoxColumn txtLocality { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtTown")]
    internal virtual DataGridViewTextBoxColumn txtTown { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtPostcode")]
    internal virtual DataGridViewTextBoxColumn txtPostcode { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtAssessor")]
    internal virtual DataGridViewTextBoxColumn txtAssessor { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Notes")]
    internal virtual DataGridViewTextBoxColumn Notes { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Status")]
    internal virtual DataGridViewImageColumn Status { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private void cmdClose_Click(object sender, EventArgs e) => this.Close();

    private void AddAddressForm_Load(object sender, EventArgs e)
    {
      this.dgvCopy.Rows.Clear();
      this.dgvCopy.ReadOnly = false;
    }

    private void SaveItems()
    {
      try
      {
        if (this.Items.Length <= 0)
          return;
        int num = checked (this.Items.Length - 1);
        int rowIndex = 0;
        while (rowIndex <= num)
        {
          this.Items[rowIndex].COUNTRY = Conversions.ToString(this.dgvCopy[0, rowIndex].Value);
          this.Items[rowIndex].NAME = Conversions.ToString(this.dgvCopy[1, rowIndex].Value);
          this.Items[rowIndex].STREET = Conversions.ToString(this.dgvCopy[2, rowIndex].Value);
          this.Items[rowIndex].LOCALITY = Conversions.ToString(this.dgvCopy[3, rowIndex].Value);
          this.Items[rowIndex].TOWN = Conversions.ToString(this.dgvCopy[4, rowIndex].Value);
          this.Items[rowIndex].POSTCODE = Conversions.ToString(this.dgvCopy[5, rowIndex].Value);
          this.Items[rowIndex].ASSESSOR = Validation.AssessorNO;
          this.Items[rowIndex].NOTES = Conversions.ToString(this.dgvCopy[7, rowIndex].Value);
          checked { ++rowIndex; }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void txtAddress_ValueChanged(object sender, EventArgs e)
    {
      if (this.Removed)
        return;
      try
      {
        // ISSUE: variable of a reference type
        AddAddressForm.Item_s[] local;
                local = this.Items;
        // ISSUE: explicit reference operation
        AddAddressForm.Item_s[] itemSArray = (AddAddressForm.Item_s[]) Utils.CopyArray((local ), (Array) new AddAddressForm.Item_s[checked (Convert.ToInt32(Decimal.Subtract(this.txtAddress.Value, 1M)) + 1)]);
        local = itemSArray;
        this.dgvCopy.Rows.Add((object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Address.Country, (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Address.Line1, (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Address.Line2, (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Address.Line3, (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Address.City, (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Address.PostCost, (object) Validation.AssessorNO, (object) "", (object) this.StatusList.Images[0]);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void cmdadd_Click(object sender, EventArgs e)
    {
      this.Removed = false;
      int num = checked (this.dgvCopy.Rows.Count - 1);
      int rowIndex = 0;
      while (rowIndex <= num)
      {
        try
        {
          if (Operators.CompareString(this.Items[rowIndex].COUNTRY, "Northern Ireland", false) == 0)
            new NISAPSoapClient().Add_New_AddressNI(Conversions.ToString(this.dgvCopy[1, rowIndex].Value), Conversions.ToString(this.dgvCopy[2, rowIndex].Value), Conversions.ToString(this.dgvCopy[3, rowIndex].Value), Conversions.ToString(this.dgvCopy[4, rowIndex].Value), Conversions.ToString(this.dgvCopy[5, rowIndex].Value), Conversions.ToString(this.dgvCopy[6, rowIndex].Value), Conversions.ToString(this.dgvCopy[7, rowIndex].Value), Validation.UserName, Functions.MD5_Hash(Validation.Password), Functions.TransactionID, Functions.Encrypt);
          this.dgvCopy[8, rowIndex].Value = (object) this.StatusList.Images[1];
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          this.dgvCopy[8, rowIndex].Value = (object) this.StatusList.Images[2];
          ProjectData.ClearProjectError();
        }
        checked { ++rowIndex; }
      }
    }

    private void Button2_Click(object sender, EventArgs e)
    {
      int index = this.dgvCopy.SelectedRows[0].Index;
      try
      {
        if (this.dgvCopy.Rows.Count > 0)
          this.dgvCopy.Rows.RemoveAt(index);
        this.Removed = true;
        this.txtAddress.Value = Decimal.Subtract(this.txtAddress.Value, 1M);
        this.Removed = false;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private struct Item_s
    {
      public string COUNTRY;
      public string NAME;
      public string STREET;
      public string LOCALITY;
      public string TOWN;
      public string POSTCODE;
      public string ASSESSOR;
      public string NOTES;
    }
  }
}
