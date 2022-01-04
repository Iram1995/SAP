
// Type: SAP2012.UValues




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
  public class UValues : Form
  {
    private IContainer components;
    public string Type;
    private DataTable Uvalues;
    public int SelectedUValue;

    public UValues()
    {
      this.Load += new EventHandler(this.UValues_Load);
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
      this.cmdAddressConfirm = new Button();
      this.uvals = new ListBox();
      this.Button1 = new Button();
      this.SuspendLayout();
      this.cmdAddressConfirm.BackColor = Color.LightSlateGray;
      this.cmdAddressConfirm.Cursor = Cursors.Hand;
      this.cmdAddressConfirm.DialogResult = DialogResult.OK;
      this.cmdAddressConfirm.FlatStyle = FlatStyle.Popup;
      this.cmdAddressConfirm.ForeColor = Color.White;
      this.cmdAddressConfirm.Location = new Point(148, 356);
      this.cmdAddressConfirm.Name = "cmdAddressConfirm";
      this.cmdAddressConfirm.Size = new Size(102, 23);
      this.cmdAddressConfirm.TabIndex = 18;
      this.cmdAddressConfirm.Text = "Confirm";
      this.cmdAddressConfirm.UseVisualStyleBackColor = false;
      this.uvals.BorderStyle = BorderStyle.FixedSingle;
      this.uvals.Cursor = Cursors.Hand;
      this.uvals.FormattingEnabled = true;
      this.uvals.Location = new Point(13, 13);
      this.uvals.Name = "uvals";
      this.uvals.Size = new Size(237, 327);
      this.uvals.TabIndex = 19;
      this.Button1.BackColor = Color.LightSlateGray;
      this.Button1.Cursor = Cursors.Hand;
      this.Button1.DialogResult = DialogResult.Cancel;
      this.Button1.FlatStyle = FlatStyle.Popup;
      this.Button1.ForeColor = Color.White;
      this.Button1.Location = new Point(13, 356);
      this.Button1.Name = "Button1";
      this.Button1.Size = new Size(102, 23);
      this.Button1.TabIndex = 20;
      this.Button1.Text = "Cancel";
      this.Button1.UseVisualStyleBackColor = false;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.White;
      this.ClientSize = new Size(261, 391);
      this.Controls.Add((Control) this.Button1);
      this.Controls.Add((Control) this.uvals);
      this.Controls.Add((Control) this.cmdAddressConfirm);
      this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.Name = nameof (UValues);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "U-value Selection";
      this.ResumeLayout(false);
    }

    internal virtual Button cmdAddressConfirm
    {
      get => this._cmdAddressConfirm;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdAddressConfirm_Click);
        Button cmdAddressConfirm1 = this._cmdAddressConfirm;
        if (cmdAddressConfirm1 != null)
          cmdAddressConfirm1.Click -= eventHandler;
        this._cmdAddressConfirm = value;
        Button cmdAddressConfirm2 = this._cmdAddressConfirm;
        if (cmdAddressConfirm2 == null)
          return;
        cmdAddressConfirm2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("uvals")]
    internal virtual ListBox uvals { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Button1")]
    internal virtual Button Button1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private void UValues_Load(object sender, EventArgs e)
    {
      this.Uvalues = new DataTable();
      this.Uvalues.Columns.Add("ID", typeof (short));
      this.Uvalues.Columns.Add("Name");
      int num = checked (SAP_Module.Proj.SAPUValues.SAPUValues.Length - 1);
      int index = 0;
      while (index <= num)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.Type, SAP_Module.Proj.SAPUValues.SAPUValues[index].prop_entity_type, false) == 0)
        {
          DataRow row = this.Uvalues.NewRow();
          DataRow dataRow = row;
          dataRow["ID"] = (object) index;
          dataRow["Name"] = (object) SAP_Module.Proj.SAPUValues.SAPUValues[index].prop_Name;
          this.Uvalues.Rows.Add(row);
        }
        checked { ++index; }
      }
      this.uvals.DataSource = (object) this.Uvalues;
      this.uvals.DisplayMember = "Name";
    }

    private void cmdAddressConfirm_Click(object sender, EventArgs e)
    {
      if (this.uvals.SelectedIndex == -1)
        return;
      this.SelectedUValue = Conversions.ToInteger(this.Uvalues.Rows[this.uvals.SelectedIndex]["ID"]);
    }
  }
}
