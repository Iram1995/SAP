
// Type: SAP2012.Version




using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SAP2012
{
  [DesignerGenerated]
  public class Version : Form
  {
    private IContainer components;

    public Version()
    {
      this.Load += new EventHandler(this.Version_Load);
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
      this.rb1 = new RadioButton();
      this.cmdOK = new Button();
      this.cmdCancel = new Button();
      this.rb5 = new RadioButton();
      this.rb6 = new RadioButton();
      this.rb7 = new RadioButton();
      this.rb8 = new RadioButton();
      this.SuspendLayout();
      this.rb1.AutoSize = true;
      this.rb1.Checked = true;
      this.rb1.Cursor = Cursors.Hand;
      this.rb1.Location = new Point(13, 13);
      this.rb1.Name = "rb1";
      this.rb1.Size = new Size(51, 17);
      this.rb1.TabIndex = 0;
      this.rb1.TabStop = true;
      this.rb1.Text = "None";
      this.rb1.UseVisualStyleBackColor = true;
      this.cmdOK.BackColor = Color.LightSlateGray;
      this.cmdOK.Cursor = Cursors.Hand;
      this.cmdOK.DialogResult = DialogResult.OK;
      this.cmdOK.FlatStyle = FlatStyle.Popup;
      this.cmdOK.ForeColor = Color.White;
      this.cmdOK.Location = new Point(258, 256);
      this.cmdOK.Name = "cmdOK";
      this.cmdOK.Size = new Size(78, 23);
      this.cmdOK.TabIndex = 17;
      this.cmdOK.Text = "OK";
      this.cmdOK.UseVisualStyleBackColor = false;
      this.cmdCancel.BackColor = Color.LightSlateGray;
      this.cmdCancel.Cursor = Cursors.Hand;
      this.cmdCancel.DialogResult = DialogResult.Cancel;
      this.cmdCancel.FlatStyle = FlatStyle.Popup;
      this.cmdCancel.ForeColor = Color.White;
      this.cmdCancel.Location = new Point(174, 256);
      this.cmdCancel.Name = "cmdCancel";
      this.cmdCancel.Size = new Size(78, 23);
      this.cmdCancel.TabIndex = 18;
      this.cmdCancel.Text = "Cancel";
      this.cmdCancel.UseVisualStyleBackColor = false;
      this.rb5.AutoSize = true;
      this.rb5.Cursor = Cursors.Hand;
      this.rb5.Location = new Point(13, 36);
      this.rb5.Name = "rb5";
      this.rb5.Size = new Size(155, 17);
      this.rb5.TabIndex = 21;
      this.rb5.Tag = (object) "1.0.2.0";
      this.rb5.Text = "Change to 1.0.1.4 or before";
      this.rb5.UseVisualStyleBackColor = true;
      this.rb6.AutoSize = true;
      this.rb6.Cursor = Cursors.Hand;
      this.rb6.Location = new Point(12, 59);
      this.rb6.Name = "rb6";
      this.rb6.Size = new Size(161, 17);
      this.rb6.TabIndex = 22;
      this.rb6.Tag = (object) "1.0.1.25";
      this.rb6.Text = "Change to 1.0.1.25 or before";
      this.rb6.UseVisualStyleBackColor = true;
      this.rb7.AutoSize = true;
      this.rb7.Cursor = Cursors.Hand;
      this.rb7.Location = new Point(13, 82);
      this.rb7.Name = "rb7";
      this.rb7.Size = new Size(155, 17);
      this.rb7.TabIndex = 23;
      this.rb7.Tag = (object) "1.0.4.0";
      this.rb7.Text = "Change to 1.0.4.0 or before";
      this.rb7.UseVisualStyleBackColor = true;
      this.rb8.AutoSize = true;
      this.rb8.Cursor = Cursors.Hand;
      this.rb8.Location = new Point(12, 105);
      this.rb8.Name = "rb8";
      this.rb8.Size = new Size(161, 17);
      this.rb8.TabIndex = 24;
      this.rb8.Tag = (object) "1.0.4.0";
      this.rb8.Text = "Change to 1.0.4.14 or before";
      this.rb8.UseVisualStyleBackColor = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.White;
      this.ClientSize = new Size(347, 291);
      this.Controls.Add((Control) this.rb8);
      this.Controls.Add((Control) this.rb7);
      this.Controls.Add((Control) this.rb6);
      this.Controls.Add((Control) this.rb5);
      this.Controls.Add((Control) this.cmdCancel);
      this.Controls.Add((Control) this.cmdOK);
      this.Controls.Add((Control) this.rb1);
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.Name = nameof (Version);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Calculation Version Selection";
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    [field: AccessedThroughProperty("rb1")]
    internal virtual RadioButton rb1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

    [field: AccessedThroughProperty("cmdCancel")]
    internal virtual Button cmdCancel { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("rb5")]
    internal virtual RadioButton rb5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("rb6")]
    internal virtual RadioButton rb6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("rb7")]
    internal virtual RadioButton rb7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("rb8")]
    internal virtual RadioButton rb8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private void cmdOK_Click(object sender, EventArgs e)
    {
      SAP_Module.Proj.CalcVersion = "";
      if (this.rb5.Checked)
        SAP_Module.Proj.CalcVersion = Conversions.ToString(this.rb5.Tag);
      if (this.rb6.Checked)
        SAP_Module.Proj.CalcVersion = Conversions.ToString(this.rb6.Tag);
      if (this.rb7.Checked)
        SAP_Module.Proj.CalcVersion = Conversions.ToString(this.rb7.Tag);
      if (this.rb8.Checked)
        SAP_Module.Proj.CalcVersion = Conversions.ToString(this.rb8.Tag);
      if ((uint) Operators.CompareString(SAP_Module.Proj.CalcVersion, "", false) > 0U)
        SAP_Module.Proj.OverRide = true;
      else
        SAP_Module.Proj.OverRide = false;
    }

    private void Version_Load(object sender, EventArgs e)
    {
      if (Operators.CompareString(SAP_Module.CurrVersion, "Debug Mode", false) == 0 & string.IsNullOrEmpty(SAP_Module.Proj.Version))
        SAP_Module.Proj.Version = "";
      if (!string.IsNullOrEmpty(SAP_Module.Proj.Version))
      {
        this.rb6.Enabled = this.CheckVersion(Conversions.ToString(this.rb6.Tag), false);
        this.rb5.Enabled = this.CheckVersion(Conversions.ToString(this.rb5.Tag), false);
        this.rb7.Enabled = this.CheckVersion(Conversions.ToString(this.rb7.Tag), false);
        this.rb8.Enabled = this.CheckVersion(Conversions.ToString(this.rb8.Tag), false);
      }
      if (!SAP_Module.Proj.OverRide)
        return;
      if (Operators.ConditionalCompareObjectEqual(this.rb6.Tag, (object) SAP_Module.Proj.CalcVersion, false))
        this.rb6.Checked = true;
      if (Operators.ConditionalCompareObjectEqual(this.rb5.Tag, (object) SAP_Module.Proj.CalcVersion, false))
        this.rb5.Checked = true;
      if (Operators.ConditionalCompareObjectEqual(this.rb7.Tag, (object) SAP_Module.Proj.CalcVersion, false))
        this.rb7.Checked = true;
      if (Operators.ConditionalCompareObjectEqual(this.rb8.Tag, (object) SAP_Module.Proj.CalcVersion, false))
        this.rb8.Checked = true;
    }

    private bool CheckVersion(string VersionMax, bool DebugOveride)
    {
      bool flag;
      try
      {
        string[] strArray1 = new string[4];
        string[] strArray2 = new string[4];
        if (!string.IsNullOrEmpty(SAP_Module.Proj.Version))
        {
          string[] strArray3 = SAP_Module.Proj.Version.Split('.');
          string[] strArray4 = VersionMax.Split('.');
          flag = Conversion.Val(strArray3[0]) < Conversion.Val(strArray4[0]) || Conversion.Val(strArray3[0]) == Conversion.Val(strArray4[0]) && (Conversion.Val(strArray3[1]) < Conversion.Val(strArray4[1]) || Conversion.Val(strArray3[1]) == Conversion.Val(strArray4[1]) && (Conversion.Val(strArray3[2]) < Conversion.Val(strArray4[2]) || Conversion.Val(strArray3[2]) == Conversion.Val(strArray4[2]) && (Conversion.Val(strArray3[3]) < Conversion.Val(strArray4[3]) || Conversion.Val(strArray3[3]) == Conversion.Val(strArray4[3]))));
        }
        else
          flag = false;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      return flag;
    }
  }
}
