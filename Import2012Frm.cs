
// Type: SAP2012.Import2012Frm




using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using SAP2012.My;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using uValueCalc;

namespace SAP2012
{
  [DesignerGenerated]
  public class Import2012Frm : Form
  {
    private IContainer components;
    private object ProjectImport;

    public Import2012Frm() => this.InitializeComponent();

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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Import2012Frm));
      this.Label1 = new Label();
      this.Button6 = new Button();
      this.Button5 = new Button();
      this.CheckedListBox1 = new CheckedListBox();
      this.Button4 = new Button();
      this.GroupBox3 = new GroupBox();
      this.Button3 = new Button();
      this.OpenFileDialog1 = new OpenFileDialog();
      this.Button1 = new Button();
      this.GroupBox3.SuspendLayout();
      this.SuspendLayout();
      this.Label1.AutoSize = true;
      this.Label1.Location = new Point(6, 352);
      this.Label1.Name = "Label1";
      this.Label1.Size = new Size(190, 13);
      this.Label1.TabIndex = 24;
      this.Label1.Text = "Select the dwellings from the list above";
      this.Button6.BackColor = Color.LightSlateGray;
      this.Button6.Cursor = Cursors.Hand;
      this.Button6.FlatStyle = FlatStyle.Popup;
      this.Button6.ForeColor = Color.White;
      this.Button6.Location = new Point(280, 342);
      this.Button6.Name = "Button6";
      this.Button6.Size = new Size(84, 23);
      this.Button6.TabIndex = 23;
      this.Button6.Text = "Select All";
      this.Button6.UseVisualStyleBackColor = false;
      this.Button5.BackColor = Color.LightSlateGray;
      this.Button5.Cursor = Cursors.Hand;
      this.Button5.FlatStyle = FlatStyle.Popup;
      this.Button5.ForeColor = Color.White;
      this.Button5.Location = new Point(370, 342);
      this.Button5.Name = "Button5";
      this.Button5.Size = new Size(84, 23);
      this.Button5.TabIndex = 22;
      this.Button5.Text = "Select None";
      this.Button5.UseVisualStyleBackColor = false;
      this.CheckedListBox1.CheckOnClick = true;
      this.CheckedListBox1.Cursor = Cursors.Hand;
      this.CheckedListBox1.FormattingEnabled = true;
      this.CheckedListBox1.Location = new Point(6, 49);
      this.CheckedListBox1.Name = "CheckedListBox1";
      this.CheckedListBox1.Size = new Size(448, 289);
      this.CheckedListBox1.TabIndex = 21;
      this.Button4.BackColor = Color.LightSlateGray;
      this.Button4.Cursor = Cursors.Hand;
      this.Button4.DialogResult = DialogResult.OK;
      this.Button4.FlatStyle = FlatStyle.Popup;
      this.Button4.ForeColor = Color.White;
      this.Button4.Location = new Point(331, 20);
      this.Button4.Name = "Button4";
      this.Button4.Size = new Size(123, 23);
      this.Button4.TabIndex = 19;
      this.Button4.Text = "Import";
      this.Button4.UseVisualStyleBackColor = false;
      this.GroupBox3.Controls.Add((Control) this.Label1);
      this.GroupBox3.Controls.Add((Control) this.Button6);
      this.GroupBox3.Controls.Add((Control) this.Button5);
      this.GroupBox3.Controls.Add((Control) this.CheckedListBox1);
      this.GroupBox3.Controls.Add((Control) this.Button3);
      this.GroupBox3.Controls.Add((Control) this.Button4);
      this.GroupBox3.Location = new Point(11, 7);
      this.GroupBox3.Name = "GroupBox3";
      this.GroupBox3.Size = new Size(460, 371);
      this.GroupBox3.TabIndex = 27;
      this.GroupBox3.TabStop = false;
      this.GroupBox3.Text = "Import dwellings from a SAP 2012 project file";
      this.Button3.BackColor = Color.LightSlateGray;
      this.Button3.Cursor = Cursors.Hand;
      this.Button3.FlatStyle = FlatStyle.Popup;
      this.Button3.ForeColor = Color.White;
      this.Button3.Location = new Point(6, 20);
      this.Button3.Name = "Button3";
      this.Button3.Size = new Size(123, 23);
      this.Button3.TabIndex = 20;
      this.Button3.Text = "Select Project";
      this.Button3.UseVisualStyleBackColor = false;
      this.OpenFileDialog1.FileName = "OpenFileDialog1";
      this.OpenFileDialog1.Multiselect = true;
      this.Button1.BackColor = Color.LightSlateGray;
      this.Button1.Cursor = Cursors.Hand;
      this.Button1.DialogResult = DialogResult.Cancel;
      this.Button1.FlatStyle = FlatStyle.Popup;
      this.Button1.ForeColor = Color.White;
      this.Button1.Location = new Point(11, 384);
      this.Button1.Name = "Button1";
      this.Button1.Size = new Size(78, 23);
      this.Button1.TabIndex = 24;
      this.Button1.Text = "Cancel";
      this.Button1.UseVisualStyleBackColor = false;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.White;
      this.ClientSize = new Size(474, 419);
      this.Controls.Add((Control) this.GroupBox3);
      this.Controls.Add((Control) this.Button1);
      this.Cursor = Cursors.Hand;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (Import2012Frm);
      this.Text = "Import 2012 FSAP Dwellings";
      this.GroupBox3.ResumeLayout(false);
      this.GroupBox3.PerformLayout();
      this.ResumeLayout(false);
    }

    [field: AccessedThroughProperty("Label1")]
    internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button6
    {
      get => this._Button6;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button6_Click);
        Button button6_1 = this._Button6;
        if (button6_1 != null)
          button6_1.Click -= eventHandler;
        this._Button6 = value;
        Button button6_2 = this._Button6;
        if (button6_2 == null)
          return;
        button6_2.Click += eventHandler;
      }
    }

    internal virtual Button Button5
    {
      get => this._Button5;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button5_Click);
        Button button5_1 = this._Button5;
        if (button5_1 != null)
          button5_1.Click -= eventHandler;
        this._Button5 = value;
        Button button5_2 = this._Button5;
        if (button5_2 == null)
          return;
        button5_2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("CheckedListBox1")]
    internal virtual CheckedListBox CheckedListBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

    [field: AccessedThroughProperty("GroupBox3")]
    internal virtual GroupBox GroupBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

    [field: AccessedThroughProperty("OpenFileDialog1")]
    internal virtual OpenFileDialog OpenFileDialog1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

    private void Button1_Click(object sender, EventArgs e) => this.Close();

    private void Button6_Click(object sender, EventArgs e)
    {
      int num = checked (this.CheckedListBox1.Items.Count - 1);
      int index = 0;
      while (index <= num)
      {
        this.CheckedListBox1.SetItemChecked(index, true);
        checked { ++index; }
      }
    }

    private void Button5_Click(object sender, EventArgs e)
    {
      int num = checked (this.CheckedListBox1.Items.Count - 1);
      int index = 0;
      while (index <= num)
      {
        this.CheckedListBox1.SetItemChecked(index, false);
        checked { ++index; }
      }
    }

    private void Button3_Click(object sender, EventArgs e)
    {
      try
      {
        this.OpenFileDialog1.FileName = "";
        this.OpenFileDialog1.Filter = "Stroma FSAP Projects (*.sts2012)|*.sts2012";
        int num1 = (int) this.OpenFileDialog1.ShowDialog();
        try
        {
          FileStream serializationStream = File.Open(this.OpenFileDialog1.FileName, FileMode.Open);
          this.ProjectImport = RuntimeHelpers.GetObjectValue(new BinaryFormatter().Deserialize((Stream) serializationStream));
          serializationStream.Close();
          this.CheckedListBox1.Items.Clear();
          object Counter;
          object LoopForResult;
          object objectValue1;
          if (!ObjectFlowControl.ForLoopControl.ForLoopInitObj(Counter, (object) 0, Operators.SubtractObject(NewLateBinding.LateGet(this.ProjectImport, (System.Type) null, "NoofDwells", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) 1), (object) 1, ref LoopForResult, ref objectValue1))
            return;
          do
          {
            CheckedListBox.ObjectCollection items = this.CheckedListBox1.Items;
            object[] objArray;
            bool[] flagArray;
            object Instance = NewLateBinding.LateGet(this.ProjectImport, (System.Type) null, "Dwellings", objArray = new object[1]
            {
              objectValue1
            }, (string[]) null, (System.Type[]) null, flagArray = new bool[1]
            {
              true
            });
            if (flagArray[0])
              objectValue1 = RuntimeHelpers.GetObjectValue(objArray[0]);
            object[] Arguments = new object[0];
            object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Instance, (System.Type) null, "name", Arguments, (string[]) null, (System.Type[]) null, (bool[]) null));
            items.Add(objectValue2, false);
          }
          while (ObjectFlowControl.ForLoopControl.ForNextCheckObj(objectValue1, LoopForResult, ref objectValue1));
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          int num2 = (int) Interaction.MsgBox((object) Information.Err().Description);
          ProjectData.ClearProjectError();
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) "Error Occured", MsgBoxStyle.Information, (object) "Open File Information");
        ProjectData.ClearProjectError();
      }
      finally
      {
      }
    }

    private void Button4_Click(object sender, EventArgs e)
    {
      int[] numArray = new int[0];
      int num = checked (this.CheckedListBox1.CheckedIndices.Count - 1);
      int index = 0;
      while (index <= num)
      {
        numArray = (int[]) Utils.CopyArray((Array) numArray, (Array) new int[checked (numArray.Length + 1)]);
        numArray[checked (numArray.Length - 1)] = this.CheckedListBox1.CheckedIndices[index];
        checked { ++index; }
      }
      if ((uint) numArray.Length <= 0U)
        return;
      this.Import_2012_Method(RuntimeHelpers.GetObjectValue(this.ProjectImport), numArray);
    }

    public void Import_2012_Method(object ProjectImport, int[] Dwellings)
    {
      try
      {
        int num1 = checked (Dwellings.Length - 1);
        int index = 0;
        while (index <= num1)
        {
          MyProject.Forms.SAPForm.TreeSAP.SelectedNode = MyProject.Forms.SAPForm.TreeSAP.Nodes[0];
          Application.DoEvents();
          // ISSUE: variable of a reference type
          int& local1;
          // ISSUE: explicit reference operation
          int num2 = checked (^(local1 = ref SAP_Module.Proj.NoOfDwells) + 1);
          local1 = num2;
          // ISSUE: variable of a reference type
          SAP_Module.Dwelling[]& local2;
          // ISSUE: explicit reference operation
          SAP_Module.Dwelling[] dwellingArray = (SAP_Module.Dwelling[]) Utils.CopyArray((Array) ^(local2 = ref SAP_Module.Proj.Dwellings), (Array) new SAP_Module.Dwelling[checked (SAP_Module.Proj.NoOfDwells - 1 + 1)]);
          local2 = dwellingArray;
          ref SAP_Module.Dwelling local3 = ref SAP_Module.Proj.Dwellings[checked (SAP_Module.Proj.NoOfDwells - 1)];
          // ISSUE: variable of a reference type
          int& local4;
          object[] objArray1;
          bool[] flagArray1;
          // ISSUE: explicit reference operation
          object Instance1 = NewLateBinding.LateGet(ProjectImport, (System.Type) null, nameof (Dwellings), objArray1 = new object[1]
          {
            (object) ^(local4 = ref Dwellings[index])
          }, (string[]) null, (System.Type[]) null, flagArray1 = new bool[1]
          {
            true
          });
          if (flagArray1[0])
            local4 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray1[0]), typeof (int));
          string str = Conversions.ToString(NewLateBinding.LateGet(Instance1, (System.Type) null, "name", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local3.Name = str;
          ref SAP_Module.Dwelling local5 = ref SAP_Module.Proj.Dwellings[checked (SAP_Module.Proj.NoOfDwells - 1)];
          // ISSUE: variable of a reference type
          int& local6;
          object[] objArray2;
          bool[] flagArray2;
          // ISSUE: explicit reference operation
          object Instance2 = NewLateBinding.LateGet(ProjectImport, (System.Type) null, nameof (Dwellings), objArray2 = new object[1]
          {
            (object) ^(local6 = ref Dwellings[index])
          }, (string[]) null, (System.Type[]) null, flagArray2 = new bool[1]
          {
            true
          });
          if (flagArray2[0])
            local6 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray2[0]), typeof (int));
          int integer = Conversions.ToInteger(NewLateBinding.LateGet(Instance2, (System.Type) null, "YearBuilt", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local5.YearBuilt = integer;
          SAP_Module.CurrDwelling = checked (SAP_Module.Proj.NoOfDwells - 1);
          SAP_Module.Dwelling[] dwellings = SAP_Module.Proj.Dwellings;
          int currDwelling = SAP_Module.CurrDwelling;
          // ISSUE: variable of a reference type
          int& local7;
          object[] objArray3;
          bool[] flagArray3;
          // ISSUE: explicit reference operation
          object obj1 = NewLateBinding.LateGet(ProjectImport, (System.Type) null, nameof (Dwellings), objArray3 = new object[1]
          {
            (object) ^(local7 = ref Dwellings[index])
          }, (string[]) null, (System.Type[]) null, flagArray3 = new bool[1]
          {
            true
          });
          if (flagArray3[0])
            local7 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray3[0]), typeof (int));
          object obj2 = obj1;
          SAP_Module.Dwelling dwelling = obj2 != null ? (SAP_Module.Dwelling) obj2 : new SAP_Module.Dwelling();
          dwellings[currDwelling] = dwelling;
          try
          {
            SAP_Module.Proj.SAPUValues.SAPUValues = (Output.uValueInfo[]) NewLateBinding.LateGet(ProjectImport, (System.Type) null, "SAPUValues", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null);
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
          Validation.Checkerrors_All(SAP_Module.CurrDwelling);
          checked { ++index; }
        }
        Functions.MakeTree();
        MyProject.Forms.SAPForm.TreeSAP.SelectedNode = MyProject.Forms.SAPForm.TreeSAP.Nodes[0].Nodes[SAP_Module.CurrDwelling];
        SAP_Write.SaveDetails_Validation(SAP_Module.CurrDwelling);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) "Error Occured", MsgBoxStyle.Information, (object) "Open File Information");
        ProjectData.ClearProjectError();
      }
      finally
      {
      }
    }
  }
}
