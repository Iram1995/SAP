
// Type: SAP2012.Notes




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
  public class Notes : Form
  {
    private IContainer components;
    private int CurrentSelection;

    public Notes()
    {
      this.Load += new EventHandler(this.Notes_Load);
      this.CurrentSelection = -2;
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Notes));
      this.TreeSAP = new TreeView();
      this.TreeImages = new ImageList(this.components);
      this.txtNotes = new TextBox();
      this.Button2 = new Button();
      this.CmdNotes = new Button();
      this.SuspendLayout();
      this.TreeSAP.AllowDrop = true;
      this.TreeSAP.BackColor = Color.White;
      this.TreeSAP.Cursor = Cursors.Hand;
      this.TreeSAP.Font = new Font("Tahoma", 8.5f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.TreeSAP.ForeColor = Color.Black;
      this.TreeSAP.FullRowSelect = true;
      this.TreeSAP.ImageIndex = 0;
      this.TreeSAP.ImageList = this.TreeImages;
      this.TreeSAP.ImeMode = ImeMode.On;
      this.TreeSAP.Location = new Point(8, 8);
      this.TreeSAP.Name = "TreeSAP";
      this.TreeSAP.SelectedImageIndex = 0;
      this.TreeSAP.ShowRootLines = false;
      this.TreeSAP.Size = new Size(216, 466);
      this.TreeSAP.TabIndex = 2;
      this.TreeImages.ImageStream = (ImageListStreamer) componentResourceManager.GetObject("TreeImages.ImageStream");
      this.TreeImages.TransparentColor = Color.Transparent;
      this.TreeImages.Images.SetKeyName(0, "1.gif");
      this.TreeImages.Images.SetKeyName(1, "house.jpg");
      this.TreeImages.Images.SetKeyName(2, "accept.ico");
      this.TreeImages.Images.SetKeyName(3, "delete.ico");
      this.TreeImages.Images.SetKeyName(4, "next.ico");
      this.txtNotes.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtNotes.Location = new Point(230, 8);
      this.txtNotes.Multiline = true;
      this.txtNotes.Name = "txtNotes";
      this.txtNotes.ScrollBars = ScrollBars.Vertical;
      this.txtNotes.Size = new Size(510, 439);
      this.txtNotes.TabIndex = 3;
      this.Button2.BackColor = Color.LightSlateGray;
      this.Button2.Cursor = Cursors.Hand;
      this.Button2.DialogResult = DialogResult.OK;
      this.Button2.FlatStyle = FlatStyle.Popup;
      this.Button2.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button2.ForeColor = Color.White;
      this.Button2.Location = new Point(524, 453);
      this.Button2.Name = "Button2";
      this.Button2.Size = new Size(216, 29);
      this.Button2.TabIndex = 22;
      this.Button2.Text = "Close";
      this.Button2.UseVisualStyleBackColor = false;
      this.CmdNotes.BackColor = Color.LightSlateGray;
      this.CmdNotes.Cursor = Cursors.Hand;
      this.CmdNotes.DialogResult = DialogResult.OK;
      this.CmdNotes.FlatStyle = FlatStyle.Popup;
      this.CmdNotes.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.CmdNotes.ForeColor = Color.White;
      this.CmdNotes.Location = new Point(230, 453);
      this.CmdNotes.Name = "CmdNotes";
      this.CmdNotes.Size = new Size(216, 29);
      this.CmdNotes.TabIndex = 24;
      this.CmdNotes.Text = "Print Notes";
      this.CmdNotes.UseVisualStyleBackColor = false;
      this.AutoScaleDimensions = new SizeF(8f, 17f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.White;
      this.ClientSize = new Size(752, 487);
      this.Controls.Add((Control) this.CmdNotes);
      this.Controls.Add((Control) this.Button2);
      this.Controls.Add((Control) this.txtNotes);
      this.Controls.Add((Control) this.TreeSAP);
      this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.Name = nameof (Notes);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = nameof (Notes);
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    public virtual TreeView TreeSAP
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

    [field: AccessedThroughProperty("txtNotes")]
    internal virtual TextBox txtNotes { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("TreeImages")]
    internal virtual ImageList TreeImages { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

    internal virtual Button CmdNotes
    {
      get => this._CmdNotes;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CmdNotes_Click);
        Button cmdNotes1 = this._CmdNotes;
        if (cmdNotes1 != null)
          cmdNotes1.Click -= eventHandler;
        this._CmdNotes = value;
        Button cmdNotes2 = this._CmdNotes;
        if (cmdNotes2 == null)
          return;
        cmdNotes2.Click += eventHandler;
      }
    }

    private void Notes_Load(object sender, EventArgs e)
    {
      this.TreeSAP.Nodes.Clear();
      this.TreeSAP.Nodes.Add("Project", SAP_Module.Proj.Name, 0, 4);
      int num = checked (SAP_Module.Proj.NoOfDwells - 1);
      int Number = 0;
      while (Number <= num)
      {
        this.TreeSAP.Nodes[0].Nodes.Add(Conversion.Str((object) Number), SAP_Module.Proj.Dwellings[Number].Name, 1, 4);
        checked { ++Number; }
      }
      this.TreeSAP.Nodes[0].Expand();
      this.TreeSAP.SelectedNode = this.TreeSAP.Nodes[0];
    }

    private void TreeSAP_AfterSelect(object sender, TreeViewEventArgs e)
    {
      this.SaveNotes();
      if (e.Node.Level == 1)
      {
        this.CurrentSelection = e.Node.Index;
        if (string.IsNullOrEmpty(SAP_Module.Proj.Dwellings[e.Node.Index].Comments))
          SAP_Module.Proj.Dwellings[e.Node.Index].Comments = "";
        this.txtNotes.Text = SAP_Module.Proj.Dwellings[e.Node.Index].Comments;
      }
      else
      {
        this.CurrentSelection = -1;
        if (string.IsNullOrEmpty(SAP_Module.Proj.Comments))
          SAP_Module.Proj.Comments = "";
        this.txtNotes.Text = SAP_Module.Proj.Comments;
      }
    }

    private void SaveNotes()
    {
      switch (this.CurrentSelection)
      {
        case -2:
          break;
        case -1:
          SAP_Module.Proj.Comments = this.txtNotes.Text;
          break;
        default:
          SAP_Module.Proj.Dwellings[this.CurrentSelection].Comments = this.txtNotes.Text;
          break;
      }
    }

    private void Button2_Click(object sender, EventArgs e) => this.SaveNotes();

    private void CmdNotes_Click(object sender, EventArgs e)
    {
      this.SaveNotes();
      new CreatePDF().PrintNotes();
    }
  }
}
