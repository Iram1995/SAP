
// Type: SAP2012.Copy_Dwelling




using Microsoft.VisualBasic;
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
  public class Copy_Dwelling : Form
  {
    private IContainer components;

    public Copy_Dwelling() => this.InitializeComponent();

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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Copy_Dwelling));
      this.cmdClose = new Button();
      this.Label1 = new Label();
      this.lblCopy = new Label();
      this.cmdCopy = new Button();
      this.chkIncludeOrientation = new CheckBox();
      this.grpOrientation = new GroupBox();
      this.txtOriginalOrientation = new TextBox();
      this.chkDoAll = new CheckBox();
      this.txtNewOrientation = new ComboBox();
      this.Label2 = new Label();
      this.Label77 = new Label();
      this.PictureBox1 = new PictureBox();
      this.chkIncludeMirror = new CheckBox();
      this.GroupBox1 = new GroupBox();
      this.txtMirrorLine = new ComboBox();
      this.Label3 = new Label();
      this.cmdBatchCopy = new Button();
      this.grpOrientation.SuspendLayout();
      ((ISupportInitialize) this.PictureBox1).BeginInit();
      this.GroupBox1.SuspendLayout();
      this.SuspendLayout();
      this.cmdClose.BackColor = Color.LightSlateGray;
      this.cmdClose.Cursor = Cursors.Hand;
      this.cmdClose.DialogResult = DialogResult.OK;
      this.cmdClose.FlatStyle = FlatStyle.Popup;
      this.cmdClose.ForeColor = Color.White;
      this.cmdClose.Location = new Point(12, 297);
      this.cmdClose.Name = "cmdClose";
      this.cmdClose.Size = new Size(159, 23);
      this.cmdClose.TabIndex = 19;
      this.cmdClose.Text = "Close";
      this.cmdClose.UseVisualStyleBackColor = false;
      this.Label1.AutoSize = true;
      this.Label1.Location = new Point(9, 13);
      this.Label1.Name = "Label1";
      this.Label1.Size = new Size(99, 17);
      this.Label1.TabIndex = 20;
      this.Label1.Text = "Copy Dwelling:";
      this.lblCopy.AutoSize = true;
      this.lblCopy.Location = new Point(97, 13);
      this.lblCopy.Name = "lblCopy";
      this.lblCopy.Size = new Size(99, 17);
      this.lblCopy.TabIndex = 21;
      this.lblCopy.Text = "Copy Dwelling:";
      this.cmdCopy.BackColor = Color.LightSlateGray;
      this.cmdCopy.Cursor = Cursors.Hand;
      this.cmdCopy.DialogResult = DialogResult.OK;
      this.cmdCopy.FlatStyle = FlatStyle.Popup;
      this.cmdCopy.ForeColor = Color.White;
      this.cmdCopy.Location = new Point(273, 297);
      this.cmdCopy.Name = "cmdCopy";
      this.cmdCopy.Size = new Size(159, 23);
      this.cmdCopy.TabIndex = 22;
      this.cmdCopy.Text = "Copy";
      this.cmdCopy.UseVisualStyleBackColor = false;
      this.chkIncludeOrientation.AutoSize = true;
      this.chkIncludeOrientation.Cursor = Cursors.Hand;
      this.chkIncludeOrientation.Location = new Point(12, 39);
      this.chkIncludeOrientation.Name = "chkIncludeOrientation";
      this.chkIncludeOrientation.Size = new Size(317, 21);
      this.chkIncludeOrientation.TabIndex = 23;
      this.chkIncludeOrientation.Text = "Change Orientation During Dwelling Duplication";
      this.chkIncludeOrientation.UseVisualStyleBackColor = true;
      this.grpOrientation.Controls.Add((Control) this.txtOriginalOrientation);
      this.grpOrientation.Controls.Add((Control) this.chkDoAll);
      this.grpOrientation.Controls.Add((Control) this.txtNewOrientation);
      this.grpOrientation.Controls.Add((Control) this.Label2);
      this.grpOrientation.Controls.Add((Control) this.Label77);
      this.grpOrientation.Enabled = false;
      this.grpOrientation.Location = new Point(12, 62);
      this.grpOrientation.Name = "grpOrientation";
      this.grpOrientation.Size = new Size(420, 106);
      this.grpOrientation.TabIndex = 24;
      this.grpOrientation.TabStop = false;
      this.grpOrientation.Text = "Orientation";
      this.txtOriginalOrientation.Location = new Point(183, 11);
      this.txtOriginalOrientation.Name = "txtOriginalOrientation";
      this.txtOriginalOrientation.ReadOnly = true;
      this.txtOriginalOrientation.Size = new Size(188, 24);
      this.txtOriginalOrientation.TabIndex = 26;
      this.chkDoAll.AutoSize = true;
      this.chkDoAll.Checked = true;
      this.chkDoAll.CheckState = CheckState.Checked;
      this.chkDoAll.Cursor = Cursors.Hand;
      this.chkDoAll.Location = new Point(21, 74);
      this.chkDoAll.Name = "chkDoAll";
      this.chkDoAll.Size = new Size(389, 21);
      this.chkDoAll.TabIndex = 24;
      this.chkDoAll.Text = "Change All Other Orientations (Windows... etc) Accordingly";
      this.chkDoAll.UseVisualStyleBackColor = true;
      this.txtNewOrientation.Cursor = Cursors.Hand;
      this.txtNewOrientation.FormattingEnabled = true;
      this.txtNewOrientation.Items.AddRange(new object[8]
      {
        (object) "North",
        (object) "North East",
        (object) "East",
        (object) "South East",
        (object) "South",
        (object) "South West",
        (object) "West",
        (object) "North West"
      });
      this.txtNewOrientation.Location = new Point(183, 47);
      this.txtNewOrientation.Name = "txtNewOrientation";
      this.txtNewOrientation.Size = new Size(188, 25);
      this.txtNewOrientation.TabIndex = 18;
      this.Label2.AutoSize = true;
      this.Label2.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label2.Location = new Point(18, 50);
      this.Label2.Name = "Label2";
      this.Label2.Size = new Size(166, 18);
      this.Label2.TabIndex = 17;
      this.Label2.Text = "New Dwelling Orientation";
      this.Label77.AutoSize = true;
      this.Label77.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label77.Location = new Point(18, 23);
      this.Label77.Name = "Label77";
      this.Label77.Size = new Size(182, 18);
      this.Label77.TabIndex = 15;
      this.Label77.Text = "Source Dwelling Orientation";
      this.PictureBox1.Image = (Image) componentResourceManager.GetObject("PictureBox1.Image");
      this.PictureBox1.Location = new Point(325, 2);
      this.PictureBox1.Name = "PictureBox1";
      this.PictureBox1.Size = new Size(110, 65);
      this.PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
      this.PictureBox1.TabIndex = 36;
      this.PictureBox1.TabStop = false;
      this.chkIncludeMirror.AutoSize = true;
      this.chkIncludeMirror.Cursor = Cursors.Hand;
      this.chkIncludeMirror.Location = new Point(12, 174);
      this.chkIncludeMirror.Name = "chkIncludeMirror";
      this.chkIncludeMirror.Size = new Size(147, 21);
      this.chkIncludeMirror.TabIndex = 39;
      this.chkIncludeMirror.Text = "Mirror the Property";
      this.chkIncludeMirror.UseVisualStyleBackColor = true;
      this.GroupBox1.Controls.Add((Control) this.txtMirrorLine);
      this.GroupBox1.Controls.Add((Control) this.Label3);
      this.GroupBox1.Enabled = false;
      this.GroupBox1.Location = new Point(12, 197);
      this.GroupBox1.Name = "GroupBox1";
      this.GroupBox1.Size = new Size(420, 65);
      this.GroupBox1.TabIndex = 40;
      this.GroupBox1.TabStop = false;
      this.GroupBox1.Text = "Select Mirror Line";
      this.txtMirrorLine.Cursor = Cursors.Hand;
      this.txtMirrorLine.FormattingEnabled = true;
      this.txtMirrorLine.Items.AddRange(new object[4]
      {
        (object) "North-South",
        (object) "NorthWest-SouthEast",
        (object) "East-West",
        (object) "SouthWest-NorthEast"
      });
      this.txtMirrorLine.Location = new Point(183, 24);
      this.txtMirrorLine.Name = "txtMirrorLine";
      this.txtMirrorLine.Size = new Size(188, 25);
      this.txtMirrorLine.TabIndex = 18;
      this.Label3.AutoSize = true;
      this.Label3.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label3.Location = new Point(18, 27);
      this.Label3.Name = "Label3";
      this.Label3.Size = new Size(118, 18);
      this.Label3.TabIndex = 17;
      this.Label3.Text = "Select Mirror Line";
      this.cmdBatchCopy.BackColor = Color.LightSlateGray;
      this.cmdBatchCopy.Cursor = Cursors.Hand;
      this.cmdBatchCopy.DialogResult = DialogResult.OK;
      this.cmdBatchCopy.FlatStyle = FlatStyle.Popup;
      this.cmdBatchCopy.ForeColor = Color.White;
      this.cmdBatchCopy.Location = new Point(12, 268);
      this.cmdBatchCopy.Name = "cmdBatchCopy";
      this.cmdBatchCopy.Size = new Size(159, 23);
      this.cmdBatchCopy.TabIndex = 41;
      this.cmdBatchCopy.Text = "Batch Copy";
      this.cmdBatchCopy.UseVisualStyleBackColor = false;
      this.AutoScaleDimensions = new SizeF(8f, 17f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.White;
      this.ClientSize = new Size(447, 329);
      this.Controls.Add((Control) this.cmdBatchCopy);
      this.Controls.Add((Control) this.chkIncludeMirror);
      this.Controls.Add((Control) this.GroupBox1);
      this.Controls.Add((Control) this.PictureBox1);
      this.Controls.Add((Control) this.chkIncludeOrientation);
      this.Controls.Add((Control) this.grpOrientation);
      this.Controls.Add((Control) this.cmdCopy);
      this.Controls.Add((Control) this.lblCopy);
      this.Controls.Add((Control) this.Label1);
      this.Controls.Add((Control) this.cmdClose);
      this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.Name = nameof (Copy_Dwelling);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Copy Dwelling";
      this.grpOrientation.ResumeLayout(false);
      this.grpOrientation.PerformLayout();
      ((ISupportInitialize) this.PictureBox1).EndInit();
      this.GroupBox1.ResumeLayout(false);
      this.GroupBox1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    [field: AccessedThroughProperty("cmdClose")]
    internal virtual Button cmdClose { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label1")]
    internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("lblCopy")]
    internal virtual Label lblCopy { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button cmdCopy
    {
      get => this._cmdCopy;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdCopy_Click);
        Button cmdCopy1 = this._cmdCopy;
        if (cmdCopy1 != null)
          cmdCopy1.Click -= eventHandler;
        this._cmdCopy = value;
        Button cmdCopy2 = this._cmdCopy;
        if (cmdCopy2 == null)
          return;
        cmdCopy2.Click += eventHandler;
      }
    }

    internal virtual CheckBox chkIncludeOrientation
    {
      get => this._chkIncludeOrientation;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chkIncludeOrientation_CheckedChanged);
        CheckBox includeOrientation1 = this._chkIncludeOrientation;
        if (includeOrientation1 != null)
          includeOrientation1.CheckedChanged -= eventHandler;
        this._chkIncludeOrientation = value;
        CheckBox includeOrientation2 = this._chkIncludeOrientation;
        if (includeOrientation2 == null)
          return;
        includeOrientation2.CheckedChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("grpOrientation")]
    internal virtual GroupBox grpOrientation { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("PictureBox1")]
    internal virtual PictureBox PictureBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chkDoAll")]
    internal virtual CheckBox chkDoAll { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtNewOrientation")]
    internal virtual ComboBox txtNewOrientation { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label2")]
    internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label77")]
    internal virtual Label Label77 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox chkIncludeMirror
    {
      get => this._chkIncludeMirror;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chkIncludeMirror_CheckedChanged);
        CheckBox chkIncludeMirror1 = this._chkIncludeMirror;
        if (chkIncludeMirror1 != null)
          chkIncludeMirror1.CheckedChanged -= eventHandler;
        this._chkIncludeMirror = value;
        CheckBox chkIncludeMirror2 = this._chkIncludeMirror;
        if (chkIncludeMirror2 == null)
          return;
        chkIncludeMirror2.CheckedChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("GroupBox1")]
    internal virtual GroupBox GroupBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtMirrorLine")]
    internal virtual ComboBox txtMirrorLine { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label3")]
    internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button cmdBatchCopy
    {
      get => this._cmdBatchCopy;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdBatchCopy_Click);
        Button cmdBatchCopy1 = this._cmdBatchCopy;
        if (cmdBatchCopy1 != null)
          cmdBatchCopy1.Click -= eventHandler;
        this._cmdBatchCopy = value;
        Button cmdBatchCopy2 = this._cmdBatchCopy;
        if (cmdBatchCopy2 == null)
          return;
        cmdBatchCopy2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("txtOriginalOrientation")]
    internal virtual TextBox txtOriginalOrientation { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private void chkIncludeOrientation_CheckedChanged(object sender, EventArgs e)
    {
      if (!this.chkIncludeOrientation.Checked)
        return;
      this.chkIncludeMirror.Checked = false;
      if ((uint) Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Orientation, "Undefined", false) > 0U & (uint) Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Orientation, "", false) > 0U)
      {
        this.grpOrientation.Enabled = this.chkIncludeOrientation.Checked;
        this.txtOriginalOrientation.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Orientation;
      }
      else
      {
        int num = (int) Interaction.MsgBox((object) "The source dwelling has an undefined orientation!", MsgBoxStyle.Information, (object) "Copy");
        this.chkIncludeOrientation.Checked = false;
      }
    }

    private void cmdCopy_Click(object sender, EventArgs e)
    {
      try
      {
        if (this.chkIncludeOrientation.Checked)
        {
          if (Operators.CompareString(this.txtOriginalOrientation.Text, "Unspecified", false) == 0 | Operators.CompareString(this.txtOriginalOrientation.Text, "", false) == 0)
          {
            int num = (int) Interaction.MsgBox((object) "Please Select  Orientation First!", MsgBoxStyle.Information, (object) "Copy");
            return;
          }
          if (Operators.CompareString(this.txtNewOrientation.Text, "", false) == 0)
          {
            int num = (int) Interaction.MsgBox((object) "Please Select New Orientation First!", MsgBoxStyle.Information, (object) "Copy");
            return;
          }
          if (Operators.CompareString(this.txtNewOrientation.Text, SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Orientation, false) == 0)
          {
            int num = (int) Interaction.MsgBox((object) "Both the original and new orientation as the same!", MsgBoxStyle.Information, (object) "Copy");
            return;
          }
        }
        if (Interaction.MsgBox((object) ("Copy dwelling " + SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Reference + "?"), MsgBoxStyle.YesNo | MsgBoxStyle.Question, (object) "Copy") == MsgBoxResult.Yes)
        {
          Application.DoEvents();
          // ISSUE: variable of a reference type
          int& local1;
          // ISSUE: explicit reference operation
          int num1 = checked (^(local1 = ref SAP_Module.Proj.NoOfDwells) + 1);
          local1 = num1;
          // ISSUE: variable of a reference type
          SAP_Module.Dwelling[]& local2;
          // ISSUE: explicit reference operation
          SAP_Module.Dwelling[] dwellingArray = (SAP_Module.Dwelling[]) Utils.CopyArray((Array) ^(local2 = ref SAP_Module.Proj.Dwellings), (Array) new SAP_Module.Dwelling[checked (SAP_Module.Proj.NoOfDwells - 1 + 1)]);
          local2 = dwellingArray;
          int currDwelling = SAP_Module.CurrDwelling;
          MyProject.Forms.SAPForm.TreeSAP.SelectedNode = MyProject.Forms.SAPForm.TreeSAP.Nodes[0];
          SAP_Module.Proj.Dwellings[checked (SAP_Module.Proj.NoOfDwells - 1)] = Functions.CopyDwelling(SAP_Module.Proj.Dwellings[currDwelling]);
          SAP_Module.CurrDwelling = checked (SAP_Module.Proj.NoOfDwells - 1);
          SAP_Module.Proj.Dwellings[checked (SAP_Module.Proj.NoOfDwells - 1)].Name = "House " + Conversions.ToString(SAP_Module.Proj.NoOfDwells);
          SAP_Module.Proj.Dwellings[checked (SAP_Module.Proj.NoOfDwells - 1)].YearBuilt = DateAndTime.Now.Year;
          try
          {
            SAP_Module.Proj.Dwellings[checked (SAP_Module.Proj.NoOfDwells - 1)].Lodgement = (SAP_Module.Lodgement[]) null;
            SAP_Module.Proj.Dwellings[checked (SAP_Module.Proj.NoOfDwells - 1)].LodgementAttempts = 0;
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
          Functions.MakeTree();
          MyProject.Forms.SAPForm.TreeSAP.SelectedNode = MyProject.Forms.SAPForm.TreeSAP.Nodes[0].Nodes[SAP_Module.CurrDwelling];
          if (this.chkIncludeOrientation.Checked)
          {
            int orientationChange = this.GetOrientationChange();
            int num2 = checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofDoors - 1);
            int index1 = 0;
            while (index1 <= num2)
            {
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors[index1].Orientation = this.ChangeOrientation(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors[index1].Orientation, orientationChange);
              checked { ++index1; }
            }
            int num3 = checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofWindows - 1);
            int index2 = 0;
            while (index2 <= num3)
            {
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows[index2].Orientation = this.ChangeOrientation(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows[index2].Orientation, orientationChange);
              checked { ++index2; }
            }
            int num4 = checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofRoofLights - 1);
            int index3 = 0;
            while (index3 <= num4)
            {
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[index3].Orientation = this.ChangeOrientation(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[index3].Orientation, orientationChange);
              checked { ++index3; }
            }
            try
            {
              if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Photovoltaic.Inlcude)
              {
                int num5 = checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Photovoltaic.Photovoltaics.Length - 1);
                int index4 = 0;
                while (index4 <= num5)
                {
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Photovoltaic.Photovoltaics[index4].PCOrientation = this.ChangeOrientation(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Photovoltaic.Photovoltaics[index4].PCOrientation, orientationChange);
                  checked { ++index4; }
                }
              }
            }
            catch (Exception ex)
            {
              ProjectData.SetProjectError(ex);
              ProjectData.ClearProjectError();
            }
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Orientation = this.ChangeOrientation(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Orientation, orientationChange);
            SAP_Read.ReadDwellingDetails();
          }
          if (this.chkIncludeMirror.Checked)
          {
            int num6 = checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofDoors - 1);
            int index5 = 0;
            while (index5 <= num6)
            {
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors[index5].Orientation = this.MirrorOrientation((object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors[index5].Orientation);
              checked { ++index5; }
            }
            int num7 = checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofWindows - 1);
            int index6 = 0;
            while (index6 <= num7)
            {
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows[index6].Orientation = this.MirrorOrientation((object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows[index6].Orientation);
              checked { ++index6; }
            }
            int num8 = checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofRoofLights - 1);
            int index7 = 0;
            while (index7 <= num8)
            {
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[index7].Orientation = this.MirrorOrientation((object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[index7].Orientation);
              checked { ++index7; }
            }
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Orientation = this.MirrorOrientation((object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Orientation);
            SAP_Read.ReadDwellingDetails();
          }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    public string MirrorOrientation(object Orientation)
    {
      string text = this.txtMirrorLine.Text;
      string str;
      if (Operators.CompareString(text, "North-South", false) != 0)
      {
        if (Operators.CompareString(text, "NorthWest-SouthEast", false) != 0)
        {
          if (Operators.CompareString(text, "East-West", false) != 0)
          {
            if (Operators.CompareString(text, "SouthWest-NorthEast", false) == 0)
            {
              object Left = Orientation;
              if (Operators.ConditionalCompareObjectEqual(Left, (object) "North", false))
              {
                str = "East";
                goto label_69;
              }
              else if (Operators.ConditionalCompareObjectEqual(Left, (object) "North East", false))
              {
                str = "North East";
                goto label_69;
              }
              else if (Operators.ConditionalCompareObjectEqual(Left, (object) "East", false))
              {
                str = "North";
                goto label_69;
              }
              else if (Operators.ConditionalCompareObjectEqual(Left, (object) "South East", false))
              {
                str = "North West";
                goto label_69;
              }
              else if (Operators.ConditionalCompareObjectEqual(Left, (object) "South", false))
              {
                str = "West";
                goto label_69;
              }
              else if (Operators.ConditionalCompareObjectEqual(Left, (object) "South West", false))
              {
                str = "South West";
                goto label_69;
              }
              else if (Operators.ConditionalCompareObjectEqual(Left, (object) "West", false))
              {
                str = "South";
                goto label_69;
              }
              else if (Operators.ConditionalCompareObjectEqual(Left, (object) "North West", false))
              {
                str = "South East";
                goto label_69;
              }
            }
          }
          else
          {
            object Left = Orientation;
            if (Operators.ConditionalCompareObjectEqual(Left, (object) "North", false))
            {
              str = "South";
              goto label_69;
            }
            else if (Operators.ConditionalCompareObjectEqual(Left, (object) "North East", false))
            {
              str = "South East";
              goto label_69;
            }
            else if (Operators.ConditionalCompareObjectEqual(Left, (object) "East", false))
            {
              str = "East";
              goto label_69;
            }
            else if (Operators.ConditionalCompareObjectEqual(Left, (object) "South East", false))
            {
              str = "North East";
              goto label_69;
            }
            else if (Operators.ConditionalCompareObjectEqual(Left, (object) "South", false))
            {
              str = "North";
              goto label_69;
            }
            else if (Operators.ConditionalCompareObjectEqual(Left, (object) "South West", false))
            {
              str = "North West";
              goto label_69;
            }
            else if (Operators.ConditionalCompareObjectEqual(Left, (object) "West", false))
            {
              str = "West";
              goto label_69;
            }
            else if (Operators.ConditionalCompareObjectEqual(Left, (object) "North West", false))
            {
              str = "South West";
              goto label_69;
            }
          }
        }
        else
        {
          object Left = Orientation;
          if (Operators.ConditionalCompareObjectEqual(Left, (object) "North", false))
          {
            str = "West";
            goto label_69;
          }
          else if (Operators.ConditionalCompareObjectEqual(Left, (object) "North East", false))
          {
            str = "South West";
            goto label_69;
          }
          else if (Operators.ConditionalCompareObjectEqual(Left, (object) "East", false))
          {
            str = "South";
            goto label_69;
          }
          else if (Operators.ConditionalCompareObjectEqual(Left, (object) "South East", false))
          {
            str = "South East";
            goto label_69;
          }
          else if (Operators.ConditionalCompareObjectEqual(Left, (object) "South", false))
          {
            str = "East";
            goto label_69;
          }
          else if (Operators.ConditionalCompareObjectEqual(Left, (object) "South West", false))
          {
            str = "North East";
            goto label_69;
          }
          else if (Operators.ConditionalCompareObjectEqual(Left, (object) "West", false))
          {
            str = "North";
            goto label_69;
          }
          else if (Operators.ConditionalCompareObjectEqual(Left, (object) "North West", false))
          {
            str = "North West";
            goto label_69;
          }
        }
      }
      else
      {
        object Left = Orientation;
        if (Operators.ConditionalCompareObjectEqual(Left, (object) "North", false))
        {
          str = "North";
          goto label_69;
        }
        else if (Operators.ConditionalCompareObjectEqual(Left, (object) "North East", false))
        {
          str = "North West";
          goto label_69;
        }
        else if (Operators.ConditionalCompareObjectEqual(Left, (object) "East", false))
        {
          str = "West";
          goto label_69;
        }
        else if (Operators.ConditionalCompareObjectEqual(Left, (object) "South East", false))
        {
          str = "South West";
          goto label_69;
        }
        else if (Operators.ConditionalCompareObjectEqual(Left, (object) "South", false))
        {
          str = "South";
          goto label_69;
        }
        else if (Operators.ConditionalCompareObjectEqual(Left, (object) "South West", false))
        {
          str = "South East";
          goto label_69;
        }
        else if (Operators.ConditionalCompareObjectEqual(Left, (object) "West", false))
        {
          str = "East";
          goto label_69;
        }
        else if (Operators.ConditionalCompareObjectEqual(Left, (object) "North West", false))
        {
          str = "North East";
          goto label_69;
        }
      }
label_69:
      return str;
    }

    private string ChangeOrientation(string Orientation, int Change)
    {
      string str1 = Orientation;
      string str2;
      // ISSUE: reference to a compiler-generated method
      switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(str1))
      {
        case 1128440633:
          if (Operators.CompareString(str1, "North East", false) == 0)
          {
            switch (Change)
            {
              case 0:
                str2 = "North East";
                break;
              case 1:
                str2 = "East";
                break;
              case 2:
                str2 = "South East";
                break;
              case 3:
                str2 = "South";
                break;
              case 4:
                str2 = "South West";
                break;
              case 5:
                str2 = "West";
                break;
              case 6:
                str2 = "North West";
                break;
              case 7:
                str2 = "North";
                break;
              default:
                goto label_83;
            }
          }
          else
            goto default;
          break;
        case 1409318971:
          if (Operators.CompareString(str1, "North West", false) == 0)
          {
            switch (Change)
            {
              case 0:
                str2 = "North West";
                break;
              case 1:
                str2 = "North";
                break;
              case 2:
                str2 = "North East";
                break;
              case 3:
                str2 = "East";
                break;
              case 4:
                str2 = "South East";
                break;
              case 5:
                str2 = "South";
                break;
              case 6:
                str2 = "South West";
                break;
              case 7:
                str2 = "West";
                break;
              default:
                goto label_83;
            }
          }
          else
            goto default;
          break;
        case 1731397980:
          if (Operators.CompareString(str1, "East", false) == 0)
          {
            switch (Change)
            {
              case 0:
                str2 = "East";
                break;
              case 1:
                str2 = "South East";
                break;
              case 2:
                str2 = "South";
                break;
              case 3:
                str2 = "South West";
                break;
              case 4:
                str2 = "West";
                break;
              case 5:
                str2 = "North West";
                break;
              case 6:
                str2 = "North";
                break;
              case 7:
                str2 = "North East";
                break;
              default:
                goto label_83;
            }
          }
          else
            goto default;
          break;
        case 1734234020:
          if (Operators.CompareString(str1, "North", false) == 0)
          {
            switch (Change)
            {
              case 0:
                str2 = "North";
                break;
              case 1:
                str2 = "North East";
                break;
              case 2:
                str2 = "East";
                break;
              case 3:
                str2 = "South East";
                break;
              case 4:
                str2 = "South";
                break;
              case 5:
                str2 = "South West";
                break;
              case 6:
                str2 = "West";
                break;
              case 7:
                str2 = "North West";
                break;
              default:
                goto label_83;
            }
          }
          else
            goto default;
          break;
        case 1796576718:
          if (Operators.CompareString(str1, "West", false) == 0)
          {
            switch (Change)
            {
              case 0:
                str2 = "West";
                break;
              case 1:
                str2 = "North West";
                break;
              case 2:
                str2 = "North";
                break;
              case 3:
                str2 = "North East";
                break;
              case 4:
                str2 = "East";
                break;
              case 5:
                str2 = "South East";
                break;
              case 6:
                str2 = "South";
                break;
              case 7:
                str2 = "South West";
                break;
              default:
                goto label_83;
            }
          }
          else
            goto default;
          break;
        case 1811125385:
          if (Operators.CompareString(str1, "Horizontal", false) == 0)
          {
            str2 = "Horizontal";
            break;
          }
          goto default;
        case 2417407149:
          if (Operators.CompareString(str1, "South West", false) == 0)
          {
            switch (Change)
            {
              case 0:
                str2 = "South West";
                break;
              case 1:
                str2 = "West";
                break;
              case 2:
                str2 = "North West";
                break;
              case 3:
                str2 = "North";
                break;
              case 4:
                str2 = "North East";
                break;
              case 5:
                str2 = "East";
                break;
              case 6:
                str2 = "South East";
                break;
              case 7:
                str2 = "South";
                break;
              default:
                goto label_83;
            }
          }
          else
            goto default;
          break;
        case 2853841879:
          if (Operators.CompareString(str1, "South East", false) == 0)
          {
            switch (Change)
            {
              case 0:
                str2 = "South East";
                break;
              case 1:
                str2 = "South";
                break;
              case 2:
                str2 = "South West";
                break;
              case 3:
                str2 = "West";
                break;
              case 4:
                str2 = "North West";
                break;
              case 5:
                str2 = "North";
                break;
              case 6:
                str2 = "North East";
                break;
              case 7:
                str2 = "East";
                break;
              default:
                goto label_83;
            }
          }
          else
            goto default;
          break;
        case 3017973530:
          if (Operators.CompareString(str1, "South", false) == 0)
          {
            switch (Change)
            {
              case 0:
                str2 = "South";
                break;
              case 1:
                str2 = "South West";
                break;
              case 2:
                str2 = "West";
                break;
              case 3:
                str2 = "North West";
                break;
              case 4:
                str2 = "North";
                break;
              case 5:
                str2 = "North East";
                break;
              case 6:
                str2 = "East";
                break;
              case 7:
                str2 = "South East";
                break;
              default:
                goto label_83;
            }
          }
          else
            goto default;
          break;
        default:
label_83:
          break;
      }
      return str2;
    }

    private int GetOrientationChange()
    {
      string orientation = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Orientation;
      int orientationChange;
      // ISSUE: reference to a compiler-generated method
      switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(orientation))
      {
        case 1128440633:
          if (Operators.CompareString(orientation, "North East", false) == 0)
          {
            string text = this.txtNewOrientation.Text;
            // ISSUE: reference to a compiler-generated method
            switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(text))
            {
              case 1128440633:
                if (Operators.CompareString(text, "North East", false) == 0)
                  goto label_137;
                else
                  goto label_137;
              case 1409318971:
                if (Operators.CompareString(text, "North West", false) == 0)
                {
                  orientationChange = 6;
                  break;
                }
                goto label_137;
              case 1731397980:
                if (Operators.CompareString(text, "East", false) == 0)
                {
                  orientationChange = 1;
                  break;
                }
                goto label_137;
              case 1734234020:
                if (Operators.CompareString(text, "North", false) == 0)
                {
                  orientationChange = 7;
                  break;
                }
                goto label_137;
              case 1796576718:
                if (Operators.CompareString(text, "West", false) == 0)
                {
                  orientationChange = 5;
                  break;
                }
                goto label_137;
              case 2417407149:
                if (Operators.CompareString(text, "South West", false) == 0)
                {
                  orientationChange = 4;
                  break;
                }
                goto label_137;
              case 2853841879:
                if (Operators.CompareString(text, "South East", false) == 0)
                {
                  orientationChange = 2;
                  break;
                }
                goto label_137;
              case 3017973530:
                if (Operators.CompareString(text, "South", false) == 0)
                {
                  orientationChange = 3;
                  break;
                }
                goto label_137;
              default:
                goto label_137;
            }
          }
          else
            goto default;
          break;
        case 1409318971:
          if (Operators.CompareString(orientation, "North West", false) == 0)
          {
            string text = this.txtNewOrientation.Text;
            // ISSUE: reference to a compiler-generated method
            switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(text))
            {
              case 1128440633:
                if (Operators.CompareString(text, "North East", false) == 0)
                {
                  orientationChange = 2;
                  break;
                }
                goto label_137;
              case 1409318971:
                if (Operators.CompareString(text, "North West", false) == 0)
                  goto label_137;
                else
                  goto label_137;
              case 1731397980:
                if (Operators.CompareString(text, "East", false) == 0)
                {
                  orientationChange = 3;
                  break;
                }
                goto label_137;
              case 1734234020:
                if (Operators.CompareString(text, "North", false) == 0)
                {
                  orientationChange = 1;
                  break;
                }
                goto label_137;
              case 1796576718:
                if (Operators.CompareString(text, "West", false) == 0)
                {
                  orientationChange = 7;
                  break;
                }
                goto label_137;
              case 2417407149:
                if (Operators.CompareString(text, "South West", false) == 0)
                {
                  orientationChange = 6;
                  break;
                }
                goto label_137;
              case 2853841879:
                if (Operators.CompareString(text, "South East", false) == 0)
                {
                  orientationChange = 4;
                  break;
                }
                goto label_137;
              case 3017973530:
                if (Operators.CompareString(text, "South", false) == 0)
                {
                  orientationChange = 5;
                  break;
                }
                goto label_137;
              default:
                goto label_137;
            }
          }
          else
            goto default;
          break;
        case 1731397980:
          if (Operators.CompareString(orientation, "East", false) == 0)
          {
            string text = this.txtNewOrientation.Text;
            // ISSUE: reference to a compiler-generated method
            switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(text))
            {
              case 1128440633:
                if (Operators.CompareString(text, "North East", false) == 0)
                {
                  orientationChange = 7;
                  break;
                }
                goto label_137;
              case 1409318971:
                if (Operators.CompareString(text, "North West", false) == 0)
                {
                  orientationChange = 5;
                  break;
                }
                goto label_137;
              case 1731397980:
                if (Operators.CompareString(text, "East", false) == 0)
                  goto label_137;
                else
                  goto label_137;
              case 1734234020:
                if (Operators.CompareString(text, "North", false) == 0)
                {
                  orientationChange = 6;
                  break;
                }
                goto label_137;
              case 1796576718:
                if (Operators.CompareString(text, "West", false) == 0)
                {
                  orientationChange = 4;
                  break;
                }
                goto label_137;
              case 2417407149:
                if (Operators.CompareString(text, "South West", false) == 0)
                {
                  orientationChange = 3;
                  break;
                }
                goto label_137;
              case 2853841879:
                if (Operators.CompareString(text, "South East", false) == 0)
                {
                  orientationChange = 1;
                  break;
                }
                goto label_137;
              case 3017973530:
                if (Operators.CompareString(text, "South", false) == 0)
                {
                  orientationChange = 2;
                  break;
                }
                goto label_137;
              default:
                goto label_137;
            }
          }
          else
            goto default;
          break;
        case 1734234020:
          if (Operators.CompareString(orientation, "North", false) == 0)
          {
            string text = this.txtNewOrientation.Text;
            // ISSUE: reference to a compiler-generated method
            switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(text))
            {
              case 1128440633:
                if (Operators.CompareString(text, "North East", false) == 0)
                {
                  orientationChange = 1;
                  break;
                }
                goto label_137;
              case 1409318971:
                if (Operators.CompareString(text, "North West", false) == 0)
                {
                  orientationChange = 7;
                  break;
                }
                goto label_137;
              case 1731397980:
                if (Operators.CompareString(text, "East", false) == 0)
                {
                  orientationChange = 2;
                  break;
                }
                goto label_137;
              case 1734234020:
                if (Operators.CompareString(text, "North", false) == 0)
                  goto label_137;
                else
                  goto label_137;
              case 1796576718:
                if (Operators.CompareString(text, "West", false) == 0)
                {
                  orientationChange = 6;
                  break;
                }
                goto label_137;
              case 2417407149:
                if (Operators.CompareString(text, "South West", false) == 0)
                {
                  orientationChange = 5;
                  break;
                }
                goto label_137;
              case 2853841879:
                if (Operators.CompareString(text, "South East", false) == 0)
                {
                  orientationChange = 3;
                  break;
                }
                goto label_137;
              case 3017973530:
                if (Operators.CompareString(text, "South", false) == 0)
                {
                  orientationChange = 4;
                  break;
                }
                goto label_137;
              default:
                goto label_137;
            }
          }
          else
            goto default;
          break;
        case 1796576718:
          if (Operators.CompareString(orientation, "West", false) == 0)
          {
            string text = this.txtNewOrientation.Text;
            // ISSUE: reference to a compiler-generated method
            switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(text))
            {
              case 1128440633:
                if (Operators.CompareString(text, "North East", false) == 0)
                {
                  orientationChange = 3;
                  break;
                }
                goto label_137;
              case 1409318971:
                if (Operators.CompareString(text, "North West", false) == 0)
                {
                  orientationChange = 1;
                  break;
                }
                goto label_137;
              case 1731397980:
                if (Operators.CompareString(text, "East", false) == 0)
                {
                  orientationChange = 4;
                  break;
                }
                goto label_137;
              case 1734234020:
                if (Operators.CompareString(text, "North", false) == 0)
                {
                  orientationChange = 2;
                  break;
                }
                goto label_137;
              case 1796576718:
                if (Operators.CompareString(text, "West", false) == 0)
                  goto label_137;
                else
                  goto label_137;
              case 2417407149:
                if (Operators.CompareString(text, "South West", false) == 0)
                {
                  orientationChange = 7;
                  break;
                }
                goto label_137;
              case 2853841879:
                if (Operators.CompareString(text, "South East", false) == 0)
                {
                  orientationChange = 5;
                  break;
                }
                goto label_137;
              case 3017973530:
                if (Operators.CompareString(text, "South", false) == 0)
                {
                  orientationChange = 6;
                  break;
                }
                goto label_137;
              default:
                goto label_137;
            }
          }
          else
            goto default;
          break;
        case 2417407149:
          if (Operators.CompareString(orientation, "South West", false) == 0)
          {
            string text = this.txtNewOrientation.Text;
            // ISSUE: reference to a compiler-generated method
            switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(text))
            {
              case 1128440633:
                if (Operators.CompareString(text, "North East", false) == 0)
                {
                  orientationChange = 4;
                  break;
                }
                goto label_137;
              case 1409318971:
                if (Operators.CompareString(text, "North West", false) == 0)
                {
                  orientationChange = 2;
                  break;
                }
                goto label_137;
              case 1731397980:
                if (Operators.CompareString(text, "East", false) == 0)
                {
                  orientationChange = 5;
                  break;
                }
                goto label_137;
              case 1734234020:
                if (Operators.CompareString(text, "North", false) == 0)
                {
                  orientationChange = 3;
                  break;
                }
                goto label_137;
              case 1796576718:
                if (Operators.CompareString(text, "West", false) == 0)
                {
                  orientationChange = 1;
                  break;
                }
                goto label_137;
              case 2417407149:
                if (Operators.CompareString(text, "South West", false) == 0)
                  goto label_137;
                else
                  goto label_137;
              case 2853841879:
                if (Operators.CompareString(text, "South East", false) == 0)
                {
                  orientationChange = 6;
                  break;
                }
                goto label_137;
              case 3017973530:
                if (Operators.CompareString(text, "South", false) == 0)
                {
                  orientationChange = 7;
                  break;
                }
                goto label_137;
              default:
                goto label_137;
            }
          }
          else
            goto default;
          break;
        case 2853841879:
          if (Operators.CompareString(orientation, "South East", false) == 0)
          {
            string text = this.txtNewOrientation.Text;
            // ISSUE: reference to a compiler-generated method
            switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(text))
            {
              case 1128440633:
                if (Operators.CompareString(text, "North East", false) == 0)
                {
                  orientationChange = 6;
                  break;
                }
                goto label_137;
              case 1409318971:
                if (Operators.CompareString(text, "North West", false) == 0)
                {
                  orientationChange = 4;
                  break;
                }
                goto label_137;
              case 1731397980:
                if (Operators.CompareString(text, "East", false) == 0)
                {
                  orientationChange = 7;
                  break;
                }
                goto label_137;
              case 1734234020:
                if (Operators.CompareString(text, "North", false) == 0)
                {
                  orientationChange = 5;
                  break;
                }
                goto label_137;
              case 1796576718:
                if (Operators.CompareString(text, "West", false) == 0)
                {
                  orientationChange = 3;
                  break;
                }
                goto label_137;
              case 2417407149:
                if (Operators.CompareString(text, "South West", false) == 0)
                {
                  orientationChange = 2;
                  break;
                }
                goto label_137;
              case 2853841879:
                if (Operators.CompareString(text, "South East", false) == 0)
                  goto label_137;
                else
                  goto label_137;
              case 3017973530:
                if (Operators.CompareString(text, "South", false) == 0)
                {
                  orientationChange = 1;
                  break;
                }
                goto label_137;
              default:
                goto label_137;
            }
          }
          else
            goto default;
          break;
        case 3017973530:
          if (Operators.CompareString(orientation, "South", false) == 0)
          {
            string text = this.txtNewOrientation.Text;
            // ISSUE: reference to a compiler-generated method
            switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(text))
            {
              case 1128440633:
                if (Operators.CompareString(text, "North East", false) == 0)
                {
                  orientationChange = 5;
                  break;
                }
                goto label_137;
              case 1409318971:
                if (Operators.CompareString(text, "North West", false) == 0)
                {
                  orientationChange = 3;
                  break;
                }
                goto label_137;
              case 1731397980:
                if (Operators.CompareString(text, "East", false) == 0)
                {
                  orientationChange = 6;
                  break;
                }
                goto label_137;
              case 1734234020:
                if (Operators.CompareString(text, "North", false) == 0)
                {
                  orientationChange = 4;
                  break;
                }
                goto label_137;
              case 1796576718:
                if (Operators.CompareString(text, "West", false) == 0)
                {
                  orientationChange = 2;
                  break;
                }
                goto label_137;
              case 2417407149:
                if (Operators.CompareString(text, "South West", false) == 0)
                {
                  orientationChange = 1;
                  break;
                }
                goto label_137;
              case 2853841879:
                if (Operators.CompareString(text, "South East", false) == 0)
                {
                  orientationChange = 7;
                  break;
                }
                goto label_137;
              case 3017973530:
                if (Operators.CompareString(text, "South", false) == 0)
                  goto label_137;
                else
                  goto label_137;
              default:
                goto label_137;
            }
          }
          else
            goto default;
          break;
        default:
label_137:
          break;
      }
      return orientationChange;
    }

    private void chkIncludeMirror_CheckedChanged(object sender, EventArgs e)
    {
      if (this.chkIncludeMirror.Checked)
      {
        this.chkIncludeOrientation.Checked = false;
        this.GroupBox1.Enabled = true;
      }
      else
        this.GroupBox1.Enabled = false;
    }

    private void cmdBatchCopy_Click(object sender, EventArgs e)
    {
      int num = (int) new Copy_Multiple().ShowDialog();
    }
  }
}
