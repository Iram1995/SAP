
// Type: SAP2012.MoveToo




using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using SAP2012.My;
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
  public class MoveToo : Form
  {
    private IContainer components;
    private DataTable dt;

    public MoveToo()
    {
      this.Load += new EventHandler(this.MoveToo_Load);
      this.dt = new DataTable();
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
      this.cmdOK = new Button();
      this.Button1 = new Button();
      this.lstDwellings = new ListBox();
      this.Label1 = new Label();
      this.Label2 = new Label();
      this.SuspendLayout();
      this.cmdOK.BackColor = Color.LightSlateGray;
      this.cmdOK.Cursor = Cursors.Hand;
      this.cmdOK.FlatStyle = FlatStyle.Popup;
      this.cmdOK.ForeColor = Color.White;
      this.cmdOK.Location = new Point(132, 380);
      this.cmdOK.Name = "cmdOK";
      this.cmdOK.Size = new Size(112, 23);
      this.cmdOK.TabIndex = 18;
      this.cmdOK.Text = "OK";
      this.cmdOK.UseVisualStyleBackColor = false;
      this.Button1.BackColor = Color.LightSlateGray;
      this.Button1.Cursor = Cursors.Hand;
      this.Button1.DialogResult = DialogResult.Cancel;
      this.Button1.FlatStyle = FlatStyle.Popup;
      this.Button1.ForeColor = Color.White;
      this.Button1.Location = new Point(12, 380);
      this.Button1.Name = "Button1";
      this.Button1.Size = new Size(104, 23);
      this.Button1.TabIndex = 19;
      this.Button1.Text = "Cancel";
      this.Button1.UseVisualStyleBackColor = false;
      this.lstDwellings.BackColor = Color.White;
      this.lstDwellings.Cursor = Cursors.Hand;
      this.lstDwellings.FormattingEnabled = true;
      this.lstDwellings.Location = new Point(12, 52);
      this.lstDwellings.Name = "lstDwellings";
      this.lstDwellings.Size = new Size(232, 316);
      this.lstDwellings.TabIndex = 20;
      this.Label1.AutoSize = true;
      this.Label1.Font = new Font("Tahoma", 8.25f, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, (byte) 0);
      this.Label1.Location = new Point(40, 7);
      this.Label1.Name = "Label1";
      this.Label1.Size = new Size(176, 13);
      this.Label1.TabIndex = 21;
      this.Label1.Text = "Select Dwelling Position Below";
      this.Label2.AutoSize = true;
      this.Label2.Font = new Font("Tahoma", 8.25f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.Label2.Location = new Point(13, 23);
      this.Label2.Name = "Label2";
      this.Label2.Size = new Size(198, 26);
      this.Label2.TabIndex = 22;
      this.Label2.Text = "Note the current dwelling will be\r\npositioned before the selected dwelling.";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.White;
      this.ClientSize = new Size(256, 415);
      this.Controls.Add((Control) this.Label2);
      this.Controls.Add((Control) this.Label1);
      this.Controls.Add((Control) this.lstDwellings);
      this.Controls.Add((Control) this.Button1);
      this.Controls.Add((Control) this.cmdOK);
      this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.Name = nameof (MoveToo);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Change dwelling location";
      this.ResumeLayout(false);
      this.PerformLayout();
    }

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

    [field: AccessedThroughProperty("Button1")]
    internal virtual Button Button1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("lstDwellings")]
    internal virtual ListBox lstDwellings { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label1")]
    internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label2")]
    internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private void MoveToo_Load(object sender, EventArgs e)
    {
      this.dt.Columns.Add("ID", typeof (short));
      this.dt.Columns.Add("Name");
      int num = checked (SAP_Module.Proj.NoOfDwells - 1);
      int index = 0;
      while (index <= num)
      {
        if (SAP_Module.CurrDwelling != index)
        {
          DataRow row = this.dt.NewRow();
          row["ID"] = (object) index;
          row["Name"] = (object) SAP_Module.Proj.Dwellings[index].Name;
          this.dt.Rows.Add(row);
        }
        checked { ++index; }
      }
      this.lstDwellings.DataSource = (object) this.dt;
      this.lstDwellings.DisplayMember = "Name";
    }

    private void cmdOK_Click(object sender, EventArgs e)
    {
      try
      {
        int selectedIndex = this.lstDwellings.SelectedIndex;
        if (SAP_Module.CurrDwelling > -1)
        {
          DataRow row = this.dt.Rows[selectedIndex];
          if (Interaction.MsgBox(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("Move " + SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Name + " before "), row["Name"]), MsgBoxStyle.YesNo | MsgBoxStyle.Question, (object) "Delete Dwelling?") == MsgBoxResult.Yes)
          {
            SAP_Module.DontChange = true;
            MyProject.Forms.SAPForm.TreeSAP.SelectedNode = MyProject.Forms.SAPForm.TreeSAP.Nodes[0];
            SAP_Module.Dwelling Dwelling = Functions.CopyDwelling(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling]);
            if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectLess((object) SAP_Module.CurrDwelling, row["ID"], false))
            {
              object Counter;
              object LoopForResult;
              object CounterResult;
              if (ObjectFlowControl.ForLoopControl.ForLoopInitObj(Counter, (object) SAP_Module.CurrDwelling, Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject(row["ID"], (object) 2), (object) 1, ref LoopForResult, ref CounterResult))
              {
                do
                {
                  SAP_Module.Proj.Dwellings[Conversions.ToInteger(CounterResult)] = Functions.CopyDwelling(SAP_Module.Proj.Dwellings[Conversions.ToInteger(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(CounterResult, (object) 1))]);
                }
                while (ObjectFlowControl.ForLoopControl.ForNextCheckObj(CounterResult, LoopForResult, ref CounterResult));
              }
              SAP_Module.Proj.Dwellings[Conversions.ToInteger(Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject(row["ID"], (object) 1))] = Functions.CopyDwelling(Dwelling);
            }
            else
            {
              object Counter;
              object LoopForResult;
              object CounterResult;
              if (ObjectFlowControl.ForLoopControl.ForLoopInitObj(Counter, (object) SAP_Module.CurrDwelling, Microsoft.VisualBasic.CompilerServices.Operators.AddObject(row["ID"], (object) 1), (object) -1, ref LoopForResult, ref CounterResult))
              {
                do
                {
                  SAP_Module.Proj.Dwellings[Conversions.ToInteger(CounterResult)] = Functions.CopyDwelling(SAP_Module.Proj.Dwellings[Conversions.ToInteger(Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject(CounterResult, (object) 1))]);
                }
                while (ObjectFlowControl.ForLoopControl.ForNextCheckObj(CounterResult, LoopForResult, ref CounterResult));
              }
              SAP_Module.Proj.Dwellings[Conversions.ToInteger(row["ID"])] = Functions.CopyDwelling(Dwelling);
            }
            Functions.MakeTree();
            MyProject.Forms.SAPForm.TreeSAP.CollapseAll();
            MyProject.Forms.SAPForm.TreeSAP.Nodes[0].Expand();
            SAP_Module.DontChange = false;
          }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      this.DialogResult = DialogResult.OK;
    }
  }
}
