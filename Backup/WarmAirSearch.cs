
// Type: SAP2012.WarmAirSearch




using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SAP2012
{
  [DesignerGenerated]
  public class WarmAirSearch : Form
  {
    private IContainer components;

    public WarmAirSearch()
    {
      this.Load += new EventHandler(this.WarmAirSearch_Load);
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
      this.cmdCancel = new Button();
      this.cmdOK = new Button();
      this.txtSearch = new TextBox();
      this.Label1 = new Label();
      this.dtgWarmAir = new DataGridView();
      ((ISupportInitialize) this.dtgWarmAir).BeginInit();
      this.SuspendLayout();
      this.cmdCancel.Cursor = Cursors.Hand;
      this.cmdCancel.DialogResult = DialogResult.Cancel;
      this.cmdCancel.Location = new Point(15, 425);
      this.cmdCancel.Name = "cmdCancel";
      this.cmdCancel.Size = new Size(75, 23);
      this.cmdCancel.TabIndex = 9;
      this.cmdCancel.Text = "Cancel";
      this.cmdCancel.UseVisualStyleBackColor = true;
      this.cmdOK.Cursor = Cursors.Hand;
      this.cmdOK.Location = new Point(739, 425);
      this.cmdOK.Name = "cmdOK";
      this.cmdOK.Size = new Size(75, 23);
      this.cmdOK.TabIndex = 8;
      this.cmdOK.Text = "OK";
      this.cmdOK.UseVisualStyleBackColor = true;
      this.txtSearch.Location = new Point(15, 25);
      this.txtSearch.Name = "txtSearch";
      this.txtSearch.Size = new Size(799, 20);
      this.txtSearch.TabIndex = 7;
      this.Label1.AutoSize = true;
      this.Label1.Location = new Point(12, 9);
      this.Label1.Name = "Label1";
      this.Label1.Size = new Size(41, 13);
      this.Label1.TabIndex = 6;
      this.Label1.Text = "Search";
      this.dtgWarmAir.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.dtgWarmAir.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dtgWarmAir.Location = new Point(15, 51);
      this.dtgWarmAir.MultiSelect = false;
      this.dtgWarmAir.Name = "dtgWarmAir";
      this.dtgWarmAir.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dtgWarmAir.Size = new Size(799, 368);
      this.dtgWarmAir.TabIndex = 5;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(824, 462);
      this.Controls.Add((Control) this.cmdCancel);
      this.Controls.Add((Control) this.cmdOK);
      this.Controls.Add((Control) this.txtSearch);
      this.Controls.Add((Control) this.Label1);
      this.Controls.Add((Control) this.dtgWarmAir);
      this.Name = nameof (WarmAirSearch);
      this.Text = nameof (WarmAirSearch);
      ((ISupportInitialize) this.dtgWarmAir).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    [field: AccessedThroughProperty("cmdCancel")]
    internal virtual Button cmdCancel { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button cmdOK
    {
      get => this._cmdOK;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdOK_Click);
        Button cmdOk1 = this._cmdOK;
        if (cmdOk1 != null)
          cmdOk1.Click -= eventHandler;
        this._cmdOK = value;
        Button cmdOk2 = this._cmdOK;
        if (cmdOk2 == null)
          return;
        cmdOk2.Click += eventHandler;
      }
    }

    internal virtual TextBox txtSearch
    {
      get => this._txtSearch;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.TextBox1_TextChanged);
        TextBox txtSearch1 = this._txtSearch;
        if (txtSearch1 != null)
          txtSearch1.TextChanged -= eventHandler;
        this._txtSearch = value;
        TextBox txtSearch2 = this._txtSearch;
        if (txtSearch2 == null)
          return;
        txtSearch2.TextChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Label1")]
    internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("dtgWarmAir")]
    internal virtual DataGridView dtgWarmAir { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private void WarmAirSearch_Load(object sender, EventArgs e)
    {
      PCDF pcdfData;
      List<PCDF.WarmAir> warmAirs = (pcdfData = SAP_Module.PCDFData).WarmAirs;
      List<PCDF.WarmAir> warmAirList1 = Functions.DeepClone<List<PCDF.WarmAir>>(ref warmAirs);
      pcdfData.WarmAirs = warmAirs;
      List<PCDF.WarmAir> warmAirList2 = warmAirList1;
      try
      {
        int num1 = checked (warmAirList2.Count - 1);
        int index = 0;
        while (index <= num1)
        {
          double num2 = Conversion.Val(warmAirList2[index].Status);
          if (num2 == 0.0)
            warmAirList2[index].Status = "normal";
          else if (num2 == 1.0)
            warmAirList2[index].Status = "illustrative";
          else if (num2 == 2.0)
            warmAirList2[index].Status = "under investigation";
          else if (num2 == 3.0)
            warmAirList2[index].Status = "not valid";
          else if (num2 == 4.0)
            warmAirList2[index].Status = "The SAP Warm Air Systems methodology is currently being reviewed. This entry may change.";
          checked { ++index; }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      this.dtgWarmAir.DataSource = (object) warmAirList2;
    }

    private void cmdOK_Click(object sender, EventArgs e)
    {
      if (this.dtgWarmAir.SelectedRows == null)
        return;
      this.DialogResult = DialogResult.OK;
    }

    private void TextBox1_TextChanged(object sender, EventArgs e)
    {
      if ((uint) Operators.CompareString(this.txtSearch.Text, "", false) > 0U)
      {
        List<PCDF.WarmAir> warmAirList = new List<PCDF.WarmAir>();
        List<string> list1 = ((IEnumerable<string>) this.txtSearch.Text.Split(' ')).ToList<string>();
        try
        {
          foreach (string str in list1)
          {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            WarmAirSearch._Closure\u0024__26\u002D0 closure260 = new WarmAirSearch._Closure\u0024__26\u002D0(closure260);
            // ISSUE: reference to a compiler-generated field
            closure260.\u0024VB\u0024Local_part = str;
            // ISSUE: reference to a compiler-generated method
            List<PCDF.WarmAir> list2 = SAP_Module.PCDFData.WarmAirs.Where<PCDF.WarmAir>(new Func<PCDF.WarmAir, bool>(closure260._Lambda\u0024__0)).ToList<PCDF.WarmAir>();
            warmAirList.AddRange((IEnumerable<PCDF.WarmAir>) list2);
          }
        }
        finally
        {
          List<string>.Enumerator enumerator;
          enumerator.Dispose();
        }
        try
        {
          int num1 = checked (warmAirList.Count - 1);
          int index = 0;
          while (index <= num1)
          {
            double num2 = Conversion.Val(warmAirList[index].Status);
            if (num2 == 0.0)
              warmAirList[index].Status = "normal";
            else if (num2 == 1.0)
              warmAirList[index].Status = "illustrative";
            else if (num2 == 2.0)
              warmAirList[index].Status = "under investigation";
            else if (num2 == 3.0)
              warmAirList[index].Status = "not valid";
            else if (num2 == 4.0)
              warmAirList[index].Status = "The SAP Warm Air Systems methodology is currently being reviewed. This entry may change.";
            checked { ++index; }
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        this.dtgWarmAir.DataSource = (object) warmAirList;
      }
      else
      {
        try
        {
          int num3 = checked (SAP_Module.PCDFData.WarmAirs.Count - 1);
          int index = 0;
          while (index <= num3)
          {
            double num4 = Conversion.Val(SAP_Module.PCDFData.WarmAirs[index].Status);
            if (num4 == 0.0)
              SAP_Module.PCDFData.WarmAirs[index].Status = "normal";
            else if (num4 == 1.0)
              SAP_Module.PCDFData.WarmAirs[index].Status = "illustrative";
            else if (num4 == 2.0)
              SAP_Module.PCDFData.WarmAirs[index].Status = "under investigation";
            else if (num4 == 3.0)
              SAP_Module.PCDFData.WarmAirs[index].Status = "not valid";
            else if (num4 == 4.0)
              SAP_Module.PCDFData.WarmAirs[index].Status = "The SAP Warm Air Systems methodology is currently being reviewed. This entry may change.";
            checked { ++index; }
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        this.dtgWarmAir.DataSource = (object) SAP_Module.PCDFData.WarmAirs;
      }
    }
  }
}
