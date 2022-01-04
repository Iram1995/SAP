
// Type: SAP2012.Lodgement_History




using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using SAP2012.SAPRef;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SAP2012
{
  [DesignerGenerated]
  public class Lodgement_History : Form
  {
    private IContainer components;

    public Lodgement_History()
    {
      this.Load += new EventHandler(this.Lodgement_History_Load);
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Lodgement_History));
      this.TreeSAP = new TreeView();
      this.TreeImages = new ImageList(this.components);
      this.Panel1 = new Panel();
      this.lblMethod = new Label();
      this.Label5 = new Label();
      this.Button2 = new Button();
      this.LodgeDate = new Label();
      this.Label4 = new Label();
      this.lblGraph = new Label();
      this.PicGraph = new PictureBox();
      this.txtNotes = new TextBox();
      this.Label2 = new Label();
      this.LinkLabel1 = new LinkLabel();
      this.RRN = new Label();
      this.Label1 = new Label();
      this.Panel2 = new Panel();
      this.lblDetails = new Label();
      this.PictureBox1 = new PictureBox();
      this.Panel1.SuspendLayout();
      ((ISupportInitialize) this.PicGraph).BeginInit();
      this.Panel2.SuspendLayout();
      ((ISupportInitialize) this.PictureBox1).BeginInit();
      this.SuspendLayout();
      this.TreeSAP.Cursor = Cursors.Hand;
      this.TreeSAP.Dock = DockStyle.Left;
      this.TreeSAP.ImageIndex = 0;
      this.TreeSAP.ImageList = this.TreeImages;
      this.TreeSAP.Location = new Point(0, 0);
      this.TreeSAP.Name = "TreeSAP";
      this.TreeSAP.SelectedImageIndex = 0;
      this.TreeSAP.Size = new Size(205, 728);
      this.TreeSAP.TabIndex = 0;
      this.TreeImages.ImageStream = (ImageListStreamer) componentResourceManager.GetObject("TreeImages.ImageStream");
      this.TreeImages.TransparentColor = Color.Transparent;
      this.TreeImages.Images.SetKeyName(0, "1.gif");
      this.TreeImages.Images.SetKeyName(1, "house.jpg");
      this.TreeImages.Images.SetKeyName(2, "accept.ico");
      this.TreeImages.Images.SetKeyName(3, "delete.ico");
      this.TreeImages.Images.SetKeyName(4, "next.ico");
      this.Panel1.Controls.Add((Control) this.lblMethod);
      this.Panel1.Controls.Add((Control) this.Label5);
      this.Panel1.Controls.Add((Control) this.Button2);
      this.Panel1.Controls.Add((Control) this.LodgeDate);
      this.Panel1.Controls.Add((Control) this.Label4);
      this.Panel1.Controls.Add((Control) this.lblGraph);
      this.Panel1.Controls.Add((Control) this.PicGraph);
      this.Panel1.Controls.Add((Control) this.txtNotes);
      this.Panel1.Controls.Add((Control) this.Label2);
      this.Panel1.Controls.Add((Control) this.LinkLabel1);
      this.Panel1.Controls.Add((Control) this.RRN);
      this.Panel1.Controls.Add((Control) this.Label1);
      this.Panel1.Dock = DockStyle.Fill;
      this.Panel1.Location = new Point(205, 82);
      this.Panel1.Name = "Panel1";
      this.Panel1.Size = new Size(712, 646);
      this.Panel1.TabIndex = 1;
      this.lblMethod.Location = new Point(641, 39);
      this.lblMethod.Name = "lblMethod";
      this.lblMethod.Size = new Size(91, 14);
      this.lblMethod.TabIndex = 28;
      this.lblMethod.TextAlign = ContentAlignment.MiddleLeft;
      this.Label5.AutoSize = true;
      this.Label5.Font = new Font("Tahoma", 9f, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, (byte) 0);
      this.Label5.Location = new Point(495, 39);
      this.Label5.Name = "Label5";
      this.Label5.Size = new Size(133, 14);
      this.Label5.TabIndex = 27;
      this.Label5.Text = "Lodgement Method:";
      this.Button2.BackColor = Color.LightSlateGray;
      this.Button2.Cursor = Cursors.Hand;
      this.Button2.FlatStyle = FlatStyle.Popup;
      this.Button2.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button2.ForeColor = Color.White;
      this.Button2.Location = new Point(613, 609);
      this.Button2.Name = "Button2";
      this.Button2.Size = new Size(92, 25);
      this.Button2.TabIndex = 21;
      this.Button2.Text = "Close";
      this.Button2.UseVisualStyleBackColor = false;
      this.LodgeDate.AutoSize = true;
      this.LodgeDate.Location = new Point(143, 39);
      this.LodgeDate.Name = "LodgeDate";
      this.LodgeDate.Size = new Size(33, 14);
      this.LodgeDate.TabIndex = 26;
      this.LodgeDate.Text = "RRN:";
      this.Label4.AutoSize = true;
      this.Label4.Font = new Font("Tahoma", 9f, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, (byte) 0);
      this.Label4.Location = new Point(19, 39);
      this.Label4.Name = "Label4";
      this.Label4.Size = new Size(114, 14);
      this.Label4.TabIndex = 25;
      this.Label4.Text = "Lodgement Date:";
      this.lblGraph.AutoSize = true;
      this.lblGraph.Font = new Font("Tahoma", 9f, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, (byte) 0);
      this.lblGraph.Location = new Point(19, 302);
      this.lblGraph.Name = "lblGraph";
      this.lblGraph.Size = new Size(117, 14);
      this.lblGraph.TabIndex = 24;
      this.lblGraph.Text = "Lodgement Graph";
      this.PicGraph.Location = new Point(22, 319);
      this.PicGraph.Name = "PicGraph";
      this.PicGraph.Size = new Size(683, 290);
      this.PicGraph.SizeMode = PictureBoxSizeMode.Zoom;
      this.PicGraph.TabIndex = 23;
      this.PicGraph.TabStop = false;
      this.txtNotes.Location = new Point(21, 87);
      this.txtNotes.Multiline = true;
      this.txtNotes.Name = "txtNotes";
      this.txtNotes.ScrollBars = ScrollBars.Both;
      this.txtNotes.Size = new Size(684, 212);
      this.txtNotes.TabIndex = 22;
      this.Label2.AutoSize = true;
      this.Label2.Font = new Font("Tahoma", 9f, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, (byte) 0);
      this.Label2.Location = new Point(18, 69);
      this.Label2.Name = "Label2";
      this.Label2.Size = new Size(138, 14);
      this.Label2.TabIndex = 3;
      this.Label2.Text = "Lodgement Summary";
      this.LinkLabel1.AutoSize = true;
      this.LinkLabel1.Location = new Point(641, 15);
      this.LinkLabel1.Name = "LinkLabel1";
      this.LinkLabel1.Size = new Size(55, 14);
      this.LinkLabel1.TabIndex = 2;
      this.LinkLabel1.TabStop = true;
      this.LinkLabel1.Text = "ViewEPC";
      this.RRN.AutoSize = true;
      this.RRN.Location = new Point(143, 15);
      this.RRN.Name = "RRN";
      this.RRN.Size = new Size(33, 14);
      this.RRN.TabIndex = 1;
      this.RRN.Text = "RRN:";
      this.Label1.AutoSize = true;
      this.Label1.Font = new Font("Tahoma", 9f, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, (byte) 0);
      this.Label1.Location = new Point(19, 15);
      this.Label1.Name = "Label1";
      this.Label1.Size = new Size(37, 14);
      this.Label1.TabIndex = 0;
      this.Label1.Text = "RRN:";
      this.Panel2.BackColor = Color.LightSlateGray;
      this.Panel2.Controls.Add((Control) this.lblDetails);
      this.Panel2.Controls.Add((Control) this.PictureBox1);
      this.Panel2.Dock = DockStyle.Top;
      this.Panel2.Location = new Point(205, 0);
      this.Panel2.Name = "Panel2";
      this.Panel2.Padding = new Padding(6, 5, 6, 5);
      this.Panel2.Size = new Size(712, 82);
      this.Panel2.TabIndex = 2;
      this.lblDetails.Font = new Font("Tahoma", 11f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblDetails.ForeColor = Color.White;
      this.lblDetails.Location = new Point(22, 9);
      this.lblDetails.Name = "lblDetails";
      this.lblDetails.Size = new Size(540, 63);
      this.lblDetails.TabIndex = 2;
      this.PictureBox1.Dock = DockStyle.Right;
      this.PictureBox1.Image = (Image) componentResourceManager.GetObject("PictureBox1.Image");
      this.PictureBox1.Location = new Point(551, 5);
      this.PictureBox1.Name = "PictureBox1";
      this.PictureBox1.Size = new Size(155, 72);
      this.PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
      this.PictureBox1.TabIndex = 1;
      this.PictureBox1.TabStop = false;
      this.AutoScaleDimensions = new SizeF(7f, 14f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.White;
      this.ClientSize = new Size(917, 728);
      this.Controls.Add((Control) this.Panel1);
      this.Controls.Add((Control) this.Panel2);
      this.Controls.Add((Control) this.TreeSAP);
      this.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (Lodgement_History);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Lodgement History";
      this.Panel1.ResumeLayout(false);
      this.Panel1.PerformLayout();
      ((ISupportInitialize) this.PicGraph).EndInit();
      this.Panel2.ResumeLayout(false);
      ((ISupportInitialize) this.PictureBox1).EndInit();
      this.ResumeLayout(false);
    }

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

    [field: AccessedThroughProperty("Panel1")]
    internal virtual Panel Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("TreeImages")]
    internal virtual ImageList TreeImages { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Panel2")]
    internal virtual Panel Panel2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("lblDetails")]
    internal virtual Label lblDetails { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label2")]
    internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual LinkLabel LinkLabel1
    {
      get => this._LinkLabel1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
        LinkLabel linkLabel1_1 = this._LinkLabel1;
        if (linkLabel1_1 != null)
          linkLabel1_1.LinkClicked -= clickedEventHandler;
        this._LinkLabel1 = value;
        LinkLabel linkLabel1_2 = this._LinkLabel1;
        if (linkLabel1_2 == null)
          return;
        linkLabel1_2.LinkClicked += clickedEventHandler;
      }
    }

    [field: AccessedThroughProperty("RRN")]
    internal virtual Label RRN { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label1")]
    internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("LodgeDate")]
    internal virtual Label LodgeDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label4")]
    internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("lblGraph")]
    internal virtual Label lblGraph { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("PicGraph")]
    internal virtual PictureBox PicGraph { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtNotes")]
    internal virtual TextBox txtNotes { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

    [field: AccessedThroughProperty("PictureBox1")]
    internal virtual PictureBox PictureBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("lblMethod")]
    internal virtual Label lblMethod { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label5")]
    internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private void Lodgement_History_Load(object sender, EventArgs e)
    {
    }

    public void FillHistory()
    {
      this.Panel2.Visible = false;
      this.TreeSAP.Nodes.Clear();
      this.TreeSAP.Nodes.Add("Project", SAP_Module.Proj.Name, 0, 4);
      int num1 = checked (SAP_Module.Proj.NoOfDwells - 1);
      int Number = 0;
      while (Number <= num1)
      {
        if (SAP_Module.Proj.Dwellings[Number].LodgementAttempts > 0)
        {
          this.TreeSAP.Nodes[0].Nodes.Add(Conversion.Str((object) Number), SAP_Module.Proj.Dwellings[Number].Name, 1, 4);
          int num2 = checked (SAP_Module.Proj.Dwellings[Number].LodgementAttempts - 1);
          int index1 = 0;
          int index2;
          while (index1 <= num2)
          {
            try
            {
              if (SAP_Module.Proj.Dwellings[Number].Lodgement[index1].Success)
                this.TreeSAP.Nodes[0].Nodes[index2].Nodes.Add(Conversion.Str((object) Number), SAP_Module.Proj.Dwellings[Number].Lodgement[index1].DateLodged.ToString(), 2, 4);
              else
                this.TreeSAP.Nodes[0].Nodes[index2].Nodes.Add(Conversion.Str((object) Number), SAP_Module.Proj.Dwellings[Number].Lodgement[index1].DateLodged.ToString(), 3, 4);
            }
            catch (Exception ex)
            {
              ProjectData.SetProjectError(ex);
              ProjectData.ClearProjectError();
            }
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
        int House;
        if ((double) num != Conversion.Val(e.Node.Name))
          House = checked ((int) Math.Round(Conversion.Val(e.Node.Name)));
        this.lblDetails.Text = "Project: " + SAP_Module.Proj.Name + " -- Dwelling: " + SAP_Module.Proj.Dwellings[House].Name + " -- Lodged: " + Conversions.ToString(SAP_Module.Proj.Dwellings[House].Lodgement[e.Node.Index].DateLodged);
        this.Panel1.Visible = true;
        this.LodgeDate.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[House].Lodgement[e.Node.Index].DateLodged);
        if (SAP_Module.Proj.Dwellings[House].Lodgement[e.Node.Index].Success)
        {
          this.lblGraph.Visible = true;
          this.PicGraph.Visible = true;
          this.txtNotes.Height = 212;
          int x = 1344;
          int height = 1088;
          Image image1 = (Image) new Bitmap(checked (x * 2), height);
          Image image2;
          Image image3;
          if (Operators.CompareString(SAP_Module.Proj.Dwellings[House].Address.Country, "England", false) == 0)
          {
            image2 = this.DrawEnvironGraph(1, House, SAP_Module.Proj.Dwellings[House].Lodgement[e.Node.Index].SAP.EIRating, SAP_Module.Proj.Dwellings[House].Lodgement[e.Node.Index].PSAP.EIRating);
            image3 = this.DrawEnergyGraph(1, House, SAP_Module.Proj.Dwellings[House].Lodgement[e.Node.Index].SAP.SAPRating, SAP_Module.Proj.Dwellings[House].Lodgement[e.Node.Index].PSAP.SAPRating);
          }
          else if (Operators.CompareString(SAP_Module.Proj.Dwellings[House].Address.Country, "Scotland", false) == 0)
          {
            image2 = this.DrawEnvironGraph(4, House, SAP_Module.Proj.Dwellings[House].Lodgement[e.Node.Index].SAP.EIRating, SAP_Module.Proj.Dwellings[House].Lodgement[e.Node.Index].PSAP.EIRating);
            image3 = this.DrawEnergyGraph(4, House, SAP_Module.Proj.Dwellings[House].Lodgement[e.Node.Index].SAP.SAPRating, SAP_Module.Proj.Dwellings[House].Lodgement[e.Node.Index].PSAP.SAPRating);
          }
          else
          {
            image2 = this.DrawEnvironGraph(2, House, SAP_Module.Proj.Dwellings[House].Lodgement[e.Node.Index].SAP.EIRating, SAP_Module.Proj.Dwellings[House].Lodgement[e.Node.Index].PSAP.EIRating);
            image3 = this.DrawEnergyGraph(2, House, SAP_Module.Proj.Dwellings[House].Lodgement[e.Node.Index].SAP.SAPRating, SAP_Module.Proj.Dwellings[House].Lodgement[e.Node.Index].PSAP.SAPRating);
          }
          Graphics graphics = Graphics.FromImage(image1);
          graphics.DrawImage(image2, 0, 0);
          graphics.DrawImage(image3, x, 0);
          this.PicGraph.Image = image1;
        }
        else
        {
          this.lblGraph.Visible = false;
          this.PicGraph.Visible = false;
          this.txtNotes.Height = 522;
        }
        this.RRN.Text = SAP_Module.Proj.Dwellings[House].Lodgement[e.Node.Index].RRN;
        try
        {
          this.lblMethod.Text = "";
          this.lblMethod.Text = SAP_Module.Proj.Dwellings[House].Lodgement[e.Node.Index].Method == null ? "" : SAP_Module.Proj.Dwellings[House].Lodgement[e.Node.Index].Method;
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        this.txtNotes.Text = SAP_Module.Proj.Dwellings[House].Lodgement[e.Node.Index].Result;
      }
      else
        this.lblDetails.Text = "Project: " + SAP_Module.Proj.Name;
    }

    public Image DrawEnvironGraph(int Country, int House, int EI, int PEI)
    {
      int num1;
      Image image1;
      int num2;
      try
      {
label_2:
        ProjectData.ClearProjectError();
        num1 = -2;
label_3:
        int num3 = 2;
        int width1 = 1344;
label_4:
        num3 = 3;
        int num4 = 1088;
label_5:
        num3 = 4;
        image1 = (Image) new Bitmap(width1, num4);
label_6:
        num3 = 5;
        Graphics graphics1 = Graphics.FromImage(image1);
label_7:
        num3 = 6;
        Font font1 = new Font("Arial", 64f, FontStyle.Bold);
label_8:
        num3 = 7;
        Font font2 = new Font("Arial", 56f, FontStyle.Bold);
label_9:
        num3 = 8;
        Font font3 = new Font("Arial", 36f, FontStyle.Regular);
label_10:
        num3 = 9;
        Font font4 = new Font("Arial", 32f, FontStyle.Bold);
label_11:
        num3 = 10;
        Font font5 = new Font("Arial", 28f, FontStyle.Italic);
label_12:
        num3 = 11;
        Font font6 = new Font("Arial", 28f, FontStyle.Bold);
label_13:
        num3 = 12;
        Font font7 = new Font("Arial", 24f, FontStyle.Regular);
label_14:
        num3 = 13;
        Pen pen1 = (Pen) Pens.Black.Clone();
label_15:
        num3 = 14;
        pen1.Width = 5f;
label_16:
        num3 = 15;
        Pen pen2 = (Pen) Pens.Black.Clone();
label_17:
        num3 = 16;
        pen2.Width = 3f;
label_18:
        num3 = 17;
        Pen pen3 = new Pen(Color.Black, 2f);
label_19:
        num3 = 18;
        Graphics graphics2 = graphics1;
label_20:
        num3 = 19;
        graphics2.TextRenderingHint = TextRenderingHint.AntiAlias;
label_21:
        num3 = 20;
        graphics2.SmoothingMode = SmoothingMode.AntiAlias;
label_22:
        num3 = 21;
        graphics1.FillRectangle(Brushes.White, 0, 0, width1, num4);
label_23:
        num3 = 22;
        graphics2.DrawLine(pen1, 1, 1, checked (width1 - 1), 1);
label_24:
        num3 = 23;
        graphics2.DrawLine(pen1, checked (width1 - 1), 1, checked (width1 - 1), checked (num4 - 1));
label_25:
        num3 = 24;
        graphics2.DrawLine(pen1, checked (width1 - 1), checked (num4 - 1), 1, checked (num4 - 1));
label_26:
        num3 = 25;
        graphics2.DrawLine(pen1, 1, checked (num4 - 1), 1, 1);
label_27:
        num3 = 26;
        int num5 = checked ((int) Math.Round(unchecked (0.688 * (double) width1)));
label_28:
        num3 = 27;
        int num6 = checked ((int) Math.Round(unchecked (0.885 * (double) num4)));
label_29:
        num3 = 28;
        graphics2.DrawLine(pen1, num5, num6, num5, 1);
label_30:
        num3 = 29;
        num5 = checked ((int) Math.Round(unchecked (0.845 * (double) width1)));
label_31:
        num3 = 30;
        graphics2.DrawLine(pen1, num5, num6, num5, 1);
label_32:
        num3 = 31;
        if (!(Country == 2 & Operators.CompareString(SAP_Module.Proj.Dwellings[House].EPCLanguage, "Welsh", false) == 0))
          goto label_42;
label_33:
        num3 = 32;
        num5 = checked ((int) Math.Round(unchecked (0.766 * (double) width1 - (double) graphics2.MeasureString("Cyfredol", font4, 500).Width / 2.0)));
label_34:
        num3 = 33;
        num6 = checked ((int) Math.Round(unchecked (0.2 * (double) font4.GetHeight())));
label_35:
        num3 = 34;
        graphics2.DrawString("Cyfredol", font4, Brushes.Black, (float) num5, (float) num6);
label_36:
        num3 = 35;
        num5 = checked ((int) Math.Round(unchecked (0.921 * (double) width1 - (double) graphics2.MeasureString("Potensial", font4, 500).Width / 2.0)));
label_37:
        num3 = 36;
        num6 = checked ((int) Math.Round(unchecked (0.2 * (double) font4.GetHeight())));
label_38:
        num3 = 37;
        graphics2.DrawString("Potensial", font4, Brushes.Black, (float) num5, (float) num6);
label_39:
        num3 = 38;
        num5 = checked ((int) Math.Round(unchecked (0.02 * (double) width1)));
label_40:
        num3 = 39;
        num6 = checked ((int) Math.Round(unchecked (1.6 * (double) font4.GetHeight())));
label_41:
        num3 = 40;
        graphics2.DrawString("Amgylcheddol gyfeillgar iawn – allyriadau CO2 is", font5, Brushes.Black, (float) num5, (float) num6);
        goto label_52;
label_42:
        num3 = 42;
        num5 = checked ((int) Math.Round(unchecked (0.766 * (double) width1 - (double) graphics2.MeasureString("Current", font4, 500).Width / 2.0)));
label_43:
        num3 = 43;
        num6 = checked ((int) Math.Round(unchecked (0.2 * (double) font4.GetHeight())));
label_44:
        num3 = 44;
        graphics2.DrawString("Current", font4, Brushes.Black, (float) num5, (float) num6);
label_45:
        num3 = 45;
        num5 = checked ((int) Math.Round(unchecked (0.921 * (double) width1 - (double) graphics2.MeasureString("Potential", font4, 500).Width / 2.0)));
label_46:
        num3 = 46;
        num6 = checked ((int) Math.Round(unchecked (0.2 * (double) font4.GetHeight())));
label_47:
        num3 = 47;
        graphics2.DrawString("Potential", font4, Brushes.Black, (float) num5, (float) num6);
label_48:
        num3 = 48;
        num5 = checked ((int) Math.Round(unchecked (0.02 * (double) width1)));
label_49:
        num3 = 49;
        num6 = checked ((int) Math.Round(unchecked (1.6 * (double) font4.GetHeight())));
label_50:
        num3 = 50;
        graphics2.DrawString("Very environmentally friendly - lower CO2 emissions", font5, Brushes.Black, (float) num5, (float) num6);
label_51:
label_52:
        num3 = 52;
        num6 = checked ((int) Math.Round(unchecked (0.063 * (double) num4)));
label_53:
        num3 = 53;
        graphics2.DrawLine(pen1, 1, num6, checked (width1 - 1), num6);
label_54:
        num3 = 54;
        Brush brush = (Brush) new SolidBrush(Color.FromArgb(205, 226, 245));
label_55:
        num3 = 55;
        num5 = checked ((int) Math.Round(unchecked (0.01 * (double) width1)));
label_56:
        num3 = 56;
        num6 = checked ((int) Math.Round(unchecked (0.127 * (double) num4)));
label_57:
        num3 = 57;
        int width2 = checked ((int) Math.Round(unchecked (0.221 * (double) width1)));
label_58:
        num3 = 58;
        int height = checked ((int) Math.Round(unchecked (0.086585 * (double) num4)));
label_59:
        num3 = 59;
        graphics2.FillRectangle(brush, num5, num6, width2, height);
label_60:
        num3 = 60;
        num6 = checked ((int) Math.Round(unchecked ((double) num6 + (double) height / 2.0 - (double) graphics2.MeasureString("()", font6, 500).Height / 2.0)));
label_61:
        num3 = 61;
        num5 = checked ((int) Math.Round(unchecked (0.025 * (double) width1)));
label_62:
        num3 = 62;
        graphics2.DrawString("(92 plus)", font6, Brushes.Black, (float) num5, (float) num6);
label_63:
        num3 = 63;
        num5 = checked ((int) Math.Round(unchecked (0.158 * (double) width1)));
label_64:
        num3 = 64;
        num6 = checked ((int) Math.Round(unchecked (0.127 * (double) num4 + (double) height / 2.0 - (double) graphics2.MeasureString("A", font1, 900).Height / 2.1)));
label_65:
        num3 = 65;
        GraphicsPath path = new GraphicsPath();
label_66:
        num3 = 66;
        path.AddString("A", font1.FontFamily, 1, 84f, new Point(num5, num6), StringFormat.GenericTypographic);
label_67:
        num3 = 67;
        graphics2.FillPath(Brushes.White, path);
label_68:
        num3 = 68;
        graphics2.DrawPath(pen2, path);
label_69:
        num3 = 69;
        num5 = checked ((int) Math.Round(unchecked (0.01 * (double) width1)));
label_70:
        num3 = 70;
        brush = (Brush) new SolidBrush(Color.FromArgb(151, 192, 239));
label_71:
        num3 = 71;
        num6 = checked ((int) Math.Round(unchecked (0.227 * (double) num4)));
label_72:
        num3 = 72;
        width2 = checked ((int) Math.Round(unchecked (0.295 * (double) width1)));
label_73:
        num3 = 73;
        graphics2.FillRectangle(brush, num5, num6, width2, height);
label_74:
        num3 = 74;
        num6 = checked ((int) Math.Round(unchecked ((double) num6 + (double) height / 2.0 - (double) graphics2.MeasureString("()", font6, 900).Height / 2.0)));
label_75:
        num3 = 75;
        num5 = checked ((int) Math.Round(unchecked (0.025 * (double) width1)));
label_76:
        num3 = 76;
        graphics2.DrawString("(81-91)", font6, Brushes.Black, (float) num5, (float) num6);
label_77:
        num3 = 77;
        num5 = checked ((int) Math.Round(unchecked (0.239 * (double) width1)));
label_78:
        num3 = 78;
        num6 = checked ((int) Math.Round(unchecked (0.227 * (double) num4 + (double) height / 2.0 - (double) graphics2.MeasureString("B", font1, 500).Height / 2.1)));
label_79:
        num3 = 79;
        path.AddString("B", font1.FontFamily, 1, 84f, new Point(num5, num6), StringFormat.GenericTypographic);
label_80:
        num3 = 80;
        graphics2.FillPath(Brushes.White, path);
label_81:
        num3 = 81;
        graphics2.DrawPath(pen2, path);
label_82:
        num3 = 82;
        num5 = checked ((int) Math.Round(unchecked (0.01 * (double) width1)));
label_83:
        num3 = 83;
        brush = (Brush) new SolidBrush(Color.FromArgb(115, 162, 214));
label_84:
        num3 = 84;
        num6 = checked ((int) Math.Round(unchecked (0.327 * (double) num4)));
label_85:
        num3 = 85;
        width2 = checked ((int) Math.Round(unchecked (0.37 * (double) width1)));
label_86:
        num3 = 86;
        graphics2.FillRectangle(brush, num5, num6, width2, height);
label_87:
        num3 = 87;
        num6 = checked ((int) Math.Round(unchecked ((double) num6 + (double) height / 2.0 - (double) graphics2.MeasureString("()", font6, 900).Height / 2.0)));
label_88:
        num3 = 88;
        num5 = checked ((int) Math.Round(unchecked (0.025 * (double) width1)));
label_89:
        num3 = 89;
        graphics2.DrawString("(69-80)", font6, Brushes.Black, (float) num5, (float) num6);
label_90:
        num3 = 90;
        num5 = checked ((int) Math.Round(unchecked (0.307 * (double) width1)));
label_91:
        num3 = 91;
        num6 = checked ((int) Math.Round(unchecked (0.327 * (double) num4 + (double) height / 2.0 - (double) graphics2.MeasureString("C", font1, 500).Height / 2.1)));
label_92:
        num3 = 92;
        path.AddString("C", font1.FontFamily, 1, 84f, new Point(num5, num6), StringFormat.GenericTypographic);
label_93:
        num3 = 93;
        graphics2.FillPath(Brushes.White, path);
label_94:
        num3 = 94;
        graphics2.DrawPath(pen2, path);
label_95:
        num3 = 95;
        num5 = checked ((int) Math.Round(unchecked (0.01 * (double) width1)));
label_96:
        num3 = 96;
        brush = (Brush) new SolidBrush(Color.FromArgb(78, 132, 196));
label_97:
        num3 = 97;
        num6 = checked ((int) Math.Round(unchecked (0.427 * (double) num4)));
label_98:
        num3 = 98;
        width2 = checked ((int) Math.Round(unchecked (0.445 * (double) width1)));
label_99:
        num3 = 99;
        graphics2.FillRectangle(brush, num5, num6, width2, height);
label_100:
        num3 = 100;
        num6 = checked ((int) Math.Round(unchecked ((double) num6 + (double) height / 2.0 - (double) graphics2.MeasureString("()", font6, 900).Height / 2.0)));
label_101:
        num3 = 101;
        num5 = checked ((int) Math.Round(unchecked (0.025 * (double) width1)));
label_102:
        num3 = 102;
        graphics2.DrawString("(55-68)", font6, Brushes.Black, (float) num5, (float) num6);
label_103:
        num3 = 103;
        num5 = checked ((int) Math.Round(unchecked (0.387 * (double) width1)));
label_104:
        num3 = 104;
        num6 = checked ((int) Math.Round(unchecked (0.427 * (double) num4 + (double) height / 2.0 - (double) graphics2.MeasureString("D", font1, 500).Height / 2.1)));
label_105:
        num3 = 105;
        path.AddString("D", font1.FontFamily, 1, 84f, new Point(num5, num6), StringFormat.GenericTypographic);
label_106:
        num3 = 106;
        graphics2.FillPath(Brushes.White, path);
label_107:
        num3 = 107;
        graphics2.DrawPath(pen2, path);
label_108:
        num3 = 108;
        num5 = checked ((int) Math.Round(unchecked (0.01 * (double) width1)));
label_109:
        num3 = 109;
        brush = (Brush) new SolidBrush(Color.FromArgb(168, 168, 168));
label_110:
        num3 = 110;
        num6 = checked ((int) Math.Round(unchecked (0.527 * (double) num4)));
label_111:
        num3 = 111;
        width2 = checked ((int) Math.Round(unchecked (0.518 * (double) width1)));
label_112:
        num3 = 112;
        graphics2.FillRectangle(brush, num5, num6, width2, height);
label_113:
        num3 = 113;
        num6 = checked ((int) Math.Round(unchecked ((double) num6 + (double) height / 2.0 - (double) graphics2.MeasureString("()", font6, 900).Height / 2.0)));
label_114:
        num3 = 114;
        num5 = checked ((int) Math.Round(unchecked (0.025 * (double) width1)));
label_115:
        num3 = 115;
        graphics2.DrawString("(39-54)", font6, Brushes.Black, (float) num5, (float) num6);
label_116:
        num3 = 116;
        num5 = checked ((int) Math.Round(unchecked (0.459 * (double) width1)));
label_117:
        num3 = 117;
        num6 = checked ((int) Math.Round(unchecked (0.527 * (double) num4 + (double) height / 2.0 - (double) graphics2.MeasureString("E", font1, 500).Height / 2.1)));
label_118:
        num3 = 118;
        path.AddString("E", font1.FontFamily, 1, 84f, new Point(num5, num6), StringFormat.GenericTypographic);
label_119:
        num3 = 119;
        graphics2.FillPath(Brushes.White, path);
label_120:
        num3 = 120;
        graphics2.DrawPath(pen2, path);
label_121:
        num3 = 121;
        num5 = checked ((int) Math.Round(unchecked (0.01 * (double) width1)));
label_122:
        num3 = 122;
        brush = (Brush) new SolidBrush(Color.FromArgb(134, 134, 134));
label_123:
        num3 = 123;
        num6 = checked ((int) Math.Round(unchecked (0.627 * (double) num4)));
label_124:
        num3 = 124;
        width2 = checked ((int) Math.Round(unchecked (0.592 * (double) width1)));
label_125:
        num3 = 125;
        graphics2.FillRectangle(brush, num5, num6, width2, height);
label_126:
        num3 = 126;
        num6 = checked ((int) Math.Round(unchecked ((double) num6 + (double) height / 2.0 - (double) graphics2.MeasureString("()", font6, 900).Height / 2.0)));
label_127:
        num3 = (int) sbyte.MaxValue;
        num5 = checked ((int) Math.Round(unchecked (0.025 * (double) width1)));
label_128:
        num3 = 128;
        graphics2.DrawString("(21-38)", font6, Brushes.White, (float) num5, (float) num6);
label_129:
        num3 = 129;
        num5 = checked ((int) Math.Round(unchecked (0.536 * (double) width1)));
label_130:
        num3 = 130;
        num6 = checked ((int) Math.Round(unchecked (0.627 * (double) num4 + (double) height / 2.0 - (double) graphics2.MeasureString("F", font1, 500).Height / 2.1)));
label_131:
        num3 = 131;
        path.AddString("F", font1.FontFamily, 1, 84f, new Point(num5, num6), StringFormat.GenericTypographic);
label_132:
        num3 = 132;
        graphics2.FillPath(Brushes.White, path);
label_133:
        num3 = 133;
        graphics2.DrawPath(pen2, path);
label_134:
        num3 = 134;
        num5 = checked ((int) Math.Round(unchecked (0.01 * (double) width1)));
label_135:
        num3 = 135;
        brush = (Brush) new SolidBrush(Color.FromArgb(104, 104, 104));
label_136:
        num3 = 136;
        num6 = checked ((int) Math.Round(unchecked (0.727 * (double) num4)));
label_137:
        num3 = 137;
        width2 = checked ((int) Math.Round(unchecked (0.668 * (double) width1)));
label_138:
        num3 = 138;
        graphics2.FillRectangle(brush, num5, num6, width2, height);
label_139:
        num3 = 139;
        num6 = checked ((int) Math.Round(unchecked ((double) num6 + (double) height / 2.0 - (double) graphics2.MeasureString("()", font6, 900).Height / 2.0)));
label_140:
        num3 = 140;
        num5 = checked ((int) Math.Round(unchecked (0.025 * (double) width1)));
label_141:
        num3 = 141;
        graphics2.DrawString("(1-20)", font6, Brushes.White, (float) num5, (float) num6);
label_142:
        num3 = 142;
        num5 = checked ((int) Math.Round(unchecked (0.607 * (double) width1)));
label_143:
        num3 = 143;
        num6 = checked ((int) Math.Round(unchecked (0.727 * (double) num4 + (double) height / 2.0 - (double) graphics2.MeasureString("G", font1, 500).Height / 2.1)));
label_144:
        num3 = 144;
        path.AddString("G", font1.FontFamily, 1, 84f, new Point(num5, num6), StringFormat.GenericTypographic);
label_145:
        num3 = 145;
        graphics2.FillPath(Brushes.White, path);
label_146:
        num3 = 146;
        graphics2.DrawPath(pen2, path);
label_147:
        num3 = 147;
        num5 = checked ((int) Math.Round(unchecked (0.01 * (double) width1)));
label_148:
        num3 = 148;
        num6 = checked ((int) Math.Round(unchecked (0.885 * (double) num4)));
label_149:
        num3 = 149;
        graphics2.DrawLine(pen1, 1, num6, checked (width1 - 1), num6);
label_150:
        num3 = 150;
        num6 = checked ((int) Math.Round(unchecked ((0.885 * (double) num4 - (0.727 * (double) num4 + 0.086585 * (double) num4)) / 2.0 + (0.727 * (double) num4 + 0.086585 * (double) num4) - (double) graphics2.MeasureString("Potential", font5, 500).Height / 2.0)));
label_151:
        num3 = 151;
        num5 = checked ((int) Math.Round(unchecked (0.02 * (double) width1)));
label_152:
        num3 = 152;
        if (!(Country == 2 & Operators.CompareString(SAP_Module.Proj.Dwellings[House].EPCLanguage, "Welsh", false) == 0))
          goto label_164;
label_153:
        num3 = 153;
        graphics2.DrawString("Ddim yn amgylcheddol gyfeillgar - allyriadau CO2 uwch", font5, Brushes.Black, (float) num5, (float) num6);
label_154:
        num3 = 154;
        num6 = checked ((int) Math.Round(unchecked (23.0 / 400.0 * (double) num4 + 0.885 * (double) num4 - 0.5 * (double) graphics2.MeasureString("Cymru a Lloegr", font2, 900).Height)));
label_155:
        num3 = 155;
        num5 = checked ((int) Math.Round(unchecked (0.025 * (double) width1)));
label_156:
        num3 = 156;
        graphics2.DrawString("Cymru a Lloegr", font2, Brushes.Black, (float) num5, (float) num6);
label_157:
        num3 = 157;
        num6 = checked ((int) Math.Round(unchecked (23.0 / 400.0 * (double) num4 + 0.885 * (double) num4 - (double) graphics2.MeasureString("Cyfarwyddeb 2002/91/EC", font7, 500).Height)));
label_158:
        num3 = 158;
        num5 = checked ((int) Math.Round(unchecked (0.59 * (double) width1)));
label_159:
        num3 = 159;
        graphics2.DrawString("Cyfarwyddeb 2002/91/EC", font7, Brushes.Black, (float) num5, (float) num6);
label_160:
        num3 = 160;
        num6 = checked ((int) Math.Round(unchecked (23.0 / 400.0 * (double) num4 + 0.885 * (double) num4)));
label_161:
        num3 = 161;
        num5 = checked ((int) Math.Round(unchecked (0.63 * (double) width1)));
label_162:
        num3 = 162;
        graphics2.DrawString("yr Undeb Ewropeaidd", font7, Brushes.Black, (float) num5, (float) num6);
label_163:
        num3 = 163;
        num6 = checked ((int) Math.Round(unchecked (23.0 / 400.0 * (double) num4 + 0.885 * (double) num4 - 0.52 * (double) graphics2.MeasureString("Cymru a Lloegr", font2, 900).Height)));
        goto label_184;
label_164:
        num3 = 165;
        graphics2.DrawString("Not environmentally friendly - higher CO2 emissions", font5, Brushes.Black, (float) num5, (float) num6);
label_165:
        num3 = 166;
        if (Country != 4)
          goto label_169;
label_166:
        num3 = 167;
        num6 = checked ((int) Math.Round(unchecked (23.0 / 400.0 * (double) num4 + 0.885 * (double) num4 - 0.5 * (double) graphics2.MeasureString("Scotland", font2, 900).Height)));
label_167:
        num3 = 168;
        num5 = checked ((int) Math.Round(unchecked (0.025 * (double) width1)));
label_168:
        num3 = 169;
        graphics2.DrawString("Scotland", font2, Brushes.Black, (float) num5, (float) num6);
        goto label_173;
label_169:
        num3 = 171;
        num6 = checked ((int) Math.Round(unchecked (23.0 / 400.0 * (double) num4 + 0.885 * (double) num4 - 0.5 * (double) graphics2.MeasureString("England & Wales", font2, 900).Height)));
label_170:
        num3 = 172;
        num5 = checked ((int) Math.Round(unchecked (0.025 * (double) width1)));
label_171:
        num3 = 173;
        graphics2.DrawString("England & Wales", font2, Brushes.Black, (float) num5, (float) num6);
label_172:
label_173:
        num3 = 175;
        num6 = checked ((int) Math.Round(unchecked (23.0 / 400.0 * (double) num4 + 0.885 * (double) num4 - (double) graphics2.MeasureString("EU Directive", font3, 500).Height)));
label_174:
        num3 = 176;
        num5 = checked ((int) Math.Round(unchecked (0.66 * (double) width1)));
label_175:
        num3 = 177;
        graphics2.DrawString("EU Directive", font3, Brushes.Black, (float) num5, (float) num6);
label_176:
        num3 = 178;
        num6 = checked ((int) Math.Round(unchecked (23.0 / 400.0 * (double) num4 + 0.885 * (double) num4)));
label_177:
        num3 = 179;
        num5 = checked ((int) Math.Round(unchecked (0.66 * (double) width1)));
label_178:
        num3 = 180;
        graphics2.DrawString("2002/91/EC", font3, Brushes.Black, (float) num5, (float) num6);
label_179:
        num3 = 181;
        if (Country != 4)
          goto label_181;
label_180:
        num3 = 182;
        num6 = checked ((int) Math.Round(unchecked (23.0 / 400.0 * (double) num4 + 0.885 * (double) num4 - 0.52 * (double) graphics2.MeasureString("Scotland", font2, 900).Height)));
        goto label_183;
label_181:
        num3 = 184;
        num6 = checked ((int) Math.Round(unchecked (23.0 / 400.0 * (double) num4 + 0.885 * (double) num4 - 0.52 * (double) graphics2.MeasureString("England & Wales", font2, 900).Height)));
label_182:
label_183:
label_184:
        num3 = 187;
        num5 = checked ((int) Math.Round(unchecked (0.88 * (double) width1)));
label_185:
        num3 = 188;
        Image image2 = Image.FromFile(Application.StartupPath + "\\Resources\\EU.bmp");
label_186:
        num3 = 189;
        width2 = checked ((int) Math.Round(unchecked ((double) image2.Width / 2.75)));
label_187:
        num3 = 190;
        height = checked ((int) Math.Round(unchecked ((double) image2.Height / 2.75)));
label_188:
        num3 = 191;
        graphics2.DrawImage(image2, num5, num6, width2, height);
label_189:
        num3 = 192;
        Point[] points = new Point[5];
label_190:
        num3 = 193;
label_191:
        num3 = 194;
        object Right1 = (object) EI;
label_192:
        num3 = 195;
        object Left1 = Right1;
label_193:
        num3 = 197;
        if (!Conversions.ToBoolean((object) (bool) (!Conversions.ToBoolean(Operators.CompareObjectGreaterEqual(Left1, (object) 1, false)) ? 0 : (Conversions.ToBoolean(Operators.CompareObjectLessEqual(Left1, (object) 20, false)) ? 1 : 0))))
          goto label_198;
label_194:
        num3 = 198;
        float Left2 = 0.727f;
label_195:
        num3 = 199;
        float Left3 = 20f;
label_196:
        num3 = 200;
        float num7 = 1f;
label_197:
        num3 = 201;
        brush = (Brush) new SolidBrush(Color.FromArgb(104, 104, 104));
        goto label_228;
label_198:
        num3 = 203;
        if (!Conversions.ToBoolean((object) (bool) (!Conversions.ToBoolean(Operators.CompareObjectGreaterEqual(Left1, (object) 21, false)) ? 0 : (Conversions.ToBoolean(Operators.CompareObjectLessEqual(Left1, (object) 38, false)) ? 1 : 0))))
          goto label_203;
label_199:
        num3 = 204;
        Left2 = 0.627f;
label_200:
        num3 = 205;
        Left3 = 38f;
label_201:
        num3 = 206;
        num7 = 21f;
label_202:
        num3 = 207;
        brush = (Brush) new SolidBrush(Color.FromArgb(134, 134, 134));
        goto label_228;
label_203:
        num3 = 209;
        if (!Conversions.ToBoolean((object) (bool) (!Conversions.ToBoolean(Operators.CompareObjectGreaterEqual(Left1, (object) 39, false)) ? 0 : (Conversions.ToBoolean(Operators.CompareObjectLessEqual(Left1, (object) 54, false)) ? 1 : 0))))
          goto label_208;
label_204:
        num3 = 210;
        Left2 = 0.527f;
label_205:
        num3 = 211;
        Left3 = 54f;
label_206:
        num3 = 212;
        num7 = 39f;
label_207:
        num3 = 213;
        brush = (Brush) new SolidBrush(Color.FromArgb(168, 168, 168));
        goto label_228;
label_208:
        num3 = 215;
        if (!Conversions.ToBoolean((object) (bool) (!Conversions.ToBoolean(Operators.CompareObjectGreaterEqual(Left1, (object) 55, false)) ? 0 : (Conversions.ToBoolean(Operators.CompareObjectLessEqual(Left1, (object) 68, false)) ? 1 : 0))))
          goto label_213;
label_209:
        num3 = 216;
        Left2 = 0.427f;
label_210:
        num3 = 217;
        Left3 = 68f;
label_211:
        num3 = 218;
        num7 = 55f;
label_212:
        num3 = 219;
        brush = (Brush) new SolidBrush(Color.FromArgb(78, 132, 196));
        goto label_228;
label_213:
        num3 = 221;
        if (!Conversions.ToBoolean((object) (bool) (!Conversions.ToBoolean(Operators.CompareObjectGreaterEqual(Left1, (object) 69, false)) ? 0 : (Conversions.ToBoolean(Operators.CompareObjectLessEqual(Left1, (object) 80, false)) ? 1 : 0))))
          goto label_218;
label_214:
        num3 = 222;
        Left2 = 0.327f;
label_215:
        num3 = 223;
        Left3 = 80f;
label_216:
        num3 = 224;
        num7 = 69f;
label_217:
        num3 = 225;
        brush = (Brush) new SolidBrush(Color.FromArgb(115, 162, 214));
        goto label_228;
label_218:
        num3 = 227;
        if (!Conversions.ToBoolean((object) (bool) (!Conversions.ToBoolean(Operators.CompareObjectGreaterEqual(Left1, (object) 81, false)) ? 0 : (Conversions.ToBoolean(Operators.CompareObjectLessEqual(Left1, (object) 91, false)) ? 1 : 0))))
          goto label_223;
label_219:
        num3 = 228;
        Left2 = 0.227f;
label_220:
        num3 = 229;
        Left3 = 91f;
label_221:
        num3 = 230;
        num7 = 81f;
label_222:
        num3 = 231;
        brush = (Brush) new SolidBrush(Color.FromArgb(151, 192, 239));
        goto label_228;
label_223:
        num3 = 233;
        if (!Operators.ConditionalCompareObjectGreaterEqual(Left1, (object) 92, false))
          goto label_228;
label_224:
        num3 = 234;
        Left2 = 0.127f;
label_225:
        num3 = 235;
        Left3 = 100f;
label_226:
        num3 = 236;
        num7 = 92f;
label_227:
        num3 = 237;
        brush = (Brush) new SolidBrush(Color.FromArgb(205, 226, 245));
label_228:
label_229:
        num3 = 238;
        float single = Conversions.ToSingle(Operators.MultiplyObject(Operators.AddObject((object) Left2, Operators.DivideObject(Operators.MultiplyObject((object) 0.086585, Operators.SubtractObject((object) Left3, Right1)), (object) (float) ((double) Left3 - (double) num7))), (object) num4));
label_230:
        num3 = 239;
        points[0].X = checked ((int) Math.Round(unchecked (0.693 * (double) width1)));
label_231:
        num3 = 240;
        points[0].Y = checked ((int) Math.Round((double) single));
label_232:
        num3 = 241;
        points[1].X = checked ((int) Math.Round(unchecked (0.729 * (double) width1)));
label_233:
        num3 = 242;
        points[1].Y = checked ((int) Math.Round(unchecked ((double) single - 0.0477 * (double) num4)));
label_234:
        num3 = 243;
        points[2].X = checked ((int) Math.Round(unchecked (0.839 * (double) width1)));
label_235:
        num3 = 244;
        points[2].Y = checked ((int) Math.Round(unchecked ((double) single - 0.0477 * (double) num4)));
label_236:
        num3 = 245;
        points[3].X = checked ((int) Math.Round(unchecked (0.839 * (double) width1)));
label_237:
        num3 = 246;
        points[3].Y = checked ((int) Math.Round(unchecked ((double) single + 0.0477 * (double) num4)));
label_238:
        num3 = 247;
        points[4].X = checked ((int) Math.Round(unchecked (0.729 * (double) width1)));
label_239:
        num3 = 248;
        points[4].Y = checked ((int) Math.Round(unchecked ((double) single + 0.0477 * (double) num4)));
label_240:
        num3 = 249;
        graphics2.FillPolygon(brush, points);
label_241:
        num3 = 250;
        num5 = checked ((int) Math.Round(unchecked (0.738 * (double) width1)));
label_242:
        num3 = 251;
        num6 = checked ((int) Math.Round(unchecked ((double) single - (double) graphics2.MeasureString("G", font1, 500).Height / 2.1)));
label_243:
        num3 = 252;
        path.AddString(Conversion.Str(RuntimeHelpers.GetObjectValue(Right1)), font1.FontFamily, 1, 84f, new Point(num5, num6), StringFormat.GenericTypographic);
label_244:
        num3 = 253;
        graphics2.FillPath(Brushes.White, path);
label_245:
        num3 = 254;
        graphics2.DrawPath(pen2, path);
label_246:
        num3 = (int) byte.MaxValue;
        object Right2 = (object) "";
label_247:
        num3 = 256;
        Right2 = (object) PEI;
label_248:
        num3 = 257;
        object Left4 = Right2;
label_249:
        num3 = 259;
        if (!Conversions.ToBoolean((object) (bool) (!Conversions.ToBoolean(Operators.CompareObjectGreaterEqual(Left4, (object) 1, false)) ? 0 : (Conversions.ToBoolean(Operators.CompareObjectLessEqual(Left4, (object) 20, false)) ? 1 : 0))))
          goto label_254;
label_250:
        num3 = 260;
        Left2 = 0.727f;
label_251:
        num3 = 261;
        Left3 = 20f;
label_252:
        num3 = 262;
        num7 = 1f;
label_253:
        num3 = 263;
        brush = (Brush) new SolidBrush(Color.FromArgb(104, 104, 104));
        goto label_284;
label_254:
        num3 = 265;
        if (!Conversions.ToBoolean((object) (bool) (!Conversions.ToBoolean(Operators.CompareObjectGreaterEqual(Left4, (object) 21, false)) ? 0 : (Conversions.ToBoolean(Operators.CompareObjectLessEqual(Left4, (object) 38, false)) ? 1 : 0))))
          goto label_259;
label_255:
        num3 = 266;
        Left2 = 0.627f;
label_256:
        num3 = 267;
        Left3 = 38f;
label_257:
        num3 = 268;
        num7 = 21f;
label_258:
        num3 = 269;
        brush = (Brush) new SolidBrush(Color.FromArgb(134, 134, 134));
        goto label_284;
label_259:
        num3 = 271;
        if (!Conversions.ToBoolean((object) (bool) (!Conversions.ToBoolean(Operators.CompareObjectGreaterEqual(Left4, (object) 39, false)) ? 0 : (Conversions.ToBoolean(Operators.CompareObjectLessEqual(Left4, (object) 54, false)) ? 1 : 0))))
          goto label_264;
label_260:
        num3 = 272;
        Left2 = 0.527f;
label_261:
        num3 = 273;
        Left3 = 54f;
label_262:
        num3 = 274;
        num7 = 39f;
label_263:
        num3 = 275;
        brush = (Brush) new SolidBrush(Color.FromArgb(168, 168, 168));
        goto label_284;
label_264:
        num3 = 277;
        if (!Conversions.ToBoolean((object) (bool) (!Conversions.ToBoolean(Operators.CompareObjectGreaterEqual(Left4, (object) 55, false)) ? 0 : (Conversions.ToBoolean(Operators.CompareObjectLessEqual(Left4, (object) 68, false)) ? 1 : 0))))
          goto label_269;
label_265:
        num3 = 278;
        Left2 = 0.427f;
label_266:
        num3 = 279;
        Left3 = 68f;
label_267:
        num3 = 280;
        num7 = 55f;
label_268:
        num3 = 281;
        brush = (Brush) new SolidBrush(Color.FromArgb(78, 132, 196));
        goto label_284;
label_269:
        num3 = 283;
        if (!Conversions.ToBoolean((object) (bool) (!Conversions.ToBoolean(Operators.CompareObjectGreaterEqual(Left4, (object) 69, false)) ? 0 : (Conversions.ToBoolean(Operators.CompareObjectLessEqual(Left4, (object) 80, false)) ? 1 : 0))))
          goto label_274;
label_270:
        num3 = 284;
        Left2 = 0.327f;
label_271:
        num3 = 285;
        Left3 = 80f;
label_272:
        num3 = 286;
        num7 = 69f;
label_273:
        num3 = 287;
        brush = (Brush) new SolidBrush(Color.FromArgb(115, 162, 214));
        goto label_284;
label_274:
        num3 = 289;
        if (!Conversions.ToBoolean((object) (bool) (!Conversions.ToBoolean(Operators.CompareObjectGreaterEqual(Left4, (object) 81, false)) ? 0 : (Conversions.ToBoolean(Operators.CompareObjectLessEqual(Left4, (object) 91, false)) ? 1 : 0))))
          goto label_279;
label_275:
        num3 = 290;
        Left2 = 0.227f;
label_276:
        num3 = 291;
        Left3 = 91f;
label_277:
        num3 = 292;
        num7 = 81f;
label_278:
        num3 = 293;
        brush = (Brush) new SolidBrush(Color.FromArgb(151, 192, 239));
        goto label_284;
label_279:
        num3 = 295;
        if (!Operators.ConditionalCompareObjectGreaterEqual(Left4, (object) 92, false))
          goto label_284;
label_280:
        num3 = 296;
        Left2 = 0.127f;
label_281:
        num3 = 297;
        Left3 = 100f;
label_282:
        num3 = 298;
        num7 = 92f;
label_283:
        num3 = 299;
        brush = (Brush) new SolidBrush(Color.FromArgb(205, 226, 245));
label_284:
label_285:
        num3 = 300;
        single = Conversions.ToSingle(Operators.MultiplyObject(Operators.AddObject((object) Left2, Operators.DivideObject(Operators.MultiplyObject((object) 0.086585, Operators.SubtractObject((object) Left3, Right2)), (object) (float) ((double) Left3 - (double) num7))), (object) num4));
label_286:
        num3 = 301;
        points[0].X = checked ((int) Math.Round(unchecked (0.853 * (double) width1)));
label_287:
        num3 = 302;
        points[0].Y = checked ((int) Math.Round((double) single));
label_288:
        num3 = 303;
        points[1].X = checked ((int) Math.Round(unchecked (0.887 * (double) width1)));
label_289:
        num3 = 304;
        points[1].Y = checked ((int) Math.Round(unchecked ((double) single - 0.0477 * (double) num4)));
label_290:
        num3 = 305;
        points[2].X = checked ((int) Math.Round(unchecked (0.992 * (double) width1)));
label_291:
        num3 = 306;
        points[2].Y = checked ((int) Math.Round(unchecked ((double) single - 0.0477 * (double) num4)));
label_292:
        num3 = 307;
        points[3].X = checked ((int) Math.Round(unchecked (0.992 * (double) width1)));
label_293:
        num3 = 308;
        points[3].Y = checked ((int) Math.Round(unchecked ((double) single + 0.0477 * (double) num4)));
label_294:
        num3 = 309;
        points[4].X = checked ((int) Math.Round(unchecked (0.887 * (double) width1)));
label_295:
        num3 = 310;
        points[4].Y = checked ((int) Math.Round(unchecked ((double) single + 0.0477 * (double) num4)));
label_296:
        num3 = 311;
        graphics2.FillPolygon(brush, points);
label_297:
        num3 = 312;
        num5 = checked ((int) Math.Round(unchecked (0.894 * (double) width1)));
label_298:
        num3 = 313;
        num6 = checked ((int) Math.Round(unchecked ((double) single - (double) graphics2.MeasureString("G", font1, 500).Height / 2.1)));
label_299:
        num3 = 314;
        path.AddString(Conversion.Str(RuntimeHelpers.GetObjectValue(Right2)), font1.FontFamily, 1, 84f, new Point(num5, num6), StringFormat.GenericTypographic);
label_300:
        num3 = 315;
        graphics2.FillPath(Brushes.White, path);
label_301:
        num3 = 316;
        graphics2.DrawPath(pen2, path);
label_302:
        graphics2 = (Graphics) null;
label_303:
        image1 = image1;
        goto label_309;
label_305:
        num2 = num3;
        switch (num1 > -2 ? num1 : 1)
        {
          case 1:
            int num8 = num2 + 1;
            num2 = 0;
            switch (num8)
            {
              case 1:
                goto label_2;
              case 2:
                goto label_3;
              case 3:
                goto label_4;
              case 4:
                goto label_5;
              case 5:
                goto label_6;
              case 6:
                goto label_7;
              case 7:
                goto label_8;
              case 8:
                goto label_9;
              case 9:
                goto label_10;
              case 10:
                goto label_11;
              case 11:
                goto label_12;
              case 12:
                goto label_13;
              case 13:
                goto label_14;
              case 14:
                goto label_15;
              case 15:
                goto label_16;
              case 16:
                goto label_17;
              case 17:
                goto label_18;
              case 18:
                goto label_19;
              case 19:
                goto label_20;
              case 20:
                goto label_21;
              case 21:
                goto label_22;
              case 22:
                goto label_23;
              case 23:
                goto label_24;
              case 24:
                goto label_25;
              case 25:
                goto label_26;
              case 26:
                goto label_27;
              case 27:
                goto label_28;
              case 28:
                goto label_29;
              case 29:
                goto label_30;
              case 30:
                goto label_31;
              case 31:
                goto label_32;
              case 32:
                goto label_33;
              case 33:
                goto label_34;
              case 34:
                goto label_35;
              case 35:
                goto label_36;
              case 36:
                goto label_37;
              case 37:
                goto label_38;
              case 38:
                goto label_39;
              case 39:
                goto label_40;
              case 40:
                goto label_41;
              case 41:
              case 52:
                goto label_52;
              case 42:
                goto label_42;
              case 43:
                goto label_43;
              case 44:
                goto label_44;
              case 45:
                goto label_45;
              case 46:
                goto label_46;
              case 47:
                goto label_47;
              case 48:
                goto label_48;
              case 49:
                goto label_49;
              case 50:
                goto label_50;
              case 51:
                goto label_51;
              case 53:
                goto label_53;
              case 54:
                goto label_54;
              case 55:
                goto label_55;
              case 56:
                goto label_56;
              case 57:
                goto label_57;
              case 58:
                goto label_58;
              case 59:
                goto label_59;
              case 60:
                goto label_60;
              case 61:
                goto label_61;
              case 62:
                goto label_62;
              case 63:
                goto label_63;
              case 64:
                goto label_64;
              case 65:
                goto label_65;
              case 66:
                goto label_66;
              case 67:
                goto label_67;
              case 68:
                goto label_68;
              case 69:
                goto label_69;
              case 70:
                goto label_70;
              case 71:
                goto label_71;
              case 72:
                goto label_72;
              case 73:
                goto label_73;
              case 74:
                goto label_74;
              case 75:
                goto label_75;
              case 76:
                goto label_76;
              case 77:
                goto label_77;
              case 78:
                goto label_78;
              case 79:
                goto label_79;
              case 80:
                goto label_80;
              case 81:
                goto label_81;
              case 82:
                goto label_82;
              case 83:
                goto label_83;
              case 84:
                goto label_84;
              case 85:
                goto label_85;
              case 86:
                goto label_86;
              case 87:
                goto label_87;
              case 88:
                goto label_88;
              case 89:
                goto label_89;
              case 90:
                goto label_90;
              case 91:
                goto label_91;
              case 92:
                goto label_92;
              case 93:
                goto label_93;
              case 94:
                goto label_94;
              case 95:
                goto label_95;
              case 96:
                goto label_96;
              case 97:
                goto label_97;
              case 98:
                goto label_98;
              case 99:
                goto label_99;
              case 100:
                goto label_100;
              case 101:
                goto label_101;
              case 102:
                goto label_102;
              case 103:
                goto label_103;
              case 104:
                goto label_104;
              case 105:
                goto label_105;
              case 106:
                goto label_106;
              case 107:
                goto label_107;
              case 108:
                goto label_108;
              case 109:
                goto label_109;
              case 110:
                goto label_110;
              case 111:
                goto label_111;
              case 112:
                goto label_112;
              case 113:
                goto label_113;
              case 114:
                goto label_114;
              case 115:
                goto label_115;
              case 116:
                goto label_116;
              case 117:
                goto label_117;
              case 118:
                goto label_118;
              case 119:
                goto label_119;
              case 120:
                goto label_120;
              case 121:
                goto label_121;
              case 122:
                goto label_122;
              case 123:
                goto label_123;
              case 124:
                goto label_124;
              case 125:
                goto label_125;
              case 126:
                goto label_126;
              case (int) sbyte.MaxValue:
                goto label_127;
              case 128:
                goto label_128;
              case 129:
                goto label_129;
              case 130:
                goto label_130;
              case 131:
                goto label_131;
              case 132:
                goto label_132;
              case 133:
                goto label_133;
              case 134:
                goto label_134;
              case 135:
                goto label_135;
              case 136:
                goto label_136;
              case 137:
                goto label_137;
              case 138:
                goto label_138;
              case 139:
                goto label_139;
              case 140:
                goto label_140;
              case 141:
                goto label_141;
              case 142:
                goto label_142;
              case 143:
                goto label_143;
              case 144:
                goto label_144;
              case 145:
                goto label_145;
              case 146:
                goto label_146;
              case 147:
                goto label_147;
              case 148:
                goto label_148;
              case 149:
                goto label_149;
              case 150:
                goto label_150;
              case 151:
                goto label_151;
              case 152:
                goto label_152;
              case 153:
                goto label_153;
              case 154:
                goto label_154;
              case 155:
                goto label_155;
              case 156:
                goto label_156;
              case 157:
                goto label_157;
              case 158:
                goto label_158;
              case 159:
                goto label_159;
              case 160:
                goto label_160;
              case 161:
                goto label_161;
              case 162:
                goto label_162;
              case 163:
                goto label_163;
              case 164:
              case 187:
                goto label_184;
              case 165:
                goto label_164;
              case 166:
                goto label_165;
              case 167:
                goto label_166;
              case 168:
                goto label_167;
              case 169:
                goto label_168;
              case 170:
              case 175:
                goto label_173;
              case 171:
                goto label_169;
              case 172:
                goto label_170;
              case 173:
                goto label_171;
              case 174:
                goto label_172;
              case 176:
                goto label_174;
              case 177:
                goto label_175;
              case 178:
                goto label_176;
              case 179:
                goto label_177;
              case 180:
                goto label_178;
              case 181:
                goto label_179;
              case 182:
                goto label_180;
              case 183:
              case 186:
                goto label_183;
              case 184:
                goto label_181;
              case 185:
                goto label_182;
              case 188:
                goto label_185;
              case 189:
                goto label_186;
              case 190:
                goto label_187;
              case 191:
                goto label_188;
              case 192:
                goto label_189;
              case 193:
                goto label_190;
              case 194:
                goto label_191;
              case 195:
                goto label_192;
              case 196:
              case 202:
              case 208:
              case 214:
              case 220:
              case 226:
              case 232:
                goto label_228;
              case 197:
                goto label_193;
              case 198:
                goto label_194;
              case 199:
                goto label_195;
              case 200:
                goto label_196;
              case 201:
                goto label_197;
              case 203:
                goto label_198;
              case 204:
                goto label_199;
              case 205:
                goto label_200;
              case 206:
                goto label_201;
              case 207:
                goto label_202;
              case 209:
                goto label_203;
              case 210:
                goto label_204;
              case 211:
                goto label_205;
              case 212:
                goto label_206;
              case 213:
                goto label_207;
              case 215:
                goto label_208;
              case 216:
                goto label_209;
              case 217:
                goto label_210;
              case 218:
                goto label_211;
              case 219:
                goto label_212;
              case 221:
                goto label_213;
              case 222:
                goto label_214;
              case 223:
                goto label_215;
              case 224:
                goto label_216;
              case 225:
                goto label_217;
              case 227:
                goto label_218;
              case 228:
                goto label_219;
              case 229:
                goto label_220;
              case 230:
                goto label_221;
              case 231:
                goto label_222;
              case 233:
                goto label_223;
              case 234:
                goto label_224;
              case 235:
                goto label_225;
              case 236:
                goto label_226;
              case 237:
                goto label_227;
              case 238:
                goto label_229;
              case 239:
                goto label_230;
              case 240:
                goto label_231;
              case 241:
                goto label_232;
              case 242:
                goto label_233;
              case 243:
                goto label_234;
              case 244:
                goto label_235;
              case 245:
                goto label_236;
              case 246:
                goto label_237;
              case 247:
                goto label_238;
              case 248:
                goto label_239;
              case 249:
                goto label_240;
              case 250:
                goto label_241;
              case 251:
                goto label_242;
              case 252:
                goto label_243;
              case 253:
                goto label_244;
              case 254:
                goto label_245;
              case (int) byte.MaxValue:
                goto label_246;
              case 256:
                goto label_247;
              case 257:
                goto label_248;
              case 258:
              case 264:
              case 270:
              case 276:
              case 282:
              case 288:
              case 294:
                goto label_284;
              case 259:
                goto label_249;
              case 260:
                goto label_250;
              case 261:
                goto label_251;
              case 262:
                goto label_252;
              case 263:
                goto label_253;
              case 265:
                goto label_254;
              case 266:
                goto label_255;
              case 267:
                goto label_256;
              case 268:
                goto label_257;
              case 269:
                goto label_258;
              case 271:
                goto label_259;
              case 272:
                goto label_260;
              case 273:
                goto label_261;
              case 274:
                goto label_262;
              case 275:
                goto label_263;
              case 277:
                goto label_264;
              case 278:
                goto label_265;
              case 279:
                goto label_266;
              case 280:
                goto label_267;
              case 281:
                goto label_268;
              case 283:
                goto label_269;
              case 284:
                goto label_270;
              case 285:
                goto label_271;
              case 286:
                goto label_272;
              case 287:
                goto label_273;
              case 289:
                goto label_274;
              case 290:
                goto label_275;
              case 291:
                goto label_276;
              case 292:
                goto label_277;
              case 293:
                goto label_278;
              case 295:
                goto label_279;
              case 296:
                goto label_280;
              case 297:
                goto label_281;
              case 298:
                goto label_282;
              case 299:
                goto label_283;
              case 300:
                goto label_285;
              case 301:
                goto label_286;
              case 302:
                goto label_287;
              case 303:
                goto label_288;
              case 304:
                goto label_289;
              case 305:
                goto label_290;
              case 306:
                goto label_291;
              case 307:
                goto label_292;
              case 308:
                goto label_293;
              case 309:
                goto label_294;
              case 310:
                goto label_295;
              case 311:
                goto label_296;
              case 312:
                goto label_297;
              case 313:
                goto label_298;
              case 314:
                goto label_299;
              case 315:
                goto label_300;
              case 316:
                goto label_301;
              case 317:
                goto label_302;
              case 318:
                goto label_303;
              case 319:
                goto label_309;
            }
            break;
        }
      }
      catch (Exception ex) when (ex is Exception & (uint) num1 > 0U & num2 == 0)
      {
        ProjectData.SetProjectError(ex);
        goto label_305;
      }
      throw ProjectData.CreateProjectError(-2146828237);
label_309:
      if (num2 != 0)
        ProjectData.ClearProjectError();
      return image1;
    }

    public Image DrawEnergyGraph(int Country, int House, int SAP, int PSAP)
    {
      int num1;
      Image image1;
      int num2;
      try
      {
label_2:
        ProjectData.ClearProjectError();
        num1 = -2;
label_3:
        int num3 = 2;
        int width1 = 1344;
label_4:
        num3 = 3;
        int num4 = 1088;
label_5:
        num3 = 4;
        Font font1 = new Font("Arial", 24f, FontStyle.Regular);
label_6:
        num3 = 5;
        image1 = (Image) new Bitmap(width1, num4);
label_7:
        num3 = 6;
        Graphics graphics1 = Graphics.FromImage(image1);
label_8:
        num3 = 7;
        Font font2 = new Font("Arial", 64f, FontStyle.Bold);
label_9:
        num3 = 8;
        Font font3 = new Font("Arial", 56f, FontStyle.Bold);
label_10:
        num3 = 9;
        Font font4 = new Font("Arial", 36f, FontStyle.Regular);
label_11:
        num3 = 10;
        Font font5 = new Font("Arial", 32f, FontStyle.Bold);
label_12:
        num3 = 11;
        Font font6 = new Font("Arial", 28f, FontStyle.Italic);
label_13:
        num3 = 12;
        Font font7 = new Font("Arial", 28f, FontStyle.Bold);
label_14:
        num3 = 13;
        Pen pen1 = (Pen) Pens.Black.Clone();
label_15:
        num3 = 14;
        pen1.Width = 5f;
label_16:
        num3 = 15;
        Pen pen2 = (Pen) Pens.Black.Clone();
label_17:
        num3 = 16;
        pen2.Width = 3f;
label_18:
        num3 = 17;
        Pen pen3 = new Pen(Color.Black, 2f);
label_19:
        num3 = 18;
        Graphics graphics2 = graphics1;
label_20:
        num3 = 19;
        graphics2.TextRenderingHint = TextRenderingHint.AntiAlias;
label_21:
        num3 = 20;
        graphics2.SmoothingMode = SmoothingMode.AntiAlias;
label_22:
        num3 = 21;
        graphics1.FillRectangle(Brushes.White, 0, 0, width1, num4);
label_23:
        num3 = 22;
        graphics2.DrawLine(pen1, 1, 1, checked (width1 - 1), 1);
label_24:
        num3 = 23;
        graphics2.DrawLine(pen1, checked (width1 - 1), 1, checked (width1 - 1), checked (num4 - 1));
label_25:
        num3 = 24;
        graphics2.DrawLine(pen1, checked (width1 - 1), checked (num4 - 1), 1, checked (num4 - 1));
label_26:
        num3 = 25;
        graphics2.DrawLine(pen1, 1, checked (num4 - 1), 1, 1);
label_27:
        num3 = 26;
        int num5 = checked ((int) Math.Round(unchecked (0.688 * (double) width1)));
label_28:
        num3 = 27;
        int num6 = checked ((int) Math.Round(unchecked (0.885 * (double) num4)));
label_29:
        num3 = 28;
        graphics2.DrawLine(pen1, num5, num6, num5, 1);
label_30:
        num3 = 29;
        num5 = checked ((int) Math.Round(unchecked (0.845 * (double) width1)));
label_31:
        num3 = 30;
        graphics2.DrawLine(pen1, num5, num6, num5, 1);
label_32:
        num3 = 31;
        if (!(Country == 2 & Operators.CompareString(SAP_Module.Proj.Dwellings[House].EPCLanguage, "Welsh", false) == 0))
          goto label_42;
label_33:
        num3 = 32;
        num5 = checked ((int) Math.Round(unchecked (0.766 * (double) width1 - (double) graphics2.MeasureString("Cyfredol", font5, 500).Width / 2.0)));
label_34:
        num3 = 33;
        num6 = checked ((int) Math.Round(unchecked (0.2 * (double) font5.GetHeight())));
label_35:
        num3 = 34;
        graphics2.DrawString("Cyfredol", font5, Brushes.Black, (float) num5, (float) num6);
label_36:
        num3 = 35;
        num5 = checked ((int) Math.Round(unchecked (0.921 * (double) width1 - (double) graphics2.MeasureString("Potensial", font5, 500).Width / 2.0)));
label_37:
        num3 = 36;
        num6 = checked ((int) Math.Round(unchecked (0.2 * (double) font5.GetHeight())));
label_38:
        num3 = 37;
        graphics2.DrawString("Potensial", font5, Brushes.Black, (float) num5, (float) num6);
label_39:
        num3 = 38;
        num5 = checked ((int) Math.Round(unchecked (0.02 * (double) width1)));
label_40:
        num3 = 39;
        num6 = checked ((int) Math.Round(unchecked (1.6 * (double) font5.GetHeight())));
label_41:
        num3 = 40;
        graphics2.DrawString("Effeithlon iawn o ran ynni – costau rhedeg is", font6, Brushes.Black, (float) num5, (float) num6);
        goto label_52;
label_42:
        num3 = 42;
        num5 = checked ((int) Math.Round(unchecked (0.766 * (double) width1 - (double) graphics2.MeasureString("Current", font5, 500).Width / 2.0)));
label_43:
        num3 = 43;
        num6 = checked ((int) Math.Round(unchecked (0.2 * (double) font5.GetHeight())));
label_44:
        num3 = 44;
        graphics2.DrawString("Current", font5, Brushes.Black, (float) num5, (float) num6);
label_45:
        num3 = 45;
        num5 = checked ((int) Math.Round(unchecked (0.921 * (double) width1 - (double) graphics2.MeasureString("Potential", font5, 500).Width / 2.0)));
label_46:
        num3 = 46;
        num6 = checked ((int) Math.Round(unchecked (0.2 * (double) font5.GetHeight())));
label_47:
        num3 = 47;
        graphics2.DrawString("Potential", font5, Brushes.Black, (float) num5, (float) num6);
label_48:
        num3 = 48;
        num5 = checked ((int) Math.Round(unchecked (0.02 * (double) width1)));
label_49:
        num3 = 49;
        num6 = checked ((int) Math.Round(unchecked (1.6 * (double) font5.GetHeight())));
label_50:
        num3 = 50;
        graphics2.DrawString("Very energy efficient - lower running costs", font6, Brushes.Black, (float) num5, (float) num6);
label_51:
label_52:
        num3 = 52;
        num6 = checked ((int) Math.Round(unchecked (0.063 * (double) num4)));
label_53:
        num3 = 53;
        graphics2.DrawLine(pen1, 1, num6, checked (width1 - 1), num6);
label_54:
        num3 = 54;
        Brush brush = (Brush) new SolidBrush(Color.FromArgb(0, (int) sbyte.MaxValue, 61));
label_55:
        num3 = 55;
        num5 = checked ((int) Math.Round(unchecked (0.01 * (double) width1)));
label_56:
        num3 = 56;
        num6 = checked ((int) Math.Round(unchecked (0.127 * (double) num4)));
label_57:
        num3 = 57;
        int width2 = checked ((int) Math.Round(unchecked (0.221 * (double) width1)));
label_58:
        num3 = 58;
        int height = checked ((int) Math.Round(unchecked (0.086585 * (double) num4)));
label_59:
        num3 = 59;
        graphics2.FillRectangle(brush, num5, num6, width2, height);
label_60:
        num3 = 60;
        num6 = checked ((int) Math.Round(unchecked ((double) num6 + (double) height / 2.0 - (double) graphics2.MeasureString("()", font7, 500).Height / 2.0)));
label_61:
        num3 = 61;
        num5 = checked ((int) Math.Round(unchecked (0.025 * (double) width1)));
label_62:
        num3 = 62;
        graphics2.DrawString("(92 plus)", font7, Brushes.White, (float) num5, (float) num6);
label_63:
        num3 = 63;
        num5 = checked ((int) Math.Round(unchecked (0.158 * (double) width1)));
label_64:
        num3 = 64;
        num6 = checked ((int) Math.Round(unchecked (0.127 * (double) num4 + (double) height / 2.0 - (double) graphics2.MeasureString("A", font2, 900).Height / 2.1)));
label_65:
        num3 = 65;
        GraphicsPath path = new GraphicsPath();
label_66:
        num3 = 66;
        path.AddString("A", font2.FontFamily, 1, 84f, new Point(num5, num6), StringFormat.GenericTypographic);
label_67:
        num3 = 67;
        graphics2.FillPath(Brushes.White, path);
label_68:
        num3 = 68;
        graphics2.DrawPath(pen2, path);
label_69:
        num3 = 69;
        num5 = checked ((int) Math.Round(unchecked (0.01 * (double) width1)));
label_70:
        num3 = 70;
        brush = (Brush) new SolidBrush(Color.FromArgb(44, 159, 41));
label_71:
        num3 = 71;
        num6 = checked ((int) Math.Round(unchecked (0.227 * (double) num4)));
label_72:
        num3 = 72;
        width2 = checked ((int) Math.Round(unchecked (0.295 * (double) width1)));
label_73:
        num3 = 73;
        graphics2.FillRectangle(brush, num5, num6, width2, height);
label_74:
        num3 = 74;
        num6 = checked ((int) Math.Round(unchecked ((double) num6 + (double) height / 2.0 - (double) graphics2.MeasureString("()", font7, 900).Height / 2.0)));
label_75:
        num3 = 75;
        num5 = checked ((int) Math.Round(unchecked (0.025 * (double) width1)));
label_76:
        num3 = 76;
        graphics2.DrawString("(81-91)", font7, Brushes.White, (float) num5, (float) num6);
label_77:
        num3 = 77;
        num5 = checked ((int) Math.Round(unchecked (0.239 * (double) width1)));
label_78:
        num3 = 78;
        num6 = checked ((int) Math.Round(unchecked (0.227 * (double) num4 + (double) height / 2.0 - (double) graphics2.MeasureString("B", font2, 500).Height / 2.1)));
label_79:
        num3 = 79;
        path.AddString("B", font2.FontFamily, 1, 84f, new Point(num5, num6), StringFormat.GenericTypographic);
label_80:
        num3 = 80;
        graphics2.FillPath(Brushes.White, path);
label_81:
        num3 = 81;
        graphics2.DrawPath(pen2, path);
label_82:
        num3 = 82;
        num5 = checked ((int) Math.Round(unchecked (0.01 * (double) width1)));
label_83:
        num3 = 83;
        brush = (Brush) new SolidBrush(Color.FromArgb(157, 203, 60));
label_84:
        num3 = 84;
        num6 = checked ((int) Math.Round(unchecked (0.327 * (double) num4)));
label_85:
        num3 = 85;
        width2 = checked ((int) Math.Round(unchecked (0.37 * (double) width1)));
label_86:
        num3 = 86;
        graphics2.FillRectangle(brush, num5, num6, width2, height);
label_87:
        num3 = 87;
        num6 = checked ((int) Math.Round(unchecked ((double) num6 + (double) height / 2.0 - (double) graphics2.MeasureString("()", font7, 900).Height / 2.0)));
label_88:
        num3 = 88;
        num5 = checked ((int) Math.Round(unchecked (0.025 * (double) width1)));
label_89:
        num3 = 89;
        graphics2.DrawString("(69-80)", font7, Brushes.Black, (float) num5, (float) num6);
label_90:
        num3 = 90;
        num5 = checked ((int) Math.Round(unchecked (0.307 * (double) width1)));
label_91:
        num3 = 91;
        num6 = checked ((int) Math.Round(unchecked (0.327 * (double) num4 + (double) height / 2.0 - (double) graphics2.MeasureString("C", font2, 500).Height / 2.1)));
label_92:
        num3 = 92;
        path.AddString("C", font2.FontFamily, 1, 84f, new Point(num5, num6), StringFormat.GenericTypographic);
label_93:
        num3 = 93;
        graphics2.FillPath(Brushes.White, path);
label_94:
        num3 = 94;
        graphics2.DrawPath(pen2, path);
label_95:
        num3 = 95;
        num5 = checked ((int) Math.Round(unchecked (0.01 * (double) width1)));
label_96:
        num3 = 96;
        brush = (Brush) new SolidBrush(Color.FromArgb((int) byte.MaxValue, 242, 0));
label_97:
        num3 = 97;
        num6 = checked ((int) Math.Round(unchecked (0.427 * (double) num4)));
label_98:
        num3 = 98;
        width2 = checked ((int) Math.Round(unchecked (0.445 * (double) width1)));
label_99:
        num3 = 99;
        graphics2.FillRectangle(brush, num5, num6, width2, height);
label_100:
        num3 = 100;
        num6 = checked ((int) Math.Round(unchecked ((double) num6 + (double) height / 2.0 - (double) graphics2.MeasureString("()", font7, 900).Height / 2.0)));
label_101:
        num3 = 101;
        num5 = checked ((int) Math.Round(unchecked (0.025 * (double) width1)));
label_102:
        num3 = 102;
        graphics2.DrawString("(55-68)", font7, Brushes.Black, (float) num5, (float) num6);
label_103:
        num3 = 103;
        num5 = checked ((int) Math.Round(unchecked (0.387 * (double) width1)));
label_104:
        num3 = 104;
        num6 = checked ((int) Math.Round(unchecked (0.427 * (double) num4 + (double) height / 2.0 - (double) graphics2.MeasureString("D", font2, 500).Height / 2.1)));
label_105:
        num3 = 105;
        path.AddString("D", font2.FontFamily, 1, 84f, new Point(num5, num6), StringFormat.GenericTypographic);
label_106:
        num3 = 106;
        graphics2.FillPath(Brushes.White, path);
label_107:
        num3 = 107;
        graphics2.DrawPath(pen2, path);
label_108:
        num3 = 108;
        num5 = checked ((int) Math.Round(unchecked (0.01 * (double) width1)));
label_109:
        num3 = 109;
        brush = (Brush) new SolidBrush(Color.FromArgb(247, 175, 29));
label_110:
        num3 = 110;
        num6 = checked ((int) Math.Round(unchecked (0.527 * (double) num4)));
label_111:
        num3 = 111;
        width2 = checked ((int) Math.Round(unchecked (0.518 * (double) width1)));
label_112:
        num3 = 112;
        graphics2.FillRectangle(brush, num5, num6, width2, height);
label_113:
        num3 = 113;
        num6 = checked ((int) Math.Round(unchecked ((double) num6 + (double) height / 2.0 - (double) graphics2.MeasureString("()", font7, 900).Height / 2.0)));
label_114:
        num3 = 114;
        num5 = checked ((int) Math.Round(unchecked (0.025 * (double) width1)));
label_115:
        num3 = 115;
        graphics2.DrawString("(39-54)", font7, Brushes.Black, (float) num5, (float) num6);
label_116:
        num3 = 116;
        num5 = checked ((int) Math.Round(unchecked (0.459 * (double) width1)));
label_117:
        num3 = 117;
        num6 = checked ((int) Math.Round(unchecked (0.527 * (double) num4 + (double) height / 2.0 - (double) graphics2.MeasureString("E", font2, 500).Height / 2.1)));
label_118:
        num3 = 118;
        path.AddString("E", font2.FontFamily, 1, 84f, new Point(num5, num6), StringFormat.GenericTypographic);
label_119:
        num3 = 119;
        graphics2.FillPath(Brushes.White, path);
label_120:
        num3 = 120;
        graphics2.DrawPath(pen2, path);
label_121:
        num3 = 121;
        num5 = checked ((int) Math.Round(unchecked (0.01 * (double) width1)));
label_122:
        num3 = 122;
        brush = (Brush) new SolidBrush(Color.FromArgb(237, 104, 35));
label_123:
        num3 = 123;
        num6 = checked ((int) Math.Round(unchecked (0.627 * (double) num4)));
label_124:
        num3 = 124;
        width2 = checked ((int) Math.Round(unchecked (0.592 * (double) width1)));
label_125:
        num3 = 125;
        graphics2.FillRectangle(brush, num5, num6, width2, height);
label_126:
        num3 = 126;
        num6 = checked ((int) Math.Round(unchecked ((double) num6 + (double) height / 2.0 - (double) graphics2.MeasureString("()", font7, 900).Height / 2.0)));
label_127:
        num3 = (int) sbyte.MaxValue;
        num5 = checked ((int) Math.Round(unchecked (0.025 * (double) width1)));
label_128:
        num3 = 128;
        graphics2.DrawString("(21-38)", font7, Brushes.Black, (float) num5, (float) num6);
label_129:
        num3 = 129;
        num5 = checked ((int) Math.Round(unchecked (0.536 * (double) width1)));
label_130:
        num3 = 130;
        num6 = checked ((int) Math.Round(unchecked (0.627 * (double) num4 + (double) height / 2.0 - (double) graphics2.MeasureString("F", font2, 500).Height / 2.1)));
label_131:
        num3 = 131;
        path.AddString("F", font2.FontFamily, 1, 84f, new Point(num5, num6), StringFormat.GenericTypographic);
label_132:
        num3 = 132;
        graphics2.FillPath(Brushes.White, path);
label_133:
        num3 = 133;
        graphics2.DrawPath(pen2, path);
label_134:
        num3 = 134;
        num5 = checked ((int) Math.Round(unchecked (0.01 * (double) width1)));
label_135:
        num3 = 135;
        brush = (Brush) new SolidBrush(Color.FromArgb(227, 29, 35));
label_136:
        num3 = 136;
        num6 = checked ((int) Math.Round(unchecked (0.727 * (double) num4)));
label_137:
        num3 = 137;
        width2 = checked ((int) Math.Round(unchecked (0.668 * (double) width1)));
label_138:
        num3 = 138;
        graphics2.FillRectangle(brush, num5, num6, width2, height);
label_139:
        num3 = 139;
        num6 = checked ((int) Math.Round(unchecked ((double) num6 + (double) height / 2.0 - (double) graphics2.MeasureString("()", font7, 900).Height / 2.0)));
label_140:
        num3 = 140;
        num5 = checked ((int) Math.Round(unchecked (0.025 * (double) width1)));
label_141:
        num3 = 141;
        graphics2.DrawString("(1-20)", font7, Brushes.Black, (float) num5, (float) num6);
label_142:
        num3 = 142;
        num5 = checked ((int) Math.Round(unchecked (0.607 * (double) width1)));
label_143:
        num3 = 143;
        num6 = checked ((int) Math.Round(unchecked (0.727 * (double) num4 + (double) height / 2.0 - (double) graphics2.MeasureString("G", font2, 500).Height / 2.1)));
label_144:
        num3 = 144;
        path.AddString("G", font2.FontFamily, 1, 84f, new Point(num5, num6), StringFormat.GenericTypographic);
label_145:
        num3 = 145;
        graphics2.FillPath(Brushes.White, path);
label_146:
        num3 = 146;
        graphics2.DrawPath(pen2, path);
label_147:
        num3 = 147;
        num5 = checked ((int) Math.Round(unchecked (0.01 * (double) width1)));
label_148:
        num3 = 148;
        num6 = checked ((int) Math.Round(unchecked (0.885 * (double) num4)));
label_149:
        num3 = 149;
        graphics2.DrawLine(pen1, 1, num6, checked (width1 - 1), num6);
label_150:
        num3 = 150;
        num6 = checked ((int) Math.Round(unchecked ((0.885 * (double) num4 - (0.727 * (double) num4 + 0.086585 * (double) num4)) / 2.0 + (0.727 * (double) num4 + 0.086585 * (double) num4) - (double) graphics2.MeasureString("Potential", font6, 500).Height / 2.0)));
label_151:
        num3 = 151;
        num5 = checked ((int) Math.Round(unchecked (0.02 * (double) width1)));
label_152:
        num3 = 152;
        if (!(Country == 2 & Operators.CompareString(SAP_Module.Proj.Dwellings[House].EPCLanguage, "Welsh", false) == 0))
          goto label_164;
label_153:
        num3 = 153;
        graphics2.DrawString("Ddim yn effeithlon o ran ynni – costau rhedeg uwch", font6, Brushes.Black, (float) num5, (float) num6);
label_154:
        num3 = 154;
        num6 = checked ((int) Math.Round(unchecked (23.0 / 400.0 * (double) num4 + 0.885 * (double) num4 - 0.5 * (double) graphics2.MeasureString("Cymru a Lloegr", font3, 900).Height)));
label_155:
        num3 = 155;
        num5 = checked ((int) Math.Round(unchecked (0.025 * (double) width1)));
label_156:
        num3 = 156;
        graphics2.DrawString("Cymru a Lloegr", font3, Brushes.Black, (float) num5, (float) num6);
label_157:
        num3 = 157;
        num6 = checked ((int) Math.Round(unchecked (23.0 / 400.0 * (double) num4 + 0.885 * (double) num4 - (double) graphics2.MeasureString("Cyfarwyddeb 2002/91/EC", font1, 500).Height)));
label_158:
        num3 = 158;
        num5 = checked ((int) Math.Round(unchecked (0.59 * (double) width1)));
label_159:
        num3 = 159;
        graphics2.DrawString("Cyfarwyddeb 2002/91/EC", font1, Brushes.Black, (float) num5, (float) num6);
label_160:
        num3 = 160;
        num6 = checked ((int) Math.Round(unchecked (23.0 / 400.0 * (double) num4 + 0.885 * (double) num4)));
label_161:
        num3 = 161;
        num5 = checked ((int) Math.Round(unchecked (0.63 * (double) width1)));
label_162:
        num3 = 162;
        graphics2.DrawString("yr Undeb Ewropeaidd", font1, Brushes.Black, (float) num5, (float) num6);
label_163:
        num3 = 163;
        num6 = checked ((int) Math.Round(unchecked (23.0 / 400.0 * (double) num4 + 0.885 * (double) num4 - 0.52 * (double) graphics2.MeasureString("Cymru a Lloegr", font3, 900).Height)));
        goto label_184;
label_164:
        num3 = 165;
        graphics2.DrawString("Not energy efficient - higher running costs", font6, Brushes.Black, (float) num5, (float) num6);
label_165:
        num3 = 166;
        if (Country != 4)
          goto label_169;
label_166:
        num3 = 167;
        num6 = checked ((int) Math.Round(unchecked (23.0 / 400.0 * (double) num4 + 0.885 * (double) num4 - 0.5 * (double) graphics2.MeasureString("Scotland", font3, 900).Height)));
label_167:
        num3 = 168;
        num5 = checked ((int) Math.Round(unchecked (0.025 * (double) width1)));
label_168:
        num3 = 169;
        graphics2.DrawString("Scotland", font3, Brushes.Black, (float) num5, (float) num6);
        goto label_173;
label_169:
        num3 = 171;
        num6 = checked ((int) Math.Round(unchecked (23.0 / 400.0 * (double) num4 + 0.885 * (double) num4 - 0.5 * (double) graphics2.MeasureString("Scotland", font3, 900).Height)));
label_170:
        num3 = 172;
        num5 = checked ((int) Math.Round(unchecked (0.025 * (double) width1)));
label_171:
        num3 = 173;
        graphics2.DrawString("England & Wales", font3, Brushes.Black, (float) num5, (float) num6);
label_172:
label_173:
        num3 = 175;
        num6 = checked ((int) Math.Round(unchecked (23.0 / 400.0 * (double) num4 + 0.885 * (double) num4 - (double) graphics2.MeasureString("EU Directive", font4, 500).Height)));
label_174:
        num3 = 176;
        num5 = checked ((int) Math.Round(unchecked (0.66 * (double) width1)));
label_175:
        num3 = 177;
        graphics2.DrawString("EU Directive", font4, Brushes.Black, (float) num5, (float) num6);
label_176:
        num3 = 178;
        num6 = checked ((int) Math.Round(unchecked (23.0 / 400.0 * (double) num4 + 0.885 * (double) num4)));
label_177:
        num3 = 179;
        num5 = checked ((int) Math.Round(unchecked (0.66 * (double) width1)));
label_178:
        num3 = 180;
        graphics2.DrawString("2002/91/EC", font4, Brushes.Black, (float) num5, (float) num6);
label_179:
        num3 = 181;
        if (Country != 4)
          goto label_181;
label_180:
        num3 = 182;
        num6 = checked ((int) Math.Round(unchecked (23.0 / 400.0 * (double) num4 + 0.885 * (double) num4 - 0.52 * (double) graphics2.MeasureString("Scotland", font3, 900).Height)));
        goto label_183;
label_181:
        num3 = 184;
        num6 = checked ((int) Math.Round(unchecked (23.0 / 400.0 * (double) num4 + 0.885 * (double) num4 - 0.52 * (double) graphics2.MeasureString("England & Wales", font3, 900).Height)));
label_182:
label_183:
label_184:
        num3 = 187;
        num5 = checked ((int) Math.Round(unchecked (0.88 * (double) width1)));
label_185:
        num3 = 188;
        Image image2 = Image.FromFile(Application.StartupPath + "\\Resources\\EU.bmp");
label_186:
        num3 = 189;
        width2 = checked ((int) Math.Round(unchecked ((double) image2.Width / 2.75)));
label_187:
        num3 = 190;
        height = checked ((int) Math.Round(unchecked ((double) image2.Height / 2.75)));
label_188:
        num3 = 191;
        graphics2.DrawImage(image2, num5, num6, width2, height);
label_189:
        num3 = 192;
        Point[] points = new Point[5];
label_190:
        num3 = 193;
label_191:
        num3 = 194;
        object Right1 = (object) SAP;
label_192:
        num3 = 195;
        object Left1 = Right1;
label_193:
        num3 = 197;
        if (!Conversions.ToBoolean((object) (bool) (!Conversions.ToBoolean(Operators.CompareObjectGreaterEqual(Left1, (object) 1, false)) ? 0 : (Conversions.ToBoolean(Operators.CompareObjectLessEqual(Left1, (object) 20, false)) ? 1 : 0))))
          goto label_198;
label_194:
        num3 = 198;
        float Left2 = 0.727f;
label_195:
        num3 = 199;
        float Left3 = 20f;
label_196:
        num3 = 200;
        float num7 = 1f;
label_197:
        num3 = 201;
        brush = (Brush) new SolidBrush(Color.FromArgb(227, 29, 35));
        goto label_228;
label_198:
        num3 = 203;
        if (!Conversions.ToBoolean((object) (bool) (!Conversions.ToBoolean(Operators.CompareObjectGreaterEqual(Left1, (object) 21, false)) ? 0 : (Conversions.ToBoolean(Operators.CompareObjectLessEqual(Left1, (object) 38, false)) ? 1 : 0))))
          goto label_203;
label_199:
        num3 = 204;
        Left2 = 0.627f;
label_200:
        num3 = 205;
        Left3 = 38f;
label_201:
        num3 = 206;
        num7 = 21f;
label_202:
        num3 = 207;
        brush = (Brush) new SolidBrush(Color.FromArgb(237, 104, 35));
        goto label_228;
label_203:
        num3 = 209;
        if (!Conversions.ToBoolean((object) (bool) (!Conversions.ToBoolean(Operators.CompareObjectGreaterEqual(Left1, (object) 39, false)) ? 0 : (Conversions.ToBoolean(Operators.CompareObjectLessEqual(Left1, (object) 54, false)) ? 1 : 0))))
          goto label_208;
label_204:
        num3 = 210;
        Left2 = 0.527f;
label_205:
        num3 = 211;
        Left3 = 54f;
label_206:
        num3 = 212;
        num7 = 39f;
label_207:
        num3 = 213;
        brush = (Brush) new SolidBrush(Color.FromArgb(247, 175, 29));
        goto label_228;
label_208:
        num3 = 215;
        if (!Conversions.ToBoolean((object) (bool) (!Conversions.ToBoolean(Operators.CompareObjectGreaterEqual(Left1, (object) 55, false)) ? 0 : (Conversions.ToBoolean(Operators.CompareObjectLessEqual(Left1, (object) 68, false)) ? 1 : 0))))
          goto label_213;
label_209:
        num3 = 216;
        Left2 = 0.427f;
label_210:
        num3 = 217;
        Left3 = 68f;
label_211:
        num3 = 218;
        num7 = 55f;
label_212:
        num3 = 219;
        brush = (Brush) new SolidBrush(Color.FromArgb((int) byte.MaxValue, 242, 0));
        goto label_228;
label_213:
        num3 = 221;
        if (!Conversions.ToBoolean((object) (bool) (!Conversions.ToBoolean(Operators.CompareObjectGreaterEqual(Left1, (object) 69, false)) ? 0 : (Conversions.ToBoolean(Operators.CompareObjectLessEqual(Left1, (object) 80, false)) ? 1 : 0))))
          goto label_218;
label_214:
        num3 = 222;
        Left2 = 0.327f;
label_215:
        num3 = 223;
        Left3 = 80f;
label_216:
        num3 = 224;
        num7 = 69f;
label_217:
        num3 = 225;
        brush = (Brush) new SolidBrush(Color.FromArgb(157, 203, 60));
        goto label_228;
label_218:
        num3 = 227;
        if (!Conversions.ToBoolean((object) (bool) (!Conversions.ToBoolean(Operators.CompareObjectGreaterEqual(Left1, (object) 81, false)) ? 0 : (Conversions.ToBoolean(Operators.CompareObjectLessEqual(Left1, (object) 91, false)) ? 1 : 0))))
          goto label_223;
label_219:
        num3 = 228;
        Left2 = 0.227f;
label_220:
        num3 = 229;
        Left3 = 91f;
label_221:
        num3 = 230;
        num7 = 81f;
label_222:
        num3 = 231;
        brush = (Brush) new SolidBrush(Color.FromArgb(44, 159, 41));
        goto label_228;
label_223:
        num3 = 233;
        if (!Operators.ConditionalCompareObjectGreaterEqual(Left1, (object) 92, false))
          goto label_228;
label_224:
        num3 = 234;
        Left2 = 0.127f;
label_225:
        num3 = 235;
        Left3 = 100f;
label_226:
        num3 = 236;
        num7 = 92f;
label_227:
        num3 = 237;
        brush = (Brush) new SolidBrush(Color.FromArgb(0, (int) sbyte.MaxValue, 61));
label_228:
label_229:
        num3 = 238;
        float single = Conversions.ToSingle(Operators.MultiplyObject(Operators.AddObject((object) Left2, Operators.DivideObject(Operators.MultiplyObject((object) 0.086585, Operators.SubtractObject((object) Left3, Right1)), (object) (float) ((double) Left3 - (double) num7))), (object) num4));
label_230:
        num3 = 239;
        points[0].X = checked ((int) Math.Round(unchecked (0.693 * (double) width1)));
label_231:
        num3 = 240;
        points[0].Y = checked ((int) Math.Round((double) single));
label_232:
        num3 = 241;
        points[1].X = checked ((int) Math.Round(unchecked (0.729 * (double) width1)));
label_233:
        num3 = 242;
        points[1].Y = checked ((int) Math.Round(unchecked ((double) single - 0.0477 * (double) num4)));
label_234:
        num3 = 243;
        points[2].X = checked ((int) Math.Round(unchecked (0.839 * (double) width1)));
label_235:
        num3 = 244;
        points[2].Y = checked ((int) Math.Round(unchecked ((double) single - 0.0477 * (double) num4)));
label_236:
        num3 = 245;
        points[3].X = checked ((int) Math.Round(unchecked (0.839 * (double) width1)));
label_237:
        num3 = 246;
        points[3].Y = checked ((int) Math.Round(unchecked ((double) single + 0.0477 * (double) num4)));
label_238:
        num3 = 247;
        points[4].X = checked ((int) Math.Round(unchecked (0.729 * (double) width1)));
label_239:
        num3 = 248;
        points[4].Y = checked ((int) Math.Round(unchecked ((double) single + 0.0477 * (double) num4)));
label_240:
        num3 = 249;
        graphics2.FillPolygon(brush, points);
label_241:
        num3 = 250;
        num5 = checked ((int) Math.Round(unchecked (0.738 * (double) width1)));
label_242:
        num3 = 251;
        num6 = checked ((int) Math.Round(unchecked ((double) single - (double) graphics2.MeasureString("G", font2, 500).Height / 2.1)));
label_243:
        num3 = 252;
        path.AddString(Conversion.Str(RuntimeHelpers.GetObjectValue(Right1)), font2.FontFamily, 1, 84f, new Point(num5, num6), StringFormat.GenericTypographic);
label_244:
        num3 = 253;
        graphics2.FillPath(Brushes.White, path);
label_245:
        num3 = 254;
        graphics2.DrawPath(pen2, path);
label_246:
        num3 = (int) byte.MaxValue;
        object Right2 = (object) PSAP;
label_247:
        num3 = 256;
        object Left4 = Right2;
label_248:
        num3 = 258;
        if (!Conversions.ToBoolean((object) (bool) (!Conversions.ToBoolean(Operators.CompareObjectGreaterEqual(Left4, (object) 1, false)) ? 0 : (Conversions.ToBoolean(Operators.CompareObjectLessEqual(Left4, (object) 20, false)) ? 1 : 0))))
          goto label_253;
label_249:
        num3 = 259;
        Left2 = 0.727f;
label_250:
        num3 = 260;
        Left3 = 20f;
label_251:
        num3 = 261;
        num7 = 1f;
label_252:
        num3 = 262;
        brush = (Brush) new SolidBrush(Color.FromArgb(227, 29, 35));
        goto label_283;
label_253:
        num3 = 264;
        if (!Conversions.ToBoolean((object) (bool) (!Conversions.ToBoolean(Operators.CompareObjectGreaterEqual(Left4, (object) 21, false)) ? 0 : (Conversions.ToBoolean(Operators.CompareObjectLessEqual(Left4, (object) 38, false)) ? 1 : 0))))
          goto label_258;
label_254:
        num3 = 265;
        Left2 = 0.627f;
label_255:
        num3 = 266;
        Left3 = 38f;
label_256:
        num3 = 267;
        num7 = 21f;
label_257:
        num3 = 268;
        brush = (Brush) new SolidBrush(Color.FromArgb(237, 104, 35));
        goto label_283;
label_258:
        num3 = 270;
        if (!Conversions.ToBoolean((object) (bool) (!Conversions.ToBoolean(Operators.CompareObjectGreaterEqual(Left4, (object) 39, false)) ? 0 : (Conversions.ToBoolean(Operators.CompareObjectLessEqual(Left4, (object) 54, false)) ? 1 : 0))))
          goto label_263;
label_259:
        num3 = 271;
        Left2 = 0.527f;
label_260:
        num3 = 272;
        Left3 = 54f;
label_261:
        num3 = 273;
        num7 = 39f;
label_262:
        num3 = 274;
        brush = (Brush) new SolidBrush(Color.FromArgb(247, 175, 29));
        goto label_283;
label_263:
        num3 = 276;
        if (!Conversions.ToBoolean((object) (bool) (!Conversions.ToBoolean(Operators.CompareObjectGreaterEqual(Left4, (object) 55, false)) ? 0 : (Conversions.ToBoolean(Operators.CompareObjectLessEqual(Left4, (object) 68, false)) ? 1 : 0))))
          goto label_268;
label_264:
        num3 = 277;
        Left2 = 0.427f;
label_265:
        num3 = 278;
        Left3 = 68f;
label_266:
        num3 = 279;
        num7 = 55f;
label_267:
        num3 = 280;
        brush = (Brush) new SolidBrush(Color.FromArgb((int) byte.MaxValue, 242, 0));
        goto label_283;
label_268:
        num3 = 282;
        if (!Conversions.ToBoolean((object) (bool) (!Conversions.ToBoolean(Operators.CompareObjectGreaterEqual(Left4, (object) 69, false)) ? 0 : (Conversions.ToBoolean(Operators.CompareObjectLessEqual(Left4, (object) 80, false)) ? 1 : 0))))
          goto label_273;
label_269:
        num3 = 283;
        Left2 = 0.327f;
label_270:
        num3 = 284;
        Left3 = 80f;
label_271:
        num3 = 285;
        num7 = 69f;
label_272:
        num3 = 286;
        brush = (Brush) new SolidBrush(Color.FromArgb(157, 203, 60));
        goto label_283;
label_273:
        num3 = 288;
        if (!Conversions.ToBoolean((object) (bool) (!Conversions.ToBoolean(Operators.CompareObjectGreaterEqual(Left4, (object) 81, false)) ? 0 : (Conversions.ToBoolean(Operators.CompareObjectLessEqual(Left4, (object) 91, false)) ? 1 : 0))))
          goto label_278;
label_274:
        num3 = 289;
        Left2 = 0.227f;
label_275:
        num3 = 290;
        Left3 = 91f;
label_276:
        num3 = 291;
        num7 = 81f;
label_277:
        num3 = 292;
        brush = (Brush) new SolidBrush(Color.FromArgb(44, 159, 41));
        goto label_283;
label_278:
        num3 = 294;
        if (!Operators.ConditionalCompareObjectGreaterEqual(Left4, (object) 92, false))
          goto label_283;
label_279:
        num3 = 295;
        Left2 = 0.127f;
label_280:
        num3 = 296;
        Left3 = 100f;
label_281:
        num3 = 297;
        num7 = 92f;
label_282:
        num3 = 298;
        brush = (Brush) new SolidBrush(Color.FromArgb(0, (int) sbyte.MaxValue, 61));
label_283:
label_284:
        num3 = 299;
        single = Conversions.ToSingle(Operators.MultiplyObject(Operators.AddObject((object) Left2, Operators.DivideObject(Operators.MultiplyObject((object) 0.086585, Operators.SubtractObject((object) Left3, Right2)), (object) (float) ((double) Left3 - (double) num7))), (object) num4));
label_285:
        num3 = 300;
        points[0].X = checked ((int) Math.Round(unchecked (0.853 * (double) width1)));
label_286:
        num3 = 301;
        points[0].Y = checked ((int) Math.Round((double) single));
label_287:
        num3 = 302;
        points[1].X = checked ((int) Math.Round(unchecked (0.887 * (double) width1)));
label_288:
        num3 = 303;
        points[1].Y = checked ((int) Math.Round(unchecked ((double) single - 0.0477 * (double) num4)));
label_289:
        num3 = 304;
        points[2].X = checked ((int) Math.Round(unchecked (0.992 * (double) width1)));
label_290:
        num3 = 305;
        points[2].Y = checked ((int) Math.Round(unchecked ((double) single - 0.0477 * (double) num4)));
label_291:
        num3 = 306;
        points[3].X = checked ((int) Math.Round(unchecked (0.992 * (double) width1)));
label_292:
        num3 = 307;
        points[3].Y = checked ((int) Math.Round(unchecked ((double) single + 0.0477 * (double) num4)));
label_293:
        num3 = 308;
        points[4].X = checked ((int) Math.Round(unchecked (0.887 * (double) width1)));
label_294:
        num3 = 309;
        points[4].Y = checked ((int) Math.Round(unchecked ((double) single + 0.0477 * (double) num4)));
label_295:
        num3 = 310;
        graphics2.FillPolygon(brush, points);
label_296:
        num3 = 311;
        num5 = checked ((int) Math.Round(unchecked (0.894 * (double) width1)));
label_297:
        num3 = 312;
        num6 = checked ((int) Math.Round(unchecked ((double) single - (double) graphics2.MeasureString("G", font2, 500).Height / 2.1)));
label_298:
        num3 = 313;
        path.AddString(Conversion.Str(RuntimeHelpers.GetObjectValue(Right2)), font2.FontFamily, 1, 84f, new Point(num5, num6), StringFormat.GenericTypographic);
label_299:
        num3 = 314;
        graphics2.FillPath(Brushes.White, path);
label_300:
        num3 = 315;
        graphics2.DrawPath(pen2, path);
label_301:
        graphics2 = (Graphics) null;
label_302:
        image1 = image1;
        goto label_308;
label_304:
        num2 = num3;
        switch (num1 > -2 ? num1 : 1)
        {
          case 1:
            int num8 = num2 + 1;
            num2 = 0;
            switch (num8)
            {
              case 1:
                goto label_2;
              case 2:
                goto label_3;
              case 3:
                goto label_4;
              case 4:
                goto label_5;
              case 5:
                goto label_6;
              case 6:
                goto label_7;
              case 7:
                goto label_8;
              case 8:
                goto label_9;
              case 9:
                goto label_10;
              case 10:
                goto label_11;
              case 11:
                goto label_12;
              case 12:
                goto label_13;
              case 13:
                goto label_14;
              case 14:
                goto label_15;
              case 15:
                goto label_16;
              case 16:
                goto label_17;
              case 17:
                goto label_18;
              case 18:
                goto label_19;
              case 19:
                goto label_20;
              case 20:
                goto label_21;
              case 21:
                goto label_22;
              case 22:
                goto label_23;
              case 23:
                goto label_24;
              case 24:
                goto label_25;
              case 25:
                goto label_26;
              case 26:
                goto label_27;
              case 27:
                goto label_28;
              case 28:
                goto label_29;
              case 29:
                goto label_30;
              case 30:
                goto label_31;
              case 31:
                goto label_32;
              case 32:
                goto label_33;
              case 33:
                goto label_34;
              case 34:
                goto label_35;
              case 35:
                goto label_36;
              case 36:
                goto label_37;
              case 37:
                goto label_38;
              case 38:
                goto label_39;
              case 39:
                goto label_40;
              case 40:
                goto label_41;
              case 41:
              case 52:
                goto label_52;
              case 42:
                goto label_42;
              case 43:
                goto label_43;
              case 44:
                goto label_44;
              case 45:
                goto label_45;
              case 46:
                goto label_46;
              case 47:
                goto label_47;
              case 48:
                goto label_48;
              case 49:
                goto label_49;
              case 50:
                goto label_50;
              case 51:
                goto label_51;
              case 53:
                goto label_53;
              case 54:
                goto label_54;
              case 55:
                goto label_55;
              case 56:
                goto label_56;
              case 57:
                goto label_57;
              case 58:
                goto label_58;
              case 59:
                goto label_59;
              case 60:
                goto label_60;
              case 61:
                goto label_61;
              case 62:
                goto label_62;
              case 63:
                goto label_63;
              case 64:
                goto label_64;
              case 65:
                goto label_65;
              case 66:
                goto label_66;
              case 67:
                goto label_67;
              case 68:
                goto label_68;
              case 69:
                goto label_69;
              case 70:
                goto label_70;
              case 71:
                goto label_71;
              case 72:
                goto label_72;
              case 73:
                goto label_73;
              case 74:
                goto label_74;
              case 75:
                goto label_75;
              case 76:
                goto label_76;
              case 77:
                goto label_77;
              case 78:
                goto label_78;
              case 79:
                goto label_79;
              case 80:
                goto label_80;
              case 81:
                goto label_81;
              case 82:
                goto label_82;
              case 83:
                goto label_83;
              case 84:
                goto label_84;
              case 85:
                goto label_85;
              case 86:
                goto label_86;
              case 87:
                goto label_87;
              case 88:
                goto label_88;
              case 89:
                goto label_89;
              case 90:
                goto label_90;
              case 91:
                goto label_91;
              case 92:
                goto label_92;
              case 93:
                goto label_93;
              case 94:
                goto label_94;
              case 95:
                goto label_95;
              case 96:
                goto label_96;
              case 97:
                goto label_97;
              case 98:
                goto label_98;
              case 99:
                goto label_99;
              case 100:
                goto label_100;
              case 101:
                goto label_101;
              case 102:
                goto label_102;
              case 103:
                goto label_103;
              case 104:
                goto label_104;
              case 105:
                goto label_105;
              case 106:
                goto label_106;
              case 107:
                goto label_107;
              case 108:
                goto label_108;
              case 109:
                goto label_109;
              case 110:
                goto label_110;
              case 111:
                goto label_111;
              case 112:
                goto label_112;
              case 113:
                goto label_113;
              case 114:
                goto label_114;
              case 115:
                goto label_115;
              case 116:
                goto label_116;
              case 117:
                goto label_117;
              case 118:
                goto label_118;
              case 119:
                goto label_119;
              case 120:
                goto label_120;
              case 121:
                goto label_121;
              case 122:
                goto label_122;
              case 123:
                goto label_123;
              case 124:
                goto label_124;
              case 125:
                goto label_125;
              case 126:
                goto label_126;
              case (int) sbyte.MaxValue:
                goto label_127;
              case 128:
                goto label_128;
              case 129:
                goto label_129;
              case 130:
                goto label_130;
              case 131:
                goto label_131;
              case 132:
                goto label_132;
              case 133:
                goto label_133;
              case 134:
                goto label_134;
              case 135:
                goto label_135;
              case 136:
                goto label_136;
              case 137:
                goto label_137;
              case 138:
                goto label_138;
              case 139:
                goto label_139;
              case 140:
                goto label_140;
              case 141:
                goto label_141;
              case 142:
                goto label_142;
              case 143:
                goto label_143;
              case 144:
                goto label_144;
              case 145:
                goto label_145;
              case 146:
                goto label_146;
              case 147:
                goto label_147;
              case 148:
                goto label_148;
              case 149:
                goto label_149;
              case 150:
                goto label_150;
              case 151:
                goto label_151;
              case 152:
                goto label_152;
              case 153:
                goto label_153;
              case 154:
                goto label_154;
              case 155:
                goto label_155;
              case 156:
                goto label_156;
              case 157:
                goto label_157;
              case 158:
                goto label_158;
              case 159:
                goto label_159;
              case 160:
                goto label_160;
              case 161:
                goto label_161;
              case 162:
                goto label_162;
              case 163:
                goto label_163;
              case 164:
              case 187:
                goto label_184;
              case 165:
                goto label_164;
              case 166:
                goto label_165;
              case 167:
                goto label_166;
              case 168:
                goto label_167;
              case 169:
                goto label_168;
              case 170:
              case 175:
                goto label_173;
              case 171:
                goto label_169;
              case 172:
                goto label_170;
              case 173:
                goto label_171;
              case 174:
                goto label_172;
              case 176:
                goto label_174;
              case 177:
                goto label_175;
              case 178:
                goto label_176;
              case 179:
                goto label_177;
              case 180:
                goto label_178;
              case 181:
                goto label_179;
              case 182:
                goto label_180;
              case 183:
              case 186:
                goto label_183;
              case 184:
                goto label_181;
              case 185:
                goto label_182;
              case 188:
                goto label_185;
              case 189:
                goto label_186;
              case 190:
                goto label_187;
              case 191:
                goto label_188;
              case 192:
                goto label_189;
              case 193:
                goto label_190;
              case 194:
                goto label_191;
              case 195:
                goto label_192;
              case 196:
              case 202:
              case 208:
              case 214:
              case 220:
              case 226:
              case 232:
                goto label_228;
              case 197:
                goto label_193;
              case 198:
                goto label_194;
              case 199:
                goto label_195;
              case 200:
                goto label_196;
              case 201:
                goto label_197;
              case 203:
                goto label_198;
              case 204:
                goto label_199;
              case 205:
                goto label_200;
              case 206:
                goto label_201;
              case 207:
                goto label_202;
              case 209:
                goto label_203;
              case 210:
                goto label_204;
              case 211:
                goto label_205;
              case 212:
                goto label_206;
              case 213:
                goto label_207;
              case 215:
                goto label_208;
              case 216:
                goto label_209;
              case 217:
                goto label_210;
              case 218:
                goto label_211;
              case 219:
                goto label_212;
              case 221:
                goto label_213;
              case 222:
                goto label_214;
              case 223:
                goto label_215;
              case 224:
                goto label_216;
              case 225:
                goto label_217;
              case 227:
                goto label_218;
              case 228:
                goto label_219;
              case 229:
                goto label_220;
              case 230:
                goto label_221;
              case 231:
                goto label_222;
              case 233:
                goto label_223;
              case 234:
                goto label_224;
              case 235:
                goto label_225;
              case 236:
                goto label_226;
              case 237:
                goto label_227;
              case 238:
                goto label_229;
              case 239:
                goto label_230;
              case 240:
                goto label_231;
              case 241:
                goto label_232;
              case 242:
                goto label_233;
              case 243:
                goto label_234;
              case 244:
                goto label_235;
              case 245:
                goto label_236;
              case 246:
                goto label_237;
              case 247:
                goto label_238;
              case 248:
                goto label_239;
              case 249:
                goto label_240;
              case 250:
                goto label_241;
              case 251:
                goto label_242;
              case 252:
                goto label_243;
              case 253:
                goto label_244;
              case 254:
                goto label_245;
              case (int) byte.MaxValue:
                goto label_246;
              case 256:
                goto label_247;
              case 257:
              case 263:
              case 269:
              case 275:
              case 281:
              case 287:
              case 293:
                goto label_283;
              case 258:
                goto label_248;
              case 259:
                goto label_249;
              case 260:
                goto label_250;
              case 261:
                goto label_251;
              case 262:
                goto label_252;
              case 264:
                goto label_253;
              case 265:
                goto label_254;
              case 266:
                goto label_255;
              case 267:
                goto label_256;
              case 268:
                goto label_257;
              case 270:
                goto label_258;
              case 271:
                goto label_259;
              case 272:
                goto label_260;
              case 273:
                goto label_261;
              case 274:
                goto label_262;
              case 276:
                goto label_263;
              case 277:
                goto label_264;
              case 278:
                goto label_265;
              case 279:
                goto label_266;
              case 280:
                goto label_267;
              case 282:
                goto label_268;
              case 283:
                goto label_269;
              case 284:
                goto label_270;
              case 285:
                goto label_271;
              case 286:
                goto label_272;
              case 288:
                goto label_273;
              case 289:
                goto label_274;
              case 290:
                goto label_275;
              case 291:
                goto label_276;
              case 292:
                goto label_277;
              case 294:
                goto label_278;
              case 295:
                goto label_279;
              case 296:
                goto label_280;
              case 297:
                goto label_281;
              case 298:
                goto label_282;
              case 299:
                goto label_284;
              case 300:
                goto label_285;
              case 301:
                goto label_286;
              case 302:
                goto label_287;
              case 303:
                goto label_288;
              case 304:
                goto label_289;
              case 305:
                goto label_290;
              case 306:
                goto label_291;
              case 307:
                goto label_292;
              case 308:
                goto label_293;
              case 309:
                goto label_294;
              case 310:
                goto label_295;
              case 311:
                goto label_296;
              case 312:
                goto label_297;
              case 313:
                goto label_298;
              case 314:
                goto label_299;
              case 315:
                goto label_300;
              case 316:
                goto label_301;
              case 317:
                goto label_302;
              case 318:
                goto label_308;
            }
            break;
        }
      }
      catch (Exception ex) when (ex is Exception & (uint) num1 > 0U & num2 == 0)
      {
        ProjectData.SetProjectError(ex);
        goto label_304;
      }
      throw ProjectData.CreateProjectError(-2146828237);
label_308:
      if (num2 != 0)
        ProjectData.ClearProjectError();
      return image1;
    }

    private void Button2_Click(object sender, EventArgs e) => this.Close();

    private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      if (!Validation.UserLogged)
      {
        int num1 = (int) Interaction.MsgBox((object) "User not logged in. Please log in first in order to download EPC", MsgBoxStyle.Critical);
      }
      else
      {
        object folderPath = (object) Environment.GetFolderPath(Environment.SpecialFolder.Personal);
        DirectoryInfo directoryInfo1 = new DirectoryInfo(Conversions.ToString(Operators.ConcatenateObject(folderPath, (object) "\\Stroma SAP 2012")));
        DirectoryInfo directoryInfo2 = new DirectoryInfo(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(folderPath, (object) "\\Stroma SAP 2012\\"), (object) SAP_Module.Proj.Name)));
        DirectoryInfo directoryInfo3;
        try
        {
          directoryInfo3 = new DirectoryInfo(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(folderPath, (object) "\\Stroma SAP 2012\\"), (object) SAP_Module.Proj.Name), (object) "\\"), (object) this.TreeSAP.SelectedNode.Parent.Text)));
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        if (directoryInfo3 == null)
        {
          int num2 = (int) Interaction.MsgBox((object) "Please select the correct file in order to download EPC", MsgBoxStyle.Critical);
        }
        else
        {
          if (!directoryInfo1.Exists)
            directoryInfo1.Create();
          if (!directoryInfo2.Exists)
            directoryInfo2.Create();
          if (!directoryInfo3.Exists)
            directoryInfo3.Create();
          string str1 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(folderPath, (object) "\\Stroma SAP 2012\\"), (object) SAP_Module.Proj.Name), (object) "\\"), (object) this.TreeSAP.SelectedNode.Parent.Text), (object) "\\EPC.pdf"));
          Functions.Access_Details();
          string str2 = "";
          SAPSoapClient sapSoapClient = new SAPSoapClient();
          try
          {
            if (Operators.CompareString(SAP_Module.Proj.Dwellings[this.TreeSAP.SelectedNode.Parent.Index].Address.Country, "Scotland", false) == 0)
            {
              if (DateTime.Compare(DateTime.Parse(this.LodgeDate.Text), Conversions.ToDate("01/07/2013")) < 0)
              {
                try
                {
                  str2 = sapSoapClient.DownLoadScotlandEPC(this.RRN.Text, Functions.TransactionID, Functions.Encrypt);
                }
                catch (Exception ex)
                {
                  ProjectData.SetProjectError(ex);
                  ProjectData.ClearProjectError();
                }
              }
              else
              {
                try
                {
                  str2 = sapSoapClient.DownLoad_lodgedEPC_In_Scotland(Validation.AssessorNO, this.RRN.Text, Functions.TransactionID, Functions.Encrypt);
                }
                catch (Exception ex)
                {
                  ProjectData.SetProjectError(ex);
                  int num3 = (int) Interaction.MsgBox((object) str2, MsgBoxStyle.Critical, (object) "FSAP 2012");
                  ProjectData.ClearProjectError();
                }
              }
              PDFFunctions.DecodeFile(str2, str1);
              EPC_Viewer epcViewer = new EPC_Viewer();
              epcViewer.EPCViewer.Navigate(str1);
              int num4 = (int) epcViewer.ShowDialog();
              epcViewer.Close();
            }
            else
              Process.Start(SAP_Module.CurrentEnvironment != SAP_Module.AppEnvironment.Uat ? "https://find-energy-certificate.digital.communities.gov.uk/energy-certificate/" + this.RRN.Text : "https://find-energy-certificate-integration.digital.communities.gov.uk/energy-certificate/" + this.RRN.Text);
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            Exception exception = ex;
            int num5 = (int) Interaction.MsgBox((object) (Information.Err().Description + " " + exception.Message), MsgBoxStyle.Critical);
            ProjectData.ClearProjectError();
          }
        }
      }
    }
  }
}
