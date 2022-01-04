
// Type: SAP2012.Ordering




using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using SAP2012.My;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SAP2012
{
  [DesignerGenerated]
  public class Ordering : Form
  {
    private IContainer components;

    public Ordering()
    {
      this.Load += new EventHandler(this.Ordering_Load);
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Ordering));
      this.DG1 = new DataGridView();
      this.Button11 = new Button();
      this.cmdChangeOrder = new Button();
      this.Panel1 = new Panel();
      this.Panel2 = new Panel();
      this.cmdDelete = new Button();
      this.Panel3 = new Panel();
      this.cmdSNone = new Button();
      this.cmdSAll = new Button();
      ((ISupportInitialize) this.DG1).BeginInit();
      this.Panel1.SuspendLayout();
      this.Panel2.SuspendLayout();
      this.Panel3.SuspendLayout();
      this.SuspendLayout();
      this.DG1.AllowUserToAddRows = false;
      this.DG1.AllowUserToDeleteRows = false;
      this.DG1.AllowUserToResizeRows = false;
      this.DG1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.DG1.Cursor = Cursors.Hand;
      this.DG1.Dock = DockStyle.Top;
      this.DG1.Location = new Point(0, 0);
      this.DG1.Name = "DG1";
      this.DG1.RowHeadersVisible = false;
      this.DG1.Size = new Size(479, 531);
      this.DG1.TabIndex = 44;
      this.Button11.BackColor = Color.LightSlateGray;
      this.Button11.Cursor = Cursors.Hand;
      this.Button11.DialogResult = DialogResult.OK;
      this.Button11.Dock = DockStyle.Right;
      this.Button11.FlatStyle = FlatStyle.Popup;
      this.Button11.ForeColor = Color.White;
      this.Button11.Location = new Point(321, 0);
      this.Button11.Name = "Button11";
      this.Button11.Size = new Size(158, 43);
      this.Button11.TabIndex = 54;
      this.Button11.Text = "Close";
      this.Button11.UseVisualStyleBackColor = false;
      this.cmdChangeOrder.BackColor = Color.LightSlateGray;
      this.cmdChangeOrder.Cursor = Cursors.Hand;
      this.cmdChangeOrder.DialogResult = DialogResult.OK;
      this.cmdChangeOrder.Dock = DockStyle.Left;
      this.cmdChangeOrder.FlatStyle = FlatStyle.Popup;
      this.cmdChangeOrder.ForeColor = Color.White;
      this.cmdChangeOrder.Location = new Point(0, 0);
      this.cmdChangeOrder.Name = "cmdChangeOrder";
      this.cmdChangeOrder.Size = new Size(191, 43);
      this.cmdChangeOrder.TabIndex = 55;
      this.cmdChangeOrder.Text = "Change Order";
      this.cmdChangeOrder.UseVisualStyleBackColor = false;
      this.Panel1.Controls.Add((Control) this.Panel2);
      this.Panel1.Controls.Add((Control) this.DG1);
      this.Panel1.Dock = DockStyle.Fill;
      this.Panel1.Location = new Point(0, 0);
      this.Panel1.Name = "Panel1";
      this.Panel1.Size = new Size(479, 531);
      this.Panel1.TabIndex = 56;
      this.Panel2.Controls.Add((Control) this.cmdDelete);
      this.Panel2.Controls.Add((Control) this.cmdChangeOrder);
      this.Panel2.Controls.Add((Control) this.Button11);
      this.Panel2.Dock = DockStyle.Bottom;
      this.Panel2.Location = new Point(0, 488);
      this.Panel2.Name = "Panel2";
      this.Panel2.Size = new Size(479, 43);
      this.Panel2.TabIndex = 56;
      this.cmdDelete.BackColor = Color.LightSlateGray;
      this.cmdDelete.Cursor = Cursors.Hand;
      this.cmdDelete.DialogResult = DialogResult.OK;
      this.cmdDelete.Dock = DockStyle.Fill;
      this.cmdDelete.FlatStyle = FlatStyle.Popup;
      this.cmdDelete.ForeColor = Color.White;
      this.cmdDelete.Location = new Point(191, 0);
      this.cmdDelete.Name = "cmdDelete";
      this.cmdDelete.Size = new Size(130, 43);
      this.cmdDelete.TabIndex = 56;
      this.cmdDelete.Text = "Delete Selected";
      this.cmdDelete.UseVisualStyleBackColor = false;
      this.Panel3.Controls.Add((Control) this.cmdSNone);
      this.Panel3.Controls.Add((Control) this.cmdSAll);
      this.Panel3.Dock = DockStyle.Right;
      this.Panel3.Location = new Point(479, 0);
      this.Panel3.Margin = new Padding(2, 2, 2, 2);
      this.Panel3.Name = "Panel3";
      this.Panel3.Size = new Size(95, 531);
      this.Panel3.TabIndex = 57;
      this.cmdSNone.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.cmdSNone.BackColor = Color.LightSlateGray;
      this.cmdSNone.Cursor = Cursors.Hand;
      this.cmdSNone.FlatStyle = FlatStyle.Popup;
      this.cmdSNone.ForeColor = Color.White;
      this.cmdSNone.Location = new Point(5, 33);
      this.cmdSNone.Margin = new Padding(2, 2, 2, 2);
      this.cmdSNone.Name = "cmdSNone";
      this.cmdSNone.Size = new Size(81, 19);
      this.cmdSNone.TabIndex = 48;
      this.cmdSNone.Text = "Select None";
      this.cmdSNone.UseVisualStyleBackColor = false;
      this.cmdSAll.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.cmdSAll.BackColor = Color.LightSlateGray;
      this.cmdSAll.Cursor = Cursors.Hand;
      this.cmdSAll.FlatStyle = FlatStyle.Popup;
      this.cmdSAll.ForeColor = Color.White;
      this.cmdSAll.Location = new Point(5, 10);
      this.cmdSAll.Margin = new Padding(2, 2, 2, 2);
      this.cmdSAll.Name = "cmdSAll";
      this.cmdSAll.Size = new Size(81, 19);
      this.cmdSAll.TabIndex = 47;
      this.cmdSAll.Text = "Select All";
      this.cmdSAll.UseVisualStyleBackColor = false;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(574, 531);
      this.Controls.Add((Control) this.Panel1);
      this.Controls.Add((Control) this.Panel3);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (Ordering);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = nameof (Ordering);
      this.TopMost = true;
      ((ISupportInitialize) this.DG1).EndInit();
      this.Panel1.ResumeLayout(false);
      this.Panel2.ResumeLayout(false);
      this.Panel3.ResumeLayout(false);
      this.ResumeLayout(false);
    }

    internal virtual DataGridView DG1
    {
      get => this._DG1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DataGridViewDataErrorEventHandler errorEventHandler = new DataGridViewDataErrorEventHandler(this.DataGridView1_DataError);
        DataGridViewCellEventHandler cellEventHandler = new DataGridViewCellEventHandler(this.DG1_CellContentClick);
        DataGridView dg1_1 = this._DG1;
        if (dg1_1 != null)
        {
          dg1_1.DataError -= errorEventHandler;
          dg1_1.CellContentClick -= cellEventHandler;
        }
        this._DG1 = value;
        DataGridView dg1_2 = this._DG1;
        if (dg1_2 == null)
          return;
        dg1_2.DataError += errorEventHandler;
        dg1_2.CellContentClick += cellEventHandler;
      }
    }

    internal virtual Button Button11
    {
      get => this._Button11;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button11_Click);
        Button button11_1 = this._Button11;
        if (button11_1 != null)
          button11_1.Click -= eventHandler;
        this._Button11 = value;
        Button button11_2 = this._Button11;
        if (button11_2 == null)
          return;
        button11_2.Click += eventHandler;
      }
    }

    internal virtual Button cmdChangeOrder
    {
      get => this._cmdChangeOrder;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdChangeOrder_Click);
        Button cmdChangeOrder1 = this._cmdChangeOrder;
        if (cmdChangeOrder1 != null)
          cmdChangeOrder1.Click -= eventHandler;
        this._cmdChangeOrder = value;
        Button cmdChangeOrder2 = this._cmdChangeOrder;
        if (cmdChangeOrder2 == null)
          return;
        cmdChangeOrder2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Panel1")]
    internal virtual Panel Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Panel2")]
    internal virtual Panel Panel2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button cmdDelete
    {
      get => this._cmdDelete;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button1_Click);
        Button cmdDelete1 = this._cmdDelete;
        if (cmdDelete1 != null)
          cmdDelete1.Click -= eventHandler;
        this._cmdDelete = value;
        Button cmdDelete2 = this._cmdDelete;
        if (cmdDelete2 == null)
          return;
        cmdDelete2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Panel3")]
    internal virtual Panel Panel3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button cmdSAll
    {
      get => this._cmdSAll;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdSAll_Click);
        Button cmdSall1 = this._cmdSAll;
        if (cmdSall1 != null)
          cmdSall1.Click -= eventHandler;
        this._cmdSAll = value;
        Button cmdSall2 = this._cmdSAll;
        if (cmdSall2 == null)
          return;
        cmdSall2.Click += eventHandler;
      }
    }

    internal virtual Button cmdSNone
    {
      get => this._cmdSNone;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdSNone_Click);
        Button cmdSnone1 = this._cmdSNone;
        if (cmdSnone1 != null)
          cmdSnone1.Click -= eventHandler;
        this._cmdSNone = value;
        Button cmdSnone2 = this._cmdSNone;
        if (cmdSnone2 == null)
          return;
        cmdSnone2.Click += eventHandler;
      }
    }

    private void Ordering_Load(object sender, EventArgs e)
    {
      if (SAP_Module.Proj.NoOfDwells == 0)
        return;
      DataTable dataTable = new DataTable();
      dataTable.Columns.Add("Order", typeof (short));
      dataTable.Columns.Add("Dwelling Name", typeof (string));
      dataTable.Columns.Add("Delete", typeof (bool));
      int num = checked (SAP_Module.Proj.NoOfDwells - 1);
      int index = 0;
      while (index <= num)
      {
        DataRow row = dataTable.NewRow();
        DataRow dataRow = row;
        dataRow["Order"] = (object) index;
        dataRow["Dwelling Name"] = (object) SAP_Module.Proj.Dwellings[index].Name;
        dataTable.Rows.Add(row);
        checked { ++index; }
      }
      this.DG1.DataSource = (object) dataTable;
      this.DG1.Columns["Order"].ReadOnly = true;
      this.DG1.Columns["Order"].DefaultCellStyle.ForeColor = Color.White;
      this.DG1.Columns["Order"].DefaultCellStyle.BackColor = Color.LightGray;
      this.DG1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
    }

    private void Button11_Click(object sender, EventArgs e) => this.Close();

    private void DataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
    {
      int num1 = (int) MessageBox.Show("Error happened " + e.Context.ToString());
      if (e.Context == DataGridViewDataErrorContexts.Commit)
      {
        int num2 = (int) MessageBox.Show("Commit error");
      }
      if (e.Context == DataGridViewDataErrorContexts.CurrentCellChange)
      {
        int num3 = (int) MessageBox.Show("Cell change");
      }
      if (e.Context == DataGridViewDataErrorContexts.Parsing)
      {
        int num4 = (int) MessageBox.Show("parsing error");
      }
      if (e.Context == DataGridViewDataErrorContexts.LeaveControl)
      {
        int num5 = (int) MessageBox.Show("leave control error");
      }
      if (!(e.Exception is ConstraintException))
        return;
      DataGridView dataGridView = (DataGridView) sender;
      dataGridView.Rows[e.RowIndex].ErrorText = "an error";
      dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = "an error";
      e.ThrowException = false;
    }

    private void cmdChangeOrder_Click(object sender, EventArgs e)
    {
      try
      {
        SAP_Module.DontChange = true;
        List<SAP_Module.Dwelling> dwellingList = new List<SAP_Module.Dwelling>();
        int num1 = checked (this.DG1.Rows.Count - 1);
        int index = 0;
        while (index <= num1)
        {
          SAP_Module.Dwelling dwelling = Functions.CopyDwelling(SAP_Module.Proj.Dwellings[Conversions.ToInteger(this.DG1.Rows[index].Cells[0].Value)]);
          dwellingList.Add(dwelling);
          checked { ++index; }
        }
        int num2 = checked (dwellingList.Count - 1);
        int num3 = 0;
        while (num3 <= num2)
        {
          SAP_Module.CurrDwelling = num3;
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling] = dwellingList[SAP_Module.CurrDwelling];
          SAP_Read.ReadDwellingDetails();
          SAP_Read.ReadDimensions();
          SAP_Read.ReadFloors();
          SAP_Read.ReadWalls();
          SAP_Read.ReadRoofs();
          SAP_Read.ReadThermal();
          SAP_Read.ReadWindows();
          SAP_Read.ReadDoors();
          SAP_Read.ReadRoofLights();
          SAP_Read.ReadVentilation();
          SAP_Read.ReadMainHeating();
          try
          {
            SAP_Read.ReadMainHeating2();
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
          SAP_Read.ReadSecHeating();
          SAP_Read.ReadWater();
          try
          {
            SAP_Read.ReadSolar();
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
          try
          {
            SAP_Read.ReadRenewables();
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
          try
          {
            SAP_Read.ReadOverHeating();
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
          SAP_Write.SaveDetails();
          checked { ++num3; }
        }
        SAP_Module.Proj.NoOfDwells = dwellingList.Count;
        Functions.MakeTree();
        MyProject.Forms.SAPForm.TreeSAP.CollapseAll();
        MyProject.Forms.SAPForm.TreeSAP.Nodes[0].Expand();
        SAP_Module.DontChange = false;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Console.Write("");
        ProjectData.ClearProjectError();
      }
    }

    private void Button1_Click(object sender, EventArgs e)
    {
      try
      {
        SAP_Module.DontChange = true;
        List<SAP_Module.Dwelling> dwellingList = new List<SAP_Module.Dwelling>();
        int num1 = checked (this.DG1.Rows.Count - 1);
        int num2 = 0;
        while (num2 <= num1)
        {
          if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DG1[2, num2].Value)))
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DG1[2, num2].Value, (object) false, false))
            {
              SAP_Module.Dwelling dwelling = Functions.CopyDwelling(SAP_Module.Proj.Dwellings[Conversions.ToInteger(this.DG1.Rows[num2].Cells[0].Value)]);
              dwellingList.Add(dwelling);
            }
          }
          else
          {
            SAP_Module.Dwelling dwelling = Functions.CopyDwelling(SAP_Module.Proj.Dwellings[Conversions.ToInteger(this.DG1.Rows[num2].Cells[0].Value)]);
            dwellingList.Add(dwelling);
          }
          checked { ++num2; }
        }
        int num3 = checked (dwellingList.Count - 1);
        int index = 0;
        while (index <= num3)
        {
          SAP_Module.Proj.Dwellings[index] = dwellingList[index];
          checked { ++index; }
        }
        int num4 = checked (dwellingList.Count - 1);
        int num5 = 0;
        while (num5 <= num4)
        {
          SAP_Module.CurrDwelling = num5;
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling] = dwellingList[SAP_Module.CurrDwelling];
          SAP_Read.ReadDwellingDetails();
          SAP_Read.ReadDimensions();
          SAP_Read.ReadFloors();
          SAP_Read.ReadWalls();
          SAP_Read.ReadRoofs();
          SAP_Read.ReadThermal();
          SAP_Read.ReadWindows();
          SAP_Read.ReadDoors();
          SAP_Read.ReadRoofLights();
          SAP_Read.ReadVentilation();
          SAP_Read.ReadMainHeating();
          SAP_Read.ReadMainHeating2();
          SAP_Read.ReadSecHeating();
          SAP_Read.ReadWater();
          SAP_Read.ReadSolar();
          SAP_Read.ReadRenewables();
          SAP_Read.ReadOverHeating();
          SAP_Write.SaveDetails();
          checked { ++num5; }
        }
        SAP_Module.Proj.NoOfDwells = dwellingList.Count;
        Functions.MakeTree();
        MyProject.Forms.SAPForm.TreeSAP.CollapseAll();
        MyProject.Forms.SAPForm.TreeSAP.Nodes[0].Expand();
        SAP_Module.DontChange = false;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Console.Write("");
        ProjectData.ClearProjectError();
      }
    }

    private void DG1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
    }

    private void cmdSAll_Click(object sender, EventArgs e)
    {
      int num = checked (this.DG1.RowCount - 1);
      int rowIndex = 0;
      while (rowIndex <= num)
      {
        this.DG1[2, rowIndex].Selected = true;
        this.DG1[2, rowIndex].Value = (object) true;
        checked { ++rowIndex; }
      }
    }

    private void cmdSNone_Click(object sender, EventArgs e)
    {
      int num = checked (this.DG1.RowCount - 1);
      int rowIndex = 0;
      while (rowIndex <= num)
      {
        this.DG1[2, rowIndex].Selected = false;
        this.DG1[2, rowIndex].Value = (object) false;
        checked { ++rowIndex; }
      }
    }
  }
}
