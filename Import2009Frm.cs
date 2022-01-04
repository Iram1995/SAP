
// Type: SAP2012.Import2009Frm




using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace SAP2012
{
  [DesignerGenerated]
  public class Import2009Frm : Form
  {
    private IContainer components;
    private object ProjectImport;

    public Import2009Frm()
    {
      this.Load += new EventHandler(this.Import2009Frm_Load);
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
      this.Label1 = new Label();
      this.Button6 = new Button();
      this.Button5 = new Button();
      this.CheckedListBox1 = new CheckedListBox();
      this.Button4 = new Button();
      this.GroupBox3 = new GroupBox();
      this.Button3 = new Button();
      this.Label4 = new Label();
      this.Label3 = new Label();
      this.OpenFileDialog1 = new OpenFileDialog();
      this.Label2 = new Label();
      this.GroupBox2 = new GroupBox();
      this.lstFiles = new ListBox();
      this.Button2 = new Button();
      this.GroupBox1 = new GroupBox();
      this.cmdProducts = new Button();
      this.Button1 = new Button();
      this.GroupBox3.SuspendLayout();
      this.GroupBox2.SuspendLayout();
      this.GroupBox1.SuspendLayout();
      this.SuspendLayout();
      this.Label1.AutoSize = true;
      this.Label1.Location = new Point(7, 155);
      this.Label1.Name = "Label1";
      this.Label1.Size = new Size(218, 15);
      this.Label1.TabIndex = 24;
      this.Label1.Text = "Select the dwellings from the list above";
      this.Button6.BackColor = Color.LightSlateGray;
      this.Button6.Cursor = Cursors.Hand;
      this.Button6.FlatStyle = FlatStyle.Popup;
      this.Button6.ForeColor = Color.White;
      this.Button6.Location = new Point(280, 155);
      this.Button6.Name = "Button6";
      this.Button6.Size = new Size(84, 23);
      this.Button6.TabIndex = 23;
      this.Button6.Text = "Select All";
      this.Button6.UseVisualStyleBackColor = false;
      this.Button5.BackColor = Color.LightSlateGray;
      this.Button5.Cursor = Cursors.Hand;
      this.Button5.FlatStyle = FlatStyle.Popup;
      this.Button5.ForeColor = Color.White;
      this.Button5.Location = new Point(370, 155);
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
      this.CheckedListBox1.Size = new Size(448, 94);
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
      this.GroupBox3.Size = new Size(460, 187);
      this.GroupBox3.TabIndex = 27;
      this.GroupBox3.TabStop = false;
      this.GroupBox3.Text = "Import dwellings from a SAP 2009 project file";
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
      this.Label4.AutoSize = true;
      this.Label4.Location = new Point(7, 85);
      this.Label4.Name = "Label4";
      this.Label4.Size = new Size(439, 30);
      this.Label4.TabIndex = 2;
      this.Label4.Text = "3) There will be a need to specify thermal mass parameters within the imported \r\ndwelling";
      this.Label3.AutoSize = true;
      this.Label3.Location = new Point(7, 45);
      this.Label3.Name = "Label3";
      this.Label3.Size = new Size(443, 30);
      this.Label3.TabIndex = 1;
      this.Label3.Text = "2) If the main heating from the original source is community heating, the heating \r\nwill require respecification within the imported dwelling.";
      this.OpenFileDialog1.FileName = "OpenFileDialog1";
      this.OpenFileDialog1.Multiselect = true;
      this.Label2.AutoSize = true;
      this.Label2.Location = new Point(7, 21);
      this.Label2.Name = "Label2";
      this.Label2.Size = new Size(434, 15);
      this.Label2.TabIndex = 0;
      this.Label2.Text = "1) There will be a need to specify thermal bridging within the imported dwelling";
      this.GroupBox2.Controls.Add((Control) this.Label4);
      this.GroupBox2.Controls.Add((Control) this.Label3);
      this.GroupBox2.Controls.Add((Control) this.Label2);
      this.GroupBox2.Location = new Point(11, 358);
      this.GroupBox2.Name = "GroupBox2";
      this.GroupBox2.Size = new Size(460, 128);
      this.GroupBox2.TabIndex = 26;
      this.GroupBox2.TabStop = false;
      this.GroupBox2.Text = "Notes";
      this.lstFiles.Cursor = Cursors.Hand;
      this.lstFiles.FormattingEnabled = true;
      this.lstFiles.Location = new Point(6, 49);
      this.lstFiles.Name = "lstFiles";
      this.lstFiles.Size = new Size(448, 95);
      this.lstFiles.TabIndex = 21;
      this.Button2.BackColor = Color.LightSlateGray;
      this.Button2.Cursor = Cursors.Hand;
      this.Button2.FlatStyle = FlatStyle.Popup;
      this.Button2.ForeColor = Color.White;
      this.Button2.Location = new Point(6, 20);
      this.Button2.Name = "Button2";
      this.Button2.Size = new Size(123, 23);
      this.Button2.TabIndex = 20;
      this.Button2.Text = "Select File(s)";
      this.Button2.UseVisualStyleBackColor = false;
      this.GroupBox1.Controls.Add((Control) this.lstFiles);
      this.GroupBox1.Controls.Add((Control) this.Button2);
      this.GroupBox1.Controls.Add((Control) this.cmdProducts);
      this.GroupBox1.Location = new Point(11, 200);
      this.GroupBox1.Name = "GroupBox1";
      this.GroupBox1.Size = new Size(460, 152);
      this.GroupBox1.TabIndex = 25;
      this.GroupBox1.TabStop = false;
      this.GroupBox1.Text = "Import from SAP 2009 dwelling files";
      this.cmdProducts.BackColor = Color.LightSlateGray;
      this.cmdProducts.Cursor = Cursors.Hand;
      this.cmdProducts.DialogResult = DialogResult.OK;
      this.cmdProducts.FlatStyle = FlatStyle.Popup;
      this.cmdProducts.ForeColor = Color.White;
      this.cmdProducts.Location = new Point(331, 20);
      this.cmdProducts.Name = "cmdProducts";
      this.cmdProducts.Size = new Size(123, 23);
      this.cmdProducts.TabIndex = 19;
      this.cmdProducts.Text = "Import";
      this.cmdProducts.UseVisualStyleBackColor = false;
      this.Button1.BackColor = Color.LightSlateGray;
      this.Button1.Cursor = Cursors.Hand;
      this.Button1.DialogResult = DialogResult.Cancel;
      this.Button1.FlatStyle = FlatStyle.Popup;
      this.Button1.ForeColor = Color.White;
      this.Button1.Location = new Point(12, 492);
      this.Button1.Name = "Button1";
      this.Button1.Size = new Size(78, 23);
      this.Button1.TabIndex = 24;
      this.Button1.Text = "Cancel";
      this.Button1.UseVisualStyleBackColor = false;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.White;
      this.ClientSize = new Size(474, 525);
      this.Controls.Add((Control) this.GroupBox3);
      this.Controls.Add((Control) this.GroupBox2);
      this.Controls.Add((Control) this.GroupBox1);
      this.Controls.Add((Control) this.Button1);
      this.Cursor = Cursors.Hand;
      this.Name = nameof (Import2009Frm);
      this.Text = "Import 2009 FSAP Dwellings";
      this.GroupBox3.ResumeLayout(false);
      this.GroupBox3.PerformLayout();
      this.GroupBox2.ResumeLayout(false);
      this.GroupBox2.PerformLayout();
      this.GroupBox1.ResumeLayout(false);
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

    [field: AccessedThroughProperty("Label4")]
    internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label3")]
    internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("OpenFileDialog1")]
    internal virtual OpenFileDialog OpenFileDialog1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label2")]
    internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox2")]
    internal virtual GroupBox GroupBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("lstFiles")]
    internal virtual ListBox lstFiles { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

    [field: AccessedThroughProperty("GroupBox1")]
    internal virtual GroupBox GroupBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button cmdProducts
    {
      get => this._cmdProducts;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdProducts_Click);
        Button cmdProducts1 = this._cmdProducts;
        if (cmdProducts1 != null)
          cmdProducts1.Click -= eventHandler;
        this._cmdProducts = value;
        Button cmdProducts2 = this._cmdProducts;
        if (cmdProducts2 == null)
          return;
        cmdProducts2.Click += eventHandler;
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
        this.OpenFileDialog1.Filter = "Stroma FSAP Projects (*.sts2009)|*.sts2009";
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
      Import2009 import2009 = new Import2009();
      if ((uint) numArray.Length <= 0U)
        return;
      import2009.Import_2009_Method(RuntimeHelpers.GetObjectValue(this.ProjectImport), numArray);
    }

    private void Button2_Click(object sender, EventArgs e)
    {
      try
      {
        this.OpenFileDialog1.FileName = "";
        this.OpenFileDialog1.Filter = "Stroma FSAP Dwelling (*.dwl2009)|*.dwl2009";
        int num1 = (int) this.OpenFileDialog1.ShowDialog();
        this.lstFiles.Items.Clear();
        int num2 = checked (this.OpenFileDialog1.FileNames.Length - 1);
        int index = 0;
        while (index <= num2)
        {
          this.lstFiles.Items.Add((object) this.OpenFileDialog1.FileNames[index]);
          checked { ++index; }
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

    private void cmdProducts_Click(object sender, EventArgs e)
    {
      string[] strArray = new string[1];
      if (this.lstFiles.Items.Count == 0)
        return;
      int num = checked (this.lstFiles.Items.Count - 1);
      int index = 0;
      while (index <= num)
      {
        strArray = (string[]) Utils.CopyArray((Array) strArray, (Array) new string[checked (index + 1)]);
        strArray[index] = Conversions.ToString(this.lstFiles.Items[index]);
        checked { ++index; }
      }
      new Import2009().Import_2009_Dwellings(strArray);
    }

    private void Import2009Frm_Load(object sender, EventArgs e)
    {
    }
  }
}
