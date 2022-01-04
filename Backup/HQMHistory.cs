
// Type: SAP2012.HQMHistory




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
  public class HQMHistory : Form
  {
    private IContainer components;

    public HQMHistory() => this.InitializeComponent();

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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (HQMHistory));
      this.lblDetails = new Label();
      this.lblMethod = new Label();
      this.Label5 = new Label();
      this.Button2 = new Button();
      this.LodgeDate = new Label();
      this.Label4 = new Label();
      this.txtNotes = new TextBox();
      this.Label2 = new Label();
      this.RRN = new Label();
      this.Label1 = new Label();
      this.TreeImages = new ImageList(this.components);
      this.Panel1 = new Panel();
      this.TreeSAP = new TreeView();
      this.Panel1.SuspendLayout();
      this.SuspendLayout();
      this.lblDetails.BackColor = Color.Gray;
      this.lblDetails.Font = new Font("Tahoma", 11f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblDetails.ForeColor = Color.White;
      this.lblDetails.Location = new Point(3, 0);
      this.lblDetails.Name = "lblDetails";
      this.lblDetails.Size = new Size(732, 63);
      this.lblDetails.TabIndex = 2;
      this.lblMethod.Location = new Point(635, 115);
      this.lblMethod.Name = "lblMethod";
      this.lblMethod.Size = new Size(91, 14);
      this.lblMethod.TabIndex = 28;
      this.lblMethod.TextAlign = ContentAlignment.MiddleLeft;
      this.Label5.AutoSize = true;
      this.Label5.Font = new Font("Tahoma", 9f, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, (byte) 0);
      this.Label5.Location = new Point(430, 113);
      this.Label5.Name = "Label5";
      this.Label5.Size = new Size(155, 14);
      this.Label5.TabIndex = 27;
      this.Label5.Text = "XML Download Method:";
      this.Button2.BackColor = Color.LightSlateGray;
      this.Button2.Cursor = Cursors.Hand;
      this.Button2.FlatStyle = FlatStyle.Popup;
      this.Button2.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button2.ForeColor = Color.White;
      this.Button2.Location = new Point(628, 387);
      this.Button2.Name = "Button2";
      this.Button2.Size = new Size(92, 25);
      this.Button2.TabIndex = 21;
      this.Button2.Text = "Close";
      this.Button2.UseVisualStyleBackColor = false;
      this.LodgeDate.AutoSize = true;
      this.LodgeDate.Location = new Point(131, 113);
      this.LodgeDate.Name = "LodgeDate";
      this.LodgeDate.Size = new Size(41, 16);
      this.LodgeDate.TabIndex = 26;
      this.LodgeDate.Text = "RRN:";
      this.Label4.AutoSize = true;
      this.Label4.Font = new Font("Tahoma", 9f, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, (byte) 0);
      this.Label4.Location = new Point(7, 113);
      this.Label4.Name = "Label4";
      this.Label4.Size = new Size(121, 14);
      this.Label4.TabIndex = 25;
      this.Label4.Text = "Downloaded Date:";
      this.txtNotes.Location = new Point(10, 169);
      this.txtNotes.Multiline = true;
      this.txtNotes.Name = "txtNotes";
      this.txtNotes.ScrollBars = ScrollBars.Both;
      this.txtNotes.Size = new Size(711, 212);
      this.txtNotes.TabIndex = 22;
      this.Label2.AutoSize = true;
      this.Label2.Font = new Font("Tahoma", 9f, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, (byte) 0);
      this.Label2.Location = new Point(6, 143);
      this.Label2.Name = "Label2";
      this.Label2.Size = new Size(50, 14);
      this.Label2.TabIndex = 3;
      this.Label2.Text = "Result:";
      this.RRN.AutoSize = true;
      this.RRN.Location = new Point(131, 89);
      this.RRN.Name = "RRN";
      this.RRN.Size = new Size(41, 16);
      this.RRN.TabIndex = 1;
      this.RRN.Text = "RRN:";
      this.Label1.AutoSize = true;
      this.Label1.Font = new Font("Tahoma", 9f, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, (byte) 0);
      this.Label1.Location = new Point(7, 89);
      this.Label1.Name = "Label1";
      this.Label1.Size = new Size(37, 14);
      this.Label1.TabIndex = 0;
      this.Label1.Text = "RRN:";
      this.TreeImages.ImageStream = (ImageListStreamer) componentResourceManager.GetObject("TreeImages.ImageStream");
      this.TreeImages.TransparentColor = Color.Transparent;
      this.TreeImages.Images.SetKeyName(0, "1.gif");
      this.TreeImages.Images.SetKeyName(1, "house.jpg");
      this.TreeImages.Images.SetKeyName(2, "accept.ico");
      this.TreeImages.Images.SetKeyName(3, "delete.ico");
      this.TreeImages.Images.SetKeyName(4, "next.ico");
      this.Panel1.Controls.Add((Control) this.lblDetails);
      this.Panel1.Controls.Add((Control) this.lblMethod);
      this.Panel1.Controls.Add((Control) this.Label5);
      this.Panel1.Controls.Add((Control) this.Button2);
      this.Panel1.Controls.Add((Control) this.LodgeDate);
      this.Panel1.Controls.Add((Control) this.Label4);
      this.Panel1.Controls.Add((Control) this.txtNotes);
      this.Panel1.Controls.Add((Control) this.Label2);
      this.Panel1.Controls.Add((Control) this.RRN);
      this.Panel1.Controls.Add((Control) this.Label1);
      this.Panel1.Dock = DockStyle.Fill;
      this.Panel1.Location = new Point(263, 0);
      this.Panel1.Name = "Panel1";
      this.Panel1.Size = new Size(738, 427);
      this.Panel1.TabIndex = 4;
      this.TreeSAP.Cursor = Cursors.Hand;
      this.TreeSAP.Dock = DockStyle.Left;
      this.TreeSAP.ImageIndex = 0;
      this.TreeSAP.ImageList = this.TreeImages;
      this.TreeSAP.Location = new Point(0, 0);
      this.TreeSAP.Name = "TreeSAP";
      this.TreeSAP.SelectedImageIndex = 0;
      this.TreeSAP.Size = new Size(263, 427);
      this.TreeSAP.TabIndex = 3;
      this.AutoScaleDimensions = new SizeF(8f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.White;
      this.ClientSize = new Size(1001, 427);
      this.Controls.Add((Control) this.Panel1);
      this.Controls.Add((Control) this.TreeSAP);
      this.Name = nameof (HQMHistory);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = nameof (HQMHistory);
      this.TopMost = true;
      this.Panel1.ResumeLayout(false);
      this.Panel1.PerformLayout();
      this.ResumeLayout(false);
    }

    [field: AccessedThroughProperty("lblDetails")]
    internal virtual Label lblDetails { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("lblMethod")]
    internal virtual Label lblMethod { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label5")]
    internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

    [field: AccessedThroughProperty("LodgeDate")]
    internal virtual Label LodgeDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label4")]
    internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtNotes")]
    internal virtual TextBox txtNotes { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label2")]
    internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("RRN")]
    internal virtual Label RRN { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label1")]
    internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("TreeImages")]
    internal virtual ImageList TreeImages { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Panel1")]
    internal virtual Panel Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TreeView TreeSAP
    {
      get => this._TreeSAP;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        TreeViewEventHandler viewEventHandler = new TreeViewEventHandler(this.TreeSAP_AfterSelect);
        TreeView treeSap1 = this._TreeSAP;
        if (treeSap1 != null)
          treeSap1.AfterSelect -= viewEventHandler;
        this._TreeSAP = value;
        TreeView treeSap2 = this._TreeSAP;
        if (treeSap2 == null)
          return;
        treeSap2.AfterSelect += viewEventHandler;
      }
    }

    private void Button2_Click(object sender, EventArgs e) => this.Close();

    public void FillHQMHistory()
    {
      this.TreeSAP.Nodes.Clear();
      this.TreeSAP.Nodes.Add("Project", SAP_Module.Proj.Name, 0, 4);
      int num1 = checked (SAP_Module.Proj.NoOfDwells - 1);
      int Number = 0;
      while (Number <= num1)
      {
        if (SAP_Module.Proj.Dwellings[Number].HQMLAttempts > 0)
        {
          this.TreeSAP.Nodes[0].Nodes.Add(Conversion.Str((object) Number), SAP_Module.Proj.Dwellings[Number].Name, 1, 4);
          int num2 = checked (SAP_Module.Proj.Dwellings[Number].HQMLAttempts - 1);
          int index1 = 0;
          int index2;
          while (index1 <= num2)
          {
            if (SAP_Module.Proj.Dwellings[Number].HQMLodgemnt[index1].Success)
              this.TreeSAP.Nodes[0].Nodes[index2].Nodes.Add(Conversion.Str((object) Number), SAP_Module.Proj.Dwellings[Number].HQMLodgemnt[index1].DateLodged.ToString(), 2, 4);
            else
              this.TreeSAP.Nodes[0].Nodes[index2].Nodes.Add(Conversion.Str((object) Number), SAP_Module.Proj.Dwellings[Number].HQMLodgemnt[index1].DateLodged.ToString(), 3, 4);
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        checked { ++Number; }
      }
      this.TreeSAP.Nodes[0].Expand();
    }

    private void TreeSAP_AfterSelect(object sender, TreeViewEventArgs e)
    {
      this.Panel1.Visible = false;
      int num;
      if (e.Node.Level == 1)
      {
        int index;
        if ((double) num != Conversion.Val(e.Node.Name))
          index = checked ((int) Math.Round(Conversion.Val(e.Node.Name)));
        this.lblDetails.Text = "Project: " + SAP_Module.Proj.Name + " -- Dwelling: " + SAP_Module.Proj.Dwellings[index].Name;
      }
      else if (e.Node.Level == 2)
      {
        int index;
        if ((double) num != Conversion.Val(e.Node.Name))
          index = checked ((int) Math.Round(Conversion.Val(e.Node.Name)));
        this.lblDetails.Text = "Project: " + SAP_Module.Proj.Name + " -- Dwelling: " + SAP_Module.Proj.Dwellings[index].Name + " -- Lodged: " + Conversions.ToString(SAP_Module.Proj.Dwellings[index].HQMLodgemnt[e.Node.Index].DateLodged);
        this.Panel1.Visible = true;
        this.LodgeDate.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[index].HQMLodgemnt[e.Node.Index].DateLodged);
        this.RRN.Text = SAP_Module.Proj.Dwellings[index].HQMLodgemnt[e.Node.Index].RRN;
        try
        {
          this.lblMethod.Text = "";
          this.lblMethod.Text = SAP_Module.Proj.Dwellings[index].HQMLodgemnt[e.Node.Index].Method == null ? "" : SAP_Module.Proj.Dwellings[index].HQMLodgemnt[e.Node.Index].Method;
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        this.txtNotes.Text = SAP_Module.Proj.Dwellings[index].HQMLodgemnt[e.Node.Index].Result;
      }
      else
        this.lblDetails.Text = "Project: " + SAP_Module.Proj.Name;
    }
  }
}
